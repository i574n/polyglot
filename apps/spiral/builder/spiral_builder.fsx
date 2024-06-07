#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::env::VarError")>]
#endif
type std_env_VarError = class end
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
module State = let mutable trace_state = None
type IOsEnviron = abstract environ: x: unit -> obj
type IPathJoin = abstract join: [<System.ParamArray>] paths: string[] -> string
type IFsExistsSync = abstract existsSync: path: string -> bool
type IPathDirname = abstract dirname: path: string -> string
#if FABLE_COMPILER
[<CompilationRepresentation (CompilationRepresentationFlags.ModuleSuffix)>]
module System =
 module Diagnostics =
  type Process = unit
  type DataReceivedEventArgs = unit
#endif
type ICryptoCreateHash = abstract createHash: x: string -> obj
type IHashlibSha256 = abstract sha256: x: unit -> obj
type Disposable (f : unit -> unit) = interface System.IDisposable with member _.Dispose () = f ()
type [<Struct>] US0 =
    | US0_0
    | US0_1
    | US0_2
    | US0_3
    | US0_4
and Mut0 = {mutable l0 : int64}
and Mut1 = {mutable l0 : bool}
and Mut2 = {mutable l0 : US0}
and Mut3 = {mutable l0 : (string -> unit)}
and [<Struct>] US1 =
    | US1_0 of f0_0 : int64
    | US1_1
and [<Struct>] US2 =
    | US2_0 of f0_0 : US0
    | US2_1
and [<Struct>] US3 =
    | US3_0 of f0_0 : string
    | US3_1
and [<Struct>] US4 =
    | US4_0 of f0_0 : std_string_String * f0_1 : clap_ArgMatches
    | US4_1
and [<Struct>] US5 =
    | US5_0 of f0_0 : std_string_String
    | US5_1
and [<Struct>] US8 =
    | US8_0
    | US8_1
and [<Struct>] US7 =
    | US7_0 of f0_0 : US8
    | US7_1
and [<Struct>] US6 =
    | US6_0 of f0_0 : US7
    | US6_1
and [<Struct>] US9 =
    | US9_0 of f0_0 : Vec<std_string_String>
    | US9_1
and [<Struct>] US10 =
    | US10_0
    | US10_1
    | US10_2
and [<Struct>] US11 =
    | US11_0 of f0_0 : US10
    | US11_1 of f1_0 : US10
    | US11_2 of f2_0 : US10
    | US11_3 of f3_0 : US10
    | US11_4 of f4_0 : US10
and [<Struct>] US12 =
    | US12_0 of f0_0 : string
    | US12_1 of f1_0 : string
and Mut4 = {mutable l0 : int32}
and UH0 =
    | UH0_0
    | UH0_1 of char * UH0
and [<Struct>] US14 =
    | US14_0
    | US14_1
and [<Struct>] US13 =
    | US13_0
    | US13_1 of f1_0 : US14
    | US13_2
and [<Struct>] US15 =
    | US15_0 of f0_0 : (string [])
    | US15_1 of f1_0 : string
and UH1 =
    | UH1_0
    | UH1_1 of string * UH1
and [<Struct>] US16 =
    | US16_0 of f0_0 : UH1 * f0_1 : string * f0_2 : System.Text.StringBuilder * f0_3 : int32 * f0_4 : int32
    | US16_1 of f1_0 : string
and [<Struct>] US17 =
    | US17_0 of f0_0 : char * f0_1 : string * f0_2 : System.Text.StringBuilder * f0_3 : int32 * f0_4 : int32
    | US17_1 of f1_0 : string
and [<Struct>] US18 =
    | US18_0 of f0_0 : char
    | US18_1
and [<Struct>] US19 =
    | US19_0 of f0_0 : string * f0_1 : string * f0_2 : System.Text.StringBuilder * f0_3 : int32 * f0_4 : int32
    | US19_1 of f1_0 : string
and UH2 =
    | UH2_0
    | UH2_1 of (struct (string * System.Text.StringBuilder * int32 * int32) -> US19) * UH2
and [<Struct>] US20 =
    | US20_0 of f0_0 : string * f0_1 : System.Text.StringBuilder * f0_2 : int32 * f0_3 : int32
    | US20_1 of f1_0 : string
and [<Struct>] US21 =
    | US21_0 of f0_0 : (string [])
    | US21_1 of f1_0 : string
and [<Struct>] US22 =
    | US22_0 of f0_0 : std_sync_Arc<std_sync_Mutex<std_process_Child option>>
    | US22_1 of f1_0 : std_string_String
and [<Struct>] US23 =
    | US23_0 of f0_0 : std_sync_Arc<std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>>
    | US23_1
and [<Struct>] US24 =
    | US24_0 of f0_0 : std_string_String
    | US24_1 of f1_0 : std_string_String
and [<Struct>] US25 =
    | US25_0 of f0_0 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit)
    | US25_1
and [<Struct>] US26 =
    | US26_0 of f0_0 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>>
    | US26_1
and [<Struct>] US27 =
    | US27_0 of f0_0 : std_process_Output
    | US27_1 of f1_0 : std_string_String
and [<Struct>] US28 =
    | US28_0 of f0_0 : int32
    | US28_1
and [<Struct>] US29 =
    | US29_0 of f0_0 : (struct (bool * string * int32) -> Async<unit>)
    | US29_1
and [<Struct>] US30 =
    | US30_0 of f0_0 : System.Threading.CancellationToken
    | US30_1
and Mut5 = {mutable l0 : int32; mutable l1 : int32; mutable l2 : (string [])}
and [<Struct>] US31 =
    | US31_0
    | US31_1 of f1_0 : std_string_String
and [<Struct>] US32 =
    | US32_0 of f0_0 : chrono_DateTime<chrono_Utc>
    | US32_1
and [<Struct>] US33 =
    | US33_0 of f0_0 : int32 * f0_1 : string
    | US33_1 of f1_0 : int32 * f1_1 : string
and [<Struct>] US34 =
    | US34_0 of f0_0 : std_collections_HashMap<string, string>
    | US34_1
and [<Struct>] US35 =
    | US35_0 of f0_0 : US3
    | US35_1
and UH3 =
    | UH3_0
    | UH3_1 of string * bool * UH3
and [<Struct>] US36 =
    | US36_0
    | US36_1
    | US36_2
and [<Struct>] US37 =
    | US37_0 of f0_0 : std_fs_FileType
    | US37_1 of f1_0 : std_string_String
and [<Struct>] US38 =
    | US38_0 of f0_0 : async_walkdir_DirEntry
    | US38_1 of f1_0 : std_string_String
and [<Struct>] US39 =
    | US39_0 of f0_0 : string * f0_1 : string
    | US39_1
and UH4 =
    | UH4_0
    | UH4_1 of string * string * UH4
let rec method0 () : clap_Command =
    let v0 : string = "command"
    let v1 : string = "r#\"" + v0 + "\"#"
    let v2 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v1 
    let v3 : string = "clap::Command::new($0)"
    let v4 : clap_Command = Fable.Core.RustInterop.emitRustExpr v2 v3 
    let v5 : string = "clap::Command::subcommand_required($0, true)"
    let v6 : clap_Command = Fable.Core.RustInterop.emitRustExpr v4 v5 
    let v7 : string = "fsharp"
    let v8 : string = "r#\"" + v7 + "\"#"
    let v9 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v8 
    let v10 : string = "clap::Command::new($0)"
    let v11 : clap_Command = Fable.Core.RustInterop.emitRustExpr v9 v10 
    let v12 : string = "spi-path"
    let v13 : string = "r#\"" + v12 + "\"#"
    let v14 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v13 
    let v15 : string = "clap::Arg::new($0)"
    let v16 : clap_Arg = Fable.Core.RustInterop.emitRustExpr v14 v15 
    let v17 : string = "$0.short($1)"
    let v18 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v16, 's') v17 
    let v19 : string = "r#\"" + v12 + "\"#"
    let v20 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v19 
    let v21 : string = "$0.long($1)"
    let v22 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v18, v20) v21 
    let v23 : string = "$0.required($1)"
    let v24 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v22, true) v23 
    let v25 : string = "clap::Command::arg($0, $1)"
    let v26 : clap_Command = Fable.Core.RustInterop.emitRustExpr struct (v11, v24) v25 
    let v27 : string = "clap::Command::subcommand($0, v26)"
    let v28 : clap_Command = Fable.Core.RustInterop.emitRustExpr v6 v27 
    let v29 : string = "cuda"
    let v30 : string = "r#\"" + v29 + "\"#"
    let v31 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v30 
    let v32 : string = "clap::Command::new($0)"
    let v33 : clap_Command = Fable.Core.RustInterop.emitRustExpr v31 v32 
    let v34 : string = "py-path"
    let v35 : string = "r#\"" + v34 + "\"#"
    let v36 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v35 
    let v37 : string = "clap::Arg::new($0)"
    let v38 : clap_Arg = Fable.Core.RustInterop.emitRustExpr v36 v37 
    let v39 : string = "$0.short($1)"
    let v40 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v38, 'p') v39 
    let v41 : string = "r#\"" + v34 + "\"#"
    let v42 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v41 
    let v43 : string = "$0.long($1)"
    let v44 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v40, v42) v43 
    let v45 : string = "$0.required($1)"
    let v46 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v44, true) v45 
    let v47 : string = "clap::Command::arg($0, $1)"
    let v48 : clap_Command = Fable.Core.RustInterop.emitRustExpr struct (v33, v46) v47 
    let v49 : string = "env"
    let v50 : string = "r#\"" + v49 + "\"#"
    let v51 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v50 
    let v52 : string = "clap::Arg::new($0)"
    let v53 : clap_Arg = Fable.Core.RustInterop.emitRustExpr v51 v52 
    let v54 : string = "$0.short($1)"
    let v55 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v53, 'e') v54 
    let v56 : string = "r#\"" + v49 + "\"#"
    let v57 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v56 
    let v58 : string = "$0.long($1)"
    let v59 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v55, v57) v58 
    let v60 : string list = []
    let v61 : string = "Poetry"
    let v62 : string list = v61 :: v60 
    let v63 : string = "Pip"
    let v64 : string list = v63 :: v62 
    let v65 : (string list -> (string [])) = List.toArray
    let v66 : (string []) = v65 v64
    let v67 : string = "$0.to_vec()"
    let v68 : Vec<string> = Fable.Core.RustInterop.emitRustExpr v66 v67 
    let v69 : string = "true; let _result : Vec<_> = v68.into_iter().map(|x| { //"
    let v70 : bool = Fable.Core.RustInterop.emitRustExpr () v69 
    let v71 : string = "x"
    let v72 : string = Fable.Core.RustInterop.emitRustExpr () v71 
    let v73 : string = "&*$0"
    let v74 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v72 v73 
    let v75 : string = "String::from($0)"
    let v76 : std_string_String = Fable.Core.RustInterop.emitRustExpr v74 v75 
    let v77 : string = "Box::new($0)"
    let v78 : Box<std_string_String> = Fable.Core.RustInterop.emitRustExpr v76 v77 
    let v79 : string = "Box::leak($0)"
    let v80 : Ref<Lifetime<StaticLifetime, Mut<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr v78 v79 
    let v81 : string = "clap::builder::PossibleValue::new(&**$0)"
    let v82 : clap_builder_PossibleValue = Fable.Core.RustInterop.emitRustExpr v80 v81 
    let v83 : string = "true; $0 }).collect::<Vec<_>>()"
    let v84 : bool = Fable.Core.RustInterop.emitRustExpr v82 v83 
    let v85 : string = "_result"
    let v86 : Vec<clap_builder_PossibleValue> = Fable.Core.RustInterop.emitRustExpr () v85 
    let v87 : string = "Into::<clap::builder::ValueParser>::into(clap::builder::PossibleValuesParser::new($0))"
    let v88 : clap_builder_ValueParser = Fable.Core.RustInterop.emitRustExpr v86 v87 
    let v89 : string = "$0.value_parser($1)"
    let v90 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v59, v88) v89 
    let v91 : string = "clap::Command::arg($0, $1)"
    let v92 : clap_Command = Fable.Core.RustInterop.emitRustExpr struct (v48, v90) v91 
    let v93 : string = "NAME"
    let v94 : string = "r#\"" + v93 + "\"#"
    let v95 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v94 
    let v96 : string = "VERSION"
    let v97 : string = "r#\"" + v96 + "\"#"
    let v98 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v97 
    let v99 : (Ref<Lifetime<StaticLifetime, Str>> []) = [|v95; v98|]
    let v100 : unativeint = 1 |> unativeint 
    let v101 : unativeint = 0 |> unativeint 
    let v102 : bool = v101 = v101 
    let v107 : clap_builder_ValueRange =
        if v102 then
            let v103 : string = "clap::builder::ValueRange::new(v100..)"
            let v104 : clap_builder_ValueRange = Fable.Core.RustInterop.emitRustExpr () v103 
            v104
        else
            let v105 : string = "clap::builder::ValueRange::new(v100..v101)"
            let v106 : clap_builder_ValueRange = Fable.Core.RustInterop.emitRustExpr () v105 
            v106
    let v108 : string = "deps"
    let v109 : string = "r#\"" + v108 + "\"#"
    let v110 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v109 
    let v111 : string = "clap::Arg::new($0)"
    let v112 : clap_Arg = Fable.Core.RustInterop.emitRustExpr v110 v111 
    let v113 : string = "$0.short($1)"
    let v114 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v112, 'd') v113 
    let v115 : string = "r#\"" + v108 + "\"#"
    let v116 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v115 
    let v117 : string = "$0.long($1)"
    let v118 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v114, v116) v117 
    let v119 : string = "$0.to_vec()"
    let v120 : Vec<Ref<Lifetime<StaticLifetime, Str>>> = Fable.Core.RustInterop.emitRustExpr v99 v119 
    let v121 : string = "$0.value_names($1)"
    let v122 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v118, v120) v121 
    let v123 : string = "$0.num_args($1)"
    let v124 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v122, v107) v123 
    let v125 : string = "clap::ArgAction::Append"
    let v126 : clap_ArgAction = Fable.Core.RustInterop.emitRustExpr () v125 
    let v127 : string = "$0.action($1)"
    let v128 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v124, v126) v127 
    let v129 : string = "clap::Command::arg($0, $1)"
    let v130 : clap_Command = Fable.Core.RustInterop.emitRustExpr struct (v92, v128) v129 
    let v131 : string = "clap::Command::subcommand($0, v130)"
    let v132 : clap_Command = Fable.Core.RustInterop.emitRustExpr v28 v131 
    let v133 : string = "fable"
    let v134 : string = "r#\"" + v133 + "\"#"
    let v135 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v134 
    let v136 : string = "clap::Command::new($0)"
    let v137 : clap_Command = Fable.Core.RustInterop.emitRustExpr v135 v136 
    let v138 : string = "fs-path"
    let v139 : string = "r#\"" + v138 + "\"#"
    let v140 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v139 
    let v141 : string = "clap::Arg::new($0)"
    let v142 : clap_Arg = Fable.Core.RustInterop.emitRustExpr v140 v141 
    let v143 : string = "$0.short($1)"
    let v144 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v142, 'f') v143 
    let v145 : string = "r#\"" + v138 + "\"#"
    let v146 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v145 
    let v147 : string = "$0.long($1)"
    let v148 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v144, v146) v147 
    let v149 : string = "$0.required($1)"
    let v150 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v148, true) v149 
    let v151 : string = "clap::Command::arg($0, $1)"
    let v152 : clap_Command = Fable.Core.RustInterop.emitRustExpr struct (v137, v150) v151 
    let v153 : string = "r#\"" + v0 + "\"#"
    let v154 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v153 
    let v155 : string = "clap::Arg::new($0)"
    let v156 : clap_Arg = Fable.Core.RustInterop.emitRustExpr v154 v155 
    let v157 : string = "$0.short($1)"
    let v158 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v156, 'c') v157 
    let v159 : string = "r#\"" + v0 + "\"#"
    let v160 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v159 
    let v161 : string = "$0.long($1)"
    let v162 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v158, v160) v161 
    let v163 : string = "clap::Command::arg($0, $1)"
    let v164 : clap_Command = Fable.Core.RustInterop.emitRustExpr struct (v152, v162) v163 
    let v165 : string = "clap::Command::subcommand($0, v164)"
    let v166 : clap_Command = Fable.Core.RustInterop.emitRustExpr v132 v165 
    let v167 : string = "rust"
    let v168 : string = "r#\"" + v167 + "\"#"
    let v169 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v168 
    let v170 : string = "clap::Command::new($0)"
    let v171 : clap_Command = Fable.Core.RustInterop.emitRustExpr v169 v170 
    let v172 : string = "r#\"" + v138 + "\"#"
    let v173 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v172 
    let v174 : string = "clap::Arg::new($0)"
    let v175 : clap_Arg = Fable.Core.RustInterop.emitRustExpr v173 v174 
    let v176 : string = "$0.short($1)"
    let v177 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v175, 'f') v176 
    let v178 : string = "r#\"" + v138 + "\"#"
    let v179 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v178 
    let v180 : string = "$0.long($1)"
    let v181 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v177, v179) v180 
    let v182 : string = "$0.required($1)"
    let v183 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v181, true) v182 
    let v184 : string = "clap::Command::arg($0, $1)"
    let v185 : clap_Command = Fable.Core.RustInterop.emitRustExpr struct (v171, v183) v184 
    let v186 : string = "r#\"" + v93 + "\"#"
    let v187 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v186 
    let v188 : string = "r#\"" + v96 + "\"#"
    let v189 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v188 
    let v190 : (Ref<Lifetime<StaticLifetime, Str>> []) = [|v187; v189|]
    let v191 : unativeint = 1 |> unativeint 
    let v192 : unativeint = 0 |> unativeint 
    let v193 : bool = v192 = v192 
    let v198 : clap_builder_ValueRange =
        if v193 then
            let v194 : string = "clap::builder::ValueRange::new(v191..)"
            let v195 : clap_builder_ValueRange = Fable.Core.RustInterop.emitRustExpr () v194 
            v195
        else
            let v196 : string = "clap::builder::ValueRange::new(v191..v192)"
            let v197 : clap_builder_ValueRange = Fable.Core.RustInterop.emitRustExpr () v196 
            v197
    let v199 : string = "r#\"" + v108 + "\"#"
    let v200 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v199 
    let v201 : string = "clap::Arg::new($0)"
    let v202 : clap_Arg = Fable.Core.RustInterop.emitRustExpr v200 v201 
    let v203 : string = "$0.short($1)"
    let v204 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v202, 'd') v203 
    let v205 : string = "r#\"" + v108 + "\"#"
    let v206 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v205 
    let v207 : string = "$0.long($1)"
    let v208 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v204, v206) v207 
    let v209 : string = "$0.to_vec()"
    let v210 : Vec<Ref<Lifetime<StaticLifetime, Str>>> = Fable.Core.RustInterop.emitRustExpr v190 v209 
    let v211 : string = "$0.value_names($1)"
    let v212 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v208, v210) v211 
    let v213 : string = "$0.num_args($1)"
    let v214 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v212, v198) v213 
    let v215 : string = "clap::ArgAction::Append"
    let v216 : clap_ArgAction = Fable.Core.RustInterop.emitRustExpr () v215 
    let v217 : string = "$0.action($1)"
    let v218 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v214, v216) v217 
    let v219 : string = "clap::Command::arg($0, $1)"
    let v220 : clap_Command = Fable.Core.RustInterop.emitRustExpr struct (v185, v218) v219 
    let v221 : string = "clap::Command::subcommand($0, v220)"
    let v222 : clap_Command = Fable.Core.RustInterop.emitRustExpr v166 v221 
    let v223 : string = "typescript"
    let v224 : string = "r#\"" + v223 + "\"#"
    let v225 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v224 
    let v226 : string = "clap::Command::new($0)"
    let v227 : clap_Command = Fable.Core.RustInterop.emitRustExpr v225 v226 
    let v228 : string = "r#\"" + v138 + "\"#"
    let v229 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v228 
    let v230 : string = "clap::Arg::new($0)"
    let v231 : clap_Arg = Fable.Core.RustInterop.emitRustExpr v229 v230 
    let v232 : string = "$0.short($1)"
    let v233 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v231, 'f') v232 
    let v234 : string = "r#\"" + v138 + "\"#"
    let v235 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v234 
    let v236 : string = "$0.long($1)"
    let v237 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v233, v235) v236 
    let v238 : string = "$0.required($1)"
    let v239 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v237, true) v238 
    let v240 : string = "clap::Command::arg($0, $1)"
    let v241 : clap_Command = Fable.Core.RustInterop.emitRustExpr struct (v227, v239) v240 
    let v242 : string = "r#\"" + v93 + "\"#"
    let v243 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v242 
    let v244 : string = "r#\"" + v96 + "\"#"
    let v245 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v244 
    let v246 : (Ref<Lifetime<StaticLifetime, Str>> []) = [|v243; v245|]
    let v247 : unativeint = 1 |> unativeint 
    let v248 : unativeint = 0 |> unativeint 
    let v249 : bool = v248 = v248 
    let v254 : clap_builder_ValueRange =
        if v249 then
            let v250 : string = "clap::builder::ValueRange::new(v247..)"
            let v251 : clap_builder_ValueRange = Fable.Core.RustInterop.emitRustExpr () v250 
            v251
        else
            let v252 : string = "clap::builder::ValueRange::new(v247..v248)"
            let v253 : clap_builder_ValueRange = Fable.Core.RustInterop.emitRustExpr () v252 
            v253
    let v255 : string = "r#\"" + v108 + "\"#"
    let v256 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v255 
    let v257 : string = "clap::Arg::new($0)"
    let v258 : clap_Arg = Fable.Core.RustInterop.emitRustExpr v256 v257 
    let v259 : string = "$0.short($1)"
    let v260 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v258, 'd') v259 
    let v261 : string = "r#\"" + v108 + "\"#"
    let v262 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v261 
    let v263 : string = "$0.long($1)"
    let v264 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v260, v262) v263 
    let v265 : string = "$0.to_vec()"
    let v266 : Vec<Ref<Lifetime<StaticLifetime, Str>>> = Fable.Core.RustInterop.emitRustExpr v246 v265 
    let v267 : string = "$0.value_names($1)"
    let v268 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v264, v266) v267 
    let v269 : string = "$0.num_args($1)"
    let v270 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v268, v254) v269 
    let v271 : string = "clap::ArgAction::Append"
    let v272 : clap_ArgAction = Fable.Core.RustInterop.emitRustExpr () v271 
    let v273 : string = "$0.action($1)"
    let v274 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v270, v272) v273 
    let v275 : string = "clap::Command::arg($0, $1)"
    let v276 : clap_Command = Fable.Core.RustInterop.emitRustExpr struct (v241, v274) v275 
    let v277 : string = "clap::Command::subcommand($0, v276)"
    let v278 : clap_Command = Fable.Core.RustInterop.emitRustExpr v222 v277 
    let v279 : string = "python"
    let v280 : string = "r#\"" + v279 + "\"#"
    let v281 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v280 
    let v282 : string = "clap::Command::new($0)"
    let v283 : clap_Command = Fable.Core.RustInterop.emitRustExpr v281 v282 
    let v284 : string = "r#\"" + v138 + "\"#"
    let v285 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v284 
    let v286 : string = "clap::Arg::new($0)"
    let v287 : clap_Arg = Fable.Core.RustInterop.emitRustExpr v285 v286 
    let v288 : string = "$0.short($1)"
    let v289 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v287, 'f') v288 
    let v290 : string = "r#\"" + v138 + "\"#"
    let v291 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v290 
    let v292 : string = "$0.long($1)"
    let v293 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v289, v291) v292 
    let v294 : string = "$0.required($1)"
    let v295 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v293, true) v294 
    let v296 : string = "clap::Command::arg($0, $1)"
    let v297 : clap_Command = Fable.Core.RustInterop.emitRustExpr struct (v283, v295) v296 
    let v298 : string = "r#\"" + v93 + "\"#"
    let v299 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v298 
    let v300 : string = "r#\"" + v96 + "\"#"
    let v301 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v300 
    let v302 : (Ref<Lifetime<StaticLifetime, Str>> []) = [|v299; v301|]
    let v303 : unativeint = 1 |> unativeint 
    let v304 : unativeint = 0 |> unativeint 
    let v305 : bool = v304 = v304 
    let v310 : clap_builder_ValueRange =
        if v305 then
            let v306 : string = "clap::builder::ValueRange::new(v303..)"
            let v307 : clap_builder_ValueRange = Fable.Core.RustInterop.emitRustExpr () v306 
            v307
        else
            let v308 : string = "clap::builder::ValueRange::new(v303..v304)"
            let v309 : clap_builder_ValueRange = Fable.Core.RustInterop.emitRustExpr () v308 
            v309
    let v311 : string = "r#\"" + v108 + "\"#"
    let v312 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v311 
    let v313 : string = "clap::Arg::new($0)"
    let v314 : clap_Arg = Fable.Core.RustInterop.emitRustExpr v312 v313 
    let v315 : string = "$0.short($1)"
    let v316 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v314, 'd') v315 
    let v317 : string = "r#\"" + v108 + "\"#"
    let v318 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v317 
    let v319 : string = "$0.long($1)"
    let v320 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v316, v318) v319 
    let v321 : string = "$0.to_vec()"
    let v322 : Vec<Ref<Lifetime<StaticLifetime, Str>>> = Fable.Core.RustInterop.emitRustExpr v302 v321 
    let v323 : string = "$0.value_names($1)"
    let v324 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v320, v322) v323 
    let v325 : string = "$0.num_args($1)"
    let v326 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v324, v310) v325 
    let v327 : string = "clap::ArgAction::Append"
    let v328 : clap_ArgAction = Fable.Core.RustInterop.emitRustExpr () v327 
    let v329 : string = "$0.action($1)"
    let v330 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v326, v328) v329 
    let v331 : string = "clap::Command::arg($0, $1)"
    let v332 : clap_Command = Fable.Core.RustInterop.emitRustExpr struct (v297, v330) v331 
    let v333 : string = "clap::Command::subcommand($0, v332)"
    let v334 : clap_Command = Fable.Core.RustInterop.emitRustExpr v278 v333 
    let v335 : string = "dib"
    let v336 : string = "r#\"" + v335 + "\"#"
    let v337 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v336 
    let v338 : string = "clap::Command::new($0)"
    let v339 : clap_Command = Fable.Core.RustInterop.emitRustExpr v337 v338 
    let v340 : string = "path"
    let v341 : string = "r#\"" + v340 + "\"#"
    let v342 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v341 
    let v343 : string = "clap::Arg::new($0)"
    let v344 : clap_Arg = Fable.Core.RustInterop.emitRustExpr v342 v343 
    let v345 : string = "$0.short($1)"
    let v346 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v344, 'p') v345 
    let v347 : string = "r#\"" + v340 + "\"#"
    let v348 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v347 
    let v349 : string = "$0.long($1)"
    let v350 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v346, v348) v349 
    let v351 : string = "$0.required($1)"
    let v352 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v350, true) v351 
    let v353 : string = "clap::Command::arg($0, $1)"
    let v354 : clap_Command = Fable.Core.RustInterop.emitRustExpr struct (v339, v352) v353 
    let v355 : string = "u8"
    let v356 : string = "clap::value_parser!(" + v355 + ").into()"
    let v357 : clap_builder_ValueParser = Fable.Core.RustInterop.emitRustExpr () v356 
    let v358 : string = "retries"
    let v359 : string = "r#\"" + v358 + "\"#"
    let v360 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v359 
    let v361 : string = "clap::Arg::new($0)"
    let v362 : clap_Arg = Fable.Core.RustInterop.emitRustExpr v360 v361 
    let v363 : string = "$0.short($1)"
    let v364 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v362, 'r') v363 
    let v365 : string = "r#\"" + v358 + "\"#"
    let v366 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v365 
    let v367 : string = "$0.long($1)"
    let v368 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v364, v366) v367 
    let v369 : string = "$0.value_parser($1)"
    let v370 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v368, v357) v369 
    let v371 : string = "clap::Command::arg($0, $1)"
    let v372 : clap_Command = Fable.Core.RustInterop.emitRustExpr struct (v354, v370) v371 
    let v373 : string = "working-directory"
    let v374 : string = "r#\"" + v373 + "\"#"
    let v375 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v374 
    let v376 : string = "clap::Arg::new($0)"
    let v377 : clap_Arg = Fable.Core.RustInterop.emitRustExpr v375 v376 
    let v378 : string = "$0.short($1)"
    let v379 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v377, 'w') v378 
    let v380 : string = "r#\"" + v373 + "\"#"
    let v381 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v380 
    let v382 : string = "$0.long($1)"
    let v383 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v379, v381) v382 
    let v384 : string = "clap::Command::arg($0, $1)"
    let v385 : clap_Command = Fable.Core.RustInterop.emitRustExpr struct (v372, v383) v384 
    let v386 : string = "clap::Command::subcommand($0, v385)"
    let v387 : clap_Command = Fable.Core.RustInterop.emitRustExpr v334 v386 
    v387
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
and method1 () : string =
    let v0 : string = "TRACE_LEVEL"
    v0
and method3 () : string =
    let v0 : string = ""
    v0
and method2 (v0 : string) : string =
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
    let v14 : string = method3()
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
    let v29 : string = method3()
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
    let v44 : string = method3()
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
    v54 
    #endif
#else
    let v55 : (string -> string) = System.Environment.GetEnvironmentVariable
    let v56 : string = v55 v0
    let mutable _v56 = None
    #if !FABLE_COMPILER && !WASM && !CONTRACT
    let v57 : (string -> string option) = Option.ofObj
    let v58 : string option = v57 v56
    v58 
    #else
    Some v56 
    #endif
    |> fun x -> _v56 <- Some x
    let v59 : string option = match _v56 with Some x -> x | None -> failwith "optionm'.of_obj / _v56=None"
    let v60 : US3 option = None
    let _v60 = ref v60 
    match v59 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v61 : string = x
    let v62 : US3 = US3_0(v61)
    v62 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v60.Value <- x
    let v63 : US3 option = _v60.Value 
    let v64 : US3 = US3_1
    let v65 : US3 = v63 |> Option.defaultValue v64 
    let v69 : string =
        match v65 with
        | US3_1 -> (* None *)
            let v67 : string = ""
            v67
        | US3_0(v66) -> (* Some *)
            v66
    v69 
    #endif
    |> fun x -> _v1 <- Some x
    let v70 : string = match _v1 with Some x -> x | None -> failwith "base.run_target / _v1=None"
    v70
and method4 () : string =
    let v0 : string = "AUTOMATION"
    v0
and closure3 () (v0 : string) : unit =
    ()
and closure2 () (v0 : US0) : struct (Mut0 * Mut1 * Mut2 * int64 option * Mut3) =
    let v1 : bool = true
    let mutable _v1 : struct (US1 * US2) option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = method1()
    let v3 : string = method2(v2)
    let v5 : bool = "Verbose" = v3
    let v9 : US2 =
        if v5 then
            let v6 : US0 = US0_0
            US2_0(v6)
        else
            US2_1
    let v54 : US2 =
        match v9 with
        | US2_1 -> (* None *)
            let v13 : bool = "Debug" = v3
            let v17 : US2 =
                if v13 then
                    let v14 : US0 = US0_1
                    US2_0(v14)
                else
                    US2_1
            match v17 with
            | US2_1 -> (* None *)
                let v21 : bool = "Info" = v3
                let v25 : US2 =
                    if v21 then
                        let v22 : US0 = US0_2
                        US2_0(v22)
                    else
                        US2_1
                match v25 with
                | US2_1 -> (* None *)
                    let v29 : bool = "Warning" = v3
                    let v33 : US2 =
                        if v29 then
                            let v30 : US0 = US0_3
                            US2_0(v30)
                        else
                            US2_1
                    match v33 with
                    | US2_1 -> (* None *)
                        let v37 : bool = "Critical" = v3
                        let v41 : US2 =
                            if v37 then
                                let v38 : US0 = US0_4
                                US2_0(v38)
                            else
                                US2_1
                        match v41 with
                        | US2_1 -> (* None *)
                            US2_1
                        | US2_0(v42) -> (* Some *)
                            US2_0(v42)
                    | US2_0(v34) -> (* Some *)
                        US2_0(v34)
                | US2_0(v26) -> (* Some *)
                    US2_0(v26)
            | US2_0(v18) -> (* Some *)
                US2_0(v18)
        | US2_0(v10) -> (* Some *)
            US2_0(v10)
    let v55 : string = method4()
    let v56 : string = method2(v55)
    let v58 : bool = v56 = "True"
    let v64 : US1 =
        if v58 then
            let v59 : System.DateTime = System.DateTime.Now
            let v60 : (System.DateTime -> int64) = _.Ticks
            let v61 : int64 = v60 v59
            US1_0(v61)
        else
            US1_1
    struct (v64, v54) 
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
    let v69 : string = method1()
    let v70 : string = method2(v69)
    let v72 : bool = "Verbose" = v70
    let v76 : US2 =
        if v72 then
            let v73 : US0 = US0_0
            US2_0(v73)
        else
            US2_1
    let v121 : US2 =
        match v76 with
        | US2_1 -> (* None *)
            let v80 : bool = "Debug" = v70
            let v84 : US2 =
                if v80 then
                    let v81 : US0 = US0_1
                    US2_0(v81)
                else
                    US2_1
            match v84 with
            | US2_1 -> (* None *)
                let v88 : bool = "Info" = v70
                let v92 : US2 =
                    if v88 then
                        let v89 : US0 = US0_2
                        US2_0(v89)
                    else
                        US2_1
                match v92 with
                | US2_1 -> (* None *)
                    let v96 : bool = "Warning" = v70
                    let v100 : US2 =
                        if v96 then
                            let v97 : US0 = US0_3
                            US2_0(v97)
                        else
                            US2_1
                    match v100 with
                    | US2_1 -> (* None *)
                        let v104 : bool = "Critical" = v70
                        let v108 : US2 =
                            if v104 then
                                let v105 : US0 = US0_4
                                US2_0(v105)
                            else
                                US2_1
                        match v108 with
                        | US2_1 -> (* None *)
                            US2_1
                        | US2_0(v109) -> (* Some *)
                            US2_0(v109)
                    | US2_0(v101) -> (* Some *)
                        US2_0(v101)
                | US2_0(v93) -> (* Some *)
                    US2_0(v93)
            | US2_0(v85) -> (* Some *)
                US2_0(v85)
        | US2_0(v77) -> (* Some *)
            US2_0(v77)
    let v122 : string = method4()
    let v123 : string = method2(v122)
    let v125 : bool = v123 = "True"
    let v131 : US1 =
        if v125 then
            let v126 : System.DateTime = System.DateTime.Now
            let v127 : (System.DateTime -> int64) = _.Ticks
            let v128 : int64 = v127 v126
            US1_0(v128)
        else
            US1_1
    struct (v131, v121) 
    #endif
#if FABLE_COMPILER_PYTHON
    let v132 : string = method1()
    let v133 : string = method2(v132)
    let v135 : bool = "Verbose" = v133
    let v139 : US2 =
        if v135 then
            let v136 : US0 = US0_0
            US2_0(v136)
        else
            US2_1
    let v184 : US2 =
        match v139 with
        | US2_1 -> (* None *)
            let v143 : bool = "Debug" = v133
            let v147 : US2 =
                if v143 then
                    let v144 : US0 = US0_1
                    US2_0(v144)
                else
                    US2_1
            match v147 with
            | US2_1 -> (* None *)
                let v151 : bool = "Info" = v133
                let v155 : US2 =
                    if v151 then
                        let v152 : US0 = US0_2
                        US2_0(v152)
                    else
                        US2_1
                match v155 with
                | US2_1 -> (* None *)
                    let v159 : bool = "Warning" = v133
                    let v163 : US2 =
                        if v159 then
                            let v160 : US0 = US0_3
                            US2_0(v160)
                        else
                            US2_1
                    match v163 with
                    | US2_1 -> (* None *)
                        let v167 : bool = "Critical" = v133
                        let v171 : US2 =
                            if v167 then
                                let v168 : US0 = US0_4
                                US2_0(v168)
                            else
                                US2_1
                        match v171 with
                        | US2_1 -> (* None *)
                            US2_1
                        | US2_0(v172) -> (* Some *)
                            US2_0(v172)
                    | US2_0(v164) -> (* Some *)
                        US2_0(v164)
                | US2_0(v156) -> (* Some *)
                    US2_0(v156)
            | US2_0(v148) -> (* Some *)
                US2_0(v148)
        | US2_0(v140) -> (* Some *)
            US2_0(v140)
    let v185 : string = method4()
    let v186 : string = method2(v185)
    let v188 : bool = v186 = "True"
    let v194 : US1 =
        if v188 then
            let v189 : System.DateTime = System.DateTime.Now
            let v190 : (System.DateTime -> int64) = _.Ticks
            let v191 : int64 = v190 v189
            US1_0(v191)
        else
            US1_1
    struct (v194, v184) 
    #endif
#else
    let v195 : string = method1()
    let v196 : string = method2(v195)
    let v198 : bool = "Verbose" = v196
    let v202 : US2 =
        if v198 then
            let v199 : US0 = US0_0
            US2_0(v199)
        else
            US2_1
    let v247 : US2 =
        match v202 with
        | US2_1 -> (* None *)
            let v206 : bool = "Debug" = v196
            let v210 : US2 =
                if v206 then
                    let v207 : US0 = US0_1
                    US2_0(v207)
                else
                    US2_1
            match v210 with
            | US2_1 -> (* None *)
                let v214 : bool = "Info" = v196
                let v218 : US2 =
                    if v214 then
                        let v215 : US0 = US0_2
                        US2_0(v215)
                    else
                        US2_1
                match v218 with
                | US2_1 -> (* None *)
                    let v222 : bool = "Warning" = v196
                    let v226 : US2 =
                        if v222 then
                            let v223 : US0 = US0_3
                            US2_0(v223)
                        else
                            US2_1
                    match v226 with
                    | US2_1 -> (* None *)
                        let v230 : bool = "Critical" = v196
                        let v234 : US2 =
                            if v230 then
                                let v231 : US0 = US0_4
                                US2_0(v231)
                            else
                                US2_1
                        match v234 with
                        | US2_1 -> (* None *)
                            US2_1
                        | US2_0(v235) -> (* Some *)
                            US2_0(v235)
                    | US2_0(v227) -> (* Some *)
                        US2_0(v227)
                | US2_0(v219) -> (* Some *)
                    US2_0(v219)
            | US2_0(v211) -> (* Some *)
                US2_0(v211)
        | US2_0(v203) -> (* Some *)
            US2_0(v203)
    let v248 : string = method4()
    let v249 : string = method2(v248)
    let v251 : bool = v249 = "True"
    let v257 : US1 =
        if v251 then
            let v252 : System.DateTime = System.DateTime.Now
            let v253 : (System.DateTime -> int64) = _.Ticks
            let v254 : int64 = v253 v252
            US1_0(v254)
        else
            US1_1
    struct (v257, v247) 
    #endif
    |> fun x -> _v1 <- Some x
    let struct (v258 : US1, v259 : US2) = match _v1 with Some x -> x | None -> failwith "base.run_target / _v1=None"
    let v260 : Mut1 = {l0 = true} : Mut1
    let v261 : Mut0 = {l0 = 0L} : Mut0
    let v264 : US0 =
        match v259 with
        | US2_1 -> (* None *)
            v0
        | US2_0(v262) -> (* Some *)
            v262
    let v265 : Mut2 = {l0 = v264} : Mut2
    let v266 : (string -> unit) = closure3()
    let v267 : Mut3 = {l0 = v266} : Mut3
    let v272 : int64 option =
        match v258 with
        | US1_1 -> (* None *)
            let v270 : int64 option = None
            v270
        | US1_0(v268) -> (* Some *)
            let v269 : int64 option = Some v268 
            v269
    struct (v261, v260, v265, v272, v267)
and closure4 () () : string =
    let v0 : string = $"spiral_builder.main"
    v0
and closure6 () () : string =
    let v0 : string = ""
    v0
and closure5 (v0 : (string [])) () : string =
    let v1 : (unit -> string) = closure6()
    let v2 : string = $"args: {v0} / {v1 ()}"
    v2
and method6 () : string =
    let v0 : string = "hh:mm:ss"
    v0
and method7 () : string =
    let v0 : string = ""
    v0
and method8 () : string =
    let v0 : string = "HH:mm:ss"
    v0
and closure7 (v0 : US0, v1 : (unit -> string), v2 : (unit -> string)) () : string =
    let v3 : (US0 -> struct (Mut0 * Mut1 * Mut2 * int64 option * Mut3)) = closure2()
    let v4 : US0 = US0_0
    if State.trace_state.IsNone then State.trace_state <- v3 v4 |> Some
    let struct (v5 : Mut0, v6 : Mut1, v7 : Mut2, v8 : int64 option, v9 : Mut3) = State.trace_state.Value
    let v10 : bool = true
    let mutable _v10 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v11 : US1 option = None
    let _v11 = ref v11 
    match v8 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v12 : int64 = x
    let v13 : US1 = US1_0(v12)
    v13 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v11.Value <- x
    let v14 : US1 option = _v11.Value 
    let v15 : US1 = US1_1
    let v16 : US1 = v14 |> Option.defaultValue v15 
    let v35 : System.DateTime =
        match v16 with
        | US1_1 -> (* None *)
            let v33 : System.DateTime = System.DateTime.Now
            v33
        | US1_0(v17) -> (* Some *)
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
    let v36 : string = method6()
    let v37 : string = v35.ToString v36 
    v37 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v38 : US1 option = None
    let _v38 = ref v38 
    match v8 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v39 : int64 = x
    let v40 : US1 = US1_0(v39)
    v40 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v38.Value <- x
    let v41 : US1 option = _v38.Value 
    let v42 : US1 = US1_1
    let v43 : US1 = v41 |> Option.defaultValue v42 
    let v62 : System.DateTime =
        match v43 with
        | US1_1 -> (* None *)
            let v60 : System.DateTime = System.DateTime.Now
            v60
        | US1_0(v44) -> (* Some *)
            let v45 : System.DateTime = System.DateTime.Now
            let v46 : (System.DateTime -> int64) = _.Ticks
            let v47 : int64 = v46 v45
            let v48 : int64 = v47 - v44
            let v49 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v50 : System.TimeSpan = v49 v48
            let v51 : (System.TimeSpan -> int32) = _.Hours
            let v52 : int32 = v51 v50
            let v53 : (System.TimeSpan -> int32) = _.Minutes
            let v54 : int32 = v53 v50
            let v55 : (System.TimeSpan -> int32) = _.Seconds
            let v56 : int32 = v55 v50
            let v57 : (System.TimeSpan -> int32) = _.Milliseconds
            let v58 : int32 = v57 v50
            let v59 : System.DateTime = System.DateTime (1, 1, 1, v52, v54, v56, v58)
            v59
    let v63 : string = method6()
    let v64 : string = v62.ToString v63 
    v64 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v65 : string = method7()
    v65 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v66 : US1 option = None
    let _v66 = ref v66 
    match v8 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v67 : int64 = x
    let v68 : US1 = US1_0(v67)
    v68 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v66.Value <- x
    let v69 : US1 option = _v66.Value 
    let v70 : US1 = US1_1
    let v71 : US1 = v69 |> Option.defaultValue v70 
    let v90 : System.DateTime =
        match v71 with
        | US1_1 -> (* None *)
            let v88 : System.DateTime = System.DateTime.Now
            v88
        | US1_0(v72) -> (* Some *)
            let v73 : System.DateTime = System.DateTime.Now
            let v74 : (System.DateTime -> int64) = _.Ticks
            let v75 : int64 = v74 v73
            let v76 : int64 = v75 - v72
            let v77 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v78 : System.TimeSpan = v77 v76
            let v79 : (System.TimeSpan -> int32) = _.Hours
            let v80 : int32 = v79 v78
            let v81 : (System.TimeSpan -> int32) = _.Minutes
            let v82 : int32 = v81 v78
            let v83 : (System.TimeSpan -> int32) = _.Seconds
            let v84 : int32 = v83 v78
            let v85 : (System.TimeSpan -> int32) = _.Milliseconds
            let v86 : int32 = v85 v78
            let v87 : System.DateTime = System.DateTime (1, 1, 1, v80, v82, v84, v86)
            v87
    let v91 : string = method8()
    let v92 : string = v90.ToString v91 
    v92 
    #endif
#if FABLE_COMPILER_PYTHON
    let v93 : US1 option = None
    let _v93 = ref v93 
    match v8 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v94 : int64 = x
    let v95 : US1 = US1_0(v94)
    v95 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v93.Value <- x
    let v96 : US1 option = _v93.Value 
    let v97 : US1 = US1_1
    let v98 : US1 = v96 |> Option.defaultValue v97 
    let v117 : System.DateTime =
        match v98 with
        | US1_1 -> (* None *)
            let v115 : System.DateTime = System.DateTime.Now
            v115
        | US1_0(v99) -> (* Some *)
            let v100 : System.DateTime = System.DateTime.Now
            let v101 : (System.DateTime -> int64) = _.Ticks
            let v102 : int64 = v101 v100
            let v103 : int64 = v102 - v99
            let v104 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v105 : System.TimeSpan = v104 v103
            let v106 : (System.TimeSpan -> int32) = _.Hours
            let v107 : int32 = v106 v105
            let v108 : (System.TimeSpan -> int32) = _.Minutes
            let v109 : int32 = v108 v105
            let v110 : (System.TimeSpan -> int32) = _.Seconds
            let v111 : int32 = v110 v105
            let v112 : (System.TimeSpan -> int32) = _.Milliseconds
            let v113 : int32 = v112 v105
            let v114 : System.DateTime = System.DateTime (1, 1, 1, v107, v109, v111, v113)
            v114
    let v118 : string = method8()
    let v119 : string = v117.ToString v118 
    v119 
    #endif
#else
    let v120 : US1 option = None
    let _v120 = ref v120 
    match v8 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v121 : int64 = x
    let v122 : US1 = US1_0(v121)
    v122 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v120.Value <- x
    let v123 : US1 option = _v120.Value 
    let v124 : US1 = US1_1
    let v125 : US1 = v123 |> Option.defaultValue v124 
    let v144 : System.DateTime =
        match v125 with
        | US1_1 -> (* None *)
            let v142 : System.DateTime = System.DateTime.Now
            v142
        | US1_0(v126) -> (* Some *)
            let v127 : System.DateTime = System.DateTime.Now
            let v128 : (System.DateTime -> int64) = _.Ticks
            let v129 : int64 = v128 v127
            let v130 : int64 = v129 - v126
            let v131 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v132 : System.TimeSpan = v131 v130
            let v133 : (System.TimeSpan -> int32) = _.Hours
            let v134 : int32 = v133 v132
            let v135 : (System.TimeSpan -> int32) = _.Minutes
            let v136 : int32 = v135 v132
            let v137 : (System.TimeSpan -> int32) = _.Seconds
            let v138 : int32 = v137 v132
            let v139 : (System.TimeSpan -> int32) = _.Milliseconds
            let v140 : int32 = v139 v132
            let v141 : System.DateTime = System.DateTime (1, 1, 1, v134, v136, v138, v140)
            v141
    let v145 : string = method8()
    let v146 : string = v144.ToString v145 
    v146 
    #endif
    |> fun x -> _v10 <- Some x
    let v147 : string = match _v10 with Some x -> x | None -> failwith "base.run_target / _v10=None"
    let v150 : bool =
        match v0 with
        | US0_0 -> (* Verbose *)
            true
        | _ ->
            false
    let v154 : US3 =
        if v150 then
            let v151 : string = "Verbose"
            US3_0(v151)
        else
            US3_1
    let v203 : US3 =
        match v154 with
        | US3_1 -> (* None *)
            let v159 : bool =
                match v0 with
                | US0_1 -> (* Debug *)
                    true
                | _ ->
                    false
            let v163 : US3 =
                if v159 then
                    let v160 : string = "Debug"
                    US3_0(v160)
                else
                    US3_1
            match v163 with
            | US3_1 -> (* None *)
                let v168 : bool =
                    match v0 with
                    | US0_2 -> (* Info *)
                        true
                    | _ ->
                        false
                let v172 : US3 =
                    if v168 then
                        let v169 : string = "Info"
                        US3_0(v169)
                    else
                        US3_1
                match v172 with
                | US3_1 -> (* None *)
                    let v177 : bool =
                        match v0 with
                        | US0_3 -> (* Warning *)
                            true
                        | _ ->
                            false
                    let v181 : US3 =
                        if v177 then
                            let v178 : string = "Warning"
                            US3_0(v178)
                        else
                            US3_1
                    match v181 with
                    | US3_1 -> (* None *)
                        let v186 : bool =
                            match v0 with
                            | US0_4 -> (* Critical *)
                                true
                            | _ ->
                                false
                        let v190 : US3 =
                            if v186 then
                                let v187 : string = "Critical"
                                US3_0(v187)
                            else
                                US3_1
                        match v190 with
                        | US3_1 -> (* None *)
                            US3_1
                        | US3_0(v191) -> (* Some *)
                            US3_0(v191)
                    | US3_0(v182) -> (* Some *)
                        US3_0(v182)
                | US3_0(v173) -> (* Some *)
                    US3_0(v173)
            | US3_0(v164) -> (* Some *)
                US3_0(v164)
        | US3_0(v155) -> (* Some *)
            US3_0(v155)
    let v207 : string =
        match v203 with
        | US3_1 -> (* None *)
            failwith<string> "Option does not have a value."
        | US3_0(v204) -> (* Some *)
            v204
    let v208 : (unit -> string) = v207.ToLower
    let v209 : string = v208 ()
    let v210 : string = v209.PadLeft (7, ' ')
    let v211 : bool = true
    let mutable _v211 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v226 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v220 : string = "inline_colorization::color_bright_red"
            let v221 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v220 
            v221
        | US0_1 -> (* Debug *)
            let v214 : string = "inline_colorization::color_bright_blue"
            let v215 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v214 
            v215
        | US0_2 -> (* Info *)
            let v216 : string = "inline_colorization::color_bright_green"
            let v217 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v216 
            v217
        | US0_0 -> (* Verbose *)
            let v212 : string = "inline_colorization::color_bright_black"
            let v213 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v212 
            v213
        | US0_3 -> (* Warning *)
            let v218 : string = "inline_colorization::color_yellow"
            let v219 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v218 
            v219
    let v227 : string = "&*$0"
    let v228 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v210 v227 
    let v229 : string = "inline_colorization::color_reset"
    let v230 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v229 
    let v231 : string = "\"{v226}{v228}{v230}\""
    let v232 : string = @$"format!(" + v231 + ")"
    let v233 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v232 
    let v234 : string = "fable_library_rust::String_::fromString($0)"
    let v235 : string = Fable.Core.RustInterop.emitRustExpr v233 v234 
    v235 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v250 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v244 : string = "inline_colorization::color_bright_red"
            let v245 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v244 
            v245
        | US0_1 -> (* Debug *)
            let v238 : string = "inline_colorization::color_bright_blue"
            let v239 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v238 
            v239
        | US0_2 -> (* Info *)
            let v240 : string = "inline_colorization::color_bright_green"
            let v241 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v240 
            v241
        | US0_0 -> (* Verbose *)
            let v236 : string = "inline_colorization::color_bright_black"
            let v237 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v236 
            v237
        | US0_3 -> (* Warning *)
            let v242 : string = "inline_colorization::color_yellow"
            let v243 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v242 
            v243
    let v251 : string = "&*$0"
    let v252 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v210 v251 
    let v253 : string = "inline_colorization::color_reset"
    let v254 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v253 
    let v255 : string = "\"{v250}{v252}{v254}\""
    let v256 : string = @$"format!(" + v255 + ")"
    let v257 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v256 
    let v258 : string = "fable_library_rust::String_::fromString($0)"
    let v259 : string = Fable.Core.RustInterop.emitRustExpr v257 v258 
    v259 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v274 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v268 : string = "inline_colorization::color_bright_red"
            let v269 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v268 
            v269
        | US0_1 -> (* Debug *)
            let v262 : string = "inline_colorization::color_bright_blue"
            let v263 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v262 
            v263
        | US0_2 -> (* Info *)
            let v264 : string = "inline_colorization::color_bright_green"
            let v265 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v264 
            v265
        | US0_0 -> (* Verbose *)
            let v260 : string = "inline_colorization::color_bright_black"
            let v261 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v260 
            v261
        | US0_3 -> (* Warning *)
            let v266 : string = "inline_colorization::color_yellow"
            let v267 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v266 
            v267
    let v275 : string = "&*$0"
    let v276 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v210 v275 
    let v277 : string = "inline_colorization::color_reset"
    let v278 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v277 
    let v279 : string = "\"{v274}{v276}{v278}\""
    let v280 : string = @$"format!(" + v279 + ")"
    let v281 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v280 
    let v282 : string = "fable_library_rust::String_::fromString($0)"
    let v283 : string = Fable.Core.RustInterop.emitRustExpr v281 v282 
    v283 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    v210 
    #endif
#if FABLE_COMPILER_PYTHON
    v210 
    #endif
#else
    v210 
    #endif
    |> fun x -> _v211 <- Some x
    let v284 : string = match _v211 with Some x -> x | None -> failwith "base.run_target / _v211=None"
    let v285 : int64 = v5.l0
    let v286 : string = $"{v147} {v284} #{v285} %s{v1 ()} / %s{v2 ()}"
    let v287 : (char []) = [||]
    let v288 : string = v286.TrimStart v287 
    let v289 : (char []) = [|' '; '/'|]
    let v290 : string = v288.TrimEnd v289 
    v290
and method9 (v0 : US0, v1 : (unit -> string)) : unit =
    let v2 : (US0 -> struct (Mut0 * Mut1 * Mut2 * int64 option * Mut3)) = closure2()
    let v3 : US0 = US0_0
    if State.trace_state.IsNone then State.trace_state <- v2 v3 |> Some
    let struct (v4 : Mut0, v5 : Mut1, v6 : Mut2, v7 : int64 option, v8 : Mut3) = State.trace_state.Value
    let v9 : US0 = US0_0
    if State.trace_state.IsNone then State.trace_state <- v2 v9 |> Some
    let struct (v10 : Mut0, v11 : Mut1, v12 : Mut2, v13 : int64 option, v14 : Mut3) = State.trace_state.Value
    let v15 : US0 = v12.l0
    let v16 : bool = v11.l0
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
        let v29 : (string -> unit) = v8.l0
        v29 v24
and method5 (v0 : US0, v1 : (unit -> string), v2 : (unit -> string)) : unit =
    let v3 : (unit -> string) = closure7(v0, v1, v2)
    method9(v0, v3)
and closure8 () (v0 : Ref<Str>) : std_string_String =
    let v1 : string = "String::from($0)"
    let v2 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v1 
    v2
and method11 () : string =
    let v0 : string = "py-path"
    v0
and method12 () : string =
    let v0 : string = "env"
    v0
and method13 () : string =
    let v0 : string = "deps"
    v0
and method14 () : string =
    let v0 : bool = true
    let mutable _v0 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1 : string = "std::env::current_dir()"
    let v2 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v1 
    let v3 : string = "$0.unwrap()"
    let v4 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v2 v3 
    let v5 : string = "$0.display()"
    let v6 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v4 v5 
    let v7 : bool = true
    let mutable _v7 : std_string_String option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v8 : string = "format!(\"{}\", $0)"
    let v9 : std_string_String = Fable.Core.RustInterop.emitRustExpr v6 v8 
    v9 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v10 : string = "format!(\"{}\", $0)"
    let v11 : std_string_String = Fable.Core.RustInterop.emitRustExpr v6 v10 
    v11 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v12 : string = "format!(\"{}\", $0)"
    let v13 : std_string_String = Fable.Core.RustInterop.emitRustExpr v6 v12 
    v13 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v14 : std_string_String = null |> unbox<std_string_String>
    v14 
    #endif
#if FABLE_COMPILER_PYTHON
    let v15 : std_string_String = null |> unbox<std_string_String>
    v15 
    #endif
#else
    let v16 : std_string_String = null |> unbox<std_string_String>
    v16 
    #endif
    |> fun x -> _v7 <- Some x
    let v17 : std_string_String = match _v7 with Some x -> x | None -> failwith "base.run_target / _v7=None"
    let v18 : string = "fable_library_rust::String_::fromString($0)"
    let v19 : string = Fable.Core.RustInterop.emitRustExpr v17 v18 
    v19 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v20 : (unit -> string) = System.IO.Directory.GetCurrentDirectory
    let v21 : string = v20 ()
    v21 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v22 : string = null |> unbox<string>
    v22 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v23 : (unit -> string) = System.IO.Directory.GetCurrentDirectory
    let v24 : string = v23 ()
    v24 
    #endif
#if FABLE_COMPILER_PYTHON
    let v25 : (unit -> string) = System.IO.Directory.GetCurrentDirectory
    let v26 : string = v25 ()
    v26 
    #endif
#else
    let v27 : (unit -> string) = System.IO.Directory.GetCurrentDirectory
    let v28 : string = v27 ()
    v28 
    #endif
    |> fun x -> _v0 <- Some x
    let v29 : string = match _v0 with Some x -> x | None -> failwith "base.run_target / _v0=None"
    v29
and method17 (v0 : string) : string =
    v0
and method16 (v0 : string, v1 : string) : struct (string * string) =
    let v2 : string = method17(v0)
    struct (v1, v2)
and method15 (v0 : string, v1 : string) : string =
    let v2 : bool = true
    let mutable _v2 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : string = "&*$0"
    let v4 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v3 
    let v5 : string = "String::from($0)"
    let v6 : std_string_String = Fable.Core.RustInterop.emitRustExpr v4 v5 
    let v7 : string = "std::path::PathBuf::from($0)"
    let v8 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v6 v7 
    let v9 : string = "&*$0"
    let v10 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1 v9 
    let v11 : string = "String::from($0)"
    let v12 : std_string_String = Fable.Core.RustInterop.emitRustExpr v10 v11 
    let v13 : string = "$0.join($1)"
    let v14 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr struct (v8, v12) v13 
    let v15 : string = "$0.display()"
    let v16 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v14 v15 
    let v17 : bool = true
    let mutable _v17 : std_string_String option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v18 : string = "format!(\"{}\", $0)"
    let v19 : std_string_String = Fable.Core.RustInterop.emitRustExpr v16 v18 
    v19 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v20 : string = "format!(\"{}\", $0)"
    let v21 : std_string_String = Fable.Core.RustInterop.emitRustExpr v16 v20 
    v21 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v22 : string = "format!(\"{}\", $0)"
    let v23 : std_string_String = Fable.Core.RustInterop.emitRustExpr v16 v22 
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
    |> fun x -> _v17 <- Some x
    let v27 : std_string_String = match _v17 with Some x -> x | None -> failwith "base.run_target / _v17=None"
    let v28 : string = "fable_library_rust::String_::fromString($0)"
    let v29 : string = Fable.Core.RustInterop.emitRustExpr v27 v28 
    v29 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v30 : US10 = US10_1
    let v31 : US11 = US11_2(v30)
    let v32 : string = $"file_system.(</>) / target: {v31} / a: {v0} / b: {v1}"
    let v33 : string = failwith<string> v32
    v33 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v34 : string = null |> unbox<string>
    v34 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v35 : string = "path"
    let v36 : IPathJoin = Fable.Core.JsInterop.importAll v35 
    let struct (v37 : string, v38 : string) = method16(v1, v0)
    let v39 : string = "v36.join($0, $1)"
    let v40 : string = Fable.Core.JsInterop.emitJsExpr struct (v37, v38) v39 
    v40 
    #endif
#if FABLE_COMPILER_PYTHON
    let v41 : US10 = US10_0
    let v42 : US11 = US11_4(v41)
    let v43 : string = $"file_system.(</>) / target: {v42} / a: {v0} / b: {v1}"
    let v44 : string = failwith<string> v43
    v44 
    #endif
#else
    let v45 : string = System.IO.Path.Combine (v0, v1)
    v45 
    #endif
    |> fun x -> _v2 <- Some x
    let v46 : string = match _v2 with Some x -> x | None -> failwith "base.run_target / _v2=None"
    v46
and method19 (v0 : string) : bool =
    let v1 : bool = true
    let mutable _v1 : bool option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = "&*$0"
    let v3 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v2 
    let v4 : string = "String::from($0)"
    let v5 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3 v4 
    let v6 : string = "std::path::PathBuf::from($0)"
    let v7 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v5 v6 
    let v8 : string = "$0.exists()"
    let v9 : bool = Fable.Core.RustInterop.emitRustExpr v7 v8 
    let v15 : bool =
        if v9 then
            true
        else
            let v10 : string = "$0.is_dir()"
            let v11 : bool = Fable.Core.RustInterop.emitRustExpr v7 v10 
            if v11 then
                true
            else
                let v12 : string = "$0.is_symlink()"
                let v13 : bool = Fable.Core.RustInterop.emitRustExpr v7 v12 
                v13
    v15 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v16 : bool = null |> unbox<bool>
    v16 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v17 : bool = null |> unbox<bool>
    v17 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v18 : string = "fs"
    let v19 : IFsExistsSync = Fable.Core.JsInterop.importAll v18 
    let v20 : string = "$0.existsSync($1)"
    let v21 : bool = Fable.Core.JsInterop.emitJsExpr struct (v19, v0) v20 
    v21 
    #endif
#if FABLE_COMPILER_PYTHON
    let v22 : bool = null |> unbox<bool>
    v22 
    #endif
#else
    let v23 : (string -> bool) = System.IO.Directory.Exists
    let v24 : bool = v23 v0
    v24 
    #endif
    |> fun x -> _v1 <- Some x
    let v25 : bool = match _v1 with Some x -> x | None -> failwith "base.run_target / _v1=None"
    v25
and method21 (v0 : string) : string option =
    let v1 : bool = true
    let mutable _v1 : US3 option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = "&*$0"
    let v3 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v2 
    let v4 : string = "String::from($0)"
    let v5 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3 v4 
    let v6 : string = "std::path::PathBuf::from($0)"
    let v7 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v5 v6 
    let v8 : string = "$0.parent().map(std::path::PathBuf::from)"
    let v9 : std_path_PathBuf option = Fable.Core.RustInterop.emitRustExpr v7 v8 
    let v10 : string = "$0?"
    let v11 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v9 v10 
    let v12 : string = "$0.display()"
    let v13 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v11 v12 
    let v14 : bool = true
    let mutable _v14 : std_string_String option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v15 : string = "format!(\"{}\", $0)"
    let v16 : std_string_String = Fable.Core.RustInterop.emitRustExpr v13 v15 
    v16 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v17 : string = "format!(\"{}\", $0)"
    let v18 : std_string_String = Fable.Core.RustInterop.emitRustExpr v13 v17 
    v18 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v19 : string = "format!(\"{}\", $0)"
    let v20 : std_string_String = Fable.Core.RustInterop.emitRustExpr v13 v19 
    v20 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v21 : std_string_String = null |> unbox<std_string_String>
    v21 
    #endif
#if FABLE_COMPILER_PYTHON
    let v22 : std_string_String = null |> unbox<std_string_String>
    v22 
    #endif
#else
    let v23 : std_string_String = null |> unbox<std_string_String>
    v23 
    #endif
    |> fun x -> _v14 <- Some x
    let v24 : std_string_String = match _v14 with Some x -> x | None -> failwith "base.run_target / _v14=None"
    let v25 : string = "fable_library_rust::String_::fromString($0)"
    let v26 : string = Fable.Core.RustInterop.emitRustExpr v24 v25 
    let v27 : US3 = US3_0(v26)
    v27 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v28 : US3 = null |> unbox<US3>
    v28 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v29 : US3 = null |> unbox<US3>
    v29 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v30 : string = "path"
    let v31 : IPathDirname = Fable.Core.JsInterop.importAll v30 
    let v32 : string = "v31.dirname($0)"
    let v33 : string = Fable.Core.JsInterop.emitJsExpr v0 v32 
    let v34 : US3 = US3_0(v33)
    v34 
    #endif
#if FABLE_COMPILER_PYTHON
    let v35 : US3 = null |> unbox<US3>
    v35 
    #endif
#else
    let v36 : (string -> System.IO.DirectoryInfo) = System.IO.Directory.GetParent
    let v37 : System.IO.DirectoryInfo = v36 v0
    let v38 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    let v39 : bool = v37 = v38 
    let v50 : US3 =
        if v39 then
            US3_1
        else
            let v41 : bool = true
            let mutable _v41 : string option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v42 : string = null |> unbox<string>
            v42 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v43 : string = null |> unbox<string>
            v43 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v44 : string = null |> unbox<string>
            v44 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v45 : string = null |> unbox<string>
            v45 
            #endif
#if FABLE_COMPILER_PYTHON
            let v46 : string = null |> unbox<string>
            v46 
            #endif
#else
            let v47 : string = v37.FullName
            v47 
            #endif
            |> fun x -> _v41 <- Some x
            let v48 : string = match _v41 with Some x -> x | None -> failwith "base.run_target / _v41=None"
            US3_0(v48)
    v50 
    #endif
    |> fun x -> _v1 <- Some x
    let v51 : US3 = match _v1 with Some x -> x | None -> failwith "base.run_target / _v1=None"
    match v51 with
    | US3_1 -> (* None *)
        let v54 : string option = None
        v54
    | US3_0(v52) -> (* Some *)
        let v53 : string option = Some v52 
        v53
and closure9 () (v0 : string) : string option =
    method21(v0)
and method20 () : (string -> string option) =
    closure9()
and method22 (v0 : string, v1 : string, v2 : string) : US12 =
    let v3 : string = method15(v2, v0)
    let v4 : bool = method19(v3)
    if v4 then
        US12_0(v2)
    else
        let v6 : (string -> string option) = method20()
        let v7 : string option = v6 v2
        let v8 : US3 option = None
        let _v8 = ref v8 
        match v7 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v9 : string = x
        let v10 : US3 = US3_0(v9)
        v10 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v8.Value <- x
        let v11 : US3 option = _v8.Value 
        let v12 : US3 = US3_1
        let v13 : US3 = v11 |> Option.defaultValue v12 
        match v13 with
        | US3_1 -> (* None *)
            let v16 : string = $"""No parent for {if false then "file" else "dir"} '{v0}' at '{v1}' (until '{v2}')"""
            US12_1(v16)
        | US3_0(v14) -> (* Some *)
            method22(v0, v1, v14)
and method18 (v0 : string, v1 : string) : US12 =
    let v2 : string = method15(v1, v0)
    let v3 : bool = method19(v2)
    if v3 then
        US12_0(v1)
    else
        let v5 : (string -> string option) = method20()
        let v6 : string option = v5 v1
        let v7 : US3 option = None
        let _v7 = ref v7 
        match v6 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v8 : string = x
        let v9 : US3 = US3_0(v8)
        v9 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v7.Value <- x
        let v10 : US3 option = _v7.Value 
        let v11 : US3 = US3_1
        let v12 : US3 = v10 |> Option.defaultValue v11 
        match v12 with
        | US3_1 -> (* None *)
            let v15 : string = $"""No parent for {if false then "file" else "dir"} '{v0}' at '{v1}' (until '{v1}')"""
            US12_1(v15)
        | US3_0(v13) -> (* Some *)
            method22(v0, v1, v13)
and closure10 () () : string =
    let v0 : string = "file_system.get_workspace_root"
    v0
and closure11 (v0 : string) () : string =
    let v1 : (unit -> string) = closure6()
    let v2 : string = $"error: {v0} / {v1 ()}"
    v2
and method23 (v0 : string) : string =
    let v1 : bool = true
    let mutable _v1 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = "&*$0"
    let v3 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v2 
    let v4 : string = "String::from($0)"
    let v5 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3 v4 
    let v6 : string = "std::path::PathBuf::from($0)"
    let v7 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v5 v6 
    let v8 : string = "$0.parent()"
    let v9 : Ref<std_path_Path> option = Fable.Core.RustInterop.emitRustExpr v7 v8 
    let v10 : string = "$0.unwrap()"
    let v11 : Ref<std_path_Path> = Fable.Core.RustInterop.emitRustExpr v9 v10 
    let v12 : string = "$0.display()"
    let v13 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v11 v12 
    let v14 : bool = true
    let mutable _v14 : std_string_String option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v15 : string = "format!(\"{}\", $0)"
    let v16 : std_string_String = Fable.Core.RustInterop.emitRustExpr v13 v15 
    v16 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v17 : string = "format!(\"{}\", $0)"
    let v18 : std_string_String = Fable.Core.RustInterop.emitRustExpr v13 v17 
    v18 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v19 : string = "format!(\"{}\", $0)"
    let v20 : std_string_String = Fable.Core.RustInterop.emitRustExpr v13 v19 
    v20 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v21 : std_string_String = null |> unbox<std_string_String>
    v21 
    #endif
#if FABLE_COMPILER_PYTHON
    let v22 : std_string_String = null |> unbox<std_string_String>
    v22 
    #endif
#else
    let v23 : std_string_String = null |> unbox<std_string_String>
    v23 
    #endif
    |> fun x -> _v14 <- Some x
    let v24 : std_string_String = match _v14 with Some x -> x | None -> failwith "base.run_target / _v14=None"
    let v25 : string = "fable_library_rust::String_::fromString($0)"
    let v26 : string = Fable.Core.RustInterop.emitRustExpr v24 v25 
    v26 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v27 : (string -> string) = System.IO.Path.GetDirectoryName
    let v28 : string = v27 v0
    v28 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v29 : string = null |> unbox<string>
    v29 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v30 : (string -> string) = System.IO.Path.GetDirectoryName
    let v31 : string = v30 v0
    v31 
    #endif
#if FABLE_COMPILER_PYTHON
    let v32 : (string -> string) = System.IO.Path.GetDirectoryName
    let v33 : string = v32 v0
    v33 
    #endif
#else
    let v34 : (string -> string) = System.IO.Path.GetDirectoryName
    let v35 : string = v34 v0
    v35 
    #endif
    |> fun x -> _v1 <- Some x
    let v36 : string = match _v1 with Some x -> x | None -> failwith "base.run_target / _v1=None"
    v36
and method26 (v0 : string) : bool =
    let v1 : bool = true
    let mutable _v1 : bool option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = "&*$0"
    let v3 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v2 
    let v4 : string = "String::from($0)"
    let v5 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3 v4 
    let v6 : string = "std::path::PathBuf::from($0)"
    let v7 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v5 v6 
    let v8 : string = "$0.exists()"
    let v9 : bool = Fable.Core.RustInterop.emitRustExpr v7 v8 
    let v12 : bool =
        if v9 then
            let v10 : string = "$0.is_file()"
            let v11 : bool = Fable.Core.RustInterop.emitRustExpr v7 v10 
            v11
        else
            false
    v12 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v13 : bool = null |> unbox<bool>
    v13 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v14 : bool = null |> unbox<bool>
    v14 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v15 : string = "fs"
    let v16 : IFsExistsSync = Fable.Core.JsInterop.importAll v15 
    let v17 : string = "$0.existsSync($1)"
    let v18 : bool = Fable.Core.JsInterop.emitJsExpr struct (v16, v0) v17 
    v18 
    #endif
#if FABLE_COMPILER_PYTHON
    let v19 : bool = null |> unbox<bool>
    v19 
    #endif
#else
    let v20 : (string -> bool) = System.IO.File.Exists
    let v21 : bool = v20 v0
    v21 
    #endif
    |> fun x -> _v1 <- Some x
    let v22 : bool = match _v1 with Some x -> x | None -> failwith "base.run_target / _v1=None"
    v22
and method25 (v0 : string, v1 : string) : bool =
    let v2 : bool = true
    let mutable _v2 : bool option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : bool = method26(v0)
    let v4 : bool = v3 = false
    let v30 : bool =
        if v4 then
            false
        else
            let v5 : bool = true
            let mutable _v5 : string option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v6 : bool = true
            let mutable _v6 : Vec<uint8> option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v7 : string = "std::fs::read(&*$0).unwrap()"
            let v8 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v0 v7 
            v8 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v9 : Vec<uint8> = null |> unbox<Vec<uint8>>
            v9 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v10 : Vec<uint8> = null |> unbox<Vec<uint8>>
            v10 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v11 : Vec<uint8> = null |> unbox<Vec<uint8>>
            v11 
            #endif
#if FABLE_COMPILER_PYTHON
            let v12 : Vec<uint8> = null |> unbox<Vec<uint8>>
            v12 
            #endif
#else
            let v13 : (uint8 []) = v0 |> System.IO.File.ReadAllBytes
            let v14 : string = "$0.to_vec()"
            let v15 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v13 v14 
            v15 
            #endif
            |> fun x -> _v6 <- Some x
            let v16 : Vec<uint8> = match _v6 with Some x -> x | None -> failwith "base.run_target / _v6=None"
            let v17 : string = "std::string::String::from_utf8(v16)"
            let v18 : Result<std_string_String, std_string_FromUtf8Error> = Fable.Core.RustInterop.emitRustExpr () v17 
            let v19 : string = "$0.unwrap()"
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
#if FABLE_COMPILER_TYPESCRIPT
            let v25 : string = null |> unbox<string>
            v25 
            #endif
#if FABLE_COMPILER_PYTHON
            let v26 : string = null |> unbox<string>
            v26 
            #endif
#else
            let v27 : string = v0 |> System.IO.File.ReadAllText
            v27 
            #endif
            |> fun x -> _v5 <- Some x
            let v28 : string = match _v5 with Some x -> x | None -> failwith "base.run_target / _v5=None"
            let v29 : bool = v1 = v28
            v29
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
    let v33 : bool = null |> unbox<bool>
    v33 
    #endif
#if FABLE_COMPILER_PYTHON
    let v34 : bool = null |> unbox<bool>
    v34 
    #endif
#else
    let v35 : bool = null |> unbox<bool>
    v35 
    #endif
    |> fun x -> _v2 <- Some x
    let v36 : bool = match _v2 with Some x -> x | None -> failwith "base.run_target / _v2=None"
    v36
and method27 (v0 : string) : string =
    v0
and method24 (v0 : string, v1 : string) : unit =
    let v2 : bool = method25(v0, v1)
    let v3 : bool = v2 = false
    if v3 then
        let v4 : bool = true
        let mutable _v4 : unit option = None 
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v5 : string = "std::fs::write(&*$0, &*$1).unwrap()"
        Fable.Core.RustInterop.emitRustExpr struct (v0, v1) v5 
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
        let v6 : string = method27(v1)
        System.IO.File.WriteAllText (v0, v6)
        () 
        #endif
        |> fun x -> _v4 <- Some x
        match _v4 with Some x -> x | None -> failwith "base.run_target / _v4=None"
        ()
and method29 (v0 : System.Threading.CancellationToken option, v1 : string, v2 : (struct (string * string) []), v3 : (struct (bool * string * int32) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option) : string =
    v1
and method31 () : struct (string * string) =
    let v0 : string = ""
    struct (v0, v0)
and method32 (v0 : int32, v1 : Mut4) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and closure13 (v0 : char) (v1 : UH0) : UH0 =
    UH0_1(v0, v1)
and closure12 () (v0 : char) : (UH0 -> UH0) =
    closure13(v0)
and method33 () : (char -> (UH0 -> UH0)) =
    closure12()
and method34 (v0 : string, v1 : string, v2 : UH0, v3 : US13) : struct (string * string) =
    match v2 with
    | UH0_1(v4, v5) -> (* Cons *)
        let v6 : bool = '"' = v4
        if v6 then
            let v8 : bool = v1 = ""
            if v8 then
                let v9 : US14 = US14_0
                let v10 : US13 = US13_1(v9)
                method34(v0, v1, v5, v10)
            else
                match v3 with
                | US13_2 -> (* Arguments *)
                    let v38 : string = $"{v0}{v4}"
                    let v39 : US13 = US13_2
                    method34(v38, v1, v5, v39)
                | US13_1(v13) -> (* Path *)
                    match v13 with
                    | US14_0 -> (* Quoted *)
                        let v14 : US14 = US14_1
                        let v15 : US13 = US13_1(v14)
                        method34(v0, v1, v5, v15)
                    | _ ->
                        let v18 : bool = ' ' = v4
                        if v18 then
                            let v19 : US13 = US13_2
                            method34(v0, v1, v5, v19)
                        else
                            let v22 : string = $"{v1}{v4}"
                            method34(v0, v22, v5, v3)
                | US13_0 -> (* Start *)
                    let v29 : bool = ' ' = v4
                    if v29 then
                        let v30 : US13 = US13_2
                        method34(v0, v1, v5, v30)
                    else
                        let v33 : string = $"{v1}{v4}"
                        method34(v0, v33, v5, v3)
        else
            let v50 : bool = ''' = v4
            if v50 then
                let v52 : bool = v1 = ""
                if v52 then
                    let v53 : US14 = US14_0
                    let v54 : US13 = US13_1(v53)
                    method34(v0, v1, v5, v54)
                else
                    match v3 with
                    | US13_2 -> (* Arguments *)
                        let v82 : string = $"{v0}{v4}"
                        let v83 : US13 = US13_2
                        method34(v82, v1, v5, v83)
                    | US13_1(v57) -> (* Path *)
                        match v57 with
                        | US14_0 -> (* Quoted *)
                            let v58 : US14 = US14_1
                            let v59 : US13 = US13_1(v58)
                            method34(v0, v1, v5, v59)
                        | _ ->
                            let v62 : bool = ' ' = v4
                            if v62 then
                                let v63 : US13 = US13_2
                                method34(v0, v1, v5, v63)
                            else
                                let v66 : string = $"{v1}{v4}"
                                method34(v0, v66, v5, v3)
                    | US13_0 -> (* Start *)
                        let v73 : bool = ' ' = v4
                        if v73 then
                            let v74 : US13 = US13_2
                            method34(v0, v1, v5, v74)
                        else
                            let v77 : string = $"{v1}{v4}"
                            method34(v0, v77, v5, v3)
            else
                match v3 with
                | US13_2 -> (* Arguments *)
                    let v126 : string = $"{v0}{v4}"
                    let v127 : US13 = US13_2
                    method34(v126, v1, v5, v127)
                | US13_1(v94) -> (* Path *)
                    match v94 with
                    | US14_0 -> (* Quoted *)
                        let v95 : bool = ' ' = v4
                        if v95 then
                            let v96 : string = $"{v1} "
                            let v97 : US14 = US14_0
                            let v98 : US13 = US13_1(v97)
                            method34(v0, v96, v5, v98)
                        else
                            let v101 : string = $"{v1}{v4}"
                            method34(v0, v101, v5, v3)
                    | _ ->
                        let v106 : bool = ' ' = v4
                        if v106 then
                            let v107 : US13 = US13_2
                            method34(v0, v1, v5, v107)
                        else
                            let v110 : string = $"{v1}{v4}"
                            method34(v0, v110, v5, v3)
                | US13_0 -> (* Start *)
                    let v117 : bool = ' ' = v4
                    if v117 then
                        let v118 : US13 = US13_2
                        method34(v0, v1, v5, v118)
                    else
                        let v121 : string = $"{v1}{v4}"
                        method34(v0, v121, v5, v3)
    | _ ->
        match v3 with
        | US13_2 -> (* Arguments *)
            let v152 : string = "\\"
            let v153 : string = "/"
            let v154 : string = v1.Replace (v152, v153)
            struct (v154, v0)
        | US13_1(v140) -> (* Path *)
            match v140 with
            | US14_0 -> (* Quoted *)
                let v141 : string = "\\"
                let v142 : string = "/"
                let v143 : string = v1.Replace (v141, v142)
                struct (v143, v0)
            | _ ->
                let v144 : string = "\\"
                let v145 : string = "/"
                let v146 : string = v1.Replace (v144, v145)
                struct (v146, v0)
        | US13_0 -> (* Start *)
            let v149 : string = "\\"
            let v150 : string = "/"
            let v151 : string = v1.Replace (v149, v150)
            struct (v151, v0)
and method30 (v0 : string) : struct (string * string) =
    let struct (v1 : string, v2 : string) = method31()
    let v3 : int32 = v0.Length
    let v4 : (char []) = Array.zeroCreate<char> (v3)
    let v5 : Mut4 = {l0 = 0} : Mut4
    while method32(v3, v5) do
        let v7 : int32 = v5.l0
        let v8 : char = v0.[int v7]
        v4.[int v7] <- v8
        let v9 : int32 = v7 + 1
        v5.l0 <- v9
        ()
    let v10 : ((char []) -> char list) = Array.toList
    let v11 : char list = v10 v4
    let v12 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
    let v13 : (char -> (UH0 -> UH0)) = method33()
    let v14 : (char list -> (UH0 -> UH0)) = v12 v13
    let v15 : (UH0 -> UH0) = v14 v11
    let v16 : UH0 = UH0_0
    let v17 : UH0 = v15 v16
    let v18 : US13 = US13_0
    method34(v2, v1, v17, v18)
and method37 (v0 : char, v1 : int64) : bool =
    let v2 : bool = v1 >= 4L
    if v2 then
        false
    else
        let v3 : bool = v1 = 0L
        let v19 : US18 =
            if v3 then
                US18_0('\\')
            else
                let v5 : int64 = v1 - 1L
                let v6 : bool = v5 = 0L
                if v6 then
                    US18_0('`')
                else
                    let v8 : int64 = v5 - 1L
                    let v9 : bool = v8 = 0L
                    if v9 then
                        US18_0('"')
                    else
                        let v11 : int64 = v8 - 1L
                        let v12 : bool = v11 = 0L
                        if v12 then
                            US18_0(' ')
                        else
                            let v14 : int64 = v11 - 1L
                            US18_1
        let v23 : char =
            match v19 with
            | US18_1 -> (* None *)
                failwith<char> "Option does not have a value."
            | US18_0(v20) -> (* Some *)
                v20
        let v24 : bool = v0 = v23
        if v24 then
            true
        else
            let v25 : int64 = v1 + 1L
            method37(v0, v25)
and method38 (v0 : UH0, v1 : System.Text.StringBuilder, v2 : int32, v3 : int32) : struct (System.Text.StringBuilder * int32 * int32) =
    match v0 with
    | UH0_1(v4, v5) -> (* Cons *)
        let v6 : bool = '\n' = v4
        let struct (v9 : int32, v10 : int32) =
            if v6 then
                let v7 : int32 = v3 + 1
                struct (1, v7)
            else
                let v8 : int32 = v2 + 1
                struct (v8, v3)
        let v17 : System.Text.StringBuilder =
            if v6 then
                let v11 : (unit -> System.Text.StringBuilder) = v1.Clear
                let v12 : System.Text.StringBuilder = v11 ()
                v1
            else
                let v13 : (char -> string) = _.ToString()
                let v14 : string = v13 v4
                let v15 : (string -> System.Text.StringBuilder) = v1.Append
                let v16 : System.Text.StringBuilder = v15 v14
                v1
        method38(v5, v17, v9, v10)
    | UH0_0 -> (* Nil *)
        struct (v1, v2, v3)
and method39 (v0 : string, v1 : string, v2 : System.Text.StringBuilder, v3 : int32, v4 : int32) : US19 =
    let v5 : bool = "" = v1
    let v57 : US17 =
        if v5 then
            let v6 : char list = []
            let v7 : char list = ' ' :: v6 
            let v8 : char list = '"' :: v7 
            let v9 : char list = '`' :: v8 
            let v10 : char list = '\\' :: v9 
            let v11 : (char list -> (char [])) = List.toArray
            let v12 : (char []) = v11 v10
            let v13 : string = $"parsing.none_of / unexpected end of input / chars: %A{v12} / s: %A{struct (v2, v3, v4)}"
            US17_1(v13)
        else
            let v15 : char = v1.[int 0]
            let v16 : (string -> int32) = String.length
            let v17 : int32 = v16 v1
            let v18 : (int32 -> int32) = int32
            let v19 : int32 = v18 1
            let v20 : (int32 -> int32) = int32
            let v21 : int32 = v20 v17
            let v22 : string = v1.[int v19..int v21]
            let v23 : int64 = 0L
            let v24 : bool = method37(v15, v23)
            let v25 : bool = v24 = false
            if v25 then
                let v26 : (char -> string) = _.ToString()
                let v27 : string = v26 v15
                let v28 : int32 = v27.Length
                let v29 : (char []) = Array.zeroCreate<char> (v28)
                let v30 : Mut4 = {l0 = 0} : Mut4
                while method32(v28, v30) do
                    let v32 : int32 = v30.l0
                    let v33 : char = v27.[int v32]
                    v29.[int v32] <- v33
                    let v34 : int32 = v32 + 1
                    v30.l0 <- v34
                    ()
                let v35 : ((char []) -> char list) = Array.toList
                let v36 : char list = v35 v29
                let v37 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v38 : (char -> (UH0 -> UH0)) = method33()
                let v39 : (char list -> (UH0 -> UH0)) = v37 v38
                let v40 : (UH0 -> UH0) = v39 v36
                let v41 : UH0 = UH0_0
                let v42 : UH0 = v40 v41
                let struct (v43 : System.Text.StringBuilder, v44 : int32, v45 : int32) = method38(v42, v2, v3, v4)
                US17_0(v15, v22, v43, v44, v45)
            else
                let v47 : char list = []
                let v48 : char list = ' ' :: v47 
                let v49 : char list = '"' :: v48 
                let v50 : char list = '`' :: v49 
                let v51 : char list = '\\' :: v50 
                let v52 : (char list -> (char [])) = List.toArray
                let v53 : (char []) = v52 v51
                let v54 : string = $"parsing.none_of / unexpected char: '{v15}' / chars: %A{v53} / s: %A{struct (v2, v3, v4)}"
                US17_1(v54)
    match v57 with
    | US17_1(v67) -> (* Error *)
        US19_0(v0, v1, v2, v3, v4)
    | US17_0(v58, v59, v60, v61, v62) -> (* Ok *)
        let v63 : (char -> string) = _.ToString()
        let v64 : string = v63 v58
        let v65 : string = v0 + v64 
        method39(v65, v59, v60, v61, v62)
and method41 (v0 : char, v1 : int64) : bool =
    let v2 : bool = v1 >= 3L
    if v2 then
        false
    else
        let v3 : bool = v1 = 0L
        let v15 : US18 =
            if v3 then
                US18_0('\\')
            else
                let v5 : int64 = v1 - 1L
                let v6 : bool = v5 = 0L
                if v6 then
                    US18_0('`')
                else
                    let v8 : int64 = v5 - 1L
                    let v9 : bool = v8 = 0L
                    if v9 then
                        US18_0('"')
                    else
                        let v11 : int64 = v8 - 1L
                        US18_1
        let v19 : char =
            match v15 with
            | US18_1 -> (* None *)
                failwith<char> "Option does not have a value."
            | US18_0(v16) -> (* Some *)
                v16
        let v20 : bool = v0 = v19
        if v20 then
            true
        else
            let v21 : int64 = v1 + 1L
            method41(v0, v21)
and closure14 () struct (v0 : string, v1 : System.Text.StringBuilder, v2 : int32, v3 : int32) : US19 =
    let v4 : bool = "" = v0
    let v60 : US17 =
        if v4 then
            let v5 : string = $"parsing.p_char / unexpected end of input / s: %A{struct (v1, v2, v3)}"
            US17_1(v5)
        else
            let v7 : char = v0.[int 0]
            let v8 : bool = v7 = '\\'
            if v8 then
                let v9 : (string -> int32) = String.length
                let v10 : int32 = v9 v0
                let v11 : (int32 -> int32) = int32
                let v12 : int32 = v11 1
                let v13 : (int32 -> int32) = int32
                let v14 : int32 = v13 v10
                let v15 : string = v0.[int v12..int v14]
                let v16 : (char -> string) = _.ToString()
                let v17 : string = v16 v7
                let v18 : int32 = v17.Length
                let v19 : (char []) = Array.zeroCreate<char> (v18)
                let v20 : Mut4 = {l0 = 0} : Mut4
                while method32(v18, v20) do
                    let v22 : int32 = v20.l0
                    let v23 : char = v17.[int v22]
                    v19.[int v22] <- v23
                    let v24 : int32 = v22 + 1
                    v20.l0 <- v24
                    ()
                let v25 : ((char []) -> char list) = Array.toList
                let v26 : char list = v25 v19
                let v27 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v28 : (char -> (UH0 -> UH0)) = method33()
                let v29 : (char list -> (UH0 -> UH0)) = v27 v28
                let v30 : (UH0 -> UH0) = v29 v26
                let v31 : UH0 = UH0_0
                let v32 : UH0 = v30 v31
                let struct (v33 : System.Text.StringBuilder, v34 : int32, v35 : int32) = method38(v32, v1, v2, v3)
                US17_0(v7, v15, v33, v34, v35)
            else
                let v37 : (string -> int32) = String.length
                let v38 : int32 = v37 v0
                let v39 : string = "\n"
                let v40 : int32 = v0.IndexOf v39 
                let v41 : int32 = v40 - 1
                let v42 : bool = -2 = v41
                let v43 : int32 =
                    if v42 then
                        v38
                    else
                        v41
                let v44 : (int32 -> int32) = int32
                let v45 : int32 = v44 0
                let v46 : (int32 -> int32) = int32
                let v47 : int32 = v46 v43
                let v48 : string = v0.[int v45..int v47]
                let v49 : string = $"parsing.p_char / expected: '{'\\'}' / line: {v3} / col: {v2}
{v1}{v48}"
                let v50 : int32 = v2 - 1
                let v51 : (int32 -> (string -> string)) = String.replicate
                let v52 : (string -> string) = v51 v50
                let v53 : string = " "
                let v54 : string = v52 v53
                let v55 : string = "^"
                let v56 : string = v54 + v55 
                let v57 : string = $"{v49}
{v56}
"
                US17_1(v57)
    let v102 : US17 =
        match v60 with
        | US17_1(v99) -> (* Error *)
            US17_1(v99)
        | US17_0(v61, v62, v63, v64, v65) -> (* Ok *)
            let v66 : bool = "" = v62
            if v66 then
                let v67 : string = $"parsing.any_char / unexpected end of input / s: %A{struct (v63, v64, v65)}"
                US17_1(v67)
            else
                let v69 : char = v62.[int 0]
                let v70 : (string -> int32) = String.length
                let v71 : int32 = v70 v62
                let v72 : (int32 -> int32) = int32
                let v73 : int32 = v72 1
                let v74 : (int32 -> int32) = int32
                let v75 : int32 = v74 v71
                let v76 : string = v62.[int v73..int v75]
                let v77 : (char -> string) = _.ToString()
                let v78 : string = v77 v69
                let v79 : int32 = v78.Length
                let v80 : (char []) = Array.zeroCreate<char> (v79)
                let v81 : Mut4 = {l0 = 0} : Mut4
                while method32(v79, v81) do
                    let v83 : int32 = v81.l0
                    let v84 : char = v78.[int v83]
                    v80.[int v83] <- v84
                    let v85 : int32 = v83 + 1
                    v81.l0 <- v85
                    ()
                let v86 : ((char []) -> char list) = Array.toList
                let v87 : char list = v86 v80
                let v88 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v89 : (char -> (UH0 -> UH0)) = method33()
                let v90 : (char list -> (UH0 -> UH0)) = v88 v89
                let v91 : (UH0 -> UH0) = v90 v87
                let v92 : UH0 = UH0_0
                let v93 : UH0 = v91 v92
                let struct (v94 : System.Text.StringBuilder, v95 : int32, v96 : int32) = method38(v93, v63, v64, v65)
                US17_0(v69, v76, v94, v95, v96)
    match v102 with
    | US17_1(v110) -> (* Error *)
        US19_1(v110)
    | US17_0(v103, v104, v105, v106, v107) -> (* Ok *)
        let v108 : string = $"{'\\'}{v103}"
        US19_0(v108, v104, v105, v106, v107)
and closure15 () struct (v0 : string, v1 : System.Text.StringBuilder, v2 : int32, v3 : int32) : US19 =
    let v4 : bool = "" = v0
    let v60 : US17 =
        if v4 then
            let v5 : string = $"parsing.p_char / unexpected end of input / s: %A{struct (v1, v2, v3)}"
            US17_1(v5)
        else
            let v7 : char = v0.[int 0]
            let v8 : bool = v7 = '`'
            if v8 then
                let v9 : (string -> int32) = String.length
                let v10 : int32 = v9 v0
                let v11 : (int32 -> int32) = int32
                let v12 : int32 = v11 1
                let v13 : (int32 -> int32) = int32
                let v14 : int32 = v13 v10
                let v15 : string = v0.[int v12..int v14]
                let v16 : (char -> string) = _.ToString()
                let v17 : string = v16 v7
                let v18 : int32 = v17.Length
                let v19 : (char []) = Array.zeroCreate<char> (v18)
                let v20 : Mut4 = {l0 = 0} : Mut4
                while method32(v18, v20) do
                    let v22 : int32 = v20.l0
                    let v23 : char = v17.[int v22]
                    v19.[int v22] <- v23
                    let v24 : int32 = v22 + 1
                    v20.l0 <- v24
                    ()
                let v25 : ((char []) -> char list) = Array.toList
                let v26 : char list = v25 v19
                let v27 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v28 : (char -> (UH0 -> UH0)) = method33()
                let v29 : (char list -> (UH0 -> UH0)) = v27 v28
                let v30 : (UH0 -> UH0) = v29 v26
                let v31 : UH0 = UH0_0
                let v32 : UH0 = v30 v31
                let struct (v33 : System.Text.StringBuilder, v34 : int32, v35 : int32) = method38(v32, v1, v2, v3)
                US17_0(v7, v15, v33, v34, v35)
            else
                let v37 : (string -> int32) = String.length
                let v38 : int32 = v37 v0
                let v39 : string = "\n"
                let v40 : int32 = v0.IndexOf v39 
                let v41 : int32 = v40 - 1
                let v42 : bool = -2 = v41
                let v43 : int32 =
                    if v42 then
                        v38
                    else
                        v41
                let v44 : (int32 -> int32) = int32
                let v45 : int32 = v44 0
                let v46 : (int32 -> int32) = int32
                let v47 : int32 = v46 v43
                let v48 : string = v0.[int v45..int v47]
                let v49 : string = $"parsing.p_char / expected: '{'`'}' / line: {v3} / col: {v2}
{v1}{v48}"
                let v50 : int32 = v2 - 1
                let v51 : (int32 -> (string -> string)) = String.replicate
                let v52 : (string -> string) = v51 v50
                let v53 : string = " "
                let v54 : string = v52 v53
                let v55 : string = "^"
                let v56 : string = v54 + v55 
                let v57 : string = $"{v49}
{v56}
"
                US17_1(v57)
    let v102 : US17 =
        match v60 with
        | US17_1(v99) -> (* Error *)
            US17_1(v99)
        | US17_0(v61, v62, v63, v64, v65) -> (* Ok *)
            let v66 : bool = "" = v62
            if v66 then
                let v67 : string = $"parsing.any_char / unexpected end of input / s: %A{struct (v63, v64, v65)}"
                US17_1(v67)
            else
                let v69 : char = v62.[int 0]
                let v70 : (string -> int32) = String.length
                let v71 : int32 = v70 v62
                let v72 : (int32 -> int32) = int32
                let v73 : int32 = v72 1
                let v74 : (int32 -> int32) = int32
                let v75 : int32 = v74 v71
                let v76 : string = v62.[int v73..int v75]
                let v77 : (char -> string) = _.ToString()
                let v78 : string = v77 v69
                let v79 : int32 = v78.Length
                let v80 : (char []) = Array.zeroCreate<char> (v79)
                let v81 : Mut4 = {l0 = 0} : Mut4
                while method32(v79, v81) do
                    let v83 : int32 = v81.l0
                    let v84 : char = v78.[int v83]
                    v80.[int v83] <- v84
                    let v85 : int32 = v83 + 1
                    v81.l0 <- v85
                    ()
                let v86 : ((char []) -> char list) = Array.toList
                let v87 : char list = v86 v80
                let v88 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v89 : (char -> (UH0 -> UH0)) = method33()
                let v90 : (char list -> (UH0 -> UH0)) = v88 v89
                let v91 : (UH0 -> UH0) = v90 v87
                let v92 : UH0 = UH0_0
                let v93 : UH0 = v91 v92
                let struct (v94 : System.Text.StringBuilder, v95 : int32, v96 : int32) = method38(v93, v63, v64, v65)
                US17_0(v69, v76, v94, v95, v96)
    match v102 with
    | US17_1(v110) -> (* Error *)
        US19_1(v110)
    | US17_0(v103, v104, v105, v106, v107) -> (* Ok *)
        let v108 : string = $"{'`'}{v103}"
        US19_0(v108, v104, v105, v106, v107)
and method42 (v0 : string, v1 : System.Text.StringBuilder, v2 : int32, v3 : int32, v4 : UH2) : US19 =
    match v4 with
    | UH2_1(v7, v8) -> (* Cons *)
        let v9 : US19 = v7 struct (v0, v1, v2, v3)
        match v9 with
        | US19_1(v15) -> (* Error *)
            method42(v0, v1, v2, v3, v8)
        | US19_0(v10, v11, v12, v13, v14) -> (* Ok *)
            v9
    | UH2_0 -> (* Nil *)
        let v5 : string = "choice / no parsers succeeded"
        US19_1(v5)
and method43 (v0 : UH1, v1 : UH1) : UH1 =
    match v0 with
    | UH1_1(v2, v3) -> (* Cons *)
        let v4 : UH1 = UH1_1(v2, v1)
        method43(v3, v4)
    | UH1_0 -> (* Nil *)
        v1
and method40 (v0 : UH1, v1 : string, v2 : System.Text.StringBuilder, v3 : int32, v4 : int32) : US16 =
    let v5 : bool = "" = v1
    let v55 : US17 =
        if v5 then
            let v6 : char list = []
            let v7 : char list = '"' :: v6 
            let v8 : char list = '`' :: v7 
            let v9 : char list = '\\' :: v8 
            let v10 : (char list -> (char [])) = List.toArray
            let v11 : (char []) = v10 v9
            let v12 : string = $"parsing.none_of / unexpected end of input / chars: %A{v11} / s: %A{struct (v2, v3, v4)}"
            US17_1(v12)
        else
            let v14 : char = v1.[int 0]
            let v15 : (string -> int32) = String.length
            let v16 : int32 = v15 v1
            let v17 : (int32 -> int32) = int32
            let v18 : int32 = v17 1
            let v19 : (int32 -> int32) = int32
            let v20 : int32 = v19 v16
            let v21 : string = v1.[int v18..int v20]
            let v22 : int64 = 0L
            let v23 : bool = method41(v14, v22)
            let v24 : bool = v23 = false
            if v24 then
                let v25 : (char -> string) = _.ToString()
                let v26 : string = v25 v14
                let v27 : int32 = v26.Length
                let v28 : (char []) = Array.zeroCreate<char> (v27)
                let v29 : Mut4 = {l0 = 0} : Mut4
                while method32(v27, v29) do
                    let v31 : int32 = v29.l0
                    let v32 : char = v26.[int v31]
                    v28.[int v31] <- v32
                    let v33 : int32 = v31 + 1
                    v29.l0 <- v33
                    ()
                let v34 : ((char []) -> char list) = Array.toList
                let v35 : char list = v34 v28
                let v36 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v37 : (char -> (UH0 -> UH0)) = method33()
                let v38 : (char list -> (UH0 -> UH0)) = v36 v37
                let v39 : (UH0 -> UH0) = v38 v35
                let v40 : UH0 = UH0_0
                let v41 : UH0 = v39 v40
                let struct (v42 : System.Text.StringBuilder, v43 : int32, v44 : int32) = method38(v41, v2, v3, v4)
                US17_0(v14, v21, v42, v43, v44)
            else
                let v46 : char list = []
                let v47 : char list = '"' :: v46 
                let v48 : char list = '`' :: v47 
                let v49 : char list = '\\' :: v48 
                let v50 : (char list -> (char [])) = List.toArray
                let v51 : (char []) = v50 v49
                let v52 : string = $"parsing.none_of / unexpected char: '{v14}' / chars: %A{v51} / s: %A{struct (v2, v3, v4)}"
                US17_1(v52)
    let v67 : US19 =
        match v55 with
        | US17_1(v64) -> (* Error *)
            US19_1(v64)
        | US17_0(v56, v57, v58, v59, v60) -> (* Ok *)
            let v61 : (char -> string) = _.ToString()
            let v62 : string = v61 v56
            US19_0(v62, v57, v58, v59, v60)
    let v81 : US19 =
        match v67 with
        | US19_1(v73) -> (* Error *)
            let v74 : (struct (string * System.Text.StringBuilder * int32 * int32) -> US19) = closure14()
            let v75 : (struct (string * System.Text.StringBuilder * int32 * int32) -> US19) = closure15()
            let v76 : UH2 = UH2_0
            let v77 : UH2 = UH2_1(v75, v76)
            let v78 : UH2 = UH2_1(v74, v77)
            method42(v1, v2, v3, v4, v78)
        | US19_0(v68, v69, v70, v71, v72) -> (* Ok *)
            v67
    match v81 with
    | US19_1(v89) -> (* Error *)
        let v90 : UH1 = UH1_0
        let v91 : UH1 = method43(v0, v90)
        US16_0(v91, v1, v2, v3, v4)
    | US19_0(v82, v83, v84, v85, v86) -> (* Ok *)
        let v87 : UH1 = UH1_1(v82, v0)
        method40(v87, v83, v84, v85, v86)
and method44 (v0 : UH1, v1 : string list) : string list =
    match v0 with
    | UH1_1(v2, v3) -> (* Cons *)
        let v4 : string list = method44(v3, v1)
        let v5 : string list = v2 :: v4 
        v5
    | UH1_0 -> (* Nil *)
        v1
and method45 (v0 : UH1, v1 : string, v2 : System.Text.StringBuilder, v3 : int32, v4 : int32) : US16 =
    let v5 : bool = "" = v1
    let v55 : US17 =
        if v5 then
            let v6 : char list = []
            let v7 : char list = '"' :: v6 
            let v8 : char list = '`' :: v7 
            let v9 : char list = '\\' :: v8 
            let v10 : (char list -> (char [])) = List.toArray
            let v11 : (char []) = v10 v9
            let v12 : string = $"parsing.none_of / unexpected end of input / chars: %A{v11} / s: %A{struct (v2, v3, v4)}"
            US17_1(v12)
        else
            let v14 : char = v1.[int 0]
            let v15 : (string -> int32) = String.length
            let v16 : int32 = v15 v1
            let v17 : (int32 -> int32) = int32
            let v18 : int32 = v17 1
            let v19 : (int32 -> int32) = int32
            let v20 : int32 = v19 v16
            let v21 : string = v1.[int v18..int v20]
            let v22 : int64 = 0L
            let v23 : bool = method41(v14, v22)
            let v24 : bool = v23 = false
            if v24 then
                let v25 : (char -> string) = _.ToString()
                let v26 : string = v25 v14
                let v27 : int32 = v26.Length
                let v28 : (char []) = Array.zeroCreate<char> (v27)
                let v29 : Mut4 = {l0 = 0} : Mut4
                while method32(v27, v29) do
                    let v31 : int32 = v29.l0
                    let v32 : char = v26.[int v31]
                    v28.[int v31] <- v32
                    let v33 : int32 = v31 + 1
                    v29.l0 <- v33
                    ()
                let v34 : ((char []) -> char list) = Array.toList
                let v35 : char list = v34 v28
                let v36 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v37 : (char -> (UH0 -> UH0)) = method33()
                let v38 : (char list -> (UH0 -> UH0)) = v36 v37
                let v39 : (UH0 -> UH0) = v38 v35
                let v40 : UH0 = UH0_0
                let v41 : UH0 = v39 v40
                let struct (v42 : System.Text.StringBuilder, v43 : int32, v44 : int32) = method38(v41, v2, v3, v4)
                US17_0(v14, v21, v42, v43, v44)
            else
                let v46 : char list = []
                let v47 : char list = '"' :: v46 
                let v48 : char list = '`' :: v47 
                let v49 : char list = '\\' :: v48 
                let v50 : (char list -> (char [])) = List.toArray
                let v51 : (char []) = v50 v49
                let v52 : string = $"parsing.none_of / unexpected char: '{v14}' / chars: %A{v51} / s: %A{struct (v2, v3, v4)}"
                US17_1(v52)
    let v67 : US19 =
        match v55 with
        | US17_1(v64) -> (* Error *)
            US19_1(v64)
        | US17_0(v56, v57, v58, v59, v60) -> (* Ok *)
            let v61 : (char -> string) = _.ToString()
            let v62 : string = v61 v56
            US19_0(v62, v57, v58, v59, v60)
    match v67 with
    | US19_1(v75) -> (* Error *)
        let v76 : UH1 = UH1_0
        let v77 : UH1 = method43(v0, v76)
        US16_0(v77, v1, v2, v3, v4)
    | US19_0(v68, v69, v70, v71, v72) -> (* Ok *)
        let v73 : UH1 = UH1_1(v68, v0)
        method45(v73, v69, v70, v71, v72)
and method46 (v0 : string, v1 : int32) : int32 =
    let v2 : int32 = v0.Length
    let v3 : bool = v1 >= v2
    if v3 then
        v1
    else
        let v4 : char = v0.[int v1]
        let v5 : bool = v4 = ' '
        if v5 then
            let v6 : int32 = v1 + 1
            method46(v0, v6)
        else
            v1
and method36 (v0 : UH1, v1 : string, v2 : System.Text.StringBuilder, v3 : int32, v4 : int32) : US16 =
    let v5 : bool = "" = v1
    let v57 : US17 =
        if v5 then
            let v6 : char list = []
            let v7 : char list = ' ' :: v6 
            let v8 : char list = '"' :: v7 
            let v9 : char list = '`' :: v8 
            let v10 : char list = '\\' :: v9 
            let v11 : (char list -> (char [])) = List.toArray
            let v12 : (char []) = v11 v10
            let v13 : string = $"parsing.none_of / unexpected end of input / chars: %A{v12} / s: %A{struct (v2, v3, v4)}"
            US17_1(v13)
        else
            let v15 : char = v1.[int 0]
            let v16 : (string -> int32) = String.length
            let v17 : int32 = v16 v1
            let v18 : (int32 -> int32) = int32
            let v19 : int32 = v18 1
            let v20 : (int32 -> int32) = int32
            let v21 : int32 = v20 v17
            let v22 : string = v1.[int v19..int v21]
            let v23 : int64 = 0L
            let v24 : bool = method37(v15, v23)
            let v25 : bool = v24 = false
            if v25 then
                let v26 : (char -> string) = _.ToString()
                let v27 : string = v26 v15
                let v28 : int32 = v27.Length
                let v29 : (char []) = Array.zeroCreate<char> (v28)
                let v30 : Mut4 = {l0 = 0} : Mut4
                while method32(v28, v30) do
                    let v32 : int32 = v30.l0
                    let v33 : char = v27.[int v32]
                    v29.[int v32] <- v33
                    let v34 : int32 = v32 + 1
                    v30.l0 <- v34
                    ()
                let v35 : ((char []) -> char list) = Array.toList
                let v36 : char list = v35 v29
                let v37 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v38 : (char -> (UH0 -> UH0)) = method33()
                let v39 : (char list -> (UH0 -> UH0)) = v37 v38
                let v40 : (UH0 -> UH0) = v39 v36
                let v41 : UH0 = UH0_0
                let v42 : UH0 = v40 v41
                let struct (v43 : System.Text.StringBuilder, v44 : int32, v45 : int32) = method38(v42, v2, v3, v4)
                US17_0(v15, v22, v43, v44, v45)
            else
                let v47 : char list = []
                let v48 : char list = ' ' :: v47 
                let v49 : char list = '"' :: v48 
                let v50 : char list = '`' :: v49 
                let v51 : char list = '\\' :: v50 
                let v52 : (char list -> (char [])) = List.toArray
                let v53 : (char []) = v52 v51
                let v54 : string = $"parsing.none_of / unexpected char: '{v15}' / chars: %A{v53} / s: %A{struct (v2, v3, v4)}"
                US17_1(v54)
    let v69 : US19 =
        match v57 with
        | US17_1(v58) -> (* Error *)
            US19_1(v58)
        | US17_0(v60, v61, v62, v63, v64) -> (* Ok *)
            let v65 : (char -> string) = _.ToString()
            let v66 : string = v65 v60
            method39(v66, v61, v62, v63, v64)
    let v292 : US19 =
        match v69 with
        | US19_1(v75) -> (* Error *)
            let v131 : US17 =
                if v5 then
                    let v76 : string = $"parsing.p_char / unexpected end of input / s: %A{struct (v2, v3, v4)}"
                    US17_1(v76)
                else
                    let v78 : char = v1.[int 0]
                    let v79 : bool = v78 = '"'
                    if v79 then
                        let v80 : (string -> int32) = String.length
                        let v81 : int32 = v80 v1
                        let v82 : (int32 -> int32) = int32
                        let v83 : int32 = v82 1
                        let v84 : (int32 -> int32) = int32
                        let v85 : int32 = v84 v81
                        let v86 : string = v1.[int v83..int v85]
                        let v87 : (char -> string) = _.ToString()
                        let v88 : string = v87 v78
                        let v89 : int32 = v88.Length
                        let v90 : (char []) = Array.zeroCreate<char> (v89)
                        let v91 : Mut4 = {l0 = 0} : Mut4
                        while method32(v89, v91) do
                            let v93 : int32 = v91.l0
                            let v94 : char = v88.[int v93]
                            v90.[int v93] <- v94
                            let v95 : int32 = v93 + 1
                            v91.l0 <- v95
                            ()
                        let v96 : ((char []) -> char list) = Array.toList
                        let v97 : char list = v96 v90
                        let v98 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                        let v99 : (char -> (UH0 -> UH0)) = method33()
                        let v100 : (char list -> (UH0 -> UH0)) = v98 v99
                        let v101 : (UH0 -> UH0) = v100 v97
                        let v102 : UH0 = UH0_0
                        let v103 : UH0 = v101 v102
                        let struct (v104 : System.Text.StringBuilder, v105 : int32, v106 : int32) = method38(v103, v2, v3, v4)
                        US17_0(v78, v86, v104, v105, v106)
                    else
                        let v108 : (string -> int32) = String.length
                        let v109 : int32 = v108 v1
                        let v110 : string = "\n"
                        let v111 : int32 = v1.IndexOf v110 
                        let v112 : int32 = v111 - 1
                        let v113 : bool = -2 = v112
                        let v114 : int32 =
                            if v113 then
                                v109
                            else
                                v112
                        let v115 : (int32 -> int32) = int32
                        let v116 : int32 = v115 0
                        let v117 : (int32 -> int32) = int32
                        let v118 : int32 = v117 v114
                        let v119 : string = v1.[int v116..int v118]
                        let v120 : string = $"parsing.p_char / expected: '{'"'}' / line: {v4} / col: {v3}
{v2}{v119}"
                        let v121 : int32 = v3 - 1
                        let v122 : (int32 -> (string -> string)) = String.replicate
                        let v123 : (string -> string) = v122 v121
                        let v124 : string = " "
                        let v125 : string = v123 v124
                        let v126 : string = "^"
                        let v127 : string = v125 + v126 
                        let v128 : string = $"{v120}
{v127}
"
                        US17_1(v128)
            let v237 : US19 =
                match v131 with
                | US17_1(v234) -> (* Error *)
                    US19_1(v234)
                | US17_0(v132, v133, v134, v135, v136) -> (* Ok *)
                    let v137 : UH1 = UH1_0
                    let v138 : US16 = method40(v137, v133, v134, v135, v136)
                    let v155 : US19 =
                        match v138 with
                        | US16_1(v152) -> (* Error *)
                            US19_1(v152)
                        | US16_0(v139, v140, v141, v142, v143) -> (* Ok *)
                            let v144 : string list = []
                            let v145 : string list = method44(v139, v144)
                            let v146 : string seq = seq { for i = 0 to v145.Length - 1 do yield v145.[i] }
                            let v147 : (string -> (string seq -> string)) = String.concat
                            let v148 : string = ""
                            let v149 : (string seq -> string) = v147 v148
                            let v150 : string = v149 v146
                            US19_0(v150, v140, v141, v142, v143)
                    match v155 with
                    | US19_1(v229) -> (* Error *)
                        let v230 : string = "between / expected content"
                        US19_1(v230)
                    | US19_0(v156, v157, v158, v159, v160) -> (* Ok *)
                        let v161 : bool = "" = v157
                        let v217 : US17 =
                            if v161 then
                                let v162 : string = $"parsing.p_char / unexpected end of input / s: %A{struct (v158, v159, v160)}"
                                US17_1(v162)
                            else
                                let v164 : char = v157.[int 0]
                                let v165 : bool = v164 = '"'
                                if v165 then
                                    let v166 : (string -> int32) = String.length
                                    let v167 : int32 = v166 v157
                                    let v168 : (int32 -> int32) = int32
                                    let v169 : int32 = v168 1
                                    let v170 : (int32 -> int32) = int32
                                    let v171 : int32 = v170 v167
                                    let v172 : string = v157.[int v169..int v171]
                                    let v173 : (char -> string) = _.ToString()
                                    let v174 : string = v173 v164
                                    let v175 : int32 = v174.Length
                                    let v176 : (char []) = Array.zeroCreate<char> (v175)
                                    let v177 : Mut4 = {l0 = 0} : Mut4
                                    while method32(v175, v177) do
                                        let v179 : int32 = v177.l0
                                        let v180 : char = v174.[int v179]
                                        v176.[int v179] <- v180
                                        let v181 : int32 = v179 + 1
                                        v177.l0 <- v181
                                        ()
                                    let v182 : ((char []) -> char list) = Array.toList
                                    let v183 : char list = v182 v176
                                    let v184 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                                    let v185 : (char -> (UH0 -> UH0)) = method33()
                                    let v186 : (char list -> (UH0 -> UH0)) = v184 v185
                                    let v187 : (UH0 -> UH0) = v186 v183
                                    let v188 : UH0 = UH0_0
                                    let v189 : UH0 = v187 v188
                                    let struct (v190 : System.Text.StringBuilder, v191 : int32, v192 : int32) = method38(v189, v158, v159, v160)
                                    US17_0(v164, v172, v190, v191, v192)
                                else
                                    let v194 : (string -> int32) = String.length
                                    let v195 : int32 = v194 v157
                                    let v196 : string = "\n"
                                    let v197 : int32 = v157.IndexOf v196 
                                    let v198 : int32 = v197 - 1
                                    let v199 : bool = -2 = v198
                                    let v200 : int32 =
                                        if v199 then
                                            v195
                                        else
                                            v198
                                    let v201 : (int32 -> int32) = int32
                                    let v202 : int32 = v201 0
                                    let v203 : (int32 -> int32) = int32
                                    let v204 : int32 = v203 v200
                                    let v205 : string = v157.[int v202..int v204]
                                    let v206 : string = $"parsing.p_char / expected: '{'"'}' / line: {v160} / col: {v159}
{v158}{v205}"
                                    let v207 : int32 = v159 - 1
                                    let v208 : (int32 -> (string -> string)) = String.replicate
                                    let v209 : (string -> string) = v208 v207
                                    let v210 : string = " "
                                    let v211 : string = v209 v210
                                    let v212 : string = "^"
                                    let v213 : string = v211 + v212 
                                    let v214 : string = $"{v206}
{v213}
"
                                    US17_1(v214)
                        match v217 with
                        | US17_1(v224) -> (* Error *)
                            let v225 : string = $"between / expected closing delimiter / e: %A{v224} / input: %A{struct (v1, v2, v3, v4)} / rest1: %A{struct (v133, v134, v135, v136)} / rest2: %A{struct (v157, v158, v159, v160)}"
                            US19_1(v225)
                        | US17_0(v218, v219, v220, v221, v222) -> (* Ok *)
                            US19_0(v156, v219, v220, v221, v222)
            match v237 with
            | US19_1(v243) -> (* Error *)
                let v244 : (struct (string * System.Text.StringBuilder * int32 * int32) -> US19) = closure14()
                let v245 : (struct (string * System.Text.StringBuilder * int32 * int32) -> US19) = closure15()
                let v246 : UH2 = UH2_0
                let v247 : UH2 = UH2_1(v245, v246)
                let v248 : UH2 = UH2_1(v244, v247)
                let v249 : US19 = method42(v1, v2, v3, v4, v248)
                let v260 : US19 =
                    match v249 with
                    | US19_1(v257) -> (* Error *)
                        US19_1(v257)
                    | US19_0(v250, v251, v252, v253, v254) -> (* Ok *)
                        let v255 : string = ""
                        US19_0(v255, v251, v252, v253, v254)
                let v271 : US16 =
                    match v260 with
                    | US19_1(v268) -> (* Error *)
                        US16_1(v268)
                    | US19_0(v261, v262, v263, v264, v265) -> (* Ok *)
                        let v266 : UH1 = UH1_0
                        method45(v266, v262, v263, v264, v265)
                match v271 with
                | US16_1(v285) -> (* Error *)
                    US19_1(v285)
                | US16_0(v272, v273, v274, v275, v276) -> (* Ok *)
                    let v277 : string list = []
                    let v278 : string list = method44(v272, v277)
                    let v279 : string seq = seq { for i = 0 to v278.Length - 1 do yield v278.[i] }
                    let v280 : (string -> (string seq -> string)) = String.concat
                    let v281 : string = ""
                    let v282 : (string seq -> string) = v280 v281
                    let v283 : string = v282 v279
                    US19_0(v283, v273, v274, v275, v276)
            | US19_0(v238, v239, v240, v241, v242) -> (* Ok *)
                v237
        | US19_0(v70, v71, v72, v73, v74) -> (* Ok *)
            v69
    match v292 with
    | US19_1(v293) -> (* Error *)
        let v294 : UH1 = UH1_0
        let v295 : UH1 = method43(v0, v294)
        US16_0(v295, v1, v2, v3, v4)
    | US19_0(v297, v298, v299, v300, v301) -> (* Ok *)
        let v302 : int32 = 0
        let v303 : int32 = method46(v298, v302)
        let v304 : bool = 0 = v303
        let v315 : US20 =
            if v304 then
                let v305 : string = "spaces1 / expected at least one space"
                US20_1(v305)
            else
                let v307 : (string -> int32) = String.length
                let v308 : int32 = v307 v298
                let v309 : (int32 -> int32) = int32
                let v310 : int32 = v309 v303
                let v311 : (int32 -> int32) = int32
                let v312 : int32 = v311 v308
                let v313 : string = v298.[int v310..int v312]
                US20_0(v313, v299, v300, v301)
        match v315 with
        | US20_1(v316) -> (* Error *)
            let v317 : UH1 = UH1_0
            let v318 : UH1 = UH1_1(v297, v317)
            let v319 : UH1 = method43(v0, v318)
            US16_0(v319, v298, v299, v300, v301)
        | US20_0(v321, v322, v323, v324) -> (* Ok *)
            let v325 : UH1 = UH1_1(v297, v0)
            method36(v325, v321, v322, v323, v324)
and method35 (v0 : string) : US15 =
    let mutable _v0 = None
    #if !FABLE_COMPILER && !WASM && !CONTRACT
    let v1 : (string -> string option) = Option.ofObj
    let v2 : string option = v1 v0
    v2 
    #else
    Some v0 
    #endif
    |> fun x -> _v0 <- Some x
    let v3 : string option = match _v0 with Some x -> x | None -> failwith "optionm'.of_obj / _v0=None"
    let v4 : string = ""
    let v5 : string = v3 |> Option.defaultValue v4 
    let v6 : (string -> System.Text.StringBuilder) = System.Text.StringBuilder 
    let v7 : System.Text.StringBuilder = v6 v4
    let v8 : UH1 = UH1_0
    let v9 : int32 = 1
    let v10 : int32 = 1
    let v11 : US16 = method36(v8, v5, v7, v9, v10)
    let v25 : US21 =
        match v11 with
        | US16_1(v22) -> (* Error *)
            US21_1(v22)
        | US16_0(v12, v13, v14, v15, v16) -> (* Ok *)
            let v17 : string list = []
            let v18 : string list = method44(v12, v17)
            let v19 : (string list -> (string [])) = List.toArray
            let v20 : (string []) = v19 v18
            US21_0(v20)
    match v25 with
    | US21_1(v28) -> (* Error *)
        US15_1(v28)
    | US21_0(v26) -> (* Ok *)
        US15_0(v26)
and closure16 () () : string =
    let v0 : string = $"runtime.execute_with_options"
    v0
and closure17 (v0 : System.Threading.CancellationToken option, v1 : string, v2 : (struct (string * string) []), v3 : (struct (bool * string * int32) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option, v7 : string, v8 : Vec<std_string_String>) () : string =
    let v9 : string = $"file_name: {v7} / arguments: %A{v8}"
    let v10 : (unit -> string) = closure6()
    let v11 : string = $" / options: %A{struct (v0, v1, v2, v3, v4, v5, v6)} / {v10 ()}"
    let v12 : string = v9 + v11 
    v12
and closure18 () (v0 : std_io_Error) : std_string_String =
    let v1 : bool = true
    let mutable _v1 : std_string_String option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = "format!(\"{}\", $0)"
    let v3 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v2 
    v3 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v4 : string = "format!(\"{}\", $0)"
    let v5 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v4 
    v5 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v6 : string = "format!(\"{}\", $0)"
    let v7 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v6 
    v7 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v8 : std_string_String = null |> unbox<std_string_String>
    v8 
    #endif
#if FABLE_COMPILER_PYTHON
    let v9 : std_string_String = null |> unbox<std_string_String>
    v9 
    #endif
#else
    let v10 : std_string_String = null |> unbox<std_string_String>
    v10 
    #endif
    |> fun x -> _v1 <- Some x
    let v11 : std_string_String = match _v1 with Some x -> x | None -> failwith "base.run_target / _v1=None"
    v11
and method47 () : (std_io_Error -> std_string_String) =
    closure18()
and closure19 () (v0 : std_sync_Arc<std_sync_Mutex<std_process_Child option>>) : US22 =
    US22_0(v0)
and method48 () : (std_sync_Arc<std_sync_Mutex<std_process_Child option>> -> US22) =
    closure19()
and closure20 () (v0 : std_string_String) : US22 =
    US22_1(v0)
and method49 () : (std_string_String -> US22) =
    closure20()
and closure21 () () : string =
    let v0 : string = $"runtime.execute_with_options / child error"
    v0
and closure22 (v0 : std_string_String) () : string =
    let v1 : (unit -> string) = closure6()
    let v2 : string = $"error: {v0} / {v1 ()}"
    v2
and method50 (v0 : std_sync_Arc<std_sync_Mutex<std_process_Child option>>) : std_sync_Arc<std_sync_Mutex<std_process_Child option>> =
    v0
and closure23 () (v0 : std_string_String) : US24 =
    US24_0(v0)
and method51 () : (std_string_String -> US24) =
    closure23()
and closure24 () (v0 : std_string_String) : US24 =
    US24_1(v0)
and method52 () : (std_string_String -> US24) =
    closure24()
and closure25 () () : string =
    let v0 : string = $"runtime.stdio_line"
    v0
and closure26 (v0 : std_string_String) () : string =
    let v1 : (unit -> string) = closure6()
    let v2 : string = $"e: {v0} / {v1 ()}"
    v2
and closure27 (v0 : string) () : string =
    v0
and method53 (v0 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>>) : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>> =
    v0
and closure28 () (v0 : std_sync_mpsc_SendError<std_string_String>) : std_string_String =
    let v1 : bool = true
    let mutable _v1 : std_string_String option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = "format!(\"{}\", $0)"
    let v3 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v2 
    v3 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v4 : string = "format!(\"{}\", $0)"
    let v5 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v4 
    v5 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v6 : string = "format!(\"{}\", $0)"
    let v7 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v6 
    v7 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v8 : std_string_String = null |> unbox<std_string_String>
    v8 
    #endif
#if FABLE_COMPILER_PYTHON
    let v9 : std_string_String = null |> unbox<std_string_String>
    v9 
    #endif
#else
    let v10 : std_string_String = null |> unbox<std_string_String>
    v10 
    #endif
    |> fun x -> _v1 <- Some x
    let v11 : std_string_String = match _v1 with Some x -> x | None -> failwith "base.run_target / _v1=None"
    v11
and method54 () : (std_sync_mpsc_SendError<std_string_String> -> std_string_String) =
    closure28()
and method55 (v0 : Result<unit, string>) : Result<unit, string> =
    v0
and method56 (v0 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin option>>) : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin option>> =
    v0
and method57 (v0 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>>) : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> =
    v0
and method58 (v0 : std_sync_MutexGuard<std_process_ChildStdin>) : std_sync_MutexGuard<std_process_ChildStdin> =
    v0
and method59 (v0 : std_thread_JoinHandle<Result<unit, string>>) : std_thread_JoinHandle<Result<unit, string>> =
    v0
and closure29 () (v0 : std_process_Output) : US27 =
    US27_0(v0)
and closure30 () (v0 : std_string_String) : US27 =
    US27_1(v0)
and closure31 () () : string =
    let v0 : string = $"runtime.execute_with_options / output error"
    v0
and closure32 (v0 : std_string_String) () : string =
    let v1 : (unit -> string) = closure6()
    let v2 : string = $"error: {v0} / {v1 ()}"
    v2
and method60 (v0 : std_sync_Arc<std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>>) : std_sync_Arc<std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>> =
    v0
and closure33 () () : string =
    let v0 : string = $"runtime.execute_with_options / result"
    v0
and closure34 (v0 : int32, v1 : string) () : string =
    let v2 : string = $"exit_code: {v0}"
    let v3 : (unit -> string) = closure6()
    let v4 : string = $" / std_trace.Length: {v1.Length} / {v3 ()}"
    let v5 : string = v2 + v4 
    v5
and closure35 (v0 : System.Threading.CancellationToken option, v1 : string, v2 : (struct (string * string) []), v3 : (struct (bool * string * int32) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option) () : string =
    let v7 : string = $"runtime.execute_with_options_async / options: %A{struct (v0, v1, v2, v3, v4, v5, v6)}"
    v7
and method62 () : (unit -> string) =
    closure6()
and closure37 (v0 : string) () : string =
    v0
and closure36 (v0 : System.Threading.CancellationToken option, v1 : string, v2 : (struct (string * string) []), v3 : (struct (bool * string * int32) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option, v7 : System.Diagnostics.Process, v8 : System.Collections.Concurrent.ConcurrentStack<string>) (v9 : System.Diagnostics.DataReceivedEventArgs) : unit =
    let v10 : bool = true
    let mutable _v10 : Async<unit> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v11 : Async<unit> = null |> unbox<Async<unit>>
    v11 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v12 : Async<unit> = null |> unbox<Async<unit>>
    v12 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v13 : Async<unit> = null |> unbox<Async<unit>>
    v13 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v14 : Async<unit> = null |> unbox<Async<unit>>
    v14 
    #endif
#if FABLE_COMPILER_PYTHON
    let v15 : Async<unit> = null |> unbox<Async<unit>>
    v15 
    #endif
#else
    let v16 : Async<unit> option = None
    let mutable _v16 = v16 
    async {
    let v17 : string = v9.Data
    let v18 : string = null |> unbox<string>
    let v19 : bool = v17 = v18
    let v20 : bool = v19 <> true
    if v20 then
        let v21 : US29 option = None
        let _v21 = ref v21 
        match v3 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v22 : (struct (bool * string * int32) -> Async<unit>) = x
        let v23 : US29 = US29_0(v22)
        v23 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v21.Value <- x
        let v24 : US29 option = _v21.Value 
        let v25 : US29 = US29_1
        let v26 : US29 = v24 |> Option.defaultValue v25 
        match v26 with
        | US29_1 -> (* None *)
            ()
        | US29_0(v27) -> (* Some *)
            let v28 : int32 = v7.Id
            let v29 : Async<unit> = v27 struct (false, v17, v28)
            do! v29 
            ()
        let v30 : string = $"> {v17}"
        if v5 then
            let v31 : US0 = US0_0
            let v32 : (unit -> string) = closure37(v30)
            let v33 : (unit -> string) = closure6()
            method5(v31, v32, v33)
        else
            let v34 : (string -> unit) = System.Console.WriteLine
            v34 v30
        let v35 : string = ""
        let v36 : string = $"{v35}{v17}{v35}"
        let v37 : (string -> unit) = v8.Push
        v37 v36
    }
    |> fun x -> _v16 <- Some x
    let v38 : Async<unit> = match _v16 with Some x -> x | None -> failwith "async.new_async_unit / _v16=None"
    v38 
    #endif
    |> fun x -> _v10 <- Some x
    let v39 : Async<unit> = match _v10 with Some x -> x | None -> failwith "base.run_target / _v10=None"
    let v40 : bool = true
    let mutable _v40 : unit option = None 
    
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
    let v41 : (Async<unit> -> unit) = Async.StartImmediate
    v41 v39
    () 
    #endif
    |> fun x -> _v40 <- Some x
    match _v40 with Some x -> x | None -> failwith "base.run_target / _v40=None"
    ()
and closure38 (v0 : System.Threading.CancellationToken option, v1 : string, v2 : (struct (string * string) []), v3 : (struct (bool * string * int32) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option, v7 : System.Diagnostics.Process, v8 : System.Collections.Concurrent.ConcurrentStack<string>) (v9 : System.Diagnostics.DataReceivedEventArgs) : unit =
    let v10 : bool = true
    let mutable _v10 : Async<unit> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v11 : Async<unit> = null |> unbox<Async<unit>>
    v11 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v12 : Async<unit> = null |> unbox<Async<unit>>
    v12 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v13 : Async<unit> = null |> unbox<Async<unit>>
    v13 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v14 : Async<unit> = null |> unbox<Async<unit>>
    v14 
    #endif
#if FABLE_COMPILER_PYTHON
    let v15 : Async<unit> = null |> unbox<Async<unit>>
    v15 
    #endif
#else
    let v16 : Async<unit> option = None
    let mutable _v16 = v16 
    async {
    let v17 : string = v9.Data
    let v18 : string = null |> unbox<string>
    let v19 : bool = v17 = v18
    let v20 : bool = v19 <> true
    if v20 then
        let v21 : US29 option = None
        let _v21 = ref v21 
        match v3 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v22 : (struct (bool * string * int32) -> Async<unit>) = x
        let v23 : US29 = US29_0(v22)
        v23 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v21.Value <- x
        let v24 : US29 option = _v21.Value 
        let v25 : US29 = US29_1
        let v26 : US29 = v24 |> Option.defaultValue v25 
        match v26 with
        | US29_1 -> (* None *)
            ()
        | US29_0(v27) -> (* Some *)
            let v28 : int32 = v7.Id
            let v29 : Async<unit> = v27 struct (true, v17, v28)
            do! v29 
            ()
        let v30 : string = $"! {v17}"
        if v5 then
            let v31 : US0 = US0_0
            let v32 : (unit -> string) = closure37(v30)
            let v33 : (unit -> string) = closure6()
            method5(v31, v32, v33)
        else
            let v34 : (string -> unit) = System.Console.WriteLine
            v34 v30
        let v35 : string = "\u001b[7;4m"
        let v36 : string = "\u001b[0m"
        let v37 : string = $"{v35}{v17}{v36}"
        let v38 : (string -> unit) = v8.Push
        v38 v37
    }
    |> fun x -> _v16 <- Some x
    let v39 : Async<unit> = match _v16 with Some x -> x | None -> failwith "async.new_async_unit / _v16=None"
    v39 
    #endif
    |> fun x -> _v10 <- Some x
    let v40 : Async<unit> = match _v10 with Some x -> x | None -> failwith "base.run_target / _v10=None"
    let v41 : bool = true
    let mutable _v41 : unit option = None 
    
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
    let v42 : (Async<unit> -> unit) = Async.StartImmediate
    v42 v40
    () 
    #endif
    |> fun x -> _v41 <- Some x
    match _v41 with Some x -> x | None -> failwith "base.run_target / _v41=None"
    ()
and closure39 (v0 : System.Diagnostics.Process) () : unit =
    let v1 : bool = true
    let mutable _v1 : bool option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : bool = null |> unbox<bool>
    v2 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v3 : bool = null |> unbox<bool>
    v3 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v4 : bool = null |> unbox<bool>
    v4 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v5 : bool = null |> unbox<bool>
    v5 
    #endif
#if FABLE_COMPILER_PYTHON
    let v6 : bool = null |> unbox<bool>
    v6 
    #endif
#else
    let v7 : bool = v0.HasExited
    v7 
    #endif
    |> fun x -> _v1 <- Some x
    let v8 : bool = match _v1 with Some x -> x | None -> failwith "base.run_target / _v1=None"
    let v9 : bool = v8 = false
    if v9 then
        let v10 : bool = true
        let mutable _v10 : unit option = None 
        
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
        let v11 : (unit -> unit) = v0.Kill
        v11 ()
        () 
        #endif
        |> fun x -> _v10 <- Some x
        match _v10 with Some x -> x | None -> failwith "base.run_target / _v10=None"
        ()
and closure40 (v0 : System.Threading.Tasks.TaskCanceledException) () : string =
    let v1 : string = $"runtime.execute_with_options_async / WaitForExitAsync / ex: %A{v0}"
    v1
and closure41 (v0 : int32, v1 : string) () : string =
    let v2 : string = $"runtime.execute_with_options_async / exit_code: {v0} / output.Length: {v1.Length}"
    v2
and method61 (v0 : System.Threading.CancellationToken option, v1 : string, v2 : (struct (string * string) []), v3 : (struct (bool * string * int32) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option) : Async<struct (int32 * string)> =
    let v7 : bool = true
    let mutable _v7 : Async<struct (int32 * string)> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v8 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v8 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v9 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v9 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v10 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v10 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v11 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v11 
    #endif
#if FABLE_COMPILER_PYTHON
    let v12 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v12 
    #endif
#else
    let v13 : bool = true
    let mutable _v13 : Async<struct (int32 * string)> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v14 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v14 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v15 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v15 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v16 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v16 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v17 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v17 
    #endif
#if FABLE_COMPILER_PYTHON
    let v18 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v18 
    #endif
#else
    let v19 : Async<struct (int32 * string)> option = None
    let mutable _v19 = v19 
    async {
    let struct (v20 : string, v21 : string) = method30(v1)
    let v22 : US3 option = None
    let _v22 = ref v22 
    match v6 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v23 : string = x
    let v24 : US3 = US3_0(v23)
    v24 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v22.Value <- x
    let v25 : US3 option = _v22.Value 
    let v26 : US3 = US3_1
    let v27 : US3 = v25 |> Option.defaultValue v26 
    let v31 : string =
        match v27 with
        | US3_1 -> (* None *)
            let v29 : string = ""
            v29
        | US3_0(v28) -> (* Some *)
            v28
    let v32 : US0 = US0_1
    let v33 : (unit -> string) = closure35(v0, v1, v2, v3, v4, v5, v6)
    let v34 : (unit -> string) = method62()
    method5(v32, v33, v34)
    let v35 : System.Text.Encoding = System.Text.Encoding.UTF8
    let v36 : System.Diagnostics.ProcessStartInfo = System.Diagnostics.ProcessStartInfo (Arguments = v21, StandardOutputEncoding = v35, WorkingDirectory = v31, FileName = v20, CreateNoWindow = true, RedirectStandardError = true, RedirectStandardOutput = true, UseShellExecute = false)
    let v37 : int32 = v2.Length
    let v38 : Mut4 = {l0 = 0} : Mut4
    while method32(v37, v38) do
        let v40 : int32 = v38.l0
        let struct (v41 : string, v42 : string) = v2.[int v40]
        v36.EnvironmentVariables.[v41] <- v42 
        let v43 : int32 = v40 + 1
        v38.l0 <- v43
        ()
    let v44 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v36)
    use v44 = v44 
    let v45 : System.Diagnostics.Process = v44 
    let v46 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
    let v47 : System.Collections.Concurrent.ConcurrentStack<string> = v46 ()
    let v48 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure36(v0, v1, v2, v3, v4, v5, v6, v45, v47)
    v45.OutputDataReceived.Add v48 
    let v49 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure38(v0, v1, v2, v3, v4, v5, v6, v45, v47)
    v45.ErrorDataReceived.Add v49 
    let v50 : (unit -> bool) = v45.Start
    let v51 : bool = v50 ()
    let v52 : bool = v51 = false
    if v52 then
        let v53 : string = $"runtime.execute_with_options_async / process_start error"
        failwith<unit> v53
    let v54 : (unit -> unit) = v45.BeginErrorReadLine
    v54 ()
    let v55 : (unit -> unit) = v45.BeginOutputReadLine
    v55 ()
    let v56 : US30 option = None
    let _v56 = ref v56 
    match v0 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v57 : System.Threading.CancellationToken = x
    let v58 : US30 = US30_0(v57)
    v58 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v56.Value <- x
    let v59 : US30 option = _v56.Value 
    let v60 : US30 = US30_1
    let v61 : US30 = v59 |> Option.defaultValue v60 
    let v65 : System.Threading.CancellationToken =
        match v61 with
        | US30_1 -> (* None *)
            let v63 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
            v63
        | US30_0(v62) -> (* Some *)
            v62
    let v66 : bool = true
    let mutable _v66 : Async<System.Threading.CancellationToken> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v67 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v67 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v68 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v68 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v69 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v69 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v70 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v70 
    #endif
#if FABLE_COMPILER_PYTHON
    let v71 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v71 
    #endif
#else
    let v72 : bool = true
    let mutable _v72 : Async<System.Threading.CancellationToken> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v73 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v73 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v74 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v74 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v75 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v75 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v76 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v76 
    #endif
#if FABLE_COMPILER_PYTHON
    let v77 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v77 
    #endif
#else
    let v78 : Async<System.Threading.CancellationToken> option = None
    let mutable _v78 = v78 
    async {
    let v79 : Async<System.Threading.CancellationToken> = Async.CancellationToken
    let! v79 = v79 
    let v80 : System.Threading.CancellationToken = v79 
    let v81 : System.Threading.CancellationToken = Async.DefaultCancellationToken
    let v82 : (System.Threading.CancellationToken []) = [|v80; v81; v65|]
    let v83 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
    let v84 : System.Threading.CancellationTokenSource = v83 v82
    let v85 : System.Threading.CancellationToken = v84.Token
    return v85 
    }
    |> fun x -> _v78 <- Some x
    let v86 : Async<System.Threading.CancellationToken> = match _v78 with Some x -> x | None -> failwith "async.new_async_unit / _v78=None"
    v86 
    #endif
    |> fun x -> _v72 <- Some x
    let v87 : Async<System.Threading.CancellationToken> = match _v72 with Some x -> x | None -> failwith "base.run_target / _v72=None"
    v87 
    #endif
    |> fun x -> _v66 <- Some x
    let v88 : Async<System.Threading.CancellationToken> = match _v66 with Some x -> x | None -> failwith "base.run_target / _v66=None"
    let! v88 = v88 
    let v89 : System.Threading.CancellationToken = v88 
    let v90 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v89.Register
    let v91 : (unit -> unit) = closure39(v45)
    let v92 : System.Threading.CancellationTokenRegistration = v90 v91
    use v92 = v92 
    let v93 : System.Threading.CancellationTokenRegistration = v92 
    let v94 : bool = true
    let mutable _v94 : Async<int32> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v95 : Async<int32> = null |> unbox<Async<int32>>
    v95 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v96 : Async<int32> = null |> unbox<Async<int32>>
    v96 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v97 : Async<int32> = null |> unbox<Async<int32>>
    v97 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v98 : Async<int32> = null |> unbox<Async<int32>>
    v98 
    #endif
#if FABLE_COMPILER_PYTHON
    let v99 : Async<int32> = null |> unbox<Async<int32>>
    v99 
    #endif
#else
    let v100 : Async<int32> option = None
    let mutable _v100 = v100 
    async {
    try
    let v101 : System.Threading.Tasks.Task = v45.WaitForExitAsync v89 
    let v102 : bool = true
    let mutable _v102 : Async<unit> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v103 : Async<unit> = null |> unbox<Async<unit>>
    v103 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v104 : Async<unit> = null |> unbox<Async<unit>>
    v104 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v105 : Async<unit> = null |> unbox<Async<unit>>
    v105 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v106 : Async<unit> = null |> unbox<Async<unit>>
    v106 
    #endif
#if FABLE_COMPILER_PYTHON
    let v107 : Async<unit> = null |> unbox<Async<unit>>
    v107 
    #endif
#else
    let v108 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
    let v109 : Async<unit> = v108 v101
    v109 
    #endif
    |> fun x -> _v102 <- Some x
    let v110 : Async<unit> = match _v102 with Some x -> x | None -> failwith "base.run_target / _v102=None"
    do! v110 
    let v111 : int32 = v45.ExitCode
    return v111 
    with ex ->
    let v112 : exn = ex
    let v113 : bool = true
    let mutable _v113 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v114 : string = $"%A{v112}"
    v114 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v115 : string = $"%A{v112}"
    v115 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v116 : string = $"%A{v112}"
    v116 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v117 : string = $"%A{v112}"
    v117 
    #endif
#if FABLE_COMPILER_PYTHON
    let v118 : string = $"%A{v112}"
    v118 
    #endif
#else
    let v119 : string = $"{v112.GetType ()}: {v112.Message}"
    v119 
    #endif
    |> fun x -> _v113 <- Some x
    let v120 : string = match _v113 with Some x -> x | None -> failwith "base.run_target / _v113=None"
    let v121 : (string -> unit) = v47.Push
    v121 v120
    let v122 : System.Threading.Tasks.TaskCanceledException = v112 |> unbox<System.Threading.Tasks.TaskCanceledException>
    let v123 : US0 = US0_3
    let v124 : (unit -> string) = closure40(v122)
    let v125 : (unit -> string) = method62()
    method5(v123, v124, v125)
    return -2147483648 
    (*
    *)
    }
    |> fun x -> _v100 <- Some x
    let v126 : Async<int32> = match _v100 with Some x -> x | None -> failwith "async.new_async_unit / _v100=None"
    v126 
    #endif
    |> fun x -> _v94 <- Some x
    let v127 : Async<int32> = match _v94 with Some x -> x | None -> failwith "base.run_target / _v94=None"
    let! v127 = v127 
    let v128 : int32 = v127 
    let v129 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.rev
    let v130 : string seq = v129 v47
    let v131 : (string -> (string seq -> string)) = String.concat
    let v132 : string = "\n"
    let v133 : (string seq -> string) = v131 v132
    let v134 : string = v133 v130
    let v135 : US0 = US0_1
    let v136 : (unit -> string) = closure41(v128, v134)
    let v137 : (unit -> string) = method62()
    method5(v135, v136, v137)
    return struct (v128, v134) 
    }
    |> fun x -> _v19 <- Some x
    let v138 : Async<struct (int32 * string)> = match _v19 with Some x -> x | None -> failwith "async.new_async_unit / _v19=None"
    v138 
    #endif
    |> fun x -> _v13 <- Some x
    let v139 : Async<struct (int32 * string)> = match _v13 with Some x -> x | None -> failwith "base.run_target / _v13=None"
    v139 
    #endif
    |> fun x -> _v7 <- Some x
    let v140 : Async<struct (int32 * string)> = match _v7 with Some x -> x | None -> failwith "base.run_target / _v7=None"
    v140
and method28 (v0 : System.Threading.CancellationToken option, v1 : string, v2 : (struct (string * string) []), v3 : (struct (bool * string * int32) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option) : struct (int32 * string) =
    let v7 : bool = true
    let mutable _v7 : struct (int32 * string) option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v8 : string = method29(v0, v1, v2, v3, v4, v5, v6)
    let struct (v9 : string, v10 : string) = method30(v8)
    let v11 : US15 = method35(v10)
    let v17 : (string []) =
        match v11 with
        | US15_1(v13) -> (* Error *)
            let v14 : string = $"resultm.get / Result value was Error: {v13}"
            failwith<(string [])> v14
        | US15_0(v12) -> (* Ok *)
            v12
    let v18 : string = "$0.to_vec()"
    let v19 : Vec<string> = Fable.Core.RustInterop.emitRustExpr v17 v18 
    let v20 : string = "true; let _result : Vec<_> = v19.into_iter().map(|x| { //"
    let v21 : bool = Fable.Core.RustInterop.emitRustExpr () v20 
    let v22 : string = "x"
    let v23 : string = Fable.Core.RustInterop.emitRustExpr () v22 
    let v24 : string = "&*$0"
    let v25 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v23 v24 
    let v26 : string = "String::from($0)"
    let v27 : std_string_String = Fable.Core.RustInterop.emitRustExpr v25 v26 
    let v28 : string = "true; $0 }).collect::<Vec<_>>()"
    let v29 : bool = Fable.Core.RustInterop.emitRustExpr v27 v28 
    let v30 : string = "_result"
    let v31 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v30 
    let v32 : US0 = US0_1
    let v33 : (unit -> string) = closure16()
    let v34 : (unit -> string) = closure17(v0, v1, v2, v3, v4, v5, v6, v9, v31)
    method5(v32, v33, v34)
    let v35 : bool = true
    let mutable _v35 : (int32 * string) option = None 
    (
    (fun () ->
    (fun () ->
    let v36 : string = "std::process::Command::new(&*$0)"
    let v37 : std_process_Command = Fable.Core.RustInterop.emitRustExpr v9 v36 
    let v38 : string = "true; let mut v37 = v37"
    let v39 : bool = Fable.Core.RustInterop.emitRustExpr () v38 
    let v40 : string = "std::process::Command::args(&mut $0, &*$1)"
    let v41 : Ref<Mut<std_process_Command>> = Fable.Core.RustInterop.emitRustExpr struct (v37, v31) v40 
    let v42 : string = "std::process::Stdio::piped()"
    let v43 : std_process_Stdio = Fable.Core.RustInterop.emitRustExpr () v42 
    let v44 : string = "std::process::Command::stdout($0, std::process::Stdio::piped())"
    let v45 : Ref<Mut<std_process_Command>> = Fable.Core.RustInterop.emitRustExpr v41 v44 
    let v46 : string = "std::process::Stdio::piped()"
    let v47 : std_process_Stdio = Fable.Core.RustInterop.emitRustExpr () v46 
    let v48 : string = "std::process::Command::stderr($0, std::process::Stdio::piped())"
    let v49 : Ref<Mut<std_process_Command>> = Fable.Core.RustInterop.emitRustExpr v45 v48 
    let v50 : string = "std::process::Stdio::piped()"
    let v51 : std_process_Stdio = Fable.Core.RustInterop.emitRustExpr () v50 
    let v52 : string = "std::process::Command::stdin($0, std::process::Stdio::piped())"
    let v53 : Ref<Mut<std_process_Command>> = Fable.Core.RustInterop.emitRustExpr v49 v52 
    let v54 : US3 option = None
    let _v54 = ref v54 
    match v6 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v55 : string = x
    let v56 : US3 = US3_0(v55)
    v56 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v54.Value <- x
    let v57 : US3 option = _v54.Value 
    let v58 : US3 = US3_1
    let v59 : US3 = v57 |> Option.defaultValue v58 
    let v64 : Ref<Mut<std_process_Command>> =
        match v59 with
        | US3_1 -> (* None *)
            v53
        | US3_0(v60) -> (* Some *)
            let v61 : string = "std::process::Command::current_dir(v53, &*$0)"
            let v62 : Ref<Mut<std_process_Command>> = Fable.Core.RustInterop.emitRustExpr v60 v61 
            v62
    let v65 : uint64 = System.Convert.ToUInt64 v2.Length
    let v66 : bool = v65 = 0UL
    let v82 : Ref<Mut<std_process_Command>> =
        if v66 then
            v64
        else
            let v67 : string = "$0.to_vec()"
            let v68 : Vec<struct (string * string)> = Fable.Core.RustInterop.emitRustExpr v2 v67 
            let v69 : string = "true; let _result = $0.into_iter().fold(v64, |acc, x| { //"
            let v70 : bool = Fable.Core.RustInterop.emitRustExpr v68 v69 
            let v71 : string = "acc"
            let v72 : Ref<Mut<std_process_Command>> = Fable.Core.RustInterop.emitRustExpr () v71 
            let v73 : string = "x"
            let struct (v74 : string, v75 : string) = Fable.Core.RustInterop.emitRustExpr () v73 
            let v76 : string = "std::process::Command::env(v72, &*$0, &*$1)"
            let v77 : Ref<Mut<std_process_Command>> = Fable.Core.RustInterop.emitRustExpr struct (v74, v75) v76 
            let v78 : string = "true; $0 })"
            let v79 : bool = Fable.Core.RustInterop.emitRustExpr v77 v78 
            let v80 : string = "_result"
            let v81 : Ref<Mut<std_process_Command>> = Fable.Core.RustInterop.emitRustExpr () v80 
            v81
    let v83 : string = "std::process::Command::spawn($0)"
    let v84 : Result<std_process_Child, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v82 v83 
    let v85 : (std_io_Error -> std_string_String) = method47()
    let v86 : string = "$0.map_err(|x| $1(x))"
    let v87 : Result<std_process_Child, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v84, v85) v86 
    let v88 : string = "true; let _result = $0.map(|x| { //"
    let v89 : bool = Fable.Core.RustInterop.emitRustExpr v87 v88 
    let v90 : string = "x"
    let v91 : std_process_Child = Fable.Core.RustInterop.emitRustExpr () v90 
    let v92 : std_process_Child option = Some v91 
    let v93 : string = "std::sync::Mutex::new($0)"
    let v94 : std_sync_Mutex<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr v92 v93 
    let v95 : string = "std::sync::Arc::new($0)"
    let v96 : std_sync_Arc<std_sync_Mutex<std_process_Child option>> = Fable.Core.RustInterop.emitRustExpr v94 v95 
    let v97 : string = "true; $0 })"
    let v98 : bool = Fable.Core.RustInterop.emitRustExpr v96 v97 
    let v99 : string = "_result"
    let v100 : Result<std_sync_Arc<std_sync_Mutex<std_process_Child option>>, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v99 
    let v101 : (std_sync_Arc<std_sync_Mutex<std_process_Child option>> -> US22) = method48()
    let v102 : (std_string_String -> US22) = method49()
    let v103 : string = "match v100 { Ok(x) => $0(x), Err(e) => $1(e) }"
    let v104 : US22 = Fable.Core.RustInterop.emitRustExpr struct (v101, v102) v103 
    let struct (v500 : int32, v501 : US5, v502 : US23) =
        match v104 with
        | US22_1(v491) -> (* Error *)
            let v492 : US0 = US0_4
            let v493 : (unit -> string) = closure21()
            let v494 : (unit -> string) = closure22(v491)
            method5(v492, v493, v494)
            let v495 : US5 = US5_0(v491)
            let v496 : US23 = US23_1
            struct (-1, v495, v496)
        | US22_0(v105) -> (* Ok *)
            let v106 : string = "true; let _result = (|| { //"
            let v107 : bool = Fable.Core.RustInterop.emitRustExpr () v106 
            let v108 : std_sync_Arc<std_sync_Mutex<std_process_Child option>> = method50(v105)
            let v109 : string = "v108.lock()"
            let v110 : Result<std_sync_MutexGuard<std_process_Child option>, std_sync_PoisonError<std_sync_MutexGuard<std_process_Child option>>> = Fable.Core.RustInterop.emitRustExpr () v109 
            let v111 : string = "$0.unwrap()"
            let v112 : std_sync_MutexGuard<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr v110 v111 
            let v113 : string = "true; let mut v112 = v112"
            let v114 : bool = Fable.Core.RustInterop.emitRustExpr () v113 
            let v115 : string = "&mut $0"
            let v116 : Ref<Mut<std_process_Child option>> = Fable.Core.RustInterop.emitRustExpr v112 v115 
            let v117 : string = "$0.as_mut()"
            let v118 : Ref<Mut<std_process_Child>> option = Fable.Core.RustInterop.emitRustExpr v116 v117 
            let v119 : string = "$0.unwrap()"
            let v120 : Ref<Mut<std_process_Child>> = Fable.Core.RustInterop.emitRustExpr v118 v119 
            let v121 : string = "&mut v120.stdout"
            let v122 : Ref<Mut<std_process_ChildStdout option>> = Fable.Core.RustInterop.emitRustExpr () v121 
            let v123 : string = "Option::take($0)"
            let v124 : std_process_ChildStdout option = Fable.Core.RustInterop.emitRustExpr v122 v123 
            let v125 : string = "$0.unwrap()"
            let v126 : std_process_ChildStdout = Fable.Core.RustInterop.emitRustExpr v124 v125 
            let v127 : string = "true; $0 })()"
            let v128 : bool = Fable.Core.RustInterop.emitRustExpr v126 v127 
            let v129 : string = "_result"
            let v130 : std_process_ChildStdout = Fable.Core.RustInterop.emitRustExpr () v129 
            let v131 : string = "true; let _result = (|| { //"
            let v132 : bool = Fable.Core.RustInterop.emitRustExpr () v131 
            let v133 : std_sync_Arc<std_sync_Mutex<std_process_Child option>> = method50(v105)
            let v134 : string = "v133.lock()"
            let v135 : Result<std_sync_MutexGuard<std_process_Child option>, std_sync_PoisonError<std_sync_MutexGuard<std_process_Child option>>> = Fable.Core.RustInterop.emitRustExpr () v134 
            let v136 : string = "$0.unwrap()"
            let v137 : std_sync_MutexGuard<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr v135 v136 
            let v138 : string = "true; let mut v137 = v137"
            let v139 : bool = Fable.Core.RustInterop.emitRustExpr () v138 
            let v140 : string = "&mut $0"
            let v141 : Ref<Mut<std_process_Child option>> = Fable.Core.RustInterop.emitRustExpr v137 v140 
            let v142 : string = "$0.as_mut()"
            let v143 : Ref<Mut<std_process_Child>> option = Fable.Core.RustInterop.emitRustExpr v141 v142 
            let v144 : string = "$0.unwrap()"
            let v145 : Ref<Mut<std_process_Child>> = Fable.Core.RustInterop.emitRustExpr v143 v144 
            let v146 : string = "&mut v145.stderr"
            let v147 : Ref<Mut<std_process_ChildStderr option>> = Fable.Core.RustInterop.emitRustExpr () v146 
            let v148 : string = "Option::take($0)"
            let v149 : std_process_ChildStderr option = Fable.Core.RustInterop.emitRustExpr v147 v148 
            let v150 : string = "$0.unwrap()"
            let v151 : std_process_ChildStderr = Fable.Core.RustInterop.emitRustExpr v149 v150 
            let v152 : string = "true; $0 })()"
            let v153 : bool = Fable.Core.RustInterop.emitRustExpr v151 v152 
            let v154 : string = "_result"
            let v155 : std_process_ChildStderr = Fable.Core.RustInterop.emitRustExpr () v154 
            let v156 : string = "true; let _result = (|| { //"
            let v157 : bool = Fable.Core.RustInterop.emitRustExpr () v156 
            let v158 : std_sync_Arc<std_sync_Mutex<std_process_Child option>> = method50(v105)
            let v159 : string = "v158.lock()"
            let v160 : Result<std_sync_MutexGuard<std_process_Child option>, std_sync_PoisonError<std_sync_MutexGuard<std_process_Child option>>> = Fable.Core.RustInterop.emitRustExpr () v159 
            let v161 : string = "$0.unwrap()"
            let v162 : std_sync_MutexGuard<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr v160 v161 
            let v163 : string = "true; let mut v162 = v162"
            let v164 : bool = Fable.Core.RustInterop.emitRustExpr () v163 
            let v165 : string = "&mut $0"
            let v166 : Ref<Mut<std_process_Child option>> = Fable.Core.RustInterop.emitRustExpr v162 v165 
            let v167 : string = "$0.as_mut()"
            let v168 : Ref<Mut<std_process_Child>> option = Fable.Core.RustInterop.emitRustExpr v166 v167 
            let v169 : string = "$0.unwrap()"
            let v170 : Ref<Mut<std_process_Child>> = Fable.Core.RustInterop.emitRustExpr v168 v169 
            let v171 : string = "&mut $0.stdin"
            let v172 : Ref<Mut<std_process_ChildStdin option>> = Fable.Core.RustInterop.emitRustExpr v170 v171 
            let v173 : string = "Option::take($0)"
            let v174 : std_process_ChildStdin option = Fable.Core.RustInterop.emitRustExpr v172 v173 
            let v175 : string = "$0.unwrap()"
            let v176 : std_process_ChildStdin = Fable.Core.RustInterop.emitRustExpr v174 v175 
            let v177 : std_process_ChildStdin option = Some v176 
            let v178 : string = "std::sync::Mutex::new($0)"
            let v179 : std_sync_Mutex<std_process_ChildStdin option> = Fable.Core.RustInterop.emitRustExpr v177 v178 
            let v180 : string = "std::sync::Arc::new($0)"
            let v181 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin option>> = Fable.Core.RustInterop.emitRustExpr v179 v180 
            let v182 : string = "true; $0 })()"
            let v183 : bool = Fable.Core.RustInterop.emitRustExpr v181 v182 
            let v184 : string = "_result"
            let v185 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin option>> = Fable.Core.RustInterop.emitRustExpr () v184 
            let v186 : string = "{ let (sender, receiver) = std::sync::mpsc::channel(); (sender, std::sync::Arc::new(receiver)) }"
            let struct (v187 : std_sync_mpsc_Sender<std_string_String>, v188 : std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>) = Fable.Core.RustInterop.emitRustExpr () v186 
            let v189 : string = "std::sync::Mutex::new($0)"
            let v190 : std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>> = Fable.Core.RustInterop.emitRustExpr v187 v189 
            let v191 : string = "std::sync::Arc::new($0)"
            let v192 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr v190 v191 
            let v193 : string = "std::sync::Mutex::new($0)"
            let v194 : std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>> = Fable.Core.RustInterop.emitRustExpr v187 v193 
            let v195 : string = "std::sync::Arc::new($0)"
            let v196 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr v194 v195 
            let v197 : string = "std::sync::Mutex::new($0)"
            let v198 : std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr v188 v197 
            let v199 : string = "std::sync::Arc::new($0)"
            let v200 : std_sync_Arc<std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>> = Fable.Core.RustInterop.emitRustExpr v198 v199 
            let v201 : string = "true; let __result = std::thread::spawn(move || { //"
            let v202 : bool = Fable.Core.RustInterop.emitRustExpr () v201 
            let v203 : string = "encoding_rs_io::DecodeReaderBytesBuilder::new().utf8_passthru(true).build($0)"
            let v204 : encoding_rs_io_DecodeReaderBytes<std_process_ChildStdout, Vec<uint8>> = Fable.Core.RustInterop.emitRustExpr v130 v203 
            let v205 : string = "std::io::BufReader::new(v204)"
            let v206 : std_io_BufReader<encoding_rs_io_DecodeReaderBytes<std_process_ChildStdout, Vec<uint8>>> = Fable.Core.RustInterop.emitRustExpr () v205 
            let v207 : string = "std::io::BufRead::lines(v206)"
            let v208 : std_io_Lines<std_io_BufReader<encoding_rs_io_DecodeReaderBytes<std_process_ChildStdout, Vec<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v207 
            let v209 : string = "true; let mut v208 = v208; let _result = v208.try_for_each(|x| { //"
            let v210 : bool = Fable.Core.RustInterop.emitRustExpr () v209 
            let v211 : string = "x"
            let v212 : Result<std_string_String, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v211 
            let v213 : string = "$0.clone()"
            let v214 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr v192 v213 
            let v215 : (std_io_Error -> std_string_String) = method47()
            let v216 : string = "$0.map_err(|x| $1(x))"
            let v217 : Result<std_string_String, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v212, v215) v216 
            let v218 : (std_string_String -> US24) = method51()
            let v219 : (std_string_String -> US24) = method52()
            let v220 : string = "match v217 { Ok(x) => $0(x), Err(e) => $1(e) }"
            let v221 : US24 = Fable.Core.RustInterop.emitRustExpr struct (v218, v219) v220 
            let v254 : std_string_String =
                match v221 with
                | US24_1(v244) -> (* Error *)
                    let v245 : US0 = US0_4
                    let v246 : (unit -> string) = closure25()
                    let v247 : (unit -> string) = closure26(v244)
                    method5(v245, v246, v247)
                    let v248 : string = $"\u001b[4;7m{v244}\u001b[0m"
                    let v249 : string = "&*$0"
                    let v250 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v248 v249 
                    let v251 : string = "String::from($0)"
                    let v252 : std_string_String = Fable.Core.RustInterop.emitRustExpr v250 v251 
                    v252
                | US24_0(v222) -> (* Ok *)
                    let v223 : string = "fable_library_rust::String_::fromString($0)"
                    let v224 : string = Fable.Core.RustInterop.emitRustExpr v222 v223 
                    let v225 : string = "encoding_rs::UTF_8"
                    let v226 : Ref<encoding_rs_Encoding> = Fable.Core.RustInterop.emitRustExpr () v225 
                    let v227 : string = "$0.encode(&*$1).0"
                    let v228 : std_borrow_Cow<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr struct (v226, v224) v227 
                    let v229 : string = "$0.as_ref()"
                    let v230 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr v228 v229 
                    let v231 : string = "std::str::from_utf8(v230)"
                    let v232 : Result<Ref<Str>, std_str_Utf8Error> = Fable.Core.RustInterop.emitRustExpr () v231 
                    let v233 : string = "$0.unwrap()"
                    let v234 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v232 v233 
                    let v235 : string = "String::from($0)"
                    let v236 : std_string_String = Fable.Core.RustInterop.emitRustExpr v234 v235 
                    let v237 : string = "fable_library_rust::String_::fromString($0)"
                    let v238 : string = Fable.Core.RustInterop.emitRustExpr v236 v237 
                    let v239 : string = $"> {v238}"
                    if v5 then
                        let v240 : US0 = US0_0
                        let v241 : (unit -> string) = closure27(v239)
                        let v242 : (unit -> string) = closure6()
                        method5(v240, v241, v242)
                    else
                        let v243 : (string -> unit) = System.Console.WriteLine
                        v243 v239
                    v236
            let v255 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>> = method53(v214)
            let v256 : string = "v255.lock()"
            let v257 : Result<std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>>, std_sync_PoisonError<std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>>>> = Fable.Core.RustInterop.emitRustExpr () v256 
            let v258 : string = "$0.unwrap()"
            let v259 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = Fable.Core.RustInterop.emitRustExpr v257 v258 
            let v260 : string = "&$0"
            let v261 : Ref<std_sync_mpsc_Sender<std_string_String>> = Fable.Core.RustInterop.emitRustExpr v259 v260 
            let v262 : string = "$0.send($1)"
            let v263 : Result<unit, std_sync_mpsc_SendError<std_string_String>> = Fable.Core.RustInterop.emitRustExpr struct (v261, v254) v262 
            let v264 : (std_sync_mpsc_SendError<std_string_String> -> std_string_String) = method54()
            let v265 : string = "$0.map_err(|x| $1(x))"
            let v266 : Result<unit, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v263, v264) v265 
            let v267 : string = "$0"
            let v268 : core_ops_Try<unit> = Fable.Core.RustInterop.emitRustExpr v266 v267 
            let v269 : string = "true; $0 }); //"
            let v270 : bool = Fable.Core.RustInterop.emitRustExpr v268 v269 
            let v271 : string = "_result.map_err(|x| x.into())"
            let v272 : Result<unit, string> = Fable.Core.RustInterop.emitRustExpr () v271 
            let v273 : Result<unit, string> = method55(v272)
            let v274 : string = ""
            let v275 : string = "}"
            let v276 : string = v274 + v275 
            let v277 : string = "v273 " + v276 + "); " + v274 + " //"
            Fable.Core.RustInterop.emitRustExpr () v277 
            let v278 : string = "__result"
            let v279 : std_thread_JoinHandle<Result<unit, string>> = Fable.Core.RustInterop.emitRustExpr () v278 
            let v280 : string = "true; let __result = std::thread::spawn(move || { //"
            let v281 : bool = Fable.Core.RustInterop.emitRustExpr () v280 
            let v282 : string = "encoding_rs_io::DecodeReaderBytesBuilder::new().utf8_passthru(true).build($0)"
            let v283 : encoding_rs_io_DecodeReaderBytes<std_process_ChildStderr, Vec<uint8>> = Fable.Core.RustInterop.emitRustExpr v155 v282 
            let v284 : string = "std::io::BufReader::new(v283)"
            let v285 : std_io_BufReader<encoding_rs_io_DecodeReaderBytes<std_process_ChildStderr, Vec<uint8>>> = Fable.Core.RustInterop.emitRustExpr () v284 
            let v286 : string = "std::io::BufRead::lines(v285)"
            let v287 : std_io_Lines<std_io_BufReader<encoding_rs_io_DecodeReaderBytes<std_process_ChildStderr, Vec<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v286 
            let v288 : string = "true; let mut v287 = v287; let _result = v287.try_for_each(|x| { //"
            let v289 : bool = Fable.Core.RustInterop.emitRustExpr () v288 
            let v290 : string = "x"
            let v291 : Result<std_string_String, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v290 
            let v292 : string = "$0.clone()"
            let v293 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr v196 v292 
            let v294 : (std_io_Error -> std_string_String) = method47()
            let v295 : string = "$0.map_err(|x| $1(x))"
            let v296 : Result<std_string_String, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v291, v294) v295 
            let v297 : (std_string_String -> US24) = method51()
            let v298 : (std_string_String -> US24) = method52()
            let v299 : string = "match v296 { Ok(x) => $0(x), Err(e) => $1(e) }"
            let v300 : US24 = Fable.Core.RustInterop.emitRustExpr struct (v297, v298) v299 
            let v338 : std_string_String =
                match v300 with
                | US24_1(v328) -> (* Error *)
                    let v329 : US0 = US0_4
                    let v330 : (unit -> string) = closure25()
                    let v331 : (unit -> string) = closure26(v328)
                    method5(v329, v330, v331)
                    let v332 : string = $"\u001b[4;7m{v328}\u001b[0m"
                    let v333 : string = "&*$0"
                    let v334 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v332 v333 
                    let v335 : string = "String::from($0)"
                    let v336 : std_string_String = Fable.Core.RustInterop.emitRustExpr v334 v335 
                    v336
                | US24_0(v301) -> (* Ok *)
                    let v302 : string = "fable_library_rust::String_::fromString($0)"
                    let v303 : string = Fable.Core.RustInterop.emitRustExpr v301 v302 
                    let v304 : string = "encoding_rs::UTF_8"
                    let v305 : Ref<encoding_rs_Encoding> = Fable.Core.RustInterop.emitRustExpr () v304 
                    let v306 : string = "$0.encode(&*$1).0"
                    let v307 : std_borrow_Cow<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr struct (v305, v303) v306 
                    let v308 : string = "$0.as_ref()"
                    let v309 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr v307 v308 
                    let v310 : string = "std::str::from_utf8(v309)"
                    let v311 : Result<Ref<Str>, std_str_Utf8Error> = Fable.Core.RustInterop.emitRustExpr () v310 
                    let v312 : string = "$0.unwrap()"
                    let v313 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v311 v312 
                    let v314 : string = "String::from($0)"
                    let v315 : std_string_String = Fable.Core.RustInterop.emitRustExpr v313 v314 
                    let v316 : string = "fable_library_rust::String_::fromString($0)"
                    let v317 : string = Fable.Core.RustInterop.emitRustExpr v315 v316 
                    let v318 : string = $"! {v317}"
                    if v5 then
                        let v319 : US0 = US0_0
                        let v320 : (unit -> string) = closure27(v318)
                        let v321 : (unit -> string) = closure6()
                        method5(v319, v320, v321)
                    else
                        let v322 : (string -> unit) = System.Console.WriteLine
                        v322 v318
                    let v323 : string = $"\u001b[4;7m{v315}\u001b[0m"
                    let v324 : string = "&*$0"
                    let v325 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v323 v324 
                    let v326 : string = "String::from($0)"
                    let v327 : std_string_String = Fable.Core.RustInterop.emitRustExpr v325 v326 
                    v327
            let v339 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>> = method53(v293)
            let v340 : string = "v339.lock()"
            let v341 : Result<std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>>, std_sync_PoisonError<std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>>>> = Fable.Core.RustInterop.emitRustExpr () v340 
            let v342 : string = "$0.unwrap()"
            let v343 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = Fable.Core.RustInterop.emitRustExpr v341 v342 
            let v344 : string = "&$0"
            let v345 : Ref<std_sync_mpsc_Sender<std_string_String>> = Fable.Core.RustInterop.emitRustExpr v343 v344 
            let v346 : string = "$0.send($1)"
            let v347 : Result<unit, std_sync_mpsc_SendError<std_string_String>> = Fable.Core.RustInterop.emitRustExpr struct (v345, v338) v346 
            let v348 : (std_sync_mpsc_SendError<std_string_String> -> std_string_String) = method54()
            let v349 : string = "$0.map_err(|x| $1(x))"
            let v350 : Result<unit, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v347, v348) v349 
            let v351 : string = "$0"
            let v352 : core_ops_Try<unit> = Fable.Core.RustInterop.emitRustExpr v350 v351 
            let v353 : string = "true; $0 }); //"
            let v354 : bool = Fable.Core.RustInterop.emitRustExpr v352 v353 
            let v355 : string = "_result.map_err(|x| x.into())"
            let v356 : Result<unit, string> = Fable.Core.RustInterop.emitRustExpr () v355 
            let v357 : Result<unit, string> = method55(v356)
            let v358 : string = v274 + v275 
            let v359 : string = "v357 " + v358 + "); " + v274 + " //"
            Fable.Core.RustInterop.emitRustExpr () v359 
            let v360 : string = "__result"
            let v361 : std_thread_JoinHandle<Result<unit, string>> = Fable.Core.RustInterop.emitRustExpr () v360 
            let v362 : US25 option = None
            let _v362 = ref v362 
            match v4 with
            | Some x -> (
            (fun () ->
            (fun () ->
            let v363 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) = x
            let v364 : US25 = US25_0(v363)
            v364 
            )
            |> fun x -> x () |> Some
            ) () ) | None -> None
            |> fun x -> _v362.Value <- x
            let v365 : US25 option = _v362.Value 
            let v366 : US25 = US25_1
            let v367 : US25 = v365 |> Option.defaultValue v366 
            match v367 with
            | US25_1 -> (* None *)
                ()
            | US25_0(v368) -> (* Some *)
                let v369 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin option>> = method56(v185)
                let v370 : string = "v369.lock()"
                let v371 : Result<std_sync_MutexGuard<std_process_ChildStdin option>, std_sync_PoisonError<std_sync_MutexGuard<std_process_ChildStdin option>>> = Fable.Core.RustInterop.emitRustExpr () v370 
                let v372 : string = "$0.unwrap()"
                let v373 : std_sync_MutexGuard<std_process_ChildStdin option> = Fable.Core.RustInterop.emitRustExpr v371 v372 
                let v374 : string = "true; let mut v373 = v373"
                let v375 : bool = Fable.Core.RustInterop.emitRustExpr () v374 
                let v376 : string = "&mut $0"
                let v377 : Ref<Mut<std_process_ChildStdin option>> = Fable.Core.RustInterop.emitRustExpr v373 v376 
                let v378 : string = "Option::take($0)"
                let v379 : std_process_ChildStdin option = Fable.Core.RustInterop.emitRustExpr v377 v378 
                let v380 : string = "true; let _result = v379.map(|x| { //"
                let v381 : bool = Fable.Core.RustInterop.emitRustExpr () v380 
                let v382 : string = "x"
                let v383 : std_process_ChildStdin = Fable.Core.RustInterop.emitRustExpr () v382 
                let v384 : string = "std::sync::Mutex::new($0)"
                let v385 : std_sync_Mutex<std_process_ChildStdin> = Fable.Core.RustInterop.emitRustExpr v383 v384 
                let v386 : string = "std::sync::Arc::new($0)"
                let v387 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> = Fable.Core.RustInterop.emitRustExpr v385 v386 
                let v388 : string = "true; $0 })"
                let v389 : bool = Fable.Core.RustInterop.emitRustExpr v387 v388 
                let v390 : string = "_result"
                let v391 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> option = Fable.Core.RustInterop.emitRustExpr () v390 
                let v392 : US26 option = None
                let _v392 = ref v392 
                match v391 with
                | Some x -> (
                (fun () ->
                (fun () ->
                let v393 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> = x
                let v394 : US26 = US26_0(v393)
                v394 
                )
                |> fun x -> x () |> Some
                ) () ) | None -> None
                |> fun x -> _v392.Value <- x
                let v395 : US26 option = _v392.Value 
                let v396 : US26 = US26_1
                let v397 : US26 = v395 |> Option.defaultValue v396 
                match v397 with
                | US26_1 -> (* None *)
                    ()
                | US26_0(v398) -> (* Some *)
                    v368 v398
                    let v399 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> = method57(v398)
                    let v400 : string = "v399.lock()"
                    let v401 : Result<std_sync_MutexGuard<std_process_ChildStdin>, std_sync_PoisonError<std_sync_MutexGuard<std_process_ChildStdin>>> = Fable.Core.RustInterop.emitRustExpr () v400 
                    let v402 : string = "$0.unwrap()"
                    let v403 : std_sync_MutexGuard<std_process_ChildStdin> = Fable.Core.RustInterop.emitRustExpr v401 v402 
                    let v404 : std_sync_MutexGuard<std_process_ChildStdin> = method58(v403)
                    let v405 : string = "true; let mut v404 = v404"
                    let v406 : bool = Fable.Core.RustInterop.emitRustExpr () v405 
                    let v407 : string = "true; std::io::Write::flush(&mut *$0).unwrap()"
                    let v408 : bool = Fable.Core.RustInterop.emitRustExpr v404 v407 
                    ()
            let v409 : std_sync_Arc<std_sync_Mutex<std_process_Child option>> = method50(v105)
            let v410 : string = "v409.lock()"
            let v411 : Result<std_sync_MutexGuard<std_process_Child option>, std_sync_PoisonError<std_sync_MutexGuard<std_process_Child option>>> = Fable.Core.RustInterop.emitRustExpr () v410 
            let v412 : string = "$0.unwrap()"
            let v413 : std_sync_MutexGuard<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr v411 v412 
            let v414 : string = "true; let mut v413 = v413"
            let v415 : bool = Fable.Core.RustInterop.emitRustExpr () v414 
            let v416 : string = "&mut $0"
            let v417 : Ref<Mut<std_process_Child option>> = Fable.Core.RustInterop.emitRustExpr v413 v416 
            let v418 : string = "Option::take($0)"
            let v419 : std_process_Child option = Fable.Core.RustInterop.emitRustExpr v417 v418 
            let v420 : string = "$0.unwrap()"
            let v421 : std_process_Child = Fable.Core.RustInterop.emitRustExpr v419 v420 
            let v422 : string = "$0.wait_with_output()"
            let v423 : Result<std_process_Output, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v421 v422 
            let v424 : (std_io_Error -> std_string_String) = method47()
            let v425 : string = "$0.map_err(|x| $1(x))"
            let v426 : Result<std_process_Output, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v423, v424) v425 
            let v427 : std_thread_JoinHandle<Result<unit, string>> = method59(v361)
            let v428 : string = "v427"
            let v429 : string = v428 + v274 
            let v430 : string = v429 + v274 
            let v431 : std_thread_JoinHandle<Result<unit, string>> = method59(v279)
            let v432 : string = "v431"
            let v433 : string = ", "
            let v434 : string = v432 + v433 
            let v435 : string = v434 + v430 
            let v436 : string = "vec![" + v435 + "]"
            let v437 : Vec<std_thread_JoinHandle<Result<unit, string>>> = Fable.Core.RustInterop.emitRustExpr () v436 
            let v438 : string = "true; v437.into_iter().for_each(|x| { //"
            let v439 : bool = Fable.Core.RustInterop.emitRustExpr () v438 
            let v440 : string = "x"
            let v441 : std_thread_JoinHandle<Result<unit, string>> = Fable.Core.RustInterop.emitRustExpr () v440 
            let v442 : string = "std::thread::JoinHandle::join($0)"
            let v443 : Result<Result<unit, string>, Box<LifetimeRef<Dyn<LifetimeJoin<core_any_Any, LifetimeRef<LifetimeJoin<StaticLifetime, Send<StaticLifetime>>>>>>>> = Fable.Core.RustInterop.emitRustExpr v441 v442 
            let v444 : string = "$0.unwrap()"
            let v445 : Result<unit, string> = Fable.Core.RustInterop.emitRustExpr v443 v444 
            let v446 : string = "$0.unwrap()"
            Fable.Core.RustInterop.emitRustExpr v445 v446 
            let v447 : string = "true; () }}); { //"
            let v448 : bool = Fable.Core.RustInterop.emitRustExpr () v447 
            let v449 : (std_process_Output -> US27) = closure29()
            let v450 : (std_string_String -> US27) = closure30()
            let v451 : US27 = match v426 with Ok x -> v449 x | Error x -> v450 x
            match v451 with
            | US27_1(v479) -> (* Error *)
                let v480 : US0 = US0_4
                let v481 : (unit -> string) = closure31()
                let v482 : (unit -> string) = closure32(v479)
                method5(v480, v481, v482)
                let v483 : US5 = US5_0(v479)
                let v484 : US23 = US23_1
                struct (-2, v483, v484)
            | US27_0(v452) -> (* Ok *)
                let v453 : string = "$0.status"
                let v454 : std_process_ExitStatus = Fable.Core.RustInterop.emitRustExpr v452 v453 
                let v455 : string = "$0.code()"
                let v456 : int32 option = Fable.Core.RustInterop.emitRustExpr v454 v455 
                let v457 : US28 option = None
                let _v457 = ref v457 
                match v456 with
                | Some x -> (
                (fun () ->
                (fun () ->
                let v458 : int32 = x
                let v459 : US28 = US28_0(v458)
                v459 
                )
                |> fun x -> x () |> Some
                ) () ) | None -> None
                |> fun x -> _v457.Value <- x
                let v460 : US28 option = _v457.Value 
                let v461 : US28 = US28_1
                let v462 : US28 = v460 |> Option.defaultValue v461 
                match v462 with
                | US28_1 -> (* None *)
                    let v466 : string = "&*$0"
                    let v467 : string = "runtime.execute_with_options / exit_code=None"
                    let v468 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v467 v466 
                    let v469 : string = "String::from($0)"
                    let v470 : std_string_String = Fable.Core.RustInterop.emitRustExpr v468 v469 
                    let v471 : US5 = US5_0(v470)
                    let v472 : US23 = US23_0(v200)
                    struct (-1, v471, v472)
                | US28_0(v463) -> (* Some *)
                    let v464 : US5 = US5_1
                    let v465 : US23 = US23_0(v200)
                    struct (v463, v464, v465)
    let v507 : std_sync_Arc<std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>> option =
        match v502 with
        | US23_1 -> (* None *)
            let v505 : std_sync_Arc<std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>> option = None
            v505
        | US23_0(v503) -> (* Some *)
            let v504 : std_sync_Arc<std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>> option = Some v503 
            v504
    let v508 : string = "true; let _result = v507.map(|x| { //"
    let v509 : bool = Fable.Core.RustInterop.emitRustExpr () v508 
    let v510 : string = "x"
    let v511 : std_sync_Arc<std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>> = Fable.Core.RustInterop.emitRustExpr () v510 
    let v512 : std_sync_Arc<std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>> = method60(v511)
    let v513 : string = "v512.lock()"
    let v514 : Result<std_sync_MutexGuard<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>, std_sync_PoisonError<std_sync_MutexGuard<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>>> = Fable.Core.RustInterop.emitRustExpr () v513 
    let v515 : string = "$0.unwrap()"
    let v516 : std_sync_MutexGuard<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr v514 v515 
    let v517 : string = "v516.iter()"
    let v518 : _ = Fable.Core.RustInterop.emitRustExpr () v517 
    let v519 : string = "v518.collect::<Vec<_>>()"
    let v520 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v519 
    let v521 : string = "true; let _result : Vec<_> = v520.into_iter().map(|x| { //"
    let v522 : bool = Fable.Core.RustInterop.emitRustExpr () v521 
    let v523 : string = "x"
    let v524 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v523 
    let v525 : string = "fable_library_rust::String_::fromString($0)"
    let v526 : string = Fable.Core.RustInterop.emitRustExpr v524 v525 
    let v527 : string = "true; $0 }).collect::<Vec<_>>()"
    let v528 : bool = Fable.Core.RustInterop.emitRustExpr v526 v527 
    let v529 : string = "_result"
    let v530 : Vec<string> = Fable.Core.RustInterop.emitRustExpr () v529 
    let v531 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v532 : (string []) = Fable.Core.RustInterop.emitRustExpr v530 v531 
    let v533 : ((string []) -> string seq) = Seq.ofArray
    let v534 : string seq = v533 v532
    let v535 : (string -> (string seq -> string)) = String.concat
    let v536 : string = "\n"
    let v537 : (string seq -> string) = v535 v536
    let v538 : string = v537 v534
    let v539 : string = "true; $0 })"
    let v540 : bool = Fable.Core.RustInterop.emitRustExpr v538 v539 
    let v541 : string = "_result"
    let v542 : string option = Fable.Core.RustInterop.emitRustExpr () v541 
    let v549 : US3 =
        match v501 with
        | US5_1 -> (* None *)
            US3_1
        | US5_0(v543) -> (* Some *)
            let v544 : string = "fable_library_rust::String_::fromString($0)"
            let v545 : string = Fable.Core.RustInterop.emitRustExpr v543 v544 
            US3_0(v545)
    let v553 : string =
        match v549 with
        | US3_1 -> (* None *)
            let v551 : string = ""
            v551
        | US3_0(v550) -> (* Some *)
            v550
    let v554 : string = v542 |> Option.defaultValue v553 
    let v555 : US0 = US0_0
    let v556 : (unit -> string) = closure33()
    let v557 : (unit -> string) = closure34(v500, v554)
    method5(v555, v556, v557)
    let v558 : (int32 * string) = v500, v554 
    v558 
    )
    |> fun x -> x ()
    ) () )
    |> fun x -> _v35 <- Some x
    let v559 : (int32 * string) = match _v35 with Some x -> x | None -> failwith "base.capture / _v35=None"
    let (a, b) = v559 
    let v560 : int32 = a
    let v561 : string = b
    struct (v560, v561) 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let struct (v562 : int32, v563 : string) = null |> unbox<struct (int32 * string)>
    struct (v562, v563) 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let struct (v564 : int32, v565 : string) = null |> unbox<struct (int32 * string)>
    struct (v564, v565) 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let struct (v566 : int32, v567 : string) = null |> unbox<struct (int32 * string)>
    struct (v566, v567) 
    #endif
#if FABLE_COMPILER_PYTHON
    let struct (v568 : int32, v569 : string) = null |> unbox<struct (int32 * string)>
    struct (v568, v569) 
    #endif
#else
    let v570 : Async<struct (int32 * string)> = method61(v0, v1, v2, v3, v4, v5, v6)
    let v571 : bool = true
    let mutable _v571 : struct (int32 * string) option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let struct (v572 : int32, v573 : string) = null |> unbox<struct (int32 * string)>
    struct (v572, v573) 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let struct (v574 : int32, v575 : string) = null |> unbox<struct (int32 * string)>
    struct (v574, v575) 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let struct (v576 : int32, v577 : string) = null |> unbox<struct (int32 * string)>
    struct (v576, v577) 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let struct (v578 : int32, v579 : string) = null |> unbox<struct (int32 * string)>
    struct (v578, v579) 
    #endif
#if FABLE_COMPILER_PYTHON
    let struct (v580 : int32, v581 : string) = null |> unbox<struct (int32 * string)>
    struct (v580, v581) 
    #endif
#else
    let v582 : (Async<struct (int32 * string)> -> struct (int32 * string)) = Async.RunSynchronously
    let struct (v583 : int32, v584 : string) = v582 v570
    struct (v583, v584) 
    #endif
    |> fun x -> _v571 <- Some x
    let struct (v585 : int32, v586 : string) = match _v571 with Some x -> x | None -> failwith "base.run_target / _v571=None"
    struct (v585, v586) 
    #endif
    |> fun x -> _v7 <- Some x
    let struct (v587 : int32, v588 : string) = match _v7 with Some x -> x | None -> failwith "base.run_target / _v7=None"
    struct (v587, v588)
and closure42 () () : string =
    let v0 : string = "spiral_builder.process_cuda / env install error"
    v0
and closure43 (v0 : US8, v1 : string, v2 : string, v3 : int32) () : string =
    let v4 : string = $"env: {v0} / exit_code: {v3} / new_code_path: {v1} / run_result: {v2}"
    v4
and closure44 (v0 : string) () : string =
    let v1 : string = "\n"
    let v2 : (string []) = v0.Split v1 
    let v3 : ((string []) -> string seq) = Seq.ofArray
    let v4 : string seq = v3 v2
    let v5 : (string -> (string seq -> string)) = String.concat
    let v6 : (string seq -> string) = v5 v1
    v6 v4
and closure45 () (v0 : string) : US3 =
    US3_0(v0)
and closure47 () () : string =
    let v0 : string = "spiral_builder.process_cuda / Exception"
    v0
and closure48 (v0 : string, v1 : string, v2 : string, v3 : exn) () : string =
    let v4 : (unit -> string) = closure6()
    let v5 : string = $"ex: {v3} / new_code_path: {v0} / external_command: {v2} / run_result: {v1} / {v4 ()}"
    v5
and closure46 (v0 : string, v1 : string, v2 : string) (v3 : exn) : US3 =
    let v4 : US0 = US0_4
    let v5 : (unit -> string) = closure47()
    let v6 : (unit -> string) = closure48(v0, v1, v2, v3)
    method5(v4, v5, v6)
    US3_1
and closure49 () () : string =
    let v0 : string = "spiral_builder.process_cuda / error"
    v0
and closure50 (v0 : string, v1 : string, v2 : int32, v3 : string) () : string =
    let v4 : string = $"exit_code: {v2} / new_code_path: {v0} / external_command: {v3} / run_result: {v1}"
    v4
and closure51 () struct (v0 : string, v1 : string) : (std_string_String * std_string_String) =
    let v2 : string = "&*$0"
    let v3 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v2 
    let v4 : string = "String::from($0)"
    let v5 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3 v4 
    let v6 : string = "&*$0"
    let v7 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1 v6 
    let v8 : string = "String::from($0)"
    let v9 : std_string_String = Fable.Core.RustInterop.emitRustExpr v7 v8 
    let v10 : (std_string_String * std_string_String) = v5, v9 
    v10
and method63 () : string =
    let v0 : string = "fs-path"
    v0
and method64 () : string =
    let v0 : string = "command"
    v0
and method65 () : string =
    let v0 : string = "path"
    v0
and method69 (v0 : string) : string =
    v0
and method71 () : string =
    let v0 : string = ""
    v0
and method72 (v0 : string) : string =
    v0
and method73 () : string =
    let v0 : string = "^\\\\\\\\\\?\\\\"
    v0
and method70 (v0 : string) : string =
    let v1 : string = method71()
    let v2 : bool = true
    let mutable _v2 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : string = method72(v0)
    let v4 : string = $"regex::Regex::new(&$0)"
    let v5 : string = "^\\\\\\\\\\?\\\\"
    let v6 : Result<regex_Regex, regex_Error> = Fable.Core.RustInterop.emitRustExpr v5 v4 
    let v7 : string = "$0.unwrap()"
    let v8 : regex_Regex = Fable.Core.RustInterop.emitRustExpr v6 v7 
    let v9 : string = $"$0.replace_all(&$1, &*$2)"
    let v10 : std_borrow_Cow<Str> = Fable.Core.RustInterop.emitRustExpr struct (v8, v3, v1) v9 
    let v11 : string = "String::from($0)"
    let v12 : std_string_String = Fable.Core.RustInterop.emitRustExpr v10 v11 
    let v13 : string = "fable_library_rust::String_::fromString($0)"
    let v14 : string = Fable.Core.RustInterop.emitRustExpr v12 v13 
    v14 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v15 : string = null |> unbox<string>
    v15 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v16 : string = null |> unbox<string>
    v16 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v17 : string = null |> unbox<string>
    v17 
    #endif
#if FABLE_COMPILER_PYTHON
    let v18 : string = null |> unbox<string>
    v18 
    #endif
#else
    let v19 : string = method73()
    let v20 : string = System.Text.RegularExpressions.Regex.Replace (v0, v19, v1)
    v20 
    #endif
    |> fun x -> _v2 <- Some x
    let v21 : string = match _v2 with Some x -> x | None -> failwith "base.run_target / _v2=None"
    let v22 : string = $"{v21.[0] |> string |> _.ToLower()}{v21.[1..]}"
    let v23 : string = "\\"
    let v24 : string = "/"
    let v25 : string = v22.Replace (v23, v24)
    v25
and method74 (v0 : int32, v1 : Mut5) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method75 () : char =
    let v0 : bool = true
    let mutable _v0 : char option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1 : string = "std::path::MAIN_SEPARATOR"
    let v2 : char = Fable.Core.RustInterop.emitRustExpr () v1 
    v2 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v3 : char = System.IO.Path.DirectorySeparatorChar
    v3 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v4 : char = System.IO.Path.DirectorySeparatorChar
    v4 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v5 : char = System.IO.Path.DirectorySeparatorChar
    v5 
    #endif
#if FABLE_COMPILER_PYTHON
    let v6 : char = System.IO.Path.DirectorySeparatorChar
    v6 
    #endif
#else
    let v7 : char = System.IO.Path.DirectorySeparatorChar
    v7 
    #endif
    |> fun x -> _v0 <- Some x
    let v8 : char = match _v0 with Some x -> x | None -> failwith "base.run_target / _v0=None"
    v8
and method76 (v0 : string) : string =
    v0
and method68 (v0 : string) : string =
    let v1 : bool = true
    let mutable _v1 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = method69(v0)
    let v3 : string = "&*$0"
    let v4 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v2 v3 
    let v5 : string = "String::from($0)"
    let v6 : std_string_String = Fable.Core.RustInterop.emitRustExpr v4 v5 
    let v7 : string = "std::path::PathBuf::from($0)"
    let v8 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v6 v7 
    let v9 : string = "$0.exists()"
    let v10 : bool = Fable.Core.RustInterop.emitRustExpr v8 v9 
    let v11 : bool = v10 = false
    let v101 : string =
        if v11 then
            let v12 : string = method14()
            let v13 : string = method15(v12, v2)
            let v14 : string = method70(v13)
            let v15 : string = "/"
            let v16 : (string []) = v14.Split v15 
            let v17 : (string []) = [||]
            let v18 : int32 = v16.Length
            let v19 : Mut5 = {l0 = 0; l1 = 0; l2 = v17} : Mut5
            while method74(v18, v19) do
                let v21 : int32 = v19.l0
                let v22 : int32 =  -v21
                let v23 : int32 = v22 + v18
                let v24 : int32 = v23 - 1
                let struct (v25 : int32, v26 : (string [])) = v19.l1, v19.l2
                let v27 : string = v16.[int v24]
                let v28 : bool = ".." = v27
                let struct (v70 : int32, v71 : (string [])) =
                    if v28 then
                        let v29 : int32 = v25 + 1
                        struct (v29, v26)
                    else
                        let v30 : bool = "." = v27
                        if v30 then
                            struct (v25, v26)
                        else
                            let v31 : bool = 0 = v25
                            if v31 then
                                let v32 : string = ":"
                                let v33 : bool = v27.EndsWith v32 
                                if v33 then
                                    let v34 : string = $"{v12.[0]}:"
                                    let v35 : (string []) = [|v34|]
                                    let v36 : int32 = v35.Length
                                    let v37 : int32 = v26.Length
                                    let v38 : int32 = v36 + v37
                                    let v39 : (string []) = Array.zeroCreate<string> (v38)
                                    let v40 : Mut4 = {l0 = 0} : Mut4
                                    while method32(v38, v40) do
                                        let v42 : int32 = v40.l0
                                        let v43 : bool = v42 < v36
                                        let v47 : string =
                                            if v43 then
                                                let v44 : string = v35.[int v42]
                                                v44
                                            else
                                                let v45 : int32 = v42 - v36
                                                let v46 : string = v26.[int v45]
                                                v46
                                        v39.[int v42] <- v47
                                        let v48 : int32 = v42 + 1
                                        v40.l0 <- v48
                                        ()
                                    struct (0, v39)
                                else
                                    let v49 : (string []) = [|v27|]
                                    let v50 : int32 = v49.Length
                                    let v51 : int32 = v26.Length
                                    let v52 : int32 = v50 + v51
                                    let v53 : (string []) = Array.zeroCreate<string> (v52)
                                    let v54 : Mut4 = {l0 = 0} : Mut4
                                    while method32(v52, v54) do
                                        let v56 : int32 = v54.l0
                                        let v57 : bool = v56 < v50
                                        let v61 : string =
                                            if v57 then
                                                let v58 : string = v49.[int v56]
                                                v58
                                            else
                                                let v59 : int32 = v56 - v50
                                                let v60 : string = v26.[int v59]
                                                v60
                                        v53.[int v56] <- v61
                                        let v62 : int32 = v56 + 1
                                        v54.l0 <- v62
                                        ()
                                    struct (0, v53)
                            else
                                let v65 : int32 = v25 - 1
                                struct (v65, v26)
                let v72 : int32 = v21 + 1
                v19.l0 <- v72
                v19.l1 <- v70
                v19.l2 <- v71
                ()
            let struct (v73 : int32, v74 : (string [])) = v19.l1, v19.l2
            let v75 : string seq = seq { for i = 0 to v74.Length - 1 do yield v74.[i] }
            let v76 : char = method75()
            let v77 : (char -> string) = _.ToString()
            let v78 : string = v77 v76
            let v79 : (string -> (string seq -> string)) = String.concat
            let v80 : (string seq -> string) = v79 v78
            v80 v75
        else
            let v82 : string = "std::fs::canonicalize(&*$0)"
            let v83 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v2 v82 
            let v84 : string = "$0.unwrap()"
            let v85 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v83 v84 
            let v86 : string = "$0.display()"
            let v87 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v85 v86 
            let v88 : bool = true
            let mutable _v88 : std_string_String option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v89 : string = "format!(\"{}\", $0)"
            let v90 : std_string_String = Fable.Core.RustInterop.emitRustExpr v87 v89 
            v90 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v91 : string = "format!(\"{}\", $0)"
            let v92 : std_string_String = Fable.Core.RustInterop.emitRustExpr v87 v91 
            v92 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v93 : string = "format!(\"{}\", $0)"
            let v94 : std_string_String = Fable.Core.RustInterop.emitRustExpr v87 v93 
            v94 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v95 : std_string_String = null |> unbox<std_string_String>
            v95 
            #endif
#if FABLE_COMPILER_PYTHON
            let v96 : std_string_String = null |> unbox<std_string_String>
            v96 
            #endif
#else
            let v97 : std_string_String = null |> unbox<std_string_String>
            v97 
            #endif
            |> fun x -> _v88 <- Some x
            let v98 : std_string_String = match _v88 with Some x -> x | None -> failwith "base.run_target / _v88=None"
            let v99 : string = "fable_library_rust::String_::fromString($0)"
            let v100 : string = Fable.Core.RustInterop.emitRustExpr v98 v99 
            v100
    v101 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v102 : string = null |> unbox<string>
    v102 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v103 : string = null |> unbox<string>
    v103 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v104 : string = null |> unbox<string>
    v104 
    #endif
#if FABLE_COMPILER_PYTHON
    let v105 : string = null |> unbox<string>
    v105 
    #endif
#else
    let v106 : string = method76(v0)
    let v107 : (string -> string) = System.IO.Path.GetFullPath
    let v108 : string = v107 v106
    v108 
    #endif
    |> fun x -> _v1 <- Some x
    let v109 : string = match _v1 with Some x -> x | None -> failwith "base.run_target / _v1=None"
    v109
and method67 (v0 : string) : string =
    let v1 : string = method68(v0)
    method70(v1)
and method66 (v0 : string) : string =
    let v1 : string = method14()
    let v2 : string = method15(v1, v0)
    method67(v2)
and closure52 () (v0 : std_string_String) : string =
    let v1 : string = "fable_library_rust::String_::fromString($0)"
    let v2 : string = Fable.Core.RustInterop.emitRustExpr v0 v1 
    method66(v2)
and method77 () : string =
    let v0 : string = "retries"
    v0
and method78 () : string =
    let v0 : string = "working-directory"
    v0
and closure53 () () : string =
    let v0 : string = "spiral_builder.run / repl error"
    v0
and closure54 (v0 : uint8, v1 : uint8, v2 : string, v3 : int32) () : string =
    let v4 : (unit -> string) = closure6()
    let v5 : string = $"exit_code: {v3} / retry: {v1}/{v0} / repl_result: {v2} / {v4 ()}"
    v5
and method79 (v0 : string option, v1 : uint8, v2 : string, v3 : uint8) : struct (int32 * string) =
    let v4 : System.Threading.CancellationToken option = None
    let v5 : (struct (string * string) []) = [||]
    let v6 : (struct (bool * string * int32) -> Async<unit>) option = None
    let v7 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = None
    let v8 : string option = None
    let v9 : string = $"dotnet repl --exit-after-run --run \"{v2}\" --output-path \"{v2}.ipynb\""
    let v10 : string = "TRACE_LEVEL"
    let v11 : string = "Verbose"
    let v12 : string = "AUTOMATION"
    let v13 : string = "True"
    let v14 : (struct (string * string) []) = [|struct (v10, v11); struct (v12, v13)|]
    let v15 : bool = false
    let struct (v16 : int32, v17 : string) = method28(v4, v9, v14, v6, v7, v15, v0)
    let v18 : bool = v16 = 0
    let v20 : bool =
        if v18 then
            true
        else
            let v19 : bool = v3 >= v1
            v19
    if v20 then
        struct (v16, v17)
    else
        let v21 : US0 = US0_1
        let v22 : (unit -> string) = closure53()
        let v23 : (unit -> string) = closure54(v1, v3, v17, v16)
        method5(v21, v22, v23)
        let v24 : uint8 = v3 + 1uy
        method79(v0, v1, v2, v24)
and closure55 () () : string =
    let v0 : string = "spiral_builder.run / dib / jupyter nbconvert"
    v0
and closure56 (v0 : string, v1 : int32) () : string =
    let v2 : (unit -> string) = closure6()
    let v3 : string = $"exit_code: {v1} / jupyter_result.Length: {v0.Length} / {v2 ()}"
    v3
and closure57 () () : string =
    let v0 : string = "spiral_builder.run / dib / html cell ids"
    v0
and closure58 (v0 : string, v1 : int32) () : string =
    let v2 : (unit -> string) = closure6()
    let v3 : string = $"exit_code: {v1} / pwsh_replace_html_result.Length: {v0.Length} / {v2 ()}"
    v3
and closure59 () () : string =
    let v0 : string = "spiral_builder.run / dib"
    v0
and closure60 (v0 : string, v1 : int32) () : string =
    let v2 : (unit -> string) = closure6()
    let v3 : string = $"exit_code: {v1} / result.Length: {v0.Length} / {v2 ()}"
    v3
and method81 () : string =
    let v0 : string = ""
    v0
and method80 (v0 : string) : string =
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
    let v114 : Mut4 = {l0 = 0} : Mut4
    while method32(v112, v114) do
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
    let v123 : string = method81()
    let v124 : (string -> (string seq -> string)) = String.concat
    let v125 : (string seq -> string) = v124 v123
    let v126 : string = v125 v122
    v126 
    #endif
    |> fun x -> _v1 <- Some x
    let v127 : string = match _v1 with Some x -> x | None -> failwith "base.run_target / _v1=None"
    v127
and method83 (v0 : string) : string =
    v0
and closure61 () () : US31 =
    US31_0
and closure62 () (v0 : std_string_String) : US31 =
    US31_1(v0)
and closure63 () () : string =
    let v0 : string = "file_system.create_dir"
    v0
and closure64 (v0 : string, v1 : std_string_String) () : string =
    let v2 : (unit -> string) = closure6()
    let v3 : string = $"dir: {v0} / error: {v1} / {v2 ()}"
    v3
and closure65 () () : string =
    let v0 : string = "file_system.create_dir"
    v0
and closure66 (v0 : string) () : string =
    let v1 : (unit -> string) = closure6()
    let v2 : string = $"dir: {v0} / {v1 ()}"
    v2
and method86 (v0 : string) : string =
    v0
and method85 (v0 : bool, v1 : string) : unit =
    let v2 : bool = true
    let mutable _v2 : unit option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : string = method86(v1)
    let v4 : bool = method19(v3)
    if v4 then
        if v0 then
            let v5 : string = "std::fs::remove_dir_all(&*$0).unwrap()"
            Fable.Core.RustInterop.emitRustExpr v3 v5 
            ()
        else
            let v6 : string = "std::fs::remove_dir(&*$0).unwrap()"
            Fable.Core.RustInterop.emitRustExpr v3 v6 
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
    System.IO.Directory.Delete (v1, v0)
    () 
    #endif
    |> fun x -> _v2 <- Some x
    match _v2 with Some x -> x | None -> failwith "base.run_target / _v2=None"
    ()
and closure67 (v0 : string) () : unit =
    let v1 : bool = true
    method85(v1, v0)
and method84 (v0 : string) : (unit -> unit) =
    closure67(v0)
and method87 (v0 : string) : (unit -> unit) =
    closure67(v0)
and closure68 () () : string =
    let v0 : string = "file_system.create_dir"
    v0
and closure69 (v0 : string, v1 : string) () : string =
    let v2 : (unit -> string) = closure6()
    let v3 : string = $"dir: {v0} / result: {v1} {v2 ()}"
    v3
and closure71 () () : string =
    let v0 : string = "file_system.delete_directory_async"
    v0
and method90 (v0 : string) : string =
    let v1 : bool = true
    let mutable _v1 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = "&*$0"
    let v3 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v2 
    let v4 : string = "String::from($0)"
    let v5 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3 v4 
    let v6 : string = "std::path::PathBuf::from($0)"
    let v7 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v5 v6 
    let v8 : string = "$0.file_name()"
    let v9 : Ref<std_ffi_OsStr> option = Fable.Core.RustInterop.emitRustExpr v7 v8 
    let v10 : string = "$0.unwrap()"
    let v11 : Ref<std_ffi_OsStr> = Fable.Core.RustInterop.emitRustExpr v9 v10 
    let v12 : string = "$0.to_os_string()"
    let v13 : std_ffi_OsString = Fable.Core.RustInterop.emitRustExpr v11 v12 
    let v14 : string = "$0.to_str()"
    let v15 : Ref<Str> option = Fable.Core.RustInterop.emitRustExpr v13 v14 
    let v16 : string = "$0.unwrap()"
    let v17 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v15 v16 
    let v18 : string = "String::from($0)"
    let v19 : std_string_String = Fable.Core.RustInterop.emitRustExpr v17 v18 
    let v20 : string = "fable_library_rust::String_::fromString($0)"
    let v21 : string = Fable.Core.RustInterop.emitRustExpr v19 v20 
    v21 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v22 : US10 = US10_1
    let v23 : US11 = US11_2(v22)
    let v24 : string = $"file_system.get_file_name / target: {v23} / path: {v0}"
    let v25 : string = failwith<string> v24
    v25 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v26 : string = null |> unbox<string>
    v26 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v27 : US10 = US10_0
    let v28 : US11 = US11_3(v27)
    let v29 : string = $"file_system.get_file_name / target: {v28} / path: {v0}"
    let v30 : string = failwith<string> v29
    v30 
    #endif
#if FABLE_COMPILER_PYTHON
    let v31 : US10 = US10_0
    let v32 : US11 = US11_4(v31)
    let v33 : string = $"file_system.get_file_name / target: {v32} / path: {v0}"
    let v34 : string = failwith<string> v33
    v34 
    #endif
#else
    let v35 : (string -> string) = System.IO.Path.GetFileName
    let v36 : string = v35 v0
    v36 
    #endif
    |> fun x -> _v1 <- Some x
    let v37 : string = match _v1 with Some x -> x | None -> failwith "base.run_target / _v1=None"
    v37
and closure73 () (v0 : string) : string =
    method90(v0)
and closure72 (v0 : string, v1 : string) () : string =
    let v2 : (string -> string) = closure73()
    let v3 : (unit -> string) = closure6()
    let v4 : string = $"path: {v0 |> v2} / ex: {v1} / {v3 ()}"
    v4
and method89 (v0 : string, v1 : int64) : Async<int64> =
    let v2 : bool = true
    let mutable _v2 : Async<int64> option = None 
    
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
    let v8 : Async<int64> option = None
    let mutable _v8 = v8 
    async {
    try
    let v9 : bool = true
    method85(v9, v0)
    return v1 
    with ex ->
    let v10 : exn = ex
    let v11 : int64 = v1 % 100L
    let v12 : bool = v11 = 0L
    if v12 then
        let v13 : bool = true
        let mutable _v13 : string option = None 
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v14 : string = $"%A{v10}"
        v14 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v15 : string = $"%A{v10}"
        v15 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v16 : string = $"%A{v10}"
        v16 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v17 : string = $"%A{v10}"
        v17 
        #endif
#if FABLE_COMPILER_PYTHON
        let v18 : string = $"%A{v10}"
        v18 
        #endif
#else
        let v19 : string = $"{v10.GetType ()}: {v10.Message}"
        v19 
        #endif
        |> fun x -> _v13 <- Some x
        let v20 : string = match _v13 with Some x -> x | None -> failwith "base.run_target / _v13=None"
        let v21 : US0 = US0_1
        let v22 : (unit -> string) = closure71()
        let v23 : (unit -> string) = closure72(v0, v20)
        method5(v21, v22, v23)
    let v24 : bool = true
    let mutable _v24 : Async<unit> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v25 : Async<unit> = null |> unbox<Async<unit>>
    v25 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v26 : Async<unit> = null |> unbox<Async<unit>>
    v26 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v27 : Async<unit> = null |> unbox<Async<unit>>
    v27 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v28 : Async<unit> = null |> unbox<Async<unit>>
    v28 
    #endif
#if FABLE_COMPILER_PYTHON
    let v29 : Async<unit> = null |> unbox<Async<unit>>
    v29 
    #endif
#else
    let v30 : (int32 -> Async<unit>) = Async.Sleep
    let v31 : Async<unit> = v30 10
    v31 
    #endif
    |> fun x -> _v24 <- Some x
    let v32 : Async<unit> = match _v24 with Some x -> x | None -> failwith "base.run_target / _v24=None"
    do! v32 
    let v33 : int64 = v1 + 1L
    let v34 : Async<int64> = method89(v0, v33)
    return! v34 
    (*
    let v35 : int64 = *)
    }
    |> fun x -> _v8 <- Some x
    let v36 : Async<int64> = match _v8 with Some x -> x | None -> failwith "async.new_async_unit / _v8=None"
    v36 
    #endif
    |> fun x -> _v2 <- Some x
    let v37 : Async<int64> = match _v2 with Some x -> x | None -> failwith "base.run_target / _v2=None"
    v37
and closure70 (v0 : string) () : unit =
    let v1 : bool = true
    let mutable _v1 : Async<int64> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : Async<int64> = null |> unbox<Async<int64>>
    v2 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v3 : Async<int64> = null |> unbox<Async<int64>>
    v3 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v4 : Async<int64> = null |> unbox<Async<int64>>
    v4 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v5 : Async<int64> = null |> unbox<Async<int64>>
    v5 
    #endif
#if FABLE_COMPILER_PYTHON
    let v6 : Async<int64> = null |> unbox<Async<int64>>
    v6 
    #endif
#else
    let v7 : int64 = 0L
    let v8 : Async<int64> = method89(v0, v7)
    v8 
    #endif
    |> fun x -> _v1 <- Some x
    let v9 : Async<int64> = match _v1 with Some x -> x | None -> failwith "base.run_target / _v1=None"
    let v10 : bool = true
    let mutable _v10 : Async<unit> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v11 : Async<unit> = null |> unbox<Async<unit>>
    v11 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v12 : Async<unit> = null |> unbox<Async<unit>>
    v12 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v13 : Async<unit> = null |> unbox<Async<unit>>
    v13 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v14 : Async<unit> = null |> unbox<Async<unit>>
    v14 
    #endif
#if FABLE_COMPILER_PYTHON
    let v15 : Async<unit> = null |> unbox<Async<unit>>
    v15 
    #endif
#else
    let v16 : (Async<int64> -> Async<unit>) = Async.Ignore
    let v17 : Async<unit> = v16 v9
    v17 
    #endif
    |> fun x -> _v10 <- Some x
    let v18 : Async<unit> = match _v10 with Some x -> x | None -> failwith "base.run_target / _v10=None"
    let v19 : bool = true
    let mutable _v19 : unit option = None 
    
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
    let v20 : (Async<unit> -> unit) = Async.RunSynchronously
    v20 v18
    () 
    #endif
    |> fun x -> _v19 <- Some x
    match _v19 with Some x -> x | None -> failwith "base.run_target / _v19=None"
    ()
and method88 (v0 : string) : (unit -> unit) =
    closure70(v0)
and method91 (v0 : string) : (unit -> unit) =
    closure70(v0)
and method82 (v0 : string) : System.IDisposable =
    let v1 : bool = true
    let mutable _v1 : System.IDisposable option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = method83(v0)
    let v3 : string = "std::fs::create_dir_all(&*$0)"
    let v4 : Result<unit, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v2 v3 
    let v5 : (std_io_Error -> std_string_String) = method47()
    let v6 : string = "$0.map_err(|x| $1(x))"
    let v7 : Result<unit, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v4, v5) v6 
    let v8 : (unit -> US31) = closure61()
    let v9 : (std_string_String -> US31) = closure62()
    let v10 : US31 = match v7 with Ok () -> v8 () | Error x -> v9 x
    match v10 with
    | US31_1(v14) -> (* Error *)
        let v15 : US0 = US0_4
        let v16 : (unit -> string) = closure63()
        let v17 : (unit -> string) = closure64(v2, v14)
        method5(v15, v16, v17)
    | US31_0 -> (* Ok *)
        let v11 : US0 = US0_0
        let v12 : (unit -> string) = closure65()
        let v13 : (unit -> string) = closure66(v2)
        method5(v11, v12, v13)
    let v18 : bool = true
    let mutable _v18 : System.IDisposable option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v19 : (unit -> unit) = method84(v2)
    let v20 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v19 "$0()" )
    v20 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v21 : (unit -> unit) = method84(v2)
    let v22 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v21 "$0()" )
    v22 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v23 : (unit -> unit) = method84(v2)
    let v24 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v23 "$0()" )
    v24 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v25 : System.IDisposable = null |> unbox<System.IDisposable>
    v25 
    #endif
#if FABLE_COMPILER_PYTHON
    let v26 : System.IDisposable = null |> unbox<System.IDisposable>
    v26 
    #endif
#else
    let v27 : (unit -> unit) = method87(v2)
    let v28 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v27 () }
    v28 
    #endif
    |> fun x -> _v18 <- Some x
    let v29 : System.IDisposable = match _v18 with Some x -> x | None -> failwith "base.run_target / _v18=None"
    v29 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v30 : System.IDisposable = null |> unbox<System.IDisposable>
    v30 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v31 : System.IDisposable = null |> unbox<System.IDisposable>
    v31 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v32 : bool = true
    let mutable _v32 : System.IO.DirectoryInfo option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v33 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    v33 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v34 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    v34 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v35 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    v35 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v36 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    v36 
    #endif
#if FABLE_COMPILER_PYTHON
    let v37 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    v37 
    #endif
#else
    let v38 : (string -> System.IO.DirectoryInfo) = System.IO.Directory.CreateDirectory
    let v39 : System.IO.DirectoryInfo = v38 v0
    v39 
    #endif
    |> fun x -> _v32 <- Some x
    let v40 : System.IO.DirectoryInfo = match _v32 with Some x -> x | None -> failwith "base.run_target / _v32=None"
    let v41 : bool = true
    let mutable _v41 : bool option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v42 : bool = null |> unbox<bool>
    v42 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v43 : bool = null |> unbox<bool>
    v43 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v44 : bool = null |> unbox<bool>
    v44 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v45 : bool = null |> unbox<bool>
    v45 
    #endif
#if FABLE_COMPILER_PYTHON
    let v46 : bool = null |> unbox<bool>
    v46 
    #endif
#else
    let v47 : bool = v40.Exists
    v47 
    #endif
    |> fun x -> _v41 <- Some x
    let v48 : bool = match _v41 with Some x -> x | None -> failwith "base.run_target / _v41=None"
    let v49 : bool = v48 = false
    if v49 then
        let v50 : bool = true
        let mutable _v50 : System.DateTime option = None 
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v51 : System.DateTime = null |> unbox<System.DateTime>
        v51 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v52 : System.DateTime = null |> unbox<System.DateTime>
        v52 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v53 : System.DateTime = null |> unbox<System.DateTime>
        v53 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v54 : System.DateTime = null |> unbox<System.DateTime>
        v54 
        #endif
#if FABLE_COMPILER_PYTHON
        let v55 : System.DateTime = null |> unbox<System.DateTime>
        v55 
        #endif
#else
        let v56 : System.DateTime = v40.CreationTime
        v56 
        #endif
        |> fun x -> _v50 <- Some x
        let v57 : System.DateTime = match _v50 with Some x -> x | None -> failwith "base.run_target / _v50=None"
        let v58 : obj = {| Exists = v48; CreationTime = v57 |}
        let v59 : string = $"%A{v58}"
        let v60 : US0 = US0_1
        let v61 : (unit -> string) = closure68()
        let v62 : (unit -> string) = closure69(v0, v59)
        method5(v60, v61, v62)
    let v63 : bool = true
    let mutable _v63 : System.IDisposable option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v64 : (unit -> unit) = method88(v0)
    let v65 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v64 "$0()" )
    v65 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v66 : (unit -> unit) = method88(v0)
    let v67 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v66 "$0()" )
    v67 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v68 : (unit -> unit) = method88(v0)
    let v69 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v68 "$0()" )
    v69 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v70 : System.IDisposable = null |> unbox<System.IDisposable>
    v70 
    #endif
#if FABLE_COMPILER_PYTHON
    let v71 : System.IDisposable = null |> unbox<System.IDisposable>
    v71 
    #endif
#else
    let v72 : (unit -> unit) = method91(v0)
    let v73 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v72 () }
    v73 
    #endif
    |> fun x -> _v63 <- Some x
    let v74 : System.IDisposable = match _v63 with Some x -> x | None -> failwith "base.run_target / _v63=None"
    v74 
    #endif
#if FABLE_COMPILER_PYTHON
    let v75 : bool = true
    let mutable _v75 : System.IO.DirectoryInfo option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v76 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    v76 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v77 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    v77 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v78 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    v78 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v79 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    v79 
    #endif
#if FABLE_COMPILER_PYTHON
    let v80 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    v80 
    #endif
#else
    let v81 : (string -> System.IO.DirectoryInfo) = System.IO.Directory.CreateDirectory
    let v82 : System.IO.DirectoryInfo = v81 v0
    v82 
    #endif
    |> fun x -> _v75 <- Some x
    let v83 : System.IO.DirectoryInfo = match _v75 with Some x -> x | None -> failwith "base.run_target / _v75=None"
    let v84 : bool = true
    let mutable _v84 : bool option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v85 : bool = null |> unbox<bool>
    v85 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v86 : bool = null |> unbox<bool>
    v86 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v87 : bool = null |> unbox<bool>
    v87 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v88 : bool = null |> unbox<bool>
    v88 
    #endif
#if FABLE_COMPILER_PYTHON
    let v89 : bool = null |> unbox<bool>
    v89 
    #endif
#else
    let v90 : bool = v83.Exists
    v90 
    #endif
    |> fun x -> _v84 <- Some x
    let v91 : bool = match _v84 with Some x -> x | None -> failwith "base.run_target / _v84=None"
    let v92 : bool = v91 = false
    if v92 then
        let v93 : bool = true
        let mutable _v93 : System.DateTime option = None 
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v94 : System.DateTime = null |> unbox<System.DateTime>
        v94 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v95 : System.DateTime = null |> unbox<System.DateTime>
        v95 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v96 : System.DateTime = null |> unbox<System.DateTime>
        v96 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v97 : System.DateTime = null |> unbox<System.DateTime>
        v97 
        #endif
#if FABLE_COMPILER_PYTHON
        let v98 : System.DateTime = null |> unbox<System.DateTime>
        v98 
        #endif
#else
        let v99 : System.DateTime = v83.CreationTime
        v99 
        #endif
        |> fun x -> _v93 <- Some x
        let v100 : System.DateTime = match _v93 with Some x -> x | None -> failwith "base.run_target / _v93=None"
        let v101 : obj = {| Exists = v91; CreationTime = v100 |}
        let v102 : string = $"%A{v101}"
        let v103 : US0 = US0_1
        let v104 : (unit -> string) = closure68()
        let v105 : (unit -> string) = closure69(v0, v102)
        method5(v103, v104, v105)
    let v106 : bool = true
    let mutable _v106 : System.IDisposable option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v107 : (unit -> unit) = method88(v0)
    let v108 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v107 "$0()" )
    v108 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v109 : (unit -> unit) = method88(v0)
    let v110 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v109 "$0()" )
    v110 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v111 : (unit -> unit) = method88(v0)
    let v112 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v111 "$0()" )
    v112 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v113 : System.IDisposable = null |> unbox<System.IDisposable>
    v113 
    #endif
#if FABLE_COMPILER_PYTHON
    let v114 : System.IDisposable = null |> unbox<System.IDisposable>
    v114 
    #endif
#else
    let v115 : (unit -> unit) = method91(v0)
    let v116 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v115 () }
    v116 
    #endif
    |> fun x -> _v106 <- Some x
    let v117 : System.IDisposable = match _v106 with Some x -> x | None -> failwith "base.run_target / _v106=None"
    v117 
    #endif
#else
    let v118 : bool = true
    let mutable _v118 : System.IO.DirectoryInfo option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v119 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    v119 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v120 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    v120 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v121 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    v121 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v122 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    v122 
    #endif
#if FABLE_COMPILER_PYTHON
    let v123 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    v123 
    #endif
#else
    let v124 : (string -> System.IO.DirectoryInfo) = System.IO.Directory.CreateDirectory
    let v125 : System.IO.DirectoryInfo = v124 v0
    v125 
    #endif
    |> fun x -> _v118 <- Some x
    let v126 : System.IO.DirectoryInfo = match _v118 with Some x -> x | None -> failwith "base.run_target / _v118=None"
    let v127 : bool = true
    let mutable _v127 : bool option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v128 : bool = null |> unbox<bool>
    v128 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v129 : bool = null |> unbox<bool>
    v129 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v130 : bool = null |> unbox<bool>
    v130 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v131 : bool = null |> unbox<bool>
    v131 
    #endif
#if FABLE_COMPILER_PYTHON
    let v132 : bool = null |> unbox<bool>
    v132 
    #endif
#else
    let v133 : bool = v126.Exists
    v133 
    #endif
    |> fun x -> _v127 <- Some x
    let v134 : bool = match _v127 with Some x -> x | None -> failwith "base.run_target / _v127=None"
    let v135 : bool = v134 = false
    if v135 then
        let v136 : bool = true
        let mutable _v136 : System.DateTime option = None 
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v137 : System.DateTime = null |> unbox<System.DateTime>
        v137 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v138 : System.DateTime = null |> unbox<System.DateTime>
        v138 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v139 : System.DateTime = null |> unbox<System.DateTime>
        v139 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v140 : System.DateTime = null |> unbox<System.DateTime>
        v140 
        #endif
#if FABLE_COMPILER_PYTHON
        let v141 : System.DateTime = null |> unbox<System.DateTime>
        v141 
        #endif
#else
        let v142 : System.DateTime = v126.CreationTime
        v142 
        #endif
        |> fun x -> _v136 <- Some x
        let v143 : System.DateTime = match _v136 with Some x -> x | None -> failwith "base.run_target / _v136=None"
        let v144 : obj = {| Exists = v134; CreationTime = v143 |}
        let v145 : string = $"%A{v144}"
        let v146 : US0 = US0_1
        let v147 : (unit -> string) = closure68()
        let v148 : (unit -> string) = closure69(v0, v145)
        method5(v146, v147, v148)
    let v149 : bool = true
    let mutable _v149 : System.IDisposable option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v150 : (unit -> unit) = method88(v0)
    let v151 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v150 "$0()" )
    v151 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v152 : (unit -> unit) = method88(v0)
    let v153 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v152 "$0()" )
    v153 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v154 : (unit -> unit) = method88(v0)
    let v155 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v154 "$0()" )
    v155 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v156 : System.IDisposable = null |> unbox<System.IDisposable>
    v156 
    #endif
#if FABLE_COMPILER_PYTHON
    let v157 : System.IDisposable = null |> unbox<System.IDisposable>
    v157 
    #endif
#else
    let v158 : (unit -> unit) = method91(v0)
    let v159 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v158 () }
    v159 
    #endif
    |> fun x -> _v149 <- Some x
    let v160 : System.IDisposable = match _v149 with Some x -> x | None -> failwith "base.run_target / _v149=None"
    v160 
    #endif
    |> fun x -> _v1 <- Some x
    let v161 : System.IDisposable = match _v1 with Some x -> x | None -> failwith "base.run_target / _v1=None"
    v161
and method93 (v0 : chrono_DateTime<chrono_Utc>) : chrono_DateTime<chrono_Utc> =
    v0
and method94 (v0 : chrono_DateTime<chrono_Local>) : chrono_DateTime<chrono_Local> =
    v0
and method95 () : string =
    let v0 : string = "hh:mm"
    v0
and method96 () : string =
    let v0 : string = "yyyyMMdd-HHmm-ssff-ffff-f"
    v0
and method97 () : string =
    let v0 : string = "hhmm"
    v0
and method92 (v0 : System.Guid, v1 : System.DateTime) : System.Guid =
    let v2 : bool = true
    let mutable _v2 : System.Guid option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : System.DateTime = System.DateTime (1970, 1, 1, 0, 0, 0, System.DateTimeKind.Utc)
    let v4 : (System.DateTime -> System.DateTime) = _.ToUniversalTime()
    let v5 : System.DateTime = v4 v3
    let v6 : System.DateTimeKind = System.DateTimeKind.Local
    let v7 : System.DateTime = System.DateTime.SpecifyKind (v1, v6)
    let v8 : (System.DateTime -> System.DateTime) = _.ToUniversalTime()
    let v9 : System.DateTime = v8 v7
    let v10 : (System.DateTime -> int64) = _.Ticks
    let v11 : int64 = v10 v9
    let v12 : (System.DateTime -> int64) = _.Ticks
    let v13 : int64 = v12 v5
    let v14 : int64 = v11 - v13
    let v15 : int64 = v14 / 10L
    let v16 : string = "chrono::DateTime::from_timestamp_micros($0)"
    let v17 : chrono_DateTime<chrono_Utc> option = Fable.Core.RustInterop.emitRustExpr v15 v16 
    let v18 : US32 option = None
    let _v18 = ref v18 
    match v17 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v19 : chrono_DateTime<chrono_Utc> = x
    let v20 : US32 = US32_0(v19)
    v20 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v18.Value <- x
    let v21 : US32 option = _v18.Value 
    let v22 : US32 = US32_1
    let v23 : US32 = v21 |> Option.defaultValue v22 
    let v42 : US3 =
        match v23 with
        | US32_1 -> (* None *)
            US3_1
        | US32_0(v24) -> (* Some *)
            let v25 : chrono_DateTime<chrono_Utc> = method93(v24)
            let v26 : string = "v25.naive_utc()"
            let v27 : chrono_NaiveDateTime = Fable.Core.RustInterop.emitRustExpr () v26 
            let v28 : string = "chrono::offset::TimeZone::from_utc_datetime(&chrono::Local, &v27)"
            let v29 : chrono_DateTime<chrono_Local> = Fable.Core.RustInterop.emitRustExpr () v28 
            let v30 : string = "%Y%m%d-%H%M-%S%f"
            let v31 : string = "r#\"" + v30 + "\"#"
            let v32 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v31 
            let v33 : chrono_DateTime<chrono_Local> = method94(v29)
            let v34 : string = "v33.format(v32).to_string()"
            let v35 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v34 
            let v36 : string = "fable_library_rust::String_::fromString($0)"
            let v37 : string = Fable.Core.RustInterop.emitRustExpr v35 v36 
            let v38 : string = $"{v37.[0..17]}-{v37.[18..21]}-{v37.[22]}"
            US3_0(v38)
    let v46 : string =
        match v42 with
        | US3_1 -> (* None *)
            let v44 : string = ""
            v44
        | US3_0(v43) -> (* Some *)
            v43
    let v47 : bool = true
    let mutable _v47 : System.TimeZoneInfo option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v48 : string = "0i64.into()"
    let v49 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v48 
    v49 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v50 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v50 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v51 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v51 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v52 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v52 
    #endif
#if FABLE_COMPILER_PYTHON
    let v53 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v53 
    #endif
#else
    let v54 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    v54 
    #endif
    |> fun x -> _v47 <- Some x
    let v55 : System.TimeZoneInfo = match _v47 with Some x -> x | None -> failwith "base.run_target / _v47=None"
    let v56 : bool = true
    let mutable _v56 : System.TimeSpan option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v57 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v58 : System.TimeSpan = v57 ()
    v58 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v59 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v60 : System.TimeSpan = v59 ()
    v60 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v61 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v62 : System.TimeSpan = v61 ()
    v62 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v63 : US10 = US10_0
    let v64 : US11 = US11_3(v63)
    let v65 : string = $"date_time.get_utc_offset / target: {v64}"
    let v66 : System.TimeSpan = failwith<System.TimeSpan> v65
    v66 
    #endif
#if FABLE_COMPILER_PYTHON
    let v67 : US10 = US10_0
    let v68 : US11 = US11_4(v67)
    let v69 : string = $"date_time.get_utc_offset / target: {v68}"
    let v70 : System.TimeSpan = failwith<System.TimeSpan> v69
    v70 
    #endif
#else
    let v71 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v72 : bool = true
    let mutable _v72 : System.TimeZoneInfo option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v73 : string = "0i64.into()"
    let v74 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v73 
    v74 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v75 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v75 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v76 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v76 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v77 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v77 
    #endif
#if FABLE_COMPILER_PYTHON
    let v78 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v78 
    #endif
#else
    let v79 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    v79 
    #endif
    |> fun x -> _v72 <- Some x
    let v80 : System.TimeZoneInfo = match _v72 with Some x -> x | None -> failwith "base.run_target / _v72=None"
    let v81 : (System.DateTime -> System.TimeSpan) = v71 v80
    let v82 : System.TimeSpan = v81 v9
    v82 
    #endif
    |> fun x -> _v56 <- Some x
    let v83 : System.TimeSpan = match _v56 with Some x -> x | None -> failwith "base.run_target / _v56=None"
    let v84 : (System.TimeSpan -> int32) = _.Hours
    let v85 : int32 = v84 v83
    let v86 : bool = v85 > 0
    let v87 : uint8 =
        if v86 then
            1uy
        else
            0uy
    let v88 : string = method95()
    let v89 : bool = true
    let mutable _v89 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v90 : string = v83.ToString v88 
    v90 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v91 : string = v83.ToString v88 
    v91 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v92 : string = v83.ToString v88 
    v92 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v93 : string = v83.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    v93 
    #endif
#if FABLE_COMPILER_PYTHON
    let v94 : string = v83.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    v94 
    #endif
#else
    let v95 : string = v83.ToString v88 
    v95 
    #endif
    |> fun x -> _v89 <- Some x
    let v96 : string = match _v89 with Some x -> x | None -> failwith "base.run_target / _v89=None"
    let v97 : string = $"{v87}{v96.[0..1]}{v96.[3..4]}"
    let v98 : (System.Guid -> string) = _.ToString()
    let v99 : string = v98 v0
    let v100 : System.Guid = System.Guid $"{v46}{v97}{v99.[v46.Length + v97.Length..]}"
    v100 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v101 : System.DateTime = System.DateTime (1970, 1, 1, 0, 0, 0, System.DateTimeKind.Utc)
    let v102 : (System.DateTime -> System.DateTime) = _.ToUniversalTime()
    let v103 : System.DateTime = v102 v101
    let v104 : System.DateTimeKind = System.DateTimeKind.Local
    let v105 : System.DateTime = System.DateTime.SpecifyKind (v1, v104)
    let v106 : (System.DateTime -> System.DateTime) = _.ToUniversalTime()
    let v107 : System.DateTime = v106 v105
    let v108 : (System.DateTime -> int64) = _.Ticks
    let v109 : int64 = v108 v107
    let v110 : (System.DateTime -> int64) = _.Ticks
    let v111 : int64 = v110 v103
    let v112 : int64 = v109 - v111
    let v113 : int64 = v112 / 10L
    let v114 : string = "chrono::DateTime::from_timestamp_micros($0)"
    let v115 : chrono_DateTime<chrono_Utc> option = Fable.Core.RustInterop.emitRustExpr v113 v114 
    let v116 : US32 option = None
    let _v116 = ref v116 
    match v115 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v117 : chrono_DateTime<chrono_Utc> = x
    let v118 : US32 = US32_0(v117)
    v118 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v116.Value <- x
    let v119 : US32 option = _v116.Value 
    let v120 : US32 = US32_1
    let v121 : US32 = v119 |> Option.defaultValue v120 
    let v140 : US3 =
        match v121 with
        | US32_1 -> (* None *)
            US3_1
        | US32_0(v122) -> (* Some *)
            let v123 : chrono_DateTime<chrono_Utc> = method93(v122)
            let v124 : string = "v123.naive_utc()"
            let v125 : chrono_NaiveDateTime = Fable.Core.RustInterop.emitRustExpr () v124 
            let v126 : string = "chrono::offset::TimeZone::from_utc_datetime(&chrono::Local, &v125)"
            let v127 : chrono_DateTime<chrono_Local> = Fable.Core.RustInterop.emitRustExpr () v126 
            let v128 : string = "%Y%m%d-%H%M-%S%f"
            let v129 : string = "r#\"" + v128 + "\"#"
            let v130 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v129 
            let v131 : chrono_DateTime<chrono_Local> = method94(v127)
            let v132 : string = "v131.format(v130).to_string()"
            let v133 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v132 
            let v134 : string = "fable_library_rust::String_::fromString($0)"
            let v135 : string = Fable.Core.RustInterop.emitRustExpr v133 v134 
            let v136 : string = $"{v135.[0..17]}-{v135.[18..21]}-{v135.[22]}"
            US3_0(v136)
    let v144 : string =
        match v140 with
        | US3_1 -> (* None *)
            let v142 : string = ""
            v142
        | US3_0(v141) -> (* Some *)
            v141
    let v145 : bool = true
    let mutable _v145 : System.TimeZoneInfo option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v146 : string = "0i64.into()"
    let v147 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v146 
    v147 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v148 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v148 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v149 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v149 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v150 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v150 
    #endif
#if FABLE_COMPILER_PYTHON
    let v151 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v151 
    #endif
#else
    let v152 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    v152 
    #endif
    |> fun x -> _v145 <- Some x
    let v153 : System.TimeZoneInfo = match _v145 with Some x -> x | None -> failwith "base.run_target / _v145=None"
    let v154 : bool = true
    let mutable _v154 : System.TimeSpan option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v155 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v156 : System.TimeSpan = v155 ()
    v156 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v157 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v158 : System.TimeSpan = v157 ()
    v158 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v159 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v160 : System.TimeSpan = v159 ()
    v160 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v161 : US10 = US10_0
    let v162 : US11 = US11_3(v161)
    let v163 : string = $"date_time.get_utc_offset / target: {v162}"
    let v164 : System.TimeSpan = failwith<System.TimeSpan> v163
    v164 
    #endif
#if FABLE_COMPILER_PYTHON
    let v165 : US10 = US10_0
    let v166 : US11 = US11_4(v165)
    let v167 : string = $"date_time.get_utc_offset / target: {v166}"
    let v168 : System.TimeSpan = failwith<System.TimeSpan> v167
    v168 
    #endif
#else
    let v169 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v170 : bool = true
    let mutable _v170 : System.TimeZoneInfo option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v171 : string = "0i64.into()"
    let v172 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v171 
    v172 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v173 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v173 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v174 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v174 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v175 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v175 
    #endif
#if FABLE_COMPILER_PYTHON
    let v176 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v176 
    #endif
#else
    let v177 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    v177 
    #endif
    |> fun x -> _v170 <- Some x
    let v178 : System.TimeZoneInfo = match _v170 with Some x -> x | None -> failwith "base.run_target / _v170=None"
    let v179 : (System.DateTime -> System.TimeSpan) = v169 v178
    let v180 : System.TimeSpan = v179 v107
    v180 
    #endif
    |> fun x -> _v154 <- Some x
    let v181 : System.TimeSpan = match _v154 with Some x -> x | None -> failwith "base.run_target / _v154=None"
    let v182 : (System.TimeSpan -> int32) = _.Hours
    let v183 : int32 = v182 v181
    let v184 : bool = v183 > 0
    let v185 : uint8 =
        if v184 then
            1uy
        else
            0uy
    let v186 : string = method95()
    let v187 : bool = true
    let mutable _v187 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v188 : string = v181.ToString v186 
    v188 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v189 : string = v181.ToString v186 
    v189 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v190 : string = v181.ToString v186 
    v190 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v191 : string = v181.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    v191 
    #endif
#if FABLE_COMPILER_PYTHON
    let v192 : string = v181.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    v192 
    #endif
#else
    let v193 : string = v181.ToString v186 
    v193 
    #endif
    |> fun x -> _v187 <- Some x
    let v194 : string = match _v187 with Some x -> x | None -> failwith "base.run_target / _v187=None"
    let v195 : string = $"{v185}{v194.[0..1]}{v194.[3..4]}"
    let v196 : (System.Guid -> string) = _.ToString()
    let v197 : string = v196 v0
    let v198 : System.Guid = System.Guid $"{v144}{v195}{v197.[v144.Length + v195.Length..]}"
    v198 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v199 : System.Guid = null |> unbox<System.Guid>
    v199 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v200 : string = method96()
    let v201 : (string -> string) = v1.ToString
    let v202 : string = v201 v200
    let v203 : bool = true
    let mutable _v203 : System.TimeZoneInfo option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v204 : string = "0i64.into()"
    let v205 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v204 
    v205 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v206 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v206 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v207 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v207 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v208 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v208 
    #endif
#if FABLE_COMPILER_PYTHON
    let v209 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v209 
    #endif
#else
    let v210 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    v210 
    #endif
    |> fun x -> _v203 <- Some x
    let v211 : System.TimeZoneInfo = match _v203 with Some x -> x | None -> failwith "base.run_target / _v203=None"
    let v212 : bool = true
    let mutable _v212 : System.TimeSpan option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v213 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v214 : System.TimeSpan = v213 ()
    v214 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v215 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v216 : System.TimeSpan = v215 ()
    v216 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v217 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v218 : System.TimeSpan = v217 ()
    v218 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v219 : US10 = US10_0
    let v220 : US11 = US11_3(v219)
    let v221 : string = $"date_time.get_utc_offset / target: {v220}"
    let v222 : System.TimeSpan = failwith<System.TimeSpan> v221
    v222 
    #endif
#if FABLE_COMPILER_PYTHON
    let v223 : US10 = US10_0
    let v224 : US11 = US11_4(v223)
    let v225 : string = $"date_time.get_utc_offset / target: {v224}"
    let v226 : System.TimeSpan = failwith<System.TimeSpan> v225
    v226 
    #endif
#else
    let v227 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v228 : bool = true
    let mutable _v228 : System.TimeZoneInfo option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v229 : string = "0i64.into()"
    let v230 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v229 
    v230 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v231 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v231 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v232 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v232 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v233 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v233 
    #endif
#if FABLE_COMPILER_PYTHON
    let v234 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v234 
    #endif
#else
    let v235 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    v235 
    #endif
    |> fun x -> _v228 <- Some x
    let v236 : System.TimeZoneInfo = match _v228 with Some x -> x | None -> failwith "base.run_target / _v228=None"
    let v237 : (System.DateTime -> System.TimeSpan) = v227 v236
    let v238 : System.TimeSpan = v237 v1
    v238 
    #endif
    |> fun x -> _v212 <- Some x
    let v239 : System.TimeSpan = match _v212 with Some x -> x | None -> failwith "base.run_target / _v212=None"
    let v240 : (System.TimeSpan -> int32) = _.Hours
    let v241 : int32 = v240 v239
    let v242 : bool = v241 > 0
    let v243 : uint8 =
        if v242 then
            1uy
        else
            0uy
    let v244 : string = method97()
    let v245 : bool = true
    let mutable _v245 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v246 : string = v239.ToString v244 
    v246 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v247 : string = v239.ToString v244 
    v247 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v248 : string = v239.ToString v244 
    v248 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v249 : string = v239.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    v249 
    #endif
#if FABLE_COMPILER_PYTHON
    let v250 : string = v239.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    v250 
    #endif
#else
    let v251 : string = v239.ToString v244 
    v251 
    #endif
    |> fun x -> _v245 <- Some x
    let v252 : string = match _v245 with Some x -> x | None -> failwith "base.run_target / _v245=None"
    let v253 : string = $"{v243}{v252}"
    let v254 : (System.Guid -> string) = _.ToString()
    let v255 : string = v254 v0
    let v256 : System.Guid = System.Guid $"{v202}{v253}{v255.[v202.Length + v253.Length..]}"
    v256 
    #endif
#if FABLE_COMPILER_PYTHON
    let v257 : string = method96()
    let v258 : (string -> string) = v1.ToString
    let v259 : string = v258 v257
    let v260 : bool = true
    let mutable _v260 : System.TimeZoneInfo option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v261 : string = "0i64.into()"
    let v262 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v261 
    v262 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v263 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v263 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v264 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v264 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v265 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v265 
    #endif
#if FABLE_COMPILER_PYTHON
    let v266 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v266 
    #endif
#else
    let v267 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    v267 
    #endif
    |> fun x -> _v260 <- Some x
    let v268 : System.TimeZoneInfo = match _v260 with Some x -> x | None -> failwith "base.run_target / _v260=None"
    let v269 : bool = true
    let mutable _v269 : System.TimeSpan option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v270 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v271 : System.TimeSpan = v270 ()
    v271 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v272 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v273 : System.TimeSpan = v272 ()
    v273 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v274 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v275 : System.TimeSpan = v274 ()
    v275 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v276 : US10 = US10_0
    let v277 : US11 = US11_3(v276)
    let v278 : string = $"date_time.get_utc_offset / target: {v277}"
    let v279 : System.TimeSpan = failwith<System.TimeSpan> v278
    v279 
    #endif
#if FABLE_COMPILER_PYTHON
    let v280 : US10 = US10_0
    let v281 : US11 = US11_4(v280)
    let v282 : string = $"date_time.get_utc_offset / target: {v281}"
    let v283 : System.TimeSpan = failwith<System.TimeSpan> v282
    v283 
    #endif
#else
    let v284 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v285 : bool = true
    let mutable _v285 : System.TimeZoneInfo option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v286 : string = "0i64.into()"
    let v287 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v286 
    v287 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v288 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v288 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v289 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v289 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v290 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v290 
    #endif
#if FABLE_COMPILER_PYTHON
    let v291 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v291 
    #endif
#else
    let v292 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    v292 
    #endif
    |> fun x -> _v285 <- Some x
    let v293 : System.TimeZoneInfo = match _v285 with Some x -> x | None -> failwith "base.run_target / _v285=None"
    let v294 : (System.DateTime -> System.TimeSpan) = v284 v293
    let v295 : System.TimeSpan = v294 v1
    v295 
    #endif
    |> fun x -> _v269 <- Some x
    let v296 : System.TimeSpan = match _v269 with Some x -> x | None -> failwith "base.run_target / _v269=None"
    let v297 : (System.TimeSpan -> int32) = _.Hours
    let v298 : int32 = v297 v296
    let v299 : bool = v298 > 0
    let v300 : uint8 =
        if v299 then
            1uy
        else
            0uy
    let v301 : string = method97()
    let v302 : bool = true
    let mutable _v302 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v303 : string = v296.ToString v301 
    v303 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v304 : string = v296.ToString v301 
    v304 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v305 : string = v296.ToString v301 
    v305 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v306 : string = v296.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    v306 
    #endif
#if FABLE_COMPILER_PYTHON
    let v307 : string = v296.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    v307 
    #endif
#else
    let v308 : string = v296.ToString v301 
    v308 
    #endif
    |> fun x -> _v302 <- Some x
    let v309 : string = match _v302 with Some x -> x | None -> failwith "base.run_target / _v302=None"
    let v310 : string = $"{v300}{v309}"
    let v311 : (System.Guid -> string) = _.ToString()
    let v312 : string = v311 v0
    let v313 : System.Guid = System.Guid $"{v259}{v310}{v312.[v259.Length + v310.Length..]}"
    v313 
    #endif
#else
    let v314 : string = method96()
    let v315 : (string -> string) = v1.ToString
    let v316 : string = v315 v314
    let v317 : bool = true
    let mutable _v317 : System.TimeZoneInfo option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v318 : string = "0i64.into()"
    let v319 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v318 
    v319 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v320 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v320 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v321 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v321 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v322 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v322 
    #endif
#if FABLE_COMPILER_PYTHON
    let v323 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v323 
    #endif
#else
    let v324 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    v324 
    #endif
    |> fun x -> _v317 <- Some x
    let v325 : System.TimeZoneInfo = match _v317 with Some x -> x | None -> failwith "base.run_target / _v317=None"
    let v326 : bool = true
    let mutable _v326 : System.TimeSpan option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v327 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v328 : System.TimeSpan = v327 ()
    v328 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v329 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v330 : System.TimeSpan = v329 ()
    v330 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v331 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v332 : System.TimeSpan = v331 ()
    v332 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v333 : US10 = US10_0
    let v334 : US11 = US11_3(v333)
    let v335 : string = $"date_time.get_utc_offset / target: {v334}"
    let v336 : System.TimeSpan = failwith<System.TimeSpan> v335
    v336 
    #endif
#if FABLE_COMPILER_PYTHON
    let v337 : US10 = US10_0
    let v338 : US11 = US11_4(v337)
    let v339 : string = $"date_time.get_utc_offset / target: {v338}"
    let v340 : System.TimeSpan = failwith<System.TimeSpan> v339
    v340 
    #endif
#else
    let v341 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v342 : bool = true
    let mutable _v342 : System.TimeZoneInfo option = None 
    
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
    |> fun x -> _v342 <- Some x
    let v350 : System.TimeZoneInfo = match _v342 with Some x -> x | None -> failwith "base.run_target / _v342=None"
    let v351 : (System.DateTime -> System.TimeSpan) = v341 v350
    let v352 : System.TimeSpan = v351 v1
    v352 
    #endif
    |> fun x -> _v326 <- Some x
    let v353 : System.TimeSpan = match _v326 with Some x -> x | None -> failwith "base.run_target / _v326=None"
    let v354 : (System.TimeSpan -> int32) = _.Hours
    let v355 : int32 = v354 v353
    let v356 : bool = v355 > 0
    let v357 : uint8 =
        if v356 then
            1uy
        else
            0uy
    let v358 : string = method97()
    let v359 : bool = true
    let mutable _v359 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v360 : string = v353.ToString v358 
    v360 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v361 : string = v353.ToString v358 
    v361 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v362 : string = v353.ToString v358 
    v362 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v363 : string = v353.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    v363 
    #endif
#if FABLE_COMPILER_PYTHON
    let v364 : string = v353.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    v364 
    #endif
#else
    let v365 : string = v353.ToString v358 
    v365 
    #endif
    |> fun x -> _v359 <- Some x
    let v366 : string = match _v359 with Some x -> x | None -> failwith "base.run_target / _v359=None"
    let v367 : string = $"{v357}{v366}"
    let v368 : (System.Guid -> string) = _.ToString()
    let v369 : string = v368 v0
    let v370 : System.Guid = System.Guid $"{v316}{v367}{v369.[v316.Length + v367.Length..]}"
    v370 
    #endif
    |> fun x -> _v2 <- Some x
    let v371 : System.Guid = match _v2 with Some x -> x | None -> failwith "base.run_target / _v2=None"
    v371
and method98 (v0 : string, v1 : string) : unit =
    let v2 : bool = method19(v0)
    let v3 : bool = v2 = false
    if v3 then
        let v4 : System.IDisposable = method82(v0)
        ()
    let v5 : string = method23(v1)
    let v6 : bool = method19(v5)
    let v7 : bool = v6 = false
    if v7 then
        let v8 : System.IDisposable = method82(v5)
        ()
    let v9 : bool = method19(v1)
    let v14 : bool =
        if v9 then
            let v10 : string = "std::fs::read_link(&*$0)"
            let v11 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v1 v10 
            let v12 : string = "v11.is_err()"
            let v13 : bool = Fable.Core.RustInterop.emitRustExpr () v12 
            v13
        else
            false
    if v14 then
        let v15 : bool = true
        method85(v15, v1)
    let v16 : bool = method19(v1)
    let v17 : bool = v16 = false
    if v17 then
        let v18 : bool = true
        let mutable _v18 : unit option = None 
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v19 : bool = true
        let mutable _v19 : unit option = None 
        
#if _FREEBSD
        let v20 : string = "std::os::unix::fs::symlink(&*$0, &*$1).unwrap()"
        Fable.Core.RustInterop.emitRustExpr struct (v0, v1) v20 
        () 
        #endif
#if _LINUX
        let v21 : string = "std::os::unix::fs::symlink(&*$0, &*$1).unwrap()"
        Fable.Core.RustInterop.emitRustExpr struct (v0, v1) v21 
        () 
        #endif
#if _OSX
        let v22 : string = "std::os::unix::fs::symlink(&*$0, &*$1).unwrap()"
        Fable.Core.RustInterop.emitRustExpr struct (v0, v1) v22 
        () 
        #endif
#if _WINDOWS
        let v23 : string = "std::os::windows::fs::symlink_dir(&*$0, &*$1).unwrap()"
        Fable.Core.RustInterop.emitRustExpr struct (v0, v1) v23 
        () 
        #endif
        |> fun x -> _v19 <- Some x
        match _v19 with Some x -> x | None -> failwith "runtime.run_platform / _v19=None"
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
        let v24 : System.IO.FileSystemInfo = System.IO.Directory.CreateSymbolicLink (v1, v0)
        () 
        #endif
        |> fun x -> _v18 <- Some x
        match _v18 with Some x -> x | None -> failwith "base.run_target / _v18=None"
        ()
and closure74 () () : string =
    let v0 : string = "common.retry_fn' / loop"
    v0
and closure75 (v0 : uint8, v1 : int32, v2 : string, v3 : bool) () : string =
    let v4 : (unit -> string) = closure6()
    let v5 : string = $"is_error: {v3} / retry: {v0}/{3uy} / result: %A{struct (v1, v2)} / {v4 ()}"
    v5
and method100 (v0 : string, v1 : string, v2 : string, v3 : US12, v4 : uint8) : struct (int32 * string) =
    let v5 : bool = true
    let mutable _v5 : bool option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v6 : string = "cfg!(windows)"
    let v7 : bool = Fable.Core.RustInterop.emitRustExpr () v6 
    v7 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v8 : string = "cfg!(windows)"
    let v9 : bool = Fable.Core.RustInterop.emitRustExpr () v8 
    v9 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v10 : string = "cfg!(windows)"
    let v11 : bool = Fable.Core.RustInterop.emitRustExpr () v10 
    v11 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v12 : US10 = US10_0
    let v13 : US11 = US11_3(v12)
    let v14 : string = $"platform.is_windows / target: {v13}"
    let v15 : bool = failwith<bool> v14
    v15 
    #endif
#if FABLE_COMPILER_PYTHON
    let v16 : US10 = US10_0
    let v17 : US11 = US11_4(v16)
    let v18 : string = $"platform.is_windows / target: {v17}"
    let v19 : bool = failwith<bool> v18
    v19 
    #endif
#else
    let v20 : System.Runtime.InteropServices.OSPlatform = System.Runtime.InteropServices.OSPlatform.Windows
    let v21 : (System.Runtime.InteropServices.OSPlatform -> bool) = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform
    let v22 : bool = v21 v20
    v22 
    #endif
    |> fun x -> _v5 <- Some x
    let v23 : bool = match _v5 with Some x -> x | None -> failwith "base.run_target / _v5=None"
    let v26 : string =
        if v23 then
            let v24 : string = "_WINDOWS"
            v24
        else
            let v25 : string = "_LINUX"
            v25
    let v27 : System.Threading.CancellationToken option = None
    let v28 : (struct (string * string) []) = [||]
    let v29 : (struct (bool * string * int32) -> Async<unit>) option = None
    let v30 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = None
    let v31 : string option = None
    let v32 : string = $"dotnet fable \"{v2}\" --optimize --lang {v1} --extension .{v1} --outDir \"{v0}\" --define {v26}"
    let v38 : Result<string, string> =
        match v3 with
        | US12_1(v35) -> (* Error *)
            let v36 : Result<string, string> = Error v35 
            v36
        | US12_0(v33) -> (* Ok *)
            let v34 : Result<string, string> = Ok v33 
            v34
    let v39 : string = "v38.ok()"
    let v40 : string option = Fable.Core.RustInterop.emitRustExpr () v39 
    let v41 : bool = true
    let struct (v42 : int32, v43 : string) = method28(v27, v32, v28, v29, v30, v41, v40)
    let v44 : bool = v42 = 0
    let v47 : US33 =
        if v44 then
            US33_0(v42, v43)
        else
            US33_1(v42, v43)
    let struct (v55 : bool, v56 : int32, v57 : string) =
        match v47 with
        | US33_1(v50, v51) -> (* Error *)
            struct (true, v50, v51)
        | US33_0(v48, v49) -> (* Ok *)
            struct (false, v48, v49)
    let v58 : bool = v55 = false
    let v60 : bool =
        if v58 then
            true
        else
            let v59 : bool = v4 >= 3uy
            v59
    if v60 then
        struct (v56, v57)
    else
        let v61 : US0 = US0_1
        let v62 : (unit -> string) = closure74()
        let v63 : (unit -> string) = closure75(v4, v56, v57, v55)
        method5(v61, v62, v63)
        let v64 : uint8 = v4 + 1uy
        method100(v0, v1, v2, v3, v64)
and method99 (v0 : string, v1 : string, v2 : string, v3 : US12) : struct (int32 * string) =
    let v4 : uint8 = 1uy
    method100(v0, v1, v2, v3, v4)
and closure76 () () : string =
    let v0 : string = "spiral_builder.process_rust / dotnet fable error"
    v0
and closure77 (v0 : string, v1 : int32) () : string =
    let v2 : (unit -> string) = closure6()
    let v3 : string = $"exit_code: {v1} / dotnet_fable_result: {v0} / {v2 ()}"
    v3
and method102 () : string =
    let v0 : string = "a"
    v0
and method101 (v0 : string, v1 : US12, v2 : uint8) : struct (int32 * string) =
    let v3 : System.Threading.CancellationToken option = None
    let v4 : (struct (string * string) []) = [||]
    let v5 : (struct (bool * string * int32) -> Async<unit>) option = None
    let v6 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = None
    let v7 : string option = None
    let v8 : string = $"cargo fmt --manifest-path \"{v0}\" --"
    let v14 : Result<string, string> =
        match v1 with
        | US12_1(v11) -> (* Error *)
            let v12 : Result<string, string> = Error v11 
            v12
        | US12_0(v9) -> (* Ok *)
            let v10 : Result<string, string> = Ok v9 
            v10
    let v15 : string = "v14.ok()"
    let v16 : string option = Fable.Core.RustInterop.emitRustExpr () v15 
    let v17 : bool = true
    let struct (v18 : int32, v19 : string) = method28(v3, v8, v4, v5, v6, v17, v16)
    let v20 : string = "failed to load manifest for workspace member"
    let v21 : bool = v19.Contains v20 
    let v22 : bool = v21 = false
    let v152 : US33 =
        if v22 then
            let v23 : bool = v18 = 0
            if v23 then
                US33_0(v18, v19)
            else
                US33_1(v18, v19)
        else
            let v27 : string = $"regex::Regex::new(&$0)"
            let v28 : string = "failed to read `(?<a>.*?Cargo.toml)`"
            let v29 : Result<regex_Regex, regex_Error> = Fable.Core.RustInterop.emitRustExpr v28 v27 
            let v30 : string = "$0.unwrap()"
            let v31 : regex_Regex = Fable.Core.RustInterop.emitRustExpr v29 v30 
            let v32 : string = "&*$0"
            let v33 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v19 v32 
            let v34 : string = "String::from($0)"
            let v35 : std_string_String = Fable.Core.RustInterop.emitRustExpr v33 v34 
            let v36 : string = "true; let _result = (move || { //"
            let v37 : bool = Fable.Core.RustInterop.emitRustExpr () v36 
            let v38 : string = "Box::new($0)"
            let v39 : Box<std_string_String> = Fable.Core.RustInterop.emitRustExpr v35 v38 
            let v40 : string = "Box::leak($0)"
            let v41 : Ref<Lifetime<StaticLifetime, Mut<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr v39 v40 
            let v42 : string = $"v31.captures_iter(v41)"
            let v43 : regex_CaptureMatches = Fable.Core.RustInterop.emitRustExpr () v42 
            let v44 : string = "true; let _result : Vec<_> = v43.map(|x| { //"
            let v45 : bool = Fable.Core.RustInterop.emitRustExpr () v44 
            let v46 : string = $"x"
            let v47 : regex_Captures<StaticLifetime> = Fable.Core.RustInterop.emitRustExpr () v46 
            let v48 : string = "Box::new($0)"
            let v49 : Box<regex_Captures<StaticLifetime>> = Fable.Core.RustInterop.emitRustExpr v47 v48 
            let v50 : string = "Box::leak($0)"
            let v51 : Ref<Lifetime<StaticLifetime, Mut<regex_Captures<StaticLifetime>>>> = Fable.Core.RustInterop.emitRustExpr v49 v50 
            let v52 : string = $"$0.capture_names()"
            let v53 : regex_CaptureNames = Fable.Core.RustInterop.emitRustExpr v31 v52 
            let v54 : string = "true; let _result : std::collections::HashMap<_, _> = v53.map(|x| { //"
            let v55 : bool = Fable.Core.RustInterop.emitRustExpr () v54 
            let v56 : string = "x.unwrap_or(\"\").to_string().into()"
            let v57 : string = Fable.Core.RustInterop.emitRustExpr () v56 
            let v58 : string = "$0.clone()"
            let v59 : string = Fable.Core.RustInterop.emitRustExpr v57 v58 
            let v60 : string = $"v51.name(&$0).map(|x| x.as_str()).unwrap_or(\"\").to_string().into()"
            let v61 : string = Fable.Core.RustInterop.emitRustExpr v57 v60 
            let v62 : (string * string) = v59, v61 
            let v63 : string = "true; $0 }).map(|x| std::sync::Arc::try_unwrap(x).unwrap_or_else(|x| (*x).clone())).collect()"
            let v64 : bool = Fable.Core.RustInterop.emitRustExpr v62 v63 
            let v65 : string = "_result"
            let v66 : std_collections_HashMap<string, string> = Fable.Core.RustInterop.emitRustExpr () v65 
            let v67 : string = "true; $0 }).collect::<Vec<_>>()"
            let v68 : bool = Fable.Core.RustInterop.emitRustExpr v66 v67 
            let v69 : string = "_result"
            let v70 : Vec<std_collections_HashMap<string, string>> = Fable.Core.RustInterop.emitRustExpr () v69 
            let v71 : string = "true; $0 })()"
            let v72 : bool = Fable.Core.RustInterop.emitRustExpr v70 v71 
            let v73 : string = "_result"
            let v74 : Vec<std_collections_HashMap<string, string>> = Fable.Core.RustInterop.emitRustExpr () v73 
            let v75 : string = "fable_library_rust::NativeArray_::array_from($0)"
            let v76 : (std_collections_HashMap<string, string> []) = Fable.Core.RustInterop.emitRustExpr v74 v75 
            let v77 : (int32 -> ((std_collections_HashMap<string, string> []) -> std_collections_HashMap<string, string> option)) = Array.tryItem
            let v78 : ((std_collections_HashMap<string, string> []) -> std_collections_HashMap<string, string> option) = v77 0
            let v79 : std_collections_HashMap<string, string> option = v78 v76
            let v80 : US34 option = None
            let _v80 = ref v80 
            match v79 with
            | Some x -> (
            (fun () ->
            (fun () ->
            let v81 : std_collections_HashMap<string, string> = x
            let v82 : US34 = US34_0(v81)
            v82 
            )
            |> fun x -> x () |> Some
            ) () ) | None -> None
            |> fun x -> _v80.Value <- x
            let v83 : US34 option = _v80.Value 
            let v84 : US34 = US34_1
            let v85 : US34 = v83 |> Option.defaultValue v84 
            let v99 : US35 =
                match v85 with
                | US34_1 -> (* None *)
                    US35_1
                | US34_0(v86) -> (* Some *)
                    let v87 : string = method102()
                    let v88 : string = "std::collections::HashMap::get(&$0, &v87).map(|x| x).cloned()"
                    let v89 : string option = Fable.Core.RustInterop.emitRustExpr v86 v88 
                    let v90 : US3 option = None
                    let _v90 = ref v90 
                    match v89 with
                    | Some x -> (
                    (fun () ->
                    (fun () ->
                    let v91 : string = x
                    let v92 : US3 = US3_0(v91)
                    v92 
                    )
                    |> fun x -> x () |> Some
                    ) () ) | None -> None
                    |> fun x -> _v90.Value <- x
                    let v93 : US3 option = _v90.Value 
                    let v94 : US3 = US3_1
                    let v95 : US3 = v93 |> Option.defaultValue v94 
                    US35_0(v95)
            let v106 : US3 =
                match v99 with
                | US35_0(v100) -> (* Some *)
                    match v100 with
                    | US3_0(v101) -> (* Some *)
                        US3_0(v101)
                    | _ ->
                        US3_1
                | _ ->
                    US3_1
            match v106 with
            | US3_1 -> (* None *)
                US33_1(v18, v19)
            | US3_0(v108) -> (* Some *)
                let v109 : bool = method26(v108)
                let v110 : bool = v109 = false
                if v110 then
                    let v111 : string = method23(v108)
                    let v112 : System.IDisposable = method82(v111)
                    let v113 : System.DateTime = System.DateTime.Now
                    let v114 : (unit -> System.Guid) = System.Guid.NewGuid
                    let v115 : System.Guid = v114 ()
                    let v116 : System.Guid = method92(v115, v113)
                    let v117 : (System.Guid -> string) = _.ToString()
                    let v118 : string = v117 v116
                    let v119 : string = $"[package]"
                    let v120 : string = $"name = \"spiral_builder_{v118}\""
                    let v121 : string = "\n"
                    let v122 : string = v119 + v121 
                    let v123 : string = v122 + v120 
                    let v124 : string = $"version = \"0.0.1\""
                    let v125 : string = v123 + v121 
                    let v126 : string = v125 + v124 
                    let v127 : string = $"edition = \"2021\""
                    let v128 : string = v126 + v121 
                    let v129 : string = v128 + v127 
                    let v130 : string = $""
                    let v131 : string = v129 + v121 
                    let v132 : string = v131 + v130 
                    let v133 : string = $"[[bin]]"
                    let v134 : string = v132 + v121 
                    let v135 : string = v134 + v133 
                    let v136 : string = $"name = \"spiral_builder_{v118}\""
                    let v137 : string = v135 + v121 
                    let v138 : string = v137 + v136 
                    let v139 : string = "rs"
                    let v140 : string = $"path = \"spiral_builder.{v139}\""
                    let v141 : string = v138 + v121 
                    let v142 : string = v141 + v140 
                    let v143 : bool = true
                    let mutable _v143 : unit option = None 
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v144 : string = "std::fs::write(&*$0, &*$1).unwrap()"
                    Fable.Core.RustInterop.emitRustExpr struct (v108, v142) v144 
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
                    let v145 : string = method27(v142)
                    System.IO.File.WriteAllText (v108, v145)
                    () 
                    #endif
                    |> fun x -> _v143 <- Some x
                    match _v143 with Some x -> x | None -> failwith "base.run_target / _v143=None"
                    ()
                let v146 : bool = v18 = 0
                if v146 then
                    US33_0(v18, v19)
                else
                    US33_1(v18, v19)
    let struct (v160 : bool, v161 : int32, v162 : string) =
        match v152 with
        | US33_1(v155, v156) -> (* Error *)
            struct (true, v155, v156)
        | US33_0(v153, v154) -> (* Ok *)
            struct (false, v153, v154)
    let v163 : bool = v160 = false
    let v165 : bool =
        if v163 then
            true
        else
            let v164 : bool = v2 >= 3uy
            v164
    if v165 then
        struct (v161, v162)
    else
        let v166 : US0 = US0_1
        let v167 : (unit -> string) = closure74()
        let v168 : (unit -> string) = closure75(v2, v161, v162, v160)
        method5(v166, v167, v168)
        let v169 : uint8 = v2 + 1uy
        method101(v0, v1, v169)
and closure78 () () : string =
    let v0 : string = "spiral_builder.process_rust / cargo fmt error"
    v0
and closure79 (v0 : string, v1 : int32) () : string =
    let v2 : (unit -> string) = closure6()
    let v3 : string = $"exit_code: {v1} / cargo_fmt_result: {v0} / {v2 ()}"
    v3
and method103 () : string =
    let v0 : string = " defaultOf::<()>();"
    v0
and method104 () : string =
    let v0 : string = "\\s\\sdefaultOf\\(\\);"
    v0
and closure80 () () : string =
    let v0 : string = "spiral_builder.process_rust"
    v0
and closure81 (v0 : string, v1 : string, v2 : bool, v3 : string, v4 : bool, v5 : string, v6 : bool, v7 : string, v8 : bool) () : string =
    let v9 : UH3 = UH3_0
    let v10 : UH3 = UH3_1(v7, v8, v9)
    let v11 : UH3 = UH3_1(v5, v6, v10)
    let v12 : UH3 = UH3_1(v3, v4, v11)
    let v13 : UH3 = UH3_1(v1, v2, v12)
    let v14 : (unit -> string) = closure6()
    let v15 : string = $"new_code_path: {v0} / cleanup: %A{v13} / {v14 ()}"
    v15
and method105 (v0 : UH3) : unit =
    match v0 with
    | UH3_1(v1, v2, v3) -> (* Cons *)
        let v4 : bool = true
        let mutable _v4 : unit option = None 
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v5 : string = "std::fs::remove_file(&*$0).unwrap()"
        Fable.Core.RustInterop.emitRustExpr v1 v5 
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
        let v6 : (string -> unit) = System.IO.File.Delete
        v6 v1
        () 
        #endif
        |> fun x -> _v4 <- Some x
        match _v4 with Some x -> x | None -> failwith "base.run_target / _v4=None"
        method105(v3)
    | UH3_0 -> (* Nil *)
        ()
and closure83 () (v0 : string) : bool =
    let v1 : string = "profile [optimized] target"
    let v2 : bool = v0.Contains v1 
    let v3 : bool = v2 = false
    if v3 then
        let v4 : string = "profile [unoptimized] target"
        let v5 : bool = v0.Contains v4 
        let v6 : bool = v5 = false
        if v6 then
            let v7 : string = "profile [unoptimized + debuginfo] target"
            let v8 : bool = v0.Contains v7 
            let v9 : bool = v8 = false
            v9
        else
            false
    else
        false
and closure82 (v0 : string) () : string =
    let v1 : string = "\n"
    let v2 : (string []) = v0.Split v1 
    let v3 : ((string -> bool) -> ((string []) -> (string []))) = Array.skipWhile
    let v4 : (string -> bool) = closure83()
    let v5 : ((string []) -> (string [])) = v3 v4
    let v6 : (string []) = v5 v2
    let v7 : (int32 -> ((string []) -> (string []))) = Array.skip
    let v8 : ((string []) -> (string [])) = v7 2
    let v9 : (string []) = v8 v6
    let v10 : ((string []) -> string seq) = Seq.ofArray
    let v11 : string seq = v10 v9
    let v12 : (string -> (string seq -> string)) = String.concat
    let v13 : (string seq -> string) = v12 v1
    v13 v11
and closure85 () () : string =
    let v0 : string = "spiral_builder.process_rust / Exception"
    v0
and closure86 (v0 : string, v1 : string, v2 : string, v3 : exn) () : string =
    let v4 : (unit -> string) = closure6()
    let v5 : string = $"ex: {v3} / new_code_path: {v0} / external_command: {v2} / cargo_run_result: {v1} / {v4 ()}"
    v5
and closure84 (v0 : string, v1 : string, v2 : string) (v3 : exn) : US3 =
    let v4 : US0 = US0_4
    let v5 : (unit -> string) = closure85()
    let v6 : (unit -> string) = closure86(v0, v1, v2, v3)
    method5(v4, v5, v6)
    US3_1
and closure87 () () : string =
    let v0 : string = "spiral_builder.process_rust / error"
    v0
and closure88 (v0 : string, v1 : string, v2 : int32, v3 : string) () : string =
    let v4 : string = $"exit_code: {v2} / new_code_path: {v0} / external_command: {v3} / cargo_run_result: {v1}"
    v4
and method108 (v0 : async_walkdir_DirEntry) : async_walkdir_DirEntry =
    v0
and closure90 () (v0 : std_fs_FileType) : US37 =
    US37_0(v0)
and closure91 () (v0 : std_string_String) : US37 =
    US37_1(v0)
and method109 (v0 : std_fs_FileType) : std_fs_FileType =
    v0
and method110 (v0 : US36) : US36 =
    v0
and method107 (v0 : async_walkdir_DirEntry) : std_pin_Pin<Box<LifetimeJoin<Dyn<std_future_Future<US36>>, Send<Dyn<std_future_Future<US36>>>>>> =
    let v1 : string = "let __result = Box::pin(async move { //"
    Fable.Core.RustInterop.emitRustExpr () v1 
    let v2 : async_walkdir_DirEntry = method108(v0)
    let v3 : string = "Box::pin(async_walkdir::DirEntry::file_type(&v2))"
    let v4 : std_pin_Pin<Box<LifetimeJoin<Dyn<std_future_Future<Result<std_fs_FileType, std_io_Error>>>, Send<Dyn<std_future_Future<Result<std_fs_FileType, std_io_Error>>>>>>> = Fable.Core.RustInterop.emitRustExpr () v3 
    let v5 : string = "v4.await"
    let v6 : Result<std_fs_FileType, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v5 
    let v7 : (std_io_Error -> std_string_String) = method47()
    let v8 : string = "$0.map_err(|x| $1(x))"
    let v9 : Result<std_fs_FileType, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v6, v7) v8 
    let v10 : (std_fs_FileType -> US37) = closure90()
    let v11 : (std_string_String -> US37) = closure91()
    let v12 : US37 = match v9 with Ok x -> v10 x | Error x -> v11 x
    let v22 : US36 =
        match v12 with
        | US37_0(v13) -> (* Ok *)
            let v14 : std_fs_FileType = method109(v13)
            let v15 : string = "std::fs::FileType::is_dir(&v14)"
            let v16 : bool = Fable.Core.RustInterop.emitRustExpr () v15 
            let v17 : bool = v16 = false
            if v17 then
                US36_0
            else
                US36_2
        | _ ->
            US36_2
    let v23 : US36 = method110(v22)
    let v24 : string = ""
    let v25 : string = "}"
    let v26 : string = v24 + v25 
    let v27 : string = v26 + v25 
    let v28 : string = "{"
    let v29 : string = v24 + v28 
    let v30 : string = "v23 " + v27 + "); " + v29 + " //"
    Fable.Core.RustInterop.emitRustExpr () v30 
    let v31 : string = "__result"
    let v32 : std_pin_Pin<Box<LifetimeJoin<Dyn<std_future_Future<US36>>, Send<Dyn<std_future_Future<US36>>>>>> = Fable.Core.RustInterop.emitRustExpr () v31 
    v32
and method111 (v0 : async_walkdir_Filtering) : async_walkdir_Filtering =
    v0
and method106 (v0 : async_walkdir_DirEntry) : std_pin_Pin<Box<LifetimeJoin<Dyn<std_future_Future<async_walkdir_Filtering>>, Send<Dyn<std_future_Future<async_walkdir_Filtering>>>>>> =
    let v1 : string = "let __result = Box::pin(async { //"
    Fable.Core.RustInterop.emitRustExpr () v1 
    let v2 : std_pin_Pin<Box<LifetimeJoin<Dyn<std_future_Future<US36>>, Send<Dyn<std_future_Future<US36>>>>>> = method107(v0)
    let v3 : string = "v2.await"
    let v4 : US36 = Fable.Core.RustInterop.emitRustExpr () v3 
    let v13 : async_walkdir_Filtering =
        match v4 with
        | US36_2 -> (* Continue *)
            let v9 : string = "async_walkdir::Filtering::Continue"
            let v10 : async_walkdir_Filtering = Fable.Core.RustInterop.emitRustExpr () v9 
            v10
        | US36_0 -> (* Ignore *)
            let v5 : string = "async_walkdir::Filtering::Ignore"
            let v6 : async_walkdir_Filtering = Fable.Core.RustInterop.emitRustExpr () v5 
            v6
        | US36_1 -> (* IgnoreDir *)
            let v7 : string = "async_walkdir::Filtering::IgnoreDir"
            let v8 : async_walkdir_Filtering = Fable.Core.RustInterop.emitRustExpr () v7 
            v8
    let v14 : async_walkdir_Filtering = method111(v13)
    let v15 : string = ""
    let v16 : string = "}"
    let v17 : string = v15 + v16 
    let v18 : string = v17 + v16 
    let v19 : string = "{"
    let v20 : string = v15 + v19 
    let v21 : string = "v14 " + v18 + "); " + v20 + " //"
    Fable.Core.RustInterop.emitRustExpr () v21 
    let v22 : string = "__result"
    let v23 : std_pin_Pin<Box<LifetimeJoin<Dyn<std_future_Future<async_walkdir_Filtering>>, Send<Dyn<std_future_Future<async_walkdir_Filtering>>>>>> = Fable.Core.RustInterop.emitRustExpr () v22 
    v23
and closure89 () (v0 : async_walkdir_DirEntry) : std_pin_Pin<Box<LifetimeJoin<Dyn<std_future_Future<async_walkdir_Filtering>>, Send<Dyn<std_future_Future<async_walkdir_Filtering>>>>>> =
    method106(v0)
and closure93 () (v0 : async_walkdir_DirEntry) : US38 =
    US38_0(v0)
and closure94 () (v0 : std_string_String) : US38 =
    US38_1(v0)
and closure95 () () : string =
    let v0 : string = "spiral_builder.process_typescript / stream_filter_map"
    v0
and closure96 (v0 : std_string_String) () : string =
    let v1 : (unit -> string) = closure6()
    let v2 : string = $"error: {v0} / {v1 ()}"
    v2
and closure92 () (v0 : Result<async_walkdir_DirEntry, std_io_Error>) : struct (string * string) option =
    let v1 : (std_io_Error -> std_string_String) = method47()
    let v2 : string = "$0.map_err(|x| $1(x))"
    let v3 : Result<async_walkdir_DirEntry, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v0, v1) v2 
    let v4 : (async_walkdir_DirEntry -> US38) = closure93()
    let v5 : (std_string_String -> US38) = closure94()
    let v6 : US38 = match v3 with Ok x -> v4 x | Error x -> v5 x
    let v117 : US39 =
        match v6 with
        | US38_1(v111) -> (* Error *)
            let v112 : US0 = US0_4
            let v113 : (unit -> string) = closure95()
            let v114 : (unit -> string) = closure96(v111)
            method5(v112, v113, v114)
            US39_1
        | US38_0(v7) -> (* Ok *)
            let v8 : string = "async_walkdir::DirEntry::path(&$0)"
            let v9 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v7 v8 
            let v10 : string = "$0.display()"
            let v11 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v9 v10 
            let v12 : bool = true
            let mutable _v12 : std_string_String option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v13 : string = "format!(\"{}\", $0)"
            let v14 : std_string_String = Fable.Core.RustInterop.emitRustExpr v11 v13 
            v14 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v15 : string = "format!(\"{}\", $0)"
            let v16 : std_string_String = Fable.Core.RustInterop.emitRustExpr v11 v15 
            v16 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v17 : string = "format!(\"{}\", $0)"
            let v18 : std_string_String = Fable.Core.RustInterop.emitRustExpr v11 v17 
            v18 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v19 : std_string_String = null |> unbox<std_string_String>
            v19 
            #endif
#if FABLE_COMPILER_PYTHON
            let v20 : std_string_String = null |> unbox<std_string_String>
            v20 
            #endif
#else
            let v21 : std_string_String = null |> unbox<std_string_String>
            v21 
            #endif
            |> fun x -> _v12 <- Some x
            let v22 : std_string_String = match _v12 with Some x -> x | None -> failwith "base.run_target / _v12=None"
            let v23 : string = "fable_library_rust::String_::fromString($0)"
            let v24 : string = Fable.Core.RustInterop.emitRustExpr v22 v23 
            let v25 : string = "ts"
            let v26 : string = $"fable-library-{v25}\.(?<a>[\d.]+)$"
            let v27 : string = $"regex::Regex::new(&$0)"
            let v28 : Result<regex_Regex, regex_Error> = Fable.Core.RustInterop.emitRustExpr v26 v27 
            let v29 : string = "$0.unwrap()"
            let v30 : regex_Regex = Fable.Core.RustInterop.emitRustExpr v28 v29 
            let v31 : string = "&*$0"
            let v32 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v24 v31 
            let v33 : string = "String::from($0)"
            let v34 : std_string_String = Fable.Core.RustInterop.emitRustExpr v32 v33 
            let v35 : string = "true; let _result = (move || { //"
            let v36 : bool = Fable.Core.RustInterop.emitRustExpr () v35 
            let v37 : string = "Box::new($0)"
            let v38 : Box<std_string_String> = Fable.Core.RustInterop.emitRustExpr v34 v37 
            let v39 : string = "Box::leak($0)"
            let v40 : Ref<Lifetime<StaticLifetime, Mut<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr v38 v39 
            let v41 : string = $"v30.captures_iter(v40)"
            let v42 : regex_CaptureMatches = Fable.Core.RustInterop.emitRustExpr () v41 
            let v43 : string = "true; let _result : Vec<_> = v42.map(|x| { //"
            let v44 : bool = Fable.Core.RustInterop.emitRustExpr () v43 
            let v45 : string = $"x"
            let v46 : regex_Captures<StaticLifetime> = Fable.Core.RustInterop.emitRustExpr () v45 
            let v47 : string = "Box::new($0)"
            let v48 : Box<regex_Captures<StaticLifetime>> = Fable.Core.RustInterop.emitRustExpr v46 v47 
            let v49 : string = "Box::leak($0)"
            let v50 : Ref<Lifetime<StaticLifetime, Mut<regex_Captures<StaticLifetime>>>> = Fable.Core.RustInterop.emitRustExpr v48 v49 
            let v51 : string = $"$0.capture_names()"
            let v52 : regex_CaptureNames = Fable.Core.RustInterop.emitRustExpr v30 v51 
            let v53 : string = "true; let _result : std::collections::HashMap<_, _> = v52.map(|x| { //"
            let v54 : bool = Fable.Core.RustInterop.emitRustExpr () v53 
            let v55 : string = "x.unwrap_or(\"\").to_string().into()"
            let v56 : string = Fable.Core.RustInterop.emitRustExpr () v55 
            let v57 : string = "$0.clone()"
            let v58 : string = Fable.Core.RustInterop.emitRustExpr v56 v57 
            let v59 : string = $"v50.name(&$0).map(|x| x.as_str()).unwrap_or(\"\").to_string().into()"
            let v60 : string = Fable.Core.RustInterop.emitRustExpr v56 v59 
            let v61 : (string * string) = v58, v60 
            let v62 : string = "true; $0 }).map(|x| std::sync::Arc::try_unwrap(x).unwrap_or_else(|x| (*x).clone())).collect()"
            let v63 : bool = Fable.Core.RustInterop.emitRustExpr v61 v62 
            let v64 : string = "_result"
            let v65 : std_collections_HashMap<string, string> = Fable.Core.RustInterop.emitRustExpr () v64 
            let v66 : string = "true; $0 }).collect::<Vec<_>>()"
            let v67 : bool = Fable.Core.RustInterop.emitRustExpr v65 v66 
            let v68 : string = "_result"
            let v69 : Vec<std_collections_HashMap<string, string>> = Fable.Core.RustInterop.emitRustExpr () v68 
            let v70 : string = "true; $0 })()"
            let v71 : bool = Fable.Core.RustInterop.emitRustExpr v69 v70 
            let v72 : string = "_result"
            let v73 : Vec<std_collections_HashMap<string, string>> = Fable.Core.RustInterop.emitRustExpr () v72 
            let v74 : string = "fable_library_rust::NativeArray_::array_from($0)"
            let v75 : (std_collections_HashMap<string, string> []) = Fable.Core.RustInterop.emitRustExpr v73 v74 
            let v76 : (int32 -> ((std_collections_HashMap<string, string> []) -> std_collections_HashMap<string, string> option)) = Array.tryItem
            let v77 : ((std_collections_HashMap<string, string> []) -> std_collections_HashMap<string, string> option) = v76 0
            let v78 : std_collections_HashMap<string, string> option = v77 v75
            let v79 : US34 option = None
            let _v79 = ref v79 
            match v78 with
            | Some x -> (
            (fun () ->
            (fun () ->
            let v80 : std_collections_HashMap<string, string> = x
            let v81 : US34 = US34_0(v80)
            v81 
            )
            |> fun x -> x () |> Some
            ) () ) | None -> None
            |> fun x -> _v79.Value <- x
            let v82 : US34 option = _v79.Value 
            let v83 : US34 = US34_1
            let v84 : US34 = v82 |> Option.defaultValue v83 
            let v98 : US35 =
                match v84 with
                | US34_1 -> (* None *)
                    US35_1
                | US34_0(v85) -> (* Some *)
                    let v86 : string = method102()
                    let v87 : string = "std::collections::HashMap::get(&$0, &v86).map(|x| x).cloned()"
                    let v88 : string option = Fable.Core.RustInterop.emitRustExpr v85 v87 
                    let v89 : US3 option = None
                    let _v89 = ref v89 
                    match v88 with
                    | Some x -> (
                    (fun () ->
                    (fun () ->
                    let v90 : string = x
                    let v91 : US3 = US3_0(v90)
                    v91 
                    )
                    |> fun x -> x () |> Some
                    ) () ) | None -> None
                    |> fun x -> _v89.Value <- x
                    let v92 : US3 option = _v89.Value 
                    let v93 : US3 = US3_1
                    let v94 : US3 = v92 |> Option.defaultValue v93 
                    US35_0(v94)
            let v105 : US3 =
                match v98 with
                | US35_0(v99) -> (* Some *)
                    match v99 with
                    | US3_0(v100) -> (* Some *)
                        US3_0(v100)
                    | _ ->
                        US3_1
                | _ ->
                    US3_1
            match v105 with
            | US3_1 -> (* None *)
                US39_1
            | US3_0(v107) -> (* Some *)
                US39_0(v24, v107)
    match v117 with
    | US39_1 -> (* None *)
        let v121 : struct (string * string) option = None
        v121
    | US39_0(v118, v119) -> (* Some *)
        let v120 : struct (string * string) option = Some struct (v118, v119) 
        v120
and method112 () : (Result<async_walkdir_DirEntry, std_io_Error> -> struct (string * string) option) =
    closure92()
and closure97 () struct (v0 : string, v1 : string) : struct (string * string) =
    struct (v0, v1)
and closure98 () () : string =
    let v0 : string = "spiral_builder.process_typescript"
    v0
and closure99 (v0 : US39) () : string =
    let v1 : bool = true
    let mutable _v1 : std_string_String option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = "format!(\"{:#?}\", $0)"
    let v3 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v2 
    v3 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v4 : string = "format!(\"{:#?}\", $0)"
    let v5 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v4 
    v5 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v6 : string = "format!(\"{:#?}\", $0)"
    let v7 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v6 
    v7 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v8 : std_string_String = null |> unbox<std_string_String>
    v8 
    #endif
#if FABLE_COMPILER_PYTHON
    let v9 : std_string_String = null |> unbox<std_string_String>
    v9 
    #endif
#else
    let v10 : std_string_String = null |> unbox<std_string_String>
    v10 
    #endif
    |> fun x -> _v1 <- Some x
    let v11 : std_string_String = match _v1 with Some x -> x | None -> failwith "base.run_target / _v1=None"
    let v12 : (unit -> string) = closure6()
    let v13 : string = $"version: {v11} / {v12 ()}"
    v13
and closure100 (v0 : string, v1 : int32) () : string =
    let v2 : string = $"spiral_builder.process_typescript / exit_code: {v1} / dotnet_fable_result: {v0}"
    v2
and closure101 () () : string =
    let v0 : string = "spiral_builder.process_typescript"
    v0
and closure102 (v0 : string) () : string =
    let v1 : (unit -> string) = closure6()
    let v2 : string = $"new_code_path: {v0} / {v1 ()}"
    v2
and method113 (v0 : UH4, v1 : UH4) : UH4 =
    match v0 with
    | UH4_1(v2, v3, v4) -> (* Cons *)
        let v5 : UH4 = method113(v4, v1)
        UH4_1(v2, v3, v5)
    | UH4_0 -> (* Nil *)
        v1
and method114 (v0 : UH4, v1 : struct (string * string) list) : struct (string * string) list =
    match v0 with
    | UH4_1(v2, v3, v4) -> (* Cons *)
        let v5 : struct (string * string) list = method114(v4, v1)
        let v6 : struct (string * string) list = struct (v2, v3) :: v5 
        v6
    | UH4_0 -> (* Nil *)
        v1
and closure103 (v0 : string) () : string =
    let v1 : string = "\n"
    let v2 : (string []) = v0.Split v1 
    let v3 : ((string []) -> string seq) = Seq.ofArray
    let v4 : string seq = v3 v2
    let v5 : (string -> (string seq -> string)) = String.concat
    let v6 : (string seq -> string) = v5 v1
    v6 v4
and closure105 () () : string =
    let v0 : string = "spiral_builder.process_typescript / Exception"
    v0
and closure106 (v0 : string, v1 : string, v2 : string, v3 : exn) () : string =
    let v4 : (unit -> string) = closure6()
    let v5 : string = $"ex: {v3} / new_code_path: {v0} / external_command: {v2} / run_result: {v1} / {v4 ()}"
    v5
and closure104 (v0 : string, v1 : string, v2 : string) (v3 : exn) : US3 =
    let v4 : US0 = US0_4
    let v5 : (unit -> string) = closure105()
    let v6 : (unit -> string) = closure106(v0, v1, v2, v3)
    method5(v4, v5, v6)
    US3_1
and closure107 () () : string =
    let v0 : string = "spiral_builder.process_typescript / error"
    v0
and closure108 (v0 : string, v1 : string, v2 : int32, v3 : string) () : string =
    let v4 : string = $"exit_code: {v2} / new_code_path: {v0} / external_command: {v3} / run_result: {v1}"
    v4
and closure109 (v0 : string, v1 : int32) () : string =
    let v2 : string = $"spiral_builder.process_python / exit_code: {v1} / dotnet_fable_result: {v0}"
    v2
and closure110 () () : string =
    let v0 : string = "spiral_builder.process_python"
    v0
and closure111 (v0 : string) () : string =
    let v1 : (unit -> string) = closure6()
    let v2 : string = $"new_code_path: {v0} / {v1 ()}"
    v2
and closure112 (v0 : string) () : string =
    let v1 : string = "\n"
    let v2 : (string []) = v0.Split v1 
    let v3 : ((string []) -> string seq) = Seq.ofArray
    let v4 : string seq = v3 v2
    let v5 : (string -> (string seq -> string)) = String.concat
    let v6 : (string seq -> string) = v5 v1
    v6 v4
and closure114 () () : string =
    let v0 : string = "spiral_builder.process_python / Exception"
    v0
and closure115 (v0 : string, v1 : string, v2 : string, v3 : exn) () : string =
    let v4 : (unit -> string) = closure6()
    let v5 : string = $"ex: {v3} / new_code_path: {v0} / external_command: {v2} / run_result: {v1} / {v4 ()}"
    v5
and closure113 (v0 : string, v1 : string, v2 : string) (v3 : exn) : US3 =
    let v4 : US0 = US0_4
    let v5 : (unit -> string) = closure114()
    let v6 : (unit -> string) = closure115(v0, v1, v2, v3)
    method5(v4, v5, v6)
    US3_1
and closure116 () () : string =
    let v0 : string = "spiral_builder.process_python / error"
    v0
and closure117 (v0 : string, v1 : string, v2 : int32, v3 : string) () : string =
    let v4 : string = $"exit_code: {v2} / new_code_path: {v0} / external_command: {v3} / run_result: {v1}"
    v4
and closure118 () () : string =
    let v0 : string = "spiral_builder.run / invalid subcommand"
    v0
and closure119 (v0 : clap_ArgMatches, v1 : std_string_String) () : string =
    let v2 : (unit -> string) = closure6()
    let v3 : string = $"subcommand: {v1} / arg_matches: %A{v0} / {v2 ()}"
    v3
and closure120 () struct (v0 : string, v1 : string) : (std_string_String * std_string_String) =
    let v2 : string = "&*$0"
    let v3 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v2 
    let v4 : string = "String::from($0)"
    let v5 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3 v4 
    let v6 : string = "&*$0"
    let v7 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1 v6 
    let v8 : string = "String::from($0)"
    let v9 : std_string_String = Fable.Core.RustInterop.emitRustExpr v7 v8 
    let v10 : (std_string_String * std_string_String) = v5, v9 
    v10
and closure121 () (v0 : serde_json_Error) : string =
    let v1 : bool = true
    let mutable _v1 : std_string_String option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = "format!(\"{}\", $0)"
    let v3 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v2 
    v3 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v4 : string = "format!(\"{}\", $0)"
    let v5 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v4 
    v5 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v6 : string = "format!(\"{}\", $0)"
    let v7 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v6 
    v7 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v8 : std_string_String = null |> unbox<std_string_String>
    v8 
    #endif
#if FABLE_COMPILER_PYTHON
    let v9 : std_string_String = null |> unbox<std_string_String>
    v9 
    #endif
#else
    let v10 : std_string_String = null |> unbox<std_string_String>
    v10 
    #endif
    |> fun x -> _v1 <- Some x
    let v11 : std_string_String = match _v1 with Some x -> x | None -> failwith "base.run_target / _v1=None"
    let v12 : string = "fable_library_rust::String_::fromString($0)"
    let v13 : string = Fable.Core.RustInterop.emitRustExpr v11 v12 
    v13
and method115 () : (serde_json_Error -> string) =
    closure121()
and method116 (v0 : Result<string, string>) : Result<string, string> =
    v0
and method10 (v0 : US0, v1 : clap_ArgMatches) : std_pin_Pin<Box<Dyn<std_future_Future<Result<string, string>>>>> =
    let v2 : string = "let __result = Box::pin(async move { //"
    Fable.Core.RustInterop.emitRustExpr () v2 
    let v3 : string = "clap::ArgMatches::subcommand(Box::leak(Box::new($0))).map(|(a, b)| ($1(a), b.clone()))"
    let v4 : (Ref<Str> -> std_string_String) = closure8()
    let v5 : struct (std_string_String * clap_ArgMatches) option = Fable.Core.RustInterop.emitRustExpr struct (v1, v4) v3 
    let v6 : US4 option = None
    let _v6 = ref v6 
    match v5 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let struct (v7 : std_string_String, v8 : clap_ArgMatches) = x
    let v9 : US4 = US4_0(v7, v8)
    v9 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v6.Value <- x
    let v10 : US4 option = _v6.Value 
    let v11 : US4 = US4_1
    let v12 : US4 = v10 |> Option.defaultValue v11 
    let v2337 : (struct (string * string) []) =
        match v12 with
        | US4_0(v13, v14) -> (* Some *)
            let v15 : string = "fable_library_rust::String_::fromString($0)"
            let v16 : string = Fable.Core.RustInterop.emitRustExpr v13 v15 
            let v18 : bool = v16 = "cuda"
            if v18 then
                let v19 : string = method11()
                let v20 : string = "&*$0"
                let v21 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v19 v20 
                let v22 : string = "clap::ArgMatches::get_one(&$0, v21).cloned()"
                let v23 : std_string_String option = Fable.Core.RustInterop.emitRustExpr v14 v22 
                let v24 : US5 option = None
                let _v24 = ref v24 
                match v23 with
                | Some x -> (
                (fun () ->
                (fun () ->
                let v25 : std_string_String = x
                let v26 : US5 = US5_0(v25)
                v26 
                )
                |> fun x -> x () |> Some
                ) () ) | None -> None
                |> fun x -> _v24.Value <- x
                let v27 : US5 option = _v24.Value 
                let v28 : US5 = US5_1
                let v29 : US5 = v27 |> Option.defaultValue v28 
                let v33 : std_string_String =
                    match v29 with
                    | US5_1 -> (* None *)
                        failwith<std_string_String> "Option does not have a value."
                    | US5_0(v30) -> (* Some *)
                        v30
                let v34 : string = "fable_library_rust::String_::fromString($0)"
                let v35 : string = Fable.Core.RustInterop.emitRustExpr v33 v34 
                let v36 : string = method12()
                let v37 : string = "&*$0"
                let v38 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v36 v37 
                let v39 : string = "clap::ArgMatches::get_one(&$0, v38).cloned()"
                let v40 : std_string_String option = Fable.Core.RustInterop.emitRustExpr v14 v39 
                let v41 : US5 option = None
                let _v41 = ref v41 
                match v40 with
                | Some x -> (
                (fun () ->
                (fun () ->
                let v42 : std_string_String = x
                let v43 : US5 = US5_0(v42)
                v43 
                )
                |> fun x -> x () |> Some
                ) () ) | None -> None
                |> fun x -> _v41.Value <- x
                let v44 : US5 option = _v41.Value 
                let v45 : US5 = US5_1
                let v46 : US5 = v44 |> Option.defaultValue v45 
                let v74 : US6 =
                    match v46 with
                    | US5_1 -> (* None *)
                        US6_1
                    | US5_0(v47) -> (* Some *)
                        let v48 : string = "fable_library_rust::String_::fromString($0)"
                        let v49 : string = Fable.Core.RustInterop.emitRustExpr v47 v48 
                        let v51 : bool = "Pip" = v49
                        let v55 : US7 =
                            if v51 then
                                let v52 : US8 = US8_0
                                US7_0(v52)
                            else
                                US7_1
                        let v70 : US7 =
                            match v55 with
                            | US7_1 -> (* None *)
                                let v59 : bool = "Poetry" = v49
                                let v63 : US7 =
                                    if v59 then
                                        let v60 : US8 = US8_1
                                        US7_0(v60)
                                    else
                                        US7_1
                                match v63 with
                                | US7_1 -> (* None *)
                                    US7_1
                                | US7_0(v64) -> (* Some *)
                                    US7_0(v64)
                            | US7_0(v56) -> (* Some *)
                                US7_0(v56)
                        US6_0(v70)
                let v81 : US7 =
                    match v74 with
                    | US6_0(v75) -> (* Some *)
                        match v75 with
                        | US7_0(v76) -> (* Some *)
                            US7_0(v76)
                        | _ ->
                            US7_1
                    | _ ->
                        US7_1
                let v85 : US8 =
                    match v81 with
                    | US7_1 -> (* None *)
                        US8_0
                    | US7_0(v82) -> (* Some *)
                        v82
                let v86 : string = method13()
                let v87 : string = "&*$0"
                let v88 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v86 v87 
                let v89 : string = "clap::ArgMatches::get_many(&$0, v88).map(|x| x.cloned().into_iter().collect())"
                let v90 : Vec<std_string_String> option = Fable.Core.RustInterop.emitRustExpr v14 v89 
                let v91 : US9 option = None
                let _v91 = ref v91 
                match v90 with
                | Some x -> (
                (fun () ->
                (fun () ->
                let v92 : Vec<std_string_String> = x
                let v93 : US9 = US9_0(v92)
                v93 
                )
                |> fun x -> x () |> Some
                ) () ) | None -> None
                |> fun x -> _v91.Value <- x
                let v94 : US9 option = _v91.Value 
                let v95 : US9 = US9_1
                let v96 : US9 = v94 |> Option.defaultValue v95 
                let v97 : (std_string_String []) = [||]
                let v98 : string = "$0.to_vec()"
                let v99 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr v97 v98 
                let v102 : Vec<std_string_String> =
                    match v96 with
                    | US9_1 -> (* None *)
                        v99
                    | US9_0(v100) -> (* Some *)
                        v100
                let v103 : bool = true
                let mutable _v103 : string option = None 
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v104 : bool = true
                let mutable _v104 : Vec<uint8> option = None 
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v105 : string = "std::fs::read(&*$0).unwrap()"
                let v106 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v35 v105 
                v106 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v107 : Vec<uint8> = null |> unbox<Vec<uint8>>
                v107 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v108 : Vec<uint8> = null |> unbox<Vec<uint8>>
                v108 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v109 : Vec<uint8> = null |> unbox<Vec<uint8>>
                v109 
                #endif
#if FABLE_COMPILER_PYTHON
                let v110 : Vec<uint8> = null |> unbox<Vec<uint8>>
                v110 
                #endif
#else
                let v111 : (uint8 []) = v35 |> System.IO.File.ReadAllBytes
                let v112 : string = "$0.to_vec()"
                let v113 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v111 v112 
                v113 
                #endif
                |> fun x -> _v104 <- Some x
                let v114 : Vec<uint8> = match _v104 with Some x -> x | None -> failwith "base.run_target / _v104=None"
                let v115 : string = "std::string::String::from_utf8(v114)"
                let v116 : Result<std_string_String, std_string_FromUtf8Error> = Fable.Core.RustInterop.emitRustExpr () v115 
                let v117 : string = "$0.unwrap()"
                let v118 : std_string_String = Fable.Core.RustInterop.emitRustExpr v116 v117 
                let v119 : string = "fable_library_rust::String_::fromString($0)"
                let v120 : string = Fable.Core.RustInterop.emitRustExpr v118 v119 
                v120 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v121 : string = null |> unbox<string>
                v121 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v122 : string = null |> unbox<string>
                v122 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v123 : string = null |> unbox<string>
                v123 
                #endif
#if FABLE_COMPILER_PYTHON
                let v124 : string = null |> unbox<string>
                v124 
                #endif
#else
                let v125 : string = v35 |> System.IO.File.ReadAllText
                v125 
                #endif
                |> fun x -> _v103 <- Some x
                let v126 : string = match _v103 with Some x -> x | None -> failwith "base.run_target / _v103=None"
                let v127 : string = __SOURCE_DIRECTORY__
                let v128 : string = method14()
                let v129 : string = "polyglot"
                let v130 : string = ".paket"
                let v131 : string = method15(v129, v130)
                let v132 : US12 = method18(v131, v127)
                let v141 : US3 =
                    match v132 with
                    | US12_1(v135) -> (* Error *)
                        let v136 : US0 = US0_3
                        let v137 : (unit -> string) = closure10()
                        let v138 : (unit -> string) = closure11(v135)
                        method5(v136, v137, v138)
                        US3_1
                    | US12_0(v133) -> (* Ok *)
                        US3_0(v133)
                let v156 : US3 =
                    match v141 with
                    | US3_1 -> (* None *)
                        let v144 : string = method15(v129, v130)
                        let v145 : US12 = method18(v144, v128)
                        match v145 with
                        | US12_1(v148) -> (* Error *)
                            let v149 : US0 = US0_3
                            let v150 : (unit -> string) = closure10()
                            let v151 : (unit -> string) = closure11(v148)
                            method5(v149, v150, v151)
                            US3_1
                        | US12_0(v146) -> (* Ok *)
                            US3_0(v146)
                    | US3_0(v142) -> (* Some *)
                        US3_0(v142)
                let v160 : string =
                    match v156 with
                    | US3_1 -> (* None *)
                        failwith<string> "Option does not have a value."
                    | US3_0(v157) -> (* Some *)
                        v157
                let v161 : string = method15(v160, v129)
                let v162 : string = method14()
                let v163 : (unit -> string) = v162.ToLower
                let v164 : string = v163 ()
                let v165 : (unit -> string) = v161.ToLower
                let v166 : string = v165 ()
                let v167 : bool = v164.StartsWith v166 
                let v170 : US12 =
                    if v167 then
                        US12_1(v166)
                    else
                        US12_0(v166)
                let v176 : Result<string, string> =
                    match v170 with
                    | US12_1(v173) -> (* Error *)
                        let v174 : Result<string, string> = Error v173 
                        v174
                    | US12_0(v171) -> (* Ok *)
                        let v172 : Result<string, string> = Ok v171 
                        v172
                let v177 : string = "true; let _result = $0.unwrap_or_else(|x| { //"
                let v178 : bool = Fable.Core.RustInterop.emitRustExpr v176 v177 
                let v179 : string = "x"
                let v180 : string = Fable.Core.RustInterop.emitRustExpr () v179 
                let v181 : string = "true; $0 })"
                let v182 : bool = Fable.Core.RustInterop.emitRustExpr v180 v181 
                let v183 : string = "_result"
                let v184 : string = Fable.Core.RustInterop.emitRustExpr () v183 
                let v185 : string = method23(v35)
                let v191 : string =
                    match v85 with
                    | US8_0 -> (* Pip *)
                        let v186 : string = "requirements.txt"
                        method15(v185, v186)
                    | US8_1 -> (* Poetry *)
                        let v188 : string = "pyproject.toml"
                        method15(v185, v188)
                let v192 : string = "true; let _result : Vec<_> = v102.into_iter().map(|x| { //"
                let v193 : bool = Fable.Core.RustInterop.emitRustExpr () v192 
                let v194 : string = "x"
                let v195 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v194 
                let v196 : string = "fable_library_rust::String_::fromString($0)"
                let v197 : string = Fable.Core.RustInterop.emitRustExpr v195 v196 
                let v198 : string = "="
                let v199 : bool = v197.Contains v198 
                let v208 : string =
                    if v199 then
                        v197
                    else
                        let v200 : string = "]"
                        let v201 : bool = v197.EndsWith v200 
                        if v201 then
                            let v202 : string = $"={{version='*',features=["
                            let v203 : string = "["
                            let v204 : string = v197.Replace (v203, v202)
                            let v205 : string = $"{v204}}}"
                            v205
                        else
                            let v206 : string = $"{v197}='*'"
                            v206
                let v209 : string = "true; $0 }).collect::<Vec<_>>()"
                let v210 : bool = Fable.Core.RustInterop.emitRustExpr v208 v209 
                let v211 : string = "_result"
                let v212 : Vec<string> = Fable.Core.RustInterop.emitRustExpr () v211 
                let v213 : string = "fable_library_rust::NativeArray_::array_from($0)"
                let v214 : (string []) = Fable.Core.RustInterop.emitRustExpr v212 v213 
                let v215 : string seq = seq { for i = 0 to v214.Length - 1 do yield v214.[i] }
                let v216 : (string -> (string seq -> string)) = String.concat
                let v217 : string = "\n"
                let v218 : (string seq -> string) = v216 v217
                let v219 : string = v218 v215
                let v221 : bool = v219 = ""
                let struct (v275 : int32, v276 : string) =
                    if v221 then
                        let v222 : string = ""
                        struct (0, v222)
                    else
                        let v261 : string =
                            match v85 with
                            | US8_0 -> (* Pip *)
                                v219
                            | US8_1 -> (* Poetry *)
                                let v223 : string = $"[tool.poetry]"
                                let v224 : string = $"name = \"test\""
                                let v225 : string = v223 + v217 
                                let v226 : string = v225 + v224 
                                let v227 : string = $"version = \"0.0.1\""
                                let v228 : string = v226 + v217 
                                let v229 : string = v228 + v227 
                                let v230 : string = $"description = \"\""
                                let v231 : string = v229 + v217 
                                let v232 : string = v231 + v230 
                                let v233 : string = $"authors = []"
                                let v234 : string = v232 + v217 
                                let v235 : string = v234 + v233 
                                let v236 : string = $""
                                let v237 : string = v235 + v217 
                                let v238 : string = v237 + v236 
                                let v239 : string = $"[tool.poetry.dependencies]"
                                let v240 : string = v238 + v217 
                                let v241 : string = v240 + v239 
                                let v242 : string = $"python=\"~3.12\""
                                let v243 : string = v241 + v217 
                                let v244 : string = v243 + v242 
                                let v245 : string = $"{v219}"
                                let v246 : string = v244 + v217 
                                let v247 : string = v246 + v245 
                                let v248 : string = $""
                                let v249 : string = v247 + v217 
                                let v250 : string = v249 + v248 
                                let v251 : string = $"[build-system]"
                                let v252 : string = v250 + v217 
                                let v253 : string = v252 + v251 
                                let v254 : string = $"requires = [\"poetry-core\"]"
                                let v255 : string = v253 + v217 
                                let v256 : string = v255 + v254 
                                let v257 : string = $"build-backend = \"poetry.core.masonry.api\""
                                let v258 : string = v256 + v217 
                                let v259 : string = v258 + v257 
                                v259
                        method24(v191, v261)
                        let v262 : System.Threading.CancellationToken option = None
                        let v263 : (struct (string * string) []) = [||]
                        let v264 : (struct (bool * string * int32) -> Async<unit>) option = None
                        let v265 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = None
                        let v266 : string option = None
                        let v270 : string =
                            match v85 with
                            | US8_0 -> (* Pip *)
                                let v267 : string = $"pip install -r requirements.txt"
                                v267
                            | US8_1 -> (* Poetry *)
                                let v268 : string = $"poetry install"
                                v268
                        let v271 : string option = Some v185 
                        let v272 : bool = true
                        method28(v262, v270, v263, v264, v265, v272, v271)
                let v277 : bool = v275 <> 0 
                let struct (v343 : US3, v344 : US3, v345 : US3) =
                    if v277 then
                        let v278 : US0 = US0_4
                        let v279 : (unit -> string) = closure42()
                        let v280 : (unit -> string) = closure43(v85, v35, v276, v275)
                        method5(v278, v279, v280)
                        let v281 : US3 = US3_1
                        let v282 : string = "py"
                        let v283 : US3 = US3_0(v282)
                        let v284 : US3 = US3_1
                        struct (v281, v283, v284)
                    else
                        let v288 : string =
                            match v85 with
                            | US8_0 -> (* Pip *)
                                let v285 : string = $"python \"{v35}\""
                                v285
                            | US8_1 -> (* Poetry *)
                                let v286 : string = $"poetry run python \"{v35}\""
                                v286
                        let v289 : string = "TRACE_LEVEL"
                        let v290 : string = "Verbose"
                        let v291 : (struct (string * string) []) = [|struct (v289, v290)|]
                        let v292 : System.Threading.CancellationToken option = None
                        let v293 : (struct (string * string) []) = [||]
                        let v294 : (struct (bool * string * int32) -> Async<unit>) option = None
                        let v295 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = None
                        let v296 : string option = None
                        let v297 : string option = Some v185 
                        let v298 : bool = true
                        let struct (v299 : int32, v300 : string) = method28(v292, v288, v291, v294, v295, v298, v297)
                        let v301 : int32 = v291.Length
                        let v302 : (string []) = Array.zeroCreate<string> (v301)
                        let v303 : Mut4 = {l0 = 0} : Mut4
                        while method32(v301, v303) do
                            let v305 : int32 = v303.l0
                            let struct (v306 : string, v307 : string) = v291.[int v305]
                            let v308 : string = $"$env:{v306}=''{v307}''"
                            v302.[int v305] <- v308
                            let v309 : int32 = v305 + 1
                            v303.l0 <- v309
                            ()
                        let v310 : ((string []) -> string seq) = Seq.ofArray
                        let v311 : string seq = v310 v302
                        let v312 : (string -> (string seq -> string)) = String.concat
                        let v313 : string = ";"
                        let v314 : (string seq -> string) = v312 v313
                        let v315 : string = v314 v311
                        let v316 : string = $"pwsh -c '{v315}; {v288}'"
                        let v317 : bool = v299 = 0
                        if v317 then
                            let v318 : (unit -> string) = closure44(v300)
                            let v319 : (string -> US3) = closure45()
                            let v320 : (exn -> US3) = closure46(v35, v300, v316)
                            let v321 : US3 = try v318 () |> v319 with ex -> v320 ex 
                            let v326 : string option =
                                match v321 with
                                | US3_1 -> (* None *)
                                    let v324 : string option = None
                                    v324
                                | US3_0(v322) -> (* Some *)
                                    let v323 : string option = Some v322 
                                    v323
                            let v327 : string = "$0.unwrap()"
                            let v328 : string = Fable.Core.RustInterop.emitRustExpr v326 v327 
                            let v329 : US3 = US3_0(v126)
                            let v330 : string = "py"
                            let v331 : US3 = US3_0(v330)
                            let v332 : US3 = US3_0(v328)
                            struct (v329, v331, v332)
                        else
                            let v333 : US0 = US0_4
                            let v334 : (unit -> string) = closure49()
                            let v335 : (unit -> string) = closure50(v35, v300, v299, v316)
                            method5(v333, v334, v335)
                            let v336 : US3 = US3_1
                            let v337 : string = "py"
                            let v338 : US3 = US3_0(v337)
                            let v339 : US3 = US3_1
                            struct (v336, v338, v339)
                let v349 : string =
                    match v344 with
                    | US3_1 -> (* None *)
                        let v347 : string = ""
                        v347
                    | US3_0(v346) -> (* Some *)
                        v346
                let v350 : string = "extension"
                let v354 : string =
                    match v343 with
                    | US3_1 -> (* None *)
                        let v352 : string = ""
                        v352
                    | US3_0(v351) -> (* Some *)
                        v351
                let v355 : string = "code"
                let v359 : string =
                    match v345 with
                    | US3_1 -> (* None *)
                        let v357 : string = ""
                        v357
                    | US3_0(v356) -> (* Some *)
                        v356
                let v360 : string = "output"
                let v361 : (struct (string * string) []) = [|struct (v350, v349); struct (v355, v354); struct (v360, v359)|]
                let v362 : string = "$0.to_vec()"
                let v363 : Vec<struct (string * string)> = Fable.Core.RustInterop.emitRustExpr v361 v362 
                let v364 : string = "$0.into_iter().map(|x| $1(x.clone())).collect::<Vec<_>>()"
                let v365 : (struct (string * string) -> (std_string_String * std_string_String)) = closure51()
                let v366 : Vec<(std_string_String * std_string_String)> = Fable.Core.RustInterop.emitRustExpr struct (v363, v365) v364 
                let v367 : string = "std::collections::BTreeMap::from_iter(v366.iter().map(|x| x.as_ref()).map(|&(ref k, ref v)| (k.clone(), v.clone())))"
                let v368 : std_collections_BTreeMap<std_string_String, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v367 
                let v369 : string = "serde_json::to_string(&v368)"
                let v370 : Result<std_string_String, serde_json_Error> = Fable.Core.RustInterop.emitRustExpr () v369 
                let v371 : string = "$0.unwrap()"
                let v372 : std_string_String = Fable.Core.RustInterop.emitRustExpr v370 v371 
                let v373 : string = "fable_library_rust::String_::fromString($0)"
                let v374 : string = Fable.Core.RustInterop.emitRustExpr v372 v373 
                let v375 : string = "command_result"
                [|struct (v375, v374)|]
            else
                let v377 : string = "fable_library_rust::String_::fromString($0)"
                let v378 : string = Fable.Core.RustInterop.emitRustExpr v13 v377 
                let v380 : bool = v378 = "fable"
                if v380 then
                    let v381 : string = method63()
                    let v382 : string = "&*$0"
                    let v383 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v381 v382 
                    let v384 : string = "clap::ArgMatches::get_one(&$0, v383).cloned()"
                    let v385 : std_string_String option = Fable.Core.RustInterop.emitRustExpr v14 v384 
                    let v386 : US5 option = None
                    let _v386 = ref v386 
                    match v385 with
                    | Some x -> (
                    (fun () ->
                    (fun () ->
                    let v387 : std_string_String = x
                    let v388 : US5 = US5_0(v387)
                    v388 
                    )
                    |> fun x -> x () |> Some
                    ) () ) | None -> None
                    |> fun x -> _v386.Value <- x
                    let v389 : US5 option = _v386.Value 
                    let v390 : US5 = US5_1
                    let v391 : US5 = v389 |> Option.defaultValue v390 
                    let v395 : std_string_String =
                        match v391 with
                        | US5_1 -> (* None *)
                            failwith<std_string_String> "Option does not have a value."
                        | US5_0(v392) -> (* Some *)
                            v392
                    let v396 : string = "fable_library_rust::String_::fromString($0)"
                    let v397 : string = Fable.Core.RustInterop.emitRustExpr v395 v396 
                    let v398 : string = method64()
                    let v399 : string = "&*$0"
                    let v400 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v398 v399 
                    let v401 : string = "clap::ArgMatches::get_one(&$0, v400).cloned()"
                    let v402 : std_string_String option = Fable.Core.RustInterop.emitRustExpr v14 v401 
                    let v403 : US5 option = None
                    let _v403 = ref v403 
                    match v402 with
                    | Some x -> (
                    (fun () ->
                    (fun () ->
                    let v404 : std_string_String = x
                    let v405 : US5 = US5_0(v404)
                    v405 
                    )
                    |> fun x -> x () |> Some
                    ) () ) | None -> None
                    |> fun x -> _v403.Value <- x
                    let v406 : US5 option = _v403.Value 
                    let v407 : US5 = US5_1
                    let v408 : US5 = v406 |> Option.defaultValue v407 
                    let v415 : US3 =
                        match v408 with
                        | US5_1 -> (* None *)
                            US3_1
                        | US5_0(v409) -> (* Some *)
                            let v410 : string = "fable_library_rust::String_::fromString($0)"
                            let v411 : string = Fable.Core.RustInterop.emitRustExpr v409 v410 
                            US3_0(v411)
                    let v449 : string =
                        match v415 with
                        | US3_1 -> (* None *)
                            let v447 : string = "{}"
                            v447
                        | US3_0(v416) -> (* Some *)
                            let v417 : clap_Command = method0()
                            let v418 : string = $"_ {v416} --fs-path \"{v397}\""
                            let v419 : US15 = method35(v418)
                            let v425 : (string []) =
                                match v419 with
                                | US15_1(v421) -> (* Error *)
                                    let v422 : string = $"resultm.get / Result value was Error: {v421}"
                                    failwith<(string [])> v422
                                | US15_0(v420) -> (* Ok *)
                                    v420
                            let v426 : string = "$0.to_vec()"
                            let v427 : Vec<string> = Fable.Core.RustInterop.emitRustExpr v425 v426 
                            let v428 : string = "true; let _result : Vec<_> = v427.into_iter().map(|x| { //"
                            let v429 : bool = Fable.Core.RustInterop.emitRustExpr () v428 
                            let v430 : string = "x"
                            let v431 : string = Fable.Core.RustInterop.emitRustExpr () v430 
                            let v432 : string = "&*$0"
                            let v433 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v431 v432 
                            let v434 : string = "String::from($0)"
                            let v435 : std_string_String = Fable.Core.RustInterop.emitRustExpr v433 v434 
                            let v436 : string = "true; $0 }).collect::<Vec<_>>()"
                            let v437 : bool = Fable.Core.RustInterop.emitRustExpr v435 v436 
                            let v438 : string = "_result"
                            let v439 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v438 
                            let v440 : string = "clap::Command::get_matches_from($0, v439)"
                            let v441 : clap_ArgMatches = Fable.Core.RustInterop.emitRustExpr v417 v440 
                            let v442 : std_pin_Pin<Box<Dyn<std_future_Future<Result<string, string>>>>> = method10(v0, v441)
                            let v443 : string = "v442.await"
                            let v444 : Result<string, string> = Fable.Core.RustInterop.emitRustExpr () v443 
                            let v445 : string = "$0.unwrap()"
                            let v446 : string = Fable.Core.RustInterop.emitRustExpr v444 v445 
                            v446
                    let v450 : string = "command_result"
                    [|struct (v450, v449)|]
                else
                    let v452 : string = "fable_library_rust::String_::fromString($0)"
                    let v453 : string = Fable.Core.RustInterop.emitRustExpr v13 v452 
                    let v455 : bool = v453 = "dib"
                    if v455 then
                        let v456 : string = method65()
                        let v457 : string = "&*$0"
                        let v458 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v456 v457 
                        let v459 : string = "clap::ArgMatches::get_one(&$0, v458).cloned()"
                        let v460 : std_string_String option = Fable.Core.RustInterop.emitRustExpr v14 v459 
                        let v461 : (std_string_String -> string) = closure52()
                        let v462 : string option = v460 |> Option.map v461 
                        let v463 : string = "$0.unwrap()"
                        let v464 : string = Fable.Core.RustInterop.emitRustExpr v462 v463 
                        let v465 : string = method77()
                        let v466 : string = "&*$0"
                        let v467 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v465 v466 
                        let v468 : string = "clap::ArgMatches::get_one(&$0, v467).cloned()"
                        let v469 : uint8 option = Fable.Core.RustInterop.emitRustExpr v14 v468 
                        let v470 : uint8 = v469 |> Option.defaultValue 1uy 
                        let v471 : string = method78()
                        let v472 : string = "&*$0"
                        let v473 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v471 v472 
                        let v474 : string = "clap::ArgMatches::get_one(&$0, v473).cloned()"
                        let v475 : string option = Fable.Core.RustInterop.emitRustExpr v14 v474 
                        let v476 : uint8 = 1uy
                        let struct (v477 : int32, v478 : string) = method79(v475, v470, v464, v476)
                        let v479 : bool = v477 <> 0 
                        let struct (v576 : int32, v577 : string) =
                            if v479 then
                                struct (v477, v478)
                            else
                                let v480 : System.Threading.CancellationToken option = None
                                let v481 : (struct (string * string) []) = [||]
                                let v482 : (struct (bool * string * int32) -> Async<unit>) option = None
                                let v483 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = None
                                let v484 : string option = None
                                let v485 : string = $"jupyter nbconvert \"{v464}.ipynb\" --to html --HTMLExporter.theme=dark"
                                let v486 : bool = true
                                let struct (v487 : int32, v488 : string) = method28(v480, v485, v481, v482, v483, v486, v484)
                                let v489 : US0 = US0_1
                                let v490 : (unit -> string) = closure55()
                                let v491 : (unit -> string) = closure56(v488, v487)
                                method5(v489, v490, v491)
                                let v492 : bool = v487 <> 0 
                                if v492 then
                                    let v493 : string = $"repl_result: {v478}

jupyter_result: {v488}"
                                    struct (v487, v493)
                                else
                                    let v494 : string = "'"
                                    let v495 : string = "''"
                                    let v496 : string = v464.Replace (v494, v495)
                                    let v497 : System.Threading.CancellationToken option = None
                                    let v498 : (struct (string * string) []) = [||]
                                    let v499 : (struct (bool * string * int32) -> Async<unit>) option = None
                                    let v500 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = None
                                    let v501 : string option = None
                                    let v502 : string = $"pwsh -c \"$counter = 1; $path = '{v496}.html'; (Get-Content $path -Raw) -replace '(id=\\\"cell-id=)[a-fA-F0-9]{{8}}', {{ $_.Groups[1].Value + $counter++ }} | Set-Content $path\""
                                    let v503 : bool = true
                                    let struct (v504 : int32, v505 : string) = method28(v497, v502, v498, v499, v500, v503, v501)
                                    let v506 : US0 = US0_1
                                    let v507 : (unit -> string) = closure57()
                                    let v508 : (unit -> string) = closure58(v505, v504)
                                    method5(v506, v507, v508)
                                    let v509 : string = $"{v464}.html"
                                    let v510 : bool = true
                                    let mutable _v510 : string option = None 
                                    
#if FABLE_COMPILER || WASM || CONTRACT
                                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                    let v511 : bool = true
                                    let mutable _v511 : Vec<uint8> option = None 
                                    
#if FABLE_COMPILER || WASM || CONTRACT
                                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                    let v512 : string = "std::fs::read(&*$0).unwrap()"
                                    let v513 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v509 v512 
                                    v513 
                                    #endif
#if FABLE_COMPILER_RUST && WASM
                                    let v514 : Vec<uint8> = null |> unbox<Vec<uint8>>
                                    v514 
                                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                                    let v515 : Vec<uint8> = null |> unbox<Vec<uint8>>
                                    v515 
                                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                                    let v516 : Vec<uint8> = null |> unbox<Vec<uint8>>
                                    v516 
                                    #endif
#if FABLE_COMPILER_PYTHON
                                    let v517 : Vec<uint8> = null |> unbox<Vec<uint8>>
                                    v517 
                                    #endif
#else
                                    let v518 : (uint8 []) = v509 |> System.IO.File.ReadAllBytes
                                    let v519 : string = "$0.to_vec()"
                                    let v520 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v518 v519 
                                    v520 
                                    #endif
                                    |> fun x -> _v511 <- Some x
                                    let v521 : Vec<uint8> = match _v511 with Some x -> x | None -> failwith "base.run_target / _v511=None"
                                    let v522 : string = "std::string::String::from_utf8(v521)"
                                    let v523 : Result<std_string_String, std_string_FromUtf8Error> = Fable.Core.RustInterop.emitRustExpr () v522 
                                    let v524 : string = "$0.unwrap()"
                                    let v525 : std_string_String = Fable.Core.RustInterop.emitRustExpr v523 v524 
                                    let v526 : string = "fable_library_rust::String_::fromString($0)"
                                    let v527 : string = Fable.Core.RustInterop.emitRustExpr v525 v526 
                                    v527 
                                    #endif
#if FABLE_COMPILER_RUST && WASM
                                    let v528 : string = null |> unbox<string>
                                    v528 
                                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                                    let v529 : string = null |> unbox<string>
                                    v529 
                                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                                    let v530 : string = null |> unbox<string>
                                    v530 
                                    #endif
#if FABLE_COMPILER_PYTHON
                                    let v531 : string = null |> unbox<string>
                                    v531 
                                    #endif
#else
                                    let v532 : string = v509 |> System.IO.File.ReadAllText
                                    v532 
                                    #endif
                                    |> fun x -> _v510 <- Some x
                                    let v533 : string = match _v510 with Some x -> x | None -> failwith "base.run_target / _v510=None"
                                    let v534 : string = "\r\n"
                                    let v535 : string = "\n"
                                    let v536 : string = v533.Replace (v534, v535)
                                    let v537 : string = $"{v464}.html"
                                    let v538 : bool = true
                                    let mutable _v538 : unit option = None 
                                    
#if FABLE_COMPILER || WASM || CONTRACT
                                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                    let v539 : string = "std::fs::write(&*$0, &*$1).unwrap()"
                                    Fable.Core.RustInterop.emitRustExpr struct (v537, v536) v539 
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
                                    let v540 : string = method27(v536)
                                    System.IO.File.WriteAllText (v537, v540)
                                    () 
                                    #endif
                                    |> fun x -> _v538 <- Some x
                                    match _v538 with Some x -> x | None -> failwith "base.run_target / _v538=None"
                                    let v541 : string = $"{v464}.ipynb"
                                    let v542 : bool = true
                                    let mutable _v542 : string option = None 
                                    
#if FABLE_COMPILER || WASM || CONTRACT
                                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                    let v543 : bool = true
                                    let mutable _v543 : Vec<uint8> option = None 
                                    
#if FABLE_COMPILER || WASM || CONTRACT
                                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                    let v544 : string = "std::fs::read(&*$0).unwrap()"
                                    let v545 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v541 v544 
                                    v545 
                                    #endif
#if FABLE_COMPILER_RUST && WASM
                                    let v546 : Vec<uint8> = null |> unbox<Vec<uint8>>
                                    v546 
                                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                                    let v547 : Vec<uint8> = null |> unbox<Vec<uint8>>
                                    v547 
                                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                                    let v548 : Vec<uint8> = null |> unbox<Vec<uint8>>
                                    v548 
                                    #endif
#if FABLE_COMPILER_PYTHON
                                    let v549 : Vec<uint8> = null |> unbox<Vec<uint8>>
                                    v549 
                                    #endif
#else
                                    let v550 : (uint8 []) = v541 |> System.IO.File.ReadAllBytes
                                    let v551 : string = "$0.to_vec()"
                                    let v552 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v550 v551 
                                    v552 
                                    #endif
                                    |> fun x -> _v543 <- Some x
                                    let v553 : Vec<uint8> = match _v543 with Some x -> x | None -> failwith "base.run_target / _v543=None"
                                    let v554 : string = "std::string::String::from_utf8(v553)"
                                    let v555 : Result<std_string_String, std_string_FromUtf8Error> = Fable.Core.RustInterop.emitRustExpr () v554 
                                    let v556 : string = "$0.unwrap()"
                                    let v557 : std_string_String = Fable.Core.RustInterop.emitRustExpr v555 v556 
                                    let v558 : string = "fable_library_rust::String_::fromString($0)"
                                    let v559 : string = Fable.Core.RustInterop.emitRustExpr v557 v558 
                                    v559 
                                    #endif
#if FABLE_COMPILER_RUST && WASM
                                    let v560 : string = null |> unbox<string>
                                    v560 
                                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                                    let v561 : string = null |> unbox<string>
                                    v561 
                                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                                    let v562 : string = null |> unbox<string>
                                    v562 
                                    #endif
#if FABLE_COMPILER_PYTHON
                                    let v563 : string = null |> unbox<string>
                                    v563 
                                    #endif
#else
                                    let v564 : string = v541 |> System.IO.File.ReadAllText
                                    v564 
                                    #endif
                                    |> fun x -> _v542 <- Some x
                                    let v565 : string = match _v542 with Some x -> x | None -> failwith "base.run_target / _v542=None"
                                    let v566 : string = "\\r\\n"
                                    let v567 : string = "\\n"
                                    let v568 : string = v565.Replace (v566, v567)
                                    let v569 : string = $"{v464}.ipynb"
                                    let v570 : bool = true
                                    let mutable _v570 : unit option = None 
                                    
#if FABLE_COMPILER || WASM || CONTRACT
                                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                    let v571 : string = "std::fs::write(&*$0, &*$1).unwrap()"
                                    Fable.Core.RustInterop.emitRustExpr struct (v569, v568) v571 
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
                                    let v572 : string = method27(v568)
                                    System.IO.File.WriteAllText (v569, v572)
                                    () 
                                    #endif
                                    |> fun x -> _v570 <- Some x
                                    match _v570 with Some x -> x | None -> failwith "base.run_target / _v570=None"
                                    let v573 : string = $"repl_result: {v478}

jupyter_result: {v488}

pwsh_replace_html_result: {v505}"
                                    struct (v504, v573)
                        let v578 : US0 = US0_1
                        let v579 : (unit -> string) = closure59()
                        let v580 : (unit -> string) = closure60(v577, v576)
                        method5(v578, v579, v580)
                        let v581 : bool = v576 <> 0 
                        if v581 then
                            let v582 : (unit -> string) = closure6()
                            let v583 : string = $"spiral_builder.run / dib / exit_code: {v576} / result: {v577} / {v582 ()}"
                            failwith<unit> v583
                        let v584 : string = "stdio"
                        [|struct (v584, v577)|]
                    else
                        let v586 : string = "fable_library_rust::String_::fromString($0)"
                        let v587 : string = Fable.Core.RustInterop.emitRustExpr v13 v586 
                        let v589 : bool = v587 = "rust"
                        let struct (v2310 : US3, v2311 : US3, v2312 : US3) =
                            if v589 then
                                let v590 : string = method63()
                                let v591 : string = "&*$0"
                                let v592 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v590 v591 
                                let v593 : string = "clap::ArgMatches::get_one(&$0, v592).cloned()"
                                let v594 : std_string_String option = Fable.Core.RustInterop.emitRustExpr v14 v593 
                                let v595 : US5 option = None
                                let _v595 = ref v595 
                                match v594 with
                                | Some x -> (
                                (fun () ->
                                (fun () ->
                                let v596 : std_string_String = x
                                let v597 : US5 = US5_0(v596)
                                v597 
                                )
                                |> fun x -> x () |> Some
                                ) () ) | None -> None
                                |> fun x -> _v595.Value <- x
                                let v598 : US5 option = _v595.Value 
                                let v599 : US5 = US5_1
                                let v600 : US5 = v598 |> Option.defaultValue v599 
                                let v604 : std_string_String =
                                    match v600 with
                                    | US5_1 -> (* None *)
                                        failwith<std_string_String> "Option does not have a value."
                                    | US5_0(v601) -> (* Some *)
                                        v601
                                let v605 : string = "fable_library_rust::String_::fromString($0)"
                                let v606 : string = Fable.Core.RustInterop.emitRustExpr v604 v605 
                                let v607 : string = method13()
                                let v608 : string = "&*$0"
                                let v609 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v607 v608 
                                let v610 : string = "clap::ArgMatches::get_many(&$0, v609).map(|x| x.cloned().into_iter().collect())"
                                let v611 : Vec<std_string_String> option = Fable.Core.RustInterop.emitRustExpr v14 v610 
                                let v612 : US9 option = None
                                let _v612 = ref v612 
                                match v611 with
                                | Some x -> (
                                (fun () ->
                                (fun () ->
                                let v613 : Vec<std_string_String> = x
                                let v614 : US9 = US9_0(v613)
                                v614 
                                )
                                |> fun x -> x () |> Some
                                ) () ) | None -> None
                                |> fun x -> _v612.Value <- x
                                let v615 : US9 option = _v612.Value 
                                let v616 : US9 = US9_1
                                let v617 : US9 = v615 |> Option.defaultValue v616 
                                let v618 : (std_string_String []) = [||]
                                let v619 : string = "$0.to_vec()"
                                let v620 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr v618 v619 
                                let v623 : Vec<std_string_String> =
                                    match v617 with
                                    | US9_1 -> (* None *)
                                        v620
                                    | US9_0(v621) -> (* Some *)
                                        v621
                                let v625 : bool =
                                    match v0 with
                                    | US0_0 -> (* Verbose *)
                                        true
                                    | _ ->
                                        false
                                let v626 : bool = true
                                let mutable _v626 : string option = None 
                                
#if FABLE_COMPILER || WASM || CONTRACT
                                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                let v627 : bool = true
                                let mutable _v627 : Vec<uint8> option = None 
                                
#if FABLE_COMPILER || WASM || CONTRACT
                                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                let v628 : string = "std::fs::read(&*$0).unwrap()"
                                let v629 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v606 v628 
                                v629 
                                #endif
#if FABLE_COMPILER_RUST && WASM
                                let v630 : Vec<uint8> = null |> unbox<Vec<uint8>>
                                v630 
                                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                                let v631 : Vec<uint8> = null |> unbox<Vec<uint8>>
                                v631 
                                #endif
#if FABLE_COMPILER_TYPESCRIPT
                                let v632 : Vec<uint8> = null |> unbox<Vec<uint8>>
                                v632 
                                #endif
#if FABLE_COMPILER_PYTHON
                                let v633 : Vec<uint8> = null |> unbox<Vec<uint8>>
                                v633 
                                #endif
#else
                                let v634 : (uint8 []) = v606 |> System.IO.File.ReadAllBytes
                                let v635 : string = "$0.to_vec()"
                                let v636 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v634 v635 
                                v636 
                                #endif
                                |> fun x -> _v627 <- Some x
                                let v637 : Vec<uint8> = match _v627 with Some x -> x | None -> failwith "base.run_target / _v627=None"
                                let v638 : string = "std::string::String::from_utf8(v637)"
                                let v639 : Result<std_string_String, std_string_FromUtf8Error> = Fable.Core.RustInterop.emitRustExpr () v638 
                                let v640 : string = "$0.unwrap()"
                                let v641 : std_string_String = Fable.Core.RustInterop.emitRustExpr v639 v640 
                                let v642 : string = "fable_library_rust::String_::fromString($0)"
                                let v643 : string = Fable.Core.RustInterop.emitRustExpr v641 v642 
                                v643 
                                #endif
#if FABLE_COMPILER_RUST && WASM
                                let v644 : string = null |> unbox<string>
                                v644 
                                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                                let v645 : string = null |> unbox<string>
                                v645 
                                #endif
#if FABLE_COMPILER_TYPESCRIPT
                                let v646 : string = null |> unbox<string>
                                v646 
                                #endif
#if FABLE_COMPILER_PYTHON
                                let v647 : string = null |> unbox<string>
                                v647 
                                #endif
#else
                                let v648 : string = v606 |> System.IO.File.ReadAllText
                                v648 
                                #endif
                                |> fun x -> _v626 <- Some x
                                let v649 : string = match _v626 with Some x -> x | None -> failwith "base.run_target / _v626=None"
                                let v650 : string = "rs"
                                let v651 : string = $"%A{struct (v650, v649)}"
                                let v652 : string = method80(v651)
                                let v653 : string = __SOURCE_DIRECTORY__
                                let v654 : string = method14()
                                let v655 : string = "polyglot"
                                let v656 : string = ".paket"
                                let v657 : string = method15(v655, v656)
                                let v658 : US12 = method18(v657, v653)
                                let v667 : US3 =
                                    match v658 with
                                    | US12_1(v661) -> (* Error *)
                                        let v662 : US0 = US0_3
                                        let v663 : (unit -> string) = closure10()
                                        let v664 : (unit -> string) = closure11(v661)
                                        method5(v662, v663, v664)
                                        US3_1
                                    | US12_0(v659) -> (* Ok *)
                                        US3_0(v659)
                                let v682 : US3 =
                                    match v667 with
                                    | US3_1 -> (* None *)
                                        let v670 : string = method15(v655, v656)
                                        let v671 : US12 = method18(v670, v654)
                                        match v671 with
                                        | US12_1(v674) -> (* Error *)
                                            let v675 : US0 = US0_3
                                            let v676 : (unit -> string) = closure10()
                                            let v677 : (unit -> string) = closure11(v674)
                                            method5(v675, v676, v677)
                                            US3_1
                                        | US12_0(v672) -> (* Ok *)
                                            US3_0(v672)
                                    | US3_0(v668) -> (* Some *)
                                        US3_0(v668)
                                let v686 : string =
                                    match v682 with
                                    | US3_1 -> (* None *)
                                        failwith<string> "Option does not have a value."
                                    | US3_0(v683) -> (* Some *)
                                        v683
                                let v687 : string = method15(v686, v655)
                                let v688 : string = "target/spiral_builder"
                                let v689 : string = method15(v687, v688)
                                let v690 : string = "spiral_builder"
                                let v691 : string = method15(v689, v690)
                                let v692 : string = "packages"
                                let v693 : string = method15(v691, v692)
                                let v694 : string = method15(v693, v652)
                                let v695 : System.IDisposable = method82(v694)
                                let v696 : string = $"{v690}.fs"
                                let v697 : string = method15(v694, v696)
                                let v698 : string = method70(v697)
                                method24(v698, v649)
                                let v699 : string list = []
                                let v700 : string seq = seq { for i = 0 to v699.Length - 1 do yield v699.[i] }
                                let v701 : (string -> (string seq -> string)) = String.concat
                                let v702 : string = "\\n        "
                                let v703 : (string seq -> string) = v701 v702
                                let v704 : string = v703 v700
                                let v705 : string = "Fable.Core"
                                let v706 : string = $"<PackageReference Include=\"{v705}\" Version=\"*\" />"
                                let v707 : string list = []
                                let v708 : string list = v706 :: v707 
                                let v709 : string seq = seq { for i = 0 to v708.Length - 1 do yield v708.[i] }
                                let v710 : (string -> (string seq -> string)) = String.concat
                                let v711 : (string seq -> string) = v710 v702
                                let v712 : string = v711 v709
                                let v713 : string = $"{v690}.fsproj"
                                let v714 : string = method15(v694, v713)
                                let v715 : string = method70(v714)
                                let v716 : string = $"<Project Sdk=\"Microsoft.NET.Sdk\">"
                                let v717 : string = $"<PropertyGroup>"
                                let v718 : string = "\n"
                                let v719 : string = v716 + v718 
                                let v720 : string = v719 + v717 
                                let v721 : string = $"    <TargetFramework>net9.0</TargetFramework>"
                                let v722 : string = v720 + v718 
                                let v723 : string = v722 + v721 
                                let v724 : string = $"    <LangVersion>preview</LangVersion>"
                                let v725 : string = v723 + v718 
                                let v726 : string = v725 + v724 
                                let v727 : string = $"    <RollForward>Major</RollForward>"
                                let v728 : string = v726 + v718 
                                let v729 : string = v728 + v727 
                                let v730 : string = $"    <TargetLatestRuntimePatch>true</TargetLatestRuntimePatch>"
                                let v731 : string = v729 + v718 
                                let v732 : string = v731 + v730 
                                let v733 : string = $"    <PublishAot>false</PublishAot>"
                                let v734 : string = v732 + v718 
                                let v735 : string = v734 + v733 
                                let v736 : string = $"    <PublishTrimmed>false</PublishTrimmed>"
                                let v737 : string = v735 + v718 
                                let v738 : string = v737 + v736 
                                let v739 : string = $"    <PublishSingleFile>true</PublishSingleFile>"
                                let v740 : string = v738 + v718 
                                let v741 : string = v740 + v739 
                                let v742 : string = $"    <SelfContained>true</SelfContained>"
                                let v743 : string = v741 + v718 
                                let v744 : string = v743 + v742 
                                let v745 : string = $"    <Version>0.0.1-alpha.1</Version>"
                                let v746 : string = v744 + v718 
                                let v747 : string = v746 + v745 
                                let v748 : string = $"    <OutputType>Exe</OutputType>"
                                let v749 : string = v747 + v718 
                                let v750 : string = v749 + v748 
                                let v751 : string = $"</PropertyGroup>"
                                let v752 : string = v750 + v718 
                                let v753 : string = v752 + v751 
                                let v754 : string = $"<PropertyGroup Condition=\"$([MSBuild]::IsOSPlatform('FreeBSD'))\">"
                                let v755 : string = v753 + v718 
                                let v756 : string = v755 + v754 
                                let v757 : string = $"    <DefineConstants>_FREEBSD</DefineConstants>"
                                let v758 : string = v756 + v718 
                                let v759 : string = v758 + v757 
                                let v760 : string = $"</PropertyGroup>"
                                let v761 : string = v759 + v718 
                                let v762 : string = v761 + v760 
                                let v763 : string = $"<PropertyGroup Condition=\"$([MSBuild]::IsOSPlatform('Linux'))\">"
                                let v764 : string = v762 + v718 
                                let v765 : string = v764 + v763 
                                let v766 : string = $"    <DefineConstants>_LINUX</DefineConstants>"
                                let v767 : string = v765 + v718 
                                let v768 : string = v767 + v766 
                                let v769 : string = $"</PropertyGroup>"
                                let v770 : string = v768 + v718 
                                let v771 : string = v770 + v769 
                                let v772 : string = $"<PropertyGroup Condition=\"$([MSBuild]::IsOSPlatform('OSX'))\">"
                                let v773 : string = v771 + v718 
                                let v774 : string = v773 + v772 
                                let v775 : string = $"    <DefineConstants>_OSX</DefineConstants>"
                                let v776 : string = v774 + v718 
                                let v777 : string = v776 + v775 
                                let v778 : string = $"</PropertyGroup>"
                                let v779 : string = v777 + v718 
                                let v780 : string = v779 + v778 
                                let v781 : string = $"<PropertyGroup Condition=\"$([MSBuild]::IsOSPlatform('Windows'))\">"
                                let v782 : string = v780 + v718 
                                let v783 : string = v782 + v781 
                                let v784 : string = $"    <DefineConstants>_WINDOWS</DefineConstants>"
                                let v785 : string = v783 + v718 
                                let v786 : string = v785 + v784 
                                let v787 : string = $"</PropertyGroup>"
                                let v788 : string = v786 + v718 
                                let v789 : string = v788 + v787 
                                let v790 : string = $"<ItemGroup>"
                                let v791 : string = v789 + v718 
                                let v792 : string = v791 + v790 
                                let v793 : string = $"    {v704}"
                                let v794 : string = v792 + v718 
                                let v795 : string = v794 + v793 
                                let v796 : string = $"    <Compile Include=\"{v698}\" />"
                                let v797 : string = v795 + v718 
                                let v798 : string = v797 + v796 
                                let v799 : string = $"</ItemGroup>"
                                let v800 : string = v798 + v718 
                                let v801 : string = v800 + v799 
                                let v802 : string = $"<ItemGroup>"
                                let v803 : string = v801 + v718 
                                let v804 : string = v803 + v802 
                                let v805 : string = $"    {v712}"
                                let v806 : string = v804 + v718 
                                let v807 : string = v806 + v805 
                                let v808 : string = $"</ItemGroup>"
                                let v809 : string = v807 + v718 
                                let v810 : string = v809 + v808 
                                let v811 : string = $"</Project>"
                                let v812 : string = v810 + v718 
                                let v813 : string = v812 + v811 
                                method24(v715, v813)
                                let v814 : string = method23(v715)
                                let v815 : string = "Cargo.toml"
                                let v816 : string = method15(v814, v815)
                                let v817 : string = "../.."
                                let v818 : string = method15(v814, v817)
                                let v819 : string = method15(v818, v815)
                                let v820 : bool = method26(v816)
                                let v821 : bool = v820 = false
                                if v821 then
                                    let v822 : System.DateTime = System.DateTime.Now
                                    let v823 : (unit -> System.Guid) = System.Guid.NewGuid
                                    let v824 : System.Guid = v823 ()
                                    let v825 : System.Guid = method92(v824, v822)
                                    let v826 : (System.Guid -> string) = _.ToString()
                                    let v827 : string = v826 v825
                                    let v828 : string = $"[package]"
                                    let v829 : string = $"name = \"spiral_builder_{v827}\""
                                    let v830 : string = v828 + v718 
                                    let v831 : string = v830 + v829 
                                    let v832 : string = $"version = \"0.0.1\""
                                    let v833 : string = v831 + v718 
                                    let v834 : string = v833 + v832 
                                    let v835 : string = $"edition = \"2021\""
                                    let v836 : string = v834 + v718 
                                    let v837 : string = v836 + v835 
                                    let v838 : string = $""
                                    let v839 : string = v837 + v718 
                                    let v840 : string = v839 + v838 
                                    let v841 : string = $"[[bin]]"
                                    let v842 : string = v840 + v718 
                                    let v843 : string = v842 + v841 
                                    let v844 : string = $"name = \"spiral_builder_{v827}\""
                                    let v845 : string = v843 + v718 
                                    let v846 : string = v845 + v844 
                                    let v847 : string = $"path = \"spiral_builder.{v650}\""
                                    let v848 : string = v846 + v718 
                                    let v849 : string = v848 + v847 
                                    let v850 : bool = true
                                    let mutable _v850 : unit option = None 
                                    
#if FABLE_COMPILER || WASM || CONTRACT
                                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                    let v851 : string = "std::fs::write(&*$0, &*$1).unwrap()"
                                    Fable.Core.RustInterop.emitRustExpr struct (v816, v849) v851 
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
                                    let v852 : string = method27(v849)
                                    System.IO.File.WriteAllText (v816, v852)
                                    () 
                                    #endif
                                    |> fun x -> _v850 <- Some x
                                    match _v850 with Some x -> x | None -> failwith "base.run_target / _v850=None"
                                    ()
                                let v853 : bool = method26(v819)
                                let v854 : bool = v853 = false
                                if v854 then
                                    let v855 : System.DateTime = System.DateTime.Now
                                    let v856 : (unit -> System.Guid) = System.Guid.NewGuid
                                    let v857 : System.Guid = v856 ()
                                    let v858 : System.Guid = method92(v857, v855)
                                    let v859 : (System.Guid -> string) = _.ToString()
                                    let v860 : string = v859 v858
                                    let v861 : string = $"[package]"
                                    let v862 : string = $"name = \"spiral_builder_{v860}\""
                                    let v863 : string = v861 + v718 
                                    let v864 : string = v863 + v862 
                                    let v865 : string = $"version = \"0.0.1\""
                                    let v866 : string = v864 + v718 
                                    let v867 : string = v866 + v865 
                                    let v868 : string = $"edition = \"2021\""
                                    let v869 : string = v867 + v718 
                                    let v870 : string = v869 + v868 
                                    let v871 : string = $""
                                    let v872 : string = v870 + v718 
                                    let v873 : string = v872 + v871 
                                    let v874 : string = $"[[bin]]"
                                    let v875 : string = v873 + v718 
                                    let v876 : string = v875 + v874 
                                    let v877 : string = $"name = \"spiral_builder_{v860}\""
                                    let v878 : string = v876 + v718 
                                    let v879 : string = v878 + v877 
                                    let v880 : string = $"path = \"spiral_builder.{v650}\""
                                    let v881 : string = v879 + v718 
                                    let v882 : string = v881 + v880 
                                    let v883 : bool = true
                                    let mutable _v883 : unit option = None 
                                    
#if FABLE_COMPILER || WASM || CONTRACT
                                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                    let v884 : string = "std::fs::write(&*$0, &*$1).unwrap()"
                                    Fable.Core.RustInterop.emitRustExpr struct (v819, v882) v884 
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
                                    let v885 : string = method27(v882)
                                    System.IO.File.WriteAllText (v819, v885)
                                    () 
                                    #endif
                                    |> fun x -> _v883 <- Some x
                                    match _v883 with Some x -> x | None -> failwith "base.run_target / _v883=None"
                                    ()
                                let v886 : string = __SOURCE_DIRECTORY__
                                let v887 : string = method14()
                                let v888 : string = method15(v655, v656)
                                let v889 : US12 = method18(v888, v886)
                                let v898 : US3 =
                                    match v889 with
                                    | US12_1(v892) -> (* Error *)
                                        let v893 : US0 = US0_3
                                        let v894 : (unit -> string) = closure10()
                                        let v895 : (unit -> string) = closure11(v892)
                                        method5(v893, v894, v895)
                                        US3_1
                                    | US12_0(v890) -> (* Ok *)
                                        US3_0(v890)
                                let v913 : US3 =
                                    match v898 with
                                    | US3_1 -> (* None *)
                                        let v901 : string = method15(v655, v656)
                                        let v902 : US12 = method18(v901, v887)
                                        match v902 with
                                        | US12_1(v905) -> (* Error *)
                                            let v906 : US0 = US0_3
                                            let v907 : (unit -> string) = closure10()
                                            let v908 : (unit -> string) = closure11(v905)
                                            method5(v906, v907, v908)
                                            US3_1
                                        | US12_0(v903) -> (* Ok *)
                                            US3_0(v903)
                                    | US3_0(v899) -> (* Some *)
                                        US3_0(v899)
                                let v917 : string =
                                    match v913 with
                                    | US3_1 -> (* None *)
                                        failwith<string> "Option does not have a value."
                                    | US3_0(v914) -> (* Some *)
                                        v914
                                let v918 : string = method15(v917, v655)
                                let v919 : string = method14()
                                let v920 : (unit -> string) = v919.ToLower
                                let v921 : string = v920 ()
                                let v922 : (unit -> string) = v918.ToLower
                                let v923 : string = v922 ()
                                let v924 : bool = v921.StartsWith v923 
                                let v927 : US12 =
                                    if v924 then
                                        US12_1(v923)
                                    else
                                        US12_0(v923)
                                let v933 : Result<string, string> =
                                    match v927 with
                                    | US12_1(v930) -> (* Error *)
                                        let v931 : Result<string, string> = Error v930 
                                        v931
                                    | US12_0(v928) -> (* Ok *)
                                        let v929 : Result<string, string> = Ok v928 
                                        v929
                                let v934 : string = "true; let _result = $0.unwrap_or_else(|x| { //"
                                let v935 : bool = Fable.Core.RustInterop.emitRustExpr v933 v934 
                                let v936 : string = "x"
                                let v937 : string = Fable.Core.RustInterop.emitRustExpr () v936 
                                let v938 : string = "true; $0 })"
                                let v939 : bool = Fable.Core.RustInterop.emitRustExpr v937 v938 
                                let v940 : string = "_result"
                                let v941 : string = Fable.Core.RustInterop.emitRustExpr () v940 
                                let v942 : string = "lib/rust/fable/fable_modules/fable-library-rust"
                                let v943 : string = method15(v941, v942)
                                let v944 : string = "fable_modules/fable-library-rust"
                                let v945 : string = method15(v814, v944)
                                method98(v943, v945)
                                let struct (v946 : int32, v947 : string) = method99(v814, v650, v715, v927)
                                let v948 : bool = v946 <> 0 
                                if v948 then
                                    let v949 : US0 = US0_4
                                    let v950 : (unit -> string) = closure76()
                                    let v951 : (unit -> string) = closure77(v947, v946)
                                    method5(v949, v950, v951)
                                    let v952 : US3 = US3_1
                                    let v953 : US3 = US3_0(v650)
                                    let v954 : US3 = US3_0(v947)
                                    struct (v952, v953, v954)
                                else
                                    let v955 : string = "true; let _result : Vec<_> = v623.into_iter().map(|x| { //"
                                    let v956 : bool = Fable.Core.RustInterop.emitRustExpr () v955 
                                    let v957 : string = "x"
                                    let v958 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v957 
                                    let v959 : string = "fable_library_rust::String_::fromString($0)"
                                    let v960 : string = Fable.Core.RustInterop.emitRustExpr v958 v959 
                                    let v961 : string = "="
                                    let v962 : bool = v960.Contains v961 
                                    let v971 : string =
                                        if v962 then
                                            v960
                                        else
                                            let v963 : string = "]"
                                            let v964 : bool = v960.EndsWith v963 
                                            if v964 then
                                                let v965 : string = $"={{version='*',features=["
                                                let v966 : string = "["
                                                let v967 : string = v960.Replace (v966, v965)
                                                let v968 : string = $"{v967}}}"
                                                v968
                                            else
                                                let v969 : string = $"{v960}='*'"
                                                v969
                                    let v972 : string = "true; $0 }).collect::<Vec<_>>()"
                                    let v973 : bool = Fable.Core.RustInterop.emitRustExpr v971 v972 
                                    let v974 : string = "_result"
                                    let v975 : Vec<string> = Fable.Core.RustInterop.emitRustExpr () v974 
                                    let v976 : string = "fable_library_rust::NativeArray_::array_from($0)"
                                    let v977 : (string []) = Fable.Core.RustInterop.emitRustExpr v975 v976 
                                    let v978 : string seq = seq { for i = 0 to v977.Length - 1 do yield v977.[i] }
                                    let v979 : (string -> (string seq -> string)) = String.concat
                                    let v980 : (string seq -> string) = v979 v718
                                    let v981 : string = v980 v978
                                    let v982 : string = $"[package]"
                                    let v983 : string = $"name = \"spiral_builder_{v652}\""
                                    let v984 : string = v982 + v718 
                                    let v985 : string = v984 + v983 
                                    let v986 : string = $"version = \"0.0.1\""
                                    let v987 : string = v985 + v718 
                                    let v988 : string = v987 + v986 
                                    let v989 : string = $"edition = \"2021\""
                                    let v990 : string = v988 + v718 
                                    let v991 : string = v990 + v989 
                                    let v992 : string = $""
                                    let v993 : string = v991 + v718 
                                    let v994 : string = v993 + v992 
                                    let v995 : string = $"[dependencies]"
                                    let v996 : string = v994 + v718 
                                    let v997 : string = v996 + v995 
                                    let v998 : string = $"fable_library_rust = {{ workspace = true }}"
                                    let v999 : string = v997 + v718 
                                    let v1000 : string = v999 + v998 
                                    let v1001 : string = $"inline_colorization = {{ workspace = true }}"
                                    let v1002 : string = v1000 + v718 
                                    let v1003 : string = v1002 + v1001 
                                    let v1004 : string = $"{v981}"
                                    let v1005 : string = v1003 + v718 
                                    let v1006 : string = v1005 + v1004 
                                    let v1007 : string = $""
                                    let v1008 : string = v1006 + v718 
                                    let v1009 : string = v1008 + v1007 
                                    let v1010 : string = $"[[bin]]"
                                    let v1011 : string = v1009 + v718 
                                    let v1012 : string = v1011 + v1010 
                                    let v1013 : string = $"name = \"spiral_builder_{v652}\""
                                    let v1014 : string = v1012 + v718 
                                    let v1015 : string = v1014 + v1013 
                                    let v1016 : string = $"path = \"spiral_builder.rs\" "
                                    let v1017 : string = v1015 + v718 
                                    let v1018 : string = v1017 + v1016 
                                    let v1019 : string = method70(v941)
                                    let v1020 : string = $"[workspace]"
                                    let v1021 : string = $"resolver = \"2\""
                                    let v1022 : string = v1020 + v718 
                                    let v1023 : string = v1022 + v1021 
                                    let v1024 : string = $"members = [\"packages/*\"]"
                                    let v1025 : string = v1023 + v718 
                                    let v1026 : string = v1025 + v1024 
                                    let v1027 : string = $""
                                    let v1028 : string = v1026 + v718 
                                    let v1029 : string = v1028 + v1027 
                                    let v1030 : string = $"[workspace.dependencies.fable_library_rust]"
                                    let v1031 : string = v1029 + v718 
                                    let v1032 : string = v1031 + v1030 
                                    let v1033 : string = $"path = \"{v1019}/lib/rust/fable/fable_modules/fable-library-rust\""
                                    let v1034 : string = v1032 + v718 
                                    let v1035 : string = v1034 + v1033 
                                    let v1036 : string = $"default-features = false"
                                    let v1037 : string = v1035 + v718 
                                    let v1038 : string = v1037 + v1036 
                                    let v1039 : string = $"features = [\"static_do_bindings\", \"datetime\", \"guid\", \"threaded\"]"
                                    let v1040 : string = v1038 + v718 
                                    let v1041 : string = v1040 + v1039 
                                    let v1042 : string = $""
                                    let v1043 : string = v1041 + v718 
                                    let v1044 : string = v1043 + v1042 
                                    let v1045 : string = $"[workspace.dependencies]"
                                    let v1046 : string = v1044 + v718 
                                    let v1047 : string = v1046 + v1045 
                                    let v1048 : string = $"inline_colorization = \"~0.1\""
                                    let v1049 : string = v1047 + v718 
                                    let v1050 : string = v1049 + v1048 
                                    method24(v816, v1018)
                                    method24(v819, v1050)
                                    let v1051 : string = "src/Range.rs"
                                    let v1052 : string = method15(v945, v1051)
                                    let v1053 : bool = method26(v1052)
                                    if v1053 then
                                        let v1054 : bool = true
                                        let mutable _v1054 : string option = None 
                                        
#if FABLE_COMPILER || WASM || CONTRACT
                                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                        let v1055 : bool = true
                                        let mutable _v1055 : Vec<uint8> option = None 
                                        
#if FABLE_COMPILER || WASM || CONTRACT
                                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                        let v1056 : string = "std::fs::read(&*$0).unwrap()"
                                        let v1057 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v1052 v1056 
                                        v1057 
                                        #endif
#if FABLE_COMPILER_RUST && WASM
                                        let v1058 : Vec<uint8> = null |> unbox<Vec<uint8>>
                                        v1058 
                                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                                        let v1059 : Vec<uint8> = null |> unbox<Vec<uint8>>
                                        v1059 
                                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                                        let v1060 : Vec<uint8> = null |> unbox<Vec<uint8>>
                                        v1060 
                                        #endif
#if FABLE_COMPILER_PYTHON
                                        let v1061 : Vec<uint8> = null |> unbox<Vec<uint8>>
                                        v1061 
                                        #endif
#else
                                        let v1062 : (uint8 []) = v1052 |> System.IO.File.ReadAllBytes
                                        let v1063 : string = "$0.to_vec()"
                                        let v1064 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v1062 v1063 
                                        v1064 
                                        #endif
                                        |> fun x -> _v1055 <- Some x
                                        let v1065 : Vec<uint8> = match _v1055 with Some x -> x | None -> failwith "base.run_target / _v1055=None"
                                        let v1066 : string = "std::string::String::from_utf8(v1065)"
                                        let v1067 : Result<std_string_String, std_string_FromUtf8Error> = Fable.Core.RustInterop.emitRustExpr () v1066 
                                        let v1068 : string = "$0.unwrap()"
                                        let v1069 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1067 v1068 
                                        let v1070 : string = "fable_library_rust::String_::fromString($0)"
                                        let v1071 : string = Fable.Core.RustInterop.emitRustExpr v1069 v1070 
                                        v1071 
                                        #endif
#if FABLE_COMPILER_RUST && WASM
                                        let v1072 : string = null |> unbox<string>
                                        v1072 
                                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                                        let v1073 : string = null |> unbox<string>
                                        v1073 
                                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                                        let v1074 : string = null |> unbox<string>
                                        v1074 
                                        #endif
#if FABLE_COMPILER_PYTHON
                                        let v1075 : string = null |> unbox<string>
                                        v1075 
                                        #endif
#else
                                        let v1076 : string = v1052 |> System.IO.File.ReadAllText
                                        v1076 
                                        #endif
                                        |> fun x -> _v1054 <- Some x
                                        let v1077 : string = match _v1054 with Some x -> x | None -> failwith "base.run_target / _v1054=None"
                                        let v1078 : string = "use crate::String_::fromCharCode;"
                                        let v1079 : string = "use crate::String_::fromChar;"
                                        let v1080 : string = v1077.Replace (v1078, v1079)
                                        let v1081 : string = "fromCharCode(c)"
                                        let v1082 : string = "std::char::from_u32(c).unwrap()"
                                        let v1083 : string = v1080.Replace (v1081, v1082)
                                        method24(v1052, v1083)
                                    let v1084 : uint8 = 1uy
                                    let struct (v1085 : int32, v1086 : string) = method101(v816, v927, v1084)
                                    let v1087 : bool = v1085 <> 0 
                                    if v1087 then
                                        let v1088 : US0 = US0_4
                                        let v1089 : (unit -> string) = closure78()
                                        let v1090 : (unit -> string) = closure79(v1086, v1085)
                                        method5(v1088, v1089, v1090)
                                    let v1091 : string = $"{v690}.{v650}"
                                    let v1092 : string = method15(v814, v1091)
                                    let v1093 : bool = true
                                    let mutable _v1093 : string option = None 
                                    
#if FABLE_COMPILER || WASM || CONTRACT
                                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                    let v1094 : bool = true
                                    let mutable _v1094 : Vec<uint8> option = None 
                                    
#if FABLE_COMPILER || WASM || CONTRACT
                                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                    let v1095 : string = "std::fs::read(&*$0).unwrap()"
                                    let v1096 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v1092 v1095 
                                    v1096 
                                    #endif
#if FABLE_COMPILER_RUST && WASM
                                    let v1097 : Vec<uint8> = null |> unbox<Vec<uint8>>
                                    v1097 
                                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                                    let v1098 : Vec<uint8> = null |> unbox<Vec<uint8>>
                                    v1098 
                                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                                    let v1099 : Vec<uint8> = null |> unbox<Vec<uint8>>
                                    v1099 
                                    #endif
#if FABLE_COMPILER_PYTHON
                                    let v1100 : Vec<uint8> = null |> unbox<Vec<uint8>>
                                    v1100 
                                    #endif
#else
                                    let v1101 : (uint8 []) = v1092 |> System.IO.File.ReadAllBytes
                                    let v1102 : string = "$0.to_vec()"
                                    let v1103 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v1101 v1102 
                                    v1103 
                                    #endif
                                    |> fun x -> _v1094 <- Some x
                                    let v1104 : Vec<uint8> = match _v1094 with Some x -> x | None -> failwith "base.run_target / _v1094=None"
                                    let v1105 : string = "std::string::String::from_utf8(v1104)"
                                    let v1106 : Result<std_string_String, std_string_FromUtf8Error> = Fable.Core.RustInterop.emitRustExpr () v1105 
                                    let v1107 : string = "$0.unwrap()"
                                    let v1108 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1106 v1107 
                                    let v1109 : string = "fable_library_rust::String_::fromString($0)"
                                    let v1110 : string = Fable.Core.RustInterop.emitRustExpr v1108 v1109 
                                    v1110 
                                    #endif
#if FABLE_COMPILER_RUST && WASM
                                    let v1111 : string = null |> unbox<string>
                                    v1111 
                                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                                    let v1112 : string = null |> unbox<string>
                                    v1112 
                                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                                    let v1113 : string = null |> unbox<string>
                                    v1113 
                                    #endif
#if FABLE_COMPILER_PYTHON
                                    let v1114 : string = null |> unbox<string>
                                    v1114 
                                    #endif
#else
                                    let v1115 : string = v1092 |> System.IO.File.ReadAllText
                                    v1115 
                                    #endif
                                    |> fun x -> _v1093 <- Some x
                                    let v1116 : string = match _v1093 with Some x -> x | None -> failwith "base.run_target / _v1093=None"
                                    let v1117 : string = "\"{\".into()"
                                    let v1118 : string = Fable.Core.RustInterop.emitRustExpr () v1117 
                                    let v1119 : string = "pub fn main() -> Result<(), String> "
                                    let v1120 : string = v1119 + v1118 
                                    let v1121 : string = $"{v1120} Ok(()) }}"
                                    let v1122 : bool = v1116.Contains v1120 
                                    let v1198 : string =
                                        if v1122 then
                                            v1116
                                        else
                                            let v1123 : string = "\";\".into()"
                                            let v1124 : string = Fable.Core.RustInterop.emitRustExpr () v1123 
                                            let v1125 : string = "),)"
                                            let v1126 : string = v1125 + v1124 
                                            let v1127 : string = "));"
                                            let v1128 : string = v1116.Replace (v1126, v1127)
                                            let v1129 : string = "\";\".into()"
                                            let v1130 : string = Fable.Core.RustInterop.emitRustExpr () v1129 
                                            let v1131 : string = "},)"
                                            let v1132 : string = v1131 + v1130 
                                            let v1133 : string = "});"
                                            let v1134 : string = v1128.Replace (v1132, v1133)
                                            let v1135 : string = method103()
                                            let v1136 : bool = true
                                            let mutable _v1136 : string option = None 
                                            
#if FABLE_COMPILER || WASM || CONTRACT
                                            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                            let v1137 : string = method72(v1134)
                                            let v1138 : string = $"regex::Regex::new(&$0)"
                                            let v1139 : string = "\\s\\sdefaultOf\\(\\);"
                                            let v1140 : Result<regex_Regex, regex_Error> = Fable.Core.RustInterop.emitRustExpr v1139 v1138 
                                            let v1141 : string = "$0.unwrap()"
                                            let v1142 : regex_Regex = Fable.Core.RustInterop.emitRustExpr v1140 v1141 
                                            let v1143 : string = $"$0.replace_all(&$1, &*$2)"
                                            let v1144 : std_borrow_Cow<Str> = Fable.Core.RustInterop.emitRustExpr struct (v1142, v1137, v1135) v1143 
                                            let v1145 : string = "String::from($0)"
                                            let v1146 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1144 v1145 
                                            let v1147 : string = "fable_library_rust::String_::fromString($0)"
                                            let v1148 : string = Fable.Core.RustInterop.emitRustExpr v1146 v1147 
                                            v1148 
                                            #endif
#if FABLE_COMPILER_RUST && WASM
                                            let v1149 : string = null |> unbox<string>
                                            v1149 
                                            #endif
#if FABLE_COMPILER_RUST && CONTRACT
                                            let v1150 : string = null |> unbox<string>
                                            v1150 
                                            #endif
#if FABLE_COMPILER_TYPESCRIPT
                                            let v1151 : string = null |> unbox<string>
                                            v1151 
                                            #endif
#if FABLE_COMPILER_PYTHON
                                            let v1152 : string = null |> unbox<string>
                                            v1152 
                                            #endif
#else
                                            let v1153 : string = method104()
                                            let v1154 : string = System.Text.RegularExpressions.Regex.Replace (v1134, v1153, v1135)
                                            v1154 
                                            #endif
                                            |> fun x -> _v1136 <- Some x
                                            let v1155 : string = match _v1136 with Some x -> x | None -> failwith "base.run_target / _v1136=None"
                                            let v1156 : string = "\",\".into()"
                                            let v1157 : string = Fable.Core.RustInterop.emitRustExpr () v1156 
                                            let v1158 : string = "defaultOf()"
                                            let v1159 : string = v1158 + v1157 
                                            let v1160 : string = "defaultOf::<std::sync::Arc<dyn IDisposable>>(),"
                                            let v1161 : string = v1155.Replace (v1159, v1160)
                                            let v1162 : string = "\"_.\".into()"
                                            let v1163 : string = Fable.Core.RustInterop.emitRustExpr () v1162 
                                            let v1164 : string = "_self"
                                            let v1165 : string = v1164 + v1163 
                                            let v1166 : string = "self."
                                            let v1167 : string = v1161.Replace (v1165, v1166)
                                            let v1168 : string = "\"h\".into()"
                                            let v1169 : string = Fable.Core.RustInterop.emitRustExpr () v1168 
                                            let v1170 : string = "get_or_insert_wit"
                                            let v1171 : string = v1170 + v1169 
                                            let v1172 : string = "get_or_init"
                                            let v1173 : string = v1167.Replace (v1171, v1172)
                                            let v1174 : string = "\";\".into()"
                                            let v1175 : string = Fable.Core.RustInterop.emitRustExpr () v1174 
                                            let v1176 : string = "use fable_library_rust::System::Collections::Concurrent::ConcurrentStack_1"
                                            let v1177 : string = v1176 + v1175 
                                            let v1178 : string = "type ConcurrentStack_1<T> = T;"
                                            let v1179 : string = v1173.Replace (v1177, v1178)
                                            let v1180 : string = "\";\".into()"
                                            let v1181 : string = Fable.Core.RustInterop.emitRustExpr () v1180 
                                            let v1182 : string = "use fable_library_rust::System::Threading::CancellationToken"
                                            let v1183 : string = v1182 + v1181 
                                            let v1184 : string = "type CancellationToken = ();"
                                            let v1185 : string = v1179.Replace (v1183, v1184)
                                            let v1186 : string = "\";\".into()"
                                            let v1187 : string = Fable.Core.RustInterop.emitRustExpr () v1186 
                                            let v1188 : string = "use fable_library_rust::System::TimeZoneInfo"
                                            let v1189 : string = v1188 + v1187 
                                            let v1190 : string = "type TimeZoneInfo = i64;"
                                            let v1191 : string = v1185.Replace (v1189, v1190)
                                            let v1192 : string = "\";\".into()"
                                            let v1193 : string = Fable.Core.RustInterop.emitRustExpr () v1192 
                                            let v1194 : string = "use fable_library_rust::System::Threading::Tasks::TaskCanceledException"
                                            let v1195 : string = v1194 + v1193 
                                            let v1196 : string = "type TaskCanceledException = ();"
                                            let v1197 : string = v1191.Replace (v1195, v1196)
                                            v1197
                                    let v1199 : bool = v1122 = false
                                    if v1199 then
                                        let v1200 : string = $"{v1198}\n\n{v1121}\n"
                                        method24(v1092, v1200)
                                    let v1201 : string = $"cargo +nightly run --manifest-path \"{v816}\""
                                    let v1202 : string = "TRACE_LEVEL"
                                    let v1203 : string = "Verbose"
                                    let v1204 : string = "RUSTC_WRAPPER"
                                    let v1205 : string = "sccache"
                                    let v1206 : string = "RUSTFLAGS"
                                    let v1207 : string = "-C prefer-dynamic"
                                    let v1208 : (struct (string * string) []) = [|struct (v1202, v1203); struct (v1204, v1205); struct (v1206, v1207)|]
                                    let v1209 : System.Threading.CancellationToken option = None
                                    let v1210 : (struct (string * string) []) = [||]
                                    let v1211 : (struct (bool * string * int32) -> Async<unit>) option = None
                                    let v1212 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = None
                                    let v1213 : string option = None
                                    let v1219 : Result<string, string> =
                                        match v927 with
                                        | US12_1(v1216) -> (* Error *)
                                            let v1217 : Result<string, string> = Error v1216 
                                            v1217
                                        | US12_0(v1214) -> (* Ok *)
                                            let v1215 : Result<string, string> = Ok v1214 
                                            v1215
                                    let v1220 : string = "v1219.ok()"
                                    let v1221 : string option = Fable.Core.RustInterop.emitRustExpr () v1220 
                                    let v1222 : bool = true
                                    let struct (v1223 : int32, v1224 : string) = method28(v1209, v1201, v1208, v1211, v1212, v1222, v1221)
                                    let v1225 : string = ""
                                    let v1226 : string = $"target/debug/spiral_builder_{v652}{v1225}"
                                    let v1227 : string = method15(v818, v1226)
                                    let v1228 : string = ".pdb"
                                    let v1229 : string = $"target/debug/spiral_builder_{v652}{v1228}"
                                    let v1230 : string = method15(v818, v1229)
                                    let v1231 : string = ".exe"
                                    let v1232 : string = $"target/debug/spiral_builder_{v652}{v1231}"
                                    let v1233 : string = method15(v818, v1232)
                                    let v1234 : string = ".d"
                                    let v1235 : string = $"target/debug/spiral_builder_{v652}{v1234}"
                                    let v1236 : string = method15(v818, v1235)
                                    let v1237 : bool = method26(v1227)
                                    let v1238 : bool = method26(v1230)
                                    let v1239 : bool = method26(v1233)
                                    let v1240 : bool = method26(v1236)
                                    let v1241 : US0 = US0_0
                                    let v1242 : (unit -> string) = closure80()
                                    let v1243 : (unit -> string) = closure81(v1092, v1236, v1240, v1233, v1239, v1230, v1238, v1227, v1237)
                                    method5(v1241, v1242, v1243)
                                    let v1247 : UH3 =
                                        if v1237 then
                                            let v1244 : UH3 = UH3_0
                                            UH3_1(v1227, v1237, v1244)
                                        else
                                            UH3_0
                                    let v1249 : UH3 =
                                        if v1238 then
                                            UH3_1(v1230, v1238, v1247)
                                        else
                                            v1247
                                    let v1251 : UH3 =
                                        if v1239 then
                                            UH3_1(v1233, v1239, v1249)
                                        else
                                            v1249
                                    let v1253 : UH3 =
                                        if v1240 then
                                            UH3_1(v1236, v1240, v1251)
                                        else
                                            v1251
                                    method105(v1253)
                                    let v1254 : int32 = v1208.Length
                                    let v1255 : (string []) = Array.zeroCreate<string> (v1254)
                                    let v1256 : Mut4 = {l0 = 0} : Mut4
                                    while method32(v1254, v1256) do
                                        let v1258 : int32 = v1256.l0
                                        let struct (v1259 : string, v1260 : string) = v1208.[int v1258]
                                        let v1261 : string = $"$env:{v1259}=''{v1260}''"
                                        v1255.[int v1258] <- v1261
                                        let v1262 : int32 = v1258 + 1
                                        v1256.l0 <- v1262
                                        ()
                                    let v1263 : ((string []) -> string seq) = Seq.ofArray
                                    let v1264 : string seq = v1263 v1255
                                    let v1265 : (string -> (string seq -> string)) = String.concat
                                    let v1266 : string = ";"
                                    let v1267 : (string seq -> string) = v1265 v1266
                                    let v1268 : string = v1267 v1264
                                    let v1269 : string = $"pwsh -c '{v1268}; {v1201}'"
                                    let v1270 : bool = v1223 = 0
                                    if v1270 then
                                        let v1271 : (unit -> string) = closure82(v1224)
                                        let v1272 : (string -> US3) = closure45()
                                        let v1273 : (exn -> US3) = closure84(v1092, v1224, v1269)
                                        let v1274 : US3 = try v1271 () |> v1272 with ex -> v1273 ex 
                                        let v1279 : string option =
                                            match v1274 with
                                            | US3_1 -> (* None *)
                                                let v1277 : string option = None
                                                v1277
                                            | US3_0(v1275) -> (* Some *)
                                                let v1276 : string option = Some v1275 
                                                v1276
                                        let v1280 : string = "$0.unwrap()"
                                        let v1281 : string = Fable.Core.RustInterop.emitRustExpr v1279 v1280 
                                        let v1282 : US3 = US3_0(v1198)
                                        let v1283 : US3 = US3_0(v650)
                                        let v1284 : US3 = US3_0(v1281)
                                        struct (v1282, v1283, v1284)
                                    else
                                        let v1285 : US0 = US0_4
                                        let v1286 : (unit -> string) = closure87()
                                        let v1287 : (unit -> string) = closure88(v1092, v1224, v1223, v1269)
                                        method5(v1285, v1286, v1287)
                                        let v1288 : US3 = US3_1
                                        let v1289 : US3 = US3_0(v650)
                                        let v1290 : US3 = US3_1
                                        struct (v1288, v1289, v1290)
                            else
                                let v1297 : string = "fable_library_rust::String_::fromString($0)"
                                let v1298 : string = Fable.Core.RustInterop.emitRustExpr v13 v1297 
                                let v1300 : bool = v1298 = "typescript"
                                if v1300 then
                                    let v1301 : string = method63()
                                    let v1302 : string = "&*$0"
                                    let v1303 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1301 v1302 
                                    let v1304 : string = "clap::ArgMatches::get_one(&$0, v1303).cloned()"
                                    let v1305 : std_string_String option = Fable.Core.RustInterop.emitRustExpr v14 v1304 
                                    let v1306 : US5 option = None
                                    let _v1306 = ref v1306 
                                    match v1305 with
                                    | Some x -> (
                                    (fun () ->
                                    (fun () ->
                                    let v1307 : std_string_String = x
                                    let v1308 : US5 = US5_0(v1307)
                                    v1308 
                                    )
                                    |> fun x -> x () |> Some
                                    ) () ) | None -> None
                                    |> fun x -> _v1306.Value <- x
                                    let v1309 : US5 option = _v1306.Value 
                                    let v1310 : US5 = US5_1
                                    let v1311 : US5 = v1309 |> Option.defaultValue v1310 
                                    let v1315 : std_string_String =
                                        match v1311 with
                                        | US5_1 -> (* None *)
                                            failwith<std_string_String> "Option does not have a value."
                                        | US5_0(v1312) -> (* Some *)
                                            v1312
                                    let v1316 : string = "fable_library_rust::String_::fromString($0)"
                                    let v1317 : string = Fable.Core.RustInterop.emitRustExpr v1315 v1316 
                                    let v1318 : string = method13()
                                    let v1319 : string = "&*$0"
                                    let v1320 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1318 v1319 
                                    let v1321 : string = "clap::ArgMatches::get_many(&$0, v1320).map(|x| x.cloned().into_iter().collect())"
                                    let v1322 : Vec<std_string_String> option = Fable.Core.RustInterop.emitRustExpr v14 v1321 
                                    let v1323 : US9 option = None
                                    let _v1323 = ref v1323 
                                    match v1322 with
                                    | Some x -> (
                                    (fun () ->
                                    (fun () ->
                                    let v1324 : Vec<std_string_String> = x
                                    let v1325 : US9 = US9_0(v1324)
                                    v1325 
                                    )
                                    |> fun x -> x () |> Some
                                    ) () ) | None -> None
                                    |> fun x -> _v1323.Value <- x
                                    let v1326 : US9 option = _v1323.Value 
                                    let v1327 : US9 = US9_1
                                    let v1328 : US9 = v1326 |> Option.defaultValue v1327 
                                    let v1329 : (std_string_String []) = [||]
                                    let v1330 : string = "$0.to_vec()"
                                    let v1331 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr v1329 v1330 
                                    let v1334 : Vec<std_string_String> =
                                        match v1328 with
                                        | US9_1 -> (* None *)
                                            v1331
                                        | US9_0(v1332) -> (* Some *)
                                            v1332
                                    let v1336 : bool =
                                        match v0 with
                                        | US0_0 -> (* Verbose *)
                                            true
                                        | _ ->
                                            false
                                    let v1337 : bool = true
                                    let mutable _v1337 : string option = None 
                                    
#if FABLE_COMPILER || WASM || CONTRACT
                                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                    let v1338 : bool = true
                                    let mutable _v1338 : Vec<uint8> option = None 
                                    
#if FABLE_COMPILER || WASM || CONTRACT
                                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                    let v1339 : string = "std::fs::read(&*$0).unwrap()"
                                    let v1340 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v1317 v1339 
                                    v1340 
                                    #endif
#if FABLE_COMPILER_RUST && WASM
                                    let v1341 : Vec<uint8> = null |> unbox<Vec<uint8>>
                                    v1341 
                                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                                    let v1342 : Vec<uint8> = null |> unbox<Vec<uint8>>
                                    v1342 
                                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                                    let v1343 : Vec<uint8> = null |> unbox<Vec<uint8>>
                                    v1343 
                                    #endif
#if FABLE_COMPILER_PYTHON
                                    let v1344 : Vec<uint8> = null |> unbox<Vec<uint8>>
                                    v1344 
                                    #endif
#else
                                    let v1345 : (uint8 []) = v1317 |> System.IO.File.ReadAllBytes
                                    let v1346 : string = "$0.to_vec()"
                                    let v1347 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v1345 v1346 
                                    v1347 
                                    #endif
                                    |> fun x -> _v1338 <- Some x
                                    let v1348 : Vec<uint8> = match _v1338 with Some x -> x | None -> failwith "base.run_target / _v1338=None"
                                    let v1349 : string = "std::string::String::from_utf8(v1348)"
                                    let v1350 : Result<std_string_String, std_string_FromUtf8Error> = Fable.Core.RustInterop.emitRustExpr () v1349 
                                    let v1351 : string = "$0.unwrap()"
                                    let v1352 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1350 v1351 
                                    let v1353 : string = "fable_library_rust::String_::fromString($0)"
                                    let v1354 : string = Fable.Core.RustInterop.emitRustExpr v1352 v1353 
                                    v1354 
                                    #endif
#if FABLE_COMPILER_RUST && WASM
                                    let v1355 : string = null |> unbox<string>
                                    v1355 
                                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                                    let v1356 : string = null |> unbox<string>
                                    v1356 
                                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                                    let v1357 : string = null |> unbox<string>
                                    v1357 
                                    #endif
#if FABLE_COMPILER_PYTHON
                                    let v1358 : string = null |> unbox<string>
                                    v1358 
                                    #endif
#else
                                    let v1359 : string = v1317 |> System.IO.File.ReadAllText
                                    v1359 
                                    #endif
                                    |> fun x -> _v1337 <- Some x
                                    let v1360 : string = match _v1337 with Some x -> x | None -> failwith "base.run_target / _v1337=None"
                                    let v1361 : string = "ts"
                                    let v1362 : string = $"%A{struct (v1361, v1360)}"
                                    let v1363 : string = method80(v1362)
                                    let v1364 : string = __SOURCE_DIRECTORY__
                                    let v1365 : string = method14()
                                    let v1366 : string = "polyglot"
                                    let v1367 : string = ".paket"
                                    let v1368 : string = method15(v1366, v1367)
                                    let v1369 : US12 = method18(v1368, v1364)
                                    let v1378 : US3 =
                                        match v1369 with
                                        | US12_1(v1372) -> (* Error *)
                                            let v1373 : US0 = US0_3
                                            let v1374 : (unit -> string) = closure10()
                                            let v1375 : (unit -> string) = closure11(v1372)
                                            method5(v1373, v1374, v1375)
                                            US3_1
                                        | US12_0(v1370) -> (* Ok *)
                                            US3_0(v1370)
                                    let v1393 : US3 =
                                        match v1378 with
                                        | US3_1 -> (* None *)
                                            let v1381 : string = method15(v1366, v1367)
                                            let v1382 : US12 = method18(v1381, v1365)
                                            match v1382 with
                                            | US12_1(v1385) -> (* Error *)
                                                let v1386 : US0 = US0_3
                                                let v1387 : (unit -> string) = closure10()
                                                let v1388 : (unit -> string) = closure11(v1385)
                                                method5(v1386, v1387, v1388)
                                                US3_1
                                            | US12_0(v1383) -> (* Ok *)
                                                US3_0(v1383)
                                        | US3_0(v1379) -> (* Some *)
                                            US3_0(v1379)
                                    let v1397 : string =
                                        match v1393 with
                                        | US3_1 -> (* None *)
                                            failwith<string> "Option does not have a value."
                                        | US3_0(v1394) -> (* Some *)
                                            v1394
                                    let v1398 : string = method15(v1397, v1366)
                                    let v1399 : string = "target/spiral_builder"
                                    let v1400 : string = method15(v1398, v1399)
                                    let v1401 : string = "spiral_builder"
                                    let v1402 : string = method15(v1400, v1401)
                                    let v1403 : string = "packages"
                                    let v1404 : string = method15(v1402, v1403)
                                    let v1405 : string = method15(v1404, v1363)
                                    let v1406 : System.IDisposable = method82(v1405)
                                    let v1407 : string = $"{v1401}.fs"
                                    let v1408 : string = method15(v1405, v1407)
                                    let v1409 : string = method70(v1408)
                                    method24(v1409, v1360)
                                    let v1410 : string list = []
                                    let v1411 : string seq = seq { for i = 0 to v1410.Length - 1 do yield v1410.[i] }
                                    let v1412 : (string -> (string seq -> string)) = String.concat
                                    let v1413 : string = "\\n        "
                                    let v1414 : (string seq -> string) = v1412 v1413
                                    let v1415 : string = v1414 v1411
                                    let v1416 : string = "Fable.Core"
                                    let v1417 : string = $"<PackageReference Include=\"{v1416}\" Version=\"*\" />"
                                    let v1418 : string list = []
                                    let v1419 : string list = v1417 :: v1418 
                                    let v1420 : string seq = seq { for i = 0 to v1419.Length - 1 do yield v1419.[i] }
                                    let v1421 : (string -> (string seq -> string)) = String.concat
                                    let v1422 : (string seq -> string) = v1421 v1413
                                    let v1423 : string = v1422 v1420
                                    let v1424 : string = $"{v1401}.fsproj"
                                    let v1425 : string = method15(v1405, v1424)
                                    let v1426 : string = method70(v1425)
                                    let v1427 : string = $"<Project Sdk=\"Microsoft.NET.Sdk\">"
                                    let v1428 : string = $"<PropertyGroup>"
                                    let v1429 : string = "\n"
                                    let v1430 : string = v1427 + v1429 
                                    let v1431 : string = v1430 + v1428 
                                    let v1432 : string = $"    <TargetFramework>net9.0</TargetFramework>"
                                    let v1433 : string = v1431 + v1429 
                                    let v1434 : string = v1433 + v1432 
                                    let v1435 : string = $"    <LangVersion>preview</LangVersion>"
                                    let v1436 : string = v1434 + v1429 
                                    let v1437 : string = v1436 + v1435 
                                    let v1438 : string = $"    <RollForward>Major</RollForward>"
                                    let v1439 : string = v1437 + v1429 
                                    let v1440 : string = v1439 + v1438 
                                    let v1441 : string = $"    <TargetLatestRuntimePatch>true</TargetLatestRuntimePatch>"
                                    let v1442 : string = v1440 + v1429 
                                    let v1443 : string = v1442 + v1441 
                                    let v1444 : string = $"    <PublishAot>false</PublishAot>"
                                    let v1445 : string = v1443 + v1429 
                                    let v1446 : string = v1445 + v1444 
                                    let v1447 : string = $"    <PublishTrimmed>false</PublishTrimmed>"
                                    let v1448 : string = v1446 + v1429 
                                    let v1449 : string = v1448 + v1447 
                                    let v1450 : string = $"    <PublishSingleFile>true</PublishSingleFile>"
                                    let v1451 : string = v1449 + v1429 
                                    let v1452 : string = v1451 + v1450 
                                    let v1453 : string = $"    <SelfContained>true</SelfContained>"
                                    let v1454 : string = v1452 + v1429 
                                    let v1455 : string = v1454 + v1453 
                                    let v1456 : string = $"    <Version>0.0.1-alpha.1</Version>"
                                    let v1457 : string = v1455 + v1429 
                                    let v1458 : string = v1457 + v1456 
                                    let v1459 : string = $"    <OutputType>Exe</OutputType>"
                                    let v1460 : string = v1458 + v1429 
                                    let v1461 : string = v1460 + v1459 
                                    let v1462 : string = $"</PropertyGroup>"
                                    let v1463 : string = v1461 + v1429 
                                    let v1464 : string = v1463 + v1462 
                                    let v1465 : string = $"<PropertyGroup Condition=\"$([MSBuild]::IsOSPlatform('FreeBSD'))\">"
                                    let v1466 : string = v1464 + v1429 
                                    let v1467 : string = v1466 + v1465 
                                    let v1468 : string = $"    <DefineConstants>_FREEBSD</DefineConstants>"
                                    let v1469 : string = v1467 + v1429 
                                    let v1470 : string = v1469 + v1468 
                                    let v1471 : string = $"</PropertyGroup>"
                                    let v1472 : string = v1470 + v1429 
                                    let v1473 : string = v1472 + v1471 
                                    let v1474 : string = $"<PropertyGroup Condition=\"$([MSBuild]::IsOSPlatform('Linux'))\">"
                                    let v1475 : string = v1473 + v1429 
                                    let v1476 : string = v1475 + v1474 
                                    let v1477 : string = $"    <DefineConstants>_LINUX</DefineConstants>"
                                    let v1478 : string = v1476 + v1429 
                                    let v1479 : string = v1478 + v1477 
                                    let v1480 : string = $"</PropertyGroup>"
                                    let v1481 : string = v1479 + v1429 
                                    let v1482 : string = v1481 + v1480 
                                    let v1483 : string = $"<PropertyGroup Condition=\"$([MSBuild]::IsOSPlatform('OSX'))\">"
                                    let v1484 : string = v1482 + v1429 
                                    let v1485 : string = v1484 + v1483 
                                    let v1486 : string = $"    <DefineConstants>_OSX</DefineConstants>"
                                    let v1487 : string = v1485 + v1429 
                                    let v1488 : string = v1487 + v1486 
                                    let v1489 : string = $"</PropertyGroup>"
                                    let v1490 : string = v1488 + v1429 
                                    let v1491 : string = v1490 + v1489 
                                    let v1492 : string = $"<PropertyGroup Condition=\"$([MSBuild]::IsOSPlatform('Windows'))\">"
                                    let v1493 : string = v1491 + v1429 
                                    let v1494 : string = v1493 + v1492 
                                    let v1495 : string = $"    <DefineConstants>_WINDOWS</DefineConstants>"
                                    let v1496 : string = v1494 + v1429 
                                    let v1497 : string = v1496 + v1495 
                                    let v1498 : string = $"</PropertyGroup>"
                                    let v1499 : string = v1497 + v1429 
                                    let v1500 : string = v1499 + v1498 
                                    let v1501 : string = $"<ItemGroup>"
                                    let v1502 : string = v1500 + v1429 
                                    let v1503 : string = v1502 + v1501 
                                    let v1504 : string = $"    {v1415}"
                                    let v1505 : string = v1503 + v1429 
                                    let v1506 : string = v1505 + v1504 
                                    let v1507 : string = $"    <Compile Include=\"{v1409}\" />"
                                    let v1508 : string = v1506 + v1429 
                                    let v1509 : string = v1508 + v1507 
                                    let v1510 : string = $"</ItemGroup>"
                                    let v1511 : string = v1509 + v1429 
                                    let v1512 : string = v1511 + v1510 
                                    let v1513 : string = $"<ItemGroup>"
                                    let v1514 : string = v1512 + v1429 
                                    let v1515 : string = v1514 + v1513 
                                    let v1516 : string = $"    {v1423}"
                                    let v1517 : string = v1515 + v1429 
                                    let v1518 : string = v1517 + v1516 
                                    let v1519 : string = $"</ItemGroup>"
                                    let v1520 : string = v1518 + v1429 
                                    let v1521 : string = v1520 + v1519 
                                    let v1522 : string = $"</Project>"
                                    let v1523 : string = v1521 + v1429 
                                    let v1524 : string = v1523 + v1522 
                                    method24(v1426, v1524)
                                    let v1525 : string = method23(v1426)
                                    let v1526 : string = __SOURCE_DIRECTORY__
                                    let v1527 : string = method14()
                                    let v1528 : string = method15(v1366, v1367)
                                    let v1529 : US12 = method18(v1528, v1526)
                                    let v1538 : US3 =
                                        match v1529 with
                                        | US12_1(v1532) -> (* Error *)
                                            let v1533 : US0 = US0_3
                                            let v1534 : (unit -> string) = closure10()
                                            let v1535 : (unit -> string) = closure11(v1532)
                                            method5(v1533, v1534, v1535)
                                            US3_1
                                        | US12_0(v1530) -> (* Ok *)
                                            US3_0(v1530)
                                    let v1553 : US3 =
                                        match v1538 with
                                        | US3_1 -> (* None *)
                                            let v1541 : string = method15(v1366, v1367)
                                            let v1542 : US12 = method18(v1541, v1527)
                                            match v1542 with
                                            | US12_1(v1545) -> (* Error *)
                                                let v1546 : US0 = US0_3
                                                let v1547 : (unit -> string) = closure10()
                                                let v1548 : (unit -> string) = closure11(v1545)
                                                method5(v1546, v1547, v1548)
                                                US3_1
                                            | US12_0(v1543) -> (* Ok *)
                                                US3_0(v1543)
                                        | US3_0(v1539) -> (* Some *)
                                            US3_0(v1539)
                                    let v1557 : string =
                                        match v1553 with
                                        | US3_1 -> (* None *)
                                            failwith<string> "Option does not have a value."
                                        | US3_0(v1554) -> (* Some *)
                                            v1554
                                    let v1558 : string = method15(v1557, v1366)
                                    let v1559 : string = method14()
                                    let v1560 : (unit -> string) = v1559.ToLower
                                    let v1561 : string = v1560 ()
                                    let v1562 : (unit -> string) = v1558.ToLower
                                    let v1563 : string = v1562 ()
                                    let v1564 : bool = v1561.StartsWith v1563 
                                    let v1567 : US12 =
                                        if v1564 then
                                            US12_1(v1563)
                                        else
                                            US12_0(v1563)
                                    let v1573 : Result<string, string> =
                                        match v1567 with
                                        | US12_1(v1570) -> (* Error *)
                                            let v1571 : Result<string, string> = Error v1570 
                                            v1571
                                        | US12_0(v1568) -> (* Ok *)
                                            let v1569 : Result<string, string> = Ok v1568 
                                            v1569
                                    let v1574 : string = "true; let _result = $0.unwrap_or_else(|x| { //"
                                    let v1575 : bool = Fable.Core.RustInterop.emitRustExpr v1573 v1574 
                                    let v1576 : string = "x"
                                    let v1577 : string = Fable.Core.RustInterop.emitRustExpr () v1576 
                                    let v1578 : string = "true; $0 })"
                                    let v1579 : bool = Fable.Core.RustInterop.emitRustExpr v1577 v1578 
                                    let v1580 : string = "_result"
                                    let v1581 : string = Fable.Core.RustInterop.emitRustExpr () v1580 
                                    let v1582 : string = "lib/typescript/fable/fable_modules"
                                    let v1583 : string = method15(v1581, v1582)
                                    let v1584 : string = "async_walkdir::WalkDir::new(&*$0)"
                                    let v1585 : async_walkdir_WalkDir = Fable.Core.RustInterop.emitRustExpr v1583 v1584 
                                    let v1586 : string = "async_walkdir::WalkDir::filter($0, |x| $1(x))"
                                    let v1587 : (async_walkdir_DirEntry -> std_pin_Pin<Box<LifetimeJoin<Dyn<std_future_Future<async_walkdir_Filtering>>, Send<Dyn<std_future_Future<async_walkdir_Filtering>>>>>>) = closure89()
                                    let v1588 : async_walkdir_WalkDir = Fable.Core.RustInterop.emitRustExpr struct (v1585, v1587) v1586 
                                    let v1589 : (Result<async_walkdir_DirEntry, std_io_Error> -> struct (string * string) option) = method112()
                                    let v1590 : string = "tokio_stream::StreamExt::collect(tokio_stream::StreamExt::filter_map(v1588, |x| v1589(x))).await"
                                    let v1591 : Vec<struct (string * string)> = Fable.Core.RustInterop.emitRustExpr () v1590 
                                    let v1592 : string = "rayon::iter::IntoParallelIterator::into_par_iter(v1591)"
                                    let v1593 : rayon_vec_IntoIter<struct (string * string)> = Fable.Core.RustInterop.emitRustExpr () v1592 
                                    let v1594 : string = "rayon::iter::ParallelIterator::map($0, |x| $1(x))"
                                    let v1595 : (struct (string * string) -> struct (string * string)) = closure97()
                                    let v1596 : rayon_iter_Map<rayon_vec_IntoIter<struct (string * string)>> = Fable.Core.RustInterop.emitRustExpr struct (v1593, v1595) v1594 
                                    let v1597 : string = "rayon::iter::ParallelIterator::collect($0)"
                                    let v1598 : Vec<struct (string * string)> = Fable.Core.RustInterop.emitRustExpr v1596 v1597 
                                    let v1599 : string = "fable_library_rust::NativeArray_::array_from($0)"
                                    let v1600 : (struct (string * string) []) = Fable.Core.RustInterop.emitRustExpr v1598 v1599 
                                    let v1601 : (int32 -> ((struct (string * string) []) -> struct (string * string) option)) = Array.tryItem
                                    let v1602 : ((struct (string * string) []) -> struct (string * string) option) = v1601 0
                                    let v1603 : struct (string * string) option = v1602 v1600
                                    let v1604 : US39 option = None
                                    let _v1604 = ref v1604 
                                    match v1603 with
                                    | Some x -> (
                                    (fun () ->
                                    (fun () ->
                                    let struct (v1605 : string, v1606 : string) = x
                                    let v1607 : US39 = US39_0(v1605, v1606)
                                    v1607 
                                    )
                                    |> fun x -> x () |> Some
                                    ) () ) | None -> None
                                    |> fun x -> _v1604.Value <- x
                                    let v1608 : US39 option = _v1604.Value 
                                    let v1609 : US39 = US39_1
                                    let v1610 : US39 = v1608 |> Option.defaultValue v1609 
                                    let v1611 : US0 = US0_1
                                    let v1612 : (unit -> string) = closure98()
                                    let v1613 : (unit -> string) = closure99(v1610)
                                    method5(v1611, v1612, v1613)
                                    match v1610 with
                                    | US39_1 -> (* None *)
                                        ()
                                    | US39_0(v1614, v1615) -> (* Some *)
                                        let v1616 : string = $"fable-library-{v1361}.{v1615}"
                                        let v1617 : string = method15(v1583, v1616)
                                        let v1618 : string = $"fable_modules/fable-library-{v1361}.{v1615}"
                                        let v1619 : string = method15(v1525, v1618)
                                        method98(v1617, v1619)
                                    let struct (v1620 : int32, v1621 : string) = method99(v1525, v1361, v1426, v1567)
                                    let v1622 : bool = v1620 <> 0 
                                    if v1622 then
                                        let v1623 : US0 = US0_4
                                        let v1624 : (unit -> string) = closure100(v1621, v1620)
                                        let v1625 : (unit -> string) = closure6()
                                        method5(v1623, v1624, v1625)
                                        let v1626 : US3 = US3_1
                                        let v1627 : US3 = US3_0(v1361)
                                        let v1628 : US3 = US3_0(v1621)
                                        struct (v1626, v1627, v1628)
                                    else
                                        let v1629 : string = "true; let _result : Vec<_> = v1334.into_iter().map(|x| { //"
                                        let v1630 : bool = Fable.Core.RustInterop.emitRustExpr () v1629 
                                        let v1631 : string = "x"
                                        let v1632 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v1631 
                                        let v1633 : string = "fable_library_rust::String_::fromString($0)"
                                        let v1634 : string = Fable.Core.RustInterop.emitRustExpr v1632 v1633 
                                        let v1635 : string = "="
                                        let v1636 : bool = v1634.Contains v1635 
                                        let v1638 : string =
                                            if v1636 then
                                                v1634
                                            else
                                                let v1637 : string = $"\"{v1634}\":\"*\""
                                                v1637
                                        let v1639 : string = "true; $0 }).collect::<Vec<_>>()"
                                        let v1640 : bool = Fable.Core.RustInterop.emitRustExpr v1638 v1639 
                                        let v1641 : string = "_result"
                                        let v1642 : Vec<string> = Fable.Core.RustInterop.emitRustExpr () v1641 
                                        let v1643 : string = "fable_library_rust::NativeArray_::array_from($0)"
                                        let v1644 : (string []) = Fable.Core.RustInterop.emitRustExpr v1642 v1643 
                                        let v1645 : string seq = seq { for i = 0 to v1644.Length - 1 do yield v1644.[i] }
                                        let v1646 : (string -> (string seq -> string)) = String.concat
                                        let v1647 : string = ",\n"
                                        let v1648 : (string seq -> string) = v1646 v1647
                                        let v1649 : string = v1648 v1645
                                        let v1650 : string = $"{{"
                                        let v1651 : string = $"  \"name\": \"spiral_builder_{v1363}\","
                                        let v1652 : string = v1650 + v1651 
                                        let v1653 : string = $"  \"dependencies\": {{"
                                        let v1654 : string = v1652 + v1653 
                                        let v1655 : string = v1654 + v1649 
                                        let v1656 : string = $"  }},"
                                        let v1657 : string = v1655 + v1656 
                                        let v1658 : string = $"    \"devDependencies\": {{"
                                        let v1659 : string = v1657 + v1658 
                                        let v1660 : string = $"  }},"
                                        let v1661 : string = v1659 + v1660 
                                        let v1662 : string = $"}}"
                                        let v1663 : string = v1661 + v1662 
                                        let v1664 : string = "package.json"
                                        let v1665 : string = method15(v1525, v1664)
                                        let v1666 : string = "../.."
                                        let v1667 : string = method15(v1525, v1666)
                                        let v1668 : string = method15(v1667, v1664)
                                        method24(v1665, v1663)
                                        let v1669 : string = ""
                                        method24(v1668, v1669)
                                        let v1670 : string = $"{v1401}.{v1361}"
                                        let v1671 : string = method15(v1525, v1670)
                                        let v1672 : US0 = US0_1
                                        let v1673 : (unit -> string) = closure101()
                                        let v1674 : (unit -> string) = closure102(v1671)
                                        method5(v1672, v1673, v1674)
                                        let v1675 : bool = true
                                        let mutable _v1675 : string option = None 
                                        
#if FABLE_COMPILER || WASM || CONTRACT
                                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                        let v1676 : bool = true
                                        let mutable _v1676 : Vec<uint8> option = None 
                                        
#if FABLE_COMPILER || WASM || CONTRACT
                                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                        let v1677 : string = "std::fs::read(&*$0).unwrap()"
                                        let v1678 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v1671 v1677 
                                        v1678 
                                        #endif
#if FABLE_COMPILER_RUST && WASM
                                        let v1679 : Vec<uint8> = null |> unbox<Vec<uint8>>
                                        v1679 
                                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                                        let v1680 : Vec<uint8> = null |> unbox<Vec<uint8>>
                                        v1680 
                                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                                        let v1681 : Vec<uint8> = null |> unbox<Vec<uint8>>
                                        v1681 
                                        #endif
#if FABLE_COMPILER_PYTHON
                                        let v1682 : Vec<uint8> = null |> unbox<Vec<uint8>>
                                        v1682 
                                        #endif
#else
                                        let v1683 : (uint8 []) = v1671 |> System.IO.File.ReadAllBytes
                                        let v1684 : string = "$0.to_vec()"
                                        let v1685 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v1683 v1684 
                                        v1685 
                                        #endif
                                        |> fun x -> _v1676 <- Some x
                                        let v1686 : Vec<uint8> = match _v1676 with Some x -> x | None -> failwith "base.run_target / _v1676=None"
                                        let v1687 : string = "std::string::String::from_utf8(v1686)"
                                        let v1688 : Result<std_string_String, std_string_FromUtf8Error> = Fable.Core.RustInterop.emitRustExpr () v1687 
                                        let v1689 : string = "$0.unwrap()"
                                        let v1690 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1688 v1689 
                                        let v1691 : string = "fable_library_rust::String_::fromString($0)"
                                        let v1692 : string = Fable.Core.RustInterop.emitRustExpr v1690 v1691 
                                        v1692 
                                        #endif
#if FABLE_COMPILER_RUST && WASM
                                        let v1693 : string = null |> unbox<string>
                                        v1693 
                                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                                        let v1694 : string = null |> unbox<string>
                                        v1694 
                                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                                        let v1695 : string = null |> unbox<string>
                                        v1695 
                                        #endif
#if FABLE_COMPILER_PYTHON
                                        let v1696 : string = null |> unbox<string>
                                        v1696 
                                        #endif
#else
                                        let v1697 : string = v1671 |> System.IO.File.ReadAllText
                                        v1697 
                                        #endif
                                        |> fun x -> _v1675 <- Some x
                                        let v1698 : string = match _v1675 with Some x -> x | None -> failwith "base.run_target / _v1675=None"
                                        let v1699 : string = "// spiral_builder.process_typescript"
                                        let v1700 : bool = v1698.Contains v1699 
                                        let v1725 : string =
                                            if v1700 then
                                                v1698
                                            else
                                                let v1701 : string = $"\"./fable_modules/fable-library-ts.{v1610}/"
                                                let v1702 : string = $"\"{v1581}/lib/typescript/fable/fable_modules/fable-library-ts.{v1610}/"
                                                let v1703 : string = v1698.Replace (v1701, v1702)
                                                let v1704 : string = method103()
                                                let v1705 : bool = true
                                                let mutable _v1705 : string option = None 
                                                
#if FABLE_COMPILER || WASM || CONTRACT
                                                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                                let v1706 : string = method72(v1703)
                                                let v1707 : string = $"regex::Regex::new(&$0)"
                                                let v1708 : string = "\\s\\sdefaultOf\\(\\);"
                                                let v1709 : Result<regex_Regex, regex_Error> = Fable.Core.RustInterop.emitRustExpr v1708 v1707 
                                                let v1710 : string = "$0.unwrap()"
                                                let v1711 : regex_Regex = Fable.Core.RustInterop.emitRustExpr v1709 v1710 
                                                let v1712 : string = $"$0.replace_all(&$1, &*$2)"
                                                let v1713 : std_borrow_Cow<Str> = Fable.Core.RustInterop.emitRustExpr struct (v1711, v1706, v1704) v1712 
                                                let v1714 : string = "String::from($0)"
                                                let v1715 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1713 v1714 
                                                let v1716 : string = "fable_library_rust::String_::fromString($0)"
                                                let v1717 : string = Fable.Core.RustInterop.emitRustExpr v1715 v1716 
                                                v1717 
                                                #endif
#if FABLE_COMPILER_RUST && WASM
                                                let v1718 : string = null |> unbox<string>
                                                v1718 
                                                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                                                let v1719 : string = null |> unbox<string>
                                                v1719 
                                                #endif
#if FABLE_COMPILER_TYPESCRIPT
                                                let v1720 : string = null |> unbox<string>
                                                v1720 
                                                #endif
#if FABLE_COMPILER_PYTHON
                                                let v1721 : string = null |> unbox<string>
                                                v1721 
                                                #endif
#else
                                                let v1722 : string = method104()
                                                let v1723 : string = System.Text.RegularExpressions.Regex.Replace (v1703, v1722, v1704)
                                                v1723 
                                                #endif
                                                |> fun x -> _v1705 <- Some x
                                                let v1724 : string = match _v1705 with Some x -> x | None -> failwith "base.run_target / _v1705=None"
                                                v1724
                                        let v1726 : bool = v1700 = false
                                        if v1726 then
                                            let v1727 : string = $"{v1725}\n\n{v1699}\n"
                                            method24(v1671, v1727)
                                        let v1728 : string = $"bun run \"{v1671}\""
                                        let v1729 : string = "PATH"
                                        let v1730 : string = method2(v1729)
                                        let v1731 : bool = v1730 = ""
                                        let v1758 : US3 =
                                            if v1731 then
                                                US3_1
                                            else
                                                let v1733 : bool = true
                                                let mutable _v1733 : bool option = None 
                                                
#if FABLE_COMPILER || WASM || CONTRACT
                                                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                                let v1734 : string = "cfg!(windows)"
                                                let v1735 : bool = Fable.Core.RustInterop.emitRustExpr () v1734 
                                                v1735 
                                                #endif
#if FABLE_COMPILER_RUST && WASM
                                                let v1736 : string = "cfg!(windows)"
                                                let v1737 : bool = Fable.Core.RustInterop.emitRustExpr () v1736 
                                                v1737 
                                                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                                                let v1738 : string = "cfg!(windows)"
                                                let v1739 : bool = Fable.Core.RustInterop.emitRustExpr () v1738 
                                                v1739 
                                                #endif
#if FABLE_COMPILER_TYPESCRIPT
                                                let v1740 : US10 = US10_0
                                                let v1741 : US11 = US11_3(v1740)
                                                let v1742 : string = $"platform.is_windows / target: {v1741}"
                                                let v1743 : bool = failwith<bool> v1742
                                                v1743 
                                                #endif
#if FABLE_COMPILER_PYTHON
                                                let v1744 : US10 = US10_0
                                                let v1745 : US11 = US11_4(v1744)
                                                let v1746 : string = $"platform.is_windows / target: {v1745}"
                                                let v1747 : bool = failwith<bool> v1746
                                                v1747 
                                                #endif
#else
                                                let v1748 : System.Runtime.InteropServices.OSPlatform = System.Runtime.InteropServices.OSPlatform.Windows
                                                let v1749 : (System.Runtime.InteropServices.OSPlatform -> bool) = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform
                                                let v1750 : bool = v1749 v1748
                                                v1750 
                                                #endif
                                                |> fun x -> _v1733 <- Some x
                                                let v1751 : bool = match _v1733 with Some x -> x | None -> failwith "base.run_target / _v1733=None"
                                                let v1754 : string =
                                                    if v1751 then
                                                        let v1752 : string = ";"
                                                        v1752
                                                    else
                                                        let v1753 : string = ":"
                                                        v1753
                                                let v1755 : string = "~/.bun/bin"
                                                let v1756 : string = $"{v1755}{v1754}{v1730}"
                                                US3_0(v1756)
                                        let v1764 : UH4 =
                                            match v1758 with
                                            | US3_1 -> (* None *)
                                                UH4_0
                                            | US3_0(v1759) -> (* Some *)
                                                let v1760 : UH4 = UH4_0
                                                UH4_1(v1729, v1759, v1760)
                                        let v1765 : string = "TRACE_LEVEL"
                                        let v1766 : string = "Verbose"
                                        let v1767 : UH4 = UH4_0
                                        let v1768 : UH4 = UH4_1(v1765, v1766, v1767)
                                        let v1769 : UH4 = method113(v1764, v1768)
                                        let v1770 : struct (string * string) list = []
                                        let v1771 : struct (string * string) list = method114(v1769, v1770)
                                        let v1772 : (struct (string * string) list -> (struct (string * string) [])) = List.toArray
                                        let v1773 : (struct (string * string) []) = v1772 v1771
                                        let v1774 : System.Threading.CancellationToken option = None
                                        let v1775 : (struct (string * string) []) = [||]
                                        let v1776 : (struct (bool * string * int32) -> Async<unit>) option = None
                                        let v1777 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = None
                                        let v1778 : string option = None
                                        let v1784 : Result<string, string> =
                                            match v1567 with
                                            | US12_1(v1781) -> (* Error *)
                                                let v1782 : Result<string, string> = Error v1781 
                                                v1782
                                            | US12_0(v1779) -> (* Ok *)
                                                let v1780 : Result<string, string> = Ok v1779 
                                                v1780
                                        let v1785 : string = "v1784.ok()"
                                        let v1786 : string option = Fable.Core.RustInterop.emitRustExpr () v1785 
                                        let v1787 : bool = true
                                        let struct (v1788 : int32, v1789 : string) = method28(v1774, v1728, v1773, v1776, v1777, v1787, v1786)
                                        let v1790 : int32 = v1773.Length
                                        let v1791 : (string []) = Array.zeroCreate<string> (v1790)
                                        let v1792 : Mut4 = {l0 = 0} : Mut4
                                        while method32(v1790, v1792) do
                                            let v1794 : int32 = v1792.l0
                                            let struct (v1795 : string, v1796 : string) = v1773.[int v1794]
                                            let v1797 : string = $"$env:{v1795}=''{v1796}''"
                                            v1791.[int v1794] <- v1797
                                            let v1798 : int32 = v1794 + 1
                                            v1792.l0 <- v1798
                                            ()
                                        let v1799 : ((string []) -> string seq) = Seq.ofArray
                                        let v1800 : string seq = v1799 v1791
                                        let v1801 : (string -> (string seq -> string)) = String.concat
                                        let v1802 : string = ";"
                                        let v1803 : (string seq -> string) = v1801 v1802
                                        let v1804 : string = v1803 v1800
                                        let v1805 : string = $"pwsh -c '{v1804}; {v1728}'"
                                        let v1806 : bool = v1788 = 0
                                        if v1806 then
                                            let v1807 : (unit -> string) = closure103(v1789)
                                            let v1808 : (string -> US3) = closure45()
                                            let v1809 : (exn -> US3) = closure104(v1671, v1789, v1805)
                                            let v1810 : US3 = try v1807 () |> v1808 with ex -> v1809 ex 
                                            let v1815 : string option =
                                                match v1810 with
                                                | US3_1 -> (* None *)
                                                    let v1813 : string option = None
                                                    v1813
                                                | US3_0(v1811) -> (* Some *)
                                                    let v1812 : string option = Some v1811 
                                                    v1812
                                            let v1816 : string = "$0.unwrap()"
                                            let v1817 : string = Fable.Core.RustInterop.emitRustExpr v1815 v1816 
                                            let v1818 : US3 = US3_0(v1725)
                                            let v1819 : US3 = US3_0(v1361)
                                            let v1820 : US3 = US3_0(v1817)
                                            struct (v1818, v1819, v1820)
                                        else
                                            let v1821 : US0 = US0_4
                                            let v1822 : (unit -> string) = closure107()
                                            let v1823 : (unit -> string) = closure108(v1671, v1789, v1788, v1805)
                                            method5(v1821, v1822, v1823)
                                            let v1824 : US3 = US3_1
                                            let v1825 : US3 = US3_0(v1361)
                                            let v1826 : US3 = US3_1
                                            struct (v1824, v1825, v1826)
                                else
                                    let v1833 : string = "fable_library_rust::String_::fromString($0)"
                                    let v1834 : string = Fable.Core.RustInterop.emitRustExpr v13 v1833 
                                    let v1836 : bool = v1834 = "python"
                                    if v1836 then
                                        let v1837 : string = method63()
                                        let v1838 : string = "&*$0"
                                        let v1839 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1837 v1838 
                                        let v1840 : string = "clap::ArgMatches::get_one(&$0, v1839).cloned()"
                                        let v1841 : std_string_String option = Fable.Core.RustInterop.emitRustExpr v14 v1840 
                                        let v1842 : US5 option = None
                                        let _v1842 = ref v1842 
                                        match v1841 with
                                        | Some x -> (
                                        (fun () ->
                                        (fun () ->
                                        let v1843 : std_string_String = x
                                        let v1844 : US5 = US5_0(v1843)
                                        v1844 
                                        )
                                        |> fun x -> x () |> Some
                                        ) () ) | None -> None
                                        |> fun x -> _v1842.Value <- x
                                        let v1845 : US5 option = _v1842.Value 
                                        let v1846 : US5 = US5_1
                                        let v1847 : US5 = v1845 |> Option.defaultValue v1846 
                                        let v1851 : std_string_String =
                                            match v1847 with
                                            | US5_1 -> (* None *)
                                                failwith<std_string_String> "Option does not have a value."
                                            | US5_0(v1848) -> (* Some *)
                                                v1848
                                        let v1852 : string = "fable_library_rust::String_::fromString($0)"
                                        let v1853 : string = Fable.Core.RustInterop.emitRustExpr v1851 v1852 
                                        let v1854 : string = method13()
                                        let v1855 : string = "&*$0"
                                        let v1856 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1854 v1855 
                                        let v1857 : string = "clap::ArgMatches::get_many(&$0, v1856).map(|x| x.cloned().into_iter().collect())"
                                        let v1858 : Vec<std_string_String> option = Fable.Core.RustInterop.emitRustExpr v14 v1857 
                                        let v1859 : US9 option = None
                                        let _v1859 = ref v1859 
                                        match v1858 with
                                        | Some x -> (
                                        (fun () ->
                                        (fun () ->
                                        let v1860 : Vec<std_string_String> = x
                                        let v1861 : US9 = US9_0(v1860)
                                        v1861 
                                        )
                                        |> fun x -> x () |> Some
                                        ) () ) | None -> None
                                        |> fun x -> _v1859.Value <- x
                                        let v1862 : US9 option = _v1859.Value 
                                        let v1863 : US9 = US9_1
                                        let v1864 : US9 = v1862 |> Option.defaultValue v1863 
                                        let v1865 : (std_string_String []) = [||]
                                        let v1866 : string = "$0.to_vec()"
                                        let v1867 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr v1865 v1866 
                                        let v1870 : Vec<std_string_String> =
                                            match v1864 with
                                            | US9_1 -> (* None *)
                                                v1867
                                            | US9_0(v1868) -> (* Some *)
                                                v1868
                                        let v1872 : bool =
                                            match v0 with
                                            | US0_0 -> (* Verbose *)
                                                true
                                            | _ ->
                                                false
                                        let v1873 : bool = true
                                        let mutable _v1873 : string option = None 
                                        
#if FABLE_COMPILER || WASM || CONTRACT
                                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                        let v1874 : bool = true
                                        let mutable _v1874 : Vec<uint8> option = None 
                                        
#if FABLE_COMPILER || WASM || CONTRACT
                                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                        let v1875 : string = "std::fs::read(&*$0).unwrap()"
                                        let v1876 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v1853 v1875 
                                        v1876 
                                        #endif
#if FABLE_COMPILER_RUST && WASM
                                        let v1877 : Vec<uint8> = null |> unbox<Vec<uint8>>
                                        v1877 
                                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                                        let v1878 : Vec<uint8> = null |> unbox<Vec<uint8>>
                                        v1878 
                                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                                        let v1879 : Vec<uint8> = null |> unbox<Vec<uint8>>
                                        v1879 
                                        #endif
#if FABLE_COMPILER_PYTHON
                                        let v1880 : Vec<uint8> = null |> unbox<Vec<uint8>>
                                        v1880 
                                        #endif
#else
                                        let v1881 : (uint8 []) = v1853 |> System.IO.File.ReadAllBytes
                                        let v1882 : string = "$0.to_vec()"
                                        let v1883 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v1881 v1882 
                                        v1883 
                                        #endif
                                        |> fun x -> _v1874 <- Some x
                                        let v1884 : Vec<uint8> = match _v1874 with Some x -> x | None -> failwith "base.run_target / _v1874=None"
                                        let v1885 : string = "std::string::String::from_utf8(v1884)"
                                        let v1886 : Result<std_string_String, std_string_FromUtf8Error> = Fable.Core.RustInterop.emitRustExpr () v1885 
                                        let v1887 : string = "$0.unwrap()"
                                        let v1888 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1886 v1887 
                                        let v1889 : string = "fable_library_rust::String_::fromString($0)"
                                        let v1890 : string = Fable.Core.RustInterop.emitRustExpr v1888 v1889 
                                        v1890 
                                        #endif
#if FABLE_COMPILER_RUST && WASM
                                        let v1891 : string = null |> unbox<string>
                                        v1891 
                                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                                        let v1892 : string = null |> unbox<string>
                                        v1892 
                                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                                        let v1893 : string = null |> unbox<string>
                                        v1893 
                                        #endif
#if FABLE_COMPILER_PYTHON
                                        let v1894 : string = null |> unbox<string>
                                        v1894 
                                        #endif
#else
                                        let v1895 : string = v1853 |> System.IO.File.ReadAllText
                                        v1895 
                                        #endif
                                        |> fun x -> _v1873 <- Some x
                                        let v1896 : string = match _v1873 with Some x -> x | None -> failwith "base.run_target / _v1873=None"
                                        let v1897 : string = "py"
                                        let v1898 : string = $"%A{struct (v1897, v1896)}"
                                        let v1899 : string = method80(v1898)
                                        let v1900 : string = __SOURCE_DIRECTORY__
                                        let v1901 : string = method14()
                                        let v1902 : string = "polyglot"
                                        let v1903 : string = ".paket"
                                        let v1904 : string = method15(v1902, v1903)
                                        let v1905 : US12 = method18(v1904, v1900)
                                        let v1914 : US3 =
                                            match v1905 with
                                            | US12_1(v1908) -> (* Error *)
                                                let v1909 : US0 = US0_3
                                                let v1910 : (unit -> string) = closure10()
                                                let v1911 : (unit -> string) = closure11(v1908)
                                                method5(v1909, v1910, v1911)
                                                US3_1
                                            | US12_0(v1906) -> (* Ok *)
                                                US3_0(v1906)
                                        let v1929 : US3 =
                                            match v1914 with
                                            | US3_1 -> (* None *)
                                                let v1917 : string = method15(v1902, v1903)
                                                let v1918 : US12 = method18(v1917, v1901)
                                                match v1918 with
                                                | US12_1(v1921) -> (* Error *)
                                                    let v1922 : US0 = US0_3
                                                    let v1923 : (unit -> string) = closure10()
                                                    let v1924 : (unit -> string) = closure11(v1921)
                                                    method5(v1922, v1923, v1924)
                                                    US3_1
                                                | US12_0(v1919) -> (* Ok *)
                                                    US3_0(v1919)
                                            | US3_0(v1915) -> (* Some *)
                                                US3_0(v1915)
                                        let v1933 : string =
                                            match v1929 with
                                            | US3_1 -> (* None *)
                                                failwith<string> "Option does not have a value."
                                            | US3_0(v1930) -> (* Some *)
                                                v1930
                                        let v1934 : string = method15(v1933, v1902)
                                        let v1935 : string = "target/spiral_builder"
                                        let v1936 : string = method15(v1934, v1935)
                                        let v1937 : string = "spiral_builder"
                                        let v1938 : string = method15(v1936, v1937)
                                        let v1939 : string = "packages"
                                        let v1940 : string = method15(v1938, v1939)
                                        let v1941 : string = method15(v1940, v1899)
                                        let v1942 : System.IDisposable = method82(v1941)
                                        let v1943 : string = $"{v1937}.fs"
                                        let v1944 : string = method15(v1941, v1943)
                                        let v1945 : string = method70(v1944)
                                        method24(v1945, v1896)
                                        let v1946 : string list = []
                                        let v1947 : string seq = seq { for i = 0 to v1946.Length - 1 do yield v1946.[i] }
                                        let v1948 : (string -> (string seq -> string)) = String.concat
                                        let v1949 : string = "\\n        "
                                        let v1950 : (string seq -> string) = v1948 v1949
                                        let v1951 : string = v1950 v1947
                                        let v1952 : string = "Fable.Core"
                                        let v1953 : string = $"<PackageReference Include=\"{v1952}\" Version=\"*\" />"
                                        let v1954 : string list = []
                                        let v1955 : string list = v1953 :: v1954 
                                        let v1956 : string seq = seq { for i = 0 to v1955.Length - 1 do yield v1955.[i] }
                                        let v1957 : (string -> (string seq -> string)) = String.concat
                                        let v1958 : (string seq -> string) = v1957 v1949
                                        let v1959 : string = v1958 v1956
                                        let v1960 : string = $"{v1937}.fsproj"
                                        let v1961 : string = method15(v1941, v1960)
                                        let v1962 : string = method70(v1961)
                                        let v1963 : string = $"<Project Sdk=\"Microsoft.NET.Sdk\">"
                                        let v1964 : string = $"<PropertyGroup>"
                                        let v1965 : string = "\n"
                                        let v1966 : string = v1963 + v1965 
                                        let v1967 : string = v1966 + v1964 
                                        let v1968 : string = $"    <TargetFramework>net9.0</TargetFramework>"
                                        let v1969 : string = v1967 + v1965 
                                        let v1970 : string = v1969 + v1968 
                                        let v1971 : string = $"    <LangVersion>preview</LangVersion>"
                                        let v1972 : string = v1970 + v1965 
                                        let v1973 : string = v1972 + v1971 
                                        let v1974 : string = $"    <RollForward>Major</RollForward>"
                                        let v1975 : string = v1973 + v1965 
                                        let v1976 : string = v1975 + v1974 
                                        let v1977 : string = $"    <TargetLatestRuntimePatch>true</TargetLatestRuntimePatch>"
                                        let v1978 : string = v1976 + v1965 
                                        let v1979 : string = v1978 + v1977 
                                        let v1980 : string = $"    <PublishAot>false</PublishAot>"
                                        let v1981 : string = v1979 + v1965 
                                        let v1982 : string = v1981 + v1980 
                                        let v1983 : string = $"    <PublishTrimmed>false</PublishTrimmed>"
                                        let v1984 : string = v1982 + v1965 
                                        let v1985 : string = v1984 + v1983 
                                        let v1986 : string = $"    <PublishSingleFile>true</PublishSingleFile>"
                                        let v1987 : string = v1985 + v1965 
                                        let v1988 : string = v1987 + v1986 
                                        let v1989 : string = $"    <SelfContained>true</SelfContained>"
                                        let v1990 : string = v1988 + v1965 
                                        let v1991 : string = v1990 + v1989 
                                        let v1992 : string = $"    <Version>0.0.1-alpha.1</Version>"
                                        let v1993 : string = v1991 + v1965 
                                        let v1994 : string = v1993 + v1992 
                                        let v1995 : string = $"    <OutputType>Exe</OutputType>"
                                        let v1996 : string = v1994 + v1965 
                                        let v1997 : string = v1996 + v1995 
                                        let v1998 : string = $"</PropertyGroup>"
                                        let v1999 : string = v1997 + v1965 
                                        let v2000 : string = v1999 + v1998 
                                        let v2001 : string = $"<PropertyGroup Condition=\"$([MSBuild]::IsOSPlatform('FreeBSD'))\">"
                                        let v2002 : string = v2000 + v1965 
                                        let v2003 : string = v2002 + v2001 
                                        let v2004 : string = $"    <DefineConstants>_FREEBSD</DefineConstants>"
                                        let v2005 : string = v2003 + v1965 
                                        let v2006 : string = v2005 + v2004 
                                        let v2007 : string = $"</PropertyGroup>"
                                        let v2008 : string = v2006 + v1965 
                                        let v2009 : string = v2008 + v2007 
                                        let v2010 : string = $"<PropertyGroup Condition=\"$([MSBuild]::IsOSPlatform('Linux'))\">"
                                        let v2011 : string = v2009 + v1965 
                                        let v2012 : string = v2011 + v2010 
                                        let v2013 : string = $"    <DefineConstants>_LINUX</DefineConstants>"
                                        let v2014 : string = v2012 + v1965 
                                        let v2015 : string = v2014 + v2013 
                                        let v2016 : string = $"</PropertyGroup>"
                                        let v2017 : string = v2015 + v1965 
                                        let v2018 : string = v2017 + v2016 
                                        let v2019 : string = $"<PropertyGroup Condition=\"$([MSBuild]::IsOSPlatform('OSX'))\">"
                                        let v2020 : string = v2018 + v1965 
                                        let v2021 : string = v2020 + v2019 
                                        let v2022 : string = $"    <DefineConstants>_OSX</DefineConstants>"
                                        let v2023 : string = v2021 + v1965 
                                        let v2024 : string = v2023 + v2022 
                                        let v2025 : string = $"</PropertyGroup>"
                                        let v2026 : string = v2024 + v1965 
                                        let v2027 : string = v2026 + v2025 
                                        let v2028 : string = $"<PropertyGroup Condition=\"$([MSBuild]::IsOSPlatform('Windows'))\">"
                                        let v2029 : string = v2027 + v1965 
                                        let v2030 : string = v2029 + v2028 
                                        let v2031 : string = $"    <DefineConstants>_WINDOWS</DefineConstants>"
                                        let v2032 : string = v2030 + v1965 
                                        let v2033 : string = v2032 + v2031 
                                        let v2034 : string = $"</PropertyGroup>"
                                        let v2035 : string = v2033 + v1965 
                                        let v2036 : string = v2035 + v2034 
                                        let v2037 : string = $"<ItemGroup>"
                                        let v2038 : string = v2036 + v1965 
                                        let v2039 : string = v2038 + v2037 
                                        let v2040 : string = $"    {v1951}"
                                        let v2041 : string = v2039 + v1965 
                                        let v2042 : string = v2041 + v2040 
                                        let v2043 : string = $"    <Compile Include=\"{v1945}\" />"
                                        let v2044 : string = v2042 + v1965 
                                        let v2045 : string = v2044 + v2043 
                                        let v2046 : string = $"</ItemGroup>"
                                        let v2047 : string = v2045 + v1965 
                                        let v2048 : string = v2047 + v2046 
                                        let v2049 : string = $"<ItemGroup>"
                                        let v2050 : string = v2048 + v1965 
                                        let v2051 : string = v2050 + v2049 
                                        let v2052 : string = $"    {v1959}"
                                        let v2053 : string = v2051 + v1965 
                                        let v2054 : string = v2053 + v2052 
                                        let v2055 : string = $"</ItemGroup>"
                                        let v2056 : string = v2054 + v1965 
                                        let v2057 : string = v2056 + v2055 
                                        let v2058 : string = $"</Project>"
                                        let v2059 : string = v2057 + v1965 
                                        let v2060 : string = v2059 + v2058 
                                        method24(v1962, v2060)
                                        let v2061 : string = method23(v1962)
                                        let v2062 : string = __SOURCE_DIRECTORY__
                                        let v2063 : string = method14()
                                        let v2064 : string = method15(v1902, v1903)
                                        let v2065 : US12 = method18(v2064, v2062)
                                        let v2074 : US3 =
                                            match v2065 with
                                            | US12_1(v2068) -> (* Error *)
                                                let v2069 : US0 = US0_3
                                                let v2070 : (unit -> string) = closure10()
                                                let v2071 : (unit -> string) = closure11(v2068)
                                                method5(v2069, v2070, v2071)
                                                US3_1
                                            | US12_0(v2066) -> (* Ok *)
                                                US3_0(v2066)
                                        let v2089 : US3 =
                                            match v2074 with
                                            | US3_1 -> (* None *)
                                                let v2077 : string = method15(v1902, v1903)
                                                let v2078 : US12 = method18(v2077, v2063)
                                                match v2078 with
                                                | US12_1(v2081) -> (* Error *)
                                                    let v2082 : US0 = US0_3
                                                    let v2083 : (unit -> string) = closure10()
                                                    let v2084 : (unit -> string) = closure11(v2081)
                                                    method5(v2082, v2083, v2084)
                                                    US3_1
                                                | US12_0(v2079) -> (* Ok *)
                                                    US3_0(v2079)
                                            | US3_0(v2075) -> (* Some *)
                                                US3_0(v2075)
                                        let v2093 : string =
                                            match v2089 with
                                            | US3_1 -> (* None *)
                                                failwith<string> "Option does not have a value."
                                            | US3_0(v2090) -> (* Some *)
                                                v2090
                                        let v2094 : string = method15(v2093, v1902)
                                        let v2095 : string = method14()
                                        let v2096 : (unit -> string) = v2095.ToLower
                                        let v2097 : string = v2096 ()
                                        let v2098 : (unit -> string) = v2094.ToLower
                                        let v2099 : string = v2098 ()
                                        let v2100 : bool = v2097.StartsWith v2099 
                                        let v2103 : US12 =
                                            if v2100 then
                                                US12_1(v2099)
                                            else
                                                US12_0(v2099)
                                        let v2109 : Result<string, string> =
                                            match v2103 with
                                            | US12_1(v2106) -> (* Error *)
                                                let v2107 : Result<string, string> = Error v2106 
                                                v2107
                                            | US12_0(v2104) -> (* Ok *)
                                                let v2105 : Result<string, string> = Ok v2104 
                                                v2105
                                        let v2110 : string = "true; let _result = $0.unwrap_or_else(|x| { //"
                                        let v2111 : bool = Fable.Core.RustInterop.emitRustExpr v2109 v2110 
                                        let v2112 : string = "x"
                                        let v2113 : string = Fable.Core.RustInterop.emitRustExpr () v2112 
                                        let v2114 : string = "true; $0 })"
                                        let v2115 : bool = Fable.Core.RustInterop.emitRustExpr v2113 v2114 
                                        let v2116 : string = "_result"
                                        let v2117 : string = Fable.Core.RustInterop.emitRustExpr () v2116 
                                        let v2118 : string = "lib/python/fable/fable_modules"
                                        let v2119 : string = method15(v2117, v2118)
                                        let v2120 : string = $"fable-library-{v1897}"
                                        let v2121 : string = method15(v2119, v2120)
                                        let v2122 : string = $"fable_modules/fable-library"
                                        let v2123 : string = method15(v2061, v2122)
                                        method98(v2121, v2123)
                                        let struct (v2124 : int32, v2125 : string) = method99(v2061, v1897, v1962, v2103)
                                        let v2126 : bool = v2124 <> 0 
                                        if v2126 then
                                            let v2127 : US0 = US0_4
                                            let v2128 : (unit -> string) = closure109(v2125, v2124)
                                            let v2129 : (unit -> string) = closure6()
                                            method5(v2127, v2128, v2129)
                                            let v2130 : US3 = US3_1
                                            let v2131 : US3 = US3_0(v1897)
                                            let v2132 : US3 = US3_0(v2125)
                                            struct (v2130, v2131, v2132)
                                        else
                                            let v2133 : string = "true; let _result : Vec<_> = v1870.into_iter().map(|x| { //"
                                            let v2134 : bool = Fable.Core.RustInterop.emitRustExpr () v2133 
                                            let v2135 : string = "x"
                                            let v2136 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v2135 
                                            let v2137 : string = "fable_library_rust::String_::fromString($0)"
                                            let v2138 : string = Fable.Core.RustInterop.emitRustExpr v2136 v2137 
                                            let v2139 : string = "="
                                            let v2140 : bool = v2138.Contains v2139 
                                            let v2142 : string =
                                                if v2140 then
                                                    v2138
                                                else
                                                    let v2141 : string = $"\"{v2138}\":\"*\""
                                                    v2141
                                            let v2143 : string = "true; $0 }).collect::<Vec<_>>()"
                                            let v2144 : bool = Fable.Core.RustInterop.emitRustExpr v2142 v2143 
                                            let v2145 : string = "_result"
                                            let v2146 : Vec<string> = Fable.Core.RustInterop.emitRustExpr () v2145 
                                            let v2147 : string = "fable_library_rust::NativeArray_::array_from($0)"
                                            let v2148 : (string []) = Fable.Core.RustInterop.emitRustExpr v2146 v2147 
                                            let v2149 : string seq = seq { for i = 0 to v2148.Length - 1 do yield v2148.[i] }
                                            let v2150 : (string -> (string seq -> string)) = String.concat
                                            let v2151 : string = ",\n"
                                            let v2152 : (string seq -> string) = v2150 v2151
                                            let v2153 : string = v2152 v2149
                                            let v2154 : string = $"{{"
                                            let v2155 : string = $"  \"name\": \"spiral_builder_{v1899}\","
                                            let v2156 : string = v2154 + v2155 
                                            let v2157 : string = $"  \"dependencies\": {{"
                                            let v2158 : string = v2156 + v2157 
                                            let v2159 : string = v2158 + v2153 
                                            let v2160 : string = $"  }},"
                                            let v2161 : string = v2159 + v2160 
                                            let v2162 : string = $"    \"devDependencies\": {{"
                                            let v2163 : string = v2161 + v2162 
                                            let v2164 : string = $"  }},"
                                            let v2165 : string = v2163 + v2164 
                                            let v2166 : string = $"}}"
                                            let v2167 : string = v2165 + v2166 
                                            let v2168 : string = "package.json"
                                            let v2169 : string = method15(v2061, v2168)
                                            let v2170 : string = "../.."
                                            let v2171 : string = method15(v2061, v2170)
                                            let v2172 : string = method15(v2171, v2168)
                                            method24(v2169, v2167)
                                            let v2173 : string = ""
                                            method24(v2172, v2173)
                                            let v2174 : string = $"{v1937}.{v1897}"
                                            let v2175 : string = method15(v2061, v2174)
                                            let v2176 : US0 = US0_1
                                            let v2177 : (unit -> string) = closure110()
                                            let v2178 : (unit -> string) = closure111(v2175)
                                            method5(v2176, v2177, v2178)
                                            let v2179 : bool = true
                                            let mutable _v2179 : string option = None 
                                            
#if FABLE_COMPILER || WASM || CONTRACT
                                            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                            let v2180 : bool = true
                                            let mutable _v2180 : Vec<uint8> option = None 
                                            
#if FABLE_COMPILER || WASM || CONTRACT
                                            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                            let v2181 : string = "std::fs::read(&*$0).unwrap()"
                                            let v2182 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v2175 v2181 
                                            v2182 
                                            #endif
#if FABLE_COMPILER_RUST && WASM
                                            let v2183 : Vec<uint8> = null |> unbox<Vec<uint8>>
                                            v2183 
                                            #endif
#if FABLE_COMPILER_RUST && CONTRACT
                                            let v2184 : Vec<uint8> = null |> unbox<Vec<uint8>>
                                            v2184 
                                            #endif
#if FABLE_COMPILER_TYPESCRIPT
                                            let v2185 : Vec<uint8> = null |> unbox<Vec<uint8>>
                                            v2185 
                                            #endif
#if FABLE_COMPILER_PYTHON
                                            let v2186 : Vec<uint8> = null |> unbox<Vec<uint8>>
                                            v2186 
                                            #endif
#else
                                            let v2187 : (uint8 []) = v2175 |> System.IO.File.ReadAllBytes
                                            let v2188 : string = "$0.to_vec()"
                                            let v2189 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v2187 v2188 
                                            v2189 
                                            #endif
                                            |> fun x -> _v2180 <- Some x
                                            let v2190 : Vec<uint8> = match _v2180 with Some x -> x | None -> failwith "base.run_target / _v2180=None"
                                            let v2191 : string = "std::string::String::from_utf8(v2190)"
                                            let v2192 : Result<std_string_String, std_string_FromUtf8Error> = Fable.Core.RustInterop.emitRustExpr () v2191 
                                            let v2193 : string = "$0.unwrap()"
                                            let v2194 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2192 v2193 
                                            let v2195 : string = "fable_library_rust::String_::fromString($0)"
                                            let v2196 : string = Fable.Core.RustInterop.emitRustExpr v2194 v2195 
                                            v2196 
                                            #endif
#if FABLE_COMPILER_RUST && WASM
                                            let v2197 : string = null |> unbox<string>
                                            v2197 
                                            #endif
#if FABLE_COMPILER_RUST && CONTRACT
                                            let v2198 : string = null |> unbox<string>
                                            v2198 
                                            #endif
#if FABLE_COMPILER_TYPESCRIPT
                                            let v2199 : string = null |> unbox<string>
                                            v2199 
                                            #endif
#if FABLE_COMPILER_PYTHON
                                            let v2200 : string = null |> unbox<string>
                                            v2200 
                                            #endif
#else
                                            let v2201 : string = v2175 |> System.IO.File.ReadAllText
                                            v2201 
                                            #endif
                                            |> fun x -> _v2179 <- Some x
                                            let v2202 : string = match _v2179 with Some x -> x | None -> failwith "base.run_target / _v2179=None"
                                            let v2203 : string = "# spiral_builder.process_python"
                                            let v2204 : bool = v2202.Contains v2203 
                                            let v2232 : string =
                                                if v2204 then
                                                    v2202
                                                else
                                                    let v2205 : string = "\";\".into()"
                                                    let v2206 : string = Fable.Core.RustInterop.emitRustExpr () v2205 
                                                    let v2207 : string = "),)"
                                                    let v2208 : string = v2207 + v2206 
                                                    let v2209 : string = "));"
                                                    let v2210 : string = v2202.Replace (v2208, v2209)
                                                    let v2211 : string = method103()
                                                    let v2212 : bool = true
                                                    let mutable _v2212 : string option = None 
                                                    
#if FABLE_COMPILER || WASM || CONTRACT
                                                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                                    let v2213 : string = method72(v2210)
                                                    let v2214 : string = $"regex::Regex::new(&$0)"
                                                    let v2215 : string = "\\s\\sdefaultOf\\(\\);"
                                                    let v2216 : Result<regex_Regex, regex_Error> = Fable.Core.RustInterop.emitRustExpr v2215 v2214 
                                                    let v2217 : string = "$0.unwrap()"
                                                    let v2218 : regex_Regex = Fable.Core.RustInterop.emitRustExpr v2216 v2217 
                                                    let v2219 : string = $"$0.replace_all(&$1, &*$2)"
                                                    let v2220 : std_borrow_Cow<Str> = Fable.Core.RustInterop.emitRustExpr struct (v2218, v2213, v2211) v2219 
                                                    let v2221 : string = "String::from($0)"
                                                    let v2222 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2220 v2221 
                                                    let v2223 : string = "fable_library_rust::String_::fromString($0)"
                                                    let v2224 : string = Fable.Core.RustInterop.emitRustExpr v2222 v2223 
                                                    v2224 
                                                    #endif
#if FABLE_COMPILER_RUST && WASM
                                                    let v2225 : string = null |> unbox<string>
                                                    v2225 
                                                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                                                    let v2226 : string = null |> unbox<string>
                                                    v2226 
                                                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                                                    let v2227 : string = null |> unbox<string>
                                                    v2227 
                                                    #endif
#if FABLE_COMPILER_PYTHON
                                                    let v2228 : string = null |> unbox<string>
                                                    v2228 
                                                    #endif
#else
                                                    let v2229 : string = method104()
                                                    let v2230 : string = System.Text.RegularExpressions.Regex.Replace (v2210, v2229, v2211)
                                                    v2230 
                                                    #endif
                                                    |> fun x -> _v2212 <- Some x
                                                    let v2231 : string = match _v2212 with Some x -> x | None -> failwith "base.run_target / _v2212=None"
                                                    v2231
                                            let v2233 : bool = v2204 = false
                                            if v2233 then
                                                let v2234 : string = $"{v2232}\n\n{v2203}\n"
                                                method24(v2175, v2234)
                                            let v2235 : string = $"python \"{v2175}\""
                                            let v2236 : string = "TRACE_LEVEL"
                                            let v2237 : string = "Verbose"
                                            let v2238 : (struct (string * string) []) = [|struct (v2236, v2237)|]
                                            let v2239 : System.Threading.CancellationToken option = None
                                            let v2240 : (struct (string * string) []) = [||]
                                            let v2241 : (struct (bool * string * int32) -> Async<unit>) option = None
                                            let v2242 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = None
                                            let v2243 : string option = None
                                            let v2249 : Result<string, string> =
                                                match v2103 with
                                                | US12_1(v2246) -> (* Error *)
                                                    let v2247 : Result<string, string> = Error v2246 
                                                    v2247
                                                | US12_0(v2244) -> (* Ok *)
                                                    let v2245 : Result<string, string> = Ok v2244 
                                                    v2245
                                            let v2250 : string = "v2249.ok()"
                                            let v2251 : string option = Fable.Core.RustInterop.emitRustExpr () v2250 
                                            let v2252 : bool = true
                                            let struct (v2253 : int32, v2254 : string) = method28(v2239, v2235, v2238, v2241, v2242, v2252, v2251)
                                            let v2255 : int32 = v2238.Length
                                            let v2256 : (string []) = Array.zeroCreate<string> (v2255)
                                            let v2257 : Mut4 = {l0 = 0} : Mut4
                                            while method32(v2255, v2257) do
                                                let v2259 : int32 = v2257.l0
                                                let struct (v2260 : string, v2261 : string) = v2238.[int v2259]
                                                let v2262 : string = $"$env:{v2260}=''{v2261}''"
                                                v2256.[int v2259] <- v2262
                                                let v2263 : int32 = v2259 + 1
                                                v2257.l0 <- v2263
                                                ()
                                            let v2264 : ((string []) -> string seq) = Seq.ofArray
                                            let v2265 : string seq = v2264 v2256
                                            let v2266 : (string -> (string seq -> string)) = String.concat
                                            let v2267 : string = ";"
                                            let v2268 : (string seq -> string) = v2266 v2267
                                            let v2269 : string = v2268 v2265
                                            let v2270 : string = $"pwsh -c '{v2269}; {v2235}'"
                                            let v2271 : bool = v2253 = 0
                                            if v2271 then
                                                let v2272 : (unit -> string) = closure112(v2254)
                                                let v2273 : (string -> US3) = closure45()
                                                let v2274 : (exn -> US3) = closure113(v2175, v2254, v2270)
                                                let v2275 : US3 = try v2272 () |> v2273 with ex -> v2274 ex 
                                                let v2280 : string option =
                                                    match v2275 with
                                                    | US3_1 -> (* None *)
                                                        let v2278 : string option = None
                                                        v2278
                                                    | US3_0(v2276) -> (* Some *)
                                                        let v2277 : string option = Some v2276 
                                                        v2277
                                                let v2281 : string = "$0.unwrap()"
                                                let v2282 : string = Fable.Core.RustInterop.emitRustExpr v2280 v2281 
                                                let v2283 : US3 = US3_0(v2232)
                                                let v2284 : US3 = US3_0(v1897)
                                                let v2285 : US3 = US3_0(v2282)
                                                struct (v2283, v2284, v2285)
                                            else
                                                let v2286 : US0 = US0_4
                                                let v2287 : (unit -> string) = closure116()
                                                let v2288 : (unit -> string) = closure117(v2175, v2254, v2253, v2270)
                                                method5(v2286, v2287, v2288)
                                                let v2289 : US3 = US3_1
                                                let v2290 : US3 = US3_0(v1897)
                                                let v2291 : US3 = US3_1
                                                struct (v2289, v2290, v2291)
                                    else
                                        let v2298 : US0 = US0_1
                                        let v2299 : (unit -> string) = closure118()
                                        let v2300 : (unit -> string) = closure119(v14, v13)
                                        method5(v2298, v2299, v2300)
                                        let v2301 : US3 = US3_1
                                        let v2302 : US3 = US3_1
                                        let v2303 : US3 = US3_1
                                        struct (v2301, v2302, v2303)
                        let v2316 : string =
                            match v2311 with
                            | US3_1 -> (* None *)
                                let v2314 : string = ""
                                v2314
                            | US3_0(v2313) -> (* Some *)
                                v2313
                        let v2317 : string = "extension"
                        let v2321 : string =
                            match v2310 with
                            | US3_1 -> (* None *)
                                let v2319 : string = ""
                                v2319
                            | US3_0(v2318) -> (* Some *)
                                v2318
                        let v2322 : string = "code"
                        let v2326 : string =
                            match v2312 with
                            | US3_1 -> (* None *)
                                let v2324 : string = ""
                                v2324
                            | US3_0(v2323) -> (* Some *)
                                v2323
                        let v2327 : string = "output"
                        [|struct (v2317, v2316); struct (v2322, v2321); struct (v2327, v2326)|]
        | _ ->
            let v2332 : string = "extension"
            let v2333 : string = ""
            let v2334 : string = "code"
            let v2335 : string = "output"
            [|struct (v2332, v2333); struct (v2334, v2333); struct (v2335, v2333)|]
    let v2338 : string = "$0.to_vec()"
    let v2339 : Vec<struct (string * string)> = Fable.Core.RustInterop.emitRustExpr v2337 v2338 
    let v2340 : string = "$0.into_iter().map(|x| $1(x.clone())).collect::<Vec<_>>()"
    let v2341 : (struct (string * string) -> (std_string_String * std_string_String)) = closure120()
    let v2342 : Vec<(std_string_String * std_string_String)> = Fable.Core.RustInterop.emitRustExpr struct (v2339, v2341) v2340 
    let v2343 : string = "std::collections::BTreeMap::from_iter(v2342.iter().map(|x| x.as_ref()).map(|&(ref k, ref v)| (k.clone(), v.clone())))"
    let v2344 : std_collections_BTreeMap<std_string_String, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v2343 
    let v2345 : string = "serde_json::to_string(&v2344)"
    let v2346 : Result<std_string_String, serde_json_Error> = Fable.Core.RustInterop.emitRustExpr () v2345 
    let v2347 : (serde_json_Error -> string) = method115()
    let v2348 : string = "$0.map_err(|x| $1(x))"
    let v2349 : Result<std_string_String, string> = Fable.Core.RustInterop.emitRustExpr struct (v2346, v2347) v2348 
    let v2350 : string = "true; let _result = $0.map(|x| { //"
    let v2351 : bool = Fable.Core.RustInterop.emitRustExpr v2349 v2350 
    let v2352 : string = "x"
    let v2353 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v2352 
    let v2354 : string = "fable_library_rust::String_::fromString($0)"
    let v2355 : string = Fable.Core.RustInterop.emitRustExpr v2353 v2354 
    let v2356 : string = "true; $0 })"
    let v2357 : bool = Fable.Core.RustInterop.emitRustExpr v2355 v2356 
    let v2358 : string = "_result"
    let v2359 : Result<string, string> = Fable.Core.RustInterop.emitRustExpr () v2358 
    let v2360 : Result<string, string> = method116(v2359)
    let v2361 : string = ""
    let v2362 : string = "}"
    let v2363 : string = v2361 + v2362 
    let v2364 : string = v2363 + v2362 
    let v2365 : string = v2364 + v2362 
    let v2366 : string = "{"
    let v2367 : string = v2361 + v2366 
    let v2368 : string = v2367 + v2366 
    let v2369 : string = "v2360 " + v2365 + "); " + v2368 + " //"
    Fable.Core.RustInterop.emitRustExpr () v2369 
    let v2370 : string = "__result"
    let v2371 : std_pin_Pin<Box<Dyn<std_future_Future<Result<string, string>>>>> = Fable.Core.RustInterop.emitRustExpr () v2370 
    v2371
and closure1 () (v0 : (string [])) : int32 =
    let v1 : (US0 -> struct (Mut0 * Mut1 * Mut2 * int64 option * Mut3)) = closure2()
    let v2 : US0 = US0_0
    if State.trace_state.IsNone then State.trace_state <- v1 v2 |> Some
    let struct (v3 : Mut0, v4 : Mut1, v5 : Mut2, v6 : int64 option, v7 : Mut3) = State.trace_state.Value
    let v8 : US0 = US0_1
    let v9 : (unit -> string) = closure4()
    let v10 : (unit -> string) = closure5(v0)
    method5(v8, v9, v10)
    let v11 : clap_Command = method0()
    let v12 : string = "clap::Command::get_matches($0)"
    let v13 : clap_ArgMatches = Fable.Core.RustInterop.emitRustExpr v11 v12 
    let v14 : US0 = v5.l0
    let v15 : std_pin_Pin<Box<Dyn<std_future_Future<Result<string, string>>>>> = method10(v14, v13)
    let v16 : string = $"tokio::runtime::Builder::new_multi_thread().enable_all().build().unwrap()"
    let v17 : _ = Fable.Core.RustInterop.emitRustExpr () v16 
    let v18 : string = "v17.handle().block_on($0)"
    let v19 : Result<string, string> = Fable.Core.RustInterop.emitRustExpr v15 v18 
    let v20 : string = "$0.unwrap()"
    let v21 : string = Fable.Core.RustInterop.emitRustExpr v19 v20 
    let v22 : US0 = v5.l0
    let v24 : bool =
        match v22 with
        | US0_2 -> (* Info *)
            true
        | _ ->
            false
    if v24 then
        let v25 : (string -> unit) = System.Console.WriteLine
        v25 v21
    0
let v0 : (unit -> unit) = closure0()
let tests () = v0 ()
let v1 : ((string []) -> int32) = closure1()
let main args = v1 args
()
