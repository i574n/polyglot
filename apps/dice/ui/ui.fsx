[<Fable.Core.Erase; Fable.Core.Emit("leptos::html::Button")>] type leptos_html_Button = class end
[<Fable.Core.Erase; Fable.Core.Emit("leptos::html::Div")>] type leptos_html_Div = class end
[<Fable.Core.Erase; Fable.Core.Emit("leptos::html::Input")>] type leptos_html_Input = class end
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
let rec method0 (v0 : string) : string =
    v0
and method1 () : string =
    let v0 : string = "explorer-backend-mainnet-prod-24ktefolwq-uc.a.run.app"
    v0
and closure1 () () : Impl<leptos_IntoView> =
    let v0 : string = string 30
    let v1 : string = method0(v0)
    let v2 : string = $"fable_library_rust::String_::LrcStr::as_str(&v1)"
    let v3 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v2
    let v4 : string = method1()
    let v5 : string = $"fable_library_rust::String_::LrcStr::as_str(&v4)"
    let v6 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v5
    let v7 : string = $"String::from(v6)"
    let v8 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v7
    let v9 : string = $"leptos::create_signal(v8)"
    let struct (v10 : (unit -> std_string_String), v11 : (std_string_String -> unit)) = Fable.Core.RustInterop.emitRustExpr () v9
    let v12 : string = $"leptos::view! {{ <input class=\"bg-gray-50 dark:bg-gray-900 flex-1 h-8\" prop:value=$0 on:keyup=move |event: web_sys::KeyboardEvent| {{ $1(leptos::event_target_value(&event)) }} /> }}"
    let v13 : leptos_HtmlElement<leptos_html_Input> = Fable.Core.RustInterop.emitRustExpr struct (v10, v11) v12
    let v14 : Impl<leptos_IntoView> = v13 |> unbox
    let v15 : leptos_HtmlElement<leptos_html_Input> = v14 |> unbox
    let v16 : string = "leptos::view! { <div class=\"flex flex-1\" style=\"font-size: \".to_owned() + *$0 + \"px\">2{v15}</div> }"
    let v17 : leptos_HtmlElement<leptos_html_Div> = Fable.Core.RustInterop.emitRustExpr v3 v16
    let v18 : Impl<leptos_IntoView> = v17 |> unbox
    let v19 : leptos_HtmlElement<leptos_html_Div> = v18 |> unbox
    let v20 : string = "leptos::view! { <button class=\"fixed bottom-4 right-4 bg-gray-500 text-white p-2 rounded-full\">{(|| { leptos::logging::log!(\"button () / render\"); leptos::view! {<></>} })()}{\"🌓︎\"}</button> }"
    let v21 : leptos_HtmlElement<leptos_html_Button> = Fable.Core.RustInterop.emitRustExpr () v20
    let v22 : Impl<leptos_IntoView> = v21 |> unbox
    let v23 : leptos_HtmlElement<leptos_html_Button> = v22 |> unbox
    let v24 : string = "<div class=\"flex flex-1\">{v19}{v23}</div>"
    let v25 : string = "leptos::view! { " + v24 + " }"
    let v26 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v25
    v26
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
