#if !INTERACTIVE
namespace Polyglot
#endif

module FileSystem =

    open Common

    /// ## Operators

    let inline (</>) a b = System.IO.Path.Combine (a, b)

    /// ## createTempDirectoryName

    let createTempDirectoryName () =
        let root =
            match System.Reflection.Assembly.GetEntryAssembly().GetName().Name with
            | assemblyName -> assemblyName

        System.IO.Path.GetTempPath ()
        </> $"!{root}"
        </> string (newGuidFromDateTime System.DateTime.Now)

    /// ## createTempDirectory

    let createTempDirectory () =
        let tempFolder = createTempDirectoryName ()
        let result = System.IO.Directory.CreateDirectory tempFolder

        let getLocals () =
            $"tempFolder: {tempFolder} / result: {({|
                Exists = result.Exists
                CreationTime = result.CreationTime
            |})} {getLocals ()}"

        trace Debug (fun () -> "createTempDirectory") getLocals

        tempFolder

    /// ## waitForFileAccess

    let waitForFileAccess path =
        let rec loop retry = async {
            try
                use _ = new System.IO.FileStream (
                    path,
                    System.IO.FileMode.Open,
                    System.IO.FileAccess.ReadWrite,
                    System.IO.FileShare.None
                )
                return retry
            with ex ->
                if retry % 100 = 0 then
                    let getLocals () = $"path: {path} / ex: {ex |> printException} / {getLocals ()}"
                    trace Warn (fun () -> "waitForFileAccess") getLocals
                do! Async.Sleep 10
                return! loop (retry + 1)
        }
        loop 0

    /// ## deleteDirectoryAsync

    let deleteDirectoryAsync path =
        let rec loop retry = async {
            try
                System.IO.Directory.Delete (path, true)
            with ex ->
                if retry % 100 = 0 then
                    let getLocals () = $"path: {path} / ex: {ex |> printException} / {getLocals ()}"
                    trace Warn (fun () -> "deleteDirectoryAsync") getLocals
                do! Async.Sleep 10
                return! loop (retry + 1)
        }
        loop 0

    /// ## deleteFileAsync

    let deleteFileAsync path =
        let rec loop retry = async {
            try
                System.IO.File.Delete path
            with ex ->
                if retry % 100 = 0 then
                    let getLocals () = $"path: {path} / ex: {ex |> printException} / {getLocals ()}"
                    trace Warn (fun () -> "deleteFileAsync") getLocals
                do! Async.Sleep 10
                return! loop (retry + 1)
        }
        loop 0

    /// ## moveFileAsync

    let moveFileAsync newPath oldPath =
        let rec loop retry = async {
            try
                System.IO.File.Move (oldPath, newPath)
            with ex ->
                if retry % 100 = 0 then
                    let getLocals () =
                        $"oldPath: {oldPath} / newPath: {newPath} / ex: {ex |> printException} / {getLocals ()}"
                    trace Warn (fun () -> "moveFileAsync") getLocals
                do! Async.Sleep 10
                return! loop (retry + 1)
        }
        loop 0

    /// ## watchDirectory

    [<RequireQualifiedAccess>]
    type FileSystemChangeType =
        | Error
        | Changed
        | Created
        | Deleted
        | Renamed

    [<RequireQualifiedAccess>]
    type FileSystemChange =
        | Error of exn: exn
        | Changed of path: string * content: string option
        | Created of path: string * content: string option
        | Deleted of path: string
        | Renamed of oldPath: string * (string * string option)


    let watchDirectoryWithFilter filter shouldReadContent path =
        let fullPath = System.IO.Path.GetFullPath path
        let getLocals () = $"fullPath: {fullPath} / filter: {filter} / {getLocals ()}"

        let watcher =
            new System.IO.FileSystemWatcher (
                Path = fullPath,
                NotifyFilter = filter,
                EnableRaisingEvents = true,
                IncludeSubdirectories = true
            )

        let getEventPath (path : string) =
            path |> String.trim |> String.replace fullPath "" |> String.trimStart [| '/'; '\\' |]

        let ticks () =
            System.DateTime.UtcNow.Ticks

        let changedStream =
            AsyncSeq.subscribeEvent
                watcher.Changed
                (fun event ->
                    ticks (),
                    [ FileSystemChange.Changed (getEventPath event.FullPath, None) ]
                )

        let deletedStream =
            AsyncSeq.subscribeEvent
                watcher.Deleted
                (fun event ->
                    ticks (),
                    [ FileSystemChange.Deleted (getEventPath event.FullPath) ]
                )

        let createdStream =
            AsyncSeq.subscribeEvent
                watcher.Created
                (fun event ->
                    let path = getEventPath event.FullPath
                    ticks (), [
                        FileSystemChange.Created (path, None)
                        if Runtime.isWindows () then
                            FileSystemChange.Changed (path, None)
                    ])

        let renamedStream =
            AsyncSeq.subscribeEvent
                watcher.Renamed
                (fun event ->
                    ticks (), [
                        FileSystemChange.Renamed (
                            getEventPath event.OldFullPath,
                            (getEventPath event.FullPath, None)
                        )
                    ]
                )

        let errorStream =
            AsyncSeq.subscribeEvent
                watcher.Error
                (fun event -> ticks (), [ FileSystemChange.Error (event.GetException ()) ])


        let readContent fullPath = async {
            try
                let! _ = waitForFileAccess fullPath |> Async.runWithTimeoutAsync 30000
                return System.IO.File.ReadAllText fullPath |> Some
            with ex ->
                trace Error (fun () -> $"watchWithFilter / readContent / ex: {ex |> printException}") getLocals
                return None
        }

        let stream =
            [
                changedStream
                deletedStream
                createdStream
                renamedStream
                errorStream
            ]
            |> FSharp.Control.AsyncSeq.mergeAll
            |> FSharp.Control.AsyncSeq.mapAsync (fun (n, events) -> async {
                let! events =
                    if not shouldReadContent
                    then events |> Async.init
                    else 
                        events
                        |> List.map (fun event ->
                            match event with
                            | FileSystemChange.Changed (path, _) ->
                                async {
                                    let! content = fullPath </> path |> readContent
                                    return FileSystemChange.Changed (path, content)
                                }
                            | FileSystemChange.Created (path, _) ->
                                async {
                                    let! content = fullPath </> path |> readContent
                                    return FileSystemChange.Created (path, content)
                                }
                            | FileSystemChange.Renamed (oldPath, (newPath, _)) ->
                                async {
                                    let! content = fullPath </> newPath |> readContent
                                    return FileSystemChange.Renamed (oldPath, (newPath, content))
                                }
                            | _ -> event |> Async.init
                        )
                        |> Async.Parallel
                        |> Async.map Array.toList

                return
                    events
                    |> List.fold
                        (fun (i, events) event ->
                            i + 1L,
                            (n + i, event) :: events)
                        (0L, [])
                    |> snd
                    |> List.rev
            })
            |> FSharp.Control.AsyncSeq.concatSeq

        let disposable =
            newDisposable (fun () ->
                trace Debug (fun () -> "watchWithFilter / Disposing watch stream") getLocals
                watcher.EnableRaisingEvents <- false
                watcher.Dispose ()
            )

        stream, disposable

    let watchDirectory path =
        watchDirectoryWithFilter
            (System.IO.NotifyFilters.Attributes
            ||| System.IO.NotifyFilters.CreationTime
            ||| System.IO.NotifyFilters.DirectoryName
            ||| System.IO.NotifyFilters.FileName
            //  ||| System.IO.NotifyFilters.LastAccess
            //  ||| System.IO.NotifyFilters.LastWrite
            ||| System.IO.NotifyFilters.Security
            //  ||| System.IO.NotifyFilters.Size
            )
            path