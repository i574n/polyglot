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
type IFsExistsSync = abstract existsSync: path: string -> bool
module State = let mutable trace_state = None
type IPathJoin = abstract join: [<System.ParamArray>] paths: string[] -> string
type IPathDirname = abstract dirname: path: string -> string
type [<Struct>] US1 =
    | US1_0
    | US1_1
    | US1_2
and [<Struct>] US2 =
    | US2_0
    | US2_1
    | US2_2
    | US2_3
    | US2_4
and [<Struct>] US0 =
    | US0_0 of f0_0 : US1 * f0_1 : US2
    | US0_1
and [<Struct>] US3 =
    | US3_0
    | US3_1
    | US3_2
    | US3_3
    | US3_4
and Mut0 = {mutable l0 : int64}
and Mut1 = {mutable l0 : bool}
and Mut2 = {mutable l0 : US3}
and [<Struct>] US4 =
    | US4_0 of f0_0 : int64
    | US4_1
and [<Struct>] US5 =
    | US5_0 of f0_0 : int64
    | US5_1
and [<Struct>] US6 =
    | US6_0 of f0_0 : int64
    | US6_1 of f1_0 : exn
and [<Struct>] US7 =
    | US7_0 of f0_0 : int64
    | US7_1 of f1_0 : exn
and [<Struct>] US8 =
    | US8_0 of f0_0 : string
    | US8_1
let rec closure2 () (v0 : string) : string =
    let v1 : string option = None
    let mutable _v1 = v1
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = null |> unbox<string>
    v2 
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v3 : string = null |> unbox<string>
    v3 
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v4 : string = null |> unbox<string>
    v4 
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v5 : (string -> string) = System.IO.Path.GetFileName
    let v6 : string = v5 v0
    v6 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v7 : string = null |> unbox<string>
    v7 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v8 : string = Unchecked.defaultof<string>
    v8 
    #endif
    |> fun x -> _v1 <- Some x
    let v9 : string = _v1.Value
    v9
and closure3 () () : string =
    let v0 : string = ""
    v0
and method1 (v0 : string, v1 : string) : string =
    let v2 : (string -> string) = closure2()
    let v3 : (unit -> string) = closure3()
    let v4 : string = $"path: {v0 |> v2} / ex: {v1} / {v3 ()}"
    v4
and closure1 (v0 : string, v1 : string) () : string =
    method1(v0, v1)
and method0 (v0 : string, v1 : int64) : Async<int64> =
    let v2 : Async<int64> option = None
    let mutable _v2 = v2
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
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v6 : Async<int64> option = None
    let mutable _v6 = v6
    async {
    try
    let v7 : unit option = None
    let mutable _v7 = v7
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
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    System.IO.Directory.Delete (v0, true)
    () 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    null |> unbox<unit>
    () 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    Unchecked.defaultof<unit>
    () 
    #endif
    |> fun x -> _v7 <- Some x
    _v7.Value
    return v1 
    with ex ->
    let v8 : exn = ex
    let v9 : int64 = v1 % 100L
    let v10 : bool = v9 = 0L
    if v10 then
        let v11 : string option = None
        let mutable _v11 = v11
        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v12 : string = $"%A{v8}"
        v12 
        #endif
        #if FABLE_COMPILER_RUST && WASM
        let v13 : string = $"%A{v8}"
        v13 
        #endif
        #if FABLE_COMPILER_RUST && CONTRACT
        let v14 : string = $"%A{v8}"
        v14 
        #endif
        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
        let v15 : string = $"{v8.GetType ()}: {v8.Message}"
        v15 
        #endif
        #if FABLE_COMPILER_TYPESCRIPT
        let v16 : string = $"%A{v8}"
        v16 
        #endif
        #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
        let v17 : string = Unchecked.defaultof<string>
        v17 
        #endif
        |> fun x -> _v11 <- Some x
        let v18 : string = _v11.Value
        let v19 : (unit -> string) = closure1(v0, v18)
        let v20 : string = $"delete_directory_async / {v19 ()}"
        System.Console.WriteLine v20
        ()
    let v21 : Async<unit> option = None
    let mutable _v21 = v21
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v22 : Async<unit> = null |> unbox<Async<unit>>
    v22 
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v23 : Async<unit> = null |> unbox<Async<unit>>
    v23 
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v24 : Async<unit> = null |> unbox<Async<unit>>
    v24 
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v25 : (int32 -> Async<unit>) = Async.Sleep
    let v26 : Async<unit> = v25 10
    v26 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v27 : Async<unit> = null |> unbox<Async<unit>>
    v27 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v28 : Async<unit> = Unchecked.defaultof<Async<unit>>
    v28 
    #endif
    |> fun x -> _v21 <- Some x
    let v29 : Async<unit> = _v21.Value
    do! v29 
    let v30 : int64 = v1 + 1L
    let v31 : Async<int64> = method0(v0, v30)
    return! v31 
    (*
    let v32 : int64 = *)
    }
    |> fun x -> _v6 <- Some x
    let v33 : Async<int64> = _v6 |> Option.get
    v33 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v34 : Async<int64> = null |> unbox<Async<int64>>
    v34 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v35 : Async<int64> = Unchecked.defaultof<Async<int64>>
    v35 
    #endif
    |> fun x -> _v2 <- Some x
    let v36 : Async<int64> = _v2.Value
    v36
and closure0 () (v0 : string) : Async<int64> =
    let v1 : Async<int64> option = None
    let mutable _v1 = v1
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
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v5 : int64 = 0L
    let v6 : Async<int64> = method0(v0, v5)
    v6 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v7 : Async<int64> = null |> unbox<Async<int64>>
    v7 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v8 : Async<int64> = Unchecked.defaultof<Async<int64>>
    v8 
    #endif
    |> fun x -> _v1 <- Some x
    let v9 : Async<int64> = _v1.Value
    v9
and method3 (v0 : string, v1 : int64, v2 : string) : string =
    let v3 : (string -> string) = closure2()
    let v4 : (unit -> string) = closure3()
    let v5 : string = $"path: {v0 |> v3} / retry: {v1} / ex: {v2} / {v4 ()}"
    v5
and closure6 (v0 : string, v1 : int64, v2 : string) () : string =
    method3(v0, v1, v2)
and method2 (v0 : string, v1 : US2, v2 : US1, v3 : int64) : Async<int64> =
    let v4 : Async<int64> option = None
    let mutable _v4 = v4
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
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v8 : Async<int64> option = None
    let mutable _v8 = v8
    async {
    try
    let v9 : System.IO.FileStream option = None
    let mutable _v9 = v9
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
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v13 : System.IO.FileMode = System.IO.FileMode.Open
    let v19 : System.IO.FileAccess =
        match v2 with
        | US1_0 -> (* AccessRead *)
            let v14 : System.IO.FileAccess = System.IO.FileAccess.Read
            v14
        | US1_2 -> (* AccessReadWrite *)
            let v16 : System.IO.FileAccess = System.IO.FileAccess.ReadWrite
            v16
        | US1_1 -> (* AccessWrite *)
            let v15 : System.IO.FileAccess = System.IO.FileAccess.ReadWrite
            v15
    let v29 : System.IO.FileShare =
        match v1 with
        | US2_4 -> (* ShareDelete *)
            let v24 : System.IO.FileShare = System.IO.FileShare.Delete
            v24
        | US2_0 -> (* ShareNone *)
            let v20 : System.IO.FileShare = System.IO.FileShare.None
            v20
        | US2_1 -> (* ShareRead *)
            let v21 : System.IO.FileShare = System.IO.FileShare.Read
            v21
        | US2_3 -> (* ShareReadWrite *)
            let v23 : System.IO.FileShare = System.IO.FileShare.ReadWrite
            v23
        | US2_2 -> (* ShareWrite *)
            let v22 : System.IO.FileShare = System.IO.FileShare.Write
            v22
    let v30 : System.IO.FileStream = new System.IO.FileStream (v0, v13, v19, v29)
    v30 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v31 : System.IO.FileStream = null |> unbox<System.IO.FileStream>
    v31 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v32 : System.IO.FileStream = Unchecked.defaultof<System.IO.FileStream>
    v32 
    #endif
    |> fun x -> _v9 <- Some x
    let v33 : System.IO.FileStream = _v9.Value
    use v33 = v33 
    let v34 : System.IO.FileStream = v33 
    return v3 
    with ex ->
    let v35 : exn = ex
    let v36 : bool = v3 > 0L
    let v39 : bool =
        if v36 then
            let v37 : int64 = v3 % 100L
            let v38 : bool = v37 = 0L
            v38
        else
            false
    if v39 then
        let v40 : string option = None
        let mutable _v40 = v40
        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v41 : string = $"%A{v35}"
        v41 
        #endif
        #if FABLE_COMPILER_RUST && WASM
        let v42 : string = $"%A{v35}"
        v42 
        #endif
        #if FABLE_COMPILER_RUST && CONTRACT
        let v43 : string = $"%A{v35}"
        v43 
        #endif
        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
        let v44 : string = $"{v35.GetType ()}: {v35.Message}"
        v44 
        #endif
        #if FABLE_COMPILER_TYPESCRIPT
        let v45 : string = $"%A{v35}"
        v45 
        #endif
        #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
        let v46 : string = Unchecked.defaultof<string>
        v46 
        #endif
        |> fun x -> _v40 <- Some x
        let v47 : string = _v40.Value
        let v48 : (unit -> string) = closure6(v0, v3, v47)
        let v49 : string = $"wait_for_file_access / {v48 ()}"
        System.Console.WriteLine v49
        ()
    let v50 : Async<unit> option = None
    let mutable _v50 = v50
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v51 : Async<unit> = null |> unbox<Async<unit>>
    v51 
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v52 : Async<unit> = null |> unbox<Async<unit>>
    v52 
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v53 : Async<unit> = null |> unbox<Async<unit>>
    v53 
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v54 : (int32 -> Async<unit>) = Async.Sleep
    let v55 : Async<unit> = v54 10
    v55 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v56 : Async<unit> = null |> unbox<Async<unit>>
    v56 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v57 : Async<unit> = Unchecked.defaultof<Async<unit>>
    v57 
    #endif
    |> fun x -> _v50 <- Some x
    let v58 : Async<unit> = _v50.Value
    do! v58 
    let v59 : int64 = v3 + 1L
    let v60 : Async<int64> = method2(v0, v1, v2, v59)
    return! v60 
    (*
    let v61 : int64 = *)
    }
    |> fun x -> _v8 <- Some x
    let v62 : Async<int64> = _v8 |> Option.get
    v62 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v63 : Async<int64> = null |> unbox<Async<int64>>
    v63 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v64 : Async<int64> = Unchecked.defaultof<Async<int64>>
    v64 
    #endif
    |> fun x -> _v4 <- Some x
    let v65 : Async<int64> = _v4.Value
    v65
and closure5 (v0 : US0) (v1 : string) : Async<int64> =
    let v2 : Async<int64> option = None
    let mutable _v2 = v2
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
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let struct (v12 : US1, v13 : US2) =
        match v0 with
        | US0_1 -> (* None *)
            let v8 : US1 = US1_2
            let v9 : US2 = US2_1
            struct (v8, v9)
        | US0_0(v6, v7) -> (* Some *)
            struct (v6, v7)
    let v14 : int64 = 0L
    let v15 : Async<int64> = method2(v1, v13, v12, v14)
    v15 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v16 : Async<int64> = null |> unbox<Async<int64>>
    v16 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v17 : Async<int64> = Unchecked.defaultof<Async<int64>>
    v17 
    #endif
    |> fun x -> _v2 <- Some x
    let v18 : Async<int64> = _v2.Value
    v18
and closure4 () (v0 : US0) : (string -> Async<int64>) =
    closure5(v0)
and method4 (v0 : string, v1 : int64) : Async<int64> =
    let v2 : Async<int64> option = None
    let mutable _v2 = v2
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
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v6 : Async<int64> option = None
    let mutable _v6 = v6
    async {
    try
    let v7 : System.IO.FileStream option = None
    let mutable _v7 = v7
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v8 : System.IO.FileStream = null |> unbox<System.IO.FileStream>
    v8 
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v9 : System.IO.FileStream = null |> unbox<System.IO.FileStream>
    v9 
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v10 : System.IO.FileStream = null |> unbox<System.IO.FileStream>
    v10 
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v11 : System.IO.FileMode = System.IO.FileMode.Open
    let v12 : System.IO.FileAccess = System.IO.FileAccess.Read
    let v13 : System.IO.FileShare = System.IO.FileShare.Read
    let v14 : System.IO.FileStream = new System.IO.FileStream (v0, v11, v12, v13)
    v14 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v15 : System.IO.FileStream = null |> unbox<System.IO.FileStream>
    v15 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v16 : System.IO.FileStream = Unchecked.defaultof<System.IO.FileStream>
    v16 
    #endif
    |> fun x -> _v7 <- Some x
    let v17 : System.IO.FileStream = _v7.Value
    use v17 = v17 
    let v18 : System.IO.FileStream = v17 
    return v1 
    with ex ->
    let v19 : exn = ex
    let v20 : bool = v1 > 0L
    let v23 : bool =
        if v20 then
            let v21 : int64 = v1 % 100L
            let v22 : bool = v21 = 0L
            v22
        else
            false
    if v23 then
        let v24 : string option = None
        let mutable _v24 = v24
        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v25 : string = $"%A{v19}"
        v25 
        #endif
        #if FABLE_COMPILER_RUST && WASM
        let v26 : string = $"%A{v19}"
        v26 
        #endif
        #if FABLE_COMPILER_RUST && CONTRACT
        let v27 : string = $"%A{v19}"
        v27 
        #endif
        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
        let v28 : string = $"{v19.GetType ()}: {v19.Message}"
        v28 
        #endif
        #if FABLE_COMPILER_TYPESCRIPT
        let v29 : string = $"%A{v19}"
        v29 
        #endif
        #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
        let v30 : string = Unchecked.defaultof<string>
        v30 
        #endif
        |> fun x -> _v24 <- Some x
        let v31 : string = _v24.Value
        let v32 : (unit -> string) = closure6(v0, v1, v31)
        let v33 : string = $"wait_for_file_access / {v32 ()}"
        System.Console.WriteLine v33
        ()
    let v34 : Async<unit> option = None
    let mutable _v34 = v34
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v35 : Async<unit> = null |> unbox<Async<unit>>
    v35 
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v36 : Async<unit> = null |> unbox<Async<unit>>
    v36 
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v37 : Async<unit> = null |> unbox<Async<unit>>
    v37 
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v38 : (int32 -> Async<unit>) = Async.Sleep
    let v39 : Async<unit> = v38 10
    v39 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v40 : Async<unit> = null |> unbox<Async<unit>>
    v40 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v41 : Async<unit> = Unchecked.defaultof<Async<unit>>
    v41 
    #endif
    |> fun x -> _v34 <- Some x
    let v42 : Async<unit> = _v34.Value
    do! v42 
    let v43 : int64 = v1 + 1L
    let v44 : Async<int64> = method4(v0, v43)
    return! v44 
    (*
    let v45 : int64 = *)
    }
    |> fun x -> _v6 <- Some x
    let v46 : Async<int64> = _v6 |> Option.get
    v46 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v47 : Async<int64> = null |> unbox<Async<int64>>
    v47 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v48 : Async<int64> = Unchecked.defaultof<Async<int64>>
    v48 
    #endif
    |> fun x -> _v2 <- Some x
    let v49 : Async<int64> = _v2.Value
    v49
and closure7 () (v0 : string) : Async<int64> =
    let v1 : Async<int64> option = None
    let mutable _v1 = v1
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
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v5 : int64 = 0L
    let v6 : Async<int64> = method4(v0, v5)
    v6 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v7 : Async<int64> = null |> unbox<Async<int64>>
    v7 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v8 : Async<int64> = Unchecked.defaultof<Async<int64>>
    v8 
    #endif
    |> fun x -> _v1 <- Some x
    let v9 : Async<int64> = _v1.Value
    v9
and closure8 () (v0 : string) : Async<string> =
    let v1 : Async<string> option = None
    let mutable _v1 = v1
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
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v5 : (string -> System.Threading.Tasks.Task<string>) = System.IO.File.ReadAllTextAsync
    let v6 : System.Threading.Tasks.Task<string> = v5 v0
    let v7 : Async<string> option = None
    let mutable _v7 = v7
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v8 : Async<string> = null |> unbox<Async<string>>
    v8 
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v9 : Async<string> = null |> unbox<Async<string>>
    v9 
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v10 : Async<string> = null |> unbox<Async<string>>
    v10 
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v11 : (System.Threading.Tasks.Task<string> -> Async<string>) = Async.AwaitTask
    let v12 : Async<string> = v11 v6
    v12 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v13 : Async<string> = null |> unbox<Async<string>>
    v13 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v14 : Async<string> = Unchecked.defaultof<Async<string>>
    v14 
    #endif
    |> fun x -> _v7 <- Some x
    let v15 : Async<string> = _v7.Value
    v15 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v16 : Async<string> = null |> unbox<Async<string>>
    v16 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v17 : Async<string> = Unchecked.defaultof<Async<string>>
    v17 
    #endif
    |> fun x -> _v1 <- Some x
    let v18 : Async<string> = _v1.Value
    v18
and method5 (v0 : string) : string =
    v0
and closure10 (v0 : string) (v1 : string) : Async<bool> =
    let v2 : Async<bool> option = None
    let mutable _v2 = v2
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
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v6 : Async<bool> option = None
    let mutable _v6 = v6
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v7 : Async<bool> = null |> unbox<Async<bool>>
    v7 
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v8 : Async<bool> = null |> unbox<Async<bool>>
    v8 
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v9 : Async<bool> = null |> unbox<Async<bool>>
    v9 
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v10 : Async<bool> option = None
    let mutable _v10 = v10
    async {
    let v11 : bool option = None
    let mutable _v11 = v11
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v12 : string = method5(v0)
    let v13 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v14 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v12 v13
    let v15 : string = "String::from($0)"
    let v16 : std_string_String = Fable.Core.RustInterop.emitRustExpr v14 v15
    let v17 : string = "std::path::PathBuf::from($0)"
    let v18 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v16 v17
    let v19 : string = "$0.exists()"
    let v20 : bool = Fable.Core.RustInterop.emitRustExpr v18 v19
    let v23 : bool =
        if v20 then
            let v21 : string = "$0.is_file()"
            let v22 : bool = Fable.Core.RustInterop.emitRustExpr v18 v21
            v22
        else
            false
    v23 
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v24 : bool = null |> unbox<bool>
    v24 
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v25 : bool = null |> unbox<bool>
    v25 
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v26 : (string -> bool) = System.IO.File.Exists
    let v27 : bool = v26 v0
    v27 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v28 : string = "fs"
    let v29 : IFsExistsSync = Fable.Core.JsInterop.importAll v28
    let v30 : string = "v29.existsSync($0)"
    let v31 : bool = Fable.Core.JsInterop.emitJsExpr v0 v30
    v31 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v32 : bool = Unchecked.defaultof<bool>
    v32 
    #endif
    |> fun x -> _v11 <- Some x
    let v33 : bool = _v11.Value
    let v34 : bool = v33 = false
    if v34 then
        return false 
        (*
        ()
    else
        *) else
        let v35 : Async<string> option = None
        let mutable _v35 = v35
        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v36 : Async<string> = null |> unbox<Async<string>>
        v36 
        #endif
        #if FABLE_COMPILER_RUST && WASM
        let v37 : Async<string> = null |> unbox<Async<string>>
        v37 
        #endif
        #if FABLE_COMPILER_RUST && CONTRACT
        let v38 : Async<string> = null |> unbox<Async<string>>
        v38 
        #endif
        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
        let v39 : (string -> System.Threading.Tasks.Task<string>) = System.IO.File.ReadAllTextAsync
        let v40 : System.Threading.Tasks.Task<string> = v39 v0
        let v41 : Async<string> option = None
        let mutable _v41 = v41
        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v42 : Async<string> = null |> unbox<Async<string>>
        v42 
        #endif
        #if FABLE_COMPILER_RUST && WASM
        let v43 : Async<string> = null |> unbox<Async<string>>
        v43 
        #endif
        #if FABLE_COMPILER_RUST && CONTRACT
        let v44 : Async<string> = null |> unbox<Async<string>>
        v44 
        #endif
        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
        let v45 : (System.Threading.Tasks.Task<string> -> Async<string>) = Async.AwaitTask
        let v46 : Async<string> = v45 v40
        v46 
        #endif
        #if FABLE_COMPILER_TYPESCRIPT
        let v47 : Async<string> = null |> unbox<Async<string>>
        v47 
        #endif
        #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
        let v48 : Async<string> = Unchecked.defaultof<Async<string>>
        v48 
        #endif
        |> fun x -> _v41 <- Some x
        let v49 : Async<string> = _v41.Value
        v49 
        #endif
        #if FABLE_COMPILER_TYPESCRIPT
        let v50 : Async<string> = null |> unbox<Async<string>>
        v50 
        #endif
        #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
        let v51 : Async<string> = Unchecked.defaultof<Async<string>>
        v51 
        #endif
        |> fun x -> _v35 <- Some x
        let v52 : Async<string> = _v35.Value
        let! v52 = v52 
        let v53 : string = v52 
        let v54 : bool = v1 = v53
        return v54 
        (*
        ()
    *)
    }
    |> fun x -> _v10 <- Some x
    let v55 : Async<bool> = _v10 |> Option.get
    v55 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v56 : Async<bool> = null |> unbox<Async<bool>>
    v56 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v57 : Async<bool> = Unchecked.defaultof<Async<bool>>
    v57 
    #endif
    |> fun x -> _v6 <- Some x
    let v58 : Async<bool> = _v6.Value
    v58 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v59 : Async<bool> = null |> unbox<Async<bool>>
    v59 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v60 : Async<bool> = Unchecked.defaultof<Async<bool>>
    v60 
    #endif
    |> fun x -> _v2 <- Some x
    let v61 : Async<bool> = _v2.Value
    v61
and closure9 () (v0 : string) : (string -> Async<bool>) =
    closure10(v0)
and closure12 (v0 : string) (v1 : string) : Async<unit> =
    let v2 : Async<unit> option = None
    let mutable _v2 = v2
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
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v6 : System.Threading.Tasks.Task = System.IO.File.WriteAllTextAsync (v0, v1)
    let v7 : Async<unit> option = None
    let mutable _v7 = v7
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v8 : Async<unit> = null |> unbox<Async<unit>>
    v8 
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v9 : Async<unit> = null |> unbox<Async<unit>>
    v9 
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v10 : Async<unit> = null |> unbox<Async<unit>>
    v10 
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v11 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
    let v12 : Async<unit> = v11 v6
    v12 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v13 : Async<unit> = null |> unbox<Async<unit>>
    v13 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v14 : Async<unit> = Unchecked.defaultof<Async<unit>>
    v14 
    #endif
    |> fun x -> _v7 <- Some x
    let v15 : Async<unit> = _v7.Value
    v15 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v16 : Async<unit> = null |> unbox<Async<unit>>
    v16 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v17 : Async<unit> = Unchecked.defaultof<Async<unit>>
    v17 
    #endif
    |> fun x -> _v2 <- Some x
    let v18 : Async<unit> = _v2.Value
    v18
and closure11 () (v0 : string) : (string -> Async<unit>) =
    closure12(v0)
and closure14 (v0 : string) (v1 : string) : Async<unit> =
    let v2 : Async<unit> option = None
    let mutable _v2 = v2
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
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v6 : Async<unit> option = None
    let mutable _v6 = v6
    async {
    let v7 : Async<bool> option = None
    let mutable _v7 = v7
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v8 : Async<bool> = null |> unbox<Async<bool>>
    v8 
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v9 : Async<bool> = null |> unbox<Async<bool>>
    v9 
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v10 : Async<bool> = null |> unbox<Async<bool>>
    v10 
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v11 : Async<bool> option = None
    let mutable _v11 = v11
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v12 : Async<bool> = null |> unbox<Async<bool>>
    v12 
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v13 : Async<bool> = null |> unbox<Async<bool>>
    v13 
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v14 : Async<bool> = null |> unbox<Async<bool>>
    v14 
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v15 : Async<bool> option = None
    let mutable _v15 = v15
    async {
    let v16 : bool option = None
    let mutable _v16 = v16
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v17 : string = method5(v0)
    let v18 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v19 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v17 v18
    let v20 : string = "String::from($0)"
    let v21 : std_string_String = Fable.Core.RustInterop.emitRustExpr v19 v20
    let v22 : string = "std::path::PathBuf::from($0)"
    let v23 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v21 v22
    let v24 : string = "$0.exists()"
    let v25 : bool = Fable.Core.RustInterop.emitRustExpr v23 v24
    let v28 : bool =
        if v25 then
            let v26 : string = "$0.is_file()"
            let v27 : bool = Fable.Core.RustInterop.emitRustExpr v23 v26
            v27
        else
            false
    v28 
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v29 : bool = null |> unbox<bool>
    v29 
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v30 : bool = null |> unbox<bool>
    v30 
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v31 : (string -> bool) = System.IO.File.Exists
    let v32 : bool = v31 v0
    v32 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v33 : string = "fs"
    let v34 : IFsExistsSync = Fable.Core.JsInterop.importAll v33
    let v35 : string = "v34.existsSync($0)"
    let v36 : bool = Fable.Core.JsInterop.emitJsExpr v0 v35
    v36 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v37 : bool = Unchecked.defaultof<bool>
    v37 
    #endif
    |> fun x -> _v16 <- Some x
    let v38 : bool = _v16.Value
    let v39 : bool = v38 = false
    if v39 then
        return false 
        (*
        ()
    else
        *) else
        let v40 : Async<string> option = None
        let mutable _v40 = v40
        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v41 : Async<string> = null |> unbox<Async<string>>
        v41 
        #endif
        #if FABLE_COMPILER_RUST && WASM
        let v42 : Async<string> = null |> unbox<Async<string>>
        v42 
        #endif
        #if FABLE_COMPILER_RUST && CONTRACT
        let v43 : Async<string> = null |> unbox<Async<string>>
        v43 
        #endif
        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
        let v44 : (string -> System.Threading.Tasks.Task<string>) = System.IO.File.ReadAllTextAsync
        let v45 : System.Threading.Tasks.Task<string> = v44 v0
        let v46 : Async<string> option = None
        let mutable _v46 = v46
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
        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
        let v50 : (System.Threading.Tasks.Task<string> -> Async<string>) = Async.AwaitTask
        let v51 : Async<string> = v50 v45
        v51 
        #endif
        #if FABLE_COMPILER_TYPESCRIPT
        let v52 : Async<string> = null |> unbox<Async<string>>
        v52 
        #endif
        #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
        let v53 : Async<string> = Unchecked.defaultof<Async<string>>
        v53 
        #endif
        |> fun x -> _v46 <- Some x
        let v54 : Async<string> = _v46.Value
        v54 
        #endif
        #if FABLE_COMPILER_TYPESCRIPT
        let v55 : Async<string> = null |> unbox<Async<string>>
        v55 
        #endif
        #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
        let v56 : Async<string> = Unchecked.defaultof<Async<string>>
        v56 
        #endif
        |> fun x -> _v40 <- Some x
        let v57 : Async<string> = _v40.Value
        let! v57 = v57 
        let v58 : string = v57 
        let v59 : bool = v1 = v58
        return v59 
        (*
        ()
    *)
    }
    |> fun x -> _v15 <- Some x
    let v60 : Async<bool> = _v15 |> Option.get
    v60 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v61 : Async<bool> = null |> unbox<Async<bool>>
    v61 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v62 : Async<bool> = Unchecked.defaultof<Async<bool>>
    v62 
    #endif
    |> fun x -> _v11 <- Some x
    let v63 : Async<bool> = _v11.Value
    v63 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v64 : Async<bool> = null |> unbox<Async<bool>>
    v64 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v65 : Async<bool> = Unchecked.defaultof<Async<bool>>
    v65 
    #endif
    |> fun x -> _v7 <- Some x
    let v66 : Async<bool> = _v7.Value
    let! v66 = v66 
    let v67 : bool = v66 
    let v68 : bool = v67 = false
    if v68 then
        let v69 : Async<unit> option = None
        let mutable _v69 = v69
        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v70 : Async<unit> = null |> unbox<Async<unit>>
        v70 
        #endif
        #if FABLE_COMPILER_RUST && WASM
        let v71 : Async<unit> = null |> unbox<Async<unit>>
        v71 
        #endif
        #if FABLE_COMPILER_RUST && CONTRACT
        let v72 : Async<unit> = null |> unbox<Async<unit>>
        v72 
        #endif
        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
        let v73 : System.Threading.Tasks.Task = System.IO.File.WriteAllTextAsync (v0, v1)
        let v74 : Async<unit> option = None
        let mutable _v74 = v74
        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v75 : Async<unit> = null |> unbox<Async<unit>>
        v75 
        #endif
        #if FABLE_COMPILER_RUST && WASM
        let v76 : Async<unit> = null |> unbox<Async<unit>>
        v76 
        #endif
        #if FABLE_COMPILER_RUST && CONTRACT
        let v77 : Async<unit> = null |> unbox<Async<unit>>
        v77 
        #endif
        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
        let v78 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
        let v79 : Async<unit> = v78 v73
        v79 
        #endif
        #if FABLE_COMPILER_TYPESCRIPT
        let v80 : Async<unit> = null |> unbox<Async<unit>>
        v80 
        #endif
        #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
        let v81 : Async<unit> = Unchecked.defaultof<Async<unit>>
        v81 
        #endif
        |> fun x -> _v74 <- Some x
        let v82 : Async<unit> = _v74.Value
        v82 
        #endif
        #if FABLE_COMPILER_TYPESCRIPT
        let v83 : Async<unit> = null |> unbox<Async<unit>>
        v83 
        #endif
        #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
        let v84 : Async<unit> = Unchecked.defaultof<Async<unit>>
        v84 
        #endif
        |> fun x -> _v69 <- Some x
        let v85 : Async<unit> = _v69.Value
        do! v85 
        ()
    }
    |> fun x -> _v6 <- Some x
    let v86 : Async<unit> = _v6 |> Option.get
    v86 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v87 : Async<unit> = null |> unbox<Async<unit>>
    v87 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v88 : Async<unit> = Unchecked.defaultof<Async<unit>>
    v88 
    #endif
    |> fun x -> _v2 <- Some x
    let v89 : Async<unit> = _v2.Value
    v89
and closure13 () (v0 : string) : (string -> Async<unit>) =
    closure14(v0)
and closure16 () () : string =
    let v0 : string = "delete_file_async"
    v0
and method8 (v0 : int64 option) : int64 option =
    v0
and method9 (v0 : int64 option) : int64 option =
    v0
and closure17 () () : struct (Mut0 * Mut1 * Mut1 * Mut2 * int64 option) =
    let v0 : Mut1 = {l0 = true} : Mut1
    let v1 : Mut0 = {l0 = 0L} : Mut0
    let v2 : US3 = US3_0
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
    let v22 : US4 =
        if v16 then
            let v17 : System.DateTime = System.DateTime.Now
            let v18 : (System.DateTime -> int64) = _.Ticks
            let v19 : int64 = v18 v17
            US4_0(v19)
        else
            US4_1
    let v27 : int64 option =
        match v22 with
        | US4_1 -> (* None *)
            let v25 : int64 option = None
            v25
        | US4_0(v23) -> (* Some *)
            let v24 : int64 option = Some v23 
            v24
    let v28 : int64 option = method8(v27)
    v28 
    #else
    let v29 : int64 option = None
    let v30 : int64 option = method9(v29)
    v30 
    #endif
    |> fun x -> _v5 <- Some x
    let v31 : int64 option = _v5.Value
    struct (v1, v4, v0, v3, v31)
and closure19 () (v0 : int64) : US5 =
    US5_0(v0)
and method10 () : (int64 -> US5) =
    closure19()
and method11 () : string =
    let v0 : string = ""
    v0
and closure18 (v0 : US3, v1 : (unit -> string), v2 : (unit -> string)) () : string =
    let v3 : (unit -> struct (Mut0 * Mut1 * Mut1 * Mut2 * int64 option)) = closure17()
    if State.trace_state = None then State.trace_state <- v3 () |> Some
    let struct (v4 : Mut0, v5 : Mut1, v6 : Mut1, v7 : Mut2, v8 : int64 option) = State.trace_state.Value
    let v9 : string option = None
    let mutable _v9 = v9
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v10 : (int64 -> US5) = method10()
    let v11 : US5 = US5_1
    let v12 : US5 = v8 |> Option.map v10 |> Option.defaultValue v11 
    let v30 : System.DateTime =
        match v12 with
        | US5_1 -> (* None *)
            let v28 : System.DateTime = System.DateTime.Now
            v28
        | US5_0(v13) -> (* Some *)
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
    let v33 : string = method11()
    v33 
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v34 : string = method11()
    v34 
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v35 : (int64 -> US5) = method10()
    let v36 : US5 = US5_1
    let v37 : US5 = v8 |> Option.map v35 |> Option.defaultValue v36 
    let v55 : System.DateTime =
        match v37 with
        | US5_1 -> (* None *)
            let v53 : System.DateTime = System.DateTime.Now
            v53
        | US5_0(v38) -> (* Some *)
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
    let v58 : string = method11()
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
        | US3_4 -> (* Critical *)
            let v66 : string = "Critical"
            v66
        | US3_1 -> (* Debug *)
            let v63 : string = "Debug"
            v63
        | US3_2 -> (* Info *)
            let v64 : string = "Info"
            v64
        | US3_0 -> (* Verbose *)
            let v62 : string = "Verbose"
            v62
        | US3_3 -> (* Warning *)
            let v65 : string = "Warning"
            v65
    let v72 : string = v71.ToLower ()
    let v73 : string = $"{v60} #{v61} [{v72}] %s{v1 ()} / %s{v2 ()}"
    let v74 : (char []) = [||]
    let v75 : string = v73.TrimStart v74
    let v76 : (char []) = [|' '; '/'|]
    let v77 : string = v75.TrimEnd v76
    v77
and method7 (v0 : US3, v1 : (unit -> string), v2 : (unit -> string)) : unit =
    let v3 : (unit -> struct (Mut0 * Mut1 * Mut1 * Mut2 * int64 option)) = closure17()
    if State.trace_state = None then State.trace_state <- v3 () |> Some
    let struct (v4 : Mut0, v5 : Mut1, v6 : Mut1, v7 : Mut2, v8 : int64 option) = State.trace_state.Value
    if State.trace_state = None then State.trace_state <- v3 () |> Some
    let struct (v9 : Mut0, v10 : Mut1, v11 : Mut1, v12 : Mut2, v13 : int64 option) = State.trace_state.Value
    let v14 : US3 = v12.l0
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
        let v20 : (unit -> string) = closure18(v0, v1, v2)
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
and method6 (v0 : string, v1 : int64) : Async<int64> =
    let v2 : Async<int64> option = None
    let mutable _v2 = v2
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
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v6 : Async<int64> option = None
    let mutable _v6 = v6
    async {
    try
    let v7 : unit option = None
    let mutable _v7 = v7
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
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v8 : (string -> unit) = System.IO.File.Delete
    v8 v0
    () 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    null |> unbox<unit>
    () 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    Unchecked.defaultof<unit>
    () 
    #endif
    |> fun x -> _v7 <- Some x
    _v7.Value
    return v1 
    with ex ->
    let v9 : exn = ex
    let v10 : int64 = v1 % 100L
    let v11 : bool = v10 = 0L
    if v11 then
        let v12 : string option = None
        let mutable _v12 = v12
        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v13 : string = $"%A{v9}"
        v13 
        #endif
        #if FABLE_COMPILER_RUST && WASM
        let v14 : string = $"%A{v9}"
        v14 
        #endif
        #if FABLE_COMPILER_RUST && CONTRACT
        let v15 : string = $"%A{v9}"
        v15 
        #endif
        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
        let v16 : string = $"{v9.GetType ()}: {v9.Message}"
        v16 
        #endif
        #if FABLE_COMPILER_TYPESCRIPT
        let v17 : string = $"%A{v9}"
        v17 
        #endif
        #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
        let v18 : string = Unchecked.defaultof<string>
        v18 
        #endif
        |> fun x -> _v12 <- Some x
        let v19 : string = _v12.Value
        let v20 : US3 = US3_3
        let v21 : (unit -> string) = closure16()
        let v22 : (unit -> string) = closure3()
        method7(v20, v21, v22)
    let v23 : Async<unit> option = None
    let mutable _v23 = v23
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v24 : Async<unit> = null |> unbox<Async<unit>>
    v24 
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v25 : Async<unit> = null |> unbox<Async<unit>>
    v25 
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v26 : Async<unit> = null |> unbox<Async<unit>>
    v26 
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v27 : (int32 -> Async<unit>) = Async.Sleep
    let v28 : Async<unit> = v27 10
    v28 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v29 : Async<unit> = null |> unbox<Async<unit>>
    v29 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v30 : Async<unit> = Unchecked.defaultof<Async<unit>>
    v30 
    #endif
    |> fun x -> _v23 <- Some x
    let v31 : Async<unit> = _v23.Value
    do! v31 
    let v32 : int64 = v1 + 1L
    let v33 : Async<int64> = method6(v0, v32)
    return! v33 
    (*
    let v34 : int64 = *)
    }
    |> fun x -> _v6 <- Some x
    let v35 : Async<int64> = _v6 |> Option.get
    v35 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v36 : Async<int64> = null |> unbox<Async<int64>>
    v36 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v37 : Async<int64> = Unchecked.defaultof<Async<int64>>
    v37 
    #endif
    |> fun x -> _v2 <- Some x
    let v38 : Async<int64> = _v2.Value
    v38
and closure15 () (v0 : string) : Async<int64> =
    let v1 : Async<int64> option = None
    let mutable _v1 = v1
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
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v5 : int64 = 0L
    let v6 : Async<int64> = method6(v0, v5)
    v6 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v7 : Async<int64> = null |> unbox<Async<int64>>
    v7 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v8 : Async<int64> = Unchecked.defaultof<Async<int64>>
    v8 
    #endif
    |> fun x -> _v1 <- Some x
    let v9 : Async<int64> = _v1.Value
    v9
and closure22 () () : string =
    let v0 : string = "move_file_async"
    v0
and method13 (v0 : string, v1 : string, v2 : exn) : string =
    let v3 : string option = None
    let mutable _v3 = v3
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
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v7 : string = $"{v2.GetType ()}: {v2.Message}"
    v7 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v8 : string = $"%A{v2}"
    v8 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v9 : string = Unchecked.defaultof<string>
    v9 
    #endif
    |> fun x -> _v3 <- Some x
    let v10 : string = _v3.Value
    let v11 : (string -> string) = closure2()
    let v12 : (unit -> string) = closure3()
    let v13 : string = $"old_path: {v1 |> v11} / new_path: {v0 |> v11} / ex: {v10} / {v12 ()}"
    v13
and closure23 (v0 : string, v1 : string, v2 : exn) () : string =
    method13(v0, v1, v2)
and method12 (v0 : string, v1 : string, v2 : int64) : Async<int64> =
    let v3 : Async<int64> option = None
    let mutable _v3 = v3
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
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v7 : Async<int64> option = None
    let mutable _v7 = v7
    async {
    try
    let v8 : unit option = None
    let mutable _v8 = v8
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
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    System.IO.File.Move (v1, v0)
    () 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    null |> unbox<unit>
    () 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    Unchecked.defaultof<unit>
    () 
    #endif
    |> fun x -> _v8 <- Some x
    _v8.Value
    return v2 
    with ex ->
    let v9 : exn = ex
    let v10 : int64 = v2 % 100L
    let v11 : bool = v10 = 0L
    if v11 then
        let v12 : US3 = US3_3
        let v13 : (unit -> string) = closure22()
        let v14 : (unit -> string) = closure23(v0, v1, v9)
        method7(v12, v13, v14)
    let v15 : Async<unit> option = None
    let mutable _v15 = v15
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v16 : Async<unit> = null |> unbox<Async<unit>>
    v16 
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v17 : Async<unit> = null |> unbox<Async<unit>>
    v17 
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v18 : Async<unit> = null |> unbox<Async<unit>>
    v18 
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v19 : (int32 -> Async<unit>) = Async.Sleep
    let v20 : Async<unit> = v19 10
    v20 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v21 : Async<unit> = null |> unbox<Async<unit>>
    v21 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v22 : Async<unit> = Unchecked.defaultof<Async<unit>>
    v22 
    #endif
    |> fun x -> _v15 <- Some x
    let v23 : Async<unit> = _v15.Value
    do! v23 
    let v24 : int64 = v2 + 1L
    let v25 : Async<int64> = method12(v0, v1, v24)
    return! v25 
    (*
    *)
    }
    |> fun x -> _v7 <- Some x
    let v26 : Async<int64> = _v7 |> Option.get
    v26 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v27 : Async<int64> = null |> unbox<Async<int64>>
    v27 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v28 : Async<int64> = Unchecked.defaultof<Async<int64>>
    v28 
    #endif
    |> fun x -> _v3 <- Some x
    let v29 : Async<int64> = _v3.Value
    v29
and closure21 (v0 : string) (v1 : string) : Async<int64> =
    let v2 : Async<int64> option = None
    let mutable _v2 = v2
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
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v6 : int64 = 0L
    let v7 : Async<int64> = method12(v0, v1, v6)
    v7 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v8 : Async<int64> = null |> unbox<Async<int64>>
    v8 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v9 : Async<int64> = Unchecked.defaultof<Async<int64>>
    v9 
    #endif
    |> fun x -> _v2 <- Some x
    let v10 : Async<int64> = _v2.Value
    v10
and closure20 () (v0 : string) : (string -> Async<int64>) =
    closure21(v0)
and closure25 () (v0 : int64) : US6 =
    US6_0(v0)
and closure26 () (v0 : exn) : US6 =
    US6_1(v0)
and closure27 () () : string =
    let v0 : string = "run_with_timeout_async"
    v0
and closure28 () () : string =
    let v0 : (unit -> string) = closure3()
    let v1 : string = $"timeout: {1000} / {v0 ()}"
    v1
and closure29 (v0 : string) () : string =
    let v1 : string = $"run_with_timeout_async** / ex: {v0}"
    v1
and closure30 () () : string =
    let v0 : string = "read_all_text_retry_async"
    v0
and method15 (v0 : int64, v1 : string) : string =
    let v2 : (unit -> string) = closure3()
    let v3 : string = $"retry: {v0} / ex: {v1} / {v2 ()}"
    v3
and closure31 (v0 : int64, v1 : string) () : string =
    method15(v0, v1)
and method14 (v0 : string, v1 : int64) : Async<string option> =
    let v2 : Async<string option> option = None
    let mutable _v2 = v2
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
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v6 : Async<string option> option = None
    let mutable _v6 = v6
    async {
    try
    let v7 : bool = v1 > 0L
    if v7 then
        let v8 : Async<int64> option = None
        let mutable _v8 = v8
        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v9 : Async<int64> = null |> unbox<Async<int64>>
        v9 
        #endif
        #if FABLE_COMPILER_RUST && WASM
        let v10 : Async<int64> = null |> unbox<Async<int64>>
        v10 
        #endif
        #if FABLE_COMPILER_RUST && CONTRACT
        let v11 : Async<int64> = null |> unbox<Async<int64>>
        v11 
        #endif
        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
        let v12 : int64 = 0L
        let v13 : Async<int64> = method4(v0, v12)
        v13 
        #endif
        #if FABLE_COMPILER_TYPESCRIPT
        let v14 : Async<int64> = null |> unbox<Async<int64>>
        v14 
        #endif
        #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
        let v15 : Async<int64> = Unchecked.defaultof<Async<int64>>
        v15 
        #endif
        |> fun x -> _v8 <- Some x
        let v16 : Async<int64> = _v8.Value
        let v17 : Async<US5> option = None
        let mutable _v17 = v17
        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v18 : Async<US5> = null |> unbox<Async<US5>>
        v18 
        #endif
        #if FABLE_COMPILER_RUST && WASM
        let v19 : Async<US5> = null |> unbox<Async<US5>>
        v19 
        #endif
        #if FABLE_COMPILER_RUST && CONTRACT
        let v20 : Async<US5> = null |> unbox<Async<US5>>
        v20 
        #endif
        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
        let v21 : Async<US5> option = None
        let mutable _v21 = v21
        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v22 : Async<US5> = null |> unbox<Async<US5>>
        v22 
        #endif
        #if FABLE_COMPILER_RUST && WASM
        let v23 : Async<US5> = null |> unbox<Async<US5>>
        v23 
        #endif
        #if FABLE_COMPILER_RUST && CONTRACT
        let v24 : Async<US5> = null |> unbox<Async<US5>>
        v24 
        #endif
        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
        let v25 : Async<US5> option = None
        let mutable _v25 = v25
        async {
        let v26 : Async<Async<int64>> option = None
        let mutable _v26 = v26
        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v27 : Async<Async<int64>> = null |> unbox<Async<Async<int64>>>
        v27 
        #endif
        #if FABLE_COMPILER_RUST && WASM
        let v28 : Async<Async<int64>> = null |> unbox<Async<Async<int64>>>
        v28 
        #endif
        #if FABLE_COMPILER_RUST && CONTRACT
        let v29 : Async<Async<int64>> = null |> unbox<Async<Async<int64>>>
        v29 
        #endif
        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
        let v30 : Async<Async<int64>> = Async.StartChild (v16, 1000)
        v30 
        #endif
        #if FABLE_COMPILER_TYPESCRIPT
        let v31 : Async<Async<int64>> = null |> unbox<Async<Async<int64>>>
        v31 
        #endif
        #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
        let v32 : Async<Async<int64>> = Unchecked.defaultof<Async<Async<int64>>>
        v32 
        #endif
        |> fun x -> _v26 <- Some x
        let v33 : Async<Async<int64>> = _v26.Value
        let! v33 = v33 
        let v34 : Async<int64> = v33 
        let v35 : Async<Choice<int64, exn>> option = None
        let mutable _v35 = v35
        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v36 : Async<Choice<int64, exn>> = null |> unbox<Async<Choice<int64, exn>>>
        v36 
        #endif
        #if FABLE_COMPILER_RUST && WASM
        let v37 : Async<Choice<int64, exn>> = null |> unbox<Async<Choice<int64, exn>>>
        v37 
        #endif
        #if FABLE_COMPILER_RUST && CONTRACT
        let v38 : Async<Choice<int64, exn>> = null |> unbox<Async<Choice<int64, exn>>>
        v38 
        #endif
        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
        let v39 : (Async<int64> -> Async<Choice<int64, exn>>) = Async.Catch
        let v40 : Async<Choice<int64, exn>> = v39 v34
        v40 
        #endif
        #if FABLE_COMPILER_TYPESCRIPT
        let v41 : Async<Choice<int64, exn>> = null |> unbox<Async<Choice<int64, exn>>>
        v41 
        #endif
        #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
        let v42 : Async<Choice<int64, exn>> = Unchecked.defaultof<Async<Choice<int64, exn>>>
        v42 
        #endif
        |> fun x -> _v35 <- Some x
        let v43 : Async<Choice<int64, exn>> = _v35.Value
        let v44 : Async<US6> option = None
        let mutable _v44 = v44
        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v45 : Async<US6> = null |> unbox<Async<US6>>
        v45 
        #endif
        #if FABLE_COMPILER_RUST && WASM
        let v46 : Async<US6> = null |> unbox<Async<US6>>
        v46 
        #endif
        #if FABLE_COMPILER_RUST && CONTRACT
        let v47 : Async<US6> = null |> unbox<Async<US6>>
        v47 
        #endif
        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
        let v48 : Async<US6> option = None
        let mutable _v48 = v48
        async {
        let! v43 = v43 
        let v49 : Choice<int64, exn> = v43 
        let v50 : US6 option = None
        let mutable _v50 = v50
        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v51 : US6 = null |> unbox<US6>
        v51 
        #endif
        #if FABLE_COMPILER_RUST && WASM
        let v52 : US6 = null |> unbox<US6>
        v52 
        #endif
        #if FABLE_COMPILER_RUST && CONTRACT
        let v53 : US6 = null |> unbox<US6>
        v53 
        #endif
        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
        let v54 : (int64 -> US6) = closure25()
        let v55 : (exn -> US6) = closure26()
        let v56 : US6 = match v49 with Choice1Of2 x -> v54 x | Choice2Of2 x -> v55 x
        v56 
        #endif
        #if FABLE_COMPILER_TYPESCRIPT
        let v57 : US6 = null |> unbox<US6>
        v57 
        #endif
        #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
        let v58 : US6 = Unchecked.defaultof<US6>
        v58 
        #endif
        |> fun x -> _v50 <- Some x
        let v59 : US6 = _v50.Value
        return v59 
        }
        |> fun x -> _v48 <- Some x
        let v60 : Async<US6> = _v48 |> Option.get
        v60 
        #endif
        #if FABLE_COMPILER_TYPESCRIPT
        let v61 : Async<US6> = null |> unbox<Async<US6>>
        v61 
        #endif
        #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
        let v62 : Async<US6> = Unchecked.defaultof<Async<US6>>
        v62 
        #endif
        |> fun x -> _v44 <- Some x
        let v63 : Async<US6> = _v44.Value
        let v64 : Async<US7> option = None
        let mutable _v64 = v64
        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v65 : Async<US7> = null |> unbox<Async<US7>>
        v65 
        #endif
        #if FABLE_COMPILER_RUST && WASM
        let v66 : Async<US7> = null |> unbox<Async<US7>>
        v66 
        #endif
        #if FABLE_COMPILER_RUST && CONTRACT
        let v67 : Async<US7> = null |> unbox<Async<US7>>
        v67 
        #endif
        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
        let v68 : Async<US7> option = None
        let mutable _v68 = v68
        async {
        let! v63 = v63 
        let v69 : US6 = v63 
        let v75 : US7 =
            match v69 with
            | US6_0(v70) -> (* Choice1Of2 *)
                US7_0(v70)
            | US6_1(v72) -> (* Choice2Of2 *)
                US7_1(v72)
        return v75 
        }
        |> fun x -> _v68 <- Some x
        let v76 : Async<US7> = _v68 |> Option.get
        v76 
        #endif
        #if FABLE_COMPILER_TYPESCRIPT
        let v77 : Async<US7> = null |> unbox<Async<US7>>
        v77 
        #endif
        #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
        let v78 : Async<US7> = Unchecked.defaultof<Async<US7>>
        v78 
        #endif
        |> fun x -> _v64 <- Some x
        let v79 : Async<US7> = _v64.Value
        let v80 : Async<US5> option = None
        let mutable _v80 = v80
        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v81 : Async<US5> = null |> unbox<Async<US5>>
        v81 
        #endif
        #if FABLE_COMPILER_RUST && WASM
        let v82 : Async<US5> = null |> unbox<Async<US5>>
        v82 
        #endif
        #if FABLE_COMPILER_RUST && CONTRACT
        let v83 : Async<US5> = null |> unbox<Async<US5>>
        v83 
        #endif
        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
        let v84 : Async<US5> option = None
        let mutable _v84 = v84
        async {
        let! v79 = v79 
        let v85 : US7 = v79 
        let v110 : US5 =
            match v85 with
            | US7_1(v88) -> (* Error *)
                let v89 : string = $"%A{v88}"
                let v90 : string = "System.TimeoutException"
                let v91 : bool = v89.Contains v90
                if v91 then
                    let v92 : US3 = US3_1
                    let v93 : (unit -> string) = closure27()
                    let v94 : (unit -> string) = closure28()
                    method7(v92, v93, v94)
                    US5_1
                else
                    let v96 : string option = None
                    let mutable _v96 = v96
                    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v97 : string = $"%A{v88}"
                    v97 
                    #endif
                    #if FABLE_COMPILER_RUST && WASM
                    let v98 : string = $"%A{v88}"
                    v98 
                    #endif
                    #if FABLE_COMPILER_RUST && CONTRACT
                    let v99 : string = $"%A{v88}"
                    v99 
                    #endif
                    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                    let v100 : string = $"{v88.GetType ()}: {v88.Message}"
                    v100 
                    #endif
                    #if FABLE_COMPILER_TYPESCRIPT
                    let v101 : string = $"%A{v88}"
                    v101 
                    #endif
                    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
                    let v102 : string = Unchecked.defaultof<string>
                    v102 
                    #endif
                    |> fun x -> _v96 <- Some x
                    let v103 : string = _v96.Value
                    let v104 : US3 = US3_4
                    let v105 : (unit -> string) = closure29(v103)
                    let v106 : (unit -> string) = closure28()
                    method7(v104, v105, v106)
                    US5_1
            | US7_0(v86) -> (* Ok *)
                US5_0(v86)
        return v110 
        }
        |> fun x -> _v84 <- Some x
        let v111 : Async<US5> = _v84 |> Option.get
        v111 
        #endif
        #if FABLE_COMPILER_TYPESCRIPT
        let v112 : Async<US5> = null |> unbox<Async<US5>>
        v112 
        #endif
        #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
        let v113 : Async<US5> = Unchecked.defaultof<Async<US5>>
        v113 
        #endif
        |> fun x -> _v80 <- Some x
        let v114 : Async<US5> = _v80.Value
        return! v114 
        }
        |> fun x -> _v25 <- Some x
        let v115 : Async<US5> = _v25 |> Option.get
        v115 
        #endif
        #if FABLE_COMPILER_TYPESCRIPT
        let v116 : Async<US5> = null |> unbox<Async<US5>>
        v116 
        #endif
        #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
        let v117 : Async<US5> = Unchecked.defaultof<Async<US5>>
        v117 
        #endif
        |> fun x -> _v21 <- Some x
        let v118 : Async<US5> = _v21.Value
        v118 
        #endif
        #if FABLE_COMPILER_TYPESCRIPT
        let v119 : Async<US5> = null |> unbox<Async<US5>>
        v119 
        #endif
        #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
        let v120 : Async<US5> = Unchecked.defaultof<Async<US5>>
        v120 
        #endif
        |> fun x -> _v17 <- Some x
        let v121 : Async<US5> = _v17.Value
        let v122 : Async<unit> option = None
        let mutable _v122 = v122
        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v123 : Async<unit> = null |> unbox<Async<unit>>
        v123 
        #endif
        #if FABLE_COMPILER_RUST && WASM
        let v124 : Async<unit> = null |> unbox<Async<unit>>
        v124 
        #endif
        #if FABLE_COMPILER_RUST && CONTRACT
        let v125 : Async<unit> = null |> unbox<Async<unit>>
        v125 
        #endif
        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
        let v126 : (Async<US5> -> Async<unit>) = Async.Ignore
        let v127 : Async<unit> = v126 v121
        v127 
        #endif
        #if FABLE_COMPILER_TYPESCRIPT
        let v128 : Async<unit> = null |> unbox<Async<unit>>
        v128 
        #endif
        #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
        let v129 : Async<unit> = Unchecked.defaultof<Async<unit>>
        v129 
        #endif
        |> fun x -> _v122 <- Some x
        let v130 : Async<unit> = _v122.Value
        do! v130 
        ()
    let v131 : Async<string> option = None
    let mutable _v131 = v131
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v132 : Async<string> = null |> unbox<Async<string>>
    v132 
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v133 : Async<string> = null |> unbox<Async<string>>
    v133 
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v134 : Async<string> = null |> unbox<Async<string>>
    v134 
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v135 : (string -> System.Threading.Tasks.Task<string>) = System.IO.File.ReadAllTextAsync
    let v136 : System.Threading.Tasks.Task<string> = v135 v0
    let v137 : Async<string> option = None
    let mutable _v137 = v137
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v138 : Async<string> = null |> unbox<Async<string>>
    v138 
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v139 : Async<string> = null |> unbox<Async<string>>
    v139 
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v140 : Async<string> = null |> unbox<Async<string>>
    v140 
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v141 : (System.Threading.Tasks.Task<string> -> Async<string>) = Async.AwaitTask
    let v142 : Async<string> = v141 v136
    v142 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v143 : Async<string> = null |> unbox<Async<string>>
    v143 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v144 : Async<string> = Unchecked.defaultof<Async<string>>
    v144 
    #endif
    |> fun x -> _v137 <- Some x
    let v145 : Async<string> = _v137.Value
    v145 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v146 : Async<string> = null |> unbox<Async<string>>
    v146 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v147 : Async<string> = Unchecked.defaultof<Async<string>>
    v147 
    #endif
    |> fun x -> _v131 <- Some x
    let v148 : Async<string> = _v131.Value
    let v149 : Async<string option> option = None
    let mutable _v149 = v149
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v150 : Async<string option> = null |> unbox<Async<string option>>
    v150 
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v151 : Async<string option> = null |> unbox<Async<string option>>
    v151 
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v152 : Async<string option> = null |> unbox<Async<string option>>
    v152 
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v153 : Async<string option> option = None
    let mutable _v153 = v153
    async {
    let! v148 = v148 
    let v154 : string = v148 
    let v155 : string option = Some v154 
    return v155 
    }
    |> fun x -> _v153 <- Some x
    let v156 : Async<string option> = _v153 |> Option.get
    v156 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v157 : Async<string option> = null |> unbox<Async<string option>>
    v157 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v158 : Async<string option> = Unchecked.defaultof<Async<string option>>
    v158 
    #endif
    |> fun x -> _v149 <- Some x
    let v159 : Async<string option> = _v149.Value
    return! v159 
    with ex ->
    let v160 : exn = ex
    let v161 : bool = v1 = 0L
    let v162 : bool = v161 <> true
    if v162 then
        let v163 : string option = None
        let mutable _v163 = v163
        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v164 : string = $"%A{v160}"
        v164 
        #endif
        #if FABLE_COMPILER_RUST && WASM
        let v165 : string = $"%A{v160}"
        v165 
        #endif
        #if FABLE_COMPILER_RUST && CONTRACT
        let v166 : string = $"%A{v160}"
        v166 
        #endif
        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
        let v167 : string = $"{v160.GetType ()}: {v160.Message}"
        v167 
        #endif
        #if FABLE_COMPILER_TYPESCRIPT
        let v168 : string = $"%A{v160}"
        v168 
        #endif
        #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
        let v169 : string = Unchecked.defaultof<string>
        v169 
        #endif
        |> fun x -> _v163 <- Some x
        let v170 : string = _v163.Value
        let v171 : US3 = US3_1
        let v172 : (unit -> string) = closure30()
        let v173 : (unit -> string) = closure31(v1, v170)
        method7(v171, v172, v173)
        let v174 : string option = None
        return v174 
        (*
        ()
    else
        *) else
        let v175 : int64 = v1 + 1L
        let v176 : Async<string option> = method14(v0, v175)
        return! v176 
        (*
        ()
    *)
    (*
    let v177 : string option = *)
    }
    |> fun x -> _v6 <- Some x
    let v178 : Async<string option> = _v6 |> Option.get
    v178 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v179 : Async<string option> = null |> unbox<Async<string option>>
    v179 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v180 : Async<string option> = Unchecked.defaultof<Async<string option>>
    v180 
    #endif
    |> fun x -> _v2 <- Some x
    let v181 : Async<string option> = _v2.Value
    v181
and closure24 () (v0 : string) : Async<string option> =
    let v1 : Async<string option> option = None
    let mutable _v1 = v1
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
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v5 : int64 = 0L
    let v6 : Async<string option> = method14(v0, v5)
    v6 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v7 : Async<string option> = null |> unbox<Async<string option>>
    v7 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v8 : Async<string option> = Unchecked.defaultof<Async<string option>>
    v8 
    #endif
    |> fun x -> _v1 <- Some x
    let v9 : Async<string option> = _v1.Value
    v9
and closure33 () () : string =
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
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v4 : string = System.Reflection.Assembly.GetEntryAssembly().GetName().Name
    v4 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v5 : string = null |> unbox<string>
    v5 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v6 : string = Unchecked.defaultof<string>
    v6 
    #endif
    |> fun x -> _v0 <- Some x
    let v7 : string = _v0.Value
    v7
and closure32 () () : string =
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
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v4 : (unit -> string) = System.IO.Path.GetTempPath
    let v5 : string = v4 ()
    let v6 : (unit -> string) = closure33()
    let v7 : string = $"!{v6 ()}"
    let v8 : string option = None
    let mutable _v8 = v8
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v9 : string = method5(v5)
    let v10 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v11 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v9 v10
    let v12 : string = "String::from($0)"
    let v13 : std_string_String = Fable.Core.RustInterop.emitRustExpr v11 v12
    let v14 : string = "std::path::PathBuf::from($0)"
    let v15 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v13 v14
    let v16 : string = method5(v7)
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
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v29 : string = System.IO.Path.Combine (v5, v7)
    v29 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v30 : string = "path"
    let v31 : IPathJoin = Fable.Core.JsInterop.importAll v30
    let v32 : string = "v31.join($0, $1)"
    let v33 : string = Fable.Core.JsInterop.emitJsExpr struct (v5, v7) v32
    v33 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v34 : string = Unchecked.defaultof<string>
    v34 
    #endif
    |> fun x -> _v8 <- Some x
    let v35 : string = _v8.Value
    let v36 : System.DateTime = System.DateTime.Now
    let v37 : System.Guid = System.Guid.NewGuid ()
    let v38 : (System.Guid -> string) = _.ToString()
    let v39 : string = v38 v37
    let v40 : string = v36.ToString "yyyyMMdd-HHmm-ssff-ffff-f"
    let v41 : System.Guid = System.Guid $"{v40}{v39.[v40.Length..]}"
    let v42 : (System.Guid -> string) = _.ToString()
    let v43 : string = v42 v41
    let v44 : string option = None
    let mutable _v44 = v44
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v45 : string = method5(v35)
    let v46 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v47 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v45 v46
    let v48 : string = "String::from($0)"
    let v49 : std_string_String = Fable.Core.RustInterop.emitRustExpr v47 v48
    let v50 : string = "std::path::PathBuf::from($0)"
    let v51 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v49 v50
    let v52 : string = method5(v43)
    let v53 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v54 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v52 v53
    let v55 : string = "String::from($0)"
    let v56 : std_string_String = Fable.Core.RustInterop.emitRustExpr v54 v55
    let v57 : string = "$0.join($1)"
    let v58 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr struct (v51, v56) v57
    let v59 : string = "$0.display().to_string()"
    let v60 : std_string_String = Fable.Core.RustInterop.emitRustExpr v58 v59
    let v61 : string = "fable_library_rust::String_::fromString($0)"
    let v62 : string = Fable.Core.RustInterop.emitRustExpr v60 v61
    v62 
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v63 : string = null |> unbox<string>
    v63 
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v64 : string = null |> unbox<string>
    v64 
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v65 : string = System.IO.Path.Combine (v35, v43)
    v65 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v66 : IPathJoin = Fable.Core.JsInterop.importAll v30
    let v67 : string = "v66.join($0, $1)"
    let v68 : string = Fable.Core.JsInterop.emitJsExpr struct (v35, v43) v67
    v68 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v69 : string = Unchecked.defaultof<string>
    v69 
    #endif
    |> fun x -> _v44 <- Some x
    let v70 : string = _v44.Value
    v70 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v71 : string = null |> unbox<string>
    v71 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v72 : string = Unchecked.defaultof<string>
    v72 
    #endif
    |> fun x -> _v0 <- Some x
    let v73 : string = _v0.Value
    v73
and closure35 (v0 : string, v1 : string) () : string =
    let v2 : (unit -> string) = closure3()
    let v3 : string = $"temp_folder: {v0} / result: {v1} {v2 ()}"
    v3
and closure36 (v0 : string) () : unit =
    let v1 : Async<int64> option = None
    let mutable _v1 = v1
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
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v5 : int64 = 0L
    let v6 : Async<int64> = method0(v0, v5)
    v6 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v7 : Async<int64> = null |> unbox<Async<int64>>
    v7 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v8 : Async<int64> = Unchecked.defaultof<Async<int64>>
    v8 
    #endif
    |> fun x -> _v1 <- Some x
    let v9 : Async<int64> = _v1.Value
    let v10 : Async<unit> option = None
    let mutable _v10 = v10
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
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v14 : (Async<int64> -> Async<unit>) = Async.Ignore
    let v15 : Async<unit> = v14 v9
    v15 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v16 : Async<unit> = null |> unbox<Async<unit>>
    v16 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v17 : Async<unit> = Unchecked.defaultof<Async<unit>>
    v17 
    #endif
    |> fun x -> _v10 <- Some x
    let v18 : Async<unit> = _v10.Value
    let v19 : unit option = None
    let mutable _v19 = v19
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
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v20 : (Async<unit> -> unit) = Async.RunSynchronously
    v20 v18
    () 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    null |> unbox<unit>
    () 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    Unchecked.defaultof<unit>
    () 
    #endif
    |> fun x -> _v19 <- Some x
    _v19.Value
    ()
and closure34 () () : struct (string * System.IDisposable) =
    let v0 : struct (string * System.IDisposable) option = None
    let mutable _v0 = v0
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let struct (v1 : string, v2 : System.IDisposable) = null |> unbox<struct (string * System.IDisposable)>
    struct (v1, v2) 
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let struct (v3 : string, v4 : System.IDisposable) = null |> unbox<struct (string * System.IDisposable)>
    struct (v3, v4) 
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let struct (v5 : string, v6 : System.IDisposable) = null |> unbox<struct (string * System.IDisposable)>
    struct (v5, v6) 
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v7 : string option = None
    let mutable _v7 = v7
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
    let v11 : (unit -> string) = System.IO.Path.GetTempPath
    let v12 : string = v11 ()
    let v13 : (unit -> string) = closure33()
    let v14 : string = $"!{v13 ()}"
    let v15 : string option = None
    let mutable _v15 = v15
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v16 : string = method5(v12)
    let v17 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v18 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v16 v17
    let v19 : string = "String::from($0)"
    let v20 : std_string_String = Fable.Core.RustInterop.emitRustExpr v18 v19
    let v21 : string = "std::path::PathBuf::from($0)"
    let v22 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v20 v21
    let v23 : string = method5(v14)
    let v24 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v25 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v23 v24
    let v26 : string = "String::from($0)"
    let v27 : std_string_String = Fable.Core.RustInterop.emitRustExpr v25 v26
    let v28 : string = "$0.join($1)"
    let v29 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr struct (v22, v27) v28
    let v30 : string = "$0.display().to_string()"
    let v31 : std_string_String = Fable.Core.RustInterop.emitRustExpr v29 v30
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
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v36 : string = System.IO.Path.Combine (v12, v14)
    v36 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v37 : string = "path"
    let v38 : IPathJoin = Fable.Core.JsInterop.importAll v37
    let v39 : string = "v38.join($0, $1)"
    let v40 : string = Fable.Core.JsInterop.emitJsExpr struct (v12, v14) v39
    v40 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v41 : string = Unchecked.defaultof<string>
    v41 
    #endif
    |> fun x -> _v15 <- Some x
    let v42 : string = _v15.Value
    let v43 : System.DateTime = System.DateTime.Now
    let v44 : System.Guid = System.Guid.NewGuid ()
    let v45 : (System.Guid -> string) = _.ToString()
    let v46 : string = v45 v44
    let v47 : string = v43.ToString "yyyyMMdd-HHmm-ssff-ffff-f"
    let v48 : System.Guid = System.Guid $"{v47}{v46.[v47.Length..]}"
    let v49 : (System.Guid -> string) = _.ToString()
    let v50 : string = v49 v48
    let v51 : string option = None
    let mutable _v51 = v51
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v52 : string = method5(v42)
    let v53 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v54 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v52 v53
    let v55 : string = "String::from($0)"
    let v56 : std_string_String = Fable.Core.RustInterop.emitRustExpr v54 v55
    let v57 : string = "std::path::PathBuf::from($0)"
    let v58 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v56 v57
    let v59 : string = method5(v50)
    let v60 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v61 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v59 v60
    let v62 : string = "String::from($0)"
    let v63 : std_string_String = Fable.Core.RustInterop.emitRustExpr v61 v62
    let v64 : string = "$0.join($1)"
    let v65 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr struct (v58, v63) v64
    let v66 : string = "$0.display().to_string()"
    let v67 : std_string_String = Fable.Core.RustInterop.emitRustExpr v65 v66
    let v68 : string = "fable_library_rust::String_::fromString($0)"
    let v69 : string = Fable.Core.RustInterop.emitRustExpr v67 v68
    v69 
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v70 : string = null |> unbox<string>
    v70 
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v71 : string = null |> unbox<string>
    v71 
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v72 : string = System.IO.Path.Combine (v42, v50)
    v72 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v73 : IPathJoin = Fable.Core.JsInterop.importAll v37
    let v74 : string = "v73.join($0, $1)"
    let v75 : string = Fable.Core.JsInterop.emitJsExpr struct (v42, v50) v74
    v75 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v76 : string = Unchecked.defaultof<string>
    v76 
    #endif
    |> fun x -> _v51 <- Some x
    let v77 : string = _v51.Value
    v77 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v78 : string = null |> unbox<string>
    v78 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v79 : string = Unchecked.defaultof<string>
    v79 
    #endif
    |> fun x -> _v7 <- Some x
    let v80 : string = _v7.Value
    let v81 : System.IO.DirectoryInfo option = None
    let mutable _v81 = v81
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v82 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    v82 
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v83 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    v83 
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v84 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    v84 
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v85 : (string -> System.IO.DirectoryInfo) = System.IO.Directory.CreateDirectory
    let v86 : System.IO.DirectoryInfo = v85 v80
    v86 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v87 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    v87 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v88 : System.IO.DirectoryInfo = Unchecked.defaultof<System.IO.DirectoryInfo>
    v88 
    #endif
    |> fun x -> _v81 <- Some x
    let v89 : System.IO.DirectoryInfo = _v81.Value
    let v90 : bool option = None
    let mutable _v90 = v90
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v91 : bool = null |> unbox<bool>
    v91 
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v92 : bool = null |> unbox<bool>
    v92 
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v93 : bool = null |> unbox<bool>
    v93 
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v94 : bool = v89.Exists
    v94 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v95 : bool = null |> unbox<bool>
    v95 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v96 : bool = Unchecked.defaultof<bool>
    v96 
    #endif
    |> fun x -> _v90 <- Some x
    let v97 : bool = _v90.Value
    let v98 : bool = v97 = false
    if v98 then
        let v99 : System.DateTime option = None
        let mutable _v99 = v99
        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v100 : System.DateTime = null |> unbox<System.DateTime>
        v100 
        #endif
        #if FABLE_COMPILER_RUST && WASM
        let v101 : System.DateTime = null |> unbox<System.DateTime>
        v101 
        #endif
        #if FABLE_COMPILER_RUST && CONTRACT
        let v102 : System.DateTime = null |> unbox<System.DateTime>
        v102 
        #endif
        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
        let v103 : System.DateTime = v89.CreationTime
        v103 
        #endif
        #if FABLE_COMPILER_TYPESCRIPT
        let v104 : System.DateTime = null |> unbox<System.DateTime>
        v104 
        #endif
        #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
        let v105 : System.DateTime = Unchecked.defaultof<System.DateTime>
        v105 
        #endif
        |> fun x -> _v99 <- Some x
        let v106 : System.DateTime = _v99.Value
        let v107 : obj = {| Exists = v97; CreationTime = v106 |}
        let v108 : string = $"%A{v107}"
        let v109 : (unit -> string) = closure35(v80, v108)
        let v110 : string = $"create_temp_directory / {v109 ()}"
        System.Console.WriteLine v110
        ()
    let v111 : System.IDisposable option = None
    let mutable _v111 = v111
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v112 : System.IDisposable = null |> unbox<System.IDisposable>
    v112 
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v113 : System.IDisposable = null |> unbox<System.IDisposable>
    v113 
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v114 : System.IDisposable = null |> unbox<System.IDisposable>
    v114 
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v115 : (unit -> unit) = closure36(v80)
    let v116 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v115 () }
    v116 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v117 : System.IDisposable = null |> unbox<System.IDisposable>
    v117 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v118 : System.IDisposable = Unchecked.defaultof<System.IDisposable>
    v118 
    #endif
    |> fun x -> _v111 <- Some x
    let v119 : System.IDisposable = _v111.Value
    struct (v80, v119) 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let struct (v120 : string, v121 : System.IDisposable) = null |> unbox<struct (string * System.IDisposable)>
    struct (v120, v121) 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let struct (v122 : string, v123 : System.IDisposable) = Unchecked.defaultof<struct (string * System.IDisposable)>
    struct (v122, v123) 
    #endif
    |> fun x -> _v0 <- Some x
    let struct (v124 : string, v125 : System.IDisposable) = _v0.Value
    struct (v124, v125)
and closure37 () () : string =
    let v0 : string = __SOURCE_DIRECTORY__
    v0
and closure41 () (v0 : string) : bool =
    let v1 : bool option = None
    let mutable _v1 = v1
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = method5(v0)
    let v3 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v4 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v2 v3
    let v5 : string = "String::from($0)"
    let v6 : std_string_String = Fable.Core.RustInterop.emitRustExpr v4 v5
    let v7 : string = "std::path::PathBuf::from($0)"
    let v8 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v6 v7
    let v9 : string = "$0.exists()"
    let v10 : bool = Fable.Core.RustInterop.emitRustExpr v8 v9
    let v13 : bool =
        if v10 then
            let v11 : string = "$0.is_file()"
            let v12 : bool = Fable.Core.RustInterop.emitRustExpr v8 v11
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
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v16 : (string -> bool) = System.IO.File.Exists
    let v17 : bool = v16 v0
    v17 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v18 : string = "fs"
    let v19 : IFsExistsSync = Fable.Core.JsInterop.importAll v18
    let v20 : string = "v19.existsSync($0)"
    let v21 : bool = Fable.Core.JsInterop.emitJsExpr v0 v20
    v21 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v22 : bool = Unchecked.defaultof<bool>
    v22 
    #endif
    |> fun x -> _v1 <- Some x
    let v23 : bool = _v1.Value
    v23
and closure42 () (v0 : string) : bool =
    let v1 : bool option = None
    let mutable _v1 = v1
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = method5(v0)
    let v3 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v4 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v2 v3
    let v5 : string = "String::from($0)"
    let v6 : std_string_String = Fable.Core.RustInterop.emitRustExpr v4 v5
    let v7 : string = "std::path::PathBuf::from($0)"
    let v8 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v6 v7
    let v9 : string = "$0.exists()"
    let v10 : bool = Fable.Core.RustInterop.emitRustExpr v8 v9
    let v13 : bool =
        if v10 then
            let v11 : string = "$0.is_dir()"
            let v12 : bool = Fable.Core.RustInterop.emitRustExpr v8 v11
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
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v16 : (string -> bool) = System.IO.Directory.Exists
    let v17 : bool = v16 v0
    v17 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v18 : string = "fs"
    let v19 : IFsExistsSync = Fable.Core.JsInterop.importAll v18
    let v20 : string = "v19.existsSync($0)"
    let v21 : bool = Fable.Core.JsInterop.emitJsExpr v0 v20
    v21 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v22 : bool = Unchecked.defaultof<bool>
    v22 
    #endif
    |> fun x -> _v1 <- Some x
    let v23 : bool = _v1.Value
    v23
and closure43 () (v0 : string) : string option =
    let v1 : US8 option = None
    let mutable _v1 = v1
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = method5(v0)
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
    let v17 : US8 = US8_0(v16)
    v17 
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v18 : US8 = null |> unbox<US8>
    v18 
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v19 : US8 = null |> unbox<US8>
    v19 
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v20 : (string -> System.IO.DirectoryInfo) = System.IO.Directory.GetParent
    let v21 : System.IO.DirectoryInfo = v20 v0
    let v22 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    let v23 : bool = v21 = v22
    let v34 : US8 =
        if v23 then
            US8_1
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
            US8_0(v32)
    v34 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v35 : string = "path"
    let v36 : IPathDirname = Fable.Core.JsInterop.importAll v35
    let v37 : string = "v36.dirname($0)"
    let v38 : string = Fable.Core.JsInterop.emitJsExpr v0 v37
    let v39 : US8 = US8_0(v38)
    v39 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v40 : US8 = Unchecked.defaultof<US8>
    v40 
    #endif
    |> fun x -> _v1 <- Some x
    let v41 : US8 = _v1.Value
    match v41 with
    | US8_1 -> (* None *)
        let v44 : string option = None
        v44
    | US8_0(v42) -> (* Some *)
        let v43 : string option = Some v42 
        v43
and method17 () : (string -> string option) =
    closure43()
and closure44 () (v0 : string) : US8 =
    US8_0(v0)
and method18 () : (string -> US8) =
    closure44()
and method19 (v0 : string, v1 : bool, v2 : string, v3 : string) : string =
    let v4 : string option = None
    let mutable _v4 = v4
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v5 : string = method5(v3)
    let v6 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v7 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v6
    let v8 : string = "String::from($0)"
    let v9 : std_string_String = Fable.Core.RustInterop.emitRustExpr v7 v8
    let v10 : string = "std::path::PathBuf::from($0)"
    let v11 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v9 v10
    let v12 : string = method5(v0)
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
    let v25 : string = System.IO.Path.Combine (v3, v0)
    v25 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v26 : string = "path"
    let v27 : IPathJoin = Fable.Core.JsInterop.importAll v26
    let v28 : string = "v27.join($0, $1)"
    let v29 : string = Fable.Core.JsInterop.emitJsExpr struct (v3, v0) v28
    v29 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v30 : string = Unchecked.defaultof<string>
    v30 
    #endif
    |> fun x -> _v4 <- Some x
    let v31 : string = _v4.Value
    let v34 : (string -> bool) =
        if v1 then
            closure41()
        else
            closure42()
    let v35 : bool = v34 v31
    if v35 then
        v3
    else
        let v36 : (string -> string option) = method17()
        let v37 : string option = v36 v3
        let v38 : (string -> US8) = method18()
        let v39 : US8 = US8_1
        let v40 : US8 = v37 |> Option.map v38 |> Option.defaultValue v39 
        match v40 with
        | US8_1 -> (* None *)
            let v43 : string = $"""No parent for {if v1 then "file" else "dir"} '{v0}' at '{v2}' (until '{v3}')"""
            failwith<string> v43
        | US8_0(v41) -> (* Some *)
            method19(v0, v1, v2, v41)
and method16 (v0 : string, v1 : bool, v2 : string) : string =
    let v3 : string option = None
    let mutable _v3 = v3
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v4 : string = method5(v2)
    let v5 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v6 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v4 v5
    let v7 : string = "String::from($0)"
    let v8 : std_string_String = Fable.Core.RustInterop.emitRustExpr v6 v7
    let v9 : string = "std::path::PathBuf::from($0)"
    let v10 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v8 v9
    let v11 : string = method5(v0)
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
    let v27 : string = "v26.join($0, $1)"
    let v28 : string = Fable.Core.JsInterop.emitJsExpr struct (v2, v0) v27
    v28 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v29 : string = Unchecked.defaultof<string>
    v29 
    #endif
    |> fun x -> _v3 <- Some x
    let v30 : string = _v3.Value
    let v33 : (string -> bool) =
        if v1 then
            closure41()
        else
            closure42()
    let v34 : bool = v33 v30
    if v34 then
        v2
    else
        let v35 : (string -> string option) = method17()
        let v36 : string option = v35 v2
        let v37 : (string -> US8) = method18()
        let v38 : US8 = US8_1
        let v39 : US8 = v36 |> Option.map v37 |> Option.defaultValue v38 
        match v39 with
        | US8_1 -> (* None *)
            let v42 : string = $"""No parent for {if v1 then "file" else "dir"} '{v0}' at '{v2}' (until '{v2}')"""
            failwith<string> v42
        | US8_0(v40) -> (* Some *)
            method19(v0, v1, v2, v40)
and closure40 (v0 : string, v1 : bool) (v2 : string) : string =
    method16(v0, v1, v2)
and closure39 (v0 : string) (v1 : bool) : (string -> string) =
    closure40(v0, v1)
and closure38 () (v0 : string) : (bool -> (string -> string)) =
    closure39(v0)
and closure46 (v0 : string) (v1 : string) : string =
    let v2 : string option = None
    let mutable _v2 = v2
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : string = method5(v0)
    let v4 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v5 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v3 v4
    let v6 : string = "String::from($0)"
    let v7 : std_string_String = Fable.Core.RustInterop.emitRustExpr v5 v6
    let v8 : string = "std::path::PathBuf::from($0)"
    let v9 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v7 v8
    let v10 : string = method5(v1)
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
    let v23 : string = System.IO.Path.Combine (v0, v1)
    v23 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v24 : string = "path"
    let v25 : IPathJoin = Fable.Core.JsInterop.importAll v24
    let v26 : string = "v25.join($0, $1)"
    let v27 : string = Fable.Core.JsInterop.emitJsExpr struct (v0, v1) v26
    v27 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v28 : string = Unchecked.defaultof<string>
    v28 
    #endif
    |> fun x -> _v2 <- Some x
    let v29 : string = _v2.Value
    v29
and closure45 () (v0 : string) : (string -> string) =
    closure46(v0)
let v0 : unit option = None
let mutable _v0 = v0
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
() 
#endif
#if FABLE_COMPILER_RUST && WASM
() 
#endif
#if FABLE_COMPILER_RUST && CONTRACT
() 
#endif
#if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
let v1 : (string -> Async<int64>) = closure0()
let delete_directory_async x = v1 x
let v2 : (US0 -> (string -> Async<int64>)) = closure4()
let wait_for_file_access x = v2 x
let v3 : (string -> Async<int64>) = closure7()
let wait_for_file_access_read x = v3 x
let v4 : (string -> Async<string>) = closure8()
let read_all_text_async x = v4 x
let v5 : (string -> (string -> Async<bool>)) = closure9()
let file_exists_content x = v5 x
let v6 : (string -> (string -> Async<unit>)) = closure11()
let write_all_text_async x = v6 x
let v7 : (string -> (string -> Async<unit>)) = closure13()
let write_all_text_exists x = v7 x
let v8 : (string -> Async<int64>) = closure15()
let delete_file_async x = v8 x
let v9 : (string -> (string -> Async<int64>)) = closure20()
let move_file_async x = v9 x
let v10 : (string -> Async<string option>) = closure24()
let read_all_text_retry_async x = v10 x
() 
#endif
#if FABLE_COMPILER_TYPESCRIPT
() 
#endif
#if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
Unchecked.defaultof<unit>
() 
#endif
|> fun x -> _v0 <- Some x
_v0.Value
let v11 : (unit -> string) = closure32()
let create_temp_directory_name () = v11 ()
let v12 : (unit -> struct (string * System.IDisposable)) = closure34()
let create_temp_directory () = v12 ()
let v13 : (unit -> string) = closure37()
let get_source_directory () = v13 ()
let v14 : (string -> (bool -> (string -> string))) = closure38()
let find_parent x = v14 x
let v15 : (string -> (string -> string)) = closure45()
let (</>) x = v15 x
()
