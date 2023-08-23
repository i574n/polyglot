#if !INTERACTIVE
namespace Polyglot
#endif

module Async =

    open Common

    /// ## choice

    let inline choice asyncs = async {
        let e = Event<_> ()
        use cts = new System.Threading.CancellationTokenSource ()
        let fn =
            asyncs
            |> Seq.map (fun a -> async {
                let! x = a
                e.Trigger x
            })
            |> Async.Parallel
            |> Async.Ignore
        Async.Start (fn, cts.Token)
        let! result = Async.AwaitEvent e.Publish
        cts.Cancel ()
        return result
    }

    /// ## map

    let inline map fn a = async {
        let! x = a
        return fn x
    }

    /// ## runWithTimeoutAsync

    let inline runWithTimeoutAsync (timeout : int) fn =
        let getLocals () = $"timeout: {timeout} / {getLocals ()}"

        let timeoutTask = async {
            do! Async.Sleep timeout
            trace Debug (fun () -> "runWithTimeoutAsync") getLocals
            return None
        }

        let task = async {
            try
                let! result = fn
                return Some result
            with
            | :? System.AggregateException as ex when
                ex.InnerExceptions
                |> Seq.exists (function :? System.Threading.Tasks.TaskCanceledException -> true | _ -> false)
                ->
                let getLocals () = $"ex: {ex |> printException} / {getLocals ()}"
                trace Warn (fun () -> "runWithTimeoutAsync") getLocals
                return None
            | ex ->
                trace Error (fun () -> "runWithTimeoutAsync") getLocals
                return raise ex
        }

        [ timeoutTask; task ]
        |> choice

    let inline runWithTimeout timeout fn =
        fn
        |> runWithTimeoutAsync timeout
        |> Async.RunSynchronously

    /// ## runWithTimeoutStrict

    let inline runWithTimeoutStrict (timeout : int) fn =
        let getLocals () = $"timeout: {timeout} / {getLocals ()}"

        let timeoutTask = async {
            do! Async.Sleep timeout
            return None, getLocals
        }

        let task = async {
            try
                return Async.RunSynchronously (fn, timeout) |> Some, getLocals
            with
            | :? System.TimeoutException as ex ->
                let getLocals () = $"ex: {ex |> printException} / {getLocals ()}"
                return None, getLocals
            | e ->
                trace Error (fun () -> "runWithTimeoutStrict") getLocals
                return raise e
        }

        try
            [| timeoutTask; task |]
            |> Array.map Async.StartAsTask
            |> System.Threading.Tasks.Task.WhenAny
            |> fun task ->
                match task.Result.Result with
                | None, getLocals ->
                    trace Debug (fun () -> "runWithTimeoutStrict") getLocals
                    None
                | result, _ -> result
        with
        | :? System.AggregateException as ex when
            ex.InnerExceptions
            |> Seq.exists (function :? System.Threading.Tasks.TaskCanceledException -> true | _ -> false)
            ->
            let getLocals () = $"ex: {ex |> printException} / {getLocals ()}"
            trace Warn (fun () -> "runWithTimeoutStrict") getLocals
            None
        | ex ->
            trace Error (fun () -> "runWithTimeoutStrict") getLocals
            raise ex

    /// ## awaitValueTask

    let inline awaitValueTaskUnit (task : System.Threading.Tasks.ValueTask) =
        task.AsTask () |> Async.AwaitTask

    let inline awaitValueTask (task : System.Threading.Tasks.ValueTask<_>) =
        task.AsTask () |> Async.AwaitTask

    /// ## init

    let inline init x = async {
        return x
    }

    /// ## mergeCancellationTokenWithDefaultAsync

    let inline mergeCancellationTokenWithDefaultAsync (token : System.Threading.CancellationToken) = async {
        let! ct = Async.CancellationToken
        let dct = Async.DefaultCancellationToken
        let cts = System.Threading.CancellationTokenSource.CreateLinkedTokenSource [| ct; dct; token |]
        return cts.Token
    }

    /// ## withTraceLevel

    let inline withTraceLevel level fn = async {
        let oldTraceLevel = traceLevel
        try
            traceLevel <- level
            return! fn
        finally
            traceLevel <- oldTraceLevel
    }
