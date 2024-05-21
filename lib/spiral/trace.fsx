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
[<Fable.Core.Erase; Fable.Core.Emit("regex::Captures")>]
#endif
type regex_Captures = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("regex::CaptureMatches")>]
#endif
type regex_CaptureMatches = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("regex::Error")>]
#endif
type regex_Error = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::env::VarError")>]
#endif
type std_env_VarError = class end
module State = let mutable trace_state = None
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
let rec closure1 () (v0 : string) : unit =
    ()
and method0 () : string =
    let v0 : string = ""
    v0
and method1 () : string =
    let v0 : string = "AUTOMATION"
    v0
and closure0 () (v0 : US0) : struct (Mut0 * Mut1 * Mut2 * int64 option * Mut3) =
    let v1 : Mut1 = {l0 = true} : Mut1
    let v2 : Mut0 = {l0 = 0L} : Mut0
    let v3 : Mut2 = {l0 = v0} : Mut2
    let v4 : (string -> unit) = closure1()
    let v5 : Mut3 = {l0 = v4} : Mut3
    let v6 : bool = true
    let mutable _v6 : int64 option option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v7 : bool = true
    let mutable _v7 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v8 : string = "std::env::var(&*$0)"
    let v9 : string = "AUTOMATION"
    let v10 : Result<std_string_String, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr v9 v8 
    let v11 : string = "true; let _result = $0.map(|x| { //"
    let v12 : bool = Fable.Core.RustInterop.emitRustExpr v10 v11 
    let v13 : string = "x"
    let v14 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v13 
    let v15 : string = "fable_library_rust::String_::fromString($0)"
    let v16 : string = Fable.Core.RustInterop.emitRustExpr v14 v15 
    let v17 : string = "true; $0 })"
    let v18 : bool = Fable.Core.RustInterop.emitRustExpr v16 v17 
    let v19 : string = "_result"
    let v20 : Result<string, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr () v19 
    let v21 : string = method0()
    let v22 : string = "$0.unwrap_or($1)"
    let v23 : string = Fable.Core.RustInterop.emitRustExpr struct (v20, v21) v22 
    v23 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v24 : string = null |> unbox<string>
    v24 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v25 : string = null |> unbox<string>
    v25 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v26 : string = null |> unbox<string>
    v26 
    #endif
#if FABLE_COMPILER_PYTHON
    let v27 : string = null |> unbox<string>
    v27 
    #endif
#else
    let v28 : string = method1()
    let v29 : (string -> string) = System.Environment.GetEnvironmentVariable
    let v30 : string = v29 v28
    v30 
    #endif
    |> fun x -> _v7 <- Some x
    let v31 : string = match _v7 with Some x -> x | None -> failwith "base.run_target / _v7=None"
    let v33 : bool = v31 = "True"
    let v39 : US1 =
        if v33 then
            let v34 : System.DateTime = System.DateTime.Now
            let v35 : (System.DateTime -> int64) = _.Ticks
            let v36 : int64 = v35 v34
            US1_0(v36)
        else
            US1_1
    let v44 : int64 option =
        match v39 with
        | US1_1 -> (* None *)
            let v42 : int64 option = None
            v42
        | US1_0(v40) -> (* Some *)
            let v41 : int64 option = Some v40 
            v41
    v44 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v45 : int64 option = None
    v45 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v46 : int64 option = None
    v46 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v47 : int64 option = None
    v47 
    #endif
#if FABLE_COMPILER_PYTHON
    let v48 : int64 option = None
    v48 
    #endif
#else
    let v49 : bool = true
    let mutable _v49 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v50 : string = "std::env::var(&*$0)"
    let v51 : Result<std_string_String, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr v9 v50 
    let v52 : string = "true; let _result = $0.map(|x| { //"
    let v53 : bool = Fable.Core.RustInterop.emitRustExpr v51 v52 
    let v54 : string = "x"
    let v55 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v54 
    let v56 : string = "fable_library_rust::String_::fromString($0)"
    let v57 : string = Fable.Core.RustInterop.emitRustExpr v55 v56 
    let v58 : string = "true; $0 })"
    let v59 : bool = Fable.Core.RustInterop.emitRustExpr v57 v58 
    let v60 : string = "_result"
    let v61 : Result<string, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr () v60 
    let v62 : string = method0()
    let v63 : string = "$0.unwrap_or($1)"
    let v64 : string = Fable.Core.RustInterop.emitRustExpr struct (v61, v62) v63 
    v64 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v65 : string = null |> unbox<string>
    v65 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v66 : string = null |> unbox<string>
    v66 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v67 : string = null |> unbox<string>
    v67 
    #endif
#if FABLE_COMPILER_PYTHON
    let v68 : string = null |> unbox<string>
    v68 
    #endif
#else
    let v69 : string = method1()
    let v70 : (string -> string) = System.Environment.GetEnvironmentVariable
    let v71 : string = v70 v69
    v71 
    #endif
    |> fun x -> _v49 <- Some x
    let v72 : string = match _v49 with Some x -> x | None -> failwith "base.run_target / _v49=None"
    let v74 : bool = v72 = "True"
    let v80 : US1 =
        if v74 then
            let v75 : System.DateTime = System.DateTime.Now
            let v76 : (System.DateTime -> int64) = _.Ticks
            let v77 : int64 = v76 v75
            US1_0(v77)
        else
            US1_1
    let v85 : int64 option =
        match v80 with
        | US1_1 -> (* None *)
            let v83 : int64 option = None
            v83
        | US1_0(v81) -> (* Some *)
            let v82 : int64 option = Some v81 
            v82
    v85 
    #endif
    |> fun x -> _v6 <- Some x
    let v86 : int64 option = match _v6 with Some x -> x | None -> failwith "base.run_target / _v6=None"
    struct (v2, v1, v3, v86, v5)
and method3 () : string =
    let v0 : string = ""
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
    let v34 : System.DateTime =
        match v16 with
        | US1_1 -> (* None *)
            let v32 : System.DateTime = System.DateTime.Now
            v32
        | US1_0(v17) -> (* Some *)
            let v18 : System.DateTime = System.DateTime.Now
            let v19 : (System.DateTime -> int64) = _.Ticks
            let v20 : int64 = v19 v18
            let v21 : int64 = v20 - v17
            let v22 : System.TimeSpan = System.TimeSpan v21 
            let v23 : (System.TimeSpan -> int32) = _.Hours
            let v24 : int32 = v23 v22
            let v25 : (System.TimeSpan -> int32) = _.Minutes
            let v26 : int32 = v25 v22
            let v27 : (System.TimeSpan -> int32) = _.Seconds
            let v28 : int32 = v27 v22
            let v29 : (System.TimeSpan -> int32) = _.Milliseconds
            let v30 : int32 = v29 v22
            let v31 : System.DateTime = System.DateTime (1, 1, 1, v24, v26, v28, v30)
            v31
    let v35 : string = "hh:mm:ss"
    let v36 : string = v34.ToString v35 
    v36 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v37 : string = method3()
    v37 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v38 : string = method3()
    v38 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v39 : string = method3()
    v39 
    #endif
#if FABLE_COMPILER_PYTHON
    let v40 : string = method3()
    v40 
    #endif
#else
    let v41 : US1 option = None
    let _v41 = ref v41 
    match v8 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v42 : int64 = x
    let v43 : US1 = US1_0(v42)
    v43 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v41.Value <- x
    let v44 : US1 option = _v41.Value 
    let v45 : US1 = US1_1
    let v46 : US1 = v44 |> Option.defaultValue v45 
    let v64 : System.DateTime =
        match v46 with
        | US1_1 -> (* None *)
            let v62 : System.DateTime = System.DateTime.Now
            v62
        | US1_0(v47) -> (* Some *)
            let v48 : System.DateTime = System.DateTime.Now
            let v49 : (System.DateTime -> int64) = _.Ticks
            let v50 : int64 = v49 v48
            let v51 : int64 = v50 - v47
            let v52 : System.TimeSpan = System.TimeSpan v51 
            let v53 : (System.TimeSpan -> int32) = _.Hours
            let v54 : int32 = v53 v52
            let v55 : (System.TimeSpan -> int32) = _.Minutes
            let v56 : int32 = v55 v52
            let v57 : (System.TimeSpan -> int32) = _.Seconds
            let v58 : int32 = v57 v52
            let v59 : (System.TimeSpan -> int32) = _.Milliseconds
            let v60 : int32 = v59 v52
            let v61 : System.DateTime = System.DateTime (1, 1, 1, v54, v56, v58, v60)
            v61
    let v65 : string = "HH:mm:ss"
    let v66 : string = v64.ToString v65 
    v66 
    #endif
    |> fun x -> _v10 <- Some x
    let v67 : string = match _v10 with Some x -> x | None -> failwith "base.run_target / _v10=None"
    let v68 : int64 = v5.l0
    let v78 : string =
        match v0 with
        | US0_4 -> (* Critical *)
            let v73 : string = "Critical"
            v73
        | US0_1 -> (* Debug *)
            let v70 : string = "Debug"
            v70
        | US0_2 -> (* Info *)
            let v71 : string = "Info"
            v71
        | US0_0 -> (* Verbose *)
            let v69 : string = "Verbose"
            v69
        | US0_3 -> (* Warning *)
            let v72 : string = "Warning"
            v72
    let v79 : (unit -> string) = v78.ToLower
    let v80 : string = v79 ()
    let v81 : string = v80.PadLeft (7, ' ')
    let v82 : bool = true
    let mutable _v82 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v97 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v91 : string = "inline_colorization::color_bright_red"
            let v92 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v91 
            v92
        | US0_1 -> (* Debug *)
            let v85 : string = "inline_colorization::color_bright_blue"
            let v86 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v85 
            v86
        | US0_2 -> (* Info *)
            let v87 : string = "inline_colorization::color_bright_green"
            let v88 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v87 
            v88
        | US0_0 -> (* Verbose *)
            let v83 : string = "inline_colorization::color_bright_black"
            let v84 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v83 
            v84
        | US0_3 -> (* Warning *)
            let v89 : string = "inline_colorization::color_yellow"
            let v90 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v89 
            v90
    let v98 : string = "&*$0"
    let v99 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v81 v98 
    let v100 : string = "inline_colorization::color_reset"
    let v101 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v100 
    let v102 : string = "\"{v97}{v99}{v101}\""
    let v103 : string = @$"format!(" + v102 + ")"
    let v104 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v103 
    let v105 : string = "fable_library_rust::String_::fromString($0)"
    let v106 : string = Fable.Core.RustInterop.emitRustExpr v104 v105 
    v106 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v121 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v115 : string = "inline_colorization::color_bright_red"
            let v116 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v115 
            v116
        | US0_1 -> (* Debug *)
            let v109 : string = "inline_colorization::color_bright_blue"
            let v110 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v109 
            v110
        | US0_2 -> (* Info *)
            let v111 : string = "inline_colorization::color_bright_green"
            let v112 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v111 
            v112
        | US0_0 -> (* Verbose *)
            let v107 : string = "inline_colorization::color_bright_black"
            let v108 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v107 
            v108
        | US0_3 -> (* Warning *)
            let v113 : string = "inline_colorization::color_yellow"
            let v114 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v113 
            v114
    let v122 : string = "&*$0"
    let v123 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v81 v122 
    let v124 : string = "inline_colorization::color_reset"
    let v125 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v124 
    let v126 : string = "\"{v121}{v123}{v125}\""
    let v127 : string = @$"format!(" + v126 + ")"
    let v128 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v127 
    let v129 : string = "fable_library_rust::String_::fromString($0)"
    let v130 : string = Fable.Core.RustInterop.emitRustExpr v128 v129 
    v130 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v145 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v139 : string = "inline_colorization::color_bright_red"
            let v140 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v139 
            v140
        | US0_1 -> (* Debug *)
            let v133 : string = "inline_colorization::color_bright_blue"
            let v134 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v133 
            v134
        | US0_2 -> (* Info *)
            let v135 : string = "inline_colorization::color_bright_green"
            let v136 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v135 
            v136
        | US0_0 -> (* Verbose *)
            let v131 : string = "inline_colorization::color_bright_black"
            let v132 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v131 
            v132
        | US0_3 -> (* Warning *)
            let v137 : string = "inline_colorization::color_yellow"
            let v138 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v137 
            v138
    let v146 : string = "&*$0"
    let v147 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v81 v146 
    let v148 : string = "inline_colorization::color_reset"
    let v149 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v148 
    let v150 : string = "\"{v145}{v147}{v149}\""
    let v151 : string = @$"format!(" + v150 + ")"
    let v152 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v151 
    let v153 : string = "fable_library_rust::String_::fromString($0)"
    let v154 : string = Fable.Core.RustInterop.emitRustExpr v152 v153 
    v154 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    v81 
    #endif
#if FABLE_COMPILER_PYTHON
    v81 
    #endif
#else
    v81 
    #endif
    |> fun x -> _v82 <- Some x
    let v155 : string = match _v82 with Some x -> x | None -> failwith "base.run_target / _v82=None"
    let v156 : string = $"{v67} {v155} #{v68} %s{v1 ()} / %s{v2 ()}"
    let v157 : (char []) = [||]
    let v158 : string = v156.TrimStart v157 
    let v159 : (char []) = [|' '; '/'|]
    let v160 : string = v158.TrimEnd v159 
    v160
and method4 (v0 : US0, v1 : (unit -> string)) : unit =
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
and method2 (v0 : US0, v1 : (unit -> string), v2 : (unit -> string)) : unit =
    let v3 : (unit -> string) = closure5(v0, v1, v2)
    method4(v0, v3)
and closure4 (v0 : US0, v1 : (unit -> string)) (v2 : (unit -> string)) : unit =
    method2(v0, v1, v2)
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
