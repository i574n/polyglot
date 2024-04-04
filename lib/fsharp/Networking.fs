#if !INTERACTIVE
namespace Polyglot
#endif

module Networking =

#if !INTERACTIVE
    open Lib
#endif

    open Common

    /// ## testPortOpen

    let inline testPortOpen port = async {
        let! ct = Async.CancellationToken
        use client = new System.Net.Sockets.TcpClient ()
        try
            do! client.ConnectAsync ("127.0.0.1", port, ct) |> Async.awaitValueTaskUnit
            return true
        with ex ->
            trace Verbose (fun () -> $"testPortOpen / ex: {ex |> SpiralSm.format_exception}") getLocals
            return false
    }

    let inline testPortOpenTimeout timeout port = async {
        let! result =
            testPortOpen port
            |> Async.runWithTimeoutAsync timeout
        return
            match result with
            | None -> false
            | Some result -> result
    }

    /// ## waitForPortAccess

    let inline waitForPortAccess timeout status port =
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
                    trace Verbose (fun () -> "waitForPortAccess") getLocals
                do! Async.Sleep 10
                return! loop (retry + 1)
        }
        loop 0

    /// ## getAvailablePort

    let inline getAvailablePort timeout initialPort =
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
