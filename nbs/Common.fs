#if !INTERACTIVE
namespace Polyglot
#endif

module Common =

    let nl = System.Environment.NewLine
    let q = @""""

    let inline cons head tail = head :: tail

    module String =
        let inline contains (value : string) (input : string) =
            input.Contains value

        let inline endsWith (value : string) (input : string) =
            input.EndsWith value

        let inline padLeft totalWidth paddingChar (input : string) =
            input.PadLeft (totalWidth, paddingChar)

        let inline replace (oldValue : string) (newValue : string) (input : string) =
            input.Replace (oldValue, newValue)

        let inline split separator (input : string) =
            input.Split separator

        let inline splitString (separator : string array) (input : string) =
            input.Split (separator, System.StringSplitOptions.None)

        let inline startsWith (value : string) (input : string) =
            input.StartsWith value

        let inline substring startIndex length (input : string) =
            input.Substring (startIndex, length)

        let inline trim (input : string) =
            input.Trim ()

        let inline trimEnd (trimChars : char array) (input : string) =
            input.TrimEnd trimChars

        let inline trimStart (trimChars : char array) (input : string) =
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

    /// ## memoize

    let inline memoize fn =
        let result = lazy fn ()
        fun () -> result.Value

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

    let private replStart =
#if INTERACTIVE
        fun () ->
            if System.Reflection.Assembly.GetEntryAssembly().GetName().Name = "dotnet-repl"
            then Some System.DateTime.Now
            else None
        |> memoize
#else
            fun () -> None : System.DateTime option
#endif

    let trace level fn getLocals =
        if traceEnabled && level >= traceLevel then
            traceCount <- traceCount + 1
            let time =
                match replStart () with
                | Some dateTime ->
                    let t = System.DateTime.Now - dateTime
                    System.DateTime (1, 1, 1, t.Hours, t.Minutes, t.Seconds, t.Milliseconds, t.Microseconds)
                | None -> System.DateTime.Now
                |> fun dateTime -> dateTime.ToString "HH:mm:ss"
            $"{time} #{traceCount} [{level}] %s{fn ()} / %s{getLocals ()}"
            |> String.trimEnd [| ' '; '/' |]
            |> System.Console.WriteLine

    let inline withTrace enabled fn =
        let oldTraceEnabled = traceEnabled
        try
            traceEnabled <- enabled
            fn ()
        finally
            traceEnabled <- oldTraceEnabled

    let inline withTraceEnabled fn =
        withTrace true fn

    let inline withTraceDisabled fn =
        withTrace false fn

    let inline withTraceLevel level fn =
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

    /// ## printException

    let inline printException (ex : System.Exception) =
        $"{ex.GetType ()}: {ex.Message}"

    /// ## retryFn

    let inline retryFn retries fn =
        let rec loop retry =
            try
                if retry < retries
                then fn () |> Some
                else None
            with ex ->
                let getLocals () = $"retry: {retry} / ex: {ex |> printException} / {getLocals ()}"
                trace Warn (fun () -> "retryFn") getLocals
                System.Threading.Thread.Sleep 1
                loop (retry + 1)
        loop 0
