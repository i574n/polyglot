#if !INTERACTIVE
namespace Polyglot
#endif

module Eval =

#if !INTERACTIVE
    open Lib
#endif

    open Common
    open SpiralFileSystem.Operators
    open Microsoft.AspNetCore.SignalR.Client

    open System
    open System.Collections.Generic
    open System.IO
    open System.Text
    open System.Threading

    /// ## mapErrors

    let inline mapErrors (severity, errors, lastTopLevelIndex) allCode =
        let allCodeLineLength =
            allCode |> SpiralSm.split "\n" |> Array.length

        errors
        |> List.map (fun (_, error) ->
            match error with
            | Supervisor.FatalError message ->
                (
                    severity, message, 0, ("", (0, 0), (0, 0))
                )
                |> List.singleton
            | Supervisor.TracedError data ->
                data.trace
                |> List.truncate 5
                |> List.append [ data.message ]
                |> List.map (fun message ->
                    (
                        severity, message, 0, ("", (0, 0), (0, 0))
                    )
                )
            | Supervisor.PackageErrors data
            | Supervisor.TokenizerErrors data
            | Supervisor.ParserErrors data
            | Supervisor.TypeErrors data ->
                data.errors
                |> List.filter (fun ((rangeStart, _), _) ->
                    trace Debug (fun () -> $"Eval.mapErrors / rangeStart.line: {rangeStart.line} / lastTopLevelIndex: {lastTopLevelIndex} / allCodeLineLength: {allCodeLineLength} / filtered: {rangeStart.line > allCodeLineLength}") getLocals
                    rangeStart.line > allCodeLineLength
                )
                |> List.map (fun ((rangeStart, rangeEnd), message) ->
                    (
                        severity,
                        message,
                        0,
                        (
                            (data.uri |> System.IO.Path.GetFileName),
                            (
                                (match lastTopLevelIndex with
                                | Some i when rangeStart.line >= i + allCodeLineLength + 3 ->
                                    rangeStart.line - allCodeLineLength - 2
                                | _ -> rangeStart.line - allCodeLineLength),
                                (match lastTopLevelIndex with
                                | Some i when rangeStart.line >= i + allCodeLineLength + 3 ->
                                    rangeStart.character - 4
                                | _ -> rangeStart.character)
                            ),
                            (
                                (match lastTopLevelIndex with
                                | Some i when rangeStart.line >= i + allCodeLineLength + 3 ->
                                    rangeEnd.line - allCodeLineLength - 2
                                | _ -> rangeEnd.line - allCodeLineLength),
                                (match lastTopLevelIndex with
                                | Some i when rangeStart.line >= i + allCodeLineLength + 3 ->
                                    rangeEnd.character - 4
                                | _ -> rangeEnd.character)
                            )
                        )
                    )
                )
        )
        |> List.collect id
        |> List.toArray

    let repositoryRoot = SpiralFileSystem.get_source_directory () |> SpiralFileSystem.find_parent ".paket" false
    let targetDir = repositoryRoot </> "target/polyglot/spiral_eval"
    let traceDir = targetDir </> "eval_trace"
    [ targetDir; traceDir ]
    |> List.iter (fun dir -> if Directory.Exists dir |> not then Directory.CreateDirectory dir |> ignore)

    let mutable allCode = ""

    /// ## traceFile

    let traceFile filePath (text : string) =
        let struct (_, _, _, level, _) = SpiralTrace.get_trace_state ()
        if level.l0 = SpiralTrace.TraceLevel.US0_0 then
            let dateTimeStr = DateTime.Now |> SpiralDateTime.new_guid_from_date_time
            let traceFile = traceDir </> filePath
            File.AppendAllText (traceFile, $"{dateTimeStr} Eval / {text}{Environment.NewLine}") |> ignore

    /// ## log

    let assemblyName = Reflection.Assembly.GetEntryAssembly().GetName().Name

    let log (text : string) =
        let dateTimeStr = DateTime.Now |> SpiralDateTime.new_guid_from_date_time
        text |> traceFile $"{assemblyName}_{dateTimeStr}_{Random().Next()}.txt"

    /// ## startTokenRangeWatcher

    let inline startTokenRangeWatcher () =
        if [ "dotnet-repl" ] |> List.contains assemblyName |> not then
            let packagesDir = targetDir </> "packages"

            [ packagesDir ]
            |> List.iter (fun dir -> if Directory.Exists dir |> not then Directory.CreateDirectory dir |> ignore)

            let stream, disposable = FileSystem.watchDirectory (fun _ -> false) packagesDir

            try
                let existingFilesChild =
                    packagesDir
                    |> System.IO.Directory.GetDirectories
                    |> Array.map (fun codeDir -> async {
                        try
                            let tokensPath = codeDir </> "tokens.json"
                            let packagePath = codeDir </> "package.spiproj"
                            if (tokensPath |> File.Exists |> not) && (packagePath |> File.Exists |> not) then
                                let codePath = codeDir </> "main.spi"
                                let! tokens = codePath |> Supervisor.getFileTokenRange None None
                                match tokens with
                                | Some tokens ->
                                    do!
                                        tokens
                                        |> FSharp.Json.Json.serialize
                                        |> SpiralFileSystem.write_all_text_async tokensPath
                                | None ->
                                    log $"Eval.startTokenRangeWatcher / GetDirectories / tokens: None / {getLocals ()}"
                        with ex ->
                            log $"Eval.startTokenRangeWatcher / GetDirectories / ex: {ex |> SpiralSm.format_exception} / {getLocals ()}"
                    })
                    |> Async.Parallel
                    |> Async.Ignore

                let streamAsyncChild =
                    stream
                    |> FSharp.Control.AsyncSeq.iterAsyncParallel (fun (ticks, event) -> async {
                        try
                            let getLocals () = $"ticks: {ticks} / event: {event} / {getLocals ()}"
                            log $"Eval.startTokenRangeWatcher / iterAsyncParallel / {getLocals ()}"
                            match event with
                            | FileSystem.FileSystemChange.Changed (codePath, _)
                                when System.IO.Path.GetFileName codePath = "main.spi"
                                ->
                                let hashDir = codePath |> System.IO.Directory.GetParent
                                let hashHex = hashDir.Name
                                let packagePath = packagesDir </> hashHex </> "package.spiproj"

                                if packagePath |> System.IO.File.Exists |> not then
                                    let codePath = packagesDir </> codePath
                                    let tokensPath = packagesDir </> hashHex </> "tokens.json"
                                    do!
                                        codePath
                                        |> SpiralFileSystem.wait_for_file_access_read
                                        |> Async.runWithTimeoutAsync 1000
                                        |> Async.Ignore
                                    let! tokens = codePath |> Supervisor.getFileTokenRange None None
                                    match tokens with
                                    | Some tokens ->
                                        do!
                                            tokens
                                            |> FSharp.Json.Json.serialize
                                            |> SpiralFileSystem.write_all_text_async tokensPath
                                    | None ->
                                        log $"Eval.startTokenRangeWatcher / iterAsyncParallel / tokens: None / {getLocals ()}"
                            | _ -> ()
                        with ex ->
                            log $"Eval.startTokenRangeWatcher / iterAsyncParallel / ex: {ex |> SpiralSm.format_exception} / {getLocals ()}"
                    })

                async {
                    do! Async.Sleep 3000
                    existingFilesChild |> Async.StartImmediate
                    streamAsyncChild |> Async.Start
                }
                |> Async.Start
            with ex ->
                log $"Eval.startTokenRangeWatcher / ex: {ex |> SpiralSm.format_exception}"

            disposable
        else new_disposable (fun () -> ())

    /// ## startCommandsWatcher

    let startCommandsWatcher (uriServer : string) =
        let commandsDir = targetDir </> "eval_commands"
        let commandHistoryDir = targetDir </> "eval_command_history"
        [ commandsDir; commandHistoryDir ]
        |> List.iter (fun dir -> if Directory.Exists dir |> not then Directory.CreateDirectory dir |> ignore)

        Directory.EnumerateFiles commandsDir |> Seq.iter File.Delete

        let stream, disposable =
            commandsDir
            |> FileSystem.watchDirectory (function
                | FileSystem.FileSystemChange.Created _ -> true
                | _ -> false
            )

        let connection = HubConnectionBuilder().WithUrl(uriServer).Build()
        connection.StartAsync() |> Async.AwaitTask |> Async.Start
        // let _ = connection.On<string>("ServerToClientMsg", fun x ->
        //     printfn $"ServerToClientMsg: '{x}'"
        // )

        stream
        |> FSharp.Control.AsyncSeq.iterAsyncParallel (fun (ticks, event) -> async {
            let getLocals () = $"ticks: {ticks} / event: {event} / {getLocals ()}"
            trace Verbose (fun () -> "Eval.startCommandsWatcher / iterAsyncParallel") getLocals

            match event with
            | FileSystem.FileSystemChange.Created (path, Some json) ->
                try
                    let fullPath = commandsDir </> path
                    let! result = connection.InvokeAsync<string>("ClientToServerMsg", json) |> Async.AwaitTask
                    let commandHistoryPath = commandHistoryDir </> path
                    do! fullPath |> SpiralFileSystem.move_file_async commandHistoryPath |> Async.Ignore
                    if result |> SpiralSm.trim |> String.length > 0 then
                        let resultPath = commandHistoryDir </> $"{Path.GetFileNameWithoutExtension path}_result.json"
                        do! result |> SpiralFileSystem.write_all_text_async resultPath
                with ex ->
                    trace Critical (fun () -> "Eval.startCommandsWatcher / iterAsyncParallel / ex: {ex |> SpiralSm.format_exception}") getLocals
            | _ -> ()
        })
        |> Async.StartChild
        |> Async.Ignore
        |> Async.Start

        new_disposable (fun () ->
            disposable.Dispose ()
        )

    /// ## eval

    let inline eval
        (fsi_eval:
            string
            -> System.Threading.CancellationToken
            -> Choice<'a,Exception> * (TraceLevel * string * int * (string * (int * int) * (int * int))) array)
        (cancellationToken: Option<System.Threading.CancellationToken>)
        (code: string)
        =
        log $"Eval.eval / code: %A{code}"

        let rawCellCode =
            code |> SpiralSm.replace "\r\n" "\n"

        let lines = rawCellCode |> SpiralSm.split "\n"

        if lines |> Array.exists (fun line -> line |> SpiralSm.starts_with "#r " && line |> SpiralSm.ends_with "\"") then
            let cancellationToken = defaultArg cancellationToken System.Threading.CancellationToken.None
            let ch, errors = fsi_eval code cancellationToken
            match ch with
            | Choice1Of2 v -> Ok(v), errors
            | Choice2Of2 ex -> Error(ex), errors
        else
            try
                let rustArgs =
                    lines
                    |> Array.tryPick (fun line ->
                        if line |> SpiralSm.starts_with "// // rust="
                        then line |> SpiralSm.split "=" |> Array.tryItem 1
                        else None
                    )

                let timeout =
                    lines
                    |> Array.tryPick (fun line ->
                        if line |> SpiralSm.starts_with "// // timeout="
                        then line |> SpiralSm.split "=" |> Array.tryItem 1 |> Option.map int
                        else None
                    )
                    |> Option.defaultValue (60000 * 60)

                let printCode =
                    lines
                    |> Array.tryPick (fun line ->
                        if line |> SpiralSm.starts_with "// // print_code="
                        then line |> SpiralSm.split "=" |> Array.tryItem 1 |> Option.map ((=) "true")
                        else None
                    )
                    |> Option.defaultValue true

                let isTrace =
                    lines
                    |> Array.tryPick (fun line ->
                        if line |> SpiralSm.starts_with "// // trace="
                        then line |> SpiralSm.split "=" |> Array.tryItem 1 |> Option.map ((=) "true")
                        else None
                    )
                    |> Option.defaultValue false

                let traceLevel =
                    if isTrace
                    then SpiralRuntime.TraceLevel.US0_0
                    else SpiralRuntime.TraceLevel.US0_2

                let struct (_, _, _, level, _) = SpiralTrace.get_trace_state ()
                level.l0 <-
                    if traceLevel = SpiralRuntime.TraceLevel.US0_0
                    then SpiralTrace.TraceLevel.US0_0
                    else SpiralTrace.TraceLevel.US0_2

                let lastBlock =
                    lines
                    |> Array.tryFindBack (fun line ->
                        line |> String.length > 0
                        && line.[0] <> ' '
                    )

                let hasMain =
                    lastBlock
                    |> Option.exists (fun line ->
                        line |> SpiralSm.starts_with "inl main "
                        || line |> SpiralSm.starts_with "let main "
                    )

                let cellCode, lastTopLevelIndex =
                    if hasMain
                    then rawCellCode, None
                    else
                        let lastTopLevelIndex, _ =
                            (lines |> Array.indexed, (None, false))
                            ||> Array.foldBack (fun (i, line) (lastTopLevelIndex, finished) ->
                                trace Debug (fun () -> $"i: {i} / line: '{line}' / lastTopLevelIndex: {lastTopLevelIndex} / finished: {finished}") getLocals
                                match line with
                                | _ when finished -> lastTopLevelIndex, true
                                | "" -> lastTopLevelIndex, false
                                | line when
                                    line |> SpiralSm.starts_with " "
                                    || line |> SpiralSm.starts_with "// " -> lastTopLevelIndex, false
                                | line when
                                    line |> SpiralSm.starts_with "open "
                                    || line |> SpiralSm.starts_with "prototype "
                                    || line |> SpiralSm.starts_with "instance "
                                    || line |> SpiralSm.starts_with "type "
                                    || line |> SpiralSm.starts_with "union "
                                    || line |> SpiralSm.starts_with "nominal " -> lastTopLevelIndex, true
                                | line when
                                    line |> SpiralSm.starts_with "inl "
                                    || line |> SpiralSm.starts_with "let " ->
                                    let m =
                                        System.Text.RegularExpressions.Regex.Match (
                                            line,
                                            @"^(inl|let) +([~\(\w][\w\d']*(?:| *[~\w][\w\d']*\)|, *[~\w][\w\d']*)) +[:=](?! +function)"
                                        )
                                    trace Debug (fun () -> $"m: '{m}' / m.Groups.Count: {m.Groups.Count}") getLocals
                                    if m.Groups.Count = 3
                                    then Some i, false
                                    else lastTopLevelIndex, true
                                | _ -> Some i, false
                            )
                        let code =
                            match lastTopLevelIndex with
                            | Some lastTopLevelIndex ->
                                lines
                                |> Array.mapi (fun i line ->
                                    match i with
                                    | i when i < lastTopLevelIndex -> line
                                    | i when i = lastTopLevelIndex -> $"\nlet main () =\n    {line}"
                                    | _ when line |> SpiralSm.trim = "" -> ""
                                    | _ -> $"    {line}"
                                )
                                |> SpiralSm.concat "\n"
                            | None -> $"{rawCellCode}\n\ninl main () = ()\n"
                        code, lastTopLevelIndex

                let newAllCode = $"{allCode}\n\n{cellCode}"

                async {
                    try
                        let! mainPath = newAllCode |> Supervisor.persistCode

                        let port = Supervisor.getCompilerPort ()

                        let! codeChoice =
                            mainPath
                            |> Supervisor.buildFile timeout port cancellationToken
                            |> Async.catch
                            |> Async.runWithTimeoutAsync timeout

                        let code =
                            match codeChoice with
                            | Some (Ok code) -> Some code
                            | Some (Error ex) ->
                                log $"Eval / errors: {ex |> SpiralSm.format_exception}"
                                None
                            | _ -> None

                        match code with
                        | Some (Some code, spiralErrors) ->
                            let spiralErrors =
                                mapErrors (Warning, spiralErrors, lastTopLevelIndex) allCode
                            let inline _trace (fn : unit -> string) =
                                if isTrace
                                then trace Info (fun () -> $"Eval.eval / {fn ()}") getLocals
                                else fn () |> System.Console.WriteLine

                            if printCode
                            then _trace (fun () -> if rustArgs |> Option.isSome then $".fsx:\n{code}" else code)

                            let! rustResult =
                                if rustArgs |> Option.isNone || lastTopLevelIndex = None
                                then None |> Async.init
                                else
                                    async {
                                        // let hash = $"repl_{code |> SpiralCrypto.hash_text}"
                                        let hash = $"spiral_eval"

                                        let! fsprojPath = code |> Builder.persistCodeProject ["Fable.Core"] [] hash

                                        let projectDir = fsprojPath |> Path.GetDirectoryName

                                        let outDir = projectDir </> $"target/{hash}"

                                        let libLinkTargetPath = projectDir </> "target/fable-library-rust"
                                        let libLinkPath = outDir </> $"fable_modules/fable-library-rust"

                                        if Directory.Exists libLinkTargetPath |> not
                                        then libLinkTargetPath |> Directory.CreateDirectory |> ignore

                                        libLinkPath |> Path.GetDirectoryName |> Directory.CreateDirectory |> ignore

                                        let libLinkPathInfo = DirectoryInfo libLinkPath
                                        if libLinkPathInfo.Exists && libLinkPathInfo.LinkTarget = null then
                                            Directory.Delete (libLinkPath, true)

                                        if libLinkPath |> Directory.Exists |> not then
                                            Directory.CreateSymbolicLink (libLinkPath, libLinkTargetPath)
                                            |> ignore


                                        let command = $@"dotnet fable {fsprojPath} --optimize --lang rs --extension .rs --outDir {outDir}"
                                        let! exitCode, result =
                                            SpiralRuntime.execute_with_options_async struct (cancellationToken, command, None, Some traceLevel, None)

                                        if exitCode <> 0
                                        then return Some (Error result)
                                        else
                                            let rsPath = outDir </> $"{hash}.rs"
                                            let! rsCode = rsPath |> SpiralFileSystem.read_all_text_async

                                            let mainCode = "pub fn main() -> Result<(), String> { Ok(()) }"

                                            let cached = rsCode |> SpiralSm.contains mainCode

                                            let rsCode =
                                                if cached
                                                then rsCode
                                                else rsCode |> SpiralSm.replace "),);" "));"

                                            if printCode
                                            then _trace (fun () -> $".rs:\n{rsCode}")

                                            if not cached
                                            then do!
                                                $"{rsCode}\n\n{mainCode}\n"
                                                |> SpiralFileSystem.write_all_text_async rsPath


                                            let cargoTomlPath = outDir </> $"Cargo.toml"
                                            let cargoTomlContent = $"""[package]
name = "{hash}"
version = "0.0.1"
edition = "2021"

[workspace]

[dependencies]
fable_library_rust = {{ path = "fable_modules/fable-library-rust", optional = true, default-features = false }}
clap = {{}}
num-complex = {{}}
pyo3 = "~0.21.0-beta.0"

[features]
default = ["fable_library_rust/default", "fable_library_rust/static_do_bindings"]

[[bin]]
name = "{hash}"
path = "{hash}.rs"
"""
                                            do! cargoTomlContent |> SpiralFileSystem.write_all_text_exists cargoTomlPath

                                            let command = $@"cargo run --release --manifest-path {cargoTomlPath}"
                                            let! exitCode, result =
                                                SpiralRuntime.execute_with_options_async struct (cancellationToken, command, None, Some traceLevel, None)

                                            if exitCode = 0 then
                                                try
                                                    let result =
                                                        result
                                                        |> SpiralSm.split "\n"
                                                        |> Array.skipWhile (fun line ->
                                                            line |> SpiralSm.contains @"[optimized] target" |> not
                                                        )
                                                        |> Array.skip 2
                                                        |> SpiralSm.concat "\n"
                                                    return Some (Ok result)
                                                with ex ->
                                                    return $"ex: {ex}\nresult:\n{result}" |> Error |> Some
                                            else
                                                return Some (Error result)
                                    }

                            let cancellationToken = defaultArg cancellationToken System.Threading.CancellationToken.None

                            let fsxResult =
                                if rustArgs |> Option.isSome
                                then None
                                else
                                    try
                                        let ch, errors = fsi_eval code cancellationToken
                                        let errors =
                                            errors
                                            |> Array.map (fun (e1, e2, e3, _) ->
                                                (e1, e2, e3, ("", (0, 0), (0, 0)))
                                            )
                                        Some (ch, errors)
                                    with ex ->
                                        trace Critical (fun () -> $"Eval.eval / ex: {ex |> SpiralSm.format_exception}") getLocals
                                        None

                            match fsxResult, rustResult with
                            | Some (ch, errors), None ->
                                let errors = errors |> Array.append spiralErrors
                                match ch with
                                | Choice1Of2 v ->
                                    allCode <- newAllCode
                                    return Ok(v), errors
                                | Choice2Of2 ex -> return Error ex, errors
                            | _, Some result ->
                                let result, errors =
                                    match result with
                                    | Ok result -> result, [||]
                                    | Error error ->
                                        "",
                                        [|
                                            (
                                                TraceLevel.Critical, error, 0, ("", (0, 0), (0, 0))
                                            )
                                        |]

                                let header = if printCode then ".rs output:\n" else ""
                                let code =
                                    if printCode
                                    then $"\"\"\"{header}{result}\n\n\n\"\"\""
                                    else $"\"\"\"{header}{result}\n\"\"\""
                                let ch, errors2 = fsi_eval code cancellationToken
                                let errors =
                                    errors
                                    |> Array.append spiralErrors
                                    |> Array.append errors2
                                match ch with
                                | Choice1Of2 v ->
                                    allCode <- newAllCode
                                    return Ok(v), errors
                                | Choice2Of2 ex ->
                                    return Error ex, errors
                            | _ ->
                                let ch, errors = fsi_eval "()" cancellationToken
                                match ch with
                                | Choice1Of2 v ->
                                    allCode <- newAllCode
                                    return Ok(v), errors
                                | Choice2Of2 ex ->
                                    return Error ex, errors
                        | Some (None, errors) when errors |> List.isEmpty |> not ->
                            return errors.[0] |> fst |> Exception |> Error,
                            mapErrors (TraceLevel.Critical, errors, lastTopLevelIndex) allCode
                        | _ ->
                            return Error (Exception "Spiral error or timeout"),
                            [|
                                (
                                    TraceLevel.Critical, "Diag: Spiral error or timeout", 0, ("", (0, 0), (0, 0))
                                )
                            |]
                    with ex ->
                        log $"Eval / ex: {ex |> SpiralSm.format_exception}"
                        return Error (Exception $"Spiral error or timeout (4_) / ex: {ex |> SpiralSm.format_exception}"),
                        [|
                            (
                                TraceLevel.Critical, $"Diag: Spiral error or timeout (4) / ex: {ex |> SpiralSm.format_exception}", 0, ("", (0, 0), (0, 0))
                            )
                        |]
                }
                |> Async.runWithTimeoutStrict timeout
                |> Option.defaultValue (
                    Error (Exception "Spiral error or timeout (2)"),
                    [|
                        (
                            TraceLevel.Critical, "Diag: Spiral error or timeout (2)", 0, ("", (0, 0), (0, 0))
                        )
                    |]
                )
            with ex ->
                log $"Eval / ex: {ex |> SpiralSm.format_exception}"
                Error (Exception $"Spiral error or timeout (3) / ex: {ex |> SpiralSm.format_exception}"),
                [|
                    (
                        TraceLevel.Critical, $"Diag: Spiral error or timeout (3) / ex: {ex |> SpiralSm.format_exception}", 0, ("", (0, 0), (0, 0))
                    )
                |]
