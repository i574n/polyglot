#if !INTERACTIVE
namespace Polyglot
#endif

module Common =

#if !WASM && !FABLE_COMPILER
    let Date_time = {|
        new_guid_from_date_time =
#if !INTERACTIVE
            Date_time.new_guid_from_date_time
#else
            new_guid_from_date_time
#endif
    |}
#endif

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


        let ellipsis max value =
            if value |> String.length <= max
            then value
            else $"{value |> substring 0 max}..."

    /// ## formatException

    let inline formatException (ex : exn) =
        $"{ex.GetType ()}: {ex.Message}"

    /// ## memoize

    let inline memoize fn =
        let result = lazy fn ()
        fun () -> result.Value

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
#if FABLE_COMPILER_RUST
            Fable.Core.RustInterop.emitRustExpr () @"println!(""{}"", text)"
#else
            System.Console.WriteLine text
#endif

#if !WASM && !FABLE_COMPILER
            if traceDump then
                try
                    let tmpPath = System.IO.Path.GetTempPath ()
                    let logDir = System.IO.Path.Combine (tmpPath, "!polyglot")
                    System.IO.Directory.CreateDirectory logDir |> ignore
                    let logFile = System.IO.Path.Combine (logDir, $"{Date_time.new_guid_from_date_time System.DateTime.Now}.txt")
                    System.IO.File.WriteAllTextAsync (logFile, text) |> Async.AwaitTask |> Async.RunSynchronously
                with ex ->
                    traceRaw Critical (fun () -> $"trace / ex: {ex |> formatException}")
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
#if WASM
                ""
#else
                match replStart () with
                | Some replStart ->
                    let t = System.DateTime.Now.Ticks - replStart |> System.TimeSpan
                    System.DateTime (1, 1, 1, t.Hours, t.Minutes, t.Seconds, t.Milliseconds)
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
