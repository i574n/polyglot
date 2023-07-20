// # Async (Polyglot)

#if !INTERACTIVE
namespace Polyglot
#endif

module Async =

    open Common

    // ## runWithTimeout

    let runWithTimeout timeout fn =
        try
            Async.RunSynchronously (fn, timeout) |> Some
        with
        | :? System.TimeoutException as ex ->
            let info = ex

            let getLocals () = $"timeout: {timeout} / exception: {ex.Message} / {getLocals ()}"
            trace Debug (fun () -> "runWithTimeout") getLocals
            None
        | e -> raise e
