[<Fable.Core.Erase; Fable.Core.Emit("leptos::ev::MouseEvent")>] type leptos_ev_MouseEvent = class end
[<Fable.Core.Erase; Fable.Core.Emit("leptos::html::Button")>] type leptos_html_Button = class end
[<Fable.Core.Erase; Fable.Core.Emit("leptos::html::Div")>] type leptos_html_Div = class end
[<Fable.Core.Erase; Fable.Core.Emit("leptos::html::Input")>] type leptos_html_Input = class end
[<Fable.Core.Erase; Fable.Core.Emit("leptos::Action<$0, $1>")>] type leptos_Action<'T, 'U> = class end
[<Fable.Core.Erase; Fable.Core.Emit("leptos::Fragment")>] type leptos_Fragment = class end
[<Fable.Core.Erase; Fable.Core.Emit("leptos::HtmlElement<$0>")>] type leptos_HtmlElement<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("leptos::IntoView")>] type leptos_IntoView = class end
[<Fable.Core.Erase; Fable.Core.Emit("leptos::RwSignal<$0>")>] type leptos_RwSignal<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("leptos::Resource<$0, $1>")>] type leptos_Resource<'T, 'U> = class end
[<Fable.Core.Erase; Fable.Core.Emit("leptos::View")>] type leptos_View = class end
[<Fable.Core.Erase; Fable.Core.Emit("rexie::Error")>] type rexie_Error = class end
[<Fable.Core.Erase; Fable.Core.Emit("rexie::Rexie")>] type rexie_Rexie = class end
[<Fable.Core.Erase; Fable.Core.Emit("rexie::Store")>] type rexie_Store = class end
[<Fable.Core.Erase; Fable.Core.Emit("rexie::Transaction")>] type rexie_Transaction = class end
[<Fable.Core.Erase; Fable.Core.Emit("serde_json::Value")>] type serde_json_Value = class end
[<Fable.Core.Erase; Fable.Core.Emit("wasm_bindgen::JsValue")>] type wasm_bindgen_JsValue = class end
[<Fable.Core.Erase; Fable.Core.Emit("std::rc::Rc<$0>")>] type std_rc_Rc<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("Box<$0>")>] type Box<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("std::pin::Pin<$0>")>] type std_pin_Pin<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("std::sync::Arc<$0>")>] type std_sync_Arc<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("std::string::String")>] type std_string_String = class end
[<Fable.Core.Erase; Fable.Core.Emit("web_sys::Window")>] type web_sys_Window = class end
[<Fable.Core.Erase; Fable.Core.Emit("web_sys::Storage")>] type web_sys_Storage = class end
[<Fable.Core.Erase; Fable.Core.Emit("dyn $0")>] type Dyn<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("Fn() -> $0")>] type Fn<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("FnOnce() -> $0")>] type FnOnce<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("Fn()")>] type FnUnit = class end
[<Fable.Core.Erase; Fable.Core.Emit("std::future::Future<Output = $0>")>] type Future<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("impl $0")>] type Impl<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("&$0")>] type Ref<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("str")>] type Str = class end
[<Fable.Core.Erase; Fable.Core.Emit("Vec<$0>")>] type Vec<'T> = class end
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
and [<Struct>] US4 =
    | US4_0
    | US4_1 of f1_0 : serde_json_Value
and [<Struct>] US5 =
    | US5_0 of f0_0 : rexie_Error
    | US5_1 of f1_0 : US2
and [<Struct>] US6 =
    | US6_0 of f0_0 : wasm_bindgen_JsValue
    | US6_1 of f1_0 : web_sys_Storage option
and [<Struct>] US8 =
    | US8_0
    | US8_1 of f1_0 : web_sys_Storage
and [<Struct>] US7 =
    | US7_0 of f0_0 : wasm_bindgen_JsValue
    | US7_1 of f1_0 : US8
and [<Struct>] US9 =
    | US9_0
    | US9_1 of f1_0 : US2
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
and method10 (v0 : rexie_Rexie) : rexie_Rexie =
    v0
and closure8 () (v0 : serde_json_Value) : US4 =
    US4_1(v0)
and method11 (v0 : serde_json_Value) : serde_json_Value =
    v0
and method12 (v0 : std_string_String) : std_string_String =
    v0
and closure9 () (v0 : bool) : US2 =
    US2_1(v0)
and method13 (v0 : Result<US2, rexie_Error>) : Result<US2, rexie_Error> =
    v0
and method14 (v0 : US2) : US2 =
    v0
and closure6 () (v0 : rexie_Rexie option) : std_pin_Pin<Box<Dyn<Future<US2>>>> =
    let v1 : string = "let __future_init = Box::pin(async { //"
    Fable.Core.RustInterop.emitRustExpr () v1
    let v2 : string = @$"format!(""{{:?}}"", $0)"
    let v3 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v2
    let v4 : string = "ui.dark_mode_button () / dark_mode create_local_resource / database: " + string v3 + ""
    let v5 : string = @$"leptos::logging::log!(""{{}}"", $0)"
    Fable.Core.RustInterop.emitRustExpr v4 v5
    let v6 : (rexie_Rexie -> US3) = closure7()
    let v7 : US3 = US3_0
    let v8 : US3 = v0 |> Option.map v6 |> Option.defaultValue v7
    let v77 : US2 =
        match v8 with
        | US3_0 -> (* None *)
            US2_0
        | US3_1(v9) -> (* Some *)
            let v10 : string = "ui.get_dark_mode ()"
            let v11 : string = @$"leptos::logging::log!(""{{}}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v10 v11
            let v12 : rexie_Rexie = method10(v9)
            let v13 : string = "let __future_init = Box::pin(async { //"
            Fable.Core.RustInterop.emitRustExpr () v13
            let v14 : string = "v12.transaction(&[\"store\"], rexie::TransactionMode::ReadOnly)?"
            let v15 : rexie_Transaction = Fable.Core.RustInterop.emitRustExpr () v14
            let v16 : string = "v15.store(\"store\")?"
            let v17 : rexie_Store = Fable.Core.RustInterop.emitRustExpr () v16
            let v18 : string = "data"
            let v19 : string = "r#\"" + v18 + "\"#"
            let v20 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v19
            let v21 : string = "$0.into()"
            let v22 : Ref<wasm_bindgen_JsValue> = Fable.Core.RustInterop.emitRustExpr v20 v21
            let v23 : string = $"Box::pin(rexie::Store::get(&v17, v22))"
            let v24 : std_pin_Pin<Box<Dyn<Future<Result<wasm_bindgen_JsValue, rexie_Error>>>>> = Fable.Core.RustInterop.emitRustExpr () v23
            let v25 : string = "v24.await"
            let v26 : Result<wasm_bindgen_JsValue, rexie_Error> = Fable.Core.RustInterop.emitRustExpr () v25
            let v27 : string = "v26?"
            let v28 : wasm_bindgen_JsValue = Fable.Core.RustInterop.emitRustExpr () v27
            let v29 : string = "serde_wasm_bindgen::from_value(v28).unwrap()"
            let v30 : serde_json_Value option = Fable.Core.RustInterop.emitRustExpr () v29
            let v31 : (serde_json_Value -> US4) = closure8()
            let v32 : US4 = US4_0
            let v33 : US4 = v30 |> Option.map v31 |> Option.defaultValue v32
            let v59 : US5 =
                match v33 with
                | US4_0 -> (* None *)
                    let v56 : US2 = US2_0
                    US5_1(v56)
                | US4_1(v34) -> (* Some *)
                    let v35 : serde_json_Value = method11(v34)
                    let v36 : string = "serde_json::from_value(v35).unwrap()"
                    let v37 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v36
                    let v38 : string = "ui.get_dark_mode () / data: " + string v37 + ""
                    let v39 : string = @$"leptos::logging::log!(""{{}}"", $0)"
                    Fable.Core.RustInterop.emitRustExpr v38 v39
                    let v40 : std_string_String = method12(v37)
                    let v41 : string = "borsh::BorshDeserialize::deserialize(&mut v40.as_bytes()).unwrap()"
                    let v42 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v41
                    let v43 : string = "ui.get_dark_mode () / json: " + string v42 + ""
                    let v44 : string = @$"leptos::logging::log!(""{{}}"", $0)"
                    Fable.Core.RustInterop.emitRustExpr v43 v44
                    let v45 : string = "serde_json::from_str::<serde_json::Value>($0).unwrap()"
                    let v46 : serde_json_Value = Fable.Core.RustInterop.emitRustExpr v42 v45
                    let v47 : string = "dark-mode"
                    let v48 : string = "r#\"" + v47 + "\"#"
                    let v49 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v48
                    let v50 : string = "v46[v49].as_bool()"
                    let v51 : bool option = Fable.Core.RustInterop.emitRustExpr () v50
                    let v52 : (bool -> US2) = closure9()
                    let v53 : US2 = US2_0
                    let v54 : US2 = v51 |> Option.map v52 |> Option.defaultValue v53
                    US5_1(v54)
            let v65 : Result<US2, rexie_Error> =
                match v59 with
                | US5_0(v62) -> (* Error *)
                    let v63 : Result<US2, rexie_Error> = Error v62
                    v63
                | US5_1(v60) -> (* Ok *)
                    let v61 : Result<US2, rexie_Error> = Ok v60
                    v61
            let v66 : Result<US2, rexie_Error> = method13(v65)
            let v67 : string = "v66 }})"
            Fable.Core.RustInterop.emitRustExpr () v67
            let v68 : string = "{ // "
            Fable.Core.RustInterop.emitRustExpr () v68
            let v69 : string = "__future_init"
            let v70 : std_pin_Pin<Box<Dyn<Future<Result<US2, rexie_Error>>>>> = Fable.Core.RustInterop.emitRustExpr () v69
            let v71 : string = "v70.await"
            let v72 : Result<US2, rexie_Error> = Fable.Core.RustInterop.emitRustExpr () v71
            let v73 : string = "v72.unwrap()"
            let v74 : US2 = Fable.Core.RustInterop.emitRustExpr () v73
            v74
    let v78 : US2 = method14(v77)
    let v79 : string = "v78 }}})"
    Fable.Core.RustInterop.emitRustExpr () v79
    let v80 : string = "{ { // "
    Fable.Core.RustInterop.emitRustExpr () v80
    let v81 : string = "__future_init"
    let v82 : std_pin_Pin<Box<Dyn<Future<US2>>>> = Fable.Core.RustInterop.emitRustExpr () v81
    v82
and method16 () : web_sys_Window =
    let v0 : string = "leptos::leptos_dom::window()"
    let v1 : web_sys_Window = Fable.Core.RustInterop.emitRustExpr () v0
    v1
and method18 (v0 : web_sys_Window) : web_sys_Window =
    v0
and method17 (v0 : web_sys_Window) : Result<web_sys_Storage option, wasm_bindgen_JsValue> =
    let v1 : web_sys_Window = method18(v0)
    let v2 : string = "v1.local_storage()"
    let v3 : Result<web_sys_Storage option, wasm_bindgen_JsValue> = Fable.Core.RustInterop.emitRustExpr () v2
    v3
and closure11 () (v0 : web_sys_Storage option) : US6 =
    US6_1(v0)
and closure12 () (v0 : wasm_bindgen_JsValue) : US6 =
    US6_0(v0)
and closure13 () (v0 : web_sys_Storage) : US8 =
    US8_1(v0)
and method19 (v0 : leptos_Resource<rexie_Rexie option, US2>) : leptos_Resource<rexie_Rexie option, US2> =
    v0
and closure14 () (v0 : US2) : US9 =
    US9_1(v0)
and method20 (v0 : leptos_RwSignal<leptos_RwSignal<bool>>) : leptos_RwSignal<leptos_RwSignal<bool>> =
    v0
and method21 (v0 : bool) : bool =
    v0
and method22 (v0 : leptos_RwSignal<bool>) : leptos_RwSignal<bool> =
    v0
and closure10 (v0 : Heap0, v1 : leptos_Resource<rexie_Rexie option, US2>) () : unit =
    let v2 : string = "ui.dark_mode_button () / create_effect 1 / ##1"
    let v3 : string = @$"leptos::logging::log!(""{{}}"", $0)"
    Fable.Core.RustInterop.emitRustExpr v2 v3
    let v4 : web_sys_Window = method16()
    let v5 : Result<web_sys_Storage option, wasm_bindgen_JsValue> = method17(v4)
    let v6 : (web_sys_Storage option -> US6) = closure11()
    let v7 : (wasm_bindgen_JsValue -> US6) = closure12()
    let v8 : US6 = match v5 with Ok x -> v6 x | Error x -> v7 x
    let v17 : US7 =
        match v8 with
        | US6_0(v14) -> (* Error *)
            US7_0(v14)
        | US6_1(v9) -> (* Ok *)
            let v10 : (web_sys_Storage -> US8) = closure13()
            let v11 : US8 = US8_0
            let v12 : US8 = v9 |> Option.map v10 |> Option.defaultValue v11
            US7_1(v12)
    match v17 with
    | US7_1(v18) -> (* Ok *)
        match v18 with
        | US8_1(v19) -> (* Some *)
            let v20 : leptos_Resource<rexie_Rexie option, US2> = method19(v1)
            let v21 : string = $"leptos::SignalGet::get(&v20)"
            let v22 : US2 option = Fable.Core.RustInterop.emitRustExpr () v21
            let v23 : (US2 -> US9) = closure14()
            let v24 : US9 = US9_0
            let v25 : US9 = v22 |> Option.map v23 |> Option.defaultValue v24
            let v26 : string = @$"format!(""{{:?}}"", $0)"
            let v27 : std_string_String = Fable.Core.RustInterop.emitRustExpr v25 v26
            let v28 : string = "ui.dark_mode_button () / dark_mode effect 0 / ##1.1 / dark_mode: " + string v27 + ""
            let v29 : string = @$"leptos::logging::log!(""{{}}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v28 v29
            match v25 with
            | US9_1(v30) -> (* Some *)
                match v30 with
                | US2_1(v31) -> (* Some *)
                    let v32 : leptos_RwSignal<leptos_RwSignal<bool>> = v0.l0
                    let v33 : leptos_RwSignal<leptos_RwSignal<bool>> = method20(v32)
                    let v34 : string = $"leptos::SignalGetUntracked::get_untracked(&v33)"
                    let v35 : leptos_RwSignal<bool> = Fable.Core.RustInterop.emitRustExpr () v34
                    let v36 : bool = method21(v31)
                    let v37 : leptos_RwSignal<bool> = method22(v35)
                    let v38 : string = $"leptos::SignalSet::set(&v37, v36)"
                    Fable.Core.RustInterop.emitRustExpr () v38
                    ()
                | _ ->
                    ()
            | _ ->
                ()
        | _ ->
            ()
    | _ ->
        ()
and method15 (v0 : Heap0, v1 : leptos_Resource<rexie_Rexie option, US2>) : (unit -> unit) =
    closure10(v0, v1)
and method24 (v0 : rexie_Rexie) : rexie_Rexie =
    v0
and method25 (v0 : Result<unit, rexie_Error>) : Result<unit, rexie_Error> =
    v0
and method26 () : unit =
    ()
and closure15 (v0 : leptos_Resource<US0, rexie_Rexie>) (v1 : bool) : std_pin_Pin<Box<Dyn<Future<unit>>>> =
    let v2 : string = "ui.dark_mode_button () / set_dark_mode_action / value: " + string v1 + ""
    let v3 : string = @$"leptos::logging::log!(""{{}}"", $0)"
    Fable.Core.RustInterop.emitRustExpr v2 v3
    let v4 : leptos_Resource<US0, rexie_Rexie> = method9(v0)
    let v5 : string = $"leptos::SignalGet::get(&v4)"
    let v6 : rexie_Rexie option = Fable.Core.RustInterop.emitRustExpr () v5
    let v7 : (rexie_Rexie -> US3) = closure7()
    let v8 : US3 = US3_0
    let v9 : US3 = v6 |> Option.map v7 |> Option.defaultValue v8
    let v13 : rexie_Rexie =
        match v9 with
        | US3_0 -> (* None *)
            failwith<rexie_Rexie> "Option does not have a value."
        | US3_1(v10) -> (* Some *)
            v10
    let v14 : string = "let __future_init = Box::pin(async move { //"
    Fable.Core.RustInterop.emitRustExpr () v14
    let v15 : string = "ui.set_dark_mode () / mode: " + string v1 + ""
    let v16 : string = @$"leptos::logging::log!(""{{}}"", $0)"
    Fable.Core.RustInterop.emitRustExpr v15 v16
    let v17 : rexie_Rexie = method24(v13)
    let v18 : string = "let __future_init = Box::pin(async { //"
    Fable.Core.RustInterop.emitRustExpr () v18
    let v19 : string = "v17.transaction(&[\"store\"], rexie::TransactionMode::ReadWrite)?"
    let v20 : rexie_Transaction = Fable.Core.RustInterop.emitRustExpr () v19
    let v21 : string = "v20.store(\"store\")?"
    let v22 : rexie_Store = Fable.Core.RustInterop.emitRustExpr () v21
    let v23 : string = "dark-mode"
    let v24 : string = "r#\"" + v23 + "\"#"
    let v25 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v24
    let v26 : string = "serde_json::json!({ v25: v1 }).to_string()"
    let v27 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v26
    let v28 : string = "let mut data = Vec::new()"
    Fable.Core.RustInterop.emitRustExpr () v28
    let v29 : string = "borsh::BorshSerialize::serialize(&v27, &mut data).unwrap()"
    Fable.Core.RustInterop.emitRustExpr () v29
    let v30 : string = "data"
    let v31 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v30
    let v32 : string = "serde_wasm_bindgen::to_value(&v31).unwrap()"
    let v33 : wasm_bindgen_JsValue = Fable.Core.RustInterop.emitRustExpr () v32
    let v34 : string = "v22.put(&v33, Some(&\"data\".into())).await?"
    Fable.Core.RustInterop.emitRustExpr () v34
    let v35 : string = "v20.done().await?"
    Fable.Core.RustInterop.emitRustExpr () v35
    let v36 : Result<unit, rexie_Error> = Ok ()
    let v37 : Result<unit, rexie_Error> = method25(v36)
    let v38 : string = "v37 }}}})"
    Fable.Core.RustInterop.emitRustExpr () v38
    let v39 : string = "__future_init"
    let v40 : std_pin_Pin<Box<Dyn<Future<Result<unit, rexie_Error>>>>> = Fable.Core.RustInterop.emitRustExpr () v39
    let v41 : string = "v40.await"
    let v42 : Result<unit, rexie_Error> = Fable.Core.RustInterop.emitRustExpr () v41
    let v43 : string = "v42.unwrap()"
    Fable.Core.RustInterop.emitRustExpr () v43
    method26()
    let v44 : string = "() }}}})"
    Fable.Core.RustInterop.emitRustExpr () v44
    let v45 : string = "{ { { { { { // "
    Fable.Core.RustInterop.emitRustExpr () v45
    let v46 : string = "__future_init"
    let v47 : std_pin_Pin<Box<Dyn<Future<unit>>>> = Fable.Core.RustInterop.emitRustExpr () v46
    v47
and method23 (v0 : leptos_Resource<US0, rexie_Rexie>) : (bool -> std_pin_Pin<Box<Dyn<Future<unit>>>>) =
    closure15(v0)
and closure17 () (v0 : bool) : bool =
    let v1 : bool = v0 = false
    v1
and method28 () : (bool -> bool) =
    closure17()
and method29 (v0 : leptos_RwSignal<bool>) : leptos_RwSignal<bool> =
    v0
and closure16 (v0 : Heap0) (v1 : leptos_ev_MouseEvent) : unit =
    let v2 : leptos_RwSignal<leptos_RwSignal<bool>> = v0.l0
    let v3 : leptos_RwSignal<leptos_RwSignal<bool>> = method3(v2)
    let v4 : string = $"leptos::SignalGet::get(&v3)"
    let v5 : leptos_RwSignal<bool> = Fable.Core.RustInterop.emitRustExpr () v4
    let v6 : (bool -> bool) = method28()
    let v7 : leptos_RwSignal<bool> = method29(v5)
    let v8 : string = $"leptos::SignalUpdate::update(&v7, |x| *x = v6(*x))"
    Fable.Core.RustInterop.emitRustExpr () v8
    ()
and method27 (v0 : Heap0) : (leptos_ev_MouseEvent -> unit) =
    closure16(v0)
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
    let v46 : (unit -> unit) = method15(v37, v45)
    let v47 : string = "leptos::create_effect(move |_| { v46() })"
    Fable.Core.RustInterop.emitRustExpr () v47
    let v48 : (bool -> std_pin_Pin<Box<Dyn<Future<unit>>>>) = method23(v41)
    let v49 : string = "leptos::create_action(move |value: &bool| v48(*value))"
    let v50 : leptos_Action<bool, unit> = Fable.Core.RustInterop.emitRustExpr () v49
    let v51 : (leptos_ev_MouseEvent -> unit) = method27(v37)
    let v52 : string = $"<button class=\"fixed bottom-4 right-4 bg-gray-500 text-white p-2 rounded-full\" on:click=move |mouse_event| v51(mouse_event)>{{(|| {{ leptos::logging::log!(\"button () / render\"); leptos::view! {{<></>}} }})()}}{{\"🌓︎\"}}</button>"
    let v53 : string = "leptos::view! { " + v52 + " }"
    let v54 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v53
    let v55 : leptos_HtmlElement<leptos_html_Button> = v54 |> unbox
    let v56 : string = "<div class=\"flex flex-1\" class:dark={move || v33()}>{v55}{v32}</div>"
    let v57 : string = "leptos::view! { " + v56 + " }"
    let v58 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v57
    let v59 : leptos_HtmlElement<leptos_html_Div> = v58 |> unbox
    let v60 : string = "leptos::IntoView::into_view(v59)"
    let v61 : leptos_View = Fable.Core.RustInterop.emitRustExpr () v60
    let v62 : Impl<leptos_IntoView> = v61 |> unbox
    v62
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
