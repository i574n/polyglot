#if !INTERACTIVE
namespace Polyglot
#endif

module Async =

#if !INTERACTIVE
    open Lib
#endif

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

    /// ## catch

    let inline catch a =
        a
        |> Async.Catch
        |> map (function
            | Choice1Of2 result -> Ok result
            | Choice2Of2 ex -> Error ex
        )

    /// ## runWithTimeoutAsync

    let inline runWithTimeoutAsync_ (timeout : int) fn =
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
                let getLocals () = $"ex: {ex |> SpiralSm.format_exception} / {getLocals ()}"
                trace Warning (fun () -> "runWithTimeoutAsync") getLocals
                return None
            | ex ->
                trace Critical (fun () -> $"runWithTimeoutAsync** / ex: {ex |> SpiralSm.format_exception}") getLocals
                return None
        }

        [ timeoutTask; task ]
        |> choice

    let inline runWithTimeout_ timeout fn =
        fn
        |> runWithTimeoutAsync_ timeout
        |> Async.RunSynchronously

    /// ## runWithTimeoutChildAsync

    let inline runWithTimeoutChildAsync (timeout : int) fn = async {
        let getLocals () = $"timeout: {timeout} / {getLocals ()}"
        let! child = Async.StartChild (fn, timeout)
        return!
            child
            |> catch
            |> map (function
                | Ok result -> Some result
                | Error (:? System.TimeoutException as ex) ->
                    trace Debug (fun () -> $"runWithTimeoutChildAsync") getLocals
                    None
                | Error ex ->
                    trace Critical (fun () -> $"runWithTimeoutChildAsync** / ex: {ex |> SpiralSm.format_exception}") getLocals
                    None
            )
    }

    let inline runWithTimeoutChild timeout fn =
        fn
        |> runWithTimeoutChildAsync timeout
        |> Async.RunSynchronously

    let inline runWithTimeoutAsync timeout fn =
        runWithTimeoutChildAsync timeout fn

    let inline runWithTimeout timeout fn =
        runWithTimeoutChild timeout fn

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
                let getLocals () = $"ex: {ex |> SpiralSm.format_exception} / {getLocals ()}"
                return None, getLocals
            | ex ->
                trace Critical (fun () -> $"runWithTimeoutStrict / ex: {ex |> SpiralSm.format_exception}") getLocals
                return raise ex
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
            let getLocals () = $"ex: {ex |> SpiralSm.format_exception} / {getLocals ()}"
            trace Warning (fun () -> "runWithTimeoutStrict") getLocals
            None
        | ex ->
            let getLocals () = $"ex: {ex |> SpiralSm.format_exception} / {getLocals ()}"
            trace Critical (fun () -> "runWithTimeoutStrict**") getLocals
            None

    /// ## awaitValueTask

    let inline awaitValueTaskUnit (task : System.Threading.Tasks.ValueTask) =
        task.AsTask () |> Async.AwaitTask

    let inline awaitValueTask (task : System.Threading.Tasks.ValueTask<_>) =
        task.AsTask () |> Async.AwaitTask

    /// ## init

    let inline init x = async {
        return x
    }

    /// ## withCancellationToken

    let inline withCancellationToken (ct : System.Threading.CancellationToken) fn =
        Async.StartImmediateAsTask (fn, ct)
        |> Async.AwaitTask
