[<Fable.Core.Erase; Fable.Core.Emit("leptos::ev::MouseEvent")>] type leptos_ev_MouseEvent = class end
[<Fable.Core.Erase; Fable.Core.Emit("leptos::html::Button")>] type leptos_html_Button = class end
[<Fable.Core.Erase; Fable.Core.Emit("leptos::html::Div")>] type leptos_html_Div = class end
[<Fable.Core.Erase; Fable.Core.Emit("leptos::html::Input")>] type leptos_html_Input = class end
[<Fable.Core.Erase; Fable.Core.Emit("leptos::Fragment")>] type leptos_Fragment = class end
[<Fable.Core.Erase; Fable.Core.Emit("leptos::HtmlElement<$0>")>] type leptos_HtmlElement<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("leptos::IntoView")>] type leptos_IntoView = class end
[<Fable.Core.Erase; Fable.Core.Emit("leptos::RwSignal<$0>")>] type leptos_RwSignal<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("leptos::Resource<$0, $1>")>] type leptos_Resource<'T, 'U> = class end
[<Fable.Core.Erase; Fable.Core.Emit("leptos::View")>] type leptos_View = class end
[<Fable.Core.Erase; Fable.Core.Emit("rexie::Rexie")>] type rexie_Rexie = class end
[<Fable.Core.Erase; Fable.Core.Emit("rexie::Error")>] type rexie_Error = class end
[<Fable.Core.Erase; Fable.Core.Emit("std::rc::Rc<$0>")>] type std_rc_Rc<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("Box<$0>")>] type Box<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("std::pin::Pin<$0>")>] type std_pin_Pin<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("std::sync::Arc<$0>")>] type std_sync_Arc<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("std::string::String")>] type std_string_String = class end
[<Fable.Core.Erase; Fable.Core.Emit("dyn $0")>] type Dyn<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("Fn() -> $0")>] type Fn<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("FnOnce() -> $0")>] type FnOnce<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("Fn()")>] type FnUnit = class end
[<Fable.Core.Erase; Fable.Core.Emit("std::future::Future<Output = $0>")>] type Future<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("impl $0")>] type Impl<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("&$0")>] type Ref<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("str")>] type Str = class end
type Heap0 = {l0 : leptos_RwSignal<leptos_RwSignal<bool>>}
and [<Struct>] US0 =
    | US0_0
    | US0_1
and [<Struct>] US1 =
    | US1_0 of f0_0 : rexie_Error
    | US1_1 of f1_0 : rexie_Rexie
and [<Struct>] US2 =
    | US2_0
    | US2_1 of f1_0 : bool
and [<Struct>] US3 =
    | US3_0
    | US3_1 of f1_0 : rexie_Rexie
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
and closure3 () () : US0 =
    US0_0
and method5 () : (unit -> US0) =
    closure3()
and method6 (v0 : rexie_Rexie) : US1 =
    US1_1(v0)
and method7 (v0 : rexie_Rexie) : rexie_Rexie =
    v0
and closure4 () (v0 : US0) : std_pin_Pin<Box<Dyn<Future<rexie_Rexie>>>> =
    let v1 : string = "let __future_init = Box::pin(async { //"
    Fable.Core.RustInterop.emitRustExpr () v1
    let v2 : string = "ui.dark_mode_button () / database create_local_resource"
    let v3 : string = @$"leptos::logging::log!(""{{}}"", $0)"
    Fable.Core.RustInterop.emitRustExpr v2 v3
    let v4 : string = "ui.build_database ()"
    let v5 : string = @$"leptos::logging::log!(""{{}}"", $0)"
    Fable.Core.RustInterop.emitRustExpr v4 v5
    let v6 : string = "let __future_init = Box::pin(async { //"
    Fable.Core.RustInterop.emitRustExpr () v6
    let v7 : string = "Box::pin(rexie::Rexie::builder(\"database\").version(1).add_object_store(rexie::ObjectStore::new(\"store\")).build())"
    let v8 : std_pin_Pin<Box<Dyn<Future<Result<rexie_Rexie, rexie_Error>>>>> = Fable.Core.RustInterop.emitRustExpr () v7
    let v9 : string = "v8.await"
    let v10 : Result<rexie_Rexie, rexie_Error> = Fable.Core.RustInterop.emitRustExpr () v9
    let v11 : string = "v10.unwrap()"
    let v12 : rexie_Rexie = Fable.Core.RustInterop.emitRustExpr () v11
    let v13 : US1 = method6(v12)
    let v14 : string = "v13 }})"
    Fable.Core.RustInterop.emitRustExpr () v14
    let v15 : string = "__future_init"
    let v16 : std_pin_Pin<Box<Dyn<Future<US1>>>> = Fable.Core.RustInterop.emitRustExpr () v15
    let v17 : string = "v16.await"
    let v18 : US1 = Fable.Core.RustInterop.emitRustExpr () v17
    let v24 : rexie_Rexie =
        match v18 with
        | US1_0(v20) -> (* Error *)
            let v21 : string = $"Result value was Error: {v20}"
            failwith<rexie_Rexie> v21
        | US1_1(v19) -> (* Ok *)
            v19
    let v25 : rexie_Rexie = method7(v24)
    let v26 : string = "v25 }})"
    Fable.Core.RustInterop.emitRustExpr () v26
    let v27 : string = "{ { // "
    Fable.Core.RustInterop.emitRustExpr () v27
    let v28 : string = "__future_init"
    let v29 : std_pin_Pin<Box<Dyn<Future<rexie_Rexie>>>> = Fable.Core.RustInterop.emitRustExpr () v28
    v29
and method9 (v0 : leptos_Resource<US0, rexie_Rexie>) : leptos_Resource<US0, rexie_Rexie> =
    v0
and closure5 (v0 : leptos_Resource<US0, rexie_Rexie>) () : rexie_Rexie option =
    let v1 : leptos_Resource<US0, rexie_Rexie> = method9(v0)
    let v2 : string = $"leptos::SignalGet::get(&v1)"
    let v3 : rexie_Rexie option = Fable.Core.RustInterop.emitRustExpr () v2
    v3
and method8 (v0 : leptos_Resource<US0, rexie_Rexie>) : (unit -> rexie_Rexie option) =
    closure5(v0)
and closure7 () (v0 : rexie_Rexie) : US3 =
    US3_1(v0)
and method10 (v0 : Result<US2, rexie_Error>) : Result<US2, rexie_Error> =
    v0
and method11 (v0 : US2) : US2 =
    v0
and closure6 () (v0 : rexie_Rexie option) : std_pin_Pin<Box<Dyn<Future<US2>>>> =
    let v1 : string = "let __future_init = Box::pin(async { //"
    Fable.Core.RustInterop.emitRustExpr () v1
    let v2 : string = "ui.dark_mode_button () / dark_mode create_local_resource"
    let v3 : string = @$"leptos::logging::log!(""{{}}"", $0)"
    Fable.Core.RustInterop.emitRustExpr v2 v3
    let v4 : (rexie_Rexie -> US3) = closure7()
    let v5 : US3 = US3_0
    let v6 : US3 = v0 |> Option.map v4 |> Option.defaultValue v5
    let v24 : US2 =
        match v6 with
        | US3_0 -> (* None *)
            US2_0
        | US3_1(v7) -> (* Some *)
            let v8 : string = "ui.get_dark_mode ()"
            let v9 : string = @$"leptos::logging::log!(""{{}}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v8 v9
            let v10 : string = "let __future_init = Box::pin(async { //"
            Fable.Core.RustInterop.emitRustExpr () v10
            let v11 : US2 = US2_1(true)
            let v12 : Result<US2, rexie_Error> = Ok v11
            let v13 : Result<US2, rexie_Error> = method10(v12)
            let v14 : string = "v13 }})"
            Fable.Core.RustInterop.emitRustExpr () v14
            let v15 : string = "{ // "
            Fable.Core.RustInterop.emitRustExpr () v15
            let v16 : string = "__future_init"
            let v17 : std_pin_Pin<Box<Dyn<Future<Result<US2, rexie_Error>>>>> = Fable.Core.RustInterop.emitRustExpr () v16
            let v18 : string = "v17.await"
            let v19 : Result<US2, rexie_Error> = Fable.Core.RustInterop.emitRustExpr () v18
            let v20 : string = "v19.unwrap()"
            let v21 : US2 = Fable.Core.RustInterop.emitRustExpr () v20
            v21
    let v25 : US2 = method11(v24)
    let v26 : string = "v25 }})"
    Fable.Core.RustInterop.emitRustExpr () v26
    let v27 : string = "{ // "
    Fable.Core.RustInterop.emitRustExpr () v27
    let v28 : string = "__future_init"
    let v29 : std_pin_Pin<Box<Dyn<Future<US2>>>> = Fable.Core.RustInterop.emitRustExpr () v28
    v29
and closure9 () (v0 : bool) : bool =
    let v1 : bool = v0 = false
    v1
and method13 () : (bool -> bool) =
    closure9()
and method14 (v0 : leptos_RwSignal<bool>) : leptos_RwSignal<bool> =
    v0
and closure8 (v0 : Heap0) (v1 : leptos_ev_MouseEvent) : unit =
    let v2 : leptos_RwSignal<leptos_RwSignal<bool>> = v0.l0
    let v3 : leptos_RwSignal<leptos_RwSignal<bool>> = method3(v2)
    let v4 : string = $"leptos::SignalGet::get(&v3)"
    let v5 : leptos_RwSignal<bool> = Fable.Core.RustInterop.emitRustExpr () v4
    let v6 : (bool -> bool) = method13()
    let v7 : leptos_RwSignal<bool> = method14(v5)
    let v8 : string = $"leptos::SignalUpdate::update(&v7, |x| *x = v6(*x))"
    Fable.Core.RustInterop.emitRustExpr () v8
    ()
and method12 (v0 : Heap0) : (leptos_ev_MouseEvent -> unit) =
    closure8(v0)
and closure1 () () : Impl<leptos_IntoView> =
    let v0 : string = "ui.app ()"
    let v1 : string = @$"leptos::logging::log!(""{{}}"", $0)"
    Fable.Core.RustInterop.emitRustExpr v0 v1
    let v2 : string = "leptos_meta::provide_meta_context()"
    Fable.Core.RustInterop.emitRustExpr () v2
    let v3 : string = $"leptos::create_rw_signal(true)"
    let v4 : leptos_RwSignal<bool> = Fable.Core.RustInterop.emitRustExpr () v3
    let v5 : string = $"leptos::create_rw_signal(v4)"
    let v6 : leptos_RwSignal<leptos_RwSignal<bool>> = Fable.Core.RustInterop.emitRustExpr () v5
    let v7 : Heap0 = {l0 = v6} : Heap0
    let v8 : string = $"leptos::provide_context::<std::rc::Rc<Heap0>>(v7)"
    Fable.Core.RustInterop.emitRustExpr () v8
    let v9 : string = "ui.home ()"
    let v10 : string = @$"leptos::logging::log!(""{{}}"", $0)"
    Fable.Core.RustInterop.emitRustExpr v9 v10
    let v11 : string = "leptos::use_context::<std::rc::Rc<Heap0>>().unwrap().into()"
    let v12 : Heap0 = Fable.Core.RustInterop.emitRustExpr () v11
    let v13 : string = string 14
    let v14 : string = method0(v13)
    let v15 : string = $"fable_library_rust::String_::LrcStr::as_str(&v14)"
    let v16 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v15
    let v17 : string = method1()
    let v18 : string = $"fable_library_rust::String_::LrcStr::as_str(&v17)"
    let v19 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v18
    let v20 : string = $"String::from(v19)"
    let v21 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v20
    let v22 : string = $"leptos::create_signal(v21)"
    let struct (v23 : (unit -> std_string_String), v24 : (std_string_String -> unit)) = Fable.Core.RustInterop.emitRustExpr () v22
    let v25 : string = $"leptos::view! {{ <input class=\"bg-gray-50 dark:bg-gray-900 flex-1 h-8\" prop:value=$0 on:keyup=move |event: web_sys::KeyboardEvent| {{ $1(leptos::event_target_value(&event)) }} /> }}"
    let v26 : leptos_HtmlElement<leptos_html_Input> = Fable.Core.RustInterop.emitRustExpr struct (v23, v24) v25
    let v27 : Impl<leptos_IntoView> = v26 |> unbox
    let v28 : leptos_HtmlElement<leptos_html_Input> = v27 |> unbox
    let v29 : string = "leptos::view! { <div class=\"bg-gray-50 dark:bg-gray-900 flex flex-1 min-h-screen min-w-full place-items-baseline text-gray-700 dark:text-gray-200 text-sm\" style=\"font-size: \".to_owned() + *$0 + \"px; place-items: baseline;\">label:{v28}</div> }"
    let v30 : leptos_HtmlElement<leptos_html_Div> = Fable.Core.RustInterop.emitRustExpr v16 v29
    let v31 : Impl<leptos_IntoView> = v30 |> unbox
    let v32 : leptos_HtmlElement<leptos_html_Div> = v31 |> unbox
    let v33 : (unit -> bool) = method2(v12)
    let v34 : string = "ui.dark_mode_button ()"
    let v35 : string = @$"leptos::logging::log!(""{{}}"", $0)"
    Fable.Core.RustInterop.emitRustExpr v34 v35
    let v36 : string = "leptos::use_context::<std::rc::Rc<Heap0>>().unwrap().into()"
    let v37 : Heap0 = Fable.Core.RustInterop.emitRustExpr () v36
    let v38 : (unit -> US0) = method5()
    let v39 : string = "leptos::create_local_resource(move || v38(), |x| async move { $0(x).await })"
    let v40 : (US0 -> std_pin_Pin<Box<Dyn<Future<rexie_Rexie>>>>) = closure4()
    let v41 : leptos_Resource<US0, rexie_Rexie> = Fable.Core.RustInterop.emitRustExpr v40 v39
    let v42 : (unit -> rexie_Rexie option) = method8(v41)
    let v43 : string = "leptos::create_local_resource(move || v42(), |x| async move { $0(x).await })"
    let v44 : (rexie_Rexie option -> std_pin_Pin<Box<Dyn<Future<US2>>>>) = closure6()
    let v45 : leptos_Resource<rexie_Rexie option, US2> = Fable.Core.RustInterop.emitRustExpr v44 v43
    let v46 : (leptos_ev_MouseEvent -> unit) = method12(v37)
    let v47 : string = $"<button class=\"fixed bottom-4 right-4 bg-gray-500 text-white p-2 rounded-full\" on:click=move |mouse_event| v46(mouse_event)>{{(|| {{ leptos::logging::log!(\"button () / render\"); leptos::view! {{<></>}} }})()}}{{\"🌓︎\"}}</button>"
    let v48 : string = "leptos::view! { " + v47 + " }"
    let v49 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v48
    let v50 : leptos_HtmlElement<leptos_html_Button> = v49 |> unbox
    let v51 : string = "<div class=\"flex flex-1\" class:dark={move || v33()}>{v50}{v32}</div>"
    let v52 : string = "leptos::view! { " + v51 + " }"
    let v53 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v52
    let v54 : leptos_HtmlElement<leptos_html_Div> = v53 |> unbox
    let v55 : string = "leptos::IntoView::into_view(v54)"
    let v56 : leptos_View = Fable.Core.RustInterop.emitRustExpr () v55
    let v57 : Impl<leptos_IntoView> = v56 |> unbox
    v57
and closure0 () (v0 : (string [])) : int32 =
    let v1 : string = "main / args: " + string v0 + ""
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
