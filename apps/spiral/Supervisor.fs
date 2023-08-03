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
            let result = result |> Seq.toList |> List.map (fun x -> x.ConvertToString ())
            trace Debug (fun () -> $"sendJson / port: {port} / json: {json} / result: {result}") getLocals
            return true
        else
            trace Debug (fun () -> "sendJson / error: port not open") getLocals
            return false
    }

    /// ## sendObj

    let inline sendObj port obj =
        let json = System.Text.Json.JsonSerializer.Serialize obj
        sendJson port json

    /// ## compile

    let inline compileFile timeout path = async {
        let fullPath = path |> System.IO.Path.GetFullPath
        let fileDir = fullPath |> System.IO.Path.GetDirectoryName
        let fileName = fullPath |> System.IO.Path.GetFileNameWithoutExtension
        let! code = fullPath |> FileSystem.readAllTextAsync

        let stream, disposable = FileSystem.watchDirectory true fileDir

        let port =
            if fileDir |> String.startsWith (System.IO.Path.GetTempPath ())
            then 13807
            else 13805

        let! ct = Async.CancellationToken
        let compiler = MailboxProcessor.Start (fun inbox -> async {
            let! availablePort = Networking.getAvailablePort (Some 60) port
            if availablePort <> port then
                let pingObj = {| Ping = true |}
                let! pingResult = pingObj |> sendObj port
                inbox.Post ()
            else
                let compilerPath =
                    "../../deps/The-Spiral-Language/The Spiral Language 2/artifacts/bin/The Spiral Language 2/release"
                    |> System.IO.Path.GetFullPath

                let dllPath = compilerPath </> "Spiral.dll"
                // let commandsPath = compilerPath </> "compiler/supervisor/commands"

                let! exitCode, result =
                    Runtime.executeWithOptionsAsync
                        {
                            Command = $@"dotnet ""{dllPath}"" port={port}"
                            CancellationToken = None
                            WorkingDirectory = None
                            OnLine = Some <| fun { Line = line } -> async {
                                if line |> String.contains $"Server bound to: tcp://*:{port}"
                                then inbox.Post ()
                            }
                        }
                trace Debug (fun () -> $"startSupervisor / exitCode: {exitCode} / result: {result}") getLocals
        }, ct)

        do! compiler.Receive ()

        let! fsxContentChild =
            stream
            |> FSharp.Control.AsyncSeq.choose (function
                | _, FileSystemChange.Changed (path, Some content) when path = $"{fileName}.fsx" -> Some content
                | _ -> None
            )
            |> FSharp.Control.AsyncSeq.tryFirst
            |> Async.runWithTimeoutAsync timeout
            |> Async.StartChild

        let inline getFileUri path =
            $"file:///{path |> String.trimStart [| '/' |]}"


        let fileOpenObj = {| FileOpen = {| uri = fullPath |> getFileUri; spiText = code |} |}
        let! fileOpenResult = fileOpenObj |> sendObj port

        let buildFileObj = {| BuildFile = {| uri = fullPath |> getFileUri; backend = "Fsharp" |} |}
        let! buildFileResult = buildFileObj |> sendObj port

        let! fsxContent = fsxContentChild

        disposable.Dispose ()

        return fsxContent |> Option.flatten |> Option.map (String.replace "\r\n" "\n")
    }

    let inline compileCode timeout code = async {
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

        let! result = mainPath |> compileFile timeout

        do! tempDir |> FileSystem.deleteDirectoryAsync |> Async.Ignore

        return result
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

    [<EntryPoint>]
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
            let! outputCode = inputPath |> compileFile timeout
            match outputCode with
            | Some outputCode ->
                do! outputCode |> FileSystem.writeAllTextAsync outputPath
                return 0
            | None ->
                return 1
        }
        |> Async.runWithTimeout timeout
        |> Option.defaultValue 1
