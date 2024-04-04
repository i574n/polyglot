#if FABLE_COMPILER // file_system.types
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
[<Fable.Core.Erase; Fable.Core.Emit("std::path::Path")>] type std_path_Path = class end
[<Fable.Core.Erase; Fable.Core.Emit("std::path::PathBuf")>] type std_path_PathBuf = class end
#endif // file_system.types
type [<Struct>] US0 =
    | US0_0 of f0_0 : string
    | US0_1
let rec method0 (v0 : string) : string =
    v0
and closure0 () () : string =
    let v0 : string option = None
    let mutable _v0 = v0
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1 : string = null |> unbox<string>
    v1
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v2 : string = null |> unbox<string>
    v2
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v3 : string = null |> unbox<string>
    v3
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !WASM
    let v4 : string = System.Reflection.Assembly.GetEntryAssembly().GetName().Name
    let v5 : (unit -> string) = System.IO.Path.GetTempPath
    let v6 : string = v5 ()
    let v7 : string = $"!{v4}"
    let v8 : string option = None
    let mutable _v8 = v8
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v9 : string = method0(v6)
    let v10 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v11 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v9 v10
    let v12 : string = "String::from($0)"
    let v13 : std_string_String = Fable.Core.RustInterop.emitRustExpr v11 v12
    let v14 : string = "std::path::PathBuf::from($0)"
    let v15 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v13 v14
    let v16 : string = method0(v7)
    let v17 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v18 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v16 v17
    let v19 : string = "String::from($0)"
    let v20 : std_string_String = Fable.Core.RustInterop.emitRustExpr v18 v19
    let v21 : string = "$0.join($1)"
    let v22 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr struct (v15, v20) v21
    let v23 : string = "$0.display().to_string()"
    let v24 : std_string_String = Fable.Core.RustInterop.emitRustExpr v22 v23
    let v25 : string = "fable_library_rust::String_::fromString($0)"
    let v26 : string = Fable.Core.RustInterop.emitRustExpr v24 v25
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
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !WASM
    let v29 : string = System.IO.Path.Combine (v6, v7)
    v29
    #endif
    #if FABLE_COMPILER && !FABLE_COMPILER_RUST && !WASM
    let v30 : string = null |> unbox<string>
    v30
    #endif
    #if !FABLE_COMPILER_RUST && WASM
    let v31 : string = null |> unbox<string>
    v31
    #endif
    |> fun x -> _v8 <- Some x
    let v32 : string = _v8 |> Option.get
    let v33 : System.DateTime = System.DateTime.Now
    let v34 : System.Guid = System.Guid.NewGuid ()
    let v35 : (System.Guid -> string) = _.ToString()
    let v36 : string = v35 v34
    let v37 : string = v33.ToString "yyyyMMdd-HHmm-ssff-ffff-f"
    let v38 : System.Guid = System.Guid $"{v37}{v36.[v37.Length..]}"
    let v39 : (System.Guid -> string) = _.ToString()
    let v40 : string = v39 v38
    let v41 : string option = None
    let mutable _v41 = v41
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v42 : string = method0(v32)
    let v43 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v44 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v42 v43
    let v45 : string = "String::from($0)"
    let v46 : std_string_String = Fable.Core.RustInterop.emitRustExpr v44 v45
    let v47 : string = "std::path::PathBuf::from($0)"
    let v48 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v46 v47
    let v49 : string = method0(v40)
    let v50 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v51 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v49 v50
    let v52 : string = "String::from($0)"
    let v53 : std_string_String = Fable.Core.RustInterop.emitRustExpr v51 v52
    let v54 : string = "$0.join($1)"
    let v55 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr struct (v48, v53) v54
    let v56 : string = "$0.display().to_string()"
    let v57 : std_string_String = Fable.Core.RustInterop.emitRustExpr v55 v56
    let v58 : string = "fable_library_rust::String_::fromString($0)"
    let v59 : string = Fable.Core.RustInterop.emitRustExpr v57 v58
    v59
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v60 : string = null |> unbox<string>
    v60
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v61 : string = null |> unbox<string>
    v61
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !WASM
    let v62 : string = System.IO.Path.Combine (v32, v40)
    v62
    #endif
    #if FABLE_COMPILER && !FABLE_COMPILER_RUST && !WASM
    let v63 : string = null |> unbox<string>
    v63
    #endif
    #if !FABLE_COMPILER_RUST && WASM
    let v64 : string = null |> unbox<string>
    v64
    #endif
    |> fun x -> _v41 <- Some x
    let v65 : string = _v41 |> Option.get
    v65
    #endif
    #if FABLE_COMPILER && !FABLE_COMPILER_RUST && !WASM
    let v66 : string = null |> unbox<string>
    v66
    #endif
    #if !FABLE_COMPILER_RUST && WASM
    let v67 : string = null |> unbox<string>
    v67
    #endif
    |> fun x -> _v0 <- Some x
    let v68 : string = _v0 |> Option.get
    v68
and closure3 () () : string =
    let v0 : string = ""
    v0
and closure2 (v0 : string, v1 : string) () : string =
    let v2 : (unit -> string) = closure3()
    let v3 : string = $"temp_folder: {v0} / result: {v1} {v2 ()}"
    v3
and closure1 () () : string =
    let v0 : string option = None
    let mutable _v0 = v0
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1 : string = null |> unbox<string>
    v1
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v2 : string = null |> unbox<string>
    v2
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v3 : string = null |> unbox<string>
    v3
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !WASM
    let v4 : string option = None
    let mutable _v4 = v4
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v5 : string = null |> unbox<string>
    v5
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v6 : string = null |> unbox<string>
    v6
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v7 : string = null |> unbox<string>
    v7
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !WASM
    let v8 : string = System.Reflection.Assembly.GetEntryAssembly().GetName().Name
    let v9 : (unit -> string) = System.IO.Path.GetTempPath
    let v10 : string = v9 ()
    let v11 : string = $"!{v8}"
    let v12 : string option = None
    let mutable _v12 = v12
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v13 : string = method0(v10)
    let v14 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v15 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v13 v14
    let v16 : string = "String::from($0)"
    let v17 : std_string_String = Fable.Core.RustInterop.emitRustExpr v15 v16
    let v18 : string = "std::path::PathBuf::from($0)"
    let v19 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v17 v18
    let v20 : string = method0(v11)
    let v21 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v22 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v20 v21
    let v23 : string = "String::from($0)"
    let v24 : std_string_String = Fable.Core.RustInterop.emitRustExpr v22 v23
    let v25 : string = "$0.join($1)"
    let v26 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr struct (v19, v24) v25
    let v27 : string = "$0.display().to_string()"
    let v28 : std_string_String = Fable.Core.RustInterop.emitRustExpr v26 v27
    let v29 : string = "fable_library_rust::String_::fromString($0)"
    let v30 : string = Fable.Core.RustInterop.emitRustExpr v28 v29
    v30
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v31 : string = null |> unbox<string>
    v31
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v32 : string = null |> unbox<string>
    v32
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !WASM
    let v33 : string = System.IO.Path.Combine (v10, v11)
    v33
    #endif
    #if FABLE_COMPILER && !FABLE_COMPILER_RUST && !WASM
    let v34 : string = null |> unbox<string>
    v34
    #endif
    #if !FABLE_COMPILER_RUST && WASM
    let v35 : string = null |> unbox<string>
    v35
    #endif
    |> fun x -> _v12 <- Some x
    let v36 : string = _v12 |> Option.get
    let v37 : System.DateTime = System.DateTime.Now
    let v38 : System.Guid = System.Guid.NewGuid ()
    let v39 : (System.Guid -> string) = _.ToString()
    let v40 : string = v39 v38
    let v41 : string = v37.ToString "yyyyMMdd-HHmm-ssff-ffff-f"
    let v42 : System.Guid = System.Guid $"{v41}{v40.[v41.Length..]}"
    let v43 : (System.Guid -> string) = _.ToString()
    let v44 : string = v43 v42
    let v45 : string option = None
    let mutable _v45 = v45
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v46 : string = method0(v36)
    let v47 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v48 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v46 v47
    let v49 : string = "String::from($0)"
    let v50 : std_string_String = Fable.Core.RustInterop.emitRustExpr v48 v49
    let v51 : string = "std::path::PathBuf::from($0)"
    let v52 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v50 v51
    let v53 : string = method0(v44)
    let v54 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v55 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v53 v54
    let v56 : string = "String::from($0)"
    let v57 : std_string_String = Fable.Core.RustInterop.emitRustExpr v55 v56
    let v58 : string = "$0.join($1)"
    let v59 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr struct (v52, v57) v58
    let v60 : string = "$0.display().to_string()"
    let v61 : std_string_String = Fable.Core.RustInterop.emitRustExpr v59 v60
    let v62 : string = "fable_library_rust::String_::fromString($0)"
    let v63 : string = Fable.Core.RustInterop.emitRustExpr v61 v62
    v63
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v64 : string = null |> unbox<string>
    v64
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v65 : string = null |> unbox<string>
    v65
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !WASM
    let v66 : string = System.IO.Path.Combine (v36, v44)
    v66
    #endif
    #if FABLE_COMPILER && !FABLE_COMPILER_RUST && !WASM
    let v67 : string = null |> unbox<string>
    v67
    #endif
    #if !FABLE_COMPILER_RUST && WASM
    let v68 : string = null |> unbox<string>
    v68
    #endif
    |> fun x -> _v45 <- Some x
    let v69 : string = _v45 |> Option.get
    v69
    #endif
    #if FABLE_COMPILER && !FABLE_COMPILER_RUST && !WASM
    let v70 : string = null |> unbox<string>
    v70
    #endif
    #if !FABLE_COMPILER_RUST && WASM
    let v71 : string = null |> unbox<string>
    v71
    #endif
    |> fun x -> _v4 <- Some x
    let v72 : string = _v4 |> Option.get
    let v73 : System.IO.DirectoryInfo option = None
    let mutable _v73 = v73
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v74 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    v74
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v75 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    v75
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v76 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    v76
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !WASM
    let v77 : (string -> System.IO.DirectoryInfo) = System.IO.Directory.CreateDirectory
    let v78 : System.IO.DirectoryInfo = v77 v72
    v78
    #endif
    #if FABLE_COMPILER && !FABLE_COMPILER_RUST && !WASM
    let v79 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    v79
    #endif
    #if !FABLE_COMPILER_RUST && WASM
    let v80 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    v80
    #endif
    |> fun x -> _v73 <- Some x
    let v81 : System.IO.DirectoryInfo = _v73 |> Option.get
    let v82 : bool option = None
    let mutable _v82 = v82
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v83 : bool = null |> unbox<bool>
    v83
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v84 : bool = null |> unbox<bool>
    v84
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v85 : bool = null |> unbox<bool>
    v85
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !WASM
    let v86 : bool = v81.Exists
    v86
    #endif
    #if FABLE_COMPILER && !FABLE_COMPILER_RUST && !WASM
    let v87 : bool = null |> unbox<bool>
    v87
    #endif
    #if !FABLE_COMPILER_RUST && WASM
    let v88 : bool = null |> unbox<bool>
    v88
    #endif
    |> fun x -> _v82 <- Some x
    let v89 : bool = _v82 |> Option.get
    let v90 : bool = v89 = false
    if v90 then
        let v91 : System.DateTime option = None
        let mutable _v91 = v91
        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v92 : System.DateTime = null |> unbox<System.DateTime>
        v92
        #endif
        #if FABLE_COMPILER_RUST && WASM
        let v93 : System.DateTime = null |> unbox<System.DateTime>
        v93
        #endif
        #if FABLE_COMPILER_RUST && CONTRACT
        let v94 : System.DateTime = null |> unbox<System.DateTime>
        v94
        #endif
        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !WASM
        let v95 : System.DateTime = v81.CreationTime
        v95
        #endif
        #if FABLE_COMPILER && !FABLE_COMPILER_RUST && !WASM
        let v96 : System.DateTime = null |> unbox<System.DateTime>
        v96
        #endif
        #if !FABLE_COMPILER_RUST && WASM
        let v97 : System.DateTime = null |> unbox<System.DateTime>
        v97
        #endif
        |> fun x -> _v91 <- Some x
        let v98 : System.DateTime = _v91 |> Option.get
        let v99 : obj = {| Exists = v89; CreationTime = v98 |}
        let v100 : string = $"%A{v99}"
        let v101 : (unit -> string) = closure2(v72, v100)
        let v102 : string = $"create_temp_directory / {v101 ()}"
        System.Console.WriteLine v102
        ()
    v72
    #endif
    #if FABLE_COMPILER && !FABLE_COMPILER_RUST && !WASM
    let v103 : string = null |> unbox<string>
    v103
    #endif
    #if !FABLE_COMPILER_RUST && WASM
    let v104 : string = null |> unbox<string>
    v104
    #endif
    |> fun x -> _v0 <- Some x
    let v105 : string = _v0 |> Option.get
    v105
and closure4 () () : string =
    let v0 : string = __SOURCE_DIRECTORY__
    v0
and closure8 () (v0 : string) : bool =
    let v1 : bool option = None
    let mutable _v1 = v1
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = method0(v0)
    let v3 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v4 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v2 v3
    let v5 : string = "String::from($0)"
    let v6 : std_string_String = Fable.Core.RustInterop.emitRustExpr v4 v5
    let v7 : string = "std::path::PathBuf::from($0)"
    let v8 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v6 v7
    let v9 : string = "v8.exists()"
    let v10 : bool = Fable.Core.RustInterop.emitRustExpr () v9
    let v13 : bool =
        if v10 then
            let v11 : string = "v8.is_file()"
            let v12 : bool = Fable.Core.RustInterop.emitRustExpr () v11
            v12
        else
            false
    v13
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v14 : bool = null |> unbox<bool>
    v14
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v15 : bool = null |> unbox<bool>
    v15
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !WASM
    let v16 : (string -> bool) = System.IO.File.Exists
    let v17 : bool = v16 v0
    v17
    #endif
    #if FABLE_COMPILER && !FABLE_COMPILER_RUST && !WASM
    let v18 : bool = null |> unbox<bool>
    v18
    #endif
    #if !FABLE_COMPILER_RUST && WASM
    let v19 : bool = null |> unbox<bool>
    v19
    #endif
    |> fun x -> _v1 <- Some x
    let v20 : bool = _v1 |> Option.get
    v20
and closure9 () (v0 : string) : bool =
    let v1 : bool option = None
    let mutable _v1 = v1
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = method0(v0)
    let v3 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v4 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v2 v3
    let v5 : string = "String::from($0)"
    let v6 : std_string_String = Fable.Core.RustInterop.emitRustExpr v4 v5
    let v7 : string = "std::path::PathBuf::from($0)"
    let v8 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v6 v7
    let v9 : string = "v8.exists()"
    let v10 : bool = Fable.Core.RustInterop.emitRustExpr () v9
    let v13 : bool =
        if v10 then
            let v11 : string = "v8.is_dir()"
            let v12 : bool = Fable.Core.RustInterop.emitRustExpr () v11
            v12
        else
            false
    v13
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v14 : bool = null |> unbox<bool>
    v14
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v15 : bool = null |> unbox<bool>
    v15
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !WASM
    let v16 : (string -> bool) = System.IO.Directory.Exists
    let v17 : bool = v16 v0
    v17
    #endif
    #if FABLE_COMPILER && !FABLE_COMPILER_RUST && !WASM
    let v18 : bool = null |> unbox<bool>
    v18
    #endif
    #if !FABLE_COMPILER_RUST && WASM
    let v19 : bool = null |> unbox<bool>
    v19
    #endif
    |> fun x -> _v1 <- Some x
    let v20 : bool = _v1 |> Option.get
    v20
and closure10 () (v0 : string) : string option =
    let v1 : US0 option = None
    let mutable _v1 = v1
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = method0(v0)
    let v3 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v4 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v2 v3
    let v5 : string = "String::from($0)"
    let v6 : std_string_String = Fable.Core.RustInterop.emitRustExpr v4 v5
    let v7 : string = "std::path::PathBuf::from($0)"
    let v8 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v6 v7
    let v9 : string = "$0.parent().map(std::path::PathBuf::from)"
    let v10 : std_path_PathBuf option = Fable.Core.RustInterop.emitRustExpr v8 v9
    let v11 : string = "v10?"
    let v12 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr () v11
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
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !WASM
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
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !WASM
            let v29 : string = v21.FullName
            v29
            #endif
            #if FABLE_COMPILER && !FABLE_COMPILER_RUST && !WASM
            let v30 : string = null |> unbox<string>
            v30
            #endif
            #if !FABLE_COMPILER_RUST && WASM
            let v31 : string = null |> unbox<string>
            v31
            #endif
            |> fun x -> _v25 <- Some x
            let v32 : string = _v25 |> Option.get
            US0_0(v32)
    v34
    #endif
    #if FABLE_COMPILER && !FABLE_COMPILER_RUST && !WASM
    let v35 : US0 = null |> unbox<US0>
    v35
    #endif
    #if !FABLE_COMPILER_RUST && WASM
    let v36 : US0 = null |> unbox<US0>
    v36
    #endif
    |> fun x -> _v1 <- Some x
    let v37 : US0 = _v1 |> Option.get
    match v37 with
    | US0_1 -> (* None *)
        let v40 : string option = None
        v40
    | US0_0(v38) -> (* Some *)
        let v39 : string option = Some v38
        v39
and method2 () : (string -> string option) =
    closure10()
and closure11 () (v0 : string) : US0 =
    US0_0(v0)
and method3 () : (string -> US0) =
    closure11()
and method4 (v0 : string, v1 : bool, v2 : string, v3 : string) : string =
    let v4 : string option = None
    let mutable _v4 = v4
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v5 : string = method0(v3)
    let v6 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v7 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v6
    let v8 : string = "String::from($0)"
    let v9 : std_string_String = Fable.Core.RustInterop.emitRustExpr v7 v8
    let v10 : string = "std::path::PathBuf::from($0)"
    let v11 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v9 v10
    let v12 : string = method0(v0)
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
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !WASM
    let v25 : string = System.IO.Path.Combine (v3, v0)
    v25
    #endif
    #if FABLE_COMPILER && !FABLE_COMPILER_RUST && !WASM
    let v26 : string = null |> unbox<string>
    v26
    #endif
    #if !FABLE_COMPILER_RUST && WASM
    let v27 : string = null |> unbox<string>
    v27
    #endif
    |> fun x -> _v4 <- Some x
    let v28 : string = _v4 |> Option.get
    let v31 : (string -> bool) =
        if v1 then
            closure8()
        else
            closure9()
    let v32 : bool = v31 v28
    if v32 then
        v3
    else
        let v33 : (string -> string option) = method2()
        let v34 : string option = v33 v3
        let v35 : (string -> US0) = method3()
        let v36 : US0 = US0_1
        let v37 : US0 = v34 |> Option.map v35 |> Option.defaultValue v36
        match v37 with
        | US0_1 -> (* None *)
            let v40 : string = $"""No parent for {if v1 then "file" else "dir"} '{v0}' at '{v2}'"""
            failwith<string> v40
        | US0_0(v38) -> (* Some *)
            method4(v0, v1, v2, v38)
and method1 (v0 : string, v1 : bool, v2 : string) : string =
    let v3 : string option = None
    let mutable _v3 = v3
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v4 : string = method0(v2)
    let v5 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v6 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v4 v5
    let v7 : string = "String::from($0)"
    let v8 : std_string_String = Fable.Core.RustInterop.emitRustExpr v6 v7
    let v9 : string = "std::path::PathBuf::from($0)"
    let v10 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v8 v9
    let v11 : string = method0(v0)
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
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !WASM
    let v24 : string = System.IO.Path.Combine (v2, v0)
    v24
    #endif
    #if FABLE_COMPILER && !FABLE_COMPILER_RUST && !WASM
    let v25 : string = null |> unbox<string>
    v25
    #endif
    #if !FABLE_COMPILER_RUST && WASM
    let v26 : string = null |> unbox<string>
    v26
    #endif
    |> fun x -> _v3 <- Some x
    let v27 : string = _v3 |> Option.get
    let v30 : (string -> bool) =
        if v1 then
            closure8()
        else
            closure9()
    let v31 : bool = v30 v27
    if v31 then
        v2
    else
        let v32 : (string -> string option) = method2()
        let v33 : string option = v32 v2
        let v34 : (string -> US0) = method3()
        let v35 : US0 = US0_1
        let v36 : US0 = v33 |> Option.map v34 |> Option.defaultValue v35
        match v36 with
        | US0_1 -> (* None *)
            let v39 : string = $"""No parent for {if v1 then "file" else "dir"} '{v0}' at '{v2}'"""
            failwith<string> v39
        | US0_0(v37) -> (* Some *)
            method4(v0, v1, v2, v37)
and closure7 (v0 : string, v1 : bool) (v2 : string) : string =
    method1(v0, v1, v2)
and closure6 (v0 : string) (v1 : bool) : (string -> string) =
    closure7(v0, v1)
and closure5 () (v0 : string) : (bool -> (string -> string)) =
    closure6(v0)
and closure13 (v0 : string) (v1 : string) : string =
    let v2 : string option = None
    let mutable _v2 = v2
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : string = method0(v0)
    let v4 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v5 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v3 v4
    let v6 : string = "String::from($0)"
    let v7 : std_string_String = Fable.Core.RustInterop.emitRustExpr v5 v6
    let v8 : string = "std::path::PathBuf::from($0)"
    let v9 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v7 v8
    let v10 : string = method0(v1)
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
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !WASM
    let v23 : string = System.IO.Path.Combine (v0, v1)
    v23
    #endif
    #if FABLE_COMPILER && !FABLE_COMPILER_RUST && !WASM
    let v24 : string = null |> unbox<string>
    v24
    #endif
    #if !FABLE_COMPILER_RUST && WASM
    let v25 : string = null |> unbox<string>
    v25
    #endif
    |> fun x -> _v2 <- Some x
    let v26 : string = _v2 |> Option.get
    v26
and closure12 () (v0 : string) : (string -> string) =
    closure13(v0)
let v0 : (unit -> string) = closure0()
let create_temp_directory_name () = v0 ()
let v1 : (unit -> string) = closure1()
let create_temp_directory () = v1 ()
let v2 : (unit -> string) = closure4()
let get_source_directory () = v2 ()
let v3 : (string -> (bool -> (string -> string))) = closure5()
let find_parent x = v3 x
let v4 : (string -> (string -> string)) = closure12()
let (</>) x = v4 x
()
