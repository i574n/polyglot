#if !INTERACTIVE
namespace Polyglot
#endif

module Networking =

    open Common

    /// ## testPortOpen

    let testPortOpen port = async {
        let! ct = Async.CancellationToken
        use client = new System.Net.Sockets.TcpClient ()
        try
            do! client.ConnectAsync ("127.0.0.1", port, ct) |> Async.awaitValueTaskUnit
            return true
        with ex ->
            trace Verbose (fun () -> $"testPortOpen / ex: {ex |> printException}") getLocals
            return false
    }

    let testPortOpenTimeout timeout port = async {
        let! result =
            testPortOpen port
            |> Async.runWithTimeoutAsync timeout
        return
            match result with
            | None -> false
            | Some result -> result
    }

    /// ## waitForPortAccess

    let waitForPortAccess timeout status port =
        let rec loop retry = async {
            let! isPortOpen =
                match timeout with
                | None -> testPortOpen port
                | Some timeout -> testPortOpenTimeout timeout port
            if isPortOpen = status
            then return retry
            else
                if retry % 100 = 0 then
                    let getLocals () = $"port: {port} / retry: {retry} / {getLocals ()}"
                    trace Warn (fun () -> "waitForPortAccess") getLocals
                do! Async.Sleep 1
                return! loop (retry + 1)
        }
        loop 0

    /// ## getAvailablePort

    let getAvailablePort timeout initialPort =
        let rec loop port = async {
            let! isPortOpen =
                match timeout with
                | None -> testPortOpen port
                | Some timeout -> testPortOpenTimeout timeout port
            if not isPortOpen
            then return port
            else return! loop (port + 1)
        }
        loop initialPort
