/// # Async (Polyglot)

#if !INTERACTIVE
namespace Polyglot
#endif

module Async =

    open Common

    /// ## runWithTimeout

    let runWithTimeout (timeout : int) fn =
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
                let getLocals () = $"exception: {ex.Message} / {getLocals ()}"
                return None, getLocals
            | e -> return raise e
        }

        [| timeoutTask; task |]
        |> Array.map Async.StartAsTask
        |> System.Threading.Tasks.Task.WhenAny
        |> fun task ->
            match task.Result.Result with
            | None, getLocals ->
                trace Debug (fun () -> "runWithTimeout") getLocals
                None
            | result, _ -> result
