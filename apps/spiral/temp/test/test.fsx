let rec closure0 () () : int32 =
    let v2 : (string -> unit) = System.Console.WriteLine
    let v3 : string = "test"
    v2 v3
    0
let v0 : (unit -> int32) = closure0()
()
