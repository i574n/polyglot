let rec closure0 () () : int32 =
    let v0 : string = "test"
    System.Console.WriteLine v0
    -1
let v0 : (unit -> int32) = closure0()
()
