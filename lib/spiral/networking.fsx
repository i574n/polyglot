#if FABLE_COMPILER // networking.types
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
and closure1 () (v0 : int32) : Async<bool> =
    let v1 : Async<bool> option = None
    let mutable _v1 = v1
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : Async<bool> = null |> unbox<Async<bool>>
    v2 
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v3 : Async<bool> = null |> unbox<Async<bool>>
    v3 
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v4 : Async<bool> = null |> unbox<Async<bool>>
    v4 
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v5 : Async<bool> option = None
    let mutable _v5 = v5
    async {
    let v6 : Async<System.Threading.CancellationToken> = Async.CancellationToken
    let! v6 = v6 
    let v7 : System.Threading.CancellationToken = v6 
    let v8 : System.Net.Sockets.TcpClient = new System.Net.Sockets.TcpClient ()
    use v8 = v8 
    let v9 : System.Net.Sockets.TcpClient = v8 
    try
    let v10 : string = "127.0.0.1"
    let v11 : System.Threading.Tasks.ValueTask = v9.ConnectAsync (v10, v0, v7)
    let v12 : (unit -> System.Threading.Tasks.Task) = v11.AsTask
    let v13 : System.Threading.Tasks.Task = v12 ()
    let v14 : Async<unit> option = None
    let mutable _v14 = v14
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v15 : Async<unit> = null |> unbox<Async<unit>>
    v15 
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v16 : Async<unit> = null |> unbox<Async<unit>>
    v16 
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v17 : Async<unit> = null |> unbox<Async<unit>>
    v17 
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v18 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
    let v19 : Async<unit> = v18 v13
    v19 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v20 : Async<unit> = null |> unbox<Async<unit>>
    v20 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v21 : Async<unit> = Unchecked.defaultof<Async<unit>>
    v21 
    #endif
    |> fun x -> _v14 <- Some x
    let v22 : Async<unit> = _v14.Value
    do! v22 
    return true 
    with ex ->
    let v23 : exn = ex
    let v24 : string option = None
    let mutable _v24 = v24
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v25 : string = $"%A{v23}"
    v25 
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v26 : string = $"%A{v23}"
    v26 
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v27 : string = $"%A{v23}"
    v27 
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v28 : string = $"{v23.GetType ()}: {v23.Message}"
    v28 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v29 : string = $"%A{v23}"
    v29 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v30 : string = Unchecked.defaultof<string>
    v30 
    #endif
    |> fun x -> _v24 <- Some x
    let v31 : string = _v24.Value
    let v32 : US0 = US0_0
    let v33 : (unit -> string) = closure2(v31)
    let v34 : (unit -> string) = closure3()
    method2(v32, v33, v34)
    return false 
    (*
    let v35 : bool = *)
    }
    |> fun x -> _v5 <- Some x
    let v36 : Async<bool> = _v5 |> Option.get
    v36 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v37 : Async<bool> = null |> unbox<Async<bool>>
    v37 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v38 : Async<bool> = Unchecked.defaultof<Async<bool>>
    v38 
    #endif
    |> fun x -> _v1 <- Some x
    let v39 : Async<bool> = _v1.Value
    v39
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
    let mutable _v2 = v2
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
    let v7 : Async<bool> option = None
    let mutable _v7 = v7
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v8 : Async<bool> = null |> unbox<Async<bool>>
    v8 
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v9 : Async<bool> = null |> unbox<Async<bool>>
    v9 
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v10 : Async<bool> = null |> unbox<Async<bool>>
    v10 
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v11 : Async<bool> option = None
    let mutable _v11 = v11
    async {
    let v12 : Async<System.Threading.CancellationToken> = Async.CancellationToken
    let! v12 = v12 
    let v13 : System.Threading.CancellationToken = v12 
    let v14 : System.Net.Sockets.TcpClient = new System.Net.Sockets.TcpClient ()
    use v14 = v14 
    let v15 : System.Net.Sockets.TcpClient = v14 
    try
    let v16 : string = "127.0.0.1"
    let v17 : System.Threading.Tasks.ValueTask = v15.ConnectAsync (v16, v1, v13)
    let v18 : (unit -> System.Threading.Tasks.Task) = v17.AsTask
    let v19 : System.Threading.Tasks.Task = v18 ()
    let v20 : Async<unit> option = None
    let mutable _v20 = v20
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v21 : Async<unit> = null |> unbox<Async<unit>>
    v21 
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v22 : Async<unit> = null |> unbox<Async<unit>>
    v22 
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v23 : Async<unit> = null |> unbox<Async<unit>>
    v23 
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v24 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
    let v25 : Async<unit> = v24 v19
    v25 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v26 : Async<unit> = null |> unbox<Async<unit>>
    v26 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v27 : Async<unit> = Unchecked.defaultof<Async<unit>>
    v27 
    #endif
    |> fun x -> _v20 <- Some x
    let v28 : Async<unit> = _v20.Value
    do! v28 
    return true 
    with ex ->
    let v29 : exn = ex
    let v30 : string option = None
    let mutable _v30 = v30
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v31 : string = $"%A{v29}"
    v31 
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v32 : string = $"%A{v29}"
    v32 
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v33 : string = $"%A{v29}"
    v33 
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v34 : string = $"{v29.GetType ()}: {v29.Message}"
    v34 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v35 : string = $"%A{v29}"
    v35 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v36 : string = Unchecked.defaultof<string>
    v36 
    #endif
    |> fun x -> _v30 <- Some x
    let v37 : string = _v30.Value
    let v38 : US0 = US0_0
    let v39 : (unit -> string) = closure2(v37)
    let v40 : (unit -> string) = closure3()
    method2(v38, v39, v40)
    return false 
    (*
    let v41 : bool = *)
    }
    |> fun x -> _v11 <- Some x
    let v42 : Async<bool> = _v11 |> Option.get
    v42 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v43 : Async<bool> = null |> unbox<Async<bool>>
    v43 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v44 : Async<bool> = Unchecked.defaultof<Async<bool>>
    v44 
    #endif
    |> fun x -> _v7 <- Some x
    let v45 : Async<bool> = _v7.Value
    let v46 : Async<US3> option = None
    let mutable _v46 = v46
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v47 : Async<US3> = null |> unbox<Async<US3>>
    v47 
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v48 : Async<US3> = null |> unbox<Async<US3>>
    v48 
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v49 : Async<US3> = null |> unbox<Async<US3>>
    v49 
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v50 : Async<US3> option = None
    let mutable _v50 = v50
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v51 : Async<US3> = null |> unbox<Async<US3>>
    v51 
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v52 : Async<US3> = null |> unbox<Async<US3>>
    v52 
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v53 : Async<US3> = null |> unbox<Async<US3>>
    v53 
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v54 : Async<US3> option = None
    let mutable _v54 = v54
    async {
    let v55 : Async<Async<bool>> option = None
    let mutable _v55 = v55
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v56 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
    v56 
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v57 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
    v57 
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v58 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
    v58 
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v59 : Async<Async<bool>> = Async.StartChild (v45, v0)
    v59 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v60 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
    v60 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v61 : Async<Async<bool>> = Unchecked.defaultof<Async<Async<bool>>>
    v61 
    #endif
    |> fun x -> _v55 <- Some x
    let v62 : Async<Async<bool>> = _v55.Value
    let! v62 = v62 
    let v63 : Async<bool> = v62 
    let v64 : Async<Choice<bool, exn>> option = None
    let mutable _v64 = v64
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v65 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
    v65 
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v66 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
    v66 
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v67 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
    v67 
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v68 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
    let v69 : Async<Choice<bool, exn>> = v68 v63
    v69 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v70 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
    v70 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v71 : Async<Choice<bool, exn>> = Unchecked.defaultof<Async<Choice<bool, exn>>>
    v71 
    #endif
    |> fun x -> _v64 <- Some x
    let v72 : Async<Choice<bool, exn>> = _v64.Value
    let v73 : Async<US4> option = None
    let mutable _v73 = v73
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v74 : Async<US4> = null |> unbox<Async<US4>>
    v74 
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v75 : Async<US4> = null |> unbox<Async<US4>>
    v75 
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v76 : Async<US4> = null |> unbox<Async<US4>>
    v76 
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v77 : Async<US4> option = None
    let mutable _v77 = v77
    async {
    let! v72 = v72 
    let v78 : Choice<bool, exn> = v72 
    let v79 : US4 option = None
    let mutable _v79 = v79
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v80 : US4 = null |> unbox<US4>
    v80 
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v81 : US4 = null |> unbox<US4>
    v81 
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v82 : US4 = null |> unbox<US4>
    v82 
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v83 : (bool -> US4) = closure8()
    let v84 : (exn -> US4) = closure9()
    let v85 : US4 = match v78 with Choice1Of2 x -> v83 x | Choice2Of2 x -> v84 x
    v85 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v86 : US4 = null |> unbox<US4>
    v86 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v87 : US4 = Unchecked.defaultof<US4>
    v87 
    #endif
    |> fun x -> _v79 <- Some x
    let v88 : US4 = _v79.Value
    return v88 
    }
    |> fun x -> _v77 <- Some x
    let v89 : Async<US4> = _v77 |> Option.get
    v89 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v90 : Async<US4> = null |> unbox<Async<US4>>
    v90 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v91 : Async<US4> = Unchecked.defaultof<Async<US4>>
    v91 
    #endif
    |> fun x -> _v73 <- Some x
    let v92 : Async<US4> = _v73.Value
    let v93 : Async<US5> option = None
    let mutable _v93 = v93
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v94 : Async<US5> = null |> unbox<Async<US5>>
    v94 
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v95 : Async<US5> = null |> unbox<Async<US5>>
    v95 
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v96 : Async<US5> = null |> unbox<Async<US5>>
    v96 
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v97 : Async<US5> option = None
    let mutable _v97 = v97
    async {
    let! v92 = v92 
    let v98 : US4 = v92 
    let v104 : US5 =
        match v98 with
        | US4_0(v99) -> (* Choice1Of2 *)
            US5_0(v99)
        | US4_1(v101) -> (* Choice2Of2 *)
            US5_1(v101)
    return v104 
    }
    |> fun x -> _v97 <- Some x
    let v105 : Async<US5> = _v97 |> Option.get
    v105 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v106 : Async<US5> = null |> unbox<Async<US5>>
    v106 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v107 : Async<US5> = Unchecked.defaultof<Async<US5>>
    v107 
    #endif
    |> fun x -> _v93 <- Some x
    let v108 : Async<US5> = _v93.Value
    let v109 : Async<US3> option = None
    let mutable _v109 = v109
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
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v113 : Async<US3> option = None
    let mutable _v113 = v113
    async {
    let! v108 = v108 
    let v114 : US5 = v108 
    let v139 : US3 =
        match v114 with
        | US5_1(v117) -> (* Error *)
            let v118 : string = $"%A{v117}"
            let v119 : string = "System.TimeoutException"
            let v120 : bool = v118.Contains v119
            if v120 then
                let v121 : US0 = US0_1
                let v122 : (unit -> string) = closure10()
                let v123 : (unit -> string) = closure11(v0)
                method2(v121, v122, v123)
                US3_1
            else
                let v125 : string option = None
                let mutable _v125 = v125
                #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v126 : string = $"%A{v117}"
                v126 
                #endif
                #if FABLE_COMPILER_RUST && WASM
                let v127 : string = $"%A{v117}"
                v127 
                #endif
                #if FABLE_COMPILER_RUST && CONTRACT
                let v128 : string = $"%A{v117}"
                v128 
                #endif
                #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                let v129 : string = $"{v117.GetType ()}: {v117.Message}"
                v129 
                #endif
                #if FABLE_COMPILER_TYPESCRIPT
                let v130 : string = $"%A{v117}"
                v130 
                #endif
                #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
                let v131 : string = Unchecked.defaultof<string>
                v131 
                #endif
                |> fun x -> _v125 <- Some x
                let v132 : string = _v125.Value
                let v133 : US0 = US0_4
                let v134 : (unit -> string) = closure12(v132)
                let v135 : (unit -> string) = closure11(v0)
                method2(v133, v134, v135)
                US3_1
        | US5_0(v115) -> (* Ok *)
            US3_0(v115)
    return v139 
    }
    |> fun x -> _v113 <- Some x
    let v140 : Async<US3> = _v113 |> Option.get
    v140 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v141 : Async<US3> = null |> unbox<Async<US3>>
    v141 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v142 : Async<US3> = Unchecked.defaultof<Async<US3>>
    v142 
    #endif
    |> fun x -> _v109 <- Some x
    let v143 : Async<US3> = _v109.Value
    return! v143 
    }
    |> fun x -> _v54 <- Some x
    let v144 : Async<US3> = _v54 |> Option.get
    v144 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v145 : Async<US3> = null |> unbox<Async<US3>>
    v145 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v146 : Async<US3> = Unchecked.defaultof<Async<US3>>
    v146 
    #endif
    |> fun x -> _v50 <- Some x
    let v147 : Async<US3> = _v50.Value
    v147 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v148 : Async<US3> = null |> unbox<Async<US3>>
    v148 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v149 : Async<US3> = Unchecked.defaultof<Async<US3>>
    v149 
    #endif
    |> fun x -> _v46 <- Some x
    let v150 : Async<US3> = _v46.Value
    let! v150 = v150 
    let v151 : US3 = v150 
    let v154 : bool =
        match v151 with
        | US3_1 -> (* None *)
            false
        | US3_0(v152) -> (* Some *)
            v152
    return v154 
    }
    |> fun x -> _v6 <- Some x
    let v155 : Async<bool> = _v6 |> Option.get
    v155 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v156 : Async<bool> = null |> unbox<Async<bool>>
    v156 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v157 : Async<bool> = Unchecked.defaultof<Async<bool>>
    v157 
    #endif
    |> fun x -> _v2 <- Some x
    let v158 : Async<bool> = _v2.Value
    v158
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
    let mutable _v4 = v4
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v5 : Async<int64> = null |> unbox<Async<int64>>
    v5 
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v6 : Async<int64> = null |> unbox<Async<int64>>
    v6 
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v7 : Async<int64> = null |> unbox<Async<int64>>
    v7 
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v8 : Async<int64> option = None
    let mutable _v8 = v8
    async {
    let v9 : (int32 -> US6) = method6()
    let v10 : US6 = US6_1
    let v11 : US6 = v0 |> Option.map v9 |> Option.defaultValue v10 
    let v210 : Async<bool> =
        match v11 with
        | US6_1 -> (* None *)
            let v12 : Async<bool> option = None
            let mutable _v12 = v12
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
            let v22 : System.Threading.Tasks.ValueTask = v20.ConnectAsync (v21, v2, v18)
            let v23 : (unit -> System.Threading.Tasks.Task) = v22.AsTask
            let v24 : System.Threading.Tasks.Task = v23 ()
            let v25 : Async<unit> option = None
            let mutable _v25 = v25
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v26 : Async<unit> = null |> unbox<Async<unit>>
            v26 
            #endif
            #if FABLE_COMPILER_RUST && WASM
            let v27 : Async<unit> = null |> unbox<Async<unit>>
            v27 
            #endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let v28 : Async<unit> = null |> unbox<Async<unit>>
            v28 
            #endif
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v29 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
            let v30 : Async<unit> = v29 v24
            v30 
            #endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v31 : Async<unit> = null |> unbox<Async<unit>>
            v31 
            #endif
            #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
            let v32 : Async<unit> = Unchecked.defaultof<Async<unit>>
            v32 
            #endif
            |> fun x -> _v25 <- Some x
            let v33 : Async<unit> = _v25.Value
            do! v33 
            return true 
            with ex ->
            let v34 : exn = ex
            let v35 : string option = None
            let mutable _v35 = v35
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v36 : string = $"%A{v34}"
            v36 
            #endif
            #if FABLE_COMPILER_RUST && WASM
            let v37 : string = $"%A{v34}"
            v37 
            #endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let v38 : string = $"%A{v34}"
            v38 
            #endif
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v39 : string = $"{v34.GetType ()}: {v34.Message}"
            v39 
            #endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v40 : string = $"%A{v34}"
            v40 
            #endif
            #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
            let v41 : string = Unchecked.defaultof<string>
            v41 
            #endif
            |> fun x -> _v35 <- Some x
            let v42 : string = _v35.Value
            let v43 : US0 = US0_0
            let v44 : (unit -> string) = closure2(v42)
            let v45 : (unit -> string) = closure3()
            method2(v43, v44, v45)
            return false 
            (*
            let v46 : bool = *)
            }
            |> fun x -> _v16 <- Some x
            let v47 : Async<bool> = _v16 |> Option.get
            v47 
            #endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v48 : Async<bool> = null |> unbox<Async<bool>>
            v48 
            #endif
            #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
            let v49 : Async<bool> = Unchecked.defaultof<Async<bool>>
            v49 
            #endif
            |> fun x -> _v12 <- Some x
            let v50 : Async<bool> = _v12.Value
            v50
        | US6_0(v51) -> (* Some *)
            let v52 : Async<bool> option = None
            let mutable _v52 = v52
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v53 : Async<bool> = null |> unbox<Async<bool>>
            v53 
            #endif
            #if FABLE_COMPILER_RUST && WASM
            let v54 : Async<bool> = null |> unbox<Async<bool>>
            v54 
            #endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let v55 : Async<bool> = null |> unbox<Async<bool>>
            v55 
            #endif
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v56 : Async<bool> option = None
            let mutable _v56 = v56
            async {
            let v57 : Async<bool> option = None
            let mutable _v57 = v57
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
            let v62 : Async<System.Threading.CancellationToken> = Async.CancellationToken
            let! v62 = v62 
            let v63 : System.Threading.CancellationToken = v62 
            let v64 : System.Net.Sockets.TcpClient = new System.Net.Sockets.TcpClient ()
            use v64 = v64 
            let v65 : System.Net.Sockets.TcpClient = v64 
            try
            let v66 : string = "127.0.0.1"
            let v67 : System.Threading.Tasks.ValueTask = v65.ConnectAsync (v66, v2, v63)
            let v68 : (unit -> System.Threading.Tasks.Task) = v67.AsTask
            let v69 : System.Threading.Tasks.Task = v68 ()
            let v70 : Async<unit> option = None
            let mutable _v70 = v70
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v71 : Async<unit> = null |> unbox<Async<unit>>
            v71 
            #endif
            #if FABLE_COMPILER_RUST && WASM
            let v72 : Async<unit> = null |> unbox<Async<unit>>
            v72 
            #endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let v73 : Async<unit> = null |> unbox<Async<unit>>
            v73 
            #endif
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v74 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
            let v75 : Async<unit> = v74 v69
            v75 
            #endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v76 : Async<unit> = null |> unbox<Async<unit>>
            v76 
            #endif
            #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
            let v77 : Async<unit> = Unchecked.defaultof<Async<unit>>
            v77 
            #endif
            |> fun x -> _v70 <- Some x
            let v78 : Async<unit> = _v70.Value
            do! v78 
            return true 
            with ex ->
            let v79 : exn = ex
            let v80 : string option = None
            let mutable _v80 = v80
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v81 : string = $"%A{v79}"
            v81 
            #endif
            #if FABLE_COMPILER_RUST && WASM
            let v82 : string = $"%A{v79}"
            v82 
            #endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let v83 : string = $"%A{v79}"
            v83 
            #endif
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v84 : string = $"{v79.GetType ()}: {v79.Message}"
            v84 
            #endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v85 : string = $"%A{v79}"
            v85 
            #endif
            #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
            let v86 : string = Unchecked.defaultof<string>
            v86 
            #endif
            |> fun x -> _v80 <- Some x
            let v87 : string = _v80.Value
            let v88 : US0 = US0_0
            let v89 : (unit -> string) = closure2(v87)
            let v90 : (unit -> string) = closure3()
            method2(v88, v89, v90)
            return false 
            (*
            let v91 : bool = *)
            }
            |> fun x -> _v61 <- Some x
            let v92 : Async<bool> = _v61 |> Option.get
            v92 
            #endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v93 : Async<bool> = null |> unbox<Async<bool>>
            v93 
            #endif
            #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
            let v94 : Async<bool> = Unchecked.defaultof<Async<bool>>
            v94 
            #endif
            |> fun x -> _v57 <- Some x
            let v95 : Async<bool> = _v57.Value
            let v96 : Async<US3> option = None
            let mutable _v96 = v96
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v97 : Async<US3> = null |> unbox<Async<US3>>
            v97 
            #endif
            #if FABLE_COMPILER_RUST && WASM
            let v98 : Async<US3> = null |> unbox<Async<US3>>
            v98 
            #endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let v99 : Async<US3> = null |> unbox<Async<US3>>
            v99 
            #endif
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v100 : Async<US3> option = None
            let mutable _v100 = v100
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v101 : Async<US3> = null |> unbox<Async<US3>>
            v101 
            #endif
            #if FABLE_COMPILER_RUST && WASM
            let v102 : Async<US3> = null |> unbox<Async<US3>>
            v102 
            #endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let v103 : Async<US3> = null |> unbox<Async<US3>>
            v103 
            #endif
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v104 : Async<US3> option = None
            let mutable _v104 = v104
            async {
            let v105 : Async<Async<bool>> option = None
            let mutable _v105 = v105
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v106 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            v106 
            #endif
            #if FABLE_COMPILER_RUST && WASM
            let v107 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            v107 
            #endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let v108 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            v108 
            #endif
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v109 : Async<Async<bool>> = Async.StartChild (v95, v51)
            v109 
            #endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v110 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            v110 
            #endif
            #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
            let v111 : Async<Async<bool>> = Unchecked.defaultof<Async<Async<bool>>>
            v111 
            #endif
            |> fun x -> _v105 <- Some x
            let v112 : Async<Async<bool>> = _v105.Value
            let! v112 = v112 
            let v113 : Async<bool> = v112 
            let v114 : Async<Choice<bool, exn>> option = None
            let mutable _v114 = v114
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v115 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
            v115 
            #endif
            #if FABLE_COMPILER_RUST && WASM
            let v116 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
            v116 
            #endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let v117 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
            v117 
            #endif
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v118 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v119 : Async<Choice<bool, exn>> = v118 v113
            v119 
            #endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v120 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
            v120 
            #endif
            #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
            let v121 : Async<Choice<bool, exn>> = Unchecked.defaultof<Async<Choice<bool, exn>>>
            v121 
            #endif
            |> fun x -> _v114 <- Some x
            let v122 : Async<Choice<bool, exn>> = _v114.Value
            let v123 : Async<US4> option = None
            let mutable _v123 = v123
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v124 : Async<US4> = null |> unbox<Async<US4>>
            v124 
            #endif
            #if FABLE_COMPILER_RUST && WASM
            let v125 : Async<US4> = null |> unbox<Async<US4>>
            v125 
            #endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let v126 : Async<US4> = null |> unbox<Async<US4>>
            v126 
            #endif
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v127 : Async<US4> option = None
            let mutable _v127 = v127
            async {
            let! v122 = v122 
            let v128 : Choice<bool, exn> = v122 
            let v129 : US4 option = None
            let mutable _v129 = v129
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v130 : US4 = null |> unbox<US4>
            v130 
            #endif
            #if FABLE_COMPILER_RUST && WASM
            let v131 : US4 = null |> unbox<US4>
            v131 
            #endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let v132 : US4 = null |> unbox<US4>
            v132 
            #endif
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v133 : (bool -> US4) = closure8()
            let v134 : (exn -> US4) = closure9()
            let v135 : US4 = match v128 with Choice1Of2 x -> v133 x | Choice2Of2 x -> v134 x
            v135 
            #endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v136 : US4 = null |> unbox<US4>
            v136 
            #endif
            #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
            let v137 : US4 = Unchecked.defaultof<US4>
            v137 
            #endif
            |> fun x -> _v129 <- Some x
            let v138 : US4 = _v129.Value
            return v138 
            }
            |> fun x -> _v127 <- Some x
            let v139 : Async<US4> = _v127 |> Option.get
            v139 
            #endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v140 : Async<US4> = null |> unbox<Async<US4>>
            v140 
            #endif
            #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
            let v141 : Async<US4> = Unchecked.defaultof<Async<US4>>
            v141 
            #endif
            |> fun x -> _v123 <- Some x
            let v142 : Async<US4> = _v123.Value
            let v143 : Async<US5> option = None
            let mutable _v143 = v143
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v144 : Async<US5> = null |> unbox<Async<US5>>
            v144 
            #endif
            #if FABLE_COMPILER_RUST && WASM
            let v145 : Async<US5> = null |> unbox<Async<US5>>
            v145 
            #endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let v146 : Async<US5> = null |> unbox<Async<US5>>
            v146 
            #endif
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v147 : Async<US5> option = None
            let mutable _v147 = v147
            async {
            let! v142 = v142 
            let v148 : US4 = v142 
            let v154 : US5 =
                match v148 with
                | US4_0(v149) -> (* Choice1Of2 *)
                    US5_0(v149)
                | US4_1(v151) -> (* Choice2Of2 *)
                    US5_1(v151)
            return v154 
            }
            |> fun x -> _v147 <- Some x
            let v155 : Async<US5> = _v147 |> Option.get
            v155 
            #endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v156 : Async<US5> = null |> unbox<Async<US5>>
            v156 
            #endif
            #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
            let v157 : Async<US5> = Unchecked.defaultof<Async<US5>>
            v157 
            #endif
            |> fun x -> _v143 <- Some x
            let v158 : Async<US5> = _v143.Value
            let v159 : Async<US3> option = None
            let mutable _v159 = v159
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v160 : Async<US3> = null |> unbox<Async<US3>>
            v160 
            #endif
            #if FABLE_COMPILER_RUST && WASM
            let v161 : Async<US3> = null |> unbox<Async<US3>>
            v161 
            #endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let v162 : Async<US3> = null |> unbox<Async<US3>>
            v162 
            #endif
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v163 : Async<US3> option = None
            let mutable _v163 = v163
            async {
            let! v158 = v158 
            let v164 : US5 = v158 
            let v189 : US3 =
                match v164 with
                | US5_1(v167) -> (* Error *)
                    let v168 : string = $"%A{v167}"
                    let v169 : string = "System.TimeoutException"
                    let v170 : bool = v168.Contains v169
                    if v170 then
                        let v171 : US0 = US0_1
                        let v172 : (unit -> string) = closure10()
                        let v173 : (unit -> string) = closure11(v51)
                        method2(v171, v172, v173)
                        US3_1
                    else
                        let v175 : string option = None
                        let mutable _v175 = v175
                        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v176 : string = $"%A{v167}"
                        v176 
                        #endif
                        #if FABLE_COMPILER_RUST && WASM
                        let v177 : string = $"%A{v167}"
                        v177 
                        #endif
                        #if FABLE_COMPILER_RUST && CONTRACT
                        let v178 : string = $"%A{v167}"
                        v178 
                        #endif
                        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                        let v179 : string = $"{v167.GetType ()}: {v167.Message}"
                        v179 
                        #endif
                        #if FABLE_COMPILER_TYPESCRIPT
                        let v180 : string = $"%A{v167}"
                        v180 
                        #endif
                        #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
                        let v181 : string = Unchecked.defaultof<string>
                        v181 
                        #endif
                        |> fun x -> _v175 <- Some x
                        let v182 : string = _v175.Value
                        let v183 : US0 = US0_4
                        let v184 : (unit -> string) = closure12(v182)
                        let v185 : (unit -> string) = closure11(v51)
                        method2(v183, v184, v185)
                        US3_1
                | US5_0(v165) -> (* Ok *)
                    US3_0(v165)
            return v189 
            }
            |> fun x -> _v163 <- Some x
            let v190 : Async<US3> = _v163 |> Option.get
            v190 
            #endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v191 : Async<US3> = null |> unbox<Async<US3>>
            v191 
            #endif
            #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
            let v192 : Async<US3> = Unchecked.defaultof<Async<US3>>
            v192 
            #endif
            |> fun x -> _v159 <- Some x
            let v193 : Async<US3> = _v159.Value
            return! v193 
            }
            |> fun x -> _v104 <- Some x
            let v194 : Async<US3> = _v104 |> Option.get
            v194 
            #endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v195 : Async<US3> = null |> unbox<Async<US3>>
            v195 
            #endif
            #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
            let v196 : Async<US3> = Unchecked.defaultof<Async<US3>>
            v196 
            #endif
            |> fun x -> _v100 <- Some x
            let v197 : Async<US3> = _v100.Value
            v197 
            #endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v198 : Async<US3> = null |> unbox<Async<US3>>
            v198 
            #endif
            #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
            let v199 : Async<US3> = Unchecked.defaultof<Async<US3>>
            v199 
            #endif
            |> fun x -> _v96 <- Some x
            let v200 : Async<US3> = _v96.Value
            let! v200 = v200 
            let v201 : US3 = v200 
            let v204 : bool =
                match v201 with
                | US3_1 -> (* None *)
                    false
                | US3_0(v202) -> (* Some *)
                    v202
            return v204 
            }
            |> fun x -> _v56 <- Some x
            let v205 : Async<bool> = _v56 |> Option.get
            v205 
            #endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v206 : Async<bool> = null |> unbox<Async<bool>>
            v206 
            #endif
            #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
            let v207 : Async<bool> = Unchecked.defaultof<Async<bool>>
            v207 
            #endif
            |> fun x -> _v52 <- Some x
            let v208 : Async<bool> = _v52.Value
            v208
    let! v210 = v210 
    let v211 : bool = v210 
    let v212 : bool = v211 = v1
    if v212 then
        return v3 
        (*
        ()
    else
        *) else
        let v213 : int64 = v3 % 100L
        let v214 : bool = v213 = 0L
        if v214 then
            let v215 : US0 = US0_0
            let v216 : (unit -> string) = closure17()
            let v217 : (unit -> string) = closure18(v2, v3)
            method2(v215, v216, v217)
        let v218 : Async<unit> option = None
        let mutable _v218 = v218
        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v219 : Async<unit> = null |> unbox<Async<unit>>
        v219 
        #endif
        #if FABLE_COMPILER_RUST && WASM
        let v220 : Async<unit> = null |> unbox<Async<unit>>
        v220 
        #endif
        #if FABLE_COMPILER_RUST && CONTRACT
        let v221 : Async<unit> = null |> unbox<Async<unit>>
        v221 
        #endif
        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
        let v222 : (int32 -> Async<unit>) = Async.Sleep
        let v223 : Async<unit> = v222 10
        v223 
        #endif
        #if FABLE_COMPILER_TYPESCRIPT
        let v224 : Async<unit> = null |> unbox<Async<unit>>
        v224 
        #endif
        #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
        let v225 : Async<unit> = Unchecked.defaultof<Async<unit>>
        v225 
        #endif
        |> fun x -> _v218 <- Some x
        let v226 : Async<unit> = _v218.Value
        do! v226 
        let v227 : int64 = v3 + 1L
        let v228 : Async<int64> = method5(v0, v1, v2, v227)
        return! v228 
        (*
        ()
    *)
    }
    |> fun x -> _v8 <- Some x
    let v229 : Async<int64> = _v8 |> Option.get
    v229 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v230 : Async<int64> = null |> unbox<Async<int64>>
    v230 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v231 : Async<int64> = Unchecked.defaultof<Async<int64>>
    v231 
    #endif
    |> fun x -> _v4 <- Some x
    let v232 : Async<int64> = _v4.Value
    v232
and closure15 (v0 : int32 option, v1 : bool) (v2 : int32) : Async<int64> =
    let v3 : int64 = 0L
    method5(v0, v1, v2, v3)
and closure14 (v0 : int32 option) (v1 : bool) : (int32 -> Async<int64>) =
    closure15(v0, v1)
and closure13 () (v0 : int32 option) : (bool -> (int32 -> Async<int64>)) =
    closure14(v0)
and method7 (v0 : int32 option, v1 : int32) : Async<int32> =
    let v2 : Async<int32> option = None
    let mutable _v2 = v2
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : Async<int32> = null |> unbox<Async<int32>>
    v3 
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v4 : Async<int32> = null |> unbox<Async<int32>>
    v4 
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v5 : Async<int32> = null |> unbox<Async<int32>>
    v5 
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v6 : Async<int32> option = None
    let mutable _v6 = v6
    async {
    let v7 : (int32 -> US6) = method6()
    let v8 : US6 = US6_1
    let v9 : US6 = v0 |> Option.map v7 |> Option.defaultValue v8 
    let v208 : Async<bool> =
        match v9 with
        | US6_1 -> (* None *)
            let v10 : Async<bool> option = None
            let mutable _v10 = v10
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
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v14 : Async<bool> option = None
            let mutable _v14 = v14
            async {
            let v15 : Async<System.Threading.CancellationToken> = Async.CancellationToken
            let! v15 = v15 
            let v16 : System.Threading.CancellationToken = v15 
            let v17 : System.Net.Sockets.TcpClient = new System.Net.Sockets.TcpClient ()
            use v17 = v17 
            let v18 : System.Net.Sockets.TcpClient = v17 
            try
            let v19 : string = "127.0.0.1"
            let v20 : System.Threading.Tasks.ValueTask = v18.ConnectAsync (v19, v1, v16)
            let v21 : (unit -> System.Threading.Tasks.Task) = v20.AsTask
            let v22 : System.Threading.Tasks.Task = v21 ()
            let v23 : Async<unit> option = None
            let mutable _v23 = v23
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
            let v28 : Async<unit> = v27 v22
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
            |> fun x -> _v23 <- Some x
            let v31 : Async<unit> = _v23.Value
            do! v31 
            return true 
            with ex ->
            let v32 : exn = ex
            let v33 : string option = None
            let mutable _v33 = v33
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v34 : string = $"%A{v32}"
            v34 
            #endif
            #if FABLE_COMPILER_RUST && WASM
            let v35 : string = $"%A{v32}"
            v35 
            #endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let v36 : string = $"%A{v32}"
            v36 
            #endif
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v37 : string = $"{v32.GetType ()}: {v32.Message}"
            v37 
            #endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v38 : string = $"%A{v32}"
            v38 
            #endif
            #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
            let v39 : string = Unchecked.defaultof<string>
            v39 
            #endif
            |> fun x -> _v33 <- Some x
            let v40 : string = _v33.Value
            let v41 : US0 = US0_0
            let v42 : (unit -> string) = closure2(v40)
            let v43 : (unit -> string) = closure3()
            method2(v41, v42, v43)
            return false 
            (*
            let v44 : bool = *)
            }
            |> fun x -> _v14 <- Some x
            let v45 : Async<bool> = _v14 |> Option.get
            v45 
            #endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v46 : Async<bool> = null |> unbox<Async<bool>>
            v46 
            #endif
            #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
            let v47 : Async<bool> = Unchecked.defaultof<Async<bool>>
            v47 
            #endif
            |> fun x -> _v10 <- Some x
            let v48 : Async<bool> = _v10.Value
            v48
        | US6_0(v49) -> (* Some *)
            let v50 : Async<bool> option = None
            let mutable _v50 = v50
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v51 : Async<bool> = null |> unbox<Async<bool>>
            v51 
            #endif
            #if FABLE_COMPILER_RUST && WASM
            let v52 : Async<bool> = null |> unbox<Async<bool>>
            v52 
            #endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let v53 : Async<bool> = null |> unbox<Async<bool>>
            v53 
            #endif
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v54 : Async<bool> option = None
            let mutable _v54 = v54
            async {
            let v55 : Async<bool> option = None
            let mutable _v55 = v55
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
            let v60 : Async<System.Threading.CancellationToken> = Async.CancellationToken
            let! v60 = v60 
            let v61 : System.Threading.CancellationToken = v60 
            let v62 : System.Net.Sockets.TcpClient = new System.Net.Sockets.TcpClient ()
            use v62 = v62 
            let v63 : System.Net.Sockets.TcpClient = v62 
            try
            let v64 : string = "127.0.0.1"
            let v65 : System.Threading.Tasks.ValueTask = v63.ConnectAsync (v64, v1, v61)
            let v66 : (unit -> System.Threading.Tasks.Task) = v65.AsTask
            let v67 : System.Threading.Tasks.Task = v66 ()
            let v68 : Async<unit> option = None
            let mutable _v68 = v68
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v69 : Async<unit> = null |> unbox<Async<unit>>
            v69 
            #endif
            #if FABLE_COMPILER_RUST && WASM
            let v70 : Async<unit> = null |> unbox<Async<unit>>
            v70 
            #endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let v71 : Async<unit> = null |> unbox<Async<unit>>
            v71 
            #endif
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v72 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
            let v73 : Async<unit> = v72 v67
            v73 
            #endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v74 : Async<unit> = null |> unbox<Async<unit>>
            v74 
            #endif
            #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
            let v75 : Async<unit> = Unchecked.defaultof<Async<unit>>
            v75 
            #endif
            |> fun x -> _v68 <- Some x
            let v76 : Async<unit> = _v68.Value
            do! v76 
            return true 
            with ex ->
            let v77 : exn = ex
            let v78 : string option = None
            let mutable _v78 = v78
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v79 : string = $"%A{v77}"
            v79 
            #endif
            #if FABLE_COMPILER_RUST && WASM
            let v80 : string = $"%A{v77}"
            v80 
            #endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let v81 : string = $"%A{v77}"
            v81 
            #endif
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v82 : string = $"{v77.GetType ()}: {v77.Message}"
            v82 
            #endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v83 : string = $"%A{v77}"
            v83 
            #endif
            #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
            let v84 : string = Unchecked.defaultof<string>
            v84 
            #endif
            |> fun x -> _v78 <- Some x
            let v85 : string = _v78.Value
            let v86 : US0 = US0_0
            let v87 : (unit -> string) = closure2(v85)
            let v88 : (unit -> string) = closure3()
            method2(v86, v87, v88)
            return false 
            (*
            let v89 : bool = *)
            }
            |> fun x -> _v59 <- Some x
            let v90 : Async<bool> = _v59 |> Option.get
            v90 
            #endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v91 : Async<bool> = null |> unbox<Async<bool>>
            v91 
            #endif
            #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
            let v92 : Async<bool> = Unchecked.defaultof<Async<bool>>
            v92 
            #endif
            |> fun x -> _v55 <- Some x
            let v93 : Async<bool> = _v55.Value
            let v94 : Async<US3> option = None
            let mutable _v94 = v94
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v95 : Async<US3> = null |> unbox<Async<US3>>
            v95 
            #endif
            #if FABLE_COMPILER_RUST && WASM
            let v96 : Async<US3> = null |> unbox<Async<US3>>
            v96 
            #endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let v97 : Async<US3> = null |> unbox<Async<US3>>
            v97 
            #endif
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v98 : Async<US3> option = None
            let mutable _v98 = v98
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v99 : Async<US3> = null |> unbox<Async<US3>>
            v99 
            #endif
            #if FABLE_COMPILER_RUST && WASM
            let v100 : Async<US3> = null |> unbox<Async<US3>>
            v100 
            #endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let v101 : Async<US3> = null |> unbox<Async<US3>>
            v101 
            #endif
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v102 : Async<US3> option = None
            let mutable _v102 = v102
            async {
            let v103 : Async<Async<bool>> option = None
            let mutable _v103 = v103
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v104 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            v104 
            #endif
            #if FABLE_COMPILER_RUST && WASM
            let v105 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            v105 
            #endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let v106 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            v106 
            #endif
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v107 : Async<Async<bool>> = Async.StartChild (v93, v49)
            v107 
            #endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v108 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            v108 
            #endif
            #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
            let v109 : Async<Async<bool>> = Unchecked.defaultof<Async<Async<bool>>>
            v109 
            #endif
            |> fun x -> _v103 <- Some x
            let v110 : Async<Async<bool>> = _v103.Value
            let! v110 = v110 
            let v111 : Async<bool> = v110 
            let v112 : Async<Choice<bool, exn>> option = None
            let mutable _v112 = v112
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v113 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
            v113 
            #endif
            #if FABLE_COMPILER_RUST && WASM
            let v114 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
            v114 
            #endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let v115 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
            v115 
            #endif
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v116 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v117 : Async<Choice<bool, exn>> = v116 v111
            v117 
            #endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v118 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
            v118 
            #endif
            #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
            let v119 : Async<Choice<bool, exn>> = Unchecked.defaultof<Async<Choice<bool, exn>>>
            v119 
            #endif
            |> fun x -> _v112 <- Some x
            let v120 : Async<Choice<bool, exn>> = _v112.Value
            let v121 : Async<US4> option = None
            let mutable _v121 = v121
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v122 : Async<US4> = null |> unbox<Async<US4>>
            v122 
            #endif
            #if FABLE_COMPILER_RUST && WASM
            let v123 : Async<US4> = null |> unbox<Async<US4>>
            v123 
            #endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let v124 : Async<US4> = null |> unbox<Async<US4>>
            v124 
            #endif
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v125 : Async<US4> option = None
            let mutable _v125 = v125
            async {
            let! v120 = v120 
            let v126 : Choice<bool, exn> = v120 
            let v127 : US4 option = None
            let mutable _v127 = v127
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v128 : US4 = null |> unbox<US4>
            v128 
            #endif
            #if FABLE_COMPILER_RUST && WASM
            let v129 : US4 = null |> unbox<US4>
            v129 
            #endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let v130 : US4 = null |> unbox<US4>
            v130 
            #endif
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v131 : (bool -> US4) = closure8()
            let v132 : (exn -> US4) = closure9()
            let v133 : US4 = match v126 with Choice1Of2 x -> v131 x | Choice2Of2 x -> v132 x
            v133 
            #endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v134 : US4 = null |> unbox<US4>
            v134 
            #endif
            #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
            let v135 : US4 = Unchecked.defaultof<US4>
            v135 
            #endif
            |> fun x -> _v127 <- Some x
            let v136 : US4 = _v127.Value
            return v136 
            }
            |> fun x -> _v125 <- Some x
            let v137 : Async<US4> = _v125 |> Option.get
            v137 
            #endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v138 : Async<US4> = null |> unbox<Async<US4>>
            v138 
            #endif
            #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
            let v139 : Async<US4> = Unchecked.defaultof<Async<US4>>
            v139 
            #endif
            |> fun x -> _v121 <- Some x
            let v140 : Async<US4> = _v121.Value
            let v141 : Async<US5> option = None
            let mutable _v141 = v141
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v142 : Async<US5> = null |> unbox<Async<US5>>
            v142 
            #endif
            #if FABLE_COMPILER_RUST && WASM
            let v143 : Async<US5> = null |> unbox<Async<US5>>
            v143 
            #endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let v144 : Async<US5> = null |> unbox<Async<US5>>
            v144 
            #endif
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v145 : Async<US5> option = None
            let mutable _v145 = v145
            async {
            let! v140 = v140 
            let v146 : US4 = v140 
            let v152 : US5 =
                match v146 with
                | US4_0(v147) -> (* Choice1Of2 *)
                    US5_0(v147)
                | US4_1(v149) -> (* Choice2Of2 *)
                    US5_1(v149)
            return v152 
            }
            |> fun x -> _v145 <- Some x
            let v153 : Async<US5> = _v145 |> Option.get
            v153 
            #endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v154 : Async<US5> = null |> unbox<Async<US5>>
            v154 
            #endif
            #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
            let v155 : Async<US5> = Unchecked.defaultof<Async<US5>>
            v155 
            #endif
            |> fun x -> _v141 <- Some x
            let v156 : Async<US5> = _v141.Value
            let v157 : Async<US3> option = None
            let mutable _v157 = v157
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v158 : Async<US3> = null |> unbox<Async<US3>>
            v158 
            #endif
            #if FABLE_COMPILER_RUST && WASM
            let v159 : Async<US3> = null |> unbox<Async<US3>>
            v159 
            #endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let v160 : Async<US3> = null |> unbox<Async<US3>>
            v160 
            #endif
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v161 : Async<US3> option = None
            let mutable _v161 = v161
            async {
            let! v156 = v156 
            let v162 : US5 = v156 
            let v187 : US3 =
                match v162 with
                | US5_1(v165) -> (* Error *)
                    let v166 : string = $"%A{v165}"
                    let v167 : string = "System.TimeoutException"
                    let v168 : bool = v166.Contains v167
                    if v168 then
                        let v169 : US0 = US0_1
                        let v170 : (unit -> string) = closure10()
                        let v171 : (unit -> string) = closure11(v49)
                        method2(v169, v170, v171)
                        US3_1
                    else
                        let v173 : string option = None
                        let mutable _v173 = v173
                        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v174 : string = $"%A{v165}"
                        v174 
                        #endif
                        #if FABLE_COMPILER_RUST && WASM
                        let v175 : string = $"%A{v165}"
                        v175 
                        #endif
                        #if FABLE_COMPILER_RUST && CONTRACT
                        let v176 : string = $"%A{v165}"
                        v176 
                        #endif
                        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                        let v177 : string = $"{v165.GetType ()}: {v165.Message}"
                        v177 
                        #endif
                        #if FABLE_COMPILER_TYPESCRIPT
                        let v178 : string = $"%A{v165}"
                        v178 
                        #endif
                        #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
                        let v179 : string = Unchecked.defaultof<string>
                        v179 
                        #endif
                        |> fun x -> _v173 <- Some x
                        let v180 : string = _v173.Value
                        let v181 : US0 = US0_4
                        let v182 : (unit -> string) = closure12(v180)
                        let v183 : (unit -> string) = closure11(v49)
                        method2(v181, v182, v183)
                        US3_1
                | US5_0(v163) -> (* Ok *)
                    US3_0(v163)
            return v187 
            }
            |> fun x -> _v161 <- Some x
            let v188 : Async<US3> = _v161 |> Option.get
            v188 
            #endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v189 : Async<US3> = null |> unbox<Async<US3>>
            v189 
            #endif
            #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
            let v190 : Async<US3> = Unchecked.defaultof<Async<US3>>
            v190 
            #endif
            |> fun x -> _v157 <- Some x
            let v191 : Async<US3> = _v157.Value
            return! v191 
            }
            |> fun x -> _v102 <- Some x
            let v192 : Async<US3> = _v102 |> Option.get
            v192 
            #endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v193 : Async<US3> = null |> unbox<Async<US3>>
            v193 
            #endif
            #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
            let v194 : Async<US3> = Unchecked.defaultof<Async<US3>>
            v194 
            #endif
            |> fun x -> _v98 <- Some x
            let v195 : Async<US3> = _v98.Value
            v195 
            #endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v196 : Async<US3> = null |> unbox<Async<US3>>
            v196 
            #endif
            #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
            let v197 : Async<US3> = Unchecked.defaultof<Async<US3>>
            v197 
            #endif
            |> fun x -> _v94 <- Some x
            let v198 : Async<US3> = _v94.Value
            let! v198 = v198 
            let v199 : US3 = v198 
            let v202 : bool =
                match v199 with
                | US3_1 -> (* None *)
                    false
                | US3_0(v200) -> (* Some *)
                    v200
            return v202 
            }
            |> fun x -> _v54 <- Some x
            let v203 : Async<bool> = _v54 |> Option.get
            v203 
            #endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v204 : Async<bool> = null |> unbox<Async<bool>>
            v204 
            #endif
            #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
            let v205 : Async<bool> = Unchecked.defaultof<Async<bool>>
            v205 
            #endif
            |> fun x -> _v50 <- Some x
            let v206 : Async<bool> = _v50.Value
            v206
    let! v208 = v208 
    let v209 : bool = v208 
    let v210 : bool = v209 = false
    if v210 then
        return v1 
        (*
        ()
    else
        *) else
        let v211 : int32 = v1 + 1
        let v212 : Async<int32> = method7(v0, v211)
        return! v212 
        (*
        ()
    *)
    }
    |> fun x -> _v6 <- Some x
    let v213 : Async<int32> = _v6 |> Option.get
    v213 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v214 : Async<int32> = null |> unbox<Async<int32>>
    v214 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v215 : Async<int32> = Unchecked.defaultof<Async<int32>>
    v215 
    #endif
    |> fun x -> _v2 <- Some x
    let v216 : Async<int32> = _v2.Value
    v216
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
