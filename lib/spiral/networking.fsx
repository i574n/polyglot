#if FABLE_COMPILER // networking.types
[<Fable.Core.Erase; Fable.Core.Emit("Func0<$0>")>] type Func0<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("Func1<$0, $1>")>] type Func0<'T, 'U> = class end
[<Fable.Core.Erase; Fable.Core.Emit("Box<$0>")>] type Box<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("dyn $0")>] type Dyn<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("$0 + Send")>] type Send<'T> = class end
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
[<Fable.Core.Erase; Fable.Core.Emit("reqwest_wasm::Error")>] type reqwest_Error = class end
[<Fable.Core.Erase; Fable.Core.Emit("reqwest_wasm::RequestBuilder")>] type reqwest_RequestBuilder = class end
[<Fable.Core.Erase; Fable.Core.Emit("reqwest_wasm::Response")>] type reqwest_Response = class end
#endif // networking.types
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
    let v7 : bool = true in let mutable _v6 = v6
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v8 : string = null |> unbox<string>
    v8
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v9 : string = null |> unbox<string>
    v9
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v10 : string = null |> unbox<string>
    v10
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v11 : string = System.Reflection.Assembly.GetEntryAssembly().GetName().Name
    v11
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v12 : string = null |> unbox<string>
    v12
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v13 : string = Unchecked.defaultof<string>
    v13
#endif
    |> fun x -> _v6 <- Some x
    let v14 : string = _v6.Value
    let v16 : bool = v14 = "Microsoft.DotNet.Interactive.App"
    let v17 : bool = v16 <> true
    let v23 : US1 =
        if v17 then
            let v18 : System.DateTime = System.DateTime.Now
            let v19 : (System.DateTime -> int64) = _.Ticks
            let v20 : int64 = v19 v18
            US1_0(v20)
        else
            US1_1
    let v28 : int64 option =
        match v23 with
        | US1_1 -> (* None *)
            let v26 : int64 option = None
            v26
        | US1_0(v24) -> (* Some *)
            let v25 : int64 option = Some v24 
            v25
    let v29 : int64 option = method0(v28)
    v29 
    #else
    let v30 : int64 option = None
    let v31 : int64 option = method1(v30)
    v31 
    #endif
    |> fun x -> _v5 <- Some x
    let v32 : int64 option = _v5.Value
    struct (v1, v4, v0, v3, v32)
and closure2 (v0 : string) () : string =
    let v1 : string = $"test_port_open / ex: {v0}"
    v1
and closure3 () () : string =
    let v0 : string = ""
    v0
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
    let v10 : bool = true in let mutable _v9 = v9
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v11 : (int64 -> US2) = method3()
    let v12 : US2 = US2_1
    let v13 : US2 = v8 |> Option.map v11 |> Option.defaultValue v12 
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
    let v38 : US2 = v8 |> Option.map v36 |> Option.defaultValue v37 
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
        let v23 : bool = true in let mutable _v22 = v22
        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v24 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v21 v24
        ()
#endif
        #if FABLE_COMPILER_RUST && WASM
        let v25 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v21 v25
        ()
#endif
        #if FABLE_COMPILER_RUST && CONTRACT
        let v26 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v21 v26
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
and closure1 () (v0 : int32) : Async<bool> =
    let v1 : Async<bool> option = None
    let v2 : bool = true in let mutable _v1 = v1
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
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v6 : Async<bool> option = None
    let mutable _v6 = v6
    async {
    let v7 : Async<System.Threading.CancellationToken> = Async.CancellationToken
    let! v7 = v7 
    let v8 : System.Threading.CancellationToken = v7 
    let v9 : System.Net.Sockets.TcpClient = new System.Net.Sockets.TcpClient ()
    use v9 = v9 
    let v10 : System.Net.Sockets.TcpClient = v9 
    try
    let v11 : string = "127.0.0.1"
    let v12 : System.Threading.Tasks.ValueTask = v10.ConnectAsync (v11, v0, v8)
    let v13 : (unit -> System.Threading.Tasks.Task) = v12.AsTask
    let v14 : System.Threading.Tasks.Task = v13 ()
    let v15 : Async<unit> option = None
    let v16 : bool = true in let mutable _v15 = v15
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
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v20 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
    let v21 : Async<unit> = v20 v14
    v21
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v22 : Async<unit> = null |> unbox<Async<unit>>
    v22
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v23 : Async<unit> = Unchecked.defaultof<Async<unit>>
    v23
#endif
    |> fun x -> _v15 <- Some x
    let v24 : Async<unit> = _v15.Value
    do! v24 
    return true 
    with ex ->
    let v25 : exn = ex
    let v26 : string option = None
    let v27 : bool = true in let mutable _v26 = v26
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v28 : string = $"%A{v25}"
    v28
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v29 : string = $"%A{v25}"
    v29
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v30 : string = $"%A{v25}"
    v30
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v31 : string = $"{v25.GetType ()}: {v25.Message}"
    v31
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v32 : string = $"%A{v25}"
    v32
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v33 : string = Unchecked.defaultof<string>
    v33
#endif
    |> fun x -> _v26 <- Some x
    let v34 : string = _v26.Value
    let v35 : US0 = US0_0
    let v36 : (unit -> string) = closure2(v34)
    let v37 : (unit -> string) = closure3()
    method2(v35, v36, v37)
    return false 
    (*
    let v38 : bool = *)
    }
    |> fun x -> _v6 <- Some x
    let v39 : Async<bool> = _v6 |> Option.get
    v39
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v40 : Async<bool> = null |> unbox<Async<bool>>
    v40
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v41 : Async<bool> = Unchecked.defaultof<Async<bool>>
    v41
#endif
    |> fun x -> _v1 <- Some x
    let v42 : Async<bool> = _v1.Value
    v42
and closure8 () (v0 : bool) : US4 =
    US4_0(v0)
and closure9 () (v0 : exn) : US4 =
    US4_1(v0)
and closure10 () () : string =
    let v0 : string = "run_with_timeout_async"
    v0
and closure11 (v0 : int32) () : string =
    let v1 : (unit -> string) = closure3()
    let v2 : string = $"timeout: {v0} / {v1 ()}"
    v2
and closure12 (v0 : string) () : string =
    let v1 : string = $"run_with_timeout_async** / ex: {v0}"
    v1
and closure7 (v0 : int32) (v1 : int32) : Async<bool> =
    let v2 : Async<bool> option = None
    let v3 : bool = true in let mutable _v2 = v2
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
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v7 : Async<bool> option = None
    let mutable _v7 = v7
    async {
    let v8 : Async<bool> option = None
    let v9 : bool = true in let mutable _v8 = v8
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v10 : Async<bool> = null |> unbox<Async<bool>>
    v10
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v11 : Async<bool> = null |> unbox<Async<bool>>
    v11
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v12 : Async<bool> = null |> unbox<Async<bool>>
    v12
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v13 : Async<bool> option = None
    let mutable _v13 = v13
    async {
    let v14 : Async<System.Threading.CancellationToken> = Async.CancellationToken
    let! v14 = v14 
    let v15 : System.Threading.CancellationToken = v14 
    let v16 : System.Net.Sockets.TcpClient = new System.Net.Sockets.TcpClient ()
    use v16 = v16 
    let v17 : System.Net.Sockets.TcpClient = v16 
    try
    let v18 : string = "127.0.0.1"
    let v19 : System.Threading.Tasks.ValueTask = v17.ConnectAsync (v18, v1, v15)
    let v20 : (unit -> System.Threading.Tasks.Task) = v19.AsTask
    let v21 : System.Threading.Tasks.Task = v20 ()
    let v22 : Async<unit> option = None
    let v23 : bool = true in let mutable _v22 = v22
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v24 : Async<unit> = null |> unbox<Async<unit>>
    v24
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v25 : Async<unit> = null |> unbox<Async<unit>>
    v25
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v26 : Async<unit> = null |> unbox<Async<unit>>
    v26
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v27 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
    let v28 : Async<unit> = v27 v21
    v28
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v29 : Async<unit> = null |> unbox<Async<unit>>
    v29
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v30 : Async<unit> = Unchecked.defaultof<Async<unit>>
    v30
#endif
    |> fun x -> _v22 <- Some x
    let v31 : Async<unit> = _v22.Value
    do! v31 
    return true 
    with ex ->
    let v32 : exn = ex
    let v33 : string option = None
    let v34 : bool = true in let mutable _v33 = v33
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v35 : string = $"%A{v32}"
    v35
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v36 : string = $"%A{v32}"
    v36
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v37 : string = $"%A{v32}"
    v37
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v38 : string = $"{v32.GetType ()}: {v32.Message}"
    v38
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v39 : string = $"%A{v32}"
    v39
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v40 : string = Unchecked.defaultof<string>
    v40
#endif
    |> fun x -> _v33 <- Some x
    let v41 : string = _v33.Value
    let v42 : US0 = US0_0
    let v43 : (unit -> string) = closure2(v41)
    let v44 : (unit -> string) = closure3()
    method2(v42, v43, v44)
    return false 
    (*
    let v45 : bool = *)
    }
    |> fun x -> _v13 <- Some x
    let v46 : Async<bool> = _v13 |> Option.get
    v46
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v47 : Async<bool> = null |> unbox<Async<bool>>
    v47
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v48 : Async<bool> = Unchecked.defaultof<Async<bool>>
    v48
#endif
    |> fun x -> _v8 <- Some x
    let v49 : Async<bool> = _v8.Value
    let v50 : Async<US3> option = None
    let v51 : bool = true in let mutable _v50 = v50
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v52 : Async<US3> = null |> unbox<Async<US3>>
    v52
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v53 : Async<US3> = null |> unbox<Async<US3>>
    v53
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v54 : Async<US3> = null |> unbox<Async<US3>>
    v54
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v55 : Async<US3> option = None
    let v56 : bool = true in let mutable _v55 = v55
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v57 : Async<US3> = null |> unbox<Async<US3>>
    v57
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v58 : Async<US3> = null |> unbox<Async<US3>>
    v58
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v59 : Async<US3> = null |> unbox<Async<US3>>
    v59
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v60 : Async<US3> option = None
    let mutable _v60 = v60
    async {
    let v61 : Async<Async<bool>> option = None
    let v62 : bool = true in let mutable _v61 = v61
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v63 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
    v63
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v64 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
    v64
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v65 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
    v65
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v66 : Async<Async<bool>> = Async.StartChild (v49, v0)
    v66
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v67 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
    v67
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v68 : Async<Async<bool>> = Unchecked.defaultof<Async<Async<bool>>>
    v68
#endif
    |> fun x -> _v61 <- Some x
    let v69 : Async<Async<bool>> = _v61.Value
    let! v69 = v69 
    let v70 : Async<bool> = v69 
    let v71 : Async<Choice<bool, exn>> option = None
    let v72 : bool = true in let mutable _v71 = v71
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v73 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
    v73
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v74 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
    v74
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v75 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
    v75
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v76 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
    let v77 : Async<Choice<bool, exn>> = v76 v70
    v77
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v78 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
    v78
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v79 : Async<Choice<bool, exn>> = Unchecked.defaultof<Async<Choice<bool, exn>>>
    v79
#endif
    |> fun x -> _v71 <- Some x
    let v80 : Async<Choice<bool, exn>> = _v71.Value
    let v81 : Async<US4> option = None
    let v82 : bool = true in let mutable _v81 = v81
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v83 : Async<US4> = null |> unbox<Async<US4>>
    v83
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v84 : Async<US4> = null |> unbox<Async<US4>>
    v84
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v85 : Async<US4> = null |> unbox<Async<US4>>
    v85
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v86 : Async<US4> option = None
    let mutable _v86 = v86
    async {
    let! v80 = v80 
    let v87 : Choice<bool, exn> = v80 
    let v88 : US4 option = None
    let v89 : bool = true in let mutable _v88 = v88
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v90 : US4 = null |> unbox<US4>
    v90
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v91 : US4 = null |> unbox<US4>
    v91
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v92 : US4 = null |> unbox<US4>
    v92
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v93 : (bool -> US4) = closure8()
    let v94 : (exn -> US4) = closure9()
    let v95 : US4 = match v87 with Choice1Of2 x -> v93 x | Choice2Of2 x -> v94 x
    v95
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v96 : US4 = null |> unbox<US4>
    v96
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v97 : US4 = Unchecked.defaultof<US4>
    v97
#endif
    |> fun x -> _v88 <- Some x
    let v98 : US4 = _v88.Value
    return v98 
    }
    |> fun x -> _v86 <- Some x
    let v99 : Async<US4> = _v86 |> Option.get
    v99
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v100 : Async<US4> = null |> unbox<Async<US4>>
    v100
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v101 : Async<US4> = Unchecked.defaultof<Async<US4>>
    v101
#endif
    |> fun x -> _v81 <- Some x
    let v102 : Async<US4> = _v81.Value
    let v103 : Async<US5> option = None
    let v104 : bool = true in let mutable _v103 = v103
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v105 : Async<US5> = null |> unbox<Async<US5>>
    v105
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v106 : Async<US5> = null |> unbox<Async<US5>>
    v106
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v107 : Async<US5> = null |> unbox<Async<US5>>
    v107
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v108 : Async<US5> option = None
    let mutable _v108 = v108
    async {
    let! v102 = v102 
    let v109 : US4 = v102 
    let v115 : US5 =
        match v109 with
        | US4_0(v110) -> (* Choice1Of2 *)
            US5_0(v110)
        | US4_1(v112) -> (* Choice2Of2 *)
            US5_1(v112)
    return v115 
    }
    |> fun x -> _v108 <- Some x
    let v116 : Async<US5> = _v108 |> Option.get
    v116
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v117 : Async<US5> = null |> unbox<Async<US5>>
    v117
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v118 : Async<US5> = Unchecked.defaultof<Async<US5>>
    v118
#endif
    |> fun x -> _v103 <- Some x
    let v119 : Async<US5> = _v103.Value
    let v120 : Async<US3> option = None
    let v121 : bool = true in let mutable _v120 = v120
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v122 : Async<US3> = null |> unbox<Async<US3>>
    v122
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v123 : Async<US3> = null |> unbox<Async<US3>>
    v123
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v124 : Async<US3> = null |> unbox<Async<US3>>
    v124
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v125 : Async<US3> option = None
    let mutable _v125 = v125
    async {
    let! v119 = v119 
    let v126 : US5 = v119 
    let v152 : US3 =
        match v126 with
        | US5_1(v129) -> (* Error *)
            let v130 : string = $"%A{v129}"
            let v131 : string = "System.TimeoutException"
            let v132 : bool = v130.Contains v131
            if v132 then
                let v133 : US0 = US0_1
                let v134 : (unit -> string) = closure10()
                let v135 : (unit -> string) = closure11(v0)
                method2(v133, v134, v135)
                US3_1
            else
                let v137 : string option = None
                let v138 : bool = true in let mutable _v137 = v137
                #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v139 : string = $"%A{v129}"
                v139
#endif
                #if FABLE_COMPILER_RUST && WASM
                let v140 : string = $"%A{v129}"
                v140
#endif
                #if FABLE_COMPILER_RUST && CONTRACT
                let v141 : string = $"%A{v129}"
                v141
#endif
                #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                let v142 : string = $"{v129.GetType ()}: {v129.Message}"
                v142
#endif
                #if FABLE_COMPILER_TYPESCRIPT
                let v143 : string = $"%A{v129}"
                v143
#endif
                #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
                let v144 : string = Unchecked.defaultof<string>
                v144
#endif
                |> fun x -> _v137 <- Some x
                let v145 : string = _v137.Value
                let v146 : US0 = US0_4
                let v147 : (unit -> string) = closure12(v145)
                let v148 : (unit -> string) = closure11(v0)
                method2(v146, v147, v148)
                US3_1
        | US5_0(v127) -> (* Ok *)
            US3_0(v127)
    return v152 
    }
    |> fun x -> _v125 <- Some x
    let v153 : Async<US3> = _v125 |> Option.get
    v153
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v154 : Async<US3> = null |> unbox<Async<US3>>
    v154
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v155 : Async<US3> = Unchecked.defaultof<Async<US3>>
    v155
#endif
    |> fun x -> _v120 <- Some x
    let v156 : Async<US3> = _v120.Value
    return! v156 
    }
    |> fun x -> _v60 <- Some x
    let v157 : Async<US3> = _v60 |> Option.get
    v157
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v158 : Async<US3> = null |> unbox<Async<US3>>
    v158
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v159 : Async<US3> = Unchecked.defaultof<Async<US3>>
    v159
#endif
    |> fun x -> _v55 <- Some x
    let v160 : Async<US3> = _v55.Value
    v160
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v161 : Async<US3> = null |> unbox<Async<US3>>
    v161
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v162 : Async<US3> = Unchecked.defaultof<Async<US3>>
    v162
#endif
    |> fun x -> _v50 <- Some x
    let v163 : Async<US3> = _v50.Value
    let! v163 = v163 
    let v164 : US3 = v163 
    let v167 : bool =
        match v164 with
        | US3_1 -> (* None *)
            false
        | US3_0(v165) -> (* Some *)
            v165
    return v167 
    }
    |> fun x -> _v7 <- Some x
    let v168 : Async<bool> = _v7 |> Option.get
    v168
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v169 : Async<bool> = null |> unbox<Async<bool>>
    v169
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v170 : Async<bool> = Unchecked.defaultof<Async<bool>>
    v170
#endif
    |> fun x -> _v2 <- Some x
    let v171 : Async<bool> = _v2.Value
    v171
and closure6 () (v0 : int32) : (int32 -> Async<bool>) =
    closure7(v0)
and closure16 () (v0 : int32) : US6 =
    US6_0(v0)
and method6 () : (int32 -> US6) =
    closure16()
and closure17 () () : string =
    let v0 : string = "wait_for_port_access"
    v0
and closure18 (v0 : int32, v1 : int64) () : string =
    let v2 : (unit -> string) = closure3()
    let v3 : string = $"port: {v0} / retry: {v1} / {v2 ()}"
    v3
and method5 (v0 : int32 option, v1 : bool, v2 : int32, v3 : int64) : Async<int64> =
    let v4 : Async<int64> option = None
    let v5 : bool = true in let mutable _v4 = v4
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
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v9 : Async<int64> option = None
    let mutable _v9 = v9
    async {
    let v10 : (int32 -> US6) = method6()
    let v11 : US6 = US6_1
    let v12 : US6 = v0 |> Option.map v10 |> Option.defaultValue v11 
    let v227 : Async<bool> =
        match v12 with
        | US6_1 -> (* None *)
            let v13 : Async<bool> option = None
            let v14 : bool = true in let mutable _v13 = v13
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
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v18 : Async<bool> option = None
            let mutable _v18 = v18
            async {
            let v19 : Async<System.Threading.CancellationToken> = Async.CancellationToken
            let! v19 = v19 
            let v20 : System.Threading.CancellationToken = v19 
            let v21 : System.Net.Sockets.TcpClient = new System.Net.Sockets.TcpClient ()
            use v21 = v21 
            let v22 : System.Net.Sockets.TcpClient = v21 
            try
            let v23 : string = "127.0.0.1"
            let v24 : System.Threading.Tasks.ValueTask = v22.ConnectAsync (v23, v2, v20)
            let v25 : (unit -> System.Threading.Tasks.Task) = v24.AsTask
            let v26 : System.Threading.Tasks.Task = v25 ()
            let v27 : Async<unit> option = None
            let v28 : bool = true in let mutable _v27 = v27
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v29 : Async<unit> = null |> unbox<Async<unit>>
            v29
#endif
            #if FABLE_COMPILER_RUST && WASM
            let v30 : Async<unit> = null |> unbox<Async<unit>>
            v30
#endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let v31 : Async<unit> = null |> unbox<Async<unit>>
            v31
#endif
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v32 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
            let v33 : Async<unit> = v32 v26
            v33
#endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v34 : Async<unit> = null |> unbox<Async<unit>>
            v34
#endif
            #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
            let v35 : Async<unit> = Unchecked.defaultof<Async<unit>>
            v35
#endif
            |> fun x -> _v27 <- Some x
            let v36 : Async<unit> = _v27.Value
            do! v36 
            return true 
            with ex ->
            let v37 : exn = ex
            let v38 : string option = None
            let v39 : bool = true in let mutable _v38 = v38
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v40 : string = $"%A{v37}"
            v40
#endif
            #if FABLE_COMPILER_RUST && WASM
            let v41 : string = $"%A{v37}"
            v41
#endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let v42 : string = $"%A{v37}"
            v42
#endif
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v43 : string = $"{v37.GetType ()}: {v37.Message}"
            v43
#endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v44 : string = $"%A{v37}"
            v44
#endif
            #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
            let v45 : string = Unchecked.defaultof<string>
            v45
#endif
            |> fun x -> _v38 <- Some x
            let v46 : string = _v38.Value
            let v47 : US0 = US0_0
            let v48 : (unit -> string) = closure2(v46)
            let v49 : (unit -> string) = closure3()
            method2(v47, v48, v49)
            return false 
            (*
            let v50 : bool = *)
            }
            |> fun x -> _v18 <- Some x
            let v51 : Async<bool> = _v18 |> Option.get
            v51
#endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v52 : Async<bool> = null |> unbox<Async<bool>>
            v52
#endif
            #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
            let v53 : Async<bool> = Unchecked.defaultof<Async<bool>>
            v53
#endif
            |> fun x -> _v13 <- Some x
            let v54 : Async<bool> = _v13.Value
            v54
        | US6_0(v55) -> (* Some *)
            let v56 : Async<bool> option = None
            let v57 : bool = true in let mutable _v56 = v56
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
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v61 : Async<bool> option = None
            let mutable _v61 = v61
            async {
            let v62 : Async<bool> option = None
            let v63 : bool = true in let mutable _v62 = v62
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v64 : Async<bool> = null |> unbox<Async<bool>>
            v64
#endif
            #if FABLE_COMPILER_RUST && WASM
            let v65 : Async<bool> = null |> unbox<Async<bool>>
            v65
#endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let v66 : Async<bool> = null |> unbox<Async<bool>>
            v66
#endif
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v67 : Async<bool> option = None
            let mutable _v67 = v67
            async {
            let v68 : Async<System.Threading.CancellationToken> = Async.CancellationToken
            let! v68 = v68 
            let v69 : System.Threading.CancellationToken = v68 
            let v70 : System.Net.Sockets.TcpClient = new System.Net.Sockets.TcpClient ()
            use v70 = v70 
            let v71 : System.Net.Sockets.TcpClient = v70 
            try
            let v72 : string = "127.0.0.1"
            let v73 : System.Threading.Tasks.ValueTask = v71.ConnectAsync (v72, v2, v69)
            let v74 : (unit -> System.Threading.Tasks.Task) = v73.AsTask
            let v75 : System.Threading.Tasks.Task = v74 ()
            let v76 : Async<unit> option = None
            let v77 : bool = true in let mutable _v76 = v76
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v78 : Async<unit> = null |> unbox<Async<unit>>
            v78
#endif
            #if FABLE_COMPILER_RUST && WASM
            let v79 : Async<unit> = null |> unbox<Async<unit>>
            v79
#endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let v80 : Async<unit> = null |> unbox<Async<unit>>
            v80
#endif
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v81 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
            let v82 : Async<unit> = v81 v75
            v82
#endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v83 : Async<unit> = null |> unbox<Async<unit>>
            v83
#endif
            #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
            let v84 : Async<unit> = Unchecked.defaultof<Async<unit>>
            v84
#endif
            |> fun x -> _v76 <- Some x
            let v85 : Async<unit> = _v76.Value
            do! v85 
            return true 
            with ex ->
            let v86 : exn = ex
            let v87 : string option = None
            let v88 : bool = true in let mutable _v87 = v87
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v89 : string = $"%A{v86}"
            v89
#endif
            #if FABLE_COMPILER_RUST && WASM
            let v90 : string = $"%A{v86}"
            v90
#endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let v91 : string = $"%A{v86}"
            v91
#endif
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v92 : string = $"{v86.GetType ()}: {v86.Message}"
            v92
#endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v93 : string = $"%A{v86}"
            v93
#endif
            #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
            let v94 : string = Unchecked.defaultof<string>
            v94
#endif
            |> fun x -> _v87 <- Some x
            let v95 : string = _v87.Value
            let v96 : US0 = US0_0
            let v97 : (unit -> string) = closure2(v95)
            let v98 : (unit -> string) = closure3()
            method2(v96, v97, v98)
            return false 
            (*
            let v99 : bool = *)
            }
            |> fun x -> _v67 <- Some x
            let v100 : Async<bool> = _v67 |> Option.get
            v100
#endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v101 : Async<bool> = null |> unbox<Async<bool>>
            v101
#endif
            #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
            let v102 : Async<bool> = Unchecked.defaultof<Async<bool>>
            v102
#endif
            |> fun x -> _v62 <- Some x
            let v103 : Async<bool> = _v62.Value
            let v104 : Async<US3> option = None
            let v105 : bool = true in let mutable _v104 = v104
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v106 : Async<US3> = null |> unbox<Async<US3>>
            v106
#endif
            #if FABLE_COMPILER_RUST && WASM
            let v107 : Async<US3> = null |> unbox<Async<US3>>
            v107
#endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let v108 : Async<US3> = null |> unbox<Async<US3>>
            v108
#endif
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v109 : Async<US3> option = None
            let v110 : bool = true in let mutable _v109 = v109
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v111 : Async<US3> = null |> unbox<Async<US3>>
            v111
#endif
            #if FABLE_COMPILER_RUST && WASM
            let v112 : Async<US3> = null |> unbox<Async<US3>>
            v112
#endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let v113 : Async<US3> = null |> unbox<Async<US3>>
            v113
#endif
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v114 : Async<US3> option = None
            let mutable _v114 = v114
            async {
            let v115 : Async<Async<bool>> option = None
            let v116 : bool = true in let mutable _v115 = v115
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v117 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            v117
#endif
            #if FABLE_COMPILER_RUST && WASM
            let v118 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            v118
#endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let v119 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            v119
#endif
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v120 : Async<Async<bool>> = Async.StartChild (v103, v55)
            v120
#endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v121 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            v121
#endif
            #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
            let v122 : Async<Async<bool>> = Unchecked.defaultof<Async<Async<bool>>>
            v122
#endif
            |> fun x -> _v115 <- Some x
            let v123 : Async<Async<bool>> = _v115.Value
            let! v123 = v123 
            let v124 : Async<bool> = v123 
            let v125 : Async<Choice<bool, exn>> option = None
            let v126 : bool = true in let mutable _v125 = v125
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v127 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
            v127
#endif
            #if FABLE_COMPILER_RUST && WASM
            let v128 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
            v128
#endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let v129 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
            v129
#endif
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v130 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v131 : Async<Choice<bool, exn>> = v130 v124
            v131
#endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v132 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
            v132
#endif
            #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
            let v133 : Async<Choice<bool, exn>> = Unchecked.defaultof<Async<Choice<bool, exn>>>
            v133
#endif
            |> fun x -> _v125 <- Some x
            let v134 : Async<Choice<bool, exn>> = _v125.Value
            let v135 : Async<US4> option = None
            let v136 : bool = true in let mutable _v135 = v135
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v137 : Async<US4> = null |> unbox<Async<US4>>
            v137
#endif
            #if FABLE_COMPILER_RUST && WASM
            let v138 : Async<US4> = null |> unbox<Async<US4>>
            v138
#endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let v139 : Async<US4> = null |> unbox<Async<US4>>
            v139
#endif
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v140 : Async<US4> option = None
            let mutable _v140 = v140
            async {
            let! v134 = v134 
            let v141 : Choice<bool, exn> = v134 
            let v142 : US4 option = None
            let v143 : bool = true in let mutable _v142 = v142
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v144 : US4 = null |> unbox<US4>
            v144
#endif
            #if FABLE_COMPILER_RUST && WASM
            let v145 : US4 = null |> unbox<US4>
            v145
#endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let v146 : US4 = null |> unbox<US4>
            v146
#endif
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v147 : (bool -> US4) = closure8()
            let v148 : (exn -> US4) = closure9()
            let v149 : US4 = match v141 with Choice1Of2 x -> v147 x | Choice2Of2 x -> v148 x
            v149
#endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v150 : US4 = null |> unbox<US4>
            v150
#endif
            #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
            let v151 : US4 = Unchecked.defaultof<US4>
            v151
#endif
            |> fun x -> _v142 <- Some x
            let v152 : US4 = _v142.Value
            return v152 
            }
            |> fun x -> _v140 <- Some x
            let v153 : Async<US4> = _v140 |> Option.get
            v153
#endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v154 : Async<US4> = null |> unbox<Async<US4>>
            v154
#endif
            #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
            let v155 : Async<US4> = Unchecked.defaultof<Async<US4>>
            v155
#endif
            |> fun x -> _v135 <- Some x
            let v156 : Async<US4> = _v135.Value
            let v157 : Async<US5> option = None
            let v158 : bool = true in let mutable _v157 = v157
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v159 : Async<US5> = null |> unbox<Async<US5>>
            v159
#endif
            #if FABLE_COMPILER_RUST && WASM
            let v160 : Async<US5> = null |> unbox<Async<US5>>
            v160
#endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let v161 : Async<US5> = null |> unbox<Async<US5>>
            v161
#endif
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v162 : Async<US5> option = None
            let mutable _v162 = v162
            async {
            let! v156 = v156 
            let v163 : US4 = v156 
            let v169 : US5 =
                match v163 with
                | US4_0(v164) -> (* Choice1Of2 *)
                    US5_0(v164)
                | US4_1(v166) -> (* Choice2Of2 *)
                    US5_1(v166)
            return v169 
            }
            |> fun x -> _v162 <- Some x
            let v170 : Async<US5> = _v162 |> Option.get
            v170
#endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v171 : Async<US5> = null |> unbox<Async<US5>>
            v171
#endif
            #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
            let v172 : Async<US5> = Unchecked.defaultof<Async<US5>>
            v172
#endif
            |> fun x -> _v157 <- Some x
            let v173 : Async<US5> = _v157.Value
            let v174 : Async<US3> option = None
            let v175 : bool = true in let mutable _v174 = v174
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v176 : Async<US3> = null |> unbox<Async<US3>>
            v176
#endif
            #if FABLE_COMPILER_RUST && WASM
            let v177 : Async<US3> = null |> unbox<Async<US3>>
            v177
#endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let v178 : Async<US3> = null |> unbox<Async<US3>>
            v178
#endif
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v179 : Async<US3> option = None
            let mutable _v179 = v179
            async {
            let! v173 = v173 
            let v180 : US5 = v173 
            let v206 : US3 =
                match v180 with
                | US5_1(v183) -> (* Error *)
                    let v184 : string = $"%A{v183}"
                    let v185 : string = "System.TimeoutException"
                    let v186 : bool = v184.Contains v185
                    if v186 then
                        let v187 : US0 = US0_1
                        let v188 : (unit -> string) = closure10()
                        let v189 : (unit -> string) = closure11(v55)
                        method2(v187, v188, v189)
                        US3_1
                    else
                        let v191 : string option = None
                        let v192 : bool = true in let mutable _v191 = v191
                        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v193 : string = $"%A{v183}"
                        v193
#endif
                        #if FABLE_COMPILER_RUST && WASM
                        let v194 : string = $"%A{v183}"
                        v194
#endif
                        #if FABLE_COMPILER_RUST && CONTRACT
                        let v195 : string = $"%A{v183}"
                        v195
#endif
                        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                        let v196 : string = $"{v183.GetType ()}: {v183.Message}"
                        v196
#endif
                        #if FABLE_COMPILER_TYPESCRIPT
                        let v197 : string = $"%A{v183}"
                        v197
#endif
                        #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
                        let v198 : string = Unchecked.defaultof<string>
                        v198
#endif
                        |> fun x -> _v191 <- Some x
                        let v199 : string = _v191.Value
                        let v200 : US0 = US0_4
                        let v201 : (unit -> string) = closure12(v199)
                        let v202 : (unit -> string) = closure11(v55)
                        method2(v200, v201, v202)
                        US3_1
                | US5_0(v181) -> (* Ok *)
                    US3_0(v181)
            return v206 
            }
            |> fun x -> _v179 <- Some x
            let v207 : Async<US3> = _v179 |> Option.get
            v207
#endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v208 : Async<US3> = null |> unbox<Async<US3>>
            v208
#endif
            #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
            let v209 : Async<US3> = Unchecked.defaultof<Async<US3>>
            v209
#endif
            |> fun x -> _v174 <- Some x
            let v210 : Async<US3> = _v174.Value
            return! v210 
            }
            |> fun x -> _v114 <- Some x
            let v211 : Async<US3> = _v114 |> Option.get
            v211
#endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v212 : Async<US3> = null |> unbox<Async<US3>>
            v212
#endif
            #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
            let v213 : Async<US3> = Unchecked.defaultof<Async<US3>>
            v213
#endif
            |> fun x -> _v109 <- Some x
            let v214 : Async<US3> = _v109.Value
            v214
#endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v215 : Async<US3> = null |> unbox<Async<US3>>
            v215
#endif
            #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
            let v216 : Async<US3> = Unchecked.defaultof<Async<US3>>
            v216
#endif
            |> fun x -> _v104 <- Some x
            let v217 : Async<US3> = _v104.Value
            let! v217 = v217 
            let v218 : US3 = v217 
            let v221 : bool =
                match v218 with
                | US3_1 -> (* None *)
                    false
                | US3_0(v219) -> (* Some *)
                    v219
            return v221 
            }
            |> fun x -> _v61 <- Some x
            let v222 : Async<bool> = _v61 |> Option.get
            v222
#endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v223 : Async<bool> = null |> unbox<Async<bool>>
            v223
#endif
            #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
            let v224 : Async<bool> = Unchecked.defaultof<Async<bool>>
            v224
#endif
            |> fun x -> _v56 <- Some x
            let v225 : Async<bool> = _v56.Value
            v225
    let! v227 = v227 
    let v228 : bool = v227 
    let v229 : bool = v228 = v1
    if v229 then
        return v3 
        (*
        ()
    else
        *) else
        let v230 : int64 = v3 % 100L
        let v231 : bool = v230 = 0L
        if v231 then
            let v232 : US0 = US0_0
            let v233 : (unit -> string) = closure17()
            let v234 : (unit -> string) = closure18(v2, v3)
            method2(v232, v233, v234)
        let v235 : Async<unit> option = None
        let v236 : bool = true in let mutable _v235 = v235
        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v237 : Async<unit> = null |> unbox<Async<unit>>
        v237
#endif
        #if FABLE_COMPILER_RUST && WASM
        let v238 : Async<unit> = null |> unbox<Async<unit>>
        v238
#endif
        #if FABLE_COMPILER_RUST && CONTRACT
        let v239 : Async<unit> = null |> unbox<Async<unit>>
        v239
#endif
        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
        let v240 : (int32 -> Async<unit>) = Async.Sleep
        let v241 : Async<unit> = v240 10
        v241
#endif
        #if FABLE_COMPILER_TYPESCRIPT
        let v242 : Async<unit> = null |> unbox<Async<unit>>
        v242
#endif
        #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
        let v243 : Async<unit> = Unchecked.defaultof<Async<unit>>
        v243
#endif
        |> fun x -> _v235 <- Some x
        let v244 : Async<unit> = _v235.Value
        do! v244 
        let v245 : int64 = v3 + 1L
        let v246 : Async<int64> = method5(v0, v1, v2, v245)
        return! v246 
        (*
        ()
    *)
    }
    |> fun x -> _v9 <- Some x
    let v247 : Async<int64> = _v9 |> Option.get
    v247
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v248 : Async<int64> = null |> unbox<Async<int64>>
    v248
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v249 : Async<int64> = Unchecked.defaultof<Async<int64>>
    v249
#endif
    |> fun x -> _v4 <- Some x
    let v250 : Async<int64> = _v4.Value
    v250
and closure15 (v0 : int32 option, v1 : bool) (v2 : int32) : Async<int64> =
    let v3 : int64 = 0L
    method5(v0, v1, v2, v3)
and closure14 (v0 : int32 option) (v1 : bool) : (int32 -> Async<int64>) =
    closure15(v0, v1)
and closure13 () (v0 : int32 option) : (bool -> (int32 -> Async<int64>)) =
    closure14(v0)
and method7 (v0 : int32 option, v1 : int32) : Async<int32> =
    let v2 : Async<int32> option = None
    let v3 : bool = true in let mutable _v2 = v2
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
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v7 : Async<int32> option = None
    let mutable _v7 = v7
    async {
    let v8 : (int32 -> US6) = method6()
    let v9 : US6 = US6_1
    let v10 : US6 = v0 |> Option.map v8 |> Option.defaultValue v9 
    let v225 : Async<bool> =
        match v10 with
        | US6_1 -> (* None *)
            let v11 : Async<bool> option = None
            let v12 : bool = true in let mutable _v11 = v11
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v13 : Async<bool> = null |> unbox<Async<bool>>
            v13
#endif
            #if FABLE_COMPILER_RUST && WASM
            let v14 : Async<bool> = null |> unbox<Async<bool>>
            v14
#endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let v15 : Async<bool> = null |> unbox<Async<bool>>
            v15
#endif
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
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
            let v21 : string = "127.0.0.1"
            let v22 : System.Threading.Tasks.ValueTask = v20.ConnectAsync (v21, v1, v18)
            let v23 : (unit -> System.Threading.Tasks.Task) = v22.AsTask
            let v24 : System.Threading.Tasks.Task = v23 ()
            let v25 : Async<unit> option = None
            let v26 : bool = true in let mutable _v25 = v25
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v27 : Async<unit> = null |> unbox<Async<unit>>
            v27
#endif
            #if FABLE_COMPILER_RUST && WASM
            let v28 : Async<unit> = null |> unbox<Async<unit>>
            v28
#endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let v29 : Async<unit> = null |> unbox<Async<unit>>
            v29
#endif
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v30 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
            let v31 : Async<unit> = v30 v24
            v31
#endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v32 : Async<unit> = null |> unbox<Async<unit>>
            v32
#endif
            #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
            let v33 : Async<unit> = Unchecked.defaultof<Async<unit>>
            v33
#endif
            |> fun x -> _v25 <- Some x
            let v34 : Async<unit> = _v25.Value
            do! v34 
            return true 
            with ex ->
            let v35 : exn = ex
            let v36 : string option = None
            let v37 : bool = true in let mutable _v36 = v36
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v38 : string = $"%A{v35}"
            v38
#endif
            #if FABLE_COMPILER_RUST && WASM
            let v39 : string = $"%A{v35}"
            v39
#endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let v40 : string = $"%A{v35}"
            v40
#endif
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v41 : string = $"{v35.GetType ()}: {v35.Message}"
            v41
#endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v42 : string = $"%A{v35}"
            v42
#endif
            #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
            let v43 : string = Unchecked.defaultof<string>
            v43
#endif
            |> fun x -> _v36 <- Some x
            let v44 : string = _v36.Value
            let v45 : US0 = US0_0
            let v46 : (unit -> string) = closure2(v44)
            let v47 : (unit -> string) = closure3()
            method2(v45, v46, v47)
            return false 
            (*
            let v48 : bool = *)
            }
            |> fun x -> _v16 <- Some x
            let v49 : Async<bool> = _v16 |> Option.get
            v49
#endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v50 : Async<bool> = null |> unbox<Async<bool>>
            v50
#endif
            #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
            let v51 : Async<bool> = Unchecked.defaultof<Async<bool>>
            v51
#endif
            |> fun x -> _v11 <- Some x
            let v52 : Async<bool> = _v11.Value
            v52
        | US6_0(v53) -> (* Some *)
            let v54 : Async<bool> option = None
            let v55 : bool = true in let mutable _v54 = v54
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
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v59 : Async<bool> option = None
            let mutable _v59 = v59
            async {
            let v60 : Async<bool> option = None
            let v61 : bool = true in let mutable _v60 = v60
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v62 : Async<bool> = null |> unbox<Async<bool>>
            v62
#endif
            #if FABLE_COMPILER_RUST && WASM
            let v63 : Async<bool> = null |> unbox<Async<bool>>
            v63
#endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let v64 : Async<bool> = null |> unbox<Async<bool>>
            v64
#endif
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v65 : Async<bool> option = None
            let mutable _v65 = v65
            async {
            let v66 : Async<System.Threading.CancellationToken> = Async.CancellationToken
            let! v66 = v66 
            let v67 : System.Threading.CancellationToken = v66 
            let v68 : System.Net.Sockets.TcpClient = new System.Net.Sockets.TcpClient ()
            use v68 = v68 
            let v69 : System.Net.Sockets.TcpClient = v68 
            try
            let v70 : string = "127.0.0.1"
            let v71 : System.Threading.Tasks.ValueTask = v69.ConnectAsync (v70, v1, v67)
            let v72 : (unit -> System.Threading.Tasks.Task) = v71.AsTask
            let v73 : System.Threading.Tasks.Task = v72 ()
            let v74 : Async<unit> option = None
            let v75 : bool = true in let mutable _v74 = v74
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v76 : Async<unit> = null |> unbox<Async<unit>>
            v76
#endif
            #if FABLE_COMPILER_RUST && WASM
            let v77 : Async<unit> = null |> unbox<Async<unit>>
            v77
#endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let v78 : Async<unit> = null |> unbox<Async<unit>>
            v78
#endif
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v79 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
            let v80 : Async<unit> = v79 v73
            v80
#endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v81 : Async<unit> = null |> unbox<Async<unit>>
            v81
#endif
            #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
            let v82 : Async<unit> = Unchecked.defaultof<Async<unit>>
            v82
#endif
            |> fun x -> _v74 <- Some x
            let v83 : Async<unit> = _v74.Value
            do! v83 
            return true 
            with ex ->
            let v84 : exn = ex
            let v85 : string option = None
            let v86 : bool = true in let mutable _v85 = v85
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v87 : string = $"%A{v84}"
            v87
#endif
            #if FABLE_COMPILER_RUST && WASM
            let v88 : string = $"%A{v84}"
            v88
#endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let v89 : string = $"%A{v84}"
            v89
#endif
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v90 : string = $"{v84.GetType ()}: {v84.Message}"
            v90
#endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v91 : string = $"%A{v84}"
            v91
#endif
            #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
            let v92 : string = Unchecked.defaultof<string>
            v92
#endif
            |> fun x -> _v85 <- Some x
            let v93 : string = _v85.Value
            let v94 : US0 = US0_0
            let v95 : (unit -> string) = closure2(v93)
            let v96 : (unit -> string) = closure3()
            method2(v94, v95, v96)
            return false 
            (*
            let v97 : bool = *)
            }
            |> fun x -> _v65 <- Some x
            let v98 : Async<bool> = _v65 |> Option.get
            v98
#endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v99 : Async<bool> = null |> unbox<Async<bool>>
            v99
#endif
            #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
            let v100 : Async<bool> = Unchecked.defaultof<Async<bool>>
            v100
#endif
            |> fun x -> _v60 <- Some x
            let v101 : Async<bool> = _v60.Value
            let v102 : Async<US3> option = None
            let v103 : bool = true in let mutable _v102 = v102
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v104 : Async<US3> = null |> unbox<Async<US3>>
            v104
#endif
            #if FABLE_COMPILER_RUST && WASM
            let v105 : Async<US3> = null |> unbox<Async<US3>>
            v105
#endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let v106 : Async<US3> = null |> unbox<Async<US3>>
            v106
#endif
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v107 : Async<US3> option = None
            let v108 : bool = true in let mutable _v107 = v107
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v109 : Async<US3> = null |> unbox<Async<US3>>
            v109
#endif
            #if FABLE_COMPILER_RUST && WASM
            let v110 : Async<US3> = null |> unbox<Async<US3>>
            v110
#endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let v111 : Async<US3> = null |> unbox<Async<US3>>
            v111
#endif
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v112 : Async<US3> option = None
            let mutable _v112 = v112
            async {
            let v113 : Async<Async<bool>> option = None
            let v114 : bool = true in let mutable _v113 = v113
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v115 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            v115
#endif
            #if FABLE_COMPILER_RUST && WASM
            let v116 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            v116
#endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let v117 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            v117
#endif
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v118 : Async<Async<bool>> = Async.StartChild (v101, v53)
            v118
#endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v119 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            v119
#endif
            #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
            let v120 : Async<Async<bool>> = Unchecked.defaultof<Async<Async<bool>>>
            v120
#endif
            |> fun x -> _v113 <- Some x
            let v121 : Async<Async<bool>> = _v113.Value
            let! v121 = v121 
            let v122 : Async<bool> = v121 
            let v123 : Async<Choice<bool, exn>> option = None
            let v124 : bool = true in let mutable _v123 = v123
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
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v128 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v129 : Async<Choice<bool, exn>> = v128 v122
            v129
#endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v130 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
            v130
#endif
            #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
            let v131 : Async<Choice<bool, exn>> = Unchecked.defaultof<Async<Choice<bool, exn>>>
            v131
#endif
            |> fun x -> _v123 <- Some x
            let v132 : Async<Choice<bool, exn>> = _v123.Value
            let v133 : Async<US4> option = None
            let v134 : bool = true in let mutable _v133 = v133
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v135 : Async<US4> = null |> unbox<Async<US4>>
            v135
#endif
            #if FABLE_COMPILER_RUST && WASM
            let v136 : Async<US4> = null |> unbox<Async<US4>>
            v136
#endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let v137 : Async<US4> = null |> unbox<Async<US4>>
            v137
#endif
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v138 : Async<US4> option = None
            let mutable _v138 = v138
            async {
            let! v132 = v132 
            let v139 : Choice<bool, exn> = v132 
            let v140 : US4 option = None
            let v141 : bool = true in let mutable _v140 = v140
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v142 : US4 = null |> unbox<US4>
            v142
#endif
            #if FABLE_COMPILER_RUST && WASM
            let v143 : US4 = null |> unbox<US4>
            v143
#endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let v144 : US4 = null |> unbox<US4>
            v144
#endif
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v145 : (bool -> US4) = closure8()
            let v146 : (exn -> US4) = closure9()
            let v147 : US4 = match v139 with Choice1Of2 x -> v145 x | Choice2Of2 x -> v146 x
            v147
#endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v148 : US4 = null |> unbox<US4>
            v148
#endif
            #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
            let v149 : US4 = Unchecked.defaultof<US4>
            v149
#endif
            |> fun x -> _v140 <- Some x
            let v150 : US4 = _v140.Value
            return v150 
            }
            |> fun x -> _v138 <- Some x
            let v151 : Async<US4> = _v138 |> Option.get
            v151
#endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v152 : Async<US4> = null |> unbox<Async<US4>>
            v152
#endif
            #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
            let v153 : Async<US4> = Unchecked.defaultof<Async<US4>>
            v153
#endif
            |> fun x -> _v133 <- Some x
            let v154 : Async<US4> = _v133.Value
            let v155 : Async<US5> option = None
            let v156 : bool = true in let mutable _v155 = v155
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v157 : Async<US5> = null |> unbox<Async<US5>>
            v157
#endif
            #if FABLE_COMPILER_RUST && WASM
            let v158 : Async<US5> = null |> unbox<Async<US5>>
            v158
#endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let v159 : Async<US5> = null |> unbox<Async<US5>>
            v159
#endif
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v160 : Async<US5> option = None
            let mutable _v160 = v160
            async {
            let! v154 = v154 
            let v161 : US4 = v154 
            let v167 : US5 =
                match v161 with
                | US4_0(v162) -> (* Choice1Of2 *)
                    US5_0(v162)
                | US4_1(v164) -> (* Choice2Of2 *)
                    US5_1(v164)
            return v167 
            }
            |> fun x -> _v160 <- Some x
            let v168 : Async<US5> = _v160 |> Option.get
            v168
#endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v169 : Async<US5> = null |> unbox<Async<US5>>
            v169
#endif
            #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
            let v170 : Async<US5> = Unchecked.defaultof<Async<US5>>
            v170
#endif
            |> fun x -> _v155 <- Some x
            let v171 : Async<US5> = _v155.Value
            let v172 : Async<US3> option = None
            let v173 : bool = true in let mutable _v172 = v172
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v174 : Async<US3> = null |> unbox<Async<US3>>
            v174
#endif
            #if FABLE_COMPILER_RUST && WASM
            let v175 : Async<US3> = null |> unbox<Async<US3>>
            v175
#endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let v176 : Async<US3> = null |> unbox<Async<US3>>
            v176
#endif
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v177 : Async<US3> option = None
            let mutable _v177 = v177
            async {
            let! v171 = v171 
            let v178 : US5 = v171 
            let v204 : US3 =
                match v178 with
                | US5_1(v181) -> (* Error *)
                    let v182 : string = $"%A{v181}"
                    let v183 : string = "System.TimeoutException"
                    let v184 : bool = v182.Contains v183
                    if v184 then
                        let v185 : US0 = US0_1
                        let v186 : (unit -> string) = closure10()
                        let v187 : (unit -> string) = closure11(v53)
                        method2(v185, v186, v187)
                        US3_1
                    else
                        let v189 : string option = None
                        let v190 : bool = true in let mutable _v189 = v189
                        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v191 : string = $"%A{v181}"
                        v191
#endif
                        #if FABLE_COMPILER_RUST && WASM
                        let v192 : string = $"%A{v181}"
                        v192
#endif
                        #if FABLE_COMPILER_RUST && CONTRACT
                        let v193 : string = $"%A{v181}"
                        v193
#endif
                        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                        let v194 : string = $"{v181.GetType ()}: {v181.Message}"
                        v194
#endif
                        #if FABLE_COMPILER_TYPESCRIPT
                        let v195 : string = $"%A{v181}"
                        v195
#endif
                        #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
                        let v196 : string = Unchecked.defaultof<string>
                        v196
#endif
                        |> fun x -> _v189 <- Some x
                        let v197 : string = _v189.Value
                        let v198 : US0 = US0_4
                        let v199 : (unit -> string) = closure12(v197)
                        let v200 : (unit -> string) = closure11(v53)
                        method2(v198, v199, v200)
                        US3_1
                | US5_0(v179) -> (* Ok *)
                    US3_0(v179)
            return v204 
            }
            |> fun x -> _v177 <- Some x
            let v205 : Async<US3> = _v177 |> Option.get
            v205
#endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v206 : Async<US3> = null |> unbox<Async<US3>>
            v206
#endif
            #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
            let v207 : Async<US3> = Unchecked.defaultof<Async<US3>>
            v207
#endif
            |> fun x -> _v172 <- Some x
            let v208 : Async<US3> = _v172.Value
            return! v208 
            }
            |> fun x -> _v112 <- Some x
            let v209 : Async<US3> = _v112 |> Option.get
            v209
#endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v210 : Async<US3> = null |> unbox<Async<US3>>
            v210
#endif
            #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
            let v211 : Async<US3> = Unchecked.defaultof<Async<US3>>
            v211
#endif
            |> fun x -> _v107 <- Some x
            let v212 : Async<US3> = _v107.Value
            v212
#endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v213 : Async<US3> = null |> unbox<Async<US3>>
            v213
#endif
            #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
            let v214 : Async<US3> = Unchecked.defaultof<Async<US3>>
            v214
#endif
            |> fun x -> _v102 <- Some x
            let v215 : Async<US3> = _v102.Value
            let! v215 = v215 
            let v216 : US3 = v215 
            let v219 : bool =
                match v216 with
                | US3_1 -> (* None *)
                    false
                | US3_0(v217) -> (* Some *)
                    v217
            return v219 
            }
            |> fun x -> _v59 <- Some x
            let v220 : Async<bool> = _v59 |> Option.get
            v220
#endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v221 : Async<bool> = null |> unbox<Async<bool>>
            v221
#endif
            #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
            let v222 : Async<bool> = Unchecked.defaultof<Async<bool>>
            v222
#endif
            |> fun x -> _v54 <- Some x
            let v223 : Async<bool> = _v54.Value
            v223
    let! v225 = v225 
    let v226 : bool = v225 
    let v227 : bool = v226 = false
    if v227 then
        return v1 
        (*
        ()
    else
        *) else
        let v228 : int32 = v1 + 1
        let v229 : Async<int32> = method7(v0, v228)
        return! v229 
        (*
        ()
    *)
    }
    |> fun x -> _v7 <- Some x
    let v230 : Async<int32> = _v7 |> Option.get
    v230
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v231 : Async<int32> = null |> unbox<Async<int32>>
    v231
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v232 : Async<int32> = Unchecked.defaultof<Async<int32>>
    v232
#endif
    |> fun x -> _v2 <- Some x
    let v233 : Async<int32> = _v2.Value
    v233
and closure20 (v0 : int32 option) (v1 : int32) : Async<int32> =
    method7(v0, v1)
and closure19 () (v0 : int32 option) : (int32 -> Async<int32>) =
    closure20(v0)
let v0 : (unit -> struct (Mut0 * Mut1 * Mut1 * Mut2 * int64 option)) = closure0()
if State.trace_state = None then State.trace_state <- v0 () |> Some
let v1 : (int32 -> Async<bool>) = closure1()
let test_port_open x = v1 x
let v2 : (int32 -> (int32 -> Async<bool>)) = closure6()
let test_port_open_timeout x = v2 x
let v3 : (int32 option -> (bool -> (int32 -> Async<int64>))) = closure13()
let wait_for_port_access x = v3 x
let v4 : (int32 option -> (int32 -> Async<int32>)) = closure19()
let get_available_port x = v4 x
()
