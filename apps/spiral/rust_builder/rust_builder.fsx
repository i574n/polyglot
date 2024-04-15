[<Fable.Core.Erase; Fable.Core.Emit("Func0<$0>")>] type Func0<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("Func1<$0, $1>")>] type Func0<'T, 'U> = class end
[<Fable.Core.Erase; Fable.Core.Emit("Box<$0>")>] type Box<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("dyn $0")>] type Dyn<'T> = class end
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
[<Fable.Core.Erase; Fable.Core.Emit("std::path::Path")>] type std_path_Path = class end
[<Fable.Core.Erase; Fable.Core.Emit("std::path::PathBuf")>] type std_path_PathBuf = class end
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
    let v0 : string = "}//"
    Fable.Core.RustInterop.emitRustExpr () v0
    let v1 : string = "#[test] fn verify_app() { //"
    Fable.Core.RustInterop.emitRustExpr () v1
    let v2 : clap_Command = method0()
    let v3 : string = "clap::Command::debug_assert($0)"
    Fable.Core.RustInterop.emitRustExpr v2 v3
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
    let mutable _v1 = v1
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = method6(v0)
    let v3 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v4 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v2 v3
    let v5 : string = "String::from($0)"
    let v6 : std_string_String = Fable.Core.RustInterop.emitRustExpr v4 v5
    let v7 : string = "std::path::PathBuf::from($0)"
    let v8 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v6 v7
    let v9 : string = "$0.parent().map(std::path::PathBuf::from)"
    let v10 : std_path_PathBuf option = Fable.Core.RustInterop.emitRustExpr v8 v9
    let v11 : string = "$0?"
    let v12 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v10 v11
    let v13 : string = "$0.display().to_string()"
    let v14 : std_string_String = Fable.Core.RustInterop.emitRustExpr v12 v13
    let v15 : string = "fable_library_rust::String_::fromString($0)"
    let v16 : string = Fable.Core.RustInterop.emitRustExpr v14 v15
    let v17 : US0 = US0_0(v16)
    v17 
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v18 : US0 = null |> unbox<US0>
    v18 
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v19 : US0 = null |> unbox<US0>
    v19 
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v20 : (string -> System.IO.DirectoryInfo) = System.IO.Directory.GetParent
    let v21 : System.IO.DirectoryInfo = v20 v0
    let v22 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    let v23 : bool = v21 = v22
    let v34 : US0 =
        if v23 then
            US0_1
        else
            let v25 : string option = None
            let mutable _v25 = v25
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v26 : string = null |> unbox<string>
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
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v29 : string = v21.FullName
            v29 
            #endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v30 : string = null |> unbox<string>
            v30 
            #endif
            #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
            let v31 : string = Unchecked.defaultof<string>
            v31 
            #endif
            |> fun x -> _v25 <- Some x
            let v32 : string = _v25.Value
            US0_0(v32)
    v34 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v35 : string = "path"
    let v36 : IPathDirname = Fable.Core.JsInterop.importAll v35
    let v37 : string = "v36.dirname($0)"
    let v38 : string = Fable.Core.JsInterop.emitJsExpr v0 v37
    let v39 : US0 = US0_0(v38)
    v39 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v40 : US0 = Unchecked.defaultof<US0>
    v40 
    #endif
    |> fun x -> _v1 <- Some x
    let v41 : US0 = _v1.Value
    match v41 with
    | US0_1 -> (* None *)
        let v44 : string option = None
        v44
    | US0_0(v42) -> (* Some *)
        let v43 : string option = Some v42 
        v43
and method9 () : (string -> string option) =
    closure2()
and closure3 () (v0 : string) : US0 =
    US0_0(v0)
and method10 () : (string -> US0) =
    closure3()
and method11 (v0 : string, v1 : string, v2 : string) : string =
    let v3 : string option = None
    let mutable _v3 = v3
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v4 : string = method6(v2)
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
    let v24 : string = System.IO.Path.Combine (v2, v0)
    v24 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v25 : string = "path"
    let v26 : IPathJoin = Fable.Core.JsInterop.importAll v25
    let v27 : string = method7(v2)
    let v28 : string = method8(v0)
    let v29 : string = "v26.join(v27, v28)"
    let v30 : string = Fable.Core.JsInterop.emitJsExpr () v29
    v30 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v31 : string = Unchecked.defaultof<string>
    v31 
    #endif
    |> fun x -> _v3 <- Some x
    let v32 : string = _v3.Value
    let v33 : bool option = None
    let mutable _v33 = v33
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v34 : string = method6(v32)
    let v35 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v36 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v34 v35
    let v37 : string = "String::from($0)"
    let v38 : std_string_String = Fable.Core.RustInterop.emitRustExpr v36 v37
    let v39 : string = "std::path::PathBuf::from($0)"
    let v40 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v38 v39
    let v41 : string = "$0.exists()"
    let v42 : bool = Fable.Core.RustInterop.emitRustExpr v40 v41
    let v45 : bool =
        if v42 then
            let v43 : string = "$0.is_dir()"
            let v44 : bool = Fable.Core.RustInterop.emitRustExpr v40 v43
            v44
        else
            false
    v45 
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v46 : bool = null |> unbox<bool>
    v46 
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v47 : bool = null |> unbox<bool>
    v47 
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v48 : (string -> bool) = System.IO.Directory.Exists
    let v49 : bool = v48 v32
    v49 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v50 : string = "fs"
    let v51 : IFsExistsSync = Fable.Core.JsInterop.importAll v50
    let v52 : string = "v51.existsSync($0)"
    let v53 : bool = Fable.Core.JsInterop.emitJsExpr v32 v52
    v53 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v54 : bool = Unchecked.defaultof<bool>
    v54 
    #endif
    |> fun x -> _v33 <- Some x
    let v55 : bool = _v33.Value
    if v55 then
        v2
    else
        let v56 : (string -> string option) = method9()
        let v57 : string option = v56 v2
        let v58 : (string -> US0) = method10()
        let v59 : US0 = US0_1
        let v60 : US0 = v57 |> Option.map v58 |> Option.defaultValue v59 
        match v60 with
        | US0_1 -> (* None *)
            let v63 : string = $"""No parent for {if false then "file" else "dir"} '{v0}' at '{v1}' (until '{v2}')"""
            failwith<string> v63
        | US0_0(v61) -> (* Some *)
            method11(v0, v1, v61)
and method5 (v0 : string, v1 : string) : string =
    let v2 : string option = None
    let mutable _v2 = v2
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : string = method6(v1)
    let v4 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v5 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v3 v4
    let v6 : string = "String::from($0)"
    let v7 : std_string_String = Fable.Core.RustInterop.emitRustExpr v5 v6
    let v8 : string = "std::path::PathBuf::from($0)"
    let v9 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v7 v8
    let v10 : string = method6(v0)
    let v11 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v12 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v10 v11
    let v13 : string = "String::from($0)"
    let v14 : std_string_String = Fable.Core.RustInterop.emitRustExpr v12 v13
    let v15 : string = "$0.join($1)"
    let v16 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr struct (v9, v14) v15
    let v17 : string = "$0.display().to_string()"
    let v18 : std_string_String = Fable.Core.RustInterop.emitRustExpr v16 v17
    let v19 : string = "fable_library_rust::String_::fromString($0)"
    let v20 : string = Fable.Core.RustInterop.emitRustExpr v18 v19
    v20 
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v21 : string = null |> unbox<string>
    v21 
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v22 : string = null |> unbox<string>
    v22 
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v23 : string = System.IO.Path.Combine (v1, v0)
    v23 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v24 : string = "path"
    let v25 : IPathJoin = Fable.Core.JsInterop.importAll v24
    let v26 : string = method7(v1)
    let v27 : string = method8(v0)
    let v28 : string = "v25.join(v26, v27)"
    let v29 : string = Fable.Core.JsInterop.emitJsExpr () v28
    v29 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v30 : string = Unchecked.defaultof<string>
    v30 
    #endif
    |> fun x -> _v2 <- Some x
    let v31 : string = _v2.Value
    let v32 : bool option = None
    let mutable _v32 = v32
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v33 : string = method6(v31)
    let v34 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v35 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v33 v34
    let v36 : string = "String::from($0)"
    let v37 : std_string_String = Fable.Core.RustInterop.emitRustExpr v35 v36
    let v38 : string = "std::path::PathBuf::from($0)"
    let v39 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v37 v38
    let v40 : string = "$0.exists()"
    let v41 : bool = Fable.Core.RustInterop.emitRustExpr v39 v40
    let v44 : bool =
        if v41 then
            let v42 : string = "$0.is_dir()"
            let v43 : bool = Fable.Core.RustInterop.emitRustExpr v39 v42
            v43
        else
            false
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
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v47 : (string -> bool) = System.IO.Directory.Exists
    let v48 : bool = v47 v31
    v48 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v49 : string = "fs"
    let v50 : IFsExistsSync = Fable.Core.JsInterop.importAll v49
    let v51 : string = "v50.existsSync($0)"
    let v52 : bool = Fable.Core.JsInterop.emitJsExpr v31 v51
    v52 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v53 : bool = Unchecked.defaultof<bool>
    v53 
    #endif
    |> fun x -> _v32 <- Some x
    let v54 : bool = _v32.Value
    if v54 then
        v1
    else
        let v55 : (string -> string option) = method9()
        let v56 : string option = v55 v1
        let v57 : (string -> US0) = method10()
        let v58 : US0 = US0_1
        let v59 : US0 = v56 |> Option.map v57 |> Option.defaultValue v58 
        match v59 with
        | US0_1 -> (* None *)
            let v62 : string = $"""No parent for {if false then "file" else "dir"} '{v0}' at '{v1}' (until '{v1}')"""
            failwith<string> v62
        | US0_0(v60) -> (* Some *)
            method11(v0, v1, v60)
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
    let mutable _v6 = v6
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v7 : string = null |> unbox<string>
    v7 
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v8 : string = null |> unbox<string>
    v8 
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v9 : string = null |> unbox<string>
    v9 
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v10 : string = System.Reflection.Assembly.GetEntryAssembly().GetName().Name
    v10 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v11 : string = null |> unbox<string>
    v11 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v12 : string = Unchecked.defaultof<string>
    v12 
    #endif
    |> fun x -> _v6 <- Some x
    let v13 : string = _v6.Value
    let v15 : bool = v13 = "Microsoft.DotNet.Interactive.App"
    let v16 : bool = v15 <> true
    let v22 : US2 =
        if v16 then
            let v17 : System.DateTime = System.DateTime.Now
            let v18 : (System.DateTime -> int64) = _.Ticks
            let v19 : int64 = v18 v17
            US2_0(v19)
        else
            US2_1
    let v27 : int64 option =
        match v22 with
        | US2_1 -> (* None *)
            let v25 : int64 option = None
            v25
        | US2_0(v23) -> (* Some *)
            let v24 : int64 option = Some v23 
            v24
    let v28 : int64 option = method14(v27)
    v28 
    #else
    let v29 : int64 option = None
    let v30 : int64 option = method15(v29)
    v30 
    #endif
    |> fun x -> _v5 <- Some x
    let v31 : int64 option = _v5.Value
    struct (v1, v4, v0, v3, v31)
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
    let mutable _v9 = v9
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v10 : (int64 -> US3) = method16()
    let v11 : US3 = US3_1
    let v12 : US3 = v8 |> Option.map v10 |> Option.defaultValue v11 
    let v30 : System.DateTime =
        match v12 with
        | US3_1 -> (* None *)
            let v28 : System.DateTime = System.DateTime.Now
            v28
        | US3_0(v13) -> (* Some *)
            let v14 : System.DateTime = System.DateTime.Now
            let v15 : (System.DateTime -> int64) = _.Ticks
            let v16 : int64 = v15 v14
            let v17 : int64 = v16 - v13
            let v18 : System.TimeSpan = System.TimeSpan v17 
            let v19 : (System.TimeSpan -> int32) = _.Hours
            let v20 : int32 = v19 v18
            let v21 : (System.TimeSpan -> int32) = _.Minutes
            let v22 : int32 = v21 v18
            let v23 : (System.TimeSpan -> int32) = _.Seconds
            let v24 : int32 = v23 v18
            let v25 : (System.TimeSpan -> int32) = _.Milliseconds
            let v26 : int32 = v25 v18
            let v27 : System.DateTime = System.DateTime (1, 1, 1, v20, v22, v24, v26)
            v27
    let v31 : string = "hh:mm:ss"
    let v32 : string = v30.ToString v31 
    v32 
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v33 : string = method17()
    v33 
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v34 : string = method17()
    v34 
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v35 : (int64 -> US3) = method16()
    let v36 : US3 = US3_1
    let v37 : US3 = v8 |> Option.map v35 |> Option.defaultValue v36 
    let v55 : System.DateTime =
        match v37 with
        | US3_1 -> (* None *)
            let v53 : System.DateTime = System.DateTime.Now
            v53
        | US3_0(v38) -> (* Some *)
            let v39 : System.DateTime = System.DateTime.Now
            let v40 : (System.DateTime -> int64) = _.Ticks
            let v41 : int64 = v40 v39
            let v42 : int64 = v41 - v38
            let v43 : System.TimeSpan = System.TimeSpan v42 
            let v44 : (System.TimeSpan -> int32) = _.Hours
            let v45 : int32 = v44 v43
            let v46 : (System.TimeSpan -> int32) = _.Minutes
            let v47 : int32 = v46 v43
            let v48 : (System.TimeSpan -> int32) = _.Seconds
            let v49 : int32 = v48 v43
            let v50 : (System.TimeSpan -> int32) = _.Milliseconds
            let v51 : int32 = v50 v43
            let v52 : System.DateTime = System.DateTime (1, 1, 1, v45, v47, v49, v51)
            v52
    let v56 : string = "HH:mm:ss"
    let v57 : string = v55.ToString v56 
    v57 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v58 : string = method17()
    v58 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v59 : string = Unchecked.defaultof<string>
    v59 
    #endif
    |> fun x -> _v9 <- Some x
    let v60 : string = _v9.Value
    let v61 : int64 = v4.l0
    let v71 : string =
        match v0 with
        | US1_4 -> (* Critical *)
            let v66 : string = "Critical"
            v66
        | US1_1 -> (* Debug *)
            let v63 : string = "Debug"
            v63
        | US1_2 -> (* Info *)
            let v64 : string = "Info"
            v64
        | US1_0 -> (* Verbose *)
            let v62 : string = "Verbose"
            v62
        | US1_3 -> (* Warning *)
            let v65 : string = "Warning"
            v65
    let v72 : string = v71.ToLower ()
    let v73 : string option = None
    let mutable _v73 = v73
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v88 : Ref<Str> =
        match v0 with
        | US1_4 -> (* Critical *)
            let v82 : string = "inline_colorization::color_bright_red"
            let v83 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v82
            v83
        | US1_1 -> (* Debug *)
            let v76 : string = "inline_colorization::color_bright_blue"
            let v77 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v76
            v77
        | US1_2 -> (* Info *)
            let v78 : string = "inline_colorization::color_bright_green"
            let v79 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v78
            v79
        | US1_0 -> (* Verbose *)
            let v74 : string = "inline_colorization::color_bright_black"
            let v75 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v74
            v75
        | US1_3 -> (* Warning *)
            let v80 : string = "inline_colorization::color_bright_yellow"
            let v81 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v80
            v81
    let v89 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v90 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v72 v89
    let v91 : string = "inline_colorization::color_reset"
    let v92 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v91
    let v93 : string = "\"{v88}{v90}{v92}\""
    let v94 : string = @$"format!(" + v93 + ")"
    let v95 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v94
    let v96 : string = "fable_library_rust::String_::fromString($0)"
    let v97 : string = Fable.Core.RustInterop.emitRustExpr v95 v96
    v97 
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v112 : Ref<Str> =
        match v0 with
        | US1_4 -> (* Critical *)
            let v106 : string = "inline_colorization::color_bright_red"
            let v107 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v106
            v107
        | US1_1 -> (* Debug *)
            let v100 : string = "inline_colorization::color_bright_blue"
            let v101 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v100
            v101
        | US1_2 -> (* Info *)
            let v102 : string = "inline_colorization::color_bright_green"
            let v103 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v102
            v103
        | US1_0 -> (* Verbose *)
            let v98 : string = "inline_colorization::color_bright_black"
            let v99 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v98
            v99
        | US1_3 -> (* Warning *)
            let v104 : string = "inline_colorization::color_bright_yellow"
            let v105 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v104
            v105
    let v113 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v114 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v72 v113
    let v115 : string = "inline_colorization::color_reset"
    let v116 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v115
    let v117 : string = "\"{v112}{v114}{v116}\""
    let v118 : string = @$"format!(" + v117 + ")"
    let v119 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v118
    let v120 : string = "fable_library_rust::String_::fromString($0)"
    let v121 : string = Fable.Core.RustInterop.emitRustExpr v119 v120
    v121 
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v136 : Ref<Str> =
        match v0 with
        | US1_4 -> (* Critical *)
            let v130 : string = "inline_colorization::color_bright_red"
            let v131 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v130
            v131
        | US1_1 -> (* Debug *)
            let v124 : string = "inline_colorization::color_bright_blue"
            let v125 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v124
            v125
        | US1_2 -> (* Info *)
            let v126 : string = "inline_colorization::color_bright_green"
            let v127 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v126
            v127
        | US1_0 -> (* Verbose *)
            let v122 : string = "inline_colorization::color_bright_black"
            let v123 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v122
            v123
        | US1_3 -> (* Warning *)
            let v128 : string = "inline_colorization::color_bright_yellow"
            let v129 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v128
            v129
    let v137 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v138 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v72 v137
    let v139 : string = "inline_colorization::color_reset"
    let v140 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v139
    let v141 : string = "\"{v136}{v138}{v140}\""
    let v142 : string = @$"format!(" + v141 + ")"
    let v143 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v142
    let v144 : string = "fable_library_rust::String_::fromString($0)"
    let v145 : string = Fable.Core.RustInterop.emitRustExpr v143 v144
    v145 
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    v72 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    v72 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v146 : string = Unchecked.defaultof<string>
    v146 
    #endif
    |> fun x -> _v73 <- Some x
    let v147 : string = _v73.Value
    let v148 : string = $"{v60} {v147} #{v61} %s{v1 ()} / %s{v2 ()}"
    let v149 : (char []) = [||]
    let v150 : string = v148.TrimStart v149
    let v151 : (char []) = [|' '; '/'|]
    let v152 : string = v150.TrimEnd v151
    v152
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
        let mutable _v22 = v22
        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v23 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v21 v23
        () 
        #endif
        #if FABLE_COMPILER_RUST && WASM
        let v24 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v21 v24
        () 
        #endif
        #if FABLE_COMPILER_RUST && CONTRACT
        let v25 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v21 v25
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
    let mutable _v2 = v2
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : string = method1()
    let v4 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v5 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v3 v4
    let v6 : string = "String::from($0)"
    let v7 : std_string_String = Fable.Core.RustInterop.emitRustExpr v5 v6
    let v8 : string = "std::path::PathBuf::from($0)"
    let v9 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v7 v8
    let v10 : string = method2()
    let v11 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v12 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v10 v11
    let v13 : string = "String::from($0)"
    let v14 : std_string_String = Fable.Core.RustInterop.emitRustExpr v12 v13
    let v15 : string = "$0.join($1)"
    let v16 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr struct (v9, v14) v15
    let v17 : string = "$0.display().to_string()"
    let v18 : std_string_String = Fable.Core.RustInterop.emitRustExpr v16 v17
    let v19 : string = "fable_library_rust::String_::fromString($0)"
    let v20 : string = Fable.Core.RustInterop.emitRustExpr v18 v19
    v20 
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v21 : string = null |> unbox<string>
    v21 
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v22 : string = null |> unbox<string>
    v22 
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v23 : string = "polyglot"
    let v24 : string = ".paket"
    let v25 : string = System.IO.Path.Combine (v23, v24)
    v25 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v26 : string = "path"
    let v27 : IPathJoin = Fable.Core.JsInterop.importAll v26
    let v28 : string = method3()
    let v29 : string = method4()
    let v30 : string = "v27.join(v28, v29)"
    let v31 : string = Fable.Core.JsInterop.emitJsExpr () v30
    v31 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v32 : string = Unchecked.defaultof<string>
    v32 
    #endif
    |> fun x -> _v2 <- Some x
    let v33 : string = _v2.Value
    let v34 : string = method5(v33, v1)
    let v35 : string option = None
    let mutable _v35 = v35
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v36 : string = method6(v34)
    let v37 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v38 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v36 v37
    let v39 : string = "String::from($0)"
    let v40 : std_string_String = Fable.Core.RustInterop.emitRustExpr v38 v39
    let v41 : string = "std::path::PathBuf::from($0)"
    let v42 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v40 v41
    let v43 : string = method1()
    let v44 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v45 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v43 v44
    let v46 : string = "String::from($0)"
    let v47 : std_string_String = Fable.Core.RustInterop.emitRustExpr v45 v46
    let v48 : string = "$0.join($1)"
    let v49 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr struct (v42, v47) v48
    let v50 : string = "$0.display().to_string()"
    let v51 : std_string_String = Fable.Core.RustInterop.emitRustExpr v49 v50
    let v52 : string = "fable_library_rust::String_::fromString($0)"
    let v53 : string = Fable.Core.RustInterop.emitRustExpr v51 v52
    v53 
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v54 : string = null |> unbox<string>
    v54 
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v55 : string = null |> unbox<string>
    v55 
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v56 : string = System.IO.Path.Combine (v34, v23)
    v56 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v57 : IPathJoin = Fable.Core.JsInterop.importAll v26
    let v58 : string = method7(v34)
    let v59 : string = method12()
    let v60 : string = "v57.join(v58, v59)"
    let v61 : string = Fable.Core.JsInterop.emitJsExpr () v60
    v61 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v62 : string = Unchecked.defaultof<string>
    v62 
    #endif
    |> fun x -> _v35 <- Some x
    let v63 : string = _v35.Value
    let v64 : US1 = US1_1
    let v65 : (unit -> string) = closure4()
    let v66 : (unit -> string) = closure5(v0, v63)
    method13(v64, v65, v66)
    let v67 : clap_Command = method0()
    let v68 : string = "clap::Command::get_matches($0)"
    let v69 : clap_ArgMatches = Fable.Core.RustInterop.emitRustExpr v67 v68
    let v70 : US1 = US1_1
    let v71 : (unit -> string) = closure10()
    let v72 : (unit -> string) = closure11(v67, v69)
    method13(v70, v71, v72)
    0
let v0 : (unit -> unit) = closure0()
let tests () = v0 ()
let v1 : ((string []) -> int32) = closure1()
let main args = v1 args
()
