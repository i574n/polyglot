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
[<Fable.Core.Erase; Fable.Core.Emit("regex::Captures")>]
#endif
type regex_Captures = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("regex::CaptureMatches")>]
#endif
type regex_CaptureMatches = class end
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
[<Fable.Core.Erase; Fable.Core.Emit("encoding_rs_io::DecodeReaderBytes<$0, $1>")>]
#endif
type encoding_rs_io_DecodeReaderBytes<'T, 'U> = class end
module State = let mutable trace_state = None
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
and [<Struct>] US3 =
    | US3_0
    | US3_1
    | US3_2
and [<Struct>] US4 =
    | US4_0
    | US4_1
    | US4_2
    | US4_3
    | US4_4
and [<Struct>] US2 =
    | US2_0 of f0_0 : US3 * f0_1 : US4
    | US2_1
and [<Struct>] US5 =
    | US5_0 of f0_0 : int64
    | US5_1 of f1_0 : exn
and [<Struct>] US6 =
    | US6_0 of f0_0 : int64
    | US6_1 of f1_0 : exn
and [<Struct>] US7 =
    | US7_0 of f0_0 : chrono_DateTime<chrono_Utc>
    | US7_1
and [<Struct>] US8 =
    | US8_0 of f0_0 : string
    | US8_1
and [<Struct>] US9 =
    | US9_0
    | US9_1 of f1_0 : std_string_String
let rec closure1 () (v0 : string) : unit =
    ()
and method0 () : string =
    let v0 : string = ""
    v0
and method1 () : string =
    let v0 : string = "AUTOMATION"
    v0
and closure0 () (v0 : US0) : struct (Mut0 * Mut1 * Mut2 * int64 option * Mut3) =
    let v1 : Mut1 = {l0 = true} : Mut1
    let v2 : Mut0 = {l0 = 0L} : Mut0
    let v3 : Mut2 = {l0 = v0} : Mut2
    let v4 : (string -> unit) = closure1()
    let v5 : Mut3 = {l0 = v4} : Mut3
    let v6 : bool = true
    let mutable _v6 : int64 option option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v7 : bool = true
    let mutable _v7 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v8 : string = "std::env::var(&*$0)"
    let v9 : string = "AUTOMATION"
    let v10 : Result<std_string_String, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr v9 v8
    let v11 : string = "true; let _result = $0.map(|x| { //"
    let v12 : bool = Fable.Core.RustInterop.emitRustExpr v10 v11
    let v13 : string = "x"
    let v14 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v13
    let v15 : string = "fable_library_rust::String_::fromString($0)"
    let v16 : string = Fable.Core.RustInterop.emitRustExpr v14 v15
    let v17 : string = "true; $0 })"
    let v18 : bool = Fable.Core.RustInterop.emitRustExpr v16 v17
    let v19 : string = "_result"
    let v20 : Result<string, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr () v19
    let v21 : string = method0()
    let v22 : string = "$0.unwrap_or($1)"
    let v23 : string = Fable.Core.RustInterop.emitRustExpr struct (v20, v21) v22
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
    let v28 : string = method1()
    let v29 : (string -> string) = System.Environment.GetEnvironmentVariable
    let v30 : string = v29 v28
    v30 
    #endif
    |> fun x -> _v7 <- Some x
    let v31 : string = _v7.Value
    let v33 : bool = v31 = "True"
    let v39 : US1 =
        if v33 then
            let v34 : System.DateTime = System.DateTime.Now
            let v35 : (System.DateTime -> int64) = _.Ticks
            let v36 : int64 = v35 v34
            US1_0(v36)
        else
            US1_1
    let v44 : int64 option =
        match v39 with
        | US1_1 -> (* None *)
            let v42 : int64 option = None
            v42
        | US1_0(v40) -> (* Some *)
            let v41 : int64 option = Some v40 
            v41
    v44 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v45 : int64 option = None
    v45 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v46 : int64 option = None
    v46 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v47 : int64 option = None
    v47 
    #endif
#if FABLE_COMPILER_PYTHON
    let v48 : int64 option = None
    v48 
    #endif
#else
    let v49 : bool = true
    let mutable _v49 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v50 : string = "std::env::var(&*$0)"
    let v51 : Result<std_string_String, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr v9 v50
    let v52 : string = "true; let _result = $0.map(|x| { //"
    let v53 : bool = Fable.Core.RustInterop.emitRustExpr v51 v52
    let v54 : string = "x"
    let v55 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v54
    let v56 : string = "fable_library_rust::String_::fromString($0)"
    let v57 : string = Fable.Core.RustInterop.emitRustExpr v55 v56
    let v58 : string = "true; $0 })"
    let v59 : bool = Fable.Core.RustInterop.emitRustExpr v57 v58
    let v60 : string = "_result"
    let v61 : Result<string, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr () v60
    let v62 : string = method0()
    let v63 : string = "$0.unwrap_or($1)"
    let v64 : string = Fable.Core.RustInterop.emitRustExpr struct (v61, v62) v63
    v64 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v65 : string = null |> unbox<string>
    v65 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v66 : string = null |> unbox<string>
    v66 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v67 : string = null |> unbox<string>
    v67 
    #endif
#if FABLE_COMPILER_PYTHON
    let v68 : string = null |> unbox<string>
    v68 
    #endif
#else
    let v69 : string = method1()
    let v70 : (string -> string) = System.Environment.GetEnvironmentVariable
    let v71 : string = v70 v69
    v71 
    #endif
    |> fun x -> _v49 <- Some x
    let v72 : string = _v49.Value
    let v74 : bool = v72 = "True"
    let v80 : US1 =
        if v74 then
            let v75 : System.DateTime = System.DateTime.Now
            let v76 : (System.DateTime -> int64) = _.Ticks
            let v77 : int64 = v76 v75
            US1_0(v77)
        else
            US1_1
    let v85 : int64 option =
        match v80 with
        | US1_1 -> (* None *)
            let v83 : int64 option = None
            v83
        | US1_0(v81) -> (* Some *)
            let v82 : int64 option = Some v81 
            v82
    v85 
    #endif
    |> fun x -> _v6 <- Some x
    let v86 : int64 option = _v6.Value
    struct (v2, v1, v3, v86, v5)
and method3 (v0 : string) : string =
    v0
and closure3 () () : string =
    let v0 : string = "file_system.delete_directory_async"
    v0
and closure5 () (v0 : string) : string =
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
    let v22 : string = null |> unbox<string>
    v22 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v23 : string = null |> unbox<string>
    v23 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v24 : string = null |> unbox<string>
    v24 
    #endif
#if FABLE_COMPILER_PYTHON
    let v25 : string = null |> unbox<string>
    v25 
    #endif
#else
    let v26 : (string -> string) = System.IO.Path.GetFileName
    let v27 : string = v26 v0
    v27 
    #endif
    |> fun x -> _v1 <- Some x
    let v28 : string = _v1.Value
    v28
and closure6 () () : string =
    let v0 : string = ""
    v0
and closure4 (v0 : string, v1 : string) () : string =
    let v2 : (string -> string) = closure5()
    let v3 : (unit -> string) = closure6()
    let v4 : string = $"path: {v0 |> v2} / ex: {v1} / {v3 ()}"
    v4
and method5 () : string =
    let v0 : string = ""
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
    let v34 : System.DateTime =
        match v16 with
        | US1_1 -> (* None *)
            let v32 : System.DateTime = System.DateTime.Now
            v32
        | US1_0(v17) -> (* Some *)
            let v18 : System.DateTime = System.DateTime.Now
            let v19 : (System.DateTime -> int64) = _.Ticks
            let v20 : int64 = v19 v18
            let v21 : int64 = v20 - v17
            let v22 : System.TimeSpan = System.TimeSpan v21 
            let v23 : (System.TimeSpan -> int32) = _.Hours
            let v24 : int32 = v23 v22
            let v25 : (System.TimeSpan -> int32) = _.Minutes
            let v26 : int32 = v25 v22
            let v27 : (System.TimeSpan -> int32) = _.Seconds
            let v28 : int32 = v27 v22
            let v29 : (System.TimeSpan -> int32) = _.Milliseconds
            let v30 : int32 = v29 v22
            let v31 : System.DateTime = System.DateTime (1, 1, 1, v24, v26, v28, v30)
            v31
    let v35 : string = "hh:mm:ss"
    let v36 : string = v34.ToString v35 
    v36 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v37 : string = method5()
    v37 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v38 : string = method5()
    v38 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v39 : string = method5()
    v39 
    #endif
#if FABLE_COMPILER_PYTHON
    let v40 : string = method5()
    v40 
    #endif
#else
    let v41 : US1 option = None
    let _v41 = ref v41 
    match v8 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v42 : int64 = x
    let v43 : US1 = US1_0(v42)
    v43 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v41.Value <- x
    let v44 : US1 option = _v41.Value 
    let v45 : US1 = US1_1
    let v46 : US1 = v44 |> Option.defaultValue v45 
    let v64 : System.DateTime =
        match v46 with
        | US1_1 -> (* None *)
            let v62 : System.DateTime = System.DateTime.Now
            v62
        | US1_0(v47) -> (* Some *)
            let v48 : System.DateTime = System.DateTime.Now
            let v49 : (System.DateTime -> int64) = _.Ticks
            let v50 : int64 = v49 v48
            let v51 : int64 = v50 - v47
            let v52 : System.TimeSpan = System.TimeSpan v51 
            let v53 : (System.TimeSpan -> int32) = _.Hours
            let v54 : int32 = v53 v52
            let v55 : (System.TimeSpan -> int32) = _.Minutes
            let v56 : int32 = v55 v52
            let v57 : (System.TimeSpan -> int32) = _.Seconds
            let v58 : int32 = v57 v52
            let v59 : (System.TimeSpan -> int32) = _.Milliseconds
            let v60 : int32 = v59 v52
            let v61 : System.DateTime = System.DateTime (1, 1, 1, v54, v56, v58, v60)
            v61
    let v65 : string = "HH:mm:ss"
    let v66 : string = v64.ToString v65 
    v66 
    #endif
    |> fun x -> _v10 <- Some x
    let v67 : string = _v10.Value
    let v68 : int64 = v5.l0
    let v78 : string =
        match v0 with
        | US0_4 -> (* Critical *)
            let v73 : string = "Critical"
            v73
        | US0_1 -> (* Debug *)
            let v70 : string = "Debug"
            v70
        | US0_2 -> (* Info *)
            let v71 : string = "Info"
            v71
        | US0_0 -> (* Verbose *)
            let v69 : string = "Verbose"
            v69
        | US0_3 -> (* Warning *)
            let v72 : string = "Warning"
            v72
    let v79 : string = v78.ToLower ()
    let v80 : string = v79.PadLeft (7, ' ')
    let v81 : bool = true
    let mutable _v81 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v96 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v90 : string = "inline_colorization::color_bright_red"
            let v91 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v90
            v91
        | US0_1 -> (* Debug *)
            let v84 : string = "inline_colorization::color_bright_blue"
            let v85 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v84
            v85
        | US0_2 -> (* Info *)
            let v86 : string = "inline_colorization::color_bright_green"
            let v87 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v86
            v87
        | US0_0 -> (* Verbose *)
            let v82 : string = "inline_colorization::color_bright_black"
            let v83 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v82
            v83
        | US0_3 -> (* Warning *)
            let v88 : string = "inline_colorization::color_yellow"
            let v89 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v88
            v89
    let v97 : string = "&*$0"
    let v98 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v80 v97
    let v99 : string = "inline_colorization::color_reset"
    let v100 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v99
    let v101 : string = "\"{v96}{v98}{v100}\""
    let v102 : string = @$"format!(" + v101 + ")"
    let v103 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v102
    let v104 : string = "fable_library_rust::String_::fromString($0)"
    let v105 : string = Fable.Core.RustInterop.emitRustExpr v103 v104
    v105 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v120 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v114 : string = "inline_colorization::color_bright_red"
            let v115 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v114
            v115
        | US0_1 -> (* Debug *)
            let v108 : string = "inline_colorization::color_bright_blue"
            let v109 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v108
            v109
        | US0_2 -> (* Info *)
            let v110 : string = "inline_colorization::color_bright_green"
            let v111 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v110
            v111
        | US0_0 -> (* Verbose *)
            let v106 : string = "inline_colorization::color_bright_black"
            let v107 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v106
            v107
        | US0_3 -> (* Warning *)
            let v112 : string = "inline_colorization::color_yellow"
            let v113 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v112
            v113
    let v121 : string = "&*$0"
    let v122 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v80 v121
    let v123 : string = "inline_colorization::color_reset"
    let v124 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v123
    let v125 : string = "\"{v120}{v122}{v124}\""
    let v126 : string = @$"format!(" + v125 + ")"
    let v127 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v126
    let v128 : string = "fable_library_rust::String_::fromString($0)"
    let v129 : string = Fable.Core.RustInterop.emitRustExpr v127 v128
    v129 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v144 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v138 : string = "inline_colorization::color_bright_red"
            let v139 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v138
            v139
        | US0_1 -> (* Debug *)
            let v132 : string = "inline_colorization::color_bright_blue"
            let v133 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v132
            v133
        | US0_2 -> (* Info *)
            let v134 : string = "inline_colorization::color_bright_green"
            let v135 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v134
            v135
        | US0_0 -> (* Verbose *)
            let v130 : string = "inline_colorization::color_bright_black"
            let v131 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v130
            v131
        | US0_3 -> (* Warning *)
            let v136 : string = "inline_colorization::color_yellow"
            let v137 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v136
            v137
    let v145 : string = "&*$0"
    let v146 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v80 v145
    let v147 : string = "inline_colorization::color_reset"
    let v148 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v147
    let v149 : string = "\"{v144}{v146}{v148}\""
    let v150 : string = @$"format!(" + v149 + ")"
    let v151 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v150
    let v152 : string = "fable_library_rust::String_::fromString($0)"
    let v153 : string = Fable.Core.RustInterop.emitRustExpr v151 v152
    v153 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    v80 
    #endif
#if FABLE_COMPILER_PYTHON
    v80 
    #endif
#else
    v80 
    #endif
    |> fun x -> _v81 <- Some x
    let v154 : string = _v81.Value
    let v155 : string = $"{v67} {v154} #{v68} %s{v1 ()} / %s{v2 ()}"
    let v156 : (char []) = [||]
    let v157 : string = v155.TrimStart v156
    let v158 : (char []) = [|' '; '/'|]
    let v159 : string = v157.TrimEnd v158
    v159
and method6 (v0 : US0, v1 : (unit -> string)) : unit =
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
        _v25.Value
        let v29 : (string -> unit) = v8.l0
        v29 v24
and method4 (v0 : US0, v1 : (unit -> string), v2 : (unit -> string)) : unit =
    let v3 : (unit -> string) = closure7(v0, v1, v2)
    method6(v0, v3)
and method2 (v0 : string, v1 : int64) : Async<int64> =
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
    let v10 : string = method3(v0)
    let v11 : bool = true
    let mutable _v11 : bool option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v12 : string = "&*$0"
    let v13 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v10 v12
    let v14 : string = "String::from($0)"
    let v15 : std_string_String = Fable.Core.RustInterop.emitRustExpr v13 v14
    let v16 : string = "std::path::PathBuf::from($0)"
    let v17 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v15 v16
    let v18 : string = "$0.exists()"
    let v19 : bool = Fable.Core.RustInterop.emitRustExpr v17 v18
    let v22 : bool =
        if v19 then
            let v20 : string = "$0.is_dir()"
            let v21 : bool = Fable.Core.RustInterop.emitRustExpr v17 v20
            v21
        else
            false
    v22 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v23 : bool = null |> unbox<bool>
    v23 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v24 : bool = null |> unbox<bool>
    v24 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v25 : string = "fs"
    let v26 : IFsExistsSync = Fable.Core.JsInterop.importAll v25
    let v27 : string = "$0.existsSync($1)"
    let v28 : bool = Fable.Core.JsInterop.emitJsExpr struct (v26, v10) v27
    v28 
    #endif
#if FABLE_COMPILER_PYTHON
    let v29 : bool = null |> unbox<bool>
    v29 
    #endif
#else
    let v30 : (string -> bool) = System.IO.Directory.Exists
    let v31 : bool = v30 v10
    v31 
    #endif
    |> fun x -> _v11 <- Some x
    let v32 : bool = _v11.Value
    if v32 then
        let v33 : string = "std::fs::remove_dir_all(&*$0).unwrap()"
        Fable.Core.RustInterop.emitRustExpr v10 v33
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
    |> fun x -> _v9 <- Some x
    _v9.Value
    return v1 
    with ex ->
    let v34 : exn = ex
    let v35 : int64 = v1 % 100L
    let v36 : bool = v35 = 0L
    if v36 then
        let v37 : bool = true
        let mutable _v37 : string option = None 
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v38 : string = $"%A{v34}"
        v38 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v39 : string = $"%A{v34}"
        v39 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v40 : string = $"%A{v34}"
        v40 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v41 : string = $"%A{v34}"
        v41 
        #endif
#if FABLE_COMPILER_PYTHON
        let v42 : string = $"%A{v34}"
        v42 
        #endif
#else
        let v43 : string = $"{v34.GetType ()}: {v34.Message}"
        v43 
        #endif
        |> fun x -> _v37 <- Some x
        let v44 : string = _v37.Value
        let v45 : US0 = US0_1
        let v46 : (unit -> string) = closure3()
        let v47 : (unit -> string) = closure4(v0, v44)
        method4(v45, v46, v47)
    let v48 : bool = true
    let mutable _v48 : Async<unit> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v49 : Async<unit> = null |> unbox<Async<unit>>
    v49 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v50 : Async<unit> = null |> unbox<Async<unit>>
    v50 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v51 : Async<unit> = null |> unbox<Async<unit>>
    v51 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v52 : Async<unit> = null |> unbox<Async<unit>>
    v52 
    #endif
#if FABLE_COMPILER_PYTHON
    let v53 : Async<unit> = null |> unbox<Async<unit>>
    v53 
    #endif
#else
    let v54 : (int32 -> Async<unit>) = Async.Sleep
    let v55 : Async<unit> = v54 10
    v55 
    #endif
    |> fun x -> _v48 <- Some x
    let v56 : Async<unit> = _v48.Value
    do! v56 
    let v57 : int64 = v1 + 1L
    let v58 : Async<int64> = method2(v0, v57)
    return! v58 
    (*
    let v59 : int64 = *)
    }
    |> fun x -> _v8 <- Some x
    let v60 : Async<int64> = _v8 |> Option.get
    v60 
    #endif
    |> fun x -> _v2 <- Some x
    let v61 : Async<int64> = _v2.Value
    v61
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
    let v8 : Async<int64> = method2(v0, v7)
    v8 
    #endif
    |> fun x -> _v1 <- Some x
    let v9 : Async<int64> = _v1.Value
    v9
and closure10 () () : string =
    let v0 : string = "file_system.wait_for_file_access"
    v0
and closure11 (v0 : string, v1 : int64, v2 : string) () : string =
    let v3 : (string -> string) = closure5()
    let v4 : (unit -> string) = closure6()
    let v5 : string = $"path: {v0 |> v3} / retry: {v1} / ex: {v2} / {v4 ()}"
    v5
and method7 (v0 : string, v1 : US4, v2 : US3, v3 : int64) : Async<int64> =
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
        | US3_0 -> (* AccessRead *)
            let v18 : System.IO.FileAccess = System.IO.FileAccess.Read
            v18
        | US3_2 -> (* AccessReadWrite *)
            let v20 : System.IO.FileAccess = System.IO.FileAccess.ReadWrite
            v20
        | US3_1 -> (* AccessWrite *)
            let v19 : System.IO.FileAccess = System.IO.FileAccess.ReadWrite
            v19
    let v33 : System.IO.FileShare =
        match v1 with
        | US4_4 -> (* ShareDelete *)
            let v28 : System.IO.FileShare = System.IO.FileShare.Delete
            v28
        | US4_0 -> (* ShareNone *)
            let v24 : System.IO.FileShare = System.IO.FileShare.None
            v24
        | US4_1 -> (* ShareRead *)
            let v25 : System.IO.FileShare = System.IO.FileShare.Read
            v25
        | US4_3 -> (* ShareReadWrite *)
            let v27 : System.IO.FileShare = System.IO.FileShare.ReadWrite
            v27
        | US4_2 -> (* ShareWrite *)
            let v26 : System.IO.FileShare = System.IO.FileShare.Write
            v26
    let v34 : System.IO.FileStream = new System.IO.FileStream (v0, v17, v23, v33)
    v34 
    #endif
    |> fun x -> _v11 <- Some x
    let v35 : System.IO.FileStream = _v11.Value
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
        let v49 : string = _v42.Value
        let v50 : US0 = US0_1
        let v51 : (unit -> string) = closure10()
        let v52 : (unit -> string) = closure11(v0, v3, v49)
        method4(v50, v51, v52)
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
    let v61 : Async<unit> = _v53.Value
    do! v61 
    let v62 : int64 = v3 + 1L
    let v63 : Async<int64> = method7(v0, v1, v2, v62)
    return! v63 
    (*
    let v64 : int64 = *)
    }
    |> fun x -> _v10 <- Some x
    let v65 : Async<int64> = _v10 |> Option.get
    v65 
    #endif
    |> fun x -> _v4 <- Some x
    let v66 : Async<int64> = _v4.Value
    v66
and closure9 (v0 : US2) (v1 : string) : Async<int64> =
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
    let struct (v14 : US3, v15 : US4) =
        match v0 with
        | US2_1 -> (* None *)
            let v10 : US3 = US3_2
            let v11 : US4 = US4_1
            struct (v10, v11)
        | US2_0(v8, v9) -> (* Some *)
            struct (v8, v9)
    let v16 : int64 = 0L
    let v17 : Async<int64> = method7(v1, v15, v14, v16)
    v17 
    #endif
    |> fun x -> _v2 <- Some x
    let v18 : Async<int64> = _v2.Value
    v18
and closure8 () (v0 : US2) : (string -> Async<int64>) =
    closure9(v0)
and method8 (v0 : string, v1 : int64) : Async<int64> =
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
    let v19 : System.IO.FileStream = _v9.Value
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
        let v33 : string = _v26.Value
        let v34 : US0 = US0_1
        let v35 : (unit -> string) = closure10()
        let v36 : (unit -> string) = closure11(v0, v1, v33)
        method4(v34, v35, v36)
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
    let v45 : Async<unit> = _v37.Value
    do! v45 
    let v46 : int64 = v1 + 1L
    let v47 : Async<int64> = method8(v0, v46)
    return! v47 
    (*
    let v48 : int64 = *)
    }
    |> fun x -> _v8 <- Some x
    let v49 : Async<int64> = _v8 |> Option.get
    v49 
    #endif
    |> fun x -> _v2 <- Some x
    let v50 : Async<int64> = _v2.Value
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
    let v8 : Async<int64> = method8(v0, v7)
    v8 
    #endif
    |> fun x -> _v1 <- Some x
    let v9 : Async<int64> = _v1.Value
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
    let v17 : Async<string> = _v9.Value
    v17 
    #endif
    |> fun x -> _v1 <- Some x
    let v18 : Async<string> = _v1.Value
    v18
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
    let v15 : bool = true
    let mutable _v15 : bool option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v16 : string = "&*$0"
    let v17 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v16
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
#if FABLE_COMPILER_TYPESCRIPT
    let v29 : string = "fs"
    let v30 : IFsExistsSync = Fable.Core.JsInterop.importAll v29
    let v31 : string = "$0.existsSync($1)"
    let v32 : bool = Fable.Core.JsInterop.emitJsExpr struct (v30, v0) v31
    v32 
    #endif
#if FABLE_COMPILER_PYTHON
    let v33 : bool = null |> unbox<bool>
    v33 
    #endif
#else
    let v34 : (string -> bool) = System.IO.File.Exists
    let v35 : bool = v34 v0
    v35 
    #endif
    |> fun x -> _v15 <- Some x
    let v36 : bool = _v15.Value
    let v37 : bool = v36 = false
    if v37 then
        return false 
        (*
        ()
    else
        *) else
        let v38 : bool = true
        let mutable _v38 : Async<string> option = None 
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v39 : Async<string> = null |> unbox<Async<string>>
        v39 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v40 : Async<string> = null |> unbox<Async<string>>
        v40 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v41 : Async<string> = null |> unbox<Async<string>>
        v41 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v42 : Async<string> = null |> unbox<Async<string>>
        v42 
        #endif
#if FABLE_COMPILER_PYTHON
        let v43 : Async<string> = null |> unbox<Async<string>>
        v43 
        #endif
#else
        let v44 : (string -> System.Threading.Tasks.Task<string>) = System.IO.File.ReadAllTextAsync
        let v45 : System.Threading.Tasks.Task<string> = v44 v0
        let v46 : bool = true
        let mutable _v46 : Async<string> option = None 
        
#if FABLE_COMPILER || WASM || CONTRACT
        
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
#if FABLE_COMPILER_TYPESCRIPT
        let v50 : Async<string> = null |> unbox<Async<string>>
        v50 
        #endif
#if FABLE_COMPILER_PYTHON
        let v51 : Async<string> = null |> unbox<Async<string>>
        v51 
        #endif
#else
        let v52 : (System.Threading.Tasks.Task<string> -> Async<string>) = Async.AwaitTask
        let v53 : Async<string> = v52 v45
        v53 
        #endif
        |> fun x -> _v46 <- Some x
        let v54 : Async<string> = _v46.Value
        v54 
        #endif
        |> fun x -> _v38 <- Some x
        let v55 : Async<string> = _v38.Value
        let! v55 = v55 
        let v56 : string = v55 
        let v57 : bool = v1 = v56
        return v57 
        (*
        ()
    *)
    }
    |> fun x -> _v14 <- Some x
    let v58 : Async<bool> = _v14 |> Option.get
    v58 
    #endif
    |> fun x -> _v8 <- Some x
    let v59 : Async<bool> = _v8.Value
    v59 
    #endif
    |> fun x -> _v2 <- Some x
    let v60 : Async<bool> = _v2.Value
    v60
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
    let v17 : Async<unit> = _v9.Value
    v17 
    #endif
    |> fun x -> _v2 <- Some x
    let v18 : Async<unit> = _v2.Value
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
    let v22 : bool = true
    let mutable _v22 : bool option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v23 : string = "&*$0"
    let v24 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v23
    let v25 : string = "String::from($0)"
    let v26 : std_string_String = Fable.Core.RustInterop.emitRustExpr v24 v25
    let v27 : string = "std::path::PathBuf::from($0)"
    let v28 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v26 v27
    let v29 : string = "$0.exists()"
    let v30 : bool = Fable.Core.RustInterop.emitRustExpr v28 v29
    let v33 : bool =
        if v30 then
            let v31 : string = "$0.is_file()"
            let v32 : bool = Fable.Core.RustInterop.emitRustExpr v28 v31
            v32
        else
            false
    v33 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v34 : bool = null |> unbox<bool>
    v34 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v35 : bool = null |> unbox<bool>
    v35 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v36 : string = "fs"
    let v37 : IFsExistsSync = Fable.Core.JsInterop.importAll v36
    let v38 : string = "$0.existsSync($1)"
    let v39 : bool = Fable.Core.JsInterop.emitJsExpr struct (v37, v0) v38
    v39 
    #endif
#if FABLE_COMPILER_PYTHON
    let v40 : bool = null |> unbox<bool>
    v40 
    #endif
#else
    let v41 : (string -> bool) = System.IO.File.Exists
    let v42 : bool = v41 v0
    v42 
    #endif
    |> fun x -> _v22 <- Some x
    let v43 : bool = _v22.Value
    let v44 : bool = v43 = false
    if v44 then
        return false 
        (*
        ()
    else
        *) else
        let v45 : bool = true
        let mutable _v45 : Async<string> option = None 
        
#if FABLE_COMPILER || WASM || CONTRACT
        
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
#if FABLE_COMPILER_TYPESCRIPT
        let v49 : Async<string> = null |> unbox<Async<string>>
        v49 
        #endif
#if FABLE_COMPILER_PYTHON
        let v50 : Async<string> = null |> unbox<Async<string>>
        v50 
        #endif
#else
        let v51 : (string -> System.Threading.Tasks.Task<string>) = System.IO.File.ReadAllTextAsync
        let v52 : System.Threading.Tasks.Task<string> = v51 v0
        let v53 : bool = true
        let mutable _v53 : Async<string> option = None 
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v54 : Async<string> = null |> unbox<Async<string>>
        v54 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v55 : Async<string> = null |> unbox<Async<string>>
        v55 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v56 : Async<string> = null |> unbox<Async<string>>
        v56 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v57 : Async<string> = null |> unbox<Async<string>>
        v57 
        #endif
#if FABLE_COMPILER_PYTHON
        let v58 : Async<string> = null |> unbox<Async<string>>
        v58 
        #endif
#else
        let v59 : (System.Threading.Tasks.Task<string> -> Async<string>) = Async.AwaitTask
        let v60 : Async<string> = v59 v52
        v60 
        #endif
        |> fun x -> _v53 <- Some x
        let v61 : Async<string> = _v53.Value
        v61 
        #endif
        |> fun x -> _v45 <- Some x
        let v62 : Async<string> = _v45.Value
        let! v62 = v62 
        let v63 : string = v62 
        let v64 : bool = v1 = v63
        return v64 
        (*
        ()
    *)
    }
    |> fun x -> _v21 <- Some x
    let v65 : Async<bool> = _v21 |> Option.get
    v65 
    #endif
    |> fun x -> _v15 <- Some x
    let v66 : Async<bool> = _v15.Value
    v66 
    #endif
    |> fun x -> _v9 <- Some x
    let v67 : Async<bool> = _v9.Value
    let! v67 = v67 
    let v68 : bool = v67 
    let v69 : bool = v68 = false
    if v69 then
        let v70 : bool = true
        let mutable _v70 : Async<unit> option = None 
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v71 : Async<unit> = null |> unbox<Async<unit>>
        v71 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v72 : Async<unit> = null |> unbox<Async<unit>>
        v72 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v73 : Async<unit> = null |> unbox<Async<unit>>
        v73 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v74 : Async<unit> = null |> unbox<Async<unit>>
        v74 
        #endif
#if FABLE_COMPILER_PYTHON
        let v75 : Async<unit> = null |> unbox<Async<unit>>
        v75 
        #endif
#else
        let v76 : System.Threading.Tasks.Task = System.IO.File.WriteAllTextAsync (v0, v1)
        let v77 : bool = true
        let mutable _v77 : Async<unit> option = None 
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v78 : Async<unit> = null |> unbox<Async<unit>>
        v78 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v79 : Async<unit> = null |> unbox<Async<unit>>
        v79 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v80 : Async<unit> = null |> unbox<Async<unit>>
        v80 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v81 : Async<unit> = null |> unbox<Async<unit>>
        v81 
        #endif
#if FABLE_COMPILER_PYTHON
        let v82 : Async<unit> = null |> unbox<Async<unit>>
        v82 
        #endif
#else
        let v83 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
        let v84 : Async<unit> = v83 v76
        v84 
        #endif
        |> fun x -> _v77 <- Some x
        let v85 : Async<unit> = _v77.Value
        v85 
        #endif
        |> fun x -> _v70 <- Some x
        let v86 : Async<unit> = _v70.Value
        do! v86 
        ()
    }
    |> fun x -> _v8 <- Some x
    let v87 : Async<unit> = _v8 |> Option.get
    v87 
    #endif
    |> fun x -> _v2 <- Some x
    let v88 : Async<unit> = _v2.Value
    v88
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
    let v9 : string = _v2.Value
    let v10 : (string -> string) = closure5()
    let v11 : (unit -> string) = closure6()
    let v12 : string = $"path: {v0 |> v10} / ex: {v9} / {v11 ()}"
    v12
and method9 (v0 : string, v1 : int64) : Async<int64> =
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
    let v10 : (string -> unit) = System.IO.File.Delete
    v10 v0
    () 
    #endif
    |> fun x -> _v9 <- Some x
    _v9.Value
    return v1 
    with ex ->
    let v11 : exn = ex
    let v12 : int64 = v1 % 100L
    let v13 : bool = v12 = 0L
    if v13 then
        let v14 : US0 = US0_3
        let v15 : (unit -> string) = closure21()
        let v16 : (unit -> string) = closure22(v0, v11)
        method4(v14, v15, v16)
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
    let v25 : Async<unit> = _v17.Value
    do! v25 
    let v26 : int64 = v1 + 1L
    let v27 : Async<int64> = method9(v0, v26)
    return! v27 
    (*
    let v28 : int64 = *)
    }
    |> fun x -> _v8 <- Some x
    let v29 : Async<int64> = _v8 |> Option.get
    v29 
    #endif
    |> fun x -> _v2 <- Some x
    let v30 : Async<int64> = _v2.Value
    v30
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
    let v8 : Async<int64> = method9(v0, v7)
    v8 
    #endif
    |> fun x -> _v1 <- Some x
    let v9 : Async<int64> = _v1.Value
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
    let v10 : string = _v3.Value
    let v11 : (string -> string) = closure5()
    let v12 : (unit -> string) = closure6()
    let v13 : string = $"old_path: {v1 |> v11} / new_path: {v0 |> v11} / ex: {v10} / {v12 ()}"
    v13
and method10 (v0 : string, v1 : string, v2 : int64) : Async<int64> =
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
    _v10.Value
    return v2 
    with ex ->
    let v11 : exn = ex
    let v12 : int64 = v2 % 100L
    let v13 : bool = v12 = 0L
    if v13 then
        let v14 : US0 = US0_3
        let v15 : (unit -> string) = closure25()
        let v16 : (unit -> string) = closure26(v0, v1, v11)
        method4(v14, v15, v16)
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
    let v25 : Async<unit> = _v17.Value
    do! v25 
    let v26 : int64 = v2 + 1L
    let v27 : Async<int64> = method10(v0, v1, v26)
    return! v27 
    (*
    *)
    }
    |> fun x -> _v9 <- Some x
    let v28 : Async<int64> = _v9 |> Option.get
    v28 
    #endif
    |> fun x -> _v3 <- Some x
    let v29 : Async<int64> = _v3.Value
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
    let v9 : Async<int64> = method10(v0, v1, v8)
    v9 
    #endif
    |> fun x -> _v2 <- Some x
    let v10 : Async<int64> = _v2.Value
    v10
and closure23 () (v0 : string) : (string -> Async<int64>) =
    closure24(v0)
and closure28 () (v0 : int64) : US5 =
    US5_0(v0)
and closure29 () (v0 : exn) : US5 =
    US5_1(v0)
and closure30 () () : string =
    let v0 : string = "run_with_timeout_async"
    v0
and closure31 () () : string =
    let v0 : (unit -> string) = closure6()
    let v1 : string = $"timeout: {1000} / {v0 ()}"
    v1
and closure32 (v0 : string) () : string =
    let v1 : string = $"run_with_timeout_async** / ex: {v0}"
    v1
and closure33 () () : string =
    let v0 : string = "read_all_text_retry_async"
    v0
and method12 (v0 : int64, v1 : string) : string =
    let v2 : (unit -> string) = closure6()
    let v3 : string = $"retry: {v0} / ex: {v1} / {v2 ()}"
    v3
and closure34 (v0 : int64, v1 : string) () : string =
    method12(v0, v1)
and method11 (v0 : string, v1 : int64) : Async<string option> =
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
        let v17 : Async<int64> = method8(v0, v16)
        v17 
        #endif
        |> fun x -> _v10 <- Some x
        let v18 : Async<int64> = _v10.Value
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
        let v39 : Async<Async<int64>> = _v32.Value
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
        let v49 : Async<Choice<int64, exn>> = _v41.Value
        let v50 : bool = true
        let mutable _v50 : Async<US5> option = None 
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v51 : Async<US5> = null |> unbox<Async<US5>>
        v51 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v52 : Async<US5> = null |> unbox<Async<US5>>
        v52 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v53 : Async<US5> = null |> unbox<Async<US5>>
        v53 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v54 : Async<US5> = null |> unbox<Async<US5>>
        v54 
        #endif
#if FABLE_COMPILER_PYTHON
        let v55 : Async<US5> = null |> unbox<Async<US5>>
        v55 
        #endif
#else
        let v56 : Async<US5> option = None
        let mutable _v56 = v56
        async {
        let! v49 = v49 
        let v57 : Choice<int64, exn> = v49 
        let v58 : bool = true
        let mutable _v58 : US5 option = None 
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v59 : US5 = null |> unbox<US5>
        v59 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v60 : US5 = null |> unbox<US5>
        v60 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v61 : US5 = null |> unbox<US5>
        v61 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v62 : US5 = null |> unbox<US5>
        v62 
        #endif
#if FABLE_COMPILER_PYTHON
        let v63 : US5 = null |> unbox<US5>
        v63 
        #endif
#else
        let v64 : (int64 -> US5) = closure28()
        let v65 : (exn -> US5) = closure29()
        let v66 : US5 = match v57 with Choice1Of2 x -> v64 x | Choice2Of2 x -> v65 x
        v66 
        #endif
        |> fun x -> _v58 <- Some x
        let v67 : US5 = _v58.Value
        return v67 
        }
        |> fun x -> _v56 <- Some x
        let v68 : Async<US5> = _v56 |> Option.get
        v68 
        #endif
        |> fun x -> _v50 <- Some x
        let v69 : Async<US5> = _v50.Value
        let v70 : bool = true
        let mutable _v70 : Async<US6> option = None 
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v71 : Async<US6> = null |> unbox<Async<US6>>
        v71 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v72 : Async<US6> = null |> unbox<Async<US6>>
        v72 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v73 : Async<US6> = null |> unbox<Async<US6>>
        v73 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v74 : Async<US6> = null |> unbox<Async<US6>>
        v74 
        #endif
#if FABLE_COMPILER_PYTHON
        let v75 : Async<US6> = null |> unbox<Async<US6>>
        v75 
        #endif
#else
        let v76 : Async<US6> option = None
        let mutable _v76 = v76
        async {
        let! v69 = v69 
        let v77 : US5 = v69 
        let v83 : US6 =
            match v77 with
            | US5_0(v78) -> (* Choice1Of2 *)
                US6_0(v78)
            | US5_1(v80) -> (* Choice2Of2 *)
                US6_1(v80)
        return v83 
        }
        |> fun x -> _v76 <- Some x
        let v84 : Async<US6> = _v76 |> Option.get
        v84 
        #endif
        |> fun x -> _v70 <- Some x
        let v85 : Async<US6> = _v70.Value
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
        let v93 : US6 = v85 
        let v118 : US1 =
            match v93 with
            | US6_1(v96) -> (* Error *)
                let v97 : string = $"%A{v96}"
                let v98 : string = "System.TimeoutException"
                let v99 : bool = v97.Contains v98
                if v99 then
                    let v100 : US0 = US0_1
                    let v101 : (unit -> string) = closure30()
                    let v102 : (unit -> string) = closure31()
                    method4(v100, v101, v102)
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
                    let v111 : string = _v104.Value
                    let v112 : US0 = US0_4
                    let v113 : (unit -> string) = closure32(v111)
                    let v114 : (unit -> string) = closure31()
                    method4(v112, v113, v114)
                    US1_1
            | US6_0(v94) -> (* Ok *)
                US1_0(v94)
        return v118 
        }
        |> fun x -> _v92 <- Some x
        let v119 : Async<US1> = _v92 |> Option.get
        v119 
        #endif
        |> fun x -> _v86 <- Some x
        let v120 : Async<US1> = _v86.Value
        return! v120 
        }
        |> fun x -> _v31 <- Some x
        let v121 : Async<US1> = _v31 |> Option.get
        v121 
        #endif
        |> fun x -> _v25 <- Some x
        let v122 : Async<US1> = _v25.Value
        v122 
        #endif
        |> fun x -> _v19 <- Some x
        let v123 : Async<US1> = _v19.Value
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
        let v132 : Async<unit> = _v124.Value
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
    let v149 : Async<string> = _v141.Value
    v149 
    #endif
    |> fun x -> _v133 <- Some x
    let v150 : Async<string> = _v133.Value
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
    let v160 : Async<string option> = _v157 |> Option.get
    v160 
    #endif
    |> fun x -> _v151 <- Some x
    let v161 : Async<string option> = _v151.Value
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
        let v172 : string = _v165.Value
        let v173 : US0 = US0_1
        let v174 : (unit -> string) = closure33()
        let v175 : (unit -> string) = closure34(v1, v172)
        method4(v173, v174, v175)
        let v176 : string option = None
        return v176 
        (*
        ()
    else
        *) else
        let v177 : int64 = v1 + 1L
        let v178 : Async<string option> = method11(v0, v177)
        return! v178 
        (*
        ()
    *)
    (*
    let v179 : string option = *)
    }
    |> fun x -> _v8 <- Some x
    let v180 : Async<string option> = _v8 |> Option.get
    v180 
    #endif
    |> fun x -> _v2 <- Some x
    let v181 : Async<string option> = _v2.Value
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
    let v8 : Async<string option> = method11(v0, v7)
    v8 
    #endif
    |> fun x -> _v1 <- Some x
    let v9 : Async<string option> = _v1.Value
    v9
and method13 () : string =
    let v0 : string = "CARGO_PKG_NAME"
    v0
and method15 (v0 : string) : string =
    v0
and method16 (v0 : string) : string =
    v0
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
    let v27 : std_string_String = _v17.Value
    let v28 : string = "fable_library_rust::String_::fromString($0)"
    let v29 : string = Fable.Core.RustInterop.emitRustExpr v27 v28
    v29 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v30 : string = null |> unbox<string>
    v30 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v31 : string = null |> unbox<string>
    v31 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v32 : string = "path"
    let v33 : IPathJoin = Fable.Core.JsInterop.importAll v32
    let v34 : string = method15(v0)
    let v35 : string = method16(v1)
    let v36 : string = "v33.join(v34, v35)"
    let v37 : string = Fable.Core.JsInterop.emitJsExpr () v36
    v37 
    #endif
#if FABLE_COMPILER_PYTHON
    let v38 : string = null |> unbox<string>
    v38 
    #endif
#else
    let v39 : string = System.IO.Path.Combine (v0, v1)
    v39 
    #endif
    |> fun x -> _v2 <- Some x
    let v40 : string = _v2.Value
    v40
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
and method17 (v0 : System.Guid, v1 : System.DateTime) : System.Guid =
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
    let v18 : US7 option = None
    let _v18 = ref v18 
    match v17 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v19 : chrono_DateTime<chrono_Utc> = x
    let v20 : US7 = US7_0(v19)
    v20 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v18.Value <- x
    let v21 : US7 option = _v18.Value 
    let v22 : US7 = US7_1
    let v23 : US7 = v21 |> Option.defaultValue v22 
    let v42 : US8 =
        match v23 with
        | US7_1 -> (* None *)
            US8_1
        | US7_0(v24) -> (* Some *)
            let v25 : chrono_DateTime<chrono_Utc> = method18(v24)
            let v26 : string = "v25.naive_utc()"
            let v27 : chrono_NaiveDateTime = Fable.Core.RustInterop.emitRustExpr () v26
            let v28 : string = "chrono::offset::TimeZone::from_utc_datetime(&chrono::Local, &v27)"
            let v29 : chrono_DateTime<chrono_Local> = Fable.Core.RustInterop.emitRustExpr () v28
            let v30 : string = "%Y%m%d-%H%M-%S%f"
            let v31 : string = "r#\"" + v30 + "\"#"
            let v32 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v31
            let v33 : chrono_DateTime<chrono_Local> = method19(v29)
            let v34 : string = "v33.format(v32).to_string()"
            let v35 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v34
            let v36 : string = "fable_library_rust::String_::fromString($0)"
            let v37 : string = Fable.Core.RustInterop.emitRustExpr v35 v36
            let v38 : string = $"{v37.[0..17]}-{v37.[18..21]}-{v37.[22]}"
            US8_0(v38)
    let v46 : string =
        match v42 with
        | US8_1 -> (* None *)
            let v44 : string = ""
            v44
        | US8_0(v43) -> (* Some *)
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
    let v55 : System.TimeZoneInfo = _v47.Value
    let v56 : bool = true
    let mutable _v56 : System.TimeSpan option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v57 : System.TimeSpan = System.TimeSpan () 
    v57 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v58 : System.TimeSpan = System.TimeSpan () 
    v58 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v59 : System.TimeSpan = System.TimeSpan () 
    v59 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v60 : System.TimeSpan = System.TimeSpan () 
    v60 
    #endif
#if FABLE_COMPILER_PYTHON
    let v61 : System.TimeSpan = System.TimeSpan () 
    v61 
    #endif
#else
    let v62 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v63 : bool = true
    let mutable _v63 : System.TimeZoneInfo option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v64 : string = "0i64.into()"
    let v65 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v64
    v65 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v66 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v66 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v67 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v67 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v68 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v68 
    #endif
#if FABLE_COMPILER_PYTHON
    let v69 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v69 
    #endif
#else
    let v70 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    v70 
    #endif
    |> fun x -> _v63 <- Some x
    let v71 : System.TimeZoneInfo = _v63.Value
    let v72 : (System.DateTime -> System.TimeSpan) = v62 v71
    let v73 : System.TimeSpan = v72 v9
    v73 
    #endif
    |> fun x -> _v56 <- Some x
    let v74 : System.TimeSpan = _v56.Value
    let v75 : (System.TimeSpan -> int32) = _.Hours
    let v76 : int32 = v75 v74
    let v77 : bool = v76 > 0
    let v78 : uint8 =
        if v77 then
            1uy
        else
            0uy
    let v79 : (string -> string) = v74.ToString
    let v80 : string = "hh:mm"
    let v81 : string = v79 v80
    let v82 : string = $"{v78}{v81.[0..1]}{v81.[3..4]}"
    let v83 : (System.Guid -> string) = _.ToString()
    let v84 : string = v83 v0
    let v85 : System.Guid = System.Guid $"{v46}{v82}{v84.[v46.Length + v82.Length..]}"
    v85 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v86 : System.Guid = null |> unbox<System.Guid>
    v86 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v87 : System.Guid = null |> unbox<System.Guid>
    v87 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v88 : System.Guid = null |> unbox<System.Guid>
    v88 
    #endif
#if FABLE_COMPILER_PYTHON
    let v89 : System.Guid = null |> unbox<System.Guid>
    v89 
    #endif
#else
    let v90 : string = method20()
    let v91 : (string -> string) = v1.ToString
    let v92 : string = v91 v90
    let v93 : bool = true
    let mutable _v93 : System.TimeZoneInfo option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v94 : string = "0i64.into()"
    let v95 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v94
    v95 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v96 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v96 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v97 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v97 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v98 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v98 
    #endif
#if FABLE_COMPILER_PYTHON
    let v99 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v99 
    #endif
#else
    let v100 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    v100 
    #endif
    |> fun x -> _v93 <- Some x
    let v101 : System.TimeZoneInfo = _v93.Value
    let v102 : bool = true
    let mutable _v102 : System.TimeSpan option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v103 : System.TimeSpan = System.TimeSpan () 
    v103 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v104 : System.TimeSpan = System.TimeSpan () 
    v104 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v105 : System.TimeSpan = System.TimeSpan () 
    v105 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v106 : System.TimeSpan = System.TimeSpan () 
    v106 
    #endif
#if FABLE_COMPILER_PYTHON
    let v107 : System.TimeSpan = System.TimeSpan () 
    v107 
    #endif
#else
    let v108 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v109 : bool = true
    let mutable _v109 : System.TimeZoneInfo option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v110 : string = "0i64.into()"
    let v111 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v110
    v111 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v112 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v112 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v113 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v113 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v114 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v114 
    #endif
#if FABLE_COMPILER_PYTHON
    let v115 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v115 
    #endif
#else
    let v116 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    v116 
    #endif
    |> fun x -> _v109 <- Some x
    let v117 : System.TimeZoneInfo = _v109.Value
    let v118 : (System.DateTime -> System.TimeSpan) = v108 v117
    let v119 : System.TimeSpan = v118 v1
    v119 
    #endif
    |> fun x -> _v102 <- Some x
    let v120 : System.TimeSpan = _v102.Value
    let v121 : (System.TimeSpan -> int32) = _.Hours
    let v122 : int32 = v121 v120
    let v123 : bool = v122 > 0
    let v124 : (bool -> int32) = System.Convert.ToInt32
    let v125 : int32 = v124 v123
    let v126 : string = method21()
    let v127 : (string -> string) = v120.ToString
    let v128 : string = v127 v126
    let v129 : string = $"{v125}{v128}"
    let v130 : (System.Guid -> string) = _.ToString()
    let v131 : string = v130 v0
    let v132 : System.Guid = System.Guid $"{v92}{v129}{v131.[v92.Length + v129.Length..]}"
    v132 
    #endif
    |> fun x -> _v2 <- Some x
    let v133 : System.Guid = _v2.Value
    v133
and closure35 () () : string =
    let v0 : bool = true
    let mutable _v0 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1 : bool = true
    let mutable _v1 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : bool = true
    let mutable _v2 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : string = "std::env::var(&*$0)"
    let v4 : string = "CARGO_PKG_NAME"
    let v5 : Result<std_string_String, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr v4 v3
    let v6 : string = "true; let _result = $0.map(|x| { //"
    let v7 : bool = Fable.Core.RustInterop.emitRustExpr v5 v6
    let v8 : string = "x"
    let v9 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v8
    let v10 : string = "fable_library_rust::String_::fromString($0)"
    let v11 : string = Fable.Core.RustInterop.emitRustExpr v9 v10
    let v12 : string = "true; $0 })"
    let v13 : bool = Fable.Core.RustInterop.emitRustExpr v11 v12
    let v14 : string = "_result"
    let v15 : Result<string, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr () v14
    let v16 : string = method0()
    let v17 : string = "$0.unwrap_or($1)"
    let v18 : string = Fable.Core.RustInterop.emitRustExpr struct (v15, v16) v17
    v18 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v19 : string = null |> unbox<string>
    v19 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v20 : string = null |> unbox<string>
    v20 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v21 : string = null |> unbox<string>
    v21 
    #endif
#if FABLE_COMPILER_PYTHON
    let v22 : string = null |> unbox<string>
    v22 
    #endif
#else
    let v23 : string = method13()
    let v24 : (string -> string) = System.Environment.GetEnvironmentVariable
    let v25 : string = v24 v23
    v25 
    #endif
    |> fun x -> _v2 <- Some x
    let v26 : string = _v2.Value
    v26 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v27 : string = null |> unbox<string>
    v27 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v28 : string = null |> unbox<string>
    v28 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v29 : string = null |> unbox<string>
    v29 
    #endif
#if FABLE_COMPILER_PYTHON
    let v30 : string = null |> unbox<string>
    v30 
    #endif
#else
    let v31 : string = System.Reflection.Assembly.GetEntryAssembly().GetName().Name
    v31 
    #endif
    |> fun x -> _v1 <- Some x
    let v32 : string = _v1.Value
    let v33 : bool = true
    let mutable _v33 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v34 : string = "std::env::temp_dir()"
    let v35 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr () v34
    let v36 : string = "$0.display()"
    let v37 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v35 v36
    let v38 : bool = true
    let mutable _v38 : std_string_String option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v39 : string = "format!(\"{}\", $0)"
    let v40 : std_string_String = Fable.Core.RustInterop.emitRustExpr v37 v39
    v40 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v41 : string = "format!(\"{}\", $0)"
    let v42 : std_string_String = Fable.Core.RustInterop.emitRustExpr v37 v41
    v42 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v43 : string = "format!(\"{}\", $0)"
    let v44 : std_string_String = Fable.Core.RustInterop.emitRustExpr v37 v43
    v44 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v45 : std_string_String = null |> unbox<std_string_String>
    v45 
    #endif
#if FABLE_COMPILER_PYTHON
    let v46 : std_string_String = null |> unbox<std_string_String>
    v46 
    #endif
#else
    let v47 : std_string_String = null |> unbox<std_string_String>
    v47 
    #endif
    |> fun x -> _v38 <- Some x
    let v48 : std_string_String = _v38.Value
    let v49 : string = "fable_library_rust::String_::fromString($0)"
    let v50 : string = Fable.Core.RustInterop.emitRustExpr v48 v49
    v50 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v51 : string = null |> unbox<string>
    v51 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v52 : string = null |> unbox<string>
    v52 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v53 : string = null |> unbox<string>
    v53 
    #endif
#if FABLE_COMPILER_PYTHON
    let v54 : string = null |> unbox<string>
    v54 
    #endif
#else
    let v55 : (unit -> string) = System.IO.Path.GetTempPath
    let v56 : string = v55 ()
    v56 
    #endif
    |> fun x -> _v33 <- Some x
    let v57 : string = _v33.Value
    let v58 : string = $"!{v32}"
    let v59 : string = method14(v57, v58)
    let v60 : System.DateTime = System.DateTime.Now
    let v61 : System.Guid = System.Guid.NewGuid ()
    let v62 : System.Guid = method17(v61, v60)
    let v63 : (System.Guid -> string) = _.ToString()
    let v64 : string = v63 v62
    let v65 : string = method14(v59, v64)
    v65 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v66 : string = null |> unbox<string>
    v66 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v67 : string = null |> unbox<string>
    v67 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v68 : string = null |> unbox<string>
    v68 
    #endif
#if FABLE_COMPILER_PYTHON
    let v69 : string = null |> unbox<string>
    v69 
    #endif
#else
    let v70 : bool = true
    let mutable _v70 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v71 : bool = true
    let mutable _v71 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v72 : string = "std::env::var(&*$0)"
    let v73 : Result<std_string_String, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr v4 v72
    let v74 : string = "true; let _result = $0.map(|x| { //"
    let v75 : bool = Fable.Core.RustInterop.emitRustExpr v73 v74
    let v76 : string = "x"
    let v77 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v76
    let v78 : string = "fable_library_rust::String_::fromString($0)"
    let v79 : string = Fable.Core.RustInterop.emitRustExpr v77 v78
    let v80 : string = "true; $0 })"
    let v81 : bool = Fable.Core.RustInterop.emitRustExpr v79 v80
    let v82 : string = "_result"
    let v83 : Result<string, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr () v82
    let v84 : string = method0()
    let v85 : string = "$0.unwrap_or($1)"
    let v86 : string = Fable.Core.RustInterop.emitRustExpr struct (v83, v84) v85
    v86 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v87 : string = null |> unbox<string>
    v87 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v88 : string = null |> unbox<string>
    v88 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v89 : string = null |> unbox<string>
    v89 
    #endif
#if FABLE_COMPILER_PYTHON
    let v90 : string = null |> unbox<string>
    v90 
    #endif
#else
    let v91 : string = method13()
    let v92 : (string -> string) = System.Environment.GetEnvironmentVariable
    let v93 : string = v92 v91
    v93 
    #endif
    |> fun x -> _v71 <- Some x
    let v94 : string = _v71.Value
    v94 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v95 : string = null |> unbox<string>
    v95 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v96 : string = null |> unbox<string>
    v96 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v97 : string = null |> unbox<string>
    v97 
    #endif
#if FABLE_COMPILER_PYTHON
    let v98 : string = null |> unbox<string>
    v98 
    #endif
#else
    let v99 : string = System.Reflection.Assembly.GetEntryAssembly().GetName().Name
    v99 
    #endif
    |> fun x -> _v70 <- Some x
    let v100 : string = _v70.Value
    let v101 : bool = true
    let mutable _v101 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v102 : string = "std::env::temp_dir()"
    let v103 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr () v102
    let v104 : string = "$0.display()"
    let v105 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v103 v104
    let v106 : bool = true
    let mutable _v106 : std_string_String option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v107 : string = "format!(\"{}\", $0)"
    let v108 : std_string_String = Fable.Core.RustInterop.emitRustExpr v105 v107
    v108 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v109 : string = "format!(\"{}\", $0)"
    let v110 : std_string_String = Fable.Core.RustInterop.emitRustExpr v105 v109
    v110 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v111 : string = "format!(\"{}\", $0)"
    let v112 : std_string_String = Fable.Core.RustInterop.emitRustExpr v105 v111
    v112 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v113 : std_string_String = null |> unbox<std_string_String>
    v113 
    #endif
#if FABLE_COMPILER_PYTHON
    let v114 : std_string_String = null |> unbox<std_string_String>
    v114 
    #endif
#else
    let v115 : std_string_String = null |> unbox<std_string_String>
    v115 
    #endif
    |> fun x -> _v106 <- Some x
    let v116 : std_string_String = _v106.Value
    let v117 : string = "fable_library_rust::String_::fromString($0)"
    let v118 : string = Fable.Core.RustInterop.emitRustExpr v116 v117
    v118 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v119 : string = null |> unbox<string>
    v119 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v120 : string = null |> unbox<string>
    v120 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v121 : string = null |> unbox<string>
    v121 
    #endif
#if FABLE_COMPILER_PYTHON
    let v122 : string = null |> unbox<string>
    v122 
    #endif
#else
    let v123 : (unit -> string) = System.IO.Path.GetTempPath
    let v124 : string = v123 ()
    v124 
    #endif
    |> fun x -> _v101 <- Some x
    let v125 : string = _v101.Value
    let v126 : string = $"!{v100}"
    let v127 : string = method14(v125, v126)
    let v128 : System.DateTime = System.DateTime.Now
    let v129 : System.Guid = System.Guid.NewGuid ()
    let v130 : System.Guid = method17(v129, v128)
    let v131 : (System.Guid -> string) = _.ToString()
    let v132 : string = v131 v130
    let v133 : string = method14(v127, v132)
    v133 
    #endif
    |> fun x -> _v0 <- Some x
    let v134 : string = _v0.Value
    v134
and method22 (v0 : string) : string =
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
    let v11 : std_string_String = _v1.Value
    v11
and method23 () : (std_io_Error -> std_string_String) =
    closure37()
and closure38 () () : US9 =
    US9_0
and closure39 () (v0 : std_string_String) : US9 =
    US9_1(v0)
and closure40 () () : string =
    let v0 : string = "file_system.create_directory"
    v0
and closure41 (v0 : string, v1 : std_string_String) () : string =
    let v2 : (unit -> string) = closure6()
    let v3 : string = $"dir: {v0} / error: {v1} / {v2 ()}"
    v3
and closure42 () () : string =
    let v0 : string = "file_system.create_directory"
    v0
and closure43 (v0 : string) () : string =
    let v1 : (unit -> string) = closure6()
    let v2 : string = $"dir: {v0} / {v1 ()}"
    v2
and closure44 (v0 : string) () : unit =
    let v1 : bool = true
    let mutable _v1 : unit option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = method3(v0)
    let v3 : bool = true
    let mutable _v3 : bool option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v4 : string = "&*$0"
    let v5 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v2 v4
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
    let v19 : string = "$0.existsSync($1)"
    let v20 : bool = Fable.Core.JsInterop.emitJsExpr struct (v18, v2) v19
    v20 
    #endif
#if FABLE_COMPILER_PYTHON
    let v21 : bool = null |> unbox<bool>
    v21 
    #endif
#else
    let v22 : (string -> bool) = System.IO.Directory.Exists
    let v23 : bool = v22 v2
    v23 
    #endif
    |> fun x -> _v3 <- Some x
    let v24 : bool = _v3.Value
    if v24 then
        let v25 : string = "std::fs::remove_dir_all(&*$0).unwrap()"
        Fable.Core.RustInterop.emitRustExpr v2 v25
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
    closure44(v0)
and closure45 () () : string =
    let v0 : string = "file_system.create_directory"
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
    let v8 : Async<int64> = method2(v0, v7)
    v8 
    #endif
    |> fun x -> _v1 <- Some x
    let v9 : Async<int64> = _v1.Value
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
    let v18 : Async<unit> = _v10.Value
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
    _v19.Value
    ()
and method25 (v0 : string) : (unit -> unit) =
    closure47(v0)
and closure36 () () : struct (string * System.IDisposable) =
    let v0 : bool = true
    let mutable _v0 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1 : bool = true
    let mutable _v1 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : bool = true
    let mutable _v2 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : string = "std::env::var(&*$0)"
    let v4 : string = "CARGO_PKG_NAME"
    let v5 : Result<std_string_String, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr v4 v3
    let v6 : string = "true; let _result = $0.map(|x| { //"
    let v7 : bool = Fable.Core.RustInterop.emitRustExpr v5 v6
    let v8 : string = "x"
    let v9 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v8
    let v10 : string = "fable_library_rust::String_::fromString($0)"
    let v11 : string = Fable.Core.RustInterop.emitRustExpr v9 v10
    let v12 : string = "true; $0 })"
    let v13 : bool = Fable.Core.RustInterop.emitRustExpr v11 v12
    let v14 : string = "_result"
    let v15 : Result<string, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr () v14
    let v16 : string = method0()
    let v17 : string = "$0.unwrap_or($1)"
    let v18 : string = Fable.Core.RustInterop.emitRustExpr struct (v15, v16) v17
    v18 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v19 : string = null |> unbox<string>
    v19 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v20 : string = null |> unbox<string>
    v20 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v21 : string = null |> unbox<string>
    v21 
    #endif
#if FABLE_COMPILER_PYTHON
    let v22 : string = null |> unbox<string>
    v22 
    #endif
#else
    let v23 : string = method13()
    let v24 : (string -> string) = System.Environment.GetEnvironmentVariable
    let v25 : string = v24 v23
    v25 
    #endif
    |> fun x -> _v2 <- Some x
    let v26 : string = _v2.Value
    v26 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v27 : string = null |> unbox<string>
    v27 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v28 : string = null |> unbox<string>
    v28 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v29 : string = null |> unbox<string>
    v29 
    #endif
#if FABLE_COMPILER_PYTHON
    let v30 : string = null |> unbox<string>
    v30 
    #endif
#else
    let v31 : string = System.Reflection.Assembly.GetEntryAssembly().GetName().Name
    v31 
    #endif
    |> fun x -> _v1 <- Some x
    let v32 : string = _v1.Value
    let v33 : bool = true
    let mutable _v33 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v34 : string = "std::env::temp_dir()"
    let v35 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr () v34
    let v36 : string = "$0.display()"
    let v37 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v35 v36
    let v38 : bool = true
    let mutable _v38 : std_string_String option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v39 : string = "format!(\"{}\", $0)"
    let v40 : std_string_String = Fable.Core.RustInterop.emitRustExpr v37 v39
    v40 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v41 : string = "format!(\"{}\", $0)"
    let v42 : std_string_String = Fable.Core.RustInterop.emitRustExpr v37 v41
    v42 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v43 : string = "format!(\"{}\", $0)"
    let v44 : std_string_String = Fable.Core.RustInterop.emitRustExpr v37 v43
    v44 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v45 : std_string_String = null |> unbox<std_string_String>
    v45 
    #endif
#if FABLE_COMPILER_PYTHON
    let v46 : std_string_String = null |> unbox<std_string_String>
    v46 
    #endif
#else
    let v47 : std_string_String = null |> unbox<std_string_String>
    v47 
    #endif
    |> fun x -> _v38 <- Some x
    let v48 : std_string_String = _v38.Value
    let v49 : string = "fable_library_rust::String_::fromString($0)"
    let v50 : string = Fable.Core.RustInterop.emitRustExpr v48 v49
    v50 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v51 : string = null |> unbox<string>
    v51 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v52 : string = null |> unbox<string>
    v52 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v53 : string = null |> unbox<string>
    v53 
    #endif
#if FABLE_COMPILER_PYTHON
    let v54 : string = null |> unbox<string>
    v54 
    #endif
#else
    let v55 : (unit -> string) = System.IO.Path.GetTempPath
    let v56 : string = v55 ()
    v56 
    #endif
    |> fun x -> _v33 <- Some x
    let v57 : string = _v33.Value
    let v58 : string = $"!{v32}"
    let v59 : string = method14(v57, v58)
    let v60 : System.DateTime = System.DateTime.Now
    let v61 : System.Guid = System.Guid.NewGuid ()
    let v62 : System.Guid = method17(v61, v60)
    let v63 : (System.Guid -> string) = _.ToString()
    let v64 : string = v63 v62
    let v65 : string = method14(v59, v64)
    v65 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v66 : string = null |> unbox<string>
    v66 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v67 : string = null |> unbox<string>
    v67 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v68 : string = null |> unbox<string>
    v68 
    #endif
#if FABLE_COMPILER_PYTHON
    let v69 : string = null |> unbox<string>
    v69 
    #endif
#else
    let v70 : bool = true
    let mutable _v70 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v71 : bool = true
    let mutable _v71 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v72 : string = "std::env::var(&*$0)"
    let v73 : Result<std_string_String, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr v4 v72
    let v74 : string = "true; let _result = $0.map(|x| { //"
    let v75 : bool = Fable.Core.RustInterop.emitRustExpr v73 v74
    let v76 : string = "x"
    let v77 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v76
    let v78 : string = "fable_library_rust::String_::fromString($0)"
    let v79 : string = Fable.Core.RustInterop.emitRustExpr v77 v78
    let v80 : string = "true; $0 })"
    let v81 : bool = Fable.Core.RustInterop.emitRustExpr v79 v80
    let v82 : string = "_result"
    let v83 : Result<string, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr () v82
    let v84 : string = method0()
    let v85 : string = "$0.unwrap_or($1)"
    let v86 : string = Fable.Core.RustInterop.emitRustExpr struct (v83, v84) v85
    v86 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v87 : string = null |> unbox<string>
    v87 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v88 : string = null |> unbox<string>
    v88 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v89 : string = null |> unbox<string>
    v89 
    #endif
#if FABLE_COMPILER_PYTHON
    let v90 : string = null |> unbox<string>
    v90 
    #endif
#else
    let v91 : string = method13()
    let v92 : (string -> string) = System.Environment.GetEnvironmentVariable
    let v93 : string = v92 v91
    v93 
    #endif
    |> fun x -> _v71 <- Some x
    let v94 : string = _v71.Value
    v94 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v95 : string = null |> unbox<string>
    v95 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v96 : string = null |> unbox<string>
    v96 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v97 : string = null |> unbox<string>
    v97 
    #endif
#if FABLE_COMPILER_PYTHON
    let v98 : string = null |> unbox<string>
    v98 
    #endif
#else
    let v99 : string = System.Reflection.Assembly.GetEntryAssembly().GetName().Name
    v99 
    #endif
    |> fun x -> _v70 <- Some x
    let v100 : string = _v70.Value
    let v101 : bool = true
    let mutable _v101 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v102 : string = "std::env::temp_dir()"
    let v103 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr () v102
    let v104 : string = "$0.display()"
    let v105 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v103 v104
    let v106 : bool = true
    let mutable _v106 : std_string_String option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v107 : string = "format!(\"{}\", $0)"
    let v108 : std_string_String = Fable.Core.RustInterop.emitRustExpr v105 v107
    v108 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v109 : string = "format!(\"{}\", $0)"
    let v110 : std_string_String = Fable.Core.RustInterop.emitRustExpr v105 v109
    v110 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v111 : string = "format!(\"{}\", $0)"
    let v112 : std_string_String = Fable.Core.RustInterop.emitRustExpr v105 v111
    v112 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v113 : std_string_String = null |> unbox<std_string_String>
    v113 
    #endif
#if FABLE_COMPILER_PYTHON
    let v114 : std_string_String = null |> unbox<std_string_String>
    v114 
    #endif
#else
    let v115 : std_string_String = null |> unbox<std_string_String>
    v115 
    #endif
    |> fun x -> _v106 <- Some x
    let v116 : std_string_String = _v106.Value
    let v117 : string = "fable_library_rust::String_::fromString($0)"
    let v118 : string = Fable.Core.RustInterop.emitRustExpr v116 v117
    v118 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v119 : string = null |> unbox<string>
    v119 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v120 : string = null |> unbox<string>
    v120 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v121 : string = null |> unbox<string>
    v121 
    #endif
#if FABLE_COMPILER_PYTHON
    let v122 : string = null |> unbox<string>
    v122 
    #endif
#else
    let v123 : (unit -> string) = System.IO.Path.GetTempPath
    let v124 : string = v123 ()
    v124 
    #endif
    |> fun x -> _v101 <- Some x
    let v125 : string = _v101.Value
    let v126 : string = $"!{v100}"
    let v127 : string = method14(v125, v126)
    let v128 : System.DateTime = System.DateTime.Now
    let v129 : System.Guid = System.Guid.NewGuid ()
    let v130 : System.Guid = method17(v129, v128)
    let v131 : (System.Guid -> string) = _.ToString()
    let v132 : string = v131 v130
    let v133 : string = method14(v127, v132)
    v133 
    #endif
    |> fun x -> _v0 <- Some x
    let v134 : string = _v0.Value
    let v135 : bool = true
    let mutable _v135 : System.IDisposable option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v136 : string = method22(v134)
    let v137 : string = "std::fs::create_dir_all(&*$0)"
    let v138 : Result<unit, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v136 v137
    let v139 : (std_io_Error -> std_string_String) = method23()
    let v140 : string = "$0.map_err(|x| $1(x))"
    let v141 : Result<unit, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v138, v139) v140
    let v142 : (unit -> US9) = closure38()
    let v143 : (std_string_String -> US9) = closure39()
    let v144 : US9 = match v141 with Ok () -> v142 () | Error x -> v143 x
    match v144 with
    | US9_1(v148) -> (* Error *)
        let v149 : US0 = US0_4
        let v150 : (unit -> string) = closure40()
        let v151 : (unit -> string) = closure41(v136, v148)
        method4(v149, v150, v151)
    | US9_0 -> (* Ok *)
        let v145 : US0 = US0_0
        let v146 : (unit -> string) = closure42()
        let v147 : (unit -> string) = closure43(v136)
        method4(v145, v146, v147)
    let v152 : bool = true
    let mutable _v152 : System.IDisposable option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v153 : (unit -> unit) = closure44(v136)
    let v154 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v153 "$0()" )
    v154 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v155 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v153 "$0()" )
    v155 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v156 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v153 "$0()" )
    v156 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v157 : System.IDisposable = null |> unbox<System.IDisposable>
    v157 
    #endif
#if FABLE_COMPILER_PYTHON
    let v158 : System.IDisposable = null |> unbox<System.IDisposable>
    v158 
    #endif
#else
    let v159 : (unit -> unit) = method24(v136)
    let v160 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v159 () }
    v160 
    #endif
    |> fun x -> _v152 <- Some x
    let v161 : System.IDisposable = _v152.Value
    v161 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v162 : System.IDisposable = null |> unbox<System.IDisposable>
    v162 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v163 : System.IDisposable = null |> unbox<System.IDisposable>
    v163 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v164 : System.IDisposable = null |> unbox<System.IDisposable>
    v164 
    #endif
#if FABLE_COMPILER_PYTHON
    let v165 : System.IDisposable = null |> unbox<System.IDisposable>
    v165 
    #endif
#else
    let v166 : bool = true
    let mutable _v166 : System.IO.DirectoryInfo option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v167 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    v167 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v168 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    v168 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v169 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    v169 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v170 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    v170 
    #endif
#if FABLE_COMPILER_PYTHON
    let v171 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    v171 
    #endif
#else
    let v172 : (string -> System.IO.DirectoryInfo) = System.IO.Directory.CreateDirectory
    let v173 : System.IO.DirectoryInfo = v172 v134
    v173 
    #endif
    |> fun x -> _v166 <- Some x
    let v174 : System.IO.DirectoryInfo = _v166.Value
    let v175 : bool = true
    let mutable _v175 : bool option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v176 : bool = null |> unbox<bool>
    v176 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v177 : bool = null |> unbox<bool>
    v177 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v178 : bool = null |> unbox<bool>
    v178 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v179 : bool = null |> unbox<bool>
    v179 
    #endif
#if FABLE_COMPILER_PYTHON
    let v180 : bool = null |> unbox<bool>
    v180 
    #endif
#else
    let v181 : bool = v174.Exists
    v181 
    #endif
    |> fun x -> _v175 <- Some x
    let v182 : bool = _v175.Value
    let v183 : bool = v182 = false
    if v183 then
        let v184 : bool = true
        let mutable _v184 : System.DateTime option = None 
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v185 : System.DateTime = null |> unbox<System.DateTime>
        v185 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v186 : System.DateTime = null |> unbox<System.DateTime>
        v186 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v187 : System.DateTime = null |> unbox<System.DateTime>
        v187 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v188 : System.DateTime = null |> unbox<System.DateTime>
        v188 
        #endif
#if FABLE_COMPILER_PYTHON
        let v189 : System.DateTime = null |> unbox<System.DateTime>
        v189 
        #endif
#else
        let v190 : System.DateTime = v174.CreationTime
        v190 
        #endif
        |> fun x -> _v184 <- Some x
        let v191 : System.DateTime = _v184.Value
        let v192 : obj = {| Exists = v182; CreationTime = v191 |}
        let v193 : string = $"%A{v192}"
        let v194 : US0 = US0_1
        let v195 : (unit -> string) = closure45()
        let v196 : (unit -> string) = closure46(v134, v193)
        method4(v194, v195, v196)
    let v197 : bool = true
    let mutable _v197 : System.IDisposable option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v198 : (unit -> unit) = closure47(v134)
    let v199 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v198 "$0()" )
    v199 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v200 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v198 "$0()" )
    v200 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v201 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v198 "$0()" )
    v201 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v202 : System.IDisposable = null |> unbox<System.IDisposable>
    v202 
    #endif
#if FABLE_COMPILER_PYTHON
    let v203 : System.IDisposable = null |> unbox<System.IDisposable>
    v203 
    #endif
#else
    let v204 : (unit -> unit) = method25(v134)
    let v205 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v204 () }
    v205 
    #endif
    |> fun x -> _v197 <- Some x
    let v206 : System.IDisposable = _v197.Value
    v206 
    #endif
    |> fun x -> _v135 <- Some x
    let v207 : System.IDisposable = _v135.Value
    struct (v134, v207)
and closure48 () () : string =
    let v0 : string = __SOURCE_DIRECTORY__
    v0
and closure52 () (v0 : string) : bool =
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
    let v22 : bool = _v1.Value
    v22
and closure53 () (v0 : string) : bool =
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
            let v10 : string = "$0.is_dir()"
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
    let v20 : (string -> bool) = System.IO.Directory.Exists
    let v21 : bool = v20 v0
    v21 
    #endif
    |> fun x -> _v1 <- Some x
    let v22 : bool = _v1.Value
    v22
and closure54 () (v0 : string) : string option =
    let v1 : bool = true
    let mutable _v1 : US8 option = None 
    
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
    let v24 : std_string_String = _v14.Value
    let v25 : string = "fable_library_rust::String_::fromString($0)"
    let v26 : string = Fable.Core.RustInterop.emitRustExpr v24 v25
    let v27 : US8 = US8_0(v26)
    v27 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v28 : US8 = null |> unbox<US8>
    v28 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v29 : US8 = null |> unbox<US8>
    v29 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v30 : string = "path"
    let v31 : IPathDirname = Fable.Core.JsInterop.importAll v30
    let v32 : string = "v31.dirname($0)"
    let v33 : string = Fable.Core.JsInterop.emitJsExpr v0 v32
    let v34 : US8 = US8_0(v33)
    v34 
    #endif
#if FABLE_COMPILER_PYTHON
    let v35 : US8 = null |> unbox<US8>
    v35 
    #endif
#else
    let v36 : (string -> System.IO.DirectoryInfo) = System.IO.Directory.GetParent
    let v37 : System.IO.DirectoryInfo = v36 v0
    let v38 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    let v39 : bool = v37 = v38
    let v50 : US8 =
        if v39 then
            US8_1
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
            let v48 : string = _v41.Value
            US8_0(v48)
    v50 
    #endif
    |> fun x -> _v1 <- Some x
    let v51 : US8 = _v1.Value
    match v51 with
    | US8_1 -> (* None *)
        let v54 : string option = None
        v54
    | US8_0(v52) -> (* Some *)
        let v53 : string option = Some v52 
        v53
and method27 () : (string -> string option) =
    closure54()
and method28 (v0 : string, v1 : bool, v2 : string, v3 : string) : string =
    let v4 : string = method14(v3, v0)
    let v7 : (string -> bool) =
        if v1 then
            closure52()
        else
            closure53()
    let v8 : bool = v7 v4
    if v8 then
        v3
    else
        let v9 : (string -> string option) = method27()
        let v10 : string option = v9 v3
        let v11 : US8 option = None
        let _v11 = ref v11 
        match v10 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v12 : string = x
        let v13 : US8 = US8_0(v12)
        v13 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v11.Value <- x
        let v14 : US8 option = _v11.Value 
        let v15 : US8 = US8_1
        let v16 : US8 = v14 |> Option.defaultValue v15 
        match v16 with
        | US8_1 -> (* None *)
            let v19 : string = $"""No parent for {if v1 then "file" else "dir"} '{v0}' at '{v2}' (until '{v3}')"""
            failwith<string> v19
        | US8_0(v17) -> (* Some *)
            method28(v0, v1, v2, v17)
and method26 (v0 : string, v1 : bool, v2 : string) : string =
    let v3 : string = method14(v2, v0)
    let v6 : (string -> bool) =
        if v1 then
            closure52()
        else
            closure53()
    let v7 : bool = v6 v3
    if v7 then
        v2
    else
        let v8 : (string -> string option) = method27()
        let v9 : string option = v8 v2
        let v10 : US8 option = None
        let _v10 = ref v10 
        match v9 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v11 : string = x
        let v12 : US8 = US8_0(v11)
        v12 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v10.Value <- x
        let v13 : US8 option = _v10.Value 
        let v14 : US8 = US8_1
        let v15 : US8 = v13 |> Option.defaultValue v14 
        match v15 with
        | US8_1 -> (* None *)
            let v18 : string = $"""No parent for {if v1 then "file" else "dir"} '{v0}' at '{v2}' (until '{v2}')"""
            failwith<string> v18
        | US8_0(v16) -> (* Some *)
            method28(v0, v1, v2, v16)
and closure51 (v0 : string, v1 : bool) (v2 : string) : string =
    method26(v0, v1, v2)
and closure50 (v0 : string) (v1 : bool) : (string -> string) =
    closure51(v0, v1)
and closure49 () (v0 : string) : (bool -> (string -> string)) =
    closure50(v0)
and method29 (v0 : string) : string =
    v0
and method30 () : string =
    let v0 : string = ""
    v0
and method31 () : string =
    let v0 : string = "^\\\\\\\\\\?\\\\"
    v0
and method32 () : string =
    let v0 : string = ""
    v0
and closure55 () (v0 : string) : string =
    let v1 : bool = true
    let mutable _v1 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = method29(v0)
    let v3 : string = method30()
    let v4 : bool = true
    let mutable _v4 : Result<regex_Regex, regex_Error> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v5 : string = method31()
    let v6 : string = $"regex::Regex::new(&$0)"
    let v7 : Result<regex_Regex, regex_Error> = Fable.Core.RustInterop.emitRustExpr v5 v6
    v7 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v8 : Result<regex_Regex, regex_Error> = null |> unbox<Result<regex_Regex, regex_Error>>
    v8 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v9 : Result<regex_Regex, regex_Error> = null |> unbox<Result<regex_Regex, regex_Error>>
    v9 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v10 : Result<regex_Regex, regex_Error> = null |> unbox<Result<regex_Regex, regex_Error>>
    v10 
    #endif
#if FABLE_COMPILER_PYTHON
    let v11 : Result<regex_Regex, regex_Error> = null |> unbox<Result<regex_Regex, regex_Error>>
    v11 
    #endif
#else
    let v12 : Result<regex_Regex, regex_Error> = null |> unbox<Result<regex_Regex, regex_Error>>
    v12 
    #endif
    |> fun x -> _v4 <- Some x
    let v13 : Result<regex_Regex, regex_Error> = _v4.Value
    let v14 : string = "$0.unwrap()"
    let v15 : regex_Regex = Fable.Core.RustInterop.emitRustExpr v13 v14
    let v16 : string = $"$0.replace_all(&$1, &*$2)"
    let v17 : std_borrow_Cow<Str> = Fable.Core.RustInterop.emitRustExpr struct (v15, v2, v3) v16
    let v18 : string = "String::from($0)"
    let v19 : std_string_String = Fable.Core.RustInterop.emitRustExpr v17 v18
    let v20 : string = "fable_library_rust::String_::fromString($0)"
    let v21 : string = Fable.Core.RustInterop.emitRustExpr v19 v20
    v21 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v22 : string = null |> unbox<string>
    v22 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v23 : string = null |> unbox<string>
    v23 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v24 : string = null |> unbox<string>
    v24 
    #endif
#if FABLE_COMPILER_PYTHON
    let v25 : string = null |> unbox<string>
    v25 
    #endif
#else
    let v26 : string = method32()
    let v27 : string = "^\\\\\\\\\\?\\\\"
    let v28 : string = System.Text.RegularExpressions.Regex.Replace (v0, v27, v26)
    v28 
    #endif
    |> fun x -> _v1 <- Some x
    let v29 : string = _v1.Value
    let v30 : string = $"{v29.[0] |> string |> _.ToLower()}{v29.[1..]}"
    let v31 : string = "\\"
    let v32 : string = "/"
    let v33 : string = v30.Replace (v31, v32)
    v33
and closure56 () (v0 : string) : string =
    let v1 : (char []) = [|'/'|]
    let v2 : string = v0.TrimStart v1
    let v3 : string = $"file:///{v2}"
    v3
and method34 (v0 : string, v1 : string, v2 : string) : string =
    let v3 : string = method14(v2, v0)
    let v4 : bool = true
    let mutable _v4 : bool option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v5 : string = "&*$0"
    let v6 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v3 v5
    let v7 : string = "String::from($0)"
    let v8 : std_string_String = Fable.Core.RustInterop.emitRustExpr v6 v7
    let v9 : string = "std::path::PathBuf::from($0)"
    let v10 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v8 v9
    let v11 : string = "$0.exists()"
    let v12 : bool = Fable.Core.RustInterop.emitRustExpr v10 v11
    let v15 : bool =
        if v12 then
            let v13 : string = "$0.is_dir()"
            let v14 : bool = Fable.Core.RustInterop.emitRustExpr v10 v13
            v14
        else
            false
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
    let v21 : bool = Fable.Core.JsInterop.emitJsExpr struct (v19, v3) v20
    v21 
    #endif
#if FABLE_COMPILER_PYTHON
    let v22 : bool = null |> unbox<bool>
    v22 
    #endif
#else
    let v23 : (string -> bool) = System.IO.Directory.Exists
    let v24 : bool = v23 v3
    v24 
    #endif
    |> fun x -> _v4 <- Some x
    let v25 : bool = _v4.Value
    if v25 then
        v2
    else
        let v26 : (string -> string option) = method27()
        let v27 : string option = v26 v2
        let v28 : US8 option = None
        let _v28 = ref v28 
        match v27 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v29 : string = x
        let v30 : US8 = US8_0(v29)
        v30 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v28.Value <- x
        let v31 : US8 option = _v28.Value 
        let v32 : US8 = US8_1
        let v33 : US8 = v31 |> Option.defaultValue v32 
        match v33 with
        | US8_1 -> (* None *)
            let v36 : string = $"""No parent for {if false then "file" else "dir"} '{v0}' at '{v1}' (until '{v2}')"""
            failwith<string> v36
        | US8_0(v34) -> (* Some *)
            method34(v0, v1, v34)
and method33 (v0 : string, v1 : string) : string =
    let v2 : string = method14(v1, v0)
    let v3 : bool = true
    let mutable _v3 : bool option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v4 : string = "&*$0"
    let v5 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v2 v4
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
    let v19 : string = "$0.existsSync($1)"
    let v20 : bool = Fable.Core.JsInterop.emitJsExpr struct (v18, v2) v19
    v20 
    #endif
#if FABLE_COMPILER_PYTHON
    let v21 : bool = null |> unbox<bool>
    v21 
    #endif
#else
    let v22 : (string -> bool) = System.IO.Directory.Exists
    let v23 : bool = v22 v2
    v23 
    #endif
    |> fun x -> _v3 <- Some x
    let v24 : bool = _v3.Value
    if v24 then
        v1
    else
        let v25 : (string -> string option) = method27()
        let v26 : string option = v25 v1
        let v27 : US8 option = None
        let _v27 = ref v27 
        match v26 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v28 : string = x
        let v29 : US8 = US8_0(v28)
        v29 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v27.Value <- x
        let v30 : US8 option = _v27.Value 
        let v31 : US8 = US8_1
        let v32 : US8 = v30 |> Option.defaultValue v31 
        match v32 with
        | US8_1 -> (* None *)
            let v35 : string = $"""No parent for {if false then "file" else "dir"} '{v0}' at '{v1}' (until '{v1}')"""
            failwith<string> v35
        | US8_0(v33) -> (* Some *)
            method34(v0, v1, v33)
and closure57 () () : string =
    let v0 : string = __SOURCE_DIRECTORY__
    let v1 : string = "polyglot"
    let v2 : string = ".paket"
    let v3 : string = method14(v1, v2)
    let v4 : string = method33(v3, v0)
    method14(v4, v1)
and method35 (v0 : string) : unit =
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
    let v2 : bool = true
    let mutable _v2 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : bool = true
    let mutable _v3 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v4 : string = "std::env::var(&*$0)"
    let v5 : string = "CARGO_PKG_NAME"
    let v6 : Result<std_string_String, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr v5 v4
    let v7 : string = "true; let _result = $0.map(|x| { //"
    let v8 : bool = Fable.Core.RustInterop.emitRustExpr v6 v7
    let v9 : string = "x"
    let v10 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v9
    let v11 : string = "fable_library_rust::String_::fromString($0)"
    let v12 : string = Fable.Core.RustInterop.emitRustExpr v10 v11
    let v13 : string = "true; $0 })"
    let v14 : bool = Fable.Core.RustInterop.emitRustExpr v12 v13
    let v15 : string = "_result"
    let v16 : Result<string, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr () v15
    let v17 : string = method0()
    let v18 : string = "$0.unwrap_or($1)"
    let v19 : string = Fable.Core.RustInterop.emitRustExpr struct (v16, v17) v18
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
    let v24 : string = method13()
    let v25 : (string -> string) = System.Environment.GetEnvironmentVariable
    let v26 : string = v25 v24
    v26 
    #endif
    |> fun x -> _v3 <- Some x
    let v27 : string = _v3.Value
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
    let v32 : string = System.Reflection.Assembly.GetEntryAssembly().GetName().Name
    v32 
    #endif
    |> fun x -> _v2 <- Some x
    let v33 : string = _v2.Value
    let v34 : System.DateTime = System.DateTime.Now
    let v35 : System.Guid = System.Guid.NewGuid ()
    let v36 : System.Guid = method17(v35, v34)
    let v37 : string = $"{v33}_{v36}.txt"
    let v38 : string = __SOURCE_DIRECTORY__
    let v39 : string = "polyglot"
    let v40 : string = ".paket"
    let v41 : string = method14(v39, v40)
    let v42 : string = method33(v41, v38)
    let v43 : string = method14(v42, v39)
    let v44 : string = "target/polyglot/trace"
    let v45 : string = method14(v43, v44)
    let v46 : bool = true
    let mutable _v46 : System.IO.DirectoryInfo option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v47 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    v47 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v48 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    v48 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v49 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    v49 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v50 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    v50 
    #endif
#if FABLE_COMPILER_PYTHON
    let v51 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    v51 
    #endif
#else
    let v52 : (string -> System.IO.DirectoryInfo) = System.IO.Directory.CreateDirectory
    let v53 : System.IO.DirectoryInfo = v52 v45
    v53 
    #endif
    |> fun x -> _v46 <- Some x
    let v54 : System.IO.DirectoryInfo = _v46.Value
    let v55 : string = method14(v45, v37)
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
    let v62 : System.Threading.Tasks.Task = System.IO.File.WriteAllTextAsync (v55, v0)
    let v63 : bool = true
    let mutable _v63 : Async<unit> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v64 : Async<unit> = null |> unbox<Async<unit>>
    v64 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v65 : Async<unit> = null |> unbox<Async<unit>>
    v65 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v66 : Async<unit> = null |> unbox<Async<unit>>
    v66 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v67 : Async<unit> = null |> unbox<Async<unit>>
    v67 
    #endif
#if FABLE_COMPILER_PYTHON
    let v68 : Async<unit> = null |> unbox<Async<unit>>
    v68 
    #endif
#else
    let v69 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
    let v70 : Async<unit> = v69 v62
    v70 
    #endif
    |> fun x -> _v63 <- Some x
    let v71 : Async<unit> = _v63.Value
    v71 
    #endif
    |> fun x -> _v56 <- Some x
    let v72 : Async<unit> = _v56.Value
    let v73 : bool = true
    let mutable _v73 : unit option = None 
    
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
    let v74 : (Async<unit> -> unit) = Async.RunSynchronously
    v74 v72
    () 
    #endif
    |> fun x -> _v73 <- Some x
    _v73.Value
    with ex ->
    let v75 : exn = ex
    let v76 : string = $"file_system.trace_file / ex: %A{v75}"
    method35(v76)
    (*
    *)
    () 
    #endif
    |> fun x -> _v1 <- Some x
    _v1.Value
    ()
and closure59 () (v0 : string) : unit =
    method35(v0)
and closure58 () (v0 : bool) : unit =
    let v1 : (US0 -> struct (Mut0 * Mut1 * Mut2 * int64 option * Mut3)) = closure0()
    let v2 : US0 = US0_0
    if State.trace_state.IsNone then State.trace_state <- v1 v2 |> Some
    let struct (v3 : Mut0, v4 : Mut1, v5 : Mut2, v6 : int64 option, v7 : Mut3) = State.trace_state.Value
    let v10 : (string -> unit) =
        if v0 then
            closure59()
        else
            closure1()
    v7.l0 <- v10
    ()
and closure61 (v0 : string) (v1 : string) : string =
    method14(v0, v1)
and closure60 () (v0 : string) : (string -> string) =
    closure61(v0)
let v0 : (US0 -> struct (Mut0 * Mut1 * Mut2 * int64 option * Mut3)) = closure0()
let v1 : US0 = US0_0
if State.trace_state.IsNone then State.trace_state <- v0 v1 |> Some
let v2 : (string -> Async<int64>) = closure2()
let delete_directory_async x = v2 x
let v3 : (US2 -> (string -> Async<int64>)) = closure8()
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
let create_temp_directory_name () = v12 ()
let v13 : (unit -> struct (string * System.IDisposable)) = closure36()
let create_temp_directory () = v13 ()
let v14 : (unit -> string) = closure48()
let get_source_directory () = v14 ()
let v15 : (string -> (bool -> (string -> string))) = closure49()
let find_parent x = v15 x
let v16 : (string -> string) = closure55()
let normalize_path x = v16 x
let v17 : (string -> string) = closure56()
let new_file_uri x = v17 x
let v18 : (unit -> string) = closure57()
let get_workspace_root () = v18 ()
let v19 : (bool -> unit) = closure58()
let init_trace_file x = v19 x
let v20 : (string -> (string -> string)) = closure60()
let (</>) x = v20 x
()
