let rec closure0 () () : int32 =
    let v2 : string = "test"
    v2 |> System.Console.WriteLine
    0
let v0 : (unit -> int32) = closure0()
()
