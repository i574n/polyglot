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
    | US21_0 of f0_0 : std_sync_Arc<std_sync_Mutex<std_process_Child option>>
    | US21_1 of f1_0 : std_string_String
and [<Struct>] US22 =
    | US22_0 of f0_0 : std_sync_Arc<std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>>
    | US22_1
and [<Struct>] US23 =
    | US23_0 of f0_0 : std_string_String
    | US23_1 of f1_0 : std_string_String
and [<Struct>] US24 =
    | US24_0 of f0_0 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit)
    | US24_1
and [<Struct>] US25 =
    | US25_0 of f0_0 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>>
    | US25_1
and [<Struct>] US26 =
    | US26_0 of f0_0 : std_process_Output
    | US26_1 of f1_0 : std_string_String
and [<Struct>] US27 =
    | US27_0 of f0_0 : int32
    | US27_1
and [<Struct>] US28 =
    | US28_0 of f0_0 : (struct (bool * string * int32) -> Async<unit>)
    | US28_1
and [<Struct>] US29 =
    | US29_0 of f0_0 : System.Threading.CancellationToken
    | US29_1
and Mut5 = {mutable l0 : int32; mutable l1 : int32; mutable l2 : (string [])}
and [<Struct>] US30 =
    | US30_0
    | US30_1 of f1_0 : std_string_String
and [<Struct>] US31 =
    | US31_0 of f0_0 : chrono_DateTime<chrono_Utc>
    | US31_1
and [<Struct>] US32 =
    | US32_0 of f0_0 : int32 * f0_1 : string
    | US32_1 of f1_0 : int32 * f1_1 : string
and [<Struct>] US33 =
    | US33_0 of f0_0 : std_collections_HashMap<string, string>
    | US33_1
and [<Struct>] US34 =
    | US34_0 of f0_0 : US3
    | US34_1
and UH3 =
    | UH3_0
    | UH3_1 of string * bool * UH3
and [<Struct>] US35 =
    | US35_0
    | US35_1
    | US35_2
and [<Struct>] US36 =
    | US36_0 of f0_0 : std_fs_FileType
    | US36_1 of f1_0 : std_string_String
and [<Struct>] US37 =
    | US37_0 of f0_0 : async_walkdir_DirEntry
    | US37_1 of f1_0 : std_string_String
and [<Struct>] US38 =
    | US38_0 of f0_0 : string * f0_1 : string
    | US38_1
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
and method16 (v0 : string) : string =
    v0
and method15 (v0 : string, v1 : string) : struct (string * string) =
    let v2 : string = method16(v0)
    struct (v1, v2)
and method14 (v0 : string, v1 : string) : string =
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
    let struct (v37 : string, v38 : string) = method15(v1, v0)
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
and method18 (v0 : string) : bool =
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
and method20 (v0 : string) : string option =
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
    method20(v0)
and method19 () : (string -> string option) =
    closure9()
and method21 (v0 : string, v1 : string, v2 : string) : US12 =
    let v3 : string = method14(v2, v0)
    let v4 : bool = method18(v3)
    if v4 then
        US12_0(v2)
    else
        let v6 : (string -> string option) = method19()
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
            method21(v0, v1, v14)
and method17 (v0 : string, v1 : string) : US12 =
    let v2 : string = method14(v1, v0)
    let v3 : bool = method18(v2)
    if v3 then
        US12_0(v1)
    else
        let v5 : (string -> string option) = method19()
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
            method21(v0, v1, v13)
and closure10 () () : string =
    let v0 : string = "file_system.get_workspace_root"
    v0
and closure11 (v0 : string) () : string =
    let v1 : (unit -> string) = closure6()
    let v2 : string = $"error: {v0} / {v1 ()}"
    v2
and method22 () : string =
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
    let v20 : string = null |> unbox<string>
    v20 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v21 : string = null |> unbox<string>
    v21 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v22 : (unit -> string) = System.IO.Directory.GetCurrentDirectory
    let v23 : string = v22 ()
    v23 
    #endif
#if FABLE_COMPILER_PYTHON
    let v24 : (unit -> string) = System.IO.Directory.GetCurrentDirectory
    let v25 : string = v24 ()
    v25 
    #endif
#else
    let v26 : (unit -> string) = System.IO.Directory.GetCurrentDirectory
    let v27 : string = v26 ()
    v27 
    #endif
    |> fun x -> _v0 <- Some x
    let v28 : string = match _v0 with Some x -> x | None -> failwith "base.run_target / _v0=None"
    v28
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
    match v11 with
    | US16_1(v22) -> (* Error *)
        US15_1(v22)
    | US16_0(v12, v13, v14, v15, v16) -> (* Ok *)
        let v17 : string list = []
        let v18 : string list = method44(v12, v17)
        let v19 : (string list -> (string [])) = List.toArray
        let v20 : (string []) = v19 v18
        US15_0(v20)
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
and closure19 () (v0 : std_sync_Arc<std_sync_Mutex<std_process_Child option>>) : US21 =
    US21_0(v0)
and method48 () : (std_sync_Arc<std_sync_Mutex<std_process_Child option>> -> US21) =
    closure19()
and closure20 () (v0 : std_string_String) : US21 =
    US21_1(v0)
and method49 () : (std_string_String -> US21) =
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
and closure23 () (v0 : std_string_String) : US23 =
    US23_0(v0)
and method51 () : (std_string_String -> US23) =
    closure23()
and closure24 () (v0 : std_string_String) : US23 =
    US23_1(v0)
and method52 () : (std_string_String -> US23) =
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
and closure29 () (v0 : std_process_Output) : US26 =
    US26_0(v0)
and closure30 () (v0 : std_string_String) : US26 =
    US26_1(v0)
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
        let v21 : US28 option = None
        let _v21 = ref v21 
        match v3 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v22 : (struct (bool * string * int32) -> Async<unit>) = x
        let v23 : US28 = US28_0(v22)
        v23 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v21.Value <- x
        let v24 : US28 option = _v21.Value 
        let v25 : US28 = US28_1
        let v26 : US28 = v24 |> Option.defaultValue v25 
        match v26 with
        | US28_1 -> (* None *)
            ()
        | US28_0(v27) -> (* Some *)
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
        let v21 : US28 option = None
        let _v21 = ref v21 
        match v3 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v22 : (struct (bool * string * int32) -> Async<unit>) = x
        let v23 : US28 = US28_0(v22)
        v23 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v21.Value <- x
        let v24 : US28 option = _v21.Value 
        let v25 : US28 = US28_1
        let v26 : US28 = v24 |> Option.defaultValue v25 
        match v26 with
        | US28_1 -> (* None *)
            ()
        | US28_0(v27) -> (* Some *)
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
    let v56 : US29 option = None
    let _v56 = ref v56 
    match v0 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v57 : System.Threading.CancellationToken = x
    let v58 : US29 = US29_0(v57)
    v58 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v56.Value <- x
    let v59 : US29 option = _v56.Value 
    let v60 : US29 = US29_1
    let v61 : US29 = v59 |> Option.defaultValue v60 
    let v65 : System.Threading.CancellationToken =
        match v61 with
        | US29_1 -> (* None *)
            let v63 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
            v63
        | US29_0(v62) -> (* Some *)
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
    let v101 : (std_sync_Arc<std_sync_Mutex<std_process_Child option>> -> US21) = method48()
    let v102 : (std_string_String -> US21) = method49()
    let v103 : string = "match v100 { Ok(x) => $0(x), Err(e) => $1(e) }"
    let v104 : US21 = Fable.Core.RustInterop.emitRustExpr struct (v101, v102) v103 
    let struct (v500 : int32, v501 : US5, v502 : US22) =
        match v104 with
        | US21_1(v491) -> (* Error *)
            let v492 : US0 = US0_4
            let v493 : (unit -> string) = closure21()
            let v494 : (unit -> string) = closure22(v491)
            method5(v492, v493, v494)
            let v495 : US5 = US5_0(v491)
            let v496 : US22 = US22_1
            struct (-1, v495, v496)
        | US21_0(v105) -> (* Ok *)
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
            let v218 : (std_string_String -> US23) = method51()
            let v219 : (std_string_String -> US23) = method52()
            let v220 : string = "match v217 { Ok(x) => $0(x), Err(e) => $1(e) }"
            let v221 : US23 = Fable.Core.RustInterop.emitRustExpr struct (v218, v219) v220 
            let v254 : std_string_String =
                match v221 with
                | US23_1(v244) -> (* Error *)
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
                | US23_0(v222) -> (* Ok *)
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
            let v297 : (std_string_String -> US23) = method51()
            let v298 : (std_string_String -> US23) = method52()
            let v299 : string = "match v296 { Ok(x) => $0(x), Err(e) => $1(e) }"
            let v300 : US23 = Fable.Core.RustInterop.emitRustExpr struct (v297, v298) v299 
            let v338 : std_string_String =
                match v300 with
                | US23_1(v328) -> (* Error *)
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
                | US23_0(v301) -> (* Ok *)
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
            let v362 : US24 option = None
            let _v362 = ref v362 
            match v4 with
            | Some x -> (
            (fun () ->
            (fun () ->
            let v363 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) = x
            let v364 : US24 = US24_0(v363)
            v364 
            )
            |> fun x -> x () |> Some
            ) () ) | None -> None
            |> fun x -> _v362.Value <- x
            let v365 : US24 option = _v362.Value 
            let v366 : US24 = US24_1
            let v367 : US24 = v365 |> Option.defaultValue v366 
            match v367 with
            | US24_1 -> (* None *)
                ()
            | US24_0(v368) -> (* Some *)
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
                let v392 : US25 option = None
                let _v392 = ref v392 
                match v391 with
                | Some x -> (
                (fun () ->
                (fun () ->
                let v393 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> = x
                let v394 : US25 = US25_0(v393)
                v394 
                )
                |> fun x -> x () |> Some
                ) () ) | None -> None
                |> fun x -> _v392.Value <- x
                let v395 : US25 option = _v392.Value 
                let v396 : US25 = US25_1
                let v397 : US25 = v395 |> Option.defaultValue v396 
                match v397 with
                | US25_1 -> (* None *)
                    ()
                | US25_0(v398) -> (* Some *)
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
            let v449 : (std_process_Output -> US26) = closure29()
            let v450 : (std_string_String -> US26) = closure30()
            let v451 : US26 = match v426 with Ok x -> v449 x | Error x -> v450 x
            match v451 with
            | US26_1(v479) -> (* Error *)
                let v480 : US0 = US0_4
                let v481 : (unit -> string) = closure31()
                let v482 : (unit -> string) = closure32(v479)
                method5(v480, v481, v482)
                let v483 : US5 = US5_0(v479)
                let v484 : US22 = US22_1
                struct (-2, v483, v484)
            | US26_0(v452) -> (* Ok *)
                let v453 : string = "$0.status"
                let v454 : std_process_ExitStatus = Fable.Core.RustInterop.emitRustExpr v452 v453 
                let v455 : string = "$0.code()"
                let v456 : int32 option = Fable.Core.RustInterop.emitRustExpr v454 v455 
                let v457 : US27 option = None
                let _v457 = ref v457 
                match v456 with
                | Some x -> (
                (fun () ->
                (fun () ->
                let v458 : int32 = x
                let v459 : US27 = US27_0(v458)
                v459 
                )
                |> fun x -> x () |> Some
                ) () ) | None -> None
                |> fun x -> _v457.Value <- x
                let v460 : US27 option = _v457.Value 
                let v461 : US27 = US27_1
                let v462 : US27 = v460 |> Option.defaultValue v461 
                match v462 with
                | US27_1 -> (* None *)
                    let v466 : string = "&*$0"
                    let v467 : string = "runtime.execute_with_options / exit_code=None"
                    let v468 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v467 v466 
                    let v469 : string = "String::from($0)"
                    let v470 : std_string_String = Fable.Core.RustInterop.emitRustExpr v468 v469 
                    let v471 : US5 = US5_0(v470)
                    let v472 : US22 = US22_0(v200)
                    struct (-1, v471, v472)
                | US27_0(v463) -> (* Some *)
                    let v464 : US5 = US5_1
                    let v465 : US22 = US22_0(v200)
                    struct (v463, v464, v465)
    let v507 : std_sync_Arc<std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>> option =
        match v502 with
        | US22_1 -> (* None *)
            let v505 : std_sync_Arc<std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>> option = None
            v505
        | US22_0(v503) -> (* Some *)
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
    let v4 : string = $"env: {v0} / exit_code: {v3} / run_result: {v2} / new_code_path: {v1}"
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
    let v5 : string = $"ex: {v3} / run_result: {v1} / new_code_path: {v0} / external_command: {v2} / {v4 ()}"
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
    let v4 : string = $"exit_code: {v2} / run_result: {v1} / new_code_path: {v0} / external_command: {v3}"
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
            let v12 : string = method22()
            let v13 : string = method14(v12, v2)
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
    let v1 : string = method22()
    let v2 : string = method14(v1, v0)
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
and closure61 () () : US30 =
    US30_0
and closure62 () (v0 : std_string_String) : US30 =
    US30_1(v0)
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
    let v4 : bool = method18(v3)
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
    let v8 : (unit -> US30) = closure61()
    let v9 : (std_string_String -> US30) = closure62()
    let v10 : US30 = match v7 with Ok () -> v8 () | Error x -> v9 x
    match v10 with
    | US30_1(v14) -> (* Error *)
        let v15 : US0 = US0_4
        let v16 : (unit -> string) = closure63()
        let v17 : (unit -> string) = closure64(v2, v14)
        method5(v15, v16, v17)
    | US30_0 -> (* Ok *)
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
    let v18 : US31 option = None
    let _v18 = ref v18 
    match v17 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v19 : chrono_DateTime<chrono_Utc> = x
    let v20 : US31 = US31_0(v19)
    v20 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v18.Value <- x
    let v21 : US31 option = _v18.Value 
    let v22 : US31 = US31_1
    let v23 : US31 = v21 |> Option.defaultValue v22 
    let v42 : US3 =
        match v23 with
        | US31_1 -> (* None *)
            US3_1
        | US31_0(v24) -> (* Some *)
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
    let v116 : US31 option = None
    let _v116 = ref v116 
    match v115 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v117 : chrono_DateTime<chrono_Utc> = x
    let v118 : US31 = US31_0(v117)
    v118 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v116.Value <- x
    let v119 : US31 option = _v116.Value 
    let v120 : US31 = US31_1
    let v121 : US31 = v119 |> Option.defaultValue v120 
    let v140 : US3 =
        match v121 with
        | US31_1 -> (* None *)
            US3_1
        | US31_0(v122) -> (* Some *)
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
    let v2 : bool = method18(v0)
    let v3 : bool = v2 = false
    if v3 then
        let v4 : System.IDisposable = method82(v0)
        ()
    let v5 : string = method23(v1)
    let v6 : bool = method18(v5)
    let v7 : bool = v6 = false
    if v7 then
        let v8 : System.IDisposable = method82(v5)
        ()
    let v9 : bool = method18(v1)
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
    let v16 : bool = method18(v1)
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
    let v47 : US32 =
        if v44 then
            US32_0(v42, v43)
        else
            US32_1(v42, v43)
    let struct (v55 : bool, v56 : int32, v57 : string) =
        match v47 with
        | US32_1(v50, v51) -> (* Error *)
            struct (true, v50, v51)
        | US32_0(v48, v49) -> (* Ok *)
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
    let v152 : US32 =
        if v22 then
            let v23 : bool = v18 = 0
            if v23 then
                US32_0(v18, v19)
            else
                US32_1(v18, v19)
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
            let v80 : US33 option = None
            let _v80 = ref v80 
            match v79 with
            | Some x -> (
            (fun () ->
            (fun () ->
            let v81 : std_collections_HashMap<string, string> = x
            let v82 : US33 = US33_0(v81)
            v82 
            )
            |> fun x -> x () |> Some
            ) () ) | None -> None
            |> fun x -> _v80.Value <- x
            let v83 : US33 option = _v80.Value 
            let v84 : US33 = US33_1
            let v85 : US33 = v83 |> Option.defaultValue v84 
            let v99 : US34 =
                match v85 with
                | US33_1 -> (* None *)
                    US34_1
                | US33_0(v86) -> (* Some *)
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
                    US34_0(v95)
            let v106 : US3 =
                match v99 with
                | US34_0(v100) -> (* Some *)
                    match v100 with
                    | US3_0(v101) -> (* Some *)
                        US3_0(v101)
                    | _ ->
                        US3_1
                | _ ->
                    US3_1
            match v106 with
            | US3_1 -> (* None *)
                US32_1(v18, v19)
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
                    US32_0(v18, v19)
                else
                    US32_1(v18, v19)
    let struct (v160 : bool, v161 : int32, v162 : string) =
        match v152 with
        | US32_1(v155, v156) -> (* Error *)
            struct (true, v155, v156)
        | US32_0(v153, v154) -> (* Ok *)
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
    let v5 : string = $"ex: {v3} / cargo_run_result: {v1} / new_code_path: {v0} / external_command: {v2} / {v4 ()}"
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
    let v4 : string = $"exit_code: {v2} / cargo_run_result: {v1} / new_code_path: {v0} / external_command: {v3}"
    v4
and method108 (v0 : async_walkdir_DirEntry) : async_walkdir_DirEntry =
    v0
and closure90 () (v0 : std_fs_FileType) : US36 =
    US36_0(v0)
and closure91 () (v0 : std_string_String) : US36 =
    US36_1(v0)
and method109 (v0 : std_fs_FileType) : std_fs_FileType =
    v0
and method110 (v0 : US35) : US35 =
    v0
and method107 (v0 : async_walkdir_DirEntry) : std_pin_Pin<Box<LifetimeJoin<Dyn<std_future_Future<US35>>, Send<Dyn<std_future_Future<US35>>>>>> =
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
    let v10 : (std_fs_FileType -> US36) = closure90()
    let v11 : (std_string_String -> US36) = closure91()
    let v12 : US36 = match v9 with Ok x -> v10 x | Error x -> v11 x
    let v22 : US35 =
        match v12 with
        | US36_0(v13) -> (* Ok *)
            let v14 : std_fs_FileType = method109(v13)
            let v15 : string = "std::fs::FileType::is_dir(&v14)"
            let v16 : bool = Fable.Core.RustInterop.emitRustExpr () v15 
            let v17 : bool = v16 = false
            if v17 then
                US35_0
            else
                US35_2
        | _ ->
            US35_2
    let v23 : US35 = method110(v22)
    let v24 : string = ""
    let v25 : string = "}"
    let v26 : string = v24 + v25 
    let v27 : string = v26 + v25 
    let v28 : string = "{"
    let v29 : string = v24 + v28 
    let v30 : string = "v23 " + v27 + "); " + v29 + " //"
    Fable.Core.RustInterop.emitRustExpr () v30 
    let v31 : string = "__result"
    let v32 : std_pin_Pin<Box<LifetimeJoin<Dyn<std_future_Future<US35>>, Send<Dyn<std_future_Future<US35>>>>>> = Fable.Core.RustInterop.emitRustExpr () v31 
    v32
and method111 (v0 : async_walkdir_Filtering) : async_walkdir_Filtering =
    v0
and method106 (v0 : async_walkdir_DirEntry) : std_pin_Pin<Box<LifetimeJoin<Dyn<std_future_Future<async_walkdir_Filtering>>, Send<Dyn<std_future_Future<async_walkdir_Filtering>>>>>> =
    let v1 : string = "let __result = Box::pin(async { //"
    Fable.Core.RustInterop.emitRustExpr () v1 
    let v2 : std_pin_Pin<Box<LifetimeJoin<Dyn<std_future_Future<US35>>, Send<Dyn<std_future_Future<US35>>>>>> = method107(v0)
    let v3 : string = "v2.await"
    let v4 : US35 = Fable.Core.RustInterop.emitRustExpr () v3 
    let v13 : async_walkdir_Filtering =
        match v4 with
        | US35_2 -> (* Continue *)
            let v9 : string = "async_walkdir::Filtering::Continue"
            let v10 : async_walkdir_Filtering = Fable.Core.RustInterop.emitRustExpr () v9 
            v10
        | US35_0 -> (* Ignore *)
            let v5 : string = "async_walkdir::Filtering::Ignore"
            let v6 : async_walkdir_Filtering = Fable.Core.RustInterop.emitRustExpr () v5 
            v6
        | US35_1 -> (* IgnoreDir *)
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
and closure93 () (v0 : async_walkdir_DirEntry) : US37 =
    US37_0(v0)
and closure94 () (v0 : std_string_String) : US37 =
    US37_1(v0)
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
    let v4 : (async_walkdir_DirEntry -> US37) = closure93()
    let v5 : (std_string_String -> US37) = closure94()
    let v6 : US37 = match v3 with Ok x -> v4 x | Error x -> v5 x
    let v117 : US38 =
        match v6 with
        | US37_1(v111) -> (* Error *)
            let v112 : US0 = US0_4
            let v113 : (unit -> string) = closure95()
            let v114 : (unit -> string) = closure96(v111)
            method5(v112, v113, v114)
            US38_1
        | US37_0(v7) -> (* Ok *)
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
            let v79 : US33 option = None
            let _v79 = ref v79 
            match v78 with
            | Some x -> (
            (fun () ->
            (fun () ->
            let v80 : std_collections_HashMap<string, string> = x
            let v81 : US33 = US33_0(v80)
            v81 
            )
            |> fun x -> x () |> Some
            ) () ) | None -> None
            |> fun x -> _v79.Value <- x
            let v82 : US33 option = _v79.Value 
            let v83 : US33 = US33_1
            let v84 : US33 = v82 |> Option.defaultValue v83 
            let v98 : US34 =
                match v84 with
                | US33_1 -> (* None *)
                    US34_1
                | US33_0(v85) -> (* Some *)
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
                    US34_0(v94)
            let v105 : US3 =
                match v98 with
                | US34_0(v99) -> (* Some *)
                    match v99 with
                    | US3_0(v100) -> (* Some *)
                        US3_0(v100)
                    | _ ->
                        US3_1
                | _ ->
                    US3_1
            match v105 with
            | US3_1 -> (* None *)
                US38_1
            | US3_0(v107) -> (* Some *)
                US38_0(v24, v107)
    match v117 with
    | US38_1 -> (* None *)
        let v121 : struct (string * string) option = None
        v121
    | US38_0(v118, v119) -> (* Some *)
        let v120 : struct (string * string) option = Some struct (v118, v119) 
        v120
and method112 () : (Result<async_walkdir_DirEntry, std_io_Error> -> struct (string * string) option) =
    closure92()
and closure97 () struct (v0 : string, v1 : string) : struct (string * string) =
    struct (v0, v1)
and closure98 () () : string =
    let v0 : string = "spiral_builder.process_typescript"
    v0
and closure99 (v0 : US38) () : string =
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
    let v4 : string = $"exit_code: {v2} / run_result: {v1} / new_code_path: {v0} / external_command: {v3}"
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
    let v5 : string = $"ex: {v3} / run_result: {v1} / new_code_path: {v0} / external_command: {v2} / {v4 ()}"
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
    let v4 : string = $"exit_code: {v2} / run_result: {v1} / new_code_path: {v0} / external_command: {v3}"
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
    let v2341 : (struct (string * string) []) =
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
                let v128 : string = "polyglot"
                let v129 : string = ".paket"
                let v130 : string = method14(v128, v129)
                let v131 : US12 = method17(v130, v127)
                let v140 : US3 =
                    match v131 with
                    | US12_1(v134) -> (* Error *)
                        let v135 : US0 = US0_3
                        let v136 : (unit -> string) = closure10()
                        let v137 : (unit -> string) = closure11(v134)
                        method5(v135, v136, v137)
                        US3_1
                    | US12_0(v132) -> (* Ok *)
                        US3_0(v132)
                let v156 : US3 =
                    match v140 with
                    | US3_1 -> (* None *)
                        let v143 : string = method22()
                        let v144 : string = method14(v128, v129)
                        let v145 : US12 = method17(v144, v143)
                        match v145 with
                        | US12_1(v148) -> (* Error *)
                            let v149 : US0 = US0_3
                            let v150 : (unit -> string) = closure10()
                            let v151 : (unit -> string) = closure11(v148)
                            method5(v149, v150, v151)
                            US3_1
                        | US12_0(v146) -> (* Ok *)
                            US3_0(v146)
                    | US3_0(v141) -> (* Some *)
                        US3_0(v141)
                let v160 : string =
                    match v156 with
                    | US3_1 -> (* None *)
                        failwith<string> "Option does not have a value."
                    | US3_0(v157) -> (* Some *)
                        v157
                let v161 : string = method14(v160, v128)
                let v162 : string = method22()
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
                        method14(v185, v186)
                    | US8_1 -> (* Poetry *)
                        let v188 : string = "pyproject.toml"
                        method14(v185, v188)
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
                let struct (v346 : US3, v347 : US3, v348 : US3) =
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
                        let v320 : bool =
                            if v317 then
                                true
                            else
                                let v318 : string = "cupy_backends.cuda.api.runtime.CUDARuntimeError: cudaErrorInsufficientDriver"
                                let v319 : bool = v300.Contains v318 
                                v319
                        if v320 then
                            let v321 : (unit -> string) = closure44(v300)
                            let v322 : (string -> US3) = closure45()
                            let v323 : (exn -> US3) = closure46(v35, v300, v316)
                            let v324 : US3 = try v321 () |> v322 with ex -> v323 ex 
                            let v329 : string option =
                                match v324 with
                                | US3_1 -> (* None *)
                                    let v327 : string option = None
                                    v327
                                | US3_0(v325) -> (* Some *)
                                    let v326 : string option = Some v325 
                                    v326
                            let v330 : string = "$0.unwrap()"
                            let v331 : string = Fable.Core.RustInterop.emitRustExpr v329 v330 
                            let v332 : US3 = US3_0(v126)
                            let v333 : string = "py"
                            let v334 : US3 = US3_0(v333)
                            let v335 : US3 = US3_0(v331)
                            struct (v332, v334, v335)
                        else
                            let v336 : US0 = US0_4
                            let v337 : (unit -> string) = closure49()
                            let v338 : (unit -> string) = closure50(v35, v300, v299, v316)
                            method5(v336, v337, v338)
                            let v339 : US3 = US3_1
                            let v340 : string = "py"
                            let v341 : US3 = US3_0(v340)
                            let v342 : US3 = US3_1
                            struct (v339, v341, v342)
                let v352 : string =
                    match v347 with
                    | US3_1 -> (* None *)
                        let v350 : string = ""
                        v350
                    | US3_0(v349) -> (* Some *)
                        v349
                let v353 : string = "extension"
                let v357 : string =
                    match v346 with
                    | US3_1 -> (* None *)
                        let v355 : string = ""
                        v355
                    | US3_0(v354) -> (* Some *)
                        v354
                let v358 : string = "code"
                let v362 : string =
                    match v348 with
                    | US3_1 -> (* None *)
                        let v360 : string = ""
                        v360
                    | US3_0(v359) -> (* Some *)
                        v359
                let v363 : string = "output"
                let v364 : (struct (string * string) []) = [|struct (v353, v352); struct (v358, v357); struct (v363, v362)|]
                let v365 : string = "$0.to_vec()"
                let v366 : Vec<struct (string * string)> = Fable.Core.RustInterop.emitRustExpr v364 v365 
                let v367 : string = "$0.into_iter().map(|x| $1(x.clone())).collect::<Vec<_>>()"
                let v368 : (struct (string * string) -> (std_string_String * std_string_String)) = closure51()
                let v369 : Vec<(std_string_String * std_string_String)> = Fable.Core.RustInterop.emitRustExpr struct (v366, v368) v367 
                let v370 : string = "std::collections::BTreeMap::from_iter(v369.iter().map(|x| x.as_ref()).map(|&(ref k, ref v)| (k.clone(), v.clone())))"
                let v371 : std_collections_BTreeMap<std_string_String, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v370 
                let v372 : string = "serde_json::to_string(&v371)"
                let v373 : Result<std_string_String, serde_json_Error> = Fable.Core.RustInterop.emitRustExpr () v372 
                let v374 : string = "$0.unwrap()"
                let v375 : std_string_String = Fable.Core.RustInterop.emitRustExpr v373 v374 
                let v376 : string = "fable_library_rust::String_::fromString($0)"
                let v377 : string = Fable.Core.RustInterop.emitRustExpr v375 v376 
                let v378 : string = "command_result"
                [|struct (v378, v377)|]
            else
                let v380 : string = "fable_library_rust::String_::fromString($0)"
                let v381 : string = Fable.Core.RustInterop.emitRustExpr v13 v380 
                let v383 : bool = v381 = "fable"
                if v383 then
                    let v384 : string = method63()
                    let v385 : string = "&*$0"
                    let v386 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v384 v385 
                    let v387 : string = "clap::ArgMatches::get_one(&$0, v386).cloned()"
                    let v388 : std_string_String option = Fable.Core.RustInterop.emitRustExpr v14 v387 
                    let v389 : US5 option = None
                    let _v389 = ref v389 
                    match v388 with
                    | Some x -> (
                    (fun () ->
                    (fun () ->
                    let v390 : std_string_String = x
                    let v391 : US5 = US5_0(v390)
                    v391 
                    )
                    |> fun x -> x () |> Some
                    ) () ) | None -> None
                    |> fun x -> _v389.Value <- x
                    let v392 : US5 option = _v389.Value 
                    let v393 : US5 = US5_1
                    let v394 : US5 = v392 |> Option.defaultValue v393 
                    let v398 : std_string_String =
                        match v394 with
                        | US5_1 -> (* None *)
                            failwith<std_string_String> "Option does not have a value."
                        | US5_0(v395) -> (* Some *)
                            v395
                    let v399 : string = "fable_library_rust::String_::fromString($0)"
                    let v400 : string = Fable.Core.RustInterop.emitRustExpr v398 v399 
                    let v401 : string = method64()
                    let v402 : string = "&*$0"
                    let v403 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v401 v402 
                    let v404 : string = "clap::ArgMatches::get_one(&$0, v403).cloned()"
                    let v405 : std_string_String option = Fable.Core.RustInterop.emitRustExpr v14 v404 
                    let v406 : US5 option = None
                    let _v406 = ref v406 
                    match v405 with
                    | Some x -> (
                    (fun () ->
                    (fun () ->
                    let v407 : std_string_String = x
                    let v408 : US5 = US5_0(v407)
                    v408 
                    )
                    |> fun x -> x () |> Some
                    ) () ) | None -> None
                    |> fun x -> _v406.Value <- x
                    let v409 : US5 option = _v406.Value 
                    let v410 : US5 = US5_1
                    let v411 : US5 = v409 |> Option.defaultValue v410 
                    let v418 : US3 =
                        match v411 with
                        | US5_1 -> (* None *)
                            US3_1
                        | US5_0(v412) -> (* Some *)
                            let v413 : string = "fable_library_rust::String_::fromString($0)"
                            let v414 : string = Fable.Core.RustInterop.emitRustExpr v412 v413 
                            US3_0(v414)
                    let v452 : string =
                        match v418 with
                        | US3_1 -> (* None *)
                            let v450 : string = "{}"
                            v450
                        | US3_0(v419) -> (* Some *)
                            let v420 : clap_Command = method0()
                            let v421 : string = $"_ {v419} --fs-path \"{v400}\""
                            let v422 : US15 = method35(v421)
                            let v428 : (string []) =
                                match v422 with
                                | US15_1(v424) -> (* Error *)
                                    let v425 : string = $"resultm.get / Result value was Error: {v424}"
                                    failwith<(string [])> v425
                                | US15_0(v423) -> (* Ok *)
                                    v423
                            let v429 : string = "$0.to_vec()"
                            let v430 : Vec<string> = Fable.Core.RustInterop.emitRustExpr v428 v429 
                            let v431 : string = "true; let _result : Vec<_> = v430.into_iter().map(|x| { //"
                            let v432 : bool = Fable.Core.RustInterop.emitRustExpr () v431 
                            let v433 : string = "x"
                            let v434 : string = Fable.Core.RustInterop.emitRustExpr () v433 
                            let v435 : string = "&*$0"
                            let v436 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v434 v435 
                            let v437 : string = "String::from($0)"
                            let v438 : std_string_String = Fable.Core.RustInterop.emitRustExpr v436 v437 
                            let v439 : string = "true; $0 }).collect::<Vec<_>>()"
                            let v440 : bool = Fable.Core.RustInterop.emitRustExpr v438 v439 
                            let v441 : string = "_result"
                            let v442 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v441 
                            let v443 : string = "clap::Command::get_matches_from($0, v442)"
                            let v444 : clap_ArgMatches = Fable.Core.RustInterop.emitRustExpr v420 v443 
                            let v445 : std_pin_Pin<Box<Dyn<std_future_Future<Result<string, string>>>>> = method10(v0, v444)
                            let v446 : string = "v445.await"
                            let v447 : Result<string, string> = Fable.Core.RustInterop.emitRustExpr () v446 
                            let v448 : string = "$0.unwrap()"
                            let v449 : string = Fable.Core.RustInterop.emitRustExpr v447 v448 
                            v449
                    let v453 : string = "command_result"
                    [|struct (v453, v452)|]
                else
                    let v455 : string = "fable_library_rust::String_::fromString($0)"
                    let v456 : string = Fable.Core.RustInterop.emitRustExpr v13 v455 
                    let v458 : bool = v456 = "dib"
                    if v458 then
                        let v459 : string = method65()
                        let v460 : string = "&*$0"
                        let v461 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v459 v460 
                        let v462 : string = "clap::ArgMatches::get_one(&$0, v461).cloned()"
                        let v463 : std_string_String option = Fable.Core.RustInterop.emitRustExpr v14 v462 
                        let v464 : (std_string_String -> string) = closure52()
                        let v465 : string option = v463 |> Option.map v464 
                        let v466 : string = "$0.unwrap()"
                        let v467 : string = Fable.Core.RustInterop.emitRustExpr v465 v466 
                        let v468 : string = method77()
                        let v469 : string = "&*$0"
                        let v470 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v468 v469 
                        let v471 : string = "clap::ArgMatches::get_one(&$0, v470).cloned()"
                        let v472 : uint8 option = Fable.Core.RustInterop.emitRustExpr v14 v471 
                        let v473 : uint8 = v472 |> Option.defaultValue 1uy 
                        let v474 : string = method78()
                        let v475 : string = "&*$0"
                        let v476 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v474 v475 
                        let v477 : string = "clap::ArgMatches::get_one(&$0, v476).cloned()"
                        let v478 : string option = Fable.Core.RustInterop.emitRustExpr v14 v477 
                        let v479 : uint8 = 1uy
                        let struct (v480 : int32, v481 : string) = method79(v478, v473, v467, v479)
                        let v482 : bool = v480 <> 0 
                        let struct (v580 : int32, v581 : string) =
                            if v482 then
                                struct (v480, v481)
                            else
                                let v483 : System.Threading.CancellationToken option = None
                                let v484 : (struct (string * string) []) = [||]
                                let v485 : (struct (bool * string * int32) -> Async<unit>) option = None
                                let v486 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = None
                                let v487 : string option = None
                                let v488 : string = $"jupyter nbconvert \"{v467}.ipynb\" --to html --HTMLExporter.theme=dark"
                                let v489 : bool = true
                                let struct (v490 : int32, v491 : string) = method28(v483, v488, v484, v485, v486, v489, v487)
                                let v492 : US0 = US0_1
                                let v493 : (unit -> string) = closure55()
                                let v494 : (unit -> string) = closure56(v491, v490)
                                method5(v492, v493, v494)
                                let v495 : bool = v490 <> 0 
                                if v495 then
                                    let v496 : string = $"repl_result: {v481}

jupyter_result: {v491}"
                                    struct (v490, v496)
                                else
                                    let v497 : string = "'"
                                    let v498 : string = "''"
                                    let v499 : string = v467.Replace (v497, v498)
                                    let v500 : System.Threading.CancellationToken option = None
                                    let v501 : (struct (string * string) []) = [||]
                                    let v502 : (struct (bool * string * int32) -> Async<unit>) option = None
                                    let v503 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = None
                                    let v504 : string option = None
                                    let v505 : string = $"pwsh -c \"$counter = 1; $path = '{v499}.html'; (Get-Content $path -Raw) -replace '(id=\\\"cell-id=)[a-fA-F0-9]{{8}}', {{ $_.Groups[1].Value + $counter++ }} | Set-Content $path\""
                                    let v506 : bool = true
                                    let struct (v507 : int32, v508 : string) = method28(v500, v505, v501, v502, v503, v506, v504)
                                    let v509 : US0 = US0_1
                                    let v510 : (unit -> string) = closure57()
                                    let v511 : (unit -> string) = closure58(v508, v507)
                                    method5(v509, v510, v511)
                                    let v512 : string = $"{v467}.html"
                                    let v513 : bool = true
                                    let mutable _v513 : string option = None 
                                    
#if FABLE_COMPILER || WASM || CONTRACT
                                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                    let v514 : bool = true
                                    let mutable _v514 : Vec<uint8> option = None 
                                    
#if FABLE_COMPILER || WASM || CONTRACT
                                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                    let v515 : string = "std::fs::read(&*$0).unwrap()"
                                    let v516 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v512 v515 
                                    v516 
                                    #endif
#if FABLE_COMPILER_RUST && WASM
                                    let v517 : Vec<uint8> = null |> unbox<Vec<uint8>>
                                    v517 
                                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                                    let v518 : Vec<uint8> = null |> unbox<Vec<uint8>>
                                    v518 
                                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                                    let v519 : Vec<uint8> = null |> unbox<Vec<uint8>>
                                    v519 
                                    #endif
#if FABLE_COMPILER_PYTHON
                                    let v520 : Vec<uint8> = null |> unbox<Vec<uint8>>
                                    v520 
                                    #endif
#else
                                    let v521 : (uint8 []) = v512 |> System.IO.File.ReadAllBytes
                                    let v522 : string = "$0.to_vec()"
                                    let v523 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v521 v522 
                                    v523 
                                    #endif
                                    |> fun x -> _v514 <- Some x
                                    let v524 : Vec<uint8> = match _v514 with Some x -> x | None -> failwith "base.run_target / _v514=None"
                                    let v525 : string = "std::string::String::from_utf8(v524)"
                                    let v526 : Result<std_string_String, std_string_FromUtf8Error> = Fable.Core.RustInterop.emitRustExpr () v525 
                                    let v527 : string = "$0.unwrap()"
                                    let v528 : std_string_String = Fable.Core.RustInterop.emitRustExpr v526 v527 
                                    let v529 : string = "fable_library_rust::String_::fromString($0)"
                                    let v530 : string = Fable.Core.RustInterop.emitRustExpr v528 v529 
                                    v530 
                                    #endif
#if FABLE_COMPILER_RUST && WASM
                                    let v531 : string = null |> unbox<string>
                                    v531 
                                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                                    let v532 : string = null |> unbox<string>
                                    v532 
                                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                                    let v533 : string = null |> unbox<string>
                                    v533 
                                    #endif
#if FABLE_COMPILER_PYTHON
                                    let v534 : string = null |> unbox<string>
                                    v534 
                                    #endif
#else
                                    let v535 : string = v512 |> System.IO.File.ReadAllText
                                    v535 
                                    #endif
                                    |> fun x -> _v513 <- Some x
                                    let v536 : string = match _v513 with Some x -> x | None -> failwith "base.run_target / _v513=None"
                                    let v537 : string = "\r\n"
                                    let v538 : string = "\n"
                                    let v539 : string = v536.Replace (v537, v538)
                                    let v540 : string = $"{v467}.html"
                                    let v541 : bool = true
                                    let mutable _v541 : unit option = None 
                                    
#if FABLE_COMPILER || WASM || CONTRACT
                                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                    let v542 : string = "std::fs::write(&*$0, &*$1).unwrap()"
                                    Fable.Core.RustInterop.emitRustExpr struct (v540, v539) v542 
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
                                    let v543 : string = method27(v539)
                                    System.IO.File.WriteAllText (v540, v543)
                                    () 
                                    #endif
                                    |> fun x -> _v541 <- Some x
                                    match _v541 with Some x -> x | None -> failwith "base.run_target / _v541=None"
                                    let v544 : string = $"{v467}.ipynb"
                                    let v545 : bool = true
                                    let mutable _v545 : string option = None 
                                    
#if FABLE_COMPILER || WASM || CONTRACT
                                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                    let v546 : bool = true
                                    let mutable _v546 : Vec<uint8> option = None 
                                    
#if FABLE_COMPILER || WASM || CONTRACT
                                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                    let v547 : string = "std::fs::read(&*$0).unwrap()"
                                    let v548 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v544 v547 
                                    v548 
                                    #endif
#if FABLE_COMPILER_RUST && WASM
                                    let v549 : Vec<uint8> = null |> unbox<Vec<uint8>>
                                    v549 
                                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                                    let v550 : Vec<uint8> = null |> unbox<Vec<uint8>>
                                    v550 
                                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                                    let v551 : Vec<uint8> = null |> unbox<Vec<uint8>>
                                    v551 
                                    #endif
#if FABLE_COMPILER_PYTHON
                                    let v552 : Vec<uint8> = null |> unbox<Vec<uint8>>
                                    v552 
                                    #endif
#else
                                    let v553 : (uint8 []) = v544 |> System.IO.File.ReadAllBytes
                                    let v554 : string = "$0.to_vec()"
                                    let v555 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v553 v554 
                                    v555 
                                    #endif
                                    |> fun x -> _v546 <- Some x
                                    let v556 : Vec<uint8> = match _v546 with Some x -> x | None -> failwith "base.run_target / _v546=None"
                                    let v557 : string = "std::string::String::from_utf8(v556)"
                                    let v558 : Result<std_string_String, std_string_FromUtf8Error> = Fable.Core.RustInterop.emitRustExpr () v557 
                                    let v559 : string = "$0.unwrap()"
                                    let v560 : std_string_String = Fable.Core.RustInterop.emitRustExpr v558 v559 
                                    let v561 : string = "fable_library_rust::String_::fromString($0)"
                                    let v562 : string = Fable.Core.RustInterop.emitRustExpr v560 v561 
                                    v562 
                                    #endif
#if FABLE_COMPILER_RUST && WASM
                                    let v563 : string = null |> unbox<string>
                                    v563 
                                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                                    let v564 : string = null |> unbox<string>
                                    v564 
                                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                                    let v565 : string = null |> unbox<string>
                                    v565 
                                    #endif
#if FABLE_COMPILER_PYTHON
                                    let v566 : string = null |> unbox<string>
                                    v566 
                                    #endif
#else
                                    let v567 : string = v544 |> System.IO.File.ReadAllText
                                    v567 
                                    #endif
                                    |> fun x -> _v545 <- Some x
                                    let v568 : string = match _v545 with Some x -> x | None -> failwith "base.run_target / _v545=None"
                                    let v569 : string = v568.Replace (v537, v538)
                                    let v570 : string = "\\r\\n"
                                    let v571 : string = "\\n"
                                    let v572 : string = v569.Replace (v570, v571)
                                    let v573 : string = $"{v467}.ipynb"
                                    let v574 : bool = true
                                    let mutable _v574 : unit option = None 
                                    
#if FABLE_COMPILER || WASM || CONTRACT
                                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                    let v575 : string = "std::fs::write(&*$0, &*$1).unwrap()"
                                    Fable.Core.RustInterop.emitRustExpr struct (v573, v572) v575 
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
                                    let v576 : string = method27(v572)
                                    System.IO.File.WriteAllText (v573, v576)
                                    () 
                                    #endif
                                    |> fun x -> _v574 <- Some x
                                    match _v574 with Some x -> x | None -> failwith "base.run_target / _v574=None"
                                    let v577 : string = $"repl_result: {v481}

jupyter_result: {v491}

pwsh_replace_html_result: {v508}"
                                    struct (v507, v577)
                        let v582 : US0 = US0_1
                        let v583 : (unit -> string) = closure59()
                        let v584 : (unit -> string) = closure60(v581, v580)
                        method5(v582, v583, v584)
                        let v585 : bool = v580 <> 0 
                        if v585 then
                            let v586 : (unit -> string) = closure6()
                            let v587 : string = $"spiral_builder.run / dib / exit_code: {v580} / result: {v581} / {v586 ()}"
                            failwith<unit> v587
                        let v588 : string = "stdio"
                        [|struct (v588, v581)|]
                    else
                        let v590 : string = "fable_library_rust::String_::fromString($0)"
                        let v591 : string = Fable.Core.RustInterop.emitRustExpr v13 v590 
                        let v593 : bool = v591 = "rust"
                        let struct (v2314 : US3, v2315 : US3, v2316 : US3) =
                            if v593 then
                                let v594 : string = method63()
                                let v595 : string = "&*$0"
                                let v596 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v594 v595 
                                let v597 : string = "clap::ArgMatches::get_one(&$0, v596).cloned()"
                                let v598 : std_string_String option = Fable.Core.RustInterop.emitRustExpr v14 v597 
                                let v599 : US5 option = None
                                let _v599 = ref v599 
                                match v598 with
                                | Some x -> (
                                (fun () ->
                                (fun () ->
                                let v600 : std_string_String = x
                                let v601 : US5 = US5_0(v600)
                                v601 
                                )
                                |> fun x -> x () |> Some
                                ) () ) | None -> None
                                |> fun x -> _v599.Value <- x
                                let v602 : US5 option = _v599.Value 
                                let v603 : US5 = US5_1
                                let v604 : US5 = v602 |> Option.defaultValue v603 
                                let v608 : std_string_String =
                                    match v604 with
                                    | US5_1 -> (* None *)
                                        failwith<std_string_String> "Option does not have a value."
                                    | US5_0(v605) -> (* Some *)
                                        v605
                                let v609 : string = "fable_library_rust::String_::fromString($0)"
                                let v610 : string = Fable.Core.RustInterop.emitRustExpr v608 v609 
                                let v611 : string = method13()
                                let v612 : string = "&*$0"
                                let v613 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v611 v612 
                                let v614 : string = "clap::ArgMatches::get_many(&$0, v613).map(|x| x.cloned().into_iter().collect())"
                                let v615 : Vec<std_string_String> option = Fable.Core.RustInterop.emitRustExpr v14 v614 
                                let v616 : US9 option = None
                                let _v616 = ref v616 
                                match v615 with
                                | Some x -> (
                                (fun () ->
                                (fun () ->
                                let v617 : Vec<std_string_String> = x
                                let v618 : US9 = US9_0(v617)
                                v618 
                                )
                                |> fun x -> x () |> Some
                                ) () ) | None -> None
                                |> fun x -> _v616.Value <- x
                                let v619 : US9 option = _v616.Value 
                                let v620 : US9 = US9_1
                                let v621 : US9 = v619 |> Option.defaultValue v620 
                                let v622 : (std_string_String []) = [||]
                                let v623 : string = "$0.to_vec()"
                                let v624 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr v622 v623 
                                let v627 : Vec<std_string_String> =
                                    match v621 with
                                    | US9_1 -> (* None *)
                                        v624
                                    | US9_0(v625) -> (* Some *)
                                        v625
                                let v629 : bool =
                                    match v0 with
                                    | US0_0 -> (* Verbose *)
                                        true
                                    | _ ->
                                        false
                                let v630 : bool = true
                                let mutable _v630 : string option = None 
                                
#if FABLE_COMPILER || WASM || CONTRACT
                                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                let v631 : bool = true
                                let mutable _v631 : Vec<uint8> option = None 
                                
#if FABLE_COMPILER || WASM || CONTRACT
                                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                let v632 : string = "std::fs::read(&*$0).unwrap()"
                                let v633 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v610 v632 
                                v633 
                                #endif
#if FABLE_COMPILER_RUST && WASM
                                let v634 : Vec<uint8> = null |> unbox<Vec<uint8>>
                                v634 
                                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                                let v635 : Vec<uint8> = null |> unbox<Vec<uint8>>
                                v635 
                                #endif
#if FABLE_COMPILER_TYPESCRIPT
                                let v636 : Vec<uint8> = null |> unbox<Vec<uint8>>
                                v636 
                                #endif
#if FABLE_COMPILER_PYTHON
                                let v637 : Vec<uint8> = null |> unbox<Vec<uint8>>
                                v637 
                                #endif
#else
                                let v638 : (uint8 []) = v610 |> System.IO.File.ReadAllBytes
                                let v639 : string = "$0.to_vec()"
                                let v640 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v638 v639 
                                v640 
                                #endif
                                |> fun x -> _v631 <- Some x
                                let v641 : Vec<uint8> = match _v631 with Some x -> x | None -> failwith "base.run_target / _v631=None"
                                let v642 : string = "std::string::String::from_utf8(v641)"
                                let v643 : Result<std_string_String, std_string_FromUtf8Error> = Fable.Core.RustInterop.emitRustExpr () v642 
                                let v644 : string = "$0.unwrap()"
                                let v645 : std_string_String = Fable.Core.RustInterop.emitRustExpr v643 v644 
                                let v646 : string = "fable_library_rust::String_::fromString($0)"
                                let v647 : string = Fable.Core.RustInterop.emitRustExpr v645 v646 
                                v647 
                                #endif
#if FABLE_COMPILER_RUST && WASM
                                let v648 : string = null |> unbox<string>
                                v648 
                                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                                let v649 : string = null |> unbox<string>
                                v649 
                                #endif
#if FABLE_COMPILER_TYPESCRIPT
                                let v650 : string = null |> unbox<string>
                                v650 
                                #endif
#if FABLE_COMPILER_PYTHON
                                let v651 : string = null |> unbox<string>
                                v651 
                                #endif
#else
                                let v652 : string = v610 |> System.IO.File.ReadAllText
                                v652 
                                #endif
                                |> fun x -> _v630 <- Some x
                                let v653 : string = match _v630 with Some x -> x | None -> failwith "base.run_target / _v630=None"
                                let v654 : string = "rs"
                                let v655 : string = $"%A{struct (v654, v653)}"
                                let v656 : string = method80(v655)
                                let v657 : string = __SOURCE_DIRECTORY__
                                let v658 : string = "polyglot"
                                let v659 : string = ".paket"
                                let v660 : string = method14(v658, v659)
                                let v661 : US12 = method17(v660, v657)
                                let v670 : US3 =
                                    match v661 with
                                    | US12_1(v664) -> (* Error *)
                                        let v665 : US0 = US0_3
                                        let v666 : (unit -> string) = closure10()
                                        let v667 : (unit -> string) = closure11(v664)
                                        method5(v665, v666, v667)
                                        US3_1
                                    | US12_0(v662) -> (* Ok *)
                                        US3_0(v662)
                                let v686 : US3 =
                                    match v670 with
                                    | US3_1 -> (* None *)
                                        let v673 : string = method22()
                                        let v674 : string = method14(v658, v659)
                                        let v675 : US12 = method17(v674, v673)
                                        match v675 with
                                        | US12_1(v678) -> (* Error *)
                                            let v679 : US0 = US0_3
                                            let v680 : (unit -> string) = closure10()
                                            let v681 : (unit -> string) = closure11(v678)
                                            method5(v679, v680, v681)
                                            US3_1
                                        | US12_0(v676) -> (* Ok *)
                                            US3_0(v676)
                                    | US3_0(v671) -> (* Some *)
                                        US3_0(v671)
                                let v690 : string =
                                    match v686 with
                                    | US3_1 -> (* None *)
                                        failwith<string> "Option does not have a value."
                                    | US3_0(v687) -> (* Some *)
                                        v687
                                let v691 : string = method14(v690, v658)
                                let v692 : string = "target/spiral_builder"
                                let v693 : string = method14(v691, v692)
                                let v694 : string = "spiral_builder"
                                let v695 : string = method14(v693, v694)
                                let v696 : string = "packages"
                                let v697 : string = method14(v695, v696)
                                let v698 : string = method14(v697, v656)
                                let v699 : System.IDisposable = method82(v698)
                                let v700 : string = $"{v694}.fs"
                                let v701 : string = method14(v698, v700)
                                let v702 : string = method70(v701)
                                method24(v702, v653)
                                let v703 : string list = []
                                let v704 : string seq = seq { for i = 0 to v703.Length - 1 do yield v703.[i] }
                                let v705 : (string -> (string seq -> string)) = String.concat
                                let v706 : string = "\\n        "
                                let v707 : (string seq -> string) = v705 v706
                                let v708 : string = v707 v704
                                let v709 : string = "Fable.Core"
                                let v710 : string = $"<PackageReference Include=\"{v709}\" Version=\"*\" />"
                                let v711 : string list = []
                                let v712 : string list = v710 :: v711 
                                let v713 : string seq = seq { for i = 0 to v712.Length - 1 do yield v712.[i] }
                                let v714 : (string -> (string seq -> string)) = String.concat
                                let v715 : (string seq -> string) = v714 v706
                                let v716 : string = v715 v713
                                let v717 : string = $"{v694}.fsproj"
                                let v718 : string = method14(v698, v717)
                                let v719 : string = method70(v718)
                                let v720 : string = $"<Project Sdk=\"Microsoft.NET.Sdk\">"
                                let v721 : string = $"<PropertyGroup>"
                                let v722 : string = "\n"
                                let v723 : string = v720 + v722 
                                let v724 : string = v723 + v721 
                                let v725 : string = $"    <TargetFramework>net9.0</TargetFramework>"
                                let v726 : string = v724 + v722 
                                let v727 : string = v726 + v725 
                                let v728 : string = $"    <LangVersion>preview</LangVersion>"
                                let v729 : string = v727 + v722 
                                let v730 : string = v729 + v728 
                                let v731 : string = $"    <RollForward>Major</RollForward>"
                                let v732 : string = v730 + v722 
                                let v733 : string = v732 + v731 
                                let v734 : string = $"    <TargetLatestRuntimePatch>true</TargetLatestRuntimePatch>"
                                let v735 : string = v733 + v722 
                                let v736 : string = v735 + v734 
                                let v737 : string = $"    <PublishAot>false</PublishAot>"
                                let v738 : string = v736 + v722 
                                let v739 : string = v738 + v737 
                                let v740 : string = $"    <PublishTrimmed>false</PublishTrimmed>"
                                let v741 : string = v739 + v722 
                                let v742 : string = v741 + v740 
                                let v743 : string = $"    <PublishSingleFile>true</PublishSingleFile>"
                                let v744 : string = v742 + v722 
                                let v745 : string = v744 + v743 
                                let v746 : string = $"    <SelfContained>true</SelfContained>"
                                let v747 : string = v745 + v722 
                                let v748 : string = v747 + v746 
                                let v749 : string = $"    <Version>0.0.1-alpha.1</Version>"
                                let v750 : string = v748 + v722 
                                let v751 : string = v750 + v749 
                                let v752 : string = $"    <OutputType>Exe</OutputType>"
                                let v753 : string = v751 + v722 
                                let v754 : string = v753 + v752 
                                let v755 : string = $"</PropertyGroup>"
                                let v756 : string = v754 + v722 
                                let v757 : string = v756 + v755 
                                let v758 : string = $"<PropertyGroup Condition=\"$([MSBuild]::IsOSPlatform('FreeBSD'))\">"
                                let v759 : string = v757 + v722 
                                let v760 : string = v759 + v758 
                                let v761 : string = $"    <DefineConstants>_FREEBSD</DefineConstants>"
                                let v762 : string = v760 + v722 
                                let v763 : string = v762 + v761 
                                let v764 : string = $"</PropertyGroup>"
                                let v765 : string = v763 + v722 
                                let v766 : string = v765 + v764 
                                let v767 : string = $"<PropertyGroup Condition=\"$([MSBuild]::IsOSPlatform('Linux'))\">"
                                let v768 : string = v766 + v722 
                                let v769 : string = v768 + v767 
                                let v770 : string = $"    <DefineConstants>_LINUX</DefineConstants>"
                                let v771 : string = v769 + v722 
                                let v772 : string = v771 + v770 
                                let v773 : string = $"</PropertyGroup>"
                                let v774 : string = v772 + v722 
                                let v775 : string = v774 + v773 
                                let v776 : string = $"<PropertyGroup Condition=\"$([MSBuild]::IsOSPlatform('OSX'))\">"
                                let v777 : string = v775 + v722 
                                let v778 : string = v777 + v776 
                                let v779 : string = $"    <DefineConstants>_OSX</DefineConstants>"
                                let v780 : string = v778 + v722 
                                let v781 : string = v780 + v779 
                                let v782 : string = $"</PropertyGroup>"
                                let v783 : string = v781 + v722 
                                let v784 : string = v783 + v782 
                                let v785 : string = $"<PropertyGroup Condition=\"$([MSBuild]::IsOSPlatform('Windows'))\">"
                                let v786 : string = v784 + v722 
                                let v787 : string = v786 + v785 
                                let v788 : string = $"    <DefineConstants>_WINDOWS</DefineConstants>"
                                let v789 : string = v787 + v722 
                                let v790 : string = v789 + v788 
                                let v791 : string = $"</PropertyGroup>"
                                let v792 : string = v790 + v722 
                                let v793 : string = v792 + v791 
                                let v794 : string = $"<ItemGroup>"
                                let v795 : string = v793 + v722 
                                let v796 : string = v795 + v794 
                                let v797 : string = $"    {v708}"
                                let v798 : string = v796 + v722 
                                let v799 : string = v798 + v797 
                                let v800 : string = $"    <Compile Include=\"{v702}\" />"
                                let v801 : string = v799 + v722 
                                let v802 : string = v801 + v800 
                                let v803 : string = $"</ItemGroup>"
                                let v804 : string = v802 + v722 
                                let v805 : string = v804 + v803 
                                let v806 : string = $"<ItemGroup>"
                                let v807 : string = v805 + v722 
                                let v808 : string = v807 + v806 
                                let v809 : string = $"    {v716}"
                                let v810 : string = v808 + v722 
                                let v811 : string = v810 + v809 
                                let v812 : string = $"</ItemGroup>"
                                let v813 : string = v811 + v722 
                                let v814 : string = v813 + v812 
                                let v815 : string = $"</Project>"
                                let v816 : string = v814 + v722 
                                let v817 : string = v816 + v815 
                                method24(v719, v817)
                                let v818 : string = method23(v719)
                                let v819 : string = "Cargo.toml"
                                let v820 : string = method14(v818, v819)
                                let v821 : string = "../.."
                                let v822 : string = method14(v818, v821)
                                let v823 : string = method14(v822, v819)
                                let v824 : bool = method26(v820)
                                let v825 : bool = v824 = false
                                if v825 then
                                    let v826 : System.DateTime = System.DateTime.Now
                                    let v827 : (unit -> System.Guid) = System.Guid.NewGuid
                                    let v828 : System.Guid = v827 ()
                                    let v829 : System.Guid = method92(v828, v826)
                                    let v830 : (System.Guid -> string) = _.ToString()
                                    let v831 : string = v830 v829
                                    let v832 : string = $"[package]"
                                    let v833 : string = $"name = \"spiral_builder_{v831}\""
                                    let v834 : string = v832 + v722 
                                    let v835 : string = v834 + v833 
                                    let v836 : string = $"version = \"0.0.1\""
                                    let v837 : string = v835 + v722 
                                    let v838 : string = v837 + v836 
                                    let v839 : string = $"edition = \"2021\""
                                    let v840 : string = v838 + v722 
                                    let v841 : string = v840 + v839 
                                    let v842 : string = $""
                                    let v843 : string = v841 + v722 
                                    let v844 : string = v843 + v842 
                                    let v845 : string = $"[[bin]]"
                                    let v846 : string = v844 + v722 
                                    let v847 : string = v846 + v845 
                                    let v848 : string = $"name = \"spiral_builder_{v831}\""
                                    let v849 : string = v847 + v722 
                                    let v850 : string = v849 + v848 
                                    let v851 : string = $"path = \"spiral_builder.{v654}\""
                                    let v852 : string = v850 + v722 
                                    let v853 : string = v852 + v851 
                                    let v854 : bool = true
                                    let mutable _v854 : unit option = None 
                                    
#if FABLE_COMPILER || WASM || CONTRACT
                                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                    let v855 : string = "std::fs::write(&*$0, &*$1).unwrap()"
                                    Fable.Core.RustInterop.emitRustExpr struct (v820, v853) v855 
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
                                    let v856 : string = method27(v853)
                                    System.IO.File.WriteAllText (v820, v856)
                                    () 
                                    #endif
                                    |> fun x -> _v854 <- Some x
                                    match _v854 with Some x -> x | None -> failwith "base.run_target / _v854=None"
                                    ()
                                let v857 : bool = method26(v823)
                                let v858 : bool = v857 = false
                                if v858 then
                                    let v859 : System.DateTime = System.DateTime.Now
                                    let v860 : (unit -> System.Guid) = System.Guid.NewGuid
                                    let v861 : System.Guid = v860 ()
                                    let v862 : System.Guid = method92(v861, v859)
                                    let v863 : (System.Guid -> string) = _.ToString()
                                    let v864 : string = v863 v862
                                    let v865 : string = $"[package]"
                                    let v866 : string = $"name = \"spiral_builder_{v864}\""
                                    let v867 : string = v865 + v722 
                                    let v868 : string = v867 + v866 
                                    let v869 : string = $"version = \"0.0.1\""
                                    let v870 : string = v868 + v722 
                                    let v871 : string = v870 + v869 
                                    let v872 : string = $"edition = \"2021\""
                                    let v873 : string = v871 + v722 
                                    let v874 : string = v873 + v872 
                                    let v875 : string = $""
                                    let v876 : string = v874 + v722 
                                    let v877 : string = v876 + v875 
                                    let v878 : string = $"[[bin]]"
                                    let v879 : string = v877 + v722 
                                    let v880 : string = v879 + v878 
                                    let v881 : string = $"name = \"spiral_builder_{v864}\""
                                    let v882 : string = v880 + v722 
                                    let v883 : string = v882 + v881 
                                    let v884 : string = $"path = \"spiral_builder.{v654}\""
                                    let v885 : string = v883 + v722 
                                    let v886 : string = v885 + v884 
                                    let v887 : bool = true
                                    let mutable _v887 : unit option = None 
                                    
#if FABLE_COMPILER || WASM || CONTRACT
                                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                    let v888 : string = "std::fs::write(&*$0, &*$1).unwrap()"
                                    Fable.Core.RustInterop.emitRustExpr struct (v823, v886) v888 
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
                                    let v889 : string = method27(v886)
                                    System.IO.File.WriteAllText (v823, v889)
                                    () 
                                    #endif
                                    |> fun x -> _v887 <- Some x
                                    match _v887 with Some x -> x | None -> failwith "base.run_target / _v887=None"
                                    ()
                                let v890 : string = __SOURCE_DIRECTORY__
                                let v891 : string = method14(v658, v659)
                                let v892 : US12 = method17(v891, v890)
                                let v901 : US3 =
                                    match v892 with
                                    | US12_1(v895) -> (* Error *)
                                        let v896 : US0 = US0_3
                                        let v897 : (unit -> string) = closure10()
                                        let v898 : (unit -> string) = closure11(v895)
                                        method5(v896, v897, v898)
                                        US3_1
                                    | US12_0(v893) -> (* Ok *)
                                        US3_0(v893)
                                let v917 : US3 =
                                    match v901 with
                                    | US3_1 -> (* None *)
                                        let v904 : string = method22()
                                        let v905 : string = method14(v658, v659)
                                        let v906 : US12 = method17(v905, v904)
                                        match v906 with
                                        | US12_1(v909) -> (* Error *)
                                            let v910 : US0 = US0_3
                                            let v911 : (unit -> string) = closure10()
                                            let v912 : (unit -> string) = closure11(v909)
                                            method5(v910, v911, v912)
                                            US3_1
                                        | US12_0(v907) -> (* Ok *)
                                            US3_0(v907)
                                    | US3_0(v902) -> (* Some *)
                                        US3_0(v902)
                                let v921 : string =
                                    match v917 with
                                    | US3_1 -> (* None *)
                                        failwith<string> "Option does not have a value."
                                    | US3_0(v918) -> (* Some *)
                                        v918
                                let v922 : string = method14(v921, v658)
                                let v923 : string = method22()
                                let v924 : (unit -> string) = v923.ToLower
                                let v925 : string = v924 ()
                                let v926 : (unit -> string) = v922.ToLower
                                let v927 : string = v926 ()
                                let v928 : bool = v925.StartsWith v927 
                                let v931 : US12 =
                                    if v928 then
                                        US12_1(v927)
                                    else
                                        US12_0(v927)
                                let v937 : Result<string, string> =
                                    match v931 with
                                    | US12_1(v934) -> (* Error *)
                                        let v935 : Result<string, string> = Error v934 
                                        v935
                                    | US12_0(v932) -> (* Ok *)
                                        let v933 : Result<string, string> = Ok v932 
                                        v933
                                let v938 : string = "true; let _result = $0.unwrap_or_else(|x| { //"
                                let v939 : bool = Fable.Core.RustInterop.emitRustExpr v937 v938 
                                let v940 : string = "x"
                                let v941 : string = Fable.Core.RustInterop.emitRustExpr () v940 
                                let v942 : string = "true; $0 })"
                                let v943 : bool = Fable.Core.RustInterop.emitRustExpr v941 v942 
                                let v944 : string = "_result"
                                let v945 : string = Fable.Core.RustInterop.emitRustExpr () v944 
                                let v946 : string = "lib/rust/fable/fable_modules/fable-library-rust"
                                let v947 : string = method14(v945, v946)
                                let v948 : string = "fable_modules/fable-library-rust"
                                let v949 : string = method14(v818, v948)
                                method98(v947, v949)
                                let struct (v950 : int32, v951 : string) = method99(v818, v654, v719, v931)
                                let v952 : bool = v950 <> 0 
                                if v952 then
                                    let v953 : US0 = US0_4
                                    let v954 : (unit -> string) = closure76()
                                    let v955 : (unit -> string) = closure77(v951, v950)
                                    method5(v953, v954, v955)
                                    let v956 : US3 = US3_1
                                    let v957 : US3 = US3_0(v654)
                                    let v958 : US3 = US3_0(v951)
                                    struct (v956, v957, v958)
                                else
                                    let v959 : string = "true; let _result : Vec<_> = v627.into_iter().map(|x| { //"
                                    let v960 : bool = Fable.Core.RustInterop.emitRustExpr () v959 
                                    let v961 : string = "x"
                                    let v962 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v961 
                                    let v963 : string = "fable_library_rust::String_::fromString($0)"
                                    let v964 : string = Fable.Core.RustInterop.emitRustExpr v962 v963 
                                    let v965 : string = "="
                                    let v966 : bool = v964.Contains v965 
                                    let v975 : string =
                                        if v966 then
                                            v964
                                        else
                                            let v967 : string = "]"
                                            let v968 : bool = v964.EndsWith v967 
                                            if v968 then
                                                let v969 : string = $"={{version='*',features=["
                                                let v970 : string = "["
                                                let v971 : string = v964.Replace (v970, v969)
                                                let v972 : string = $"{v971}}}"
                                                v972
                                            else
                                                let v973 : string = $"{v964}='*'"
                                                v973
                                    let v976 : string = "true; $0 }).collect::<Vec<_>>()"
                                    let v977 : bool = Fable.Core.RustInterop.emitRustExpr v975 v976 
                                    let v978 : string = "_result"
                                    let v979 : Vec<string> = Fable.Core.RustInterop.emitRustExpr () v978 
                                    let v980 : string = "fable_library_rust::NativeArray_::array_from($0)"
                                    let v981 : (string []) = Fable.Core.RustInterop.emitRustExpr v979 v980 
                                    let v982 : string seq = seq { for i = 0 to v981.Length - 1 do yield v981.[i] }
                                    let v983 : (string -> (string seq -> string)) = String.concat
                                    let v984 : (string seq -> string) = v983 v722
                                    let v985 : string = v984 v982
                                    let v986 : string = $"[package]"
                                    let v987 : string = $"name = \"spiral_builder_{v656}\""
                                    let v988 : string = v986 + v722 
                                    let v989 : string = v988 + v987 
                                    let v990 : string = $"version = \"0.0.1\""
                                    let v991 : string = v989 + v722 
                                    let v992 : string = v991 + v990 
                                    let v993 : string = $"edition = \"2021\""
                                    let v994 : string = v992 + v722 
                                    let v995 : string = v994 + v993 
                                    let v996 : string = $""
                                    let v997 : string = v995 + v722 
                                    let v998 : string = v997 + v996 
                                    let v999 : string = $"[dependencies]"
                                    let v1000 : string = v998 + v722 
                                    let v1001 : string = v1000 + v999 
                                    let v1002 : string = $"fable_library_rust = {{ workspace = true }}"
                                    let v1003 : string = v1001 + v722 
                                    let v1004 : string = v1003 + v1002 
                                    let v1005 : string = $"inline_colorization = {{ workspace = true }}"
                                    let v1006 : string = v1004 + v722 
                                    let v1007 : string = v1006 + v1005 
                                    let v1008 : string = $"{v985}"
                                    let v1009 : string = v1007 + v722 
                                    let v1010 : string = v1009 + v1008 
                                    let v1011 : string = $""
                                    let v1012 : string = v1010 + v722 
                                    let v1013 : string = v1012 + v1011 
                                    let v1014 : string = $"[[bin]]"
                                    let v1015 : string = v1013 + v722 
                                    let v1016 : string = v1015 + v1014 
                                    let v1017 : string = $"name = \"spiral_builder_{v656}\""
                                    let v1018 : string = v1016 + v722 
                                    let v1019 : string = v1018 + v1017 
                                    let v1020 : string = $"path = \"spiral_builder.rs\" "
                                    let v1021 : string = v1019 + v722 
                                    let v1022 : string = v1021 + v1020 
                                    let v1023 : string = method70(v945)
                                    let v1024 : string = $"[workspace]"
                                    let v1025 : string = $"resolver = \"2\""
                                    let v1026 : string = v1024 + v722 
                                    let v1027 : string = v1026 + v1025 
                                    let v1028 : string = $"members = [\"packages/*\"]"
                                    let v1029 : string = v1027 + v722 
                                    let v1030 : string = v1029 + v1028 
                                    let v1031 : string = $""
                                    let v1032 : string = v1030 + v722 
                                    let v1033 : string = v1032 + v1031 
                                    let v1034 : string = $"[workspace.dependencies.fable_library_rust]"
                                    let v1035 : string = v1033 + v722 
                                    let v1036 : string = v1035 + v1034 
                                    let v1037 : string = $"path = \"{v1023}/lib/rust/fable/fable_modules/fable-library-rust\""
                                    let v1038 : string = v1036 + v722 
                                    let v1039 : string = v1038 + v1037 
                                    let v1040 : string = $"default-features = false"
                                    let v1041 : string = v1039 + v722 
                                    let v1042 : string = v1041 + v1040 
                                    let v1043 : string = $"features = [\"static_do_bindings\", \"datetime\", \"guid\", \"threaded\"]"
                                    let v1044 : string = v1042 + v722 
                                    let v1045 : string = v1044 + v1043 
                                    let v1046 : string = $""
                                    let v1047 : string = v1045 + v722 
                                    let v1048 : string = v1047 + v1046 
                                    let v1049 : string = $"[workspace.dependencies]"
                                    let v1050 : string = v1048 + v722 
                                    let v1051 : string = v1050 + v1049 
                                    let v1052 : string = $"inline_colorization = \"~0.1\""
                                    let v1053 : string = v1051 + v722 
                                    let v1054 : string = v1053 + v1052 
                                    method24(v820, v1022)
                                    method24(v823, v1054)
                                    let v1055 : string = "src/Range.rs"
                                    let v1056 : string = method14(v949, v1055)
                                    let v1057 : bool = method26(v1056)
                                    if v1057 then
                                        let v1058 : bool = true
                                        let mutable _v1058 : string option = None 
                                        
#if FABLE_COMPILER || WASM || CONTRACT
                                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                        let v1059 : bool = true
                                        let mutable _v1059 : Vec<uint8> option = None 
                                        
#if FABLE_COMPILER || WASM || CONTRACT
                                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                        let v1060 : string = "std::fs::read(&*$0).unwrap()"
                                        let v1061 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v1056 v1060 
                                        v1061 
                                        #endif
#if FABLE_COMPILER_RUST && WASM
                                        let v1062 : Vec<uint8> = null |> unbox<Vec<uint8>>
                                        v1062 
                                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                                        let v1063 : Vec<uint8> = null |> unbox<Vec<uint8>>
                                        v1063 
                                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                                        let v1064 : Vec<uint8> = null |> unbox<Vec<uint8>>
                                        v1064 
                                        #endif
#if FABLE_COMPILER_PYTHON
                                        let v1065 : Vec<uint8> = null |> unbox<Vec<uint8>>
                                        v1065 
                                        #endif
#else
                                        let v1066 : (uint8 []) = v1056 |> System.IO.File.ReadAllBytes
                                        let v1067 : string = "$0.to_vec()"
                                        let v1068 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v1066 v1067 
                                        v1068 
                                        #endif
                                        |> fun x -> _v1059 <- Some x
                                        let v1069 : Vec<uint8> = match _v1059 with Some x -> x | None -> failwith "base.run_target / _v1059=None"
                                        let v1070 : string = "std::string::String::from_utf8(v1069)"
                                        let v1071 : Result<std_string_String, std_string_FromUtf8Error> = Fable.Core.RustInterop.emitRustExpr () v1070 
                                        let v1072 : string = "$0.unwrap()"
                                        let v1073 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1071 v1072 
                                        let v1074 : string = "fable_library_rust::String_::fromString($0)"
                                        let v1075 : string = Fable.Core.RustInterop.emitRustExpr v1073 v1074 
                                        v1075 
                                        #endif
#if FABLE_COMPILER_RUST && WASM
                                        let v1076 : string = null |> unbox<string>
                                        v1076 
                                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                                        let v1077 : string = null |> unbox<string>
                                        v1077 
                                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                                        let v1078 : string = null |> unbox<string>
                                        v1078 
                                        #endif
#if FABLE_COMPILER_PYTHON
                                        let v1079 : string = null |> unbox<string>
                                        v1079 
                                        #endif
#else
                                        let v1080 : string = v1056 |> System.IO.File.ReadAllText
                                        v1080 
                                        #endif
                                        |> fun x -> _v1058 <- Some x
                                        let v1081 : string = match _v1058 with Some x -> x | None -> failwith "base.run_target / _v1058=None"
                                        let v1082 : string = "use crate::String_::fromCharCode;"
                                        let v1083 : string = "use crate::String_::fromChar;"
                                        let v1084 : string = v1081.Replace (v1082, v1083)
                                        let v1085 : string = "fromCharCode(c)"
                                        let v1086 : string = "std::char::from_u32(c).unwrap()"
                                        let v1087 : string = v1084.Replace (v1085, v1086)
                                        method24(v1056, v1087)
                                    let v1088 : uint8 = 1uy
                                    let struct (v1089 : int32, v1090 : string) = method101(v820, v931, v1088)
                                    let v1091 : bool = v1089 <> 0 
                                    if v1091 then
                                        let v1092 : US0 = US0_4
                                        let v1093 : (unit -> string) = closure78()
                                        let v1094 : (unit -> string) = closure79(v1090, v1089)
                                        method5(v1092, v1093, v1094)
                                    let v1095 : string = $"{v694}.{v654}"
                                    let v1096 : string = method14(v818, v1095)
                                    let v1097 : bool = true
                                    let mutable _v1097 : string option = None 
                                    
#if FABLE_COMPILER || WASM || CONTRACT
                                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                    let v1098 : bool = true
                                    let mutable _v1098 : Vec<uint8> option = None 
                                    
#if FABLE_COMPILER || WASM || CONTRACT
                                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                    let v1099 : string = "std::fs::read(&*$0).unwrap()"
                                    let v1100 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v1096 v1099 
                                    v1100 
                                    #endif
#if FABLE_COMPILER_RUST && WASM
                                    let v1101 : Vec<uint8> = null |> unbox<Vec<uint8>>
                                    v1101 
                                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                                    let v1102 : Vec<uint8> = null |> unbox<Vec<uint8>>
                                    v1102 
                                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                                    let v1103 : Vec<uint8> = null |> unbox<Vec<uint8>>
                                    v1103 
                                    #endif
#if FABLE_COMPILER_PYTHON
                                    let v1104 : Vec<uint8> = null |> unbox<Vec<uint8>>
                                    v1104 
                                    #endif
#else
                                    let v1105 : (uint8 []) = v1096 |> System.IO.File.ReadAllBytes
                                    let v1106 : string = "$0.to_vec()"
                                    let v1107 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v1105 v1106 
                                    v1107 
                                    #endif
                                    |> fun x -> _v1098 <- Some x
                                    let v1108 : Vec<uint8> = match _v1098 with Some x -> x | None -> failwith "base.run_target / _v1098=None"
                                    let v1109 : string = "std::string::String::from_utf8(v1108)"
                                    let v1110 : Result<std_string_String, std_string_FromUtf8Error> = Fable.Core.RustInterop.emitRustExpr () v1109 
                                    let v1111 : string = "$0.unwrap()"
                                    let v1112 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1110 v1111 
                                    let v1113 : string = "fable_library_rust::String_::fromString($0)"
                                    let v1114 : string = Fable.Core.RustInterop.emitRustExpr v1112 v1113 
                                    v1114 
                                    #endif
#if FABLE_COMPILER_RUST && WASM
                                    let v1115 : string = null |> unbox<string>
                                    v1115 
                                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                                    let v1116 : string = null |> unbox<string>
                                    v1116 
                                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                                    let v1117 : string = null |> unbox<string>
                                    v1117 
                                    #endif
#if FABLE_COMPILER_PYTHON
                                    let v1118 : string = null |> unbox<string>
                                    v1118 
                                    #endif
#else
                                    let v1119 : string = v1096 |> System.IO.File.ReadAllText
                                    v1119 
                                    #endif
                                    |> fun x -> _v1097 <- Some x
                                    let v1120 : string = match _v1097 with Some x -> x | None -> failwith "base.run_target / _v1097=None"
                                    let v1121 : string = "\"{\".into()"
                                    let v1122 : string = Fable.Core.RustInterop.emitRustExpr () v1121 
                                    let v1123 : string = "pub fn main() -> Result<(), String> "
                                    let v1124 : string = v1123 + v1122 
                                    let v1125 : string = $"{v1124} Ok(()) }}"
                                    let v1126 : bool = v1120.Contains v1124 
                                    let v1202 : string =
                                        if v1126 then
                                            v1120
                                        else
                                            let v1127 : string = "\";\".into()"
                                            let v1128 : string = Fable.Core.RustInterop.emitRustExpr () v1127 
                                            let v1129 : string = "),)"
                                            let v1130 : string = v1129 + v1128 
                                            let v1131 : string = "));"
                                            let v1132 : string = v1120.Replace (v1130, v1131)
                                            let v1133 : string = "\";\".into()"
                                            let v1134 : string = Fable.Core.RustInterop.emitRustExpr () v1133 
                                            let v1135 : string = "},)"
                                            let v1136 : string = v1135 + v1134 
                                            let v1137 : string = "});"
                                            let v1138 : string = v1132.Replace (v1136, v1137)
                                            let v1139 : string = method103()
                                            let v1140 : bool = true
                                            let mutable _v1140 : string option = None 
                                            
#if FABLE_COMPILER || WASM || CONTRACT
                                            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                            let v1141 : string = method72(v1138)
                                            let v1142 : string = $"regex::Regex::new(&$0)"
                                            let v1143 : string = "\\s\\sdefaultOf\\(\\);"
                                            let v1144 : Result<regex_Regex, regex_Error> = Fable.Core.RustInterop.emitRustExpr v1143 v1142 
                                            let v1145 : string = "$0.unwrap()"
                                            let v1146 : regex_Regex = Fable.Core.RustInterop.emitRustExpr v1144 v1145 
                                            let v1147 : string = $"$0.replace_all(&$1, &*$2)"
                                            let v1148 : std_borrow_Cow<Str> = Fable.Core.RustInterop.emitRustExpr struct (v1146, v1141, v1139) v1147 
                                            let v1149 : string = "String::from($0)"
                                            let v1150 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1148 v1149 
                                            let v1151 : string = "fable_library_rust::String_::fromString($0)"
                                            let v1152 : string = Fable.Core.RustInterop.emitRustExpr v1150 v1151 
                                            v1152 
                                            #endif
#if FABLE_COMPILER_RUST && WASM
                                            let v1153 : string = null |> unbox<string>
                                            v1153 
                                            #endif
#if FABLE_COMPILER_RUST && CONTRACT
                                            let v1154 : string = null |> unbox<string>
                                            v1154 
                                            #endif
#if FABLE_COMPILER_TYPESCRIPT
                                            let v1155 : string = null |> unbox<string>
                                            v1155 
                                            #endif
#if FABLE_COMPILER_PYTHON
                                            let v1156 : string = null |> unbox<string>
                                            v1156 
                                            #endif
#else
                                            let v1157 : string = method104()
                                            let v1158 : string = System.Text.RegularExpressions.Regex.Replace (v1138, v1157, v1139)
                                            v1158 
                                            #endif
                                            |> fun x -> _v1140 <- Some x
                                            let v1159 : string = match _v1140 with Some x -> x | None -> failwith "base.run_target / _v1140=None"
                                            let v1160 : string = "\",\".into()"
                                            let v1161 : string = Fable.Core.RustInterop.emitRustExpr () v1160 
                                            let v1162 : string = "defaultOf()"
                                            let v1163 : string = v1162 + v1161 
                                            let v1164 : string = "defaultOf::<std::sync::Arc<dyn IDisposable>>(),"
                                            let v1165 : string = v1159.Replace (v1163, v1164)
                                            let v1166 : string = "\"_.\".into()"
                                            let v1167 : string = Fable.Core.RustInterop.emitRustExpr () v1166 
                                            let v1168 : string = "_self"
                                            let v1169 : string = v1168 + v1167 
                                            let v1170 : string = "self."
                                            let v1171 : string = v1165.Replace (v1169, v1170)
                                            let v1172 : string = "\"h\".into()"
                                            let v1173 : string = Fable.Core.RustInterop.emitRustExpr () v1172 
                                            let v1174 : string = "get_or_insert_wit"
                                            let v1175 : string = v1174 + v1173 
                                            let v1176 : string = "get_or_init"
                                            let v1177 : string = v1171.Replace (v1175, v1176)
                                            let v1178 : string = "\";\".into()"
                                            let v1179 : string = Fable.Core.RustInterop.emitRustExpr () v1178 
                                            let v1180 : string = "use fable_library_rust::System::Collections::Concurrent::ConcurrentStack_1"
                                            let v1181 : string = v1180 + v1179 
                                            let v1182 : string = "type ConcurrentStack_1<T> = T;"
                                            let v1183 : string = v1177.Replace (v1181, v1182)
                                            let v1184 : string = "\";\".into()"
                                            let v1185 : string = Fable.Core.RustInterop.emitRustExpr () v1184 
                                            let v1186 : string = "use fable_library_rust::System::Threading::CancellationToken"
                                            let v1187 : string = v1186 + v1185 
                                            let v1188 : string = "type CancellationToken = ();"
                                            let v1189 : string = v1183.Replace (v1187, v1188)
                                            let v1190 : string = "\";\".into()"
                                            let v1191 : string = Fable.Core.RustInterop.emitRustExpr () v1190 
                                            let v1192 : string = "use fable_library_rust::System::TimeZoneInfo"
                                            let v1193 : string = v1192 + v1191 
                                            let v1194 : string = "type TimeZoneInfo = i64;"
                                            let v1195 : string = v1189.Replace (v1193, v1194)
                                            let v1196 : string = "\";\".into()"
                                            let v1197 : string = Fable.Core.RustInterop.emitRustExpr () v1196 
                                            let v1198 : string = "use fable_library_rust::System::Threading::Tasks::TaskCanceledException"
                                            let v1199 : string = v1198 + v1197 
                                            let v1200 : string = "type TaskCanceledException = ();"
                                            let v1201 : string = v1195.Replace (v1199, v1200)
                                            v1201
                                    let v1203 : bool = v1126 = false
                                    if v1203 then
                                        let v1204 : string = $"{v1202}\n\n{v1125}\n"
                                        method24(v1096, v1204)
                                    let v1205 : string = $"cargo +nightly run --manifest-path \"{v820}\""
                                    let v1206 : string = "TRACE_LEVEL"
                                    let v1207 : string = "Verbose"
                                    let v1208 : string = "RUSTC_WRAPPER"
                                    let v1209 : string = "sccache"
                                    let v1210 : string = "RUSTFLAGS"
                                    let v1211 : string = "-C prefer-dynamic"
                                    let v1212 : (struct (string * string) []) = [|struct (v1206, v1207); struct (v1208, v1209); struct (v1210, v1211)|]
                                    let v1213 : System.Threading.CancellationToken option = None
                                    let v1214 : (struct (string * string) []) = [||]
                                    let v1215 : (struct (bool * string * int32) -> Async<unit>) option = None
                                    let v1216 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = None
                                    let v1217 : string option = None
                                    let v1223 : Result<string, string> =
                                        match v931 with
                                        | US12_1(v1220) -> (* Error *)
                                            let v1221 : Result<string, string> = Error v1220 
                                            v1221
                                        | US12_0(v1218) -> (* Ok *)
                                            let v1219 : Result<string, string> = Ok v1218 
                                            v1219
                                    let v1224 : string = "v1223.ok()"
                                    let v1225 : string option = Fable.Core.RustInterop.emitRustExpr () v1224 
                                    let v1226 : bool = true
                                    let struct (v1227 : int32, v1228 : string) = method28(v1213, v1205, v1212, v1215, v1216, v1226, v1225)
                                    let v1229 : string = ""
                                    let v1230 : string = $"target/debug/spiral_builder_{v656}{v1229}"
                                    let v1231 : string = method14(v822, v1230)
                                    let v1232 : string = ".pdb"
                                    let v1233 : string = $"target/debug/spiral_builder_{v656}{v1232}"
                                    let v1234 : string = method14(v822, v1233)
                                    let v1235 : string = ".exe"
                                    let v1236 : string = $"target/debug/spiral_builder_{v656}{v1235}"
                                    let v1237 : string = method14(v822, v1236)
                                    let v1238 : string = ".d"
                                    let v1239 : string = $"target/debug/spiral_builder_{v656}{v1238}"
                                    let v1240 : string = method14(v822, v1239)
                                    let v1241 : bool = method26(v1231)
                                    let v1242 : bool = method26(v1234)
                                    let v1243 : bool = method26(v1237)
                                    let v1244 : bool = method26(v1240)
                                    let v1245 : US0 = US0_0
                                    let v1246 : (unit -> string) = closure80()
                                    let v1247 : (unit -> string) = closure81(v1096, v1240, v1244, v1237, v1243, v1234, v1242, v1231, v1241)
                                    method5(v1245, v1246, v1247)
                                    let v1251 : UH3 =
                                        if v1241 then
                                            let v1248 : UH3 = UH3_0
                                            UH3_1(v1231, v1241, v1248)
                                        else
                                            UH3_0
                                    let v1253 : UH3 =
                                        if v1242 then
                                            UH3_1(v1234, v1242, v1251)
                                        else
                                            v1251
                                    let v1255 : UH3 =
                                        if v1243 then
                                            UH3_1(v1237, v1243, v1253)
                                        else
                                            v1253
                                    let v1257 : UH3 =
                                        if v1244 then
                                            UH3_1(v1240, v1244, v1255)
                                        else
                                            v1255
                                    method105(v1257)
                                    let v1258 : int32 = v1212.Length
                                    let v1259 : (string []) = Array.zeroCreate<string> (v1258)
                                    let v1260 : Mut4 = {l0 = 0} : Mut4
                                    while method32(v1258, v1260) do
                                        let v1262 : int32 = v1260.l0
                                        let struct (v1263 : string, v1264 : string) = v1212.[int v1262]
                                        let v1265 : string = $"$env:{v1263}=''{v1264}''"
                                        v1259.[int v1262] <- v1265
                                        let v1266 : int32 = v1262 + 1
                                        v1260.l0 <- v1266
                                        ()
                                    let v1267 : ((string []) -> string seq) = Seq.ofArray
                                    let v1268 : string seq = v1267 v1259
                                    let v1269 : (string -> (string seq -> string)) = String.concat
                                    let v1270 : string = ";"
                                    let v1271 : (string seq -> string) = v1269 v1270
                                    let v1272 : string = v1271 v1268
                                    let v1273 : string = $"pwsh -c '{v1272}; {v1205}'"
                                    let v1274 : bool = v1227 = 0
                                    if v1274 then
                                        let v1275 : (unit -> string) = closure82(v1228)
                                        let v1276 : (string -> US3) = closure45()
                                        let v1277 : (exn -> US3) = closure84(v1096, v1228, v1273)
                                        let v1278 : US3 = try v1275 () |> v1276 with ex -> v1277 ex 
                                        let v1283 : string option =
                                            match v1278 with
                                            | US3_1 -> (* None *)
                                                let v1281 : string option = None
                                                v1281
                                            | US3_0(v1279) -> (* Some *)
                                                let v1280 : string option = Some v1279 
                                                v1280
                                        let v1284 : string = "$0.unwrap()"
                                        let v1285 : string = Fable.Core.RustInterop.emitRustExpr v1283 v1284 
                                        let v1286 : US3 = US3_0(v1202)
                                        let v1287 : US3 = US3_0(v654)
                                        let v1288 : US3 = US3_0(v1285)
                                        struct (v1286, v1287, v1288)
                                    else
                                        let v1289 : US0 = US0_4
                                        let v1290 : (unit -> string) = closure87()
                                        let v1291 : (unit -> string) = closure88(v1096, v1228, v1227, v1273)
                                        method5(v1289, v1290, v1291)
                                        let v1292 : US3 = US3_1
                                        let v1293 : US3 = US3_0(v654)
                                        let v1294 : US3 = US3_1
                                        struct (v1292, v1293, v1294)
                            else
                                let v1301 : string = "fable_library_rust::String_::fromString($0)"
                                let v1302 : string = Fable.Core.RustInterop.emitRustExpr v13 v1301 
                                let v1304 : bool = v1302 = "typescript"
                                if v1304 then
                                    let v1305 : string = method63()
                                    let v1306 : string = "&*$0"
                                    let v1307 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1305 v1306 
                                    let v1308 : string = "clap::ArgMatches::get_one(&$0, v1307).cloned()"
                                    let v1309 : std_string_String option = Fable.Core.RustInterop.emitRustExpr v14 v1308 
                                    let v1310 : US5 option = None
                                    let _v1310 = ref v1310 
                                    match v1309 with
                                    | Some x -> (
                                    (fun () ->
                                    (fun () ->
                                    let v1311 : std_string_String = x
                                    let v1312 : US5 = US5_0(v1311)
                                    v1312 
                                    )
                                    |> fun x -> x () |> Some
                                    ) () ) | None -> None
                                    |> fun x -> _v1310.Value <- x
                                    let v1313 : US5 option = _v1310.Value 
                                    let v1314 : US5 = US5_1
                                    let v1315 : US5 = v1313 |> Option.defaultValue v1314 
                                    let v1319 : std_string_String =
                                        match v1315 with
                                        | US5_1 -> (* None *)
                                            failwith<std_string_String> "Option does not have a value."
                                        | US5_0(v1316) -> (* Some *)
                                            v1316
                                    let v1320 : string = "fable_library_rust::String_::fromString($0)"
                                    let v1321 : string = Fable.Core.RustInterop.emitRustExpr v1319 v1320 
                                    let v1322 : string = method13()
                                    let v1323 : string = "&*$0"
                                    let v1324 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1322 v1323 
                                    let v1325 : string = "clap::ArgMatches::get_many(&$0, v1324).map(|x| x.cloned().into_iter().collect())"
                                    let v1326 : Vec<std_string_String> option = Fable.Core.RustInterop.emitRustExpr v14 v1325 
                                    let v1327 : US9 option = None
                                    let _v1327 = ref v1327 
                                    match v1326 with
                                    | Some x -> (
                                    (fun () ->
                                    (fun () ->
                                    let v1328 : Vec<std_string_String> = x
                                    let v1329 : US9 = US9_0(v1328)
                                    v1329 
                                    )
                                    |> fun x -> x () |> Some
                                    ) () ) | None -> None
                                    |> fun x -> _v1327.Value <- x
                                    let v1330 : US9 option = _v1327.Value 
                                    let v1331 : US9 = US9_1
                                    let v1332 : US9 = v1330 |> Option.defaultValue v1331 
                                    let v1333 : (std_string_String []) = [||]
                                    let v1334 : string = "$0.to_vec()"
                                    let v1335 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr v1333 v1334 
                                    let v1338 : Vec<std_string_String> =
                                        match v1332 with
                                        | US9_1 -> (* None *)
                                            v1335
                                        | US9_0(v1336) -> (* Some *)
                                            v1336
                                    let v1340 : bool =
                                        match v0 with
                                        | US0_0 -> (* Verbose *)
                                            true
                                        | _ ->
                                            false
                                    let v1341 : bool = true
                                    let mutable _v1341 : string option = None 
                                    
#if FABLE_COMPILER || WASM || CONTRACT
                                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                    let v1342 : bool = true
                                    let mutable _v1342 : Vec<uint8> option = None 
                                    
#if FABLE_COMPILER || WASM || CONTRACT
                                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                    let v1343 : string = "std::fs::read(&*$0).unwrap()"
                                    let v1344 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v1321 v1343 
                                    v1344 
                                    #endif
#if FABLE_COMPILER_RUST && WASM
                                    let v1345 : Vec<uint8> = null |> unbox<Vec<uint8>>
                                    v1345 
                                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                                    let v1346 : Vec<uint8> = null |> unbox<Vec<uint8>>
                                    v1346 
                                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                                    let v1347 : Vec<uint8> = null |> unbox<Vec<uint8>>
                                    v1347 
                                    #endif
#if FABLE_COMPILER_PYTHON
                                    let v1348 : Vec<uint8> = null |> unbox<Vec<uint8>>
                                    v1348 
                                    #endif
#else
                                    let v1349 : (uint8 []) = v1321 |> System.IO.File.ReadAllBytes
                                    let v1350 : string = "$0.to_vec()"
                                    let v1351 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v1349 v1350 
                                    v1351 
                                    #endif
                                    |> fun x -> _v1342 <- Some x
                                    let v1352 : Vec<uint8> = match _v1342 with Some x -> x | None -> failwith "base.run_target / _v1342=None"
                                    let v1353 : string = "std::string::String::from_utf8(v1352)"
                                    let v1354 : Result<std_string_String, std_string_FromUtf8Error> = Fable.Core.RustInterop.emitRustExpr () v1353 
                                    let v1355 : string = "$0.unwrap()"
                                    let v1356 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1354 v1355 
                                    let v1357 : string = "fable_library_rust::String_::fromString($0)"
                                    let v1358 : string = Fable.Core.RustInterop.emitRustExpr v1356 v1357 
                                    v1358 
                                    #endif
#if FABLE_COMPILER_RUST && WASM
                                    let v1359 : string = null |> unbox<string>
                                    v1359 
                                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                                    let v1360 : string = null |> unbox<string>
                                    v1360 
                                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                                    let v1361 : string = null |> unbox<string>
                                    v1361 
                                    #endif
#if FABLE_COMPILER_PYTHON
                                    let v1362 : string = null |> unbox<string>
                                    v1362 
                                    #endif
#else
                                    let v1363 : string = v1321 |> System.IO.File.ReadAllText
                                    v1363 
                                    #endif
                                    |> fun x -> _v1341 <- Some x
                                    let v1364 : string = match _v1341 with Some x -> x | None -> failwith "base.run_target / _v1341=None"
                                    let v1365 : string = "ts"
                                    let v1366 : string = $"%A{struct (v1365, v1364)}"
                                    let v1367 : string = method80(v1366)
                                    let v1368 : string = __SOURCE_DIRECTORY__
                                    let v1369 : string = "polyglot"
                                    let v1370 : string = ".paket"
                                    let v1371 : string = method14(v1369, v1370)
                                    let v1372 : US12 = method17(v1371, v1368)
                                    let v1381 : US3 =
                                        match v1372 with
                                        | US12_1(v1375) -> (* Error *)
                                            let v1376 : US0 = US0_3
                                            let v1377 : (unit -> string) = closure10()
                                            let v1378 : (unit -> string) = closure11(v1375)
                                            method5(v1376, v1377, v1378)
                                            US3_1
                                        | US12_0(v1373) -> (* Ok *)
                                            US3_0(v1373)
                                    let v1397 : US3 =
                                        match v1381 with
                                        | US3_1 -> (* None *)
                                            let v1384 : string = method22()
                                            let v1385 : string = method14(v1369, v1370)
                                            let v1386 : US12 = method17(v1385, v1384)
                                            match v1386 with
                                            | US12_1(v1389) -> (* Error *)
                                                let v1390 : US0 = US0_3
                                                let v1391 : (unit -> string) = closure10()
                                                let v1392 : (unit -> string) = closure11(v1389)
                                                method5(v1390, v1391, v1392)
                                                US3_1
                                            | US12_0(v1387) -> (* Ok *)
                                                US3_0(v1387)
                                        | US3_0(v1382) -> (* Some *)
                                            US3_0(v1382)
                                    let v1401 : string =
                                        match v1397 with
                                        | US3_1 -> (* None *)
                                            failwith<string> "Option does not have a value."
                                        | US3_0(v1398) -> (* Some *)
                                            v1398
                                    let v1402 : string = method14(v1401, v1369)
                                    let v1403 : string = "target/spiral_builder"
                                    let v1404 : string = method14(v1402, v1403)
                                    let v1405 : string = "spiral_builder"
                                    let v1406 : string = method14(v1404, v1405)
                                    let v1407 : string = "packages"
                                    let v1408 : string = method14(v1406, v1407)
                                    let v1409 : string = method14(v1408, v1367)
                                    let v1410 : System.IDisposable = method82(v1409)
                                    let v1411 : string = $"{v1405}.fs"
                                    let v1412 : string = method14(v1409, v1411)
                                    let v1413 : string = method70(v1412)
                                    method24(v1413, v1364)
                                    let v1414 : string list = []
                                    let v1415 : string seq = seq { for i = 0 to v1414.Length - 1 do yield v1414.[i] }
                                    let v1416 : (string -> (string seq -> string)) = String.concat
                                    let v1417 : string = "\\n        "
                                    let v1418 : (string seq -> string) = v1416 v1417
                                    let v1419 : string = v1418 v1415
                                    let v1420 : string = "Fable.Core"
                                    let v1421 : string = $"<PackageReference Include=\"{v1420}\" Version=\"*\" />"
                                    let v1422 : string list = []
                                    let v1423 : string list = v1421 :: v1422 
                                    let v1424 : string seq = seq { for i = 0 to v1423.Length - 1 do yield v1423.[i] }
                                    let v1425 : (string -> (string seq -> string)) = String.concat
                                    let v1426 : (string seq -> string) = v1425 v1417
                                    let v1427 : string = v1426 v1424
                                    let v1428 : string = $"{v1405}.fsproj"
                                    let v1429 : string = method14(v1409, v1428)
                                    let v1430 : string = method70(v1429)
                                    let v1431 : string = $"<Project Sdk=\"Microsoft.NET.Sdk\">"
                                    let v1432 : string = $"<PropertyGroup>"
                                    let v1433 : string = "\n"
                                    let v1434 : string = v1431 + v1433 
                                    let v1435 : string = v1434 + v1432 
                                    let v1436 : string = $"    <TargetFramework>net9.0</TargetFramework>"
                                    let v1437 : string = v1435 + v1433 
                                    let v1438 : string = v1437 + v1436 
                                    let v1439 : string = $"    <LangVersion>preview</LangVersion>"
                                    let v1440 : string = v1438 + v1433 
                                    let v1441 : string = v1440 + v1439 
                                    let v1442 : string = $"    <RollForward>Major</RollForward>"
                                    let v1443 : string = v1441 + v1433 
                                    let v1444 : string = v1443 + v1442 
                                    let v1445 : string = $"    <TargetLatestRuntimePatch>true</TargetLatestRuntimePatch>"
                                    let v1446 : string = v1444 + v1433 
                                    let v1447 : string = v1446 + v1445 
                                    let v1448 : string = $"    <PublishAot>false</PublishAot>"
                                    let v1449 : string = v1447 + v1433 
                                    let v1450 : string = v1449 + v1448 
                                    let v1451 : string = $"    <PublishTrimmed>false</PublishTrimmed>"
                                    let v1452 : string = v1450 + v1433 
                                    let v1453 : string = v1452 + v1451 
                                    let v1454 : string = $"    <PublishSingleFile>true</PublishSingleFile>"
                                    let v1455 : string = v1453 + v1433 
                                    let v1456 : string = v1455 + v1454 
                                    let v1457 : string = $"    <SelfContained>true</SelfContained>"
                                    let v1458 : string = v1456 + v1433 
                                    let v1459 : string = v1458 + v1457 
                                    let v1460 : string = $"    <Version>0.0.1-alpha.1</Version>"
                                    let v1461 : string = v1459 + v1433 
                                    let v1462 : string = v1461 + v1460 
                                    let v1463 : string = $"    <OutputType>Exe</OutputType>"
                                    let v1464 : string = v1462 + v1433 
                                    let v1465 : string = v1464 + v1463 
                                    let v1466 : string = $"</PropertyGroup>"
                                    let v1467 : string = v1465 + v1433 
                                    let v1468 : string = v1467 + v1466 
                                    let v1469 : string = $"<PropertyGroup Condition=\"$([MSBuild]::IsOSPlatform('FreeBSD'))\">"
                                    let v1470 : string = v1468 + v1433 
                                    let v1471 : string = v1470 + v1469 
                                    let v1472 : string = $"    <DefineConstants>_FREEBSD</DefineConstants>"
                                    let v1473 : string = v1471 + v1433 
                                    let v1474 : string = v1473 + v1472 
                                    let v1475 : string = $"</PropertyGroup>"
                                    let v1476 : string = v1474 + v1433 
                                    let v1477 : string = v1476 + v1475 
                                    let v1478 : string = $"<PropertyGroup Condition=\"$([MSBuild]::IsOSPlatform('Linux'))\">"
                                    let v1479 : string = v1477 + v1433 
                                    let v1480 : string = v1479 + v1478 
                                    let v1481 : string = $"    <DefineConstants>_LINUX</DefineConstants>"
                                    let v1482 : string = v1480 + v1433 
                                    let v1483 : string = v1482 + v1481 
                                    let v1484 : string = $"</PropertyGroup>"
                                    let v1485 : string = v1483 + v1433 
                                    let v1486 : string = v1485 + v1484 
                                    let v1487 : string = $"<PropertyGroup Condition=\"$([MSBuild]::IsOSPlatform('OSX'))\">"
                                    let v1488 : string = v1486 + v1433 
                                    let v1489 : string = v1488 + v1487 
                                    let v1490 : string = $"    <DefineConstants>_OSX</DefineConstants>"
                                    let v1491 : string = v1489 + v1433 
                                    let v1492 : string = v1491 + v1490 
                                    let v1493 : string = $"</PropertyGroup>"
                                    let v1494 : string = v1492 + v1433 
                                    let v1495 : string = v1494 + v1493 
                                    let v1496 : string = $"<PropertyGroup Condition=\"$([MSBuild]::IsOSPlatform('Windows'))\">"
                                    let v1497 : string = v1495 + v1433 
                                    let v1498 : string = v1497 + v1496 
                                    let v1499 : string = $"    <DefineConstants>_WINDOWS</DefineConstants>"
                                    let v1500 : string = v1498 + v1433 
                                    let v1501 : string = v1500 + v1499 
                                    let v1502 : string = $"</PropertyGroup>"
                                    let v1503 : string = v1501 + v1433 
                                    let v1504 : string = v1503 + v1502 
                                    let v1505 : string = $"<ItemGroup>"
                                    let v1506 : string = v1504 + v1433 
                                    let v1507 : string = v1506 + v1505 
                                    let v1508 : string = $"    {v1419}"
                                    let v1509 : string = v1507 + v1433 
                                    let v1510 : string = v1509 + v1508 
                                    let v1511 : string = $"    <Compile Include=\"{v1413}\" />"
                                    let v1512 : string = v1510 + v1433 
                                    let v1513 : string = v1512 + v1511 
                                    let v1514 : string = $"</ItemGroup>"
                                    let v1515 : string = v1513 + v1433 
                                    let v1516 : string = v1515 + v1514 
                                    let v1517 : string = $"<ItemGroup>"
                                    let v1518 : string = v1516 + v1433 
                                    let v1519 : string = v1518 + v1517 
                                    let v1520 : string = $"    {v1427}"
                                    let v1521 : string = v1519 + v1433 
                                    let v1522 : string = v1521 + v1520 
                                    let v1523 : string = $"</ItemGroup>"
                                    let v1524 : string = v1522 + v1433 
                                    let v1525 : string = v1524 + v1523 
                                    let v1526 : string = $"</Project>"
                                    let v1527 : string = v1525 + v1433 
                                    let v1528 : string = v1527 + v1526 
                                    method24(v1430, v1528)
                                    let v1529 : string = method23(v1430)
                                    let v1530 : string = __SOURCE_DIRECTORY__
                                    let v1531 : string = method14(v1369, v1370)
                                    let v1532 : US12 = method17(v1531, v1530)
                                    let v1541 : US3 =
                                        match v1532 with
                                        | US12_1(v1535) -> (* Error *)
                                            let v1536 : US0 = US0_3
                                            let v1537 : (unit -> string) = closure10()
                                            let v1538 : (unit -> string) = closure11(v1535)
                                            method5(v1536, v1537, v1538)
                                            US3_1
                                        | US12_0(v1533) -> (* Ok *)
                                            US3_0(v1533)
                                    let v1557 : US3 =
                                        match v1541 with
                                        | US3_1 -> (* None *)
                                            let v1544 : string = method22()
                                            let v1545 : string = method14(v1369, v1370)
                                            let v1546 : US12 = method17(v1545, v1544)
                                            match v1546 with
                                            | US12_1(v1549) -> (* Error *)
                                                let v1550 : US0 = US0_3
                                                let v1551 : (unit -> string) = closure10()
                                                let v1552 : (unit -> string) = closure11(v1549)
                                                method5(v1550, v1551, v1552)
                                                US3_1
                                            | US12_0(v1547) -> (* Ok *)
                                                US3_0(v1547)
                                        | US3_0(v1542) -> (* Some *)
                                            US3_0(v1542)
                                    let v1561 : string =
                                        match v1557 with
                                        | US3_1 -> (* None *)
                                            failwith<string> "Option does not have a value."
                                        | US3_0(v1558) -> (* Some *)
                                            v1558
                                    let v1562 : string = method14(v1561, v1369)
                                    let v1563 : string = method22()
                                    let v1564 : (unit -> string) = v1563.ToLower
                                    let v1565 : string = v1564 ()
                                    let v1566 : (unit -> string) = v1562.ToLower
                                    let v1567 : string = v1566 ()
                                    let v1568 : bool = v1565.StartsWith v1567 
                                    let v1571 : US12 =
                                        if v1568 then
                                            US12_1(v1567)
                                        else
                                            US12_0(v1567)
                                    let v1577 : Result<string, string> =
                                        match v1571 with
                                        | US12_1(v1574) -> (* Error *)
                                            let v1575 : Result<string, string> = Error v1574 
                                            v1575
                                        | US12_0(v1572) -> (* Ok *)
                                            let v1573 : Result<string, string> = Ok v1572 
                                            v1573
                                    let v1578 : string = "true; let _result = $0.unwrap_or_else(|x| { //"
                                    let v1579 : bool = Fable.Core.RustInterop.emitRustExpr v1577 v1578 
                                    let v1580 : string = "x"
                                    let v1581 : string = Fable.Core.RustInterop.emitRustExpr () v1580 
                                    let v1582 : string = "true; $0 })"
                                    let v1583 : bool = Fable.Core.RustInterop.emitRustExpr v1581 v1582 
                                    let v1584 : string = "_result"
                                    let v1585 : string = Fable.Core.RustInterop.emitRustExpr () v1584 
                                    let v1586 : string = "lib/typescript/fable/fable_modules"
                                    let v1587 : string = method14(v1585, v1586)
                                    let v1588 : string = "async_walkdir::WalkDir::new(&*$0)"
                                    let v1589 : async_walkdir_WalkDir = Fable.Core.RustInterop.emitRustExpr v1587 v1588 
                                    let v1590 : string = "async_walkdir::WalkDir::filter($0, |x| $1(x))"
                                    let v1591 : (async_walkdir_DirEntry -> std_pin_Pin<Box<LifetimeJoin<Dyn<std_future_Future<async_walkdir_Filtering>>, Send<Dyn<std_future_Future<async_walkdir_Filtering>>>>>>) = closure89()
                                    let v1592 : async_walkdir_WalkDir = Fable.Core.RustInterop.emitRustExpr struct (v1589, v1591) v1590 
                                    let v1593 : (Result<async_walkdir_DirEntry, std_io_Error> -> struct (string * string) option) = method112()
                                    let v1594 : string = "tokio_stream::StreamExt::collect(tokio_stream::StreamExt::filter_map(v1592, |x| v1593(x))).await"
                                    let v1595 : Vec<struct (string * string)> = Fable.Core.RustInterop.emitRustExpr () v1594 
                                    let v1596 : string = "rayon::iter::IntoParallelIterator::into_par_iter(v1595)"
                                    let v1597 : rayon_vec_IntoIter<struct (string * string)> = Fable.Core.RustInterop.emitRustExpr () v1596 
                                    let v1598 : string = "rayon::iter::ParallelIterator::map($0, |x| $1(x))"
                                    let v1599 : (struct (string * string) -> struct (string * string)) = closure97()
                                    let v1600 : rayon_iter_Map<rayon_vec_IntoIter<struct (string * string)>> = Fable.Core.RustInterop.emitRustExpr struct (v1597, v1599) v1598 
                                    let v1601 : string = "rayon::iter::ParallelIterator::collect($0)"
                                    let v1602 : Vec<struct (string * string)> = Fable.Core.RustInterop.emitRustExpr v1600 v1601 
                                    let v1603 : string = "fable_library_rust::NativeArray_::array_from($0)"
                                    let v1604 : (struct (string * string) []) = Fable.Core.RustInterop.emitRustExpr v1602 v1603 
                                    let v1605 : (int32 -> ((struct (string * string) []) -> struct (string * string) option)) = Array.tryItem
                                    let v1606 : ((struct (string * string) []) -> struct (string * string) option) = v1605 0
                                    let v1607 : struct (string * string) option = v1606 v1604
                                    let v1608 : US38 option = None
                                    let _v1608 = ref v1608 
                                    match v1607 with
                                    | Some x -> (
                                    (fun () ->
                                    (fun () ->
                                    let struct (v1609 : string, v1610 : string) = x
                                    let v1611 : US38 = US38_0(v1609, v1610)
                                    v1611 
                                    )
                                    |> fun x -> x () |> Some
                                    ) () ) | None -> None
                                    |> fun x -> _v1608.Value <- x
                                    let v1612 : US38 option = _v1608.Value 
                                    let v1613 : US38 = US38_1
                                    let v1614 : US38 = v1612 |> Option.defaultValue v1613 
                                    let v1615 : US0 = US0_1
                                    let v1616 : (unit -> string) = closure98()
                                    let v1617 : (unit -> string) = closure99(v1614)
                                    method5(v1615, v1616, v1617)
                                    match v1614 with
                                    | US38_1 -> (* None *)
                                        ()
                                    | US38_0(v1618, v1619) -> (* Some *)
                                        let v1620 : string = $"fable-library-{v1365}.{v1619}"
                                        let v1621 : string = method14(v1587, v1620)
                                        let v1622 : string = $"fable_modules/fable-library-{v1365}.{v1619}"
                                        let v1623 : string = method14(v1529, v1622)
                                        method98(v1621, v1623)
                                    let struct (v1624 : int32, v1625 : string) = method99(v1529, v1365, v1430, v1571)
                                    let v1626 : bool = v1624 <> 0 
                                    if v1626 then
                                        let v1627 : US0 = US0_4
                                        let v1628 : (unit -> string) = closure100(v1625, v1624)
                                        let v1629 : (unit -> string) = closure6()
                                        method5(v1627, v1628, v1629)
                                        let v1630 : US3 = US3_1
                                        let v1631 : US3 = US3_0(v1365)
                                        let v1632 : US3 = US3_0(v1625)
                                        struct (v1630, v1631, v1632)
                                    else
                                        let v1633 : string = "true; let _result : Vec<_> = v1338.into_iter().map(|x| { //"
                                        let v1634 : bool = Fable.Core.RustInterop.emitRustExpr () v1633 
                                        let v1635 : string = "x"
                                        let v1636 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v1635 
                                        let v1637 : string = "fable_library_rust::String_::fromString($0)"
                                        let v1638 : string = Fable.Core.RustInterop.emitRustExpr v1636 v1637 
                                        let v1639 : string = "="
                                        let v1640 : bool = v1638.Contains v1639 
                                        let v1642 : string =
                                            if v1640 then
                                                v1638
                                            else
                                                let v1641 : string = $"\"{v1638}\":\"*\""
                                                v1641
                                        let v1643 : string = "true; $0 }).collect::<Vec<_>>()"
                                        let v1644 : bool = Fable.Core.RustInterop.emitRustExpr v1642 v1643 
                                        let v1645 : string = "_result"
                                        let v1646 : Vec<string> = Fable.Core.RustInterop.emitRustExpr () v1645 
                                        let v1647 : string = "fable_library_rust::NativeArray_::array_from($0)"
                                        let v1648 : (string []) = Fable.Core.RustInterop.emitRustExpr v1646 v1647 
                                        let v1649 : string seq = seq { for i = 0 to v1648.Length - 1 do yield v1648.[i] }
                                        let v1650 : (string -> (string seq -> string)) = String.concat
                                        let v1651 : string = ",\n"
                                        let v1652 : (string seq -> string) = v1650 v1651
                                        let v1653 : string = v1652 v1649
                                        let v1654 : string = $"{{"
                                        let v1655 : string = $"  \"name\": \"spiral_builder_{v1367}\","
                                        let v1656 : string = v1654 + v1655 
                                        let v1657 : string = $"  \"dependencies\": {{"
                                        let v1658 : string = v1656 + v1657 
                                        let v1659 : string = v1658 + v1653 
                                        let v1660 : string = $"  }},"
                                        let v1661 : string = v1659 + v1660 
                                        let v1662 : string = $"    \"devDependencies\": {{"
                                        let v1663 : string = v1661 + v1662 
                                        let v1664 : string = $"  }},"
                                        let v1665 : string = v1663 + v1664 
                                        let v1666 : string = $"}}"
                                        let v1667 : string = v1665 + v1666 
                                        let v1668 : string = "package.json"
                                        let v1669 : string = method14(v1529, v1668)
                                        let v1670 : string = "../.."
                                        let v1671 : string = method14(v1529, v1670)
                                        let v1672 : string = method14(v1671, v1668)
                                        method24(v1669, v1667)
                                        let v1673 : string = ""
                                        method24(v1672, v1673)
                                        let v1674 : string = $"{v1405}.{v1365}"
                                        let v1675 : string = method14(v1529, v1674)
                                        let v1676 : US0 = US0_1
                                        let v1677 : (unit -> string) = closure101()
                                        let v1678 : (unit -> string) = closure102(v1675)
                                        method5(v1676, v1677, v1678)
                                        let v1679 : bool = true
                                        let mutable _v1679 : string option = None 
                                        
#if FABLE_COMPILER || WASM || CONTRACT
                                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                        let v1680 : bool = true
                                        let mutable _v1680 : Vec<uint8> option = None 
                                        
#if FABLE_COMPILER || WASM || CONTRACT
                                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                        let v1681 : string = "std::fs::read(&*$0).unwrap()"
                                        let v1682 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v1675 v1681 
                                        v1682 
                                        #endif
#if FABLE_COMPILER_RUST && WASM
                                        let v1683 : Vec<uint8> = null |> unbox<Vec<uint8>>
                                        v1683 
                                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                                        let v1684 : Vec<uint8> = null |> unbox<Vec<uint8>>
                                        v1684 
                                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                                        let v1685 : Vec<uint8> = null |> unbox<Vec<uint8>>
                                        v1685 
                                        #endif
#if FABLE_COMPILER_PYTHON
                                        let v1686 : Vec<uint8> = null |> unbox<Vec<uint8>>
                                        v1686 
                                        #endif
#else
                                        let v1687 : (uint8 []) = v1675 |> System.IO.File.ReadAllBytes
                                        let v1688 : string = "$0.to_vec()"
                                        let v1689 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v1687 v1688 
                                        v1689 
                                        #endif
                                        |> fun x -> _v1680 <- Some x
                                        let v1690 : Vec<uint8> = match _v1680 with Some x -> x | None -> failwith "base.run_target / _v1680=None"
                                        let v1691 : string = "std::string::String::from_utf8(v1690)"
                                        let v1692 : Result<std_string_String, std_string_FromUtf8Error> = Fable.Core.RustInterop.emitRustExpr () v1691 
                                        let v1693 : string = "$0.unwrap()"
                                        let v1694 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1692 v1693 
                                        let v1695 : string = "fable_library_rust::String_::fromString($0)"
                                        let v1696 : string = Fable.Core.RustInterop.emitRustExpr v1694 v1695 
                                        v1696 
                                        #endif
#if FABLE_COMPILER_RUST && WASM
                                        let v1697 : string = null |> unbox<string>
                                        v1697 
                                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                                        let v1698 : string = null |> unbox<string>
                                        v1698 
                                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                                        let v1699 : string = null |> unbox<string>
                                        v1699 
                                        #endif
#if FABLE_COMPILER_PYTHON
                                        let v1700 : string = null |> unbox<string>
                                        v1700 
                                        #endif
#else
                                        let v1701 : string = v1675 |> System.IO.File.ReadAllText
                                        v1701 
                                        #endif
                                        |> fun x -> _v1679 <- Some x
                                        let v1702 : string = match _v1679 with Some x -> x | None -> failwith "base.run_target / _v1679=None"
                                        let v1703 : string = "// spiral_builder.process_typescript"
                                        let v1704 : bool = v1702.Contains v1703 
                                        let v1729 : string =
                                            if v1704 then
                                                v1702
                                            else
                                                let v1705 : string = $"\"./fable_modules/fable-library-ts.{v1614}/"
                                                let v1706 : string = $"\"{v1585}/lib/typescript/fable/fable_modules/fable-library-ts.{v1614}/"
                                                let v1707 : string = v1702.Replace (v1705, v1706)
                                                let v1708 : string = method103()
                                                let v1709 : bool = true
                                                let mutable _v1709 : string option = None 
                                                
#if FABLE_COMPILER || WASM || CONTRACT
                                                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                                let v1710 : string = method72(v1707)
                                                let v1711 : string = $"regex::Regex::new(&$0)"
                                                let v1712 : string = "\\s\\sdefaultOf\\(\\);"
                                                let v1713 : Result<regex_Regex, regex_Error> = Fable.Core.RustInterop.emitRustExpr v1712 v1711 
                                                let v1714 : string = "$0.unwrap()"
                                                let v1715 : regex_Regex = Fable.Core.RustInterop.emitRustExpr v1713 v1714 
                                                let v1716 : string = $"$0.replace_all(&$1, &*$2)"
                                                let v1717 : std_borrow_Cow<Str> = Fable.Core.RustInterop.emitRustExpr struct (v1715, v1710, v1708) v1716 
                                                let v1718 : string = "String::from($0)"
                                                let v1719 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1717 v1718 
                                                let v1720 : string = "fable_library_rust::String_::fromString($0)"
                                                let v1721 : string = Fable.Core.RustInterop.emitRustExpr v1719 v1720 
                                                v1721 
                                                #endif
#if FABLE_COMPILER_RUST && WASM
                                                let v1722 : string = null |> unbox<string>
                                                v1722 
                                                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                                                let v1723 : string = null |> unbox<string>
                                                v1723 
                                                #endif
#if FABLE_COMPILER_TYPESCRIPT
                                                let v1724 : string = null |> unbox<string>
                                                v1724 
                                                #endif
#if FABLE_COMPILER_PYTHON
                                                let v1725 : string = null |> unbox<string>
                                                v1725 
                                                #endif
#else
                                                let v1726 : string = method104()
                                                let v1727 : string = System.Text.RegularExpressions.Regex.Replace (v1707, v1726, v1708)
                                                v1727 
                                                #endif
                                                |> fun x -> _v1709 <- Some x
                                                let v1728 : string = match _v1709 with Some x -> x | None -> failwith "base.run_target / _v1709=None"
                                                v1728
                                        let v1730 : bool = v1704 = false
                                        if v1730 then
                                            let v1731 : string = $"{v1729}\n\n{v1703}\n"
                                            method24(v1675, v1731)
                                        let v1732 : string = $"bun run \"{v1675}\""
                                        let v1733 : string = "PATH"
                                        let v1734 : string = method2(v1733)
                                        let v1735 : bool = v1734 = ""
                                        let v1762 : US3 =
                                            if v1735 then
                                                US3_1
                                            else
                                                let v1737 : bool = true
                                                let mutable _v1737 : bool option = None 
                                                
#if FABLE_COMPILER || WASM || CONTRACT
                                                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                                let v1738 : string = "cfg!(windows)"
                                                let v1739 : bool = Fable.Core.RustInterop.emitRustExpr () v1738 
                                                v1739 
                                                #endif
#if FABLE_COMPILER_RUST && WASM
                                                let v1740 : string = "cfg!(windows)"
                                                let v1741 : bool = Fable.Core.RustInterop.emitRustExpr () v1740 
                                                v1741 
                                                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                                                let v1742 : string = "cfg!(windows)"
                                                let v1743 : bool = Fable.Core.RustInterop.emitRustExpr () v1742 
                                                v1743 
                                                #endif
#if FABLE_COMPILER_TYPESCRIPT
                                                let v1744 : US10 = US10_0
                                                let v1745 : US11 = US11_3(v1744)
                                                let v1746 : string = $"platform.is_windows / target: {v1745}"
                                                let v1747 : bool = failwith<bool> v1746
                                                v1747 
                                                #endif
#if FABLE_COMPILER_PYTHON
                                                let v1748 : US10 = US10_0
                                                let v1749 : US11 = US11_4(v1748)
                                                let v1750 : string = $"platform.is_windows / target: {v1749}"
                                                let v1751 : bool = failwith<bool> v1750
                                                v1751 
                                                #endif
#else
                                                let v1752 : System.Runtime.InteropServices.OSPlatform = System.Runtime.InteropServices.OSPlatform.Windows
                                                let v1753 : (System.Runtime.InteropServices.OSPlatform -> bool) = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform
                                                let v1754 : bool = v1753 v1752
                                                v1754 
                                                #endif
                                                |> fun x -> _v1737 <- Some x
                                                let v1755 : bool = match _v1737 with Some x -> x | None -> failwith "base.run_target / _v1737=None"
                                                let v1758 : string =
                                                    if v1755 then
                                                        let v1756 : string = ";"
                                                        v1756
                                                    else
                                                        let v1757 : string = ":"
                                                        v1757
                                                let v1759 : string = "~/.bun/bin"
                                                let v1760 : string = $"{v1759}{v1758}{v1734}"
                                                US3_0(v1760)
                                        let v1768 : UH4 =
                                            match v1762 with
                                            | US3_1 -> (* None *)
                                                UH4_0
                                            | US3_0(v1763) -> (* Some *)
                                                let v1764 : UH4 = UH4_0
                                                UH4_1(v1733, v1763, v1764)
                                        let v1769 : string = "TRACE_LEVEL"
                                        let v1770 : string = "Verbose"
                                        let v1771 : UH4 = UH4_0
                                        let v1772 : UH4 = UH4_1(v1769, v1770, v1771)
                                        let v1773 : UH4 = method113(v1768, v1772)
                                        let v1774 : struct (string * string) list = []
                                        let v1775 : struct (string * string) list = method114(v1773, v1774)
                                        let v1776 : (struct (string * string) list -> (struct (string * string) [])) = List.toArray
                                        let v1777 : (struct (string * string) []) = v1776 v1775
                                        let v1778 : System.Threading.CancellationToken option = None
                                        let v1779 : (struct (string * string) []) = [||]
                                        let v1780 : (struct (bool * string * int32) -> Async<unit>) option = None
                                        let v1781 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = None
                                        let v1782 : string option = None
                                        let v1788 : Result<string, string> =
                                            match v1571 with
                                            | US12_1(v1785) -> (* Error *)
                                                let v1786 : Result<string, string> = Error v1785 
                                                v1786
                                            | US12_0(v1783) -> (* Ok *)
                                                let v1784 : Result<string, string> = Ok v1783 
                                                v1784
                                        let v1789 : string = "v1788.ok()"
                                        let v1790 : string option = Fable.Core.RustInterop.emitRustExpr () v1789 
                                        let v1791 : bool = true
                                        let struct (v1792 : int32, v1793 : string) = method28(v1778, v1732, v1777, v1780, v1781, v1791, v1790)
                                        let v1794 : int32 = v1777.Length
                                        let v1795 : (string []) = Array.zeroCreate<string> (v1794)
                                        let v1796 : Mut4 = {l0 = 0} : Mut4
                                        while method32(v1794, v1796) do
                                            let v1798 : int32 = v1796.l0
                                            let struct (v1799 : string, v1800 : string) = v1777.[int v1798]
                                            let v1801 : string = $"$env:{v1799}=''{v1800}''"
                                            v1795.[int v1798] <- v1801
                                            let v1802 : int32 = v1798 + 1
                                            v1796.l0 <- v1802
                                            ()
                                        let v1803 : ((string []) -> string seq) = Seq.ofArray
                                        let v1804 : string seq = v1803 v1795
                                        let v1805 : (string -> (string seq -> string)) = String.concat
                                        let v1806 : string = ";"
                                        let v1807 : (string seq -> string) = v1805 v1806
                                        let v1808 : string = v1807 v1804
                                        let v1809 : string = $"pwsh -c '{v1808}; {v1732}'"
                                        let v1810 : bool = v1792 = 0
                                        if v1810 then
                                            let v1811 : (unit -> string) = closure103(v1793)
                                            let v1812 : (string -> US3) = closure45()
                                            let v1813 : (exn -> US3) = closure104(v1675, v1793, v1809)
                                            let v1814 : US3 = try v1811 () |> v1812 with ex -> v1813 ex 
                                            let v1819 : string option =
                                                match v1814 with
                                                | US3_1 -> (* None *)
                                                    let v1817 : string option = None
                                                    v1817
                                                | US3_0(v1815) -> (* Some *)
                                                    let v1816 : string option = Some v1815 
                                                    v1816
                                            let v1820 : string = "$0.unwrap()"
                                            let v1821 : string = Fable.Core.RustInterop.emitRustExpr v1819 v1820 
                                            let v1822 : US3 = US3_0(v1729)
                                            let v1823 : US3 = US3_0(v1365)
                                            let v1824 : US3 = US3_0(v1821)
                                            struct (v1822, v1823, v1824)
                                        else
                                            let v1825 : US0 = US0_4
                                            let v1826 : (unit -> string) = closure107()
                                            let v1827 : (unit -> string) = closure108(v1675, v1793, v1792, v1809)
                                            method5(v1825, v1826, v1827)
                                            let v1828 : US3 = US3_1
                                            let v1829 : US3 = US3_0(v1365)
                                            let v1830 : US3 = US3_1
                                            struct (v1828, v1829, v1830)
                                else
                                    let v1837 : string = "fable_library_rust::String_::fromString($0)"
                                    let v1838 : string = Fable.Core.RustInterop.emitRustExpr v13 v1837 
                                    let v1840 : bool = v1838 = "python"
                                    if v1840 then
                                        let v1841 : string = method63()
                                        let v1842 : string = "&*$0"
                                        let v1843 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1841 v1842 
                                        let v1844 : string = "clap::ArgMatches::get_one(&$0, v1843).cloned()"
                                        let v1845 : std_string_String option = Fable.Core.RustInterop.emitRustExpr v14 v1844 
                                        let v1846 : US5 option = None
                                        let _v1846 = ref v1846 
                                        match v1845 with
                                        | Some x -> (
                                        (fun () ->
                                        (fun () ->
                                        let v1847 : std_string_String = x
                                        let v1848 : US5 = US5_0(v1847)
                                        v1848 
                                        )
                                        |> fun x -> x () |> Some
                                        ) () ) | None -> None
                                        |> fun x -> _v1846.Value <- x
                                        let v1849 : US5 option = _v1846.Value 
                                        let v1850 : US5 = US5_1
                                        let v1851 : US5 = v1849 |> Option.defaultValue v1850 
                                        let v1855 : std_string_String =
                                            match v1851 with
                                            | US5_1 -> (* None *)
                                                failwith<std_string_String> "Option does not have a value."
                                            | US5_0(v1852) -> (* Some *)
                                                v1852
                                        let v1856 : string = "fable_library_rust::String_::fromString($0)"
                                        let v1857 : string = Fable.Core.RustInterop.emitRustExpr v1855 v1856 
                                        let v1858 : string = method13()
                                        let v1859 : string = "&*$0"
                                        let v1860 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1858 v1859 
                                        let v1861 : string = "clap::ArgMatches::get_many(&$0, v1860).map(|x| x.cloned().into_iter().collect())"
                                        let v1862 : Vec<std_string_String> option = Fable.Core.RustInterop.emitRustExpr v14 v1861 
                                        let v1863 : US9 option = None
                                        let _v1863 = ref v1863 
                                        match v1862 with
                                        | Some x -> (
                                        (fun () ->
                                        (fun () ->
                                        let v1864 : Vec<std_string_String> = x
                                        let v1865 : US9 = US9_0(v1864)
                                        v1865 
                                        )
                                        |> fun x -> x () |> Some
                                        ) () ) | None -> None
                                        |> fun x -> _v1863.Value <- x
                                        let v1866 : US9 option = _v1863.Value 
                                        let v1867 : US9 = US9_1
                                        let v1868 : US9 = v1866 |> Option.defaultValue v1867 
                                        let v1869 : (std_string_String []) = [||]
                                        let v1870 : string = "$0.to_vec()"
                                        let v1871 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr v1869 v1870 
                                        let v1874 : Vec<std_string_String> =
                                            match v1868 with
                                            | US9_1 -> (* None *)
                                                v1871
                                            | US9_0(v1872) -> (* Some *)
                                                v1872
                                        let v1876 : bool =
                                            match v0 with
                                            | US0_0 -> (* Verbose *)
                                                true
                                            | _ ->
                                                false
                                        let v1877 : bool = true
                                        let mutable _v1877 : string option = None 
                                        
#if FABLE_COMPILER || WASM || CONTRACT
                                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                        let v1878 : bool = true
                                        let mutable _v1878 : Vec<uint8> option = None 
                                        
#if FABLE_COMPILER || WASM || CONTRACT
                                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                        let v1879 : string = "std::fs::read(&*$0).unwrap()"
                                        let v1880 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v1857 v1879 
                                        v1880 
                                        #endif
#if FABLE_COMPILER_RUST && WASM
                                        let v1881 : Vec<uint8> = null |> unbox<Vec<uint8>>
                                        v1881 
                                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                                        let v1882 : Vec<uint8> = null |> unbox<Vec<uint8>>
                                        v1882 
                                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                                        let v1883 : Vec<uint8> = null |> unbox<Vec<uint8>>
                                        v1883 
                                        #endif
#if FABLE_COMPILER_PYTHON
                                        let v1884 : Vec<uint8> = null |> unbox<Vec<uint8>>
                                        v1884 
                                        #endif
#else
                                        let v1885 : (uint8 []) = v1857 |> System.IO.File.ReadAllBytes
                                        let v1886 : string = "$0.to_vec()"
                                        let v1887 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v1885 v1886 
                                        v1887 
                                        #endif
                                        |> fun x -> _v1878 <- Some x
                                        let v1888 : Vec<uint8> = match _v1878 with Some x -> x | None -> failwith "base.run_target / _v1878=None"
                                        let v1889 : string = "std::string::String::from_utf8(v1888)"
                                        let v1890 : Result<std_string_String, std_string_FromUtf8Error> = Fable.Core.RustInterop.emitRustExpr () v1889 
                                        let v1891 : string = "$0.unwrap()"
                                        let v1892 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1890 v1891 
                                        let v1893 : string = "fable_library_rust::String_::fromString($0)"
                                        let v1894 : string = Fable.Core.RustInterop.emitRustExpr v1892 v1893 
                                        v1894 
                                        #endif
#if FABLE_COMPILER_RUST && WASM
                                        let v1895 : string = null |> unbox<string>
                                        v1895 
                                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                                        let v1896 : string = null |> unbox<string>
                                        v1896 
                                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                                        let v1897 : string = null |> unbox<string>
                                        v1897 
                                        #endif
#if FABLE_COMPILER_PYTHON
                                        let v1898 : string = null |> unbox<string>
                                        v1898 
                                        #endif
#else
                                        let v1899 : string = v1857 |> System.IO.File.ReadAllText
                                        v1899 
                                        #endif
                                        |> fun x -> _v1877 <- Some x
                                        let v1900 : string = match _v1877 with Some x -> x | None -> failwith "base.run_target / _v1877=None"
                                        let v1901 : string = "py"
                                        let v1902 : string = $"%A{struct (v1901, v1900)}"
                                        let v1903 : string = method80(v1902)
                                        let v1904 : string = __SOURCE_DIRECTORY__
                                        let v1905 : string = "polyglot"
                                        let v1906 : string = ".paket"
                                        let v1907 : string = method14(v1905, v1906)
                                        let v1908 : US12 = method17(v1907, v1904)
                                        let v1917 : US3 =
                                            match v1908 with
                                            | US12_1(v1911) -> (* Error *)
                                                let v1912 : US0 = US0_3
                                                let v1913 : (unit -> string) = closure10()
                                                let v1914 : (unit -> string) = closure11(v1911)
                                                method5(v1912, v1913, v1914)
                                                US3_1
                                            | US12_0(v1909) -> (* Ok *)
                                                US3_0(v1909)
                                        let v1933 : US3 =
                                            match v1917 with
                                            | US3_1 -> (* None *)
                                                let v1920 : string = method22()
                                                let v1921 : string = method14(v1905, v1906)
                                                let v1922 : US12 = method17(v1921, v1920)
                                                match v1922 with
                                                | US12_1(v1925) -> (* Error *)
                                                    let v1926 : US0 = US0_3
                                                    let v1927 : (unit -> string) = closure10()
                                                    let v1928 : (unit -> string) = closure11(v1925)
                                                    method5(v1926, v1927, v1928)
                                                    US3_1
                                                | US12_0(v1923) -> (* Ok *)
                                                    US3_0(v1923)
                                            | US3_0(v1918) -> (* Some *)
                                                US3_0(v1918)
                                        let v1937 : string =
                                            match v1933 with
                                            | US3_1 -> (* None *)
                                                failwith<string> "Option does not have a value."
                                            | US3_0(v1934) -> (* Some *)
                                                v1934
                                        let v1938 : string = method14(v1937, v1905)
                                        let v1939 : string = "target/spiral_builder"
                                        let v1940 : string = method14(v1938, v1939)
                                        let v1941 : string = "spiral_builder"
                                        let v1942 : string = method14(v1940, v1941)
                                        let v1943 : string = "packages"
                                        let v1944 : string = method14(v1942, v1943)
                                        let v1945 : string = method14(v1944, v1903)
                                        let v1946 : System.IDisposable = method82(v1945)
                                        let v1947 : string = $"{v1941}.fs"
                                        let v1948 : string = method14(v1945, v1947)
                                        let v1949 : string = method70(v1948)
                                        method24(v1949, v1900)
                                        let v1950 : string list = []
                                        let v1951 : string seq = seq { for i = 0 to v1950.Length - 1 do yield v1950.[i] }
                                        let v1952 : (string -> (string seq -> string)) = String.concat
                                        let v1953 : string = "\\n        "
                                        let v1954 : (string seq -> string) = v1952 v1953
                                        let v1955 : string = v1954 v1951
                                        let v1956 : string = "Fable.Core"
                                        let v1957 : string = $"<PackageReference Include=\"{v1956}\" Version=\"*\" />"
                                        let v1958 : string list = []
                                        let v1959 : string list = v1957 :: v1958 
                                        let v1960 : string seq = seq { for i = 0 to v1959.Length - 1 do yield v1959.[i] }
                                        let v1961 : (string -> (string seq -> string)) = String.concat
                                        let v1962 : (string seq -> string) = v1961 v1953
                                        let v1963 : string = v1962 v1960
                                        let v1964 : string = $"{v1941}.fsproj"
                                        let v1965 : string = method14(v1945, v1964)
                                        let v1966 : string = method70(v1965)
                                        let v1967 : string = $"<Project Sdk=\"Microsoft.NET.Sdk\">"
                                        let v1968 : string = $"<PropertyGroup>"
                                        let v1969 : string = "\n"
                                        let v1970 : string = v1967 + v1969 
                                        let v1971 : string = v1970 + v1968 
                                        let v1972 : string = $"    <TargetFramework>net9.0</TargetFramework>"
                                        let v1973 : string = v1971 + v1969 
                                        let v1974 : string = v1973 + v1972 
                                        let v1975 : string = $"    <LangVersion>preview</LangVersion>"
                                        let v1976 : string = v1974 + v1969 
                                        let v1977 : string = v1976 + v1975 
                                        let v1978 : string = $"    <RollForward>Major</RollForward>"
                                        let v1979 : string = v1977 + v1969 
                                        let v1980 : string = v1979 + v1978 
                                        let v1981 : string = $"    <TargetLatestRuntimePatch>true</TargetLatestRuntimePatch>"
                                        let v1982 : string = v1980 + v1969 
                                        let v1983 : string = v1982 + v1981 
                                        let v1984 : string = $"    <PublishAot>false</PublishAot>"
                                        let v1985 : string = v1983 + v1969 
                                        let v1986 : string = v1985 + v1984 
                                        let v1987 : string = $"    <PublishTrimmed>false</PublishTrimmed>"
                                        let v1988 : string = v1986 + v1969 
                                        let v1989 : string = v1988 + v1987 
                                        let v1990 : string = $"    <PublishSingleFile>true</PublishSingleFile>"
                                        let v1991 : string = v1989 + v1969 
                                        let v1992 : string = v1991 + v1990 
                                        let v1993 : string = $"    <SelfContained>true</SelfContained>"
                                        let v1994 : string = v1992 + v1969 
                                        let v1995 : string = v1994 + v1993 
                                        let v1996 : string = $"    <Version>0.0.1-alpha.1</Version>"
                                        let v1997 : string = v1995 + v1969 
                                        let v1998 : string = v1997 + v1996 
                                        let v1999 : string = $"    <OutputType>Exe</OutputType>"
                                        let v2000 : string = v1998 + v1969 
                                        let v2001 : string = v2000 + v1999 
                                        let v2002 : string = $"</PropertyGroup>"
                                        let v2003 : string = v2001 + v1969 
                                        let v2004 : string = v2003 + v2002 
                                        let v2005 : string = $"<PropertyGroup Condition=\"$([MSBuild]::IsOSPlatform('FreeBSD'))\">"
                                        let v2006 : string = v2004 + v1969 
                                        let v2007 : string = v2006 + v2005 
                                        let v2008 : string = $"    <DefineConstants>_FREEBSD</DefineConstants>"
                                        let v2009 : string = v2007 + v1969 
                                        let v2010 : string = v2009 + v2008 
                                        let v2011 : string = $"</PropertyGroup>"
                                        let v2012 : string = v2010 + v1969 
                                        let v2013 : string = v2012 + v2011 
                                        let v2014 : string = $"<PropertyGroup Condition=\"$([MSBuild]::IsOSPlatform('Linux'))\">"
                                        let v2015 : string = v2013 + v1969 
                                        let v2016 : string = v2015 + v2014 
                                        let v2017 : string = $"    <DefineConstants>_LINUX</DefineConstants>"
                                        let v2018 : string = v2016 + v1969 
                                        let v2019 : string = v2018 + v2017 
                                        let v2020 : string = $"</PropertyGroup>"
                                        let v2021 : string = v2019 + v1969 
                                        let v2022 : string = v2021 + v2020 
                                        let v2023 : string = $"<PropertyGroup Condition=\"$([MSBuild]::IsOSPlatform('OSX'))\">"
                                        let v2024 : string = v2022 + v1969 
                                        let v2025 : string = v2024 + v2023 
                                        let v2026 : string = $"    <DefineConstants>_OSX</DefineConstants>"
                                        let v2027 : string = v2025 + v1969 
                                        let v2028 : string = v2027 + v2026 
                                        let v2029 : string = $"</PropertyGroup>"
                                        let v2030 : string = v2028 + v1969 
                                        let v2031 : string = v2030 + v2029 
                                        let v2032 : string = $"<PropertyGroup Condition=\"$([MSBuild]::IsOSPlatform('Windows'))\">"
                                        let v2033 : string = v2031 + v1969 
                                        let v2034 : string = v2033 + v2032 
                                        let v2035 : string = $"    <DefineConstants>_WINDOWS</DefineConstants>"
                                        let v2036 : string = v2034 + v1969 
                                        let v2037 : string = v2036 + v2035 
                                        let v2038 : string = $"</PropertyGroup>"
                                        let v2039 : string = v2037 + v1969 
                                        let v2040 : string = v2039 + v2038 
                                        let v2041 : string = $"<ItemGroup>"
                                        let v2042 : string = v2040 + v1969 
                                        let v2043 : string = v2042 + v2041 
                                        let v2044 : string = $"    {v1955}"
                                        let v2045 : string = v2043 + v1969 
                                        let v2046 : string = v2045 + v2044 
                                        let v2047 : string = $"    <Compile Include=\"{v1949}\" />"
                                        let v2048 : string = v2046 + v1969 
                                        let v2049 : string = v2048 + v2047 
                                        let v2050 : string = $"</ItemGroup>"
                                        let v2051 : string = v2049 + v1969 
                                        let v2052 : string = v2051 + v2050 
                                        let v2053 : string = $"<ItemGroup>"
                                        let v2054 : string = v2052 + v1969 
                                        let v2055 : string = v2054 + v2053 
                                        let v2056 : string = $"    {v1963}"
                                        let v2057 : string = v2055 + v1969 
                                        let v2058 : string = v2057 + v2056 
                                        let v2059 : string = $"</ItemGroup>"
                                        let v2060 : string = v2058 + v1969 
                                        let v2061 : string = v2060 + v2059 
                                        let v2062 : string = $"</Project>"
                                        let v2063 : string = v2061 + v1969 
                                        let v2064 : string = v2063 + v2062 
                                        method24(v1966, v2064)
                                        let v2065 : string = method23(v1966)
                                        let v2066 : string = __SOURCE_DIRECTORY__
                                        let v2067 : string = method14(v1905, v1906)
                                        let v2068 : US12 = method17(v2067, v2066)
                                        let v2077 : US3 =
                                            match v2068 with
                                            | US12_1(v2071) -> (* Error *)
                                                let v2072 : US0 = US0_3
                                                let v2073 : (unit -> string) = closure10()
                                                let v2074 : (unit -> string) = closure11(v2071)
                                                method5(v2072, v2073, v2074)
                                                US3_1
                                            | US12_0(v2069) -> (* Ok *)
                                                US3_0(v2069)
                                        let v2093 : US3 =
                                            match v2077 with
                                            | US3_1 -> (* None *)
                                                let v2080 : string = method22()
                                                let v2081 : string = method14(v1905, v1906)
                                                let v2082 : US12 = method17(v2081, v2080)
                                                match v2082 with
                                                | US12_1(v2085) -> (* Error *)
                                                    let v2086 : US0 = US0_3
                                                    let v2087 : (unit -> string) = closure10()
                                                    let v2088 : (unit -> string) = closure11(v2085)
                                                    method5(v2086, v2087, v2088)
                                                    US3_1
                                                | US12_0(v2083) -> (* Ok *)
                                                    US3_0(v2083)
                                            | US3_0(v2078) -> (* Some *)
                                                US3_0(v2078)
                                        let v2097 : string =
                                            match v2093 with
                                            | US3_1 -> (* None *)
                                                failwith<string> "Option does not have a value."
                                            | US3_0(v2094) -> (* Some *)
                                                v2094
                                        let v2098 : string = method14(v2097, v1905)
                                        let v2099 : string = method22()
                                        let v2100 : (unit -> string) = v2099.ToLower
                                        let v2101 : string = v2100 ()
                                        let v2102 : (unit -> string) = v2098.ToLower
                                        let v2103 : string = v2102 ()
                                        let v2104 : bool = v2101.StartsWith v2103 
                                        let v2107 : US12 =
                                            if v2104 then
                                                US12_1(v2103)
                                            else
                                                US12_0(v2103)
                                        let v2113 : Result<string, string> =
                                            match v2107 with
                                            | US12_1(v2110) -> (* Error *)
                                                let v2111 : Result<string, string> = Error v2110 
                                                v2111
                                            | US12_0(v2108) -> (* Ok *)
                                                let v2109 : Result<string, string> = Ok v2108 
                                                v2109
                                        let v2114 : string = "true; let _result = $0.unwrap_or_else(|x| { //"
                                        let v2115 : bool = Fable.Core.RustInterop.emitRustExpr v2113 v2114 
                                        let v2116 : string = "x"
                                        let v2117 : string = Fable.Core.RustInterop.emitRustExpr () v2116 
                                        let v2118 : string = "true; $0 })"
                                        let v2119 : bool = Fable.Core.RustInterop.emitRustExpr v2117 v2118 
                                        let v2120 : string = "_result"
                                        let v2121 : string = Fable.Core.RustInterop.emitRustExpr () v2120 
                                        let v2122 : string = "lib/python/fable/fable_modules"
                                        let v2123 : string = method14(v2121, v2122)
                                        let v2124 : string = $"fable-library-{v1901}"
                                        let v2125 : string = method14(v2123, v2124)
                                        let v2126 : string = $"fable_modules/fable-library"
                                        let v2127 : string = method14(v2065, v2126)
                                        method98(v2125, v2127)
                                        let struct (v2128 : int32, v2129 : string) = method99(v2065, v1901, v1966, v2107)
                                        let v2130 : bool = v2128 <> 0 
                                        if v2130 then
                                            let v2131 : US0 = US0_4
                                            let v2132 : (unit -> string) = closure109(v2129, v2128)
                                            let v2133 : (unit -> string) = closure6()
                                            method5(v2131, v2132, v2133)
                                            let v2134 : US3 = US3_1
                                            let v2135 : US3 = US3_0(v1901)
                                            let v2136 : US3 = US3_0(v2129)
                                            struct (v2134, v2135, v2136)
                                        else
                                            let v2137 : string = "true; let _result : Vec<_> = v1874.into_iter().map(|x| { //"
                                            let v2138 : bool = Fable.Core.RustInterop.emitRustExpr () v2137 
                                            let v2139 : string = "x"
                                            let v2140 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v2139 
                                            let v2141 : string = "fable_library_rust::String_::fromString($0)"
                                            let v2142 : string = Fable.Core.RustInterop.emitRustExpr v2140 v2141 
                                            let v2143 : string = "="
                                            let v2144 : bool = v2142.Contains v2143 
                                            let v2146 : string =
                                                if v2144 then
                                                    v2142
                                                else
                                                    let v2145 : string = $"\"{v2142}\":\"*\""
                                                    v2145
                                            let v2147 : string = "true; $0 }).collect::<Vec<_>>()"
                                            let v2148 : bool = Fable.Core.RustInterop.emitRustExpr v2146 v2147 
                                            let v2149 : string = "_result"
                                            let v2150 : Vec<string> = Fable.Core.RustInterop.emitRustExpr () v2149 
                                            let v2151 : string = "fable_library_rust::NativeArray_::array_from($0)"
                                            let v2152 : (string []) = Fable.Core.RustInterop.emitRustExpr v2150 v2151 
                                            let v2153 : string seq = seq { for i = 0 to v2152.Length - 1 do yield v2152.[i] }
                                            let v2154 : (string -> (string seq -> string)) = String.concat
                                            let v2155 : string = ",\n"
                                            let v2156 : (string seq -> string) = v2154 v2155
                                            let v2157 : string = v2156 v2153
                                            let v2158 : string = $"{{"
                                            let v2159 : string = $"  \"name\": \"spiral_builder_{v1903}\","
                                            let v2160 : string = v2158 + v2159 
                                            let v2161 : string = $"  \"dependencies\": {{"
                                            let v2162 : string = v2160 + v2161 
                                            let v2163 : string = v2162 + v2157 
                                            let v2164 : string = $"  }},"
                                            let v2165 : string = v2163 + v2164 
                                            let v2166 : string = $"    \"devDependencies\": {{"
                                            let v2167 : string = v2165 + v2166 
                                            let v2168 : string = $"  }},"
                                            let v2169 : string = v2167 + v2168 
                                            let v2170 : string = $"}}"
                                            let v2171 : string = v2169 + v2170 
                                            let v2172 : string = "package.json"
                                            let v2173 : string = method14(v2065, v2172)
                                            let v2174 : string = "../.."
                                            let v2175 : string = method14(v2065, v2174)
                                            let v2176 : string = method14(v2175, v2172)
                                            method24(v2173, v2171)
                                            let v2177 : string = ""
                                            method24(v2176, v2177)
                                            let v2178 : string = $"{v1941}.{v1901}"
                                            let v2179 : string = method14(v2065, v2178)
                                            let v2180 : US0 = US0_1
                                            let v2181 : (unit -> string) = closure110()
                                            let v2182 : (unit -> string) = closure111(v2179)
                                            method5(v2180, v2181, v2182)
                                            let v2183 : bool = true
                                            let mutable _v2183 : string option = None 
                                            
#if FABLE_COMPILER || WASM || CONTRACT
                                            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                            let v2184 : bool = true
                                            let mutable _v2184 : Vec<uint8> option = None 
                                            
#if FABLE_COMPILER || WASM || CONTRACT
                                            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                            let v2185 : string = "std::fs::read(&*$0).unwrap()"
                                            let v2186 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v2179 v2185 
                                            v2186 
                                            #endif
#if FABLE_COMPILER_RUST && WASM
                                            let v2187 : Vec<uint8> = null |> unbox<Vec<uint8>>
                                            v2187 
                                            #endif
#if FABLE_COMPILER_RUST && CONTRACT
                                            let v2188 : Vec<uint8> = null |> unbox<Vec<uint8>>
                                            v2188 
                                            #endif
#if FABLE_COMPILER_TYPESCRIPT
                                            let v2189 : Vec<uint8> = null |> unbox<Vec<uint8>>
                                            v2189 
                                            #endif
#if FABLE_COMPILER_PYTHON
                                            let v2190 : Vec<uint8> = null |> unbox<Vec<uint8>>
                                            v2190 
                                            #endif
#else
                                            let v2191 : (uint8 []) = v2179 |> System.IO.File.ReadAllBytes
                                            let v2192 : string = "$0.to_vec()"
                                            let v2193 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v2191 v2192 
                                            v2193 
                                            #endif
                                            |> fun x -> _v2184 <- Some x
                                            let v2194 : Vec<uint8> = match _v2184 with Some x -> x | None -> failwith "base.run_target / _v2184=None"
                                            let v2195 : string = "std::string::String::from_utf8(v2194)"
                                            let v2196 : Result<std_string_String, std_string_FromUtf8Error> = Fable.Core.RustInterop.emitRustExpr () v2195 
                                            let v2197 : string = "$0.unwrap()"
                                            let v2198 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2196 v2197 
                                            let v2199 : string = "fable_library_rust::String_::fromString($0)"
                                            let v2200 : string = Fable.Core.RustInterop.emitRustExpr v2198 v2199 
                                            v2200 
                                            #endif
#if FABLE_COMPILER_RUST && WASM
                                            let v2201 : string = null |> unbox<string>
                                            v2201 
                                            #endif
#if FABLE_COMPILER_RUST && CONTRACT
                                            let v2202 : string = null |> unbox<string>
                                            v2202 
                                            #endif
#if FABLE_COMPILER_TYPESCRIPT
                                            let v2203 : string = null |> unbox<string>
                                            v2203 
                                            #endif
#if FABLE_COMPILER_PYTHON
                                            let v2204 : string = null |> unbox<string>
                                            v2204 
                                            #endif
#else
                                            let v2205 : string = v2179 |> System.IO.File.ReadAllText
                                            v2205 
                                            #endif
                                            |> fun x -> _v2183 <- Some x
                                            let v2206 : string = match _v2183 with Some x -> x | None -> failwith "base.run_target / _v2183=None"
                                            let v2207 : string = "# spiral_builder.process_python"
                                            let v2208 : bool = v2206.Contains v2207 
                                            let v2236 : string =
                                                if v2208 then
                                                    v2206
                                                else
                                                    let v2209 : string = "\";\".into()"
                                                    let v2210 : string = Fable.Core.RustInterop.emitRustExpr () v2209 
                                                    let v2211 : string = "),)"
                                                    let v2212 : string = v2211 + v2210 
                                                    let v2213 : string = "));"
                                                    let v2214 : string = v2206.Replace (v2212, v2213)
                                                    let v2215 : string = method103()
                                                    let v2216 : bool = true
                                                    let mutable _v2216 : string option = None 
                                                    
#if FABLE_COMPILER || WASM || CONTRACT
                                                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                                    let v2217 : string = method72(v2214)
                                                    let v2218 : string = $"regex::Regex::new(&$0)"
                                                    let v2219 : string = "\\s\\sdefaultOf\\(\\);"
                                                    let v2220 : Result<regex_Regex, regex_Error> = Fable.Core.RustInterop.emitRustExpr v2219 v2218 
                                                    let v2221 : string = "$0.unwrap()"
                                                    let v2222 : regex_Regex = Fable.Core.RustInterop.emitRustExpr v2220 v2221 
                                                    let v2223 : string = $"$0.replace_all(&$1, &*$2)"
                                                    let v2224 : std_borrow_Cow<Str> = Fable.Core.RustInterop.emitRustExpr struct (v2222, v2217, v2215) v2223 
                                                    let v2225 : string = "String::from($0)"
                                                    let v2226 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2224 v2225 
                                                    let v2227 : string = "fable_library_rust::String_::fromString($0)"
                                                    let v2228 : string = Fable.Core.RustInterop.emitRustExpr v2226 v2227 
                                                    v2228 
                                                    #endif
#if FABLE_COMPILER_RUST && WASM
                                                    let v2229 : string = null |> unbox<string>
                                                    v2229 
                                                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                                                    let v2230 : string = null |> unbox<string>
                                                    v2230 
                                                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                                                    let v2231 : string = null |> unbox<string>
                                                    v2231 
                                                    #endif
#if FABLE_COMPILER_PYTHON
                                                    let v2232 : string = null |> unbox<string>
                                                    v2232 
                                                    #endif
#else
                                                    let v2233 : string = method104()
                                                    let v2234 : string = System.Text.RegularExpressions.Regex.Replace (v2214, v2233, v2215)
                                                    v2234 
                                                    #endif
                                                    |> fun x -> _v2216 <- Some x
                                                    let v2235 : string = match _v2216 with Some x -> x | None -> failwith "base.run_target / _v2216=None"
                                                    v2235
                                            let v2237 : bool = v2208 = false
                                            if v2237 then
                                                let v2238 : string = $"{v2236}\n\n{v2207}\n"
                                                method24(v2179, v2238)
                                            let v2239 : string = $"python \"{v2179}\""
                                            let v2240 : string = "TRACE_LEVEL"
                                            let v2241 : string = "Verbose"
                                            let v2242 : (struct (string * string) []) = [|struct (v2240, v2241)|]
                                            let v2243 : System.Threading.CancellationToken option = None
                                            let v2244 : (struct (string * string) []) = [||]
                                            let v2245 : (struct (bool * string * int32) -> Async<unit>) option = None
                                            let v2246 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = None
                                            let v2247 : string option = None
                                            let v2253 : Result<string, string> =
                                                match v2107 with
                                                | US12_1(v2250) -> (* Error *)
                                                    let v2251 : Result<string, string> = Error v2250 
                                                    v2251
                                                | US12_0(v2248) -> (* Ok *)
                                                    let v2249 : Result<string, string> = Ok v2248 
                                                    v2249
                                            let v2254 : string = "v2253.ok()"
                                            let v2255 : string option = Fable.Core.RustInterop.emitRustExpr () v2254 
                                            let v2256 : bool = true
                                            let struct (v2257 : int32, v2258 : string) = method28(v2243, v2239, v2242, v2245, v2246, v2256, v2255)
                                            let v2259 : int32 = v2242.Length
                                            let v2260 : (string []) = Array.zeroCreate<string> (v2259)
                                            let v2261 : Mut4 = {l0 = 0} : Mut4
                                            while method32(v2259, v2261) do
                                                let v2263 : int32 = v2261.l0
                                                let struct (v2264 : string, v2265 : string) = v2242.[int v2263]
                                                let v2266 : string = $"$env:{v2264}=''{v2265}''"
                                                v2260.[int v2263] <- v2266
                                                let v2267 : int32 = v2263 + 1
                                                v2261.l0 <- v2267
                                                ()
                                            let v2268 : ((string []) -> string seq) = Seq.ofArray
                                            let v2269 : string seq = v2268 v2260
                                            let v2270 : (string -> (string seq -> string)) = String.concat
                                            let v2271 : string = ";"
                                            let v2272 : (string seq -> string) = v2270 v2271
                                            let v2273 : string = v2272 v2269
                                            let v2274 : string = $"pwsh -c '{v2273}; {v2239}'"
                                            let v2275 : bool = v2257 = 0
                                            if v2275 then
                                                let v2276 : (unit -> string) = closure112(v2258)
                                                let v2277 : (string -> US3) = closure45()
                                                let v2278 : (exn -> US3) = closure113(v2179, v2258, v2274)
                                                let v2279 : US3 = try v2276 () |> v2277 with ex -> v2278 ex 
                                                let v2284 : string option =
                                                    match v2279 with
                                                    | US3_1 -> (* None *)
                                                        let v2282 : string option = None
                                                        v2282
                                                    | US3_0(v2280) -> (* Some *)
                                                        let v2281 : string option = Some v2280 
                                                        v2281
                                                let v2285 : string = "$0.unwrap()"
                                                let v2286 : string = Fable.Core.RustInterop.emitRustExpr v2284 v2285 
                                                let v2287 : US3 = US3_0(v2236)
                                                let v2288 : US3 = US3_0(v1901)
                                                let v2289 : US3 = US3_0(v2286)
                                                struct (v2287, v2288, v2289)
                                            else
                                                let v2290 : US0 = US0_4
                                                let v2291 : (unit -> string) = closure116()
                                                let v2292 : (unit -> string) = closure117(v2179, v2258, v2257, v2274)
                                                method5(v2290, v2291, v2292)
                                                let v2293 : US3 = US3_1
                                                let v2294 : US3 = US3_0(v1901)
                                                let v2295 : US3 = US3_1
                                                struct (v2293, v2294, v2295)
                                    else
                                        let v2302 : US0 = US0_1
                                        let v2303 : (unit -> string) = closure118()
                                        let v2304 : (unit -> string) = closure119(v14, v13)
                                        method5(v2302, v2303, v2304)
                                        let v2305 : US3 = US3_1
                                        let v2306 : US3 = US3_1
                                        let v2307 : US3 = US3_1
                                        struct (v2305, v2306, v2307)
                        let v2320 : string =
                            match v2315 with
                            | US3_1 -> (* None *)
                                let v2318 : string = ""
                                v2318
                            | US3_0(v2317) -> (* Some *)
                                v2317
                        let v2321 : string = "extension"
                        let v2325 : string =
                            match v2314 with
                            | US3_1 -> (* None *)
                                let v2323 : string = ""
                                v2323
                            | US3_0(v2322) -> (* Some *)
                                v2322
                        let v2326 : string = "code"
                        let v2330 : string =
                            match v2316 with
                            | US3_1 -> (* None *)
                                let v2328 : string = ""
                                v2328
                            | US3_0(v2327) -> (* Some *)
                                v2327
                        let v2331 : string = "output"
                        [|struct (v2321, v2320); struct (v2326, v2325); struct (v2331, v2330)|]
        | _ ->
            let v2336 : string = "extension"
            let v2337 : string = ""
            let v2338 : string = "code"
            let v2339 : string = "output"
            [|struct (v2336, v2337); struct (v2338, v2337); struct (v2339, v2337)|]
    let v2342 : string = "$0.to_vec()"
    let v2343 : Vec<struct (string * string)> = Fable.Core.RustInterop.emitRustExpr v2341 v2342 
    let v2344 : string = "$0.into_iter().map(|x| $1(x.clone())).collect::<Vec<_>>()"
    let v2345 : (struct (string * string) -> (std_string_String * std_string_String)) = closure120()
    let v2346 : Vec<(std_string_String * std_string_String)> = Fable.Core.RustInterop.emitRustExpr struct (v2343, v2345) v2344 
    let v2347 : string = "std::collections::BTreeMap::from_iter(v2346.iter().map(|x| x.as_ref()).map(|&(ref k, ref v)| (k.clone(), v.clone())))"
    let v2348 : std_collections_BTreeMap<std_string_String, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v2347 
    let v2349 : string = "serde_json::to_string(&v2348)"
    let v2350 : Result<std_string_String, serde_json_Error> = Fable.Core.RustInterop.emitRustExpr () v2349 
    let v2351 : (serde_json_Error -> string) = method115()
    let v2352 : string = "$0.map_err(|x| $1(x))"
    let v2353 : Result<std_string_String, string> = Fable.Core.RustInterop.emitRustExpr struct (v2350, v2351) v2352 
    let v2354 : string = "true; let _result = $0.map(|x| { //"
    let v2355 : bool = Fable.Core.RustInterop.emitRustExpr v2353 v2354 
    let v2356 : string = "x"
    let v2357 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v2356 
    let v2358 : string = "fable_library_rust::String_::fromString($0)"
    let v2359 : string = Fable.Core.RustInterop.emitRustExpr v2357 v2358 
    let v2360 : string = "true; $0 })"
    let v2361 : bool = Fable.Core.RustInterop.emitRustExpr v2359 v2360 
    let v2362 : string = "_result"
    let v2363 : Result<string, string> = Fable.Core.RustInterop.emitRustExpr () v2362 
    let v2364 : Result<string, string> = method116(v2363)
    let v2365 : string = ""
    let v2366 : string = "}"
    let v2367 : string = v2365 + v2366 
    let v2368 : string = v2367 + v2366 
    let v2369 : string = v2368 + v2366 
    let v2370 : string = "{"
    let v2371 : string = v2365 + v2370 
    let v2372 : string = v2371 + v2370 
    let v2373 : string = "v2364 " + v2369 + "); " + v2372 + " //"
    Fable.Core.RustInterop.emitRustExpr () v2373 
    let v2374 : string = "__result"
    let v2375 : std_pin_Pin<Box<Dyn<std_future_Future<Result<string, string>>>>> = Fable.Core.RustInterop.emitRustExpr () v2374 
    v2375
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
