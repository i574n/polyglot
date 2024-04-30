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
type IPathJoin = abstract join: [<System.ParamArray>] paths: string[] -> string
type IFsExistsSync = abstract existsSync: path: string -> bool
type IPathDirname = abstract dirname: path: string -> string
module State = let mutable trace_state = None
type [<Struct>] US0 =
    | US0_0 of f0_0 : string
    | US0_1
and [<Struct>] US1 =
    | US1_0
    | US1_1
    | US1_2
    | US1_3
    | US1_4
and Mut0 = {mutable l0 : int64}
and Mut1 = {mutable l0 : bool}
and Mut2 = {mutable l0 : US1}
and Mut3 = {mutable l0 : (string -> unit)}
and [<Struct>] US2 =
    | US2_0 of f0_0 : int64
    | US2_1
and [<Struct>] US3 =
    | US3_0 of f0_0 : int64
    | US3_1
let rec method0 () : clap_Command =
    let v0 : string = "command"
    let v1 : string = "r#\"" + v0 + "\"#"
    let v2 : StaticRef<Str> = Fable.Core.RustInterop.emitRustExpr () v1
    let v3 : string = "clap::Command::new($0)"
    let v4 : clap_Command = Fable.Core.RustInterop.emitRustExpr v2 v3
    let v5 : string = "path"
    let v6 : string = "r#\"" + v5 + "\"#"
    let v7 : StaticRef<Str> = Fable.Core.RustInterop.emitRustExpr () v6
    let v8 : string = "clap::Arg::new($0)"
    let v9 : clap_Arg = Fable.Core.RustInterop.emitRustExpr v7 v8
    let v10 : string = "$0.required($1)"
    let v11 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v9, true) v10
    let v12 : string = "clap::Command::arg($0, $1)"
    let v13 : clap_Command = Fable.Core.RustInterop.emitRustExpr struct (v4, v11) v12
    let v14 : string = "out_dir"
    let v15 : string = "r#\"" + v14 + "\"#"
    let v16 : StaticRef<Str> = Fable.Core.RustInterop.emitRustExpr () v15
    let v17 : string = "clap::Arg::new($0)"
    let v18 : clap_Arg = Fable.Core.RustInterop.emitRustExpr v16 v17
    let v19 : string = "$0.required($1)"
    let v20 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v18, true) v19
    let v21 : string = "clap::Command::arg($0, $1)"
    let v22 : clap_Command = Fable.Core.RustInterop.emitRustExpr struct (v13, v20) v21
    v22
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
    let v0 : string = "polyglot"
    v0
and method2 () : string =
    let v0 : string = ".paket"
    v0
and method3 () : string =
    let v0 : string = "polyglot"
    v0
and method4 () : string =
    let v0 : string = ".paket"
    v0
and method6 (v0 : string) : string =
    v0
and method7 (v0 : string) : string =
    v0
and method8 (v0 : string) : string =
    v0
and closure2 () (v0 : string) : string option =
    let v1 : US0 option = None
    let v2 : bool = true in let mutable _v1 = v1
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : string = method6(v0)
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
    let v30 : US0 = US0_0(v29)
    v30
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v31 : US0 = null |> unbox<US0>
    v31
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v32 : US0 = null |> unbox<US0>
    v32
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v33 : string = "path"
    let v34 : IPathDirname = Fable.Core.JsInterop.importAll v33
    let v35 : string = "v34.dirname($0)"
    let v36 : string = Fable.Core.JsInterop.emitJsExpr v0 v35
    let v37 : US0 = US0_0(v36)
    v37
#endif
    
#if FABLE_COMPILER_PYTHON
    let v38 : US0 = null |> unbox<US0>
    v38
#endif
    
#else
    let v39 : (string -> System.IO.DirectoryInfo) = System.IO.Directory.GetParent
    let v40 : System.IO.DirectoryInfo = v39 v0
    let v41 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    let v42 : bool = v40 = v41
    let v54 : US0 =
        if v42 then
            US0_1
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
            US0_0(v52)
    v54
#endif
    |> fun x -> _v1 <- Some x
    let v55 : US0 = _v1.Value
    match v55 with
    | US0_1 -> (* None *)
        let v58 : string option = None
        v58
    | US0_0(v56) -> (* Some *)
        let v57 : string option = Some v56 
        v57
and method9 () : (string -> string option) =
    closure2()
and closure3 () (v0 : string) : US0 =
    US0_0(v0)
and method10 () : (string -> US0) =
    closure3()
and method11 (v0 : string, v1 : string, v2 : string) : string =
    let v3 : string option = None
    let v4 : bool = true in let mutable _v3 = v3
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v5 : string = method6(v2)
    let v6 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v7 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v6
    let v8 : string = "String::from($0)"
    let v9 : std_string_String = Fable.Core.RustInterop.emitRustExpr v7 v8
    let v10 : string = "std::path::PathBuf::from($0)"
    let v11 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v9 v10
    let v12 : string = method6(v0)
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
    let v39 : string = method7(v2)
    let v40 : string = method8(v0)
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
    let v48 : string = method6(v45)
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
        let v70 : (string -> string option) = method9()
        let v71 : string option = v70 v2
        let v72 : (string -> US0) = method10()
        let v73 : US0 = US0_1
        let v74 : US0 = v71 |> Option.map v72 |> Option.defaultValue v73 
        match v74 with
        | US0_1 -> (* None *)
            let v77 : string = $"""No parent for {if false then "file" else "dir"} '{v0}' at '{v1}' (until '{v2}')"""
            failwith<string> v77
        | US0_0(v75) -> (* Some *)
            method11(v0, v1, v75)
and method5 (v0 : string, v1 : string) : string =
    let v2 : string option = None
    let v3 : bool = true in let mutable _v2 = v2
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v4 : string = method6(v1)
    let v5 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v6 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v4 v5
    let v7 : string = "String::from($0)"
    let v8 : std_string_String = Fable.Core.RustInterop.emitRustExpr v6 v7
    let v9 : string = "std::path::PathBuf::from($0)"
    let v10 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v8 v9
    let v11 : string = method6(v0)
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
    let v38 : string = method7(v1)
    let v39 : string = method8(v0)
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
    let v47 : string = method6(v44)
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
        let v69 : (string -> string option) = method9()
        let v70 : string option = v69 v1
        let v71 : (string -> US0) = method10()
        let v72 : US0 = US0_1
        let v73 : US0 = v70 |> Option.map v71 |> Option.defaultValue v72 
        match v73 with
        | US0_1 -> (* None *)
            let v76 : string = $"""No parent for {if false then "file" else "dir"} '{v0}' at '{v1}' (until '{v1}')"""
            failwith<string> v76
        | US0_0(v74) -> (* Some *)
            method11(v0, v1, v74)
and method12 () : string =
    let v0 : string = "polyglot"
    v0
and closure4 () () : string =
    let v0 : string = $"rust_builder.main"
    v0
and closure6 () () : string =
    let v0 : string = ""
    v0
and closure5 (v0 : (string []), v1 : string) () : string =
    let v2 : (unit -> string) = closure6()
    let v3 : string = $"args: {v0} / repository_root: {v1} / {v2 ()}"
    v3
and closure9 () (v0 : string) : unit =
    ()
and method14 (v0 : int64 option) : int64 option =
    v0
and method15 (v0 : int64 option) : int64 option =
    v0
and closure8 () () : struct (Mut0 * Mut1 * Mut2 * int64 option * Mut3) =
    let v0 : Mut1 = {l0 = true} : Mut1
    let v1 : Mut0 = {l0 = 0L} : Mut0
    let v2 : US1 = US1_0
    let v3 : Mut2 = {l0 = v2} : Mut2
    let v4 : (string -> unit) = closure9()
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
    let v25 : US2 =
        if v19 then
            let v20 : System.DateTime = System.DateTime.Now
            let v21 : (System.DateTime -> int64) = _.Ticks
            let v22 : int64 = v21 v20
            US2_0(v22)
        else
            US2_1
    let v30 : int64 option =
        match v25 with
        | US2_1 -> (* None *)
            let v28 : int64 option = None
            v28
        | US2_0(v26) -> (* Some *)
            let v27 : int64 option = Some v26 
            v27
    let v31 : int64 option = method14(v30)
    v31 
    #else
    let v32 : int64 option = None
    let v33 : int64 option = method15(v32)
    v33 
    #endif
    |> fun x -> _v6 <- Some x
    let v34 : int64 option = _v6.Value
    struct (v1, v0, v3, v34, v5)
and closure10 () (v0 : int64) : US3 =
    US3_0(v0)
and method16 () : (int64 -> US3) =
    closure10()
and method17 () : string =
    let v0 : string = ""
    v0
and closure7 (v0 : US1, v1 : (unit -> string), v2 : (unit -> string)) () : string =
    let v3 : (unit -> struct (Mut0 * Mut1 * Mut2 * int64 option * Mut3)) = closure8()
    if State.trace_state.IsNone then State.trace_state <- v3 () |> Some
    let struct (v4 : Mut0, v5 : Mut1, v6 : Mut2, v7 : int64 option, v8 : Mut3) = State.trace_state.Value
    let v9 : string option = None
    let v10 : bool = true in let mutable _v9 = v9
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v11 : (int64 -> US3) = method16()
    let v12 : US3 = US3_1
    let v13 : US3 = v7 |> Option.map v11 |> Option.defaultValue v12 
    let v31 : System.DateTime =
        match v13 with
        | US3_1 -> (* None *)
            let v29 : System.DateTime = System.DateTime.Now
            v29
        | US3_0(v14) -> (* Some *)
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
    let v34 : string = method17()
    v34
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v35 : string = method17()
    v35
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v36 : string = method17()
    v36
#endif
    
#if FABLE_COMPILER_PYTHON
    let v37 : string = method17()
    v37
#endif
    
#else
    let v38 : (int64 -> US3) = method16()
    let v39 : US3 = US3_1
    let v40 : US3 = v7 |> Option.map v38 |> Option.defaultValue v39 
    let v58 : System.DateTime =
        match v40 with
        | US3_1 -> (* None *)
            let v56 : System.DateTime = System.DateTime.Now
            v56
        | US3_0(v41) -> (* Some *)
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
        | US1_4 -> (* Critical *)
            let v67 : string = "Critical"
            v67
        | US1_1 -> (* Debug *)
            let v64 : string = "Debug"
            v64
        | US1_2 -> (* Info *)
            let v65 : string = "Info"
            v65
        | US1_0 -> (* Verbose *)
            let v63 : string = "Verbose"
            v63
        | US1_3 -> (* Warning *)
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
        | US1_4 -> (* Critical *)
            let v85 : string = "inline_colorization::color_bright_red"
            let v86 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v85
            v86
        | US1_1 -> (* Debug *)
            let v79 : string = "inline_colorization::color_bright_blue"
            let v80 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v79
            v80
        | US1_2 -> (* Info *)
            let v81 : string = "inline_colorization::color_bright_green"
            let v82 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v81
            v82
        | US1_0 -> (* Verbose *)
            let v77 : string = "inline_colorization::color_bright_black"
            let v78 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v77
            v78
        | US1_3 -> (* Warning *)
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
        | US1_4 -> (* Critical *)
            let v109 : string = "inline_colorization::color_bright_red"
            let v110 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v109
            v110
        | US1_1 -> (* Debug *)
            let v103 : string = "inline_colorization::color_bright_blue"
            let v104 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v103
            v104
        | US1_2 -> (* Info *)
            let v105 : string = "inline_colorization::color_bright_green"
            let v106 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v105
            v106
        | US1_0 -> (* Verbose *)
            let v101 : string = "inline_colorization::color_bright_black"
            let v102 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v101
            v102
        | US1_3 -> (* Warning *)
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
        | US1_4 -> (* Critical *)
            let v133 : string = "inline_colorization::color_bright_red"
            let v134 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v133
            v134
        | US1_1 -> (* Debug *)
            let v127 : string = "inline_colorization::color_bright_blue"
            let v128 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v127
            v128
        | US1_2 -> (* Info *)
            let v129 : string = "inline_colorization::color_bright_green"
            let v130 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v129
            v130
        | US1_0 -> (* Verbose *)
            let v125 : string = "inline_colorization::color_bright_black"
            let v126 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v125
            v126
        | US1_3 -> (* Warning *)
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
and method18 (v0 : US1, v1 : (unit -> string)) : unit =
    let v2 : (unit -> struct (Mut0 * Mut1 * Mut2 * int64 option * Mut3)) = closure8()
    if State.trace_state.IsNone then State.trace_state <- v2 () |> Some
    let struct (v3 : Mut0, v4 : Mut1, v5 : Mut2, v6 : int64 option, v7 : Mut3) = State.trace_state.Value
    if State.trace_state.IsNone then State.trace_state <- v2 () |> Some
    let struct (v8 : Mut0, v9 : Mut1, v10 : Mut2, v11 : int64 option, v12 : Mut3) = State.trace_state.Value
    let v13 : US1 = v10.l0
    let v14 : bool = v9.l0
    let v15 : bool = v14 = false
    let v19 : bool =
        if v15 then
            false
        else
            let v16 : int32 = [ US1_0, 0; US1_1, 1; US1_2, 2; US1_3, 3; US1_4, 4 ] |> Map |> Map.find v0
            let v17 : int32 = [ US1_0, 0; US1_1, 1; US1_2, 2; US1_3, 3; US1_4, 4 ] |> Map |> Map.find v13
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
and method13 (v0 : US1, v1 : (unit -> string), v2 : (unit -> string)) : unit =
    let v3 : (unit -> string) = closure7(v0, v1, v2)
    method18(v0, v3)
and closure11 () () : string =
    let v0 : string = $"rust_builder"
    v0
and closure12 (v0 : clap_Command, v1 : clap_ArgMatches) () : string =
    let v2 : string = @$"format!(""{{:#?}}"", $0)"
    let v3 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v2
    let v4 : string = @$"format!(""{{:#?}}"", $0)"
    let v5 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1 v4
    let v6 : (unit -> string) = closure6()
    let v7 : string = $"command: {v3} / matches: {v5} / {v6 ()}"
    v7
and closure1 () (v0 : (string [])) : int32 =
    let v1 : string = __SOURCE_DIRECTORY__
    let v2 : string option = None
    let v3 : bool = true in let mutable _v2 = v2
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v4 : string = method1()
    let v5 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v6 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v4 v5
    let v7 : string = "String::from($0)"
    let v8 : std_string_String = Fable.Core.RustInterop.emitRustExpr v6 v7
    let v9 : string = "std::path::PathBuf::from($0)"
    let v10 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v8 v9
    let v11 : string = method2()
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
    let v38 : string = method3()
    let v39 : string = method4()
    let v40 : string = "v37.join(v38, v39)"
    let v41 : string = Fable.Core.JsInterop.emitJsExpr () v40
    v41
#endif
    
#if FABLE_COMPILER_PYTHON
    let v42 : string = null |> unbox<string>
    v42
#endif
    
#else
    let v43 : string = "polyglot"
    let v44 : string = ".paket"
    let v45 : string = System.IO.Path.Combine (v43, v44)
    v45
#endif
    |> fun x -> _v2 <- Some x
    let v46 : string = _v2.Value
    let v47 : string = method5(v46, v1)
    let v48 : string option = None
    let v49 : bool = true in let mutable _v48 = v48
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v50 : string = method6(v47)
    let v51 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v52 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v50 v51
    let v53 : string = "String::from($0)"
    let v54 : std_string_String = Fable.Core.RustInterop.emitRustExpr v52 v53
    let v55 : string = "std::path::PathBuf::from($0)"
    let v56 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v54 v55
    let v57 : string = method1()
    let v58 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v59 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v57 v58
    let v60 : string = "String::from($0)"
    let v61 : std_string_String = Fable.Core.RustInterop.emitRustExpr v59 v60
    let v62 : string = "$0.join($1)"
    let v63 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr struct (v56, v61) v62
    let v64 : string = "$0.display()"
    let v65 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v63 v64
    let v66 : std_string_String option = None
    let v67 : bool = true in let mutable _v66 = v66
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v68 : string = @$"format!(""{{}}"", $0)"
    let v69 : std_string_String = Fable.Core.RustInterop.emitRustExpr v65 v68
    v69
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v70 : string = @$"format!(""{{}}"", $0)"
    let v71 : std_string_String = Fable.Core.RustInterop.emitRustExpr v65 v70
    v71
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v72 : string = @$"format!(""{{}}"", $0)"
    let v73 : std_string_String = Fable.Core.RustInterop.emitRustExpr v65 v72
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
    
#else
    let v76 : std_string_String = null |> unbox<std_string_String>
    v76
#endif
    |> fun x -> _v66 <- Some x
    let v77 : std_string_String = _v66.Value
    let v78 : string = "fable_library_rust::String_::fromString($0)"
    let v79 : string = Fable.Core.RustInterop.emitRustExpr v77 v78
    v79
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v80 : string = null |> unbox<string>
    v80
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v81 : string = null |> unbox<string>
    v81
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v82 : IPathJoin = Fable.Core.JsInterop.importAll v36
    let v83 : string = method7(v47)
    let v84 : string = method12()
    let v85 : string = "v82.join(v83, v84)"
    let v86 : string = Fable.Core.JsInterop.emitJsExpr () v85
    v86
#endif
    
#if FABLE_COMPILER_PYTHON
    let v87 : string = null |> unbox<string>
    v87
#endif
    
#else
    let v88 : string = System.IO.Path.Combine (v47, v43)
    v88
#endif
    |> fun x -> _v48 <- Some x
    let v89 : string = _v48.Value
    let v90 : US1 = US1_1
    let v91 : (unit -> string) = closure4()
    let v92 : (unit -> string) = closure5(v0, v89)
    method13(v90, v91, v92)
    let v93 : clap_Command = method0()
    let v94 : string = "clap::Command::get_matches($0)"
    let v95 : clap_ArgMatches = Fable.Core.RustInterop.emitRustExpr v93 v94
    let v96 : US1 = US1_1
    let v97 : (unit -> string) = closure11()
    let v98 : (unit -> string) = closure12(v93, v95)
    method13(v96, v97, v98)
    0
let v0 : (unit -> unit) = closure0()
let tests () = v0 ()
let v1 : ((string []) -> int32) = closure1()
let main args = v1 args
()
