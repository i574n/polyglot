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
    Unchecked.defaultof<string>
    #endif
    |> fun x -> _v1 <- Some x
    let v8 : string = _v1.Value
    v8
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
        Unchecked.defaultof<string>
        #endif
        |> fun x -> _v11 <- Some x
        let v17 : string = _v11.Value
        let v18 : (unit -> string) = closure1(v0, v17)
        let v19 : string = $"delete_directory_async / {v18 ()}"
        System.Console.WriteLine v19
        ()
    let v20 : Async<unit> option = None
    let mutable _v20 = v20
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v21 : Async<unit> = null |> unbox<Async<unit>>
    v21 
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v22 : Async<unit> = null |> unbox<Async<unit>>
    v22 
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v23 : Async<unit> = null |> unbox<Async<unit>>
    v23 
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v24 : (int32 -> Async<unit>) = Async.Sleep
    let v25 : Async<unit> = v24 10
    v25 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v26 : Async<unit> = null |> unbox<Async<unit>>
    v26 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    Unchecked.defaultof<Async<unit>>
    #endif
    |> fun x -> _v20 <- Some x
    let v27 : Async<unit> = _v20.Value
    do! v27 
    let v28 : int64 = v1 + 1L
    let v29 : Async<int64> = method0(v0, v28)
    return! v29 
    (*
    let v30 : int64 = *)
    }
    |> fun x -> _v6 <- Some x
    let v31 : Async<int64> = _v6 |> Option.get
    v31 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v32 : Async<int64> = null |> unbox<Async<int64>>
    v32 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    Unchecked.defaultof<Async<int64>>
    #endif
    |> fun x -> _v2 <- Some x
    let v33 : Async<int64> = _v2.Value
    v33
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
    Unchecked.defaultof<Async<int64>>
    #endif
    |> fun x -> _v1 <- Some x
    let v8 : Async<int64> = _v1.Value
    v8
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
    Unchecked.defaultof<System.IO.FileStream>
    #endif
    |> fun x -> _v9 <- Some x
    let v32 : System.IO.FileStream = _v9.Value
    use v32 = v32 
    let v33 : System.IO.FileStream = v32 
    return v3 
    with ex ->
    let v34 : exn = ex
    let v35 : bool = v3 > 0L
    let v38 : bool =
        if v35 then
            let v36 : int64 = v3 % 100L
            let v37 : bool = v36 = 0L
            v37
        else
            false
    if v38 then
        let v39 : string option = None
        let mutable _v39 = v39
        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v40 : string = $"%A{v34}"
        v40 
        #endif
        #if FABLE_COMPILER_RUST && WASM
        let v41 : string = $"%A{v34}"
        v41 
        #endif
        #if FABLE_COMPILER_RUST && CONTRACT
        let v42 : string = $"%A{v34}"
        v42 
        #endif
        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
        let v43 : string = $"{v34.GetType ()}: {v34.Message}"
        v43 
        #endif
        #if FABLE_COMPILER_TYPESCRIPT
        let v44 : string = $"%A{v34}"
        v44 
        #endif
        #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
        Unchecked.defaultof<string>
        #endif
        |> fun x -> _v39 <- Some x
        let v45 : string = _v39.Value
        let v46 : (unit -> string) = closure6(v0, v3, v45)
        let v47 : string = $"wait_for_file_access / {v46 ()}"
        System.Console.WriteLine v47
        ()
    let v48 : Async<unit> option = None
    let mutable _v48 = v48
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
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v52 : (int32 -> Async<unit>) = Async.Sleep
    let v53 : Async<unit> = v52 10
    v53 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v54 : Async<unit> = null |> unbox<Async<unit>>
    v54 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    Unchecked.defaultof<Async<unit>>
    #endif
    |> fun x -> _v48 <- Some x
    let v55 : Async<unit> = _v48.Value
    do! v55 
    let v56 : int64 = v3 + 1L
    let v57 : Async<int64> = method2(v0, v1, v2, v56)
    return! v57 
    (*
    let v58 : int64 = *)
    }
    |> fun x -> _v8 <- Some x
    let v59 : Async<int64> = _v8 |> Option.get
    v59 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v60 : Async<int64> = null |> unbox<Async<int64>>
    v60 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    Unchecked.defaultof<Async<int64>>
    #endif
    |> fun x -> _v4 <- Some x
    let v61 : Async<int64> = _v4.Value
    v61
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
    Unchecked.defaultof<Async<int64>>
    #endif
    |> fun x -> _v2 <- Some x
    let v17 : Async<int64> = _v2.Value
    v17
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
    Unchecked.defaultof<System.IO.FileStream>
    #endif
    |> fun x -> _v7 <- Some x
    let v16 : System.IO.FileStream = _v7.Value
    use v16 = v16 
    let v17 : System.IO.FileStream = v16 
    return v1 
    with ex ->
    let v18 : exn = ex
    let v19 : bool = v1 > 0L
    let v22 : bool =
        if v19 then
            let v20 : int64 = v1 % 100L
            let v21 : bool = v20 = 0L
            v21
        else
            false
    if v22 then
        let v23 : string option = None
        let mutable _v23 = v23
        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v24 : string = $"%A{v18}"
        v24 
        #endif
        #if FABLE_COMPILER_RUST && WASM
        let v25 : string = $"%A{v18}"
        v25 
        #endif
        #if FABLE_COMPILER_RUST && CONTRACT
        let v26 : string = $"%A{v18}"
        v26 
        #endif
        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
        let v27 : string = $"{v18.GetType ()}: {v18.Message}"
        v27 
        #endif
        #if FABLE_COMPILER_TYPESCRIPT
        let v28 : string = $"%A{v18}"
        v28 
        #endif
        #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
        Unchecked.defaultof<string>
        #endif
        |> fun x -> _v23 <- Some x
        let v29 : string = _v23.Value
        let v30 : (unit -> string) = closure6(v0, v1, v29)
        let v31 : string = $"wait_for_file_access / {v30 ()}"
        System.Console.WriteLine v31
        ()
    let v32 : Async<unit> option = None
    let mutable _v32 = v32
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v33 : Async<unit> = null |> unbox<Async<unit>>
    v33 
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v34 : Async<unit> = null |> unbox<Async<unit>>
    v34 
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v35 : Async<unit> = null |> unbox<Async<unit>>
    v35 
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v36 : (int32 -> Async<unit>) = Async.Sleep
    let v37 : Async<unit> = v36 10
    v37 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v38 : Async<unit> = null |> unbox<Async<unit>>
    v38 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    Unchecked.defaultof<Async<unit>>
    #endif
    |> fun x -> _v32 <- Some x
    let v39 : Async<unit> = _v32.Value
    do! v39 
    let v40 : int64 = v1 + 1L
    let v41 : Async<int64> = method4(v0, v40)
    return! v41 
    (*
    let v42 : int64 = *)
    }
    |> fun x -> _v6 <- Some x
    let v43 : Async<int64> = _v6 |> Option.get
    v43 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v44 : Async<int64> = null |> unbox<Async<int64>>
    v44 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    Unchecked.defaultof<Async<int64>>
    #endif
    |> fun x -> _v2 <- Some x
    let v45 : Async<int64> = _v2.Value
    v45
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
    Unchecked.defaultof<Async<int64>>
    #endif
    |> fun x -> _v1 <- Some x
    let v8 : Async<int64> = _v1.Value
    v8
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
    Unchecked.defaultof<Async<string>>
    #endif
    |> fun x -> _v7 <- Some x
    let v14 : Async<string> = _v7.Value
    v14 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v15 : Async<string> = null |> unbox<Async<string>>
    v15 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    Unchecked.defaultof<Async<string>>
    #endif
    |> fun x -> _v1 <- Some x
    let v16 : Async<string> = _v1.Value
    v16
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
    Unchecked.defaultof<bool>
    #endif
    |> fun x -> _v11 <- Some x
    let v32 : bool = _v11.Value
    let v33 : bool = v32 = false
    if v33 then
        return false 
        (*
        ()
    else
        *) else
        let v34 : Async<string> option = None
        let mutable _v34 = v34
        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v35 : Async<string> = null |> unbox<Async<string>>
        v35 
        #endif
        #if FABLE_COMPILER_RUST && WASM
        let v36 : Async<string> = null |> unbox<Async<string>>
        v36 
        #endif
        #if FABLE_COMPILER_RUST && CONTRACT
        let v37 : Async<string> = null |> unbox<Async<string>>
        v37 
        #endif
        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
        let v38 : (string -> System.Threading.Tasks.Task<string>) = System.IO.File.ReadAllTextAsync
        let v39 : System.Threading.Tasks.Task<string> = v38 v0
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
        let v44 : (System.Threading.Tasks.Task<string> -> Async<string>) = Async.AwaitTask
        let v45 : Async<string> = v44 v39
        v45 
        #endif
        #if FABLE_COMPILER_TYPESCRIPT
        let v46 : Async<string> = null |> unbox<Async<string>>
        v46 
        #endif
        #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
        Unchecked.defaultof<Async<string>>
        #endif
        |> fun x -> _v40 <- Some x
        let v47 : Async<string> = _v40.Value
        v47 
        #endif
        #if FABLE_COMPILER_TYPESCRIPT
        let v48 : Async<string> = null |> unbox<Async<string>>
        v48 
        #endif
        #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
        Unchecked.defaultof<Async<string>>
        #endif
        |> fun x -> _v34 <- Some x
        let v49 : Async<string> = _v34.Value
        let! v49 = v49 
        let v50 : string = v49 
        let v51 : bool = v1 = v50
        return v51 
        (*
        ()
    *)
    }
    |> fun x -> _v10 <- Some x
    let v52 : Async<bool> = _v10 |> Option.get
    v52 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v53 : Async<bool> = null |> unbox<Async<bool>>
    v53 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    Unchecked.defaultof<Async<bool>>
    #endif
    |> fun x -> _v6 <- Some x
    let v54 : Async<bool> = _v6.Value
    v54 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v55 : Async<bool> = null |> unbox<Async<bool>>
    v55 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    Unchecked.defaultof<Async<bool>>
    #endif
    |> fun x -> _v2 <- Some x
    let v56 : Async<bool> = _v2.Value
    v56
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
    Unchecked.defaultof<Async<unit>>
    #endif
    |> fun x -> _v7 <- Some x
    let v14 : Async<unit> = _v7.Value
    v14 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v15 : Async<unit> = null |> unbox<Async<unit>>
    v15 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    Unchecked.defaultof<Async<unit>>
    #endif
    |> fun x -> _v2 <- Some x
    let v16 : Async<unit> = _v2.Value
    v16
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
    Unchecked.defaultof<bool>
    #endif
    |> fun x -> _v16 <- Some x
    let v37 : bool = _v16.Value
    let v38 : bool = v37 = false
    if v38 then
        return false 
        (*
        ()
    else
        *) else
        let v39 : Async<string> option = None
        let mutable _v39 = v39
        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v40 : Async<string> = null |> unbox<Async<string>>
        v40 
        #endif
        #if FABLE_COMPILER_RUST && WASM
        let v41 : Async<string> = null |> unbox<Async<string>>
        v41 
        #endif
        #if FABLE_COMPILER_RUST && CONTRACT
        let v42 : Async<string> = null |> unbox<Async<string>>
        v42 
        #endif
        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
        let v43 : (string -> System.Threading.Tasks.Task<string>) = System.IO.File.ReadAllTextAsync
        let v44 : System.Threading.Tasks.Task<string> = v43 v0
        let v45 : Async<string> option = None
        let mutable _v45 = v45
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
        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
        let v49 : (System.Threading.Tasks.Task<string> -> Async<string>) = Async.AwaitTask
        let v50 : Async<string> = v49 v44
        v50 
        #endif
        #if FABLE_COMPILER_TYPESCRIPT
        let v51 : Async<string> = null |> unbox<Async<string>>
        v51 
        #endif
        #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
        Unchecked.defaultof<Async<string>>
        #endif
        |> fun x -> _v45 <- Some x
        let v52 : Async<string> = _v45.Value
        v52 
        #endif
        #if FABLE_COMPILER_TYPESCRIPT
        let v53 : Async<string> = null |> unbox<Async<string>>
        v53 
        #endif
        #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
        Unchecked.defaultof<Async<string>>
        #endif
        |> fun x -> _v39 <- Some x
        let v54 : Async<string> = _v39.Value
        let! v54 = v54 
        let v55 : string = v54 
        let v56 : bool = v1 = v55
        return v56 
        (*
        ()
    *)
    }
    |> fun x -> _v15 <- Some x
    let v57 : Async<bool> = _v15 |> Option.get
    v57 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v58 : Async<bool> = null |> unbox<Async<bool>>
    v58 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    Unchecked.defaultof<Async<bool>>
    #endif
    |> fun x -> _v11 <- Some x
    let v59 : Async<bool> = _v11.Value
    v59 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v60 : Async<bool> = null |> unbox<Async<bool>>
    v60 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    Unchecked.defaultof<Async<bool>>
    #endif
    |> fun x -> _v7 <- Some x
    let v61 : Async<bool> = _v7.Value
    let! v61 = v61 
    let v62 : bool = v61 
    let v63 : bool = v62 = false
    if v63 then
        let v64 : Async<unit> option = None
        let mutable _v64 = v64
        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v65 : Async<unit> = null |> unbox<Async<unit>>
        v65 
        #endif
        #if FABLE_COMPILER_RUST && WASM
        let v66 : Async<unit> = null |> unbox<Async<unit>>
        v66 
        #endif
        #if FABLE_COMPILER_RUST && CONTRACT
        let v67 : Async<unit> = null |> unbox<Async<unit>>
        v67 
        #endif
        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
        let v68 : System.Threading.Tasks.Task = System.IO.File.WriteAllTextAsync (v0, v1)
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
        let v73 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
        let v74 : Async<unit> = v73 v68
        v74 
        #endif
        #if FABLE_COMPILER_TYPESCRIPT
        let v75 : Async<unit> = null |> unbox<Async<unit>>
        v75 
        #endif
        #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
        Unchecked.defaultof<Async<unit>>
        #endif
        |> fun x -> _v69 <- Some x
        let v76 : Async<unit> = _v69.Value
        v76 
        #endif
        #if FABLE_COMPILER_TYPESCRIPT
        let v77 : Async<unit> = null |> unbox<Async<unit>>
        v77 
        #endif
        #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
        Unchecked.defaultof<Async<unit>>
        #endif
        |> fun x -> _v64 <- Some x
        let v78 : Async<unit> = _v64.Value
        do! v78 
        ()
    }
    |> fun x -> _v6 <- Some x
    let v79 : Async<unit> = _v6 |> Option.get
    v79 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v80 : Async<unit> = null |> unbox<Async<unit>>
    v80 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    Unchecked.defaultof<Async<unit>>
    #endif
    |> fun x -> _v2 <- Some x
    let v81 : Async<unit> = _v2.Value
    v81
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
    Unchecked.defaultof<string>
    #endif
    |> fun x -> _v6 <- Some x
    let v12 : string = _v6.Value
    let v14 : bool = v12 = "Microsoft.DotNet.Interactive.App"
    let v15 : bool = v14 <> true
    let v21 : US4 =
        if v15 then
            let v16 : System.DateTime = System.DateTime.Now
            let v17 : (System.DateTime -> int64) = _.Ticks
            let v18 : int64 = v17 v16
            US4_0(v18)
        else
            US4_1
    let v26 : int64 option =
        match v21 with
        | US4_1 -> (* None *)
            let v24 : int64 option = None
            v24
        | US4_0(v22) -> (* Some *)
            let v23 : int64 option = Some v22 
            v23
    let v27 : int64 option = method8(v26)
    v27 
    #else
    let v28 : int64 option = None
    let v29 : int64 option = method9(v28)
    v29 
    #endif
    |> fun x -> _v5 <- Some x
    let v30 : int64 option = _v5.Value
    struct (v1, v4, v0, v3, v30)
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
    Unchecked.defaultof<string>
    #endif
    |> fun x -> _v9 <- Some x
    let v59 : string = _v9.Value
    let v60 : int64 = v4.l0
    let v70 : string =
        match v0 with
        | US3_4 -> (* Critical *)
            let v65 : string = "Critical"
            v65
        | US3_1 -> (* Debug *)
            let v62 : string = "Debug"
            v62
        | US3_2 -> (* Info *)
            let v63 : string = "Info"
            v63
        | US3_0 -> (* Verbose *)
            let v61 : string = "Verbose"
            v61
        | US3_3 -> (* Warning *)
            let v64 : string = "Warning"
            v64
    let v71 : string = v70.ToLower ()
    let v72 : string = $"{v59} #{v60} [{v71}] %s{v1 ()} / %s{v2 ()}"
    let v73 : (char []) = [||]
    let v74 : string = v72.TrimStart v73
    let v75 : (char []) = [|' '; '/'|]
    let v76 : string = v74.TrimEnd v75
    v76
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
        Unchecked.defaultof<string>
        #endif
        |> fun x -> _v12 <- Some x
        let v18 : string = _v12.Value
        let v19 : US3 = US3_3
        let v20 : (unit -> string) = closure16()
        let v21 : (unit -> string) = closure3()
        method7(v19, v20, v21)
    let v22 : Async<unit> option = None
    let mutable _v22 = v22
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v23 : Async<unit> = null |> unbox<Async<unit>>
    v23 
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v24 : Async<unit> = null |> unbox<Async<unit>>
    v24 
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v25 : Async<unit> = null |> unbox<Async<unit>>
    v25 
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v26 : (int32 -> Async<unit>) = Async.Sleep
    let v27 : Async<unit> = v26 10
    v27 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v28 : Async<unit> = null |> unbox<Async<unit>>
    v28 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    Unchecked.defaultof<Async<unit>>
    #endif
    |> fun x -> _v22 <- Some x
    let v29 : Async<unit> = _v22.Value
    do! v29 
    let v30 : int64 = v1 + 1L
    let v31 : Async<int64> = method6(v0, v30)
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
    Unchecked.defaultof<Async<int64>>
    #endif
    |> fun x -> _v2 <- Some x
    let v35 : Async<int64> = _v2.Value
    v35
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
    Unchecked.defaultof<Async<int64>>
    #endif
    |> fun x -> _v1 <- Some x
    let v8 : Async<int64> = _v1.Value
    v8
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
    Unchecked.defaultof<string>
    #endif
    |> fun x -> _v3 <- Some x
    let v9 : string = _v3.Value
    let v10 : (string -> string) = closure2()
    let v11 : (unit -> string) = closure3()
    let v12 : string = $"old_path: {v1 |> v10} / new_path: {v0 |> v10} / ex: {v9} / {v11 ()}"
    v12
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
    Unchecked.defaultof<Async<unit>>
    #endif
    |> fun x -> _v15 <- Some x
    let v22 : Async<unit> = _v15.Value
    do! v22 
    let v23 : int64 = v2 + 1L
    let v24 : Async<int64> = method12(v0, v1, v23)
    return! v24 
    (*
    *)
    }
    |> fun x -> _v7 <- Some x
    let v25 : Async<int64> = _v7 |> Option.get
    v25 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v26 : Async<int64> = null |> unbox<Async<int64>>
    v26 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    Unchecked.defaultof<Async<int64>>
    #endif
    |> fun x -> _v3 <- Some x
    let v27 : Async<int64> = _v3.Value
    v27
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
    Unchecked.defaultof<Async<int64>>
    #endif
    |> fun x -> _v2 <- Some x
    let v9 : Async<int64> = _v2.Value
    v9
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
        Unchecked.defaultof<Async<int64>>
        #endif
        |> fun x -> _v8 <- Some x
        let v15 : Async<int64> = _v8.Value
        let v16 : Async<US5> option = None
        let mutable _v16 = v16
        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v17 : Async<US5> = null |> unbox<Async<US5>>
        v17 
        #endif
        #if FABLE_COMPILER_RUST && WASM
        let v18 : Async<US5> = null |> unbox<Async<US5>>
        v18 
        #endif
        #if FABLE_COMPILER_RUST && CONTRACT
        let v19 : Async<US5> = null |> unbox<Async<US5>>
        v19 
        #endif
        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
        let v20 : Async<US5> option = None
        let mutable _v20 = v20
        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v21 : Async<US5> = null |> unbox<Async<US5>>
        v21 
        #endif
        #if FABLE_COMPILER_RUST && WASM
        let v22 : Async<US5> = null |> unbox<Async<US5>>
        v22 
        #endif
        #if FABLE_COMPILER_RUST && CONTRACT
        let v23 : Async<US5> = null |> unbox<Async<US5>>
        v23 
        #endif
        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
        let v24 : Async<US5> option = None
        let mutable _v24 = v24
        async {
        let v25 : Async<Async<int64>> option = None
        let mutable _v25 = v25
        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v26 : Async<Async<int64>> = null |> unbox<Async<Async<int64>>>
        v26 
        #endif
        #if FABLE_COMPILER_RUST && WASM
        let v27 : Async<Async<int64>> = null |> unbox<Async<Async<int64>>>
        v27 
        #endif
        #if FABLE_COMPILER_RUST && CONTRACT
        let v28 : Async<Async<int64>> = null |> unbox<Async<Async<int64>>>
        v28 
        #endif
        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
        let v29 : Async<Async<int64>> = Async.StartChild (v15, 1000)
        v29 
        #endif
        #if FABLE_COMPILER_TYPESCRIPT
        let v30 : Async<Async<int64>> = null |> unbox<Async<Async<int64>>>
        v30 
        #endif
        #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
        Unchecked.defaultof<Async<Async<int64>>>
        #endif
        |> fun x -> _v25 <- Some x
        let v31 : Async<Async<int64>> = _v25.Value
        let! v31 = v31 
        let v32 : Async<int64> = v31 
        let v33 : Async<Choice<int64, exn>> option = None
        let mutable _v33 = v33
        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v34 : Async<Choice<int64, exn>> = null |> unbox<Async<Choice<int64, exn>>>
        v34 
        #endif
        #if FABLE_COMPILER_RUST && WASM
        let v35 : Async<Choice<int64, exn>> = null |> unbox<Async<Choice<int64, exn>>>
        v35 
        #endif
        #if FABLE_COMPILER_RUST && CONTRACT
        let v36 : Async<Choice<int64, exn>> = null |> unbox<Async<Choice<int64, exn>>>
        v36 
        #endif
        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
        let v37 : (Async<int64> -> Async<Choice<int64, exn>>) = Async.Catch
        let v38 : Async<Choice<int64, exn>> = v37 v32
        v38 
        #endif
        #if FABLE_COMPILER_TYPESCRIPT
        let v39 : Async<Choice<int64, exn>> = null |> unbox<Async<Choice<int64, exn>>>
        v39 
        #endif
        #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
        Unchecked.defaultof<Async<Choice<int64, exn>>>
        #endif
        |> fun x -> _v33 <- Some x
        let v40 : Async<Choice<int64, exn>> = _v33.Value
        let v41 : Async<US6> option = None
        let mutable _v41 = v41
        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v42 : Async<US6> = null |> unbox<Async<US6>>
        v42 
        #endif
        #if FABLE_COMPILER_RUST && WASM
        let v43 : Async<US6> = null |> unbox<Async<US6>>
        v43 
        #endif
        #if FABLE_COMPILER_RUST && CONTRACT
        let v44 : Async<US6> = null |> unbox<Async<US6>>
        v44 
        #endif
        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
        let v45 : Async<US6> option = None
        let mutable _v45 = v45
        async {
        let! v40 = v40 
        let v46 : Choice<int64, exn> = v40 
        let v47 : US6 option = None
        let mutable _v47 = v47
        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v48 : US6 = null |> unbox<US6>
        v48 
        #endif
        #if FABLE_COMPILER_RUST && WASM
        let v49 : US6 = null |> unbox<US6>
        v49 
        #endif
        #if FABLE_COMPILER_RUST && CONTRACT
        let v50 : US6 = null |> unbox<US6>
        v50 
        #endif
        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
        let v51 : (int64 -> US6) = closure25()
        let v52 : (exn -> US6) = closure26()
        let v53 : US6 = match v46 with Choice1Of2 x -> v51 x | Choice2Of2 x -> v52 x
        v53 
        #endif
        #if FABLE_COMPILER_TYPESCRIPT
        let v54 : US6 = null |> unbox<US6>
        v54 
        #endif
        #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
        Unchecked.defaultof<US6>
        #endif
        |> fun x -> _v47 <- Some x
        let v55 : US6 = _v47.Value
        return v55 
        }
        |> fun x -> _v45 <- Some x
        let v56 : Async<US6> = _v45 |> Option.get
        v56 
        #endif
        #if FABLE_COMPILER_TYPESCRIPT
        let v57 : Async<US6> = null |> unbox<Async<US6>>
        v57 
        #endif
        #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
        Unchecked.defaultof<Async<US6>>
        #endif
        |> fun x -> _v41 <- Some x
        let v58 : Async<US6> = _v41.Value
        let v59 : Async<US7> option = None
        let mutable _v59 = v59
        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v60 : Async<US7> = null |> unbox<Async<US7>>
        v60 
        #endif
        #if FABLE_COMPILER_RUST && WASM
        let v61 : Async<US7> = null |> unbox<Async<US7>>
        v61 
        #endif
        #if FABLE_COMPILER_RUST && CONTRACT
        let v62 : Async<US7> = null |> unbox<Async<US7>>
        v62 
        #endif
        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
        let v63 : Async<US7> option = None
        let mutable _v63 = v63
        async {
        let! v58 = v58 
        let v64 : US6 = v58 
        let v70 : US7 =
            match v64 with
            | US6_0(v65) -> (* Choice1Of2 *)
                US7_0(v65)
            | US6_1(v67) -> (* Choice2Of2 *)
                US7_1(v67)
        return v70 
        }
        |> fun x -> _v63 <- Some x
        let v71 : Async<US7> = _v63 |> Option.get
        v71 
        #endif
        #if FABLE_COMPILER_TYPESCRIPT
        let v72 : Async<US7> = null |> unbox<Async<US7>>
        v72 
        #endif
        #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
        Unchecked.defaultof<Async<US7>>
        #endif
        |> fun x -> _v59 <- Some x
        let v73 : Async<US7> = _v59.Value
        let v74 : Async<US5> option = None
        let mutable _v74 = v74
        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v75 : Async<US5> = null |> unbox<Async<US5>>
        v75 
        #endif
        #if FABLE_COMPILER_RUST && WASM
        let v76 : Async<US5> = null |> unbox<Async<US5>>
        v76 
        #endif
        #if FABLE_COMPILER_RUST && CONTRACT
        let v77 : Async<US5> = null |> unbox<Async<US5>>
        v77 
        #endif
        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
        let v78 : Async<US5> option = None
        let mutable _v78 = v78
        async {
        let! v73 = v73 
        let v79 : US7 = v73 
        let v103 : US5 =
            match v79 with
            | US7_1(v82) -> (* Error *)
                let v83 : string = $"%A{v82}"
                let v84 : string = "System.TimeoutException"
                let v85 : bool = v83.Contains v84
                if v85 then
                    let v86 : US3 = US3_1
                    let v87 : (unit -> string) = closure27()
                    let v88 : (unit -> string) = closure28()
                    method7(v86, v87, v88)
                    US5_1
                else
                    let v90 : string option = None
                    let mutable _v90 = v90
                    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v91 : string = $"%A{v82}"
                    v91 
                    #endif
                    #if FABLE_COMPILER_RUST && WASM
                    let v92 : string = $"%A{v82}"
                    v92 
                    #endif
                    #if FABLE_COMPILER_RUST && CONTRACT
                    let v93 : string = $"%A{v82}"
                    v93 
                    #endif
                    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                    let v94 : string = $"{v82.GetType ()}: {v82.Message}"
                    v94 
                    #endif
                    #if FABLE_COMPILER_TYPESCRIPT
                    let v95 : string = $"%A{v82}"
                    v95 
                    #endif
                    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
                    Unchecked.defaultof<string>
                    #endif
                    |> fun x -> _v90 <- Some x
                    let v96 : string = _v90.Value
                    let v97 : US3 = US3_4
                    let v98 : (unit -> string) = closure29(v96)
                    let v99 : (unit -> string) = closure28()
                    method7(v97, v98, v99)
                    US5_1
            | US7_0(v80) -> (* Ok *)
                US5_0(v80)
        return v103 
        }
        |> fun x -> _v78 <- Some x
        let v104 : Async<US5> = _v78 |> Option.get
        v104 
        #endif
        #if FABLE_COMPILER_TYPESCRIPT
        let v105 : Async<US5> = null |> unbox<Async<US5>>
        v105 
        #endif
        #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
        Unchecked.defaultof<Async<US5>>
        #endif
        |> fun x -> _v74 <- Some x
        let v106 : Async<US5> = _v74.Value
        return! v106 
        }
        |> fun x -> _v24 <- Some x
        let v107 : Async<US5> = _v24 |> Option.get
        v107 
        #endif
        #if FABLE_COMPILER_TYPESCRIPT
        let v108 : Async<US5> = null |> unbox<Async<US5>>
        v108 
        #endif
        #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
        Unchecked.defaultof<Async<US5>>
        #endif
        |> fun x -> _v20 <- Some x
        let v109 : Async<US5> = _v20.Value
        v109 
        #endif
        #if FABLE_COMPILER_TYPESCRIPT
        let v110 : Async<US5> = null |> unbox<Async<US5>>
        v110 
        #endif
        #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
        Unchecked.defaultof<Async<US5>>
        #endif
        |> fun x -> _v16 <- Some x
        let v111 : Async<US5> = _v16.Value
        let v112 : Async<unit> option = None
        let mutable _v112 = v112
        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v113 : Async<unit> = null |> unbox<Async<unit>>
        v113 
        #endif
        #if FABLE_COMPILER_RUST && WASM
        let v114 : Async<unit> = null |> unbox<Async<unit>>
        v114 
        #endif
        #if FABLE_COMPILER_RUST && CONTRACT
        let v115 : Async<unit> = null |> unbox<Async<unit>>
        v115 
        #endif
        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
        let v116 : (Async<US5> -> Async<unit>) = Async.Ignore
        let v117 : Async<unit> = v116 v111
        v117 
        #endif
        #if FABLE_COMPILER_TYPESCRIPT
        let v118 : Async<unit> = null |> unbox<Async<unit>>
        v118 
        #endif
        #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
        Unchecked.defaultof<Async<unit>>
        #endif
        |> fun x -> _v112 <- Some x
        let v119 : Async<unit> = _v112.Value
        do! v119 
        ()
    let v120 : Async<string> option = None
    let mutable _v120 = v120
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v121 : Async<string> = null |> unbox<Async<string>>
    v121 
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v122 : Async<string> = null |> unbox<Async<string>>
    v122 
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v123 : Async<string> = null |> unbox<Async<string>>
    v123 
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v124 : (string -> System.Threading.Tasks.Task<string>) = System.IO.File.ReadAllTextAsync
    let v125 : System.Threading.Tasks.Task<string> = v124 v0
    let v126 : Async<string> option = None
    let mutable _v126 = v126
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v127 : Async<string> = null |> unbox<Async<string>>
    v127 
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v128 : Async<string> = null |> unbox<Async<string>>
    v128 
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v129 : Async<string> = null |> unbox<Async<string>>
    v129 
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v130 : (System.Threading.Tasks.Task<string> -> Async<string>) = Async.AwaitTask
    let v131 : Async<string> = v130 v125
    v131 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v132 : Async<string> = null |> unbox<Async<string>>
    v132 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    Unchecked.defaultof<Async<string>>
    #endif
    |> fun x -> _v126 <- Some x
    let v133 : Async<string> = _v126.Value
    v133 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v134 : Async<string> = null |> unbox<Async<string>>
    v134 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    Unchecked.defaultof<Async<string>>
    #endif
    |> fun x -> _v120 <- Some x
    let v135 : Async<string> = _v120.Value
    let v136 : Async<string option> option = None
    let mutable _v136 = v136
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v137 : Async<string option> = null |> unbox<Async<string option>>
    v137 
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v138 : Async<string option> = null |> unbox<Async<string option>>
    v138 
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v139 : Async<string option> = null |> unbox<Async<string option>>
    v139 
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v140 : Async<string option> option = None
    let mutable _v140 = v140
    async {
    let! v135 = v135 
    let v141 : string = v135 
    let v142 : string option = Some v141 
    return v142 
    }
    |> fun x -> _v140 <- Some x
    let v143 : Async<string option> = _v140 |> Option.get
    v143 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v144 : Async<string option> = null |> unbox<Async<string option>>
    v144 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    Unchecked.defaultof<Async<string option>>
    #endif
    |> fun x -> _v136 <- Some x
    let v145 : Async<string option> = _v136.Value
    return! v145 
    with ex ->
    let v146 : exn = ex
    let v147 : bool = v1 = 0L
    let v148 : bool = v147 <> true
    if v148 then
        let v149 : string option = None
        let mutable _v149 = v149
        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v150 : string = $"%A{v146}"
        v150 
        #endif
        #if FABLE_COMPILER_RUST && WASM
        let v151 : string = $"%A{v146}"
        v151 
        #endif
        #if FABLE_COMPILER_RUST && CONTRACT
        let v152 : string = $"%A{v146}"
        v152 
        #endif
        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
        let v153 : string = $"{v146.GetType ()}: {v146.Message}"
        v153 
        #endif
        #if FABLE_COMPILER_TYPESCRIPT
        let v154 : string = $"%A{v146}"
        v154 
        #endif
        #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
        Unchecked.defaultof<string>
        #endif
        |> fun x -> _v149 <- Some x
        let v155 : string = _v149.Value
        let v156 : US3 = US3_1
        let v157 : (unit -> string) = closure30()
        let v158 : (unit -> string) = closure31(v1, v155)
        method7(v156, v157, v158)
        let v159 : string option = None
        return v159 
        (*
        ()
    else
        *) else
        let v160 : int64 = v1 + 1L
        let v161 : Async<string option> = method14(v0, v160)
        return! v161 
        (*
        ()
    *)
    (*
    let v162 : string option = *)
    }
    |> fun x -> _v6 <- Some x
    let v163 : Async<string option> = _v6 |> Option.get
    v163 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v164 : Async<string option> = null |> unbox<Async<string option>>
    v164 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    Unchecked.defaultof<Async<string option>>
    #endif
    |> fun x -> _v2 <- Some x
    let v165 : Async<string option> = _v2.Value
    v165
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
    Unchecked.defaultof<Async<string option>>
    #endif
    |> fun x -> _v1 <- Some x
    let v8 : Async<string option> = _v1.Value
    v8
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
    Unchecked.defaultof<string>
    #endif
    |> fun x -> _v0 <- Some x
    let v6 : string = _v0.Value
    v6
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
    Unchecked.defaultof<string>
    #endif
    |> fun x -> _v8 <- Some x
    let v34 : string = _v8.Value
    let v35 : System.DateTime = System.DateTime.Now
    let v36 : System.Guid = System.Guid.NewGuid ()
    let v37 : (System.Guid -> string) = _.ToString()
    let v38 : string = v37 v36
    let v39 : string = v35.ToString "yyyyMMdd-HHmm-ssff-ffff-f"
    let v40 : System.Guid = System.Guid $"{v39}{v38.[v39.Length..]}"
    let v41 : (System.Guid -> string) = _.ToString()
    let v42 : string = v41 v40
    let v43 : string option = None
    let mutable _v43 = v43
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v44 : string = method5(v34)
    let v45 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v46 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v44 v45
    let v47 : string = "String::from($0)"
    let v48 : std_string_String = Fable.Core.RustInterop.emitRustExpr v46 v47
    let v49 : string = "std::path::PathBuf::from($0)"
    let v50 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v48 v49
    let v51 : string = method5(v42)
    let v52 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v53 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v51 v52
    let v54 : string = "String::from($0)"
    let v55 : std_string_String = Fable.Core.RustInterop.emitRustExpr v53 v54
    let v56 : string = "$0.join($1)"
    let v57 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr struct (v50, v55) v56
    let v58 : string = "$0.display().to_string()"
    let v59 : std_string_String = Fable.Core.RustInterop.emitRustExpr v57 v58
    let v60 : string = "fable_library_rust::String_::fromString($0)"
    let v61 : string = Fable.Core.RustInterop.emitRustExpr v59 v60
    v61 
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v62 : string = null |> unbox<string>
    v62 
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v63 : string = null |> unbox<string>
    v63 
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v64 : string = System.IO.Path.Combine (v34, v42)
    v64 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v65 : IPathJoin = Fable.Core.JsInterop.importAll v30
    let v66 : string = "v65.join($0, $1)"
    let v67 : string = Fable.Core.JsInterop.emitJsExpr struct (v34, v42) v66
    v67 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    Unchecked.defaultof<string>
    #endif
    |> fun x -> _v43 <- Some x
    let v68 : string = _v43.Value
    v68 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v69 : string = null |> unbox<string>
    v69 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    Unchecked.defaultof<string>
    #endif
    |> fun x -> _v0 <- Some x
    let v70 : string = _v0.Value
    v70
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
    Unchecked.defaultof<Async<int64>>
    #endif
    |> fun x -> _v1 <- Some x
    let v8 : Async<int64> = _v1.Value
    let v9 : Async<unit> option = None
    let mutable _v9 = v9
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
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v13 : (Async<int64> -> Async<unit>) = Async.Ignore
    let v14 : Async<unit> = v13 v8
    v14 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v15 : Async<unit> = null |> unbox<Async<unit>>
    v15 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    Unchecked.defaultof<Async<unit>>
    #endif
    |> fun x -> _v9 <- Some x
    let v16 : Async<unit> = _v9.Value
    let v17 : unit option = None
    let mutable _v17 = v17
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
    let v18 : (Async<unit> -> unit) = Async.RunSynchronously
    v18 v16
    () 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    null |> unbox<unit>
    () 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    Unchecked.defaultof<unit>
    #endif
    |> fun x -> _v17 <- Some x
    _v17.Value
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
    Unchecked.defaultof<string>
    #endif
    |> fun x -> _v15 <- Some x
    let v41 : string = _v15.Value
    let v42 : System.DateTime = System.DateTime.Now
    let v43 : System.Guid = System.Guid.NewGuid ()
    let v44 : (System.Guid -> string) = _.ToString()
    let v45 : string = v44 v43
    let v46 : string = v42.ToString "yyyyMMdd-HHmm-ssff-ffff-f"
    let v47 : System.Guid = System.Guid $"{v46}{v45.[v46.Length..]}"
    let v48 : (System.Guid -> string) = _.ToString()
    let v49 : string = v48 v47
    let v50 : string option = None
    let mutable _v50 = v50
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v51 : string = method5(v41)
    let v52 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v53 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v51 v52
    let v54 : string = "String::from($0)"
    let v55 : std_string_String = Fable.Core.RustInterop.emitRustExpr v53 v54
    let v56 : string = "std::path::PathBuf::from($0)"
    let v57 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v55 v56
    let v58 : string = method5(v49)
    let v59 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v60 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v58 v59
    let v61 : string = "String::from($0)"
    let v62 : std_string_String = Fable.Core.RustInterop.emitRustExpr v60 v61
    let v63 : string = "$0.join($1)"
    let v64 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr struct (v57, v62) v63
    let v65 : string = "$0.display().to_string()"
    let v66 : std_string_String = Fable.Core.RustInterop.emitRustExpr v64 v65
    let v67 : string = "fable_library_rust::String_::fromString($0)"
    let v68 : string = Fable.Core.RustInterop.emitRustExpr v66 v67
    v68 
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v69 : string = null |> unbox<string>
    v69 
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v70 : string = null |> unbox<string>
    v70 
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v71 : string = System.IO.Path.Combine (v41, v49)
    v71 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v72 : IPathJoin = Fable.Core.JsInterop.importAll v37
    let v73 : string = "v72.join($0, $1)"
    let v74 : string = Fable.Core.JsInterop.emitJsExpr struct (v41, v49) v73
    v74 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    Unchecked.defaultof<string>
    #endif
    |> fun x -> _v50 <- Some x
    let v75 : string = _v50.Value
    v75 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v76 : string = null |> unbox<string>
    v76 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    Unchecked.defaultof<string>
    #endif
    |> fun x -> _v7 <- Some x
    let v77 : string = _v7.Value
    let v78 : System.IO.DirectoryInfo option = None
    let mutable _v78 = v78
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v79 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    v79 
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v80 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    v80 
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v81 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    v81 
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v82 : (string -> System.IO.DirectoryInfo) = System.IO.Directory.CreateDirectory
    let v83 : System.IO.DirectoryInfo = v82 v77
    v83 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v84 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    v84 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    Unchecked.defaultof<System.IO.DirectoryInfo>
    #endif
    |> fun x -> _v78 <- Some x
    let v85 : System.IO.DirectoryInfo = _v78.Value
    let v86 : bool option = None
    let mutable _v86 = v86
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v87 : bool = null |> unbox<bool>
    v87 
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v88 : bool = null |> unbox<bool>
    v88 
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v89 : bool = null |> unbox<bool>
    v89 
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v90 : bool = v85.Exists
    v90 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v91 : bool = null |> unbox<bool>
    v91 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    Unchecked.defaultof<bool>
    #endif
    |> fun x -> _v86 <- Some x
    let v92 : bool = _v86.Value
    let v93 : bool = v92 = false
    if v93 then
        let v94 : System.DateTime option = None
        let mutable _v94 = v94
        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v95 : System.DateTime = null |> unbox<System.DateTime>
        v95 
        #endif
        #if FABLE_COMPILER_RUST && WASM
        let v96 : System.DateTime = null |> unbox<System.DateTime>
        v96 
        #endif
        #if FABLE_COMPILER_RUST && CONTRACT
        let v97 : System.DateTime = null |> unbox<System.DateTime>
        v97 
        #endif
        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
        let v98 : System.DateTime = v85.CreationTime
        v98 
        #endif
        #if FABLE_COMPILER_TYPESCRIPT
        let v99 : System.DateTime = null |> unbox<System.DateTime>
        v99 
        #endif
        #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
        Unchecked.defaultof<System.DateTime>
        #endif
        |> fun x -> _v94 <- Some x
        let v100 : System.DateTime = _v94.Value
        let v101 : obj = {| Exists = v92; CreationTime = v100 |}
        let v102 : string = $"%A{v101}"
        let v103 : (unit -> string) = closure35(v77, v102)
        let v104 : string = $"create_temp_directory / {v103 ()}"
        System.Console.WriteLine v104
        ()
    let v105 : System.IDisposable option = None
    let mutable _v105 = v105
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v106 : System.IDisposable = null |> unbox<System.IDisposable>
    v106 
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v107 : System.IDisposable = null |> unbox<System.IDisposable>
    v107 
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v108 : System.IDisposable = null |> unbox<System.IDisposable>
    v108 
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v109 : (unit -> unit) = closure36(v77)
    let v110 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v109 () }
    v110 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v111 : System.IDisposable = null |> unbox<System.IDisposable>
    v111 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    Unchecked.defaultof<System.IDisposable>
    #endif
    |> fun x -> _v105 <- Some x
    let v112 : System.IDisposable = _v105.Value
    struct (v77, v112) 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let struct (v113 : string, v114 : System.IDisposable) = null |> unbox<struct (string * System.IDisposable)>
    struct (v113, v114) 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    Unchecked.defaultof<struct (string * System.IDisposable)>
    #endif
    |> fun x -> _v0 <- Some x
    let struct (v115 : string, v116 : System.IDisposable) = _v0.Value
    struct (v115, v116)
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
    Unchecked.defaultof<bool>
    #endif
    |> fun x -> _v1 <- Some x
    let v22 : bool = _v1.Value
    v22
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
    Unchecked.defaultof<bool>
    #endif
    |> fun x -> _v1 <- Some x
    let v22 : bool = _v1.Value
    v22
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
    let v33 : US8 =
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
            Unchecked.defaultof<string>
            #endif
            |> fun x -> _v25 <- Some x
            let v31 : string = _v25.Value
            US8_0(v31)
    v33 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v34 : string = "path"
    let v35 : IPathDirname = Fable.Core.JsInterop.importAll v34
    let v36 : string = "v35.dirname($0)"
    let v37 : string = Fable.Core.JsInterop.emitJsExpr v0 v36
    let v38 : US8 = US8_0(v37)
    v38 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    Unchecked.defaultof<US8>
    #endif
    |> fun x -> _v1 <- Some x
    let v39 : US8 = _v1.Value
    match v39 with
    | US8_1 -> (* None *)
        let v42 : string option = None
        v42
    | US8_0(v40) -> (* Some *)
        let v41 : string option = Some v40 
        v41
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
    Unchecked.defaultof<string>
    #endif
    |> fun x -> _v4 <- Some x
    let v30 : string = _v4.Value
    let v33 : (string -> bool) =
        if v1 then
            closure41()
        else
            closure42()
    let v34 : bool = v33 v30
    if v34 then
        v3
    else
        let v35 : (string -> string option) = method17()
        let v36 : string option = v35 v3
        let v37 : (string -> US8) = method18()
        let v38 : US8 = US8_1
        let v39 : US8 = v36 |> Option.map v37 |> Option.defaultValue v38 
        match v39 with
        | US8_1 -> (* None *)
            let v42 : string = $"""No parent for {if v1 then "file" else "dir"} '{v0}' at '{v2}'"""
            failwith<string> v42
        | US8_0(v40) -> (* Some *)
            method19(v0, v1, v2, v40)
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
    Unchecked.defaultof<string>
    #endif
    |> fun x -> _v3 <- Some x
    let v29 : string = _v3.Value
    let v32 : (string -> bool) =
        if v1 then
            closure41()
        else
            closure42()
    let v33 : bool = v32 v29
    if v33 then
        v2
    else
        let v34 : (string -> string option) = method17()
        let v35 : string option = v34 v2
        let v36 : (string -> US8) = method18()
        let v37 : US8 = US8_1
        let v38 : US8 = v35 |> Option.map v36 |> Option.defaultValue v37 
        match v38 with
        | US8_1 -> (* None *)
            let v41 : string = $"""No parent for {if v1 then "file" else "dir"} '{v0}' at '{v2}'"""
            failwith<string> v41
        | US8_0(v39) -> (* Some *)
            method19(v0, v1, v2, v39)
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
    Unchecked.defaultof<string>
    #endif
    |> fun x -> _v2 <- Some x
    let v28 : string = _v2.Value
    v28
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
