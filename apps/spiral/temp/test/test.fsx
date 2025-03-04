let rec closure1 () () : unit =
    let v0 : (string -> unit) = System.Console.WriteLine
    let v1 : string = "test"
    v0 v1
and closure0 () () : int32 =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure1()
    let v3 : unit = (fun () -> v2 (); v1) ()
    0
let v0 : (unit -> int32) = closure0()
()
