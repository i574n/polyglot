// # Async (Polyglot)

#if !INTERACTIVE
namespace Polyglot
#endif

module Async =

    open Common

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

    module AsyncSeq =
        let subscribeEvent (event: IEvent<'H, 'A>) map =
            let x = System.Reactive.Linq.Observable.FromEventPattern<'H, 'A>(event.AddHandler, event.RemoveHandler)
            System.Reactive.Linq.Observable.Select (x, fun event -> map event.EventArgs)
            |> FSharp.Control.AsyncSeq.ofObservableBuffered
