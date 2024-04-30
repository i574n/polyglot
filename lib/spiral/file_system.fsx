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
[<Fable.Core.Erase; Fable.Core.Emit("[$0]")>]
#endif
type Slice<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("[$0; $1]")>]
#endif
type Slice'<'T, 'U> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("Vec<$0>")>]
#endif
type Vec<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::future::Future<Output = $0>")>]
#endif
type std_future_Future<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("futures::future::TryJoinAll<$0>")>]
#endif
type futures_future_TryJoinAll<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("rayon::vec::IntoIter<$0>")>]
#endif
type rayon_vec_IntoIter<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("rayon::iter::Map<$0, _>")>]
#endif
type rayon_iter_Map<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("futures_lite::stream::StreamExt")>]
#endif
type futures_lite_stream_StreamExt = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("core::iter::Fuse<$0>")>]
#endif
type core_iter_Fuse<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::thread::JoinHandle<$0>")>]
#endif
type std_thread_JoinHandle<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::sync::Arc<$0>")>]
#endif
type std_sync_Arc<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::sync::Mutex<$0>")>]
#endif
type std_sync_Mutex<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::sync::MutexGuard<$0>")>]
#endif
type std_sync_MutexGuard<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("clap::Arg")>]
#endif
type clap_Arg = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("clap::Command")>]
#endif
type clap_Command = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("clap::ArgMatches")>]
#endif
type clap_ArgMatches = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::io::Error")>]
#endif
type std_io_Error = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::io::Lines<$0>")>]
#endif
type std_io_Lines<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("async_std::io::BufReader<$0>")>]
#endif
type async_std_io_BufReader<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::io::BufReader<$0>")>]
#endif
type std_io_BufReader<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::process::Child")>]
#endif
type std_process_Child = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::process::ChildStderr")>]
#endif
type std_process_ChildStderr = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::process::ChildStdout")>]
#endif
type std_process_ChildStdout = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::process::Command")>]
#endif
type std_process_Command = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::process::Output")>]
#endif
type std_process_Output = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::process::Stdio")>]
#endif
type std_process_Stdio = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::sync::mpsc::Receiver<$0>")>]
#endif
type std_sync_mpsc_Receiver<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::sync::mpsc::Sender<$0>")>]
#endif
type std_sync_mpsc_Sender<'T> = class end
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
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v13 : string = System.Reflection.Assembly.GetEntryAssembly().GetName().Name
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
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v6 : (string -> string) = System.IO.Path.GetFileName
    let v7 : string = v6 v0
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
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v36 : (int64 -> US2) = method6()
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
    let v59 : string = method7()
    v59
#endif
    
#if FABLE_COMPILER_PYTHON
    let v60 : string = method7()
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
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    v74
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    v74
#endif
    
#if FABLE_COMPILER_PYTHON
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
        
#if !FABLE_COMPILER && !WASM && !CONTRACT
        System.Console.WriteLine v22 
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
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v7 : Async<int64> option = None
    let mutable _v7 = v7
    async {
    try
    let v8 : unit option = None
    let v9 : bool = true in let mutable _v8 = v8
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v10 : string = method3(v0)
    let v11 : bool option = None
    let v12 : bool = true in let mutable _v11 = v11
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v13 : string = method4(v10)
    let v14 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v15 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v13 v14
    let v16 : string = "String::from($0)"
    let v17 : std_string_String = Fable.Core.RustInterop.emitRustExpr v15 v16
    let v18 : string = "std::path::PathBuf::from($0)"
    let v19 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v17 v18
    let v20 : string = "$0.exists()"
    let v21 : bool = Fable.Core.RustInterop.emitRustExpr v19 v20
    let v24 : bool =
        if v21 then
            let v22 : string = "$0.is_dir()"
            let v23 : bool = Fable.Core.RustInterop.emitRustExpr v19 v22
            v23
        else
            false
    v24
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v25 : bool = null |> unbox<bool>
    v25
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v26 : bool = null |> unbox<bool>
    v26
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v27 : (string -> bool) = System.IO.Directory.Exists
    let v28 : bool = v27 v10
    v28
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v29 : string = "fs"
    let v30 : IFsExistsSync = Fable.Core.JsInterop.importAll v29
    let v31 : string = "v30.existsSync($0)"
    let v32 : bool = Fable.Core.JsInterop.emitJsExpr v10 v31
    v32
#endif
    
#if FABLE_COMPILER_PYTHON
    let v33 : bool = null |> unbox<bool>
    v33
#endif
    |> fun x -> _v11 <- Some x
    let v34 : bool = _v11.Value
    if v34 then
        let v35 : string = "std::fs::remove_dir_all(&*$0).unwrap()"
        Fable.Core.RustInterop.emitRustExpr v10 v35
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
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    System.IO.Directory.Delete (v0, true)
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
    |> fun x -> _v8 <- Some x
    _v8.Value
    return v1 
    with ex ->
    let v36 : exn = ex
    let v37 : int64 = v1 % 100L
    let v38 : bool = v37 = 0L
    if v38 then
        let v39 : string option = None
        let v40 : bool = true in let mutable _v39 = v39
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v41 : string = $"%A{v36}"
        v41
#endif
        
#if FABLE_COMPILER_RUST && WASM
        let v42 : string = $"%A{v36}"
        v42
#endif
        
#if FABLE_COMPILER_RUST && CONTRACT
        let v43 : string = $"%A{v36}"
        v43
#endif
        
#if !FABLE_COMPILER && !WASM && !CONTRACT
        let v44 : string = $"{v36.GetType ()}: {v36.Message}"
        v44
#endif
        
#if FABLE_COMPILER_TYPESCRIPT
        let v45 : string = $"%A{v36}"
        v45
#endif
        
#if FABLE_COMPILER_PYTHON
        let v46 : string = $"%A{v36}"
        v46
#endif
        |> fun x -> _v39 <- Some x
        let v47 : string = _v39.Value
        let v48 : US0 = US0_1
        let v49 : (unit -> string) = closure3()
        let v50 : (unit -> string) = closure4(v0, v47)
        method5(v48, v49, v50)
    let v51 : Async<unit> option = None
    let v52 : bool = true in let mutable _v51 = v51
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v53 : Async<unit> = null |> unbox<Async<unit>>
    v53
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v54 : Async<unit> = null |> unbox<Async<unit>>
    v54
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v55 : Async<unit> = null |> unbox<Async<unit>>
    v55
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v56 : (int32 -> Async<unit>) = Async.Sleep
    let v57 : Async<unit> = v56 10
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
    |> fun x -> _v51 <- Some x
    let v60 : Async<unit> = _v51.Value
    do! v60 
    let v61 : int64 = v1 + 1L
    let v62 : Async<int64> = method2(v0, v61)
    return! v62 
    (*
    let v63 : int64 = *)
    }
    |> fun x -> _v7 <- Some x
    let v64 : Async<int64> = _v7 |> Option.get
    v64
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v65 : Async<int64> = null |> unbox<Async<int64>>
    v65
#endif
    
#if FABLE_COMPILER_PYTHON
    let v66 : Async<int64> = null |> unbox<Async<int64>>
    v66
#endif
    |> fun x -> _v2 <- Some x
    let v67 : Async<int64> = _v2.Value
    v67
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
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v6 : int64 = 0L
    let v7 : Async<int64> = method2(v0, v6)
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
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
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
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
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
    
#if FABLE_COMPILER_PYTHON
    let v34 : System.IO.FileStream = null |> unbox<System.IO.FileStream>
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
        
#if !FABLE_COMPILER && !WASM && !CONTRACT
        let v47 : string = $"{v37.GetType ()}: {v37.Message}"
        v47
#endif
        
#if FABLE_COMPILER_TYPESCRIPT
        let v48 : string = $"%A{v37}"
        v48
#endif
        
#if FABLE_COMPILER_PYTHON
        let v49 : string = $"%A{v37}"
        v49
#endif
        |> fun x -> _v42 <- Some x
        let v50 : string = _v42.Value
        let v51 : US0 = US0_1
        let v52 : (unit -> string) = closure11()
        let v53 : (unit -> string) = closure12(v0, v3, v50)
        method5(v51, v52, v53)
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
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v59 : (int32 -> Async<unit>) = Async.Sleep
    let v60 : Async<unit> = v59 10
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
    |> fun x -> _v54 <- Some x
    let v63 : Async<unit> = _v54.Value
    do! v63 
    let v64 : int64 = v3 + 1L
    let v65 : Async<int64> = method9(v0, v1, v2, v64)
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
    
#if FABLE_COMPILER_PYTHON
    let v69 : Async<int64> = null |> unbox<Async<int64>>
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
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let struct (v13 : US4, v14 : US5) =
        match v0 with
        | US3_1 -> (* None *)
            let v9 : US4 = US4_2
            let v10 : US5 = US5_1
            struct (v9, v10)
        | US3_0(v7, v8) -> (* Some *)
            struct (v7, v8)
    let v15 : int64 = 0L
    let v16 : Async<int64> = method9(v1, v14, v13, v15)
    v16
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v17 : Async<int64> = null |> unbox<Async<int64>>
    v17
#endif
    
#if FABLE_COMPILER_PYTHON
    let v18 : Async<int64> = null |> unbox<Async<int64>>
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
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
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
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
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
    
#if FABLE_COMPILER_PYTHON
    let v18 : System.IO.FileStream = null |> unbox<System.IO.FileStream>
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
        
#if !FABLE_COMPILER && !WASM && !CONTRACT
        let v31 : string = $"{v21.GetType ()}: {v21.Message}"
        v31
#endif
        
#if FABLE_COMPILER_TYPESCRIPT
        let v32 : string = $"%A{v21}"
        v32
#endif
        
#if FABLE_COMPILER_PYTHON
        let v33 : string = $"%A{v21}"
        v33
#endif
        |> fun x -> _v26 <- Some x
        let v34 : string = _v26.Value
        let v35 : US0 = US0_1
        let v36 : (unit -> string) = closure11()
        let v37 : (unit -> string) = closure12(v0, v1, v34)
        method5(v35, v36, v37)
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
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v43 : (int32 -> Async<unit>) = Async.Sleep
    let v44 : Async<unit> = v43 10
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
    |> fun x -> _v38 <- Some x
    let v47 : Async<unit> = _v38.Value
    do! v47 
    let v48 : int64 = v1 + 1L
    let v49 : Async<int64> = method10(v0, v48)
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
    
#if FABLE_COMPILER_PYTHON
    let v53 : Async<int64> = null |> unbox<Async<int64>>
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
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v6 : int64 = 0L
    let v7 : Async<int64> = method10(v0, v6)
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
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
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
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v13 : (System.Threading.Tasks.Task<string> -> Async<string>) = Async.AwaitTask
    let v14 : Async<string> = v13 v7
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
    |> fun x -> _v8 <- Some x
    let v17 : Async<string> = _v8.Value
    v17
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v18 : Async<string> = null |> unbox<Async<string>>
    v18
#endif
    
#if FABLE_COMPILER_PYTHON
    let v19 : Async<string> = null |> unbox<Async<string>>
    v19
#endif
    |> fun x -> _v1 <- Some x
    let v20 : Async<string> = _v1.Value
    v20
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
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
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
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v12 : Async<bool> option = None
    let mutable _v12 = v12
    async {
    let v13 : bool option = None
    let v14 : bool = true in let mutable _v13 = v13
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v15 : string = method4(v0)
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
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
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
    
#if FABLE_COMPILER_PYTHON
    let v35 : bool = null |> unbox<bool>
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
        
#if !FABLE_COMPILER && !WASM && !CONTRACT
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
        
#if !FABLE_COMPILER && !WASM && !CONTRACT
        let v50 : (System.Threading.Tasks.Task<string> -> Async<string>) = Async.AwaitTask
        let v51 : Async<string> = v50 v44
        v51
#endif
        
#if FABLE_COMPILER_TYPESCRIPT
        let v52 : Async<string> = null |> unbox<Async<string>>
        v52
#endif
        
#if FABLE_COMPILER_PYTHON
        let v53 : Async<string> = null |> unbox<Async<string>>
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
        
#if FABLE_COMPILER_PYTHON
        let v56 : Async<string> = null |> unbox<Async<string>>
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
    
#if FABLE_COMPILER_PYTHON
    let v62 : Async<bool> = null |> unbox<Async<bool>>
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
    
#if FABLE_COMPILER_PYTHON
    let v65 : Async<bool> = null |> unbox<Async<bool>>
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
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
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
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v13 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
    let v14 : Async<unit> = v13 v7
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
    |> fun x -> _v8 <- Some x
    let v17 : Async<unit> = _v8.Value
    v17
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v18 : Async<unit> = null |> unbox<Async<unit>>
    v18
#endif
    
#if FABLE_COMPILER_PYTHON
    let v19 : Async<unit> = null |> unbox<Async<unit>>
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
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
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
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
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
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v18 : Async<bool> option = None
    let mutable _v18 = v18
    async {
    let v19 : bool option = None
    let v20 : bool = true in let mutable _v19 = v19
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v21 : string = method4(v0)
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
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
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
    
#if FABLE_COMPILER_PYTHON
    let v41 : bool = null |> unbox<bool>
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
        
#if !FABLE_COMPILER && !WASM && !CONTRACT
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
        
#if !FABLE_COMPILER && !WASM && !CONTRACT
        let v56 : (System.Threading.Tasks.Task<string> -> Async<string>) = Async.AwaitTask
        let v57 : Async<string> = v56 v50
        v57
#endif
        
#if FABLE_COMPILER_TYPESCRIPT
        let v58 : Async<string> = null |> unbox<Async<string>>
        v58
#endif
        
#if FABLE_COMPILER_PYTHON
        let v59 : Async<string> = null |> unbox<Async<string>>
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
        
#if FABLE_COMPILER_PYTHON
        let v62 : Async<string> = null |> unbox<Async<string>>
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
    
#if FABLE_COMPILER_PYTHON
    let v68 : Async<bool> = null |> unbox<Async<bool>>
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
    
#if FABLE_COMPILER_PYTHON
    let v71 : Async<bool> = null |> unbox<Async<bool>>
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
        
#if !FABLE_COMPILER && !WASM && !CONTRACT
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
        
#if !FABLE_COMPILER && !WASM && !CONTRACT
        let v86 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
        let v87 : Async<unit> = v86 v80
        v87
#endif
        
#if FABLE_COMPILER_TYPESCRIPT
        let v88 : Async<unit> = null |> unbox<Async<unit>>
        v88
#endif
        
#if FABLE_COMPILER_PYTHON
        let v89 : Async<unit> = null |> unbox<Async<unit>>
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
        
#if FABLE_COMPILER_PYTHON
        let v92 : Async<unit> = null |> unbox<Async<unit>>
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
    
#if FABLE_COMPILER_PYTHON
    let v96 : Async<unit> = null |> unbox<Async<unit>>
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
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v7 : string = $"{v1.GetType ()}: {v1.Message}"
    v7
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v8 : string = $"%A{v1}"
    v8
#endif
    
#if FABLE_COMPILER_PYTHON
    let v9 : string = $"%A{v1}"
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
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
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
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v10 : (string -> unit) = System.IO.File.Delete
    v10 v0
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
        method5(v14, v15, v16)
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
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v22 : (int32 -> Async<unit>) = Async.Sleep
    let v23 : Async<unit> = v22 10
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
    |> fun x -> _v17 <- Some x
    let v26 : Async<unit> = _v17.Value
    do! v26 
    let v27 : int64 = v1 + 1L
    let v28 : Async<int64> = method11(v0, v27)
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
    
#if FABLE_COMPILER_PYTHON
    let v32 : Async<int64> = null |> unbox<Async<int64>>
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
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v6 : int64 = 0L
    let v7 : Async<int64> = method11(v0, v6)
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
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v8 : string = $"{v2.GetType ()}: {v2.Message}"
    v8
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v9 : string = $"%A{v2}"
    v9
#endif
    
#if FABLE_COMPILER_PYTHON
    let v10 : string = $"%A{v2}"
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
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
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
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    System.IO.File.Move (v1, v0)
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
        method5(v14, v15, v16)
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
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v22 : (int32 -> Async<unit>) = Async.Sleep
    let v23 : Async<unit> = v22 10
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
    |> fun x -> _v17 <- Some x
    let v26 : Async<unit> = _v17.Value
    do! v26 
    let v27 : int64 = v2 + 1L
    let v28 : Async<int64> = method12(v0, v1, v27)
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
    
#if FABLE_COMPILER_PYTHON
    let v31 : Async<int64> = null |> unbox<Async<int64>>
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
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v7 : int64 = 0L
    let v8 : Async<int64> = method12(v0, v1, v7)
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
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
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
        
#if !FABLE_COMPILER && !WASM && !CONTRACT
        let v14 : int64 = 0L
        let v15 : Async<int64> = method10(v0, v14)
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
        
#if !FABLE_COMPILER && !WASM && !CONTRACT
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
        
#if !FABLE_COMPILER && !WASM && !CONTRACT
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
        
#if !FABLE_COMPILER && !WASM && !CONTRACT
        let v35 : Async<Async<int64>> = Async.StartChild (v18, 1000)
        v35
#endif
        
#if FABLE_COMPILER_TYPESCRIPT
        let v36 : Async<Async<int64>> = null |> unbox<Async<Async<int64>>>
        v36
#endif
        
#if FABLE_COMPILER_PYTHON
        let v37 : Async<Async<int64>> = null |> unbox<Async<Async<int64>>>
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
        
#if !FABLE_COMPILER && !WASM && !CONTRACT
        let v45 : (Async<int64> -> Async<Choice<int64, exn>>) = Async.Catch
        let v46 : Async<Choice<int64, exn>> = v45 v39
        v46
#endif
        
#if FABLE_COMPILER_TYPESCRIPT
        let v47 : Async<Choice<int64, exn>> = null |> unbox<Async<Choice<int64, exn>>>
        v47
#endif
        
#if FABLE_COMPILER_PYTHON
        let v48 : Async<Choice<int64, exn>> = null |> unbox<Async<Choice<int64, exn>>>
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
        
#if !FABLE_COMPILER && !WASM && !CONTRACT
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
        
#if !FABLE_COMPILER && !WASM && !CONTRACT
        let v62 : (int64 -> US6) = closure29()
        let v63 : (exn -> US6) = closure30()
        let v64 : US6 = match v56 with Choice1Of2 x -> v62 x | Choice2Of2 x -> v63 x
        v64
#endif
        
#if FABLE_COMPILER_TYPESCRIPT
        let v65 : US6 = null |> unbox<US6>
        v65
#endif
        
#if FABLE_COMPILER_PYTHON
        let v66 : US6 = null |> unbox<US6>
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
        
#if FABLE_COMPILER_PYTHON
        let v70 : Async<US6> = null |> unbox<Async<US6>>
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
        
#if !FABLE_COMPILER && !WASM && !CONTRACT
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
        
#if FABLE_COMPILER_PYTHON
        let v87 : Async<US7> = null |> unbox<Async<US7>>
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
        
#if !FABLE_COMPILER && !WASM && !CONTRACT
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
                    method5(v102, v103, v104)
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
                    
#if !FABLE_COMPILER && !WASM && !CONTRACT
                    let v111 : string = $"{v98.GetType ()}: {v98.Message}"
                    v111
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let v112 : string = $"%A{v98}"
                    v112
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let v113 : string = $"%A{v98}"
                    v113
#endif
                    |> fun x -> _v106 <- Some x
                    let v114 : string = _v106.Value
                    let v115 : US0 = US0_4
                    let v116 : (unit -> string) = closure33(v114)
                    let v117 : (unit -> string) = closure32()
                    method5(v115, v116, v117)
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
        
#if FABLE_COMPILER_PYTHON
        let v124 : Async<US2> = null |> unbox<Async<US2>>
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
        
#if FABLE_COMPILER_PYTHON
        let v128 : Async<US2> = null |> unbox<Async<US2>>
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
        
#if FABLE_COMPILER_PYTHON
        let v131 : Async<US2> = null |> unbox<Async<US2>>
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
        
#if !FABLE_COMPILER && !WASM && !CONTRACT
        let v138 : (Async<US2> -> Async<unit>) = Async.Ignore
        let v139 : Async<unit> = v138 v132
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
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
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
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v155 : (System.Threading.Tasks.Task<string> -> Async<string>) = Async.AwaitTask
    let v156 : Async<string> = v155 v149
    v156
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v157 : Async<string> = null |> unbox<Async<string>>
    v157
#endif
    
#if FABLE_COMPILER_PYTHON
    let v158 : Async<string> = null |> unbox<Async<string>>
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
    
#if FABLE_COMPILER_PYTHON
    let v161 : Async<string> = null |> unbox<Async<string>>
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
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
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
    
#if FABLE_COMPILER_PYTHON
    let v173 : Async<string option> = null |> unbox<Async<string option>>
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
        
#if !FABLE_COMPILER && !WASM && !CONTRACT
        let v183 : string = $"{v175.GetType ()}: {v175.Message}"
        v183
#endif
        
#if FABLE_COMPILER_TYPESCRIPT
        let v184 : string = $"%A{v175}"
        v184
#endif
        
#if FABLE_COMPILER_PYTHON
        let v185 : string = $"%A{v175}"
        v185
#endif
        |> fun x -> _v178 <- Some x
        let v186 : string = _v178.Value
        let v187 : US0 = US0_1
        let v188 : (unit -> string) = closure34()
        let v189 : (unit -> string) = closure35(v1, v186)
        method5(v187, v188, v189)
        let v190 : string option = None
        return v190 
        (*
        ()
    else
        *) else
        let v191 : int64 = v1 + 1L
        let v192 : Async<string option> = method13(v0, v191)
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
    
#if FABLE_COMPILER_PYTHON
    let v196 : Async<string option> = null |> unbox<Async<string option>>
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
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v6 : int64 = 0L
    let v7 : Async<string option> = method13(v0, v6)
    v7
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v8 : Async<string option> = null |> unbox<Async<string option>>
    v8
#endif
    
#if FABLE_COMPILER_PYTHON
    let v9 : Async<string option> = null |> unbox<Async<string option>>
    v9
#endif
    |> fun x -> _v1 <- Some x
    let v10 : Async<string option> = _v1.Value
    v10
and method15 (v0 : string) : string =
    v0
and method16 (v0 : string) : string =
    v0
and closure37 () (v0 : chrono_DateTime<chrono_Utc>) : US8 =
    US8_0(v0)
and method17 () : (chrono_DateTime<chrono_Utc> -> US8) =
    closure37()
and method18 (v0 : chrono_DateTime<chrono_Utc>) : chrono_DateTime<chrono_Utc> =
    v0
and method19 (v0 : chrono_DateTime<chrono_Local>) : chrono_DateTime<chrono_Local> =
    v0
and method20 () : string =
    let v0 : string = "yyyyMMdd-HHmm-ssff-ffff-f"
    v0
and method21 () : string =
    let v0 : string = "hhmm"
    v0
and closure36 () () : string =
    let v0 : string option = None
    let v1 : bool = true in let mutable _v0 = v0
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string option = None
    let v3 : bool = true in let mutable _v2 = v2
    
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
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v8 : string = System.Reflection.Assembly.GetEntryAssembly().GetName().Name
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
    |> fun x -> _v2 <- Some x
    let v11 : string = _v2.Value
    let v12 : string option = None
    let v13 : bool = true in let mutable _v12 = v12
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v14 : string = "std::env::temp_dir()"
    let v15 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr () v14
    let v16 : string = "$0.display()"
    let v17 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v15 v16
    let v18 : std_string_String option = None
    let v19 : bool = true in let mutable _v18 = v18
    
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
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v26 : std_string_String = null |> unbox<std_string_String>
    v26
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v27 : std_string_String = null |> unbox<std_string_String>
    v27
#endif
    
#if FABLE_COMPILER_PYTHON
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
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v34 : (unit -> string) = System.IO.Path.GetTempPath
    let v35 : string = v34 ()
    v35
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v36 : string = null |> unbox<string>
    v36
#endif
    
#if FABLE_COMPILER_PYTHON
    let v37 : string = null |> unbox<string>
    v37
#endif
    |> fun x -> _v12 <- Some x
    let v38 : string = _v12.Value
    let v39 : string = $"!{v11}"
    let v40 : string option = None
    let v41 : bool = true in let mutable _v40 = v40
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v42 : string = method4(v38)
    let v43 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v44 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v42 v43
    let v45 : string = "String::from($0)"
    let v46 : std_string_String = Fable.Core.RustInterop.emitRustExpr v44 v45
    let v47 : string = "std::path::PathBuf::from($0)"
    let v48 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v46 v47
    let v49 : string = method4(v39)
    let v50 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v51 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v49 v50
    let v52 : string = "String::from($0)"
    let v53 : std_string_String = Fable.Core.RustInterop.emitRustExpr v51 v52
    let v54 : string = "$0.join($1)"
    let v55 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr struct (v48, v53) v54
    let v56 : string = "$0.display()"
    let v57 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v55 v56
    let v58 : std_string_String option = None
    let v59 : bool = true in let mutable _v58 = v58
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v60 : string = @$"format!(""{{}}"", $0)"
    let v61 : std_string_String = Fable.Core.RustInterop.emitRustExpr v57 v60
    v61
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v62 : string = @$"format!(""{{}}"", $0)"
    let v63 : std_string_String = Fable.Core.RustInterop.emitRustExpr v57 v62
    v63
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v64 : string = @$"format!(""{{}}"", $0)"
    let v65 : std_string_String = Fable.Core.RustInterop.emitRustExpr v57 v64
    v65
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v66 : std_string_String = null |> unbox<std_string_String>
    v66
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v67 : std_string_String = null |> unbox<std_string_String>
    v67
#endif
    
#if FABLE_COMPILER_PYTHON
    let v68 : std_string_String = null |> unbox<std_string_String>
    v68
#endif
    |> fun x -> _v58 <- Some x
    let v69 : std_string_String = _v58.Value
    let v70 : string = "fable_library_rust::String_::fromString($0)"
    let v71 : string = Fable.Core.RustInterop.emitRustExpr v69 v70
    v71
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v72 : string = null |> unbox<string>
    v72
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v73 : string = null |> unbox<string>
    v73
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v74 : string = System.IO.Path.Combine (v38, v39)
    v74
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v75 : string = "path"
    let v76 : IPathJoin = Fable.Core.JsInterop.importAll v75
    let v77 : string = method15(v38)
    let v78 : string = method16(v39)
    let v79 : string = "v76.join(v77, v78)"
    let v80 : string = Fable.Core.JsInterop.emitJsExpr () v79
    v80
#endif
    
#if FABLE_COMPILER_PYTHON
    let v81 : string = null |> unbox<string>
    v81
#endif
    |> fun x -> _v40 <- Some x
    let v82 : string = _v40.Value
    let v83 : System.DateTime = System.DateTime.Now
    let v84 : System.Guid = System.Guid.NewGuid ()
    let v85 : (System.Guid -> string) = _.ToString()
    let v86 : string = v85 v84
    let v87 : struct (string * string) option = None
    let v88 : bool = true in let mutable _v87 = v87
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v89 : System.DateTime = System.DateTime (1970, 1, 1, 0, 0, 0, System.DateTimeKind.Utc)
    let v90 : (System.DateTime -> System.DateTime) = _.ToUniversalTime()
    let v91 : System.DateTime = v90 v89
    let v92 : System.DateTimeKind = System.DateTimeKind.Local
    let v93 : System.DateTime = System.DateTime.SpecifyKind (v83, v92)
    let v94 : (System.DateTime -> System.DateTime) = _.ToUniversalTime()
    let v95 : System.DateTime = v94 v93
    let v96 : (System.DateTime -> int64) = _.Ticks
    let v97 : int64 = v96 v95
    let v98 : (System.DateTime -> int64) = _.Ticks
    let v99 : int64 = v98 v91
    let v100 : int64 = v97 - v99
    let v101 : int64 = v100 / 10L
    let v102 : string = "chrono::DateTime::from_timestamp_micros($0)"
    let v103 : chrono_DateTime<chrono_Utc> option = Fable.Core.RustInterop.emitRustExpr v101 v102
    let v104 : (chrono_DateTime<chrono_Utc> -> US8) = method17()
    let v105 : US8 = US8_1
    let v106 : US8 = v103 |> Option.map v104 |> Option.defaultValue v105 
    let v125 : US9 =
        match v106 with
        | US8_1 -> (* None *)
            US9_1
        | US8_0(v107) -> (* Some *)
            let v108 : chrono_DateTime<chrono_Utc> = method18(v107)
            let v109 : string = "v108.naive_utc()"
            let v110 : chrono_NaiveDateTime = Fable.Core.RustInterop.emitRustExpr () v109
            let v111 : string = "chrono::offset::TimeZone::from_utc_datetime(&chrono::Local, &v110)"
            let v112 : chrono_DateTime<chrono_Local> = Fable.Core.RustInterop.emitRustExpr () v111
            let v113 : string = "%Y%m%d-%H%M-%S%f"
            let v114 : string = "r#\"" + v113 + "\"#"
            let v115 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v114
            let v116 : chrono_DateTime<chrono_Local> = method19(v112)
            let v117 : string = "v116.format(v115).to_string()"
            let v118 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v117
            let v119 : string = "fable_library_rust::String_::fromString($0)"
            let v120 : string = Fable.Core.RustInterop.emitRustExpr v118 v119
            let v121 : string = $"{v120.[0..17]}-{v120.[18..21]}-{v120.[22]}"
            US9_0(v121)
    let v129 : string =
        match v125 with
        | US9_1 -> (* None *)
            let v127 : string = ""
            v127
        | US9_0(v126) -> (* Some *)
            v126
    let v130 : System.TimeZoneInfo option = None
    let v131 : bool = true in let mutable _v130 = v130
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v132 : string = "0i64.into()"
    let v133 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v132
    v133
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v134 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v134
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v135 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v135
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v136 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    v136
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v137 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v137
#endif
    
#if FABLE_COMPILER_PYTHON
    let v138 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v138
#endif
    |> fun x -> _v130 <- Some x
    let v139 : System.TimeZoneInfo = _v130.Value
    let v140 : System.TimeSpan option = None
    let v141 : bool = true in let mutable _v140 = v140
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v142 : System.TimeSpan = System.TimeSpan () 
    v142
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v143 : System.TimeSpan = System.TimeSpan () 
    v143
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v144 : System.TimeSpan = System.TimeSpan () 
    v144
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v145 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v146 : System.TimeZoneInfo option = None
    let v147 : bool = true in let mutable _v146 = v146
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v148 : string = "0i64.into()"
    let v149 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v148
    v149
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v150 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v150
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v151 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v151
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v152 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    v152
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v153 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v153
#endif
    
#if FABLE_COMPILER_PYTHON
    let v154 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v154
#endif
    |> fun x -> _v146 <- Some x
    let v155 : System.TimeZoneInfo = _v146.Value
    let v156 : (System.DateTime -> System.TimeSpan) = v145 v155
    let v157 : System.TimeSpan = v156 v95
    v157
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v158 : System.TimeSpan = System.TimeSpan () 
    v158
#endif
    
#if FABLE_COMPILER_PYTHON
    let v159 : System.TimeSpan = System.TimeSpan () 
    v159
#endif
    |> fun x -> _v140 <- Some x
    let v160 : System.TimeSpan = _v140.Value
    let v161 : (System.TimeSpan -> int32) = _.Hours
    let v162 : int32 = v161 v160
    let v163 : bool = v162 > 0
    let v164 : uint8 =
        if v163 then
            1uy
        else
            0uy
    let v165 : (string -> string) = v160.ToString
    let v166 : string = "hh:mm"
    let v167 : string = v165 v166
    let v168 : string = $"{v164}{v167.[0..1]}{v167.[3..4]}"
    struct (v129, v168)
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let struct (v169 : string, v170 : string) = null |> unbox<struct (string * string)>
    struct (v169, v170)
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let struct (v171 : string, v172 : string) = null |> unbox<struct (string * string)>
    struct (v171, v172)
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v173 : string = method20()
    let v174 : (string -> string) = v83.ToString
    let v175 : string = v174 v173
    let v176 : System.TimeZoneInfo option = None
    let v177 : bool = true in let mutable _v176 = v176
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v178 : string = "0i64.into()"
    let v179 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v178
    v179
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v180 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v180
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v181 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v181
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v182 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    v182
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v183 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v183
#endif
    
#if FABLE_COMPILER_PYTHON
    let v184 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v184
#endif
    |> fun x -> _v176 <- Some x
    let v185 : System.TimeZoneInfo = _v176.Value
    let v186 : System.TimeSpan option = None
    let v187 : bool = true in let mutable _v186 = v186
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v188 : System.TimeSpan = System.TimeSpan () 
    v188
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v189 : System.TimeSpan = System.TimeSpan () 
    v189
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v190 : System.TimeSpan = System.TimeSpan () 
    v190
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v191 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v192 : System.TimeZoneInfo option = None
    let v193 : bool = true in let mutable _v192 = v192
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v194 : string = "0i64.into()"
    let v195 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v194
    v195
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v196 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v196
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v197 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v197
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v198 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    v198
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v199 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v199
#endif
    
#if FABLE_COMPILER_PYTHON
    let v200 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v200
#endif
    |> fun x -> _v192 <- Some x
    let v201 : System.TimeZoneInfo = _v192.Value
    let v202 : (System.DateTime -> System.TimeSpan) = v191 v201
    let v203 : System.TimeSpan = v202 v83
    v203
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v204 : System.TimeSpan = System.TimeSpan () 
    v204
#endif
    
#if FABLE_COMPILER_PYTHON
    let v205 : System.TimeSpan = System.TimeSpan () 
    v205
#endif
    |> fun x -> _v186 <- Some x
    let v206 : System.TimeSpan = _v186.Value
    let v207 : (System.TimeSpan -> int32) = _.Hours
    let v208 : int32 = v207 v206
    let v209 : bool = v208 > 0
    let v210 : (bool -> int32) = System.Convert.ToInt32
    let v211 : int32 = v210 v209
    let v212 : string = method21()
    let v213 : (string -> string) = v206.ToString
    let v214 : string = v213 v212
    let v215 : string = $"{v211}{v214}"
    struct (v175, v215)
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let struct (v216 : string, v217 : string) = null |> unbox<struct (string * string)>
    struct (v216, v217)
#endif
    
#if FABLE_COMPILER_PYTHON
    let struct (v218 : string, v219 : string) = null |> unbox<struct (string * string)>
    struct (v218, v219)
#endif
    |> fun x -> _v87 <- Some x
    let struct (v220 : string, v221 : string) = _v87.Value
    let v222 : System.Guid = System.Guid $"{v220}{v221}{v86.[v220.Length + v221.Length..]}"
    let v223 : (System.Guid -> string) = _.ToString()
    let v224 : string = v223 v222
    let v225 : string option = None
    let v226 : bool = true in let mutable _v225 = v225
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v227 : string = method4(v82)
    let v228 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v229 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v227 v228
    let v230 : string = "String::from($0)"
    let v231 : std_string_String = Fable.Core.RustInterop.emitRustExpr v229 v230
    let v232 : string = "std::path::PathBuf::from($0)"
    let v233 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v231 v232
    let v234 : string = method4(v224)
    let v235 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v236 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v234 v235
    let v237 : string = "String::from($0)"
    let v238 : std_string_String = Fable.Core.RustInterop.emitRustExpr v236 v237
    let v239 : string = "$0.join($1)"
    let v240 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr struct (v233, v238) v239
    let v241 : string = "$0.display()"
    let v242 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v240 v241
    let v243 : std_string_String option = None
    let v244 : bool = true in let mutable _v243 = v243
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v245 : string = @$"format!(""{{}}"", $0)"
    let v246 : std_string_String = Fable.Core.RustInterop.emitRustExpr v242 v245
    v246
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v247 : string = @$"format!(""{{}}"", $0)"
    let v248 : std_string_String = Fable.Core.RustInterop.emitRustExpr v242 v247
    v248
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v249 : string = @$"format!(""{{}}"", $0)"
    let v250 : std_string_String = Fable.Core.RustInterop.emitRustExpr v242 v249
    v250
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v251 : std_string_String = null |> unbox<std_string_String>
    v251
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v252 : std_string_String = null |> unbox<std_string_String>
    v252
#endif
    
#if FABLE_COMPILER_PYTHON
    let v253 : std_string_String = null |> unbox<std_string_String>
    v253
#endif
    |> fun x -> _v243 <- Some x
    let v254 : std_string_String = _v243.Value
    let v255 : string = "fable_library_rust::String_::fromString($0)"
    let v256 : string = Fable.Core.RustInterop.emitRustExpr v254 v255
    v256
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v257 : string = null |> unbox<string>
    v257
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v258 : string = null |> unbox<string>
    v258
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v259 : string = System.IO.Path.Combine (v82, v224)
    v259
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v260 : IPathJoin = Fable.Core.JsInterop.importAll v75
    let v261 : string = method15(v82)
    let v262 : string = method16(v224)
    let v263 : string = "v260.join(v261, v262)"
    let v264 : string = Fable.Core.JsInterop.emitJsExpr () v263
    v264
#endif
    
#if FABLE_COMPILER_PYTHON
    let v265 : string = null |> unbox<string>
    v265
#endif
    |> fun x -> _v225 <- Some x
    let v266 : string = _v225.Value
    v266
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v267 : string = null |> unbox<string>
    v267
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v268 : string = null |> unbox<string>
    v268
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v269 : string option = None
    let v270 : bool = true in let mutable _v269 = v269
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v271 : string = "env!(\"CARGO_PKG_NAME\").into()"
    let v272 : string = Fable.Core.RustInterop.emitRustExpr () v271
    v272
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v273 : string = null |> unbox<string>
    v273
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v274 : string = null |> unbox<string>
    v274
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v275 : string = System.Reflection.Assembly.GetEntryAssembly().GetName().Name
    v275
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v276 : string = null |> unbox<string>
    v276
#endif
    
#if FABLE_COMPILER_PYTHON
    let v277 : string = null |> unbox<string>
    v277
#endif
    |> fun x -> _v269 <- Some x
    let v278 : string = _v269.Value
    let v279 : string option = None
    let v280 : bool = true in let mutable _v279 = v279
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v281 : string = "std::env::temp_dir()"
    let v282 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr () v281
    let v283 : string = "$0.display()"
    let v284 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v282 v283
    let v285 : std_string_String option = None
    let v286 : bool = true in let mutable _v285 = v285
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v287 : string = @$"format!(""{{}}"", $0)"
    let v288 : std_string_String = Fable.Core.RustInterop.emitRustExpr v284 v287
    v288
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v289 : string = @$"format!(""{{}}"", $0)"
    let v290 : std_string_String = Fable.Core.RustInterop.emitRustExpr v284 v289
    v290
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v291 : string = @$"format!(""{{}}"", $0)"
    let v292 : std_string_String = Fable.Core.RustInterop.emitRustExpr v284 v291
    v292
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v293 : std_string_String = null |> unbox<std_string_String>
    v293
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v294 : std_string_String = null |> unbox<std_string_String>
    v294
#endif
    
#if FABLE_COMPILER_PYTHON
    let v295 : std_string_String = null |> unbox<std_string_String>
    v295
#endif
    |> fun x -> _v285 <- Some x
    let v296 : std_string_String = _v285.Value
    let v297 : string = "fable_library_rust::String_::fromString($0)"
    let v298 : string = Fable.Core.RustInterop.emitRustExpr v296 v297
    v298
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v299 : string = null |> unbox<string>
    v299
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v300 : string = null |> unbox<string>
    v300
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v301 : (unit -> string) = System.IO.Path.GetTempPath
    let v302 : string = v301 ()
    v302
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v303 : string = null |> unbox<string>
    v303
#endif
    
#if FABLE_COMPILER_PYTHON
    let v304 : string = null |> unbox<string>
    v304
#endif
    |> fun x -> _v279 <- Some x
    let v305 : string = _v279.Value
    let v306 : string = $"!{v278}"
    let v307 : string option = None
    let v308 : bool = true in let mutable _v307 = v307
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v309 : string = method4(v305)
    let v310 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v311 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v309 v310
    let v312 : string = "String::from($0)"
    let v313 : std_string_String = Fable.Core.RustInterop.emitRustExpr v311 v312
    let v314 : string = "std::path::PathBuf::from($0)"
    let v315 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v313 v314
    let v316 : string = method4(v306)
    let v317 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v318 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v316 v317
    let v319 : string = "String::from($0)"
    let v320 : std_string_String = Fable.Core.RustInterop.emitRustExpr v318 v319
    let v321 : string = "$0.join($1)"
    let v322 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr struct (v315, v320) v321
    let v323 : string = "$0.display()"
    let v324 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v322 v323
    let v325 : std_string_String option = None
    let v326 : bool = true in let mutable _v325 = v325
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v327 : string = @$"format!(""{{}}"", $0)"
    let v328 : std_string_String = Fable.Core.RustInterop.emitRustExpr v324 v327
    v328
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v329 : string = @$"format!(""{{}}"", $0)"
    let v330 : std_string_String = Fable.Core.RustInterop.emitRustExpr v324 v329
    v330
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v331 : string = @$"format!(""{{}}"", $0)"
    let v332 : std_string_String = Fable.Core.RustInterop.emitRustExpr v324 v331
    v332
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v333 : std_string_String = null |> unbox<std_string_String>
    v333
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v334 : std_string_String = null |> unbox<std_string_String>
    v334
#endif
    
#if FABLE_COMPILER_PYTHON
    let v335 : std_string_String = null |> unbox<std_string_String>
    v335
#endif
    |> fun x -> _v325 <- Some x
    let v336 : std_string_String = _v325.Value
    let v337 : string = "fable_library_rust::String_::fromString($0)"
    let v338 : string = Fable.Core.RustInterop.emitRustExpr v336 v337
    v338
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v339 : string = null |> unbox<string>
    v339
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v340 : string = null |> unbox<string>
    v340
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v341 : string = System.IO.Path.Combine (v305, v306)
    v341
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v342 : IPathJoin = Fable.Core.JsInterop.importAll v75
    let v343 : string = method15(v305)
    let v344 : string = method16(v306)
    let v345 : string = "v342.join(v343, v344)"
    let v346 : string = Fable.Core.JsInterop.emitJsExpr () v345
    v346
#endif
    
#if FABLE_COMPILER_PYTHON
    let v347 : string = null |> unbox<string>
    v347
#endif
    |> fun x -> _v307 <- Some x
    let v348 : string = _v307.Value
    let v349 : System.DateTime = System.DateTime.Now
    let v350 : System.Guid = System.Guid.NewGuid ()
    let v351 : (System.Guid -> string) = _.ToString()
    let v352 : string = v351 v350
    let v353 : struct (string * string) option = None
    let v354 : bool = true in let mutable _v353 = v353
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v355 : System.DateTime = System.DateTime (1970, 1, 1, 0, 0, 0, System.DateTimeKind.Utc)
    let v356 : (System.DateTime -> System.DateTime) = _.ToUniversalTime()
    let v357 : System.DateTime = v356 v355
    let v358 : System.DateTimeKind = System.DateTimeKind.Local
    let v359 : System.DateTime = System.DateTime.SpecifyKind (v349, v358)
    let v360 : (System.DateTime -> System.DateTime) = _.ToUniversalTime()
    let v361 : System.DateTime = v360 v359
    let v362 : (System.DateTime -> int64) = _.Ticks
    let v363 : int64 = v362 v361
    let v364 : (System.DateTime -> int64) = _.Ticks
    let v365 : int64 = v364 v357
    let v366 : int64 = v363 - v365
    let v367 : int64 = v366 / 10L
    let v368 : string = "chrono::DateTime::from_timestamp_micros($0)"
    let v369 : chrono_DateTime<chrono_Utc> option = Fable.Core.RustInterop.emitRustExpr v367 v368
    let v370 : (chrono_DateTime<chrono_Utc> -> US8) = method17()
    let v371 : US8 = US8_1
    let v372 : US8 = v369 |> Option.map v370 |> Option.defaultValue v371 
    let v391 : US9 =
        match v372 with
        | US8_1 -> (* None *)
            US9_1
        | US8_0(v373) -> (* Some *)
            let v374 : chrono_DateTime<chrono_Utc> = method18(v373)
            let v375 : string = "v374.naive_utc()"
            let v376 : chrono_NaiveDateTime = Fable.Core.RustInterop.emitRustExpr () v375
            let v377 : string = "chrono::offset::TimeZone::from_utc_datetime(&chrono::Local, &v376)"
            let v378 : chrono_DateTime<chrono_Local> = Fable.Core.RustInterop.emitRustExpr () v377
            let v379 : string = "%Y%m%d-%H%M-%S%f"
            let v380 : string = "r#\"" + v379 + "\"#"
            let v381 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v380
            let v382 : chrono_DateTime<chrono_Local> = method19(v378)
            let v383 : string = "v382.format(v381).to_string()"
            let v384 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v383
            let v385 : string = "fable_library_rust::String_::fromString($0)"
            let v386 : string = Fable.Core.RustInterop.emitRustExpr v384 v385
            let v387 : string = $"{v386.[0..17]}-{v386.[18..21]}-{v386.[22]}"
            US9_0(v387)
    let v395 : string =
        match v391 with
        | US9_1 -> (* None *)
            let v393 : string = ""
            v393
        | US9_0(v392) -> (* Some *)
            v392
    let v396 : System.TimeZoneInfo option = None
    let v397 : bool = true in let mutable _v396 = v396
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v398 : string = "0i64.into()"
    let v399 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v398
    v399
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v400 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v400
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v401 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v401
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v402 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    v402
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v403 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v403
#endif
    
#if FABLE_COMPILER_PYTHON
    let v404 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v404
#endif
    |> fun x -> _v396 <- Some x
    let v405 : System.TimeZoneInfo = _v396.Value
    let v406 : System.TimeSpan option = None
    let v407 : bool = true in let mutable _v406 = v406
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v408 : System.TimeSpan = System.TimeSpan () 
    v408
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v409 : System.TimeSpan = System.TimeSpan () 
    v409
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v410 : System.TimeSpan = System.TimeSpan () 
    v410
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v411 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v412 : System.TimeZoneInfo option = None
    let v413 : bool = true in let mutable _v412 = v412
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v414 : string = "0i64.into()"
    let v415 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v414
    v415
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v416 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v416
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v417 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v417
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v418 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    v418
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v419 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v419
#endif
    
#if FABLE_COMPILER_PYTHON
    let v420 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v420
#endif
    |> fun x -> _v412 <- Some x
    let v421 : System.TimeZoneInfo = _v412.Value
    let v422 : (System.DateTime -> System.TimeSpan) = v411 v421
    let v423 : System.TimeSpan = v422 v361
    v423
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v424 : System.TimeSpan = System.TimeSpan () 
    v424
#endif
    
#if FABLE_COMPILER_PYTHON
    let v425 : System.TimeSpan = System.TimeSpan () 
    v425
#endif
    |> fun x -> _v406 <- Some x
    let v426 : System.TimeSpan = _v406.Value
    let v427 : (System.TimeSpan -> int32) = _.Hours
    let v428 : int32 = v427 v426
    let v429 : bool = v428 > 0
    let v430 : uint8 =
        if v429 then
            1uy
        else
            0uy
    let v431 : (string -> string) = v426.ToString
    let v432 : string = v431 v166
    let v433 : string = $"{v430}{v432.[0..1]}{v432.[3..4]}"
    struct (v395, v433)
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let struct (v434 : string, v435 : string) = null |> unbox<struct (string * string)>
    struct (v434, v435)
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let struct (v436 : string, v437 : string) = null |> unbox<struct (string * string)>
    struct (v436, v437)
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v438 : string = method20()
    let v439 : (string -> string) = v349.ToString
    let v440 : string = v439 v438
    let v441 : System.TimeZoneInfo option = None
    let v442 : bool = true in let mutable _v441 = v441
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v443 : string = "0i64.into()"
    let v444 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v443
    v444
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v445 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v445
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v446 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v446
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v447 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    v447
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v448 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v448
#endif
    
#if FABLE_COMPILER_PYTHON
    let v449 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v449
#endif
    |> fun x -> _v441 <- Some x
    let v450 : System.TimeZoneInfo = _v441.Value
    let v451 : System.TimeSpan option = None
    let v452 : bool = true in let mutable _v451 = v451
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v453 : System.TimeSpan = System.TimeSpan () 
    v453
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v454 : System.TimeSpan = System.TimeSpan () 
    v454
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v455 : System.TimeSpan = System.TimeSpan () 
    v455
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v456 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v457 : System.TimeZoneInfo option = None
    let v458 : bool = true in let mutable _v457 = v457
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v459 : string = "0i64.into()"
    let v460 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v459
    v460
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v461 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v461
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v462 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v462
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v463 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    v463
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v464 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v464
#endif
    
#if FABLE_COMPILER_PYTHON
    let v465 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v465
#endif
    |> fun x -> _v457 <- Some x
    let v466 : System.TimeZoneInfo = _v457.Value
    let v467 : (System.DateTime -> System.TimeSpan) = v456 v466
    let v468 : System.TimeSpan = v467 v349
    v468
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v469 : System.TimeSpan = System.TimeSpan () 
    v469
#endif
    
#if FABLE_COMPILER_PYTHON
    let v470 : System.TimeSpan = System.TimeSpan () 
    v470
#endif
    |> fun x -> _v451 <- Some x
    let v471 : System.TimeSpan = _v451.Value
    let v472 : (System.TimeSpan -> int32) = _.Hours
    let v473 : int32 = v472 v471
    let v474 : bool = v473 > 0
    let v475 : (bool -> int32) = System.Convert.ToInt32
    let v476 : int32 = v475 v474
    let v477 : string = method21()
    let v478 : (string -> string) = v471.ToString
    let v479 : string = v478 v477
    let v480 : string = $"{v476}{v479}"
    struct (v440, v480)
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let struct (v481 : string, v482 : string) = null |> unbox<struct (string * string)>
    struct (v481, v482)
#endif
    
#if FABLE_COMPILER_PYTHON
    let struct (v483 : string, v484 : string) = null |> unbox<struct (string * string)>
    struct (v483, v484)
#endif
    |> fun x -> _v353 <- Some x
    let struct (v485 : string, v486 : string) = _v353.Value
    let v487 : System.Guid = System.Guid $"{v485}{v486}{v352.[v485.Length + v486.Length..]}"
    let v488 : (System.Guid -> string) = _.ToString()
    let v489 : string = v488 v487
    let v490 : string option = None
    let v491 : bool = true in let mutable _v490 = v490
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v492 : string = method4(v348)
    let v493 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v494 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v492 v493
    let v495 : string = "String::from($0)"
    let v496 : std_string_String = Fable.Core.RustInterop.emitRustExpr v494 v495
    let v497 : string = "std::path::PathBuf::from($0)"
    let v498 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v496 v497
    let v499 : string = method4(v489)
    let v500 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v501 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v499 v500
    let v502 : string = "String::from($0)"
    let v503 : std_string_String = Fable.Core.RustInterop.emitRustExpr v501 v502
    let v504 : string = "$0.join($1)"
    let v505 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr struct (v498, v503) v504
    let v506 : string = "$0.display()"
    let v507 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v505 v506
    let v508 : std_string_String option = None
    let v509 : bool = true in let mutable _v508 = v508
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v510 : string = @$"format!(""{{}}"", $0)"
    let v511 : std_string_String = Fable.Core.RustInterop.emitRustExpr v507 v510
    v511
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v512 : string = @$"format!(""{{}}"", $0)"
    let v513 : std_string_String = Fable.Core.RustInterop.emitRustExpr v507 v512
    v513
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v514 : string = @$"format!(""{{}}"", $0)"
    let v515 : std_string_String = Fable.Core.RustInterop.emitRustExpr v507 v514
    v515
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v516 : std_string_String = null |> unbox<std_string_String>
    v516
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v517 : std_string_String = null |> unbox<std_string_String>
    v517
#endif
    
#if FABLE_COMPILER_PYTHON
    let v518 : std_string_String = null |> unbox<std_string_String>
    v518
#endif
    |> fun x -> _v508 <- Some x
    let v519 : std_string_String = _v508.Value
    let v520 : string = "fable_library_rust::String_::fromString($0)"
    let v521 : string = Fable.Core.RustInterop.emitRustExpr v519 v520
    v521
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v522 : string = null |> unbox<string>
    v522
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v523 : string = null |> unbox<string>
    v523
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v524 : string = System.IO.Path.Combine (v348, v489)
    v524
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v525 : IPathJoin = Fable.Core.JsInterop.importAll v75
    let v526 : string = method15(v348)
    let v527 : string = method16(v489)
    let v528 : string = "v525.join(v526, v527)"
    let v529 : string = Fable.Core.JsInterop.emitJsExpr () v528
    v529
#endif
    
#if FABLE_COMPILER_PYTHON
    let v530 : string = null |> unbox<string>
    v530
#endif
    |> fun x -> _v490 <- Some x
    let v531 : string = _v490.Value
    v531
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v532 : string = null |> unbox<string>
    v532
#endif
    
#if FABLE_COMPILER_PYTHON
    let v533 : string = null |> unbox<string>
    v533
#endif
    |> fun x -> _v0 <- Some x
    let v534 : string = _v0.Value
    v534
and method22 (v0 : string) : string =
    v0
and closure39 () (v0 : std_io_Error) : std_string_String =
    let v1 : std_string_String option = None
    let v2 : bool = true in let mutable _v1 = v1
    
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
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v9 : std_string_String = null |> unbox<std_string_String>
    v9
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v10 : std_string_String = null |> unbox<std_string_String>
    v10
#endif
    
#if FABLE_COMPILER_PYTHON
    let v11 : std_string_String = null |> unbox<std_string_String>
    v11
#endif
    |> fun x -> _v1 <- Some x
    let v12 : std_string_String = _v1.Value
    v12
and method23 () : (std_io_Error -> std_string_String) =
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
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : string = method3(v0)
    let v4 : bool option = None
    let v5 : bool = true in let mutable _v4 = v4
    
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
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v20 : (string -> bool) = System.IO.Directory.Exists
    let v21 : bool = v20 v3
    v21
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v22 : string = "fs"
    let v23 : IFsExistsSync = Fable.Core.JsInterop.importAll v22
    let v24 : string = "v23.existsSync($0)"
    let v25 : bool = Fable.Core.JsInterop.emitJsExpr v3 v24
    v25
#endif
    
#if FABLE_COMPILER_PYTHON
    let v26 : bool = null |> unbox<bool>
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
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    System.IO.Directory.Delete (v0, true)
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
    |> fun x -> _v1 <- Some x
    _v1.Value
    ()
and method24 (v0 : string) : (unit -> unit) =
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
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v6 : int64 = 0L
    let v7 : Async<int64> = method2(v0, v6)
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
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v16 : (Async<int64> -> Async<unit>) = Async.Ignore
    let v17 : Async<unit> = v16 v10
    v17
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v18 : Async<unit> = null |> unbox<Async<unit>>
    v18
#endif
    
#if FABLE_COMPILER_PYTHON
    let v19 : Async<unit> = null |> unbox<Async<unit>>
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
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v23 : (Async<unit> -> unit) = Async.RunSynchronously
    v23 v20
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
    |> fun x -> _v21 <- Some x
    _v21.Value
    ()
and method25 (v0 : string) : (unit -> unit) =
    closure49(v0)
and closure38 () () : struct (string * System.IDisposable) =
    let v0 : string option = None
    let v1 : bool = true in let mutable _v0 = v0
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string option = None
    let v3 : bool = true in let mutable _v2 = v2
    
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
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v8 : string = System.Reflection.Assembly.GetEntryAssembly().GetName().Name
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
    |> fun x -> _v2 <- Some x
    let v11 : string = _v2.Value
    let v12 : string option = None
    let v13 : bool = true in let mutable _v12 = v12
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v14 : string = "std::env::temp_dir()"
    let v15 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr () v14
    let v16 : string = "$0.display()"
    let v17 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v15 v16
    let v18 : std_string_String option = None
    let v19 : bool = true in let mutable _v18 = v18
    
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
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v26 : std_string_String = null |> unbox<std_string_String>
    v26
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v27 : std_string_String = null |> unbox<std_string_String>
    v27
#endif
    
#if FABLE_COMPILER_PYTHON
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
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v34 : (unit -> string) = System.IO.Path.GetTempPath
    let v35 : string = v34 ()
    v35
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v36 : string = null |> unbox<string>
    v36
#endif
    
#if FABLE_COMPILER_PYTHON
    let v37 : string = null |> unbox<string>
    v37
#endif
    |> fun x -> _v12 <- Some x
    let v38 : string = _v12.Value
    let v39 : string = $"!{v11}"
    let v40 : string option = None
    let v41 : bool = true in let mutable _v40 = v40
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v42 : string = method4(v38)
    let v43 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v44 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v42 v43
    let v45 : string = "String::from($0)"
    let v46 : std_string_String = Fable.Core.RustInterop.emitRustExpr v44 v45
    let v47 : string = "std::path::PathBuf::from($0)"
    let v48 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v46 v47
    let v49 : string = method4(v39)
    let v50 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v51 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v49 v50
    let v52 : string = "String::from($0)"
    let v53 : std_string_String = Fable.Core.RustInterop.emitRustExpr v51 v52
    let v54 : string = "$0.join($1)"
    let v55 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr struct (v48, v53) v54
    let v56 : string = "$0.display()"
    let v57 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v55 v56
    let v58 : std_string_String option = None
    let v59 : bool = true in let mutable _v58 = v58
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v60 : string = @$"format!(""{{}}"", $0)"
    let v61 : std_string_String = Fable.Core.RustInterop.emitRustExpr v57 v60
    v61
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v62 : string = @$"format!(""{{}}"", $0)"
    let v63 : std_string_String = Fable.Core.RustInterop.emitRustExpr v57 v62
    v63
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v64 : string = @$"format!(""{{}}"", $0)"
    let v65 : std_string_String = Fable.Core.RustInterop.emitRustExpr v57 v64
    v65
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v66 : std_string_String = null |> unbox<std_string_String>
    v66
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v67 : std_string_String = null |> unbox<std_string_String>
    v67
#endif
    
#if FABLE_COMPILER_PYTHON
    let v68 : std_string_String = null |> unbox<std_string_String>
    v68
#endif
    |> fun x -> _v58 <- Some x
    let v69 : std_string_String = _v58.Value
    let v70 : string = "fable_library_rust::String_::fromString($0)"
    let v71 : string = Fable.Core.RustInterop.emitRustExpr v69 v70
    v71
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v72 : string = null |> unbox<string>
    v72
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v73 : string = null |> unbox<string>
    v73
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v74 : string = System.IO.Path.Combine (v38, v39)
    v74
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v75 : string = "path"
    let v76 : IPathJoin = Fable.Core.JsInterop.importAll v75
    let v77 : string = method15(v38)
    let v78 : string = method16(v39)
    let v79 : string = "v76.join(v77, v78)"
    let v80 : string = Fable.Core.JsInterop.emitJsExpr () v79
    v80
#endif
    
#if FABLE_COMPILER_PYTHON
    let v81 : string = null |> unbox<string>
    v81
#endif
    |> fun x -> _v40 <- Some x
    let v82 : string = _v40.Value
    let v83 : System.DateTime = System.DateTime.Now
    let v84 : System.Guid = System.Guid.NewGuid ()
    let v85 : (System.Guid -> string) = _.ToString()
    let v86 : string = v85 v84
    let v87 : struct (string * string) option = None
    let v88 : bool = true in let mutable _v87 = v87
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v89 : System.DateTime = System.DateTime (1970, 1, 1, 0, 0, 0, System.DateTimeKind.Utc)
    let v90 : (System.DateTime -> System.DateTime) = _.ToUniversalTime()
    let v91 : System.DateTime = v90 v89
    let v92 : System.DateTimeKind = System.DateTimeKind.Local
    let v93 : System.DateTime = System.DateTime.SpecifyKind (v83, v92)
    let v94 : (System.DateTime -> System.DateTime) = _.ToUniversalTime()
    let v95 : System.DateTime = v94 v93
    let v96 : (System.DateTime -> int64) = _.Ticks
    let v97 : int64 = v96 v95
    let v98 : (System.DateTime -> int64) = _.Ticks
    let v99 : int64 = v98 v91
    let v100 : int64 = v97 - v99
    let v101 : int64 = v100 / 10L
    let v102 : string = "chrono::DateTime::from_timestamp_micros($0)"
    let v103 : chrono_DateTime<chrono_Utc> option = Fable.Core.RustInterop.emitRustExpr v101 v102
    let v104 : (chrono_DateTime<chrono_Utc> -> US8) = method17()
    let v105 : US8 = US8_1
    let v106 : US8 = v103 |> Option.map v104 |> Option.defaultValue v105 
    let v125 : US9 =
        match v106 with
        | US8_1 -> (* None *)
            US9_1
        | US8_0(v107) -> (* Some *)
            let v108 : chrono_DateTime<chrono_Utc> = method18(v107)
            let v109 : string = "v108.naive_utc()"
            let v110 : chrono_NaiveDateTime = Fable.Core.RustInterop.emitRustExpr () v109
            let v111 : string = "chrono::offset::TimeZone::from_utc_datetime(&chrono::Local, &v110)"
            let v112 : chrono_DateTime<chrono_Local> = Fable.Core.RustInterop.emitRustExpr () v111
            let v113 : string = "%Y%m%d-%H%M-%S%f"
            let v114 : string = "r#\"" + v113 + "\"#"
            let v115 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v114
            let v116 : chrono_DateTime<chrono_Local> = method19(v112)
            let v117 : string = "v116.format(v115).to_string()"
            let v118 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v117
            let v119 : string = "fable_library_rust::String_::fromString($0)"
            let v120 : string = Fable.Core.RustInterop.emitRustExpr v118 v119
            let v121 : string = $"{v120.[0..17]}-{v120.[18..21]}-{v120.[22]}"
            US9_0(v121)
    let v129 : string =
        match v125 with
        | US9_1 -> (* None *)
            let v127 : string = ""
            v127
        | US9_0(v126) -> (* Some *)
            v126
    let v130 : System.TimeZoneInfo option = None
    let v131 : bool = true in let mutable _v130 = v130
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v132 : string = "0i64.into()"
    let v133 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v132
    v133
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v134 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v134
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v135 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v135
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v136 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    v136
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v137 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v137
#endif
    
#if FABLE_COMPILER_PYTHON
    let v138 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v138
#endif
    |> fun x -> _v130 <- Some x
    let v139 : System.TimeZoneInfo = _v130.Value
    let v140 : System.TimeSpan option = None
    let v141 : bool = true in let mutable _v140 = v140
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v142 : System.TimeSpan = System.TimeSpan () 
    v142
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v143 : System.TimeSpan = System.TimeSpan () 
    v143
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v144 : System.TimeSpan = System.TimeSpan () 
    v144
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v145 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v146 : System.TimeZoneInfo option = None
    let v147 : bool = true in let mutable _v146 = v146
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v148 : string = "0i64.into()"
    let v149 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v148
    v149
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v150 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v150
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v151 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v151
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v152 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    v152
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v153 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v153
#endif
    
#if FABLE_COMPILER_PYTHON
    let v154 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v154
#endif
    |> fun x -> _v146 <- Some x
    let v155 : System.TimeZoneInfo = _v146.Value
    let v156 : (System.DateTime -> System.TimeSpan) = v145 v155
    let v157 : System.TimeSpan = v156 v95
    v157
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v158 : System.TimeSpan = System.TimeSpan () 
    v158
#endif
    
#if FABLE_COMPILER_PYTHON
    let v159 : System.TimeSpan = System.TimeSpan () 
    v159
#endif
    |> fun x -> _v140 <- Some x
    let v160 : System.TimeSpan = _v140.Value
    let v161 : (System.TimeSpan -> int32) = _.Hours
    let v162 : int32 = v161 v160
    let v163 : bool = v162 > 0
    let v164 : uint8 =
        if v163 then
            1uy
        else
            0uy
    let v165 : (string -> string) = v160.ToString
    let v166 : string = "hh:mm"
    let v167 : string = v165 v166
    let v168 : string = $"{v164}{v167.[0..1]}{v167.[3..4]}"
    struct (v129, v168)
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let struct (v169 : string, v170 : string) = null |> unbox<struct (string * string)>
    struct (v169, v170)
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let struct (v171 : string, v172 : string) = null |> unbox<struct (string * string)>
    struct (v171, v172)
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v173 : string = method20()
    let v174 : (string -> string) = v83.ToString
    let v175 : string = v174 v173
    let v176 : System.TimeZoneInfo option = None
    let v177 : bool = true in let mutable _v176 = v176
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v178 : string = "0i64.into()"
    let v179 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v178
    v179
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v180 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v180
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v181 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v181
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v182 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    v182
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v183 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v183
#endif
    
#if FABLE_COMPILER_PYTHON
    let v184 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v184
#endif
    |> fun x -> _v176 <- Some x
    let v185 : System.TimeZoneInfo = _v176.Value
    let v186 : System.TimeSpan option = None
    let v187 : bool = true in let mutable _v186 = v186
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v188 : System.TimeSpan = System.TimeSpan () 
    v188
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v189 : System.TimeSpan = System.TimeSpan () 
    v189
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v190 : System.TimeSpan = System.TimeSpan () 
    v190
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v191 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v192 : System.TimeZoneInfo option = None
    let v193 : bool = true in let mutable _v192 = v192
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v194 : string = "0i64.into()"
    let v195 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v194
    v195
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v196 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v196
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v197 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v197
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v198 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    v198
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v199 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v199
#endif
    
#if FABLE_COMPILER_PYTHON
    let v200 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v200
#endif
    |> fun x -> _v192 <- Some x
    let v201 : System.TimeZoneInfo = _v192.Value
    let v202 : (System.DateTime -> System.TimeSpan) = v191 v201
    let v203 : System.TimeSpan = v202 v83
    v203
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v204 : System.TimeSpan = System.TimeSpan () 
    v204
#endif
    
#if FABLE_COMPILER_PYTHON
    let v205 : System.TimeSpan = System.TimeSpan () 
    v205
#endif
    |> fun x -> _v186 <- Some x
    let v206 : System.TimeSpan = _v186.Value
    let v207 : (System.TimeSpan -> int32) = _.Hours
    let v208 : int32 = v207 v206
    let v209 : bool = v208 > 0
    let v210 : (bool -> int32) = System.Convert.ToInt32
    let v211 : int32 = v210 v209
    let v212 : string = method21()
    let v213 : (string -> string) = v206.ToString
    let v214 : string = v213 v212
    let v215 : string = $"{v211}{v214}"
    struct (v175, v215)
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let struct (v216 : string, v217 : string) = null |> unbox<struct (string * string)>
    struct (v216, v217)
#endif
    
#if FABLE_COMPILER_PYTHON
    let struct (v218 : string, v219 : string) = null |> unbox<struct (string * string)>
    struct (v218, v219)
#endif
    |> fun x -> _v87 <- Some x
    let struct (v220 : string, v221 : string) = _v87.Value
    let v222 : System.Guid = System.Guid $"{v220}{v221}{v86.[v220.Length + v221.Length..]}"
    let v223 : (System.Guid -> string) = _.ToString()
    let v224 : string = v223 v222
    let v225 : string option = None
    let v226 : bool = true in let mutable _v225 = v225
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v227 : string = method4(v82)
    let v228 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v229 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v227 v228
    let v230 : string = "String::from($0)"
    let v231 : std_string_String = Fable.Core.RustInterop.emitRustExpr v229 v230
    let v232 : string = "std::path::PathBuf::from($0)"
    let v233 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v231 v232
    let v234 : string = method4(v224)
    let v235 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v236 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v234 v235
    let v237 : string = "String::from($0)"
    let v238 : std_string_String = Fable.Core.RustInterop.emitRustExpr v236 v237
    let v239 : string = "$0.join($1)"
    let v240 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr struct (v233, v238) v239
    let v241 : string = "$0.display()"
    let v242 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v240 v241
    let v243 : std_string_String option = None
    let v244 : bool = true in let mutable _v243 = v243
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v245 : string = @$"format!(""{{}}"", $0)"
    let v246 : std_string_String = Fable.Core.RustInterop.emitRustExpr v242 v245
    v246
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v247 : string = @$"format!(""{{}}"", $0)"
    let v248 : std_string_String = Fable.Core.RustInterop.emitRustExpr v242 v247
    v248
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v249 : string = @$"format!(""{{}}"", $0)"
    let v250 : std_string_String = Fable.Core.RustInterop.emitRustExpr v242 v249
    v250
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v251 : std_string_String = null |> unbox<std_string_String>
    v251
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v252 : std_string_String = null |> unbox<std_string_String>
    v252
#endif
    
#if FABLE_COMPILER_PYTHON
    let v253 : std_string_String = null |> unbox<std_string_String>
    v253
#endif
    |> fun x -> _v243 <- Some x
    let v254 : std_string_String = _v243.Value
    let v255 : string = "fable_library_rust::String_::fromString($0)"
    let v256 : string = Fable.Core.RustInterop.emitRustExpr v254 v255
    v256
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v257 : string = null |> unbox<string>
    v257
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v258 : string = null |> unbox<string>
    v258
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v259 : string = System.IO.Path.Combine (v82, v224)
    v259
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v260 : IPathJoin = Fable.Core.JsInterop.importAll v75
    let v261 : string = method15(v82)
    let v262 : string = method16(v224)
    let v263 : string = "v260.join(v261, v262)"
    let v264 : string = Fable.Core.JsInterop.emitJsExpr () v263
    v264
#endif
    
#if FABLE_COMPILER_PYTHON
    let v265 : string = null |> unbox<string>
    v265
#endif
    |> fun x -> _v225 <- Some x
    let v266 : string = _v225.Value
    v266
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v267 : string = null |> unbox<string>
    v267
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v268 : string = null |> unbox<string>
    v268
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v269 : string option = None
    let v270 : bool = true in let mutable _v269 = v269
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v271 : string = "env!(\"CARGO_PKG_NAME\").into()"
    let v272 : string = Fable.Core.RustInterop.emitRustExpr () v271
    v272
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v273 : string = null |> unbox<string>
    v273
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v274 : string = null |> unbox<string>
    v274
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v275 : string = System.Reflection.Assembly.GetEntryAssembly().GetName().Name
    v275
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v276 : string = null |> unbox<string>
    v276
#endif
    
#if FABLE_COMPILER_PYTHON
    let v277 : string = null |> unbox<string>
    v277
#endif
    |> fun x -> _v269 <- Some x
    let v278 : string = _v269.Value
    let v279 : string option = None
    let v280 : bool = true in let mutable _v279 = v279
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v281 : string = "std::env::temp_dir()"
    let v282 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr () v281
    let v283 : string = "$0.display()"
    let v284 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v282 v283
    let v285 : std_string_String option = None
    let v286 : bool = true in let mutable _v285 = v285
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v287 : string = @$"format!(""{{}}"", $0)"
    let v288 : std_string_String = Fable.Core.RustInterop.emitRustExpr v284 v287
    v288
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v289 : string = @$"format!(""{{}}"", $0)"
    let v290 : std_string_String = Fable.Core.RustInterop.emitRustExpr v284 v289
    v290
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v291 : string = @$"format!(""{{}}"", $0)"
    let v292 : std_string_String = Fable.Core.RustInterop.emitRustExpr v284 v291
    v292
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v293 : std_string_String = null |> unbox<std_string_String>
    v293
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v294 : std_string_String = null |> unbox<std_string_String>
    v294
#endif
    
#if FABLE_COMPILER_PYTHON
    let v295 : std_string_String = null |> unbox<std_string_String>
    v295
#endif
    |> fun x -> _v285 <- Some x
    let v296 : std_string_String = _v285.Value
    let v297 : string = "fable_library_rust::String_::fromString($0)"
    let v298 : string = Fable.Core.RustInterop.emitRustExpr v296 v297
    v298
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v299 : string = null |> unbox<string>
    v299
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v300 : string = null |> unbox<string>
    v300
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v301 : (unit -> string) = System.IO.Path.GetTempPath
    let v302 : string = v301 ()
    v302
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v303 : string = null |> unbox<string>
    v303
#endif
    
#if FABLE_COMPILER_PYTHON
    let v304 : string = null |> unbox<string>
    v304
#endif
    |> fun x -> _v279 <- Some x
    let v305 : string = _v279.Value
    let v306 : string = $"!{v278}"
    let v307 : string option = None
    let v308 : bool = true in let mutable _v307 = v307
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v309 : string = method4(v305)
    let v310 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v311 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v309 v310
    let v312 : string = "String::from($0)"
    let v313 : std_string_String = Fable.Core.RustInterop.emitRustExpr v311 v312
    let v314 : string = "std::path::PathBuf::from($0)"
    let v315 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v313 v314
    let v316 : string = method4(v306)
    let v317 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v318 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v316 v317
    let v319 : string = "String::from($0)"
    let v320 : std_string_String = Fable.Core.RustInterop.emitRustExpr v318 v319
    let v321 : string = "$0.join($1)"
    let v322 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr struct (v315, v320) v321
    let v323 : string = "$0.display()"
    let v324 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v322 v323
    let v325 : std_string_String option = None
    let v326 : bool = true in let mutable _v325 = v325
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v327 : string = @$"format!(""{{}}"", $0)"
    let v328 : std_string_String = Fable.Core.RustInterop.emitRustExpr v324 v327
    v328
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v329 : string = @$"format!(""{{}}"", $0)"
    let v330 : std_string_String = Fable.Core.RustInterop.emitRustExpr v324 v329
    v330
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v331 : string = @$"format!(""{{}}"", $0)"
    let v332 : std_string_String = Fable.Core.RustInterop.emitRustExpr v324 v331
    v332
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v333 : std_string_String = null |> unbox<std_string_String>
    v333
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v334 : std_string_String = null |> unbox<std_string_String>
    v334
#endif
    
#if FABLE_COMPILER_PYTHON
    let v335 : std_string_String = null |> unbox<std_string_String>
    v335
#endif
    |> fun x -> _v325 <- Some x
    let v336 : std_string_String = _v325.Value
    let v337 : string = "fable_library_rust::String_::fromString($0)"
    let v338 : string = Fable.Core.RustInterop.emitRustExpr v336 v337
    v338
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v339 : string = null |> unbox<string>
    v339
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v340 : string = null |> unbox<string>
    v340
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v341 : string = System.IO.Path.Combine (v305, v306)
    v341
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v342 : IPathJoin = Fable.Core.JsInterop.importAll v75
    let v343 : string = method15(v305)
    let v344 : string = method16(v306)
    let v345 : string = "v342.join(v343, v344)"
    let v346 : string = Fable.Core.JsInterop.emitJsExpr () v345
    v346
#endif
    
#if FABLE_COMPILER_PYTHON
    let v347 : string = null |> unbox<string>
    v347
#endif
    |> fun x -> _v307 <- Some x
    let v348 : string = _v307.Value
    let v349 : System.DateTime = System.DateTime.Now
    let v350 : System.Guid = System.Guid.NewGuid ()
    let v351 : (System.Guid -> string) = _.ToString()
    let v352 : string = v351 v350
    let v353 : struct (string * string) option = None
    let v354 : bool = true in let mutable _v353 = v353
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v355 : System.DateTime = System.DateTime (1970, 1, 1, 0, 0, 0, System.DateTimeKind.Utc)
    let v356 : (System.DateTime -> System.DateTime) = _.ToUniversalTime()
    let v357 : System.DateTime = v356 v355
    let v358 : System.DateTimeKind = System.DateTimeKind.Local
    let v359 : System.DateTime = System.DateTime.SpecifyKind (v349, v358)
    let v360 : (System.DateTime -> System.DateTime) = _.ToUniversalTime()
    let v361 : System.DateTime = v360 v359
    let v362 : (System.DateTime -> int64) = _.Ticks
    let v363 : int64 = v362 v361
    let v364 : (System.DateTime -> int64) = _.Ticks
    let v365 : int64 = v364 v357
    let v366 : int64 = v363 - v365
    let v367 : int64 = v366 / 10L
    let v368 : string = "chrono::DateTime::from_timestamp_micros($0)"
    let v369 : chrono_DateTime<chrono_Utc> option = Fable.Core.RustInterop.emitRustExpr v367 v368
    let v370 : (chrono_DateTime<chrono_Utc> -> US8) = method17()
    let v371 : US8 = US8_1
    let v372 : US8 = v369 |> Option.map v370 |> Option.defaultValue v371 
    let v391 : US9 =
        match v372 with
        | US8_1 -> (* None *)
            US9_1
        | US8_0(v373) -> (* Some *)
            let v374 : chrono_DateTime<chrono_Utc> = method18(v373)
            let v375 : string = "v374.naive_utc()"
            let v376 : chrono_NaiveDateTime = Fable.Core.RustInterop.emitRustExpr () v375
            let v377 : string = "chrono::offset::TimeZone::from_utc_datetime(&chrono::Local, &v376)"
            let v378 : chrono_DateTime<chrono_Local> = Fable.Core.RustInterop.emitRustExpr () v377
            let v379 : string = "%Y%m%d-%H%M-%S%f"
            let v380 : string = "r#\"" + v379 + "\"#"
            let v381 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v380
            let v382 : chrono_DateTime<chrono_Local> = method19(v378)
            let v383 : string = "v382.format(v381).to_string()"
            let v384 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v383
            let v385 : string = "fable_library_rust::String_::fromString($0)"
            let v386 : string = Fable.Core.RustInterop.emitRustExpr v384 v385
            let v387 : string = $"{v386.[0..17]}-{v386.[18..21]}-{v386.[22]}"
            US9_0(v387)
    let v395 : string =
        match v391 with
        | US9_1 -> (* None *)
            let v393 : string = ""
            v393
        | US9_0(v392) -> (* Some *)
            v392
    let v396 : System.TimeZoneInfo option = None
    let v397 : bool = true in let mutable _v396 = v396
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v398 : string = "0i64.into()"
    let v399 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v398
    v399
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v400 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v400
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v401 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v401
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v402 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    v402
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v403 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v403
#endif
    
#if FABLE_COMPILER_PYTHON
    let v404 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v404
#endif
    |> fun x -> _v396 <- Some x
    let v405 : System.TimeZoneInfo = _v396.Value
    let v406 : System.TimeSpan option = None
    let v407 : bool = true in let mutable _v406 = v406
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v408 : System.TimeSpan = System.TimeSpan () 
    v408
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v409 : System.TimeSpan = System.TimeSpan () 
    v409
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v410 : System.TimeSpan = System.TimeSpan () 
    v410
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v411 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v412 : System.TimeZoneInfo option = None
    let v413 : bool = true in let mutable _v412 = v412
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v414 : string = "0i64.into()"
    let v415 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v414
    v415
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v416 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v416
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v417 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v417
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v418 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    v418
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v419 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v419
#endif
    
#if FABLE_COMPILER_PYTHON
    let v420 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v420
#endif
    |> fun x -> _v412 <- Some x
    let v421 : System.TimeZoneInfo = _v412.Value
    let v422 : (System.DateTime -> System.TimeSpan) = v411 v421
    let v423 : System.TimeSpan = v422 v361
    v423
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v424 : System.TimeSpan = System.TimeSpan () 
    v424
#endif
    
#if FABLE_COMPILER_PYTHON
    let v425 : System.TimeSpan = System.TimeSpan () 
    v425
#endif
    |> fun x -> _v406 <- Some x
    let v426 : System.TimeSpan = _v406.Value
    let v427 : (System.TimeSpan -> int32) = _.Hours
    let v428 : int32 = v427 v426
    let v429 : bool = v428 > 0
    let v430 : uint8 =
        if v429 then
            1uy
        else
            0uy
    let v431 : (string -> string) = v426.ToString
    let v432 : string = v431 v166
    let v433 : string = $"{v430}{v432.[0..1]}{v432.[3..4]}"
    struct (v395, v433)
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let struct (v434 : string, v435 : string) = null |> unbox<struct (string * string)>
    struct (v434, v435)
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let struct (v436 : string, v437 : string) = null |> unbox<struct (string * string)>
    struct (v436, v437)
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v438 : string = method20()
    let v439 : (string -> string) = v349.ToString
    let v440 : string = v439 v438
    let v441 : System.TimeZoneInfo option = None
    let v442 : bool = true in let mutable _v441 = v441
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v443 : string = "0i64.into()"
    let v444 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v443
    v444
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v445 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v445
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v446 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v446
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v447 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    v447
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v448 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v448
#endif
    
#if FABLE_COMPILER_PYTHON
    let v449 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v449
#endif
    |> fun x -> _v441 <- Some x
    let v450 : System.TimeZoneInfo = _v441.Value
    let v451 : System.TimeSpan option = None
    let v452 : bool = true in let mutable _v451 = v451
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v453 : System.TimeSpan = System.TimeSpan () 
    v453
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v454 : System.TimeSpan = System.TimeSpan () 
    v454
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v455 : System.TimeSpan = System.TimeSpan () 
    v455
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v456 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v457 : System.TimeZoneInfo option = None
    let v458 : bool = true in let mutable _v457 = v457
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v459 : string = "0i64.into()"
    let v460 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v459
    v460
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v461 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v461
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v462 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v462
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v463 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    v463
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v464 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v464
#endif
    
#if FABLE_COMPILER_PYTHON
    let v465 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v465
#endif
    |> fun x -> _v457 <- Some x
    let v466 : System.TimeZoneInfo = _v457.Value
    let v467 : (System.DateTime -> System.TimeSpan) = v456 v466
    let v468 : System.TimeSpan = v467 v349
    v468
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v469 : System.TimeSpan = System.TimeSpan () 
    v469
#endif
    
#if FABLE_COMPILER_PYTHON
    let v470 : System.TimeSpan = System.TimeSpan () 
    v470
#endif
    |> fun x -> _v451 <- Some x
    let v471 : System.TimeSpan = _v451.Value
    let v472 : (System.TimeSpan -> int32) = _.Hours
    let v473 : int32 = v472 v471
    let v474 : bool = v473 > 0
    let v475 : (bool -> int32) = System.Convert.ToInt32
    let v476 : int32 = v475 v474
    let v477 : string = method21()
    let v478 : (string -> string) = v471.ToString
    let v479 : string = v478 v477
    let v480 : string = $"{v476}{v479}"
    struct (v440, v480)
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let struct (v481 : string, v482 : string) = null |> unbox<struct (string * string)>
    struct (v481, v482)
#endif
    
#if FABLE_COMPILER_PYTHON
    let struct (v483 : string, v484 : string) = null |> unbox<struct (string * string)>
    struct (v483, v484)
#endif
    |> fun x -> _v353 <- Some x
    let struct (v485 : string, v486 : string) = _v353.Value
    let v487 : System.Guid = System.Guid $"{v485}{v486}{v352.[v485.Length + v486.Length..]}"
    let v488 : (System.Guid -> string) = _.ToString()
    let v489 : string = v488 v487
    let v490 : string option = None
    let v491 : bool = true in let mutable _v490 = v490
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v492 : string = method4(v348)
    let v493 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v494 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v492 v493
    let v495 : string = "String::from($0)"
    let v496 : std_string_String = Fable.Core.RustInterop.emitRustExpr v494 v495
    let v497 : string = "std::path::PathBuf::from($0)"
    let v498 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v496 v497
    let v499 : string = method4(v489)
    let v500 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v501 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v499 v500
    let v502 : string = "String::from($0)"
    let v503 : std_string_String = Fable.Core.RustInterop.emitRustExpr v501 v502
    let v504 : string = "$0.join($1)"
    let v505 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr struct (v498, v503) v504
    let v506 : string = "$0.display()"
    let v507 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v505 v506
    let v508 : std_string_String option = None
    let v509 : bool = true in let mutable _v508 = v508
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v510 : string = @$"format!(""{{}}"", $0)"
    let v511 : std_string_String = Fable.Core.RustInterop.emitRustExpr v507 v510
    v511
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v512 : string = @$"format!(""{{}}"", $0)"
    let v513 : std_string_String = Fable.Core.RustInterop.emitRustExpr v507 v512
    v513
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v514 : string = @$"format!(""{{}}"", $0)"
    let v515 : std_string_String = Fable.Core.RustInterop.emitRustExpr v507 v514
    v515
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v516 : std_string_String = null |> unbox<std_string_String>
    v516
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v517 : std_string_String = null |> unbox<std_string_String>
    v517
#endif
    
#if FABLE_COMPILER_PYTHON
    let v518 : std_string_String = null |> unbox<std_string_String>
    v518
#endif
    |> fun x -> _v508 <- Some x
    let v519 : std_string_String = _v508.Value
    let v520 : string = "fable_library_rust::String_::fromString($0)"
    let v521 : string = Fable.Core.RustInterop.emitRustExpr v519 v520
    v521
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v522 : string = null |> unbox<string>
    v522
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v523 : string = null |> unbox<string>
    v523
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v524 : string = System.IO.Path.Combine (v348, v489)
    v524
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v525 : IPathJoin = Fable.Core.JsInterop.importAll v75
    let v526 : string = method15(v348)
    let v527 : string = method16(v489)
    let v528 : string = "v525.join(v526, v527)"
    let v529 : string = Fable.Core.JsInterop.emitJsExpr () v528
    v529
#endif
    
#if FABLE_COMPILER_PYTHON
    let v530 : string = null |> unbox<string>
    v530
#endif
    |> fun x -> _v490 <- Some x
    let v531 : string = _v490.Value
    v531
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v532 : string = null |> unbox<string>
    v532
#endif
    
#if FABLE_COMPILER_PYTHON
    let v533 : string = null |> unbox<string>
    v533
#endif
    |> fun x -> _v0 <- Some x
    let v534 : string = _v0.Value
    let v535 : System.IDisposable option = None
    let v536 : bool = true in let mutable _v535 = v535
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v537 : string = method22(v534)
    let v538 : string = "std::fs::create_dir_all(&*$0)"
    let v539 : Result<unit, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v537 v538
    let v540 : (std_io_Error -> std_string_String) = method23()
    let v541 : string = "$0.map_err(|x| $1(x))"
    let v542 : Result<unit, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v539, v540) v541
    let v543 : (unit -> US10) = closure40()
    let v544 : (std_string_String -> US10) = closure41()
    let v545 : US10 = match v542 with Ok () -> v543 () | Error x -> v544 x
    match v545 with
    | US10_1(v549) -> (* Error *)
        let v550 : US0 = US0_4
        let v551 : (unit -> string) = closure42()
        let v552 : (unit -> string) = closure43(v537, v549)
        method5(v550, v551, v552)
    | US10_0 -> (* Ok *)
        let v546 : US0 = US0_0
        let v547 : (unit -> string) = closure44()
        let v548 : (unit -> string) = closure45(v537)
        method5(v546, v547, v548)
    let v553 : System.IDisposable option = None
    let v554 : bool = true in let mutable _v553 = v553
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v555 : (unit -> unit) = closure46(v537)
    let v556 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v555 "$0()" )
    v556
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v557 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v555 "$0()" )
    v557
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v558 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v555 "$0()" )
    v558
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v559 : (unit -> unit) = method24(v537)
    let v560 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v559 () }
    v560
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v561 : System.IDisposable = null |> unbox<System.IDisposable>
    v561
#endif
    
#if FABLE_COMPILER_PYTHON
    let v562 : System.IDisposable = null |> unbox<System.IDisposable>
    v562
#endif
    |> fun x -> _v553 <- Some x
    let v563 : System.IDisposable = _v553.Value
    v563
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v564 : System.IDisposable = null |> unbox<System.IDisposable>
    v564
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v565 : System.IDisposable = null |> unbox<System.IDisposable>
    v565
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v566 : System.IO.DirectoryInfo option = None
    let v567 : bool = true in let mutable _v566 = v566
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v568 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    v568
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v569 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    v569
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v570 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    v570
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v571 : (string -> System.IO.DirectoryInfo) = System.IO.Directory.CreateDirectory
    let v572 : System.IO.DirectoryInfo = v571 v534
    v572
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v573 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    v573
#endif
    
#if FABLE_COMPILER_PYTHON
    let v574 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    v574
#endif
    |> fun x -> _v566 <- Some x
    let v575 : System.IO.DirectoryInfo = _v566.Value
    let v576 : bool option = None
    let v577 : bool = true in let mutable _v576 = v576
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v578 : bool = null |> unbox<bool>
    v578
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v579 : bool = null |> unbox<bool>
    v579
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v580 : bool = null |> unbox<bool>
    v580
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v581 : bool = v575.Exists
    v581
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v582 : bool = null |> unbox<bool>
    v582
#endif
    
#if FABLE_COMPILER_PYTHON
    let v583 : bool = null |> unbox<bool>
    v583
#endif
    |> fun x -> _v576 <- Some x
    let v584 : bool = _v576.Value
    let v585 : bool = v584 = false
    if v585 then
        let v586 : System.DateTime option = None
        let v587 : bool = true in let mutable _v586 = v586
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v588 : System.DateTime = null |> unbox<System.DateTime>
        v588
#endif
        
#if FABLE_COMPILER_RUST && WASM
        let v589 : System.DateTime = null |> unbox<System.DateTime>
        v589
#endif
        
#if FABLE_COMPILER_RUST && CONTRACT
        let v590 : System.DateTime = null |> unbox<System.DateTime>
        v590
#endif
        
#if !FABLE_COMPILER && !WASM && !CONTRACT
        let v591 : System.DateTime = v575.CreationTime
        v591
#endif
        
#if FABLE_COMPILER_TYPESCRIPT
        let v592 : System.DateTime = null |> unbox<System.DateTime>
        v592
#endif
        
#if FABLE_COMPILER_PYTHON
        let v593 : System.DateTime = null |> unbox<System.DateTime>
        v593
#endif
        |> fun x -> _v586 <- Some x
        let v594 : System.DateTime = _v586.Value
        let v595 : obj = {| Exists = v584; CreationTime = v594 |}
        let v596 : string = $"%A{v595}"
        let v597 : US0 = US0_1
        let v598 : (unit -> string) = closure47()
        let v599 : (unit -> string) = closure48(v534, v596)
        method5(v597, v598, v599)
    let v600 : System.IDisposable option = None
    let v601 : bool = true in let mutable _v600 = v600
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v602 : (unit -> unit) = closure49(v534)
    let v603 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v602 "$0()" )
    v603
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v604 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v602 "$0()" )
    v604
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v605 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v602 "$0()" )
    v605
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v606 : (unit -> unit) = method25(v534)
    let v607 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v606 () }
    v607
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v608 : System.IDisposable = null |> unbox<System.IDisposable>
    v608
#endif
    
#if FABLE_COMPILER_PYTHON
    let v609 : System.IDisposable = null |> unbox<System.IDisposable>
    v609
#endif
    |> fun x -> _v600 <- Some x
    let v610 : System.IDisposable = _v600.Value
    v610
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v611 : System.IDisposable = null |> unbox<System.IDisposable>
    v611
#endif
    
#if FABLE_COMPILER_PYTHON
    let v612 : System.IDisposable = null |> unbox<System.IDisposable>
    v612
#endif
    |> fun x -> _v535 <- Some x
    let v613 : System.IDisposable = _v535.Value
    struct (v534, v613)
and closure50 () () : string =
    let v0 : string = __SOURCE_DIRECTORY__
    v0
and closure54 () (v0 : string) : bool =
    let v1 : bool option = None
    let v2 : bool = true in let mutable _v1 = v1
    
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
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
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
    
#if FABLE_COMPILER_PYTHON
    let v23 : bool = null |> unbox<bool>
    v23
#endif
    |> fun x -> _v1 <- Some x
    let v24 : bool = _v1.Value
    v24
and closure55 () (v0 : string) : bool =
    let v1 : bool option = None
    let v2 : bool = true in let mutable _v1 = v1
    
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
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
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
    
#if FABLE_COMPILER_PYTHON
    let v23 : bool = null |> unbox<bool>
    v23
#endif
    |> fun x -> _v1 <- Some x
    let v24 : bool = _v1.Value
    v24
and closure56 () (v0 : string) : string option =
    let v1 : US9 option = None
    let v2 : bool = true in let mutable _v1 = v1
    
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
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v24 : std_string_String = null |> unbox<std_string_String>
    v24
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v25 : std_string_String = null |> unbox<std_string_String>
    v25
#endif
    
#if FABLE_COMPILER_PYTHON
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
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v33 : (string -> System.IO.DirectoryInfo) = System.IO.Directory.GetParent
    let v34 : System.IO.DirectoryInfo = v33 v0
    let v35 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    let v36 : bool = v34 = v35
    let v48 : US9 =
        if v36 then
            US9_1
        else
            let v38 : string option = None
            let v39 : bool = true in let mutable _v38 = v38
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v40 : string = null |> unbox<string>
            v40
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v41 : string = null |> unbox<string>
            v41
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v42 : string = null |> unbox<string>
            v42
#endif
            
#if !FABLE_COMPILER && !WASM && !CONTRACT
            let v43 : string = v34.FullName
            v43
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v44 : string = null |> unbox<string>
            v44
#endif
            
#if FABLE_COMPILER_PYTHON
            let v45 : string = null |> unbox<string>
            v45
#endif
            |> fun x -> _v38 <- Some x
            let v46 : string = _v38.Value
            US9_0(v46)
    v48
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v49 : string = "path"
    let v50 : IPathDirname = Fable.Core.JsInterop.importAll v49
    let v51 : string = "v50.dirname($0)"
    let v52 : string = Fable.Core.JsInterop.emitJsExpr v0 v51
    let v53 : US9 = US9_0(v52)
    v53
#endif
    
#if FABLE_COMPILER_PYTHON
    let v54 : US9 = null |> unbox<US9>
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
and method27 () : (string -> string option) =
    closure56()
and closure57 () (v0 : string) : US9 =
    US9_0(v0)
and method28 () : (string -> US9) =
    closure57()
and method29 (v0 : string, v1 : bool, v2 : string, v3 : string) : string =
    let v4 : string option = None
    let v5 : bool = true in let mutable _v4 = v4
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v6 : string = method4(v3)
    let v7 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v8 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v7
    let v9 : string = "String::from($0)"
    let v10 : std_string_String = Fable.Core.RustInterop.emitRustExpr v8 v9
    let v11 : string = "std::path::PathBuf::from($0)"
    let v12 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v10 v11
    let v13 : string = method4(v0)
    let v14 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v15 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v13 v14
    let v16 : string = "String::from($0)"
    let v17 : std_string_String = Fable.Core.RustInterop.emitRustExpr v15 v16
    let v18 : string = "$0.join($1)"
    let v19 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr struct (v12, v17) v18
    let v20 : string = "$0.display()"
    let v21 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v19 v20
    let v22 : std_string_String option = None
    let v23 : bool = true in let mutable _v22 = v22
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v24 : string = @$"format!(""{{}}"", $0)"
    let v25 : std_string_String = Fable.Core.RustInterop.emitRustExpr v21 v24
    v25
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v26 : string = @$"format!(""{{}}"", $0)"
    let v27 : std_string_String = Fable.Core.RustInterop.emitRustExpr v21 v26
    v27
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v28 : string = @$"format!(""{{}}"", $0)"
    let v29 : std_string_String = Fable.Core.RustInterop.emitRustExpr v21 v28
    v29
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v30 : std_string_String = null |> unbox<std_string_String>
    v30
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v31 : std_string_String = null |> unbox<std_string_String>
    v31
#endif
    
#if FABLE_COMPILER_PYTHON
    let v32 : std_string_String = null |> unbox<std_string_String>
    v32
#endif
    |> fun x -> _v22 <- Some x
    let v33 : std_string_String = _v22.Value
    let v34 : string = "fable_library_rust::String_::fromString($0)"
    let v35 : string = Fable.Core.RustInterop.emitRustExpr v33 v34
    v35
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v36 : string = null |> unbox<string>
    v36
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v37 : string = null |> unbox<string>
    v37
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v38 : string = System.IO.Path.Combine (v3, v0)
    v38
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v39 : string = "path"
    let v40 : IPathJoin = Fable.Core.JsInterop.importAll v39
    let v41 : string = method15(v3)
    let v42 : string = method16(v0)
    let v43 : string = "v40.join(v41, v42)"
    let v44 : string = Fable.Core.JsInterop.emitJsExpr () v43
    v44
#endif
    
#if FABLE_COMPILER_PYTHON
    let v45 : string = null |> unbox<string>
    v45
#endif
    |> fun x -> _v4 <- Some x
    let v46 : string = _v4.Value
    let v49 : (string -> bool) =
        if v1 then
            closure54()
        else
            closure55()
    let v50 : bool = v49 v46
    if v50 then
        v3
    else
        let v51 : (string -> string option) = method27()
        let v52 : string option = v51 v3
        let v53 : (string -> US9) = method28()
        let v54 : US9 = US9_1
        let v55 : US9 = v52 |> Option.map v53 |> Option.defaultValue v54 
        match v55 with
        | US9_1 -> (* None *)
            let v58 : string = $"""No parent for {if v1 then "file" else "dir"} '{v0}' at '{v2}' (until '{v3}')"""
            failwith<string> v58
        | US9_0(v56) -> (* Some *)
            method29(v0, v1, v2, v56)
and method26 (v0 : string, v1 : bool, v2 : string) : string =
    let v3 : string option = None
    let v4 : bool = true in let mutable _v3 = v3
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v5 : string = method4(v2)
    let v6 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v7 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v6
    let v8 : string = "String::from($0)"
    let v9 : std_string_String = Fable.Core.RustInterop.emitRustExpr v7 v8
    let v10 : string = "std::path::PathBuf::from($0)"
    let v11 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v9 v10
    let v12 : string = method4(v0)
    let v13 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v14 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v12 v13
    let v15 : string = "String::from($0)"
    let v16 : std_string_String = Fable.Core.RustInterop.emitRustExpr v14 v15
    let v17 : string = "$0.join($1)"
    let v18 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr struct (v11, v16) v17
    let v19 : string = "$0.display()"
    let v20 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v18 v19
    let v21 : std_string_String option = None
    let v22 : bool = true in let mutable _v21 = v21
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v23 : string = @$"format!(""{{}}"", $0)"
    let v24 : std_string_String = Fable.Core.RustInterop.emitRustExpr v20 v23
    v24
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v25 : string = @$"format!(""{{}}"", $0)"
    let v26 : std_string_String = Fable.Core.RustInterop.emitRustExpr v20 v25
    v26
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v27 : string = @$"format!(""{{}}"", $0)"
    let v28 : std_string_String = Fable.Core.RustInterop.emitRustExpr v20 v27
    v28
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v29 : std_string_String = null |> unbox<std_string_String>
    v29
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v30 : std_string_String = null |> unbox<std_string_String>
    v30
#endif
    
#if FABLE_COMPILER_PYTHON
    let v31 : std_string_String = null |> unbox<std_string_String>
    v31
#endif
    |> fun x -> _v21 <- Some x
    let v32 : std_string_String = _v21.Value
    let v33 : string = "fable_library_rust::String_::fromString($0)"
    let v34 : string = Fable.Core.RustInterop.emitRustExpr v32 v33
    v34
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v35 : string = null |> unbox<string>
    v35
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v36 : string = null |> unbox<string>
    v36
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v37 : string = System.IO.Path.Combine (v2, v0)
    v37
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v38 : string = "path"
    let v39 : IPathJoin = Fable.Core.JsInterop.importAll v38
    let v40 : string = method15(v2)
    let v41 : string = method16(v0)
    let v42 : string = "v39.join(v40, v41)"
    let v43 : string = Fable.Core.JsInterop.emitJsExpr () v42
    v43
#endif
    
#if FABLE_COMPILER_PYTHON
    let v44 : string = null |> unbox<string>
    v44
#endif
    |> fun x -> _v3 <- Some x
    let v45 : string = _v3.Value
    let v48 : (string -> bool) =
        if v1 then
            closure54()
        else
            closure55()
    let v49 : bool = v48 v45
    if v49 then
        v2
    else
        let v50 : (string -> string option) = method27()
        let v51 : string option = v50 v2
        let v52 : (string -> US9) = method28()
        let v53 : US9 = US9_1
        let v54 : US9 = v51 |> Option.map v52 |> Option.defaultValue v53 
        match v54 with
        | US9_1 -> (* None *)
            let v57 : string = $"""No parent for {if v1 then "file" else "dir"} '{v0}' at '{v2}' (until '{v2}')"""
            failwith<string> v57
        | US9_0(v55) -> (* Some *)
            method29(v0, v1, v2, v55)
and closure53 (v0 : string, v1 : bool) (v2 : string) : string =
    method26(v0, v1, v2)
and closure52 (v0 : string) (v1 : bool) : (string -> string) =
    closure53(v0, v1)
and closure51 () (v0 : string) : (bool -> (string -> string)) =
    closure52(v0)
and method30 () : string =
    let v0 : string = "^\\\\\\\\\\?\\\\"
    v0
and method31 (v0 : string) : string =
    v0
and method32 () : string =
    let v0 : string = ""
    v0
and closure58 () (v0 : string) : string =
    let v1 : bool option = None
    let v2 : bool = true in let mutable _v1 = v1
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : string = "cfg!(windows)"
    let v4 : bool = Fable.Core.RustInterop.emitRustExpr () v3
    v4
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v5 : bool = null |> unbox<bool>
    v5
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v6 : bool = null |> unbox<bool>
    v6
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v7 : System.Runtime.InteropServices.OSPlatform = System.Runtime.InteropServices.OSPlatform.Windows
    let v8 : (System.Runtime.InteropServices.OSPlatform -> bool) = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform
    let v9 : bool = v8 v7
    v9
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v10 : bool = null |> unbox<bool>
    v10
#endif
    
#if FABLE_COMPILER_PYTHON
    let v11 : bool = null |> unbox<bool>
    v11
#endif
    |> fun x -> _v1 <- Some x
    let v12 : bool = _v1.Value
    let v13 : bool = v12 = false
    if v13 then
        v0
    else
        let v14 : string option = None
        let v15 : bool = true in let mutable _v14 = v14
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v16 : string = method30()
        let v17 : string = method31(v0)
        let v18 : string = method32()
        let v19 : string = $"&regex::Regex::new(&$0).unwrap().replace_all(&$1, &*$2)"
        let v20 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr struct (v16, v17, v18) v19
        let v21 : string = "String::from($0)"
        let v22 : std_string_String = Fable.Core.RustInterop.emitRustExpr v20 v21
        let v23 : string = "fable_library_rust::String_::fromString($0)"
        let v24 : string = Fable.Core.RustInterop.emitRustExpr v22 v23
        v24
#endif
        
#if FABLE_COMPILER_RUST && WASM
        let v25 : string = null |> unbox<string>
        v25
#endif
        
#if FABLE_COMPILER_RUST && CONTRACT
        let v26 : string = null |> unbox<string>
        v26
#endif
        
#if !FABLE_COMPILER && !WASM && !CONTRACT
        let v27 : string = "^\\\\\\\\\\?\\\\"
        let v28 : string = ""
        let v29 : string = System.Text.RegularExpressions.Regex.Replace (v0, v27, v28)
        v29
#endif
        
#if FABLE_COMPILER_TYPESCRIPT
        let v30 : string = null |> unbox<string>
        v30
#endif
        
#if FABLE_COMPILER_PYTHON
        let v31 : string = null |> unbox<string>
        v31
#endif
        |> fun x -> _v14 <- Some x
        let v32 : string = _v14.Value
        let v33 : string = $"{v32.[0] |> string |> _.ToLower()}{v32.[1..]}"
        let v34 : string = "\\"
        let v35 : string = "/"
        let v36 : string = v33.Replace (v34, v35)
        v36
and closure59 () (v0 : string) : string =
    let v1 : (char []) = [|'/'|]
    let v2 : string = v0.TrimStart v1
    let v3 : string = $"file:///{v2}"
    v3
and method33 () : string =
    let v0 : string = "polyglot"
    v0
and method34 () : string =
    let v0 : string = ".paket"
    v0
and method35 () : string =
    let v0 : string = "polyglot"
    v0
and method36 () : string =
    let v0 : string = ".paket"
    v0
and method38 (v0 : string, v1 : string, v2 : string) : string =
    let v3 : string option = None
    let v4 : bool = true in let mutable _v3 = v3
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v5 : string = method4(v2)
    let v6 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v7 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v6
    let v8 : string = "String::from($0)"
    let v9 : std_string_String = Fable.Core.RustInterop.emitRustExpr v7 v8
    let v10 : string = "std::path::PathBuf::from($0)"
    let v11 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v9 v10
    let v12 : string = method4(v0)
    let v13 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v14 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v12 v13
    let v15 : string = "String::from($0)"
    let v16 : std_string_String = Fable.Core.RustInterop.emitRustExpr v14 v15
    let v17 : string = "$0.join($1)"
    let v18 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr struct (v11, v16) v17
    let v19 : string = "$0.display()"
    let v20 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v18 v19
    let v21 : std_string_String option = None
    let v22 : bool = true in let mutable _v21 = v21
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v23 : string = @$"format!(""{{}}"", $0)"
    let v24 : std_string_String = Fable.Core.RustInterop.emitRustExpr v20 v23
    v24
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v25 : string = @$"format!(""{{}}"", $0)"
    let v26 : std_string_String = Fable.Core.RustInterop.emitRustExpr v20 v25
    v26
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v27 : string = @$"format!(""{{}}"", $0)"
    let v28 : std_string_String = Fable.Core.RustInterop.emitRustExpr v20 v27
    v28
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v29 : std_string_String = null |> unbox<std_string_String>
    v29
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v30 : std_string_String = null |> unbox<std_string_String>
    v30
#endif
    
#if FABLE_COMPILER_PYTHON
    let v31 : std_string_String = null |> unbox<std_string_String>
    v31
#endif
    |> fun x -> _v21 <- Some x
    let v32 : std_string_String = _v21.Value
    let v33 : string = "fable_library_rust::String_::fromString($0)"
    let v34 : string = Fable.Core.RustInterop.emitRustExpr v32 v33
    v34
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v35 : string = null |> unbox<string>
    v35
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v36 : string = null |> unbox<string>
    v36
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v37 : string = System.IO.Path.Combine (v2, v0)
    v37
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v38 : string = "path"
    let v39 : IPathJoin = Fable.Core.JsInterop.importAll v38
    let v40 : string = method15(v2)
    let v41 : string = method16(v0)
    let v42 : string = "v39.join(v40, v41)"
    let v43 : string = Fable.Core.JsInterop.emitJsExpr () v42
    v43
#endif
    
#if FABLE_COMPILER_PYTHON
    let v44 : string = null |> unbox<string>
    v44
#endif
    |> fun x -> _v3 <- Some x
    let v45 : string = _v3.Value
    let v46 : bool option = None
    let v47 : bool = true in let mutable _v46 = v46
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v48 : string = method4(v45)
    let v49 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v50 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v48 v49
    let v51 : string = "String::from($0)"
    let v52 : std_string_String = Fable.Core.RustInterop.emitRustExpr v50 v51
    let v53 : string = "std::path::PathBuf::from($0)"
    let v54 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v52 v53
    let v55 : string = "$0.exists()"
    let v56 : bool = Fable.Core.RustInterop.emitRustExpr v54 v55
    let v59 : bool =
        if v56 then
            let v57 : string = "$0.is_dir()"
            let v58 : bool = Fable.Core.RustInterop.emitRustExpr v54 v57
            v58
        else
            false
    v59
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v60 : bool = null |> unbox<bool>
    v60
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v61 : bool = null |> unbox<bool>
    v61
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v62 : (string -> bool) = System.IO.Directory.Exists
    let v63 : bool = v62 v45
    v63
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v64 : string = "fs"
    let v65 : IFsExistsSync = Fable.Core.JsInterop.importAll v64
    let v66 : string = "v65.existsSync($0)"
    let v67 : bool = Fable.Core.JsInterop.emitJsExpr v45 v66
    v67
#endif
    
#if FABLE_COMPILER_PYTHON
    let v68 : bool = null |> unbox<bool>
    v68
#endif
    |> fun x -> _v46 <- Some x
    let v69 : bool = _v46.Value
    if v69 then
        v2
    else
        let v70 : (string -> string option) = method27()
        let v71 : string option = v70 v2
        let v72 : (string -> US9) = method28()
        let v73 : US9 = US9_1
        let v74 : US9 = v71 |> Option.map v72 |> Option.defaultValue v73 
        match v74 with
        | US9_1 -> (* None *)
            let v77 : string = $"""No parent for {if false then "file" else "dir"} '{v0}' at '{v1}' (until '{v2}')"""
            failwith<string> v77
        | US9_0(v75) -> (* Some *)
            method38(v0, v1, v75)
and method37 (v0 : string, v1 : string) : string =
    let v2 : string option = None
    let v3 : bool = true in let mutable _v2 = v2
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v4 : string = method4(v1)
    let v5 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v6 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v4 v5
    let v7 : string = "String::from($0)"
    let v8 : std_string_String = Fable.Core.RustInterop.emitRustExpr v6 v7
    let v9 : string = "std::path::PathBuf::from($0)"
    let v10 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v8 v9
    let v11 : string = method4(v0)
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
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v28 : std_string_String = null |> unbox<std_string_String>
    v28
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v29 : std_string_String = null |> unbox<std_string_String>
    v29
#endif
    
#if FABLE_COMPILER_PYTHON
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
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v36 : string = System.IO.Path.Combine (v1, v0)
    v36
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v37 : string = "path"
    let v38 : IPathJoin = Fable.Core.JsInterop.importAll v37
    let v39 : string = method15(v1)
    let v40 : string = method16(v0)
    let v41 : string = "v38.join(v39, v40)"
    let v42 : string = Fable.Core.JsInterop.emitJsExpr () v41
    v42
#endif
    
#if FABLE_COMPILER_PYTHON
    let v43 : string = null |> unbox<string>
    v43
#endif
    |> fun x -> _v2 <- Some x
    let v44 : string = _v2.Value
    let v45 : bool option = None
    let v46 : bool = true in let mutable _v45 = v45
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v47 : string = method4(v44)
    let v48 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v49 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v47 v48
    let v50 : string = "String::from($0)"
    let v51 : std_string_String = Fable.Core.RustInterop.emitRustExpr v49 v50
    let v52 : string = "std::path::PathBuf::from($0)"
    let v53 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v51 v52
    let v54 : string = "$0.exists()"
    let v55 : bool = Fable.Core.RustInterop.emitRustExpr v53 v54
    let v58 : bool =
        if v55 then
            let v56 : string = "$0.is_dir()"
            let v57 : bool = Fable.Core.RustInterop.emitRustExpr v53 v56
            v57
        else
            false
    v58
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v59 : bool = null |> unbox<bool>
    v59
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v60 : bool = null |> unbox<bool>
    v60
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v61 : (string -> bool) = System.IO.Directory.Exists
    let v62 : bool = v61 v44
    v62
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v63 : string = "fs"
    let v64 : IFsExistsSync = Fable.Core.JsInterop.importAll v63
    let v65 : string = "v64.existsSync($0)"
    let v66 : bool = Fable.Core.JsInterop.emitJsExpr v44 v65
    v66
#endif
    
#if FABLE_COMPILER_PYTHON
    let v67 : bool = null |> unbox<bool>
    v67
#endif
    |> fun x -> _v45 <- Some x
    let v68 : bool = _v45.Value
    if v68 then
        v1
    else
        let v69 : (string -> string option) = method27()
        let v70 : string option = v69 v1
        let v71 : (string -> US9) = method28()
        let v72 : US9 = US9_1
        let v73 : US9 = v70 |> Option.map v71 |> Option.defaultValue v72 
        match v73 with
        | US9_1 -> (* None *)
            let v76 : string = $"""No parent for {if false then "file" else "dir"} '{v0}' at '{v1}' (until '{v1}')"""
            failwith<string> v76
        | US9_0(v74) -> (* Some *)
            method38(v0, v1, v74)
and method39 () : string =
    let v0 : string = "polyglot"
    v0
and closure60 () () : string =
    let v0 : string = __SOURCE_DIRECTORY__
    let v1 : string option = None
    let v2 : bool = true in let mutable _v1 = v1
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : string = method33()
    let v4 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v5 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v3 v4
    let v6 : string = "String::from($0)"
    let v7 : std_string_String = Fable.Core.RustInterop.emitRustExpr v5 v6
    let v8 : string = "std::path::PathBuf::from($0)"
    let v9 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v7 v8
    let v10 : string = method34()
    let v11 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v12 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v10 v11
    let v13 : string = "String::from($0)"
    let v14 : std_string_String = Fable.Core.RustInterop.emitRustExpr v12 v13
    let v15 : string = "$0.join($1)"
    let v16 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr struct (v9, v14) v15
    let v17 : string = "$0.display()"
    let v18 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v16 v17
    let v19 : std_string_String option = None
    let v20 : bool = true in let mutable _v19 = v19
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v21 : string = @$"format!(""{{}}"", $0)"
    let v22 : std_string_String = Fable.Core.RustInterop.emitRustExpr v18 v21
    v22
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v23 : string = @$"format!(""{{}}"", $0)"
    let v24 : std_string_String = Fable.Core.RustInterop.emitRustExpr v18 v23
    v24
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v25 : string = @$"format!(""{{}}"", $0)"
    let v26 : std_string_String = Fable.Core.RustInterop.emitRustExpr v18 v25
    v26
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v27 : std_string_String = null |> unbox<std_string_String>
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
    |> fun x -> _v19 <- Some x
    let v30 : std_string_String = _v19.Value
    let v31 : string = "fable_library_rust::String_::fromString($0)"
    let v32 : string = Fable.Core.RustInterop.emitRustExpr v30 v31
    v32
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v33 : string = null |> unbox<string>
    v33
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v34 : string = null |> unbox<string>
    v34
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v35 : string = "polyglot"
    let v36 : string = ".paket"
    let v37 : string = System.IO.Path.Combine (v35, v36)
    v37
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v38 : string = "path"
    let v39 : IPathJoin = Fable.Core.JsInterop.importAll v38
    let v40 : string = method35()
    let v41 : string = method36()
    let v42 : string = "v39.join(v40, v41)"
    let v43 : string = Fable.Core.JsInterop.emitJsExpr () v42
    v43
#endif
    
#if FABLE_COMPILER_PYTHON
    let v44 : string = null |> unbox<string>
    v44
#endif
    |> fun x -> _v1 <- Some x
    let v45 : string = _v1.Value
    let v46 : string = method37(v45, v0)
    let v47 : string option = None
    let v48 : bool = true in let mutable _v47 = v47
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v49 : string = method4(v46)
    let v50 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v51 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v49 v50
    let v52 : string = "String::from($0)"
    let v53 : std_string_String = Fable.Core.RustInterop.emitRustExpr v51 v52
    let v54 : string = "std::path::PathBuf::from($0)"
    let v55 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v53 v54
    let v56 : string = method33()
    let v57 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v58 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v56 v57
    let v59 : string = "String::from($0)"
    let v60 : std_string_String = Fable.Core.RustInterop.emitRustExpr v58 v59
    let v61 : string = "$0.join($1)"
    let v62 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr struct (v55, v60) v61
    let v63 : string = "$0.display()"
    let v64 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v62 v63
    let v65 : std_string_String option = None
    let v66 : bool = true in let mutable _v65 = v65
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v67 : string = @$"format!(""{{}}"", $0)"
    let v68 : std_string_String = Fable.Core.RustInterop.emitRustExpr v64 v67
    v68
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v69 : string = @$"format!(""{{}}"", $0)"
    let v70 : std_string_String = Fable.Core.RustInterop.emitRustExpr v64 v69
    v70
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v71 : string = @$"format!(""{{}}"", $0)"
    let v72 : std_string_String = Fable.Core.RustInterop.emitRustExpr v64 v71
    v72
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v73 : std_string_String = null |> unbox<std_string_String>
    v73
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v74 : std_string_String = null |> unbox<std_string_String>
    v74
#endif
    
#if FABLE_COMPILER_PYTHON
    let v75 : std_string_String = null |> unbox<std_string_String>
    v75
#endif
    |> fun x -> _v65 <- Some x
    let v76 : std_string_String = _v65.Value
    let v77 : string = "fable_library_rust::String_::fromString($0)"
    let v78 : string = Fable.Core.RustInterop.emitRustExpr v76 v77
    v78
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v79 : string = null |> unbox<string>
    v79
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v80 : string = null |> unbox<string>
    v80
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v81 : string = System.IO.Path.Combine (v46, v35)
    v81
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v82 : IPathJoin = Fable.Core.JsInterop.importAll v38
    let v83 : string = method15(v46)
    let v84 : string = method39()
    let v85 : string = "v82.join(v83, v84)"
    let v86 : string = Fable.Core.JsInterop.emitJsExpr () v85
    v86
#endif
    
#if FABLE_COMPILER_PYTHON
    let v87 : string = null |> unbox<string>
    v87
#endif
    |> fun x -> _v47 <- Some x
    let v88 : string = _v47.Value
    v88
and method41 () : string =
    let v0 : string = "target/polyglot/trace"
    v0
and method42 () : string =
    let v0 : string = "target/polyglot/trace"
    v0
and method40 (v0 : string) : unit =
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
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    try
    let v3 : string option = None
    let v4 : bool = true in let mutable _v3 = v3
    
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
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v9 : string = System.Reflection.Assembly.GetEntryAssembly().GetName().Name
    v9
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v10 : string = null |> unbox<string>
    v10
#endif
    
#if FABLE_COMPILER_PYTHON
    let v11 : string = null |> unbox<string>
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
    let v34 : (chrono_DateTime<chrono_Utc> -> US8) = method17()
    let v35 : US8 = US8_1
    let v36 : US8 = v33 |> Option.map v34 |> Option.defaultValue v35 
    let v55 : US9 =
        match v36 with
        | US8_1 -> (* None *)
            US9_1
        | US8_0(v37) -> (* Some *)
            let v38 : chrono_DateTime<chrono_Utc> = method18(v37)
            let v39 : string = "v38.naive_utc()"
            let v40 : chrono_NaiveDateTime = Fable.Core.RustInterop.emitRustExpr () v39
            let v41 : string = "chrono::offset::TimeZone::from_utc_datetime(&chrono::Local, &v40)"
            let v42 : chrono_DateTime<chrono_Local> = Fable.Core.RustInterop.emitRustExpr () v41
            let v43 : string = "%Y%m%d-%H%M-%S%f"
            let v44 : string = "r#\"" + v43 + "\"#"
            let v45 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v44
            let v46 : chrono_DateTime<chrono_Local> = method19(v42)
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
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v66 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    v66
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v67 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v67
#endif
    
#if FABLE_COMPILER_PYTHON
    let v68 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v68
#endif
    |> fun x -> _v60 <- Some x
    let v69 : System.TimeZoneInfo = _v60.Value
    let v70 : System.TimeSpan option = None
    let v71 : bool = true in let mutable _v70 = v70
    
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
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v75 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v76 : System.TimeZoneInfo option = None
    let v77 : bool = true in let mutable _v76 = v76
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v78 : string = "0i64.into()"
    let v79 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v78
    v79
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v80 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v80
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v81 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v81
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v82 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    v82
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v83 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v83
#endif
    
#if FABLE_COMPILER_PYTHON
    let v84 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v84
#endif
    |> fun x -> _v76 <- Some x
    let v85 : System.TimeZoneInfo = _v76.Value
    let v86 : (System.DateTime -> System.TimeSpan) = v75 v85
    let v87 : System.TimeSpan = v86 v25
    v87
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v88 : System.TimeSpan = System.TimeSpan () 
    v88
#endif
    
#if FABLE_COMPILER_PYTHON
    let v89 : System.TimeSpan = System.TimeSpan () 
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
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v103 : string = method20()
    let v104 : (string -> string) = v13.ToString
    let v105 : string = v104 v103
    let v106 : System.TimeZoneInfo option = None
    let v107 : bool = true in let mutable _v106 = v106
    
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
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v112 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    v112
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v113 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v113
#endif
    
#if FABLE_COMPILER_PYTHON
    let v114 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v114
#endif
    |> fun x -> _v106 <- Some x
    let v115 : System.TimeZoneInfo = _v106.Value
    let v116 : System.TimeSpan option = None
    let v117 : bool = true in let mutable _v116 = v116
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v118 : System.TimeSpan = System.TimeSpan () 
    v118
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v119 : System.TimeSpan = System.TimeSpan () 
    v119
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v120 : System.TimeSpan = System.TimeSpan () 
    v120
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v121 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v122 : System.TimeZoneInfo option = None
    let v123 : bool = true in let mutable _v122 = v122
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v124 : string = "0i64.into()"
    let v125 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v124
    v125
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v126 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v126
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v127 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v127
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v128 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    v128
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v129 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v129
#endif
    
#if FABLE_COMPILER_PYTHON
    let v130 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v130
#endif
    |> fun x -> _v122 <- Some x
    let v131 : System.TimeZoneInfo = _v122.Value
    let v132 : (System.DateTime -> System.TimeSpan) = v121 v131
    let v133 : System.TimeSpan = v132 v13
    v133
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v134 : System.TimeSpan = System.TimeSpan () 
    v134
#endif
    
#if FABLE_COMPILER_PYTHON
    let v135 : System.TimeSpan = System.TimeSpan () 
    v135
#endif
    |> fun x -> _v116 <- Some x
    let v136 : System.TimeSpan = _v116.Value
    let v137 : (System.TimeSpan -> int32) = _.Hours
    let v138 : int32 = v137 v136
    let v139 : bool = v138 > 0
    let v140 : (bool -> int32) = System.Convert.ToInt32
    let v141 : int32 = v140 v139
    let v142 : string = method21()
    let v143 : (string -> string) = v136.ToString
    let v144 : string = v143 v142
    let v145 : string = $"{v141}{v144}"
    struct (v105, v145)
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let struct (v146 : string, v147 : string) = null |> unbox<struct (string * string)>
    struct (v146, v147)
#endif
    
#if FABLE_COMPILER_PYTHON
    let struct (v148 : string, v149 : string) = null |> unbox<struct (string * string)>
    struct (v148, v149)
#endif
    |> fun x -> _v17 <- Some x
    let struct (v150 : string, v151 : string) = _v17.Value
    let v152 : System.Guid = System.Guid $"{v150}{v151}{v16.[v150.Length + v151.Length..]}"
    let v153 : string = $"{v12}_{v152}.txt"
    let v154 : string = __SOURCE_DIRECTORY__
    let v155 : string option = None
    let v156 : bool = true in let mutable _v155 = v155
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v157 : string = method33()
    let v158 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v159 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v157 v158
    let v160 : string = "String::from($0)"
    let v161 : std_string_String = Fable.Core.RustInterop.emitRustExpr v159 v160
    let v162 : string = "std::path::PathBuf::from($0)"
    let v163 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v161 v162
    let v164 : string = method34()
    let v165 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v166 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v164 v165
    let v167 : string = "String::from($0)"
    let v168 : std_string_String = Fable.Core.RustInterop.emitRustExpr v166 v167
    let v169 : string = "$0.join($1)"
    let v170 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr struct (v163, v168) v169
    let v171 : string = "$0.display()"
    let v172 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v170 v171
    let v173 : std_string_String option = None
    let v174 : bool = true in let mutable _v173 = v173
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v175 : string = @$"format!(""{{}}"", $0)"
    let v176 : std_string_String = Fable.Core.RustInterop.emitRustExpr v172 v175
    v176
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v177 : string = @$"format!(""{{}}"", $0)"
    let v178 : std_string_String = Fable.Core.RustInterop.emitRustExpr v172 v177
    v178
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v179 : string = @$"format!(""{{}}"", $0)"
    let v180 : std_string_String = Fable.Core.RustInterop.emitRustExpr v172 v179
    v180
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v181 : std_string_String = null |> unbox<std_string_String>
    v181
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v182 : std_string_String = null |> unbox<std_string_String>
    v182
#endif
    
#if FABLE_COMPILER_PYTHON
    let v183 : std_string_String = null |> unbox<std_string_String>
    v183
#endif
    |> fun x -> _v173 <- Some x
    let v184 : std_string_String = _v173.Value
    let v185 : string = "fable_library_rust::String_::fromString($0)"
    let v186 : string = Fable.Core.RustInterop.emitRustExpr v184 v185
    v186
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v187 : string = null |> unbox<string>
    v187
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v188 : string = null |> unbox<string>
    v188
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v189 : string = "polyglot"
    let v190 : string = ".paket"
    let v191 : string = System.IO.Path.Combine (v189, v190)
    v191
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v192 : string = "path"
    let v193 : IPathJoin = Fable.Core.JsInterop.importAll v192
    let v194 : string = method35()
    let v195 : string = method36()
    let v196 : string = "v193.join(v194, v195)"
    let v197 : string = Fable.Core.JsInterop.emitJsExpr () v196
    v197
#endif
    
#if FABLE_COMPILER_PYTHON
    let v198 : string = null |> unbox<string>
    v198
#endif
    |> fun x -> _v155 <- Some x
    let v199 : string = _v155.Value
    let v200 : string = method37(v199, v154)
    let v201 : string option = None
    let v202 : bool = true in let mutable _v201 = v201
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v203 : string = method4(v200)
    let v204 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v205 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v203 v204
    let v206 : string = "String::from($0)"
    let v207 : std_string_String = Fable.Core.RustInterop.emitRustExpr v205 v206
    let v208 : string = "std::path::PathBuf::from($0)"
    let v209 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v207 v208
    let v210 : string = method33()
    let v211 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v212 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v210 v211
    let v213 : string = "String::from($0)"
    let v214 : std_string_String = Fable.Core.RustInterop.emitRustExpr v212 v213
    let v215 : string = "$0.join($1)"
    let v216 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr struct (v209, v214) v215
    let v217 : string = "$0.display()"
    let v218 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v216 v217
    let v219 : std_string_String option = None
    let v220 : bool = true in let mutable _v219 = v219
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v221 : string = @$"format!(""{{}}"", $0)"
    let v222 : std_string_String = Fable.Core.RustInterop.emitRustExpr v218 v221
    v222
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v223 : string = @$"format!(""{{}}"", $0)"
    let v224 : std_string_String = Fable.Core.RustInterop.emitRustExpr v218 v223
    v224
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v225 : string = @$"format!(""{{}}"", $0)"
    let v226 : std_string_String = Fable.Core.RustInterop.emitRustExpr v218 v225
    v226
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v227 : std_string_String = null |> unbox<std_string_String>
    v227
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v228 : std_string_String = null |> unbox<std_string_String>
    v228
#endif
    
#if FABLE_COMPILER_PYTHON
    let v229 : std_string_String = null |> unbox<std_string_String>
    v229
#endif
    |> fun x -> _v219 <- Some x
    let v230 : std_string_String = _v219.Value
    let v231 : string = "fable_library_rust::String_::fromString($0)"
    let v232 : string = Fable.Core.RustInterop.emitRustExpr v230 v231
    v232
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v233 : string = null |> unbox<string>
    v233
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v234 : string = null |> unbox<string>
    v234
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v235 : string = System.IO.Path.Combine (v200, v189)
    v235
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v236 : IPathJoin = Fable.Core.JsInterop.importAll v192
    let v237 : string = method15(v200)
    let v238 : string = method39()
    let v239 : string = "v236.join(v237, v238)"
    let v240 : string = Fable.Core.JsInterop.emitJsExpr () v239
    v240
#endif
    
#if FABLE_COMPILER_PYTHON
    let v241 : string = null |> unbox<string>
    v241
#endif
    |> fun x -> _v201 <- Some x
    let v242 : string = _v201.Value
    let v243 : string option = None
    let v244 : bool = true in let mutable _v243 = v243
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v245 : string = method4(v242)
    let v246 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v247 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v245 v246
    let v248 : string = "String::from($0)"
    let v249 : std_string_String = Fable.Core.RustInterop.emitRustExpr v247 v248
    let v250 : string = "std::path::PathBuf::from($0)"
    let v251 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v249 v250
    let v252 : string = method41()
    let v253 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v254 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v252 v253
    let v255 : string = "String::from($0)"
    let v256 : std_string_String = Fable.Core.RustInterop.emitRustExpr v254 v255
    let v257 : string = "$0.join($1)"
    let v258 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr struct (v251, v256) v257
    let v259 : string = "$0.display()"
    let v260 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v258 v259
    let v261 : std_string_String option = None
    let v262 : bool = true in let mutable _v261 = v261
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v263 : string = @$"format!(""{{}}"", $0)"
    let v264 : std_string_String = Fable.Core.RustInterop.emitRustExpr v260 v263
    v264
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v265 : string = @$"format!(""{{}}"", $0)"
    let v266 : std_string_String = Fable.Core.RustInterop.emitRustExpr v260 v265
    v266
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v267 : string = @$"format!(""{{}}"", $0)"
    let v268 : std_string_String = Fable.Core.RustInterop.emitRustExpr v260 v267
    v268
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v269 : std_string_String = null |> unbox<std_string_String>
    v269
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v270 : std_string_String = null |> unbox<std_string_String>
    v270
#endif
    
#if FABLE_COMPILER_PYTHON
    let v271 : std_string_String = null |> unbox<std_string_String>
    v271
#endif
    |> fun x -> _v261 <- Some x
    let v272 : std_string_String = _v261.Value
    let v273 : string = "fable_library_rust::String_::fromString($0)"
    let v274 : string = Fable.Core.RustInterop.emitRustExpr v272 v273
    v274
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v275 : string = null |> unbox<string>
    v275
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v276 : string = null |> unbox<string>
    v276
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v277 : string = "target/polyglot/trace"
    let v278 : string = System.IO.Path.Combine (v242, v277)
    v278
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v279 : IPathJoin = Fable.Core.JsInterop.importAll v192
    let v280 : string = method15(v242)
    let v281 : string = method42()
    let v282 : string = "v279.join(v280, v281)"
    let v283 : string = Fable.Core.JsInterop.emitJsExpr () v282
    v283
#endif
    
#if FABLE_COMPILER_PYTHON
    let v284 : string = null |> unbox<string>
    v284
#endif
    |> fun x -> _v243 <- Some x
    let v285 : string = _v243.Value
    let v286 : System.IO.DirectoryInfo option = None
    let v287 : bool = true in let mutable _v286 = v286
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v288 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    v288
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v289 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    v289
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v290 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    v290
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v291 : (string -> System.IO.DirectoryInfo) = System.IO.Directory.CreateDirectory
    let v292 : System.IO.DirectoryInfo = v291 v285
    v292
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v293 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    v293
#endif
    
#if FABLE_COMPILER_PYTHON
    let v294 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    v294
#endif
    |> fun x -> _v286 <- Some x
    let v295 : System.IO.DirectoryInfo = _v286.Value
    let v296 : string option = None
    let v297 : bool = true in let mutable _v296 = v296
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v298 : string = method4(v285)
    let v299 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v300 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v298 v299
    let v301 : string = "String::from($0)"
    let v302 : std_string_String = Fable.Core.RustInterop.emitRustExpr v300 v301
    let v303 : string = "std::path::PathBuf::from($0)"
    let v304 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v302 v303
    let v305 : string = method4(v153)
    let v306 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v307 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v305 v306
    let v308 : string = "String::from($0)"
    let v309 : std_string_String = Fable.Core.RustInterop.emitRustExpr v307 v308
    let v310 : string = "$0.join($1)"
    let v311 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr struct (v304, v309) v310
    let v312 : string = "$0.display()"
    let v313 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v311 v312
    let v314 : std_string_String option = None
    let v315 : bool = true in let mutable _v314 = v314
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v316 : string = @$"format!(""{{}}"", $0)"
    let v317 : std_string_String = Fable.Core.RustInterop.emitRustExpr v313 v316
    v317
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v318 : string = @$"format!(""{{}}"", $0)"
    let v319 : std_string_String = Fable.Core.RustInterop.emitRustExpr v313 v318
    v319
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v320 : string = @$"format!(""{{}}"", $0)"
    let v321 : std_string_String = Fable.Core.RustInterop.emitRustExpr v313 v320
    v321
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v322 : std_string_String = null |> unbox<std_string_String>
    v322
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v323 : std_string_String = null |> unbox<std_string_String>
    v323
#endif
    
#if FABLE_COMPILER_PYTHON
    let v324 : std_string_String = null |> unbox<std_string_String>
    v324
#endif
    |> fun x -> _v314 <- Some x
    let v325 : std_string_String = _v314.Value
    let v326 : string = "fable_library_rust::String_::fromString($0)"
    let v327 : string = Fable.Core.RustInterop.emitRustExpr v325 v326
    v327
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v328 : string = null |> unbox<string>
    v328
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v329 : string = null |> unbox<string>
    v329
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v330 : string = System.IO.Path.Combine (v285, v153)
    v330
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v331 : IPathJoin = Fable.Core.JsInterop.importAll v192
    let v332 : string = method15(v285)
    let v333 : string = method16(v153)
    let v334 : string = "v331.join(v332, v333)"
    let v335 : string = Fable.Core.JsInterop.emitJsExpr () v334
    v335
#endif
    
#if FABLE_COMPILER_PYTHON
    let v336 : string = null |> unbox<string>
    v336
#endif
    |> fun x -> _v296 <- Some x
    let v337 : string = _v296.Value
    let v338 : Async<unit> option = None
    let v339 : bool = true in let mutable _v338 = v338
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v340 : Async<unit> = null |> unbox<Async<unit>>
    v340
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v341 : Async<unit> = null |> unbox<Async<unit>>
    v341
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v342 : Async<unit> = null |> unbox<Async<unit>>
    v342
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v343 : System.Threading.Tasks.Task = System.IO.File.WriteAllTextAsync (v337, v0)
    let v344 : Async<unit> option = None
    let v345 : bool = true in let mutable _v344 = v344
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v346 : Async<unit> = null |> unbox<Async<unit>>
    v346
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v347 : Async<unit> = null |> unbox<Async<unit>>
    v347
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v348 : Async<unit> = null |> unbox<Async<unit>>
    v348
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v349 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
    let v350 : Async<unit> = v349 v343
    v350
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v351 : Async<unit> = null |> unbox<Async<unit>>
    v351
#endif
    
#if FABLE_COMPILER_PYTHON
    let v352 : Async<unit> = null |> unbox<Async<unit>>
    v352
#endif
    |> fun x -> _v344 <- Some x
    let v353 : Async<unit> = _v344.Value
    v353
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v354 : Async<unit> = null |> unbox<Async<unit>>
    v354
#endif
    
#if FABLE_COMPILER_PYTHON
    let v355 : Async<unit> = null |> unbox<Async<unit>>
    v355
#endif
    |> fun x -> _v338 <- Some x
    let v356 : Async<unit> = _v338.Value
    let v357 : unit option = None
    let v358 : bool = true in let mutable _v357 = v357
    
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
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v359 : (Async<unit> -> unit) = Async.RunSynchronously
    v359 v356
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
    |> fun x -> _v357 <- Some x
    _v357.Value
    with ex ->
    let v360 : exn = ex
    let v361 : string = $"file_system.trace_file / ex: %A{v360}"
    method40(v361)
    (*
    *)
    ()
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    ()
#endif
    
#if FABLE_COMPILER_PYTHON
    ()
#endif
    |> fun x -> _v1 <- Some x
    _v1.Value
    ()
and closure62 () (v0 : string) : unit =
    method40(v0)
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
    let v2 : string option = None
    let v3 : bool = true in let mutable _v2 = v2
    
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
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v28 : std_string_String = null |> unbox<std_string_String>
    v28
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v29 : std_string_String = null |> unbox<std_string_String>
    v29
#endif
    
#if FABLE_COMPILER_PYTHON
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
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v36 : string = System.IO.Path.Combine (v0, v1)
    v36
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v37 : string = "path"
    let v38 : IPathJoin = Fable.Core.JsInterop.importAll v37
    let v39 : string = method15(v0)
    let v40 : string = method16(v1)
    let v41 : string = "v38.join(v39, v40)"
    let v42 : string = Fable.Core.JsInterop.emitJsExpr () v41
    v42
#endif
    
#if FABLE_COMPILER_PYTHON
    let v43 : string = null |> unbox<string>
    v43
#endif
    |> fun x -> _v2 <- Some x
    let v44 : string = _v2.Value
    v44
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
