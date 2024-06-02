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
    | US4_0
    | US4_1
    | US4_2
and [<Struct>] US5 =
    | US5_0 of f0_0 : US4
    | US5_1 of f1_0 : US4
    | US5_2 of f2_0 : US4
    | US5_3 of f3_0 : US4
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
and method3 () : string =
    let v0 : string = "AUTOMATION"
    v0
and closure1 () (v0 : string) : unit =
    ()
and closure0 () (v0 : US0) : struct (Mut0 * Mut1 * Mut2 * int64 option * Mut3) =
    let v1 : bool = true
    let mutable _v1 : struct (US1 * US2) option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = method0()
    let v3 : string = method1(v2)
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
    let v25 : string = method3()
    let v26 : string = method1(v25)
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
    let v39 : string = method0()
    let v40 : string = method1(v39)
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
    let v62 : string = method3()
    let v63 : string = method1(v62)
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
    let v72 : string = method0()
    let v73 : string = method1(v72)
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
    let v95 : string = method3()
    let v96 : string = method1(v95)
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
    let v105 : string = method0()
    let v106 : string = method1(v105)
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
    let v128 : string = method3()
    let v129 : string = method1(v128)
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
    let v146 : (string -> unit) = closure1()
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
    let v23 : US5 = US5_0(v22)
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
    let v28 : US5 = US5_2(v27)
    let v29 : string = $"file_system.get_file_name / target: {v28} / path: {v0}"
    let v30 : string = failwith<string> v29
    v30 
    #endif
#if FABLE_COMPILER_PYTHON
    let v31 : US4 = US4_0
    let v32 : US5 = US5_3(v31)
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
and closure5 () (v0 : string) : string =
    method8(v0)
and closure6 () () : string =
    let v0 : string = ""
    v0
and closure4 (v0 : string, v1 : string) () : string =
    let v2 : (string -> string) = closure5()
    let v3 : (unit -> string) = closure6()
    let v4 : string = $"path: {v0 |> v2} / ex: {v1} / {v3 ()}"
    v4
and method10 () : string =
    let v0 : string = "hh:mm:ss"
    v0
and method11 () : string =
    let v0 : string = ""
    v0
and method12 () : string =
    let v0 : string = "HH:mm:ss"
    v0
and closure7 (v0 : US0, v1 : (unit -> string), v2 : (unit -> string)) () : string =
    let v3 : (US0 -> struct (Mut0 * Mut1 * Mut2 * int64 option * Mut3)) = closure0()
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
    let v36 : string = method10()
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
    let v63 : string = method10()
    let v64 : string = v62.ToString v63 
    v64 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v65 : string = method11()
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
    let v91 : string = method12()
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
    let v118 : string = method12()
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
    let v145 : string = method12()
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
and method13 (v0 : US0, v1 : (unit -> string)) : unit =
    let v2 : (US0 -> struct (Mut0 * Mut1 * Mut2 * int64 option * Mut3)) = closure0()
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
and method9 (v0 : US0, v1 : (unit -> string), v2 : (unit -> string)) : unit =
    let v3 : (unit -> string) = closure7(v0, v1, v2)
    method13(v0, v3)
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
        let v23 : (unit -> string) = closure4(v0, v20)
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
and closure10 () () : string =
    let v0 : string = "file_system.wait_for_file_access"
    v0
and closure11 (v0 : string, v1 : int64, v2 : string) () : string =
    let v3 : (string -> string) = closure5()
    let v4 : (unit -> string) = closure6()
    let v5 : string = $"path: {v0 |> v3} / retry: {v1} / ex: {v2} / {v4 ()}"
    v5
and method14 (v0 : string, v1 : US8, v2 : US7, v3 : int64) : Async<int64> =
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
        let v51 : (unit -> string) = closure10()
        let v52 : (unit -> string) = closure11(v0, v3, v49)
        method9(v50, v51, v52)
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
    let v63 : Async<int64> = method14(v0, v1, v2, v62)
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
and closure9 (v0 : US6) (v1 : string) : Async<int64> =
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
    let v17 : Async<int64> = method14(v1, v15, v14, v16)
    v17 
    #endif
    |> fun x -> _v2 <- Some x
    let v18 : Async<int64> = match _v2 with Some x -> x | None -> failwith "base.run_target / _v2=None"
    v18
and closure8 () (v0 : US6) : (string -> Async<int64>) =
    closure9(v0)
and method15 (v0 : string, v1 : int64) : Async<int64> =
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
        let v35 : (unit -> string) = closure10()
        let v36 : (unit -> string) = closure11(v0, v1, v33)
        method9(v34, v35, v36)
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
    let v47 : Async<int64> = method15(v0, v46)
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
and closure12 () (v0 : string) : Async<int64> =
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
    let v8 : Async<int64> = method15(v0, v7)
    v8 
    #endif
    |> fun x -> _v1 <- Some x
    let v9 : Async<int64> = match _v1 with Some x -> x | None -> failwith "base.run_target / _v1=None"
    v9
and closure13 () (v0 : string) : Async<string> =
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
and method16 (v0 : string) : bool =
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
and closure15 (v0 : string) (v1 : string) : Async<bool> =
    let v2 : bool = true
    let mutable _v2 : Async<bool> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : Async<bool> = null |> unbox<Async<bool>>
    v3 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v4 : Async<bool> = null |> unbox<Async<bool>>
    v4 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v5 : Async<bool> = null |> unbox<Async<bool>>
    v5 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v6 : Async<bool> = null |> unbox<Async<bool>>
    v6 
    #endif
#if FABLE_COMPILER_PYTHON
    let v7 : Async<bool> = null |> unbox<Async<bool>>
    v7 
    #endif
#else
    let v8 : bool = true
    let mutable _v8 : Async<bool> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
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
#if FABLE_COMPILER_TYPESCRIPT
    let v12 : Async<bool> = null |> unbox<Async<bool>>
    v12 
    #endif
#if FABLE_COMPILER_PYTHON
    let v13 : Async<bool> = null |> unbox<Async<bool>>
    v13 
    #endif
#else
    let v14 : Async<bool> option = None
    let mutable _v14 = v14 
    async {
    let v15 : bool = method16(v0)
    let v16 : bool = v15 = false
    if v16 then
        return false 
        (*
        ()
    else
        *) else
        let v17 : bool = true
        let mutable _v17 : Async<string> option = None 
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v18 : Async<string> = null |> unbox<Async<string>>
        v18 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v19 : Async<string> = null |> unbox<Async<string>>
        v19 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v20 : Async<string> = null |> unbox<Async<string>>
        v20 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v21 : Async<string> = null |> unbox<Async<string>>
        v21 
        #endif
#if FABLE_COMPILER_PYTHON
        let v22 : Async<string> = null |> unbox<Async<string>>
        v22 
        #endif
#else
        let v23 : (string -> System.Threading.Tasks.Task<string>) = System.IO.File.ReadAllTextAsync
        let v24 : System.Threading.Tasks.Task<string> = v23 v0
        let v25 : bool = true
        let mutable _v25 : Async<string> option = None 
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v26 : Async<string> = null |> unbox<Async<string>>
        v26 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v27 : Async<string> = null |> unbox<Async<string>>
        v27 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v28 : Async<string> = null |> unbox<Async<string>>
        v28 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v29 : Async<string> = null |> unbox<Async<string>>
        v29 
        #endif
#if FABLE_COMPILER_PYTHON
        let v30 : Async<string> = null |> unbox<Async<string>>
        v30 
        #endif
#else
        let v31 : (System.Threading.Tasks.Task<string> -> Async<string>) = Async.AwaitTask
        let v32 : Async<string> = v31 v24
        v32 
        #endif
        |> fun x -> _v25 <- Some x
        let v33 : Async<string> = match _v25 with Some x -> x | None -> failwith "base.run_target / _v25=None"
        v33 
        #endif
        |> fun x -> _v17 <- Some x
        let v34 : Async<string> = match _v17 with Some x -> x | None -> failwith "base.run_target / _v17=None"
        let! v34 = v34 
        let v35 : string = v34 
        let v36 : bool = v1 = v35
        return v36 
        (*
        ()
    *)
    }
    |> fun x -> _v14 <- Some x
    let v37 : Async<bool> = match _v14 with Some x -> x | None -> failwith "async.new_async_unit / _v14=None"
    v37 
    #endif
    |> fun x -> _v8 <- Some x
    let v38 : Async<bool> = match _v8 with Some x -> x | None -> failwith "base.run_target / _v8=None"
    v38 
    #endif
    |> fun x -> _v2 <- Some x
    let v39 : Async<bool> = match _v2 with Some x -> x | None -> failwith "base.run_target / _v2=None"
    v39
and closure14 () (v0 : string) : (string -> Async<bool>) =
    closure15(v0)
and closure17 (v0 : string) (v1 : string) : Async<unit> =
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
and closure16 () (v0 : string) : (string -> Async<unit>) =
    closure17(v0)
and closure19 (v0 : string) (v1 : string) : Async<unit> =
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
    let v22 : bool = method16(v0)
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
and closure18 () (v0 : string) : (string -> Async<unit>) =
    closure19(v0)
and closure21 () () : string =
    let v0 : string = "delete_file_async"
    v0
and closure22 (v0 : string, v1 : exn) () : string =
    let v2 : bool = true
    let mutable _v2 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : string = $"%A{v1}"
    v3 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v4 : string = $"%A{v1}"
    v4 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v5 : string = $"%A{v1}"
    v5 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v6 : string = $"%A{v1}"
    v6 
    #endif
#if FABLE_COMPILER_PYTHON
    let v7 : string = $"%A{v1}"
    v7 
    #endif
#else
    let v8 : string = $"{v1.GetType ()}: {v1.Message}"
    v8 
    #endif
    |> fun x -> _v2 <- Some x
    let v9 : string = match _v2 with Some x -> x | None -> failwith "base.run_target / _v2=None"
    let v10 : (string -> string) = closure5()
    let v11 : (unit -> string) = closure6()
    let v12 : string = $"path: {v0 |> v10} / ex: {v9} / {v11 ()}"
    v12
and method17 (v0 : string, v1 : int64) : Async<int64> =
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
        let v16 : (unit -> string) = closure21()
        let v17 : (unit -> string) = closure22(v0, v12)
        method9(v15, v16, v17)
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
    let v28 : Async<int64> = method17(v0, v27)
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
and closure20 () (v0 : string) : Async<int64> =
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
    let v8 : Async<int64> = method17(v0, v7)
    v8 
    #endif
    |> fun x -> _v1 <- Some x
    let v9 : Async<int64> = match _v1 with Some x -> x | None -> failwith "base.run_target / _v1=None"
    v9
and closure25 () () : string =
    let v0 : string = "move_file_async"
    v0
and closure26 (v0 : string, v1 : string, v2 : exn) () : string =
    let v3 : bool = true
    let mutable _v3 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v4 : string = $"%A{v2}"
    v4 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v5 : string = $"%A{v2}"
    v5 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v6 : string = $"%A{v2}"
    v6 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v7 : string = $"%A{v2}"
    v7 
    #endif
#if FABLE_COMPILER_PYTHON
    let v8 : string = $"%A{v2}"
    v8 
    #endif
#else
    let v9 : string = $"{v2.GetType ()}: {v2.Message}"
    v9 
    #endif
    |> fun x -> _v3 <- Some x
    let v10 : string = match _v3 with Some x -> x | None -> failwith "base.run_target / _v3=None"
    let v11 : (string -> string) = closure5()
    let v12 : (unit -> string) = closure6()
    let v13 : string = $"old_path: {v1 |> v11} / new_path: {v0 |> v11} / ex: {v10} / {v12 ()}"
    v13
and method18 (v0 : string, v1 : string, v2 : int64) : Async<int64> =
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
        let v16 : (unit -> string) = closure26(v0, v1, v11)
        method9(v14, v15, v16)
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
    let v27 : Async<int64> = method18(v0, v1, v26)
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
    let v9 : Async<int64> = method18(v0, v1, v8)
    v9 
    #endif
    |> fun x -> _v2 <- Some x
    let v10 : Async<int64> = match _v2 with Some x -> x | None -> failwith "base.run_target / _v2=None"
    v10
and closure23 () (v0 : string) : (string -> Async<int64>) =
    closure24(v0)
and closure28 () (v0 : int64) : US9 =
    US9_0(v0)
and closure29 () (v0 : exn) : US9 =
    US9_1(v0)
and closure30 () () : string =
    let v0 : string = "async.run_with_timeout_async"
    v0
and closure31 () () : string =
    let v0 : (unit -> string) = closure6()
    let v1 : string = $"timeout: {1000} / {v0 ()}"
    v1
and closure32 (v0 : string) () : string =
    let v1 : string = $"async.run_with_timeout_async** / ex: {v0}"
    v1
and closure33 () () : string =
    let v0 : string = "read_all_text_retry_async"
    v0
and method20 (v0 : int64, v1 : string) : string =
    let v2 : (unit -> string) = closure6()
    let v3 : string = $"retry: {v0} / ex: {v1} / {v2 ()}"
    v3
and closure34 (v0 : int64, v1 : string) () : string =
    method20(v0, v1)
and method19 (v0 : string, v1 : int64) : Async<string option> =
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
        let v17 : Async<int64> = method15(v0, v16)
        v17 
        #endif
        |> fun x -> _v10 <- Some x
        let v18 : Async<int64> = match _v10 with Some x -> x | None -> failwith "base.run_target / _v10=None"
        let v19 : bool = true
        let mutable _v19 : Async<US1> option = None 
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v20 : Async<US1> = null |> unbox<Async<US1>>
        v20 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v21 : Async<US1> = null |> unbox<Async<US1>>
        v21 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v22 : Async<US1> = null |> unbox<Async<US1>>
        v22 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v23 : Async<US1> = null |> unbox<Async<US1>>
        v23 
        #endif
#if FABLE_COMPILER_PYTHON
        let v24 : Async<US1> = null |> unbox<Async<US1>>
        v24 
        #endif
#else
        let v25 : bool = true
        let mutable _v25 : Async<US1> option = None 
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v26 : Async<US1> = null |> unbox<Async<US1>>
        v26 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v27 : Async<US1> = null |> unbox<Async<US1>>
        v27 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v28 : Async<US1> = null |> unbox<Async<US1>>
        v28 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v29 : Async<US1> = null |> unbox<Async<US1>>
        v29 
        #endif
#if FABLE_COMPILER_PYTHON
        let v30 : Async<US1> = null |> unbox<Async<US1>>
        v30 
        #endif
#else
        let v31 : Async<US1> option = None
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
        let v64 : (int64 -> US9) = closure28()
        let v65 : (exn -> US9) = closure29()
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
            | US9_0(v78) -> (* Choice1Of2 *)
                US10_0(v78)
            | US9_1(v80) -> (* Choice2Of2 *)
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
        let mutable _v86 : Async<US1> option = None 
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v87 : Async<US1> = null |> unbox<Async<US1>>
        v87 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v88 : Async<US1> = null |> unbox<Async<US1>>
        v88 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v89 : Async<US1> = null |> unbox<Async<US1>>
        v89 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v90 : Async<US1> = null |> unbox<Async<US1>>
        v90 
        #endif
#if FABLE_COMPILER_PYTHON
        let v91 : Async<US1> = null |> unbox<Async<US1>>
        v91 
        #endif
#else
        let v92 : Async<US1> option = None
        let mutable _v92 = v92 
        async {
        let! v85 = v85 
        let v93 : US10 = v85 
        let v118 : US1 =
            match v93 with
            | US10_1(v96) -> (* Error *)
                let v97 : string = $"%A{v96}"
                let v98 : string = "System.TimeoutException"
                let v99 : bool = v97.Contains v98 
                if v99 then
                    let v100 : US0 = US0_1
                    let v101 : (unit -> string) = closure30()
                    let v102 : (unit -> string) = closure31()
                    method9(v100, v101, v102)
                    US1_1
                else
                    let v104 : bool = true
                    let mutable _v104 : string option = None 
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v105 : string = $"%A{v96}"
                    v105 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v106 : string = $"%A{v96}"
                    v106 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v107 : string = $"%A{v96}"
                    v107 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v108 : string = $"%A{v96}"
                    v108 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v109 : string = $"%A{v96}"
                    v109 
                    #endif
#else
                    let v110 : string = $"{v96.GetType ()}: {v96.Message}"
                    v110 
                    #endif
                    |> fun x -> _v104 <- Some x
                    let v111 : string = match _v104 with Some x -> x | None -> failwith "base.run_target / _v104=None"
                    let v112 : US0 = US0_4
                    let v113 : (unit -> string) = closure32(v111)
                    let v114 : (unit -> string) = closure31()
                    method9(v112, v113, v114)
                    US1_1
            | US10_0(v94) -> (* Ok *)
                US1_0(v94)
        return v118 
        }
        |> fun x -> _v92 <- Some x
        let v119 : Async<US1> = match _v92 with Some x -> x | None -> failwith "async.new_async_unit / _v92=None"
        v119 
        #endif
        |> fun x -> _v86 <- Some x
        let v120 : Async<US1> = match _v86 with Some x -> x | None -> failwith "base.run_target / _v86=None"
        return! v120 
        }
        |> fun x -> _v31 <- Some x
        let v121 : Async<US1> = match _v31 with Some x -> x | None -> failwith "async.new_async_unit / _v31=None"
        v121 
        #endif
        |> fun x -> _v25 <- Some x
        let v122 : Async<US1> = match _v25 with Some x -> x | None -> failwith "base.run_target / _v25=None"
        v122 
        #endif
        |> fun x -> _v19 <- Some x
        let v123 : Async<US1> = match _v19 with Some x -> x | None -> failwith "base.run_target / _v19=None"
        let v124 : bool = true
        let mutable _v124 : Async<unit> option = None 
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v125 : Async<unit> = null |> unbox<Async<unit>>
        v125 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v126 : Async<unit> = null |> unbox<Async<unit>>
        v126 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v127 : Async<unit> = null |> unbox<Async<unit>>
        v127 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v128 : Async<unit> = null |> unbox<Async<unit>>
        v128 
        #endif
#if FABLE_COMPILER_PYTHON
        let v129 : Async<unit> = null |> unbox<Async<unit>>
        v129 
        #endif
#else
        let v130 : (Async<US1> -> Async<unit>) = Async.Ignore
        let v131 : Async<unit> = v130 v123
        v131 
        #endif
        |> fun x -> _v124 <- Some x
        let v132 : Async<unit> = match _v124 with Some x -> x | None -> failwith "base.run_target / _v124=None"
        do! v132 
        ()
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
    let v139 : (string -> System.Threading.Tasks.Task<string>) = System.IO.File.ReadAllTextAsync
    let v140 : System.Threading.Tasks.Task<string> = v139 v0
    let v141 : bool = true
    let mutable _v141 : Async<string> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v142 : Async<string> = null |> unbox<Async<string>>
    v142 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v143 : Async<string> = null |> unbox<Async<string>>
    v143 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v144 : Async<string> = null |> unbox<Async<string>>
    v144 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v145 : Async<string> = null |> unbox<Async<string>>
    v145 
    #endif
#if FABLE_COMPILER_PYTHON
    let v146 : Async<string> = null |> unbox<Async<string>>
    v146 
    #endif
#else
    let v147 : (System.Threading.Tasks.Task<string> -> Async<string>) = Async.AwaitTask
    let v148 : Async<string> = v147 v140
    v148 
    #endif
    |> fun x -> _v141 <- Some x
    let v149 : Async<string> = match _v141 with Some x -> x | None -> failwith "base.run_target / _v141=None"
    v149 
    #endif
    |> fun x -> _v133 <- Some x
    let v150 : Async<string> = match _v133 with Some x -> x | None -> failwith "base.run_target / _v133=None"
    let v151 : bool = true
    let mutable _v151 : Async<string option> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v152 : Async<string option> = null |> unbox<Async<string option>>
    v152 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v153 : Async<string option> = null |> unbox<Async<string option>>
    v153 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v154 : Async<string option> = null |> unbox<Async<string option>>
    v154 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v155 : Async<string option> = null |> unbox<Async<string option>>
    v155 
    #endif
#if FABLE_COMPILER_PYTHON
    let v156 : Async<string option> = null |> unbox<Async<string option>>
    v156 
    #endif
#else
    let v157 : Async<string option> option = None
    let mutable _v157 = v157 
    async {
    let! v150 = v150 
    let v158 : string = v150 
    let v159 : string option = Some v158 
    return v159 
    }
    |> fun x -> _v157 <- Some x
    let v160 : Async<string option> = match _v157 with Some x -> x | None -> failwith "async.new_async_unit / _v157=None"
    v160 
    #endif
    |> fun x -> _v151 <- Some x
    let v161 : Async<string option> = match _v151 with Some x -> x | None -> failwith "base.run_target / _v151=None"
    return! v161 
    with ex ->
    let v162 : exn = ex
    let v163 : bool = v1 = 0L
    let v164 : bool = v163 <> true
    if v164 then
        let v165 : bool = true
        let mutable _v165 : string option = None 
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v166 : string = $"%A{v162}"
        v166 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v167 : string = $"%A{v162}"
        v167 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v168 : string = $"%A{v162}"
        v168 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v169 : string = $"%A{v162}"
        v169 
        #endif
#if FABLE_COMPILER_PYTHON
        let v170 : string = $"%A{v162}"
        v170 
        #endif
#else
        let v171 : string = $"{v162.GetType ()}: {v162.Message}"
        v171 
        #endif
        |> fun x -> _v165 <- Some x
        let v172 : string = match _v165 with Some x -> x | None -> failwith "base.run_target / _v165=None"
        let v173 : US0 = US0_1
        let v174 : (unit -> string) = closure33()
        let v175 : (unit -> string) = closure34(v1, v172)
        method9(v173, v174, v175)
        let v176 : string option = None
        return v176 
        (*
        ()
    else
        *) else
        let v177 : int64 = v1 + 1L
        let v178 : Async<string option> = method19(v0, v177)
        return! v178 
        (*
        ()
    *)
    (*
    let v179 : string option = *)
    }
    |> fun x -> _v8 <- Some x
    let v180 : Async<string option> = match _v8 with Some x -> x | None -> failwith "async.new_async_unit / _v8=None"
    v180 
    #endif
    |> fun x -> _v2 <- Some x
    let v181 : Async<string option> = match _v2 with Some x -> x | None -> failwith "base.run_target / _v2=None"
    v181
and closure27 () (v0 : string) : Async<string option> =
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
    let v8 : Async<string option> = method19(v0, v7)
    v8 
    #endif
    |> fun x -> _v1 <- Some x
    let v9 : Async<string option> = match _v1 with Some x -> x | None -> failwith "base.run_target / _v1=None"
    v9
and method22 (v0 : chrono_DateTime<chrono_Utc>) : chrono_DateTime<chrono_Utc> =
    v0
and method23 (v0 : chrono_DateTime<chrono_Local>) : chrono_DateTime<chrono_Local> =
    v0
and method24 () : string =
    let v0 : string = "hh:mm"
    v0
and method25 () : string =
    let v0 : string = "yyyyMMdd-HHmm-ssff-ffff-f"
    v0
and method26 () : string =
    let v0 : string = "hhmm"
    v0
and method21 (v0 : System.Guid, v1 : System.DateTime) : System.Guid =
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
            let v25 : chrono_DateTime<chrono_Utc> = method22(v24)
            let v26 : string = "v25.naive_utc()"
            let v27 : chrono_NaiveDateTime = Fable.Core.RustInterop.emitRustExpr () v26 
            let v28 : string = "chrono::offset::TimeZone::from_utc_datetime(&chrono::Local, &v27)"
            let v29 : chrono_DateTime<chrono_Local> = Fable.Core.RustInterop.emitRustExpr () v28 
            let v30 : string = "%Y%m%d-%H%M-%S%f"
            let v31 : string = "r#\"" + v30 + "\"#"
            let v32 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v31 
            let v33 : chrono_DateTime<chrono_Local> = method23(v29)
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
    let v64 : US5 = US5_2(v63)
    let v65 : string = $"date_time.get_utc_offset / target: {v64}"
    let v66 : System.TimeSpan = failwith<System.TimeSpan> v65
    v66 
    #endif
#if FABLE_COMPILER_PYTHON
    let v67 : US4 = US4_0
    let v68 : US5 = US5_3(v67)
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
    let v88 : string = method24()
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
            let v123 : chrono_DateTime<chrono_Utc> = method22(v122)
            let v124 : string = "v123.naive_utc()"
            let v125 : chrono_NaiveDateTime = Fable.Core.RustInterop.emitRustExpr () v124 
            let v126 : string = "chrono::offset::TimeZone::from_utc_datetime(&chrono::Local, &v125)"
            let v127 : chrono_DateTime<chrono_Local> = Fable.Core.RustInterop.emitRustExpr () v126 
            let v128 : string = "%Y%m%d-%H%M-%S%f"
            let v129 : string = "r#\"" + v128 + "\"#"
            let v130 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v129 
            let v131 : chrono_DateTime<chrono_Local> = method23(v127)
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
    let v162 : US5 = US5_2(v161)
    let v163 : string = $"date_time.get_utc_offset / target: {v162}"
    let v164 : System.TimeSpan = failwith<System.TimeSpan> v163
    v164 
    #endif
#if FABLE_COMPILER_PYTHON
    let v165 : US4 = US4_0
    let v166 : US5 = US5_3(v165)
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
    let v186 : string = method24()
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
    let v200 : string = method25()
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
    let v220 : US5 = US5_2(v219)
    let v221 : string = $"date_time.get_utc_offset / target: {v220}"
    let v222 : System.TimeSpan = failwith<System.TimeSpan> v221
    v222 
    #endif
#if FABLE_COMPILER_PYTHON
    let v223 : US4 = US4_0
    let v224 : US5 = US5_3(v223)
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
    let v245 : string = method26()
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
    let v258 : string = method25()
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
    let v277 : US4 = US4_0
    let v278 : US5 = US5_2(v277)
    let v279 : string = $"date_time.get_utc_offset / target: {v278}"
    let v280 : System.TimeSpan = failwith<System.TimeSpan> v279
    v280 
    #endif
#if FABLE_COMPILER_PYTHON
    let v281 : US4 = US4_0
    let v282 : US5 = US5_3(v281)
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
    let v303 : string = method26()
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
    let v316 : string = method25()
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
    let v335 : US4 = US4_0
    let v336 : US5 = US5_2(v335)
    let v337 : string = $"date_time.get_utc_offset / target: {v336}"
    let v338 : System.TimeSpan = failwith<System.TimeSpan> v337
    v338 
    #endif
#if FABLE_COMPILER_PYTHON
    let v339 : US4 = US4_0
    let v340 : US5 = US5_3(v339)
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
    let v361 : string = method26()
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
and method27 () : string =
    let v0 : string = "!create_temp_path_"
    v0
and method30 (v0 : string) : string =
    v0
and method29 (v0 : string, v1 : string) : struct (string * string) =
    let v2 : string = method30(v0)
    struct (v1, v2)
and method28 (v0 : string, v1 : string) : string =
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
    let v31 : US5 = US5_0(v30)
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
    let struct (v37 : string, v38 : string) = method29(v1, v0)
    let v39 : string = "v36.join($0, $1)"
    let v40 : string = Fable.Core.JsInterop.emitJsExpr struct (v37, v38) v39 
    v40 
    #endif
#if FABLE_COMPILER_PYTHON
    let v41 : US4 = US4_0
    let v42 : US5 = US5_3(v41)
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
and method32 () : string =
    let v0 : string = "CARGO_PKG_NAME"
    v0
and method31 () : string =
    let v0 : bool = true
    let mutable _v0 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1 : string = method32()
    let v2 : string = method1(v1)
    v2 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v3 : string = method32()
    let v4 : string = method1(v3)
    v4 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v5 : string = method32()
    let v6 : string = method1(v5)
    v6 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v7 : US4 = US4_0
    let v8 : US5 = US5_2(v7)
    let v9 : string = $"env.get_entry_assembly_name / target: {v8}"
    let v10 : string = failwith<string> v9
    v10 
    #endif
#if FABLE_COMPILER_PYTHON
    let v11 : US4 = US4_0
    let v12 : US5 = US5_3(v11)
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
and closure35 () () : string =
    let v0 : bool = true
    let mutable _v0 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1 : System.DateTime = System.DateTime.Now
    let v2 : (unit -> System.Guid) = System.Guid.NewGuid
    let v3 : System.Guid = v2 ()
    let v4 : System.Guid = method21(v3, v1)
    let v5 : bool = true
    let mutable _v5 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v6 : bool = true
    let mutable _v6 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v7 : string = "std::env::temp_dir()"
    let v8 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr () v7 
    let v9 : string = "$0.display()"
    let v10 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v8 v9 
    let v11 : bool = true
    let mutable _v11 : std_string_String option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v12 : string = "format!(\"{}\", $0)"
    let v13 : std_string_String = Fable.Core.RustInterop.emitRustExpr v10 v12 
    v13 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v14 : string = "format!(\"{}\", $0)"
    let v15 : std_string_String = Fable.Core.RustInterop.emitRustExpr v10 v14 
    v15 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v16 : string = "format!(\"{}\", $0)"
    let v17 : std_string_String = Fable.Core.RustInterop.emitRustExpr v10 v16 
    v17 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v18 : std_string_String = null |> unbox<std_string_String>
    v18 
    #endif
#if FABLE_COMPILER_PYTHON
    let v19 : std_string_String = null |> unbox<std_string_String>
    v19 
    #endif
#else
    let v20 : std_string_String = null |> unbox<std_string_String>
    v20 
    #endif
    |> fun x -> _v11 <- Some x
    let v21 : std_string_String = match _v11 with Some x -> x | None -> failwith "base.run_target / _v11=None"
    let v22 : string = "fable_library_rust::String_::fromString($0)"
    let v23 : string = Fable.Core.RustInterop.emitRustExpr v21 v22 
    v23 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v24 : US4 = US4_1
    let v25 : US5 = US5_0(v24)
    let v26 : string = $"file_system.get_temp_path / target: {v25}"
    let v27 : string = failwith<string> v26
    v27 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v28 : string = null |> unbox<string>
    v28 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v29 : US4 = US4_0
    let v30 : US5 = US5_2(v29)
    let v31 : string = $"file_system.get_temp_path / target: {v30}"
    let v32 : string = failwith<string> v31
    v32 
    #endif
#if FABLE_COMPILER_PYTHON
    let v33 : US4 = US4_0
    let v34 : US5 = US5_3(v33)
    let v35 : string = $"file_system.get_temp_path / target: {v34}"
    let v36 : string = failwith<string> v35
    v36 
    #endif
#else
    let v37 : (unit -> string) = System.IO.Path.GetTempPath
    let v38 : string = v37 ()
    v38 
    #endif
    |> fun x -> _v6 <- Some x
    let v39 : string = match _v6 with Some x -> x | None -> failwith "base.run_target / _v6=None"
    let v40 : string = method27()
    let v41 : string = method28(v39, v40)
    let v42 : string = method31()
    let v43 : string = method28(v41, v42)
    let v44 : (System.Guid -> string) = _.ToString()
    let v45 : string = v44 v4
    let v46 : string = method28(v43, v45)
    v46 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v47 : bool = true
    let mutable _v47 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v48 : string = "std::env::temp_dir()"
    let v49 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr () v48 
    let v50 : string = "$0.display()"
    let v51 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v49 v50 
    let v52 : bool = true
    let mutable _v52 : std_string_String option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v53 : string = "format!(\"{}\", $0)"
    let v54 : std_string_String = Fable.Core.RustInterop.emitRustExpr v51 v53 
    v54 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v55 : string = "format!(\"{}\", $0)"
    let v56 : std_string_String = Fable.Core.RustInterop.emitRustExpr v51 v55 
    v56 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v57 : string = "format!(\"{}\", $0)"
    let v58 : std_string_String = Fable.Core.RustInterop.emitRustExpr v51 v57 
    v58 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v59 : std_string_String = null |> unbox<std_string_String>
    v59 
    #endif
#if FABLE_COMPILER_PYTHON
    let v60 : std_string_String = null |> unbox<std_string_String>
    v60 
    #endif
#else
    let v61 : std_string_String = null |> unbox<std_string_String>
    v61 
    #endif
    |> fun x -> _v52 <- Some x
    let v62 : std_string_String = match _v52 with Some x -> x | None -> failwith "base.run_target / _v52=None"
    let v63 : string = "fable_library_rust::String_::fromString($0)"
    let v64 : string = Fable.Core.RustInterop.emitRustExpr v62 v63 
    v64 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v65 : US4 = US4_1
    let v66 : US5 = US5_0(v65)
    let v67 : string = $"file_system.get_temp_path / target: {v66}"
    let v68 : string = failwith<string> v67
    v68 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v69 : string = null |> unbox<string>
    v69 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v70 : US4 = US4_0
    let v71 : US5 = US5_2(v70)
    let v72 : string = $"file_system.get_temp_path / target: {v71}"
    let v73 : string = failwith<string> v72
    v73 
    #endif
#if FABLE_COMPILER_PYTHON
    let v74 : US4 = US4_0
    let v75 : US5 = US5_3(v74)
    let v76 : string = $"file_system.get_temp_path / target: {v75}"
    let v77 : string = failwith<string> v76
    v77 
    #endif
#else
    let v78 : (unit -> string) = System.IO.Path.GetTempPath
    let v79 : string = v78 ()
    v79 
    #endif
    |> fun x -> _v47 <- Some x
    let v80 : string = match _v47 with Some x -> x | None -> failwith "base.run_target / _v47=None"
    let v81 : string = method27()
    let v82 : string = method28(v80, v81)
    let v83 : string = method31()
    let v84 : string = method28(v82, v83)
    let v85 : (System.Guid -> string) = _.ToString()
    let v86 : string = v85 v4
    let v87 : string = method28(v84, v86)
    v87 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v88 : string = null |> unbox<string>
    v88 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v89 : bool = true
    let mutable _v89 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v90 : string = "std::env::temp_dir()"
    let v91 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr () v90 
    let v92 : string = "$0.display()"
    let v93 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v91 v92 
    let v94 : bool = true
    let mutable _v94 : std_string_String option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v95 : string = "format!(\"{}\", $0)"
    let v96 : std_string_String = Fable.Core.RustInterop.emitRustExpr v93 v95 
    v96 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v97 : string = "format!(\"{}\", $0)"
    let v98 : std_string_String = Fable.Core.RustInterop.emitRustExpr v93 v97 
    v98 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v99 : string = "format!(\"{}\", $0)"
    let v100 : std_string_String = Fable.Core.RustInterop.emitRustExpr v93 v99 
    v100 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v101 : std_string_String = null |> unbox<std_string_String>
    v101 
    #endif
#if FABLE_COMPILER_PYTHON
    let v102 : std_string_String = null |> unbox<std_string_String>
    v102 
    #endif
#else
    let v103 : std_string_String = null |> unbox<std_string_String>
    v103 
    #endif
    |> fun x -> _v94 <- Some x
    let v104 : std_string_String = match _v94 with Some x -> x | None -> failwith "base.run_target / _v94=None"
    let v105 : string = "fable_library_rust::String_::fromString($0)"
    let v106 : string = Fable.Core.RustInterop.emitRustExpr v104 v105 
    v106 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v107 : US4 = US4_1
    let v108 : US5 = US5_0(v107)
    let v109 : string = $"file_system.get_temp_path / target: {v108}"
    let v110 : string = failwith<string> v109
    v110 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v111 : string = null |> unbox<string>
    v111 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v112 : US4 = US4_0
    let v113 : US5 = US5_2(v112)
    let v114 : string = $"file_system.get_temp_path / target: {v113}"
    let v115 : string = failwith<string> v114
    v115 
    #endif
#if FABLE_COMPILER_PYTHON
    let v116 : US4 = US4_0
    let v117 : US5 = US5_3(v116)
    let v118 : string = $"file_system.get_temp_path / target: {v117}"
    let v119 : string = failwith<string> v118
    v119 
    #endif
#else
    let v120 : (unit -> string) = System.IO.Path.GetTempPath
    let v121 : string = v120 ()
    v121 
    #endif
    |> fun x -> _v89 <- Some x
    let v122 : string = match _v89 with Some x -> x | None -> failwith "base.run_target / _v89=None"
    let v123 : string = method27()
    let v124 : string = method28(v122, v123)
    let v125 : string = method31()
    let v126 : string = method28(v124, v125)
    let v127 : (System.Guid -> string) = _.ToString()
    let v128 : string = v127 v4
    let v129 : string = method28(v126, v128)
    v129 
    #endif
#if FABLE_COMPILER_PYTHON
    let v130 : bool = true
    let mutable _v130 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v131 : string = "std::env::temp_dir()"
    let v132 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr () v131 
    let v133 : string = "$0.display()"
    let v134 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v132 v133 
    let v135 : bool = true
    let mutable _v135 : std_string_String option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v136 : string = "format!(\"{}\", $0)"
    let v137 : std_string_String = Fable.Core.RustInterop.emitRustExpr v134 v136 
    v137 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v138 : string = "format!(\"{}\", $0)"
    let v139 : std_string_String = Fable.Core.RustInterop.emitRustExpr v134 v138 
    v139 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v140 : string = "format!(\"{}\", $0)"
    let v141 : std_string_String = Fable.Core.RustInterop.emitRustExpr v134 v140 
    v141 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v142 : std_string_String = null |> unbox<std_string_String>
    v142 
    #endif
#if FABLE_COMPILER_PYTHON
    let v143 : std_string_String = null |> unbox<std_string_String>
    v143 
    #endif
#else
    let v144 : std_string_String = null |> unbox<std_string_String>
    v144 
    #endif
    |> fun x -> _v135 <- Some x
    let v145 : std_string_String = match _v135 with Some x -> x | None -> failwith "base.run_target / _v135=None"
    let v146 : string = "fable_library_rust::String_::fromString($0)"
    let v147 : string = Fable.Core.RustInterop.emitRustExpr v145 v146 
    v147 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v148 : US4 = US4_1
    let v149 : US5 = US5_0(v148)
    let v150 : string = $"file_system.get_temp_path / target: {v149}"
    let v151 : string = failwith<string> v150
    v151 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v152 : string = null |> unbox<string>
    v152 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v153 : US4 = US4_0
    let v154 : US5 = US5_2(v153)
    let v155 : string = $"file_system.get_temp_path / target: {v154}"
    let v156 : string = failwith<string> v155
    v156 
    #endif
#if FABLE_COMPILER_PYTHON
    let v157 : US4 = US4_0
    let v158 : US5 = US5_3(v157)
    let v159 : string = $"file_system.get_temp_path / target: {v158}"
    let v160 : string = failwith<string> v159
    v160 
    #endif
#else
    let v161 : (unit -> string) = System.IO.Path.GetTempPath
    let v162 : string = v161 ()
    v162 
    #endif
    |> fun x -> _v130 <- Some x
    let v163 : string = match _v130 with Some x -> x | None -> failwith "base.run_target / _v130=None"
    let v164 : string = method27()
    let v165 : string = method28(v163, v164)
    let v166 : string = method31()
    let v167 : string = method28(v165, v166)
    let v168 : (System.Guid -> string) = _.ToString()
    let v169 : string = v168 v4
    let v170 : string = method28(v167, v169)
    v170 
    #endif
#else
    let v171 : bool = true
    let mutable _v171 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v172 : string = "std::env::temp_dir()"
    let v173 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr () v172 
    let v174 : string = "$0.display()"
    let v175 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v173 v174 
    let v176 : bool = true
    let mutable _v176 : std_string_String option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v177 : string = "format!(\"{}\", $0)"
    let v178 : std_string_String = Fable.Core.RustInterop.emitRustExpr v175 v177 
    v178 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v179 : string = "format!(\"{}\", $0)"
    let v180 : std_string_String = Fable.Core.RustInterop.emitRustExpr v175 v179 
    v180 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v181 : string = "format!(\"{}\", $0)"
    let v182 : std_string_String = Fable.Core.RustInterop.emitRustExpr v175 v181 
    v182 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v183 : std_string_String = null |> unbox<std_string_String>
    v183 
    #endif
#if FABLE_COMPILER_PYTHON
    let v184 : std_string_String = null |> unbox<std_string_String>
    v184 
    #endif
#else
    let v185 : std_string_String = null |> unbox<std_string_String>
    v185 
    #endif
    |> fun x -> _v176 <- Some x
    let v186 : std_string_String = match _v176 with Some x -> x | None -> failwith "base.run_target / _v176=None"
    let v187 : string = "fable_library_rust::String_::fromString($0)"
    let v188 : string = Fable.Core.RustInterop.emitRustExpr v186 v187 
    v188 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v189 : US4 = US4_1
    let v190 : US5 = US5_0(v189)
    let v191 : string = $"file_system.get_temp_path / target: {v190}"
    let v192 : string = failwith<string> v191
    v192 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v193 : string = null |> unbox<string>
    v193 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v194 : US4 = US4_0
    let v195 : US5 = US5_2(v194)
    let v196 : string = $"file_system.get_temp_path / target: {v195}"
    let v197 : string = failwith<string> v196
    v197 
    #endif
#if FABLE_COMPILER_PYTHON
    let v198 : US4 = US4_0
    let v199 : US5 = US5_3(v198)
    let v200 : string = $"file_system.get_temp_path / target: {v199}"
    let v201 : string = failwith<string> v200
    v201 
    #endif
#else
    let v202 : (unit -> string) = System.IO.Path.GetTempPath
    let v203 : string = v202 ()
    v203 
    #endif
    |> fun x -> _v171 <- Some x
    let v204 : string = match _v171 with Some x -> x | None -> failwith "base.run_target / _v171=None"
    let v205 : string = method27()
    let v206 : string = method28(v204, v205)
    let v207 : string = method31()
    let v208 : string = method28(v206, v207)
    let v209 : (System.Guid -> string) = _.ToString()
    let v210 : string = v209 v4
    let v211 : string = method28(v208, v210)
    v211 
    #endif
    |> fun x -> _v5 <- Some x
    let v212 : string = match _v5 with Some x -> x | None -> failwith "base.run_target / _v5=None"
    v212 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v213 : System.DateTime = System.DateTime.Now
    let v214 : (unit -> System.Guid) = System.Guid.NewGuid
    let v215 : System.Guid = v214 ()
    let v216 : System.Guid = method21(v215, v213)
    let v217 : bool = true
    let mutable _v217 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v218 : bool = true
    let mutable _v218 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v219 : string = "std::env::temp_dir()"
    let v220 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr () v219 
    let v221 : string = "$0.display()"
    let v222 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v220 v221 
    let v223 : bool = true
    let mutable _v223 : std_string_String option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v224 : string = "format!(\"{}\", $0)"
    let v225 : std_string_String = Fable.Core.RustInterop.emitRustExpr v222 v224 
    v225 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v226 : string = "format!(\"{}\", $0)"
    let v227 : std_string_String = Fable.Core.RustInterop.emitRustExpr v222 v226 
    v227 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v228 : string = "format!(\"{}\", $0)"
    let v229 : std_string_String = Fable.Core.RustInterop.emitRustExpr v222 v228 
    v229 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v230 : std_string_String = null |> unbox<std_string_String>
    v230 
    #endif
#if FABLE_COMPILER_PYTHON
    let v231 : std_string_String = null |> unbox<std_string_String>
    v231 
    #endif
#else
    let v232 : std_string_String = null |> unbox<std_string_String>
    v232 
    #endif
    |> fun x -> _v223 <- Some x
    let v233 : std_string_String = match _v223 with Some x -> x | None -> failwith "base.run_target / _v223=None"
    let v234 : string = "fable_library_rust::String_::fromString($0)"
    let v235 : string = Fable.Core.RustInterop.emitRustExpr v233 v234 
    v235 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v236 : US4 = US4_1
    let v237 : US5 = US5_0(v236)
    let v238 : string = $"file_system.get_temp_path / target: {v237}"
    let v239 : string = failwith<string> v238
    v239 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v240 : string = null |> unbox<string>
    v240 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v241 : US4 = US4_0
    let v242 : US5 = US5_2(v241)
    let v243 : string = $"file_system.get_temp_path / target: {v242}"
    let v244 : string = failwith<string> v243
    v244 
    #endif
#if FABLE_COMPILER_PYTHON
    let v245 : US4 = US4_0
    let v246 : US5 = US5_3(v245)
    let v247 : string = $"file_system.get_temp_path / target: {v246}"
    let v248 : string = failwith<string> v247
    v248 
    #endif
#else
    let v249 : (unit -> string) = System.IO.Path.GetTempPath
    let v250 : string = v249 ()
    v250 
    #endif
    |> fun x -> _v218 <- Some x
    let v251 : string = match _v218 with Some x -> x | None -> failwith "base.run_target / _v218=None"
    let v252 : string = method27()
    let v253 : string = method28(v251, v252)
    let v254 : string = method31()
    let v255 : string = method28(v253, v254)
    let v256 : (System.Guid -> string) = _.ToString()
    let v257 : string = v256 v216
    let v258 : string = method28(v255, v257)
    v258 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v259 : bool = true
    let mutable _v259 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v260 : string = "std::env::temp_dir()"
    let v261 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr () v260 
    let v262 : string = "$0.display()"
    let v263 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v261 v262 
    let v264 : bool = true
    let mutable _v264 : std_string_String option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v265 : string = "format!(\"{}\", $0)"
    let v266 : std_string_String = Fable.Core.RustInterop.emitRustExpr v263 v265 
    v266 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v267 : string = "format!(\"{}\", $0)"
    let v268 : std_string_String = Fable.Core.RustInterop.emitRustExpr v263 v267 
    v268 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v269 : string = "format!(\"{}\", $0)"
    let v270 : std_string_String = Fable.Core.RustInterop.emitRustExpr v263 v269 
    v270 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v271 : std_string_String = null |> unbox<std_string_String>
    v271 
    #endif
#if FABLE_COMPILER_PYTHON
    let v272 : std_string_String = null |> unbox<std_string_String>
    v272 
    #endif
#else
    let v273 : std_string_String = null |> unbox<std_string_String>
    v273 
    #endif
    |> fun x -> _v264 <- Some x
    let v274 : std_string_String = match _v264 with Some x -> x | None -> failwith "base.run_target / _v264=None"
    let v275 : string = "fable_library_rust::String_::fromString($0)"
    let v276 : string = Fable.Core.RustInterop.emitRustExpr v274 v275 
    v276 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v277 : US4 = US4_1
    let v278 : US5 = US5_0(v277)
    let v279 : string = $"file_system.get_temp_path / target: {v278}"
    let v280 : string = failwith<string> v279
    v280 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v281 : string = null |> unbox<string>
    v281 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v282 : US4 = US4_0
    let v283 : US5 = US5_2(v282)
    let v284 : string = $"file_system.get_temp_path / target: {v283}"
    let v285 : string = failwith<string> v284
    v285 
    #endif
#if FABLE_COMPILER_PYTHON
    let v286 : US4 = US4_0
    let v287 : US5 = US5_3(v286)
    let v288 : string = $"file_system.get_temp_path / target: {v287}"
    let v289 : string = failwith<string> v288
    v289 
    #endif
#else
    let v290 : (unit -> string) = System.IO.Path.GetTempPath
    let v291 : string = v290 ()
    v291 
    #endif
    |> fun x -> _v259 <- Some x
    let v292 : string = match _v259 with Some x -> x | None -> failwith "base.run_target / _v259=None"
    let v293 : string = method27()
    let v294 : string = method28(v292, v293)
    let v295 : string = method31()
    let v296 : string = method28(v294, v295)
    let v297 : (System.Guid -> string) = _.ToString()
    let v298 : string = v297 v216
    let v299 : string = method28(v296, v298)
    v299 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v300 : string = null |> unbox<string>
    v300 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v301 : bool = true
    let mutable _v301 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v302 : string = "std::env::temp_dir()"
    let v303 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr () v302 
    let v304 : string = "$0.display()"
    let v305 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v303 v304 
    let v306 : bool = true
    let mutable _v306 : std_string_String option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v307 : string = "format!(\"{}\", $0)"
    let v308 : std_string_String = Fable.Core.RustInterop.emitRustExpr v305 v307 
    v308 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v309 : string = "format!(\"{}\", $0)"
    let v310 : std_string_String = Fable.Core.RustInterop.emitRustExpr v305 v309 
    v310 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v311 : string = "format!(\"{}\", $0)"
    let v312 : std_string_String = Fable.Core.RustInterop.emitRustExpr v305 v311 
    v312 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v313 : std_string_String = null |> unbox<std_string_String>
    v313 
    #endif
#if FABLE_COMPILER_PYTHON
    let v314 : std_string_String = null |> unbox<std_string_String>
    v314 
    #endif
#else
    let v315 : std_string_String = null |> unbox<std_string_String>
    v315 
    #endif
    |> fun x -> _v306 <- Some x
    let v316 : std_string_String = match _v306 with Some x -> x | None -> failwith "base.run_target / _v306=None"
    let v317 : string = "fable_library_rust::String_::fromString($0)"
    let v318 : string = Fable.Core.RustInterop.emitRustExpr v316 v317 
    v318 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v319 : US4 = US4_1
    let v320 : US5 = US5_0(v319)
    let v321 : string = $"file_system.get_temp_path / target: {v320}"
    let v322 : string = failwith<string> v321
    v322 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v323 : string = null |> unbox<string>
    v323 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v324 : US4 = US4_0
    let v325 : US5 = US5_2(v324)
    let v326 : string = $"file_system.get_temp_path / target: {v325}"
    let v327 : string = failwith<string> v326
    v327 
    #endif
#if FABLE_COMPILER_PYTHON
    let v328 : US4 = US4_0
    let v329 : US5 = US5_3(v328)
    let v330 : string = $"file_system.get_temp_path / target: {v329}"
    let v331 : string = failwith<string> v330
    v331 
    #endif
#else
    let v332 : (unit -> string) = System.IO.Path.GetTempPath
    let v333 : string = v332 ()
    v333 
    #endif
    |> fun x -> _v301 <- Some x
    let v334 : string = match _v301 with Some x -> x | None -> failwith "base.run_target / _v301=None"
    let v335 : string = method27()
    let v336 : string = method28(v334, v335)
    let v337 : string = method31()
    let v338 : string = method28(v336, v337)
    let v339 : (System.Guid -> string) = _.ToString()
    let v340 : string = v339 v216
    let v341 : string = method28(v338, v340)
    v341 
    #endif
#if FABLE_COMPILER_PYTHON
    let v342 : bool = true
    let mutable _v342 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v343 : string = "std::env::temp_dir()"
    let v344 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr () v343 
    let v345 : string = "$0.display()"
    let v346 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v344 v345 
    let v347 : bool = true
    let mutable _v347 : std_string_String option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v348 : string = "format!(\"{}\", $0)"
    let v349 : std_string_String = Fable.Core.RustInterop.emitRustExpr v346 v348 
    v349 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v350 : string = "format!(\"{}\", $0)"
    let v351 : std_string_String = Fable.Core.RustInterop.emitRustExpr v346 v350 
    v351 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v352 : string = "format!(\"{}\", $0)"
    let v353 : std_string_String = Fable.Core.RustInterop.emitRustExpr v346 v352 
    v353 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v354 : std_string_String = null |> unbox<std_string_String>
    v354 
    #endif
#if FABLE_COMPILER_PYTHON
    let v355 : std_string_String = null |> unbox<std_string_String>
    v355 
    #endif
#else
    let v356 : std_string_String = null |> unbox<std_string_String>
    v356 
    #endif
    |> fun x -> _v347 <- Some x
    let v357 : std_string_String = match _v347 with Some x -> x | None -> failwith "base.run_target / _v347=None"
    let v358 : string = "fable_library_rust::String_::fromString($0)"
    let v359 : string = Fable.Core.RustInterop.emitRustExpr v357 v358 
    v359 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v360 : US4 = US4_1
    let v361 : US5 = US5_0(v360)
    let v362 : string = $"file_system.get_temp_path / target: {v361}"
    let v363 : string = failwith<string> v362
    v363 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v364 : string = null |> unbox<string>
    v364 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v365 : US4 = US4_0
    let v366 : US5 = US5_2(v365)
    let v367 : string = $"file_system.get_temp_path / target: {v366}"
    let v368 : string = failwith<string> v367
    v368 
    #endif
#if FABLE_COMPILER_PYTHON
    let v369 : US4 = US4_0
    let v370 : US5 = US5_3(v369)
    let v371 : string = $"file_system.get_temp_path / target: {v370}"
    let v372 : string = failwith<string> v371
    v372 
    #endif
#else
    let v373 : (unit -> string) = System.IO.Path.GetTempPath
    let v374 : string = v373 ()
    v374 
    #endif
    |> fun x -> _v342 <- Some x
    let v375 : string = match _v342 with Some x -> x | None -> failwith "base.run_target / _v342=None"
    let v376 : string = method27()
    let v377 : string = method28(v375, v376)
    let v378 : string = method31()
    let v379 : string = method28(v377, v378)
    let v380 : (System.Guid -> string) = _.ToString()
    let v381 : string = v380 v216
    let v382 : string = method28(v379, v381)
    v382 
    #endif
#else
    let v383 : bool = true
    let mutable _v383 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v384 : string = "std::env::temp_dir()"
    let v385 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr () v384 
    let v386 : string = "$0.display()"
    let v387 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v385 v386 
    let v388 : bool = true
    let mutable _v388 : std_string_String option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v389 : string = "format!(\"{}\", $0)"
    let v390 : std_string_String = Fable.Core.RustInterop.emitRustExpr v387 v389 
    v390 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v391 : string = "format!(\"{}\", $0)"
    let v392 : std_string_String = Fable.Core.RustInterop.emitRustExpr v387 v391 
    v392 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v393 : string = "format!(\"{}\", $0)"
    let v394 : std_string_String = Fable.Core.RustInterop.emitRustExpr v387 v393 
    v394 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v395 : std_string_String = null |> unbox<std_string_String>
    v395 
    #endif
#if FABLE_COMPILER_PYTHON
    let v396 : std_string_String = null |> unbox<std_string_String>
    v396 
    #endif
#else
    let v397 : std_string_String = null |> unbox<std_string_String>
    v397 
    #endif
    |> fun x -> _v388 <- Some x
    let v398 : std_string_String = match _v388 with Some x -> x | None -> failwith "base.run_target / _v388=None"
    let v399 : string = "fable_library_rust::String_::fromString($0)"
    let v400 : string = Fable.Core.RustInterop.emitRustExpr v398 v399 
    v400 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v401 : US4 = US4_1
    let v402 : US5 = US5_0(v401)
    let v403 : string = $"file_system.get_temp_path / target: {v402}"
    let v404 : string = failwith<string> v403
    v404 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v405 : string = null |> unbox<string>
    v405 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v406 : US4 = US4_0
    let v407 : US5 = US5_2(v406)
    let v408 : string = $"file_system.get_temp_path / target: {v407}"
    let v409 : string = failwith<string> v408
    v409 
    #endif
#if FABLE_COMPILER_PYTHON
    let v410 : US4 = US4_0
    let v411 : US5 = US5_3(v410)
    let v412 : string = $"file_system.get_temp_path / target: {v411}"
    let v413 : string = failwith<string> v412
    v413 
    #endif
#else
    let v414 : (unit -> string) = System.IO.Path.GetTempPath
    let v415 : string = v414 ()
    v415 
    #endif
    |> fun x -> _v383 <- Some x
    let v416 : string = match _v383 with Some x -> x | None -> failwith "base.run_target / _v383=None"
    let v417 : string = method27()
    let v418 : string = method28(v416, v417)
    let v419 : string = method31()
    let v420 : string = method28(v418, v419)
    let v421 : (System.Guid -> string) = _.ToString()
    let v422 : string = v421 v216
    let v423 : string = method28(v420, v422)
    v423 
    #endif
    |> fun x -> _v217 <- Some x
    let v424 : string = match _v217 with Some x -> x | None -> failwith "base.run_target / _v217=None"
    v424 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v425 : string = null |> unbox<string>
    v425 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v426 : System.DateTime = System.DateTime.Now
    let v427 : (unit -> System.Guid) = System.Guid.NewGuid
    let v428 : System.Guid = v427 ()
    let v429 : System.Guid = method21(v428, v426)
    let v430 : bool = true
    let mutable _v430 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v431 : bool = true
    let mutable _v431 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v432 : string = "std::env::temp_dir()"
    let v433 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr () v432 
    let v434 : string = "$0.display()"
    let v435 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v433 v434 
    let v436 : bool = true
    let mutable _v436 : std_string_String option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v437 : string = "format!(\"{}\", $0)"
    let v438 : std_string_String = Fable.Core.RustInterop.emitRustExpr v435 v437 
    v438 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v439 : string = "format!(\"{}\", $0)"
    let v440 : std_string_String = Fable.Core.RustInterop.emitRustExpr v435 v439 
    v440 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v441 : string = "format!(\"{}\", $0)"
    let v442 : std_string_String = Fable.Core.RustInterop.emitRustExpr v435 v441 
    v442 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v443 : std_string_String = null |> unbox<std_string_String>
    v443 
    #endif
#if FABLE_COMPILER_PYTHON
    let v444 : std_string_String = null |> unbox<std_string_String>
    v444 
    #endif
#else
    let v445 : std_string_String = null |> unbox<std_string_String>
    v445 
    #endif
    |> fun x -> _v436 <- Some x
    let v446 : std_string_String = match _v436 with Some x -> x | None -> failwith "base.run_target / _v436=None"
    let v447 : string = "fable_library_rust::String_::fromString($0)"
    let v448 : string = Fable.Core.RustInterop.emitRustExpr v446 v447 
    v448 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v449 : US4 = US4_1
    let v450 : US5 = US5_0(v449)
    let v451 : string = $"file_system.get_temp_path / target: {v450}"
    let v452 : string = failwith<string> v451
    v452 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v453 : string = null |> unbox<string>
    v453 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v454 : US4 = US4_0
    let v455 : US5 = US5_2(v454)
    let v456 : string = $"file_system.get_temp_path / target: {v455}"
    let v457 : string = failwith<string> v456
    v457 
    #endif
#if FABLE_COMPILER_PYTHON
    let v458 : US4 = US4_0
    let v459 : US5 = US5_3(v458)
    let v460 : string = $"file_system.get_temp_path / target: {v459}"
    let v461 : string = failwith<string> v460
    v461 
    #endif
#else
    let v462 : (unit -> string) = System.IO.Path.GetTempPath
    let v463 : string = v462 ()
    v463 
    #endif
    |> fun x -> _v431 <- Some x
    let v464 : string = match _v431 with Some x -> x | None -> failwith "base.run_target / _v431=None"
    let v465 : string = method27()
    let v466 : string = method28(v464, v465)
    let v467 : string = method31()
    let v468 : string = method28(v466, v467)
    let v469 : (System.Guid -> string) = _.ToString()
    let v470 : string = v469 v429
    let v471 : string = method28(v468, v470)
    v471 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v472 : bool = true
    let mutable _v472 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v473 : string = "std::env::temp_dir()"
    let v474 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr () v473 
    let v475 : string = "$0.display()"
    let v476 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v474 v475 
    let v477 : bool = true
    let mutable _v477 : std_string_String option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v478 : string = "format!(\"{}\", $0)"
    let v479 : std_string_String = Fable.Core.RustInterop.emitRustExpr v476 v478 
    v479 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v480 : string = "format!(\"{}\", $0)"
    let v481 : std_string_String = Fable.Core.RustInterop.emitRustExpr v476 v480 
    v481 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v482 : string = "format!(\"{}\", $0)"
    let v483 : std_string_String = Fable.Core.RustInterop.emitRustExpr v476 v482 
    v483 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v484 : std_string_String = null |> unbox<std_string_String>
    v484 
    #endif
#if FABLE_COMPILER_PYTHON
    let v485 : std_string_String = null |> unbox<std_string_String>
    v485 
    #endif
#else
    let v486 : std_string_String = null |> unbox<std_string_String>
    v486 
    #endif
    |> fun x -> _v477 <- Some x
    let v487 : std_string_String = match _v477 with Some x -> x | None -> failwith "base.run_target / _v477=None"
    let v488 : string = "fable_library_rust::String_::fromString($0)"
    let v489 : string = Fable.Core.RustInterop.emitRustExpr v487 v488 
    v489 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v490 : US4 = US4_1
    let v491 : US5 = US5_0(v490)
    let v492 : string = $"file_system.get_temp_path / target: {v491}"
    let v493 : string = failwith<string> v492
    v493 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v494 : string = null |> unbox<string>
    v494 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v495 : US4 = US4_0
    let v496 : US5 = US5_2(v495)
    let v497 : string = $"file_system.get_temp_path / target: {v496}"
    let v498 : string = failwith<string> v497
    v498 
    #endif
#if FABLE_COMPILER_PYTHON
    let v499 : US4 = US4_0
    let v500 : US5 = US5_3(v499)
    let v501 : string = $"file_system.get_temp_path / target: {v500}"
    let v502 : string = failwith<string> v501
    v502 
    #endif
#else
    let v503 : (unit -> string) = System.IO.Path.GetTempPath
    let v504 : string = v503 ()
    v504 
    #endif
    |> fun x -> _v472 <- Some x
    let v505 : string = match _v472 with Some x -> x | None -> failwith "base.run_target / _v472=None"
    let v506 : string = method27()
    let v507 : string = method28(v505, v506)
    let v508 : string = method31()
    let v509 : string = method28(v507, v508)
    let v510 : (System.Guid -> string) = _.ToString()
    let v511 : string = v510 v429
    let v512 : string = method28(v509, v511)
    v512 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v513 : string = null |> unbox<string>
    v513 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v514 : bool = true
    let mutable _v514 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v515 : string = "std::env::temp_dir()"
    let v516 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr () v515 
    let v517 : string = "$0.display()"
    let v518 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v516 v517 
    let v519 : bool = true
    let mutable _v519 : std_string_String option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v520 : string = "format!(\"{}\", $0)"
    let v521 : std_string_String = Fable.Core.RustInterop.emitRustExpr v518 v520 
    v521 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v522 : string = "format!(\"{}\", $0)"
    let v523 : std_string_String = Fable.Core.RustInterop.emitRustExpr v518 v522 
    v523 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v524 : string = "format!(\"{}\", $0)"
    let v525 : std_string_String = Fable.Core.RustInterop.emitRustExpr v518 v524 
    v525 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v526 : std_string_String = null |> unbox<std_string_String>
    v526 
    #endif
#if FABLE_COMPILER_PYTHON
    let v527 : std_string_String = null |> unbox<std_string_String>
    v527 
    #endif
#else
    let v528 : std_string_String = null |> unbox<std_string_String>
    v528 
    #endif
    |> fun x -> _v519 <- Some x
    let v529 : std_string_String = match _v519 with Some x -> x | None -> failwith "base.run_target / _v519=None"
    let v530 : string = "fable_library_rust::String_::fromString($0)"
    let v531 : string = Fable.Core.RustInterop.emitRustExpr v529 v530 
    v531 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v532 : US4 = US4_1
    let v533 : US5 = US5_0(v532)
    let v534 : string = $"file_system.get_temp_path / target: {v533}"
    let v535 : string = failwith<string> v534
    v535 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v536 : string = null |> unbox<string>
    v536 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v537 : US4 = US4_0
    let v538 : US5 = US5_2(v537)
    let v539 : string = $"file_system.get_temp_path / target: {v538}"
    let v540 : string = failwith<string> v539
    v540 
    #endif
#if FABLE_COMPILER_PYTHON
    let v541 : US4 = US4_0
    let v542 : US5 = US5_3(v541)
    let v543 : string = $"file_system.get_temp_path / target: {v542}"
    let v544 : string = failwith<string> v543
    v544 
    #endif
#else
    let v545 : (unit -> string) = System.IO.Path.GetTempPath
    let v546 : string = v545 ()
    v546 
    #endif
    |> fun x -> _v514 <- Some x
    let v547 : string = match _v514 with Some x -> x | None -> failwith "base.run_target / _v514=None"
    let v548 : string = method27()
    let v549 : string = method28(v547, v548)
    let v550 : string = method31()
    let v551 : string = method28(v549, v550)
    let v552 : (System.Guid -> string) = _.ToString()
    let v553 : string = v552 v429
    let v554 : string = method28(v551, v553)
    v554 
    #endif
#if FABLE_COMPILER_PYTHON
    let v555 : bool = true
    let mutable _v555 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v556 : string = "std::env::temp_dir()"
    let v557 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr () v556 
    let v558 : string = "$0.display()"
    let v559 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v557 v558 
    let v560 : bool = true
    let mutable _v560 : std_string_String option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v561 : string = "format!(\"{}\", $0)"
    let v562 : std_string_String = Fable.Core.RustInterop.emitRustExpr v559 v561 
    v562 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v563 : string = "format!(\"{}\", $0)"
    let v564 : std_string_String = Fable.Core.RustInterop.emitRustExpr v559 v563 
    v564 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v565 : string = "format!(\"{}\", $0)"
    let v566 : std_string_String = Fable.Core.RustInterop.emitRustExpr v559 v565 
    v566 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v567 : std_string_String = null |> unbox<std_string_String>
    v567 
    #endif
#if FABLE_COMPILER_PYTHON
    let v568 : std_string_String = null |> unbox<std_string_String>
    v568 
    #endif
#else
    let v569 : std_string_String = null |> unbox<std_string_String>
    v569 
    #endif
    |> fun x -> _v560 <- Some x
    let v570 : std_string_String = match _v560 with Some x -> x | None -> failwith "base.run_target / _v560=None"
    let v571 : string = "fable_library_rust::String_::fromString($0)"
    let v572 : string = Fable.Core.RustInterop.emitRustExpr v570 v571 
    v572 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v573 : US4 = US4_1
    let v574 : US5 = US5_0(v573)
    let v575 : string = $"file_system.get_temp_path / target: {v574}"
    let v576 : string = failwith<string> v575
    v576 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v577 : string = null |> unbox<string>
    v577 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v578 : US4 = US4_0
    let v579 : US5 = US5_2(v578)
    let v580 : string = $"file_system.get_temp_path / target: {v579}"
    let v581 : string = failwith<string> v580
    v581 
    #endif
#if FABLE_COMPILER_PYTHON
    let v582 : US4 = US4_0
    let v583 : US5 = US5_3(v582)
    let v584 : string = $"file_system.get_temp_path / target: {v583}"
    let v585 : string = failwith<string> v584
    v585 
    #endif
#else
    let v586 : (unit -> string) = System.IO.Path.GetTempPath
    let v587 : string = v586 ()
    v587 
    #endif
    |> fun x -> _v555 <- Some x
    let v588 : string = match _v555 with Some x -> x | None -> failwith "base.run_target / _v555=None"
    let v589 : string = method27()
    let v590 : string = method28(v588, v589)
    let v591 : string = method31()
    let v592 : string = method28(v590, v591)
    let v593 : (System.Guid -> string) = _.ToString()
    let v594 : string = v593 v429
    let v595 : string = method28(v592, v594)
    v595 
    #endif
#else
    let v596 : bool = true
    let mutable _v596 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v597 : string = "std::env::temp_dir()"
    let v598 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr () v597 
    let v599 : string = "$0.display()"
    let v600 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v598 v599 
    let v601 : bool = true
    let mutable _v601 : std_string_String option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v602 : string = "format!(\"{}\", $0)"
    let v603 : std_string_String = Fable.Core.RustInterop.emitRustExpr v600 v602 
    v603 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v604 : string = "format!(\"{}\", $0)"
    let v605 : std_string_String = Fable.Core.RustInterop.emitRustExpr v600 v604 
    v605 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v606 : string = "format!(\"{}\", $0)"
    let v607 : std_string_String = Fable.Core.RustInterop.emitRustExpr v600 v606 
    v607 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v608 : std_string_String = null |> unbox<std_string_String>
    v608 
    #endif
#if FABLE_COMPILER_PYTHON
    let v609 : std_string_String = null |> unbox<std_string_String>
    v609 
    #endif
#else
    let v610 : std_string_String = null |> unbox<std_string_String>
    v610 
    #endif
    |> fun x -> _v601 <- Some x
    let v611 : std_string_String = match _v601 with Some x -> x | None -> failwith "base.run_target / _v601=None"
    let v612 : string = "fable_library_rust::String_::fromString($0)"
    let v613 : string = Fable.Core.RustInterop.emitRustExpr v611 v612 
    v613 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v614 : US4 = US4_1
    let v615 : US5 = US5_0(v614)
    let v616 : string = $"file_system.get_temp_path / target: {v615}"
    let v617 : string = failwith<string> v616
    v617 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v618 : string = null |> unbox<string>
    v618 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v619 : US4 = US4_0
    let v620 : US5 = US5_2(v619)
    let v621 : string = $"file_system.get_temp_path / target: {v620}"
    let v622 : string = failwith<string> v621
    v622 
    #endif
#if FABLE_COMPILER_PYTHON
    let v623 : US4 = US4_0
    let v624 : US5 = US5_3(v623)
    let v625 : string = $"file_system.get_temp_path / target: {v624}"
    let v626 : string = failwith<string> v625
    v626 
    #endif
#else
    let v627 : (unit -> string) = System.IO.Path.GetTempPath
    let v628 : string = v627 ()
    v628 
    #endif
    |> fun x -> _v596 <- Some x
    let v629 : string = match _v596 with Some x -> x | None -> failwith "base.run_target / _v596=None"
    let v630 : string = method27()
    let v631 : string = method28(v629, v630)
    let v632 : string = method31()
    let v633 : string = method28(v631, v632)
    let v634 : (System.Guid -> string) = _.ToString()
    let v635 : string = v634 v429
    let v636 : string = method28(v633, v635)
    v636 
    #endif
    |> fun x -> _v430 <- Some x
    let v637 : string = match _v430 with Some x -> x | None -> failwith "base.run_target / _v430=None"
    v637 
    #endif
#if FABLE_COMPILER_PYTHON
    let v638 : System.DateTime = System.DateTime.Now
    let v639 : (unit -> System.Guid) = System.Guid.NewGuid
    let v640 : System.Guid = v639 ()
    let v641 : System.Guid = method21(v640, v638)
    let v642 : bool = true
    let mutable _v642 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v643 : bool = true
    let mutable _v643 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v644 : string = "std::env::temp_dir()"
    let v645 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr () v644 
    let v646 : string = "$0.display()"
    let v647 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v645 v646 
    let v648 : bool = true
    let mutable _v648 : std_string_String option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v649 : string = "format!(\"{}\", $0)"
    let v650 : std_string_String = Fable.Core.RustInterop.emitRustExpr v647 v649 
    v650 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v651 : string = "format!(\"{}\", $0)"
    let v652 : std_string_String = Fable.Core.RustInterop.emitRustExpr v647 v651 
    v652 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v653 : string = "format!(\"{}\", $0)"
    let v654 : std_string_String = Fable.Core.RustInterop.emitRustExpr v647 v653 
    v654 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v655 : std_string_String = null |> unbox<std_string_String>
    v655 
    #endif
#if FABLE_COMPILER_PYTHON
    let v656 : std_string_String = null |> unbox<std_string_String>
    v656 
    #endif
#else
    let v657 : std_string_String = null |> unbox<std_string_String>
    v657 
    #endif
    |> fun x -> _v648 <- Some x
    let v658 : std_string_String = match _v648 with Some x -> x | None -> failwith "base.run_target / _v648=None"
    let v659 : string = "fable_library_rust::String_::fromString($0)"
    let v660 : string = Fable.Core.RustInterop.emitRustExpr v658 v659 
    v660 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v661 : US4 = US4_1
    let v662 : US5 = US5_0(v661)
    let v663 : string = $"file_system.get_temp_path / target: {v662}"
    let v664 : string = failwith<string> v663
    v664 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v665 : string = null |> unbox<string>
    v665 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v666 : US4 = US4_0
    let v667 : US5 = US5_2(v666)
    let v668 : string = $"file_system.get_temp_path / target: {v667}"
    let v669 : string = failwith<string> v668
    v669 
    #endif
#if FABLE_COMPILER_PYTHON
    let v670 : US4 = US4_0
    let v671 : US5 = US5_3(v670)
    let v672 : string = $"file_system.get_temp_path / target: {v671}"
    let v673 : string = failwith<string> v672
    v673 
    #endif
#else
    let v674 : (unit -> string) = System.IO.Path.GetTempPath
    let v675 : string = v674 ()
    v675 
    #endif
    |> fun x -> _v643 <- Some x
    let v676 : string = match _v643 with Some x -> x | None -> failwith "base.run_target / _v643=None"
    let v677 : string = method27()
    let v678 : string = method28(v676, v677)
    let v679 : string = method31()
    let v680 : string = method28(v678, v679)
    let v681 : (System.Guid -> string) = _.ToString()
    let v682 : string = v681 v641
    let v683 : string = method28(v680, v682)
    v683 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v684 : bool = true
    let mutable _v684 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v685 : string = "std::env::temp_dir()"
    let v686 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr () v685 
    let v687 : string = "$0.display()"
    let v688 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v686 v687 
    let v689 : bool = true
    let mutable _v689 : std_string_String option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v690 : string = "format!(\"{}\", $0)"
    let v691 : std_string_String = Fable.Core.RustInterop.emitRustExpr v688 v690 
    v691 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v692 : string = "format!(\"{}\", $0)"
    let v693 : std_string_String = Fable.Core.RustInterop.emitRustExpr v688 v692 
    v693 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v694 : string = "format!(\"{}\", $0)"
    let v695 : std_string_String = Fable.Core.RustInterop.emitRustExpr v688 v694 
    v695 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v696 : std_string_String = null |> unbox<std_string_String>
    v696 
    #endif
#if FABLE_COMPILER_PYTHON
    let v697 : std_string_String = null |> unbox<std_string_String>
    v697 
    #endif
#else
    let v698 : std_string_String = null |> unbox<std_string_String>
    v698 
    #endif
    |> fun x -> _v689 <- Some x
    let v699 : std_string_String = match _v689 with Some x -> x | None -> failwith "base.run_target / _v689=None"
    let v700 : string = "fable_library_rust::String_::fromString($0)"
    let v701 : string = Fable.Core.RustInterop.emitRustExpr v699 v700 
    v701 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v702 : US4 = US4_1
    let v703 : US5 = US5_0(v702)
    let v704 : string = $"file_system.get_temp_path / target: {v703}"
    let v705 : string = failwith<string> v704
    v705 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v706 : string = null |> unbox<string>
    v706 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v707 : US4 = US4_0
    let v708 : US5 = US5_2(v707)
    let v709 : string = $"file_system.get_temp_path / target: {v708}"
    let v710 : string = failwith<string> v709
    v710 
    #endif
#if FABLE_COMPILER_PYTHON
    let v711 : US4 = US4_0
    let v712 : US5 = US5_3(v711)
    let v713 : string = $"file_system.get_temp_path / target: {v712}"
    let v714 : string = failwith<string> v713
    v714 
    #endif
#else
    let v715 : (unit -> string) = System.IO.Path.GetTempPath
    let v716 : string = v715 ()
    v716 
    #endif
    |> fun x -> _v684 <- Some x
    let v717 : string = match _v684 with Some x -> x | None -> failwith "base.run_target / _v684=None"
    let v718 : string = method27()
    let v719 : string = method28(v717, v718)
    let v720 : string = method31()
    let v721 : string = method28(v719, v720)
    let v722 : (System.Guid -> string) = _.ToString()
    let v723 : string = v722 v641
    let v724 : string = method28(v721, v723)
    v724 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v725 : string = null |> unbox<string>
    v725 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v726 : bool = true
    let mutable _v726 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v727 : string = "std::env::temp_dir()"
    let v728 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr () v727 
    let v729 : string = "$0.display()"
    let v730 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v728 v729 
    let v731 : bool = true
    let mutable _v731 : std_string_String option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v732 : string = "format!(\"{}\", $0)"
    let v733 : std_string_String = Fable.Core.RustInterop.emitRustExpr v730 v732 
    v733 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v734 : string = "format!(\"{}\", $0)"
    let v735 : std_string_String = Fable.Core.RustInterop.emitRustExpr v730 v734 
    v735 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v736 : string = "format!(\"{}\", $0)"
    let v737 : std_string_String = Fable.Core.RustInterop.emitRustExpr v730 v736 
    v737 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v738 : std_string_String = null |> unbox<std_string_String>
    v738 
    #endif
#if FABLE_COMPILER_PYTHON
    let v739 : std_string_String = null |> unbox<std_string_String>
    v739 
    #endif
#else
    let v740 : std_string_String = null |> unbox<std_string_String>
    v740 
    #endif
    |> fun x -> _v731 <- Some x
    let v741 : std_string_String = match _v731 with Some x -> x | None -> failwith "base.run_target / _v731=None"
    let v742 : string = "fable_library_rust::String_::fromString($0)"
    let v743 : string = Fable.Core.RustInterop.emitRustExpr v741 v742 
    v743 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v744 : US4 = US4_1
    let v745 : US5 = US5_0(v744)
    let v746 : string = $"file_system.get_temp_path / target: {v745}"
    let v747 : string = failwith<string> v746
    v747 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v748 : string = null |> unbox<string>
    v748 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v749 : US4 = US4_0
    let v750 : US5 = US5_2(v749)
    let v751 : string = $"file_system.get_temp_path / target: {v750}"
    let v752 : string = failwith<string> v751
    v752 
    #endif
#if FABLE_COMPILER_PYTHON
    let v753 : US4 = US4_0
    let v754 : US5 = US5_3(v753)
    let v755 : string = $"file_system.get_temp_path / target: {v754}"
    let v756 : string = failwith<string> v755
    v756 
    #endif
#else
    let v757 : (unit -> string) = System.IO.Path.GetTempPath
    let v758 : string = v757 ()
    v758 
    #endif
    |> fun x -> _v726 <- Some x
    let v759 : string = match _v726 with Some x -> x | None -> failwith "base.run_target / _v726=None"
    let v760 : string = method27()
    let v761 : string = method28(v759, v760)
    let v762 : string = method31()
    let v763 : string = method28(v761, v762)
    let v764 : (System.Guid -> string) = _.ToString()
    let v765 : string = v764 v641
    let v766 : string = method28(v763, v765)
    v766 
    #endif
#if FABLE_COMPILER_PYTHON
    let v767 : bool = true
    let mutable _v767 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v768 : string = "std::env::temp_dir()"
    let v769 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr () v768 
    let v770 : string = "$0.display()"
    let v771 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v769 v770 
    let v772 : bool = true
    let mutable _v772 : std_string_String option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v773 : string = "format!(\"{}\", $0)"
    let v774 : std_string_String = Fable.Core.RustInterop.emitRustExpr v771 v773 
    v774 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v775 : string = "format!(\"{}\", $0)"
    let v776 : std_string_String = Fable.Core.RustInterop.emitRustExpr v771 v775 
    v776 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v777 : string = "format!(\"{}\", $0)"
    let v778 : std_string_String = Fable.Core.RustInterop.emitRustExpr v771 v777 
    v778 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v779 : std_string_String = null |> unbox<std_string_String>
    v779 
    #endif
#if FABLE_COMPILER_PYTHON
    let v780 : std_string_String = null |> unbox<std_string_String>
    v780 
    #endif
#else
    let v781 : std_string_String = null |> unbox<std_string_String>
    v781 
    #endif
    |> fun x -> _v772 <- Some x
    let v782 : std_string_String = match _v772 with Some x -> x | None -> failwith "base.run_target / _v772=None"
    let v783 : string = "fable_library_rust::String_::fromString($0)"
    let v784 : string = Fable.Core.RustInterop.emitRustExpr v782 v783 
    v784 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v785 : US4 = US4_1
    let v786 : US5 = US5_0(v785)
    let v787 : string = $"file_system.get_temp_path / target: {v786}"
    let v788 : string = failwith<string> v787
    v788 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v789 : string = null |> unbox<string>
    v789 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v790 : US4 = US4_0
    let v791 : US5 = US5_2(v790)
    let v792 : string = $"file_system.get_temp_path / target: {v791}"
    let v793 : string = failwith<string> v792
    v793 
    #endif
#if FABLE_COMPILER_PYTHON
    let v794 : US4 = US4_0
    let v795 : US5 = US5_3(v794)
    let v796 : string = $"file_system.get_temp_path / target: {v795}"
    let v797 : string = failwith<string> v796
    v797 
    #endif
#else
    let v798 : (unit -> string) = System.IO.Path.GetTempPath
    let v799 : string = v798 ()
    v799 
    #endif
    |> fun x -> _v767 <- Some x
    let v800 : string = match _v767 with Some x -> x | None -> failwith "base.run_target / _v767=None"
    let v801 : string = method27()
    let v802 : string = method28(v800, v801)
    let v803 : string = method31()
    let v804 : string = method28(v802, v803)
    let v805 : (System.Guid -> string) = _.ToString()
    let v806 : string = v805 v641
    let v807 : string = method28(v804, v806)
    v807 
    #endif
#else
    let v808 : bool = true
    let mutable _v808 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v809 : string = "std::env::temp_dir()"
    let v810 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr () v809 
    let v811 : string = "$0.display()"
    let v812 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v810 v811 
    let v813 : bool = true
    let mutable _v813 : std_string_String option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v814 : string = "format!(\"{}\", $0)"
    let v815 : std_string_String = Fable.Core.RustInterop.emitRustExpr v812 v814 
    v815 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v816 : string = "format!(\"{}\", $0)"
    let v817 : std_string_String = Fable.Core.RustInterop.emitRustExpr v812 v816 
    v817 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v818 : string = "format!(\"{}\", $0)"
    let v819 : std_string_String = Fable.Core.RustInterop.emitRustExpr v812 v818 
    v819 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v820 : std_string_String = null |> unbox<std_string_String>
    v820 
    #endif
#if FABLE_COMPILER_PYTHON
    let v821 : std_string_String = null |> unbox<std_string_String>
    v821 
    #endif
#else
    let v822 : std_string_String = null |> unbox<std_string_String>
    v822 
    #endif
    |> fun x -> _v813 <- Some x
    let v823 : std_string_String = match _v813 with Some x -> x | None -> failwith "base.run_target / _v813=None"
    let v824 : string = "fable_library_rust::String_::fromString($0)"
    let v825 : string = Fable.Core.RustInterop.emitRustExpr v823 v824 
    v825 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v826 : US4 = US4_1
    let v827 : US5 = US5_0(v826)
    let v828 : string = $"file_system.get_temp_path / target: {v827}"
    let v829 : string = failwith<string> v828
    v829 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v830 : string = null |> unbox<string>
    v830 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v831 : US4 = US4_0
    let v832 : US5 = US5_2(v831)
    let v833 : string = $"file_system.get_temp_path / target: {v832}"
    let v834 : string = failwith<string> v833
    v834 
    #endif
#if FABLE_COMPILER_PYTHON
    let v835 : US4 = US4_0
    let v836 : US5 = US5_3(v835)
    let v837 : string = $"file_system.get_temp_path / target: {v836}"
    let v838 : string = failwith<string> v837
    v838 
    #endif
#else
    let v839 : (unit -> string) = System.IO.Path.GetTempPath
    let v840 : string = v839 ()
    v840 
    #endif
    |> fun x -> _v808 <- Some x
    let v841 : string = match _v808 with Some x -> x | None -> failwith "base.run_target / _v808=None"
    let v842 : string = method27()
    let v843 : string = method28(v841, v842)
    let v844 : string = method31()
    let v845 : string = method28(v843, v844)
    let v846 : (System.Guid -> string) = _.ToString()
    let v847 : string = v846 v641
    let v848 : string = method28(v845, v847)
    v848 
    #endif
    |> fun x -> _v642 <- Some x
    let v849 : string = match _v642 with Some x -> x | None -> failwith "base.run_target / _v642=None"
    v849 
    #endif
#else
    let v850 : System.DateTime = System.DateTime.Now
    let v851 : (unit -> System.Guid) = System.Guid.NewGuid
    let v852 : System.Guid = v851 ()
    let v853 : System.Guid = method21(v852, v850)
    let v854 : bool = true
    let mutable _v854 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v855 : bool = true
    let mutable _v855 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v856 : string = "std::env::temp_dir()"
    let v857 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr () v856 
    let v858 : string = "$0.display()"
    let v859 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v857 v858 
    let v860 : bool = true
    let mutable _v860 : std_string_String option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v861 : string = "format!(\"{}\", $0)"
    let v862 : std_string_String = Fable.Core.RustInterop.emitRustExpr v859 v861 
    v862 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v863 : string = "format!(\"{}\", $0)"
    let v864 : std_string_String = Fable.Core.RustInterop.emitRustExpr v859 v863 
    v864 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v865 : string = "format!(\"{}\", $0)"
    let v866 : std_string_String = Fable.Core.RustInterop.emitRustExpr v859 v865 
    v866 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v867 : std_string_String = null |> unbox<std_string_String>
    v867 
    #endif
#if FABLE_COMPILER_PYTHON
    let v868 : std_string_String = null |> unbox<std_string_String>
    v868 
    #endif
#else
    let v869 : std_string_String = null |> unbox<std_string_String>
    v869 
    #endif
    |> fun x -> _v860 <- Some x
    let v870 : std_string_String = match _v860 with Some x -> x | None -> failwith "base.run_target / _v860=None"
    let v871 : string = "fable_library_rust::String_::fromString($0)"
    let v872 : string = Fable.Core.RustInterop.emitRustExpr v870 v871 
    v872 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v873 : US4 = US4_1
    let v874 : US5 = US5_0(v873)
    let v875 : string = $"file_system.get_temp_path / target: {v874}"
    let v876 : string = failwith<string> v875
    v876 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v877 : string = null |> unbox<string>
    v877 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v878 : US4 = US4_0
    let v879 : US5 = US5_2(v878)
    let v880 : string = $"file_system.get_temp_path / target: {v879}"
    let v881 : string = failwith<string> v880
    v881 
    #endif
#if FABLE_COMPILER_PYTHON
    let v882 : US4 = US4_0
    let v883 : US5 = US5_3(v882)
    let v884 : string = $"file_system.get_temp_path / target: {v883}"
    let v885 : string = failwith<string> v884
    v885 
    #endif
#else
    let v886 : (unit -> string) = System.IO.Path.GetTempPath
    let v887 : string = v886 ()
    v887 
    #endif
    |> fun x -> _v855 <- Some x
    let v888 : string = match _v855 with Some x -> x | None -> failwith "base.run_target / _v855=None"
    let v889 : string = method27()
    let v890 : string = method28(v888, v889)
    let v891 : string = method31()
    let v892 : string = method28(v890, v891)
    let v893 : (System.Guid -> string) = _.ToString()
    let v894 : string = v893 v853
    let v895 : string = method28(v892, v894)
    v895 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v896 : bool = true
    let mutable _v896 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v897 : string = "std::env::temp_dir()"
    let v898 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr () v897 
    let v899 : string = "$0.display()"
    let v900 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v898 v899 
    let v901 : bool = true
    let mutable _v901 : std_string_String option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v902 : string = "format!(\"{}\", $0)"
    let v903 : std_string_String = Fable.Core.RustInterop.emitRustExpr v900 v902 
    v903 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v904 : string = "format!(\"{}\", $0)"
    let v905 : std_string_String = Fable.Core.RustInterop.emitRustExpr v900 v904 
    v905 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v906 : string = "format!(\"{}\", $0)"
    let v907 : std_string_String = Fable.Core.RustInterop.emitRustExpr v900 v906 
    v907 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v908 : std_string_String = null |> unbox<std_string_String>
    v908 
    #endif
#if FABLE_COMPILER_PYTHON
    let v909 : std_string_String = null |> unbox<std_string_String>
    v909 
    #endif
#else
    let v910 : std_string_String = null |> unbox<std_string_String>
    v910 
    #endif
    |> fun x -> _v901 <- Some x
    let v911 : std_string_String = match _v901 with Some x -> x | None -> failwith "base.run_target / _v901=None"
    let v912 : string = "fable_library_rust::String_::fromString($0)"
    let v913 : string = Fable.Core.RustInterop.emitRustExpr v911 v912 
    v913 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v914 : US4 = US4_1
    let v915 : US5 = US5_0(v914)
    let v916 : string = $"file_system.get_temp_path / target: {v915}"
    let v917 : string = failwith<string> v916
    v917 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v918 : string = null |> unbox<string>
    v918 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v919 : US4 = US4_0
    let v920 : US5 = US5_2(v919)
    let v921 : string = $"file_system.get_temp_path / target: {v920}"
    let v922 : string = failwith<string> v921
    v922 
    #endif
#if FABLE_COMPILER_PYTHON
    let v923 : US4 = US4_0
    let v924 : US5 = US5_3(v923)
    let v925 : string = $"file_system.get_temp_path / target: {v924}"
    let v926 : string = failwith<string> v925
    v926 
    #endif
#else
    let v927 : (unit -> string) = System.IO.Path.GetTempPath
    let v928 : string = v927 ()
    v928 
    #endif
    |> fun x -> _v896 <- Some x
    let v929 : string = match _v896 with Some x -> x | None -> failwith "base.run_target / _v896=None"
    let v930 : string = method27()
    let v931 : string = method28(v929, v930)
    let v932 : string = method31()
    let v933 : string = method28(v931, v932)
    let v934 : (System.Guid -> string) = _.ToString()
    let v935 : string = v934 v853
    let v936 : string = method28(v933, v935)
    v936 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v937 : string = null |> unbox<string>
    v937 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v938 : bool = true
    let mutable _v938 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v939 : string = "std::env::temp_dir()"
    let v940 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr () v939 
    let v941 : string = "$0.display()"
    let v942 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v940 v941 
    let v943 : bool = true
    let mutable _v943 : std_string_String option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v944 : string = "format!(\"{}\", $0)"
    let v945 : std_string_String = Fable.Core.RustInterop.emitRustExpr v942 v944 
    v945 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v946 : string = "format!(\"{}\", $0)"
    let v947 : std_string_String = Fable.Core.RustInterop.emitRustExpr v942 v946 
    v947 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v948 : string = "format!(\"{}\", $0)"
    let v949 : std_string_String = Fable.Core.RustInterop.emitRustExpr v942 v948 
    v949 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v950 : std_string_String = null |> unbox<std_string_String>
    v950 
    #endif
#if FABLE_COMPILER_PYTHON
    let v951 : std_string_String = null |> unbox<std_string_String>
    v951 
    #endif
#else
    let v952 : std_string_String = null |> unbox<std_string_String>
    v952 
    #endif
    |> fun x -> _v943 <- Some x
    let v953 : std_string_String = match _v943 with Some x -> x | None -> failwith "base.run_target / _v943=None"
    let v954 : string = "fable_library_rust::String_::fromString($0)"
    let v955 : string = Fable.Core.RustInterop.emitRustExpr v953 v954 
    v955 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v956 : US4 = US4_1
    let v957 : US5 = US5_0(v956)
    let v958 : string = $"file_system.get_temp_path / target: {v957}"
    let v959 : string = failwith<string> v958
    v959 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v960 : string = null |> unbox<string>
    v960 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v961 : US4 = US4_0
    let v962 : US5 = US5_2(v961)
    let v963 : string = $"file_system.get_temp_path / target: {v962}"
    let v964 : string = failwith<string> v963
    v964 
    #endif
#if FABLE_COMPILER_PYTHON
    let v965 : US4 = US4_0
    let v966 : US5 = US5_3(v965)
    let v967 : string = $"file_system.get_temp_path / target: {v966}"
    let v968 : string = failwith<string> v967
    v968 
    #endif
#else
    let v969 : (unit -> string) = System.IO.Path.GetTempPath
    let v970 : string = v969 ()
    v970 
    #endif
    |> fun x -> _v938 <- Some x
    let v971 : string = match _v938 with Some x -> x | None -> failwith "base.run_target / _v938=None"
    let v972 : string = method27()
    let v973 : string = method28(v971, v972)
    let v974 : string = method31()
    let v975 : string = method28(v973, v974)
    let v976 : (System.Guid -> string) = _.ToString()
    let v977 : string = v976 v853
    let v978 : string = method28(v975, v977)
    v978 
    #endif
#if FABLE_COMPILER_PYTHON
    let v979 : bool = true
    let mutable _v979 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v980 : string = "std::env::temp_dir()"
    let v981 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr () v980 
    let v982 : string = "$0.display()"
    let v983 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v981 v982 
    let v984 : bool = true
    let mutable _v984 : std_string_String option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v985 : string = "format!(\"{}\", $0)"
    let v986 : std_string_String = Fable.Core.RustInterop.emitRustExpr v983 v985 
    v986 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v987 : string = "format!(\"{}\", $0)"
    let v988 : std_string_String = Fable.Core.RustInterop.emitRustExpr v983 v987 
    v988 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v989 : string = "format!(\"{}\", $0)"
    let v990 : std_string_String = Fable.Core.RustInterop.emitRustExpr v983 v989 
    v990 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v991 : std_string_String = null |> unbox<std_string_String>
    v991 
    #endif
#if FABLE_COMPILER_PYTHON
    let v992 : std_string_String = null |> unbox<std_string_String>
    v992 
    #endif
#else
    let v993 : std_string_String = null |> unbox<std_string_String>
    v993 
    #endif
    |> fun x -> _v984 <- Some x
    let v994 : std_string_String = match _v984 with Some x -> x | None -> failwith "base.run_target / _v984=None"
    let v995 : string = "fable_library_rust::String_::fromString($0)"
    let v996 : string = Fable.Core.RustInterop.emitRustExpr v994 v995 
    v996 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v997 : US4 = US4_1
    let v998 : US5 = US5_0(v997)
    let v999 : string = $"file_system.get_temp_path / target: {v998}"
    let v1000 : string = failwith<string> v999
    v1000 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1001 : string = null |> unbox<string>
    v1001 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1002 : US4 = US4_0
    let v1003 : US5 = US5_2(v1002)
    let v1004 : string = $"file_system.get_temp_path / target: {v1003}"
    let v1005 : string = failwith<string> v1004
    v1005 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1006 : US4 = US4_0
    let v1007 : US5 = US5_3(v1006)
    let v1008 : string = $"file_system.get_temp_path / target: {v1007}"
    let v1009 : string = failwith<string> v1008
    v1009 
    #endif
#else
    let v1010 : (unit -> string) = System.IO.Path.GetTempPath
    let v1011 : string = v1010 ()
    v1011 
    #endif
    |> fun x -> _v979 <- Some x
    let v1012 : string = match _v979 with Some x -> x | None -> failwith "base.run_target / _v979=None"
    let v1013 : string = method27()
    let v1014 : string = method28(v1012, v1013)
    let v1015 : string = method31()
    let v1016 : string = method28(v1014, v1015)
    let v1017 : (System.Guid -> string) = _.ToString()
    let v1018 : string = v1017 v853
    let v1019 : string = method28(v1016, v1018)
    v1019 
    #endif
#else
    let v1020 : bool = true
    let mutable _v1020 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1021 : string = "std::env::temp_dir()"
    let v1022 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr () v1021 
    let v1023 : string = "$0.display()"
    let v1024 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v1022 v1023 
    let v1025 : bool = true
    let mutable _v1025 : std_string_String option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1026 : string = "format!(\"{}\", $0)"
    let v1027 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1024 v1026 
    v1027 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1028 : string = "format!(\"{}\", $0)"
    let v1029 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1024 v1028 
    v1029 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1030 : string = "format!(\"{}\", $0)"
    let v1031 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1024 v1030 
    v1031 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1032 : std_string_String = null |> unbox<std_string_String>
    v1032 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1033 : std_string_String = null |> unbox<std_string_String>
    v1033 
    #endif
#else
    let v1034 : std_string_String = null |> unbox<std_string_String>
    v1034 
    #endif
    |> fun x -> _v1025 <- Some x
    let v1035 : std_string_String = match _v1025 with Some x -> x | None -> failwith "base.run_target / _v1025=None"
    let v1036 : string = "fable_library_rust::String_::fromString($0)"
    let v1037 : string = Fable.Core.RustInterop.emitRustExpr v1035 v1036 
    v1037 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1038 : US4 = US4_1
    let v1039 : US5 = US5_0(v1038)
    let v1040 : string = $"file_system.get_temp_path / target: {v1039}"
    let v1041 : string = failwith<string> v1040
    v1041 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1042 : string = null |> unbox<string>
    v1042 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1043 : US4 = US4_0
    let v1044 : US5 = US5_2(v1043)
    let v1045 : string = $"file_system.get_temp_path / target: {v1044}"
    let v1046 : string = failwith<string> v1045
    v1046 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1047 : US4 = US4_0
    let v1048 : US5 = US5_3(v1047)
    let v1049 : string = $"file_system.get_temp_path / target: {v1048}"
    let v1050 : string = failwith<string> v1049
    v1050 
    #endif
#else
    let v1051 : (unit -> string) = System.IO.Path.GetTempPath
    let v1052 : string = v1051 ()
    v1052 
    #endif
    |> fun x -> _v1020 <- Some x
    let v1053 : string = match _v1020 with Some x -> x | None -> failwith "base.run_target / _v1020=None"
    let v1054 : string = method27()
    let v1055 : string = method28(v1053, v1054)
    let v1056 : string = method31()
    let v1057 : string = method28(v1055, v1056)
    let v1058 : (System.Guid -> string) = _.ToString()
    let v1059 : string = v1058 v853
    let v1060 : string = method28(v1057, v1059)
    v1060 
    #endif
    |> fun x -> _v854 <- Some x
    let v1061 : string = match _v854 with Some x -> x | None -> failwith "base.run_target / _v854=None"
    v1061 
    #endif
    |> fun x -> _v0 <- Some x
    let v1062 : string = match _v0 with Some x -> x | None -> failwith "base.run_target / _v0=None"
    v1062
and method34 (v0 : string) : string =
    v0
and closure37 () (v0 : std_io_Error) : std_string_String =
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
and method35 () : (std_io_Error -> std_string_String) =
    closure37()
and closure38 () () : US12 =
    US12_0
and closure39 () (v0 : std_string_String) : US12 =
    US12_1(v0)
and closure40 () () : string =
    let v0 : string = "file_system.create_dir"
    v0
and closure41 (v0 : string, v1 : std_string_String) () : string =
    let v2 : (unit -> string) = closure6()
    let v3 : string = $"dir: {v0} / error: {v1} / {v2 ()}"
    v3
and closure42 () () : string =
    let v0 : string = "file_system.create_dir"
    v0
and closure43 (v0 : string) () : string =
    let v1 : (unit -> string) = closure6()
    let v2 : string = $"dir: {v0} / {v1 ()}"
    v2
and closure44 (v0 : string) () : unit =
    let v1 : bool = true
    method5(v1, v0)
and method36 (v0 : string) : (unit -> unit) =
    closure44(v0)
and method37 (v0 : string) : (unit -> unit) =
    closure44(v0)
and closure45 () () : string =
    let v0 : string = "file_system.create_dir"
    v0
and closure46 (v0 : string, v1 : string) () : string =
    let v2 : (unit -> string) = closure6()
    let v3 : string = $"dir: {v0} / result: {v1} {v2 ()}"
    v3
and closure47 (v0 : string) () : unit =
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
and method38 (v0 : string) : (unit -> unit) =
    closure47(v0)
and method39 (v0 : string) : (unit -> unit) =
    closure47(v0)
and method33 (v0 : string) : System.IDisposable =
    let v1 : bool = true
    let mutable _v1 : System.IDisposable option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = method34(v0)
    let v3 : string = "std::fs::create_dir_all(&*$0)"
    let v4 : Result<unit, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v2 v3 
    let v5 : (std_io_Error -> std_string_String) = method35()
    let v6 : string = "$0.map_err(|x| $1(x))"
    let v7 : Result<unit, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v4, v5) v6 
    let v8 : (unit -> US12) = closure38()
    let v9 : (std_string_String -> US12) = closure39()
    let v10 : US12 = match v7 with Ok () -> v8 () | Error x -> v9 x
    match v10 with
    | US12_1(v14) -> (* Error *)
        let v15 : US0 = US0_4
        let v16 : (unit -> string) = closure40()
        let v17 : (unit -> string) = closure41(v2, v14)
        method9(v15, v16, v17)
    | US12_0 -> (* Ok *)
        let v11 : US0 = US0_0
        let v12 : (unit -> string) = closure42()
        let v13 : (unit -> string) = closure43(v2)
        method9(v11, v12, v13)
    let v18 : bool = true
    let mutable _v18 : System.IDisposable option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v19 : (unit -> unit) = method36(v2)
    let v20 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v19 "$0()" )
    v20 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v21 : (unit -> unit) = method36(v2)
    let v22 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v21 "$0()" )
    v22 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v23 : (unit -> unit) = method36(v2)
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
    let v27 : (unit -> unit) = method37(v2)
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
        let v61 : (unit -> string) = closure45()
        let v62 : (unit -> string) = closure46(v0, v59)
        method9(v60, v61, v62)
    let v63 : bool = true
    let mutable _v63 : System.IDisposable option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v64 : (unit -> unit) = method38(v0)
    let v65 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v64 "$0()" )
    v65 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v66 : (unit -> unit) = method38(v0)
    let v67 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v66 "$0()" )
    v67 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v68 : (unit -> unit) = method38(v0)
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
    let v72 : (unit -> unit) = method39(v0)
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
        let v104 : (unit -> string) = closure45()
        let v105 : (unit -> string) = closure46(v0, v102)
        method9(v103, v104, v105)
    let v106 : bool = true
    let mutable _v106 : System.IDisposable option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v107 : (unit -> unit) = method38(v0)
    let v108 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v107 "$0()" )
    v108 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v109 : (unit -> unit) = method38(v0)
    let v110 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v109 "$0()" )
    v110 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v111 : (unit -> unit) = method38(v0)
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
    let v115 : (unit -> unit) = method39(v0)
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
        let v147 : (unit -> string) = closure45()
        let v148 : (unit -> string) = closure46(v0, v145)
        method9(v146, v147, v148)
    let v149 : bool = true
    let mutable _v149 : System.IDisposable option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v150 : (unit -> unit) = method38(v0)
    let v151 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v150 "$0()" )
    v151 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v152 : (unit -> unit) = method38(v0)
    let v153 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v152 "$0()" )
    v153 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v154 : (unit -> unit) = method38(v0)
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
    let v158 : (unit -> unit) = method39(v0)
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
and closure36 () () : struct (string * System.IDisposable) =
    let v0 : bool = true
    let mutable _v0 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1 : System.DateTime = System.DateTime.Now
    let v2 : (unit -> System.Guid) = System.Guid.NewGuid
    let v3 : System.Guid = v2 ()
    let v4 : System.Guid = method21(v3, v1)
    let v5 : bool = true
    let mutable _v5 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v6 : bool = true
    let mutable _v6 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v7 : string = "std::env::temp_dir()"
    let v8 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr () v7 
    let v9 : string = "$0.display()"
    let v10 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v8 v9 
    let v11 : bool = true
    let mutable _v11 : std_string_String option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v12 : string = "format!(\"{}\", $0)"
    let v13 : std_string_String = Fable.Core.RustInterop.emitRustExpr v10 v12 
    v13 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v14 : string = "format!(\"{}\", $0)"
    let v15 : std_string_String = Fable.Core.RustInterop.emitRustExpr v10 v14 
    v15 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v16 : string = "format!(\"{}\", $0)"
    let v17 : std_string_String = Fable.Core.RustInterop.emitRustExpr v10 v16 
    v17 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v18 : std_string_String = null |> unbox<std_string_String>
    v18 
    #endif
#if FABLE_COMPILER_PYTHON
    let v19 : std_string_String = null |> unbox<std_string_String>
    v19 
    #endif
#else
    let v20 : std_string_String = null |> unbox<std_string_String>
    v20 
    #endif
    |> fun x -> _v11 <- Some x
    let v21 : std_string_String = match _v11 with Some x -> x | None -> failwith "base.run_target / _v11=None"
    let v22 : string = "fable_library_rust::String_::fromString($0)"
    let v23 : string = Fable.Core.RustInterop.emitRustExpr v21 v22 
    v23 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v24 : US4 = US4_1
    let v25 : US5 = US5_0(v24)
    let v26 : string = $"file_system.get_temp_path / target: {v25}"
    let v27 : string = failwith<string> v26
    v27 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v28 : string = null |> unbox<string>
    v28 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v29 : US4 = US4_0
    let v30 : US5 = US5_2(v29)
    let v31 : string = $"file_system.get_temp_path / target: {v30}"
    let v32 : string = failwith<string> v31
    v32 
    #endif
#if FABLE_COMPILER_PYTHON
    let v33 : US4 = US4_0
    let v34 : US5 = US5_3(v33)
    let v35 : string = $"file_system.get_temp_path / target: {v34}"
    let v36 : string = failwith<string> v35
    v36 
    #endif
#else
    let v37 : (unit -> string) = System.IO.Path.GetTempPath
    let v38 : string = v37 ()
    v38 
    #endif
    |> fun x -> _v6 <- Some x
    let v39 : string = match _v6 with Some x -> x | None -> failwith "base.run_target / _v6=None"
    let v40 : string = method27()
    let v41 : string = method28(v39, v40)
    let v42 : string = method31()
    let v43 : string = method28(v41, v42)
    let v44 : (System.Guid -> string) = _.ToString()
    let v45 : string = v44 v4
    let v46 : string = method28(v43, v45)
    v46 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v47 : bool = true
    let mutable _v47 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v48 : string = "std::env::temp_dir()"
    let v49 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr () v48 
    let v50 : string = "$0.display()"
    let v51 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v49 v50 
    let v52 : bool = true
    let mutable _v52 : std_string_String option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v53 : string = "format!(\"{}\", $0)"
    let v54 : std_string_String = Fable.Core.RustInterop.emitRustExpr v51 v53 
    v54 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v55 : string = "format!(\"{}\", $0)"
    let v56 : std_string_String = Fable.Core.RustInterop.emitRustExpr v51 v55 
    v56 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v57 : string = "format!(\"{}\", $0)"
    let v58 : std_string_String = Fable.Core.RustInterop.emitRustExpr v51 v57 
    v58 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v59 : std_string_String = null |> unbox<std_string_String>
    v59 
    #endif
#if FABLE_COMPILER_PYTHON
    let v60 : std_string_String = null |> unbox<std_string_String>
    v60 
    #endif
#else
    let v61 : std_string_String = null |> unbox<std_string_String>
    v61 
    #endif
    |> fun x -> _v52 <- Some x
    let v62 : std_string_String = match _v52 with Some x -> x | None -> failwith "base.run_target / _v52=None"
    let v63 : string = "fable_library_rust::String_::fromString($0)"
    let v64 : string = Fable.Core.RustInterop.emitRustExpr v62 v63 
    v64 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v65 : US4 = US4_1
    let v66 : US5 = US5_0(v65)
    let v67 : string = $"file_system.get_temp_path / target: {v66}"
    let v68 : string = failwith<string> v67
    v68 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v69 : string = null |> unbox<string>
    v69 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v70 : US4 = US4_0
    let v71 : US5 = US5_2(v70)
    let v72 : string = $"file_system.get_temp_path / target: {v71}"
    let v73 : string = failwith<string> v72
    v73 
    #endif
#if FABLE_COMPILER_PYTHON
    let v74 : US4 = US4_0
    let v75 : US5 = US5_3(v74)
    let v76 : string = $"file_system.get_temp_path / target: {v75}"
    let v77 : string = failwith<string> v76
    v77 
    #endif
#else
    let v78 : (unit -> string) = System.IO.Path.GetTempPath
    let v79 : string = v78 ()
    v79 
    #endif
    |> fun x -> _v47 <- Some x
    let v80 : string = match _v47 with Some x -> x | None -> failwith "base.run_target / _v47=None"
    let v81 : string = method27()
    let v82 : string = method28(v80, v81)
    let v83 : string = method31()
    let v84 : string = method28(v82, v83)
    let v85 : (System.Guid -> string) = _.ToString()
    let v86 : string = v85 v4
    let v87 : string = method28(v84, v86)
    v87 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v88 : string = null |> unbox<string>
    v88 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v89 : bool = true
    let mutable _v89 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v90 : string = "std::env::temp_dir()"
    let v91 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr () v90 
    let v92 : string = "$0.display()"
    let v93 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v91 v92 
    let v94 : bool = true
    let mutable _v94 : std_string_String option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v95 : string = "format!(\"{}\", $0)"
    let v96 : std_string_String = Fable.Core.RustInterop.emitRustExpr v93 v95 
    v96 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v97 : string = "format!(\"{}\", $0)"
    let v98 : std_string_String = Fable.Core.RustInterop.emitRustExpr v93 v97 
    v98 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v99 : string = "format!(\"{}\", $0)"
    let v100 : std_string_String = Fable.Core.RustInterop.emitRustExpr v93 v99 
    v100 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v101 : std_string_String = null |> unbox<std_string_String>
    v101 
    #endif
#if FABLE_COMPILER_PYTHON
    let v102 : std_string_String = null |> unbox<std_string_String>
    v102 
    #endif
#else
    let v103 : std_string_String = null |> unbox<std_string_String>
    v103 
    #endif
    |> fun x -> _v94 <- Some x
    let v104 : std_string_String = match _v94 with Some x -> x | None -> failwith "base.run_target / _v94=None"
    let v105 : string = "fable_library_rust::String_::fromString($0)"
    let v106 : string = Fable.Core.RustInterop.emitRustExpr v104 v105 
    v106 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v107 : US4 = US4_1
    let v108 : US5 = US5_0(v107)
    let v109 : string = $"file_system.get_temp_path / target: {v108}"
    let v110 : string = failwith<string> v109
    v110 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v111 : string = null |> unbox<string>
    v111 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v112 : US4 = US4_0
    let v113 : US5 = US5_2(v112)
    let v114 : string = $"file_system.get_temp_path / target: {v113}"
    let v115 : string = failwith<string> v114
    v115 
    #endif
#if FABLE_COMPILER_PYTHON
    let v116 : US4 = US4_0
    let v117 : US5 = US5_3(v116)
    let v118 : string = $"file_system.get_temp_path / target: {v117}"
    let v119 : string = failwith<string> v118
    v119 
    #endif
#else
    let v120 : (unit -> string) = System.IO.Path.GetTempPath
    let v121 : string = v120 ()
    v121 
    #endif
    |> fun x -> _v89 <- Some x
    let v122 : string = match _v89 with Some x -> x | None -> failwith "base.run_target / _v89=None"
    let v123 : string = method27()
    let v124 : string = method28(v122, v123)
    let v125 : string = method31()
    let v126 : string = method28(v124, v125)
    let v127 : (System.Guid -> string) = _.ToString()
    let v128 : string = v127 v4
    let v129 : string = method28(v126, v128)
    v129 
    #endif
#if FABLE_COMPILER_PYTHON
    let v130 : bool = true
    let mutable _v130 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v131 : string = "std::env::temp_dir()"
    let v132 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr () v131 
    let v133 : string = "$0.display()"
    let v134 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v132 v133 
    let v135 : bool = true
    let mutable _v135 : std_string_String option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v136 : string = "format!(\"{}\", $0)"
    let v137 : std_string_String = Fable.Core.RustInterop.emitRustExpr v134 v136 
    v137 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v138 : string = "format!(\"{}\", $0)"
    let v139 : std_string_String = Fable.Core.RustInterop.emitRustExpr v134 v138 
    v139 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v140 : string = "format!(\"{}\", $0)"
    let v141 : std_string_String = Fable.Core.RustInterop.emitRustExpr v134 v140 
    v141 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v142 : std_string_String = null |> unbox<std_string_String>
    v142 
    #endif
#if FABLE_COMPILER_PYTHON
    let v143 : std_string_String = null |> unbox<std_string_String>
    v143 
    #endif
#else
    let v144 : std_string_String = null |> unbox<std_string_String>
    v144 
    #endif
    |> fun x -> _v135 <- Some x
    let v145 : std_string_String = match _v135 with Some x -> x | None -> failwith "base.run_target / _v135=None"
    let v146 : string = "fable_library_rust::String_::fromString($0)"
    let v147 : string = Fable.Core.RustInterop.emitRustExpr v145 v146 
    v147 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v148 : US4 = US4_1
    let v149 : US5 = US5_0(v148)
    let v150 : string = $"file_system.get_temp_path / target: {v149}"
    let v151 : string = failwith<string> v150
    v151 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v152 : string = null |> unbox<string>
    v152 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v153 : US4 = US4_0
    let v154 : US5 = US5_2(v153)
    let v155 : string = $"file_system.get_temp_path / target: {v154}"
    let v156 : string = failwith<string> v155
    v156 
    #endif
#if FABLE_COMPILER_PYTHON
    let v157 : US4 = US4_0
    let v158 : US5 = US5_3(v157)
    let v159 : string = $"file_system.get_temp_path / target: {v158}"
    let v160 : string = failwith<string> v159
    v160 
    #endif
#else
    let v161 : (unit -> string) = System.IO.Path.GetTempPath
    let v162 : string = v161 ()
    v162 
    #endif
    |> fun x -> _v130 <- Some x
    let v163 : string = match _v130 with Some x -> x | None -> failwith "base.run_target / _v130=None"
    let v164 : string = method27()
    let v165 : string = method28(v163, v164)
    let v166 : string = method31()
    let v167 : string = method28(v165, v166)
    let v168 : (System.Guid -> string) = _.ToString()
    let v169 : string = v168 v4
    let v170 : string = method28(v167, v169)
    v170 
    #endif
#else
    let v171 : bool = true
    let mutable _v171 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v172 : string = "std::env::temp_dir()"
    let v173 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr () v172 
    let v174 : string = "$0.display()"
    let v175 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v173 v174 
    let v176 : bool = true
    let mutable _v176 : std_string_String option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v177 : string = "format!(\"{}\", $0)"
    let v178 : std_string_String = Fable.Core.RustInterop.emitRustExpr v175 v177 
    v178 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v179 : string = "format!(\"{}\", $0)"
    let v180 : std_string_String = Fable.Core.RustInterop.emitRustExpr v175 v179 
    v180 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v181 : string = "format!(\"{}\", $0)"
    let v182 : std_string_String = Fable.Core.RustInterop.emitRustExpr v175 v181 
    v182 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v183 : std_string_String = null |> unbox<std_string_String>
    v183 
    #endif
#if FABLE_COMPILER_PYTHON
    let v184 : std_string_String = null |> unbox<std_string_String>
    v184 
    #endif
#else
    let v185 : std_string_String = null |> unbox<std_string_String>
    v185 
    #endif
    |> fun x -> _v176 <- Some x
    let v186 : std_string_String = match _v176 with Some x -> x | None -> failwith "base.run_target / _v176=None"
    let v187 : string = "fable_library_rust::String_::fromString($0)"
    let v188 : string = Fable.Core.RustInterop.emitRustExpr v186 v187 
    v188 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v189 : US4 = US4_1
    let v190 : US5 = US5_0(v189)
    let v191 : string = $"file_system.get_temp_path / target: {v190}"
    let v192 : string = failwith<string> v191
    v192 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v193 : string = null |> unbox<string>
    v193 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v194 : US4 = US4_0
    let v195 : US5 = US5_2(v194)
    let v196 : string = $"file_system.get_temp_path / target: {v195}"
    let v197 : string = failwith<string> v196
    v197 
    #endif
#if FABLE_COMPILER_PYTHON
    let v198 : US4 = US4_0
    let v199 : US5 = US5_3(v198)
    let v200 : string = $"file_system.get_temp_path / target: {v199}"
    let v201 : string = failwith<string> v200
    v201 
    #endif
#else
    let v202 : (unit -> string) = System.IO.Path.GetTempPath
    let v203 : string = v202 ()
    v203 
    #endif
    |> fun x -> _v171 <- Some x
    let v204 : string = match _v171 with Some x -> x | None -> failwith "base.run_target / _v171=None"
    let v205 : string = method27()
    let v206 : string = method28(v204, v205)
    let v207 : string = method31()
    let v208 : string = method28(v206, v207)
    let v209 : (System.Guid -> string) = _.ToString()
    let v210 : string = v209 v4
    let v211 : string = method28(v208, v210)
    v211 
    #endif
    |> fun x -> _v5 <- Some x
    let v212 : string = match _v5 with Some x -> x | None -> failwith "base.run_target / _v5=None"
    v212 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v213 : System.DateTime = System.DateTime.Now
    let v214 : (unit -> System.Guid) = System.Guid.NewGuid
    let v215 : System.Guid = v214 ()
    let v216 : System.Guid = method21(v215, v213)
    let v217 : bool = true
    let mutable _v217 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v218 : bool = true
    let mutable _v218 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v219 : string = "std::env::temp_dir()"
    let v220 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr () v219 
    let v221 : string = "$0.display()"
    let v222 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v220 v221 
    let v223 : bool = true
    let mutable _v223 : std_string_String option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v224 : string = "format!(\"{}\", $0)"
    let v225 : std_string_String = Fable.Core.RustInterop.emitRustExpr v222 v224 
    v225 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v226 : string = "format!(\"{}\", $0)"
    let v227 : std_string_String = Fable.Core.RustInterop.emitRustExpr v222 v226 
    v227 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v228 : string = "format!(\"{}\", $0)"
    let v229 : std_string_String = Fable.Core.RustInterop.emitRustExpr v222 v228 
    v229 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v230 : std_string_String = null |> unbox<std_string_String>
    v230 
    #endif
#if FABLE_COMPILER_PYTHON
    let v231 : std_string_String = null |> unbox<std_string_String>
    v231 
    #endif
#else
    let v232 : std_string_String = null |> unbox<std_string_String>
    v232 
    #endif
    |> fun x -> _v223 <- Some x
    let v233 : std_string_String = match _v223 with Some x -> x | None -> failwith "base.run_target / _v223=None"
    let v234 : string = "fable_library_rust::String_::fromString($0)"
    let v235 : string = Fable.Core.RustInterop.emitRustExpr v233 v234 
    v235 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v236 : US4 = US4_1
    let v237 : US5 = US5_0(v236)
    let v238 : string = $"file_system.get_temp_path / target: {v237}"
    let v239 : string = failwith<string> v238
    v239 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v240 : string = null |> unbox<string>
    v240 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v241 : US4 = US4_0
    let v242 : US5 = US5_2(v241)
    let v243 : string = $"file_system.get_temp_path / target: {v242}"
    let v244 : string = failwith<string> v243
    v244 
    #endif
#if FABLE_COMPILER_PYTHON
    let v245 : US4 = US4_0
    let v246 : US5 = US5_3(v245)
    let v247 : string = $"file_system.get_temp_path / target: {v246}"
    let v248 : string = failwith<string> v247
    v248 
    #endif
#else
    let v249 : (unit -> string) = System.IO.Path.GetTempPath
    let v250 : string = v249 ()
    v250 
    #endif
    |> fun x -> _v218 <- Some x
    let v251 : string = match _v218 with Some x -> x | None -> failwith "base.run_target / _v218=None"
    let v252 : string = method27()
    let v253 : string = method28(v251, v252)
    let v254 : string = method31()
    let v255 : string = method28(v253, v254)
    let v256 : (System.Guid -> string) = _.ToString()
    let v257 : string = v256 v216
    let v258 : string = method28(v255, v257)
    v258 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v259 : bool = true
    let mutable _v259 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v260 : string = "std::env::temp_dir()"
    let v261 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr () v260 
    let v262 : string = "$0.display()"
    let v263 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v261 v262 
    let v264 : bool = true
    let mutable _v264 : std_string_String option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v265 : string = "format!(\"{}\", $0)"
    let v266 : std_string_String = Fable.Core.RustInterop.emitRustExpr v263 v265 
    v266 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v267 : string = "format!(\"{}\", $0)"
    let v268 : std_string_String = Fable.Core.RustInterop.emitRustExpr v263 v267 
    v268 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v269 : string = "format!(\"{}\", $0)"
    let v270 : std_string_String = Fable.Core.RustInterop.emitRustExpr v263 v269 
    v270 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v271 : std_string_String = null |> unbox<std_string_String>
    v271 
    #endif
#if FABLE_COMPILER_PYTHON
    let v272 : std_string_String = null |> unbox<std_string_String>
    v272 
    #endif
#else
    let v273 : std_string_String = null |> unbox<std_string_String>
    v273 
    #endif
    |> fun x -> _v264 <- Some x
    let v274 : std_string_String = match _v264 with Some x -> x | None -> failwith "base.run_target / _v264=None"
    let v275 : string = "fable_library_rust::String_::fromString($0)"
    let v276 : string = Fable.Core.RustInterop.emitRustExpr v274 v275 
    v276 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v277 : US4 = US4_1
    let v278 : US5 = US5_0(v277)
    let v279 : string = $"file_system.get_temp_path / target: {v278}"
    let v280 : string = failwith<string> v279
    v280 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v281 : string = null |> unbox<string>
    v281 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v282 : US4 = US4_0
    let v283 : US5 = US5_2(v282)
    let v284 : string = $"file_system.get_temp_path / target: {v283}"
    let v285 : string = failwith<string> v284
    v285 
    #endif
#if FABLE_COMPILER_PYTHON
    let v286 : US4 = US4_0
    let v287 : US5 = US5_3(v286)
    let v288 : string = $"file_system.get_temp_path / target: {v287}"
    let v289 : string = failwith<string> v288
    v289 
    #endif
#else
    let v290 : (unit -> string) = System.IO.Path.GetTempPath
    let v291 : string = v290 ()
    v291 
    #endif
    |> fun x -> _v259 <- Some x
    let v292 : string = match _v259 with Some x -> x | None -> failwith "base.run_target / _v259=None"
    let v293 : string = method27()
    let v294 : string = method28(v292, v293)
    let v295 : string = method31()
    let v296 : string = method28(v294, v295)
    let v297 : (System.Guid -> string) = _.ToString()
    let v298 : string = v297 v216
    let v299 : string = method28(v296, v298)
    v299 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v300 : string = null |> unbox<string>
    v300 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v301 : bool = true
    let mutable _v301 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v302 : string = "std::env::temp_dir()"
    let v303 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr () v302 
    let v304 : string = "$0.display()"
    let v305 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v303 v304 
    let v306 : bool = true
    let mutable _v306 : std_string_String option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v307 : string = "format!(\"{}\", $0)"
    let v308 : std_string_String = Fable.Core.RustInterop.emitRustExpr v305 v307 
    v308 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v309 : string = "format!(\"{}\", $0)"
    let v310 : std_string_String = Fable.Core.RustInterop.emitRustExpr v305 v309 
    v310 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v311 : string = "format!(\"{}\", $0)"
    let v312 : std_string_String = Fable.Core.RustInterop.emitRustExpr v305 v311 
    v312 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v313 : std_string_String = null |> unbox<std_string_String>
    v313 
    #endif
#if FABLE_COMPILER_PYTHON
    let v314 : std_string_String = null |> unbox<std_string_String>
    v314 
    #endif
#else
    let v315 : std_string_String = null |> unbox<std_string_String>
    v315 
    #endif
    |> fun x -> _v306 <- Some x
    let v316 : std_string_String = match _v306 with Some x -> x | None -> failwith "base.run_target / _v306=None"
    let v317 : string = "fable_library_rust::String_::fromString($0)"
    let v318 : string = Fable.Core.RustInterop.emitRustExpr v316 v317 
    v318 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v319 : US4 = US4_1
    let v320 : US5 = US5_0(v319)
    let v321 : string = $"file_system.get_temp_path / target: {v320}"
    let v322 : string = failwith<string> v321
    v322 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v323 : string = null |> unbox<string>
    v323 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v324 : US4 = US4_0
    let v325 : US5 = US5_2(v324)
    let v326 : string = $"file_system.get_temp_path / target: {v325}"
    let v327 : string = failwith<string> v326
    v327 
    #endif
#if FABLE_COMPILER_PYTHON
    let v328 : US4 = US4_0
    let v329 : US5 = US5_3(v328)
    let v330 : string = $"file_system.get_temp_path / target: {v329}"
    let v331 : string = failwith<string> v330
    v331 
    #endif
#else
    let v332 : (unit -> string) = System.IO.Path.GetTempPath
    let v333 : string = v332 ()
    v333 
    #endif
    |> fun x -> _v301 <- Some x
    let v334 : string = match _v301 with Some x -> x | None -> failwith "base.run_target / _v301=None"
    let v335 : string = method27()
    let v336 : string = method28(v334, v335)
    let v337 : string = method31()
    let v338 : string = method28(v336, v337)
    let v339 : (System.Guid -> string) = _.ToString()
    let v340 : string = v339 v216
    let v341 : string = method28(v338, v340)
    v341 
    #endif
#if FABLE_COMPILER_PYTHON
    let v342 : bool = true
    let mutable _v342 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v343 : string = "std::env::temp_dir()"
    let v344 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr () v343 
    let v345 : string = "$0.display()"
    let v346 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v344 v345 
    let v347 : bool = true
    let mutable _v347 : std_string_String option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v348 : string = "format!(\"{}\", $0)"
    let v349 : std_string_String = Fable.Core.RustInterop.emitRustExpr v346 v348 
    v349 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v350 : string = "format!(\"{}\", $0)"
    let v351 : std_string_String = Fable.Core.RustInterop.emitRustExpr v346 v350 
    v351 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v352 : string = "format!(\"{}\", $0)"
    let v353 : std_string_String = Fable.Core.RustInterop.emitRustExpr v346 v352 
    v353 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v354 : std_string_String = null |> unbox<std_string_String>
    v354 
    #endif
#if FABLE_COMPILER_PYTHON
    let v355 : std_string_String = null |> unbox<std_string_String>
    v355 
    #endif
#else
    let v356 : std_string_String = null |> unbox<std_string_String>
    v356 
    #endif
    |> fun x -> _v347 <- Some x
    let v357 : std_string_String = match _v347 with Some x -> x | None -> failwith "base.run_target / _v347=None"
    let v358 : string = "fable_library_rust::String_::fromString($0)"
    let v359 : string = Fable.Core.RustInterop.emitRustExpr v357 v358 
    v359 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v360 : US4 = US4_1
    let v361 : US5 = US5_0(v360)
    let v362 : string = $"file_system.get_temp_path / target: {v361}"
    let v363 : string = failwith<string> v362
    v363 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v364 : string = null |> unbox<string>
    v364 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v365 : US4 = US4_0
    let v366 : US5 = US5_2(v365)
    let v367 : string = $"file_system.get_temp_path / target: {v366}"
    let v368 : string = failwith<string> v367
    v368 
    #endif
#if FABLE_COMPILER_PYTHON
    let v369 : US4 = US4_0
    let v370 : US5 = US5_3(v369)
    let v371 : string = $"file_system.get_temp_path / target: {v370}"
    let v372 : string = failwith<string> v371
    v372 
    #endif
#else
    let v373 : (unit -> string) = System.IO.Path.GetTempPath
    let v374 : string = v373 ()
    v374 
    #endif
    |> fun x -> _v342 <- Some x
    let v375 : string = match _v342 with Some x -> x | None -> failwith "base.run_target / _v342=None"
    let v376 : string = method27()
    let v377 : string = method28(v375, v376)
    let v378 : string = method31()
    let v379 : string = method28(v377, v378)
    let v380 : (System.Guid -> string) = _.ToString()
    let v381 : string = v380 v216
    let v382 : string = method28(v379, v381)
    v382 
    #endif
#else
    let v383 : bool = true
    let mutable _v383 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v384 : string = "std::env::temp_dir()"
    let v385 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr () v384 
    let v386 : string = "$0.display()"
    let v387 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v385 v386 
    let v388 : bool = true
    let mutable _v388 : std_string_String option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v389 : string = "format!(\"{}\", $0)"
    let v390 : std_string_String = Fable.Core.RustInterop.emitRustExpr v387 v389 
    v390 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v391 : string = "format!(\"{}\", $0)"
    let v392 : std_string_String = Fable.Core.RustInterop.emitRustExpr v387 v391 
    v392 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v393 : string = "format!(\"{}\", $0)"
    let v394 : std_string_String = Fable.Core.RustInterop.emitRustExpr v387 v393 
    v394 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v395 : std_string_String = null |> unbox<std_string_String>
    v395 
    #endif
#if FABLE_COMPILER_PYTHON
    let v396 : std_string_String = null |> unbox<std_string_String>
    v396 
    #endif
#else
    let v397 : std_string_String = null |> unbox<std_string_String>
    v397 
    #endif
    |> fun x -> _v388 <- Some x
    let v398 : std_string_String = match _v388 with Some x -> x | None -> failwith "base.run_target / _v388=None"
    let v399 : string = "fable_library_rust::String_::fromString($0)"
    let v400 : string = Fable.Core.RustInterop.emitRustExpr v398 v399 
    v400 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v401 : US4 = US4_1
    let v402 : US5 = US5_0(v401)
    let v403 : string = $"file_system.get_temp_path / target: {v402}"
    let v404 : string = failwith<string> v403
    v404 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v405 : string = null |> unbox<string>
    v405 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v406 : US4 = US4_0
    let v407 : US5 = US5_2(v406)
    let v408 : string = $"file_system.get_temp_path / target: {v407}"
    let v409 : string = failwith<string> v408
    v409 
    #endif
#if FABLE_COMPILER_PYTHON
    let v410 : US4 = US4_0
    let v411 : US5 = US5_3(v410)
    let v412 : string = $"file_system.get_temp_path / target: {v411}"
    let v413 : string = failwith<string> v412
    v413 
    #endif
#else
    let v414 : (unit -> string) = System.IO.Path.GetTempPath
    let v415 : string = v414 ()
    v415 
    #endif
    |> fun x -> _v383 <- Some x
    let v416 : string = match _v383 with Some x -> x | None -> failwith "base.run_target / _v383=None"
    let v417 : string = method27()
    let v418 : string = method28(v416, v417)
    let v419 : string = method31()
    let v420 : string = method28(v418, v419)
    let v421 : (System.Guid -> string) = _.ToString()
    let v422 : string = v421 v216
    let v423 : string = method28(v420, v422)
    v423 
    #endif
    |> fun x -> _v217 <- Some x
    let v424 : string = match _v217 with Some x -> x | None -> failwith "base.run_target / _v217=None"
    v424 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v425 : string = null |> unbox<string>
    v425 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v426 : System.DateTime = System.DateTime.Now
    let v427 : (unit -> System.Guid) = System.Guid.NewGuid
    let v428 : System.Guid = v427 ()
    let v429 : System.Guid = method21(v428, v426)
    let v430 : bool = true
    let mutable _v430 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v431 : bool = true
    let mutable _v431 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v432 : string = "std::env::temp_dir()"
    let v433 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr () v432 
    let v434 : string = "$0.display()"
    let v435 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v433 v434 
    let v436 : bool = true
    let mutable _v436 : std_string_String option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v437 : string = "format!(\"{}\", $0)"
    let v438 : std_string_String = Fable.Core.RustInterop.emitRustExpr v435 v437 
    v438 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v439 : string = "format!(\"{}\", $0)"
    let v440 : std_string_String = Fable.Core.RustInterop.emitRustExpr v435 v439 
    v440 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v441 : string = "format!(\"{}\", $0)"
    let v442 : std_string_String = Fable.Core.RustInterop.emitRustExpr v435 v441 
    v442 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v443 : std_string_String = null |> unbox<std_string_String>
    v443 
    #endif
#if FABLE_COMPILER_PYTHON
    let v444 : std_string_String = null |> unbox<std_string_String>
    v444 
    #endif
#else
    let v445 : std_string_String = null |> unbox<std_string_String>
    v445 
    #endif
    |> fun x -> _v436 <- Some x
    let v446 : std_string_String = match _v436 with Some x -> x | None -> failwith "base.run_target / _v436=None"
    let v447 : string = "fable_library_rust::String_::fromString($0)"
    let v448 : string = Fable.Core.RustInterop.emitRustExpr v446 v447 
    v448 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v449 : US4 = US4_1
    let v450 : US5 = US5_0(v449)
    let v451 : string = $"file_system.get_temp_path / target: {v450}"
    let v452 : string = failwith<string> v451
    v452 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v453 : string = null |> unbox<string>
    v453 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v454 : US4 = US4_0
    let v455 : US5 = US5_2(v454)
    let v456 : string = $"file_system.get_temp_path / target: {v455}"
    let v457 : string = failwith<string> v456
    v457 
    #endif
#if FABLE_COMPILER_PYTHON
    let v458 : US4 = US4_0
    let v459 : US5 = US5_3(v458)
    let v460 : string = $"file_system.get_temp_path / target: {v459}"
    let v461 : string = failwith<string> v460
    v461 
    #endif
#else
    let v462 : (unit -> string) = System.IO.Path.GetTempPath
    let v463 : string = v462 ()
    v463 
    #endif
    |> fun x -> _v431 <- Some x
    let v464 : string = match _v431 with Some x -> x | None -> failwith "base.run_target / _v431=None"
    let v465 : string = method27()
    let v466 : string = method28(v464, v465)
    let v467 : string = method31()
    let v468 : string = method28(v466, v467)
    let v469 : (System.Guid -> string) = _.ToString()
    let v470 : string = v469 v429
    let v471 : string = method28(v468, v470)
    v471 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v472 : bool = true
    let mutable _v472 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v473 : string = "std::env::temp_dir()"
    let v474 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr () v473 
    let v475 : string = "$0.display()"
    let v476 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v474 v475 
    let v477 : bool = true
    let mutable _v477 : std_string_String option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v478 : string = "format!(\"{}\", $0)"
    let v479 : std_string_String = Fable.Core.RustInterop.emitRustExpr v476 v478 
    v479 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v480 : string = "format!(\"{}\", $0)"
    let v481 : std_string_String = Fable.Core.RustInterop.emitRustExpr v476 v480 
    v481 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v482 : string = "format!(\"{}\", $0)"
    let v483 : std_string_String = Fable.Core.RustInterop.emitRustExpr v476 v482 
    v483 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v484 : std_string_String = null |> unbox<std_string_String>
    v484 
    #endif
#if FABLE_COMPILER_PYTHON
    let v485 : std_string_String = null |> unbox<std_string_String>
    v485 
    #endif
#else
    let v486 : std_string_String = null |> unbox<std_string_String>
    v486 
    #endif
    |> fun x -> _v477 <- Some x
    let v487 : std_string_String = match _v477 with Some x -> x | None -> failwith "base.run_target / _v477=None"
    let v488 : string = "fable_library_rust::String_::fromString($0)"
    let v489 : string = Fable.Core.RustInterop.emitRustExpr v487 v488 
    v489 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v490 : US4 = US4_1
    let v491 : US5 = US5_0(v490)
    let v492 : string = $"file_system.get_temp_path / target: {v491}"
    let v493 : string = failwith<string> v492
    v493 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v494 : string = null |> unbox<string>
    v494 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v495 : US4 = US4_0
    let v496 : US5 = US5_2(v495)
    let v497 : string = $"file_system.get_temp_path / target: {v496}"
    let v498 : string = failwith<string> v497
    v498 
    #endif
#if FABLE_COMPILER_PYTHON
    let v499 : US4 = US4_0
    let v500 : US5 = US5_3(v499)
    let v501 : string = $"file_system.get_temp_path / target: {v500}"
    let v502 : string = failwith<string> v501
    v502 
    #endif
#else
    let v503 : (unit -> string) = System.IO.Path.GetTempPath
    let v504 : string = v503 ()
    v504 
    #endif
    |> fun x -> _v472 <- Some x
    let v505 : string = match _v472 with Some x -> x | None -> failwith "base.run_target / _v472=None"
    let v506 : string = method27()
    let v507 : string = method28(v505, v506)
    let v508 : string = method31()
    let v509 : string = method28(v507, v508)
    let v510 : (System.Guid -> string) = _.ToString()
    let v511 : string = v510 v429
    let v512 : string = method28(v509, v511)
    v512 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v513 : string = null |> unbox<string>
    v513 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v514 : bool = true
    let mutable _v514 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v515 : string = "std::env::temp_dir()"
    let v516 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr () v515 
    let v517 : string = "$0.display()"
    let v518 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v516 v517 
    let v519 : bool = true
    let mutable _v519 : std_string_String option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v520 : string = "format!(\"{}\", $0)"
    let v521 : std_string_String = Fable.Core.RustInterop.emitRustExpr v518 v520 
    v521 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v522 : string = "format!(\"{}\", $0)"
    let v523 : std_string_String = Fable.Core.RustInterop.emitRustExpr v518 v522 
    v523 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v524 : string = "format!(\"{}\", $0)"
    let v525 : std_string_String = Fable.Core.RustInterop.emitRustExpr v518 v524 
    v525 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v526 : std_string_String = null |> unbox<std_string_String>
    v526 
    #endif
#if FABLE_COMPILER_PYTHON
    let v527 : std_string_String = null |> unbox<std_string_String>
    v527 
    #endif
#else
    let v528 : std_string_String = null |> unbox<std_string_String>
    v528 
    #endif
    |> fun x -> _v519 <- Some x
    let v529 : std_string_String = match _v519 with Some x -> x | None -> failwith "base.run_target / _v519=None"
    let v530 : string = "fable_library_rust::String_::fromString($0)"
    let v531 : string = Fable.Core.RustInterop.emitRustExpr v529 v530 
    v531 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v532 : US4 = US4_1
    let v533 : US5 = US5_0(v532)
    let v534 : string = $"file_system.get_temp_path / target: {v533}"
    let v535 : string = failwith<string> v534
    v535 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v536 : string = null |> unbox<string>
    v536 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v537 : US4 = US4_0
    let v538 : US5 = US5_2(v537)
    let v539 : string = $"file_system.get_temp_path / target: {v538}"
    let v540 : string = failwith<string> v539
    v540 
    #endif
#if FABLE_COMPILER_PYTHON
    let v541 : US4 = US4_0
    let v542 : US5 = US5_3(v541)
    let v543 : string = $"file_system.get_temp_path / target: {v542}"
    let v544 : string = failwith<string> v543
    v544 
    #endif
#else
    let v545 : (unit -> string) = System.IO.Path.GetTempPath
    let v546 : string = v545 ()
    v546 
    #endif
    |> fun x -> _v514 <- Some x
    let v547 : string = match _v514 with Some x -> x | None -> failwith "base.run_target / _v514=None"
    let v548 : string = method27()
    let v549 : string = method28(v547, v548)
    let v550 : string = method31()
    let v551 : string = method28(v549, v550)
    let v552 : (System.Guid -> string) = _.ToString()
    let v553 : string = v552 v429
    let v554 : string = method28(v551, v553)
    v554 
    #endif
#if FABLE_COMPILER_PYTHON
    let v555 : bool = true
    let mutable _v555 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v556 : string = "std::env::temp_dir()"
    let v557 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr () v556 
    let v558 : string = "$0.display()"
    let v559 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v557 v558 
    let v560 : bool = true
    let mutable _v560 : std_string_String option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v561 : string = "format!(\"{}\", $0)"
    let v562 : std_string_String = Fable.Core.RustInterop.emitRustExpr v559 v561 
    v562 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v563 : string = "format!(\"{}\", $0)"
    let v564 : std_string_String = Fable.Core.RustInterop.emitRustExpr v559 v563 
    v564 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v565 : string = "format!(\"{}\", $0)"
    let v566 : std_string_String = Fable.Core.RustInterop.emitRustExpr v559 v565 
    v566 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v567 : std_string_String = null |> unbox<std_string_String>
    v567 
    #endif
#if FABLE_COMPILER_PYTHON
    let v568 : std_string_String = null |> unbox<std_string_String>
    v568 
    #endif
#else
    let v569 : std_string_String = null |> unbox<std_string_String>
    v569 
    #endif
    |> fun x -> _v560 <- Some x
    let v570 : std_string_String = match _v560 with Some x -> x | None -> failwith "base.run_target / _v560=None"
    let v571 : string = "fable_library_rust::String_::fromString($0)"
    let v572 : string = Fable.Core.RustInterop.emitRustExpr v570 v571 
    v572 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v573 : US4 = US4_1
    let v574 : US5 = US5_0(v573)
    let v575 : string = $"file_system.get_temp_path / target: {v574}"
    let v576 : string = failwith<string> v575
    v576 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v577 : string = null |> unbox<string>
    v577 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v578 : US4 = US4_0
    let v579 : US5 = US5_2(v578)
    let v580 : string = $"file_system.get_temp_path / target: {v579}"
    let v581 : string = failwith<string> v580
    v581 
    #endif
#if FABLE_COMPILER_PYTHON
    let v582 : US4 = US4_0
    let v583 : US5 = US5_3(v582)
    let v584 : string = $"file_system.get_temp_path / target: {v583}"
    let v585 : string = failwith<string> v584
    v585 
    #endif
#else
    let v586 : (unit -> string) = System.IO.Path.GetTempPath
    let v587 : string = v586 ()
    v587 
    #endif
    |> fun x -> _v555 <- Some x
    let v588 : string = match _v555 with Some x -> x | None -> failwith "base.run_target / _v555=None"
    let v589 : string = method27()
    let v590 : string = method28(v588, v589)
    let v591 : string = method31()
    let v592 : string = method28(v590, v591)
    let v593 : (System.Guid -> string) = _.ToString()
    let v594 : string = v593 v429
    let v595 : string = method28(v592, v594)
    v595 
    #endif
#else
    let v596 : bool = true
    let mutable _v596 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v597 : string = "std::env::temp_dir()"
    let v598 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr () v597 
    let v599 : string = "$0.display()"
    let v600 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v598 v599 
    let v601 : bool = true
    let mutable _v601 : std_string_String option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v602 : string = "format!(\"{}\", $0)"
    let v603 : std_string_String = Fable.Core.RustInterop.emitRustExpr v600 v602 
    v603 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v604 : string = "format!(\"{}\", $0)"
    let v605 : std_string_String = Fable.Core.RustInterop.emitRustExpr v600 v604 
    v605 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v606 : string = "format!(\"{}\", $0)"
    let v607 : std_string_String = Fable.Core.RustInterop.emitRustExpr v600 v606 
    v607 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v608 : std_string_String = null |> unbox<std_string_String>
    v608 
    #endif
#if FABLE_COMPILER_PYTHON
    let v609 : std_string_String = null |> unbox<std_string_String>
    v609 
    #endif
#else
    let v610 : std_string_String = null |> unbox<std_string_String>
    v610 
    #endif
    |> fun x -> _v601 <- Some x
    let v611 : std_string_String = match _v601 with Some x -> x | None -> failwith "base.run_target / _v601=None"
    let v612 : string = "fable_library_rust::String_::fromString($0)"
    let v613 : string = Fable.Core.RustInterop.emitRustExpr v611 v612 
    v613 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v614 : US4 = US4_1
    let v615 : US5 = US5_0(v614)
    let v616 : string = $"file_system.get_temp_path / target: {v615}"
    let v617 : string = failwith<string> v616
    v617 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v618 : string = null |> unbox<string>
    v618 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v619 : US4 = US4_0
    let v620 : US5 = US5_2(v619)
    let v621 : string = $"file_system.get_temp_path / target: {v620}"
    let v622 : string = failwith<string> v621
    v622 
    #endif
#if FABLE_COMPILER_PYTHON
    let v623 : US4 = US4_0
    let v624 : US5 = US5_3(v623)
    let v625 : string = $"file_system.get_temp_path / target: {v624}"
    let v626 : string = failwith<string> v625
    v626 
    #endif
#else
    let v627 : (unit -> string) = System.IO.Path.GetTempPath
    let v628 : string = v627 ()
    v628 
    #endif
    |> fun x -> _v596 <- Some x
    let v629 : string = match _v596 with Some x -> x | None -> failwith "base.run_target / _v596=None"
    let v630 : string = method27()
    let v631 : string = method28(v629, v630)
    let v632 : string = method31()
    let v633 : string = method28(v631, v632)
    let v634 : (System.Guid -> string) = _.ToString()
    let v635 : string = v634 v429
    let v636 : string = method28(v633, v635)
    v636 
    #endif
    |> fun x -> _v430 <- Some x
    let v637 : string = match _v430 with Some x -> x | None -> failwith "base.run_target / _v430=None"
    v637 
    #endif
#if FABLE_COMPILER_PYTHON
    let v638 : System.DateTime = System.DateTime.Now
    let v639 : (unit -> System.Guid) = System.Guid.NewGuid
    let v640 : System.Guid = v639 ()
    let v641 : System.Guid = method21(v640, v638)
    let v642 : bool = true
    let mutable _v642 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v643 : bool = true
    let mutable _v643 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v644 : string = "std::env::temp_dir()"
    let v645 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr () v644 
    let v646 : string = "$0.display()"
    let v647 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v645 v646 
    let v648 : bool = true
    let mutable _v648 : std_string_String option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v649 : string = "format!(\"{}\", $0)"
    let v650 : std_string_String = Fable.Core.RustInterop.emitRustExpr v647 v649 
    v650 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v651 : string = "format!(\"{}\", $0)"
    let v652 : std_string_String = Fable.Core.RustInterop.emitRustExpr v647 v651 
    v652 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v653 : string = "format!(\"{}\", $0)"
    let v654 : std_string_String = Fable.Core.RustInterop.emitRustExpr v647 v653 
    v654 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v655 : std_string_String = null |> unbox<std_string_String>
    v655 
    #endif
#if FABLE_COMPILER_PYTHON
    let v656 : std_string_String = null |> unbox<std_string_String>
    v656 
    #endif
#else
    let v657 : std_string_String = null |> unbox<std_string_String>
    v657 
    #endif
    |> fun x -> _v648 <- Some x
    let v658 : std_string_String = match _v648 with Some x -> x | None -> failwith "base.run_target / _v648=None"
    let v659 : string = "fable_library_rust::String_::fromString($0)"
    let v660 : string = Fable.Core.RustInterop.emitRustExpr v658 v659 
    v660 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v661 : US4 = US4_1
    let v662 : US5 = US5_0(v661)
    let v663 : string = $"file_system.get_temp_path / target: {v662}"
    let v664 : string = failwith<string> v663
    v664 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v665 : string = null |> unbox<string>
    v665 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v666 : US4 = US4_0
    let v667 : US5 = US5_2(v666)
    let v668 : string = $"file_system.get_temp_path / target: {v667}"
    let v669 : string = failwith<string> v668
    v669 
    #endif
#if FABLE_COMPILER_PYTHON
    let v670 : US4 = US4_0
    let v671 : US5 = US5_3(v670)
    let v672 : string = $"file_system.get_temp_path / target: {v671}"
    let v673 : string = failwith<string> v672
    v673 
    #endif
#else
    let v674 : (unit -> string) = System.IO.Path.GetTempPath
    let v675 : string = v674 ()
    v675 
    #endif
    |> fun x -> _v643 <- Some x
    let v676 : string = match _v643 with Some x -> x | None -> failwith "base.run_target / _v643=None"
    let v677 : string = method27()
    let v678 : string = method28(v676, v677)
    let v679 : string = method31()
    let v680 : string = method28(v678, v679)
    let v681 : (System.Guid -> string) = _.ToString()
    let v682 : string = v681 v641
    let v683 : string = method28(v680, v682)
    v683 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v684 : bool = true
    let mutable _v684 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v685 : string = "std::env::temp_dir()"
    let v686 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr () v685 
    let v687 : string = "$0.display()"
    let v688 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v686 v687 
    let v689 : bool = true
    let mutable _v689 : std_string_String option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v690 : string = "format!(\"{}\", $0)"
    let v691 : std_string_String = Fable.Core.RustInterop.emitRustExpr v688 v690 
    v691 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v692 : string = "format!(\"{}\", $0)"
    let v693 : std_string_String = Fable.Core.RustInterop.emitRustExpr v688 v692 
    v693 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v694 : string = "format!(\"{}\", $0)"
    let v695 : std_string_String = Fable.Core.RustInterop.emitRustExpr v688 v694 
    v695 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v696 : std_string_String = null |> unbox<std_string_String>
    v696 
    #endif
#if FABLE_COMPILER_PYTHON
    let v697 : std_string_String = null |> unbox<std_string_String>
    v697 
    #endif
#else
    let v698 : std_string_String = null |> unbox<std_string_String>
    v698 
    #endif
    |> fun x -> _v689 <- Some x
    let v699 : std_string_String = match _v689 with Some x -> x | None -> failwith "base.run_target / _v689=None"
    let v700 : string = "fable_library_rust::String_::fromString($0)"
    let v701 : string = Fable.Core.RustInterop.emitRustExpr v699 v700 
    v701 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v702 : US4 = US4_1
    let v703 : US5 = US5_0(v702)
    let v704 : string = $"file_system.get_temp_path / target: {v703}"
    let v705 : string = failwith<string> v704
    v705 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v706 : string = null |> unbox<string>
    v706 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v707 : US4 = US4_0
    let v708 : US5 = US5_2(v707)
    let v709 : string = $"file_system.get_temp_path / target: {v708}"
    let v710 : string = failwith<string> v709
    v710 
    #endif
#if FABLE_COMPILER_PYTHON
    let v711 : US4 = US4_0
    let v712 : US5 = US5_3(v711)
    let v713 : string = $"file_system.get_temp_path / target: {v712}"
    let v714 : string = failwith<string> v713
    v714 
    #endif
#else
    let v715 : (unit -> string) = System.IO.Path.GetTempPath
    let v716 : string = v715 ()
    v716 
    #endif
    |> fun x -> _v684 <- Some x
    let v717 : string = match _v684 with Some x -> x | None -> failwith "base.run_target / _v684=None"
    let v718 : string = method27()
    let v719 : string = method28(v717, v718)
    let v720 : string = method31()
    let v721 : string = method28(v719, v720)
    let v722 : (System.Guid -> string) = _.ToString()
    let v723 : string = v722 v641
    let v724 : string = method28(v721, v723)
    v724 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v725 : string = null |> unbox<string>
    v725 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v726 : bool = true
    let mutable _v726 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v727 : string = "std::env::temp_dir()"
    let v728 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr () v727 
    let v729 : string = "$0.display()"
    let v730 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v728 v729 
    let v731 : bool = true
    let mutable _v731 : std_string_String option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v732 : string = "format!(\"{}\", $0)"
    let v733 : std_string_String = Fable.Core.RustInterop.emitRustExpr v730 v732 
    v733 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v734 : string = "format!(\"{}\", $0)"
    let v735 : std_string_String = Fable.Core.RustInterop.emitRustExpr v730 v734 
    v735 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v736 : string = "format!(\"{}\", $0)"
    let v737 : std_string_String = Fable.Core.RustInterop.emitRustExpr v730 v736 
    v737 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v738 : std_string_String = null |> unbox<std_string_String>
    v738 
    #endif
#if FABLE_COMPILER_PYTHON
    let v739 : std_string_String = null |> unbox<std_string_String>
    v739 
    #endif
#else
    let v740 : std_string_String = null |> unbox<std_string_String>
    v740 
    #endif
    |> fun x -> _v731 <- Some x
    let v741 : std_string_String = match _v731 with Some x -> x | None -> failwith "base.run_target / _v731=None"
    let v742 : string = "fable_library_rust::String_::fromString($0)"
    let v743 : string = Fable.Core.RustInterop.emitRustExpr v741 v742 
    v743 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v744 : US4 = US4_1
    let v745 : US5 = US5_0(v744)
    let v746 : string = $"file_system.get_temp_path / target: {v745}"
    let v747 : string = failwith<string> v746
    v747 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v748 : string = null |> unbox<string>
    v748 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v749 : US4 = US4_0
    let v750 : US5 = US5_2(v749)
    let v751 : string = $"file_system.get_temp_path / target: {v750}"
    let v752 : string = failwith<string> v751
    v752 
    #endif
#if FABLE_COMPILER_PYTHON
    let v753 : US4 = US4_0
    let v754 : US5 = US5_3(v753)
    let v755 : string = $"file_system.get_temp_path / target: {v754}"
    let v756 : string = failwith<string> v755
    v756 
    #endif
#else
    let v757 : (unit -> string) = System.IO.Path.GetTempPath
    let v758 : string = v757 ()
    v758 
    #endif
    |> fun x -> _v726 <- Some x
    let v759 : string = match _v726 with Some x -> x | None -> failwith "base.run_target / _v726=None"
    let v760 : string = method27()
    let v761 : string = method28(v759, v760)
    let v762 : string = method31()
    let v763 : string = method28(v761, v762)
    let v764 : (System.Guid -> string) = _.ToString()
    let v765 : string = v764 v641
    let v766 : string = method28(v763, v765)
    v766 
    #endif
#if FABLE_COMPILER_PYTHON
    let v767 : bool = true
    let mutable _v767 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v768 : string = "std::env::temp_dir()"
    let v769 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr () v768 
    let v770 : string = "$0.display()"
    let v771 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v769 v770 
    let v772 : bool = true
    let mutable _v772 : std_string_String option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v773 : string = "format!(\"{}\", $0)"
    let v774 : std_string_String = Fable.Core.RustInterop.emitRustExpr v771 v773 
    v774 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v775 : string = "format!(\"{}\", $0)"
    let v776 : std_string_String = Fable.Core.RustInterop.emitRustExpr v771 v775 
    v776 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v777 : string = "format!(\"{}\", $0)"
    let v778 : std_string_String = Fable.Core.RustInterop.emitRustExpr v771 v777 
    v778 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v779 : std_string_String = null |> unbox<std_string_String>
    v779 
    #endif
#if FABLE_COMPILER_PYTHON
    let v780 : std_string_String = null |> unbox<std_string_String>
    v780 
    #endif
#else
    let v781 : std_string_String = null |> unbox<std_string_String>
    v781 
    #endif
    |> fun x -> _v772 <- Some x
    let v782 : std_string_String = match _v772 with Some x -> x | None -> failwith "base.run_target / _v772=None"
    let v783 : string = "fable_library_rust::String_::fromString($0)"
    let v784 : string = Fable.Core.RustInterop.emitRustExpr v782 v783 
    v784 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v785 : US4 = US4_1
    let v786 : US5 = US5_0(v785)
    let v787 : string = $"file_system.get_temp_path / target: {v786}"
    let v788 : string = failwith<string> v787
    v788 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v789 : string = null |> unbox<string>
    v789 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v790 : US4 = US4_0
    let v791 : US5 = US5_2(v790)
    let v792 : string = $"file_system.get_temp_path / target: {v791}"
    let v793 : string = failwith<string> v792
    v793 
    #endif
#if FABLE_COMPILER_PYTHON
    let v794 : US4 = US4_0
    let v795 : US5 = US5_3(v794)
    let v796 : string = $"file_system.get_temp_path / target: {v795}"
    let v797 : string = failwith<string> v796
    v797 
    #endif
#else
    let v798 : (unit -> string) = System.IO.Path.GetTempPath
    let v799 : string = v798 ()
    v799 
    #endif
    |> fun x -> _v767 <- Some x
    let v800 : string = match _v767 with Some x -> x | None -> failwith "base.run_target / _v767=None"
    let v801 : string = method27()
    let v802 : string = method28(v800, v801)
    let v803 : string = method31()
    let v804 : string = method28(v802, v803)
    let v805 : (System.Guid -> string) = _.ToString()
    let v806 : string = v805 v641
    let v807 : string = method28(v804, v806)
    v807 
    #endif
#else
    let v808 : bool = true
    let mutable _v808 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v809 : string = "std::env::temp_dir()"
    let v810 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr () v809 
    let v811 : string = "$0.display()"
    let v812 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v810 v811 
    let v813 : bool = true
    let mutable _v813 : std_string_String option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v814 : string = "format!(\"{}\", $0)"
    let v815 : std_string_String = Fable.Core.RustInterop.emitRustExpr v812 v814 
    v815 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v816 : string = "format!(\"{}\", $0)"
    let v817 : std_string_String = Fable.Core.RustInterop.emitRustExpr v812 v816 
    v817 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v818 : string = "format!(\"{}\", $0)"
    let v819 : std_string_String = Fable.Core.RustInterop.emitRustExpr v812 v818 
    v819 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v820 : std_string_String = null |> unbox<std_string_String>
    v820 
    #endif
#if FABLE_COMPILER_PYTHON
    let v821 : std_string_String = null |> unbox<std_string_String>
    v821 
    #endif
#else
    let v822 : std_string_String = null |> unbox<std_string_String>
    v822 
    #endif
    |> fun x -> _v813 <- Some x
    let v823 : std_string_String = match _v813 with Some x -> x | None -> failwith "base.run_target / _v813=None"
    let v824 : string = "fable_library_rust::String_::fromString($0)"
    let v825 : string = Fable.Core.RustInterop.emitRustExpr v823 v824 
    v825 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v826 : US4 = US4_1
    let v827 : US5 = US5_0(v826)
    let v828 : string = $"file_system.get_temp_path / target: {v827}"
    let v829 : string = failwith<string> v828
    v829 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v830 : string = null |> unbox<string>
    v830 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v831 : US4 = US4_0
    let v832 : US5 = US5_2(v831)
    let v833 : string = $"file_system.get_temp_path / target: {v832}"
    let v834 : string = failwith<string> v833
    v834 
    #endif
#if FABLE_COMPILER_PYTHON
    let v835 : US4 = US4_0
    let v836 : US5 = US5_3(v835)
    let v837 : string = $"file_system.get_temp_path / target: {v836}"
    let v838 : string = failwith<string> v837
    v838 
    #endif
#else
    let v839 : (unit -> string) = System.IO.Path.GetTempPath
    let v840 : string = v839 ()
    v840 
    #endif
    |> fun x -> _v808 <- Some x
    let v841 : string = match _v808 with Some x -> x | None -> failwith "base.run_target / _v808=None"
    let v842 : string = method27()
    let v843 : string = method28(v841, v842)
    let v844 : string = method31()
    let v845 : string = method28(v843, v844)
    let v846 : (System.Guid -> string) = _.ToString()
    let v847 : string = v846 v641
    let v848 : string = method28(v845, v847)
    v848 
    #endif
    |> fun x -> _v642 <- Some x
    let v849 : string = match _v642 with Some x -> x | None -> failwith "base.run_target / _v642=None"
    v849 
    #endif
#else
    let v850 : System.DateTime = System.DateTime.Now
    let v851 : (unit -> System.Guid) = System.Guid.NewGuid
    let v852 : System.Guid = v851 ()
    let v853 : System.Guid = method21(v852, v850)
    let v854 : bool = true
    let mutable _v854 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v855 : bool = true
    let mutable _v855 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v856 : string = "std::env::temp_dir()"
    let v857 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr () v856 
    let v858 : string = "$0.display()"
    let v859 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v857 v858 
    let v860 : bool = true
    let mutable _v860 : std_string_String option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v861 : string = "format!(\"{}\", $0)"
    let v862 : std_string_String = Fable.Core.RustInterop.emitRustExpr v859 v861 
    v862 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v863 : string = "format!(\"{}\", $0)"
    let v864 : std_string_String = Fable.Core.RustInterop.emitRustExpr v859 v863 
    v864 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v865 : string = "format!(\"{}\", $0)"
    let v866 : std_string_String = Fable.Core.RustInterop.emitRustExpr v859 v865 
    v866 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v867 : std_string_String = null |> unbox<std_string_String>
    v867 
    #endif
#if FABLE_COMPILER_PYTHON
    let v868 : std_string_String = null |> unbox<std_string_String>
    v868 
    #endif
#else
    let v869 : std_string_String = null |> unbox<std_string_String>
    v869 
    #endif
    |> fun x -> _v860 <- Some x
    let v870 : std_string_String = match _v860 with Some x -> x | None -> failwith "base.run_target / _v860=None"
    let v871 : string = "fable_library_rust::String_::fromString($0)"
    let v872 : string = Fable.Core.RustInterop.emitRustExpr v870 v871 
    v872 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v873 : US4 = US4_1
    let v874 : US5 = US5_0(v873)
    let v875 : string = $"file_system.get_temp_path / target: {v874}"
    let v876 : string = failwith<string> v875
    v876 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v877 : string = null |> unbox<string>
    v877 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v878 : US4 = US4_0
    let v879 : US5 = US5_2(v878)
    let v880 : string = $"file_system.get_temp_path / target: {v879}"
    let v881 : string = failwith<string> v880
    v881 
    #endif
#if FABLE_COMPILER_PYTHON
    let v882 : US4 = US4_0
    let v883 : US5 = US5_3(v882)
    let v884 : string = $"file_system.get_temp_path / target: {v883}"
    let v885 : string = failwith<string> v884
    v885 
    #endif
#else
    let v886 : (unit -> string) = System.IO.Path.GetTempPath
    let v887 : string = v886 ()
    v887 
    #endif
    |> fun x -> _v855 <- Some x
    let v888 : string = match _v855 with Some x -> x | None -> failwith "base.run_target / _v855=None"
    let v889 : string = method27()
    let v890 : string = method28(v888, v889)
    let v891 : string = method31()
    let v892 : string = method28(v890, v891)
    let v893 : (System.Guid -> string) = _.ToString()
    let v894 : string = v893 v853
    let v895 : string = method28(v892, v894)
    v895 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v896 : bool = true
    let mutable _v896 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v897 : string = "std::env::temp_dir()"
    let v898 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr () v897 
    let v899 : string = "$0.display()"
    let v900 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v898 v899 
    let v901 : bool = true
    let mutable _v901 : std_string_String option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v902 : string = "format!(\"{}\", $0)"
    let v903 : std_string_String = Fable.Core.RustInterop.emitRustExpr v900 v902 
    v903 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v904 : string = "format!(\"{}\", $0)"
    let v905 : std_string_String = Fable.Core.RustInterop.emitRustExpr v900 v904 
    v905 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v906 : string = "format!(\"{}\", $0)"
    let v907 : std_string_String = Fable.Core.RustInterop.emitRustExpr v900 v906 
    v907 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v908 : std_string_String = null |> unbox<std_string_String>
    v908 
    #endif
#if FABLE_COMPILER_PYTHON
    let v909 : std_string_String = null |> unbox<std_string_String>
    v909 
    #endif
#else
    let v910 : std_string_String = null |> unbox<std_string_String>
    v910 
    #endif
    |> fun x -> _v901 <- Some x
    let v911 : std_string_String = match _v901 with Some x -> x | None -> failwith "base.run_target / _v901=None"
    let v912 : string = "fable_library_rust::String_::fromString($0)"
    let v913 : string = Fable.Core.RustInterop.emitRustExpr v911 v912 
    v913 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v914 : US4 = US4_1
    let v915 : US5 = US5_0(v914)
    let v916 : string = $"file_system.get_temp_path / target: {v915}"
    let v917 : string = failwith<string> v916
    v917 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v918 : string = null |> unbox<string>
    v918 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v919 : US4 = US4_0
    let v920 : US5 = US5_2(v919)
    let v921 : string = $"file_system.get_temp_path / target: {v920}"
    let v922 : string = failwith<string> v921
    v922 
    #endif
#if FABLE_COMPILER_PYTHON
    let v923 : US4 = US4_0
    let v924 : US5 = US5_3(v923)
    let v925 : string = $"file_system.get_temp_path / target: {v924}"
    let v926 : string = failwith<string> v925
    v926 
    #endif
#else
    let v927 : (unit -> string) = System.IO.Path.GetTempPath
    let v928 : string = v927 ()
    v928 
    #endif
    |> fun x -> _v896 <- Some x
    let v929 : string = match _v896 with Some x -> x | None -> failwith "base.run_target / _v896=None"
    let v930 : string = method27()
    let v931 : string = method28(v929, v930)
    let v932 : string = method31()
    let v933 : string = method28(v931, v932)
    let v934 : (System.Guid -> string) = _.ToString()
    let v935 : string = v934 v853
    let v936 : string = method28(v933, v935)
    v936 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v937 : string = null |> unbox<string>
    v937 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v938 : bool = true
    let mutable _v938 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v939 : string = "std::env::temp_dir()"
    let v940 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr () v939 
    let v941 : string = "$0.display()"
    let v942 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v940 v941 
    let v943 : bool = true
    let mutable _v943 : std_string_String option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v944 : string = "format!(\"{}\", $0)"
    let v945 : std_string_String = Fable.Core.RustInterop.emitRustExpr v942 v944 
    v945 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v946 : string = "format!(\"{}\", $0)"
    let v947 : std_string_String = Fable.Core.RustInterop.emitRustExpr v942 v946 
    v947 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v948 : string = "format!(\"{}\", $0)"
    let v949 : std_string_String = Fable.Core.RustInterop.emitRustExpr v942 v948 
    v949 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v950 : std_string_String = null |> unbox<std_string_String>
    v950 
    #endif
#if FABLE_COMPILER_PYTHON
    let v951 : std_string_String = null |> unbox<std_string_String>
    v951 
    #endif
#else
    let v952 : std_string_String = null |> unbox<std_string_String>
    v952 
    #endif
    |> fun x -> _v943 <- Some x
    let v953 : std_string_String = match _v943 with Some x -> x | None -> failwith "base.run_target / _v943=None"
    let v954 : string = "fable_library_rust::String_::fromString($0)"
    let v955 : string = Fable.Core.RustInterop.emitRustExpr v953 v954 
    v955 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v956 : US4 = US4_1
    let v957 : US5 = US5_0(v956)
    let v958 : string = $"file_system.get_temp_path / target: {v957}"
    let v959 : string = failwith<string> v958
    v959 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v960 : string = null |> unbox<string>
    v960 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v961 : US4 = US4_0
    let v962 : US5 = US5_2(v961)
    let v963 : string = $"file_system.get_temp_path / target: {v962}"
    let v964 : string = failwith<string> v963
    v964 
    #endif
#if FABLE_COMPILER_PYTHON
    let v965 : US4 = US4_0
    let v966 : US5 = US5_3(v965)
    let v967 : string = $"file_system.get_temp_path / target: {v966}"
    let v968 : string = failwith<string> v967
    v968 
    #endif
#else
    let v969 : (unit -> string) = System.IO.Path.GetTempPath
    let v970 : string = v969 ()
    v970 
    #endif
    |> fun x -> _v938 <- Some x
    let v971 : string = match _v938 with Some x -> x | None -> failwith "base.run_target / _v938=None"
    let v972 : string = method27()
    let v973 : string = method28(v971, v972)
    let v974 : string = method31()
    let v975 : string = method28(v973, v974)
    let v976 : (System.Guid -> string) = _.ToString()
    let v977 : string = v976 v853
    let v978 : string = method28(v975, v977)
    v978 
    #endif
#if FABLE_COMPILER_PYTHON
    let v979 : bool = true
    let mutable _v979 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v980 : string = "std::env::temp_dir()"
    let v981 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr () v980 
    let v982 : string = "$0.display()"
    let v983 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v981 v982 
    let v984 : bool = true
    let mutable _v984 : std_string_String option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v985 : string = "format!(\"{}\", $0)"
    let v986 : std_string_String = Fable.Core.RustInterop.emitRustExpr v983 v985 
    v986 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v987 : string = "format!(\"{}\", $0)"
    let v988 : std_string_String = Fable.Core.RustInterop.emitRustExpr v983 v987 
    v988 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v989 : string = "format!(\"{}\", $0)"
    let v990 : std_string_String = Fable.Core.RustInterop.emitRustExpr v983 v989 
    v990 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v991 : std_string_String = null |> unbox<std_string_String>
    v991 
    #endif
#if FABLE_COMPILER_PYTHON
    let v992 : std_string_String = null |> unbox<std_string_String>
    v992 
    #endif
#else
    let v993 : std_string_String = null |> unbox<std_string_String>
    v993 
    #endif
    |> fun x -> _v984 <- Some x
    let v994 : std_string_String = match _v984 with Some x -> x | None -> failwith "base.run_target / _v984=None"
    let v995 : string = "fable_library_rust::String_::fromString($0)"
    let v996 : string = Fable.Core.RustInterop.emitRustExpr v994 v995 
    v996 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v997 : US4 = US4_1
    let v998 : US5 = US5_0(v997)
    let v999 : string = $"file_system.get_temp_path / target: {v998}"
    let v1000 : string = failwith<string> v999
    v1000 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1001 : string = null |> unbox<string>
    v1001 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1002 : US4 = US4_0
    let v1003 : US5 = US5_2(v1002)
    let v1004 : string = $"file_system.get_temp_path / target: {v1003}"
    let v1005 : string = failwith<string> v1004
    v1005 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1006 : US4 = US4_0
    let v1007 : US5 = US5_3(v1006)
    let v1008 : string = $"file_system.get_temp_path / target: {v1007}"
    let v1009 : string = failwith<string> v1008
    v1009 
    #endif
#else
    let v1010 : (unit -> string) = System.IO.Path.GetTempPath
    let v1011 : string = v1010 ()
    v1011 
    #endif
    |> fun x -> _v979 <- Some x
    let v1012 : string = match _v979 with Some x -> x | None -> failwith "base.run_target / _v979=None"
    let v1013 : string = method27()
    let v1014 : string = method28(v1012, v1013)
    let v1015 : string = method31()
    let v1016 : string = method28(v1014, v1015)
    let v1017 : (System.Guid -> string) = _.ToString()
    let v1018 : string = v1017 v853
    let v1019 : string = method28(v1016, v1018)
    v1019 
    #endif
#else
    let v1020 : bool = true
    let mutable _v1020 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1021 : string = "std::env::temp_dir()"
    let v1022 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr () v1021 
    let v1023 : string = "$0.display()"
    let v1024 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v1022 v1023 
    let v1025 : bool = true
    let mutable _v1025 : std_string_String option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1026 : string = "format!(\"{}\", $0)"
    let v1027 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1024 v1026 
    v1027 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1028 : string = "format!(\"{}\", $0)"
    let v1029 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1024 v1028 
    v1029 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1030 : string = "format!(\"{}\", $0)"
    let v1031 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1024 v1030 
    v1031 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1032 : std_string_String = null |> unbox<std_string_String>
    v1032 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1033 : std_string_String = null |> unbox<std_string_String>
    v1033 
    #endif
#else
    let v1034 : std_string_String = null |> unbox<std_string_String>
    v1034 
    #endif
    |> fun x -> _v1025 <- Some x
    let v1035 : std_string_String = match _v1025 with Some x -> x | None -> failwith "base.run_target / _v1025=None"
    let v1036 : string = "fable_library_rust::String_::fromString($0)"
    let v1037 : string = Fable.Core.RustInterop.emitRustExpr v1035 v1036 
    v1037 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1038 : US4 = US4_1
    let v1039 : US5 = US5_0(v1038)
    let v1040 : string = $"file_system.get_temp_path / target: {v1039}"
    let v1041 : string = failwith<string> v1040
    v1041 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1042 : string = null |> unbox<string>
    v1042 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1043 : US4 = US4_0
    let v1044 : US5 = US5_2(v1043)
    let v1045 : string = $"file_system.get_temp_path / target: {v1044}"
    let v1046 : string = failwith<string> v1045
    v1046 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1047 : US4 = US4_0
    let v1048 : US5 = US5_3(v1047)
    let v1049 : string = $"file_system.get_temp_path / target: {v1048}"
    let v1050 : string = failwith<string> v1049
    v1050 
    #endif
#else
    let v1051 : (unit -> string) = System.IO.Path.GetTempPath
    let v1052 : string = v1051 ()
    v1052 
    #endif
    |> fun x -> _v1020 <- Some x
    let v1053 : string = match _v1020 with Some x -> x | None -> failwith "base.run_target / _v1020=None"
    let v1054 : string = method27()
    let v1055 : string = method28(v1053, v1054)
    let v1056 : string = method31()
    let v1057 : string = method28(v1055, v1056)
    let v1058 : (System.Guid -> string) = _.ToString()
    let v1059 : string = v1058 v853
    let v1060 : string = method28(v1057, v1059)
    v1060 
    #endif
    |> fun x -> _v854 <- Some x
    let v1061 : string = match _v854 with Some x -> x | None -> failwith "base.run_target / _v854=None"
    v1061 
    #endif
    |> fun x -> _v0 <- Some x
    let v1062 : string = match _v0 with Some x -> x | None -> failwith "base.run_target / _v0=None"
    let v1063 : System.IDisposable = method33(v1062)
    struct (v1062, v1063)
and closure48 () (v0 : string) : struct (string * System.IDisposable) =
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
    let v14 : bool = true
    let mutable _v14 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v15 : bool = true
    let mutable _v15 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v16 : string = "std::env::temp_dir()"
    let v17 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr () v16 
    let v18 : string = "$0.display()"
    let v19 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v17 v18 
    let v20 : bool = true
    let mutable _v20 : std_string_String option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v21 : string = "format!(\"{}\", $0)"
    let v22 : std_string_String = Fable.Core.RustInterop.emitRustExpr v19 v21 
    v22 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v23 : string = "format!(\"{}\", $0)"
    let v24 : std_string_String = Fable.Core.RustInterop.emitRustExpr v19 v23 
    v24 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v25 : string = "format!(\"{}\", $0)"
    let v26 : std_string_String = Fable.Core.RustInterop.emitRustExpr v19 v25 
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
    |> fun x -> _v20 <- Some x
    let v30 : std_string_String = match _v20 with Some x -> x | None -> failwith "base.run_target / _v20=None"
    let v31 : string = "fable_library_rust::String_::fromString($0)"
    let v32 : string = Fable.Core.RustInterop.emitRustExpr v30 v31 
    v32 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v33 : US4 = US4_1
    let v34 : US5 = US5_0(v33)
    let v35 : string = $"file_system.get_temp_path / target: {v34}"
    let v36 : string = failwith<string> v35
    v36 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v37 : string = null |> unbox<string>
    v37 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v38 : US4 = US4_0
    let v39 : US5 = US5_2(v38)
    let v40 : string = $"file_system.get_temp_path / target: {v39}"
    let v41 : string = failwith<string> v40
    v41 
    #endif
#if FABLE_COMPILER_PYTHON
    let v42 : US4 = US4_0
    let v43 : US5 = US5_3(v42)
    let v44 : string = $"file_system.get_temp_path / target: {v43}"
    let v45 : string = failwith<string> v44
    v45 
    #endif
#else
    let v46 : (unit -> string) = System.IO.Path.GetTempPath
    let v47 : string = v46 ()
    v47 
    #endif
    |> fun x -> _v15 <- Some x
    let v48 : string = match _v15 with Some x -> x | None -> failwith "base.run_target / _v15=None"
    let v49 : string = method27()
    let v50 : string = method28(v48, v49)
    let v51 : string = method31()
    let v52 : string = method28(v50, v51)
    let v53 : (System.Guid -> string) = _.ToString()
    let v54 : string = v53 v13
    let v55 : string = method28(v52, v54)
    v55 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v56 : bool = true
    let mutable _v56 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v57 : string = "std::env::temp_dir()"
    let v58 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr () v57 
    let v59 : string = "$0.display()"
    let v60 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v58 v59 
    let v61 : bool = true
    let mutable _v61 : std_string_String option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v62 : string = "format!(\"{}\", $0)"
    let v63 : std_string_String = Fable.Core.RustInterop.emitRustExpr v60 v62 
    v63 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v64 : string = "format!(\"{}\", $0)"
    let v65 : std_string_String = Fable.Core.RustInterop.emitRustExpr v60 v64 
    v65 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v66 : string = "format!(\"{}\", $0)"
    let v67 : std_string_String = Fable.Core.RustInterop.emitRustExpr v60 v66 
    v67 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v68 : std_string_String = null |> unbox<std_string_String>
    v68 
    #endif
#if FABLE_COMPILER_PYTHON
    let v69 : std_string_String = null |> unbox<std_string_String>
    v69 
    #endif
#else
    let v70 : std_string_String = null |> unbox<std_string_String>
    v70 
    #endif
    |> fun x -> _v61 <- Some x
    let v71 : std_string_String = match _v61 with Some x -> x | None -> failwith "base.run_target / _v61=None"
    let v72 : string = "fable_library_rust::String_::fromString($0)"
    let v73 : string = Fable.Core.RustInterop.emitRustExpr v71 v72 
    v73 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v74 : US4 = US4_1
    let v75 : US5 = US5_0(v74)
    let v76 : string = $"file_system.get_temp_path / target: {v75}"
    let v77 : string = failwith<string> v76
    v77 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v78 : string = null |> unbox<string>
    v78 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v79 : US4 = US4_0
    let v80 : US5 = US5_2(v79)
    let v81 : string = $"file_system.get_temp_path / target: {v80}"
    let v82 : string = failwith<string> v81
    v82 
    #endif
#if FABLE_COMPILER_PYTHON
    let v83 : US4 = US4_0
    let v84 : US5 = US5_3(v83)
    let v85 : string = $"file_system.get_temp_path / target: {v84}"
    let v86 : string = failwith<string> v85
    v86 
    #endif
#else
    let v87 : (unit -> string) = System.IO.Path.GetTempPath
    let v88 : string = v87 ()
    v88 
    #endif
    |> fun x -> _v56 <- Some x
    let v89 : string = match _v56 with Some x -> x | None -> failwith "base.run_target / _v56=None"
    let v90 : string = method27()
    let v91 : string = method28(v89, v90)
    let v92 : string = method31()
    let v93 : string = method28(v91, v92)
    let v94 : (System.Guid -> string) = _.ToString()
    let v95 : string = v94 v13
    let v96 : string = method28(v93, v95)
    v96 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v97 : string = null |> unbox<string>
    v97 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v98 : bool = true
    let mutable _v98 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v99 : string = "std::env::temp_dir()"
    let v100 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr () v99 
    let v101 : string = "$0.display()"
    let v102 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v100 v101 
    let v103 : bool = true
    let mutable _v103 : std_string_String option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v104 : string = "format!(\"{}\", $0)"
    let v105 : std_string_String = Fable.Core.RustInterop.emitRustExpr v102 v104 
    v105 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v106 : string = "format!(\"{}\", $0)"
    let v107 : std_string_String = Fable.Core.RustInterop.emitRustExpr v102 v106 
    v107 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v108 : string = "format!(\"{}\", $0)"
    let v109 : std_string_String = Fable.Core.RustInterop.emitRustExpr v102 v108 
    v109 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v110 : std_string_String = null |> unbox<std_string_String>
    v110 
    #endif
#if FABLE_COMPILER_PYTHON
    let v111 : std_string_String = null |> unbox<std_string_String>
    v111 
    #endif
#else
    let v112 : std_string_String = null |> unbox<std_string_String>
    v112 
    #endif
    |> fun x -> _v103 <- Some x
    let v113 : std_string_String = match _v103 with Some x -> x | None -> failwith "base.run_target / _v103=None"
    let v114 : string = "fable_library_rust::String_::fromString($0)"
    let v115 : string = Fable.Core.RustInterop.emitRustExpr v113 v114 
    v115 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v116 : US4 = US4_1
    let v117 : US5 = US5_0(v116)
    let v118 : string = $"file_system.get_temp_path / target: {v117}"
    let v119 : string = failwith<string> v118
    v119 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v120 : string = null |> unbox<string>
    v120 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v121 : US4 = US4_0
    let v122 : US5 = US5_2(v121)
    let v123 : string = $"file_system.get_temp_path / target: {v122}"
    let v124 : string = failwith<string> v123
    v124 
    #endif
#if FABLE_COMPILER_PYTHON
    let v125 : US4 = US4_0
    let v126 : US5 = US5_3(v125)
    let v127 : string = $"file_system.get_temp_path / target: {v126}"
    let v128 : string = failwith<string> v127
    v128 
    #endif
#else
    let v129 : (unit -> string) = System.IO.Path.GetTempPath
    let v130 : string = v129 ()
    v130 
    #endif
    |> fun x -> _v98 <- Some x
    let v131 : string = match _v98 with Some x -> x | None -> failwith "base.run_target / _v98=None"
    let v132 : string = method27()
    let v133 : string = method28(v131, v132)
    let v134 : string = method31()
    let v135 : string = method28(v133, v134)
    let v136 : (System.Guid -> string) = _.ToString()
    let v137 : string = v136 v13
    let v138 : string = method28(v135, v137)
    v138 
    #endif
#if FABLE_COMPILER_PYTHON
    let v139 : bool = true
    let mutable _v139 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v140 : string = "std::env::temp_dir()"
    let v141 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr () v140 
    let v142 : string = "$0.display()"
    let v143 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v141 v142 
    let v144 : bool = true
    let mutable _v144 : std_string_String option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v145 : string = "format!(\"{}\", $0)"
    let v146 : std_string_String = Fable.Core.RustInterop.emitRustExpr v143 v145 
    v146 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v147 : string = "format!(\"{}\", $0)"
    let v148 : std_string_String = Fable.Core.RustInterop.emitRustExpr v143 v147 
    v148 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v149 : string = "format!(\"{}\", $0)"
    let v150 : std_string_String = Fable.Core.RustInterop.emitRustExpr v143 v149 
    v150 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v151 : std_string_String = null |> unbox<std_string_String>
    v151 
    #endif
#if FABLE_COMPILER_PYTHON
    let v152 : std_string_String = null |> unbox<std_string_String>
    v152 
    #endif
#else
    let v153 : std_string_String = null |> unbox<std_string_String>
    v153 
    #endif
    |> fun x -> _v144 <- Some x
    let v154 : std_string_String = match _v144 with Some x -> x | None -> failwith "base.run_target / _v144=None"
    let v155 : string = "fable_library_rust::String_::fromString($0)"
    let v156 : string = Fable.Core.RustInterop.emitRustExpr v154 v155 
    v156 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v157 : US4 = US4_1
    let v158 : US5 = US5_0(v157)
    let v159 : string = $"file_system.get_temp_path / target: {v158}"
    let v160 : string = failwith<string> v159
    v160 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v161 : string = null |> unbox<string>
    v161 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v162 : US4 = US4_0
    let v163 : US5 = US5_2(v162)
    let v164 : string = $"file_system.get_temp_path / target: {v163}"
    let v165 : string = failwith<string> v164
    v165 
    #endif
#if FABLE_COMPILER_PYTHON
    let v166 : US4 = US4_0
    let v167 : US5 = US5_3(v166)
    let v168 : string = $"file_system.get_temp_path / target: {v167}"
    let v169 : string = failwith<string> v168
    v169 
    #endif
#else
    let v170 : (unit -> string) = System.IO.Path.GetTempPath
    let v171 : string = v170 ()
    v171 
    #endif
    |> fun x -> _v139 <- Some x
    let v172 : string = match _v139 with Some x -> x | None -> failwith "base.run_target / _v139=None"
    let v173 : string = method27()
    let v174 : string = method28(v172, v173)
    let v175 : string = method31()
    let v176 : string = method28(v174, v175)
    let v177 : (System.Guid -> string) = _.ToString()
    let v178 : string = v177 v13
    let v179 : string = method28(v176, v178)
    v179 
    #endif
#else
    let v180 : bool = true
    let mutable _v180 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v181 : string = "std::env::temp_dir()"
    let v182 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr () v181 
    let v183 : string = "$0.display()"
    let v184 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v182 v183 
    let v185 : bool = true
    let mutable _v185 : std_string_String option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v186 : string = "format!(\"{}\", $0)"
    let v187 : std_string_String = Fable.Core.RustInterop.emitRustExpr v184 v186 
    v187 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v188 : string = "format!(\"{}\", $0)"
    let v189 : std_string_String = Fable.Core.RustInterop.emitRustExpr v184 v188 
    v189 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v190 : string = "format!(\"{}\", $0)"
    let v191 : std_string_String = Fable.Core.RustInterop.emitRustExpr v184 v190 
    v191 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v192 : std_string_String = null |> unbox<std_string_String>
    v192 
    #endif
#if FABLE_COMPILER_PYTHON
    let v193 : std_string_String = null |> unbox<std_string_String>
    v193 
    #endif
#else
    let v194 : std_string_String = null |> unbox<std_string_String>
    v194 
    #endif
    |> fun x -> _v185 <- Some x
    let v195 : std_string_String = match _v185 with Some x -> x | None -> failwith "base.run_target / _v185=None"
    let v196 : string = "fable_library_rust::String_::fromString($0)"
    let v197 : string = Fable.Core.RustInterop.emitRustExpr v195 v196 
    v197 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v198 : US4 = US4_1
    let v199 : US5 = US5_0(v198)
    let v200 : string = $"file_system.get_temp_path / target: {v199}"
    let v201 : string = failwith<string> v200
    v201 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v202 : string = null |> unbox<string>
    v202 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v203 : US4 = US4_0
    let v204 : US5 = US5_2(v203)
    let v205 : string = $"file_system.get_temp_path / target: {v204}"
    let v206 : string = failwith<string> v205
    v206 
    #endif
#if FABLE_COMPILER_PYTHON
    let v207 : US4 = US4_0
    let v208 : US5 = US5_3(v207)
    let v209 : string = $"file_system.get_temp_path / target: {v208}"
    let v210 : string = failwith<string> v209
    v210 
    #endif
#else
    let v211 : (unit -> string) = System.IO.Path.GetTempPath
    let v212 : string = v211 ()
    v212 
    #endif
    |> fun x -> _v180 <- Some x
    let v213 : string = match _v180 with Some x -> x | None -> failwith "base.run_target / _v180=None"
    let v214 : string = method27()
    let v215 : string = method28(v213, v214)
    let v216 : string = method31()
    let v217 : string = method28(v215, v216)
    let v218 : (System.Guid -> string) = _.ToString()
    let v219 : string = v218 v13
    let v220 : string = method28(v217, v219)
    v220 
    #endif
    |> fun x -> _v14 <- Some x
    let v221 : string = match _v14 with Some x -> x | None -> failwith "base.run_target / _v14=None"
    let v222 : System.IDisposable = method33(v221)
    struct (v221, v222)
and closure49 () () : string =
    let v0 : string = __SOURCE_DIRECTORY__
    v0
and closure53 () (v0 : string) : bool =
    method16(v0)
and closure54 () (v0 : string) : bool =
    method7(v0)
and method42 (v0 : string) : string option =
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
and closure55 () (v0 : string) : string option =
    method42(v0)
and method41 () : (string -> string option) =
    closure55()
and method43 (v0 : string, v1 : bool, v2 : string, v3 : string) : string =
    let v4 : string = method28(v3, v0)
    let v7 : (string -> bool) =
        if v1 then
            closure53()
        else
            closure54()
    let v8 : bool = v7 v4
    if v8 then
        v3
    else
        let v9 : (string -> string option) = method41()
        let v10 : string option = v9 v3
        let v11 : US3 option = None
        let _v11 = ref v11 
        match v10 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v12 : string = x
        let v13 : US3 = US3_0(v12)
        v13 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v11.Value <- x
        let v14 : US3 option = _v11.Value 
        let v15 : US3 = US3_1
        let v16 : US3 = v14 |> Option.defaultValue v15 
        match v16 with
        | US3_1 -> (* None *)
            let v19 : string = $"""No parent for {if v1 then "file" else "dir"} '{v0}' at '{v2}' (until '{v3}')"""
            failwith<string> v19
        | US3_0(v17) -> (* Some *)
            method43(v0, v1, v2, v17)
and method40 (v0 : string, v1 : bool, v2 : string) : string =
    let v3 : string = method28(v2, v0)
    let v6 : (string -> bool) =
        if v1 then
            closure53()
        else
            closure54()
    let v7 : bool = v6 v3
    if v7 then
        v2
    else
        let v8 : (string -> string option) = method41()
        let v9 : string option = v8 v2
        let v10 : US3 option = None
        let _v10 = ref v10 
        match v9 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v11 : string = x
        let v12 : US3 = US3_0(v11)
        v12 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v10.Value <- x
        let v13 : US3 option = _v10.Value 
        let v14 : US3 = US3_1
        let v15 : US3 = v13 |> Option.defaultValue v14 
        match v15 with
        | US3_1 -> (* None *)
            let v18 : string = $"""No parent for {if v1 then "file" else "dir"} '{v0}' at '{v2}' (until '{v2}')"""
            failwith<string> v18
        | US3_0(v16) -> (* Some *)
            method43(v0, v1, v2, v16)
and closure52 (v0 : string, v1 : bool) (v2 : string) : string =
    method40(v0, v1, v2)
and closure51 (v0 : string) (v1 : bool) : (string -> string) =
    closure52(v0, v1)
and closure50 () (v0 : string) : (bool -> (string -> string)) =
    closure51(v0)
and method44 () : string =
    let v0 : string = ""
    v0
and method45 (v0 : string) : string =
    v0
and method46 () : string =
    let v0 : string = "^\\\\\\\\\\?\\\\"
    v0
and closure56 () (v0 : string) : string =
    let v1 : string = method44()
    let v2 : bool = true
    let mutable _v2 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : string = method45(v0)
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
    let v19 : string = method46()
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
and closure57 () (v0 : string) : string =
    let v1 : (char []) = [|'/'|]
    let v2 : string = v0.TrimStart v1 
    let v3 : string = $"file:///{v2}"
    v3
and method48 (v0 : string, v1 : string, v2 : string) : string =
    let v3 : string = method28(v2, v0)
    let v4 : bool = method7(v3)
    if v4 then
        v2
    else
        let v5 : (string -> string option) = method41()
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
            method48(v0, v1, v13)
and method47 (v0 : string, v1 : string) : string =
    let v2 : string = method28(v1, v0)
    let v3 : bool = method7(v2)
    if v3 then
        v1
    else
        let v4 : (string -> string option) = method41()
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
            method48(v0, v1, v12)
and closure58 () () : string =
    let v0 : string = __SOURCE_DIRECTORY__
    let v1 : string = "polyglot"
    let v2 : string = ".paket"
    let v3 : string = method28(v1, v2)
    let v4 : string = method47(v3, v0)
    method28(v4, v1)
and method49 (v0 : string) : unit =
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
    let v2 : string = method31()
    let v3 : System.DateTime = System.DateTime.Now
    let v4 : (unit -> System.Guid) = System.Guid.NewGuid
    let v5 : System.Guid = v4 ()
    let v6 : System.Guid = method21(v5, v3)
    let v7 : string = $"{v2}_{v6}.txt"
    let v8 : string = __SOURCE_DIRECTORY__
    let v9 : string = "polyglot"
    let v10 : string = ".paket"
    let v11 : string = method28(v9, v10)
    let v12 : string = method47(v11, v8)
    let v13 : string = method28(v12, v9)
    let v14 : string = "target/trace"
    let v15 : string = method28(v13, v14)
    let v16 : bool = true
    let mutable _v16 : System.IO.DirectoryInfo option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v17 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    v17 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v18 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    v18 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v19 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    v19 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v20 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    v20 
    #endif
#if FABLE_COMPILER_PYTHON
    let v21 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    v21 
    #endif
#else
    let v22 : (string -> System.IO.DirectoryInfo) = System.IO.Directory.CreateDirectory
    let v23 : System.IO.DirectoryInfo = v22 v15
    v23 
    #endif
    |> fun x -> _v16 <- Some x
    let v24 : System.IO.DirectoryInfo = match _v16 with Some x -> x | None -> failwith "base.run_target / _v16=None"
    let v25 : string = method28(v15, v7)
    let v26 : bool = true
    let mutable _v26 : Async<unit> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v27 : Async<unit> = null |> unbox<Async<unit>>
    v27 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v28 : Async<unit> = null |> unbox<Async<unit>>
    v28 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v29 : Async<unit> = null |> unbox<Async<unit>>
    v29 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v30 : Async<unit> = null |> unbox<Async<unit>>
    v30 
    #endif
#if FABLE_COMPILER_PYTHON
    let v31 : Async<unit> = null |> unbox<Async<unit>>
    v31 
    #endif
#else
    let v32 : System.Threading.Tasks.Task = System.IO.File.WriteAllTextAsync (v25, v0)
    let v33 : bool = true
    let mutable _v33 : Async<unit> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v34 : Async<unit> = null |> unbox<Async<unit>>
    v34 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v35 : Async<unit> = null |> unbox<Async<unit>>
    v35 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v36 : Async<unit> = null |> unbox<Async<unit>>
    v36 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v37 : Async<unit> = null |> unbox<Async<unit>>
    v37 
    #endif
#if FABLE_COMPILER_PYTHON
    let v38 : Async<unit> = null |> unbox<Async<unit>>
    v38 
    #endif
#else
    let v39 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
    let v40 : Async<unit> = v39 v32
    v40 
    #endif
    |> fun x -> _v33 <- Some x
    let v41 : Async<unit> = match _v33 with Some x -> x | None -> failwith "base.run_target / _v33=None"
    v41 
    #endif
    |> fun x -> _v26 <- Some x
    let v42 : Async<unit> = match _v26 with Some x -> x | None -> failwith "base.run_target / _v26=None"
    let v43 : bool = true
    let mutable _v43 : unit option = None 
    
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
    let v44 : (Async<unit> -> unit) = Async.RunSynchronously
    v44 v42
    () 
    #endif
    |> fun x -> _v43 <- Some x
    match _v43 with Some x -> x | None -> failwith "base.run_target / _v43=None"
    with ex ->
    let v45 : exn = ex
    let v46 : string = $"file_system.trace_file / ex: %A{v45}"
    method49(v46)
    (*
    *)
    () 
    #endif
    |> fun x -> _v1 <- Some x
    match _v1 with Some x -> x | None -> failwith "base.run_target / _v1=None"
    ()
and closure60 () (v0 : string) : unit =
    method49(v0)
and closure59 () (v0 : bool) : unit =
    let v1 : (US0 -> struct (Mut0 * Mut1 * Mut2 * int64 option * Mut3)) = closure0()
    let v2 : US0 = US0_0
    if State.trace_state.IsNone then State.trace_state <- v1 v2 |> Some
    let struct (v3 : Mut0, v4 : Mut1, v5 : Mut2, v6 : int64 option, v7 : Mut3) = State.trace_state.Value
    let v10 : (string -> unit) =
        if v0 then
            closure60()
        else
            closure1()
    v7.l0 <- v10
    ()
and closure62 (v0 : string) (v1 : string) : string =
    method28(v0, v1)
and closure61 () (v0 : string) : (string -> string) =
    closure62(v0)
let v0 : (US0 -> struct (Mut0 * Mut1 * Mut2 * int64 option * Mut3)) = closure0()
let v1 : US0 = US0_0
if State.trace_state.IsNone then State.trace_state <- v0 v1 |> Some
let v2 : (string -> Async<int64>) = closure2()
let delete_directory_async x = v2 x
let v3 : (US6 -> (string -> Async<int64>)) = closure8()
let wait_for_file_access x = v3 x
let v4 : (string -> Async<int64>) = closure12()
let wait_for_file_access_read x = v4 x
let v5 : (string -> Async<string>) = closure13()
let read_all_text_async x = v5 x
let v6 : (string -> (string -> Async<bool>)) = closure14()
let file_exists_content x = v6 x
let v7 : (string -> (string -> Async<unit>)) = closure16()
let write_all_text_async x = v7 x
let v8 : (string -> (string -> Async<unit>)) = closure18()
let write_all_text_exists x = v8 x
let v9 : (string -> Async<int64>) = closure20()
let delete_file_async x = v9 x
let v10 : (string -> (string -> Async<int64>)) = closure23()
let move_file_async x = v10 x
let v11 : (string -> Async<string option>) = closure27()
let read_all_text_retry_async x = v11 x
let v12 : (unit -> string) = closure35()
let create_temp_path () = v12 ()
let v13 : (unit -> struct (string * System.IDisposable)) = closure36()
let create_temp_dir () = v13 ()
let v14 : (string -> struct (string * System.IDisposable)) = closure48()
let create_temp_dir' x = v14 x
let v15 : (unit -> string) = closure49()
let get_source_directory () = v15 ()
let v16 : (string -> (bool -> (string -> string))) = closure50()
let find_parent x = v16 x
let v17 : (string -> string) = closure56()
let normalize_path x = v17 x
let v18 : (string -> string) = closure57()
let new_file_uri x = v18 x
let v19 : (unit -> string) = closure58()
let get_workspace_root () = v19 ()
let v20 : (bool -> unit) = closure59()
let init_trace_file x = v20 x
let v21 : (string -> (string -> string)) = closure61()
let (</>) x = v21 x
()
