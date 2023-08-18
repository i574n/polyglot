#if !INTERACTIVE
namespace Polyglot
#endif

module Runtime =

    open Common

    /// ## isWindows

    let isWindows =
        fun () ->
            System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform
                System.Runtime.InteropServices.OSPlatform.Windows
        |> memoize

    /// ## getExecutableSuffix

    let inline getExecutableSuffix () =
        if isWindows ()
        then ".exe"
        else ""

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
        loop ("", "") (command |> Seq.toList) Start

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
            WorkingDirectory : string option
            CancellationToken : System.Threading.CancellationToken option
            OnLine : (ExecutionLine -> Async<unit>) option
        }

    let inline executeWithOptionsAsync (options : ExecutionOptions) = async {
        let fileName, arguments = options.Command |> splitCommand
        let workingDirectory = options.WorkingDirectory |> Option.defaultValue ""

        trace Debug (fun () -> $"executeAsync / options: {options}") getLocals

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
                    (fun () -> $"> {e.Data}")
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

        if proc.Start () |> not
        then failwith $"executeAsync / proc.Start () error"

        proc.BeginErrorReadLine ()
        proc.BeginOutputReadLine ()

        let! ct =
            options.CancellationToken
            |> Option.defaultValue System.Threading.CancellationToken.None
            |> Async.mergeCancellationTokenWithDefaultAsync

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

        trace Debug (fun () ->
            $"executeAsync / exitCode: {exitCode} / proc.Id: {proc.Id} / output.Length: {output.Length}"
        ) getLocals

        return exitCode, output
    }

    let inline executeAsync command =
        executeWithOptionsAsync
            {
                Command = command
                CancellationToken = None
                OnLine = None
                WorkingDirectory = None
            }

    /// ## splitArgs

    let inline splitArgs commandLine =
        commandLine
        |> System.CommandLine.Parsing.CommandLineStringSplitter.Instance.Split

    /// ## parseArgs

    let inline parseArgs<'T when 'T :> Argu.IArgParserTemplate> args =
        let assemblyName = System.Reflection.Assembly.GetEntryAssembly().GetName().Name
        let errorHandler : Argu.IExiter =
            if ["Microsoft.DotNet.Interactive.App"; "dotnet-repl"] |> List.contains assemblyName
            then Argu.ExceptionExiter ()
            else Argu.ProcessExiter (function Argu.ErrorCode.HelpText -> None | _ -> Some System.ConsoleColor.Red)

        let parser =
            Argu.ArgumentParser.Create<'T> (
                programName = $"{assemblyName}{getExecutableSuffix ()}",
                errorHandler = errorHandler
            )

        parser.ParseCommandLine args

    let inline parseAllArgs<'T when 'T :> Argu.IArgParserTemplate> args =
        args
        |> parseArgs<'T>
        |> fun results -> results.GetAllResults ()

    let inline parseArgsMap<'T when 'T :> Argu.IArgParserTemplate> args =
        args
        |> parseAllArgs<'T>
        |> List.groupBy CommonFSharp.getUnionCaseName
        |> Map.ofList
