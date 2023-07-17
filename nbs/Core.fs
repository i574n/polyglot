let nl = Environment.NewLine

module String =
    let trim (input : string) =
        input.Trim ()

type TicksGuid = System.Guid
type DateTimeGuid = System.Guid

let inline dateTimeGuidFromDateTime (guid: Guid) (dateTime: DateTime) =
    let guid = guid |> string
    let prefix = dateTime.ToString "yyyyMMdd-HHmm-ssff-ffff-f"
    DateTimeGuid $"{prefix}{guid.[prefix.Length..]}"

let inline dateTimeFromGuid (dateTimeGuid: DateTimeGuid) =
    let dateTimeGuid = dateTimeGuid |> string
    System.DateTime.ParseExact (dateTimeGuid.[..24].Replace ("-", ""), "yyyyMMddHHmmssfffffff", null)

let inline ticksGuidFromTicks (guid: Guid) (ticks: int64) =
    let guid = guid |> string
    let ticks = (ticks |> string).PadLeft (18, '0')
    TicksGuid $"{ticks.[0..7]}-{ticks.[8..11]}-{ticks.[12..15]}-{ticks.[16..17]}{guid.[21..]}"

let inline ticksFromGuid (ticksGuid: DateTimeGuid) =
    let ticks = ticksGuid |> string
    int64 $"{ticks.[0..7]}{ticks.[9..12]}{ticks.[14..17]}{ticks.[19..20]}"

let inline newGuidFromDateTime (dateTime: DateTime) =
    let guid = System.Guid.NewGuid ()
    dateTimeGuidFromDateTime guid dateTime

let inline newGuidFromTicks (ticks: int64) =
    let guid = System.Guid.NewGuid ()
    ticksGuidFromTicks guid ticks

let inline (</>) a b = System.IO.Path.Combine (a, b)

type LogLevel =
    | Verbose
    | Debug
    | Info
    | Warn
    | Error

let inline getLocals () = ""

let mutable logEnabled = true
let mutable logCount = 0
let mutable logLevel = Verbose


let log level fn getLocals =
    if logEnabled && level >= logLevel then
        logCount <- logCount + 1
        let time = System.DateTime.Now.ToString "HH:mm:ss"
        System.Console.WriteLine ($"{time} #{logCount} [{level}] {fn ()} / {getLocals ()}".TrimEnd [| ' '; '/' |])

let withLog enabled fn =
    let oldLogEnabled = logEnabled
    try
        logEnabled <- enabled
        fn ()
    finally
        logEnabled <- oldLogEnabled

let withLogEnabled fn =
    withLog true fn

let withLogDisabled fn =
    withLog false fn

let withLogLevel level fn =
    let oldLogLevel = logLevel
    try
        logLevel <- level
        fn ()
    finally
        logLevel <- oldLogLevel

module OS =
    let isWindows () =
        System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform System.Runtime.InteropServices.OSPlatform.Windows

module Object =
    let inline newDisposable fn =
        { new System.IDisposable with
            member _.Dispose () = fn ()
        }
