let rec closure0 () () : int32 =
    let v0 : (string -> unit) = System.Console.WriteLine
    let v1 : string = "test"
    v0 v1
    0
let v0 : (unit -> int32) = closure0()
()
