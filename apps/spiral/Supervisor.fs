#if !INTERACTIVE
namespace Polyglot
#endif

module Supervisor =

#if !INTERACTIVE
    open Lib
#endif

    open Common
    open SpiralFileSystem.Operators
    open Microsoft.AspNetCore.SignalR.Client

    /// ### sendJson
    let inline sendJson (port : int) (json : string) = async {
        let host = "127.0.0.1"
        let! portOpen = SpiralNetworking.test_port_open host port
        if portOpen then
            try
                let connection = HubConnectionBuilder().WithUrl($"http://{host}:{port}").Build()
                do! connection.StartAsync () |> Async.AwaitTask
                let! result = connection.InvokeAsync<string>("ClientToServerMsg", json) |> Async.AwaitTask
                do! connection.StopAsync () |> Async.AwaitTask
                trace Verbose (fun () -> $"Supervisor.sendJson / port: {port} / json: {json |> SpiralSm.ellipsis_end 200} / result: {result |> Option.ofObj |> Option.map (SpiralSm.ellipsis_end 200)}") _locals
                return Some result
            with ex ->
                trace Critical (fun () -> $"Supervisor.sendJson / port: {port} / json: {json |> SpiralSm.ellipsis_end 200} / ex: {ex |> SpiralSm.format_exception}") _locals
                return None
        else
            trace Debug (fun () -> "Supervisor.sendJson / port: {port} / error: port not open") _locals
            return None
    }

    /// ### sendObj
    let inline sendObj port obj =
        obj
        |> System.Text.Json.JsonSerializer.Serialize
        |> sendJson port

    /// ### VSCPos
    type VSCPos = {| line : int; character : int |}

    /// ### VSCRange
    type VSCRange = VSCPos * VSCPos

    /// ### RString
    type RString = VSCRange * string

    /// ### TracedError
    type TracedError = {| trace : string list; message : string |}

    /// ### ClientErrorsRes
    type ClientErrorsRes =
        | FatalError of string
        | TracedError of TracedError
        | PackageErrors of {| uri : string; errors : RString list |}
        | TokenizerErrors of {| uri : string; errors : RString list |}
        | ParserErrors of {| uri : string; errors : RString list |}
        | TypeErrors of {| uri : string; errors : RString list |}

    /// ### workspaceRoot
    let workspaceRoot = SpiralFileSystem.get_workspace_root ()

    /// ### awaitCompiler
    let inline awaitCompiler port cancellationToken = async {
        let host = "127.0.0.1"
        let struct (ct, disposable) = cancellationToken |> SpiralThreading.new_disposable_token
        let! ct = ct |> SpiralAsync.merge_cancellation_token_with_default_async

        let compiler = MailboxProcessor.Start (fun inbox -> async {
            let! availablePort = SpiralNetworking.get_available_port (Some 180) host port
            if availablePort <> port then
                inbox.Post (port, false)
            else
                let compilerPath =
                    workspaceRoot </> "deps/The-Spiral-Language/The Spiral Language 2/artifacts/bin/The Spiral Language 2/release"
                    |> System.IO.Path.GetFullPath

                let dllPath = compilerPath </> "Spiral.dll"

                let! exitCode, result =
                    SpiralRuntime.execution_options (fun x ->
                        { x with
                            l0 = $@"dotnet ""{dllPath}"" --port {availablePort} --default-int i32 --default-float f64"
                            l1 = Some ct
                            l3 = Some (fun struct (_, line, _) -> async {
                                if line |> SpiralSm.contains $"System.IO.IOException: Failed to bind to address http://{host}:{port}: address already in use." then
                                    inbox.Post (port, false)

                                if line |> SpiralSm.contains $"Server bound to: http://localhost:{availablePort}" then
                                    let rec loop retry = async {
                                        do!
                                            SpiralNetworking.wait_for_port_access (Some 60) true host availablePort
                                            |> Async.runWithTimeoutAsync 200
                                            |> Async.Ignore

                                        let _locals () = $"port: {availablePort} / retry: {retry} / {_locals ()}"
                                        try
                                            let pingObj = {| Ping = true |}
                                            let! pingResult = pingObj |> sendObj availablePort
                                            trace Verbose (fun () -> $"awaitCompiler / Ping / result: '{pingResult}'") _locals

                                            inbox.Post (availablePort, true)
                                        with ex ->
                                            trace Verbose (fun () -> $"awaitCompiler / Ping / ex: {ex |> SpiralSm.format_exception}") _locals
                                            do! Async.Sleep 10
                                            do! loop (retry + 1)
                                    }
                                    do! loop 0
                            })
                            l6 = Some workspaceRoot
                        }
                    )
                    |> SpiralRuntime.execute_with_options_async

                trace Debug (fun () -> $"awaitCompiler / exitCode: {exitCode} / result: {result}") _locals
                disposable.Dispose ()
        }, ct)

        let! serverPort, managed = compiler.Receive ()

        let connection = HubConnectionBuilder().WithUrl($"http://{host}:{serverPort}").Build ()
        do! connection.StartAsync () |> Async.AwaitTask

        let event = Event<_> ()
        let disposable' = connection.On<string> ("ServerToClientMsg", event.Trigger)
        let stream =
            FSharp.Control.AsyncSeq.unfoldAsync
                (fun () -> async {
                    let! msg = event.Publish |> Async.AwaitEvent
                    return Some (msg |> FSharp.Json.Json.deserialize<ClientErrorsRes>, ())
                })
                ()

        let disposable' =
            new_disposable (fun () ->
                async {
                    disposable'.Dispose ()
                    do! connection.StopAsync () |> Async.AwaitTask
                    disposable.Dispose ()
                    if managed
                    then do!
                        SpiralNetworking.wait_for_port_access (Some 100) false host serverPort
                        |> Async.runWithTimeoutAsync 1500
                        |> Async.Ignore
                }
                |> Async.RunSynchronously
            )

        return
            serverPort,
            stream,
            ct,
            disposable'
    }

    /// ### getFilePathFromUri
    let inline getFilePathFromUri uri =
        match System.Uri.TryCreate (uri, System.UriKind.Absolute) with
        | true, uri -> uri.AbsolutePath |> System.IO.Path.GetFullPath
        | _ -> failwith "invalid uri"

    /// ### getCompilerPort
    let inline getCompilerPort () =
        13805

    /// ### serialize_obj
    let serializeObj obj =
            try
                obj
                |> FSharp.Json.Json.serialize
                |> SpiralSm.replace "\\\\" "\\"
                |> SpiralSm.replace "\\r\\n" "\n"
                |> SpiralSm.replace "\\n" "\n"
            with ex ->
                trace Critical (fun () -> "Supervisor.serialize_obj / obj: %A{obj}") _locals
                ""

    /// ### Backend
    type Backend =
        | Fsharp
        | Cuda

    /// ### buildFile
    let inline buildFile backend timeout port cancellationToken path =
        let rec loop retry = async {
            let fullPath = path |> System.IO.Path.GetFullPath
            let fileDir = fullPath |> System.IO.Path.GetDirectoryName
            let fileName = fullPath |> System.IO.Path.GetFileNameWithoutExtension
            let! code = fullPath |> SpiralFileSystem.read_all_text_async

            let stream, disposable = fileDir |> FileSystem.watchDirectory (fun _ -> true)
            use _ = disposable

            let struct (token, disposable) = SpiralThreading.new_disposable_token cancellationToken
            use _ = disposable

            let port = port |> Option.defaultWith getCompilerPort
            let! serverPort, errors, ct, disposable = awaitCompiler port (Some token)
            use _ = disposable

            let outputFileName =
                match backend with
                | Fsharp -> $"{fileName}.fsx"
                | Cuda -> $"{fileName}.py"

            let outputContentSeq =
                stream
                |> FSharp.Control.AsyncSeq.chooseAsync (function
                    | _, (FileSystem.FileSystemChange.Changed (path, Some text))
                        when (path |> System.IO.Path.GetFileName) = outputFileName
                        ->
                            // fileDir </> path |> SpiralFileSystem.read_all_text_retry_async
                            text |> Some |> Async.init
                    | _ -> None |> Async.init
                )
                |> FSharp.Control.AsyncSeq.map (fun content ->
                    Some (content |> SpiralSm.replace "\r\n" "\n"), None
                )

            let inline printErrorData (data : {| uri : string; errors : RString list |}) =
                let fileName = data.uri |> System.IO.Path.GetFileName
                let errors =
                    data.errors
                    |> List.map snd
                    |> SpiralSm.concat "\n"
                $"{fileName}:\n{errors}"

            let errorsSeq =
                errors
                |> FSharp.Control.AsyncSeq.choose (fun error ->
                    match error with
                    | FatalError message ->
                        Some (message, error)
                    | TracedError data ->
                        Some (data.message, error)
                    | PackageErrors data when data.errors |> List.isEmpty |> not ->
                        Some (data |> printErrorData, error)
                    | TokenizerErrors data when data.errors |> List.isEmpty |> not ->
                        Some (data |> printErrorData, error)
                    | ParserErrors data when data.errors |> List.isEmpty |> not ->
                        Some (data |> printErrorData, error)
                    | TypeErrors data when data.errors |> List.isEmpty |> not ->
                        Some (data |> printErrorData, error)
                    | _ -> None
                )
                |> FSharp.Control.AsyncSeq.map (fun (message, error) ->
                    None, Some (message, error)
                )

            let timerSeq =
                500
                |> FSharp.Control.AsyncSeq.intervalMs
                |> FSharp.Control.AsyncSeq.map (fun _ -> None, None)

            let outputSeq =
                [ outputContentSeq; errorsSeq; timerSeq ]
                |> FSharp.Control.AsyncSeq.mergeAll

            let! outputChild =
                ((None, [], 0), outputSeq)
                ||> FSharp.Control.AsyncSeq.scan (
                    fun (outputContentResult, errors, typeErrorCount) (outputContent, error) ->
                        trace Debug (fun () -> $"Supervisor.buildFile / AsyncSeq.scan / outputContent: {outputContent |> Option.defaultValue System.String.Empty |> SpiralSm.ellipsis_end 400} / errors: {errors |> serializeObj} / outputContentResult: {outputContentResult} / typeErrorCount: {typeErrorCount} / retry: {retry} / error: {error} / path: {path}") _locals
                        match outputContent, error with
                        | Some outputContent, None -> Some outputContent, errors, typeErrorCount
                        | None, Some (_, FatalError "File main has a type error somewhere in its path.") ->
                            outputContentResult, errors, typeErrorCount + 1
                        | None, Some error -> outputContentResult, error :: errors, typeErrorCount
                        | None, None when typeErrorCount >= 1 ->
                            outputContentResult, errors, typeErrorCount + 1
                        | _ -> outputContentResult, errors, typeErrorCount
                )
                |> FSharp.Control.AsyncSeq.takeWhileInclusive (fun (outputContent, errors, typeErrorCount) ->
                    trace Debug (fun () -> $"Supervisor.buildFile / takeWhileInclusive / outputContent: {outputContent |> Option.defaultValue System.String.Empty |> SpiralSm.ellipsis_end 400} / errors: {errors |> serializeObj} / typeErrorCount: {typeErrorCount} / retry: {retry} / path: {path}") _locals
        #if INTERACTIVE
                    let errorWait = 2
        #else
                    let errorWait = 2
        #endif
                    match outputContent, errors with
                    | None, [] when typeErrorCount > errorWait -> false
                    | None, [] -> true
                    | _ -> false
                )
                |> FSharp.Control.AsyncSeq.tryLast
                |> Async.withCancellationToken ct
                |> Async.catch
                |> Async.runWithTimeoutAsync timeout
                |> Async.StartChild

            do! Async.Sleep 60

            let fullPathUri = fullPath |> SpiralFileSystem.normalize_path |> SpiralFileSystem.new_file_uri

            let fileOpenObj = {| FileOpen = {| uri = fullPathUri; spiText = code |} |}
            let! _fileOpenResult = fileOpenObj |> sendObj serverPort

            do! Async.Sleep 60

            let backendId =
                match backend with
                | Fsharp -> "Fsharp"
                | Cuda -> "Python + Cuda"
            let buildFileObj = {| BuildFile = {| uri = fullPathUri; backend = backendId |} |}
            let! _buildFileResult = buildFileObj |> sendObj serverPort

            let! result, typeErrorCount =
                outputChild
                |> Async.map (function
                    | Some (Ok (Some (outputCode, errors, typeErrorCount))) ->
                        (outputCode, errors |> List.distinct |> List.rev), typeErrorCount
                    | Some (Error ex) ->
                        trace Critical (fun () -> $"Supervisor.buildFile / error: {ex |> SpiralSm.format_exception} / retry: {retry}") _locals
                        (None, []), 0
                    | _ -> (None, []), 0
                )

            match result with
            | None, _ when typeErrorCount > 0 && retry = 0 ->
                return! loop (retry + 1)
            | _ ->
                if fileDir |> SpiralSm.starts_with (workspaceRoot </> "target") then
                    let fileDirUri = fileDir |> SpiralFileSystem.normalize_path |> SpiralFileSystem.new_file_uri
                    let fileDeleteObj = {| FileDelete = {| uris = [| fileDirUri |] |} |}
                    let! _fileDeleteResult = fileDeleteObj |> sendObj serverPort
                    ()

                let outputPath = fileDir </> outputFileName
                return outputPath, result
        }
        loop 0

    /// ### SpiralInput
    type SpiralInput =
        | Spi of string * string option
        | Spir of string

    /// ### persistCode
    let inline persistCode backend input = async {
        let targetDir = workspaceRoot </> "target/spiral_Eval"

        let packagesDir = targetDir </> "packages"

        let hashHex = $"%A{backend}%A{input}" |> SpiralCrypto.hash_text

        let codeDir = packagesDir </> hashHex
        codeDir |> System.IO.Directory.CreateDirectory |> ignore

        let moduleName = "main"

        let spirModule, spiModule =
            match input with
            | Spi (spi, Some spir) -> true, true
            | Spi (spi, None) -> false, true
            | Spir spir -> true, false
            |> fun (spir, spi) ->
                (if spir then $"real_{moduleName}*-" else ""),
                if spi then moduleName else ""

        let spiprojPath = codeDir </> "package.spiproj"
        let spiprojCode =
            $"""packageDir: {workspaceRoot </> "lib"}
packages:
    |core-
    spiral-
modules:
    {spirModule}
    {spiModule}
"""
        do! spiprojCode |> SpiralFileSystem.write_all_text_exists spiprojPath

        let spirPath = codeDir </> $"real_{moduleName}.spir"
        let spiPath = codeDir </> $"{moduleName}.spi"

        let spirCode, spiCode =
            match input with
            | Spi (spi, Some spir) -> Some spir, Some spi
            | Spi (spi, None) -> None, Some spi
            | Spir spir -> Some spir, None

        match spirCode with
        | Some spir -> do! spir |> SpiralFileSystem.write_all_text_exists spirPath
        | None -> ()
        match spiCode with
        | Some spi -> do! spi |> SpiralFileSystem.write_all_text_exists spiPath
        | None -> ()

        let spiralPath =
            match input with
            | Spi _ -> spiPath
            | Spir _ -> spirPath
        match backend with
        | None -> return spiralPath, None
        | Some backend ->
            let outputFileName =
                let fileName =
                    match input with
                    | Spi _ -> moduleName
                    | Spir _ -> $"real_{moduleName}"
                match backend with
                | Fsharp -> $"{fileName}.fsx"
                | Cuda -> $"{fileName}.py"
            let outputPath = codeDir </> outputFileName
            if outputPath |> System.IO.File.Exists |> not
            then return spiralPath, None
            else
                let! oldCode = spiralPath |> SpiralFileSystem.read_all_text_async
                if oldCode <> (spiCode |> Option.defaultValue (spirCode |> Option.defaultValue ""))
                then return spiralPath, None
                else
                    let! outputCode = outputPath |> SpiralFileSystem.read_all_text_async
                    return spiralPath, Some (outputPath, outputCode |> SpiralSm.replace "\r\n" "\n")
        }

    /// ### buildCode
    let buildCode backend isCache timeout cancellationToken input = async {
        let! mainPath, outputCache = input |> persistCode (Some backend)
        match outputCache with
        | Some (outputPath, outputCode) when isCache -> return mainPath, (outputPath, Some outputCode), []
        | _ ->
            let! outputPath, (outputCode, errors) = mainPath |> buildFile backend timeout None cancellationToken
            return mainPath, (outputPath, outputCode), errors
    }

    /// ## getFileTokenRange
    let inline getFileTokenRange port cancellationToken path = async {
        let fullPath = path |> System.IO.Path.GetFullPath
        let! code = fullPath |> SpiralFileSystem.read_all_text_async
        let lines = code |> SpiralSm.split "\n"

        let struct (token, disposable) = SpiralThreading.new_disposable_token cancellationToken
        use _ = disposable

        let port = port |> Option.defaultWith getCompilerPort
        let! serverPort, _errors, ct, disposable = awaitCompiler port (Some token)
        use _ = disposable

        let fullPathUri = fullPath |> SpiralFileSystem.normalize_path |> SpiralFileSystem.new_file_uri

        let fileOpenObj = {| FileOpen = {| uri = fullPathUri; spiText = code |} |}
        let! _fileOpenResult = fileOpenObj |> sendObj serverPort

        do! Async.Sleep 60

        let fileTokenRangeObj =
            {|
                FileTokenRange =
                    {|
                        uri = fullPathUri
                        range =
                            [|
                                {| line = 0; character = 0 |}
                                {| line = lines.Length - 1; character = lines.[lines.Length - 1].Length |}
                            |]
                    |}
            |}
        let! fileTokenRangeResult =
            fileTokenRangeObj
            |> sendObj serverPort
            |> Async.withCancellationToken ct

        let fileDir = fullPath |> System.IO.Path.GetDirectoryName
        if fileDir |> SpiralSm.starts_with (workspaceRoot </> "target") then
            let fileDirUri = fileDir |> SpiralFileSystem.normalize_path |> SpiralFileSystem.new_file_uri
            let fileDeleteObj = {| FileDelete = {| uris = [| fileDirUri |] |} |}
            let! _fileDeleteResult = fileDeleteObj |> sendObj serverPort
            ()

        return fileTokenRangeResult |> Option.map FSharp.Json.Json.deserialize<int array>
    }

    /// ## getCodeTokenRange
    let inline getCodeTokenRange cancellationToken code = async {
        let! mainPath, _ = Spi (code, None) |> persistCode None

        let codeDir = mainPath |> System.IO.Path.GetDirectoryName
        let tokensPath = codeDir </> "tokens.json"
        let! tokens = async {
            if tokensPath |> System.IO.File.Exists |> not
            then return None
            else
                let! text = tokensPath |> SpiralFileSystem.read_all_text_async

                return
                    if text.Length > 2
                    then text |> FSharp.Json.Json.deserialize<int array> |> Some
                    else None
        }
        match tokens with
        | Some tokens ->
            return tokens |> Some
        | None -> return! mainPath |> getFileTokenRange None cancellationToken
    }

    /// ## Arguments
    [<RequireQualifiedAccess>]
    type Arguments =
        | Build_File of string * string
        | File_Token_Range of string * string
        | Execute_Command of string
        | [<Argu.ArguAttributes.Unique>] Timeout of int
        | [<Argu.ArguAttributes.Unique>] Port of int
        | [<Argu.ArguAttributes.Unique>] Parallel
        | [<Argu.ArguAttributes.Unique>] Exit_On_Error

        interface Argu.IArgParserTemplate with
            member s.Usage =
                match s with
                | Build_File _ -> nameof Build_File
                | File_Token_Range _ -> nameof File_Token_Range
                | Execute_Command _ -> nameof Execute_Command
                | Timeout _ -> nameof Timeout
                | Port _ -> nameof Port
                | Parallel -> nameof Parallel
                | Exit_On_Error-> nameof Exit_On_Error

    /// ## main
    let main args =
        let argsMap = args |> Runtime.parseArgsMap<Arguments>

        let buildFileActions =
            argsMap
            |> Map.tryFind (nameof Arguments.Build_File)
            |> Option.defaultValue []
            |> List.choose (function
                | Arguments.Build_File (inputPath, outputPath) -> Some (inputPath, outputPath)
                | _ -> None
            )

        let fileTokenRangeActions =
            argsMap
            |> Map.tryFind (nameof Arguments.File_Token_Range)
            |> Option.defaultValue []
            |> List.choose (function
                | Arguments.File_Token_Range (inputPath, outputPath) -> Some (inputPath, outputPath)
                | _ -> None
            )

        let executeCommandActions =
            argsMap
            |> Map.tryFind (nameof Arguments.Execute_Command)
            |> Option.defaultValue []
            |> List.choose (function
                | Arguments.Execute_Command command -> Some command
                | _ -> None
            )

        let timeout =
            match argsMap |> Map.tryFind (nameof Arguments.Timeout) with
            | Some [ Arguments.Timeout timeout ] -> timeout
            | _ -> 60000 * 60

        let port =
            match argsMap |> Map.tryFind (nameof Arguments.Port) with
            | Some [ Arguments.Port port ] -> Some port
            | _ -> None

        let isParallel = argsMap |> Map.containsKey (nameof Arguments.Parallel)

        let isExitOnError = argsMap |> Map.containsKey (nameof Arguments.Exit_On_Error)

        async {
            let port =
                port
                |> Option.defaultWith getCompilerPort
            let struct (localToken, disposable) = SpiralThreading.new_disposable_token None
            let! serverPort, _errors, compilerToken, disposable = awaitCompiler port (Some localToken)
            use _ = disposable

            let buildFileAsync =
                buildFileActions
                |> List.map (fun (inputPath, outputPath) -> async {
                    let! _outputPath, (outputCode, errors) =
                        let backend =
                            if outputPath |> SpiralSm.ends_with ".fsx"
                            then Fsharp
                            elif outputPath |> SpiralSm.ends_with ".py"
                            then Cuda
                            else failwith $"Supervisor.main / invalid backend / outputPath: {outputPath}"
                        let isReal = inputPath |> SpiralSm.ends_with ".spir"
                        inputPath |> buildFile backend timeout (Some serverPort) None

                    errors
                    |> List.map snd
                    |> List.iter (fun error ->
                        trace Critical (fun () -> $"main / error: {error |> serializeObj}") _locals
                    )

                    match outputCode with
                    | Some outputCode ->
                        do! outputCode |> SpiralFileSystem.write_all_text_exists outputPath
                        return 0
                    | None ->
                        if isExitOnError
                        then SpiralRuntime.current_process_kill ()

                        return 1
                })

            let fileTokenRangeAsync =
                fileTokenRangeActions
                |> List.map (fun (inputPath, outputPath) -> async {
                    let! tokenRange = inputPath |> getFileTokenRange (Some serverPort) None
                    match tokenRange with
                    | Some tokenRange ->
                        do! tokenRange |> FSharp.Json.Json.serialize |> SpiralFileSystem.write_all_text_exists outputPath
                        return 0
                    | None ->
                        if isExitOnError
                        then SpiralRuntime.current_process_kill ()

                        return 1
                })

            let executeCommandAsync =
                executeCommandActions
                |> List.map (fun command -> async {
                    let! exitCode, result =
                        SpiralRuntime.execution_options (fun x ->
                            { x with
                                l0 = command
                                l1 = Some compilerToken
                            }
                        )
                        |> SpiralRuntime.execute_with_options_async

                    trace Debug (fun () -> $"main / executeCommand / exitCode: {exitCode} / command: {command}") _locals

                    if isExitOnError && exitCode <> 0
                    then SpiralRuntime.current_process_kill ()

                    return exitCode
                })

            return!
                [| buildFileAsync; fileTokenRangeAsync; executeCommandAsync |]
                |> Seq.collect id
                |> fun x ->
                    if isParallel
                    then Async.Parallel (x, float System.Environment.ProcessorCount * 0.51 |> ceil |> int)
                    else Async.Sequential x
                |> Async.map Array.sum
        }
        |> Async.runWithTimeout timeout
        |> Option.defaultValue 1
