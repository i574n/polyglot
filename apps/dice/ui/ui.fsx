[<Fable.Core.Erase; Fable.Core.Emit("leptos::Fragment")>] type leptos_Fragment = class end
[<Fable.Core.Erase; Fable.Core.Emit("leptos::IntoView")>] type leptos_IntoView = class end
[<Fable.Core.Erase; Fable.Core.Emit("leptos::View")>] type leptos_View = class end
[<Fable.Core.Erase; Fable.Core.Emit("std::string::String")>] type std_string_String = class end
[<Fable.Core.Erase; Fable.Core.Emit("dyn $0")>] type Dyn<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("impl $0")>] type Impl<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("&$0")>] type Ref<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("str")>] type Str = class end
Fable.Core.RustInterop.emitRustExpr () "use leptos::IntoView;"
let rec closure1 () () : Impl<leptos_IntoView> =
    let v0 : string = "leptos::html::div()"
    let v1 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v0
    v1
and closure0 () (v0 : (string [])) : int32 =
    let v1 : string = "result"
    let v2 : string = $"result: {v1}"
    System.Console.WriteLine v2
    let v3 : string = "main / mount_to_body"
    let v4 : string = @"leptos::logging::log!(""" + v3 + @""")"
    Fable.Core.RustInterop.emitRustExpr () v4
    let v5 : string = "leptos::mount_to_body(|| $0())"
    let v6 : (unit -> Impl<leptos_IntoView>) = closure1()
    Fable.Core.RustInterop.emitRustExpr v6 v5
    0
let v0 : ((string []) -> int32) = closure0()
let main args = v0 args
()
