/// # AsyncSeq (Polyglot)

#if !INTERACTIVE
namespace Polyglot
#endif

module AsyncSeq =

    open Common

    /// ## subscribeEvent

    let subscribeEvent (event: IEvent<'H, 'A>) map =
        let observable = System.Reactive.Linq.Observable.FromEventPattern<'H, 'A>(event.AddHandler, event.RemoveHandler)
        System.Reactive.Linq.Observable.Select (observable, fun event -> map event.EventArgs)
        |> FSharp.Control.AsyncSeq.ofObservableBuffered
