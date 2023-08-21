#if !INTERACTIVE
namespace Polyglot
#endif

module Supervisor =

    open Common
    open FileSystem

    /// ## sendJson

    let inline sendJson (port : int) (json : string) = async {
        let! portOpen = Networking.testPortOpen port
        if portOpen then
            // use runtime = new NetMQ.NetMQRuntime ()
            use request = new NetMQ.Sockets.RequestSocket ()
            request.Connect $"tcp://127.0.0.1:{port}"

            let msg = NetMQ.NetMQMessage ()
            msg.Append json

            NetMQ.OutgoingSocketExtensions.SendMultipartMessage (request, msg)
            let result = NetMQ.ReceivingSocketExtensions.ReceiveMultipartMessage (request, 10)
            // let! result = NetMQ.AsyncReceiveExtensions.ReceiveMultipartMessageAsync (request, 10) |> Async.AwaitTask
            let resultString = result |> Seq.map (fun x -> x.ConvertToString ()) |> String.concat ""
            trace Debug (fun () -> $"sendJson / port: {port} / json: {json} / result.FrameCount: {result.FrameCount} / resultString.Length: {resultString.Length}") getLocals
            return Some resultString
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
                let pingObj = {| Ping = true |}
                let! pingResult = pingObj |> sendObj port
                inbox.Post ()
            else
                let repositoryRoot = FileSystem.getSourceDirectory () |> FileSystem.findParent ".paket" false

                let compilerPath =
                    repositoryRoot </> "deps/The-Spiral-Language/The Spiral Language 2/artifacts/bin/The Spiral Language 2/release"
                    |> System.IO.Path.GetFullPath

                let dllPath = compilerPath </> "Spiral.dll"
                // let commandsPath = compilerPath </> "compiler/supervisor/commands"

                let! exitCode, result =
                    Runtime.executeWithOptionsAsync
                        {
                            Command = $@"dotnet ""{dllPath}"" port={availablePort}"
                            CancellationToken = Some ct
                            WorkingDirectory = None
                            OnLine = Some <| fun { Line = line } -> async {
                                if line |> String.contains $"Server bound to: tcp://*:{availablePort}"
                                then inbox.Post ()
                            }
                        }
                trace Debug (fun () -> $"startSupervisor / exitCode: {exitCode} / result: {result}") getLocals
        }, ct)

        do! compiler.Receive ()

        let request = new NetMQ.Sockets.SubscriberSocket ()
        request.SubscribeToAnyTopic ()
        request.Connect $"tcp://127.0.0.1:{port + 1}"

        let rec loop i = async {
            let result = NetMQ.ReceivingSocketExtensions.ReceiveMultipartMessage (request, 10)
            // let! result = NetMQ.AsyncReceiveExtensions.ReceiveMultipartMessageAsync (request, 10) |> Async.AwaitTask
            return
                result
                |> Seq.map (fun x -> x.ConvertToString ())
                |> String.concat ""
                |> FSharp.Json.Json.deserialize<ClientErrorsRes>
        }

        return loop |> FSharp.Control.AsyncSeq.initInfiniteAsync, (request :> System.IDisposable)
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

        let! errors, disposable = awaitCompiler port cancellationToken
        use _ = disposable

        let fsxContentSeq =
            stream
            |> FSharp.Control.AsyncSeq.choose (function
                | _, FileSystemChange.Changed (path, Some content) when path = $"{fileName}.fsx" -> Some content
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
            [fsxContentSeq; errorsSeq]
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
            |> Async.runWithTimeoutAsync timeout
            |> Async.StartChild

        let fileOpenObj = {| FileOpen = {| uri = fullPath |> getFileUri; spiText = code |} |}
        let! fileOpenResult = fileOpenObj |> sendObj port

        let buildFileObj = {| BuildFile = {| uri = fullPath |> getFileUri; backend = "Fsharp" |} |}
        let! buildFileResult = buildFileObj |> sendObj port

        return!
            outputChild
            |> Async.map (Option.flatten >> Option.defaultValue (None, []))
    }

    /// ## persistCode

    let inline persistCode timeout cancellationToken code = async {
        let tempDir = FileSystem.createTempDirectory ()

        let mainPath = tempDir </> "main.spi"
        do! code |> FileSystem.writeAllTextAsync mainPath

        let repositoryRoot = FileSystem.getSourceDirectory () |> FileSystem.findParent ".paket" false

        let spiprojPath = tempDir </> "package.spiproj"
        let spiprojCode =
            $"""packageDir: {repositoryRoot </> "spiral"}
packages:
    |core-
    fsharp
modules:
    main
"""
        do! spiprojCode |> FileSystem.writeAllTextAsync spiprojPath

        let disposable = newDisposable (fun () ->
            tempDir |> FileSystem.deleteDirectoryAsync |> Async.Ignore |> Async.RunSynchronously
        )

        return mainPath, disposable
    }

    /// ## buildCode

    let inline buildCode timeout cancellationToken code = async {
        let! mainPath, disposable = persistCode timeout cancellationToken code
        use _ = disposable
        return! mainPath |> buildFile timeout cancellationToken
    }

    /// ## getFileTokenRange

    let inline getFileTokenRange timeout cancellationToken path = async {
        let fullPath = path |> System.IO.Path.GetFullPath
        let! code = fullPath |> FileSystem.readAllTextAsync
        let lines = code |> String.split [| '\n' |]

        let port =
            if fullPath |> String.startsWith (System.IO.Path.GetTempPath ())
                && fullPath |> String.contains "Microsoft.DotNet.Interactive.App" |> not
            then 13807
            else 13805

        let! outputs = awaitCompiler port cancellationToken

        let fileOpenObj = {| FileOpen = {| uri = fullPath |> getFileUri; spiText = code |} |}
        let! fileOpenResult = fileOpenObj |> sendObj port

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
        let! fileTokenRangeResult = fileTokenRangeObj |> sendObj port

        return fileTokenRangeResult |> Option.map FSharp.Json.Json.deserialize<int array>
    }

    /// ## getCodeTokenRange

    let inline getCodeTokenRange timeout cancellationToken code = async {
        let! mainPath, disposable = persistCode timeout cancellationToken code
        use _ = disposable
        return! mainPath |> getFileTokenRange timeout cancellationToken
    }

    /// ## Arguments

    [<RequireQualifiedAccess>]
    type Arguments =
        | [<Argu.ArguAttributes.Mandatory>] BuildFile of string * string
        | Timeout of int

        interface Argu.IArgParserTemplate with
            member s.Usage =
                match s with
                | BuildFile _ -> nameof Arguments.BuildFile
                | Timeout _ -> nameof Arguments.Timeout

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
                trace Error (fun () -> $"main / error: {error}") getLocals
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
