[<Fable.Core.Erase; Fable.Core.Emit("leptos::html::Button")>] type leptos_html_Button = class end
[<Fable.Core.Erase; Fable.Core.Emit("leptos::html::Div")>] type leptos_html_Div = class end
[<Fable.Core.Erase; Fable.Core.Emit("leptos::html::Input")>] type leptos_html_Input = class end
[<Fable.Core.Erase; Fable.Core.Emit("leptos::Fragment")>] type leptos_Fragment = class end
[<Fable.Core.Erase; Fable.Core.Emit("leptos::HtmlElement<$0>")>] type leptos_HtmlElement<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("leptos::IntoView")>] type leptos_IntoView = class end
[<Fable.Core.Erase; Fable.Core.Emit("leptos::RwSignal<$0>")>] type leptos_RwSignal<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("leptos::View")>] type leptos_View = class end
[<Fable.Core.Erase; Fable.Core.Emit("std::string::String")>] type std_string_String = class end
[<Fable.Core.Erase; Fable.Core.Emit("dyn $0")>] type Dyn<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("Fn() -> $0")>] type Fn<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("FnOnce() -> $0")>] type FnOnce<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("Fn()")>] type FnUnit = class end
[<Fable.Core.Erase; Fable.Core.Emit("impl $0")>] type Impl<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("std::rc::Rc<$0>")>] type Rc<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("&$0")>] type Ref<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("str")>] type Str = class end
type Heap0 = {l0 : leptos_RwSignal<leptos_RwSignal<bool>>}
let rec method0 (v0 : string) : string =
    v0
and method1 () : string =
    let v0 : string = "explorer-backend-mainnet-prod-24ktefolwq-uc.a.run.app"
    v0
and closure1 () () : Impl<leptos_IntoView> =
    let v0 : string = "leptos_meta::provide_meta_context()"
    Fable.Core.RustInterop.emitRustExpr () v0
    let v1 : string = $"leptos::create_rw_signal(true)"
    let v2 : leptos_RwSignal<bool> = Fable.Core.RustInterop.emitRustExpr () v1
    let v3 : string = $"leptos::create_rw_signal(v2)"
    let v4 : leptos_RwSignal<leptos_RwSignal<bool>> = Fable.Core.RustInterop.emitRustExpr () v3
    let v5 : Heap0 = {l0 = v4} : Heap0
    let v6 : string = $"leptos::provide_context::<std::rc::Rc<Heap0>>(v5)"
    Fable.Core.RustInterop.emitRustExpr () v6
    let v7 : string = string 30
    let v8 : string = method0(v7)
    let v9 : string = $"fable_library_rust::String_::LrcStr::as_str(&v8)"
    let v10 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v9
    let v11 : string = method1()
    let v12 : string = $"fable_library_rust::String_::LrcStr::as_str(&v11)"
    let v13 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v12
    let v14 : string = $"String::from(v13)"
    let v15 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v14
    let v16 : string = $"leptos::create_signal(v15)"
    let struct (v17 : (unit -> std_string_String), v18 : (std_string_String -> unit)) = Fable.Core.RustInterop.emitRustExpr () v16
    let v19 : string = $"leptos::view! {{ <input class=\"bg-gray-50 dark:bg-gray-900 flex-1 h-8\" prop:value=$0 on:keyup=move |event: web_sys::KeyboardEvent| {{ $1(leptos::event_target_value(&event)) }} /> }}"
    let v20 : leptos_HtmlElement<leptos_html_Input> = Fable.Core.RustInterop.emitRustExpr struct (v17, v18) v19
    let v21 : Impl<leptos_IntoView> = v20 |> unbox
    let v22 : leptos_HtmlElement<leptos_html_Input> = v21 |> unbox
    let v23 : string = "leptos::view! { <div class=\"flex flex-1\" style=\"font-size: \".to_owned() + *$0 + \"px\">2{v22}</div> }"
    let v24 : leptos_HtmlElement<leptos_html_Div> = Fable.Core.RustInterop.emitRustExpr v10 v23
    let v25 : Impl<leptos_IntoView> = v24 |> unbox
    let v26 : leptos_HtmlElement<leptos_html_Div> = v25 |> unbox
    let v27 : string = "leptos::use_context::<std::rc::Rc<Heap0>>().unwrap().into()"
    let v28 : Heap0 = Fable.Core.RustInterop.emitRustExpr () v27
    let v29 : string = "leptos::view! { <button class=\"fixed bottom-4 right-4 bg-gray-500 text-white p-2 rounded-full\">{(|| { leptos::logging::log!(\"button () / render\"); leptos::view! {<></>} })()}{\"🌓︎\"}</button> }"
    let v30 : leptos_HtmlElement<leptos_html_Button> = Fable.Core.RustInterop.emitRustExpr () v29
    let v31 : Impl<leptos_IntoView> = v30 |> unbox
    let v32 : leptos_HtmlElement<leptos_html_Button> = v31 |> unbox
    let v33 : string = "<div class=\"flex flex-1\">{v26}{v32}</div>"
    let v34 : string = "leptos::view! { " + v33 + " }"
    let v35 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v34
    let v36 : leptos_HtmlElement<leptos_html_Div> = v35 |> unbox
    let v37 : string = "<div class=\"flex flex-1\">{v36}</div>"
    let v38 : string = "leptos::view! { " + v37 + " }"
    let v39 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v38
    v39
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
