let rec closure0 () () : int32 =
    let v0 : string = "test"
    v0 |> System.Console.WriteLine
    0
let v0 : (unit -> int32) = closure0()
()
