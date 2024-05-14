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

    /// ## sendJson
    let inline sendJson (port : int) (json : string) = async {
        let! portOpen = SpiralNetworking.test_port_open port
        if portOpen then
            try
                let connection = HubConnectionBuilder().WithUrl($"http://127.0.0.1:{port}").Build()
                do! connection.StartAsync () |> Async.AwaitTask
                let! result = connection.InvokeAsync<string>("ClientToServerMsg", json) |> Async.AwaitTask
                do! connection.StopAsync () |> Async.AwaitTask
                trace Verbose (fun () -> $"sendJson / port: {port} / json: {json |> SpiralSm.ellipsis_end 200} / result: {result |> Option.ofObj |> Option.map (SpiralSm.ellipsis_end 200)}") _locals
                return Some result
            with ex ->
                trace Critical (fun () -> $"sendJson / port: {port} / json: {json |> SpiralSm.ellipsis_end 200} / ex: {ex |> SpiralSm.format_exception}") _locals
                return None
        else
            trace Debug (fun () -> "sendJson / error: port not open") _locals
            return None
    }

    /// ## sendObj
    let inline sendObj port obj =
        obj
        |> System.Text.Json.JsonSerializer.Serialize
        |> sendJson port

    /// ## awaitCompiler
    type VSCPos = {| line : int; character : int |}
    type VSCRange = VSCPos * VSCPos
    type RString = VSCRange * string
    type TracedError = {| trace : string list; message : string |}
    type ClientErrorsRes =
        | FatalError of string
        | TracedError of TracedError
        | PackageErrors of {| uri : string; errors : RString list |}
        | TokenizerErrors of {| uri : string; errors : RString list |}
        | ParserErrors of {| uri : string; errors : RString list |}
        | TypeErrors of {| uri : string; errors : RString list |}

    let workspaceRoot = SpiralFileSystem.get_workspace_root ()

    let inline awaitCompiler port cancellationToken = async {
        let host = "127.0.0.1"
        let struct (ct, disposable) = cancellationToken |> SpiralThreading.new_disposable_token
        let! ct = ct |> SpiralAsync.merge_cancellation_token_with_default_async

        let compiler = MailboxProcessor.Start (fun inbox -> async {
            let! availablePort = SpiralNetworking.get_available_port (Some 500) port
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
                            l0 = Some ct
                            l1 = $@"dotnet ""{dllPath}"" --port {availablePort} --default-int i32 --default-float f64"
                            l3 = Some (fun struct (_, line, _) -> async {
                                if line |> SpiralSm.contains $"System.IO.IOException: Failed to bind to address http://{host}:{port}: address already in use." then
                                    inbox.Post (port, false)

                                if line |> SpiralSm.contains $"Server bound to: http://localhost:{availablePort}" then
                                    let rec loop retry = async {
                                        do!
                                            SpiralNetworking.wait_for_port_access (Some 100) true availablePort
                                            |> Async.runWithTimeoutAsync 2000
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
                            l5 = Some workspaceRoot
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
                        SpiralNetworking.wait_for_port_access (Some 100) false serverPort
                        |> Async.runWithTimeoutAsync 2000
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

    /// ## getFilePathFromUri
    let inline getFilePathFromUri uri =
        match System.Uri.TryCreate (uri, System.UriKind.Absolute) with
        | true, uri -> uri.AbsolutePath |> System.IO.Path.GetFullPath
        | _ -> failwith "invalid uri"

    /// ## getCompilerPort
    let inline getCompilerPort () =
        13805

    /// ## serialize_obj
    let serializeObj obj =
            obj
            |> FSharp.Json.Json.serialize
            |> SpiralSm.replace "\\\\" "\\"
            |> SpiralSm.replace "\\r\\n" "\n"
            |> SpiralSm.replace "\\n" "\n"

    /// ## buildFile
    let inline buildFile timeout port cancellationToken path = async {
        let fullPath = path |> System.IO.Path.GetFullPath
        let fileDir = fullPath |> System.IO.Path.GetDirectoryName
        let fileName = fullPath |> System.IO.Path.GetFileNameWithoutExtension
        let! code = fullPath |> SpiralFileSystem.read_all_text_async

        let stream, disposable = fileDir |> FileSystem.watchDirectory (fun _ -> false)
        use _ = disposable

        let struct (token, disposable) = SpiralThreading.new_disposable_token cancellationToken
        use _ = disposable

        let! serverPort, errors, ct, disposable = awaitCompiler port (Some token)
        use _ = disposable

        let fsxContentSeq =
            stream
            |> FSharp.Control.AsyncSeq.chooseAsync (function
                | _, (FileSystem.FileSystemChange.Changed (path, _))
                    when (path |> System.IO.Path.GetFileName) = $"{fileName}.fsx"
                    ->
                        fileDir </> path |> SpiralFileSystem.read_all_text_retry_async
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
            1000
            |> FSharp.Control.AsyncSeq.intervalMs
            |> FSharp.Control.AsyncSeq.map (fun _ -> None, None)

        let outputSeq =
            [ fsxContentSeq; errorsSeq; timerSeq ]
            |> FSharp.Control.AsyncSeq.mergeAll

        let! outputChild =
            ((None, [], 0), outputSeq)
            ||> FSharp.Control.AsyncSeq.scan (
                fun (fsxContentResult, errors, typeErrorCount) (fsxContent, error) ->
                    match fsxContent, error with
                    | Some fsxContent, None -> Some fsxContent, errors, typeErrorCount
                    | None, Some (_, FatalError "File main has a type error somewhere in its path.") ->
                        fsxContentResult, errors, typeErrorCount + 1
                    | None, Some error -> fsxContentResult, error :: errors, typeErrorCount
                    | None, None when typeErrorCount >= 1 ->
                        fsxContentResult, errors, typeErrorCount + 1
                    | _ -> fsxContentResult, errors, typeErrorCount
            )
            |> FSharp.Control.AsyncSeq.takeWhileInclusive (fun (fsxContent, errors, typeErrorCount) ->
                trace Debug (fun () -> $"buildFile / takeWhileInclusive / path: {path} / fsxContent: {fsxContent |> Option.defaultValue System.String.Empty |> SpiralSm.ellipsis_end 400} / errors: {errors |> serializeObj} / typeErrorCount: {typeErrorCount}") _locals
#if INTERACTIVE
                let errorWait = 2
#else
                let errorWait = 4
#endif
                match fsxContent, errors with
                | None, [] when typeErrorCount > errorWait -> false
                | None, [] -> true
                | _ -> false
            )
            |> FSharp.Control.AsyncSeq.tryLast
            |> Async.withCancellationToken ct
            |> Async.catch
            |> Async.runWithTimeoutAsync timeout
            |> Async.StartChild

        let fullPathUri = fullPath |> SpiralFileSystem.normalize_path |> SpiralFileSystem.new_file_uri

        let fileOpenObj = {| FileOpen = {| uri = fullPathUri; spiText = code |} |}
        let! _fileOpenResult = fileOpenObj |> sendObj serverPort

        // do! Async.Sleep 60

        let buildFileObj = {| BuildFile = {| uri = fullPathUri; backend = "Fsharp" |} |}
        let! _buildFileResult = buildFileObj |> sendObj serverPort

        let! result =
            outputChild
            |> Async.map (function
                | Some (Ok (Some (fsxCode, errors, _))) ->
                    fsxCode, errors |> List.distinct |> List.rev
                | Some (Error ex) ->
                    trace Critical (fun () -> $"buildFile / error: {ex |> serializeObj}") _locals
                    None, []
                | _ -> None, []
            )

        if fileDir |> SpiralSm.starts_with (workspaceRoot </> "target") then
            let fileDirUri = fileDir |> SpiralFileSystem.normalize_path |> SpiralFileSystem.new_file_uri
            let fileDeleteObj = {| FileDelete = {| uris = [| fileDirUri |] |} |}
            let! _fileDeleteResult = fileDeleteObj |> sendObj serverPort
            ()

        let fsxPath = fileDir </> $"{fileName}.fsx"
        return fsxPath, result
    }

    /// ## persistCode
    let inline persistCode code = async {
        let targetDir = workspaceRoot </> "target/polyglot/spiral_eval"

        let packagesDir = targetDir </> "packages"

        let hashHex = code |> SpiralCrypto.hash_text

        let codeDir = packagesDir </> hashHex

        let mainPath = codeDir </> "main.spi"

        codeDir |> System.IO.Directory.CreateDirectory |> ignore

        do! code |> SpiralFileSystem.write_all_text_exists mainPath

        let spiprojPath = codeDir </> "package.spiproj"
        let spiprojCode =
            $"""packageDir: {workspaceRoot </> "lib"}
packages:
    |core-
    spiral-
modules:
    main
"""
        do! spiprojCode |> SpiralFileSystem.write_all_text_exists spiprojPath

        let fsxPath = codeDir </> "main.fsx"

        if fsxPath |> System.IO.File.Exists |> not
        then return mainPath, None
        else
            let! oldCode = mainPath |> SpiralFileSystem.read_all_text_async
            if oldCode <> code
            then return mainPath, None
            else
                let! fsxCode = fsxPath |> SpiralFileSystem.read_all_text_async
                return mainPath, Some (fsxPath, fsxCode |> SpiralSm.replace "\r\n" "\n")
    }

    /// ## buildCode
    let inline buildCode timeout cancellationToken code = async {
        let! mainPath, fsx = code |> persistCode
        match fsx with
        | Some (fsxPath, fsxCode) -> return mainPath, (fsxPath, Some fsxCode), []
        | None ->
            let port = getCompilerPort ()
            let! fsxPath, (fsxCode, errors) = mainPath |> buildFile timeout port cancellationToken
            return mainPath, (fsxPath, fsxCode), errors
    }

    /// ## getFileTokenRange
    let inline getFileTokenRange port cancellationToken path = async {
        let fullPath = path |> System.IO.Path.GetFullPath
        let! code = fullPath |> SpiralFileSystem.read_all_text_async
        let lines = code |> SpiralSm.split "\n"

        let struct (token, disposable) = SpiralThreading.new_disposable_token cancellationToken
        use _ = disposable

        let! serverPort, _errors, ct, disposable =
            match port with
            | Some port -> awaitCompiler port (Some token)
            | None -> (getCompilerPort (), FSharp.Control.AsyncSeq.empty, token, new_disposable id) |> Async.init
        use _ = disposable

        let fullPathUri = fullPath |> SpiralFileSystem.normalize_path |> SpiralFileSystem.new_file_uri

        let fileOpenObj = {| FileOpen = {| uri = fullPathUri; spiText = code |} |}
        let! _fileOpenResult = fileOpenObj |> sendObj serverPort

        // do! Async.Sleep 60

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
        let! mainPath, _ = persistCode code

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
        | Some tokens -> return tokens |> Some
        | None ->
            let port = getCompilerPort ()
            return! mainPath |> getFileTokenRange (Some port) cancellationToken
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
            let port = port |> Option.defaultWith getCompilerPort
            let struct (localToken, disposable) = SpiralThreading.new_disposable_token None
            let! serverPort, _errors, compilerToken, disposable = awaitCompiler port (Some localToken)
            use _ = disposable

            let buildFileAsync =
                buildFileActions
                |> List.map (fun (inputPath, outputPath) -> async {
                    let! _fsxPath, (outputCode, errors) = inputPath |> buildFile timeout serverPort None

                    errors
                    |> List.map snd
                    |> List.iter (fun error ->
                        trace Critical (fun () -> $"main / error: {error |> serializeObj}") _locals
                    )

                    match outputCode with
                    | Some outputCode ->
                        do! outputCode |> SpiralFileSystem.write_all_text_async outputPath
                        return 0
                    | None ->
                        if isExitOnError
                        then System.Environment.Exit 1

                        return 1
                })

            let fileTokenRangeAsync =
                fileTokenRangeActions
                |> List.map (fun (inputPath, outputPath) -> async {
                    let! tokenRange = inputPath |> getFileTokenRange (Some serverPort) None
                    match tokenRange with
                    | Some tokenRange ->
                        do! tokenRange |> FSharp.Json.Json.serialize |> SpiralFileSystem.write_all_text_async outputPath
                        return 0
                    | None ->
                        if isExitOnError
                        then System.Environment.Exit 1

                        return 1
                })

            let executeCommandAsync =
                executeCommandActions
                |> List.map (fun command -> async {
                    let! exitCode, result =
                        SpiralRuntime.execution_options (fun x ->
                            { x with
                                l0 = Some compilerToken
                                l1 = command
                            }
                        )
                        |> SpiralRuntime.execute_with_options_async

                    trace Debug (fun () -> $"main / executeCommand / exitCode: {exitCode} / command: {command}") _locals

                    if isExitOnError && exitCode > 0
                    then System.Environment.Exit exitCode

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
