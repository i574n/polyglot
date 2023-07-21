/// # Networking (Polyglot)

#if !INTERACTIVE
namespace Polyglot
#endif

module Networking =

    open Common

    /// ## testPortOpen

    let testPortOpen port = async {
        use client = new System.Net.Sockets.TcpClient ()
        try
            do! client.ConnectAsync ("127.0.0.1", port) |> Async.AwaitTask
            return true
        with ex ->
            trace Warn (fun () -> $"testPortOpen / message: {ex.Message}") getLocals
            return false
    }

    /// ## waitForPortAccess

    let waitForPortAccess status port =
        let rec loop retry = async {
            let! isPortOpen = testPortOpen port
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

    let getAvailablePort initialPort =
        let rec loop port = async {
            let! isPortOpen = testPortOpen port
            if not isPortOpen
            then return port
            else return! loop (port + 1)
        }
        loop initialPort
