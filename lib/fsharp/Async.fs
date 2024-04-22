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
        let _locals () = $"timeout: {timeout} / {_locals ()}"

        let timeoutTask = async {
            do! Async.Sleep timeout
            trace Debug (fun () -> "runWithTimeoutAsync") _locals
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
                let _locals () = $"ex: {ex |> SpiralSm.format_exception} / {_locals ()}"
                trace Warning (fun () -> "runWithTimeoutAsync") _locals
                return None
            | ex ->
                trace Critical (fun () -> $"runWithTimeoutAsync** / ex: {ex |> SpiralSm.format_exception}") _locals
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
        let _locals () = $"timeout: {timeout} / {_locals ()}"
        let! child = Async.StartChild (fn, timeout)
        return!
            child
            |> catch
            |> map (function
                | Ok result -> Some result
                | Error (:? System.TimeoutException as ex) ->
                    trace Debug (fun () -> $"runWithTimeoutChildAsync") _locals
                    None
                | Error ex ->
                    trace Critical (fun () -> $"runWithTimeoutChildAsync** / ex: {ex |> SpiralSm.format_exception}") _locals
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
        let _locals () = $"timeout: {timeout} / {_locals ()}"

        let timeoutTask = async {
            do! Async.Sleep timeout
            return None, _locals
        }

        let task = async {
            try
                return Async.RunSynchronously (fn, timeout) |> Some, _locals
            with
            | :? System.TimeoutException as ex ->
                let _locals () = $"ex: {ex |> SpiralSm.format_exception} / {_locals ()}"
                return None, _locals
            | ex ->
                trace Critical (fun () -> $"runWithTimeoutStrict / ex: {ex |> SpiralSm.format_exception}") _locals
                return raise ex
        }

        try
            [| timeoutTask; task |]
            |> Array.map Async.StartAsTask
            |> System.Threading.Tasks.Task.WhenAny
            |> fun task ->
                match task.Result.Result with
                | None, _locals ->
                    trace Debug (fun () -> "runWithTimeoutStrict") _locals
                    None
                | result, _ -> result
        with
        | :? System.AggregateException as ex when
            ex.InnerExceptions
            |> Seq.exists (function :? System.Threading.Tasks.TaskCanceledException -> true | _ -> false)
            ->
            let _locals () = $"ex: {ex |> SpiralSm.format_exception} / {_locals ()}"
            trace Warning (fun () -> "runWithTimeoutStrict") _locals
            None
        | ex ->
            let _locals () = $"ex: {ex |> SpiralSm.format_exception} / {_locals ()}"
            trace Critical (fun () -> "runWithTimeoutStrict**") _locals
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
