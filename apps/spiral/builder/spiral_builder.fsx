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
module State = let mutable trace_state = None
type IPathJoin = abstract join: [<System.ParamArray>] paths: string[] -> string
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
    | US3_0 of f0_0 : std_string_String
    | US3_1
and [<Struct>] US4 =
    | US4_0 of f0_0 : string
    | US4_1
and Mut4 = {mutable l0 : int32; mutable l1 : int32; mutable l2 : (string [])}
and Mut5 = {mutable l0 : int32}
and UH0 =
    | UH0_0
    | UH0_1 of string * UH0
and UH1 =
    | UH1_0
    | UH1_1 of char * UH1
and [<Struct>] US5 =
    | US5_0
    | US5_1 of f1_0 : char
    | US5_2 of f2_0 : uint8
and [<Struct>] US6 =
    | US6_0 of f0_0 : std_string_String * f0_1 : clap_ArgMatches
    | US6_1
let rec method1 (v0 : string) : string =
    v0
and method2 (v0 : std_string_String) : std_string_String =
    v0
and closure1 () (v0 : string) : clap_builder_PossibleValue =
    let v1 : string = method1(v0)
    let v2 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v3 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1 v2
    let v4 : string = "String::from($0)"
    let v5 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3 v4
    let v6 : std_string_String = method2(v5)
    let v7 : string = "Box::new(v6)"
    let v8 : Box<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v7
    let v9 : string = "Box::leak(v8)"
    let v10 : StaticRef<Mut<std_string_String>> = Fable.Core.RustInterop.emitRustExpr () v9
    let v11 : string = "clap::builder::PossibleValue::new(&**$0)"
    let v12 : clap_builder_PossibleValue = Fable.Core.RustInterop.emitRustExpr v10 v11
    v12
and method0 () : clap_Command =
    let v0 : string = "command"
    let v1 : string = "r#\"" + v0 + "\"#"
    let v2 : StaticRef<Str> = Fable.Core.RustInterop.emitRustExpr () v1
    let v3 : string = "clap::Command::new($0)"
    let v4 : clap_Command = Fable.Core.RustInterop.emitRustExpr v2 v3
    let v5 : string = "file"
    let v6 : string = "r#\"" + v5 + "\"#"
    let v7 : StaticRef<Str> = Fable.Core.RustInterop.emitRustExpr () v6
    let v8 : string = "clap::Arg::new($0)"
    let v9 : clap_Arg = Fable.Core.RustInterop.emitRustExpr v7 v8
    let v10 : string = "$0.short($1)"
    let v11 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v9, 'f') v10
    let v12 : string = "r#\"" + v5 + "\"#"
    let v13 : StaticRef<Str> = Fable.Core.RustInterop.emitRustExpr () v12
    let v14 : string = "$0.long($1)"
    let v15 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v11, v13) v14
    let v16 : string = "$0.required($1)"
    let v17 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v15, true) v16
    let v18 : string = "clap::Command::arg($0, $1)"
    let v19 : clap_Command = Fable.Core.RustInterop.emitRustExpr struct (v4, v17) v18
    let v20 : string = "out-dir"
    let v21 : string = "r#\"" + v20 + "\"#"
    let v22 : StaticRef<Str> = Fable.Core.RustInterop.emitRustExpr () v21
    let v23 : string = "clap::Arg::new($0)"
    let v24 : clap_Arg = Fable.Core.RustInterop.emitRustExpr v22 v23
    let v25 : string = "$0.short($1)"
    let v26 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v24, 'o') v25
    let v27 : string = "r#\"" + v20 + "\"#"
    let v28 : StaticRef<Str> = Fable.Core.RustInterop.emitRustExpr () v27
    let v29 : string = "$0.long($1)"
    let v30 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v26, v28) v29
    let v31 : string = "$0.required($1)"
    let v32 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v30, true) v31
    let v33 : string = "clap::Command::arg($0, $1)"
    let v34 : clap_Command = Fable.Core.RustInterop.emitRustExpr struct (v19, v32) v33
    let v35 : string = "hash"
    let v36 : string = "r#\"" + v35 + "\"#"
    let v37 : StaticRef<Str> = Fable.Core.RustInterop.emitRustExpr () v36
    let v38 : string = "clap::Arg::new($0)"
    let v39 : clap_Arg = Fable.Core.RustInterop.emitRustExpr v37 v38
    let v40 : string = "$0.short($1)"
    let v41 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v39, 'h') v40
    let v42 : string = "r#\"" + v35 + "\"#"
    let v43 : StaticRef<Str> = Fable.Core.RustInterop.emitRustExpr () v42
    let v44 : string = "$0.long($1)"
    let v45 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v41, v43) v44
    let v46 : string = "$0.required($1)"
    let v47 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v45, true) v46
    let v48 : string = "clap::Command::arg($0, $1)"
    let v49 : clap_Command = Fable.Core.RustInterop.emitRustExpr struct (v34, v47) v48
    let v50 : string = "args"
    let v51 : string = "r#\"" + v50 + "\"#"
    let v52 : StaticRef<Str> = Fable.Core.RustInterop.emitRustExpr () v51
    let v53 : string = "clap::Arg::new($0)"
    let v54 : clap_Arg = Fable.Core.RustInterop.emitRustExpr v52 v53
    let v55 : string = "$0.short($1)"
    let v56 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v54, 'a') v55
    let v57 : string = "r#\"" + v50 + "\"#"
    let v58 : StaticRef<Str> = Fable.Core.RustInterop.emitRustExpr () v57
    let v59 : string = "$0.long($1)"
    let v60 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v56, v58) v59
    let v61 : string = "clap::Command::arg($0, $1)"
    let v62 : clap_Command = Fable.Core.RustInterop.emitRustExpr struct (v49, v60) v61
    let v63 : string = "trace-level"
    let v64 : string = "r#\"" + v63 + "\"#"
    let v65 : StaticRef<Str> = Fable.Core.RustInterop.emitRustExpr () v64
    let v66 : string = "clap::Arg::new($0)"
    let v67 : clap_Arg = Fable.Core.RustInterop.emitRustExpr v65 v66
    let v68 : string = "$0.short($1)"
    let v69 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v67, 't') v68
    let v70 : string = "r#\"" + v63 + "\"#"
    let v71 : StaticRef<Str> = Fable.Core.RustInterop.emitRustExpr () v70
    let v72 : string = "$0.long($1)"
    let v73 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v69, v71) v72
    let v74 : string list = []
    let v75 : string = "Critical"
    let v76 : string list = v75 :: v74 
    let v77 : string = "Warning"
    let v78 : string list = v77 :: v76 
    let v79 : string = "Info"
    let v80 : string list = v79 :: v78 
    let v81 : string = "Debug"
    let v82 : string list = v81 :: v80 
    let v83 : string = "Verbose"
    let v84 : string list = v83 :: v82 
    let v85 : (string list -> (string [])) = List.toArray
    let v86 : (string []) = v85 v84
    let v87 : string = "$0.to_vec()"
    let v88 : Vec<string> = Fable.Core.RustInterop.emitRustExpr v86 v87
    let v89 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
    let v90 : (string -> clap_builder_PossibleValue) = closure1()
    let v91 : Vec<clap_builder_PossibleValue> = Fable.Core.RustInterop.emitRustExpr struct (v88, v90) v89
    let v92 : string = "clap::builder::PossibleValuesParser::new($0).into()"
    let v93 : clap_builder_ValueParser = Fable.Core.RustInterop.emitRustExpr v91 v92
    let v94 : string = "$0.value_parser($1)"
    let v95 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v73, v93) v94
    let v96 : string = "clap::Command::arg($0, $1)"
    let v97 : clap_Command = Fable.Core.RustInterop.emitRustExpr struct (v62, v95) v96
    v97
and closure0 () () : unit =
    let v0 : string = "true; () //"
    let v1 : bool = Fable.Core.RustInterop.emitRustExpr () v0
    let v2 : string = "} /* /*"
    Fable.Core.RustInterop.emitRustExpr () v2
    let v3 : string = "verify_app"
    let v4 : string = $"*/ #[test] fn " + v3 + "() { //"
    let v5 : bool = Fable.Core.RustInterop.emitRustExpr () v4
    let v6 : clap_Command = method0()
    let v7 : string = "clap::Command::debug_assert($0)"
    Fable.Core.RustInterop.emitRustExpr v6 v7
    let v8 : string = "{ //"
    Fable.Core.RustInterop.emitRustExpr () v8
    ()
and closure4 () (v0 : string) : unit =
    ()
and method3 (v0 : int64 option) : int64 option =
    v0
and method4 (v0 : int64 option) : int64 option =
    v0
and closure3 () () : struct (Mut0 * Mut1 * Mut2 * int64 option * Mut3) =
    let v0 : Mut1 = {l0 = true} : Mut1
    let v1 : Mut0 = {l0 = 0L} : Mut0
    let v2 : US0 = US0_0
    let v3 : Mut2 = {l0 = v2} : Mut2
    let v4 : (string -> unit) = closure4()
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
    let v31 : int64 option = method3(v30)
    v31 
    #else
    let v32 : int64 option = None
    let v33 : int64 option = method4(v32)
    v33 
    #endif
    |> fun x -> _v6 <- Some x
    let v34 : int64 option = _v6.Value
    struct (v1, v0, v3, v34, v5)
and closure5 () () : string =
    let v0 : string = $"spiral_builder.main"
    v0
and closure7 () () : string =
    let v0 : string = ""
    v0
and closure6 (v0 : (string [])) () : string =
    let v1 : (unit -> string) = closure7()
    let v2 : string = $"args: {v0} / {v1 ()}"
    v2
and closure9 () (v0 : int64) : US2 =
    US2_0(v0)
and method6 () : (int64 -> US2) =
    closure9()
and method7 () : string =
    let v0 : string = ""
    v0
and closure8 (v0 : US0, v1 : (unit -> string), v2 : (unit -> string)) () : string =
    let v3 : (unit -> struct (Mut0 * Mut1 * Mut2 * int64 option * Mut3)) = closure3()
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
    let v2 : (unit -> struct (Mut0 * Mut1 * Mut2 * int64 option * Mut3)) = closure3()
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
    let v3 : (unit -> string) = closure8(v0, v1, v2)
    method8(v0, v3)
and method9 () : string =
    let v0 : string = "file"
    v0
and closure10 () (v0 : std_string_String) : US3 =
    US3_0(v0)
and method10 () : (std_string_String -> US3) =
    closure10()
and method11 () : string =
    let v0 : string = "out-dir"
    v0
and method12 () : string =
    let v0 : string = "hash"
    v0
and method13 () : string =
    let v0 : string = "args"
    v0
and method14 () : string =
    let v0 : string = "trace-level"
    v0
and method16 (v0 : string) : string =
    v0
and method18 (v0 : string) : string =
    v0
and method19 (v0 : string) : string =
    v0
and method17 (v0 : string, v1 : string) : string =
    let v2 : string option = None
    let v3 : bool = true in let mutable _v2 = v2
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v4 : string = method1(v0)
    let v5 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v6 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v4 v5
    let v7 : string = "String::from($0)"
    let v8 : std_string_String = Fable.Core.RustInterop.emitRustExpr v6 v7
    let v9 : string = "std::path::PathBuf::from($0)"
    let v10 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v8 v9
    let v11 : string = method1(v1)
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
    let v38 : string = method18(v0)
    let v39 : string = method19(v1)
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
and method20 () : string =
    let v0 : string = "^\\\\\\\\\\?\\\\"
    v0
and method21 (v0 : string) : string =
    v0
and method22 () : string =
    let v0 : string = ""
    v0
and method23 (v0 : int32, v1 : Mut4) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method24 (v0 : int32, v1 : Mut5) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method25 (v0 : string) : string =
    v0
and method26 (v0 : string) : string =
    v0
and closure11 () () : string =
    let v0 : string = "spiral_builder.run"
    v0
and closure12 (v0 : string, v1 : string, v2 : string, v3 : string) () : string =
    let v4 : (unit -> string) = closure7()
    let v5 : string = $"file: {v2} / out_dir: {v3} / hash: {v1} / args: {v0} / {v4 ()}"
    v5
and method28 () : clap_Command =
    let v0 : string = "command"
    let v1 : string = "r#\"" + v0 + "\"#"
    let v2 : StaticRef<Str> = Fable.Core.RustInterop.emitRustExpr () v1
    let v3 : string = "clap::Command::new($0)"
    let v4 : clap_Command = Fable.Core.RustInterop.emitRustExpr v2 v3
    let v5 : string = "clap::Command::subcommand_required($0, true)"
    let v6 : clap_Command = Fable.Core.RustInterop.emitRustExpr v4 v5
    let v7 : string = "rust"
    let v8 : string = "r#\"" + v7 + "\"#"
    let v9 : StaticRef<Str> = Fable.Core.RustInterop.emitRustExpr () v8
    let v10 : string = "clap::Command::new($0)"
    let v11 : clap_Command = Fable.Core.RustInterop.emitRustExpr v9 v10
    let v12 : string = "deps"
    let v13 : string = "r#\"" + v12 + "\"#"
    let v14 : StaticRef<Str> = Fable.Core.RustInterop.emitRustExpr () v13
    let v15 : string = "clap::Arg::new($0)"
    let v16 : clap_Arg = Fable.Core.RustInterop.emitRustExpr v14 v15
    let v17 : string = "$0.short($1)"
    let v18 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v16, 'd') v17
    let v19 : string = "r#\"" + v12 + "\"#"
    let v20 : StaticRef<Str> = Fable.Core.RustInterop.emitRustExpr () v19
    let v21 : string = "$0.long($1)"
    let v22 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v18, v20) v21
    let v23 : string = "NAME"
    let v24 : string = "r#\"" + v23 + "\"#"
    let v25 : StaticRef<Str> = Fable.Core.RustInterop.emitRustExpr () v24
    let v26 : string = "VERSION"
    let v27 : string = "r#\"" + v26 + "\"#"
    let v28 : StaticRef<Str> = Fable.Core.RustInterop.emitRustExpr () v27
    let v29 : (StaticRef<Str> []) = [|v25; v28|]
    let v30 : string = "$0.to_vec()"
    let v31 : Vec<StaticRef<Str>> = Fable.Core.RustInterop.emitRustExpr v29 v30
    let v32 : string = "$0.value_names($1)"
    let v33 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v22, v31) v32
    let v34 : string = "clap::builder::ValueRange::new(1..)"
    let v35 : clap_builder_ValueRange = Fable.Core.RustInterop.emitRustExpr () v34
    let v36 : string = "$0.num_args($1)"
    let v37 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v33, v35) v36
    let v38 : string = "clap::Command::arg($0, $1)"
    let v39 : clap_Command = Fable.Core.RustInterop.emitRustExpr struct (v11, v37) v38
    let v40 : string = "clap::Command::subcommand($0, v39)"
    let v41 : clap_Command = Fable.Core.RustInterop.emitRustExpr v6 v40
    v41
and closure13 () (v0 : string) : US4 =
    US4_0(v0)
and method30 () : (string -> US4) =
    closure13()
and closure15 (v0 : char) (v1 : UH1) : UH1 =
    UH1_1(v0, v1)
and closure14 () (v0 : char) : (UH1 -> UH1) =
    closure15(v0)
and method31 () : (char -> (UH1 -> UH1)) =
    closure14()
and method34 (v0 : UH0, v1 : UH0) : UH0 =
    match v0 with
    | UH0_1(v2, v3) -> (* Cons *)
        let v4 : UH0 = method34(v3, v1)
        UH0_1(v2, v4)
    | UH0_0 -> (* Nil *)
        v1
and method33 (v0 : string, v1 : UH0, v2 : UH1, v3 : US5) : struct (UH0 * string) =
    match v3 with
    | US5_2(v44) -> (* Escaped *)
        match v2 with
        | UH1_1(v45, v46) -> (* Cons *)
            let v47 : bool = '\\' = v45
            if v47 then
                let v48 : char = '\\'
                let v49 : US5 = US5_1(v48)
                method32(v0, v1, v46, v3, v49)
            else
                let v52 : bool = '"' = v45
                if v52 then
                    let v54 : bool =
                        match v3 with
                        | US5_0 -> (* Start *)
                            true
                        | _ ->
                            false
                    if v54 then
                        method33(v0, v1, v46, v3)
                    else
                        let v57 : string = $"{v0}\""
                        let v58 : US5 = US5_2(v44)
                        method32(v57, v1, v46, v3, v58)
                else
                    let v63 : bool = ' ' = v45
                    if v63 then
                        let v64 : string = $"{v0} "
                        method33(v64, v1, v46, v3)
                    else
                        let v67 : bool = 1uy = v44
                        if v67 then
                            let v68 : bool = v3 <> v3
                            if v68 then
                                let v69 : string = $"{v0}\{v45}"
                                method33(v69, v1, v46, v3)
                            else
                                let v72 : string = $"{v0}{v45}"
                                method33(v72, v1, v46, v3)
                        else
                            let v77 : string = $"{v0}{v45}"
                            method33(v77, v1, v46, v3)
        | _ ->
            let v88 : bool = 1uy = v44
            if v88 then
                let v90 : bool = v0 = ""
                let v94 : UH0 =
                    if v90 then
                        v1
                    else
                        let v91 : UH0 = UH0_0
                        let v92 : UH0 = UH0_1(v0, v91)
                        method34(v1, v92)
                struct (v94, v0)
            else
                let v96 : bool = v0 = ""
                let v100 : UH0 =
                    if v96 then
                        v1
                    else
                        let v97 : UH0 = UH0_0
                        let v98 : UH0 = UH0_1(v0, v97)
                        method34(v1, v98)
                struct (v100, v0)
    | US5_1(v105) -> (* Quoted *)
        let v106 : bool = '"' = v105
        if v106 then
            match v2 with
            | UH1_1(v107, v108) -> (* Cons *)
                let v109 : bool = '"' = v107
                if v109 then
                    let v110 : US5 = US5_1('\\')
                    let v111 : bool = v3 = v110
                    if v111 then
                        let v112 : US5 = US5_0
                        method32(v0, v1, v108, v3, v112)
                    else
                        let v115 : bool = '\\' = v105
                        if v115 then
                            let v116 : US5 = US5_2(0uy)
                            let v117 : bool = v3 <> v116
                            if v117 then
                                let v118 : string = $"{v0}\""
                                let v119 : char = '"'
                                let v120 : US5 = US5_1(v119)
                                method32(v118, v1, v108, v3, v120)
                            else
                                let v123 : US5 = US5_1('\\')
                                let v124 : bool = v3 = v123
                                if v124 then
                                    let v125 : string = $"{v0}\""
                                    let v126 : char = '"'
                                    let v127 : US5 = US5_1(v126)
                                    method32(v125, v1, v108, v3, v127)
                                else
                                    let v130 : US5 = US5_0
                                    method32(v0, v1, v108, v3, v130)
                        else
                            let v137 : bool = '\\' = v107
                            if v137 then
                                let v138 : uint8 = 1uy
                                let v139 : US5 = US5_2(v138)
                                method32(v0, v1, v108, v3, v139)
                            else
                                let v142 : US5 = US5_2(0uy)
                                let v143 : bool = v3 = v142
                                if v143 then
                                    let v144 : string = $"{v0}\""
                                    let v145 : char = '"'
                                    let v146 : US5 = US5_1(v145)
                                    method32(v144, v1, v108, v3, v146)
                                else
                                    let v149 : UH0 = UH0_0
                                    let v150 : UH0 = UH0_1(v0, v149)
                                    let v151 : UH0 = method34(v1, v150)
                                    let v152 : string = ""
                                    let v153 : US5 = US5_0
                                    method32(v152, v151, v108, v3, v153)
                else
                    let v164 : bool = '\\' = v105
                    if v164 then
                        let v165 : bool = '\\' = v107
                        if v165 then
                            let v166 : uint8 = 1uy
                            let v167 : US5 = US5_2(v166)
                            method32(v0, v1, v108, v3, v167)
                        else
                            let v170 : bool = ' ' = v107
                            if v170 then
                                let v171 : string = $"{v0} "
                                method33(v171, v1, v108, v3)
                            else
                                let v174 : string = $"{v0}{v107}"
                                method33(v174, v1, v108, v3)
                    else
                        let v181 : bool = '\\' = v107
                        if v181 then
                            let v182 : uint8 = 1uy
                            let v183 : US5 = US5_2(v182)
                            method32(v0, v1, v108, v3, v183)
                        else
                            let v186 : bool = ' ' = v107
                            if v186 then
                                let v187 : string = $"{v0} "
                                method33(v187, v1, v108, v3)
                            else
                                let v190 : string = $"{v0}{v107}"
                                method33(v190, v1, v108, v3)
            | _ ->
                let v201 : bool = '\\' = v105
                if v201 then
                    let v203 : bool = v0 = ""
                    let v207 : UH0 =
                        if v203 then
                            v1
                        else
                            let v204 : UH0 = UH0_0
                            let v205 : UH0 = UH0_1(v0, v204)
                            method34(v1, v205)
                    struct (v207, v0)
                else
                    let v209 : bool = v0 = ""
                    let v213 : UH0 =
                        if v209 then
                            v1
                        else
                            let v210 : UH0 = UH0_0
                            let v211 : UH0 = UH0_1(v0, v210)
                            method34(v1, v211)
                    struct (v213, v0)
        else
            let v218 : bool = '\\' = v105
            if v218 then
                match v2 with
                | UH1_1(v219, v220) -> (* Cons *)
                    let v221 : bool = '"' = v219
                    if v221 then
                        let v222 : US5 = US5_2(0uy)
                        let v223 : bool = v3 <> v222
                        if v223 then
                            let v224 : string = $"{v0}\""
                            let v225 : char = '"'
                            let v226 : US5 = US5_1(v225)
                            method32(v224, v1, v220, v3, v226)
                        else
                            let v229 : US5 = US5_1('\\')
                            let v230 : bool = v3 = v229
                            if v230 then
                                let v231 : string = $"{v0}\""
                                let v232 : char = '"'
                                let v233 : US5 = US5_1(v232)
                                method32(v231, v1, v220, v3, v233)
                            else
                                let v236 : US5 = US5_0
                                method32(v0, v1, v220, v3, v236)
                    else
                        let v243 : bool = '\\' = v219
                        if v243 then
                            let v244 : uint8 = 1uy
                            let v245 : US5 = US5_2(v244)
                            method32(v0, v1, v220, v3, v245)
                        else
                            let v248 : bool = ' ' = v219
                            if v248 then
                                let v249 : string = $"{v0} "
                                method33(v249, v1, v220, v3)
                            else
                                let v252 : string = $"{v0}{v219}"
                                method33(v252, v1, v220, v3)
                | _ ->
                    let v262 : bool = v0 = ""
                    let v266 : UH0 =
                        if v262 then
                            v1
                        else
                            let v263 : UH0 = UH0_0
                            let v264 : UH0 = UH0_1(v0, v263)
                            method34(v1, v264)
                    struct (v266, v0)
            else
                match v2 with
                | UH1_1(v269, v270) -> (* Cons *)
                    let v271 : bool = '\\' = v269
                    if v271 then
                        let v272 : uint8 = 1uy
                        let v273 : US5 = US5_2(v272)
                        method32(v0, v1, v270, v3, v273)
                    else
                        let v276 : bool = '"' = v269
                        if v276 then
                            let v277 : US5 = US5_2(0uy)
                            let v278 : bool = v3 = v277
                            if v278 then
                                let v279 : string = $"{v0}\""
                                let v280 : char = '"'
                                let v281 : US5 = US5_1(v280)
                                method32(v279, v1, v270, v3, v281)
                            else
                                let v284 : UH0 = UH0_0
                                let v285 : UH0 = UH0_1(v0, v284)
                                let v286 : UH0 = method34(v1, v285)
                                let v287 : string = ""
                                let v288 : US5 = US5_0
                                method32(v287, v286, v270, v3, v288)
                        else
                            let v293 : bool = ' ' = v269
                            if v293 then
                                let v294 : string = $"{v0} "
                                method33(v294, v1, v270, v3)
                            else
                                let v297 : string = $"{v0}{v269}"
                                method33(v297, v1, v270, v3)
                | _ ->
                    let v307 : bool = v0 = ""
                    let v311 : UH0 =
                        if v307 then
                            v1
                        else
                            let v308 : UH0 = UH0_0
                            let v309 : UH0 = UH0_1(v0, v308)
                            method34(v1, v309)
                    struct (v311, v0)
    | US5_0 -> (* Start *)
        match v2 with
        | UH1_1(v4, v5) -> (* Cons *)
            let v6 : bool = '"' = v4
            if v6 then
                let v7 : string = ""
                let v8 : char = '"'
                let v9 : US5 = US5_1(v8)
                method32(v7, v1, v5, v3, v9)
            else
                let v12 : bool = '\\' = v4
                if v12 then
                    let v13 : uint8 = 0uy
                    let v14 : US5 = US5_2(v13)
                    method32(v0, v1, v5, v3, v14)
                else
                    let v17 : bool = ' ' = v4
                    if v17 then
                        let v19 : bool = v0 = ""
                        let v23 : UH0 =
                            if v19 then
                                v1
                            else
                                let v20 : UH0 = UH0_0
                                let v21 : UH0 = UH0_1(v0, v20)
                                method34(v1, v21)
                        let v24 : string = ""
                        method33(v24, v23, v5, v3)
                    else
                        let v27 : string = $"{v0}{v4}"
                        method33(v27, v1, v5, v3)
        | _ ->
            let v37 : bool = v0 = ""
            let v41 : UH0 =
                if v37 then
                    v1
                else
                    let v38 : UH0 = UH0_0
                    let v39 : UH0 = UH0_1(v0, v38)
                    method34(v1, v39)
            struct (v41, v0)
and method32 (v0 : string, v1 : UH0, v2 : UH1, v3 : US5, v4 : US5) : struct (UH0 * string) =
    match v4 with
    | US5_2(v45) -> (* Escaped *)
        match v2 with
        | UH1_1(v46, v47) -> (* Cons *)
            let v48 : bool = '\\' = v46
            if v48 then
                let v49 : char = '\\'
                let v50 : US5 = US5_1(v49)
                method32(v0, v1, v47, v4, v50)
            else
                let v53 : bool = '"' = v46
                if v53 then
                    let v55 : bool =
                        match v3 with
                        | US5_0 -> (* Start *)
                            true
                        | _ ->
                            false
                    if v55 then
                        method33(v0, v1, v47, v4)
                    else
                        let v58 : string = $"{v0}\""
                        let v59 : US5 = US5_2(v45)
                        method32(v58, v1, v47, v4, v59)
                else
                    let v64 : bool = ' ' = v46
                    if v64 then
                        let v65 : string = $"{v0} "
                        method33(v65, v1, v47, v4)
                    else
                        let v68 : bool = 1uy = v45
                        if v68 then
                            let v69 : bool = v3 <> v4
                            if v69 then
                                let v70 : string = $"{v0}\{v46}"
                                method32(v70, v1, v47, v4, v3)
                            else
                                let v73 : string = $"{v0}{v46}"
                                method33(v73, v1, v47, v4)
                        else
                            let v78 : string = $"{v0}{v46}"
                            method33(v78, v1, v47, v4)
        | _ ->
            let v89 : bool = 1uy = v45
            if v89 then
                let v91 : bool = v0 = ""
                let v95 : UH0 =
                    if v91 then
                        v1
                    else
                        let v92 : UH0 = UH0_0
                        let v93 : UH0 = UH0_1(v0, v92)
                        method34(v1, v93)
                struct (v95, v0)
            else
                let v97 : bool = v0 = ""
                let v101 : UH0 =
                    if v97 then
                        v1
                    else
                        let v98 : UH0 = UH0_0
                        let v99 : UH0 = UH0_1(v0, v98)
                        method34(v1, v99)
                struct (v101, v0)
    | US5_1(v106) -> (* Quoted *)
        let v107 : bool = '"' = v106
        if v107 then
            match v2 with
            | UH1_1(v108, v109) -> (* Cons *)
                let v110 : bool = '"' = v108
                if v110 then
                    let v111 : US5 = US5_1('\\')
                    let v112 : bool = v3 = v111
                    if v112 then
                        let v113 : US5 = US5_0
                        method32(v0, v1, v109, v4, v113)
                    else
                        let v116 : bool = '\\' = v106
                        if v116 then
                            let v117 : US5 = US5_2(0uy)
                            let v118 : bool = v3 <> v117
                            if v118 then
                                let v119 : string = $"{v0}\""
                                let v120 : char = '"'
                                let v121 : US5 = US5_1(v120)
                                method32(v119, v1, v109, v4, v121)
                            else
                                let v124 : US5 = US5_1('\\')
                                let v125 : bool = v3 = v124
                                if v125 then
                                    let v126 : string = $"{v0}\""
                                    let v127 : char = '"'
                                    let v128 : US5 = US5_1(v127)
                                    method32(v126, v1, v109, v4, v128)
                                else
                                    let v131 : US5 = US5_0
                                    method32(v0, v1, v109, v4, v131)
                        else
                            let v138 : bool = '\\' = v108
                            if v138 then
                                let v139 : uint8 = 1uy
                                let v140 : US5 = US5_2(v139)
                                method32(v0, v1, v109, v4, v140)
                            else
                                let v143 : US5 = US5_2(0uy)
                                let v144 : bool = v3 = v143
                                if v144 then
                                    let v145 : string = $"{v0}\""
                                    let v146 : char = '"'
                                    let v147 : US5 = US5_1(v146)
                                    method32(v145, v1, v109, v4, v147)
                                else
                                    let v150 : UH0 = UH0_0
                                    let v151 : UH0 = UH0_1(v0, v150)
                                    let v152 : UH0 = method34(v1, v151)
                                    let v153 : string = ""
                                    let v154 : US5 = US5_0
                                    method32(v153, v152, v109, v4, v154)
                else
                    let v165 : bool = '\\' = v106
                    if v165 then
                        let v166 : bool = '\\' = v108
                        if v166 then
                            let v167 : uint8 = 1uy
                            let v168 : US5 = US5_2(v167)
                            method32(v0, v1, v109, v4, v168)
                        else
                            let v171 : bool = ' ' = v108
                            if v171 then
                                let v172 : string = $"{v0} "
                                method33(v172, v1, v109, v4)
                            else
                                let v175 : string = $"{v0}{v108}"
                                method33(v175, v1, v109, v4)
                    else
                        let v182 : bool = '\\' = v108
                        if v182 then
                            let v183 : uint8 = 1uy
                            let v184 : US5 = US5_2(v183)
                            method32(v0, v1, v109, v4, v184)
                        else
                            let v187 : bool = ' ' = v108
                            if v187 then
                                let v188 : string = $"{v0} "
                                method33(v188, v1, v109, v4)
                            else
                                let v191 : string = $"{v0}{v108}"
                                method33(v191, v1, v109, v4)
            | _ ->
                let v202 : bool = '\\' = v106
                if v202 then
                    let v204 : bool = v0 = ""
                    let v208 : UH0 =
                        if v204 then
                            v1
                        else
                            let v205 : UH0 = UH0_0
                            let v206 : UH0 = UH0_1(v0, v205)
                            method34(v1, v206)
                    struct (v208, v0)
                else
                    let v210 : bool = v0 = ""
                    let v214 : UH0 =
                        if v210 then
                            v1
                        else
                            let v211 : UH0 = UH0_0
                            let v212 : UH0 = UH0_1(v0, v211)
                            method34(v1, v212)
                    struct (v214, v0)
        else
            let v219 : bool = '\\' = v106
            if v219 then
                match v2 with
                | UH1_1(v220, v221) -> (* Cons *)
                    let v222 : bool = '"' = v220
                    if v222 then
                        let v223 : US5 = US5_2(0uy)
                        let v224 : bool = v3 <> v223
                        if v224 then
                            let v225 : string = $"{v0}\""
                            let v226 : char = '"'
                            let v227 : US5 = US5_1(v226)
                            method32(v225, v1, v221, v4, v227)
                        else
                            let v230 : US5 = US5_1('\\')
                            let v231 : bool = v3 = v230
                            if v231 then
                                let v232 : string = $"{v0}\""
                                let v233 : char = '"'
                                let v234 : US5 = US5_1(v233)
                                method32(v232, v1, v221, v4, v234)
                            else
                                let v237 : US5 = US5_0
                                method32(v0, v1, v221, v4, v237)
                    else
                        let v244 : bool = '\\' = v220
                        if v244 then
                            let v245 : uint8 = 1uy
                            let v246 : US5 = US5_2(v245)
                            method32(v0, v1, v221, v4, v246)
                        else
                            let v249 : bool = ' ' = v220
                            if v249 then
                                let v250 : string = $"{v0} "
                                method33(v250, v1, v221, v4)
                            else
                                let v253 : string = $"{v0}{v220}"
                                method33(v253, v1, v221, v4)
                | _ ->
                    let v263 : bool = v0 = ""
                    let v267 : UH0 =
                        if v263 then
                            v1
                        else
                            let v264 : UH0 = UH0_0
                            let v265 : UH0 = UH0_1(v0, v264)
                            method34(v1, v265)
                    struct (v267, v0)
            else
                match v2 with
                | UH1_1(v270, v271) -> (* Cons *)
                    let v272 : bool = '\\' = v270
                    if v272 then
                        let v273 : uint8 = 1uy
                        let v274 : US5 = US5_2(v273)
                        method32(v0, v1, v271, v4, v274)
                    else
                        let v277 : bool = '"' = v270
                        if v277 then
                            let v278 : US5 = US5_2(0uy)
                            let v279 : bool = v3 = v278
                            if v279 then
                                let v280 : string = $"{v0}\""
                                let v281 : char = '"'
                                let v282 : US5 = US5_1(v281)
                                method32(v280, v1, v271, v4, v282)
                            else
                                let v285 : UH0 = UH0_0
                                let v286 : UH0 = UH0_1(v0, v285)
                                let v287 : UH0 = method34(v1, v286)
                                let v288 : string = ""
                                let v289 : US5 = US5_0
                                method32(v288, v287, v271, v4, v289)
                        else
                            let v294 : bool = ' ' = v270
                            if v294 then
                                let v295 : string = $"{v0} "
                                method33(v295, v1, v271, v4)
                            else
                                let v298 : string = $"{v0}{v270}"
                                method33(v298, v1, v271, v4)
                | _ ->
                    let v308 : bool = v0 = ""
                    let v312 : UH0 =
                        if v308 then
                            v1
                        else
                            let v309 : UH0 = UH0_0
                            let v310 : UH0 = UH0_1(v0, v309)
                            method34(v1, v310)
                    struct (v312, v0)
    | US5_0 -> (* Start *)
        match v2 with
        | UH1_1(v5, v6) -> (* Cons *)
            let v7 : bool = '"' = v5
            if v7 then
                let v8 : string = ""
                let v9 : char = '"'
                let v10 : US5 = US5_1(v9)
                method32(v8, v1, v6, v4, v10)
            else
                let v13 : bool = '\\' = v5
                if v13 then
                    let v14 : uint8 = 0uy
                    let v15 : US5 = US5_2(v14)
                    method32(v0, v1, v6, v4, v15)
                else
                    let v18 : bool = ' ' = v5
                    if v18 then
                        let v20 : bool = v0 = ""
                        let v24 : UH0 =
                            if v20 then
                                v1
                            else
                                let v21 : UH0 = UH0_0
                                let v22 : UH0 = UH0_1(v0, v21)
                                method34(v1, v22)
                        let v25 : string = ""
                        method33(v25, v24, v6, v4)
                    else
                        let v28 : string = $"{v0}{v5}"
                        method33(v28, v1, v6, v4)
        | _ ->
            let v38 : bool = v0 = ""
            let v42 : UH0 =
                if v38 then
                    v1
                else
                    let v39 : UH0 = UH0_0
                    let v40 : UH0 = UH0_1(v0, v39)
                    method34(v1, v40)
            struct (v42, v0)
and method35 (v0 : UH0, v1 : string list) : string list =
    match v0 with
    | UH0_1(v2, v3) -> (* Cons *)
        let v4 : string list = method35(v3, v1)
        let v5 : string list = v2 :: v4 
        v5
    | UH0_0 -> (* Nil *)
        v1
and method29 (v0 : string) : (string []) =
    let v1 : UH0 = UH0_0
    let v2 : string = ""
    let v3 : bool = true in let mutable _v0 = None
    #if !FABLE_COMPILER && !WASM && !CONTRACT
    let v4 : (string -> string option) = Option.ofObj
    let v5 : string option = v4 v0
    v5 
    #else
    Some v0 
    #endif
    |> fun x -> _v0 <- Some x
    let v6 : string option = _v0.Value
    let v7 : (string -> US4) = method30()
    let v8 : US4 = US4_1
    let v9 : US4 = v6 |> Option.map v7 |> Option.defaultValue v8 
    let v12 : string =
        match v9 with
        | US4_1 -> (* None *)
            v2
        | US4_0(v10) -> (* Some *)
            v10
    let v13 : int32 = v12.Length
    let v14 : (char []) = Array.zeroCreate<char> (v13)
    let v15 : Mut5 = {l0 = 0} : Mut5
    while method24(v13, v15) do
        let v17 : int32 = v15.l0
        let v18 : char = v12.[int v17]
        v14.[int v17] <- v18
        let v19 : int32 = v17 + 1
        v15.l0 <- v19
        ()
    let v20 : ((char []) -> char list) = Array.toList
    let v21 : char list = v20 v14
    let v22 : ((char -> (UH1 -> UH1)) -> (char list -> (UH1 -> UH1))) = List.foldBack
    let v23 : (char -> (UH1 -> UH1)) = method31()
    let v24 : (char list -> (UH1 -> UH1)) = v22 v23
    let v25 : (UH1 -> UH1) = v24 v21
    let v26 : UH1 = UH1_0
    let v27 : UH1 = v25 v26
    let v28 : US5 = US5_0
    let v29 : US5 = US5_0
    let struct (v30 : UH0, v31 : string) = method32(v2, v1, v27, v29, v28)
    let v32 : string list = []
    let v33 : string list = method35(v30, v32)
    let v34 : (string list -> (string [])) = List.toArray
    let v35 : (string []) = v34 v33
    v35
and closure16 () (v0 : string) : std_string_String =
    let v1 : string = method1(v0)
    let v2 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v3 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1 v2
    let v4 : string = "String::from($0)"
    let v5 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3 v4
    v5
and closure17 () (v0 : Ref<Str>) : std_string_String =
    let v1 : string = "String::from($0)"
    let v2 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v1
    v2
and closure18 () struct (v0 : std_string_String, v1 : clap_ArgMatches) : US6 =
    US6_0(v0, v1)
and method36 () : (struct (std_string_String * clap_ArgMatches) -> US6) =
    closure18()
and method37 () : string =
    let v0 : string = "deps"
    v0
and closure19 () () : string =
    let v0 : string = "spiral_builder.run"
    v0
and closure20 (v0 : Vec<std_string_String> option) () : string =
    let v1 : (unit -> string) = closure7()
    let v2 : string = $"deps: %A{v0} / {v1 ()}"
    v2
and closure21 () () : string =
    let v0 : string = "spiral_builder.run"
    v0
and closure22 (v0 : std_string_String) () : string =
    let v1 : (unit -> string) = closure7()
    let v2 : string = $"subcommand: {v0} / {v1 ()}"
    v2
and closure23 () () : string =
    let v0 : string = "spiral_builder.run"
    v0
and closure24 (v0 : string) () : string =
    let v1 : (unit -> string) = closure7()
    let v2 : string = $"result: {v0} / {v1 ()}"
    v2
and method38 (v0 : Result<string, std_string_String>) : Result<string, std_string_String> =
    v0
and method27 (v0 : string, v1 : string) : std_pin_Pin<Box<Dyn<std_future_Future<Result<string, std_string_String>>>>> =
    let v2 : string = "let __result = Box::pin(async move { //"
    Fable.Core.RustInterop.emitRustExpr () v2
    let v3 : clap_Command = method28()
    let v4 : string = $"spiral_builder {v0}"
    let v5 : (string []) = method29(v4)
    let v6 : string = "$0.to_vec()"
    let v7 : Vec<string> = Fable.Core.RustInterop.emitRustExpr v5 v6
    let v8 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
    let v9 : (string -> std_string_String) = closure16()
    let v10 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v7, v9) v8
    let v11 : string = "clap::Command::get_matches_from($0, v10)"
    let v12 : clap_ArgMatches = Fable.Core.RustInterop.emitRustExpr v3 v11
    let v13 : string = "v12.clone()"
    let v14 : clap_ArgMatches = Fable.Core.RustInterop.emitRustExpr () v13
    let v15 : string = "clap::ArgMatches::subcommand(Box::leak(Box::new(v14))).map(|(a, b)| ($0(a), b.clone()))"
    let v16 : (Ref<Str> -> std_string_String) = closure17()
    let v17 : struct (std_string_String * clap_ArgMatches) option = Fable.Core.RustInterop.emitRustExpr v16 v15
    let v18 : (struct (std_string_String * clap_ArgMatches) -> US6) = method36()
    let v19 : US6 = US6_1
    let v20 : US6 = v17 |> Option.map v18 |> Option.defaultValue v19 
    let v42 : string =
        match v20 with
        | US6_0(v21, v22) -> (* Some *)
            let v23 : string = "fable_library_rust::String_::fromString($0)"
            let v24 : string = Fable.Core.RustInterop.emitRustExpr v21 v23
            let v26 : bool = v24 = "rust"
            if v26 then
                let v27 : string = method37()
                let v28 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
                let v29 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v27 v28
                let v30 : string = "clap::ArgMatches::get_many(&$0, v29).map(|x| x.cloned().into_iter().collect())"
                let v31 : Vec<std_string_String> option = Fable.Core.RustInterop.emitRustExpr v22 v30
                let v32 : US0 = US0_1
                let v33 : (unit -> string) = closure19()
                let v34 : (unit -> string) = closure20(v31)
                method5(v32, v33, v34)
                let v35 : string = $"""[package]
name = "{v1}"
version = "0.0.1"
edition = "2021"

[workspace]

[dependencies]
fable_library_rust = {{ path = "fable_modules/fable-library-rust", default-features = false, features = ["static_do_bindings", "datetime", "guid", "threaded"] }}
clap = "~4.5"
inline_colorization = "~0.1"
regex = "~1.10"
chrono = "~0.4"
num-complex = "~0.4"
pyo3 = "~0.21"
async-std = "~1.12"
futures = "~0.3"
futures-lite = "~2.3"
async-walkdir = "~1.0"
rayon = "~1.10"

[[bin]]
name = "{v1}"
path = "{v1}.rs" """
                v35
            else
                let v36 : US0 = US0_1
                let v37 : (unit -> string) = closure21()
                let v38 : (unit -> string) = closure22(v21)
                method5(v36, v37, v38)
                let v39 : string = $"""[package]
name = "{v1}"
version = "0.0.1"
edition = "2021"

[workspace]

[dependencies]
fable_library_rust = {{ path = "fable_modules/fable-library-rust", default-features = false, features = ["static_do_bindings", "datetime", "guid", "threaded"] }}
clap = "~4.5"
inline_colorization = "~0.1"
regex = "~1.10"
chrono = "~0.4"
num-complex = "~0.4"
pyo3 = "~0.21"
async-std = "~1.12"
futures = "~0.3"
futures-lite = "~2.3"
async-walkdir = "~1.0"
rayon = "~1.10"

[[bin]]
name = "{v1}"
path = "{v1}.rs" """
                v39
        | _ ->
            let v41 : string = ""
            v41
    let v43 : US0 = US0_1
    let v44 : (unit -> string) = closure23()
    let v45 : (unit -> string) = closure24(v42)
    method5(v43, v44, v45)
    let v46 : Result<string, std_string_String> = Ok v42
    let v47 : Result<string, std_string_String> = method38(v46)
    let v48 : string = "v47 }}})"
    Fable.Core.RustInterop.emitRustExpr () v48
    let v49 : string = "{{ //"
    Fable.Core.RustInterop.emitRustExpr () v49
    let v50 : string = "__result"
    let v51 : std_pin_Pin<Box<Dyn<std_future_Future<Result<string, std_string_String>>>>> = Fable.Core.RustInterop.emitRustExpr () v50
    v51
and method15 (v0 : string, v1 : string, v2 : string, v3 : string) : std_pin_Pin<Box<Dyn<std_future_Future<Result<string, std_string_String>>>>> =
    let v4 : string option = None
    let v5 : bool = true in let mutable _v4 = v4
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v6 : string = method16(v3)
    let v7 : string = method1(v6)
    let v8 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v9 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v7 v8
    let v10 : string = "String::from($0)"
    let v11 : std_string_String = Fable.Core.RustInterop.emitRustExpr v9 v10
    let v12 : string = "std::path::PathBuf::from($0)"
    let v13 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v11 v12
    let v14 : string = "$0.exists()"
    let v15 : bool = Fable.Core.RustInterop.emitRustExpr v13 v14
    let v16 : bool = v15 = false
    let v166 : string =
        if v16 then
            let v17 : string option = None
            let v18 : bool = true in let mutable _v17 = v17
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v19 : string = "std::env::current_dir()"
            let v20 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v19
            let v21 : string = "$0.unwrap()"
            let v22 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v20 v21
            let v23 : string = "$0.display()"
            let v24 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v22 v23
            let v25 : std_string_String option = None
            let v26 : bool = true in let mutable _v25 = v25
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v27 : string = @$"format!(""{{}}"", $0)"
            let v28 : std_string_String = Fable.Core.RustInterop.emitRustExpr v24 v27
            v28
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v29 : string = @$"format!(""{{}}"", $0)"
            let v30 : std_string_String = Fable.Core.RustInterop.emitRustExpr v24 v29
            v30
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v31 : string = @$"format!(""{{}}"", $0)"
            let v32 : std_string_String = Fable.Core.RustInterop.emitRustExpr v24 v31
            v32
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v33 : std_string_String = null |> unbox<std_string_String>
            v33
#endif
            
#if FABLE_COMPILER_PYTHON
            let v34 : std_string_String = null |> unbox<std_string_String>
            v34
#endif
            
#else
            let v35 : std_string_String = null |> unbox<std_string_String>
            v35
#endif
            |> fun x -> _v25 <- Some x
            let v36 : std_string_String = _v25.Value
            let v37 : string = "fable_library_rust::String_::fromString($0)"
            let v38 : string = Fable.Core.RustInterop.emitRustExpr v36 v37
            v38
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v39 : string = null |> unbox<string>
            v39
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v40 : string = null |> unbox<string>
            v40
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v41 : string = null |> unbox<string>
            v41
#endif
            
#if FABLE_COMPILER_PYTHON
            let v42 : string = null |> unbox<string>
            v42
#endif
            
#else
            let v43 : (unit -> string) = System.IO.Directory.GetCurrentDirectory
            let v44 : string = v43 ()
            v44
#endif
            |> fun x -> _v17 <- Some x
            let v45 : string = _v17.Value
            let v46 : string = method17(v45, v6)
            let v47 : string option = None
            let v48 : bool = true in let mutable _v47 = v47
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v49 : string = method20()
            let v50 : string = method21(v46)
            let v51 : string = method22()
            let v52 : string = $"regex::Regex::new(&$0).unwrap().replace_all(&$1, &*$2)"
            let v53 : std_borrow_Cow<Str> = Fable.Core.RustInterop.emitRustExpr struct (v49, v50, v51) v52
            let v54 : string = "String::from($0)"
            let v55 : std_string_String = Fable.Core.RustInterop.emitRustExpr v53 v54
            let v56 : string = "fable_library_rust::String_::fromString($0)"
            let v57 : string = Fable.Core.RustInterop.emitRustExpr v55 v56
            v57
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v58 : string = null |> unbox<string>
            v58
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v59 : string = null |> unbox<string>
            v59
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v60 : string = null |> unbox<string>
            v60
#endif
            
#if FABLE_COMPILER_PYTHON
            let v61 : string = null |> unbox<string>
            v61
#endif
            
#else
            let v62 : string = "^\\\\\\\\\\?\\\\"
            let v63 : string = ""
            let v64 : string = System.Text.RegularExpressions.Regex.Replace (v46, v62, v63)
            v64
#endif
            |> fun x -> _v47 <- Some x
            let v65 : string = _v47.Value
            let v66 : string = $"{v65.[0] |> string |> _.ToLower()}{v65.[1..]}"
            let v67 : string = "\\"
            let v68 : string = "/"
            let v69 : string = v66.Replace (v67, v68)
            let v70 : (string []) = v69.Split v68
            let v71 : (string []) = [||]
            let v72 : int32 = v70.Length
            let v73 : Mut4 = {l0 = 0; l1 = 0; l2 = v71} : Mut4
            while method23(v72, v73) do
                let v75 : int32 = v73.l0
                let v76 : int32 =  -v75
                let v77 : int32 = v76 + v72
                let v78 : int32 = v77 - 1
                let struct (v79 : int32, v80 : (string [])) = v73.l1, v73.l2
                let v81 : string = v70.[int v78]
                let v82 : bool = ".." = v81
                let struct (v124 : int32, v125 : (string [])) =
                    if v82 then
                        let v83 : int32 = v79 + 1
                        struct (v83, v80)
                    else
                        let v84 : bool = "." = v81
                        if v84 then
                            struct (v79, v80)
                        else
                            let v85 : bool = 0 = v79
                            if v85 then
                                let v86 : string = ":"
                                let v87 : bool = v81.EndsWith v86
                                if v87 then
                                    let v88 : string = $"{v45.[0]}:"
                                    let v89 : (string []) = [|v88|]
                                    let v90 : int32 = v89.Length
                                    let v91 : int32 = v80.Length
                                    let v92 : int32 = v90 + v91
                                    let v93 : (string []) = Array.zeroCreate<string> (v92)
                                    let v94 : Mut5 = {l0 = 0} : Mut5
                                    while method24(v92, v94) do
                                        let v96 : int32 = v94.l0
                                        let v97 : bool = v96 < v90
                                        let v101 : string =
                                            if v97 then
                                                let v98 : string = v89.[int v96]
                                                v98
                                            else
                                                let v99 : int32 = v96 - v90
                                                let v100 : string = v80.[int v99]
                                                v100
                                        v93.[int v96] <- v101
                                        let v102 : int32 = v96 + 1
                                        v94.l0 <- v102
                                        ()
                                    struct (0, v93)
                                else
                                    let v103 : (string []) = [|v81|]
                                    let v104 : int32 = v103.Length
                                    let v105 : int32 = v80.Length
                                    let v106 : int32 = v104 + v105
                                    let v107 : (string []) = Array.zeroCreate<string> (v106)
                                    let v108 : Mut5 = {l0 = 0} : Mut5
                                    while method24(v106, v108) do
                                        let v110 : int32 = v108.l0
                                        let v111 : bool = v110 < v104
                                        let v115 : string =
                                            if v111 then
                                                let v112 : string = v103.[int v110]
                                                v112
                                            else
                                                let v113 : int32 = v110 - v104
                                                let v114 : string = v80.[int v113]
                                                v114
                                        v107.[int v110] <- v115
                                        let v116 : int32 = v110 + 1
                                        v108.l0 <- v116
                                        ()
                                    struct (0, v107)
                            else
                                let v119 : int32 = v79 - 1
                                struct (v119, v80)
                let v126 : int32 = v75 + 1
                v73.l0 <- v126
                v73.l1 <- v124
                v73.l2 <- v125
                ()
            let struct (v127 : int32, v128 : (string [])) = v73.l1, v73.l2
            let v129 : string seq = seq { for i = 0 to v128.Length - 1 do yield v128.[i] }
            let v130 : char option = None
            let v131 : bool = true in let mutable _v130 = v130
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v132 : string = "std::path::MAIN_SEPARATOR"
            let v133 : char = Fable.Core.RustInterop.emitRustExpr () v132
            v133
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v134 : char = null |> unbox<char>
            v134
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v135 : char = null |> unbox<char>
            v135
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v136 : char = null |> unbox<char>
            v136
#endif
            
#if FABLE_COMPILER_PYTHON
            let v137 : char = null |> unbox<char>
            v137
#endif
            
#else
            let v138 : char = System.IO.Path.DirectorySeparatorChar
            v138
#endif
            |> fun x -> _v130 <- Some x
            let v139 : char = _v130.Value
            let v140 : (char -> string) = _.ToString()
            let v141 : string = v140 v139
            let v142 : string = method25(v141)
            let v143 : (string -> (string seq -> string)) = String.concat
            let v144 : (string seq -> string) = v143 v142
            v144 v129
        else
            let v146 : string = "std::fs::canonicalize(&*$0)"
            let v147 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v6 v146
            let v148 : string = "$0.unwrap()"
            let v149 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v147 v148
            let v150 : string = "$0.display()"
            let v151 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v149 v150
            let v152 : std_string_String option = None
            let v153 : bool = true in let mutable _v152 = v152
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v154 : string = @$"format!(""{{}}"", $0)"
            let v155 : std_string_String = Fable.Core.RustInterop.emitRustExpr v151 v154
            v155
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v156 : string = @$"format!(""{{}}"", $0)"
            let v157 : std_string_String = Fable.Core.RustInterop.emitRustExpr v151 v156
            v157
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v158 : string = @$"format!(""{{}}"", $0)"
            let v159 : std_string_String = Fable.Core.RustInterop.emitRustExpr v151 v158
            v159
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v160 : std_string_String = null |> unbox<std_string_String>
            v160
#endif
            
#if FABLE_COMPILER_PYTHON
            let v161 : std_string_String = null |> unbox<std_string_String>
            v161
#endif
            
#else
            let v162 : std_string_String = null |> unbox<std_string_String>
            v162
#endif
            |> fun x -> _v152 <- Some x
            let v163 : std_string_String = _v152.Value
            let v164 : string = "fable_library_rust::String_::fromString($0)"
            let v165 : string = Fable.Core.RustInterop.emitRustExpr v163 v164
            v165
    v166
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v167 : string = null |> unbox<string>
    v167
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v168 : string = null |> unbox<string>
    v168
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v169 : string = null |> unbox<string>
    v169
#endif
    
#if FABLE_COMPILER_PYTHON
    let v170 : string = null |> unbox<string>
    v170
#endif
    
#else
    let v171 : string = method26(v3)
    let v172 : (string -> string) = System.IO.Path.GetFullPath
    let v173 : string = v172 v171
    v173
#endif
    |> fun x -> _v4 <- Some x
    let v174 : string = _v4.Value
    let v175 : string option = None
    let v176 : bool = true in let mutable _v175 = v175
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v177 : string = method16(v2)
    let v178 : string = method1(v177)
    let v179 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v180 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v178 v179
    let v181 : string = "String::from($0)"
    let v182 : std_string_String = Fable.Core.RustInterop.emitRustExpr v180 v181
    let v183 : string = "std::path::PathBuf::from($0)"
    let v184 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v182 v183
    let v185 : string = "$0.exists()"
    let v186 : bool = Fable.Core.RustInterop.emitRustExpr v184 v185
    let v187 : bool = v186 = false
    let v337 : string =
        if v187 then
            let v188 : string option = None
            let v189 : bool = true in let mutable _v188 = v188
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v190 : string = "std::env::current_dir()"
            let v191 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v190
            let v192 : string = "$0.unwrap()"
            let v193 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v191 v192
            let v194 : string = "$0.display()"
            let v195 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v193 v194
            let v196 : std_string_String option = None
            let v197 : bool = true in let mutable _v196 = v196
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v198 : string = @$"format!(""{{}}"", $0)"
            let v199 : std_string_String = Fable.Core.RustInterop.emitRustExpr v195 v198
            v199
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v200 : string = @$"format!(""{{}}"", $0)"
            let v201 : std_string_String = Fable.Core.RustInterop.emitRustExpr v195 v200
            v201
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v202 : string = @$"format!(""{{}}"", $0)"
            let v203 : std_string_String = Fable.Core.RustInterop.emitRustExpr v195 v202
            v203
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v204 : std_string_String = null |> unbox<std_string_String>
            v204
#endif
            
#if FABLE_COMPILER_PYTHON
            let v205 : std_string_String = null |> unbox<std_string_String>
            v205
#endif
            
#else
            let v206 : std_string_String = null |> unbox<std_string_String>
            v206
#endif
            |> fun x -> _v196 <- Some x
            let v207 : std_string_String = _v196.Value
            let v208 : string = "fable_library_rust::String_::fromString($0)"
            let v209 : string = Fable.Core.RustInterop.emitRustExpr v207 v208
            v209
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v210 : string = null |> unbox<string>
            v210
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v211 : string = null |> unbox<string>
            v211
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v212 : string = null |> unbox<string>
            v212
#endif
            
#if FABLE_COMPILER_PYTHON
            let v213 : string = null |> unbox<string>
            v213
#endif
            
#else
            let v214 : (unit -> string) = System.IO.Directory.GetCurrentDirectory
            let v215 : string = v214 ()
            v215
#endif
            |> fun x -> _v188 <- Some x
            let v216 : string = _v188.Value
            let v217 : string = method17(v216, v177)
            let v218 : string option = None
            let v219 : bool = true in let mutable _v218 = v218
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v220 : string = method20()
            let v221 : string = method21(v217)
            let v222 : string = method22()
            let v223 : string = $"regex::Regex::new(&$0).unwrap().replace_all(&$1, &*$2)"
            let v224 : std_borrow_Cow<Str> = Fable.Core.RustInterop.emitRustExpr struct (v220, v221, v222) v223
            let v225 : string = "String::from($0)"
            let v226 : std_string_String = Fable.Core.RustInterop.emitRustExpr v224 v225
            let v227 : string = "fable_library_rust::String_::fromString($0)"
            let v228 : string = Fable.Core.RustInterop.emitRustExpr v226 v227
            v228
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v229 : string = null |> unbox<string>
            v229
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v230 : string = null |> unbox<string>
            v230
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v231 : string = null |> unbox<string>
            v231
#endif
            
#if FABLE_COMPILER_PYTHON
            let v232 : string = null |> unbox<string>
            v232
#endif
            
#else
            let v233 : string = "^\\\\\\\\\\?\\\\"
            let v234 : string = ""
            let v235 : string = System.Text.RegularExpressions.Regex.Replace (v217, v233, v234)
            v235
#endif
            |> fun x -> _v218 <- Some x
            let v236 : string = _v218.Value
            let v237 : string = $"{v236.[0] |> string |> _.ToLower()}{v236.[1..]}"
            let v238 : string = "\\"
            let v239 : string = "/"
            let v240 : string = v237.Replace (v238, v239)
            let v241 : (string []) = v240.Split v239
            let v242 : (string []) = [||]
            let v243 : int32 = v241.Length
            let v244 : Mut4 = {l0 = 0; l1 = 0; l2 = v242} : Mut4
            while method23(v243, v244) do
                let v246 : int32 = v244.l0
                let v247 : int32 =  -v246
                let v248 : int32 = v247 + v243
                let v249 : int32 = v248 - 1
                let struct (v250 : int32, v251 : (string [])) = v244.l1, v244.l2
                let v252 : string = v241.[int v249]
                let v253 : bool = ".." = v252
                let struct (v295 : int32, v296 : (string [])) =
                    if v253 then
                        let v254 : int32 = v250 + 1
                        struct (v254, v251)
                    else
                        let v255 : bool = "." = v252
                        if v255 then
                            struct (v250, v251)
                        else
                            let v256 : bool = 0 = v250
                            if v256 then
                                let v257 : string = ":"
                                let v258 : bool = v252.EndsWith v257
                                if v258 then
                                    let v259 : string = $"{v216.[0]}:"
                                    let v260 : (string []) = [|v259|]
                                    let v261 : int32 = v260.Length
                                    let v262 : int32 = v251.Length
                                    let v263 : int32 = v261 + v262
                                    let v264 : (string []) = Array.zeroCreate<string> (v263)
                                    let v265 : Mut5 = {l0 = 0} : Mut5
                                    while method24(v263, v265) do
                                        let v267 : int32 = v265.l0
                                        let v268 : bool = v267 < v261
                                        let v272 : string =
                                            if v268 then
                                                let v269 : string = v260.[int v267]
                                                v269
                                            else
                                                let v270 : int32 = v267 - v261
                                                let v271 : string = v251.[int v270]
                                                v271
                                        v264.[int v267] <- v272
                                        let v273 : int32 = v267 + 1
                                        v265.l0 <- v273
                                        ()
                                    struct (0, v264)
                                else
                                    let v274 : (string []) = [|v252|]
                                    let v275 : int32 = v274.Length
                                    let v276 : int32 = v251.Length
                                    let v277 : int32 = v275 + v276
                                    let v278 : (string []) = Array.zeroCreate<string> (v277)
                                    let v279 : Mut5 = {l0 = 0} : Mut5
                                    while method24(v277, v279) do
                                        let v281 : int32 = v279.l0
                                        let v282 : bool = v281 < v275
                                        let v286 : string =
                                            if v282 then
                                                let v283 : string = v274.[int v281]
                                                v283
                                            else
                                                let v284 : int32 = v281 - v275
                                                let v285 : string = v251.[int v284]
                                                v285
                                        v278.[int v281] <- v286
                                        let v287 : int32 = v281 + 1
                                        v279.l0 <- v287
                                        ()
                                    struct (0, v278)
                            else
                                let v290 : int32 = v250 - 1
                                struct (v290, v251)
                let v297 : int32 = v246 + 1
                v244.l0 <- v297
                v244.l1 <- v295
                v244.l2 <- v296
                ()
            let struct (v298 : int32, v299 : (string [])) = v244.l1, v244.l2
            let v300 : string seq = seq { for i = 0 to v299.Length - 1 do yield v299.[i] }
            let v301 : char option = None
            let v302 : bool = true in let mutable _v301 = v301
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v303 : string = "std::path::MAIN_SEPARATOR"
            let v304 : char = Fable.Core.RustInterop.emitRustExpr () v303
            v304
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v305 : char = null |> unbox<char>
            v305
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v306 : char = null |> unbox<char>
            v306
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v307 : char = null |> unbox<char>
            v307
#endif
            
#if FABLE_COMPILER_PYTHON
            let v308 : char = null |> unbox<char>
            v308
#endif
            
#else
            let v309 : char = System.IO.Path.DirectorySeparatorChar
            v309
#endif
            |> fun x -> _v301 <- Some x
            let v310 : char = _v301.Value
            let v311 : (char -> string) = _.ToString()
            let v312 : string = v311 v310
            let v313 : string = method25(v312)
            let v314 : (string -> (string seq -> string)) = String.concat
            let v315 : (string seq -> string) = v314 v313
            v315 v300
        else
            let v317 : string = "std::fs::canonicalize(&*$0)"
            let v318 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v177 v317
            let v319 : string = "$0.unwrap()"
            let v320 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v318 v319
            let v321 : string = "$0.display()"
            let v322 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v320 v321
            let v323 : std_string_String option = None
            let v324 : bool = true in let mutable _v323 = v323
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v325 : string = @$"format!(""{{}}"", $0)"
            let v326 : std_string_String = Fable.Core.RustInterop.emitRustExpr v322 v325
            v326
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v327 : string = @$"format!(""{{}}"", $0)"
            let v328 : std_string_String = Fable.Core.RustInterop.emitRustExpr v322 v327
            v328
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v329 : string = @$"format!(""{{}}"", $0)"
            let v330 : std_string_String = Fable.Core.RustInterop.emitRustExpr v322 v329
            v330
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v331 : std_string_String = null |> unbox<std_string_String>
            v331
#endif
            
#if FABLE_COMPILER_PYTHON
            let v332 : std_string_String = null |> unbox<std_string_String>
            v332
#endif
            
#else
            let v333 : std_string_String = null |> unbox<std_string_String>
            v333
#endif
            |> fun x -> _v323 <- Some x
            let v334 : std_string_String = _v323.Value
            let v335 : string = "fable_library_rust::String_::fromString($0)"
            let v336 : string = Fable.Core.RustInterop.emitRustExpr v334 v335
            v336
    v337
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v338 : string = null |> unbox<string>
    v338
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v339 : string = null |> unbox<string>
    v339
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v340 : string = null |> unbox<string>
    v340
#endif
    
#if FABLE_COMPILER_PYTHON
    let v341 : string = null |> unbox<string>
    v341
#endif
    
#else
    let v342 : string = method26(v2)
    let v343 : (string -> string) = System.IO.Path.GetFullPath
    let v344 : string = v343 v342
    v344
#endif
    |> fun x -> _v175 <- Some x
    let v345 : string = _v175.Value
    let v346 : US0 = US0_1
    let v347 : (unit -> string) = closure11()
    let v348 : (unit -> string) = closure12(v0, v1, v174, v345)
    method5(v346, v347, v348)
    method27(v0, v1)
and closure2 () (v0 : (string [])) : int32 =
    let v1 : (unit -> struct (Mut0 * Mut1 * Mut2 * int64 option * Mut3)) = closure3()
    if State.trace_state.IsNone then State.trace_state <- v1 () |> Some
    let struct (v2 : Mut0, v3 : Mut1, v4 : Mut2, v5 : int64 option, v6 : Mut3) = State.trace_state.Value
    let v7 : US0 = US0_2
    v4.l0 <- v7
    let v8 : US0 = US0_1
    let v9 : (unit -> string) = closure5()
    let v10 : (unit -> string) = closure6(v0)
    method5(v8, v9, v10)
    let v11 : clap_Command = method0()
    let v12 : string = "clap::Command::get_matches($0)"
    let v13 : clap_ArgMatches = Fable.Core.RustInterop.emitRustExpr v11 v12
    let v14 : string = method9()
    let v15 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v16 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v14 v15
    let v17 : string = "clap::ArgMatches::get_one(&v13, v16).cloned()"
    let v18 : std_string_String option = Fable.Core.RustInterop.emitRustExpr () v17
    let v19 : (std_string_String -> US3) = method10()
    let v20 : US3 = US3_1
    let v21 : US3 = v18 |> Option.map v19 |> Option.defaultValue v20 
    let v25 : std_string_String =
        match v21 with
        | US3_1 -> (* None *)
            failwith<std_string_String> "Option does not have a value."
        | US3_0(v22) -> (* Some *)
            v22
    let v26 : string = "fable_library_rust::String_::fromString($0)"
    let v27 : string = Fable.Core.RustInterop.emitRustExpr v25 v26
    let v28 : string = method11()
    let v29 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v30 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v28 v29
    let v31 : string = "clap::ArgMatches::get_one(&v13, v30).cloned()"
    let v32 : std_string_String option = Fable.Core.RustInterop.emitRustExpr () v31
    let v33 : (std_string_String -> US3) = method10()
    let v34 : US3 = US3_1
    let v35 : US3 = v32 |> Option.map v33 |> Option.defaultValue v34 
    let v39 : std_string_String =
        match v35 with
        | US3_1 -> (* None *)
            failwith<std_string_String> "Option does not have a value."
        | US3_0(v36) -> (* Some *)
            v36
    let v40 : string = "fable_library_rust::String_::fromString($0)"
    let v41 : string = Fable.Core.RustInterop.emitRustExpr v39 v40
    let v42 : string = method12()
    let v43 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v44 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v42 v43
    let v45 : string = "clap::ArgMatches::get_one(&v13, v44).cloned()"
    let v46 : std_string_String option = Fable.Core.RustInterop.emitRustExpr () v45
    let v47 : (std_string_String -> US3) = method10()
    let v48 : US3 = US3_1
    let v49 : US3 = v46 |> Option.map v47 |> Option.defaultValue v48 
    let v53 : std_string_String =
        match v49 with
        | US3_1 -> (* None *)
            failwith<std_string_String> "Option does not have a value."
        | US3_0(v50) -> (* Some *)
            v50
    let v54 : string = "fable_library_rust::String_::fromString($0)"
    let v55 : string = Fable.Core.RustInterop.emitRustExpr v53 v54
    let v56 : string = method13()
    let v57 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v58 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v56 v57
    let v59 : string = "clap::ArgMatches::get_one(&v13, v58).cloned()"
    let v60 : std_string_String option = Fable.Core.RustInterop.emitRustExpr () v59
    let v61 : (std_string_String -> US3) = method10()
    let v62 : US3 = US3_1
    let v63 : US3 = v60 |> Option.map v61 |> Option.defaultValue v62 
    let v70 : US4 =
        match v63 with
        | US3_1 -> (* None *)
            US4_1
        | US3_0(v64) -> (* Some *)
            let v65 : string = "fable_library_rust::String_::fromString($0)"
            let v66 : string = Fable.Core.RustInterop.emitRustExpr v64 v65
            US4_0(v66)
    let v74 : string =
        match v70 with
        | US4_1 -> (* None *)
            let v72 : string = ""
            v72
        | US4_0(v71) -> (* Some *)
            v71
    let v75 : string = method14()
    let v76 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v77 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v75 v76
    let v78 : string = "clap::ArgMatches::get_one(&v13, v77).cloned()"
    let v79 : std_string_String option = Fable.Core.RustInterop.emitRustExpr () v78
    let v80 : (std_string_String -> US3) = method10()
    let v81 : US3 = US3_1
    let v82 : US3 = v79 |> Option.map v80 |> Option.defaultValue v81 
    let v89 : US4 =
        match v82 with
        | US3_1 -> (* None *)
            US4_1
        | US3_0(v83) -> (* Some *)
            let v84 : string = "fable_library_rust::String_::fromString($0)"
            let v85 : string = Fable.Core.RustInterop.emitRustExpr v83 v84
            US4_0(v85)
    match v89 with
    | US4_1 -> (* None *)
        ()
    | US4_0(v90) -> (* Some *)
        let v91 : bool = "Verbose" = v90
        let v107 : US0 =
            if v91 then
                US0_0
            else
                let v93 : bool = "Debug" = v90
                if v93 then
                    US0_1
                else
                    let v95 : bool = "Info" = v90
                    if v95 then
                        US0_2
                    else
                        let v97 : bool = "Warning" = v90
                        if v97 then
                            US0_3
                        else
                            let v99 : bool = "Critical" = v90
                            if v99 then
                                US0_4
                            else
                                let v101 : string = $"of_string trace_level / x: {v90}"
                                failwith<US0> v101
        v4.l0 <- v107
        ()
    let v108 : std_pin_Pin<Box<Dyn<std_future_Future<Result<string, std_string_String>>>>> = method15(v74, v55, v41, v27)
    let v109 : string = "futures_lite::future::block_on($0)"
    let v110 : Result<string, std_string_String> = Fable.Core.RustInterop.emitRustExpr v108 v109
    let v111 : string = "$0.unwrap()"
    let v112 : string = Fable.Core.RustInterop.emitRustExpr v110 v111
    let v113 : US0 = v4.l0
    let v115 : bool =
        match v113 with
        | US0_2 -> (* Info *)
            true
        | _ ->
            false
    if v115 then
        System.Console.WriteLine v112
        ()
    0
let v0 : (unit -> unit) = closure0()
let tests () = v0 ()
let v1 : ((string []) -> int32) = closure2()
let main args = v1 args
()
