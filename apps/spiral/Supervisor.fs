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
                trace Critical (fun () -> $"sendJson / port: {port} / json: {json} / ex: {ex |> printException}") getLocals
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

        let compiler = MailboxProcessor.Start (fun inbox -> async {
            let! availablePort = Networking.getAvailablePort (Some 60) port
            if port = 13805 && availablePort <> port then
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
                            Command = $@"dotnet ""{dllPath}"" port={availablePort}"
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
                                            trace Verbose (fun () -> $"awaitCompiler / Ping / ex: {ex |> printException}") getLocals
                                            do! Async.Sleep 10
                                            do! loop (retry + 1)
                                    }
                                    do! loop 0
                                    inbox.Post availablePort
                            }
                        }
                trace Debug (fun () -> $"awaitCompiler / exitCode: {exitCode} / result: {result}") getLocals
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
            newDisposable (fun () ->
                disposable.Dispose ()
                connection.StopAsync () |> Async.AwaitTask |> Async.StartImmediate
            )

        return
            serverPort,
            stream,
            disposable
    }

    /// ## getFileUri

    let inline getFileUri path =
        $"file:///{path |> String.trimStart [| '/' |]}"

    let inline getFilePathFromUri uri =
        match System.Uri.TryCreate (uri, System.UriKind.Absolute) with
        | true, uri -> uri.AbsolutePath |> System.IO.Path.GetFullPath
        | _ -> failwith "invalid uri"

    /// ## buildFile

    let inline buildFile timeout cancellationToken path = async {
        let fullPath = path |> System.IO.Path.GetFullPath
        let fileDir = fullPath |> System.IO.Path.GetDirectoryName
        let fileName = fullPath |> System.IO.Path.GetFileNameWithoutExtension
        let! code = fullPath |> FileSystem.readAllTextAsync

        let stream, disposable = FileSystem.watchDirectory true fileDir
        use _ = disposable

        let port =
            if fullPath |> String.startsWith (System.IO.Path.GetTempPath ())
                && fullPath |> String.contains "Microsoft.DotNet.Interactive.App" |> not
            then 13807
            else 13805

        let token, disposable = Threading.newDisposableToken cancellationToken
        use _ = disposable

        let! serverPort, errors, disposable = awaitCompiler port (Some token)
        use _ = disposable

        let fsxContentSeq =
            stream
            |> FSharp.Control.AsyncSeq.choose (function
                | _, FileSystem.FileSystemChange.Changed (path, Some content) when path = $"{fileName}.fsx" ->
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
                    Some (message, true, error)
                | TracedError data ->
                    Some (data.message, true, error)
                | PackageErrors data when data.errors |> List.isEmpty |> not ->
                    Some (data |> printErrorData, true, error)
                | TokenizerErrors data when data.errors |> List.isEmpty |> not ->
                    Some (data |> printErrorData, true, error)
                | ParserErrors data when data.errors |> List.isEmpty |> not ->
                    Some (data |> printErrorData, false, error)
                | TypeErrors data when data.errors |> List.isEmpty |> not ->
                    Some (data |> printErrorData, true, error)
                | _ -> None
            )
            |> FSharp.Control.AsyncSeq.map (fun (message, fatal, error) ->
                None, Some (message, fatal, error)
            )

        let outputSeq =
            [ fsxContentSeq; errorsSeq ]
            |> FSharp.Control.AsyncSeq.mergeAll

        let! outputChild =
            ((None, [], None), outputSeq)
            ||> FSharp.Control.AsyncSeq.scan (
                fun (fsxContentResult, errors, firstErrorTicks) (fsxContent, error) ->
                    match fsxContent, error with
                    | Some fsxContent, None -> Some fsxContent, errors, firstErrorTicks
                    | None, Some (message, fatal, error) ->
                        fsxContentResult,
                        (message, error) :: errors,
                        firstErrorTicks
                        |> Option.defaultWith (fun () ->
                            if fatal
                            then System.DateTime.MinValue.Ticks
                            else System.DateTime.Now.Ticks
                        )
                        |> Some
                    | _ -> fsxContentResult, errors, firstErrorTicks
            )
            |> FSharp.Control.AsyncSeq.takeWhileInclusive (fun (fsxContent, errors, firstErrorTicks) ->
                let firstErrorMs =
                    firstErrorTicks
                    |> Option.map (fun t -> System.TimeSpan(System.DateTime.Now.Ticks - t).TotalMilliseconds)
                trace Debug (fun () -> $"buildFile / fsxContent: {fsxContent} / errors: {errors} / firstErrorMs: {firstErrorMs}") getLocals
                match fsxContent, errors, firstErrorMs with
                | None, [], _ -> true
                | None, _, Some firstErrorMs when firstErrorMs < 2000. -> true
                | _ -> false
            )
            |> FSharp.Control.AsyncSeq.map (fun (fsxContent, errors, _) ->
                fsxContent, errors |> List.distinct
            )
            |> FSharp.Control.AsyncSeq.tryLast
            |> Async.catch
            |> Async.runWithTimeoutAsync timeout
            |> Async.StartChild

        let fileOpenObj = {| FileOpen = {| uri = fullPath |> getFileUri; spiText = code |} |}
        let! _fileOpenResult = fileOpenObj |> sendObj serverPort

        let buildFileObj = {| BuildFile = {| uri = fullPath |> getFileUri; backend = "Fsharp" |} |}
        let! _buildFileResult = buildFileObj |> sendObj serverPort

        return!
            outputChild
            |> Async.map (function
                | Some (Ok (Some result)) -> result
                | Some (Error ex) ->
                    trace Critical (fun () -> $"buildFile / error: {ex |> printException}") getLocals
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

        let disposable = newDisposable (fun () ->
            ()
            // tempDir |> FileSystem.deleteDirectoryAsync |> Async.Ignore |> Async.RunSynchronously
        )

        return mainPath, disposable
    }

    /// ## buildCode

    let inline buildCode timeout cancellationToken code = async {
        let! mainPath, disposable = persistCode code
        use _ = disposable
        return! mainPath |> buildFile timeout cancellationToken
    }

    /// ## getFileTokenRange

    let inline getFileTokenRange cancellationToken path = async {
        let fullPath = path |> System.IO.Path.GetFullPath
        let! code = fullPath |> FileSystem.readAllTextAsync
        let lines = code |> String.split [| '\n' |]

        let port =
            if fullPath |> String.startsWith (System.IO.Path.GetTempPath ())
                && fullPath |> String.contains "Microsoft.DotNet.Interactive.App" |> not
            then 13807
            else 13805

        let token, disposable = Threading.newDisposableToken cancellationToken
        use _ = disposable

        let! serverPort, _errors, disposable = awaitCompiler port (Some token)
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
        let! fileTokenRangeResult = fileTokenRangeObj |> sendObj serverPort

        return fileTokenRangeResult |> Option.map FSharp.Json.Json.deserialize<int array>
    }

    /// ## getCodeTokenRange

    let inline getCodeTokenRange cancellationToken code = async {
        let! mainPath, disposable = persistCode code
        use _ = disposable
        return! mainPath |> getFileTokenRange cancellationToken
    }

    /// ## Arguments

    [<RequireQualifiedAccess>]
    type Arguments =
        | [<Argu.ArguAttributes.Mandatory>] BuildFile of string * string
        | Timeout of int

        interface Argu.IArgParserTemplate with
            member s.Usage =
                match s with
                | BuildFile _ -> nameof BuildFile
                | Timeout _ -> nameof Timeout

    /// ## main

    let main args =
        let argsMap = args |> Runtime.parseArgsMap<Arguments>

        let inputPath, outputPath =
            match argsMap.[nameof Arguments.BuildFile] with
            | [ Arguments.BuildFile (inputPath, outputPath) ] -> Some (inputPath, outputPath)
            | _ -> None
            |> Option.get

        let timeout =
            match argsMap |> Map.tryFind (nameof Arguments.Timeout) with
            | Some [ Arguments.Timeout timeout ] -> timeout
            | _ -> 30000

        async {
            let! outputCode, errors = inputPath |> buildFile timeout None

            errors
            |> List.map snd
            |> List.iter (fun error ->
                trace Critical (fun () -> $"main / error: {error}") getLocals
            )

            match outputCode with
            | Some outputCode ->
                do! outputCode |> FileSystem.writeAllTextAsync outputPath
                return 0
            | None ->
                return 1
        }
        |> Async.runWithTimeout timeout
        |> Option.defaultValue 1
