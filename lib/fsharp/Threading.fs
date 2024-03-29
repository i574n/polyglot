#if !INTERACTIVE
namespace Polyglot
#endif

module Threading =

    open Common

    /// ## newDisposableToken

    let inline newDisposableToken (mergeToken: System.Threading.CancellationToken option) =
        let cts = new System.Threading.CancellationTokenSource ()
        let cts =
            match mergeToken with
            | None -> cts
            | Some mergeToken ->
                System.Threading.CancellationTokenSource.CreateLinkedTokenSource [| cts.Token; mergeToken |]
        let disposable = new_disposable cts.Cancel
        cts.Token, disposable
