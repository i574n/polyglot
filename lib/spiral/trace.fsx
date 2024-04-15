#if FABLE_COMPILER // trace.types
[<Fable.Core.Erase; Fable.Core.Emit("Func0<$0>")>] type Func0<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("Func1<$0, $1>")>] type Func0<'T, 'U> = class end
[<Fable.Core.Erase; Fable.Core.Emit("Box<$0>")>] type Box<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("dyn $0")>] type Dyn<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("Fn() -> $0")>] type Fn<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("Fn()")>] type FnUnit = class end
[<Fable.Core.Erase; Fable.Core.Emit("FnOnce() -> $0")>] type FnOnce<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("Fn($0, $1)")>] type ActionFn2<'T, 'U> = class end
[<Fable.Core.Erase; Fable.Core.Emit("impl $0")>] type Impl<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("mut $0")>] type Mut<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("&$0")>] type Ref<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("&'static $0")>] type StaticRef<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("MutCell<$0>")>] type MutCell<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("std::any::Any")>] type std_any_Any = class end
[<Fable.Core.Erase; Fable.Core.Emit("std::cell::RefCell<$0>")>] type std_cell_RefCell<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("std::pin::Pin<$0>")>] type std_pin_Pin<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("std::rc::Rc<$0>")>] type std_rc_Rc<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("std::rc::Weak<$0>")>] type std_rc_Weak<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("std::sync::Arc<$0>")>] type std_sync_Arc<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("str")>] type Str = class end
[<Fable.Core.Erase; Fable.Core.Emit("base64::DecodeError")>] type base64_DecodeError = class end
[<Fable.Core.Erase; Fable.Core.Emit("borsh::io::Error")>] type borsh_io_Error = class end
[<Fable.Core.Erase; Fable.Core.Emit("js_sys::JsString")>] type js_sys_JsString = class end
[<Fable.Core.Erase; Fable.Core.Emit("serde_json::Error")>] type serde_json_Error = class end
[<Fable.Core.Erase; Fable.Core.Emit("serde_json::Value")>] type serde_json_Value = class end
[<Fable.Core.Erase; Fable.Core.Emit("serde_wasm_bindgen::Error")>] type serde_wasm_bindgen_Error = class end
[<Fable.Core.Erase; Fable.Core.Emit("std::ffi::OsStr")>] type std_ffi_OsStr = class end
[<Fable.Core.Erase; Fable.Core.Emit("std::ffi::OsString")>] type std_ffi_OsString = class end
[<Fable.Core.Erase; Fable.Core.Emit("std::str::Utf8Error")>] type std_str_Utf8Error = class end
[<Fable.Core.Erase; Fable.Core.Emit("std::string::String")>] type std_string_String = class end
#endif // trace.types
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
and [<Struct>] US1 =
    | US1_0 of f0_0 : int64
    | US1_1
and [<Struct>] US2 =
    | US2_0 of f0_0 : int64
    | US2_1
let rec method0 (v0 : int64 option) : int64 option =
    v0
and method1 (v0 : int64 option) : int64 option =
    v0
and closure0 () () : struct (Mut0 * Mut1 * Mut1 * Mut2 * int64 option) =
    let v0 : Mut1 = {l0 = true} : Mut1
    let v1 : Mut0 = {l0 = 0L} : Mut0
    let v2 : US0 = US0_0
    let v3 : Mut2 = {l0 = v2} : Mut2
    let v4 : Mut1 = {l0 = false} : Mut1
    let v5 : int64 option option = None
    let mutable _v5 = v5
    #if INTERACTIVE || !FABLE_COMPILER
    let v6 : string option = None
    let mutable _v6 = v6
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v7 : string = null |> unbox<string>
    v7 
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v8 : string = null |> unbox<string>
    v8 
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v9 : string = null |> unbox<string>
    v9 
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v10 : string = System.Reflection.Assembly.GetEntryAssembly().GetName().Name
    v10 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v11 : string = null |> unbox<string>
    v11 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v12 : string = Unchecked.defaultof<string>
    v12 
    #endif
    |> fun x -> _v6 <- Some x
    let v13 : string = _v6.Value
    let v15 : bool = v13 = "Microsoft.DotNet.Interactive.App"
    let v16 : bool = v15 <> true
    let v22 : US1 =
        if v16 then
            let v17 : System.DateTime = System.DateTime.Now
            let v18 : (System.DateTime -> int64) = _.Ticks
            let v19 : int64 = v18 v17
            US1_0(v19)
        else
            US1_1
    let v27 : int64 option =
        match v22 with
        | US1_1 -> (* None *)
            let v25 : int64 option = None
            v25
        | US1_0(v23) -> (* Some *)
            let v24 : int64 option = Some v23 
            v24
    let v28 : int64 option = method0(v27)
    v28 
    #else
    let v29 : int64 option = None
    let v30 : int64 option = method1(v29)
    v30 
    #endif
    |> fun x -> _v5 <- Some x
    let v31 : int64 option = _v5.Value
    struct (v1, v4, v0, v3, v31)
and closure5 () (v0 : int64) : US2 =
    US2_0(v0)
and method3 () : (int64 -> US2) =
    closure5()
and method4 () : string =
    let v0 : string = ""
    v0
and closure4 (v0 : US0, v1 : (unit -> string), v2 : (unit -> string)) () : string =
    let v3 : (unit -> struct (Mut0 * Mut1 * Mut1 * Mut2 * int64 option)) = closure0()
    if State.trace_state = None then State.trace_state <- v3 () |> Some
    let struct (v4 : Mut0, v5 : Mut1, v6 : Mut1, v7 : Mut2, v8 : int64 option) = State.trace_state.Value
    let v9 : string option = None
    let mutable _v9 = v9
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v10 : (int64 -> US2) = method3()
    let v11 : US2 = US2_1
    let v12 : US2 = v8 |> Option.map v10 |> Option.defaultValue v11 
    let v30 : System.DateTime =
        match v12 with
        | US2_1 -> (* None *)
            let v28 : System.DateTime = System.DateTime.Now
            v28
        | US2_0(v13) -> (* Some *)
            let v14 : System.DateTime = System.DateTime.Now
            let v15 : (System.DateTime -> int64) = _.Ticks
            let v16 : int64 = v15 v14
            let v17 : int64 = v16 - v13
            let v18 : System.TimeSpan = System.TimeSpan v17 
            let v19 : (System.TimeSpan -> int32) = _.Hours
            let v20 : int32 = v19 v18
            let v21 : (System.TimeSpan -> int32) = _.Minutes
            let v22 : int32 = v21 v18
            let v23 : (System.TimeSpan -> int32) = _.Seconds
            let v24 : int32 = v23 v18
            let v25 : (System.TimeSpan -> int32) = _.Milliseconds
            let v26 : int32 = v25 v18
            let v27 : System.DateTime = System.DateTime (1, 1, 1, v20, v22, v24, v26)
            v27
    let v31 : string = "hh:mm:ss"
    let v32 : string = v30.ToString v31 
    v32 
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v33 : string = method4()
    v33 
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v34 : string = method4()
    v34 
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v35 : (int64 -> US2) = method3()
    let v36 : US2 = US2_1
    let v37 : US2 = v8 |> Option.map v35 |> Option.defaultValue v36 
    let v55 : System.DateTime =
        match v37 with
        | US2_1 -> (* None *)
            let v53 : System.DateTime = System.DateTime.Now
            v53
        | US2_0(v38) -> (* Some *)
            let v39 : System.DateTime = System.DateTime.Now
            let v40 : (System.DateTime -> int64) = _.Ticks
            let v41 : int64 = v40 v39
            let v42 : int64 = v41 - v38
            let v43 : System.TimeSpan = System.TimeSpan v42 
            let v44 : (System.TimeSpan -> int32) = _.Hours
            let v45 : int32 = v44 v43
            let v46 : (System.TimeSpan -> int32) = _.Minutes
            let v47 : int32 = v46 v43
            let v48 : (System.TimeSpan -> int32) = _.Seconds
            let v49 : int32 = v48 v43
            let v50 : (System.TimeSpan -> int32) = _.Milliseconds
            let v51 : int32 = v50 v43
            let v52 : System.DateTime = System.DateTime (1, 1, 1, v45, v47, v49, v51)
            v52
    let v56 : string = "HH:mm:ss"
    let v57 : string = v55.ToString v56 
    v57 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v58 : string = method4()
    v58 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v59 : string = Unchecked.defaultof<string>
    v59 
    #endif
    |> fun x -> _v9 <- Some x
    let v60 : string = _v9.Value
    let v61 : int64 = v4.l0
    let v71 : string =
        match v0 with
        | US0_4 -> (* Critical *)
            let v66 : string = "Critical"
            v66
        | US0_1 -> (* Debug *)
            let v63 : string = "Debug"
            v63
        | US0_2 -> (* Info *)
            let v64 : string = "Info"
            v64
        | US0_0 -> (* Verbose *)
            let v62 : string = "Verbose"
            v62
        | US0_3 -> (* Warning *)
            let v65 : string = "Warning"
            v65
    let v72 : string = v71.ToLower ()
    let v73 : string option = None
    let mutable _v73 = v73
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v88 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v82 : string = "inline_colorization::color_bright_red"
            let v83 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v82
            v83
        | US0_1 -> (* Debug *)
            let v76 : string = "inline_colorization::color_bright_blue"
            let v77 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v76
            v77
        | US0_2 -> (* Info *)
            let v78 : string = "inline_colorization::color_bright_green"
            let v79 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v78
            v79
        | US0_0 -> (* Verbose *)
            let v74 : string = "inline_colorization::color_bright_black"
            let v75 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v74
            v75
        | US0_3 -> (* Warning *)
            let v80 : string = "inline_colorization::color_bright_yellow"
            let v81 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v80
            v81
    let v89 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v90 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v72 v89
    let v91 : string = "inline_colorization::color_reset"
    let v92 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v91
    let v93 : string = "\"{v88}{v90}{v92}\""
    let v94 : string = @$"format!(" + v93 + ")"
    let v95 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v94
    let v96 : string = "fable_library_rust::String_::fromString($0)"
    let v97 : string = Fable.Core.RustInterop.emitRustExpr v95 v96
    v97 
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v112 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v106 : string = "inline_colorization::color_bright_red"
            let v107 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v106
            v107
        | US0_1 -> (* Debug *)
            let v100 : string = "inline_colorization::color_bright_blue"
            let v101 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v100
            v101
        | US0_2 -> (* Info *)
            let v102 : string = "inline_colorization::color_bright_green"
            let v103 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v102
            v103
        | US0_0 -> (* Verbose *)
            let v98 : string = "inline_colorization::color_bright_black"
            let v99 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v98
            v99
        | US0_3 -> (* Warning *)
            let v104 : string = "inline_colorization::color_bright_yellow"
            let v105 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v104
            v105
    let v113 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v114 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v72 v113
    let v115 : string = "inline_colorization::color_reset"
    let v116 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v115
    let v117 : string = "\"{v112}{v114}{v116}\""
    let v118 : string = @$"format!(" + v117 + ")"
    let v119 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v118
    let v120 : string = "fable_library_rust::String_::fromString($0)"
    let v121 : string = Fable.Core.RustInterop.emitRustExpr v119 v120
    v121 
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v136 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v130 : string = "inline_colorization::color_bright_red"
            let v131 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v130
            v131
        | US0_1 -> (* Debug *)
            let v124 : string = "inline_colorization::color_bright_blue"
            let v125 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v124
            v125
        | US0_2 -> (* Info *)
            let v126 : string = "inline_colorization::color_bright_green"
            let v127 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v126
            v127
        | US0_0 -> (* Verbose *)
            let v122 : string = "inline_colorization::color_bright_black"
            let v123 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v122
            v123
        | US0_3 -> (* Warning *)
            let v128 : string = "inline_colorization::color_bright_yellow"
            let v129 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v128
            v129
    let v137 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v138 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v72 v137
    let v139 : string = "inline_colorization::color_reset"
    let v140 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v139
    let v141 : string = "\"{v136}{v138}{v140}\""
    let v142 : string = @$"format!(" + v141 + ")"
    let v143 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v142
    let v144 : string = "fable_library_rust::String_::fromString($0)"
    let v145 : string = Fable.Core.RustInterop.emitRustExpr v143 v144
    v145 
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    v72 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    v72 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v146 : string = Unchecked.defaultof<string>
    v146 
    #endif
    |> fun x -> _v73 <- Some x
    let v147 : string = _v73.Value
    let v148 : string = $"{v60} {v147} #{v61} %s{v1 ()} / %s{v2 ()}"
    let v149 : (char []) = [||]
    let v150 : string = v148.TrimStart v149
    let v151 : (char []) = [|' '; '/'|]
    let v152 : string = v150.TrimEnd v151
    v152
and method2 (v0 : US0, v1 : (unit -> string), v2 : (unit -> string)) : unit =
    let v3 : (unit -> struct (Mut0 * Mut1 * Mut1 * Mut2 * int64 option)) = closure0()
    if State.trace_state = None then State.trace_state <- v3 () |> Some
    let struct (v4 : Mut0, v5 : Mut1, v6 : Mut1, v7 : Mut2, v8 : int64 option) = State.trace_state.Value
    if State.trace_state = None then State.trace_state <- v3 () |> Some
    let struct (v9 : Mut0, v10 : Mut1, v11 : Mut1, v12 : Mut2, v13 : int64 option) = State.trace_state.Value
    let v14 : US0 = v12.l0
    let v15 : bool = v11.l0
    let v17 : bool =
        if v15 then
            let v16 : bool = v0 >= v14 
            v16
        else
            false
    if v17 then
        let v18 : int64 = v4.l0
        let v19 : int64 = v18 + 1L
        v4.l0 <- v19
        let v20 : (unit -> string) = closure4(v0, v1, v2)
        let v21 : string = $"%s{v20 ()}"
        let v22 : unit option = None
        let mutable _v22 = v22
        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v23 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v21 v23
        () 
        #endif
        #if FABLE_COMPILER_RUST && WASM
        let v24 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v21 v24
        () 
        #endif
        #if FABLE_COMPILER_RUST && CONTRACT
        let v25 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v21 v25
        () 
        #endif
        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
        System.Console.WriteLine v21 
        () 
        #endif
        #if FABLE_COMPILER_TYPESCRIPT
        System.Console.WriteLine v21 
        () 
        #endif
        #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
        Unchecked.defaultof<unit>
        () 
        #endif
        |> fun x -> _v22 <- Some x
        _v22.Value
        ()
and closure3 (v0 : US0, v1 : (unit -> string)) (v2 : (unit -> string)) : unit =
    method2(v0, v1, v2)
and closure2 (v0 : US0) (v1 : (unit -> string)) : ((unit -> string) -> unit) =
    closure3(v0, v1)
and closure1 () (v0 : US0) : ((unit -> string) -> ((unit -> string) -> unit)) =
    closure2(v0)
let v0 : (unit -> struct (Mut0 * Mut1 * Mut1 * Mut2 * int64 option)) = closure0()
if State.trace_state = None then State.trace_state <- v0 () |> Some
let v1 : (US0 -> ((unit -> string) -> ((unit -> string) -> unit))) = closure1()
let trace x = v1 x
()
