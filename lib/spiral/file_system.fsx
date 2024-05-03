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
[<Fable.Core.Erase; Fable.Core.Emit("chrono::DateTime<$0>")>]
#endif
type chrono_DateTime<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("chrono::Local")>]
#endif
type chrono_Local = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("chrono::NaiveDateTime")>]
#endif
type chrono_NaiveDateTime = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("chrono::Utc")>]
#endif
type chrono_Utc = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::time::Duration")>]
#endif
type std_time_Duration = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("async_std::io::BufReader<$0>")>]
#endif
type async_std_io_BufReader<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::io::BufReader<$0>")>]
#endif
type std_io_BufReader<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::io::Error")>]
#endif
type std_io_Error = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::io::Lines<$0>")>]
#endif
type std_io_Lines<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::fs::File")>]
#endif
type std_fs_File = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::fs::FileType")>]
#endif
type std_fs_FileType = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::path::Display")>]
#endif
type std_path_Display = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::path::Path")>]
#endif
type std_path_Path = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::path::PathBuf")>]
#endif
type std_path_PathBuf = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("async_walkdir::DirEntry")>]
#endif
type async_walkdir_DirEntry = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("async_walkdir::Filtering")>]
#endif
type async_walkdir_Filtering = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("async_walkdir::WalkDir")>]
#endif
type async_walkdir_WalkDir = class end
module State = let mutable trace_state = None
type IFsExistsSync = abstract existsSync: path: string -> bool
type IPathJoin = abstract join: [<System.ParamArray>] paths: string[] -> string
type Disposable (f : unit -> unit) = interface System.IDisposable with member _.Dispose () = f ()
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
    | US8_0 of f0_0 : chrono_DateTime<chrono_Utc>
    | US8_1
and [<Struct>] US9 =
    | US9_0 of f0_0 : string
    | US9_1
and [<Struct>] US10 =
    | US10_0
    | US10_1 of f1_0 : std_string_String
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
and method3 (v0 : string) : string =
    v0
and method4 (v0 : string) : string =
    v0
and closure3 () () : string =
    let v0 : string = "file_system.delete_directory_async"
    v0
and closure5 () (v0 : string) : string =
    let v1 : string option = None
    let v2 : bool = true in let mutable _v1 = v1
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : string = method4(v0)
    let v4 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v5 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v3 v4
    let v6 : string = "String::from($0)"
    let v7 : std_string_String = Fable.Core.RustInterop.emitRustExpr v5 v6
    let v8 : string = "std::path::PathBuf::from($0)"
    let v9 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v7 v8
    let v10 : string = "$0.file_name()"
    let v11 : Ref<std_ffi_OsStr> option = Fable.Core.RustInterop.emitRustExpr v9 v10
    let v12 : string = "$0.unwrap()"
    let v13 : Ref<std_ffi_OsStr> = Fable.Core.RustInterop.emitRustExpr v11 v12
    let v14 : string = "$0.to_os_string()"
    let v15 : std_ffi_OsString = Fable.Core.RustInterop.emitRustExpr v13 v14
    let v16 : string = "$0.to_str()"
    let v17 : Ref<Str> option = Fable.Core.RustInterop.emitRustExpr v15 v16
    let v18 : string = "$0.unwrap()"
    let v19 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v17 v18
    let v20 : string = "String::from($0)"
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
    
#if FABLE_COMPILER_TYPESCRIPT
    let v26 : string = null |> unbox<string>
    v26
#endif
    
#if FABLE_COMPILER_PYTHON
    let v27 : string = null |> unbox<string>
    v27
#endif
    
#else
    let v28 : (string -> string) = System.IO.Path.GetFileName
    let v29 : string = v28 v0
    v29
#endif
    |> fun x -> _v1 <- Some x
    let v30 : string = _v1.Value
    v30
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
and method6 () : (int64 -> US2) =
    closure8()
and method7 () : string =
    let v0 : string = ""
    v0
and closure7 (v0 : US0, v1 : (unit -> string), v2 : (unit -> string)) () : string =
    let v3 : (unit -> struct (Mut0 * Mut1 * Mut2 * int64 option * Mut3)) = closure0()
    if State.trace_state.IsNone then State.trace_state <- v3 () |> Some
    let struct (v4 : Mut0, v5 : Mut1, v6 : Mut2, v7 : int64 option, v8 : Mut3) = State.trace_state.Value
    let v9 : string option = None
    let v10 : bool = true in let mutable _v9 = v9
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v11 : (int64 -> US2) = method6()
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
    let v34 : string = method7()
    v34
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v35 : string = method7()
    v35
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v36 : string = method7()
    v36
#endif
    
#if FABLE_COMPILER_PYTHON
    let v37 : string = method7()
    v37
#endif
    
#else
    let v38 : (int64 -> US2) = method6()
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
and method8 (v0 : US0, v1 : (unit -> string)) : unit =
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
and method5 (v0 : US0, v1 : (unit -> string), v2 : (unit -> string)) : unit =
    let v3 : (unit -> string) = closure7(v0, v1, v2)
    method8(v0, v3)
and method2 (v0 : string, v1 : int64) : Async<int64> =
    let v2 : Async<int64> option = None
    let v3 : bool = true in let mutable _v2 = v2
    
#if FABLE_COMPILER || WASM || CONTRACT
    
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
    
#if FABLE_COMPILER_TYPESCRIPT
    let v7 : Async<int64> = null |> unbox<Async<int64>>
    v7
#endif
    
#if FABLE_COMPILER_PYTHON
    let v8 : Async<int64> = null |> unbox<Async<int64>>
    v8
#endif
    
#else
    let v9 : Async<int64> option = None
    let mutable _v9 = v9
    async {
    try
    let v10 : unit option = None
    let v11 : bool = true in let mutable _v10 = v10
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v12 : string = method3(v0)
    let v13 : bool option = None
    let v14 : bool = true in let mutable _v13 = v13
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v15 : string = method4(v12)
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
            let v24 : string = "$0.is_dir()"
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
    
#if FABLE_COMPILER_TYPESCRIPT
    let v29 : string = "fs"
    let v30 : IFsExistsSync = Fable.Core.JsInterop.importAll v29
    let v31 : string = "$0.existsSync($1)"
    let v32 : bool = Fable.Core.JsInterop.emitJsExpr struct (v30, v12) v31
    v32
#endif
    
#if FABLE_COMPILER_PYTHON
    let v33 : bool = null |> unbox<bool>
    v33
#endif
    
#else
    let v34 : (string -> bool) = System.IO.Directory.Exists
    let v35 : bool = v34 v12
    v35
#endif
    |> fun x -> _v13 <- Some x
    let v36 : bool = _v13.Value
    if v36 then
        let v37 : string = "std::fs::remove_dir_all(&*$0).unwrap()"
        Fable.Core.RustInterop.emitRustExpr v12 v37
        ()
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
    
#if FABLE_COMPILER_TYPESCRIPT
    null |> unbox<unit>
    ()
#endif
    
#if FABLE_COMPILER_PYTHON
    null |> unbox<unit>
    ()
#endif
    
#else
    System.IO.Directory.Delete (v0, true)
    ()
#endif
    |> fun x -> _v10 <- Some x
    _v10.Value
    return v1 
    with ex ->
    let v38 : exn = ex
    let v39 : int64 = v1 % 100L
    let v40 : bool = v39 = 0L
    if v40 then
        let v41 : string option = None
        let v42 : bool = true in let mutable _v41 = v41
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v43 : string = $"%A{v38}"
        v43
#endif
        
#if FABLE_COMPILER_RUST && WASM
        let v44 : string = $"%A{v38}"
        v44
#endif
        
#if FABLE_COMPILER_RUST && CONTRACT
        let v45 : string = $"%A{v38}"
        v45
#endif
        
#if FABLE_COMPILER_TYPESCRIPT
        let v46 : string = $"%A{v38}"
        v46
#endif
        
#if FABLE_COMPILER_PYTHON
        let v47 : string = $"%A{v38}"
        v47
#endif
        
#else
        let v48 : string = $"{v38.GetType ()}: {v38.Message}"
        v48
#endif
        |> fun x -> _v41 <- Some x
        let v49 : string = _v41.Value
        let v50 : US0 = US0_1
        let v51 : (unit -> string) = closure3()
        let v52 : (unit -> string) = closure4(v0, v49)
        method5(v50, v51, v52)
    let v53 : Async<unit> option = None
    let v54 : bool = true in let mutable _v53 = v53
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v55 : Async<unit> = null |> unbox<Async<unit>>
    v55
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v56 : Async<unit> = null |> unbox<Async<unit>>
    v56
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v57 : Async<unit> = null |> unbox<Async<unit>>
    v57
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v58 : Async<unit> = null |> unbox<Async<unit>>
    v58
#endif
    
#if FABLE_COMPILER_PYTHON
    let v59 : Async<unit> = null |> unbox<Async<unit>>
    v59
#endif
    
#else
    let v60 : (int32 -> Async<unit>) = Async.Sleep
    let v61 : Async<unit> = v60 10
    v61
#endif
    |> fun x -> _v53 <- Some x
    let v62 : Async<unit> = _v53.Value
    do! v62 
    let v63 : int64 = v1 + 1L
    let v64 : Async<int64> = method2(v0, v63)
    return! v64 
    (*
    let v65 : int64 = *)
    }
    |> fun x -> _v9 <- Some x
    let v66 : Async<int64> = _v9 |> Option.get
    v66
#endif
    |> fun x -> _v2 <- Some x
    let v67 : Async<int64> = _v2.Value
    v67
and closure2 () (v0 : string) : Async<int64> =
    let v1 : Async<int64> option = None
    let v2 : bool = true in let mutable _v1 = v1
    
#if FABLE_COMPILER || WASM || CONTRACT
    
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
    
#if FABLE_COMPILER_TYPESCRIPT
    let v6 : Async<int64> = null |> unbox<Async<int64>>
    v6
#endif
    
#if FABLE_COMPILER_PYTHON
    let v7 : Async<int64> = null |> unbox<Async<int64>>
    v7
#endif
    
#else
    let v8 : int64 = 0L
    let v9 : Async<int64> = method2(v0, v8)
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
and method9 (v0 : string, v1 : US5, v2 : US4, v3 : int64) : Async<int64> =
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
    try
    let v12 : System.IO.FileStream option = None
    let v13 : bool = true in let mutable _v12 = v12
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v14 : System.IO.FileStream = null |> unbox<System.IO.FileStream>
    v14
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v15 : System.IO.FileStream = null |> unbox<System.IO.FileStream>
    v15
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v16 : System.IO.FileStream = null |> unbox<System.IO.FileStream>
    v16
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v17 : System.IO.FileStream = null |> unbox<System.IO.FileStream>
    v17
#endif
    
#if FABLE_COMPILER_PYTHON
    let v18 : System.IO.FileStream = null |> unbox<System.IO.FileStream>
    v18
#endif
    
#else
    let v19 : System.IO.FileMode = System.IO.FileMode.Open
    let v25 : System.IO.FileAccess =
        match v2 with
        | US4_0 -> (* AccessRead *)
            let v20 : System.IO.FileAccess = System.IO.FileAccess.Read
            v20
        | US4_2 -> (* AccessReadWrite *)
            let v22 : System.IO.FileAccess = System.IO.FileAccess.ReadWrite
            v22
        | US4_1 -> (* AccessWrite *)
            let v21 : System.IO.FileAccess = System.IO.FileAccess.ReadWrite
            v21
    let v35 : System.IO.FileShare =
        match v1 with
        | US5_4 -> (* ShareDelete *)
            let v30 : System.IO.FileShare = System.IO.FileShare.Delete
            v30
        | US5_0 -> (* ShareNone *)
            let v26 : System.IO.FileShare = System.IO.FileShare.None
            v26
        | US5_1 -> (* ShareRead *)
            let v27 : System.IO.FileShare = System.IO.FileShare.Read
            v27
        | US5_3 -> (* ShareReadWrite *)
            let v29 : System.IO.FileShare = System.IO.FileShare.ReadWrite
            v29
        | US5_2 -> (* ShareWrite *)
            let v28 : System.IO.FileShare = System.IO.FileShare.Write
            v28
    let v36 : System.IO.FileStream = new System.IO.FileStream (v0, v19, v25, v35)
    v36
#endif
    |> fun x -> _v12 <- Some x
    let v37 : System.IO.FileStream = _v12.Value
    use v37 = v37 
    let v38 : System.IO.FileStream = v37 
    return v3 
    with ex ->
    let v39 : exn = ex
    let v40 : bool = v3 > 0L
    let v43 : bool =
        if v40 then
            let v41 : int64 = v3 % 100L
            let v42 : bool = v41 = 0L
            v42
        else
            false
    if v43 then
        let v44 : string option = None
        let v45 : bool = true in let mutable _v44 = v44
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v46 : string = $"%A{v39}"
        v46
#endif
        
#if FABLE_COMPILER_RUST && WASM
        let v47 : string = $"%A{v39}"
        v47
#endif
        
#if FABLE_COMPILER_RUST && CONTRACT
        let v48 : string = $"%A{v39}"
        v48
#endif
        
#if FABLE_COMPILER_TYPESCRIPT
        let v49 : string = $"%A{v39}"
        v49
#endif
        
#if FABLE_COMPILER_PYTHON
        let v50 : string = $"%A{v39}"
        v50
#endif
        
#else
        let v51 : string = $"{v39.GetType ()}: {v39.Message}"
        v51
#endif
        |> fun x -> _v44 <- Some x
        let v52 : string = _v44.Value
        let v53 : US0 = US0_1
        let v54 : (unit -> string) = closure11()
        let v55 : (unit -> string) = closure12(v0, v3, v52)
        method5(v53, v54, v55)
    let v56 : Async<unit> option = None
    let v57 : bool = true in let mutable _v56 = v56
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v58 : Async<unit> = null |> unbox<Async<unit>>
    v58
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v59 : Async<unit> = null |> unbox<Async<unit>>
    v59
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v60 : Async<unit> = null |> unbox<Async<unit>>
    v60
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v61 : Async<unit> = null |> unbox<Async<unit>>
    v61
#endif
    
#if FABLE_COMPILER_PYTHON
    let v62 : Async<unit> = null |> unbox<Async<unit>>
    v62
#endif
    
#else
    let v63 : (int32 -> Async<unit>) = Async.Sleep
    let v64 : Async<unit> = v63 10
    v64
#endif
    |> fun x -> _v56 <- Some x
    let v65 : Async<unit> = _v56.Value
    do! v65 
    let v66 : int64 = v3 + 1L
    let v67 : Async<int64> = method9(v0, v1, v2, v66)
    return! v67 
    (*
    let v68 : int64 = *)
    }
    |> fun x -> _v11 <- Some x
    let v69 : Async<int64> = _v11 |> Option.get
    v69
#endif
    |> fun x -> _v4 <- Some x
    let v70 : Async<int64> = _v4.Value
    v70
and closure10 (v0 : US3) (v1 : string) : Async<int64> =
    let v2 : Async<int64> option = None
    let v3 : bool = true in let mutable _v2 = v2
    
#if FABLE_COMPILER || WASM || CONTRACT
    
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
    
#if FABLE_COMPILER_TYPESCRIPT
    let v7 : Async<int64> = null |> unbox<Async<int64>>
    v7
#endif
    
#if FABLE_COMPILER_PYTHON
    let v8 : Async<int64> = null |> unbox<Async<int64>>
    v8
#endif
    
#else
    let struct (v15 : US4, v16 : US5) =
        match v0 with
        | US3_1 -> (* None *)
            let v11 : US4 = US4_2
            let v12 : US5 = US5_1
            struct (v11, v12)
        | US3_0(v9, v10) -> (* Some *)
            struct (v9, v10)
    let v17 : int64 = 0L
    let v18 : Async<int64> = method9(v1, v16, v15, v17)
    v18
#endif
    |> fun x -> _v2 <- Some x
    let v19 : Async<int64> = _v2.Value
    v19
and closure9 () (v0 : US3) : (string -> Async<int64>) =
    closure10(v0)
and method10 (v0 : string, v1 : int64) : Async<int64> =
    let v2 : Async<int64> option = None
    let v3 : bool = true in let mutable _v2 = v2
    
#if FABLE_COMPILER || WASM || CONTRACT
    
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
    
#if FABLE_COMPILER_TYPESCRIPT
    let v7 : Async<int64> = null |> unbox<Async<int64>>
    v7
#endif
    
#if FABLE_COMPILER_PYTHON
    let v8 : Async<int64> = null |> unbox<Async<int64>>
    v8
#endif
    
#else
    let v9 : Async<int64> option = None
    let mutable _v9 = v9
    async {
    try
    let v10 : System.IO.FileStream option = None
    let v11 : bool = true in let mutable _v10 = v10
    
#if FABLE_COMPILER || WASM || CONTRACT
    
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
    
#if FABLE_COMPILER_TYPESCRIPT
    let v15 : System.IO.FileStream = null |> unbox<System.IO.FileStream>
    v15
#endif
    
#if FABLE_COMPILER_PYTHON
    let v16 : System.IO.FileStream = null |> unbox<System.IO.FileStream>
    v16
#endif
    
#else
    let v17 : System.IO.FileMode = System.IO.FileMode.Open
    let v18 : System.IO.FileAccess = System.IO.FileAccess.Read
    let v19 : System.IO.FileShare = System.IO.FileShare.Read
    let v20 : System.IO.FileStream = new System.IO.FileStream (v0, v17, v18, v19)
    v20
#endif
    |> fun x -> _v10 <- Some x
    let v21 : System.IO.FileStream = _v10.Value
    use v21 = v21 
    let v22 : System.IO.FileStream = v21 
    return v1 
    with ex ->
    let v23 : exn = ex
    let v24 : bool = v1 > 0L
    let v27 : bool =
        if v24 then
            let v25 : int64 = v1 % 100L
            let v26 : bool = v25 = 0L
            v26
        else
            false
    if v27 then
        let v28 : string option = None
        let v29 : bool = true in let mutable _v28 = v28
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v30 : string = $"%A{v23}"
        v30
#endif
        
#if FABLE_COMPILER_RUST && WASM
        let v31 : string = $"%A{v23}"
        v31
#endif
        
#if FABLE_COMPILER_RUST && CONTRACT
        let v32 : string = $"%A{v23}"
        v32
#endif
        
#if FABLE_COMPILER_TYPESCRIPT
        let v33 : string = $"%A{v23}"
        v33
#endif
        
#if FABLE_COMPILER_PYTHON
        let v34 : string = $"%A{v23}"
        v34
#endif
        
#else
        let v35 : string = $"{v23.GetType ()}: {v23.Message}"
        v35
#endif
        |> fun x -> _v28 <- Some x
        let v36 : string = _v28.Value
        let v37 : US0 = US0_1
        let v38 : (unit -> string) = closure11()
        let v39 : (unit -> string) = closure12(v0, v1, v36)
        method5(v37, v38, v39)
    let v40 : Async<unit> option = None
    let v41 : bool = true in let mutable _v40 = v40
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v42 : Async<unit> = null |> unbox<Async<unit>>
    v42
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v43 : Async<unit> = null |> unbox<Async<unit>>
    v43
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v44 : Async<unit> = null |> unbox<Async<unit>>
    v44
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v45 : Async<unit> = null |> unbox<Async<unit>>
    v45
#endif
    
#if FABLE_COMPILER_PYTHON
    let v46 : Async<unit> = null |> unbox<Async<unit>>
    v46
#endif
    
#else
    let v47 : (int32 -> Async<unit>) = Async.Sleep
    let v48 : Async<unit> = v47 10
    v48
#endif
    |> fun x -> _v40 <- Some x
    let v49 : Async<unit> = _v40.Value
    do! v49 
    let v50 : int64 = v1 + 1L
    let v51 : Async<int64> = method10(v0, v50)
    return! v51 
    (*
    let v52 : int64 = *)
    }
    |> fun x -> _v9 <- Some x
    let v53 : Async<int64> = _v9 |> Option.get
    v53
#endif
    |> fun x -> _v2 <- Some x
    let v54 : Async<int64> = _v2.Value
    v54
and closure13 () (v0 : string) : Async<int64> =
    let v1 : Async<int64> option = None
    let v2 : bool = true in let mutable _v1 = v1
    
#if FABLE_COMPILER || WASM || CONTRACT
    
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
    
#if FABLE_COMPILER_TYPESCRIPT
    let v6 : Async<int64> = null |> unbox<Async<int64>>
    v6
#endif
    
#if FABLE_COMPILER_PYTHON
    let v7 : Async<int64> = null |> unbox<Async<int64>>
    v7
#endif
    
#else
    let v8 : int64 = 0L
    let v9 : Async<int64> = method10(v0, v8)
    v9
#endif
    |> fun x -> _v1 <- Some x
    let v10 : Async<int64> = _v1.Value
    v10
and closure14 () (v0 : string) : Async<string> =
    let v1 : Async<string> option = None
    let v2 : bool = true in let mutable _v1 = v1
    
#if FABLE_COMPILER || WASM || CONTRACT
    
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
    
#if FABLE_COMPILER_TYPESCRIPT
    let v6 : Async<string> = null |> unbox<Async<string>>
    v6
#endif
    
#if FABLE_COMPILER_PYTHON
    let v7 : Async<string> = null |> unbox<Async<string>>
    v7
#endif
    
#else
    let v8 : (string -> System.Threading.Tasks.Task<string>) = System.IO.File.ReadAllTextAsync
    let v9 : System.Threading.Tasks.Task<string> = v8 v0
    let v10 : Async<string> option = None
    let v11 : bool = true in let mutable _v10 = v10
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v12 : Async<string> = null |> unbox<Async<string>>
    v12
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v13 : Async<string> = null |> unbox<Async<string>>
    v13
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v14 : Async<string> = null |> unbox<Async<string>>
    v14
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v15 : Async<string> = null |> unbox<Async<string>>
    v15
#endif
    
#if FABLE_COMPILER_PYTHON
    let v16 : Async<string> = null |> unbox<Async<string>>
    v16
#endif
    
#else
    let v17 : (System.Threading.Tasks.Task<string> -> Async<string>) = Async.AwaitTask
    let v18 : Async<string> = v17 v9
    v18
#endif
    |> fun x -> _v10 <- Some x
    let v19 : Async<string> = _v10.Value
    v19
#endif
    |> fun x -> _v1 <- Some x
    let v20 : Async<string> = _v1.Value
    v20
and closure16 (v0 : string) (v1 : string) : Async<bool> =
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
    let v10 : bool = true in let mutable _v9 = v9
    
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
    let v17 : bool option = None
    let v18 : bool = true in let mutable _v17 = v17
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v19 : string = method4(v0)
    let v20 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v21 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v19 v20
    let v22 : string = "String::from($0)"
    let v23 : std_string_String = Fable.Core.RustInterop.emitRustExpr v21 v22
    let v24 : string = "std::path::PathBuf::from($0)"
    let v25 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v23 v24
    let v26 : string = "$0.exists()"
    let v27 : bool = Fable.Core.RustInterop.emitRustExpr v25 v26
    let v30 : bool =
        if v27 then
            let v28 : string = "$0.is_file()"
            let v29 : bool = Fable.Core.RustInterop.emitRustExpr v25 v28
            v29
        else
            false
    v30
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v31 : bool = null |> unbox<bool>
    v31
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v32 : bool = null |> unbox<bool>
    v32
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v33 : string = "fs"
    let v34 : IFsExistsSync = Fable.Core.JsInterop.importAll v33
    let v35 : string = "$0.existsSync($1)"
    let v36 : bool = Fable.Core.JsInterop.emitJsExpr struct (v34, v0) v35
    v36
#endif
    
#if FABLE_COMPILER_PYTHON
    let v37 : bool = null |> unbox<bool>
    v37
#endif
    
#else
    let v38 : (string -> bool) = System.IO.File.Exists
    let v39 : bool = v38 v0
    v39
#endif
    |> fun x -> _v17 <- Some x
    let v40 : bool = _v17.Value
    let v41 : bool = v40 = false
    if v41 then
        return false 
        (*
        ()
    else
        *) else
        let v42 : Async<string> option = None
        let v43 : bool = true in let mutable _v42 = v42
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v44 : Async<string> = null |> unbox<Async<string>>
        v44
#endif
        
#if FABLE_COMPILER_RUST && WASM
        let v45 : Async<string> = null |> unbox<Async<string>>
        v45
#endif
        
#if FABLE_COMPILER_RUST && CONTRACT
        let v46 : Async<string> = null |> unbox<Async<string>>
        v46
#endif
        
#if FABLE_COMPILER_TYPESCRIPT
        let v47 : Async<string> = null |> unbox<Async<string>>
        v47
#endif
        
#if FABLE_COMPILER_PYTHON
        let v48 : Async<string> = null |> unbox<Async<string>>
        v48
#endif
        
#else
        let v49 : (string -> System.Threading.Tasks.Task<string>) = System.IO.File.ReadAllTextAsync
        let v50 : System.Threading.Tasks.Task<string> = v49 v0
        let v51 : Async<string> option = None
        let v52 : bool = true in let mutable _v51 = v51
        
#if FABLE_COMPILER || WASM || CONTRACT
        
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
        
#if FABLE_COMPILER_TYPESCRIPT
        let v56 : Async<string> = null |> unbox<Async<string>>
        v56
#endif
        
#if FABLE_COMPILER_PYTHON
        let v57 : Async<string> = null |> unbox<Async<string>>
        v57
#endif
        
#else
        let v58 : (System.Threading.Tasks.Task<string> -> Async<string>) = Async.AwaitTask
        let v59 : Async<string> = v58 v50
        v59
#endif
        |> fun x -> _v51 <- Some x
        let v60 : Async<string> = _v51.Value
        v60
#endif
        |> fun x -> _v42 <- Some x
        let v61 : Async<string> = _v42.Value
        let! v61 = v61 
        let v62 : string = v61 
        let v63 : bool = v1 = v62
        return v63 
        (*
        ()
    *)
    }
    |> fun x -> _v16 <- Some x
    let v64 : Async<bool> = _v16 |> Option.get
    v64
#endif
    |> fun x -> _v9 <- Some x
    let v65 : Async<bool> = _v9.Value
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
    
#if FABLE_COMPILER || WASM || CONTRACT
    
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
    
#if FABLE_COMPILER_TYPESCRIPT
    let v7 : Async<unit> = null |> unbox<Async<unit>>
    v7
#endif
    
#if FABLE_COMPILER_PYTHON
    let v8 : Async<unit> = null |> unbox<Async<unit>>
    v8
#endif
    
#else
    let v9 : System.Threading.Tasks.Task = System.IO.File.WriteAllTextAsync (v0, v1)
    let v10 : Async<unit> option = None
    let v11 : bool = true in let mutable _v10 = v10
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v12 : Async<unit> = null |> unbox<Async<unit>>
    v12
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v13 : Async<unit> = null |> unbox<Async<unit>>
    v13
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v14 : Async<unit> = null |> unbox<Async<unit>>
    v14
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v15 : Async<unit> = null |> unbox<Async<unit>>
    v15
#endif
    
#if FABLE_COMPILER_PYTHON
    let v16 : Async<unit> = null |> unbox<Async<unit>>
    v16
#endif
    
#else
    let v17 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
    let v18 : Async<unit> = v17 v9
    v18
#endif
    |> fun x -> _v10 <- Some x
    let v19 : Async<unit> = _v10.Value
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
    
#if FABLE_COMPILER || WASM || CONTRACT
    
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
    
#if FABLE_COMPILER_TYPESCRIPT
    let v7 : Async<unit> = null |> unbox<Async<unit>>
    v7
#endif
    
#if FABLE_COMPILER_PYTHON
    let v8 : Async<unit> = null |> unbox<Async<unit>>
    v8
#endif
    
#else
    let v9 : Async<unit> option = None
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
    let v18 : bool = true in let mutable _v17 = v17
    
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
    let v25 : bool option = None
    let v26 : bool = true in let mutable _v25 = v25
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v27 : string = method4(v0)
    let v28 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v29 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v27 v28
    let v30 : string = "String::from($0)"
    let v31 : std_string_String = Fable.Core.RustInterop.emitRustExpr v29 v30
    let v32 : string = "std::path::PathBuf::from($0)"
    let v33 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v31 v32
    let v34 : string = "$0.exists()"
    let v35 : bool = Fable.Core.RustInterop.emitRustExpr v33 v34
    let v38 : bool =
        if v35 then
            let v36 : string = "$0.is_file()"
            let v37 : bool = Fable.Core.RustInterop.emitRustExpr v33 v36
            v37
        else
            false
    v38
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v39 : bool = null |> unbox<bool>
    v39
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v40 : bool = null |> unbox<bool>
    v40
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v41 : string = "fs"
    let v42 : IFsExistsSync = Fable.Core.JsInterop.importAll v41
    let v43 : string = "$0.existsSync($1)"
    let v44 : bool = Fable.Core.JsInterop.emitJsExpr struct (v42, v0) v43
    v44
#endif
    
#if FABLE_COMPILER_PYTHON
    let v45 : bool = null |> unbox<bool>
    v45
#endif
    
#else
    let v46 : (string -> bool) = System.IO.File.Exists
    let v47 : bool = v46 v0
    v47
#endif
    |> fun x -> _v25 <- Some x
    let v48 : bool = _v25.Value
    let v49 : bool = v48 = false
    if v49 then
        return false 
        (*
        ()
    else
        *) else
        let v50 : Async<string> option = None
        let v51 : bool = true in let mutable _v50 = v50
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v52 : Async<string> = null |> unbox<Async<string>>
        v52
#endif
        
#if FABLE_COMPILER_RUST && WASM
        let v53 : Async<string> = null |> unbox<Async<string>>
        v53
#endif
        
#if FABLE_COMPILER_RUST && CONTRACT
        let v54 : Async<string> = null |> unbox<Async<string>>
        v54
#endif
        
#if FABLE_COMPILER_TYPESCRIPT
        let v55 : Async<string> = null |> unbox<Async<string>>
        v55
#endif
        
#if FABLE_COMPILER_PYTHON
        let v56 : Async<string> = null |> unbox<Async<string>>
        v56
#endif
        
#else
        let v57 : (string -> System.Threading.Tasks.Task<string>) = System.IO.File.ReadAllTextAsync
        let v58 : System.Threading.Tasks.Task<string> = v57 v0
        let v59 : Async<string> option = None
        let v60 : bool = true in let mutable _v59 = v59
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v61 : Async<string> = null |> unbox<Async<string>>
        v61
#endif
        
#if FABLE_COMPILER_RUST && WASM
        let v62 : Async<string> = null |> unbox<Async<string>>
        v62
#endif
        
#if FABLE_COMPILER_RUST && CONTRACT
        let v63 : Async<string> = null |> unbox<Async<string>>
        v63
#endif
        
#if FABLE_COMPILER_TYPESCRIPT
        let v64 : Async<string> = null |> unbox<Async<string>>
        v64
#endif
        
#if FABLE_COMPILER_PYTHON
        let v65 : Async<string> = null |> unbox<Async<string>>
        v65
#endif
        
#else
        let v66 : (System.Threading.Tasks.Task<string> -> Async<string>) = Async.AwaitTask
        let v67 : Async<string> = v66 v58
        v67
#endif
        |> fun x -> _v59 <- Some x
        let v68 : Async<string> = _v59.Value
        v68
#endif
        |> fun x -> _v50 <- Some x
        let v69 : Async<string> = _v50.Value
        let! v69 = v69 
        let v70 : string = v69 
        let v71 : bool = v1 = v70
        return v71 
        (*
        ()
    *)
    }
    |> fun x -> _v24 <- Some x
    let v72 : Async<bool> = _v24 |> Option.get
    v72
#endif
    |> fun x -> _v17 <- Some x
    let v73 : Async<bool> = _v17.Value
    v73
#endif
    |> fun x -> _v10 <- Some x
    let v74 : Async<bool> = _v10.Value
    let! v74 = v74 
    let v75 : bool = v74 
    let v76 : bool = v75 = false
    if v76 then
        let v77 : Async<unit> option = None
        let v78 : bool = true in let mutable _v77 = v77
        
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
        let v84 : System.Threading.Tasks.Task = System.IO.File.WriteAllTextAsync (v0, v1)
        let v85 : Async<unit> option = None
        let v86 : bool = true in let mutable _v85 = v85
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v87 : Async<unit> = null |> unbox<Async<unit>>
        v87
#endif
        
#if FABLE_COMPILER_RUST && WASM
        let v88 : Async<unit> = null |> unbox<Async<unit>>
        v88
#endif
        
#if FABLE_COMPILER_RUST && CONTRACT
        let v89 : Async<unit> = null |> unbox<Async<unit>>
        v89
#endif
        
#if FABLE_COMPILER_TYPESCRIPT
        let v90 : Async<unit> = null |> unbox<Async<unit>>
        v90
#endif
        
#if FABLE_COMPILER_PYTHON
        let v91 : Async<unit> = null |> unbox<Async<unit>>
        v91
#endif
        
#else
        let v92 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
        let v93 : Async<unit> = v92 v84
        v93
#endif
        |> fun x -> _v85 <- Some x
        let v94 : Async<unit> = _v85.Value
        v94
#endif
        |> fun x -> _v77 <- Some x
        let v95 : Async<unit> = _v77.Value
        do! v95 
        ()
    }
    |> fun x -> _v9 <- Some x
    let v96 : Async<unit> = _v9 |> Option.get
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
    
#if FABLE_COMPILER || WASM || CONTRACT
    
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
    
#if FABLE_COMPILER_TYPESCRIPT
    let v7 : string = $"%A{v1}"
    v7
#endif
    
#if FABLE_COMPILER_PYTHON
    let v8 : string = $"%A{v1}"
    v8
#endif
    
#else
    let v9 : string = $"{v1.GetType ()}: {v1.Message}"
    v9
#endif
    |> fun x -> _v2 <- Some x
    let v10 : string = _v2.Value
    let v11 : (string -> string) = closure5()
    let v12 : (unit -> string) = closure6()
    let v13 : string = $"path: {v0 |> v11} / ex: {v10} / {v12 ()}"
    v13
and method11 (v0 : string, v1 : int64) : Async<int64> =
    let v2 : Async<int64> option = None
    let v3 : bool = true in let mutable _v2 = v2
    
#if FABLE_COMPILER || WASM || CONTRACT
    
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
    
#if FABLE_COMPILER_TYPESCRIPT
    let v7 : Async<int64> = null |> unbox<Async<int64>>
    v7
#endif
    
#if FABLE_COMPILER_PYTHON
    let v8 : Async<int64> = null |> unbox<Async<int64>>
    v8
#endif
    
#else
    let v9 : Async<int64> option = None
    let mutable _v9 = v9
    async {
    try
    let v10 : unit option = None
    let v11 : bool = true in let mutable _v10 = v10
    
#if FABLE_COMPILER || WASM || CONTRACT
    
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
    
#if FABLE_COMPILER_TYPESCRIPT
    null |> unbox<unit>
    ()
#endif
    
#if FABLE_COMPILER_PYTHON
    null |> unbox<unit>
    ()
#endif
    
#else
    let v12 : (string -> unit) = System.IO.File.Delete
    v12 v0
    ()
#endif
    |> fun x -> _v10 <- Some x
    _v10.Value
    return v1 
    with ex ->
    let v13 : exn = ex
    let v14 : int64 = v1 % 100L
    let v15 : bool = v14 = 0L
    if v15 then
        let v16 : US0 = US0_3
        let v17 : (unit -> string) = closure22()
        let v18 : (unit -> string) = closure23(v0, v13)
        method5(v16, v17, v18)
    let v19 : Async<unit> option = None
    let v20 : bool = true in let mutable _v19 = v19
    
#if FABLE_COMPILER || WASM || CONTRACT
    
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
    
#if FABLE_COMPILER_TYPESCRIPT
    let v24 : Async<unit> = null |> unbox<Async<unit>>
    v24
#endif
    
#if FABLE_COMPILER_PYTHON
    let v25 : Async<unit> = null |> unbox<Async<unit>>
    v25
#endif
    
#else
    let v26 : (int32 -> Async<unit>) = Async.Sleep
    let v27 : Async<unit> = v26 10
    v27
#endif
    |> fun x -> _v19 <- Some x
    let v28 : Async<unit> = _v19.Value
    do! v28 
    let v29 : int64 = v1 + 1L
    let v30 : Async<int64> = method11(v0, v29)
    return! v30 
    (*
    let v31 : int64 = *)
    }
    |> fun x -> _v9 <- Some x
    let v32 : Async<int64> = _v9 |> Option.get
    v32
#endif
    |> fun x -> _v2 <- Some x
    let v33 : Async<int64> = _v2.Value
    v33
and closure21 () (v0 : string) : Async<int64> =
    let v1 : Async<int64> option = None
    let v2 : bool = true in let mutable _v1 = v1
    
#if FABLE_COMPILER || WASM || CONTRACT
    
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
    
#if FABLE_COMPILER_TYPESCRIPT
    let v6 : Async<int64> = null |> unbox<Async<int64>>
    v6
#endif
    
#if FABLE_COMPILER_PYTHON
    let v7 : Async<int64> = null |> unbox<Async<int64>>
    v7
#endif
    
#else
    let v8 : int64 = 0L
    let v9 : Async<int64> = method11(v0, v8)
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
    
#if FABLE_COMPILER || WASM || CONTRACT
    
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
    
#if FABLE_COMPILER_TYPESCRIPT
    let v8 : string = $"%A{v2}"
    v8
#endif
    
#if FABLE_COMPILER_PYTHON
    let v9 : string = $"%A{v2}"
    v9
#endif
    
#else
    let v10 : string = $"{v2.GetType ()}: {v2.Message}"
    v10
#endif
    |> fun x -> _v3 <- Some x
    let v11 : string = _v3.Value
    let v12 : (string -> string) = closure5()
    let v13 : (unit -> string) = closure6()
    let v14 : string = $"old_path: {v1 |> v12} / new_path: {v0 |> v12} / ex: {v11} / {v13 ()}"
    v14
and method12 (v0 : string, v1 : string, v2 : int64) : Async<int64> =
    let v3 : Async<int64> option = None
    let v4 : bool = true in let mutable _v3 = v3
    
#if FABLE_COMPILER || WASM || CONTRACT
    
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
    
#if FABLE_COMPILER_TYPESCRIPT
    let v8 : Async<int64> = null |> unbox<Async<int64>>
    v8
#endif
    
#if FABLE_COMPILER_PYTHON
    let v9 : Async<int64> = null |> unbox<Async<int64>>
    v9
#endif
    
#else
    let v10 : Async<int64> option = None
    let mutable _v10 = v10
    async {
    try
    let v11 : unit option = None
    let v12 : bool = true in let mutable _v11 = v11
    
#if FABLE_COMPILER || WASM || CONTRACT
    
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
    
#if FABLE_COMPILER_TYPESCRIPT
    null |> unbox<unit>
    ()
#endif
    
#if FABLE_COMPILER_PYTHON
    null |> unbox<unit>
    ()
#endif
    
#else
    System.IO.File.Move (v1, v0)
    ()
#endif
    |> fun x -> _v11 <- Some x
    _v11.Value
    return v2 
    with ex ->
    let v13 : exn = ex
    let v14 : int64 = v2 % 100L
    let v15 : bool = v14 = 0L
    if v15 then
        let v16 : US0 = US0_3
        let v17 : (unit -> string) = closure26()
        let v18 : (unit -> string) = closure27(v0, v1, v13)
        method5(v16, v17, v18)
    let v19 : Async<unit> option = None
    let v20 : bool = true in let mutable _v19 = v19
    
#if FABLE_COMPILER || WASM || CONTRACT
    
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
    
#if FABLE_COMPILER_TYPESCRIPT
    let v24 : Async<unit> = null |> unbox<Async<unit>>
    v24
#endif
    
#if FABLE_COMPILER_PYTHON
    let v25 : Async<unit> = null |> unbox<Async<unit>>
    v25
#endif
    
#else
    let v26 : (int32 -> Async<unit>) = Async.Sleep
    let v27 : Async<unit> = v26 10
    v27
#endif
    |> fun x -> _v19 <- Some x
    let v28 : Async<unit> = _v19.Value
    do! v28 
    let v29 : int64 = v2 + 1L
    let v30 : Async<int64> = method12(v0, v1, v29)
    return! v30 
    (*
    *)
    }
    |> fun x -> _v10 <- Some x
    let v31 : Async<int64> = _v10 |> Option.get
    v31
#endif
    |> fun x -> _v3 <- Some x
    let v32 : Async<int64> = _v3.Value
    v32
and closure25 (v0 : string) (v1 : string) : Async<int64> =
    let v2 : Async<int64> option = None
    let v3 : bool = true in let mutable _v2 = v2
    
#if FABLE_COMPILER || WASM || CONTRACT
    
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
    
#if FABLE_COMPILER_TYPESCRIPT
    let v7 : Async<int64> = null |> unbox<Async<int64>>
    v7
#endif
    
#if FABLE_COMPILER_PYTHON
    let v8 : Async<int64> = null |> unbox<Async<int64>>
    v8
#endif
    
#else
    let v9 : int64 = 0L
    let v10 : Async<int64> = method12(v0, v1, v9)
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
and method14 (v0 : int64, v1 : string) : string =
    let v2 : (unit -> string) = closure6()
    let v3 : string = $"retry: {v0} / ex: {v1} / {v2 ()}"
    v3
and closure35 (v0 : int64, v1 : string) () : string =
    method14(v0, v1)
and method13 (v0 : string, v1 : int64) : Async<string option> =
    let v2 : Async<string option> option = None
    let v3 : bool = true in let mutable _v2 = v2
    
#if FABLE_COMPILER || WASM || CONTRACT
    
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
    
#if FABLE_COMPILER_TYPESCRIPT
    let v7 : Async<string option> = null |> unbox<Async<string option>>
    v7
#endif
    
#if FABLE_COMPILER_PYTHON
    let v8 : Async<string option> = null |> unbox<Async<string option>>
    v8
#endif
    
#else
    let v9 : Async<string option> option = None
    let mutable _v9 = v9
    async {
    try
    let v10 : bool = v1 > 0L
    if v10 then
        let v11 : Async<int64> option = None
        let v12 : bool = true in let mutable _v11 = v11
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v13 : Async<int64> = null |> unbox<Async<int64>>
        v13
#endif
        
#if FABLE_COMPILER_RUST && WASM
        let v14 : Async<int64> = null |> unbox<Async<int64>>
        v14
#endif
        
#if FABLE_COMPILER_RUST && CONTRACT
        let v15 : Async<int64> = null |> unbox<Async<int64>>
        v15
#endif
        
#if FABLE_COMPILER_TYPESCRIPT
        let v16 : Async<int64> = null |> unbox<Async<int64>>
        v16
#endif
        
#if FABLE_COMPILER_PYTHON
        let v17 : Async<int64> = null |> unbox<Async<int64>>
        v17
#endif
        
#else
        let v18 : int64 = 0L
        let v19 : Async<int64> = method10(v0, v18)
        v19
#endif
        |> fun x -> _v11 <- Some x
        let v20 : Async<int64> = _v11.Value
        let v21 : Async<US2> option = None
        let v22 : bool = true in let mutable _v21 = v21
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v23 : Async<US2> = null |> unbox<Async<US2>>
        v23
#endif
        
#if FABLE_COMPILER_RUST && WASM
        let v24 : Async<US2> = null |> unbox<Async<US2>>
        v24
#endif
        
#if FABLE_COMPILER_RUST && CONTRACT
        let v25 : Async<US2> = null |> unbox<Async<US2>>
        v25
#endif
        
#if FABLE_COMPILER_TYPESCRIPT
        let v26 : Async<US2> = null |> unbox<Async<US2>>
        v26
#endif
        
#if FABLE_COMPILER_PYTHON
        let v27 : Async<US2> = null |> unbox<Async<US2>>
        v27
#endif
        
#else
        let v28 : Async<US2> option = None
        let v29 : bool = true in let mutable _v28 = v28
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v30 : Async<US2> = null |> unbox<Async<US2>>
        v30
#endif
        
#if FABLE_COMPILER_RUST && WASM
        let v31 : Async<US2> = null |> unbox<Async<US2>>
        v31
#endif
        
#if FABLE_COMPILER_RUST && CONTRACT
        let v32 : Async<US2> = null |> unbox<Async<US2>>
        v32
#endif
        
#if FABLE_COMPILER_TYPESCRIPT
        let v33 : Async<US2> = null |> unbox<Async<US2>>
        v33
#endif
        
#if FABLE_COMPILER_PYTHON
        let v34 : Async<US2> = null |> unbox<Async<US2>>
        v34
#endif
        
#else
        let v35 : Async<US2> option = None
        let mutable _v35 = v35
        async {
        let v36 : Async<Async<int64>> option = None
        let v37 : bool = true in let mutable _v36 = v36
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v38 : Async<Async<int64>> = null |> unbox<Async<Async<int64>>>
        v38
#endif
        
#if FABLE_COMPILER_RUST && WASM
        let v39 : Async<Async<int64>> = null |> unbox<Async<Async<int64>>>
        v39
#endif
        
#if FABLE_COMPILER_RUST && CONTRACT
        let v40 : Async<Async<int64>> = null |> unbox<Async<Async<int64>>>
        v40
#endif
        
#if FABLE_COMPILER_TYPESCRIPT
        let v41 : Async<Async<int64>> = null |> unbox<Async<Async<int64>>>
        v41
#endif
        
#if FABLE_COMPILER_PYTHON
        let v42 : Async<Async<int64>> = null |> unbox<Async<Async<int64>>>
        v42
#endif
        
#else
        let v43 : Async<Async<int64>> = Async.StartChild (v20, 1000)
        v43
#endif
        |> fun x -> _v36 <- Some x
        let v44 : Async<Async<int64>> = _v36.Value
        let! v44 = v44 
        let v45 : Async<int64> = v44 
        let v46 : Async<Choice<int64, exn>> option = None
        let v47 : bool = true in let mutable _v46 = v46
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v48 : Async<Choice<int64, exn>> = null |> unbox<Async<Choice<int64, exn>>>
        v48
#endif
        
#if FABLE_COMPILER_RUST && WASM
        let v49 : Async<Choice<int64, exn>> = null |> unbox<Async<Choice<int64, exn>>>
        v49
#endif
        
#if FABLE_COMPILER_RUST && CONTRACT
        let v50 : Async<Choice<int64, exn>> = null |> unbox<Async<Choice<int64, exn>>>
        v50
#endif
        
#if FABLE_COMPILER_TYPESCRIPT
        let v51 : Async<Choice<int64, exn>> = null |> unbox<Async<Choice<int64, exn>>>
        v51
#endif
        
#if FABLE_COMPILER_PYTHON
        let v52 : Async<Choice<int64, exn>> = null |> unbox<Async<Choice<int64, exn>>>
        v52
#endif
        
#else
        let v53 : (Async<int64> -> Async<Choice<int64, exn>>) = Async.Catch
        let v54 : Async<Choice<int64, exn>> = v53 v45
        v54
#endif
        |> fun x -> _v46 <- Some x
        let v55 : Async<Choice<int64, exn>> = _v46.Value
        let v56 : Async<US6> option = None
        let v57 : bool = true in let mutable _v56 = v56
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v58 : Async<US6> = null |> unbox<Async<US6>>
        v58
#endif
        
#if FABLE_COMPILER_RUST && WASM
        let v59 : Async<US6> = null |> unbox<Async<US6>>
        v59
#endif
        
#if FABLE_COMPILER_RUST && CONTRACT
        let v60 : Async<US6> = null |> unbox<Async<US6>>
        v60
#endif
        
#if FABLE_COMPILER_TYPESCRIPT
        let v61 : Async<US6> = null |> unbox<Async<US6>>
        v61
#endif
        
#if FABLE_COMPILER_PYTHON
        let v62 : Async<US6> = null |> unbox<Async<US6>>
        v62
#endif
        
#else
        let v63 : Async<US6> option = None
        let mutable _v63 = v63
        async {
        let! v55 = v55 
        let v64 : Choice<int64, exn> = v55 
        let v65 : US6 option = None
        let v66 : bool = true in let mutable _v65 = v65
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v67 : US6 = null |> unbox<US6>
        v67
#endif
        
#if FABLE_COMPILER_RUST && WASM
        let v68 : US6 = null |> unbox<US6>
        v68
#endif
        
#if FABLE_COMPILER_RUST && CONTRACT
        let v69 : US6 = null |> unbox<US6>
        v69
#endif
        
#if FABLE_COMPILER_TYPESCRIPT
        let v70 : US6 = null |> unbox<US6>
        v70
#endif
        
#if FABLE_COMPILER_PYTHON
        let v71 : US6 = null |> unbox<US6>
        v71
#endif
        
#else
        let v72 : (int64 -> US6) = closure29()
        let v73 : (exn -> US6) = closure30()
        let v74 : US6 = match v64 with Choice1Of2 x -> v72 x | Choice2Of2 x -> v73 x
        v74
#endif
        |> fun x -> _v65 <- Some x
        let v75 : US6 = _v65.Value
        return v75 
        }
        |> fun x -> _v63 <- Some x
        let v76 : Async<US6> = _v63 |> Option.get
        v76
#endif
        |> fun x -> _v56 <- Some x
        let v77 : Async<US6> = _v56.Value
        let v78 : Async<US7> option = None
        let v79 : bool = true in let mutable _v78 = v78
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v80 : Async<US7> = null |> unbox<Async<US7>>
        v80
#endif
        
#if FABLE_COMPILER_RUST && WASM
        let v81 : Async<US7> = null |> unbox<Async<US7>>
        v81
#endif
        
#if FABLE_COMPILER_RUST && CONTRACT
        let v82 : Async<US7> = null |> unbox<Async<US7>>
        v82
#endif
        
#if FABLE_COMPILER_TYPESCRIPT
        let v83 : Async<US7> = null |> unbox<Async<US7>>
        v83
#endif
        
#if FABLE_COMPILER_PYTHON
        let v84 : Async<US7> = null |> unbox<Async<US7>>
        v84
#endif
        
#else
        let v85 : Async<US7> option = None
        let mutable _v85 = v85
        async {
        let! v77 = v77 
        let v86 : US6 = v77 
        let v92 : US7 =
            match v86 with
            | US6_0(v87) -> (* Choice1Of2 *)
                US7_0(v87)
            | US6_1(v89) -> (* Choice2Of2 *)
                US7_1(v89)
        return v92 
        }
        |> fun x -> _v85 <- Some x
        let v93 : Async<US7> = _v85 |> Option.get
        v93
#endif
        |> fun x -> _v78 <- Some x
        let v94 : Async<US7> = _v78.Value
        let v95 : Async<US2> option = None
        let v96 : bool = true in let mutable _v95 = v95
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v97 : Async<US2> = null |> unbox<Async<US2>>
        v97
#endif
        
#if FABLE_COMPILER_RUST && WASM
        let v98 : Async<US2> = null |> unbox<Async<US2>>
        v98
#endif
        
#if FABLE_COMPILER_RUST && CONTRACT
        let v99 : Async<US2> = null |> unbox<Async<US2>>
        v99
#endif
        
#if FABLE_COMPILER_TYPESCRIPT
        let v100 : Async<US2> = null |> unbox<Async<US2>>
        v100
#endif
        
#if FABLE_COMPILER_PYTHON
        let v101 : Async<US2> = null |> unbox<Async<US2>>
        v101
#endif
        
#else
        let v102 : Async<US2> option = None
        let mutable _v102 = v102
        async {
        let! v94 = v94 
        let v103 : US7 = v94 
        let v129 : US2 =
            match v103 with
            | US7_1(v106) -> (* Error *)
                let v107 : string = $"%A{v106}"
                let v108 : string = "System.TimeoutException"
                let v109 : bool = v107.Contains v108
                if v109 then
                    let v110 : US0 = US0_1
                    let v111 : (unit -> string) = closure31()
                    let v112 : (unit -> string) = closure32()
                    method5(v110, v111, v112)
                    US2_1
                else
                    let v114 : string option = None
                    let v115 : bool = true in let mutable _v114 = v114
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v116 : string = $"%A{v106}"
                    v116
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let v117 : string = $"%A{v106}"
                    v117
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let v118 : string = $"%A{v106}"
                    v118
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let v119 : string = $"%A{v106}"
                    v119
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let v120 : string = $"%A{v106}"
                    v120
#endif
                    
#else
                    let v121 : string = $"{v106.GetType ()}: {v106.Message}"
                    v121
#endif
                    |> fun x -> _v114 <- Some x
                    let v122 : string = _v114.Value
                    let v123 : US0 = US0_4
                    let v124 : (unit -> string) = closure33(v122)
                    let v125 : (unit -> string) = closure32()
                    method5(v123, v124, v125)
                    US2_1
            | US7_0(v104) -> (* Ok *)
                US2_0(v104)
        return v129 
        }
        |> fun x -> _v102 <- Some x
        let v130 : Async<US2> = _v102 |> Option.get
        v130
#endif
        |> fun x -> _v95 <- Some x
        let v131 : Async<US2> = _v95.Value
        return! v131 
        }
        |> fun x -> _v35 <- Some x
        let v132 : Async<US2> = _v35 |> Option.get
        v132
#endif
        |> fun x -> _v28 <- Some x
        let v133 : Async<US2> = _v28.Value
        v133
#endif
        |> fun x -> _v21 <- Some x
        let v134 : Async<US2> = _v21.Value
        let v135 : Async<unit> option = None
        let v136 : bool = true in let mutable _v135 = v135
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v137 : Async<unit> = null |> unbox<Async<unit>>
        v137
#endif
        
#if FABLE_COMPILER_RUST && WASM
        let v138 : Async<unit> = null |> unbox<Async<unit>>
        v138
#endif
        
#if FABLE_COMPILER_RUST && CONTRACT
        let v139 : Async<unit> = null |> unbox<Async<unit>>
        v139
#endif
        
#if FABLE_COMPILER_TYPESCRIPT
        let v140 : Async<unit> = null |> unbox<Async<unit>>
        v140
#endif
        
#if FABLE_COMPILER_PYTHON
        let v141 : Async<unit> = null |> unbox<Async<unit>>
        v141
#endif
        
#else
        let v142 : (Async<US2> -> Async<unit>) = Async.Ignore
        let v143 : Async<unit> = v142 v134
        v143
#endif
        |> fun x -> _v135 <- Some x
        let v144 : Async<unit> = _v135.Value
        do! v144 
        ()
    let v145 : Async<string> option = None
    let v146 : bool = true in let mutable _v145 = v145
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v147 : Async<string> = null |> unbox<Async<string>>
    v147
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v148 : Async<string> = null |> unbox<Async<string>>
    v148
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v149 : Async<string> = null |> unbox<Async<string>>
    v149
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v150 : Async<string> = null |> unbox<Async<string>>
    v150
#endif
    
#if FABLE_COMPILER_PYTHON
    let v151 : Async<string> = null |> unbox<Async<string>>
    v151
#endif
    
#else
    let v152 : (string -> System.Threading.Tasks.Task<string>) = System.IO.File.ReadAllTextAsync
    let v153 : System.Threading.Tasks.Task<string> = v152 v0
    let v154 : Async<string> option = None
    let v155 : bool = true in let mutable _v154 = v154
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v156 : Async<string> = null |> unbox<Async<string>>
    v156
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v157 : Async<string> = null |> unbox<Async<string>>
    v157
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v158 : Async<string> = null |> unbox<Async<string>>
    v158
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v159 : Async<string> = null |> unbox<Async<string>>
    v159
#endif
    
#if FABLE_COMPILER_PYTHON
    let v160 : Async<string> = null |> unbox<Async<string>>
    v160
#endif
    
#else
    let v161 : (System.Threading.Tasks.Task<string> -> Async<string>) = Async.AwaitTask
    let v162 : Async<string> = v161 v153
    v162
#endif
    |> fun x -> _v154 <- Some x
    let v163 : Async<string> = _v154.Value
    v163
#endif
    |> fun x -> _v145 <- Some x
    let v164 : Async<string> = _v145.Value
    let v165 : Async<string option> option = None
    let v166 : bool = true in let mutable _v165 = v165
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v167 : Async<string option> = null |> unbox<Async<string option>>
    v167
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v168 : Async<string option> = null |> unbox<Async<string option>>
    v168
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v169 : Async<string option> = null |> unbox<Async<string option>>
    v169
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v170 : Async<string option> = null |> unbox<Async<string option>>
    v170
#endif
    
#if FABLE_COMPILER_PYTHON
    let v171 : Async<string option> = null |> unbox<Async<string option>>
    v171
#endif
    
#else
    let v172 : Async<string option> option = None
    let mutable _v172 = v172
    async {
    let! v164 = v164 
    let v173 : string = v164 
    let v174 : string option = Some v173 
    return v174 
    }
    |> fun x -> _v172 <- Some x
    let v175 : Async<string option> = _v172 |> Option.get
    v175
#endif
    |> fun x -> _v165 <- Some x
    let v176 : Async<string option> = _v165.Value
    return! v176 
    with ex ->
    let v177 : exn = ex
    let v178 : bool = v1 = 0L
    let v179 : bool = v178 <> true
    if v179 then
        let v180 : string option = None
        let v181 : bool = true in let mutable _v180 = v180
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v182 : string = $"%A{v177}"
        v182
#endif
        
#if FABLE_COMPILER_RUST && WASM
        let v183 : string = $"%A{v177}"
        v183
#endif
        
#if FABLE_COMPILER_RUST && CONTRACT
        let v184 : string = $"%A{v177}"
        v184
#endif
        
#if FABLE_COMPILER_TYPESCRIPT
        let v185 : string = $"%A{v177}"
        v185
#endif
        
#if FABLE_COMPILER_PYTHON
        let v186 : string = $"%A{v177}"
        v186
#endif
        
#else
        let v187 : string = $"{v177.GetType ()}: {v177.Message}"
        v187
#endif
        |> fun x -> _v180 <- Some x
        let v188 : string = _v180.Value
        let v189 : US0 = US0_1
        let v190 : (unit -> string) = closure34()
        let v191 : (unit -> string) = closure35(v1, v188)
        method5(v189, v190, v191)
        let v192 : string option = None
        return v192 
        (*
        ()
    else
        *) else
        let v193 : int64 = v1 + 1L
        let v194 : Async<string option> = method13(v0, v193)
        return! v194 
        (*
        ()
    *)
    (*
    let v195 : string option = *)
    }
    |> fun x -> _v9 <- Some x
    let v196 : Async<string option> = _v9 |> Option.get
    v196
#endif
    |> fun x -> _v2 <- Some x
    let v197 : Async<string option> = _v2.Value
    v197
and closure28 () (v0 : string) : Async<string option> =
    let v1 : Async<string option> option = None
    let v2 : bool = true in let mutable _v1 = v1
    
#if FABLE_COMPILER || WASM || CONTRACT
    
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
    
#if FABLE_COMPILER_TYPESCRIPT
    let v6 : Async<string option> = null |> unbox<Async<string option>>
    v6
#endif
    
#if FABLE_COMPILER_PYTHON
    let v7 : Async<string option> = null |> unbox<Async<string option>>
    v7
#endif
    
#else
    let v8 : int64 = 0L
    let v9 : Async<string option> = method13(v0, v8)
    v9
#endif
    |> fun x -> _v1 <- Some x
    let v10 : Async<string option> = _v1.Value
    v10
and method16 (v0 : string) : string =
    v0
and method17 (v0 : string) : string =
    v0
and method15 (v0 : string, v1 : string) : string =
    let v2 : string option = None
    let v3 : bool = true in let mutable _v2 = v2
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v4 : string = method4(v0)
    let v5 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v6 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v4 v5
    let v7 : string = "String::from($0)"
    let v8 : std_string_String = Fable.Core.RustInterop.emitRustExpr v6 v7
    let v9 : string = "std::path::PathBuf::from($0)"
    let v10 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v8 v9
    let v11 : string = method4(v1)
    let v12 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v13 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v11 v12
    let v14 : string = "String::from($0)"
    let v15 : std_string_String = Fable.Core.RustInterop.emitRustExpr v13 v14
    let v16 : string = "$0.join($1)"
    let v17 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr struct (v10, v15) v16
    let v18 : string = "$0.display()"
    let v19 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v17 v18
    let v20 : std_string_String option = None
    let v21 : bool = true in let mutable _v20 = v20
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v22 : string = @$"format!(""{{}}"", $0)"
    let v23 : std_string_String = Fable.Core.RustInterop.emitRustExpr v19 v22
    v23
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v24 : string = @$"format!(""{{}}"", $0)"
    let v25 : std_string_String = Fable.Core.RustInterop.emitRustExpr v19 v24
    v25
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v26 : string = @$"format!(""{{}}"", $0)"
    let v27 : std_string_String = Fable.Core.RustInterop.emitRustExpr v19 v26
    v27
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v28 : std_string_String = null |> unbox<std_string_String>
    v28
#endif
    
#if FABLE_COMPILER_PYTHON
    let v29 : std_string_String = null |> unbox<std_string_String>
    v29
#endif
    
#else
    let v30 : std_string_String = null |> unbox<std_string_String>
    v30
#endif
    |> fun x -> _v20 <- Some x
    let v31 : std_string_String = _v20.Value
    let v32 : string = "fable_library_rust::String_::fromString($0)"
    let v33 : string = Fable.Core.RustInterop.emitRustExpr v31 v32
    v33
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v34 : string = null |> unbox<string>
    v34
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v35 : string = null |> unbox<string>
    v35
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v36 : string = "path"
    let v37 : IPathJoin = Fable.Core.JsInterop.importAll v36
    let v38 : string = method16(v0)
    let v39 : string = method17(v1)
    let v40 : string = "v37.join(v38, v39)"
    let v41 : string = Fable.Core.JsInterop.emitJsExpr () v40
    v41
#endif
    
#if FABLE_COMPILER_PYTHON
    let v42 : string = null |> unbox<string>
    v42
#endif
    
#else
    let v43 : string = System.IO.Path.Combine (v0, v1)
    v43
#endif
    |> fun x -> _v2 <- Some x
    let v44 : string = _v2.Value
    v44
and closure37 () (v0 : chrono_DateTime<chrono_Utc>) : US8 =
    US8_0(v0)
and method18 () : (chrono_DateTime<chrono_Utc> -> US8) =
    closure37()
and method19 (v0 : chrono_DateTime<chrono_Utc>) : chrono_DateTime<chrono_Utc> =
    v0
and method20 (v0 : chrono_DateTime<chrono_Local>) : chrono_DateTime<chrono_Local> =
    v0
and method21 () : string =
    let v0 : string = "yyyyMMdd-HHmm-ssff-ffff-f"
    v0
and method22 () : string =
    let v0 : string = "hhmm"
    v0
and closure36 () () : string =
    let v0 : string option = None
    let v1 : bool = true in let mutable _v0 = v0
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string option = None
    let v3 : bool = true in let mutable _v2 = v2
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v4 : string = "env!(\"CARGO_PKG_NAME\").into()"
    let v5 : string = Fable.Core.RustInterop.emitRustExpr () v4
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
    
#if FABLE_COMPILER_TYPESCRIPT
    let v8 : string = null |> unbox<string>
    v8
#endif
    
#if FABLE_COMPILER_PYTHON
    let v9 : string = null |> unbox<string>
    v9
#endif
    
#else
    let v10 : string = System.Reflection.Assembly.GetEntryAssembly().GetName().Name
    v10
#endif
    |> fun x -> _v2 <- Some x
    let v11 : string = _v2.Value
    let v12 : string option = None
    let v13 : bool = true in let mutable _v12 = v12
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v14 : string = "std::env::temp_dir()"
    let v15 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr () v14
    let v16 : string = "$0.display()"
    let v17 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v15 v16
    let v18 : std_string_String option = None
    let v19 : bool = true in let mutable _v18 = v18
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v20 : string = @$"format!(""{{}}"", $0)"
    let v21 : std_string_String = Fable.Core.RustInterop.emitRustExpr v17 v20
    v21
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v22 : string = @$"format!(""{{}}"", $0)"
    let v23 : std_string_String = Fable.Core.RustInterop.emitRustExpr v17 v22
    v23
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v24 : string = @$"format!(""{{}}"", $0)"
    let v25 : std_string_String = Fable.Core.RustInterop.emitRustExpr v17 v24
    v25
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v26 : std_string_String = null |> unbox<std_string_String>
    v26
#endif
    
#if FABLE_COMPILER_PYTHON
    let v27 : std_string_String = null |> unbox<std_string_String>
    v27
#endif
    
#else
    let v28 : std_string_String = null |> unbox<std_string_String>
    v28
#endif
    |> fun x -> _v18 <- Some x
    let v29 : std_string_String = _v18.Value
    let v30 : string = "fable_library_rust::String_::fromString($0)"
    let v31 : string = Fable.Core.RustInterop.emitRustExpr v29 v30
    v31
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v32 : string = null |> unbox<string>
    v32
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v33 : string = null |> unbox<string>
    v33
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v34 : string = null |> unbox<string>
    v34
#endif
    
#if FABLE_COMPILER_PYTHON
    let v35 : string = null |> unbox<string>
    v35
#endif
    
#else
    let v36 : (unit -> string) = System.IO.Path.GetTempPath
    let v37 : string = v36 ()
    v37
#endif
    |> fun x -> _v12 <- Some x
    let v38 : string = _v12.Value
    let v39 : string = $"!{v11}"
    let v40 : string = method15(v38, v39)
    let v41 : System.DateTime = System.DateTime.Now
    let v42 : System.Guid = System.Guid.NewGuid ()
    let v43 : (System.Guid -> string) = _.ToString()
    let v44 : string = v43 v42
    let v45 : struct (string * string) option = None
    let v46 : bool = true in let mutable _v45 = v45
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v47 : System.DateTime = System.DateTime (1970, 1, 1, 0, 0, 0, System.DateTimeKind.Utc)
    let v48 : (System.DateTime -> System.DateTime) = _.ToUniversalTime()
    let v49 : System.DateTime = v48 v47
    let v50 : System.DateTimeKind = System.DateTimeKind.Local
    let v51 : System.DateTime = System.DateTime.SpecifyKind (v41, v50)
    let v52 : (System.DateTime -> System.DateTime) = _.ToUniversalTime()
    let v53 : System.DateTime = v52 v51
    let v54 : (System.DateTime -> int64) = _.Ticks
    let v55 : int64 = v54 v53
    let v56 : (System.DateTime -> int64) = _.Ticks
    let v57 : int64 = v56 v49
    let v58 : int64 = v55 - v57
    let v59 : int64 = v58 / 10L
    let v60 : string = "chrono::DateTime::from_timestamp_micros($0)"
    let v61 : chrono_DateTime<chrono_Utc> option = Fable.Core.RustInterop.emitRustExpr v59 v60
    let v62 : (chrono_DateTime<chrono_Utc> -> US8) = method18()
    let v63 : US8 = US8_1
    let v64 : US8 = v61 |> Option.map v62 |> Option.defaultValue v63 
    let v83 : US9 =
        match v64 with
        | US8_1 -> (* None *)
            US9_1
        | US8_0(v65) -> (* Some *)
            let v66 : chrono_DateTime<chrono_Utc> = method19(v65)
            let v67 : string = "v66.naive_utc()"
            let v68 : chrono_NaiveDateTime = Fable.Core.RustInterop.emitRustExpr () v67
            let v69 : string = "chrono::offset::TimeZone::from_utc_datetime(&chrono::Local, &v68)"
            let v70 : chrono_DateTime<chrono_Local> = Fable.Core.RustInterop.emitRustExpr () v69
            let v71 : string = "%Y%m%d-%H%M-%S%f"
            let v72 : string = "r#\"" + v71 + "\"#"
            let v73 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v72
            let v74 : chrono_DateTime<chrono_Local> = method20(v70)
            let v75 : string = "v74.format(v73).to_string()"
            let v76 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v75
            let v77 : string = "fable_library_rust::String_::fromString($0)"
            let v78 : string = Fable.Core.RustInterop.emitRustExpr v76 v77
            let v79 : string = $"{v78.[0..17]}-{v78.[18..21]}-{v78.[22]}"
            US9_0(v79)
    let v87 : string =
        match v83 with
        | US9_1 -> (* None *)
            let v85 : string = ""
            v85
        | US9_0(v84) -> (* Some *)
            v84
    let v88 : System.TimeZoneInfo option = None
    let v89 : bool = true in let mutable _v88 = v88
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v90 : string = "0i64.into()"
    let v91 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v90
    v91
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v92 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v92
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v93 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v93
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v94 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v94
#endif
    
#if FABLE_COMPILER_PYTHON
    let v95 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v95
#endif
    
#else
    let v96 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    v96
#endif
    |> fun x -> _v88 <- Some x
    let v97 : System.TimeZoneInfo = _v88.Value
    let v98 : System.TimeSpan option = None
    let v99 : bool = true in let mutable _v98 = v98
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v100 : System.TimeSpan = System.TimeSpan () 
    v100
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v101 : System.TimeSpan = System.TimeSpan () 
    v101
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v102 : System.TimeSpan = System.TimeSpan () 
    v102
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v103 : System.TimeSpan = System.TimeSpan () 
    v103
#endif
    
#if FABLE_COMPILER_PYTHON
    let v104 : System.TimeSpan = System.TimeSpan () 
    v104
#endif
    
#else
    let v105 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v106 : System.TimeZoneInfo option = None
    let v107 : bool = true in let mutable _v106 = v106
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v108 : string = "0i64.into()"
    let v109 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v108
    v109
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v110 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v110
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v111 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v111
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v112 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v112
#endif
    
#if FABLE_COMPILER_PYTHON
    let v113 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v113
#endif
    
#else
    let v114 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    v114
#endif
    |> fun x -> _v106 <- Some x
    let v115 : System.TimeZoneInfo = _v106.Value
    let v116 : (System.DateTime -> System.TimeSpan) = v105 v115
    let v117 : System.TimeSpan = v116 v53
    v117
#endif
    |> fun x -> _v98 <- Some x
    let v118 : System.TimeSpan = _v98.Value
    let v119 : (System.TimeSpan -> int32) = _.Hours
    let v120 : int32 = v119 v118
    let v121 : bool = v120 > 0
    let v122 : uint8 =
        if v121 then
            1uy
        else
            0uy
    let v123 : (string -> string) = v118.ToString
    let v124 : string = "hh:mm"
    let v125 : string = v123 v124
    let v126 : string = $"{v122}{v125.[0..1]}{v125.[3..4]}"
    struct (v87, v126)
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let struct (v127 : string, v128 : string) = null |> unbox<struct (string * string)>
    struct (v127, v128)
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let struct (v129 : string, v130 : string) = null |> unbox<struct (string * string)>
    struct (v129, v130)
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let struct (v131 : string, v132 : string) = null |> unbox<struct (string * string)>
    struct (v131, v132)
#endif
    
#if FABLE_COMPILER_PYTHON
    let struct (v133 : string, v134 : string) = null |> unbox<struct (string * string)>
    struct (v133, v134)
#endif
    
#else
    let v135 : string = method21()
    let v136 : (string -> string) = v41.ToString
    let v137 : string = v136 v135
    let v138 : System.TimeZoneInfo option = None
    let v139 : bool = true in let mutable _v138 = v138
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v140 : string = "0i64.into()"
    let v141 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v140
    v141
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v142 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v142
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v143 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v143
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v144 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v144
#endif
    
#if FABLE_COMPILER_PYTHON
    let v145 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v145
#endif
    
#else
    let v146 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    v146
#endif
    |> fun x -> _v138 <- Some x
    let v147 : System.TimeZoneInfo = _v138.Value
    let v148 : System.TimeSpan option = None
    let v149 : bool = true in let mutable _v148 = v148
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v150 : System.TimeSpan = System.TimeSpan () 
    v150
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v151 : System.TimeSpan = System.TimeSpan () 
    v151
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v152 : System.TimeSpan = System.TimeSpan () 
    v152
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v153 : System.TimeSpan = System.TimeSpan () 
    v153
#endif
    
#if FABLE_COMPILER_PYTHON
    let v154 : System.TimeSpan = System.TimeSpan () 
    v154
#endif
    
#else
    let v155 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v156 : System.TimeZoneInfo option = None
    let v157 : bool = true in let mutable _v156 = v156
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v158 : string = "0i64.into()"
    let v159 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v158
    v159
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v160 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v160
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v161 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v161
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v162 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v162
#endif
    
#if FABLE_COMPILER_PYTHON
    let v163 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v163
#endif
    
#else
    let v164 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    v164
#endif
    |> fun x -> _v156 <- Some x
    let v165 : System.TimeZoneInfo = _v156.Value
    let v166 : (System.DateTime -> System.TimeSpan) = v155 v165
    let v167 : System.TimeSpan = v166 v41
    v167
#endif
    |> fun x -> _v148 <- Some x
    let v168 : System.TimeSpan = _v148.Value
    let v169 : (System.TimeSpan -> int32) = _.Hours
    let v170 : int32 = v169 v168
    let v171 : bool = v170 > 0
    let v172 : (bool -> int32) = System.Convert.ToInt32
    let v173 : int32 = v172 v171
    let v174 : string = method22()
    let v175 : (string -> string) = v168.ToString
    let v176 : string = v175 v174
    let v177 : string = $"{v173}{v176}"
    struct (v137, v177)
#endif
    |> fun x -> _v45 <- Some x
    let struct (v178 : string, v179 : string) = _v45.Value
    let v180 : System.Guid = System.Guid $"{v178}{v179}{v44.[v178.Length + v179.Length..]}"
    let v181 : (System.Guid -> string) = _.ToString()
    let v182 : string = v181 v180
    let v183 : string = method15(v40, v182)
    v183
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v184 : string = null |> unbox<string>
    v184
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v185 : string = null |> unbox<string>
    v185
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v186 : string = null |> unbox<string>
    v186
#endif
    
#if FABLE_COMPILER_PYTHON
    let v187 : string = null |> unbox<string>
    v187
#endif
    
#else
    let v188 : string option = None
    let v189 : bool = true in let mutable _v188 = v188
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v190 : string = "env!(\"CARGO_PKG_NAME\").into()"
    let v191 : string = Fable.Core.RustInterop.emitRustExpr () v190
    v191
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v192 : string = null |> unbox<string>
    v192
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v193 : string = null |> unbox<string>
    v193
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v194 : string = null |> unbox<string>
    v194
#endif
    
#if FABLE_COMPILER_PYTHON
    let v195 : string = null |> unbox<string>
    v195
#endif
    
#else
    let v196 : string = System.Reflection.Assembly.GetEntryAssembly().GetName().Name
    v196
#endif
    |> fun x -> _v188 <- Some x
    let v197 : string = _v188.Value
    let v198 : string option = None
    let v199 : bool = true in let mutable _v198 = v198
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v200 : string = "std::env::temp_dir()"
    let v201 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr () v200
    let v202 : string = "$0.display()"
    let v203 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v201 v202
    let v204 : std_string_String option = None
    let v205 : bool = true in let mutable _v204 = v204
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v206 : string = @$"format!(""{{}}"", $0)"
    let v207 : std_string_String = Fable.Core.RustInterop.emitRustExpr v203 v206
    v207
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v208 : string = @$"format!(""{{}}"", $0)"
    let v209 : std_string_String = Fable.Core.RustInterop.emitRustExpr v203 v208
    v209
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v210 : string = @$"format!(""{{}}"", $0)"
    let v211 : std_string_String = Fable.Core.RustInterop.emitRustExpr v203 v210
    v211
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v212 : std_string_String = null |> unbox<std_string_String>
    v212
#endif
    
#if FABLE_COMPILER_PYTHON
    let v213 : std_string_String = null |> unbox<std_string_String>
    v213
#endif
    
#else
    let v214 : std_string_String = null |> unbox<std_string_String>
    v214
#endif
    |> fun x -> _v204 <- Some x
    let v215 : std_string_String = _v204.Value
    let v216 : string = "fable_library_rust::String_::fromString($0)"
    let v217 : string = Fable.Core.RustInterop.emitRustExpr v215 v216
    v217
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v218 : string = null |> unbox<string>
    v218
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v219 : string = null |> unbox<string>
    v219
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v220 : string = null |> unbox<string>
    v220
#endif
    
#if FABLE_COMPILER_PYTHON
    let v221 : string = null |> unbox<string>
    v221
#endif
    
#else
    let v222 : (unit -> string) = System.IO.Path.GetTempPath
    let v223 : string = v222 ()
    v223
#endif
    |> fun x -> _v198 <- Some x
    let v224 : string = _v198.Value
    let v225 : string = $"!{v197}"
    let v226 : string = method15(v224, v225)
    let v227 : System.DateTime = System.DateTime.Now
    let v228 : System.Guid = System.Guid.NewGuid ()
    let v229 : (System.Guid -> string) = _.ToString()
    let v230 : string = v229 v228
    let v231 : struct (string * string) option = None
    let v232 : bool = true in let mutable _v231 = v231
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v233 : System.DateTime = System.DateTime (1970, 1, 1, 0, 0, 0, System.DateTimeKind.Utc)
    let v234 : (System.DateTime -> System.DateTime) = _.ToUniversalTime()
    let v235 : System.DateTime = v234 v233
    let v236 : System.DateTimeKind = System.DateTimeKind.Local
    let v237 : System.DateTime = System.DateTime.SpecifyKind (v227, v236)
    let v238 : (System.DateTime -> System.DateTime) = _.ToUniversalTime()
    let v239 : System.DateTime = v238 v237
    let v240 : (System.DateTime -> int64) = _.Ticks
    let v241 : int64 = v240 v239
    let v242 : (System.DateTime -> int64) = _.Ticks
    let v243 : int64 = v242 v235
    let v244 : int64 = v241 - v243
    let v245 : int64 = v244 / 10L
    let v246 : string = "chrono::DateTime::from_timestamp_micros($0)"
    let v247 : chrono_DateTime<chrono_Utc> option = Fable.Core.RustInterop.emitRustExpr v245 v246
    let v248 : (chrono_DateTime<chrono_Utc> -> US8) = method18()
    let v249 : US8 = US8_1
    let v250 : US8 = v247 |> Option.map v248 |> Option.defaultValue v249 
    let v269 : US9 =
        match v250 with
        | US8_1 -> (* None *)
            US9_1
        | US8_0(v251) -> (* Some *)
            let v252 : chrono_DateTime<chrono_Utc> = method19(v251)
            let v253 : string = "v252.naive_utc()"
            let v254 : chrono_NaiveDateTime = Fable.Core.RustInterop.emitRustExpr () v253
            let v255 : string = "chrono::offset::TimeZone::from_utc_datetime(&chrono::Local, &v254)"
            let v256 : chrono_DateTime<chrono_Local> = Fable.Core.RustInterop.emitRustExpr () v255
            let v257 : string = "%Y%m%d-%H%M-%S%f"
            let v258 : string = "r#\"" + v257 + "\"#"
            let v259 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v258
            let v260 : chrono_DateTime<chrono_Local> = method20(v256)
            let v261 : string = "v260.format(v259).to_string()"
            let v262 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v261
            let v263 : string = "fable_library_rust::String_::fromString($0)"
            let v264 : string = Fable.Core.RustInterop.emitRustExpr v262 v263
            let v265 : string = $"{v264.[0..17]}-{v264.[18..21]}-{v264.[22]}"
            US9_0(v265)
    let v273 : string =
        match v269 with
        | US9_1 -> (* None *)
            let v271 : string = ""
            v271
        | US9_0(v270) -> (* Some *)
            v270
    let v274 : System.TimeZoneInfo option = None
    let v275 : bool = true in let mutable _v274 = v274
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v276 : string = "0i64.into()"
    let v277 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v276
    v277
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v278 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v278
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v279 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v279
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v280 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v280
#endif
    
#if FABLE_COMPILER_PYTHON
    let v281 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v281
#endif
    
#else
    let v282 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    v282
#endif
    |> fun x -> _v274 <- Some x
    let v283 : System.TimeZoneInfo = _v274.Value
    let v284 : System.TimeSpan option = None
    let v285 : bool = true in let mutable _v284 = v284
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v286 : System.TimeSpan = System.TimeSpan () 
    v286
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v287 : System.TimeSpan = System.TimeSpan () 
    v287
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v288 : System.TimeSpan = System.TimeSpan () 
    v288
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v289 : System.TimeSpan = System.TimeSpan () 
    v289
#endif
    
#if FABLE_COMPILER_PYTHON
    let v290 : System.TimeSpan = System.TimeSpan () 
    v290
#endif
    
#else
    let v291 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v292 : System.TimeZoneInfo option = None
    let v293 : bool = true in let mutable _v292 = v292
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v294 : string = "0i64.into()"
    let v295 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v294
    v295
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v296 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v296
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v297 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v297
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v298 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v298
#endif
    
#if FABLE_COMPILER_PYTHON
    let v299 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v299
#endif
    
#else
    let v300 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    v300
#endif
    |> fun x -> _v292 <- Some x
    let v301 : System.TimeZoneInfo = _v292.Value
    let v302 : (System.DateTime -> System.TimeSpan) = v291 v301
    let v303 : System.TimeSpan = v302 v239
    v303
#endif
    |> fun x -> _v284 <- Some x
    let v304 : System.TimeSpan = _v284.Value
    let v305 : (System.TimeSpan -> int32) = _.Hours
    let v306 : int32 = v305 v304
    let v307 : bool = v306 > 0
    let v308 : uint8 =
        if v307 then
            1uy
        else
            0uy
    let v309 : (string -> string) = v304.ToString
    let v310 : string = v309 v124
    let v311 : string = $"{v308}{v310.[0..1]}{v310.[3..4]}"
    struct (v273, v311)
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let struct (v312 : string, v313 : string) = null |> unbox<struct (string * string)>
    struct (v312, v313)
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let struct (v314 : string, v315 : string) = null |> unbox<struct (string * string)>
    struct (v314, v315)
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let struct (v316 : string, v317 : string) = null |> unbox<struct (string * string)>
    struct (v316, v317)
#endif
    
#if FABLE_COMPILER_PYTHON
    let struct (v318 : string, v319 : string) = null |> unbox<struct (string * string)>
    struct (v318, v319)
#endif
    
#else
    let v320 : string = method21()
    let v321 : (string -> string) = v227.ToString
    let v322 : string = v321 v320
    let v323 : System.TimeZoneInfo option = None
    let v324 : bool = true in let mutable _v323 = v323
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v325 : string = "0i64.into()"
    let v326 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v325
    v326
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v327 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v327
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v328 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v328
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v329 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v329
#endif
    
#if FABLE_COMPILER_PYTHON
    let v330 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v330
#endif
    
#else
    let v331 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    v331
#endif
    |> fun x -> _v323 <- Some x
    let v332 : System.TimeZoneInfo = _v323.Value
    let v333 : System.TimeSpan option = None
    let v334 : bool = true in let mutable _v333 = v333
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v335 : System.TimeSpan = System.TimeSpan () 
    v335
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v336 : System.TimeSpan = System.TimeSpan () 
    v336
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v337 : System.TimeSpan = System.TimeSpan () 
    v337
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v338 : System.TimeSpan = System.TimeSpan () 
    v338
#endif
    
#if FABLE_COMPILER_PYTHON
    let v339 : System.TimeSpan = System.TimeSpan () 
    v339
#endif
    
#else
    let v340 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v341 : System.TimeZoneInfo option = None
    let v342 : bool = true in let mutable _v341 = v341
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v343 : string = "0i64.into()"
    let v344 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v343
    v344
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v345 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v345
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v346 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v346
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v347 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v347
#endif
    
#if FABLE_COMPILER_PYTHON
    let v348 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v348
#endif
    
#else
    let v349 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    v349
#endif
    |> fun x -> _v341 <- Some x
    let v350 : System.TimeZoneInfo = _v341.Value
    let v351 : (System.DateTime -> System.TimeSpan) = v340 v350
    let v352 : System.TimeSpan = v351 v227
    v352
#endif
    |> fun x -> _v333 <- Some x
    let v353 : System.TimeSpan = _v333.Value
    let v354 : (System.TimeSpan -> int32) = _.Hours
    let v355 : int32 = v354 v353
    let v356 : bool = v355 > 0
    let v357 : (bool -> int32) = System.Convert.ToInt32
    let v358 : int32 = v357 v356
    let v359 : string = method22()
    let v360 : (string -> string) = v353.ToString
    let v361 : string = v360 v359
    let v362 : string = $"{v358}{v361}"
    struct (v322, v362)
#endif
    |> fun x -> _v231 <- Some x
    let struct (v363 : string, v364 : string) = _v231.Value
    let v365 : System.Guid = System.Guid $"{v363}{v364}{v230.[v363.Length + v364.Length..]}"
    let v366 : (System.Guid -> string) = _.ToString()
    let v367 : string = v366 v365
    let v368 : string = method15(v226, v367)
    v368
#endif
    |> fun x -> _v0 <- Some x
    let v369 : string = _v0.Value
    v369
and method23 (v0 : string) : string =
    v0
and closure39 () (v0 : std_io_Error) : std_string_String =
    let v1 : std_string_String option = None
    let v2 : bool = true in let mutable _v1 = v1
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : string = @$"format!(""{{}}"", $0)"
    let v4 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v3
    v4
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v5 : string = @$"format!(""{{}}"", $0)"
    let v6 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v5
    v6
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v7 : string = @$"format!(""{{}}"", $0)"
    let v8 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v7
    v8
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v9 : std_string_String = null |> unbox<std_string_String>
    v9
#endif
    
#if FABLE_COMPILER_PYTHON
    let v10 : std_string_String = null |> unbox<std_string_String>
    v10
#endif
    
#else
    let v11 : std_string_String = null |> unbox<std_string_String>
    v11
#endif
    |> fun x -> _v1 <- Some x
    let v12 : std_string_String = _v1.Value
    v12
and method24 () : (std_io_Error -> std_string_String) =
    closure39()
and closure40 () () : US10 =
    US10_0
and closure41 () (v0 : std_string_String) : US10 =
    US10_1(v0)
and closure42 () () : string =
    let v0 : string = "file_system.create_directory"
    v0
and closure43 (v0 : string, v1 : std_string_String) () : string =
    let v2 : (unit -> string) = closure6()
    let v3 : string = $"dir: {v0} / error: {v1} / {v2 ()}"
    v3
and closure44 () () : string =
    let v0 : string = "file_system.create_directory"
    v0
and closure45 (v0 : string) () : string =
    let v1 : (unit -> string) = closure6()
    let v2 : string = $"dir: {v0} / {v1 ()}"
    v2
and closure46 (v0 : string) () : unit =
    let v1 : unit option = None
    let v2 : bool = true in let mutable _v1 = v1
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : string = method3(v0)
    let v4 : bool option = None
    let v5 : bool = true in let mutable _v4 = v4
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v6 : string = method4(v3)
    let v7 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v8 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v7
    let v9 : string = "String::from($0)"
    let v10 : std_string_String = Fable.Core.RustInterop.emitRustExpr v8 v9
    let v11 : string = "std::path::PathBuf::from($0)"
    let v12 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v10 v11
    let v13 : string = "$0.exists()"
    let v14 : bool = Fable.Core.RustInterop.emitRustExpr v12 v13
    let v17 : bool =
        if v14 then
            let v15 : string = "$0.is_dir()"
            let v16 : bool = Fable.Core.RustInterop.emitRustExpr v12 v15
            v16
        else
            false
    v17
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v18 : bool = null |> unbox<bool>
    v18
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v19 : bool = null |> unbox<bool>
    v19
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v20 : string = "fs"
    let v21 : IFsExistsSync = Fable.Core.JsInterop.importAll v20
    let v22 : string = "$0.existsSync($1)"
    let v23 : bool = Fable.Core.JsInterop.emitJsExpr struct (v21, v3) v22
    v23
#endif
    
#if FABLE_COMPILER_PYTHON
    let v24 : bool = null |> unbox<bool>
    v24
#endif
    
#else
    let v25 : (string -> bool) = System.IO.Directory.Exists
    let v26 : bool = v25 v3
    v26
#endif
    |> fun x -> _v4 <- Some x
    let v27 : bool = _v4.Value
    if v27 then
        let v28 : string = "std::fs::remove_dir_all(&*$0).unwrap()"
        Fable.Core.RustInterop.emitRustExpr v3 v28
        ()
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
    
#if FABLE_COMPILER_TYPESCRIPT
    null |> unbox<unit>
    ()
#endif
    
#if FABLE_COMPILER_PYTHON
    null |> unbox<unit>
    ()
#endif
    
#else
    System.IO.Directory.Delete (v0, true)
    ()
#endif
    |> fun x -> _v1 <- Some x
    _v1.Value
    ()
and method25 (v0 : string) : (unit -> unit) =
    closure46(v0)
and closure47 () () : string =
    let v0 : string = "file_system.create_directory"
    v0
and closure48 (v0 : string, v1 : string) () : string =
    let v2 : (unit -> string) = closure6()
    let v3 : string = $"dir: {v0} / result: {v1} {v2 ()}"
    v3
and closure49 (v0 : string) () : unit =
    let v1 : Async<int64> option = None
    let v2 : bool = true in let mutable _v1 = v1
    
#if FABLE_COMPILER || WASM || CONTRACT
    
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
    
#if FABLE_COMPILER_TYPESCRIPT
    let v6 : Async<int64> = null |> unbox<Async<int64>>
    v6
#endif
    
#if FABLE_COMPILER_PYTHON
    let v7 : Async<int64> = null |> unbox<Async<int64>>
    v7
#endif
    
#else
    let v8 : int64 = 0L
    let v9 : Async<int64> = method2(v0, v8)
    v9
#endif
    |> fun x -> _v1 <- Some x
    let v10 : Async<int64> = _v1.Value
    let v11 : Async<unit> option = None
    let v12 : bool = true in let mutable _v11 = v11
    
#if FABLE_COMPILER || WASM || CONTRACT
    
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
    
#if FABLE_COMPILER_TYPESCRIPT
    let v16 : Async<unit> = null |> unbox<Async<unit>>
    v16
#endif
    
#if FABLE_COMPILER_PYTHON
    let v17 : Async<unit> = null |> unbox<Async<unit>>
    v17
#endif
    
#else
    let v18 : (Async<int64> -> Async<unit>) = Async.Ignore
    let v19 : Async<unit> = v18 v10
    v19
#endif
    |> fun x -> _v11 <- Some x
    let v20 : Async<unit> = _v11.Value
    let v21 : unit option = None
    let v22 : bool = true in let mutable _v21 = v21
    
#if FABLE_COMPILER || WASM || CONTRACT
    
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
    
#if FABLE_COMPILER_TYPESCRIPT
    null |> unbox<unit>
    ()
#endif
    
#if FABLE_COMPILER_PYTHON
    null |> unbox<unit>
    ()
#endif
    
#else
    let v23 : (Async<unit> -> unit) = Async.RunSynchronously
    v23 v20
    ()
#endif
    |> fun x -> _v21 <- Some x
    _v21.Value
    ()
and method26 (v0 : string) : (unit -> unit) =
    closure49(v0)
and closure38 () () : struct (string * System.IDisposable) =
    let v0 : string option = None
    let v1 : bool = true in let mutable _v0 = v0
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string option = None
    let v3 : bool = true in let mutable _v2 = v2
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v4 : string = "env!(\"CARGO_PKG_NAME\").into()"
    let v5 : string = Fable.Core.RustInterop.emitRustExpr () v4
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
    
#if FABLE_COMPILER_TYPESCRIPT
    let v8 : string = null |> unbox<string>
    v8
#endif
    
#if FABLE_COMPILER_PYTHON
    let v9 : string = null |> unbox<string>
    v9
#endif
    
#else
    let v10 : string = System.Reflection.Assembly.GetEntryAssembly().GetName().Name
    v10
#endif
    |> fun x -> _v2 <- Some x
    let v11 : string = _v2.Value
    let v12 : string option = None
    let v13 : bool = true in let mutable _v12 = v12
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v14 : string = "std::env::temp_dir()"
    let v15 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr () v14
    let v16 : string = "$0.display()"
    let v17 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v15 v16
    let v18 : std_string_String option = None
    let v19 : bool = true in let mutable _v18 = v18
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v20 : string = @$"format!(""{{}}"", $0)"
    let v21 : std_string_String = Fable.Core.RustInterop.emitRustExpr v17 v20
    v21
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v22 : string = @$"format!(""{{}}"", $0)"
    let v23 : std_string_String = Fable.Core.RustInterop.emitRustExpr v17 v22
    v23
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v24 : string = @$"format!(""{{}}"", $0)"
    let v25 : std_string_String = Fable.Core.RustInterop.emitRustExpr v17 v24
    v25
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v26 : std_string_String = null |> unbox<std_string_String>
    v26
#endif
    
#if FABLE_COMPILER_PYTHON
    let v27 : std_string_String = null |> unbox<std_string_String>
    v27
#endif
    
#else
    let v28 : std_string_String = null |> unbox<std_string_String>
    v28
#endif
    |> fun x -> _v18 <- Some x
    let v29 : std_string_String = _v18.Value
    let v30 : string = "fable_library_rust::String_::fromString($0)"
    let v31 : string = Fable.Core.RustInterop.emitRustExpr v29 v30
    v31
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v32 : string = null |> unbox<string>
    v32
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v33 : string = null |> unbox<string>
    v33
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v34 : string = null |> unbox<string>
    v34
#endif
    
#if FABLE_COMPILER_PYTHON
    let v35 : string = null |> unbox<string>
    v35
#endif
    
#else
    let v36 : (unit -> string) = System.IO.Path.GetTempPath
    let v37 : string = v36 ()
    v37
#endif
    |> fun x -> _v12 <- Some x
    let v38 : string = _v12.Value
    let v39 : string = $"!{v11}"
    let v40 : string = method15(v38, v39)
    let v41 : System.DateTime = System.DateTime.Now
    let v42 : System.Guid = System.Guid.NewGuid ()
    let v43 : (System.Guid -> string) = _.ToString()
    let v44 : string = v43 v42
    let v45 : struct (string * string) option = None
    let v46 : bool = true in let mutable _v45 = v45
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v47 : System.DateTime = System.DateTime (1970, 1, 1, 0, 0, 0, System.DateTimeKind.Utc)
    let v48 : (System.DateTime -> System.DateTime) = _.ToUniversalTime()
    let v49 : System.DateTime = v48 v47
    let v50 : System.DateTimeKind = System.DateTimeKind.Local
    let v51 : System.DateTime = System.DateTime.SpecifyKind (v41, v50)
    let v52 : (System.DateTime -> System.DateTime) = _.ToUniversalTime()
    let v53 : System.DateTime = v52 v51
    let v54 : (System.DateTime -> int64) = _.Ticks
    let v55 : int64 = v54 v53
    let v56 : (System.DateTime -> int64) = _.Ticks
    let v57 : int64 = v56 v49
    let v58 : int64 = v55 - v57
    let v59 : int64 = v58 / 10L
    let v60 : string = "chrono::DateTime::from_timestamp_micros($0)"
    let v61 : chrono_DateTime<chrono_Utc> option = Fable.Core.RustInterop.emitRustExpr v59 v60
    let v62 : (chrono_DateTime<chrono_Utc> -> US8) = method18()
    let v63 : US8 = US8_1
    let v64 : US8 = v61 |> Option.map v62 |> Option.defaultValue v63 
    let v83 : US9 =
        match v64 with
        | US8_1 -> (* None *)
            US9_1
        | US8_0(v65) -> (* Some *)
            let v66 : chrono_DateTime<chrono_Utc> = method19(v65)
            let v67 : string = "v66.naive_utc()"
            let v68 : chrono_NaiveDateTime = Fable.Core.RustInterop.emitRustExpr () v67
            let v69 : string = "chrono::offset::TimeZone::from_utc_datetime(&chrono::Local, &v68)"
            let v70 : chrono_DateTime<chrono_Local> = Fable.Core.RustInterop.emitRustExpr () v69
            let v71 : string = "%Y%m%d-%H%M-%S%f"
            let v72 : string = "r#\"" + v71 + "\"#"
            let v73 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v72
            let v74 : chrono_DateTime<chrono_Local> = method20(v70)
            let v75 : string = "v74.format(v73).to_string()"
            let v76 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v75
            let v77 : string = "fable_library_rust::String_::fromString($0)"
            let v78 : string = Fable.Core.RustInterop.emitRustExpr v76 v77
            let v79 : string = $"{v78.[0..17]}-{v78.[18..21]}-{v78.[22]}"
            US9_0(v79)
    let v87 : string =
        match v83 with
        | US9_1 -> (* None *)
            let v85 : string = ""
            v85
        | US9_0(v84) -> (* Some *)
            v84
    let v88 : System.TimeZoneInfo option = None
    let v89 : bool = true in let mutable _v88 = v88
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v90 : string = "0i64.into()"
    let v91 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v90
    v91
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v92 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v92
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v93 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v93
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v94 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v94
#endif
    
#if FABLE_COMPILER_PYTHON
    let v95 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v95
#endif
    
#else
    let v96 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    v96
#endif
    |> fun x -> _v88 <- Some x
    let v97 : System.TimeZoneInfo = _v88.Value
    let v98 : System.TimeSpan option = None
    let v99 : bool = true in let mutable _v98 = v98
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v100 : System.TimeSpan = System.TimeSpan () 
    v100
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v101 : System.TimeSpan = System.TimeSpan () 
    v101
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v102 : System.TimeSpan = System.TimeSpan () 
    v102
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v103 : System.TimeSpan = System.TimeSpan () 
    v103
#endif
    
#if FABLE_COMPILER_PYTHON
    let v104 : System.TimeSpan = System.TimeSpan () 
    v104
#endif
    
#else
    let v105 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v106 : System.TimeZoneInfo option = None
    let v107 : bool = true in let mutable _v106 = v106
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v108 : string = "0i64.into()"
    let v109 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v108
    v109
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v110 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v110
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v111 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v111
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v112 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v112
#endif
    
#if FABLE_COMPILER_PYTHON
    let v113 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v113
#endif
    
#else
    let v114 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    v114
#endif
    |> fun x -> _v106 <- Some x
    let v115 : System.TimeZoneInfo = _v106.Value
    let v116 : (System.DateTime -> System.TimeSpan) = v105 v115
    let v117 : System.TimeSpan = v116 v53
    v117
#endif
    |> fun x -> _v98 <- Some x
    let v118 : System.TimeSpan = _v98.Value
    let v119 : (System.TimeSpan -> int32) = _.Hours
    let v120 : int32 = v119 v118
    let v121 : bool = v120 > 0
    let v122 : uint8 =
        if v121 then
            1uy
        else
            0uy
    let v123 : (string -> string) = v118.ToString
    let v124 : string = "hh:mm"
    let v125 : string = v123 v124
    let v126 : string = $"{v122}{v125.[0..1]}{v125.[3..4]}"
    struct (v87, v126)
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let struct (v127 : string, v128 : string) = null |> unbox<struct (string * string)>
    struct (v127, v128)
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let struct (v129 : string, v130 : string) = null |> unbox<struct (string * string)>
    struct (v129, v130)
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let struct (v131 : string, v132 : string) = null |> unbox<struct (string * string)>
    struct (v131, v132)
#endif
    
#if FABLE_COMPILER_PYTHON
    let struct (v133 : string, v134 : string) = null |> unbox<struct (string * string)>
    struct (v133, v134)
#endif
    
#else
    let v135 : string = method21()
    let v136 : (string -> string) = v41.ToString
    let v137 : string = v136 v135
    let v138 : System.TimeZoneInfo option = None
    let v139 : bool = true in let mutable _v138 = v138
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v140 : string = "0i64.into()"
    let v141 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v140
    v141
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v142 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v142
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v143 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v143
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v144 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v144
#endif
    
#if FABLE_COMPILER_PYTHON
    let v145 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v145
#endif
    
#else
    let v146 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    v146
#endif
    |> fun x -> _v138 <- Some x
    let v147 : System.TimeZoneInfo = _v138.Value
    let v148 : System.TimeSpan option = None
    let v149 : bool = true in let mutable _v148 = v148
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v150 : System.TimeSpan = System.TimeSpan () 
    v150
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v151 : System.TimeSpan = System.TimeSpan () 
    v151
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v152 : System.TimeSpan = System.TimeSpan () 
    v152
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v153 : System.TimeSpan = System.TimeSpan () 
    v153
#endif
    
#if FABLE_COMPILER_PYTHON
    let v154 : System.TimeSpan = System.TimeSpan () 
    v154
#endif
    
#else
    let v155 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v156 : System.TimeZoneInfo option = None
    let v157 : bool = true in let mutable _v156 = v156
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v158 : string = "0i64.into()"
    let v159 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v158
    v159
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v160 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v160
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v161 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v161
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v162 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v162
#endif
    
#if FABLE_COMPILER_PYTHON
    let v163 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v163
#endif
    
#else
    let v164 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    v164
#endif
    |> fun x -> _v156 <- Some x
    let v165 : System.TimeZoneInfo = _v156.Value
    let v166 : (System.DateTime -> System.TimeSpan) = v155 v165
    let v167 : System.TimeSpan = v166 v41
    v167
#endif
    |> fun x -> _v148 <- Some x
    let v168 : System.TimeSpan = _v148.Value
    let v169 : (System.TimeSpan -> int32) = _.Hours
    let v170 : int32 = v169 v168
    let v171 : bool = v170 > 0
    let v172 : (bool -> int32) = System.Convert.ToInt32
    let v173 : int32 = v172 v171
    let v174 : string = method22()
    let v175 : (string -> string) = v168.ToString
    let v176 : string = v175 v174
    let v177 : string = $"{v173}{v176}"
    struct (v137, v177)
#endif
    |> fun x -> _v45 <- Some x
    let struct (v178 : string, v179 : string) = _v45.Value
    let v180 : System.Guid = System.Guid $"{v178}{v179}{v44.[v178.Length + v179.Length..]}"
    let v181 : (System.Guid -> string) = _.ToString()
    let v182 : string = v181 v180
    let v183 : string = method15(v40, v182)
    v183
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v184 : string = null |> unbox<string>
    v184
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v185 : string = null |> unbox<string>
    v185
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v186 : string = null |> unbox<string>
    v186
#endif
    
#if FABLE_COMPILER_PYTHON
    let v187 : string = null |> unbox<string>
    v187
#endif
    
#else
    let v188 : string option = None
    let v189 : bool = true in let mutable _v188 = v188
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v190 : string = "env!(\"CARGO_PKG_NAME\").into()"
    let v191 : string = Fable.Core.RustInterop.emitRustExpr () v190
    v191
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v192 : string = null |> unbox<string>
    v192
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v193 : string = null |> unbox<string>
    v193
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v194 : string = null |> unbox<string>
    v194
#endif
    
#if FABLE_COMPILER_PYTHON
    let v195 : string = null |> unbox<string>
    v195
#endif
    
#else
    let v196 : string = System.Reflection.Assembly.GetEntryAssembly().GetName().Name
    v196
#endif
    |> fun x -> _v188 <- Some x
    let v197 : string = _v188.Value
    let v198 : string option = None
    let v199 : bool = true in let mutable _v198 = v198
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v200 : string = "std::env::temp_dir()"
    let v201 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr () v200
    let v202 : string = "$0.display()"
    let v203 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v201 v202
    let v204 : std_string_String option = None
    let v205 : bool = true in let mutable _v204 = v204
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v206 : string = @$"format!(""{{}}"", $0)"
    let v207 : std_string_String = Fable.Core.RustInterop.emitRustExpr v203 v206
    v207
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v208 : string = @$"format!(""{{}}"", $0)"
    let v209 : std_string_String = Fable.Core.RustInterop.emitRustExpr v203 v208
    v209
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v210 : string = @$"format!(""{{}}"", $0)"
    let v211 : std_string_String = Fable.Core.RustInterop.emitRustExpr v203 v210
    v211
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v212 : std_string_String = null |> unbox<std_string_String>
    v212
#endif
    
#if FABLE_COMPILER_PYTHON
    let v213 : std_string_String = null |> unbox<std_string_String>
    v213
#endif
    
#else
    let v214 : std_string_String = null |> unbox<std_string_String>
    v214
#endif
    |> fun x -> _v204 <- Some x
    let v215 : std_string_String = _v204.Value
    let v216 : string = "fable_library_rust::String_::fromString($0)"
    let v217 : string = Fable.Core.RustInterop.emitRustExpr v215 v216
    v217
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v218 : string = null |> unbox<string>
    v218
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v219 : string = null |> unbox<string>
    v219
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v220 : string = null |> unbox<string>
    v220
#endif
    
#if FABLE_COMPILER_PYTHON
    let v221 : string = null |> unbox<string>
    v221
#endif
    
#else
    let v222 : (unit -> string) = System.IO.Path.GetTempPath
    let v223 : string = v222 ()
    v223
#endif
    |> fun x -> _v198 <- Some x
    let v224 : string = _v198.Value
    let v225 : string = $"!{v197}"
    let v226 : string = method15(v224, v225)
    let v227 : System.DateTime = System.DateTime.Now
    let v228 : System.Guid = System.Guid.NewGuid ()
    let v229 : (System.Guid -> string) = _.ToString()
    let v230 : string = v229 v228
    let v231 : struct (string * string) option = None
    let v232 : bool = true in let mutable _v231 = v231
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v233 : System.DateTime = System.DateTime (1970, 1, 1, 0, 0, 0, System.DateTimeKind.Utc)
    let v234 : (System.DateTime -> System.DateTime) = _.ToUniversalTime()
    let v235 : System.DateTime = v234 v233
    let v236 : System.DateTimeKind = System.DateTimeKind.Local
    let v237 : System.DateTime = System.DateTime.SpecifyKind (v227, v236)
    let v238 : (System.DateTime -> System.DateTime) = _.ToUniversalTime()
    let v239 : System.DateTime = v238 v237
    let v240 : (System.DateTime -> int64) = _.Ticks
    let v241 : int64 = v240 v239
    let v242 : (System.DateTime -> int64) = _.Ticks
    let v243 : int64 = v242 v235
    let v244 : int64 = v241 - v243
    let v245 : int64 = v244 / 10L
    let v246 : string = "chrono::DateTime::from_timestamp_micros($0)"
    let v247 : chrono_DateTime<chrono_Utc> option = Fable.Core.RustInterop.emitRustExpr v245 v246
    let v248 : (chrono_DateTime<chrono_Utc> -> US8) = method18()
    let v249 : US8 = US8_1
    let v250 : US8 = v247 |> Option.map v248 |> Option.defaultValue v249 
    let v269 : US9 =
        match v250 with
        | US8_1 -> (* None *)
            US9_1
        | US8_0(v251) -> (* Some *)
            let v252 : chrono_DateTime<chrono_Utc> = method19(v251)
            let v253 : string = "v252.naive_utc()"
            let v254 : chrono_NaiveDateTime = Fable.Core.RustInterop.emitRustExpr () v253
            let v255 : string = "chrono::offset::TimeZone::from_utc_datetime(&chrono::Local, &v254)"
            let v256 : chrono_DateTime<chrono_Local> = Fable.Core.RustInterop.emitRustExpr () v255
            let v257 : string = "%Y%m%d-%H%M-%S%f"
            let v258 : string = "r#\"" + v257 + "\"#"
            let v259 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v258
            let v260 : chrono_DateTime<chrono_Local> = method20(v256)
            let v261 : string = "v260.format(v259).to_string()"
            let v262 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v261
            let v263 : string = "fable_library_rust::String_::fromString($0)"
            let v264 : string = Fable.Core.RustInterop.emitRustExpr v262 v263
            let v265 : string = $"{v264.[0..17]}-{v264.[18..21]}-{v264.[22]}"
            US9_0(v265)
    let v273 : string =
        match v269 with
        | US9_1 -> (* None *)
            let v271 : string = ""
            v271
        | US9_0(v270) -> (* Some *)
            v270
    let v274 : System.TimeZoneInfo option = None
    let v275 : bool = true in let mutable _v274 = v274
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v276 : string = "0i64.into()"
    let v277 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v276
    v277
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v278 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v278
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v279 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v279
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v280 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v280
#endif
    
#if FABLE_COMPILER_PYTHON
    let v281 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v281
#endif
    
#else
    let v282 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    v282
#endif
    |> fun x -> _v274 <- Some x
    let v283 : System.TimeZoneInfo = _v274.Value
    let v284 : System.TimeSpan option = None
    let v285 : bool = true in let mutable _v284 = v284
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v286 : System.TimeSpan = System.TimeSpan () 
    v286
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v287 : System.TimeSpan = System.TimeSpan () 
    v287
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v288 : System.TimeSpan = System.TimeSpan () 
    v288
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v289 : System.TimeSpan = System.TimeSpan () 
    v289
#endif
    
#if FABLE_COMPILER_PYTHON
    let v290 : System.TimeSpan = System.TimeSpan () 
    v290
#endif
    
#else
    let v291 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v292 : System.TimeZoneInfo option = None
    let v293 : bool = true in let mutable _v292 = v292
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v294 : string = "0i64.into()"
    let v295 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v294
    v295
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v296 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v296
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v297 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v297
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v298 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v298
#endif
    
#if FABLE_COMPILER_PYTHON
    let v299 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v299
#endif
    
#else
    let v300 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    v300
#endif
    |> fun x -> _v292 <- Some x
    let v301 : System.TimeZoneInfo = _v292.Value
    let v302 : (System.DateTime -> System.TimeSpan) = v291 v301
    let v303 : System.TimeSpan = v302 v239
    v303
#endif
    |> fun x -> _v284 <- Some x
    let v304 : System.TimeSpan = _v284.Value
    let v305 : (System.TimeSpan -> int32) = _.Hours
    let v306 : int32 = v305 v304
    let v307 : bool = v306 > 0
    let v308 : uint8 =
        if v307 then
            1uy
        else
            0uy
    let v309 : (string -> string) = v304.ToString
    let v310 : string = v309 v124
    let v311 : string = $"{v308}{v310.[0..1]}{v310.[3..4]}"
    struct (v273, v311)
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let struct (v312 : string, v313 : string) = null |> unbox<struct (string * string)>
    struct (v312, v313)
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let struct (v314 : string, v315 : string) = null |> unbox<struct (string * string)>
    struct (v314, v315)
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let struct (v316 : string, v317 : string) = null |> unbox<struct (string * string)>
    struct (v316, v317)
#endif
    
#if FABLE_COMPILER_PYTHON
    let struct (v318 : string, v319 : string) = null |> unbox<struct (string * string)>
    struct (v318, v319)
#endif
    
#else
    let v320 : string = method21()
    let v321 : (string -> string) = v227.ToString
    let v322 : string = v321 v320
    let v323 : System.TimeZoneInfo option = None
    let v324 : bool = true in let mutable _v323 = v323
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v325 : string = "0i64.into()"
    let v326 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v325
    v326
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v327 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v327
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v328 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v328
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v329 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v329
#endif
    
#if FABLE_COMPILER_PYTHON
    let v330 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v330
#endif
    
#else
    let v331 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    v331
#endif
    |> fun x -> _v323 <- Some x
    let v332 : System.TimeZoneInfo = _v323.Value
    let v333 : System.TimeSpan option = None
    let v334 : bool = true in let mutable _v333 = v333
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v335 : System.TimeSpan = System.TimeSpan () 
    v335
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v336 : System.TimeSpan = System.TimeSpan () 
    v336
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v337 : System.TimeSpan = System.TimeSpan () 
    v337
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v338 : System.TimeSpan = System.TimeSpan () 
    v338
#endif
    
#if FABLE_COMPILER_PYTHON
    let v339 : System.TimeSpan = System.TimeSpan () 
    v339
#endif
    
#else
    let v340 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v341 : System.TimeZoneInfo option = None
    let v342 : bool = true in let mutable _v341 = v341
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v343 : string = "0i64.into()"
    let v344 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v343
    v344
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v345 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v345
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v346 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v346
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v347 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v347
#endif
    
#if FABLE_COMPILER_PYTHON
    let v348 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v348
#endif
    
#else
    let v349 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    v349
#endif
    |> fun x -> _v341 <- Some x
    let v350 : System.TimeZoneInfo = _v341.Value
    let v351 : (System.DateTime -> System.TimeSpan) = v340 v350
    let v352 : System.TimeSpan = v351 v227
    v352
#endif
    |> fun x -> _v333 <- Some x
    let v353 : System.TimeSpan = _v333.Value
    let v354 : (System.TimeSpan -> int32) = _.Hours
    let v355 : int32 = v354 v353
    let v356 : bool = v355 > 0
    let v357 : (bool -> int32) = System.Convert.ToInt32
    let v358 : int32 = v357 v356
    let v359 : string = method22()
    let v360 : (string -> string) = v353.ToString
    let v361 : string = v360 v359
    let v362 : string = $"{v358}{v361}"
    struct (v322, v362)
#endif
    |> fun x -> _v231 <- Some x
    let struct (v363 : string, v364 : string) = _v231.Value
    let v365 : System.Guid = System.Guid $"{v363}{v364}{v230.[v363.Length + v364.Length..]}"
    let v366 : (System.Guid -> string) = _.ToString()
    let v367 : string = v366 v365
    let v368 : string = method15(v226, v367)
    v368
#endif
    |> fun x -> _v0 <- Some x
    let v369 : string = _v0.Value
    let v370 : System.IDisposable option = None
    let v371 : bool = true in let mutable _v370 = v370
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v372 : string = method23(v369)
    let v373 : string = "std::fs::create_dir_all(&*$0)"
    let v374 : Result<unit, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v372 v373
    let v375 : (std_io_Error -> std_string_String) = method24()
    let v376 : string = "$0.map_err(|x| $1(x))"
    let v377 : Result<unit, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v374, v375) v376
    let v378 : (unit -> US10) = closure40()
    let v379 : (std_string_String -> US10) = closure41()
    let v380 : US10 = match v377 with Ok () -> v378 () | Error x -> v379 x
    match v380 with
    | US10_1(v384) -> (* Error *)
        let v385 : US0 = US0_4
        let v386 : (unit -> string) = closure42()
        let v387 : (unit -> string) = closure43(v372, v384)
        method5(v385, v386, v387)
    | US10_0 -> (* Ok *)
        let v381 : US0 = US0_0
        let v382 : (unit -> string) = closure44()
        let v383 : (unit -> string) = closure45(v372)
        method5(v381, v382, v383)
    let v388 : System.IDisposable option = None
    let v389 : bool = true in let mutable _v388 = v388
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v390 : (unit -> unit) = closure46(v372)
    let v391 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v390 "$0()" )
    v391
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v392 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v390 "$0()" )
    v392
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v393 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v390 "$0()" )
    v393
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v394 : System.IDisposable = null |> unbox<System.IDisposable>
    v394
#endif
    
#if FABLE_COMPILER_PYTHON
    let v395 : System.IDisposable = null |> unbox<System.IDisposable>
    v395
#endif
    
#else
    let v396 : (unit -> unit) = method25(v372)
    let v397 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v396 () }
    v397
#endif
    |> fun x -> _v388 <- Some x
    let v398 : System.IDisposable = _v388.Value
    v398
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v399 : System.IDisposable = null |> unbox<System.IDisposable>
    v399
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v400 : System.IDisposable = null |> unbox<System.IDisposable>
    v400
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v401 : System.IDisposable = null |> unbox<System.IDisposable>
    v401
#endif
    
#if FABLE_COMPILER_PYTHON
    let v402 : System.IDisposable = null |> unbox<System.IDisposable>
    v402
#endif
    
#else
    let v403 : System.IO.DirectoryInfo option = None
    let v404 : bool = true in let mutable _v403 = v403
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v405 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    v405
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v406 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    v406
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v407 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    v407
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v408 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    v408
#endif
    
#if FABLE_COMPILER_PYTHON
    let v409 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    v409
#endif
    
#else
    let v410 : (string -> System.IO.DirectoryInfo) = System.IO.Directory.CreateDirectory
    let v411 : System.IO.DirectoryInfo = v410 v369
    v411
#endif
    |> fun x -> _v403 <- Some x
    let v412 : System.IO.DirectoryInfo = _v403.Value
    let v413 : bool option = None
    let v414 : bool = true in let mutable _v413 = v413
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v415 : bool = null |> unbox<bool>
    v415
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v416 : bool = null |> unbox<bool>
    v416
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v417 : bool = null |> unbox<bool>
    v417
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v418 : bool = null |> unbox<bool>
    v418
#endif
    
#if FABLE_COMPILER_PYTHON
    let v419 : bool = null |> unbox<bool>
    v419
#endif
    
#else
    let v420 : bool = v412.Exists
    v420
#endif
    |> fun x -> _v413 <- Some x
    let v421 : bool = _v413.Value
    let v422 : bool = v421 = false
    if v422 then
        let v423 : System.DateTime option = None
        let v424 : bool = true in let mutable _v423 = v423
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v425 : System.DateTime = null |> unbox<System.DateTime>
        v425
#endif
        
#if FABLE_COMPILER_RUST && WASM
        let v426 : System.DateTime = null |> unbox<System.DateTime>
        v426
#endif
        
#if FABLE_COMPILER_RUST && CONTRACT
        let v427 : System.DateTime = null |> unbox<System.DateTime>
        v427
#endif
        
#if FABLE_COMPILER_TYPESCRIPT
        let v428 : System.DateTime = null |> unbox<System.DateTime>
        v428
#endif
        
#if FABLE_COMPILER_PYTHON
        let v429 : System.DateTime = null |> unbox<System.DateTime>
        v429
#endif
        
#else
        let v430 : System.DateTime = v412.CreationTime
        v430
#endif
        |> fun x -> _v423 <- Some x
        let v431 : System.DateTime = _v423.Value
        let v432 : obj = {| Exists = v421; CreationTime = v431 |}
        let v433 : string = $"%A{v432}"
        let v434 : US0 = US0_1
        let v435 : (unit -> string) = closure47()
        let v436 : (unit -> string) = closure48(v369, v433)
        method5(v434, v435, v436)
    let v437 : System.IDisposable option = None
    let v438 : bool = true in let mutable _v437 = v437
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v439 : (unit -> unit) = closure49(v369)
    let v440 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v439 "$0()" )
    v440
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v441 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v439 "$0()" )
    v441
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v442 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v439 "$0()" )
    v442
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v443 : System.IDisposable = null |> unbox<System.IDisposable>
    v443
#endif
    
#if FABLE_COMPILER_PYTHON
    let v444 : System.IDisposable = null |> unbox<System.IDisposable>
    v444
#endif
    
#else
    let v445 : (unit -> unit) = method26(v369)
    let v446 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v445 () }
    v446
#endif
    |> fun x -> _v437 <- Some x
    let v447 : System.IDisposable = _v437.Value
    v447
#endif
    |> fun x -> _v370 <- Some x
    let v448 : System.IDisposable = _v370.Value
    struct (v369, v448)
and closure50 () () : string =
    let v0 : string = __SOURCE_DIRECTORY__
    v0
and closure54 () (v0 : string) : bool =
    let v1 : bool option = None
    let v2 : bool = true in let mutable _v1 = v1
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : string = method4(v0)
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
    
#if FABLE_COMPILER_TYPESCRIPT
    let v17 : string = "fs"
    let v18 : IFsExistsSync = Fable.Core.JsInterop.importAll v17
    let v19 : string = "$0.existsSync($1)"
    let v20 : bool = Fable.Core.JsInterop.emitJsExpr struct (v18, v0) v19
    v20
#endif
    
#if FABLE_COMPILER_PYTHON
    let v21 : bool = null |> unbox<bool>
    v21
#endif
    
#else
    let v22 : (string -> bool) = System.IO.File.Exists
    let v23 : bool = v22 v0
    v23
#endif
    |> fun x -> _v1 <- Some x
    let v24 : bool = _v1.Value
    v24
and closure55 () (v0 : string) : bool =
    let v1 : bool option = None
    let v2 : bool = true in let mutable _v1 = v1
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : string = method4(v0)
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
    
#if FABLE_COMPILER_TYPESCRIPT
    let v17 : string = "fs"
    let v18 : IFsExistsSync = Fable.Core.JsInterop.importAll v17
    let v19 : string = "$0.existsSync($1)"
    let v20 : bool = Fable.Core.JsInterop.emitJsExpr struct (v18, v0) v19
    v20
#endif
    
#if FABLE_COMPILER_PYTHON
    let v21 : bool = null |> unbox<bool>
    v21
#endif
    
#else
    let v22 : (string -> bool) = System.IO.Directory.Exists
    let v23 : bool = v22 v0
    v23
#endif
    |> fun x -> _v1 <- Some x
    let v24 : bool = _v1.Value
    v24
and closure56 () (v0 : string) : string option =
    let v1 : US9 option = None
    let v2 : bool = true in let mutable _v1 = v1
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : string = method4(v0)
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
    let v14 : string = "$0.display()"
    let v15 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v13 v14
    let v16 : std_string_String option = None
    let v17 : bool = true in let mutable _v16 = v16
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v18 : string = @$"format!(""{{}}"", $0)"
    let v19 : std_string_String = Fable.Core.RustInterop.emitRustExpr v15 v18
    v19
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v20 : string = @$"format!(""{{}}"", $0)"
    let v21 : std_string_String = Fable.Core.RustInterop.emitRustExpr v15 v20
    v21
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v22 : string = @$"format!(""{{}}"", $0)"
    let v23 : std_string_String = Fable.Core.RustInterop.emitRustExpr v15 v22
    v23
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v24 : std_string_String = null |> unbox<std_string_String>
    v24
#endif
    
#if FABLE_COMPILER_PYTHON
    let v25 : std_string_String = null |> unbox<std_string_String>
    v25
#endif
    
#else
    let v26 : std_string_String = null |> unbox<std_string_String>
    v26
#endif
    |> fun x -> _v16 <- Some x
    let v27 : std_string_String = _v16.Value
    let v28 : string = "fable_library_rust::String_::fromString($0)"
    let v29 : string = Fable.Core.RustInterop.emitRustExpr v27 v28
    let v30 : US9 = US9_0(v29)
    v30
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v31 : US9 = null |> unbox<US9>
    v31
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v32 : US9 = null |> unbox<US9>
    v32
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v33 : string = "path"
    let v34 : IPathDirname = Fable.Core.JsInterop.importAll v33
    let v35 : string = "v34.dirname($0)"
    let v36 : string = Fable.Core.JsInterop.emitJsExpr v0 v35
    let v37 : US9 = US9_0(v36)
    v37
#endif
    
#if FABLE_COMPILER_PYTHON
    let v38 : US9 = null |> unbox<US9>
    v38
#endif
    
#else
    let v39 : (string -> System.IO.DirectoryInfo) = System.IO.Directory.GetParent
    let v40 : System.IO.DirectoryInfo = v39 v0
    let v41 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    let v42 : bool = v40 = v41
    let v54 : US9 =
        if v42 then
            US9_1
        else
            let v44 : string option = None
            let v45 : bool = true in let mutable _v44 = v44
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v46 : string = null |> unbox<string>
            v46
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v47 : string = null |> unbox<string>
            v47
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v48 : string = null |> unbox<string>
            v48
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v49 : string = null |> unbox<string>
            v49
#endif
            
#if FABLE_COMPILER_PYTHON
            let v50 : string = null |> unbox<string>
            v50
#endif
            
#else
            let v51 : string = v40.FullName
            v51
#endif
            |> fun x -> _v44 <- Some x
            let v52 : string = _v44.Value
            US9_0(v52)
    v54
#endif
    |> fun x -> _v1 <- Some x
    let v55 : US9 = _v1.Value
    match v55 with
    | US9_1 -> (* None *)
        let v58 : string option = None
        v58
    | US9_0(v56) -> (* Some *)
        let v57 : string option = Some v56 
        v57
and method28 () : (string -> string option) =
    closure56()
and closure57 () (v0 : string) : US9 =
    US9_0(v0)
and method29 () : (string -> US9) =
    closure57()
and method30 (v0 : string, v1 : bool, v2 : string, v3 : string) : string =
    let v4 : string = method15(v3, v0)
    let v7 : (string -> bool) =
        if v1 then
            closure54()
        else
            closure55()
    let v8 : bool = v7 v4
    if v8 then
        v3
    else
        let v9 : (string -> string option) = method28()
        let v10 : string option = v9 v3
        let v11 : (string -> US9) = method29()
        let v12 : US9 = US9_1
        let v13 : US9 = v10 |> Option.map v11 |> Option.defaultValue v12 
        match v13 with
        | US9_1 -> (* None *)
            let v16 : string = $"""No parent for {if v1 then "file" else "dir"} '{v0}' at '{v2}' (until '{v3}')"""
            failwith<string> v16
        | US9_0(v14) -> (* Some *)
            method30(v0, v1, v2, v14)
and method27 (v0 : string, v1 : bool, v2 : string) : string =
    let v3 : string = method15(v2, v0)
    let v6 : (string -> bool) =
        if v1 then
            closure54()
        else
            closure55()
    let v7 : bool = v6 v3
    if v7 then
        v2
    else
        let v8 : (string -> string option) = method28()
        let v9 : string option = v8 v2
        let v10 : (string -> US9) = method29()
        let v11 : US9 = US9_1
        let v12 : US9 = v9 |> Option.map v10 |> Option.defaultValue v11 
        match v12 with
        | US9_1 -> (* None *)
            let v15 : string = $"""No parent for {if v1 then "file" else "dir"} '{v0}' at '{v2}' (until '{v2}')"""
            failwith<string> v15
        | US9_0(v13) -> (* Some *)
            method30(v0, v1, v2, v13)
and closure53 (v0 : string, v1 : bool) (v2 : string) : string =
    method27(v0, v1, v2)
and closure52 (v0 : string) (v1 : bool) : (string -> string) =
    closure53(v0, v1)
and closure51 () (v0 : string) : (bool -> (string -> string)) =
    closure52(v0)
and method31 () : string =
    let v0 : string = "^\\\\\\\\\\?\\\\"
    v0
and method32 (v0 : string) : string =
    v0
and method33 () : string =
    let v0 : string = ""
    v0
and closure58 () (v0 : string) : string =
    let v1 : string option = None
    let v2 : bool = true in let mutable _v1 = v1
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : string = method31()
    let v4 : string = method32(v0)
    let v5 : string = method33()
    let v6 : string = $"regex::Regex::new(&$0).unwrap().replace_all(&$1, &*$2)"
    let v7 : std_borrow_Cow<Str> = Fable.Core.RustInterop.emitRustExpr struct (v3, v4, v5) v6
    let v8 : string = "String::from($0)"
    let v9 : std_string_String = Fable.Core.RustInterop.emitRustExpr v7 v8
    let v10 : string = "fable_library_rust::String_::fromString($0)"
    let v11 : string = Fable.Core.RustInterop.emitRustExpr v9 v10
    v11
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v12 : string = null |> unbox<string>
    v12
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v13 : string = null |> unbox<string>
    v13
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v14 : string = null |> unbox<string>
    v14
#endif
    
#if FABLE_COMPILER_PYTHON
    let v15 : string = null |> unbox<string>
    v15
#endif
    
#else
    let v16 : string = "^\\\\\\\\\\?\\\\"
    let v17 : string = ""
    let v18 : string = System.Text.RegularExpressions.Regex.Replace (v0, v16, v17)
    v18
#endif
    |> fun x -> _v1 <- Some x
    let v19 : string = _v1.Value
    let v20 : string = $"{v19.[0] |> string |> _.ToLower()}{v19.[1..]}"
    let v21 : string = "\\"
    let v22 : string = "/"
    let v23 : string = v20.Replace (v21, v22)
    v23
and closure59 () (v0 : string) : string =
    let v1 : (char []) = [|'/'|]
    let v2 : string = v0.TrimStart v1
    let v3 : string = $"file:///{v2}"
    v3
and method35 (v0 : string, v1 : string, v2 : string) : string =
    let v3 : string = method15(v2, v0)
    let v4 : bool option = None
    let v5 : bool = true in let mutable _v4 = v4
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v6 : string = method4(v3)
    let v7 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v8 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v7
    let v9 : string = "String::from($0)"
    let v10 : std_string_String = Fable.Core.RustInterop.emitRustExpr v8 v9
    let v11 : string = "std::path::PathBuf::from($0)"
    let v12 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v10 v11
    let v13 : string = "$0.exists()"
    let v14 : bool = Fable.Core.RustInterop.emitRustExpr v12 v13
    let v17 : bool =
        if v14 then
            let v15 : string = "$0.is_dir()"
            let v16 : bool = Fable.Core.RustInterop.emitRustExpr v12 v15
            v16
        else
            false
    v17
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v18 : bool = null |> unbox<bool>
    v18
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v19 : bool = null |> unbox<bool>
    v19
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v20 : string = "fs"
    let v21 : IFsExistsSync = Fable.Core.JsInterop.importAll v20
    let v22 : string = "$0.existsSync($1)"
    let v23 : bool = Fable.Core.JsInterop.emitJsExpr struct (v21, v3) v22
    v23
#endif
    
#if FABLE_COMPILER_PYTHON
    let v24 : bool = null |> unbox<bool>
    v24
#endif
    
#else
    let v25 : (string -> bool) = System.IO.Directory.Exists
    let v26 : bool = v25 v3
    v26
#endif
    |> fun x -> _v4 <- Some x
    let v27 : bool = _v4.Value
    if v27 then
        v2
    else
        let v28 : (string -> string option) = method28()
        let v29 : string option = v28 v2
        let v30 : (string -> US9) = method29()
        let v31 : US9 = US9_1
        let v32 : US9 = v29 |> Option.map v30 |> Option.defaultValue v31 
        match v32 with
        | US9_1 -> (* None *)
            let v35 : string = $"""No parent for {if false then "file" else "dir"} '{v0}' at '{v1}' (until '{v2}')"""
            failwith<string> v35
        | US9_0(v33) -> (* Some *)
            method35(v0, v1, v33)
and method34 (v0 : string, v1 : string) : string =
    let v2 : string = method15(v1, v0)
    let v3 : bool option = None
    let v4 : bool = true in let mutable _v3 = v3
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v5 : string = method4(v2)
    let v6 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v7 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v6
    let v8 : string = "String::from($0)"
    let v9 : std_string_String = Fable.Core.RustInterop.emitRustExpr v7 v8
    let v10 : string = "std::path::PathBuf::from($0)"
    let v11 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v9 v10
    let v12 : string = "$0.exists()"
    let v13 : bool = Fable.Core.RustInterop.emitRustExpr v11 v12
    let v16 : bool =
        if v13 then
            let v14 : string = "$0.is_dir()"
            let v15 : bool = Fable.Core.RustInterop.emitRustExpr v11 v14
            v15
        else
            false
    v16
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v17 : bool = null |> unbox<bool>
    v17
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v18 : bool = null |> unbox<bool>
    v18
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v19 : string = "fs"
    let v20 : IFsExistsSync = Fable.Core.JsInterop.importAll v19
    let v21 : string = "$0.existsSync($1)"
    let v22 : bool = Fable.Core.JsInterop.emitJsExpr struct (v20, v2) v21
    v22
#endif
    
#if FABLE_COMPILER_PYTHON
    let v23 : bool = null |> unbox<bool>
    v23
#endif
    
#else
    let v24 : (string -> bool) = System.IO.Directory.Exists
    let v25 : bool = v24 v2
    v25
#endif
    |> fun x -> _v3 <- Some x
    let v26 : bool = _v3.Value
    if v26 then
        v1
    else
        let v27 : (string -> string option) = method28()
        let v28 : string option = v27 v1
        let v29 : (string -> US9) = method29()
        let v30 : US9 = US9_1
        let v31 : US9 = v28 |> Option.map v29 |> Option.defaultValue v30 
        match v31 with
        | US9_1 -> (* None *)
            let v34 : string = $"""No parent for {if false then "file" else "dir"} '{v0}' at '{v1}' (until '{v1}')"""
            failwith<string> v34
        | US9_0(v32) -> (* Some *)
            method35(v0, v1, v32)
and closure60 () () : string =
    let v0 : string = __SOURCE_DIRECTORY__
    let v1 : string = "polyglot"
    let v2 : string = ".paket"
    let v3 : string = method15(v1, v2)
    let v4 : string = method34(v3, v0)
    method15(v4, v1)
and method36 (v0 : string) : unit =
    let v1 : unit option = None
    let v2 : bool = true in let mutable _v1 = v1
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    ()
#endif
    
#if FABLE_COMPILER_RUST && WASM
    ()
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    ()
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    ()
#endif
    
#if FABLE_COMPILER_PYTHON
    ()
#endif
    
#else
    try
    let v3 : string option = None
    let v4 : bool = true in let mutable _v3 = v3
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v5 : string = "env!(\"CARGO_PKG_NAME\").into()"
    let v6 : string = Fable.Core.RustInterop.emitRustExpr () v5
    v6
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v7 : string = null |> unbox<string>
    v7
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v8 : string = null |> unbox<string>
    v8
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v9 : string = null |> unbox<string>
    v9
#endif
    
#if FABLE_COMPILER_PYTHON
    let v10 : string = null |> unbox<string>
    v10
#endif
    
#else
    let v11 : string = System.Reflection.Assembly.GetEntryAssembly().GetName().Name
    v11
#endif
    |> fun x -> _v3 <- Some x
    let v12 : string = _v3.Value
    let v13 : System.DateTime = System.DateTime.Now
    let v14 : System.Guid = System.Guid.NewGuid ()
    let v15 : (System.Guid -> string) = _.ToString()
    let v16 : string = v15 v14
    let v17 : struct (string * string) option = None
    let v18 : bool = true in let mutable _v17 = v17
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v19 : System.DateTime = System.DateTime (1970, 1, 1, 0, 0, 0, System.DateTimeKind.Utc)
    let v20 : (System.DateTime -> System.DateTime) = _.ToUniversalTime()
    let v21 : System.DateTime = v20 v19
    let v22 : System.DateTimeKind = System.DateTimeKind.Local
    let v23 : System.DateTime = System.DateTime.SpecifyKind (v13, v22)
    let v24 : (System.DateTime -> System.DateTime) = _.ToUniversalTime()
    let v25 : System.DateTime = v24 v23
    let v26 : (System.DateTime -> int64) = _.Ticks
    let v27 : int64 = v26 v25
    let v28 : (System.DateTime -> int64) = _.Ticks
    let v29 : int64 = v28 v21
    let v30 : int64 = v27 - v29
    let v31 : int64 = v30 / 10L
    let v32 : string = "chrono::DateTime::from_timestamp_micros($0)"
    let v33 : chrono_DateTime<chrono_Utc> option = Fable.Core.RustInterop.emitRustExpr v31 v32
    let v34 : (chrono_DateTime<chrono_Utc> -> US8) = method18()
    let v35 : US8 = US8_1
    let v36 : US8 = v33 |> Option.map v34 |> Option.defaultValue v35 
    let v55 : US9 =
        match v36 with
        | US8_1 -> (* None *)
            US9_1
        | US8_0(v37) -> (* Some *)
            let v38 : chrono_DateTime<chrono_Utc> = method19(v37)
            let v39 : string = "v38.naive_utc()"
            let v40 : chrono_NaiveDateTime = Fable.Core.RustInterop.emitRustExpr () v39
            let v41 : string = "chrono::offset::TimeZone::from_utc_datetime(&chrono::Local, &v40)"
            let v42 : chrono_DateTime<chrono_Local> = Fable.Core.RustInterop.emitRustExpr () v41
            let v43 : string = "%Y%m%d-%H%M-%S%f"
            let v44 : string = "r#\"" + v43 + "\"#"
            let v45 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v44
            let v46 : chrono_DateTime<chrono_Local> = method20(v42)
            let v47 : string = "v46.format(v45).to_string()"
            let v48 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v47
            let v49 : string = "fable_library_rust::String_::fromString($0)"
            let v50 : string = Fable.Core.RustInterop.emitRustExpr v48 v49
            let v51 : string = $"{v50.[0..17]}-{v50.[18..21]}-{v50.[22]}"
            US9_0(v51)
    let v59 : string =
        match v55 with
        | US9_1 -> (* None *)
            let v57 : string = ""
            v57
        | US9_0(v56) -> (* Some *)
            v56
    let v60 : System.TimeZoneInfo option = None
    let v61 : bool = true in let mutable _v60 = v60
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v62 : string = "0i64.into()"
    let v63 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v62
    v63
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v64 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v64
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v65 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v65
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v66 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v66
#endif
    
#if FABLE_COMPILER_PYTHON
    let v67 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v67
#endif
    
#else
    let v68 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    v68
#endif
    |> fun x -> _v60 <- Some x
    let v69 : System.TimeZoneInfo = _v60.Value
    let v70 : System.TimeSpan option = None
    let v71 : bool = true in let mutable _v70 = v70
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v72 : System.TimeSpan = System.TimeSpan () 
    v72
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v73 : System.TimeSpan = System.TimeSpan () 
    v73
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v74 : System.TimeSpan = System.TimeSpan () 
    v74
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v75 : System.TimeSpan = System.TimeSpan () 
    v75
#endif
    
#if FABLE_COMPILER_PYTHON
    let v76 : System.TimeSpan = System.TimeSpan () 
    v76
#endif
    
#else
    let v77 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v78 : System.TimeZoneInfo option = None
    let v79 : bool = true in let mutable _v78 = v78
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v80 : string = "0i64.into()"
    let v81 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v80
    v81
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v82 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v82
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v83 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v83
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v84 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v84
#endif
    
#if FABLE_COMPILER_PYTHON
    let v85 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v85
#endif
    
#else
    let v86 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    v86
#endif
    |> fun x -> _v78 <- Some x
    let v87 : System.TimeZoneInfo = _v78.Value
    let v88 : (System.DateTime -> System.TimeSpan) = v77 v87
    let v89 : System.TimeSpan = v88 v25
    v89
#endif
    |> fun x -> _v70 <- Some x
    let v90 : System.TimeSpan = _v70.Value
    let v91 : (System.TimeSpan -> int32) = _.Hours
    let v92 : int32 = v91 v90
    let v93 : bool = v92 > 0
    let v94 : uint8 =
        if v93 then
            1uy
        else
            0uy
    let v95 : (string -> string) = v90.ToString
    let v96 : string = "hh:mm"
    let v97 : string = v95 v96
    let v98 : string = $"{v94}{v97.[0..1]}{v97.[3..4]}"
    struct (v59, v98)
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let struct (v99 : string, v100 : string) = null |> unbox<struct (string * string)>
    struct (v99, v100)
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let struct (v101 : string, v102 : string) = null |> unbox<struct (string * string)>
    struct (v101, v102)
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let struct (v103 : string, v104 : string) = null |> unbox<struct (string * string)>
    struct (v103, v104)
#endif
    
#if FABLE_COMPILER_PYTHON
    let struct (v105 : string, v106 : string) = null |> unbox<struct (string * string)>
    struct (v105, v106)
#endif
    
#else
    let v107 : string = method21()
    let v108 : (string -> string) = v13.ToString
    let v109 : string = v108 v107
    let v110 : System.TimeZoneInfo option = None
    let v111 : bool = true in let mutable _v110 = v110
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v112 : string = "0i64.into()"
    let v113 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v112
    v113
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v114 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v114
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v115 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v115
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v116 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v116
#endif
    
#if FABLE_COMPILER_PYTHON
    let v117 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v117
#endif
    
#else
    let v118 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    v118
#endif
    |> fun x -> _v110 <- Some x
    let v119 : System.TimeZoneInfo = _v110.Value
    let v120 : System.TimeSpan option = None
    let v121 : bool = true in let mutable _v120 = v120
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v122 : System.TimeSpan = System.TimeSpan () 
    v122
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v123 : System.TimeSpan = System.TimeSpan () 
    v123
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v124 : System.TimeSpan = System.TimeSpan () 
    v124
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v125 : System.TimeSpan = System.TimeSpan () 
    v125
#endif
    
#if FABLE_COMPILER_PYTHON
    let v126 : System.TimeSpan = System.TimeSpan () 
    v126
#endif
    
#else
    let v127 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v128 : System.TimeZoneInfo option = None
    let v129 : bool = true in let mutable _v128 = v128
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v130 : string = "0i64.into()"
    let v131 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v130
    v131
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v132 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v132
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v133 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v133
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v134 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v134
#endif
    
#if FABLE_COMPILER_PYTHON
    let v135 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v135
#endif
    
#else
    let v136 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    v136
#endif
    |> fun x -> _v128 <- Some x
    let v137 : System.TimeZoneInfo = _v128.Value
    let v138 : (System.DateTime -> System.TimeSpan) = v127 v137
    let v139 : System.TimeSpan = v138 v13
    v139
#endif
    |> fun x -> _v120 <- Some x
    let v140 : System.TimeSpan = _v120.Value
    let v141 : (System.TimeSpan -> int32) = _.Hours
    let v142 : int32 = v141 v140
    let v143 : bool = v142 > 0
    let v144 : (bool -> int32) = System.Convert.ToInt32
    let v145 : int32 = v144 v143
    let v146 : string = method22()
    let v147 : (string -> string) = v140.ToString
    let v148 : string = v147 v146
    let v149 : string = $"{v145}{v148}"
    struct (v109, v149)
#endif
    |> fun x -> _v17 <- Some x
    let struct (v150 : string, v151 : string) = _v17.Value
    let v152 : System.Guid = System.Guid $"{v150}{v151}{v16.[v150.Length + v151.Length..]}"
    let v153 : string = $"{v12}_{v152}.txt"
    let v154 : string = __SOURCE_DIRECTORY__
    let v155 : string = "polyglot"
    let v156 : string = ".paket"
    let v157 : string = method15(v155, v156)
    let v158 : string = method34(v157, v154)
    let v159 : string = method15(v158, v155)
    let v160 : string = "target/polyglot/trace"
    let v161 : string = method15(v159, v160)
    let v162 : System.IO.DirectoryInfo option = None
    let v163 : bool = true in let mutable _v162 = v162
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v164 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    v164
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v165 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    v165
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v166 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    v166
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v167 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    v167
#endif
    
#if FABLE_COMPILER_PYTHON
    let v168 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    v168
#endif
    
#else
    let v169 : (string -> System.IO.DirectoryInfo) = System.IO.Directory.CreateDirectory
    let v170 : System.IO.DirectoryInfo = v169 v161
    v170
#endif
    |> fun x -> _v162 <- Some x
    let v171 : System.IO.DirectoryInfo = _v162.Value
    let v172 : string = method15(v161, v153)
    let v173 : Async<unit> option = None
    let v174 : bool = true in let mutable _v173 = v173
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v175 : Async<unit> = null |> unbox<Async<unit>>
    v175
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v176 : Async<unit> = null |> unbox<Async<unit>>
    v176
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v177 : Async<unit> = null |> unbox<Async<unit>>
    v177
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v178 : Async<unit> = null |> unbox<Async<unit>>
    v178
#endif
    
#if FABLE_COMPILER_PYTHON
    let v179 : Async<unit> = null |> unbox<Async<unit>>
    v179
#endif
    
#else
    let v180 : System.Threading.Tasks.Task = System.IO.File.WriteAllTextAsync (v172, v0)
    let v181 : Async<unit> option = None
    let v182 : bool = true in let mutable _v181 = v181
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v183 : Async<unit> = null |> unbox<Async<unit>>
    v183
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v184 : Async<unit> = null |> unbox<Async<unit>>
    v184
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v185 : Async<unit> = null |> unbox<Async<unit>>
    v185
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v186 : Async<unit> = null |> unbox<Async<unit>>
    v186
#endif
    
#if FABLE_COMPILER_PYTHON
    let v187 : Async<unit> = null |> unbox<Async<unit>>
    v187
#endif
    
#else
    let v188 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
    let v189 : Async<unit> = v188 v180
    v189
#endif
    |> fun x -> _v181 <- Some x
    let v190 : Async<unit> = _v181.Value
    v190
#endif
    |> fun x -> _v173 <- Some x
    let v191 : Async<unit> = _v173.Value
    let v192 : unit option = None
    let v193 : bool = true in let mutable _v192 = v192
    
#if FABLE_COMPILER || WASM || CONTRACT
    
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
    
#if FABLE_COMPILER_TYPESCRIPT
    null |> unbox<unit>
    ()
#endif
    
#if FABLE_COMPILER_PYTHON
    null |> unbox<unit>
    ()
#endif
    
#else
    let v194 : (Async<unit> -> unit) = Async.RunSynchronously
    v194 v191
    ()
#endif
    |> fun x -> _v192 <- Some x
    _v192.Value
    with ex ->
    let v195 : exn = ex
    let v196 : string = $"file_system.trace_file / ex: %A{v195}"
    method36(v196)
    (*
    *)
    ()
#endif
    |> fun x -> _v1 <- Some x
    _v1.Value
    ()
and closure62 () (v0 : string) : unit =
    method36(v0)
and closure61 () (v0 : bool) : unit =
    let v1 : (unit -> struct (Mut0 * Mut1 * Mut2 * int64 option * Mut3)) = closure0()
    if State.trace_state.IsNone then State.trace_state <- v1 () |> Some
    let struct (v2 : Mut0, v3 : Mut1, v4 : Mut2, v5 : int64 option, v6 : Mut3) = State.trace_state.Value
    let v9 : (string -> unit) =
        if v0 then
            closure62()
        else
            closure1()
    v6.l0 <- v9
    ()
and closure64 (v0 : string) (v1 : string) : string =
    method15(v0, v1)
and closure63 () (v0 : string) : (string -> string) =
    closure64(v0)
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
let v13 : (unit -> string) = closure50()
let get_source_directory () = v13 ()
let v14 : (string -> (bool -> (string -> string))) = closure51()
let find_parent x = v14 x
let v15 : (string -> string) = closure58()
let normalize_path x = v15 x
let v16 : (string -> string) = closure59()
let new_file_uri x = v16 x
let v17 : (unit -> string) = closure60()
let get_repository_root () = v17 ()
let v18 : (bool -> unit) = closure61()
let init_trace_file x = v18 x
let v19 : (string -> (string -> string)) = closure63()
let (</>) x = v19 x
()
