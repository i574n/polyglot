/// # Common (Polyglot)

#if !INTERACTIVE
namespace Polyglot
#endif

module Common =

    let nl = System.Environment.NewLine

    let cons head tail = head :: tail

    module String =
        let endsWith (value : string) (input : string) =
            input.EndsWith value

        let padLeft totalWidth paddingChar (input : string) =
            input.PadLeft (totalWidth, paddingChar)

        let replace (oldValue : string) (newValue : string) (input : string) =
            input.Replace (oldValue, newValue)

        let split separator (input : string) =
            input.Split separator

        let splitString (separator : string array) (input : string) =
            input.Split (separator, System.StringSplitOptions.None)

        let startsWith (value : string) (input : string) =
            input.StartsWith value

        let trim (input : string) =
            input.Trim ()

        let trimEnd (trimChars : char array) (input : string) =
            input.TrimEnd trimChars

        let trimStart (trimChars : char array) (input : string) =
            input.TrimStart trimChars

    type TicksGuid = System.Guid
    type DateTimeGuid = System.Guid

    /// ## dateTimeGuidFromDateTime

    let inline dateTimeGuidFromDateTime (guid: System.Guid) (dateTime: System.DateTime) =
        let guid = guid |> string
        let prefix = dateTime.ToString "yyyyMMdd-HHmm-ssff-ffff-f"
        DateTimeGuid $"{prefix}{guid.[prefix.Length..]}"

    /// ## dateTimeFromGuid

    let inline dateTimeFromGuid (dateTimeGuid: DateTimeGuid) =
        let dateTimeGuid = dateTimeGuid |> string
        System.DateTime.ParseExact (dateTimeGuid.[..24] |> String.replace "-" "", "yyyyMMddHHmmssfffffff", null)

    /// ## ticksGuidFromTicks

    let inline ticksGuidFromTicks (guid: System.Guid) (ticks: int64) =
        let guid = guid |> string
        let ticks = ticks |> string |> String.padLeft 18 '0'
        TicksGuid $"{ticks.[0..7]}-{ticks.[8..11]}-{ticks.[12..15]}-{ticks.[16..17]}{guid.[21..]}"

    /// ## ticksFromGuid

    let inline ticksFromGuid (ticksGuid: DateTimeGuid) =
        let ticks = ticksGuid |> string
        int64 $"{ticks.[0..7]}{ticks.[9..12]}{ticks.[14..17]}{ticks.[19..20]}"

    /// ## newGuidFromDateTime

    let inline newGuidFromDateTime (dateTime: System.DateTime) =
        let guid = System.Guid.NewGuid ()
        dateTimeGuidFromDateTime guid dateTime

    /// ## newGuidFromTicks

    let inline newGuidFromTicks (ticks: int64) =
        let guid = System.Guid.NewGuid ()
        ticksGuidFromTicks guid ticks

    /// ## trace

    type TraceLevel =
        | Verbose
        | Debug
        | Info
        | Warn
        | Error

    let inline getLocals () = ""

    let mutable traceEnabled = true
    let mutable traceCount = 0
    let mutable traceLevel = Verbose


    let trace level fn getLocals =
        if traceEnabled && level >= traceLevel then
            traceCount <- traceCount + 1
            let time = System.DateTime.Now.ToString "HH:mm:ss"
            $"{time} #{traceCount} [{level}] {fn ()} / {getLocals ()}"
            |> String.trimEnd [| ' '; '/' |]
            |> System.Console.WriteLine

    let withTrace enabled fn =
        let oldTraceEnabled = traceEnabled
        try
            traceEnabled <- enabled
            fn ()
        finally
            traceEnabled <- oldTraceEnabled

    let withTraceEnabled fn =
        withTrace true fn

    let withTraceDisabled fn =
        withTrace false fn

    let withTraceLevel level fn =
        let oldTraceLevel = traceLevel
        try
            traceLevel <- level
            fn ()
        finally
            traceLevel <- oldTraceLevel

    /// ## newDisposable

    let inline newDisposable fn =
        { new System.IDisposable with
            member _.Dispose () = fn ()
        }
