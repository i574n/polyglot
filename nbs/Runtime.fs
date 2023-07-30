#if !INTERACTIVE
namespace Polyglot
#endif

module Runtime =

    open Common

    /// ## isWindows

    let inline isWindows () =
        System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform System.Runtime.InteropServices.OSPlatform.Windows

    /// ## splitCommand

    type private CommandParseStep =
        | Start
        | Path of quoted: bool
        | Arguments

    let splitCommand (command: string) =
        let rec loop (path, args) chars step =
            match chars, step with
            | ('"' | '\'') :: tail, _ when path = "" -> loop (path, args) tail (Path true)
            | ('"' | '\'') :: tail, Path true -> loop (path, args) tail (Path false)
            | ' ' :: tail, Path true -> loop ($"{path} ", args) tail (Path true)
            | ' ' :: tail, (Start | Path _) -> loop (path, args) tail Arguments
            | char :: tail, Arguments -> loop (path, $"{args}{char}") tail Arguments
            | char :: tail, _ -> loop ($"{path}{char}", args) tail step
            | _, _ -> path |> String.replace @"\" "/", args
        let path, args = loop ("", "") (command |> Seq.toList) Start
        let workingDirectory, fileName =
            if path |> String.startsWith "./" || path |> String.contains "/"
            then path |> System.IO.Path.GetDirectoryName |> String.replace @"\" "/", System.IO.Path.GetFileName path
            else ".", path
        workingDirectory, fileName, args

    /// ## executeAsync

    type ExecutionLine =
        {
            ProcessId : int
            Line : string
            Error : bool
        }

    type ExecutionOptions =
        {
            Command : string
            CancellationToken : System.Threading.CancellationToken option
            OnLine : (ExecutionLine -> Async<unit>) option
        }

    let inline executeWithOptionsAsync (options : ExecutionOptions) = async {
        let workingDirectory, fileName, arguments = options.Command |> splitCommand
        let getLocals () = $"workingDirectory: {workingDirectory} / fileName: {fileName} / arguments: {arguments} / {getLocals ()}"

        let startInfo = System.Diagnostics.ProcessStartInfo (
            WorkingDirectory = workingDirectory,
            FileName = fileName,
            Arguments = arguments,
            RedirectStandardOutput = true,
            RedirectStandardError = true,
            UseShellExecute = false,
            CreateNoWindow = true
        )

        use proc = new System.Diagnostics.Process (StartInfo = startInfo)
        let output = System.Collections.Concurrent.ConcurrentStack<string> ()

        let inline event error (e: System.Diagnostics.DataReceivedEventArgs) = async {
            if e.Data <> null then
                match options.OnLine with
                | Some onLine ->
                    do!
                        onLine
                            {
                                ProcessId = proc.Id
                                Line = e.Data
                                Error = error
                            }
                | None -> ()

                trace
                    (if error then Error else Debug)
                    (fun () -> $"{if error then 'E' else ' '}{proc.Id}: {e.Data}")
                    Common.getLocals

                output.Push
                    $"{
                        if error then '['.ToString() else System.String.Empty
                    }{
                        e.Data
                    }{
                        if error then ']'.ToString() else System.String.Empty
                    }"
        }

        proc.OutputDataReceived.Add (event false >> Async.StartImmediate)
        proc.ErrorDataReceived.Add (event true >> Async.StartImmediate)

        trace Debug (fun () -> $"executeAsync") getLocals

        if proc.Start () |> not
        then failwith $"executeAsync / proc.Start() error"

        proc.BeginErrorReadLine ()
        proc.BeginOutputReadLine ()

        let! ct =
            options.CancellationToken
            |> Option.map Async.init
            |> Option.defaultValue Async.CancellationToken

        use reg = ct.Register (fun _ ->
            if not proc.HasExited then proc.Kill ()
        )

        let! exitCode = async {
            try
                do! proc.WaitForExitAsync ct |> Async.AwaitTask
                return proc.ExitCode
            with :? System.Threading.Tasks.TaskCanceledException as ex ->
                trace Warn (fun () -> $"executeAsync / WaitForExitAsync / ex: {ex |> printException}") getLocals
                ex |> printException |> output.Push
                return System.Int32.MinValue
        }

        let output = output |> Seq.rev |> String.concat System.Environment.NewLine

        trace Debug (fun () -> $"executeAsync / exitCode: {exitCode} / output.Length: {output.Length}") getLocals

        return exitCode, output
    }

    let inline executeAsync command =
        executeWithOptionsAsync
            {
                Command = command
                CancellationToken = None
                OnLine = None
            }
