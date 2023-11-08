let rec closure0 () (v0 : (string [])) : int32 =
    let v1 : string = "result"
    let v2 : string = $"result: {v1}"
    System.Console.WriteLine v2
    let v3 : string = "main / mount_to_body"
    let v4 : string = @"leptos::logging::log!(""{}"", """ + v3 + @""")"
    Fable.Core.RustInterop.emitRustExpr () v4
    0
let v0 : ((string []) -> int32) = closure0()
let main args = v0 args
()
