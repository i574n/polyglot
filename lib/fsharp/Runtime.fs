#if !INTERACTIVE
namespace Polyglot
#endif

module Runtime =

#if !INTERACTIVE
    open Lib
#endif

    open Common

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
            | _, _ -> path |> SpiralSm.replace @"\" "/", args
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
            Arguments = arguments,
            CreateNoWindow = true,
            FileName = fileName,
            RedirectStandardError = true,
            RedirectStandardOutput = true,
            StandardOutputEncoding = System.Text.Encoding.UTF8,
            UseShellExecute = false,
            WorkingDirectory = workingDirectory
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
                    Verbose
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
            |> SpiralAsync.merge_cancellation_token_with_default_async

        use reg = ct.Register (fun _ ->
            if not proc.HasExited then proc.Kill ()
        )

        let! exitCode = async {
            try
                do! proc.WaitForExitAsync ct |> Async.AwaitTask
                return proc.ExitCode
            with :? System.Threading.Tasks.TaskCanceledException as ex ->
                trace Warning (fun () -> $"executeAsync / WaitForExitAsync / ex: {ex |> SpiralSm.format_exception}") getLocals
                ex |> SpiralSm.format_exception |> output.Push
                return System.Int32.MinValue
        }

        let output = output |> Seq.rev |> SpiralSm.concat "\n"

        trace Debug (fun () ->
            $"executeAsync / exitCode: {exitCode} / output.Length: {output.Length}"
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
            if [ "Microsoft.DotNet.Interactive.App"; "dotnet-repl" ] |> List.contains assemblyName
            then Argu.ExceptionExiter ()
            else Argu.ProcessExiter (function Argu.ErrorCode.HelpText -> None | _ -> Some System.ConsoleColor.Red)

        let parser =
            Argu.ArgumentParser.Create<'T> (
                programName = $"{assemblyName}{SpiralRuntime.get_executable_suffix ()}",
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
        |> List.groupBy CommonFSharp.getUnionCaseName<'T>
        |> Map.ofList
