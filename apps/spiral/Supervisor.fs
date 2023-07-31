#if !INTERACTIVE
namespace Polyglot
#endif

module Supervisor =

    open Common
    open FileSystem

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

    let inline sendObj port obj =
        let json = System.Text.Json.JsonSerializer.Serialize obj
        sendJson port json

    let inline compile code = async {
        let tempDir = FileSystem.createTempDirectory ()

        let stream, disposable = FileSystem.watchDirectory true tempDir

        let mainPath = tempDir </> "main.spi"
        let spiprojPath = tempDir </> "package.spiproj"

        let inline writeCode path code =
            System.IO.File.WriteAllTextAsync (path, code) |> Async.AwaitTask

        do! code |> writeCode mainPath
        do! "packages:
    |core-
modules:
    main" |> writeCode spiprojPath

        let port = 13805

        let! ct = Async.CancellationToken
        let compiler = MailboxProcessor.Start (fun inbox -> async {
            let! availablePort = Networking.getAvailablePort (Some 60) port
            if availablePort <> port
            then inbox.Post ()
            else
                let compilerPath =
                    "../../deps/The-Spiral-Language/The Spiral Language 2/artifacts/bin/The Spiral Language 2/release"
                    |> Path.GetFullPath

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

        let inline getFileUri path =
            $"file:///{path |> String.trimStart [| '/' |]}"


        let fileOpenObj = {| FileOpen = {| uri = mainPath |> getFileUri; spiText = code |} |}
        let! fileOpenResult = fileOpenObj |> sendObj port

        let buildFileObj = {| BuildFile = {| uri = mainPath |> getFileUri; backend = "Fsharp" |} |}
        let! buildFileResult = buildFileObj |> sendObj port

        let! fsxContent =
            stream
            |> FSharp.Control.AsyncSeq.choose (function
                | _, FileSystemChange.Changed ("main.fsx", Some content) -> Some content
                | _ -> None
            )
            |> FSharp.Control.AsyncSeq.tryFirst

        disposable.Dispose ()

        return fsxContent |> Option.defaultValue "" |> String.replace "\r\n" "\n"
    }
