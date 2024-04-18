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
[<Fable.Core.Erase; Fable.Core.Emit("std::io::Error")>] type std_io_Error = class end
[<Fable.Core.Erase; Fable.Core.Emit("std::path::Path")>] type std_path_Path = class end
[<Fable.Core.Erase; Fable.Core.Emit("std::path::PathBuf")>] type std_path_PathBuf = class end
[<Fable.Core.Erase; Fable.Core.Emit("async_walkdir::DirEntry")>] type async_walkdir_DirEntry = class end
[<Fable.Core.Erase; Fable.Core.Emit("async_walkdir::WalkDir")>] type async_walkdir_WalkDir = class end
#endif // file_system.types
module State = let mutable trace_state = None
type IFsExistsSync = abstract existsSync: path: string -> bool
type IPathJoin = abstract join: [<System.ParamArray>] paths: string[] -> string
type IPathDirname = abstract dirname: path: string -> string
type Mut0 = {mutable l0 : int64}
and Mut1 = {mutable l0 : bool}
and [<Struct>] US0 =
    | US0_0
    | US0_1
    | US0_2
    | US0_3
    | US0_4
and Mut2 = {mutable l0 : US0}
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
let rec method0 (v0 : int64 option) : int64 option =
    v0
and method1 (v0 : int64 option) : int64 option =
    v0
and closure0 () () : struct (Mut0 * Mut1 * Mut1 * Mut2 * int64 option) =
    let v0 : Mut1 = {l0 = true} : Mut1
    let v1 : Mut0 = {l0 = 0L} : Mut0
    let v2 : US0 = US0_0
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
    let v23 : US1 =
        if v17 then
            let v18 : System.DateTime = System.DateTime.Now
            let v19 : (System.DateTime -> int64) = _.Ticks
            let v20 : int64 = v19 v18
            US1_0(v20)
        else
            US1_1
    let v28 : int64 option =
        match v23 with
        | US1_1 -> (* None *)
            let v26 : int64 option = None
            v26
        | US1_0(v24) -> (* Some *)
            let v25 : int64 option = Some v24 
            v25
    let v29 : int64 option = method0(v28)
    v29 
    #else
    let v30 : int64 option = None
    let v31 : int64 option = method1(v30)
    v31 
    #endif
    |> fun x -> _v5 <- Some x
    let v32 : int64 option = _v5.Value
    struct (v1, v4, v0, v3, v32)
and closure3 () (v0 : string) : string =
    let v1 : string option = None
    let v2 : bool = true in let mutable _v1 = v1
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : string = null |> unbox<string>
    v3
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v4 : string = null |> unbox<string>
    v4
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v5 : string = null |> unbox<string>
    v5
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v6 : (string -> string) = System.IO.Path.GetFileName
    let v7 : string = v6 v0
    v7
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v8 : string = null |> unbox<string>
    v8
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v9 : string = Unchecked.defaultof<string>
    v9
#endif
    |> fun x -> _v1 <- Some x
    let v10 : string = _v1.Value
    v10
and closure4 () () : string =
    let v0 : string = ""
    v0
and method3 (v0 : string, v1 : string) : string =
    let v2 : (string -> string) = closure3()
    let v3 : (unit -> string) = closure4()
    let v4 : string = $"path: {v0 |> v2} / ex: {v1} / {v3 ()}"
    v4
and closure2 (v0 : string, v1 : string) () : string =
    method3(v0, v1)
and method2 (v0 : string, v1 : int64) : Async<int64> =
    let v2 : Async<int64> option = None
    let v3 : bool = true in let mutable _v2 = v2
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
    let v9 : bool = true in let mutable _v8 = v8
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
    |> fun x -> _v8 <- Some x
    _v8.Value
    return v1 
    with ex ->
    let v10 : exn = ex
    let v11 : int64 = v1 % 100L
    let v12 : bool = v11 = 0L
    if v12 then
        let v13 : string option = None
        let v14 : bool = true in let mutable _v13 = v13
        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v15 : string = $"%A{v10}"
        v15
#endif
        #if FABLE_COMPILER_RUST && WASM
        let v16 : string = $"%A{v10}"
        v16
#endif
        #if FABLE_COMPILER_RUST && CONTRACT
        let v17 : string = $"%A{v10}"
        v17
#endif
        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
        let v18 : string = $"{v10.GetType ()}: {v10.Message}"
        v18
#endif
        #if FABLE_COMPILER_TYPESCRIPT
        let v19 : string = $"%A{v10}"
        v19
#endif
        #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
        let v20 : string = Unchecked.defaultof<string>
        v20
#endif
        |> fun x -> _v13 <- Some x
        let v21 : string = _v13.Value
        let v22 : (unit -> string) = closure2(v0, v21)
        let v23 : string = $"delete_directory_async / {v22 ()}"
        System.Console.WriteLine v23
        ()
    let v24 : Async<unit> option = None
    let v25 : bool = true in let mutable _v24 = v24
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v26 : Async<unit> = null |> unbox<Async<unit>>
    v26
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v27 : Async<unit> = null |> unbox<Async<unit>>
    v27
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v28 : Async<unit> = null |> unbox<Async<unit>>
    v28
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v29 : (int32 -> Async<unit>) = Async.Sleep
    let v30 : Async<unit> = v29 10
    v30
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v31 : Async<unit> = null |> unbox<Async<unit>>
    v31
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v32 : Async<unit> = Unchecked.defaultof<Async<unit>>
    v32
#endif
    |> fun x -> _v24 <- Some x
    let v33 : Async<unit> = _v24.Value
    do! v33 
    let v34 : int64 = v1 + 1L
    let v35 : Async<int64> = method2(v0, v34)
    return! v35 
    (*
    let v36 : int64 = *)
    }
    |> fun x -> _v7 <- Some x
    let v37 : Async<int64> = _v7 |> Option.get
    v37
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v38 : Async<int64> = null |> unbox<Async<int64>>
    v38
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v39 : Async<int64> = Unchecked.defaultof<Async<int64>>
    v39
#endif
    |> fun x -> _v2 <- Some x
    let v40 : Async<int64> = _v2.Value
    v40
and closure1 () (v0 : string) : Async<int64> =
    let v1 : Async<int64> option = None
    let v2 : bool = true in let mutable _v1 = v1
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
    let v7 : Async<int64> = method2(v0, v6)
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
    |> fun x -> _v1 <- Some x
    let v10 : Async<int64> = _v1.Value
    v10
and method5 (v0 : string, v1 : int64, v2 : string) : string =
    let v3 : (string -> string) = closure3()
    let v4 : (unit -> string) = closure4()
    let v5 : string = $"path: {v0 |> v3} / retry: {v1} / ex: {v2} / {v4 ()}"
    v5
and closure7 (v0 : string, v1 : int64, v2 : string) () : string =
    method5(v0, v1, v2)
and method4 (v0 : string, v1 : US4, v2 : US3, v3 : int64) : Async<int64> =
    let v4 : Async<int64> option = None
    let v5 : bool = true in let mutable _v4 = v4
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v6 : Async<int64> = null |> unbox<Async<int64>>
    v6
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v7 : Async<int64> = null |> unbox<Async<int64>>
    v7
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v8 : Async<int64> = null |> unbox<Async<int64>>
    v8
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v9 : Async<int64> option = None
    let mutable _v9 = v9
    async {
    try
    let v10 : System.IO.FileStream option = None
    let v11 : bool = true in let mutable _v10 = v10
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
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v15 : System.IO.FileMode = System.IO.FileMode.Open
    let v21 : System.IO.FileAccess =
        match v2 with
        | US3_0 -> (* AccessRead *)
            let v16 : System.IO.FileAccess = System.IO.FileAccess.Read
            v16
        | US3_2 -> (* AccessReadWrite *)
            let v18 : System.IO.FileAccess = System.IO.FileAccess.ReadWrite
            v18
        | US3_1 -> (* AccessWrite *)
            let v17 : System.IO.FileAccess = System.IO.FileAccess.ReadWrite
            v17
    let v31 : System.IO.FileShare =
        match v1 with
        | US4_4 -> (* ShareDelete *)
            let v26 : System.IO.FileShare = System.IO.FileShare.Delete
            v26
        | US4_0 -> (* ShareNone *)
            let v22 : System.IO.FileShare = System.IO.FileShare.None
            v22
        | US4_1 -> (* ShareRead *)
            let v23 : System.IO.FileShare = System.IO.FileShare.Read
            v23
        | US4_3 -> (* ShareReadWrite *)
            let v25 : System.IO.FileShare = System.IO.FileShare.ReadWrite
            v25
        | US4_2 -> (* ShareWrite *)
            let v24 : System.IO.FileShare = System.IO.FileShare.Write
            v24
    let v32 : System.IO.FileStream = new System.IO.FileStream (v0, v15, v21, v31)
    v32
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v33 : System.IO.FileStream = null |> unbox<System.IO.FileStream>
    v33
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v34 : System.IO.FileStream = Unchecked.defaultof<System.IO.FileStream>
    v34
#endif
    |> fun x -> _v10 <- Some x
    let v35 : System.IO.FileStream = _v10.Value
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
        let v42 : string option = None
        let v43 : bool = true in let mutable _v42 = v42
        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v44 : string = $"%A{v37}"
        v44
#endif
        #if FABLE_COMPILER_RUST && WASM
        let v45 : string = $"%A{v37}"
        v45
#endif
        #if FABLE_COMPILER_RUST && CONTRACT
        let v46 : string = $"%A{v37}"
        v46
#endif
        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
        let v47 : string = $"{v37.GetType ()}: {v37.Message}"
        v47
#endif
        #if FABLE_COMPILER_TYPESCRIPT
        let v48 : string = $"%A{v37}"
        v48
#endif
        #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
        let v49 : string = Unchecked.defaultof<string>
        v49
#endif
        |> fun x -> _v42 <- Some x
        let v50 : string = _v42.Value
        let v51 : (unit -> string) = closure7(v0, v3, v50)
        let v52 : string = $"wait_for_file_access / {v51 ()}"
        System.Console.WriteLine v52
        ()
    let v53 : Async<unit> option = None
    let v54 : bool = true in let mutable _v53 = v53
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v55 : Async<unit> = null |> unbox<Async<unit>>
    v55
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v56 : Async<unit> = null |> unbox<Async<unit>>
    v56
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v57 : Async<unit> = null |> unbox<Async<unit>>
    v57
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v58 : (int32 -> Async<unit>) = Async.Sleep
    let v59 : Async<unit> = v58 10
    v59
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v60 : Async<unit> = null |> unbox<Async<unit>>
    v60
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v61 : Async<unit> = Unchecked.defaultof<Async<unit>>
    v61
#endif
    |> fun x -> _v53 <- Some x
    let v62 : Async<unit> = _v53.Value
    do! v62 
    let v63 : int64 = v3 + 1L
    let v64 : Async<int64> = method4(v0, v1, v2, v63)
    return! v64 
    (*
    let v65 : int64 = *)
    }
    |> fun x -> _v9 <- Some x
    let v66 : Async<int64> = _v9 |> Option.get
    v66
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v67 : Async<int64> = null |> unbox<Async<int64>>
    v67
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v68 : Async<int64> = Unchecked.defaultof<Async<int64>>
    v68
#endif
    |> fun x -> _v4 <- Some x
    let v69 : Async<int64> = _v4.Value
    v69
and closure6 (v0 : US2) (v1 : string) : Async<int64> =
    let v2 : Async<int64> option = None
    let v3 : bool = true in let mutable _v2 = v2
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
    let struct (v13 : US3, v14 : US4) =
        match v0 with
        | US2_1 -> (* None *)
            let v9 : US3 = US3_2
            let v10 : US4 = US4_1
            struct (v9, v10)
        | US2_0(v7, v8) -> (* Some *)
            struct (v7, v8)
    let v15 : int64 = 0L
    let v16 : Async<int64> = method4(v1, v14, v13, v15)
    v16
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v17 : Async<int64> = null |> unbox<Async<int64>>
    v17
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v18 : Async<int64> = Unchecked.defaultof<Async<int64>>
    v18
#endif
    |> fun x -> _v2 <- Some x
    let v19 : Async<int64> = _v2.Value
    v19
and closure5 () (v0 : US2) : (string -> Async<int64>) =
    closure6(v0)
and method6 (v0 : string, v1 : int64) : Async<int64> =
    let v2 : Async<int64> option = None
    let v3 : bool = true in let mutable _v2 = v2
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
    let v8 : System.IO.FileStream option = None
    let v9 : bool = true in let mutable _v8 = v8
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
    let v14 : System.IO.FileAccess = System.IO.FileAccess.Read
    let v15 : System.IO.FileShare = System.IO.FileShare.Read
    let v16 : System.IO.FileStream = new System.IO.FileStream (v0, v13, v14, v15)
    v16
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v17 : System.IO.FileStream = null |> unbox<System.IO.FileStream>
    v17
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v18 : System.IO.FileStream = Unchecked.defaultof<System.IO.FileStream>
    v18
#endif
    |> fun x -> _v8 <- Some x
    let v19 : System.IO.FileStream = _v8.Value
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
        let v26 : string option = None
        let v27 : bool = true in let mutable _v26 = v26
        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v28 : string = $"%A{v21}"
        v28
#endif
        #if FABLE_COMPILER_RUST && WASM
        let v29 : string = $"%A{v21}"
        v29
#endif
        #if FABLE_COMPILER_RUST && CONTRACT
        let v30 : string = $"%A{v21}"
        v30
#endif
        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
        let v31 : string = $"{v21.GetType ()}: {v21.Message}"
        v31
#endif
        #if FABLE_COMPILER_TYPESCRIPT
        let v32 : string = $"%A{v21}"
        v32
#endif
        #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
        let v33 : string = Unchecked.defaultof<string>
        v33
#endif
        |> fun x -> _v26 <- Some x
        let v34 : string = _v26.Value
        let v35 : (unit -> string) = closure7(v0, v1, v34)
        let v36 : string = $"wait_for_file_access / {v35 ()}"
        System.Console.WriteLine v36
        ()
    let v37 : Async<unit> option = None
    let v38 : bool = true in let mutable _v37 = v37
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v39 : Async<unit> = null |> unbox<Async<unit>>
    v39
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v40 : Async<unit> = null |> unbox<Async<unit>>
    v40
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v41 : Async<unit> = null |> unbox<Async<unit>>
    v41
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v42 : (int32 -> Async<unit>) = Async.Sleep
    let v43 : Async<unit> = v42 10
    v43
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v44 : Async<unit> = null |> unbox<Async<unit>>
    v44
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v45 : Async<unit> = Unchecked.defaultof<Async<unit>>
    v45
#endif
    |> fun x -> _v37 <- Some x
    let v46 : Async<unit> = _v37.Value
    do! v46 
    let v47 : int64 = v1 + 1L
    let v48 : Async<int64> = method6(v0, v47)
    return! v48 
    (*
    let v49 : int64 = *)
    }
    |> fun x -> _v7 <- Some x
    let v50 : Async<int64> = _v7 |> Option.get
    v50
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v51 : Async<int64> = null |> unbox<Async<int64>>
    v51
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v52 : Async<int64> = Unchecked.defaultof<Async<int64>>
    v52
#endif
    |> fun x -> _v2 <- Some x
    let v53 : Async<int64> = _v2.Value
    v53
and closure8 () (v0 : string) : Async<int64> =
    let v1 : Async<int64> option = None
    let v2 : bool = true in let mutable _v1 = v1
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
    let v7 : Async<int64> = method6(v0, v6)
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
    |> fun x -> _v1 <- Some x
    let v10 : Async<int64> = _v1.Value
    v10
and closure9 () (v0 : string) : Async<string> =
    let v1 : Async<string> option = None
    let v2 : bool = true in let mutable _v1 = v1
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : Async<string> = null |> unbox<Async<string>>
    v3
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v4 : Async<string> = null |> unbox<Async<string>>
    v4
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v5 : Async<string> = null |> unbox<Async<string>>
    v5
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v6 : (string -> System.Threading.Tasks.Task<string>) = System.IO.File.ReadAllTextAsync
    let v7 : System.Threading.Tasks.Task<string> = v6 v0
    let v8 : Async<string> option = None
    let v9 : bool = true in let mutable _v8 = v8
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
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v13 : (System.Threading.Tasks.Task<string> -> Async<string>) = Async.AwaitTask
    let v14 : Async<string> = v13 v7
    v14
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v15 : Async<string> = null |> unbox<Async<string>>
    v15
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v16 : Async<string> = Unchecked.defaultof<Async<string>>
    v16
#endif
    |> fun x -> _v8 <- Some x
    let v17 : Async<string> = _v8.Value
    v17
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v18 : Async<string> = null |> unbox<Async<string>>
    v18
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v19 : Async<string> = Unchecked.defaultof<Async<string>>
    v19
#endif
    |> fun x -> _v1 <- Some x
    let v20 : Async<string> = _v1.Value
    v20
and method7 (v0 : string) : string =
    v0
and closure11 (v0 : string) (v1 : string) : Async<bool> =
    let v2 : Async<bool> option = None
    let v3 : bool = true in let mutable _v2 = v2
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v4 : Async<bool> = null |> unbox<Async<bool>>
    v4
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v5 : Async<bool> = null |> unbox<Async<bool>>
    v5
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v6 : Async<bool> = null |> unbox<Async<bool>>
    v6
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v7 : Async<bool> option = None
    let v8 : bool = true in let mutable _v7 = v7
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
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v12 : Async<bool> option = None
    let mutable _v12 = v12
    async {
    let v13 : bool option = None
    let v14 : bool = true in let mutable _v13 = v13
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v15 : string = method7(v0)
    let v16 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v17 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v15 v16
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
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v29 : (string -> bool) = System.IO.File.Exists
    let v30 : bool = v29 v0
    v30
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v31 : string = "fs"
    let v32 : IFsExistsSync = Fable.Core.JsInterop.importAll v31
    let v33 : string = "v32.existsSync($0)"
    let v34 : bool = Fable.Core.JsInterop.emitJsExpr v0 v33
    v34
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v35 : bool = Unchecked.defaultof<bool>
    v35
#endif
    |> fun x -> _v13 <- Some x
    let v36 : bool = _v13.Value
    let v37 : bool = v36 = false
    if v37 then
        return false 
        (*
        ()
    else
        *) else
        let v38 : Async<string> option = None
        let v39 : bool = true in let mutable _v38 = v38
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
        let v46 : bool = true in let mutable _v45 = v45
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
        let v51 : Async<string> = v50 v44
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
        |> fun x -> _v45 <- Some x
        let v54 : Async<string> = _v45.Value
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
        |> fun x -> _v38 <- Some x
        let v57 : Async<string> = _v38.Value
        let! v57 = v57 
        let v58 : string = v57 
        let v59 : bool = v1 = v58
        return v59 
        (*
        ()
    *)
    }
    |> fun x -> _v12 <- Some x
    let v60 : Async<bool> = _v12 |> Option.get
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
    |> fun x -> _v7 <- Some x
    let v63 : Async<bool> = _v7.Value
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
    |> fun x -> _v2 <- Some x
    let v66 : Async<bool> = _v2.Value
    v66
and closure10 () (v0 : string) : (string -> Async<bool>) =
    closure11(v0)
and closure13 (v0 : string) (v1 : string) : Async<unit> =
    let v2 : Async<unit> option = None
    let v3 : bool = true in let mutable _v2 = v2
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v4 : Async<unit> = null |> unbox<Async<unit>>
    v4
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v5 : Async<unit> = null |> unbox<Async<unit>>
    v5
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v6 : Async<unit> = null |> unbox<Async<unit>>
    v6
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v7 : System.Threading.Tasks.Task = System.IO.File.WriteAllTextAsync (v0, v1)
    let v8 : Async<unit> option = None
    let v9 : bool = true in let mutable _v8 = v8
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
    let v13 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
    let v14 : Async<unit> = v13 v7
    v14
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v15 : Async<unit> = null |> unbox<Async<unit>>
    v15
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v16 : Async<unit> = Unchecked.defaultof<Async<unit>>
    v16
#endif
    |> fun x -> _v8 <- Some x
    let v17 : Async<unit> = _v8.Value
    v17
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v18 : Async<unit> = null |> unbox<Async<unit>>
    v18
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v19 : Async<unit> = Unchecked.defaultof<Async<unit>>
    v19
#endif
    |> fun x -> _v2 <- Some x
    let v20 : Async<unit> = _v2.Value
    v20
and closure12 () (v0 : string) : (string -> Async<unit>) =
    closure13(v0)
and closure15 (v0 : string) (v1 : string) : Async<unit> =
    let v2 : Async<unit> option = None
    let v3 : bool = true in let mutable _v2 = v2
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v4 : Async<unit> = null |> unbox<Async<unit>>
    v4
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v5 : Async<unit> = null |> unbox<Async<unit>>
    v5
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v6 : Async<unit> = null |> unbox<Async<unit>>
    v6
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v7 : Async<unit> option = None
    let mutable _v7 = v7
    async {
    let v8 : Async<bool> option = None
    let v9 : bool = true in let mutable _v8 = v8
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
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v13 : Async<bool> option = None
    let v14 : bool = true in let mutable _v13 = v13
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v15 : Async<bool> = null |> unbox<Async<bool>>
    v15
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v16 : Async<bool> = null |> unbox<Async<bool>>
    v16
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v17 : Async<bool> = null |> unbox<Async<bool>>
    v17
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v18 : Async<bool> option = None
    let mutable _v18 = v18
    async {
    let v19 : bool option = None
    let v20 : bool = true in let mutable _v19 = v19
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v21 : string = method7(v0)
    let v22 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v23 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v21 v22
    let v24 : string = "String::from($0)"
    let v25 : std_string_String = Fable.Core.RustInterop.emitRustExpr v23 v24
    let v26 : string = "std::path::PathBuf::from($0)"
    let v27 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v25 v26
    let v28 : string = "$0.exists()"
    let v29 : bool = Fable.Core.RustInterop.emitRustExpr v27 v28
    let v32 : bool =
        if v29 then
            let v30 : string = "$0.is_file()"
            let v31 : bool = Fable.Core.RustInterop.emitRustExpr v27 v30
            v31
        else
            false
    v32
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v33 : bool = null |> unbox<bool>
    v33
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v34 : bool = null |> unbox<bool>
    v34
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v35 : (string -> bool) = System.IO.File.Exists
    let v36 : bool = v35 v0
    v36
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v37 : string = "fs"
    let v38 : IFsExistsSync = Fable.Core.JsInterop.importAll v37
    let v39 : string = "v38.existsSync($0)"
    let v40 : bool = Fable.Core.JsInterop.emitJsExpr v0 v39
    v40
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v41 : bool = Unchecked.defaultof<bool>
    v41
#endif
    |> fun x -> _v19 <- Some x
    let v42 : bool = _v19.Value
    let v43 : bool = v42 = false
    if v43 then
        return false 
        (*
        ()
    else
        *) else
        let v44 : Async<string> option = None
        let v45 : bool = true in let mutable _v44 = v44
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
        let v49 : (string -> System.Threading.Tasks.Task<string>) = System.IO.File.ReadAllTextAsync
        let v50 : System.Threading.Tasks.Task<string> = v49 v0
        let v51 : Async<string> option = None
        let v52 : bool = true in let mutable _v51 = v51
        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v53 : Async<string> = null |> unbox<Async<string>>
        v53
#endif
        #if FABLE_COMPILER_RUST && WASM
        let v54 : Async<string> = null |> unbox<Async<string>>
        v54
#endif
        #if FABLE_COMPILER_RUST && CONTRACT
        let v55 : Async<string> = null |> unbox<Async<string>>
        v55
#endif
        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
        let v56 : (System.Threading.Tasks.Task<string> -> Async<string>) = Async.AwaitTask
        let v57 : Async<string> = v56 v50
        v57
#endif
        #if FABLE_COMPILER_TYPESCRIPT
        let v58 : Async<string> = null |> unbox<Async<string>>
        v58
#endif
        #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
        let v59 : Async<string> = Unchecked.defaultof<Async<string>>
        v59
#endif
        |> fun x -> _v51 <- Some x
        let v60 : Async<string> = _v51.Value
        v60
#endif
        #if FABLE_COMPILER_TYPESCRIPT
        let v61 : Async<string> = null |> unbox<Async<string>>
        v61
#endif
        #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
        let v62 : Async<string> = Unchecked.defaultof<Async<string>>
        v62
#endif
        |> fun x -> _v44 <- Some x
        let v63 : Async<string> = _v44.Value
        let! v63 = v63 
        let v64 : string = v63 
        let v65 : bool = v1 = v64
        return v65 
        (*
        ()
    *)
    }
    |> fun x -> _v18 <- Some x
    let v66 : Async<bool> = _v18 |> Option.get
    v66
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v67 : Async<bool> = null |> unbox<Async<bool>>
    v67
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v68 : Async<bool> = Unchecked.defaultof<Async<bool>>
    v68
#endif
    |> fun x -> _v13 <- Some x
    let v69 : Async<bool> = _v13.Value
    v69
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v70 : Async<bool> = null |> unbox<Async<bool>>
    v70
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v71 : Async<bool> = Unchecked.defaultof<Async<bool>>
    v71
#endif
    |> fun x -> _v8 <- Some x
    let v72 : Async<bool> = _v8.Value
    let! v72 = v72 
    let v73 : bool = v72 
    let v74 : bool = v73 = false
    if v74 then
        let v75 : Async<unit> option = None
        let v76 : bool = true in let mutable _v75 = v75
        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v77 : Async<unit> = null |> unbox<Async<unit>>
        v77
#endif
        #if FABLE_COMPILER_RUST && WASM
        let v78 : Async<unit> = null |> unbox<Async<unit>>
        v78
#endif
        #if FABLE_COMPILER_RUST && CONTRACT
        let v79 : Async<unit> = null |> unbox<Async<unit>>
        v79
#endif
        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
        let v80 : System.Threading.Tasks.Task = System.IO.File.WriteAllTextAsync (v0, v1)
        let v81 : Async<unit> option = None
        let v82 : bool = true in let mutable _v81 = v81
        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v83 : Async<unit> = null |> unbox<Async<unit>>
        v83
#endif
        #if FABLE_COMPILER_RUST && WASM
        let v84 : Async<unit> = null |> unbox<Async<unit>>
        v84
#endif
        #if FABLE_COMPILER_RUST && CONTRACT
        let v85 : Async<unit> = null |> unbox<Async<unit>>
        v85
#endif
        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
        let v86 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
        let v87 : Async<unit> = v86 v80
        v87
#endif
        #if FABLE_COMPILER_TYPESCRIPT
        let v88 : Async<unit> = null |> unbox<Async<unit>>
        v88
#endif
        #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
        let v89 : Async<unit> = Unchecked.defaultof<Async<unit>>
        v89
#endif
        |> fun x -> _v81 <- Some x
        let v90 : Async<unit> = _v81.Value
        v90
#endif
        #if FABLE_COMPILER_TYPESCRIPT
        let v91 : Async<unit> = null |> unbox<Async<unit>>
        v91
#endif
        #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
        let v92 : Async<unit> = Unchecked.defaultof<Async<unit>>
        v92
#endif
        |> fun x -> _v75 <- Some x
        let v93 : Async<unit> = _v75.Value
        do! v93 
        ()
    }
    |> fun x -> _v7 <- Some x
    let v94 : Async<unit> = _v7 |> Option.get
    v94
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v95 : Async<unit> = null |> unbox<Async<unit>>
    v95
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v96 : Async<unit> = Unchecked.defaultof<Async<unit>>
    v96
#endif
    |> fun x -> _v2 <- Some x
    let v97 : Async<unit> = _v2.Value
    v97
and closure14 () (v0 : string) : (string -> Async<unit>) =
    closure15(v0)
and closure17 () () : string =
    let v0 : string = "delete_file_async"
    v0
and closure19 () (v0 : int64) : US5 =
    US5_0(v0)
and method10 () : (int64 -> US5) =
    closure19()
and method11 () : string =
    let v0 : string = ""
    v0
and closure18 (v0 : US0, v1 : (unit -> string), v2 : (unit -> string)) () : string =
    let v3 : (unit -> struct (Mut0 * Mut1 * Mut1 * Mut2 * int64 option)) = closure0()
    if State.trace_state = None then State.trace_state <- v3 () |> Some
    let struct (v4 : Mut0, v5 : Mut1, v6 : Mut1, v7 : Mut2, v8 : int64 option) = State.trace_state.Value
    let v9 : string option = None
    let v10 : bool = true in let mutable _v9 = v9
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v11 : (int64 -> US5) = method10()
    let v12 : US5 = US5_1
    let v13 : US5 = v8 |> Option.map v11 |> Option.defaultValue v12 
    let v31 : System.DateTime =
        match v13 with
        | US5_1 -> (* None *)
            let v29 : System.DateTime = System.DateTime.Now
            v29
        | US5_0(v14) -> (* Some *)
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
    let v34 : string = method11()
    v34
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v35 : string = method11()
    v35
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v36 : (int64 -> US5) = method10()
    let v37 : US5 = US5_1
    let v38 : US5 = v8 |> Option.map v36 |> Option.defaultValue v37 
    let v56 : System.DateTime =
        match v38 with
        | US5_1 -> (* None *)
            let v54 : System.DateTime = System.DateTime.Now
            v54
        | US5_0(v39) -> (* Some *)
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
    let v59 : string = method11()
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
        | US0_4 -> (* Critical *)
            let v67 : string = "Critical"
            v67
        | US0_1 -> (* Debug *)
            let v64 : string = "Debug"
            v64
        | US0_2 -> (* Info *)
            let v65 : string = "Info"
            v65
        | US0_0 -> (* Verbose *)
            let v63 : string = "Verbose"
            v63
        | US0_3 -> (* Warning *)
            let v66 : string = "Warning"
            v66
    let v73 : string = v72.ToLower ()
    let v74 : string option = None
    let v75 : bool = true in let mutable _v74 = v74
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v90 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v84 : string = "inline_colorization::color_bright_red"
            let v85 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v84
            v85
        | US0_1 -> (* Debug *)
            let v78 : string = "inline_colorization::color_bright_blue"
            let v79 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v78
            v79
        | US0_2 -> (* Info *)
            let v80 : string = "inline_colorization::color_bright_green"
            let v81 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v80
            v81
        | US0_0 -> (* Verbose *)
            let v76 : string = "inline_colorization::color_bright_black"
            let v77 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v76
            v77
        | US0_3 -> (* Warning *)
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
        | US0_4 -> (* Critical *)
            let v108 : string = "inline_colorization::color_bright_red"
            let v109 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v108
            v109
        | US0_1 -> (* Debug *)
            let v102 : string = "inline_colorization::color_bright_blue"
            let v103 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v102
            v103
        | US0_2 -> (* Info *)
            let v104 : string = "inline_colorization::color_bright_green"
            let v105 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v104
            v105
        | US0_0 -> (* Verbose *)
            let v100 : string = "inline_colorization::color_bright_black"
            let v101 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v100
            v101
        | US0_3 -> (* Warning *)
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
        | US0_4 -> (* Critical *)
            let v132 : string = "inline_colorization::color_bright_red"
            let v133 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v132
            v133
        | US0_1 -> (* Debug *)
            let v126 : string = "inline_colorization::color_bright_blue"
            let v127 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v126
            v127
        | US0_2 -> (* Info *)
            let v128 : string = "inline_colorization::color_bright_green"
            let v129 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v128
            v129
        | US0_0 -> (* Verbose *)
            let v124 : string = "inline_colorization::color_bright_black"
            let v125 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v124
            v125
        | US0_3 -> (* Warning *)
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
and method9 (v0 : US0, v1 : (unit -> string), v2 : (unit -> string)) : unit =
    let v3 : (unit -> struct (Mut0 * Mut1 * Mut1 * Mut2 * int64 option)) = closure0()
    if State.trace_state = None then State.trace_state <- v3 () |> Some
    let struct (v4 : Mut0, v5 : Mut1, v6 : Mut1, v7 : Mut2, v8 : int64 option) = State.trace_state.Value
    if State.trace_state = None then State.trace_state <- v3 () |> Some
    let struct (v9 : Mut0, v10 : Mut1, v11 : Mut1, v12 : Mut2, v13 : int64 option) = State.trace_state.Value
    let v14 : US0 = v12.l0
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
and method8 (v0 : string, v1 : int64) : Async<int64> =
    let v2 : Async<int64> option = None
    let v3 : bool = true in let mutable _v2 = v2
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
    let v9 : bool = true in let mutable _v8 = v8
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
    let v10 : (string -> unit) = System.IO.File.Delete
    v10 v0
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
    return v1 
    with ex ->
    let v11 : exn = ex
    let v12 : int64 = v1 % 100L
    let v13 : bool = v12 = 0L
    if v13 then
        let v14 : string option = None
        let v15 : bool = true in let mutable _v14 = v14
        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v16 : string = $"%A{v11}"
        v16
#endif
        #if FABLE_COMPILER_RUST && WASM
        let v17 : string = $"%A{v11}"
        v17
#endif
        #if FABLE_COMPILER_RUST && CONTRACT
        let v18 : string = $"%A{v11}"
        v18
#endif
        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
        let v19 : string = $"{v11.GetType ()}: {v11.Message}"
        v19
#endif
        #if FABLE_COMPILER_TYPESCRIPT
        let v20 : string = $"%A{v11}"
        v20
#endif
        #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
        let v21 : string = Unchecked.defaultof<string>
        v21
#endif
        |> fun x -> _v14 <- Some x
        let v22 : string = _v14.Value
        let v23 : US0 = US0_3
        let v24 : (unit -> string) = closure17()
        let v25 : (unit -> string) = closure4()
        method9(v23, v24, v25)
    let v26 : Async<unit> option = None
    let v27 : bool = true in let mutable _v26 = v26
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v28 : Async<unit> = null |> unbox<Async<unit>>
    v28
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v29 : Async<unit> = null |> unbox<Async<unit>>
    v29
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v30 : Async<unit> = null |> unbox<Async<unit>>
    v30
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v31 : (int32 -> Async<unit>) = Async.Sleep
    let v32 : Async<unit> = v31 10
    v32
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v33 : Async<unit> = null |> unbox<Async<unit>>
    v33
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v34 : Async<unit> = Unchecked.defaultof<Async<unit>>
    v34
#endif
    |> fun x -> _v26 <- Some x
    let v35 : Async<unit> = _v26.Value
    do! v35 
    let v36 : int64 = v1 + 1L
    let v37 : Async<int64> = method8(v0, v36)
    return! v37 
    (*
    let v38 : int64 = *)
    }
    |> fun x -> _v7 <- Some x
    let v39 : Async<int64> = _v7 |> Option.get
    v39
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v40 : Async<int64> = null |> unbox<Async<int64>>
    v40
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v41 : Async<int64> = Unchecked.defaultof<Async<int64>>
    v41
#endif
    |> fun x -> _v2 <- Some x
    let v42 : Async<int64> = _v2.Value
    v42
and closure16 () (v0 : string) : Async<int64> =
    let v1 : Async<int64> option = None
    let v2 : bool = true in let mutable _v1 = v1
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
    let v7 : Async<int64> = method8(v0, v6)
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
    |> fun x -> _v1 <- Some x
    let v10 : Async<int64> = _v1.Value
    v10
and closure22 () () : string =
    let v0 : string = "move_file_async"
    v0
and method13 (v0 : string, v1 : string, v2 : exn) : string =
    let v3 : string option = None
    let v4 : bool = true in let mutable _v3 = v3
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v5 : string = $"%A{v2}"
    v5
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v6 : string = $"%A{v2}"
    v6
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v7 : string = $"%A{v2}"
    v7
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v8 : string = $"{v2.GetType ()}: {v2.Message}"
    v8
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v9 : string = $"%A{v2}"
    v9
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v10 : string = Unchecked.defaultof<string>
    v10
#endif
    |> fun x -> _v3 <- Some x
    let v11 : string = _v3.Value
    let v12 : (string -> string) = closure3()
    let v13 : (unit -> string) = closure4()
    let v14 : string = $"old_path: {v1 |> v12} / new_path: {v0 |> v12} / ex: {v11} / {v13 ()}"
    v14
and closure23 (v0 : string, v1 : string, v2 : exn) () : string =
    method13(v0, v1, v2)
and method12 (v0 : string, v1 : string, v2 : int64) : Async<int64> =
    let v3 : Async<int64> option = None
    let v4 : bool = true in let mutable _v3 = v3
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
    let v9 : unit option = None
    let v10 : bool = true in let mutable _v9 = v9
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
    |> fun x -> _v9 <- Some x
    _v9.Value
    return v2 
    with ex ->
    let v11 : exn = ex
    let v12 : int64 = v2 % 100L
    let v13 : bool = v12 = 0L
    if v13 then
        let v14 : US0 = US0_3
        let v15 : (unit -> string) = closure22()
        let v16 : (unit -> string) = closure23(v0, v1, v11)
        method9(v14, v15, v16)
    let v17 : Async<unit> option = None
    let v18 : bool = true in let mutable _v17 = v17
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
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v22 : (int32 -> Async<unit>) = Async.Sleep
    let v23 : Async<unit> = v22 10
    v23
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v24 : Async<unit> = null |> unbox<Async<unit>>
    v24
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v25 : Async<unit> = Unchecked.defaultof<Async<unit>>
    v25
#endif
    |> fun x -> _v17 <- Some x
    let v26 : Async<unit> = _v17.Value
    do! v26 
    let v27 : int64 = v2 + 1L
    let v28 : Async<int64> = method12(v0, v1, v27)
    return! v28 
    (*
    *)
    }
    |> fun x -> _v8 <- Some x
    let v29 : Async<int64> = _v8 |> Option.get
    v29
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v30 : Async<int64> = null |> unbox<Async<int64>>
    v30
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v31 : Async<int64> = Unchecked.defaultof<Async<int64>>
    v31
#endif
    |> fun x -> _v3 <- Some x
    let v32 : Async<int64> = _v3.Value
    v32
and closure21 (v0 : string) (v1 : string) : Async<int64> =
    let v2 : Async<int64> option = None
    let v3 : bool = true in let mutable _v2 = v2
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
    let v7 : int64 = 0L
    let v8 : Async<int64> = method12(v0, v1, v7)
    v8
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v9 : Async<int64> = null |> unbox<Async<int64>>
    v9
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v10 : Async<int64> = Unchecked.defaultof<Async<int64>>
    v10
#endif
    |> fun x -> _v2 <- Some x
    let v11 : Async<int64> = _v2.Value
    v11
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
    let v0 : (unit -> string) = closure4()
    let v1 : string = $"timeout: {1000} / {v0 ()}"
    v1
and closure29 (v0 : string) () : string =
    let v1 : string = $"run_with_timeout_async** / ex: {v0}"
    v1
and closure30 () () : string =
    let v0 : string = "read_all_text_retry_async"
    v0
and method15 (v0 : int64, v1 : string) : string =
    let v2 : (unit -> string) = closure4()
    let v3 : string = $"retry: {v0} / ex: {v1} / {v2 ()}"
    v3
and closure31 (v0 : int64, v1 : string) () : string =
    method15(v0, v1)
and method14 (v0 : string, v1 : int64) : Async<string option> =
    let v2 : Async<string option> option = None
    let v3 : bool = true in let mutable _v2 = v2
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v4 : Async<string option> = null |> unbox<Async<string option>>
    v4
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v5 : Async<string option> = null |> unbox<Async<string option>>
    v5
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v6 : Async<string option> = null |> unbox<Async<string option>>
    v6
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v7 : Async<string option> option = None
    let mutable _v7 = v7
    async {
    try
    let v8 : bool = v1 > 0L
    if v8 then
        let v9 : Async<int64> option = None
        let v10 : bool = true in let mutable _v9 = v9
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
        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
        let v14 : int64 = 0L
        let v15 : Async<int64> = method6(v0, v14)
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
        |> fun x -> _v9 <- Some x
        let v18 : Async<int64> = _v9.Value
        let v19 : Async<US5> option = None
        let v20 : bool = true in let mutable _v19 = v19
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
        let v25 : bool = true in let mutable _v24 = v24
        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v26 : Async<US5> = null |> unbox<Async<US5>>
        v26
#endif
        #if FABLE_COMPILER_RUST && WASM
        let v27 : Async<US5> = null |> unbox<Async<US5>>
        v27
#endif
        #if FABLE_COMPILER_RUST && CONTRACT
        let v28 : Async<US5> = null |> unbox<Async<US5>>
        v28
#endif
        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
        let v29 : Async<US5> option = None
        let mutable _v29 = v29
        async {
        let v30 : Async<Async<int64>> option = None
        let v31 : bool = true in let mutable _v30 = v30
        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v32 : Async<Async<int64>> = null |> unbox<Async<Async<int64>>>
        v32
#endif
        #if FABLE_COMPILER_RUST && WASM
        let v33 : Async<Async<int64>> = null |> unbox<Async<Async<int64>>>
        v33
#endif
        #if FABLE_COMPILER_RUST && CONTRACT
        let v34 : Async<Async<int64>> = null |> unbox<Async<Async<int64>>>
        v34
#endif
        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
        let v35 : Async<Async<int64>> = Async.StartChild (v18, 1000)
        v35
#endif
        #if FABLE_COMPILER_TYPESCRIPT
        let v36 : Async<Async<int64>> = null |> unbox<Async<Async<int64>>>
        v36
#endif
        #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
        let v37 : Async<Async<int64>> = Unchecked.defaultof<Async<Async<int64>>>
        v37
#endif
        |> fun x -> _v30 <- Some x
        let v38 : Async<Async<int64>> = _v30.Value
        let! v38 = v38 
        let v39 : Async<int64> = v38 
        let v40 : Async<Choice<int64, exn>> option = None
        let v41 : bool = true in let mutable _v40 = v40
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
        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
        let v45 : (Async<int64> -> Async<Choice<int64, exn>>) = Async.Catch
        let v46 : Async<Choice<int64, exn>> = v45 v39
        v46
#endif
        #if FABLE_COMPILER_TYPESCRIPT
        let v47 : Async<Choice<int64, exn>> = null |> unbox<Async<Choice<int64, exn>>>
        v47
#endif
        #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
        let v48 : Async<Choice<int64, exn>> = Unchecked.defaultof<Async<Choice<int64, exn>>>
        v48
#endif
        |> fun x -> _v40 <- Some x
        let v49 : Async<Choice<int64, exn>> = _v40.Value
        let v50 : Async<US6> option = None
        let v51 : bool = true in let mutable _v50 = v50
        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v52 : Async<US6> = null |> unbox<Async<US6>>
        v52
#endif
        #if FABLE_COMPILER_RUST && WASM
        let v53 : Async<US6> = null |> unbox<Async<US6>>
        v53
#endif
        #if FABLE_COMPILER_RUST && CONTRACT
        let v54 : Async<US6> = null |> unbox<Async<US6>>
        v54
#endif
        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
        let v55 : Async<US6> option = None
        let mutable _v55 = v55
        async {
        let! v49 = v49 
        let v56 : Choice<int64, exn> = v49 
        let v57 : US6 option = None
        let v58 : bool = true in let mutable _v57 = v57
        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v59 : US6 = null |> unbox<US6>
        v59
#endif
        #if FABLE_COMPILER_RUST && WASM
        let v60 : US6 = null |> unbox<US6>
        v60
#endif
        #if FABLE_COMPILER_RUST && CONTRACT
        let v61 : US6 = null |> unbox<US6>
        v61
#endif
        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
        let v62 : (int64 -> US6) = closure25()
        let v63 : (exn -> US6) = closure26()
        let v64 : US6 = match v56 with Choice1Of2 x -> v62 x | Choice2Of2 x -> v63 x
        v64
#endif
        #if FABLE_COMPILER_TYPESCRIPT
        let v65 : US6 = null |> unbox<US6>
        v65
#endif
        #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
        let v66 : US6 = Unchecked.defaultof<US6>
        v66
#endif
        |> fun x -> _v57 <- Some x
        let v67 : US6 = _v57.Value
        return v67 
        }
        |> fun x -> _v55 <- Some x
        let v68 : Async<US6> = _v55 |> Option.get
        v68
#endif
        #if FABLE_COMPILER_TYPESCRIPT
        let v69 : Async<US6> = null |> unbox<Async<US6>>
        v69
#endif
        #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
        let v70 : Async<US6> = Unchecked.defaultof<Async<US6>>
        v70
#endif
        |> fun x -> _v50 <- Some x
        let v71 : Async<US6> = _v50.Value
        let v72 : Async<US7> option = None
        let v73 : bool = true in let mutable _v72 = v72
        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v74 : Async<US7> = null |> unbox<Async<US7>>
        v74
#endif
        #if FABLE_COMPILER_RUST && WASM
        let v75 : Async<US7> = null |> unbox<Async<US7>>
        v75
#endif
        #if FABLE_COMPILER_RUST && CONTRACT
        let v76 : Async<US7> = null |> unbox<Async<US7>>
        v76
#endif
        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
        let v77 : Async<US7> option = None
        let mutable _v77 = v77
        async {
        let! v71 = v71 
        let v78 : US6 = v71 
        let v84 : US7 =
            match v78 with
            | US6_0(v79) -> (* Choice1Of2 *)
                US7_0(v79)
            | US6_1(v81) -> (* Choice2Of2 *)
                US7_1(v81)
        return v84 
        }
        |> fun x -> _v77 <- Some x
        let v85 : Async<US7> = _v77 |> Option.get
        v85
#endif
        #if FABLE_COMPILER_TYPESCRIPT
        let v86 : Async<US7> = null |> unbox<Async<US7>>
        v86
#endif
        #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
        let v87 : Async<US7> = Unchecked.defaultof<Async<US7>>
        v87
#endif
        |> fun x -> _v72 <- Some x
        let v88 : Async<US7> = _v72.Value
        let v89 : Async<US5> option = None
        let v90 : bool = true in let mutable _v89 = v89
        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v91 : Async<US5> = null |> unbox<Async<US5>>
        v91
#endif
        #if FABLE_COMPILER_RUST && WASM
        let v92 : Async<US5> = null |> unbox<Async<US5>>
        v92
#endif
        #if FABLE_COMPILER_RUST && CONTRACT
        let v93 : Async<US5> = null |> unbox<Async<US5>>
        v93
#endif
        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
        let v94 : Async<US5> option = None
        let mutable _v94 = v94
        async {
        let! v88 = v88 
        let v95 : US7 = v88 
        let v121 : US5 =
            match v95 with
            | US7_1(v98) -> (* Error *)
                let v99 : string = $"%A{v98}"
                let v100 : string = "System.TimeoutException"
                let v101 : bool = v99.Contains v100
                if v101 then
                    let v102 : US0 = US0_1
                    let v103 : (unit -> string) = closure27()
                    let v104 : (unit -> string) = closure28()
                    method9(v102, v103, v104)
                    US5_1
                else
                    let v106 : string option = None
                    let v107 : bool = true in let mutable _v106 = v106
                    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v108 : string = $"%A{v98}"
                    v108
#endif
                    #if FABLE_COMPILER_RUST && WASM
                    let v109 : string = $"%A{v98}"
                    v109
#endif
                    #if FABLE_COMPILER_RUST && CONTRACT
                    let v110 : string = $"%A{v98}"
                    v110
#endif
                    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                    let v111 : string = $"{v98.GetType ()}: {v98.Message}"
                    v111
#endif
                    #if FABLE_COMPILER_TYPESCRIPT
                    let v112 : string = $"%A{v98}"
                    v112
#endif
                    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
                    let v113 : string = Unchecked.defaultof<string>
                    v113
#endif
                    |> fun x -> _v106 <- Some x
                    let v114 : string = _v106.Value
                    let v115 : US0 = US0_4
                    let v116 : (unit -> string) = closure29(v114)
                    let v117 : (unit -> string) = closure28()
                    method9(v115, v116, v117)
                    US5_1
            | US7_0(v96) -> (* Ok *)
                US5_0(v96)
        return v121 
        }
        |> fun x -> _v94 <- Some x
        let v122 : Async<US5> = _v94 |> Option.get
        v122
#endif
        #if FABLE_COMPILER_TYPESCRIPT
        let v123 : Async<US5> = null |> unbox<Async<US5>>
        v123
#endif
        #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
        let v124 : Async<US5> = Unchecked.defaultof<Async<US5>>
        v124
#endif
        |> fun x -> _v89 <- Some x
        let v125 : Async<US5> = _v89.Value
        return! v125 
        }
        |> fun x -> _v29 <- Some x
        let v126 : Async<US5> = _v29 |> Option.get
        v126
#endif
        #if FABLE_COMPILER_TYPESCRIPT
        let v127 : Async<US5> = null |> unbox<Async<US5>>
        v127
#endif
        #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
        let v128 : Async<US5> = Unchecked.defaultof<Async<US5>>
        v128
#endif
        |> fun x -> _v24 <- Some x
        let v129 : Async<US5> = _v24.Value
        v129
#endif
        #if FABLE_COMPILER_TYPESCRIPT
        let v130 : Async<US5> = null |> unbox<Async<US5>>
        v130
#endif
        #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
        let v131 : Async<US5> = Unchecked.defaultof<Async<US5>>
        v131
#endif
        |> fun x -> _v19 <- Some x
        let v132 : Async<US5> = _v19.Value
        let v133 : Async<unit> option = None
        let v134 : bool = true in let mutable _v133 = v133
        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v135 : Async<unit> = null |> unbox<Async<unit>>
        v135
#endif
        #if FABLE_COMPILER_RUST && WASM
        let v136 : Async<unit> = null |> unbox<Async<unit>>
        v136
#endif
        #if FABLE_COMPILER_RUST && CONTRACT
        let v137 : Async<unit> = null |> unbox<Async<unit>>
        v137
#endif
        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
        let v138 : (Async<US5> -> Async<unit>) = Async.Ignore
        let v139 : Async<unit> = v138 v132
        v139
#endif
        #if FABLE_COMPILER_TYPESCRIPT
        let v140 : Async<unit> = null |> unbox<Async<unit>>
        v140
#endif
        #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
        let v141 : Async<unit> = Unchecked.defaultof<Async<unit>>
        v141
#endif
        |> fun x -> _v133 <- Some x
        let v142 : Async<unit> = _v133.Value
        do! v142 
        ()
    let v143 : Async<string> option = None
    let v144 : bool = true in let mutable _v143 = v143
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v145 : Async<string> = null |> unbox<Async<string>>
    v145
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v146 : Async<string> = null |> unbox<Async<string>>
    v146
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v147 : Async<string> = null |> unbox<Async<string>>
    v147
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v148 : (string -> System.Threading.Tasks.Task<string>) = System.IO.File.ReadAllTextAsync
    let v149 : System.Threading.Tasks.Task<string> = v148 v0
    let v150 : Async<string> option = None
    let v151 : bool = true in let mutable _v150 = v150
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v152 : Async<string> = null |> unbox<Async<string>>
    v152
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v153 : Async<string> = null |> unbox<Async<string>>
    v153
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v154 : Async<string> = null |> unbox<Async<string>>
    v154
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v155 : (System.Threading.Tasks.Task<string> -> Async<string>) = Async.AwaitTask
    let v156 : Async<string> = v155 v149
    v156
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v157 : Async<string> = null |> unbox<Async<string>>
    v157
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v158 : Async<string> = Unchecked.defaultof<Async<string>>
    v158
#endif
    |> fun x -> _v150 <- Some x
    let v159 : Async<string> = _v150.Value
    v159
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v160 : Async<string> = null |> unbox<Async<string>>
    v160
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v161 : Async<string> = Unchecked.defaultof<Async<string>>
    v161
#endif
    |> fun x -> _v143 <- Some x
    let v162 : Async<string> = _v143.Value
    let v163 : Async<string option> option = None
    let v164 : bool = true in let mutable _v163 = v163
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v165 : Async<string option> = null |> unbox<Async<string option>>
    v165
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v166 : Async<string option> = null |> unbox<Async<string option>>
    v166
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v167 : Async<string option> = null |> unbox<Async<string option>>
    v167
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v168 : Async<string option> option = None
    let mutable _v168 = v168
    async {
    let! v162 = v162 
    let v169 : string = v162 
    let v170 : string option = Some v169 
    return v170 
    }
    |> fun x -> _v168 <- Some x
    let v171 : Async<string option> = _v168 |> Option.get
    v171
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v172 : Async<string option> = null |> unbox<Async<string option>>
    v172
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v173 : Async<string option> = Unchecked.defaultof<Async<string option>>
    v173
#endif
    |> fun x -> _v163 <- Some x
    let v174 : Async<string option> = _v163.Value
    return! v174 
    with ex ->
    let v175 : exn = ex
    let v176 : bool = v1 = 0L
    let v177 : bool = v176 <> true
    if v177 then
        let v178 : string option = None
        let v179 : bool = true in let mutable _v178 = v178
        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v180 : string = $"%A{v175}"
        v180
#endif
        #if FABLE_COMPILER_RUST && WASM
        let v181 : string = $"%A{v175}"
        v181
#endif
        #if FABLE_COMPILER_RUST && CONTRACT
        let v182 : string = $"%A{v175}"
        v182
#endif
        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
        let v183 : string = $"{v175.GetType ()}: {v175.Message}"
        v183
#endif
        #if FABLE_COMPILER_TYPESCRIPT
        let v184 : string = $"%A{v175}"
        v184
#endif
        #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
        let v185 : string = Unchecked.defaultof<string>
        v185
#endif
        |> fun x -> _v178 <- Some x
        let v186 : string = _v178.Value
        let v187 : US0 = US0_1
        let v188 : (unit -> string) = closure30()
        let v189 : (unit -> string) = closure31(v1, v186)
        method9(v187, v188, v189)
        let v190 : string option = None
        return v190 
        (*
        ()
    else
        *) else
        let v191 : int64 = v1 + 1L
        let v192 : Async<string option> = method14(v0, v191)
        return! v192 
        (*
        ()
    *)
    (*
    let v193 : string option = *)
    }
    |> fun x -> _v7 <- Some x
    let v194 : Async<string option> = _v7 |> Option.get
    v194
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v195 : Async<string option> = null |> unbox<Async<string option>>
    v195
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v196 : Async<string option> = Unchecked.defaultof<Async<string option>>
    v196
#endif
    |> fun x -> _v2 <- Some x
    let v197 : Async<string option> = _v2.Value
    v197
and closure24 () (v0 : string) : Async<string option> =
    let v1 : Async<string option> option = None
    let v2 : bool = true in let mutable _v1 = v1
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
    let v6 : int64 = 0L
    let v7 : Async<string option> = method14(v0, v6)
    v7
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v8 : Async<string option> = null |> unbox<Async<string option>>
    v8
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v9 : Async<string option> = Unchecked.defaultof<Async<string option>>
    v9
#endif
    |> fun x -> _v1 <- Some x
    let v10 : Async<string option> = _v1.Value
    v10
and closure33 () () : string =
    let v0 : string option = None
    let v1 : bool = true in let mutable _v0 = v0
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
    let v5 : string = System.Reflection.Assembly.GetEntryAssembly().GetName().Name
    v5
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v6 : string = null |> unbox<string>
    v6
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v7 : string = Unchecked.defaultof<string>
    v7
#endif
    |> fun x -> _v0 <- Some x
    let v8 : string = _v0.Value
    v8
and method16 (v0 : string) : string =
    v0
and method17 (v0 : string) : string =
    v0
and closure32 () () : string =
    let v0 : string option = None
    let v1 : bool = true in let mutable _v0 = v0
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
    let v5 : (unit -> string) = System.IO.Path.GetTempPath
    let v6 : string = v5 ()
    let v7 : (unit -> string) = closure33()
    let v8 : string = $"!{v7 ()}"
    let v9 : string option = None
    let v10 : bool = true in let mutable _v9 = v9
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v11 : string = method7(v6)
    let v12 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v13 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v11 v12
    let v14 : string = "String::from($0)"
    let v15 : std_string_String = Fable.Core.RustInterop.emitRustExpr v13 v14
    let v16 : string = "std::path::PathBuf::from($0)"
    let v17 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v15 v16
    let v18 : string = method7(v8)
    let v19 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v20 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v18 v19
    let v21 : string = "String::from($0)"
    let v22 : std_string_String = Fable.Core.RustInterop.emitRustExpr v20 v21
    let v23 : string = "$0.join($1)"
    let v24 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr struct (v17, v22) v23
    let v25 : string = "$0.display().to_string()"
    let v26 : std_string_String = Fable.Core.RustInterop.emitRustExpr v24 v25
    let v27 : string = "fable_library_rust::String_::fromString($0)"
    let v28 : string = Fable.Core.RustInterop.emitRustExpr v26 v27
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
    let v31 : string = System.IO.Path.Combine (v6, v8)
    v31
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v32 : string = "path"
    let v33 : IPathJoin = Fable.Core.JsInterop.importAll v32
    let v34 : string = method16(v6)
    let v35 : string = method17(v8)
    let v36 : string = "v33.join(v34, v35)"
    let v37 : string = Fable.Core.JsInterop.emitJsExpr () v36
    v37
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v38 : string = Unchecked.defaultof<string>
    v38
#endif
    |> fun x -> _v9 <- Some x
    let v39 : string = _v9.Value
    let v40 : System.DateTime = System.DateTime.Now
    let v41 : System.Guid = System.Guid.NewGuid ()
    let v42 : (System.Guid -> string) = _.ToString()
    let v43 : string = v42 v41
    let v44 : string = v40.ToString "yyyyMMdd-HHmm-ssff-ffff-f"
    let v45 : System.Guid = System.Guid $"{v44}{v43.[v44.Length..]}"
    let v46 : (System.Guid -> string) = _.ToString()
    let v47 : string = v46 v45
    let v48 : string option = None
    let v49 : bool = true in let mutable _v48 = v48
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v50 : string = method7(v39)
    let v51 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v52 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v50 v51
    let v53 : string = "String::from($0)"
    let v54 : std_string_String = Fable.Core.RustInterop.emitRustExpr v52 v53
    let v55 : string = "std::path::PathBuf::from($0)"
    let v56 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v54 v55
    let v57 : string = method7(v47)
    let v58 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v59 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v57 v58
    let v60 : string = "String::from($0)"
    let v61 : std_string_String = Fable.Core.RustInterop.emitRustExpr v59 v60
    let v62 : string = "$0.join($1)"
    let v63 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr struct (v56, v61) v62
    let v64 : string = "$0.display().to_string()"
    let v65 : std_string_String = Fable.Core.RustInterop.emitRustExpr v63 v64
    let v66 : string = "fable_library_rust::String_::fromString($0)"
    let v67 : string = Fable.Core.RustInterop.emitRustExpr v65 v66
    v67
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v68 : string = null |> unbox<string>
    v68
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v69 : string = null |> unbox<string>
    v69
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v70 : string = System.IO.Path.Combine (v39, v47)
    v70
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v71 : IPathJoin = Fable.Core.JsInterop.importAll v32
    let v72 : string = method16(v39)
    let v73 : string = method17(v47)
    let v74 : string = "v71.join(v72, v73)"
    let v75 : string = Fable.Core.JsInterop.emitJsExpr () v74
    v75
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v76 : string = Unchecked.defaultof<string>
    v76
#endif
    |> fun x -> _v48 <- Some x
    let v77 : string = _v48.Value
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
    |> fun x -> _v0 <- Some x
    let v80 : string = _v0.Value
    v80
and closure35 (v0 : string, v1 : string) () : string =
    let v2 : (unit -> string) = closure4()
    let v3 : string = $"temp_folder: {v0} / result: {v1} {v2 ()}"
    v3
and closure36 (v0 : string) () : unit =
    let v1 : Async<int64> option = None
    let v2 : bool = true in let mutable _v1 = v1
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
    let v7 : Async<int64> = method2(v0, v6)
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
    |> fun x -> _v1 <- Some x
    let v10 : Async<int64> = _v1.Value
    let v11 : Async<unit> option = None
    let v12 : bool = true in let mutable _v11 = v11
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v13 : Async<unit> = null |> unbox<Async<unit>>
    v13
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v14 : Async<unit> = null |> unbox<Async<unit>>
    v14
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v15 : Async<unit> = null |> unbox<Async<unit>>
    v15
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v16 : (Async<int64> -> Async<unit>) = Async.Ignore
    let v17 : Async<unit> = v16 v10
    v17
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v18 : Async<unit> = null |> unbox<Async<unit>>
    v18
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v19 : Async<unit> = Unchecked.defaultof<Async<unit>>
    v19
#endif
    |> fun x -> _v11 <- Some x
    let v20 : Async<unit> = _v11.Value
    let v21 : unit option = None
    let v22 : bool = true in let mutable _v21 = v21
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
    let v23 : (Async<unit> -> unit) = Async.RunSynchronously
    v23 v20
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
    |> fun x -> _v21 <- Some x
    _v21.Value
    ()
and closure34 () () : struct (string * System.IDisposable) =
    let v0 : struct (string * System.IDisposable) option = None
    let v1 : bool = true in let mutable _v0 = v0
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let struct (v2 : string, v3 : System.IDisposable) = null |> unbox<struct (string * System.IDisposable)>
    struct (v2, v3)
#endif
    #if FABLE_COMPILER_RUST && WASM
    let struct (v4 : string, v5 : System.IDisposable) = null |> unbox<struct (string * System.IDisposable)>
    struct (v4, v5)
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let struct (v6 : string, v7 : System.IDisposable) = null |> unbox<struct (string * System.IDisposable)>
    struct (v6, v7)
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v8 : string option = None
    let v9 : bool = true in let mutable _v8 = v8
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v10 : string = null |> unbox<string>
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
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v13 : (unit -> string) = System.IO.Path.GetTempPath
    let v14 : string = v13 ()
    let v15 : (unit -> string) = closure33()
    let v16 : string = $"!{v15 ()}"
    let v17 : string option = None
    let v18 : bool = true in let mutable _v17 = v17
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v19 : string = method7(v14)
    let v20 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v21 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v19 v20
    let v22 : string = "String::from($0)"
    let v23 : std_string_String = Fable.Core.RustInterop.emitRustExpr v21 v22
    let v24 : string = "std::path::PathBuf::from($0)"
    let v25 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v23 v24
    let v26 : string = method7(v16)
    let v27 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v28 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v26 v27
    let v29 : string = "String::from($0)"
    let v30 : std_string_String = Fable.Core.RustInterop.emitRustExpr v28 v29
    let v31 : string = "$0.join($1)"
    let v32 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr struct (v25, v30) v31
    let v33 : string = "$0.display().to_string()"
    let v34 : std_string_String = Fable.Core.RustInterop.emitRustExpr v32 v33
    let v35 : string = "fable_library_rust::String_::fromString($0)"
    let v36 : string = Fable.Core.RustInterop.emitRustExpr v34 v35
    v36
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v37 : string = null |> unbox<string>
    v37
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v38 : string = null |> unbox<string>
    v38
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v39 : string = System.IO.Path.Combine (v14, v16)
    v39
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v40 : string = "path"
    let v41 : IPathJoin = Fable.Core.JsInterop.importAll v40
    let v42 : string = method16(v14)
    let v43 : string = method17(v16)
    let v44 : string = "v41.join(v42, v43)"
    let v45 : string = Fable.Core.JsInterop.emitJsExpr () v44
    v45
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v46 : string = Unchecked.defaultof<string>
    v46
#endif
    |> fun x -> _v17 <- Some x
    let v47 : string = _v17.Value
    let v48 : System.DateTime = System.DateTime.Now
    let v49 : System.Guid = System.Guid.NewGuid ()
    let v50 : (System.Guid -> string) = _.ToString()
    let v51 : string = v50 v49
    let v52 : string = v48.ToString "yyyyMMdd-HHmm-ssff-ffff-f"
    let v53 : System.Guid = System.Guid $"{v52}{v51.[v52.Length..]}"
    let v54 : (System.Guid -> string) = _.ToString()
    let v55 : string = v54 v53
    let v56 : string option = None
    let v57 : bool = true in let mutable _v56 = v56
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v58 : string = method7(v47)
    let v59 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v60 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v58 v59
    let v61 : string = "String::from($0)"
    let v62 : std_string_String = Fable.Core.RustInterop.emitRustExpr v60 v61
    let v63 : string = "std::path::PathBuf::from($0)"
    let v64 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v62 v63
    let v65 : string = method7(v55)
    let v66 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v67 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v65 v66
    let v68 : string = "String::from($0)"
    let v69 : std_string_String = Fable.Core.RustInterop.emitRustExpr v67 v68
    let v70 : string = "$0.join($1)"
    let v71 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr struct (v64, v69) v70
    let v72 : string = "$0.display().to_string()"
    let v73 : std_string_String = Fable.Core.RustInterop.emitRustExpr v71 v72
    let v74 : string = "fable_library_rust::String_::fromString($0)"
    let v75 : string = Fable.Core.RustInterop.emitRustExpr v73 v74
    v75
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v76 : string = null |> unbox<string>
    v76
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v77 : string = null |> unbox<string>
    v77
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v78 : string = System.IO.Path.Combine (v47, v55)
    v78
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v79 : IPathJoin = Fable.Core.JsInterop.importAll v40
    let v80 : string = method16(v47)
    let v81 : string = method17(v55)
    let v82 : string = "v79.join(v80, v81)"
    let v83 : string = Fable.Core.JsInterop.emitJsExpr () v82
    v83
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v84 : string = Unchecked.defaultof<string>
    v84
#endif
    |> fun x -> _v56 <- Some x
    let v85 : string = _v56.Value
    v85
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v86 : string = null |> unbox<string>
    v86
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v87 : string = Unchecked.defaultof<string>
    v87
#endif
    |> fun x -> _v8 <- Some x
    let v88 : string = _v8.Value
    let v89 : System.IO.DirectoryInfo option = None
    let v90 : bool = true in let mutable _v89 = v89
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v91 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    v91
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v92 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    v92
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v93 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    v93
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v94 : (string -> System.IO.DirectoryInfo) = System.IO.Directory.CreateDirectory
    let v95 : System.IO.DirectoryInfo = v94 v88
    v95
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v96 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    v96
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v97 : System.IO.DirectoryInfo = Unchecked.defaultof<System.IO.DirectoryInfo>
    v97
#endif
    |> fun x -> _v89 <- Some x
    let v98 : System.IO.DirectoryInfo = _v89.Value
    let v99 : bool option = None
    let v100 : bool = true in let mutable _v99 = v99
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v101 : bool = null |> unbox<bool>
    v101
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v102 : bool = null |> unbox<bool>
    v102
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v103 : bool = null |> unbox<bool>
    v103
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v104 : bool = v98.Exists
    v104
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v105 : bool = null |> unbox<bool>
    v105
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v106 : bool = Unchecked.defaultof<bool>
    v106
#endif
    |> fun x -> _v99 <- Some x
    let v107 : bool = _v99.Value
    let v108 : bool = v107 = false
    if v108 then
        let v109 : System.DateTime option = None
        let v110 : bool = true in let mutable _v109 = v109
        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v111 : System.DateTime = null |> unbox<System.DateTime>
        v111
#endif
        #if FABLE_COMPILER_RUST && WASM
        let v112 : System.DateTime = null |> unbox<System.DateTime>
        v112
#endif
        #if FABLE_COMPILER_RUST && CONTRACT
        let v113 : System.DateTime = null |> unbox<System.DateTime>
        v113
#endif
        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
        let v114 : System.DateTime = v98.CreationTime
        v114
#endif
        #if FABLE_COMPILER_TYPESCRIPT
        let v115 : System.DateTime = null |> unbox<System.DateTime>
        v115
#endif
        #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
        let v116 : System.DateTime = Unchecked.defaultof<System.DateTime>
        v116
#endif
        |> fun x -> _v109 <- Some x
        let v117 : System.DateTime = _v109.Value
        let v118 : obj = {| Exists = v107; CreationTime = v117 |}
        let v119 : string = $"%A{v118}"
        let v120 : (unit -> string) = closure35(v88, v119)
        let v121 : string = $"create_temp_directory / {v120 ()}"
        System.Console.WriteLine v121
        ()
    let v122 : System.IDisposable option = None
    let v123 : bool = true in let mutable _v122 = v122
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v124 : System.IDisposable = null |> unbox<System.IDisposable>
    v124
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v125 : System.IDisposable = null |> unbox<System.IDisposable>
    v125
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v126 : System.IDisposable = null |> unbox<System.IDisposable>
    v126
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v127 : (unit -> unit) = closure36(v88)
    let v128 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v127 () }
    v128
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v129 : System.IDisposable = null |> unbox<System.IDisposable>
    v129
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v130 : System.IDisposable = Unchecked.defaultof<System.IDisposable>
    v130
#endif
    |> fun x -> _v122 <- Some x
    let v131 : System.IDisposable = _v122.Value
    struct (v88, v131)
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let struct (v132 : string, v133 : System.IDisposable) = null |> unbox<struct (string * System.IDisposable)>
    struct (v132, v133)
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let struct (v134 : string, v135 : System.IDisposable) = Unchecked.defaultof<struct (string * System.IDisposable)>
    struct (v134, v135)
#endif
    |> fun x -> _v0 <- Some x
    let struct (v136 : string, v137 : System.IDisposable) = _v0.Value
    struct (v136, v137)
and closure37 () () : string =
    let v0 : string = __SOURCE_DIRECTORY__
    v0
and closure41 () (v0 : string) : bool =
    let v1 : bool option = None
    let v2 : bool = true in let mutable _v1 = v1
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : string = method7(v0)
    let v4 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v5 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v3 v4
    let v6 : string = "String::from($0)"
    let v7 : std_string_String = Fable.Core.RustInterop.emitRustExpr v5 v6
    let v8 : string = "std::path::PathBuf::from($0)"
    let v9 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v7 v8
    let v10 : string = "$0.exists()"
    let v11 : bool = Fable.Core.RustInterop.emitRustExpr v9 v10
    let v14 : bool =
        if v11 then
            let v12 : string = "$0.is_file()"
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
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v17 : (string -> bool) = System.IO.File.Exists
    let v18 : bool = v17 v0
    v18
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v19 : string = "fs"
    let v20 : IFsExistsSync = Fable.Core.JsInterop.importAll v19
    let v21 : string = "v20.existsSync($0)"
    let v22 : bool = Fable.Core.JsInterop.emitJsExpr v0 v21
    v22
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v23 : bool = Unchecked.defaultof<bool>
    v23
#endif
    |> fun x -> _v1 <- Some x
    let v24 : bool = _v1.Value
    v24
and closure42 () (v0 : string) : bool =
    let v1 : bool option = None
    let v2 : bool = true in let mutable _v1 = v1
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : string = method7(v0)
    let v4 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v5 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v3 v4
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
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v17 : (string -> bool) = System.IO.Directory.Exists
    let v18 : bool = v17 v0
    v18
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v19 : string = "fs"
    let v20 : IFsExistsSync = Fable.Core.JsInterop.importAll v19
    let v21 : string = "v20.existsSync($0)"
    let v22 : bool = Fable.Core.JsInterop.emitJsExpr v0 v21
    v22
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v23 : bool = Unchecked.defaultof<bool>
    v23
#endif
    |> fun x -> _v1 <- Some x
    let v24 : bool = _v1.Value
    v24
and closure43 () (v0 : string) : string option =
    let v1 : US8 option = None
    let v2 : bool = true in let mutable _v1 = v1
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : string = method7(v0)
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
    let v18 : US8 = US8_0(v17)
    v18
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v19 : US8 = null |> unbox<US8>
    v19
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v20 : US8 = null |> unbox<US8>
    v20
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v21 : (string -> System.IO.DirectoryInfo) = System.IO.Directory.GetParent
    let v22 : System.IO.DirectoryInfo = v21 v0
    let v23 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    let v24 : bool = v22 = v23
    let v36 : US8 =
        if v24 then
            US8_1
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
            US8_0(v34)
    v36
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v37 : string = "path"
    let v38 : IPathDirname = Fable.Core.JsInterop.importAll v37
    let v39 : string = "v38.dirname($0)"
    let v40 : string = Fable.Core.JsInterop.emitJsExpr v0 v39
    let v41 : US8 = US8_0(v40)
    v41
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v42 : US8 = Unchecked.defaultof<US8>
    v42
#endif
    |> fun x -> _v1 <- Some x
    let v43 : US8 = _v1.Value
    match v43 with
    | US8_1 -> (* None *)
        let v46 : string option = None
        v46
    | US8_0(v44) -> (* Some *)
        let v45 : string option = Some v44 
        v45
and method19 () : (string -> string option) =
    closure43()
and closure44 () (v0 : string) : US8 =
    US8_0(v0)
and method20 () : (string -> US8) =
    closure44()
and method21 (v0 : string, v1 : bool, v2 : string, v3 : string) : string =
    let v4 : string option = None
    let v5 : bool = true in let mutable _v4 = v4
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v6 : string = method7(v3)
    let v7 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v8 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v7
    let v9 : string = "String::from($0)"
    let v10 : std_string_String = Fable.Core.RustInterop.emitRustExpr v8 v9
    let v11 : string = "std::path::PathBuf::from($0)"
    let v12 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v10 v11
    let v13 : string = method7(v0)
    let v14 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v15 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v13 v14
    let v16 : string = "String::from($0)"
    let v17 : std_string_String = Fable.Core.RustInterop.emitRustExpr v15 v16
    let v18 : string = "$0.join($1)"
    let v19 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr struct (v12, v17) v18
    let v20 : string = "$0.display().to_string()"
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
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v26 : string = System.IO.Path.Combine (v3, v0)
    v26
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v27 : string = "path"
    let v28 : IPathJoin = Fable.Core.JsInterop.importAll v27
    let v29 : string = method16(v3)
    let v30 : string = method17(v0)
    let v31 : string = "v28.join(v29, v30)"
    let v32 : string = Fable.Core.JsInterop.emitJsExpr () v31
    v32
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v33 : string = Unchecked.defaultof<string>
    v33
#endif
    |> fun x -> _v4 <- Some x
    let v34 : string = _v4.Value
    let v37 : (string -> bool) =
        if v1 then
            closure41()
        else
            closure42()
    let v38 : bool = v37 v34
    if v38 then
        v3
    else
        let v39 : (string -> string option) = method19()
        let v40 : string option = v39 v3
        let v41 : (string -> US8) = method20()
        let v42 : US8 = US8_1
        let v43 : US8 = v40 |> Option.map v41 |> Option.defaultValue v42 
        match v43 with
        | US8_1 -> (* None *)
            let v46 : string = $"""No parent for {if v1 then "file" else "dir"} '{v0}' at '{v2}' (until '{v3}')"""
            failwith<string> v46
        | US8_0(v44) -> (* Some *)
            method21(v0, v1, v2, v44)
and method18 (v0 : string, v1 : bool, v2 : string) : string =
    let v3 : string option = None
    let v4 : bool = true in let mutable _v3 = v3
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v5 : string = method7(v2)
    let v6 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v7 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v6
    let v8 : string = "String::from($0)"
    let v9 : std_string_String = Fable.Core.RustInterop.emitRustExpr v7 v8
    let v10 : string = "std::path::PathBuf::from($0)"
    let v11 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v9 v10
    let v12 : string = method7(v0)
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
    let v28 : string = method16(v2)
    let v29 : string = method17(v0)
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
    let v36 : (string -> bool) =
        if v1 then
            closure41()
        else
            closure42()
    let v37 : bool = v36 v33
    if v37 then
        v2
    else
        let v38 : (string -> string option) = method19()
        let v39 : string option = v38 v2
        let v40 : (string -> US8) = method20()
        let v41 : US8 = US8_1
        let v42 : US8 = v39 |> Option.map v40 |> Option.defaultValue v41 
        match v42 with
        | US8_1 -> (* None *)
            let v45 : string = $"""No parent for {if v1 then "file" else "dir"} '{v0}' at '{v2}' (until '{v2}')"""
            failwith<string> v45
        | US8_0(v43) -> (* Some *)
            method21(v0, v1, v2, v43)
and closure40 (v0 : string, v1 : bool) (v2 : string) : string =
    method18(v0, v1, v2)
and closure39 (v0 : string) (v1 : bool) : (string -> string) =
    closure40(v0, v1)
and closure38 () (v0 : string) : (bool -> (string -> string)) =
    closure39(v0)
and method22 () : string =
    let v0 : string = "polyglot"
    v0
and method23 () : string =
    let v0 : string = ".paket"
    v0
and method24 () : string =
    let v0 : string = "polyglot"
    v0
and method25 () : string =
    let v0 : string = ".paket"
    v0
and method27 (v0 : string, v1 : string, v2 : string) : string =
    let v3 : string option = None
    let v4 : bool = true in let mutable _v3 = v3
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v5 : string = method7(v2)
    let v6 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v7 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v6
    let v8 : string = "String::from($0)"
    let v9 : std_string_String = Fable.Core.RustInterop.emitRustExpr v7 v8
    let v10 : string = "std::path::PathBuf::from($0)"
    let v11 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v9 v10
    let v12 : string = method7(v0)
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
    let v28 : string = method16(v2)
    let v29 : string = method17(v0)
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
    let v36 : string = method7(v33)
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
        let v58 : (string -> string option) = method19()
        let v59 : string option = v58 v2
        let v60 : (string -> US8) = method20()
        let v61 : US8 = US8_1
        let v62 : US8 = v59 |> Option.map v60 |> Option.defaultValue v61 
        match v62 with
        | US8_1 -> (* None *)
            let v65 : string = $"""No parent for {if false then "file" else "dir"} '{v0}' at '{v1}' (until '{v2}')"""
            failwith<string> v65
        | US8_0(v63) -> (* Some *)
            method27(v0, v1, v63)
and method26 (v0 : string, v1 : string) : string =
    let v2 : string option = None
    let v3 : bool = true in let mutable _v2 = v2
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v4 : string = method7(v1)
    let v5 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v6 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v4 v5
    let v7 : string = "String::from($0)"
    let v8 : std_string_String = Fable.Core.RustInterop.emitRustExpr v6 v7
    let v9 : string = "std::path::PathBuf::from($0)"
    let v10 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v8 v9
    let v11 : string = method7(v0)
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
    let v27 : string = method16(v1)
    let v28 : string = method17(v0)
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
    let v35 : string = method7(v32)
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
        let v57 : (string -> string option) = method19()
        let v58 : string option = v57 v1
        let v59 : (string -> US8) = method20()
        let v60 : US8 = US8_1
        let v61 : US8 = v58 |> Option.map v59 |> Option.defaultValue v60 
        match v61 with
        | US8_1 -> (* None *)
            let v64 : string = $"""No parent for {if false then "file" else "dir"} '{v0}' at '{v1}' (until '{v1}')"""
            failwith<string> v64
        | US8_0(v62) -> (* Some *)
            method27(v0, v1, v62)
and method28 () : string =
    let v0 : string = "polyglot"
    v0
and closure45 () () : string =
    let v0 : string = __SOURCE_DIRECTORY__
    let v1 : string option = None
    let v2 : bool = true in let mutable _v1 = v1
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : string = method22()
    let v4 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v5 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v3 v4
    let v6 : string = "String::from($0)"
    let v7 : std_string_String = Fable.Core.RustInterop.emitRustExpr v5 v6
    let v8 : string = "std::path::PathBuf::from($0)"
    let v9 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v7 v8
    let v10 : string = method23()
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
    let v28 : string = method24()
    let v29 : string = method25()
    let v30 : string = "v27.join(v28, v29)"
    let v31 : string = Fable.Core.JsInterop.emitJsExpr () v30
    v31
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v32 : string = Unchecked.defaultof<string>
    v32
#endif
    |> fun x -> _v1 <- Some x
    let v33 : string = _v1.Value
    let v34 : string = method26(v33, v0)
    let v35 : string option = None
    let v36 : bool = true in let mutable _v35 = v35
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v37 : string = method7(v34)
    let v38 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v39 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v37 v38
    let v40 : string = "String::from($0)"
    let v41 : std_string_String = Fable.Core.RustInterop.emitRustExpr v39 v40
    let v42 : string = "std::path::PathBuf::from($0)"
    let v43 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v41 v42
    let v44 : string = method22()
    let v45 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v46 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v44 v45
    let v47 : string = "String::from($0)"
    let v48 : std_string_String = Fable.Core.RustInterop.emitRustExpr v46 v47
    let v49 : string = "$0.join($1)"
    let v50 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr struct (v43, v48) v49
    let v51 : string = "$0.display().to_string()"
    let v52 : std_string_String = Fable.Core.RustInterop.emitRustExpr v50 v51
    let v53 : string = "fable_library_rust::String_::fromString($0)"
    let v54 : string = Fable.Core.RustInterop.emitRustExpr v52 v53
    v54
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v55 : string = null |> unbox<string>
    v55
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v56 : string = null |> unbox<string>
    v56
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v57 : string = System.IO.Path.Combine (v34, v23)
    v57
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v58 : IPathJoin = Fable.Core.JsInterop.importAll v26
    let v59 : string = method16(v34)
    let v60 : string = method28()
    let v61 : string = "v58.join(v59, v60)"
    let v62 : string = Fable.Core.JsInterop.emitJsExpr () v61
    v62
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v63 : string = Unchecked.defaultof<string>
    v63
#endif
    |> fun x -> _v35 <- Some x
    let v64 : string = _v35.Value
    v64
and closure47 (v0 : string) (v1 : string) : string =
    let v2 : string option = None
    let v3 : bool = true in let mutable _v2 = v2
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v4 : string = method7(v0)
    let v5 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v6 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v4 v5
    let v7 : string = "String::from($0)"
    let v8 : std_string_String = Fable.Core.RustInterop.emitRustExpr v6 v7
    let v9 : string = "std::path::PathBuf::from($0)"
    let v10 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v8 v9
    let v11 : string = method7(v1)
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
    let v24 : string = System.IO.Path.Combine (v0, v1)
    v24
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v25 : string = "path"
    let v26 : IPathJoin = Fable.Core.JsInterop.importAll v25
    let v27 : string = method16(v0)
    let v28 : string = method17(v1)
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
    v32
and closure46 () (v0 : string) : (string -> string) =
    closure47(v0)
let v0 : (unit -> struct (Mut0 * Mut1 * Mut1 * Mut2 * int64 option)) = closure0()
if State.trace_state = None then State.trace_state <- v0 () |> Some
let v1 : (string -> Async<int64>) = closure1()
let delete_directory_async x = v1 x
let v2 : (US2 -> (string -> Async<int64>)) = closure5()
let wait_for_file_access x = v2 x
let v3 : (string -> Async<int64>) = closure8()
let wait_for_file_access_read x = v3 x
let v4 : (string -> Async<string>) = closure9()
let read_all_text_async x = v4 x
let v5 : (string -> (string -> Async<bool>)) = closure10()
let file_exists_content x = v5 x
let v6 : (string -> (string -> Async<unit>)) = closure12()
let write_all_text_async x = v6 x
let v7 : (string -> (string -> Async<unit>)) = closure14()
let write_all_text_exists x = v7 x
let v8 : (string -> Async<int64>) = closure16()
let delete_file_async x = v8 x
let v9 : (string -> (string -> Async<int64>)) = closure20()
let move_file_async x = v9 x
let v10 : (string -> Async<string option>) = closure24()
let read_all_text_retry_async x = v10 x
let v11 : (unit -> string) = closure32()
let create_temp_directory_name () = v11 ()
let v12 : (unit -> struct (string * System.IDisposable)) = closure34()
let create_temp_directory () = v12 ()
let v13 : (unit -> string) = closure37()
let get_source_directory () = v13 ()
let v14 : (string -> (bool -> (string -> string))) = closure38()
let find_parent x = v14 x
let v15 : (unit -> string) = closure45()
let get_repository_root () = v15 ()
let v16 : (string -> (string -> string)) = closure46()
let (</>) x = v16 x
()
