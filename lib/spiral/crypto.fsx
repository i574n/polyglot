#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("core::any::Any")>]
#endif
type core_any_Any = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("_")>]
#endif
type core_ops_Try<'T> = class end
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
[<Fable.Core.Erase; Fable.Core.Emit("Send")>]
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
[<Fable.Core.Erase; Fable.Core.Emit("$0 + $1")>]
#endif
type LifetimeJoin<'T, 'U> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("'static")>]
#endif
type StaticLifetime = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("$0")>]
#endif
type LifetimeRef<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("$0 $1")>]
#endif
type Lifetime<'T, 'U> = class end
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
[<Fable.Core.Erase; Fable.Core.Emit("[$0]")>]
#endif
type Slice<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("_")>]
#endif
type Slice'<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("Vec<$0>")>]
#endif
type Vec<'T> = class end
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
[<Fable.Core.Erase; Fable.Core.Emit("encoding_rs::Encoding")>]
#endif
type encoding_rs_Encoding = class end
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
[<Fable.Core.Erase; Fable.Core.Emit("regex::Captures<$0>")>]
#endif
type regex_Captures<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("regex::CaptureMatches")>]
#endif
type regex_CaptureMatches = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("regex::CaptureNames")>]
#endif
type regex_CaptureNames = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("regex::Match")>]
#endif
type regex_Match = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("regex::Error")>]
#endif
type regex_Error = class end
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
[<Fable.Core.Erase; Fable.Core.Emit("std::sync::mpsc::Receiver<$0>")>]
#endif
type std_sync_mpsc_Receiver<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::sync::mpsc::SendError<$0>")>]
#endif
type std_sync_mpsc_SendError<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::sync::mpsc::Sender<$0>")>]
#endif
type std_sync_mpsc_Sender<'T> = class end
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
[<Fable.Core.Erase; Fable.Core.Emit("async_walkdir::Error")>]
#endif
type async_walkdir_Error = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("async_walkdir::Filtering")>]
#endif
type async_walkdir_Filtering = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("async_walkdir::WalkDir")>]
#endif
type async_walkdir_WalkDir = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::env::VarError")>]
#endif
type std_env_VarError = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("encoding_rs_io::DecodeReaderBytes<$0, $1>")>]
#endif
type encoding_rs_io_DecodeReaderBytes<'T, 'U> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::io::BufReader<$0>")>]
#endif
type std_io_BufReader<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::io::Cursor<$0>")>]
#endif
type std_io_Cursor<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::io::Error")>]
#endif
type std_io_Error = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::io::Lines<$0>")>]
#endif
type std_io_Lines<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("tokio::io::BufReader<$0>")>]
#endif
type tokio_io_BufReader<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("clap::Arg")>]
#endif
type clap_Arg = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("clap::ArgAction")>]
#endif
type clap_ArgAction = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("clap::Command")>]
#endif
type clap_Command = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("clap::ArgMatches")>]
#endif
type clap_ArgMatches = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("clap::builder::ValueRange")>]
#endif
type clap_builder_ValueRange = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("clap::builder::ValueParser")>]
#endif
type clap_builder_ValueParser = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("clap::builder::PossibleValue")>]
#endif
type clap_builder_PossibleValue = class end
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
[<Fable.Core.Erase; Fable.Core.Emit("std::process::ExitStatus")>]
#endif
type std_process_ExitStatus = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::process::Output")>]
#endif
type std_process_Output = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::process::Stdio")>]
#endif
type std_process_Stdio = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("futures::future::JoinAll<$0>")>]
#endif
type futures_future_JoinAll<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("futures::future::TryJoinAll<$0>")>]
#endif
type futures_future_TryJoinAll<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("rayon::iter::Map<$0, _>")>]
#endif
type rayon_iter_Map<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("rayon::vec::IntoIter<$0>")>]
#endif
type rayon_vec_IntoIter<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::future::Future<Output = $0>")>]
#endif
type std_future_Future<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("tokio::prelude::stream::Fuse<$0>")>]
#endif
type futures_future_Fuse<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("tokio::task::JoinHandle<$0>")>]
#endif
type tokio_task_JoinHandle<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("tokio_stream::StreamExt")>]
#endif
type tokio_stream_StreamExt = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("core::iter::Fuse<$0>")>]
#endif
type core_iter_Fuse<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("sha2::Sha256")>]
#endif
type sha2_Sha256 = class end
type ICryptoCreateHash = abstract createHash: x: string -> obj
type IHashlibSha256 = abstract sha256: x: unit -> obj
module State = let mutable trace_state = None
type IOsEnviron = abstract environ: x: unit -> obj
type Mut0 = {mutable l0 : int32}
and [<Struct>] US0 =
    | US0_0
    | US0_1
    | US0_2
    | US0_3
    | US0_4
and Mut1 = {mutable l0 : int64}
and Mut2 = {mutable l0 : (string -> unit)}
and Mut3 = {mutable l0 : bool}
and Mut4 = {mutable l0 : US0}
and [<Struct>] US1 =
    | US1_0 of f0_0 : US0
    | US1_1
and [<Struct>] US2 =
    | US2_0 of f0_0 : int64
    | US2_1
and [<Struct>] US3 =
    | US3_0 of f0_0 : string
    | US3_1
and Mut5 = {mutable l0 : string}
let rec method1 (v0 : int32, v1 : Mut0) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method2 () : string =
    let v0 : string = ""
    v0
and method0 (v0 : string) : string =
    let v1 : bool = true
    let mutable _v1 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : System.Text.Encoding = System.Text.Encoding.UTF8
    let v3 : (System.Text.Encoding -> (string -> (uint8 []))) = _.GetBytes
    let v4 : (string -> (uint8 [])) = v3 v2
    let v5 : (uint8 []) = v4 v0
    let v6 : string = "$0.to_vec()"
    let v7 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v5 v6 
    let v8 : string = "std::io::Cursor::new(v7)"
    let v9 : std_io_Cursor<Vec<uint8>> = Fable.Core.RustInterop.emitRustExpr () v8 
    let v10 : string = "std::io::BufReader::new(v9)"
    let v11 : std_io_BufReader<std_io_Cursor<Vec<uint8>>> = Fable.Core.RustInterop.emitRustExpr () v10 
    let v12 : string = "true; let mut v11 = v11"
    let v13 : bool = Fable.Core.RustInterop.emitRustExpr () v12 
    let v14 : string = "let result : sha2::Sha256 = sha2::Digest::new()"
    Fable.Core.RustInterop.emitRustExpr () v14 
    let v15 : string = "result"
    let v16 : sha2_Sha256 = Fable.Core.RustInterop.emitRustExpr () v15 
    let v17 : string = "true; let mut v16 = v16"
    let v18 : bool = Fable.Core.RustInterop.emitRustExpr () v17 
    let v19 : unativeint = 0 |> unativeint 
    let v20 : string = "[$0; 1024]"
    let v21 : Slice'<uint8> = Fable.Core.RustInterop.emitRustExpr 0uy v20 
    let v22 : string = "true; loop { // rust.loop"
    let v23 : bool = Fable.Core.RustInterop.emitRustExpr () v22 
    let v24 : string = "true; let mut v21 = v21"
    let v25 : bool = Fable.Core.RustInterop.emitRustExpr () v24 
    let v26 : string = "std::io::Read::read(&mut v11, &mut v21)"
    let v27 : Result<unativeint, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v26 
    let v28 : string = "$0.unwrap()"
    let v29 : unativeint = Fable.Core.RustInterop.emitRustExpr v27 v28 
    let v30 : bool = v29 = v19 
    if v30 then
        let v31 : string = "true; break"
        let v32 : bool = Fable.Core.RustInterop.emitRustExpr () v31 
        ()
    let v33 : string = "v21.len()"
    let v34 : unativeint = Fable.Core.RustInterop.emitRustExpr () v33 
    let v35 : uint8 = v34 |> uint8 
    let v36 : unativeint = v29 |> unativeint 
    let v37 : unativeint = v36 |> unbox<unativeint>
    let v38 : bool = v37 = v34 
    let v43 : Ref<Slice'<uint8>> =
        if v38 then
            let v39 : string = "&v21[v19..]"
            let v40 : Ref<Slice'<uint8>> = Fable.Core.RustInterop.emitRustExpr () v39 
            v40
        else
            let v41 : string = "&v21[$0..$1]"
            let v42 : Ref<Slice'<uint8>> = Fable.Core.RustInterop.emitRustExpr struct (v19, v36) v41 
            v42
    let v44 : string = "sha2::Digest::update(&mut v16, v43)"
    Fable.Core.RustInterop.emitRustExpr () v44 
    let v45 : string = "true; } // rust.loop"
    let v46 : bool = Fable.Core.RustInterop.emitRustExpr () v45 
    let v47 : string = "true; } // rust.loop"
    let v48 : bool = Fable.Core.RustInterop.emitRustExpr () v47 
    let v49 : string = "true; } // rust.loop"
    let v50 : bool = Fable.Core.RustInterop.emitRustExpr () v49 
    let v51 : string = "true; { // rust.loop"
    let v52 : bool = Fable.Core.RustInterop.emitRustExpr () v51 
    let v53 : string = "true; { // rust.loop"
    let v54 : bool = Fable.Core.RustInterop.emitRustExpr () v53 
    let v55 : string = "&sha2::Digest::finalize(v16)"
    let v56 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v55 
    let v57 : string = "$0.iter().map(|x| *x).collect::<Vec<_>>()"
    let v58 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v56 v57 
    let v59 : string = "true; let _result : Vec<_> = v58.into_iter().map(|x| { //"
    let v60 : bool = Fable.Core.RustInterop.emitRustExpr () v59 
    let v61 : string = "x"
    let v62 : uint8 = Fable.Core.RustInterop.emitRustExpr () v61 
    let v63 : string = "format!(\"{:02x}\", $0)"
    let v64 : std_string_String = Fable.Core.RustInterop.emitRustExpr v62 v63 
    let v65 : string = "fable_library_rust::String_::fromString($0)"
    let v66 : string = Fable.Core.RustInterop.emitRustExpr v64 v65 
    let v67 : string = "true; $0 }).collect::<Vec<_>>()"
    let v68 : bool = Fable.Core.RustInterop.emitRustExpr v66 v67 
    let v69 : string = "_result"
    let v70 : Vec<string> = Fable.Core.RustInterop.emitRustExpr () v69 
    let v71 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v72 : (string []) = Fable.Core.RustInterop.emitRustExpr v70 v71 
    let v73 : string seq = seq { for i = 0 to v72.Length - 1 do yield v72.[i] }
    let v74 : (string -> (string seq -> string)) = String.concat
    let v75 : string = ""
    let v76 : (string seq -> string) = v74 v75
    let v77 : string = v76 v73
    let v78 : Result<string, std_io_Error> = Ok v77 
    let v79 : string = "$0.unwrap()"
    let v80 : string = Fable.Core.RustInterop.emitRustExpr v78 v79 
    v80 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v81 : string = null |> unbox<string>
    v81 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v82 : string = null |> unbox<string>
    v82 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v83 : string = "crypto"
    let v84 : ICryptoCreateHash = Fable.Core.JsInterop.importAll v83 
    let v85 : string = "v84.createHash($0)"
    let v86 : string = "sha256"
    let v87 : obj = Fable.Core.JsInterop.emitJsExpr v86 v85 
    let v88 : string = "$0.update($1, 'utf8')"
    let v89 : obj = Fable.Core.JsInterop.emitJsExpr struct (v87, v0) v88 
    let v90 : string = "$0.digest($1)"
    let v91 : string = "hex"
    let v92 : string = Fable.Core.JsInterop.emitJsExpr struct (v89, v91) v90 
    v92 
    #endif
#if FABLE_COMPILER_PYTHON
    let v93 : string = "hashlib"
    let v94 : IHashlibSha256 = Fable.Core.PyInterop.importAll v93 
    let v95 : string = "v94.sha256()"
    let v96 : obj = Fable.Core.PyInterop.emitPyExpr () v95 
    let v97 : string = "$0.encode($1)"
    let v98 : string = "utf-8"
    let v99 : string = Fable.Core.PyInterop.emitPyExpr struct (v0, v98) v97 
    let v100 : string = "v96.update($0)"
    Fable.Core.PyInterop.emitPyExpr v99 v100 
    let v101 : string = "v96.hexdigest()"
    let v102 : string = Fable.Core.PyInterop.emitPyExpr () v101 
    v102 
    #endif
#else
    let v103 : (unit -> System.Security.Cryptography.SHA256) = System.Security.Cryptography.SHA256.Create
    let v104 : System.Security.Cryptography.SHA256 = v103 ()
    use v104 = v104 
    let v105 : System.Security.Cryptography.SHA256 = v104 
    let v106 : System.Text.Encoding = System.Text.Encoding.UTF8
    let v107 : (System.Text.Encoding -> (string -> (uint8 []))) = _.GetBytes
    let v108 : (string -> (uint8 [])) = v107 v106
    let v109 : (uint8 []) = v108 v0
    let v110 : ((uint8 []) -> (uint8 [])) = v105.ComputeHash
    let v111 : (uint8 []) = v110 v109
    let v112 : int32 = v111.Length
    let v113 : (string []) = Array.zeroCreate<string> (v112)
    let v114 : Mut0 = {l0 = 0} : Mut0
    while method1(v112, v114) do
        let v116 : int32 = v114.l0
        let v117 : uint8 = v111.[int v116]
        let v118 : (string -> string) = v117.ToString
        let v119 : string = "x2"
        let v120 : string = v118 v119
        v113.[int v116] <- v120
        let v121 : int32 = v116 + 1
        v114.l0 <- v121
        ()
    let v122 : string seq = seq { for i = 0 to v113.Length - 1 do yield v113.[i] }
    let v123 : string = method2()
    let v124 : (string -> (string seq -> string)) = String.concat
    let v125 : (string seq -> string) = v124 v123
    let v126 : string = v125 v122
    v126 
    #endif
    |> fun x -> _v1 <- Some x
    let v127 : string = match _v1 with Some x -> x | None -> failwith "base.run_target / _v1=None"
    v127
and closure0 () (v0 : string) : string =
    method0(v0)
and closure2 () () : string =
    let v0 : string = "crypto.hash_to_port"
    v0
and closure3 (v0 : int32, v1 : string, v2 : uint16) () : struct (int32 * string * uint16) =
    struct (v0, v1, v2)
and method4 () : string =
    let v0 : string = "TRACE_LEVEL"
    v0
and method6 () : string =
    let v0 : string = ""
    v0
and method5 (v0 : string) : string =
    let v1 : bool = true
    let mutable _v1 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = "std::env::var(&*$0)"
    let v3 : Result<std_string_String, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr v0 v2 
    let v4 : string = "true; let _result = $0.map(|x| { //"
    let v5 : bool = Fable.Core.RustInterop.emitRustExpr v3 v4 
    let v6 : string = "x"
    let v7 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v6 
    let v8 : string = "fable_library_rust::String_::fromString($0)"
    let v9 : string = Fable.Core.RustInterop.emitRustExpr v7 v8 
    let v10 : string = "true; $0 })"
    let v11 : bool = Fable.Core.RustInterop.emitRustExpr v9 v10 
    let v12 : string = "_result"
    let v13 : Result<string, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr () v12 
    let v14 : string = method6()
    let v15 : string = "$0.unwrap_or($1)"
    let v16 : string = Fable.Core.RustInterop.emitRustExpr struct (v13, v14) v15 
    v16 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v17 : string = "std::env::var(&*$0)"
    let v18 : Result<std_string_String, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr v0 v17 
    let v19 : string = "true; let _result = $0.map(|x| { //"
    let v20 : bool = Fable.Core.RustInterop.emitRustExpr v18 v19 
    let v21 : string = "x"
    let v22 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v21 
    let v23 : string = "fable_library_rust::String_::fromString($0)"
    let v24 : string = Fable.Core.RustInterop.emitRustExpr v22 v23 
    let v25 : string = "true; $0 })"
    let v26 : bool = Fable.Core.RustInterop.emitRustExpr v24 v25 
    let v27 : string = "_result"
    let v28 : Result<string, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr () v27 
    let v29 : string = method6()
    let v30 : string = "$0.unwrap_or($1)"
    let v31 : string = Fable.Core.RustInterop.emitRustExpr struct (v28, v29) v30 
    v31 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v32 : string = "std::env::var(&*$0)"
    let v33 : Result<std_string_String, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr v0 v32 
    let v34 : string = "true; let _result = $0.map(|x| { //"
    let v35 : bool = Fable.Core.RustInterop.emitRustExpr v33 v34 
    let v36 : string = "x"
    let v37 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v36 
    let v38 : string = "fable_library_rust::String_::fromString($0)"
    let v39 : string = Fable.Core.RustInterop.emitRustExpr v37 v38 
    let v40 : string = "true; $0 })"
    let v41 : bool = Fable.Core.RustInterop.emitRustExpr v39 v40 
    let v42 : string = "_result"
    let v43 : Result<string, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr () v42 
    let v44 : string = method6()
    let v45 : string = "$0.unwrap_or($1)"
    let v46 : string = Fable.Core.RustInterop.emitRustExpr struct (v43, v44) v45 
    v46 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v47 : string = "process.env[$0] ?? \"\""
    let v48 : string = Fable.Core.JsInterop.emitJsExpr v0 v47 
    v48 
    #endif
#if FABLE_COMPILER_PYTHON
    let v49 : string = "os"
    let v50 : IOsEnviron = Fable.Core.PyInterop.importAll v49 
    let v51 : string = "v50.environ"
    let v52 : obj = Fable.Core.PyInterop.emitPyExpr () v51 
    let v53 : string = "v52.get($0)"
    let v54 : string = Fable.Core.PyInterop.emitPyExpr v0 v53 
    let mutable _v54 = None
    #if !FABLE_COMPILER && !WASM && !CONTRACT
    let v55 : (string -> string option) = Option.ofObj
    let v56 : string option = v55 v54
    v56 
    #else
    Some v54 
    #endif
    |> fun x -> _v54 <- Some x
    let v57 : string option = match _v54 with Some x -> x | None -> failwith "optionm'.of_obj / _v54=None"
    let v58 : US3 option = None
    let _v58 = ref v58 
    match v57 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v59 : string = x
    let v60 : US3 = US3_0(v59)
    v60 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v58.Value <- x
    let v61 : US3 option = _v58.Value 
    let v62 : US3 = US3_1
    let v63 : US3 = v61 |> Option.defaultValue v62 
    let v67 : string =
        match v63 with
        | US3_1 -> (* None *)
            let v65 : string = ""
            v65
        | US3_0(v64) -> (* Some *)
            v64
    v67 
    #endif
#else
    let v68 : (string -> string) = System.Environment.GetEnvironmentVariable
    let v69 : string = v68 v0
    let mutable _v69 = None
    #if !FABLE_COMPILER && !WASM && !CONTRACT
    let v70 : (string -> string option) = Option.ofObj
    let v71 : string option = v70 v69
    v71 
    #else
    Some v69 
    #endif
    |> fun x -> _v69 <- Some x
    let v72 : string option = match _v69 with Some x -> x | None -> failwith "optionm'.of_obj / _v69=None"
    let v73 : US3 option = None
    let _v73 = ref v73 
    match v72 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v74 : string = x
    let v75 : US3 = US3_0(v74)
    v75 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v73.Value <- x
    let v76 : US3 option = _v73.Value 
    let v77 : US3 = US3_1
    let v78 : US3 = v76 |> Option.defaultValue v77 
    let v82 : string =
        match v78 with
        | US3_1 -> (* None *)
            let v80 : string = ""
            v80
        | US3_0(v79) -> (* Some *)
            v79
    v82 
    #endif
    |> fun x -> _v1 <- Some x
    let v83 : string = match _v1 with Some x -> x | None -> failwith "base.run_target / _v1=None"
    v83
and method7 () : string =
    let v0 : string = "AUTOMATION"
    v0
and closure6 () (v0 : string) : unit =
    ()
and closure5 () (v0 : US0) : struct (Mut1 * Mut2 * Mut3 * Mut4 * int64 option) =
    let v1 : bool = true
    let mutable _v1 : struct (US1 * US2) option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = method4()
    let v3 : string = method5(v2)
    let v5 : bool = "Verbose" = v3
    let v9 : US1 =
        if v5 then
            let v6 : US0 = US0_0
            US1_0(v6)
        else
            US1_1
    let v54 : US1 =
        match v9 with
        | US1_1 -> (* None *)
            let v13 : bool = "Debug" = v3
            let v17 : US1 =
                if v13 then
                    let v14 : US0 = US0_1
                    US1_0(v14)
                else
                    US1_1
            match v17 with
            | US1_1 -> (* None *)
                let v21 : bool = "Info" = v3
                let v25 : US1 =
                    if v21 then
                        let v22 : US0 = US0_2
                        US1_0(v22)
                    else
                        US1_1
                match v25 with
                | US1_1 -> (* None *)
                    let v29 : bool = "Warning" = v3
                    let v33 : US1 =
                        if v29 then
                            let v30 : US0 = US0_3
                            US1_0(v30)
                        else
                            US1_1
                    match v33 with
                    | US1_1 -> (* None *)
                        let v37 : bool = "Critical" = v3
                        let v41 : US1 =
                            if v37 then
                                let v38 : US0 = US0_4
                                US1_0(v38)
                            else
                                US1_1
                        match v41 with
                        | US1_1 -> (* None *)
                            US1_1
                        | US1_0(v42) -> (* Some *)
                            US1_0(v42)
                    | US1_0(v34) -> (* Some *)
                        US1_0(v34)
                | US1_0(v26) -> (* Some *)
                    US1_0(v26)
            | US1_0(v18) -> (* Some *)
                US1_0(v18)
        | US1_0(v10) -> (* Some *)
            US1_0(v10)
    let v55 : string = method7()
    let v56 : string = method5(v55)
    let v58 : bool = v56 = "True"
    let v64 : US2 =
        if v58 then
            let v59 : System.DateTime = System.DateTime.Now
            let v60 : (System.DateTime -> int64) = _.Ticks
            let v61 : int64 = v60 v59
            US2_0(v61)
        else
            US2_1
    struct (v54, v64) 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v65 : US1 = US1_1
    let v66 : US2 = US2_1
    struct (v65, v66) 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v67 : US1 = US1_1
    let v68 : US2 = US2_1
    struct (v67, v68) 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v69 : string = method4()
    let v70 : string = method5(v69)
    let v72 : bool = "Verbose" = v70
    let v76 : US1 =
        if v72 then
            let v73 : US0 = US0_0
            US1_0(v73)
        else
            US1_1
    let v121 : US1 =
        match v76 with
        | US1_1 -> (* None *)
            let v80 : bool = "Debug" = v70
            let v84 : US1 =
                if v80 then
                    let v81 : US0 = US0_1
                    US1_0(v81)
                else
                    US1_1
            match v84 with
            | US1_1 -> (* None *)
                let v88 : bool = "Info" = v70
                let v92 : US1 =
                    if v88 then
                        let v89 : US0 = US0_2
                        US1_0(v89)
                    else
                        US1_1
                match v92 with
                | US1_1 -> (* None *)
                    let v96 : bool = "Warning" = v70
                    let v100 : US1 =
                        if v96 then
                            let v97 : US0 = US0_3
                            US1_0(v97)
                        else
                            US1_1
                    match v100 with
                    | US1_1 -> (* None *)
                        let v104 : bool = "Critical" = v70
                        let v108 : US1 =
                            if v104 then
                                let v105 : US0 = US0_4
                                US1_0(v105)
                            else
                                US1_1
                        match v108 with
                        | US1_1 -> (* None *)
                            US1_1
                        | US1_0(v109) -> (* Some *)
                            US1_0(v109)
                    | US1_0(v101) -> (* Some *)
                        US1_0(v101)
                | US1_0(v93) -> (* Some *)
                    US1_0(v93)
            | US1_0(v85) -> (* Some *)
                US1_0(v85)
        | US1_0(v77) -> (* Some *)
            US1_0(v77)
    let v122 : string = method7()
    let v123 : string = method5(v122)
    let v125 : bool = v123 = "True"
    let v131 : US2 =
        if v125 then
            let v126 : System.DateTime = System.DateTime.Now
            let v127 : (System.DateTime -> int64) = _.Ticks
            let v128 : int64 = v127 v126
            US2_0(v128)
        else
            US2_1
    struct (v121, v131) 
    #endif
#if FABLE_COMPILER_PYTHON
    let v132 : string = method4()
    let v133 : string = method5(v132)
    let v135 : bool = "Verbose" = v133
    let v139 : US1 =
        if v135 then
            let v136 : US0 = US0_0
            US1_0(v136)
        else
            US1_1
    let v184 : US1 =
        match v139 with
        | US1_1 -> (* None *)
            let v143 : bool = "Debug" = v133
            let v147 : US1 =
                if v143 then
                    let v144 : US0 = US0_1
                    US1_0(v144)
                else
                    US1_1
            match v147 with
            | US1_1 -> (* None *)
                let v151 : bool = "Info" = v133
                let v155 : US1 =
                    if v151 then
                        let v152 : US0 = US0_2
                        US1_0(v152)
                    else
                        US1_1
                match v155 with
                | US1_1 -> (* None *)
                    let v159 : bool = "Warning" = v133
                    let v163 : US1 =
                        if v159 then
                            let v160 : US0 = US0_3
                            US1_0(v160)
                        else
                            US1_1
                    match v163 with
                    | US1_1 -> (* None *)
                        let v167 : bool = "Critical" = v133
                        let v171 : US1 =
                            if v167 then
                                let v168 : US0 = US0_4
                                US1_0(v168)
                            else
                                US1_1
                        match v171 with
                        | US1_1 -> (* None *)
                            US1_1
                        | US1_0(v172) -> (* Some *)
                            US1_0(v172)
                    | US1_0(v164) -> (* Some *)
                        US1_0(v164)
                | US1_0(v156) -> (* Some *)
                    US1_0(v156)
            | US1_0(v148) -> (* Some *)
                US1_0(v148)
        | US1_0(v140) -> (* Some *)
            US1_0(v140)
    let v185 : string = method7()
    let v186 : string = method5(v185)
    let v188 : bool = v186 = "True"
    let v194 : US2 =
        if v188 then
            let v189 : System.DateTime = System.DateTime.Now
            let v190 : (System.DateTime -> int64) = _.Ticks
            let v191 : int64 = v190 v189
            US2_0(v191)
        else
            US2_1
    struct (v184, v194) 
    #endif
#else
    let v195 : string = method4()
    let v196 : string = method5(v195)
    let v198 : bool = "Verbose" = v196
    let v202 : US1 =
        if v198 then
            let v199 : US0 = US0_0
            US1_0(v199)
        else
            US1_1
    let v247 : US1 =
        match v202 with
        | US1_1 -> (* None *)
            let v206 : bool = "Debug" = v196
            let v210 : US1 =
                if v206 then
                    let v207 : US0 = US0_1
                    US1_0(v207)
                else
                    US1_1
            match v210 with
            | US1_1 -> (* None *)
                let v214 : bool = "Info" = v196
                let v218 : US1 =
                    if v214 then
                        let v215 : US0 = US0_2
                        US1_0(v215)
                    else
                        US1_1
                match v218 with
                | US1_1 -> (* None *)
                    let v222 : bool = "Warning" = v196
                    let v226 : US1 =
                        if v222 then
                            let v223 : US0 = US0_3
                            US1_0(v223)
                        else
                            US1_1
                    match v226 with
                    | US1_1 -> (* None *)
                        let v230 : bool = "Critical" = v196
                        let v234 : US1 =
                            if v230 then
                                let v231 : US0 = US0_4
                                US1_0(v231)
                            else
                                US1_1
                        match v234 with
                        | US1_1 -> (* None *)
                            US1_1
                        | US1_0(v235) -> (* Some *)
                            US1_0(v235)
                    | US1_0(v227) -> (* Some *)
                        US1_0(v227)
                | US1_0(v219) -> (* Some *)
                    US1_0(v219)
            | US1_0(v211) -> (* Some *)
                US1_0(v211)
        | US1_0(v203) -> (* Some *)
            US1_0(v203)
    let v248 : string = method7()
    let v249 : string = method5(v248)
    let v251 : bool = v249 = "True"
    let v257 : US2 =
        if v251 then
            let v252 : System.DateTime = System.DateTime.Now
            let v253 : (System.DateTime -> int64) = _.Ticks
            let v254 : int64 = v253 v252
            US2_0(v254)
        else
            US2_1
    struct (v247, v257) 
    #endif
    |> fun x -> _v1 <- Some x
    let struct (v258 : US1, v259 : US2) = match _v1 with Some x -> x | None -> failwith "base.run_target / _v1=None"
    let v260 : Mut3 = {l0 = true} : Mut3
    let v261 : Mut1 = {l0 = 0L} : Mut1
    let v264 : US0 =
        match v258 with
        | US1_1 -> (* None *)
            v0
        | US1_0(v262) -> (* Some *)
            v262
    let v265 : Mut4 = {l0 = v264} : Mut4
    let v266 : (string -> unit) = closure6()
    let v267 : Mut2 = {l0 = v266} : Mut2
    let v272 : int64 option =
        match v259 with
        | US2_1 -> (* None *)
            let v270 : int64 option = None
            v270
        | US2_0(v268) -> (* Some *)
            let v269 : int64 option = Some v268 
            v269
    struct (v261, v267, v260, v265, v272)
and method8 () : string =
    let v0 : string = "hh:mm:ss"
    v0
and method9 () : string =
    let v0 : string = ""
    v0
and method10 () : string =
    let v0 : string = "HH:mm:ss"
    v0
and method11 () : string =
    let v0 : string = "\u001b[0m"
    v0
and method13 (v0 : Mut5, v1 : string) : unit =
    let v2 : string = $"{v1}"
    let v3 : string = v0.l0
    let v4 : string = v3 + v2 
    v0.l0 <- v4
    ()
and method14 (v0 : Mut5) : unit =
    ()
and method15 (v0 : Mut5, v1 : int32) : unit =
    let v2 : string = $"{v1}"
    let v3 : string = v0.l0
    let v4 : string = v3 + v2 
    v0.l0 <- v4
    ()
and method16 (v0 : Mut5, v1 : uint16) : unit =
    let v2 : string = $"{v1}"
    let v3 : string = v0.l0
    let v4 : string = v3 + v2 
    v0.l0 <- v4
    ()
and method12 (v0 : Mut5, v1 : int32, v2 : string, v3 : uint16) : unit =
    let v4 : string = "{ "
    method13(v0, v4)
    method14(v0)
    let v5 : string = "first_letter_code"
    method13(v0, v5)
    let v6 : string = " = "
    method13(v0, v6)
    method15(v0, v1)
    let v7 : string = "; "
    method13(v0, v7)
    let v8 : string = "hash_part"
    method13(v0, v8)
    method13(v0, v6)
    method13(v0, v2)
    method13(v0, v7)
    let v9 : string = "combined_value"
    method13(v0, v9)
    method13(v0, v6)
    method16(v0, v3)
    let v10 : string = " }"
    method13(v0, v10)
and closure4 (v0 : US0, v1 : (unit -> string), v2 : (unit -> struct (int32 * string * uint16))) () : string =
    let v3 : (US0 -> struct (Mut1 * Mut2 * Mut3 * Mut4 * int64 option)) = closure5()
    let v4 : US0 = US0_0
    if State.trace_state.IsNone then State.trace_state <- v3 v4 |> Some
    let struct (v5 : Mut1, v6 : Mut2, v7 : Mut3, v8 : Mut4, v9 : int64 option) = State.trace_state.Value
    let v10 : bool = true
    let mutable _v10 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v11 : US2 option = None
    let _v11 = ref v11 
    match v9 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v12 : int64 = x
    let v13 : US2 = US2_0(v12)
    v13 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v11.Value <- x
    let v14 : US2 option = _v11.Value 
    let v15 : US2 = US2_1
    let v16 : US2 = v14 |> Option.defaultValue v15 
    let v35 : System.DateTime =
        match v16 with
        | US2_1 -> (* None *)
            let v33 : System.DateTime = System.DateTime.Now
            v33
        | US2_0(v17) -> (* Some *)
            let v18 : System.DateTime = System.DateTime.Now
            let v19 : (System.DateTime -> int64) = _.Ticks
            let v20 : int64 = v19 v18
            let v21 : int64 = v20 - v17
            let v22 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v23 : System.TimeSpan = v22 v21
            let v24 : (System.TimeSpan -> int32) = _.Hours
            let v25 : int32 = v24 v23
            let v26 : (System.TimeSpan -> int32) = _.Minutes
            let v27 : int32 = v26 v23
            let v28 : (System.TimeSpan -> int32) = _.Seconds
            let v29 : int32 = v28 v23
            let v30 : (System.TimeSpan -> int32) = _.Milliseconds
            let v31 : int32 = v30 v23
            let v32 : System.DateTime = System.DateTime (1, 1, 1, v25, v27, v29, v31)
            v32
    let v36 : string = method8()
    let v37 : (string -> string) = v35.ToString
    let v38 : string = v37 v36
    v38 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v39 : US2 option = None
    let _v39 = ref v39 
    match v9 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v40 : int64 = x
    let v41 : US2 = US2_0(v40)
    v41 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v39.Value <- x
    let v42 : US2 option = _v39.Value 
    let v43 : US2 = US2_1
    let v44 : US2 = v42 |> Option.defaultValue v43 
    let v63 : System.DateTime =
        match v44 with
        | US2_1 -> (* None *)
            let v61 : System.DateTime = System.DateTime.Now
            v61
        | US2_0(v45) -> (* Some *)
            let v46 : System.DateTime = System.DateTime.Now
            let v47 : (System.DateTime -> int64) = _.Ticks
            let v48 : int64 = v47 v46
            let v49 : int64 = v48 - v45
            let v50 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v51 : System.TimeSpan = v50 v49
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
    let v64 : string = method8()
    let v65 : (string -> string) = v63.ToString
    let v66 : string = v65 v64
    v66 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v67 : string = method9()
    v67 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v68 : US2 option = None
    let _v68 = ref v68 
    match v9 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v69 : int64 = x
    let v70 : US2 = US2_0(v69)
    v70 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v68.Value <- x
    let v71 : US2 option = _v68.Value 
    let v72 : US2 = US2_1
    let v73 : US2 = v71 |> Option.defaultValue v72 
    let v92 : System.DateTime =
        match v73 with
        | US2_1 -> (* None *)
            let v90 : System.DateTime = System.DateTime.Now
            v90
        | US2_0(v74) -> (* Some *)
            let v75 : System.DateTime = System.DateTime.Now
            let v76 : (System.DateTime -> int64) = _.Ticks
            let v77 : int64 = v76 v75
            let v78 : int64 = v77 - v74
            let v79 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v80 : System.TimeSpan = v79 v78
            let v81 : (System.TimeSpan -> int32) = _.Hours
            let v82 : int32 = v81 v80
            let v83 : (System.TimeSpan -> int32) = _.Minutes
            let v84 : int32 = v83 v80
            let v85 : (System.TimeSpan -> int32) = _.Seconds
            let v86 : int32 = v85 v80
            let v87 : (System.TimeSpan -> int32) = _.Milliseconds
            let v88 : int32 = v87 v80
            let v89 : System.DateTime = System.DateTime (1, 1, 1, v82, v84, v86, v88)
            v89
    let v93 : string = method10()
    let v94 : (string -> string) = v92.ToString
    let v95 : string = v94 v93
    v95 
    #endif
#if FABLE_COMPILER_PYTHON
    let v96 : US2 option = None
    let _v96 = ref v96 
    match v9 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v97 : int64 = x
    let v98 : US2 = US2_0(v97)
    v98 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v96.Value <- x
    let v99 : US2 option = _v96.Value 
    let v100 : US2 = US2_1
    let v101 : US2 = v99 |> Option.defaultValue v100 
    let v120 : System.DateTime =
        match v101 with
        | US2_1 -> (* None *)
            let v118 : System.DateTime = System.DateTime.Now
            v118
        | US2_0(v102) -> (* Some *)
            let v103 : System.DateTime = System.DateTime.Now
            let v104 : (System.DateTime -> int64) = _.Ticks
            let v105 : int64 = v104 v103
            let v106 : int64 = v105 - v102
            let v107 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v108 : System.TimeSpan = v107 v106
            let v109 : (System.TimeSpan -> int32) = _.Hours
            let v110 : int32 = v109 v108
            let v111 : (System.TimeSpan -> int32) = _.Minutes
            let v112 : int32 = v111 v108
            let v113 : (System.TimeSpan -> int32) = _.Seconds
            let v114 : int32 = v113 v108
            let v115 : (System.TimeSpan -> int32) = _.Milliseconds
            let v116 : int32 = v115 v108
            let v117 : System.DateTime = System.DateTime (1, 1, 1, v110, v112, v114, v116)
            v117
    let v121 : string = method10()
    let v122 : (string -> string) = v120.ToString
    let v123 : string = v122 v121
    v123 
    #endif
#else
    let v124 : US2 option = None
    let _v124 = ref v124 
    match v9 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v125 : int64 = x
    let v126 : US2 = US2_0(v125)
    v126 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v124.Value <- x
    let v127 : US2 option = _v124.Value 
    let v128 : US2 = US2_1
    let v129 : US2 = v127 |> Option.defaultValue v128 
    let v148 : System.DateTime =
        match v129 with
        | US2_1 -> (* None *)
            let v146 : System.DateTime = System.DateTime.Now
            v146
        | US2_0(v130) -> (* Some *)
            let v131 : System.DateTime = System.DateTime.Now
            let v132 : (System.DateTime -> int64) = _.Ticks
            let v133 : int64 = v132 v131
            let v134 : int64 = v133 - v130
            let v135 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v136 : System.TimeSpan = v135 v134
            let v137 : (System.TimeSpan -> int32) = _.Hours
            let v138 : int32 = v137 v136
            let v139 : (System.TimeSpan -> int32) = _.Minutes
            let v140 : int32 = v139 v136
            let v141 : (System.TimeSpan -> int32) = _.Seconds
            let v142 : int32 = v141 v136
            let v143 : (System.TimeSpan -> int32) = _.Milliseconds
            let v144 : int32 = v143 v136
            let v145 : System.DateTime = System.DateTime (1, 1, 1, v138, v140, v142, v144)
            v145
    let v149 : string = method10()
    let v150 : (string -> string) = v148.ToString
    let v151 : string = v150 v149
    v151 
    #endif
    |> fun x -> _v10 <- Some x
    let v152 : string = match _v10 with Some x -> x | None -> failwith "base.run_target / _v10=None"
    let v155 : bool =
        match v0 with
        | US0_0 -> (* Verbose *)
            true
        | _ ->
            false
    let v159 : US3 =
        if v155 then
            let v156 : string = "Verbose"
            US3_0(v156)
        else
            US3_1
    let v208 : US3 =
        match v159 with
        | US3_1 -> (* None *)
            let v164 : bool =
                match v0 with
                | US0_1 -> (* Debug *)
                    true
                | _ ->
                    false
            let v168 : US3 =
                if v164 then
                    let v165 : string = "Debug"
                    US3_0(v165)
                else
                    US3_1
            match v168 with
            | US3_1 -> (* None *)
                let v173 : bool =
                    match v0 with
                    | US0_2 -> (* Info *)
                        true
                    | _ ->
                        false
                let v177 : US3 =
                    if v173 then
                        let v174 : string = "Info"
                        US3_0(v174)
                    else
                        US3_1
                match v177 with
                | US3_1 -> (* None *)
                    let v182 : bool =
                        match v0 with
                        | US0_3 -> (* Warning *)
                            true
                        | _ ->
                            false
                    let v186 : US3 =
                        if v182 then
                            let v183 : string = "Warning"
                            US3_0(v183)
                        else
                            US3_1
                    match v186 with
                    | US3_1 -> (* None *)
                        let v191 : bool =
                            match v0 with
                            | US0_4 -> (* Critical *)
                                true
                            | _ ->
                                false
                        let v195 : US3 =
                            if v191 then
                                let v192 : string = "Critical"
                                US3_0(v192)
                            else
                                US3_1
                        match v195 with
                        | US3_1 -> (* None *)
                            US3_1
                        | US3_0(v196) -> (* Some *)
                            US3_0(v196)
                    | US3_0(v187) -> (* Some *)
                        US3_0(v187)
                | US3_0(v178) -> (* Some *)
                    US3_0(v178)
            | US3_0(v169) -> (* Some *)
                US3_0(v169)
        | US3_0(v160) -> (* Some *)
            US3_0(v160)
    let v212 : string =
        match v208 with
        | US3_1 -> (* None *)
            failwith<string> "Option does not have a value."
        | US3_0(v209) -> (* Some *)
            v209
    let v213 : (unit -> string) = v212.ToLower
    let v214 : string = v213 ()
    let v215 : string = v214.PadLeft (7, ' ')
    let v216 : bool = true
    let mutable _v216 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v231 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v225 : string = "inline_colorization::color_bright_red"
            let v226 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v225 
            v226
        | US0_1 -> (* Debug *)
            let v219 : string = "inline_colorization::color_bright_blue"
            let v220 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v219 
            v220
        | US0_2 -> (* Info *)
            let v221 : string = "inline_colorization::color_bright_green"
            let v222 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v221 
            v222
        | US0_0 -> (* Verbose *)
            let v217 : string = "inline_colorization::color_bright_black"
            let v218 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v217 
            v218
        | US0_3 -> (* Warning *)
            let v223 : string = "inline_colorization::color_yellow"
            let v224 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v223 
            v224
    let v232 : string = "&*$0"
    let v233 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v215 v232 
    let v234 : string = "inline_colorization::color_reset"
    let v235 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v234 
    let v236 : string = "\"{v231}{v233}{v235}\""
    let v237 : string = @$"format!(" + v236 + ")"
    let v238 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v237 
    let v239 : string = "fable_library_rust::String_::fromString($0)"
    let v240 : string = Fable.Core.RustInterop.emitRustExpr v238 v239 
    v240 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v255 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v249 : string = "inline_colorization::color_bright_red"
            let v250 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v249 
            v250
        | US0_1 -> (* Debug *)
            let v243 : string = "inline_colorization::color_bright_blue"
            let v244 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v243 
            v244
        | US0_2 -> (* Info *)
            let v245 : string = "inline_colorization::color_bright_green"
            let v246 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v245 
            v246
        | US0_0 -> (* Verbose *)
            let v241 : string = "inline_colorization::color_bright_black"
            let v242 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v241 
            v242
        | US0_3 -> (* Warning *)
            let v247 : string = "inline_colorization::color_yellow"
            let v248 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v247 
            v248
    let v256 : string = "&*$0"
    let v257 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v215 v256 
    let v258 : string = "inline_colorization::color_reset"
    let v259 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v258 
    let v260 : string = "\"{v255}{v257}{v259}\""
    let v261 : string = @$"format!(" + v260 + ")"
    let v262 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v261 
    let v263 : string = "fable_library_rust::String_::fromString($0)"
    let v264 : string = Fable.Core.RustInterop.emitRustExpr v262 v263 
    v264 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v279 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v273 : string = "inline_colorization::color_bright_red"
            let v274 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v273 
            v274
        | US0_1 -> (* Debug *)
            let v267 : string = "inline_colorization::color_bright_blue"
            let v268 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v267 
            v268
        | US0_2 -> (* Info *)
            let v269 : string = "inline_colorization::color_bright_green"
            let v270 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v269 
            v270
        | US0_0 -> (* Verbose *)
            let v265 : string = "inline_colorization::color_bright_black"
            let v266 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v265 
            v266
        | US0_3 -> (* Warning *)
            let v271 : string = "inline_colorization::color_yellow"
            let v272 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v271 
            v272
    let v280 : string = "&*$0"
    let v281 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v215 v280 
    let v282 : string = "inline_colorization::color_reset"
    let v283 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v282 
    let v284 : string = "\"{v279}{v281}{v283}\""
    let v285 : string = @$"format!(" + v284 + ")"
    let v286 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v285 
    let v287 : string = "fable_library_rust::String_::fromString($0)"
    let v288 : string = Fable.Core.RustInterop.emitRustExpr v286 v287 
    v288 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v298 : string =
        match v0 with
        | US0_4 -> (* Critical *)
            let v293 : string = "\u001b[91m"
            v293
        | US0_1 -> (* Debug *)
            let v290 : string = "\u001b[94m"
            v290
        | US0_2 -> (* Info *)
            let v291 : string = "\u001b[92m"
            v291
        | US0_0 -> (* Verbose *)
            let v289 : string = "\u001b[90m"
            v289
        | US0_3 -> (* Warning *)
            let v292 : string = "\u001b[93m"
            v292
    let v299 : string = method11()
    let v300 : string = v298 + v215 
    let v301 : string = v300 + v299 
    v301 
    #endif
#if FABLE_COMPILER_PYTHON
    let v311 : string =
        match v0 with
        | US0_4 -> (* Critical *)
            let v306 : string = "\u001b[91m"
            v306
        | US0_1 -> (* Debug *)
            let v303 : string = "\u001b[94m"
            v303
        | US0_2 -> (* Info *)
            let v304 : string = "\u001b[92m"
            v304
        | US0_0 -> (* Verbose *)
            let v302 : string = "\u001b[90m"
            v302
        | US0_3 -> (* Warning *)
            let v305 : string = "\u001b[93m"
            v305
    let v312 : string = method11()
    let v313 : string = v311 + v215 
    let v314 : string = v313 + v312 
    v314 
    #endif
#else
    let v324 : string =
        match v0 with
        | US0_4 -> (* Critical *)
            let v319 : string = "\u001b[91m"
            v319
        | US0_1 -> (* Debug *)
            let v316 : string = "\u001b[94m"
            v316
        | US0_2 -> (* Info *)
            let v317 : string = "\u001b[92m"
            v317
        | US0_0 -> (* Verbose *)
            let v315 : string = "\u001b[90m"
            v315
        | US0_3 -> (* Warning *)
            let v318 : string = "\u001b[93m"
            v318
    let v325 : string = method11()
    let v326 : string = v324 + v215 
    let v327 : string = v326 + v325 
    v327 
    #endif
    |> fun x -> _v216 <- Some x
    let v328 : string = match _v216 with Some x -> x | None -> failwith "base.run_target / _v216=None"
    let v329 : int64 = v5.l0
    let struct (v330 : int32, v331 : string, v332 : uint16) = v2 ()
    let v333 : string = ""
    let v334 : Mut5 = {l0 = v333} : Mut5
    method12(v334, v330, v331, v332)
    let v335 : string = v334.l0
    let v336 : string = $"{v152} {v328} #{v329} %s{v1 ()} / {v335}"
    let v337 : char list = []
    let v338 : (char list -> (char [])) = List.toArray
    let v339 : (char []) = v338 v337
    let v340 : string = v336.TrimStart v339 
    let v341 : char list = []
    let v342 : char list = '/' :: v341 
    let v343 : char list = ' ' :: v342 
    let v344 : (char list -> (char [])) = List.toArray
    let v345 : (char []) = v344 v343
    let v346 : string = v340.TrimEnd v345 
    v346
and method17 (v0 : US0, v1 : (unit -> string)) : unit =
    let v2 : (US0 -> struct (Mut1 * Mut2 * Mut3 * Mut4 * int64 option)) = closure5()
    let v3 : US0 = US0_0
    if State.trace_state.IsNone then State.trace_state <- v2 v3 |> Some
    let struct (v4 : Mut1, v5 : Mut2, v6 : Mut3, v7 : Mut4, v8 : int64 option) = State.trace_state.Value
    let v9 : US0 = US0_0
    if State.trace_state.IsNone then State.trace_state <- v2 v9 |> Some
    let struct (v10 : Mut1, v11 : Mut2, v12 : Mut3, v13 : Mut4, v14 : int64 option) = State.trace_state.Value
    let v15 : US0 = v13.l0
    let v16 : bool = v12.l0
    let v17 : bool = v16 = false
    let v21 : bool =
        if v17 then
            false
        else
            let v18 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v0
            let v19 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v15
            let v20 : bool = v18 >= v19
            v20
    if v21 then
        let v22 : int64 = v4.l0
        let v23 : int64 = v22 + 1L
        v4.l0 <- v23
        let v24 : string = $"%s{v1 ()}"
        let v25 : bool = true
        let mutable _v25 : unit option = None 
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v26 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v24 v26 
        () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v27 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v24 v27 
        () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v28 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v24 v28 
        () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        System.Console.WriteLine v24 
        () 
        #endif
#if FABLE_COMPILER_PYTHON
        System.Console.WriteLine v24 
        () 
        #endif
#else
        System.Console.WriteLine v24 
        () 
        #endif
        |> fun x -> _v25 <- Some x
        match _v25 with Some x -> x | None -> failwith "base.run_target / _v25=None"
        let v29 : (string -> unit) = v5.l0
        v29 v24
and method3 (v0 : US0, v1 : (unit -> string), v2 : (unit -> struct (int32 * string * uint16))) : unit =
    let v3 : (unit -> string) = closure4(v0, v1, v2)
    method17(v0, v3)
and closure1 () (v0 : string) : uint16 =
    let v1 : char = v0.[int 0]
    let v2 : (char -> int32) = int32
    let v3 : int32 = v2 v1
    let v4 : string = v0.[int 0..int 7]
    let v5 : int32 = System.Convert.ToInt32 (v4, 16)
    let v6 : int32 = v5 + v3
    let v7 : (int32 -> uint16) = uint16
    let v8 : uint16 = v7 v6
    let v9 : US0 = US0_0
    let v10 : (unit -> string) = closure2()
    let v11 : (unit -> struct (int32 * string * uint16)) = closure3(v3, v4, v8)
    method3(v9, v10, v11)
    let v12 : uint16 = v8 % 48128us
    let v13 : uint16 = v12 + 1024us
    v13
let v0 : (string -> string) = closure0()
let hash_text x = v0 x
let v1 : (string -> uint16) = closure1()
let hash_to_port x = v1 x
()
