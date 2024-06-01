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
#if FABLE_COMPILER
[<CompilationRepresentation (CompilationRepresentationFlags.ModuleSuffix)>]
module System =
 module Diagnostics =
  type Process = unit
  type DataReceivedEventArgs = unit
#endif
type ICryptoCreateHash = abstract createHash: x: string -> obj
type IHashlibSha256 = abstract sha256: x: unit -> obj
type IFsExistsSync = abstract existsSync: path: string -> bool
type IPathDirname = abstract dirname: path: string -> string
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
and [<Struct>] US6 =
    | US6_0 of f0_0 : (string [])
    | US6_1 of f1_0 : string
and UH0 =
    | UH0_0
    | UH0_1 of string * UH0
and [<Struct>] US7 =
    | US7_0 of f0_0 : UH0 * f0_1 : string * f0_2 : System.Text.StringBuilder * f0_3 : int32 * f0_4 : int32
    | US7_1 of f1_0 : string
and [<Struct>] US8 =
    | US8_0 of f0_0 : char * f0_1 : string * f0_2 : System.Text.StringBuilder * f0_3 : int32 * f0_4 : int32
    | US8_1 of f1_0 : string
and [<Struct>] US9 =
    | US9_0 of f0_0 : char
    | US9_1
and Mut4 = {mutable l0 : int32}
and UH1 =
    | UH1_0
    | UH1_1 of char * UH1
and [<Struct>] US10 =
    | US10_0 of f0_0 : string * f0_1 : string * f0_2 : System.Text.StringBuilder * f0_3 : int32 * f0_4 : int32
    | US10_1 of f1_0 : string
and UH2 =
    | UH2_0
    | UH2_1 of (struct (string * System.Text.StringBuilder * int32 * int32) -> US10) * UH2
and [<Struct>] US11 =
    | US11_0 of f0_0 : string * f0_1 : System.Text.StringBuilder * f0_2 : int32 * f0_3 : int32
    | US11_1 of f1_0 : string
and [<Struct>] US12 =
    | US12_0 of f0_0 : (string [])
    | US12_1 of f1_0 : string
and [<Struct>] US13 =
    | US13_0
    | US13_1
    | US13_2
and [<Struct>] US14 =
    | US14_0 of f0_0 : US13
    | US14_1 of f1_0 : US13
    | US14_2 of f2_0 : US13
    | US14_3 of f3_0 : US13
and Mut5 = {mutable l0 : int32; mutable l1 : int32; mutable l2 : (string [])}
and [<Struct>] US16 =
    | US16_0
    | US16_1
and [<Struct>] US15 =
    | US15_0
    | US15_1 of f1_0 : US16
    | US15_2
and [<Struct>] US17 =
    | US17_0 of f0_0 : std_sync_Arc<std_sync_Mutex<std_process_Child option>>
    | US17_1 of f1_0 : std_string_String
and [<Struct>] US18 =
    | US18_0 of f0_0 : std_sync_Arc<std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>>
    | US18_1
and [<Struct>] US19 =
    | US19_0 of f0_0 : std_string_String
    | US19_1 of f1_0 : std_string_String
and [<Struct>] US20 =
    | US20_0 of f0_0 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit)
    | US20_1
and [<Struct>] US21 =
    | US21_0 of f0_0 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>>
    | US21_1
and [<Struct>] US22 =
    | US22_0 of f0_0 : std_process_Output
    | US22_1 of f1_0 : std_string_String
and [<Struct>] US23 =
    | US23_0 of f0_0 : (struct (bool * string * int32) -> Async<unit>)
    | US23_1
and [<Struct>] US24 =
    | US24_0 of f0_0 : System.Threading.CancellationToken
    | US24_1
and [<Struct>] US25 =
    | US25_0 of f0_0 : Vec<std_string_String>
    | US25_1
and [<Struct>] US26 =
    | US26_0
    | US26_1 of f1_0 : std_string_String
and [<Struct>] US27 =
    | US27_0 of f0_0 : chrono_DateTime<chrono_Utc>
    | US27_1
and [<Struct>] US28 =
    | US28_0 of f0_0 : string
    | US28_1 of f1_0 : string
and [<Struct>] US29 =
    | US29_0 of f0_0 : int32 * f0_1 : string
    | US29_1 of f1_0 : int32 * f1_1 : string
and [<Struct>] US30 =
    | US30_0 of f0_0 : std_collections_HashMap<string, string>
    | US30_1
and [<Struct>] US31 =
    | US31_0 of f0_0 : US3
    | US31_1
and UH3 =
    | UH3_0
    | UH3_1 of string * bool * UH3
and [<Struct>] US32 =
    | US32_0
    | US32_1
    | US32_2
and [<Struct>] US33 =
    | US33_0 of f0_0 : std_fs_FileType
    | US33_1 of f1_0 : std_string_String
and [<Struct>] US34 =
    | US34_0 of f0_0 : async_walkdir_DirEntry
    | US34_1 of f1_0 : std_string_String
and [<Struct>] US35 =
    | US35_0 of f0_0 : string * f0_1 : string
    | US35_1
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
    let v12 : string = "fs-path"
    let v13 : string = "r#\"" + v12 + "\"#"
    let v14 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v13 
    let v15 : string = "clap::Arg::new($0)"
    let v16 : clap_Arg = Fable.Core.RustInterop.emitRustExpr v14 v15 
    let v17 : string = "$0.short($1)"
    let v18 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v16, 'f') v17 
    let v19 : string = "r#\"" + v12 + "\"#"
    let v20 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v19 
    let v21 : string = "$0.long($1)"
    let v22 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v18, v20) v21 
    let v23 : string = "$0.required($1)"
    let v24 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v22, true) v23 
    let v25 : string = "clap::Command::arg($0, $1)"
    let v26 : clap_Command = Fable.Core.RustInterop.emitRustExpr struct (v11, v24) v25 
    let v27 : string = "r#\"" + v0 + "\"#"
    let v28 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v27 
    let v29 : string = "clap::Arg::new($0)"
    let v30 : clap_Arg = Fable.Core.RustInterop.emitRustExpr v28 v29 
    let v31 : string = "$0.short($1)"
    let v32 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v30, 'c') v31 
    let v33 : string = "r#\"" + v0 + "\"#"
    let v34 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v33 
    let v35 : string = "$0.long($1)"
    let v36 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v32, v34) v35 
    let v37 : string = "clap::Command::arg($0, $1)"
    let v38 : clap_Command = Fable.Core.RustInterop.emitRustExpr struct (v26, v36) v37 
    let v39 : string = "clap::Command::subcommand($0, v38)"
    let v40 : clap_Command = Fable.Core.RustInterop.emitRustExpr v6 v39 
    let v41 : string = "rust"
    let v42 : string = "r#\"" + v41 + "\"#"
    let v43 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v42 
    let v44 : string = "clap::Command::new($0)"
    let v45 : clap_Command = Fable.Core.RustInterop.emitRustExpr v43 v44 
    let v46 : string = "r#\"" + v12 + "\"#"
    let v47 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v46 
    let v48 : string = "clap::Arg::new($0)"
    let v49 : clap_Arg = Fable.Core.RustInterop.emitRustExpr v47 v48 
    let v50 : string = "$0.short($1)"
    let v51 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v49, 'f') v50 
    let v52 : string = "r#\"" + v12 + "\"#"
    let v53 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v52 
    let v54 : string = "$0.long($1)"
    let v55 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v51, v53) v54 
    let v56 : string = "$0.required($1)"
    let v57 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v55, true) v56 
    let v58 : string = "clap::Command::arg($0, $1)"
    let v59 : clap_Command = Fable.Core.RustInterop.emitRustExpr struct (v45, v57) v58 
    let v60 : string = "NAME"
    let v61 : string = "r#\"" + v60 + "\"#"
    let v62 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v61 
    let v63 : string = "VERSION"
    let v64 : string = "r#\"" + v63 + "\"#"
    let v65 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v64 
    let v66 : (Ref<Lifetime<StaticLifetime, Str>> []) = [|v62; v65|]
    let v67 : unativeint = 1 |> unativeint 
    let v68 : unativeint = 0 |> unativeint 
    let v69 : bool = v68 = v68 
    let v74 : clap_builder_ValueRange =
        if v69 then
            let v70 : string = "clap::builder::ValueRange::new(v67..)"
            let v71 : clap_builder_ValueRange = Fable.Core.RustInterop.emitRustExpr () v70 
            v71
        else
            let v72 : string = "clap::builder::ValueRange::new(v67..v68)"
            let v73 : clap_builder_ValueRange = Fable.Core.RustInterop.emitRustExpr () v72 
            v73
    let v75 : string = "deps"
    let v76 : string = "r#\"" + v75 + "\"#"
    let v77 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v76 
    let v78 : string = "clap::Arg::new($0)"
    let v79 : clap_Arg = Fable.Core.RustInterop.emitRustExpr v77 v78 
    let v80 : string = "$0.short($1)"
    let v81 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v79, 'd') v80 
    let v82 : string = "r#\"" + v75 + "\"#"
    let v83 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v82 
    let v84 : string = "$0.long($1)"
    let v85 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v81, v83) v84 
    let v86 : string = "$0.to_vec()"
    let v87 : Vec<Ref<Lifetime<StaticLifetime, Str>>> = Fable.Core.RustInterop.emitRustExpr v66 v86 
    let v88 : string = "$0.value_names($1)"
    let v89 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v85, v87) v88 
    let v90 : string = "$0.num_args($1)"
    let v91 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v89, v74) v90 
    let v92 : string = "clap::ArgAction::Append"
    let v93 : clap_ArgAction = Fable.Core.RustInterop.emitRustExpr () v92 
    let v94 : string = "$0.action($1)"
    let v95 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v91, v93) v94 
    let v96 : string = "clap::Command::arg($0, $1)"
    let v97 : clap_Command = Fable.Core.RustInterop.emitRustExpr struct (v59, v95) v96 
    let v98 : string = "clap::Command::subcommand($0, v97)"
    let v99 : clap_Command = Fable.Core.RustInterop.emitRustExpr v40 v98 
    let v100 : string = "dib"
    let v101 : string = "r#\"" + v100 + "\"#"
    let v102 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v101 
    let v103 : string = "clap::Command::new($0)"
    let v104 : clap_Command = Fable.Core.RustInterop.emitRustExpr v102 v103 
    let v105 : string = "path"
    let v106 : string = "r#\"" + v105 + "\"#"
    let v107 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v106 
    let v108 : string = "clap::Arg::new($0)"
    let v109 : clap_Arg = Fable.Core.RustInterop.emitRustExpr v107 v108 
    let v110 : string = "$0.short($1)"
    let v111 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v109, 'p') v110 
    let v112 : string = "r#\"" + v105 + "\"#"
    let v113 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v112 
    let v114 : string = "$0.long($1)"
    let v115 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v111, v113) v114 
    let v116 : string = "$0.required($1)"
    let v117 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v115, true) v116 
    let v118 : string = "clap::Command::arg($0, $1)"
    let v119 : clap_Command = Fable.Core.RustInterop.emitRustExpr struct (v104, v117) v118 
    let v120 : string = "u8"
    let v121 : string = "clap::value_parser!(" + v120 + ").into()"
    let v122 : clap_builder_ValueParser = Fable.Core.RustInterop.emitRustExpr () v121 
    let v123 : string = "retries"
    let v124 : string = "r#\"" + v123 + "\"#"
    let v125 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v124 
    let v126 : string = "clap::Arg::new($0)"
    let v127 : clap_Arg = Fable.Core.RustInterop.emitRustExpr v125 v126 
    let v128 : string = "$0.short($1)"
    let v129 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v127, 'r') v128 
    let v130 : string = "r#\"" + v123 + "\"#"
    let v131 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v130 
    let v132 : string = "$0.long($1)"
    let v133 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v129, v131) v132 
    let v134 : string = "$0.value_parser($1)"
    let v135 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v133, v122) v134 
    let v136 : string = "clap::Command::arg($0, $1)"
    let v137 : clap_Command = Fable.Core.RustInterop.emitRustExpr struct (v119, v135) v136 
    let v138 : string = "working-directory"
    let v139 : string = "r#\"" + v138 + "\"#"
    let v140 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v139 
    let v141 : string = "clap::Arg::new($0)"
    let v142 : clap_Arg = Fable.Core.RustInterop.emitRustExpr v140 v141 
    let v143 : string = "$0.short($1)"
    let v144 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v142, 'w') v143 
    let v145 : string = "r#\"" + v138 + "\"#"
    let v146 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v145 
    let v147 : string = "$0.long($1)"
    let v148 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v144, v146) v147 
    let v149 : string = "clap::Command::arg($0, $1)"
    let v150 : clap_Command = Fable.Core.RustInterop.emitRustExpr struct (v137, v148) v149 
    let v151 : string = "clap::Command::subcommand($0, v150)"
    let v152 : clap_Command = Fable.Core.RustInterop.emitRustExpr v99 v151 
    let v153 : string = "typescript"
    let v154 : string = "r#\"" + v153 + "\"#"
    let v155 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v154 
    let v156 : string = "clap::Command::new($0)"
    let v157 : clap_Command = Fable.Core.RustInterop.emitRustExpr v155 v156 
    let v158 : string = "r#\"" + v12 + "\"#"
    let v159 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v158 
    let v160 : string = "clap::Arg::new($0)"
    let v161 : clap_Arg = Fable.Core.RustInterop.emitRustExpr v159 v160 
    let v162 : string = "$0.short($1)"
    let v163 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v161, 'f') v162 
    let v164 : string = "r#\"" + v12 + "\"#"
    let v165 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v164 
    let v166 : string = "$0.long($1)"
    let v167 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v163, v165) v166 
    let v168 : string = "$0.required($1)"
    let v169 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v167, true) v168 
    let v170 : string = "clap::Command::arg($0, $1)"
    let v171 : clap_Command = Fable.Core.RustInterop.emitRustExpr struct (v157, v169) v170 
    let v172 : string = "r#\"" + v60 + "\"#"
    let v173 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v172 
    let v174 : string = "r#\"" + v63 + "\"#"
    let v175 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v174 
    let v176 : (Ref<Lifetime<StaticLifetime, Str>> []) = [|v173; v175|]
    let v177 : unativeint = 1 |> unativeint 
    let v178 : unativeint = 0 |> unativeint 
    let v179 : bool = v178 = v178 
    let v184 : clap_builder_ValueRange =
        if v179 then
            let v180 : string = "clap::builder::ValueRange::new(v177..)"
            let v181 : clap_builder_ValueRange = Fable.Core.RustInterop.emitRustExpr () v180 
            v181
        else
            let v182 : string = "clap::builder::ValueRange::new(v177..v178)"
            let v183 : clap_builder_ValueRange = Fable.Core.RustInterop.emitRustExpr () v182 
            v183
    let v185 : string = "r#\"" + v75 + "\"#"
    let v186 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v185 
    let v187 : string = "clap::Arg::new($0)"
    let v188 : clap_Arg = Fable.Core.RustInterop.emitRustExpr v186 v187 
    let v189 : string = "$0.short($1)"
    let v190 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v188, 'd') v189 
    let v191 : string = "r#\"" + v75 + "\"#"
    let v192 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v191 
    let v193 : string = "$0.long($1)"
    let v194 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v190, v192) v193 
    let v195 : string = "$0.to_vec()"
    let v196 : Vec<Ref<Lifetime<StaticLifetime, Str>>> = Fable.Core.RustInterop.emitRustExpr v176 v195 
    let v197 : string = "$0.value_names($1)"
    let v198 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v194, v196) v197 
    let v199 : string = "$0.num_args($1)"
    let v200 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v198, v184) v199 
    let v201 : string = "clap::ArgAction::Append"
    let v202 : clap_ArgAction = Fable.Core.RustInterop.emitRustExpr () v201 
    let v203 : string = "$0.action($1)"
    let v204 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v200, v202) v203 
    let v205 : string = "clap::Command::arg($0, $1)"
    let v206 : clap_Command = Fable.Core.RustInterop.emitRustExpr struct (v171, v204) v205 
    let v207 : string = "clap::Command::subcommand($0, v206)"
    let v208 : clap_Command = Fable.Core.RustInterop.emitRustExpr v152 v207 
    let v209 : string = "python"
    let v210 : string = "r#\"" + v209 + "\"#"
    let v211 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v210 
    let v212 : string = "clap::Command::new($0)"
    let v213 : clap_Command = Fable.Core.RustInterop.emitRustExpr v211 v212 
    let v214 : string = "r#\"" + v12 + "\"#"
    let v215 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v214 
    let v216 : string = "clap::Arg::new($0)"
    let v217 : clap_Arg = Fable.Core.RustInterop.emitRustExpr v215 v216 
    let v218 : string = "$0.short($1)"
    let v219 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v217, 'f') v218 
    let v220 : string = "r#\"" + v12 + "\"#"
    let v221 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v220 
    let v222 : string = "$0.long($1)"
    let v223 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v219, v221) v222 
    let v224 : string = "$0.required($1)"
    let v225 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v223, true) v224 
    let v226 : string = "clap::Command::arg($0, $1)"
    let v227 : clap_Command = Fable.Core.RustInterop.emitRustExpr struct (v213, v225) v226 
    let v228 : string = "r#\"" + v60 + "\"#"
    let v229 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v228 
    let v230 : string = "r#\"" + v63 + "\"#"
    let v231 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v230 
    let v232 : (Ref<Lifetime<StaticLifetime, Str>> []) = [|v229; v231|]
    let v233 : unativeint = 1 |> unativeint 
    let v234 : unativeint = 0 |> unativeint 
    let v235 : bool = v234 = v234 
    let v240 : clap_builder_ValueRange =
        if v235 then
            let v236 : string = "clap::builder::ValueRange::new(v233..)"
            let v237 : clap_builder_ValueRange = Fable.Core.RustInterop.emitRustExpr () v236 
            v237
        else
            let v238 : string = "clap::builder::ValueRange::new(v233..v234)"
            let v239 : clap_builder_ValueRange = Fable.Core.RustInterop.emitRustExpr () v238 
            v239
    let v241 : string = "r#\"" + v75 + "\"#"
    let v242 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v241 
    let v243 : string = "clap::Arg::new($0)"
    let v244 : clap_Arg = Fable.Core.RustInterop.emitRustExpr v242 v243 
    let v245 : string = "$0.short($1)"
    let v246 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v244, 'd') v245 
    let v247 : string = "r#\"" + v75 + "\"#"
    let v248 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v247 
    let v249 : string = "$0.long($1)"
    let v250 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v246, v248) v249 
    let v251 : string = "$0.to_vec()"
    let v252 : Vec<Ref<Lifetime<StaticLifetime, Str>>> = Fable.Core.RustInterop.emitRustExpr v232 v251 
    let v253 : string = "$0.value_names($1)"
    let v254 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v250, v252) v253 
    let v255 : string = "$0.num_args($1)"
    let v256 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v254, v240) v255 
    let v257 : string = "clap::ArgAction::Append"
    let v258 : clap_ArgAction = Fable.Core.RustInterop.emitRustExpr () v257 
    let v259 : string = "$0.action($1)"
    let v260 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v256, v258) v259 
    let v261 : string = "clap::Command::arg($0, $1)"
    let v262 : clap_Command = Fable.Core.RustInterop.emitRustExpr struct (v227, v260) v261 
    let v263 : string = "clap::Command::subcommand($0, v262)"
    let v264 : clap_Command = Fable.Core.RustInterop.emitRustExpr v208 v263 
    v264
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
    let v47 : string = "process.env[$0]"
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
    let v4 : bool = "Verbose" = v3
    let v24 : US2 =
        if v4 then
            let v5 : US0 = US0_0
            US2_0(v5)
        else
            let v7 : bool = "Debug" = v3
            if v7 then
                let v8 : US0 = US0_1
                US2_0(v8)
            else
                let v10 : bool = "Info" = v3
                if v10 then
                    let v11 : US0 = US0_2
                    US2_0(v11)
                else
                    let v13 : bool = "Warning" = v3
                    if v13 then
                        let v14 : US0 = US0_3
                        US2_0(v14)
                    else
                        let v16 : bool = "Critical" = v3
                        if v16 then
                            let v17 : US0 = US0_4
                            US2_0(v17)
                        else
                            US2_1
    let v25 : string = method4()
    let v26 : string = method2(v25)
    let v28 : bool = v26 = "True"
    let v34 : US1 =
        if v28 then
            let v29 : System.DateTime = System.DateTime.Now
            let v30 : (System.DateTime -> int64) = _.Ticks
            let v31 : int64 = v30 v29
            US1_0(v31)
        else
            US1_1
    struct (v34, v24) 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v35 : US1 = US1_1
    let v36 : US2 = US2_1
    struct (v35, v36) 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v37 : US1 = US1_1
    let v38 : US2 = US2_1
    struct (v37, v38) 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v39 : string = method1()
    let v40 : string = method2(v39)
    let v41 : bool = "Verbose" = v40
    let v61 : US2 =
        if v41 then
            let v42 : US0 = US0_0
            US2_0(v42)
        else
            let v44 : bool = "Debug" = v40
            if v44 then
                let v45 : US0 = US0_1
                US2_0(v45)
            else
                let v47 : bool = "Info" = v40
                if v47 then
                    let v48 : US0 = US0_2
                    US2_0(v48)
                else
                    let v50 : bool = "Warning" = v40
                    if v50 then
                        let v51 : US0 = US0_3
                        US2_0(v51)
                    else
                        let v53 : bool = "Critical" = v40
                        if v53 then
                            let v54 : US0 = US0_4
                            US2_0(v54)
                        else
                            US2_1
    let v62 : string = method4()
    let v63 : string = method2(v62)
    let v65 : bool = v63 = "True"
    let v71 : US1 =
        if v65 then
            let v66 : System.DateTime = System.DateTime.Now
            let v67 : (System.DateTime -> int64) = _.Ticks
            let v68 : int64 = v67 v66
            US1_0(v68)
        else
            US1_1
    struct (v71, v61) 
    #endif
#if FABLE_COMPILER_PYTHON
    let v72 : string = method1()
    let v73 : string = method2(v72)
    let v74 : bool = "Verbose" = v73
    let v94 : US2 =
        if v74 then
            let v75 : US0 = US0_0
            US2_0(v75)
        else
            let v77 : bool = "Debug" = v73
            if v77 then
                let v78 : US0 = US0_1
                US2_0(v78)
            else
                let v80 : bool = "Info" = v73
                if v80 then
                    let v81 : US0 = US0_2
                    US2_0(v81)
                else
                    let v83 : bool = "Warning" = v73
                    if v83 then
                        let v84 : US0 = US0_3
                        US2_0(v84)
                    else
                        let v86 : bool = "Critical" = v73
                        if v86 then
                            let v87 : US0 = US0_4
                            US2_0(v87)
                        else
                            US2_1
    let v95 : string = method4()
    let v96 : string = method2(v95)
    let v98 : bool = v96 = "True"
    let v104 : US1 =
        if v98 then
            let v99 : System.DateTime = System.DateTime.Now
            let v100 : (System.DateTime -> int64) = _.Ticks
            let v101 : int64 = v100 v99
            US1_0(v101)
        else
            US1_1
    struct (v104, v94) 
    #endif
#else
    let v105 : string = method1()
    let v106 : string = method2(v105)
    let v107 : bool = "Verbose" = v106
    let v127 : US2 =
        if v107 then
            let v108 : US0 = US0_0
            US2_0(v108)
        else
            let v110 : bool = "Debug" = v106
            if v110 then
                let v111 : US0 = US0_1
                US2_0(v111)
            else
                let v113 : bool = "Info" = v106
                if v113 then
                    let v114 : US0 = US0_2
                    US2_0(v114)
                else
                    let v116 : bool = "Warning" = v106
                    if v116 then
                        let v117 : US0 = US0_3
                        US2_0(v117)
                    else
                        let v119 : bool = "Critical" = v106
                        if v119 then
                            let v120 : US0 = US0_4
                            US2_0(v120)
                        else
                            US2_1
    let v128 : string = method4()
    let v129 : string = method2(v128)
    let v131 : bool = v129 = "True"
    let v137 : US1 =
        if v131 then
            let v132 : System.DateTime = System.DateTime.Now
            let v133 : (System.DateTime -> int64) = _.Ticks
            let v134 : int64 = v133 v132
            US1_0(v134)
        else
            US1_1
    struct (v137, v127) 
    #endif
    |> fun x -> _v1 <- Some x
    let struct (v138 : US1, v139 : US2) = match _v1 with Some x -> x | None -> failwith "base.run_target / _v1=None"
    let v140 : Mut1 = {l0 = true} : Mut1
    let v141 : Mut0 = {l0 = 0L} : Mut0
    let v144 : US0 =
        match v139 with
        | US2_1 -> (* None *)
            v0
        | US2_0(v142) -> (* Some *)
            v142
    let v145 : Mut2 = {l0 = v144} : Mut2
    let v146 : (string -> unit) = closure3()
    let v147 : Mut3 = {l0 = v146} : Mut3
    let v152 : int64 option =
        match v138 with
        | US1_1 -> (* None *)
            let v150 : int64 option = None
            v150
        | US1_0(v148) -> (* Some *)
            let v149 : int64 option = Some v148 
            v149
    struct (v141, v140, v145, v152, v147)
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
    let v157 : string =
        match v0 with
        | US0_4 -> (* Critical *)
            let v152 : string = "Critical"
            v152
        | US0_1 -> (* Debug *)
            let v149 : string = "Debug"
            v149
        | US0_2 -> (* Info *)
            let v150 : string = "Info"
            v150
        | US0_0 -> (* Verbose *)
            let v148 : string = "Verbose"
            v148
        | US0_3 -> (* Warning *)
            let v151 : string = "Warning"
            v151
    let v158 : (unit -> string) = v157.ToLower
    let v159 : string = v158 ()
    let v160 : string = v159.PadLeft (7, ' ')
    let v161 : bool = true
    let mutable _v161 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v176 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v170 : string = "inline_colorization::color_bright_red"
            let v171 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v170 
            v171
        | US0_1 -> (* Debug *)
            let v164 : string = "inline_colorization::color_bright_blue"
            let v165 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v164 
            v165
        | US0_2 -> (* Info *)
            let v166 : string = "inline_colorization::color_bright_green"
            let v167 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v166 
            v167
        | US0_0 -> (* Verbose *)
            let v162 : string = "inline_colorization::color_bright_black"
            let v163 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v162 
            v163
        | US0_3 -> (* Warning *)
            let v168 : string = "inline_colorization::color_yellow"
            let v169 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v168 
            v169
    let v177 : string = "&*$0"
    let v178 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v160 v177 
    let v179 : string = "inline_colorization::color_reset"
    let v180 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v179 
    let v181 : string = "\"{v176}{v178}{v180}\""
    let v182 : string = @$"format!(" + v181 + ")"
    let v183 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v182 
    let v184 : string = "fable_library_rust::String_::fromString($0)"
    let v185 : string = Fable.Core.RustInterop.emitRustExpr v183 v184 
    v185 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v200 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v194 : string = "inline_colorization::color_bright_red"
            let v195 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v194 
            v195
        | US0_1 -> (* Debug *)
            let v188 : string = "inline_colorization::color_bright_blue"
            let v189 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v188 
            v189
        | US0_2 -> (* Info *)
            let v190 : string = "inline_colorization::color_bright_green"
            let v191 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v190 
            v191
        | US0_0 -> (* Verbose *)
            let v186 : string = "inline_colorization::color_bright_black"
            let v187 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v186 
            v187
        | US0_3 -> (* Warning *)
            let v192 : string = "inline_colorization::color_yellow"
            let v193 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v192 
            v193
    let v201 : string = "&*$0"
    let v202 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v160 v201 
    let v203 : string = "inline_colorization::color_reset"
    let v204 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v203 
    let v205 : string = "\"{v200}{v202}{v204}\""
    let v206 : string = @$"format!(" + v205 + ")"
    let v207 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v206 
    let v208 : string = "fable_library_rust::String_::fromString($0)"
    let v209 : string = Fable.Core.RustInterop.emitRustExpr v207 v208 
    v209 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v224 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v218 : string = "inline_colorization::color_bright_red"
            let v219 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v218 
            v219
        | US0_1 -> (* Debug *)
            let v212 : string = "inline_colorization::color_bright_blue"
            let v213 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v212 
            v213
        | US0_2 -> (* Info *)
            let v214 : string = "inline_colorization::color_bright_green"
            let v215 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v214 
            v215
        | US0_0 -> (* Verbose *)
            let v210 : string = "inline_colorization::color_bright_black"
            let v211 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v210 
            v211
        | US0_3 -> (* Warning *)
            let v216 : string = "inline_colorization::color_yellow"
            let v217 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v216 
            v217
    let v225 : string = "&*$0"
    let v226 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v160 v225 
    let v227 : string = "inline_colorization::color_reset"
    let v228 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v227 
    let v229 : string = "\"{v224}{v226}{v228}\""
    let v230 : string = @$"format!(" + v229 + ")"
    let v231 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v230 
    let v232 : string = "fable_library_rust::String_::fromString($0)"
    let v233 : string = Fable.Core.RustInterop.emitRustExpr v231 v232 
    v233 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    v160 
    #endif
#if FABLE_COMPILER_PYTHON
    v160 
    #endif
#else
    v160 
    #endif
    |> fun x -> _v161 <- Some x
    let v234 : string = match _v161 with Some x -> x | None -> failwith "base.run_target / _v161=None"
    let v235 : int64 = v5.l0
    let v236 : string = $"{v147} {v234} #{v235} %s{v1 ()} / %s{v2 ()}"
    let v237 : (char []) = [||]
    let v238 : string = v236.TrimStart v237 
    let v239 : (char []) = [|' '; '/'|]
    let v240 : string = v238.TrimEnd v239 
    v240
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
    let v0 : string = "fs-path"
    v0
and method12 () : string =
    let v0 : string = "command"
    v0
and method15 (v0 : char, v1 : int64) : bool =
    let v2 : bool = v1 >= 4L
    if v2 then
        false
    else
        let v3 : bool = v1 = 0L
        let v19 : US9 =
            if v3 then
                US9_0('\\')
            else
                let v5 : int64 = v1 - 1L
                let v6 : bool = v5 = 0L
                if v6 then
                    US9_0('`')
                else
                    let v8 : int64 = v5 - 1L
                    let v9 : bool = v8 = 0L
                    if v9 then
                        US9_0('"')
                    else
                        let v11 : int64 = v8 - 1L
                        let v12 : bool = v11 = 0L
                        if v12 then
                            US9_0(' ')
                        else
                            let v14 : int64 = v11 - 1L
                            US9_1
        let v23 : char =
            match v19 with
            | US9_1 -> (* None *)
                failwith<char> "Option does not have a value."
            | US9_0(v20) -> (* Some *)
                v20
        let v24 : bool = v0 = v23
        if v24 then
            true
        else
            let v25 : int64 = v1 + 1L
            method15(v0, v25)
and method16 (v0 : int32, v1 : Mut4) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and closure10 (v0 : char) (v1 : UH1) : UH1 =
    UH1_1(v0, v1)
and closure9 () (v0 : char) : (UH1 -> UH1) =
    closure10(v0)
and method17 () : (char -> (UH1 -> UH1)) =
    closure9()
and method18 (v0 : UH1, v1 : System.Text.StringBuilder, v2 : int32, v3 : int32) : struct (System.Text.StringBuilder * int32 * int32) =
    match v0 with
    | UH1_1(v4, v5) -> (* Cons *)
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
        method18(v5, v17, v9, v10)
    | UH1_0 -> (* Nil *)
        struct (v1, v2, v3)
and method19 (v0 : string, v1 : string, v2 : System.Text.StringBuilder, v3 : int32, v4 : int32) : US10 =
    let v5 : bool = "" = v1
    let v57 : US8 =
        if v5 then
            let v6 : char list = []
            let v7 : char list = ' ' :: v6 
            let v8 : char list = '"' :: v7 
            let v9 : char list = '`' :: v8 
            let v10 : char list = '\\' :: v9 
            let v11 : (char list -> (char [])) = List.toArray
            let v12 : (char []) = v11 v10
            let v13 : string = $"parsing.none_of / unexpected end of input / chars: %A{v12} / s: %A{struct (v2, v3, v4)}"
            US8_1(v13)
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
            let v24 : bool = method15(v15, v23)
            let v25 : bool = v24 = false
            if v25 then
                let v26 : (char -> string) = _.ToString()
                let v27 : string = v26 v15
                let v28 : int32 = v27.Length
                let v29 : (char []) = Array.zeroCreate<char> (v28)
                let v30 : Mut4 = {l0 = 0} : Mut4
                while method16(v28, v30) do
                    let v32 : int32 = v30.l0
                    let v33 : char = v27.[int v32]
                    v29.[int v32] <- v33
                    let v34 : int32 = v32 + 1
                    v30.l0 <- v34
                    ()
                let v35 : ((char []) -> char list) = Array.toList
                let v36 : char list = v35 v29
                let v37 : ((char -> (UH1 -> UH1)) -> (char list -> (UH1 -> UH1))) = List.foldBack
                let v38 : (char -> (UH1 -> UH1)) = method17()
                let v39 : (char list -> (UH1 -> UH1)) = v37 v38
                let v40 : (UH1 -> UH1) = v39 v36
                let v41 : UH1 = UH1_0
                let v42 : UH1 = v40 v41
                let struct (v43 : System.Text.StringBuilder, v44 : int32, v45 : int32) = method18(v42, v2, v3, v4)
                US8_0(v15, v22, v43, v44, v45)
            else
                let v47 : char list = []
                let v48 : char list = ' ' :: v47 
                let v49 : char list = '"' :: v48 
                let v50 : char list = '`' :: v49 
                let v51 : char list = '\\' :: v50 
                let v52 : (char list -> (char [])) = List.toArray
                let v53 : (char []) = v52 v51
                let v54 : string = $"parsing.none_of / unexpected char: '{v15}' / chars: %A{v53} / s: %A{struct (v2, v3, v4)}"
                US8_1(v54)
    match v57 with
    | US8_1(v67) -> (* Error *)
        US10_0(v0, v1, v2, v3, v4)
    | US8_0(v58, v59, v60, v61, v62) -> (* Ok *)
        let v63 : (char -> string) = _.ToString()
        let v64 : string = v63 v58
        let v65 : string = v0 + v64 
        method19(v65, v59, v60, v61, v62)
and method21 (v0 : char, v1 : int64) : bool =
    let v2 : bool = v1 >= 3L
    if v2 then
        false
    else
        let v3 : bool = v1 = 0L
        let v15 : US9 =
            if v3 then
                US9_0('\\')
            else
                let v5 : int64 = v1 - 1L
                let v6 : bool = v5 = 0L
                if v6 then
                    US9_0('`')
                else
                    let v8 : int64 = v5 - 1L
                    let v9 : bool = v8 = 0L
                    if v9 then
                        US9_0('"')
                    else
                        let v11 : int64 = v8 - 1L
                        US9_1
        let v19 : char =
            match v15 with
            | US9_1 -> (* None *)
                failwith<char> "Option does not have a value."
            | US9_0(v16) -> (* Some *)
                v16
        let v20 : bool = v0 = v19
        if v20 then
            true
        else
            let v21 : int64 = v1 + 1L
            method21(v0, v21)
and closure11 () struct (v0 : string, v1 : System.Text.StringBuilder, v2 : int32, v3 : int32) : US10 =
    let v4 : bool = "" = v0
    let v60 : US8 =
        if v4 then
            let v5 : string = $"parsing.p_char / unexpected end of input / s: %A{struct (v1, v2, v3)}"
            US8_1(v5)
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
                while method16(v18, v20) do
                    let v22 : int32 = v20.l0
                    let v23 : char = v17.[int v22]
                    v19.[int v22] <- v23
                    let v24 : int32 = v22 + 1
                    v20.l0 <- v24
                    ()
                let v25 : ((char []) -> char list) = Array.toList
                let v26 : char list = v25 v19
                let v27 : ((char -> (UH1 -> UH1)) -> (char list -> (UH1 -> UH1))) = List.foldBack
                let v28 : (char -> (UH1 -> UH1)) = method17()
                let v29 : (char list -> (UH1 -> UH1)) = v27 v28
                let v30 : (UH1 -> UH1) = v29 v26
                let v31 : UH1 = UH1_0
                let v32 : UH1 = v30 v31
                let struct (v33 : System.Text.StringBuilder, v34 : int32, v35 : int32) = method18(v32, v1, v2, v3)
                US8_0(v7, v15, v33, v34, v35)
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
                US8_1(v57)
    let v102 : US8 =
        match v60 with
        | US8_1(v99) -> (* Error *)
            US8_1(v99)
        | US8_0(v61, v62, v63, v64, v65) -> (* Ok *)
            let v66 : bool = "" = v62
            if v66 then
                let v67 : string = $"parsing.any_char / unexpected end of input / s: %A{struct (v63, v64, v65)}"
                US8_1(v67)
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
                while method16(v79, v81) do
                    let v83 : int32 = v81.l0
                    let v84 : char = v78.[int v83]
                    v80.[int v83] <- v84
                    let v85 : int32 = v83 + 1
                    v81.l0 <- v85
                    ()
                let v86 : ((char []) -> char list) = Array.toList
                let v87 : char list = v86 v80
                let v88 : ((char -> (UH1 -> UH1)) -> (char list -> (UH1 -> UH1))) = List.foldBack
                let v89 : (char -> (UH1 -> UH1)) = method17()
                let v90 : (char list -> (UH1 -> UH1)) = v88 v89
                let v91 : (UH1 -> UH1) = v90 v87
                let v92 : UH1 = UH1_0
                let v93 : UH1 = v91 v92
                let struct (v94 : System.Text.StringBuilder, v95 : int32, v96 : int32) = method18(v93, v63, v64, v65)
                US8_0(v69, v76, v94, v95, v96)
    match v102 with
    | US8_1(v110) -> (* Error *)
        US10_1(v110)
    | US8_0(v103, v104, v105, v106, v107) -> (* Ok *)
        let v108 : string = $"{'\\'}{v103}"
        US10_0(v108, v104, v105, v106, v107)
and closure12 () struct (v0 : string, v1 : System.Text.StringBuilder, v2 : int32, v3 : int32) : US10 =
    let v4 : bool = "" = v0
    let v60 : US8 =
        if v4 then
            let v5 : string = $"parsing.p_char / unexpected end of input / s: %A{struct (v1, v2, v3)}"
            US8_1(v5)
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
                while method16(v18, v20) do
                    let v22 : int32 = v20.l0
                    let v23 : char = v17.[int v22]
                    v19.[int v22] <- v23
                    let v24 : int32 = v22 + 1
                    v20.l0 <- v24
                    ()
                let v25 : ((char []) -> char list) = Array.toList
                let v26 : char list = v25 v19
                let v27 : ((char -> (UH1 -> UH1)) -> (char list -> (UH1 -> UH1))) = List.foldBack
                let v28 : (char -> (UH1 -> UH1)) = method17()
                let v29 : (char list -> (UH1 -> UH1)) = v27 v28
                let v30 : (UH1 -> UH1) = v29 v26
                let v31 : UH1 = UH1_0
                let v32 : UH1 = v30 v31
                let struct (v33 : System.Text.StringBuilder, v34 : int32, v35 : int32) = method18(v32, v1, v2, v3)
                US8_0(v7, v15, v33, v34, v35)
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
                US8_1(v57)
    let v102 : US8 =
        match v60 with
        | US8_1(v99) -> (* Error *)
            US8_1(v99)
        | US8_0(v61, v62, v63, v64, v65) -> (* Ok *)
            let v66 : bool = "" = v62
            if v66 then
                let v67 : string = $"parsing.any_char / unexpected end of input / s: %A{struct (v63, v64, v65)}"
                US8_1(v67)
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
                while method16(v79, v81) do
                    let v83 : int32 = v81.l0
                    let v84 : char = v78.[int v83]
                    v80.[int v83] <- v84
                    let v85 : int32 = v83 + 1
                    v81.l0 <- v85
                    ()
                let v86 : ((char []) -> char list) = Array.toList
                let v87 : char list = v86 v80
                let v88 : ((char -> (UH1 -> UH1)) -> (char list -> (UH1 -> UH1))) = List.foldBack
                let v89 : (char -> (UH1 -> UH1)) = method17()
                let v90 : (char list -> (UH1 -> UH1)) = v88 v89
                let v91 : (UH1 -> UH1) = v90 v87
                let v92 : UH1 = UH1_0
                let v93 : UH1 = v91 v92
                let struct (v94 : System.Text.StringBuilder, v95 : int32, v96 : int32) = method18(v93, v63, v64, v65)
                US8_0(v69, v76, v94, v95, v96)
    match v102 with
    | US8_1(v110) -> (* Error *)
        US10_1(v110)
    | US8_0(v103, v104, v105, v106, v107) -> (* Ok *)
        let v108 : string = $"{'`'}{v103}"
        US10_0(v108, v104, v105, v106, v107)
and method22 (v0 : string, v1 : System.Text.StringBuilder, v2 : int32, v3 : int32, v4 : UH2) : US10 =
    match v4 with
    | UH2_1(v7, v8) -> (* Cons *)
        let v9 : US10 = v7 struct (v0, v1, v2, v3)
        match v9 with
        | US10_1(v15) -> (* Error *)
            method22(v0, v1, v2, v3, v8)
        | US10_0(v10, v11, v12, v13, v14) -> (* Ok *)
            v9
    | UH2_0 -> (* Nil *)
        let v5 : string = "choice / no parsers succeeded"
        US10_1(v5)
and method23 (v0 : UH0, v1 : UH0) : UH0 =
    match v0 with
    | UH0_1(v2, v3) -> (* Cons *)
        let v4 : UH0 = UH0_1(v2, v1)
        method23(v3, v4)
    | UH0_0 -> (* Nil *)
        v1
and method20 (v0 : UH0, v1 : string, v2 : System.Text.StringBuilder, v3 : int32, v4 : int32) : US7 =
    let v5 : bool = "" = v1
    let v55 : US8 =
        if v5 then
            let v6 : char list = []
            let v7 : char list = '"' :: v6 
            let v8 : char list = '`' :: v7 
            let v9 : char list = '\\' :: v8 
            let v10 : (char list -> (char [])) = List.toArray
            let v11 : (char []) = v10 v9
            let v12 : string = $"parsing.none_of / unexpected end of input / chars: %A{v11} / s: %A{struct (v2, v3, v4)}"
            US8_1(v12)
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
            let v23 : bool = method21(v14, v22)
            let v24 : bool = v23 = false
            if v24 then
                let v25 : (char -> string) = _.ToString()
                let v26 : string = v25 v14
                let v27 : int32 = v26.Length
                let v28 : (char []) = Array.zeroCreate<char> (v27)
                let v29 : Mut4 = {l0 = 0} : Mut4
                while method16(v27, v29) do
                    let v31 : int32 = v29.l0
                    let v32 : char = v26.[int v31]
                    v28.[int v31] <- v32
                    let v33 : int32 = v31 + 1
                    v29.l0 <- v33
                    ()
                let v34 : ((char []) -> char list) = Array.toList
                let v35 : char list = v34 v28
                let v36 : ((char -> (UH1 -> UH1)) -> (char list -> (UH1 -> UH1))) = List.foldBack
                let v37 : (char -> (UH1 -> UH1)) = method17()
                let v38 : (char list -> (UH1 -> UH1)) = v36 v37
                let v39 : (UH1 -> UH1) = v38 v35
                let v40 : UH1 = UH1_0
                let v41 : UH1 = v39 v40
                let struct (v42 : System.Text.StringBuilder, v43 : int32, v44 : int32) = method18(v41, v2, v3, v4)
                US8_0(v14, v21, v42, v43, v44)
            else
                let v46 : char list = []
                let v47 : char list = '"' :: v46 
                let v48 : char list = '`' :: v47 
                let v49 : char list = '\\' :: v48 
                let v50 : (char list -> (char [])) = List.toArray
                let v51 : (char []) = v50 v49
                let v52 : string = $"parsing.none_of / unexpected char: '{v14}' / chars: %A{v51} / s: %A{struct (v2, v3, v4)}"
                US8_1(v52)
    let v67 : US10 =
        match v55 with
        | US8_1(v64) -> (* Error *)
            US10_1(v64)
        | US8_0(v56, v57, v58, v59, v60) -> (* Ok *)
            let v61 : (char -> string) = _.ToString()
            let v62 : string = v61 v56
            US10_0(v62, v57, v58, v59, v60)
    let v81 : US10 =
        match v67 with
        | US10_1(v73) -> (* Error *)
            let v74 : (struct (string * System.Text.StringBuilder * int32 * int32) -> US10) = closure11()
            let v75 : (struct (string * System.Text.StringBuilder * int32 * int32) -> US10) = closure12()
            let v76 : UH2 = UH2_0
            let v77 : UH2 = UH2_1(v75, v76)
            let v78 : UH2 = UH2_1(v74, v77)
            method22(v1, v2, v3, v4, v78)
        | US10_0(v68, v69, v70, v71, v72) -> (* Ok *)
            v67
    match v81 with
    | US10_1(v89) -> (* Error *)
        let v90 : UH0 = UH0_0
        let v91 : UH0 = method23(v0, v90)
        US7_0(v91, v1, v2, v3, v4)
    | US10_0(v82, v83, v84, v85, v86) -> (* Ok *)
        let v87 : UH0 = UH0_1(v82, v0)
        method20(v87, v83, v84, v85, v86)
and method24 (v0 : UH0, v1 : string list) : string list =
    match v0 with
    | UH0_1(v2, v3) -> (* Cons *)
        let v4 : string list = method24(v3, v1)
        let v5 : string list = v2 :: v4 
        v5
    | UH0_0 -> (* Nil *)
        v1
and method25 (v0 : UH0, v1 : string, v2 : System.Text.StringBuilder, v3 : int32, v4 : int32) : US7 =
    let v5 : bool = "" = v1
    let v55 : US8 =
        if v5 then
            let v6 : char list = []
            let v7 : char list = '"' :: v6 
            let v8 : char list = '`' :: v7 
            let v9 : char list = '\\' :: v8 
            let v10 : (char list -> (char [])) = List.toArray
            let v11 : (char []) = v10 v9
            let v12 : string = $"parsing.none_of / unexpected end of input / chars: %A{v11} / s: %A{struct (v2, v3, v4)}"
            US8_1(v12)
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
            let v23 : bool = method21(v14, v22)
            let v24 : bool = v23 = false
            if v24 then
                let v25 : (char -> string) = _.ToString()
                let v26 : string = v25 v14
                let v27 : int32 = v26.Length
                let v28 : (char []) = Array.zeroCreate<char> (v27)
                let v29 : Mut4 = {l0 = 0} : Mut4
                while method16(v27, v29) do
                    let v31 : int32 = v29.l0
                    let v32 : char = v26.[int v31]
                    v28.[int v31] <- v32
                    let v33 : int32 = v31 + 1
                    v29.l0 <- v33
                    ()
                let v34 : ((char []) -> char list) = Array.toList
                let v35 : char list = v34 v28
                let v36 : ((char -> (UH1 -> UH1)) -> (char list -> (UH1 -> UH1))) = List.foldBack
                let v37 : (char -> (UH1 -> UH1)) = method17()
                let v38 : (char list -> (UH1 -> UH1)) = v36 v37
                let v39 : (UH1 -> UH1) = v38 v35
                let v40 : UH1 = UH1_0
                let v41 : UH1 = v39 v40
                let struct (v42 : System.Text.StringBuilder, v43 : int32, v44 : int32) = method18(v41, v2, v3, v4)
                US8_0(v14, v21, v42, v43, v44)
            else
                let v46 : char list = []
                let v47 : char list = '"' :: v46 
                let v48 : char list = '`' :: v47 
                let v49 : char list = '\\' :: v48 
                let v50 : (char list -> (char [])) = List.toArray
                let v51 : (char []) = v50 v49
                let v52 : string = $"parsing.none_of / unexpected char: '{v14}' / chars: %A{v51} / s: %A{struct (v2, v3, v4)}"
                US8_1(v52)
    let v67 : US10 =
        match v55 with
        | US8_1(v64) -> (* Error *)
            US10_1(v64)
        | US8_0(v56, v57, v58, v59, v60) -> (* Ok *)
            let v61 : (char -> string) = _.ToString()
            let v62 : string = v61 v56
            US10_0(v62, v57, v58, v59, v60)
    match v67 with
    | US10_1(v75) -> (* Error *)
        let v76 : UH0 = UH0_0
        let v77 : UH0 = method23(v0, v76)
        US7_0(v77, v1, v2, v3, v4)
    | US10_0(v68, v69, v70, v71, v72) -> (* Ok *)
        let v73 : UH0 = UH0_1(v68, v0)
        method25(v73, v69, v70, v71, v72)
and method26 (v0 : string, v1 : int32) : int32 =
    let v2 : int32 = v0.Length
    let v3 : bool = v1 >= v2
    if v3 then
        v1
    else
        let v4 : char = v0.[int v1]
        let v5 : bool = v4 = ' '
        if v5 then
            let v6 : int32 = v1 + 1
            method26(v0, v6)
        else
            v1
and method14 (v0 : UH0, v1 : string, v2 : System.Text.StringBuilder, v3 : int32, v4 : int32) : US7 =
    let v5 : bool = "" = v1
    let v57 : US8 =
        if v5 then
            let v6 : char list = []
            let v7 : char list = ' ' :: v6 
            let v8 : char list = '"' :: v7 
            let v9 : char list = '`' :: v8 
            let v10 : char list = '\\' :: v9 
            let v11 : (char list -> (char [])) = List.toArray
            let v12 : (char []) = v11 v10
            let v13 : string = $"parsing.none_of / unexpected end of input / chars: %A{v12} / s: %A{struct (v2, v3, v4)}"
            US8_1(v13)
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
            let v24 : bool = method15(v15, v23)
            let v25 : bool = v24 = false
            if v25 then
                let v26 : (char -> string) = _.ToString()
                let v27 : string = v26 v15
                let v28 : int32 = v27.Length
                let v29 : (char []) = Array.zeroCreate<char> (v28)
                let v30 : Mut4 = {l0 = 0} : Mut4
                while method16(v28, v30) do
                    let v32 : int32 = v30.l0
                    let v33 : char = v27.[int v32]
                    v29.[int v32] <- v33
                    let v34 : int32 = v32 + 1
                    v30.l0 <- v34
                    ()
                let v35 : ((char []) -> char list) = Array.toList
                let v36 : char list = v35 v29
                let v37 : ((char -> (UH1 -> UH1)) -> (char list -> (UH1 -> UH1))) = List.foldBack
                let v38 : (char -> (UH1 -> UH1)) = method17()
                let v39 : (char list -> (UH1 -> UH1)) = v37 v38
                let v40 : (UH1 -> UH1) = v39 v36
                let v41 : UH1 = UH1_0
                let v42 : UH1 = v40 v41
                let struct (v43 : System.Text.StringBuilder, v44 : int32, v45 : int32) = method18(v42, v2, v3, v4)
                US8_0(v15, v22, v43, v44, v45)
            else
                let v47 : char list = []
                let v48 : char list = ' ' :: v47 
                let v49 : char list = '"' :: v48 
                let v50 : char list = '`' :: v49 
                let v51 : char list = '\\' :: v50 
                let v52 : (char list -> (char [])) = List.toArray
                let v53 : (char []) = v52 v51
                let v54 : string = $"parsing.none_of / unexpected char: '{v15}' / chars: %A{v53} / s: %A{struct (v2, v3, v4)}"
                US8_1(v54)
    let v69 : US10 =
        match v57 with
        | US8_1(v58) -> (* Error *)
            US10_1(v58)
        | US8_0(v60, v61, v62, v63, v64) -> (* Ok *)
            let v65 : (char -> string) = _.ToString()
            let v66 : string = v65 v60
            method19(v66, v61, v62, v63, v64)
    let v292 : US10 =
        match v69 with
        | US10_1(v75) -> (* Error *)
            let v131 : US8 =
                if v5 then
                    let v76 : string = $"parsing.p_char / unexpected end of input / s: %A{struct (v2, v3, v4)}"
                    US8_1(v76)
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
                        while method16(v89, v91) do
                            let v93 : int32 = v91.l0
                            let v94 : char = v88.[int v93]
                            v90.[int v93] <- v94
                            let v95 : int32 = v93 + 1
                            v91.l0 <- v95
                            ()
                        let v96 : ((char []) -> char list) = Array.toList
                        let v97 : char list = v96 v90
                        let v98 : ((char -> (UH1 -> UH1)) -> (char list -> (UH1 -> UH1))) = List.foldBack
                        let v99 : (char -> (UH1 -> UH1)) = method17()
                        let v100 : (char list -> (UH1 -> UH1)) = v98 v99
                        let v101 : (UH1 -> UH1) = v100 v97
                        let v102 : UH1 = UH1_0
                        let v103 : UH1 = v101 v102
                        let struct (v104 : System.Text.StringBuilder, v105 : int32, v106 : int32) = method18(v103, v2, v3, v4)
                        US8_0(v78, v86, v104, v105, v106)
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
                        US8_1(v128)
            let v237 : US10 =
                match v131 with
                | US8_1(v234) -> (* Error *)
                    US10_1(v234)
                | US8_0(v132, v133, v134, v135, v136) -> (* Ok *)
                    let v137 : UH0 = UH0_0
                    let v138 : US7 = method20(v137, v133, v134, v135, v136)
                    let v155 : US10 =
                        match v138 with
                        | US7_1(v152) -> (* Error *)
                            US10_1(v152)
                        | US7_0(v139, v140, v141, v142, v143) -> (* Ok *)
                            let v144 : string list = []
                            let v145 : string list = method24(v139, v144)
                            let v146 : string seq = seq { for i = 0 to v145.Length - 1 do yield v145.[i] }
                            let v147 : (string -> (string seq -> string)) = String.concat
                            let v148 : string = ""
                            let v149 : (string seq -> string) = v147 v148
                            let v150 : string = v149 v146
                            US10_0(v150, v140, v141, v142, v143)
                    match v155 with
                    | US10_1(v229) -> (* Error *)
                        let v230 : string = "between / expected content"
                        US10_1(v230)
                    | US10_0(v156, v157, v158, v159, v160) -> (* Ok *)
                        let v161 : bool = "" = v157
                        let v217 : US8 =
                            if v161 then
                                let v162 : string = $"parsing.p_char / unexpected end of input / s: %A{struct (v158, v159, v160)}"
                                US8_1(v162)
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
                                    while method16(v175, v177) do
                                        let v179 : int32 = v177.l0
                                        let v180 : char = v174.[int v179]
                                        v176.[int v179] <- v180
                                        let v181 : int32 = v179 + 1
                                        v177.l0 <- v181
                                        ()
                                    let v182 : ((char []) -> char list) = Array.toList
                                    let v183 : char list = v182 v176
                                    let v184 : ((char -> (UH1 -> UH1)) -> (char list -> (UH1 -> UH1))) = List.foldBack
                                    let v185 : (char -> (UH1 -> UH1)) = method17()
                                    let v186 : (char list -> (UH1 -> UH1)) = v184 v185
                                    let v187 : (UH1 -> UH1) = v186 v183
                                    let v188 : UH1 = UH1_0
                                    let v189 : UH1 = v187 v188
                                    let struct (v190 : System.Text.StringBuilder, v191 : int32, v192 : int32) = method18(v189, v158, v159, v160)
                                    US8_0(v164, v172, v190, v191, v192)
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
                                    US8_1(v214)
                        match v217 with
                        | US8_1(v224) -> (* Error *)
                            let v225 : string = $"between / expected closing delimiter / e: %A{v224} / input: %A{struct (v1, v2, v3, v4)} / rest1: %A{struct (v133, v134, v135, v136)} / rest2: %A{struct (v157, v158, v159, v160)}"
                            US10_1(v225)
                        | US8_0(v218, v219, v220, v221, v222) -> (* Ok *)
                            US10_0(v156, v219, v220, v221, v222)
            match v237 with
            | US10_1(v243) -> (* Error *)
                let v244 : (struct (string * System.Text.StringBuilder * int32 * int32) -> US10) = closure11()
                let v245 : (struct (string * System.Text.StringBuilder * int32 * int32) -> US10) = closure12()
                let v246 : UH2 = UH2_0
                let v247 : UH2 = UH2_1(v245, v246)
                let v248 : UH2 = UH2_1(v244, v247)
                let v249 : US10 = method22(v1, v2, v3, v4, v248)
                let v260 : US10 =
                    match v249 with
                    | US10_1(v257) -> (* Error *)
                        US10_1(v257)
                    | US10_0(v250, v251, v252, v253, v254) -> (* Ok *)
                        let v255 : string = ""
                        US10_0(v255, v251, v252, v253, v254)
                let v271 : US7 =
                    match v260 with
                    | US10_1(v268) -> (* Error *)
                        US7_1(v268)
                    | US10_0(v261, v262, v263, v264, v265) -> (* Ok *)
                        let v266 : UH0 = UH0_0
                        method25(v266, v262, v263, v264, v265)
                match v271 with
                | US7_1(v285) -> (* Error *)
                    US10_1(v285)
                | US7_0(v272, v273, v274, v275, v276) -> (* Ok *)
                    let v277 : string list = []
                    let v278 : string list = method24(v272, v277)
                    let v279 : string seq = seq { for i = 0 to v278.Length - 1 do yield v278.[i] }
                    let v280 : (string -> (string seq -> string)) = String.concat
                    let v281 : string = ""
                    let v282 : (string seq -> string) = v280 v281
                    let v283 : string = v282 v279
                    US10_0(v283, v273, v274, v275, v276)
            | US10_0(v238, v239, v240, v241, v242) -> (* Ok *)
                v237
        | US10_0(v70, v71, v72, v73, v74) -> (* Ok *)
            v69
    match v292 with
    | US10_1(v293) -> (* Error *)
        let v294 : UH0 = UH0_0
        let v295 : UH0 = method23(v0, v294)
        US7_0(v295, v1, v2, v3, v4)
    | US10_0(v297, v298, v299, v300, v301) -> (* Ok *)
        let v302 : int32 = 0
        let v303 : int32 = method26(v298, v302)
        let v304 : bool = 0 = v303
        let v315 : US11 =
            if v304 then
                let v305 : string = "spaces1 / expected at least one space"
                US11_1(v305)
            else
                let v307 : (string -> int32) = String.length
                let v308 : int32 = v307 v298
                let v309 : (int32 -> int32) = int32
                let v310 : int32 = v309 v303
                let v311 : (int32 -> int32) = int32
                let v312 : int32 = v311 v308
                let v313 : string = v298.[int v310..int v312]
                US11_0(v313, v299, v300, v301)
        match v315 with
        | US11_1(v316) -> (* Error *)
            let v317 : UH0 = UH0_0
            let v318 : UH0 = UH0_1(v297, v317)
            let v319 : UH0 = method23(v0, v318)
            US7_0(v319, v298, v299, v300, v301)
        | US11_0(v321, v322, v323, v324) -> (* Ok *)
            let v325 : UH0 = UH0_1(v297, v0)
            method14(v325, v321, v322, v323, v324)
and method13 (v0 : string) : US6 =
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
    let v8 : UH0 = UH0_0
    let v9 : int32 = 1
    let v10 : int32 = 1
    let v11 : US7 = method14(v8, v5, v7, v9, v10)
    let v25 : US12 =
        match v11 with
        | US7_1(v22) -> (* Error *)
            US12_1(v22)
        | US7_0(v12, v13, v14, v15, v16) -> (* Ok *)
            let v17 : string list = []
            let v18 : string list = method24(v12, v17)
            let v19 : (string list -> (string [])) = List.toArray
            let v20 : (string []) = v19 v18
            US12_0(v20)
    match v25 with
    | US12_1(v28) -> (* Error *)
        US6_1(v28)
    | US12_0(v26) -> (* Ok *)
        US6_0(v26)
and method27 () : string =
    let v0 : string = "path"
    v0
and method29 () : string =
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
and method32 (v0 : string) : string =
    v0
and method31 (v0 : string, v1 : string) : struct (string * string) =
    let v2 : string = method32(v0)
    struct (v1, v2)
and method30 (v0 : string, v1 : string) : string =
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
    let v30 : US13 = US13_1
    let v31 : US14 = US14_0(v30)
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
    let struct (v37 : string, v38 : string) = method31(v1, v0)
    let v39 : string = "v36.join($0, $1)"
    let v40 : string = Fable.Core.JsInterop.emitJsExpr struct (v37, v38) v39 
    v40 
    #endif
#if FABLE_COMPILER_PYTHON
    let v41 : US13 = US13_0
    let v42 : US14 = US14_3(v41)
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
and method35 (v0 : string) : string =
    v0
and method36 () : string =
    let v0 : string = ""
    v0
and method37 (v0 : string) : string =
    v0
and method38 () : string =
    let v0 : string = "^\\\\\\\\\\?\\\\"
    v0
and method39 (v0 : int32, v1 : Mut5) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method40 (v0 : string) : string =
    v0
and method34 (v0 : string) : string =
    let v1 : bool = true
    let mutable _v1 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = method35(v0)
    let v3 : string = "&*$0"
    let v4 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v2 v3 
    let v5 : string = "String::from($0)"
    let v6 : std_string_String = Fable.Core.RustInterop.emitRustExpr v4 v5 
    let v7 : string = "std::path::PathBuf::from($0)"
    let v8 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v6 v7 
    let v9 : string = "$0.exists()"
    let v10 : bool = Fable.Core.RustInterop.emitRustExpr v8 v9 
    let v11 : bool = v10 = false
    let v132 : string =
        if v11 then
            let v12 : string = method29()
            let v13 : string = method30(v12, v2)
            let v14 : string = method36()
            let v15 : bool = true
            let mutable _v15 : string option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v16 : string = method37(v13)
            let v17 : string = $"regex::Regex::new(&$0)"
            let v18 : string = "^\\\\\\\\\\?\\\\"
            let v19 : Result<regex_Regex, regex_Error> = Fable.Core.RustInterop.emitRustExpr v18 v17 
            let v20 : string = "$0.unwrap()"
            let v21 : regex_Regex = Fable.Core.RustInterop.emitRustExpr v19 v20 
            let v22 : string = $"$0.replace_all(&$1, &*$2)"
            let v23 : std_borrow_Cow<Str> = Fable.Core.RustInterop.emitRustExpr struct (v21, v16, v14) v22 
            let v24 : string = "String::from($0)"
            let v25 : std_string_String = Fable.Core.RustInterop.emitRustExpr v23 v24 
            let v26 : string = "fable_library_rust::String_::fromString($0)"
            let v27 : string = Fable.Core.RustInterop.emitRustExpr v25 v26 
            v27 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v28 : string = null |> unbox<string>
            v28 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v29 : string = null |> unbox<string>
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
#else
            let v32 : string = method38()
            let v33 : string = System.Text.RegularExpressions.Regex.Replace (v13, v32, v14)
            v33 
            #endif
            |> fun x -> _v15 <- Some x
            let v34 : string = match _v15 with Some x -> x | None -> failwith "base.run_target / _v15=None"
            let v35 : string = $"{v34.[0] |> string |> _.ToLower()}{v34.[1..]}"
            let v36 : string = "\\"
            let v37 : string = "/"
            let v38 : string = v35.Replace (v36, v37)
            let v39 : (string []) = v38.Split v37 
            let v40 : (string []) = [||]
            let v41 : int32 = v39.Length
            let v42 : Mut5 = {l0 = 0; l1 = 0; l2 = v40} : Mut5
            while method39(v41, v42) do
                let v44 : int32 = v42.l0
                let v45 : int32 =  -v44
                let v46 : int32 = v45 + v41
                let v47 : int32 = v46 - 1
                let struct (v48 : int32, v49 : (string [])) = v42.l1, v42.l2
                let v50 : string = v39.[int v47]
                let v51 : bool = ".." = v50
                let struct (v93 : int32, v94 : (string [])) =
                    if v51 then
                        let v52 : int32 = v48 + 1
                        struct (v52, v49)
                    else
                        let v53 : bool = "." = v50
                        if v53 then
                            struct (v48, v49)
                        else
                            let v54 : bool = 0 = v48
                            if v54 then
                                let v55 : string = ":"
                                let v56 : bool = v50.EndsWith v55 
                                if v56 then
                                    let v57 : string = $"{v12.[0]}:"
                                    let v58 : (string []) = [|v57|]
                                    let v59 : int32 = v58.Length
                                    let v60 : int32 = v49.Length
                                    let v61 : int32 = v59 + v60
                                    let v62 : (string []) = Array.zeroCreate<string> (v61)
                                    let v63 : Mut4 = {l0 = 0} : Mut4
                                    while method16(v61, v63) do
                                        let v65 : int32 = v63.l0
                                        let v66 : bool = v65 < v59
                                        let v70 : string =
                                            if v66 then
                                                let v67 : string = v58.[int v65]
                                                v67
                                            else
                                                let v68 : int32 = v65 - v59
                                                let v69 : string = v49.[int v68]
                                                v69
                                        v62.[int v65] <- v70
                                        let v71 : int32 = v65 + 1
                                        v63.l0 <- v71
                                        ()
                                    struct (0, v62)
                                else
                                    let v72 : (string []) = [|v50|]
                                    let v73 : int32 = v72.Length
                                    let v74 : int32 = v49.Length
                                    let v75 : int32 = v73 + v74
                                    let v76 : (string []) = Array.zeroCreate<string> (v75)
                                    let v77 : Mut4 = {l0 = 0} : Mut4
                                    while method16(v75, v77) do
                                        let v79 : int32 = v77.l0
                                        let v80 : bool = v79 < v73
                                        let v84 : string =
                                            if v80 then
                                                let v81 : string = v72.[int v79]
                                                v81
                                            else
                                                let v82 : int32 = v79 - v73
                                                let v83 : string = v49.[int v82]
                                                v83
                                        v76.[int v79] <- v84
                                        let v85 : int32 = v79 + 1
                                        v77.l0 <- v85
                                        ()
                                    struct (0, v76)
                            else
                                let v88 : int32 = v48 - 1
                                struct (v88, v49)
                let v95 : int32 = v44 + 1
                v42.l0 <- v95
                v42.l1 <- v93
                v42.l2 <- v94
                ()
            let struct (v96 : int32, v97 : (string [])) = v42.l1, v42.l2
            let v98 : string seq = seq { for i = 0 to v97.Length - 1 do yield v97.[i] }
            let v99 : bool = true
            let mutable _v99 : char option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v100 : string = "std::path::MAIN_SEPARATOR"
            let v101 : char = Fable.Core.RustInterop.emitRustExpr () v100 
            v101 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v102 : char = System.IO.Path.DirectorySeparatorChar
            v102 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v103 : char = System.IO.Path.DirectorySeparatorChar
            v103 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v104 : char = System.IO.Path.DirectorySeparatorChar
            v104 
            #endif
#if FABLE_COMPILER_PYTHON
            let v105 : char = System.IO.Path.DirectorySeparatorChar
            v105 
            #endif
#else
            let v106 : char = System.IO.Path.DirectorySeparatorChar
            v106 
            #endif
            |> fun x -> _v99 <- Some x
            let v107 : char = match _v99 with Some x -> x | None -> failwith "base.run_target / _v99=None"
            let v108 : (char -> string) = _.ToString()
            let v109 : string = v108 v107
            let v110 : (string -> (string seq -> string)) = String.concat
            let v111 : (string seq -> string) = v110 v109
            v111 v98
        else
            let v113 : string = "std::fs::canonicalize(&*$0)"
            let v114 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v2 v113 
            let v115 : string = "$0.unwrap()"
            let v116 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v114 v115 
            let v117 : string = "$0.display()"
            let v118 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v116 v117 
            let v119 : bool = true
            let mutable _v119 : std_string_String option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v120 : string = "format!(\"{}\", $0)"
            let v121 : std_string_String = Fable.Core.RustInterop.emitRustExpr v118 v120 
            v121 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v122 : string = "format!(\"{}\", $0)"
            let v123 : std_string_String = Fable.Core.RustInterop.emitRustExpr v118 v122 
            v123 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v124 : string = "format!(\"{}\", $0)"
            let v125 : std_string_String = Fable.Core.RustInterop.emitRustExpr v118 v124 
            v125 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v126 : std_string_String = null |> unbox<std_string_String>
            v126 
            #endif
#if FABLE_COMPILER_PYTHON
            let v127 : std_string_String = null |> unbox<std_string_String>
            v127 
            #endif
#else
            let v128 : std_string_String = null |> unbox<std_string_String>
            v128 
            #endif
            |> fun x -> _v119 <- Some x
            let v129 : std_string_String = match _v119 with Some x -> x | None -> failwith "base.run_target / _v119=None"
            let v130 : string = "fable_library_rust::String_::fromString($0)"
            let v131 : string = Fable.Core.RustInterop.emitRustExpr v129 v130 
            v131
    v132 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v133 : string = null |> unbox<string>
    v133 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v134 : string = null |> unbox<string>
    v134 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v135 : string = null |> unbox<string>
    v135 
    #endif
#if FABLE_COMPILER_PYTHON
    let v136 : string = null |> unbox<string>
    v136 
    #endif
#else
    let v137 : string = method40(v0)
    let v138 : (string -> string) = System.IO.Path.GetFullPath
    let v139 : string = v138 v137
    v139 
    #endif
    |> fun x -> _v1 <- Some x
    let v140 : string = match _v1 with Some x -> x | None -> failwith "base.run_target / _v1=None"
    v140
and method33 (v0 : string) : string =
    let v1 : string = method34(v0)
    let v2 : string = method36()
    let v3 : bool = true
    let mutable _v3 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v4 : string = method37(v1)
    let v5 : string = $"regex::Regex::new(&$0)"
    let v6 : string = "^\\\\\\\\\\?\\\\"
    let v7 : Result<regex_Regex, regex_Error> = Fable.Core.RustInterop.emitRustExpr v6 v5 
    let v8 : string = "$0.unwrap()"
    let v9 : regex_Regex = Fable.Core.RustInterop.emitRustExpr v7 v8 
    let v10 : string = $"$0.replace_all(&$1, &*$2)"
    let v11 : std_borrow_Cow<Str> = Fable.Core.RustInterop.emitRustExpr struct (v9, v4, v2) v10 
    let v12 : string = "String::from($0)"
    let v13 : std_string_String = Fable.Core.RustInterop.emitRustExpr v11 v12 
    let v14 : string = "fable_library_rust::String_::fromString($0)"
    let v15 : string = Fable.Core.RustInterop.emitRustExpr v13 v14 
    v15 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v16 : string = null |> unbox<string>
    v16 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v17 : string = null |> unbox<string>
    v17 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v18 : string = null |> unbox<string>
    v18 
    #endif
#if FABLE_COMPILER_PYTHON
    let v19 : string = null |> unbox<string>
    v19 
    #endif
#else
    let v20 : string = method38()
    let v21 : string = System.Text.RegularExpressions.Regex.Replace (v1, v20, v2)
    v21 
    #endif
    |> fun x -> _v3 <- Some x
    let v22 : string = match _v3 with Some x -> x | None -> failwith "base.run_target / _v3=None"
    let v23 : string = $"{v22.[0] |> string |> _.ToLower()}{v22.[1..]}"
    let v24 : string = "\\"
    let v25 : string = "/"
    let v26 : string = v23.Replace (v24, v25)
    v26
and method28 (v0 : string) : string =
    let v1 : string = method29()
    let v2 : string = method30(v1, v0)
    method33(v2)
and closure13 () (v0 : std_string_String) : string =
    let v1 : string = "fable_library_rust::String_::fromString($0)"
    let v2 : string = Fable.Core.RustInterop.emitRustExpr v0 v1 
    method28(v2)
and method41 () : string =
    let v0 : string = "retries"
    v0
and method42 () : string =
    let v0 : string = "working-directory"
    v0
and method45 (v0 : System.Threading.CancellationToken option, v1 : string, v2 : (struct (string * string) []), v3 : (struct (bool * string * int32) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option) : string =
    v1
and method47 () : struct (string * string) =
    let v0 : string = ""
    struct (v0, v0)
and method48 (v0 : string, v1 : string, v2 : UH1, v3 : US15) : struct (string * string) =
    match v2 with
    | UH1_1(v4, v5) -> (* Cons *)
        let v6 : bool = '"' = v4
        if v6 then
            let v8 : bool = v1 = ""
            if v8 then
                let v9 : US16 = US16_0
                let v10 : US15 = US15_1(v9)
                method48(v0, v1, v5, v10)
            else
                match v3 with
                | US15_2 -> (* Arguments *)
                    let v38 : string = $"{v0}{v4}"
                    let v39 : US15 = US15_2
                    method48(v38, v1, v5, v39)
                | US15_1(v13) -> (* Path *)
                    match v13 with
                    | US16_0 -> (* Quoted *)
                        let v14 : US16 = US16_1
                        let v15 : US15 = US15_1(v14)
                        method48(v0, v1, v5, v15)
                    | _ ->
                        let v18 : bool = ' ' = v4
                        if v18 then
                            let v19 : US15 = US15_2
                            method48(v0, v1, v5, v19)
                        else
                            let v22 : string = $"{v1}{v4}"
                            method48(v0, v22, v5, v3)
                | US15_0 -> (* Start *)
                    let v29 : bool = ' ' = v4
                    if v29 then
                        let v30 : US15 = US15_2
                        method48(v0, v1, v5, v30)
                    else
                        let v33 : string = $"{v1}{v4}"
                        method48(v0, v33, v5, v3)
        else
            let v50 : bool = ''' = v4
            if v50 then
                let v52 : bool = v1 = ""
                if v52 then
                    let v53 : US16 = US16_0
                    let v54 : US15 = US15_1(v53)
                    method48(v0, v1, v5, v54)
                else
                    match v3 with
                    | US15_2 -> (* Arguments *)
                        let v82 : string = $"{v0}{v4}"
                        let v83 : US15 = US15_2
                        method48(v82, v1, v5, v83)
                    | US15_1(v57) -> (* Path *)
                        match v57 with
                        | US16_0 -> (* Quoted *)
                            let v58 : US16 = US16_1
                            let v59 : US15 = US15_1(v58)
                            method48(v0, v1, v5, v59)
                        | _ ->
                            let v62 : bool = ' ' = v4
                            if v62 then
                                let v63 : US15 = US15_2
                                method48(v0, v1, v5, v63)
                            else
                                let v66 : string = $"{v1}{v4}"
                                method48(v0, v66, v5, v3)
                    | US15_0 -> (* Start *)
                        let v73 : bool = ' ' = v4
                        if v73 then
                            let v74 : US15 = US15_2
                            method48(v0, v1, v5, v74)
                        else
                            let v77 : string = $"{v1}{v4}"
                            method48(v0, v77, v5, v3)
            else
                match v3 with
                | US15_2 -> (* Arguments *)
                    let v126 : string = $"{v0}{v4}"
                    let v127 : US15 = US15_2
                    method48(v126, v1, v5, v127)
                | US15_1(v94) -> (* Path *)
                    match v94 with
                    | US16_0 -> (* Quoted *)
                        let v95 : bool = ' ' = v4
                        if v95 then
                            let v96 : string = $"{v1} "
                            let v97 : US16 = US16_0
                            let v98 : US15 = US15_1(v97)
                            method48(v0, v96, v5, v98)
                        else
                            let v101 : string = $"{v1}{v4}"
                            method48(v0, v101, v5, v3)
                    | _ ->
                        let v106 : bool = ' ' = v4
                        if v106 then
                            let v107 : US15 = US15_2
                            method48(v0, v1, v5, v107)
                        else
                            let v110 : string = $"{v1}{v4}"
                            method48(v0, v110, v5, v3)
                | US15_0 -> (* Start *)
                    let v117 : bool = ' ' = v4
                    if v117 then
                        let v118 : US15 = US15_2
                        method48(v0, v1, v5, v118)
                    else
                        let v121 : string = $"{v1}{v4}"
                        method48(v0, v121, v5, v3)
    | _ ->
        match v3 with
        | US15_2 -> (* Arguments *)
            let v152 : string = "\\"
            let v153 : string = "/"
            let v154 : string = v1.Replace (v152, v153)
            struct (v154, v0)
        | US15_1(v140) -> (* Path *)
            match v140 with
            | US16_0 -> (* Quoted *)
                let v141 : string = "\\"
                let v142 : string = "/"
                let v143 : string = v1.Replace (v141, v142)
                struct (v143, v0)
            | _ ->
                let v144 : string = "\\"
                let v145 : string = "/"
                let v146 : string = v1.Replace (v144, v145)
                struct (v146, v0)
        | US15_0 -> (* Start *)
            let v149 : string = "\\"
            let v150 : string = "/"
            let v151 : string = v1.Replace (v149, v150)
            struct (v151, v0)
and method46 (v0 : string) : struct (string * string) =
    let struct (v1 : string, v2 : string) = method47()
    let v3 : int32 = v0.Length
    let v4 : (char []) = Array.zeroCreate<char> (v3)
    let v5 : Mut4 = {l0 = 0} : Mut4
    while method16(v3, v5) do
        let v7 : int32 = v5.l0
        let v8 : char = v0.[int v7]
        v4.[int v7] <- v8
        let v9 : int32 = v7 + 1
        v5.l0 <- v9
        ()
    let v10 : ((char []) -> char list) = Array.toList
    let v11 : char list = v10 v4
    let v12 : ((char -> (UH1 -> UH1)) -> (char list -> (UH1 -> UH1))) = List.foldBack
    let v13 : (char -> (UH1 -> UH1)) = method17()
    let v14 : (char list -> (UH1 -> UH1)) = v12 v13
    let v15 : (UH1 -> UH1) = v14 v11
    let v16 : UH1 = UH1_0
    let v17 : UH1 = v15 v16
    let v18 : US15 = US15_0
    method48(v2, v1, v17, v18)
and closure14 () () : string =
    let v0 : string = $"runtime.execute_with_options"
    v0
and closure15 (v0 : System.Threading.CancellationToken option, v1 : string, v2 : (struct (string * string) []), v3 : (struct (bool * string * int32) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option, v7 : string, v8 : Vec<std_string_String>) () : string =
    let v9 : string = $"file_name: {v7} / arguments: %A{v8}"
    let v10 : (unit -> string) = closure6()
    let v11 : string = $" / options: %A{struct (v0, v1, v2, v3, v4, v5, v6)} / {v10 ()}"
    let v12 : string = v9 + v11 
    v12
and closure16 () (v0 : std_io_Error) : std_string_String =
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
and method49 () : (std_io_Error -> std_string_String) =
    closure16()
and closure17 () (v0 : std_sync_Arc<std_sync_Mutex<std_process_Child option>>) : US17 =
    US17_0(v0)
and method50 () : (std_sync_Arc<std_sync_Mutex<std_process_Child option>> -> US17) =
    closure17()
and closure18 () (v0 : std_string_String) : US17 =
    US17_1(v0)
and method51 () : (std_string_String -> US17) =
    closure18()
and closure19 () () : string =
    let v0 : string = $"runtime.execute_with_options / child error"
    v0
and closure20 (v0 : std_string_String) () : string =
    let v1 : (unit -> string) = closure6()
    let v2 : string = $"error: {v0} / {v1 ()}"
    v2
and method52 (v0 : std_sync_Arc<std_sync_Mutex<std_process_Child option>>) : std_sync_Arc<std_sync_Mutex<std_process_Child option>> =
    v0
and closure21 () (v0 : std_string_String) : US19 =
    US19_0(v0)
and method53 () : (std_string_String -> US19) =
    closure21()
and closure22 () (v0 : std_string_String) : US19 =
    US19_1(v0)
and method54 () : (std_string_String -> US19) =
    closure22()
and closure23 () () : string =
    let v0 : string = $"runtime.stdio_line"
    v0
and closure24 (v0 : std_string_String) () : string =
    let v1 : (unit -> string) = closure6()
    let v2 : string = $"e: {v0} / {v1 ()}"
    v2
and closure25 (v0 : string) () : string =
    v0
and method55 (v0 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>>) : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>> =
    v0
and closure26 () (v0 : std_sync_mpsc_SendError<std_string_String>) : std_string_String =
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
and method56 () : (std_sync_mpsc_SendError<std_string_String> -> std_string_String) =
    closure26()
and method57 (v0 : Result<unit, string>) : Result<unit, string> =
    v0
and method58 (v0 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin option>>) : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin option>> =
    v0
and method59 (v0 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>>) : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> =
    v0
and method60 (v0 : std_sync_MutexGuard<std_process_ChildStdin>) : std_sync_MutexGuard<std_process_ChildStdin> =
    v0
and method61 (v0 : std_thread_JoinHandle<Result<unit, string>>) : std_thread_JoinHandle<Result<unit, string>> =
    v0
and closure27 () (v0 : std_process_Output) : US22 =
    US22_0(v0)
and closure28 () (v0 : std_string_String) : US22 =
    US22_1(v0)
and closure29 () () : string =
    let v0 : string = $"runtime.execute_with_options / output error"
    v0
and closure30 (v0 : std_string_String) () : string =
    let v1 : (unit -> string) = closure6()
    let v2 : string = $"error: {v0} / {v1 ()}"
    v2
and method62 (v0 : std_sync_Arc<std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>>) : std_sync_Arc<std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>> =
    v0
and closure31 () () : string =
    let v0 : string = $"runtime.execute_with_options / result"
    v0
and closure32 (v0 : int32, v1 : string) () : string =
    let v2 : string = $"exit_code: {v0}"
    let v3 : (unit -> string) = closure6()
    let v4 : string = $" / std_trace.Length: {v1.Length} / {v3 ()}"
    let v5 : string = v2 + v4 
    v5
and closure33 (v0 : System.Threading.CancellationToken option, v1 : string, v2 : (struct (string * string) []), v3 : (struct (bool * string * int32) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option) () : string =
    let v7 : string = $"execute_with_options_async / options: %A{struct (v0, v1, v2, v3, v4, v5, v6)}"
    v7
and method64 () : (unit -> string) =
    closure6()
and closure35 (v0 : string) () : string =
    v0
and closure34 (v0 : System.Threading.CancellationToken option, v1 : string, v2 : (struct (string * string) []), v3 : (struct (bool * string * int32) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option, v7 : System.Diagnostics.Process, v8 : System.Collections.Concurrent.ConcurrentStack<string>) (v9 : System.Diagnostics.DataReceivedEventArgs) : unit =
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
        let v21 : US23 option = None
        let _v21 = ref v21 
        match v3 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v22 : (struct (bool * string * int32) -> Async<unit>) = x
        let v23 : US23 = US23_0(v22)
        v23 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v21.Value <- x
        let v24 : US23 option = _v21.Value 
        let v25 : US23 = US23_1
        let v26 : US23 = v24 |> Option.defaultValue v25 
        match v26 with
        | US23_1 -> (* None *)
            ()
        | US23_0(v27) -> (* Some *)
            let v28 : int32 = v7.Id
            let v29 : Async<unit> = v27 struct (false, v17, v28)
            do! v29 
            ()
        let v30 : string = $"> {v17}"
        if v5 then
            let v31 : US0 = US0_0
            let v32 : (unit -> string) = closure35(v30)
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
        let v21 : US23 option = None
        let _v21 = ref v21 
        match v3 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v22 : (struct (bool * string * int32) -> Async<unit>) = x
        let v23 : US23 = US23_0(v22)
        v23 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v21.Value <- x
        let v24 : US23 option = _v21.Value 
        let v25 : US23 = US23_1
        let v26 : US23 = v24 |> Option.defaultValue v25 
        match v26 with
        | US23_1 -> (* None *)
            ()
        | US23_0(v27) -> (* Some *)
            let v28 : int32 = v7.Id
            let v29 : Async<unit> = v27 struct (true, v17, v28)
            do! v29 
            ()
        let v30 : string = $"! {v17}"
        if v5 then
            let v31 : US0 = US0_0
            let v32 : (unit -> string) = closure35(v30)
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
and closure37 (v0 : System.Diagnostics.Process) () : unit =
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
and closure38 (v0 : System.Threading.Tasks.TaskCanceledException) () : string =
    let v1 : string = $"execute_with_options_async / WaitForExitAsync / ex: %A{v0}"
    v1
and closure39 (v0 : int32, v1 : string) () : string =
    let v2 : string = $"execute_with_options_async / exit_code: {v0} / output.Length: {v1.Length}"
    v2
and method63 (v0 : System.Threading.CancellationToken option, v1 : string, v2 : (struct (string * string) []), v3 : (struct (bool * string * int32) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option) : Async<struct (int32 * string)> =
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
    let struct (v20 : string, v21 : string) = method46(v1)
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
    let v33 : (unit -> string) = closure33(v0, v1, v2, v3, v4, v5, v6)
    let v34 : (unit -> string) = method64()
    method5(v32, v33, v34)
    let v35 : System.Text.Encoding = System.Text.Encoding.UTF8
    let v36 : System.Diagnostics.ProcessStartInfo = System.Diagnostics.ProcessStartInfo (Arguments = v21, StandardOutputEncoding = v35, WorkingDirectory = v31, FileName = v20, CreateNoWindow = true, RedirectStandardError = true, RedirectStandardOutput = true, UseShellExecute = false)
    let v37 : int32 = v2.Length
    let v38 : Mut4 = {l0 = 0} : Mut4
    while method16(v37, v38) do
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
    let v48 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure34(v0, v1, v2, v3, v4, v5, v6, v45, v47)
    v45.OutputDataReceived.Add v48 
    let v49 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure36(v0, v1, v2, v3, v4, v5, v6, v45, v47)
    v45.ErrorDataReceived.Add v49 
    let v50 : (unit -> bool) = v45.Start
    let v51 : bool = v50 ()
    let v52 : bool = v51 = false
    if v52 then
        let v53 : string = $"execute_with_options_async / process_start error"
        failwith<unit> v53
    let v54 : (unit -> unit) = v45.BeginErrorReadLine
    v54 ()
    let v55 : (unit -> unit) = v45.BeginOutputReadLine
    v55 ()
    let v56 : US24 option = None
    let _v56 = ref v56 
    match v0 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v57 : System.Threading.CancellationToken = x
    let v58 : US24 = US24_0(v57)
    v58 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v56.Value <- x
    let v59 : US24 option = _v56.Value 
    let v60 : US24 = US24_1
    let v61 : US24 = v59 |> Option.defaultValue v60 
    let v65 : System.Threading.CancellationToken =
        match v61 with
        | US24_1 -> (* None *)
            let v63 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
            v63
        | US24_0(v62) -> (* Some *)
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
    let v91 : (unit -> unit) = closure37(v45)
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
    let v124 : (unit -> string) = closure38(v122)
    let v125 : (unit -> string) = method64()
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
    let v136 : (unit -> string) = closure39(v128, v134)
    let v137 : (unit -> string) = method64()
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
and method44 (v0 : System.Threading.CancellationToken option, v1 : string, v2 : (struct (string * string) []), v3 : (struct (bool * string * int32) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option) : struct (int32 * string) =
    let v7 : bool = true
    let mutable _v7 : struct (int32 * string) option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v8 : string = method45(v0, v1, v2, v3, v4, v5, v6)
    let struct (v9 : string, v10 : string) = method46(v8)
    let v11 : US6 = method13(v10)
    let v17 : (string []) =
        match v11 with
        | US6_1(v13) -> (* Error *)
            let v14 : string = $"resultm.get / Result value was Error: {v13}"
            failwith<(string [])> v14
        | US6_0(v12) -> (* Ok *)
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
    let v33 : (unit -> string) = closure14()
    let v34 : (unit -> string) = closure15(v0, v1, v2, v3, v4, v5, v6, v9, v31)
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
    let v85 : (std_io_Error -> std_string_String) = method49()
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
    let v101 : (std_sync_Arc<std_sync_Mutex<std_process_Child option>> -> US17) = method50()
    let v102 : (std_string_String -> US17) = method51()
    let v103 : string = "match v100 { Ok(x) => $0(x), Err(e) => $1(e) }"
    let v104 : US17 = Fable.Core.RustInterop.emitRustExpr struct (v101, v102) v103 
    let struct (v482 : int32, v483 : US5, v484 : US18) =
        match v104 with
        | US17_1(v473) -> (* Error *)
            let v474 : US0 = US0_4
            let v475 : (unit -> string) = closure19()
            let v476 : (unit -> string) = closure20(v473)
            method5(v474, v475, v476)
            let v477 : US5 = US5_0(v473)
            let v478 : US18 = US18_1
            struct (-1, v477, v478)
        | US17_0(v105) -> (* Ok *)
            let v106 : string = "true; let _result = (|| { //"
            let v107 : bool = Fable.Core.RustInterop.emitRustExpr () v106 
            let v108 : std_sync_Arc<std_sync_Mutex<std_process_Child option>> = method52(v105)
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
            let v133 : std_sync_Arc<std_sync_Mutex<std_process_Child option>> = method52(v105)
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
            let v158 : std_sync_Arc<std_sync_Mutex<std_process_Child option>> = method52(v105)
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
            let v215 : (std_io_Error -> std_string_String) = method49()
            let v216 : string = "$0.map_err(|x| $1(x))"
            let v217 : Result<std_string_String, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v212, v215) v216 
            let v218 : (std_string_String -> US19) = method53()
            let v219 : (std_string_String -> US19) = method54()
            let v220 : string = "match v217 { Ok(x) => $0(x), Err(e) => $1(e) }"
            let v221 : US19 = Fable.Core.RustInterop.emitRustExpr struct (v218, v219) v220 
            let v254 : std_string_String =
                match v221 with
                | US19_1(v244) -> (* Error *)
                    let v245 : US0 = US0_4
                    let v246 : (unit -> string) = closure23()
                    let v247 : (unit -> string) = closure24(v244)
                    method5(v245, v246, v247)
                    let v248 : string = $"\u001b[4;7m{v244}\u001b[0m"
                    let v249 : string = "&*$0"
                    let v250 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v248 v249 
                    let v251 : string = "String::from($0)"
                    let v252 : std_string_String = Fable.Core.RustInterop.emitRustExpr v250 v251 
                    v252
                | US19_0(v222) -> (* Ok *)
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
                        let v241 : (unit -> string) = closure25(v239)
                        let v242 : (unit -> string) = closure6()
                        method5(v240, v241, v242)
                    else
                        let v243 : (string -> unit) = System.Console.WriteLine
                        v243 v239
                    v236
            let v255 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>> = method55(v214)
            let v256 : string = "v255.lock()"
            let v257 : Result<std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>>, std_sync_PoisonError<std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>>>> = Fable.Core.RustInterop.emitRustExpr () v256 
            let v258 : string = "$0.unwrap()"
            let v259 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = Fable.Core.RustInterop.emitRustExpr v257 v258 
            let v260 : string = "&$0"
            let v261 : Ref<std_sync_mpsc_Sender<std_string_String>> = Fable.Core.RustInterop.emitRustExpr v259 v260 
            let v262 : string = "$0.send($1)"
            let v263 : Result<unit, std_sync_mpsc_SendError<std_string_String>> = Fable.Core.RustInterop.emitRustExpr struct (v261, v254) v262 
            let v264 : (std_sync_mpsc_SendError<std_string_String> -> std_string_String) = method56()
            let v265 : string = "$0.map_err(|x| $1(x))"
            let v266 : Result<unit, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v263, v264) v265 
            let v267 : string = "$0"
            let v268 : core_ops_Try<unit> = Fable.Core.RustInterop.emitRustExpr v266 v267 
            let v269 : string = "true; $0 }); //"
            let v270 : bool = Fable.Core.RustInterop.emitRustExpr v268 v269 
            let v271 : string = "_result.map_err(|x| x.into())"
            let v272 : Result<unit, string> = Fable.Core.RustInterop.emitRustExpr () v271 
            let v273 : Result<unit, string> = method57(v272)
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
            let v294 : (std_io_Error -> std_string_String) = method49()
            let v295 : string = "$0.map_err(|x| $1(x))"
            let v296 : Result<std_string_String, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v291, v294) v295 
            let v297 : (std_string_String -> US19) = method53()
            let v298 : (std_string_String -> US19) = method54()
            let v299 : string = "match v296 { Ok(x) => $0(x), Err(e) => $1(e) }"
            let v300 : US19 = Fable.Core.RustInterop.emitRustExpr struct (v297, v298) v299 
            let v338 : std_string_String =
                match v300 with
                | US19_1(v328) -> (* Error *)
                    let v329 : US0 = US0_4
                    let v330 : (unit -> string) = closure23()
                    let v331 : (unit -> string) = closure24(v328)
                    method5(v329, v330, v331)
                    let v332 : string = $"\u001b[4;7m{v328}\u001b[0m"
                    let v333 : string = "&*$0"
                    let v334 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v332 v333 
                    let v335 : string = "String::from($0)"
                    let v336 : std_string_String = Fable.Core.RustInterop.emitRustExpr v334 v335 
                    v336
                | US19_0(v301) -> (* Ok *)
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
                        let v320 : (unit -> string) = closure25(v318)
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
            let v339 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>> = method55(v293)
            let v340 : string = "v339.lock()"
            let v341 : Result<std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>>, std_sync_PoisonError<std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>>>> = Fable.Core.RustInterop.emitRustExpr () v340 
            let v342 : string = "$0.unwrap()"
            let v343 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = Fable.Core.RustInterop.emitRustExpr v341 v342 
            let v344 : string = "&$0"
            let v345 : Ref<std_sync_mpsc_Sender<std_string_String>> = Fable.Core.RustInterop.emitRustExpr v343 v344 
            let v346 : string = "$0.send($1)"
            let v347 : Result<unit, std_sync_mpsc_SendError<std_string_String>> = Fable.Core.RustInterop.emitRustExpr struct (v345, v338) v346 
            let v348 : (std_sync_mpsc_SendError<std_string_String> -> std_string_String) = method56()
            let v349 : string = "$0.map_err(|x| $1(x))"
            let v350 : Result<unit, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v347, v348) v349 
            let v351 : string = "$0"
            let v352 : core_ops_Try<unit> = Fable.Core.RustInterop.emitRustExpr v350 v351 
            let v353 : string = "true; $0 }); //"
            let v354 : bool = Fable.Core.RustInterop.emitRustExpr v352 v353 
            let v355 : string = "_result.map_err(|x| x.into())"
            let v356 : Result<unit, string> = Fable.Core.RustInterop.emitRustExpr () v355 
            let v357 : Result<unit, string> = method57(v356)
            let v358 : string = v274 + v275 
            let v359 : string = "v357 " + v358 + "); " + v274 + " //"
            Fable.Core.RustInterop.emitRustExpr () v359 
            let v360 : string = "__result"
            let v361 : std_thread_JoinHandle<Result<unit, string>> = Fable.Core.RustInterop.emitRustExpr () v360 
            let v362 : US20 option = None
            let _v362 = ref v362 
            match v4 with
            | Some x -> (
            (fun () ->
            (fun () ->
            let v363 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) = x
            let v364 : US20 = US20_0(v363)
            v364 
            )
            |> fun x -> x () |> Some
            ) () ) | None -> None
            |> fun x -> _v362.Value <- x
            let v365 : US20 option = _v362.Value 
            let v366 : US20 = US20_1
            let v367 : US20 = v365 |> Option.defaultValue v366 
            match v367 with
            | US20_1 -> (* None *)
                ()
            | US20_0(v368) -> (* Some *)
                let v369 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin option>> = method58(v185)
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
                let v392 : US21 option = None
                let _v392 = ref v392 
                match v391 with
                | Some x -> (
                (fun () ->
                (fun () ->
                let v393 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> = x
                let v394 : US21 = US21_0(v393)
                v394 
                )
                |> fun x -> x () |> Some
                ) () ) | None -> None
                |> fun x -> _v392.Value <- x
                let v395 : US21 option = _v392.Value 
                let v396 : US21 = US21_1
                let v397 : US21 = v395 |> Option.defaultValue v396 
                match v397 with
                | US21_1 -> (* None *)
                    ()
                | US21_0(v398) -> (* Some *)
                    v368 v398
                    let v399 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> = method59(v398)
                    let v400 : string = "v399.lock()"
                    let v401 : Result<std_sync_MutexGuard<std_process_ChildStdin>, std_sync_PoisonError<std_sync_MutexGuard<std_process_ChildStdin>>> = Fable.Core.RustInterop.emitRustExpr () v400 
                    let v402 : string = "$0.unwrap()"
                    let v403 : std_sync_MutexGuard<std_process_ChildStdin> = Fable.Core.RustInterop.emitRustExpr v401 v402 
                    let v404 : std_sync_MutexGuard<std_process_ChildStdin> = method60(v403)
                    let v405 : string = "true; let mut v404 = v404"
                    let v406 : bool = Fable.Core.RustInterop.emitRustExpr () v405 
                    let v407 : string = "true; std::io::Write::flush(&mut *$0).unwrap()"
                    let v408 : bool = Fable.Core.RustInterop.emitRustExpr v404 v407 
                    ()
            let v409 : std_sync_Arc<std_sync_Mutex<std_process_Child option>> = method52(v105)
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
            let v424 : (std_io_Error -> std_string_String) = method49()
            let v425 : string = "$0.map_err(|x| $1(x))"
            let v426 : Result<std_process_Output, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v423, v424) v425 
            let v427 : std_thread_JoinHandle<Result<unit, string>> = method61(v361)
            let v428 : string = "v427"
            let v429 : string = v428 + v274 
            let v430 : string = v429 + v274 
            let v431 : std_thread_JoinHandle<Result<unit, string>> = method61(v279)
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
            let v449 : (std_process_Output -> US22) = closure27()
            let v450 : (std_string_String -> US22) = closure28()
            let v451 : US22 = match v426 with Ok x -> v449 x | Error x -> v450 x
            match v451 with
            | US22_1(v461) -> (* Error *)
                let v462 : US0 = US0_4
                let v463 : (unit -> string) = closure29()
                let v464 : (unit -> string) = closure30(v461)
                method5(v462, v463, v464)
                let v465 : US5 = US5_0(v461)
                let v466 : US18 = US18_1
                struct (-2, v465, v466)
            | US22_0(v452) -> (* Ok *)
                let v453 : string = "$0.status"
                let v454 : std_process_ExitStatus = Fable.Core.RustInterop.emitRustExpr v452 v453 
                let v455 : string = "$0.code()"
                let v456 : int32 option = Fable.Core.RustInterop.emitRustExpr v454 v455 
                let v457 : string = "$0.unwrap()"
                let v458 : int32 = Fable.Core.RustInterop.emitRustExpr v456 v457 
                let v459 : US5 = US5_1
                let v460 : US18 = US18_0(v200)
                struct (v458, v459, v460)
    let v489 : std_sync_Arc<std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>> option =
        match v484 with
        | US18_1 -> (* None *)
            let v487 : std_sync_Arc<std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>> option = None
            v487
        | US18_0(v485) -> (* Some *)
            let v486 : std_sync_Arc<std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>> option = Some v485 
            v486
    let v490 : string = "true; let _result = v489.map(|x| { //"
    let v491 : bool = Fable.Core.RustInterop.emitRustExpr () v490 
    let v492 : string = "x"
    let v493 : std_sync_Arc<std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>> = Fable.Core.RustInterop.emitRustExpr () v492 
    let v494 : std_sync_Arc<std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>> = method62(v493)
    let v495 : string = "v494.lock()"
    let v496 : Result<std_sync_MutexGuard<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>, std_sync_PoisonError<std_sync_MutexGuard<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>>> = Fable.Core.RustInterop.emitRustExpr () v495 
    let v497 : string = "$0.unwrap()"
    let v498 : std_sync_MutexGuard<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr v496 v497 
    let v499 : string = "v498.iter()"
    let v500 : _ = Fable.Core.RustInterop.emitRustExpr () v499 
    let v501 : string = "v500.collect::<Vec<_>>()"
    let v502 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v501 
    let v503 : string = "true; let _result : Vec<_> = v502.into_iter().map(|x| { //"
    let v504 : bool = Fable.Core.RustInterop.emitRustExpr () v503 
    let v505 : string = "x"
    let v506 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v505 
    let v507 : string = "fable_library_rust::String_::fromString($0)"
    let v508 : string = Fable.Core.RustInterop.emitRustExpr v506 v507 
    let v509 : string = "true; $0 }).collect::<Vec<_>>()"
    let v510 : bool = Fable.Core.RustInterop.emitRustExpr v508 v509 
    let v511 : string = "_result"
    let v512 : Vec<string> = Fable.Core.RustInterop.emitRustExpr () v511 
    let v513 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v514 : (string []) = Fable.Core.RustInterop.emitRustExpr v512 v513 
    let v515 : ((string []) -> string seq) = Seq.ofArray
    let v516 : string seq = v515 v514
    let v517 : (string -> (string seq -> string)) = String.concat
    let v518 : string = "\n"
    let v519 : (string seq -> string) = v517 v518
    let v520 : string = v519 v516
    let v521 : string = "true; $0 })"
    let v522 : bool = Fable.Core.RustInterop.emitRustExpr v520 v521 
    let v523 : string = "_result"
    let v524 : string option = Fable.Core.RustInterop.emitRustExpr () v523 
    let v531 : US3 =
        match v483 with
        | US5_1 -> (* None *)
            US3_1
        | US5_0(v525) -> (* Some *)
            let v526 : string = "fable_library_rust::String_::fromString($0)"
            let v527 : string = Fable.Core.RustInterop.emitRustExpr v525 v526 
            US3_0(v527)
    let v535 : string =
        match v531 with
        | US3_1 -> (* None *)
            let v533 : string = ""
            v533
        | US3_0(v532) -> (* Some *)
            v532
    let v536 : string = v524 |> Option.defaultValue v535 
    let v537 : US0 = US0_0
    let v538 : (unit -> string) = closure31()
    let v539 : (unit -> string) = closure32(v482, v536)
    method5(v537, v538, v539)
    let v540 : (int32 * string) = v482, v536 
    v540 
    )
    |> fun x -> x ()
    ) () )
    |> fun x -> _v35 <- Some x
    let v541 : (int32 * string) = match _v35 with Some x -> x | None -> failwith "base.capture / _v35=None"
    let (a, b) = v541 
    let v542 : int32 = a
    let v543 : string = b
    struct (v542, v543) 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let struct (v544 : int32, v545 : string) = null |> unbox<struct (int32 * string)>
    struct (v544, v545) 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let struct (v546 : int32, v547 : string) = null |> unbox<struct (int32 * string)>
    struct (v546, v547) 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let struct (v548 : int32, v549 : string) = null |> unbox<struct (int32 * string)>
    struct (v548, v549) 
    #endif
#if FABLE_COMPILER_PYTHON
    let struct (v550 : int32, v551 : string) = null |> unbox<struct (int32 * string)>
    struct (v550, v551) 
    #endif
#else
    let v552 : Async<struct (int32 * string)> = method63(v0, v1, v2, v3, v4, v5, v6)
    let v553 : bool = true
    let mutable _v553 : struct (int32 * string) option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let struct (v554 : int32, v555 : string) = null |> unbox<struct (int32 * string)>
    struct (v554, v555) 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let struct (v556 : int32, v557 : string) = null |> unbox<struct (int32 * string)>
    struct (v556, v557) 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let struct (v558 : int32, v559 : string) = null |> unbox<struct (int32 * string)>
    struct (v558, v559) 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let struct (v560 : int32, v561 : string) = null |> unbox<struct (int32 * string)>
    struct (v560, v561) 
    #endif
#if FABLE_COMPILER_PYTHON
    let struct (v562 : int32, v563 : string) = null |> unbox<struct (int32 * string)>
    struct (v562, v563) 
    #endif
#else
    let v564 : (Async<struct (int32 * string)> -> struct (int32 * string)) = Async.RunSynchronously
    let struct (v565 : int32, v566 : string) = v564 v552
    struct (v565, v566) 
    #endif
    |> fun x -> _v553 <- Some x
    let struct (v567 : int32, v568 : string) = match _v553 with Some x -> x | None -> failwith "base.run_target / _v553=None"
    struct (v567, v568) 
    #endif
    |> fun x -> _v7 <- Some x
    let struct (v569 : int32, v570 : string) = match _v7 with Some x -> x | None -> failwith "base.run_target / _v7=None"
    struct (v569, v570)
and closure40 () () : string =
    let v0 : string = "spiral_builder.run / repl error"
    v0
and closure41 (v0 : uint8, v1 : uint8, v2 : string, v3 : int32) () : string =
    let v4 : (unit -> string) = closure6()
    let v5 : string = $"exit_code: {v3} / retry: {v1}/{v0} / repl_result: {v2} / {v4 ()}"
    v5
and method43 (v0 : string option, v1 : uint8, v2 : string, v3 : uint8) : struct (int32 * string) =
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
    let struct (v16 : int32, v17 : string) = method44(v4, v9, v14, v6, v7, v15, v0)
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
        let v22 : (unit -> string) = closure40()
        let v23 : (unit -> string) = closure41(v1, v3, v17, v16)
        method5(v21, v22, v23)
        let v24 : uint8 = v3 + 1uy
        method43(v0, v1, v2, v24)
and closure42 () () : string =
    let v0 : string = "spiral_builder.run / dib / jupyter nbconvert"
    v0
and closure43 (v0 : string, v1 : int32) () : string =
    let v2 : (unit -> string) = closure6()
    let v3 : string = $"exit_code: {v1} / jupyter_result.Length: {v0.Length} / {v2 ()}"
    v3
and closure44 () () : string =
    let v0 : string = "spiral_builder.run / dib / html cell ids"
    v0
and closure45 (v0 : string, v1 : int32) () : string =
    let v2 : (unit -> string) = closure6()
    let v3 : string = $"exit_code: {v1} / pwsh_replace_html_result.Length: {v0.Length} / {v2 ()}"
    v3
and method65 (v0 : string) : string =
    v0
and closure46 () () : string =
    let v0 : string = "spiral_builder.run / dib"
    v0
and closure47 (v0 : string, v1 : int32) () : string =
    let v2 : (unit -> string) = closure6()
    let v3 : string = $"exit_code: {v1} / result.Length: {v0.Length} / {v2 ()}"
    v3
and method66 () : string =
    let v0 : string = "deps"
    v0
and method68 () : string =
    let v0 : string = ""
    v0
and method67 (v0 : string) : string =
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
    while method16(v112, v114) do
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
    let v123 : string = method68()
    let v124 : (string -> (string seq -> string)) = String.concat
    let v125 : (string seq -> string) = v124 v123
    let v126 : string = v125 v122
    v126 
    #endif
    |> fun x -> _v1 <- Some x
    let v127 : string = match _v1 with Some x -> x | None -> failwith "base.run_target / _v1=None"
    v127
and method70 (v0 : string) : bool =
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
and method72 (v0 : string) : string option =
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
and closure48 () (v0 : string) : string option =
    method72(v0)
and method71 () : (string -> string option) =
    closure48()
and method73 (v0 : string, v1 : string, v2 : string) : string =
    let v3 : string = method30(v2, v0)
    let v4 : bool = method70(v3)
    if v4 then
        v2
    else
        let v5 : (string -> string option) = method71()
        let v6 : string option = v5 v2
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
            let v15 : string = $"""No parent for {if false then "file" else "dir"} '{v0}' at '{v1}' (until '{v2}')"""
            failwith<string> v15
        | US3_0(v13) -> (* Some *)
            method73(v0, v1, v13)
and method69 (v0 : string, v1 : string) : string =
    let v2 : string = method30(v1, v0)
    let v3 : bool = method70(v2)
    if v3 then
        v1
    else
        let v4 : (string -> string option) = method71()
        let v5 : string option = v4 v1
        let v6 : US3 option = None
        let _v6 = ref v6 
        match v5 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v7 : string = x
        let v8 : US3 = US3_0(v7)
        v8 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v6.Value <- x
        let v9 : US3 option = _v6.Value 
        let v10 : US3 = US3_1
        let v11 : US3 = v9 |> Option.defaultValue v10 
        match v11 with
        | US3_1 -> (* None *)
            let v14 : string = $"""No parent for {if false then "file" else "dir"} '{v0}' at '{v1}' (until '{v1}')"""
            failwith<string> v14
        | US3_0(v12) -> (* Some *)
            method73(v0, v1, v12)
and method75 (v0 : string) : string =
    v0
and closure49 () () : US26 =
    US26_0
and closure50 () (v0 : std_string_String) : US26 =
    US26_1(v0)
and closure51 () () : string =
    let v0 : string = "file_system.create_dir"
    v0
and closure52 (v0 : string, v1 : std_string_String) () : string =
    let v2 : (unit -> string) = closure6()
    let v3 : string = $"dir: {v0} / error: {v1} / {v2 ()}"
    v3
and closure53 () () : string =
    let v0 : string = "file_system.create_dir"
    v0
and closure54 (v0 : string) () : string =
    let v1 : (unit -> string) = closure6()
    let v2 : string = $"dir: {v0} / {v1 ()}"
    v2
and method78 (v0 : string) : string =
    v0
and method77 (v0 : bool, v1 : string) : unit =
    let v2 : bool = true
    let mutable _v2 : unit option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : string = method78(v1)
    let v4 : bool = method70(v3)
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
and closure55 (v0 : string) () : unit =
    let v1 : bool = true
    method77(v1, v0)
and method76 (v0 : string) : (unit -> unit) =
    closure55(v0)
and method79 (v0 : string) : (unit -> unit) =
    closure55(v0)
and closure56 () () : string =
    let v0 : string = "file_system.create_dir"
    v0
and closure57 (v0 : string, v1 : string) () : string =
    let v2 : (unit -> string) = closure6()
    let v3 : string = $"dir: {v0} / result: {v1} {v2 ()}"
    v3
and closure59 () () : string =
    let v0 : string = "file_system.delete_directory_async"
    v0
and method82 (v0 : string) : string =
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
    let v22 : US13 = US13_1
    let v23 : US14 = US14_0(v22)
    let v24 : string = $"file_system.get_file_name / target: {v23} / path: {v0}"
    let v25 : string = failwith<string> v24
    v25 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v26 : string = null |> unbox<string>
    v26 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v27 : US13 = US13_0
    let v28 : US14 = US14_2(v27)
    let v29 : string = $"file_system.get_file_name / target: {v28} / path: {v0}"
    let v30 : string = failwith<string> v29
    v30 
    #endif
#if FABLE_COMPILER_PYTHON
    let v31 : US13 = US13_0
    let v32 : US14 = US14_3(v31)
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
and closure61 () (v0 : string) : string =
    method82(v0)
and closure60 (v0 : string, v1 : string) () : string =
    let v2 : (string -> string) = closure61()
    let v3 : (unit -> string) = closure6()
    let v4 : string = $"path: {v0 |> v2} / ex: {v1} / {v3 ()}"
    v4
and method81 (v0 : string, v1 : int64) : Async<int64> =
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
    method77(v9, v0)
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
        let v22 : (unit -> string) = closure59()
        let v23 : (unit -> string) = closure60(v0, v20)
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
    let v34 : Async<int64> = method81(v0, v33)
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
and closure58 (v0 : string) () : unit =
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
    let v8 : Async<int64> = method81(v0, v7)
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
and method80 (v0 : string) : (unit -> unit) =
    closure58(v0)
and method83 (v0 : string) : (unit -> unit) =
    closure58(v0)
and method74 (v0 : string) : System.IDisposable =
    let v1 : bool = true
    let mutable _v1 : System.IDisposable option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = method75(v0)
    let v3 : string = "std::fs::create_dir_all(&*$0)"
    let v4 : Result<unit, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v2 v3 
    let v5 : (std_io_Error -> std_string_String) = method49()
    let v6 : string = "$0.map_err(|x| $1(x))"
    let v7 : Result<unit, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v4, v5) v6 
    let v8 : (unit -> US26) = closure49()
    let v9 : (std_string_String -> US26) = closure50()
    let v10 : US26 = match v7 with Ok () -> v8 () | Error x -> v9 x
    match v10 with
    | US26_1(v14) -> (* Error *)
        let v15 : US0 = US0_4
        let v16 : (unit -> string) = closure51()
        let v17 : (unit -> string) = closure52(v2, v14)
        method5(v15, v16, v17)
    | US26_0 -> (* Ok *)
        let v11 : US0 = US0_0
        let v12 : (unit -> string) = closure53()
        let v13 : (unit -> string) = closure54(v2)
        method5(v11, v12, v13)
    let v18 : bool = true
    let mutable _v18 : System.IDisposable option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v19 : (unit -> unit) = method76(v2)
    let v20 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v19 "$0()" )
    v20 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v21 : (unit -> unit) = method76(v2)
    let v22 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v21 "$0()" )
    v22 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v23 : (unit -> unit) = method76(v2)
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
    let v27 : (unit -> unit) = method79(v2)
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
        let v61 : (unit -> string) = closure56()
        let v62 : (unit -> string) = closure57(v0, v59)
        method5(v60, v61, v62)
    let v63 : bool = true
    let mutable _v63 : System.IDisposable option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v64 : (unit -> unit) = method80(v0)
    let v65 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v64 "$0()" )
    v65 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v66 : (unit -> unit) = method80(v0)
    let v67 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v66 "$0()" )
    v67 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v68 : (unit -> unit) = method80(v0)
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
    let v72 : (unit -> unit) = method83(v0)
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
        let v104 : (unit -> string) = closure56()
        let v105 : (unit -> string) = closure57(v0, v102)
        method5(v103, v104, v105)
    let v106 : bool = true
    let mutable _v106 : System.IDisposable option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v107 : (unit -> unit) = method80(v0)
    let v108 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v107 "$0()" )
    v108 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v109 : (unit -> unit) = method80(v0)
    let v110 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v109 "$0()" )
    v110 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v111 : (unit -> unit) = method80(v0)
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
    let v115 : (unit -> unit) = method83(v0)
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
        let v147 : (unit -> string) = closure56()
        let v148 : (unit -> string) = closure57(v0, v145)
        method5(v146, v147, v148)
    let v149 : bool = true
    let mutable _v149 : System.IDisposable option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v150 : (unit -> unit) = method80(v0)
    let v151 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v150 "$0()" )
    v151 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v152 : (unit -> unit) = method80(v0)
    let v153 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v152 "$0()" )
    v153 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v154 : (unit -> unit) = method80(v0)
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
    let v158 : (unit -> unit) = method83(v0)
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
and method85 (v0 : string) : bool =
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
and method84 (v0 : string, v1 : string) : bool =
    let v2 : bool = true
    let mutable _v2 : bool option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : bool = method85(v0)
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
and method86 (v0 : string) : string =
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
and method88 (v0 : chrono_DateTime<chrono_Utc>) : chrono_DateTime<chrono_Utc> =
    v0
and method89 (v0 : chrono_DateTime<chrono_Local>) : chrono_DateTime<chrono_Local> =
    v0
and method90 () : string =
    let v0 : string = "hh:mm"
    v0
and method91 () : string =
    let v0 : string = "yyyyMMdd-HHmm-ssff-ffff-f"
    v0
and method92 () : string =
    let v0 : string = "hhmm"
    v0
and method87 (v0 : System.Guid, v1 : System.DateTime) : System.Guid =
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
    let v18 : US27 option = None
    let _v18 = ref v18 
    match v17 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v19 : chrono_DateTime<chrono_Utc> = x
    let v20 : US27 = US27_0(v19)
    v20 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v18.Value <- x
    let v21 : US27 option = _v18.Value 
    let v22 : US27 = US27_1
    let v23 : US27 = v21 |> Option.defaultValue v22 
    let v42 : US3 =
        match v23 with
        | US27_1 -> (* None *)
            US3_1
        | US27_0(v24) -> (* Some *)
            let v25 : chrono_DateTime<chrono_Utc> = method88(v24)
            let v26 : string = "v25.naive_utc()"
            let v27 : chrono_NaiveDateTime = Fable.Core.RustInterop.emitRustExpr () v26 
            let v28 : string = "chrono::offset::TimeZone::from_utc_datetime(&chrono::Local, &v27)"
            let v29 : chrono_DateTime<chrono_Local> = Fable.Core.RustInterop.emitRustExpr () v28 
            let v30 : string = "%Y%m%d-%H%M-%S%f"
            let v31 : string = "r#\"" + v30 + "\"#"
            let v32 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v31 
            let v33 : chrono_DateTime<chrono_Local> = method89(v29)
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
    let v63 : US13 = US13_0
    let v64 : US14 = US14_2(v63)
    let v65 : string = $"date_time.get_utc_offset / target: {v64}"
    let v66 : System.TimeSpan = failwith<System.TimeSpan> v65
    v66 
    #endif
#if FABLE_COMPILER_PYTHON
    let v67 : US13 = US13_0
    let v68 : US14 = US14_3(v67)
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
    let v88 : string = method90()
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
    let v116 : US27 option = None
    let _v116 = ref v116 
    match v115 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v117 : chrono_DateTime<chrono_Utc> = x
    let v118 : US27 = US27_0(v117)
    v118 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v116.Value <- x
    let v119 : US27 option = _v116.Value 
    let v120 : US27 = US27_1
    let v121 : US27 = v119 |> Option.defaultValue v120 
    let v140 : US3 =
        match v121 with
        | US27_1 -> (* None *)
            US3_1
        | US27_0(v122) -> (* Some *)
            let v123 : chrono_DateTime<chrono_Utc> = method88(v122)
            let v124 : string = "v123.naive_utc()"
            let v125 : chrono_NaiveDateTime = Fable.Core.RustInterop.emitRustExpr () v124 
            let v126 : string = "chrono::offset::TimeZone::from_utc_datetime(&chrono::Local, &v125)"
            let v127 : chrono_DateTime<chrono_Local> = Fable.Core.RustInterop.emitRustExpr () v126 
            let v128 : string = "%Y%m%d-%H%M-%S%f"
            let v129 : string = "r#\"" + v128 + "\"#"
            let v130 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v129 
            let v131 : chrono_DateTime<chrono_Local> = method89(v127)
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
    let v161 : US13 = US13_0
    let v162 : US14 = US14_2(v161)
    let v163 : string = $"date_time.get_utc_offset / target: {v162}"
    let v164 : System.TimeSpan = failwith<System.TimeSpan> v163
    v164 
    #endif
#if FABLE_COMPILER_PYTHON
    let v165 : US13 = US13_0
    let v166 : US14 = US14_3(v165)
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
    let v186 : string = method90()
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
    let v200 : string = method91()
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
    let v219 : US13 = US13_0
    let v220 : US14 = US14_2(v219)
    let v221 : string = $"date_time.get_utc_offset / target: {v220}"
    let v222 : System.TimeSpan = failwith<System.TimeSpan> v221
    v222 
    #endif
#if FABLE_COMPILER_PYTHON
    let v223 : US13 = US13_0
    let v224 : US14 = US14_3(v223)
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
    let v243 : (bool -> int32) = System.Convert.ToInt32
    let v244 : int32 = v243 v242
    let v245 : string = method92()
    let v246 : bool = true
    let mutable _v246 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v247 : string = v239.ToString v245 
    v247 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v248 : string = v239.ToString v245 
    v248 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v249 : string = v239.ToString v245 
    v249 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v250 : string = v239.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    v250 
    #endif
#if FABLE_COMPILER_PYTHON
    let v251 : string = v239.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    v251 
    #endif
#else
    let v252 : string = v239.ToString v245 
    v252 
    #endif
    |> fun x -> _v246 <- Some x
    let v253 : string = match _v246 with Some x -> x | None -> failwith "base.run_target / _v246=None"
    let v254 : string = $"{v244}{v253}"
    let v255 : (System.Guid -> string) = _.ToString()
    let v256 : string = v255 v0
    let v257 : System.Guid = System.Guid $"{v202}{v254}{v256.[v202.Length + v254.Length..]}"
    v257 
    #endif
#if FABLE_COMPILER_PYTHON
    let v258 : string = method91()
    let v259 : (string -> string) = v1.ToString
    let v260 : string = v259 v258
    let v261 : bool = true
    let mutable _v261 : System.TimeZoneInfo option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v262 : string = "0i64.into()"
    let v263 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v262 
    v263 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v264 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v264 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v265 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v265 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v266 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v266 
    #endif
#if FABLE_COMPILER_PYTHON
    let v267 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v267 
    #endif
#else
    let v268 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    v268 
    #endif
    |> fun x -> _v261 <- Some x
    let v269 : System.TimeZoneInfo = match _v261 with Some x -> x | None -> failwith "base.run_target / _v261=None"
    let v270 : bool = true
    let mutable _v270 : System.TimeSpan option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v271 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v272 : System.TimeSpan = v271 ()
    v272 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v273 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v274 : System.TimeSpan = v273 ()
    v274 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v275 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v276 : System.TimeSpan = v275 ()
    v276 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v277 : US13 = US13_0
    let v278 : US14 = US14_2(v277)
    let v279 : string = $"date_time.get_utc_offset / target: {v278}"
    let v280 : System.TimeSpan = failwith<System.TimeSpan> v279
    v280 
    #endif
#if FABLE_COMPILER_PYTHON
    let v281 : US13 = US13_0
    let v282 : US14 = US14_3(v281)
    let v283 : string = $"date_time.get_utc_offset / target: {v282}"
    let v284 : System.TimeSpan = failwith<System.TimeSpan> v283
    v284 
    #endif
#else
    let v285 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v286 : bool = true
    let mutable _v286 : System.TimeZoneInfo option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v287 : string = "0i64.into()"
    let v288 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v287 
    v288 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v289 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v289 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v290 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v290 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v291 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v291 
    #endif
#if FABLE_COMPILER_PYTHON
    let v292 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v292 
    #endif
#else
    let v293 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    v293 
    #endif
    |> fun x -> _v286 <- Some x
    let v294 : System.TimeZoneInfo = match _v286 with Some x -> x | None -> failwith "base.run_target / _v286=None"
    let v295 : (System.DateTime -> System.TimeSpan) = v285 v294
    let v296 : System.TimeSpan = v295 v1
    v296 
    #endif
    |> fun x -> _v270 <- Some x
    let v297 : System.TimeSpan = match _v270 with Some x -> x | None -> failwith "base.run_target / _v270=None"
    let v298 : (System.TimeSpan -> int32) = _.Hours
    let v299 : int32 = v298 v297
    let v300 : bool = v299 > 0
    let v301 : (bool -> int32) = System.Convert.ToInt32
    let v302 : int32 = v301 v300
    let v303 : string = method92()
    let v304 : bool = true
    let mutable _v304 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v305 : string = v297.ToString v303 
    v305 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v306 : string = v297.ToString v303 
    v306 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v307 : string = v297.ToString v303 
    v307 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v308 : string = v297.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    v308 
    #endif
#if FABLE_COMPILER_PYTHON
    let v309 : string = v297.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    v309 
    #endif
#else
    let v310 : string = v297.ToString v303 
    v310 
    #endif
    |> fun x -> _v304 <- Some x
    let v311 : string = match _v304 with Some x -> x | None -> failwith "base.run_target / _v304=None"
    let v312 : string = $"{v302}{v311}"
    let v313 : (System.Guid -> string) = _.ToString()
    let v314 : string = v313 v0
    let v315 : System.Guid = System.Guid $"{v260}{v312}{v314.[v260.Length + v312.Length..]}"
    v315 
    #endif
#else
    let v316 : string = method91()
    let v317 : (string -> string) = v1.ToString
    let v318 : string = v317 v316
    let v319 : bool = true
    let mutable _v319 : System.TimeZoneInfo option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v320 : string = "0i64.into()"
    let v321 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v320 
    v321 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v322 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v322 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v323 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v323 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v324 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v324 
    #endif
#if FABLE_COMPILER_PYTHON
    let v325 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v325 
    #endif
#else
    let v326 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    v326 
    #endif
    |> fun x -> _v319 <- Some x
    let v327 : System.TimeZoneInfo = match _v319 with Some x -> x | None -> failwith "base.run_target / _v319=None"
    let v328 : bool = true
    let mutable _v328 : System.TimeSpan option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v329 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v330 : System.TimeSpan = v329 ()
    v330 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v331 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v332 : System.TimeSpan = v331 ()
    v332 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v333 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v334 : System.TimeSpan = v333 ()
    v334 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v335 : US13 = US13_0
    let v336 : US14 = US14_2(v335)
    let v337 : string = $"date_time.get_utc_offset / target: {v336}"
    let v338 : System.TimeSpan = failwith<System.TimeSpan> v337
    v338 
    #endif
#if FABLE_COMPILER_PYTHON
    let v339 : US13 = US13_0
    let v340 : US14 = US14_3(v339)
    let v341 : string = $"date_time.get_utc_offset / target: {v340}"
    let v342 : System.TimeSpan = failwith<System.TimeSpan> v341
    v342 
    #endif
#else
    let v343 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v344 : bool = true
    let mutable _v344 : System.TimeZoneInfo option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v345 : string = "0i64.into()"
    let v346 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v345 
    v346 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v347 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v347 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v348 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v348 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v349 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v349 
    #endif
#if FABLE_COMPILER_PYTHON
    let v350 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v350 
    #endif
#else
    let v351 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    v351 
    #endif
    |> fun x -> _v344 <- Some x
    let v352 : System.TimeZoneInfo = match _v344 with Some x -> x | None -> failwith "base.run_target / _v344=None"
    let v353 : (System.DateTime -> System.TimeSpan) = v343 v352
    let v354 : System.TimeSpan = v353 v1
    v354 
    #endif
    |> fun x -> _v328 <- Some x
    let v355 : System.TimeSpan = match _v328 with Some x -> x | None -> failwith "base.run_target / _v328=None"
    let v356 : (System.TimeSpan -> int32) = _.Hours
    let v357 : int32 = v356 v355
    let v358 : bool = v357 > 0
    let v359 : (bool -> int32) = System.Convert.ToInt32
    let v360 : int32 = v359 v358
    let v361 : string = method92()
    let v362 : bool = true
    let mutable _v362 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v363 : string = v355.ToString v361 
    v363 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v364 : string = v355.ToString v361 
    v364 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v365 : string = v355.ToString v361 
    v365 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v366 : string = v355.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    v366 
    #endif
#if FABLE_COMPILER_PYTHON
    let v367 : string = v355.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    v367 
    #endif
#else
    let v368 : string = v355.ToString v361 
    v368 
    #endif
    |> fun x -> _v362 <- Some x
    let v369 : string = match _v362 with Some x -> x | None -> failwith "base.run_target / _v362=None"
    let v370 : string = $"{v360}{v369}"
    let v371 : (System.Guid -> string) = _.ToString()
    let v372 : string = v371 v0
    let v373 : System.Guid = System.Guid $"{v318}{v370}{v372.[v318.Length + v370.Length..]}"
    v373 
    #endif
    |> fun x -> _v2 <- Some x
    let v374 : System.Guid = match _v2 with Some x -> x | None -> failwith "base.run_target / _v2=None"
    v374
and closure62 () () : string =
    let v0 : string = "common.retry_fn' / loop"
    v0
and closure63 (v0 : uint8, v1 : int32, v2 : string, v3 : bool) () : string =
    let v4 : (unit -> string) = closure6()
    let v5 : string = $"is_error: {v3} / retry: {v0}/{3uy} / result: %A{struct (v1, v2)} / {v4 ()}"
    v5
and method94 (v0 : string, v1 : string, v2 : string, v3 : US28, v4 : uint8) : struct (int32 * string) =
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
    let v12 : US13 = US13_0
    let v13 : US14 = US14_2(v12)
    let v14 : string = $"runtime.is_windows / target: {v13}"
    let v15 : bool = failwith<bool> v14
    v15 
    #endif
#if FABLE_COMPILER_PYTHON
    let v16 : US13 = US13_0
    let v17 : US14 = US14_3(v16)
    let v18 : string = $"runtime.is_windows / target: {v17}"
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
        | US28_1(v35) -> (* Error *)
            let v36 : Result<string, string> = Error v35 
            v36
        | US28_0(v33) -> (* Ok *)
            let v34 : Result<string, string> = Ok v33 
            v34
    let v39 : string = "v38.ok()"
    let v40 : string option = Fable.Core.RustInterop.emitRustExpr () v39 
    let v41 : bool = true
    let struct (v42 : int32, v43 : string) = method44(v27, v32, v28, v29, v30, v41, v40)
    let v44 : bool = v42 = 0
    let v47 : US29 =
        if v44 then
            US29_0(v42, v43)
        else
            US29_1(v42, v43)
    let struct (v55 : bool, v56 : int32, v57 : string) =
        match v47 with
        | US29_1(v50, v51) -> (* Error *)
            struct (true, v50, v51)
        | US29_0(v48, v49) -> (* Ok *)
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
        let v62 : (unit -> string) = closure62()
        let v63 : (unit -> string) = closure63(v4, v56, v57, v55)
        method5(v61, v62, v63)
        let v64 : uint8 = v4 + 1uy
        method94(v0, v1, v2, v3, v64)
and method93 (v0 : string, v1 : string, v2 : string, v3 : US28) : struct (int32 * string) =
    let v4 : uint8 = 1uy
    method94(v0, v1, v2, v3, v4)
and closure64 () () : string =
    let v0 : string = "spiral_builder.process_rust / dotnet fable error"
    v0
and closure65 (v0 : string, v1 : int32) () : string =
    let v2 : (unit -> string) = closure6()
    let v3 : string = $"exit_code: {v1} / dotnet_fable_result: {v0} / {v2 ()}"
    v3
and method96 () : string =
    let v0 : string = "a"
    v0
and method95 (v0 : string, v1 : US28, v2 : uint8) : struct (int32 * string) =
    let v3 : System.Threading.CancellationToken option = None
    let v4 : (struct (string * string) []) = [||]
    let v5 : (struct (bool * string * int32) -> Async<unit>) option = None
    let v6 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = None
    let v7 : string option = None
    let v8 : string = $"cargo fmt --manifest-path \"{v0}\" --"
    let v14 : Result<string, string> =
        match v1 with
        | US28_1(v11) -> (* Error *)
            let v12 : Result<string, string> = Error v11 
            v12
        | US28_0(v9) -> (* Ok *)
            let v10 : Result<string, string> = Ok v9 
            v10
    let v15 : string = "v14.ok()"
    let v16 : string option = Fable.Core.RustInterop.emitRustExpr () v15 
    let v17 : bool = true
    let struct (v18 : int32, v19 : string) = method44(v3, v8, v4, v5, v6, v17, v16)
    let v20 : string = "failed to load manifest for workspace member"
    let v21 : bool = v19.Contains v20 
    let v22 : bool = v21 = false
    let v152 : US29 =
        if v22 then
            let v23 : bool = v18 = 0
            if v23 then
                US29_0(v18, v19)
            else
                US29_1(v18, v19)
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
            let v80 : US30 option = None
            let _v80 = ref v80 
            match v79 with
            | Some x -> (
            (fun () ->
            (fun () ->
            let v81 : std_collections_HashMap<string, string> = x
            let v82 : US30 = US30_0(v81)
            v82 
            )
            |> fun x -> x () |> Some
            ) () ) | None -> None
            |> fun x -> _v80.Value <- x
            let v83 : US30 option = _v80.Value 
            let v84 : US30 = US30_1
            let v85 : US30 = v83 |> Option.defaultValue v84 
            let v99 : US31 =
                match v85 with
                | US30_1 -> (* None *)
                    US31_1
                | US30_0(v86) -> (* Some *)
                    let v87 : string = method96()
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
                    US31_0(v95)
            let v106 : US3 =
                match v99 with
                | US31_0(v100) -> (* Some *)
                    match v100 with
                    | US3_0(v101) -> (* Some *)
                        US3_0(v101)
                    | _ ->
                        US3_1
                | _ ->
                    US3_1
            match v106 with
            | US3_1 -> (* None *)
                US29_1(v18, v19)
            | US3_0(v108) -> (* Some *)
                let v109 : bool = method85(v108)
                let v110 : bool = v109 = false
                if v110 then
                    let v111 : string = method86(v108)
                    let v112 : System.IDisposable = method74(v111)
                    let v113 : System.DateTime = System.DateTime.Now
                    let v114 : (unit -> System.Guid) = System.Guid.NewGuid
                    let v115 : System.Guid = v114 ()
                    let v116 : System.Guid = method87(v115, v113)
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
                    let v145 : string = method65(v142)
                    System.IO.File.WriteAllText (v108, v145)
                    () 
                    #endif
                    |> fun x -> _v143 <- Some x
                    match _v143 with Some x -> x | None -> failwith "base.run_target / _v143=None"
                    ()
                let v146 : bool = v18 = 0
                if v146 then
                    US29_0(v18, v19)
                else
                    US29_1(v18, v19)
    let struct (v160 : bool, v161 : int32, v162 : string) =
        match v152 with
        | US29_1(v155, v156) -> (* Error *)
            struct (true, v155, v156)
        | US29_0(v153, v154) -> (* Ok *)
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
        let v167 : (unit -> string) = closure62()
        let v168 : (unit -> string) = closure63(v2, v161, v162, v160)
        method5(v166, v167, v168)
        let v169 : uint8 = v2 + 1uy
        method95(v0, v1, v169)
and closure66 () () : string =
    let v0 : string = "spiral_builder.process_rust / cargo fmt error"
    v0
and closure67 (v0 : string, v1 : int32) () : string =
    let v2 : (unit -> string) = closure6()
    let v3 : string = $"exit_code: {v1} / cargo_fmt_result: {v0} / {v2 ()}"
    v3
and method97 () : string =
    let v0 : string = " defaultOf::<()>();"
    v0
and method98 () : string =
    let v0 : string = "\\s\\sdefaultOf\\(\\);"
    v0
and closure68 () () : string =
    let v0 : string = "spiral_builder.process_rust"
    v0
and closure69 (v0 : string, v1 : bool, v2 : string, v3 : bool, v4 : string, v5 : bool, v6 : string, v7 : bool) () : string =
    let v8 : UH3 = UH3_0
    let v9 : UH3 = UH3_1(v6, v7, v8)
    let v10 : UH3 = UH3_1(v4, v5, v9)
    let v11 : UH3 = UH3_1(v2, v3, v10)
    let v12 : UH3 = UH3_1(v0, v1, v11)
    let v13 : (unit -> string) = closure6()
    let v14 : string = $"cleanup: %A{v12} / {v13 ()}"
    v14
and method99 (v0 : UH3) : unit =
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
        method99(v3)
    | UH3_0 -> (* Nil *)
        ()
and closure71 () (v0 : string) : bool =
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
and closure70 (v0 : string) () : string =
    let v1 : string = "\n"
    let v2 : (string []) = v0.Split v1 
    let v3 : ((string -> bool) -> ((string []) -> (string []))) = Array.skipWhile
    let v4 : (string -> bool) = closure71()
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
and closure72 () (v0 : string) : US3 =
    US3_0(v0)
and closure74 () () : string =
    let v0 : string = "spiral_builder.process_rust / Exception"
    v0
and closure75 (v0 : string, v1 : string, v2 : string, v3 : exn) () : string =
    let v4 : (unit -> string) = closure6()
    let v5 : string = $"ex: {v3} / new_code_path: {v0} / external_command: {v2} / cargo_run_result: {v1} / {v4 ()}"
    v5
and closure73 (v0 : string, v1 : string, v2 : string) (v3 : exn) : US3 =
    let v4 : US0 = US0_4
    let v5 : (unit -> string) = closure74()
    let v6 : (unit -> string) = closure75(v0, v1, v2, v3)
    method5(v4, v5, v6)
    US3_1
and closure76 () () : string =
    let v0 : string = "spiral_builder.process_rust / error"
    v0
and closure77 (v0 : string, v1 : string, v2 : int32, v3 : string) () : string =
    let v4 : string = $"exit_code: {v2} / new_code_path: {v0} / external_command: {v3} / cargo_run_result: {v1}"
    v4
and method102 (v0 : async_walkdir_DirEntry) : async_walkdir_DirEntry =
    v0
and closure79 () (v0 : std_fs_FileType) : US33 =
    US33_0(v0)
and closure80 () (v0 : std_string_String) : US33 =
    US33_1(v0)
and method103 (v0 : std_fs_FileType) : std_fs_FileType =
    v0
and method104 (v0 : US32) : US32 =
    v0
and method101 (v0 : async_walkdir_DirEntry) : std_pin_Pin<Box<LifetimeJoin<Dyn<std_future_Future<US32>>, Send<Dyn<std_future_Future<US32>>>>>> =
    let v1 : string = "let __result = Box::pin(async move { //"
    Fable.Core.RustInterop.emitRustExpr () v1 
    let v2 : async_walkdir_DirEntry = method102(v0)
    let v3 : string = "Box::pin(async_walkdir::DirEntry::file_type(&v2))"
    let v4 : std_pin_Pin<Box<LifetimeJoin<Dyn<std_future_Future<Result<std_fs_FileType, std_io_Error>>>, Send<Dyn<std_future_Future<Result<std_fs_FileType, std_io_Error>>>>>>> = Fable.Core.RustInterop.emitRustExpr () v3 
    let v5 : string = "v4.await"
    let v6 : Result<std_fs_FileType, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v5 
    let v7 : (std_io_Error -> std_string_String) = method49()
    let v8 : string = "$0.map_err(|x| $1(x))"
    let v9 : Result<std_fs_FileType, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v6, v7) v8 
    let v10 : (std_fs_FileType -> US33) = closure79()
    let v11 : (std_string_String -> US33) = closure80()
    let v12 : US33 = match v9 with Ok x -> v10 x | Error x -> v11 x
    let v22 : US32 =
        match v12 with
        | US33_0(v13) -> (* Ok *)
            let v14 : std_fs_FileType = method103(v13)
            let v15 : string = "std::fs::FileType::is_dir(&v14)"
            let v16 : bool = Fable.Core.RustInterop.emitRustExpr () v15 
            let v17 : bool = v16 = false
            if v17 then
                US32_0
            else
                US32_2
        | _ ->
            US32_2
    let v23 : US32 = method104(v22)
    let v24 : string = ""
    let v25 : string = "}"
    let v26 : string = v24 + v25 
    let v27 : string = v26 + v25 
    let v28 : string = "{"
    let v29 : string = v24 + v28 
    let v30 : string = "v23 " + v27 + "); " + v29 + " //"
    Fable.Core.RustInterop.emitRustExpr () v30 
    let v31 : string = "__result"
    let v32 : std_pin_Pin<Box<LifetimeJoin<Dyn<std_future_Future<US32>>, Send<Dyn<std_future_Future<US32>>>>>> = Fable.Core.RustInterop.emitRustExpr () v31 
    v32
and method105 (v0 : async_walkdir_Filtering) : async_walkdir_Filtering =
    v0
and method100 (v0 : async_walkdir_DirEntry) : std_pin_Pin<Box<LifetimeJoin<Dyn<std_future_Future<async_walkdir_Filtering>>, Send<Dyn<std_future_Future<async_walkdir_Filtering>>>>>> =
    let v1 : string = "let __result = Box::pin(async { //"
    Fable.Core.RustInterop.emitRustExpr () v1 
    let v2 : std_pin_Pin<Box<LifetimeJoin<Dyn<std_future_Future<US32>>, Send<Dyn<std_future_Future<US32>>>>>> = method101(v0)
    let v3 : string = "v2.await"
    let v4 : US32 = Fable.Core.RustInterop.emitRustExpr () v3 
    let v13 : async_walkdir_Filtering =
        match v4 with
        | US32_2 -> (* Continue *)
            let v9 : string = "async_walkdir::Filtering::Continue"
            let v10 : async_walkdir_Filtering = Fable.Core.RustInterop.emitRustExpr () v9 
            v10
        | US32_0 -> (* Ignore *)
            let v5 : string = "async_walkdir::Filtering::Ignore"
            let v6 : async_walkdir_Filtering = Fable.Core.RustInterop.emitRustExpr () v5 
            v6
        | US32_1 -> (* IgnoreDir *)
            let v7 : string = "async_walkdir::Filtering::IgnoreDir"
            let v8 : async_walkdir_Filtering = Fable.Core.RustInterop.emitRustExpr () v7 
            v8
    let v14 : async_walkdir_Filtering = method105(v13)
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
and closure78 () (v0 : async_walkdir_DirEntry) : std_pin_Pin<Box<LifetimeJoin<Dyn<std_future_Future<async_walkdir_Filtering>>, Send<Dyn<std_future_Future<async_walkdir_Filtering>>>>>> =
    method100(v0)
and closure82 () (v0 : async_walkdir_DirEntry) : US34 =
    US34_0(v0)
and closure83 () (v0 : std_string_String) : US34 =
    US34_1(v0)
and closure84 () () : string =
    let v0 : string = "spiral_builder.process_typescript / stream_filter_map"
    v0
and closure85 (v0 : std_string_String) () : string =
    let v1 : (unit -> string) = closure6()
    let v2 : string = $"error: {v0} / {v1 ()}"
    v2
and closure81 () (v0 : Result<async_walkdir_DirEntry, std_io_Error>) : struct (string * string) option =
    let v1 : (std_io_Error -> std_string_String) = method49()
    let v2 : string = "$0.map_err(|x| $1(x))"
    let v3 : Result<async_walkdir_DirEntry, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v0, v1) v2 
    let v4 : (async_walkdir_DirEntry -> US34) = closure82()
    let v5 : (std_string_String -> US34) = closure83()
    let v6 : US34 = match v3 with Ok x -> v4 x | Error x -> v5 x
    let v117 : US35 =
        match v6 with
        | US34_1(v111) -> (* Error *)
            let v112 : US0 = US0_4
            let v113 : (unit -> string) = closure84()
            let v114 : (unit -> string) = closure85(v111)
            method5(v112, v113, v114)
            US35_1
        | US34_0(v7) -> (* Ok *)
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
            let v79 : US30 option = None
            let _v79 = ref v79 
            match v78 with
            | Some x -> (
            (fun () ->
            (fun () ->
            let v80 : std_collections_HashMap<string, string> = x
            let v81 : US30 = US30_0(v80)
            v81 
            )
            |> fun x -> x () |> Some
            ) () ) | None -> None
            |> fun x -> _v79.Value <- x
            let v82 : US30 option = _v79.Value 
            let v83 : US30 = US30_1
            let v84 : US30 = v82 |> Option.defaultValue v83 
            let v98 : US31 =
                match v84 with
                | US30_1 -> (* None *)
                    US31_1
                | US30_0(v85) -> (* Some *)
                    let v86 : string = method96()
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
                    US31_0(v94)
            let v105 : US3 =
                match v98 with
                | US31_0(v99) -> (* Some *)
                    match v99 with
                    | US3_0(v100) -> (* Some *)
                        US3_0(v100)
                    | _ ->
                        US3_1
                | _ ->
                    US3_1
            match v105 with
            | US3_1 -> (* None *)
                US35_1
            | US3_0(v107) -> (* Some *)
                US35_0(v24, v107)
    match v117 with
    | US35_1 -> (* None *)
        let v121 : struct (string * string) option = None
        v121
    | US35_0(v118, v119) -> (* Some *)
        let v120 : struct (string * string) option = Some struct (v118, v119) 
        v120
and method106 () : (Result<async_walkdir_DirEntry, std_io_Error> -> struct (string * string) option) =
    closure81()
and closure86 () struct (v0 : string, v1 : string) : struct (string * string) =
    struct (v0, v1)
and closure87 () () : string =
    let v0 : string = "spiral_builder.process_typescript"
    v0
and closure88 (v0 : US35) () : string =
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
and closure89 (v0 : string, v1 : int32) () : string =
    let v2 : string = $"spiral_builder.process_typescript / exit_code: {v1} / dotnet_fable_result: {v0}"
    v2
and method107 () : string =
    let v0 : string = ""
    v0
and closure90 () () : string =
    let v0 : string = "spiral_builder.process_typescript"
    v0
and closure91 (v0 : string) () : string =
    let v1 : (unit -> string) = closure6()
    let v2 : string = $"new_code_path: {v0} / {v1 ()}"
    v2
and closure92 (v0 : string) () : string =
    let v1 : string = "\n"
    let v2 : (string []) = v0.Split v1 
    let v3 : ((string []) -> string seq) = Seq.ofArray
    let v4 : string seq = v3 v2
    let v5 : (string -> (string seq -> string)) = String.concat
    let v6 : (string seq -> string) = v5 v1
    v6 v4
and closure94 () () : string =
    let v0 : string = "spiral_builder.process_typescript / Exception"
    v0
and closure95 (v0 : string, v1 : string, v2 : string, v3 : exn) () : string =
    let v4 : (unit -> string) = closure6()
    let v5 : string = $"ex: {v3} / new_code_path: {v0} / external_command: {v2} / run_result: {v1} / {v4 ()}"
    v5
and closure93 (v0 : string, v1 : string, v2 : string) (v3 : exn) : US3 =
    let v4 : US0 = US0_4
    let v5 : (unit -> string) = closure94()
    let v6 : (unit -> string) = closure95(v0, v1, v2, v3)
    method5(v4, v5, v6)
    US3_1
and closure96 () () : string =
    let v0 : string = "spiral_builder.process_typescript / error"
    v0
and closure97 (v0 : string, v1 : string, v2 : int32, v3 : string) () : string =
    let v4 : string = $"exit_code: {v2} / new_code_path: {v0} / external_command: {v3} / run_result: {v1}"
    v4
and closure98 (v0 : string, v1 : int32) () : string =
    let v2 : string = $"spiral_builder.process_python / exit_code: {v1} / dotnet_fable_result: {v0}"
    v2
and closure99 () () : string =
    let v0 : string = "spiral_builder.process_python"
    v0
and closure100 (v0 : string) () : string =
    let v1 : (unit -> string) = closure6()
    let v2 : string = $"new_code_path: {v0} / {v1 ()}"
    v2
and closure101 (v0 : string) () : string =
    let v1 : string = "\n"
    let v2 : (string []) = v0.Split v1 
    let v3 : ((string []) -> string seq) = Seq.ofArray
    let v4 : string seq = v3 v2
    let v5 : (string -> (string seq -> string)) = String.concat
    let v6 : (string seq -> string) = v5 v1
    v6 v4
and closure103 () () : string =
    let v0 : string = "spiral_builder.process_python / Exception"
    v0
and closure104 (v0 : string, v1 : string, v2 : string, v3 : exn) () : string =
    let v4 : (unit -> string) = closure6()
    let v5 : string = $"ex: {v3} / new_code_path: {v0} / external_command: {v2} / run_result: {v1} / {v4 ()}"
    v5
and closure102 (v0 : string, v1 : string, v2 : string) (v3 : exn) : US3 =
    let v4 : US0 = US0_4
    let v5 : (unit -> string) = closure103()
    let v6 : (unit -> string) = closure104(v0, v1, v2, v3)
    method5(v4, v5, v6)
    US3_1
and closure105 () () : string =
    let v0 : string = "spiral_builder.process_python / error"
    v0
and closure106 (v0 : string, v1 : string, v2 : int32, v3 : string) () : string =
    let v4 : string = $"exit_code: {v2} / new_code_path: {v0} / external_command: {v3} / run_result: {v1}"
    v4
and closure107 () () : string =
    let v0 : string = "spiral_builder.run / invalid subcommand"
    v0
and closure108 (v0 : clap_ArgMatches, v1 : std_string_String) () : string =
    let v2 : (unit -> string) = closure6()
    let v3 : string = $"subcommand: {v1} / arg_matches: %A{v0} / {v2 ()}"
    v3
and closure109 () struct (v0 : string, v1 : string) : (std_string_String * std_string_String) =
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
and closure110 () (v0 : serde_json_Error) : string =
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
and method108 () : (serde_json_Error -> string) =
    closure110()
and method109 (v0 : Result<string, string>) : Result<string, string> =
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
    let v2067 : (struct (string * string) []) =
        match v12 with
        | US4_0(v13, v14) -> (* Some *)
            let v15 : string = "fable_library_rust::String_::fromString($0)"
            let v16 : string = Fable.Core.RustInterop.emitRustExpr v13 v15 
            let v18 : bool = v16 = "fsharp"
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
                let v53 : US3 =
                    match v46 with
                    | US5_1 -> (* None *)
                        US3_1
                    | US5_0(v47) -> (* Some *)
                        let v48 : string = "fable_library_rust::String_::fromString($0)"
                        let v49 : string = Fable.Core.RustInterop.emitRustExpr v47 v48 
                        US3_0(v49)
                let v87 : string =
                    match v53 with
                    | US3_1 -> (* None *)
                        let v85 : string = "{}"
                        v85
                    | US3_0(v54) -> (* Some *)
                        let v55 : clap_Command = method0()
                        let v56 : string = $"_ {v54} --fs-path \"{v35}\""
                        let v57 : US6 = method13(v56)
                        let v63 : (string []) =
                            match v57 with
                            | US6_1(v59) -> (* Error *)
                                let v60 : string = $"resultm.get / Result value was Error: {v59}"
                                failwith<(string [])> v60
                            | US6_0(v58) -> (* Ok *)
                                v58
                        let v64 : string = "$0.to_vec()"
                        let v65 : Vec<string> = Fable.Core.RustInterop.emitRustExpr v63 v64 
                        let v66 : string = "true; let _result : Vec<_> = v65.into_iter().map(|x| { //"
                        let v67 : bool = Fable.Core.RustInterop.emitRustExpr () v66 
                        let v68 : string = "x"
                        let v69 : string = Fable.Core.RustInterop.emitRustExpr () v68 
                        let v70 : string = "&*$0"
                        let v71 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v69 v70 
                        let v72 : string = "String::from($0)"
                        let v73 : std_string_String = Fable.Core.RustInterop.emitRustExpr v71 v72 
                        let v74 : string = "true; $0 }).collect::<Vec<_>>()"
                        let v75 : bool = Fable.Core.RustInterop.emitRustExpr v73 v74 
                        let v76 : string = "_result"
                        let v77 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v76 
                        let v78 : string = "clap::Command::get_matches_from($0, v77)"
                        let v79 : clap_ArgMatches = Fable.Core.RustInterop.emitRustExpr v55 v78 
                        let v80 : std_pin_Pin<Box<Dyn<std_future_Future<Result<string, string>>>>> = method10(v0, v79)
                        let v81 : string = "v80.await"
                        let v82 : Result<string, string> = Fable.Core.RustInterop.emitRustExpr () v81 
                        let v83 : string = "$0.unwrap()"
                        let v84 : string = Fable.Core.RustInterop.emitRustExpr v82 v83 
                        v84
                let v88 : string = "command_result"
                [|struct (v88, v87)|]
            else
                let v90 : string = "fable_library_rust::String_::fromString($0)"
                let v91 : string = Fable.Core.RustInterop.emitRustExpr v13 v90 
                let v93 : bool = v91 = "dib"
                if v93 then
                    let v94 : string = method27()
                    let v95 : string = "&*$0"
                    let v96 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v94 v95 
                    let v97 : string = "clap::ArgMatches::get_one(&$0, v96).cloned()"
                    let v98 : std_string_String option = Fable.Core.RustInterop.emitRustExpr v14 v97 
                    let v99 : (std_string_String -> string) = closure13()
                    let v100 : string option = v98 |> Option.map v99 
                    let v101 : string = "$0.unwrap()"
                    let v102 : string = Fable.Core.RustInterop.emitRustExpr v100 v101 
                    let v103 : string = method41()
                    let v104 : string = "&*$0"
                    let v105 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v103 v104 
                    let v106 : string = "clap::ArgMatches::get_one(&$0, v105).cloned()"
                    let v107 : uint8 option = Fable.Core.RustInterop.emitRustExpr v14 v106 
                    let v108 : uint8 = v107 |> Option.defaultValue 1uy 
                    let v109 : string = method42()
                    let v110 : string = "&*$0"
                    let v111 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v109 v110 
                    let v112 : string = "clap::ArgMatches::get_one(&$0, v111).cloned()"
                    let v113 : string option = Fable.Core.RustInterop.emitRustExpr v14 v112 
                    let v114 : uint8 = 1uy
                    let struct (v115 : int32, v116 : string) = method43(v113, v108, v102, v114)
                    let v117 : bool = v115 <> 0 
                    let struct (v214 : int32, v215 : string) =
                        if v117 then
                            struct (v115, v116)
                        else
                            let v118 : System.Threading.CancellationToken option = None
                            let v119 : (struct (string * string) []) = [||]
                            let v120 : (struct (bool * string * int32) -> Async<unit>) option = None
                            let v121 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = None
                            let v122 : string option = None
                            let v123 : string = $"jupyter nbconvert \"{v102}.ipynb\" --to html --HTMLExporter.theme=dark"
                            let v124 : bool = true
                            let struct (v125 : int32, v126 : string) = method44(v118, v123, v119, v120, v121, v124, v122)
                            let v127 : US0 = US0_1
                            let v128 : (unit -> string) = closure42()
                            let v129 : (unit -> string) = closure43(v126, v125)
                            method5(v127, v128, v129)
                            let v130 : bool = v125 <> 0 
                            if v130 then
                                let v131 : string = $"repl_result: {v116}

jupyter_result: {v126}"
                                struct (v125, v131)
                            else
                                let v132 : string = "'"
                                let v133 : string = "''"
                                let v134 : string = v102.Replace (v132, v133)
                                let v135 : System.Threading.CancellationToken option = None
                                let v136 : (struct (string * string) []) = [||]
                                let v137 : (struct (bool * string * int32) -> Async<unit>) option = None
                                let v138 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = None
                                let v139 : string option = None
                                let v140 : string = $"pwsh -c \"$counter = 1; $path = '{v134}.html'; (Get-Content $path -Raw) -replace '(id=\\\"cell-id=)[a-fA-F0-9]{{8}}', {{ $_.Groups[1].Value + $counter++ }} | Set-Content $path\""
                                let v141 : bool = true
                                let struct (v142 : int32, v143 : string) = method44(v135, v140, v136, v137, v138, v141, v139)
                                let v144 : US0 = US0_1
                                let v145 : (unit -> string) = closure44()
                                let v146 : (unit -> string) = closure45(v143, v142)
                                method5(v144, v145, v146)
                                let v147 : string = $"{v102}.html"
                                let v148 : bool = true
                                let mutable _v148 : string option = None 
                                
#if FABLE_COMPILER || WASM || CONTRACT
                                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                let v149 : bool = true
                                let mutable _v149 : Vec<uint8> option = None 
                                
#if FABLE_COMPILER || WASM || CONTRACT
                                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                let v150 : string = "std::fs::read(&*$0).unwrap()"
                                let v151 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v147 v150 
                                v151 
                                #endif
#if FABLE_COMPILER_RUST && WASM
                                let v152 : Vec<uint8> = null |> unbox<Vec<uint8>>
                                v152 
                                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                                let v153 : Vec<uint8> = null |> unbox<Vec<uint8>>
                                v153 
                                #endif
#if FABLE_COMPILER_TYPESCRIPT
                                let v154 : Vec<uint8> = null |> unbox<Vec<uint8>>
                                v154 
                                #endif
#if FABLE_COMPILER_PYTHON
                                let v155 : Vec<uint8> = null |> unbox<Vec<uint8>>
                                v155 
                                #endif
#else
                                let v156 : (uint8 []) = v147 |> System.IO.File.ReadAllBytes
                                let v157 : string = "$0.to_vec()"
                                let v158 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v156 v157 
                                v158 
                                #endif
                                |> fun x -> _v149 <- Some x
                                let v159 : Vec<uint8> = match _v149 with Some x -> x | None -> failwith "base.run_target / _v149=None"
                                let v160 : string = "std::string::String::from_utf8(v159)"
                                let v161 : Result<std_string_String, std_string_FromUtf8Error> = Fable.Core.RustInterop.emitRustExpr () v160 
                                let v162 : string = "$0.unwrap()"
                                let v163 : std_string_String = Fable.Core.RustInterop.emitRustExpr v161 v162 
                                let v164 : string = "fable_library_rust::String_::fromString($0)"
                                let v165 : string = Fable.Core.RustInterop.emitRustExpr v163 v164 
                                v165 
                                #endif
#if FABLE_COMPILER_RUST && WASM
                                let v166 : string = null |> unbox<string>
                                v166 
                                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                                let v167 : string = null |> unbox<string>
                                v167 
                                #endif
#if FABLE_COMPILER_TYPESCRIPT
                                let v168 : string = null |> unbox<string>
                                v168 
                                #endif
#if FABLE_COMPILER_PYTHON
                                let v169 : string = null |> unbox<string>
                                v169 
                                #endif
#else
                                let v170 : string = v147 |> System.IO.File.ReadAllText
                                v170 
                                #endif
                                |> fun x -> _v148 <- Some x
                                let v171 : string = match _v148 with Some x -> x | None -> failwith "base.run_target / _v148=None"
                                let v172 : string = "\r\n"
                                let v173 : string = "\n"
                                let v174 : string = v171.Replace (v172, v173)
                                let v175 : string = $"{v102}.html"
                                let v176 : bool = true
                                let mutable _v176 : unit option = None 
                                
#if FABLE_COMPILER || WASM || CONTRACT
                                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                let v177 : string = "std::fs::write(&*$0, &*$1).unwrap()"
                                Fable.Core.RustInterop.emitRustExpr struct (v175, v174) v177 
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
                                let v178 : string = method65(v174)
                                System.IO.File.WriteAllText (v175, v178)
                                () 
                                #endif
                                |> fun x -> _v176 <- Some x
                                match _v176 with Some x -> x | None -> failwith "base.run_target / _v176=None"
                                let v179 : string = $"{v102}.ipynb"
                                let v180 : bool = true
                                let mutable _v180 : string option = None 
                                
#if FABLE_COMPILER || WASM || CONTRACT
                                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                let v181 : bool = true
                                let mutable _v181 : Vec<uint8> option = None 
                                
#if FABLE_COMPILER || WASM || CONTRACT
                                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                let v182 : string = "std::fs::read(&*$0).unwrap()"
                                let v183 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v179 v182 
                                v183 
                                #endif
#if FABLE_COMPILER_RUST && WASM
                                let v184 : Vec<uint8> = null |> unbox<Vec<uint8>>
                                v184 
                                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                                let v185 : Vec<uint8> = null |> unbox<Vec<uint8>>
                                v185 
                                #endif
#if FABLE_COMPILER_TYPESCRIPT
                                let v186 : Vec<uint8> = null |> unbox<Vec<uint8>>
                                v186 
                                #endif
#if FABLE_COMPILER_PYTHON
                                let v187 : Vec<uint8> = null |> unbox<Vec<uint8>>
                                v187 
                                #endif
#else
                                let v188 : (uint8 []) = v179 |> System.IO.File.ReadAllBytes
                                let v189 : string = "$0.to_vec()"
                                let v190 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v188 v189 
                                v190 
                                #endif
                                |> fun x -> _v181 <- Some x
                                let v191 : Vec<uint8> = match _v181 with Some x -> x | None -> failwith "base.run_target / _v181=None"
                                let v192 : string = "std::string::String::from_utf8(v191)"
                                let v193 : Result<std_string_String, std_string_FromUtf8Error> = Fable.Core.RustInterop.emitRustExpr () v192 
                                let v194 : string = "$0.unwrap()"
                                let v195 : std_string_String = Fable.Core.RustInterop.emitRustExpr v193 v194 
                                let v196 : string = "fable_library_rust::String_::fromString($0)"
                                let v197 : string = Fable.Core.RustInterop.emitRustExpr v195 v196 
                                v197 
                                #endif
#if FABLE_COMPILER_RUST && WASM
                                let v198 : string = null |> unbox<string>
                                v198 
                                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                                let v199 : string = null |> unbox<string>
                                v199 
                                #endif
#if FABLE_COMPILER_TYPESCRIPT
                                let v200 : string = null |> unbox<string>
                                v200 
                                #endif
#if FABLE_COMPILER_PYTHON
                                let v201 : string = null |> unbox<string>
                                v201 
                                #endif
#else
                                let v202 : string = v179 |> System.IO.File.ReadAllText
                                v202 
                                #endif
                                |> fun x -> _v180 <- Some x
                                let v203 : string = match _v180 with Some x -> x | None -> failwith "base.run_target / _v180=None"
                                let v204 : string = "\\r\\n"
                                let v205 : string = "\\n"
                                let v206 : string = v203.Replace (v204, v205)
                                let v207 : string = $"{v102}.ipynb"
                                let v208 : bool = true
                                let mutable _v208 : unit option = None 
                                
#if FABLE_COMPILER || WASM || CONTRACT
                                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                let v209 : string = "std::fs::write(&*$0, &*$1).unwrap()"
                                Fable.Core.RustInterop.emitRustExpr struct (v207, v206) v209 
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
                                let v210 : string = method65(v206)
                                System.IO.File.WriteAllText (v207, v210)
                                () 
                                #endif
                                |> fun x -> _v208 <- Some x
                                match _v208 with Some x -> x | None -> failwith "base.run_target / _v208=None"
                                let v211 : string = $"repl_result: {v116}

jupyter_result: {v126}

pwsh_replace_html_result: {v143}"
                                struct (v142, v211)
                    let v216 : US0 = US0_1
                    let v217 : (unit -> string) = closure46()
                    let v218 : (unit -> string) = closure47(v215, v214)
                    method5(v216, v217, v218)
                    let v219 : bool = v214 <> 0 
                    if v219 then
                        let v220 : (unit -> string) = closure6()
                        let v221 : string = $"spiral_builder.run / dib / exit_code: {v214} / result: {v215} / {v220 ()}"
                        failwith<unit> v221
                    let v222 : string = "stdio"
                    [|struct (v222, v215)|]
                else
                    let v224 : string = "fable_library_rust::String_::fromString($0)"
                    let v225 : string = Fable.Core.RustInterop.emitRustExpr v13 v224 
                    let v227 : bool = v225 = "rust"
                    let struct (v2041 : US3, v2042 : US3, v2043 : US3) =
                        if v227 then
                            let v228 : string = method11()
                            let v229 : string = "&*$0"
                            let v230 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v228 v229 
                            let v231 : string = "clap::ArgMatches::get_one(&$0, v230).cloned()"
                            let v232 : std_string_String option = Fable.Core.RustInterop.emitRustExpr v14 v231 
                            let v233 : US5 option = None
                            let _v233 = ref v233 
                            match v232 with
                            | Some x -> (
                            (fun () ->
                            (fun () ->
                            let v234 : std_string_String = x
                            let v235 : US5 = US5_0(v234)
                            v235 
                            )
                            |> fun x -> x () |> Some
                            ) () ) | None -> None
                            |> fun x -> _v233.Value <- x
                            let v236 : US5 option = _v233.Value 
                            let v237 : US5 = US5_1
                            let v238 : US5 = v236 |> Option.defaultValue v237 
                            let v242 : std_string_String =
                                match v238 with
                                | US5_1 -> (* None *)
                                    failwith<std_string_String> "Option does not have a value."
                                | US5_0(v239) -> (* Some *)
                                    v239
                            let v243 : string = "fable_library_rust::String_::fromString($0)"
                            let v244 : string = Fable.Core.RustInterop.emitRustExpr v242 v243 
                            let v245 : string = method66()
                            let v246 : string = "&*$0"
                            let v247 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v245 v246 
                            let v248 : string = "clap::ArgMatches::get_many(&$0, v247).map(|x| x.cloned().into_iter().collect())"
                            let v249 : Vec<std_string_String> option = Fable.Core.RustInterop.emitRustExpr v14 v248 
                            let v250 : US25 option = None
                            let _v250 = ref v250 
                            match v249 with
                            | Some x -> (
                            (fun () ->
                            (fun () ->
                            let v251 : Vec<std_string_String> = x
                            let v252 : US25 = US25_0(v251)
                            v252 
                            )
                            |> fun x -> x () |> Some
                            ) () ) | None -> None
                            |> fun x -> _v250.Value <- x
                            let v253 : US25 option = _v250.Value 
                            let v254 : US25 = US25_1
                            let v255 : US25 = v253 |> Option.defaultValue v254 
                            let v256 : (std_string_String []) = [||]
                            let v257 : string = "$0.to_vec()"
                            let v258 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr v256 v257 
                            let v261 : Vec<std_string_String> =
                                match v255 with
                                | US25_1 -> (* None *)
                                    v258
                                | US25_0(v259) -> (* Some *)
                                    v259
                            let v263 : bool =
                                match v0 with
                                | US0_0 -> (* Verbose *)
                                    true
                                | _ ->
                                    false
                            let v264 : bool = true
                            let mutable _v264 : string option = None 
                            
#if FABLE_COMPILER || WASM || CONTRACT
                            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                            let v265 : bool = true
                            let mutable _v265 : Vec<uint8> option = None 
                            
#if FABLE_COMPILER || WASM || CONTRACT
                            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                            let v266 : string = "std::fs::read(&*$0).unwrap()"
                            let v267 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v244 v266 
                            v267 
                            #endif
#if FABLE_COMPILER_RUST && WASM
                            let v268 : Vec<uint8> = null |> unbox<Vec<uint8>>
                            v268 
                            #endif
#if FABLE_COMPILER_RUST && CONTRACT
                            let v269 : Vec<uint8> = null |> unbox<Vec<uint8>>
                            v269 
                            #endif
#if FABLE_COMPILER_TYPESCRIPT
                            let v270 : Vec<uint8> = null |> unbox<Vec<uint8>>
                            v270 
                            #endif
#if FABLE_COMPILER_PYTHON
                            let v271 : Vec<uint8> = null |> unbox<Vec<uint8>>
                            v271 
                            #endif
#else
                            let v272 : (uint8 []) = v244 |> System.IO.File.ReadAllBytes
                            let v273 : string = "$0.to_vec()"
                            let v274 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v272 v273 
                            v274 
                            #endif
                            |> fun x -> _v265 <- Some x
                            let v275 : Vec<uint8> = match _v265 with Some x -> x | None -> failwith "base.run_target / _v265=None"
                            let v276 : string = "std::string::String::from_utf8(v275)"
                            let v277 : Result<std_string_String, std_string_FromUtf8Error> = Fable.Core.RustInterop.emitRustExpr () v276 
                            let v278 : string = "$0.unwrap()"
                            let v279 : std_string_String = Fable.Core.RustInterop.emitRustExpr v277 v278 
                            let v280 : string = "fable_library_rust::String_::fromString($0)"
                            let v281 : string = Fable.Core.RustInterop.emitRustExpr v279 v280 
                            v281 
                            #endif
#if FABLE_COMPILER_RUST && WASM
                            let v282 : string = null |> unbox<string>
                            v282 
                            #endif
#if FABLE_COMPILER_RUST && CONTRACT
                            let v283 : string = null |> unbox<string>
                            v283 
                            #endif
#if FABLE_COMPILER_TYPESCRIPT
                            let v284 : string = null |> unbox<string>
                            v284 
                            #endif
#if FABLE_COMPILER_PYTHON
                            let v285 : string = null |> unbox<string>
                            v285 
                            #endif
#else
                            let v286 : string = v244 |> System.IO.File.ReadAllText
                            v286 
                            #endif
                            |> fun x -> _v264 <- Some x
                            let v287 : string = match _v264 with Some x -> x | None -> failwith "base.run_target / _v264=None"
                            let v288 : string = "rs"
                            let v289 : string = $"%A{struct (v288, v287)}"
                            let v290 : string = method67(v289)
                            let v291 : string = __SOURCE_DIRECTORY__
                            let v292 : string = "polyglot"
                            let v293 : string = ".paket"
                            let v294 : string = method30(v292, v293)
                            let v295 : string = method69(v294, v291)
                            let v296 : string = method30(v295, v292)
                            let v297 : string = "target/polyglot/spiral_builder"
                            let v298 : string = method30(v296, v297)
                            let v299 : string = "spiral_builder"
                            let v300 : string = method30(v298, v299)
                            let v301 : string = "packages"
                            let v302 : string = method30(v300, v301)
                            let v303 : string = method30(v302, v290)
                            let v304 : System.IDisposable = method74(v303)
                            let v305 : string = $"{v299}.fs"
                            let v306 : string = method30(v303, v305)
                            let v307 : string = method36()
                            let v308 : bool = true
                            let mutable _v308 : string option = None 
                            
#if FABLE_COMPILER || WASM || CONTRACT
                            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                            let v309 : string = method37(v306)
                            let v310 : string = $"regex::Regex::new(&$0)"
                            let v311 : string = "^\\\\\\\\\\?\\\\"
                            let v312 : Result<regex_Regex, regex_Error> = Fable.Core.RustInterop.emitRustExpr v311 v310 
                            let v313 : string = "$0.unwrap()"
                            let v314 : regex_Regex = Fable.Core.RustInterop.emitRustExpr v312 v313 
                            let v315 : string = $"$0.replace_all(&$1, &*$2)"
                            let v316 : std_borrow_Cow<Str> = Fable.Core.RustInterop.emitRustExpr struct (v314, v309, v307) v315 
                            let v317 : string = "String::from($0)"
                            let v318 : std_string_String = Fable.Core.RustInterop.emitRustExpr v316 v317 
                            let v319 : string = "fable_library_rust::String_::fromString($0)"
                            let v320 : string = Fable.Core.RustInterop.emitRustExpr v318 v319 
                            v320 
                            #endif
#if FABLE_COMPILER_RUST && WASM
                            let v321 : string = null |> unbox<string>
                            v321 
                            #endif
#if FABLE_COMPILER_RUST && CONTRACT
                            let v322 : string = null |> unbox<string>
                            v322 
                            #endif
#if FABLE_COMPILER_TYPESCRIPT
                            let v323 : string = null |> unbox<string>
                            v323 
                            #endif
#if FABLE_COMPILER_PYTHON
                            let v324 : string = null |> unbox<string>
                            v324 
                            #endif
#else
                            let v325 : string = method38()
                            let v326 : string = System.Text.RegularExpressions.Regex.Replace (v306, v325, v307)
                            v326 
                            #endif
                            |> fun x -> _v308 <- Some x
                            let v327 : string = match _v308 with Some x -> x | None -> failwith "base.run_target / _v308=None"
                            let v328 : string = $"{v327.[0] |> string |> _.ToLower()}{v327.[1..]}"
                            let v329 : string = "\\"
                            let v330 : string = "/"
                            let v331 : string = v328.Replace (v329, v330)
                            let v332 : bool = method84(v331, v287)
                            let v333 : bool = v332 = false
                            if v333 then
                                let v334 : bool = true
                                let mutable _v334 : unit option = None 
                                
#if FABLE_COMPILER || WASM || CONTRACT
                                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                let v335 : string = "std::fs::write(&*$0, &*$1).unwrap()"
                                Fable.Core.RustInterop.emitRustExpr struct (v331, v287) v335 
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
                                let v336 : string = method65(v287)
                                System.IO.File.WriteAllText (v331, v336)
                                () 
                                #endif
                                |> fun x -> _v334 <- Some x
                                match _v334 with Some x -> x | None -> failwith "base.run_target / _v334=None"
                                ()
                            let v337 : string list = []
                            let v338 : string seq = seq { for i = 0 to v337.Length - 1 do yield v337.[i] }
                            let v339 : (string -> (string seq -> string)) = String.concat
                            let v340 : string = "\\n        "
                            let v341 : (string seq -> string) = v339 v340
                            let v342 : string = v341 v338
                            let v343 : string = "Fable.Core"
                            let v344 : string = $"<PackageReference Include=\"{v343}\" Version=\"*\" />"
                            let v345 : string list = []
                            let v346 : string list = v344 :: v345 
                            let v347 : string seq = seq { for i = 0 to v346.Length - 1 do yield v346.[i] }
                            let v348 : (string -> (string seq -> string)) = String.concat
                            let v349 : (string seq -> string) = v348 v340
                            let v350 : string = v349 v347
                            let v351 : string = $"{v299}.fsproj"
                            let v352 : string = method30(v303, v351)
                            let v353 : string = method36()
                            let v354 : bool = true
                            let mutable _v354 : string option = None 
                            
#if FABLE_COMPILER || WASM || CONTRACT
                            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                            let v355 : string = method37(v352)
                            let v356 : string = $"regex::Regex::new(&$0)"
                            let v357 : Result<regex_Regex, regex_Error> = Fable.Core.RustInterop.emitRustExpr v311 v356 
                            let v358 : string = "$0.unwrap()"
                            let v359 : regex_Regex = Fable.Core.RustInterop.emitRustExpr v357 v358 
                            let v360 : string = $"$0.replace_all(&$1, &*$2)"
                            let v361 : std_borrow_Cow<Str> = Fable.Core.RustInterop.emitRustExpr struct (v359, v355, v353) v360 
                            let v362 : string = "String::from($0)"
                            let v363 : std_string_String = Fable.Core.RustInterop.emitRustExpr v361 v362 
                            let v364 : string = "fable_library_rust::String_::fromString($0)"
                            let v365 : string = Fable.Core.RustInterop.emitRustExpr v363 v364 
                            v365 
                            #endif
#if FABLE_COMPILER_RUST && WASM
                            let v366 : string = null |> unbox<string>
                            v366 
                            #endif
#if FABLE_COMPILER_RUST && CONTRACT
                            let v367 : string = null |> unbox<string>
                            v367 
                            #endif
#if FABLE_COMPILER_TYPESCRIPT
                            let v368 : string = null |> unbox<string>
                            v368 
                            #endif
#if FABLE_COMPILER_PYTHON
                            let v369 : string = null |> unbox<string>
                            v369 
                            #endif
#else
                            let v370 : string = method38()
                            let v371 : string = System.Text.RegularExpressions.Regex.Replace (v352, v370, v353)
                            v371 
                            #endif
                            |> fun x -> _v354 <- Some x
                            let v372 : string = match _v354 with Some x -> x | None -> failwith "base.run_target / _v354=None"
                            let v373 : string = $"{v372.[0] |> string |> _.ToLower()}{v372.[1..]}"
                            let v374 : string = v373.Replace (v329, v330)
                            let v375 : string = $"<Project Sdk=\"Microsoft.NET.Sdk\">"
                            let v376 : string = $"<PropertyGroup>"
                            let v377 : string = "\n"
                            let v378 : string = v375 + v377 
                            let v379 : string = v378 + v376 
                            let v380 : string = $"    <TargetFramework>net9.0</TargetFramework>"
                            let v381 : string = v379 + v377 
                            let v382 : string = v381 + v380 
                            let v383 : string = $"    <LangVersion>preview</LangVersion>"
                            let v384 : string = v382 + v377 
                            let v385 : string = v384 + v383 
                            let v386 : string = $"    <RollForward>Major</RollForward>"
                            let v387 : string = v385 + v377 
                            let v388 : string = v387 + v386 
                            let v389 : string = $"    <TargetLatestRuntimePatch>true</TargetLatestRuntimePatch>"
                            let v390 : string = v388 + v377 
                            let v391 : string = v390 + v389 
                            let v392 : string = $"    <PublishAot>false</PublishAot>"
                            let v393 : string = v391 + v377 
                            let v394 : string = v393 + v392 
                            let v395 : string = $"    <PublishTrimmed>false</PublishTrimmed>"
                            let v396 : string = v394 + v377 
                            let v397 : string = v396 + v395 
                            let v398 : string = $"    <PublishSingleFile>true</PublishSingleFile>"
                            let v399 : string = v397 + v377 
                            let v400 : string = v399 + v398 
                            let v401 : string = $"    <SelfContained>true</SelfContained>"
                            let v402 : string = v400 + v377 
                            let v403 : string = v402 + v401 
                            let v404 : string = $"    <Version>0.0.1-alpha.1</Version>"
                            let v405 : string = v403 + v377 
                            let v406 : string = v405 + v404 
                            let v407 : string = $"    <OutputType>Exe</OutputType>"
                            let v408 : string = v406 + v377 
                            let v409 : string = v408 + v407 
                            let v410 : string = $"</PropertyGroup>"
                            let v411 : string = v409 + v377 
                            let v412 : string = v411 + v410 
                            let v413 : string = $"<PropertyGroup Condition=\"$([MSBuild]::IsOSPlatform('FreeBSD'))\">"
                            let v414 : string = v412 + v377 
                            let v415 : string = v414 + v413 
                            let v416 : string = $"    <DefineConstants>_FREEBSD</DefineConstants>"
                            let v417 : string = v415 + v377 
                            let v418 : string = v417 + v416 
                            let v419 : string = $"</PropertyGroup>"
                            let v420 : string = v418 + v377 
                            let v421 : string = v420 + v419 
                            let v422 : string = $"<PropertyGroup Condition=\"$([MSBuild]::IsOSPlatform('Linux'))\">"
                            let v423 : string = v421 + v377 
                            let v424 : string = v423 + v422 
                            let v425 : string = $"    <DefineConstants>_LINUX</DefineConstants>"
                            let v426 : string = v424 + v377 
                            let v427 : string = v426 + v425 
                            let v428 : string = $"</PropertyGroup>"
                            let v429 : string = v427 + v377 
                            let v430 : string = v429 + v428 
                            let v431 : string = $"<PropertyGroup Condition=\"$([MSBuild]::IsOSPlatform('OSX'))\">"
                            let v432 : string = v430 + v377 
                            let v433 : string = v432 + v431 
                            let v434 : string = $"    <DefineConstants>_OSX</DefineConstants>"
                            let v435 : string = v433 + v377 
                            let v436 : string = v435 + v434 
                            let v437 : string = $"</PropertyGroup>"
                            let v438 : string = v436 + v377 
                            let v439 : string = v438 + v437 
                            let v440 : string = $"<PropertyGroup Condition=\"$([MSBuild]::IsOSPlatform('Windows'))\">"
                            let v441 : string = v439 + v377 
                            let v442 : string = v441 + v440 
                            let v443 : string = $"    <DefineConstants>_WINDOWS</DefineConstants>"
                            let v444 : string = v442 + v377 
                            let v445 : string = v444 + v443 
                            let v446 : string = $"</PropertyGroup>"
                            let v447 : string = v445 + v377 
                            let v448 : string = v447 + v446 
                            let v449 : string = $"<ItemGroup>"
                            let v450 : string = v448 + v377 
                            let v451 : string = v450 + v449 
                            let v452 : string = $"    {v342}"
                            let v453 : string = v451 + v377 
                            let v454 : string = v453 + v452 
                            let v455 : string = $"    <Compile Include=\"{v331}\" />"
                            let v456 : string = v454 + v377 
                            let v457 : string = v456 + v455 
                            let v458 : string = $"</ItemGroup>"
                            let v459 : string = v457 + v377 
                            let v460 : string = v459 + v458 
                            let v461 : string = $"<ItemGroup>"
                            let v462 : string = v460 + v377 
                            let v463 : string = v462 + v461 
                            let v464 : string = $"    {v350}"
                            let v465 : string = v463 + v377 
                            let v466 : string = v465 + v464 
                            let v467 : string = $"</ItemGroup>"
                            let v468 : string = v466 + v377 
                            let v469 : string = v468 + v467 
                            let v470 : string = $"</Project>"
                            let v471 : string = v469 + v377 
                            let v472 : string = v471 + v470 
                            let v473 : bool = method84(v374, v472)
                            let v474 : bool = v473 = false
                            if v474 then
                                let v475 : bool = true
                                let mutable _v475 : unit option = None 
                                
#if FABLE_COMPILER || WASM || CONTRACT
                                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                let v476 : string = "std::fs::write(&*$0, &*$1).unwrap()"
                                Fable.Core.RustInterop.emitRustExpr struct (v374, v472) v476 
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
                                let v477 : string = method65(v472)
                                System.IO.File.WriteAllText (v374, v477)
                                () 
                                #endif
                                |> fun x -> _v475 <- Some x
                                match _v475 with Some x -> x | None -> failwith "base.run_target / _v475=None"
                                ()
                            let v478 : string = method86(v374)
                            let v479 : string = "Cargo.toml"
                            let v480 : string = method30(v478, v479)
                            let v481 : string = "../.."
                            let v482 : string = method30(v478, v481)
                            let v483 : string = method30(v482, v479)
                            let v484 : bool = method85(v480)
                            let v485 : bool = v484 = false
                            if v485 then
                                let v486 : System.DateTime = System.DateTime.Now
                                let v487 : (unit -> System.Guid) = System.Guid.NewGuid
                                let v488 : System.Guid = v487 ()
                                let v489 : System.Guid = method87(v488, v486)
                                let v490 : (System.Guid -> string) = _.ToString()
                                let v491 : string = v490 v489
                                let v492 : string = $"[package]"
                                let v493 : string = $"name = \"spiral_builder_{v491}\""
                                let v494 : string = v492 + v377 
                                let v495 : string = v494 + v493 
                                let v496 : string = $"version = \"0.0.1\""
                                let v497 : string = v495 + v377 
                                let v498 : string = v497 + v496 
                                let v499 : string = $"edition = \"2021\""
                                let v500 : string = v498 + v377 
                                let v501 : string = v500 + v499 
                                let v502 : string = $""
                                let v503 : string = v501 + v377 
                                let v504 : string = v503 + v502 
                                let v505 : string = $"[[bin]]"
                                let v506 : string = v504 + v377 
                                let v507 : string = v506 + v505 
                                let v508 : string = $"name = \"spiral_builder_{v491}\""
                                let v509 : string = v507 + v377 
                                let v510 : string = v509 + v508 
                                let v511 : string = $"path = \"spiral_builder.{v288}\""
                                let v512 : string = v510 + v377 
                                let v513 : string = v512 + v511 
                                let v514 : bool = method84(v480, v513)
                                let v515 : bool = v514 = false
                                if v515 then
                                    let v516 : bool = true
                                    let mutable _v516 : unit option = None 
                                    
#if FABLE_COMPILER || WASM || CONTRACT
                                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                    let v517 : string = "std::fs::write(&*$0, &*$1).unwrap()"
                                    Fable.Core.RustInterop.emitRustExpr struct (v480, v513) v517 
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
                                    let v518 : string = method65(v513)
                                    System.IO.File.WriteAllText (v480, v518)
                                    () 
                                    #endif
                                    |> fun x -> _v516 <- Some x
                                    match _v516 with Some x -> x | None -> failwith "base.run_target / _v516=None"
                                    ()
                            let v519 : bool = method85(v483)
                            let v520 : bool = v519 = false
                            if v520 then
                                let v521 : System.DateTime = System.DateTime.Now
                                let v522 : (unit -> System.Guid) = System.Guid.NewGuid
                                let v523 : System.Guid = v522 ()
                                let v524 : System.Guid = method87(v523, v521)
                                let v525 : (System.Guid -> string) = _.ToString()
                                let v526 : string = v525 v524
                                let v527 : string = $"[package]"
                                let v528 : string = $"name = \"spiral_builder_{v526}\""
                                let v529 : string = v527 + v377 
                                let v530 : string = v529 + v528 
                                let v531 : string = $"version = \"0.0.1\""
                                let v532 : string = v530 + v377 
                                let v533 : string = v532 + v531 
                                let v534 : string = $"edition = \"2021\""
                                let v535 : string = v533 + v377 
                                let v536 : string = v535 + v534 
                                let v537 : string = $""
                                let v538 : string = v536 + v377 
                                let v539 : string = v538 + v537 
                                let v540 : string = $"[[bin]]"
                                let v541 : string = v539 + v377 
                                let v542 : string = v541 + v540 
                                let v543 : string = $"name = \"spiral_builder_{v526}\""
                                let v544 : string = v542 + v377 
                                let v545 : string = v544 + v543 
                                let v546 : string = $"path = \"spiral_builder.{v288}\""
                                let v547 : string = v545 + v377 
                                let v548 : string = v547 + v546 
                                let v549 : bool = method84(v483, v548)
                                let v550 : bool = v549 = false
                                if v550 then
                                    let v551 : bool = true
                                    let mutable _v551 : unit option = None 
                                    
#if FABLE_COMPILER || WASM || CONTRACT
                                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                    let v552 : string = "std::fs::write(&*$0, &*$1).unwrap()"
                                    Fable.Core.RustInterop.emitRustExpr struct (v483, v548) v552 
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
                                    let v553 : string = method65(v548)
                                    System.IO.File.WriteAllText (v483, v553)
                                    () 
                                    #endif
                                    |> fun x -> _v551 <- Some x
                                    match _v551 with Some x -> x | None -> failwith "base.run_target / _v551=None"
                                    ()
                            let v554 : string = __SOURCE_DIRECTORY__
                            let v555 : string = method30(v292, v293)
                            let v556 : string = method69(v555, v554)
                            let v557 : string = method30(v556, v292)
                            let v558 : string = method29()
                            let v559 : (unit -> string) = v558.ToLower
                            let v560 : string = v559 ()
                            let v561 : (unit -> string) = v557.ToLower
                            let v562 : string = v561 ()
                            let v563 : bool = v560.StartsWith v562 
                            let v566 : US28 =
                                if v563 then
                                    US28_1(v562)
                                else
                                    US28_0(v562)
                            let v572 : Result<string, string> =
                                match v566 with
                                | US28_1(v569) -> (* Error *)
                                    let v570 : Result<string, string> = Error v569 
                                    v570
                                | US28_0(v567) -> (* Ok *)
                                    let v568 : Result<string, string> = Ok v567 
                                    v568
                            let v573 : string = "true; let _result = $0.unwrap_or_else(|x| { //"
                            let v574 : bool = Fable.Core.RustInterop.emitRustExpr v572 v573 
                            let v575 : string = "x"
                            let v576 : string = Fable.Core.RustInterop.emitRustExpr () v575 
                            let v577 : string = "true; $0 })"
                            let v578 : bool = Fable.Core.RustInterop.emitRustExpr v576 v577 
                            let v579 : string = "_result"
                            let v580 : string = Fable.Core.RustInterop.emitRustExpr () v579 
                            let v581 : string = "lib/rust/fable/fable_modules/fable-library-rust"
                            let v582 : string = method30(v580, v581)
                            let v583 : string = "fable_modules/fable-library-rust"
                            let v584 : string = method30(v478, v583)
                            let v585 : bool = method70(v582)
                            let v586 : bool = v585 = false
                            if v586 then
                                let v587 : System.IDisposable = method74(v582)
                                ()
                            let v588 : string = method86(v584)
                            let v589 : bool = method70(v588)
                            let v590 : bool = v589 = false
                            if v590 then
                                let v591 : System.IDisposable = method74(v588)
                                ()
                            let v592 : bool = method70(v584)
                            let v597 : bool =
                                if v592 then
                                    let v593 : string = "std::fs::read_link(&*$0)"
                                    let v594 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v584 v593 
                                    let v595 : string = "v594.is_err()"
                                    let v596 : bool = Fable.Core.RustInterop.emitRustExpr () v595 
                                    v596
                                else
                                    false
                            if v597 then
                                let v598 : bool = true
                                method77(v598, v584)
                            let v599 : bool = method70(v584)
                            let v600 : bool = v599 = false
                            if v600 then
                                let v601 : bool = true
                                let mutable _v601 : unit option = None 
                                
#if FABLE_COMPILER || WASM || CONTRACT
                                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                let v602 : bool = true
                                let mutable _v602 : unit option = None 
                                
#if _FREEBSD
                                let v603 : string = "std::os::unix::fs::symlink(&*$0, &*$1).unwrap()"
                                Fable.Core.RustInterop.emitRustExpr struct (v582, v584) v603 
                                () 
                                #endif
#if _LINUX
                                let v604 : string = "std::os::unix::fs::symlink(&*$0, &*$1).unwrap()"
                                Fable.Core.RustInterop.emitRustExpr struct (v582, v584) v604 
                                () 
                                #endif
#if _OSX
                                let v605 : string = "std::os::unix::fs::symlink(&*$0, &*$1).unwrap()"
                                Fable.Core.RustInterop.emitRustExpr struct (v582, v584) v605 
                                () 
                                #endif
#if _WINDOWS
                                let v606 : string = "std::os::windows::fs::symlink_dir(&*$0, &*$1).unwrap()"
                                Fable.Core.RustInterop.emitRustExpr struct (v582, v584) v606 
                                () 
                                #endif
                                |> fun x -> _v602 <- Some x
                                match _v602 with Some x -> x | None -> failwith "runtime.run_platform / _v602=None"
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
                                let v607 : System.IO.FileSystemInfo = System.IO.Directory.CreateSymbolicLink (v584, v582)
                                () 
                                #endif
                                |> fun x -> _v601 <- Some x
                                match _v601 with Some x -> x | None -> failwith "base.run_target / _v601=None"
                                ()
                            let struct (v608 : int32, v609 : string) = method93(v478, v288, v374, v566)
                            let v610 : bool = v608 <> 0 
                            if v610 then
                                let v611 : US0 = US0_4
                                let v612 : (unit -> string) = closure64()
                                let v613 : (unit -> string) = closure65(v609, v608)
                                method5(v611, v612, v613)
                                let v614 : US3 = US3_1
                                let v615 : US3 = US3_0(v288)
                                let v616 : US3 = US3_0(v609)
                                struct (v614, v615, v616)
                            else
                                let v617 : string = "true; let _result : Vec<_> = v261.into_iter().map(|x| { //"
                                let v618 : bool = Fable.Core.RustInterop.emitRustExpr () v617 
                                let v619 : string = "x"
                                let v620 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v619 
                                let v621 : string = "fable_library_rust::String_::fromString($0)"
                                let v622 : string = Fable.Core.RustInterop.emitRustExpr v620 v621 
                                let v623 : string = "="
                                let v624 : bool = v622.Contains v623 
                                let v633 : string =
                                    if v624 then
                                        v622
                                    else
                                        let v625 : string = "]"
                                        let v626 : bool = v622.EndsWith v625 
                                        if v626 then
                                            let v627 : string = $"={{version='*',features=["
                                            let v628 : string = "["
                                            let v629 : string = v622.Replace (v628, v627)
                                            let v630 : string = $"{v629}}}"
                                            v630
                                        else
                                            let v631 : string = $"{v622}='*'"
                                            v631
                                let v634 : string = "true; $0 }).collect::<Vec<_>>()"
                                let v635 : bool = Fable.Core.RustInterop.emitRustExpr v633 v634 
                                let v636 : string = "_result"
                                let v637 : Vec<string> = Fable.Core.RustInterop.emitRustExpr () v636 
                                let v638 : string = "fable_library_rust::NativeArray_::array_from($0)"
                                let v639 : (string []) = Fable.Core.RustInterop.emitRustExpr v637 v638 
                                let v640 : string seq = seq { for i = 0 to v639.Length - 1 do yield v639.[i] }
                                let v641 : (string -> (string seq -> string)) = String.concat
                                let v642 : (string seq -> string) = v641 v377
                                let v643 : string = v642 v640
                                let v644 : string = $"[package]"
                                let v645 : string = $"name = \"spiral_builder_{v290}\""
                                let v646 : string = v644 + v377 
                                let v647 : string = v646 + v645 
                                let v648 : string = $"version = \"0.0.1\""
                                let v649 : string = v647 + v377 
                                let v650 : string = v649 + v648 
                                let v651 : string = $"edition = \"2021\""
                                let v652 : string = v650 + v377 
                                let v653 : string = v652 + v651 
                                let v654 : string = $""
                                let v655 : string = v653 + v377 
                                let v656 : string = v655 + v654 
                                let v657 : string = $"[dependencies]"
                                let v658 : string = v656 + v377 
                                let v659 : string = v658 + v657 
                                let v660 : string = $"fable_library_rust = {{ workspace = true }}"
                                let v661 : string = v659 + v377 
                                let v662 : string = v661 + v660 
                                let v663 : string = $"inline_colorization = {{ workspace = true }}"
                                let v664 : string = v662 + v377 
                                let v665 : string = v664 + v663 
                                let v666 : string = $"{v643}"
                                let v667 : string = v665 + v377 
                                let v668 : string = v667 + v666 
                                let v669 : string = $""
                                let v670 : string = v668 + v377 
                                let v671 : string = v670 + v669 
                                let v672 : string = $"[[bin]]"
                                let v673 : string = v671 + v377 
                                let v674 : string = v673 + v672 
                                let v675 : string = $"name = \"spiral_builder_{v290}\""
                                let v676 : string = v674 + v377 
                                let v677 : string = v676 + v675 
                                let v678 : string = $"path = \"spiral_builder.rs\" "
                                let v679 : string = v677 + v377 
                                let v680 : string = v679 + v678 
                                let v681 : string = method36()
                                let v682 : bool = true
                                let mutable _v682 : string option = None 
                                
#if FABLE_COMPILER || WASM || CONTRACT
                                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                let v683 : string = method37(v580)
                                let v684 : string = $"regex::Regex::new(&$0)"
                                let v685 : Result<regex_Regex, regex_Error> = Fable.Core.RustInterop.emitRustExpr v311 v684 
                                let v686 : string = "$0.unwrap()"
                                let v687 : regex_Regex = Fable.Core.RustInterop.emitRustExpr v685 v686 
                                let v688 : string = $"$0.replace_all(&$1, &*$2)"
                                let v689 : std_borrow_Cow<Str> = Fable.Core.RustInterop.emitRustExpr struct (v687, v683, v681) v688 
                                let v690 : string = "String::from($0)"
                                let v691 : std_string_String = Fable.Core.RustInterop.emitRustExpr v689 v690 
                                let v692 : string = "fable_library_rust::String_::fromString($0)"
                                let v693 : string = Fable.Core.RustInterop.emitRustExpr v691 v692 
                                v693 
                                #endif
#if FABLE_COMPILER_RUST && WASM
                                let v694 : string = null |> unbox<string>
                                v694 
                                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                                let v695 : string = null |> unbox<string>
                                v695 
                                #endif
#if FABLE_COMPILER_TYPESCRIPT
                                let v696 : string = null |> unbox<string>
                                v696 
                                #endif
#if FABLE_COMPILER_PYTHON
                                let v697 : string = null |> unbox<string>
                                v697 
                                #endif
#else
                                let v698 : string = method38()
                                let v699 : string = System.Text.RegularExpressions.Regex.Replace (v580, v698, v681)
                                v699 
                                #endif
                                |> fun x -> _v682 <- Some x
                                let v700 : string = match _v682 with Some x -> x | None -> failwith "base.run_target / _v682=None"
                                let v701 : string = $"{v700.[0] |> string |> _.ToLower()}{v700.[1..]}"
                                let v702 : string = v701.Replace (v329, v330)
                                let v703 : string = $"[workspace]"
                                let v704 : string = $"resolver = \"2\""
                                let v705 : string = v703 + v377 
                                let v706 : string = v705 + v704 
                                let v707 : string = $"members = [\"packages/*\"]"
                                let v708 : string = v706 + v377 
                                let v709 : string = v708 + v707 
                                let v710 : string = $""
                                let v711 : string = v709 + v377 
                                let v712 : string = v711 + v710 
                                let v713 : string = $"[workspace.dependencies.fable_library_rust]"
                                let v714 : string = v712 + v377 
                                let v715 : string = v714 + v713 
                                let v716 : string = $"path = \"{v702}/lib/rust/fable/fable_modules/fable-library-rust\""
                                let v717 : string = v715 + v377 
                                let v718 : string = v717 + v716 
                                let v719 : string = $"default-features = false"
                                let v720 : string = v718 + v377 
                                let v721 : string = v720 + v719 
                                let v722 : string = $"features = [\"static_do_bindings\", \"datetime\", \"guid\", \"threaded\"]"
                                let v723 : string = v721 + v377 
                                let v724 : string = v723 + v722 
                                let v725 : string = $""
                                let v726 : string = v724 + v377 
                                let v727 : string = v726 + v725 
                                let v728 : string = $"[workspace.dependencies]"
                                let v729 : string = v727 + v377 
                                let v730 : string = v729 + v728 
                                let v731 : string = $"inline_colorization = \"~0.1\""
                                let v732 : string = v730 + v377 
                                let v733 : string = v732 + v731 
                                let v734 : bool = method84(v480, v680)
                                let v735 : bool = v734 = false
                                if v735 then
                                    let v736 : bool = true
                                    let mutable _v736 : unit option = None 
                                    
#if FABLE_COMPILER || WASM || CONTRACT
                                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                    let v737 : string = "std::fs::write(&*$0, &*$1).unwrap()"
                                    Fable.Core.RustInterop.emitRustExpr struct (v480, v680) v737 
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
                                    let v738 : string = method65(v680)
                                    System.IO.File.WriteAllText (v480, v738)
                                    () 
                                    #endif
                                    |> fun x -> _v736 <- Some x
                                    match _v736 with Some x -> x | None -> failwith "base.run_target / _v736=None"
                                    ()
                                let v739 : bool = method84(v483, v733)
                                let v740 : bool = v739 = false
                                if v740 then
                                    let v741 : bool = true
                                    let mutable _v741 : unit option = None 
                                    
#if FABLE_COMPILER || WASM || CONTRACT
                                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                    let v742 : string = "std::fs::write(&*$0, &*$1).unwrap()"
                                    Fable.Core.RustInterop.emitRustExpr struct (v483, v733) v742 
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
                                    let v743 : string = method65(v733)
                                    System.IO.File.WriteAllText (v483, v743)
                                    () 
                                    #endif
                                    |> fun x -> _v741 <- Some x
                                    match _v741 with Some x -> x | None -> failwith "base.run_target / _v741=None"
                                    ()
                                let v744 : string = "src/Range.rs"
                                let v745 : string = method30(v584, v744)
                                let v746 : bool = method85(v745)
                                if v746 then
                                    let v747 : bool = true
                                    let mutable _v747 : string option = None 
                                    
#if FABLE_COMPILER || WASM || CONTRACT
                                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                    let v748 : bool = true
                                    let mutable _v748 : Vec<uint8> option = None 
                                    
#if FABLE_COMPILER || WASM || CONTRACT
                                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                    let v749 : string = "std::fs::read(&*$0).unwrap()"
                                    let v750 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v745 v749 
                                    v750 
                                    #endif
#if FABLE_COMPILER_RUST && WASM
                                    let v751 : Vec<uint8> = null |> unbox<Vec<uint8>>
                                    v751 
                                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                                    let v752 : Vec<uint8> = null |> unbox<Vec<uint8>>
                                    v752 
                                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                                    let v753 : Vec<uint8> = null |> unbox<Vec<uint8>>
                                    v753 
                                    #endif
#if FABLE_COMPILER_PYTHON
                                    let v754 : Vec<uint8> = null |> unbox<Vec<uint8>>
                                    v754 
                                    #endif
#else
                                    let v755 : (uint8 []) = v745 |> System.IO.File.ReadAllBytes
                                    let v756 : string = "$0.to_vec()"
                                    let v757 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v755 v756 
                                    v757 
                                    #endif
                                    |> fun x -> _v748 <- Some x
                                    let v758 : Vec<uint8> = match _v748 with Some x -> x | None -> failwith "base.run_target / _v748=None"
                                    let v759 : string = "std::string::String::from_utf8(v758)"
                                    let v760 : Result<std_string_String, std_string_FromUtf8Error> = Fable.Core.RustInterop.emitRustExpr () v759 
                                    let v761 : string = "$0.unwrap()"
                                    let v762 : std_string_String = Fable.Core.RustInterop.emitRustExpr v760 v761 
                                    let v763 : string = "fable_library_rust::String_::fromString($0)"
                                    let v764 : string = Fable.Core.RustInterop.emitRustExpr v762 v763 
                                    v764 
                                    #endif
#if FABLE_COMPILER_RUST && WASM
                                    let v765 : string = null |> unbox<string>
                                    v765 
                                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                                    let v766 : string = null |> unbox<string>
                                    v766 
                                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                                    let v767 : string = null |> unbox<string>
                                    v767 
                                    #endif
#if FABLE_COMPILER_PYTHON
                                    let v768 : string = null |> unbox<string>
                                    v768 
                                    #endif
#else
                                    let v769 : string = v745 |> System.IO.File.ReadAllText
                                    v769 
                                    #endif
                                    |> fun x -> _v747 <- Some x
                                    let v770 : string = match _v747 with Some x -> x | None -> failwith "base.run_target / _v747=None"
                                    let v771 : string = "use crate::String_::fromCharCode;"
                                    let v772 : string = "use crate::String_::fromChar;"
                                    let v773 : string = v770.Replace (v771, v772)
                                    let v774 : string = "fromCharCode(c)"
                                    let v775 : string = "std::char::from_u32(c).unwrap()"
                                    let v776 : string = v773.Replace (v774, v775)
                                    let v777 : bool = method84(v745, v776)
                                    let v778 : bool = v777 = false
                                    if v778 then
                                        let v779 : bool = true
                                        let mutable _v779 : unit option = None 
                                        
#if FABLE_COMPILER || WASM || CONTRACT
                                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                        let v780 : string = "std::fs::write(&*$0, &*$1).unwrap()"
                                        Fable.Core.RustInterop.emitRustExpr struct (v745, v776) v780 
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
                                        let v781 : string = method65(v776)
                                        System.IO.File.WriteAllText (v745, v781)
                                        () 
                                        #endif
                                        |> fun x -> _v779 <- Some x
                                        match _v779 with Some x -> x | None -> failwith "base.run_target / _v779=None"
                                        ()
                                let v782 : uint8 = 1uy
                                let struct (v783 : int32, v784 : string) = method95(v480, v566, v782)
                                let v785 : bool = v783 <> 0 
                                if v785 then
                                    let v786 : US0 = US0_4
                                    let v787 : (unit -> string) = closure66()
                                    let v788 : (unit -> string) = closure67(v784, v783)
                                    method5(v786, v787, v788)
                                let v789 : string = $"{v299}.{v288}"
                                let v790 : string = method30(v478, v789)
                                let v791 : bool = true
                                let mutable _v791 : string option = None 
                                
#if FABLE_COMPILER || WASM || CONTRACT
                                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                let v792 : bool = true
                                let mutable _v792 : Vec<uint8> option = None 
                                
#if FABLE_COMPILER || WASM || CONTRACT
                                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                let v793 : string = "std::fs::read(&*$0).unwrap()"
                                let v794 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v790 v793 
                                v794 
                                #endif
#if FABLE_COMPILER_RUST && WASM
                                let v795 : Vec<uint8> = null |> unbox<Vec<uint8>>
                                v795 
                                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                                let v796 : Vec<uint8> = null |> unbox<Vec<uint8>>
                                v796 
                                #endif
#if FABLE_COMPILER_TYPESCRIPT
                                let v797 : Vec<uint8> = null |> unbox<Vec<uint8>>
                                v797 
                                #endif
#if FABLE_COMPILER_PYTHON
                                let v798 : Vec<uint8> = null |> unbox<Vec<uint8>>
                                v798 
                                #endif
#else
                                let v799 : (uint8 []) = v790 |> System.IO.File.ReadAllBytes
                                let v800 : string = "$0.to_vec()"
                                let v801 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v799 v800 
                                v801 
                                #endif
                                |> fun x -> _v792 <- Some x
                                let v802 : Vec<uint8> = match _v792 with Some x -> x | None -> failwith "base.run_target / _v792=None"
                                let v803 : string = "std::string::String::from_utf8(v802)"
                                let v804 : Result<std_string_String, std_string_FromUtf8Error> = Fable.Core.RustInterop.emitRustExpr () v803 
                                let v805 : string = "$0.unwrap()"
                                let v806 : std_string_String = Fable.Core.RustInterop.emitRustExpr v804 v805 
                                let v807 : string = "fable_library_rust::String_::fromString($0)"
                                let v808 : string = Fable.Core.RustInterop.emitRustExpr v806 v807 
                                v808 
                                #endif
#if FABLE_COMPILER_RUST && WASM
                                let v809 : string = null |> unbox<string>
                                v809 
                                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                                let v810 : string = null |> unbox<string>
                                v810 
                                #endif
#if FABLE_COMPILER_TYPESCRIPT
                                let v811 : string = null |> unbox<string>
                                v811 
                                #endif
#if FABLE_COMPILER_PYTHON
                                let v812 : string = null |> unbox<string>
                                v812 
                                #endif
#else
                                let v813 : string = v790 |> System.IO.File.ReadAllText
                                v813 
                                #endif
                                |> fun x -> _v791 <- Some x
                                let v814 : string = match _v791 with Some x -> x | None -> failwith "base.run_target / _v791=None"
                                let v815 : string = "\"{\".into()"
                                let v816 : string = Fable.Core.RustInterop.emitRustExpr () v815 
                                let v817 : string = "pub fn main() -> Result<(), String> "
                                let v818 : string = v817 + v816 
                                let v819 : string = $"{v818} Ok(()) }}"
                                let v820 : bool = v814.Contains v818 
                                let v896 : string =
                                    if v820 then
                                        v814
                                    else
                                        let v821 : string = "\";\".into()"
                                        let v822 : string = Fable.Core.RustInterop.emitRustExpr () v821 
                                        let v823 : string = "),)"
                                        let v824 : string = v823 + v822 
                                        let v825 : string = "));"
                                        let v826 : string = v814.Replace (v824, v825)
                                        let v827 : string = "\";\".into()"
                                        let v828 : string = Fable.Core.RustInterop.emitRustExpr () v827 
                                        let v829 : string = "},)"
                                        let v830 : string = v829 + v828 
                                        let v831 : string = "});"
                                        let v832 : string = v826.Replace (v830, v831)
                                        let v833 : string = method97()
                                        let v834 : bool = true
                                        let mutable _v834 : string option = None 
                                        
#if FABLE_COMPILER || WASM || CONTRACT
                                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                        let v835 : string = method37(v832)
                                        let v836 : string = $"regex::Regex::new(&$0)"
                                        let v837 : string = "\\s\\sdefaultOf\\(\\);"
                                        let v838 : Result<regex_Regex, regex_Error> = Fable.Core.RustInterop.emitRustExpr v837 v836 
                                        let v839 : string = "$0.unwrap()"
                                        let v840 : regex_Regex = Fable.Core.RustInterop.emitRustExpr v838 v839 
                                        let v841 : string = $"$0.replace_all(&$1, &*$2)"
                                        let v842 : std_borrow_Cow<Str> = Fable.Core.RustInterop.emitRustExpr struct (v840, v835, v833) v841 
                                        let v843 : string = "String::from($0)"
                                        let v844 : std_string_String = Fable.Core.RustInterop.emitRustExpr v842 v843 
                                        let v845 : string = "fable_library_rust::String_::fromString($0)"
                                        let v846 : string = Fable.Core.RustInterop.emitRustExpr v844 v845 
                                        v846 
                                        #endif
#if FABLE_COMPILER_RUST && WASM
                                        let v847 : string = null |> unbox<string>
                                        v847 
                                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                                        let v848 : string = null |> unbox<string>
                                        v848 
                                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                                        let v849 : string = null |> unbox<string>
                                        v849 
                                        #endif
#if FABLE_COMPILER_PYTHON
                                        let v850 : string = null |> unbox<string>
                                        v850 
                                        #endif
#else
                                        let v851 : string = method98()
                                        let v852 : string = System.Text.RegularExpressions.Regex.Replace (v832, v851, v833)
                                        v852 
                                        #endif
                                        |> fun x -> _v834 <- Some x
                                        let v853 : string = match _v834 with Some x -> x | None -> failwith "base.run_target / _v834=None"
                                        let v854 : string = "\",\".into()"
                                        let v855 : string = Fable.Core.RustInterop.emitRustExpr () v854 
                                        let v856 : string = "defaultOf()"
                                        let v857 : string = v856 + v855 
                                        let v858 : string = "defaultOf::<std::sync::Arc<dyn IDisposable>>(),"
                                        let v859 : string = v853.Replace (v857, v858)
                                        let v860 : string = "\"_.\".into()"
                                        let v861 : string = Fable.Core.RustInterop.emitRustExpr () v860 
                                        let v862 : string = "_self"
                                        let v863 : string = v862 + v861 
                                        let v864 : string = "self."
                                        let v865 : string = v859.Replace (v863, v864)
                                        let v866 : string = "\"h\".into()"
                                        let v867 : string = Fable.Core.RustInterop.emitRustExpr () v866 
                                        let v868 : string = "get_or_insert_wit"
                                        let v869 : string = v868 + v867 
                                        let v870 : string = "get_or_init"
                                        let v871 : string = v865.Replace (v869, v870)
                                        let v872 : string = "\";\".into()"
                                        let v873 : string = Fable.Core.RustInterop.emitRustExpr () v872 
                                        let v874 : string = "use fable_library_rust::System::Collections::Concurrent::ConcurrentStack_1"
                                        let v875 : string = v874 + v873 
                                        let v876 : string = "type ConcurrentStack_1<T> = T;"
                                        let v877 : string = v871.Replace (v875, v876)
                                        let v878 : string = "\";\".into()"
                                        let v879 : string = Fable.Core.RustInterop.emitRustExpr () v878 
                                        let v880 : string = "use fable_library_rust::System::Threading::CancellationToken"
                                        let v881 : string = v880 + v879 
                                        let v882 : string = "type CancellationToken = ();"
                                        let v883 : string = v877.Replace (v881, v882)
                                        let v884 : string = "\";\".into()"
                                        let v885 : string = Fable.Core.RustInterop.emitRustExpr () v884 
                                        let v886 : string = "use fable_library_rust::System::TimeZoneInfo"
                                        let v887 : string = v886 + v885 
                                        let v888 : string = "type TimeZoneInfo = i64;"
                                        let v889 : string = v883.Replace (v887, v888)
                                        let v890 : string = "\";\".into()"
                                        let v891 : string = Fable.Core.RustInterop.emitRustExpr () v890 
                                        let v892 : string = "use fable_library_rust::System::Threading::Tasks::TaskCanceledException"
                                        let v893 : string = v892 + v891 
                                        let v894 : string = "type TaskCanceledException = ();"
                                        let v895 : string = v889.Replace (v893, v894)
                                        v895
                                let v897 : bool = v820 = false
                                if v897 then
                                    let v898 : string = $"{v896}\n\n{v819}\n"
                                    let v899 : bool = method84(v790, v898)
                                    let v900 : bool = v899 = false
                                    if v900 then
                                        let v901 : bool = true
                                        let mutable _v901 : unit option = None 
                                        
#if FABLE_COMPILER || WASM || CONTRACT
                                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                        let v902 : string = "std::fs::write(&*$0, &*$1).unwrap()"
                                        Fable.Core.RustInterop.emitRustExpr struct (v790, v898) v902 
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
                                        let v903 : string = method65(v898)
                                        System.IO.File.WriteAllText (v790, v903)
                                        () 
                                        #endif
                                        |> fun x -> _v901 <- Some x
                                        match _v901 with Some x -> x | None -> failwith "base.run_target / _v901=None"
                                        ()
                                let v904 : string = $"cargo +nightly run --manifest-path \"{v480}\""
                                let v905 : string = "TRACE_LEVEL"
                                let v906 : string = "Verbose"
                                let v907 : string = "RUSTC_WRAPPER"
                                let v908 : string = "sccache"
                                let v909 : string = "RUSTFLAGS"
                                let v910 : string = "-C prefer-dynamic"
                                let v911 : (struct (string * string) []) = [|struct (v905, v906); struct (v907, v908); struct (v909, v910)|]
                                let v912 : System.Threading.CancellationToken option = None
                                let v913 : (struct (string * string) []) = [||]
                                let v914 : (struct (bool * string * int32) -> Async<unit>) option = None
                                let v915 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = None
                                let v916 : string option = None
                                let v922 : Result<string, string> =
                                    match v566 with
                                    | US28_1(v919) -> (* Error *)
                                        let v920 : Result<string, string> = Error v919 
                                        v920
                                    | US28_0(v917) -> (* Ok *)
                                        let v918 : Result<string, string> = Ok v917 
                                        v918
                                let v923 : string = "v922.ok()"
                                let v924 : string option = Fable.Core.RustInterop.emitRustExpr () v923 
                                let v925 : bool = true
                                let struct (v926 : int32, v927 : string) = method44(v912, v904, v911, v914, v915, v925, v924)
                                let v928 : string = ""
                                let v929 : string = $"target/debug/spiral_builder_{v290}{v928}"
                                let v930 : string = method30(v482, v929)
                                let v931 : string = ".pdb"
                                let v932 : string = $"target/debug/spiral_builder_{v290}{v931}"
                                let v933 : string = method30(v482, v932)
                                let v934 : string = ".exe"
                                let v935 : string = $"target/debug/spiral_builder_{v290}{v934}"
                                let v936 : string = method30(v482, v935)
                                let v937 : string = ".d"
                                let v938 : string = $"target/debug/spiral_builder_{v290}{v937}"
                                let v939 : string = method30(v482, v938)
                                let v940 : bool = method85(v930)
                                let v941 : bool = method85(v933)
                                let v942 : bool = method85(v936)
                                let v943 : bool = method85(v939)
                                let v944 : US0 = US0_0
                                let v945 : (unit -> string) = closure68()
                                let v946 : (unit -> string) = closure69(v939, v943, v936, v942, v933, v941, v930, v940)
                                method5(v944, v945, v946)
                                let v950 : UH3 =
                                    if v940 then
                                        let v947 : UH3 = UH3_0
                                        UH3_1(v930, v940, v947)
                                    else
                                        UH3_0
                                let v952 : UH3 =
                                    if v941 then
                                        UH3_1(v933, v941, v950)
                                    else
                                        v950
                                let v954 : UH3 =
                                    if v942 then
                                        UH3_1(v936, v942, v952)
                                    else
                                        v952
                                let v956 : UH3 =
                                    if v943 then
                                        UH3_1(v939, v943, v954)
                                    else
                                        v954
                                method99(v956)
                                let v957 : int32 = v911.Length
                                let v958 : (string []) = Array.zeroCreate<string> (v957)
                                let v959 : Mut4 = {l0 = 0} : Mut4
                                while method16(v957, v959) do
                                    let v961 : int32 = v959.l0
                                    let struct (v962 : string, v963 : string) = v911.[int v961]
                                    let v964 : string = $"$env:{v962}=''{v963}''"
                                    v958.[int v961] <- v964
                                    let v965 : int32 = v961 + 1
                                    v959.l0 <- v965
                                    ()
                                let v966 : ((string []) -> string seq) = Seq.ofArray
                                let v967 : string seq = v966 v958
                                let v968 : (string -> (string seq -> string)) = String.concat
                                let v969 : string = ";"
                                let v970 : (string seq -> string) = v968 v969
                                let v971 : string = v970 v967
                                let v972 : string = $"pwsh -c '{v971}; {v904}'"
                                let v973 : bool = v926 = 0
                                if v973 then
                                    let v974 : (unit -> string) = closure70(v927)
                                    let v975 : (string -> US3) = closure72()
                                    let v976 : (exn -> US3) = closure73(v790, v927, v972)
                                    let v977 : US3 = try v974 () |> v975 with ex -> v976 ex 
                                    let v982 : string option =
                                        match v977 with
                                        | US3_1 -> (* None *)
                                            let v980 : string option = None
                                            v980
                                        | US3_0(v978) -> (* Some *)
                                            let v979 : string option = Some v978 
                                            v979
                                    let v983 : string = "$0.unwrap()"
                                    let v984 : string = Fable.Core.RustInterop.emitRustExpr v982 v983 
                                    let v985 : US3 = US3_0(v896)
                                    let v986 : US3 = US3_0(v288)
                                    let v987 : US3 = US3_0(v984)
                                    struct (v985, v986, v987)
                                else
                                    let v988 : US0 = US0_4
                                    let v989 : (unit -> string) = closure76()
                                    let v990 : (unit -> string) = closure77(v790, v927, v926, v972)
                                    method5(v988, v989, v990)
                                    let v991 : US3 = US3_1
                                    let v992 : US3 = US3_0(v288)
                                    let v993 : US3 = US3_1
                                    struct (v991, v992, v993)
                        else
                            let v1000 : string = "fable_library_rust::String_::fromString($0)"
                            let v1001 : string = Fable.Core.RustInterop.emitRustExpr v13 v1000 
                            let v1003 : bool = v1001 = "typescript"
                            if v1003 then
                                let v1004 : string = method11()
                                let v1005 : string = "&*$0"
                                let v1006 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1004 v1005 
                                let v1007 : string = "clap::ArgMatches::get_one(&$0, v1006).cloned()"
                                let v1008 : std_string_String option = Fable.Core.RustInterop.emitRustExpr v14 v1007 
                                let v1009 : US5 option = None
                                let _v1009 = ref v1009 
                                match v1008 with
                                | Some x -> (
                                (fun () ->
                                (fun () ->
                                let v1010 : std_string_String = x
                                let v1011 : US5 = US5_0(v1010)
                                v1011 
                                )
                                |> fun x -> x () |> Some
                                ) () ) | None -> None
                                |> fun x -> _v1009.Value <- x
                                let v1012 : US5 option = _v1009.Value 
                                let v1013 : US5 = US5_1
                                let v1014 : US5 = v1012 |> Option.defaultValue v1013 
                                let v1018 : std_string_String =
                                    match v1014 with
                                    | US5_1 -> (* None *)
                                        failwith<std_string_String> "Option does not have a value."
                                    | US5_0(v1015) -> (* Some *)
                                        v1015
                                let v1019 : string = "fable_library_rust::String_::fromString($0)"
                                let v1020 : string = Fable.Core.RustInterop.emitRustExpr v1018 v1019 
                                let v1021 : string = method66()
                                let v1022 : string = "&*$0"
                                let v1023 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1021 v1022 
                                let v1024 : string = "clap::ArgMatches::get_many(&$0, v1023).map(|x| x.cloned().into_iter().collect())"
                                let v1025 : Vec<std_string_String> option = Fable.Core.RustInterop.emitRustExpr v14 v1024 
                                let v1026 : US25 option = None
                                let _v1026 = ref v1026 
                                match v1025 with
                                | Some x -> (
                                (fun () ->
                                (fun () ->
                                let v1027 : Vec<std_string_String> = x
                                let v1028 : US25 = US25_0(v1027)
                                v1028 
                                )
                                |> fun x -> x () |> Some
                                ) () ) | None -> None
                                |> fun x -> _v1026.Value <- x
                                let v1029 : US25 option = _v1026.Value 
                                let v1030 : US25 = US25_1
                                let v1031 : US25 = v1029 |> Option.defaultValue v1030 
                                let v1032 : (std_string_String []) = [||]
                                let v1033 : string = "$0.to_vec()"
                                let v1034 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr v1032 v1033 
                                let v1037 : Vec<std_string_String> =
                                    match v1031 with
                                    | US25_1 -> (* None *)
                                        v1034
                                    | US25_0(v1035) -> (* Some *)
                                        v1035
                                let v1039 : bool =
                                    match v0 with
                                    | US0_0 -> (* Verbose *)
                                        true
                                    | _ ->
                                        false
                                let v1040 : bool = true
                                let mutable _v1040 : string option = None 
                                
#if FABLE_COMPILER || WASM || CONTRACT
                                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                let v1041 : bool = true
                                let mutable _v1041 : Vec<uint8> option = None 
                                
#if FABLE_COMPILER || WASM || CONTRACT
                                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                let v1042 : string = "std::fs::read(&*$0).unwrap()"
                                let v1043 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v1020 v1042 
                                v1043 
                                #endif
#if FABLE_COMPILER_RUST && WASM
                                let v1044 : Vec<uint8> = null |> unbox<Vec<uint8>>
                                v1044 
                                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                                let v1045 : Vec<uint8> = null |> unbox<Vec<uint8>>
                                v1045 
                                #endif
#if FABLE_COMPILER_TYPESCRIPT
                                let v1046 : Vec<uint8> = null |> unbox<Vec<uint8>>
                                v1046 
                                #endif
#if FABLE_COMPILER_PYTHON
                                let v1047 : Vec<uint8> = null |> unbox<Vec<uint8>>
                                v1047 
                                #endif
#else
                                let v1048 : (uint8 []) = v1020 |> System.IO.File.ReadAllBytes
                                let v1049 : string = "$0.to_vec()"
                                let v1050 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v1048 v1049 
                                v1050 
                                #endif
                                |> fun x -> _v1041 <- Some x
                                let v1051 : Vec<uint8> = match _v1041 with Some x -> x | None -> failwith "base.run_target / _v1041=None"
                                let v1052 : string = "std::string::String::from_utf8(v1051)"
                                let v1053 : Result<std_string_String, std_string_FromUtf8Error> = Fable.Core.RustInterop.emitRustExpr () v1052 
                                let v1054 : string = "$0.unwrap()"
                                let v1055 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1053 v1054 
                                let v1056 : string = "fable_library_rust::String_::fromString($0)"
                                let v1057 : string = Fable.Core.RustInterop.emitRustExpr v1055 v1056 
                                v1057 
                                #endif
#if FABLE_COMPILER_RUST && WASM
                                let v1058 : string = null |> unbox<string>
                                v1058 
                                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                                let v1059 : string = null |> unbox<string>
                                v1059 
                                #endif
#if FABLE_COMPILER_TYPESCRIPT
                                let v1060 : string = null |> unbox<string>
                                v1060 
                                #endif
#if FABLE_COMPILER_PYTHON
                                let v1061 : string = null |> unbox<string>
                                v1061 
                                #endif
#else
                                let v1062 : string = v1020 |> System.IO.File.ReadAllText
                                v1062 
                                #endif
                                |> fun x -> _v1040 <- Some x
                                let v1063 : string = match _v1040 with Some x -> x | None -> failwith "base.run_target / _v1040=None"
                                let v1064 : string = "ts"
                                let v1065 : string = $"%A{struct (v1064, v1063)}"
                                let v1066 : string = method67(v1065)
                                let v1067 : string = __SOURCE_DIRECTORY__
                                let v1068 : string = "polyglot"
                                let v1069 : string = ".paket"
                                let v1070 : string = method30(v1068, v1069)
                                let v1071 : string = method69(v1070, v1067)
                                let v1072 : string = method30(v1071, v1068)
                                let v1073 : string = "target/polyglot/spiral_builder"
                                let v1074 : string = method30(v1072, v1073)
                                let v1075 : string = "spiral_builder"
                                let v1076 : string = method30(v1074, v1075)
                                let v1077 : string = "packages"
                                let v1078 : string = method30(v1076, v1077)
                                let v1079 : string = method30(v1078, v1066)
                                let v1080 : System.IDisposable = method74(v1079)
                                let v1081 : string = $"{v1075}.fs"
                                let v1082 : string = method30(v1079, v1081)
                                let v1083 : string = method36()
                                let v1084 : bool = true
                                let mutable _v1084 : string option = None 
                                
#if FABLE_COMPILER || WASM || CONTRACT
                                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                let v1085 : string = method37(v1082)
                                let v1086 : string = $"regex::Regex::new(&$0)"
                                let v1087 : string = "^\\\\\\\\\\?\\\\"
                                let v1088 : Result<regex_Regex, regex_Error> = Fable.Core.RustInterop.emitRustExpr v1087 v1086 
                                let v1089 : string = "$0.unwrap()"
                                let v1090 : regex_Regex = Fable.Core.RustInterop.emitRustExpr v1088 v1089 
                                let v1091 : string = $"$0.replace_all(&$1, &*$2)"
                                let v1092 : std_borrow_Cow<Str> = Fable.Core.RustInterop.emitRustExpr struct (v1090, v1085, v1083) v1091 
                                let v1093 : string = "String::from($0)"
                                let v1094 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1092 v1093 
                                let v1095 : string = "fable_library_rust::String_::fromString($0)"
                                let v1096 : string = Fable.Core.RustInterop.emitRustExpr v1094 v1095 
                                v1096 
                                #endif
#if FABLE_COMPILER_RUST && WASM
                                let v1097 : string = null |> unbox<string>
                                v1097 
                                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                                let v1098 : string = null |> unbox<string>
                                v1098 
                                #endif
#if FABLE_COMPILER_TYPESCRIPT
                                let v1099 : string = null |> unbox<string>
                                v1099 
                                #endif
#if FABLE_COMPILER_PYTHON
                                let v1100 : string = null |> unbox<string>
                                v1100 
                                #endif
#else
                                let v1101 : string = method38()
                                let v1102 : string = System.Text.RegularExpressions.Regex.Replace (v1082, v1101, v1083)
                                v1102 
                                #endif
                                |> fun x -> _v1084 <- Some x
                                let v1103 : string = match _v1084 with Some x -> x | None -> failwith "base.run_target / _v1084=None"
                                let v1104 : string = $"{v1103.[0] |> string |> _.ToLower()}{v1103.[1..]}"
                                let v1105 : string = "\\"
                                let v1106 : string = "/"
                                let v1107 : string = v1104.Replace (v1105, v1106)
                                let v1108 : bool = method84(v1107, v1063)
                                let v1109 : bool = v1108 = false
                                if v1109 then
                                    let v1110 : bool = true
                                    let mutable _v1110 : unit option = None 
                                    
#if FABLE_COMPILER || WASM || CONTRACT
                                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                    let v1111 : string = "std::fs::write(&*$0, &*$1).unwrap()"
                                    Fable.Core.RustInterop.emitRustExpr struct (v1107, v1063) v1111 
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
                                    let v1112 : string = method65(v1063)
                                    System.IO.File.WriteAllText (v1107, v1112)
                                    () 
                                    #endif
                                    |> fun x -> _v1110 <- Some x
                                    match _v1110 with Some x -> x | None -> failwith "base.run_target / _v1110=None"
                                    ()
                                let v1113 : string list = []
                                let v1114 : string seq = seq { for i = 0 to v1113.Length - 1 do yield v1113.[i] }
                                let v1115 : (string -> (string seq -> string)) = String.concat
                                let v1116 : string = "\\n        "
                                let v1117 : (string seq -> string) = v1115 v1116
                                let v1118 : string = v1117 v1114
                                let v1119 : string = "Fable.Core"
                                let v1120 : string = $"<PackageReference Include=\"{v1119}\" Version=\"*\" />"
                                let v1121 : string list = []
                                let v1122 : string list = v1120 :: v1121 
                                let v1123 : string seq = seq { for i = 0 to v1122.Length - 1 do yield v1122.[i] }
                                let v1124 : (string -> (string seq -> string)) = String.concat
                                let v1125 : (string seq -> string) = v1124 v1116
                                let v1126 : string = v1125 v1123
                                let v1127 : string = $"{v1075}.fsproj"
                                let v1128 : string = method30(v1079, v1127)
                                let v1129 : string = method36()
                                let v1130 : bool = true
                                let mutable _v1130 : string option = None 
                                
#if FABLE_COMPILER || WASM || CONTRACT
                                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                let v1131 : string = method37(v1128)
                                let v1132 : string = $"regex::Regex::new(&$0)"
                                let v1133 : Result<regex_Regex, regex_Error> = Fable.Core.RustInterop.emitRustExpr v1087 v1132 
                                let v1134 : string = "$0.unwrap()"
                                let v1135 : regex_Regex = Fable.Core.RustInterop.emitRustExpr v1133 v1134 
                                let v1136 : string = $"$0.replace_all(&$1, &*$2)"
                                let v1137 : std_borrow_Cow<Str> = Fable.Core.RustInterop.emitRustExpr struct (v1135, v1131, v1129) v1136 
                                let v1138 : string = "String::from($0)"
                                let v1139 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1137 v1138 
                                let v1140 : string = "fable_library_rust::String_::fromString($0)"
                                let v1141 : string = Fable.Core.RustInterop.emitRustExpr v1139 v1140 
                                v1141 
                                #endif
#if FABLE_COMPILER_RUST && WASM
                                let v1142 : string = null |> unbox<string>
                                v1142 
                                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                                let v1143 : string = null |> unbox<string>
                                v1143 
                                #endif
#if FABLE_COMPILER_TYPESCRIPT
                                let v1144 : string = null |> unbox<string>
                                v1144 
                                #endif
#if FABLE_COMPILER_PYTHON
                                let v1145 : string = null |> unbox<string>
                                v1145 
                                #endif
#else
                                let v1146 : string = method38()
                                let v1147 : string = System.Text.RegularExpressions.Regex.Replace (v1128, v1146, v1129)
                                v1147 
                                #endif
                                |> fun x -> _v1130 <- Some x
                                let v1148 : string = match _v1130 with Some x -> x | None -> failwith "base.run_target / _v1130=None"
                                let v1149 : string = $"{v1148.[0] |> string |> _.ToLower()}{v1148.[1..]}"
                                let v1150 : string = v1149.Replace (v1105, v1106)
                                let v1151 : string = $"<Project Sdk=\"Microsoft.NET.Sdk\">"
                                let v1152 : string = $"<PropertyGroup>"
                                let v1153 : string = "\n"
                                let v1154 : string = v1151 + v1153 
                                let v1155 : string = v1154 + v1152 
                                let v1156 : string = $"    <TargetFramework>net9.0</TargetFramework>"
                                let v1157 : string = v1155 + v1153 
                                let v1158 : string = v1157 + v1156 
                                let v1159 : string = $"    <LangVersion>preview</LangVersion>"
                                let v1160 : string = v1158 + v1153 
                                let v1161 : string = v1160 + v1159 
                                let v1162 : string = $"    <RollForward>Major</RollForward>"
                                let v1163 : string = v1161 + v1153 
                                let v1164 : string = v1163 + v1162 
                                let v1165 : string = $"    <TargetLatestRuntimePatch>true</TargetLatestRuntimePatch>"
                                let v1166 : string = v1164 + v1153 
                                let v1167 : string = v1166 + v1165 
                                let v1168 : string = $"    <PublishAot>false</PublishAot>"
                                let v1169 : string = v1167 + v1153 
                                let v1170 : string = v1169 + v1168 
                                let v1171 : string = $"    <PublishTrimmed>false</PublishTrimmed>"
                                let v1172 : string = v1170 + v1153 
                                let v1173 : string = v1172 + v1171 
                                let v1174 : string = $"    <PublishSingleFile>true</PublishSingleFile>"
                                let v1175 : string = v1173 + v1153 
                                let v1176 : string = v1175 + v1174 
                                let v1177 : string = $"    <SelfContained>true</SelfContained>"
                                let v1178 : string = v1176 + v1153 
                                let v1179 : string = v1178 + v1177 
                                let v1180 : string = $"    <Version>0.0.1-alpha.1</Version>"
                                let v1181 : string = v1179 + v1153 
                                let v1182 : string = v1181 + v1180 
                                let v1183 : string = $"    <OutputType>Exe</OutputType>"
                                let v1184 : string = v1182 + v1153 
                                let v1185 : string = v1184 + v1183 
                                let v1186 : string = $"</PropertyGroup>"
                                let v1187 : string = v1185 + v1153 
                                let v1188 : string = v1187 + v1186 
                                let v1189 : string = $"<PropertyGroup Condition=\"$([MSBuild]::IsOSPlatform('FreeBSD'))\">"
                                let v1190 : string = v1188 + v1153 
                                let v1191 : string = v1190 + v1189 
                                let v1192 : string = $"    <DefineConstants>_FREEBSD</DefineConstants>"
                                let v1193 : string = v1191 + v1153 
                                let v1194 : string = v1193 + v1192 
                                let v1195 : string = $"</PropertyGroup>"
                                let v1196 : string = v1194 + v1153 
                                let v1197 : string = v1196 + v1195 
                                let v1198 : string = $"<PropertyGroup Condition=\"$([MSBuild]::IsOSPlatform('Linux'))\">"
                                let v1199 : string = v1197 + v1153 
                                let v1200 : string = v1199 + v1198 
                                let v1201 : string = $"    <DefineConstants>_LINUX</DefineConstants>"
                                let v1202 : string = v1200 + v1153 
                                let v1203 : string = v1202 + v1201 
                                let v1204 : string = $"</PropertyGroup>"
                                let v1205 : string = v1203 + v1153 
                                let v1206 : string = v1205 + v1204 
                                let v1207 : string = $"<PropertyGroup Condition=\"$([MSBuild]::IsOSPlatform('OSX'))\">"
                                let v1208 : string = v1206 + v1153 
                                let v1209 : string = v1208 + v1207 
                                let v1210 : string = $"    <DefineConstants>_OSX</DefineConstants>"
                                let v1211 : string = v1209 + v1153 
                                let v1212 : string = v1211 + v1210 
                                let v1213 : string = $"</PropertyGroup>"
                                let v1214 : string = v1212 + v1153 
                                let v1215 : string = v1214 + v1213 
                                let v1216 : string = $"<PropertyGroup Condition=\"$([MSBuild]::IsOSPlatform('Windows'))\">"
                                let v1217 : string = v1215 + v1153 
                                let v1218 : string = v1217 + v1216 
                                let v1219 : string = $"    <DefineConstants>_WINDOWS</DefineConstants>"
                                let v1220 : string = v1218 + v1153 
                                let v1221 : string = v1220 + v1219 
                                let v1222 : string = $"</PropertyGroup>"
                                let v1223 : string = v1221 + v1153 
                                let v1224 : string = v1223 + v1222 
                                let v1225 : string = $"<ItemGroup>"
                                let v1226 : string = v1224 + v1153 
                                let v1227 : string = v1226 + v1225 
                                let v1228 : string = $"    {v1118}"
                                let v1229 : string = v1227 + v1153 
                                let v1230 : string = v1229 + v1228 
                                let v1231 : string = $"    <Compile Include=\"{v1107}\" />"
                                let v1232 : string = v1230 + v1153 
                                let v1233 : string = v1232 + v1231 
                                let v1234 : string = $"</ItemGroup>"
                                let v1235 : string = v1233 + v1153 
                                let v1236 : string = v1235 + v1234 
                                let v1237 : string = $"<ItemGroup>"
                                let v1238 : string = v1236 + v1153 
                                let v1239 : string = v1238 + v1237 
                                let v1240 : string = $"    {v1126}"
                                let v1241 : string = v1239 + v1153 
                                let v1242 : string = v1241 + v1240 
                                let v1243 : string = $"</ItemGroup>"
                                let v1244 : string = v1242 + v1153 
                                let v1245 : string = v1244 + v1243 
                                let v1246 : string = $"</Project>"
                                let v1247 : string = v1245 + v1153 
                                let v1248 : string = v1247 + v1246 
                                let v1249 : bool = method84(v1150, v1248)
                                let v1250 : bool = v1249 = false
                                if v1250 then
                                    let v1251 : bool = true
                                    let mutable _v1251 : unit option = None 
                                    
#if FABLE_COMPILER || WASM || CONTRACT
                                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                    let v1252 : string = "std::fs::write(&*$0, &*$1).unwrap()"
                                    Fable.Core.RustInterop.emitRustExpr struct (v1150, v1248) v1252 
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
                                    let v1253 : string = method65(v1248)
                                    System.IO.File.WriteAllText (v1150, v1253)
                                    () 
                                    #endif
                                    |> fun x -> _v1251 <- Some x
                                    match _v1251 with Some x -> x | None -> failwith "base.run_target / _v1251=None"
                                    ()
                                let v1254 : string = method86(v1150)
                                let v1255 : string = __SOURCE_DIRECTORY__
                                let v1256 : string = method30(v1068, v1069)
                                let v1257 : string = method69(v1256, v1255)
                                let v1258 : string = method30(v1257, v1068)
                                let v1259 : string = method29()
                                let v1260 : (unit -> string) = v1259.ToLower
                                let v1261 : string = v1260 ()
                                let v1262 : (unit -> string) = v1258.ToLower
                                let v1263 : string = v1262 ()
                                let v1264 : bool = v1261.StartsWith v1263 
                                let v1267 : US28 =
                                    if v1264 then
                                        US28_1(v1263)
                                    else
                                        US28_0(v1263)
                                let v1273 : Result<string, string> =
                                    match v1267 with
                                    | US28_1(v1270) -> (* Error *)
                                        let v1271 : Result<string, string> = Error v1270 
                                        v1271
                                    | US28_0(v1268) -> (* Ok *)
                                        let v1269 : Result<string, string> = Ok v1268 
                                        v1269
                                let v1274 : string = "true; let _result = $0.unwrap_or_else(|x| { //"
                                let v1275 : bool = Fable.Core.RustInterop.emitRustExpr v1273 v1274 
                                let v1276 : string = "x"
                                let v1277 : string = Fable.Core.RustInterop.emitRustExpr () v1276 
                                let v1278 : string = "true; $0 })"
                                let v1279 : bool = Fable.Core.RustInterop.emitRustExpr v1277 v1278 
                                let v1280 : string = "_result"
                                let v1281 : string = Fable.Core.RustInterop.emitRustExpr () v1280 
                                let v1282 : string = "lib/typescript/fable/fable_modules"
                                let v1283 : string = method30(v1281, v1282)
                                let v1284 : string = "async_walkdir::WalkDir::new(&*$0)"
                                let v1285 : async_walkdir_WalkDir = Fable.Core.RustInterop.emitRustExpr v1283 v1284 
                                let v1286 : string = "async_walkdir::WalkDir::filter($0, |x| $1(x))"
                                let v1287 : (async_walkdir_DirEntry -> std_pin_Pin<Box<LifetimeJoin<Dyn<std_future_Future<async_walkdir_Filtering>>, Send<Dyn<std_future_Future<async_walkdir_Filtering>>>>>>) = closure78()
                                let v1288 : async_walkdir_WalkDir = Fable.Core.RustInterop.emitRustExpr struct (v1285, v1287) v1286 
                                let v1289 : (Result<async_walkdir_DirEntry, std_io_Error> -> struct (string * string) option) = method106()
                                let v1290 : string = "tokio_stream::StreamExt::collect(tokio_stream::StreamExt::filter_map(v1288, |x| v1289(x))).await"
                                let v1291 : Vec<struct (string * string)> = Fable.Core.RustInterop.emitRustExpr () v1290 
                                let v1292 : string = "rayon::iter::IntoParallelIterator::into_par_iter(v1291)"
                                let v1293 : rayon_vec_IntoIter<struct (string * string)> = Fable.Core.RustInterop.emitRustExpr () v1292 
                                let v1294 : string = "rayon::iter::ParallelIterator::map($0, |x| $1(x))"
                                let v1295 : (struct (string * string) -> struct (string * string)) = closure86()
                                let v1296 : rayon_iter_Map<rayon_vec_IntoIter<struct (string * string)>> = Fable.Core.RustInterop.emitRustExpr struct (v1293, v1295) v1294 
                                let v1297 : string = "rayon::iter::ParallelIterator::collect($0)"
                                let v1298 : Vec<struct (string * string)> = Fable.Core.RustInterop.emitRustExpr v1296 v1297 
                                let v1299 : string = "fable_library_rust::NativeArray_::array_from($0)"
                                let v1300 : (struct (string * string) []) = Fable.Core.RustInterop.emitRustExpr v1298 v1299 
                                let v1301 : (int32 -> ((struct (string * string) []) -> struct (string * string) option)) = Array.tryItem
                                let v1302 : ((struct (string * string) []) -> struct (string * string) option) = v1301 0
                                let v1303 : struct (string * string) option = v1302 v1300
                                let v1304 : US35 option = None
                                let _v1304 = ref v1304 
                                match v1303 with
                                | Some x -> (
                                (fun () ->
                                (fun () ->
                                let struct (v1305 : string, v1306 : string) = x
                                let v1307 : US35 = US35_0(v1305, v1306)
                                v1307 
                                )
                                |> fun x -> x () |> Some
                                ) () ) | None -> None
                                |> fun x -> _v1304.Value <- x
                                let v1308 : US35 option = _v1304.Value 
                                let v1309 : US35 = US35_1
                                let v1310 : US35 = v1308 |> Option.defaultValue v1309 
                                let v1311 : US0 = US0_1
                                let v1312 : (unit -> string) = closure87()
                                let v1313 : (unit -> string) = closure88(v1310)
                                method5(v1311, v1312, v1313)
                                match v1310 with
                                | US35_1 -> (* None *)
                                    ()
                                | US35_0(v1314, v1315) -> (* Some *)
                                    let v1316 : string = $"fable-library-{v1064}.{v1315}"
                                    let v1317 : string = method30(v1283, v1316)
                                    let v1318 : string = $"fable_modules/fable-library-{v1064}.{v1315}"
                                    let v1319 : string = method30(v1254, v1318)
                                    let v1320 : bool = method70(v1317)
                                    let v1321 : bool = v1320 = false
                                    if v1321 then
                                        let v1322 : System.IDisposable = method74(v1317)
                                        ()
                                    let v1323 : string = method86(v1319)
                                    let v1324 : bool = method70(v1323)
                                    let v1325 : bool = v1324 = false
                                    if v1325 then
                                        let v1326 : System.IDisposable = method74(v1323)
                                        ()
                                    let v1327 : bool = method70(v1319)
                                    let v1332 : bool =
                                        if v1327 then
                                            let v1328 : string = "std::fs::read_link(&*$0)"
                                            let v1329 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v1319 v1328 
                                            let v1330 : string = "v1329.is_err()"
                                            let v1331 : bool = Fable.Core.RustInterop.emitRustExpr () v1330 
                                            v1331
                                        else
                                            false
                                    if v1332 then
                                        let v1333 : bool = true
                                        method77(v1333, v1319)
                                    let v1334 : bool = method70(v1319)
                                    let v1335 : bool = v1334 = false
                                    if v1335 then
                                        let v1336 : bool = true
                                        let mutable _v1336 : unit option = None 
                                        
#if FABLE_COMPILER || WASM || CONTRACT
                                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                        let v1337 : bool = true
                                        let mutable _v1337 : unit option = None 
                                        
#if _FREEBSD
                                        let v1338 : string = "std::os::unix::fs::symlink(&*$0, &*$1).unwrap()"
                                        Fable.Core.RustInterop.emitRustExpr struct (v1317, v1319) v1338 
                                        () 
                                        #endif
#if _LINUX
                                        let v1339 : string = "std::os::unix::fs::symlink(&*$0, &*$1).unwrap()"
                                        Fable.Core.RustInterop.emitRustExpr struct (v1317, v1319) v1339 
                                        () 
                                        #endif
#if _OSX
                                        let v1340 : string = "std::os::unix::fs::symlink(&*$0, &*$1).unwrap()"
                                        Fable.Core.RustInterop.emitRustExpr struct (v1317, v1319) v1340 
                                        () 
                                        #endif
#if _WINDOWS
                                        let v1341 : string = "std::os::windows::fs::symlink_dir(&*$0, &*$1).unwrap()"
                                        Fable.Core.RustInterop.emitRustExpr struct (v1317, v1319) v1341 
                                        () 
                                        #endif
                                        |> fun x -> _v1337 <- Some x
                                        match _v1337 with Some x -> x | None -> failwith "runtime.run_platform / _v1337=None"
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
                                        let v1342 : System.IO.FileSystemInfo = System.IO.Directory.CreateSymbolicLink (v1319, v1317)
                                        () 
                                        #endif
                                        |> fun x -> _v1336 <- Some x
                                        match _v1336 with Some x -> x | None -> failwith "base.run_target / _v1336=None"
                                        ()
                                let struct (v1343 : int32, v1344 : string) = method93(v1254, v1064, v1150, v1267)
                                let v1345 : bool = v1343 <> 0 
                                if v1345 then
                                    let v1346 : US0 = US0_4
                                    let v1347 : (unit -> string) = closure89(v1344, v1343)
                                    let v1348 : (unit -> string) = closure6()
                                    method5(v1346, v1347, v1348)
                                    let v1349 : US3 = US3_1
                                    let v1350 : US3 = US3_0(v1064)
                                    let v1351 : US3 = US3_0(v1344)
                                    struct (v1349, v1350, v1351)
                                else
                                    let v1352 : string = "true; let _result : Vec<_> = v1037.into_iter().map(|x| { //"
                                    let v1353 : bool = Fable.Core.RustInterop.emitRustExpr () v1352 
                                    let v1354 : string = "x"
                                    let v1355 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v1354 
                                    let v1356 : string = "fable_library_rust::String_::fromString($0)"
                                    let v1357 : string = Fable.Core.RustInterop.emitRustExpr v1355 v1356 
                                    let v1358 : string = "="
                                    let v1359 : bool = v1357.Contains v1358 
                                    let v1361 : string =
                                        if v1359 then
                                            v1357
                                        else
                                            let v1360 : string = $"\"{v1357}\":\"*\""
                                            v1360
                                    let v1362 : string = "true; $0 }).collect::<Vec<_>>()"
                                    let v1363 : bool = Fable.Core.RustInterop.emitRustExpr v1361 v1362 
                                    let v1364 : string = "_result"
                                    let v1365 : Vec<string> = Fable.Core.RustInterop.emitRustExpr () v1364 
                                    let v1366 : string = "fable_library_rust::NativeArray_::array_from($0)"
                                    let v1367 : (string []) = Fable.Core.RustInterop.emitRustExpr v1365 v1366 
                                    let v1368 : string seq = seq { for i = 0 to v1367.Length - 1 do yield v1367.[i] }
                                    let v1369 : (string -> (string seq -> string)) = String.concat
                                    let v1370 : string = ",\n"
                                    let v1371 : (string seq -> string) = v1369 v1370
                                    let v1372 : string = v1371 v1368
                                    let v1373 : string = $"{{"
                                    let v1374 : string = $"  \"name\": \"spiral_builder_{v1066}\","
                                    let v1375 : string = v1373 + v1374 
                                    let v1376 : string = $"  \"dependencies\": {{"
                                    let v1377 : string = v1375 + v1376 
                                    let v1378 : string = v1377 + v1372 
                                    let v1379 : string = $"  }},"
                                    let v1380 : string = v1378 + v1379 
                                    let v1381 : string = $"    \"devDependencies\": {{"
                                    let v1382 : string = v1380 + v1381 
                                    let v1383 : string = $"  }},"
                                    let v1384 : string = v1382 + v1383 
                                    let v1385 : string = $"}}"
                                    let v1386 : string = v1384 + v1385 
                                    let v1387 : string = "package.json"
                                    let v1388 : string = method30(v1254, v1387)
                                    let v1389 : string = "../.."
                                    let v1390 : string = method30(v1254, v1389)
                                    let v1391 : string = method30(v1390, v1387)
                                    let v1392 : bool = method84(v1388, v1386)
                                    let v1393 : bool = v1392 = false
                                    if v1393 then
                                        let v1394 : bool = true
                                        let mutable _v1394 : unit option = None 
                                        
#if FABLE_COMPILER || WASM || CONTRACT
                                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                        let v1395 : string = "std::fs::write(&*$0, &*$1).unwrap()"
                                        Fable.Core.RustInterop.emitRustExpr struct (v1388, v1386) v1395 
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
                                        let v1396 : string = method65(v1386)
                                        System.IO.File.WriteAllText (v1388, v1396)
                                        () 
                                        #endif
                                        |> fun x -> _v1394 <- Some x
                                        match _v1394 with Some x -> x | None -> failwith "base.run_target / _v1394=None"
                                        ()
                                    let v1397 : string = ""
                                    let v1398 : bool = method84(v1391, v1397)
                                    let v1399 : bool = v1398 = false
                                    if v1399 then
                                        let v1400 : bool = true
                                        let mutable _v1400 : unit option = None 
                                        
#if FABLE_COMPILER || WASM || CONTRACT
                                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                        let v1401 : string = "std::fs::write(&*$0, &*$1).unwrap()"
                                        Fable.Core.RustInterop.emitRustExpr struct (v1391, v1397) v1401 
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
                                        let v1402 : string = method107()
                                        System.IO.File.WriteAllText (v1391, v1402)
                                        () 
                                        #endif
                                        |> fun x -> _v1400 <- Some x
                                        match _v1400 with Some x -> x | None -> failwith "base.run_target / _v1400=None"
                                        ()
                                    let v1403 : string = $"{v1075}.{v1064}"
                                    let v1404 : string = method30(v1254, v1403)
                                    let v1405 : US0 = US0_1
                                    let v1406 : (unit -> string) = closure90()
                                    let v1407 : (unit -> string) = closure91(v1404)
                                    method5(v1405, v1406, v1407)
                                    let v1408 : bool = true
                                    let mutable _v1408 : string option = None 
                                    
#if FABLE_COMPILER || WASM || CONTRACT
                                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                    let v1409 : bool = true
                                    let mutable _v1409 : Vec<uint8> option = None 
                                    
#if FABLE_COMPILER || WASM || CONTRACT
                                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                    let v1410 : string = "std::fs::read(&*$0).unwrap()"
                                    let v1411 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v1404 v1410 
                                    v1411 
                                    #endif
#if FABLE_COMPILER_RUST && WASM
                                    let v1412 : Vec<uint8> = null |> unbox<Vec<uint8>>
                                    v1412 
                                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                                    let v1413 : Vec<uint8> = null |> unbox<Vec<uint8>>
                                    v1413 
                                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                                    let v1414 : Vec<uint8> = null |> unbox<Vec<uint8>>
                                    v1414 
                                    #endif
#if FABLE_COMPILER_PYTHON
                                    let v1415 : Vec<uint8> = null |> unbox<Vec<uint8>>
                                    v1415 
                                    #endif
#else
                                    let v1416 : (uint8 []) = v1404 |> System.IO.File.ReadAllBytes
                                    let v1417 : string = "$0.to_vec()"
                                    let v1418 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v1416 v1417 
                                    v1418 
                                    #endif
                                    |> fun x -> _v1409 <- Some x
                                    let v1419 : Vec<uint8> = match _v1409 with Some x -> x | None -> failwith "base.run_target / _v1409=None"
                                    let v1420 : string = "std::string::String::from_utf8(v1419)"
                                    let v1421 : Result<std_string_String, std_string_FromUtf8Error> = Fable.Core.RustInterop.emitRustExpr () v1420 
                                    let v1422 : string = "$0.unwrap()"
                                    let v1423 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1421 v1422 
                                    let v1424 : string = "fable_library_rust::String_::fromString($0)"
                                    let v1425 : string = Fable.Core.RustInterop.emitRustExpr v1423 v1424 
                                    v1425 
                                    #endif
#if FABLE_COMPILER_RUST && WASM
                                    let v1426 : string = null |> unbox<string>
                                    v1426 
                                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                                    let v1427 : string = null |> unbox<string>
                                    v1427 
                                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                                    let v1428 : string = null |> unbox<string>
                                    v1428 
                                    #endif
#if FABLE_COMPILER_PYTHON
                                    let v1429 : string = null |> unbox<string>
                                    v1429 
                                    #endif
#else
                                    let v1430 : string = v1404 |> System.IO.File.ReadAllText
                                    v1430 
                                    #endif
                                    |> fun x -> _v1408 <- Some x
                                    let v1431 : string = match _v1408 with Some x -> x | None -> failwith "base.run_target / _v1408=None"
                                    let v1432 : string = "// spiral_builder.process_typescript"
                                    let v1433 : bool = v1431.Contains v1432 
                                    let v1458 : string =
                                        if v1433 then
                                            v1431
                                        else
                                            let v1434 : string = $"\"./fable_modules/fable-library-ts.{v1310}/"
                                            let v1435 : string = $"\"{v1281}/lib/typescript/fable/fable_modules/fable-library-ts.{v1310}/"
                                            let v1436 : string = v1431.Replace (v1434, v1435)
                                            let v1437 : string = method97()
                                            let v1438 : bool = true
                                            let mutable _v1438 : string option = None 
                                            
#if FABLE_COMPILER || WASM || CONTRACT
                                            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                            let v1439 : string = method37(v1436)
                                            let v1440 : string = $"regex::Regex::new(&$0)"
                                            let v1441 : string = "\\s\\sdefaultOf\\(\\);"
                                            let v1442 : Result<regex_Regex, regex_Error> = Fable.Core.RustInterop.emitRustExpr v1441 v1440 
                                            let v1443 : string = "$0.unwrap()"
                                            let v1444 : regex_Regex = Fable.Core.RustInterop.emitRustExpr v1442 v1443 
                                            let v1445 : string = $"$0.replace_all(&$1, &*$2)"
                                            let v1446 : std_borrow_Cow<Str> = Fable.Core.RustInterop.emitRustExpr struct (v1444, v1439, v1437) v1445 
                                            let v1447 : string = "String::from($0)"
                                            let v1448 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1446 v1447 
                                            let v1449 : string = "fable_library_rust::String_::fromString($0)"
                                            let v1450 : string = Fable.Core.RustInterop.emitRustExpr v1448 v1449 
                                            v1450 
                                            #endif
#if FABLE_COMPILER_RUST && WASM
                                            let v1451 : string = null |> unbox<string>
                                            v1451 
                                            #endif
#if FABLE_COMPILER_RUST && CONTRACT
                                            let v1452 : string = null |> unbox<string>
                                            v1452 
                                            #endif
#if FABLE_COMPILER_TYPESCRIPT
                                            let v1453 : string = null |> unbox<string>
                                            v1453 
                                            #endif
#if FABLE_COMPILER_PYTHON
                                            let v1454 : string = null |> unbox<string>
                                            v1454 
                                            #endif
#else
                                            let v1455 : string = method98()
                                            let v1456 : string = System.Text.RegularExpressions.Regex.Replace (v1436, v1455, v1437)
                                            v1456 
                                            #endif
                                            |> fun x -> _v1438 <- Some x
                                            let v1457 : string = match _v1438 with Some x -> x | None -> failwith "base.run_target / _v1438=None"
                                            v1457
                                    let v1459 : bool = v1433 = false
                                    if v1459 then
                                        let v1460 : string = $"{v1458}\n\n{v1432}\n"
                                        let v1461 : bool = method84(v1404, v1460)
                                        let v1462 : bool = v1461 = false
                                        if v1462 then
                                            let v1463 : bool = true
                                            let mutable _v1463 : unit option = None 
                                            
#if FABLE_COMPILER || WASM || CONTRACT
                                            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                            let v1464 : string = "std::fs::write(&*$0, &*$1).unwrap()"
                                            Fable.Core.RustInterop.emitRustExpr struct (v1404, v1460) v1464 
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
                                            let v1465 : string = method65(v1460)
                                            System.IO.File.WriteAllText (v1404, v1465)
                                            () 
                                            #endif
                                            |> fun x -> _v1463 <- Some x
                                            match _v1463 with Some x -> x | None -> failwith "base.run_target / _v1463=None"
                                            ()
                                    let v1466 : string = $"bun run \"{v1404}\""
                                    let v1467 : string = "TRACE_LEVEL"
                                    let v1468 : string = "Verbose"
                                    let v1469 : (struct (string * string) []) = [|struct (v1467, v1468)|]
                                    let v1470 : System.Threading.CancellationToken option = None
                                    let v1471 : (struct (string * string) []) = [||]
                                    let v1472 : (struct (bool * string * int32) -> Async<unit>) option = None
                                    let v1473 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = None
                                    let v1474 : string option = None
                                    let v1480 : Result<string, string> =
                                        match v1267 with
                                        | US28_1(v1477) -> (* Error *)
                                            let v1478 : Result<string, string> = Error v1477 
                                            v1478
                                        | US28_0(v1475) -> (* Ok *)
                                            let v1476 : Result<string, string> = Ok v1475 
                                            v1476
                                    let v1481 : string = "v1480.ok()"
                                    let v1482 : string option = Fable.Core.RustInterop.emitRustExpr () v1481 
                                    let v1483 : bool = true
                                    let struct (v1484 : int32, v1485 : string) = method44(v1470, v1466, v1469, v1472, v1473, v1483, v1482)
                                    let v1486 : int32 = v1469.Length
                                    let v1487 : (string []) = Array.zeroCreate<string> (v1486)
                                    let v1488 : Mut4 = {l0 = 0} : Mut4
                                    while method16(v1486, v1488) do
                                        let v1490 : int32 = v1488.l0
                                        let struct (v1491 : string, v1492 : string) = v1469.[int v1490]
                                        let v1493 : string = $"$env:{v1491}=''{v1492}''"
                                        v1487.[int v1490] <- v1493
                                        let v1494 : int32 = v1490 + 1
                                        v1488.l0 <- v1494
                                        ()
                                    let v1495 : ((string []) -> string seq) = Seq.ofArray
                                    let v1496 : string seq = v1495 v1487
                                    let v1497 : (string -> (string seq -> string)) = String.concat
                                    let v1498 : string = ";"
                                    let v1499 : (string seq -> string) = v1497 v1498
                                    let v1500 : string = v1499 v1496
                                    let v1501 : string = $"pwsh -c '{v1500}; {v1466}'"
                                    let v1502 : bool = v1484 = 0
                                    if v1502 then
                                        let v1503 : (unit -> string) = closure92(v1485)
                                        let v1504 : (string -> US3) = closure72()
                                        let v1505 : (exn -> US3) = closure93(v1404, v1485, v1501)
                                        let v1506 : US3 = try v1503 () |> v1504 with ex -> v1505 ex 
                                        let v1511 : string option =
                                            match v1506 with
                                            | US3_1 -> (* None *)
                                                let v1509 : string option = None
                                                v1509
                                            | US3_0(v1507) -> (* Some *)
                                                let v1508 : string option = Some v1507 
                                                v1508
                                        let v1512 : string = "$0.unwrap()"
                                        let v1513 : string = Fable.Core.RustInterop.emitRustExpr v1511 v1512 
                                        let v1514 : US3 = US3_0(v1458)
                                        let v1515 : US3 = US3_0(v1064)
                                        let v1516 : US3 = US3_0(v1513)
                                        struct (v1514, v1515, v1516)
                                    else
                                        let v1517 : US0 = US0_4
                                        let v1518 : (unit -> string) = closure96()
                                        let v1519 : (unit -> string) = closure97(v1404, v1485, v1484, v1501)
                                        method5(v1517, v1518, v1519)
                                        let v1520 : US3 = US3_1
                                        let v1521 : US3 = US3_0(v1064)
                                        let v1522 : US3 = US3_1
                                        struct (v1520, v1521, v1522)
                            else
                                let v1529 : string = "fable_library_rust::String_::fromString($0)"
                                let v1530 : string = Fable.Core.RustInterop.emitRustExpr v13 v1529 
                                let v1532 : bool = v1530 = "python"
                                if v1532 then
                                    let v1533 : string = method11()
                                    let v1534 : string = "&*$0"
                                    let v1535 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1533 v1534 
                                    let v1536 : string = "clap::ArgMatches::get_one(&$0, v1535).cloned()"
                                    let v1537 : std_string_String option = Fable.Core.RustInterop.emitRustExpr v14 v1536 
                                    let v1538 : US5 option = None
                                    let _v1538 = ref v1538 
                                    match v1537 with
                                    | Some x -> (
                                    (fun () ->
                                    (fun () ->
                                    let v1539 : std_string_String = x
                                    let v1540 : US5 = US5_0(v1539)
                                    v1540 
                                    )
                                    |> fun x -> x () |> Some
                                    ) () ) | None -> None
                                    |> fun x -> _v1538.Value <- x
                                    let v1541 : US5 option = _v1538.Value 
                                    let v1542 : US5 = US5_1
                                    let v1543 : US5 = v1541 |> Option.defaultValue v1542 
                                    let v1547 : std_string_String =
                                        match v1543 with
                                        | US5_1 -> (* None *)
                                            failwith<std_string_String> "Option does not have a value."
                                        | US5_0(v1544) -> (* Some *)
                                            v1544
                                    let v1548 : string = "fable_library_rust::String_::fromString($0)"
                                    let v1549 : string = Fable.Core.RustInterop.emitRustExpr v1547 v1548 
                                    let v1550 : string = method66()
                                    let v1551 : string = "&*$0"
                                    let v1552 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1550 v1551 
                                    let v1553 : string = "clap::ArgMatches::get_many(&$0, v1552).map(|x| x.cloned().into_iter().collect())"
                                    let v1554 : Vec<std_string_String> option = Fable.Core.RustInterop.emitRustExpr v14 v1553 
                                    let v1555 : US25 option = None
                                    let _v1555 = ref v1555 
                                    match v1554 with
                                    | Some x -> (
                                    (fun () ->
                                    (fun () ->
                                    let v1556 : Vec<std_string_String> = x
                                    let v1557 : US25 = US25_0(v1556)
                                    v1557 
                                    )
                                    |> fun x -> x () |> Some
                                    ) () ) | None -> None
                                    |> fun x -> _v1555.Value <- x
                                    let v1558 : US25 option = _v1555.Value 
                                    let v1559 : US25 = US25_1
                                    let v1560 : US25 = v1558 |> Option.defaultValue v1559 
                                    let v1561 : (std_string_String []) = [||]
                                    let v1562 : string = "$0.to_vec()"
                                    let v1563 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr v1561 v1562 
                                    let v1566 : Vec<std_string_String> =
                                        match v1560 with
                                        | US25_1 -> (* None *)
                                            v1563
                                        | US25_0(v1564) -> (* Some *)
                                            v1564
                                    let v1568 : bool =
                                        match v0 with
                                        | US0_0 -> (* Verbose *)
                                            true
                                        | _ ->
                                            false
                                    let v1569 : bool = true
                                    let mutable _v1569 : string option = None 
                                    
#if FABLE_COMPILER || WASM || CONTRACT
                                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                    let v1570 : bool = true
                                    let mutable _v1570 : Vec<uint8> option = None 
                                    
#if FABLE_COMPILER || WASM || CONTRACT
                                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                    let v1571 : string = "std::fs::read(&*$0).unwrap()"
                                    let v1572 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v1549 v1571 
                                    v1572 
                                    #endif
#if FABLE_COMPILER_RUST && WASM
                                    let v1573 : Vec<uint8> = null |> unbox<Vec<uint8>>
                                    v1573 
                                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                                    let v1574 : Vec<uint8> = null |> unbox<Vec<uint8>>
                                    v1574 
                                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                                    let v1575 : Vec<uint8> = null |> unbox<Vec<uint8>>
                                    v1575 
                                    #endif
#if FABLE_COMPILER_PYTHON
                                    let v1576 : Vec<uint8> = null |> unbox<Vec<uint8>>
                                    v1576 
                                    #endif
#else
                                    let v1577 : (uint8 []) = v1549 |> System.IO.File.ReadAllBytes
                                    let v1578 : string = "$0.to_vec()"
                                    let v1579 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v1577 v1578 
                                    v1579 
                                    #endif
                                    |> fun x -> _v1570 <- Some x
                                    let v1580 : Vec<uint8> = match _v1570 with Some x -> x | None -> failwith "base.run_target / _v1570=None"
                                    let v1581 : string = "std::string::String::from_utf8(v1580)"
                                    let v1582 : Result<std_string_String, std_string_FromUtf8Error> = Fable.Core.RustInterop.emitRustExpr () v1581 
                                    let v1583 : string = "$0.unwrap()"
                                    let v1584 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1582 v1583 
                                    let v1585 : string = "fable_library_rust::String_::fromString($0)"
                                    let v1586 : string = Fable.Core.RustInterop.emitRustExpr v1584 v1585 
                                    v1586 
                                    #endif
#if FABLE_COMPILER_RUST && WASM
                                    let v1587 : string = null |> unbox<string>
                                    v1587 
                                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                                    let v1588 : string = null |> unbox<string>
                                    v1588 
                                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                                    let v1589 : string = null |> unbox<string>
                                    v1589 
                                    #endif
#if FABLE_COMPILER_PYTHON
                                    let v1590 : string = null |> unbox<string>
                                    v1590 
                                    #endif
#else
                                    let v1591 : string = v1549 |> System.IO.File.ReadAllText
                                    v1591 
                                    #endif
                                    |> fun x -> _v1569 <- Some x
                                    let v1592 : string = match _v1569 with Some x -> x | None -> failwith "base.run_target / _v1569=None"
                                    let v1593 : string = "py"
                                    let v1594 : string = $"%A{struct (v1593, v1592)}"
                                    let v1595 : string = method67(v1594)
                                    let v1596 : string = __SOURCE_DIRECTORY__
                                    let v1597 : string = "polyglot"
                                    let v1598 : string = ".paket"
                                    let v1599 : string = method30(v1597, v1598)
                                    let v1600 : string = method69(v1599, v1596)
                                    let v1601 : string = method30(v1600, v1597)
                                    let v1602 : string = "target/polyglot/spiral_builder"
                                    let v1603 : string = method30(v1601, v1602)
                                    let v1604 : string = "spiral_builder"
                                    let v1605 : string = method30(v1603, v1604)
                                    let v1606 : string = "packages"
                                    let v1607 : string = method30(v1605, v1606)
                                    let v1608 : string = method30(v1607, v1595)
                                    let v1609 : System.IDisposable = method74(v1608)
                                    let v1610 : string = $"{v1604}.fs"
                                    let v1611 : string = method30(v1608, v1610)
                                    let v1612 : string = method36()
                                    let v1613 : bool = true
                                    let mutable _v1613 : string option = None 
                                    
#if FABLE_COMPILER || WASM || CONTRACT
                                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                    let v1614 : string = method37(v1611)
                                    let v1615 : string = $"regex::Regex::new(&$0)"
                                    let v1616 : string = "^\\\\\\\\\\?\\\\"
                                    let v1617 : Result<regex_Regex, regex_Error> = Fable.Core.RustInterop.emitRustExpr v1616 v1615 
                                    let v1618 : string = "$0.unwrap()"
                                    let v1619 : regex_Regex = Fable.Core.RustInterop.emitRustExpr v1617 v1618 
                                    let v1620 : string = $"$0.replace_all(&$1, &*$2)"
                                    let v1621 : std_borrow_Cow<Str> = Fable.Core.RustInterop.emitRustExpr struct (v1619, v1614, v1612) v1620 
                                    let v1622 : string = "String::from($0)"
                                    let v1623 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1621 v1622 
                                    let v1624 : string = "fable_library_rust::String_::fromString($0)"
                                    let v1625 : string = Fable.Core.RustInterop.emitRustExpr v1623 v1624 
                                    v1625 
                                    #endif
#if FABLE_COMPILER_RUST && WASM
                                    let v1626 : string = null |> unbox<string>
                                    v1626 
                                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                                    let v1627 : string = null |> unbox<string>
                                    v1627 
                                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                                    let v1628 : string = null |> unbox<string>
                                    v1628 
                                    #endif
#if FABLE_COMPILER_PYTHON
                                    let v1629 : string = null |> unbox<string>
                                    v1629 
                                    #endif
#else
                                    let v1630 : string = method38()
                                    let v1631 : string = System.Text.RegularExpressions.Regex.Replace (v1611, v1630, v1612)
                                    v1631 
                                    #endif
                                    |> fun x -> _v1613 <- Some x
                                    let v1632 : string = match _v1613 with Some x -> x | None -> failwith "base.run_target / _v1613=None"
                                    let v1633 : string = $"{v1632.[0] |> string |> _.ToLower()}{v1632.[1..]}"
                                    let v1634 : string = "\\"
                                    let v1635 : string = "/"
                                    let v1636 : string = v1633.Replace (v1634, v1635)
                                    let v1637 : bool = method84(v1636, v1592)
                                    let v1638 : bool = v1637 = false
                                    if v1638 then
                                        let v1639 : bool = true
                                        let mutable _v1639 : unit option = None 
                                        
#if FABLE_COMPILER || WASM || CONTRACT
                                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                        let v1640 : string = "std::fs::write(&*$0, &*$1).unwrap()"
                                        Fable.Core.RustInterop.emitRustExpr struct (v1636, v1592) v1640 
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
                                        let v1641 : string = method65(v1592)
                                        System.IO.File.WriteAllText (v1636, v1641)
                                        () 
                                        #endif
                                        |> fun x -> _v1639 <- Some x
                                        match _v1639 with Some x -> x | None -> failwith "base.run_target / _v1639=None"
                                        ()
                                    let v1642 : string list = []
                                    let v1643 : string seq = seq { for i = 0 to v1642.Length - 1 do yield v1642.[i] }
                                    let v1644 : (string -> (string seq -> string)) = String.concat
                                    let v1645 : string = "\\n        "
                                    let v1646 : (string seq -> string) = v1644 v1645
                                    let v1647 : string = v1646 v1643
                                    let v1648 : string = "Fable.Core"
                                    let v1649 : string = $"<PackageReference Include=\"{v1648}\" Version=\"*\" />"
                                    let v1650 : string list = []
                                    let v1651 : string list = v1649 :: v1650 
                                    let v1652 : string seq = seq { for i = 0 to v1651.Length - 1 do yield v1651.[i] }
                                    let v1653 : (string -> (string seq -> string)) = String.concat
                                    let v1654 : (string seq -> string) = v1653 v1645
                                    let v1655 : string = v1654 v1652
                                    let v1656 : string = $"{v1604}.fsproj"
                                    let v1657 : string = method30(v1608, v1656)
                                    let v1658 : string = method36()
                                    let v1659 : bool = true
                                    let mutable _v1659 : string option = None 
                                    
#if FABLE_COMPILER || WASM || CONTRACT
                                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                    let v1660 : string = method37(v1657)
                                    let v1661 : string = $"regex::Regex::new(&$0)"
                                    let v1662 : Result<regex_Regex, regex_Error> = Fable.Core.RustInterop.emitRustExpr v1616 v1661 
                                    let v1663 : string = "$0.unwrap()"
                                    let v1664 : regex_Regex = Fable.Core.RustInterop.emitRustExpr v1662 v1663 
                                    let v1665 : string = $"$0.replace_all(&$1, &*$2)"
                                    let v1666 : std_borrow_Cow<Str> = Fable.Core.RustInterop.emitRustExpr struct (v1664, v1660, v1658) v1665 
                                    let v1667 : string = "String::from($0)"
                                    let v1668 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1666 v1667 
                                    let v1669 : string = "fable_library_rust::String_::fromString($0)"
                                    let v1670 : string = Fable.Core.RustInterop.emitRustExpr v1668 v1669 
                                    v1670 
                                    #endif
#if FABLE_COMPILER_RUST && WASM
                                    let v1671 : string = null |> unbox<string>
                                    v1671 
                                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                                    let v1672 : string = null |> unbox<string>
                                    v1672 
                                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                                    let v1673 : string = null |> unbox<string>
                                    v1673 
                                    #endif
#if FABLE_COMPILER_PYTHON
                                    let v1674 : string = null |> unbox<string>
                                    v1674 
                                    #endif
#else
                                    let v1675 : string = method38()
                                    let v1676 : string = System.Text.RegularExpressions.Regex.Replace (v1657, v1675, v1658)
                                    v1676 
                                    #endif
                                    |> fun x -> _v1659 <- Some x
                                    let v1677 : string = match _v1659 with Some x -> x | None -> failwith "base.run_target / _v1659=None"
                                    let v1678 : string = $"{v1677.[0] |> string |> _.ToLower()}{v1677.[1..]}"
                                    let v1679 : string = v1678.Replace (v1634, v1635)
                                    let v1680 : string = $"<Project Sdk=\"Microsoft.NET.Sdk\">"
                                    let v1681 : string = $"<PropertyGroup>"
                                    let v1682 : string = "\n"
                                    let v1683 : string = v1680 + v1682 
                                    let v1684 : string = v1683 + v1681 
                                    let v1685 : string = $"    <TargetFramework>net9.0</TargetFramework>"
                                    let v1686 : string = v1684 + v1682 
                                    let v1687 : string = v1686 + v1685 
                                    let v1688 : string = $"    <LangVersion>preview</LangVersion>"
                                    let v1689 : string = v1687 + v1682 
                                    let v1690 : string = v1689 + v1688 
                                    let v1691 : string = $"    <RollForward>Major</RollForward>"
                                    let v1692 : string = v1690 + v1682 
                                    let v1693 : string = v1692 + v1691 
                                    let v1694 : string = $"    <TargetLatestRuntimePatch>true</TargetLatestRuntimePatch>"
                                    let v1695 : string = v1693 + v1682 
                                    let v1696 : string = v1695 + v1694 
                                    let v1697 : string = $"    <PublishAot>false</PublishAot>"
                                    let v1698 : string = v1696 + v1682 
                                    let v1699 : string = v1698 + v1697 
                                    let v1700 : string = $"    <PublishTrimmed>false</PublishTrimmed>"
                                    let v1701 : string = v1699 + v1682 
                                    let v1702 : string = v1701 + v1700 
                                    let v1703 : string = $"    <PublishSingleFile>true</PublishSingleFile>"
                                    let v1704 : string = v1702 + v1682 
                                    let v1705 : string = v1704 + v1703 
                                    let v1706 : string = $"    <SelfContained>true</SelfContained>"
                                    let v1707 : string = v1705 + v1682 
                                    let v1708 : string = v1707 + v1706 
                                    let v1709 : string = $"    <Version>0.0.1-alpha.1</Version>"
                                    let v1710 : string = v1708 + v1682 
                                    let v1711 : string = v1710 + v1709 
                                    let v1712 : string = $"    <OutputType>Exe</OutputType>"
                                    let v1713 : string = v1711 + v1682 
                                    let v1714 : string = v1713 + v1712 
                                    let v1715 : string = $"</PropertyGroup>"
                                    let v1716 : string = v1714 + v1682 
                                    let v1717 : string = v1716 + v1715 
                                    let v1718 : string = $"<PropertyGroup Condition=\"$([MSBuild]::IsOSPlatform('FreeBSD'))\">"
                                    let v1719 : string = v1717 + v1682 
                                    let v1720 : string = v1719 + v1718 
                                    let v1721 : string = $"    <DefineConstants>_FREEBSD</DefineConstants>"
                                    let v1722 : string = v1720 + v1682 
                                    let v1723 : string = v1722 + v1721 
                                    let v1724 : string = $"</PropertyGroup>"
                                    let v1725 : string = v1723 + v1682 
                                    let v1726 : string = v1725 + v1724 
                                    let v1727 : string = $"<PropertyGroup Condition=\"$([MSBuild]::IsOSPlatform('Linux'))\">"
                                    let v1728 : string = v1726 + v1682 
                                    let v1729 : string = v1728 + v1727 
                                    let v1730 : string = $"    <DefineConstants>_LINUX</DefineConstants>"
                                    let v1731 : string = v1729 + v1682 
                                    let v1732 : string = v1731 + v1730 
                                    let v1733 : string = $"</PropertyGroup>"
                                    let v1734 : string = v1732 + v1682 
                                    let v1735 : string = v1734 + v1733 
                                    let v1736 : string = $"<PropertyGroup Condition=\"$([MSBuild]::IsOSPlatform('OSX'))\">"
                                    let v1737 : string = v1735 + v1682 
                                    let v1738 : string = v1737 + v1736 
                                    let v1739 : string = $"    <DefineConstants>_OSX</DefineConstants>"
                                    let v1740 : string = v1738 + v1682 
                                    let v1741 : string = v1740 + v1739 
                                    let v1742 : string = $"</PropertyGroup>"
                                    let v1743 : string = v1741 + v1682 
                                    let v1744 : string = v1743 + v1742 
                                    let v1745 : string = $"<PropertyGroup Condition=\"$([MSBuild]::IsOSPlatform('Windows'))\">"
                                    let v1746 : string = v1744 + v1682 
                                    let v1747 : string = v1746 + v1745 
                                    let v1748 : string = $"    <DefineConstants>_WINDOWS</DefineConstants>"
                                    let v1749 : string = v1747 + v1682 
                                    let v1750 : string = v1749 + v1748 
                                    let v1751 : string = $"</PropertyGroup>"
                                    let v1752 : string = v1750 + v1682 
                                    let v1753 : string = v1752 + v1751 
                                    let v1754 : string = $"<ItemGroup>"
                                    let v1755 : string = v1753 + v1682 
                                    let v1756 : string = v1755 + v1754 
                                    let v1757 : string = $"    {v1647}"
                                    let v1758 : string = v1756 + v1682 
                                    let v1759 : string = v1758 + v1757 
                                    let v1760 : string = $"    <Compile Include=\"{v1636}\" />"
                                    let v1761 : string = v1759 + v1682 
                                    let v1762 : string = v1761 + v1760 
                                    let v1763 : string = $"</ItemGroup>"
                                    let v1764 : string = v1762 + v1682 
                                    let v1765 : string = v1764 + v1763 
                                    let v1766 : string = $"<ItemGroup>"
                                    let v1767 : string = v1765 + v1682 
                                    let v1768 : string = v1767 + v1766 
                                    let v1769 : string = $"    {v1655}"
                                    let v1770 : string = v1768 + v1682 
                                    let v1771 : string = v1770 + v1769 
                                    let v1772 : string = $"</ItemGroup>"
                                    let v1773 : string = v1771 + v1682 
                                    let v1774 : string = v1773 + v1772 
                                    let v1775 : string = $"</Project>"
                                    let v1776 : string = v1774 + v1682 
                                    let v1777 : string = v1776 + v1775 
                                    let v1778 : bool = method84(v1679, v1777)
                                    let v1779 : bool = v1778 = false
                                    if v1779 then
                                        let v1780 : bool = true
                                        let mutable _v1780 : unit option = None 
                                        
#if FABLE_COMPILER || WASM || CONTRACT
                                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                        let v1781 : string = "std::fs::write(&*$0, &*$1).unwrap()"
                                        Fable.Core.RustInterop.emitRustExpr struct (v1679, v1777) v1781 
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
                                        let v1782 : string = method65(v1777)
                                        System.IO.File.WriteAllText (v1679, v1782)
                                        () 
                                        #endif
                                        |> fun x -> _v1780 <- Some x
                                        match _v1780 with Some x -> x | None -> failwith "base.run_target / _v1780=None"
                                        ()
                                    let v1783 : string = method86(v1679)
                                    let v1784 : string = __SOURCE_DIRECTORY__
                                    let v1785 : string = method30(v1597, v1598)
                                    let v1786 : string = method69(v1785, v1784)
                                    let v1787 : string = method30(v1786, v1597)
                                    let v1788 : string = method29()
                                    let v1789 : (unit -> string) = v1788.ToLower
                                    let v1790 : string = v1789 ()
                                    let v1791 : (unit -> string) = v1787.ToLower
                                    let v1792 : string = v1791 ()
                                    let v1793 : bool = v1790.StartsWith v1792 
                                    let v1796 : US28 =
                                        if v1793 then
                                            US28_1(v1792)
                                        else
                                            US28_0(v1792)
                                    let v1802 : Result<string, string> =
                                        match v1796 with
                                        | US28_1(v1799) -> (* Error *)
                                            let v1800 : Result<string, string> = Error v1799 
                                            v1800
                                        | US28_0(v1797) -> (* Ok *)
                                            let v1798 : Result<string, string> = Ok v1797 
                                            v1798
                                    let v1803 : string = "true; let _result = $0.unwrap_or_else(|x| { //"
                                    let v1804 : bool = Fable.Core.RustInterop.emitRustExpr v1802 v1803 
                                    let v1805 : string = "x"
                                    let v1806 : string = Fable.Core.RustInterop.emitRustExpr () v1805 
                                    let v1807 : string = "true; $0 })"
                                    let v1808 : bool = Fable.Core.RustInterop.emitRustExpr v1806 v1807 
                                    let v1809 : string = "_result"
                                    let v1810 : string = Fable.Core.RustInterop.emitRustExpr () v1809 
                                    let v1811 : string = "lib/python/fable/fable_modules"
                                    let v1812 : string = method30(v1810, v1811)
                                    let v1813 : string = $"fable-library-{v1593}"
                                    let v1814 : string = method30(v1812, v1813)
                                    let v1815 : string = $"fable_modules/fable-library"
                                    let v1816 : string = method30(v1783, v1815)
                                    let v1817 : bool = method70(v1814)
                                    let v1818 : bool = v1817 = false
                                    if v1818 then
                                        let v1819 : System.IDisposable = method74(v1814)
                                        ()
                                    let v1820 : string = method86(v1816)
                                    let v1821 : bool = method70(v1820)
                                    let v1822 : bool = v1821 = false
                                    if v1822 then
                                        let v1823 : System.IDisposable = method74(v1820)
                                        ()
                                    let v1824 : bool = method70(v1816)
                                    let v1829 : bool =
                                        if v1824 then
                                            let v1825 : string = "std::fs::read_link(&*$0)"
                                            let v1826 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v1816 v1825 
                                            let v1827 : string = "v1826.is_err()"
                                            let v1828 : bool = Fable.Core.RustInterop.emitRustExpr () v1827 
                                            v1828
                                        else
                                            false
                                    if v1829 then
                                        let v1830 : bool = true
                                        method77(v1830, v1816)
                                    let v1831 : bool = method70(v1816)
                                    let v1832 : bool = v1831 = false
                                    if v1832 then
                                        let v1833 : bool = true
                                        let mutable _v1833 : unit option = None 
                                        
#if FABLE_COMPILER || WASM || CONTRACT
                                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                        let v1834 : bool = true
                                        let mutable _v1834 : unit option = None 
                                        
#if _FREEBSD
                                        let v1835 : string = "std::os::unix::fs::symlink(&*$0, &*$1).unwrap()"
                                        Fable.Core.RustInterop.emitRustExpr struct (v1814, v1816) v1835 
                                        () 
                                        #endif
#if _LINUX
                                        let v1836 : string = "std::os::unix::fs::symlink(&*$0, &*$1).unwrap()"
                                        Fable.Core.RustInterop.emitRustExpr struct (v1814, v1816) v1836 
                                        () 
                                        #endif
#if _OSX
                                        let v1837 : string = "std::os::unix::fs::symlink(&*$0, &*$1).unwrap()"
                                        Fable.Core.RustInterop.emitRustExpr struct (v1814, v1816) v1837 
                                        () 
                                        #endif
#if _WINDOWS
                                        let v1838 : string = "std::os::windows::fs::symlink_dir(&*$0, &*$1).unwrap()"
                                        Fable.Core.RustInterop.emitRustExpr struct (v1814, v1816) v1838 
                                        () 
                                        #endif
                                        |> fun x -> _v1834 <- Some x
                                        match _v1834 with Some x -> x | None -> failwith "runtime.run_platform / _v1834=None"
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
                                        let v1839 : System.IO.FileSystemInfo = System.IO.Directory.CreateSymbolicLink (v1816, v1814)
                                        () 
                                        #endif
                                        |> fun x -> _v1833 <- Some x
                                        match _v1833 with Some x -> x | None -> failwith "base.run_target / _v1833=None"
                                        ()
                                    let struct (v1840 : int32, v1841 : string) = method93(v1783, v1593, v1679, v1796)
                                    let v1842 : bool = v1840 <> 0 
                                    if v1842 then
                                        let v1843 : US0 = US0_4
                                        let v1844 : (unit -> string) = closure98(v1841, v1840)
                                        let v1845 : (unit -> string) = closure6()
                                        method5(v1843, v1844, v1845)
                                        let v1846 : US3 = US3_1
                                        let v1847 : US3 = US3_0(v1593)
                                        let v1848 : US3 = US3_0(v1841)
                                        struct (v1846, v1847, v1848)
                                    else
                                        let v1849 : string = "true; let _result : Vec<_> = v1566.into_iter().map(|x| { //"
                                        let v1850 : bool = Fable.Core.RustInterop.emitRustExpr () v1849 
                                        let v1851 : string = "x"
                                        let v1852 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v1851 
                                        let v1853 : string = "fable_library_rust::String_::fromString($0)"
                                        let v1854 : string = Fable.Core.RustInterop.emitRustExpr v1852 v1853 
                                        let v1855 : string = "="
                                        let v1856 : bool = v1854.Contains v1855 
                                        let v1858 : string =
                                            if v1856 then
                                                v1854
                                            else
                                                let v1857 : string = $"\"{v1854}\":\"*\""
                                                v1857
                                        let v1859 : string = "true; $0 }).collect::<Vec<_>>()"
                                        let v1860 : bool = Fable.Core.RustInterop.emitRustExpr v1858 v1859 
                                        let v1861 : string = "_result"
                                        let v1862 : Vec<string> = Fable.Core.RustInterop.emitRustExpr () v1861 
                                        let v1863 : string = "fable_library_rust::NativeArray_::array_from($0)"
                                        let v1864 : (string []) = Fable.Core.RustInterop.emitRustExpr v1862 v1863 
                                        let v1865 : string seq = seq { for i = 0 to v1864.Length - 1 do yield v1864.[i] }
                                        let v1866 : (string -> (string seq -> string)) = String.concat
                                        let v1867 : string = ",\n"
                                        let v1868 : (string seq -> string) = v1866 v1867
                                        let v1869 : string = v1868 v1865
                                        let v1870 : string = $"{{"
                                        let v1871 : string = $"  \"name\": \"spiral_builder_{v1595}\","
                                        let v1872 : string = v1870 + v1871 
                                        let v1873 : string = $"  \"dependencies\": {{"
                                        let v1874 : string = v1872 + v1873 
                                        let v1875 : string = v1874 + v1869 
                                        let v1876 : string = $"  }},"
                                        let v1877 : string = v1875 + v1876 
                                        let v1878 : string = $"    \"devDependencies\": {{"
                                        let v1879 : string = v1877 + v1878 
                                        let v1880 : string = $"  }},"
                                        let v1881 : string = v1879 + v1880 
                                        let v1882 : string = $"}}"
                                        let v1883 : string = v1881 + v1882 
                                        let v1884 : string = "package.json"
                                        let v1885 : string = method30(v1783, v1884)
                                        let v1886 : string = "../.."
                                        let v1887 : string = method30(v1783, v1886)
                                        let v1888 : string = method30(v1887, v1884)
                                        let v1889 : bool = method84(v1885, v1883)
                                        let v1890 : bool = v1889 = false
                                        if v1890 then
                                            let v1891 : bool = true
                                            let mutable _v1891 : unit option = None 
                                            
#if FABLE_COMPILER || WASM || CONTRACT
                                            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                            let v1892 : string = "std::fs::write(&*$0, &*$1).unwrap()"
                                            Fable.Core.RustInterop.emitRustExpr struct (v1885, v1883) v1892 
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
                                            let v1893 : string = method65(v1883)
                                            System.IO.File.WriteAllText (v1885, v1893)
                                            () 
                                            #endif
                                            |> fun x -> _v1891 <- Some x
                                            match _v1891 with Some x -> x | None -> failwith "base.run_target / _v1891=None"
                                            ()
                                        let v1894 : string = ""
                                        let v1895 : bool = method84(v1888, v1894)
                                        let v1896 : bool = v1895 = false
                                        if v1896 then
                                            let v1897 : bool = true
                                            let mutable _v1897 : unit option = None 
                                            
#if FABLE_COMPILER || WASM || CONTRACT
                                            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                            let v1898 : string = "std::fs::write(&*$0, &*$1).unwrap()"
                                            Fable.Core.RustInterop.emitRustExpr struct (v1888, v1894) v1898 
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
                                            let v1899 : string = method107()
                                            System.IO.File.WriteAllText (v1888, v1899)
                                            () 
                                            #endif
                                            |> fun x -> _v1897 <- Some x
                                            match _v1897 with Some x -> x | None -> failwith "base.run_target / _v1897=None"
                                            ()
                                        let v1900 : string = $"{v1604}.{v1593}"
                                        let v1901 : string = method30(v1783, v1900)
                                        let v1902 : US0 = US0_1
                                        let v1903 : (unit -> string) = closure99()
                                        let v1904 : (unit -> string) = closure100(v1901)
                                        method5(v1902, v1903, v1904)
                                        let v1905 : bool = true
                                        let mutable _v1905 : string option = None 
                                        
#if FABLE_COMPILER || WASM || CONTRACT
                                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                        let v1906 : bool = true
                                        let mutable _v1906 : Vec<uint8> option = None 
                                        
#if FABLE_COMPILER || WASM || CONTRACT
                                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                        let v1907 : string = "std::fs::read(&*$0).unwrap()"
                                        let v1908 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v1901 v1907 
                                        v1908 
                                        #endif
#if FABLE_COMPILER_RUST && WASM
                                        let v1909 : Vec<uint8> = null |> unbox<Vec<uint8>>
                                        v1909 
                                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                                        let v1910 : Vec<uint8> = null |> unbox<Vec<uint8>>
                                        v1910 
                                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                                        let v1911 : Vec<uint8> = null |> unbox<Vec<uint8>>
                                        v1911 
                                        #endif
#if FABLE_COMPILER_PYTHON
                                        let v1912 : Vec<uint8> = null |> unbox<Vec<uint8>>
                                        v1912 
                                        #endif
#else
                                        let v1913 : (uint8 []) = v1901 |> System.IO.File.ReadAllBytes
                                        let v1914 : string = "$0.to_vec()"
                                        let v1915 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v1913 v1914 
                                        v1915 
                                        #endif
                                        |> fun x -> _v1906 <- Some x
                                        let v1916 : Vec<uint8> = match _v1906 with Some x -> x | None -> failwith "base.run_target / _v1906=None"
                                        let v1917 : string = "std::string::String::from_utf8(v1916)"
                                        let v1918 : Result<std_string_String, std_string_FromUtf8Error> = Fable.Core.RustInterop.emitRustExpr () v1917 
                                        let v1919 : string = "$0.unwrap()"
                                        let v1920 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1918 v1919 
                                        let v1921 : string = "fable_library_rust::String_::fromString($0)"
                                        let v1922 : string = Fable.Core.RustInterop.emitRustExpr v1920 v1921 
                                        v1922 
                                        #endif
#if FABLE_COMPILER_RUST && WASM
                                        let v1923 : string = null |> unbox<string>
                                        v1923 
                                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                                        let v1924 : string = null |> unbox<string>
                                        v1924 
                                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                                        let v1925 : string = null |> unbox<string>
                                        v1925 
                                        #endif
#if FABLE_COMPILER_PYTHON
                                        let v1926 : string = null |> unbox<string>
                                        v1926 
                                        #endif
#else
                                        let v1927 : string = v1901 |> System.IO.File.ReadAllText
                                        v1927 
                                        #endif
                                        |> fun x -> _v1905 <- Some x
                                        let v1928 : string = match _v1905 with Some x -> x | None -> failwith "base.run_target / _v1905=None"
                                        let v1929 : string = "# spiral_builder.process_python"
                                        let v1930 : bool = v1928.Contains v1929 
                                        let v1958 : string =
                                            if v1930 then
                                                v1928
                                            else
                                                let v1931 : string = "\";\".into()"
                                                let v1932 : string = Fable.Core.RustInterop.emitRustExpr () v1931 
                                                let v1933 : string = "),)"
                                                let v1934 : string = v1933 + v1932 
                                                let v1935 : string = "));"
                                                let v1936 : string = v1928.Replace (v1934, v1935)
                                                let v1937 : string = method97()
                                                let v1938 : bool = true
                                                let mutable _v1938 : string option = None 
                                                
#if FABLE_COMPILER || WASM || CONTRACT
                                                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                                let v1939 : string = method37(v1936)
                                                let v1940 : string = $"regex::Regex::new(&$0)"
                                                let v1941 : string = "\\s\\sdefaultOf\\(\\);"
                                                let v1942 : Result<regex_Regex, regex_Error> = Fable.Core.RustInterop.emitRustExpr v1941 v1940 
                                                let v1943 : string = "$0.unwrap()"
                                                let v1944 : regex_Regex = Fable.Core.RustInterop.emitRustExpr v1942 v1943 
                                                let v1945 : string = $"$0.replace_all(&$1, &*$2)"
                                                let v1946 : std_borrow_Cow<Str> = Fable.Core.RustInterop.emitRustExpr struct (v1944, v1939, v1937) v1945 
                                                let v1947 : string = "String::from($0)"
                                                let v1948 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1946 v1947 
                                                let v1949 : string = "fable_library_rust::String_::fromString($0)"
                                                let v1950 : string = Fable.Core.RustInterop.emitRustExpr v1948 v1949 
                                                v1950 
                                                #endif
#if FABLE_COMPILER_RUST && WASM
                                                let v1951 : string = null |> unbox<string>
                                                v1951 
                                                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                                                let v1952 : string = null |> unbox<string>
                                                v1952 
                                                #endif
#if FABLE_COMPILER_TYPESCRIPT
                                                let v1953 : string = null |> unbox<string>
                                                v1953 
                                                #endif
#if FABLE_COMPILER_PYTHON
                                                let v1954 : string = null |> unbox<string>
                                                v1954 
                                                #endif
#else
                                                let v1955 : string = method98()
                                                let v1956 : string = System.Text.RegularExpressions.Regex.Replace (v1936, v1955, v1937)
                                                v1956 
                                                #endif
                                                |> fun x -> _v1938 <- Some x
                                                let v1957 : string = match _v1938 with Some x -> x | None -> failwith "base.run_target / _v1938=None"
                                                v1957
                                        let v1959 : bool = v1930 = false
                                        if v1959 then
                                            let v1960 : string = $"{v1958}\n\n{v1929}\n"
                                            let v1961 : bool = method84(v1901, v1960)
                                            let v1962 : bool = v1961 = false
                                            if v1962 then
                                                let v1963 : bool = true
                                                let mutable _v1963 : unit option = None 
                                                
#if FABLE_COMPILER || WASM || CONTRACT
                                                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                                let v1964 : string = "std::fs::write(&*$0, &*$1).unwrap()"
                                                Fable.Core.RustInterop.emitRustExpr struct (v1901, v1960) v1964 
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
                                                let v1965 : string = method65(v1960)
                                                System.IO.File.WriteAllText (v1901, v1965)
                                                () 
                                                #endif
                                                |> fun x -> _v1963 <- Some x
                                                match _v1963 with Some x -> x | None -> failwith "base.run_target / _v1963=None"
                                                ()
                                        let v1966 : string = $"python \"{v1901}\""
                                        let v1967 : string = "TRACE_LEVEL"
                                        let v1968 : string = "Verbose"
                                        let v1969 : (struct (string * string) []) = [|struct (v1967, v1968)|]
                                        let v1970 : System.Threading.CancellationToken option = None
                                        let v1971 : (struct (string * string) []) = [||]
                                        let v1972 : (struct (bool * string * int32) -> Async<unit>) option = None
                                        let v1973 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = None
                                        let v1974 : string option = None
                                        let v1980 : Result<string, string> =
                                            match v1796 with
                                            | US28_1(v1977) -> (* Error *)
                                                let v1978 : Result<string, string> = Error v1977 
                                                v1978
                                            | US28_0(v1975) -> (* Ok *)
                                                let v1976 : Result<string, string> = Ok v1975 
                                                v1976
                                        let v1981 : string = "v1980.ok()"
                                        let v1982 : string option = Fable.Core.RustInterop.emitRustExpr () v1981 
                                        let v1983 : bool = true
                                        let struct (v1984 : int32, v1985 : string) = method44(v1970, v1966, v1969, v1972, v1973, v1983, v1982)
                                        let v1986 : int32 = v1969.Length
                                        let v1987 : (string []) = Array.zeroCreate<string> (v1986)
                                        let v1988 : Mut4 = {l0 = 0} : Mut4
                                        while method16(v1986, v1988) do
                                            let v1990 : int32 = v1988.l0
                                            let struct (v1991 : string, v1992 : string) = v1969.[int v1990]
                                            let v1993 : string = $"$env:{v1991}=''{v1992}''"
                                            v1987.[int v1990] <- v1993
                                            let v1994 : int32 = v1990 + 1
                                            v1988.l0 <- v1994
                                            ()
                                        let v1995 : ((string []) -> string seq) = Seq.ofArray
                                        let v1996 : string seq = v1995 v1987
                                        let v1997 : (string -> (string seq -> string)) = String.concat
                                        let v1998 : string = ";"
                                        let v1999 : (string seq -> string) = v1997 v1998
                                        let v2000 : string = v1999 v1996
                                        let v2001 : string = $"pwsh -c '{v2000}; {v1966}'"
                                        let v2002 : bool = v1984 = 0
                                        if v2002 then
                                            let v2003 : (unit -> string) = closure101(v1985)
                                            let v2004 : (string -> US3) = closure72()
                                            let v2005 : (exn -> US3) = closure102(v1901, v1985, v2001)
                                            let v2006 : US3 = try v2003 () |> v2004 with ex -> v2005 ex 
                                            let v2011 : string option =
                                                match v2006 with
                                                | US3_1 -> (* None *)
                                                    let v2009 : string option = None
                                                    v2009
                                                | US3_0(v2007) -> (* Some *)
                                                    let v2008 : string option = Some v2007 
                                                    v2008
                                            let v2012 : string = "$0.unwrap()"
                                            let v2013 : string = Fable.Core.RustInterop.emitRustExpr v2011 v2012 
                                            let v2014 : US3 = US3_0(v1958)
                                            let v2015 : US3 = US3_0(v1593)
                                            let v2016 : US3 = US3_0(v2013)
                                            struct (v2014, v2015, v2016)
                                        else
                                            let v2017 : US0 = US0_4
                                            let v2018 : (unit -> string) = closure105()
                                            let v2019 : (unit -> string) = closure106(v1901, v1985, v1984, v2001)
                                            method5(v2017, v2018, v2019)
                                            let v2020 : US3 = US3_1
                                            let v2021 : US3 = US3_0(v1593)
                                            let v2022 : US3 = US3_1
                                            struct (v2020, v2021, v2022)
                                else
                                    let v2029 : US0 = US0_1
                                    let v2030 : (unit -> string) = closure107()
                                    let v2031 : (unit -> string) = closure108(v14, v13)
                                    method5(v2029, v2030, v2031)
                                    let v2032 : US3 = US3_1
                                    let v2033 : US3 = US3_1
                                    let v2034 : US3 = US3_1
                                    struct (v2032, v2033, v2034)
                    let v2047 : string =
                        match v2042 with
                        | US3_1 -> (* None *)
                            let v2045 : string = ""
                            v2045
                        | US3_0(v2044) -> (* Some *)
                            v2044
                    let v2048 : string = "extension"
                    let v2052 : string =
                        match v2041 with
                        | US3_1 -> (* None *)
                            let v2050 : string = ""
                            v2050
                        | US3_0(v2049) -> (* Some *)
                            v2049
                    let v2053 : string = "code"
                    let v2057 : string =
                        match v2043 with
                        | US3_1 -> (* None *)
                            let v2055 : string = ""
                            v2055
                        | US3_0(v2054) -> (* Some *)
                            v2054
                    let v2058 : string = "output"
                    [|struct (v2048, v2047); struct (v2053, v2052); struct (v2058, v2057)|]
        | _ ->
            let v2062 : string = "extension"
            let v2063 : string = ""
            let v2064 : string = "code"
            let v2065 : string = "output"
            [|struct (v2062, v2063); struct (v2064, v2063); struct (v2065, v2063)|]
    let v2068 : string = "$0.to_vec()"
    let v2069 : Vec<struct (string * string)> = Fable.Core.RustInterop.emitRustExpr v2067 v2068 
    let v2070 : string = "$0.into_iter().map(|x| $1(x.clone())).collect::<Vec<_>>()"
    let v2071 : (struct (string * string) -> (std_string_String * std_string_String)) = closure109()
    let v2072 : Vec<(std_string_String * std_string_String)> = Fable.Core.RustInterop.emitRustExpr struct (v2069, v2071) v2070 
    let v2073 : string = "std::collections::BTreeMap::from_iter(v2072.iter().map(|x| x.as_ref()).map(|&(ref k, ref v)| (k.clone(), v.clone())))"
    let v2074 : std_collections_BTreeMap<std_string_String, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v2073 
    let v2075 : string = "serde_json::to_string(&v2074)"
    let v2076 : Result<std_string_String, serde_json_Error> = Fable.Core.RustInterop.emitRustExpr () v2075 
    let v2077 : (serde_json_Error -> string) = method108()
    let v2078 : string = "$0.map_err(|x| $1(x))"
    let v2079 : Result<std_string_String, string> = Fable.Core.RustInterop.emitRustExpr struct (v2076, v2077) v2078 
    let v2080 : string = "true; let _result = $0.map(|x| { //"
    let v2081 : bool = Fable.Core.RustInterop.emitRustExpr v2079 v2080 
    let v2082 : string = "x"
    let v2083 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v2082 
    let v2084 : string = "fable_library_rust::String_::fromString($0)"
    let v2085 : string = Fable.Core.RustInterop.emitRustExpr v2083 v2084 
    let v2086 : string = "true; $0 })"
    let v2087 : bool = Fable.Core.RustInterop.emitRustExpr v2085 v2086 
    let v2088 : string = "_result"
    let v2089 : Result<string, string> = Fable.Core.RustInterop.emitRustExpr () v2088 
    let v2090 : Result<string, string> = method109(v2089)
    let v2091 : string = ""
    let v2092 : string = "}"
    let v2093 : string = v2091 + v2092 
    let v2094 : string = v2093 + v2092 
    let v2095 : string = v2094 + v2092 
    let v2096 : string = "{"
    let v2097 : string = v2091 + v2096 
    let v2098 : string = v2097 + v2096 
    let v2099 : string = "v2090 " + v2095 + "); " + v2098 + " //"
    Fable.Core.RustInterop.emitRustExpr () v2099 
    let v2100 : string = "__result"
    let v2101 : std_pin_Pin<Box<Dyn<std_future_Future<Result<string, string>>>>> = Fable.Core.RustInterop.emitRustExpr () v2100 
    v2101
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
