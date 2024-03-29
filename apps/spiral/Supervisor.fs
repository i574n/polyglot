#if !INTERACTIVE
namespace Polyglot
#endif

module Supervisor =

    open Common
    open FileSystem.Operators
    open Microsoft.AspNetCore.SignalR.Client

    /// ## sendJson

    let inline sendJson (port : int) (json : string) = async {
        let! portOpen = Networking.testPortOpen port
        if portOpen then
            try
                let connection = HubConnectionBuilder().WithUrl($"http://127.0.0.1:{port}").Build()
                do! connection.StartAsync () |> Async.AwaitTask
                let! result = connection.InvokeAsync<string>("ClientToServerMsg", json) |> Async.AwaitTask
                do! connection.StopAsync () |> Async.AwaitTask
                trace Debug (fun () -> $"sendJson / port: {port} / json: {json} / result.Length: {result |> Option.ofObj |> Option.map String.length}") getLocals
                return Some result
            with ex ->
                trace Critical (fun () -> $"sendJson / port: {port} / json: {json} / ex: {ex |> formatException}") getLocals
                return None
        else
            trace Debug (fun () -> "sendJson / error: port not open") getLocals
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

    let inline awaitCompiler port cancellationToken = async {
        let! ct =
            cancellationToken
            |> Option.defaultValue System.Threading.CancellationToken.None
            |> Async.mergeCancellationTokenWithDefaultAsync

        let cts = new System.Threading.CancellationTokenSource ()

        let compiler = MailboxProcessor.Start (fun inbox -> async {
            let! availablePort = Networking.getAvailablePort (Some 60) port
            if availablePort <> port then
                inbox.Post port
            else
                let repositoryRoot = FileSystem.getSourceDirectory () |> FileSystem.findParent ".paket" false

                let compilerPath =
                    repositoryRoot </> "deps/The-Spiral-Language/The Spiral Language 2/artifacts/bin/The Spiral Language 2/release"
                    |> System.IO.Path.GetFullPath

                let dllPath = compilerPath </> "Spiral.dll"

                let! exitCode, result =
                    Runtime.executeWithOptionsAsync
                        {
                            Command = $@"dotnet ""{dllPath}"" --port {availablePort} --default-int i32 --default-float f64"
                            CancellationToken = Some ct
                            WorkingDirectory = None
                            OnLine = Some <| fun { Line = line } -> async {
                                if line |> String.contains $"Server bound to: http://localhost:{availablePort}" then
                                    do! Networking.waitForPortAccess (Some 500) true availablePort |> Async.Ignore

                                    let rec loop retry = async {
                                        let getLocals () = $"port: {availablePort} / retry: {retry} / {getLocals ()}"
                                        try
                                            let pingObj = {| Ping = true |}
                                            let! pingResult = pingObj |> sendObj availablePort
                                            trace Verbose (fun () -> $"awaitCompiler / Ping / result: {pingResult}") getLocals
                                        with ex ->
                                            trace Verbose (fun () -> $"awaitCompiler / Ping / ex: {ex |> formatException}") getLocals
                                            do! Async.Sleep 10
                                            do! loop (retry + 1)
                                    }
                                    do! loop 0
                                    inbox.Post availablePort
                            }
                        }
                trace Debug (fun () -> $"awaitCompiler / exitCode: {exitCode} / result: {result}") getLocals
                cts.Cancel ()
        }, ct)

        let! serverPort = compiler.Receive ()

        let connection = HubConnectionBuilder().WithUrl($"http://127.0.0.1:{serverPort}").Build ()
        do! connection.StartAsync () |> Async.AwaitTask

        let event = Event<_> ()
        let disposable = connection.On<string> ("ServerToClientMsg", event.Trigger)
        let stream =
            FSharp.Control.AsyncSeq.unfoldAsync
                (fun () -> async {
                    let! msg = event.Publish |> Async.AwaitEvent
                    return Some (msg |> FSharp.Json.Json.deserialize<ClientErrorsRes>, ())
                })
                ()

        let disposable =
            new_disposable (fun () ->
                disposable.Dispose ()
                connection.StopAsync () |> Async.AwaitTask |> Async.StartImmediate
            )

        return
            serverPort,
            stream,
            cts.Token,
            disposable
    }

    /// ## getFileUri

    let inline getFileUri (path : string) =
        let path =
            if Runtime.isWindows () |> not
            then path
            else $"{path.[0] |> System.Char.ToLower}{path.[1..]}" |> String.replace "\\" "/"
        $"file:///{path |> String.trimStart [| '/' |]}"

    let inline getFilePathFromUri uri =
        match System.Uri.TryCreate (uri, System.UriKind.Absolute) with
        | true, uri -> uri.AbsolutePath |> System.IO.Path.GetFullPath
        | _ -> failwith "invalid uri"

    let inline getCompilerPort () =
        13805

    /// ## serialize_obj

    let serializeObj obj =
            obj
            |> FSharp.Json.Json.serialize
            |> String.replace "\\\\" "\\"
            |> String.replace "\\r\\n" "\n"
            |> String.replace "\\n" "\n"

    /// ## buildFile

    let inline buildFile timeout port cancellationToken path = async {
        let fullPath = path |> System.IO.Path.GetFullPath
        let fileDir = fullPath |> System.IO.Path.GetDirectoryName
        let fileName = fullPath |> System.IO.Path.GetFileNameWithoutExtension
        let! code = fullPath |> FileSystem.readAllTextAsync

        let eventFilter = function
            | FileSystem.FileSystemChange.Changed (path, _) when path = $"{fileName}.fsx" -> true
            | _ -> false

        let stream, disposable = fileDir |> FileSystem.watchDirectory eventFilter
        use _ = disposable

        let token, disposable = Threading.newDisposableToken cancellationToken
        use _ = disposable

        let! serverPort, errors, ct, disposable = awaitCompiler port (Some token)
        use _ = disposable

        let fsxContentSeq =
            stream
            |> FSharp.Control.AsyncSeq.choose (function
                | _, (FileSystem.FileSystemChange.Changed (path, Some content) as event)
                    when event |> eventFilter
                    ->
                    Some content
                | _ -> None
            )
            |> FSharp.Control.AsyncSeq.map (fun content ->
                Some (content |> String.replace "\r\n" "\n"), None
            )

        let inline printErrorData (data : {| uri : string; errors : RString list |}) =
            let fileName = data.uri |> System.IO.Path.GetFileName
            let errors =
                data.errors
                |> List.map snd
                |> String.concat "\n"
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
                trace Debug (fun () -> $"buildFile / takeWhileInclusive / fsxContent: {fsxContent |> Option.defaultValue System.String.Empty |> String.ellipsis 750} / errors: {errors |> serializeObj} / typeErrorCount: {typeErrorCount}") getLocals
                match fsxContent, errors with
                | None, [] when typeErrorCount > 2 -> false
                | None, [] -> true
                | _ -> false
            )
            |> FSharp.Control.AsyncSeq.tryLast
            |> Async.withCancellationToken ct
            |> Async.catch
            |> Async.runWithTimeoutAsync timeout
            |> Async.StartChild

        let fileOpenObj = {| FileOpen = {| uri = fullPath |> getFileUri; spiText = code |} |}
        let! _fileOpenResult = fileOpenObj |> sendObj serverPort

        do! Async.Sleep 60

        let buildFileObj = {| BuildFile = {| uri = fullPath |> getFileUri; backend = "Fsharp" |} |}
        let! _buildFileResult = buildFileObj |> sendObj serverPort

        return!
            outputChild
            |> Async.map (function
                | Some (Ok (Some (message, errors, _))) ->
                    message, errors |> List.distinct |> List.rev
                | Some (Error ex) ->
                    trace Critical (fun () -> $"buildFile / error: {ex |> serializeObj}") getLocals
                    None, []
                | _ -> None, []
            )
    }

    /// ## persistCode

    let inline persistCode code = async {
        let tempDir = FileSystem.createTempDirectory ()

        let mainPath = tempDir </> "main.spi"
        do! code |> FileSystem.writeAllTextAsync mainPath

        let repositoryRoot = FileSystem.getSourceDirectory () |> FileSystem.findParent ".paket" false

        let spiprojPath = tempDir </> "package.spiproj"
        let spiprojCode =
            $"""packageDir: {repositoryRoot </> "lib"}
packages:
    |core-
    spiral-
modules:
    main
"""
        do! spiprojCode |> FileSystem.writeAllTextAsync spiprojPath

        let disposable = new_disposable (fun () ->
            ()
            // tempDir |> FileSystem.deleteDirectoryAsync |> Async.Ignore |> Async.RunSynchronously
        )

        return mainPath, disposable
    }

    /// ## buildCode

    let inline buildCode timeout cancellationToken code = async {
        let! mainPath, disposable = persistCode code
        use _ = disposable
        let port = getCompilerPort ()
        return! mainPath |> buildFile timeout port cancellationToken
    }

    /// ## getFileTokenRange

    let inline getFileTokenRange port cancellationToken path = async {
        let fullPath = path |> System.IO.Path.GetFullPath
        let! code = fullPath |> FileSystem.readAllTextAsync
        let lines = code |> String.split [| '\n' |]

        let token, disposable = Threading.newDisposableToken cancellationToken
        use _ = disposable

        let! serverPort, _errors, ct, disposable = awaitCompiler port (Some token)
        use _ = disposable

        let fileOpenObj = {| FileOpen = {| uri = fullPath |> getFileUri; spiText = code |} |}
        let! _fileOpenResult = fileOpenObj |> sendObj serverPort

        let fileTokenRangeObj =
            {|
                FileTokenRange =
                    {|
                        uri = fullPath |> getFileUri
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

        return fileTokenRangeResult |> Option.map FSharp.Json.Json.deserialize<int array>
    }

    /// ## getCodeTokenRange

    let inline getCodeTokenRange cancellationToken code = async {
        let! mainPath, disposable = persistCode code
        use _ = disposable
        let port = getCompilerPort ()
        return! mainPath |> getFileTokenRange port cancellationToken
    }

    /// ## Arguments

    [<RequireQualifiedAccess>]
    type Arguments =
        | Build_File of string * string
        | File_Token_Range of string * string
        | Execute_Command of string
        | Timeout of int
        | Port of int

        interface Argu.IArgParserTemplate with
            member s.Usage =
                match s with
                | Build_File _ -> nameof Build_File
                | File_Token_Range _ -> nameof File_Token_Range
                | Execute_Command _ -> nameof Execute_Command
                | Timeout _ -> nameof Timeout
                | Port _ -> nameof Port

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

        async {
            let! buildFileResult =
                buildFileActions
                |> List.map (fun (inputPath, outputPath) -> async {
                    let port = port |> Option.defaultWith getCompilerPort
                    let! outputCode, errors = inputPath |> buildFile timeout port None

                    errors
                    |> List.map snd
                    |> List.iter (fun error ->
                        trace Critical (fun () -> $"main / error: {error |> serializeObj}") getLocals
                    )

                    match outputCode with
                    | Some outputCode ->
                        do! outputCode |> FileSystem.writeAllTextAsync outputPath
                        return 0
                    | None ->
                        return 1
                })
                |> Async.Sequential

            let! fileTokenRangeResult =
                fileTokenRangeActions
                |> List.map (fun (inputPath, outputPath) -> async {
                    let port = port |> Option.defaultWith getCompilerPort
                    let! tokenRange = inputPath |> getFileTokenRange port None
                    match tokenRange with
                    | Some tokenRange ->
                        do! tokenRange |> FSharp.Json.Json.serialize |> FileSystem.writeAllTextAsync outputPath
                        return 0
                    | None ->
                        return 1
                })
                |> Async.Sequential

            let! executeCommandResult =
                executeCommandActions
                |> List.map (fun command -> async {
                    let port = port |> Option.defaultWith getCompilerPort

                    let localToken, disposable = Threading.newDisposableToken None
                    use _ = disposable

                    let! serverPort, _errors, compilerToken, disposable = awaitCompiler port (Some localToken)
                    use _ = disposable

                    let! exitCode, result =
                        Runtime.executeWithOptionsAsync
                            {
                                Command = command
                                CancellationToken = Some compilerToken
                                WorkingDirectory = None
                                OnLine = None
                            }

                    trace Debug (fun () -> $"main / executeCommand / exitCode: {exitCode}") getLocals

                    return exitCode
                })
                |> Async.Sequential

            return
                [| buildFileResult; fileTokenRangeResult; executeCommandResult |]
                |> Array.collect id
                |> Array.sum
        }
        |> Async.runWithTimeout timeout
        |> Option.defaultValue 1
