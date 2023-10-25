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

        let inline toLower (input : string) =
            input.ToLower ()

        let inline toUpper (input : string) =
            input.ToUpper ()

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

    /// ## printException

    let inline printException (ex : System.Exception) =
        $"{ex.GetType ()}: {ex.Message}"

    /// ## TraceLevel

    type TraceLevel =
        | Verbose
        | Debug
        | Info
        | Warning
        | Critical

    let inline getLocals () = ""

    let mutable traceEnabled = true
    let mutable traceCount = 0
    let mutable traceLevel = Verbose
    let mutable traceDump = false

    let testTraceLevel level =
        traceEnabled && level >= traceLevel

    /// ## traceRaw

    let rec traceRaw level fn =
        if level |> testTraceLevel then
            traceCount <- traceCount + 1

            let text = $"%s{fn ()}"

            System.Console.WriteLine text
#if !CHAIN && !FABLE_COMPILER
            if traceDump then
                try
                    let tmpPath = System.IO.Path.GetTempPath ()
                    let logDir = System.IO.Path.Combine (tmpPath, "!polyglot")
                    System.IO.Directory.CreateDirectory logDir |> ignore
                    let logFile = System.IO.Path.Combine (logDir, $"{newGuidFromDateTime System.DateTime.Now}.txt")
                    System.IO.File.WriteAllTextAsync (logFile, text) |> Async.AwaitTask |> Async.RunSynchronously
                with ex ->
                    traceRaw Critical (fun () -> $"trace / ex: {ex |> printException}")
#endif

    /// ## trace

    let private replStart =
#if INTERACTIVE || !FABLE_COMPILER
        fun () ->
            if System.Reflection.Assembly.GetEntryAssembly().GetName().Name <> "Microsoft.DotNet.Interactive.App"
            then Some System.DateTime.Now.Ticks
            else None
        |> memoize
#else
        fun () -> None : int64 option
#endif

    let trace level fn getLocals =
        fun () ->
            let time =
#if CHAIN
                ""
#else
                match replStart () with
                | Some replStart ->
                    let t = System.DateTime.Now.Ticks - replStart |> System.TimeSpan
                    System.DateTime (1, 1, 1, t.Hours, t.Minutes, t.Seconds, t.Milliseconds, t.Microseconds)
                | None -> System.DateTime.Now
                |> fun dateTime ->
#if FABLE_COMPILER_RUST
                    "hh:mm:ss"
#else
                    "HH:mm:ss"
#endif
                    |> dateTime.ToString
#endif
            $"{time} #{traceCount} [%A{level}] %s{fn ()} / %s{getLocals ()}"
            |> String.trimStart [||]
            |> String.trimEnd [| ' '; '/' |]
        |> traceRaw level

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

    let inline withTraceDump dump fn =
        let oldTraceDump = traceDump
        try
            traceDump <- dump
            fn ()
        finally
            traceDump <- oldTraceDump

    /// ## newDisposable

    let inline newDisposable fn =
        { new System.IDisposable with
            member _.Dispose () = fn ()
        }

    /// ## retryFn

    let inline retryFn retries fn =
        let rec loop retry =
            try
                if retry < retries
                then fn () |> Some
                else None
            with ex ->
                let getLocals () = $"retry: {retry} / ex: {ex |> printException} / {getLocals ()}"
                trace Warning (fun () -> "retryFn") getLocals
                System.Threading.Thread.Sleep 1
                loop (retry + 1)
        loop 0
