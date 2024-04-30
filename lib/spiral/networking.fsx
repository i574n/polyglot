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
and [<Struct>] US2 =
    | US2_0 of f0_0 : int64
    | US2_1
and [<Struct>] US3 =
    | US3_0 of f0_0 : bool
    | US3_1
and [<Struct>] US4 =
    | US4_0 of f0_0 : bool
    | US4_1 of f1_0 : exn
and [<Struct>] US5 =
    | US5_0 of f0_0 : bool
    | US5_1 of f1_0 : exn
and [<Struct>] US6 =
    | US6_0 of f0_0 : int32
    | US6_1
and [<Struct>] US7 =
    | US7_0 of f0_0 : int64
    | US7_1 of f1_0 : exn
and [<Struct>] US8 =
    | US8_0 of f0_0 : int64
    | US8_1 of f1_0 : exn
let rec closure1 () (v0 : string) : unit =
    ()
and method0 (v0 : int64 option) : int64 option =
    v0
and method1 (v0 : int64 option) : int64 option =
    v0
and closure0 () () : struct (Mut0 * Mut1 * Mut2 * int64 option * Mut3) =
    let v0 : Mut1 = {l0 = true} : Mut1
    let v1 : Mut0 = {l0 = 0L} : Mut0
    let v2 : US0 = US0_0
    let v3 : Mut2 = {l0 = v2} : Mut2
    let v4 : (string -> unit) = closure1()
    let v5 : Mut3 = {l0 = v4} : Mut3
    let v6 : int64 option option = None
    let mutable _v6 = v6
    #if INTERACTIVE || !FABLE_COMPILER
    let v7 : string option = None
    let v8 : bool = true in let mutable _v7 = v7
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v9 : string = "env!(\"CARGO_PKG_NAME\").into()"
    let v10 : string = Fable.Core.RustInterop.emitRustExpr () v9
    v10
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v11 : string = null |> unbox<string>
    v11
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v12 : string = null |> unbox<string>
    v12
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v13 : string = null |> unbox<string>
    v13
#endif
    
#if FABLE_COMPILER_PYTHON
    let v14 : string = null |> unbox<string>
    v14
#endif
    
#else
    let v15 : string = System.Reflection.Assembly.GetEntryAssembly().GetName().Name
    v15
#endif
    |> fun x -> _v7 <- Some x
    let v16 : string = _v7.Value
    let v18 : bool = v16 = "Microsoft.DotNet.Interactive.App"
    let v19 : bool = v18 <> true
    let v25 : US1 =
        if v19 then
            let v20 : System.DateTime = System.DateTime.Now
            let v21 : (System.DateTime -> int64) = _.Ticks
            let v22 : int64 = v21 v20
            US1_0(v22)
        else
            US1_1
    let v30 : int64 option =
        match v25 with
        | US1_1 -> (* None *)
            let v28 : int64 option = None
            v28
        | US1_0(v26) -> (* Some *)
            let v27 : int64 option = Some v26 
            v27
    let v31 : int64 option = method0(v30)
    v31 
    #else
    let v32 : int64 option = None
    let v33 : int64 option = method1(v32)
    v33 
    #endif
    |> fun x -> _v6 <- Some x
    let v34 : int64 option = _v6.Value
    struct (v1, v0, v3, v34, v5)
and closure3 (v0 : string) () : string =
    let v1 : string = $"test_port_open / ex: {v0}"
    v1
and closure4 () () : string =
    let v0 : string = ""
    v0
and closure6 () (v0 : int64) : US2 =
    US2_0(v0)
and method3 () : (int64 -> US2) =
    closure6()
and method4 () : string =
    let v0 : string = ""
    v0
and closure5 (v0 : US0, v1 : (unit -> string), v2 : (unit -> string)) () : string =
    let v3 : (unit -> struct (Mut0 * Mut1 * Mut2 * int64 option * Mut3)) = closure0()
    if State.trace_state.IsNone then State.trace_state <- v3 () |> Some
    let struct (v4 : Mut0, v5 : Mut1, v6 : Mut2, v7 : int64 option, v8 : Mut3) = State.trace_state.Value
    let v9 : string option = None
    let v10 : bool = true in let mutable _v9 = v9
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v11 : (int64 -> US2) = method3()
    let v12 : US2 = US2_1
    let v13 : US2 = v7 |> Option.map v11 |> Option.defaultValue v12 
    let v31 : System.DateTime =
        match v13 with
        | US2_1 -> (* None *)
            let v29 : System.DateTime = System.DateTime.Now
            v29
        | US2_0(v14) -> (* Some *)
            let v15 : System.DateTime = System.DateTime.Now
            let v16 : (System.DateTime -> int64) = _.Ticks
            let v17 : int64 = v16 v15
            let v18 : int64 = v17 - v14
            let v19 : System.TimeSpan = System.TimeSpan v18 
            let v20 : (System.TimeSpan -> int32) = _.Hours
            let v21 : int32 = v20 v19
            let v22 : (System.TimeSpan -> int32) = _.Minutes
            let v23 : int32 = v22 v19
            let v24 : (System.TimeSpan -> int32) = _.Seconds
            let v25 : int32 = v24 v19
            let v26 : (System.TimeSpan -> int32) = _.Milliseconds
            let v27 : int32 = v26 v19
            let v28 : System.DateTime = System.DateTime (1, 1, 1, v21, v23, v25, v27)
            v28
    let v32 : string = "hh:mm:ss"
    let v33 : string = v31.ToString v32 
    v33
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v34 : string = method4()
    v34
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v35 : string = method4()
    v35
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v36 : string = method4()
    v36
#endif
    
#if FABLE_COMPILER_PYTHON
    let v37 : string = method4()
    v37
#endif
    
#else
    let v38 : (int64 -> US2) = method3()
    let v39 : US2 = US2_1
    let v40 : US2 = v7 |> Option.map v38 |> Option.defaultValue v39 
    let v58 : System.DateTime =
        match v40 with
        | US2_1 -> (* None *)
            let v56 : System.DateTime = System.DateTime.Now
            v56
        | US2_0(v41) -> (* Some *)
            let v42 : System.DateTime = System.DateTime.Now
            let v43 : (System.DateTime -> int64) = _.Ticks
            let v44 : int64 = v43 v42
            let v45 : int64 = v44 - v41
            let v46 : System.TimeSpan = System.TimeSpan v45 
            let v47 : (System.TimeSpan -> int32) = _.Hours
            let v48 : int32 = v47 v46
            let v49 : (System.TimeSpan -> int32) = _.Minutes
            let v50 : int32 = v49 v46
            let v51 : (System.TimeSpan -> int32) = _.Seconds
            let v52 : int32 = v51 v46
            let v53 : (System.TimeSpan -> int32) = _.Milliseconds
            let v54 : int32 = v53 v46
            let v55 : System.DateTime = System.DateTime (1, 1, 1, v48, v50, v52, v54)
            v55
    let v59 : string = "HH:mm:ss"
    let v60 : string = v58.ToString v59 
    v60
#endif
    |> fun x -> _v9 <- Some x
    let v61 : string = _v9.Value
    let v62 : int64 = v4.l0
    let v72 : string =
        match v0 with
        | US0_4 -> (* Critical *)
            let v67 : string = "Critical"
            v67
        | US0_1 -> (* Debug *)
            let v64 : string = "Debug"
            v64
        | US0_2 -> (* Info *)
            let v65 : string = "Info"
            v65
        | US0_0 -> (* Verbose *)
            let v63 : string = "Verbose"
            v63
        | US0_3 -> (* Warning *)
            let v66 : string = "Warning"
            v66
    let v73 : string = v72.ToLower ()
    let v74 : string = v73.PadLeft (7, ' ')
    let v75 : string option = None
    let v76 : bool = true in let mutable _v75 = v75
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v91 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v85 : string = "inline_colorization::color_bright_red"
            let v86 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v85
            v86
        | US0_1 -> (* Debug *)
            let v79 : string = "inline_colorization::color_bright_blue"
            let v80 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v79
            v80
        | US0_2 -> (* Info *)
            let v81 : string = "inline_colorization::color_bright_green"
            let v82 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v81
            v82
        | US0_0 -> (* Verbose *)
            let v77 : string = "inline_colorization::color_bright_black"
            let v78 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v77
            v78
        | US0_3 -> (* Warning *)
            let v83 : string = "inline_colorization::color_bright_yellow"
            let v84 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v83
            v84
    let v92 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v93 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v74 v92
    let v94 : string = "inline_colorization::color_reset"
    let v95 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v94
    let v96 : string = "\"{v91}{v93}{v95}\""
    let v97 : string = @$"format!(" + v96 + ")"
    let v98 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v97
    let v99 : string = "fable_library_rust::String_::fromString($0)"
    let v100 : string = Fable.Core.RustInterop.emitRustExpr v98 v99
    v100
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v115 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v109 : string = "inline_colorization::color_bright_red"
            let v110 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v109
            v110
        | US0_1 -> (* Debug *)
            let v103 : string = "inline_colorization::color_bright_blue"
            let v104 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v103
            v104
        | US0_2 -> (* Info *)
            let v105 : string = "inline_colorization::color_bright_green"
            let v106 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v105
            v106
        | US0_0 -> (* Verbose *)
            let v101 : string = "inline_colorization::color_bright_black"
            let v102 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v101
            v102
        | US0_3 -> (* Warning *)
            let v107 : string = "inline_colorization::color_bright_yellow"
            let v108 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v107
            v108
    let v116 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v117 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v74 v116
    let v118 : string = "inline_colorization::color_reset"
    let v119 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v118
    let v120 : string = "\"{v115}{v117}{v119}\""
    let v121 : string = @$"format!(" + v120 + ")"
    let v122 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v121
    let v123 : string = "fable_library_rust::String_::fromString($0)"
    let v124 : string = Fable.Core.RustInterop.emitRustExpr v122 v123
    v124
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v139 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v133 : string = "inline_colorization::color_bright_red"
            let v134 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v133
            v134
        | US0_1 -> (* Debug *)
            let v127 : string = "inline_colorization::color_bright_blue"
            let v128 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v127
            v128
        | US0_2 -> (* Info *)
            let v129 : string = "inline_colorization::color_bright_green"
            let v130 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v129
            v130
        | US0_0 -> (* Verbose *)
            let v125 : string = "inline_colorization::color_bright_black"
            let v126 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v125
            v126
        | US0_3 -> (* Warning *)
            let v131 : string = "inline_colorization::color_bright_yellow"
            let v132 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v131
            v132
    let v140 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v141 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v74 v140
    let v142 : string = "inline_colorization::color_reset"
    let v143 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v142
    let v144 : string = "\"{v139}{v141}{v143}\""
    let v145 : string = @$"format!(" + v144 + ")"
    let v146 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v145
    let v147 : string = "fable_library_rust::String_::fromString($0)"
    let v148 : string = Fable.Core.RustInterop.emitRustExpr v146 v147
    v148
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    v74
#endif
    
#if FABLE_COMPILER_PYTHON
    v74
#endif
    
#else
    v74
#endif
    |> fun x -> _v75 <- Some x
    let v149 : string = _v75.Value
    let v150 : string = v1 ()
    let v151 : string = $"{v61} {v149} #{v62} %s{v150} / %s{v2 ()}"
    let v152 : (char []) = [||]
    let v153 : string = v151.TrimStart v152
    let v154 : (char []) = [|' '; '/'|]
    let v155 : string = v153.TrimEnd v154
    v155
and method5 (v0 : US0, v1 : (unit -> string)) : unit =
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
        let v23 : unit option = None
        let v24 : bool = true in let mutable _v23 = v23
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v25 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v22 v25
        ()
#endif
        
#if FABLE_COMPILER_RUST && WASM
        let v26 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v22 v26
        ()
#endif
        
#if FABLE_COMPILER_RUST && CONTRACT
        let v27 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v22 v27
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
        let v28 : (string -> unit) = v7.l0
        v28 v22
and method2 (v0 : US0, v1 : (unit -> string), v2 : (unit -> string)) : unit =
    let v3 : (unit -> string) = closure5(v0, v1, v2)
    method5(v0, v3)
and closure2 () (v0 : int32) : Async<bool> =
    let v1 : Async<bool> option = None
    let v2 : bool = true in let mutable _v1 = v1
    
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
    let v13 : string = "127.0.0.1"
    let v14 : System.Threading.Tasks.ValueTask = v12.ConnectAsync (v13, v0, v10)
    let v15 : (unit -> System.Threading.Tasks.Task) = v14.AsTask
    let v16 : System.Threading.Tasks.Task = v15 ()
    let v17 : Async<unit> option = None
    let v18 : bool = true in let mutable _v17 = v17
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v19 : Async<unit> = null |> unbox<Async<unit>>
    v19
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v20 : Async<unit> = null |> unbox<Async<unit>>
    v20
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v21 : Async<unit> = null |> unbox<Async<unit>>
    v21
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v22 : Async<unit> = null |> unbox<Async<unit>>
    v22
#endif
    
#if FABLE_COMPILER_PYTHON
    let v23 : Async<unit> = null |> unbox<Async<unit>>
    v23
#endif
    
#else
    let v24 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
    let v25 : Async<unit> = v24 v16
    v25
#endif
    |> fun x -> _v17 <- Some x
    let v26 : Async<unit> = _v17.Value
    do! v26 
    return true 
    with ex ->
    let v27 : exn = ex
    let v28 : string option = None
    let v29 : bool = true in let mutable _v28 = v28
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v30 : string = $"%A{v27}"
    v30
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v31 : string = $"%A{v27}"
    v31
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v32 : string = $"%A{v27}"
    v32
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v33 : string = $"%A{v27}"
    v33
#endif
    
#if FABLE_COMPILER_PYTHON
    let v34 : string = $"%A{v27}"
    v34
#endif
    
#else
    let v35 : string = $"{v27.GetType ()}: {v27.Message}"
    v35
#endif
    |> fun x -> _v28 <- Some x
    let v36 : string = _v28.Value
    let v37 : US0 = US0_0
    let v38 : (unit -> string) = closure3(v36)
    let v39 : (unit -> string) = closure4()
    method2(v37, v38, v39)
    return false 
    (*
    let v40 : bool = *)
    }
    |> fun x -> _v8 <- Some x
    let v41 : Async<bool> = _v8 |> Option.get
    v41
#endif
    |> fun x -> _v1 <- Some x
    let v42 : Async<bool> = _v1.Value
    v42
and closure9 () (v0 : bool) : US4 =
    US4_0(v0)
and closure10 () (v0 : exn) : US4 =
    US4_1(v0)
and closure11 () () : string =
    let v0 : string = "run_with_timeout_async"
    v0
and closure12 (v0 : int32) () : string =
    let v1 : (unit -> string) = closure4()
    let v2 : string = $"timeout: {v0} / {v1 ()}"
    v2
and closure13 (v0 : string) () : string =
    let v1 : string = $"run_with_timeout_async** / ex: {v0}"
    v1
and closure8 (v0 : int32) (v1 : int32) : Async<bool> =
    let v2 : Async<bool> option = None
    let v3 : bool = true in let mutable _v2 = v2
    
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
    let v10 : Async<bool> option = None
    let v11 : bool = true in let mutable _v10 = v10
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v12 : Async<bool> = null |> unbox<Async<bool>>
    v12
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v13 : Async<bool> = null |> unbox<Async<bool>>
    v13
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v14 : Async<bool> = null |> unbox<Async<bool>>
    v14
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v15 : Async<bool> = null |> unbox<Async<bool>>
    v15
#endif
    
#if FABLE_COMPILER_PYTHON
    let v16 : Async<bool> = null |> unbox<Async<bool>>
    v16
#endif
    
#else
    let v17 : Async<bool> option = None
    let mutable _v17 = v17
    async {
    let v18 : Async<System.Threading.CancellationToken> = Async.CancellationToken
    let! v18 = v18 
    let v19 : System.Threading.CancellationToken = v18 
    let v20 : System.Net.Sockets.TcpClient = new System.Net.Sockets.TcpClient ()
    use v20 = v20 
    let v21 : System.Net.Sockets.TcpClient = v20 
    try
    let v22 : string = "127.0.0.1"
    let v23 : System.Threading.Tasks.ValueTask = v21.ConnectAsync (v22, v1, v19)
    let v24 : (unit -> System.Threading.Tasks.Task) = v23.AsTask
    let v25 : System.Threading.Tasks.Task = v24 ()
    let v26 : Async<unit> option = None
    let v27 : bool = true in let mutable _v26 = v26
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v28 : Async<unit> = null |> unbox<Async<unit>>
    v28
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v29 : Async<unit> = null |> unbox<Async<unit>>
    v29
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v30 : Async<unit> = null |> unbox<Async<unit>>
    v30
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v31 : Async<unit> = null |> unbox<Async<unit>>
    v31
#endif
    
#if FABLE_COMPILER_PYTHON
    let v32 : Async<unit> = null |> unbox<Async<unit>>
    v32
#endif
    
#else
    let v33 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
    let v34 : Async<unit> = v33 v25
    v34
#endif
    |> fun x -> _v26 <- Some x
    let v35 : Async<unit> = _v26.Value
    do! v35 
    return true 
    with ex ->
    let v36 : exn = ex
    let v37 : string option = None
    let v38 : bool = true in let mutable _v37 = v37
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v39 : string = $"%A{v36}"
    v39
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v40 : string = $"%A{v36}"
    v40
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v41 : string = $"%A{v36}"
    v41
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v42 : string = $"%A{v36}"
    v42
#endif
    
#if FABLE_COMPILER_PYTHON
    let v43 : string = $"%A{v36}"
    v43
#endif
    
#else
    let v44 : string = $"{v36.GetType ()}: {v36.Message}"
    v44
#endif
    |> fun x -> _v37 <- Some x
    let v45 : string = _v37.Value
    let v46 : US0 = US0_0
    let v47 : (unit -> string) = closure3(v45)
    let v48 : (unit -> string) = closure4()
    method2(v46, v47, v48)
    return false 
    (*
    let v49 : bool = *)
    }
    |> fun x -> _v17 <- Some x
    let v50 : Async<bool> = _v17 |> Option.get
    v50
#endif
    |> fun x -> _v10 <- Some x
    let v51 : Async<bool> = _v10.Value
    let v52 : Async<US3> option = None
    let v53 : bool = true in let mutable _v52 = v52
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v54 : Async<US3> = null |> unbox<Async<US3>>
    v54
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v55 : Async<US3> = null |> unbox<Async<US3>>
    v55
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v56 : Async<US3> = null |> unbox<Async<US3>>
    v56
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v57 : Async<US3> = null |> unbox<Async<US3>>
    v57
#endif
    
#if FABLE_COMPILER_PYTHON
    let v58 : Async<US3> = null |> unbox<Async<US3>>
    v58
#endif
    
#else
    let v59 : Async<US3> option = None
    let v60 : bool = true in let mutable _v59 = v59
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v61 : Async<US3> = null |> unbox<Async<US3>>
    v61
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v62 : Async<US3> = null |> unbox<Async<US3>>
    v62
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v63 : Async<US3> = null |> unbox<Async<US3>>
    v63
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v64 : Async<US3> = null |> unbox<Async<US3>>
    v64
#endif
    
#if FABLE_COMPILER_PYTHON
    let v65 : Async<US3> = null |> unbox<Async<US3>>
    v65
#endif
    
#else
    let v66 : Async<US3> option = None
    let mutable _v66 = v66
    async {
    let v67 : Async<Async<bool>> option = None
    let v68 : bool = true in let mutable _v67 = v67
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v69 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
    v69
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v70 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
    v70
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v71 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
    v71
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v72 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
    v72
#endif
    
#if FABLE_COMPILER_PYTHON
    let v73 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
    v73
#endif
    
#else
    let v74 : Async<Async<bool>> = Async.StartChild (v51, v0)
    v74
#endif
    |> fun x -> _v67 <- Some x
    let v75 : Async<Async<bool>> = _v67.Value
    let! v75 = v75 
    let v76 : Async<bool> = v75 
    let v77 : Async<Choice<bool, exn>> option = None
    let v78 : bool = true in let mutable _v77 = v77
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v79 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
    v79
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v80 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
    v80
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v81 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
    v81
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v82 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
    v82
#endif
    
#if FABLE_COMPILER_PYTHON
    let v83 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
    v83
#endif
    
#else
    let v84 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
    let v85 : Async<Choice<bool, exn>> = v84 v76
    v85
#endif
    |> fun x -> _v77 <- Some x
    let v86 : Async<Choice<bool, exn>> = _v77.Value
    let v87 : Async<US4> option = None
    let v88 : bool = true in let mutable _v87 = v87
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v89 : Async<US4> = null |> unbox<Async<US4>>
    v89
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v90 : Async<US4> = null |> unbox<Async<US4>>
    v90
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v91 : Async<US4> = null |> unbox<Async<US4>>
    v91
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v92 : Async<US4> = null |> unbox<Async<US4>>
    v92
#endif
    
#if FABLE_COMPILER_PYTHON
    let v93 : Async<US4> = null |> unbox<Async<US4>>
    v93
#endif
    
#else
    let v94 : Async<US4> option = None
    let mutable _v94 = v94
    async {
    let! v86 = v86 
    let v95 : Choice<bool, exn> = v86 
    let v96 : US4 option = None
    let v97 : bool = true in let mutable _v96 = v96
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v98 : US4 = null |> unbox<US4>
    v98
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v99 : US4 = null |> unbox<US4>
    v99
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v100 : US4 = null |> unbox<US4>
    v100
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v101 : US4 = null |> unbox<US4>
    v101
#endif
    
#if FABLE_COMPILER_PYTHON
    let v102 : US4 = null |> unbox<US4>
    v102
#endif
    
#else
    let v103 : (bool -> US4) = closure9()
    let v104 : (exn -> US4) = closure10()
    let v105 : US4 = match v95 with Choice1Of2 x -> v103 x | Choice2Of2 x -> v104 x
    v105
#endif
    |> fun x -> _v96 <- Some x
    let v106 : US4 = _v96.Value
    return v106 
    }
    |> fun x -> _v94 <- Some x
    let v107 : Async<US4> = _v94 |> Option.get
    v107
#endif
    |> fun x -> _v87 <- Some x
    let v108 : Async<US4> = _v87.Value
    let v109 : Async<US5> option = None
    let v110 : bool = true in let mutable _v109 = v109
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v111 : Async<US5> = null |> unbox<Async<US5>>
    v111
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v112 : Async<US5> = null |> unbox<Async<US5>>
    v112
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v113 : Async<US5> = null |> unbox<Async<US5>>
    v113
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v114 : Async<US5> = null |> unbox<Async<US5>>
    v114
#endif
    
#if FABLE_COMPILER_PYTHON
    let v115 : Async<US5> = null |> unbox<Async<US5>>
    v115
#endif
    
#else
    let v116 : Async<US5> option = None
    let mutable _v116 = v116
    async {
    let! v108 = v108 
    let v117 : US4 = v108 
    let v123 : US5 =
        match v117 with
        | US4_0(v118) -> (* Choice1Of2 *)
            US5_0(v118)
        | US4_1(v120) -> (* Choice2Of2 *)
            US5_1(v120)
    return v123 
    }
    |> fun x -> _v116 <- Some x
    let v124 : Async<US5> = _v116 |> Option.get
    v124
#endif
    |> fun x -> _v109 <- Some x
    let v125 : Async<US5> = _v109.Value
    let v126 : Async<US3> option = None
    let v127 : bool = true in let mutable _v126 = v126
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v128 : Async<US3> = null |> unbox<Async<US3>>
    v128
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v129 : Async<US3> = null |> unbox<Async<US3>>
    v129
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v130 : Async<US3> = null |> unbox<Async<US3>>
    v130
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v131 : Async<US3> = null |> unbox<Async<US3>>
    v131
#endif
    
#if FABLE_COMPILER_PYTHON
    let v132 : Async<US3> = null |> unbox<Async<US3>>
    v132
#endif
    
#else
    let v133 : Async<US3> option = None
    let mutable _v133 = v133
    async {
    let! v125 = v125 
    let v134 : US5 = v125 
    let v160 : US3 =
        match v134 with
        | US5_1(v137) -> (* Error *)
            let v138 : string = $"%A{v137}"
            let v139 : string = "System.TimeoutException"
            let v140 : bool = v138.Contains v139
            if v140 then
                let v141 : US0 = US0_1
                let v142 : (unit -> string) = closure11()
                let v143 : (unit -> string) = closure12(v0)
                method2(v141, v142, v143)
                US3_1
            else
                let v145 : string option = None
                let v146 : bool = true in let mutable _v145 = v145
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v147 : string = $"%A{v137}"
                v147
#endif
                
#if FABLE_COMPILER_RUST && WASM
                let v148 : string = $"%A{v137}"
                v148
#endif
                
#if FABLE_COMPILER_RUST && CONTRACT
                let v149 : string = $"%A{v137}"
                v149
#endif
                
#if FABLE_COMPILER_TYPESCRIPT
                let v150 : string = $"%A{v137}"
                v150
#endif
                
#if FABLE_COMPILER_PYTHON
                let v151 : string = $"%A{v137}"
                v151
#endif
                
#else
                let v152 : string = $"{v137.GetType ()}: {v137.Message}"
                v152
#endif
                |> fun x -> _v145 <- Some x
                let v153 : string = _v145.Value
                let v154 : US0 = US0_4
                let v155 : (unit -> string) = closure13(v153)
                let v156 : (unit -> string) = closure12(v0)
                method2(v154, v155, v156)
                US3_1
        | US5_0(v135) -> (* Ok *)
            US3_0(v135)
    return v160 
    }
    |> fun x -> _v133 <- Some x
    let v161 : Async<US3> = _v133 |> Option.get
    v161
#endif
    |> fun x -> _v126 <- Some x
    let v162 : Async<US3> = _v126.Value
    return! v162 
    }
    |> fun x -> _v66 <- Some x
    let v163 : Async<US3> = _v66 |> Option.get
    v163
#endif
    |> fun x -> _v59 <- Some x
    let v164 : Async<US3> = _v59.Value
    v164
#endif
    |> fun x -> _v52 <- Some x
    let v165 : Async<US3> = _v52.Value
    let! v165 = v165 
    let v166 : US3 = v165 
    let v169 : bool =
        match v166 with
        | US3_1 -> (* None *)
            false
        | US3_0(v167) -> (* Some *)
            v167
    return v169 
    }
    |> fun x -> _v9 <- Some x
    let v170 : Async<bool> = _v9 |> Option.get
    v170
#endif
    |> fun x -> _v2 <- Some x
    let v171 : Async<bool> = _v2.Value
    v171
and closure7 () (v0 : int32) : (int32 -> Async<bool>) =
    closure8(v0)
and closure17 () (v0 : int32) : US6 =
    US6_0(v0)
and method7 () : (int32 -> US6) =
    closure17()
and closure18 () () : string =
    let v0 : string = "wait_for_port_access"
    v0
and closure19 (v0 : int32 option, v1 : bool, v2 : int32, v3 : int64) () : string =
    let v4 : (unit -> string) = closure4()
    let v5 : string = $"port: {v2} / retry: {v3} / timeout: %A{v0} / status: {v1} / {v4 ()}"
    v5
and method6 (v0 : int32 option, v1 : bool, v2 : int32, v3 : int64) : Async<int64> =
    let v4 : Async<int64> option = None
    let v5 : bool = true in let mutable _v4 = v4
    
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
    let v12 : (int32 -> US6) = method7()
    let v13 : US6 = US6_1
    let v14 : US6 = v0 |> Option.map v12 |> Option.defaultValue v13 
    let v229 : Async<bool> =
        match v14 with
        | US6_1 -> (* None *)
            let v15 : Async<bool> option = None
            let v16 : bool = true in let mutable _v15 = v15
            
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
            let v27 : string = "127.0.0.1"
            let v28 : System.Threading.Tasks.ValueTask = v26.ConnectAsync (v27, v2, v24)
            let v29 : (unit -> System.Threading.Tasks.Task) = v28.AsTask
            let v30 : System.Threading.Tasks.Task = v29 ()
            let v31 : Async<unit> option = None
            let v32 : bool = true in let mutable _v31 = v31
            
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
            let v39 : Async<unit> = v38 v30
            v39
#endif
            |> fun x -> _v31 <- Some x
            let v40 : Async<unit> = _v31.Value
            do! v40 
            return true 
            with ex ->
            let v41 : exn = ex
            let v42 : string option = None
            let v43 : bool = true in let mutable _v42 = v42
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v44 : string = $"%A{v41}"
            v44
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v45 : string = $"%A{v41}"
            v45
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v46 : string = $"%A{v41}"
            v46
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v47 : string = $"%A{v41}"
            v47
#endif
            
#if FABLE_COMPILER_PYTHON
            let v48 : string = $"%A{v41}"
            v48
#endif
            
#else
            let v49 : string = $"{v41.GetType ()}: {v41.Message}"
            v49
#endif
            |> fun x -> _v42 <- Some x
            let v50 : string = _v42.Value
            let v51 : US0 = US0_0
            let v52 : (unit -> string) = closure3(v50)
            let v53 : (unit -> string) = closure4()
            method2(v51, v52, v53)
            return false 
            (*
            let v54 : bool = *)
            }
            |> fun x -> _v22 <- Some x
            let v55 : Async<bool> = _v22 |> Option.get
            v55
#endif
            |> fun x -> _v15 <- Some x
            let v56 : Async<bool> = _v15.Value
            v56
        | US6_0(v57) -> (* Some *)
            let v58 : Async<bool> option = None
            let v59 : bool = true in let mutable _v58 = v58
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v60 : Async<bool> = null |> unbox<Async<bool>>
            v60
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v61 : Async<bool> = null |> unbox<Async<bool>>
            v61
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v62 : Async<bool> = null |> unbox<Async<bool>>
            v62
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v63 : Async<bool> = null |> unbox<Async<bool>>
            v63
#endif
            
#if FABLE_COMPILER_PYTHON
            let v64 : Async<bool> = null |> unbox<Async<bool>>
            v64
#endif
            
#else
            let v65 : Async<bool> option = None
            let mutable _v65 = v65
            async {
            let v66 : Async<bool> option = None
            let v67 : bool = true in let mutable _v66 = v66
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v68 : Async<bool> = null |> unbox<Async<bool>>
            v68
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v69 : Async<bool> = null |> unbox<Async<bool>>
            v69
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v70 : Async<bool> = null |> unbox<Async<bool>>
            v70
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v71 : Async<bool> = null |> unbox<Async<bool>>
            v71
#endif
            
#if FABLE_COMPILER_PYTHON
            let v72 : Async<bool> = null |> unbox<Async<bool>>
            v72
#endif
            
#else
            let v73 : Async<bool> option = None
            let mutable _v73 = v73
            async {
            let v74 : Async<System.Threading.CancellationToken> = Async.CancellationToken
            let! v74 = v74 
            let v75 : System.Threading.CancellationToken = v74 
            let v76 : System.Net.Sockets.TcpClient = new System.Net.Sockets.TcpClient ()
            use v76 = v76 
            let v77 : System.Net.Sockets.TcpClient = v76 
            try
            let v78 : string = "127.0.0.1"
            let v79 : System.Threading.Tasks.ValueTask = v77.ConnectAsync (v78, v2, v75)
            let v80 : (unit -> System.Threading.Tasks.Task) = v79.AsTask
            let v81 : System.Threading.Tasks.Task = v80 ()
            let v82 : Async<unit> option = None
            let v83 : bool = true in let mutable _v82 = v82
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v84 : Async<unit> = null |> unbox<Async<unit>>
            v84
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v85 : Async<unit> = null |> unbox<Async<unit>>
            v85
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v86 : Async<unit> = null |> unbox<Async<unit>>
            v86
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v87 : Async<unit> = null |> unbox<Async<unit>>
            v87
#endif
            
#if FABLE_COMPILER_PYTHON
            let v88 : Async<unit> = null |> unbox<Async<unit>>
            v88
#endif
            
#else
            let v89 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
            let v90 : Async<unit> = v89 v81
            v90
#endif
            |> fun x -> _v82 <- Some x
            let v91 : Async<unit> = _v82.Value
            do! v91 
            return true 
            with ex ->
            let v92 : exn = ex
            let v93 : string option = None
            let v94 : bool = true in let mutable _v93 = v93
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v95 : string = $"%A{v92}"
            v95
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v96 : string = $"%A{v92}"
            v96
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v97 : string = $"%A{v92}"
            v97
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v98 : string = $"%A{v92}"
            v98
#endif
            
#if FABLE_COMPILER_PYTHON
            let v99 : string = $"%A{v92}"
            v99
#endif
            
#else
            let v100 : string = $"{v92.GetType ()}: {v92.Message}"
            v100
#endif
            |> fun x -> _v93 <- Some x
            let v101 : string = _v93.Value
            let v102 : US0 = US0_0
            let v103 : (unit -> string) = closure3(v101)
            let v104 : (unit -> string) = closure4()
            method2(v102, v103, v104)
            return false 
            (*
            let v105 : bool = *)
            }
            |> fun x -> _v73 <- Some x
            let v106 : Async<bool> = _v73 |> Option.get
            v106
#endif
            |> fun x -> _v66 <- Some x
            let v107 : Async<bool> = _v66.Value
            let v108 : Async<US3> option = None
            let v109 : bool = true in let mutable _v108 = v108
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v110 : Async<US3> = null |> unbox<Async<US3>>
            v110
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v111 : Async<US3> = null |> unbox<Async<US3>>
            v111
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v112 : Async<US3> = null |> unbox<Async<US3>>
            v112
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v113 : Async<US3> = null |> unbox<Async<US3>>
            v113
#endif
            
#if FABLE_COMPILER_PYTHON
            let v114 : Async<US3> = null |> unbox<Async<US3>>
            v114
#endif
            
#else
            let v115 : Async<US3> option = None
            let v116 : bool = true in let mutable _v115 = v115
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v117 : Async<US3> = null |> unbox<Async<US3>>
            v117
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v118 : Async<US3> = null |> unbox<Async<US3>>
            v118
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v119 : Async<US3> = null |> unbox<Async<US3>>
            v119
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v120 : Async<US3> = null |> unbox<Async<US3>>
            v120
#endif
            
#if FABLE_COMPILER_PYTHON
            let v121 : Async<US3> = null |> unbox<Async<US3>>
            v121
#endif
            
#else
            let v122 : Async<US3> option = None
            let mutable _v122 = v122
            async {
            let v123 : Async<Async<bool>> option = None
            let v124 : bool = true in let mutable _v123 = v123
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v125 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            v125
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v126 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            v126
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v127 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            v127
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v128 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            v128
#endif
            
#if FABLE_COMPILER_PYTHON
            let v129 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            v129
#endif
            
#else
            let v130 : Async<Async<bool>> = Async.StartChild (v107, v57)
            v130
#endif
            |> fun x -> _v123 <- Some x
            let v131 : Async<Async<bool>> = _v123.Value
            let! v131 = v131 
            let v132 : Async<bool> = v131 
            let v133 : Async<Choice<bool, exn>> option = None
            let v134 : bool = true in let mutable _v133 = v133
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v135 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
            v135
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v136 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
            v136
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v137 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
            v137
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v138 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
            v138
#endif
            
#if FABLE_COMPILER_PYTHON
            let v139 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
            v139
#endif
            
#else
            let v140 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v141 : Async<Choice<bool, exn>> = v140 v132
            v141
#endif
            |> fun x -> _v133 <- Some x
            let v142 : Async<Choice<bool, exn>> = _v133.Value
            let v143 : Async<US4> option = None
            let v144 : bool = true in let mutable _v143 = v143
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v145 : Async<US4> = null |> unbox<Async<US4>>
            v145
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v146 : Async<US4> = null |> unbox<Async<US4>>
            v146
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v147 : Async<US4> = null |> unbox<Async<US4>>
            v147
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v148 : Async<US4> = null |> unbox<Async<US4>>
            v148
#endif
            
#if FABLE_COMPILER_PYTHON
            let v149 : Async<US4> = null |> unbox<Async<US4>>
            v149
#endif
            
#else
            let v150 : Async<US4> option = None
            let mutable _v150 = v150
            async {
            let! v142 = v142 
            let v151 : Choice<bool, exn> = v142 
            let v152 : US4 option = None
            let v153 : bool = true in let mutable _v152 = v152
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v154 : US4 = null |> unbox<US4>
            v154
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v155 : US4 = null |> unbox<US4>
            v155
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v156 : US4 = null |> unbox<US4>
            v156
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v157 : US4 = null |> unbox<US4>
            v157
#endif
            
#if FABLE_COMPILER_PYTHON
            let v158 : US4 = null |> unbox<US4>
            v158
#endif
            
#else
            let v159 : (bool -> US4) = closure9()
            let v160 : (exn -> US4) = closure10()
            let v161 : US4 = match v151 with Choice1Of2 x -> v159 x | Choice2Of2 x -> v160 x
            v161
#endif
            |> fun x -> _v152 <- Some x
            let v162 : US4 = _v152.Value
            return v162 
            }
            |> fun x -> _v150 <- Some x
            let v163 : Async<US4> = _v150 |> Option.get
            v163
#endif
            |> fun x -> _v143 <- Some x
            let v164 : Async<US4> = _v143.Value
            let v165 : Async<US5> option = None
            let v166 : bool = true in let mutable _v165 = v165
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v167 : Async<US5> = null |> unbox<Async<US5>>
            v167
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v168 : Async<US5> = null |> unbox<Async<US5>>
            v168
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v169 : Async<US5> = null |> unbox<Async<US5>>
            v169
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v170 : Async<US5> = null |> unbox<Async<US5>>
            v170
#endif
            
#if FABLE_COMPILER_PYTHON
            let v171 : Async<US5> = null |> unbox<Async<US5>>
            v171
#endif
            
#else
            let v172 : Async<US5> option = None
            let mutable _v172 = v172
            async {
            let! v164 = v164 
            let v173 : US4 = v164 
            let v179 : US5 =
                match v173 with
                | US4_0(v174) -> (* Choice1Of2 *)
                    US5_0(v174)
                | US4_1(v176) -> (* Choice2Of2 *)
                    US5_1(v176)
            return v179 
            }
            |> fun x -> _v172 <- Some x
            let v180 : Async<US5> = _v172 |> Option.get
            v180
#endif
            |> fun x -> _v165 <- Some x
            let v181 : Async<US5> = _v165.Value
            let v182 : Async<US3> option = None
            let v183 : bool = true in let mutable _v182 = v182
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v184 : Async<US3> = null |> unbox<Async<US3>>
            v184
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v185 : Async<US3> = null |> unbox<Async<US3>>
            v185
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v186 : Async<US3> = null |> unbox<Async<US3>>
            v186
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v187 : Async<US3> = null |> unbox<Async<US3>>
            v187
#endif
            
#if FABLE_COMPILER_PYTHON
            let v188 : Async<US3> = null |> unbox<Async<US3>>
            v188
#endif
            
#else
            let v189 : Async<US3> option = None
            let mutable _v189 = v189
            async {
            let! v181 = v181 
            let v190 : US5 = v181 
            let v216 : US3 =
                match v190 with
                | US5_1(v193) -> (* Error *)
                    let v194 : string = $"%A{v193}"
                    let v195 : string = "System.TimeoutException"
                    let v196 : bool = v194.Contains v195
                    if v196 then
                        let v197 : US0 = US0_1
                        let v198 : (unit -> string) = closure11()
                        let v199 : (unit -> string) = closure12(v57)
                        method2(v197, v198, v199)
                        US3_1
                    else
                        let v201 : string option = None
                        let v202 : bool = true in let mutable _v201 = v201
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v203 : string = $"%A{v193}"
                        v203
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v204 : string = $"%A{v193}"
                        v204
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v205 : string = $"%A{v193}"
                        v205
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v206 : string = $"%A{v193}"
                        v206
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v207 : string = $"%A{v193}"
                        v207
#endif
                        
#else
                        let v208 : string = $"{v193.GetType ()}: {v193.Message}"
                        v208
#endif
                        |> fun x -> _v201 <- Some x
                        let v209 : string = _v201.Value
                        let v210 : US0 = US0_4
                        let v211 : (unit -> string) = closure13(v209)
                        let v212 : (unit -> string) = closure12(v57)
                        method2(v210, v211, v212)
                        US3_1
                | US5_0(v191) -> (* Ok *)
                    US3_0(v191)
            return v216 
            }
            |> fun x -> _v189 <- Some x
            let v217 : Async<US3> = _v189 |> Option.get
            v217
#endif
            |> fun x -> _v182 <- Some x
            let v218 : Async<US3> = _v182.Value
            return! v218 
            }
            |> fun x -> _v122 <- Some x
            let v219 : Async<US3> = _v122 |> Option.get
            v219
#endif
            |> fun x -> _v115 <- Some x
            let v220 : Async<US3> = _v115.Value
            v220
#endif
            |> fun x -> _v108 <- Some x
            let v221 : Async<US3> = _v108.Value
            let! v221 = v221 
            let v222 : US3 = v221 
            let v225 : bool =
                match v222 with
                | US3_1 -> (* None *)
                    false
                | US3_0(v223) -> (* Some *)
                    v223
            return v225 
            }
            |> fun x -> _v65 <- Some x
            let v226 : Async<bool> = _v65 |> Option.get
            v226
#endif
            |> fun x -> _v58 <- Some x
            let v227 : Async<bool> = _v58.Value
            v227
    let! v229 = v229 
    let v230 : bool = v229 
    let v231 : bool = v230 = v1
    if v231 then
        return v3 
        (*
        ()
    else
        *) else
        let v232 : int64 = v3 % 100L
        let v233 : bool = v232 = 0L
        if v233 then
            let v234 : US0 = US0_0
            let v235 : (unit -> string) = closure18()
            let v236 : (unit -> string) = closure19(v0, v1, v2, v3)
            method2(v234, v235, v236)
        let v237 : Async<unit> option = None
        let v238 : bool = true in let mutable _v237 = v237
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v239 : Async<unit> = null |> unbox<Async<unit>>
        v239
#endif
        
#if FABLE_COMPILER_RUST && WASM
        let v240 : Async<unit> = null |> unbox<Async<unit>>
        v240
#endif
        
#if FABLE_COMPILER_RUST && CONTRACT
        let v241 : Async<unit> = null |> unbox<Async<unit>>
        v241
#endif
        
#if FABLE_COMPILER_TYPESCRIPT
        let v242 : Async<unit> = null |> unbox<Async<unit>>
        v242
#endif
        
#if FABLE_COMPILER_PYTHON
        let v243 : Async<unit> = null |> unbox<Async<unit>>
        v243
#endif
        
#else
        let v244 : (int32 -> Async<unit>) = Async.Sleep
        let v245 : Async<unit> = v244 10
        v245
#endif
        |> fun x -> _v237 <- Some x
        let v246 : Async<unit> = _v237.Value
        do! v246 
        let v247 : int64 = v3 + 1L
        let v248 : Async<int64> = method6(v0, v1, v2, v247)
        return! v248 
        (*
        ()
    *)
    }
    |> fun x -> _v11 <- Some x
    let v249 : Async<int64> = _v11 |> Option.get
    v249
#endif
    |> fun x -> _v4 <- Some x
    let v250 : Async<int64> = _v4.Value
    v250
and closure20 () (v0 : int64) : US7 =
    US7_0(v0)
and closure21 () (v0 : exn) : US7 =
    US7_1(v0)
and closure16 (v0 : int32 option, v1 : bool) (v2 : int32) : Async<int64> =
    let v3 : int64 = 0L
    let v4 : Async<int64> = method6(v0, v1, v2, v3)
    let v5 : (int32 -> US6) = method7()
    let v6 : US6 = US6_1
    let v7 : US6 = v0 |> Option.map v5 |> Option.defaultValue v6 
    match v7 with
    | US6_1 -> (* None *)
        v4
    | US6_0(v8) -> (* Some *)
        let v9 : Async<US2> option = None
        let v10 : bool = true in let mutable _v9 = v9
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v11 : Async<US2> = null |> unbox<Async<US2>>
        v11
#endif
        
#if FABLE_COMPILER_RUST && WASM
        let v12 : Async<US2> = null |> unbox<Async<US2>>
        v12
#endif
        
#if FABLE_COMPILER_RUST && CONTRACT
        let v13 : Async<US2> = null |> unbox<Async<US2>>
        v13
#endif
        
#if FABLE_COMPILER_TYPESCRIPT
        let v14 : Async<US2> = null |> unbox<Async<US2>>
        v14
#endif
        
#if FABLE_COMPILER_PYTHON
        let v15 : Async<US2> = null |> unbox<Async<US2>>
        v15
#endif
        
#else
        let v16 : Async<US2> option = None
        let v17 : bool = true in let mutable _v16 = v16
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v18 : Async<US2> = null |> unbox<Async<US2>>
        v18
#endif
        
#if FABLE_COMPILER_RUST && WASM
        let v19 : Async<US2> = null |> unbox<Async<US2>>
        v19
#endif
        
#if FABLE_COMPILER_RUST && CONTRACT
        let v20 : Async<US2> = null |> unbox<Async<US2>>
        v20
#endif
        
#if FABLE_COMPILER_TYPESCRIPT
        let v21 : Async<US2> = null |> unbox<Async<US2>>
        v21
#endif
        
#if FABLE_COMPILER_PYTHON
        let v22 : Async<US2> = null |> unbox<Async<US2>>
        v22
#endif
        
#else
        let v23 : Async<US2> option = None
        let mutable _v23 = v23
        async {
        let v24 : Async<Async<int64>> option = None
        let v25 : bool = true in let mutable _v24 = v24
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v26 : Async<Async<int64>> = null |> unbox<Async<Async<int64>>>
        v26
#endif
        
#if FABLE_COMPILER_RUST && WASM
        let v27 : Async<Async<int64>> = null |> unbox<Async<Async<int64>>>
        v27
#endif
        
#if FABLE_COMPILER_RUST && CONTRACT
        let v28 : Async<Async<int64>> = null |> unbox<Async<Async<int64>>>
        v28
#endif
        
#if FABLE_COMPILER_TYPESCRIPT
        let v29 : Async<Async<int64>> = null |> unbox<Async<Async<int64>>>
        v29
#endif
        
#if FABLE_COMPILER_PYTHON
        let v30 : Async<Async<int64>> = null |> unbox<Async<Async<int64>>>
        v30
#endif
        
#else
        let v31 : Async<Async<int64>> = Async.StartChild (v4, v8)
        v31
#endif
        |> fun x -> _v24 <- Some x
        let v32 : Async<Async<int64>> = _v24.Value
        let! v32 = v32 
        let v33 : Async<int64> = v32 
        let v34 : Async<Choice<int64, exn>> option = None
        let v35 : bool = true in let mutable _v34 = v34
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v36 : Async<Choice<int64, exn>> = null |> unbox<Async<Choice<int64, exn>>>
        v36
#endif
        
#if FABLE_COMPILER_RUST && WASM
        let v37 : Async<Choice<int64, exn>> = null |> unbox<Async<Choice<int64, exn>>>
        v37
#endif
        
#if FABLE_COMPILER_RUST && CONTRACT
        let v38 : Async<Choice<int64, exn>> = null |> unbox<Async<Choice<int64, exn>>>
        v38
#endif
        
#if FABLE_COMPILER_TYPESCRIPT
        let v39 : Async<Choice<int64, exn>> = null |> unbox<Async<Choice<int64, exn>>>
        v39
#endif
        
#if FABLE_COMPILER_PYTHON
        let v40 : Async<Choice<int64, exn>> = null |> unbox<Async<Choice<int64, exn>>>
        v40
#endif
        
#else
        let v41 : (Async<int64> -> Async<Choice<int64, exn>>) = Async.Catch
        let v42 : Async<Choice<int64, exn>> = v41 v33
        v42
#endif
        |> fun x -> _v34 <- Some x
        let v43 : Async<Choice<int64, exn>> = _v34.Value
        let v44 : Async<US7> option = None
        let v45 : bool = true in let mutable _v44 = v44
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v46 : Async<US7> = null |> unbox<Async<US7>>
        v46
#endif
        
#if FABLE_COMPILER_RUST && WASM
        let v47 : Async<US7> = null |> unbox<Async<US7>>
        v47
#endif
        
#if FABLE_COMPILER_RUST && CONTRACT
        let v48 : Async<US7> = null |> unbox<Async<US7>>
        v48
#endif
        
#if FABLE_COMPILER_TYPESCRIPT
        let v49 : Async<US7> = null |> unbox<Async<US7>>
        v49
#endif
        
#if FABLE_COMPILER_PYTHON
        let v50 : Async<US7> = null |> unbox<Async<US7>>
        v50
#endif
        
#else
        let v51 : Async<US7> option = None
        let mutable _v51 = v51
        async {
        let! v43 = v43 
        let v52 : Choice<int64, exn> = v43 
        let v53 : US7 option = None
        let v54 : bool = true in let mutable _v53 = v53
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v55 : US7 = null |> unbox<US7>
        v55
#endif
        
#if FABLE_COMPILER_RUST && WASM
        let v56 : US7 = null |> unbox<US7>
        v56
#endif
        
#if FABLE_COMPILER_RUST && CONTRACT
        let v57 : US7 = null |> unbox<US7>
        v57
#endif
        
#if FABLE_COMPILER_TYPESCRIPT
        let v58 : US7 = null |> unbox<US7>
        v58
#endif
        
#if FABLE_COMPILER_PYTHON
        let v59 : US7 = null |> unbox<US7>
        v59
#endif
        
#else
        let v60 : (int64 -> US7) = closure20()
        let v61 : (exn -> US7) = closure21()
        let v62 : US7 = match v52 with Choice1Of2 x -> v60 x | Choice2Of2 x -> v61 x
        v62
#endif
        |> fun x -> _v53 <- Some x
        let v63 : US7 = _v53.Value
        return v63 
        }
        |> fun x -> _v51 <- Some x
        let v64 : Async<US7> = _v51 |> Option.get
        v64
#endif
        |> fun x -> _v44 <- Some x
        let v65 : Async<US7> = _v44.Value
        let v66 : Async<US8> option = None
        let v67 : bool = true in let mutable _v66 = v66
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v68 : Async<US8> = null |> unbox<Async<US8>>
        v68
#endif
        
#if FABLE_COMPILER_RUST && WASM
        let v69 : Async<US8> = null |> unbox<Async<US8>>
        v69
#endif
        
#if FABLE_COMPILER_RUST && CONTRACT
        let v70 : Async<US8> = null |> unbox<Async<US8>>
        v70
#endif
        
#if FABLE_COMPILER_TYPESCRIPT
        let v71 : Async<US8> = null |> unbox<Async<US8>>
        v71
#endif
        
#if FABLE_COMPILER_PYTHON
        let v72 : Async<US8> = null |> unbox<Async<US8>>
        v72
#endif
        
#else
        let v73 : Async<US8> option = None
        let mutable _v73 = v73
        async {
        let! v65 = v65 
        let v74 : US7 = v65 
        let v80 : US8 =
            match v74 with
            | US7_0(v75) -> (* Choice1Of2 *)
                US8_0(v75)
            | US7_1(v77) -> (* Choice2Of2 *)
                US8_1(v77)
        return v80 
        }
        |> fun x -> _v73 <- Some x
        let v81 : Async<US8> = _v73 |> Option.get
        v81
#endif
        |> fun x -> _v66 <- Some x
        let v82 : Async<US8> = _v66.Value
        let v83 : Async<US2> option = None
        let v84 : bool = true in let mutable _v83 = v83
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v85 : Async<US2> = null |> unbox<Async<US2>>
        v85
#endif
        
#if FABLE_COMPILER_RUST && WASM
        let v86 : Async<US2> = null |> unbox<Async<US2>>
        v86
#endif
        
#if FABLE_COMPILER_RUST && CONTRACT
        let v87 : Async<US2> = null |> unbox<Async<US2>>
        v87
#endif
        
#if FABLE_COMPILER_TYPESCRIPT
        let v88 : Async<US2> = null |> unbox<Async<US2>>
        v88
#endif
        
#if FABLE_COMPILER_PYTHON
        let v89 : Async<US2> = null |> unbox<Async<US2>>
        v89
#endif
        
#else
        let v90 : Async<US2> option = None
        let mutable _v90 = v90
        async {
        let! v82 = v82 
        let v91 : US8 = v82 
        let v117 : US2 =
            match v91 with
            | US8_1(v94) -> (* Error *)
                let v95 : string = $"%A{v94}"
                let v96 : string = "System.TimeoutException"
                let v97 : bool = v95.Contains v96
                if v97 then
                    let v98 : US0 = US0_1
                    let v99 : (unit -> string) = closure11()
                    let v100 : (unit -> string) = closure12(v8)
                    method2(v98, v99, v100)
                    US2_1
                else
                    let v102 : string option = None
                    let v103 : bool = true in let mutable _v102 = v102
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v104 : string = $"%A{v94}"
                    v104
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let v105 : string = $"%A{v94}"
                    v105
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let v106 : string = $"%A{v94}"
                    v106
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let v107 : string = $"%A{v94}"
                    v107
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let v108 : string = $"%A{v94}"
                    v108
#endif
                    
#else
                    let v109 : string = $"{v94.GetType ()}: {v94.Message}"
                    v109
#endif
                    |> fun x -> _v102 <- Some x
                    let v110 : string = _v102.Value
                    let v111 : US0 = US0_4
                    let v112 : (unit -> string) = closure13(v110)
                    let v113 : (unit -> string) = closure12(v8)
                    method2(v111, v112, v113)
                    US2_1
            | US8_0(v92) -> (* Ok *)
                US2_0(v92)
        return v117 
        }
        |> fun x -> _v90 <- Some x
        let v118 : Async<US2> = _v90 |> Option.get
        v118
#endif
        |> fun x -> _v83 <- Some x
        let v119 : Async<US2> = _v83.Value
        return! v119 
        }
        |> fun x -> _v23 <- Some x
        let v120 : Async<US2> = _v23 |> Option.get
        v120
#endif
        |> fun x -> _v16 <- Some x
        let v121 : Async<US2> = _v16.Value
        v121
#endif
        |> fun x -> _v9 <- Some x
        let v122 : Async<US2> = _v9.Value
        let v123 : Async<int64> option = None
        let v124 : bool = true in let mutable _v123 = v123
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v125 : Async<int64> = null |> unbox<Async<int64>>
        v125
#endif
        
#if FABLE_COMPILER_RUST && WASM
        let v126 : Async<int64> = null |> unbox<Async<int64>>
        v126
#endif
        
#if FABLE_COMPILER_RUST && CONTRACT
        let v127 : Async<int64> = null |> unbox<Async<int64>>
        v127
#endif
        
#if FABLE_COMPILER_TYPESCRIPT
        let v128 : Async<int64> = null |> unbox<Async<int64>>
        v128
#endif
        
#if FABLE_COMPILER_PYTHON
        let v129 : Async<int64> = null |> unbox<Async<int64>>
        v129
#endif
        
#else
        let v130 : Async<int64> option = None
        let mutable _v130 = v130
        async {
        let! v122 = v122 
        let v131 : US2 = v122 
        let v135 : int64 =
            match v131 with
            | US2_1 -> (* None *)
                failwith<int64> "Option does not have a value."
            | US2_0(v132) -> (* Some *)
                v132
        return v135 
        }
        |> fun x -> _v130 <- Some x
        let v136 : Async<int64> = _v130 |> Option.get
        v136
#endif
        |> fun x -> _v123 <- Some x
        let v137 : Async<int64> = _v123.Value
        v137
and closure15 (v0 : int32 option) (v1 : bool) : (int32 -> Async<int64>) =
    closure16(v0, v1)
and closure14 () (v0 : int32 option) : (bool -> (int32 -> Async<int64>)) =
    closure15(v0)
and method8 (v0 : int32 option, v1 : int32) : Async<int32> =
    let v2 : Async<int32> option = None
    let v3 : bool = true in let mutable _v2 = v2
    
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
    let v10 : (int32 -> US6) = method7()
    let v11 : US6 = US6_1
    let v12 : US6 = v0 |> Option.map v10 |> Option.defaultValue v11 
    let v227 : Async<bool> =
        match v12 with
        | US6_1 -> (* None *)
            let v13 : Async<bool> option = None
            let v14 : bool = true in let mutable _v13 = v13
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v15 : Async<bool> = null |> unbox<Async<bool>>
            v15
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v16 : Async<bool> = null |> unbox<Async<bool>>
            v16
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v17 : Async<bool> = null |> unbox<Async<bool>>
            v17
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v18 : Async<bool> = null |> unbox<Async<bool>>
            v18
#endif
            
#if FABLE_COMPILER_PYTHON
            let v19 : Async<bool> = null |> unbox<Async<bool>>
            v19
#endif
            
#else
            let v20 : Async<bool> option = None
            let mutable _v20 = v20
            async {
            let v21 : Async<System.Threading.CancellationToken> = Async.CancellationToken
            let! v21 = v21 
            let v22 : System.Threading.CancellationToken = v21 
            let v23 : System.Net.Sockets.TcpClient = new System.Net.Sockets.TcpClient ()
            use v23 = v23 
            let v24 : System.Net.Sockets.TcpClient = v23 
            try
            let v25 : string = "127.0.0.1"
            let v26 : System.Threading.Tasks.ValueTask = v24.ConnectAsync (v25, v1, v22)
            let v27 : (unit -> System.Threading.Tasks.Task) = v26.AsTask
            let v28 : System.Threading.Tasks.Task = v27 ()
            let v29 : Async<unit> option = None
            let v30 : bool = true in let mutable _v29 = v29
            
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
            let v37 : Async<unit> = v36 v28
            v37
#endif
            |> fun x -> _v29 <- Some x
            let v38 : Async<unit> = _v29.Value
            do! v38 
            return true 
            with ex ->
            let v39 : exn = ex
            let v40 : string option = None
            let v41 : bool = true in let mutable _v40 = v40
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v42 : string = $"%A{v39}"
            v42
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v43 : string = $"%A{v39}"
            v43
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v44 : string = $"%A{v39}"
            v44
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v45 : string = $"%A{v39}"
            v45
#endif
            
#if FABLE_COMPILER_PYTHON
            let v46 : string = $"%A{v39}"
            v46
#endif
            
#else
            let v47 : string = $"{v39.GetType ()}: {v39.Message}"
            v47
#endif
            |> fun x -> _v40 <- Some x
            let v48 : string = _v40.Value
            let v49 : US0 = US0_0
            let v50 : (unit -> string) = closure3(v48)
            let v51 : (unit -> string) = closure4()
            method2(v49, v50, v51)
            return false 
            (*
            let v52 : bool = *)
            }
            |> fun x -> _v20 <- Some x
            let v53 : Async<bool> = _v20 |> Option.get
            v53
#endif
            |> fun x -> _v13 <- Some x
            let v54 : Async<bool> = _v13.Value
            v54
        | US6_0(v55) -> (* Some *)
            let v56 : Async<bool> option = None
            let v57 : bool = true in let mutable _v56 = v56
            
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
            let v64 : Async<bool> option = None
            let v65 : bool = true in let mutable _v64 = v64
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v66 : Async<bool> = null |> unbox<Async<bool>>
            v66
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v67 : Async<bool> = null |> unbox<Async<bool>>
            v67
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v68 : Async<bool> = null |> unbox<Async<bool>>
            v68
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v69 : Async<bool> = null |> unbox<Async<bool>>
            v69
#endif
            
#if FABLE_COMPILER_PYTHON
            let v70 : Async<bool> = null |> unbox<Async<bool>>
            v70
#endif
            
#else
            let v71 : Async<bool> option = None
            let mutable _v71 = v71
            async {
            let v72 : Async<System.Threading.CancellationToken> = Async.CancellationToken
            let! v72 = v72 
            let v73 : System.Threading.CancellationToken = v72 
            let v74 : System.Net.Sockets.TcpClient = new System.Net.Sockets.TcpClient ()
            use v74 = v74 
            let v75 : System.Net.Sockets.TcpClient = v74 
            try
            let v76 : string = "127.0.0.1"
            let v77 : System.Threading.Tasks.ValueTask = v75.ConnectAsync (v76, v1, v73)
            let v78 : (unit -> System.Threading.Tasks.Task) = v77.AsTask
            let v79 : System.Threading.Tasks.Task = v78 ()
            let v80 : Async<unit> option = None
            let v81 : bool = true in let mutable _v80 = v80
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v82 : Async<unit> = null |> unbox<Async<unit>>
            v82
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v83 : Async<unit> = null |> unbox<Async<unit>>
            v83
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v84 : Async<unit> = null |> unbox<Async<unit>>
            v84
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v85 : Async<unit> = null |> unbox<Async<unit>>
            v85
#endif
            
#if FABLE_COMPILER_PYTHON
            let v86 : Async<unit> = null |> unbox<Async<unit>>
            v86
#endif
            
#else
            let v87 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
            let v88 : Async<unit> = v87 v79
            v88
#endif
            |> fun x -> _v80 <- Some x
            let v89 : Async<unit> = _v80.Value
            do! v89 
            return true 
            with ex ->
            let v90 : exn = ex
            let v91 : string option = None
            let v92 : bool = true in let mutable _v91 = v91
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v93 : string = $"%A{v90}"
            v93
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v94 : string = $"%A{v90}"
            v94
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v95 : string = $"%A{v90}"
            v95
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v96 : string = $"%A{v90}"
            v96
#endif
            
#if FABLE_COMPILER_PYTHON
            let v97 : string = $"%A{v90}"
            v97
#endif
            
#else
            let v98 : string = $"{v90.GetType ()}: {v90.Message}"
            v98
#endif
            |> fun x -> _v91 <- Some x
            let v99 : string = _v91.Value
            let v100 : US0 = US0_0
            let v101 : (unit -> string) = closure3(v99)
            let v102 : (unit -> string) = closure4()
            method2(v100, v101, v102)
            return false 
            (*
            let v103 : bool = *)
            }
            |> fun x -> _v71 <- Some x
            let v104 : Async<bool> = _v71 |> Option.get
            v104
#endif
            |> fun x -> _v64 <- Some x
            let v105 : Async<bool> = _v64.Value
            let v106 : Async<US3> option = None
            let v107 : bool = true in let mutable _v106 = v106
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v108 : Async<US3> = null |> unbox<Async<US3>>
            v108
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v109 : Async<US3> = null |> unbox<Async<US3>>
            v109
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v110 : Async<US3> = null |> unbox<Async<US3>>
            v110
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v111 : Async<US3> = null |> unbox<Async<US3>>
            v111
#endif
            
#if FABLE_COMPILER_PYTHON
            let v112 : Async<US3> = null |> unbox<Async<US3>>
            v112
#endif
            
#else
            let v113 : Async<US3> option = None
            let v114 : bool = true in let mutable _v113 = v113
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v115 : Async<US3> = null |> unbox<Async<US3>>
            v115
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v116 : Async<US3> = null |> unbox<Async<US3>>
            v116
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v117 : Async<US3> = null |> unbox<Async<US3>>
            v117
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v118 : Async<US3> = null |> unbox<Async<US3>>
            v118
#endif
            
#if FABLE_COMPILER_PYTHON
            let v119 : Async<US3> = null |> unbox<Async<US3>>
            v119
#endif
            
#else
            let v120 : Async<US3> option = None
            let mutable _v120 = v120
            async {
            let v121 : Async<Async<bool>> option = None
            let v122 : bool = true in let mutable _v121 = v121
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v123 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            v123
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v124 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            v124
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v125 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            v125
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v126 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            v126
#endif
            
#if FABLE_COMPILER_PYTHON
            let v127 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            v127
#endif
            
#else
            let v128 : Async<Async<bool>> = Async.StartChild (v105, v55)
            v128
#endif
            |> fun x -> _v121 <- Some x
            let v129 : Async<Async<bool>> = _v121.Value
            let! v129 = v129 
            let v130 : Async<bool> = v129 
            let v131 : Async<Choice<bool, exn>> option = None
            let v132 : bool = true in let mutable _v131 = v131
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v133 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
            v133
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v134 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
            v134
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v135 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
            v135
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v136 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
            v136
#endif
            
#if FABLE_COMPILER_PYTHON
            let v137 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
            v137
#endif
            
#else
            let v138 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v139 : Async<Choice<bool, exn>> = v138 v130
            v139
#endif
            |> fun x -> _v131 <- Some x
            let v140 : Async<Choice<bool, exn>> = _v131.Value
            let v141 : Async<US4> option = None
            let v142 : bool = true in let mutable _v141 = v141
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v143 : Async<US4> = null |> unbox<Async<US4>>
            v143
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v144 : Async<US4> = null |> unbox<Async<US4>>
            v144
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v145 : Async<US4> = null |> unbox<Async<US4>>
            v145
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v146 : Async<US4> = null |> unbox<Async<US4>>
            v146
#endif
            
#if FABLE_COMPILER_PYTHON
            let v147 : Async<US4> = null |> unbox<Async<US4>>
            v147
#endif
            
#else
            let v148 : Async<US4> option = None
            let mutable _v148 = v148
            async {
            let! v140 = v140 
            let v149 : Choice<bool, exn> = v140 
            let v150 : US4 option = None
            let v151 : bool = true in let mutable _v150 = v150
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v152 : US4 = null |> unbox<US4>
            v152
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v153 : US4 = null |> unbox<US4>
            v153
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v154 : US4 = null |> unbox<US4>
            v154
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v155 : US4 = null |> unbox<US4>
            v155
#endif
            
#if FABLE_COMPILER_PYTHON
            let v156 : US4 = null |> unbox<US4>
            v156
#endif
            
#else
            let v157 : (bool -> US4) = closure9()
            let v158 : (exn -> US4) = closure10()
            let v159 : US4 = match v149 with Choice1Of2 x -> v157 x | Choice2Of2 x -> v158 x
            v159
#endif
            |> fun x -> _v150 <- Some x
            let v160 : US4 = _v150.Value
            return v160 
            }
            |> fun x -> _v148 <- Some x
            let v161 : Async<US4> = _v148 |> Option.get
            v161
#endif
            |> fun x -> _v141 <- Some x
            let v162 : Async<US4> = _v141.Value
            let v163 : Async<US5> option = None
            let v164 : bool = true in let mutable _v163 = v163
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v165 : Async<US5> = null |> unbox<Async<US5>>
            v165
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v166 : Async<US5> = null |> unbox<Async<US5>>
            v166
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v167 : Async<US5> = null |> unbox<Async<US5>>
            v167
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v168 : Async<US5> = null |> unbox<Async<US5>>
            v168
#endif
            
#if FABLE_COMPILER_PYTHON
            let v169 : Async<US5> = null |> unbox<Async<US5>>
            v169
#endif
            
#else
            let v170 : Async<US5> option = None
            let mutable _v170 = v170
            async {
            let! v162 = v162 
            let v171 : US4 = v162 
            let v177 : US5 =
                match v171 with
                | US4_0(v172) -> (* Choice1Of2 *)
                    US5_0(v172)
                | US4_1(v174) -> (* Choice2Of2 *)
                    US5_1(v174)
            return v177 
            }
            |> fun x -> _v170 <- Some x
            let v178 : Async<US5> = _v170 |> Option.get
            v178
#endif
            |> fun x -> _v163 <- Some x
            let v179 : Async<US5> = _v163.Value
            let v180 : Async<US3> option = None
            let v181 : bool = true in let mutable _v180 = v180
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v182 : Async<US3> = null |> unbox<Async<US3>>
            v182
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v183 : Async<US3> = null |> unbox<Async<US3>>
            v183
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v184 : Async<US3> = null |> unbox<Async<US3>>
            v184
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v185 : Async<US3> = null |> unbox<Async<US3>>
            v185
#endif
            
#if FABLE_COMPILER_PYTHON
            let v186 : Async<US3> = null |> unbox<Async<US3>>
            v186
#endif
            
#else
            let v187 : Async<US3> option = None
            let mutable _v187 = v187
            async {
            let! v179 = v179 
            let v188 : US5 = v179 
            let v214 : US3 =
                match v188 with
                | US5_1(v191) -> (* Error *)
                    let v192 : string = $"%A{v191}"
                    let v193 : string = "System.TimeoutException"
                    let v194 : bool = v192.Contains v193
                    if v194 then
                        let v195 : US0 = US0_1
                        let v196 : (unit -> string) = closure11()
                        let v197 : (unit -> string) = closure12(v55)
                        method2(v195, v196, v197)
                        US3_1
                    else
                        let v199 : string option = None
                        let v200 : bool = true in let mutable _v199 = v199
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v201 : string = $"%A{v191}"
                        v201
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v202 : string = $"%A{v191}"
                        v202
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v203 : string = $"%A{v191}"
                        v203
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v204 : string = $"%A{v191}"
                        v204
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v205 : string = $"%A{v191}"
                        v205
#endif
                        
#else
                        let v206 : string = $"{v191.GetType ()}: {v191.Message}"
                        v206
#endif
                        |> fun x -> _v199 <- Some x
                        let v207 : string = _v199.Value
                        let v208 : US0 = US0_4
                        let v209 : (unit -> string) = closure13(v207)
                        let v210 : (unit -> string) = closure12(v55)
                        method2(v208, v209, v210)
                        US3_1
                | US5_0(v189) -> (* Ok *)
                    US3_0(v189)
            return v214 
            }
            |> fun x -> _v187 <- Some x
            let v215 : Async<US3> = _v187 |> Option.get
            v215
#endif
            |> fun x -> _v180 <- Some x
            let v216 : Async<US3> = _v180.Value
            return! v216 
            }
            |> fun x -> _v120 <- Some x
            let v217 : Async<US3> = _v120 |> Option.get
            v217
#endif
            |> fun x -> _v113 <- Some x
            let v218 : Async<US3> = _v113.Value
            v218
#endif
            |> fun x -> _v106 <- Some x
            let v219 : Async<US3> = _v106.Value
            let! v219 = v219 
            let v220 : US3 = v219 
            let v223 : bool =
                match v220 with
                | US3_1 -> (* None *)
                    false
                | US3_0(v221) -> (* Some *)
                    v221
            return v223 
            }
            |> fun x -> _v63 <- Some x
            let v224 : Async<bool> = _v63 |> Option.get
            v224
#endif
            |> fun x -> _v56 <- Some x
            let v225 : Async<bool> = _v56.Value
            v225
    let! v227 = v227 
    let v228 : bool = v227 
    let v229 : bool = v228 = false
    if v229 then
        return v1 
        (*
        ()
    else
        *) else
        let v230 : int32 = v1 + 1
        let v231 : Async<int32> = method8(v0, v230)
        return! v231 
        (*
        ()
    *)
    }
    |> fun x -> _v9 <- Some x
    let v232 : Async<int32> = _v9 |> Option.get
    v232
#endif
    |> fun x -> _v2 <- Some x
    let v233 : Async<int32> = _v2.Value
    v233
and closure23 (v0 : int32 option) (v1 : int32) : Async<int32> =
    method8(v0, v1)
and closure22 () (v0 : int32 option) : (int32 -> Async<int32>) =
    closure23(v0)
let v0 : (unit -> struct (Mut0 * Mut1 * Mut2 * int64 option * Mut3)) = closure0()
if State.trace_state.IsNone then State.trace_state <- v0 () |> Some
let v1 : (int32 -> Async<bool>) = closure2()
let test_port_open x = v1 x
let v2 : (int32 -> (int32 -> Async<bool>)) = closure7()
let test_port_open_timeout x = v2 x
let v3 : (int32 option -> (bool -> (int32 -> Async<int64>))) = closure14()
let wait_for_port_access x = v3 x
let v4 : (int32 option -> (int32 -> Async<int32>)) = closure22()
let get_available_port x = v4 x
()
