#if FABLE_COMPILER // file_system.types
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
[<Fable.Core.Erase; Fable.Core.Emit("std::fs::FileType")>] type std_fs_FileType = class end
[<Fable.Core.Erase; Fable.Core.Emit("std::io::Error")>] type std_io_Error = class end
[<Fable.Core.Erase; Fable.Core.Emit("std::path::Path")>] type std_path_Path = class end
[<Fable.Core.Erase; Fable.Core.Emit("std::path::PathBuf")>] type std_path_PathBuf = class end
[<Fable.Core.Erase; Fable.Core.Emit("async_walkdir::DirEntry")>] type async_walkdir_DirEntry = class end
[<Fable.Core.Erase; Fable.Core.Emit("async_walkdir::Filtering")>] type async_walkdir_Filtering = class end
[<Fable.Core.Erase; Fable.Core.Emit("async_walkdir::WalkDir")>] type async_walkdir_WalkDir = class end
#endif // file_system.types
module State = let mutable trace_state = None
type IFsExistsSync = abstract existsSync: path: string -> bool
type IPathJoin = abstract join: [<System.ParamArray>] paths: string[] -> string
type IPathDirname = abstract dirname: path: string -> string
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
and [<Struct>] US4 =
    | US4_0
    | US4_1
    | US4_2
and [<Struct>] US5 =
    | US5_0
    | US5_1
    | US5_2
    | US5_3
    | US5_4
and [<Struct>] US3 =
    | US3_0 of f0_0 : US4 * f0_1 : US5
    | US3_1
and [<Struct>] US6 =
    | US6_0 of f0_0 : int64
    | US6_1 of f1_0 : exn
and [<Struct>] US7 =
    | US7_0 of f0_0 : int64
    | US7_1 of f1_0 : exn
and [<Struct>] US8 =
    | US8_0 of f0_0 : string
    | US8_1
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
and closure3 () () : string =
    let v0 : string = "file_system.delete_directory_async"
    v0
and closure5 () (v0 : string) : string =
    let v1 : string option = None
    let v2 : bool = true in let mutable _v1 = v1
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : string = null |> unbox<string>
    v3
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v4 : string = null |> unbox<string>
    v4
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v5 : string = null |> unbox<string>
    v5
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v6 : (string -> string) = System.IO.Path.GetFileName
    let v7 : string = v6 v0
    v7
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v8 : string = null |> unbox<string>
    v8
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v9 : string = Unchecked.defaultof<string>
    v9
#endif
    |> fun x -> _v1 <- Some x
    let v10 : string = _v1.Value
    v10
and closure6 () () : string =
    let v0 : string = ""
    v0
and closure4 (v0 : string, v1 : string) () : string =
    let v2 : (string -> string) = closure5()
    let v3 : (unit -> string) = closure6()
    let v4 : string = $"path: {v0 |> v2} / ex: {v1} / {v3 ()}"
    v4
and closure8 () (v0 : int64) : US2 =
    US2_0(v0)
and method4 () : (int64 -> US2) =
    closure8()
and method5 () : string =
    let v0 : string = ""
    v0
and closure7 (v0 : US0, v1 : (unit -> string), v2 : (unit -> string)) () : string =
    let v3 : (unit -> struct (Mut0 * Mut1 * Mut2 * int64 option * Mut3)) = closure0()
    if State.trace_state.IsNone then State.trace_state <- v3 () |> Some
    let struct (v4 : Mut0, v5 : Mut1, v6 : Mut2, v7 : int64 option, v8 : Mut3) = State.trace_state.Value
    let v9 : string option = None
    let v10 : bool = true in let mutable _v9 = v9
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v11 : (int64 -> US2) = method4()
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
    let v34 : string = method5()
    v34
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v35 : string = method5()
    v35
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v36 : (int64 -> US2) = method4()
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
    let v59 : string = method5()
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
    let v74 : string = v73.PadRight (7, ' ')
    let v75 : string option = None
    let v76 : bool = true in let mutable _v75 = v75
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
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    v74
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    v74
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v149 : string = Unchecked.defaultof<string>
    v149
#endif
    |> fun x -> _v75 <- Some x
    let v150 : string = _v75.Value
    let v151 : string = $"{v61} {v150} #{v62} %s{v1 ()} / %s{v2 ()}"
    let v152 : (char []) = [||]
    let v153 : string = v151.TrimStart v152
    let v154 : (char []) = [|' '; '/'|]
    let v155 : string = v153.TrimEnd v154
    v155
and method6 (v0 : US0, v1 : (unit -> string)) : unit =
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
and method3 (v0 : US0, v1 : (unit -> string), v2 : (unit -> string)) : unit =
    let v3 : (unit -> string) = closure7(v0, v1, v2)
    method6(v0, v3)
and method2 (v0 : string, v1 : int64) : Async<int64> =
    let v2 : Async<int64> option = None
    let v3 : bool = true in let mutable _v2 = v2
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v4 : Async<int64> = null |> unbox<Async<int64>>
    v4
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v5 : Async<int64> = null |> unbox<Async<int64>>
    v5
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v6 : Async<int64> = null |> unbox<Async<int64>>
    v6
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v7 : Async<int64> option = None
    let mutable _v7 = v7
    async {
    try
    let v8 : unit option = None
    let v9 : bool = true in let mutable _v8 = v8
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    null |> unbox<unit>
    ()
#endif
    #if FABLE_COMPILER_RUST && WASM
    null |> unbox<unit>
    ()
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    null |> unbox<unit>
    ()
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    System.IO.Directory.Delete (v0, true)
    ()
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    null |> unbox<unit>
    ()
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    Unchecked.defaultof<unit>
    ()
#endif
    |> fun x -> _v8 <- Some x
    _v8.Value
    return v1 
    with ex ->
    let v10 : exn = ex
    let v11 : int64 = v1 % 100L
    let v12 : bool = v11 = 0L
    if v12 then
        let v13 : string option = None
        let v14 : bool = true in let mutable _v13 = v13
        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v15 : string = $"%A{v10}"
        v15
#endif
        #if FABLE_COMPILER_RUST && WASM
        let v16 : string = $"%A{v10}"
        v16
#endif
        #if FABLE_COMPILER_RUST && CONTRACT
        let v17 : string = $"%A{v10}"
        v17
#endif
        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
        let v18 : string = $"{v10.GetType ()}: {v10.Message}"
        v18
#endif
        #if FABLE_COMPILER_TYPESCRIPT
        let v19 : string = $"%A{v10}"
        v19
#endif
        #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
        let v20 : string = Unchecked.defaultof<string>
        v20
#endif
        |> fun x -> _v13 <- Some x
        let v21 : string = _v13.Value
        let v22 : US0 = US0_1
        let v23 : (unit -> string) = closure3()
        let v24 : (unit -> string) = closure4(v0, v21)
        method3(v22, v23, v24)
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
    let v30 : (int32 -> Async<unit>) = Async.Sleep
    let v31 : Async<unit> = v30 10
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
    let v35 : int64 = v1 + 1L
    let v36 : Async<int64> = method2(v0, v35)
    return! v36 
    (*
    let v37 : int64 = *)
    }
    |> fun x -> _v7 <- Some x
    let v38 : Async<int64> = _v7 |> Option.get
    v38
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v39 : Async<int64> = null |> unbox<Async<int64>>
    v39
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v40 : Async<int64> = Unchecked.defaultof<Async<int64>>
    v40
#endif
    |> fun x -> _v2 <- Some x
    let v41 : Async<int64> = _v2.Value
    v41
and closure2 () (v0 : string) : Async<int64> =
    let v1 : Async<int64> option = None
    let v2 : bool = true in let mutable _v1 = v1
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : Async<int64> = null |> unbox<Async<int64>>
    v3
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v4 : Async<int64> = null |> unbox<Async<int64>>
    v4
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v5 : Async<int64> = null |> unbox<Async<int64>>
    v5
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v6 : int64 = 0L
    let v7 : Async<int64> = method2(v0, v6)
    v7
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v8 : Async<int64> = null |> unbox<Async<int64>>
    v8
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v9 : Async<int64> = Unchecked.defaultof<Async<int64>>
    v9
#endif
    |> fun x -> _v1 <- Some x
    let v10 : Async<int64> = _v1.Value
    v10
and closure11 () () : string =
    let v0 : string = "file_system.wait_for_file_access"
    v0
and closure12 (v0 : string, v1 : int64, v2 : string) () : string =
    let v3 : (string -> string) = closure5()
    let v4 : (unit -> string) = closure6()
    let v5 : string = $"path: {v0 |> v3} / retry: {v1} / ex: {v2} / {v4 ()}"
    v5
and method7 (v0 : string, v1 : US5, v2 : US4, v3 : int64) : Async<int64> =
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
    try
    let v10 : System.IO.FileStream option = None
    let v11 : bool = true in let mutable _v10 = v10
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v12 : System.IO.FileStream = null |> unbox<System.IO.FileStream>
    v12
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v13 : System.IO.FileStream = null |> unbox<System.IO.FileStream>
    v13
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v14 : System.IO.FileStream = null |> unbox<System.IO.FileStream>
    v14
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v15 : System.IO.FileMode = System.IO.FileMode.Open
    let v21 : System.IO.FileAccess =
        match v2 with
        | US4_0 -> (* AccessRead *)
            let v16 : System.IO.FileAccess = System.IO.FileAccess.Read
            v16
        | US4_2 -> (* AccessReadWrite *)
            let v18 : System.IO.FileAccess = System.IO.FileAccess.ReadWrite
            v18
        | US4_1 -> (* AccessWrite *)
            let v17 : System.IO.FileAccess = System.IO.FileAccess.ReadWrite
            v17
    let v31 : System.IO.FileShare =
        match v1 with
        | US5_4 -> (* ShareDelete *)
            let v26 : System.IO.FileShare = System.IO.FileShare.Delete
            v26
        | US5_0 -> (* ShareNone *)
            let v22 : System.IO.FileShare = System.IO.FileShare.None
            v22
        | US5_1 -> (* ShareRead *)
            let v23 : System.IO.FileShare = System.IO.FileShare.Read
            v23
        | US5_3 -> (* ShareReadWrite *)
            let v25 : System.IO.FileShare = System.IO.FileShare.ReadWrite
            v25
        | US5_2 -> (* ShareWrite *)
            let v24 : System.IO.FileShare = System.IO.FileShare.Write
            v24
    let v32 : System.IO.FileStream = new System.IO.FileStream (v0, v15, v21, v31)
    v32
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v33 : System.IO.FileStream = null |> unbox<System.IO.FileStream>
    v33
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v34 : System.IO.FileStream = Unchecked.defaultof<System.IO.FileStream>
    v34
#endif
    |> fun x -> _v10 <- Some x
    let v35 : System.IO.FileStream = _v10.Value
    use v35 = v35 
    let v36 : System.IO.FileStream = v35 
    return v3 
    with ex ->
    let v37 : exn = ex
    let v38 : bool = v3 > 0L
    let v41 : bool =
        if v38 then
            let v39 : int64 = v3 % 100L
            let v40 : bool = v39 = 0L
            v40
        else
            false
    if v41 then
        let v42 : string option = None
        let v43 : bool = true in let mutable _v42 = v42
        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v44 : string = $"%A{v37}"
        v44
#endif
        #if FABLE_COMPILER_RUST && WASM
        let v45 : string = $"%A{v37}"
        v45
#endif
        #if FABLE_COMPILER_RUST && CONTRACT
        let v46 : string = $"%A{v37}"
        v46
#endif
        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
        let v47 : string = $"{v37.GetType ()}: {v37.Message}"
        v47
#endif
        #if FABLE_COMPILER_TYPESCRIPT
        let v48 : string = $"%A{v37}"
        v48
#endif
        #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
        let v49 : string = Unchecked.defaultof<string>
        v49
#endif
        |> fun x -> _v42 <- Some x
        let v50 : string = _v42.Value
        let v51 : US0 = US0_1
        let v52 : (unit -> string) = closure11()
        let v53 : (unit -> string) = closure12(v0, v3, v50)
        method3(v51, v52, v53)
    let v54 : Async<unit> option = None
    let v55 : bool = true in let mutable _v54 = v54
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v56 : Async<unit> = null |> unbox<Async<unit>>
    v56
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v57 : Async<unit> = null |> unbox<Async<unit>>
    v57
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v58 : Async<unit> = null |> unbox<Async<unit>>
    v58
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v59 : (int32 -> Async<unit>) = Async.Sleep
    let v60 : Async<unit> = v59 10
    v60
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v61 : Async<unit> = null |> unbox<Async<unit>>
    v61
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v62 : Async<unit> = Unchecked.defaultof<Async<unit>>
    v62
#endif
    |> fun x -> _v54 <- Some x
    let v63 : Async<unit> = _v54.Value
    do! v63 
    let v64 : int64 = v3 + 1L
    let v65 : Async<int64> = method7(v0, v1, v2, v64)
    return! v65 
    (*
    let v66 : int64 = *)
    }
    |> fun x -> _v9 <- Some x
    let v67 : Async<int64> = _v9 |> Option.get
    v67
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v68 : Async<int64> = null |> unbox<Async<int64>>
    v68
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v69 : Async<int64> = Unchecked.defaultof<Async<int64>>
    v69
#endif
    |> fun x -> _v4 <- Some x
    let v70 : Async<int64> = _v4.Value
    v70
and closure10 (v0 : US3) (v1 : string) : Async<int64> =
    let v2 : Async<int64> option = None
    let v3 : bool = true in let mutable _v2 = v2
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v4 : Async<int64> = null |> unbox<Async<int64>>
    v4
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v5 : Async<int64> = null |> unbox<Async<int64>>
    v5
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v6 : Async<int64> = null |> unbox<Async<int64>>
    v6
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let struct (v13 : US4, v14 : US5) =
        match v0 with
        | US3_1 -> (* None *)
            let v9 : US4 = US4_2
            let v10 : US5 = US5_1
            struct (v9, v10)
        | US3_0(v7, v8) -> (* Some *)
            struct (v7, v8)
    let v15 : int64 = 0L
    let v16 : Async<int64> = method7(v1, v14, v13, v15)
    v16
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v17 : Async<int64> = null |> unbox<Async<int64>>
    v17
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v18 : Async<int64> = Unchecked.defaultof<Async<int64>>
    v18
#endif
    |> fun x -> _v2 <- Some x
    let v19 : Async<int64> = _v2.Value
    v19
and closure9 () (v0 : US3) : (string -> Async<int64>) =
    closure10(v0)
and method8 (v0 : string, v1 : int64) : Async<int64> =
    let v2 : Async<int64> option = None
    let v3 : bool = true in let mutable _v2 = v2
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v4 : Async<int64> = null |> unbox<Async<int64>>
    v4
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v5 : Async<int64> = null |> unbox<Async<int64>>
    v5
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v6 : Async<int64> = null |> unbox<Async<int64>>
    v6
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v7 : Async<int64> option = None
    let mutable _v7 = v7
    async {
    try
    let v8 : System.IO.FileStream option = None
    let v9 : bool = true in let mutable _v8 = v8
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v10 : System.IO.FileStream = null |> unbox<System.IO.FileStream>
    v10
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v11 : System.IO.FileStream = null |> unbox<System.IO.FileStream>
    v11
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v12 : System.IO.FileStream = null |> unbox<System.IO.FileStream>
    v12
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v13 : System.IO.FileMode = System.IO.FileMode.Open
    let v14 : System.IO.FileAccess = System.IO.FileAccess.Read
    let v15 : System.IO.FileShare = System.IO.FileShare.Read
    let v16 : System.IO.FileStream = new System.IO.FileStream (v0, v13, v14, v15)
    v16
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v17 : System.IO.FileStream = null |> unbox<System.IO.FileStream>
    v17
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v18 : System.IO.FileStream = Unchecked.defaultof<System.IO.FileStream>
    v18
#endif
    |> fun x -> _v8 <- Some x
    let v19 : System.IO.FileStream = _v8.Value
    use v19 = v19 
    let v20 : System.IO.FileStream = v19 
    return v1 
    with ex ->
    let v21 : exn = ex
    let v22 : bool = v1 > 0L
    let v25 : bool =
        if v22 then
            let v23 : int64 = v1 % 100L
            let v24 : bool = v23 = 0L
            v24
        else
            false
    if v25 then
        let v26 : string option = None
        let v27 : bool = true in let mutable _v26 = v26
        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v28 : string = $"%A{v21}"
        v28
#endif
        #if FABLE_COMPILER_RUST && WASM
        let v29 : string = $"%A{v21}"
        v29
#endif
        #if FABLE_COMPILER_RUST && CONTRACT
        let v30 : string = $"%A{v21}"
        v30
#endif
        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
        let v31 : string = $"{v21.GetType ()}: {v21.Message}"
        v31
#endif
        #if FABLE_COMPILER_TYPESCRIPT
        let v32 : string = $"%A{v21}"
        v32
#endif
        #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
        let v33 : string = Unchecked.defaultof<string>
        v33
#endif
        |> fun x -> _v26 <- Some x
        let v34 : string = _v26.Value
        let v35 : US0 = US0_1
        let v36 : (unit -> string) = closure11()
        let v37 : (unit -> string) = closure12(v0, v1, v34)
        method3(v35, v36, v37)
    let v38 : Async<unit> option = None
    let v39 : bool = true in let mutable _v38 = v38
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v40 : Async<unit> = null |> unbox<Async<unit>>
    v40
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v41 : Async<unit> = null |> unbox<Async<unit>>
    v41
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v42 : Async<unit> = null |> unbox<Async<unit>>
    v42
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v43 : (int32 -> Async<unit>) = Async.Sleep
    let v44 : Async<unit> = v43 10
    v44
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v45 : Async<unit> = null |> unbox<Async<unit>>
    v45
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v46 : Async<unit> = Unchecked.defaultof<Async<unit>>
    v46
#endif
    |> fun x -> _v38 <- Some x
    let v47 : Async<unit> = _v38.Value
    do! v47 
    let v48 : int64 = v1 + 1L
    let v49 : Async<int64> = method8(v0, v48)
    return! v49 
    (*
    let v50 : int64 = *)
    }
    |> fun x -> _v7 <- Some x
    let v51 : Async<int64> = _v7 |> Option.get
    v51
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v52 : Async<int64> = null |> unbox<Async<int64>>
    v52
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v53 : Async<int64> = Unchecked.defaultof<Async<int64>>
    v53
#endif
    |> fun x -> _v2 <- Some x
    let v54 : Async<int64> = _v2.Value
    v54
and closure13 () (v0 : string) : Async<int64> =
    let v1 : Async<int64> option = None
    let v2 : bool = true in let mutable _v1 = v1
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : Async<int64> = null |> unbox<Async<int64>>
    v3
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v4 : Async<int64> = null |> unbox<Async<int64>>
    v4
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v5 : Async<int64> = null |> unbox<Async<int64>>
    v5
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v6 : int64 = 0L
    let v7 : Async<int64> = method8(v0, v6)
    v7
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v8 : Async<int64> = null |> unbox<Async<int64>>
    v8
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v9 : Async<int64> = Unchecked.defaultof<Async<int64>>
    v9
#endif
    |> fun x -> _v1 <- Some x
    let v10 : Async<int64> = _v1.Value
    v10
and closure14 () (v0 : string) : Async<string> =
    let v1 : Async<string> option = None
    let v2 : bool = true in let mutable _v1 = v1
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : Async<string> = null |> unbox<Async<string>>
    v3
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v4 : Async<string> = null |> unbox<Async<string>>
    v4
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v5 : Async<string> = null |> unbox<Async<string>>
    v5
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v6 : (string -> System.Threading.Tasks.Task<string>) = System.IO.File.ReadAllTextAsync
    let v7 : System.Threading.Tasks.Task<string> = v6 v0
    let v8 : Async<string> option = None
    let v9 : bool = true in let mutable _v8 = v8
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v10 : Async<string> = null |> unbox<Async<string>>
    v10
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v11 : Async<string> = null |> unbox<Async<string>>
    v11
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v12 : Async<string> = null |> unbox<Async<string>>
    v12
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v13 : (System.Threading.Tasks.Task<string> -> Async<string>) = Async.AwaitTask
    let v14 : Async<string> = v13 v7
    v14
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v15 : Async<string> = null |> unbox<Async<string>>
    v15
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v16 : Async<string> = Unchecked.defaultof<Async<string>>
    v16
#endif
    |> fun x -> _v8 <- Some x
    let v17 : Async<string> = _v8.Value
    v17
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v18 : Async<string> = null |> unbox<Async<string>>
    v18
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v19 : Async<string> = Unchecked.defaultof<Async<string>>
    v19
#endif
    |> fun x -> _v1 <- Some x
    let v20 : Async<string> = _v1.Value
    v20
and method9 (v0 : string) : string =
    v0
and closure16 (v0 : string) (v1 : string) : Async<bool> =
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
    let v8 : bool = true in let mutable _v7 = v7
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v9 : Async<bool> = null |> unbox<Async<bool>>
    v9
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v10 : Async<bool> = null |> unbox<Async<bool>>
    v10
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v11 : Async<bool> = null |> unbox<Async<bool>>
    v11
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v12 : Async<bool> option = None
    let mutable _v12 = v12
    async {
    let v13 : bool option = None
    let v14 : bool = true in let mutable _v13 = v13
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v15 : string = method9(v0)
    let v16 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v17 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v15 v16
    let v18 : string = "String::from($0)"
    let v19 : std_string_String = Fable.Core.RustInterop.emitRustExpr v17 v18
    let v20 : string = "std::path::PathBuf::from($0)"
    let v21 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v19 v20
    let v22 : string = "$0.exists()"
    let v23 : bool = Fable.Core.RustInterop.emitRustExpr v21 v22
    let v26 : bool =
        if v23 then
            let v24 : string = "$0.is_file()"
            let v25 : bool = Fable.Core.RustInterop.emitRustExpr v21 v24
            v25
        else
            false
    v26
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v27 : bool = null |> unbox<bool>
    v27
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v28 : bool = null |> unbox<bool>
    v28
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v29 : (string -> bool) = System.IO.File.Exists
    let v30 : bool = v29 v0
    v30
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v31 : string = "fs"
    let v32 : IFsExistsSync = Fable.Core.JsInterop.importAll v31
    let v33 : string = "v32.existsSync($0)"
    let v34 : bool = Fable.Core.JsInterop.emitJsExpr v0 v33
    v34
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v35 : bool = Unchecked.defaultof<bool>
    v35
#endif
    |> fun x -> _v13 <- Some x
    let v36 : bool = _v13.Value
    let v37 : bool = v36 = false
    if v37 then
        return false 
        (*
        ()
    else
        *) else
        let v38 : Async<string> option = None
        let v39 : bool = true in let mutable _v38 = v38
        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v40 : Async<string> = null |> unbox<Async<string>>
        v40
#endif
        #if FABLE_COMPILER_RUST && WASM
        let v41 : Async<string> = null |> unbox<Async<string>>
        v41
#endif
        #if FABLE_COMPILER_RUST && CONTRACT
        let v42 : Async<string> = null |> unbox<Async<string>>
        v42
#endif
        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
        let v43 : (string -> System.Threading.Tasks.Task<string>) = System.IO.File.ReadAllTextAsync
        let v44 : System.Threading.Tasks.Task<string> = v43 v0
        let v45 : Async<string> option = None
        let v46 : bool = true in let mutable _v45 = v45
        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v47 : Async<string> = null |> unbox<Async<string>>
        v47
#endif
        #if FABLE_COMPILER_RUST && WASM
        let v48 : Async<string> = null |> unbox<Async<string>>
        v48
#endif
        #if FABLE_COMPILER_RUST && CONTRACT
        let v49 : Async<string> = null |> unbox<Async<string>>
        v49
#endif
        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
        let v50 : (System.Threading.Tasks.Task<string> -> Async<string>) = Async.AwaitTask
        let v51 : Async<string> = v50 v44
        v51
#endif
        #if FABLE_COMPILER_TYPESCRIPT
        let v52 : Async<string> = null |> unbox<Async<string>>
        v52
#endif
        #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
        let v53 : Async<string> = Unchecked.defaultof<Async<string>>
        v53
#endif
        |> fun x -> _v45 <- Some x
        let v54 : Async<string> = _v45.Value
        v54
#endif
        #if FABLE_COMPILER_TYPESCRIPT
        let v55 : Async<string> = null |> unbox<Async<string>>
        v55
#endif
        #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
        let v56 : Async<string> = Unchecked.defaultof<Async<string>>
        v56
#endif
        |> fun x -> _v38 <- Some x
        let v57 : Async<string> = _v38.Value
        let! v57 = v57 
        let v58 : string = v57 
        let v59 : bool = v1 = v58
        return v59 
        (*
        ()
    *)
    }
    |> fun x -> _v12 <- Some x
    let v60 : Async<bool> = _v12 |> Option.get
    v60
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v61 : Async<bool> = null |> unbox<Async<bool>>
    v61
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v62 : Async<bool> = Unchecked.defaultof<Async<bool>>
    v62
#endif
    |> fun x -> _v7 <- Some x
    let v63 : Async<bool> = _v7.Value
    v63
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v64 : Async<bool> = null |> unbox<Async<bool>>
    v64
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v65 : Async<bool> = Unchecked.defaultof<Async<bool>>
    v65
#endif
    |> fun x -> _v2 <- Some x
    let v66 : Async<bool> = _v2.Value
    v66
and closure15 () (v0 : string) : (string -> Async<bool>) =
    closure16(v0)
and closure18 (v0 : string) (v1 : string) : Async<unit> =
    let v2 : Async<unit> option = None
    let v3 : bool = true in let mutable _v2 = v2
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v4 : Async<unit> = null |> unbox<Async<unit>>
    v4
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v5 : Async<unit> = null |> unbox<Async<unit>>
    v5
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v6 : Async<unit> = null |> unbox<Async<unit>>
    v6
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v7 : System.Threading.Tasks.Task = System.IO.File.WriteAllTextAsync (v0, v1)
    let v8 : Async<unit> option = None
    let v9 : bool = true in let mutable _v8 = v8
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v10 : Async<unit> = null |> unbox<Async<unit>>
    v10
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v11 : Async<unit> = null |> unbox<Async<unit>>
    v11
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v12 : Async<unit> = null |> unbox<Async<unit>>
    v12
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v13 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
    let v14 : Async<unit> = v13 v7
    v14
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v15 : Async<unit> = null |> unbox<Async<unit>>
    v15
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v16 : Async<unit> = Unchecked.defaultof<Async<unit>>
    v16
#endif
    |> fun x -> _v8 <- Some x
    let v17 : Async<unit> = _v8.Value
    v17
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v18 : Async<unit> = null |> unbox<Async<unit>>
    v18
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v19 : Async<unit> = Unchecked.defaultof<Async<unit>>
    v19
#endif
    |> fun x -> _v2 <- Some x
    let v20 : Async<unit> = _v2.Value
    v20
and closure17 () (v0 : string) : (string -> Async<unit>) =
    closure18(v0)
and closure20 (v0 : string) (v1 : string) : Async<unit> =
    let v2 : Async<unit> option = None
    let v3 : bool = true in let mutable _v2 = v2
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v4 : Async<unit> = null |> unbox<Async<unit>>
    v4
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v5 : Async<unit> = null |> unbox<Async<unit>>
    v5
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v6 : Async<unit> = null |> unbox<Async<unit>>
    v6
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v7 : Async<unit> option = None
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
    let v19 : bool option = None
    let v20 : bool = true in let mutable _v19 = v19
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v21 : string = method9(v0)
    let v22 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v23 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v21 v22
    let v24 : string = "String::from($0)"
    let v25 : std_string_String = Fable.Core.RustInterop.emitRustExpr v23 v24
    let v26 : string = "std::path::PathBuf::from($0)"
    let v27 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v25 v26
    let v28 : string = "$0.exists()"
    let v29 : bool = Fable.Core.RustInterop.emitRustExpr v27 v28
    let v32 : bool =
        if v29 then
            let v30 : string = "$0.is_file()"
            let v31 : bool = Fable.Core.RustInterop.emitRustExpr v27 v30
            v31
        else
            false
    v32
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v33 : bool = null |> unbox<bool>
    v33
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v34 : bool = null |> unbox<bool>
    v34
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v35 : (string -> bool) = System.IO.File.Exists
    let v36 : bool = v35 v0
    v36
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v37 : string = "fs"
    let v38 : IFsExistsSync = Fable.Core.JsInterop.importAll v37
    let v39 : string = "v38.existsSync($0)"
    let v40 : bool = Fable.Core.JsInterop.emitJsExpr v0 v39
    v40
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v41 : bool = Unchecked.defaultof<bool>
    v41
#endif
    |> fun x -> _v19 <- Some x
    let v42 : bool = _v19.Value
    let v43 : bool = v42 = false
    if v43 then
        return false 
        (*
        ()
    else
        *) else
        let v44 : Async<string> option = None
        let v45 : bool = true in let mutable _v44 = v44
        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v46 : Async<string> = null |> unbox<Async<string>>
        v46
#endif
        #if FABLE_COMPILER_RUST && WASM
        let v47 : Async<string> = null |> unbox<Async<string>>
        v47
#endif
        #if FABLE_COMPILER_RUST && CONTRACT
        let v48 : Async<string> = null |> unbox<Async<string>>
        v48
#endif
        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
        let v49 : (string -> System.Threading.Tasks.Task<string>) = System.IO.File.ReadAllTextAsync
        let v50 : System.Threading.Tasks.Task<string> = v49 v0
        let v51 : Async<string> option = None
        let v52 : bool = true in let mutable _v51 = v51
        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v53 : Async<string> = null |> unbox<Async<string>>
        v53
#endif
        #if FABLE_COMPILER_RUST && WASM
        let v54 : Async<string> = null |> unbox<Async<string>>
        v54
#endif
        #if FABLE_COMPILER_RUST && CONTRACT
        let v55 : Async<string> = null |> unbox<Async<string>>
        v55
#endif
        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
        let v56 : (System.Threading.Tasks.Task<string> -> Async<string>) = Async.AwaitTask
        let v57 : Async<string> = v56 v50
        v57
#endif
        #if FABLE_COMPILER_TYPESCRIPT
        let v58 : Async<string> = null |> unbox<Async<string>>
        v58
#endif
        #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
        let v59 : Async<string> = Unchecked.defaultof<Async<string>>
        v59
#endif
        |> fun x -> _v51 <- Some x
        let v60 : Async<string> = _v51.Value
        v60
#endif
        #if FABLE_COMPILER_TYPESCRIPT
        let v61 : Async<string> = null |> unbox<Async<string>>
        v61
#endif
        #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
        let v62 : Async<string> = Unchecked.defaultof<Async<string>>
        v62
#endif
        |> fun x -> _v44 <- Some x
        let v63 : Async<string> = _v44.Value
        let! v63 = v63 
        let v64 : string = v63 
        let v65 : bool = v1 = v64
        return v65 
        (*
        ()
    *)
    }
    |> fun x -> _v18 <- Some x
    let v66 : Async<bool> = _v18 |> Option.get
    v66
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v67 : Async<bool> = null |> unbox<Async<bool>>
    v67
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v68 : Async<bool> = Unchecked.defaultof<Async<bool>>
    v68
#endif
    |> fun x -> _v13 <- Some x
    let v69 : Async<bool> = _v13.Value
    v69
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v70 : Async<bool> = null |> unbox<Async<bool>>
    v70
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v71 : Async<bool> = Unchecked.defaultof<Async<bool>>
    v71
#endif
    |> fun x -> _v8 <- Some x
    let v72 : Async<bool> = _v8.Value
    let! v72 = v72 
    let v73 : bool = v72 
    let v74 : bool = v73 = false
    if v74 then
        let v75 : Async<unit> option = None
        let v76 : bool = true in let mutable _v75 = v75
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
        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
        let v80 : System.Threading.Tasks.Task = System.IO.File.WriteAllTextAsync (v0, v1)
        let v81 : Async<unit> option = None
        let v82 : bool = true in let mutable _v81 = v81
        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v83 : Async<unit> = null |> unbox<Async<unit>>
        v83
#endif
        #if FABLE_COMPILER_RUST && WASM
        let v84 : Async<unit> = null |> unbox<Async<unit>>
        v84
#endif
        #if FABLE_COMPILER_RUST && CONTRACT
        let v85 : Async<unit> = null |> unbox<Async<unit>>
        v85
#endif
        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
        let v86 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
        let v87 : Async<unit> = v86 v80
        v87
#endif
        #if FABLE_COMPILER_TYPESCRIPT
        let v88 : Async<unit> = null |> unbox<Async<unit>>
        v88
#endif
        #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
        let v89 : Async<unit> = Unchecked.defaultof<Async<unit>>
        v89
#endif
        |> fun x -> _v81 <- Some x
        let v90 : Async<unit> = _v81.Value
        v90
#endif
        #if FABLE_COMPILER_TYPESCRIPT
        let v91 : Async<unit> = null |> unbox<Async<unit>>
        v91
#endif
        #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
        let v92 : Async<unit> = Unchecked.defaultof<Async<unit>>
        v92
#endif
        |> fun x -> _v75 <- Some x
        let v93 : Async<unit> = _v75.Value
        do! v93 
        ()
    }
    |> fun x -> _v7 <- Some x
    let v94 : Async<unit> = _v7 |> Option.get
    v94
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v95 : Async<unit> = null |> unbox<Async<unit>>
    v95
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v96 : Async<unit> = Unchecked.defaultof<Async<unit>>
    v96
#endif
    |> fun x -> _v2 <- Some x
    let v97 : Async<unit> = _v2.Value
    v97
and closure19 () (v0 : string) : (string -> Async<unit>) =
    closure20(v0)
and closure22 () () : string =
    let v0 : string = "delete_file_async"
    v0
and closure23 (v0 : string, v1 : exn) () : string =
    let v2 : string option = None
    let v3 : bool = true in let mutable _v2 = v2
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v4 : string = $"%A{v1}"
    v4
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v5 : string = $"%A{v1}"
    v5
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v6 : string = $"%A{v1}"
    v6
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v7 : string = $"{v1.GetType ()}: {v1.Message}"
    v7
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v8 : string = $"%A{v1}"
    v8
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v9 : string = Unchecked.defaultof<string>
    v9
#endif
    |> fun x -> _v2 <- Some x
    let v10 : string = _v2.Value
    let v11 : (string -> string) = closure5()
    let v12 : (unit -> string) = closure6()
    let v13 : string = $"path: {v0 |> v11} / ex: {v10} / {v12 ()}"
    v13
and method10 (v0 : string, v1 : int64) : Async<int64> =
    let v2 : Async<int64> option = None
    let v3 : bool = true in let mutable _v2 = v2
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v4 : Async<int64> = null |> unbox<Async<int64>>
    v4
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v5 : Async<int64> = null |> unbox<Async<int64>>
    v5
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v6 : Async<int64> = null |> unbox<Async<int64>>
    v6
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v7 : Async<int64> option = None
    let mutable _v7 = v7
    async {
    try
    let v8 : unit option = None
    let v9 : bool = true in let mutable _v8 = v8
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    null |> unbox<unit>
    ()
#endif
    #if FABLE_COMPILER_RUST && WASM
    null |> unbox<unit>
    ()
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    null |> unbox<unit>
    ()
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v10 : (string -> unit) = System.IO.File.Delete
    v10 v0
    ()
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    null |> unbox<unit>
    ()
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    Unchecked.defaultof<unit>
    ()
#endif
    |> fun x -> _v8 <- Some x
    _v8.Value
    return v1 
    with ex ->
    let v11 : exn = ex
    let v12 : int64 = v1 % 100L
    let v13 : bool = v12 = 0L
    if v13 then
        let v14 : US0 = US0_3
        let v15 : (unit -> string) = closure22()
        let v16 : (unit -> string) = closure23(v0, v11)
        method3(v14, v15, v16)
    let v17 : Async<unit> option = None
    let v18 : bool = true in let mutable _v17 = v17
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
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v22 : (int32 -> Async<unit>) = Async.Sleep
    let v23 : Async<unit> = v22 10
    v23
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v24 : Async<unit> = null |> unbox<Async<unit>>
    v24
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v25 : Async<unit> = Unchecked.defaultof<Async<unit>>
    v25
#endif
    |> fun x -> _v17 <- Some x
    let v26 : Async<unit> = _v17.Value
    do! v26 
    let v27 : int64 = v1 + 1L
    let v28 : Async<int64> = method10(v0, v27)
    return! v28 
    (*
    let v29 : int64 = *)
    }
    |> fun x -> _v7 <- Some x
    let v30 : Async<int64> = _v7 |> Option.get
    v30
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v31 : Async<int64> = null |> unbox<Async<int64>>
    v31
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v32 : Async<int64> = Unchecked.defaultof<Async<int64>>
    v32
#endif
    |> fun x -> _v2 <- Some x
    let v33 : Async<int64> = _v2.Value
    v33
and closure21 () (v0 : string) : Async<int64> =
    let v1 : Async<int64> option = None
    let v2 : bool = true in let mutable _v1 = v1
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : Async<int64> = null |> unbox<Async<int64>>
    v3
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v4 : Async<int64> = null |> unbox<Async<int64>>
    v4
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v5 : Async<int64> = null |> unbox<Async<int64>>
    v5
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v6 : int64 = 0L
    let v7 : Async<int64> = method10(v0, v6)
    v7
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v8 : Async<int64> = null |> unbox<Async<int64>>
    v8
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v9 : Async<int64> = Unchecked.defaultof<Async<int64>>
    v9
#endif
    |> fun x -> _v1 <- Some x
    let v10 : Async<int64> = _v1.Value
    v10
and closure26 () () : string =
    let v0 : string = "move_file_async"
    v0
and closure27 (v0 : string, v1 : string, v2 : exn) () : string =
    let v3 : string option = None
    let v4 : bool = true in let mutable _v3 = v3
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v5 : string = $"%A{v2}"
    v5
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v6 : string = $"%A{v2}"
    v6
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v7 : string = $"%A{v2}"
    v7
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v8 : string = $"{v2.GetType ()}: {v2.Message}"
    v8
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v9 : string = $"%A{v2}"
    v9
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v10 : string = Unchecked.defaultof<string>
    v10
#endif
    |> fun x -> _v3 <- Some x
    let v11 : string = _v3.Value
    let v12 : (string -> string) = closure5()
    let v13 : (unit -> string) = closure6()
    let v14 : string = $"old_path: {v1 |> v12} / new_path: {v0 |> v12} / ex: {v11} / {v13 ()}"
    v14
and method11 (v0 : string, v1 : string, v2 : int64) : Async<int64> =
    let v3 : Async<int64> option = None
    let v4 : bool = true in let mutable _v3 = v3
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
    try
    let v9 : unit option = None
    let v10 : bool = true in let mutable _v9 = v9
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    null |> unbox<unit>
    ()
#endif
    #if FABLE_COMPILER_RUST && WASM
    null |> unbox<unit>
    ()
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    null |> unbox<unit>
    ()
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    System.IO.File.Move (v1, v0)
    ()
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    null |> unbox<unit>
    ()
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    Unchecked.defaultof<unit>
    ()
#endif
    |> fun x -> _v9 <- Some x
    _v9.Value
    return v2 
    with ex ->
    let v11 : exn = ex
    let v12 : int64 = v2 % 100L
    let v13 : bool = v12 = 0L
    if v13 then
        let v14 : US0 = US0_3
        let v15 : (unit -> string) = closure26()
        let v16 : (unit -> string) = closure27(v0, v1, v11)
        method3(v14, v15, v16)
    let v17 : Async<unit> option = None
    let v18 : bool = true in let mutable _v17 = v17
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
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v22 : (int32 -> Async<unit>) = Async.Sleep
    let v23 : Async<unit> = v22 10
    v23
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v24 : Async<unit> = null |> unbox<Async<unit>>
    v24
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v25 : Async<unit> = Unchecked.defaultof<Async<unit>>
    v25
#endif
    |> fun x -> _v17 <- Some x
    let v26 : Async<unit> = _v17.Value
    do! v26 
    let v27 : int64 = v2 + 1L
    let v28 : Async<int64> = method11(v0, v1, v27)
    return! v28 
    (*
    *)
    }
    |> fun x -> _v8 <- Some x
    let v29 : Async<int64> = _v8 |> Option.get
    v29
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v30 : Async<int64> = null |> unbox<Async<int64>>
    v30
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v31 : Async<int64> = Unchecked.defaultof<Async<int64>>
    v31
#endif
    |> fun x -> _v3 <- Some x
    let v32 : Async<int64> = _v3.Value
    v32
and closure25 (v0 : string) (v1 : string) : Async<int64> =
    let v2 : Async<int64> option = None
    let v3 : bool = true in let mutable _v2 = v2
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v4 : Async<int64> = null |> unbox<Async<int64>>
    v4
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v5 : Async<int64> = null |> unbox<Async<int64>>
    v5
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v6 : Async<int64> = null |> unbox<Async<int64>>
    v6
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v7 : int64 = 0L
    let v8 : Async<int64> = method11(v0, v1, v7)
    v8
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v9 : Async<int64> = null |> unbox<Async<int64>>
    v9
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v10 : Async<int64> = Unchecked.defaultof<Async<int64>>
    v10
#endif
    |> fun x -> _v2 <- Some x
    let v11 : Async<int64> = _v2.Value
    v11
and closure24 () (v0 : string) : (string -> Async<int64>) =
    closure25(v0)
and closure29 () (v0 : int64) : US6 =
    US6_0(v0)
and closure30 () (v0 : exn) : US6 =
    US6_1(v0)
and closure31 () () : string =
    let v0 : string = "run_with_timeout_async"
    v0
and closure32 () () : string =
    let v0 : (unit -> string) = closure6()
    let v1 : string = $"timeout: {1000} / {v0 ()}"
    v1
and closure33 (v0 : string) () : string =
    let v1 : string = $"run_with_timeout_async** / ex: {v0}"
    v1
and closure34 () () : string =
    let v0 : string = "read_all_text_retry_async"
    v0
and method13 (v0 : int64, v1 : string) : string =
    let v2 : (unit -> string) = closure6()
    let v3 : string = $"retry: {v0} / ex: {v1} / {v2 ()}"
    v3
and closure35 (v0 : int64, v1 : string) () : string =
    method13(v0, v1)
and method12 (v0 : string, v1 : int64) : Async<string option> =
    let v2 : Async<string option> option = None
    let v3 : bool = true in let mutable _v2 = v2
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v4 : Async<string option> = null |> unbox<Async<string option>>
    v4
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v5 : Async<string option> = null |> unbox<Async<string option>>
    v5
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v6 : Async<string option> = null |> unbox<Async<string option>>
    v6
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v7 : Async<string option> option = None
    let mutable _v7 = v7
    async {
    try
    let v8 : bool = v1 > 0L
    if v8 then
        let v9 : Async<int64> option = None
        let v10 : bool = true in let mutable _v9 = v9
        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v11 : Async<int64> = null |> unbox<Async<int64>>
        v11
#endif
        #if FABLE_COMPILER_RUST && WASM
        let v12 : Async<int64> = null |> unbox<Async<int64>>
        v12
#endif
        #if FABLE_COMPILER_RUST && CONTRACT
        let v13 : Async<int64> = null |> unbox<Async<int64>>
        v13
#endif
        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
        let v14 : int64 = 0L
        let v15 : Async<int64> = method8(v0, v14)
        v15
#endif
        #if FABLE_COMPILER_TYPESCRIPT
        let v16 : Async<int64> = null |> unbox<Async<int64>>
        v16
#endif
        #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
        let v17 : Async<int64> = Unchecked.defaultof<Async<int64>>
        v17
#endif
        |> fun x -> _v9 <- Some x
        let v18 : Async<int64> = _v9.Value
        let v19 : Async<US2> option = None
        let v20 : bool = true in let mutable _v19 = v19
        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v21 : Async<US2> = null |> unbox<Async<US2>>
        v21
#endif
        #if FABLE_COMPILER_RUST && WASM
        let v22 : Async<US2> = null |> unbox<Async<US2>>
        v22
#endif
        #if FABLE_COMPILER_RUST && CONTRACT
        let v23 : Async<US2> = null |> unbox<Async<US2>>
        v23
#endif
        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
        let v24 : Async<US2> option = None
        let v25 : bool = true in let mutable _v24 = v24
        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v26 : Async<US2> = null |> unbox<Async<US2>>
        v26
#endif
        #if FABLE_COMPILER_RUST && WASM
        let v27 : Async<US2> = null |> unbox<Async<US2>>
        v27
#endif
        #if FABLE_COMPILER_RUST && CONTRACT
        let v28 : Async<US2> = null |> unbox<Async<US2>>
        v28
#endif
        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
        let v29 : Async<US2> option = None
        let mutable _v29 = v29
        async {
        let v30 : Async<Async<int64>> option = None
        let v31 : bool = true in let mutable _v30 = v30
        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v32 : Async<Async<int64>> = null |> unbox<Async<Async<int64>>>
        v32
#endif
        #if FABLE_COMPILER_RUST && WASM
        let v33 : Async<Async<int64>> = null |> unbox<Async<Async<int64>>>
        v33
#endif
        #if FABLE_COMPILER_RUST && CONTRACT
        let v34 : Async<Async<int64>> = null |> unbox<Async<Async<int64>>>
        v34
#endif
        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
        let v35 : Async<Async<int64>> = Async.StartChild (v18, 1000)
        v35
#endif
        #if FABLE_COMPILER_TYPESCRIPT
        let v36 : Async<Async<int64>> = null |> unbox<Async<Async<int64>>>
        v36
#endif
        #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
        let v37 : Async<Async<int64>> = Unchecked.defaultof<Async<Async<int64>>>
        v37
#endif
        |> fun x -> _v30 <- Some x
        let v38 : Async<Async<int64>> = _v30.Value
        let! v38 = v38 
        let v39 : Async<int64> = v38 
        let v40 : Async<Choice<int64, exn>> option = None
        let v41 : bool = true in let mutable _v40 = v40
        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v42 : Async<Choice<int64, exn>> = null |> unbox<Async<Choice<int64, exn>>>
        v42
#endif
        #if FABLE_COMPILER_RUST && WASM
        let v43 : Async<Choice<int64, exn>> = null |> unbox<Async<Choice<int64, exn>>>
        v43
#endif
        #if FABLE_COMPILER_RUST && CONTRACT
        let v44 : Async<Choice<int64, exn>> = null |> unbox<Async<Choice<int64, exn>>>
        v44
#endif
        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
        let v45 : (Async<int64> -> Async<Choice<int64, exn>>) = Async.Catch
        let v46 : Async<Choice<int64, exn>> = v45 v39
        v46
#endif
        #if FABLE_COMPILER_TYPESCRIPT
        let v47 : Async<Choice<int64, exn>> = null |> unbox<Async<Choice<int64, exn>>>
        v47
#endif
        #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
        let v48 : Async<Choice<int64, exn>> = Unchecked.defaultof<Async<Choice<int64, exn>>>
        v48
#endif
        |> fun x -> _v40 <- Some x
        let v49 : Async<Choice<int64, exn>> = _v40.Value
        let v50 : Async<US6> option = None
        let v51 : bool = true in let mutable _v50 = v50
        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v52 : Async<US6> = null |> unbox<Async<US6>>
        v52
#endif
        #if FABLE_COMPILER_RUST && WASM
        let v53 : Async<US6> = null |> unbox<Async<US6>>
        v53
#endif
        #if FABLE_COMPILER_RUST && CONTRACT
        let v54 : Async<US6> = null |> unbox<Async<US6>>
        v54
#endif
        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
        let v55 : Async<US6> option = None
        let mutable _v55 = v55
        async {
        let! v49 = v49 
        let v56 : Choice<int64, exn> = v49 
        let v57 : US6 option = None
        let v58 : bool = true in let mutable _v57 = v57
        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v59 : US6 = null |> unbox<US6>
        v59
#endif
        #if FABLE_COMPILER_RUST && WASM
        let v60 : US6 = null |> unbox<US6>
        v60
#endif
        #if FABLE_COMPILER_RUST && CONTRACT
        let v61 : US6 = null |> unbox<US6>
        v61
#endif
        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
        let v62 : (int64 -> US6) = closure29()
        let v63 : (exn -> US6) = closure30()
        let v64 : US6 = match v56 with Choice1Of2 x -> v62 x | Choice2Of2 x -> v63 x
        v64
#endif
        #if FABLE_COMPILER_TYPESCRIPT
        let v65 : US6 = null |> unbox<US6>
        v65
#endif
        #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
        let v66 : US6 = Unchecked.defaultof<US6>
        v66
#endif
        |> fun x -> _v57 <- Some x
        let v67 : US6 = _v57.Value
        return v67 
        }
        |> fun x -> _v55 <- Some x
        let v68 : Async<US6> = _v55 |> Option.get
        v68
#endif
        #if FABLE_COMPILER_TYPESCRIPT
        let v69 : Async<US6> = null |> unbox<Async<US6>>
        v69
#endif
        #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
        let v70 : Async<US6> = Unchecked.defaultof<Async<US6>>
        v70
#endif
        |> fun x -> _v50 <- Some x
        let v71 : Async<US6> = _v50.Value
        let v72 : Async<US7> option = None
        let v73 : bool = true in let mutable _v72 = v72
        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v74 : Async<US7> = null |> unbox<Async<US7>>
        v74
#endif
        #if FABLE_COMPILER_RUST && WASM
        let v75 : Async<US7> = null |> unbox<Async<US7>>
        v75
#endif
        #if FABLE_COMPILER_RUST && CONTRACT
        let v76 : Async<US7> = null |> unbox<Async<US7>>
        v76
#endif
        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
        let v77 : Async<US7> option = None
        let mutable _v77 = v77
        async {
        let! v71 = v71 
        let v78 : US6 = v71 
        let v84 : US7 =
            match v78 with
            | US6_0(v79) -> (* Choice1Of2 *)
                US7_0(v79)
            | US6_1(v81) -> (* Choice2Of2 *)
                US7_1(v81)
        return v84 
        }
        |> fun x -> _v77 <- Some x
        let v85 : Async<US7> = _v77 |> Option.get
        v85
#endif
        #if FABLE_COMPILER_TYPESCRIPT
        let v86 : Async<US7> = null |> unbox<Async<US7>>
        v86
#endif
        #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
        let v87 : Async<US7> = Unchecked.defaultof<Async<US7>>
        v87
#endif
        |> fun x -> _v72 <- Some x
        let v88 : Async<US7> = _v72.Value
        let v89 : Async<US2> option = None
        let v90 : bool = true in let mutable _v89 = v89
        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v91 : Async<US2> = null |> unbox<Async<US2>>
        v91
#endif
        #if FABLE_COMPILER_RUST && WASM
        let v92 : Async<US2> = null |> unbox<Async<US2>>
        v92
#endif
        #if FABLE_COMPILER_RUST && CONTRACT
        let v93 : Async<US2> = null |> unbox<Async<US2>>
        v93
#endif
        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
        let v94 : Async<US2> option = None
        let mutable _v94 = v94
        async {
        let! v88 = v88 
        let v95 : US7 = v88 
        let v121 : US2 =
            match v95 with
            | US7_1(v98) -> (* Error *)
                let v99 : string = $"%A{v98}"
                let v100 : string = "System.TimeoutException"
                let v101 : bool = v99.Contains v100
                if v101 then
                    let v102 : US0 = US0_1
                    let v103 : (unit -> string) = closure31()
                    let v104 : (unit -> string) = closure32()
                    method3(v102, v103, v104)
                    US2_1
                else
                    let v106 : string option = None
                    let v107 : bool = true in let mutable _v106 = v106
                    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v108 : string = $"%A{v98}"
                    v108
#endif
                    #if FABLE_COMPILER_RUST && WASM
                    let v109 : string = $"%A{v98}"
                    v109
#endif
                    #if FABLE_COMPILER_RUST && CONTRACT
                    let v110 : string = $"%A{v98}"
                    v110
#endif
                    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                    let v111 : string = $"{v98.GetType ()}: {v98.Message}"
                    v111
#endif
                    #if FABLE_COMPILER_TYPESCRIPT
                    let v112 : string = $"%A{v98}"
                    v112
#endif
                    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
                    let v113 : string = Unchecked.defaultof<string>
                    v113
#endif
                    |> fun x -> _v106 <- Some x
                    let v114 : string = _v106.Value
                    let v115 : US0 = US0_4
                    let v116 : (unit -> string) = closure33(v114)
                    let v117 : (unit -> string) = closure32()
                    method3(v115, v116, v117)
                    US2_1
            | US7_0(v96) -> (* Ok *)
                US2_0(v96)
        return v121 
        }
        |> fun x -> _v94 <- Some x
        let v122 : Async<US2> = _v94 |> Option.get
        v122
#endif
        #if FABLE_COMPILER_TYPESCRIPT
        let v123 : Async<US2> = null |> unbox<Async<US2>>
        v123
#endif
        #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
        let v124 : Async<US2> = Unchecked.defaultof<Async<US2>>
        v124
#endif
        |> fun x -> _v89 <- Some x
        let v125 : Async<US2> = _v89.Value
        return! v125 
        }
        |> fun x -> _v29 <- Some x
        let v126 : Async<US2> = _v29 |> Option.get
        v126
#endif
        #if FABLE_COMPILER_TYPESCRIPT
        let v127 : Async<US2> = null |> unbox<Async<US2>>
        v127
#endif
        #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
        let v128 : Async<US2> = Unchecked.defaultof<Async<US2>>
        v128
#endif
        |> fun x -> _v24 <- Some x
        let v129 : Async<US2> = _v24.Value
        v129
#endif
        #if FABLE_COMPILER_TYPESCRIPT
        let v130 : Async<US2> = null |> unbox<Async<US2>>
        v130
#endif
        #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
        let v131 : Async<US2> = Unchecked.defaultof<Async<US2>>
        v131
#endif
        |> fun x -> _v19 <- Some x
        let v132 : Async<US2> = _v19.Value
        let v133 : Async<unit> option = None
        let v134 : bool = true in let mutable _v133 = v133
        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v135 : Async<unit> = null |> unbox<Async<unit>>
        v135
#endif
        #if FABLE_COMPILER_RUST && WASM
        let v136 : Async<unit> = null |> unbox<Async<unit>>
        v136
#endif
        #if FABLE_COMPILER_RUST && CONTRACT
        let v137 : Async<unit> = null |> unbox<Async<unit>>
        v137
#endif
        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
        let v138 : (Async<US2> -> Async<unit>) = Async.Ignore
        let v139 : Async<unit> = v138 v132
        v139
#endif
        #if FABLE_COMPILER_TYPESCRIPT
        let v140 : Async<unit> = null |> unbox<Async<unit>>
        v140
#endif
        #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
        let v141 : Async<unit> = Unchecked.defaultof<Async<unit>>
        v141
#endif
        |> fun x -> _v133 <- Some x
        let v142 : Async<unit> = _v133.Value
        do! v142 
        ()
    let v143 : Async<string> option = None
    let v144 : bool = true in let mutable _v143 = v143
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v145 : Async<string> = null |> unbox<Async<string>>
    v145
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v146 : Async<string> = null |> unbox<Async<string>>
    v146
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v147 : Async<string> = null |> unbox<Async<string>>
    v147
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v148 : (string -> System.Threading.Tasks.Task<string>) = System.IO.File.ReadAllTextAsync
    let v149 : System.Threading.Tasks.Task<string> = v148 v0
    let v150 : Async<string> option = None
    let v151 : bool = true in let mutable _v150 = v150
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v152 : Async<string> = null |> unbox<Async<string>>
    v152
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v153 : Async<string> = null |> unbox<Async<string>>
    v153
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v154 : Async<string> = null |> unbox<Async<string>>
    v154
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v155 : (System.Threading.Tasks.Task<string> -> Async<string>) = Async.AwaitTask
    let v156 : Async<string> = v155 v149
    v156
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v157 : Async<string> = null |> unbox<Async<string>>
    v157
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v158 : Async<string> = Unchecked.defaultof<Async<string>>
    v158
#endif
    |> fun x -> _v150 <- Some x
    let v159 : Async<string> = _v150.Value
    v159
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v160 : Async<string> = null |> unbox<Async<string>>
    v160
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v161 : Async<string> = Unchecked.defaultof<Async<string>>
    v161
#endif
    |> fun x -> _v143 <- Some x
    let v162 : Async<string> = _v143.Value
    let v163 : Async<string option> option = None
    let v164 : bool = true in let mutable _v163 = v163
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v165 : Async<string option> = null |> unbox<Async<string option>>
    v165
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v166 : Async<string option> = null |> unbox<Async<string option>>
    v166
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v167 : Async<string option> = null |> unbox<Async<string option>>
    v167
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v168 : Async<string option> option = None
    let mutable _v168 = v168
    async {
    let! v162 = v162 
    let v169 : string = v162 
    let v170 : string option = Some v169 
    return v170 
    }
    |> fun x -> _v168 <- Some x
    let v171 : Async<string option> = _v168 |> Option.get
    v171
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v172 : Async<string option> = null |> unbox<Async<string option>>
    v172
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v173 : Async<string option> = Unchecked.defaultof<Async<string option>>
    v173
#endif
    |> fun x -> _v163 <- Some x
    let v174 : Async<string option> = _v163.Value
    return! v174 
    with ex ->
    let v175 : exn = ex
    let v176 : bool = v1 = 0L
    let v177 : bool = v176 <> true
    if v177 then
        let v178 : string option = None
        let v179 : bool = true in let mutable _v178 = v178
        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v180 : string = $"%A{v175}"
        v180
#endif
        #if FABLE_COMPILER_RUST && WASM
        let v181 : string = $"%A{v175}"
        v181
#endif
        #if FABLE_COMPILER_RUST && CONTRACT
        let v182 : string = $"%A{v175}"
        v182
#endif
        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
        let v183 : string = $"{v175.GetType ()}: {v175.Message}"
        v183
#endif
        #if FABLE_COMPILER_TYPESCRIPT
        let v184 : string = $"%A{v175}"
        v184
#endif
        #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
        let v185 : string = Unchecked.defaultof<string>
        v185
#endif
        |> fun x -> _v178 <- Some x
        let v186 : string = _v178.Value
        let v187 : US0 = US0_1
        let v188 : (unit -> string) = closure34()
        let v189 : (unit -> string) = closure35(v1, v186)
        method3(v187, v188, v189)
        let v190 : string option = None
        return v190 
        (*
        ()
    else
        *) else
        let v191 : int64 = v1 + 1L
        let v192 : Async<string option> = method12(v0, v191)
        return! v192 
        (*
        ()
    *)
    (*
    let v193 : string option = *)
    }
    |> fun x -> _v7 <- Some x
    let v194 : Async<string option> = _v7 |> Option.get
    v194
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v195 : Async<string option> = null |> unbox<Async<string option>>
    v195
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v196 : Async<string option> = Unchecked.defaultof<Async<string option>>
    v196
#endif
    |> fun x -> _v2 <- Some x
    let v197 : Async<string option> = _v2.Value
    v197
and closure28 () (v0 : string) : Async<string option> =
    let v1 : Async<string option> option = None
    let v2 : bool = true in let mutable _v1 = v1
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : Async<string option> = null |> unbox<Async<string option>>
    v3
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v4 : Async<string option> = null |> unbox<Async<string option>>
    v4
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v5 : Async<string option> = null |> unbox<Async<string option>>
    v5
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v6 : int64 = 0L
    let v7 : Async<string option> = method12(v0, v6)
    v7
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v8 : Async<string option> = null |> unbox<Async<string option>>
    v8
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v9 : Async<string option> = Unchecked.defaultof<Async<string option>>
    v9
#endif
    |> fun x -> _v1 <- Some x
    let v10 : Async<string option> = _v1.Value
    v10
and closure37 () () : string =
    let v0 : string option = None
    let v1 : bool = true in let mutable _v0 = v0
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = null |> unbox<string>
    v2
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v3 : string = null |> unbox<string>
    v3
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v4 : string = null |> unbox<string>
    v4
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v5 : string = System.Reflection.Assembly.GetEntryAssembly().GetName().Name
    v5
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v6 : string = null |> unbox<string>
    v6
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v7 : string = Unchecked.defaultof<string>
    v7
#endif
    |> fun x -> _v0 <- Some x
    let v8 : string = _v0.Value
    v8
and method14 (v0 : string) : string =
    v0
and method15 (v0 : string) : string =
    v0
and closure36 () () : string =
    let v0 : string option = None
    let v1 : bool = true in let mutable _v0 = v0
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = null |> unbox<string>
    v2
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v3 : string = null |> unbox<string>
    v3
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v4 : string = null |> unbox<string>
    v4
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v5 : (unit -> string) = System.IO.Path.GetTempPath
    let v6 : string = v5 ()
    let v7 : (unit -> string) = closure37()
    let v8 : string = $"!{v7 ()}"
    let v9 : string option = None
    let v10 : bool = true in let mutable _v9 = v9
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v11 : string = method9(v6)
    let v12 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v13 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v11 v12
    let v14 : string = "String::from($0)"
    let v15 : std_string_String = Fable.Core.RustInterop.emitRustExpr v13 v14
    let v16 : string = "std::path::PathBuf::from($0)"
    let v17 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v15 v16
    let v18 : string = method9(v8)
    let v19 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v20 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v18 v19
    let v21 : string = "String::from($0)"
    let v22 : std_string_String = Fable.Core.RustInterop.emitRustExpr v20 v21
    let v23 : string = "$0.join($1)"
    let v24 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr struct (v17, v22) v23
    let v25 : string = "$0.display().to_string()"
    let v26 : std_string_String = Fable.Core.RustInterop.emitRustExpr v24 v25
    let v27 : string = "fable_library_rust::String_::fromString($0)"
    let v28 : string = Fable.Core.RustInterop.emitRustExpr v26 v27
    v28
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v29 : string = null |> unbox<string>
    v29
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v30 : string = null |> unbox<string>
    v30
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v31 : string = System.IO.Path.Combine (v6, v8)
    v31
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v32 : string = "path"
    let v33 : IPathJoin = Fable.Core.JsInterop.importAll v32
    let v34 : string = method14(v6)
    let v35 : string = method15(v8)
    let v36 : string = "v33.join(v34, v35)"
    let v37 : string = Fable.Core.JsInterop.emitJsExpr () v36
    v37
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v38 : string = Unchecked.defaultof<string>
    v38
#endif
    |> fun x -> _v9 <- Some x
    let v39 : string = _v9.Value
    let v40 : System.DateTime = System.DateTime.Now
    let v41 : System.Guid = System.Guid.NewGuid ()
    let v42 : (System.Guid -> string) = _.ToString()
    let v43 : string = v42 v41
    let v44 : string = v40.ToString "yyyyMMdd-HHmm-ssff-ffff-f"
    let v45 : System.Guid = System.Guid $"{v44}{v43.[v44.Length..]}"
    let v46 : (System.Guid -> string) = _.ToString()
    let v47 : string = v46 v45
    let v48 : string option = None
    let v49 : bool = true in let mutable _v48 = v48
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v50 : string = method9(v39)
    let v51 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v52 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v50 v51
    let v53 : string = "String::from($0)"
    let v54 : std_string_String = Fable.Core.RustInterop.emitRustExpr v52 v53
    let v55 : string = "std::path::PathBuf::from($0)"
    let v56 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v54 v55
    let v57 : string = method9(v47)
    let v58 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v59 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v57 v58
    let v60 : string = "String::from($0)"
    let v61 : std_string_String = Fable.Core.RustInterop.emitRustExpr v59 v60
    let v62 : string = "$0.join($1)"
    let v63 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr struct (v56, v61) v62
    let v64 : string = "$0.display().to_string()"
    let v65 : std_string_String = Fable.Core.RustInterop.emitRustExpr v63 v64
    let v66 : string = "fable_library_rust::String_::fromString($0)"
    let v67 : string = Fable.Core.RustInterop.emitRustExpr v65 v66
    v67
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v68 : string = null |> unbox<string>
    v68
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v69 : string = null |> unbox<string>
    v69
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v70 : string = System.IO.Path.Combine (v39, v47)
    v70
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v71 : IPathJoin = Fable.Core.JsInterop.importAll v32
    let v72 : string = method14(v39)
    let v73 : string = method15(v47)
    let v74 : string = "v71.join(v72, v73)"
    let v75 : string = Fable.Core.JsInterop.emitJsExpr () v74
    v75
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v76 : string = Unchecked.defaultof<string>
    v76
#endif
    |> fun x -> _v48 <- Some x
    let v77 : string = _v48.Value
    v77
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v78 : string = null |> unbox<string>
    v78
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v79 : string = Unchecked.defaultof<string>
    v79
#endif
    |> fun x -> _v0 <- Some x
    let v80 : string = _v0.Value
    v80
and closure39 () () : string =
    let v0 : string = "file_system.create_temp_directory"
    v0
and closure40 (v0 : string, v1 : string) () : string =
    let v2 : (unit -> string) = closure6()
    let v3 : string = $"temp_folder: {v0} / result: {v1} {v2 ()}"
    v3
and closure41 (v0 : string) () : unit =
    let v1 : Async<int64> option = None
    let v2 : bool = true in let mutable _v1 = v1
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : Async<int64> = null |> unbox<Async<int64>>
    v3
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v4 : Async<int64> = null |> unbox<Async<int64>>
    v4
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v5 : Async<int64> = null |> unbox<Async<int64>>
    v5
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v6 : int64 = 0L
    let v7 : Async<int64> = method2(v0, v6)
    v7
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v8 : Async<int64> = null |> unbox<Async<int64>>
    v8
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v9 : Async<int64> = Unchecked.defaultof<Async<int64>>
    v9
#endif
    |> fun x -> _v1 <- Some x
    let v10 : Async<int64> = _v1.Value
    let v11 : Async<unit> option = None
    let v12 : bool = true in let mutable _v11 = v11
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v13 : Async<unit> = null |> unbox<Async<unit>>
    v13
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v14 : Async<unit> = null |> unbox<Async<unit>>
    v14
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v15 : Async<unit> = null |> unbox<Async<unit>>
    v15
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v16 : (Async<int64> -> Async<unit>) = Async.Ignore
    let v17 : Async<unit> = v16 v10
    v17
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v18 : Async<unit> = null |> unbox<Async<unit>>
    v18
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v19 : Async<unit> = Unchecked.defaultof<Async<unit>>
    v19
#endif
    |> fun x -> _v11 <- Some x
    let v20 : Async<unit> = _v11.Value
    let v21 : unit option = None
    let v22 : bool = true in let mutable _v21 = v21
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    null |> unbox<unit>
    ()
#endif
    #if FABLE_COMPILER_RUST && WASM
    null |> unbox<unit>
    ()
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    null |> unbox<unit>
    ()
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v23 : (Async<unit> -> unit) = Async.RunSynchronously
    v23 v20
    ()
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    null |> unbox<unit>
    ()
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    Unchecked.defaultof<unit>
    ()
#endif
    |> fun x -> _v21 <- Some x
    _v21.Value
    ()
and closure38 () () : struct (string * System.IDisposable) =
    let v0 : struct (string * System.IDisposable) option = None
    let v1 : bool = true in let mutable _v0 = v0
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let struct (v2 : string, v3 : System.IDisposable) = null |> unbox<struct (string * System.IDisposable)>
    struct (v2, v3)
#endif
    #if FABLE_COMPILER_RUST && WASM
    let struct (v4 : string, v5 : System.IDisposable) = null |> unbox<struct (string * System.IDisposable)>
    struct (v4, v5)
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let struct (v6 : string, v7 : System.IDisposable) = null |> unbox<struct (string * System.IDisposable)>
    struct (v6, v7)
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v8 : string option = None
    let v9 : bool = true in let mutable _v8 = v8
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v10 : string = null |> unbox<string>
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
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v13 : (unit -> string) = System.IO.Path.GetTempPath
    let v14 : string = v13 ()
    let v15 : (unit -> string) = closure37()
    let v16 : string = $"!{v15 ()}"
    let v17 : string option = None
    let v18 : bool = true in let mutable _v17 = v17
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v19 : string = method9(v14)
    let v20 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v21 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v19 v20
    let v22 : string = "String::from($0)"
    let v23 : std_string_String = Fable.Core.RustInterop.emitRustExpr v21 v22
    let v24 : string = "std::path::PathBuf::from($0)"
    let v25 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v23 v24
    let v26 : string = method9(v16)
    let v27 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v28 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v26 v27
    let v29 : string = "String::from($0)"
    let v30 : std_string_String = Fable.Core.RustInterop.emitRustExpr v28 v29
    let v31 : string = "$0.join($1)"
    let v32 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr struct (v25, v30) v31
    let v33 : string = "$0.display().to_string()"
    let v34 : std_string_String = Fable.Core.RustInterop.emitRustExpr v32 v33
    let v35 : string = "fable_library_rust::String_::fromString($0)"
    let v36 : string = Fable.Core.RustInterop.emitRustExpr v34 v35
    v36
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v37 : string = null |> unbox<string>
    v37
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v38 : string = null |> unbox<string>
    v38
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v39 : string = System.IO.Path.Combine (v14, v16)
    v39
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v40 : string = "path"
    let v41 : IPathJoin = Fable.Core.JsInterop.importAll v40
    let v42 : string = method14(v14)
    let v43 : string = method15(v16)
    let v44 : string = "v41.join(v42, v43)"
    let v45 : string = Fable.Core.JsInterop.emitJsExpr () v44
    v45
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v46 : string = Unchecked.defaultof<string>
    v46
#endif
    |> fun x -> _v17 <- Some x
    let v47 : string = _v17.Value
    let v48 : System.DateTime = System.DateTime.Now
    let v49 : System.Guid = System.Guid.NewGuid ()
    let v50 : (System.Guid -> string) = _.ToString()
    let v51 : string = v50 v49
    let v52 : string = v48.ToString "yyyyMMdd-HHmm-ssff-ffff-f"
    let v53 : System.Guid = System.Guid $"{v52}{v51.[v52.Length..]}"
    let v54 : (System.Guid -> string) = _.ToString()
    let v55 : string = v54 v53
    let v56 : string option = None
    let v57 : bool = true in let mutable _v56 = v56
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v58 : string = method9(v47)
    let v59 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v60 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v58 v59
    let v61 : string = "String::from($0)"
    let v62 : std_string_String = Fable.Core.RustInterop.emitRustExpr v60 v61
    let v63 : string = "std::path::PathBuf::from($0)"
    let v64 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v62 v63
    let v65 : string = method9(v55)
    let v66 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v67 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v65 v66
    let v68 : string = "String::from($0)"
    let v69 : std_string_String = Fable.Core.RustInterop.emitRustExpr v67 v68
    let v70 : string = "$0.join($1)"
    let v71 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr struct (v64, v69) v70
    let v72 : string = "$0.display().to_string()"
    let v73 : std_string_String = Fable.Core.RustInterop.emitRustExpr v71 v72
    let v74 : string = "fable_library_rust::String_::fromString($0)"
    let v75 : string = Fable.Core.RustInterop.emitRustExpr v73 v74
    v75
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v76 : string = null |> unbox<string>
    v76
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v77 : string = null |> unbox<string>
    v77
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v78 : string = System.IO.Path.Combine (v47, v55)
    v78
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v79 : IPathJoin = Fable.Core.JsInterop.importAll v40
    let v80 : string = method14(v47)
    let v81 : string = method15(v55)
    let v82 : string = "v79.join(v80, v81)"
    let v83 : string = Fable.Core.JsInterop.emitJsExpr () v82
    v83
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v84 : string = Unchecked.defaultof<string>
    v84
#endif
    |> fun x -> _v56 <- Some x
    let v85 : string = _v56.Value
    v85
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v86 : string = null |> unbox<string>
    v86
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v87 : string = Unchecked.defaultof<string>
    v87
#endif
    |> fun x -> _v8 <- Some x
    let v88 : string = _v8.Value
    let v89 : System.IO.DirectoryInfo option = None
    let v90 : bool = true in let mutable _v89 = v89
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v91 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    v91
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v92 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    v92
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v93 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    v93
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v94 : (string -> System.IO.DirectoryInfo) = System.IO.Directory.CreateDirectory
    let v95 : System.IO.DirectoryInfo = v94 v88
    v95
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v96 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    v96
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v97 : System.IO.DirectoryInfo = Unchecked.defaultof<System.IO.DirectoryInfo>
    v97
#endif
    |> fun x -> _v89 <- Some x
    let v98 : System.IO.DirectoryInfo = _v89.Value
    let v99 : bool option = None
    let v100 : bool = true in let mutable _v99 = v99
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v101 : bool = null |> unbox<bool>
    v101
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v102 : bool = null |> unbox<bool>
    v102
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v103 : bool = null |> unbox<bool>
    v103
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v104 : bool = v98.Exists
    v104
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v105 : bool = null |> unbox<bool>
    v105
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v106 : bool = Unchecked.defaultof<bool>
    v106
#endif
    |> fun x -> _v99 <- Some x
    let v107 : bool = _v99.Value
    let v108 : bool = v107 = false
    if v108 then
        let v109 : System.DateTime option = None
        let v110 : bool = true in let mutable _v109 = v109
        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v111 : System.DateTime = null |> unbox<System.DateTime>
        v111
#endif
        #if FABLE_COMPILER_RUST && WASM
        let v112 : System.DateTime = null |> unbox<System.DateTime>
        v112
#endif
        #if FABLE_COMPILER_RUST && CONTRACT
        let v113 : System.DateTime = null |> unbox<System.DateTime>
        v113
#endif
        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
        let v114 : System.DateTime = v98.CreationTime
        v114
#endif
        #if FABLE_COMPILER_TYPESCRIPT
        let v115 : System.DateTime = null |> unbox<System.DateTime>
        v115
#endif
        #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
        let v116 : System.DateTime = Unchecked.defaultof<System.DateTime>
        v116
#endif
        |> fun x -> _v109 <- Some x
        let v117 : System.DateTime = _v109.Value
        let v118 : obj = {| Exists = v107; CreationTime = v117 |}
        let v119 : string = $"%A{v118}"
        let v120 : US0 = US0_1
        let v121 : (unit -> string) = closure39()
        let v122 : (unit -> string) = closure40(v88, v119)
        method3(v120, v121, v122)
    let v123 : System.IDisposable option = None
    let v124 : bool = true in let mutable _v123 = v123
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v125 : System.IDisposable = null |> unbox<System.IDisposable>
    v125
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v126 : System.IDisposable = null |> unbox<System.IDisposable>
    v126
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v127 : System.IDisposable = null |> unbox<System.IDisposable>
    v127
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v128 : (unit -> unit) = closure41(v88)
    let v129 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v128 () }
    v129
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v130 : System.IDisposable = null |> unbox<System.IDisposable>
    v130
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v131 : System.IDisposable = Unchecked.defaultof<System.IDisposable>
    v131
#endif
    |> fun x -> _v123 <- Some x
    let v132 : System.IDisposable = _v123.Value
    struct (v88, v132)
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let struct (v133 : string, v134 : System.IDisposable) = null |> unbox<struct (string * System.IDisposable)>
    struct (v133, v134)
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let struct (v135 : string, v136 : System.IDisposable) = Unchecked.defaultof<struct (string * System.IDisposable)>
    struct (v135, v136)
#endif
    |> fun x -> _v0 <- Some x
    let struct (v137 : string, v138 : System.IDisposable) = _v0.Value
    struct (v137, v138)
and closure42 () () : string =
    let v0 : string = __SOURCE_DIRECTORY__
    v0
and closure46 () (v0 : string) : bool =
    let v1 : bool option = None
    let v2 : bool = true in let mutable _v1 = v1
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : string = method9(v0)
    let v4 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v5 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v3 v4
    let v6 : string = "String::from($0)"
    let v7 : std_string_String = Fable.Core.RustInterop.emitRustExpr v5 v6
    let v8 : string = "std::path::PathBuf::from($0)"
    let v9 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v7 v8
    let v10 : string = "$0.exists()"
    let v11 : bool = Fable.Core.RustInterop.emitRustExpr v9 v10
    let v14 : bool =
        if v11 then
            let v12 : string = "$0.is_file()"
            let v13 : bool = Fable.Core.RustInterop.emitRustExpr v9 v12
            v13
        else
            false
    v14
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v15 : bool = null |> unbox<bool>
    v15
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v16 : bool = null |> unbox<bool>
    v16
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v17 : (string -> bool) = System.IO.File.Exists
    let v18 : bool = v17 v0
    v18
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v19 : string = "fs"
    let v20 : IFsExistsSync = Fable.Core.JsInterop.importAll v19
    let v21 : string = "v20.existsSync($0)"
    let v22 : bool = Fable.Core.JsInterop.emitJsExpr v0 v21
    v22
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v23 : bool = Unchecked.defaultof<bool>
    v23
#endif
    |> fun x -> _v1 <- Some x
    let v24 : bool = _v1.Value
    v24
and closure47 () (v0 : string) : bool =
    let v1 : bool option = None
    let v2 : bool = true in let mutable _v1 = v1
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : string = method9(v0)
    let v4 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v5 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v3 v4
    let v6 : string = "String::from($0)"
    let v7 : std_string_String = Fable.Core.RustInterop.emitRustExpr v5 v6
    let v8 : string = "std::path::PathBuf::from($0)"
    let v9 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v7 v8
    let v10 : string = "$0.exists()"
    let v11 : bool = Fable.Core.RustInterop.emitRustExpr v9 v10
    let v14 : bool =
        if v11 then
            let v12 : string = "$0.is_dir()"
            let v13 : bool = Fable.Core.RustInterop.emitRustExpr v9 v12
            v13
        else
            false
    v14
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v15 : bool = null |> unbox<bool>
    v15
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v16 : bool = null |> unbox<bool>
    v16
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v17 : (string -> bool) = System.IO.Directory.Exists
    let v18 : bool = v17 v0
    v18
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v19 : string = "fs"
    let v20 : IFsExistsSync = Fable.Core.JsInterop.importAll v19
    let v21 : string = "v20.existsSync($0)"
    let v22 : bool = Fable.Core.JsInterop.emitJsExpr v0 v21
    v22
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v23 : bool = Unchecked.defaultof<bool>
    v23
#endif
    |> fun x -> _v1 <- Some x
    let v24 : bool = _v1.Value
    v24
and closure48 () (v0 : string) : string option =
    let v1 : US8 option = None
    let v2 : bool = true in let mutable _v1 = v1
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : string = method9(v0)
    let v4 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v5 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v3 v4
    let v6 : string = "String::from($0)"
    let v7 : std_string_String = Fable.Core.RustInterop.emitRustExpr v5 v6
    let v8 : string = "std::path::PathBuf::from($0)"
    let v9 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v7 v8
    let v10 : string = "$0.parent().map(std::path::PathBuf::from)"
    let v11 : std_path_PathBuf option = Fable.Core.RustInterop.emitRustExpr v9 v10
    let v12 : string = "$0?"
    let v13 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v11 v12
    let v14 : string = "$0.display().to_string()"
    let v15 : std_string_String = Fable.Core.RustInterop.emitRustExpr v13 v14
    let v16 : string = "fable_library_rust::String_::fromString($0)"
    let v17 : string = Fable.Core.RustInterop.emitRustExpr v15 v16
    let v18 : US8 = US8_0(v17)
    v18
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v19 : US8 = null |> unbox<US8>
    v19
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v20 : US8 = null |> unbox<US8>
    v20
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v21 : (string -> System.IO.DirectoryInfo) = System.IO.Directory.GetParent
    let v22 : System.IO.DirectoryInfo = v21 v0
    let v23 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    let v24 : bool = v22 = v23
    let v36 : US8 =
        if v24 then
            US8_1
        else
            let v26 : string option = None
            let v27 : bool = true in let mutable _v26 = v26
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v28 : string = null |> unbox<string>
            v28
#endif
            #if FABLE_COMPILER_RUST && WASM
            let v29 : string = null |> unbox<string>
            v29
#endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let v30 : string = null |> unbox<string>
            v30
#endif
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v31 : string = v22.FullName
            v31
#endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v32 : string = null |> unbox<string>
            v32
#endif
            #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
            let v33 : string = Unchecked.defaultof<string>
            v33
#endif
            |> fun x -> _v26 <- Some x
            let v34 : string = _v26.Value
            US8_0(v34)
    v36
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v37 : string = "path"
    let v38 : IPathDirname = Fable.Core.JsInterop.importAll v37
    let v39 : string = "v38.dirname($0)"
    let v40 : string = Fable.Core.JsInterop.emitJsExpr v0 v39
    let v41 : US8 = US8_0(v40)
    v41
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v42 : US8 = Unchecked.defaultof<US8>
    v42
#endif
    |> fun x -> _v1 <- Some x
    let v43 : US8 = _v1.Value
    match v43 with
    | US8_1 -> (* None *)
        let v46 : string option = None
        v46
    | US8_0(v44) -> (* Some *)
        let v45 : string option = Some v44 
        v45
and method17 () : (string -> string option) =
    closure48()
and closure49 () (v0 : string) : US8 =
    US8_0(v0)
and method18 () : (string -> US8) =
    closure49()
and method19 (v0 : string, v1 : bool, v2 : string, v3 : string) : string =
    let v4 : string option = None
    let v5 : bool = true in let mutable _v4 = v4
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v6 : string = method9(v3)
    let v7 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v8 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v7
    let v9 : string = "String::from($0)"
    let v10 : std_string_String = Fable.Core.RustInterop.emitRustExpr v8 v9
    let v11 : string = "std::path::PathBuf::from($0)"
    let v12 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v10 v11
    let v13 : string = method9(v0)
    let v14 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v15 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v13 v14
    let v16 : string = "String::from($0)"
    let v17 : std_string_String = Fable.Core.RustInterop.emitRustExpr v15 v16
    let v18 : string = "$0.join($1)"
    let v19 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr struct (v12, v17) v18
    let v20 : string = "$0.display().to_string()"
    let v21 : std_string_String = Fable.Core.RustInterop.emitRustExpr v19 v20
    let v22 : string = "fable_library_rust::String_::fromString($0)"
    let v23 : string = Fable.Core.RustInterop.emitRustExpr v21 v22
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
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v26 : string = System.IO.Path.Combine (v3, v0)
    v26
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v27 : string = "path"
    let v28 : IPathJoin = Fable.Core.JsInterop.importAll v27
    let v29 : string = method14(v3)
    let v30 : string = method15(v0)
    let v31 : string = "v28.join(v29, v30)"
    let v32 : string = Fable.Core.JsInterop.emitJsExpr () v31
    v32
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v33 : string = Unchecked.defaultof<string>
    v33
#endif
    |> fun x -> _v4 <- Some x
    let v34 : string = _v4.Value
    let v37 : (string -> bool) =
        if v1 then
            closure46()
        else
            closure47()
    let v38 : bool = v37 v34
    if v38 then
        v3
    else
        let v39 : (string -> string option) = method17()
        let v40 : string option = v39 v3
        let v41 : (string -> US8) = method18()
        let v42 : US8 = US8_1
        let v43 : US8 = v40 |> Option.map v41 |> Option.defaultValue v42 
        match v43 with
        | US8_1 -> (* None *)
            let v46 : string = $"""No parent for {if v1 then "file" else "dir"} '{v0}' at '{v2}' (until '{v3}')"""
            failwith<string> v46
        | US8_0(v44) -> (* Some *)
            method19(v0, v1, v2, v44)
and method16 (v0 : string, v1 : bool, v2 : string) : string =
    let v3 : string option = None
    let v4 : bool = true in let mutable _v3 = v3
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v5 : string = method9(v2)
    let v6 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v7 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v6
    let v8 : string = "String::from($0)"
    let v9 : std_string_String = Fable.Core.RustInterop.emitRustExpr v7 v8
    let v10 : string = "std::path::PathBuf::from($0)"
    let v11 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v9 v10
    let v12 : string = method9(v0)
    let v13 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v14 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v12 v13
    let v15 : string = "String::from($0)"
    let v16 : std_string_String = Fable.Core.RustInterop.emitRustExpr v14 v15
    let v17 : string = "$0.join($1)"
    let v18 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr struct (v11, v16) v17
    let v19 : string = "$0.display().to_string()"
    let v20 : std_string_String = Fable.Core.RustInterop.emitRustExpr v18 v19
    let v21 : string = "fable_library_rust::String_::fromString($0)"
    let v22 : string = Fable.Core.RustInterop.emitRustExpr v20 v21
    v22
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v23 : string = null |> unbox<string>
    v23
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v24 : string = null |> unbox<string>
    v24
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v25 : string = System.IO.Path.Combine (v2, v0)
    v25
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v26 : string = "path"
    let v27 : IPathJoin = Fable.Core.JsInterop.importAll v26
    let v28 : string = method14(v2)
    let v29 : string = method15(v0)
    let v30 : string = "v27.join(v28, v29)"
    let v31 : string = Fable.Core.JsInterop.emitJsExpr () v30
    v31
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v32 : string = Unchecked.defaultof<string>
    v32
#endif
    |> fun x -> _v3 <- Some x
    let v33 : string = _v3.Value
    let v36 : (string -> bool) =
        if v1 then
            closure46()
        else
            closure47()
    let v37 : bool = v36 v33
    if v37 then
        v2
    else
        let v38 : (string -> string option) = method17()
        let v39 : string option = v38 v2
        let v40 : (string -> US8) = method18()
        let v41 : US8 = US8_1
        let v42 : US8 = v39 |> Option.map v40 |> Option.defaultValue v41 
        match v42 with
        | US8_1 -> (* None *)
            let v45 : string = $"""No parent for {if v1 then "file" else "dir"} '{v0}' at '{v2}' (until '{v2}')"""
            failwith<string> v45
        | US8_0(v43) -> (* Some *)
            method19(v0, v1, v2, v43)
and closure45 (v0 : string, v1 : bool) (v2 : string) : string =
    method16(v0, v1, v2)
and closure44 (v0 : string) (v1 : bool) : (string -> string) =
    closure45(v0, v1)
and closure43 () (v0 : string) : (bool -> (string -> string)) =
    closure44(v0)
and closure50 () (v0 : string) : string =
    let v1 : bool option = None
    let v2 : bool = true in let mutable _v1 = v1
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : bool = null |> unbox<bool>
    v3
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v4 : bool = null |> unbox<bool>
    v4
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v5 : bool = null |> unbox<bool>
    v5
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v6 : System.Runtime.InteropServices.OSPlatform = System.Runtime.InteropServices.OSPlatform.Windows
    let v7 : (System.Runtime.InteropServices.OSPlatform -> bool) = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform
    let v8 : bool = v7 v6
    v8
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v9 : bool = null |> unbox<bool>
    v9
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v10 : bool = Unchecked.defaultof<bool>
    v10
#endif
    |> fun x -> _v1 <- Some x
    let v11 : bool = _v1.Value
    let v12 : bool = v11 = false
    if v12 then
        v0
    else
        let v13 : string = $"{v0.[0] |> System.Char.ToLower}{v0.[1..]}"
        let v14 : string = "\\"
        let v15 : string = "/"
        let v16 : string = v13.Replace (v14, v15)
        v16
and closure51 () (v0 : string) : string =
    let v1 : (char []) = [|'/'|]
    let v2 : string = v0.TrimStart v1
    let v3 : string = $"file:///{v2}"
    v3
and method20 () : string =
    let v0 : string = "polyglot"
    v0
and method21 () : string =
    let v0 : string = ".paket"
    v0
and method22 () : string =
    let v0 : string = "polyglot"
    v0
and method23 () : string =
    let v0 : string = ".paket"
    v0
and method25 (v0 : string, v1 : string, v2 : string) : string =
    let v3 : string option = None
    let v4 : bool = true in let mutable _v3 = v3
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v5 : string = method9(v2)
    let v6 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v7 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v6
    let v8 : string = "String::from($0)"
    let v9 : std_string_String = Fable.Core.RustInterop.emitRustExpr v7 v8
    let v10 : string = "std::path::PathBuf::from($0)"
    let v11 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v9 v10
    let v12 : string = method9(v0)
    let v13 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v14 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v12 v13
    let v15 : string = "String::from($0)"
    let v16 : std_string_String = Fable.Core.RustInterop.emitRustExpr v14 v15
    let v17 : string = "$0.join($1)"
    let v18 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr struct (v11, v16) v17
    let v19 : string = "$0.display().to_string()"
    let v20 : std_string_String = Fable.Core.RustInterop.emitRustExpr v18 v19
    let v21 : string = "fable_library_rust::String_::fromString($0)"
    let v22 : string = Fable.Core.RustInterop.emitRustExpr v20 v21
    v22
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v23 : string = null |> unbox<string>
    v23
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v24 : string = null |> unbox<string>
    v24
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v25 : string = System.IO.Path.Combine (v2, v0)
    v25
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v26 : string = "path"
    let v27 : IPathJoin = Fable.Core.JsInterop.importAll v26
    let v28 : string = method14(v2)
    let v29 : string = method15(v0)
    let v30 : string = "v27.join(v28, v29)"
    let v31 : string = Fable.Core.JsInterop.emitJsExpr () v30
    v31
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v32 : string = Unchecked.defaultof<string>
    v32
#endif
    |> fun x -> _v3 <- Some x
    let v33 : string = _v3.Value
    let v34 : bool option = None
    let v35 : bool = true in let mutable _v34 = v34
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v36 : string = method9(v33)
    let v37 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v38 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v36 v37
    let v39 : string = "String::from($0)"
    let v40 : std_string_String = Fable.Core.RustInterop.emitRustExpr v38 v39
    let v41 : string = "std::path::PathBuf::from($0)"
    let v42 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v40 v41
    let v43 : string = "$0.exists()"
    let v44 : bool = Fable.Core.RustInterop.emitRustExpr v42 v43
    let v47 : bool =
        if v44 then
            let v45 : string = "$0.is_dir()"
            let v46 : bool = Fable.Core.RustInterop.emitRustExpr v42 v45
            v46
        else
            false
    v47
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v48 : bool = null |> unbox<bool>
    v48
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v49 : bool = null |> unbox<bool>
    v49
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v50 : (string -> bool) = System.IO.Directory.Exists
    let v51 : bool = v50 v33
    v51
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v52 : string = "fs"
    let v53 : IFsExistsSync = Fable.Core.JsInterop.importAll v52
    let v54 : string = "v53.existsSync($0)"
    let v55 : bool = Fable.Core.JsInterop.emitJsExpr v33 v54
    v55
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v56 : bool = Unchecked.defaultof<bool>
    v56
#endif
    |> fun x -> _v34 <- Some x
    let v57 : bool = _v34.Value
    if v57 then
        v2
    else
        let v58 : (string -> string option) = method17()
        let v59 : string option = v58 v2
        let v60 : (string -> US8) = method18()
        let v61 : US8 = US8_1
        let v62 : US8 = v59 |> Option.map v60 |> Option.defaultValue v61 
        match v62 with
        | US8_1 -> (* None *)
            let v65 : string = $"""No parent for {if false then "file" else "dir"} '{v0}' at '{v1}' (until '{v2}')"""
            failwith<string> v65
        | US8_0(v63) -> (* Some *)
            method25(v0, v1, v63)
and method24 (v0 : string, v1 : string) : string =
    let v2 : string option = None
    let v3 : bool = true in let mutable _v2 = v2
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v4 : string = method9(v1)
    let v5 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v6 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v4 v5
    let v7 : string = "String::from($0)"
    let v8 : std_string_String = Fable.Core.RustInterop.emitRustExpr v6 v7
    let v9 : string = "std::path::PathBuf::from($0)"
    let v10 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v8 v9
    let v11 : string = method9(v0)
    let v12 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v13 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v11 v12
    let v14 : string = "String::from($0)"
    let v15 : std_string_String = Fable.Core.RustInterop.emitRustExpr v13 v14
    let v16 : string = "$0.join($1)"
    let v17 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr struct (v10, v15) v16
    let v18 : string = "$0.display().to_string()"
    let v19 : std_string_String = Fable.Core.RustInterop.emitRustExpr v17 v18
    let v20 : string = "fable_library_rust::String_::fromString($0)"
    let v21 : string = Fable.Core.RustInterop.emitRustExpr v19 v20
    v21
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v22 : string = null |> unbox<string>
    v22
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v23 : string = null |> unbox<string>
    v23
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v24 : string = System.IO.Path.Combine (v1, v0)
    v24
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v25 : string = "path"
    let v26 : IPathJoin = Fable.Core.JsInterop.importAll v25
    let v27 : string = method14(v1)
    let v28 : string = method15(v0)
    let v29 : string = "v26.join(v27, v28)"
    let v30 : string = Fable.Core.JsInterop.emitJsExpr () v29
    v30
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v31 : string = Unchecked.defaultof<string>
    v31
#endif
    |> fun x -> _v2 <- Some x
    let v32 : string = _v2.Value
    let v33 : bool option = None
    let v34 : bool = true in let mutable _v33 = v33
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v35 : string = method9(v32)
    let v36 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v37 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v35 v36
    let v38 : string = "String::from($0)"
    let v39 : std_string_String = Fable.Core.RustInterop.emitRustExpr v37 v38
    let v40 : string = "std::path::PathBuf::from($0)"
    let v41 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v39 v40
    let v42 : string = "$0.exists()"
    let v43 : bool = Fable.Core.RustInterop.emitRustExpr v41 v42
    let v46 : bool =
        if v43 then
            let v44 : string = "$0.is_dir()"
            let v45 : bool = Fable.Core.RustInterop.emitRustExpr v41 v44
            v45
        else
            false
    v46
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v47 : bool = null |> unbox<bool>
    v47
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v48 : bool = null |> unbox<bool>
    v48
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v49 : (string -> bool) = System.IO.Directory.Exists
    let v50 : bool = v49 v32
    v50
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v51 : string = "fs"
    let v52 : IFsExistsSync = Fable.Core.JsInterop.importAll v51
    let v53 : string = "v52.existsSync($0)"
    let v54 : bool = Fable.Core.JsInterop.emitJsExpr v32 v53
    v54
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v55 : bool = Unchecked.defaultof<bool>
    v55
#endif
    |> fun x -> _v33 <- Some x
    let v56 : bool = _v33.Value
    if v56 then
        v1
    else
        let v57 : (string -> string option) = method17()
        let v58 : string option = v57 v1
        let v59 : (string -> US8) = method18()
        let v60 : US8 = US8_1
        let v61 : US8 = v58 |> Option.map v59 |> Option.defaultValue v60 
        match v61 with
        | US8_1 -> (* None *)
            let v64 : string = $"""No parent for {if false then "file" else "dir"} '{v0}' at '{v1}' (until '{v1}')"""
            failwith<string> v64
        | US8_0(v62) -> (* Some *)
            method25(v0, v1, v62)
and method26 () : string =
    let v0 : string = "polyglot"
    v0
and closure52 () () : string =
    let v0 : string = __SOURCE_DIRECTORY__
    let v1 : string option = None
    let v2 : bool = true in let mutable _v1 = v1
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : string = method20()
    let v4 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v5 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v3 v4
    let v6 : string = "String::from($0)"
    let v7 : std_string_String = Fable.Core.RustInterop.emitRustExpr v5 v6
    let v8 : string = "std::path::PathBuf::from($0)"
    let v9 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v7 v8
    let v10 : string = method21()
    let v11 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v12 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v10 v11
    let v13 : string = "String::from($0)"
    let v14 : std_string_String = Fable.Core.RustInterop.emitRustExpr v12 v13
    let v15 : string = "$0.join($1)"
    let v16 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr struct (v9, v14) v15
    let v17 : string = "$0.display().to_string()"
    let v18 : std_string_String = Fable.Core.RustInterop.emitRustExpr v16 v17
    let v19 : string = "fable_library_rust::String_::fromString($0)"
    let v20 : string = Fable.Core.RustInterop.emitRustExpr v18 v19
    v20
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v21 : string = null |> unbox<string>
    v21
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v22 : string = null |> unbox<string>
    v22
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v23 : string = "polyglot"
    let v24 : string = ".paket"
    let v25 : string = System.IO.Path.Combine (v23, v24)
    v25
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v26 : string = "path"
    let v27 : IPathJoin = Fable.Core.JsInterop.importAll v26
    let v28 : string = method22()
    let v29 : string = method23()
    let v30 : string = "v27.join(v28, v29)"
    let v31 : string = Fable.Core.JsInterop.emitJsExpr () v30
    v31
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v32 : string = Unchecked.defaultof<string>
    v32
#endif
    |> fun x -> _v1 <- Some x
    let v33 : string = _v1.Value
    let v34 : string = method24(v33, v0)
    let v35 : string option = None
    let v36 : bool = true in let mutable _v35 = v35
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v37 : string = method9(v34)
    let v38 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v39 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v37 v38
    let v40 : string = "String::from($0)"
    let v41 : std_string_String = Fable.Core.RustInterop.emitRustExpr v39 v40
    let v42 : string = "std::path::PathBuf::from($0)"
    let v43 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v41 v42
    let v44 : string = method20()
    let v45 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v46 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v44 v45
    let v47 : string = "String::from($0)"
    let v48 : std_string_String = Fable.Core.RustInterop.emitRustExpr v46 v47
    let v49 : string = "$0.join($1)"
    let v50 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr struct (v43, v48) v49
    let v51 : string = "$0.display().to_string()"
    let v52 : std_string_String = Fable.Core.RustInterop.emitRustExpr v50 v51
    let v53 : string = "fable_library_rust::String_::fromString($0)"
    let v54 : string = Fable.Core.RustInterop.emitRustExpr v52 v53
    v54
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v55 : string = null |> unbox<string>
    v55
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v56 : string = null |> unbox<string>
    v56
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v57 : string = System.IO.Path.Combine (v34, v23)
    v57
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v58 : IPathJoin = Fable.Core.JsInterop.importAll v26
    let v59 : string = method14(v34)
    let v60 : string = method26()
    let v61 : string = "v58.join(v59, v60)"
    let v62 : string = Fable.Core.JsInterop.emitJsExpr () v61
    v62
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v63 : string = Unchecked.defaultof<string>
    v63
#endif
    |> fun x -> _v35 <- Some x
    let v64 : string = _v35.Value
    v64
and method28 () : string =
    let v0 : string = "target/polyglot/trace"
    v0
and method29 () : string =
    let v0 : string = "target/polyglot/trace"
    v0
and method27 (v0 : string) : unit =
    let v1 : unit option = None
    let v2 : bool = true in let mutable _v1 = v1
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    ()
#endif
    #if FABLE_COMPILER_RUST && WASM
    ()
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    ()
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    try
    let v3 : string option = None
    let v4 : bool = true in let mutable _v3 = v3
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v5 : string = null |> unbox<string>
    v5
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v6 : string = null |> unbox<string>
    v6
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v7 : string = null |> unbox<string>
    v7
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v8 : string = System.Reflection.Assembly.GetEntryAssembly().GetName().Name
    v8
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v9 : string = null |> unbox<string>
    v9
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v10 : string = Unchecked.defaultof<string>
    v10
#endif
    |> fun x -> _v3 <- Some x
    let v11 : string = _v3.Value
    let v12 : System.DateTime = System.DateTime.Now
    let v13 : System.Guid = System.Guid.NewGuid ()
    let v14 : (System.Guid -> string) = _.ToString()
    let v15 : string = v14 v13
    let v16 : string = v12.ToString "yyyyMMdd-HHmm-ssff-ffff-f"
    let v17 : System.Guid = System.Guid $"{v16}{v15.[v16.Length..]}"
    let v18 : string = $"{v11}_{v17}.txt"
    let v19 : string = __SOURCE_DIRECTORY__
    let v20 : string option = None
    let v21 : bool = true in let mutable _v20 = v20
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v22 : string = method20()
    let v23 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v24 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v22 v23
    let v25 : string = "String::from($0)"
    let v26 : std_string_String = Fable.Core.RustInterop.emitRustExpr v24 v25
    let v27 : string = "std::path::PathBuf::from($0)"
    let v28 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v26 v27
    let v29 : string = method21()
    let v30 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v31 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v29 v30
    let v32 : string = "String::from($0)"
    let v33 : std_string_String = Fable.Core.RustInterop.emitRustExpr v31 v32
    let v34 : string = "$0.join($1)"
    let v35 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr struct (v28, v33) v34
    let v36 : string = "$0.display().to_string()"
    let v37 : std_string_String = Fable.Core.RustInterop.emitRustExpr v35 v36
    let v38 : string = "fable_library_rust::String_::fromString($0)"
    let v39 : string = Fable.Core.RustInterop.emitRustExpr v37 v38
    v39
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v40 : string = null |> unbox<string>
    v40
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v41 : string = null |> unbox<string>
    v41
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v42 : string = "polyglot"
    let v43 : string = ".paket"
    let v44 : string = System.IO.Path.Combine (v42, v43)
    v44
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v45 : string = "path"
    let v46 : IPathJoin = Fable.Core.JsInterop.importAll v45
    let v47 : string = method22()
    let v48 : string = method23()
    let v49 : string = "v46.join(v47, v48)"
    let v50 : string = Fable.Core.JsInterop.emitJsExpr () v49
    v50
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v51 : string = Unchecked.defaultof<string>
    v51
#endif
    |> fun x -> _v20 <- Some x
    let v52 : string = _v20.Value
    let v53 : string = method24(v52, v19)
    let v54 : string option = None
    let v55 : bool = true in let mutable _v54 = v54
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v56 : string = method9(v53)
    let v57 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v58 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v56 v57
    let v59 : string = "String::from($0)"
    let v60 : std_string_String = Fable.Core.RustInterop.emitRustExpr v58 v59
    let v61 : string = "std::path::PathBuf::from($0)"
    let v62 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v60 v61
    let v63 : string = method20()
    let v64 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v65 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v63 v64
    let v66 : string = "String::from($0)"
    let v67 : std_string_String = Fable.Core.RustInterop.emitRustExpr v65 v66
    let v68 : string = "$0.join($1)"
    let v69 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr struct (v62, v67) v68
    let v70 : string = "$0.display().to_string()"
    let v71 : std_string_String = Fable.Core.RustInterop.emitRustExpr v69 v70
    let v72 : string = "fable_library_rust::String_::fromString($0)"
    let v73 : string = Fable.Core.RustInterop.emitRustExpr v71 v72
    v73
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v74 : string = null |> unbox<string>
    v74
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v75 : string = null |> unbox<string>
    v75
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v76 : string = System.IO.Path.Combine (v53, v42)
    v76
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v77 : IPathJoin = Fable.Core.JsInterop.importAll v45
    let v78 : string = method14(v53)
    let v79 : string = method26()
    let v80 : string = "v77.join(v78, v79)"
    let v81 : string = Fable.Core.JsInterop.emitJsExpr () v80
    v81
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v82 : string = Unchecked.defaultof<string>
    v82
#endif
    |> fun x -> _v54 <- Some x
    let v83 : string = _v54.Value
    let v84 : string option = None
    let v85 : bool = true in let mutable _v84 = v84
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v86 : string = method9(v83)
    let v87 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v88 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v86 v87
    let v89 : string = "String::from($0)"
    let v90 : std_string_String = Fable.Core.RustInterop.emitRustExpr v88 v89
    let v91 : string = "std::path::PathBuf::from($0)"
    let v92 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v90 v91
    let v93 : string = method28()
    let v94 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v95 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v93 v94
    let v96 : string = "String::from($0)"
    let v97 : std_string_String = Fable.Core.RustInterop.emitRustExpr v95 v96
    let v98 : string = "$0.join($1)"
    let v99 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr struct (v92, v97) v98
    let v100 : string = "$0.display().to_string()"
    let v101 : std_string_String = Fable.Core.RustInterop.emitRustExpr v99 v100
    let v102 : string = "fable_library_rust::String_::fromString($0)"
    let v103 : string = Fable.Core.RustInterop.emitRustExpr v101 v102
    v103
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v104 : string = null |> unbox<string>
    v104
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v105 : string = null |> unbox<string>
    v105
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v106 : string = "target/polyglot/trace"
    let v107 : string = System.IO.Path.Combine (v83, v106)
    v107
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v108 : IPathJoin = Fable.Core.JsInterop.importAll v45
    let v109 : string = method14(v83)
    let v110 : string = method29()
    let v111 : string = "v108.join(v109, v110)"
    let v112 : string = Fable.Core.JsInterop.emitJsExpr () v111
    v112
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v113 : string = Unchecked.defaultof<string>
    v113
#endif
    |> fun x -> _v84 <- Some x
    let v114 : string = _v84.Value
    let v115 : System.IO.DirectoryInfo option = None
    let v116 : bool = true in let mutable _v115 = v115
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v117 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    v117
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v118 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    v118
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v119 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    v119
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v120 : (string -> System.IO.DirectoryInfo) = System.IO.Directory.CreateDirectory
    let v121 : System.IO.DirectoryInfo = v120 v114
    v121
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v122 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    v122
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v123 : System.IO.DirectoryInfo = Unchecked.defaultof<System.IO.DirectoryInfo>
    v123
#endif
    |> fun x -> _v115 <- Some x
    let v124 : System.IO.DirectoryInfo = _v115.Value
    let v125 : string option = None
    let v126 : bool = true in let mutable _v125 = v125
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v127 : string = method9(v114)
    let v128 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v129 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v127 v128
    let v130 : string = "String::from($0)"
    let v131 : std_string_String = Fable.Core.RustInterop.emitRustExpr v129 v130
    let v132 : string = "std::path::PathBuf::from($0)"
    let v133 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v131 v132
    let v134 : string = method9(v18)
    let v135 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v136 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v134 v135
    let v137 : string = "String::from($0)"
    let v138 : std_string_String = Fable.Core.RustInterop.emitRustExpr v136 v137
    let v139 : string = "$0.join($1)"
    let v140 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr struct (v133, v138) v139
    let v141 : string = "$0.display().to_string()"
    let v142 : std_string_String = Fable.Core.RustInterop.emitRustExpr v140 v141
    let v143 : string = "fable_library_rust::String_::fromString($0)"
    let v144 : string = Fable.Core.RustInterop.emitRustExpr v142 v143
    v144
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v145 : string = null |> unbox<string>
    v145
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v146 : string = null |> unbox<string>
    v146
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v147 : string = System.IO.Path.Combine (v114, v18)
    v147
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v148 : IPathJoin = Fable.Core.JsInterop.importAll v45
    let v149 : string = method14(v114)
    let v150 : string = method15(v18)
    let v151 : string = "v148.join(v149, v150)"
    let v152 : string = Fable.Core.JsInterop.emitJsExpr () v151
    v152
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v153 : string = Unchecked.defaultof<string>
    v153
#endif
    |> fun x -> _v125 <- Some x
    let v154 : string = _v125.Value
    let v155 : Async<unit> option = None
    let v156 : bool = true in let mutable _v155 = v155
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v157 : Async<unit> = null |> unbox<Async<unit>>
    v157
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v158 : Async<unit> = null |> unbox<Async<unit>>
    v158
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v159 : Async<unit> = null |> unbox<Async<unit>>
    v159
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v160 : System.Threading.Tasks.Task = System.IO.File.WriteAllTextAsync (v154, v0)
    let v161 : Async<unit> option = None
    let v162 : bool = true in let mutable _v161 = v161
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v163 : Async<unit> = null |> unbox<Async<unit>>
    v163
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v164 : Async<unit> = null |> unbox<Async<unit>>
    v164
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v165 : Async<unit> = null |> unbox<Async<unit>>
    v165
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v166 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
    let v167 : Async<unit> = v166 v160
    v167
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v168 : Async<unit> = null |> unbox<Async<unit>>
    v168
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v169 : Async<unit> = Unchecked.defaultof<Async<unit>>
    v169
#endif
    |> fun x -> _v161 <- Some x
    let v170 : Async<unit> = _v161.Value
    v170
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v171 : Async<unit> = null |> unbox<Async<unit>>
    v171
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v172 : Async<unit> = Unchecked.defaultof<Async<unit>>
    v172
#endif
    |> fun x -> _v155 <- Some x
    let v173 : Async<unit> = _v155.Value
    let v174 : unit option = None
    let v175 : bool = true in let mutable _v174 = v174
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    null |> unbox<unit>
    ()
#endif
    #if FABLE_COMPILER_RUST && WASM
    null |> unbox<unit>
    ()
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    null |> unbox<unit>
    ()
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v176 : (Async<unit> -> unit) = Async.RunSynchronously
    v176 v173
    ()
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    null |> unbox<unit>
    ()
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    Unchecked.defaultof<unit>
    ()
#endif
    |> fun x -> _v174 <- Some x
    _v174.Value
    with ex ->
    let v177 : exn = ex
    let v178 : string = $"file_system.trace_file / ex: %A{v177}"
    method27(v178)
    (*
    *)
    ()
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    ()
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    Unchecked.defaultof<unit>
    ()
#endif
    |> fun x -> _v1 <- Some x
    _v1.Value
    ()
and closure54 () (v0 : string) : unit =
    method27(v0)
and closure53 () (v0 : bool) : unit =
    let v1 : (unit -> struct (Mut0 * Mut1 * Mut2 * int64 option * Mut3)) = closure0()
    if State.trace_state.IsNone then State.trace_state <- v1 () |> Some
    let struct (v2 : Mut0, v3 : Mut1, v4 : Mut2, v5 : int64 option, v6 : Mut3) = State.trace_state.Value
    let v9 : (string -> unit) =
        if v0 then
            closure54()
        else
            closure1()
    v6.l0 <- v9
    ()
and closure56 (v0 : string) (v1 : string) : string =
    let v2 : string option = None
    let v3 : bool = true in let mutable _v2 = v2
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v4 : string = method9(v0)
    let v5 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v6 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v4 v5
    let v7 : string = "String::from($0)"
    let v8 : std_string_String = Fable.Core.RustInterop.emitRustExpr v6 v7
    let v9 : string = "std::path::PathBuf::from($0)"
    let v10 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v8 v9
    let v11 : string = method9(v1)
    let v12 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v13 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v11 v12
    let v14 : string = "String::from($0)"
    let v15 : std_string_String = Fable.Core.RustInterop.emitRustExpr v13 v14
    let v16 : string = "$0.join($1)"
    let v17 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr struct (v10, v15) v16
    let v18 : string = "$0.display().to_string()"
    let v19 : std_string_String = Fable.Core.RustInterop.emitRustExpr v17 v18
    let v20 : string = "fable_library_rust::String_::fromString($0)"
    let v21 : string = Fable.Core.RustInterop.emitRustExpr v19 v20
    v21
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v22 : string = null |> unbox<string>
    v22
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v23 : string = null |> unbox<string>
    v23
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v24 : string = System.IO.Path.Combine (v0, v1)
    v24
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v25 : string = "path"
    let v26 : IPathJoin = Fable.Core.JsInterop.importAll v25
    let v27 : string = method14(v0)
    let v28 : string = method15(v1)
    let v29 : string = "v26.join(v27, v28)"
    let v30 : string = Fable.Core.JsInterop.emitJsExpr () v29
    v30
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v31 : string = Unchecked.defaultof<string>
    v31
#endif
    |> fun x -> _v2 <- Some x
    let v32 : string = _v2.Value
    v32
and closure55 () (v0 : string) : (string -> string) =
    closure56(v0)
let v0 : (unit -> struct (Mut0 * Mut1 * Mut2 * int64 option * Mut3)) = closure0()
if State.trace_state.IsNone then State.trace_state <- v0 () |> Some
let v1 : (string -> Async<int64>) = closure2()
let delete_directory_async x = v1 x
let v2 : (US3 -> (string -> Async<int64>)) = closure9()
let wait_for_file_access x = v2 x
let v3 : (string -> Async<int64>) = closure13()
let wait_for_file_access_read x = v3 x
let v4 : (string -> Async<string>) = closure14()
let read_all_text_async x = v4 x
let v5 : (string -> (string -> Async<bool>)) = closure15()
let file_exists_content x = v5 x
let v6 : (string -> (string -> Async<unit>)) = closure17()
let write_all_text_async x = v6 x
let v7 : (string -> (string -> Async<unit>)) = closure19()
let write_all_text_exists x = v7 x
let v8 : (string -> Async<int64>) = closure21()
let delete_file_async x = v8 x
let v9 : (string -> (string -> Async<int64>)) = closure24()
let move_file_async x = v9 x
let v10 : (string -> Async<string option>) = closure28()
let read_all_text_retry_async x = v10 x
let v11 : (unit -> string) = closure36()
let create_temp_directory_name () = v11 ()
let v12 : (unit -> struct (string * System.IDisposable)) = closure38()
let create_temp_directory () = v12 ()
let v13 : (unit -> string) = closure42()
let get_source_directory () = v13 ()
let v14 : (string -> (bool -> (string -> string))) = closure43()
let find_parent x = v14 x
let v15 : (string -> string) = closure50()
let normalize_path x = v15 x
let v16 : (string -> string) = closure51()
let new_file_uri x = v16 x
let v17 : (unit -> string) = closure52()
let get_repository_root () = v17 ()
let v18 : (bool -> unit) = closure53()
let init_trace_file x = v18 x
let v19 : (string -> (string -> string)) = closure55()
let (</>) x = v19 x
()
