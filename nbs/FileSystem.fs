#if !INTERACTIVE
namespace Polyglot
#endif

module FileSystem =

    open Common

    /// ## Operators

    module Operators =
        let inline (</>) a b =
            System.IO.Path.Combine (a, b)

    open Operators

    /// ## createTempDirectoryName

    let inline createTempDirectoryName () =
        let root = System.Reflection.Assembly.GetEntryAssembly().GetName().Name

        System.IO.Path.GetTempPath ()
        </> $"!{root}"
        </> string (newGuidFromDateTime System.DateTime.Now)

    /// ## createTempDirectory

    let inline createTempDirectory () =
        let tempFolder = createTempDirectoryName ()
        let result = System.IO.Directory.CreateDirectory tempFolder

        let getLocals () =
            $"tempFolder: {tempFolder} / result: {({|
                Exists = result.Exists
                CreationTime = result.CreationTime
            |})} {getLocals ()}"

        trace Debug (fun () -> "createTempDirectory") getLocals

        tempFolder

    /// ## getSourceDirectory

    let getSourceDirectory =
        fun () -> __SOURCE_DIRECTORY__
        |> memoize

    /// ## findParent

    let inline findParent name isFile rootDir =
        let rec loop dir =
            if dir </> name |> (if isFile then System.IO.File.Exists else System.IO.Directory.Exists)
            then dir
            else
                dir
                |> System.IO.Directory.GetParent
                |> function
                    | null -> failwith $"""No parent for {if isFile then "file" else "dir"} '{name}' at '{rootDir}'"""
                    | parent -> parent.FullName |> loop
        loop rootDir

    /// ## readAllTextAsync

    let inline readAllTextAsync path =
        path |> System.IO.File.ReadAllTextAsync |> Async.AwaitTask

    /// ## fileExistsContent

    let inline fileExistsContent path content = async {
        if path |> System.IO.File.Exists |> not
        then return false
        else
            let! existingContent = path |> readAllTextAsync
            return content = existingContent
    }

    /// ## writeAllTextAsync

    let inline writeAllTextAsync path contents =
        System.IO.File.WriteAllTextAsync (path, contents) |> Async.AwaitTask

    /// ## writeAllTextExists

    let inline writeAllTextExists path contents = async {
        let! exists = contents |> fileExistsContent path
        if not exists
        then do! contents |> writeAllTextAsync path
    }

    /// ## waitForFileAccess

    let inline waitForFileAccess access path =
        let fileAccess, fileShare =
            access
            |> Option.defaultValue (System.IO.FileAccess.ReadWrite, System.IO.FileShare.Read)

        let rec loop retry = async {
            try
                use _ = new System.IO.FileStream (
                    path,
                    System.IO.FileMode.Open,
                    fileAccess,
                    fileShare
                )
                return retry
            with ex ->
                if retry % 100 = 0 then
                    let getLocals () = $"path: {path} / ex: {ex |> printException} / {getLocals ()}"
                    trace Debug (fun () -> "waitForFileAccess") getLocals
                do! Async.Sleep 10
                return! loop (retry + 1)
        }
        loop 0

    /// ## readAllTextRetryAsync

    let inline readAllTextRetryAsync fullPath =
        let rec loop retry = async {
            try
                if retry > 0
                then do!
                    fullPath
                    |> waitForFileAccess (Some (
                        System.IO.FileAccess.Read,
                        System.IO.FileShare.Read
                    ))
                    |> Async.runWithTimeoutAsync 1000
                    |> Async.Ignore
                return! fullPath |> readAllTextAsync |> Async.map Some
            with ex ->
                let getLocals () = $"retry: {retry} / ex: {ex |> printException} / {getLocals ()}"
                trace Debug (fun () -> $"watchWithFilter / readContent") getLocals
                if retry = 0
                then return! loop (retry + 1)
                else return None
        }
        loop 0

    /// ## deleteDirectoryAsync

    let inline deleteDirectoryAsync path =
        let rec loop retry = async {
            try
                System.IO.Directory.Delete (path, true)
                return retry
            with ex ->
                if retry % 100 = 0 then
                    let getLocals () = $"path: {path} / ex: {ex |> printException} / {getLocals ()}"
                    trace Debug (fun () -> "deleteDirectoryAsync") getLocals
                do! Async.Sleep 10
                return! loop (retry + 1)
        }
        loop 0

    /// ## deleteFileAsync

    let inline deleteFileAsync path =
        let rec loop retry = async {
            try
                System.IO.File.Delete path
                return retry
            with ex ->
                if retry % 100 = 0 then
                    let getLocals () = $"path: {path} / ex: {ex |> printException} / {getLocals ()}"
                    trace Warning (fun () -> "deleteFileAsync") getLocals
                do! Async.Sleep 10
                return! loop (retry + 1)
        }
        loop 0

    /// ## moveFileAsync

    let inline moveFileAsync newPath oldPath =
        let rec loop retry = async {
            try
                System.IO.File.Move (oldPath, newPath)
                return retry
            with ex ->
                if retry % 100 = 0 then
                    let getLocals () =
                        $"oldPath: {oldPath} / newPath: {newPath} / ex: {ex |> printException} / {getLocals ()}"
                    trace Warning (fun () -> "moveFileAsync") getLocals
                do! Async.Sleep 10
                return! loop (retry + 1)
        }
        loop 0

    /// ## watchDirectory

    [<RequireQualifiedAccess>]
    type FileSystemChangeType =
        | Failure
        | Changed
        | Created
        | Deleted
        | Renamed

    [<RequireQualifiedAccess>]
    type FileSystemChange =
        | Failure of exn: exn
        | Changed of path: string * content: string option
        | Created of path: string * content: string option
        | Deleted of path: string
        | Renamed of oldPath: string * (string * string option)


    let inline watchDirectoryWithFilter filter shouldReadContent path =
        let fullPath = path |> System.IO.Path.GetFullPath
        let getLocals () = $"fullPath: {fullPath} / filter: {filter} / {getLocals ()}"

        let watcher =
            new System.IO.FileSystemWatcher (
                Path = fullPath,
                NotifyFilter = filter,
                EnableRaisingEvents = true,
                IncludeSubdirectories = true
            )

        let inline getEventPath (path : string) =
            path |> String.trim |> String.replace fullPath "" |> String.trimStart [| '/'; '\\' |]

        let inline ticks () =
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

        let failureStream =
            AsyncSeq.subscribeEvent
                watcher.Error
                (fun event -> ticks (), [ FileSystemChange.Failure (event.GetException ()) ])

        let stream =
            [
                changedStream
                deletedStream
                createdStream
                renamedStream
                failureStream
            ]
            |> FSharp.Control.AsyncSeq.mergeAll
            |> FSharp.Control.AsyncSeq.map (fun (t, events) ->
                events
                |> List.fold
                    (fun (i, events) event ->
                        i + 1L,
                        (t + i, event) :: events)
                    (0L, [])
                |> snd
                |> List.rev
            )
            |> FSharp.Control.AsyncSeq.concatSeq
            |> FSharp.Control.AsyncSeq.mapAsyncParallel (fun (t, event) -> async {
                match shouldReadContent event, event with
                | true, FileSystemChange.Changed (path, _) ->
                    do! Async.Sleep 5
                    let! content = fullPath </> path |> readAllTextRetryAsync
                    return t, FileSystemChange.Changed (path, content)
                | true, FileSystemChange.Created (path, _) ->
                    do! Async.Sleep 5
                    let! content = fullPath </> path |> readAllTextRetryAsync
                    return t, FileSystemChange.Created (path, content)
                | true, FileSystemChange.Renamed (oldPath, (newPath, _)) ->
                    let! content = fullPath </> newPath |> readAllTextRetryAsync
                    return t, FileSystemChange.Renamed (oldPath, (newPath, content))
                | _ -> return t, event
            })

        let disposable =
            newDisposable (fun () ->
                trace Debug (fun () -> "watchWithFilter / Disposing watch stream") getLocals
                watcher.EnableRaisingEvents <- false
                watcher.Dispose ()
            )

        stream, disposable

    let inline watchDirectory path =
        watchDirectoryWithFilter
            (System.IO.NotifyFilters.FileName
            // ||| System.IO.NotifyFilters.DirectoryName
            // ||| System.IO.NotifyFilters.Attributes
            //// ||| System.IO.NotifyFilters.Size
            ||| System.IO.NotifyFilters.LastWrite
            //// ||| System.IO.NotifyFilters.LastAccess
            // ||| System.IO.NotifyFilters.CreationTime
            // ||| System.IO.NotifyFilters.Security
            )
            path
