namespace clr

open clr


module Main =
    [<EntryPoint>]
    let main _ =
        Logger.init ()
        Logger.logTrace (fun () -> "clr") getLocals
        System.Threading.Thread.Sleep 1000
        System.Console.Out.Flush ()
        printfn "clr"
        0
