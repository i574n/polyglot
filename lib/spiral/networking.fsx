#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("reqwest_wasm::Error")>]
#endif
type reqwest_Error = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("reqwest_wasm::RequestBuilder")>]
#endif
type reqwest_RequestBuilder = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("reqwest_wasm::Response")>]
#endif
type reqwest_Response = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::env::VarError")>]
#endif
type std_env_VarError = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("core::any::Any")>]
#endif
type core_any_Any = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("_")>]
#endif
type core_ops_Try<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("Func0<$0>")>]
#endif
type Func0<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("Func1<$0, $1>")>]
#endif
type Func0<'T, 'U> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("Box<$0>")>]
#endif
type Box<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("dyn $0")>]
#endif
type Dyn<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("Send")>]
#endif
type Send<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("Fn() -> $0")>]
#endif
type Fn<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("Fn()")>]
#endif
type FnUnit = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("FnOnce() -> $0")>]
#endif
type FnOnce<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("Fn($0)")>]
#endif
type ActionFn<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("Fn($0, $1)")>]
#endif
type ActionFn2<'T, 'U> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("impl $0")>]
#endif
type Impl<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("mut $0")>]
#endif
type Mut<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("&$0")>]
#endif
type Ref<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("$0 + $1")>]
#endif
type LifetimeJoin<'T, 'U> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("'static")>]
#endif
type StaticLifetime = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("$0")>]
#endif
type LifetimeRef<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("$0 $1")>]
#endif
type Lifetime<'T, 'U> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("MutCell<$0>")>]
#endif
type MutCell<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::any::Any")>]
#endif
type std_any_Any = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::borrow::Cow<$0>")>]
#endif
type std_borrow_Cow<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::cell::RefCell<$0>")>]
#endif
type std_cell_RefCell<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::pin::Pin<$0>")>]
#endif
type std_pin_Pin<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::rc::Rc<$0>")>]
#endif
type std_rc_Rc<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::rc::Weak<$0>")>]
#endif
type std_rc_Weak<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::collections::HashMap<$0, $1>")>]
#endif
type std_collections_HashMap<'K, 'V> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::collections::BTreeMap<$0, $1>")>]
#endif
type std_collections_BTreeMap<'K, 'V> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("[$0]")>]
#endif
type Slice<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("_")>]
#endif
type Slice'<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("Vec<$0>")>]
#endif
type Vec<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("str")>]
#endif
type Str = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("base64::DecodeError")>]
#endif
type base64_DecodeError = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("borsh::io::Error")>]
#endif
type borsh_io_Error = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("encoding_rs::Encoding")>]
#endif
type encoding_rs_Encoding = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("js_sys::JsString")>]
#endif
type js_sys_JsString = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("serde_json::Error")>]
#endif
type serde_json_Error = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("serde_json::Value")>]
#endif
type serde_json_Value = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("serde_wasm_bindgen::Error")>]
#endif
type serde_wasm_bindgen_Error = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::ffi::OsStr")>]
#endif
type std_ffi_OsStr = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::ffi::OsString")>]
#endif
type std_ffi_OsString = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::fmt::Display<$0>")>]
#endif
type std_fmt_Display<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::str::Utf8Error")>]
#endif
type std_str_Utf8Error = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::string::FromUtf8Error")>]
#endif
type std_string_FromUtf8Error = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::string::String")>]
#endif
type std_string_String = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::slice::Windows<$0>")>]
#endif
type std_slice_Windows<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("regex::Regex")>]
#endif
type regex_Regex = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("regex::Captures<$0>")>]
#endif
type regex_Captures<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("regex::CaptureMatches")>]
#endif
type regex_CaptureMatches = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("regex::CaptureNames")>]
#endif
type regex_CaptureNames = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("regex::Match")>]
#endif
type regex_Match = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("regex::Error")>]
#endif
type regex_Error = class end
module State = let mutable trace_state = None
type IOsEnviron = abstract environ: x: unit -> obj
type [<Struct>] US0 =
    | US0_0
    | US0_1
    | US0_2
    | US0_3
    | US0_4
and Mut0 = {mutable l0 : int64}
and Mut1 = {mutable l0 : bool}
and Mut2 = {mutable l0 : US0}
and Mut3 = {mutable l0 : (string -> unit)}
and [<Struct>] US1 =
    | US1_0 of f0_0 : int64
    | US1_1
and [<Struct>] US2 =
    | US2_0 of f0_0 : US0
    | US2_1
and [<Struct>] US3 =
    | US3_0 of f0_0 : string
    | US3_1
and [<Struct>] US4 =
    | US4_0 of f0_0 : bool
    | US4_1
and [<Struct>] US5 =
    | US5_0 of f0_0 : bool
    | US5_1 of f1_0 : exn
and [<Struct>] US6 =
    | US6_0 of f0_0 : bool
    | US6_1 of f1_0 : exn
and [<Struct>] US7 =
    | US7_0 of f0_0 : int32
    | US7_1
let rec method0 () : string =
    let v0 : string = "TRACE_LEVEL"
    v0
and method2 () : string =
    let v0 : string = ""
    v0
and method1 (v0 : string) : string =
    let v1 : bool = true
    let mutable _v1 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = "std::env::var(&*$0)"
    let v3 : Result<std_string_String, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr v0 v2 
    let v4 : string = "true; let _result = $0.map(|x| { //"
    let v5 : bool = Fable.Core.RustInterop.emitRustExpr v3 v4 
    let v6 : string = "x"
    let v7 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v6 
    let v8 : string = "fable_library_rust::String_::fromString($0)"
    let v9 : string = Fable.Core.RustInterop.emitRustExpr v7 v8 
    let v10 : string = "true; $0 })"
    let v11 : bool = Fable.Core.RustInterop.emitRustExpr v9 v10 
    let v12 : string = "_result"
    let v13 : Result<string, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr () v12 
    let v14 : string = method2()
    let v15 : string = "$0.unwrap_or($1)"
    let v16 : string = Fable.Core.RustInterop.emitRustExpr struct (v13, v14) v15 
    v16 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v17 : string = "std::env::var(&*$0)"
    let v18 : Result<std_string_String, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr v0 v17 
    let v19 : string = "true; let _result = $0.map(|x| { //"
    let v20 : bool = Fable.Core.RustInterop.emitRustExpr v18 v19 
    let v21 : string = "x"
    let v22 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v21 
    let v23 : string = "fable_library_rust::String_::fromString($0)"
    let v24 : string = Fable.Core.RustInterop.emitRustExpr v22 v23 
    let v25 : string = "true; $0 })"
    let v26 : bool = Fable.Core.RustInterop.emitRustExpr v24 v25 
    let v27 : string = "_result"
    let v28 : Result<string, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr () v27 
    let v29 : string = method2()
    let v30 : string = "$0.unwrap_or($1)"
    let v31 : string = Fable.Core.RustInterop.emitRustExpr struct (v28, v29) v30 
    v31 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v32 : string = "std::env::var(&*$0)"
    let v33 : Result<std_string_String, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr v0 v32 
    let v34 : string = "true; let _result = $0.map(|x| { //"
    let v35 : bool = Fable.Core.RustInterop.emitRustExpr v33 v34 
    let v36 : string = "x"
    let v37 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v36 
    let v38 : string = "fable_library_rust::String_::fromString($0)"
    let v39 : string = Fable.Core.RustInterop.emitRustExpr v37 v38 
    let v40 : string = "true; $0 })"
    let v41 : bool = Fable.Core.RustInterop.emitRustExpr v39 v40 
    let v42 : string = "_result"
    let v43 : Result<string, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr () v42 
    let v44 : string = method2()
    let v45 : string = "$0.unwrap_or($1)"
    let v46 : string = Fable.Core.RustInterop.emitRustExpr struct (v43, v44) v45 
    v46 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v47 : string = "process.env[$0] ?? \"\""
    let v48 : string = Fable.Core.JsInterop.emitJsExpr v0 v47 
    v48 
    #endif
#if FABLE_COMPILER_PYTHON
    let v49 : string = "os"
    let v50 : IOsEnviron = Fable.Core.PyInterop.importAll v49 
    let v51 : string = "v50.environ"
    let v52 : obj = Fable.Core.PyInterop.emitPyExpr () v51 
    let v53 : string = "v52.get($0)"
    let v54 : string = Fable.Core.PyInterop.emitPyExpr v0 v53 
    let mutable _v54 = None
    #if !FABLE_COMPILER && !WASM && !CONTRACT
    let v55 : (string -> string option) = Option.ofObj
    let v56 : string option = v55 v54
    v56 
    #else
    Some v54 
    #endif
    |> fun x -> _v54 <- Some x
    let v57 : string option = match _v54 with Some x -> x | None -> failwith "optionm'.of_obj / _v54=None"
    let v58 : US3 option = None
    let _v58 = ref v58 
    match v57 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v59 : string = x
    let v60 : US3 = US3_0(v59)
    v60 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v58.Value <- x
    let v61 : US3 option = _v58.Value 
    let v62 : US3 = US3_1
    let v63 : US3 = v61 |> Option.defaultValue v62 
    let v67 : string =
        match v63 with
        | US3_1 -> (* None *)
            let v65 : string = ""
            v65
        | US3_0(v64) -> (* Some *)
            v64
    v67 
    #endif
#else
    let v68 : (string -> string) = System.Environment.GetEnvironmentVariable
    let v69 : string = v68 v0
    let mutable _v69 = None
    #if !FABLE_COMPILER && !WASM && !CONTRACT
    let v70 : (string -> string option) = Option.ofObj
    let v71 : string option = v70 v69
    v71 
    #else
    Some v69 
    #endif
    |> fun x -> _v69 <- Some x
    let v72 : string option = match _v69 with Some x -> x | None -> failwith "optionm'.of_obj / _v69=None"
    let v73 : US3 option = None
    let _v73 = ref v73 
    match v72 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v74 : string = x
    let v75 : US3 = US3_0(v74)
    v75 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v73.Value <- x
    let v76 : US3 option = _v73.Value 
    let v77 : US3 = US3_1
    let v78 : US3 = v76 |> Option.defaultValue v77 
    let v82 : string =
        match v78 with
        | US3_1 -> (* None *)
            let v80 : string = ""
            v80
        | US3_0(v79) -> (* Some *)
            v79
    v82 
    #endif
    |> fun x -> _v1 <- Some x
    let v83 : string = match _v1 with Some x -> x | None -> failwith "base.run_target / _v1=None"
    v83
and method3 () : string =
    let v0 : string = "AUTOMATION"
    v0
and closure1 () (v0 : string) : unit =
    ()
and closure0 () (v0 : US0) : struct (Mut0 * Mut1 * Mut2 * int64 option * Mut3) =
    let v1 : bool = true
    let mutable _v1 : struct (US1 * US2) option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = method0()
    let v3 : string = method1(v2)
    let v5 : bool = "Verbose" = v3
    let v9 : US2 =
        if v5 then
            let v6 : US0 = US0_0
            US2_0(v6)
        else
            US2_1
    let v54 : US2 =
        match v9 with
        | US2_1 -> (* None *)
            let v13 : bool = "Debug" = v3
            let v17 : US2 =
                if v13 then
                    let v14 : US0 = US0_1
                    US2_0(v14)
                else
                    US2_1
            match v17 with
            | US2_1 -> (* None *)
                let v21 : bool = "Info" = v3
                let v25 : US2 =
                    if v21 then
                        let v22 : US0 = US0_2
                        US2_0(v22)
                    else
                        US2_1
                match v25 with
                | US2_1 -> (* None *)
                    let v29 : bool = "Warning" = v3
                    let v33 : US2 =
                        if v29 then
                            let v30 : US0 = US0_3
                            US2_0(v30)
                        else
                            US2_1
                    match v33 with
                    | US2_1 -> (* None *)
                        let v37 : bool = "Critical" = v3
                        let v41 : US2 =
                            if v37 then
                                let v38 : US0 = US0_4
                                US2_0(v38)
                            else
                                US2_1
                        match v41 with
                        | US2_1 -> (* None *)
                            US2_1
                        | US2_0(v42) -> (* Some *)
                            US2_0(v42)
                    | US2_0(v34) -> (* Some *)
                        US2_0(v34)
                | US2_0(v26) -> (* Some *)
                    US2_0(v26)
            | US2_0(v18) -> (* Some *)
                US2_0(v18)
        | US2_0(v10) -> (* Some *)
            US2_0(v10)
    let v55 : string = method3()
    let v56 : string = method1(v55)
    let v58 : bool = v56 = "True"
    let v64 : US1 =
        if v58 then
            let v59 : System.DateTime = System.DateTime.Now
            let v60 : (System.DateTime -> int64) = _.Ticks
            let v61 : int64 = v60 v59
            US1_0(v61)
        else
            US1_1
    struct (v64, v54) 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v65 : US1 = US1_1
    let v66 : US2 = US2_1
    struct (v65, v66) 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v67 : US1 = US1_1
    let v68 : US2 = US2_1
    struct (v67, v68) 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v69 : string = method0()
    let v70 : string = method1(v69)
    let v72 : bool = "Verbose" = v70
    let v76 : US2 =
        if v72 then
            let v73 : US0 = US0_0
            US2_0(v73)
        else
            US2_1
    let v121 : US2 =
        match v76 with
        | US2_1 -> (* None *)
            let v80 : bool = "Debug" = v70
            let v84 : US2 =
                if v80 then
                    let v81 : US0 = US0_1
                    US2_0(v81)
                else
                    US2_1
            match v84 with
            | US2_1 -> (* None *)
                let v88 : bool = "Info" = v70
                let v92 : US2 =
                    if v88 then
                        let v89 : US0 = US0_2
                        US2_0(v89)
                    else
                        US2_1
                match v92 with
                | US2_1 -> (* None *)
                    let v96 : bool = "Warning" = v70
                    let v100 : US2 =
                        if v96 then
                            let v97 : US0 = US0_3
                            US2_0(v97)
                        else
                            US2_1
                    match v100 with
                    | US2_1 -> (* None *)
                        let v104 : bool = "Critical" = v70
                        let v108 : US2 =
                            if v104 then
                                let v105 : US0 = US0_4
                                US2_0(v105)
                            else
                                US2_1
                        match v108 with
                        | US2_1 -> (* None *)
                            US2_1
                        | US2_0(v109) -> (* Some *)
                            US2_0(v109)
                    | US2_0(v101) -> (* Some *)
                        US2_0(v101)
                | US2_0(v93) -> (* Some *)
                    US2_0(v93)
            | US2_0(v85) -> (* Some *)
                US2_0(v85)
        | US2_0(v77) -> (* Some *)
            US2_0(v77)
    let v122 : string = method3()
    let v123 : string = method1(v122)
    let v125 : bool = v123 = "True"
    let v131 : US1 =
        if v125 then
            let v126 : System.DateTime = System.DateTime.Now
            let v127 : (System.DateTime -> int64) = _.Ticks
            let v128 : int64 = v127 v126
            US1_0(v128)
        else
            US1_1
    struct (v131, v121) 
    #endif
#if FABLE_COMPILER_PYTHON
    let v132 : string = method0()
    let v133 : string = method1(v132)
    let v135 : bool = "Verbose" = v133
    let v139 : US2 =
        if v135 then
            let v136 : US0 = US0_0
            US2_0(v136)
        else
            US2_1
    let v184 : US2 =
        match v139 with
        | US2_1 -> (* None *)
            let v143 : bool = "Debug" = v133
            let v147 : US2 =
                if v143 then
                    let v144 : US0 = US0_1
                    US2_0(v144)
                else
                    US2_1
            match v147 with
            | US2_1 -> (* None *)
                let v151 : bool = "Info" = v133
                let v155 : US2 =
                    if v151 then
                        let v152 : US0 = US0_2
                        US2_0(v152)
                    else
                        US2_1
                match v155 with
                | US2_1 -> (* None *)
                    let v159 : bool = "Warning" = v133
                    let v163 : US2 =
                        if v159 then
                            let v160 : US0 = US0_3
                            US2_0(v160)
                        else
                            US2_1
                    match v163 with
                    | US2_1 -> (* None *)
                        let v167 : bool = "Critical" = v133
                        let v171 : US2 =
                            if v167 then
                                let v168 : US0 = US0_4
                                US2_0(v168)
                            else
                                US2_1
                        match v171 with
                        | US2_1 -> (* None *)
                            US2_1
                        | US2_0(v172) -> (* Some *)
                            US2_0(v172)
                    | US2_0(v164) -> (* Some *)
                        US2_0(v164)
                | US2_0(v156) -> (* Some *)
                    US2_0(v156)
            | US2_0(v148) -> (* Some *)
                US2_0(v148)
        | US2_0(v140) -> (* Some *)
            US2_0(v140)
    let v185 : string = method3()
    let v186 : string = method1(v185)
    let v188 : bool = v186 = "True"
    let v194 : US1 =
        if v188 then
            let v189 : System.DateTime = System.DateTime.Now
            let v190 : (System.DateTime -> int64) = _.Ticks
            let v191 : int64 = v190 v189
            US1_0(v191)
        else
            US1_1
    struct (v194, v184) 
    #endif
#else
    let v195 : string = method0()
    let v196 : string = method1(v195)
    let v198 : bool = "Verbose" = v196
    let v202 : US2 =
        if v198 then
            let v199 : US0 = US0_0
            US2_0(v199)
        else
            US2_1
    let v247 : US2 =
        match v202 with
        | US2_1 -> (* None *)
            let v206 : bool = "Debug" = v196
            let v210 : US2 =
                if v206 then
                    let v207 : US0 = US0_1
                    US2_0(v207)
                else
                    US2_1
            match v210 with
            | US2_1 -> (* None *)
                let v214 : bool = "Info" = v196
                let v218 : US2 =
                    if v214 then
                        let v215 : US0 = US0_2
                        US2_0(v215)
                    else
                        US2_1
                match v218 with
                | US2_1 -> (* None *)
                    let v222 : bool = "Warning" = v196
                    let v226 : US2 =
                        if v222 then
                            let v223 : US0 = US0_3
                            US2_0(v223)
                        else
                            US2_1
                    match v226 with
                    | US2_1 -> (* None *)
                        let v230 : bool = "Critical" = v196
                        let v234 : US2 =
                            if v230 then
                                let v231 : US0 = US0_4
                                US2_0(v231)
                            else
                                US2_1
                        match v234 with
                        | US2_1 -> (* None *)
                            US2_1
                        | US2_0(v235) -> (* Some *)
                            US2_0(v235)
                    | US2_0(v227) -> (* Some *)
                        US2_0(v227)
                | US2_0(v219) -> (* Some *)
                    US2_0(v219)
            | US2_0(v211) -> (* Some *)
                US2_0(v211)
        | US2_0(v203) -> (* Some *)
            US2_0(v203)
    let v248 : string = method3()
    let v249 : string = method1(v248)
    let v251 : bool = v249 = "True"
    let v257 : US1 =
        if v251 then
            let v252 : System.DateTime = System.DateTime.Now
            let v253 : (System.DateTime -> int64) = _.Ticks
            let v254 : int64 = v253 v252
            US1_0(v254)
        else
            US1_1
    struct (v257, v247) 
    #endif
    |> fun x -> _v1 <- Some x
    let struct (v258 : US1, v259 : US2) = match _v1 with Some x -> x | None -> failwith "base.run_target / _v1=None"
    let v260 : Mut1 = {l0 = true} : Mut1
    let v261 : Mut0 = {l0 = 0L} : Mut0
    let v264 : US0 =
        match v259 with
        | US2_1 -> (* None *)
            v0
        | US2_0(v262) -> (* Some *)
            v262
    let v265 : Mut2 = {l0 = v264} : Mut2
    let v266 : (string -> unit) = closure1()
    let v267 : Mut3 = {l0 = v266} : Mut3
    let v272 : int64 option =
        match v258 with
        | US1_1 -> (* None *)
            let v270 : int64 option = None
            v270
        | US1_0(v268) -> (* Some *)
            let v269 : int64 option = Some v268 
            v269
    struct (v261, v260, v265, v272, v267)
and closure4 (v0 : int32, v1 : string) () : string =
    let v2 : string = $"networking.test_port_open / port: {v0} / ex: {v1}"
    v2
and closure5 () () : string =
    let v0 : string = ""
    v0
and method5 () : string =
    let v0 : string = "hh:mm:ss"
    v0
and method6 () : string =
    let v0 : string = ""
    v0
and method7 () : string =
    let v0 : string = "HH:mm:ss"
    v0
and method8 () : string =
    let v0 : string = "\u001b[0m"
    v0
and closure6 (v0 : US0, v1 : (unit -> string), v2 : (unit -> string)) () : string =
    let v3 : (US0 -> struct (Mut0 * Mut1 * Mut2 * int64 option * Mut3)) = closure0()
    let v4 : US0 = US0_0
    if State.trace_state.IsNone then State.trace_state <- v3 v4 |> Some
    let struct (v5 : Mut0, v6 : Mut1, v7 : Mut2, v8 : int64 option, v9 : Mut3) = State.trace_state.Value
    let v10 : bool = true
    let mutable _v10 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v11 : US1 option = None
    let _v11 = ref v11 
    match v8 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v12 : int64 = x
    let v13 : US1 = US1_0(v12)
    v13 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v11.Value <- x
    let v14 : US1 option = _v11.Value 
    let v15 : US1 = US1_1
    let v16 : US1 = v14 |> Option.defaultValue v15 
    let v35 : System.DateTime =
        match v16 with
        | US1_1 -> (* None *)
            let v33 : System.DateTime = System.DateTime.Now
            v33
        | US1_0(v17) -> (* Some *)
            let v18 : System.DateTime = System.DateTime.Now
            let v19 : (System.DateTime -> int64) = _.Ticks
            let v20 : int64 = v19 v18
            let v21 : int64 = v20 - v17
            let v22 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v23 : System.TimeSpan = v22 v21
            let v24 : (System.TimeSpan -> int32) = _.Hours
            let v25 : int32 = v24 v23
            let v26 : (System.TimeSpan -> int32) = _.Minutes
            let v27 : int32 = v26 v23
            let v28 : (System.TimeSpan -> int32) = _.Seconds
            let v29 : int32 = v28 v23
            let v30 : (System.TimeSpan -> int32) = _.Milliseconds
            let v31 : int32 = v30 v23
            let v32 : System.DateTime = System.DateTime (1, 1, 1, v25, v27, v29, v31)
            v32
    let v36 : string = method5()
    let v37 : (string -> string) = v35.ToString
    let v38 : string = v37 v36
    v38 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v39 : US1 option = None
    let _v39 = ref v39 
    match v8 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v40 : int64 = x
    let v41 : US1 = US1_0(v40)
    v41 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v39.Value <- x
    let v42 : US1 option = _v39.Value 
    let v43 : US1 = US1_1
    let v44 : US1 = v42 |> Option.defaultValue v43 
    let v63 : System.DateTime =
        match v44 with
        | US1_1 -> (* None *)
            let v61 : System.DateTime = System.DateTime.Now
            v61
        | US1_0(v45) -> (* Some *)
            let v46 : System.DateTime = System.DateTime.Now
            let v47 : (System.DateTime -> int64) = _.Ticks
            let v48 : int64 = v47 v46
            let v49 : int64 = v48 - v45
            let v50 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v51 : System.TimeSpan = v50 v49
            let v52 : (System.TimeSpan -> int32) = _.Hours
            let v53 : int32 = v52 v51
            let v54 : (System.TimeSpan -> int32) = _.Minutes
            let v55 : int32 = v54 v51
            let v56 : (System.TimeSpan -> int32) = _.Seconds
            let v57 : int32 = v56 v51
            let v58 : (System.TimeSpan -> int32) = _.Milliseconds
            let v59 : int32 = v58 v51
            let v60 : System.DateTime = System.DateTime (1, 1, 1, v53, v55, v57, v59)
            v60
    let v64 : string = method5()
    let v65 : (string -> string) = v63.ToString
    let v66 : string = v65 v64
    v66 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v67 : string = method6()
    v67 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v68 : US1 option = None
    let _v68 = ref v68 
    match v8 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v69 : int64 = x
    let v70 : US1 = US1_0(v69)
    v70 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v68.Value <- x
    let v71 : US1 option = _v68.Value 
    let v72 : US1 = US1_1
    let v73 : US1 = v71 |> Option.defaultValue v72 
    let v92 : System.DateTime =
        match v73 with
        | US1_1 -> (* None *)
            let v90 : System.DateTime = System.DateTime.Now
            v90
        | US1_0(v74) -> (* Some *)
            let v75 : System.DateTime = System.DateTime.Now
            let v76 : (System.DateTime -> int64) = _.Ticks
            let v77 : int64 = v76 v75
            let v78 : int64 = v77 - v74
            let v79 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v80 : System.TimeSpan = v79 v78
            let v81 : (System.TimeSpan -> int32) = _.Hours
            let v82 : int32 = v81 v80
            let v83 : (System.TimeSpan -> int32) = _.Minutes
            let v84 : int32 = v83 v80
            let v85 : (System.TimeSpan -> int32) = _.Seconds
            let v86 : int32 = v85 v80
            let v87 : (System.TimeSpan -> int32) = _.Milliseconds
            let v88 : int32 = v87 v80
            let v89 : System.DateTime = System.DateTime (1, 1, 1, v82, v84, v86, v88)
            v89
    let v93 : string = method7()
    let v94 : (string -> string) = v92.ToString
    let v95 : string = v94 v93
    v95 
    #endif
#if FABLE_COMPILER_PYTHON
    let v96 : US1 option = None
    let _v96 = ref v96 
    match v8 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v97 : int64 = x
    let v98 : US1 = US1_0(v97)
    v98 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v96.Value <- x
    let v99 : US1 option = _v96.Value 
    let v100 : US1 = US1_1
    let v101 : US1 = v99 |> Option.defaultValue v100 
    let v120 : System.DateTime =
        match v101 with
        | US1_1 -> (* None *)
            let v118 : System.DateTime = System.DateTime.Now
            v118
        | US1_0(v102) -> (* Some *)
            let v103 : System.DateTime = System.DateTime.Now
            let v104 : (System.DateTime -> int64) = _.Ticks
            let v105 : int64 = v104 v103
            let v106 : int64 = v105 - v102
            let v107 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v108 : System.TimeSpan = v107 v106
            let v109 : (System.TimeSpan -> int32) = _.Hours
            let v110 : int32 = v109 v108
            let v111 : (System.TimeSpan -> int32) = _.Minutes
            let v112 : int32 = v111 v108
            let v113 : (System.TimeSpan -> int32) = _.Seconds
            let v114 : int32 = v113 v108
            let v115 : (System.TimeSpan -> int32) = _.Milliseconds
            let v116 : int32 = v115 v108
            let v117 : System.DateTime = System.DateTime (1, 1, 1, v110, v112, v114, v116)
            v117
    let v121 : string = method7()
    let v122 : (string -> string) = v120.ToString
    let v123 : string = v122 v121
    v123 
    #endif
#else
    let v124 : US1 option = None
    let _v124 = ref v124 
    match v8 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v125 : int64 = x
    let v126 : US1 = US1_0(v125)
    v126 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v124.Value <- x
    let v127 : US1 option = _v124.Value 
    let v128 : US1 = US1_1
    let v129 : US1 = v127 |> Option.defaultValue v128 
    let v148 : System.DateTime =
        match v129 with
        | US1_1 -> (* None *)
            let v146 : System.DateTime = System.DateTime.Now
            v146
        | US1_0(v130) -> (* Some *)
            let v131 : System.DateTime = System.DateTime.Now
            let v132 : (System.DateTime -> int64) = _.Ticks
            let v133 : int64 = v132 v131
            let v134 : int64 = v133 - v130
            let v135 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v136 : System.TimeSpan = v135 v134
            let v137 : (System.TimeSpan -> int32) = _.Hours
            let v138 : int32 = v137 v136
            let v139 : (System.TimeSpan -> int32) = _.Minutes
            let v140 : int32 = v139 v136
            let v141 : (System.TimeSpan -> int32) = _.Seconds
            let v142 : int32 = v141 v136
            let v143 : (System.TimeSpan -> int32) = _.Milliseconds
            let v144 : int32 = v143 v136
            let v145 : System.DateTime = System.DateTime (1, 1, 1, v138, v140, v142, v144)
            v145
    let v149 : string = method7()
    let v150 : (string -> string) = v148.ToString
    let v151 : string = v150 v149
    v151 
    #endif
    |> fun x -> _v10 <- Some x
    let v152 : string = match _v10 with Some x -> x | None -> failwith "base.run_target / _v10=None"
    let v155 : bool =
        match v0 with
        | US0_0 -> (* Verbose *)
            true
        | _ ->
            false
    let v159 : US3 =
        if v155 then
            let v156 : string = "Verbose"
            US3_0(v156)
        else
            US3_1
    let v208 : US3 =
        match v159 with
        | US3_1 -> (* None *)
            let v164 : bool =
                match v0 with
                | US0_1 -> (* Debug *)
                    true
                | _ ->
                    false
            let v168 : US3 =
                if v164 then
                    let v165 : string = "Debug"
                    US3_0(v165)
                else
                    US3_1
            match v168 with
            | US3_1 -> (* None *)
                let v173 : bool =
                    match v0 with
                    | US0_2 -> (* Info *)
                        true
                    | _ ->
                        false
                let v177 : US3 =
                    if v173 then
                        let v174 : string = "Info"
                        US3_0(v174)
                    else
                        US3_1
                match v177 with
                | US3_1 -> (* None *)
                    let v182 : bool =
                        match v0 with
                        | US0_3 -> (* Warning *)
                            true
                        | _ ->
                            false
                    let v186 : US3 =
                        if v182 then
                            let v183 : string = "Warning"
                            US3_0(v183)
                        else
                            US3_1
                    match v186 with
                    | US3_1 -> (* None *)
                        let v191 : bool =
                            match v0 with
                            | US0_4 -> (* Critical *)
                                true
                            | _ ->
                                false
                        let v195 : US3 =
                            if v191 then
                                let v192 : string = "Critical"
                                US3_0(v192)
                            else
                                US3_1
                        match v195 with
                        | US3_1 -> (* None *)
                            US3_1
                        | US3_0(v196) -> (* Some *)
                            US3_0(v196)
                    | US3_0(v187) -> (* Some *)
                        US3_0(v187)
                | US3_0(v178) -> (* Some *)
                    US3_0(v178)
            | US3_0(v169) -> (* Some *)
                US3_0(v169)
        | US3_0(v160) -> (* Some *)
            US3_0(v160)
    let v212 : string =
        match v208 with
        | US3_1 -> (* None *)
            failwith<string> "Option does not have a value."
        | US3_0(v209) -> (* Some *)
            v209
    let v213 : (unit -> string) = v212.ToLower
    let v214 : string = v213 ()
    let v215 : string = v214.PadLeft (7, ' ')
    let v216 : bool = true
    let mutable _v216 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v231 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v225 : string = "inline_colorization::color_bright_red"
            let v226 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v225 
            v226
        | US0_1 -> (* Debug *)
            let v219 : string = "inline_colorization::color_bright_blue"
            let v220 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v219 
            v220
        | US0_2 -> (* Info *)
            let v221 : string = "inline_colorization::color_bright_green"
            let v222 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v221 
            v222
        | US0_0 -> (* Verbose *)
            let v217 : string = "inline_colorization::color_bright_black"
            let v218 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v217 
            v218
        | US0_3 -> (* Warning *)
            let v223 : string = "inline_colorization::color_yellow"
            let v224 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v223 
            v224
    let v232 : string = "&*$0"
    let v233 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v215 v232 
    let v234 : string = "inline_colorization::color_reset"
    let v235 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v234 
    let v236 : string = "\"{v231}{v233}{v235}\""
    let v237 : string = @$"format!(" + v236 + ")"
    let v238 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v237 
    let v239 : string = "fable_library_rust::String_::fromString($0)"
    let v240 : string = Fable.Core.RustInterop.emitRustExpr v238 v239 
    v240 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v255 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v249 : string = "inline_colorization::color_bright_red"
            let v250 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v249 
            v250
        | US0_1 -> (* Debug *)
            let v243 : string = "inline_colorization::color_bright_blue"
            let v244 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v243 
            v244
        | US0_2 -> (* Info *)
            let v245 : string = "inline_colorization::color_bright_green"
            let v246 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v245 
            v246
        | US0_0 -> (* Verbose *)
            let v241 : string = "inline_colorization::color_bright_black"
            let v242 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v241 
            v242
        | US0_3 -> (* Warning *)
            let v247 : string = "inline_colorization::color_yellow"
            let v248 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v247 
            v248
    let v256 : string = "&*$0"
    let v257 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v215 v256 
    let v258 : string = "inline_colorization::color_reset"
    let v259 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v258 
    let v260 : string = "\"{v255}{v257}{v259}\""
    let v261 : string = @$"format!(" + v260 + ")"
    let v262 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v261 
    let v263 : string = "fable_library_rust::String_::fromString($0)"
    let v264 : string = Fable.Core.RustInterop.emitRustExpr v262 v263 
    v264 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v279 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v273 : string = "inline_colorization::color_bright_red"
            let v274 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v273 
            v274
        | US0_1 -> (* Debug *)
            let v267 : string = "inline_colorization::color_bright_blue"
            let v268 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v267 
            v268
        | US0_2 -> (* Info *)
            let v269 : string = "inline_colorization::color_bright_green"
            let v270 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v269 
            v270
        | US0_0 -> (* Verbose *)
            let v265 : string = "inline_colorization::color_bright_black"
            let v266 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v265 
            v266
        | US0_3 -> (* Warning *)
            let v271 : string = "inline_colorization::color_yellow"
            let v272 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v271 
            v272
    let v280 : string = "&*$0"
    let v281 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v215 v280 
    let v282 : string = "inline_colorization::color_reset"
    let v283 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v282 
    let v284 : string = "\"{v279}{v281}{v283}\""
    let v285 : string = @$"format!(" + v284 + ")"
    let v286 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v285 
    let v287 : string = "fable_library_rust::String_::fromString($0)"
    let v288 : string = Fable.Core.RustInterop.emitRustExpr v286 v287 
    v288 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v298 : string =
        match v0 with
        | US0_4 -> (* Critical *)
            let v293 : string = "\u001b[91m"
            v293
        | US0_1 -> (* Debug *)
            let v290 : string = "\u001b[94m"
            v290
        | US0_2 -> (* Info *)
            let v291 : string = "\u001b[92m"
            v291
        | US0_0 -> (* Verbose *)
            let v289 : string = "\u001b[90m"
            v289
        | US0_3 -> (* Warning *)
            let v292 : string = "\u001b[93m"
            v292
    let v299 : string = method8()
    let v300 : string = v298 + v215 
    let v301 : string = v300 + v299 
    v301 
    #endif
#if FABLE_COMPILER_PYTHON
    let v311 : string =
        match v0 with
        | US0_4 -> (* Critical *)
            let v306 : string = "\u001b[91m"
            v306
        | US0_1 -> (* Debug *)
            let v303 : string = "\u001b[94m"
            v303
        | US0_2 -> (* Info *)
            let v304 : string = "\u001b[92m"
            v304
        | US0_0 -> (* Verbose *)
            let v302 : string = "\u001b[90m"
            v302
        | US0_3 -> (* Warning *)
            let v305 : string = "\u001b[93m"
            v305
    let v312 : string = method8()
    let v313 : string = v311 + v215 
    let v314 : string = v313 + v312 
    v314 
    #endif
#else
    let v324 : string =
        match v0 with
        | US0_4 -> (* Critical *)
            let v319 : string = "\u001b[91m"
            v319
        | US0_1 -> (* Debug *)
            let v316 : string = "\u001b[94m"
            v316
        | US0_2 -> (* Info *)
            let v317 : string = "\u001b[92m"
            v317
        | US0_0 -> (* Verbose *)
            let v315 : string = "\u001b[90m"
            v315
        | US0_3 -> (* Warning *)
            let v318 : string = "\u001b[93m"
            v318
    let v325 : string = method8()
    let v326 : string = v324 + v215 
    let v327 : string = v326 + v325 
    v327 
    #endif
    |> fun x -> _v216 <- Some x
    let v328 : string = match _v216 with Some x -> x | None -> failwith "base.run_target / _v216=None"
    let v329 : int64 = v5.l0
    let v330 : string = $"{v152} {v328} #{v329} %s{v1 ()} / %s{v2 ()}"
    let v331 : char list = []
    let v332 : (char list -> (char [])) = List.toArray
    let v333 : (char []) = v332 v331
    let v334 : string = v330.TrimStart v333 
    let v335 : char list = []
    let v336 : char list = '/' :: v335 
    let v337 : char list = ' ' :: v336 
    let v338 : (char list -> (char [])) = List.toArray
    let v339 : (char []) = v338 v337
    let v340 : string = v334.TrimEnd v339 
    v340
and method9 (v0 : US0, v1 : (unit -> string)) : unit =
    let v2 : (US0 -> struct (Mut0 * Mut1 * Mut2 * int64 option * Mut3)) = closure0()
    let v3 : US0 = US0_0
    if State.trace_state.IsNone then State.trace_state <- v2 v3 |> Some
    let struct (v4 : Mut0, v5 : Mut1, v6 : Mut2, v7 : int64 option, v8 : Mut3) = State.trace_state.Value
    let v9 : US0 = US0_0
    if State.trace_state.IsNone then State.trace_state <- v2 v9 |> Some
    let struct (v10 : Mut0, v11 : Mut1, v12 : Mut2, v13 : int64 option, v14 : Mut3) = State.trace_state.Value
    let v15 : US0 = v12.l0
    let v16 : bool = v11.l0
    let v17 : bool = v16 = false
    let v21 : bool =
        if v17 then
            false
        else
            let v18 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v0
            let v19 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v15
            let v20 : bool = v18 >= v19
            v20
    if v21 then
        let v22 : int64 = v4.l0
        let v23 : int64 = v22 + 1L
        v4.l0 <- v23
        let v24 : string = $"%s{v1 ()}"
        let v25 : bool = true
        let mutable _v25 : unit option = None 
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v26 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v24 v26 
        () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v27 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v24 v27 
        () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v28 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v24 v28 
        () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        System.Console.WriteLine v24 
        () 
        #endif
#if FABLE_COMPILER_PYTHON
        System.Console.WriteLine v24 
        () 
        #endif
#else
        System.Console.WriteLine v24 
        () 
        #endif
        |> fun x -> _v25 <- Some x
        match _v25 with Some x -> x | None -> failwith "base.run_target / _v25=None"
        let v29 : (string -> unit) = v8.l0
        v29 v24
and method4 (v0 : US0, v1 : (unit -> string), v2 : (unit -> string)) : unit =
    let v3 : (unit -> string) = closure6(v0, v1, v2)
    method9(v0, v3)
and closure3 (v0 : string) (v1 : int32) : Async<bool> =
    let v2 : bool = true
    let mutable _v2 : Async<bool> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : Async<bool> = null |> unbox<Async<bool>>
    v3 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v4 : Async<bool> = null |> unbox<Async<bool>>
    v4 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v5 : Async<bool> = null |> unbox<Async<bool>>
    v5 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v6 : Async<bool> = null |> unbox<Async<bool>>
    v6 
    #endif
#if FABLE_COMPILER_PYTHON
    let v7 : Async<bool> = null |> unbox<Async<bool>>
    v7 
    #endif
#else
    let v8 : Async<bool> option = None
    let mutable _v8 = v8 
    async {
    let v9 : Async<System.Threading.CancellationToken> = Async.CancellationToken
    let! v9 = v9 
    let v10 : System.Threading.CancellationToken = v9 
    let v11 : System.Net.Sockets.TcpClient = new System.Net.Sockets.TcpClient ()
    use v11 = v11 
    let v12 : System.Net.Sockets.TcpClient = v11 
    try
    let v13 : System.Threading.Tasks.ValueTask = v12.ConnectAsync (v0, v1, v10)
    let v14 : (unit -> System.Threading.Tasks.Task) = v13.AsTask
    let v15 : System.Threading.Tasks.Task = v14 ()
    let v16 : bool = true
    let mutable _v16 : Async<unit> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v17 : Async<unit> = null |> unbox<Async<unit>>
    v17 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v18 : Async<unit> = null |> unbox<Async<unit>>
    v18 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v19 : Async<unit> = null |> unbox<Async<unit>>
    v19 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v20 : Async<unit> = null |> unbox<Async<unit>>
    v20 
    #endif
#if FABLE_COMPILER_PYTHON
    let v21 : Async<unit> = null |> unbox<Async<unit>>
    v21 
    #endif
#else
    let v22 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
    let v23 : Async<unit> = v22 v15
    v23 
    #endif
    |> fun x -> _v16 <- Some x
    let v24 : Async<unit> = match _v16 with Some x -> x | None -> failwith "base.run_target / _v16=None"
    do! v24 
    return true 
    with ex ->
    let v25 : exn = ex
    let v26 : bool = true
    let mutable _v26 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v27 : string = $"%A{v25}"
    v27 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v28 : string = $"%A{v25}"
    v28 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v29 : string = $"%A{v25}"
    v29 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v30 : string = $"%A{v25}"
    v30 
    #endif
#if FABLE_COMPILER_PYTHON
    let v31 : string = $"%A{v25}"
    v31 
    #endif
#else
    let v32 : string = $"{v25.GetType ()}: {v25.Message}"
    v32 
    #endif
    |> fun x -> _v26 <- Some x
    let v33 : string = match _v26 with Some x -> x | None -> failwith "base.run_target / _v26=None"
    let v34 : US0 = US0_0
    let v35 : (unit -> string) = closure4(v1, v33)
    let v36 : (unit -> string) = closure5()
    method4(v34, v35, v36)
    return false 
    (*
    let v37 : bool = *)
    }
    |> fun x -> _v8 <- Some x
    let v38 : Async<bool> = match _v8 with Some x -> x | None -> failwith "async.new_async_unit / _v8=None"
    v38 
    #endif
    |> fun x -> _v2 <- Some x
    let v39 : Async<bool> = match _v2 with Some x -> x | None -> failwith "base.run_target / _v2=None"
    v39
and closure2 () (v0 : string) : (int32 -> Async<bool>) =
    closure3(v0)
and closure10 () (v0 : bool) : US5 =
    US5_0(v0)
and closure11 () (v0 : exn) : US5 =
    US5_1(v0)
and closure12 () () : string =
    let v0 : string = "async.run_with_timeout_async"
    v0
and closure13 (v0 : int32) () : string =
    let v1 : (unit -> string) = closure5()
    let v2 : string = $"timeout: {v0} / {v1 ()}"
    v2
and closure14 (v0 : string) () : string =
    let v1 : string = $"async.run_with_timeout_async** / ex: {v0}"
    v1
and closure9 (v0 : int32, v1 : string) (v2 : int32) : Async<bool> =
    let v3 : bool = true
    let mutable _v3 : Async<bool> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v4 : Async<bool> = null |> unbox<Async<bool>>
    v4 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v5 : Async<bool> = null |> unbox<Async<bool>>
    v5 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v6 : Async<bool> = null |> unbox<Async<bool>>
    v6 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v7 : Async<bool> = null |> unbox<Async<bool>>
    v7 
    #endif
#if FABLE_COMPILER_PYTHON
    let v8 : Async<bool> = null |> unbox<Async<bool>>
    v8 
    #endif
#else
    let v9 : Async<bool> option = None
    let mutable _v9 = v9 
    async {
    let v10 : bool = true
    let mutable _v10 : Async<bool> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v11 : Async<bool> = null |> unbox<Async<bool>>
    v11 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v12 : Async<bool> = null |> unbox<Async<bool>>
    v12 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v13 : Async<bool> = null |> unbox<Async<bool>>
    v13 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v14 : Async<bool> = null |> unbox<Async<bool>>
    v14 
    #endif
#if FABLE_COMPILER_PYTHON
    let v15 : Async<bool> = null |> unbox<Async<bool>>
    v15 
    #endif
#else
    let v16 : Async<bool> option = None
    let mutable _v16 = v16 
    async {
    let v17 : Async<System.Threading.CancellationToken> = Async.CancellationToken
    let! v17 = v17 
    let v18 : System.Threading.CancellationToken = v17 
    let v19 : System.Net.Sockets.TcpClient = new System.Net.Sockets.TcpClient ()
    use v19 = v19 
    let v20 : System.Net.Sockets.TcpClient = v19 
    try
    let v21 : System.Threading.Tasks.ValueTask = v20.ConnectAsync (v1, v2, v18)
    let v22 : (unit -> System.Threading.Tasks.Task) = v21.AsTask
    let v23 : System.Threading.Tasks.Task = v22 ()
    let v24 : bool = true
    let mutable _v24 : Async<unit> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v25 : Async<unit> = null |> unbox<Async<unit>>
    v25 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v26 : Async<unit> = null |> unbox<Async<unit>>
    v26 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v27 : Async<unit> = null |> unbox<Async<unit>>
    v27 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v28 : Async<unit> = null |> unbox<Async<unit>>
    v28 
    #endif
#if FABLE_COMPILER_PYTHON
    let v29 : Async<unit> = null |> unbox<Async<unit>>
    v29 
    #endif
#else
    let v30 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
    let v31 : Async<unit> = v30 v23
    v31 
    #endif
    |> fun x -> _v24 <- Some x
    let v32 : Async<unit> = match _v24 with Some x -> x | None -> failwith "base.run_target / _v24=None"
    do! v32 
    return true 
    with ex ->
    let v33 : exn = ex
    let v34 : bool = true
    let mutable _v34 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v35 : string = $"%A{v33}"
    v35 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v36 : string = $"%A{v33}"
    v36 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v37 : string = $"%A{v33}"
    v37 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v38 : string = $"%A{v33}"
    v38 
    #endif
#if FABLE_COMPILER_PYTHON
    let v39 : string = $"%A{v33}"
    v39 
    #endif
#else
    let v40 : string = $"{v33.GetType ()}: {v33.Message}"
    v40 
    #endif
    |> fun x -> _v34 <- Some x
    let v41 : string = match _v34 with Some x -> x | None -> failwith "base.run_target / _v34=None"
    let v42 : US0 = US0_0
    let v43 : (unit -> string) = closure4(v2, v41)
    let v44 : (unit -> string) = closure5()
    method4(v42, v43, v44)
    return false 
    (*
    let v45 : bool = *)
    }
    |> fun x -> _v16 <- Some x
    let v46 : Async<bool> = match _v16 with Some x -> x | None -> failwith "async.new_async_unit / _v16=None"
    v46 
    #endif
    |> fun x -> _v10 <- Some x
    let v47 : Async<bool> = match _v10 with Some x -> x | None -> failwith "base.run_target / _v10=None"
    let v48 : bool = true
    let mutable _v48 : Async<US4> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v49 : Async<US4> = null |> unbox<Async<US4>>
    v49 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v50 : Async<US4> = null |> unbox<Async<US4>>
    v50 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v51 : Async<US4> = null |> unbox<Async<US4>>
    v51 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v52 : Async<US4> = null |> unbox<Async<US4>>
    v52 
    #endif
#if FABLE_COMPILER_PYTHON
    let v53 : Async<US4> = null |> unbox<Async<US4>>
    v53 
    #endif
#else
    let v54 : bool = true
    let mutable _v54 : Async<US4> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v55 : Async<US4> = null |> unbox<Async<US4>>
    v55 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v56 : Async<US4> = null |> unbox<Async<US4>>
    v56 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v57 : Async<US4> = null |> unbox<Async<US4>>
    v57 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v58 : Async<US4> = null |> unbox<Async<US4>>
    v58 
    #endif
#if FABLE_COMPILER_PYTHON
    let v59 : Async<US4> = null |> unbox<Async<US4>>
    v59 
    #endif
#else
    let v60 : Async<US4> option = None
    let mutable _v60 = v60 
    async {
    let v61 : bool = true
    let mutable _v61 : Async<Async<bool>> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v62 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
    v62 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v63 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
    v63 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v64 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
    v64 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v65 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
    v65 
    #endif
#if FABLE_COMPILER_PYTHON
    let v66 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
    v66 
    #endif
#else
    let v67 : Async<Async<bool>> = Async.StartChild (v47, v0)
    v67 
    #endif
    |> fun x -> _v61 <- Some x
    let v68 : Async<Async<bool>> = match _v61 with Some x -> x | None -> failwith "base.run_target / _v61=None"
    let! v68 = v68 
    let v69 : Async<bool> = v68 
    let v70 : bool = true
    let mutable _v70 : Async<Choice<bool, exn>> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v71 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
    v71 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v72 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
    v72 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v73 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
    v73 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v74 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
    v74 
    #endif
#if FABLE_COMPILER_PYTHON
    let v75 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
    v75 
    #endif
#else
    let v76 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
    let v77 : Async<Choice<bool, exn>> = v76 v69
    v77 
    #endif
    |> fun x -> _v70 <- Some x
    let v78 : Async<Choice<bool, exn>> = match _v70 with Some x -> x | None -> failwith "base.run_target / _v70=None"
    let v79 : bool = true
    let mutable _v79 : Async<US5> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v80 : Async<US5> = null |> unbox<Async<US5>>
    v80 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v81 : Async<US5> = null |> unbox<Async<US5>>
    v81 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v82 : Async<US5> = null |> unbox<Async<US5>>
    v82 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v83 : Async<US5> = null |> unbox<Async<US5>>
    v83 
    #endif
#if FABLE_COMPILER_PYTHON
    let v84 : Async<US5> = null |> unbox<Async<US5>>
    v84 
    #endif
#else
    let v85 : Async<US5> option = None
    let mutable _v85 = v85 
    async {
    let! v78 = v78 
    let v86 : Choice<bool, exn> = v78 
    let v87 : bool = true
    let mutable _v87 : US5 option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v88 : US5 = null |> unbox<US5>
    v88 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v89 : US5 = null |> unbox<US5>
    v89 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v90 : US5 = null |> unbox<US5>
    v90 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v91 : US5 = null |> unbox<US5>
    v91 
    #endif
#if FABLE_COMPILER_PYTHON
    let v92 : US5 = null |> unbox<US5>
    v92 
    #endif
#else
    let v93 : (bool -> US5) = closure10()
    let v94 : (exn -> US5) = closure11()
    let v95 : US5 = match v86 with Choice1Of2 x -> v93 x | Choice2Of2 x -> v94 x
    v95 
    #endif
    |> fun x -> _v87 <- Some x
    let v96 : US5 = match _v87 with Some x -> x | None -> failwith "base.run_target / _v87=None"
    return v96 
    }
    |> fun x -> _v85 <- Some x
    let v97 : Async<US5> = match _v85 with Some x -> x | None -> failwith "async.new_async_unit / _v85=None"
    v97 
    #endif
    |> fun x -> _v79 <- Some x
    let v98 : Async<US5> = match _v79 with Some x -> x | None -> failwith "base.run_target / _v79=None"
    let v99 : bool = true
    let mutable _v99 : Async<US6> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v100 : Async<US6> = null |> unbox<Async<US6>>
    v100 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v101 : Async<US6> = null |> unbox<Async<US6>>
    v101 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v102 : Async<US6> = null |> unbox<Async<US6>>
    v102 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v103 : Async<US6> = null |> unbox<Async<US6>>
    v103 
    #endif
#if FABLE_COMPILER_PYTHON
    let v104 : Async<US6> = null |> unbox<Async<US6>>
    v104 
    #endif
#else
    let v105 : Async<US6> option = None
    let mutable _v105 = v105 
    async {
    let! v98 = v98 
    let v106 : US5 = v98 
    let v112 : US6 =
        match v106 with
        | US5_0(v107) -> (* C1of2 *)
            US6_0(v107)
        | US5_1(v109) -> (* C2of2 *)
            US6_1(v109)
    return v112 
    }
    |> fun x -> _v105 <- Some x
    let v113 : Async<US6> = match _v105 with Some x -> x | None -> failwith "async.new_async_unit / _v105=None"
    v113 
    #endif
    |> fun x -> _v99 <- Some x
    let v114 : Async<US6> = match _v99 with Some x -> x | None -> failwith "base.run_target / _v99=None"
    let v115 : bool = true
    let mutable _v115 : Async<US4> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v116 : Async<US4> = null |> unbox<Async<US4>>
    v116 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v117 : Async<US4> = null |> unbox<Async<US4>>
    v117 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v118 : Async<US4> = null |> unbox<Async<US4>>
    v118 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v119 : Async<US4> = null |> unbox<Async<US4>>
    v119 
    #endif
#if FABLE_COMPILER_PYTHON
    let v120 : Async<US4> = null |> unbox<Async<US4>>
    v120 
    #endif
#else
    let v121 : Async<US4> option = None
    let mutable _v121 = v121 
    async {
    let! v114 = v114 
    let v122 : US6 = v114 
    let v147 : US4 =
        match v122 with
        | US6_1(v125) -> (* Error *)
            let v126 : string = $"%A{v125}"
            let v127 : string = "System.TimeoutException"
            let v128 : bool = v126.Contains v127 
            if v128 then
                let v129 : US0 = US0_1
                let v130 : (unit -> string) = closure12()
                let v131 : (unit -> string) = closure13(v0)
                method4(v129, v130, v131)
                US4_1
            else
                let v133 : bool = true
                let mutable _v133 : string option = None 
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v134 : string = $"%A{v125}"
                v134 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v135 : string = $"%A{v125}"
                v135 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v136 : string = $"%A{v125}"
                v136 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v137 : string = $"%A{v125}"
                v137 
                #endif
#if FABLE_COMPILER_PYTHON
                let v138 : string = $"%A{v125}"
                v138 
                #endif
#else
                let v139 : string = $"{v125.GetType ()}: {v125.Message}"
                v139 
                #endif
                |> fun x -> _v133 <- Some x
                let v140 : string = match _v133 with Some x -> x | None -> failwith "base.run_target / _v133=None"
                let v141 : US0 = US0_4
                let v142 : (unit -> string) = closure14(v140)
                let v143 : (unit -> string) = closure13(v0)
                method4(v141, v142, v143)
                US4_1
        | US6_0(v123) -> (* Ok *)
            US4_0(v123)
    return v147 
    }
    |> fun x -> _v121 <- Some x
    let v148 : Async<US4> = match _v121 with Some x -> x | None -> failwith "async.new_async_unit / _v121=None"
    v148 
    #endif
    |> fun x -> _v115 <- Some x
    let v149 : Async<US4> = match _v115 with Some x -> x | None -> failwith "base.run_target / _v115=None"
    return! v149 
    }
    |> fun x -> _v60 <- Some x
    let v150 : Async<US4> = match _v60 with Some x -> x | None -> failwith "async.new_async_unit / _v60=None"
    v150 
    #endif
    |> fun x -> _v54 <- Some x
    let v151 : Async<US4> = match _v54 with Some x -> x | None -> failwith "base.run_target / _v54=None"
    v151 
    #endif
    |> fun x -> _v48 <- Some x
    let v152 : Async<US4> = match _v48 with Some x -> x | None -> failwith "base.run_target / _v48=None"
    let! v152 = v152 
    let v153 : US4 = v152 
    let v156 : bool =
        match v153 with
        | US4_1 -> (* None *)
            false
        | US4_0(v154) -> (* Some *)
            v154
    return v156 
    }
    |> fun x -> _v9 <- Some x
    let v157 : Async<bool> = match _v9 with Some x -> x | None -> failwith "async.new_async_unit / _v9=None"
    v157 
    #endif
    |> fun x -> _v3 <- Some x
    let v158 : Async<bool> = match _v3 with Some x -> x | None -> failwith "base.run_target / _v3=None"
    v158
and closure8 (v0 : int32) (v1 : string) : (int32 -> Async<bool>) =
    closure9(v0, v1)
and closure7 () (v0 : int32) : (string -> (int32 -> Async<bool>)) =
    closure8(v0)
and closure19 () () : string =
    let v0 : string = "networking.wait_for_port_access"
    v0
and closure20 (v0 : int32 option, v1 : bool, v2 : int32, v3 : int64) () : string =
    let v4 : (unit -> string) = closure5()
    let v5 : string = $"port: {v2} / retry: {v3} / timeout: %A{v0} / status: {v1} / {v4 ()}"
    v5
and method10 (v0 : int32 option, v1 : bool, v2 : string, v3 : int32, v4 : int64) : Async<int64> =
    let v5 : bool = true
    let mutable _v5 : Async<int64> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v6 : Async<int64> = null |> unbox<Async<int64>>
    v6 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v7 : Async<int64> = null |> unbox<Async<int64>>
    v7 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v8 : Async<int64> = null |> unbox<Async<int64>>
    v8 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v9 : Async<int64> = null |> unbox<Async<int64>>
    v9 
    #endif
#if FABLE_COMPILER_PYTHON
    let v10 : Async<int64> = null |> unbox<Async<int64>>
    v10 
    #endif
#else
    let v11 : Async<int64> option = None
    let mutable _v11 = v11 
    async {
    let v12 : US7 option = None
    let _v12 = ref v12 
    match v0 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v13 : int32 = x
    let v14 : US7 = US7_0(v13)
    v14 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v12.Value <- x
    let v15 : US7 option = _v12.Value 
    let v16 : US7 = US7_1
    let v17 : US7 = v15 |> Option.defaultValue v16 
    let v214 : Async<bool> =
        match v17 with
        | US7_1 -> (* None *)
            let v18 : bool = true
            let mutable _v18 : Async<bool> option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v19 : Async<bool> = null |> unbox<Async<bool>>
            v19 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v20 : Async<bool> = null |> unbox<Async<bool>>
            v20 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v21 : Async<bool> = null |> unbox<Async<bool>>
            v21 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v22 : Async<bool> = null |> unbox<Async<bool>>
            v22 
            #endif
#if FABLE_COMPILER_PYTHON
            let v23 : Async<bool> = null |> unbox<Async<bool>>
            v23 
            #endif
#else
            let v24 : Async<bool> option = None
            let mutable _v24 = v24 
            async {
            let v25 : Async<System.Threading.CancellationToken> = Async.CancellationToken
            let! v25 = v25 
            let v26 : System.Threading.CancellationToken = v25 
            let v27 : System.Net.Sockets.TcpClient = new System.Net.Sockets.TcpClient ()
            use v27 = v27 
            let v28 : System.Net.Sockets.TcpClient = v27 
            try
            let v29 : System.Threading.Tasks.ValueTask = v28.ConnectAsync (v2, v3, v26)
            let v30 : (unit -> System.Threading.Tasks.Task) = v29.AsTask
            let v31 : System.Threading.Tasks.Task = v30 ()
            let v32 : bool = true
            let mutable _v32 : Async<unit> option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v33 : Async<unit> = null |> unbox<Async<unit>>
            v33 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v34 : Async<unit> = null |> unbox<Async<unit>>
            v34 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v35 : Async<unit> = null |> unbox<Async<unit>>
            v35 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v36 : Async<unit> = null |> unbox<Async<unit>>
            v36 
            #endif
#if FABLE_COMPILER_PYTHON
            let v37 : Async<unit> = null |> unbox<Async<unit>>
            v37 
            #endif
#else
            let v38 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
            let v39 : Async<unit> = v38 v31
            v39 
            #endif
            |> fun x -> _v32 <- Some x
            let v40 : Async<unit> = match _v32 with Some x -> x | None -> failwith "base.run_target / _v32=None"
            do! v40 
            return true 
            with ex ->
            let v41 : exn = ex
            let v42 : bool = true
            let mutable _v42 : string option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v43 : string = $"%A{v41}"
            v43 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v44 : string = $"%A{v41}"
            v44 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v45 : string = $"%A{v41}"
            v45 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v46 : string = $"%A{v41}"
            v46 
            #endif
#if FABLE_COMPILER_PYTHON
            let v47 : string = $"%A{v41}"
            v47 
            #endif
#else
            let v48 : string = $"{v41.GetType ()}: {v41.Message}"
            v48 
            #endif
            |> fun x -> _v42 <- Some x
            let v49 : string = match _v42 with Some x -> x | None -> failwith "base.run_target / _v42=None"
            let v50 : US0 = US0_0
            let v51 : (unit -> string) = closure4(v3, v49)
            let v52 : (unit -> string) = closure5()
            method4(v50, v51, v52)
            return false 
            (*
            let v53 : bool = *)
            }
            |> fun x -> _v24 <- Some x
            let v54 : Async<bool> = match _v24 with Some x -> x | None -> failwith "async.new_async_unit / _v24=None"
            v54 
            #endif
            |> fun x -> _v18 <- Some x
            let v55 : Async<bool> = match _v18 with Some x -> x | None -> failwith "base.run_target / _v18=None"
            v55
        | US7_0(v56) -> (* Some *)
            let v57 : bool = true
            let mutable _v57 : Async<bool> option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v58 : Async<bool> = null |> unbox<Async<bool>>
            v58 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v59 : Async<bool> = null |> unbox<Async<bool>>
            v59 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v60 : Async<bool> = null |> unbox<Async<bool>>
            v60 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v61 : Async<bool> = null |> unbox<Async<bool>>
            v61 
            #endif
#if FABLE_COMPILER_PYTHON
            let v62 : Async<bool> = null |> unbox<Async<bool>>
            v62 
            #endif
#else
            let v63 : Async<bool> option = None
            let mutable _v63 = v63 
            async {
            let v64 : bool = true
            let mutable _v64 : Async<bool> option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v65 : Async<bool> = null |> unbox<Async<bool>>
            v65 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v66 : Async<bool> = null |> unbox<Async<bool>>
            v66 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v67 : Async<bool> = null |> unbox<Async<bool>>
            v67 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v68 : Async<bool> = null |> unbox<Async<bool>>
            v68 
            #endif
#if FABLE_COMPILER_PYTHON
            let v69 : Async<bool> = null |> unbox<Async<bool>>
            v69 
            #endif
#else
            let v70 : Async<bool> option = None
            let mutable _v70 = v70 
            async {
            let v71 : Async<System.Threading.CancellationToken> = Async.CancellationToken
            let! v71 = v71 
            let v72 : System.Threading.CancellationToken = v71 
            let v73 : System.Net.Sockets.TcpClient = new System.Net.Sockets.TcpClient ()
            use v73 = v73 
            let v74 : System.Net.Sockets.TcpClient = v73 
            try
            let v75 : System.Threading.Tasks.ValueTask = v74.ConnectAsync (v2, v3, v72)
            let v76 : (unit -> System.Threading.Tasks.Task) = v75.AsTask
            let v77 : System.Threading.Tasks.Task = v76 ()
            let v78 : bool = true
            let mutable _v78 : Async<unit> option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v79 : Async<unit> = null |> unbox<Async<unit>>
            v79 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v80 : Async<unit> = null |> unbox<Async<unit>>
            v80 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v81 : Async<unit> = null |> unbox<Async<unit>>
            v81 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v82 : Async<unit> = null |> unbox<Async<unit>>
            v82 
            #endif
#if FABLE_COMPILER_PYTHON
            let v83 : Async<unit> = null |> unbox<Async<unit>>
            v83 
            #endif
#else
            let v84 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
            let v85 : Async<unit> = v84 v77
            v85 
            #endif
            |> fun x -> _v78 <- Some x
            let v86 : Async<unit> = match _v78 with Some x -> x | None -> failwith "base.run_target / _v78=None"
            do! v86 
            return true 
            with ex ->
            let v87 : exn = ex
            let v88 : bool = true
            let mutable _v88 : string option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v89 : string = $"%A{v87}"
            v89 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v90 : string = $"%A{v87}"
            v90 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v91 : string = $"%A{v87}"
            v91 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v92 : string = $"%A{v87}"
            v92 
            #endif
#if FABLE_COMPILER_PYTHON
            let v93 : string = $"%A{v87}"
            v93 
            #endif
#else
            let v94 : string = $"{v87.GetType ()}: {v87.Message}"
            v94 
            #endif
            |> fun x -> _v88 <- Some x
            let v95 : string = match _v88 with Some x -> x | None -> failwith "base.run_target / _v88=None"
            let v96 : US0 = US0_0
            let v97 : (unit -> string) = closure4(v3, v95)
            let v98 : (unit -> string) = closure5()
            method4(v96, v97, v98)
            return false 
            (*
            let v99 : bool = *)
            }
            |> fun x -> _v70 <- Some x
            let v100 : Async<bool> = match _v70 with Some x -> x | None -> failwith "async.new_async_unit / _v70=None"
            v100 
            #endif
            |> fun x -> _v64 <- Some x
            let v101 : Async<bool> = match _v64 with Some x -> x | None -> failwith "base.run_target / _v64=None"
            let v102 : bool = true
            let mutable _v102 : Async<US4> option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v103 : Async<US4> = null |> unbox<Async<US4>>
            v103 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v104 : Async<US4> = null |> unbox<Async<US4>>
            v104 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v105 : Async<US4> = null |> unbox<Async<US4>>
            v105 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v106 : Async<US4> = null |> unbox<Async<US4>>
            v106 
            #endif
#if FABLE_COMPILER_PYTHON
            let v107 : Async<US4> = null |> unbox<Async<US4>>
            v107 
            #endif
#else
            let v108 : bool = true
            let mutable _v108 : Async<US4> option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v109 : Async<US4> = null |> unbox<Async<US4>>
            v109 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v110 : Async<US4> = null |> unbox<Async<US4>>
            v110 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v111 : Async<US4> = null |> unbox<Async<US4>>
            v111 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v112 : Async<US4> = null |> unbox<Async<US4>>
            v112 
            #endif
#if FABLE_COMPILER_PYTHON
            let v113 : Async<US4> = null |> unbox<Async<US4>>
            v113 
            #endif
#else
            let v114 : Async<US4> option = None
            let mutable _v114 = v114 
            async {
            let v115 : bool = true
            let mutable _v115 : Async<Async<bool>> option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v116 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            v116 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v117 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            v117 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v118 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            v118 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v119 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            v119 
            #endif
#if FABLE_COMPILER_PYTHON
            let v120 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            v120 
            #endif
#else
            let v121 : Async<Async<bool>> = Async.StartChild (v101, v56)
            v121 
            #endif
            |> fun x -> _v115 <- Some x
            let v122 : Async<Async<bool>> = match _v115 with Some x -> x | None -> failwith "base.run_target / _v115=None"
            let! v122 = v122 
            let v123 : Async<bool> = v122 
            let v124 : bool = true
            let mutable _v124 : Async<Choice<bool, exn>> option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v125 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
            v125 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v126 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
            v126 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v127 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
            v127 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v128 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
            v128 
            #endif
#if FABLE_COMPILER_PYTHON
            let v129 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
            v129 
            #endif
#else
            let v130 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v131 : Async<Choice<bool, exn>> = v130 v123
            v131 
            #endif
            |> fun x -> _v124 <- Some x
            let v132 : Async<Choice<bool, exn>> = match _v124 with Some x -> x | None -> failwith "base.run_target / _v124=None"
            let v133 : bool = true
            let mutable _v133 : Async<US5> option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v134 : Async<US5> = null |> unbox<Async<US5>>
            v134 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v135 : Async<US5> = null |> unbox<Async<US5>>
            v135 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v136 : Async<US5> = null |> unbox<Async<US5>>
            v136 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v137 : Async<US5> = null |> unbox<Async<US5>>
            v137 
            #endif
#if FABLE_COMPILER_PYTHON
            let v138 : Async<US5> = null |> unbox<Async<US5>>
            v138 
            #endif
#else
            let v139 : Async<US5> option = None
            let mutable _v139 = v139 
            async {
            let! v132 = v132 
            let v140 : Choice<bool, exn> = v132 
            let v141 : bool = true
            let mutable _v141 : US5 option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v142 : US5 = null |> unbox<US5>
            v142 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v143 : US5 = null |> unbox<US5>
            v143 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v144 : US5 = null |> unbox<US5>
            v144 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v145 : US5 = null |> unbox<US5>
            v145 
            #endif
#if FABLE_COMPILER_PYTHON
            let v146 : US5 = null |> unbox<US5>
            v146 
            #endif
#else
            let v147 : (bool -> US5) = closure10()
            let v148 : (exn -> US5) = closure11()
            let v149 : US5 = match v140 with Choice1Of2 x -> v147 x | Choice2Of2 x -> v148 x
            v149 
            #endif
            |> fun x -> _v141 <- Some x
            let v150 : US5 = match _v141 with Some x -> x | None -> failwith "base.run_target / _v141=None"
            return v150 
            }
            |> fun x -> _v139 <- Some x
            let v151 : Async<US5> = match _v139 with Some x -> x | None -> failwith "async.new_async_unit / _v139=None"
            v151 
            #endif
            |> fun x -> _v133 <- Some x
            let v152 : Async<US5> = match _v133 with Some x -> x | None -> failwith "base.run_target / _v133=None"
            let v153 : bool = true
            let mutable _v153 : Async<US6> option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v154 : Async<US6> = null |> unbox<Async<US6>>
            v154 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v155 : Async<US6> = null |> unbox<Async<US6>>
            v155 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v156 : Async<US6> = null |> unbox<Async<US6>>
            v156 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v157 : Async<US6> = null |> unbox<Async<US6>>
            v157 
            #endif
#if FABLE_COMPILER_PYTHON
            let v158 : Async<US6> = null |> unbox<Async<US6>>
            v158 
            #endif
#else
            let v159 : Async<US6> option = None
            let mutable _v159 = v159 
            async {
            let! v152 = v152 
            let v160 : US5 = v152 
            let v166 : US6 =
                match v160 with
                | US5_0(v161) -> (* C1of2 *)
                    US6_0(v161)
                | US5_1(v163) -> (* C2of2 *)
                    US6_1(v163)
            return v166 
            }
            |> fun x -> _v159 <- Some x
            let v167 : Async<US6> = match _v159 with Some x -> x | None -> failwith "async.new_async_unit / _v159=None"
            v167 
            #endif
            |> fun x -> _v153 <- Some x
            let v168 : Async<US6> = match _v153 with Some x -> x | None -> failwith "base.run_target / _v153=None"
            let v169 : bool = true
            let mutable _v169 : Async<US4> option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v170 : Async<US4> = null |> unbox<Async<US4>>
            v170 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v171 : Async<US4> = null |> unbox<Async<US4>>
            v171 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v172 : Async<US4> = null |> unbox<Async<US4>>
            v172 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v173 : Async<US4> = null |> unbox<Async<US4>>
            v173 
            #endif
#if FABLE_COMPILER_PYTHON
            let v174 : Async<US4> = null |> unbox<Async<US4>>
            v174 
            #endif
#else
            let v175 : Async<US4> option = None
            let mutable _v175 = v175 
            async {
            let! v168 = v168 
            let v176 : US6 = v168 
            let v201 : US4 =
                match v176 with
                | US6_1(v179) -> (* Error *)
                    let v180 : string = $"%A{v179}"
                    let v181 : string = "System.TimeoutException"
                    let v182 : bool = v180.Contains v181 
                    if v182 then
                        let v183 : US0 = US0_1
                        let v184 : (unit -> string) = closure12()
                        let v185 : (unit -> string) = closure13(v56)
                        method4(v183, v184, v185)
                        US4_1
                    else
                        let v187 : bool = true
                        let mutable _v187 : string option = None 
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v188 : string = $"%A{v179}"
                        v188 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        let v189 : string = $"%A{v179}"
                        v189 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        let v190 : string = $"%A{v179}"
                        v190 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        let v191 : string = $"%A{v179}"
                        v191 
                        #endif
#if FABLE_COMPILER_PYTHON
                        let v192 : string = $"%A{v179}"
                        v192 
                        #endif
#else
                        let v193 : string = $"{v179.GetType ()}: {v179.Message}"
                        v193 
                        #endif
                        |> fun x -> _v187 <- Some x
                        let v194 : string = match _v187 with Some x -> x | None -> failwith "base.run_target / _v187=None"
                        let v195 : US0 = US0_4
                        let v196 : (unit -> string) = closure14(v194)
                        let v197 : (unit -> string) = closure13(v56)
                        method4(v195, v196, v197)
                        US4_1
                | US6_0(v177) -> (* Ok *)
                    US4_0(v177)
            return v201 
            }
            |> fun x -> _v175 <- Some x
            let v202 : Async<US4> = match _v175 with Some x -> x | None -> failwith "async.new_async_unit / _v175=None"
            v202 
            #endif
            |> fun x -> _v169 <- Some x
            let v203 : Async<US4> = match _v169 with Some x -> x | None -> failwith "base.run_target / _v169=None"
            return! v203 
            }
            |> fun x -> _v114 <- Some x
            let v204 : Async<US4> = match _v114 with Some x -> x | None -> failwith "async.new_async_unit / _v114=None"
            v204 
            #endif
            |> fun x -> _v108 <- Some x
            let v205 : Async<US4> = match _v108 with Some x -> x | None -> failwith "base.run_target / _v108=None"
            v205 
            #endif
            |> fun x -> _v102 <- Some x
            let v206 : Async<US4> = match _v102 with Some x -> x | None -> failwith "base.run_target / _v102=None"
            let! v206 = v206 
            let v207 : US4 = v206 
            let v210 : bool =
                match v207 with
                | US4_1 -> (* None *)
                    false
                | US4_0(v208) -> (* Some *)
                    v208
            return v210 
            }
            |> fun x -> _v63 <- Some x
            let v211 : Async<bool> = match _v63 with Some x -> x | None -> failwith "async.new_async_unit / _v63=None"
            v211 
            #endif
            |> fun x -> _v57 <- Some x
            let v212 : Async<bool> = match _v57 with Some x -> x | None -> failwith "base.run_target / _v57=None"
            v212
    let! v214 = v214 
    let v215 : bool = v214 
    let v216 : bool = v215 = v1
    if v216 then
        return v4 
        (*
        ()
    else
        *) else
        let v217 : int64 = v4 % 100L
        let v218 : bool = v217 = 0L
        if v218 then
            let v219 : US0 = US0_0
            let v220 : (unit -> string) = closure19()
            let v221 : (unit -> string) = closure20(v0, v1, v3, v4)
            method4(v219, v220, v221)
        let v222 : bool = true
        let mutable _v222 : Async<unit> option = None 
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v223 : Async<unit> = null |> unbox<Async<unit>>
        v223 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v224 : Async<unit> = null |> unbox<Async<unit>>
        v224 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v225 : Async<unit> = null |> unbox<Async<unit>>
        v225 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v226 : Async<unit> = null |> unbox<Async<unit>>
        v226 
        #endif
#if FABLE_COMPILER_PYTHON
        let v227 : Async<unit> = null |> unbox<Async<unit>>
        v227 
        #endif
#else
        let v228 : (int32 -> Async<unit>) = Async.Sleep
        let v229 : Async<unit> = v228 10
        v229 
        #endif
        |> fun x -> _v222 <- Some x
        let v230 : Async<unit> = match _v222 with Some x -> x | None -> failwith "base.run_target / _v222=None"
        do! v230 
        let v231 : int64 = v4 + 1L
        let v232 : Async<int64> = method10(v0, v1, v2, v3, v231)
        return! v232 
        (*
        ()
    *)
    }
    |> fun x -> _v11 <- Some x
    let v233 : Async<int64> = match _v11 with Some x -> x | None -> failwith "async.new_async_unit / _v11=None"
    v233 
    #endif
    |> fun x -> _v5 <- Some x
    let v234 : Async<int64> = match _v5 with Some x -> x | None -> failwith "base.run_target / _v5=None"
    v234
and closure18 (v0 : int32 option, v1 : bool, v2 : string) (v3 : int32) : Async<int64> =
    let v4 : int64 = 0L
    method10(v0, v1, v2, v3, v4)
and closure17 (v0 : int32 option, v1 : bool) (v2 : string) : (int32 -> Async<int64>) =
    closure18(v0, v1, v2)
and closure16 (v0 : int32 option) (v1 : bool) : (string -> (int32 -> Async<int64>)) =
    closure17(v0, v1)
and closure15 () (v0 : int32 option) : (bool -> (string -> (int32 -> Async<int64>))) =
    closure16(v0)
and method11 (v0 : int32 option, v1 : string, v2 : int32) : Async<int32> =
    let v3 : bool = true
    let mutable _v3 : Async<int32> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v4 : Async<int32> = null |> unbox<Async<int32>>
    v4 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v5 : Async<int32> = null |> unbox<Async<int32>>
    v5 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v6 : Async<int32> = null |> unbox<Async<int32>>
    v6 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v7 : Async<int32> = null |> unbox<Async<int32>>
    v7 
    #endif
#if FABLE_COMPILER_PYTHON
    let v8 : Async<int32> = null |> unbox<Async<int32>>
    v8 
    #endif
#else
    let v9 : Async<int32> option = None
    let mutable _v9 = v9 
    async {
    let v10 : US7 option = None
    let _v10 = ref v10 
    match v0 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v11 : int32 = x
    let v12 : US7 = US7_0(v11)
    v12 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v10.Value <- x
    let v13 : US7 option = _v10.Value 
    let v14 : US7 = US7_1
    let v15 : US7 = v13 |> Option.defaultValue v14 
    let v212 : Async<bool> =
        match v15 with
        | US7_1 -> (* None *)
            let v16 : bool = true
            let mutable _v16 : Async<bool> option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v17 : Async<bool> = null |> unbox<Async<bool>>
            v17 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v18 : Async<bool> = null |> unbox<Async<bool>>
            v18 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v19 : Async<bool> = null |> unbox<Async<bool>>
            v19 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v20 : Async<bool> = null |> unbox<Async<bool>>
            v20 
            #endif
#if FABLE_COMPILER_PYTHON
            let v21 : Async<bool> = null |> unbox<Async<bool>>
            v21 
            #endif
#else
            let v22 : Async<bool> option = None
            let mutable _v22 = v22 
            async {
            let v23 : Async<System.Threading.CancellationToken> = Async.CancellationToken
            let! v23 = v23 
            let v24 : System.Threading.CancellationToken = v23 
            let v25 : System.Net.Sockets.TcpClient = new System.Net.Sockets.TcpClient ()
            use v25 = v25 
            let v26 : System.Net.Sockets.TcpClient = v25 
            try
            let v27 : System.Threading.Tasks.ValueTask = v26.ConnectAsync (v1, v2, v24)
            let v28 : (unit -> System.Threading.Tasks.Task) = v27.AsTask
            let v29 : System.Threading.Tasks.Task = v28 ()
            let v30 : bool = true
            let mutable _v30 : Async<unit> option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v31 : Async<unit> = null |> unbox<Async<unit>>
            v31 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v32 : Async<unit> = null |> unbox<Async<unit>>
            v32 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v33 : Async<unit> = null |> unbox<Async<unit>>
            v33 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v34 : Async<unit> = null |> unbox<Async<unit>>
            v34 
            #endif
#if FABLE_COMPILER_PYTHON
            let v35 : Async<unit> = null |> unbox<Async<unit>>
            v35 
            #endif
#else
            let v36 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
            let v37 : Async<unit> = v36 v29
            v37 
            #endif
            |> fun x -> _v30 <- Some x
            let v38 : Async<unit> = match _v30 with Some x -> x | None -> failwith "base.run_target / _v30=None"
            do! v38 
            return true 
            with ex ->
            let v39 : exn = ex
            let v40 : bool = true
            let mutable _v40 : string option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v41 : string = $"%A{v39}"
            v41 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v42 : string = $"%A{v39}"
            v42 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v43 : string = $"%A{v39}"
            v43 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v44 : string = $"%A{v39}"
            v44 
            #endif
#if FABLE_COMPILER_PYTHON
            let v45 : string = $"%A{v39}"
            v45 
            #endif
#else
            let v46 : string = $"{v39.GetType ()}: {v39.Message}"
            v46 
            #endif
            |> fun x -> _v40 <- Some x
            let v47 : string = match _v40 with Some x -> x | None -> failwith "base.run_target / _v40=None"
            let v48 : US0 = US0_0
            let v49 : (unit -> string) = closure4(v2, v47)
            let v50 : (unit -> string) = closure5()
            method4(v48, v49, v50)
            return false 
            (*
            let v51 : bool = *)
            }
            |> fun x -> _v22 <- Some x
            let v52 : Async<bool> = match _v22 with Some x -> x | None -> failwith "async.new_async_unit / _v22=None"
            v52 
            #endif
            |> fun x -> _v16 <- Some x
            let v53 : Async<bool> = match _v16 with Some x -> x | None -> failwith "base.run_target / _v16=None"
            v53
        | US7_0(v54) -> (* Some *)
            let v55 : bool = true
            let mutable _v55 : Async<bool> option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v56 : Async<bool> = null |> unbox<Async<bool>>
            v56 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v57 : Async<bool> = null |> unbox<Async<bool>>
            v57 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v58 : Async<bool> = null |> unbox<Async<bool>>
            v58 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v59 : Async<bool> = null |> unbox<Async<bool>>
            v59 
            #endif
#if FABLE_COMPILER_PYTHON
            let v60 : Async<bool> = null |> unbox<Async<bool>>
            v60 
            #endif
#else
            let v61 : Async<bool> option = None
            let mutable _v61 = v61 
            async {
            let v62 : bool = true
            let mutable _v62 : Async<bool> option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v63 : Async<bool> = null |> unbox<Async<bool>>
            v63 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v64 : Async<bool> = null |> unbox<Async<bool>>
            v64 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v65 : Async<bool> = null |> unbox<Async<bool>>
            v65 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v66 : Async<bool> = null |> unbox<Async<bool>>
            v66 
            #endif
#if FABLE_COMPILER_PYTHON
            let v67 : Async<bool> = null |> unbox<Async<bool>>
            v67 
            #endif
#else
            let v68 : Async<bool> option = None
            let mutable _v68 = v68 
            async {
            let v69 : Async<System.Threading.CancellationToken> = Async.CancellationToken
            let! v69 = v69 
            let v70 : System.Threading.CancellationToken = v69 
            let v71 : System.Net.Sockets.TcpClient = new System.Net.Sockets.TcpClient ()
            use v71 = v71 
            let v72 : System.Net.Sockets.TcpClient = v71 
            try
            let v73 : System.Threading.Tasks.ValueTask = v72.ConnectAsync (v1, v2, v70)
            let v74 : (unit -> System.Threading.Tasks.Task) = v73.AsTask
            let v75 : System.Threading.Tasks.Task = v74 ()
            let v76 : bool = true
            let mutable _v76 : Async<unit> option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v77 : Async<unit> = null |> unbox<Async<unit>>
            v77 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v78 : Async<unit> = null |> unbox<Async<unit>>
            v78 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v79 : Async<unit> = null |> unbox<Async<unit>>
            v79 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v80 : Async<unit> = null |> unbox<Async<unit>>
            v80 
            #endif
#if FABLE_COMPILER_PYTHON
            let v81 : Async<unit> = null |> unbox<Async<unit>>
            v81 
            #endif
#else
            let v82 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
            let v83 : Async<unit> = v82 v75
            v83 
            #endif
            |> fun x -> _v76 <- Some x
            let v84 : Async<unit> = match _v76 with Some x -> x | None -> failwith "base.run_target / _v76=None"
            do! v84 
            return true 
            with ex ->
            let v85 : exn = ex
            let v86 : bool = true
            let mutable _v86 : string option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v87 : string = $"%A{v85}"
            v87 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v88 : string = $"%A{v85}"
            v88 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v89 : string = $"%A{v85}"
            v89 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v90 : string = $"%A{v85}"
            v90 
            #endif
#if FABLE_COMPILER_PYTHON
            let v91 : string = $"%A{v85}"
            v91 
            #endif
#else
            let v92 : string = $"{v85.GetType ()}: {v85.Message}"
            v92 
            #endif
            |> fun x -> _v86 <- Some x
            let v93 : string = match _v86 with Some x -> x | None -> failwith "base.run_target / _v86=None"
            let v94 : US0 = US0_0
            let v95 : (unit -> string) = closure4(v2, v93)
            let v96 : (unit -> string) = closure5()
            method4(v94, v95, v96)
            return false 
            (*
            let v97 : bool = *)
            }
            |> fun x -> _v68 <- Some x
            let v98 : Async<bool> = match _v68 with Some x -> x | None -> failwith "async.new_async_unit / _v68=None"
            v98 
            #endif
            |> fun x -> _v62 <- Some x
            let v99 : Async<bool> = match _v62 with Some x -> x | None -> failwith "base.run_target / _v62=None"
            let v100 : bool = true
            let mutable _v100 : Async<US4> option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v101 : Async<US4> = null |> unbox<Async<US4>>
            v101 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v102 : Async<US4> = null |> unbox<Async<US4>>
            v102 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v103 : Async<US4> = null |> unbox<Async<US4>>
            v103 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v104 : Async<US4> = null |> unbox<Async<US4>>
            v104 
            #endif
#if FABLE_COMPILER_PYTHON
            let v105 : Async<US4> = null |> unbox<Async<US4>>
            v105 
            #endif
#else
            let v106 : bool = true
            let mutable _v106 : Async<US4> option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v107 : Async<US4> = null |> unbox<Async<US4>>
            v107 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v108 : Async<US4> = null |> unbox<Async<US4>>
            v108 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v109 : Async<US4> = null |> unbox<Async<US4>>
            v109 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v110 : Async<US4> = null |> unbox<Async<US4>>
            v110 
            #endif
#if FABLE_COMPILER_PYTHON
            let v111 : Async<US4> = null |> unbox<Async<US4>>
            v111 
            #endif
#else
            let v112 : Async<US4> option = None
            let mutable _v112 = v112 
            async {
            let v113 : bool = true
            let mutable _v113 : Async<Async<bool>> option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v114 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            v114 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v115 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            v115 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v116 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            v116 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v117 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            v117 
            #endif
#if FABLE_COMPILER_PYTHON
            let v118 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            v118 
            #endif
#else
            let v119 : Async<Async<bool>> = Async.StartChild (v99, v54)
            v119 
            #endif
            |> fun x -> _v113 <- Some x
            let v120 : Async<Async<bool>> = match _v113 with Some x -> x | None -> failwith "base.run_target / _v113=None"
            let! v120 = v120 
            let v121 : Async<bool> = v120 
            let v122 : bool = true
            let mutable _v122 : Async<Choice<bool, exn>> option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v123 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
            v123 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v124 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
            v124 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v125 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
            v125 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v126 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
            v126 
            #endif
#if FABLE_COMPILER_PYTHON
            let v127 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
            v127 
            #endif
#else
            let v128 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v129 : Async<Choice<bool, exn>> = v128 v121
            v129 
            #endif
            |> fun x -> _v122 <- Some x
            let v130 : Async<Choice<bool, exn>> = match _v122 with Some x -> x | None -> failwith "base.run_target / _v122=None"
            let v131 : bool = true
            let mutable _v131 : Async<US5> option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v132 : Async<US5> = null |> unbox<Async<US5>>
            v132 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v133 : Async<US5> = null |> unbox<Async<US5>>
            v133 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v134 : Async<US5> = null |> unbox<Async<US5>>
            v134 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v135 : Async<US5> = null |> unbox<Async<US5>>
            v135 
            #endif
#if FABLE_COMPILER_PYTHON
            let v136 : Async<US5> = null |> unbox<Async<US5>>
            v136 
            #endif
#else
            let v137 : Async<US5> option = None
            let mutable _v137 = v137 
            async {
            let! v130 = v130 
            let v138 : Choice<bool, exn> = v130 
            let v139 : bool = true
            let mutable _v139 : US5 option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v140 : US5 = null |> unbox<US5>
            v140 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v141 : US5 = null |> unbox<US5>
            v141 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v142 : US5 = null |> unbox<US5>
            v142 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v143 : US5 = null |> unbox<US5>
            v143 
            #endif
#if FABLE_COMPILER_PYTHON
            let v144 : US5 = null |> unbox<US5>
            v144 
            #endif
#else
            let v145 : (bool -> US5) = closure10()
            let v146 : (exn -> US5) = closure11()
            let v147 : US5 = match v138 with Choice1Of2 x -> v145 x | Choice2Of2 x -> v146 x
            v147 
            #endif
            |> fun x -> _v139 <- Some x
            let v148 : US5 = match _v139 with Some x -> x | None -> failwith "base.run_target / _v139=None"
            return v148 
            }
            |> fun x -> _v137 <- Some x
            let v149 : Async<US5> = match _v137 with Some x -> x | None -> failwith "async.new_async_unit / _v137=None"
            v149 
            #endif
            |> fun x -> _v131 <- Some x
            let v150 : Async<US5> = match _v131 with Some x -> x | None -> failwith "base.run_target / _v131=None"
            let v151 : bool = true
            let mutable _v151 : Async<US6> option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v152 : Async<US6> = null |> unbox<Async<US6>>
            v152 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v153 : Async<US6> = null |> unbox<Async<US6>>
            v153 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v154 : Async<US6> = null |> unbox<Async<US6>>
            v154 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v155 : Async<US6> = null |> unbox<Async<US6>>
            v155 
            #endif
#if FABLE_COMPILER_PYTHON
            let v156 : Async<US6> = null |> unbox<Async<US6>>
            v156 
            #endif
#else
            let v157 : Async<US6> option = None
            let mutable _v157 = v157 
            async {
            let! v150 = v150 
            let v158 : US5 = v150 
            let v164 : US6 =
                match v158 with
                | US5_0(v159) -> (* C1of2 *)
                    US6_0(v159)
                | US5_1(v161) -> (* C2of2 *)
                    US6_1(v161)
            return v164 
            }
            |> fun x -> _v157 <- Some x
            let v165 : Async<US6> = match _v157 with Some x -> x | None -> failwith "async.new_async_unit / _v157=None"
            v165 
            #endif
            |> fun x -> _v151 <- Some x
            let v166 : Async<US6> = match _v151 with Some x -> x | None -> failwith "base.run_target / _v151=None"
            let v167 : bool = true
            let mutable _v167 : Async<US4> option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v168 : Async<US4> = null |> unbox<Async<US4>>
            v168 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v169 : Async<US4> = null |> unbox<Async<US4>>
            v169 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v170 : Async<US4> = null |> unbox<Async<US4>>
            v170 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v171 : Async<US4> = null |> unbox<Async<US4>>
            v171 
            #endif
#if FABLE_COMPILER_PYTHON
            let v172 : Async<US4> = null |> unbox<Async<US4>>
            v172 
            #endif
#else
            let v173 : Async<US4> option = None
            let mutable _v173 = v173 
            async {
            let! v166 = v166 
            let v174 : US6 = v166 
            let v199 : US4 =
                match v174 with
                | US6_1(v177) -> (* Error *)
                    let v178 : string = $"%A{v177}"
                    let v179 : string = "System.TimeoutException"
                    let v180 : bool = v178.Contains v179 
                    if v180 then
                        let v181 : US0 = US0_1
                        let v182 : (unit -> string) = closure12()
                        let v183 : (unit -> string) = closure13(v54)
                        method4(v181, v182, v183)
                        US4_1
                    else
                        let v185 : bool = true
                        let mutable _v185 : string option = None 
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v186 : string = $"%A{v177}"
                        v186 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        let v187 : string = $"%A{v177}"
                        v187 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        let v188 : string = $"%A{v177}"
                        v188 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        let v189 : string = $"%A{v177}"
                        v189 
                        #endif
#if FABLE_COMPILER_PYTHON
                        let v190 : string = $"%A{v177}"
                        v190 
                        #endif
#else
                        let v191 : string = $"{v177.GetType ()}: {v177.Message}"
                        v191 
                        #endif
                        |> fun x -> _v185 <- Some x
                        let v192 : string = match _v185 with Some x -> x | None -> failwith "base.run_target / _v185=None"
                        let v193 : US0 = US0_4
                        let v194 : (unit -> string) = closure14(v192)
                        let v195 : (unit -> string) = closure13(v54)
                        method4(v193, v194, v195)
                        US4_1
                | US6_0(v175) -> (* Ok *)
                    US4_0(v175)
            return v199 
            }
            |> fun x -> _v173 <- Some x
            let v200 : Async<US4> = match _v173 with Some x -> x | None -> failwith "async.new_async_unit / _v173=None"
            v200 
            #endif
            |> fun x -> _v167 <- Some x
            let v201 : Async<US4> = match _v167 with Some x -> x | None -> failwith "base.run_target / _v167=None"
            return! v201 
            }
            |> fun x -> _v112 <- Some x
            let v202 : Async<US4> = match _v112 with Some x -> x | None -> failwith "async.new_async_unit / _v112=None"
            v202 
            #endif
            |> fun x -> _v106 <- Some x
            let v203 : Async<US4> = match _v106 with Some x -> x | None -> failwith "base.run_target / _v106=None"
            v203 
            #endif
            |> fun x -> _v100 <- Some x
            let v204 : Async<US4> = match _v100 with Some x -> x | None -> failwith "base.run_target / _v100=None"
            let! v204 = v204 
            let v205 : US4 = v204 
            let v208 : bool =
                match v205 with
                | US4_1 -> (* None *)
                    false
                | US4_0(v206) -> (* Some *)
                    v206
            return v208 
            }
            |> fun x -> _v61 <- Some x
            let v209 : Async<bool> = match _v61 with Some x -> x | None -> failwith "async.new_async_unit / _v61=None"
            v209 
            #endif
            |> fun x -> _v55 <- Some x
            let v210 : Async<bool> = match _v55 with Some x -> x | None -> failwith "base.run_target / _v55=None"
            v210
    let! v212 = v212 
    let v213 : bool = v212 
    let v214 : bool = v213 = false
    if v214 then
        return v2 
        (*
        ()
    else
        *) else
        let v215 : int32 = v2 + 1
        let v216 : Async<int32> = method11(v0, v1, v215)
        return! v216 
        (*
        ()
    *)
    }
    |> fun x -> _v9 <- Some x
    let v217 : Async<int32> = match _v9 with Some x -> x | None -> failwith "async.new_async_unit / _v9=None"
    v217 
    #endif
    |> fun x -> _v3 <- Some x
    let v218 : Async<int32> = match _v3 with Some x -> x | None -> failwith "base.run_target / _v3=None"
    v218
and closure23 (v0 : int32 option, v1 : string) (v2 : int32) : Async<int32> =
    method11(v0, v1, v2)
and closure22 (v0 : int32 option) (v1 : string) : (int32 -> Async<int32>) =
    closure23(v0, v1)
and closure21 () (v0 : int32 option) : (string -> (int32 -> Async<int32>)) =
    closure22(v0)
let v0 : (US0 -> struct (Mut0 * Mut1 * Mut2 * int64 option * Mut3)) = closure0()
let v1 : US0 = US0_0
if State.trace_state.IsNone then State.trace_state <- v0 v1 |> Some
let v2 : (string -> (int32 -> Async<bool>)) = closure2()
let test_port_open x = v2 x
let v3 : (int32 -> (string -> (int32 -> Async<bool>))) = closure7()
let test_port_open_timeout x = v3 x
let v4 : (int32 option -> (bool -> (string -> (int32 -> Async<int64>)))) = closure15()
let wait_for_port_access x = v4 x
let v5 : (int32 option -> (string -> (int32 -> Async<int32>))) = closure21()
let get_available_port x = v5 x
()
