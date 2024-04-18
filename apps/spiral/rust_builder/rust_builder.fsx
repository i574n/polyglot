[<Fable.Core.Erase; Fable.Core.Emit("Func0<$0>")>] type Func0<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("Func1<$0, $1>")>] type Func0<'T, 'U> = class end
[<Fable.Core.Erase; Fable.Core.Emit("Box<$0>")>] type Box<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("dyn $0")>] type Dyn<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("$0 + Send")>] type Send<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("Fn() -> $0")>] type Fn<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("Fn()")>] type FnUnit = class end
[<Fable.Core.Erase; Fable.Core.Emit("FnOnce() -> $0")>] type FnOnce<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("Fn($0, $1)")>] type ActionFn2<'T, 'U> = class end
[<Fable.Core.Erase; Fable.Core.Emit("impl $0")>] type Impl<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("mut $0")>] type Mut<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("&$0")>] type Ref<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("&'static $0")>] type StaticRef<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("MutCell<$0>")>] type MutCell<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("std::any::Any")>] type std_any_Any = class end
[<Fable.Core.Erase; Fable.Core.Emit("std::cell::RefCell<$0>")>] type std_cell_RefCell<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("std::pin::Pin<$0>")>] type std_pin_Pin<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("std::rc::Rc<$0>")>] type std_rc_Rc<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("std::rc::Weak<$0>")>] type std_rc_Weak<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("std::sync::Arc<$0>")>] type std_sync_Arc<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("str")>] type Str = class end
[<Fable.Core.Erase; Fable.Core.Emit("base64::DecodeError")>] type base64_DecodeError = class end
[<Fable.Core.Erase; Fable.Core.Emit("borsh::io::Error")>] type borsh_io_Error = class end
[<Fable.Core.Erase; Fable.Core.Emit("js_sys::JsString")>] type js_sys_JsString = class end
[<Fable.Core.Erase; Fable.Core.Emit("serde_json::Error")>] type serde_json_Error = class end
[<Fable.Core.Erase; Fable.Core.Emit("serde_json::Value")>] type serde_json_Value = class end
[<Fable.Core.Erase; Fable.Core.Emit("serde_wasm_bindgen::Error")>] type serde_wasm_bindgen_Error = class end
[<Fable.Core.Erase; Fable.Core.Emit("std::ffi::OsStr")>] type std_ffi_OsStr = class end
[<Fable.Core.Erase; Fable.Core.Emit("std::ffi::OsString")>] type std_ffi_OsString = class end
[<Fable.Core.Erase; Fable.Core.Emit("std::str::Utf8Error")>] type std_str_Utf8Error = class end
[<Fable.Core.Erase; Fable.Core.Emit("std::string::String")>] type std_string_String = class end
#if FABLE_COMPILER // file_system.types
[<Fable.Core.Erase; Fable.Core.Emit("std::io::Error")>] type std_io_Error = class end
[<Fable.Core.Erase; Fable.Core.Emit("std::path::Path")>] type std_path_Path = class end
[<Fable.Core.Erase; Fable.Core.Emit("std::path::PathBuf")>] type std_path_PathBuf = class end
[<Fable.Core.Erase; Fable.Core.Emit("async_walkdir::DirEntry")>] type async_walkdir_DirEntry = class end
[<Fable.Core.Erase; Fable.Core.Emit("async_walkdir::WalkDir")>] type async_walkdir_WalkDir = class end
#endif // file_system.types
#if FABLE_COMPILER // runtime.types
[<Fable.Core.Erase; Fable.Core.Emit("clap::Arg")>] type clap_Arg = class end
[<Fable.Core.Erase; Fable.Core.Emit("clap::Command")>] type clap_Command = class end
[<Fable.Core.Erase; Fable.Core.Emit("clap::ArgMatches")>] type clap_ArgMatches = class end
#endif // runtime.types
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
    let v14 : string = "$0.display().to_string()"
    let v15 : std_string_String = Fable.Core.RustInterop.emitRustExpr v13 v14
    let v16 : string = "fable_library_rust::String_::fromString($0)"
    let v17 : string = Fable.Core.RustInterop.emitRustExpr v15 v16
    let v18 : US0 = US0_0(v17)
    v18
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v19 : US0 = null |> unbox<US0>
    v19
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v20 : US0 = null |> unbox<US0>
    v20
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v21 : (string -> System.IO.DirectoryInfo) = System.IO.Directory.GetParent
    let v22 : System.IO.DirectoryInfo = v21 v0
    let v23 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    let v24 : bool = v22 = v23
    let v36 : US0 =
        if v24 then
            US0_1
        else
            let v26 : string option = None
            let v27 : bool = true in let mutable _v26 = v26
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v28 : string = null |> unbox<string>
            v28
#endif
            #if FABLE_COMPILER_RUST && WASM
            let v29 : string = null |> unbox<string>
            v29
#endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let v30 : string = null |> unbox<string>
            v30
#endif
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v31 : string = v22.FullName
            v31
#endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v32 : string = null |> unbox<string>
            v32
#endif
            #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
            let v33 : string = Unchecked.defaultof<string>
            v33
#endif
            |> fun x -> _v26 <- Some x
            let v34 : string = _v26.Value
            US0_0(v34)
    v36
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v37 : string = "path"
    let v38 : IPathDirname = Fable.Core.JsInterop.importAll v37
    let v39 : string = "v38.dirname($0)"
    let v40 : string = Fable.Core.JsInterop.emitJsExpr v0 v39
    let v41 : US0 = US0_0(v40)
    v41
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v42 : US0 = Unchecked.defaultof<US0>
    v42
#endif
    |> fun x -> _v1 <- Some x
    let v43 : US0 = _v1.Value
    match v43 with
    | US0_1 -> (* None *)
        let v46 : string option = None
        v46
    | US0_0(v44) -> (* Some *)
        let v45 : string option = Some v44 
        v45
and method9 () : (string -> string option) =
    closure2()
and closure3 () (v0 : string) : US0 =
    US0_0(v0)
and method10 () : (string -> US0) =
    closure3()
and method11 (v0 : string, v1 : string, v2 : string) : string =
    let v3 : string option = None
    let v4 : bool = true in let mutable _v3 = v3
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
    let v19 : string = "$0.display().to_string()"
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
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v25 : string = System.IO.Path.Combine (v2, v0)
    v25
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v26 : string = "path"
    let v27 : IPathJoin = Fable.Core.JsInterop.importAll v26
    let v28 : string = method7(v2)
    let v29 : string = method8(v0)
    let v30 : string = "v27.join(v28, v29)"
    let v31 : string = Fable.Core.JsInterop.emitJsExpr () v30
    v31
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v32 : string = Unchecked.defaultof<string>
    v32
#endif
    |> fun x -> _v3 <- Some x
    let v33 : string = _v3.Value
    let v34 : bool option = None
    let v35 : bool = true in let mutable _v34 = v34
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v36 : string = method6(v33)
    let v37 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v38 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v36 v37
    let v39 : string = "String::from($0)"
    let v40 : std_string_String = Fable.Core.RustInterop.emitRustExpr v38 v39
    let v41 : string = "std::path::PathBuf::from($0)"
    let v42 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v40 v41
    let v43 : string = "$0.exists()"
    let v44 : bool = Fable.Core.RustInterop.emitRustExpr v42 v43
    let v47 : bool =
        if v44 then
            let v45 : string = "$0.is_dir()"
            let v46 : bool = Fable.Core.RustInterop.emitRustExpr v42 v45
            v46
        else
            false
    v47
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v48 : bool = null |> unbox<bool>
    v48
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v49 : bool = null |> unbox<bool>
    v49
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v50 : (string -> bool) = System.IO.Directory.Exists
    let v51 : bool = v50 v33
    v51
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v52 : string = "fs"
    let v53 : IFsExistsSync = Fable.Core.JsInterop.importAll v52
    let v54 : string = "v53.existsSync($0)"
    let v55 : bool = Fable.Core.JsInterop.emitJsExpr v33 v54
    v55
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v56 : bool = Unchecked.defaultof<bool>
    v56
#endif
    |> fun x -> _v34 <- Some x
    let v57 : bool = _v34.Value
    if v57 then
        v2
    else
        let v58 : (string -> string option) = method9()
        let v59 : string option = v58 v2
        let v60 : (string -> US0) = method10()
        let v61 : US0 = US0_1
        let v62 : US0 = v59 |> Option.map v60 |> Option.defaultValue v61 
        match v62 with
        | US0_1 -> (* None *)
            let v65 : string = $"""No parent for {if false then "file" else "dir"} '{v0}' at '{v1}' (until '{v2}')"""
            failwith<string> v65
        | US0_0(v63) -> (* Some *)
            method11(v0, v1, v63)
and method5 (v0 : string, v1 : string) : string =
    let v2 : string option = None
    let v3 : bool = true in let mutable _v2 = v2
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
    let v18 : string = "$0.display().to_string()"
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
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v24 : string = System.IO.Path.Combine (v1, v0)
    v24
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v25 : string = "path"
    let v26 : IPathJoin = Fable.Core.JsInterop.importAll v25
    let v27 : string = method7(v1)
    let v28 : string = method8(v0)
    let v29 : string = "v26.join(v27, v28)"
    let v30 : string = Fable.Core.JsInterop.emitJsExpr () v29
    v30
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v31 : string = Unchecked.defaultof<string>
    v31
#endif
    |> fun x -> _v2 <- Some x
    let v32 : string = _v2.Value
    let v33 : bool option = None
    let v34 : bool = true in let mutable _v33 = v33
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v35 : string = method6(v32)
    let v36 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v37 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v35 v36
    let v38 : string = "String::from($0)"
    let v39 : std_string_String = Fable.Core.RustInterop.emitRustExpr v37 v38
    let v40 : string = "std::path::PathBuf::from($0)"
    let v41 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v39 v40
    let v42 : string = "$0.exists()"
    let v43 : bool = Fable.Core.RustInterop.emitRustExpr v41 v42
    let v46 : bool =
        if v43 then
            let v44 : string = "$0.is_dir()"
            let v45 : bool = Fable.Core.RustInterop.emitRustExpr v41 v44
            v45
        else
            false
    v46
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v47 : bool = null |> unbox<bool>
    v47
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v48 : bool = null |> unbox<bool>
    v48
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v49 : (string -> bool) = System.IO.Directory.Exists
    let v50 : bool = v49 v32
    v50
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v51 : string = "fs"
    let v52 : IFsExistsSync = Fable.Core.JsInterop.importAll v51
    let v53 : string = "v52.existsSync($0)"
    let v54 : bool = Fable.Core.JsInterop.emitJsExpr v32 v53
    v54
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v55 : bool = Unchecked.defaultof<bool>
    v55
#endif
    |> fun x -> _v33 <- Some x
    let v56 : bool = _v33.Value
    if v56 then
        v1
    else
        let v57 : (string -> string option) = method9()
        let v58 : string option = v57 v1
        let v59 : (string -> US0) = method10()
        let v60 : US0 = US0_1
        let v61 : US0 = v58 |> Option.map v59 |> Option.defaultValue v60 
        match v61 with
        | US0_1 -> (* None *)
            let v64 : string = $"""No parent for {if false then "file" else "dir"} '{v0}' at '{v1}' (until '{v1}')"""
            failwith<string> v64
        | US0_0(v62) -> (* Some *)
            method11(v0, v1, v62)
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
and method14 (v0 : int64 option) : int64 option =
    v0
and method15 (v0 : int64 option) : int64 option =
    v0
and closure7 () () : struct (Mut0 * Mut1 * Mut1 * Mut2 * int64 option) =
    let v0 : Mut1 = {l0 = true} : Mut1
    let v1 : Mut0 = {l0 = 0L} : Mut0
    let v2 : US1 = US1_0
    let v3 : Mut2 = {l0 = v2} : Mut2
    let v4 : Mut1 = {l0 = false} : Mut1
    let v5 : int64 option option = None
    let mutable _v5 = v5
    #if INTERACTIVE || !FABLE_COMPILER
    let v6 : string option = None
    let v7 : bool = true in let mutable _v6 = v6
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v8 : string = null |> unbox<string>
    v8
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v9 : string = null |> unbox<string>
    v9
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v10 : string = null |> unbox<string>
    v10
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v11 : string = System.Reflection.Assembly.GetEntryAssembly().GetName().Name
    v11
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v12 : string = null |> unbox<string>
    v12
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v13 : string = Unchecked.defaultof<string>
    v13
#endif
    |> fun x -> _v6 <- Some x
    let v14 : string = _v6.Value
    let v16 : bool = v14 = "Microsoft.DotNet.Interactive.App"
    let v17 : bool = v16 <> true
    let v23 : US2 =
        if v17 then
            let v18 : System.DateTime = System.DateTime.Now
            let v19 : (System.DateTime -> int64) = _.Ticks
            let v20 : int64 = v19 v18
            US2_0(v20)
        else
            US2_1
    let v28 : int64 option =
        match v23 with
        | US2_1 -> (* None *)
            let v26 : int64 option = None
            v26
        | US2_0(v24) -> (* Some *)
            let v25 : int64 option = Some v24 
            v25
    let v29 : int64 option = method14(v28)
    v29 
    #else
    let v30 : int64 option = None
    let v31 : int64 option = method15(v30)
    v31 
    #endif
    |> fun x -> _v5 <- Some x
    let v32 : int64 option = _v5.Value
    struct (v1, v4, v0, v3, v32)
and closure9 () (v0 : int64) : US3 =
    US3_0(v0)
and method16 () : (int64 -> US3) =
    closure9()
and method17 () : string =
    let v0 : string = ""
    v0
and closure8 (v0 : US1, v1 : (unit -> string), v2 : (unit -> string)) () : string =
    let v3 : (unit -> struct (Mut0 * Mut1 * Mut1 * Mut2 * int64 option)) = closure7()
    if State.trace_state = None then State.trace_state <- v3 () |> Some
    let struct (v4 : Mut0, v5 : Mut1, v6 : Mut1, v7 : Mut2, v8 : int64 option) = State.trace_state.Value
    let v9 : string option = None
    let v10 : bool = true in let mutable _v9 = v9
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v11 : (int64 -> US3) = method16()
    let v12 : US3 = US3_1
    let v13 : US3 = v8 |> Option.map v11 |> Option.defaultValue v12 
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
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v36 : (int64 -> US3) = method16()
    let v37 : US3 = US3_1
    let v38 : US3 = v8 |> Option.map v36 |> Option.defaultValue v37 
    let v56 : System.DateTime =
        match v38 with
        | US3_1 -> (* None *)
            let v54 : System.DateTime = System.DateTime.Now
            v54
        | US3_0(v39) -> (* Some *)
            let v40 : System.DateTime = System.DateTime.Now
            let v41 : (System.DateTime -> int64) = _.Ticks
            let v42 : int64 = v41 v40
            let v43 : int64 = v42 - v39
            let v44 : System.TimeSpan = System.TimeSpan v43 
            let v45 : (System.TimeSpan -> int32) = _.Hours
            let v46 : int32 = v45 v44
            let v47 : (System.TimeSpan -> int32) = _.Minutes
            let v48 : int32 = v47 v44
            let v49 : (System.TimeSpan -> int32) = _.Seconds
            let v50 : int32 = v49 v44
            let v51 : (System.TimeSpan -> int32) = _.Milliseconds
            let v52 : int32 = v51 v44
            let v53 : System.DateTime = System.DateTime (1, 1, 1, v46, v48, v50, v52)
            v53
    let v57 : string = "HH:mm:ss"
    let v58 : string = v56.ToString v57 
    v58
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v59 : string = method17()
    v59
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v60 : string = Unchecked.defaultof<string>
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
    let v74 : string option = None
    let v75 : bool = true in let mutable _v74 = v74
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v90 : Ref<Str> =
        match v0 with
        | US1_4 -> (* Critical *)
            let v84 : string = "inline_colorization::color_bright_red"
            let v85 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v84
            v85
        | US1_1 -> (* Debug *)
            let v78 : string = "inline_colorization::color_bright_blue"
            let v79 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v78
            v79
        | US1_2 -> (* Info *)
            let v80 : string = "inline_colorization::color_bright_green"
            let v81 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v80
            v81
        | US1_0 -> (* Verbose *)
            let v76 : string = "inline_colorization::color_bright_black"
            let v77 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v76
            v77
        | US1_3 -> (* Warning *)
            let v82 : string = "inline_colorization::color_bright_yellow"
            let v83 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v82
            v83
    let v91 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v92 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v73 v91
    let v93 : string = "inline_colorization::color_reset"
    let v94 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v93
    let v95 : string = "\"{v90}{v92}{v94}\""
    let v96 : string = @$"format!(" + v95 + ")"
    let v97 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v96
    let v98 : string = "fable_library_rust::String_::fromString($0)"
    let v99 : string = Fable.Core.RustInterop.emitRustExpr v97 v98
    v99
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v114 : Ref<Str> =
        match v0 with
        | US1_4 -> (* Critical *)
            let v108 : string = "inline_colorization::color_bright_red"
            let v109 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v108
            v109
        | US1_1 -> (* Debug *)
            let v102 : string = "inline_colorization::color_bright_blue"
            let v103 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v102
            v103
        | US1_2 -> (* Info *)
            let v104 : string = "inline_colorization::color_bright_green"
            let v105 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v104
            v105
        | US1_0 -> (* Verbose *)
            let v100 : string = "inline_colorization::color_bright_black"
            let v101 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v100
            v101
        | US1_3 -> (* Warning *)
            let v106 : string = "inline_colorization::color_bright_yellow"
            let v107 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v106
            v107
    let v115 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v116 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v73 v115
    let v117 : string = "inline_colorization::color_reset"
    let v118 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v117
    let v119 : string = "\"{v114}{v116}{v118}\""
    let v120 : string = @$"format!(" + v119 + ")"
    let v121 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v120
    let v122 : string = "fable_library_rust::String_::fromString($0)"
    let v123 : string = Fable.Core.RustInterop.emitRustExpr v121 v122
    v123
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v138 : Ref<Str> =
        match v0 with
        | US1_4 -> (* Critical *)
            let v132 : string = "inline_colorization::color_bright_red"
            let v133 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v132
            v133
        | US1_1 -> (* Debug *)
            let v126 : string = "inline_colorization::color_bright_blue"
            let v127 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v126
            v127
        | US1_2 -> (* Info *)
            let v128 : string = "inline_colorization::color_bright_green"
            let v129 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v128
            v129
        | US1_0 -> (* Verbose *)
            let v124 : string = "inline_colorization::color_bright_black"
            let v125 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v124
            v125
        | US1_3 -> (* Warning *)
            let v130 : string = "inline_colorization::color_bright_yellow"
            let v131 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v130
            v131
    let v139 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v140 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v73 v139
    let v141 : string = "inline_colorization::color_reset"
    let v142 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v141
    let v143 : string = "\"{v138}{v140}{v142}\""
    let v144 : string = @$"format!(" + v143 + ")"
    let v145 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v144
    let v146 : string = "fable_library_rust::String_::fromString($0)"
    let v147 : string = Fable.Core.RustInterop.emitRustExpr v145 v146
    v147
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    v73
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    v73
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v148 : string = Unchecked.defaultof<string>
    v148
#endif
    |> fun x -> _v74 <- Some x
    let v149 : string = _v74.Value
    let v150 : string = $"{v61} {v149} #{v62} %s{v1 ()} / %s{v2 ()}"
    let v151 : (char []) = [||]
    let v152 : string = v150.TrimStart v151
    let v153 : (char []) = [|' '; '/'|]
    let v154 : string = v152.TrimEnd v153
    v154
and method13 (v0 : US1, v1 : (unit -> string), v2 : (unit -> string)) : unit =
    let v3 : (unit -> struct (Mut0 * Mut1 * Mut1 * Mut2 * int64 option)) = closure7()
    if State.trace_state = None then State.trace_state <- v3 () |> Some
    let struct (v4 : Mut0, v5 : Mut1, v6 : Mut1, v7 : Mut2, v8 : int64 option) = State.trace_state.Value
    if State.trace_state = None then State.trace_state <- v3 () |> Some
    let struct (v9 : Mut0, v10 : Mut1, v11 : Mut1, v12 : Mut2, v13 : int64 option) = State.trace_state.Value
    let v14 : US1 = v12.l0
    let v15 : bool = v11.l0
    let v17 : bool =
        if v15 then
            let v16 : bool = v0 >= v14 
            v16
        else
            false
    if v17 then
        let v18 : int64 = v4.l0
        let v19 : int64 = v18 + 1L
        v4.l0 <- v19
        let v20 : (unit -> string) = closure8(v0, v1, v2)
        let v21 : string = $"%s{v20 ()}"
        let v22 : unit option = None
        let v23 : bool = true in let mutable _v22 = v22
        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v24 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v21 v24
        ()
#endif
        #if FABLE_COMPILER_RUST && WASM
        let v25 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v21 v25
        ()
#endif
        #if FABLE_COMPILER_RUST && CONTRACT
        let v26 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v21 v26
        ()
#endif
        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
        System.Console.WriteLine v21 
        ()
#endif
        #if FABLE_COMPILER_TYPESCRIPT
        System.Console.WriteLine v21 
        ()
#endif
        #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
        Unchecked.defaultof<unit>
        ()
#endif
        |> fun x -> _v22 <- Some x
        _v22.Value
        ()
and closure10 () () : string =
    let v0 : string = $"rust_builder"
    v0
and closure11 (v0 : clap_Command, v1 : clap_ArgMatches) () : string =
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
    let v18 : string = "$0.display().to_string()"
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
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v24 : string = "polyglot"
    let v25 : string = ".paket"
    let v26 : string = System.IO.Path.Combine (v24, v25)
    v26
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v27 : string = "path"
    let v28 : IPathJoin = Fable.Core.JsInterop.importAll v27
    let v29 : string = method3()
    let v30 : string = method4()
    let v31 : string = "v28.join(v29, v30)"
    let v32 : string = Fable.Core.JsInterop.emitJsExpr () v31
    v32
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v33 : string = Unchecked.defaultof<string>
    v33
#endif
    |> fun x -> _v2 <- Some x
    let v34 : string = _v2.Value
    let v35 : string = method5(v34, v1)
    let v36 : string option = None
    let v37 : bool = true in let mutable _v36 = v36
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v38 : string = method6(v35)
    let v39 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v40 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v38 v39
    let v41 : string = "String::from($0)"
    let v42 : std_string_String = Fable.Core.RustInterop.emitRustExpr v40 v41
    let v43 : string = "std::path::PathBuf::from($0)"
    let v44 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v42 v43
    let v45 : string = method1()
    let v46 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v47 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v45 v46
    let v48 : string = "String::from($0)"
    let v49 : std_string_String = Fable.Core.RustInterop.emitRustExpr v47 v48
    let v50 : string = "$0.join($1)"
    let v51 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr struct (v44, v49) v50
    let v52 : string = "$0.display().to_string()"
    let v53 : std_string_String = Fable.Core.RustInterop.emitRustExpr v51 v52
    let v54 : string = "fable_library_rust::String_::fromString($0)"
    let v55 : string = Fable.Core.RustInterop.emitRustExpr v53 v54
    v55
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v56 : string = null |> unbox<string>
    v56
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v57 : string = null |> unbox<string>
    v57
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v58 : string = System.IO.Path.Combine (v35, v24)
    v58
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v59 : IPathJoin = Fable.Core.JsInterop.importAll v27
    let v60 : string = method7(v35)
    let v61 : string = method12()
    let v62 : string = "v59.join(v60, v61)"
    let v63 : string = Fable.Core.JsInterop.emitJsExpr () v62
    v63
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v64 : string = Unchecked.defaultof<string>
    v64
#endif
    |> fun x -> _v36 <- Some x
    let v65 : string = _v36.Value
    let v66 : US1 = US1_1
    let v67 : (unit -> string) = closure4()
    let v68 : (unit -> string) = closure5(v0, v65)
    method13(v66, v67, v68)
    let v69 : clap_Command = method0()
    let v70 : string = "clap::Command::get_matches($0)"
    let v71 : clap_ArgMatches = Fable.Core.RustInterop.emitRustExpr v69 v70
    let v72 : US1 = US1_1
    let v73 : (unit -> string) = closure10()
    let v74 : (unit -> string) = closure11(v69, v71)
    method13(v72, v73, v74)
    0
let v0 : (unit -> unit) = closure0()
let tests () = v0 ()
let v1 : ((string []) -> int32) = closure1()
let main args = v1 args
()
