[<Fable.Core.Erase; Fable.Core.Emit("leptos::ev::MouseEvent")>] type leptos_ev_MouseEvent = class end
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
and method3 (v0 : leptos_RwSignal<leptos_RwSignal<bool>>) : leptos_RwSignal<leptos_RwSignal<bool>> =
    v0
and method4 (v0 : leptos_RwSignal<bool>) : leptos_RwSignal<bool> =
    v0
and closure2 (v0 : Heap0) () : bool =
    let v1 : leptos_RwSignal<leptos_RwSignal<bool>> = v0.l0
    let v2 : leptos_RwSignal<leptos_RwSignal<bool>> = method3(v1)
    let v3 : string = $"leptos::SignalGet::get(&v2)"
    let v4 : leptos_RwSignal<bool> = Fable.Core.RustInterop.emitRustExpr () v3
    let v5 : leptos_RwSignal<bool> = method4(v4)
    let v6 : string = $"leptos::SignalGet::get(&v5)"
    let v7 : bool = Fable.Core.RustInterop.emitRustExpr () v6
    v7
and method2 (v0 : Heap0) : (unit -> bool) =
    closure2(v0)
and closure4 () (v0 : bool) : bool =
    let v1 : bool = v0 = false
    v1
and method6 () : (bool -> bool) =
    closure4()
and method7 (v0 : leptos_RwSignal<bool>) : leptos_RwSignal<bool> =
    v0
and closure3 (v0 : Heap0) (v1 : leptos_ev_MouseEvent) : unit =
    let v2 : leptos_RwSignal<leptos_RwSignal<bool>> = v0.l0
    let v3 : leptos_RwSignal<leptos_RwSignal<bool>> = method3(v2)
    let v4 : string = $"leptos::SignalGet::get(&v3)"
    let v5 : leptos_RwSignal<bool> = Fable.Core.RustInterop.emitRustExpr () v4
    let v6 : (bool -> bool) = method6()
    let v7 : leptos_RwSignal<bool> = method7(v5)
    let v8 : string = $"leptos::SignalUpdate::update(&v7, |x| *x = v6(*x))"
    Fable.Core.RustInterop.emitRustExpr () v8
    ()
and method5 (v0 : Heap0) : (leptos_ev_MouseEvent -> unit) =
    closure3(v0)
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
    let v7 : string = "leptos::use_context::<std::rc::Rc<Heap0>>().unwrap().into()"
    let v8 : Heap0 = Fable.Core.RustInterop.emitRustExpr () v7
    let v9 : string = string 30
    let v10 : string = method0(v9)
    let v11 : string = $"fable_library_rust::String_::LrcStr::as_str(&v10)"
    let v12 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v11
    let v13 : string = method1()
    let v14 : string = $"fable_library_rust::String_::LrcStr::as_str(&v13)"
    let v15 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v14
    let v16 : string = $"String::from(v15)"
    let v17 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v16
    let v18 : string = $"leptos::create_signal(v17)"
    let struct (v19 : (unit -> std_string_String), v20 : (std_string_String -> unit)) = Fable.Core.RustInterop.emitRustExpr () v18
    let v21 : string = $"leptos::view! {{ <input class=\"bg-gray-50 dark:bg-gray-900 flex-1 h-8\" prop:value=$0 on:keyup=move |event: web_sys::KeyboardEvent| {{ $1(leptos::event_target_value(&event)) }} /> }}"
    let v22 : leptos_HtmlElement<leptos_html_Input> = Fable.Core.RustInterop.emitRustExpr struct (v19, v20) v21
    let v23 : Impl<leptos_IntoView> = v22 |> unbox
    let v24 : leptos_HtmlElement<leptos_html_Input> = v23 |> unbox
    let v25 : string = "leptos::view! { <div class=\"flex flex-1 min-h-screen min-w-full bg-gray-50 dark:bg-gray-900 text-gray-700 dark:text-gray-200 text-xs\" style=\"font-size: \".to_owned() + *$0 + \"px\">label:{v24}</div> }"
    let v26 : leptos_HtmlElement<leptos_html_Div> = Fable.Core.RustInterop.emitRustExpr v12 v25
    let v27 : Impl<leptos_IntoView> = v26 |> unbox
    let v28 : leptos_HtmlElement<leptos_html_Div> = v27 |> unbox
    let v29 : (unit -> bool) = method2(v8)
    let v30 : string = "leptos::use_context::<std::rc::Rc<Heap0>>().unwrap().into()"
    let v31 : Heap0 = Fable.Core.RustInterop.emitRustExpr () v30
    let v32 : (leptos_ev_MouseEvent -> unit) = method5(v31)
    let v33 : string = $"<button class=\"fixed bottom-4 right-4 bg-gray-500 text-white p-2 rounded-full\" on:click=move |mouse_event| v32(mouse_event)>{{(|| {{ leptos::logging::log!(\"button () / render\"); leptos::view! {{<></>}} }})()}}{{\"🌓︎\"}}</button>"
    let v34 : string = "leptos::view! { " + v33 + " }"
    let v35 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v34
    let v36 : leptos_HtmlElement<leptos_html_Button> = v35 |> unbox
    let v37 : string = "<div class=\"flex flex-1\" class:dark={move || v29()}>{v36}{v28}</div>"
    let v38 : string = "leptos::view! { " + v37 + " }"
    let v39 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v38
    let v40 : leptos_HtmlElement<leptos_html_Div> = v39 |> unbox
    let v41 : string = "leptos::IntoView::into_view(v40)"
    let v42 : leptos_View = Fable.Core.RustInterop.emitRustExpr () v41
    let v43 : Impl<leptos_IntoView> = v42 |> unbox
    v43
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
