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
[<Fable.Core.Erase; Fable.Core.Emit("std::sync::PoisonError<$0>")>]
#endif
type std_sync_PoisonError<'T> = class end
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
[<Fable.Core.Erase; Fable.Core.Emit("std::process::ChildStdin")>]
#endif
type std_process_ChildStdin = class end
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
    
#if FABLE_COMPILER_TYPESCRIPT
    let v6 : string = null |> unbox<string>
    v6
#endif
    
#if FABLE_COMPILER_PYTHON
    let v7 : string = null |> unbox<string>
    v7
#endif
    
#else
    let v8 : (string -> string) = System.IO.Path.GetFileName
    let v9 : string = v8 v0
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
    let v31 : string = "v30.existsSync($0)"
    let v32 : bool = Fable.Core.JsInterop.emitJsExpr v12 v31
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
    let v35 : string = "v34.existsSync($0)"
    let v36 : bool = Fable.Core.JsInterop.emitJsExpr v0 v35
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
    let v43 : string = "v42.existsSync($0)"
    let v44 : bool = Fable.Core.JsInterop.emitJsExpr v0 v43
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
    let v40 : string option = None
    let v41 : bool = true in let mutable _v40 = v40
    
#if FABLE_COMPILER || WASM || CONTRACT
    
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
    
#if FABLE_COMPILER || WASM || CONTRACT
    
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
    
#if FABLE_COMPILER_TYPESCRIPT
    let v66 : std_string_String = null |> unbox<std_string_String>
    v66
#endif
    
#if FABLE_COMPILER_PYTHON
    let v67 : std_string_String = null |> unbox<std_string_String>
    v67
#endif
    
#else
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
    
#if FABLE_COMPILER_TYPESCRIPT
    let v74 : string = "path"
    let v75 : IPathJoin = Fable.Core.JsInterop.importAll v74
    let v76 : string = method15(v38)
    let v77 : string = method16(v39)
    let v78 : string = "v75.join(v76, v77)"
    let v79 : string = Fable.Core.JsInterop.emitJsExpr () v78
    v79
#endif
    
#if FABLE_COMPILER_PYTHON
    let v80 : string = null |> unbox<string>
    v80
#endif
    
#else
    let v81 : string = System.IO.Path.Combine (v38, v39)
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
    
#if FABLE_COMPILER || WASM || CONTRACT
    
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
    
#if FABLE_COMPILER || WASM || CONTRACT
    
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
    
#if FABLE_COMPILER_TYPESCRIPT
    let v136 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v136
#endif
    
#if FABLE_COMPILER_PYTHON
    let v137 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v137
#endif
    
#else
    let v138 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    v138
#endif
    |> fun x -> _v130 <- Some x
    let v139 : System.TimeZoneInfo = _v130.Value
    let v140 : System.TimeSpan option = None
    let v141 : bool = true in let mutable _v140 = v140
    
#if FABLE_COMPILER || WASM || CONTRACT
    
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
    
#if FABLE_COMPILER_TYPESCRIPT
    let v145 : System.TimeSpan = System.TimeSpan () 
    v145
#endif
    
#if FABLE_COMPILER_PYTHON
    let v146 : System.TimeSpan = System.TimeSpan () 
    v146
#endif
    
#else
    let v147 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v148 : System.TimeZoneInfo option = None
    let v149 : bool = true in let mutable _v148 = v148
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v150 : string = "0i64.into()"
    let v151 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v150
    v151
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v152 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v152
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v153 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v153
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v154 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v154
#endif
    
#if FABLE_COMPILER_PYTHON
    let v155 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v155
#endif
    
#else
    let v156 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    v156
#endif
    |> fun x -> _v148 <- Some x
    let v157 : System.TimeZoneInfo = _v148.Value
    let v158 : (System.DateTime -> System.TimeSpan) = v147 v157
    let v159 : System.TimeSpan = v158 v95
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
    
#if FABLE_COMPILER_TYPESCRIPT
    let struct (v173 : string, v174 : string) = null |> unbox<struct (string * string)>
    struct (v173, v174)
#endif
    
#if FABLE_COMPILER_PYTHON
    let struct (v175 : string, v176 : string) = null |> unbox<struct (string * string)>
    struct (v175, v176)
#endif
    
#else
    let v177 : string = method20()
    let v178 : (string -> string) = v83.ToString
    let v179 : string = v178 v177
    let v180 : System.TimeZoneInfo option = None
    let v181 : bool = true in let mutable _v180 = v180
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v182 : string = "0i64.into()"
    let v183 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v182
    v183
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v184 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v184
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v185 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v185
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v186 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v186
#endif
    
#if FABLE_COMPILER_PYTHON
    let v187 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v187
#endif
    
#else
    let v188 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    v188
#endif
    |> fun x -> _v180 <- Some x
    let v189 : System.TimeZoneInfo = _v180.Value
    let v190 : System.TimeSpan option = None
    let v191 : bool = true in let mutable _v190 = v190
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v192 : System.TimeSpan = System.TimeSpan () 
    v192
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v193 : System.TimeSpan = System.TimeSpan () 
    v193
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v194 : System.TimeSpan = System.TimeSpan () 
    v194
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v195 : System.TimeSpan = System.TimeSpan () 
    v195
#endif
    
#if FABLE_COMPILER_PYTHON
    let v196 : System.TimeSpan = System.TimeSpan () 
    v196
#endif
    
#else
    let v197 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v198 : System.TimeZoneInfo option = None
    let v199 : bool = true in let mutable _v198 = v198
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v200 : string = "0i64.into()"
    let v201 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v200
    v201
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v202 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v202
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v203 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v203
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v204 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v204
#endif
    
#if FABLE_COMPILER_PYTHON
    let v205 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v205
#endif
    
#else
    let v206 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    v206
#endif
    |> fun x -> _v198 <- Some x
    let v207 : System.TimeZoneInfo = _v198.Value
    let v208 : (System.DateTime -> System.TimeSpan) = v197 v207
    let v209 : System.TimeSpan = v208 v83
    v209
#endif
    |> fun x -> _v190 <- Some x
    let v210 : System.TimeSpan = _v190.Value
    let v211 : (System.TimeSpan -> int32) = _.Hours
    let v212 : int32 = v211 v210
    let v213 : bool = v212 > 0
    let v214 : (bool -> int32) = System.Convert.ToInt32
    let v215 : int32 = v214 v213
    let v216 : string = method21()
    let v217 : (string -> string) = v210.ToString
    let v218 : string = v217 v216
    let v219 : string = $"{v215}{v218}"
    struct (v179, v219)
#endif
    |> fun x -> _v87 <- Some x
    let struct (v220 : string, v221 : string) = _v87.Value
    let v222 : System.Guid = System.Guid $"{v220}{v221}{v86.[v220.Length + v221.Length..]}"
    let v223 : (System.Guid -> string) = _.ToString()
    let v224 : string = v223 v222
    let v225 : string option = None
    let v226 : bool = true in let mutable _v225 = v225
    
#if FABLE_COMPILER || WASM || CONTRACT
    
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
    
#if FABLE_COMPILER || WASM || CONTRACT
    
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
    
#if FABLE_COMPILER_TYPESCRIPT
    let v251 : std_string_String = null |> unbox<std_string_String>
    v251
#endif
    
#if FABLE_COMPILER_PYTHON
    let v252 : std_string_String = null |> unbox<std_string_String>
    v252
#endif
    
#else
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
    
#if FABLE_COMPILER_TYPESCRIPT
    let v259 : IPathJoin = Fable.Core.JsInterop.importAll v74
    let v260 : string = method15(v82)
    let v261 : string = method16(v224)
    let v262 : string = "v259.join(v260, v261)"
    let v263 : string = Fable.Core.JsInterop.emitJsExpr () v262
    v263
#endif
    
#if FABLE_COMPILER_PYTHON
    let v264 : string = null |> unbox<string>
    v264
#endif
    
#else
    let v265 : string = System.IO.Path.Combine (v82, v224)
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
    
#if FABLE_COMPILER_TYPESCRIPT
    let v269 : string = null |> unbox<string>
    v269
#endif
    
#if FABLE_COMPILER_PYTHON
    let v270 : string = null |> unbox<string>
    v270
#endif
    
#else
    let v271 : string option = None
    let v272 : bool = true in let mutable _v271 = v271
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v273 : string = "env!(\"CARGO_PKG_NAME\").into()"
    let v274 : string = Fable.Core.RustInterop.emitRustExpr () v273
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
    
#if FABLE_COMPILER_TYPESCRIPT
    let v277 : string = null |> unbox<string>
    v277
#endif
    
#if FABLE_COMPILER_PYTHON
    let v278 : string = null |> unbox<string>
    v278
#endif
    
#else
    let v279 : string = System.Reflection.Assembly.GetEntryAssembly().GetName().Name
    v279
#endif
    |> fun x -> _v271 <- Some x
    let v280 : string = _v271.Value
    let v281 : string option = None
    let v282 : bool = true in let mutable _v281 = v281
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v283 : string = "std::env::temp_dir()"
    let v284 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr () v283
    let v285 : string = "$0.display()"
    let v286 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v284 v285
    let v287 : std_string_String option = None
    let v288 : bool = true in let mutable _v287 = v287
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v289 : string = @$"format!(""{{}}"", $0)"
    let v290 : std_string_String = Fable.Core.RustInterop.emitRustExpr v286 v289
    v290
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v291 : string = @$"format!(""{{}}"", $0)"
    let v292 : std_string_String = Fable.Core.RustInterop.emitRustExpr v286 v291
    v292
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v293 : string = @$"format!(""{{}}"", $0)"
    let v294 : std_string_String = Fable.Core.RustInterop.emitRustExpr v286 v293
    v294
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v295 : std_string_String = null |> unbox<std_string_String>
    v295
#endif
    
#if FABLE_COMPILER_PYTHON
    let v296 : std_string_String = null |> unbox<std_string_String>
    v296
#endif
    
#else
    let v297 : std_string_String = null |> unbox<std_string_String>
    v297
#endif
    |> fun x -> _v287 <- Some x
    let v298 : std_string_String = _v287.Value
    let v299 : string = "fable_library_rust::String_::fromString($0)"
    let v300 : string = Fable.Core.RustInterop.emitRustExpr v298 v299
    v300
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v301 : string = null |> unbox<string>
    v301
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v302 : string = null |> unbox<string>
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
    
#else
    let v305 : (unit -> string) = System.IO.Path.GetTempPath
    let v306 : string = v305 ()
    v306
#endif
    |> fun x -> _v281 <- Some x
    let v307 : string = _v281.Value
    let v308 : string = $"!{v280}"
    let v309 : string option = None
    let v310 : bool = true in let mutable _v309 = v309
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v311 : string = method4(v307)
    let v312 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v313 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v311 v312
    let v314 : string = "String::from($0)"
    let v315 : std_string_String = Fable.Core.RustInterop.emitRustExpr v313 v314
    let v316 : string = "std::path::PathBuf::from($0)"
    let v317 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v315 v316
    let v318 : string = method4(v308)
    let v319 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v320 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v318 v319
    let v321 : string = "String::from($0)"
    let v322 : std_string_String = Fable.Core.RustInterop.emitRustExpr v320 v321
    let v323 : string = "$0.join($1)"
    let v324 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr struct (v317, v322) v323
    let v325 : string = "$0.display()"
    let v326 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v324 v325
    let v327 : std_string_String option = None
    let v328 : bool = true in let mutable _v327 = v327
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v329 : string = @$"format!(""{{}}"", $0)"
    let v330 : std_string_String = Fable.Core.RustInterop.emitRustExpr v326 v329
    v330
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v331 : string = @$"format!(""{{}}"", $0)"
    let v332 : std_string_String = Fable.Core.RustInterop.emitRustExpr v326 v331
    v332
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v333 : string = @$"format!(""{{}}"", $0)"
    let v334 : std_string_String = Fable.Core.RustInterop.emitRustExpr v326 v333
    v334
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v335 : std_string_String = null |> unbox<std_string_String>
    v335
#endif
    
#if FABLE_COMPILER_PYTHON
    let v336 : std_string_String = null |> unbox<std_string_String>
    v336
#endif
    
#else
    let v337 : std_string_String = null |> unbox<std_string_String>
    v337
#endif
    |> fun x -> _v327 <- Some x
    let v338 : std_string_String = _v327.Value
    let v339 : string = "fable_library_rust::String_::fromString($0)"
    let v340 : string = Fable.Core.RustInterop.emitRustExpr v338 v339
    v340
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v341 : string = null |> unbox<string>
    v341
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v342 : string = null |> unbox<string>
    v342
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v343 : IPathJoin = Fable.Core.JsInterop.importAll v74
    let v344 : string = method15(v307)
    let v345 : string = method16(v308)
    let v346 : string = "v343.join(v344, v345)"
    let v347 : string = Fable.Core.JsInterop.emitJsExpr () v346
    v347
#endif
    
#if FABLE_COMPILER_PYTHON
    let v348 : string = null |> unbox<string>
    v348
#endif
    
#else
    let v349 : string = System.IO.Path.Combine (v307, v308)
    v349
#endif
    |> fun x -> _v309 <- Some x
    let v350 : string = _v309.Value
    let v351 : System.DateTime = System.DateTime.Now
    let v352 : System.Guid = System.Guid.NewGuid ()
    let v353 : (System.Guid -> string) = _.ToString()
    let v354 : string = v353 v352
    let v355 : struct (string * string) option = None
    let v356 : bool = true in let mutable _v355 = v355
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v357 : System.DateTime = System.DateTime (1970, 1, 1, 0, 0, 0, System.DateTimeKind.Utc)
    let v358 : (System.DateTime -> System.DateTime) = _.ToUniversalTime()
    let v359 : System.DateTime = v358 v357
    let v360 : System.DateTimeKind = System.DateTimeKind.Local
    let v361 : System.DateTime = System.DateTime.SpecifyKind (v351, v360)
    let v362 : (System.DateTime -> System.DateTime) = _.ToUniversalTime()
    let v363 : System.DateTime = v362 v361
    let v364 : (System.DateTime -> int64) = _.Ticks
    let v365 : int64 = v364 v363
    let v366 : (System.DateTime -> int64) = _.Ticks
    let v367 : int64 = v366 v359
    let v368 : int64 = v365 - v367
    let v369 : int64 = v368 / 10L
    let v370 : string = "chrono::DateTime::from_timestamp_micros($0)"
    let v371 : chrono_DateTime<chrono_Utc> option = Fable.Core.RustInterop.emitRustExpr v369 v370
    let v372 : (chrono_DateTime<chrono_Utc> -> US8) = method17()
    let v373 : US8 = US8_1
    let v374 : US8 = v371 |> Option.map v372 |> Option.defaultValue v373 
    let v393 : US9 =
        match v374 with
        | US8_1 -> (* None *)
            US9_1
        | US8_0(v375) -> (* Some *)
            let v376 : chrono_DateTime<chrono_Utc> = method18(v375)
            let v377 : string = "v376.naive_utc()"
            let v378 : chrono_NaiveDateTime = Fable.Core.RustInterop.emitRustExpr () v377
            let v379 : string = "chrono::offset::TimeZone::from_utc_datetime(&chrono::Local, &v378)"
            let v380 : chrono_DateTime<chrono_Local> = Fable.Core.RustInterop.emitRustExpr () v379
            let v381 : string = "%Y%m%d-%H%M-%S%f"
            let v382 : string = "r#\"" + v381 + "\"#"
            let v383 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v382
            let v384 : chrono_DateTime<chrono_Local> = method19(v380)
            let v385 : string = "v384.format(v383).to_string()"
            let v386 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v385
            let v387 : string = "fable_library_rust::String_::fromString($0)"
            let v388 : string = Fable.Core.RustInterop.emitRustExpr v386 v387
            let v389 : string = $"{v388.[0..17]}-{v388.[18..21]}-{v388.[22]}"
            US9_0(v389)
    let v397 : string =
        match v393 with
        | US9_1 -> (* None *)
            let v395 : string = ""
            v395
        | US9_0(v394) -> (* Some *)
            v394
    let v398 : System.TimeZoneInfo option = None
    let v399 : bool = true in let mutable _v398 = v398
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v400 : string = "0i64.into()"
    let v401 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v400
    v401
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v402 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v402
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v403 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v403
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v404 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v404
#endif
    
#if FABLE_COMPILER_PYTHON
    let v405 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v405
#endif
    
#else
    let v406 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    v406
#endif
    |> fun x -> _v398 <- Some x
    let v407 : System.TimeZoneInfo = _v398.Value
    let v408 : System.TimeSpan option = None
    let v409 : bool = true in let mutable _v408 = v408
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v410 : System.TimeSpan = System.TimeSpan () 
    v410
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v411 : System.TimeSpan = System.TimeSpan () 
    v411
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v412 : System.TimeSpan = System.TimeSpan () 
    v412
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v413 : System.TimeSpan = System.TimeSpan () 
    v413
#endif
    
#if FABLE_COMPILER_PYTHON
    let v414 : System.TimeSpan = System.TimeSpan () 
    v414
#endif
    
#else
    let v415 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v416 : System.TimeZoneInfo option = None
    let v417 : bool = true in let mutable _v416 = v416
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v418 : string = "0i64.into()"
    let v419 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v418
    v419
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v420 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v420
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v421 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v421
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v422 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v422
#endif
    
#if FABLE_COMPILER_PYTHON
    let v423 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v423
#endif
    
#else
    let v424 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    v424
#endif
    |> fun x -> _v416 <- Some x
    let v425 : System.TimeZoneInfo = _v416.Value
    let v426 : (System.DateTime -> System.TimeSpan) = v415 v425
    let v427 : System.TimeSpan = v426 v363
    v427
#endif
    |> fun x -> _v408 <- Some x
    let v428 : System.TimeSpan = _v408.Value
    let v429 : (System.TimeSpan -> int32) = _.Hours
    let v430 : int32 = v429 v428
    let v431 : bool = v430 > 0
    let v432 : uint8 =
        if v431 then
            1uy
        else
            0uy
    let v433 : (string -> string) = v428.ToString
    let v434 : string = v433 v166
    let v435 : string = $"{v432}{v434.[0..1]}{v434.[3..4]}"
    struct (v397, v435)
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let struct (v436 : string, v437 : string) = null |> unbox<struct (string * string)>
    struct (v436, v437)
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let struct (v438 : string, v439 : string) = null |> unbox<struct (string * string)>
    struct (v438, v439)
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let struct (v440 : string, v441 : string) = null |> unbox<struct (string * string)>
    struct (v440, v441)
#endif
    
#if FABLE_COMPILER_PYTHON
    let struct (v442 : string, v443 : string) = null |> unbox<struct (string * string)>
    struct (v442, v443)
#endif
    
#else
    let v444 : string = method20()
    let v445 : (string -> string) = v351.ToString
    let v446 : string = v445 v444
    let v447 : System.TimeZoneInfo option = None
    let v448 : bool = true in let mutable _v447 = v447
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v449 : string = "0i64.into()"
    let v450 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v449
    v450
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v451 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v451
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v452 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v452
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v453 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v453
#endif
    
#if FABLE_COMPILER_PYTHON
    let v454 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v454
#endif
    
#else
    let v455 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    v455
#endif
    |> fun x -> _v447 <- Some x
    let v456 : System.TimeZoneInfo = _v447.Value
    let v457 : System.TimeSpan option = None
    let v458 : bool = true in let mutable _v457 = v457
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v459 : System.TimeSpan = System.TimeSpan () 
    v459
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v460 : System.TimeSpan = System.TimeSpan () 
    v460
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v461 : System.TimeSpan = System.TimeSpan () 
    v461
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v462 : System.TimeSpan = System.TimeSpan () 
    v462
#endif
    
#if FABLE_COMPILER_PYTHON
    let v463 : System.TimeSpan = System.TimeSpan () 
    v463
#endif
    
#else
    let v464 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v465 : System.TimeZoneInfo option = None
    let v466 : bool = true in let mutable _v465 = v465
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v467 : string = "0i64.into()"
    let v468 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v467
    v468
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v469 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v469
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v470 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v470
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v471 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v471
#endif
    
#if FABLE_COMPILER_PYTHON
    let v472 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v472
#endif
    
#else
    let v473 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    v473
#endif
    |> fun x -> _v465 <- Some x
    let v474 : System.TimeZoneInfo = _v465.Value
    let v475 : (System.DateTime -> System.TimeSpan) = v464 v474
    let v476 : System.TimeSpan = v475 v351
    v476
#endif
    |> fun x -> _v457 <- Some x
    let v477 : System.TimeSpan = _v457.Value
    let v478 : (System.TimeSpan -> int32) = _.Hours
    let v479 : int32 = v478 v477
    let v480 : bool = v479 > 0
    let v481 : (bool -> int32) = System.Convert.ToInt32
    let v482 : int32 = v481 v480
    let v483 : string = method21()
    let v484 : (string -> string) = v477.ToString
    let v485 : string = v484 v483
    let v486 : string = $"{v482}{v485}"
    struct (v446, v486)
#endif
    |> fun x -> _v355 <- Some x
    let struct (v487 : string, v488 : string) = _v355.Value
    let v489 : System.Guid = System.Guid $"{v487}{v488}{v354.[v487.Length + v488.Length..]}"
    let v490 : (System.Guid -> string) = _.ToString()
    let v491 : string = v490 v489
    let v492 : string option = None
    let v493 : bool = true in let mutable _v492 = v492
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v494 : string = method4(v350)
    let v495 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v496 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v494 v495
    let v497 : string = "String::from($0)"
    let v498 : std_string_String = Fable.Core.RustInterop.emitRustExpr v496 v497
    let v499 : string = "std::path::PathBuf::from($0)"
    let v500 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v498 v499
    let v501 : string = method4(v491)
    let v502 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v503 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v501 v502
    let v504 : string = "String::from($0)"
    let v505 : std_string_String = Fable.Core.RustInterop.emitRustExpr v503 v504
    let v506 : string = "$0.join($1)"
    let v507 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr struct (v500, v505) v506
    let v508 : string = "$0.display()"
    let v509 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v507 v508
    let v510 : std_string_String option = None
    let v511 : bool = true in let mutable _v510 = v510
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v512 : string = @$"format!(""{{}}"", $0)"
    let v513 : std_string_String = Fable.Core.RustInterop.emitRustExpr v509 v512
    v513
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v514 : string = @$"format!(""{{}}"", $0)"
    let v515 : std_string_String = Fable.Core.RustInterop.emitRustExpr v509 v514
    v515
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v516 : string = @$"format!(""{{}}"", $0)"
    let v517 : std_string_String = Fable.Core.RustInterop.emitRustExpr v509 v516
    v517
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v518 : std_string_String = null |> unbox<std_string_String>
    v518
#endif
    
#if FABLE_COMPILER_PYTHON
    let v519 : std_string_String = null |> unbox<std_string_String>
    v519
#endif
    
#else
    let v520 : std_string_String = null |> unbox<std_string_String>
    v520
#endif
    |> fun x -> _v510 <- Some x
    let v521 : std_string_String = _v510.Value
    let v522 : string = "fable_library_rust::String_::fromString($0)"
    let v523 : string = Fable.Core.RustInterop.emitRustExpr v521 v522
    v523
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v524 : string = null |> unbox<string>
    v524
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v525 : string = null |> unbox<string>
    v525
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v526 : IPathJoin = Fable.Core.JsInterop.importAll v74
    let v527 : string = method15(v350)
    let v528 : string = method16(v491)
    let v529 : string = "v526.join(v527, v528)"
    let v530 : string = Fable.Core.JsInterop.emitJsExpr () v529
    v530
#endif
    
#if FABLE_COMPILER_PYTHON
    let v531 : string = null |> unbox<string>
    v531
#endif
    
#else
    let v532 : string = System.IO.Path.Combine (v350, v491)
    v532
#endif
    |> fun x -> _v492 <- Some x
    let v533 : string = _v492.Value
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
    let v22 : string = "v21.existsSync($0)"
    let v23 : bool = Fable.Core.JsInterop.emitJsExpr v3 v22
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
and method25 (v0 : string) : (unit -> unit) =
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
    let v40 : string option = None
    let v41 : bool = true in let mutable _v40 = v40
    
#if FABLE_COMPILER || WASM || CONTRACT
    
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
    
#if FABLE_COMPILER || WASM || CONTRACT
    
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
    
#if FABLE_COMPILER_TYPESCRIPT
    let v66 : std_string_String = null |> unbox<std_string_String>
    v66
#endif
    
#if FABLE_COMPILER_PYTHON
    let v67 : std_string_String = null |> unbox<std_string_String>
    v67
#endif
    
#else
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
    
#if FABLE_COMPILER_TYPESCRIPT
    let v74 : string = "path"
    let v75 : IPathJoin = Fable.Core.JsInterop.importAll v74
    let v76 : string = method15(v38)
    let v77 : string = method16(v39)
    let v78 : string = "v75.join(v76, v77)"
    let v79 : string = Fable.Core.JsInterop.emitJsExpr () v78
    v79
#endif
    
#if FABLE_COMPILER_PYTHON
    let v80 : string = null |> unbox<string>
    v80
#endif
    
#else
    let v81 : string = System.IO.Path.Combine (v38, v39)
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
    
#if FABLE_COMPILER || WASM || CONTRACT
    
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
    
#if FABLE_COMPILER || WASM || CONTRACT
    
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
    
#if FABLE_COMPILER_TYPESCRIPT
    let v136 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v136
#endif
    
#if FABLE_COMPILER_PYTHON
    let v137 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v137
#endif
    
#else
    let v138 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    v138
#endif
    |> fun x -> _v130 <- Some x
    let v139 : System.TimeZoneInfo = _v130.Value
    let v140 : System.TimeSpan option = None
    let v141 : bool = true in let mutable _v140 = v140
    
#if FABLE_COMPILER || WASM || CONTRACT
    
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
    
#if FABLE_COMPILER_TYPESCRIPT
    let v145 : System.TimeSpan = System.TimeSpan () 
    v145
#endif
    
#if FABLE_COMPILER_PYTHON
    let v146 : System.TimeSpan = System.TimeSpan () 
    v146
#endif
    
#else
    let v147 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v148 : System.TimeZoneInfo option = None
    let v149 : bool = true in let mutable _v148 = v148
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v150 : string = "0i64.into()"
    let v151 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v150
    v151
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v152 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v152
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v153 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v153
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v154 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v154
#endif
    
#if FABLE_COMPILER_PYTHON
    let v155 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v155
#endif
    
#else
    let v156 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    v156
#endif
    |> fun x -> _v148 <- Some x
    let v157 : System.TimeZoneInfo = _v148.Value
    let v158 : (System.DateTime -> System.TimeSpan) = v147 v157
    let v159 : System.TimeSpan = v158 v95
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
    
#if FABLE_COMPILER_TYPESCRIPT
    let struct (v173 : string, v174 : string) = null |> unbox<struct (string * string)>
    struct (v173, v174)
#endif
    
#if FABLE_COMPILER_PYTHON
    let struct (v175 : string, v176 : string) = null |> unbox<struct (string * string)>
    struct (v175, v176)
#endif
    
#else
    let v177 : string = method20()
    let v178 : (string -> string) = v83.ToString
    let v179 : string = v178 v177
    let v180 : System.TimeZoneInfo option = None
    let v181 : bool = true in let mutable _v180 = v180
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v182 : string = "0i64.into()"
    let v183 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v182
    v183
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v184 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v184
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v185 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v185
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v186 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v186
#endif
    
#if FABLE_COMPILER_PYTHON
    let v187 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v187
#endif
    
#else
    let v188 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    v188
#endif
    |> fun x -> _v180 <- Some x
    let v189 : System.TimeZoneInfo = _v180.Value
    let v190 : System.TimeSpan option = None
    let v191 : bool = true in let mutable _v190 = v190
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v192 : System.TimeSpan = System.TimeSpan () 
    v192
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v193 : System.TimeSpan = System.TimeSpan () 
    v193
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v194 : System.TimeSpan = System.TimeSpan () 
    v194
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v195 : System.TimeSpan = System.TimeSpan () 
    v195
#endif
    
#if FABLE_COMPILER_PYTHON
    let v196 : System.TimeSpan = System.TimeSpan () 
    v196
#endif
    
#else
    let v197 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v198 : System.TimeZoneInfo option = None
    let v199 : bool = true in let mutable _v198 = v198
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v200 : string = "0i64.into()"
    let v201 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v200
    v201
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v202 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v202
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v203 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v203
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v204 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v204
#endif
    
#if FABLE_COMPILER_PYTHON
    let v205 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v205
#endif
    
#else
    let v206 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    v206
#endif
    |> fun x -> _v198 <- Some x
    let v207 : System.TimeZoneInfo = _v198.Value
    let v208 : (System.DateTime -> System.TimeSpan) = v197 v207
    let v209 : System.TimeSpan = v208 v83
    v209
#endif
    |> fun x -> _v190 <- Some x
    let v210 : System.TimeSpan = _v190.Value
    let v211 : (System.TimeSpan -> int32) = _.Hours
    let v212 : int32 = v211 v210
    let v213 : bool = v212 > 0
    let v214 : (bool -> int32) = System.Convert.ToInt32
    let v215 : int32 = v214 v213
    let v216 : string = method21()
    let v217 : (string -> string) = v210.ToString
    let v218 : string = v217 v216
    let v219 : string = $"{v215}{v218}"
    struct (v179, v219)
#endif
    |> fun x -> _v87 <- Some x
    let struct (v220 : string, v221 : string) = _v87.Value
    let v222 : System.Guid = System.Guid $"{v220}{v221}{v86.[v220.Length + v221.Length..]}"
    let v223 : (System.Guid -> string) = _.ToString()
    let v224 : string = v223 v222
    let v225 : string option = None
    let v226 : bool = true in let mutable _v225 = v225
    
#if FABLE_COMPILER || WASM || CONTRACT
    
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
    
#if FABLE_COMPILER || WASM || CONTRACT
    
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
    
#if FABLE_COMPILER_TYPESCRIPT
    let v251 : std_string_String = null |> unbox<std_string_String>
    v251
#endif
    
#if FABLE_COMPILER_PYTHON
    let v252 : std_string_String = null |> unbox<std_string_String>
    v252
#endif
    
#else
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
    
#if FABLE_COMPILER_TYPESCRIPT
    let v259 : IPathJoin = Fable.Core.JsInterop.importAll v74
    let v260 : string = method15(v82)
    let v261 : string = method16(v224)
    let v262 : string = "v259.join(v260, v261)"
    let v263 : string = Fable.Core.JsInterop.emitJsExpr () v262
    v263
#endif
    
#if FABLE_COMPILER_PYTHON
    let v264 : string = null |> unbox<string>
    v264
#endif
    
#else
    let v265 : string = System.IO.Path.Combine (v82, v224)
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
    
#if FABLE_COMPILER_TYPESCRIPT
    let v269 : string = null |> unbox<string>
    v269
#endif
    
#if FABLE_COMPILER_PYTHON
    let v270 : string = null |> unbox<string>
    v270
#endif
    
#else
    let v271 : string option = None
    let v272 : bool = true in let mutable _v271 = v271
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v273 : string = "env!(\"CARGO_PKG_NAME\").into()"
    let v274 : string = Fable.Core.RustInterop.emitRustExpr () v273
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
    
#if FABLE_COMPILER_TYPESCRIPT
    let v277 : string = null |> unbox<string>
    v277
#endif
    
#if FABLE_COMPILER_PYTHON
    let v278 : string = null |> unbox<string>
    v278
#endif
    
#else
    let v279 : string = System.Reflection.Assembly.GetEntryAssembly().GetName().Name
    v279
#endif
    |> fun x -> _v271 <- Some x
    let v280 : string = _v271.Value
    let v281 : string option = None
    let v282 : bool = true in let mutable _v281 = v281
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v283 : string = "std::env::temp_dir()"
    let v284 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr () v283
    let v285 : string = "$0.display()"
    let v286 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v284 v285
    let v287 : std_string_String option = None
    let v288 : bool = true in let mutable _v287 = v287
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v289 : string = @$"format!(""{{}}"", $0)"
    let v290 : std_string_String = Fable.Core.RustInterop.emitRustExpr v286 v289
    v290
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v291 : string = @$"format!(""{{}}"", $0)"
    let v292 : std_string_String = Fable.Core.RustInterop.emitRustExpr v286 v291
    v292
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v293 : string = @$"format!(""{{}}"", $0)"
    let v294 : std_string_String = Fable.Core.RustInterop.emitRustExpr v286 v293
    v294
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v295 : std_string_String = null |> unbox<std_string_String>
    v295
#endif
    
#if FABLE_COMPILER_PYTHON
    let v296 : std_string_String = null |> unbox<std_string_String>
    v296
#endif
    
#else
    let v297 : std_string_String = null |> unbox<std_string_String>
    v297
#endif
    |> fun x -> _v287 <- Some x
    let v298 : std_string_String = _v287.Value
    let v299 : string = "fable_library_rust::String_::fromString($0)"
    let v300 : string = Fable.Core.RustInterop.emitRustExpr v298 v299
    v300
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v301 : string = null |> unbox<string>
    v301
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v302 : string = null |> unbox<string>
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
    
#else
    let v305 : (unit -> string) = System.IO.Path.GetTempPath
    let v306 : string = v305 ()
    v306
#endif
    |> fun x -> _v281 <- Some x
    let v307 : string = _v281.Value
    let v308 : string = $"!{v280}"
    let v309 : string option = None
    let v310 : bool = true in let mutable _v309 = v309
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v311 : string = method4(v307)
    let v312 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v313 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v311 v312
    let v314 : string = "String::from($0)"
    let v315 : std_string_String = Fable.Core.RustInterop.emitRustExpr v313 v314
    let v316 : string = "std::path::PathBuf::from($0)"
    let v317 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v315 v316
    let v318 : string = method4(v308)
    let v319 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v320 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v318 v319
    let v321 : string = "String::from($0)"
    let v322 : std_string_String = Fable.Core.RustInterop.emitRustExpr v320 v321
    let v323 : string = "$0.join($1)"
    let v324 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr struct (v317, v322) v323
    let v325 : string = "$0.display()"
    let v326 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v324 v325
    let v327 : std_string_String option = None
    let v328 : bool = true in let mutable _v327 = v327
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v329 : string = @$"format!(""{{}}"", $0)"
    let v330 : std_string_String = Fable.Core.RustInterop.emitRustExpr v326 v329
    v330
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v331 : string = @$"format!(""{{}}"", $0)"
    let v332 : std_string_String = Fable.Core.RustInterop.emitRustExpr v326 v331
    v332
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v333 : string = @$"format!(""{{}}"", $0)"
    let v334 : std_string_String = Fable.Core.RustInterop.emitRustExpr v326 v333
    v334
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v335 : std_string_String = null |> unbox<std_string_String>
    v335
#endif
    
#if FABLE_COMPILER_PYTHON
    let v336 : std_string_String = null |> unbox<std_string_String>
    v336
#endif
    
#else
    let v337 : std_string_String = null |> unbox<std_string_String>
    v337
#endif
    |> fun x -> _v327 <- Some x
    let v338 : std_string_String = _v327.Value
    let v339 : string = "fable_library_rust::String_::fromString($0)"
    let v340 : string = Fable.Core.RustInterop.emitRustExpr v338 v339
    v340
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v341 : string = null |> unbox<string>
    v341
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v342 : string = null |> unbox<string>
    v342
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v343 : IPathJoin = Fable.Core.JsInterop.importAll v74
    let v344 : string = method15(v307)
    let v345 : string = method16(v308)
    let v346 : string = "v343.join(v344, v345)"
    let v347 : string = Fable.Core.JsInterop.emitJsExpr () v346
    v347
#endif
    
#if FABLE_COMPILER_PYTHON
    let v348 : string = null |> unbox<string>
    v348
#endif
    
#else
    let v349 : string = System.IO.Path.Combine (v307, v308)
    v349
#endif
    |> fun x -> _v309 <- Some x
    let v350 : string = _v309.Value
    let v351 : System.DateTime = System.DateTime.Now
    let v352 : System.Guid = System.Guid.NewGuid ()
    let v353 : (System.Guid -> string) = _.ToString()
    let v354 : string = v353 v352
    let v355 : struct (string * string) option = None
    let v356 : bool = true in let mutable _v355 = v355
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v357 : System.DateTime = System.DateTime (1970, 1, 1, 0, 0, 0, System.DateTimeKind.Utc)
    let v358 : (System.DateTime -> System.DateTime) = _.ToUniversalTime()
    let v359 : System.DateTime = v358 v357
    let v360 : System.DateTimeKind = System.DateTimeKind.Local
    let v361 : System.DateTime = System.DateTime.SpecifyKind (v351, v360)
    let v362 : (System.DateTime -> System.DateTime) = _.ToUniversalTime()
    let v363 : System.DateTime = v362 v361
    let v364 : (System.DateTime -> int64) = _.Ticks
    let v365 : int64 = v364 v363
    let v366 : (System.DateTime -> int64) = _.Ticks
    let v367 : int64 = v366 v359
    let v368 : int64 = v365 - v367
    let v369 : int64 = v368 / 10L
    let v370 : string = "chrono::DateTime::from_timestamp_micros($0)"
    let v371 : chrono_DateTime<chrono_Utc> option = Fable.Core.RustInterop.emitRustExpr v369 v370
    let v372 : (chrono_DateTime<chrono_Utc> -> US8) = method17()
    let v373 : US8 = US8_1
    let v374 : US8 = v371 |> Option.map v372 |> Option.defaultValue v373 
    let v393 : US9 =
        match v374 with
        | US8_1 -> (* None *)
            US9_1
        | US8_0(v375) -> (* Some *)
            let v376 : chrono_DateTime<chrono_Utc> = method18(v375)
            let v377 : string = "v376.naive_utc()"
            let v378 : chrono_NaiveDateTime = Fable.Core.RustInterop.emitRustExpr () v377
            let v379 : string = "chrono::offset::TimeZone::from_utc_datetime(&chrono::Local, &v378)"
            let v380 : chrono_DateTime<chrono_Local> = Fable.Core.RustInterop.emitRustExpr () v379
            let v381 : string = "%Y%m%d-%H%M-%S%f"
            let v382 : string = "r#\"" + v381 + "\"#"
            let v383 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v382
            let v384 : chrono_DateTime<chrono_Local> = method19(v380)
            let v385 : string = "v384.format(v383).to_string()"
            let v386 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v385
            let v387 : string = "fable_library_rust::String_::fromString($0)"
            let v388 : string = Fable.Core.RustInterop.emitRustExpr v386 v387
            let v389 : string = $"{v388.[0..17]}-{v388.[18..21]}-{v388.[22]}"
            US9_0(v389)
    let v397 : string =
        match v393 with
        | US9_1 -> (* None *)
            let v395 : string = ""
            v395
        | US9_0(v394) -> (* Some *)
            v394
    let v398 : System.TimeZoneInfo option = None
    let v399 : bool = true in let mutable _v398 = v398
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v400 : string = "0i64.into()"
    let v401 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v400
    v401
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v402 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v402
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v403 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v403
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v404 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v404
#endif
    
#if FABLE_COMPILER_PYTHON
    let v405 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v405
#endif
    
#else
    let v406 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    v406
#endif
    |> fun x -> _v398 <- Some x
    let v407 : System.TimeZoneInfo = _v398.Value
    let v408 : System.TimeSpan option = None
    let v409 : bool = true in let mutable _v408 = v408
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v410 : System.TimeSpan = System.TimeSpan () 
    v410
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v411 : System.TimeSpan = System.TimeSpan () 
    v411
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v412 : System.TimeSpan = System.TimeSpan () 
    v412
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v413 : System.TimeSpan = System.TimeSpan () 
    v413
#endif
    
#if FABLE_COMPILER_PYTHON
    let v414 : System.TimeSpan = System.TimeSpan () 
    v414
#endif
    
#else
    let v415 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v416 : System.TimeZoneInfo option = None
    let v417 : bool = true in let mutable _v416 = v416
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v418 : string = "0i64.into()"
    let v419 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v418
    v419
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v420 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v420
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v421 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v421
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v422 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v422
#endif
    
#if FABLE_COMPILER_PYTHON
    let v423 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v423
#endif
    
#else
    let v424 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    v424
#endif
    |> fun x -> _v416 <- Some x
    let v425 : System.TimeZoneInfo = _v416.Value
    let v426 : (System.DateTime -> System.TimeSpan) = v415 v425
    let v427 : System.TimeSpan = v426 v363
    v427
#endif
    |> fun x -> _v408 <- Some x
    let v428 : System.TimeSpan = _v408.Value
    let v429 : (System.TimeSpan -> int32) = _.Hours
    let v430 : int32 = v429 v428
    let v431 : bool = v430 > 0
    let v432 : uint8 =
        if v431 then
            1uy
        else
            0uy
    let v433 : (string -> string) = v428.ToString
    let v434 : string = v433 v166
    let v435 : string = $"{v432}{v434.[0..1]}{v434.[3..4]}"
    struct (v397, v435)
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let struct (v436 : string, v437 : string) = null |> unbox<struct (string * string)>
    struct (v436, v437)
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let struct (v438 : string, v439 : string) = null |> unbox<struct (string * string)>
    struct (v438, v439)
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let struct (v440 : string, v441 : string) = null |> unbox<struct (string * string)>
    struct (v440, v441)
#endif
    
#if FABLE_COMPILER_PYTHON
    let struct (v442 : string, v443 : string) = null |> unbox<struct (string * string)>
    struct (v442, v443)
#endif
    
#else
    let v444 : string = method20()
    let v445 : (string -> string) = v351.ToString
    let v446 : string = v445 v444
    let v447 : System.TimeZoneInfo option = None
    let v448 : bool = true in let mutable _v447 = v447
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v449 : string = "0i64.into()"
    let v450 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v449
    v450
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v451 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v451
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v452 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v452
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v453 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v453
#endif
    
#if FABLE_COMPILER_PYTHON
    let v454 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v454
#endif
    
#else
    let v455 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    v455
#endif
    |> fun x -> _v447 <- Some x
    let v456 : System.TimeZoneInfo = _v447.Value
    let v457 : System.TimeSpan option = None
    let v458 : bool = true in let mutable _v457 = v457
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v459 : System.TimeSpan = System.TimeSpan () 
    v459
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v460 : System.TimeSpan = System.TimeSpan () 
    v460
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v461 : System.TimeSpan = System.TimeSpan () 
    v461
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v462 : System.TimeSpan = System.TimeSpan () 
    v462
#endif
    
#if FABLE_COMPILER_PYTHON
    let v463 : System.TimeSpan = System.TimeSpan () 
    v463
#endif
    
#else
    let v464 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v465 : System.TimeZoneInfo option = None
    let v466 : bool = true in let mutable _v465 = v465
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v467 : string = "0i64.into()"
    let v468 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v467
    v468
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v469 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v469
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v470 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v470
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v471 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v471
#endif
    
#if FABLE_COMPILER_PYTHON
    let v472 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v472
#endif
    
#else
    let v473 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    v473
#endif
    |> fun x -> _v465 <- Some x
    let v474 : System.TimeZoneInfo = _v465.Value
    let v475 : (System.DateTime -> System.TimeSpan) = v464 v474
    let v476 : System.TimeSpan = v475 v351
    v476
#endif
    |> fun x -> _v457 <- Some x
    let v477 : System.TimeSpan = _v457.Value
    let v478 : (System.TimeSpan -> int32) = _.Hours
    let v479 : int32 = v478 v477
    let v480 : bool = v479 > 0
    let v481 : (bool -> int32) = System.Convert.ToInt32
    let v482 : int32 = v481 v480
    let v483 : string = method21()
    let v484 : (string -> string) = v477.ToString
    let v485 : string = v484 v483
    let v486 : string = $"{v482}{v485}"
    struct (v446, v486)
#endif
    |> fun x -> _v355 <- Some x
    let struct (v487 : string, v488 : string) = _v355.Value
    let v489 : System.Guid = System.Guid $"{v487}{v488}{v354.[v487.Length + v488.Length..]}"
    let v490 : (System.Guid -> string) = _.ToString()
    let v491 : string = v490 v489
    let v492 : string option = None
    let v493 : bool = true in let mutable _v492 = v492
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v494 : string = method4(v350)
    let v495 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v496 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v494 v495
    let v497 : string = "String::from($0)"
    let v498 : std_string_String = Fable.Core.RustInterop.emitRustExpr v496 v497
    let v499 : string = "std::path::PathBuf::from($0)"
    let v500 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v498 v499
    let v501 : string = method4(v491)
    let v502 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v503 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v501 v502
    let v504 : string = "String::from($0)"
    let v505 : std_string_String = Fable.Core.RustInterop.emitRustExpr v503 v504
    let v506 : string = "$0.join($1)"
    let v507 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr struct (v500, v505) v506
    let v508 : string = "$0.display()"
    let v509 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v507 v508
    let v510 : std_string_String option = None
    let v511 : bool = true in let mutable _v510 = v510
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v512 : string = @$"format!(""{{}}"", $0)"
    let v513 : std_string_String = Fable.Core.RustInterop.emitRustExpr v509 v512
    v513
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v514 : string = @$"format!(""{{}}"", $0)"
    let v515 : std_string_String = Fable.Core.RustInterop.emitRustExpr v509 v514
    v515
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v516 : string = @$"format!(""{{}}"", $0)"
    let v517 : std_string_String = Fable.Core.RustInterop.emitRustExpr v509 v516
    v517
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v518 : std_string_String = null |> unbox<std_string_String>
    v518
#endif
    
#if FABLE_COMPILER_PYTHON
    let v519 : std_string_String = null |> unbox<std_string_String>
    v519
#endif
    
#else
    let v520 : std_string_String = null |> unbox<std_string_String>
    v520
#endif
    |> fun x -> _v510 <- Some x
    let v521 : std_string_String = _v510.Value
    let v522 : string = "fable_library_rust::String_::fromString($0)"
    let v523 : string = Fable.Core.RustInterop.emitRustExpr v521 v522
    v523
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v524 : string = null |> unbox<string>
    v524
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v525 : string = null |> unbox<string>
    v525
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v526 : IPathJoin = Fable.Core.JsInterop.importAll v74
    let v527 : string = method15(v350)
    let v528 : string = method16(v491)
    let v529 : string = "v526.join(v527, v528)"
    let v530 : string = Fable.Core.JsInterop.emitJsExpr () v529
    v530
#endif
    
#if FABLE_COMPILER_PYTHON
    let v531 : string = null |> unbox<string>
    v531
#endif
    
#else
    let v532 : string = System.IO.Path.Combine (v350, v491)
    v532
#endif
    |> fun x -> _v492 <- Some x
    let v533 : string = _v492.Value
    v533
#endif
    |> fun x -> _v0 <- Some x
    let v534 : string = _v0.Value
    let v535 : System.IDisposable option = None
    let v536 : bool = true in let mutable _v535 = v535
    
#if FABLE_COMPILER || WASM || CONTRACT
    
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
    
#if FABLE_COMPILER || WASM || CONTRACT
    
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
    
#if FABLE_COMPILER_TYPESCRIPT
    let v559 : System.IDisposable = null |> unbox<System.IDisposable>
    v559
#endif
    
#if FABLE_COMPILER_PYTHON
    let v560 : System.IDisposable = null |> unbox<System.IDisposable>
    v560
#endif
    
#else
    let v561 : (unit -> unit) = method24(v537)
    let v562 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v561 () }
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
    
#if FABLE_COMPILER_TYPESCRIPT
    let v566 : System.IDisposable = null |> unbox<System.IDisposable>
    v566
#endif
    
#if FABLE_COMPILER_PYTHON
    let v567 : System.IDisposable = null |> unbox<System.IDisposable>
    v567
#endif
    
#else
    let v568 : System.IO.DirectoryInfo option = None
    let v569 : bool = true in let mutable _v568 = v568
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v570 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    v570
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v571 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    v571
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v572 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
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
    
#else
    let v575 : (string -> System.IO.DirectoryInfo) = System.IO.Directory.CreateDirectory
    let v576 : System.IO.DirectoryInfo = v575 v534
    v576
#endif
    |> fun x -> _v568 <- Some x
    let v577 : System.IO.DirectoryInfo = _v568.Value
    let v578 : bool option = None
    let v579 : bool = true in let mutable _v578 = v578
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v580 : bool = null |> unbox<bool>
    v580
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v581 : bool = null |> unbox<bool>
    v581
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v582 : bool = null |> unbox<bool>
    v582
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v583 : bool = null |> unbox<bool>
    v583
#endif
    
#if FABLE_COMPILER_PYTHON
    let v584 : bool = null |> unbox<bool>
    v584
#endif
    
#else
    let v585 : bool = v577.Exists
    v585
#endif
    |> fun x -> _v578 <- Some x
    let v586 : bool = _v578.Value
    let v587 : bool = v586 = false
    if v587 then
        let v588 : System.DateTime option = None
        let v589 : bool = true in let mutable _v588 = v588
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v590 : System.DateTime = null |> unbox<System.DateTime>
        v590
#endif
        
#if FABLE_COMPILER_RUST && WASM
        let v591 : System.DateTime = null |> unbox<System.DateTime>
        v591
#endif
        
#if FABLE_COMPILER_RUST && CONTRACT
        let v592 : System.DateTime = null |> unbox<System.DateTime>
        v592
#endif
        
#if FABLE_COMPILER_TYPESCRIPT
        let v593 : System.DateTime = null |> unbox<System.DateTime>
        v593
#endif
        
#if FABLE_COMPILER_PYTHON
        let v594 : System.DateTime = null |> unbox<System.DateTime>
        v594
#endif
        
#else
        let v595 : System.DateTime = v577.CreationTime
        v595
#endif
        |> fun x -> _v588 <- Some x
        let v596 : System.DateTime = _v588.Value
        let v597 : obj = {| Exists = v586; CreationTime = v596 |}
        let v598 : string = $"%A{v597}"
        let v599 : US0 = US0_1
        let v600 : (unit -> string) = closure47()
        let v601 : (unit -> string) = closure48(v534, v598)
        method5(v599, v600, v601)
    let v602 : System.IDisposable option = None
    let v603 : bool = true in let mutable _v602 = v602
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v604 : (unit -> unit) = closure49(v534)
    let v605 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v604 "$0()" )
    v605
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v606 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v604 "$0()" )
    v606
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v607 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v604 "$0()" )
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
    
#else
    let v610 : (unit -> unit) = method25(v534)
    let v611 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v610 () }
    v611
#endif
    |> fun x -> _v602 <- Some x
    let v612 : System.IDisposable = _v602.Value
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
    let v19 : string = "v18.existsSync($0)"
    let v20 : bool = Fable.Core.JsInterop.emitJsExpr v0 v19
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
    let v19 : string = "v18.existsSync($0)"
    let v20 : bool = Fable.Core.JsInterop.emitJsExpr v0 v19
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
and method27 () : (string -> string option) =
    closure56()
and closure57 () (v0 : string) : US9 =
    US9_0(v0)
and method28 () : (string -> US9) =
    closure57()
and method29 (v0 : string, v1 : bool, v2 : string, v3 : string) : string =
    let v4 : string option = None
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
    
#if FABLE_COMPILER || WASM || CONTRACT
    
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
    
#if FABLE_COMPILER_TYPESCRIPT
    let v30 : std_string_String = null |> unbox<std_string_String>
    v30
#endif
    
#if FABLE_COMPILER_PYTHON
    let v31 : std_string_String = null |> unbox<std_string_String>
    v31
#endif
    
#else
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
    
#if FABLE_COMPILER_TYPESCRIPT
    let v38 : string = "path"
    let v39 : IPathJoin = Fable.Core.JsInterop.importAll v38
    let v40 : string = method15(v3)
    let v41 : string = method16(v0)
    let v42 : string = "v39.join(v40, v41)"
    let v43 : string = Fable.Core.JsInterop.emitJsExpr () v42
    v43
#endif
    
#if FABLE_COMPILER_PYTHON
    let v44 : string = null |> unbox<string>
    v44
#endif
    
#else
    let v45 : string = System.IO.Path.Combine (v3, v0)
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
    
#if FABLE_COMPILER || WASM || CONTRACT
    
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
    
#if FABLE_COMPILER || WASM || CONTRACT
    
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
    
#if FABLE_COMPILER_TYPESCRIPT
    let v29 : std_string_String = null |> unbox<std_string_String>
    v29
#endif
    
#if FABLE_COMPILER_PYTHON
    let v30 : std_string_String = null |> unbox<std_string_String>
    v30
#endif
    
#else
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
    
#if FABLE_COMPILER_TYPESCRIPT
    let v37 : string = "path"
    let v38 : IPathJoin = Fable.Core.JsInterop.importAll v37
    let v39 : string = method15(v2)
    let v40 : string = method16(v0)
    let v41 : string = "v38.join(v39, v40)"
    let v42 : string = Fable.Core.JsInterop.emitJsExpr () v41
    v42
#endif
    
#if FABLE_COMPILER_PYTHON
    let v43 : string = null |> unbox<string>
    v43
#endif
    
#else
    let v44 : string = System.IO.Path.Combine (v2, v0)
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
    
#if FABLE_COMPILER || WASM || CONTRACT
    
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
    
#if FABLE_COMPILER_TYPESCRIPT
    let v7 : bool = null |> unbox<bool>
    v7
#endif
    
#if FABLE_COMPILER_PYTHON
    let v8 : bool = null |> unbox<bool>
    v8
#endif
    
#else
    let v9 : System.Runtime.InteropServices.OSPlatform = System.Runtime.InteropServices.OSPlatform.Windows
    let v10 : (System.Runtime.InteropServices.OSPlatform -> bool) = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform
    let v11 : bool = v10 v9
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
        
#if FABLE_COMPILER || WASM || CONTRACT
        
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
        
#if FABLE_COMPILER_TYPESCRIPT
        let v27 : string = null |> unbox<string>
        v27
#endif
        
#if FABLE_COMPILER_PYTHON
        let v28 : string = null |> unbox<string>
        v28
#endif
        
#else
        let v29 : string = "^\\\\\\\\\\?\\\\"
        let v30 : string = ""
        let v31 : string = System.Text.RegularExpressions.Regex.Replace (v0, v29, v30)
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
    
#if FABLE_COMPILER || WASM || CONTRACT
    
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
    
#if FABLE_COMPILER || WASM || CONTRACT
    
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
    
#if FABLE_COMPILER_TYPESCRIPT
    let v29 : std_string_String = null |> unbox<std_string_String>
    v29
#endif
    
#if FABLE_COMPILER_PYTHON
    let v30 : std_string_String = null |> unbox<std_string_String>
    v30
#endif
    
#else
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
    
#if FABLE_COMPILER_TYPESCRIPT
    let v37 : string = "path"
    let v38 : IPathJoin = Fable.Core.JsInterop.importAll v37
    let v39 : string = method15(v2)
    let v40 : string = method16(v0)
    let v41 : string = "v38.join(v39, v40)"
    let v42 : string = Fable.Core.JsInterop.emitJsExpr () v41
    v42
#endif
    
#if FABLE_COMPILER_PYTHON
    let v43 : string = null |> unbox<string>
    v43
#endif
    
#else
    let v44 : string = System.IO.Path.Combine (v2, v0)
    v44
#endif
    |> fun x -> _v3 <- Some x
    let v45 : string = _v3.Value
    let v46 : bool option = None
    let v47 : bool = true in let mutable _v46 = v46
    
#if FABLE_COMPILER || WASM || CONTRACT
    
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
    
#if FABLE_COMPILER_TYPESCRIPT
    let v62 : string = "fs"
    let v63 : IFsExistsSync = Fable.Core.JsInterop.importAll v62
    let v64 : string = "v63.existsSync($0)"
    let v65 : bool = Fable.Core.JsInterop.emitJsExpr v45 v64
    v65
#endif
    
#if FABLE_COMPILER_PYTHON
    let v66 : bool = null |> unbox<bool>
    v66
#endif
    
#else
    let v67 : (string -> bool) = System.IO.Directory.Exists
    let v68 : bool = v67 v45
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
    
#if FABLE_COMPILER || WASM || CONTRACT
    
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
    let v38 : string = method15(v1)
    let v39 : string = method16(v0)
    let v40 : string = "v37.join(v38, v39)"
    let v41 : string = Fable.Core.JsInterop.emitJsExpr () v40
    v41
#endif
    
#if FABLE_COMPILER_PYTHON
    let v42 : string = null |> unbox<string>
    v42
#endif
    
#else
    let v43 : string = System.IO.Path.Combine (v1, v0)
    v43
#endif
    |> fun x -> _v2 <- Some x
    let v44 : string = _v2.Value
    let v45 : bool option = None
    let v46 : bool = true in let mutable _v45 = v45
    
#if FABLE_COMPILER || WASM || CONTRACT
    
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
    
#if FABLE_COMPILER_TYPESCRIPT
    let v61 : string = "fs"
    let v62 : IFsExistsSync = Fable.Core.JsInterop.importAll v61
    let v63 : string = "v62.existsSync($0)"
    let v64 : bool = Fable.Core.JsInterop.emitJsExpr v44 v63
    v64
#endif
    
#if FABLE_COMPILER_PYTHON
    let v65 : bool = null |> unbox<bool>
    v65
#endif
    
#else
    let v66 : (string -> bool) = System.IO.Directory.Exists
    let v67 : bool = v66 v44
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
    
#if FABLE_COMPILER || WASM || CONTRACT
    
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
    
#if FABLE_COMPILER || WASM || CONTRACT
    
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
    
#if FABLE_COMPILER_TYPESCRIPT
    let v27 : std_string_String = null |> unbox<std_string_String>
    v27
#endif
    
#if FABLE_COMPILER_PYTHON
    let v28 : std_string_String = null |> unbox<std_string_String>
    v28
#endif
    
#else
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
    
#if FABLE_COMPILER_TYPESCRIPT
    let v35 : string = "path"
    let v36 : IPathJoin = Fable.Core.JsInterop.importAll v35
    let v37 : string = method35()
    let v38 : string = method36()
    let v39 : string = "v36.join(v37, v38)"
    let v40 : string = Fable.Core.JsInterop.emitJsExpr () v39
    v40
#endif
    
#if FABLE_COMPILER_PYTHON
    let v41 : string = null |> unbox<string>
    v41
#endif
    
#else
    let v42 : string = "polyglot"
    let v43 : string = ".paket"
    let v44 : string = System.IO.Path.Combine (v42, v43)
    v44
#endif
    |> fun x -> _v1 <- Some x
    let v45 : string = _v1.Value
    let v46 : string = method37(v45, v0)
    let v47 : string option = None
    let v48 : bool = true in let mutable _v47 = v47
    
#if FABLE_COMPILER || WASM || CONTRACT
    
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
    
#if FABLE_COMPILER || WASM || CONTRACT
    
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
    
#if FABLE_COMPILER_TYPESCRIPT
    let v73 : std_string_String = null |> unbox<std_string_String>
    v73
#endif
    
#if FABLE_COMPILER_PYTHON
    let v74 : std_string_String = null |> unbox<std_string_String>
    v74
#endif
    
#else
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
    
#if FABLE_COMPILER_TYPESCRIPT
    let v81 : IPathJoin = Fable.Core.JsInterop.importAll v35
    let v82 : string = method15(v46)
    let v83 : string = method39()
    let v84 : string = "v81.join(v82, v83)"
    let v85 : string = Fable.Core.JsInterop.emitJsExpr () v84
    v85
#endif
    
#if FABLE_COMPILER_PYTHON
    let v86 : string = null |> unbox<string>
    v86
#endif
    
#else
    let v87 : string = System.IO.Path.Combine (v46, v42)
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
    let v107 : string = method20()
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
    let v146 : string = method21()
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
    let v155 : string option = None
    let v156 : bool = true in let mutable _v155 = v155
    
#if FABLE_COMPILER || WASM || CONTRACT
    
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
    
#if FABLE_COMPILER || WASM || CONTRACT
    
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
    
#if FABLE_COMPILER_TYPESCRIPT
    let v181 : std_string_String = null |> unbox<std_string_String>
    v181
#endif
    
#if FABLE_COMPILER_PYTHON
    let v182 : std_string_String = null |> unbox<std_string_String>
    v182
#endif
    
#else
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
    
#if FABLE_COMPILER_TYPESCRIPT
    let v189 : string = "path"
    let v190 : IPathJoin = Fable.Core.JsInterop.importAll v189
    let v191 : string = method35()
    let v192 : string = method36()
    let v193 : string = "v190.join(v191, v192)"
    let v194 : string = Fable.Core.JsInterop.emitJsExpr () v193
    v194
#endif
    
#if FABLE_COMPILER_PYTHON
    let v195 : string = null |> unbox<string>
    v195
#endif
    
#else
    let v196 : string = "polyglot"
    let v197 : string = ".paket"
    let v198 : string = System.IO.Path.Combine (v196, v197)
    v198
#endif
    |> fun x -> _v155 <- Some x
    let v199 : string = _v155.Value
    let v200 : string = method37(v199, v154)
    let v201 : string option = None
    let v202 : bool = true in let mutable _v201 = v201
    
#if FABLE_COMPILER || WASM || CONTRACT
    
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
    
#if FABLE_COMPILER || WASM || CONTRACT
    
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
    
#if FABLE_COMPILER_TYPESCRIPT
    let v227 : std_string_String = null |> unbox<std_string_String>
    v227
#endif
    
#if FABLE_COMPILER_PYTHON
    let v228 : std_string_String = null |> unbox<std_string_String>
    v228
#endif
    
#else
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
    
#if FABLE_COMPILER_TYPESCRIPT
    let v235 : IPathJoin = Fable.Core.JsInterop.importAll v189
    let v236 : string = method15(v200)
    let v237 : string = method39()
    let v238 : string = "v235.join(v236, v237)"
    let v239 : string = Fable.Core.JsInterop.emitJsExpr () v238
    v239
#endif
    
#if FABLE_COMPILER_PYTHON
    let v240 : string = null |> unbox<string>
    v240
#endif
    
#else
    let v241 : string = System.IO.Path.Combine (v200, v196)
    v241
#endif
    |> fun x -> _v201 <- Some x
    let v242 : string = _v201.Value
    let v243 : string option = None
    let v244 : bool = true in let mutable _v243 = v243
    
#if FABLE_COMPILER || WASM || CONTRACT
    
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
    
#if FABLE_COMPILER || WASM || CONTRACT
    
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
    
#if FABLE_COMPILER_TYPESCRIPT
    let v269 : std_string_String = null |> unbox<std_string_String>
    v269
#endif
    
#if FABLE_COMPILER_PYTHON
    let v270 : std_string_String = null |> unbox<std_string_String>
    v270
#endif
    
#else
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
    
#if FABLE_COMPILER_TYPESCRIPT
    let v277 : IPathJoin = Fable.Core.JsInterop.importAll v189
    let v278 : string = method15(v242)
    let v279 : string = method42()
    let v280 : string = "v277.join(v278, v279)"
    let v281 : string = Fable.Core.JsInterop.emitJsExpr () v280
    v281
#endif
    
#if FABLE_COMPILER_PYTHON
    let v282 : string = null |> unbox<string>
    v282
#endif
    
#else
    let v283 : string = "target/polyglot/trace"
    let v284 : string = System.IO.Path.Combine (v242, v283)
    v284
#endif
    |> fun x -> _v243 <- Some x
    let v285 : string = _v243.Value
    let v286 : System.IO.DirectoryInfo option = None
    let v287 : bool = true in let mutable _v286 = v286
    
#if FABLE_COMPILER || WASM || CONTRACT
    
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
    
#if FABLE_COMPILER_TYPESCRIPT
    let v291 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    v291
#endif
    
#if FABLE_COMPILER_PYTHON
    let v292 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    v292
#endif
    
#else
    let v293 : (string -> System.IO.DirectoryInfo) = System.IO.Directory.CreateDirectory
    let v294 : System.IO.DirectoryInfo = v293 v285
    v294
#endif
    |> fun x -> _v286 <- Some x
    let v295 : System.IO.DirectoryInfo = _v286.Value
    let v296 : string option = None
    let v297 : bool = true in let mutable _v296 = v296
    
#if FABLE_COMPILER || WASM || CONTRACT
    
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
    
#if FABLE_COMPILER || WASM || CONTRACT
    
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
    
#if FABLE_COMPILER_TYPESCRIPT
    let v322 : std_string_String = null |> unbox<std_string_String>
    v322
#endif
    
#if FABLE_COMPILER_PYTHON
    let v323 : std_string_String = null |> unbox<std_string_String>
    v323
#endif
    
#else
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
    
#if FABLE_COMPILER_TYPESCRIPT
    let v330 : IPathJoin = Fable.Core.JsInterop.importAll v189
    let v331 : string = method15(v285)
    let v332 : string = method16(v153)
    let v333 : string = "v330.join(v331, v332)"
    let v334 : string = Fable.Core.JsInterop.emitJsExpr () v333
    v334
#endif
    
#if FABLE_COMPILER_PYTHON
    let v335 : string = null |> unbox<string>
    v335
#endif
    
#else
    let v336 : string = System.IO.Path.Combine (v285, v153)
    v336
#endif
    |> fun x -> _v296 <- Some x
    let v337 : string = _v296.Value
    let v338 : Async<unit> option = None
    let v339 : bool = true in let mutable _v338 = v338
    
#if FABLE_COMPILER || WASM || CONTRACT
    
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
    
#if FABLE_COMPILER_TYPESCRIPT
    let v343 : Async<unit> = null |> unbox<Async<unit>>
    v343
#endif
    
#if FABLE_COMPILER_PYTHON
    let v344 : Async<unit> = null |> unbox<Async<unit>>
    v344
#endif
    
#else
    let v345 : System.Threading.Tasks.Task = System.IO.File.WriteAllTextAsync (v337, v0)
    let v346 : Async<unit> option = None
    let v347 : bool = true in let mutable _v346 = v346
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v348 : Async<unit> = null |> unbox<Async<unit>>
    v348
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v349 : Async<unit> = null |> unbox<Async<unit>>
    v349
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v350 : Async<unit> = null |> unbox<Async<unit>>
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
    
#else
    let v353 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
    let v354 : Async<unit> = v353 v345
    v354
#endif
    |> fun x -> _v346 <- Some x
    let v355 : Async<unit> = _v346.Value
    v355
#endif
    |> fun x -> _v338 <- Some x
    let v356 : Async<unit> = _v338.Value
    let v357 : unit option = None
    let v358 : bool = true in let mutable _v357 = v357
    
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
    let v359 : (Async<unit> -> unit) = Async.RunSynchronously
    v359 v356
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
    let v38 : string = method15(v0)
    let v39 : string = method16(v1)
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
