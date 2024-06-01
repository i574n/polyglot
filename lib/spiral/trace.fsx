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
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::env::VarError")>]
#endif
type std_env_VarError = class end
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
    let v47 : string = "process.env[$0]"
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
    v54 
    #endif
#else
    let v55 : (string -> string) = System.Environment.GetEnvironmentVariable
    let v56 : string = v55 v0
    let mutable _v56 = None
    #if !FABLE_COMPILER && !WASM && !CONTRACT
    let v57 : (string -> string option) = Option.ofObj
    let v58 : string option = v57 v56
    v58 
    #else
    Some v56 
    #endif
    |> fun x -> _v56 <- Some x
    let v59 : string option = match _v56 with Some x -> x | None -> failwith "optionm'.of_obj / _v56=None"
    let v60 : US3 option = None
    let _v60 = ref v60 
    match v59 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v61 : string = x
    let v62 : US3 = US3_0(v61)
    v62 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v60.Value <- x
    let v63 : US3 option = _v60.Value 
    let v64 : US3 = US3_1
    let v65 : US3 = v63 |> Option.defaultValue v64 
    let v69 : string =
        match v65 with
        | US3_1 -> (* None *)
            let v67 : string = ""
            v67
        | US3_0(v66) -> (* Some *)
            v66
    v69 
    #endif
    |> fun x -> _v1 <- Some x
    let v70 : string = match _v1 with Some x -> x | None -> failwith "base.run_target / _v1=None"
    v70
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
    let v4 : bool = "Verbose" = v3
    let v24 : US2 =
        if v4 then
            let v5 : US0 = US0_0
            US2_0(v5)
        else
            let v7 : bool = "Debug" = v3
            if v7 then
                let v8 : US0 = US0_1
                US2_0(v8)
            else
                let v10 : bool = "Info" = v3
                if v10 then
                    let v11 : US0 = US0_2
                    US2_0(v11)
                else
                    let v13 : bool = "Warning" = v3
                    if v13 then
                        let v14 : US0 = US0_3
                        US2_0(v14)
                    else
                        let v16 : bool = "Critical" = v3
                        if v16 then
                            let v17 : US0 = US0_4
                            US2_0(v17)
                        else
                            US2_1
    let v25 : string = method3()
    let v26 : string = method1(v25)
    let v28 : bool = v26 = "True"
    let v34 : US1 =
        if v28 then
            let v29 : System.DateTime = System.DateTime.Now
            let v30 : (System.DateTime -> int64) = _.Ticks
            let v31 : int64 = v30 v29
            US1_0(v31)
        else
            US1_1
    struct (v34, v24) 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v35 : US1 = US1_1
    let v36 : US2 = US2_1
    struct (v35, v36) 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v37 : US1 = US1_1
    let v38 : US2 = US2_1
    struct (v37, v38) 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v39 : string = method0()
    let v40 : string = method1(v39)
    let v41 : bool = "Verbose" = v40
    let v61 : US2 =
        if v41 then
            let v42 : US0 = US0_0
            US2_0(v42)
        else
            let v44 : bool = "Debug" = v40
            if v44 then
                let v45 : US0 = US0_1
                US2_0(v45)
            else
                let v47 : bool = "Info" = v40
                if v47 then
                    let v48 : US0 = US0_2
                    US2_0(v48)
                else
                    let v50 : bool = "Warning" = v40
                    if v50 then
                        let v51 : US0 = US0_3
                        US2_0(v51)
                    else
                        let v53 : bool = "Critical" = v40
                        if v53 then
                            let v54 : US0 = US0_4
                            US2_0(v54)
                        else
                            US2_1
    let v62 : string = method3()
    let v63 : string = method1(v62)
    let v65 : bool = v63 = "True"
    let v71 : US1 =
        if v65 then
            let v66 : System.DateTime = System.DateTime.Now
            let v67 : (System.DateTime -> int64) = _.Ticks
            let v68 : int64 = v67 v66
            US1_0(v68)
        else
            US1_1
    struct (v71, v61) 
    #endif
#if FABLE_COMPILER_PYTHON
    let v72 : string = method0()
    let v73 : string = method1(v72)
    let v74 : bool = "Verbose" = v73
    let v94 : US2 =
        if v74 then
            let v75 : US0 = US0_0
            US2_0(v75)
        else
            let v77 : bool = "Debug" = v73
            if v77 then
                let v78 : US0 = US0_1
                US2_0(v78)
            else
                let v80 : bool = "Info" = v73
                if v80 then
                    let v81 : US0 = US0_2
                    US2_0(v81)
                else
                    let v83 : bool = "Warning" = v73
                    if v83 then
                        let v84 : US0 = US0_3
                        US2_0(v84)
                    else
                        let v86 : bool = "Critical" = v73
                        if v86 then
                            let v87 : US0 = US0_4
                            US2_0(v87)
                        else
                            US2_1
    let v95 : string = method3()
    let v96 : string = method1(v95)
    let v98 : bool = v96 = "True"
    let v104 : US1 =
        if v98 then
            let v99 : System.DateTime = System.DateTime.Now
            let v100 : (System.DateTime -> int64) = _.Ticks
            let v101 : int64 = v100 v99
            US1_0(v101)
        else
            US1_1
    struct (v104, v94) 
    #endif
#else
    let v105 : string = method0()
    let v106 : string = method1(v105)
    let v107 : bool = "Verbose" = v106
    let v127 : US2 =
        if v107 then
            let v108 : US0 = US0_0
            US2_0(v108)
        else
            let v110 : bool = "Debug" = v106
            if v110 then
                let v111 : US0 = US0_1
                US2_0(v111)
            else
                let v113 : bool = "Info" = v106
                if v113 then
                    let v114 : US0 = US0_2
                    US2_0(v114)
                else
                    let v116 : bool = "Warning" = v106
                    if v116 then
                        let v117 : US0 = US0_3
                        US2_0(v117)
                    else
                        let v119 : bool = "Critical" = v106
                        if v119 then
                            let v120 : US0 = US0_4
                            US2_0(v120)
                        else
                            US2_1
    let v128 : string = method3()
    let v129 : string = method1(v128)
    let v131 : bool = v129 = "True"
    let v137 : US1 =
        if v131 then
            let v132 : System.DateTime = System.DateTime.Now
            let v133 : (System.DateTime -> int64) = _.Ticks
            let v134 : int64 = v133 v132
            US1_0(v134)
        else
            US1_1
    struct (v137, v127) 
    #endif
    |> fun x -> _v1 <- Some x
    let struct (v138 : US1, v139 : US2) = match _v1 with Some x -> x | None -> failwith "base.run_target / _v1=None"
    let v140 : Mut1 = {l0 = true} : Mut1
    let v141 : Mut0 = {l0 = 0L} : Mut0
    let v144 : US0 =
        match v139 with
        | US2_1 -> (* None *)
            v0
        | US2_0(v142) -> (* Some *)
            v142
    let v145 : Mut2 = {l0 = v144} : Mut2
    let v146 : (string -> unit) = closure1()
    let v147 : Mut3 = {l0 = v146} : Mut3
    let v152 : int64 option =
        match v138 with
        | US1_1 -> (* None *)
            let v150 : int64 option = None
            v150
        | US1_0(v148) -> (* Some *)
            let v149 : int64 option = Some v148 
            v149
    struct (v141, v140, v145, v152, v147)
and method5 () : string =
    let v0 : string = "hh:mm:ss"
    v0
and method6 () : string =
    let v0 : string = ""
    v0
and method7 () : string =
    let v0 : string = "HH:mm:ss"
    v0
and closure5 (v0 : US0, v1 : (unit -> string), v2 : (unit -> string)) () : string =
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
    let v37 : string = v35.ToString v36 
    v37 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v38 : US1 option = None
    let _v38 = ref v38 
    match v8 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v39 : int64 = x
    let v40 : US1 = US1_0(v39)
    v40 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v38.Value <- x
    let v41 : US1 option = _v38.Value 
    let v42 : US1 = US1_1
    let v43 : US1 = v41 |> Option.defaultValue v42 
    let v62 : System.DateTime =
        match v43 with
        | US1_1 -> (* None *)
            let v60 : System.DateTime = System.DateTime.Now
            v60
        | US1_0(v44) -> (* Some *)
            let v45 : System.DateTime = System.DateTime.Now
            let v46 : (System.DateTime -> int64) = _.Ticks
            let v47 : int64 = v46 v45
            let v48 : int64 = v47 - v44
            let v49 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v50 : System.TimeSpan = v49 v48
            let v51 : (System.TimeSpan -> int32) = _.Hours
            let v52 : int32 = v51 v50
            let v53 : (System.TimeSpan -> int32) = _.Minutes
            let v54 : int32 = v53 v50
            let v55 : (System.TimeSpan -> int32) = _.Seconds
            let v56 : int32 = v55 v50
            let v57 : (System.TimeSpan -> int32) = _.Milliseconds
            let v58 : int32 = v57 v50
            let v59 : System.DateTime = System.DateTime (1, 1, 1, v52, v54, v56, v58)
            v59
    let v63 : string = method5()
    let v64 : string = v62.ToString v63 
    v64 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v65 : string = method6()
    v65 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v66 : US1 option = None
    let _v66 = ref v66 
    match v8 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v67 : int64 = x
    let v68 : US1 = US1_0(v67)
    v68 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v66.Value <- x
    let v69 : US1 option = _v66.Value 
    let v70 : US1 = US1_1
    let v71 : US1 = v69 |> Option.defaultValue v70 
    let v90 : System.DateTime =
        match v71 with
        | US1_1 -> (* None *)
            let v88 : System.DateTime = System.DateTime.Now
            v88
        | US1_0(v72) -> (* Some *)
            let v73 : System.DateTime = System.DateTime.Now
            let v74 : (System.DateTime -> int64) = _.Ticks
            let v75 : int64 = v74 v73
            let v76 : int64 = v75 - v72
            let v77 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v78 : System.TimeSpan = v77 v76
            let v79 : (System.TimeSpan -> int32) = _.Hours
            let v80 : int32 = v79 v78
            let v81 : (System.TimeSpan -> int32) = _.Minutes
            let v82 : int32 = v81 v78
            let v83 : (System.TimeSpan -> int32) = _.Seconds
            let v84 : int32 = v83 v78
            let v85 : (System.TimeSpan -> int32) = _.Milliseconds
            let v86 : int32 = v85 v78
            let v87 : System.DateTime = System.DateTime (1, 1, 1, v80, v82, v84, v86)
            v87
    let v91 : string = method7()
    let v92 : string = v90.ToString v91 
    v92 
    #endif
#if FABLE_COMPILER_PYTHON
    let v93 : US1 option = None
    let _v93 = ref v93 
    match v8 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v94 : int64 = x
    let v95 : US1 = US1_0(v94)
    v95 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v93.Value <- x
    let v96 : US1 option = _v93.Value 
    let v97 : US1 = US1_1
    let v98 : US1 = v96 |> Option.defaultValue v97 
    let v117 : System.DateTime =
        match v98 with
        | US1_1 -> (* None *)
            let v115 : System.DateTime = System.DateTime.Now
            v115
        | US1_0(v99) -> (* Some *)
            let v100 : System.DateTime = System.DateTime.Now
            let v101 : (System.DateTime -> int64) = _.Ticks
            let v102 : int64 = v101 v100
            let v103 : int64 = v102 - v99
            let v104 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v105 : System.TimeSpan = v104 v103
            let v106 : (System.TimeSpan -> int32) = _.Hours
            let v107 : int32 = v106 v105
            let v108 : (System.TimeSpan -> int32) = _.Minutes
            let v109 : int32 = v108 v105
            let v110 : (System.TimeSpan -> int32) = _.Seconds
            let v111 : int32 = v110 v105
            let v112 : (System.TimeSpan -> int32) = _.Milliseconds
            let v113 : int32 = v112 v105
            let v114 : System.DateTime = System.DateTime (1, 1, 1, v107, v109, v111, v113)
            v114
    let v118 : string = method7()
    let v119 : string = v117.ToString v118 
    v119 
    #endif
#else
    let v120 : US1 option = None
    let _v120 = ref v120 
    match v8 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v121 : int64 = x
    let v122 : US1 = US1_0(v121)
    v122 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v120.Value <- x
    let v123 : US1 option = _v120.Value 
    let v124 : US1 = US1_1
    let v125 : US1 = v123 |> Option.defaultValue v124 
    let v144 : System.DateTime =
        match v125 with
        | US1_1 -> (* None *)
            let v142 : System.DateTime = System.DateTime.Now
            v142
        | US1_0(v126) -> (* Some *)
            let v127 : System.DateTime = System.DateTime.Now
            let v128 : (System.DateTime -> int64) = _.Ticks
            let v129 : int64 = v128 v127
            let v130 : int64 = v129 - v126
            let v131 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v132 : System.TimeSpan = v131 v130
            let v133 : (System.TimeSpan -> int32) = _.Hours
            let v134 : int32 = v133 v132
            let v135 : (System.TimeSpan -> int32) = _.Minutes
            let v136 : int32 = v135 v132
            let v137 : (System.TimeSpan -> int32) = _.Seconds
            let v138 : int32 = v137 v132
            let v139 : (System.TimeSpan -> int32) = _.Milliseconds
            let v140 : int32 = v139 v132
            let v141 : System.DateTime = System.DateTime (1, 1, 1, v134, v136, v138, v140)
            v141
    let v145 : string = method7()
    let v146 : string = v144.ToString v145 
    v146 
    #endif
    |> fun x -> _v10 <- Some x
    let v147 : string = match _v10 with Some x -> x | None -> failwith "base.run_target / _v10=None"
    let v157 : string =
        match v0 with
        | US0_4 -> (* Critical *)
            let v152 : string = "Critical"
            v152
        | US0_1 -> (* Debug *)
            let v149 : string = "Debug"
            v149
        | US0_2 -> (* Info *)
            let v150 : string = "Info"
            v150
        | US0_0 -> (* Verbose *)
            let v148 : string = "Verbose"
            v148
        | US0_3 -> (* Warning *)
            let v151 : string = "Warning"
            v151
    let v158 : (unit -> string) = v157.ToLower
    let v159 : string = v158 ()
    let v160 : string = v159.PadLeft (7, ' ')
    let v161 : bool = true
    let mutable _v161 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v176 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v170 : string = "inline_colorization::color_bright_red"
            let v171 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v170 
            v171
        | US0_1 -> (* Debug *)
            let v164 : string = "inline_colorization::color_bright_blue"
            let v165 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v164 
            v165
        | US0_2 -> (* Info *)
            let v166 : string = "inline_colorization::color_bright_green"
            let v167 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v166 
            v167
        | US0_0 -> (* Verbose *)
            let v162 : string = "inline_colorization::color_bright_black"
            let v163 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v162 
            v163
        | US0_3 -> (* Warning *)
            let v168 : string = "inline_colorization::color_yellow"
            let v169 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v168 
            v169
    let v177 : string = "&*$0"
    let v178 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v160 v177 
    let v179 : string = "inline_colorization::color_reset"
    let v180 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v179 
    let v181 : string = "\"{v176}{v178}{v180}\""
    let v182 : string = @$"format!(" + v181 + ")"
    let v183 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v182 
    let v184 : string = "fable_library_rust::String_::fromString($0)"
    let v185 : string = Fable.Core.RustInterop.emitRustExpr v183 v184 
    v185 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v200 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v194 : string = "inline_colorization::color_bright_red"
            let v195 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v194 
            v195
        | US0_1 -> (* Debug *)
            let v188 : string = "inline_colorization::color_bright_blue"
            let v189 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v188 
            v189
        | US0_2 -> (* Info *)
            let v190 : string = "inline_colorization::color_bright_green"
            let v191 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v190 
            v191
        | US0_0 -> (* Verbose *)
            let v186 : string = "inline_colorization::color_bright_black"
            let v187 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v186 
            v187
        | US0_3 -> (* Warning *)
            let v192 : string = "inline_colorization::color_yellow"
            let v193 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v192 
            v193
    let v201 : string = "&*$0"
    let v202 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v160 v201 
    let v203 : string = "inline_colorization::color_reset"
    let v204 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v203 
    let v205 : string = "\"{v200}{v202}{v204}\""
    let v206 : string = @$"format!(" + v205 + ")"
    let v207 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v206 
    let v208 : string = "fable_library_rust::String_::fromString($0)"
    let v209 : string = Fable.Core.RustInterop.emitRustExpr v207 v208 
    v209 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v224 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v218 : string = "inline_colorization::color_bright_red"
            let v219 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v218 
            v219
        | US0_1 -> (* Debug *)
            let v212 : string = "inline_colorization::color_bright_blue"
            let v213 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v212 
            v213
        | US0_2 -> (* Info *)
            let v214 : string = "inline_colorization::color_bright_green"
            let v215 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v214 
            v215
        | US0_0 -> (* Verbose *)
            let v210 : string = "inline_colorization::color_bright_black"
            let v211 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v210 
            v211
        | US0_3 -> (* Warning *)
            let v216 : string = "inline_colorization::color_yellow"
            let v217 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v216 
            v217
    let v225 : string = "&*$0"
    let v226 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v160 v225 
    let v227 : string = "inline_colorization::color_reset"
    let v228 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v227 
    let v229 : string = "\"{v224}{v226}{v228}\""
    let v230 : string = @$"format!(" + v229 + ")"
    let v231 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v230 
    let v232 : string = "fable_library_rust::String_::fromString($0)"
    let v233 : string = Fable.Core.RustInterop.emitRustExpr v231 v232 
    v233 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    v160 
    #endif
#if FABLE_COMPILER_PYTHON
    v160 
    #endif
#else
    v160 
    #endif
    |> fun x -> _v161 <- Some x
    let v234 : string = match _v161 with Some x -> x | None -> failwith "base.run_target / _v161=None"
    let v235 : int64 = v5.l0
    let v236 : string = $"{v147} {v234} #{v235} %s{v1 ()} / %s{v2 ()}"
    let v237 : (char []) = [||]
    let v238 : string = v236.TrimStart v237 
    let v239 : (char []) = [|' '; '/'|]
    let v240 : string = v238.TrimEnd v239 
    v240
and method8 (v0 : US0, v1 : (unit -> string)) : unit =
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
    let v3 : (unit -> string) = closure5(v0, v1, v2)
    method8(v0, v3)
and closure4 (v0 : US0, v1 : (unit -> string)) (v2 : (unit -> string)) : unit =
    method4(v0, v1, v2)
and closure3 (v0 : US0) (v1 : (unit -> string)) : ((unit -> string) -> unit) =
    closure4(v0, v1)
and closure2 () (v0 : US0) : ((unit -> string) -> ((unit -> string) -> unit)) =
    closure3(v0)
let v0 : (US0 -> struct (Mut0 * Mut1 * Mut2 * int64 option * Mut3)) = closure0()
let v1 : US0 = US0_0
if State.trace_state.IsNone then State.trace_state <- v0 v1 |> Some
let v2 : (US0 -> ((unit -> string) -> ((unit -> string) -> unit))) = closure2()
let trace x = v2 x
()
