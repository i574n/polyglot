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
                    trace Debug (fun () -> $"Eval.mapErrors / rangeStart.line: {rangeStart.line} / lastTopLevelIndex: {lastTopLevelIndex} / allCodeLineLength: {allCodeLineLength} / filtered: {rangeStart.line > allCodeLineLength}") _locals
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

    /// ### workspaceRoot
    let workspaceRoot = SpiralFileSystem.get_workspace_root ()

    /// ### targetDir
    let targetDir = workspaceRoot </> "target/spiral_Eval"
    [ targetDir ]
    |> List.iter (fun dir -> if Directory.Exists dir |> not then Directory.CreateDirectory dir |> ignore)

    /// ### assemblyName
    let assemblyName = Reflection.Assembly.GetEntryAssembly().GetName().Name

    /// ## allCode
    let mutable allCode = ""

    /// ### allPackages
    let mutable allPackages : string [] = [||]

    /// ## allCodeReal
    let mutable allCodeReal = ""

    /// ## traceToggle
    let mutable traceToggle = false

    /// ## getParentProcessId
    let getParentProcessId () =
        if SpiralPlatform.is_windows () |> not
        then 0u
        else
            let pid = System.Diagnostics.Process.GetCurrentProcess().Id
            let query = $"SELECT ParentProcessId FROM Win32_Process WHERE ProcessId = {pid}"
            use searcher = new System.Management.ManagementObjectSearcher (query)
            use results = searcher.Get ()
            let data = results |> Seq.cast<System.Management.ManagementObject>
            if data |> Seq.isEmpty
            then 0u
            else data |> Seq.head |> (fun mo -> mo.["ParentProcessId"] :?> uint32)

    /// ## startTokenRangeWatcher
    let inline startTokenRangeWatcher () =
        if [ "dotnet-repl" ] |> List.contains assemblyName |> not then
            let tokensDir = targetDir </> "tokens"

            [ tokensDir ]
            |> List.iter (fun dir -> if Directory.Exists dir |> not then Directory.CreateDirectory dir |> ignore)

            let stream, disposable = FileSystem.watchDirectory (fun _ -> false) tokensDir

            try
                let existingFilesChild =
                    tokensDir
                    |> System.IO.Directory.GetDirectories
                    |> Array.map (fun codeDir -> async {
                        try
                            let tokensPath = codeDir </> "tokens.json"
                            if tokensPath |> File.Exists |> not then
                                let spiralCodePath = codeDir </> "main.spi"
                                let spiralRealCodePath = codeDir </> "main_real.spir"
                                let spiralExists = spiralCodePath |> System.IO.File.Exists
                                let spiralRealExists = spiralRealCodePath |> System.IO.File.Exists
                                if spiralExists |> not && spiralRealExists |> not
                                then do! codeDir |> SpiralFileSystem.delete_directory_async |> Async.Ignore
                                else
                                    let! tokens =
                                        if spiralExists then spiralCodePath else spiralRealCodePath
                                        |> Supervisor.getFileTokenRange None None
                                    match tokens with
                                    | Some tokens ->
                                        do!
                                            tokens
                                            |> FSharp.Json.Json.serialize
                                            |> SpiralFileSystem.write_all_text_async tokensPath
                                    | None ->
                                        trace Verbose (fun () -> $"Eval.startTokenRangeWatcher / GetDirectories / tokens: None") _locals
                        with ex ->
                            trace Critical (fun () -> $"Eval.startTokenRangeWatcher / GetDirectories / ex: {ex |> SpiralSm.format_exception}") _locals
                    })
                    |> Async.Parallel
                    |> Async.Ignore

                let streamAsyncChild =
                    stream
                    |> FSharp.Control.AsyncSeq.iterAsyncParallel (fun (ticks, event) ->
                        match event with
                        | FileSystem.FileSystemChange.Changed (codePath, _)
                            when [ "main.spi"; "main_real.spir" ]
                                |> List.contains (System.IO.Path.GetFileName codePath)
                            ->
                            async {
                                let hashDir = codePath |> System.IO.Directory.GetParent
                                let hashHex = hashDir.Name
                                let codePath = tokensDir </> codePath
                                let tokensPath = tokensDir </> hashHex </> "tokens.json"
                                // do! Async.Sleep 30
                                let rec loop retry = async {
                                    let! tokens = codePath |> Supervisor.getFileTokenRange None None
                                    if retry = 3 || tokens <> Some [||]
                                    then return tokens, retry
                                    else
                                        trace Debug
                                            (fun () -> $"Eval.startTokenRangeWatcher / iterAsyncParallel")
                                            (fun () -> $"retry: {retry} / tokens: {tokens}")
                                        do! Async.Sleep 30
                                        return! loop (retry + 1)
                                }
                                let! tokens, retries = loop 1
                                match tokens with
                                | Some tokens ->
                                    do!
                                        tokens
                                        |> FSharp.Json.Json.serialize
                                        |> SpiralFileSystem.write_all_text_exists tokensPath
                                | None ->
                                    trace Debug
                                        (fun () -> $"Eval.startTokenRangeWatcher / iterAsyncParallel")
                                        (fun () -> $"retries: {retries} / tokens: {tokens}")
                            }
                            |> Async.retryAsync 3
                            |> Async.map (Result.toOption >> Option.defaultValue ())
                        | _ -> () |> Async.init
                    )

                let parentAsyncChild = async {
                    let parentProcessId = getParentProcessId ()
                    trace Verbose
                        (fun () -> "Eval.parentAsyncChild")
                        (fun () -> $"parentProcessId: {parentProcessId} / {_locals ()}")

                    if parentProcessId > 0u then
                        let parentProcess = parentProcessId |> int |> System.Diagnostics.Process.GetProcessById
                        do! parentProcess.WaitForExitAsync () |> Async.AwaitTask
                        trace Debug
                            (fun () -> "Eval.parentAsyncChild / Parent process has exited. Performing cleanup...")
                            (fun () -> $"{_locals ()}")
                        System.Threading.Thread.Sleep 1000
                        System.Environment.Exit 1
                }

                async {
                    do! Async.Sleep 3000
                    existingFilesChild |> Async.StartImmediate
                    streamAsyncChild |> Async.Start
                    parentAsyncChild |> Async.Start
                }
                |> Async.Start
            with ex ->
                trace Critical (fun () -> $"Eval.startTokenRangeWatcher / ex: {ex |> SpiralSm.format_exception}") _locals

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
            let _locals () = $"ticks: {ticks} / event: {event} / {_locals ()}"
            trace Verbose (fun () -> "Eval.startCommandsWatcher / iterAsyncParallel") _locals

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
                    let _locals () = $"ex: {ex |> SpiralSm.format_exception} / {_locals ()}"
                    trace Critical (fun () -> "Eval.startCommandsWatcher / iterAsyncParallel") _locals
            | _ -> ()
        })
        |> Async.StartChild
        |> Async.Ignore
        |> Async.Start

        new_disposable (fun () ->
            disposable.Dispose ()
        )

    /// ## prepareSpiral
    let prepareSpiral rawCellCode lines =
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

        if hasMain
        then rawCellCode, None
        else
            let lastTopLevelIndex, _ =
                (lines |> Array.indexed, (None, false))
                ||> Array.foldBack (fun (i, line) (lastTopLevelIndex, finished) ->
                    // trace Verbose (fun () -> $"Eval.prepareSpiral / i: {i} / line: '{line}' / lastTopLevelIndex: {lastTopLevelIndex} / finished: {finished}") _locals
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
                        || line |> SpiralSm.starts_with "and "
                        || line |> SpiralSm.starts_with "let " ->
                        let m =
                            System.Text.RegularExpressions.Regex.Match (
                                line,
                                @"^(?:and +)?(inl|let) +((?:[{( ]*)?[~\(\w]+[\w\d']*(?:|[\w\d']+[ }]*(?:&? *[\w\d']*\))?| *[~\w][\w\d']*\)|, *[~\w][\w\d']*)) +[:=](?! +function)"
                            )
                        trace Verbose (fun () -> $"Eval.prepareSpi / m: '{m}' / m.Groups.Count: {m.Groups.Count}") _locals
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

    /// ## processSpiralOutput
    let processSpiralOutput
        (props : {|
            printCode: bool
            traceLevel: TraceLevel
            builderCommands: string array
            lastTopLevelIndex: int option
            backend: Supervisor.Backend
            cancellationToken: _
            spiralErrors: _
            code: string
            outputPath: string
            isReal: bool
        |})
        = async {
        let inline _trace (fn : unit -> string) =
            if props.traceLevel = Verbose
            then trace Info (fun () -> $"Eval.processSpiralOutput / props: {props |> FSharp.Json.Json.serialize |> SpiralSm.ellipsis_end 400} / {fn ()}") _locals
            else fn () |> System.Console.WriteLine

        if props.printCode then
            let ext = props.outputPath |> System.IO.Path.GetExtension
            _trace (fun () -> if props.builderCommands.Length > 0 then $"{ext}:\n{props.code}\n" else props.code)

        let workspaceRootExternal =
            let currentDir =
                System.IO.Directory.GetCurrentDirectory ()
                |> SpiralSm.to_lower
            let workspaceRoot = workspaceRoot |> SpiralSm.to_lower
            if currentDir |> SpiralSm.starts_with workspaceRoot
            then None
            else Some workspaceRoot

        let! spiralBuilderResults =
            match props.builderCommands, props.lastTopLevelIndex with
            | [||], _ | _, None -> [||] |> Async.init
            | builderCommands, _ ->
                builderCommands
                |> Array.map (fun builderCommand ->
                    let path =
                        workspaceRoot </> $@"workspace/target/release/spiral_builder{SpiralPlatform.get_executable_suffix ()}"
                        |> System.IO.Path.GetFullPath
                    let commands =
                        if props.backend = Supervisor.Fsharp
                            && (
                                builderCommand |> SpiralSm.starts_with "rust"
                                || builderCommand |> SpiralSm.starts_with "typescript"
                                || builderCommand |> SpiralSm.starts_with "python"
                            )
                        then [| $"{path} fable --fs-path \"{props.outputPath}\" --command \"{builderCommand}\"" |]
                        elif props.backend = Supervisor.Cuda
                            && builderCommand |> SpiralSm.starts_with "cuda"
                        then [| $"{path} {builderCommand} --py-path \"{props.outputPath}\"" |]
                        else [||]
                    builderCommand, commands
                )
                |> Array.filter (fun (_, commands) -> commands.Length > 0)
                |> Array.map (fun (builderCommand, commands) ->
                    commands
                    |> Array.map (fun command -> async {
                        let! exitCode, result =
                            SpiralRuntime.execution_options (fun x ->
                                { x with
                                    l0 = command
                                    l1 = props.cancellationToken
                                    l2 = [|
                                        "AUTOMATION", assemblyName = "dotnet-repl" |> string
                                        "TRACE_LEVEL", $"%A{if props.printCode then props.traceLevel else Info}"
                                    |]
                                    l6 = workspaceRootExternal
                                }
                            )
                            |> SpiralRuntime.execute_with_options_async
                        trace Debug
                            (fun () -> $"Eval.processSpiralOutput / spiral_builder")
                            (fun () -> $"exitCode: {exitCode} / builderCommand: {builderCommand} / command: {command} / result: {result |> SpiralSm.ellipsis_end 400} / {_locals ()}")
                        return
                            if exitCode = 0
                            then {| code = result; eval = false; builderCommand = builderCommand |} |> Ok
                            else result |> Error
                    })
                )
                |> Array.collect id
                |> Async.Parallel

        let hasEval =
            props.backend = Supervisor.Fsharp
            && props.builderCommands |> Array.exists (fun x -> x |> SpiralSm.starts_with "fsharp")

        let outputResult =
            if props.builderCommands.Length > 0 && not hasEval
            then None
            else
                let code =
                    if props.builderCommands.Length > 1
                    then
                        let header = "System.Console.WriteLine \".fsx output:\"\n"
                        $"{header}{props.code}"
                    else props.code
                Some (Ok [ {| code = code; eval = true; builderCommand = "" |} ])

        match outputResult, spiralBuilderResults with
        | Some outputResult, [||] ->
            return outputResult, [||]
        | None, [||] ->
            return Ok [ {| code = "()"; eval = true; builderCommand = "" |} ], [||]
        | _, spiralBuilderResults ->
            try
                let spiralResults =
                    match outputResult with
                    | Some (Ok code) ->
                        spiralBuilderResults
                        |> Array.append (code |> List.map Ok |> List.toArray)
                    | _ -> spiralBuilderResults
                let codes =
                    spiralResults
                    |> Array.map (fun spiralBuilderResult' ->
                        let commandResult, errors =
                            match spiralBuilderResult' with
                            | Ok result when result.eval = false ->
                                let result' =
                                    result.code
                                    |> FSharp.Json.Json.deserialize<Map<string,string>>
                                let result =
                                    match result' |> Map.tryFind "command_result" with
                                    | Some result'' ->
                                        result''
                                        |> FSharp.Json.Json.deserialize<Map<string,string>>
                                        |> Map.add "builderCommand" result.builderCommand
                                    | None -> Map.empty
                                result, [||]
                            | Ok result when result.eval = true ->
                                let result =
                                    [
                                        "extension", "fsx"
                                        "code", result.code
                                        "output", ""
                                    ]
                                    |> Map.ofList
                                result, [||]
                            | Error error ->
                                Map.empty,
                                [|
                                    (
                                        TraceLevel.Critical, $"Eval.processSpiralOutput / evalResult error / errors[0] / outputPath: {props.outputPath} / builderCommands: %A{props.builderCommands} / spiralBuilderResult': %A{spiralBuilderResult'} / error: %A{error}", 0, ("", (0, 0), (0, 0))
                                    )
                                |]
                            | _ ->
                                Map.empty, [||]

                        if errors |> Array.isEmpty |> not
                        then Error (Exception $"Eval.processSpiralOutput / evalResult errors / Exception / commandResult: %A{commandResult}"), errors
                        else
                            let extension = commandResult.["extension"]
                            let code = commandResult.["code"]
                            let output = commandResult.["output"]
                            let builderCommand =
                                commandResult
                                |> Map.tryFind "builderCommand"
                                |> Option.defaultValue ""

                            let eval = output = "" && extension = "fsx"

                            if props.printCode && not eval
                            then _trace (fun () -> $""".{extension}:{'\n'}{code}""")

                            trace Debug
                                (fun () -> $"Eval.processSpiralOutput / result")
                                (fun () -> $"builderCommand: {builderCommand} / extension: {extension} / commandResult: {commandResult |> FSharp.Json.Json.serialize |> SpiralSm.ellipsis_end 400}/ {_locals ()}")

                            let code =
                                if props.printCode
                                    || spiralResults.Length > 1
                                    || props.builderCommands.Length > 1
                                then
                                    if eval then
                                        code
                                    else
                                        let header =
                                            let info =
                                                match props.backend, builderCommand with
                                                | Supervisor.Fsharp, builderCommand
                                                    when builderCommand |> SpiralSm.contains " " -> $" ({builderCommand})"
                                                | Supervisor.Fsharp, _ -> ""
                                                | _ -> $" ({props.backend})"
                                            if info = ""
                                            then $".{extension} output:\n"
                                            else $".{extension} output{info}:\n"
                                        $"""{if output |> SpiralSm.contains "\n" then "\n" else ""}{header}{output}"""
                                elif eval
                                then code
                                else output
                            Ok {| code = code; eval = eval; builderCommand = builderCommand |}, [||]
                    )
                trace Debug
                    (fun () -> $"Eval.processSpiralOutput / codes")
                    (fun () ->
                        let props = {| props with cancellationToken = None |}
                        $"codes: {codes |> FSharp.Json.Json.serialize |> SpiralSm.ellipsis_end 400} / spiralResults: {spiralResults |> FSharp.Json.Json.serialize |> SpiralSm.ellipsis_end 400} / spiralBuilderResults: {spiralBuilderResults |> FSharp.Json.Json.serialize |> SpiralSm.ellipsis_end 400} / props: {props |> FSharp.Json.Json.serialize |> SpiralSm.ellipsis_end 400} / {_locals ()}")
                return
                    (((Ok []), [||]), codes)
                    ||> Array.fold (fun (acc_code, acc_errors) (code, errors) ->
                        match code, acc_code with
                        | Ok code, Ok acc_code ->
                            let errors =
                                acc_errors
                                |> Array.append errors
                                |> Array.append props.spiralErrors
                            let errors =
                                if errors |> Array.isEmpty
                                then errors
                                else
                                    let code = $"%A{code}"
                                    errors
                                    |> Array.append [|
                                        TraceLevel.Critical, $"Eval.processSpiralOutput / errors / errors[-1] / outputPath: {props.outputPath} / builderCommands: %A{props.builderCommands} / code: {code |> SpiralSm.ellipsis_end 400}", 0, ("", (0, 0), (0, 0))
                                    |]
                            Ok (code :: acc_code), errors
                        | Error ex, _
                        | _, Error ex ->
                            Error (Exception $"Eval.processSpiralOutput / -1 / Exception / spiralBuilderResults: %A{spiralBuilderResults} / ex: {ex |> SpiralSm.format_exception}"),
                            acc_errors |> Array.append errors
                    )
            with ex ->
                trace Critical (fun () -> $"Eval.processSpiralOutput / try 2 ex / spiralBuilderResults: %A{spiralBuilderResults} / ex: {ex |> SpiralSm.format_exception}") _locals
                return
                    Error (Exception $"Eval.processSpiralOutput / try 2 ex / Exception / spiralBuilderResults: %A{spiralBuilderResults} / ex: {ex |> SpiralSm.format_exception}"),
                    [|
                        (
                            TraceLevel.Critical, $"Eval.processSpiralOutput / try 2 ex / errors[0] / spiralBuilderResults: %A{spiralBuilderResults} / ex: {ex |> SpiralSm.format_exception}", 0, ("", (0, 0), (0, 0))
                        )
                    |]
    }

    /// ## tryGetPropertyValue
    let tryGetPropertyValue (propertyName: string) (obj: obj) =
        let objType = obj.GetType ()
        let propertyInfo = propertyName |> objType.GetProperty
        if propertyInfo <> null
        then propertyInfo.GetValue (obj, null) |> Some
        else None

    /// ## eval
    let inline eval
        (fsi_eval:
            string
            -> System.Threading.CancellationToken
            -> Choice<'a, Exception> * (TraceLevel * string * int * (string * (int * int) * (int * int))) array)
        (cancellationToken: Option<System.Threading.CancellationToken>)
        (code: string)
        =
        trace Verbose
            (fun () -> $"Eval.eval")
            (fun () -> $"code: {code |> SpiralSm.ellipsis_end 400} / {_locals ()}")

        let rawCellCode =
            code |> SpiralSm.replace "\r\n" "\n"

        let lines = rawCellCode |> SpiralSm.split "\n"

        if lines |> Array.exists (fun line -> line |> SpiralSm.starts_with "#r " && line |> SpiralSm.ends_with "\"") then
            let cancellationToken = defaultArg cancellationToken System.Threading.CancellationToken.None
            let ch, errors = fsi_eval code cancellationToken
            trace Verbose (fun () -> $"Eval.eval / fsi_eval 1 / ch: %A{ch} / errors: {errors}") _locals
            match ch with
            | Choice1Of2 v -> Ok(v), errors
            | Choice2Of2 ex -> Error(ex), errors
        else
            let builderCommands =
                lines
                |> Array.choose (fun line ->
                    if line |> SpiralSm.starts_with "///! "
                    then line |> SpiralSm.split "///! " |> Array.tryItem 1
                    else None
                )

            let packages =
                lines
                |> Array.choose (fun line ->
                    if line |> SpiralSm.starts_with "//// package="
                    then line |> SpiralSm.split "=" |> Array.skip 1 |> SpiralSm.concat "" |> Some
                    else None
                )

            allPackages <- packages |> Array.append allPackages |> Array.distinct

            let timeout =
                lines
                |> Array.tryPick (fun line ->
                    if line |> SpiralSm.starts_with "//// timeout="
                    then line |> SpiralSm.split "=" |> Array.tryItem 1 |> Option.map int
                    else None
                )
                |> Option.defaultValue (60000 * 60)

            let boolArg def command =
                lines
                |> Array.tryPick (fun line ->
                    let text = $"//// {command}"
                    match line.[0..text.Length-1], line.[text.Length..] with
                    | head, "" when head = text ->
                        Some true
                    | head, _ when head = text ->
                        line |> SpiralSm.split "=" |> Array.tryItem 1 |> Option.map ((<>) "false")
                    | _ -> None
                )
                |> Option.defaultValue def

            let printCode = "print_code" |> boolArg false
            let isTraceToggle = "trace_toggle" |> boolArg false
            let isTrace = "trace" |> boolArg false
            let isCache = "cache" |> boolArg false
            let isReal = "real" |> boolArg false

            if isTraceToggle
            then traceToggle <- not traceToggle

            let oldLevel = get_trace_level ()
            let traceLevel =
                if isTrace || traceToggle
                then Verbose
                else Info
            traceLevel
            |> to_trace_level
            |> set_trace_level
            use _ = (new_disposable (fun () ->
                oldLevel |> set_trace_level
            ))

            async {
                try
                    let cellCode, lastTopLevelIndex = prepareSpiral rawCellCode lines
                    let newAllCode =
                        if isReal
                        then $"{allCodeReal}\n\n{cellCode}"
                        else $"{allCode}\n\n{cellCode}"

                    let buildBackends =
                        if builderCommands.Length = 0
                        then [| Supervisor.Fsharp |]
                        else
                            builderCommands
                            |> Array.map (fun x ->
                                if x |> SpiralSm.starts_with "cuda"
                                then Supervisor.Cuda
                                else Supervisor.Fsharp
                            )
                            |> Array.distinct

                    trace Verbose
                        (fun () -> $"Eval.eval")
                        (fun () -> $"lastTopLevelIndex: {lastTopLevelIndex} / builderCommands: %A{builderCommands} / buildBackends: %A{buildBackends} / isReal: {isReal} / {_locals ()}")

                    let! buildCodeResults =
                        buildBackends
                        |> Array.map (fun backend -> async {
                            let! result =
                                if isReal
                                then Supervisor.Spir newAllCode
                                else
                                    Supervisor.Spi
                                        (newAllCode, if allCodeReal = "" then None else Some allCodeReal)
                                |> Supervisor.buildCode backend allPackages isCache timeout cancellationToken
                            return backend, result
                        })
                        |> Async.Parallel
                        |> Async.catch
                        |> Async.runWithTimeoutAsync timeout

                    match buildCodeResults with
                    | Some (Ok buildCodeResults) ->
                        let! result, errors =
                            ((Ok [], [||]), buildCodeResults)
                            ||> Async.fold (fun acc buildCodeResult -> async {
                                match buildCodeResult with
                                | backend, (_, (outputPath, Some code), spiralErrors) ->
                                    let spiralErrors =
                                        mapErrors (Warning, spiralErrors, lastTopLevelIndex) allCode
                                    let! result =
                                        processSpiralOutput
                                            {|
                                                printCode = printCode
                                                traceLevel = traceLevel
                                                builderCommands = builderCommands
                                                lastTopLevelIndex = lastTopLevelIndex
                                                backend = backend
                                                cancellationToken = cancellationToken
                                                spiralErrors = spiralErrors
                                                code = code
                                                outputPath = outputPath
                                                isReal = isReal
                                            |}
                                    match result, acc with
                                    | (Ok code, errors), (Ok acc_code, acc_errors) ->
                                        return Ok (acc_code @ code), acc_errors |> Array.append errors
                                    | (Error ex, errors), _ | _, (Error ex, errors) ->
                                        return
                                            Error (Exception $"Eval.eval / processSpiralOutput / Exception / buildCodeResult: %A{buildCodeResult |> FSharp.Json.Json.serialize |> SpiralSm.ellipsis_end 400} / ex: {ex |> SpiralSm.format_exception}"),
                                            errors |> Array.append errors
                                | _, (_, _, errors) when errors |> List.isEmpty |> not ->
                                    return errors.[0] |> fst |> Exception |> Error,
                                    mapErrors (TraceLevel.Critical, errors, lastTopLevelIndex) allCode
                                | _ -> return acc
                            })
                        let cancellationToken = defaultArg cancellationToken System.Threading.CancellationToken.None
                        match result, errors with
                        | Ok code, [||] ->
                            let code, eval =
                                code
                                |> List.map (fun code ->
                                    if code.eval
                                    then None, Some code.code
                                    else Some code.code, None
                                )
                                |> List.unzip
                            let code = code |> List.choose id
                            let eval = eval |> List.choose id

                            trace Debug
                                (fun () -> $"Eval.eval")
                                (fun () -> $"eval: {eval |> FSharp.Json.Json.serialize |> SpiralSm.ellipsis_end 400} / code: {code |> FSharp.Json.Json.serialize |> SpiralSm.ellipsis_end 400} / {_locals ()}")

                            let ch, errors =
                                match eval, code with
                                | [], [] ->
                                    Choice2Of2 (Exception $"Eval.eval / eval=[] / code=[] / buildCodeResults: %A{buildCodeResults} / code: %A{code}"), errors
                                | [ eval ], [] ->
                                    let ch, errors2 = fsi_eval eval cancellationToken
                                    let errors =
                                        errors2
                                        // |> Array.map (fun (e1, e2, e3, _) ->
                                        //     (e1, e2, e3, ("", (0, 0), (0, 0)))
                                        // )
                                        |> Array.append errors
                                    ch, errors
                                | [], _ ->
                                    let code = code |> List.rev |> String.concat "\n\n"
                                    let code =
                                        if printCode
                                        then $"\"\"\"{code}\n\n\"\"\""
                                        else $"\"\"\"{code}\n\"\"\""
                                    let ch, errors2 = fsi_eval code cancellationToken
                                    let errors =
                                        errors2
                                        // |> Array.map (fun (e1, e2, e3, _) ->
                                        //     (e1, e2, e3, ("", (0, 0), (0, 0)))
                                        // )
                                        |> Array.append errors
                                    ch, errors
                                | _ ->
                                    let code, errors =
                                        ((Ok (code |> List.rev), [||]), eval)
                                        ||> List.fold (fun (acc, acc_errors) eval ->
                                            match acc with
                                            | Error ch -> Error ch, acc_errors
                                            | Ok acc ->
                                                let ch, errors = fsi_eval eval cancellationToken
                                                let errors =
                                                    errors
                                                    // |> Array.map (fun (e1, e2, e3, _) ->
                                                    //     (e1, e2, e3, ("", (0, 0), (0, 0)))
                                                    // )
                                                    |> Array.append acc_errors
                                                match ch with
                                                | Choice1Of2 v ->
                                                    let v =
                                                        v
                                                        |> tryGetPropertyValue "ReflectionValue"
                                                        |> Option.map (fun x -> $"%A{x}")
                                                        |> Option.defaultValue ""
                                                    Ok (v :: acc), errors
                                                | Choice2Of2 ex ->
                                                    trace Critical (fun () -> $"Eval.eval / fsi_eval fold Choice error / buildCodeResults: %A{buildCodeResults} / ex: {ex |> SpiralSm.format_exception}") _locals
                                                    Error ch, errors
                                        )
                                    match code with
                                    | Error ch -> ch, errors
                                    | Ok code ->
                                        let code =
                                            code
                                            |> List.filter ((<>) "")
                                            |> String.concat "\n\n"

                                        let code =
                                            if builderCommands.Length > 0 && eval.Length = 0
                                            then code
                                            elif code |> SpiralSm.contains "\n\n\n"
                                            then $"{code}\n\n"
                                            else $"{code}\n"

                                        let code =
                                            if printCode
                                            then $"\"\"\"{code}\n\n\n\"\"\""
                                            else $"\"\"\"{code}\n\"\"\""
                                        let ch, errors2 = fsi_eval code cancellationToken
                                        let errors =
                                            errors2
                                            // |> Array.map (fun (e1, e2, e3, _) ->
                                            //     (e1, e2, e3, ("", (0, 0), (0, 0)))
                                            // )
                                            |> Array.append errors
                                        ch, errors
                            match ch with
                            | Choice1Of2 v ->
                                if isReal
                                then allCodeReal <- newAllCode
                                else allCode <- newAllCode
                                return Ok(v), errors
                            | Choice2Of2 ex ->
                                return
                                    Error (Exception $"Eval.eval / -2 / Exception / ex: {ex |> SpiralSm.format_exception} / buildCodeResults: {buildCodeResults |> FSharp.Json.Json.serialize |> SpiralSm.ellipsis_end 400}"),
                                    errors
                        | Ok code, errors ->
                            return
                                Error (Exception "Eval.eval / errors / buildCodeResults: %A{buildCodeResults} / code: %A{code}"),
                                errors
                        | Error ex, errors ->
                            return
                                Error (Exception $"Eval.eval / -1 / Exception / ex: {ex |> SpiralSm.format_exception} / buildCodeResults: {buildCodeResults |> FSharp.Json.Json.serialize |> SpiralSm.ellipsis_end 1500}"),
                                errors
                    | Some (Error ex) ->
                        trace Critical (fun () -> $"Eval.eval / buildCodeResults Error / buildCodeResults: %A{buildCodeResults} / ex: {ex |> SpiralSm.format_exception}") _locals
                        return
                            Error (Exception $"Eval.eval / buildCodeResults Error / Exception / buildCodeResults: %A{buildCodeResults} / ex: {ex |> SpiralSm.format_exception}"),
                            [|
                                (
                                    TraceLevel.Critical, $"Eval.eval / buildCodeResults Error / errors[0] / ex: {ex |> SpiralSm.format_exception} / buildCodeResults: %A{buildCodeResults}", 0, ("", (0, 0), (0, 0))
                                )
                            |]
                    | _ ->
                        return
                            Error (Exception $"Eval.eval / buildCodeResults / Exception / buildCodeResults: %A{buildCodeResults}"),
                            [|
                                (
                                    TraceLevel.Critical, $"Eval.eval / buildCodeResults / errors[0] / buildCodeResults: %A{buildCodeResults}", 0, ("", (0, 0), (0, 0))
                                )
                            |]
                with ex ->
                    trace Critical (fun () -> $"Eval.eval / try 1 ex / ex: {ex |> SpiralSm.format_exception} / lines: %A{lines}") _locals
                    return
                        Error (Exception $"Eval.eval / try 1 ex / Exception / ex: {ex |> SpiralSm.format_exception} / lines: %A{lines}"),
                        [|
                            (
                                TraceLevel.Critical, $"Eval.eval / try 1 ex / errors[0] / ex: {ex |> SpiralSm.format_exception} / lines: %A{lines}", 0, ("", (0, 0), (0, 0))
                            )
                        |]
            }
            |> Async.runWithTimeout timeout
            |> Option.defaultValue (
                Error (Exception $"Eval.eval / Async.runWithTimeout / Exception / timeout: {timeout} / lines: %A{lines}"),
                [|
                    (
                        TraceLevel.Critical, $"Eval.eval / Async.runWithTimeout / errors[0] / timeout: {timeout} / lines: %A{lines}", 0, ("", (0, 0), (0, 0))
                    )
                |]
            )
