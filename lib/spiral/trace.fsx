#if FABLE_COMPILER // trace.types
[<Fable.Core.Erase; Fable.Core.Emit("Func0<$0>")>] type Func0<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("Func1<$0, $1>")>] type Func0<'T, 'U> = class end
[<Fable.Core.Erase; Fable.Core.Emit("Box<$0>")>] type Box<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("dyn $0")>] type Dyn<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("$0 + Send")>] type Send<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("Fn() -> $0")>] type Fn<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("Fn()")>] type FnUnit = class end
[<Fable.Core.Erase; Fable.Core.Emit("FnOnce() -> $0")>] type FnOnce<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("Fn($0)")>] type ActionFn<'T> = class end
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
and Mut3 = {mutable l0 : (string -> unit)}
and [<Struct>] US1 =
    | US1_0 of f0_0 : int64
    | US1_1
and [<Struct>] US2 =
    | US2_0 of f0_0 : int64
    | US2_1
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
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v9 : string = null |> unbox<string>
    v9
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v10 : string = null |> unbox<string>
    v10
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v11 : string = null |> unbox<string>
    v11
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v12 : string = System.Reflection.Assembly.GetEntryAssembly().GetName().Name
    v12
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v13 : string = null |> unbox<string>
    v13
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v14 : string = Unchecked.defaultof<string>
    v14
#endif
    |> fun x -> _v7 <- Some x
    let v15 : string = _v7.Value
    let v17 : bool = v15 = "Microsoft.DotNet.Interactive.App"
    let v18 : bool = v17 <> true
    let v24 : US1 =
        if v18 then
            let v19 : System.DateTime = System.DateTime.Now
            let v20 : (System.DateTime -> int64) = _.Ticks
            let v21 : int64 = v20 v19
            US1_0(v21)
        else
            US1_1
    let v29 : int64 option =
        match v24 with
        | US1_1 -> (* None *)
            let v27 : int64 option = None
            v27
        | US1_0(v25) -> (* Some *)
            let v26 : int64 option = Some v25 
            v26
    let v30 : int64 option = method0(v29)
    v30 
    #else
    let v31 : int64 option = None
    let v32 : int64 option = method1(v31)
    v32 
    #endif
    |> fun x -> _v6 <- Some x
    let v33 : int64 option = _v6.Value
    struct (v1, v0, v3, v33, v5)
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
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v36 : (int64 -> US2) = method3()
    let v37 : US2 = US2_1
    let v38 : US2 = v7 |> Option.map v36 |> Option.defaultValue v37 
    let v56 : System.DateTime =
        match v38 with
        | US2_1 -> (* None *)
            let v54 : System.DateTime = System.DateTime.Now
            v54
        | US2_0(v39) -> (* Some *)
            let v40 : System.DateTime = System.DateTime.Now
            let v41 : (System.DateTime -> int64) = _.Ticks
            let v42 : int64 = v41 v40
            let v43 : int64 = v42 - v39
            let v44 : System.TimeSpan = System.TimeSpan v43 
            let v45 : (System.TimeSpan -> int32) = _.Hours
            let v46 : int32 = v45 v44
            let v47 : (System.TimeSpan -> int32) = _.Minutes
            let v48 : int32 = v47 v44
            let v49 : (System.TimeSpan -> int32) = _.Seconds
            let v50 : int32 = v49 v44
            let v51 : (System.TimeSpan -> int32) = _.Milliseconds
            let v52 : int32 = v51 v44
            let v53 : System.DateTime = System.DateTime (1, 1, 1, v46, v48, v50, v52)
            v53
    let v57 : string = "HH:mm:ss"
    let v58 : string = v56.ToString v57 
    v58
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v59 : string = method4()
    v59
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v60 : string = Unchecked.defaultof<string>
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
    let v74 : string option = None
    let v75 : bool = true in let mutable _v74 = v74
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v90 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v84 : string = "inline_colorization::color_bright_red"
            let v85 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v84
            v85
        | US0_1 -> (* Debug *)
            let v78 : string = "inline_colorization::color_bright_blue"
            let v79 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v78
            v79
        | US0_2 -> (* Info *)
            let v80 : string = "inline_colorization::color_bright_green"
            let v81 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v80
            v81
        | US0_0 -> (* Verbose *)
            let v76 : string = "inline_colorization::color_bright_black"
            let v77 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v76
            v77
        | US0_3 -> (* Warning *)
            let v82 : string = "inline_colorization::color_bright_yellow"
            let v83 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v82
            v83
    let v91 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v92 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v73 v91
    let v93 : string = "inline_colorization::color_reset"
    let v94 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v93
    let v95 : string = "\"{v90}{v92}{v94}\""
    let v96 : string = @$"format!(" + v95 + ")"
    let v97 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v96
    let v98 : string = "fable_library_rust::String_::fromString($0)"
    let v99 : string = Fable.Core.RustInterop.emitRustExpr v97 v98
    v99
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v114 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v108 : string = "inline_colorization::color_bright_red"
            let v109 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v108
            v109
        | US0_1 -> (* Debug *)
            let v102 : string = "inline_colorization::color_bright_blue"
            let v103 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v102
            v103
        | US0_2 -> (* Info *)
            let v104 : string = "inline_colorization::color_bright_green"
            let v105 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v104
            v105
        | US0_0 -> (* Verbose *)
            let v100 : string = "inline_colorization::color_bright_black"
            let v101 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v100
            v101
        | US0_3 -> (* Warning *)
            let v106 : string = "inline_colorization::color_bright_yellow"
            let v107 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v106
            v107
    let v115 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v116 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v73 v115
    let v117 : string = "inline_colorization::color_reset"
    let v118 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v117
    let v119 : string = "\"{v114}{v116}{v118}\""
    let v120 : string = @$"format!(" + v119 + ")"
    let v121 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v120
    let v122 : string = "fable_library_rust::String_::fromString($0)"
    let v123 : string = Fable.Core.RustInterop.emitRustExpr v121 v122
    v123
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v138 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v132 : string = "inline_colorization::color_bright_red"
            let v133 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v132
            v133
        | US0_1 -> (* Debug *)
            let v126 : string = "inline_colorization::color_bright_blue"
            let v127 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v126
            v127
        | US0_2 -> (* Info *)
            let v128 : string = "inline_colorization::color_bright_green"
            let v129 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v128
            v129
        | US0_0 -> (* Verbose *)
            let v124 : string = "inline_colorization::color_bright_black"
            let v125 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v124
            v125
        | US0_3 -> (* Warning *)
            let v130 : string = "inline_colorization::color_bright_yellow"
            let v131 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v130
            v131
    let v139 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v140 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v73 v139
    let v141 : string = "inline_colorization::color_reset"
    let v142 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v141
    let v143 : string = "\"{v138}{v140}{v142}\""
    let v144 : string = @$"format!(" + v143 + ")"
    let v145 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v144
    let v146 : string = "fable_library_rust::String_::fromString($0)"
    let v147 : string = Fable.Core.RustInterop.emitRustExpr v145 v146
    v147
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    v73
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    v73
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v148 : string = Unchecked.defaultof<string>
    v148
#endif
    |> fun x -> _v74 <- Some x
    let v149 : string = _v74.Value
    let v150 : string = $"{v61} {v149} #{v62} %s{v1 ()} / %s{v2 ()}"
    let v151 : (char []) = [||]
    let v152 : string = v150.TrimStart v151
    let v153 : (char []) = [|' '; '/'|]
    let v154 : string = v152.TrimEnd v153
    v154
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
        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
        System.Console.WriteLine v22 
        ()
#endif
        #if FABLE_COMPILER_TYPESCRIPT
        System.Console.WriteLine v22 
        ()
#endif
        #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
        Unchecked.defaultof<unit>
        ()
#endif
        |> fun x -> _v23 <- Some x
        _v23.Value
        let v28 : (string -> unit) = v7.l0
        v28 v22
and method2 (v0 : US0, v1 : (unit -> string), v2 : (unit -> string)) : unit =
    let v3 : (unit -> string) = closure5(v0, v1, v2)
    method5(v0, v3)
and closure4 (v0 : US0, v1 : (unit -> string)) (v2 : (unit -> string)) : unit =
    method2(v0, v1, v2)
and closure3 (v0 : US0) (v1 : (unit -> string)) : ((unit -> string) -> unit) =
    closure4(v0, v1)
and closure2 () (v0 : US0) : ((unit -> string) -> ((unit -> string) -> unit)) =
    closure3(v0)
let v0 : (unit -> struct (Mut0 * Mut1 * Mut2 * int64 option * Mut3)) = closure0()
if State.trace_state.IsNone then State.trace_state <- v0 () |> Some
let v1 : (US0 -> ((unit -> string) -> ((unit -> string) -> unit))) = closure2()
let trace x = v1 x
()
