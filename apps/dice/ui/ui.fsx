[<Fable.Core.Erase; Fable.Core.Emit("leptos::html::Div")>] type leptos_html_Div = class end
[<Fable.Core.Erase; Fable.Core.Emit("leptos::Fragment")>] type leptos_Fragment = class end
[<Fable.Core.Erase; Fable.Core.Emit("leptos::HtmlElement<$0>")>] type leptos_HtmlElement<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("leptos::IntoView")>] type leptos_IntoView = class end
[<Fable.Core.Erase; Fable.Core.Emit("leptos::View")>] type leptos_View = class end
[<Fable.Core.Erase; Fable.Core.Emit("std::string::String")>] type std_string_String = class end
[<Fable.Core.Erase; Fable.Core.Emit("dyn $0")>] type Dyn<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("Fn() -> $0")>] type Fn<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("FnOnce() -> $0")>] type FnOnce<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("Fn()")>] type FnUnit = class end
[<Fable.Core.Erase; Fable.Core.Emit("impl $0")>] type Impl<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("&$0")>] type Ref<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("str")>] type Str = class end
let rec closure1 () () : Impl<leptos_IntoView> =
    let v0 : string = string 30
    let v1 : string = "fable_library_rust::String_::LrcStr::as_str($0)"
    let v2 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : string = "leptos::view! { <div style=\"font-size: \".to_owned() + *$0 + \"px\">2</div> }"
    let v4 : leptos_HtmlElement<leptos_html_Div> = Fable.Core.RustInterop.emitRustExpr v2 v3
    let v5 : Impl<leptos_IntoView> = v4 |> unbox
    let v6 : leptos_HtmlElement<leptos_html_Div> = v5 |> unbox
    let v7 : string = "leptos::IntoView::into_view(v6)"
    let v8 : leptos_View = Fable.Core.RustInterop.emitRustExpr () v7
    let v9 : string = "<div>{v8}</div>"
    let v10 : string = "leptos::view! { " + v9 + " }"
    let v11 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v10
    v11
and closure0 () (v0 : (string [])) : int32 =
    let v1 : string = "args: " + string v0 + ""
    let v2 : string = @$"leptos::logging::log!(""{{}}"", $0)"
    Fable.Core.RustInterop.emitRustExpr v1 v2
    let v3 : string = "let _ = console_log::init_with_level(log::Level::Debug)"
    Fable.Core.RustInterop.emitRustExpr () v3
    let v4 : string = "console_error_panic_hook::set_once()"
    Fable.Core.RustInterop.emitRustExpr () v4
    let v5 : string = "main / mount_to_body"
    let v6 : string = @"leptos::logging::log!(""" + v5 + @""")"
    Fable.Core.RustInterop.emitRustExpr () v6
    let v7 : string = "leptos::mount_to_body(|| $0())"
    let v8 : (unit -> Impl<leptos_IntoView>) = closure1()
    Fable.Core.RustInterop.emitRustExpr v8 v7
    0
let v0 : ((string []) -> int32) = closure0()
let main args = v0 args
()
