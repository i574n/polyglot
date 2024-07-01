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
module State = let mutable trace_state = None
type IOsEnviron = abstract environ: x: unit -> obj
type IFsExistsSync = abstract existsSync: path: string -> bool
type IPathJoin = abstract join: [<System.ParamArray>] paths: string[] -> string
type Disposable (f : unit -> unit) = interface System.IDisposable with member _.Dispose () = f ()
type IPathDirname = abstract dirname: path: string -> string
type [<Struct>] US0 =
    | US0_0
    | US0_1
    | US0_2
    | US0_3
    | US0_4
and Mut0 = {mutable l0 : int64}
and Mut1 = {mutable l0 : (string -> unit)}
and Mut2 = {mutable l0 : bool}
and Mut3 = {mutable l0 : US0}
and [<Struct>] US1 =
    | US1_0 of f0_0 : US0
    | US1_1
and [<Struct>] US2 =
    | US2_0 of f0_0 : int64
    | US2_1
and [<Struct>] US3 =
    | US3_0 of f0_0 : string
    | US3_1
and [<Struct>] US4 =
    | US4_0
    | US4_1
    | US4_2
and [<Struct>] US5 =
    | US5_0 of f0_0 : US4
    | US5_1 of f1_0 : US4
    | US5_2 of f2_0 : US4
    | US5_3 of f3_0 : US4
    | US5_4 of f4_0 : US4
and Mut4 = {mutable l0 : string}
and [<Struct>] US7 =
    | US7_0
    | US7_1
    | US7_2
and [<Struct>] US8 =
    | US8_0
    | US8_1
    | US8_2
    | US8_3
    | US8_4
and [<Struct>] US6 =
    | US6_0 of f0_0 : US7 * f0_1 : US8
    | US6_1
and [<Struct>] US9 =
    | US9_0 of f0_0 : int64
    | US9_1 of f1_0 : exn
and [<Struct>] US10 =
    | US10_0 of f0_0 : int64
    | US10_1 of f1_0 : exn
and [<Struct>] US11 =
    | US11_0 of f0_0 : chrono_DateTime<chrono_Utc>
    | US11_1
and [<Struct>] US12 =
    | US12_0
    | US12_1 of f1_0 : std_string_String
and [<Struct>] US13 =
    | US13_0 of f0_0 : string
    | US13_1 of f1_0 : string
let rec method0 () : string =
    let v0 : string = "TRACE_LEVEL"
    v0
and method2 () : string =
    let v0 : string = ""
    v0
and method1 (v0 : string) : string =
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
    let v14 : string = method2()
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
    let v29 : string = method2()
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
    let v44 : string = method2()
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
and method3 () : string =
    let v0 : string = "AUTOMATION"
    v0
and closure1 () (v0 : string) : unit =
    ()
and closure0 () (v0 : US0) : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) =
    let v1 : bool = true
    let mutable _v1 : struct (US1 * US2) option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = method0()
    let v3 : string = method1(v2)
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
    let v55 : string = method3()
    let v56 : string = method1(v55)
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
    let v69 : string = method0()
    let v70 : string = method1(v69)
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
    let v122 : string = method3()
    let v123 : string = method1(v122)
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
    let v132 : string = method0()
    let v133 : string = method1(v132)
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
    let v185 : string = method3()
    let v186 : string = method1(v185)
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
    let v195 : string = method0()
    let v196 : string = method1(v195)
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
    let v248 : string = method3()
    let v249 : string = method1(v248)
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
    let v260 : Mut2 = {l0 = true} : Mut2
    let v261 : Mut0 = {l0 = 0L} : Mut0
    let v264 : US0 =
        match v258 with
        | US1_1 -> (* None *)
            v0
        | US1_0(v262) -> (* Some *)
            v262
    let v265 : Mut3 = {l0 = v264} : Mut3
    let v266 : (string -> unit) = closure1()
    let v267 : Mut1 = {l0 = v266} : Mut1
    let v272 : int64 option =
        match v259 with
        | US2_1 -> (* None *)
            let v270 : int64 option = None
            v270
        | US2_0(v268) -> (* Some *)
            let v269 : int64 option = Some v268 
            v269
    struct (v261, v267, v260, v265, v272)
and method6 (v0 : string) : string =
    v0
and method7 (v0 : string) : bool =
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
and method5 (v0 : bool, v1 : string) : unit =
    let v2 : bool = true
    let mutable _v2 : unit option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : string = method6(v1)
    let v4 : bool = method7(v3)
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
and closure3 () () : string =
    let v0 : string = "file_system.delete_directory_async"
    v0
and method8 (v0 : string) : string =
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
    let v22 : US4 = US4_1
    let v23 : US5 = US5_2(v22)
    let v24 : string = $"file_system.get_file_name / target: {v23} / path: {v0}"
    let v25 : string = failwith<string> v24
    v25 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v26 : string = null |> unbox<string>
    v26 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v27 : US4 = US4_0
    let v28 : US5 = US5_3(v27)
    let v29 : string = $"file_system.get_file_name / target: {v28} / path: {v0}"
    let v30 : string = failwith<string> v29
    v30 
    #endif
#if FABLE_COMPILER_PYTHON
    let v31 : US4 = US4_0
    let v32 : US5 = US5_4(v31)
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
and closure4 (v0 : string, v1 : string) () : struct (string * string) =
    let v2 : string = method8(v0)
    struct (v1, v2)
and method10 () : string =
    let v0 : string = "hh:mm:ss"
    v0
and method11 () : string =
    let v0 : string = ""
    v0
and method12 () : string =
    let v0 : string = "HH:mm:ss"
    v0
and method13 () : string =
    let v0 : string = "\u001b[0m"
    v0
and method15 (v0 : Mut4, v1 : string) : unit =
    let v2 : string = $"{v1}"
    let v3 : string = v0.l0
    let v4 : string = v3 + v2 
    v0.l0 <- v4
    ()
and method16 (v0 : Mut4) : unit =
    ()
and method14 (v0 : Mut4, v1 : string, v2 : string) : unit =
    let v3 : string = "{ "
    method15(v0, v3)
    method16(v0)
    let v4 : string = "ex"
    method15(v0, v4)
    let v5 : string = " = "
    method15(v0, v5)
    method15(v0, v1)
    let v6 : string = "; "
    method15(v0, v6)
    let v7 : string = "path"
    method15(v0, v7)
    method15(v0, v5)
    method15(v0, v2)
    let v8 : string = " }"
    method15(v0, v8)
and closure5 (v0 : US0, v1 : (unit -> string), v2 : (unit -> struct (string * string))) () : string =
    let v3 : (US0 -> struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option)) = closure0()
    let v4 : US0 = US0_0
    if State.trace_state.IsNone then State.trace_state <- v3 v4 |> Some
    let struct (v5 : Mut0, v6 : Mut1, v7 : Mut2, v8 : Mut3, v9 : int64 option) = State.trace_state.Value
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
    let v36 : string = method10()
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
    let v64 : string = method10()
    let v65 : (string -> string) = v63.ToString
    let v66 : string = v65 v64
    v66 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v67 : string = method11()
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
    let v93 : string = method12()
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
    let v121 : string = method12()
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
    let v149 : string = method12()
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
    let v299 : string = method13()
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
    let v312 : string = method13()
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
    let v325 : string = method13()
    let v326 : string = v324 + v215 
    let v327 : string = v326 + v325 
    v327 
    #endif
    |> fun x -> _v216 <- Some x
    let v328 : string = match _v216 with Some x -> x | None -> failwith "base.run_target / _v216=None"
    let v329 : int64 = v5.l0
    let struct (v330 : string, v331 : string) = v2 ()
    let v332 : string = ""
    let v333 : Mut4 = {l0 = v332} : Mut4
    method14(v333, v330, v331)
    let v334 : string = v333.l0
    let v335 : string = $"{v152} {v328} #{v329} %s{v1 ()} / {v334}"
    let v336 : char list = []
    let v337 : (char list -> (char [])) = List.toArray
    let v338 : (char []) = v337 v336
    let v339 : string = v335.TrimStart v338 
    let v340 : char list = []
    let v341 : char list = '/' :: v340 
    let v342 : char list = ' ' :: v341 
    let v343 : (char list -> (char [])) = List.toArray
    let v344 : (char []) = v343 v342
    let v345 : string = v339.TrimEnd v344 
    v345
and method17 (v0 : US0, v1 : (unit -> string)) : unit =
    let v2 : (US0 -> struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option)) = closure0()
    let v3 : US0 = US0_0
    if State.trace_state.IsNone then State.trace_state <- v2 v3 |> Some
    let struct (v4 : Mut0, v5 : Mut1, v6 : Mut2, v7 : Mut3, v8 : int64 option) = State.trace_state.Value
    let v9 : US0 = US0_0
    if State.trace_state.IsNone then State.trace_state <- v2 v9 |> Some
    let struct (v10 : Mut0, v11 : Mut1, v12 : Mut2, v13 : Mut3, v14 : int64 option) = State.trace_state.Value
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
and method9 (v0 : US0, v1 : (unit -> string), v2 : (unit -> struct (string * string))) : unit =
    let v3 : (unit -> string) = closure5(v0, v1, v2)
    method17(v0, v3)
and method4 (v0 : string, v1 : int64) : Async<int64> =
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
    method5(v9, v0)
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
        let v22 : (unit -> string) = closure3()
        let v23 : (unit -> struct (string * string)) = closure4(v0, v20)
        method9(v21, v22, v23)
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
    let v34 : Async<int64> = method4(v0, v33)
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
and closure2 () (v0 : string) : Async<int64> =
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
    let v8 : Async<int64> = method4(v0, v7)
    v8 
    #endif
    |> fun x -> _v1 <- Some x
    let v9 : Async<int64> = match _v1 with Some x -> x | None -> failwith "base.run_target / _v1=None"
    v9
and closure8 () () : string =
    let v0 : string = "file_system.wait_for_file_access"
    v0
and closure9 (v0 : string, v1 : int64, v2 : string) () : struct (string * int64 * string) =
    let v3 : string = method8(v0)
    struct (v3, v1, v2)
and method21 (v0 : Mut4, v1 : int64) : unit =
    let v2 : string = $"{v1}"
    let v3 : string = v0.l0
    let v4 : string = v3 + v2 
    v0.l0 <- v4
    ()
and method20 (v0 : Mut4, v1 : string, v2 : int64, v3 : string) : unit =
    let v4 : string = "{ "
    method15(v0, v4)
    method16(v0)
    let v5 : string = "path"
    method15(v0, v5)
    let v6 : string = " = "
    method15(v0, v6)
    method15(v0, v1)
    let v7 : string = "; "
    method15(v0, v7)
    let v8 : string = "retry"
    method15(v0, v8)
    method15(v0, v6)
    method21(v0, v2)
    method15(v0, v7)
    let v9 : string = "ex"
    method15(v0, v9)
    method15(v0, v6)
    method15(v0, v3)
    let v10 : string = " }"
    method15(v0, v10)
and closure10 (v0 : US0, v1 : (unit -> string), v2 : (unit -> struct (string * int64 * string))) () : string =
    let v3 : (US0 -> struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option)) = closure0()
    let v4 : US0 = US0_0
    if State.trace_state.IsNone then State.trace_state <- v3 v4 |> Some
    let struct (v5 : Mut0, v6 : Mut1, v7 : Mut2, v8 : Mut3, v9 : int64 option) = State.trace_state.Value
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
    let v36 : string = method10()
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
    let v64 : string = method10()
    let v65 : (string -> string) = v63.ToString
    let v66 : string = v65 v64
    v66 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v67 : string = method11()
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
    let v93 : string = method12()
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
    let v121 : string = method12()
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
    let v149 : string = method12()
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
    let v299 : string = method13()
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
    let v312 : string = method13()
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
    let v325 : string = method13()
    let v326 : string = v324 + v215 
    let v327 : string = v326 + v325 
    v327 
    #endif
    |> fun x -> _v216 <- Some x
    let v328 : string = match _v216 with Some x -> x | None -> failwith "base.run_target / _v216=None"
    let v329 : int64 = v5.l0
    let struct (v330 : string, v331 : int64, v332 : string) = v2 ()
    let v333 : string = ""
    let v334 : Mut4 = {l0 = v333} : Mut4
    method20(v334, v330, v331, v332)
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
and method19 (v0 : US0, v1 : (unit -> string), v2 : (unit -> struct (string * int64 * string))) : unit =
    let v3 : (unit -> string) = closure10(v0, v1, v2)
    method17(v0, v3)
and method18 (v0 : string, v1 : US8, v2 : US7, v3 : int64) : Async<int64> =
    let v4 : bool = true
    let mutable _v4 : Async<int64> option = None 
    
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
    let v11 : bool = true
    let mutable _v11 : System.IO.FileStream option = None 
    
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
    let v23 : System.IO.FileAccess =
        match v2 with
        | US7_0 -> (* AccessRead *)
            let v18 : System.IO.FileAccess = System.IO.FileAccess.Read
            v18
        | US7_2 -> (* AccessReadWrite *)
            let v20 : System.IO.FileAccess = System.IO.FileAccess.ReadWrite
            v20
        | US7_1 -> (* AccessWrite *)
            let v19 : System.IO.FileAccess = System.IO.FileAccess.ReadWrite
            v19
    let v33 : System.IO.FileShare =
        match v1 with
        | US8_4 -> (* ShareDelete *)
            let v28 : System.IO.FileShare = System.IO.FileShare.Delete
            v28
        | US8_0 -> (* ShareNone *)
            let v24 : System.IO.FileShare = System.IO.FileShare.None
            v24
        | US8_1 -> (* ShareRead *)
            let v25 : System.IO.FileShare = System.IO.FileShare.Read
            v25
        | US8_3 -> (* ShareReadWrite *)
            let v27 : System.IO.FileShare = System.IO.FileShare.ReadWrite
            v27
        | US8_2 -> (* ShareWrite *)
            let v26 : System.IO.FileShare = System.IO.FileShare.Write
            v26
    let v34 : System.IO.FileStream = new System.IO.FileStream (v0, v17, v23, v33)
    v34 
    #endif
    |> fun x -> _v11 <- Some x
    let v35 : System.IO.FileStream = match _v11 with Some x -> x | None -> failwith "base.run_target / _v11=None"
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
        let v42 : bool = true
        let mutable _v42 : string option = None 
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v43 : string = $"%A{v37}"
        v43 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v44 : string = $"%A{v37}"
        v44 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v45 : string = $"%A{v37}"
        v45 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v46 : string = $"%A{v37}"
        v46 
        #endif
#if FABLE_COMPILER_PYTHON
        let v47 : string = $"%A{v37}"
        v47 
        #endif
#else
        let v48 : string = $"{v37.GetType ()}: {v37.Message}"
        v48 
        #endif
        |> fun x -> _v42 <- Some x
        let v49 : string = match _v42 with Some x -> x | None -> failwith "base.run_target / _v42=None"
        let v50 : US0 = US0_1
        let v51 : (unit -> string) = closure8()
        let v52 : (unit -> struct (string * int64 * string)) = closure9(v0, v3, v49)
        method19(v50, v51, v52)
    let v53 : bool = true
    let mutable _v53 : Async<unit> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v54 : Async<unit> = null |> unbox<Async<unit>>
    v54 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v55 : Async<unit> = null |> unbox<Async<unit>>
    v55 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v56 : Async<unit> = null |> unbox<Async<unit>>
    v56 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v57 : Async<unit> = null |> unbox<Async<unit>>
    v57 
    #endif
#if FABLE_COMPILER_PYTHON
    let v58 : Async<unit> = null |> unbox<Async<unit>>
    v58 
    #endif
#else
    let v59 : (int32 -> Async<unit>) = Async.Sleep
    let v60 : Async<unit> = v59 10
    v60 
    #endif
    |> fun x -> _v53 <- Some x
    let v61 : Async<unit> = match _v53 with Some x -> x | None -> failwith "base.run_target / _v53=None"
    do! v61 
    let v62 : int64 = v3 + 1L
    let v63 : Async<int64> = method18(v0, v1, v2, v62)
    return! v63 
    (*
    let v64 : int64 = *)
    }
    |> fun x -> _v10 <- Some x
    let v65 : Async<int64> = match _v10 with Some x -> x | None -> failwith "async.new_async_unit / _v10=None"
    v65 
    #endif
    |> fun x -> _v4 <- Some x
    let v66 : Async<int64> = match _v4 with Some x -> x | None -> failwith "base.run_target / _v4=None"
    v66
and closure7 (v0 : US6) (v1 : string) : Async<int64> =
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
    let struct (v14 : US7, v15 : US8) =
        match v0 with
        | US6_1 -> (* None *)
            let v10 : US7 = US7_2
            let v11 : US8 = US8_1
            struct (v10, v11)
        | US6_0(v8, v9) -> (* Some *)
            struct (v8, v9)
    let v16 : int64 = 0L
    let v17 : Async<int64> = method18(v1, v15, v14, v16)
    v17 
    #endif
    |> fun x -> _v2 <- Some x
    let v18 : Async<int64> = match _v2 with Some x -> x | None -> failwith "base.run_target / _v2=None"
    v18
and closure6 () (v0 : US6) : (string -> Async<int64>) =
    closure7(v0)
and method22 (v0 : string, v1 : int64) : Async<int64> =
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
    let mutable _v9 : System.IO.FileStream option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
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
#if FABLE_COMPILER_TYPESCRIPT
    let v13 : System.IO.FileStream = null |> unbox<System.IO.FileStream>
    v13 
    #endif
#if FABLE_COMPILER_PYTHON
    let v14 : System.IO.FileStream = null |> unbox<System.IO.FileStream>
    v14 
    #endif
#else
    let v15 : System.IO.FileMode = System.IO.FileMode.Open
    let v16 : System.IO.FileAccess = System.IO.FileAccess.Read
    let v17 : System.IO.FileShare = System.IO.FileShare.Read
    let v18 : System.IO.FileStream = new System.IO.FileStream (v0, v15, v16, v17)
    v18 
    #endif
    |> fun x -> _v9 <- Some x
    let v19 : System.IO.FileStream = match _v9 with Some x -> x | None -> failwith "base.run_target / _v9=None"
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
        let v26 : bool = true
        let mutable _v26 : string option = None 
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v27 : string = $"%A{v21}"
        v27 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v28 : string = $"%A{v21}"
        v28 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v29 : string = $"%A{v21}"
        v29 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v30 : string = $"%A{v21}"
        v30 
        #endif
#if FABLE_COMPILER_PYTHON
        let v31 : string = $"%A{v21}"
        v31 
        #endif
#else
        let v32 : string = $"{v21.GetType ()}: {v21.Message}"
        v32 
        #endif
        |> fun x -> _v26 <- Some x
        let v33 : string = match _v26 with Some x -> x | None -> failwith "base.run_target / _v26=None"
        let v34 : US0 = US0_1
        let v35 : (unit -> string) = closure8()
        let v36 : (unit -> struct (string * int64 * string)) = closure9(v0, v1, v33)
        method19(v34, v35, v36)
    let v37 : bool = true
    let mutable _v37 : Async<unit> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v38 : Async<unit> = null |> unbox<Async<unit>>
    v38 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v39 : Async<unit> = null |> unbox<Async<unit>>
    v39 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v40 : Async<unit> = null |> unbox<Async<unit>>
    v40 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v41 : Async<unit> = null |> unbox<Async<unit>>
    v41 
    #endif
#if FABLE_COMPILER_PYTHON
    let v42 : Async<unit> = null |> unbox<Async<unit>>
    v42 
    #endif
#else
    let v43 : (int32 -> Async<unit>) = Async.Sleep
    let v44 : Async<unit> = v43 10
    v44 
    #endif
    |> fun x -> _v37 <- Some x
    let v45 : Async<unit> = match _v37 with Some x -> x | None -> failwith "base.run_target / _v37=None"
    do! v45 
    let v46 : int64 = v1 + 1L
    let v47 : Async<int64> = method22(v0, v46)
    return! v47 
    (*
    let v48 : int64 = *)
    }
    |> fun x -> _v8 <- Some x
    let v49 : Async<int64> = match _v8 with Some x -> x | None -> failwith "async.new_async_unit / _v8=None"
    v49 
    #endif
    |> fun x -> _v2 <- Some x
    let v50 : Async<int64> = match _v2 with Some x -> x | None -> failwith "base.run_target / _v2=None"
    v50
and closure11 () (v0 : string) : Async<int64> =
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
    let v8 : Async<int64> = method22(v0, v7)
    v8 
    #endif
    |> fun x -> _v1 <- Some x
    let v9 : Async<int64> = match _v1 with Some x -> x | None -> failwith "base.run_target / _v1=None"
    v9
and closure12 () (v0 : string) : Async<string> =
    let v1 : bool = true
    let mutable _v1 : Async<string> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : Async<string> = null |> unbox<Async<string>>
    v2 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v3 : Async<string> = null |> unbox<Async<string>>
    v3 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v4 : Async<string> = null |> unbox<Async<string>>
    v4 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v5 : Async<string> = null |> unbox<Async<string>>
    v5 
    #endif
#if FABLE_COMPILER_PYTHON
    let v6 : Async<string> = null |> unbox<Async<string>>
    v6 
    #endif
#else
    let v7 : (string -> System.Threading.Tasks.Task<string>) = System.IO.File.ReadAllTextAsync
    let v8 : System.Threading.Tasks.Task<string> = v7 v0
    let v9 : bool = true
    let mutable _v9 : Async<string> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
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
#if FABLE_COMPILER_TYPESCRIPT
    let v13 : Async<string> = null |> unbox<Async<string>>
    v13 
    #endif
#if FABLE_COMPILER_PYTHON
    let v14 : Async<string> = null |> unbox<Async<string>>
    v14 
    #endif
#else
    let v15 : (System.Threading.Tasks.Task<string> -> Async<string>) = Async.AwaitTask
    let v16 : Async<string> = v15 v8
    v16 
    #endif
    |> fun x -> _v9 <- Some x
    let v17 : Async<string> = match _v9 with Some x -> x | None -> failwith "base.run_target / _v9=None"
    v17 
    #endif
    |> fun x -> _v1 <- Some x
    let v18 : Async<string> = match _v1 with Some x -> x | None -> failwith "base.run_target / _v1=None"
    v18
and method24 (v0 : string) : bool =
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
and method25 (v0 : Vec<uint8>) : Vec<uint8> =
    v0
and method23 (v0 : string, v1 : string) : bool =
    let v2 : bool = true
    let mutable _v2 : bool option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : bool = method24(v0)
    let v4 : bool = v3 = false
    let v31 : bool =
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
            let v17 : Vec<uint8> = method25(v16)
            let v18 : string = "std::string::String::from_utf8($0)"
            let v19 : Result<std_string_String, std_string_FromUtf8Error> = Fable.Core.RustInterop.emitRustExpr v17 v18 
            let v20 : string = "$0.unwrap()"
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
            let v28 : string = v0 |> System.IO.File.ReadAllText
            v28 
            #endif
            |> fun x -> _v5 <- Some x
            let v29 : string = match _v5 with Some x -> x | None -> failwith "base.run_target / _v5=None"
            let v30 : bool = v1 = v29
            v30
    v31 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v32 : bool = null |> unbox<bool>
    v32 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v33 : bool = null |> unbox<bool>
    v33 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v34 : bool = null |> unbox<bool>
    v34 
    #endif
#if FABLE_COMPILER_PYTHON
    let v35 : bool = null |> unbox<bool>
    v35 
    #endif
#else
    let v36 : bool = null |> unbox<bool>
    v36 
    #endif
    |> fun x -> _v2 <- Some x
    let v37 : bool = match _v2 with Some x -> x | None -> failwith "base.run_target / _v2=None"
    v37
and closure14 (v0 : string) (v1 : string) : bool =
    method23(v0, v1)
and closure13 () (v0 : string) : (string -> bool) =
    closure14(v0)
and closure16 (v0 : string) (v1 : string) : Async<unit> =
    let v2 : bool = true
    let mutable _v2 : Async<unit> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : Async<unit> = null |> unbox<Async<unit>>
    v3 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v4 : Async<unit> = null |> unbox<Async<unit>>
    v4 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v5 : Async<unit> = null |> unbox<Async<unit>>
    v5 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v6 : Async<unit> = null |> unbox<Async<unit>>
    v6 
    #endif
#if FABLE_COMPILER_PYTHON
    let v7 : Async<unit> = null |> unbox<Async<unit>>
    v7 
    #endif
#else
    let v8 : System.Threading.Tasks.Task = System.IO.File.WriteAllTextAsync (v0, v1)
    let v9 : bool = true
    let mutable _v9 : Async<unit> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
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
#if FABLE_COMPILER_TYPESCRIPT
    let v13 : Async<unit> = null |> unbox<Async<unit>>
    v13 
    #endif
#if FABLE_COMPILER_PYTHON
    let v14 : Async<unit> = null |> unbox<Async<unit>>
    v14 
    #endif
#else
    let v15 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
    let v16 : Async<unit> = v15 v8
    v16 
    #endif
    |> fun x -> _v9 <- Some x
    let v17 : Async<unit> = match _v9 with Some x -> x | None -> failwith "base.run_target / _v9=None"
    v17 
    #endif
    |> fun x -> _v2 <- Some x
    let v18 : Async<unit> = match _v2 with Some x -> x | None -> failwith "base.run_target / _v2=None"
    v18
and closure15 () (v0 : string) : (string -> Async<unit>) =
    closure16(v0)
and closure18 (v0 : string) (v1 : string) : Async<unit> =
    let v2 : bool = true
    let mutable _v2 : Async<unit> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : Async<unit> = null |> unbox<Async<unit>>
    v3 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v4 : Async<unit> = null |> unbox<Async<unit>>
    v4 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v5 : Async<unit> = null |> unbox<Async<unit>>
    v5 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v6 : Async<unit> = null |> unbox<Async<unit>>
    v6 
    #endif
#if FABLE_COMPILER_PYTHON
    let v7 : Async<unit> = null |> unbox<Async<unit>>
    v7 
    #endif
#else
    let v8 : Async<unit> option = None
    let mutable _v8 = v8 
    async {
    let v9 : bool = true
    let mutable _v9 : Async<bool> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
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
#if FABLE_COMPILER_TYPESCRIPT
    let v13 : Async<bool> = null |> unbox<Async<bool>>
    v13 
    #endif
#if FABLE_COMPILER_PYTHON
    let v14 : Async<bool> = null |> unbox<Async<bool>>
    v14 
    #endif
#else
    let v15 : bool = true
    let mutable _v15 : Async<bool> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v16 : Async<bool> = null |> unbox<Async<bool>>
    v16 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v17 : Async<bool> = null |> unbox<Async<bool>>
    v17 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v18 : Async<bool> = null |> unbox<Async<bool>>
    v18 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v19 : Async<bool> = null |> unbox<Async<bool>>
    v19 
    #endif
#if FABLE_COMPILER_PYTHON
    let v20 : Async<bool> = null |> unbox<Async<bool>>
    v20 
    #endif
#else
    let v21 : Async<bool> option = None
    let mutable _v21 = v21 
    async {
    let v22 : bool = method24(v0)
    let v23 : bool = v22 = false
    if v23 then
        return false 
        (*
        ()
    else
        *) else
        let v24 : bool = true
        let mutable _v24 : Async<string> option = None 
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v25 : Async<string> = null |> unbox<Async<string>>
        v25 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v26 : Async<string> = null |> unbox<Async<string>>
        v26 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v27 : Async<string> = null |> unbox<Async<string>>
        v27 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v28 : Async<string> = null |> unbox<Async<string>>
        v28 
        #endif
#if FABLE_COMPILER_PYTHON
        let v29 : Async<string> = null |> unbox<Async<string>>
        v29 
        #endif
#else
        let v30 : (string -> System.Threading.Tasks.Task<string>) = System.IO.File.ReadAllTextAsync
        let v31 : System.Threading.Tasks.Task<string> = v30 v0
        let v32 : bool = true
        let mutable _v32 : Async<string> option = None 
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v33 : Async<string> = null |> unbox<Async<string>>
        v33 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v34 : Async<string> = null |> unbox<Async<string>>
        v34 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v35 : Async<string> = null |> unbox<Async<string>>
        v35 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v36 : Async<string> = null |> unbox<Async<string>>
        v36 
        #endif
#if FABLE_COMPILER_PYTHON
        let v37 : Async<string> = null |> unbox<Async<string>>
        v37 
        #endif
#else
        let v38 : (System.Threading.Tasks.Task<string> -> Async<string>) = Async.AwaitTask
        let v39 : Async<string> = v38 v31
        v39 
        #endif
        |> fun x -> _v32 <- Some x
        let v40 : Async<string> = match _v32 with Some x -> x | None -> failwith "base.run_target / _v32=None"
        v40 
        #endif
        |> fun x -> _v24 <- Some x
        let v41 : Async<string> = match _v24 with Some x -> x | None -> failwith "base.run_target / _v24=None"
        let! v41 = v41 
        let v42 : string = v41 
        let v43 : bool = v1 = v42
        return v43 
        (*
        ()
    *)
    }
    |> fun x -> _v21 <- Some x
    let v44 : Async<bool> = match _v21 with Some x -> x | None -> failwith "async.new_async_unit / _v21=None"
    v44 
    #endif
    |> fun x -> _v15 <- Some x
    let v45 : Async<bool> = match _v15 with Some x -> x | None -> failwith "base.run_target / _v15=None"
    v45 
    #endif
    |> fun x -> _v9 <- Some x
    let v46 : Async<bool> = match _v9 with Some x -> x | None -> failwith "base.run_target / _v9=None"
    let! v46 = v46 
    let v47 : bool = v46 
    let v48 : bool = v47 = false
    if v48 then
        let v49 : bool = true
        let mutable _v49 : Async<unit> option = None 
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v50 : Async<unit> = null |> unbox<Async<unit>>
        v50 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v51 : Async<unit> = null |> unbox<Async<unit>>
        v51 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v52 : Async<unit> = null |> unbox<Async<unit>>
        v52 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v53 : Async<unit> = null |> unbox<Async<unit>>
        v53 
        #endif
#if FABLE_COMPILER_PYTHON
        let v54 : Async<unit> = null |> unbox<Async<unit>>
        v54 
        #endif
#else
        let v55 : System.Threading.Tasks.Task = System.IO.File.WriteAllTextAsync (v0, v1)
        let v56 : bool = true
        let mutable _v56 : Async<unit> option = None 
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v57 : Async<unit> = null |> unbox<Async<unit>>
        v57 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v58 : Async<unit> = null |> unbox<Async<unit>>
        v58 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v59 : Async<unit> = null |> unbox<Async<unit>>
        v59 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v60 : Async<unit> = null |> unbox<Async<unit>>
        v60 
        #endif
#if FABLE_COMPILER_PYTHON
        let v61 : Async<unit> = null |> unbox<Async<unit>>
        v61 
        #endif
#else
        let v62 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
        let v63 : Async<unit> = v62 v55
        v63 
        #endif
        |> fun x -> _v56 <- Some x
        let v64 : Async<unit> = match _v56 with Some x -> x | None -> failwith "base.run_target / _v56=None"
        v64 
        #endif
        |> fun x -> _v49 <- Some x
        let v65 : Async<unit> = match _v49 with Some x -> x | None -> failwith "base.run_target / _v49=None"
        do! v65 
        ()
    }
    |> fun x -> _v8 <- Some x
    let v66 : Async<unit> = match _v8 with Some x -> x | None -> failwith "async.new_async_unit / _v8=None"
    v66 
    #endif
    |> fun x -> _v2 <- Some x
    let v67 : Async<unit> = match _v2 with Some x -> x | None -> failwith "base.run_target / _v2=None"
    v67
and closure17 () (v0 : string) : (string -> Async<unit>) =
    closure18(v0)
and closure20 () () : string =
    let v0 : string = "delete_file_async"
    v0
and closure21 (v0 : string, v1 : exn) () : struct (string * string) =
    let v2 : string = method8(v0)
    let v3 : bool = true
    let mutable _v3 : string option = None 
    
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
    |> fun x -> _v3 <- Some x
    let v10 : string = match _v3 with Some x -> x | None -> failwith "base.run_target / _v3=None"
    struct (v2, v10)
and method28 (v0 : Mut4, v1 : string, v2 : string) : unit =
    let v3 : string = "{ "
    method15(v0, v3)
    method16(v0)
    let v4 : string = "path"
    method15(v0, v4)
    let v5 : string = " = "
    method15(v0, v5)
    method15(v0, v1)
    let v6 : string = "; "
    method15(v0, v6)
    let v7 : string = "ex"
    method15(v0, v7)
    method15(v0, v5)
    method15(v0, v2)
    let v8 : string = " }"
    method15(v0, v8)
and closure22 (v0 : US0, v1 : (unit -> string), v2 : (unit -> struct (string * string))) () : string =
    let v3 : (US0 -> struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option)) = closure0()
    let v4 : US0 = US0_0
    if State.trace_state.IsNone then State.trace_state <- v3 v4 |> Some
    let struct (v5 : Mut0, v6 : Mut1, v7 : Mut2, v8 : Mut3, v9 : int64 option) = State.trace_state.Value
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
    let v36 : string = method10()
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
    let v64 : string = method10()
    let v65 : (string -> string) = v63.ToString
    let v66 : string = v65 v64
    v66 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v67 : string = method11()
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
    let v93 : string = method12()
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
    let v121 : string = method12()
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
    let v149 : string = method12()
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
    let v299 : string = method13()
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
    let v312 : string = method13()
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
    let v325 : string = method13()
    let v326 : string = v324 + v215 
    let v327 : string = v326 + v325 
    v327 
    #endif
    |> fun x -> _v216 <- Some x
    let v328 : string = match _v216 with Some x -> x | None -> failwith "base.run_target / _v216=None"
    let v329 : int64 = v5.l0
    let struct (v330 : string, v331 : string) = v2 ()
    let v332 : string = ""
    let v333 : Mut4 = {l0 = v332} : Mut4
    method28(v333, v330, v331)
    let v334 : string = v333.l0
    let v335 : string = $"{v152} {v328} #{v329} %s{v1 ()} / {v334}"
    let v336 : char list = []
    let v337 : (char list -> (char [])) = List.toArray
    let v338 : (char []) = v337 v336
    let v339 : string = v335.TrimStart v338 
    let v340 : char list = []
    let v341 : char list = '/' :: v340 
    let v342 : char list = ' ' :: v341 
    let v343 : (char list -> (char [])) = List.toArray
    let v344 : (char []) = v343 v342
    let v345 : string = v339.TrimEnd v344 
    v345
and method27 (v0 : US0, v1 : (unit -> string), v2 : (unit -> struct (string * string))) : unit =
    let v3 : (unit -> string) = closure22(v0, v1, v2)
    method17(v0, v3)
and method26 (v0 : string, v1 : int64) : Async<int64> =
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
    let mutable _v9 : unit option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v10 : string = "std::fs::remove_file(&*$0).unwrap()"
    Fable.Core.RustInterop.emitRustExpr v0 v10 
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
    let v11 : (string -> unit) = System.IO.File.Delete
    v11 v0
    () 
    #endif
    |> fun x -> _v9 <- Some x
    match _v9 with Some x -> x | None -> failwith "base.run_target / _v9=None"
    return v1 
    with ex ->
    let v12 : exn = ex
    let v13 : int64 = v1 % 100L
    let v14 : bool = v13 = 0L
    if v14 then
        let v15 : US0 = US0_3
        let v16 : (unit -> string) = closure20()
        let v17 : (unit -> struct (string * string)) = closure21(v0, v12)
        method27(v15, v16, v17)
    let v18 : bool = true
    let mutable _v18 : Async<unit> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
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
#if FABLE_COMPILER_TYPESCRIPT
    let v22 : Async<unit> = null |> unbox<Async<unit>>
    v22 
    #endif
#if FABLE_COMPILER_PYTHON
    let v23 : Async<unit> = null |> unbox<Async<unit>>
    v23 
    #endif
#else
    let v24 : (int32 -> Async<unit>) = Async.Sleep
    let v25 : Async<unit> = v24 10
    v25 
    #endif
    |> fun x -> _v18 <- Some x
    let v26 : Async<unit> = match _v18 with Some x -> x | None -> failwith "base.run_target / _v18=None"
    do! v26 
    let v27 : int64 = v1 + 1L
    let v28 : Async<int64> = method26(v0, v27)
    return! v28 
    (*
    let v29 : int64 = *)
    }
    |> fun x -> _v8 <- Some x
    let v30 : Async<int64> = match _v8 with Some x -> x | None -> failwith "async.new_async_unit / _v8=None"
    v30 
    #endif
    |> fun x -> _v2 <- Some x
    let v31 : Async<int64> = match _v2 with Some x -> x | None -> failwith "base.run_target / _v2=None"
    v31
and closure19 () (v0 : string) : Async<int64> =
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
    let v8 : Async<int64> = method26(v0, v7)
    v8 
    #endif
    |> fun x -> _v1 <- Some x
    let v9 : Async<int64> = match _v1 with Some x -> x | None -> failwith "base.run_target / _v1=None"
    v9
and closure25 () () : string =
    let v0 : string = "move_file_async"
    v0
and closure26 (v0 : string, v1 : string, v2 : exn) () : struct (string * string * exn) =
    let v3 : string = method8(v1)
    let v4 : string = method8(v0)
    struct (v3, v4, v2)
and method32 (v0 : Mut4, v1 : exn) : unit =
    let v2 : string = $"%A{v1}"
    method15(v0, v2)
and method31 (v0 : Mut4, v1 : string, v2 : string, v3 : exn) : unit =
    let v4 : string = "{ "
    method15(v0, v4)
    method16(v0)
    let v5 : string = "old_path"
    method15(v0, v5)
    let v6 : string = " = "
    method15(v0, v6)
    method15(v0, v1)
    let v7 : string = "; "
    method15(v0, v7)
    let v8 : string = "new_path"
    method15(v0, v8)
    method15(v0, v6)
    method15(v0, v2)
    method15(v0, v7)
    let v9 : string = "ex"
    method15(v0, v9)
    method15(v0, v6)
    method32(v0, v3)
    let v10 : string = " }"
    method15(v0, v10)
and closure27 (v0 : US0, v1 : (unit -> string), v2 : (unit -> struct (string * string * exn))) () : string =
    let v3 : (US0 -> struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option)) = closure0()
    let v4 : US0 = US0_0
    if State.trace_state.IsNone then State.trace_state <- v3 v4 |> Some
    let struct (v5 : Mut0, v6 : Mut1, v7 : Mut2, v8 : Mut3, v9 : int64 option) = State.trace_state.Value
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
    let v36 : string = method10()
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
    let v64 : string = method10()
    let v65 : (string -> string) = v63.ToString
    let v66 : string = v65 v64
    v66 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v67 : string = method11()
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
    let v93 : string = method12()
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
    let v121 : string = method12()
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
    let v149 : string = method12()
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
    let v299 : string = method13()
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
    let v312 : string = method13()
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
    let v325 : string = method13()
    let v326 : string = v324 + v215 
    let v327 : string = v326 + v325 
    v327 
    #endif
    |> fun x -> _v216 <- Some x
    let v328 : string = match _v216 with Some x -> x | None -> failwith "base.run_target / _v216=None"
    let v329 : int64 = v5.l0
    let struct (v330 : string, v331 : string, v332 : exn) = v2 ()
    let v333 : string = ""
    let v334 : Mut4 = {l0 = v333} : Mut4
    method31(v334, v330, v331, v332)
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
and method30 (v0 : US0, v1 : (unit -> string), v2 : (unit -> struct (string * string * exn))) : unit =
    let v3 : (unit -> string) = closure27(v0, v1, v2)
    method17(v0, v3)
and method29 (v0 : string, v1 : string, v2 : int64) : Async<int64> =
    let v3 : bool = true
    let mutable _v3 : Async<int64> option = None 
    
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
    System.IO.File.Move (v1, v0)
    () 
    #endif
    |> fun x -> _v10 <- Some x
    match _v10 with Some x -> x | None -> failwith "base.run_target / _v10=None"
    return v2 
    with ex ->
    let v11 : exn = ex
    let v12 : int64 = v2 % 100L
    let v13 : bool = v12 = 0L
    if v13 then
        let v14 : US0 = US0_3
        let v15 : (unit -> string) = closure25()
        let v16 : (unit -> struct (string * string * exn)) = closure26(v0, v1, v11)
        method30(v14, v15, v16)
    let v17 : bool = true
    let mutable _v17 : Async<unit> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v18 : Async<unit> = null |> unbox<Async<unit>>
    v18 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v19 : Async<unit> = null |> unbox<Async<unit>>
    v19 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v20 : Async<unit> = null |> unbox<Async<unit>>
    v20 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v21 : Async<unit> = null |> unbox<Async<unit>>
    v21 
    #endif
#if FABLE_COMPILER_PYTHON
    let v22 : Async<unit> = null |> unbox<Async<unit>>
    v22 
    #endif
#else
    let v23 : (int32 -> Async<unit>) = Async.Sleep
    let v24 : Async<unit> = v23 10
    v24 
    #endif
    |> fun x -> _v17 <- Some x
    let v25 : Async<unit> = match _v17 with Some x -> x | None -> failwith "base.run_target / _v17=None"
    do! v25 
    let v26 : int64 = v2 + 1L
    let v27 : Async<int64> = method29(v0, v1, v26)
    return! v27 
    (*
    *)
    }
    |> fun x -> _v9 <- Some x
    let v28 : Async<int64> = match _v9 with Some x -> x | None -> failwith "async.new_async_unit / _v9=None"
    v28 
    #endif
    |> fun x -> _v3 <- Some x
    let v29 : Async<int64> = match _v3 with Some x -> x | None -> failwith "base.run_target / _v3=None"
    v29
and closure24 (v0 : string) (v1 : string) : Async<int64> =
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
    let v8 : int64 = 0L
    let v9 : Async<int64> = method29(v0, v1, v8)
    v9 
    #endif
    |> fun x -> _v2 <- Some x
    let v10 : Async<int64> = match _v2 with Some x -> x | None -> failwith "base.run_target / _v2=None"
    v10
and closure23 () (v0 : string) : (string -> Async<int64>) =
    closure24(v0)
and closure29 () (v0 : int64) : US9 =
    US9_0(v0)
and closure30 () (v0 : exn) : US9 =
    US9_1(v0)
and closure31 () () : string =
    let v0 : string = "async.run_with_timeout_async"
    v0
and closure32 () () : int32 =
    1000
and method36 (v0 : Mut4, v1 : int32) : unit =
    let v2 : string = $"{v1}"
    let v3 : string = v0.l0
    let v4 : string = v3 + v2 
    v0.l0 <- v4
    ()
and method35 (v0 : Mut4, v1 : int32) : unit =
    let v2 : string = "{ "
    method15(v0, v2)
    method16(v0)
    let v3 : string = "timeout"
    method15(v0, v3)
    let v4 : string = " = "
    method15(v0, v4)
    method36(v0, v1)
    let v5 : string = " }"
    method15(v0, v5)
and closure33 (v0 : US0, v1 : (unit -> string), v2 : (unit -> int32)) () : string =
    let v3 : (US0 -> struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option)) = closure0()
    let v4 : US0 = US0_0
    if State.trace_state.IsNone then State.trace_state <- v3 v4 |> Some
    let struct (v5 : Mut0, v6 : Mut1, v7 : Mut2, v8 : Mut3, v9 : int64 option) = State.trace_state.Value
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
    let v36 : string = method10()
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
    let v64 : string = method10()
    let v65 : (string -> string) = v63.ToString
    let v66 : string = v65 v64
    v66 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v67 : string = method11()
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
    let v93 : string = method12()
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
    let v121 : string = method12()
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
    let v149 : string = method12()
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
    let v299 : string = method13()
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
    let v312 : string = method13()
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
    let v325 : string = method13()
    let v326 : string = v324 + v215 
    let v327 : string = v326 + v325 
    v327 
    #endif
    |> fun x -> _v216 <- Some x
    let v328 : string = match _v216 with Some x -> x | None -> failwith "base.run_target / _v216=None"
    let v329 : int64 = v5.l0
    let v330 : int32 = v2 ()
    let v331 : string = ""
    let v332 : Mut4 = {l0 = v331} : Mut4
    method35(v332, v330)
    let v333 : string = v332.l0
    let v334 : string = $"{v152} {v328} #{v329} %s{v1 ()} / {v333}"
    let v335 : char list = []
    let v336 : (char list -> (char [])) = List.toArray
    let v337 : (char []) = v336 v335
    let v338 : string = v334.TrimStart v337 
    let v339 : char list = []
    let v340 : char list = '/' :: v339 
    let v341 : char list = ' ' :: v340 
    let v342 : (char list -> (char [])) = List.toArray
    let v343 : (char []) = v342 v341
    let v344 : string = v338.TrimEnd v343 
    v344
and method34 (v0 : US0, v1 : (unit -> string), v2 : (unit -> int32)) : unit =
    let v3 : (unit -> string) = closure33(v0, v1, v2)
    method17(v0, v3)
and closure34 () () : string =
    let v0 : string = $"async.run_with_timeout_async**"
    v0
and closure35 (v0 : exn) () : struct (int32 * string) =
    let v1 : bool = true
    let mutable _v1 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = $"%A{v0}"
    v2 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v3 : string = $"%A{v0}"
    v3 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v4 : string = $"%A{v0}"
    v4 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v5 : string = $"%A{v0}"
    v5 
    #endif
#if FABLE_COMPILER_PYTHON
    let v6 : string = $"%A{v0}"
    v6 
    #endif
#else
    let v7 : string = $"{v0.GetType ()}: {v0.Message}"
    v7 
    #endif
    |> fun x -> _v1 <- Some x
    let v8 : string = match _v1 with Some x -> x | None -> failwith "base.run_target / _v1=None"
    struct (1000, v8)
and method38 (v0 : Mut4, v1 : int32, v2 : string) : unit =
    let v3 : string = "{ "
    method15(v0, v3)
    method16(v0)
    let v4 : string = "timeout"
    method15(v0, v4)
    let v5 : string = " = "
    method15(v0, v5)
    method36(v0, v1)
    let v6 : string = "; "
    method15(v0, v6)
    let v7 : string = "ex"
    method15(v0, v7)
    method15(v0, v5)
    method15(v0, v2)
    let v8 : string = " }"
    method15(v0, v8)
and closure36 (v0 : US0, v1 : (unit -> string), v2 : (unit -> struct (int32 * string))) () : string =
    let v3 : (US0 -> struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option)) = closure0()
    let v4 : US0 = US0_0
    if State.trace_state.IsNone then State.trace_state <- v3 v4 |> Some
    let struct (v5 : Mut0, v6 : Mut1, v7 : Mut2, v8 : Mut3, v9 : int64 option) = State.trace_state.Value
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
    let v36 : string = method10()
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
    let v64 : string = method10()
    let v65 : (string -> string) = v63.ToString
    let v66 : string = v65 v64
    v66 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v67 : string = method11()
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
    let v93 : string = method12()
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
    let v121 : string = method12()
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
    let v149 : string = method12()
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
    let v299 : string = method13()
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
    let v312 : string = method13()
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
    let v325 : string = method13()
    let v326 : string = v324 + v215 
    let v327 : string = v326 + v325 
    v327 
    #endif
    |> fun x -> _v216 <- Some x
    let v328 : string = match _v216 with Some x -> x | None -> failwith "base.run_target / _v216=None"
    let v329 : int64 = v5.l0
    let struct (v330 : int32, v331 : string) = v2 ()
    let v332 : string = ""
    let v333 : Mut4 = {l0 = v332} : Mut4
    method38(v333, v330, v331)
    let v334 : string = v333.l0
    let v335 : string = $"{v152} {v328} #{v329} %s{v1 ()} / {v334}"
    let v336 : char list = []
    let v337 : (char list -> (char [])) = List.toArray
    let v338 : (char []) = v337 v336
    let v339 : string = v335.TrimStart v338 
    let v340 : char list = []
    let v341 : char list = '/' :: v340 
    let v342 : char list = ' ' :: v341 
    let v343 : (char list -> (char [])) = List.toArray
    let v344 : (char []) = v343 v342
    let v345 : string = v339.TrimEnd v344 
    v345
and method37 (v0 : US0, v1 : (unit -> string), v2 : (unit -> struct (int32 * string))) : unit =
    let v3 : (unit -> string) = closure36(v0, v1, v2)
    method17(v0, v3)
and closure37 () () : string =
    let v0 : string = "read_all_text_retry_async"
    v0
and closure38 (v0 : int64, v1 : string) () : struct (int64 * string) =
    struct (v0, v1)
and method40 (v0 : Mut4, v1 : int64, v2 : string) : unit =
    let v3 : string = "{ "
    method15(v0, v3)
    method16(v0)
    let v4 : string = "retry"
    method15(v0, v4)
    let v5 : string = " = "
    method15(v0, v5)
    method21(v0, v1)
    let v6 : string = "; "
    method15(v0, v6)
    let v7 : string = "ex"
    method15(v0, v7)
    method15(v0, v5)
    method15(v0, v2)
    let v8 : string = " }"
    method15(v0, v8)
and closure39 (v0 : US0, v1 : (unit -> string), v2 : (unit -> struct (int64 * string))) () : string =
    let v3 : (US0 -> struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option)) = closure0()
    let v4 : US0 = US0_0
    if State.trace_state.IsNone then State.trace_state <- v3 v4 |> Some
    let struct (v5 : Mut0, v6 : Mut1, v7 : Mut2, v8 : Mut3, v9 : int64 option) = State.trace_state.Value
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
    let v36 : string = method10()
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
    let v64 : string = method10()
    let v65 : (string -> string) = v63.ToString
    let v66 : string = v65 v64
    v66 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v67 : string = method11()
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
    let v93 : string = method12()
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
    let v121 : string = method12()
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
    let v149 : string = method12()
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
    let v299 : string = method13()
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
    let v312 : string = method13()
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
    let v325 : string = method13()
    let v326 : string = v324 + v215 
    let v327 : string = v326 + v325 
    v327 
    #endif
    |> fun x -> _v216 <- Some x
    let v328 : string = match _v216 with Some x -> x | None -> failwith "base.run_target / _v216=None"
    let v329 : int64 = v5.l0
    let struct (v330 : int64, v331 : string) = v2 ()
    let v332 : string = ""
    let v333 : Mut4 = {l0 = v332} : Mut4
    method40(v333, v330, v331)
    let v334 : string = v333.l0
    let v335 : string = $"{v152} {v328} #{v329} %s{v1 ()} / {v334}"
    let v336 : char list = []
    let v337 : (char list -> (char [])) = List.toArray
    let v338 : (char []) = v337 v336
    let v339 : string = v335.TrimStart v338 
    let v340 : char list = []
    let v341 : char list = '/' :: v340 
    let v342 : char list = ' ' :: v341 
    let v343 : (char list -> (char [])) = List.toArray
    let v344 : (char []) = v343 v342
    let v345 : string = v339.TrimEnd v344 
    v345
and method39 (v0 : US0, v1 : (unit -> string), v2 : (unit -> struct (int64 * string))) : unit =
    let v3 : (unit -> string) = closure39(v0, v1, v2)
    method17(v0, v3)
and method33 (v0 : string, v1 : int64) : Async<string option> =
    let v2 : bool = true
    let mutable _v2 : Async<string option> option = None 
    
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
    let v8 : Async<string option> option = None
    let mutable _v8 = v8 
    async {
    try
    let v9 : bool = v1 > 0L
    if v9 then
        let v10 : bool = true
        let mutable _v10 : Async<int64> option = None 
        
#if FABLE_COMPILER || WASM || CONTRACT
        
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
#if FABLE_COMPILER_TYPESCRIPT
        let v14 : Async<int64> = null |> unbox<Async<int64>>
        v14 
        #endif
#if FABLE_COMPILER_PYTHON
        let v15 : Async<int64> = null |> unbox<Async<int64>>
        v15 
        #endif
#else
        let v16 : int64 = 0L
        let v17 : Async<int64> = method22(v0, v16)
        v17 
        #endif
        |> fun x -> _v10 <- Some x
        let v18 : Async<int64> = match _v10 with Some x -> x | None -> failwith "base.run_target / _v10=None"
        let v19 : bool = true
        let mutable _v19 : Async<US2> option = None 
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v20 : Async<US2> = null |> unbox<Async<US2>>
        v20 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v21 : Async<US2> = null |> unbox<Async<US2>>
        v21 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v22 : Async<US2> = null |> unbox<Async<US2>>
        v22 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v23 : Async<US2> = null |> unbox<Async<US2>>
        v23 
        #endif
#if FABLE_COMPILER_PYTHON
        let v24 : Async<US2> = null |> unbox<Async<US2>>
        v24 
        #endif
#else
        let v25 : bool = true
        let mutable _v25 : Async<US2> option = None 
        
#if FABLE_COMPILER || WASM || CONTRACT
        
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
#if FABLE_COMPILER_TYPESCRIPT
        let v29 : Async<US2> = null |> unbox<Async<US2>>
        v29 
        #endif
#if FABLE_COMPILER_PYTHON
        let v30 : Async<US2> = null |> unbox<Async<US2>>
        v30 
        #endif
#else
        let v31 : Async<US2> option = None
        let mutable _v31 = v31 
        async {
        let v32 : bool = true
        let mutable _v32 : Async<Async<int64>> option = None 
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v33 : Async<Async<int64>> = null |> unbox<Async<Async<int64>>>
        v33 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v34 : Async<Async<int64>> = null |> unbox<Async<Async<int64>>>
        v34 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v35 : Async<Async<int64>> = null |> unbox<Async<Async<int64>>>
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
#else
        let v38 : Async<Async<int64>> = Async.StartChild (v18, 1000)
        v38 
        #endif
        |> fun x -> _v32 <- Some x
        let v39 : Async<Async<int64>> = match _v32 with Some x -> x | None -> failwith "base.run_target / _v32=None"
        let! v39 = v39 
        let v40 : Async<int64> = v39 
        let v41 : bool = true
        let mutable _v41 : Async<Choice<int64, exn>> option = None 
        
#if FABLE_COMPILER || WASM || CONTRACT
        
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
#if FABLE_COMPILER_TYPESCRIPT
        let v45 : Async<Choice<int64, exn>> = null |> unbox<Async<Choice<int64, exn>>>
        v45 
        #endif
#if FABLE_COMPILER_PYTHON
        let v46 : Async<Choice<int64, exn>> = null |> unbox<Async<Choice<int64, exn>>>
        v46 
        #endif
#else
        let v47 : (Async<int64> -> Async<Choice<int64, exn>>) = Async.Catch
        let v48 : Async<Choice<int64, exn>> = v47 v40
        v48 
        #endif
        |> fun x -> _v41 <- Some x
        let v49 : Async<Choice<int64, exn>> = match _v41 with Some x -> x | None -> failwith "base.run_target / _v41=None"
        let v50 : bool = true
        let mutable _v50 : Async<US9> option = None 
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v51 : Async<US9> = null |> unbox<Async<US9>>
        v51 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v52 : Async<US9> = null |> unbox<Async<US9>>
        v52 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v53 : Async<US9> = null |> unbox<Async<US9>>
        v53 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v54 : Async<US9> = null |> unbox<Async<US9>>
        v54 
        #endif
#if FABLE_COMPILER_PYTHON
        let v55 : Async<US9> = null |> unbox<Async<US9>>
        v55 
        #endif
#else
        let v56 : Async<US9> option = None
        let mutable _v56 = v56 
        async {
        let! v49 = v49 
        let v57 : Choice<int64, exn> = v49 
        let v58 : bool = true
        let mutable _v58 : US9 option = None 
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v59 : US9 = null |> unbox<US9>
        v59 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v60 : US9 = null |> unbox<US9>
        v60 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v61 : US9 = null |> unbox<US9>
        v61 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v62 : US9 = null |> unbox<US9>
        v62 
        #endif
#if FABLE_COMPILER_PYTHON
        let v63 : US9 = null |> unbox<US9>
        v63 
        #endif
#else
        let v64 : (int64 -> US9) = closure29()
        let v65 : (exn -> US9) = closure30()
        let v66 : US9 = match v57 with Choice1Of2 x -> v64 x | Choice2Of2 x -> v65 x
        v66 
        #endif
        |> fun x -> _v58 <- Some x
        let v67 : US9 = match _v58 with Some x -> x | None -> failwith "base.run_target / _v58=None"
        return v67 
        }
        |> fun x -> _v56 <- Some x
        let v68 : Async<US9> = match _v56 with Some x -> x | None -> failwith "async.new_async_unit / _v56=None"
        v68 
        #endif
        |> fun x -> _v50 <- Some x
        let v69 : Async<US9> = match _v50 with Some x -> x | None -> failwith "base.run_target / _v50=None"
        let v70 : bool = true
        let mutable _v70 : Async<US10> option = None 
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v71 : Async<US10> = null |> unbox<Async<US10>>
        v71 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v72 : Async<US10> = null |> unbox<Async<US10>>
        v72 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v73 : Async<US10> = null |> unbox<Async<US10>>
        v73 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v74 : Async<US10> = null |> unbox<Async<US10>>
        v74 
        #endif
#if FABLE_COMPILER_PYTHON
        let v75 : Async<US10> = null |> unbox<Async<US10>>
        v75 
        #endif
#else
        let v76 : Async<US10> option = None
        let mutable _v76 = v76 
        async {
        let! v69 = v69 
        let v77 : US9 = v69 
        let v83 : US10 =
            match v77 with
            | US9_0(v78) -> (* C1of2 *)
                US10_0(v78)
            | US9_1(v80) -> (* C2of2 *)
                US10_1(v80)
        return v83 
        }
        |> fun x -> _v76 <- Some x
        let v84 : Async<US10> = match _v76 with Some x -> x | None -> failwith "async.new_async_unit / _v76=None"
        v84 
        #endif
        |> fun x -> _v70 <- Some x
        let v85 : Async<US10> = match _v70 with Some x -> x | None -> failwith "base.run_target / _v70=None"
        let v86 : bool = true
        let mutable _v86 : Async<US2> option = None 
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v87 : Async<US2> = null |> unbox<Async<US2>>
        v87 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v88 : Async<US2> = null |> unbox<Async<US2>>
        v88 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v89 : Async<US2> = null |> unbox<Async<US2>>
        v89 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v90 : Async<US2> = null |> unbox<Async<US2>>
        v90 
        #endif
#if FABLE_COMPILER_PYTHON
        let v91 : Async<US2> = null |> unbox<Async<US2>>
        v91 
        #endif
#else
        let v92 : Async<US2> option = None
        let mutable _v92 = v92 
        async {
        let! v85 = v85 
        let v93 : US10 = v85 
        let v110 : US2 =
            match v93 with
            | US10_1(v96) -> (* Error *)
                let v97 : string = $"%A{v96}"
                let v98 : string = "System.TimeoutException"
                let v99 : bool = v97.Contains v98 
                if v99 then
                    let v100 : US0 = US0_0
                    let v101 : (unit -> string) = closure31()
                    let v102 : (unit -> int32) = closure32()
                    method34(v100, v101, v102)
                    US2_1
                else
                    let v104 : US0 = US0_4
                    let v105 : (unit -> string) = closure34()
                    let v106 : (unit -> struct (int32 * string)) = closure35(v96)
                    method37(v104, v105, v106)
                    US2_1
            | US10_0(v94) -> (* Ok *)
                US2_0(v94)
        return v110 
        }
        |> fun x -> _v92 <- Some x
        let v111 : Async<US2> = match _v92 with Some x -> x | None -> failwith "async.new_async_unit / _v92=None"
        v111 
        #endif
        |> fun x -> _v86 <- Some x
        let v112 : Async<US2> = match _v86 with Some x -> x | None -> failwith "base.run_target / _v86=None"
        return! v112 
        }
        |> fun x -> _v31 <- Some x
        let v113 : Async<US2> = match _v31 with Some x -> x | None -> failwith "async.new_async_unit / _v31=None"
        v113 
        #endif
        |> fun x -> _v25 <- Some x
        let v114 : Async<US2> = match _v25 with Some x -> x | None -> failwith "base.run_target / _v25=None"
        v114 
        #endif
        |> fun x -> _v19 <- Some x
        let v115 : Async<US2> = match _v19 with Some x -> x | None -> failwith "base.run_target / _v19=None"
        let v116 : bool = true
        let mutable _v116 : Async<unit> option = None 
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v117 : Async<unit> = null |> unbox<Async<unit>>
        v117 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v118 : Async<unit> = null |> unbox<Async<unit>>
        v118 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v119 : Async<unit> = null |> unbox<Async<unit>>
        v119 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v120 : Async<unit> = null |> unbox<Async<unit>>
        v120 
        #endif
#if FABLE_COMPILER_PYTHON
        let v121 : Async<unit> = null |> unbox<Async<unit>>
        v121 
        #endif
#else
        let v122 : (Async<US2> -> Async<unit>) = Async.Ignore
        let v123 : Async<unit> = v122 v115
        v123 
        #endif
        |> fun x -> _v116 <- Some x
        let v124 : Async<unit> = match _v116 with Some x -> x | None -> failwith "base.run_target / _v116=None"
        do! v124 
        ()
    let v125 : bool = true
    let mutable _v125 : Async<string> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v126 : Async<string> = null |> unbox<Async<string>>
    v126 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v127 : Async<string> = null |> unbox<Async<string>>
    v127 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v128 : Async<string> = null |> unbox<Async<string>>
    v128 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v129 : Async<string> = null |> unbox<Async<string>>
    v129 
    #endif
#if FABLE_COMPILER_PYTHON
    let v130 : Async<string> = null |> unbox<Async<string>>
    v130 
    #endif
#else
    let v131 : (string -> System.Threading.Tasks.Task<string>) = System.IO.File.ReadAllTextAsync
    let v132 : System.Threading.Tasks.Task<string> = v131 v0
    let v133 : bool = true
    let mutable _v133 : Async<string> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v134 : Async<string> = null |> unbox<Async<string>>
    v134 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v135 : Async<string> = null |> unbox<Async<string>>
    v135 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v136 : Async<string> = null |> unbox<Async<string>>
    v136 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v137 : Async<string> = null |> unbox<Async<string>>
    v137 
    #endif
#if FABLE_COMPILER_PYTHON
    let v138 : Async<string> = null |> unbox<Async<string>>
    v138 
    #endif
#else
    let v139 : (System.Threading.Tasks.Task<string> -> Async<string>) = Async.AwaitTask
    let v140 : Async<string> = v139 v132
    v140 
    #endif
    |> fun x -> _v133 <- Some x
    let v141 : Async<string> = match _v133 with Some x -> x | None -> failwith "base.run_target / _v133=None"
    v141 
    #endif
    |> fun x -> _v125 <- Some x
    let v142 : Async<string> = match _v125 with Some x -> x | None -> failwith "base.run_target / _v125=None"
    let v143 : bool = true
    let mutable _v143 : Async<string option> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v144 : Async<string option> = null |> unbox<Async<string option>>
    v144 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v145 : Async<string option> = null |> unbox<Async<string option>>
    v145 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v146 : Async<string option> = null |> unbox<Async<string option>>
    v146 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v147 : Async<string option> = null |> unbox<Async<string option>>
    v147 
    #endif
#if FABLE_COMPILER_PYTHON
    let v148 : Async<string option> = null |> unbox<Async<string option>>
    v148 
    #endif
#else
    let v149 : Async<string option> option = None
    let mutable _v149 = v149 
    async {
    let! v142 = v142 
    let v150 : string = v142 
    let v151 : string option = Some v150 
    return v151 
    }
    |> fun x -> _v149 <- Some x
    let v152 : Async<string option> = match _v149 with Some x -> x | None -> failwith "async.new_async_unit / _v149=None"
    v152 
    #endif
    |> fun x -> _v143 <- Some x
    let v153 : Async<string option> = match _v143 with Some x -> x | None -> failwith "base.run_target / _v143=None"
    return! v153 
    with ex ->
    let v154 : exn = ex
    let v155 : bool = v1 = 0L
    let v156 : bool = v155 <> true
    if v156 then
        let v157 : bool = true
        let mutable _v157 : string option = None 
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v158 : string = $"%A{v154}"
        v158 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v159 : string = $"%A{v154}"
        v159 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v160 : string = $"%A{v154}"
        v160 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v161 : string = $"%A{v154}"
        v161 
        #endif
#if FABLE_COMPILER_PYTHON
        let v162 : string = $"%A{v154}"
        v162 
        #endif
#else
        let v163 : string = $"{v154.GetType ()}: {v154.Message}"
        v163 
        #endif
        |> fun x -> _v157 <- Some x
        let v164 : string = match _v157 with Some x -> x | None -> failwith "base.run_target / _v157=None"
        let v165 : US0 = US0_1
        let v166 : (unit -> string) = closure37()
        let v167 : (unit -> struct (int64 * string)) = closure38(v1, v164)
        method39(v165, v166, v167)
        let v168 : string option = None
        return v168 
        (*
        ()
    else
        *) else
        let v169 : int64 = v1 + 1L
        let v170 : Async<string option> = method33(v0, v169)
        return! v170 
        (*
        ()
    *)
    (*
    let v171 : string option = *)
    }
    |> fun x -> _v8 <- Some x
    let v172 : Async<string option> = match _v8 with Some x -> x | None -> failwith "async.new_async_unit / _v8=None"
    v172 
    #endif
    |> fun x -> _v2 <- Some x
    let v173 : Async<string option> = match _v2 with Some x -> x | None -> failwith "base.run_target / _v2=None"
    v173
and closure28 () (v0 : string) : Async<string option> =
    let v1 : bool = true
    let mutable _v1 : Async<string option> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : Async<string option> = null |> unbox<Async<string option>>
    v2 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v3 : Async<string option> = null |> unbox<Async<string option>>
    v3 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v4 : Async<string option> = null |> unbox<Async<string option>>
    v4 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v5 : Async<string option> = null |> unbox<Async<string option>>
    v5 
    #endif
#if FABLE_COMPILER_PYTHON
    let v6 : Async<string option> = null |> unbox<Async<string option>>
    v6 
    #endif
#else
    let v7 : int64 = 0L
    let v8 : Async<string option> = method33(v0, v7)
    v8 
    #endif
    |> fun x -> _v1 <- Some x
    let v9 : Async<string option> = match _v1 with Some x -> x | None -> failwith "base.run_target / _v1=None"
    v9
and method43 (v0 : chrono_DateTime<chrono_Utc>) : chrono_DateTime<chrono_Utc> =
    v0
and method44 (v0 : chrono_DateTime<chrono_Local>) : chrono_DateTime<chrono_Local> =
    v0
and method45 () : string =
    let v0 : string = "hh:mm"
    v0
and method46 () : string =
    let v0 : string = "yyyyMMdd-HHmm-ssff-ffff-f"
    v0
and method47 () : string =
    let v0 : string = "hhmm"
    v0
and method42 (v0 : System.Guid, v1 : System.DateTime) : System.Guid =
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
    let v18 : US11 option = None
    let _v18 = ref v18 
    match v17 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v19 : chrono_DateTime<chrono_Utc> = x
    let v20 : US11 = US11_0(v19)
    v20 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v18.Value <- x
    let v21 : US11 option = _v18.Value 
    let v22 : US11 = US11_1
    let v23 : US11 = v21 |> Option.defaultValue v22 
    let v42 : US3 =
        match v23 with
        | US11_1 -> (* None *)
            US3_1
        | US11_0(v24) -> (* Some *)
            let v25 : chrono_DateTime<chrono_Utc> = method43(v24)
            let v26 : string = "v25.naive_utc()"
            let v27 : chrono_NaiveDateTime = Fable.Core.RustInterop.emitRustExpr () v26 
            let v28 : string = "chrono::offset::TimeZone::from_utc_datetime(&chrono::Local, &v27)"
            let v29 : chrono_DateTime<chrono_Local> = Fable.Core.RustInterop.emitRustExpr () v28 
            let v30 : string = "%Y%m%d-%H%M-%S%f"
            let v31 : string = "r#\"" + v30 + "\"#"
            let v32 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v31 
            let v33 : chrono_DateTime<chrono_Local> = method44(v29)
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
    let v63 : US4 = US4_0
    let v64 : US5 = US5_3(v63)
    let v65 : string = $"date_time.get_utc_offset / target: {v64}"
    let v66 : System.TimeSpan = failwith<System.TimeSpan> v65
    v66 
    #endif
#if FABLE_COMPILER_PYTHON
    let v67 : US4 = US4_0
    let v68 : US5 = US5_4(v67)
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
    let v88 : string = method45()
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
    let v116 : US11 option = None
    let _v116 = ref v116 
    match v115 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v117 : chrono_DateTime<chrono_Utc> = x
    let v118 : US11 = US11_0(v117)
    v118 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v116.Value <- x
    let v119 : US11 option = _v116.Value 
    let v120 : US11 = US11_1
    let v121 : US11 = v119 |> Option.defaultValue v120 
    let v140 : US3 =
        match v121 with
        | US11_1 -> (* None *)
            US3_1
        | US11_0(v122) -> (* Some *)
            let v123 : chrono_DateTime<chrono_Utc> = method43(v122)
            let v124 : string = "v123.naive_utc()"
            let v125 : chrono_NaiveDateTime = Fable.Core.RustInterop.emitRustExpr () v124 
            let v126 : string = "chrono::offset::TimeZone::from_utc_datetime(&chrono::Local, &v125)"
            let v127 : chrono_DateTime<chrono_Local> = Fable.Core.RustInterop.emitRustExpr () v126 
            let v128 : string = "%Y%m%d-%H%M-%S%f"
            let v129 : string = "r#\"" + v128 + "\"#"
            let v130 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v129 
            let v131 : chrono_DateTime<chrono_Local> = method44(v127)
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
    let v161 : US4 = US4_0
    let v162 : US5 = US5_3(v161)
    let v163 : string = $"date_time.get_utc_offset / target: {v162}"
    let v164 : System.TimeSpan = failwith<System.TimeSpan> v163
    v164 
    #endif
#if FABLE_COMPILER_PYTHON
    let v165 : US4 = US4_0
    let v166 : US5 = US5_4(v165)
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
    let v186 : string = method45()
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
    let v200 : string = method46()
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
    let v219 : US4 = US4_0
    let v220 : US5 = US5_3(v219)
    let v221 : string = $"date_time.get_utc_offset / target: {v220}"
    let v222 : System.TimeSpan = failwith<System.TimeSpan> v221
    v222 
    #endif
#if FABLE_COMPILER_PYTHON
    let v223 : US4 = US4_0
    let v224 : US5 = US5_4(v223)
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
    let v244 : string = method47()
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
    let v257 : string = method46()
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
    let v276 : US4 = US4_0
    let v277 : US5 = US5_3(v276)
    let v278 : string = $"date_time.get_utc_offset / target: {v277}"
    let v279 : System.TimeSpan = failwith<System.TimeSpan> v278
    v279 
    #endif
#if FABLE_COMPILER_PYTHON
    let v280 : US4 = US4_0
    let v281 : US5 = US5_4(v280)
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
    let v301 : string = method47()
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
    let v314 : string = method46()
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
    let v333 : US4 = US4_0
    let v334 : US5 = US5_3(v333)
    let v335 : string = $"date_time.get_utc_offset / target: {v334}"
    let v336 : System.TimeSpan = failwith<System.TimeSpan> v335
    v336 
    #endif
#if FABLE_COMPILER_PYTHON
    let v337 : US4 = US4_0
    let v338 : US5 = US5_4(v337)
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
    let v358 : string = method47()
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
and method49 () : string =
    let v0 : bool = true
    let mutable _v0 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1 : string = "std::env::temp_dir()"
    let v2 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr () v1 
    let v3 : string = "$0.display()"
    let v4 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v2 v3 
    let v5 : bool = true
    let mutable _v5 : std_string_String option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v6 : string = "format!(\"{}\", $0)"
    let v7 : std_string_String = Fable.Core.RustInterop.emitRustExpr v4 v6 
    v7 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v8 : string = "format!(\"{}\", $0)"
    let v9 : std_string_String = Fable.Core.RustInterop.emitRustExpr v4 v8 
    v9 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v10 : string = "format!(\"{}\", $0)"
    let v11 : std_string_String = Fable.Core.RustInterop.emitRustExpr v4 v10 
    v11 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v12 : std_string_String = null |> unbox<std_string_String>
    v12 
    #endif
#if FABLE_COMPILER_PYTHON
    let v13 : std_string_String = null |> unbox<std_string_String>
    v13 
    #endif
#else
    let v14 : std_string_String = null |> unbox<std_string_String>
    v14 
    #endif
    |> fun x -> _v5 <- Some x
    let v15 : std_string_String = match _v5 with Some x -> x | None -> failwith "base.run_target / _v5=None"
    let v16 : string = "fable_library_rust::String_::fromString($0)"
    let v17 : string = Fable.Core.RustInterop.emitRustExpr v15 v16 
    v17 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v18 : US4 = US4_1
    let v19 : US5 = US5_2(v18)
    let v20 : string = $"file_system.get_temp_path / target: {v19}"
    let v21 : string = failwith<string> v20
    v21 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v22 : string = null |> unbox<string>
    v22 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v23 : US4 = US4_0
    let v24 : US5 = US5_3(v23)
    let v25 : string = $"file_system.get_temp_path / target: {v24}"
    let v26 : string = failwith<string> v25
    v26 
    #endif
#if FABLE_COMPILER_PYTHON
    let v27 : US4 = US4_0
    let v28 : US5 = US5_4(v27)
    let v29 : string = $"file_system.get_temp_path / target: {v28}"
    let v30 : string = failwith<string> v29
    v30 
    #endif
#else
    let v31 : (unit -> string) = System.IO.Path.GetTempPath
    let v32 : string = v31 ()
    v32 
    #endif
    |> fun x -> _v0 <- Some x
    let v33 : string = match _v0 with Some x -> x | None -> failwith "base.run_target / _v0=None"
    v33
and method50 () : string =
    let v0 : string = "!create_temp_path_"
    v0
and method53 (v0 : string) : string =
    v0
and method52 (v0 : string, v1 : string) : struct (string * string) =
    let v2 : string = method53(v0)
    struct (v1, v2)
and method51 (v0 : string, v1 : string) : string =
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
    let v30 : US4 = US4_1
    let v31 : US5 = US5_2(v30)
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
    let struct (v37 : string, v38 : string) = method52(v1, v0)
    let v39 : string = "v36.join($0, $1)"
    let v40 : string = Fable.Core.JsInterop.emitJsExpr struct (v37, v38) v39 
    v40 
    #endif
#if FABLE_COMPILER_PYTHON
    let v41 : US4 = US4_0
    let v42 : US5 = US5_4(v41)
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
and method55 () : string =
    let v0 : string = "CARGO_PKG_NAME"
    v0
and method54 () : string =
    let v0 : bool = true
    let mutable _v0 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1 : string = method55()
    let v2 : string = method1(v1)
    v2 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v3 : string = method55()
    let v4 : string = method1(v3)
    v4 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v5 : string = method55()
    let v6 : string = method1(v5)
    v6 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v7 : US4 = US4_0
    let v8 : US5 = US5_3(v7)
    let v9 : string = $"env.get_entry_assembly_name / target: {v8}"
    let v10 : string = failwith<string> v9
    v10 
    #endif
#if FABLE_COMPILER_PYTHON
    let v11 : US4 = US4_0
    let v12 : US5 = US5_4(v11)
    let v13 : string = $"env.get_entry_assembly_name / target: {v12}"
    let v14 : string = failwith<string> v13
    v14 
    #endif
#else
    let v15 : string = System.Reflection.Assembly.GetEntryAssembly().GetName().Name
    v15 
    #endif
    |> fun x -> _v0 <- Some x
    let v16 : string = match _v0 with Some x -> x | None -> failwith "base.run_target / _v0=None"
    v16
and method48 (v0 : System.Guid) : string =
    let v1 : bool = true
    let mutable _v1 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = method49()
    let v3 : string = method50()
    let v4 : string = method51(v2, v3)
    let v5 : string = method54()
    let v6 : string = method51(v4, v5)
    let v7 : (System.Guid -> string) = _.ToString()
    let v8 : string = v7 v0
    let v9 : string = method51(v6, v8)
    v9 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v10 : string = method49()
    let v11 : string = method50()
    let v12 : string = method51(v10, v11)
    let v13 : string = method54()
    let v14 : string = method51(v12, v13)
    let v15 : (System.Guid -> string) = _.ToString()
    let v16 : string = v15 v0
    let v17 : string = method51(v14, v16)
    v17 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v18 : string = null |> unbox<string>
    v18 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v19 : string = method49()
    let v20 : string = method50()
    let v21 : string = method51(v19, v20)
    let v22 : string = method54()
    let v23 : string = method51(v21, v22)
    let v24 : (System.Guid -> string) = _.ToString()
    let v25 : string = v24 v0
    let v26 : string = method51(v23, v25)
    v26 
    #endif
#if FABLE_COMPILER_PYTHON
    let v27 : string = method49()
    let v28 : string = method50()
    let v29 : string = method51(v27, v28)
    let v30 : string = method54()
    let v31 : string = method51(v29, v30)
    let v32 : (System.Guid -> string) = _.ToString()
    let v33 : string = v32 v0
    let v34 : string = method51(v31, v33)
    v34 
    #endif
#else
    let v35 : string = method49()
    let v36 : string = method50()
    let v37 : string = method51(v35, v36)
    let v38 : string = method54()
    let v39 : string = method51(v37, v38)
    let v40 : (System.Guid -> string) = _.ToString()
    let v41 : string = v40 v0
    let v42 : string = method51(v39, v41)
    v42 
    #endif
    |> fun x -> _v1 <- Some x
    let v43 : string = match _v1 with Some x -> x | None -> failwith "base.run_target / _v1=None"
    v43
and method41 () : string =
    let v0 : bool = true
    let mutable _v0 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1 : System.DateTime = System.DateTime.Now
    let v2 : (unit -> System.Guid) = System.Guid.NewGuid
    let v3 : System.Guid = v2 ()
    let v4 : System.Guid = method42(v3, v1)
    let v5 : string = method48(v4)
    v5 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v6 : System.DateTime = System.DateTime.Now
    let v7 : (unit -> System.Guid) = System.Guid.NewGuid
    let v8 : System.Guid = v7 ()
    let v9 : System.Guid = method42(v8, v6)
    let v10 : string = method48(v9)
    v10 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v11 : string = null |> unbox<string>
    v11 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v12 : System.DateTime = System.DateTime.Now
    let v13 : (unit -> System.Guid) = System.Guid.NewGuid
    let v14 : System.Guid = v13 ()
    let v15 : System.Guid = method42(v14, v12)
    let v16 : string = method48(v15)
    v16 
    #endif
#if FABLE_COMPILER_PYTHON
    let v17 : System.DateTime = System.DateTime.Now
    let v18 : (unit -> System.Guid) = System.Guid.NewGuid
    let v19 : System.Guid = v18 ()
    let v20 : System.Guid = method42(v19, v17)
    let v21 : string = method48(v20)
    v21 
    #endif
#else
    let v22 : System.DateTime = System.DateTime.Now
    let v23 : (unit -> System.Guid) = System.Guid.NewGuid
    let v24 : System.Guid = v23 ()
    let v25 : System.Guid = method42(v24, v22)
    let v26 : string = method48(v25)
    v26 
    #endif
    |> fun x -> _v0 <- Some x
    let v27 : string = match _v0 with Some x -> x | None -> failwith "base.run_target / _v0=None"
    v27
and closure40 () () : string =
    method41()
and method57 (v0 : string) : string =
    v0
and closure42 () (v0 : std_io_Error) : std_string_String =
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
and method58 () : (std_io_Error -> std_string_String) =
    closure42()
and closure43 () () : US12 =
    US12_0
and closure44 () (v0 : std_string_String) : US12 =
    US12_1(v0)
and closure45 () () : string =
    let v0 : string = "file_system.create_dir"
    v0
and closure46 (v0 : string, v1 : std_string_String) () : struct (string * std_string_String) =
    struct (v0, v1)
and method61 (v0 : Mut4, v1 : std_string_String) : unit =
    let v2 : string = $"%A{v1}"
    method15(v0, v2)
and method60 (v0 : Mut4, v1 : string, v2 : std_string_String) : unit =
    let v3 : string = "{ "
    method15(v0, v3)
    method16(v0)
    let v4 : string = "dir"
    method15(v0, v4)
    let v5 : string = " = "
    method15(v0, v5)
    method15(v0, v1)
    let v6 : string = "; "
    method15(v0, v6)
    let v7 : string = "error"
    method15(v0, v7)
    method15(v0, v5)
    method61(v0, v2)
    let v8 : string = " }"
    method15(v0, v8)
and closure47 (v0 : US0, v1 : (unit -> string), v2 : (unit -> struct (string * std_string_String))) () : string =
    let v3 : (US0 -> struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option)) = closure0()
    let v4 : US0 = US0_0
    if State.trace_state.IsNone then State.trace_state <- v3 v4 |> Some
    let struct (v5 : Mut0, v6 : Mut1, v7 : Mut2, v8 : Mut3, v9 : int64 option) = State.trace_state.Value
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
    let v36 : string = method10()
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
    let v64 : string = method10()
    let v65 : (string -> string) = v63.ToString
    let v66 : string = v65 v64
    v66 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v67 : string = method11()
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
    let v93 : string = method12()
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
    let v121 : string = method12()
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
    let v149 : string = method12()
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
    let v299 : string = method13()
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
    let v312 : string = method13()
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
    let v325 : string = method13()
    let v326 : string = v324 + v215 
    let v327 : string = v326 + v325 
    v327 
    #endif
    |> fun x -> _v216 <- Some x
    let v328 : string = match _v216 with Some x -> x | None -> failwith "base.run_target / _v216=None"
    let v329 : int64 = v5.l0
    let struct (v330 : string, v331 : std_string_String) = v2 ()
    let v332 : string = ""
    let v333 : Mut4 = {l0 = v332} : Mut4
    method60(v333, v330, v331)
    let v334 : string = v333.l0
    let v335 : string = $"{v152} {v328} #{v329} %s{v1 ()} / {v334}"
    let v336 : char list = []
    let v337 : (char list -> (char [])) = List.toArray
    let v338 : (char []) = v337 v336
    let v339 : string = v335.TrimStart v338 
    let v340 : char list = []
    let v341 : char list = '/' :: v340 
    let v342 : char list = ' ' :: v341 
    let v343 : (char list -> (char [])) = List.toArray
    let v344 : (char []) = v343 v342
    let v345 : string = v339.TrimEnd v344 
    v345
and method59 (v0 : US0, v1 : (unit -> string), v2 : (unit -> struct (string * std_string_String))) : unit =
    let v3 : (unit -> string) = closure47(v0, v1, v2)
    method17(v0, v3)
and closure48 () () : string =
    let v0 : string = "file_system.create_dir"
    v0
and closure49 (v0 : string) () : string =
    v0
and method63 (v0 : Mut4, v1 : string) : unit =
    let v2 : string = "{ "
    method15(v0, v2)
    method16(v0)
    let v3 : string = "dir"
    method15(v0, v3)
    let v4 : string = " = "
    method15(v0, v4)
    method15(v0, v1)
    let v5 : string = " }"
    method15(v0, v5)
and closure50 (v0 : US0, v1 : (unit -> string), v2 : (unit -> string)) () : string =
    let v3 : (US0 -> struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option)) = closure0()
    let v4 : US0 = US0_0
    if State.trace_state.IsNone then State.trace_state <- v3 v4 |> Some
    let struct (v5 : Mut0, v6 : Mut1, v7 : Mut2, v8 : Mut3, v9 : int64 option) = State.trace_state.Value
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
    let v36 : string = method10()
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
    let v64 : string = method10()
    let v65 : (string -> string) = v63.ToString
    let v66 : string = v65 v64
    v66 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v67 : string = method11()
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
    let v93 : string = method12()
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
    let v121 : string = method12()
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
    let v149 : string = method12()
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
    let v299 : string = method13()
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
    let v312 : string = method13()
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
    let v325 : string = method13()
    let v326 : string = v324 + v215 
    let v327 : string = v326 + v325 
    v327 
    #endif
    |> fun x -> _v216 <- Some x
    let v328 : string = match _v216 with Some x -> x | None -> failwith "base.run_target / _v216=None"
    let v329 : int64 = v5.l0
    let v330 : string = v2 ()
    let v331 : string = ""
    let v332 : Mut4 = {l0 = v331} : Mut4
    method63(v332, v330)
    let v333 : string = v332.l0
    let v334 : string = $"{v152} {v328} #{v329} %s{v1 ()} / {v333}"
    let v335 : char list = []
    let v336 : (char list -> (char [])) = List.toArray
    let v337 : (char []) = v336 v335
    let v338 : string = v334.TrimStart v337 
    let v339 : char list = []
    let v340 : char list = '/' :: v339 
    let v341 : char list = ' ' :: v340 
    let v342 : (char list -> (char [])) = List.toArray
    let v343 : (char []) = v342 v341
    let v344 : string = v338.TrimEnd v343 
    v344
and method62 (v0 : US0, v1 : (unit -> string), v2 : (unit -> string)) : unit =
    let v3 : (unit -> string) = closure50(v0, v1, v2)
    method17(v0, v3)
and closure51 (v0 : string) () : unit =
    let v1 : bool = true
    method5(v1, v0)
and method64 (v0 : string) : (unit -> unit) =
    closure51(v0)
and method65 (v0 : string) : (unit -> unit) =
    closure51(v0)
and closure52 () () : string =
    let v0 : string = "file_system.create_dir"
    v0
and closure53 (v0 : string, v1 : string) () : struct (string * string) =
    struct (v0, v1)
and method67 (v0 : Mut4, v1 : string, v2 : string) : unit =
    let v3 : string = "{ "
    method15(v0, v3)
    method16(v0)
    let v4 : string = "dir"
    method15(v0, v4)
    let v5 : string = " = "
    method15(v0, v5)
    method15(v0, v1)
    let v6 : string = "; "
    method15(v0, v6)
    let v7 : string = "result"
    method15(v0, v7)
    method15(v0, v5)
    method15(v0, v2)
    let v8 : string = " }"
    method15(v0, v8)
and closure54 (v0 : US0, v1 : (unit -> string), v2 : (unit -> struct (string * string))) () : string =
    let v3 : (US0 -> struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option)) = closure0()
    let v4 : US0 = US0_0
    if State.trace_state.IsNone then State.trace_state <- v3 v4 |> Some
    let struct (v5 : Mut0, v6 : Mut1, v7 : Mut2, v8 : Mut3, v9 : int64 option) = State.trace_state.Value
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
    let v36 : string = method10()
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
    let v64 : string = method10()
    let v65 : (string -> string) = v63.ToString
    let v66 : string = v65 v64
    v66 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v67 : string = method11()
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
    let v93 : string = method12()
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
    let v121 : string = method12()
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
    let v149 : string = method12()
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
    let v299 : string = method13()
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
    let v312 : string = method13()
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
    let v325 : string = method13()
    let v326 : string = v324 + v215 
    let v327 : string = v326 + v325 
    v327 
    #endif
    |> fun x -> _v216 <- Some x
    let v328 : string = match _v216 with Some x -> x | None -> failwith "base.run_target / _v216=None"
    let v329 : int64 = v5.l0
    let struct (v330 : string, v331 : string) = v2 ()
    let v332 : string = ""
    let v333 : Mut4 = {l0 = v332} : Mut4
    method67(v333, v330, v331)
    let v334 : string = v333.l0
    let v335 : string = $"{v152} {v328} #{v329} %s{v1 ()} / {v334}"
    let v336 : char list = []
    let v337 : (char list -> (char [])) = List.toArray
    let v338 : (char []) = v337 v336
    let v339 : string = v335.TrimStart v338 
    let v340 : char list = []
    let v341 : char list = '/' :: v340 
    let v342 : char list = ' ' :: v341 
    let v343 : (char list -> (char [])) = List.toArray
    let v344 : (char []) = v343 v342
    let v345 : string = v339.TrimEnd v344 
    v345
and method66 (v0 : US0, v1 : (unit -> string), v2 : (unit -> struct (string * string))) : unit =
    let v3 : (unit -> string) = closure54(v0, v1, v2)
    method17(v0, v3)
and closure55 (v0 : string) () : unit =
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
    let v8 : Async<int64> = method4(v0, v7)
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
and method68 (v0 : string) : (unit -> unit) =
    closure55(v0)
and method69 (v0 : string) : (unit -> unit) =
    closure55(v0)
and method56 (v0 : string) : System.IDisposable =
    let v1 : bool = true
    let mutable _v1 : System.IDisposable option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = method57(v0)
    let v3 : string = "std::fs::create_dir_all(&*$0)"
    let v4 : Result<unit, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v2 v3 
    let v5 : (std_io_Error -> std_string_String) = method58()
    let v6 : string = "$0.map_err(|x| $1(x))"
    let v7 : Result<unit, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v4, v5) v6 
    let v8 : (unit -> US12) = closure43()
    let v9 : (std_string_String -> US12) = closure44()
    let v10 : US12 = match v7 with Ok () -> v8 () | Error x -> v9 x
    match v10 with
    | US12_1(v14) -> (* Error *)
        let v15 : US0 = US0_4
        let v16 : (unit -> string) = closure45()
        let v17 : (unit -> struct (string * std_string_String)) = closure46(v2, v14)
        method59(v15, v16, v17)
    | US12_0 -> (* Ok *)
        let v11 : US0 = US0_0
        let v12 : (unit -> string) = closure48()
        let v13 : (unit -> string) = closure49(v2)
        method62(v11, v12, v13)
    let v18 : bool = true
    let mutable _v18 : System.IDisposable option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v19 : (unit -> unit) = method64(v2)
    let v20 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v19 "$0()" )
    v20 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v21 : (unit -> unit) = method64(v2)
    let v22 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v21 "$0()" )
    v22 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v23 : (unit -> unit) = method64(v2)
    let v24 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v23 "$0()" )
    v24 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v25 : (unit -> unit) = method65(v2)
    let v26 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v25 () }
    v26 
    #endif
#if FABLE_COMPILER_PYTHON
    let v27 : (unit -> unit) = method65(v2)
    let v28 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v27 () }
    v28 
    #endif
#else
    let v29 : (unit -> unit) = method65(v2)
    let v30 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v29 () }
    v30 
    #endif
    |> fun x -> _v18 <- Some x
    let v31 : System.IDisposable = match _v18 with Some x -> x | None -> failwith "base.run_target / _v18=None"
    v31 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v32 : System.IDisposable = null |> unbox<System.IDisposable>
    v32 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v33 : System.IDisposable = null |> unbox<System.IDisposable>
    v33 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v34 : bool = true
    let mutable _v34 : System.IO.DirectoryInfo option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v35 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    v35 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v36 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    v36 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v37 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    v37 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v38 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    v38 
    #endif
#if FABLE_COMPILER_PYTHON
    let v39 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    v39 
    #endif
#else
    let v40 : (string -> System.IO.DirectoryInfo) = System.IO.Directory.CreateDirectory
    let v41 : System.IO.DirectoryInfo = v40 v0
    v41 
    #endif
    |> fun x -> _v34 <- Some x
    let v42 : System.IO.DirectoryInfo = match _v34 with Some x -> x | None -> failwith "base.run_target / _v34=None"
    let v43 : bool = true
    let mutable _v43 : bool option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v44 : bool = null |> unbox<bool>
    v44 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v45 : bool = null |> unbox<bool>
    v45 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v46 : bool = null |> unbox<bool>
    v46 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v47 : bool = null |> unbox<bool>
    v47 
    #endif
#if FABLE_COMPILER_PYTHON
    let v48 : bool = null |> unbox<bool>
    v48 
    #endif
#else
    let v49 : bool = v42.Exists
    v49 
    #endif
    |> fun x -> _v43 <- Some x
    let v50 : bool = match _v43 with Some x -> x | None -> failwith "base.run_target / _v43=None"
    let v51 : bool = v50 = false
    if v51 then
        let v52 : bool = true
        let mutable _v52 : System.DateTime option = None 
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v53 : System.DateTime = null |> unbox<System.DateTime>
        v53 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v54 : System.DateTime = null |> unbox<System.DateTime>
        v54 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v55 : System.DateTime = null |> unbox<System.DateTime>
        v55 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v56 : System.DateTime = null |> unbox<System.DateTime>
        v56 
        #endif
#if FABLE_COMPILER_PYTHON
        let v57 : System.DateTime = null |> unbox<System.DateTime>
        v57 
        #endif
#else
        let v58 : System.DateTime = v42.CreationTime
        v58 
        #endif
        |> fun x -> _v52 <- Some x
        let v59 : System.DateTime = match _v52 with Some x -> x | None -> failwith "base.run_target / _v52=None"
        let v60 : obj = {| Exists = v50; CreationTime = v59 |}
        let v61 : string = $"%A{v60}"
        let v62 : US0 = US0_1
        let v63 : (unit -> string) = closure52()
        let v64 : (unit -> struct (string * string)) = closure53(v0, v61)
        method66(v62, v63, v64)
    let v65 : bool = true
    let mutable _v65 : System.IDisposable option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v66 : (unit -> unit) = method68(v0)
    let v67 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v66 "$0()" )
    v67 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v68 : (unit -> unit) = method68(v0)
    let v69 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v68 "$0()" )
    v69 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v70 : (unit -> unit) = method68(v0)
    let v71 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v70 "$0()" )
    v71 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v72 : (unit -> unit) = method69(v0)
    let v73 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v72 () }
    v73 
    #endif
#if FABLE_COMPILER_PYTHON
    let v74 : (unit -> unit) = method69(v0)
    let v75 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v74 () }
    v75 
    #endif
#else
    let v76 : (unit -> unit) = method69(v0)
    let v77 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v76 () }
    v77 
    #endif
    |> fun x -> _v65 <- Some x
    let v78 : System.IDisposable = match _v65 with Some x -> x | None -> failwith "base.run_target / _v65=None"
    v78 
    #endif
#if FABLE_COMPILER_PYTHON
    let v79 : bool = true
    let mutable _v79 : System.IO.DirectoryInfo option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v80 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    v80 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v81 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    v81 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v82 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    v82 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v83 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    v83 
    #endif
#if FABLE_COMPILER_PYTHON
    let v84 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    v84 
    #endif
#else
    let v85 : (string -> System.IO.DirectoryInfo) = System.IO.Directory.CreateDirectory
    let v86 : System.IO.DirectoryInfo = v85 v0
    v86 
    #endif
    |> fun x -> _v79 <- Some x
    let v87 : System.IO.DirectoryInfo = match _v79 with Some x -> x | None -> failwith "base.run_target / _v79=None"
    let v88 : bool = true
    let mutable _v88 : bool option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v89 : bool = null |> unbox<bool>
    v89 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v90 : bool = null |> unbox<bool>
    v90 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v91 : bool = null |> unbox<bool>
    v91 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v92 : bool = null |> unbox<bool>
    v92 
    #endif
#if FABLE_COMPILER_PYTHON
    let v93 : bool = null |> unbox<bool>
    v93 
    #endif
#else
    let v94 : bool = v87.Exists
    v94 
    #endif
    |> fun x -> _v88 <- Some x
    let v95 : bool = match _v88 with Some x -> x | None -> failwith "base.run_target / _v88=None"
    let v96 : bool = v95 = false
    if v96 then
        let v97 : bool = true
        let mutable _v97 : System.DateTime option = None 
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v98 : System.DateTime = null |> unbox<System.DateTime>
        v98 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v99 : System.DateTime = null |> unbox<System.DateTime>
        v99 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v100 : System.DateTime = null |> unbox<System.DateTime>
        v100 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v101 : System.DateTime = null |> unbox<System.DateTime>
        v101 
        #endif
#if FABLE_COMPILER_PYTHON
        let v102 : System.DateTime = null |> unbox<System.DateTime>
        v102 
        #endif
#else
        let v103 : System.DateTime = v87.CreationTime
        v103 
        #endif
        |> fun x -> _v97 <- Some x
        let v104 : System.DateTime = match _v97 with Some x -> x | None -> failwith "base.run_target / _v97=None"
        let v105 : obj = {| Exists = v95; CreationTime = v104 |}
        let v106 : string = $"%A{v105}"
        let v107 : US0 = US0_1
        let v108 : (unit -> string) = closure52()
        let v109 : (unit -> struct (string * string)) = closure53(v0, v106)
        method66(v107, v108, v109)
    let v110 : bool = true
    let mutable _v110 : System.IDisposable option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v111 : (unit -> unit) = method68(v0)
    let v112 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v111 "$0()" )
    v112 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v113 : (unit -> unit) = method68(v0)
    let v114 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v113 "$0()" )
    v114 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v115 : (unit -> unit) = method68(v0)
    let v116 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v115 "$0()" )
    v116 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v117 : (unit -> unit) = method69(v0)
    let v118 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v117 () }
    v118 
    #endif
#if FABLE_COMPILER_PYTHON
    let v119 : (unit -> unit) = method69(v0)
    let v120 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v119 () }
    v120 
    #endif
#else
    let v121 : (unit -> unit) = method69(v0)
    let v122 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v121 () }
    v122 
    #endif
    |> fun x -> _v110 <- Some x
    let v123 : System.IDisposable = match _v110 with Some x -> x | None -> failwith "base.run_target / _v110=None"
    v123 
    #endif
#else
    let v124 : bool = true
    let mutable _v124 : System.IO.DirectoryInfo option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v125 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    v125 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v126 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    v126 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v127 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    v127 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v128 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    v128 
    #endif
#if FABLE_COMPILER_PYTHON
    let v129 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    v129 
    #endif
#else
    let v130 : (string -> System.IO.DirectoryInfo) = System.IO.Directory.CreateDirectory
    let v131 : System.IO.DirectoryInfo = v130 v0
    v131 
    #endif
    |> fun x -> _v124 <- Some x
    let v132 : System.IO.DirectoryInfo = match _v124 with Some x -> x | None -> failwith "base.run_target / _v124=None"
    let v133 : bool = true
    let mutable _v133 : bool option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v134 : bool = null |> unbox<bool>
    v134 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v135 : bool = null |> unbox<bool>
    v135 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v136 : bool = null |> unbox<bool>
    v136 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v137 : bool = null |> unbox<bool>
    v137 
    #endif
#if FABLE_COMPILER_PYTHON
    let v138 : bool = null |> unbox<bool>
    v138 
    #endif
#else
    let v139 : bool = v132.Exists
    v139 
    #endif
    |> fun x -> _v133 <- Some x
    let v140 : bool = match _v133 with Some x -> x | None -> failwith "base.run_target / _v133=None"
    let v141 : bool = v140 = false
    if v141 then
        let v142 : bool = true
        let mutable _v142 : System.DateTime option = None 
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v143 : System.DateTime = null |> unbox<System.DateTime>
        v143 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v144 : System.DateTime = null |> unbox<System.DateTime>
        v144 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v145 : System.DateTime = null |> unbox<System.DateTime>
        v145 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v146 : System.DateTime = null |> unbox<System.DateTime>
        v146 
        #endif
#if FABLE_COMPILER_PYTHON
        let v147 : System.DateTime = null |> unbox<System.DateTime>
        v147 
        #endif
#else
        let v148 : System.DateTime = v132.CreationTime
        v148 
        #endif
        |> fun x -> _v142 <- Some x
        let v149 : System.DateTime = match _v142 with Some x -> x | None -> failwith "base.run_target / _v142=None"
        let v150 : obj = {| Exists = v140; CreationTime = v149 |}
        let v151 : string = $"%A{v150}"
        let v152 : US0 = US0_1
        let v153 : (unit -> string) = closure52()
        let v154 : (unit -> struct (string * string)) = closure53(v0, v151)
        method66(v152, v153, v154)
    let v155 : bool = true
    let mutable _v155 : System.IDisposable option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v156 : (unit -> unit) = method68(v0)
    let v157 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v156 "$0()" )
    v157 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v158 : (unit -> unit) = method68(v0)
    let v159 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v158 "$0()" )
    v159 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v160 : (unit -> unit) = method68(v0)
    let v161 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v160 "$0()" )
    v161 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v162 : (unit -> unit) = method69(v0)
    let v163 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v162 () }
    v163 
    #endif
#if FABLE_COMPILER_PYTHON
    let v164 : (unit -> unit) = method69(v0)
    let v165 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v164 () }
    v165 
    #endif
#else
    let v166 : (unit -> unit) = method69(v0)
    let v167 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v166 () }
    v167 
    #endif
    |> fun x -> _v155 <- Some x
    let v168 : System.IDisposable = match _v155 with Some x -> x | None -> failwith "base.run_target / _v155=None"
    v168 
    #endif
    |> fun x -> _v1 <- Some x
    let v169 : System.IDisposable = match _v1 with Some x -> x | None -> failwith "base.run_target / _v1=None"
    v169
and closure41 () () : struct (string * System.IDisposable) =
    let v0 : string = method41()
    let v1 : System.IDisposable = method56(v0)
    struct (v0, v1)
and method70 (v0 : string) : System.Guid =
    let v1 : bool = true
    let mutable _v1 : System.Guid option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = v0.PadLeft (32, '0')
    let v3 : System.Guid = System.Guid $"{v2.[0..7]}-{v2.[8..11]}-{v2.[12..15]}-{v2.[16..19]}-{v2.[20..31]}"
    v3 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v4 : string = v0.PadLeft (32, '0')
    let v5 : System.Guid = System.Guid $"{v4.[0..7]}-{v4.[8..11]}-{v4.[12..15]}-{v4.[16..19]}-{v4.[20..31]}"
    v5 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v6 : System.Guid = null |> unbox<System.Guid>
    v6 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v7 : string = v0.PadLeft (32, '0')
    let v8 : System.Guid = System.Guid $"{v7.[0..7]}-{v7.[8..11]}-{v7.[12..15]}-{v7.[16..19]}-{v7.[20..31]}"
    v8 
    #endif
#if FABLE_COMPILER_PYTHON
    let v9 : string = v0.PadLeft (32, '0')
    let v10 : System.Guid = System.Guid $"{v9.[0..7]}-{v9.[8..11]}-{v9.[12..15]}-{v9.[16..19]}-{v9.[20..31]}"
    v10 
    #endif
#else
    let v11 : string = v0.PadLeft (32, '0')
    let v12 : System.Guid = System.Guid $"{v11.[0..7]}-{v11.[8..11]}-{v11.[12..15]}-{v11.[16..19]}-{v11.[20..31]}"
    v12 
    #endif
    |> fun x -> _v1 <- Some x
    let v13 : System.Guid = match _v1 with Some x -> x | None -> failwith "base.run_target / _v1=None"
    v13
and closure56 () (v0 : string) : struct (string * System.IDisposable) =
    let v1 : System.Guid = method70(v0)
    let v2 : string = method48(v1)
    let v3 : System.IDisposable = method56(v2)
    struct (v2, v3)
and closure57 () () : string =
    let v0 : string = __SOURCE_DIRECTORY__
    v0
and method72 () : string =
    let v0 : string = ""
    v0
and method73 (v0 : string) : string =
    v0
and method74 () : string =
    let v0 : string = "^\\\\\\\\\\?\\\\"
    v0
and method71 (v0 : string) : string =
    let v2 : bool = v0 = ""
    if v2 then
        let v3 : string = ""
        v3
    else
        let v4 : string = method72()
        let v5 : bool = true
        let mutable _v5 : string option = None 
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v6 : string = method73(v0)
        let v7 : string = $"regex::Regex::new(&$0)"
        let v8 : string = "^\\\\\\\\\\?\\\\"
        let v9 : Result<regex_Regex, regex_Error> = Fable.Core.RustInterop.emitRustExpr v8 v7 
        let v10 : string = "$0.unwrap()"
        let v11 : regex_Regex = Fable.Core.RustInterop.emitRustExpr v9 v10 
        let v12 : string = $"$0.replace_all(&$1, &*$2)"
        let v13 : std_borrow_Cow<Str> = Fable.Core.RustInterop.emitRustExpr struct (v11, v6, v4) v12 
        let v14 : string = "String::from($0)"
        let v15 : std_string_String = Fable.Core.RustInterop.emitRustExpr v13 v14 
        let v16 : string = "fable_library_rust::String_::fromString($0)"
        let v17 : string = Fable.Core.RustInterop.emitRustExpr v15 v16 
        v17 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v18 : string = null |> unbox<string>
        v18 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v19 : string = null |> unbox<string>
        v19 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v20 : string = null |> unbox<string>
        v20 
        #endif
#if FABLE_COMPILER_PYTHON
        let v21 : string = null |> unbox<string>
        v21 
        #endif
#else
        let v22 : string = method74()
        let v23 : string = System.Text.RegularExpressions.Regex.Replace (v0, v22, v4)
        v23 
        #endif
        |> fun x -> _v5 <- Some x
        let v24 : string = match _v5 with Some x -> x | None -> failwith "base.run_target / _v5=None"
        let v25 : string = $"{v24.[0] |> string |> _.ToLower()}{v24.[1..]}"
        let v26 : string = "\\"
        let v27 : string = "/"
        let v28 : string = v25.Replace (v26, v27)
        v28
and closure58 () (v0 : string) : string =
    method71(v0)
and closure59 () (v0 : string) : string =
    let v1 : char list = []
    let v2 : char list = '/' :: v1 
    let v3 : (char list -> (char [])) = List.toArray
    let v4 : (char []) = v3 v2
    let v5 : string = v0.TrimStart v4 
    let v6 : string = $"file:///{v5}"
    v6
and method77 (v0 : string) : string option =
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
and closure61 () (v0 : string) : string option =
    method77(v0)
and method76 () : (string -> string option) =
    closure61()
and method78 (v0 : string, v1 : string, v2 : string) : US13 =
    let v3 : string = method51(v2, v0)
    let v4 : bool = method7(v3)
    if v4 then
        US13_0(v2)
    else
        let v6 : (string -> string option) = method76()
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
            US13_1(v16)
        | US3_0(v14) -> (* Some *)
            method78(v0, v1, v14)
and method75 (v0 : string, v1 : string) : US13 =
    let v2 : string = method51(v1, v0)
    let v3 : bool = method7(v2)
    if v3 then
        US13_0(v1)
    else
        let v5 : (string -> string option) = method76()
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
            US13_1(v15)
        | US3_0(v13) -> (* Some *)
            method78(v0, v1, v13)
and closure62 () () : string =
    let v0 : string = "file_system.get_workspace_root"
    v0
and closure63 (v0 : string) () : string =
    v0
and method80 (v0 : Mut4, v1 : string) : unit =
    let v2 : string = "{ "
    method15(v0, v2)
    method16(v0)
    let v3 : string = "error"
    method15(v0, v3)
    let v4 : string = " = "
    method15(v0, v4)
    method15(v0, v1)
    let v5 : string = " }"
    method15(v0, v5)
and closure64 (v0 : US0, v1 : (unit -> string), v2 : (unit -> string)) () : string =
    let v3 : (US0 -> struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option)) = closure0()
    let v4 : US0 = US0_0
    if State.trace_state.IsNone then State.trace_state <- v3 v4 |> Some
    let struct (v5 : Mut0, v6 : Mut1, v7 : Mut2, v8 : Mut3, v9 : int64 option) = State.trace_state.Value
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
    let v36 : string = method10()
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
    let v64 : string = method10()
    let v65 : (string -> string) = v63.ToString
    let v66 : string = v65 v64
    v66 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v67 : string = method11()
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
    let v93 : string = method12()
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
    let v121 : string = method12()
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
    let v149 : string = method12()
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
    let v299 : string = method13()
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
    let v312 : string = method13()
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
    let v325 : string = method13()
    let v326 : string = v324 + v215 
    let v327 : string = v326 + v325 
    v327 
    #endif
    |> fun x -> _v216 <- Some x
    let v328 : string = match _v216 with Some x -> x | None -> failwith "base.run_target / _v216=None"
    let v329 : int64 = v5.l0
    let v330 : string = v2 ()
    let v331 : string = ""
    let v332 : Mut4 = {l0 = v331} : Mut4
    method80(v332, v330)
    let v333 : string = v332.l0
    let v334 : string = $"{v152} {v328} #{v329} %s{v1 ()} / {v333}"
    let v335 : char list = []
    let v336 : (char list -> (char [])) = List.toArray
    let v337 : (char []) = v336 v335
    let v338 : string = v334.TrimStart v337 
    let v339 : char list = []
    let v340 : char list = '/' :: v339 
    let v341 : char list = ' ' :: v340 
    let v342 : (char list -> (char [])) = List.toArray
    let v343 : (char []) = v342 v341
    let v344 : string = v338.TrimEnd v343 
    v344
and method79 (v0 : US0, v1 : (unit -> string), v2 : (unit -> string)) : unit =
    let v3 : (unit -> string) = closure64(v0, v1, v2)
    method17(v0, v3)
and method81 () : string =
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
    let v22 : string = null |> unbox<string>
    v22 
    #endif
#if FABLE_COMPILER_PYTHON
    let v23 : string = null |> unbox<string>
    v23 
    #endif
#else
    let v24 : (unit -> string) = System.IO.Directory.GetCurrentDirectory
    let v25 : string = v24 ()
    v25 
    #endif
    |> fun x -> _v0 <- Some x
    let v26 : string = match _v0 with Some x -> x | None -> failwith "base.run_target / _v0=None"
    v26
and closure60 () () : string =
    let v0 : string = __SOURCE_DIRECTORY__
    let v1 : string = "polyglot"
    let v2 : string = ".devcontainer"
    let v3 : string = method51(v1, v2)
    let v4 : US13 = method75(v3, v0)
    let v13 : US3 =
        match v4 with
        | US13_1(v7) -> (* Error *)
            let v8 : US0 = US0_3
            let v9 : (unit -> string) = closure62()
            let v10 : (unit -> string) = closure63(v7)
            method79(v8, v9, v10)
            US3_1
        | US13_0(v5) -> (* Ok *)
            US3_0(v5)
    let v29 : US3 =
        match v13 with
        | US3_1 -> (* None *)
            let v16 : string = method81()
            let v17 : string = method51(v1, v2)
            let v18 : US13 = method75(v17, v16)
            match v18 with
            | US13_1(v21) -> (* Error *)
                let v22 : US0 = US0_3
                let v23 : (unit -> string) = closure62()
                let v24 : (unit -> string) = closure63(v21)
                method79(v22, v23, v24)
                US3_1
            | US13_0(v19) -> (* Ok *)
                US3_0(v19)
        | US3_0(v14) -> (* Some *)
            US3_0(v14)
    let v33 : string =
        match v29 with
        | US3_1 -> (* None *)
            failwith<string> "Option does not have a value."
        | US3_0(v30) -> (* Some *)
            v30
    method51(v33, v1)
and method82 (v0 : string) : unit =
    let v1 : bool = true
    let mutable _v1 : unit option = None 
    
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
    let v2 : string = method54()
    let v3 : System.DateTime = System.DateTime.Now
    let v4 : (unit -> System.Guid) = System.Guid.NewGuid
    let v5 : System.Guid = v4 ()
    let v6 : System.Guid = method42(v5, v3)
    let v7 : string = $"{v2}_{v6}.txt"
    let v8 : string = __SOURCE_DIRECTORY__
    let v9 : string = "polyglot"
    let v10 : string = ".devcontainer"
    let v11 : string = method51(v9, v10)
    let v12 : US13 = method75(v11, v8)
    let v21 : US3 =
        match v12 with
        | US13_1(v15) -> (* Error *)
            let v16 : US0 = US0_3
            let v17 : (unit -> string) = closure62()
            let v18 : (unit -> string) = closure63(v15)
            method79(v16, v17, v18)
            US3_1
        | US13_0(v13) -> (* Ok *)
            US3_0(v13)
    let v37 : US3 =
        match v21 with
        | US3_1 -> (* None *)
            let v24 : string = method81()
            let v25 : string = method51(v9, v10)
            let v26 : US13 = method75(v25, v24)
            match v26 with
            | US13_1(v29) -> (* Error *)
                let v30 : US0 = US0_3
                let v31 : (unit -> string) = closure62()
                let v32 : (unit -> string) = closure63(v29)
                method79(v30, v31, v32)
                US3_1
            | US13_0(v27) -> (* Ok *)
                US3_0(v27)
        | US3_0(v22) -> (* Some *)
            US3_0(v22)
    let v41 : string =
        match v37 with
        | US3_1 -> (* None *)
            failwith<string> "Option does not have a value."
        | US3_0(v38) -> (* Some *)
            v38
    let v42 : string = method51(v41, v9)
    let v43 : string = "target/trace"
    let v44 : string = method51(v42, v43)
    let v45 : bool = true
    let mutable _v45 : System.IO.DirectoryInfo option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v46 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    v46 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v47 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    v47 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v48 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    v48 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v49 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    v49 
    #endif
#if FABLE_COMPILER_PYTHON
    let v50 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    v50 
    #endif
#else
    let v51 : (string -> System.IO.DirectoryInfo) = System.IO.Directory.CreateDirectory
    let v52 : System.IO.DirectoryInfo = v51 v44
    v52 
    #endif
    |> fun x -> _v45 <- Some x
    let v53 : System.IO.DirectoryInfo = match _v45 with Some x -> x | None -> failwith "base.run_target / _v45=None"
    let v54 : string = method51(v44, v7)
    let v55 : bool = true
    let mutable _v55 : Async<unit> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
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
#if FABLE_COMPILER_TYPESCRIPT
    let v59 : Async<unit> = null |> unbox<Async<unit>>
    v59 
    #endif
#if FABLE_COMPILER_PYTHON
    let v60 : Async<unit> = null |> unbox<Async<unit>>
    v60 
    #endif
#else
    let v61 : System.Threading.Tasks.Task = System.IO.File.WriteAllTextAsync (v54, v0)
    let v62 : bool = true
    let mutable _v62 : Async<unit> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v63 : Async<unit> = null |> unbox<Async<unit>>
    v63 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v64 : Async<unit> = null |> unbox<Async<unit>>
    v64 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v65 : Async<unit> = null |> unbox<Async<unit>>
    v65 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v66 : Async<unit> = null |> unbox<Async<unit>>
    v66 
    #endif
#if FABLE_COMPILER_PYTHON
    let v67 : Async<unit> = null |> unbox<Async<unit>>
    v67 
    #endif
#else
    let v68 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
    let v69 : Async<unit> = v68 v61
    v69 
    #endif
    |> fun x -> _v62 <- Some x
    let v70 : Async<unit> = match _v62 with Some x -> x | None -> failwith "base.run_target / _v62=None"
    v70 
    #endif
    |> fun x -> _v55 <- Some x
    let v71 : Async<unit> = match _v55 with Some x -> x | None -> failwith "base.run_target / _v55=None"
    let v72 : bool = true
    let mutable _v72 : unit option = None 
    
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
    let v73 : (Async<unit> -> unit) = Async.RunSynchronously
    v73 v71
    () 
    #endif
    |> fun x -> _v72 <- Some x
    match _v72 with Some x -> x | None -> failwith "base.run_target / _v72=None"
    with ex ->
    let v74 : exn = ex
    let v75 : string = $"file_system.trace_file / ex: %A{v74}"
    method82(v75)
    (*
    *)
    () 
    #endif
    |> fun x -> _v1 <- Some x
    match _v1 with Some x -> x | None -> failwith "base.run_target / _v1=None"
    ()
and closure66 () (v0 : string) : unit =
    method82(v0)
and closure65 () (v0 : bool) : unit =
    let v1 : (US0 -> struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option)) = closure0()
    let v2 : US0 = US0_0
    if State.trace_state.IsNone then State.trace_state <- v1 v2 |> Some
    let struct (v3 : Mut0, v4 : Mut1, v5 : Mut2, v6 : Mut3, v7 : int64 option) = State.trace_state.Value
    let v10 : (string -> unit) =
        if v0 then
            closure66()
        else
            closure1()
    v4.l0 <- v10
    ()
and closure68 (v0 : string) (v1 : string) : string =
    method51(v0, v1)
and closure67 () (v0 : string) : (string -> string) =
    closure68(v0)
let v0 : (US0 -> struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option)) = closure0()
let v1 : US0 = US0_0
if State.trace_state.IsNone then State.trace_state <- v0 v1 |> Some
let v2 : (string -> Async<int64>) = closure2()
let delete_directory_async x = v2 x
let v3 : (US6 -> (string -> Async<int64>)) = closure6()
let wait_for_file_access x = v3 x
let v4 : (string -> Async<int64>) = closure11()
let wait_for_file_access_read x = v4 x
let v5 : (string -> Async<string>) = closure12()
let read_all_text_async x = v5 x
let v6 : (string -> (string -> bool)) = closure13()
let file_exists_content x = v6 x
let v7 : (string -> (string -> Async<unit>)) = closure15()
let write_all_text_async x = v7 x
let v8 : (string -> (string -> Async<unit>)) = closure17()
let write_all_text_exists x = v8 x
let v9 : (string -> Async<int64>) = closure19()
let delete_file_async x = v9 x
let v10 : (string -> (string -> Async<int64>)) = closure23()
let move_file_async x = v10 x
let v11 : (string -> Async<string option>) = closure28()
let read_all_text_retry_async x = v11 x
let v12 : (unit -> string) = closure40()
let create_temp_path () = v12 ()
let v13 : (unit -> struct (string * System.IDisposable)) = closure41()
let create_temp_dir () = v13 ()
let v14 : (string -> struct (string * System.IDisposable)) = closure56()
let create_temp_dir' x = v14 x
let v15 : (unit -> string) = closure57()
let get_source_directory () = v15 ()
let v16 : (string -> string) = closure58()
let normalize_path x = v16 x
let v17 : (string -> string) = closure59()
let new_file_uri x = v17 x
let v18 : (unit -> string) = closure60()
let get_workspace_root () = v18 ()
let v19 : (bool -> unit) = closure65()
let init_trace_file x = v19 x
let v20 : (string -> (string -> string)) = closure67()
let (</>) x = v20 x
()
