// # FileSystem (Polyglot)

#if !INTERACTIVE
namespace Polyglot
#endif

module FileSystem =

    open Common

    // ## createTempDirectoryName

    let createTempDirectoryName () =
        let root =
            match System.Reflection.Assembly.GetEntryAssembly().GetName().Name with
            | assemblyName -> assemblyName

        System.IO.Path.GetTempPath ()
        </> $"!{root}"
        </> string (newGuidFromDateTime System.DateTime.Now)

    // ## createTempDirectory

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

    // ## waitForFileAccess

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
                    let getLocals () = $"path: {path} / message: {ex.Message} / {getLocals ()}"
                    trace Warn (fun () -> "waitForFileAccess") getLocals
                do! Async.Sleep 1
                return! loop (retry + 1)
        }
        loop 0

    // ## deleteDirectoryAsync

    let deleteDirectoryAsync path =
        let rec loop retry = async {
            try
                System.IO.Directory.Delete (path, true)
            with ex ->
                if retry % 100 = 0 then
                    let getLocals () = $"path: {path} / message: {ex.Message} / {getLocals ()}"
                    trace Warn (fun () -> "deleteDirectoryAsync") getLocals
                do! Async.Sleep 1
                return! loop (retry + 1)
        }
        loop 0

    // ## deleteFileAsync

    let deleteFileAsync path =
        let rec loop retry = async {
            try
                System.IO.File.Delete path
            with ex ->
                if retry % 100 = 0 then
                    let getLocals () = $"path: {path} / message: {ex.Message} / {getLocals ()}"
                    trace Warn (fun () -> "deleteFileAsync") getLocals
                do! Async.Sleep 1
                return! loop (retry + 1)
        }
        loop 0

    // ## moveFileAsync

    let moveFileAsync newPath oldPath =
        let rec loop retry = async {
            try
                System.IO.File.Move (oldPath, newPath)
            with ex ->
                if retry % 100 = 0 then
                    let getLocals () =
                        $"oldPath: {oldPath} / newPath: {newPath} / message: {ex.Message} / {getLocals ()}"
                    trace Warn (fun () -> "moveFileAsync") getLocals
                do! Async.Sleep 1
                return! loop (retry + 1)
        }
        loop 0

    // ## watch

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


    let watchWithFilter filter shouldReadContent path =
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
            path.Trim().Replace(fullPath, "").TrimStart [| '/'; '\\' |]

        let ticks () =
            System.DateTime.UtcNow.Ticks

        let readContent fullPath =
            if not shouldReadContent
            then None
            else
                try
                    waitForFileAccess fullPath |> Async.runWithTimeout 30000 |> ignore
                    System.IO.File.ReadAllText fullPath |> Some
                with ex ->
                    trace Error (fun () -> $"watchWithFilter / readContent / message: {ex.Message}") getLocals
                    None

        let changedStream =
            AsyncSeq.subscribeEvent
                watcher.Changed
                (fun event ->
                    ticks (),
                    [ FileSystemChange.Changed (getEventPath event.FullPath, readContent event.FullPath) ]
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
                    let content = readContent event.FullPath
                    ticks (), [
                        FileSystemChange.Created (path, content)
                        if OS.isWindows () then
                            FileSystemChange.Changed (path, content)
                    ])

        let renamedStream =
            AsyncSeq.subscribeEvent
                watcher.Renamed
                (fun event ->
                    ticks (), [
                        FileSystemChange.Renamed (
                            getEventPath event.OldFullPath,
                            (getEventPath event.FullPath, readContent event.FullPath)
                        )
                    ]
                )

        let errorStream =
            AsyncSeq.subscribeEvent
                watcher.Error
                (fun event -> ticks (), [ FileSystemChange.Error (event.GetException ()) ])

        let stream =
            [
                changedStream
                deletedStream
                createdStream
                renamedStream
                errorStream
            ]
            |> FSharp.Control.AsyncSeq.mergeAll
            |> FSharp.Control.AsyncSeq.map (fun (n, events) ->
                events
                |> List.fold
                    (fun (i, events) event ->
                        i + 1L,
                        (n + i, event) :: events)
                    (0L, [])
                |> snd
                |> List.rev
            )
            |> FSharp.Control.AsyncSeq.concatSeq

        let disposable =
            Object.newDisposable (fun () ->
                trace Debug (fun () -> "watchWithFilter / Disposing watch stream") getLocals
                watcher.EnableRaisingEvents <- false
                watcher.Dispose ()
            )

        stream, disposable

    let watch path =
        watchWithFilter
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
