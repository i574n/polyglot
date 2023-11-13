[<Fable.Core.Erase; Fable.Core.Emit("leptos::ev::MouseEvent")>] type leptos_ev_MouseEvent = class end
[<Fable.Core.Erase; Fable.Core.Emit("leptos::html::Button")>] type leptos_html_Button = class end
[<Fable.Core.Erase; Fable.Core.Emit("leptos::html::Div")>] type leptos_html_Div = class end
[<Fable.Core.Erase; Fable.Core.Emit("leptos::html::Input")>] type leptos_html_Input = class end
[<Fable.Core.Erase; Fable.Core.Emit("leptos::Action<$0, $1>")>] type leptos_Action<'T, 'U> = class end
[<Fable.Core.Erase; Fable.Core.Emit("leptos::Fragment")>] type leptos_Fragment = class end
[<Fable.Core.Erase; Fable.Core.Emit("leptos::HtmlElement<$0>")>] type leptos_HtmlElement<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("leptos::IntoView")>] type leptos_IntoView = class end
[<Fable.Core.Erase; Fable.Core.Emit("leptos::RwSignal<$0>")>] type leptos_RwSignal<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("leptos::ReadSignal<$0>")>] type leptos_ReadSignal<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("leptos::WriteSignal<$0>")>] type leptos_WriteSignal<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("leptos::Memo<$0>")>] type leptos_Memo<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("leptos::Resource<$0, $1>")>] type leptos_Resource<'T, 'U> = class end
[<Fable.Core.Erase; Fable.Core.Emit("leptos::View")>] type leptos_View = class end
[<Fable.Core.Erase; Fable.Core.Emit("rexie::Error")>] type rexie_Error = class end
[<Fable.Core.Erase; Fable.Core.Emit("rexie::Rexie")>] type rexie_Rexie = class end
[<Fable.Core.Erase; Fable.Core.Emit("rexie::Store")>] type rexie_Store = class end
[<Fable.Core.Erase; Fable.Core.Emit("rexie::Transaction")>] type rexie_Transaction = class end
[<Fable.Core.Erase; Fable.Core.Emit("serde_json::Value")>] type serde_json_Value = class end
[<Fable.Core.Erase; Fable.Core.Emit("serde_json::Error")>] type serde_json_Error = class end
[<Fable.Core.Erase; Fable.Core.Emit("wasm_bindgen::JsValue")>] type wasm_bindgen_JsValue = class end
[<Fable.Core.Erase; Fable.Core.Emit("wasm_bindgen::closure::Closure<$0>")>] type wasm_bindgen_closure_Closure<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("std::collections::HashMap<$0, $1>")>] type std_collections_HashMap<'K, 'V> = class end
[<Fable.Core.Erase; Fable.Core.Emit("std::rc::Rc<$0>")>] type std_rc_Rc<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("Box<$0>")>] type Box<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("std::pin::Pin<$0>")>] type std_pin_Pin<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("std::sync::Arc<$0>")>] type std_sync_Arc<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("std::string::String")>] type std_string_String = class end
[<Fable.Core.Erase; Fable.Core.Emit("js_sys::Function")>] type js_sys_Function = class end
[<Fable.Core.Erase; Fable.Core.Emit("web_sys::Window")>] type web_sys_Window = class end
[<Fable.Core.Erase; Fable.Core.Emit("web_sys::Document")>] type web_sys_Document = class end
[<Fable.Core.Erase; Fable.Core.Emit("web_sys::Storage")>] type web_sys_Storage = class end
[<Fable.Core.Erase; Fable.Core.Emit("web_sys::HtmlElement")>] type web_sys_HtmlElement = class end
[<Fable.Core.Erase; Fable.Core.Emit("dyn $0")>] type Dyn<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("Fn() -> $0")>] type Fn<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("FnOnce() -> $0")>] type FnOnce<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("Fn()")>] type FnUnit = class end
[<Fable.Core.Erase; Fable.Core.Emit("std::future::Future<Output = $0>")>] type Future<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("impl $0")>] type Impl<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("&$0")>] type Ref<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("str")>] type Str = class end
[<Fable.Core.Erase; Fable.Core.Emit("Vec<$0>")>] type Vec<'T> = class end
type [<Struct>] US0 =
    | US0_0
    | US0_1 of f1_0 : web_sys_HtmlElement
and Heap0 = {l0 : leptos_RwSignal<std_collections_HashMap<string, leptos_RwSignal<bool>>>; l1 : leptos_RwSignal<leptos_RwSignal<bool>>}
and [<Struct>] US1 =
    | US1_0
    | US1_1
and [<Struct>] US2 =
    | US2_0 of f0_0 : rexie_Error
    | US2_1 of f1_0 : rexie_Rexie
and [<Struct>] US3 =
    | US3_0
    | US3_1 of f1_0 : bool
and [<Struct>] US4 =
    | US4_0
    | US4_1 of f1_0 : rexie_Rexie
and [<Struct>] US5 =
    | US5_0
    | US5_1 of f1_0 : serde_json_Value
and [<Struct>] US6 =
    | US6_0 of f0_0 : rexie_Error
    | US6_1 of f1_0 : US3
and [<Struct>] US7 =
    | US7_0 of f0_0 : wasm_bindgen_JsValue
    | US7_1 of f1_0 : web_sys_Storage option
and [<Struct>] US9 =
    | US9_0
    | US9_1 of f1_0 : web_sys_Storage
and [<Struct>] US8 =
    | US8_0 of f0_0 : wasm_bindgen_JsValue
    | US8_1 of f1_0 : US9
and [<Struct>] US10 =
    | US10_0
    | US10_1 of f1_0 : US3
and [<Struct>] US11 =
    | US11_0
    | US11_1 of f1_0 : std_string_String option
and [<Struct>] US13 =
    | US13_0
    | US13_1 of f1_0 : std_string_String
and [<Struct>] US12 =
    | US12_0
    | US12_1 of f1_0 : US13
and [<Struct>] US14 =
    | US14_0
    | US14_1 of f1_0 : leptos_RwSignal<bool>
let rec closure1 () (v0 : web_sys_HtmlElement) : US0 =
    US0_1(v0)
and method1 (v0 : string) : string =
    v0
and method2 () : string =
    let v0 : string = "explorer-backend-mainnet-prod-24ktefolwq-uc.a.run.app"
    v0
and method4 (v0 : leptos_RwSignal<leptos_RwSignal<bool>>) : leptos_RwSignal<leptos_RwSignal<bool>> =
    v0
and method5 (v0 : leptos_RwSignal<bool>) : leptos_RwSignal<bool> =
    v0
and closure3 (v0 : Heap0) () : bool =
    let v1 : leptos_RwSignal<leptos_RwSignal<bool>> = v0.l1
    let v2 : leptos_RwSignal<leptos_RwSignal<bool>> = method4(v1)
    let v3 : string = $"leptos::SignalGet::get(&v2)"
    let v4 : leptos_RwSignal<bool> = Fable.Core.RustInterop.emitRustExpr () v3
    let v5 : leptos_RwSignal<bool> = method5(v4)
    let v6 : string = $"leptos::SignalGet::get(&v5)"
    let v7 : bool = Fable.Core.RustInterop.emitRustExpr () v6
    v7
and method3 (v0 : Heap0) : (unit -> bool) =
    closure3(v0)
and closure4 () () : US1 =
    US1_0
and method6 () : (unit -> US1) =
    closure4()
and method7 (v0 : rexie_Rexie) : US2 =
    US2_1(v0)
and method8 (v0 : rexie_Rexie) : rexie_Rexie =
    v0
and closure5 () (v0 : US1) : std_pin_Pin<Box<Dyn<Future<rexie_Rexie>>>> =
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
    let v13 : US2 = method7(v12)
    let v14 : string = "v13 }})"
    Fable.Core.RustInterop.emitRustExpr () v14
    let v15 : string = "__future_init"
    let v16 : std_pin_Pin<Box<Dyn<Future<US2>>>> = Fable.Core.RustInterop.emitRustExpr () v15
    let v17 : string = "v16.await"
    let v18 : US2 = Fable.Core.RustInterop.emitRustExpr () v17
    let v24 : rexie_Rexie =
        match v18 with
        | US2_0(v20) -> (* Error *)
            let v21 : string = $"Result value was Error: {v20}"
            failwith<rexie_Rexie> v21
        | US2_1(v19) -> (* Ok *)
            v19
    let v25 : rexie_Rexie = method8(v24)
    let v26 : string = "v25 }})"
    Fable.Core.RustInterop.emitRustExpr () v26
    let v27 : string = "{ { // "
    Fable.Core.RustInterop.emitRustExpr () v27
    let v28 : string = "__future_init"
    let v29 : std_pin_Pin<Box<Dyn<Future<rexie_Rexie>>>> = Fable.Core.RustInterop.emitRustExpr () v28
    v29
and method10 (v0 : leptos_Resource<US1, rexie_Rexie>) : leptos_Resource<US1, rexie_Rexie> =
    v0
and closure6 (v0 : leptos_Resource<US1, rexie_Rexie>) () : rexie_Rexie option =
    let v1 : leptos_Resource<US1, rexie_Rexie> = method10(v0)
    let v2 : string = $"leptos::SignalGet::get(&v1)"
    let v3 : rexie_Rexie option = Fable.Core.RustInterop.emitRustExpr () v2
    v3
and method9 (v0 : leptos_Resource<US1, rexie_Rexie>) : (unit -> rexie_Rexie option) =
    closure6(v0)
and closure8 () (v0 : rexie_Rexie) : US4 =
    US4_1(v0)
and method11 (v0 : rexie_Rexie) : rexie_Rexie =
    v0
and closure9 () (v0 : serde_json_Value) : US5 =
    US5_1(v0)
and method12 (v0 : serde_json_Value) : serde_json_Value =
    v0
and method13 (v0 : Vec<uint8>) : Vec<uint8> =
    v0
and method14 (v0 : std_string_String) : std_string_String =
    v0
and closure10 () (v0 : bool) : US3 =
    US3_1(v0)
and method15 (v0 : Result<US3, rexie_Error>) : Result<US3, rexie_Error> =
    v0
and method16 (v0 : US3) : US3 =
    v0
and closure7 () (v0 : rexie_Rexie option) : std_pin_Pin<Box<Dyn<Future<US3>>>> =
    let v1 : string = "let __future_init = Box::pin(async { //"
    Fable.Core.RustInterop.emitRustExpr () v1
    let v2 : string = @$"format!(""{{:?}}"", $0)"
    let v3 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v2
    let v4 : string = "ui.dark_mode_button () / dark_mode create_local_resource / database: " + string v3 + ""
    let v5 : string = @$"leptos::logging::log!(""{{}}"", $0)"
    Fable.Core.RustInterop.emitRustExpr v4 v5
    let v6 : (rexie_Rexie -> US4) = closure8()
    let v7 : US4 = US4_0
    let v8 : US4 = v0 |> Option.map v6 |> Option.defaultValue v7
    let v95 : US3 =
        match v8 with
        | US4_0 -> (* None *)
            US3_0
        | US4_1(v9) -> (* Some *)
            let v10 : string = "ui.get_dark_mode ()"
            let v11 : string = @$"leptos::logging::log!(""{{}}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v10 v11
            let v12 : rexie_Rexie = method11(v9)
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
            let v31 : (serde_json_Value -> US5) = closure9()
            let v32 : US5 = US5_0
            let v33 : US5 = v30 |> Option.map v31 |> Option.defaultValue v32
            let v77 : US6 =
                match v33 with
                | US5_0 -> (* None *)
                    let v74 : US3 = US3_0
                    US6_1(v74)
                | US5_1(v34) -> (* Some *)
                    let v35 : serde_json_Value = method12(v34)
                    let v36 : string = "serde_json::from_value(v35).unwrap()"
                    let v37 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v36
                    let v38 : string = @$"format!(""{{:?}}"", $0)"
                    let v39 : std_string_String = Fable.Core.RustInterop.emitRustExpr v37 v38
                    let v40 : string = "ui.get_dark_mode () / data: " + string v39 + ""
                    let v41 : string = @$"leptos::logging::log!(""{{}}"", $0)"
                    Fable.Core.RustInterop.emitRustExpr v40 v41
                    let v42 : Vec<uint8> = method13(v37)
                    let v43 : string = "borsh::BorshDeserialize::deserialize(&mut v42.as_slice()).unwrap()"
                    let v44 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v43
                    let v45 : string = "ui.get_dark_mode () / json: " + string v44 + ""
                    let v46 : string = @$"leptos::logging::log!(""{{}}"", $0)"
                    Fable.Core.RustInterop.emitRustExpr v45 v46
                    let v47 : std_string_String = method14(v44)
                    let v48 : string = "fable_library_rust::String_::fromString(v47)"
                    let v49 : string = Fable.Core.RustInterop.emitRustExpr () v48
                    let v50 : string = method1(v49)
                    let v51 : string = $"fable_library_rust::String_::LrcStr::as_str(&v50)"
                    let v52 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v51
                    let v53 : string = $"String::from(v52)"
                    let v54 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v53
                    let v55 : string = "serde_json::from_str(&v54)"
                    let v56 : Result<serde_json_Value, serde_json_Error> = Fable.Core.RustInterop.emitRustExpr () v55
                    let v57 : string = "v56.ok()"
                    let v58 : serde_json_Value option = Fable.Core.RustInterop.emitRustExpr () v57
                    let v59 : US5 = US5_0
                    let v60 : US5 = v58 |> Option.map v31 |> Option.defaultValue v59
                    let v64 : serde_json_Value =
                        match v60 with
                        | US5_0 -> (* None *)
                            failwith<serde_json_Value> "Option does not have a value."
                        | US5_1(v61) -> (* Some *)
                            v61
                    let v65 : string = "dark-mode"
                    let v66 : string = "r#\"" + v65 + "\"#"
                    let v67 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v66
                    let v68 : string = "v64[v67].as_bool()"
                    let v69 : bool option = Fable.Core.RustInterop.emitRustExpr () v68
                    let v70 : (bool -> US3) = closure10()
                    let v71 : US3 = US3_0
                    let v72 : US3 = v69 |> Option.map v70 |> Option.defaultValue v71
                    US6_1(v72)
            let v83 : Result<US3, rexie_Error> =
                match v77 with
                | US6_0(v80) -> (* Error *)
                    let v81 : Result<US3, rexie_Error> = Error v80
                    v81
                | US6_1(v78) -> (* Ok *)
                    let v79 : Result<US3, rexie_Error> = Ok v78
                    v79
            let v84 : Result<US3, rexie_Error> = method15(v83)
            let v85 : string = "v84 }})"
            Fable.Core.RustInterop.emitRustExpr () v85
            let v86 : string = "{ // "
            Fable.Core.RustInterop.emitRustExpr () v86
            let v87 : string = "__future_init"
            let v88 : std_pin_Pin<Box<Dyn<Future<Result<US3, rexie_Error>>>>> = Fable.Core.RustInterop.emitRustExpr () v87
            let v89 : string = "v88.await"
            let v90 : Result<US3, rexie_Error> = Fable.Core.RustInterop.emitRustExpr () v89
            let v91 : string = "v90.unwrap()"
            let v92 : US3 = Fable.Core.RustInterop.emitRustExpr () v91
            v92
    let v96 : US3 = method16(v95)
    let v97 : string = "v96 }}})"
    Fable.Core.RustInterop.emitRustExpr () v97
    let v98 : string = "{ { // "
    Fable.Core.RustInterop.emitRustExpr () v98
    let v99 : string = "__future_init"
    let v100 : std_pin_Pin<Box<Dyn<Future<US3>>>> = Fable.Core.RustInterop.emitRustExpr () v99
    v100
and method18 () : web_sys_Window =
    let v0 : string = "leptos::leptos_dom::window()"
    let v1 : web_sys_Window = Fable.Core.RustInterop.emitRustExpr () v0
    v1
and method20 (v0 : web_sys_Window) : web_sys_Window =
    v0
and method19 (v0 : web_sys_Window) : Result<web_sys_Storage option, wasm_bindgen_JsValue> =
    let v1 : web_sys_Window = method20(v0)
    let v2 : string = "v1.local_storage()"
    let v3 : Result<web_sys_Storage option, wasm_bindgen_JsValue> = Fable.Core.RustInterop.emitRustExpr () v2
    v3
and closure12 () (v0 : web_sys_Storage option) : US7 =
    US7_1(v0)
and closure13 () (v0 : wasm_bindgen_JsValue) : US7 =
    US7_0(v0)
and closure14 () (v0 : web_sys_Storage) : US9 =
    US9_1(v0)
and method21 (v0 : leptos_Resource<rexie_Rexie option, US3>) : leptos_Resource<rexie_Rexie option, US3> =
    v0
and closure15 () (v0 : US3) : US10 =
    US10_1(v0)
and method22 (v0 : web_sys_Storage) : web_sys_Storage =
    v0
and method23 () : string =
    let v0 : string = "dark-mode"
    v0
and closure16 () (v0 : std_string_String option) : US11 =
    US11_1(v0)
and closure17 () (v0 : std_string_String) : US13 =
    US13_1(v0)
and method24 (v0 : std_string_String) : std_string_String =
    v0
and method25 (v0 : leptos_RwSignal<leptos_RwSignal<bool>>) : leptos_RwSignal<leptos_RwSignal<bool>> =
    v0
and method26 (v0 : bool) : bool =
    v0
and method27 (v0 : leptos_RwSignal<bool>) : leptos_RwSignal<bool> =
    v0
and closure11 (v0 : Heap0, v1 : leptos_Resource<rexie_Rexie option, US3>) () : unit =
    let v2 : string = "ui.dark_mode_button () / create_effect 1 / ##1"
    let v3 : string = @$"leptos::logging::log!(""{{}}"", $0)"
    Fable.Core.RustInterop.emitRustExpr v2 v3
    let v4 : web_sys_Window = method18()
    let v5 : Result<web_sys_Storage option, wasm_bindgen_JsValue> = method19(v4)
    let v6 : (web_sys_Storage option -> US7) = closure12()
    let v7 : (wasm_bindgen_JsValue -> US7) = closure13()
    let v8 : US7 = match v5 with Ok x -> v6 x | Error x -> v7 x
    let v17 : US8 =
        match v8 with
        | US7_0(v14) -> (* Error *)
            US8_0(v14)
        | US7_1(v9) -> (* Ok *)
            let v10 : (web_sys_Storage -> US9) = closure14()
            let v11 : US9 = US9_0
            let v12 : US9 = v9 |> Option.map v10 |> Option.defaultValue v11
            US8_1(v12)
    match v17 with
    | US8_1(v18) -> (* Ok *)
        match v18 with
        | US9_1(v19) -> (* Some *)
            let v20 : leptos_Resource<rexie_Rexie option, US3> = method21(v1)
            let v21 : string = $"leptos::SignalGet::get(&v20)"
            let v22 : US3 option = Fable.Core.RustInterop.emitRustExpr () v21
            let v23 : (US3 -> US10) = closure15()
            let v24 : US10 = US10_0
            let v25 : US10 = v22 |> Option.map v23 |> Option.defaultValue v24
            let v26 : string = @$"format!(""{{:?}}"", $0)"
            let v27 : std_string_String = Fable.Core.RustInterop.emitRustExpr v25 v26
            let v28 : string = "ui.dark_mode_button () / dark_mode effect 0 / ##1.1 / dark_mode1: " + string v27 + ""
            let v29 : string = @$"leptos::logging::log!(""{{}}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v28 v29
            let v142 : US3 =
                match v25 with
                | US10_1(v30) -> (* Some *)
                    match v30 with
                    | US3_1(v31) -> (* Some *)
                        US3_1(v31)
                    | _ ->
                        let v33 : web_sys_Storage = method22(v19)
                        let v34 : string = method23()
                        let v35 : string = $"fable_library_rust::String_::LrcStr::as_str(&v34)"
                        let v36 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v35
                        let v37 : string = $"web_sys::Storage::get_item(&v33, v36)"
                        let v38 : Result<std_string_String option, wasm_bindgen_JsValue> = Fable.Core.RustInterop.emitRustExpr () v37
                        let v39 : string = "v38.ok()"
                        let v40 : std_string_String option option = Fable.Core.RustInterop.emitRustExpr () v39
                        let v41 : (std_string_String option -> US11) = closure16()
                        let v42 : US11 = US11_0
                        let v43 : US11 = v40 |> Option.map v41 |> Option.defaultValue v42
                        let v51 : US12 =
                            match v43 with
                            | US11_0 -> (* None *)
                                US12_0
                            | US11_1(v44) -> (* Some *)
                                let v45 : (std_string_String -> US13) = closure17()
                                let v46 : US13 = US13_0
                                let v47 : US13 = v44 |> Option.map v45 |> Option.defaultValue v46
                                US12_1(v47)
                        let v58 : US13 =
                            match v51 with
                            | US12_1(v52) -> (* Some *)
                                match v52 with
                                | US13_1(v53) -> (* Some *)
                                    US13_1(v53)
                                | _ ->
                                    US13_0
                            | _ ->
                                US13_0
                        let v79 : US10 =
                            match v58 with
                            | US13_0 -> (* None *)
                                US10_0
                            | US13_1(v59) -> (* Some *)
                                let v60 : std_string_String = method24(v59)
                                let v61 : std_string_String = method14(v60)
                                let v62 : string = "fable_library_rust::String_::fromString(v61)"
                                let v63 : string = Fable.Core.RustInterop.emitRustExpr () v62
                                let v64 : string = method1(v63)
                                let v65 : string = $"fable_library_rust::String_::LrcStr::as_str(&v64)"
                                let v66 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v65
                                let v67 : string = $"String::from(v66)"
                                let v68 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v67
                                let v69 : string = "serde_json::from_str(&v68)"
                                let v70 : Result<bool, serde_json_Error> = Fable.Core.RustInterop.emitRustExpr () v69
                                let v71 : string = "v70.ok()"
                                let v72 : bool option = Fable.Core.RustInterop.emitRustExpr () v71
                                let v73 : (bool -> US3) = closure10()
                                let v74 : US3 = US3_0
                                let v75 : US3 = v72 |> Option.map v73 |> Option.defaultValue v74
                                US10_1(v75)
                        match v79 with
                        | US10_1(v80) -> (* Some *)
                            match v80 with
                            | US3_1(v81) -> (* Some *)
                                US3_1(v81)
                            | _ ->
                                US3_0
                        | _ ->
                            US3_0
                | _ ->
                    let v88 : web_sys_Storage = method22(v19)
                    let v89 : string = method23()
                    let v90 : string = $"fable_library_rust::String_::LrcStr::as_str(&v89)"
                    let v91 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v90
                    let v92 : string = $"web_sys::Storage::get_item(&v88, v91)"
                    let v93 : Result<std_string_String option, wasm_bindgen_JsValue> = Fable.Core.RustInterop.emitRustExpr () v92
                    let v94 : string = "v93.ok()"
                    let v95 : std_string_String option option = Fable.Core.RustInterop.emitRustExpr () v94
                    let v96 : (std_string_String option -> US11) = closure16()
                    let v97 : US11 = US11_0
                    let v98 : US11 = v95 |> Option.map v96 |> Option.defaultValue v97
                    let v106 : US12 =
                        match v98 with
                        | US11_0 -> (* None *)
                            US12_0
                        | US11_1(v99) -> (* Some *)
                            let v100 : (std_string_String -> US13) = closure17()
                            let v101 : US13 = US13_0
                            let v102 : US13 = v99 |> Option.map v100 |> Option.defaultValue v101
                            US12_1(v102)
                    let v113 : US13 =
                        match v106 with
                        | US12_1(v107) -> (* Some *)
                            match v107 with
                            | US13_1(v108) -> (* Some *)
                                US13_1(v108)
                            | _ ->
                                US13_0
                        | _ ->
                            US13_0
                    let v134 : US10 =
                        match v113 with
                        | US13_0 -> (* None *)
                            US10_0
                        | US13_1(v114) -> (* Some *)
                            let v115 : std_string_String = method24(v114)
                            let v116 : std_string_String = method14(v115)
                            let v117 : string = "fable_library_rust::String_::fromString(v116)"
                            let v118 : string = Fable.Core.RustInterop.emitRustExpr () v117
                            let v119 : string = method1(v118)
                            let v120 : string = $"fable_library_rust::String_::LrcStr::as_str(&v119)"
                            let v121 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v120
                            let v122 : string = $"String::from(v121)"
                            let v123 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v122
                            let v124 : string = "serde_json::from_str(&v123)"
                            let v125 : Result<bool, serde_json_Error> = Fable.Core.RustInterop.emitRustExpr () v124
                            let v126 : string = "v125.ok()"
                            let v127 : bool option = Fable.Core.RustInterop.emitRustExpr () v126
                            let v128 : (bool -> US3) = closure10()
                            let v129 : US3 = US3_0
                            let v130 : US3 = v127 |> Option.map v128 |> Option.defaultValue v129
                            US10_1(v130)
                    match v134 with
                    | US10_1(v135) -> (* Some *)
                        match v135 with
                        | US3_1(v136) -> (* Some *)
                            US3_1(v136)
                        | _ ->
                            US3_0
                    | _ ->
                        US3_0
            let v143 : string = @$"format!(""{{:?}}"", $0)"
            let v144 : std_string_String = Fable.Core.RustInterop.emitRustExpr v142 v143
            let v145 : string = "ui.dark_mode_button () / dark_mode effect 0 / ##1.1 / dark_mode2: " + string v144 + ""
            let v146 : string = @$"leptos::logging::log!(""{{}}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v145 v146
            match v142 with
            | US3_1(v147) -> (* Some *)
                let v148 : leptos_RwSignal<leptos_RwSignal<bool>> = v0.l1
                let v149 : leptos_RwSignal<leptos_RwSignal<bool>> = method25(v148)
                let v150 : string = $"leptos::SignalGetUntracked::get_untracked(&v149)"
                let v151 : leptos_RwSignal<bool> = Fable.Core.RustInterop.emitRustExpr () v150
                let v152 : bool = method26(v147)
                let v153 : leptos_RwSignal<bool> = method27(v151)
                let v154 : string = $"leptos::SignalSet::set(&v153, v152)"
                Fable.Core.RustInterop.emitRustExpr () v154
                ()
            | _ ->
                ()
        | _ ->
            ()
    | _ ->
        ()
and method17 (v0 : Heap0, v1 : leptos_Resource<rexie_Rexie option, US3>) : (unit -> unit) =
    closure11(v0, v1)
and method29 (v0 : rexie_Rexie) : rexie_Rexie =
    v0
and method30 (v0 : Result<unit, rexie_Error>) : Result<unit, rexie_Error> =
    v0
and method31 () : unit =
    ()
and closure18 (v0 : leptos_Resource<US1, rexie_Rexie>) (v1 : bool) : std_pin_Pin<Box<Dyn<Future<unit>>>> =
    let v2 : string = "ui.dark_mode_button () / set_dark_mode_action / value: " + string v1 + ""
    let v3 : string = @$"leptos::logging::log!(""{{}}"", $0)"
    Fable.Core.RustInterop.emitRustExpr v2 v3
    let v4 : leptos_Resource<US1, rexie_Rexie> = method10(v0)
    let v5 : string = $"leptos::SignalGet::get(&v4)"
    let v6 : rexie_Rexie option = Fable.Core.RustInterop.emitRustExpr () v5
    let v7 : (rexie_Rexie -> US4) = closure8()
    let v8 : US4 = US4_0
    let v9 : US4 = v6 |> Option.map v7 |> Option.defaultValue v8
    let v13 : rexie_Rexie =
        match v9 with
        | US4_0 -> (* None *)
            failwith<rexie_Rexie> "Option does not have a value."
        | US4_1(v10) -> (* Some *)
            v10
    let v14 : string = "let __future_init = Box::pin(async move { //"
    Fable.Core.RustInterop.emitRustExpr () v14
    let v15 : string = "ui.set_dark_mode () / mode: " + string v1 + ""
    let v16 : string = @$"leptos::logging::log!(""{{}}"", $0)"
    Fable.Core.RustInterop.emitRustExpr v15 v16
    let v17 : rexie_Rexie = method29(v13)
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
    let v37 : Result<unit, rexie_Error> = method30(v36)
    let v38 : string = "v37 }}}})"
    Fable.Core.RustInterop.emitRustExpr () v38
    let v39 : string = "__future_init"
    let v40 : std_pin_Pin<Box<Dyn<Future<Result<unit, rexie_Error>>>>> = Fable.Core.RustInterop.emitRustExpr () v39
    let v41 : string = "v40.await"
    let v42 : Result<unit, rexie_Error> = Fable.Core.RustInterop.emitRustExpr () v41
    let v43 : string = "v42.unwrap()"
    Fable.Core.RustInterop.emitRustExpr () v43
    method31()
    let v44 : string = "() }}}})"
    Fable.Core.RustInterop.emitRustExpr () v44
    let v45 : string = "{ { { { { { // "
    Fable.Core.RustInterop.emitRustExpr () v45
    let v46 : string = "__future_init"
    let v47 : std_pin_Pin<Box<Dyn<Future<unit>>>> = Fable.Core.RustInterop.emitRustExpr () v46
    v47
and method28 (v0 : leptos_Resource<US1, rexie_Rexie>) : (bool -> std_pin_Pin<Box<Dyn<Future<unit>>>>) =
    closure18(v0)
and method33 (v0 : leptos_RwSignal<std_collections_HashMap<string, leptos_RwSignal<bool>>>) : leptos_RwSignal<std_collections_HashMap<string, leptos_RwSignal<bool>>> =
    v0
and closure19 (v0 : Heap0) () : std_collections_HashMap<string, leptos_RwSignal<bool>> =
    let v1 : string = "ui.dark_mode_button () / loading create_memo"
    let v2 : string = @$"leptos::logging::log!(""{{}}"", $0)"
    Fable.Core.RustInterop.emitRustExpr v1 v2
    let v3 : leptos_RwSignal<std_collections_HashMap<string, leptos_RwSignal<bool>>> = v0.l0
    let v4 : leptos_RwSignal<std_collections_HashMap<string, leptos_RwSignal<bool>>> = method33(v3)
    let v5 : string = $"leptos::SignalGetUntracked::get_untracked(&v4)"
    let v6 : std_collections_HashMap<string, leptos_RwSignal<bool>> = Fable.Core.RustInterop.emitRustExpr () v5
    v6
and method32 (v0 : Heap0) : (unit -> std_collections_HashMap<string, leptos_RwSignal<bool>>) =
    closure19(v0)
and method35 (v0 : leptos_ReadSignal<bool>) : leptos_ReadSignal<bool> =
    v0
and method36 () : string =
    let v0 : string = "dark-mode"
    v0
and closure21 () (v0 : leptos_RwSignal<bool>) : US14 =
    US14_1(v0)
and method37 () : bool =
    true
and method38 (v0 : leptos_WriteSignal<bool>) : leptos_WriteSignal<bool> =
    v0
and method39 (v0 : bool) : bool =
    v0
and method40 (v0 : web_sys_Storage) : web_sys_Storage =
    v0
and closure20 (v0 : Heap0, v1 : leptos_Action<bool, unit>, v2 : leptos_Memo<std_collections_HashMap<string, leptos_RwSignal<bool>>>, v3 : leptos_WriteSignal<bool>, v4 : leptos_ReadSignal<bool>) () : unit =
    let v5 : leptos_ReadSignal<bool> = method35(v4)
    let v6 : string = $"leptos::SignalGet::get(&v5)"
    let v7 : bool = Fable.Core.RustInterop.emitRustExpr () v6
    let v8 : string = "ui.dark_mode_button () / create_effect 2 / ##1 / loaded: " + string v7 + ""
    let v9 : string = @$"leptos::logging::log!(""{{}}"", $0)"
    Fable.Core.RustInterop.emitRustExpr v8 v9
    let v10 : leptos_RwSignal<leptos_RwSignal<bool>> = v0.l1
    let v11 : leptos_RwSignal<leptos_RwSignal<bool>> = method25(v10)
    let v12 : string = $"leptos::SignalGetUntracked::get_untracked(&v11)"
    let v13 : leptos_RwSignal<bool> = Fable.Core.RustInterop.emitRustExpr () v12
    let v14 : leptos_RwSignal<bool> = method5(v13)
    let v15 : string = $"leptos::SignalGet::get(&v14)"
    let v16 : bool = Fable.Core.RustInterop.emitRustExpr () v15
    let v17 : string = "ui.dark_mode_button () / create_effect 2 / ##2 / dark_mode: " + string v16 + ""
    let v18 : string = @$"leptos::logging::log!(""{{}}"", $0)"
    Fable.Core.RustInterop.emitRustExpr v17 v18
    let v19 : string = $"v2()"
    let v20 : std_collections_HashMap<string, leptos_RwSignal<bool>> = Fable.Core.RustInterop.emitRustExpr () v19
    let v21 : string = method36()
    let v22 : string = "std::collections::HashMap::get(&v20, &v21).map(|x| *x)"
    let v23 : leptos_RwSignal<bool> option = Fable.Core.RustInterop.emitRustExpr () v22
    let v24 : (leptos_RwSignal<bool> -> US14) = closure21()
    let v25 : US14 = US14_0
    let v26 : US14 = v23 |> Option.map v24 |> Option.defaultValue v25
    let v34 : US3 =
        match v26 with
        | US14_0 -> (* None *)
            US3_0
        | US14_1(v27) -> (* Some *)
            let v28 : leptos_RwSignal<bool> = method5(v27)
            let v29 : string = $"leptos::SignalGet::get(&v28)"
            let v30 : bool = Fable.Core.RustInterop.emitRustExpr () v29
            US3_1(v30)
    let v37 : bool =
        match v34 with
        | US3_0 -> (* None *)
            false
        | US3_1(v35) -> (* Some *)
            v35
    let v38 : string = "ui.dark_mode_button () / create_effect 2 / ##3 / dark_mode_loading: " + string v37 + ""
    let v39 : string = @$"leptos::logging::log!(""{{}}"", $0)"
    Fable.Core.RustInterop.emitRustExpr v38 v39
    let v40 : bool = v37 = false
    if v40 then
        let v41 : bool = v7 = false
        if v41 then
            let v42 : bool = method37()
            let v43 : leptos_WriteSignal<bool> = method38(v3)
            let v44 : string = $"leptos::SignalSet::set(&v43, v42)"
            Fable.Core.RustInterop.emitRustExpr () v44
            ()
        else
            let v45 : string = "ui.dark_mode_button () / create_effect 2 / ##4 / dark_mode: " + string v16 + ""
            let v46 : string = @$"leptos::logging::log!(""{{}}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v45 v46
            let v47 : web_sys_Window = method18()
            let v48 : Result<web_sys_Storage option, wasm_bindgen_JsValue> = method19(v47)
            let v49 : (web_sys_Storage option -> US7) = closure12()
            let v50 : (wasm_bindgen_JsValue -> US7) = closure13()
            let v51 : US7 = match v48 with Ok x -> v49 x | Error x -> v50 x
            let v60 : US8 =
                match v51 with
                | US7_0(v57) -> (* Error *)
                    US8_0(v57)
                | US7_1(v52) -> (* Ok *)
                    let v53 : (web_sys_Storage -> US9) = closure14()
                    let v54 : US9 = US9_0
                    let v55 : US9 = v52 |> Option.map v53 |> Option.defaultValue v54
                    US8_1(v55)
            match v60 with
            | US8_1(v61) -> (* Ok *)
                match v61 with
                | US9_1(v62) -> (* Some *)
                    let v63 : bool = method39(v16)
                    let v64 : string = "leptos::Action::dispatch(&v1, v63)"
                    Fable.Core.RustInterop.emitRustExpr () v64
                    let v65 : web_sys_Storage = method40(v62)
                    let v66 : string = method23()
                    let v67 : string = $"fable_library_rust::String_::LrcStr::as_str(&v66)"
                    let v68 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v67
                    let v69 : string = @$"format!(""{{}}"", $0)"
                    let v70 : std_string_String = Fable.Core.RustInterop.emitRustExpr v16 v69
                    let v71 : std_string_String = method14(v70)
                    let v72 : string = "fable_library_rust::String_::fromString(v71)"
                    let v73 : string = Fable.Core.RustInterop.emitRustExpr () v72
                    let v74 : string = method1(v73)
                    let v75 : string = $"fable_library_rust::String_::LrcStr::as_str(&v74)"
                    let v76 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v75
                    let v77 : string = $"web_sys::Storage::set(&v65, v68, v76).unwrap()"
                    Fable.Core.RustInterop.emitRustExpr () v77
                    ()
                | _ ->
                    ()
            | _ ->
                ()
and method34 (v0 : Heap0, v1 : leptos_Action<bool, unit>, v2 : leptos_Memo<std_collections_HashMap<string, leptos_RwSignal<bool>>>, v3 : leptos_WriteSignal<bool>, v4 : leptos_ReadSignal<bool>) : (unit -> unit) =
    closure20(v0, v1, v2, v3, v4)
and closure23 () (v0 : bool) : bool =
    let v1 : bool = v0 = false
    v1
and method42 () : (bool -> bool) =
    closure23()
and method43 (v0 : leptos_RwSignal<bool>) : leptos_RwSignal<bool> =
    v0
and closure22 (v0 : Heap0) (v1 : leptos_ev_MouseEvent) : unit =
    let v2 : leptos_RwSignal<leptos_RwSignal<bool>> = v0.l1
    let v3 : leptos_RwSignal<leptos_RwSignal<bool>> = method4(v2)
    let v4 : string = $"leptos::SignalGet::get(&v3)"
    let v5 : leptos_RwSignal<bool> = Fable.Core.RustInterop.emitRustExpr () v4
    let v6 : (bool -> bool) = method42()
    let v7 : leptos_RwSignal<bool> = method43(v5)
    let v8 : string = $"leptos::SignalUpdate::update(&v7, |x| *x = v6(*x))"
    Fable.Core.RustInterop.emitRustExpr () v8
    ()
and method41 (v0 : Heap0) : (leptos_ev_MouseEvent -> unit) =
    closure22(v0)
and closure2 () () : Impl<leptos_IntoView> =
    let v0 : string = "ui.app ()"
    let v1 : string = @$"leptos::logging::log!(""{{}}"", $0)"
    Fable.Core.RustInterop.emitRustExpr v0 v1
    let v2 : string = "leptos_meta::provide_meta_context()"
    Fable.Core.RustInterop.emitRustExpr () v2
    let v3 : string = $"leptos::create_rw_signal(true)"
    let v4 : leptos_RwSignal<bool> = Fable.Core.RustInterop.emitRustExpr () v3
    let v5 : string = $"leptos::create_rw_signal(v4)"
    let v6 : leptos_RwSignal<leptos_RwSignal<bool>> = Fable.Core.RustInterop.emitRustExpr () v5
    let v7 : string = "std::collections::HashMap::new()"
    let v8 : std_collections_HashMap<string, leptos_RwSignal<bool>> = Fable.Core.RustInterop.emitRustExpr () v7
    let v9 : string = $"leptos::create_rw_signal(v8)"
    let v10 : leptos_RwSignal<std_collections_HashMap<string, leptos_RwSignal<bool>>> = Fable.Core.RustInterop.emitRustExpr () v9
    let v11 : Heap0 = {l0 = v10; l1 = v6} : Heap0
    let v12 : string = $"leptos::provide_context::<std::rc::Rc<Heap0>>(v11)"
    Fable.Core.RustInterop.emitRustExpr () v12
    let v13 : string = "ui.home ()"
    let v14 : string = @$"leptos::logging::log!(""{{}}"", $0)"
    Fable.Core.RustInterop.emitRustExpr v13 v14
    let v15 : string = "leptos::use_context::<std::rc::Rc<Heap0>>().unwrap().into()"
    let v16 : Heap0 = Fable.Core.RustInterop.emitRustExpr () v15
    let v17 : string = string 14
    let v18 : string = method1(v17)
    let v19 : string = $"fable_library_rust::String_::LrcStr::as_str(&v18)"
    let v20 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v19
    let v21 : string = method2()
    let v22 : string = $"fable_library_rust::String_::LrcStr::as_str(&v21)"
    let v23 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v22
    let v24 : string = $"String::from(v23)"
    let v25 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v24
    let v26 : string = $"leptos::create_signal(v25)"
    let struct (v27 : leptos_ReadSignal<std_string_String>, v28 : leptos_WriteSignal<std_string_String>) = Fable.Core.RustInterop.emitRustExpr () v26
    let v29 : string = $"leptos::view! {{ <input class=\"bg-gray-50 dark:bg-gray-900 flex-1 h-8\" prop:value=$0 on:keyup=move |event: web_sys::KeyboardEvent| {{ $1(leptos::event_target_value(&event)) }} /> }}"
    let v30 : leptos_HtmlElement<leptos_html_Input> = Fable.Core.RustInterop.emitRustExpr struct (v27, v28) v29
    let v31 : Impl<leptos_IntoView> = v30 |> unbox
    let v32 : leptos_HtmlElement<leptos_html_Input> = v31 |> unbox
    let v33 : string = "leptos::view! { <div class=\"bg-gray-50 dark:bg-gray-900 flex flex-1 min-h-screen min-w-full place-items-baseline text-gray-700 dark:text-gray-200 text-sm\" style=\"font-size: \".to_owned() + *$0 + \"px; place-items: baseline;\">label:{v32}</div> }"
    let v34 : leptos_HtmlElement<leptos_html_Div> = Fable.Core.RustInterop.emitRustExpr v20 v33
    let v35 : Impl<leptos_IntoView> = v34 |> unbox
    let v36 : leptos_HtmlElement<leptos_html_Div> = v35 |> unbox
    let v37 : (unit -> bool) = method3(v16)
    let v38 : string = "ui.dark_mode_button ()"
    let v39 : string = @$"leptos::logging::log!(""{{}}"", $0)"
    Fable.Core.RustInterop.emitRustExpr v38 v39
    let v40 : string = "leptos::use_context::<std::rc::Rc<Heap0>>().unwrap().into()"
    let v41 : Heap0 = Fable.Core.RustInterop.emitRustExpr () v40
    let v42 : (unit -> US1) = method6()
    let v43 : string = "leptos::create_local_resource(move || v42(), |x| async move { $0(x).await })"
    let v44 : (US1 -> std_pin_Pin<Box<Dyn<Future<rexie_Rexie>>>>) = closure5()
    let v45 : leptos_Resource<US1, rexie_Rexie> = Fable.Core.RustInterop.emitRustExpr v44 v43
    let v46 : (unit -> rexie_Rexie option) = method9(v45)
    let v47 : string = "leptos::create_local_resource(move || v46(), |x| async move { $0(x).await })"
    let v48 : (rexie_Rexie option -> std_pin_Pin<Box<Dyn<Future<US3>>>>) = closure7()
    let v49 : leptos_Resource<rexie_Rexie option, US3> = Fable.Core.RustInterop.emitRustExpr v48 v47
    let v50 : (unit -> unit) = method17(v41, v49)
    let v51 : string = "leptos::create_effect(move |_| { v50() })"
    Fable.Core.RustInterop.emitRustExpr () v51
    let v52 : (bool -> std_pin_Pin<Box<Dyn<Future<unit>>>>) = method28(v45)
    let v53 : string = "leptos::create_action(move |value: &bool| v52(*value))"
    let v54 : leptos_Action<bool, unit> = Fable.Core.RustInterop.emitRustExpr () v53
    let v55 : (unit -> std_collections_HashMap<string, leptos_RwSignal<bool>>) = method32(v41)
    let v56 : string = "leptos::create_memo(move |_| { v55() })"
    let v57 : leptos_Memo<std_collections_HashMap<string, leptos_RwSignal<bool>>> = Fable.Core.RustInterop.emitRustExpr () v56
    let v58 : string = $"leptos::create_signal(false)"
    let struct (v59 : leptos_ReadSignal<bool>, v60 : leptos_WriteSignal<bool>) = Fable.Core.RustInterop.emitRustExpr () v58
    let v61 : (unit -> unit) = method34(v41, v54, v57, v60, v59)
    let v62 : string = "leptos::create_effect(move |_| { v61() })"
    Fable.Core.RustInterop.emitRustExpr () v62
    let v63 : (leptos_ev_MouseEvent -> unit) = method41(v41)
    let v64 : string = $"<button class=\"fixed bottom-4 right-4 bg-gray-500 text-white p-2 rounded-full\" on:click=move |mouse_event| v63(mouse_event)>{{(|| {{ leptos::logging::log!(\"button () / render\"); leptos::view! {{<></>}} }})()}}{{\"🌓︎\"}}</button>"
    let v65 : string = "leptos::view! { " + v64 + " }"
    let v66 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v65
    let v67 : leptos_HtmlElement<leptos_html_Button> = v66 |> unbox
    let v68 : string = "<div class=\"flex flex-1\" class:dark={move || v37()}>{v67}{v36}</div>"
    let v69 : string = "leptos::view! { " + v68 + " }"
    let v70 : Impl<leptos_IntoView> = Fable.Core.RustInterop.emitRustExpr () v69
    let v71 : leptos_HtmlElement<leptos_html_Div> = v70 |> unbox
    let v72 : string = "leptos::IntoView::into_view(v71)"
    let v73 : leptos_View = Fable.Core.RustInterop.emitRustExpr () v72
    let v74 : Impl<leptos_IntoView> = v73 |> unbox
    v74
and method0 () : unit =
    let v0 : string = "leptos::mount_to_body(|| $0())"
    let v1 : (unit -> Impl<leptos_IntoView>) = closure2()
    Fable.Core.RustInterop.emitRustExpr v1 v0
    ()
and closure24 () () : unit =
    method0()
and method44 () : (unit -> unit) =
    closure24()
and method45 (v0 : Box<Dyn<FnUnit>>) : Box<Dyn<FnUnit>> =
    v0
and closure0 () (v0 : (string [])) : int32 =
    let v1 : string = "main / args: " + string v0 + ""
    let v2 : string = @$"leptos::logging::log!(""{{}}"", $0)"
    Fable.Core.RustInterop.emitRustExpr v1 v2
    let v3 : string = "let _ = console_log::init_with_level(log::Level::Debug)"
    Fable.Core.RustInterop.emitRustExpr () v3
    let v4 : string = "console_error_panic_hook::set_once()"
    Fable.Core.RustInterop.emitRustExpr () v4
    let v5 : string = "leptos::document().body()"
    let v6 : web_sys_HtmlElement option = Fable.Core.RustInterop.emitRustExpr () v5
    let v7 : (web_sys_HtmlElement -> US0) = closure1()
    let v8 : US0 = US0_0
    let v9 : US0 = v6 |> Option.map v7 |> Option.defaultValue v8
    let v10 : string = @$"format!(""{{:?}}"", $0)"
    let v11 : std_string_String = Fable.Core.RustInterop.emitRustExpr v9 v10
    let v12 : string = "main / mount_to_body / body: " + string v11 + ""
    let v13 : string = @$"leptos::logging::log!(""{{}}"", $0)"
    Fable.Core.RustInterop.emitRustExpr v12 v13
    match v9 with
    | US0_1(v14) -> (* Some *)
        method0()
    | _ ->
        let v15 : (unit -> unit) = method44()
        let v16 : string = "Box::new(move || v15())"
        let v17 : Box<Dyn<FnUnit>> = Fable.Core.RustInterop.emitRustExpr () v16
        let v18 : Box<Dyn<FnUnit>> = method45(v17)
        let v19 : string = "wasm_bindgen::closure::Closure::wrap(v18)"
        let v20 : wasm_bindgen_closure_Closure<Dyn<FnUnit>> = Fable.Core.RustInterop.emitRustExpr () v19
        let v21 : string = "wasm_bindgen::closure::Closure::as_ref(&v20)"
        let v22 : Ref<wasm_bindgen_JsValue> = Fable.Core.RustInterop.emitRustExpr () v21
        let v23 : string = "wasm_bindgen::JsCast::unchecked_ref(v22)"
        let v24 : Ref<js_sys_Function> = Fable.Core.RustInterop.emitRustExpr () v23
        let v25 : string = "leptos::document().add_event_listener_with_callback(\"DOMContentLoaded\", v24).unwrap()"
        Fable.Core.RustInterop.emitRustExpr () v25
        let v26 : string = "v20.forget()"
        Fable.Core.RustInterop.emitRustExpr () v26
        ()
    0
let v0 : ((string []) -> int32) = closure0()
let main args = v0 args
()
