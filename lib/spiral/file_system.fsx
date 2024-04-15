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
    let v22 : US1 =
        if v16 then
            let v17 : System.DateTime = System.DateTime.Now
            let v18 : (System.DateTime -> int64) = _.Ticks
            let v19 : int64 = v18 v17
            US1_0(v19)
        else
            US1_1
    let v27 : int64 option =
        match v22 with
        | US1_1 -> (* None *)
            let v25 : int64 option = None
            v25
        | US1_0(v23) -> (* Some *)
            let v24 : int64 option = Some v23 
            v24
    let v28 : int64 option = method0(v27)
    v28 
    #else
    let v29 : int64 option = None
    let v30 : int64 option = method1(v29)
    v30 
    #endif
    |> fun x -> _v5 <- Some x
    let v31 : int64 option = _v5.Value
    struct (v1, v4, v0, v3, v31)
and closure3 () (v0 : string) : string =
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
        let v19 : (unit -> string) = closure2(v0, v18)
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
    let v31 : Async<int64> = method2(v0, v30)
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
and closure1 () (v0 : string) : Async<int64> =
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
    let v6 : Async<int64> = method2(v0, v5)
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
and method5 (v0 : string, v1 : int64, v2 : string) : string =
    let v3 : (string -> string) = closure3()
    let v4 : (unit -> string) = closure4()
    let v5 : string = $"path: {v0 |> v3} / retry: {v1} / ex: {v2} / {v4 ()}"
    v5
and closure7 (v0 : string, v1 : int64, v2 : string) () : string =
    method5(v0, v1, v2)
and method4 (v0 : string, v1 : US4, v2 : US3, v3 : int64) : Async<int64> =
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
        | US3_0 -> (* AccessRead *)
            let v14 : System.IO.FileAccess = System.IO.FileAccess.Read
            v14
        | US3_2 -> (* AccessReadWrite *)
            let v16 : System.IO.FileAccess = System.IO.FileAccess.ReadWrite
            v16
        | US3_1 -> (* AccessWrite *)
            let v15 : System.IO.FileAccess = System.IO.FileAccess.ReadWrite
            v15
    let v29 : System.IO.FileShare =
        match v1 with
        | US4_4 -> (* ShareDelete *)
            let v24 : System.IO.FileShare = System.IO.FileShare.Delete
            v24
        | US4_0 -> (* ShareNone *)
            let v20 : System.IO.FileShare = System.IO.FileShare.None
            v20
        | US4_1 -> (* ShareRead *)
            let v21 : System.IO.FileShare = System.IO.FileShare.Read
            v21
        | US4_3 -> (* ShareReadWrite *)
            let v23 : System.IO.FileShare = System.IO.FileShare.ReadWrite
            v23
        | US4_2 -> (* ShareWrite *)
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
        let v48 : (unit -> string) = closure7(v0, v3, v47)
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
    let v60 : Async<int64> = method4(v0, v1, v2, v59)
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
and closure6 (v0 : US2) (v1 : string) : Async<int64> =
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
    let struct (v12 : US3, v13 : US4) =
        match v0 with
        | US2_1 -> (* None *)
            let v8 : US3 = US3_2
            let v9 : US4 = US4_1
            struct (v8, v9)
        | US2_0(v6, v7) -> (* Some *)
            struct (v6, v7)
    let v14 : int64 = 0L
    let v15 : Async<int64> = method4(v1, v13, v12, v14)
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
and closure5 () (v0 : US2) : (string -> Async<int64>) =
    closure6(v0)
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
        let v32 : (unit -> string) = closure7(v0, v1, v31)
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
    let v44 : Async<int64> = method6(v0, v43)
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
and closure8 () (v0 : string) : Async<int64> =
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
and closure9 () (v0 : string) : Async<string> =
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
and method7 (v0 : string) : string =
    v0
and closure11 (v0 : string) (v1 : string) : Async<bool> =
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
    let v12 : string = method7(v0)
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
and closure10 () (v0 : string) : (string -> Async<bool>) =
    closure11(v0)
and closure13 (v0 : string) (v1 : string) : Async<unit> =
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
and closure12 () (v0 : string) : (string -> Async<unit>) =
    closure13(v0)
and closure15 (v0 : string) (v1 : string) : Async<unit> =
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
    let v17 : string = method7(v0)
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
        | US0_4 -> (* Critical *)
            let v66 : string = "Critical"
            v66
        | US0_1 -> (* Debug *)
            let v63 : string = "Debug"
            v63
        | US0_2 -> (* Info *)
            let v64 : string = "Info"
            v64
        | US0_0 -> (* Verbose *)
            let v62 : string = "Verbose"
            v62
        | US0_3 -> (* Warning *)
            let v65 : string = "Warning"
            v65
    let v72 : string = v71.ToLower ()
    let v73 : string option = None
    let mutable _v73 = v73
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v88 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v82 : string = "inline_colorization::color_bright_red"
            let v83 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v82
            v83
        | US0_1 -> (* Debug *)
            let v76 : string = "inline_colorization::color_bright_blue"
            let v77 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v76
            v77
        | US0_2 -> (* Info *)
            let v78 : string = "inline_colorization::color_bright_green"
            let v79 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v78
            v79
        | US0_0 -> (* Verbose *)
            let v74 : string = "inline_colorization::color_bright_black"
            let v75 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v74
            v75
        | US0_3 -> (* Warning *)
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
        | US0_4 -> (* Critical *)
            let v106 : string = "inline_colorization::color_bright_red"
            let v107 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v106
            v107
        | US0_1 -> (* Debug *)
            let v100 : string = "inline_colorization::color_bright_blue"
            let v101 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v100
            v101
        | US0_2 -> (* Info *)
            let v102 : string = "inline_colorization::color_bright_green"
            let v103 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v102
            v103
        | US0_0 -> (* Verbose *)
            let v98 : string = "inline_colorization::color_bright_black"
            let v99 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v98
            v99
        | US0_3 -> (* Warning *)
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
        | US0_4 -> (* Critical *)
            let v130 : string = "inline_colorization::color_bright_red"
            let v131 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v130
            v131
        | US0_1 -> (* Debug *)
            let v124 : string = "inline_colorization::color_bright_blue"
            let v125 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v124
            v125
        | US0_2 -> (* Info *)
            let v126 : string = "inline_colorization::color_bright_green"
            let v127 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v126
            v127
        | US0_0 -> (* Verbose *)
            let v122 : string = "inline_colorization::color_bright_black"
            let v123 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v122
            v123
        | US0_3 -> (* Warning *)
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
and method8 (v0 : string, v1 : int64) : Async<int64> =
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
        let v20 : US0 = US0_3
        let v21 : (unit -> string) = closure17()
        let v22 : (unit -> string) = closure4()
        method9(v20, v21, v22)
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
    let v33 : Async<int64> = method8(v0, v32)
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
and closure16 () (v0 : string) : Async<int64> =
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
    let v6 : Async<int64> = method8(v0, v5)
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
    let v11 : (string -> string) = closure3()
    let v12 : (unit -> string) = closure4()
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
        let v12 : US0 = US0_3
        let v13 : (unit -> string) = closure22()
        let v14 : (unit -> string) = closure23(v0, v1, v9)
        method9(v12, v13, v14)
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
        let v13 : Async<int64> = method6(v0, v12)
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
                    let v92 : US0 = US0_1
                    let v93 : (unit -> string) = closure27()
                    let v94 : (unit -> string) = closure28()
                    method9(v92, v93, v94)
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
                    let v104 : US0 = US0_4
                    let v105 : (unit -> string) = closure29(v103)
                    let v106 : (unit -> string) = closure28()
                    method9(v104, v105, v106)
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
        let v171 : US0 = US0_1
        let v172 : (unit -> string) = closure30()
        let v173 : (unit -> string) = closure31(v1, v170)
        method9(v171, v172, v173)
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
and method16 (v0 : string) : string =
    v0
and method17 (v0 : string) : string =
    v0
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
    let v9 : string = method7(v5)
    let v10 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v11 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v9 v10
    let v12 : string = "String::from($0)"
    let v13 : std_string_String = Fable.Core.RustInterop.emitRustExpr v11 v12
    let v14 : string = "std::path::PathBuf::from($0)"
    let v15 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v13 v14
    let v16 : string = method7(v7)
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
    let v32 : string = method16(v5)
    let v33 : string = method17(v7)
    let v34 : string = "v31.join(v32, v33)"
    let v35 : string = Fable.Core.JsInterop.emitJsExpr () v34
    v35 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v36 : string = Unchecked.defaultof<string>
    v36 
    #endif
    |> fun x -> _v8 <- Some x
    let v37 : string = _v8.Value
    let v38 : System.DateTime = System.DateTime.Now
    let v39 : System.Guid = System.Guid.NewGuid ()
    let v40 : (System.Guid -> string) = _.ToString()
    let v41 : string = v40 v39
    let v42 : string = v38.ToString "yyyyMMdd-HHmm-ssff-ffff-f"
    let v43 : System.Guid = System.Guid $"{v42}{v41.[v42.Length..]}"
    let v44 : (System.Guid -> string) = _.ToString()
    let v45 : string = v44 v43
    let v46 : string option = None
    let mutable _v46 = v46
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v47 : string = method7(v37)
    let v48 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v49 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v47 v48
    let v50 : string = "String::from($0)"
    let v51 : std_string_String = Fable.Core.RustInterop.emitRustExpr v49 v50
    let v52 : string = "std::path::PathBuf::from($0)"
    let v53 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v51 v52
    let v54 : string = method7(v45)
    let v55 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v56 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v54 v55
    let v57 : string = "String::from($0)"
    let v58 : std_string_String = Fable.Core.RustInterop.emitRustExpr v56 v57
    let v59 : string = "$0.join($1)"
    let v60 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr struct (v53, v58) v59
    let v61 : string = "$0.display().to_string()"
    let v62 : std_string_String = Fable.Core.RustInterop.emitRustExpr v60 v61
    let v63 : string = "fable_library_rust::String_::fromString($0)"
    let v64 : string = Fable.Core.RustInterop.emitRustExpr v62 v63
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
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v67 : string = System.IO.Path.Combine (v37, v45)
    v67 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v68 : IPathJoin = Fable.Core.JsInterop.importAll v30
    let v69 : string = method16(v37)
    let v70 : string = method17(v45)
    let v71 : string = "v68.join(v69, v70)"
    let v72 : string = Fable.Core.JsInterop.emitJsExpr () v71
    v72 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v73 : string = Unchecked.defaultof<string>
    v73 
    #endif
    |> fun x -> _v46 <- Some x
    let v74 : string = _v46.Value
    v74 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v75 : string = null |> unbox<string>
    v75 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v76 : string = Unchecked.defaultof<string>
    v76 
    #endif
    |> fun x -> _v0 <- Some x
    let v77 : string = _v0.Value
    v77
and closure35 (v0 : string, v1 : string) () : string =
    let v2 : (unit -> string) = closure4()
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
    let v6 : Async<int64> = method2(v0, v5)
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
    let v16 : string = method7(v12)
    let v17 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v18 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v16 v17
    let v19 : string = "String::from($0)"
    let v20 : std_string_String = Fable.Core.RustInterop.emitRustExpr v18 v19
    let v21 : string = "std::path::PathBuf::from($0)"
    let v22 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v20 v21
    let v23 : string = method7(v14)
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
    let v39 : string = method16(v12)
    let v40 : string = method17(v14)
    let v41 : string = "v38.join(v39, v40)"
    let v42 : string = Fable.Core.JsInterop.emitJsExpr () v41
    v42 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v43 : string = Unchecked.defaultof<string>
    v43 
    #endif
    |> fun x -> _v15 <- Some x
    let v44 : string = _v15.Value
    let v45 : System.DateTime = System.DateTime.Now
    let v46 : System.Guid = System.Guid.NewGuid ()
    let v47 : (System.Guid -> string) = _.ToString()
    let v48 : string = v47 v46
    let v49 : string = v45.ToString "yyyyMMdd-HHmm-ssff-ffff-f"
    let v50 : System.Guid = System.Guid $"{v49}{v48.[v49.Length..]}"
    let v51 : (System.Guid -> string) = _.ToString()
    let v52 : string = v51 v50
    let v53 : string option = None
    let mutable _v53 = v53
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v54 : string = method7(v44)
    let v55 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v56 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v54 v55
    let v57 : string = "String::from($0)"
    let v58 : std_string_String = Fable.Core.RustInterop.emitRustExpr v56 v57
    let v59 : string = "std::path::PathBuf::from($0)"
    let v60 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v58 v59
    let v61 : string = method7(v52)
    let v62 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v63 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v61 v62
    let v64 : string = "String::from($0)"
    let v65 : std_string_String = Fable.Core.RustInterop.emitRustExpr v63 v64
    let v66 : string = "$0.join($1)"
    let v67 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr struct (v60, v65) v66
    let v68 : string = "$0.display().to_string()"
    let v69 : std_string_String = Fable.Core.RustInterop.emitRustExpr v67 v68
    let v70 : string = "fable_library_rust::String_::fromString($0)"
    let v71 : string = Fable.Core.RustInterop.emitRustExpr v69 v70
    v71 
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v72 : string = null |> unbox<string>
    v72 
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v73 : string = null |> unbox<string>
    v73 
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v74 : string = System.IO.Path.Combine (v44, v52)
    v74 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v75 : IPathJoin = Fable.Core.JsInterop.importAll v37
    let v76 : string = method16(v44)
    let v77 : string = method17(v52)
    let v78 : string = "v75.join(v76, v77)"
    let v79 : string = Fable.Core.JsInterop.emitJsExpr () v78
    v79 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v80 : string = Unchecked.defaultof<string>
    v80 
    #endif
    |> fun x -> _v53 <- Some x
    let v81 : string = _v53.Value
    v81 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v82 : string = null |> unbox<string>
    v82 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v83 : string = Unchecked.defaultof<string>
    v83 
    #endif
    |> fun x -> _v7 <- Some x
    let v84 : string = _v7.Value
    let v85 : System.IO.DirectoryInfo option = None
    let mutable _v85 = v85
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v86 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    v86 
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v87 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    v87 
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v88 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    v88 
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v89 : (string -> System.IO.DirectoryInfo) = System.IO.Directory.CreateDirectory
    let v90 : System.IO.DirectoryInfo = v89 v84
    v90 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v91 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    v91 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v92 : System.IO.DirectoryInfo = Unchecked.defaultof<System.IO.DirectoryInfo>
    v92 
    #endif
    |> fun x -> _v85 <- Some x
    let v93 : System.IO.DirectoryInfo = _v85.Value
    let v94 : bool option = None
    let mutable _v94 = v94
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v95 : bool = null |> unbox<bool>
    v95 
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v96 : bool = null |> unbox<bool>
    v96 
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v97 : bool = null |> unbox<bool>
    v97 
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v98 : bool = v93.Exists
    v98 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v99 : bool = null |> unbox<bool>
    v99 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v100 : bool = Unchecked.defaultof<bool>
    v100 
    #endif
    |> fun x -> _v94 <- Some x
    let v101 : bool = _v94.Value
    let v102 : bool = v101 = false
    if v102 then
        let v103 : System.DateTime option = None
        let mutable _v103 = v103
        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v104 : System.DateTime = null |> unbox<System.DateTime>
        v104 
        #endif
        #if FABLE_COMPILER_RUST && WASM
        let v105 : System.DateTime = null |> unbox<System.DateTime>
        v105 
        #endif
        #if FABLE_COMPILER_RUST && CONTRACT
        let v106 : System.DateTime = null |> unbox<System.DateTime>
        v106 
        #endif
        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
        let v107 : System.DateTime = v93.CreationTime
        v107 
        #endif
        #if FABLE_COMPILER_TYPESCRIPT
        let v108 : System.DateTime = null |> unbox<System.DateTime>
        v108 
        #endif
        #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
        let v109 : System.DateTime = Unchecked.defaultof<System.DateTime>
        v109 
        #endif
        |> fun x -> _v103 <- Some x
        let v110 : System.DateTime = _v103.Value
        let v111 : obj = {| Exists = v101; CreationTime = v110 |}
        let v112 : string = $"%A{v111}"
        let v113 : (unit -> string) = closure35(v84, v112)
        let v114 : string = $"create_temp_directory / {v113 ()}"
        System.Console.WriteLine v114
        ()
    let v115 : System.IDisposable option = None
    let mutable _v115 = v115
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v116 : System.IDisposable = null |> unbox<System.IDisposable>
    v116 
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v117 : System.IDisposable = null |> unbox<System.IDisposable>
    v117 
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v118 : System.IDisposable = null |> unbox<System.IDisposable>
    v118 
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v119 : (unit -> unit) = closure36(v84)
    let v120 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v119 () }
    v120 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v121 : System.IDisposable = null |> unbox<System.IDisposable>
    v121 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v122 : System.IDisposable = Unchecked.defaultof<System.IDisposable>
    v122 
    #endif
    |> fun x -> _v115 <- Some x
    let v123 : System.IDisposable = _v115.Value
    struct (v84, v123) 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let struct (v124 : string, v125 : System.IDisposable) = null |> unbox<struct (string * System.IDisposable)>
    struct (v124, v125) 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let struct (v126 : string, v127 : System.IDisposable) = Unchecked.defaultof<struct (string * System.IDisposable)>
    struct (v126, v127) 
    #endif
    |> fun x -> _v0 <- Some x
    let struct (v128 : string, v129 : System.IDisposable) = _v0.Value
    struct (v128, v129)
and closure37 () () : string =
    let v0 : string = __SOURCE_DIRECTORY__
    v0
and closure41 () (v0 : string) : bool =
    let v1 : bool option = None
    let mutable _v1 = v1
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = method7(v0)
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
    let v2 : string = method7(v0)
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
    let v2 : string = method7(v0)
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
and method19 () : (string -> string option) =
    closure43()
and closure44 () (v0 : string) : US8 =
    US8_0(v0)
and method20 () : (string -> US8) =
    closure44()
and method21 (v0 : string, v1 : bool, v2 : string, v3 : string) : string =
    let v4 : string option = None
    let mutable _v4 = v4
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v5 : string = method7(v3)
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
    let v25 : string = System.IO.Path.Combine (v3, v0)
    v25 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v26 : string = "path"
    let v27 : IPathJoin = Fable.Core.JsInterop.importAll v26
    let v28 : string = method16(v3)
    let v29 : string = method17(v0)
    let v30 : string = "v27.join(v28, v29)"
    let v31 : string = Fable.Core.JsInterop.emitJsExpr () v30
    v31 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v32 : string = Unchecked.defaultof<string>
    v32 
    #endif
    |> fun x -> _v4 <- Some x
    let v33 : string = _v4.Value
    let v36 : (string -> bool) =
        if v1 then
            closure41()
        else
            closure42()
    let v37 : bool = v36 v33
    if v37 then
        v3
    else
        let v38 : (string -> string option) = method19()
        let v39 : string option = v38 v3
        let v40 : (string -> US8) = method20()
        let v41 : US8 = US8_1
        let v42 : US8 = v39 |> Option.map v40 |> Option.defaultValue v41 
        match v42 with
        | US8_1 -> (* None *)
            let v45 : string = $"""No parent for {if v1 then "file" else "dir"} '{v0}' at '{v2}' (until '{v3}')"""
            failwith<string> v45
        | US8_0(v43) -> (* Some *)
            method21(v0, v1, v2, v43)
and method18 (v0 : string, v1 : bool, v2 : string) : string =
    let v3 : string option = None
    let mutable _v3 = v3
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v4 : string = method7(v2)
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
    let v24 : string = System.IO.Path.Combine (v2, v0)
    v24 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v25 : string = "path"
    let v26 : IPathJoin = Fable.Core.JsInterop.importAll v25
    let v27 : string = method16(v2)
    let v28 : string = method17(v0)
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
    let v35 : (string -> bool) =
        if v1 then
            closure41()
        else
            closure42()
    let v36 : bool = v35 v32
    if v36 then
        v2
    else
        let v37 : (string -> string option) = method19()
        let v38 : string option = v37 v2
        let v39 : (string -> US8) = method20()
        let v40 : US8 = US8_1
        let v41 : US8 = v38 |> Option.map v39 |> Option.defaultValue v40 
        match v41 with
        | US8_1 -> (* None *)
            let v44 : string = $"""No parent for {if v1 then "file" else "dir"} '{v0}' at '{v2}' (until '{v2}')"""
            failwith<string> v44
        | US8_0(v42) -> (* Some *)
            method21(v0, v1, v2, v42)
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
    let mutable _v3 = v3
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v4 : string = method7(v2)
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
    let v24 : string = System.IO.Path.Combine (v2, v0)
    v24 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v25 : string = "path"
    let v26 : IPathJoin = Fable.Core.JsInterop.importAll v25
    let v27 : string = method16(v2)
    let v28 : string = method17(v0)
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
    let v34 : string = method7(v32)
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
        let v56 : (string -> string option) = method19()
        let v57 : string option = v56 v2
        let v58 : (string -> US8) = method20()
        let v59 : US8 = US8_1
        let v60 : US8 = v57 |> Option.map v58 |> Option.defaultValue v59 
        match v60 with
        | US8_1 -> (* None *)
            let v63 : string = $"""No parent for {if false then "file" else "dir"} '{v0}' at '{v1}' (until '{v2}')"""
            failwith<string> v63
        | US8_0(v61) -> (* Some *)
            method27(v0, v1, v61)
and method26 (v0 : string, v1 : string) : string =
    let v2 : string option = None
    let mutable _v2 = v2
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : string = method7(v1)
    let v4 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v5 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v3 v4
    let v6 : string = "String::from($0)"
    let v7 : std_string_String = Fable.Core.RustInterop.emitRustExpr v5 v6
    let v8 : string = "std::path::PathBuf::from($0)"
    let v9 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v7 v8
    let v10 : string = method7(v0)
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
    let v26 : string = method16(v1)
    let v27 : string = method17(v0)
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
    let v33 : string = method7(v31)
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
        let v55 : (string -> string option) = method19()
        let v56 : string option = v55 v1
        let v57 : (string -> US8) = method20()
        let v58 : US8 = US8_1
        let v59 : US8 = v56 |> Option.map v57 |> Option.defaultValue v58 
        match v59 with
        | US8_1 -> (* None *)
            let v62 : string = $"""No parent for {if false then "file" else "dir"} '{v0}' at '{v1}' (until '{v1}')"""
            failwith<string> v62
        | US8_0(v60) -> (* Some *)
            method27(v0, v1, v60)
and method28 () : string =
    let v0 : string = "polyglot"
    v0
and closure45 () () : string =
    let v0 : string = __SOURCE_DIRECTORY__
    let v1 : string option = None
    let mutable _v1 = v1
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = method22()
    let v3 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v4 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v2 v3
    let v5 : string = "String::from($0)"
    let v6 : std_string_String = Fable.Core.RustInterop.emitRustExpr v4 v5
    let v7 : string = "std::path::PathBuf::from($0)"
    let v8 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v6 v7
    let v9 : string = method23()
    let v10 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v11 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v9 v10
    let v12 : string = "String::from($0)"
    let v13 : std_string_String = Fable.Core.RustInterop.emitRustExpr v11 v12
    let v14 : string = "$0.join($1)"
    let v15 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr struct (v8, v13) v14
    let v16 : string = "$0.display().to_string()"
    let v17 : std_string_String = Fable.Core.RustInterop.emitRustExpr v15 v16
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
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v22 : string = "polyglot"
    let v23 : string = ".paket"
    let v24 : string = System.IO.Path.Combine (v22, v23)
    v24 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v25 : string = "path"
    let v26 : IPathJoin = Fable.Core.JsInterop.importAll v25
    let v27 : string = method24()
    let v28 : string = method25()
    let v29 : string = "v26.join(v27, v28)"
    let v30 : string = Fable.Core.JsInterop.emitJsExpr () v29
    v30 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v31 : string = Unchecked.defaultof<string>
    v31 
    #endif
    |> fun x -> _v1 <- Some x
    let v32 : string = _v1.Value
    let v33 : string = method26(v32, v0)
    let v34 : string option = None
    let mutable _v34 = v34
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v35 : string = method7(v33)
    let v36 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v37 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v35 v36
    let v38 : string = "String::from($0)"
    let v39 : std_string_String = Fable.Core.RustInterop.emitRustExpr v37 v38
    let v40 : string = "std::path::PathBuf::from($0)"
    let v41 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v39 v40
    let v42 : string = method22()
    let v43 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v44 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v42 v43
    let v45 : string = "String::from($0)"
    let v46 : std_string_String = Fable.Core.RustInterop.emitRustExpr v44 v45
    let v47 : string = "$0.join($1)"
    let v48 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr struct (v41, v46) v47
    let v49 : string = "$0.display().to_string()"
    let v50 : std_string_String = Fable.Core.RustInterop.emitRustExpr v48 v49
    let v51 : string = "fable_library_rust::String_::fromString($0)"
    let v52 : string = Fable.Core.RustInterop.emitRustExpr v50 v51
    v52 
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v53 : string = null |> unbox<string>
    v53 
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v54 : string = null |> unbox<string>
    v54 
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v55 : string = System.IO.Path.Combine (v33, v22)
    v55 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v56 : IPathJoin = Fable.Core.JsInterop.importAll v25
    let v57 : string = method16(v33)
    let v58 : string = method28()
    let v59 : string = "v56.join(v57, v58)"
    let v60 : string = Fable.Core.JsInterop.emitJsExpr () v59
    v60 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v61 : string = Unchecked.defaultof<string>
    v61 
    #endif
    |> fun x -> _v34 <- Some x
    let v62 : string = _v34.Value
    v62
and closure47 (v0 : string) (v1 : string) : string =
    let v2 : string option = None
    let mutable _v2 = v2
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : string = method7(v0)
    let v4 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v5 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v3 v4
    let v6 : string = "String::from($0)"
    let v7 : std_string_String = Fable.Core.RustInterop.emitRustExpr v5 v6
    let v8 : string = "std::path::PathBuf::from($0)"
    let v9 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v7 v8
    let v10 : string = method7(v1)
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
    let v26 : string = method16(v0)
    let v27 : string = method17(v1)
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
    v31
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
