#if !INTERACTIVE
namespace Polyglot
#endif

module Common =

#if !INTERACTIVE
    open Lib
#endif

    let nl = System.Environment.NewLine
    let q = @""""

    let inline cons head tail = head :: tail

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

#if !WASM && !CONTRACT && !FABLE_COMPILER
            if traceDump then
                try
                    let tmpPath = System.IO.Path.GetTempPath ()
                    let logDir = System.IO.Path.Combine (tmpPath, "!polyglot")
                    System.IO.Directory.CreateDirectory logDir |> ignore
                    let logFile = System.IO.Path.Combine (logDir, $"{SpiralDateTime.new_guid_from_date_time System.DateTime.Now}.txt")
                    System.IO.File.WriteAllTextAsync (logFile, text) |> Async.AwaitTask |> Async.RunSynchronously
                with ex ->
                    traceRaw Critical (fun () -> $"trace / ex: {ex |> SpiralSm.format_exception}")
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
#if WASM || CONTRACT
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
            |> SpiralSm.trim_start [||]
            |> SpiralSm.trim_end [| ' '; '/' |]
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
