namespace clr

// let rec closure0 () () : int32 =
//     let v0 : string = "clr"
//     System.Console.WriteLine v0
//     -1
// let v0 : (unit -> int32) = closure0()
// ()


module Core =


    [<AutoOpen>]
    module CoreMagic =
        type TicksGuid = System.Guid


    module Guid =
        let inline ticksFromGuid (ticksGuid: TicksGuid) =
            let ticks = string ticksGuid
            int64 $"{ticks.[0..7]}{ticks.[9..12]}{ticks.[14..17]}{ticks.[19..20]}"

        let inline newGuidFromTicks (ticks: int64) =
            let guid = System.Guid.NewGuid () |> string
            let ticks = string ticks
            TicksGuid $"{ticks.[0..7]}-{ticks.[8..11]}-{ticks.[12..15]}-{ticks.[16..17]}{guid.[21..]}"

        let inline newTicksGuid () = newGuidFromTicks System.DateTime.Now.Ticks

//     let inline (|Valid|Invalid|) (str: string) =
//         match Guid.TryParse str with
//         | true, guid -> Valid guid
//         | _ -> Invalid


[<AutoOpen>]
module CoreMagic =
    let inline getLocals () = ""


[<AutoOpen>]
module Operators =
    let inline (</>) a b = System.IO.Path.Combine (a, b)


module Object =
    let inline newDisposable fn =
        { new System.IDisposable with
            member _.Dispose () = fn ()
        }


module Logger =
    let mutable count = 0
    let logError fn getLocals =
        if true then
            count <- count + 1
            Serilog.Log.Error $"{fn ()} {getLocals ()}"

    let logWarning fn getLocals =
        if true then
            count <- count + 1
            Serilog.Log.Warning $"{count}. {fn ()} {getLocals ()}"

    let logInfo fn getLocals =
        if true then
            count <- count + 1
            Serilog.Log.Information $"{count}. {fn ()} {getLocals ()}"

    let logDebug fn getLocals =
        if true then
            count <- count + 1
            Serilog.Log.Debug $"{count}. {fn ()} {getLocals ()}"

    let logTrace fn getLocals =
        if true then
            count <- count + 1
            Serilog.Log.Verbose $"{count}. {fn ()} {getLocals ()}"

    let seq x =
        let items = x |> Seq.map string |> String.concat ","
        $"[{items}]"

    let init () =
        let conf =
            Serilog.LoggerConfiguration()
                .Enrich.FromLogContext()
                .MinimumLevel.Verbose()
        let conf =
            Serilog.Sinks.SpectreConsole.SpectreConsoleSinkExtensions.SpectreConsole (
                conf.WriteTo,
                "{Timestamp:HH:mm:ss} [{Level:u4}] {Message:lj}{NewLine}{Exception}",
                minLevel = Serilog.Events.LogEventLevel.Verbose
            )

        Serilog.Log.Logger <- conf.CreateLogger ()

        logInfo (fun () -> "Logger.init") getLocals

module OS =
    let isWindows () =
        System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform System.Runtime.InteropServices.OSPlatform.Windows


module AsyncSeq =
    let subscribeEvent (event: IEvent<'H, 'A>) map =
        let x = System.Reactive.Linq.Observable.FromEventPattern<'H, 'A>(event.AddHandler, event.RemoveHandler)
        System.Reactive.Linq.Observable.Select (x, fun event -> System.DateTime.Now.Ticks, (map event.EventArgs))
        |> FSharp.Control.AsyncSeq.ofObservableBuffered


module FileSystem =
    [<RequireQualifiedAccess>]
    type FileSystemChangeType =
        | Error
        | Changed
        | Created
        | Deleted
        | Renamed

    type FileSystemChange =
        | Error of exn: exn
        | Changed of path: string
        | Created of path: string
        | Deleted of path: string
        | Renamed of oldPath: string * path: string


    let watchWithFilter path filter =
        let fullPath = System.IO.Path.GetFullPath path
        let getLocals () = $"fullPath={fullPath} {getLocals ()}"

        let watcher =
            new System.IO.FileSystemWatcher (
                Path = fullPath,
                NotifyFilter = filter,
                EnableRaisingEvents = true,
                IncludeSubdirectories = true
            )

        let getEventPath (path: string) = path.Trim().Replace (fullPath, "")

        let changedStream =
            AsyncSeq.subscribeEvent
                watcher.Changed
                (fun event -> [ FileSystemChange.Changed (getEventPath event.FullPath) ])

        let deletedStream =
            AsyncSeq.subscribeEvent
                watcher.Deleted
                (fun event -> [ FileSystemChange.Deleted (getEventPath event.FullPath) ])

        let createdStream : FSharp.Control.AsyncSeq<int64 * FileSystemChange list> =
            AsyncSeq.subscribeEvent
                watcher.Created
                (fun event ->
                    let path = getEventPath event.FullPath
                    [
                        FileSystemChange.Created path
                        if OS.isWindows () then
                            FileSystemChange.Changed path
                    ])

        let renamedStream =
            AsyncSeq.subscribeEvent
                watcher.Renamed
                (fun event -> [ FileSystemChange.Renamed (getEventPath event.OldFullPath, getEventPath event.FullPath) ])

        let errorStream =
            AsyncSeq.subscribeEvent watcher.Error (fun event -> [ FileSystemChange.Error (event.GetException ()) ])

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
            Object.newDisposable
                (fun () ->
                    Logger.logDebug (fun () -> "Disposing watch stream") getLocals
                    watcher.EnableRaisingEvents <- false
                    watcher.Dispose ())

        stream, disposable

    let watch path =
        watchWithFilter
            path
            (System.IO.NotifyFilters.Attributes
             ||| System.IO.NotifyFilters.CreationTime
             ||| System.IO.NotifyFilters.DirectoryName
             ||| System.IO.NotifyFilters.FileName
            //  ||| System.IO.NotifyFilters.LastAccess
            //  ||| System.IO.NotifyFilters.LastWrite
             ||| System.IO.NotifyFilters.Security
            //  ||| System.IO.NotifyFilters.Size
             )

    let createNewGuidTempDirectory () =
        let tempFolder =
            System.IO.Path.GetTempPath ()
            </> System.Reflection.Assembly.GetEntryAssembly().GetName().Name
            </> string (Core.Guid.newTicksGuid ())

        let result = System.IO.Directory.CreateDirectory tempFolder

        let getLocals () =
            $"tempFolder={tempFolder} result.Exists={result.Exists} {getLocals ()}"

        Logger.logDebug (fun () -> "FileSystem.createNewGuidTempDirectory") getLocals

        tempFolder



// // open System
// open System.IO
// // open System.Threading.Tasks
// open FSharp.Control
// open System.Reactive.Linq


module Async =
//     let startAsTask ct fn : Task =
//         upcast Async.StartAsTask (fn, cancellationToken = ct)

//     let map fn op =
//         async {
//             let! x = op
//             let value = fn x
//             return value
//         }

    let runWithTimeout timeout fn =
        try
            Async.RunSynchronously (fn, timeout)
        with
        | :? System.TimeoutException -> printfn $"Async timeout reached ({timeout})"
        | e -> raise e

//     let initAsyncSeq op = AsyncSeq.initAsync 1L (fun _ -> op)


// module Task =
//     let ignore (t: Task<unit []>) =
//         task {
//             let! _tasks = t
//             ()
//         }


// module Old =


//     module FileSystem =
//         open FileSystem
//         type FileSystemChange with
//             static member inline Path event =
//                 match event with
//                 | Error _ -> None, None
//                 | Changed path -> None, Some path
//                 | Created path -> None, Some path
//                 | Deleted path -> None, Some path
//                 | Renamed (oldPath, path) -> Some oldPath, Some path

//             static member inline Type event =
//                 match event with
//                 | Error _ -> FileSystemChangeType.Error
//                 | Changed _ -> FileSystemChangeType.Changed
//                 | Created _ -> FileSystemChangeType.Created
//                 | Deleted _ -> FileSystemChangeType.Deleted
//                 | Renamed _ -> FileSystemChangeType.Renamed



        // let rec private waitForStream path =
        //     async {
        //         try
        //             return new FileStream (path, FileMode.Open, FileAccess.Write)
        //         with
        //         | _ ->
        //             let getLocals () = $"path={path} {getLocals ()}"
        //             Logger.logWarning (fun () -> "Error opening file for writing. Waiting...") getLocals
        //             do! Async.Sleep (TimeSpan.FromSeconds 1.)
        //             return! waitForStream path
        //     }




// open System
// open System.Collections.Generic
// open Microsoft.FSharp.Reflection



// module DateTime =
//     let inline ticksDiff ticks =
//         (TimeSpan (DateTime.Now.Ticks - ticks))
//             .TotalMilliseconds


// module Enum =
//     let inline ToList<'T> () =
//         (Enum.GetValues typeof<'T> :?> 'T [])
//         |> Array.toList

//     let inline name<'T> (value: 'T) = Enum.GetName (typeof<'T>, value)


// module Function =
//     let inline memoizeLazy fn =
//         let result = lazy (fn ())
//         fun () -> result.Value




// module BaseModel =
//     type Username = Username of alias: string
//     type Color = Color of hex: string
//     type StoreRoot = StoreRoot of name: string
//     type Collection = Collection of collection: string
//     type FileId = FileId of guid: TicksGuid
//     type DeviceId = DeviceId of guid: TicksGuid
//     type Ping = Ping of ticksText: string

//     type Username with
//         static member inline Value (Username username) = username

//     type StoreRoot with
//         static member inline Value (StoreRoot name) = name

//     type Collection with
//         static member inline Value (Collection collection) = collection

//     type Color with
//         static member inline Value (Color hex) = hex
//         static member inline Default = Color "#000000"

//     type FileId with
//         static member inline NewId () = FileId (Guid.newTicksGuid ())
//         static member inline Value (FileId guid) = guid

//     type DeviceId with
//         static member inline NewId () = DeviceId (Guid.newTicksGuid ())
//         static member inline Value (DeviceId guid) = guid

//     type Ping with
//         static member inline Value (Ping ticks) = int64 ticks





// module ListIter =
//     let inline length (target: ^X when ^X: (member length : int)) = (^X: (member length : int) target)

//     let inline item (target: ^X when ^X: (member item : int -> ^Y)) (index: int) =
//         (^X: (member item : int -> ^Y) target, index)


// module Map =
//     let inline singleton key value =
//         key, value |> List.singleton |> Map.ofSeq

//     let inline keys (source: Map<'Key, 'T>) : seq<'Key> = source |> Map.toSeq |> Seq.map fst

//     let inline values (source: Map<'Key, 'T>) : seq<'T> = source |> Map.toSeq |> Seq.map snd

//     let inline unionWith combiner (source1: Map<'Key, 'Value>) (source2: Map<'Key, 'Value>) =
//         Map.fold
//             (fun m k v' ->
//                 Map.add
//                     k
//                     (match m |> Map.tryFind k with
//                      | Some v -> combiner v v'
//                      | None -> v')
//                     m)
//             source1
//             source2

//     let inline union (source: Map<'Key, 'T>) (altSource: Map<'Key, 'T>) =
//         unionWith (fun x _ -> x) source altSource

//     let inline mapKeys f (x: Map<'Key, 'T>) =
//         x |> Map.toSeq |> Seq.map f |> Map.ofSeq

//     let inline choose fn map =
//         map
//         |> Seq.choose (fun (KeyValue (k, v)) -> fn (k, v))
//         |> Map.ofSeq

//     let inline mapValues f (x: Map<'Key, 'T>) = Map.map (fun _ -> f) x

//     let inline tryFindDictionary key (map: Dictionary<_, _>) =
//         match map.TryGetValue key with
//         | true, value -> Some value
//         | _ -> None


// module Object =
// //     let inline compare<'T> (a: 'T) (b: 'T) = (unbox a) = (unbox b)


// module Option =
//     let inline ofObjUnboxFn<'T> (getValue: unit -> 'T) =
//         getValue ()
//         |> unbox
//         |> Option.ofObj
//         |> Option.map (fun _ -> getValue ())

//     let inline ofObjUnbox<'T> (value: 'T) =
//         // ofObjUnboxFn (fun () -> value)
//         value
//         |> unbox
//         |> Option.ofObj
//         |> Option.map (fun _ -> value)


// module Reflection =
//     let inline unionCases<'T> =
//         FSharpType.GetUnionCases typeof<'T>
//         |> Array.toList
//         |> List.map (fun unionCaseInfo -> FSharpValue.MakeUnion (unionCaseInfo, [||]) :?> 'T)


// module Seq =
//     let inline intersperse sep list =
//         seq {
//             let mutable notFirst = false

//             for element in list do
//                 if notFirst then yield sep

//                 yield element
//                 notFirst <- true
//         }

//     let inline ofItems items =
//         seq {
//             for i = 0 to (ListIter.length items) - 1 do
//                 yield (ListIter.item items) i
//         }

//     let inline random items =
//         let len = items |> Seq.length
//         items |> Seq.item (Random().Next (0, len))


// module List =
//     let inline removeAt index list =
//         list
//         |> List.indexed
//         |> List.filter (fun (i, _) -> i <> index)
//         |> List.map snd

//     let inline intersperse element source : list<'T> =
//         source
//         |> List.toSeq
//         |> Seq.intersperse element
//         |> Seq.toList


// module String =
//     let inline split (separator: string) (str: string) = str.Split separator
//     let inline substring startIndex length (str: string) = str.Substring (startIndex, length)
//     let inline replace (a: string) (b: string) (str: string) = str.Replace (a, b)
//     let inline substringFrom startIndex (str: string) = str.Substring startIndex

//     let inline (|Valid|Whitespace|Null|) (str: string) =
//         match str with
//         | null -> Null
//         | str when String.IsNullOrWhiteSpace str -> Whitespace
//         | str -> Valid str

//     let inline (|Invalid|_|) (str: string) =
//         match str with
//         | Whitespace
//         | Null -> Some Invalid
//         | _ -> None





// open System
// open System.Reflection
// open Argu


// module Cli =
//     let parseArgs<'T when 'T :> IArgParserTemplate> args =
//         let errorHandler =
//             ProcessExiter (
//                 colorizer =
//                     function
//                     | ErrorCode.HelpText -> None
//                     | _ -> Some ConsoleColor.Red
//             )

//         let parser =
//             ArgumentParser.Create<'T> (
//                 programName =
//                     Assembly.GetEntryAssembly().GetName().Name
//                     + ".exe",
//                 errorHandler = errorHandler
//             )

//         parser.ParseCommandLine args
