#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("_")>]
#endif
type Any = class end
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
[<Fable.Core.Erase; Fable.Core.Emit("$0 + Send")>]
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
[<Fable.Core.Erase; Fable.Core.Emit("&'static $0")>]
#endif
type StaticRef<'T> = class end
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
type Mut0 = {mutable l0 : int64}
and Mut1 = {mutable l0 : bool}
and [<Struct>] US0 =
    | US0_0
    | US0_1
    | US0_2
    | US0_3
    | US0_4
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
and closure0 () () : struct (Mut0 * Mut1 * Mut2 * int64 option * Mut3) =
    let v0 : Mut1 = {l0 = true} : Mut1
    let v1 : Mut0 = {l0 = 0L} : Mut0
    let v2 : US0 = US0_0
    let v3 : Mut2 = {l0 = v2} : Mut2
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
    let v28 : (string -> string) = System.Environment.GetEnvironmentVariable
    let v29 : string = v28 v9
    v29 
    #endif
    |> fun x -> _v7 <- Some x
    let v30 : string = _v7.Value
    let v32 : bool = v30 = "True"
    let v38 : US1 =
        if v32 then
            let v33 : System.DateTime = System.DateTime.Now
            let v34 : (System.DateTime -> int64) = _.Ticks
            let v35 : int64 = v34 v33
            US1_0(v35)
        else
            US1_1
    let v43 : int64 option =
        match v38 with
        | US1_1 -> (* None *)
            let v41 : int64 option = None
            v41
        | US1_0(v39) -> (* Some *)
            let v40 : int64 option = Some v39 
            v40
    v43 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v44 : int64 option = None
    v44 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v45 : int64 option = None
    v45 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v46 : int64 option = None
    v46 
    #endif
#if FABLE_COMPILER_PYTHON
    let v47 : int64 option = None
    v47 
    #endif
#else
    let v48 : bool = true
    let mutable _v48 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v49 : bool = true
    let mutable _v49 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v50 : string = "std::env::var(&*$0)"
    let v51 : string = "CARGO_PKG_NAME"
    let v52 : Result<std_string_String, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr v51 v50
    let v53 : string = "true; let _result = $0.map(|x| { //"
    let v54 : bool = Fable.Core.RustInterop.emitRustExpr v52 v53
    let v55 : string = "x"
    let v56 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v55
    let v57 : string = "fable_library_rust::String_::fromString($0)"
    let v58 : string = Fable.Core.RustInterop.emitRustExpr v56 v57
    let v59 : string = "true; $0 })"
    let v60 : bool = Fable.Core.RustInterop.emitRustExpr v58 v59
    let v61 : string = "_result"
    let v62 : Result<string, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr () v61
    let v63 : string = method0()
    let v64 : string = "$0.unwrap_or($1)"
    let v65 : string = Fable.Core.RustInterop.emitRustExpr struct (v62, v63) v64
    v65 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v66 : string = null |> unbox<string>
    v66 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v67 : string = null |> unbox<string>
    v67 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v68 : string = null |> unbox<string>
    v68 
    #endif
#if FABLE_COMPILER_PYTHON
    let v69 : string = null |> unbox<string>
    v69 
    #endif
#else
    let v70 : (string -> string) = System.Environment.GetEnvironmentVariable
    let v71 : string = v70 v51
    v71 
    #endif
    |> fun x -> _v49 <- Some x
    let v72 : string = _v49.Value
    v72 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v73 : string = null |> unbox<string>
    v73 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v74 : string = null |> unbox<string>
    v74 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v75 : string = null |> unbox<string>
    v75 
    #endif
#if FABLE_COMPILER_PYTHON
    let v76 : string = null |> unbox<string>
    v76 
    #endif
#else
    let v77 : string = System.Reflection.Assembly.GetEntryAssembly().GetName().Name
    v77 
    #endif
    |> fun x -> _v48 <- Some x
    let v78 : string = _v48.Value
    let v80 : bool = v78 = "dotnet-repl"
    let v86 : US1 =
        if v80 then
            let v81 : System.DateTime = System.DateTime.Now
            let v82 : (System.DateTime -> int64) = _.Ticks
            let v83 : int64 = v82 v81
            US1_0(v83)
        else
            US1_1
    let v91 : int64 option =
        match v86 with
        | US1_1 -> (* None *)
            let v89 : int64 option = None
            v89
        | US1_0(v87) -> (* Some *)
            let v88 : int64 option = Some v87 
            v88
    v91 
    #endif
    |> fun x -> _v6 <- Some x
    let v92 : int64 option = _v6.Value
    struct (v1, v0, v3, v92, v5)
and method2 () : string =
    let v0 : string = ""
    v0
and closure5 (v0 : US0, v1 : (unit -> string), v2 : (unit -> string)) () : string =
    let v3 : (unit -> struct (Mut0 * Mut1 * Mut2 * int64 option * Mut3)) = closure0()
    if State.trace_state.IsNone then State.trace_state <- v3 () |> Some
    let struct (v4 : Mut0, v5 : Mut1, v6 : Mut2, v7 : int64 option, v8 : Mut3) = State.trace_state.Value
    let v9 : bool = true
    let mutable _v9 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v10 : US1 option = None
    let _v10 = ref v10 
    match v7 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v11 : int64 = x
    let v12 : US1 = US1_0(v11)
    v12 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v10.Value <- x
    let v13 : US1 option = _v10.Value 
    let v14 : US1 = US1_1
    let v15 : US1 = v13 |> Option.defaultValue v14 
    let v33 : System.DateTime =
        match v15 with
        | US1_1 -> (* None *)
            let v31 : System.DateTime = System.DateTime.Now
            v31
        | US1_0(v16) -> (* Some *)
            let v17 : System.DateTime = System.DateTime.Now
            let v18 : (System.DateTime -> int64) = _.Ticks
            let v19 : int64 = v18 v17
            let v20 : int64 = v19 - v16
            let v21 : System.TimeSpan = System.TimeSpan v20 
            let v22 : (System.TimeSpan -> int32) = _.Hours
            let v23 : int32 = v22 v21
            let v24 : (System.TimeSpan -> int32) = _.Minutes
            let v25 : int32 = v24 v21
            let v26 : (System.TimeSpan -> int32) = _.Seconds
            let v27 : int32 = v26 v21
            let v28 : (System.TimeSpan -> int32) = _.Milliseconds
            let v29 : int32 = v28 v21
            let v30 : System.DateTime = System.DateTime (1, 1, 1, v23, v25, v27, v29)
            v30
    let v34 : string = "hh:mm:ss"
    let v35 : string = v33.ToString v34 
    v35 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v36 : string = method2()
    v36 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v37 : string = method2()
    v37 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v38 : string = method2()
    v38 
    #endif
#if FABLE_COMPILER_PYTHON
    let v39 : string = method2()
    v39 
    #endif
#else
    let v40 : US1 option = None
    let _v40 = ref v40 
    match v7 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v41 : int64 = x
    let v42 : US1 = US1_0(v41)
    v42 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v40.Value <- x
    let v43 : US1 option = _v40.Value 
    let v44 : US1 = US1_1
    let v45 : US1 = v43 |> Option.defaultValue v44 
    let v63 : System.DateTime =
        match v45 with
        | US1_1 -> (* None *)
            let v61 : System.DateTime = System.DateTime.Now
            v61
        | US1_0(v46) -> (* Some *)
            let v47 : System.DateTime = System.DateTime.Now
            let v48 : (System.DateTime -> int64) = _.Ticks
            let v49 : int64 = v48 v47
            let v50 : int64 = v49 - v46
            let v51 : System.TimeSpan = System.TimeSpan v50 
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
    let v64 : string = "HH:mm:ss"
    let v65 : string = v63.ToString v64 
    v65 
    #endif
    |> fun x -> _v9 <- Some x
    let v66 : string = _v9.Value
    let v67 : int64 = v4.l0
    let v77 : string =
        match v0 with
        | US0_4 -> (* Critical *)
            let v72 : string = "Critical"
            v72
        | US0_1 -> (* Debug *)
            let v69 : string = "Debug"
            v69
        | US0_2 -> (* Info *)
            let v70 : string = "Info"
            v70
        | US0_0 -> (* Verbose *)
            let v68 : string = "Verbose"
            v68
        | US0_3 -> (* Warning *)
            let v71 : string = "Warning"
            v71
    let v78 : string = v77.ToLower ()
    let v79 : string = v78.PadLeft (7, ' ')
    let v80 : bool = true
    let mutable _v80 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v95 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v89 : string = "inline_colorization::color_bright_red"
            let v90 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v89
            v90
        | US0_1 -> (* Debug *)
            let v83 : string = "inline_colorization::color_bright_blue"
            let v84 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v83
            v84
        | US0_2 -> (* Info *)
            let v85 : string = "inline_colorization::color_bright_green"
            let v86 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v85
            v86
        | US0_0 -> (* Verbose *)
            let v81 : string = "inline_colorization::color_bright_black"
            let v82 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v81
            v82
        | US0_3 -> (* Warning *)
            let v87 : string = "inline_colorization::color_yellow"
            let v88 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v87
            v88
    let v96 : string = "&*$0"
    let v97 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v79 v96
    let v98 : string = "inline_colorization::color_reset"
    let v99 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v98
    let v100 : string = "\"{v95}{v97}{v99}\""
    let v101 : string = @$"format!(" + v100 + ")"
    let v102 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v101
    let v103 : string = "fable_library_rust::String_::fromString($0)"
    let v104 : string = Fable.Core.RustInterop.emitRustExpr v102 v103
    v104 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v119 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v113 : string = "inline_colorization::color_bright_red"
            let v114 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v113
            v114
        | US0_1 -> (* Debug *)
            let v107 : string = "inline_colorization::color_bright_blue"
            let v108 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v107
            v108
        | US0_2 -> (* Info *)
            let v109 : string = "inline_colorization::color_bright_green"
            let v110 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v109
            v110
        | US0_0 -> (* Verbose *)
            let v105 : string = "inline_colorization::color_bright_black"
            let v106 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v105
            v106
        | US0_3 -> (* Warning *)
            let v111 : string = "inline_colorization::color_yellow"
            let v112 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v111
            v112
    let v120 : string = "&*$0"
    let v121 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v79 v120
    let v122 : string = "inline_colorization::color_reset"
    let v123 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v122
    let v124 : string = "\"{v119}{v121}{v123}\""
    let v125 : string = @$"format!(" + v124 + ")"
    let v126 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v125
    let v127 : string = "fable_library_rust::String_::fromString($0)"
    let v128 : string = Fable.Core.RustInterop.emitRustExpr v126 v127
    v128 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v143 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v137 : string = "inline_colorization::color_bright_red"
            let v138 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v137
            v138
        | US0_1 -> (* Debug *)
            let v131 : string = "inline_colorization::color_bright_blue"
            let v132 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v131
            v132
        | US0_2 -> (* Info *)
            let v133 : string = "inline_colorization::color_bright_green"
            let v134 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v133
            v134
        | US0_0 -> (* Verbose *)
            let v129 : string = "inline_colorization::color_bright_black"
            let v130 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v129
            v130
        | US0_3 -> (* Warning *)
            let v135 : string = "inline_colorization::color_yellow"
            let v136 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v135
            v136
    let v144 : string = "&*$0"
    let v145 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v79 v144
    let v146 : string = "inline_colorization::color_reset"
    let v147 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v146
    let v148 : string = "\"{v143}{v145}{v147}\""
    let v149 : string = @$"format!(" + v148 + ")"
    let v150 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v149
    let v151 : string = "fable_library_rust::String_::fromString($0)"
    let v152 : string = Fable.Core.RustInterop.emitRustExpr v150 v151
    v152 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    v79 
    #endif
#if FABLE_COMPILER_PYTHON
    v79 
    #endif
#else
    v79 
    #endif
    |> fun x -> _v80 <- Some x
    let v153 : string = _v80.Value
    let v154 : string = $"{v66} {v153} #{v67} %s{v1 ()} / %s{v2 ()}"
    let v155 : (char []) = [||]
    let v156 : string = v154.TrimStart v155
    let v157 : (char []) = [|' '; '/'|]
    let v158 : string = v156.TrimEnd v157
    v158
and method3 (v0 : US0, v1 : (unit -> string)) : unit =
    let v2 : (unit -> struct (Mut0 * Mut1 * Mut2 * int64 option * Mut3)) = closure0()
    if State.trace_state.IsNone then State.trace_state <- v2 () |> Some
    let struct (v3 : Mut0, v4 : Mut1, v5 : Mut2, v6 : int64 option, v7 : Mut3) = State.trace_state.Value
    if State.trace_state.IsNone then State.trace_state <- v2 () |> Some
    let struct (v8 : Mut0, v9 : Mut1, v10 : Mut2, v11 : int64 option, v12 : Mut3) = State.trace_state.Value
    let v13 : US0 = v10.l0
    let v14 : bool = v9.l0
    let v15 : bool = v14 = false
    let v19 : bool =
        if v15 then
            false
        else
            let v16 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v0
            let v17 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v13
            let v18 : bool = v16 >= v17
            v18
    if v19 then
        let v20 : int64 = v3.l0
        let v21 : int64 = v20 + 1L
        v3.l0 <- v21
        let v22 : string = $"%s{v1 ()}"
        let v23 : bool = true
        let mutable _v23 : unit option = None 
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v24 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v22 v24
        () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v25 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v22 v25
        () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v26 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v22 v26
        () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        System.Console.WriteLine v22 
        () 
        #endif
#if FABLE_COMPILER_PYTHON
        System.Console.WriteLine v22 
        () 
        #endif
#else
        System.Console.WriteLine v22 
        () 
        #endif
        |> fun x -> _v23 <- Some x
        _v23.Value
        let v27 : (string -> unit) = v7.l0
        v27 v22
and method1 (v0 : US0, v1 : (unit -> string), v2 : (unit -> string)) : unit =
    let v3 : (unit -> string) = closure5(v0, v1, v2)
    method3(v0, v3)
and closure4 (v0 : US0, v1 : (unit -> string)) (v2 : (unit -> string)) : unit =
    method1(v0, v1, v2)
and closure3 (v0 : US0) (v1 : (unit -> string)) : ((unit -> string) -> unit) =
    closure4(v0, v1)
and closure2 () (v0 : US0) : ((unit -> string) -> ((unit -> string) -> unit)) =
    closure3(v0)
let v0 : (unit -> struct (Mut0 * Mut1 * Mut2 * int64 option * Mut3)) = closure0()
if State.trace_state.IsNone then State.trace_state <- v0 () |> Some
let v1 : (US0 -> ((unit -> string) -> ((unit -> string) -> unit))) = closure2()
let trace x = v1 x
()
