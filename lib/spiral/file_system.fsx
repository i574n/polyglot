#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::string::String")>]
type std_string_String = class end
#else
type std_string_String = string
#endif

#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("&$0")>]
type Ref<'T> = class end
#else
type Ref<'T> = 'T
#endif

#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::path::PathBuf")>]
type std_path_PathBuf = class end
#else
type std_path_PathBuf = string
#endif

#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::ffi::OsString")>]
#endif
type std_ffi_OsString = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("mut $0")>]
#endif
type Mut<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("Vec<$0>")>]
#endif
type Vec<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("chrono::DateTime<$0>")>]
#endif
type chrono_DateTime<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("chrono::NaiveDateTime")>]
#endif
type chrono_NaiveDateTime = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::path::Display")>]
type std_path_Display = class end
#else
type std_path_Display = string
#endif

#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::io::Error")>]
type std_io_Error = class end
#else
type std_io_Error = string
#endif

#if FABLE_COMPILER
type System_IO_DirectoryInfo = unit
#else
type System_IO_DirectoryInfo = System.IO.DirectoryInfo
#endif

#if FABLE_COMPILER
type System_IO_FileInfo = unit
#else
type System_IO_FileInfo = System.IO.FileInfo
#endif

#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("regex::Regex")>]
#endif
type regex_Regex = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::borrow::Cow<$0>")>]
#endif
type std_borrow_Cow<'T> = class end
module TraceState = let mutable trace_state = None
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::env::VarError")>]
#endif
type std_env_VarError = class end
type IOsEnviron = abstract environ: x: unit -> obj
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("str")>]
type Str = class end
#else
type Str = string
#endif

type IFsExistsSync = abstract existsSync: path: string -> bool
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::ffi::OsStr")>]
#endif
type std_ffi_OsStr = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::string::FromUtf8Error")>]
#endif
type std_string_FromUtf8Error = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("chrono::Utc")>]
#endif
type chrono_Utc = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("chrono::Local")>]
#endif
type chrono_Local = class end
type IPathJoin = abstract join: [<System.ParamArray>] paths: string[] -> string
type Disposable (f : unit -> unit) = interface System.IDisposable with member _.Dispose () = f ()
type IPathDirname = abstract dirname: path: string -> string
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("regex::Error")>]
#endif
type regex_Error = class end
type [<Struct>] US0 =
    | US0_0
    | US0_1
    | US0_2
    | US0_3
    | US0_4
and Mut0 = {mutable l0 : int64}
and Mut1 = {mutable l0 : (string -> unit)}
and Mut2 = {mutable l0 : bool}
and Mut3 = {mutable l0 : string}
and Mut4 = {mutable l0 : US0}
and [<Struct>] US1 =
    | US1_0 of f0_0 : US0
    | US1_1
and [<Struct>] US2 =
    | US2_0 of f0_0 : int64
    | US2_1
and [<Struct>] US3 =
    | US3_0
    | US3_1
    | US3_2
and [<Struct>] US4 =
    | US4_0 of f0_0 : US3
    | US4_1 of f1_0 : US3
    | US4_2 of f2_0 : US3
    | US4_3 of f3_0 : US3
    | US4_4 of f4_0 : US3
and [<Struct>] US5 =
    | US5_0 of f0_0 : string
    | US5_1
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
    | US13_0 of f0_0 : std_path_PathBuf
    | US13_1 of f1_0 : string
and [<Struct>] US14 =
    | US14_0 of f0_0 : std_path_PathBuf
    | US14_1
and [<Struct>] US15 =
    | US15_0 of f0_0 : string
    | US15_1 of f1_0 : string
let rec method3 (v0 : string) : string =
    v0
and method4 () : string =
    let v0 : string = ""
    v0
and closure1 () (v0 : string) : US5 =
    US5_0(v0)
and method5 () : (string -> US5) =
    closure1()
and method2 (v0 : string) : string =
    let v1 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = method3(v0)
    let v3 : string = "std::env::var(&*$0)"
    let v4 : Result<std_string_String, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr v2 v3 
    let v5 : string = "true; let _result_map_ = $0.map(|x| { //"
    let v6 : bool = Fable.Core.RustInterop.emitRustExpr v4 v5 
    let v7 : string = "x"
    let v8 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v7 
    let v9 : string = "fable_library_rust::String_::fromString($0)"
    let v10 : string = Fable.Core.RustInterop.emitRustExpr v8 v9 
    let v11 : string = "true; $0 })"
    let v12 : bool = Fable.Core.RustInterop.emitRustExpr v10 v11 
    let v13 : string = "_result_map_"
    let v14 : Result<string, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr () v13 
    let v15 : string = method4()
    let v16 : string = "$0.unwrap_or($1)"
    let v17 : string = Fable.Core.RustInterop.emitRustExpr struct (v14, v15) v16 
    let _v1 = v17 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v18 : US3 = US3_1
    let v19 : US4 = US4_2(v18)
    let v20 : string = $"env.get_environment_variable / target: {v19} / var: {v0}"
    let v21 : string = failwith<string> v20
    let _v1 = v21 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v22 : US3 = US3_2
    let v23 : US4 = US4_2(v22)
    let v24 : string = $"env.get_environment_variable / target: {v23} / var: {v0}"
    let v25 : string = failwith<string> v24
    let _v1 = v25 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v26 : string = "process.env[$0] ?? \"\""
    let v27 : string = Fable.Core.JsInterop.emitJsExpr v0 v26 
    let _v1 = v27 
    #endif
#if FABLE_COMPILER_PYTHON
    let v28 : string = "os"
    let v29 : IOsEnviron = Fable.Core.PyInterop.importAll v28 
    let v30 : string = "v29.environ"
    let v31 : obj = Fable.Core.PyInterop.emitPyExpr () v30 
    let v34 : string = "v31.get($0)"
    let v35 : string = Fable.Core.PyInterop.emitPyExpr v0 v34 
    let mutable _v35 = None
    #if !FABLE_COMPILER && !WASM && !CONTRACT
    let v38 : (string -> string option) = Option.ofObj
    let v39 : string option = v38 v35
    v39 
    #else
    Some v35 
    #endif
    |> fun x -> _v35 <- Some x
    let v40 : string option = match _v35 with Some x -> x | None -> failwith "optionm'.of_obj / _v35=None"
    let v43 : (string -> US5) = method5()
    let v44 : US5 option = v40 |> Option.map v43 
    let v55 : US5 = US5_1
    let v56 : US5 = v44 |> Option.defaultValue v55 
    let v63 : string =
        match v56 with
        | US5_1 -> (* None *)
            let v61 : string = ""
            v61
        | US5_0(v60) -> (* Some *)
            v60
    let _v1 = v63 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v64 : US3 = US3_1
    let v65 : US4 = US4_0(v64)
    let v66 : string = $"env.get_environment_variable / target: {v65} / var: {v0}"
    let v67 : string = failwith<string> v66
    let _v1 = v67 
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
    let v75 : (string -> US5) = method5()
    let v76 : US5 option = v72 |> Option.map v75 
    let v87 : US5 = US5_1
    let v88 : US5 = v76 |> Option.defaultValue v87 
    let v95 : string =
        match v88 with
        | US5_1 -> (* None *)
            let v93 : string = ""
            v93
        | US5_0(v92) -> (* Some *)
            v92
    let _v1 = v95 
    #endif
    let v96 : string = _v1 
    v96
and method1 () : struct (US1 * US2) =
    let v0 : string = "TRACE_LEVEL"
    let v1 : string = method2(v0)
    
    
    
    
    
    let v2 : bool = "Verbose" = v1
    let v6 : US1 =
        if v2 then
            let v3 : US0 = US0_0
            US1_0(v3)
        else
            US1_1
    let v47 : US1 =
        match v6 with
        | US1_1 -> (* None *)
            let v9 : bool = "Debug" = v1
            let v13 : US1 =
                if v9 then
                    let v10 : US0 = US0_1
                    US1_0(v10)
                else
                    US1_1
            match v13 with
            | US1_1 -> (* None *)
                let v16 : bool = "Info" = v1
                let v20 : US1 =
                    if v16 then
                        let v17 : US0 = US0_2
                        US1_0(v17)
                    else
                        US1_1
                match v20 with
                | US1_1 -> (* None *)
                    let v23 : bool = "Warning" = v1
                    let v27 : US1 =
                        if v23 then
                            let v24 : US0 = US0_3
                            US1_0(v24)
                        else
                            US1_1
                    match v27 with
                    | US1_1 -> (* None *)
                        let v30 : bool = "Critical" = v1
                        let v34 : US1 =
                            if v30 then
                                let v31 : US0 = US0_4
                                US1_0(v31)
                            else
                                US1_1
                        match v34 with
                        | US1_1 -> (* None *)
                            US1_1
                        | US1_0(v35) -> (* Some *)
                            US1_0(v35)
                    | US1_0(v28) -> (* Some *)
                        US1_0(v28)
                | US1_0(v21) -> (* Some *)
                    US1_0(v21)
            | US1_0(v14) -> (* Some *)
                US1_0(v14)
        | US1_0(v7) -> (* Some *)
            US1_0(v7)
    let v48 : string = "AUTOMATION"
    let v49 : string = method2(v48)
    let v50 : string = "True"
    let v51 : bool = v49 <> v50 
    let v107 : US2 =
        if v51 then
            US2_1
        else
            let v55 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v56 : System.DateTime = System.DateTime.Now
            let _v55 = v56 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v57 : System.DateTime = System.DateTime.Now
            let _v55 = v57 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v58 : System.DateTime = null |> unbox<System.DateTime>
            let _v55 = v58 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v61 : System.DateTime = System.DateTime.Now
            let _v55 = v61 
            #endif
#if FABLE_COMPILER_PYTHON
            let v62 : System.DateTime = System.DateTime.Now
            let _v55 = v62 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v63 : System.DateTime = System.DateTime.Now
            let _v55 = v63 
            #endif
#else
            let v64 : System.DateTime = System.DateTime.Now
            let _v55 = v64 
            #endif
            let v65 : System.DateTime = _v55 
            let v70 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v71 : (System.DateTime -> int64) = _.Ticks
            let v72 : int64 = v71 v65
            let _v70 = v72 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v73 : (System.DateTime -> int64) = _.Ticks
            let v74 : int64 = v73 v65
            let _v70 = v74 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v75 : int64 = null |> unbox<int64>
            let _v70 = v75 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v78 : (System.DateTime -> int64) = _.Ticks
            let v79 : int64 = v78 v65
            let _v70 = v79 
            #endif
#if FABLE_COMPILER_PYTHON
            let v80 : (System.DateTime -> int64) = _.Ticks
            let v81 : int64 = v80 v65
            let _v70 = v81 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v82 : (System.DateTime -> int64) = _.Ticks
            let v83 : int64 = v82 v65
            let _v70 = v83 
            #endif
#else
            let v84 : (System.DateTime -> int64) = _.Ticks
            let v85 : int64 = v84 v65
            let _v70 = v85 
            #endif
            let v86 : int64 = _v70 
            let v103 : int64 = v86 |> int64 
            US2_0(v103)
    struct (v47, v107)
and closure2 () (v0 : string) : unit =
    ()
and method0 (v0 : US0) : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) =
    let v1 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let struct (v2 : US1, v3 : US2) = method1()
    let _v1 = struct (v2, v3) 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v4 : US1 = US1_1
    let v5 : US2 = US2_1
    let _v1 = struct (v4, v5) 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v6 : string = "AUTOMATION"
    let v7 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v8 : string = "option_env!(\"" + v6 + "\").unwrap_or(\"\")"
    let v9 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v8 
    let v10 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v11 : string = "String::from($0)"
    let v12 : std_string_String = Fable.Core.RustInterop.emitRustExpr v9 v11 
    let _v10 = v12 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v13 : string = "String::from($0)"
    let v14 : std_string_String = Fable.Core.RustInterop.emitRustExpr v9 v13 
    let _v10 = v14 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v15 : string = "String::from($0)"
    let v16 : std_string_String = Fable.Core.RustInterop.emitRustExpr v9 v15 
    let _v10 = v16 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v17 : std_string_String = v9 |> unbox<std_string_String>
    let _v10 = v17 
    #endif
#if FABLE_COMPILER_PYTHON
    let v20 : std_string_String = v9 |> unbox<std_string_String>
    let _v10 = v20 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v23 : std_string_String = v9 |> unbox<std_string_String>
    let _v10 = v23 
    #endif
#else
    let v26 : std_string_String = v9 |> unbox<std_string_String>
    let _v10 = v26 
    #endif
    let v29 : std_string_String = _v10 
    let v34 : string = "fable_library_rust::String_::fromString($0)"
    let v35 : string = Fable.Core.RustInterop.emitRustExpr v29 v34 
    let _v7 = v35 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v36 : string = "option_env!(\"" + v6 + "\").unwrap_or(\"\")"
    let v37 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v36 
    let v38 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v39 : string = "String::from($0)"
    let v40 : std_string_String = Fable.Core.RustInterop.emitRustExpr v37 v39 
    let _v38 = v40 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v41 : string = "String::from($0)"
    let v42 : std_string_String = Fable.Core.RustInterop.emitRustExpr v37 v41 
    let _v38 = v42 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v43 : string = "String::from($0)"
    let v44 : std_string_String = Fable.Core.RustInterop.emitRustExpr v37 v43 
    let _v38 = v44 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v45 : std_string_String = v37 |> unbox<std_string_String>
    let _v38 = v45 
    #endif
#if FABLE_COMPILER_PYTHON
    let v48 : std_string_String = v37 |> unbox<std_string_String>
    let _v38 = v48 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v51 : std_string_String = v37 |> unbox<std_string_String>
    let _v38 = v51 
    #endif
#else
    let v54 : std_string_String = v37 |> unbox<std_string_String>
    let _v38 = v54 
    #endif
    let v57 : std_string_String = _v38 
    let v62 : string = "fable_library_rust::String_::fromString($0)"
    let v63 : string = Fable.Core.RustInterop.emitRustExpr v57 v62 
    let _v7 = v63 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v64 : string = "option_env!(\"" + v6 + "\").unwrap_or(\"\")"
    let v65 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v64 
    let v66 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v67 : string = "String::from($0)"
    let v68 : std_string_String = Fable.Core.RustInterop.emitRustExpr v65 v67 
    let _v66 = v68 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v69 : string = "String::from($0)"
    let v70 : std_string_String = Fable.Core.RustInterop.emitRustExpr v65 v69 
    let _v66 = v70 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v71 : string = "String::from($0)"
    let v72 : std_string_String = Fable.Core.RustInterop.emitRustExpr v65 v71 
    let _v66 = v72 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v73 : std_string_String = v65 |> unbox<std_string_String>
    let _v66 = v73 
    #endif
#if FABLE_COMPILER_PYTHON
    let v76 : std_string_String = v65 |> unbox<std_string_String>
    let _v66 = v76 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v79 : std_string_String = v65 |> unbox<std_string_String>
    let _v66 = v79 
    #endif
#else
    let v82 : std_string_String = v65 |> unbox<std_string_String>
    let _v66 = v82 
    #endif
    let v85 : std_string_String = _v66 
    let v90 : string = "fable_library_rust::String_::fromString($0)"
    let v91 : string = Fable.Core.RustInterop.emitRustExpr v85 v90 
    let _v7 = v91 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v92 : string = null |> unbox<string>
    let _v7 = v92 
    #endif
#if FABLE_COMPILER_PYTHON
    let v95 : string = null |> unbox<string>
    let _v7 = v95 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v98 : string = null |> unbox<string>
    let _v7 = v98 
    #endif
#else
    let v101 : string = null |> unbox<string>
    let _v7 = v101 
    #endif
    let v104 : string = _v7 
    let v109 : string = "True"
    let v110 : bool = v104 <> v109 
    let v121 : US2 =
        if v110 then
            US2_1
        else
            let v114 : string = $"near_sdk::env::block_timestamp()"
            let v115 : uint64 = Fable.Core.RustInterop.emitRustExpr () v114 
            let v116 : (uint64 -> int64) = int64
            let v117 : int64 = v116 v115
            US2_0(v117)
    let v122 : US1 = US1_1
    let _v1 = struct (v122, v121) 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let struct (v123 : US1, v124 : US2) = method1()
    let _v1 = struct (v123, v124) 
    #endif
#if FABLE_COMPILER_PYTHON
    let struct (v125 : US1, v126 : US2) = method1()
    let _v1 = struct (v125, v126) 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let struct (v127 : US1, v128 : US2) = method1()
    let _v1 = struct (v127, v128) 
    #endif
#else
    let struct (v129 : US1, v130 : US2) = method1()
    let _v1 = struct (v129, v130) 
    #endif
    let struct (v131 : US1, v132 : US2) = _v1 
    let v137 : Mut0 = {l0 = 1L} : Mut0
    let v138 : (string -> unit) = closure2()
    let v139 : Mut1 = {l0 = v138} : Mut1
    let v140 : Mut2 = {l0 = true} : Mut2
    let v141 : string = ""
    let v142 : Mut3 = {l0 = v141} : Mut3
    let v145 : US0 =
        match v131 with
        | US1_1 -> (* None *)
            v0
        | US1_0(v143) -> (* Some *)
            v143
    let v146 : Mut4 = {l0 = v145} : Mut4
    let v153 : int64 option =
        match v132 with
        | US2_1 -> (* None *)
            let v151 : int64 option = None
            v151
        | US2_0(v147) -> (* Some *)
            let v148 : int64 option = Some v147 
            v148
    struct (v137, v139, v140, v142, v146, v153)
and closure0 () () : unit =
    let v0 : bool = TraceState.trace_state.IsNone
    if v0 then
        let v1 : US0 = US0_0
        let struct (v2 : Mut0, v3 : Mut1, v4 : Mut2, v5 : Mut3, v6 : Mut4, v7 : int64 option) = method0(v1)
        let v8 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v2, v3, v4, v5, v6, v7) 
        TraceState.trace_state <- v8 
        ()
and method9 (v0 : string) : bool =
    let v1 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : string = "&*$0"
    let v4 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v3 
    let _v2 = v4 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v5 : string = "&*$0"
    let v6 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v5 
    let _v2 = v6 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v7 : string = "&*$0"
    let v8 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v7 
    let _v2 = v8 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v9 : Ref<Str> = v0 |> unbox<Ref<Str>>
    let _v2 = v9 
    #endif
#if FABLE_COMPILER_PYTHON
    let v12 : Ref<Str> = v0 |> unbox<Ref<Str>>
    let _v2 = v12 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v15 : Ref<Str> = v0 |> unbox<Ref<Str>>
    let _v2 = v15 
    #endif
#else
    let v18 : Ref<Str> = v0 |> unbox<Ref<Str>>
    let _v2 = v18 
    #endif
    let v21 : Ref<Str> = _v2 
    let v26 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v27 : string = "String::from($0)"
    let v28 : std_string_String = Fable.Core.RustInterop.emitRustExpr v21 v27 
    let _v26 = v28 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v29 : string = "String::from($0)"
    let v30 : std_string_String = Fable.Core.RustInterop.emitRustExpr v21 v29 
    let _v26 = v30 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v31 : string = "String::from($0)"
    let v32 : std_string_String = Fable.Core.RustInterop.emitRustExpr v21 v31 
    let _v26 = v32 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v33 : std_string_String = v21 |> unbox<std_string_String>
    let _v26 = v33 
    #endif
#if FABLE_COMPILER_PYTHON
    let v36 : std_string_String = v21 |> unbox<std_string_String>
    let _v26 = v36 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v39 : std_string_String = v21 |> unbox<std_string_String>
    let _v26 = v39 
    #endif
#else
    let v42 : std_string_String = v21 |> unbox<std_string_String>
    let _v26 = v42 
    #endif
    let v45 : std_string_String = _v26 
    let v50 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v51 : string = "std::path::PathBuf::from($0)"
    let v52 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v45 v51 
    let _v50 = v52 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v53 : string = "std::path::PathBuf::from($0)"
    let v54 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v45 v53 
    let _v50 = v54 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v55 : string = "std::path::PathBuf::from($0)"
    let v56 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v45 v55 
    let _v50 = v56 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v57 : std_path_PathBuf = v45 |> unbox<std_path_PathBuf>
    let _v50 = v57 
    #endif
#if FABLE_COMPILER_PYTHON
    let v60 : std_path_PathBuf = v45 |> unbox<std_path_PathBuf>
    let _v50 = v60 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v63 : std_path_PathBuf = v45 |> unbox<std_path_PathBuf>
    let _v50 = v63 
    #endif
#else
    let v66 : std_path_PathBuf = v45 |> unbox<std_path_PathBuf>
    let _v50 = v66 
    #endif
    let v69 : std_path_PathBuf = _v50 
    let v74 : string = "$0.exists()"
    let v75 : bool = Fable.Core.RustInterop.emitRustExpr v69 v74 
    let v78 : bool =
        if v75 then
            let v76 : string = "$0.is_dir()"
            let v77 : bool = Fable.Core.RustInterop.emitRustExpr v69 v76 
            v77
        else
            false
    let _v1 = v78 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v79 : bool = null |> unbox<bool>
    let _v1 = v79 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v82 : bool = null |> unbox<bool>
    let _v1 = v82 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v85 : string = "fs"
    let v86 : IFsExistsSync = Fable.Core.JsInterop.importAll v85 
    let v87 : string = "$0.existsSync($1)"
    let v88 : bool = Fable.Core.JsInterop.emitJsExpr struct (v86, v0) v87 
    let _v1 = v88 
    #endif
#if FABLE_COMPILER_PYTHON
    let v89 : bool = null |> unbox<bool>
    let _v1 = v89 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v92 : bool = null |> unbox<bool>
    let _v1 = v92 
    #endif
#else
    let v95 : (string -> bool) = System.IO.Directory.Exists
    let v96 : bool = v95 v0
    let _v1 = v96 
    #endif
    let v97 : bool = _v1 
    v97
and method8 (v0 : bool, v1 : string) : unit =
    let v2 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : bool = method9(v1)
    if v3 then
        if v0 then
            let v4 : string = "std::fs::remove_dir_all(&*$0).unwrap()"
            Fable.Core.RustInterop.emitRustExpr v1 v4 
            ()
        else
            let v5 : string = "std::fs::remove_dir(&*$0).unwrap()"
            Fable.Core.RustInterop.emitRustExpr v1 v5 
            ()
    let _v2 = () 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let _v2 = () 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let _v2 = () 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let _v2 = () 
    #endif
#if FABLE_COMPILER_PYTHON
    let _v2 = () 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let _v2 = () 
    #endif
#else
    System.IO.Directory.Delete (v1, v0)
    let _v2 = () 
    #endif
    _v2 
    ()
and method10 (v0 : US0) : bool =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure0()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v17 : Mut0, v18 : Mut1, v19 : Mut2, v20 : Mut3, v21 : Mut4, v22 : int64 option) = TraceState.trace_state.Value
    let v35 : US0 = v21.l0
    let v36 : bool = v19.l0
    let v37 : bool = v36 = false
    if v37 then
        false
    else
        let v38 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v0
        let v39 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v35
        let v40 : bool = v38 >= v39
        v40
and closure5 () (v0 : int64) : US2 =
    US2_0(v0)
and method12 () : (int64 -> US2) =
    closure5()
and method13 () : string =
    let v0 : string = "hh:mm:ss"
    v0
and method14 () : string =
    let v0 : string = "HH:mm:ss"
    v0
and method11 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option) : string =
    let v6 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v7 : (int64 -> US2) = method12()
    let v8 : US2 option = v5 |> Option.map v7 
    let v19 : US2 = US2_1
    let v20 : US2 = v8 |> Option.defaultValue v19 
    let v117 : System.DateTime =
        match v20 with
        | US2_1 -> (* None *)
            let v101 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v102 : System.DateTime = System.DateTime.Now
            let _v101 = v102 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v103 : System.DateTime = System.DateTime.Now
            let _v101 = v103 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v104 : System.DateTime = null |> unbox<System.DateTime>
            let _v101 = v104 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v107 : System.DateTime = System.DateTime.Now
            let _v101 = v107 
            #endif
#if FABLE_COMPILER_PYTHON
            let v108 : System.DateTime = System.DateTime.Now
            let _v101 = v108 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v109 : System.DateTime = System.DateTime.Now
            let _v101 = v109 
            #endif
#else
            let v110 : System.DateTime = System.DateTime.Now
            let _v101 = v110 
            #endif
            let v111 : System.DateTime = _v101 
            v111
        | US2_0(v24) -> (* Some *)
            let v25 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v26 : System.DateTime = System.DateTime.Now
            let _v25 = v26 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v27 : System.DateTime = System.DateTime.Now
            let _v25 = v27 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v28 : System.DateTime = null |> unbox<System.DateTime>
            let _v25 = v28 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v31 : System.DateTime = System.DateTime.Now
            let _v25 = v31 
            #endif
#if FABLE_COMPILER_PYTHON
            let v32 : System.DateTime = System.DateTime.Now
            let _v25 = v32 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v33 : System.DateTime = System.DateTime.Now
            let _v25 = v33 
            #endif
#else
            let v34 : System.DateTime = System.DateTime.Now
            let _v25 = v34 
            #endif
            let v35 : System.DateTime = _v25 
            let v40 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v41 : (System.DateTime -> int64) = _.Ticks
            let v42 : int64 = v41 v35
            let _v40 = v42 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v43 : (System.DateTime -> int64) = _.Ticks
            let v44 : int64 = v43 v35
            let _v40 = v44 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v45 : int64 = null |> unbox<int64>
            let _v40 = v45 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v48 : (System.DateTime -> int64) = _.Ticks
            let v49 : int64 = v48 v35
            let _v40 = v49 
            #endif
#if FABLE_COMPILER_PYTHON
            let v50 : (System.DateTime -> int64) = _.Ticks
            let v51 : int64 = v50 v35
            let _v40 = v51 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v52 : (System.DateTime -> int64) = _.Ticks
            let v53 : int64 = v52 v35
            let _v40 = v53 
            #endif
#else
            let v54 : (System.DateTime -> int64) = _.Ticks
            let v55 : int64 = v54 v35
            let _v40 = v55 
            #endif
            let v56 : int64 = _v40 
            let v73 : int64 = v56 |> int64 
            let v76 : int64 = v73 - v24
            let v77 : System.TimeSpan = v76 |> System.TimeSpan 
            let v82 : (System.TimeSpan -> int32) = _.Hours
            let v83 : int32 = v82 v77
            let v86 : (System.TimeSpan -> int32) = _.Minutes
            let v87 : int32 = v86 v77
            let v90 : (System.TimeSpan -> int32) = _.Seconds
            let v91 : int32 = v90 v77
            let v94 : (System.TimeSpan -> int32) = _.Milliseconds
            let v95 : int32 = v94 v77
            let v98 : System.DateTime = System.DateTime (1, 1, 1, v83, v87, v91, v95)
            v98
    let v118 : string = method13()
    let v121 : bool = v118 = ""
    let v123 : string =
        if v121 then
            let v122 : string = "M-d-y hh:mm:ss tt"
            v122
        else
            v118
    let v124 : (string -> string) = v117.ToString
    let v125 : string = v124 v123
    let _v6 = v125 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v139 : (int64 -> US2) = method12()
    let v140 : US2 option = v5 |> Option.map v139 
    let v151 : US2 = US2_1
    let v152 : US2 = v140 |> Option.defaultValue v151 
    let v249 : System.DateTime =
        match v152 with
        | US2_1 -> (* None *)
            let v233 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v234 : System.DateTime = System.DateTime.Now
            let _v233 = v234 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v235 : System.DateTime = System.DateTime.Now
            let _v233 = v235 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v236 : System.DateTime = null |> unbox<System.DateTime>
            let _v233 = v236 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v239 : System.DateTime = System.DateTime.Now
            let _v233 = v239 
            #endif
#if FABLE_COMPILER_PYTHON
            let v240 : System.DateTime = System.DateTime.Now
            let _v233 = v240 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v241 : System.DateTime = System.DateTime.Now
            let _v233 = v241 
            #endif
#else
            let v242 : System.DateTime = System.DateTime.Now
            let _v233 = v242 
            #endif
            let v243 : System.DateTime = _v233 
            v243
        | US2_0(v156) -> (* Some *)
            let v157 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v158 : System.DateTime = System.DateTime.Now
            let _v157 = v158 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v159 : System.DateTime = System.DateTime.Now
            let _v157 = v159 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v160 : System.DateTime = null |> unbox<System.DateTime>
            let _v157 = v160 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v163 : System.DateTime = System.DateTime.Now
            let _v157 = v163 
            #endif
#if FABLE_COMPILER_PYTHON
            let v164 : System.DateTime = System.DateTime.Now
            let _v157 = v164 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v165 : System.DateTime = System.DateTime.Now
            let _v157 = v165 
            #endif
#else
            let v166 : System.DateTime = System.DateTime.Now
            let _v157 = v166 
            #endif
            let v167 : System.DateTime = _v157 
            let v172 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v173 : (System.DateTime -> int64) = _.Ticks
            let v174 : int64 = v173 v167
            let _v172 = v174 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v175 : (System.DateTime -> int64) = _.Ticks
            let v176 : int64 = v175 v167
            let _v172 = v176 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v177 : int64 = null |> unbox<int64>
            let _v172 = v177 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v180 : (System.DateTime -> int64) = _.Ticks
            let v181 : int64 = v180 v167
            let _v172 = v181 
            #endif
#if FABLE_COMPILER_PYTHON
            let v182 : (System.DateTime -> int64) = _.Ticks
            let v183 : int64 = v182 v167
            let _v172 = v183 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v184 : (System.DateTime -> int64) = _.Ticks
            let v185 : int64 = v184 v167
            let _v172 = v185 
            #endif
#else
            let v186 : (System.DateTime -> int64) = _.Ticks
            let v187 : int64 = v186 v167
            let _v172 = v187 
            #endif
            let v188 : int64 = _v172 
            let v205 : int64 = v188 |> int64 
            let v208 : int64 = v205 - v156
            let v209 : System.TimeSpan = v208 |> System.TimeSpan 
            let v214 : (System.TimeSpan -> int32) = _.Hours
            let v215 : int32 = v214 v209
            let v218 : (System.TimeSpan -> int32) = _.Minutes
            let v219 : int32 = v218 v209
            let v222 : (System.TimeSpan -> int32) = _.Seconds
            let v223 : int32 = v222 v209
            let v226 : (System.TimeSpan -> int32) = _.Milliseconds
            let v227 : int32 = v226 v209
            let v230 : System.DateTime = System.DateTime (1, 1, 1, v215, v219, v223, v227)
            v230
    let v250 : string = method13()
    let v253 : bool = v250 = ""
    let v255 : string =
        if v253 then
            let v254 : string = "M-d-y hh:mm:ss tt"
            v254
        else
            v250
    let v256 : (string -> string) = v249.ToString
    let v257 : string = v256 v255
    let _v6 = v257 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v271 : string = $"near_sdk::env::block_timestamp()"
    let v272 : uint64 = Fable.Core.RustInterop.emitRustExpr () v271 
    let v273 : (int64 -> US2) = method12()
    let v274 : US2 option = v5 |> Option.map v273 
    let v285 : US2 = US2_1
    let v286 : US2 = v274 |> Option.defaultValue v285 
    let v297 : uint64 =
        match v286 with
        | US2_1 -> (* None *)
            v272
        | US2_0(v290) -> (* Some *)
            let v291 : (int64 -> uint64) = uint64
            let v292 : uint64 = v291 v290
            let v295 : uint64 = v272 - v292
            v295
    let v298 : uint64 = v297 / 1000000000UL
    let v299 : uint64 = v298 % 60UL
    let v300 : uint64 = v298 / 60UL
    let v301 : uint64 = v300 % 60UL
    let v302 : uint64 = v298 / 3600UL
    let v303 : uint64 = v302 % 24UL
    let v304 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
    let v305 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v303, v301, v299) v304 
    let v306 : string = "fable_library_rust::String_::fromString($0)"
    let v307 : string = Fable.Core.RustInterop.emitRustExpr v305 v306 
    let _v6 = v307 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v308 : (int64 -> US2) = method12()
    let v309 : US2 option = v5 |> Option.map v308 
    let v320 : US2 = US2_1
    let v321 : US2 = v309 |> Option.defaultValue v320 
    let v418 : System.DateTime =
        match v321 with
        | US2_1 -> (* None *)
            let v402 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v403 : System.DateTime = System.DateTime.Now
            let _v402 = v403 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v404 : System.DateTime = System.DateTime.Now
            let _v402 = v404 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v405 : System.DateTime = null |> unbox<System.DateTime>
            let _v402 = v405 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v408 : System.DateTime = System.DateTime.Now
            let _v402 = v408 
            #endif
#if FABLE_COMPILER_PYTHON
            let v409 : System.DateTime = System.DateTime.Now
            let _v402 = v409 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v410 : System.DateTime = System.DateTime.Now
            let _v402 = v410 
            #endif
#else
            let v411 : System.DateTime = System.DateTime.Now
            let _v402 = v411 
            #endif
            let v412 : System.DateTime = _v402 
            v412
        | US2_0(v325) -> (* Some *)
            let v326 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v327 : System.DateTime = System.DateTime.Now
            let _v326 = v327 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v328 : System.DateTime = System.DateTime.Now
            let _v326 = v328 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v329 : System.DateTime = null |> unbox<System.DateTime>
            let _v326 = v329 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v332 : System.DateTime = System.DateTime.Now
            let _v326 = v332 
            #endif
#if FABLE_COMPILER_PYTHON
            let v333 : System.DateTime = System.DateTime.Now
            let _v326 = v333 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v334 : System.DateTime = System.DateTime.Now
            let _v326 = v334 
            #endif
#else
            let v335 : System.DateTime = System.DateTime.Now
            let _v326 = v335 
            #endif
            let v336 : System.DateTime = _v326 
            let v341 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v342 : (System.DateTime -> int64) = _.Ticks
            let v343 : int64 = v342 v336
            let _v341 = v343 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v344 : (System.DateTime -> int64) = _.Ticks
            let v345 : int64 = v344 v336
            let _v341 = v345 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v346 : int64 = null |> unbox<int64>
            let _v341 = v346 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v349 : (System.DateTime -> int64) = _.Ticks
            let v350 : int64 = v349 v336
            let _v341 = v350 
            #endif
#if FABLE_COMPILER_PYTHON
            let v351 : (System.DateTime -> int64) = _.Ticks
            let v352 : int64 = v351 v336
            let _v341 = v352 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v353 : (System.DateTime -> int64) = _.Ticks
            let v354 : int64 = v353 v336
            let _v341 = v354 
            #endif
#else
            let v355 : (System.DateTime -> int64) = _.Ticks
            let v356 : int64 = v355 v336
            let _v341 = v356 
            #endif
            let v357 : int64 = _v341 
            let v374 : int64 = v357 |> int64 
            let v377 : int64 = v374 - v325
            let v378 : System.TimeSpan = v377 |> System.TimeSpan 
            let v383 : (System.TimeSpan -> int32) = _.Hours
            let v384 : int32 = v383 v378
            let v387 : (System.TimeSpan -> int32) = _.Minutes
            let v388 : int32 = v387 v378
            let v391 : (System.TimeSpan -> int32) = _.Seconds
            let v392 : int32 = v391 v378
            let v395 : (System.TimeSpan -> int32) = _.Milliseconds
            let v396 : int32 = v395 v378
            let v399 : System.DateTime = System.DateTime (1, 1, 1, v384, v388, v392, v396)
            v399
    let v419 : string = method14()
    let v422 : bool = v419 = ""
    let v424 : string =
        if v422 then
            let v423 : string = "M-d-y hh:mm:ss tt"
            v423
        else
            v419
    let v425 : (string -> string) = v418.ToString
    let v426 : string = v425 v424
    let _v6 = v426 
    #endif
#if FABLE_COMPILER_PYTHON
    let v440 : (int64 -> US2) = method12()
    let v441 : US2 option = v5 |> Option.map v440 
    let v452 : US2 = US2_1
    let v453 : US2 = v441 |> Option.defaultValue v452 
    let v550 : System.DateTime =
        match v453 with
        | US2_1 -> (* None *)
            let v534 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v535 : System.DateTime = System.DateTime.Now
            let _v534 = v535 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v536 : System.DateTime = System.DateTime.Now
            let _v534 = v536 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v537 : System.DateTime = null |> unbox<System.DateTime>
            let _v534 = v537 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v540 : System.DateTime = System.DateTime.Now
            let _v534 = v540 
            #endif
#if FABLE_COMPILER_PYTHON
            let v541 : System.DateTime = System.DateTime.Now
            let _v534 = v541 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v542 : System.DateTime = System.DateTime.Now
            let _v534 = v542 
            #endif
#else
            let v543 : System.DateTime = System.DateTime.Now
            let _v534 = v543 
            #endif
            let v544 : System.DateTime = _v534 
            v544
        | US2_0(v457) -> (* Some *)
            let v458 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v459 : System.DateTime = System.DateTime.Now
            let _v458 = v459 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v460 : System.DateTime = System.DateTime.Now
            let _v458 = v460 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v461 : System.DateTime = null |> unbox<System.DateTime>
            let _v458 = v461 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v464 : System.DateTime = System.DateTime.Now
            let _v458 = v464 
            #endif
#if FABLE_COMPILER_PYTHON
            let v465 : System.DateTime = System.DateTime.Now
            let _v458 = v465 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v466 : System.DateTime = System.DateTime.Now
            let _v458 = v466 
            #endif
#else
            let v467 : System.DateTime = System.DateTime.Now
            let _v458 = v467 
            #endif
            let v468 : System.DateTime = _v458 
            let v473 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v474 : (System.DateTime -> int64) = _.Ticks
            let v475 : int64 = v474 v468
            let _v473 = v475 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v476 : (System.DateTime -> int64) = _.Ticks
            let v477 : int64 = v476 v468
            let _v473 = v477 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v478 : int64 = null |> unbox<int64>
            let _v473 = v478 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v481 : (System.DateTime -> int64) = _.Ticks
            let v482 : int64 = v481 v468
            let _v473 = v482 
            #endif
#if FABLE_COMPILER_PYTHON
            let v483 : (System.DateTime -> int64) = _.Ticks
            let v484 : int64 = v483 v468
            let _v473 = v484 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v485 : (System.DateTime -> int64) = _.Ticks
            let v486 : int64 = v485 v468
            let _v473 = v486 
            #endif
#else
            let v487 : (System.DateTime -> int64) = _.Ticks
            let v488 : int64 = v487 v468
            let _v473 = v488 
            #endif
            let v489 : int64 = _v473 
            let v506 : int64 = v489 |> int64 
            let v509 : int64 = v506 - v457
            let v510 : System.TimeSpan = v509 |> System.TimeSpan 
            let v515 : (System.TimeSpan -> int32) = _.Hours
            let v516 : int32 = v515 v510
            let v519 : (System.TimeSpan -> int32) = _.Minutes
            let v520 : int32 = v519 v510
            let v523 : (System.TimeSpan -> int32) = _.Seconds
            let v524 : int32 = v523 v510
            let v527 : (System.TimeSpan -> int32) = _.Milliseconds
            let v528 : int32 = v527 v510
            let v531 : System.DateTime = System.DateTime (1, 1, 1, v516, v520, v524, v528)
            v531
    let v551 : string = method14()
    let v554 : bool = v551 = ""
    let v556 : string =
        if v554 then
            let v555 : string = "M-d-y hh:mm:ss tt"
            v555
        else
            v551
    let v557 : (string -> string) = v550.ToString
    let v558 : string = v557 v556
    let _v6 = v558 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v572 : (int64 -> US2) = method12()
    let v573 : US2 option = v5 |> Option.map v572 
    let v584 : US2 = US2_1
    let v585 : US2 = v573 |> Option.defaultValue v584 
    let v682 : System.DateTime =
        match v585 with
        | US2_1 -> (* None *)
            let v666 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v667 : System.DateTime = System.DateTime.Now
            let _v666 = v667 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v668 : System.DateTime = System.DateTime.Now
            let _v666 = v668 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v669 : System.DateTime = null |> unbox<System.DateTime>
            let _v666 = v669 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v672 : System.DateTime = System.DateTime.Now
            let _v666 = v672 
            #endif
#if FABLE_COMPILER_PYTHON
            let v673 : System.DateTime = System.DateTime.Now
            let _v666 = v673 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v674 : System.DateTime = System.DateTime.Now
            let _v666 = v674 
            #endif
#else
            let v675 : System.DateTime = System.DateTime.Now
            let _v666 = v675 
            #endif
            let v676 : System.DateTime = _v666 
            v676
        | US2_0(v589) -> (* Some *)
            let v590 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v591 : System.DateTime = System.DateTime.Now
            let _v590 = v591 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v592 : System.DateTime = System.DateTime.Now
            let _v590 = v592 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v593 : System.DateTime = null |> unbox<System.DateTime>
            let _v590 = v593 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v596 : System.DateTime = System.DateTime.Now
            let _v590 = v596 
            #endif
#if FABLE_COMPILER_PYTHON
            let v597 : System.DateTime = System.DateTime.Now
            let _v590 = v597 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v598 : System.DateTime = System.DateTime.Now
            let _v590 = v598 
            #endif
#else
            let v599 : System.DateTime = System.DateTime.Now
            let _v590 = v599 
            #endif
            let v600 : System.DateTime = _v590 
            let v605 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v606 : (System.DateTime -> int64) = _.Ticks
            let v607 : int64 = v606 v600
            let _v605 = v607 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v608 : (System.DateTime -> int64) = _.Ticks
            let v609 : int64 = v608 v600
            let _v605 = v609 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v610 : int64 = null |> unbox<int64>
            let _v605 = v610 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v613 : (System.DateTime -> int64) = _.Ticks
            let v614 : int64 = v613 v600
            let _v605 = v614 
            #endif
#if FABLE_COMPILER_PYTHON
            let v615 : (System.DateTime -> int64) = _.Ticks
            let v616 : int64 = v615 v600
            let _v605 = v616 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v617 : (System.DateTime -> int64) = _.Ticks
            let v618 : int64 = v617 v600
            let _v605 = v618 
            #endif
#else
            let v619 : (System.DateTime -> int64) = _.Ticks
            let v620 : int64 = v619 v600
            let _v605 = v620 
            #endif
            let v621 : int64 = _v605 
            let v638 : int64 = v621 |> int64 
            let v641 : int64 = v638 - v589
            let v642 : System.TimeSpan = v641 |> System.TimeSpan 
            let v647 : (System.TimeSpan -> int32) = _.Hours
            let v648 : int32 = v647 v642
            let v651 : (System.TimeSpan -> int32) = _.Minutes
            let v652 : int32 = v651 v642
            let v655 : (System.TimeSpan -> int32) = _.Seconds
            let v656 : int32 = v655 v642
            let v659 : (System.TimeSpan -> int32) = _.Milliseconds
            let v660 : int32 = v659 v642
            let v663 : System.DateTime = System.DateTime (1, 1, 1, v648, v652, v656, v660)
            v663
    let v683 : string = method14()
    let v686 : bool = v683 = ""
    let v688 : string =
        if v686 then
            let v687 : string = "M-d-y hh:mm:ss tt"
            v687
        else
            v683
    let v689 : (string -> string) = v682.ToString
    let v690 : string = v689 v688
    let _v6 = v690 
    #endif
#else
    let v704 : (int64 -> US2) = method12()
    let v705 : US2 option = v5 |> Option.map v704 
    let v716 : US2 = US2_1
    let v717 : US2 = v705 |> Option.defaultValue v716 
    let v814 : System.DateTime =
        match v717 with
        | US2_1 -> (* None *)
            let v798 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v799 : System.DateTime = System.DateTime.Now
            let _v798 = v799 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v800 : System.DateTime = System.DateTime.Now
            let _v798 = v800 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v801 : System.DateTime = null |> unbox<System.DateTime>
            let _v798 = v801 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v804 : System.DateTime = System.DateTime.Now
            let _v798 = v804 
            #endif
#if FABLE_COMPILER_PYTHON
            let v805 : System.DateTime = System.DateTime.Now
            let _v798 = v805 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v806 : System.DateTime = System.DateTime.Now
            let _v798 = v806 
            #endif
#else
            let v807 : System.DateTime = System.DateTime.Now
            let _v798 = v807 
            #endif
            let v808 : System.DateTime = _v798 
            v808
        | US2_0(v721) -> (* Some *)
            let v722 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v723 : System.DateTime = System.DateTime.Now
            let _v722 = v723 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v724 : System.DateTime = System.DateTime.Now
            let _v722 = v724 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v725 : System.DateTime = null |> unbox<System.DateTime>
            let _v722 = v725 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v728 : System.DateTime = System.DateTime.Now
            let _v722 = v728 
            #endif
#if FABLE_COMPILER_PYTHON
            let v729 : System.DateTime = System.DateTime.Now
            let _v722 = v729 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v730 : System.DateTime = System.DateTime.Now
            let _v722 = v730 
            #endif
#else
            let v731 : System.DateTime = System.DateTime.Now
            let _v722 = v731 
            #endif
            let v732 : System.DateTime = _v722 
            let v737 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v738 : (System.DateTime -> int64) = _.Ticks
            let v739 : int64 = v738 v732
            let _v737 = v739 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v740 : (System.DateTime -> int64) = _.Ticks
            let v741 : int64 = v740 v732
            let _v737 = v741 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v742 : int64 = null |> unbox<int64>
            let _v737 = v742 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v745 : (System.DateTime -> int64) = _.Ticks
            let v746 : int64 = v745 v732
            let _v737 = v746 
            #endif
#if FABLE_COMPILER_PYTHON
            let v747 : (System.DateTime -> int64) = _.Ticks
            let v748 : int64 = v747 v732
            let _v737 = v748 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v749 : (System.DateTime -> int64) = _.Ticks
            let v750 : int64 = v749 v732
            let _v737 = v750 
            #endif
#else
            let v751 : (System.DateTime -> int64) = _.Ticks
            let v752 : int64 = v751 v732
            let _v737 = v752 
            #endif
            let v753 : int64 = _v737 
            let v770 : int64 = v753 |> int64 
            let v773 : int64 = v770 - v721
            let v774 : System.TimeSpan = v773 |> System.TimeSpan 
            let v779 : (System.TimeSpan -> int32) = _.Hours
            let v780 : int32 = v779 v774
            let v783 : (System.TimeSpan -> int32) = _.Minutes
            let v784 : int32 = v783 v774
            let v787 : (System.TimeSpan -> int32) = _.Seconds
            let v788 : int32 = v787 v774
            let v791 : (System.TimeSpan -> int32) = _.Milliseconds
            let v792 : int32 = v791 v774
            let v795 : System.DateTime = System.DateTime (1, 1, 1, v780, v784, v788, v792)
            v795
    let v815 : string = method14()
    let v818 : bool = v815 = ""
    let v820 : string =
        if v818 then
            let v819 : string = "M-d-y hh:mm:ss tt"
            v819
        else
            v815
    let v821 : (string -> string) = v814.ToString
    let v822 : string = v821 v820
    let _v6 = v822 
    #endif
    let v836 : string = _v6 
    v836
and method17 () : string =
    let v0 : string = ""
    v0
and closure6 (v0 : Mut3, v1 : string) () : unit =
    let v2 : string = v0.l0
    let v3 : string = v2 + v1 
    v0.l0 <- v3
    ()
and method16 (v0 : char) : string =
    let v1 : string = method17()
    let v2 : Mut3 = {l0 = v1} : Mut3
    let v3 : string = $"{v0}"
    let v6 : unit = ()
    let v7 : (unit -> unit) = closure6(v2, v3)
    let v8 : unit = (fun () -> v7 (); v6) ()
    let v11 : string = v2.l0
    v11
and method18 () : string =
    let v0 : string = "\u001b[0m"
    v0
and method15 () : string =
    
    
    
    
    
    let v0 : string = "Debug"
    let v1 : (unit -> string) = v0.ToLower
    let v2 : string = v1 ()
    let v5 : char = v2.[int 0]
    let v6 : string = method16(v5)
    let v7 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v8 : string = "inline_colorization::color_bright_blue"
    let v9 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v8 
    let v10 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v11 : string = "&*$0"
    let v12 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v11 
    let _v10 = v12 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v13 : string = "&*$0"
    let v14 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v13 
    let _v10 = v14 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v15 : string = "&*$0"
    let v16 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v15 
    let _v10 = v16 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v17 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v10 = v17 
    #endif
#if FABLE_COMPILER_PYTHON
    let v20 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v10 = v20 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v23 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v10 = v23 
    #endif
#else
    let v26 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v10 = v26 
    #endif
    let v29 : Ref<Str> = _v10 
    let v34 : string = "inline_colorization::color_reset"
    let v35 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v34 
    let v36 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v37 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v9, v29, v35) v36 
    let v38 : string = "fable_library_rust::String_::fromString($0)"
    let v39 : string = Fable.Core.RustInterop.emitRustExpr v37 v38 
    let _v7 = v39 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v40 : string = "inline_colorization::color_bright_blue"
    let v41 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v40 
    let v42 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v43 : string = "&*$0"
    let v44 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v43 
    let _v42 = v44 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v45 : string = "&*$0"
    let v46 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v45 
    let _v42 = v46 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v47 : string = "&*$0"
    let v48 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v47 
    let _v42 = v48 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v49 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v42 = v49 
    #endif
#if FABLE_COMPILER_PYTHON
    let v52 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v42 = v52 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v55 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v42 = v55 
    #endif
#else
    let v58 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v42 = v58 
    #endif
    let v61 : Ref<Str> = _v42 
    let v66 : string = "inline_colorization::color_reset"
    let v67 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v66 
    let v68 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v69 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v41, v61, v67) v68 
    let v70 : string = "fable_library_rust::String_::fromString($0)"
    let v71 : string = Fable.Core.RustInterop.emitRustExpr v69 v70 
    let _v7 = v71 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v72 : string = "inline_colorization::color_bright_blue"
    let v73 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v72 
    let v74 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v75 : string = "&*$0"
    let v76 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v75 
    let _v74 = v76 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v77 : string = "&*$0"
    let v78 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v77 
    let _v74 = v78 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v79 : string = "&*$0"
    let v80 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v79 
    let _v74 = v80 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v81 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v74 = v81 
    #endif
#if FABLE_COMPILER_PYTHON
    let v84 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v74 = v84 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v87 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v74 = v87 
    #endif
#else
    let v90 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v74 = v90 
    #endif
    let v93 : Ref<Str> = _v74 
    let v98 : string = "inline_colorization::color_reset"
    let v99 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v98 
    let v100 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v101 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v73, v93, v99) v100 
    let v102 : string = "fable_library_rust::String_::fromString($0)"
    let v103 : string = Fable.Core.RustInterop.emitRustExpr v101 v102 
    let _v7 = v103 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v104 : string = "\u001b[94m"
    let v105 : string = method18()
    let v106 : string = v104 + v6 
    let v107 : string = v106 + v105 
    let _v7 = v107 
    #endif
#if FABLE_COMPILER_PYTHON
    let v108 : string = "\u001b[94m"
    let v109 : string = method18()
    let v110 : string = v108 + v6 
    let v111 : string = v110 + v109 
    let _v7 = v111 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v112 : string = "\u001b[94m"
    let v113 : string = method18()
    let v114 : string = v112 + v6 
    let v115 : string = v114 + v113 
    let _v7 = v115 
    #endif
#else
    let v116 : string = "\u001b[94m"
    let v117 : string = method18()
    let v118 : string = v116 + v6 
    let v119 : string = v118 + v117 
    let _v7 = v119 
    #endif
    let v120 : string = _v7 
    v120
and method19 (v0 : string) : string =
    let v1 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : string = "&*$0"
    let v4 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v3 
    let _v2 = v4 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v5 : string = "&*$0"
    let v6 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v5 
    let _v2 = v6 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v7 : string = "&*$0"
    let v8 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v7 
    let _v2 = v8 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v9 : Ref<Str> = v0 |> unbox<Ref<Str>>
    let _v2 = v9 
    #endif
#if FABLE_COMPILER_PYTHON
    let v12 : Ref<Str> = v0 |> unbox<Ref<Str>>
    let _v2 = v12 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v15 : Ref<Str> = v0 |> unbox<Ref<Str>>
    let _v2 = v15 
    #endif
#else
    let v18 : Ref<Str> = v0 |> unbox<Ref<Str>>
    let _v2 = v18 
    #endif
    let v21 : Ref<Str> = _v2 
    let v26 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v27 : string = "String::from($0)"
    let v28 : std_string_String = Fable.Core.RustInterop.emitRustExpr v21 v27 
    let _v26 = v28 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v29 : string = "String::from($0)"
    let v30 : std_string_String = Fable.Core.RustInterop.emitRustExpr v21 v29 
    let _v26 = v30 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v31 : string = "String::from($0)"
    let v32 : std_string_String = Fable.Core.RustInterop.emitRustExpr v21 v31 
    let _v26 = v32 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v33 : std_string_String = v21 |> unbox<std_string_String>
    let _v26 = v33 
    #endif
#if FABLE_COMPILER_PYTHON
    let v36 : std_string_String = v21 |> unbox<std_string_String>
    let _v26 = v36 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v39 : std_string_String = v21 |> unbox<std_string_String>
    let _v26 = v39 
    #endif
#else
    let v42 : std_string_String = v21 |> unbox<std_string_String>
    let _v26 = v42 
    #endif
    let v45 : std_string_String = _v26 
    let v50 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v51 : string = "std::path::PathBuf::from($0)"
    let v52 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v45 v51 
    let _v50 = v52 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v53 : string = "std::path::PathBuf::from($0)"
    let v54 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v45 v53 
    let _v50 = v54 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v55 : string = "std::path::PathBuf::from($0)"
    let v56 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v45 v55 
    let _v50 = v56 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v57 : std_path_PathBuf = v45 |> unbox<std_path_PathBuf>
    let _v50 = v57 
    #endif
#if FABLE_COMPILER_PYTHON
    let v60 : std_path_PathBuf = v45 |> unbox<std_path_PathBuf>
    let _v50 = v60 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v63 : std_path_PathBuf = v45 |> unbox<std_path_PathBuf>
    let _v50 = v63 
    #endif
#else
    let v66 : std_path_PathBuf = v45 |> unbox<std_path_PathBuf>
    let _v50 = v66 
    #endif
    let v69 : std_path_PathBuf = _v50 
    let v74 : string = "$0.file_name()"
    let v75 : Ref<std_ffi_OsStr> option = Fable.Core.RustInterop.emitRustExpr v69 v74 
    let v76 : string = "true; let _optionm_map_ = $0.map(|x| { //"
    let v77 : bool = Fable.Core.RustInterop.emitRustExpr v75 v76 
    let v78 : string = "x"
    let v79 : Ref<std_ffi_OsStr> = Fable.Core.RustInterop.emitRustExpr () v78 
    let v80 : string = "$0.to_os_string()"
    let v81 : std_ffi_OsString = Fable.Core.RustInterop.emitRustExpr v79 v80 
    let v82 : string = "$0.to_str()"
    let v83 : Ref<Str> option = Fable.Core.RustInterop.emitRustExpr v81 v82 
    let v84 : string = "$0.unwrap()"
    let v85 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v83 v84 
    let v86 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v87 : string = "String::from($0)"
    let v88 : std_string_String = Fable.Core.RustInterop.emitRustExpr v85 v87 
    let _v86 = v88 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v89 : string = "String::from($0)"
    let v90 : std_string_String = Fable.Core.RustInterop.emitRustExpr v85 v89 
    let _v86 = v90 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v91 : string = "String::from($0)"
    let v92 : std_string_String = Fable.Core.RustInterop.emitRustExpr v85 v91 
    let _v86 = v92 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v93 : std_string_String = v85 |> unbox<std_string_String>
    let _v86 = v93 
    #endif
#if FABLE_COMPILER_PYTHON
    let v96 : std_string_String = v85 |> unbox<std_string_String>
    let _v86 = v96 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v99 : std_string_String = v85 |> unbox<std_string_String>
    let _v86 = v99 
    #endif
#else
    let v102 : std_string_String = v85 |> unbox<std_string_String>
    let _v86 = v102 
    #endif
    let v105 : std_string_String = _v86 
    let v110 : string = "fable_library_rust::String_::fromString($0)"
    let v111 : string = Fable.Core.RustInterop.emitRustExpr v105 v110 
    let v112 : string = "true; $0 })"
    let v113 : bool = Fable.Core.RustInterop.emitRustExpr v111 v112 
    let v114 : string = "_optionm_map_"
    let v115 : string option = Fable.Core.RustInterop.emitRustExpr () v114 
    let v116 : (string -> US5) = method5()
    let v117 : US5 option = v115 |> Option.map v116 
    let v128 : US5 = US5_1
    let v129 : US5 = v117 |> Option.defaultValue v128 
    let v136 : string =
        match v129 with
        | US5_1 -> (* None *)
            let v134 : string = ""
            v134
        | US5_0(v133) -> (* Some *)
            v133
    let _v1 = v136 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v137 : US3 = US3_1
    let v138 : US4 = US4_2(v137)
    let v139 : string = $"file_system.get_file_name / target: {v138} / path: {v0}"
    let v140 : string = failwith<string> v139
    let _v1 = v140 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v141 : string = null |> unbox<string>
    let _v1 = v141 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v144 : US3 = US3_0
    let v145 : US4 = US4_3(v144)
    let v146 : string = $"file_system.get_file_name / target: {v145} / path: {v0}"
    let v147 : string = failwith<string> v146
    let _v1 = v147 
    #endif
#if FABLE_COMPILER_PYTHON
    let v148 : US3 = US3_0
    let v149 : US4 = US4_4(v148)
    let v150 : string = $"file_system.get_file_name / target: {v149} / path: {v0}"
    let v151 : string = failwith<string> v150
    let _v1 = v151 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v152 : US3 = US3_1
    let v153 : US4 = US4_0(v152)
    let v154 : string = $"file_system.get_file_name / target: {v153} / path: {v0}"
    let v155 : string = failwith<string> v154
    let _v1 = v155 
    #endif
#else
    let v156 : (string -> string) = System.IO.Path.GetFileName
    let v157 : string = v156 v0
    let _v1 = v157 
    #endif
    let v158 : string = _v1 
    v158
and method21 (v0 : string, v1 : string) : string =
    let v2 : string = method17()
    let v3 : Mut3 = {l0 = v2} : Mut3
    let v4 : string = "{ "
    let v5 : string = $"{v4}"
    let v8 : unit = ()
    let v9 : (unit -> unit) = closure6(v3, v5)
    let v10 : unit = (fun () -> v9 (); v8) ()
    let v13 : string = "ex"
    let v14 : string = $"{v13}"
    let v17 : unit = ()
    let v18 : (unit -> unit) = closure6(v3, v14)
    let v19 : unit = (fun () -> v18 (); v17) ()
    let v22 : string = " = "
    let v23 : string = $"{v22}"
    let v26 : unit = ()
    let v27 : (unit -> unit) = closure6(v3, v23)
    let v28 : unit = (fun () -> v27 (); v26) ()
    let v31 : string = $"{v0}"
    let v34 : unit = ()
    let v35 : (unit -> unit) = closure6(v3, v31)
    let v36 : unit = (fun () -> v35 (); v34) ()
    let v39 : string = "; "
    let v40 : string = $"{v39}"
    let v43 : unit = ()
    let v44 : (unit -> unit) = closure6(v3, v40)
    let v45 : unit = (fun () -> v44 (); v43) ()
    let v48 : string = "path"
    let v49 : string = $"{v48}"
    let v52 : unit = ()
    let v53 : (unit -> unit) = closure6(v3, v49)
    let v54 : unit = (fun () -> v53 (); v52) ()
    let v57 : string = $"{v22}"
    let v60 : unit = ()
    let v61 : (unit -> unit) = closure6(v3, v57)
    let v62 : unit = (fun () -> v61 (); v60) ()
    let v65 : string = $"{v1}"
    let v68 : unit = ()
    let v69 : (unit -> unit) = closure6(v3, v65)
    let v70 : unit = (fun () -> v69 (); v68) ()
    let v73 : string = " }"
    let v74 : string = $"{v73}"
    let v77 : unit = ()
    let v78 : (unit -> unit) = closure6(v3, v74)
    let v79 : unit = (fun () -> v78 (); v77) ()
    let v82 : string = v3.l0
    v82
and method22 (v0 : string) : string =
    let v1 : char list = []
    let v2 : (char list -> (char [])) = List.toArray
    let v3 : (char []) = v2 v1
    let v6 : string = v0.TrimStart v3 
    let v30 : char list = []
    let v31 : char list = '/' :: v30 
    let v34 : char list = ' ' :: v31 
    let v37 : (char list -> (char [])) = List.toArray
    let v38 : (char []) = v37 v34
    let v41 : string = v6.TrimEnd v38 
    v41
and method20 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : string, v9 : string) : string =
    let v10 : string = method21(v8, v9)
    let v11 : int64 = v0.l0
    let v12 : string = "file_system.delete_directory_async"
    let v13 : string = $"{v6} {v7} #{v11} %s{v12} / {v10}"
    method22(v13)
and closure7 (v0 : Mut0) () : unit =
    let v1 : int64 = v0.l0
    let v2 : int64 = v1 + 1L
    v0.l0 <- v2
    ()
and closure9 (v0 : string) () : unit =
    let v1 : (string -> unit) = System.Console.WriteLine
    v1 v0
and closure8 () (v0 : string) : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure9(v0)
    let v3 : unit = (fun () -> v2 (); v1) ()
    ()
and method23 (v0 : string) : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure0()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v17 : Mut0, v18 : Mut1, v19 : Mut2, v20 : Mut3, v21 : Mut4, v22 : int64 option) = TraceState.trace_state.Value
    let v35 : unit = ()
    let v36 : (unit -> unit) = closure7(v17)
    let v37 : unit = (fun () -> v36 (); v35) ()
    let v40 : (string -> unit) = closure8()
    let v41 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v42 : string = @"println!(""{}"", $0)"
    Fable.Core.RustInterop.emitRustExpr v0 v42 
    let _v41 = () 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v43 : string = @"println!(""{}"", $0)"
    Fable.Core.RustInterop.emitRustExpr v0 v43 
    let _v41 = () 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v44 : string = v20.l0
    let v45 : bool = v44 = ""
    let v53 : string =
        if v45 then
            v0
        else
            let v46 : bool = v0 = ""
            if v46 then
                let v47 : string = v20.l0
                v47
            else
                let v48 : string = v20.l0
                let v49 : string = "\n"
                let v50 : string = v48 + v49 
                let v51 : string = v50 + v0 
                v51
    let v54 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v55 : string = "&*$0"
    let v56 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v53 v55 
    let _v54 = v56 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v57 : string = "&*$0"
    let v58 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v53 v57 
    let _v54 = v58 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v59 : string = "&*$0"
    let v60 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v53 v59 
    let _v54 = v60 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v61 : Ref<Str> = v53 |> unbox<Ref<Str>>
    let _v54 = v61 
    #endif
#if FABLE_COMPILER_PYTHON
    let v64 : Ref<Str> = v53 |> unbox<Ref<Str>>
    let _v54 = v64 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v67 : Ref<Str> = v53 |> unbox<Ref<Str>>
    let _v54 = v67 
    #endif
#else
    let v70 : Ref<Str> = v53 |> unbox<Ref<Str>>
    let _v54 = v70 
    #endif
    let v73 : Ref<Str> = _v54 
    let v78 : string = $"$0.chars()"
    let v79 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v73 v78 
    let v80 : string = "$0"
    let v81 : _ = Fable.Core.RustInterop.emitRustExpr v79 v80 
    let v82 : string = "$0.collect::<Vec<_>>()"
    let v83 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v81 v82 
    let v84 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
    let v85 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v83 v84 
    let v86 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
    let v87 : bool = Fable.Core.RustInterop.emitRustExpr v85 v86 
    let v88 : string = "x"
    let v89 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v88 
    let v90 : string = "String::from_iter($0)"
    let v91 : std_string_String = Fable.Core.RustInterop.emitRustExpr v89 v90 
    let v92 : string = "true; $0 }).collect::<Vec<_>>()"
    let v93 : bool = Fable.Core.RustInterop.emitRustExpr v91 v92 
    let v94 : string = "_vec_map"
    let v95 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v94 
    let v96 : string = "$0.len()"
    let v97 : unativeint = Fable.Core.RustInterop.emitRustExpr v95 v96 
    let v98 : int32 = v97 |> int32 
    let v105 : string = ""
    let v106 : bool = v0 <> v105 
    let v110 : bool =
        if v106 then
            let v109 : bool = v98 <= 1
            v109
        else
            false
    if v110 then
        v20.l0 <- v53
        ()
    else
        v20.l0 <- v105
        let v111 : string = "true; $0.into_iter().for_each(|x| { //"
        let v112 : bool = Fable.Core.RustInterop.emitRustExpr v95 v111 
        let v113 : string = "x"
        let v114 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v113 
        let v115 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
        let v116 : bool = Fable.Core.RustInterop.emitRustExpr v114 v115 
        let v117 : string = $"true"
        let v118 : bool = Fable.Core.RustInterop.emitRustExpr () v117 
        let v119 : string = "true; }); //"
        let v120 : bool = Fable.Core.RustInterop.emitRustExpr () v119 
        ()
    let _v41 = () 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    v40 v0
    let _v41 = () 
    #endif
#if FABLE_COMPILER_PYTHON
    v40 v0
    let _v41 = () 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    v40 v0
    let _v41 = () 
    #endif
#else
    v40 v0
    let _v41 = () 
    #endif
    _v41 
    let v121 : (string -> unit) = v18.l0
    v121 v0
and closure4 (v0 : string, v1 : string) () : unit =
    let v2 : US0 = US0_1
    let v3 : bool = method10(v2)
    if v3 then
        let v4 : unit = ()
        let v5 : (unit -> unit) = closure0()
        let v6 : unit = (fun () -> v5 (); v4) ()
        let struct (v20 : Mut0, v21 : Mut1, v22 : Mut2, v23 : Mut3, v24 : Mut4, v25 : int64 option) = TraceState.trace_state.Value
        let v38 : string = method11(v20, v21, v22, v23, v24, v25)
        let v39 : string = method15()
        let v40 : string = method19(v0)
        let v41 : string = method20(v20, v21, v22, v23, v24, v25, v38, v39, v1, v40)
        method23(v41)
and method24 (v0 : int32) : Async<unit> =
    let v1 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : (int32 -> Async<unit>) = Async.Sleep
    let v3 : Async<unit> = v2 v0
    let _v1 = v3 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v4 : (int32 -> Async<unit>) = Async.Sleep
    let v5 : Async<unit> = v4 v0
    let _v1 = v5 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v6 : (int32 -> Async<unit>) = Async.Sleep
    let v7 : Async<unit> = v6 v0
    let _v1 = v7 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v8 : (int32 -> Async<unit>) = Async.Sleep
    let v9 : Async<unit> = v8 v0
    let _v1 = v9 
    #endif
#if FABLE_COMPILER_PYTHON
    let v10 : (int32 -> Async<unit>) = Async.Sleep
    let v11 : Async<unit> = v10 v0
    let _v1 = v11 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v12 : (int32 -> Async<unit>) = Async.Sleep
    let v13 : Async<unit> = v12 v0
    let _v1 = v13 
    #endif
#else
    let v14 : (int32 -> Async<unit>) = Async.Sleep
    let v15 : Async<unit> = v14 v0
    let _v1 = v15 
    #endif
    let v16 : Async<unit> = _v1 
    v16
and method7 (v0 : string, v1 : int64) : Async<int64> =
    let v2 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : Async<int64> = null |> unbox<Async<int64>>
    let _v2 = v3 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v6 : Async<int64> = null |> unbox<Async<int64>>
    let _v2 = v6 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v9 : Async<int64> = null |> unbox<Async<int64>>
    let _v2 = v9 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v12 : unit = ()
    let _v12 =
        async {
            try
            let v15 : bool = true
            method8(v15, v0)
            return v1 
            with ex ->
                let v16 : exn = ex
                let v17 : int64 = v1 % 100L
                let v18 : bool = v17 = 0L
                if v18 then
                    let v19 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v20 : string = $"%A{v16}"
                    let _v19 = v20 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v23 : string = $"%A{v16}"
                    let _v19 = v23 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v26 : string = $"%A{v16}"
                    let _v19 = v26 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v29 : string = $"%A{v16}"
                    let _v19 = v29 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v32 : string = $"%A{v16}"
                    let _v19 = v32 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v35 : string = $"%A{v16}"
                    let _v19 = v35 
                    #endif
#else
                    let v38 : string = $"{v16.GetType ()}: {v16.Message}"
                    let _v19 = v38 
                    #endif
                    let v39 : string = _v19 
                    let v44 : unit = ()
                    let v45 : (unit -> unit) = closure4(v0, v39)
                    let v46 : unit = (fun () -> v45 (); v44) ()
                    ()
                let v87 : int32 = 10
                let v88 : Async<unit> = method24(v87)
                do! v88 
                let v89 : int64 = v1 + 1L
                let v90 : Async<int64> = method7(v0, v89)
                return! v90 
                (*
                ()
            *)
            (*
            let v166 : int64 = *)
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v1231 : Async<int64> = _v12 
    let _v2 = v1231 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1232 : unit = ()
    let _v1232 =
        async {
            try
            let v1235 : bool = true
            method8(v1235, v0)
            return v1 
            with ex ->
                let v1236 : exn = ex
                let v1237 : int64 = v1 % 100L
                let v1238 : bool = v1237 = 0L
                if v1238 then
                    let v1239 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1240 : string = $"%A{v1236}"
                    let _v1239 = v1240 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v1243 : string = $"%A{v1236}"
                    let _v1239 = v1243 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1246 : string = $"%A{v1236}"
                    let _v1239 = v1246 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v1249 : string = $"%A{v1236}"
                    let _v1239 = v1249 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v1252 : string = $"%A{v1236}"
                    let _v1239 = v1252 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v1255 : string = $"%A{v1236}"
                    let _v1239 = v1255 
                    #endif
#else
                    let v1258 : string = $"{v1236.GetType ()}: {v1236.Message}"
                    let _v1239 = v1258 
                    #endif
                    let v1259 : string = _v1239 
                    let v1264 : unit = ()
                    let v1265 : (unit -> unit) = closure4(v0, v1259)
                    let v1266 : unit = (fun () -> v1265 (); v1264) ()
                    ()
                let v1307 : int32 = 10
                let v1308 : Async<unit> = method24(v1307)
                do! v1308 
                let v1309 : int64 = v1 + 1L
                let v1310 : Async<int64> = method7(v0, v1309)
                return! v1310 
                (*
                ()
            *)
            (*
            let v1386 : int64 = *)
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v2451 : Async<int64> = _v1232 
    let _v2 = v2451 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v2452 : unit = ()
    let _v2452 =
        async {
            try
            let v2455 : bool = true
            method8(v2455, v0)
            return v1 
            with ex ->
                let v2456 : exn = ex
                let v2457 : int64 = v1 % 100L
                let v2458 : bool = v2457 = 0L
                if v2458 then
                    let v2459 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v2460 : string = $"%A{v2456}"
                    let _v2459 = v2460 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v2463 : string = $"%A{v2456}"
                    let _v2459 = v2463 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v2466 : string = $"%A{v2456}"
                    let _v2459 = v2466 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v2469 : string = $"%A{v2456}"
                    let _v2459 = v2469 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v2472 : string = $"%A{v2456}"
                    let _v2459 = v2472 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v2475 : string = $"%A{v2456}"
                    let _v2459 = v2475 
                    #endif
#else
                    let v2478 : string = $"{v2456.GetType ()}: {v2456.Message}"
                    let _v2459 = v2478 
                    #endif
                    let v2479 : string = _v2459 
                    let v2484 : unit = ()
                    let v2485 : (unit -> unit) = closure4(v0, v2479)
                    let v2486 : unit = (fun () -> v2485 (); v2484) ()
                    ()
                let v2527 : int32 = 10
                let v2528 : Async<unit> = method24(v2527)
                do! v2528 
                let v2529 : int64 = v1 + 1L
                let v2530 : Async<int64> = method7(v0, v2529)
                return! v2530 
                (*
                ()
            *)
            (*
            let v2606 : int64 = *)
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v3671 : Async<int64> = _v2452 
    let _v2 = v3671 
    #endif
#else
    let v3672 : unit = ()
    let _v3672 =
        async {
            try
            let v3675 : bool = true
            method8(v3675, v0)
            return v1 
            with ex ->
                let v3676 : exn = ex
                let v3677 : int64 = v1 % 100L
                let v3678 : bool = v3677 = 0L
                if v3678 then
                    let v3679 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v3680 : string = $"%A{v3676}"
                    let _v3679 = v3680 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v3683 : string = $"%A{v3676}"
                    let _v3679 = v3683 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v3686 : string = $"%A{v3676}"
                    let _v3679 = v3686 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v3689 : string = $"%A{v3676}"
                    let _v3679 = v3689 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v3692 : string = $"%A{v3676}"
                    let _v3679 = v3692 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v3695 : string = $"%A{v3676}"
                    let _v3679 = v3695 
                    #endif
#else
                    let v3698 : string = $"{v3676.GetType ()}: {v3676.Message}"
                    let _v3679 = v3698 
                    #endif
                    let v3699 : string = _v3679 
                    let v3704 : unit = ()
                    let v3705 : (unit -> unit) = closure4(v0, v3699)
                    let v3706 : unit = (fun () -> v3705 (); v3704) ()
                    ()
                let v3747 : int32 = 10
                let v3748 : Async<unit> = method24(v3747)
                do! v3748 
                let v3749 : int64 = v1 + 1L
                let v3750 : Async<int64> = method7(v0, v3749)
                return! v3750 
                (*
                ()
            *)
            (*
            let v3826 : int64 = *)
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v4891 : Async<int64> = _v3672 
    let _v2 = v4891 
    #endif
    let v4892 : Async<int64> = _v2 
    v4892
and method6 (v0 : string) : Async<int64> =
    let v1 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : Async<int64> = null |> unbox<Async<int64>>
    let _v1 = v2 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v5 : Async<int64> = null |> unbox<Async<int64>>
    let _v1 = v5 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v8 : Async<int64> = null |> unbox<Async<int64>>
    let _v1 = v8 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v11 : Async<int64> = null |> unbox<Async<int64>>
    let _v1 = v11 
    #endif
#if FABLE_COMPILER_PYTHON
    let v14 : Async<int64> = null |> unbox<Async<int64>>
    let _v1 = v14 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v17 : Async<int64> = null |> unbox<Async<int64>>
    let _v1 = v17 
    #endif
#else
    let v20 : int64 = 0L
    let v21 : Async<int64> = method7(v0, v20)
    let _v1 = v21 
    #endif
    let v22 : Async<int64> = _v1 
    v22
and closure3 () (v0 : string) : Async<int64> =
    method6(v0)
and method28 (v0 : string, v1 : int64, v2 : string) : string =
    let v3 : string = method17()
    let v4 : Mut3 = {l0 = v3} : Mut3
    let v5 : string = "{ "
    let v6 : string = $"{v5}"
    let v9 : unit = ()
    let v10 : (unit -> unit) = closure6(v4, v6)
    let v11 : unit = (fun () -> v10 (); v9) ()
    let v14 : string = "path"
    let v15 : string = $"{v14}"
    let v18 : unit = ()
    let v19 : (unit -> unit) = closure6(v4, v15)
    let v20 : unit = (fun () -> v19 (); v18) ()
    let v23 : string = " = "
    let v24 : string = $"{v23}"
    let v27 : unit = ()
    let v28 : (unit -> unit) = closure6(v4, v24)
    let v29 : unit = (fun () -> v28 (); v27) ()
    let v32 : string = $"{v0}"
    let v35 : unit = ()
    let v36 : (unit -> unit) = closure6(v4, v32)
    let v37 : unit = (fun () -> v36 (); v35) ()
    let v40 : string = "; "
    let v41 : string = $"{v40}"
    let v44 : unit = ()
    let v45 : (unit -> unit) = closure6(v4, v41)
    let v46 : unit = (fun () -> v45 (); v44) ()
    let v49 : string = "retry"
    let v50 : string = $"{v49}"
    let v53 : unit = ()
    let v54 : (unit -> unit) = closure6(v4, v50)
    let v55 : unit = (fun () -> v54 (); v53) ()
    let v58 : string = $"{v23}"
    let v61 : unit = ()
    let v62 : (unit -> unit) = closure6(v4, v58)
    let v63 : unit = (fun () -> v62 (); v61) ()
    let v66 : string = $"{v1}"
    let v69 : unit = ()
    let v70 : (unit -> unit) = closure6(v4, v66)
    let v71 : unit = (fun () -> v70 (); v69) ()
    let v74 : string = $"{v40}"
    let v77 : unit = ()
    let v78 : (unit -> unit) = closure6(v4, v74)
    let v79 : unit = (fun () -> v78 (); v77) ()
    let v82 : string = "ex"
    let v83 : string = $"{v82}"
    let v86 : unit = ()
    let v87 : (unit -> unit) = closure6(v4, v83)
    let v88 : unit = (fun () -> v87 (); v86) ()
    let v91 : string = $"{v23}"
    let v94 : unit = ()
    let v95 : (unit -> unit) = closure6(v4, v91)
    let v96 : unit = (fun () -> v95 (); v94) ()
    let v99 : string = $"{v2}"
    let v102 : unit = ()
    let v103 : (unit -> unit) = closure6(v4, v99)
    let v104 : unit = (fun () -> v103 (); v102) ()
    let v107 : string = " }"
    let v108 : string = $"{v107}"
    let v111 : unit = ()
    let v112 : (unit -> unit) = closure6(v4, v108)
    let v113 : unit = (fun () -> v112 (); v111) ()
    let v116 : string = v4.l0
    v116
and method27 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : string, v9 : int64, v10 : string) : string =
    let v11 : string = method28(v8, v9, v10)
    let v12 : int64 = v0.l0
    let v13 : string = "file_system.wait_for_file_access"
    let v14 : string = $"{v6} {v7} #{v12} %s{v13} / {v11}"
    method22(v14)
and closure12 (v0 : string, v1 : int64, v2 : string) () : unit =
    let v3 : US0 = US0_1
    let v4 : bool = method10(v3)
    if v4 then
        let v5 : unit = ()
        let v6 : (unit -> unit) = closure0()
        let v7 : unit = (fun () -> v6 (); v5) ()
        let struct (v21 : Mut0, v22 : Mut1, v23 : Mut2, v24 : Mut3, v25 : Mut4, v26 : int64 option) = TraceState.trace_state.Value
        let v39 : string = method11(v21, v22, v23, v24, v25, v26)
        let v40 : string = method15()
        let v41 : string = method19(v0)
        let v42 : string = method27(v21, v22, v23, v24, v25, v26, v39, v40, v41, v1, v2)
        method23(v42)
and method26 (v0 : string, v1 : US8, v2 : US7, v3 : int64) : Async<int64> =
    let v4 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v5 : Async<int64> = null |> unbox<Async<int64>>
    let _v4 = v5 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v8 : Async<int64> = null |> unbox<Async<int64>>
    let _v4 = v8 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v11 : Async<int64> = null |> unbox<Async<int64>>
    let _v4 = v11 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v14 : unit = ()
    let _v14 =
        async {
            try
            let v17 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v18 : System.IO.FileStream = null |> unbox<System.IO.FileStream>
            let _v17 = v18 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v21 : System.IO.FileStream = null |> unbox<System.IO.FileStream>
            let _v17 = v21 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v24 : System.IO.FileStream = null |> unbox<System.IO.FileStream>
            let _v17 = v24 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v27 : System.IO.FileStream = null |> unbox<System.IO.FileStream>
            let _v17 = v27 
            #endif
#if FABLE_COMPILER_PYTHON
            let v30 : System.IO.FileStream = null |> unbox<System.IO.FileStream>
            let _v17 = v30 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v33 : System.IO.FileStream = null |> unbox<System.IO.FileStream>
            let _v17 = v33 
            #endif
#else
            let v36 : System.IO.FileMode = System.IO.FileMode.Open
            let v42 : System.IO.FileAccess =
                match v2 with
                | US7_0 -> (* AccessRead *)
                    let v37 : System.IO.FileAccess = System.IO.FileAccess.Read
                    v37
                | US7_2 -> (* AccessReadWrite *)
                    let v39 : System.IO.FileAccess = System.IO.FileAccess.ReadWrite
                    v39
                | US7_1 -> (* AccessWrite *)
                    let v38 : System.IO.FileAccess = System.IO.FileAccess.ReadWrite
                    v38
            let v52 : System.IO.FileShare =
                match v1 with
                | US8_4 -> (* ShareDelete *)
                    let v47 : System.IO.FileShare = System.IO.FileShare.Delete
                    v47
                | US8_0 -> (* ShareNone *)
                    let v43 : System.IO.FileShare = System.IO.FileShare.None
                    v43
                | US8_1 -> (* ShareRead *)
                    let v44 : System.IO.FileShare = System.IO.FileShare.Read
                    v44
                | US8_3 -> (* ShareReadWrite *)
                    let v46 : System.IO.FileShare = System.IO.FileShare.ReadWrite
                    v46
                | US8_2 -> (* ShareWrite *)
                    let v45 : System.IO.FileShare = System.IO.FileShare.Write
                    v45
            let v53 : System.IO.FileStream = new System.IO.FileStream (v0, v36, v42, v52)
            let _v17 = v53 
            #endif
            let v54 : System.IO.FileStream = _v17 
            use v54 = v54 
            let v59 : System.IO.FileStream = v54 
            return v3 
            with ex ->
                let v60 : exn = ex
                let v61 : bool = v3 > 0L
                let v64 : bool =
                    if v61 then
                        let v62 : int64 = v3 % 100L
                        let v63 : bool = v62 = 0L
                        v63
                    else
                        false
                if v64 then
                    let v65 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v66 : string = $"%A{v60}"
                    let _v65 = v66 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v69 : string = $"%A{v60}"
                    let _v65 = v69 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v72 : string = $"%A{v60}"
                    let _v65 = v72 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v75 : string = $"%A{v60}"
                    let _v65 = v75 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v78 : string = $"%A{v60}"
                    let _v65 = v78 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v81 : string = $"%A{v60}"
                    let _v65 = v81 
                    #endif
#else
                    let v84 : string = $"{v60.GetType ()}: {v60.Message}"
                    let _v65 = v84 
                    #endif
                    let v85 : string = _v65 
                    let v90 : unit = ()
                    let v91 : (unit -> unit) = closure12(v0, v3, v85)
                    let v92 : unit = (fun () -> v91 (); v90) ()
                    ()
                let v133 : int32 = 10
                let v134 : Async<unit> = method24(v133)
                do! v134 
                let v135 : int64 = v3 + 1L
                let v136 : Async<int64> = method26(v0, v1, v2, v135)
                return! v136 
                (*
                ()
            *)
            (*
            let v214 : int64 = *)
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v1601 : Async<int64> = _v14 
    let _v4 = v1601 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1602 : unit = ()
    let _v1602 =
        async {
            try
            let v1605 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1606 : System.IO.FileStream = null |> unbox<System.IO.FileStream>
            let _v1605 = v1606 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1609 : System.IO.FileStream = null |> unbox<System.IO.FileStream>
            let _v1605 = v1609 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1612 : System.IO.FileStream = null |> unbox<System.IO.FileStream>
            let _v1605 = v1612 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1615 : System.IO.FileStream = null |> unbox<System.IO.FileStream>
            let _v1605 = v1615 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1618 : System.IO.FileStream = null |> unbox<System.IO.FileStream>
            let _v1605 = v1618 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1621 : System.IO.FileStream = null |> unbox<System.IO.FileStream>
            let _v1605 = v1621 
            #endif
#else
            let v1624 : System.IO.FileMode = System.IO.FileMode.Open
            let v1630 : System.IO.FileAccess =
                match v2 with
                | US7_0 -> (* AccessRead *)
                    let v1625 : System.IO.FileAccess = System.IO.FileAccess.Read
                    v1625
                | US7_2 -> (* AccessReadWrite *)
                    let v1627 : System.IO.FileAccess = System.IO.FileAccess.ReadWrite
                    v1627
                | US7_1 -> (* AccessWrite *)
                    let v1626 : System.IO.FileAccess = System.IO.FileAccess.ReadWrite
                    v1626
            let v1640 : System.IO.FileShare =
                match v1 with
                | US8_4 -> (* ShareDelete *)
                    let v1635 : System.IO.FileShare = System.IO.FileShare.Delete
                    v1635
                | US8_0 -> (* ShareNone *)
                    let v1631 : System.IO.FileShare = System.IO.FileShare.None
                    v1631
                | US8_1 -> (* ShareRead *)
                    let v1632 : System.IO.FileShare = System.IO.FileShare.Read
                    v1632
                | US8_3 -> (* ShareReadWrite *)
                    let v1634 : System.IO.FileShare = System.IO.FileShare.ReadWrite
                    v1634
                | US8_2 -> (* ShareWrite *)
                    let v1633 : System.IO.FileShare = System.IO.FileShare.Write
                    v1633
            let v1641 : System.IO.FileStream = new System.IO.FileStream (v0, v1624, v1630, v1640)
            let _v1605 = v1641 
            #endif
            let v1642 : System.IO.FileStream = _v1605 
            use v1642 = v1642 
            let v1647 : System.IO.FileStream = v1642 
            return v3 
            with ex ->
                let v1648 : exn = ex
                let v1649 : bool = v3 > 0L
                let v1652 : bool =
                    if v1649 then
                        let v1650 : int64 = v3 % 100L
                        let v1651 : bool = v1650 = 0L
                        v1651
                    else
                        false
                if v1652 then
                    let v1653 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1654 : string = $"%A{v1648}"
                    let _v1653 = v1654 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v1657 : string = $"%A{v1648}"
                    let _v1653 = v1657 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1660 : string = $"%A{v1648}"
                    let _v1653 = v1660 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v1663 : string = $"%A{v1648}"
                    let _v1653 = v1663 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v1666 : string = $"%A{v1648}"
                    let _v1653 = v1666 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v1669 : string = $"%A{v1648}"
                    let _v1653 = v1669 
                    #endif
#else
                    let v1672 : string = $"{v1648.GetType ()}: {v1648.Message}"
                    let _v1653 = v1672 
                    #endif
                    let v1673 : string = _v1653 
                    let v1678 : unit = ()
                    let v1679 : (unit -> unit) = closure12(v0, v3, v1673)
                    let v1680 : unit = (fun () -> v1679 (); v1678) ()
                    ()
                let v1721 : int32 = 10
                let v1722 : Async<unit> = method24(v1721)
                do! v1722 
                let v1723 : int64 = v3 + 1L
                let v1724 : Async<int64> = method26(v0, v1, v2, v1723)
                return! v1724 
                (*
                ()
            *)
            (*
            let v1802 : int64 = *)
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v3189 : Async<int64> = _v1602 
    let _v4 = v3189 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v3190 : unit = ()
    let _v3190 =
        async {
            try
            let v3193 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v3194 : System.IO.FileStream = null |> unbox<System.IO.FileStream>
            let _v3193 = v3194 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v3197 : System.IO.FileStream = null |> unbox<System.IO.FileStream>
            let _v3193 = v3197 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v3200 : System.IO.FileStream = null |> unbox<System.IO.FileStream>
            let _v3193 = v3200 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v3203 : System.IO.FileStream = null |> unbox<System.IO.FileStream>
            let _v3193 = v3203 
            #endif
#if FABLE_COMPILER_PYTHON
            let v3206 : System.IO.FileStream = null |> unbox<System.IO.FileStream>
            let _v3193 = v3206 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v3209 : System.IO.FileStream = null |> unbox<System.IO.FileStream>
            let _v3193 = v3209 
            #endif
#else
            let v3212 : System.IO.FileMode = System.IO.FileMode.Open
            let v3218 : System.IO.FileAccess =
                match v2 with
                | US7_0 -> (* AccessRead *)
                    let v3213 : System.IO.FileAccess = System.IO.FileAccess.Read
                    v3213
                | US7_2 -> (* AccessReadWrite *)
                    let v3215 : System.IO.FileAccess = System.IO.FileAccess.ReadWrite
                    v3215
                | US7_1 -> (* AccessWrite *)
                    let v3214 : System.IO.FileAccess = System.IO.FileAccess.ReadWrite
                    v3214
            let v3228 : System.IO.FileShare =
                match v1 with
                | US8_4 -> (* ShareDelete *)
                    let v3223 : System.IO.FileShare = System.IO.FileShare.Delete
                    v3223
                | US8_0 -> (* ShareNone *)
                    let v3219 : System.IO.FileShare = System.IO.FileShare.None
                    v3219
                | US8_1 -> (* ShareRead *)
                    let v3220 : System.IO.FileShare = System.IO.FileShare.Read
                    v3220
                | US8_3 -> (* ShareReadWrite *)
                    let v3222 : System.IO.FileShare = System.IO.FileShare.ReadWrite
                    v3222
                | US8_2 -> (* ShareWrite *)
                    let v3221 : System.IO.FileShare = System.IO.FileShare.Write
                    v3221
            let v3229 : System.IO.FileStream = new System.IO.FileStream (v0, v3212, v3218, v3228)
            let _v3193 = v3229 
            #endif
            let v3230 : System.IO.FileStream = _v3193 
            use v3230 = v3230 
            let v3235 : System.IO.FileStream = v3230 
            return v3 
            with ex ->
                let v3236 : exn = ex
                let v3237 : bool = v3 > 0L
                let v3240 : bool =
                    if v3237 then
                        let v3238 : int64 = v3 % 100L
                        let v3239 : bool = v3238 = 0L
                        v3239
                    else
                        false
                if v3240 then
                    let v3241 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v3242 : string = $"%A{v3236}"
                    let _v3241 = v3242 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v3245 : string = $"%A{v3236}"
                    let _v3241 = v3245 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v3248 : string = $"%A{v3236}"
                    let _v3241 = v3248 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v3251 : string = $"%A{v3236}"
                    let _v3241 = v3251 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v3254 : string = $"%A{v3236}"
                    let _v3241 = v3254 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v3257 : string = $"%A{v3236}"
                    let _v3241 = v3257 
                    #endif
#else
                    let v3260 : string = $"{v3236.GetType ()}: {v3236.Message}"
                    let _v3241 = v3260 
                    #endif
                    let v3261 : string = _v3241 
                    let v3266 : unit = ()
                    let v3267 : (unit -> unit) = closure12(v0, v3, v3261)
                    let v3268 : unit = (fun () -> v3267 (); v3266) ()
                    ()
                let v3309 : int32 = 10
                let v3310 : Async<unit> = method24(v3309)
                do! v3310 
                let v3311 : int64 = v3 + 1L
                let v3312 : Async<int64> = method26(v0, v1, v2, v3311)
                return! v3312 
                (*
                ()
            *)
            (*
            let v3390 : int64 = *)
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v4777 : Async<int64> = _v3190 
    let _v4 = v4777 
    #endif
#else
    let v4778 : unit = ()
    let _v4778 =
        async {
            try
            let v4781 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v4782 : System.IO.FileStream = null |> unbox<System.IO.FileStream>
            let _v4781 = v4782 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v4785 : System.IO.FileStream = null |> unbox<System.IO.FileStream>
            let _v4781 = v4785 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v4788 : System.IO.FileStream = null |> unbox<System.IO.FileStream>
            let _v4781 = v4788 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v4791 : System.IO.FileStream = null |> unbox<System.IO.FileStream>
            let _v4781 = v4791 
            #endif
#if FABLE_COMPILER_PYTHON
            let v4794 : System.IO.FileStream = null |> unbox<System.IO.FileStream>
            let _v4781 = v4794 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v4797 : System.IO.FileStream = null |> unbox<System.IO.FileStream>
            let _v4781 = v4797 
            #endif
#else
            let v4800 : System.IO.FileMode = System.IO.FileMode.Open
            let v4806 : System.IO.FileAccess =
                match v2 with
                | US7_0 -> (* AccessRead *)
                    let v4801 : System.IO.FileAccess = System.IO.FileAccess.Read
                    v4801
                | US7_2 -> (* AccessReadWrite *)
                    let v4803 : System.IO.FileAccess = System.IO.FileAccess.ReadWrite
                    v4803
                | US7_1 -> (* AccessWrite *)
                    let v4802 : System.IO.FileAccess = System.IO.FileAccess.ReadWrite
                    v4802
            let v4816 : System.IO.FileShare =
                match v1 with
                | US8_4 -> (* ShareDelete *)
                    let v4811 : System.IO.FileShare = System.IO.FileShare.Delete
                    v4811
                | US8_0 -> (* ShareNone *)
                    let v4807 : System.IO.FileShare = System.IO.FileShare.None
                    v4807
                | US8_1 -> (* ShareRead *)
                    let v4808 : System.IO.FileShare = System.IO.FileShare.Read
                    v4808
                | US8_3 -> (* ShareReadWrite *)
                    let v4810 : System.IO.FileShare = System.IO.FileShare.ReadWrite
                    v4810
                | US8_2 -> (* ShareWrite *)
                    let v4809 : System.IO.FileShare = System.IO.FileShare.Write
                    v4809
            let v4817 : System.IO.FileStream = new System.IO.FileStream (v0, v4800, v4806, v4816)
            let _v4781 = v4817 
            #endif
            let v4818 : System.IO.FileStream = _v4781 
            use v4818 = v4818 
            let v4823 : System.IO.FileStream = v4818 
            return v3 
            with ex ->
                let v4824 : exn = ex
                let v4825 : bool = v3 > 0L
                let v4828 : bool =
                    if v4825 then
                        let v4826 : int64 = v3 % 100L
                        let v4827 : bool = v4826 = 0L
                        v4827
                    else
                        false
                if v4828 then
                    let v4829 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v4830 : string = $"%A{v4824}"
                    let _v4829 = v4830 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v4833 : string = $"%A{v4824}"
                    let _v4829 = v4833 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v4836 : string = $"%A{v4824}"
                    let _v4829 = v4836 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v4839 : string = $"%A{v4824}"
                    let _v4829 = v4839 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v4842 : string = $"%A{v4824}"
                    let _v4829 = v4842 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v4845 : string = $"%A{v4824}"
                    let _v4829 = v4845 
                    #endif
#else
                    let v4848 : string = $"{v4824.GetType ()}: {v4824.Message}"
                    let _v4829 = v4848 
                    #endif
                    let v4849 : string = _v4829 
                    let v4854 : unit = ()
                    let v4855 : (unit -> unit) = closure12(v0, v3, v4849)
                    let v4856 : unit = (fun () -> v4855 (); v4854) ()
                    ()
                let v4897 : int32 = 10
                let v4898 : Async<unit> = method24(v4897)
                do! v4898 
                let v4899 : int64 = v3 + 1L
                let v4900 : Async<int64> = method26(v0, v1, v2, v4899)
                return! v4900 
                (*
                ()
            *)
            (*
            let v4978 : int64 = *)
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v6365 : Async<int64> = _v4778 
    let _v4 = v6365 
    #endif
    let v6366 : Async<int64> = _v4 
    v6366
and method25 (v0 : US6, v1 : string) : Async<int64> =
    let v2 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : Async<int64> = null |> unbox<Async<int64>>
    let _v2 = v3 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v6 : Async<int64> = null |> unbox<Async<int64>>
    let _v2 = v6 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v9 : Async<int64> = null |> unbox<Async<int64>>
    let _v2 = v9 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v12 : Async<int64> = null |> unbox<Async<int64>>
    let _v2 = v12 
    #endif
#if FABLE_COMPILER_PYTHON
    let v15 : Async<int64> = null |> unbox<Async<int64>>
    let _v2 = v15 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v18 : Async<int64> = null |> unbox<Async<int64>>
    let _v2 = v18 
    #endif
#else
    let struct (v27 : US7, v28 : US8) =
        match v0 with
        | US6_1 -> (* None *)
            let v23 : US7 = US7_2
            let v24 : US8 = US8_1
            struct (v23, v24)
        | US6_0(v21, v22) -> (* Some *)
            struct (v21, v22)
    let v29 : int64 = 0L
    let v30 : Async<int64> = method26(v1, v28, v27, v29)
    let _v2 = v30 
    #endif
    let v31 : Async<int64> = _v2 
    v31
and closure11 (v0 : US6) (v1 : string) : Async<int64> =
    method25(v0, v1)
and closure10 () (v0 : US6) : (string -> Async<int64>) =
    closure11(v0)
and method29 (v0 : string) : Async<int64> =
    let v1 : US7 = US7_0
    let v2 : US8 = US8_1
    let v3 : US6 = US6_0(v1, v2)
    method25(v3, v0)
and closure13 () (v0 : string) : Async<int64> =
    method29(v0)
and method31 (v0 : System.Threading.Tasks.Task<string>) : Async<string> =
    let v1 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : (System.Threading.Tasks.Task<string> -> Async<string>) = Async.AwaitTask
    let v3 : Async<string> = v2 v0
    let _v1 = v3 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v4 : (System.Threading.Tasks.Task<string> -> Async<string>) = Async.AwaitTask
    let v5 : Async<string> = v4 v0
    let _v1 = v5 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v6 : (System.Threading.Tasks.Task<string> -> Async<string>) = Async.AwaitTask
    let v7 : Async<string> = v6 v0
    let _v1 = v7 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v8 : (System.Threading.Tasks.Task<string> -> Async<string>) = Async.AwaitTask
    let v9 : Async<string> = v8 v0
    let _v1 = v9 
    #endif
#if FABLE_COMPILER_PYTHON
    let v10 : (System.Threading.Tasks.Task<string> -> Async<string>) = Async.AwaitTask
    let v11 : Async<string> = v10 v0
    let _v1 = v11 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v12 : (System.Threading.Tasks.Task<string> -> Async<string>) = Async.AwaitTask
    let v13 : Async<string> = v12 v0
    let _v1 = v13 
    #endif
#else
    let v14 : (System.Threading.Tasks.Task<string> -> Async<string>) = Async.AwaitTask
    let v15 : Async<string> = v14 v0
    let _v1 = v15 
    #endif
    let v16 : Async<string> = _v1 
    v16
and method30 (v0 : string) : Async<string> =
    let v1 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : Async<string> = null |> unbox<Async<string>>
    let _v1 = v2 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v5 : Async<string> = null |> unbox<Async<string>>
    let _v1 = v5 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v8 : Async<string> = null |> unbox<Async<string>>
    let _v1 = v8 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v11 : Async<string> = null |> unbox<Async<string>>
    let _v1 = v11 
    #endif
#if FABLE_COMPILER_PYTHON
    let v14 : Async<string> = null |> unbox<Async<string>>
    let _v1 = v14 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v17 : Async<string> = null |> unbox<Async<string>>
    let _v1 = v17 
    #endif
#else
    let v20 : (string -> System.Threading.Tasks.Task<string>) = System.IO.File.ReadAllTextAsync
    let v21 : System.Threading.Tasks.Task<string> = v20 v0
    let v22 : Async<string> = method31(v21)
    let _v1 = v22 
    #endif
    let v23 : Async<string> = _v1 
    v23
and closure14 () (v0 : string) : Async<string> =
    method30(v0)
and method33 (v0 : string) : bool =
    let v1 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : string = "&*$0"
    let v4 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v3 
    let _v2 = v4 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v5 : string = "&*$0"
    let v6 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v5 
    let _v2 = v6 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v7 : string = "&*$0"
    let v8 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v7 
    let _v2 = v8 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v9 : Ref<Str> = v0 |> unbox<Ref<Str>>
    let _v2 = v9 
    #endif
#if FABLE_COMPILER_PYTHON
    let v12 : Ref<Str> = v0 |> unbox<Ref<Str>>
    let _v2 = v12 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v15 : Ref<Str> = v0 |> unbox<Ref<Str>>
    let _v2 = v15 
    #endif
#else
    let v18 : Ref<Str> = v0 |> unbox<Ref<Str>>
    let _v2 = v18 
    #endif
    let v21 : Ref<Str> = _v2 
    let v26 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v27 : string = "String::from($0)"
    let v28 : std_string_String = Fable.Core.RustInterop.emitRustExpr v21 v27 
    let _v26 = v28 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v29 : string = "String::from($0)"
    let v30 : std_string_String = Fable.Core.RustInterop.emitRustExpr v21 v29 
    let _v26 = v30 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v31 : string = "String::from($0)"
    let v32 : std_string_String = Fable.Core.RustInterop.emitRustExpr v21 v31 
    let _v26 = v32 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v33 : std_string_String = v21 |> unbox<std_string_String>
    let _v26 = v33 
    #endif
#if FABLE_COMPILER_PYTHON
    let v36 : std_string_String = v21 |> unbox<std_string_String>
    let _v26 = v36 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v39 : std_string_String = v21 |> unbox<std_string_String>
    let _v26 = v39 
    #endif
#else
    let v42 : std_string_String = v21 |> unbox<std_string_String>
    let _v26 = v42 
    #endif
    let v45 : std_string_String = _v26 
    let v50 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v51 : string = "std::path::PathBuf::from($0)"
    let v52 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v45 v51 
    let _v50 = v52 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v53 : string = "std::path::PathBuf::from($0)"
    let v54 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v45 v53 
    let _v50 = v54 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v55 : string = "std::path::PathBuf::from($0)"
    let v56 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v45 v55 
    let _v50 = v56 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v57 : std_path_PathBuf = v45 |> unbox<std_path_PathBuf>
    let _v50 = v57 
    #endif
#if FABLE_COMPILER_PYTHON
    let v60 : std_path_PathBuf = v45 |> unbox<std_path_PathBuf>
    let _v50 = v60 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v63 : std_path_PathBuf = v45 |> unbox<std_path_PathBuf>
    let _v50 = v63 
    #endif
#else
    let v66 : std_path_PathBuf = v45 |> unbox<std_path_PathBuf>
    let _v50 = v66 
    #endif
    let v69 : std_path_PathBuf = _v50 
    let v74 : string = "$0.exists()"
    let v75 : bool = Fable.Core.RustInterop.emitRustExpr v69 v74 
    let v78 : bool =
        if v75 then
            let v76 : string = "$0.is_file()"
            let v77 : bool = Fable.Core.RustInterop.emitRustExpr v69 v76 
            v77
        else
            false
    let _v1 = v78 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v79 : bool = null |> unbox<bool>
    let _v1 = v79 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v82 : bool = null |> unbox<bool>
    let _v1 = v82 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v85 : string = "fs"
    let v86 : IFsExistsSync = Fable.Core.JsInterop.importAll v85 
    let v87 : string = "$0.existsSync($1)"
    let v88 : bool = Fable.Core.JsInterop.emitJsExpr struct (v86, v0) v87 
    let _v1 = v88 
    #endif
#if FABLE_COMPILER_PYTHON
    let v89 : bool = null |> unbox<bool>
    let _v1 = v89 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v92 : bool = null |> unbox<bool>
    let _v1 = v92 
    #endif
#else
    let v95 : (string -> bool) = System.IO.File.Exists
    let v96 : bool = v95 v0
    let _v1 = v96 
    #endif
    let v97 : bool = _v1 
    v97
and method34 (v0 : Vec<uint8>) : Vec<uint8> =
    v0
and method32 (v0 : string, v1 : string) : bool =
    let v2 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : bool = method33(v0)
    let v4 : bool = v3 = false
    let v87 : bool =
        if v4 then
            false
        else
            let v5 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v6 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v7 : string = "std::fs::read(&*$0)"
            let v8 : Result<Vec<uint8>, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v0 v7 
            let v9 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v10 : string = "$0.unwrap()"
            let v11 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v8 v10 
            let _v9 = v11 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v12 : string = "$0.unwrap()"
            let v13 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v8 v12 
            let _v9 = v13 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v14 : string = "$0.unwrap()"
            let v15 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v8 v14 
            let _v9 = v15 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v16 : Vec<uint8> = match v8 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v9 = v16 
            #endif
#if FABLE_COMPILER_PYTHON
            let v17 : Vec<uint8> = match v8 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v9 = v17 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v18 : Vec<uint8> = match v8 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v9 = v18 
            #endif
#else
            let v19 : Vec<uint8> = match v8 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v9 = v19 
            #endif
            let v20 : Vec<uint8> = _v9 
            let _v6 = v20 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v23 : Vec<uint8> = null |> unbox<Vec<uint8>>
            let _v6 = v23 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v26 : Vec<uint8> = null |> unbox<Vec<uint8>>
            let _v6 = v26 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v29 : Vec<uint8> = null |> unbox<Vec<uint8>>
            let _v6 = v29 
            #endif
#if FABLE_COMPILER_PYTHON
            let v32 : Vec<uint8> = null |> unbox<Vec<uint8>>
            let _v6 = v32 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v35 : Vec<uint8> = null |> unbox<Vec<uint8>>
            let _v6 = v35 
            #endif
#else
            let v38 : (uint8 []) = v0 |> System.IO.File.ReadAllBytes
            let v39 : string = "$0.to_vec()"
            let v40 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v38 v39 
            let _v6 = v40 
            #endif
            let v41 : Vec<uint8> = _v6 
            let v46 : Vec<uint8> = method34(v41)
            let v47 : string = "std::string::String::from_utf8($0)"
            let v48 : Result<std_string_String, std_string_FromUtf8Error> = Fable.Core.RustInterop.emitRustExpr v46 v47 
            let v49 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v50 : string = "$0.unwrap()"
            let v51 : std_string_String = Fable.Core.RustInterop.emitRustExpr v48 v50 
            let _v49 = v51 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v52 : string = "$0.unwrap()"
            let v53 : std_string_String = Fable.Core.RustInterop.emitRustExpr v48 v52 
            let _v49 = v53 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v54 : string = "$0.unwrap()"
            let v55 : std_string_String = Fable.Core.RustInterop.emitRustExpr v48 v54 
            let _v49 = v55 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v56 : std_string_String = match v48 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v49 = v56 
            #endif
#if FABLE_COMPILER_PYTHON
            let v57 : std_string_String = match v48 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v49 = v57 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v58 : std_string_String = match v48 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v49 = v58 
            #endif
#else
            let v59 : std_string_String = match v48 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v49 = v59 
            #endif
            let v60 : std_string_String = _v49 
            let v63 : string = "fable_library_rust::String_::fromString($0)"
            let v64 : string = Fable.Core.RustInterop.emitRustExpr v60 v63 
            let _v5 = v64 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v65 : string = null |> unbox<string>
            let _v5 = v65 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v68 : string = null |> unbox<string>
            let _v5 = v68 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v71 : string = null |> unbox<string>
            let _v5 = v71 
            #endif
#if FABLE_COMPILER_PYTHON
            let v74 : string = null |> unbox<string>
            let _v5 = v74 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v77 : string = null |> unbox<string>
            let _v5 = v77 
            #endif
#else
            let v80 : string = v0 |> System.IO.File.ReadAllText
            let _v5 = v80 
            #endif
            let v81 : string = _v5 
            let v86 : bool = v1 = v81
            v86
    let _v2 = v87 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v88 : bool = null |> unbox<bool>
    let _v2 = v88 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v91 : bool = null |> unbox<bool>
    let _v2 = v91 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v94 : bool = null |> unbox<bool>
    let _v2 = v94 
    #endif
#if FABLE_COMPILER_PYTHON
    let v97 : bool = null |> unbox<bool>
    let _v2 = v97 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v100 : bool = null |> unbox<bool>
    let _v2 = v100 
    #endif
#else
    let v103 : bool = null |> unbox<bool>
    let _v2 = v103 
    #endif
    let v106 : bool = _v2 
    v106
and closure16 (v0 : string) (v1 : string) : bool =
    method32(v0, v1)
and closure15 () (v0 : string) : (string -> bool) =
    closure16(v0)
and method36 (v0 : System.Threading.Tasks.Task) : Async<unit> =
    let v1 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
    let v3 : Async<unit> = v2 v0
    let _v1 = v3 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v4 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
    let v5 : Async<unit> = v4 v0
    let _v1 = v5 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v6 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
    let v7 : Async<unit> = v6 v0
    let _v1 = v7 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v8 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
    let v9 : Async<unit> = v8 v0
    let _v1 = v9 
    #endif
#if FABLE_COMPILER_PYTHON
    let v10 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
    let v11 : Async<unit> = v10 v0
    let _v1 = v11 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v12 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
    let v13 : Async<unit> = v12 v0
    let _v1 = v13 
    #endif
#else
    let v14 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
    let v15 : Async<unit> = v14 v0
    let _v1 = v15 
    #endif
    let v16 : Async<unit> = _v1 
    v16
and method35 (v0 : string, v1 : string) : Async<unit> =
    let v2 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : Async<unit> = null |> unbox<Async<unit>>
    let _v2 = v3 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v6 : Async<unit> = null |> unbox<Async<unit>>
    let _v2 = v6 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v9 : Async<unit> = null |> unbox<Async<unit>>
    let _v2 = v9 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v12 : Async<unit> = null |> unbox<Async<unit>>
    let _v2 = v12 
    #endif
#if FABLE_COMPILER_PYTHON
    let v15 : Async<unit> = null |> unbox<Async<unit>>
    let _v2 = v15 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v18 : Async<unit> = null |> unbox<Async<unit>>
    let _v2 = v18 
    #endif
#else
    let v21 : System.Threading.Tasks.Task = System.IO.File.WriteAllTextAsync (v0, v1)
    let v22 : Async<unit> = method36(v21)
    let _v2 = v22 
    #endif
    let v23 : Async<unit> = _v2 
    v23
and closure18 (v0 : string) (v1 : string) : Async<unit> =
    method35(v0, v1)
and closure17 () (v0 : string) : (string -> Async<unit>) =
    closure18(v0)
and method38 (v0 : string, v1 : string) : Async<bool> =
    let v2 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : Async<bool> = null |> unbox<Async<bool>>
    let _v2 = v3 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v6 : Async<bool> = null |> unbox<Async<bool>>
    let _v2 = v6 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v9 : Async<bool> = null |> unbox<Async<bool>>
    let _v2 = v9 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v12 : Async<bool> = null |> unbox<Async<bool>>
    let _v2 = v12 
    #endif
#if FABLE_COMPILER_PYTHON
    let v15 : Async<bool> = null |> unbox<Async<bool>>
    let _v2 = v15 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v18 : Async<bool> = null |> unbox<Async<bool>>
    let _v2 = v18 
    #endif
#else
    let v21 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v22 : Async<bool> = null |> unbox<Async<bool>>
    let _v21 = v22 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v25 : Async<bool> = null |> unbox<Async<bool>>
    let _v21 = v25 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v28 : Async<bool> = null |> unbox<Async<bool>>
    let _v21 = v28 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v31 : unit = ()
    let _v31 =
        async {
            let v34 : bool = method33(v0)
            let v35 : bool = v34 = false
            if v35 then
                return false 
                (*
                ()
            else
                *) else
                let v36 : Async<string> = method30(v0)
                let! v36 = v36 
                let v37 : string = v36 
                let v38 : bool = v1 = v37
                return v38 
                (*
                ()
            *)
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v74 : Async<bool> = _v31 
    let _v21 = v74 
    #endif
#if FABLE_COMPILER_PYTHON
    let v75 : unit = ()
    let _v75 =
        async {
            let v78 : bool = method33(v0)
            let v79 : bool = v78 = false
            if v79 then
                return false 
                (*
                ()
            else
                *) else
                let v80 : Async<string> = method30(v0)
                let! v80 = v80 
                let v81 : string = v80 
                let v82 : bool = v1 = v81
                return v82 
                (*
                ()
            *)
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v118 : Async<bool> = _v75 
    let _v21 = v118 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v119 : unit = ()
    let _v119 =
        async {
            let v122 : bool = method33(v0)
            let v123 : bool = v122 = false
            if v123 then
                return false 
                (*
                ()
            else
                *) else
                let v124 : Async<string> = method30(v0)
                let! v124 = v124 
                let v125 : string = v124 
                let v126 : bool = v1 = v125
                return v126 
                (*
                ()
            *)
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v162 : Async<bool> = _v119 
    let _v21 = v162 
    #endif
#else
    let v163 : unit = ()
    let _v163 =
        async {
            let v166 : bool = method33(v0)
            let v167 : bool = v166 = false
            if v167 then
                return false 
                (*
                ()
            else
                *) else
                let v168 : Async<string> = method30(v0)
                let! v168 = v168 
                let v169 : string = v168 
                let v170 : bool = v1 = v169
                return v170 
                (*
                ()
            *)
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v206 : Async<bool> = _v163 
    let _v21 = v206 
    #endif
    let v207 : Async<bool> = _v21 
    let _v2 = v207 
    #endif
    let v233 : Async<bool> = _v2 
    v233
and method37 (v0 : string, v1 : string) : Async<unit> =
    let v2 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : Async<unit> = null |> unbox<Async<unit>>
    let _v2 = v3 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v6 : Async<unit> = null |> unbox<Async<unit>>
    let _v2 = v6 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v9 : Async<unit> = null |> unbox<Async<unit>>
    let _v2 = v9 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v12 : unit = ()
    let _v12 =
        async {
            let v15 : Async<bool> = method38(v0, v1)
            let! v15 = v15 
            let v16 : bool = v15 
            let v17 : bool = v16 = false
            if v17 then
                let v18 : Async<unit> = method35(v0, v1)
                do! v18 
                ()
            ()
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v47 : Async<unit> = _v12 
    let _v2 = v47 
    #endif
#if FABLE_COMPILER_PYTHON
    let v48 : unit = ()
    let _v48 =
        async {
            let v51 : Async<bool> = method38(v0, v1)
            let! v51 = v51 
            let v52 : bool = v51 
            let v53 : bool = v52 = false
            if v53 then
                let v54 : Async<unit> = method35(v0, v1)
                do! v54 
                ()
            ()
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v83 : Async<unit> = _v48 
    let _v2 = v83 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v84 : unit = ()
    let _v84 =
        async {
            let v87 : Async<bool> = method38(v0, v1)
            let! v87 = v87 
            let v88 : bool = v87 
            let v89 : bool = v88 = false
            if v89 then
                let v90 : Async<unit> = method35(v0, v1)
                do! v90 
                ()
            ()
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v119 : Async<unit> = _v84 
    let _v2 = v119 
    #endif
#else
    let v120 : unit = ()
    let _v120 =
        async {
            let v123 : Async<bool> = method38(v0, v1)
            let! v123 = v123 
            let v124 : bool = v123 
            let v125 : bool = v124 = false
            if v125 then
                let v126 : Async<unit> = method35(v0, v1)
                do! v126 
                ()
            ()
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v155 : Async<unit> = _v120 
    let _v2 = v155 
    #endif
    let v156 : Async<unit> = _v2 
    v156
and closure20 (v0 : string) (v1 : string) : Async<unit> =
    method37(v0, v1)
and closure19 () (v0 : string) : (string -> Async<unit>) =
    closure20(v0)
and method41 () : string =
    
    
    
    
    
    let v0 : string = "Warning"
    let v1 : (unit -> string) = v0.ToLower
    let v2 : string = v1 ()
    let v5 : char = v2.[int 0]
    let v6 : string = method16(v5)
    let v7 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v8 : string = "inline_colorization::color_yellow"
    let v9 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v8 
    let v10 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v11 : string = "&*$0"
    let v12 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v11 
    let _v10 = v12 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v13 : string = "&*$0"
    let v14 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v13 
    let _v10 = v14 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v15 : string = "&*$0"
    let v16 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v15 
    let _v10 = v16 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v17 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v10 = v17 
    #endif
#if FABLE_COMPILER_PYTHON
    let v20 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v10 = v20 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v23 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v10 = v23 
    #endif
#else
    let v26 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v10 = v26 
    #endif
    let v29 : Ref<Str> = _v10 
    let v34 : string = "inline_colorization::color_reset"
    let v35 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v34 
    let v36 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v37 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v9, v29, v35) v36 
    let v38 : string = "fable_library_rust::String_::fromString($0)"
    let v39 : string = Fable.Core.RustInterop.emitRustExpr v37 v38 
    let _v7 = v39 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v40 : string = "inline_colorization::color_yellow"
    let v41 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v40 
    let v42 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v43 : string = "&*$0"
    let v44 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v43 
    let _v42 = v44 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v45 : string = "&*$0"
    let v46 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v45 
    let _v42 = v46 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v47 : string = "&*$0"
    let v48 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v47 
    let _v42 = v48 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v49 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v42 = v49 
    #endif
#if FABLE_COMPILER_PYTHON
    let v52 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v42 = v52 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v55 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v42 = v55 
    #endif
#else
    let v58 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v42 = v58 
    #endif
    let v61 : Ref<Str> = _v42 
    let v66 : string = "inline_colorization::color_reset"
    let v67 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v66 
    let v68 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v69 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v41, v61, v67) v68 
    let v70 : string = "fable_library_rust::String_::fromString($0)"
    let v71 : string = Fable.Core.RustInterop.emitRustExpr v69 v70 
    let _v7 = v71 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v72 : string = "inline_colorization::color_yellow"
    let v73 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v72 
    let v74 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v75 : string = "&*$0"
    let v76 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v75 
    let _v74 = v76 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v77 : string = "&*$0"
    let v78 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v77 
    let _v74 = v78 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v79 : string = "&*$0"
    let v80 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v79 
    let _v74 = v80 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v81 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v74 = v81 
    #endif
#if FABLE_COMPILER_PYTHON
    let v84 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v74 = v84 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v87 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v74 = v87 
    #endif
#else
    let v90 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v74 = v90 
    #endif
    let v93 : Ref<Str> = _v74 
    let v98 : string = "inline_colorization::color_reset"
    let v99 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v98 
    let v100 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v101 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v73, v93, v99) v100 
    let v102 : string = "fable_library_rust::String_::fromString($0)"
    let v103 : string = Fable.Core.RustInterop.emitRustExpr v101 v102 
    let _v7 = v103 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v104 : string = "\u001b[93m"
    let v105 : string = method18()
    let v106 : string = v104 + v6 
    let v107 : string = v106 + v105 
    let _v7 = v107 
    #endif
#if FABLE_COMPILER_PYTHON
    let v108 : string = "\u001b[93m"
    let v109 : string = method18()
    let v110 : string = v108 + v6 
    let v111 : string = v110 + v109 
    let _v7 = v111 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v112 : string = "\u001b[93m"
    let v113 : string = method18()
    let v114 : string = v112 + v6 
    let v115 : string = v114 + v113 
    let _v7 = v115 
    #endif
#else
    let v116 : string = "\u001b[93m"
    let v117 : string = method18()
    let v118 : string = v116 + v6 
    let v119 : string = v118 + v117 
    let _v7 = v119 
    #endif
    let v120 : string = _v7 
    v120
and method43 (v0 : string, v1 : string) : string =
    let v2 : string = method17()
    let v3 : Mut3 = {l0 = v2} : Mut3
    let v4 : string = "{ "
    let v5 : string = $"{v4}"
    let v8 : unit = ()
    let v9 : (unit -> unit) = closure6(v3, v5)
    let v10 : unit = (fun () -> v9 (); v8) ()
    let v13 : string = "path"
    let v14 : string = $"{v13}"
    let v17 : unit = ()
    let v18 : (unit -> unit) = closure6(v3, v14)
    let v19 : unit = (fun () -> v18 (); v17) ()
    let v22 : string = " = "
    let v23 : string = $"{v22}"
    let v26 : unit = ()
    let v27 : (unit -> unit) = closure6(v3, v23)
    let v28 : unit = (fun () -> v27 (); v26) ()
    let v31 : string = $"{v0}"
    let v34 : unit = ()
    let v35 : (unit -> unit) = closure6(v3, v31)
    let v36 : unit = (fun () -> v35 (); v34) ()
    let v39 : string = "; "
    let v40 : string = $"{v39}"
    let v43 : unit = ()
    let v44 : (unit -> unit) = closure6(v3, v40)
    let v45 : unit = (fun () -> v44 (); v43) ()
    let v48 : string = "ex"
    let v49 : string = $"{v48}"
    let v52 : unit = ()
    let v53 : (unit -> unit) = closure6(v3, v49)
    let v54 : unit = (fun () -> v53 (); v52) ()
    let v57 : string = $"{v22}"
    let v60 : unit = ()
    let v61 : (unit -> unit) = closure6(v3, v57)
    let v62 : unit = (fun () -> v61 (); v60) ()
    let v65 : string = $"{v1}"
    let v68 : unit = ()
    let v69 : (unit -> unit) = closure6(v3, v65)
    let v70 : unit = (fun () -> v69 (); v68) ()
    let v73 : string = " }"
    let v74 : string = $"{v73}"
    let v77 : unit = ()
    let v78 : (unit -> unit) = closure6(v3, v74)
    let v79 : unit = (fun () -> v78 (); v77) ()
    let v82 : string = v3.l0
    v82
and method42 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : string, v9 : string) : string =
    let v10 : string = method43(v8, v9)
    let v11 : int64 = v0.l0
    let v12 : string = "delete_file_async"
    let v13 : string = $"{v6} {v7} #{v11} %s{v12} / {v10}"
    method22(v13)
and closure22 (v0 : string, v1 : exn) () : unit =
    let v2 : US0 = US0_3
    let v3 : bool = method10(v2)
    if v3 then
        let v4 : unit = ()
        let v5 : (unit -> unit) = closure0()
        let v6 : unit = (fun () -> v5 (); v4) ()
        let struct (v20 : Mut0, v21 : Mut1, v22 : Mut2, v23 : Mut3, v24 : Mut4, v25 : int64 option) = TraceState.trace_state.Value
        let v38 : string = method11(v20, v21, v22, v23, v24, v25)
        let v39 : string = method41()
        let v40 : string = method19(v0)
        let v41 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v42 : string = $"%A{v1}"
        let _v41 = v42 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v45 : string = $"%A{v1}"
        let _v41 = v45 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v48 : string = $"%A{v1}"
        let _v41 = v48 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v51 : string = $"%A{v1}"
        let _v41 = v51 
        #endif
#if FABLE_COMPILER_PYTHON
        let v54 : string = $"%A{v1}"
        let _v41 = v54 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v57 : string = $"%A{v1}"
        let _v41 = v57 
        #endif
#else
        let v60 : string = $"{v1.GetType ()}: {v1.Message}"
        let _v41 = v60 
        #endif
        let v61 : string = _v41 
        let v66 : string = method42(v20, v21, v22, v23, v24, v25, v38, v39, v40, v61)
        method23(v66)
and method40 (v0 : string, v1 : int64) : Async<int64> =
    let v2 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : Async<int64> = null |> unbox<Async<int64>>
    let _v2 = v3 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v6 : Async<int64> = null |> unbox<Async<int64>>
    let _v2 = v6 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v9 : Async<int64> = null |> unbox<Async<int64>>
    let _v2 = v9 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v12 : unit = ()
    let _v12 =
        async {
            try
            let v15 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v16 : string = "std::fs::remove_file(&*$0).unwrap()"
            Fable.Core.RustInterop.emitRustExpr v0 v16 
            let _v15 = () 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let _v15 = () 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let _v15 = () 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let _v15 = () 
            #endif
#if FABLE_COMPILER_PYTHON
            let _v15 = () 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let _v15 = () 
            #endif
#else
            let v17 : (string -> unit) = System.IO.File.Delete
            v17 v0
            let _v15 = () 
            #endif
            _v15 
            return v1 
            with ex ->
                let v18 : exn = ex
                let v19 : int64 = v1 % 100L
                let v20 : bool = v19 = 0L
                if v20 then
                    let v21 : unit = ()
                    let v22 : (unit -> unit) = closure22(v0, v18)
                    let v23 : unit = (fun () -> v22 (); v21) ()
                    ()
                let v89 : int32 = 10
                let v90 : Async<unit> = method24(v89)
                do! v90 
                let v91 : int64 = v1 + 1L
                let v92 : Async<int64> = method40(v0, v91)
                return! v92 
                (*
                ()
            *)
            (*
            let v168 : int64 = *)
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v1247 : Async<int64> = _v12 
    let _v2 = v1247 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1248 : unit = ()
    let _v1248 =
        async {
            try
            let v1251 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1252 : string = "std::fs::remove_file(&*$0).unwrap()"
            Fable.Core.RustInterop.emitRustExpr v0 v1252 
            let _v1251 = () 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let _v1251 = () 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let _v1251 = () 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let _v1251 = () 
            #endif
#if FABLE_COMPILER_PYTHON
            let _v1251 = () 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let _v1251 = () 
            #endif
#else
            let v1253 : (string -> unit) = System.IO.File.Delete
            v1253 v0
            let _v1251 = () 
            #endif
            _v1251 
            return v1 
            with ex ->
                let v1254 : exn = ex
                let v1255 : int64 = v1 % 100L
                let v1256 : bool = v1255 = 0L
                if v1256 then
                    let v1257 : unit = ()
                    let v1258 : (unit -> unit) = closure22(v0, v1254)
                    let v1259 : unit = (fun () -> v1258 (); v1257) ()
                    ()
                let v1325 : int32 = 10
                let v1326 : Async<unit> = method24(v1325)
                do! v1326 
                let v1327 : int64 = v1 + 1L
                let v1328 : Async<int64> = method40(v0, v1327)
                return! v1328 
                (*
                ()
            *)
            (*
            let v1404 : int64 = *)
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v2483 : Async<int64> = _v1248 
    let _v2 = v2483 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v2484 : unit = ()
    let _v2484 =
        async {
            try
            let v2487 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v2488 : string = "std::fs::remove_file(&*$0).unwrap()"
            Fable.Core.RustInterop.emitRustExpr v0 v2488 
            let _v2487 = () 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let _v2487 = () 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let _v2487 = () 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let _v2487 = () 
            #endif
#if FABLE_COMPILER_PYTHON
            let _v2487 = () 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let _v2487 = () 
            #endif
#else
            let v2489 : (string -> unit) = System.IO.File.Delete
            v2489 v0
            let _v2487 = () 
            #endif
            _v2487 
            return v1 
            with ex ->
                let v2490 : exn = ex
                let v2491 : int64 = v1 % 100L
                let v2492 : bool = v2491 = 0L
                if v2492 then
                    let v2493 : unit = ()
                    let v2494 : (unit -> unit) = closure22(v0, v2490)
                    let v2495 : unit = (fun () -> v2494 (); v2493) ()
                    ()
                let v2561 : int32 = 10
                let v2562 : Async<unit> = method24(v2561)
                do! v2562 
                let v2563 : int64 = v1 + 1L
                let v2564 : Async<int64> = method40(v0, v2563)
                return! v2564 
                (*
                ()
            *)
            (*
            let v2640 : int64 = *)
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v3719 : Async<int64> = _v2484 
    let _v2 = v3719 
    #endif
#else
    let v3720 : unit = ()
    let _v3720 =
        async {
            try
            let v3723 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v3724 : string = "std::fs::remove_file(&*$0).unwrap()"
            Fable.Core.RustInterop.emitRustExpr v0 v3724 
            let _v3723 = () 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let _v3723 = () 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let _v3723 = () 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let _v3723 = () 
            #endif
#if FABLE_COMPILER_PYTHON
            let _v3723 = () 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let _v3723 = () 
            #endif
#else
            let v3725 : (string -> unit) = System.IO.File.Delete
            v3725 v0
            let _v3723 = () 
            #endif
            _v3723 
            return v1 
            with ex ->
                let v3726 : exn = ex
                let v3727 : int64 = v1 % 100L
                let v3728 : bool = v3727 = 0L
                if v3728 then
                    let v3729 : unit = ()
                    let v3730 : (unit -> unit) = closure22(v0, v3726)
                    let v3731 : unit = (fun () -> v3730 (); v3729) ()
                    ()
                let v3797 : int32 = 10
                let v3798 : Async<unit> = method24(v3797)
                do! v3798 
                let v3799 : int64 = v1 + 1L
                let v3800 : Async<int64> = method40(v0, v3799)
                return! v3800 
                (*
                ()
            *)
            (*
            let v3876 : int64 = *)
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v4955 : Async<int64> = _v3720 
    let _v2 = v4955 
    #endif
    let v4956 : Async<int64> = _v2 
    v4956
and method39 (v0 : string) : Async<int64> =
    let v1 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : Async<int64> = null |> unbox<Async<int64>>
    let _v1 = v2 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v5 : Async<int64> = null |> unbox<Async<int64>>
    let _v1 = v5 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v8 : Async<int64> = null |> unbox<Async<int64>>
    let _v1 = v8 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v11 : Async<int64> = null |> unbox<Async<int64>>
    let _v1 = v11 
    #endif
#if FABLE_COMPILER_PYTHON
    let v14 : Async<int64> = null |> unbox<Async<int64>>
    let _v1 = v14 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v17 : Async<int64> = null |> unbox<Async<int64>>
    let _v1 = v17 
    #endif
#else
    let v20 : int64 = 0L
    let v21 : Async<int64> = method40(v0, v20)
    let _v1 = v21 
    #endif
    let v22 : Async<int64> = _v1 
    v22
and closure21 () (v0 : string) : Async<int64> =
    method39(v0)
and method46 (v0 : string, v1 : string) : unit =
    let v2 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let _v2 = () 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let _v2 = () 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let _v2 = () 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let _v2 = () 
    #endif
#if FABLE_COMPILER_PYTHON
    let _v2 = () 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let _v2 = () 
    #endif
#else
    System.IO.File.Move (v1, v0)
    let _v2 = () 
    #endif
    _v2 
    ()
and method48 (v0 : string, v1 : string, v2 : exn) : string =
    let v3 : string = method17()
    let v4 : Mut3 = {l0 = v3} : Mut3
    let v5 : string = "{ "
    let v6 : string = $"{v5}"
    let v9 : unit = ()
    let v10 : (unit -> unit) = closure6(v4, v6)
    let v11 : unit = (fun () -> v10 (); v9) ()
    let v14 : string = "old_path"
    let v15 : string = $"{v14}"
    let v18 : unit = ()
    let v19 : (unit -> unit) = closure6(v4, v15)
    let v20 : unit = (fun () -> v19 (); v18) ()
    let v23 : string = " = "
    let v24 : string = $"{v23}"
    let v27 : unit = ()
    let v28 : (unit -> unit) = closure6(v4, v24)
    let v29 : unit = (fun () -> v28 (); v27) ()
    let v32 : string = $"{v0}"
    let v35 : unit = ()
    let v36 : (unit -> unit) = closure6(v4, v32)
    let v37 : unit = (fun () -> v36 (); v35) ()
    let v40 : string = "; "
    let v41 : string = $"{v40}"
    let v44 : unit = ()
    let v45 : (unit -> unit) = closure6(v4, v41)
    let v46 : unit = (fun () -> v45 (); v44) ()
    let v49 : string = "new_path"
    let v50 : string = $"{v49}"
    let v53 : unit = ()
    let v54 : (unit -> unit) = closure6(v4, v50)
    let v55 : unit = (fun () -> v54 (); v53) ()
    let v58 : string = $"{v23}"
    let v61 : unit = ()
    let v62 : (unit -> unit) = closure6(v4, v58)
    let v63 : unit = (fun () -> v62 (); v61) ()
    let v66 : string = $"{v1}"
    let v69 : unit = ()
    let v70 : (unit -> unit) = closure6(v4, v66)
    let v71 : unit = (fun () -> v70 (); v69) ()
    let v74 : string = $"{v40}"
    let v77 : unit = ()
    let v78 : (unit -> unit) = closure6(v4, v74)
    let v79 : unit = (fun () -> v78 (); v77) ()
    let v82 : string = "ex"
    let v83 : string = $"{v82}"
    let v86 : unit = ()
    let v87 : (unit -> unit) = closure6(v4, v83)
    let v88 : unit = (fun () -> v87 (); v86) ()
    let v91 : string = $"{v23}"
    let v94 : unit = ()
    let v95 : (unit -> unit) = closure6(v4, v91)
    let v96 : unit = (fun () -> v95 (); v94) ()
    let v99 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v100 : string = "format!(\"{:#?}\", $0)"
    let v101 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v100 
    let v102 : string = "fable_library_rust::String_::fromString($0)"
    let v103 : string = Fable.Core.RustInterop.emitRustExpr v101 v102 
    let _v99 = v103 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v104 : string = "format!(\"{:#?}\", $0)"
    let v105 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v104 
    let v106 : string = "fable_library_rust::String_::fromString($0)"
    let v107 : string = Fable.Core.RustInterop.emitRustExpr v105 v106 
    let _v99 = v107 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v108 : string = "format!(\"{:#?}\", $0)"
    let v109 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v108 
    let v110 : string = "fable_library_rust::String_::fromString($0)"
    let v111 : string = Fable.Core.RustInterop.emitRustExpr v109 v110 
    let _v99 = v111 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v112 : string = $"%A{v2}"
    let _v99 = v112 
    #endif
#if FABLE_COMPILER_PYTHON
    let v115 : string = $"%A{v2}"
    let _v99 = v115 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v118 : string = $"%A{v2}"
    let _v99 = v118 
    #endif
#else
    let v121 : string = $"%A{v2}"
    let _v99 = v121 
    #endif
    let v124 : string = _v99 
    let v129 : string = $"{v124}"
    let v132 : unit = ()
    let v133 : (unit -> unit) = closure6(v4, v129)
    let v134 : unit = (fun () -> v133 (); v132) ()
    let v137 : string = " }"
    let v138 : string = $"{v137}"
    let v141 : unit = ()
    let v142 : (unit -> unit) = closure6(v4, v138)
    let v143 : unit = (fun () -> v142 (); v141) ()
    let v146 : string = v4.l0
    v146
and method47 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : string, v9 : string, v10 : exn) : string =
    let v11 : string = method48(v8, v9, v10)
    let v12 : int64 = v0.l0
    let v13 : string = "move_file_async"
    let v14 : string = $"{v6} {v7} #{v12} %s{v13} / {v11}"
    method22(v14)
and closure25 (v0 : string, v1 : string, v2 : exn) () : unit =
    let v3 : US0 = US0_3
    let v4 : bool = method10(v3)
    if v4 then
        let v5 : unit = ()
        let v6 : (unit -> unit) = closure0()
        let v7 : unit = (fun () -> v6 (); v5) ()
        let struct (v21 : Mut0, v22 : Mut1, v23 : Mut2, v24 : Mut3, v25 : Mut4, v26 : int64 option) = TraceState.trace_state.Value
        let v39 : string = method11(v21, v22, v23, v24, v25, v26)
        let v40 : string = method41()
        let v41 : string = method19(v1)
        let v42 : string = method19(v0)
        let v43 : string = method47(v21, v22, v23, v24, v25, v26, v39, v40, v41, v42, v2)
        method23(v43)
and method45 (v0 : string, v1 : string, v2 : int64) : Async<int64> =
    let v3 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v4 : Async<int64> = null |> unbox<Async<int64>>
    let _v3 = v4 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v7 : Async<int64> = null |> unbox<Async<int64>>
    let _v3 = v7 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v10 : Async<int64> = null |> unbox<Async<int64>>
    let _v3 = v10 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v13 : unit = ()
    let _v13 =
        async {
            try
            method46(v0, v1)
            return v2 
            with ex ->
                let v16 : exn = ex
                let v17 : int64 = v2 % 100L
                let v18 : bool = v17 = 0L
                if v18 then
                    let v19 : unit = ()
                    let v20 : (unit -> unit) = closure25(v0, v1, v16)
                    let v21 : unit = (fun () -> v20 (); v19) ()
                    ()
                let v63 : int32 = 10
                let v64 : Async<unit> = method24(v63)
                do! v64 
                let v65 : int64 = v2 + 1L
                let v66 : Async<int64> = method45(v0, v1, v65)
                return! v66 
                (*
                ()
            *)
            (*
            *)
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v832 : Async<int64> = _v13 
    let _v3 = v832 
    #endif
#if FABLE_COMPILER_PYTHON
    let v833 : unit = ()
    let _v833 =
        async {
            try
            method46(v0, v1)
            return v2 
            with ex ->
                let v836 : exn = ex
                let v837 : int64 = v2 % 100L
                let v838 : bool = v837 = 0L
                if v838 then
                    let v839 : unit = ()
                    let v840 : (unit -> unit) = closure25(v0, v1, v836)
                    let v841 : unit = (fun () -> v840 (); v839) ()
                    ()
                let v883 : int32 = 10
                let v884 : Async<unit> = method24(v883)
                do! v884 
                let v885 : int64 = v2 + 1L
                let v886 : Async<int64> = method45(v0, v1, v885)
                return! v886 
                (*
                ()
            *)
            (*
            *)
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v1652 : Async<int64> = _v833 
    let _v3 = v1652 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1653 : unit = ()
    let _v1653 =
        async {
            try
            method46(v0, v1)
            return v2 
            with ex ->
                let v1656 : exn = ex
                let v1657 : int64 = v2 % 100L
                let v1658 : bool = v1657 = 0L
                if v1658 then
                    let v1659 : unit = ()
                    let v1660 : (unit -> unit) = closure25(v0, v1, v1656)
                    let v1661 : unit = (fun () -> v1660 (); v1659) ()
                    ()
                let v1703 : int32 = 10
                let v1704 : Async<unit> = method24(v1703)
                do! v1704 
                let v1705 : int64 = v2 + 1L
                let v1706 : Async<int64> = method45(v0, v1, v1705)
                return! v1706 
                (*
                ()
            *)
            (*
            *)
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v2472 : Async<int64> = _v1653 
    let _v3 = v2472 
    #endif
#else
    let v2473 : unit = ()
    let _v2473 =
        async {
            try
            method46(v0, v1)
            return v2 
            with ex ->
                let v2476 : exn = ex
                let v2477 : int64 = v2 % 100L
                let v2478 : bool = v2477 = 0L
                if v2478 then
                    let v2479 : unit = ()
                    let v2480 : (unit -> unit) = closure25(v0, v1, v2476)
                    let v2481 : unit = (fun () -> v2480 (); v2479) ()
                    ()
                let v2523 : int32 = 10
                let v2524 : Async<unit> = method24(v2523)
                do! v2524 
                let v2525 : int64 = v2 + 1L
                let v2526 : Async<int64> = method45(v0, v1, v2525)
                return! v2526 
                (*
                ()
            *)
            (*
            *)
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v3292 : Async<int64> = _v2473 
    let _v3 = v3292 
    #endif
    let v3293 : Async<int64> = _v3 
    v3293
and method44 (v0 : string, v1 : string) : Async<int64> =
    let v2 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : Async<int64> = null |> unbox<Async<int64>>
    let _v2 = v3 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v6 : Async<int64> = null |> unbox<Async<int64>>
    let _v2 = v6 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v9 : Async<int64> = null |> unbox<Async<int64>>
    let _v2 = v9 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v12 : Async<int64> = null |> unbox<Async<int64>>
    let _v2 = v12 
    #endif
#if FABLE_COMPILER_PYTHON
    let v15 : Async<int64> = null |> unbox<Async<int64>>
    let _v2 = v15 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v18 : Async<int64> = null |> unbox<Async<int64>>
    let _v2 = v18 
    #endif
#else
    let v21 : int64 = 0L
    let v22 : Async<int64> = method45(v0, v1, v21)
    let _v2 = v22 
    #endif
    let v23 : Async<int64> = _v2 
    v23
and closure24 (v0 : string) (v1 : string) : Async<int64> =
    method44(v0, v1)
and closure23 () (v0 : string) : (string -> Async<int64>) =
    closure24(v0)
and method52 (v0 : int32, v1 : Async<int64>) : Async<Async<int64>> =
    let v2 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : Async<Async<int64>> = null |> unbox<Async<Async<int64>>>
    let _v2 = v3 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v6 : Async<Async<int64>> = null |> unbox<Async<Async<int64>>>
    let _v2 = v6 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v9 : Async<Async<int64>> = null |> unbox<Async<Async<int64>>>
    let _v2 = v9 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v12 : Async<Async<int64>> = Async.StartChild (v1, v0)
    let _v2 = v12 
    #endif
#if FABLE_COMPILER_PYTHON
    let v13 : Async<Async<int64>> = Async.StartChild (v1, v0)
    let _v2 = v13 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v14 : Async<Async<int64>> = Async.StartChild (v1, v0)
    let _v2 = v14 
    #endif
#else
    let v15 : Async<Async<int64>> = Async.StartChild (v1, v0)
    let _v2 = v15 
    #endif
    let v16 : Async<Async<int64>> = _v2 
    v16
and method54 (v0 : Async<int64>) : Async<Choice<int64, exn>> =
    let v1 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : (Async<int64> -> Async<Choice<int64, exn>>) = Async.Catch
    let v3 : Async<Choice<int64, exn>> = v2 v0
    let _v1 = v3 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v4 : (Async<int64> -> Async<Choice<int64, exn>>) = Async.Catch
    let v5 : Async<Choice<int64, exn>> = v4 v0
    let _v1 = v5 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v6 : (Async<int64> -> Async<Choice<int64, exn>>) = Async.Catch
    let v7 : Async<Choice<int64, exn>> = v6 v0
    let _v1 = v7 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v8 : (Async<int64> -> Async<Choice<int64, exn>>) = Async.Catch
    let v9 : Async<Choice<int64, exn>> = v8 v0
    let _v1 = v9 
    #endif
#if FABLE_COMPILER_PYTHON
    let v10 : (Async<int64> -> Async<Choice<int64, exn>>) = Async.Catch
    let v11 : Async<Choice<int64, exn>> = v10 v0
    let _v1 = v11 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v12 : (Async<int64> -> Async<Choice<int64, exn>>) = Async.Catch
    let v13 : Async<Choice<int64, exn>> = v12 v0
    let _v1 = v13 
    #endif
#else
    let v14 : (Async<int64> -> Async<Choice<int64, exn>>) = Async.Catch
    let v15 : Async<Choice<int64, exn>> = v14 v0
    let _v1 = v15 
    #endif
    let v16 : Async<Choice<int64, exn>> = _v1 
    v16
and closure27 () (v0 : int64) : US10 =
    US10_0(v0)
and method55 () : (int64 -> US10) =
    closure27()
and closure28 () (v0 : exn) : US10 =
    US10_1(v0)
and method56 () : (exn -> US10) =
    closure28()
and method53 (v0 : Async<int64>) : Async<US9> =
    let v1 : Async<Choice<int64, exn>> = method54(v0)
    let v2 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : Async<US10> = null |> unbox<Async<US10>>
    let _v2 = v3 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v6 : Async<US10> = null |> unbox<Async<US10>>
    let _v2 = v6 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v9 : Async<US10> = null |> unbox<Async<US10>>
    let _v2 = v9 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v12 : unit = ()
    let _v12 =
        async {
            let! v1 = v1 
            let v15 : Choice<int64, exn> = v1 
            let v16 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v17 : US10 = null |> unbox<US10>
            let _v16 = v17 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v20 : US10 = null |> unbox<US10>
            let _v16 = v20 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v23 : US10 = null |> unbox<US10>
            let _v16 = v23 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v26 : US10 = null |> unbox<US10>
            let _v16 = v26 
            #endif
#if FABLE_COMPILER_PYTHON
            let v29 : US10 = null |> unbox<US10>
            let _v16 = v29 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v32 : (int64 -> US10) = method55()
            let v33 : (exn -> US10) = method56()
            let v34 : US10 = match v15 with Choice1Of2 x -> v32 x | Choice2Of2 x -> v33 x
            let _v16 = v34 
            #endif
#else
            let v35 : (int64 -> US10) = method55()
            let v36 : (exn -> US10) = method56()
            let v37 : US10 = match v15 with Choice1Of2 x -> v35 x | Choice2Of2 x -> v36 x
            let _v16 = v37 
            #endif
            let v38 : US10 = _v16 
            return v38 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v239 : Async<US10> = _v12 
    let _v2 = v239 
    #endif
#if FABLE_COMPILER_PYTHON
    let v240 : unit = ()
    let _v240 =
        async {
            let! v1 = v1 
            let v243 : Choice<int64, exn> = v1 
            let v244 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v245 : US10 = null |> unbox<US10>
            let _v244 = v245 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v248 : US10 = null |> unbox<US10>
            let _v244 = v248 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v251 : US10 = null |> unbox<US10>
            let _v244 = v251 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v254 : US10 = null |> unbox<US10>
            let _v244 = v254 
            #endif
#if FABLE_COMPILER_PYTHON
            let v257 : US10 = null |> unbox<US10>
            let _v244 = v257 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v260 : (int64 -> US10) = method55()
            let v261 : (exn -> US10) = method56()
            let v262 : US10 = match v243 with Choice1Of2 x -> v260 x | Choice2Of2 x -> v261 x
            let _v244 = v262 
            #endif
#else
            let v263 : (int64 -> US10) = method55()
            let v264 : (exn -> US10) = method56()
            let v265 : US10 = match v243 with Choice1Of2 x -> v263 x | Choice2Of2 x -> v264 x
            let _v244 = v265 
            #endif
            let v266 : US10 = _v244 
            return v266 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v467 : Async<US10> = _v240 
    let _v2 = v467 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v468 : unit = ()
    let _v468 =
        async {
            let! v1 = v1 
            let v471 : Choice<int64, exn> = v1 
            let v472 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v473 : US10 = null |> unbox<US10>
            let _v472 = v473 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v476 : US10 = null |> unbox<US10>
            let _v472 = v476 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v479 : US10 = null |> unbox<US10>
            let _v472 = v479 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v482 : US10 = null |> unbox<US10>
            let _v472 = v482 
            #endif
#if FABLE_COMPILER_PYTHON
            let v485 : US10 = null |> unbox<US10>
            let _v472 = v485 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v488 : (int64 -> US10) = method55()
            let v489 : (exn -> US10) = method56()
            let v490 : US10 = match v471 with Choice1Of2 x -> v488 x | Choice2Of2 x -> v489 x
            let _v472 = v490 
            #endif
#else
            let v491 : (int64 -> US10) = method55()
            let v492 : (exn -> US10) = method56()
            let v493 : US10 = match v471 with Choice1Of2 x -> v491 x | Choice2Of2 x -> v492 x
            let _v472 = v493 
            #endif
            let v494 : US10 = _v472 
            return v494 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v695 : Async<US10> = _v468 
    let _v2 = v695 
    #endif
#else
    let v696 : unit = ()
    let _v696 =
        async {
            let! v1 = v1 
            let v699 : Choice<int64, exn> = v1 
            let v700 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v701 : US10 = null |> unbox<US10>
            let _v700 = v701 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v704 : US10 = null |> unbox<US10>
            let _v700 = v704 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v707 : US10 = null |> unbox<US10>
            let _v700 = v707 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v710 : US10 = null |> unbox<US10>
            let _v700 = v710 
            #endif
#if FABLE_COMPILER_PYTHON
            let v713 : US10 = null |> unbox<US10>
            let _v700 = v713 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v716 : (int64 -> US10) = method55()
            let v717 : (exn -> US10) = method56()
            let v718 : US10 = match v699 with Choice1Of2 x -> v716 x | Choice2Of2 x -> v717 x
            let _v700 = v718 
            #endif
#else
            let v719 : (int64 -> US10) = method55()
            let v720 : (exn -> US10) = method56()
            let v721 : US10 = match v699 with Choice1Of2 x -> v719 x | Choice2Of2 x -> v720 x
            let _v700 = v721 
            #endif
            let v722 : US10 = _v700 
            return v722 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v923 : Async<US10> = _v696 
    let _v2 = v923 
    #endif
    let v924 : Async<US10> = _v2 
    let v1042 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1043 : Async<US9> = null |> unbox<Async<US9>>
    let _v1042 = v1043 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1046 : Async<US9> = null |> unbox<Async<US9>>
    let _v1042 = v1046 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1049 : Async<US9> = null |> unbox<Async<US9>>
    let _v1042 = v1049 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1052 : unit = ()
    let _v1052 =
        async {
            let! v924 = v924 
            let v1055 : US10 = v924 
            let v1061 : US9 =
                match v1055 with
                | US10_0(v1056) -> (* C1of2 *)
                    US9_0(v1056)
                | US10_1(v1058) -> (* C2of2 *)
                    US9_1(v1058)
            return v1061 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v1111 : Async<US9> = _v1052 
    let _v1042 = v1111 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1112 : unit = ()
    let _v1112 =
        async {
            let! v924 = v924 
            let v1115 : US10 = v924 
            let v1121 : US9 =
                match v1115 with
                | US10_0(v1116) -> (* C1of2 *)
                    US9_0(v1116)
                | US10_1(v1118) -> (* C2of2 *)
                    US9_1(v1118)
            return v1121 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v1171 : Async<US9> = _v1112 
    let _v1042 = v1171 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1172 : unit = ()
    let _v1172 =
        async {
            let! v924 = v924 
            let v1175 : US10 = v924 
            let v1181 : US9 =
                match v1175 with
                | US10_0(v1176) -> (* C1of2 *)
                    US9_0(v1176)
                | US10_1(v1178) -> (* C2of2 *)
                    US9_1(v1178)
            return v1181 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v1231 : Async<US9> = _v1172 
    let _v1042 = v1231 
    #endif
#else
    let v1232 : unit = ()
    let _v1232 =
        async {
            let! v924 = v924 
            let v1235 : US10 = v924 
            let v1241 : US9 =
                match v1235 with
                | US10_0(v1236) -> (* C1of2 *)
                    US9_0(v1236)
                | US10_1(v1238) -> (* C2of2 *)
                    US9_1(v1238)
            return v1241 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v1291 : Async<US9> = _v1232 
    let _v1042 = v1291 
    #endif
    let v1292 : Async<US9> = _v1042 
    v1292
and method57 () : string =
    
    
    
    
    
    let v0 : string = "Verbose"
    let v1 : (unit -> string) = v0.ToLower
    let v2 : string = v1 ()
    let v5 : char = v2.[int 0]
    let v6 : string = method16(v5)
    let v7 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v8 : string = "inline_colorization::color_bright_black"
    let v9 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v8 
    let v10 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v11 : string = "&*$0"
    let v12 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v11 
    let _v10 = v12 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v13 : string = "&*$0"
    let v14 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v13 
    let _v10 = v14 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v15 : string = "&*$0"
    let v16 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v15 
    let _v10 = v16 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v17 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v10 = v17 
    #endif
#if FABLE_COMPILER_PYTHON
    let v20 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v10 = v20 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v23 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v10 = v23 
    #endif
#else
    let v26 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v10 = v26 
    #endif
    let v29 : Ref<Str> = _v10 
    let v34 : string = "inline_colorization::color_reset"
    let v35 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v34 
    let v36 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v37 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v9, v29, v35) v36 
    let v38 : string = "fable_library_rust::String_::fromString($0)"
    let v39 : string = Fable.Core.RustInterop.emitRustExpr v37 v38 
    let _v7 = v39 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v40 : string = "inline_colorization::color_bright_black"
    let v41 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v40 
    let v42 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v43 : string = "&*$0"
    let v44 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v43 
    let _v42 = v44 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v45 : string = "&*$0"
    let v46 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v45 
    let _v42 = v46 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v47 : string = "&*$0"
    let v48 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v47 
    let _v42 = v48 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v49 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v42 = v49 
    #endif
#if FABLE_COMPILER_PYTHON
    let v52 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v42 = v52 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v55 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v42 = v55 
    #endif
#else
    let v58 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v42 = v58 
    #endif
    let v61 : Ref<Str> = _v42 
    let v66 : string = "inline_colorization::color_reset"
    let v67 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v66 
    let v68 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v69 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v41, v61, v67) v68 
    let v70 : string = "fable_library_rust::String_::fromString($0)"
    let v71 : string = Fable.Core.RustInterop.emitRustExpr v69 v70 
    let _v7 = v71 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v72 : string = "inline_colorization::color_bright_black"
    let v73 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v72 
    let v74 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v75 : string = "&*$0"
    let v76 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v75 
    let _v74 = v76 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v77 : string = "&*$0"
    let v78 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v77 
    let _v74 = v78 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v79 : string = "&*$0"
    let v80 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v79 
    let _v74 = v80 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v81 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v74 = v81 
    #endif
#if FABLE_COMPILER_PYTHON
    let v84 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v74 = v84 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v87 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v74 = v87 
    #endif
#else
    let v90 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v74 = v90 
    #endif
    let v93 : Ref<Str> = _v74 
    let v98 : string = "inline_colorization::color_reset"
    let v99 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v98 
    let v100 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v101 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v73, v93, v99) v100 
    let v102 : string = "fable_library_rust::String_::fromString($0)"
    let v103 : string = Fable.Core.RustInterop.emitRustExpr v101 v102 
    let _v7 = v103 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v104 : string = "\u001b[90m"
    let v105 : string = method18()
    let v106 : string = v104 + v6 
    let v107 : string = v106 + v105 
    let _v7 = v107 
    #endif
#if FABLE_COMPILER_PYTHON
    let v108 : string = "\u001b[90m"
    let v109 : string = method18()
    let v110 : string = v108 + v6 
    let v111 : string = v110 + v109 
    let _v7 = v111 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v112 : string = "\u001b[90m"
    let v113 : string = method18()
    let v114 : string = v112 + v6 
    let v115 : string = v114 + v113 
    let _v7 = v115 
    #endif
#else
    let v116 : string = "\u001b[90m"
    let v117 : string = method18()
    let v118 : string = v116 + v6 
    let v119 : string = v118 + v117 
    let _v7 = v119 
    #endif
    let v120 : string = _v7 
    v120
and method59 (v0 : int32) : string =
    let v1 : string = method17()
    let v2 : Mut3 = {l0 = v1} : Mut3
    let v3 : string = "{ "
    let v4 : string = $"{v3}"
    let v7 : unit = ()
    let v8 : (unit -> unit) = closure6(v2, v4)
    let v9 : unit = (fun () -> v8 (); v7) ()
    let v12 : string = "timeout"
    let v13 : string = $"{v12}"
    let v16 : unit = ()
    let v17 : (unit -> unit) = closure6(v2, v13)
    let v18 : unit = (fun () -> v17 (); v16) ()
    let v21 : string = " = "
    let v22 : string = $"{v21}"
    let v25 : unit = ()
    let v26 : (unit -> unit) = closure6(v2, v22)
    let v27 : unit = (fun () -> v26 (); v25) ()
    let v30 : string = $"{v0}"
    let v33 : unit = ()
    let v34 : (unit -> unit) = closure6(v2, v30)
    let v35 : unit = (fun () -> v34 (); v33) ()
    let v38 : string = " }"
    let v39 : string = $"{v38}"
    let v42 : unit = ()
    let v43 : (unit -> unit) = closure6(v2, v39)
    let v44 : unit = (fun () -> v43 (); v42) ()
    let v47 : string = v2.l0
    v47
and method58 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : int32) : string =
    let v9 : string = method59(v8)
    let v10 : int64 = v0.l0
    let v11 : string = "async.run_with_timeout_async"
    let v12 : string = $"{v6} {v7} #{v10} %s{v11} / {v9}"
    method22(v12)
and closure29 (v0 : int32) () : unit =
    let v1 : US0 = US0_0
    let v2 : bool = method10(v1)
    if v2 then
        let v3 : unit = ()
        let v4 : (unit -> unit) = closure0()
        let v5 : unit = (fun () -> v4 (); v3) ()
        let struct (v19 : Mut0, v20 : Mut1, v21 : Mut2, v22 : Mut3, v23 : Mut4, v24 : int64 option) = TraceState.trace_state.Value
        let v37 : string = method11(v19, v20, v21, v22, v23, v24)
        let v38 : string = method57()
        let v39 : string = method58(v19, v20, v21, v22, v23, v24, v37, v38, v0)
        method23(v39)
and method60 () : string =
    
    
    
    
    
    let v0 : string = "Critical"
    let v1 : (unit -> string) = v0.ToLower
    let v2 : string = v1 ()
    let v5 : char = v2.[int 0]
    let v6 : string = method16(v5)
    let v7 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v8 : string = "inline_colorization::color_bright_red"
    let v9 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v8 
    let v10 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v11 : string = "&*$0"
    let v12 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v11 
    let _v10 = v12 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v13 : string = "&*$0"
    let v14 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v13 
    let _v10 = v14 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v15 : string = "&*$0"
    let v16 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v15 
    let _v10 = v16 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v17 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v10 = v17 
    #endif
#if FABLE_COMPILER_PYTHON
    let v20 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v10 = v20 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v23 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v10 = v23 
    #endif
#else
    let v26 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v10 = v26 
    #endif
    let v29 : Ref<Str> = _v10 
    let v34 : string = "inline_colorization::color_reset"
    let v35 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v34 
    let v36 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v37 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v9, v29, v35) v36 
    let v38 : string = "fable_library_rust::String_::fromString($0)"
    let v39 : string = Fable.Core.RustInterop.emitRustExpr v37 v38 
    let _v7 = v39 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v40 : string = "inline_colorization::color_bright_red"
    let v41 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v40 
    let v42 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v43 : string = "&*$0"
    let v44 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v43 
    let _v42 = v44 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v45 : string = "&*$0"
    let v46 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v45 
    let _v42 = v46 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v47 : string = "&*$0"
    let v48 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v47 
    let _v42 = v48 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v49 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v42 = v49 
    #endif
#if FABLE_COMPILER_PYTHON
    let v52 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v42 = v52 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v55 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v42 = v55 
    #endif
#else
    let v58 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v42 = v58 
    #endif
    let v61 : Ref<Str> = _v42 
    let v66 : string = "inline_colorization::color_reset"
    let v67 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v66 
    let v68 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v69 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v41, v61, v67) v68 
    let v70 : string = "fable_library_rust::String_::fromString($0)"
    let v71 : string = Fable.Core.RustInterop.emitRustExpr v69 v70 
    let _v7 = v71 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v72 : string = "inline_colorization::color_bright_red"
    let v73 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v72 
    let v74 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v75 : string = "&*$0"
    let v76 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v75 
    let _v74 = v76 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v77 : string = "&*$0"
    let v78 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v77 
    let _v74 = v78 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v79 : string = "&*$0"
    let v80 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v79 
    let _v74 = v80 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v81 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v74 = v81 
    #endif
#if FABLE_COMPILER_PYTHON
    let v84 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v74 = v84 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v87 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v74 = v87 
    #endif
#else
    let v90 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v74 = v90 
    #endif
    let v93 : Ref<Str> = _v74 
    let v98 : string = "inline_colorization::color_reset"
    let v99 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v98 
    let v100 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v101 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v73, v93, v99) v100 
    let v102 : string = "fable_library_rust::String_::fromString($0)"
    let v103 : string = Fable.Core.RustInterop.emitRustExpr v101 v102 
    let _v7 = v103 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v104 : string = "\u001b[91m"
    let v105 : string = method18()
    let v106 : string = v104 + v6 
    let v107 : string = v106 + v105 
    let _v7 = v107 
    #endif
#if FABLE_COMPILER_PYTHON
    let v108 : string = "\u001b[91m"
    let v109 : string = method18()
    let v110 : string = v108 + v6 
    let v111 : string = v110 + v109 
    let _v7 = v111 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v112 : string = "\u001b[91m"
    let v113 : string = method18()
    let v114 : string = v112 + v6 
    let v115 : string = v114 + v113 
    let _v7 = v115 
    #endif
#else
    let v116 : string = "\u001b[91m"
    let v117 : string = method18()
    let v118 : string = v116 + v6 
    let v119 : string = v118 + v117 
    let _v7 = v119 
    #endif
    let v120 : string = _v7 
    v120
and method62 (v0 : int32, v1 : string) : string =
    let v2 : string = method17()
    let v3 : Mut3 = {l0 = v2} : Mut3
    let v4 : string = "{ "
    let v5 : string = $"{v4}"
    let v8 : unit = ()
    let v9 : (unit -> unit) = closure6(v3, v5)
    let v10 : unit = (fun () -> v9 (); v8) ()
    let v13 : string = "timeout"
    let v14 : string = $"{v13}"
    let v17 : unit = ()
    let v18 : (unit -> unit) = closure6(v3, v14)
    let v19 : unit = (fun () -> v18 (); v17) ()
    let v22 : string = " = "
    let v23 : string = $"{v22}"
    let v26 : unit = ()
    let v27 : (unit -> unit) = closure6(v3, v23)
    let v28 : unit = (fun () -> v27 (); v26) ()
    let v31 : string = $"{v0}"
    let v34 : unit = ()
    let v35 : (unit -> unit) = closure6(v3, v31)
    let v36 : unit = (fun () -> v35 (); v34) ()
    let v39 : string = "; "
    let v40 : string = $"{v39}"
    let v43 : unit = ()
    let v44 : (unit -> unit) = closure6(v3, v40)
    let v45 : unit = (fun () -> v44 (); v43) ()
    let v48 : string = "ex"
    let v49 : string = $"{v48}"
    let v52 : unit = ()
    let v53 : (unit -> unit) = closure6(v3, v49)
    let v54 : unit = (fun () -> v53 (); v52) ()
    let v57 : string = $"{v22}"
    let v60 : unit = ()
    let v61 : (unit -> unit) = closure6(v3, v57)
    let v62 : unit = (fun () -> v61 (); v60) ()
    let v65 : string = $"{v1}"
    let v68 : unit = ()
    let v69 : (unit -> unit) = closure6(v3, v65)
    let v70 : unit = (fun () -> v69 (); v68) ()
    let v73 : string = " }"
    let v74 : string = $"{v73}"
    let v77 : unit = ()
    let v78 : (unit -> unit) = closure6(v3, v74)
    let v79 : unit = (fun () -> v78 (); v77) ()
    let v82 : string = v3.l0
    v82
and method61 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : int32, v9 : string) : string =
    let v10 : string = method62(v8, v9)
    let v11 : int64 = v0.l0
    let v12 : string = "async.run_with_timeout_async**"
    let v13 : string = $"{v6} {v7} #{v11} %s{v12} / {v10}"
    method22(v13)
and closure30 (v0 : int32, v1 : exn) () : unit =
    let v2 : US0 = US0_4
    let v3 : bool = method10(v2)
    if v3 then
        let v4 : unit = ()
        let v5 : (unit -> unit) = closure0()
        let v6 : unit = (fun () -> v5 (); v4) ()
        let struct (v20 : Mut0, v21 : Mut1, v22 : Mut2, v23 : Mut3, v24 : Mut4, v25 : int64 option) = TraceState.trace_state.Value
        let v38 : string = method11(v20, v21, v22, v23, v24, v25)
        let v39 : string = method60()
        let v40 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v41 : string = $"%A{v1}"
        let _v40 = v41 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v44 : string = $"%A{v1}"
        let _v40 = v44 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v47 : string = $"%A{v1}"
        let _v40 = v47 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v50 : string = $"%A{v1}"
        let _v40 = v50 
        #endif
#if FABLE_COMPILER_PYTHON
        let v53 : string = $"%A{v1}"
        let _v40 = v53 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v56 : string = $"%A{v1}"
        let _v40 = v56 
        #endif
#else
        let v59 : string = $"{v1.GetType ()}: {v1.Message}"
        let _v40 = v59 
        #endif
        let v60 : string = _v40 
        let v65 : string = method61(v20, v21, v22, v23, v24, v25, v38, v39, v0, v60)
        method23(v65)
and method51 (v0 : int32, v1 : Async<int64>) : Async<US2> =
    let v2 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v4 : Async<US2> = null |> unbox<Async<US2>>
    let _v3 = v4 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v7 : Async<US2> = null |> unbox<Async<US2>>
    let _v3 = v7 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v10 : Async<US2> = null |> unbox<Async<US2>>
    let _v3 = v10 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v13 : unit = ()
    let _v13 =
        async {
            let v16 : Async<Async<int64>> = method52(v0, v1)
            let! v16 = v16 
            let v17 : Async<int64> = v16 
            let v18 : Async<US9> = method53(v17)
            let v19 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v20 : Async<US2> = null |> unbox<Async<US2>>
            let _v19 = v20 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v23 : Async<US2> = null |> unbox<Async<US2>>
            let _v19 = v23 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v26 : Async<US2> = null |> unbox<Async<US2>>
            let _v19 = v26 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v29 : unit = ()
            let _v29 =
                async {
                    let! v18 = v18 
                    let v32 : US9 = v18 
                    let v156 : US2 =
                        match v32 with
                        | US9_1(v35) -> (* Error *)
                            let v36 : string = $"%A{v35}"
                            let v39 : string = "System.TimeoutException"
                            let v40 : bool = v36.Contains v39 
                            if v40 then
                                let v43 : unit = ()
                                let v44 : (unit -> unit) = closure29(v0)
                                let v45 : unit = (fun () -> v44 (); v43) ()
                                US2_1
                            else
                                let v86 : unit = ()
                                let v87 : (unit -> unit) = closure30(v0, v35)
                                let v88 : unit = (fun () -> v87 (); v86) ()
                                US2_1
                        | US9_0(v33) -> (* Ok *)
                            US2_0(v33)
                    return v156 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v1032 : Async<US2> = _v29 
            let _v19 = v1032 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1033 : unit = ()
            let _v1033 =
                async {
                    let! v18 = v18 
                    let v1036 : US9 = v18 
                    let v1160 : US2 =
                        match v1036 with
                        | US9_1(v1039) -> (* Error *)
                            let v1040 : string = $"%A{v1039}"
                            let v1043 : string = "System.TimeoutException"
                            let v1044 : bool = v1040.Contains v1043 
                            if v1044 then
                                let v1047 : unit = ()
                                let v1048 : (unit -> unit) = closure29(v0)
                                let v1049 : unit = (fun () -> v1048 (); v1047) ()
                                US2_1
                            else
                                let v1090 : unit = ()
                                let v1091 : (unit -> unit) = closure30(v0, v1039)
                                let v1092 : unit = (fun () -> v1091 (); v1090) ()
                                US2_1
                        | US9_0(v1037) -> (* Ok *)
                            US2_0(v1037)
                    return v1160 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v2036 : Async<US2> = _v1033 
            let _v19 = v2036 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v2037 : unit = ()
            let _v2037 =
                async {
                    let! v18 = v18 
                    let v2040 : US9 = v18 
                    let v2164 : US2 =
                        match v2040 with
                        | US9_1(v2043) -> (* Error *)
                            let v2044 : string = $"%A{v2043}"
                            let v2047 : string = "System.TimeoutException"
                            let v2048 : bool = v2044.Contains v2047 
                            if v2048 then
                                let v2051 : unit = ()
                                let v2052 : (unit -> unit) = closure29(v0)
                                let v2053 : unit = (fun () -> v2052 (); v2051) ()
                                US2_1
                            else
                                let v2094 : unit = ()
                                let v2095 : (unit -> unit) = closure30(v0, v2043)
                                let v2096 : unit = (fun () -> v2095 (); v2094) ()
                                US2_1
                        | US9_0(v2041) -> (* Ok *)
                            US2_0(v2041)
                    return v2164 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v3040 : Async<US2> = _v2037 
            let _v19 = v3040 
            #endif
#else
            let v3041 : unit = ()
            let _v3041 =
                async {
                    let! v18 = v18 
                    let v3044 : US9 = v18 
                    let v3168 : US2 =
                        match v3044 with
                        | US9_1(v3047) -> (* Error *)
                            let v3048 : string = $"%A{v3047}"
                            let v3051 : string = "System.TimeoutException"
                            let v3052 : bool = v3048.Contains v3051 
                            if v3052 then
                                let v3055 : unit = ()
                                let v3056 : (unit -> unit) = closure29(v0)
                                let v3057 : unit = (fun () -> v3056 (); v3055) ()
                                US2_1
                            else
                                let v3098 : unit = ()
                                let v3099 : (unit -> unit) = closure30(v0, v3047)
                                let v3100 : unit = (fun () -> v3099 (); v3098) ()
                                US2_1
                        | US9_0(v3045) -> (* Ok *)
                            US2_0(v3045)
                    return v3168 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v4044 : Async<US2> = _v3041 
            let _v19 = v4044 
            #endif
            let v4045 : Async<US2> = _v19 
            return! v4045 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v36296 : Async<US2> = _v13 
    let _v3 = v36296 
    #endif
#if FABLE_COMPILER_PYTHON
    let v36297 : unit = ()
    let _v36297 =
        async {
            let v36300 : Async<Async<int64>> = method52(v0, v1)
            let! v36300 = v36300 
            let v36301 : Async<int64> = v36300 
            let v36302 : Async<US9> = method53(v36301)
            let v36303 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v36304 : Async<US2> = null |> unbox<Async<US2>>
            let _v36303 = v36304 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v36307 : Async<US2> = null |> unbox<Async<US2>>
            let _v36303 = v36307 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v36310 : Async<US2> = null |> unbox<Async<US2>>
            let _v36303 = v36310 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v36313 : unit = ()
            let _v36313 =
                async {
                    let! v36302 = v36302 
                    let v36316 : US9 = v36302 
                    let v36440 : US2 =
                        match v36316 with
                        | US9_1(v36319) -> (* Error *)
                            let v36320 : string = $"%A{v36319}"
                            let v36323 : string = "System.TimeoutException"
                            let v36324 : bool = v36320.Contains v36323 
                            if v36324 then
                                let v36327 : unit = ()
                                let v36328 : (unit -> unit) = closure29(v0)
                                let v36329 : unit = (fun () -> v36328 (); v36327) ()
                                US2_1
                            else
                                let v36370 : unit = ()
                                let v36371 : (unit -> unit) = closure30(v0, v36319)
                                let v36372 : unit = (fun () -> v36371 (); v36370) ()
                                US2_1
                        | US9_0(v36317) -> (* Ok *)
                            US2_0(v36317)
                    return v36440 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v37316 : Async<US2> = _v36313 
            let _v36303 = v37316 
            #endif
#if FABLE_COMPILER_PYTHON
            let v37317 : unit = ()
            let _v37317 =
                async {
                    let! v36302 = v36302 
                    let v37320 : US9 = v36302 
                    let v37444 : US2 =
                        match v37320 with
                        | US9_1(v37323) -> (* Error *)
                            let v37324 : string = $"%A{v37323}"
                            let v37327 : string = "System.TimeoutException"
                            let v37328 : bool = v37324.Contains v37327 
                            if v37328 then
                                let v37331 : unit = ()
                                let v37332 : (unit -> unit) = closure29(v0)
                                let v37333 : unit = (fun () -> v37332 (); v37331) ()
                                US2_1
                            else
                                let v37374 : unit = ()
                                let v37375 : (unit -> unit) = closure30(v0, v37323)
                                let v37376 : unit = (fun () -> v37375 (); v37374) ()
                                US2_1
                        | US9_0(v37321) -> (* Ok *)
                            US2_0(v37321)
                    return v37444 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v38320 : Async<US2> = _v37317 
            let _v36303 = v38320 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v38321 : unit = ()
            let _v38321 =
                async {
                    let! v36302 = v36302 
                    let v38324 : US9 = v36302 
                    let v38448 : US2 =
                        match v38324 with
                        | US9_1(v38327) -> (* Error *)
                            let v38328 : string = $"%A{v38327}"
                            let v38331 : string = "System.TimeoutException"
                            let v38332 : bool = v38328.Contains v38331 
                            if v38332 then
                                let v38335 : unit = ()
                                let v38336 : (unit -> unit) = closure29(v0)
                                let v38337 : unit = (fun () -> v38336 (); v38335) ()
                                US2_1
                            else
                                let v38378 : unit = ()
                                let v38379 : (unit -> unit) = closure30(v0, v38327)
                                let v38380 : unit = (fun () -> v38379 (); v38378) ()
                                US2_1
                        | US9_0(v38325) -> (* Ok *)
                            US2_0(v38325)
                    return v38448 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v39324 : Async<US2> = _v38321 
            let _v36303 = v39324 
            #endif
#else
            let v39325 : unit = ()
            let _v39325 =
                async {
                    let! v36302 = v36302 
                    let v39328 : US9 = v36302 
                    let v39452 : US2 =
                        match v39328 with
                        | US9_1(v39331) -> (* Error *)
                            let v39332 : string = $"%A{v39331}"
                            let v39335 : string = "System.TimeoutException"
                            let v39336 : bool = v39332.Contains v39335 
                            if v39336 then
                                let v39339 : unit = ()
                                let v39340 : (unit -> unit) = closure29(v0)
                                let v39341 : unit = (fun () -> v39340 (); v39339) ()
                                US2_1
                            else
                                let v39382 : unit = ()
                                let v39383 : (unit -> unit) = closure30(v0, v39331)
                                let v39384 : unit = (fun () -> v39383 (); v39382) ()
                                US2_1
                        | US9_0(v39329) -> (* Ok *)
                            US2_0(v39329)
                    return v39452 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v40328 : Async<US2> = _v39325 
            let _v36303 = v40328 
            #endif
            let v40329 : Async<US2> = _v36303 
            return! v40329 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v72580 : Async<US2> = _v36297 
    let _v3 = v72580 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v72581 : unit = ()
    let _v72581 =
        async {
            let v72584 : Async<Async<int64>> = method52(v0, v1)
            let! v72584 = v72584 
            let v72585 : Async<int64> = v72584 
            let v72586 : Async<US9> = method53(v72585)
            let v72587 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v72588 : Async<US2> = null |> unbox<Async<US2>>
            let _v72587 = v72588 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v72591 : Async<US2> = null |> unbox<Async<US2>>
            let _v72587 = v72591 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v72594 : Async<US2> = null |> unbox<Async<US2>>
            let _v72587 = v72594 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v72597 : unit = ()
            let _v72597 =
                async {
                    let! v72586 = v72586 
                    let v72600 : US9 = v72586 
                    let v72724 : US2 =
                        match v72600 with
                        | US9_1(v72603) -> (* Error *)
                            let v72604 : string = $"%A{v72603}"
                            let v72607 : string = "System.TimeoutException"
                            let v72608 : bool = v72604.Contains v72607 
                            if v72608 then
                                let v72611 : unit = ()
                                let v72612 : (unit -> unit) = closure29(v0)
                                let v72613 : unit = (fun () -> v72612 (); v72611) ()
                                US2_1
                            else
                                let v72654 : unit = ()
                                let v72655 : (unit -> unit) = closure30(v0, v72603)
                                let v72656 : unit = (fun () -> v72655 (); v72654) ()
                                US2_1
                        | US9_0(v72601) -> (* Ok *)
                            US2_0(v72601)
                    return v72724 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v73600 : Async<US2> = _v72597 
            let _v72587 = v73600 
            #endif
#if FABLE_COMPILER_PYTHON
            let v73601 : unit = ()
            let _v73601 =
                async {
                    let! v72586 = v72586 
                    let v73604 : US9 = v72586 
                    let v73728 : US2 =
                        match v73604 with
                        | US9_1(v73607) -> (* Error *)
                            let v73608 : string = $"%A{v73607}"
                            let v73611 : string = "System.TimeoutException"
                            let v73612 : bool = v73608.Contains v73611 
                            if v73612 then
                                let v73615 : unit = ()
                                let v73616 : (unit -> unit) = closure29(v0)
                                let v73617 : unit = (fun () -> v73616 (); v73615) ()
                                US2_1
                            else
                                let v73658 : unit = ()
                                let v73659 : (unit -> unit) = closure30(v0, v73607)
                                let v73660 : unit = (fun () -> v73659 (); v73658) ()
                                US2_1
                        | US9_0(v73605) -> (* Ok *)
                            US2_0(v73605)
                    return v73728 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v74604 : Async<US2> = _v73601 
            let _v72587 = v74604 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v74605 : unit = ()
            let _v74605 =
                async {
                    let! v72586 = v72586 
                    let v74608 : US9 = v72586 
                    let v74732 : US2 =
                        match v74608 with
                        | US9_1(v74611) -> (* Error *)
                            let v74612 : string = $"%A{v74611}"
                            let v74615 : string = "System.TimeoutException"
                            let v74616 : bool = v74612.Contains v74615 
                            if v74616 then
                                let v74619 : unit = ()
                                let v74620 : (unit -> unit) = closure29(v0)
                                let v74621 : unit = (fun () -> v74620 (); v74619) ()
                                US2_1
                            else
                                let v74662 : unit = ()
                                let v74663 : (unit -> unit) = closure30(v0, v74611)
                                let v74664 : unit = (fun () -> v74663 (); v74662) ()
                                US2_1
                        | US9_0(v74609) -> (* Ok *)
                            US2_0(v74609)
                    return v74732 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v75608 : Async<US2> = _v74605 
            let _v72587 = v75608 
            #endif
#else
            let v75609 : unit = ()
            let _v75609 =
                async {
                    let! v72586 = v72586 
                    let v75612 : US9 = v72586 
                    let v75736 : US2 =
                        match v75612 with
                        | US9_1(v75615) -> (* Error *)
                            let v75616 : string = $"%A{v75615}"
                            let v75619 : string = "System.TimeoutException"
                            let v75620 : bool = v75616.Contains v75619 
                            if v75620 then
                                let v75623 : unit = ()
                                let v75624 : (unit -> unit) = closure29(v0)
                                let v75625 : unit = (fun () -> v75624 (); v75623) ()
                                US2_1
                            else
                                let v75666 : unit = ()
                                let v75667 : (unit -> unit) = closure30(v0, v75615)
                                let v75668 : unit = (fun () -> v75667 (); v75666) ()
                                US2_1
                        | US9_0(v75613) -> (* Ok *)
                            US2_0(v75613)
                    return v75736 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v76612 : Async<US2> = _v75609 
            let _v72587 = v76612 
            #endif
            let v76613 : Async<US2> = _v72587 
            return! v76613 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v108864 : Async<US2> = _v72581 
    let _v3 = v108864 
    #endif
#else
    let v108865 : unit = ()
    let _v108865 =
        async {
            let v108868 : Async<Async<int64>> = method52(v0, v1)
            let! v108868 = v108868 
            let v108869 : Async<int64> = v108868 
            let v108870 : Async<US9> = method53(v108869)
            let v108871 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v108872 : Async<US2> = null |> unbox<Async<US2>>
            let _v108871 = v108872 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v108875 : Async<US2> = null |> unbox<Async<US2>>
            let _v108871 = v108875 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v108878 : Async<US2> = null |> unbox<Async<US2>>
            let _v108871 = v108878 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v108881 : unit = ()
            let _v108881 =
                async {
                    let! v108870 = v108870 
                    let v108884 : US9 = v108870 
                    let v109008 : US2 =
                        match v108884 with
                        | US9_1(v108887) -> (* Error *)
                            let v108888 : string = $"%A{v108887}"
                            let v108891 : string = "System.TimeoutException"
                            let v108892 : bool = v108888.Contains v108891 
                            if v108892 then
                                let v108895 : unit = ()
                                let v108896 : (unit -> unit) = closure29(v0)
                                let v108897 : unit = (fun () -> v108896 (); v108895) ()
                                US2_1
                            else
                                let v108938 : unit = ()
                                let v108939 : (unit -> unit) = closure30(v0, v108887)
                                let v108940 : unit = (fun () -> v108939 (); v108938) ()
                                US2_1
                        | US9_0(v108885) -> (* Ok *)
                            US2_0(v108885)
                    return v109008 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v109884 : Async<US2> = _v108881 
            let _v108871 = v109884 
            #endif
#if FABLE_COMPILER_PYTHON
            let v109885 : unit = ()
            let _v109885 =
                async {
                    let! v108870 = v108870 
                    let v109888 : US9 = v108870 
                    let v110012 : US2 =
                        match v109888 with
                        | US9_1(v109891) -> (* Error *)
                            let v109892 : string = $"%A{v109891}"
                            let v109895 : string = "System.TimeoutException"
                            let v109896 : bool = v109892.Contains v109895 
                            if v109896 then
                                let v109899 : unit = ()
                                let v109900 : (unit -> unit) = closure29(v0)
                                let v109901 : unit = (fun () -> v109900 (); v109899) ()
                                US2_1
                            else
                                let v109942 : unit = ()
                                let v109943 : (unit -> unit) = closure30(v0, v109891)
                                let v109944 : unit = (fun () -> v109943 (); v109942) ()
                                US2_1
                        | US9_0(v109889) -> (* Ok *)
                            US2_0(v109889)
                    return v110012 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v110888 : Async<US2> = _v109885 
            let _v108871 = v110888 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v110889 : unit = ()
            let _v110889 =
                async {
                    let! v108870 = v108870 
                    let v110892 : US9 = v108870 
                    let v111016 : US2 =
                        match v110892 with
                        | US9_1(v110895) -> (* Error *)
                            let v110896 : string = $"%A{v110895}"
                            let v110899 : string = "System.TimeoutException"
                            let v110900 : bool = v110896.Contains v110899 
                            if v110900 then
                                let v110903 : unit = ()
                                let v110904 : (unit -> unit) = closure29(v0)
                                let v110905 : unit = (fun () -> v110904 (); v110903) ()
                                US2_1
                            else
                                let v110946 : unit = ()
                                let v110947 : (unit -> unit) = closure30(v0, v110895)
                                let v110948 : unit = (fun () -> v110947 (); v110946) ()
                                US2_1
                        | US9_0(v110893) -> (* Ok *)
                            US2_0(v110893)
                    return v111016 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v111892 : Async<US2> = _v110889 
            let _v108871 = v111892 
            #endif
#else
            let v111893 : unit = ()
            let _v111893 =
                async {
                    let! v108870 = v108870 
                    let v111896 : US9 = v108870 
                    let v112020 : US2 =
                        match v111896 with
                        | US9_1(v111899) -> (* Error *)
                            let v111900 : string = $"%A{v111899}"
                            let v111903 : string = "System.TimeoutException"
                            let v111904 : bool = v111900.Contains v111903 
                            if v111904 then
                                let v111907 : unit = ()
                                let v111908 : (unit -> unit) = closure29(v0)
                                let v111909 : unit = (fun () -> v111908 (); v111907) ()
                                US2_1
                            else
                                let v111950 : unit = ()
                                let v111951 : (unit -> unit) = closure30(v0, v111899)
                                let v111952 : unit = (fun () -> v111951 (); v111950) ()
                                US2_1
                        | US9_0(v111897) -> (* Ok *)
                            US2_0(v111897)
                    return v112020 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v112896 : Async<US2> = _v111893 
            let _v108871 = v112896 
            #endif
            let v112897 : Async<US2> = _v108871 
            return! v112897 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v145148 : Async<US2> = _v108865 
    let _v3 = v145148 
    #endif
    let v145149 : Async<US2> = _v3 
    let _v2 = v145149 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v163295 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v163296 : Async<US2> = null |> unbox<Async<US2>>
    let _v163295 = v163296 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v163299 : Async<US2> = null |> unbox<Async<US2>>
    let _v163295 = v163299 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v163302 : Async<US2> = null |> unbox<Async<US2>>
    let _v163295 = v163302 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v163305 : unit = ()
    let _v163305 =
        async {
            let v163308 : Async<Async<int64>> = method52(v0, v1)
            let! v163308 = v163308 
            let v163309 : Async<int64> = v163308 
            let v163310 : Async<US9> = method53(v163309)
            let v163311 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v163312 : Async<US2> = null |> unbox<Async<US2>>
            let _v163311 = v163312 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v163315 : Async<US2> = null |> unbox<Async<US2>>
            let _v163311 = v163315 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v163318 : Async<US2> = null |> unbox<Async<US2>>
            let _v163311 = v163318 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v163321 : unit = ()
            let _v163321 =
                async {
                    let! v163310 = v163310 
                    let v163324 : US9 = v163310 
                    let v163448 : US2 =
                        match v163324 with
                        | US9_1(v163327) -> (* Error *)
                            let v163328 : string = $"%A{v163327}"
                            let v163331 : string = "System.TimeoutException"
                            let v163332 : bool = v163328.Contains v163331 
                            if v163332 then
                                let v163335 : unit = ()
                                let v163336 : (unit -> unit) = closure29(v0)
                                let v163337 : unit = (fun () -> v163336 (); v163335) ()
                                US2_1
                            else
                                let v163378 : unit = ()
                                let v163379 : (unit -> unit) = closure30(v0, v163327)
                                let v163380 : unit = (fun () -> v163379 (); v163378) ()
                                US2_1
                        | US9_0(v163325) -> (* Ok *)
                            US2_0(v163325)
                    return v163448 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v164324 : Async<US2> = _v163321 
            let _v163311 = v164324 
            #endif
#if FABLE_COMPILER_PYTHON
            let v164325 : unit = ()
            let _v164325 =
                async {
                    let! v163310 = v163310 
                    let v164328 : US9 = v163310 
                    let v164452 : US2 =
                        match v164328 with
                        | US9_1(v164331) -> (* Error *)
                            let v164332 : string = $"%A{v164331}"
                            let v164335 : string = "System.TimeoutException"
                            let v164336 : bool = v164332.Contains v164335 
                            if v164336 then
                                let v164339 : unit = ()
                                let v164340 : (unit -> unit) = closure29(v0)
                                let v164341 : unit = (fun () -> v164340 (); v164339) ()
                                US2_1
                            else
                                let v164382 : unit = ()
                                let v164383 : (unit -> unit) = closure30(v0, v164331)
                                let v164384 : unit = (fun () -> v164383 (); v164382) ()
                                US2_1
                        | US9_0(v164329) -> (* Ok *)
                            US2_0(v164329)
                    return v164452 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v165328 : Async<US2> = _v164325 
            let _v163311 = v165328 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v165329 : unit = ()
            let _v165329 =
                async {
                    let! v163310 = v163310 
                    let v165332 : US9 = v163310 
                    let v165456 : US2 =
                        match v165332 with
                        | US9_1(v165335) -> (* Error *)
                            let v165336 : string = $"%A{v165335}"
                            let v165339 : string = "System.TimeoutException"
                            let v165340 : bool = v165336.Contains v165339 
                            if v165340 then
                                let v165343 : unit = ()
                                let v165344 : (unit -> unit) = closure29(v0)
                                let v165345 : unit = (fun () -> v165344 (); v165343) ()
                                US2_1
                            else
                                let v165386 : unit = ()
                                let v165387 : (unit -> unit) = closure30(v0, v165335)
                                let v165388 : unit = (fun () -> v165387 (); v165386) ()
                                US2_1
                        | US9_0(v165333) -> (* Ok *)
                            US2_0(v165333)
                    return v165456 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v166332 : Async<US2> = _v165329 
            let _v163311 = v166332 
            #endif
#else
            let v166333 : unit = ()
            let _v166333 =
                async {
                    let! v163310 = v163310 
                    let v166336 : US9 = v163310 
                    let v166460 : US2 =
                        match v166336 with
                        | US9_1(v166339) -> (* Error *)
                            let v166340 : string = $"%A{v166339}"
                            let v166343 : string = "System.TimeoutException"
                            let v166344 : bool = v166340.Contains v166343 
                            if v166344 then
                                let v166347 : unit = ()
                                let v166348 : (unit -> unit) = closure29(v0)
                                let v166349 : unit = (fun () -> v166348 (); v166347) ()
                                US2_1
                            else
                                let v166390 : unit = ()
                                let v166391 : (unit -> unit) = closure30(v0, v166339)
                                let v166392 : unit = (fun () -> v166391 (); v166390) ()
                                US2_1
                        | US9_0(v166337) -> (* Ok *)
                            US2_0(v166337)
                    return v166460 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v167336 : Async<US2> = _v166333 
            let _v163311 = v167336 
            #endif
            let v167337 : Async<US2> = _v163311 
            return! v167337 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v199588 : Async<US2> = _v163305 
    let _v163295 = v199588 
    #endif
#if FABLE_COMPILER_PYTHON
    let v199589 : unit = ()
    let _v199589 =
        async {
            let v199592 : Async<Async<int64>> = method52(v0, v1)
            let! v199592 = v199592 
            let v199593 : Async<int64> = v199592 
            let v199594 : Async<US9> = method53(v199593)
            let v199595 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v199596 : Async<US2> = null |> unbox<Async<US2>>
            let _v199595 = v199596 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v199599 : Async<US2> = null |> unbox<Async<US2>>
            let _v199595 = v199599 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v199602 : Async<US2> = null |> unbox<Async<US2>>
            let _v199595 = v199602 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v199605 : unit = ()
            let _v199605 =
                async {
                    let! v199594 = v199594 
                    let v199608 : US9 = v199594 
                    let v199732 : US2 =
                        match v199608 with
                        | US9_1(v199611) -> (* Error *)
                            let v199612 : string = $"%A{v199611}"
                            let v199615 : string = "System.TimeoutException"
                            let v199616 : bool = v199612.Contains v199615 
                            if v199616 then
                                let v199619 : unit = ()
                                let v199620 : (unit -> unit) = closure29(v0)
                                let v199621 : unit = (fun () -> v199620 (); v199619) ()
                                US2_1
                            else
                                let v199662 : unit = ()
                                let v199663 : (unit -> unit) = closure30(v0, v199611)
                                let v199664 : unit = (fun () -> v199663 (); v199662) ()
                                US2_1
                        | US9_0(v199609) -> (* Ok *)
                            US2_0(v199609)
                    return v199732 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v200608 : Async<US2> = _v199605 
            let _v199595 = v200608 
            #endif
#if FABLE_COMPILER_PYTHON
            let v200609 : unit = ()
            let _v200609 =
                async {
                    let! v199594 = v199594 
                    let v200612 : US9 = v199594 
                    let v200736 : US2 =
                        match v200612 with
                        | US9_1(v200615) -> (* Error *)
                            let v200616 : string = $"%A{v200615}"
                            let v200619 : string = "System.TimeoutException"
                            let v200620 : bool = v200616.Contains v200619 
                            if v200620 then
                                let v200623 : unit = ()
                                let v200624 : (unit -> unit) = closure29(v0)
                                let v200625 : unit = (fun () -> v200624 (); v200623) ()
                                US2_1
                            else
                                let v200666 : unit = ()
                                let v200667 : (unit -> unit) = closure30(v0, v200615)
                                let v200668 : unit = (fun () -> v200667 (); v200666) ()
                                US2_1
                        | US9_0(v200613) -> (* Ok *)
                            US2_0(v200613)
                    return v200736 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v201612 : Async<US2> = _v200609 
            let _v199595 = v201612 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v201613 : unit = ()
            let _v201613 =
                async {
                    let! v199594 = v199594 
                    let v201616 : US9 = v199594 
                    let v201740 : US2 =
                        match v201616 with
                        | US9_1(v201619) -> (* Error *)
                            let v201620 : string = $"%A{v201619}"
                            let v201623 : string = "System.TimeoutException"
                            let v201624 : bool = v201620.Contains v201623 
                            if v201624 then
                                let v201627 : unit = ()
                                let v201628 : (unit -> unit) = closure29(v0)
                                let v201629 : unit = (fun () -> v201628 (); v201627) ()
                                US2_1
                            else
                                let v201670 : unit = ()
                                let v201671 : (unit -> unit) = closure30(v0, v201619)
                                let v201672 : unit = (fun () -> v201671 (); v201670) ()
                                US2_1
                        | US9_0(v201617) -> (* Ok *)
                            US2_0(v201617)
                    return v201740 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v202616 : Async<US2> = _v201613 
            let _v199595 = v202616 
            #endif
#else
            let v202617 : unit = ()
            let _v202617 =
                async {
                    let! v199594 = v199594 
                    let v202620 : US9 = v199594 
                    let v202744 : US2 =
                        match v202620 with
                        | US9_1(v202623) -> (* Error *)
                            let v202624 : string = $"%A{v202623}"
                            let v202627 : string = "System.TimeoutException"
                            let v202628 : bool = v202624.Contains v202627 
                            if v202628 then
                                let v202631 : unit = ()
                                let v202632 : (unit -> unit) = closure29(v0)
                                let v202633 : unit = (fun () -> v202632 (); v202631) ()
                                US2_1
                            else
                                let v202674 : unit = ()
                                let v202675 : (unit -> unit) = closure30(v0, v202623)
                                let v202676 : unit = (fun () -> v202675 (); v202674) ()
                                US2_1
                        | US9_0(v202621) -> (* Ok *)
                            US2_0(v202621)
                    return v202744 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v203620 : Async<US2> = _v202617 
            let _v199595 = v203620 
            #endif
            let v203621 : Async<US2> = _v199595 
            return! v203621 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v235872 : Async<US2> = _v199589 
    let _v163295 = v235872 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v235873 : unit = ()
    let _v235873 =
        async {
            let v235876 : Async<Async<int64>> = method52(v0, v1)
            let! v235876 = v235876 
            let v235877 : Async<int64> = v235876 
            let v235878 : Async<US9> = method53(v235877)
            let v235879 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v235880 : Async<US2> = null |> unbox<Async<US2>>
            let _v235879 = v235880 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v235883 : Async<US2> = null |> unbox<Async<US2>>
            let _v235879 = v235883 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v235886 : Async<US2> = null |> unbox<Async<US2>>
            let _v235879 = v235886 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v235889 : unit = ()
            let _v235889 =
                async {
                    let! v235878 = v235878 
                    let v235892 : US9 = v235878 
                    let v236016 : US2 =
                        match v235892 with
                        | US9_1(v235895) -> (* Error *)
                            let v235896 : string = $"%A{v235895}"
                            let v235899 : string = "System.TimeoutException"
                            let v235900 : bool = v235896.Contains v235899 
                            if v235900 then
                                let v235903 : unit = ()
                                let v235904 : (unit -> unit) = closure29(v0)
                                let v235905 : unit = (fun () -> v235904 (); v235903) ()
                                US2_1
                            else
                                let v235946 : unit = ()
                                let v235947 : (unit -> unit) = closure30(v0, v235895)
                                let v235948 : unit = (fun () -> v235947 (); v235946) ()
                                US2_1
                        | US9_0(v235893) -> (* Ok *)
                            US2_0(v235893)
                    return v236016 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v236892 : Async<US2> = _v235889 
            let _v235879 = v236892 
            #endif
#if FABLE_COMPILER_PYTHON
            let v236893 : unit = ()
            let _v236893 =
                async {
                    let! v235878 = v235878 
                    let v236896 : US9 = v235878 
                    let v237020 : US2 =
                        match v236896 with
                        | US9_1(v236899) -> (* Error *)
                            let v236900 : string = $"%A{v236899}"
                            let v236903 : string = "System.TimeoutException"
                            let v236904 : bool = v236900.Contains v236903 
                            if v236904 then
                                let v236907 : unit = ()
                                let v236908 : (unit -> unit) = closure29(v0)
                                let v236909 : unit = (fun () -> v236908 (); v236907) ()
                                US2_1
                            else
                                let v236950 : unit = ()
                                let v236951 : (unit -> unit) = closure30(v0, v236899)
                                let v236952 : unit = (fun () -> v236951 (); v236950) ()
                                US2_1
                        | US9_0(v236897) -> (* Ok *)
                            US2_0(v236897)
                    return v237020 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v237896 : Async<US2> = _v236893 
            let _v235879 = v237896 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v237897 : unit = ()
            let _v237897 =
                async {
                    let! v235878 = v235878 
                    let v237900 : US9 = v235878 
                    let v238024 : US2 =
                        match v237900 with
                        | US9_1(v237903) -> (* Error *)
                            let v237904 : string = $"%A{v237903}"
                            let v237907 : string = "System.TimeoutException"
                            let v237908 : bool = v237904.Contains v237907 
                            if v237908 then
                                let v237911 : unit = ()
                                let v237912 : (unit -> unit) = closure29(v0)
                                let v237913 : unit = (fun () -> v237912 (); v237911) ()
                                US2_1
                            else
                                let v237954 : unit = ()
                                let v237955 : (unit -> unit) = closure30(v0, v237903)
                                let v237956 : unit = (fun () -> v237955 (); v237954) ()
                                US2_1
                        | US9_0(v237901) -> (* Ok *)
                            US2_0(v237901)
                    return v238024 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v238900 : Async<US2> = _v237897 
            let _v235879 = v238900 
            #endif
#else
            let v238901 : unit = ()
            let _v238901 =
                async {
                    let! v235878 = v235878 
                    let v238904 : US9 = v235878 
                    let v239028 : US2 =
                        match v238904 with
                        | US9_1(v238907) -> (* Error *)
                            let v238908 : string = $"%A{v238907}"
                            let v238911 : string = "System.TimeoutException"
                            let v238912 : bool = v238908.Contains v238911 
                            if v238912 then
                                let v238915 : unit = ()
                                let v238916 : (unit -> unit) = closure29(v0)
                                let v238917 : unit = (fun () -> v238916 (); v238915) ()
                                US2_1
                            else
                                let v238958 : unit = ()
                                let v238959 : (unit -> unit) = closure30(v0, v238907)
                                let v238960 : unit = (fun () -> v238959 (); v238958) ()
                                US2_1
                        | US9_0(v238905) -> (* Ok *)
                            US2_0(v238905)
                    return v239028 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v239904 : Async<US2> = _v238901 
            let _v235879 = v239904 
            #endif
            let v239905 : Async<US2> = _v235879 
            return! v239905 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v272156 : Async<US2> = _v235873 
    let _v163295 = v272156 
    #endif
#else
    let v272157 : unit = ()
    let _v272157 =
        async {
            let v272160 : Async<Async<int64>> = method52(v0, v1)
            let! v272160 = v272160 
            let v272161 : Async<int64> = v272160 
            let v272162 : Async<US9> = method53(v272161)
            let v272163 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v272164 : Async<US2> = null |> unbox<Async<US2>>
            let _v272163 = v272164 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v272167 : Async<US2> = null |> unbox<Async<US2>>
            let _v272163 = v272167 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v272170 : Async<US2> = null |> unbox<Async<US2>>
            let _v272163 = v272170 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v272173 : unit = ()
            let _v272173 =
                async {
                    let! v272162 = v272162 
                    let v272176 : US9 = v272162 
                    let v272300 : US2 =
                        match v272176 with
                        | US9_1(v272179) -> (* Error *)
                            let v272180 : string = $"%A{v272179}"
                            let v272183 : string = "System.TimeoutException"
                            let v272184 : bool = v272180.Contains v272183 
                            if v272184 then
                                let v272187 : unit = ()
                                let v272188 : (unit -> unit) = closure29(v0)
                                let v272189 : unit = (fun () -> v272188 (); v272187) ()
                                US2_1
                            else
                                let v272230 : unit = ()
                                let v272231 : (unit -> unit) = closure30(v0, v272179)
                                let v272232 : unit = (fun () -> v272231 (); v272230) ()
                                US2_1
                        | US9_0(v272177) -> (* Ok *)
                            US2_0(v272177)
                    return v272300 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v273176 : Async<US2> = _v272173 
            let _v272163 = v273176 
            #endif
#if FABLE_COMPILER_PYTHON
            let v273177 : unit = ()
            let _v273177 =
                async {
                    let! v272162 = v272162 
                    let v273180 : US9 = v272162 
                    let v273304 : US2 =
                        match v273180 with
                        | US9_1(v273183) -> (* Error *)
                            let v273184 : string = $"%A{v273183}"
                            let v273187 : string = "System.TimeoutException"
                            let v273188 : bool = v273184.Contains v273187 
                            if v273188 then
                                let v273191 : unit = ()
                                let v273192 : (unit -> unit) = closure29(v0)
                                let v273193 : unit = (fun () -> v273192 (); v273191) ()
                                US2_1
                            else
                                let v273234 : unit = ()
                                let v273235 : (unit -> unit) = closure30(v0, v273183)
                                let v273236 : unit = (fun () -> v273235 (); v273234) ()
                                US2_1
                        | US9_0(v273181) -> (* Ok *)
                            US2_0(v273181)
                    return v273304 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v274180 : Async<US2> = _v273177 
            let _v272163 = v274180 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v274181 : unit = ()
            let _v274181 =
                async {
                    let! v272162 = v272162 
                    let v274184 : US9 = v272162 
                    let v274308 : US2 =
                        match v274184 with
                        | US9_1(v274187) -> (* Error *)
                            let v274188 : string = $"%A{v274187}"
                            let v274191 : string = "System.TimeoutException"
                            let v274192 : bool = v274188.Contains v274191 
                            if v274192 then
                                let v274195 : unit = ()
                                let v274196 : (unit -> unit) = closure29(v0)
                                let v274197 : unit = (fun () -> v274196 (); v274195) ()
                                US2_1
                            else
                                let v274238 : unit = ()
                                let v274239 : (unit -> unit) = closure30(v0, v274187)
                                let v274240 : unit = (fun () -> v274239 (); v274238) ()
                                US2_1
                        | US9_0(v274185) -> (* Ok *)
                            US2_0(v274185)
                    return v274308 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v275184 : Async<US2> = _v274181 
            let _v272163 = v275184 
            #endif
#else
            let v275185 : unit = ()
            let _v275185 =
                async {
                    let! v272162 = v272162 
                    let v275188 : US9 = v272162 
                    let v275312 : US2 =
                        match v275188 with
                        | US9_1(v275191) -> (* Error *)
                            let v275192 : string = $"%A{v275191}"
                            let v275195 : string = "System.TimeoutException"
                            let v275196 : bool = v275192.Contains v275195 
                            if v275196 then
                                let v275199 : unit = ()
                                let v275200 : (unit -> unit) = closure29(v0)
                                let v275201 : unit = (fun () -> v275200 (); v275199) ()
                                US2_1
                            else
                                let v275242 : unit = ()
                                let v275243 : (unit -> unit) = closure30(v0, v275191)
                                let v275244 : unit = (fun () -> v275243 (); v275242) ()
                                US2_1
                        | US9_0(v275189) -> (* Ok *)
                            US2_0(v275189)
                    return v275312 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v276188 : Async<US2> = _v275185 
            let _v272163 = v276188 
            #endif
            let v276189 : Async<US2> = _v272163 
            return! v276189 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v308440 : Async<US2> = _v272157 
    let _v163295 = v308440 
    #endif
    let v308441 : Async<US2> = _v163295 
    let _v2 = v308441 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v326587 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v326588 : Async<US2> = null |> unbox<Async<US2>>
    let _v326587 = v326588 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v326591 : Async<US2> = null |> unbox<Async<US2>>
    let _v326587 = v326591 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v326594 : Async<US2> = null |> unbox<Async<US2>>
    let _v326587 = v326594 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v326597 : unit = ()
    let _v326597 =
        async {
            let v326600 : Async<Async<int64>> = method52(v0, v1)
            let! v326600 = v326600 
            let v326601 : Async<int64> = v326600 
            let v326602 : Async<US9> = method53(v326601)
            let v326603 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v326604 : Async<US2> = null |> unbox<Async<US2>>
            let _v326603 = v326604 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v326607 : Async<US2> = null |> unbox<Async<US2>>
            let _v326603 = v326607 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v326610 : Async<US2> = null |> unbox<Async<US2>>
            let _v326603 = v326610 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v326613 : unit = ()
            let _v326613 =
                async {
                    let! v326602 = v326602 
                    let v326616 : US9 = v326602 
                    let v326740 : US2 =
                        match v326616 with
                        | US9_1(v326619) -> (* Error *)
                            let v326620 : string = $"%A{v326619}"
                            let v326623 : string = "System.TimeoutException"
                            let v326624 : bool = v326620.Contains v326623 
                            if v326624 then
                                let v326627 : unit = ()
                                let v326628 : (unit -> unit) = closure29(v0)
                                let v326629 : unit = (fun () -> v326628 (); v326627) ()
                                US2_1
                            else
                                let v326670 : unit = ()
                                let v326671 : (unit -> unit) = closure30(v0, v326619)
                                let v326672 : unit = (fun () -> v326671 (); v326670) ()
                                US2_1
                        | US9_0(v326617) -> (* Ok *)
                            US2_0(v326617)
                    return v326740 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v327616 : Async<US2> = _v326613 
            let _v326603 = v327616 
            #endif
#if FABLE_COMPILER_PYTHON
            let v327617 : unit = ()
            let _v327617 =
                async {
                    let! v326602 = v326602 
                    let v327620 : US9 = v326602 
                    let v327744 : US2 =
                        match v327620 with
                        | US9_1(v327623) -> (* Error *)
                            let v327624 : string = $"%A{v327623}"
                            let v327627 : string = "System.TimeoutException"
                            let v327628 : bool = v327624.Contains v327627 
                            if v327628 then
                                let v327631 : unit = ()
                                let v327632 : (unit -> unit) = closure29(v0)
                                let v327633 : unit = (fun () -> v327632 (); v327631) ()
                                US2_1
                            else
                                let v327674 : unit = ()
                                let v327675 : (unit -> unit) = closure30(v0, v327623)
                                let v327676 : unit = (fun () -> v327675 (); v327674) ()
                                US2_1
                        | US9_0(v327621) -> (* Ok *)
                            US2_0(v327621)
                    return v327744 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v328620 : Async<US2> = _v327617 
            let _v326603 = v328620 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v328621 : unit = ()
            let _v328621 =
                async {
                    let! v326602 = v326602 
                    let v328624 : US9 = v326602 
                    let v328748 : US2 =
                        match v328624 with
                        | US9_1(v328627) -> (* Error *)
                            let v328628 : string = $"%A{v328627}"
                            let v328631 : string = "System.TimeoutException"
                            let v328632 : bool = v328628.Contains v328631 
                            if v328632 then
                                let v328635 : unit = ()
                                let v328636 : (unit -> unit) = closure29(v0)
                                let v328637 : unit = (fun () -> v328636 (); v328635) ()
                                US2_1
                            else
                                let v328678 : unit = ()
                                let v328679 : (unit -> unit) = closure30(v0, v328627)
                                let v328680 : unit = (fun () -> v328679 (); v328678) ()
                                US2_1
                        | US9_0(v328625) -> (* Ok *)
                            US2_0(v328625)
                    return v328748 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v329624 : Async<US2> = _v328621 
            let _v326603 = v329624 
            #endif
#else
            let v329625 : unit = ()
            let _v329625 =
                async {
                    let! v326602 = v326602 
                    let v329628 : US9 = v326602 
                    let v329752 : US2 =
                        match v329628 with
                        | US9_1(v329631) -> (* Error *)
                            let v329632 : string = $"%A{v329631}"
                            let v329635 : string = "System.TimeoutException"
                            let v329636 : bool = v329632.Contains v329635 
                            if v329636 then
                                let v329639 : unit = ()
                                let v329640 : (unit -> unit) = closure29(v0)
                                let v329641 : unit = (fun () -> v329640 (); v329639) ()
                                US2_1
                            else
                                let v329682 : unit = ()
                                let v329683 : (unit -> unit) = closure30(v0, v329631)
                                let v329684 : unit = (fun () -> v329683 (); v329682) ()
                                US2_1
                        | US9_0(v329629) -> (* Ok *)
                            US2_0(v329629)
                    return v329752 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v330628 : Async<US2> = _v329625 
            let _v326603 = v330628 
            #endif
            let v330629 : Async<US2> = _v326603 
            return! v330629 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v362880 : Async<US2> = _v326597 
    let _v326587 = v362880 
    #endif
#if FABLE_COMPILER_PYTHON
    let v362881 : unit = ()
    let _v362881 =
        async {
            let v362884 : Async<Async<int64>> = method52(v0, v1)
            let! v362884 = v362884 
            let v362885 : Async<int64> = v362884 
            let v362886 : Async<US9> = method53(v362885)
            let v362887 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v362888 : Async<US2> = null |> unbox<Async<US2>>
            let _v362887 = v362888 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v362891 : Async<US2> = null |> unbox<Async<US2>>
            let _v362887 = v362891 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v362894 : Async<US2> = null |> unbox<Async<US2>>
            let _v362887 = v362894 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v362897 : unit = ()
            let _v362897 =
                async {
                    let! v362886 = v362886 
                    let v362900 : US9 = v362886 
                    let v363024 : US2 =
                        match v362900 with
                        | US9_1(v362903) -> (* Error *)
                            let v362904 : string = $"%A{v362903}"
                            let v362907 : string = "System.TimeoutException"
                            let v362908 : bool = v362904.Contains v362907 
                            if v362908 then
                                let v362911 : unit = ()
                                let v362912 : (unit -> unit) = closure29(v0)
                                let v362913 : unit = (fun () -> v362912 (); v362911) ()
                                US2_1
                            else
                                let v362954 : unit = ()
                                let v362955 : (unit -> unit) = closure30(v0, v362903)
                                let v362956 : unit = (fun () -> v362955 (); v362954) ()
                                US2_1
                        | US9_0(v362901) -> (* Ok *)
                            US2_0(v362901)
                    return v363024 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v363900 : Async<US2> = _v362897 
            let _v362887 = v363900 
            #endif
#if FABLE_COMPILER_PYTHON
            let v363901 : unit = ()
            let _v363901 =
                async {
                    let! v362886 = v362886 
                    let v363904 : US9 = v362886 
                    let v364028 : US2 =
                        match v363904 with
                        | US9_1(v363907) -> (* Error *)
                            let v363908 : string = $"%A{v363907}"
                            let v363911 : string = "System.TimeoutException"
                            let v363912 : bool = v363908.Contains v363911 
                            if v363912 then
                                let v363915 : unit = ()
                                let v363916 : (unit -> unit) = closure29(v0)
                                let v363917 : unit = (fun () -> v363916 (); v363915) ()
                                US2_1
                            else
                                let v363958 : unit = ()
                                let v363959 : (unit -> unit) = closure30(v0, v363907)
                                let v363960 : unit = (fun () -> v363959 (); v363958) ()
                                US2_1
                        | US9_0(v363905) -> (* Ok *)
                            US2_0(v363905)
                    return v364028 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v364904 : Async<US2> = _v363901 
            let _v362887 = v364904 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v364905 : unit = ()
            let _v364905 =
                async {
                    let! v362886 = v362886 
                    let v364908 : US9 = v362886 
                    let v365032 : US2 =
                        match v364908 with
                        | US9_1(v364911) -> (* Error *)
                            let v364912 : string = $"%A{v364911}"
                            let v364915 : string = "System.TimeoutException"
                            let v364916 : bool = v364912.Contains v364915 
                            if v364916 then
                                let v364919 : unit = ()
                                let v364920 : (unit -> unit) = closure29(v0)
                                let v364921 : unit = (fun () -> v364920 (); v364919) ()
                                US2_1
                            else
                                let v364962 : unit = ()
                                let v364963 : (unit -> unit) = closure30(v0, v364911)
                                let v364964 : unit = (fun () -> v364963 (); v364962) ()
                                US2_1
                        | US9_0(v364909) -> (* Ok *)
                            US2_0(v364909)
                    return v365032 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v365908 : Async<US2> = _v364905 
            let _v362887 = v365908 
            #endif
#else
            let v365909 : unit = ()
            let _v365909 =
                async {
                    let! v362886 = v362886 
                    let v365912 : US9 = v362886 
                    let v366036 : US2 =
                        match v365912 with
                        | US9_1(v365915) -> (* Error *)
                            let v365916 : string = $"%A{v365915}"
                            let v365919 : string = "System.TimeoutException"
                            let v365920 : bool = v365916.Contains v365919 
                            if v365920 then
                                let v365923 : unit = ()
                                let v365924 : (unit -> unit) = closure29(v0)
                                let v365925 : unit = (fun () -> v365924 (); v365923) ()
                                US2_1
                            else
                                let v365966 : unit = ()
                                let v365967 : (unit -> unit) = closure30(v0, v365915)
                                let v365968 : unit = (fun () -> v365967 (); v365966) ()
                                US2_1
                        | US9_0(v365913) -> (* Ok *)
                            US2_0(v365913)
                    return v366036 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v366912 : Async<US2> = _v365909 
            let _v362887 = v366912 
            #endif
            let v366913 : Async<US2> = _v362887 
            return! v366913 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v399164 : Async<US2> = _v362881 
    let _v326587 = v399164 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v399165 : unit = ()
    let _v399165 =
        async {
            let v399168 : Async<Async<int64>> = method52(v0, v1)
            let! v399168 = v399168 
            let v399169 : Async<int64> = v399168 
            let v399170 : Async<US9> = method53(v399169)
            let v399171 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v399172 : Async<US2> = null |> unbox<Async<US2>>
            let _v399171 = v399172 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v399175 : Async<US2> = null |> unbox<Async<US2>>
            let _v399171 = v399175 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v399178 : Async<US2> = null |> unbox<Async<US2>>
            let _v399171 = v399178 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v399181 : unit = ()
            let _v399181 =
                async {
                    let! v399170 = v399170 
                    let v399184 : US9 = v399170 
                    let v399308 : US2 =
                        match v399184 with
                        | US9_1(v399187) -> (* Error *)
                            let v399188 : string = $"%A{v399187}"
                            let v399191 : string = "System.TimeoutException"
                            let v399192 : bool = v399188.Contains v399191 
                            if v399192 then
                                let v399195 : unit = ()
                                let v399196 : (unit -> unit) = closure29(v0)
                                let v399197 : unit = (fun () -> v399196 (); v399195) ()
                                US2_1
                            else
                                let v399238 : unit = ()
                                let v399239 : (unit -> unit) = closure30(v0, v399187)
                                let v399240 : unit = (fun () -> v399239 (); v399238) ()
                                US2_1
                        | US9_0(v399185) -> (* Ok *)
                            US2_0(v399185)
                    return v399308 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v400184 : Async<US2> = _v399181 
            let _v399171 = v400184 
            #endif
#if FABLE_COMPILER_PYTHON
            let v400185 : unit = ()
            let _v400185 =
                async {
                    let! v399170 = v399170 
                    let v400188 : US9 = v399170 
                    let v400312 : US2 =
                        match v400188 with
                        | US9_1(v400191) -> (* Error *)
                            let v400192 : string = $"%A{v400191}"
                            let v400195 : string = "System.TimeoutException"
                            let v400196 : bool = v400192.Contains v400195 
                            if v400196 then
                                let v400199 : unit = ()
                                let v400200 : (unit -> unit) = closure29(v0)
                                let v400201 : unit = (fun () -> v400200 (); v400199) ()
                                US2_1
                            else
                                let v400242 : unit = ()
                                let v400243 : (unit -> unit) = closure30(v0, v400191)
                                let v400244 : unit = (fun () -> v400243 (); v400242) ()
                                US2_1
                        | US9_0(v400189) -> (* Ok *)
                            US2_0(v400189)
                    return v400312 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v401188 : Async<US2> = _v400185 
            let _v399171 = v401188 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v401189 : unit = ()
            let _v401189 =
                async {
                    let! v399170 = v399170 
                    let v401192 : US9 = v399170 
                    let v401316 : US2 =
                        match v401192 with
                        | US9_1(v401195) -> (* Error *)
                            let v401196 : string = $"%A{v401195}"
                            let v401199 : string = "System.TimeoutException"
                            let v401200 : bool = v401196.Contains v401199 
                            if v401200 then
                                let v401203 : unit = ()
                                let v401204 : (unit -> unit) = closure29(v0)
                                let v401205 : unit = (fun () -> v401204 (); v401203) ()
                                US2_1
                            else
                                let v401246 : unit = ()
                                let v401247 : (unit -> unit) = closure30(v0, v401195)
                                let v401248 : unit = (fun () -> v401247 (); v401246) ()
                                US2_1
                        | US9_0(v401193) -> (* Ok *)
                            US2_0(v401193)
                    return v401316 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v402192 : Async<US2> = _v401189 
            let _v399171 = v402192 
            #endif
#else
            let v402193 : unit = ()
            let _v402193 =
                async {
                    let! v399170 = v399170 
                    let v402196 : US9 = v399170 
                    let v402320 : US2 =
                        match v402196 with
                        | US9_1(v402199) -> (* Error *)
                            let v402200 : string = $"%A{v402199}"
                            let v402203 : string = "System.TimeoutException"
                            let v402204 : bool = v402200.Contains v402203 
                            if v402204 then
                                let v402207 : unit = ()
                                let v402208 : (unit -> unit) = closure29(v0)
                                let v402209 : unit = (fun () -> v402208 (); v402207) ()
                                US2_1
                            else
                                let v402250 : unit = ()
                                let v402251 : (unit -> unit) = closure30(v0, v402199)
                                let v402252 : unit = (fun () -> v402251 (); v402250) ()
                                US2_1
                        | US9_0(v402197) -> (* Ok *)
                            US2_0(v402197)
                    return v402320 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v403196 : Async<US2> = _v402193 
            let _v399171 = v403196 
            #endif
            let v403197 : Async<US2> = _v399171 
            return! v403197 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v435448 : Async<US2> = _v399165 
    let _v326587 = v435448 
    #endif
#else
    let v435449 : unit = ()
    let _v435449 =
        async {
            let v435452 : Async<Async<int64>> = method52(v0, v1)
            let! v435452 = v435452 
            let v435453 : Async<int64> = v435452 
            let v435454 : Async<US9> = method53(v435453)
            let v435455 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v435456 : Async<US2> = null |> unbox<Async<US2>>
            let _v435455 = v435456 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v435459 : Async<US2> = null |> unbox<Async<US2>>
            let _v435455 = v435459 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v435462 : Async<US2> = null |> unbox<Async<US2>>
            let _v435455 = v435462 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v435465 : unit = ()
            let _v435465 =
                async {
                    let! v435454 = v435454 
                    let v435468 : US9 = v435454 
                    let v435592 : US2 =
                        match v435468 with
                        | US9_1(v435471) -> (* Error *)
                            let v435472 : string = $"%A{v435471}"
                            let v435475 : string = "System.TimeoutException"
                            let v435476 : bool = v435472.Contains v435475 
                            if v435476 then
                                let v435479 : unit = ()
                                let v435480 : (unit -> unit) = closure29(v0)
                                let v435481 : unit = (fun () -> v435480 (); v435479) ()
                                US2_1
                            else
                                let v435522 : unit = ()
                                let v435523 : (unit -> unit) = closure30(v0, v435471)
                                let v435524 : unit = (fun () -> v435523 (); v435522) ()
                                US2_1
                        | US9_0(v435469) -> (* Ok *)
                            US2_0(v435469)
                    return v435592 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v436468 : Async<US2> = _v435465 
            let _v435455 = v436468 
            #endif
#if FABLE_COMPILER_PYTHON
            let v436469 : unit = ()
            let _v436469 =
                async {
                    let! v435454 = v435454 
                    let v436472 : US9 = v435454 
                    let v436596 : US2 =
                        match v436472 with
                        | US9_1(v436475) -> (* Error *)
                            let v436476 : string = $"%A{v436475}"
                            let v436479 : string = "System.TimeoutException"
                            let v436480 : bool = v436476.Contains v436479 
                            if v436480 then
                                let v436483 : unit = ()
                                let v436484 : (unit -> unit) = closure29(v0)
                                let v436485 : unit = (fun () -> v436484 (); v436483) ()
                                US2_1
                            else
                                let v436526 : unit = ()
                                let v436527 : (unit -> unit) = closure30(v0, v436475)
                                let v436528 : unit = (fun () -> v436527 (); v436526) ()
                                US2_1
                        | US9_0(v436473) -> (* Ok *)
                            US2_0(v436473)
                    return v436596 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v437472 : Async<US2> = _v436469 
            let _v435455 = v437472 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v437473 : unit = ()
            let _v437473 =
                async {
                    let! v435454 = v435454 
                    let v437476 : US9 = v435454 
                    let v437600 : US2 =
                        match v437476 with
                        | US9_1(v437479) -> (* Error *)
                            let v437480 : string = $"%A{v437479}"
                            let v437483 : string = "System.TimeoutException"
                            let v437484 : bool = v437480.Contains v437483 
                            if v437484 then
                                let v437487 : unit = ()
                                let v437488 : (unit -> unit) = closure29(v0)
                                let v437489 : unit = (fun () -> v437488 (); v437487) ()
                                US2_1
                            else
                                let v437530 : unit = ()
                                let v437531 : (unit -> unit) = closure30(v0, v437479)
                                let v437532 : unit = (fun () -> v437531 (); v437530) ()
                                US2_1
                        | US9_0(v437477) -> (* Ok *)
                            US2_0(v437477)
                    return v437600 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v438476 : Async<US2> = _v437473 
            let _v435455 = v438476 
            #endif
#else
            let v438477 : unit = ()
            let _v438477 =
                async {
                    let! v435454 = v435454 
                    let v438480 : US9 = v435454 
                    let v438604 : US2 =
                        match v438480 with
                        | US9_1(v438483) -> (* Error *)
                            let v438484 : string = $"%A{v438483}"
                            let v438487 : string = "System.TimeoutException"
                            let v438488 : bool = v438484.Contains v438487 
                            if v438488 then
                                let v438491 : unit = ()
                                let v438492 : (unit -> unit) = closure29(v0)
                                let v438493 : unit = (fun () -> v438492 (); v438491) ()
                                US2_1
                            else
                                let v438534 : unit = ()
                                let v438535 : (unit -> unit) = closure30(v0, v438483)
                                let v438536 : unit = (fun () -> v438535 (); v438534) ()
                                US2_1
                        | US9_0(v438481) -> (* Ok *)
                            US2_0(v438481)
                    return v438604 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v439480 : Async<US2> = _v438477 
            let _v435455 = v439480 
            #endif
            let v439481 : Async<US2> = _v435455 
            return! v439481 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v471732 : Async<US2> = _v435449 
    let _v326587 = v471732 
    #endif
    let v471733 : Async<US2> = _v326587 
    let _v2 = v471733 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v489879 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v489880 : Async<US2> = null |> unbox<Async<US2>>
    let _v489879 = v489880 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v489883 : Async<US2> = null |> unbox<Async<US2>>
    let _v489879 = v489883 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v489886 : Async<US2> = null |> unbox<Async<US2>>
    let _v489879 = v489886 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v489889 : unit = ()
    let _v489889 =
        async {
            let v489892 : Async<Async<int64>> = method52(v0, v1)
            let! v489892 = v489892 
            let v489893 : Async<int64> = v489892 
            let v489894 : Async<US9> = method53(v489893)
            let v489895 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v489896 : Async<US2> = null |> unbox<Async<US2>>
            let _v489895 = v489896 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v489899 : Async<US2> = null |> unbox<Async<US2>>
            let _v489895 = v489899 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v489902 : Async<US2> = null |> unbox<Async<US2>>
            let _v489895 = v489902 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v489905 : unit = ()
            let _v489905 =
                async {
                    let! v489894 = v489894 
                    let v489908 : US9 = v489894 
                    let v490032 : US2 =
                        match v489908 with
                        | US9_1(v489911) -> (* Error *)
                            let v489912 : string = $"%A{v489911}"
                            let v489915 : string = "System.TimeoutException"
                            let v489916 : bool = v489912.Contains v489915 
                            if v489916 then
                                let v489919 : unit = ()
                                let v489920 : (unit -> unit) = closure29(v0)
                                let v489921 : unit = (fun () -> v489920 (); v489919) ()
                                US2_1
                            else
                                let v489962 : unit = ()
                                let v489963 : (unit -> unit) = closure30(v0, v489911)
                                let v489964 : unit = (fun () -> v489963 (); v489962) ()
                                US2_1
                        | US9_0(v489909) -> (* Ok *)
                            US2_0(v489909)
                    return v490032 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v490908 : Async<US2> = _v489905 
            let _v489895 = v490908 
            #endif
#if FABLE_COMPILER_PYTHON
            let v490909 : unit = ()
            let _v490909 =
                async {
                    let! v489894 = v489894 
                    let v490912 : US9 = v489894 
                    let v491036 : US2 =
                        match v490912 with
                        | US9_1(v490915) -> (* Error *)
                            let v490916 : string = $"%A{v490915}"
                            let v490919 : string = "System.TimeoutException"
                            let v490920 : bool = v490916.Contains v490919 
                            if v490920 then
                                let v490923 : unit = ()
                                let v490924 : (unit -> unit) = closure29(v0)
                                let v490925 : unit = (fun () -> v490924 (); v490923) ()
                                US2_1
                            else
                                let v490966 : unit = ()
                                let v490967 : (unit -> unit) = closure30(v0, v490915)
                                let v490968 : unit = (fun () -> v490967 (); v490966) ()
                                US2_1
                        | US9_0(v490913) -> (* Ok *)
                            US2_0(v490913)
                    return v491036 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v491912 : Async<US2> = _v490909 
            let _v489895 = v491912 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v491913 : unit = ()
            let _v491913 =
                async {
                    let! v489894 = v489894 
                    let v491916 : US9 = v489894 
                    let v492040 : US2 =
                        match v491916 with
                        | US9_1(v491919) -> (* Error *)
                            let v491920 : string = $"%A{v491919}"
                            let v491923 : string = "System.TimeoutException"
                            let v491924 : bool = v491920.Contains v491923 
                            if v491924 then
                                let v491927 : unit = ()
                                let v491928 : (unit -> unit) = closure29(v0)
                                let v491929 : unit = (fun () -> v491928 (); v491927) ()
                                US2_1
                            else
                                let v491970 : unit = ()
                                let v491971 : (unit -> unit) = closure30(v0, v491919)
                                let v491972 : unit = (fun () -> v491971 (); v491970) ()
                                US2_1
                        | US9_0(v491917) -> (* Ok *)
                            US2_0(v491917)
                    return v492040 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v492916 : Async<US2> = _v491913 
            let _v489895 = v492916 
            #endif
#else
            let v492917 : unit = ()
            let _v492917 =
                async {
                    let! v489894 = v489894 
                    let v492920 : US9 = v489894 
                    let v493044 : US2 =
                        match v492920 with
                        | US9_1(v492923) -> (* Error *)
                            let v492924 : string = $"%A{v492923}"
                            let v492927 : string = "System.TimeoutException"
                            let v492928 : bool = v492924.Contains v492927 
                            if v492928 then
                                let v492931 : unit = ()
                                let v492932 : (unit -> unit) = closure29(v0)
                                let v492933 : unit = (fun () -> v492932 (); v492931) ()
                                US2_1
                            else
                                let v492974 : unit = ()
                                let v492975 : (unit -> unit) = closure30(v0, v492923)
                                let v492976 : unit = (fun () -> v492975 (); v492974) ()
                                US2_1
                        | US9_0(v492921) -> (* Ok *)
                            US2_0(v492921)
                    return v493044 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v493920 : Async<US2> = _v492917 
            let _v489895 = v493920 
            #endif
            let v493921 : Async<US2> = _v489895 
            return! v493921 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v526172 : Async<US2> = _v489889 
    let _v489879 = v526172 
    #endif
#if FABLE_COMPILER_PYTHON
    let v526173 : unit = ()
    let _v526173 =
        async {
            let v526176 : Async<Async<int64>> = method52(v0, v1)
            let! v526176 = v526176 
            let v526177 : Async<int64> = v526176 
            let v526178 : Async<US9> = method53(v526177)
            let v526179 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v526180 : Async<US2> = null |> unbox<Async<US2>>
            let _v526179 = v526180 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v526183 : Async<US2> = null |> unbox<Async<US2>>
            let _v526179 = v526183 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v526186 : Async<US2> = null |> unbox<Async<US2>>
            let _v526179 = v526186 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v526189 : unit = ()
            let _v526189 =
                async {
                    let! v526178 = v526178 
                    let v526192 : US9 = v526178 
                    let v526316 : US2 =
                        match v526192 with
                        | US9_1(v526195) -> (* Error *)
                            let v526196 : string = $"%A{v526195}"
                            let v526199 : string = "System.TimeoutException"
                            let v526200 : bool = v526196.Contains v526199 
                            if v526200 then
                                let v526203 : unit = ()
                                let v526204 : (unit -> unit) = closure29(v0)
                                let v526205 : unit = (fun () -> v526204 (); v526203) ()
                                US2_1
                            else
                                let v526246 : unit = ()
                                let v526247 : (unit -> unit) = closure30(v0, v526195)
                                let v526248 : unit = (fun () -> v526247 (); v526246) ()
                                US2_1
                        | US9_0(v526193) -> (* Ok *)
                            US2_0(v526193)
                    return v526316 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v527192 : Async<US2> = _v526189 
            let _v526179 = v527192 
            #endif
#if FABLE_COMPILER_PYTHON
            let v527193 : unit = ()
            let _v527193 =
                async {
                    let! v526178 = v526178 
                    let v527196 : US9 = v526178 
                    let v527320 : US2 =
                        match v527196 with
                        | US9_1(v527199) -> (* Error *)
                            let v527200 : string = $"%A{v527199}"
                            let v527203 : string = "System.TimeoutException"
                            let v527204 : bool = v527200.Contains v527203 
                            if v527204 then
                                let v527207 : unit = ()
                                let v527208 : (unit -> unit) = closure29(v0)
                                let v527209 : unit = (fun () -> v527208 (); v527207) ()
                                US2_1
                            else
                                let v527250 : unit = ()
                                let v527251 : (unit -> unit) = closure30(v0, v527199)
                                let v527252 : unit = (fun () -> v527251 (); v527250) ()
                                US2_1
                        | US9_0(v527197) -> (* Ok *)
                            US2_0(v527197)
                    return v527320 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v528196 : Async<US2> = _v527193 
            let _v526179 = v528196 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v528197 : unit = ()
            let _v528197 =
                async {
                    let! v526178 = v526178 
                    let v528200 : US9 = v526178 
                    let v528324 : US2 =
                        match v528200 with
                        | US9_1(v528203) -> (* Error *)
                            let v528204 : string = $"%A{v528203}"
                            let v528207 : string = "System.TimeoutException"
                            let v528208 : bool = v528204.Contains v528207 
                            if v528208 then
                                let v528211 : unit = ()
                                let v528212 : (unit -> unit) = closure29(v0)
                                let v528213 : unit = (fun () -> v528212 (); v528211) ()
                                US2_1
                            else
                                let v528254 : unit = ()
                                let v528255 : (unit -> unit) = closure30(v0, v528203)
                                let v528256 : unit = (fun () -> v528255 (); v528254) ()
                                US2_1
                        | US9_0(v528201) -> (* Ok *)
                            US2_0(v528201)
                    return v528324 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v529200 : Async<US2> = _v528197 
            let _v526179 = v529200 
            #endif
#else
            let v529201 : unit = ()
            let _v529201 =
                async {
                    let! v526178 = v526178 
                    let v529204 : US9 = v526178 
                    let v529328 : US2 =
                        match v529204 with
                        | US9_1(v529207) -> (* Error *)
                            let v529208 : string = $"%A{v529207}"
                            let v529211 : string = "System.TimeoutException"
                            let v529212 : bool = v529208.Contains v529211 
                            if v529212 then
                                let v529215 : unit = ()
                                let v529216 : (unit -> unit) = closure29(v0)
                                let v529217 : unit = (fun () -> v529216 (); v529215) ()
                                US2_1
                            else
                                let v529258 : unit = ()
                                let v529259 : (unit -> unit) = closure30(v0, v529207)
                                let v529260 : unit = (fun () -> v529259 (); v529258) ()
                                US2_1
                        | US9_0(v529205) -> (* Ok *)
                            US2_0(v529205)
                    return v529328 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v530204 : Async<US2> = _v529201 
            let _v526179 = v530204 
            #endif
            let v530205 : Async<US2> = _v526179 
            return! v530205 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v562456 : Async<US2> = _v526173 
    let _v489879 = v562456 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v562457 : unit = ()
    let _v562457 =
        async {
            let v562460 : Async<Async<int64>> = method52(v0, v1)
            let! v562460 = v562460 
            let v562461 : Async<int64> = v562460 
            let v562462 : Async<US9> = method53(v562461)
            let v562463 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v562464 : Async<US2> = null |> unbox<Async<US2>>
            let _v562463 = v562464 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v562467 : Async<US2> = null |> unbox<Async<US2>>
            let _v562463 = v562467 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v562470 : Async<US2> = null |> unbox<Async<US2>>
            let _v562463 = v562470 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v562473 : unit = ()
            let _v562473 =
                async {
                    let! v562462 = v562462 
                    let v562476 : US9 = v562462 
                    let v562600 : US2 =
                        match v562476 with
                        | US9_1(v562479) -> (* Error *)
                            let v562480 : string = $"%A{v562479}"
                            let v562483 : string = "System.TimeoutException"
                            let v562484 : bool = v562480.Contains v562483 
                            if v562484 then
                                let v562487 : unit = ()
                                let v562488 : (unit -> unit) = closure29(v0)
                                let v562489 : unit = (fun () -> v562488 (); v562487) ()
                                US2_1
                            else
                                let v562530 : unit = ()
                                let v562531 : (unit -> unit) = closure30(v0, v562479)
                                let v562532 : unit = (fun () -> v562531 (); v562530) ()
                                US2_1
                        | US9_0(v562477) -> (* Ok *)
                            US2_0(v562477)
                    return v562600 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v563476 : Async<US2> = _v562473 
            let _v562463 = v563476 
            #endif
#if FABLE_COMPILER_PYTHON
            let v563477 : unit = ()
            let _v563477 =
                async {
                    let! v562462 = v562462 
                    let v563480 : US9 = v562462 
                    let v563604 : US2 =
                        match v563480 with
                        | US9_1(v563483) -> (* Error *)
                            let v563484 : string = $"%A{v563483}"
                            let v563487 : string = "System.TimeoutException"
                            let v563488 : bool = v563484.Contains v563487 
                            if v563488 then
                                let v563491 : unit = ()
                                let v563492 : (unit -> unit) = closure29(v0)
                                let v563493 : unit = (fun () -> v563492 (); v563491) ()
                                US2_1
                            else
                                let v563534 : unit = ()
                                let v563535 : (unit -> unit) = closure30(v0, v563483)
                                let v563536 : unit = (fun () -> v563535 (); v563534) ()
                                US2_1
                        | US9_0(v563481) -> (* Ok *)
                            US2_0(v563481)
                    return v563604 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v564480 : Async<US2> = _v563477 
            let _v562463 = v564480 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v564481 : unit = ()
            let _v564481 =
                async {
                    let! v562462 = v562462 
                    let v564484 : US9 = v562462 
                    let v564608 : US2 =
                        match v564484 with
                        | US9_1(v564487) -> (* Error *)
                            let v564488 : string = $"%A{v564487}"
                            let v564491 : string = "System.TimeoutException"
                            let v564492 : bool = v564488.Contains v564491 
                            if v564492 then
                                let v564495 : unit = ()
                                let v564496 : (unit -> unit) = closure29(v0)
                                let v564497 : unit = (fun () -> v564496 (); v564495) ()
                                US2_1
                            else
                                let v564538 : unit = ()
                                let v564539 : (unit -> unit) = closure30(v0, v564487)
                                let v564540 : unit = (fun () -> v564539 (); v564538) ()
                                US2_1
                        | US9_0(v564485) -> (* Ok *)
                            US2_0(v564485)
                    return v564608 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v565484 : Async<US2> = _v564481 
            let _v562463 = v565484 
            #endif
#else
            let v565485 : unit = ()
            let _v565485 =
                async {
                    let! v562462 = v562462 
                    let v565488 : US9 = v562462 
                    let v565612 : US2 =
                        match v565488 with
                        | US9_1(v565491) -> (* Error *)
                            let v565492 : string = $"%A{v565491}"
                            let v565495 : string = "System.TimeoutException"
                            let v565496 : bool = v565492.Contains v565495 
                            if v565496 then
                                let v565499 : unit = ()
                                let v565500 : (unit -> unit) = closure29(v0)
                                let v565501 : unit = (fun () -> v565500 (); v565499) ()
                                US2_1
                            else
                                let v565542 : unit = ()
                                let v565543 : (unit -> unit) = closure30(v0, v565491)
                                let v565544 : unit = (fun () -> v565543 (); v565542) ()
                                US2_1
                        | US9_0(v565489) -> (* Ok *)
                            US2_0(v565489)
                    return v565612 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v566488 : Async<US2> = _v565485 
            let _v562463 = v566488 
            #endif
            let v566489 : Async<US2> = _v562463 
            return! v566489 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v598740 : Async<US2> = _v562457 
    let _v489879 = v598740 
    #endif
#else
    let v598741 : unit = ()
    let _v598741 =
        async {
            let v598744 : Async<Async<int64>> = method52(v0, v1)
            let! v598744 = v598744 
            let v598745 : Async<int64> = v598744 
            let v598746 : Async<US9> = method53(v598745)
            let v598747 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v598748 : Async<US2> = null |> unbox<Async<US2>>
            let _v598747 = v598748 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v598751 : Async<US2> = null |> unbox<Async<US2>>
            let _v598747 = v598751 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v598754 : Async<US2> = null |> unbox<Async<US2>>
            let _v598747 = v598754 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v598757 : unit = ()
            let _v598757 =
                async {
                    let! v598746 = v598746 
                    let v598760 : US9 = v598746 
                    let v598884 : US2 =
                        match v598760 with
                        | US9_1(v598763) -> (* Error *)
                            let v598764 : string = $"%A{v598763}"
                            let v598767 : string = "System.TimeoutException"
                            let v598768 : bool = v598764.Contains v598767 
                            if v598768 then
                                let v598771 : unit = ()
                                let v598772 : (unit -> unit) = closure29(v0)
                                let v598773 : unit = (fun () -> v598772 (); v598771) ()
                                US2_1
                            else
                                let v598814 : unit = ()
                                let v598815 : (unit -> unit) = closure30(v0, v598763)
                                let v598816 : unit = (fun () -> v598815 (); v598814) ()
                                US2_1
                        | US9_0(v598761) -> (* Ok *)
                            US2_0(v598761)
                    return v598884 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v599760 : Async<US2> = _v598757 
            let _v598747 = v599760 
            #endif
#if FABLE_COMPILER_PYTHON
            let v599761 : unit = ()
            let _v599761 =
                async {
                    let! v598746 = v598746 
                    let v599764 : US9 = v598746 
                    let v599888 : US2 =
                        match v599764 with
                        | US9_1(v599767) -> (* Error *)
                            let v599768 : string = $"%A{v599767}"
                            let v599771 : string = "System.TimeoutException"
                            let v599772 : bool = v599768.Contains v599771 
                            if v599772 then
                                let v599775 : unit = ()
                                let v599776 : (unit -> unit) = closure29(v0)
                                let v599777 : unit = (fun () -> v599776 (); v599775) ()
                                US2_1
                            else
                                let v599818 : unit = ()
                                let v599819 : (unit -> unit) = closure30(v0, v599767)
                                let v599820 : unit = (fun () -> v599819 (); v599818) ()
                                US2_1
                        | US9_0(v599765) -> (* Ok *)
                            US2_0(v599765)
                    return v599888 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v600764 : Async<US2> = _v599761 
            let _v598747 = v600764 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v600765 : unit = ()
            let _v600765 =
                async {
                    let! v598746 = v598746 
                    let v600768 : US9 = v598746 
                    let v600892 : US2 =
                        match v600768 with
                        | US9_1(v600771) -> (* Error *)
                            let v600772 : string = $"%A{v600771}"
                            let v600775 : string = "System.TimeoutException"
                            let v600776 : bool = v600772.Contains v600775 
                            if v600776 then
                                let v600779 : unit = ()
                                let v600780 : (unit -> unit) = closure29(v0)
                                let v600781 : unit = (fun () -> v600780 (); v600779) ()
                                US2_1
                            else
                                let v600822 : unit = ()
                                let v600823 : (unit -> unit) = closure30(v0, v600771)
                                let v600824 : unit = (fun () -> v600823 (); v600822) ()
                                US2_1
                        | US9_0(v600769) -> (* Ok *)
                            US2_0(v600769)
                    return v600892 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v601768 : Async<US2> = _v600765 
            let _v598747 = v601768 
            #endif
#else
            let v601769 : unit = ()
            let _v601769 =
                async {
                    let! v598746 = v598746 
                    let v601772 : US9 = v598746 
                    let v601896 : US2 =
                        match v601772 with
                        | US9_1(v601775) -> (* Error *)
                            let v601776 : string = $"%A{v601775}"
                            let v601779 : string = "System.TimeoutException"
                            let v601780 : bool = v601776.Contains v601779 
                            if v601780 then
                                let v601783 : unit = ()
                                let v601784 : (unit -> unit) = closure29(v0)
                                let v601785 : unit = (fun () -> v601784 (); v601783) ()
                                US2_1
                            else
                                let v601826 : unit = ()
                                let v601827 : (unit -> unit) = closure30(v0, v601775)
                                let v601828 : unit = (fun () -> v601827 (); v601826) ()
                                US2_1
                        | US9_0(v601773) -> (* Ok *)
                            US2_0(v601773)
                    return v601896 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v602772 : Async<US2> = _v601769 
            let _v598747 = v602772 
            #endif
            let v602773 : Async<US2> = _v598747 
            return! v602773 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v635024 : Async<US2> = _v598741 
    let _v489879 = v635024 
    #endif
    let v635025 : Async<US2> = _v489879 
    let _v2 = v635025 
    #endif
#if FABLE_COMPILER_PYTHON
    let v653171 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v653172 : Async<US2> = null |> unbox<Async<US2>>
    let _v653171 = v653172 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v653175 : Async<US2> = null |> unbox<Async<US2>>
    let _v653171 = v653175 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v653178 : Async<US2> = null |> unbox<Async<US2>>
    let _v653171 = v653178 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v653181 : unit = ()
    let _v653181 =
        async {
            let v653184 : Async<Async<int64>> = method52(v0, v1)
            let! v653184 = v653184 
            let v653185 : Async<int64> = v653184 
            let v653186 : Async<US9> = method53(v653185)
            let v653187 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v653188 : Async<US2> = null |> unbox<Async<US2>>
            let _v653187 = v653188 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v653191 : Async<US2> = null |> unbox<Async<US2>>
            let _v653187 = v653191 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v653194 : Async<US2> = null |> unbox<Async<US2>>
            let _v653187 = v653194 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v653197 : unit = ()
            let _v653197 =
                async {
                    let! v653186 = v653186 
                    let v653200 : US9 = v653186 
                    let v653324 : US2 =
                        match v653200 with
                        | US9_1(v653203) -> (* Error *)
                            let v653204 : string = $"%A{v653203}"
                            let v653207 : string = "System.TimeoutException"
                            let v653208 : bool = v653204.Contains v653207 
                            if v653208 then
                                let v653211 : unit = ()
                                let v653212 : (unit -> unit) = closure29(v0)
                                let v653213 : unit = (fun () -> v653212 (); v653211) ()
                                US2_1
                            else
                                let v653254 : unit = ()
                                let v653255 : (unit -> unit) = closure30(v0, v653203)
                                let v653256 : unit = (fun () -> v653255 (); v653254) ()
                                US2_1
                        | US9_0(v653201) -> (* Ok *)
                            US2_0(v653201)
                    return v653324 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v654200 : Async<US2> = _v653197 
            let _v653187 = v654200 
            #endif
#if FABLE_COMPILER_PYTHON
            let v654201 : unit = ()
            let _v654201 =
                async {
                    let! v653186 = v653186 
                    let v654204 : US9 = v653186 
                    let v654328 : US2 =
                        match v654204 with
                        | US9_1(v654207) -> (* Error *)
                            let v654208 : string = $"%A{v654207}"
                            let v654211 : string = "System.TimeoutException"
                            let v654212 : bool = v654208.Contains v654211 
                            if v654212 then
                                let v654215 : unit = ()
                                let v654216 : (unit -> unit) = closure29(v0)
                                let v654217 : unit = (fun () -> v654216 (); v654215) ()
                                US2_1
                            else
                                let v654258 : unit = ()
                                let v654259 : (unit -> unit) = closure30(v0, v654207)
                                let v654260 : unit = (fun () -> v654259 (); v654258) ()
                                US2_1
                        | US9_0(v654205) -> (* Ok *)
                            US2_0(v654205)
                    return v654328 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v655204 : Async<US2> = _v654201 
            let _v653187 = v655204 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v655205 : unit = ()
            let _v655205 =
                async {
                    let! v653186 = v653186 
                    let v655208 : US9 = v653186 
                    let v655332 : US2 =
                        match v655208 with
                        | US9_1(v655211) -> (* Error *)
                            let v655212 : string = $"%A{v655211}"
                            let v655215 : string = "System.TimeoutException"
                            let v655216 : bool = v655212.Contains v655215 
                            if v655216 then
                                let v655219 : unit = ()
                                let v655220 : (unit -> unit) = closure29(v0)
                                let v655221 : unit = (fun () -> v655220 (); v655219) ()
                                US2_1
                            else
                                let v655262 : unit = ()
                                let v655263 : (unit -> unit) = closure30(v0, v655211)
                                let v655264 : unit = (fun () -> v655263 (); v655262) ()
                                US2_1
                        | US9_0(v655209) -> (* Ok *)
                            US2_0(v655209)
                    return v655332 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v656208 : Async<US2> = _v655205 
            let _v653187 = v656208 
            #endif
#else
            let v656209 : unit = ()
            let _v656209 =
                async {
                    let! v653186 = v653186 
                    let v656212 : US9 = v653186 
                    let v656336 : US2 =
                        match v656212 with
                        | US9_1(v656215) -> (* Error *)
                            let v656216 : string = $"%A{v656215}"
                            let v656219 : string = "System.TimeoutException"
                            let v656220 : bool = v656216.Contains v656219 
                            if v656220 then
                                let v656223 : unit = ()
                                let v656224 : (unit -> unit) = closure29(v0)
                                let v656225 : unit = (fun () -> v656224 (); v656223) ()
                                US2_1
                            else
                                let v656266 : unit = ()
                                let v656267 : (unit -> unit) = closure30(v0, v656215)
                                let v656268 : unit = (fun () -> v656267 (); v656266) ()
                                US2_1
                        | US9_0(v656213) -> (* Ok *)
                            US2_0(v656213)
                    return v656336 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v657212 : Async<US2> = _v656209 
            let _v653187 = v657212 
            #endif
            let v657213 : Async<US2> = _v653187 
            return! v657213 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v689464 : Async<US2> = _v653181 
    let _v653171 = v689464 
    #endif
#if FABLE_COMPILER_PYTHON
    let v689465 : unit = ()
    let _v689465 =
        async {
            let v689468 : Async<Async<int64>> = method52(v0, v1)
            let! v689468 = v689468 
            let v689469 : Async<int64> = v689468 
            let v689470 : Async<US9> = method53(v689469)
            let v689471 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v689472 : Async<US2> = null |> unbox<Async<US2>>
            let _v689471 = v689472 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v689475 : Async<US2> = null |> unbox<Async<US2>>
            let _v689471 = v689475 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v689478 : Async<US2> = null |> unbox<Async<US2>>
            let _v689471 = v689478 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v689481 : unit = ()
            let _v689481 =
                async {
                    let! v689470 = v689470 
                    let v689484 : US9 = v689470 
                    let v689608 : US2 =
                        match v689484 with
                        | US9_1(v689487) -> (* Error *)
                            let v689488 : string = $"%A{v689487}"
                            let v689491 : string = "System.TimeoutException"
                            let v689492 : bool = v689488.Contains v689491 
                            if v689492 then
                                let v689495 : unit = ()
                                let v689496 : (unit -> unit) = closure29(v0)
                                let v689497 : unit = (fun () -> v689496 (); v689495) ()
                                US2_1
                            else
                                let v689538 : unit = ()
                                let v689539 : (unit -> unit) = closure30(v0, v689487)
                                let v689540 : unit = (fun () -> v689539 (); v689538) ()
                                US2_1
                        | US9_0(v689485) -> (* Ok *)
                            US2_0(v689485)
                    return v689608 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v690484 : Async<US2> = _v689481 
            let _v689471 = v690484 
            #endif
#if FABLE_COMPILER_PYTHON
            let v690485 : unit = ()
            let _v690485 =
                async {
                    let! v689470 = v689470 
                    let v690488 : US9 = v689470 
                    let v690612 : US2 =
                        match v690488 with
                        | US9_1(v690491) -> (* Error *)
                            let v690492 : string = $"%A{v690491}"
                            let v690495 : string = "System.TimeoutException"
                            let v690496 : bool = v690492.Contains v690495 
                            if v690496 then
                                let v690499 : unit = ()
                                let v690500 : (unit -> unit) = closure29(v0)
                                let v690501 : unit = (fun () -> v690500 (); v690499) ()
                                US2_1
                            else
                                let v690542 : unit = ()
                                let v690543 : (unit -> unit) = closure30(v0, v690491)
                                let v690544 : unit = (fun () -> v690543 (); v690542) ()
                                US2_1
                        | US9_0(v690489) -> (* Ok *)
                            US2_0(v690489)
                    return v690612 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v691488 : Async<US2> = _v690485 
            let _v689471 = v691488 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v691489 : unit = ()
            let _v691489 =
                async {
                    let! v689470 = v689470 
                    let v691492 : US9 = v689470 
                    let v691616 : US2 =
                        match v691492 with
                        | US9_1(v691495) -> (* Error *)
                            let v691496 : string = $"%A{v691495}"
                            let v691499 : string = "System.TimeoutException"
                            let v691500 : bool = v691496.Contains v691499 
                            if v691500 then
                                let v691503 : unit = ()
                                let v691504 : (unit -> unit) = closure29(v0)
                                let v691505 : unit = (fun () -> v691504 (); v691503) ()
                                US2_1
                            else
                                let v691546 : unit = ()
                                let v691547 : (unit -> unit) = closure30(v0, v691495)
                                let v691548 : unit = (fun () -> v691547 (); v691546) ()
                                US2_1
                        | US9_0(v691493) -> (* Ok *)
                            US2_0(v691493)
                    return v691616 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v692492 : Async<US2> = _v691489 
            let _v689471 = v692492 
            #endif
#else
            let v692493 : unit = ()
            let _v692493 =
                async {
                    let! v689470 = v689470 
                    let v692496 : US9 = v689470 
                    let v692620 : US2 =
                        match v692496 with
                        | US9_1(v692499) -> (* Error *)
                            let v692500 : string = $"%A{v692499}"
                            let v692503 : string = "System.TimeoutException"
                            let v692504 : bool = v692500.Contains v692503 
                            if v692504 then
                                let v692507 : unit = ()
                                let v692508 : (unit -> unit) = closure29(v0)
                                let v692509 : unit = (fun () -> v692508 (); v692507) ()
                                US2_1
                            else
                                let v692550 : unit = ()
                                let v692551 : (unit -> unit) = closure30(v0, v692499)
                                let v692552 : unit = (fun () -> v692551 (); v692550) ()
                                US2_1
                        | US9_0(v692497) -> (* Ok *)
                            US2_0(v692497)
                    return v692620 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v693496 : Async<US2> = _v692493 
            let _v689471 = v693496 
            #endif
            let v693497 : Async<US2> = _v689471 
            return! v693497 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v725748 : Async<US2> = _v689465 
    let _v653171 = v725748 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v725749 : unit = ()
    let _v725749 =
        async {
            let v725752 : Async<Async<int64>> = method52(v0, v1)
            let! v725752 = v725752 
            let v725753 : Async<int64> = v725752 
            let v725754 : Async<US9> = method53(v725753)
            let v725755 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v725756 : Async<US2> = null |> unbox<Async<US2>>
            let _v725755 = v725756 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v725759 : Async<US2> = null |> unbox<Async<US2>>
            let _v725755 = v725759 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v725762 : Async<US2> = null |> unbox<Async<US2>>
            let _v725755 = v725762 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v725765 : unit = ()
            let _v725765 =
                async {
                    let! v725754 = v725754 
                    let v725768 : US9 = v725754 
                    let v725892 : US2 =
                        match v725768 with
                        | US9_1(v725771) -> (* Error *)
                            let v725772 : string = $"%A{v725771}"
                            let v725775 : string = "System.TimeoutException"
                            let v725776 : bool = v725772.Contains v725775 
                            if v725776 then
                                let v725779 : unit = ()
                                let v725780 : (unit -> unit) = closure29(v0)
                                let v725781 : unit = (fun () -> v725780 (); v725779) ()
                                US2_1
                            else
                                let v725822 : unit = ()
                                let v725823 : (unit -> unit) = closure30(v0, v725771)
                                let v725824 : unit = (fun () -> v725823 (); v725822) ()
                                US2_1
                        | US9_0(v725769) -> (* Ok *)
                            US2_0(v725769)
                    return v725892 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v726768 : Async<US2> = _v725765 
            let _v725755 = v726768 
            #endif
#if FABLE_COMPILER_PYTHON
            let v726769 : unit = ()
            let _v726769 =
                async {
                    let! v725754 = v725754 
                    let v726772 : US9 = v725754 
                    let v726896 : US2 =
                        match v726772 with
                        | US9_1(v726775) -> (* Error *)
                            let v726776 : string = $"%A{v726775}"
                            let v726779 : string = "System.TimeoutException"
                            let v726780 : bool = v726776.Contains v726779 
                            if v726780 then
                                let v726783 : unit = ()
                                let v726784 : (unit -> unit) = closure29(v0)
                                let v726785 : unit = (fun () -> v726784 (); v726783) ()
                                US2_1
                            else
                                let v726826 : unit = ()
                                let v726827 : (unit -> unit) = closure30(v0, v726775)
                                let v726828 : unit = (fun () -> v726827 (); v726826) ()
                                US2_1
                        | US9_0(v726773) -> (* Ok *)
                            US2_0(v726773)
                    return v726896 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v727772 : Async<US2> = _v726769 
            let _v725755 = v727772 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v727773 : unit = ()
            let _v727773 =
                async {
                    let! v725754 = v725754 
                    let v727776 : US9 = v725754 
                    let v727900 : US2 =
                        match v727776 with
                        | US9_1(v727779) -> (* Error *)
                            let v727780 : string = $"%A{v727779}"
                            let v727783 : string = "System.TimeoutException"
                            let v727784 : bool = v727780.Contains v727783 
                            if v727784 then
                                let v727787 : unit = ()
                                let v727788 : (unit -> unit) = closure29(v0)
                                let v727789 : unit = (fun () -> v727788 (); v727787) ()
                                US2_1
                            else
                                let v727830 : unit = ()
                                let v727831 : (unit -> unit) = closure30(v0, v727779)
                                let v727832 : unit = (fun () -> v727831 (); v727830) ()
                                US2_1
                        | US9_0(v727777) -> (* Ok *)
                            US2_0(v727777)
                    return v727900 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v728776 : Async<US2> = _v727773 
            let _v725755 = v728776 
            #endif
#else
            let v728777 : unit = ()
            let _v728777 =
                async {
                    let! v725754 = v725754 
                    let v728780 : US9 = v725754 
                    let v728904 : US2 =
                        match v728780 with
                        | US9_1(v728783) -> (* Error *)
                            let v728784 : string = $"%A{v728783}"
                            let v728787 : string = "System.TimeoutException"
                            let v728788 : bool = v728784.Contains v728787 
                            if v728788 then
                                let v728791 : unit = ()
                                let v728792 : (unit -> unit) = closure29(v0)
                                let v728793 : unit = (fun () -> v728792 (); v728791) ()
                                US2_1
                            else
                                let v728834 : unit = ()
                                let v728835 : (unit -> unit) = closure30(v0, v728783)
                                let v728836 : unit = (fun () -> v728835 (); v728834) ()
                                US2_1
                        | US9_0(v728781) -> (* Ok *)
                            US2_0(v728781)
                    return v728904 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v729780 : Async<US2> = _v728777 
            let _v725755 = v729780 
            #endif
            let v729781 : Async<US2> = _v725755 
            return! v729781 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v762032 : Async<US2> = _v725749 
    let _v653171 = v762032 
    #endif
#else
    let v762033 : unit = ()
    let _v762033 =
        async {
            let v762036 : Async<Async<int64>> = method52(v0, v1)
            let! v762036 = v762036 
            let v762037 : Async<int64> = v762036 
            let v762038 : Async<US9> = method53(v762037)
            let v762039 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v762040 : Async<US2> = null |> unbox<Async<US2>>
            let _v762039 = v762040 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v762043 : Async<US2> = null |> unbox<Async<US2>>
            let _v762039 = v762043 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v762046 : Async<US2> = null |> unbox<Async<US2>>
            let _v762039 = v762046 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v762049 : unit = ()
            let _v762049 =
                async {
                    let! v762038 = v762038 
                    let v762052 : US9 = v762038 
                    let v762176 : US2 =
                        match v762052 with
                        | US9_1(v762055) -> (* Error *)
                            let v762056 : string = $"%A{v762055}"
                            let v762059 : string = "System.TimeoutException"
                            let v762060 : bool = v762056.Contains v762059 
                            if v762060 then
                                let v762063 : unit = ()
                                let v762064 : (unit -> unit) = closure29(v0)
                                let v762065 : unit = (fun () -> v762064 (); v762063) ()
                                US2_1
                            else
                                let v762106 : unit = ()
                                let v762107 : (unit -> unit) = closure30(v0, v762055)
                                let v762108 : unit = (fun () -> v762107 (); v762106) ()
                                US2_1
                        | US9_0(v762053) -> (* Ok *)
                            US2_0(v762053)
                    return v762176 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v763052 : Async<US2> = _v762049 
            let _v762039 = v763052 
            #endif
#if FABLE_COMPILER_PYTHON
            let v763053 : unit = ()
            let _v763053 =
                async {
                    let! v762038 = v762038 
                    let v763056 : US9 = v762038 
                    let v763180 : US2 =
                        match v763056 with
                        | US9_1(v763059) -> (* Error *)
                            let v763060 : string = $"%A{v763059}"
                            let v763063 : string = "System.TimeoutException"
                            let v763064 : bool = v763060.Contains v763063 
                            if v763064 then
                                let v763067 : unit = ()
                                let v763068 : (unit -> unit) = closure29(v0)
                                let v763069 : unit = (fun () -> v763068 (); v763067) ()
                                US2_1
                            else
                                let v763110 : unit = ()
                                let v763111 : (unit -> unit) = closure30(v0, v763059)
                                let v763112 : unit = (fun () -> v763111 (); v763110) ()
                                US2_1
                        | US9_0(v763057) -> (* Ok *)
                            US2_0(v763057)
                    return v763180 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v764056 : Async<US2> = _v763053 
            let _v762039 = v764056 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v764057 : unit = ()
            let _v764057 =
                async {
                    let! v762038 = v762038 
                    let v764060 : US9 = v762038 
                    let v764184 : US2 =
                        match v764060 with
                        | US9_1(v764063) -> (* Error *)
                            let v764064 : string = $"%A{v764063}"
                            let v764067 : string = "System.TimeoutException"
                            let v764068 : bool = v764064.Contains v764067 
                            if v764068 then
                                let v764071 : unit = ()
                                let v764072 : (unit -> unit) = closure29(v0)
                                let v764073 : unit = (fun () -> v764072 (); v764071) ()
                                US2_1
                            else
                                let v764114 : unit = ()
                                let v764115 : (unit -> unit) = closure30(v0, v764063)
                                let v764116 : unit = (fun () -> v764115 (); v764114) ()
                                US2_1
                        | US9_0(v764061) -> (* Ok *)
                            US2_0(v764061)
                    return v764184 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v765060 : Async<US2> = _v764057 
            let _v762039 = v765060 
            #endif
#else
            let v765061 : unit = ()
            let _v765061 =
                async {
                    let! v762038 = v762038 
                    let v765064 : US9 = v762038 
                    let v765188 : US2 =
                        match v765064 with
                        | US9_1(v765067) -> (* Error *)
                            let v765068 : string = $"%A{v765067}"
                            let v765071 : string = "System.TimeoutException"
                            let v765072 : bool = v765068.Contains v765071 
                            if v765072 then
                                let v765075 : unit = ()
                                let v765076 : (unit -> unit) = closure29(v0)
                                let v765077 : unit = (fun () -> v765076 (); v765075) ()
                                US2_1
                            else
                                let v765118 : unit = ()
                                let v765119 : (unit -> unit) = closure30(v0, v765067)
                                let v765120 : unit = (fun () -> v765119 (); v765118) ()
                                US2_1
                        | US9_0(v765065) -> (* Ok *)
                            US2_0(v765065)
                    return v765188 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v766064 : Async<US2> = _v765061 
            let _v762039 = v766064 
            #endif
            let v766065 : Async<US2> = _v762039 
            return! v766065 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v798316 : Async<US2> = _v762033 
    let _v653171 = v798316 
    #endif
    let v798317 : Async<US2> = _v653171 
    let _v2 = v798317 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v816463 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v816464 : Async<US2> = null |> unbox<Async<US2>>
    let _v816463 = v816464 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v816467 : Async<US2> = null |> unbox<Async<US2>>
    let _v816463 = v816467 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v816470 : Async<US2> = null |> unbox<Async<US2>>
    let _v816463 = v816470 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v816473 : unit = ()
    let _v816473 =
        async {
            let v816476 : Async<Async<int64>> = method52(v0, v1)
            let! v816476 = v816476 
            let v816477 : Async<int64> = v816476 
            let v816478 : Async<US9> = method53(v816477)
            let v816479 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v816480 : Async<US2> = null |> unbox<Async<US2>>
            let _v816479 = v816480 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v816483 : Async<US2> = null |> unbox<Async<US2>>
            let _v816479 = v816483 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v816486 : Async<US2> = null |> unbox<Async<US2>>
            let _v816479 = v816486 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v816489 : unit = ()
            let _v816489 =
                async {
                    let! v816478 = v816478 
                    let v816492 : US9 = v816478 
                    let v816616 : US2 =
                        match v816492 with
                        | US9_1(v816495) -> (* Error *)
                            let v816496 : string = $"%A{v816495}"
                            let v816499 : string = "System.TimeoutException"
                            let v816500 : bool = v816496.Contains v816499 
                            if v816500 then
                                let v816503 : unit = ()
                                let v816504 : (unit -> unit) = closure29(v0)
                                let v816505 : unit = (fun () -> v816504 (); v816503) ()
                                US2_1
                            else
                                let v816546 : unit = ()
                                let v816547 : (unit -> unit) = closure30(v0, v816495)
                                let v816548 : unit = (fun () -> v816547 (); v816546) ()
                                US2_1
                        | US9_0(v816493) -> (* Ok *)
                            US2_0(v816493)
                    return v816616 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v817492 : Async<US2> = _v816489 
            let _v816479 = v817492 
            #endif
#if FABLE_COMPILER_PYTHON
            let v817493 : unit = ()
            let _v817493 =
                async {
                    let! v816478 = v816478 
                    let v817496 : US9 = v816478 
                    let v817620 : US2 =
                        match v817496 with
                        | US9_1(v817499) -> (* Error *)
                            let v817500 : string = $"%A{v817499}"
                            let v817503 : string = "System.TimeoutException"
                            let v817504 : bool = v817500.Contains v817503 
                            if v817504 then
                                let v817507 : unit = ()
                                let v817508 : (unit -> unit) = closure29(v0)
                                let v817509 : unit = (fun () -> v817508 (); v817507) ()
                                US2_1
                            else
                                let v817550 : unit = ()
                                let v817551 : (unit -> unit) = closure30(v0, v817499)
                                let v817552 : unit = (fun () -> v817551 (); v817550) ()
                                US2_1
                        | US9_0(v817497) -> (* Ok *)
                            US2_0(v817497)
                    return v817620 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v818496 : Async<US2> = _v817493 
            let _v816479 = v818496 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v818497 : unit = ()
            let _v818497 =
                async {
                    let! v816478 = v816478 
                    let v818500 : US9 = v816478 
                    let v818624 : US2 =
                        match v818500 with
                        | US9_1(v818503) -> (* Error *)
                            let v818504 : string = $"%A{v818503}"
                            let v818507 : string = "System.TimeoutException"
                            let v818508 : bool = v818504.Contains v818507 
                            if v818508 then
                                let v818511 : unit = ()
                                let v818512 : (unit -> unit) = closure29(v0)
                                let v818513 : unit = (fun () -> v818512 (); v818511) ()
                                US2_1
                            else
                                let v818554 : unit = ()
                                let v818555 : (unit -> unit) = closure30(v0, v818503)
                                let v818556 : unit = (fun () -> v818555 (); v818554) ()
                                US2_1
                        | US9_0(v818501) -> (* Ok *)
                            US2_0(v818501)
                    return v818624 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v819500 : Async<US2> = _v818497 
            let _v816479 = v819500 
            #endif
#else
            let v819501 : unit = ()
            let _v819501 =
                async {
                    let! v816478 = v816478 
                    let v819504 : US9 = v816478 
                    let v819628 : US2 =
                        match v819504 with
                        | US9_1(v819507) -> (* Error *)
                            let v819508 : string = $"%A{v819507}"
                            let v819511 : string = "System.TimeoutException"
                            let v819512 : bool = v819508.Contains v819511 
                            if v819512 then
                                let v819515 : unit = ()
                                let v819516 : (unit -> unit) = closure29(v0)
                                let v819517 : unit = (fun () -> v819516 (); v819515) ()
                                US2_1
                            else
                                let v819558 : unit = ()
                                let v819559 : (unit -> unit) = closure30(v0, v819507)
                                let v819560 : unit = (fun () -> v819559 (); v819558) ()
                                US2_1
                        | US9_0(v819505) -> (* Ok *)
                            US2_0(v819505)
                    return v819628 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v820504 : Async<US2> = _v819501 
            let _v816479 = v820504 
            #endif
            let v820505 : Async<US2> = _v816479 
            return! v820505 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v852756 : Async<US2> = _v816473 
    let _v816463 = v852756 
    #endif
#if FABLE_COMPILER_PYTHON
    let v852757 : unit = ()
    let _v852757 =
        async {
            let v852760 : Async<Async<int64>> = method52(v0, v1)
            let! v852760 = v852760 
            let v852761 : Async<int64> = v852760 
            let v852762 : Async<US9> = method53(v852761)
            let v852763 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v852764 : Async<US2> = null |> unbox<Async<US2>>
            let _v852763 = v852764 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v852767 : Async<US2> = null |> unbox<Async<US2>>
            let _v852763 = v852767 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v852770 : Async<US2> = null |> unbox<Async<US2>>
            let _v852763 = v852770 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v852773 : unit = ()
            let _v852773 =
                async {
                    let! v852762 = v852762 
                    let v852776 : US9 = v852762 
                    let v852900 : US2 =
                        match v852776 with
                        | US9_1(v852779) -> (* Error *)
                            let v852780 : string = $"%A{v852779}"
                            let v852783 : string = "System.TimeoutException"
                            let v852784 : bool = v852780.Contains v852783 
                            if v852784 then
                                let v852787 : unit = ()
                                let v852788 : (unit -> unit) = closure29(v0)
                                let v852789 : unit = (fun () -> v852788 (); v852787) ()
                                US2_1
                            else
                                let v852830 : unit = ()
                                let v852831 : (unit -> unit) = closure30(v0, v852779)
                                let v852832 : unit = (fun () -> v852831 (); v852830) ()
                                US2_1
                        | US9_0(v852777) -> (* Ok *)
                            US2_0(v852777)
                    return v852900 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v853776 : Async<US2> = _v852773 
            let _v852763 = v853776 
            #endif
#if FABLE_COMPILER_PYTHON
            let v853777 : unit = ()
            let _v853777 =
                async {
                    let! v852762 = v852762 
                    let v853780 : US9 = v852762 
                    let v853904 : US2 =
                        match v853780 with
                        | US9_1(v853783) -> (* Error *)
                            let v853784 : string = $"%A{v853783}"
                            let v853787 : string = "System.TimeoutException"
                            let v853788 : bool = v853784.Contains v853787 
                            if v853788 then
                                let v853791 : unit = ()
                                let v853792 : (unit -> unit) = closure29(v0)
                                let v853793 : unit = (fun () -> v853792 (); v853791) ()
                                US2_1
                            else
                                let v853834 : unit = ()
                                let v853835 : (unit -> unit) = closure30(v0, v853783)
                                let v853836 : unit = (fun () -> v853835 (); v853834) ()
                                US2_1
                        | US9_0(v853781) -> (* Ok *)
                            US2_0(v853781)
                    return v853904 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v854780 : Async<US2> = _v853777 
            let _v852763 = v854780 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v854781 : unit = ()
            let _v854781 =
                async {
                    let! v852762 = v852762 
                    let v854784 : US9 = v852762 
                    let v854908 : US2 =
                        match v854784 with
                        | US9_1(v854787) -> (* Error *)
                            let v854788 : string = $"%A{v854787}"
                            let v854791 : string = "System.TimeoutException"
                            let v854792 : bool = v854788.Contains v854791 
                            if v854792 then
                                let v854795 : unit = ()
                                let v854796 : (unit -> unit) = closure29(v0)
                                let v854797 : unit = (fun () -> v854796 (); v854795) ()
                                US2_1
                            else
                                let v854838 : unit = ()
                                let v854839 : (unit -> unit) = closure30(v0, v854787)
                                let v854840 : unit = (fun () -> v854839 (); v854838) ()
                                US2_1
                        | US9_0(v854785) -> (* Ok *)
                            US2_0(v854785)
                    return v854908 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v855784 : Async<US2> = _v854781 
            let _v852763 = v855784 
            #endif
#else
            let v855785 : unit = ()
            let _v855785 =
                async {
                    let! v852762 = v852762 
                    let v855788 : US9 = v852762 
                    let v855912 : US2 =
                        match v855788 with
                        | US9_1(v855791) -> (* Error *)
                            let v855792 : string = $"%A{v855791}"
                            let v855795 : string = "System.TimeoutException"
                            let v855796 : bool = v855792.Contains v855795 
                            if v855796 then
                                let v855799 : unit = ()
                                let v855800 : (unit -> unit) = closure29(v0)
                                let v855801 : unit = (fun () -> v855800 (); v855799) ()
                                US2_1
                            else
                                let v855842 : unit = ()
                                let v855843 : (unit -> unit) = closure30(v0, v855791)
                                let v855844 : unit = (fun () -> v855843 (); v855842) ()
                                US2_1
                        | US9_0(v855789) -> (* Ok *)
                            US2_0(v855789)
                    return v855912 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v856788 : Async<US2> = _v855785 
            let _v852763 = v856788 
            #endif
            let v856789 : Async<US2> = _v852763 
            return! v856789 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v889040 : Async<US2> = _v852757 
    let _v816463 = v889040 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v889041 : unit = ()
    let _v889041 =
        async {
            let v889044 : Async<Async<int64>> = method52(v0, v1)
            let! v889044 = v889044 
            let v889045 : Async<int64> = v889044 
            let v889046 : Async<US9> = method53(v889045)
            let v889047 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v889048 : Async<US2> = null |> unbox<Async<US2>>
            let _v889047 = v889048 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v889051 : Async<US2> = null |> unbox<Async<US2>>
            let _v889047 = v889051 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v889054 : Async<US2> = null |> unbox<Async<US2>>
            let _v889047 = v889054 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v889057 : unit = ()
            let _v889057 =
                async {
                    let! v889046 = v889046 
                    let v889060 : US9 = v889046 
                    let v889184 : US2 =
                        match v889060 with
                        | US9_1(v889063) -> (* Error *)
                            let v889064 : string = $"%A{v889063}"
                            let v889067 : string = "System.TimeoutException"
                            let v889068 : bool = v889064.Contains v889067 
                            if v889068 then
                                let v889071 : unit = ()
                                let v889072 : (unit -> unit) = closure29(v0)
                                let v889073 : unit = (fun () -> v889072 (); v889071) ()
                                US2_1
                            else
                                let v889114 : unit = ()
                                let v889115 : (unit -> unit) = closure30(v0, v889063)
                                let v889116 : unit = (fun () -> v889115 (); v889114) ()
                                US2_1
                        | US9_0(v889061) -> (* Ok *)
                            US2_0(v889061)
                    return v889184 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v890060 : Async<US2> = _v889057 
            let _v889047 = v890060 
            #endif
#if FABLE_COMPILER_PYTHON
            let v890061 : unit = ()
            let _v890061 =
                async {
                    let! v889046 = v889046 
                    let v890064 : US9 = v889046 
                    let v890188 : US2 =
                        match v890064 with
                        | US9_1(v890067) -> (* Error *)
                            let v890068 : string = $"%A{v890067}"
                            let v890071 : string = "System.TimeoutException"
                            let v890072 : bool = v890068.Contains v890071 
                            if v890072 then
                                let v890075 : unit = ()
                                let v890076 : (unit -> unit) = closure29(v0)
                                let v890077 : unit = (fun () -> v890076 (); v890075) ()
                                US2_1
                            else
                                let v890118 : unit = ()
                                let v890119 : (unit -> unit) = closure30(v0, v890067)
                                let v890120 : unit = (fun () -> v890119 (); v890118) ()
                                US2_1
                        | US9_0(v890065) -> (* Ok *)
                            US2_0(v890065)
                    return v890188 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v891064 : Async<US2> = _v890061 
            let _v889047 = v891064 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v891065 : unit = ()
            let _v891065 =
                async {
                    let! v889046 = v889046 
                    let v891068 : US9 = v889046 
                    let v891192 : US2 =
                        match v891068 with
                        | US9_1(v891071) -> (* Error *)
                            let v891072 : string = $"%A{v891071}"
                            let v891075 : string = "System.TimeoutException"
                            let v891076 : bool = v891072.Contains v891075 
                            if v891076 then
                                let v891079 : unit = ()
                                let v891080 : (unit -> unit) = closure29(v0)
                                let v891081 : unit = (fun () -> v891080 (); v891079) ()
                                US2_1
                            else
                                let v891122 : unit = ()
                                let v891123 : (unit -> unit) = closure30(v0, v891071)
                                let v891124 : unit = (fun () -> v891123 (); v891122) ()
                                US2_1
                        | US9_0(v891069) -> (* Ok *)
                            US2_0(v891069)
                    return v891192 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v892068 : Async<US2> = _v891065 
            let _v889047 = v892068 
            #endif
#else
            let v892069 : unit = ()
            let _v892069 =
                async {
                    let! v889046 = v889046 
                    let v892072 : US9 = v889046 
                    let v892196 : US2 =
                        match v892072 with
                        | US9_1(v892075) -> (* Error *)
                            let v892076 : string = $"%A{v892075}"
                            let v892079 : string = "System.TimeoutException"
                            let v892080 : bool = v892076.Contains v892079 
                            if v892080 then
                                let v892083 : unit = ()
                                let v892084 : (unit -> unit) = closure29(v0)
                                let v892085 : unit = (fun () -> v892084 (); v892083) ()
                                US2_1
                            else
                                let v892126 : unit = ()
                                let v892127 : (unit -> unit) = closure30(v0, v892075)
                                let v892128 : unit = (fun () -> v892127 (); v892126) ()
                                US2_1
                        | US9_0(v892073) -> (* Ok *)
                            US2_0(v892073)
                    return v892196 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v893072 : Async<US2> = _v892069 
            let _v889047 = v893072 
            #endif
            let v893073 : Async<US2> = _v889047 
            return! v893073 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v925324 : Async<US2> = _v889041 
    let _v816463 = v925324 
    #endif
#else
    let v925325 : unit = ()
    let _v925325 =
        async {
            let v925328 : Async<Async<int64>> = method52(v0, v1)
            let! v925328 = v925328 
            let v925329 : Async<int64> = v925328 
            let v925330 : Async<US9> = method53(v925329)
            let v925331 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v925332 : Async<US2> = null |> unbox<Async<US2>>
            let _v925331 = v925332 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v925335 : Async<US2> = null |> unbox<Async<US2>>
            let _v925331 = v925335 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v925338 : Async<US2> = null |> unbox<Async<US2>>
            let _v925331 = v925338 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v925341 : unit = ()
            let _v925341 =
                async {
                    let! v925330 = v925330 
                    let v925344 : US9 = v925330 
                    let v925468 : US2 =
                        match v925344 with
                        | US9_1(v925347) -> (* Error *)
                            let v925348 : string = $"%A{v925347}"
                            let v925351 : string = "System.TimeoutException"
                            let v925352 : bool = v925348.Contains v925351 
                            if v925352 then
                                let v925355 : unit = ()
                                let v925356 : (unit -> unit) = closure29(v0)
                                let v925357 : unit = (fun () -> v925356 (); v925355) ()
                                US2_1
                            else
                                let v925398 : unit = ()
                                let v925399 : (unit -> unit) = closure30(v0, v925347)
                                let v925400 : unit = (fun () -> v925399 (); v925398) ()
                                US2_1
                        | US9_0(v925345) -> (* Ok *)
                            US2_0(v925345)
                    return v925468 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v926344 : Async<US2> = _v925341 
            let _v925331 = v926344 
            #endif
#if FABLE_COMPILER_PYTHON
            let v926345 : unit = ()
            let _v926345 =
                async {
                    let! v925330 = v925330 
                    let v926348 : US9 = v925330 
                    let v926472 : US2 =
                        match v926348 with
                        | US9_1(v926351) -> (* Error *)
                            let v926352 : string = $"%A{v926351}"
                            let v926355 : string = "System.TimeoutException"
                            let v926356 : bool = v926352.Contains v926355 
                            if v926356 then
                                let v926359 : unit = ()
                                let v926360 : (unit -> unit) = closure29(v0)
                                let v926361 : unit = (fun () -> v926360 (); v926359) ()
                                US2_1
                            else
                                let v926402 : unit = ()
                                let v926403 : (unit -> unit) = closure30(v0, v926351)
                                let v926404 : unit = (fun () -> v926403 (); v926402) ()
                                US2_1
                        | US9_0(v926349) -> (* Ok *)
                            US2_0(v926349)
                    return v926472 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v927348 : Async<US2> = _v926345 
            let _v925331 = v927348 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v927349 : unit = ()
            let _v927349 =
                async {
                    let! v925330 = v925330 
                    let v927352 : US9 = v925330 
                    let v927476 : US2 =
                        match v927352 with
                        | US9_1(v927355) -> (* Error *)
                            let v927356 : string = $"%A{v927355}"
                            let v927359 : string = "System.TimeoutException"
                            let v927360 : bool = v927356.Contains v927359 
                            if v927360 then
                                let v927363 : unit = ()
                                let v927364 : (unit -> unit) = closure29(v0)
                                let v927365 : unit = (fun () -> v927364 (); v927363) ()
                                US2_1
                            else
                                let v927406 : unit = ()
                                let v927407 : (unit -> unit) = closure30(v0, v927355)
                                let v927408 : unit = (fun () -> v927407 (); v927406) ()
                                US2_1
                        | US9_0(v927353) -> (* Ok *)
                            US2_0(v927353)
                    return v927476 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v928352 : Async<US2> = _v927349 
            let _v925331 = v928352 
            #endif
#else
            let v928353 : unit = ()
            let _v928353 =
                async {
                    let! v925330 = v925330 
                    let v928356 : US9 = v925330 
                    let v928480 : US2 =
                        match v928356 with
                        | US9_1(v928359) -> (* Error *)
                            let v928360 : string = $"%A{v928359}"
                            let v928363 : string = "System.TimeoutException"
                            let v928364 : bool = v928360.Contains v928363 
                            if v928364 then
                                let v928367 : unit = ()
                                let v928368 : (unit -> unit) = closure29(v0)
                                let v928369 : unit = (fun () -> v928368 (); v928367) ()
                                US2_1
                            else
                                let v928410 : unit = ()
                                let v928411 : (unit -> unit) = closure30(v0, v928359)
                                let v928412 : unit = (fun () -> v928411 (); v928410) ()
                                US2_1
                        | US9_0(v928357) -> (* Ok *)
                            US2_0(v928357)
                    return v928480 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v929356 : Async<US2> = _v928353 
            let _v925331 = v929356 
            #endif
            let v929357 : Async<US2> = _v925331 
            return! v929357 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v961608 : Async<US2> = _v925325 
    let _v816463 = v961608 
    #endif
    let v961609 : Async<US2> = _v816463 
    let _v2 = v961609 
    #endif
#else
    let v979755 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v979756 : Async<US2> = null |> unbox<Async<US2>>
    let _v979755 = v979756 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v979759 : Async<US2> = null |> unbox<Async<US2>>
    let _v979755 = v979759 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v979762 : Async<US2> = null |> unbox<Async<US2>>
    let _v979755 = v979762 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v979765 : unit = ()
    let _v979765 =
        async {
            let v979768 : Async<Async<int64>> = method52(v0, v1)
            let! v979768 = v979768 
            let v979769 : Async<int64> = v979768 
            let v979770 : Async<US9> = method53(v979769)
            let v979771 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v979772 : Async<US2> = null |> unbox<Async<US2>>
            let _v979771 = v979772 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v979775 : Async<US2> = null |> unbox<Async<US2>>
            let _v979771 = v979775 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v979778 : Async<US2> = null |> unbox<Async<US2>>
            let _v979771 = v979778 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v979781 : unit = ()
            let _v979781 =
                async {
                    let! v979770 = v979770 
                    let v979784 : US9 = v979770 
                    let v979908 : US2 =
                        match v979784 with
                        | US9_1(v979787) -> (* Error *)
                            let v979788 : string = $"%A{v979787}"
                            let v979791 : string = "System.TimeoutException"
                            let v979792 : bool = v979788.Contains v979791 
                            if v979792 then
                                let v979795 : unit = ()
                                let v979796 : (unit -> unit) = closure29(v0)
                                let v979797 : unit = (fun () -> v979796 (); v979795) ()
                                US2_1
                            else
                                let v979838 : unit = ()
                                let v979839 : (unit -> unit) = closure30(v0, v979787)
                                let v979840 : unit = (fun () -> v979839 (); v979838) ()
                                US2_1
                        | US9_0(v979785) -> (* Ok *)
                            US2_0(v979785)
                    return v979908 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v980784 : Async<US2> = _v979781 
            let _v979771 = v980784 
            #endif
#if FABLE_COMPILER_PYTHON
            let v980785 : unit = ()
            let _v980785 =
                async {
                    let! v979770 = v979770 
                    let v980788 : US9 = v979770 
                    let v980912 : US2 =
                        match v980788 with
                        | US9_1(v980791) -> (* Error *)
                            let v980792 : string = $"%A{v980791}"
                            let v980795 : string = "System.TimeoutException"
                            let v980796 : bool = v980792.Contains v980795 
                            if v980796 then
                                let v980799 : unit = ()
                                let v980800 : (unit -> unit) = closure29(v0)
                                let v980801 : unit = (fun () -> v980800 (); v980799) ()
                                US2_1
                            else
                                let v980842 : unit = ()
                                let v980843 : (unit -> unit) = closure30(v0, v980791)
                                let v980844 : unit = (fun () -> v980843 (); v980842) ()
                                US2_1
                        | US9_0(v980789) -> (* Ok *)
                            US2_0(v980789)
                    return v980912 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v981788 : Async<US2> = _v980785 
            let _v979771 = v981788 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v981789 : unit = ()
            let _v981789 =
                async {
                    let! v979770 = v979770 
                    let v981792 : US9 = v979770 
                    let v981916 : US2 =
                        match v981792 with
                        | US9_1(v981795) -> (* Error *)
                            let v981796 : string = $"%A{v981795}"
                            let v981799 : string = "System.TimeoutException"
                            let v981800 : bool = v981796.Contains v981799 
                            if v981800 then
                                let v981803 : unit = ()
                                let v981804 : (unit -> unit) = closure29(v0)
                                let v981805 : unit = (fun () -> v981804 (); v981803) ()
                                US2_1
                            else
                                let v981846 : unit = ()
                                let v981847 : (unit -> unit) = closure30(v0, v981795)
                                let v981848 : unit = (fun () -> v981847 (); v981846) ()
                                US2_1
                        | US9_0(v981793) -> (* Ok *)
                            US2_0(v981793)
                    return v981916 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v982792 : Async<US2> = _v981789 
            let _v979771 = v982792 
            #endif
#else
            let v982793 : unit = ()
            let _v982793 =
                async {
                    let! v979770 = v979770 
                    let v982796 : US9 = v979770 
                    let v982920 : US2 =
                        match v982796 with
                        | US9_1(v982799) -> (* Error *)
                            let v982800 : string = $"%A{v982799}"
                            let v982803 : string = "System.TimeoutException"
                            let v982804 : bool = v982800.Contains v982803 
                            if v982804 then
                                let v982807 : unit = ()
                                let v982808 : (unit -> unit) = closure29(v0)
                                let v982809 : unit = (fun () -> v982808 (); v982807) ()
                                US2_1
                            else
                                let v982850 : unit = ()
                                let v982851 : (unit -> unit) = closure30(v0, v982799)
                                let v982852 : unit = (fun () -> v982851 (); v982850) ()
                                US2_1
                        | US9_0(v982797) -> (* Ok *)
                            US2_0(v982797)
                    return v982920 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v983796 : Async<US2> = _v982793 
            let _v979771 = v983796 
            #endif
            let v983797 : Async<US2> = _v979771 
            return! v983797 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v1016048 : Async<US2> = _v979765 
    let _v979755 = v1016048 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1016049 : unit = ()
    let _v1016049 =
        async {
            let v1016052 : Async<Async<int64>> = method52(v0, v1)
            let! v1016052 = v1016052 
            let v1016053 : Async<int64> = v1016052 
            let v1016054 : Async<US9> = method53(v1016053)
            let v1016055 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1016056 : Async<US2> = null |> unbox<Async<US2>>
            let _v1016055 = v1016056 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1016059 : Async<US2> = null |> unbox<Async<US2>>
            let _v1016055 = v1016059 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1016062 : Async<US2> = null |> unbox<Async<US2>>
            let _v1016055 = v1016062 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1016065 : unit = ()
            let _v1016065 =
                async {
                    let! v1016054 = v1016054 
                    let v1016068 : US9 = v1016054 
                    let v1016192 : US2 =
                        match v1016068 with
                        | US9_1(v1016071) -> (* Error *)
                            let v1016072 : string = $"%A{v1016071}"
                            let v1016075 : string = "System.TimeoutException"
                            let v1016076 : bool = v1016072.Contains v1016075 
                            if v1016076 then
                                let v1016079 : unit = ()
                                let v1016080 : (unit -> unit) = closure29(v0)
                                let v1016081 : unit = (fun () -> v1016080 (); v1016079) ()
                                US2_1
                            else
                                let v1016122 : unit = ()
                                let v1016123 : (unit -> unit) = closure30(v0, v1016071)
                                let v1016124 : unit = (fun () -> v1016123 (); v1016122) ()
                                US2_1
                        | US9_0(v1016069) -> (* Ok *)
                            US2_0(v1016069)
                    return v1016192 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v1017068 : Async<US2> = _v1016065 
            let _v1016055 = v1017068 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1017069 : unit = ()
            let _v1017069 =
                async {
                    let! v1016054 = v1016054 
                    let v1017072 : US9 = v1016054 
                    let v1017196 : US2 =
                        match v1017072 with
                        | US9_1(v1017075) -> (* Error *)
                            let v1017076 : string = $"%A{v1017075}"
                            let v1017079 : string = "System.TimeoutException"
                            let v1017080 : bool = v1017076.Contains v1017079 
                            if v1017080 then
                                let v1017083 : unit = ()
                                let v1017084 : (unit -> unit) = closure29(v0)
                                let v1017085 : unit = (fun () -> v1017084 (); v1017083) ()
                                US2_1
                            else
                                let v1017126 : unit = ()
                                let v1017127 : (unit -> unit) = closure30(v0, v1017075)
                                let v1017128 : unit = (fun () -> v1017127 (); v1017126) ()
                                US2_1
                        | US9_0(v1017073) -> (* Ok *)
                            US2_0(v1017073)
                    return v1017196 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v1018072 : Async<US2> = _v1017069 
            let _v1016055 = v1018072 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1018073 : unit = ()
            let _v1018073 =
                async {
                    let! v1016054 = v1016054 
                    let v1018076 : US9 = v1016054 
                    let v1018200 : US2 =
                        match v1018076 with
                        | US9_1(v1018079) -> (* Error *)
                            let v1018080 : string = $"%A{v1018079}"
                            let v1018083 : string = "System.TimeoutException"
                            let v1018084 : bool = v1018080.Contains v1018083 
                            if v1018084 then
                                let v1018087 : unit = ()
                                let v1018088 : (unit -> unit) = closure29(v0)
                                let v1018089 : unit = (fun () -> v1018088 (); v1018087) ()
                                US2_1
                            else
                                let v1018130 : unit = ()
                                let v1018131 : (unit -> unit) = closure30(v0, v1018079)
                                let v1018132 : unit = (fun () -> v1018131 (); v1018130) ()
                                US2_1
                        | US9_0(v1018077) -> (* Ok *)
                            US2_0(v1018077)
                    return v1018200 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v1019076 : Async<US2> = _v1018073 
            let _v1016055 = v1019076 
            #endif
#else
            let v1019077 : unit = ()
            let _v1019077 =
                async {
                    let! v1016054 = v1016054 
                    let v1019080 : US9 = v1016054 
                    let v1019204 : US2 =
                        match v1019080 with
                        | US9_1(v1019083) -> (* Error *)
                            let v1019084 : string = $"%A{v1019083}"
                            let v1019087 : string = "System.TimeoutException"
                            let v1019088 : bool = v1019084.Contains v1019087 
                            if v1019088 then
                                let v1019091 : unit = ()
                                let v1019092 : (unit -> unit) = closure29(v0)
                                let v1019093 : unit = (fun () -> v1019092 (); v1019091) ()
                                US2_1
                            else
                                let v1019134 : unit = ()
                                let v1019135 : (unit -> unit) = closure30(v0, v1019083)
                                let v1019136 : unit = (fun () -> v1019135 (); v1019134) ()
                                US2_1
                        | US9_0(v1019081) -> (* Ok *)
                            US2_0(v1019081)
                    return v1019204 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v1020080 : Async<US2> = _v1019077 
            let _v1016055 = v1020080 
            #endif
            let v1020081 : Async<US2> = _v1016055 
            return! v1020081 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v1052332 : Async<US2> = _v1016049 
    let _v979755 = v1052332 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1052333 : unit = ()
    let _v1052333 =
        async {
            let v1052336 : Async<Async<int64>> = method52(v0, v1)
            let! v1052336 = v1052336 
            let v1052337 : Async<int64> = v1052336 
            let v1052338 : Async<US9> = method53(v1052337)
            let v1052339 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1052340 : Async<US2> = null |> unbox<Async<US2>>
            let _v1052339 = v1052340 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1052343 : Async<US2> = null |> unbox<Async<US2>>
            let _v1052339 = v1052343 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1052346 : Async<US2> = null |> unbox<Async<US2>>
            let _v1052339 = v1052346 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1052349 : unit = ()
            let _v1052349 =
                async {
                    let! v1052338 = v1052338 
                    let v1052352 : US9 = v1052338 
                    let v1052476 : US2 =
                        match v1052352 with
                        | US9_1(v1052355) -> (* Error *)
                            let v1052356 : string = $"%A{v1052355}"
                            let v1052359 : string = "System.TimeoutException"
                            let v1052360 : bool = v1052356.Contains v1052359 
                            if v1052360 then
                                let v1052363 : unit = ()
                                let v1052364 : (unit -> unit) = closure29(v0)
                                let v1052365 : unit = (fun () -> v1052364 (); v1052363) ()
                                US2_1
                            else
                                let v1052406 : unit = ()
                                let v1052407 : (unit -> unit) = closure30(v0, v1052355)
                                let v1052408 : unit = (fun () -> v1052407 (); v1052406) ()
                                US2_1
                        | US9_0(v1052353) -> (* Ok *)
                            US2_0(v1052353)
                    return v1052476 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v1053352 : Async<US2> = _v1052349 
            let _v1052339 = v1053352 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1053353 : unit = ()
            let _v1053353 =
                async {
                    let! v1052338 = v1052338 
                    let v1053356 : US9 = v1052338 
                    let v1053480 : US2 =
                        match v1053356 with
                        | US9_1(v1053359) -> (* Error *)
                            let v1053360 : string = $"%A{v1053359}"
                            let v1053363 : string = "System.TimeoutException"
                            let v1053364 : bool = v1053360.Contains v1053363 
                            if v1053364 then
                                let v1053367 : unit = ()
                                let v1053368 : (unit -> unit) = closure29(v0)
                                let v1053369 : unit = (fun () -> v1053368 (); v1053367) ()
                                US2_1
                            else
                                let v1053410 : unit = ()
                                let v1053411 : (unit -> unit) = closure30(v0, v1053359)
                                let v1053412 : unit = (fun () -> v1053411 (); v1053410) ()
                                US2_1
                        | US9_0(v1053357) -> (* Ok *)
                            US2_0(v1053357)
                    return v1053480 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v1054356 : Async<US2> = _v1053353 
            let _v1052339 = v1054356 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1054357 : unit = ()
            let _v1054357 =
                async {
                    let! v1052338 = v1052338 
                    let v1054360 : US9 = v1052338 
                    let v1054484 : US2 =
                        match v1054360 with
                        | US9_1(v1054363) -> (* Error *)
                            let v1054364 : string = $"%A{v1054363}"
                            let v1054367 : string = "System.TimeoutException"
                            let v1054368 : bool = v1054364.Contains v1054367 
                            if v1054368 then
                                let v1054371 : unit = ()
                                let v1054372 : (unit -> unit) = closure29(v0)
                                let v1054373 : unit = (fun () -> v1054372 (); v1054371) ()
                                US2_1
                            else
                                let v1054414 : unit = ()
                                let v1054415 : (unit -> unit) = closure30(v0, v1054363)
                                let v1054416 : unit = (fun () -> v1054415 (); v1054414) ()
                                US2_1
                        | US9_0(v1054361) -> (* Ok *)
                            US2_0(v1054361)
                    return v1054484 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v1055360 : Async<US2> = _v1054357 
            let _v1052339 = v1055360 
            #endif
#else
            let v1055361 : unit = ()
            let _v1055361 =
                async {
                    let! v1052338 = v1052338 
                    let v1055364 : US9 = v1052338 
                    let v1055488 : US2 =
                        match v1055364 with
                        | US9_1(v1055367) -> (* Error *)
                            let v1055368 : string = $"%A{v1055367}"
                            let v1055371 : string = "System.TimeoutException"
                            let v1055372 : bool = v1055368.Contains v1055371 
                            if v1055372 then
                                let v1055375 : unit = ()
                                let v1055376 : (unit -> unit) = closure29(v0)
                                let v1055377 : unit = (fun () -> v1055376 (); v1055375) ()
                                US2_1
                            else
                                let v1055418 : unit = ()
                                let v1055419 : (unit -> unit) = closure30(v0, v1055367)
                                let v1055420 : unit = (fun () -> v1055419 (); v1055418) ()
                                US2_1
                        | US9_0(v1055365) -> (* Ok *)
                            US2_0(v1055365)
                    return v1055488 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v1056364 : Async<US2> = _v1055361 
            let _v1052339 = v1056364 
            #endif
            let v1056365 : Async<US2> = _v1052339 
            return! v1056365 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v1088616 : Async<US2> = _v1052333 
    let _v979755 = v1088616 
    #endif
#else
    let v1088617 : unit = ()
    let _v1088617 =
        async {
            let v1088620 : Async<Async<int64>> = method52(v0, v1)
            let! v1088620 = v1088620 
            let v1088621 : Async<int64> = v1088620 
            let v1088622 : Async<US9> = method53(v1088621)
            let v1088623 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1088624 : Async<US2> = null |> unbox<Async<US2>>
            let _v1088623 = v1088624 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1088627 : Async<US2> = null |> unbox<Async<US2>>
            let _v1088623 = v1088627 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1088630 : Async<US2> = null |> unbox<Async<US2>>
            let _v1088623 = v1088630 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1088633 : unit = ()
            let _v1088633 =
                async {
                    let! v1088622 = v1088622 
                    let v1088636 : US9 = v1088622 
                    let v1088760 : US2 =
                        match v1088636 with
                        | US9_1(v1088639) -> (* Error *)
                            let v1088640 : string = $"%A{v1088639}"
                            let v1088643 : string = "System.TimeoutException"
                            let v1088644 : bool = v1088640.Contains v1088643 
                            if v1088644 then
                                let v1088647 : unit = ()
                                let v1088648 : (unit -> unit) = closure29(v0)
                                let v1088649 : unit = (fun () -> v1088648 (); v1088647) ()
                                US2_1
                            else
                                let v1088690 : unit = ()
                                let v1088691 : (unit -> unit) = closure30(v0, v1088639)
                                let v1088692 : unit = (fun () -> v1088691 (); v1088690) ()
                                US2_1
                        | US9_0(v1088637) -> (* Ok *)
                            US2_0(v1088637)
                    return v1088760 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v1089636 : Async<US2> = _v1088633 
            let _v1088623 = v1089636 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1089637 : unit = ()
            let _v1089637 =
                async {
                    let! v1088622 = v1088622 
                    let v1089640 : US9 = v1088622 
                    let v1089764 : US2 =
                        match v1089640 with
                        | US9_1(v1089643) -> (* Error *)
                            let v1089644 : string = $"%A{v1089643}"
                            let v1089647 : string = "System.TimeoutException"
                            let v1089648 : bool = v1089644.Contains v1089647 
                            if v1089648 then
                                let v1089651 : unit = ()
                                let v1089652 : (unit -> unit) = closure29(v0)
                                let v1089653 : unit = (fun () -> v1089652 (); v1089651) ()
                                US2_1
                            else
                                let v1089694 : unit = ()
                                let v1089695 : (unit -> unit) = closure30(v0, v1089643)
                                let v1089696 : unit = (fun () -> v1089695 (); v1089694) ()
                                US2_1
                        | US9_0(v1089641) -> (* Ok *)
                            US2_0(v1089641)
                    return v1089764 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v1090640 : Async<US2> = _v1089637 
            let _v1088623 = v1090640 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1090641 : unit = ()
            let _v1090641 =
                async {
                    let! v1088622 = v1088622 
                    let v1090644 : US9 = v1088622 
                    let v1090768 : US2 =
                        match v1090644 with
                        | US9_1(v1090647) -> (* Error *)
                            let v1090648 : string = $"%A{v1090647}"
                            let v1090651 : string = "System.TimeoutException"
                            let v1090652 : bool = v1090648.Contains v1090651 
                            if v1090652 then
                                let v1090655 : unit = ()
                                let v1090656 : (unit -> unit) = closure29(v0)
                                let v1090657 : unit = (fun () -> v1090656 (); v1090655) ()
                                US2_1
                            else
                                let v1090698 : unit = ()
                                let v1090699 : (unit -> unit) = closure30(v0, v1090647)
                                let v1090700 : unit = (fun () -> v1090699 (); v1090698) ()
                                US2_1
                        | US9_0(v1090645) -> (* Ok *)
                            US2_0(v1090645)
                    return v1090768 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v1091644 : Async<US2> = _v1090641 
            let _v1088623 = v1091644 
            #endif
#else
            let v1091645 : unit = ()
            let _v1091645 =
                async {
                    let! v1088622 = v1088622 
                    let v1091648 : US9 = v1088622 
                    let v1091772 : US2 =
                        match v1091648 with
                        | US9_1(v1091651) -> (* Error *)
                            let v1091652 : string = $"%A{v1091651}"
                            let v1091655 : string = "System.TimeoutException"
                            let v1091656 : bool = v1091652.Contains v1091655 
                            if v1091656 then
                                let v1091659 : unit = ()
                                let v1091660 : (unit -> unit) = closure29(v0)
                                let v1091661 : unit = (fun () -> v1091660 (); v1091659) ()
                                US2_1
                            else
                                let v1091702 : unit = ()
                                let v1091703 : (unit -> unit) = closure30(v0, v1091651)
                                let v1091704 : unit = (fun () -> v1091703 (); v1091702) ()
                                US2_1
                        | US9_0(v1091649) -> (* Ok *)
                            US2_0(v1091649)
                    return v1091772 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v1092648 : Async<US2> = _v1091645 
            let _v1088623 = v1092648 
            #endif
            let v1092649 : Async<US2> = _v1088623 
            return! v1092649 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v1124900 : Async<US2> = _v1088617 
    let _v979755 = v1124900 
    #endif
    let v1124901 : Async<US2> = _v979755 
    let _v2 = v1124901 
    #endif
    let v1143047 : Async<US2> = _v2 
    v1143047
and method63 (v0 : Async<US2>) : Async<unit> =
    let v1 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : Async<unit> = null |> unbox<Async<unit>>
    let _v1 = v2 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v5 : Async<unit> = null |> unbox<Async<unit>>
    let _v1 = v5 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v8 : Async<unit> = null |> unbox<Async<unit>>
    let _v1 = v8 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v11 : (Async<US2> -> Async<unit>) = Async.Ignore
    let v12 : Async<unit> = v11 v0
    let _v1 = v12 
    #endif
#if FABLE_COMPILER_PYTHON
    let v13 : (Async<US2> -> Async<unit>) = Async.Ignore
    let v14 : Async<unit> = v13 v0
    let _v1 = v14 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v15 : (Async<US2> -> Async<unit>) = Async.Ignore
    let v16 : Async<unit> = v15 v0
    let _v1 = v16 
    #endif
#else
    let v17 : (Async<US2> -> Async<unit>) = Async.Ignore
    let v18 : Async<unit> = v17 v0
    let _v1 = v18 
    #endif
    let v19 : Async<unit> = _v1 
    v19
and method65 (v0 : int64, v1 : string) : string =
    let v2 : string = method17()
    let v3 : Mut3 = {l0 = v2} : Mut3
    let v4 : string = "{ "
    let v5 : string = $"{v4}"
    let v8 : unit = ()
    let v9 : (unit -> unit) = closure6(v3, v5)
    let v10 : unit = (fun () -> v9 (); v8) ()
    let v13 : string = "retry"
    let v14 : string = $"{v13}"
    let v17 : unit = ()
    let v18 : (unit -> unit) = closure6(v3, v14)
    let v19 : unit = (fun () -> v18 (); v17) ()
    let v22 : string = " = "
    let v23 : string = $"{v22}"
    let v26 : unit = ()
    let v27 : (unit -> unit) = closure6(v3, v23)
    let v28 : unit = (fun () -> v27 (); v26) ()
    let v31 : string = $"{v0}"
    let v34 : unit = ()
    let v35 : (unit -> unit) = closure6(v3, v31)
    let v36 : unit = (fun () -> v35 (); v34) ()
    let v39 : string = "; "
    let v40 : string = $"{v39}"
    let v43 : unit = ()
    let v44 : (unit -> unit) = closure6(v3, v40)
    let v45 : unit = (fun () -> v44 (); v43) ()
    let v48 : string = "ex"
    let v49 : string = $"{v48}"
    let v52 : unit = ()
    let v53 : (unit -> unit) = closure6(v3, v49)
    let v54 : unit = (fun () -> v53 (); v52) ()
    let v57 : string = $"{v22}"
    let v60 : unit = ()
    let v61 : (unit -> unit) = closure6(v3, v57)
    let v62 : unit = (fun () -> v61 (); v60) ()
    let v65 : string = $"{v1}"
    let v68 : unit = ()
    let v69 : (unit -> unit) = closure6(v3, v65)
    let v70 : unit = (fun () -> v69 (); v68) ()
    let v73 : string = " }"
    let v74 : string = $"{v73}"
    let v77 : unit = ()
    let v78 : (unit -> unit) = closure6(v3, v74)
    let v79 : unit = (fun () -> v78 (); v77) ()
    let v82 : string = v3.l0
    v82
and method64 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : string) : string =
    let v10 : string = method65(v8, v9)
    let v11 : int64 = v0.l0
    let v12 : string = "file_system.read_all_text_retry_async"
    let v13 : string = $"{v6} {v7} #{v11} %s{v12} / {v10}"
    method22(v13)
and closure31 (v0 : int64, v1 : string) () : unit =
    let v2 : US0 = US0_1
    let v3 : bool = method10(v2)
    if v3 then
        let v4 : unit = ()
        let v5 : (unit -> unit) = closure0()
        let v6 : unit = (fun () -> v5 (); v4) ()
        let struct (v20 : Mut0, v21 : Mut1, v22 : Mut2, v23 : Mut3, v24 : Mut4, v25 : int64 option) = TraceState.trace_state.Value
        let v38 : string = method11(v20, v21, v22, v23, v24, v25)
        let v39 : string = method15()
        let v40 : string = method64(v20, v21, v22, v23, v24, v25, v38, v39, v0, v1)
        method23(v40)
and method50 (v0 : string, v1 : int64) : Async<string option> =
    let v2 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : Async<string option> = null |> unbox<Async<string option>>
    let _v2 = v3 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v6 : Async<string option> = null |> unbox<Async<string option>>
    let _v2 = v6 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v9 : Async<string option> = null |> unbox<Async<string option>>
    let _v2 = v9 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v12 : unit = ()
    let _v12 =
        async {
            try
            let v15 : bool = v1 > 0L
            if v15 then
                let v16 : Async<int64> = method29(v0)
                let v17 : int32 = 1000
                let v18 : Async<US2> = method51(v17, v16)
                let v19 : Async<unit> = method63(v18)
                do! v19 
                ()
            let v20 : Async<string> = method30(v0)
            let v21 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v22 : Async<string option> = null |> unbox<Async<string option>>
            let _v21 = v22 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v25 : Async<string option> = null |> unbox<Async<string option>>
            let _v21 = v25 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v28 : Async<string option> = null |> unbox<Async<string option>>
            let _v21 = v28 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v31 : unit = ()
            let _v31 =
                async {
                    let! v20 = v20 
                    let v34 : string = v20 
                    let v35 : string option = Some v34 
                    return v35 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v66 : Async<string option> = _v31 
            let _v21 = v66 
            #endif
#if FABLE_COMPILER_PYTHON
            let v67 : unit = ()
            let _v67 =
                async {
                    let! v20 = v20 
                    let v70 : string = v20 
                    let v71 : string option = Some v70 
                    return v71 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v102 : Async<string option> = _v67 
            let _v21 = v102 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v103 : unit = ()
            let _v103 =
                async {
                    let! v20 = v20 
                    let v106 : string = v20 
                    let v107 : string option = Some v106 
                    return v107 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v138 : Async<string option> = _v103 
            let _v21 = v138 
            #endif
#else
            let v139 : unit = ()
            let _v139 =
                async {
                    let! v20 = v20 
                    let v142 : string = v20 
                    let v143 : string option = Some v142 
                    return v143 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v174 : Async<string option> = _v139 
            let _v21 = v174 
            #endif
            let v175 : Async<string option> = _v21 
            return! v175 
            with ex ->
                let v197 : exn = ex
                let v198 : bool = v1 = 0L
                let v199 : bool = v198 <> true
                if v199 then
                    let v200 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v201 : string = $"%A{v197}"
                    let _v200 = v201 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v204 : string = $"%A{v197}"
                    let _v200 = v204 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v207 : string = $"%A{v197}"
                    let _v200 = v207 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v210 : string = $"%A{v197}"
                    let _v200 = v210 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v213 : string = $"%A{v197}"
                    let _v200 = v213 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v216 : string = $"%A{v197}"
                    let _v200 = v216 
                    #endif
#else
                    let v219 : string = $"{v197.GetType ()}: {v197.Message}"
                    let _v200 = v219 
                    #endif
                    let v220 : string = _v200 
                    let v225 : unit = ()
                    let v226 : (unit -> unit) = closure31(v1, v220)
                    let v227 : unit = (fun () -> v226 (); v225) ()
                    let v267 : string option = None
                    return v267 
                    (*
                    ()
                else
                    *) else
                    let v268 : int64 = v1 + 1L
                    let v269 : Async<string option> = method50(v0, v268)
                    return! v269 
                    (*
                    ()
                *)
                (*
                ()
            *)
            (*
            let v343 : string option = *)
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v2647 : Async<string option> = _v12 
    let _v2 = v2647 
    #endif
#if FABLE_COMPILER_PYTHON
    let v2648 : unit = ()
    let _v2648 =
        async {
            try
            let v2651 : bool = v1 > 0L
            if v2651 then
                let v2652 : Async<int64> = method29(v0)
                let v2653 : int32 = 1000
                let v2654 : Async<US2> = method51(v2653, v2652)
                let v2655 : Async<unit> = method63(v2654)
                do! v2655 
                ()
            let v2656 : Async<string> = method30(v0)
            let v2657 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v2658 : Async<string option> = null |> unbox<Async<string option>>
            let _v2657 = v2658 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v2661 : Async<string option> = null |> unbox<Async<string option>>
            let _v2657 = v2661 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v2664 : Async<string option> = null |> unbox<Async<string option>>
            let _v2657 = v2664 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v2667 : unit = ()
            let _v2667 =
                async {
                    let! v2656 = v2656 
                    let v2670 : string = v2656 
                    let v2671 : string option = Some v2670 
                    return v2671 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v2702 : Async<string option> = _v2667 
            let _v2657 = v2702 
            #endif
#if FABLE_COMPILER_PYTHON
            let v2703 : unit = ()
            let _v2703 =
                async {
                    let! v2656 = v2656 
                    let v2706 : string = v2656 
                    let v2707 : string option = Some v2706 
                    return v2707 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v2738 : Async<string option> = _v2703 
            let _v2657 = v2738 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v2739 : unit = ()
            let _v2739 =
                async {
                    let! v2656 = v2656 
                    let v2742 : string = v2656 
                    let v2743 : string option = Some v2742 
                    return v2743 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v2774 : Async<string option> = _v2739 
            let _v2657 = v2774 
            #endif
#else
            let v2775 : unit = ()
            let _v2775 =
                async {
                    let! v2656 = v2656 
                    let v2778 : string = v2656 
                    let v2779 : string option = Some v2778 
                    return v2779 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v2810 : Async<string option> = _v2775 
            let _v2657 = v2810 
            #endif
            let v2811 : Async<string option> = _v2657 
            return! v2811 
            with ex ->
                let v2833 : exn = ex
                let v2834 : bool = v1 = 0L
                let v2835 : bool = v2834 <> true
                if v2835 then
                    let v2836 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v2837 : string = $"%A{v2833}"
                    let _v2836 = v2837 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v2840 : string = $"%A{v2833}"
                    let _v2836 = v2840 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v2843 : string = $"%A{v2833}"
                    let _v2836 = v2843 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v2846 : string = $"%A{v2833}"
                    let _v2836 = v2846 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v2849 : string = $"%A{v2833}"
                    let _v2836 = v2849 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v2852 : string = $"%A{v2833}"
                    let _v2836 = v2852 
                    #endif
#else
                    let v2855 : string = $"{v2833.GetType ()}: {v2833.Message}"
                    let _v2836 = v2855 
                    #endif
                    let v2856 : string = _v2836 
                    let v2861 : unit = ()
                    let v2862 : (unit -> unit) = closure31(v1, v2856)
                    let v2863 : unit = (fun () -> v2862 (); v2861) ()
                    let v2903 : string option = None
                    return v2903 
                    (*
                    ()
                else
                    *) else
                    let v2904 : int64 = v1 + 1L
                    let v2905 : Async<string option> = method50(v0, v2904)
                    return! v2905 
                    (*
                    ()
                *)
                (*
                ()
            *)
            (*
            let v2979 : string option = *)
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v5283 : Async<string option> = _v2648 
    let _v2 = v5283 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v5284 : unit = ()
    let _v5284 =
        async {
            try
            let v5287 : bool = v1 > 0L
            if v5287 then
                let v5288 : Async<int64> = method29(v0)
                let v5289 : int32 = 1000
                let v5290 : Async<US2> = method51(v5289, v5288)
                let v5291 : Async<unit> = method63(v5290)
                do! v5291 
                ()
            let v5292 : Async<string> = method30(v0)
            let v5293 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v5294 : Async<string option> = null |> unbox<Async<string option>>
            let _v5293 = v5294 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v5297 : Async<string option> = null |> unbox<Async<string option>>
            let _v5293 = v5297 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v5300 : Async<string option> = null |> unbox<Async<string option>>
            let _v5293 = v5300 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v5303 : unit = ()
            let _v5303 =
                async {
                    let! v5292 = v5292 
                    let v5306 : string = v5292 
                    let v5307 : string option = Some v5306 
                    return v5307 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v5338 : Async<string option> = _v5303 
            let _v5293 = v5338 
            #endif
#if FABLE_COMPILER_PYTHON
            let v5339 : unit = ()
            let _v5339 =
                async {
                    let! v5292 = v5292 
                    let v5342 : string = v5292 
                    let v5343 : string option = Some v5342 
                    return v5343 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v5374 : Async<string option> = _v5339 
            let _v5293 = v5374 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v5375 : unit = ()
            let _v5375 =
                async {
                    let! v5292 = v5292 
                    let v5378 : string = v5292 
                    let v5379 : string option = Some v5378 
                    return v5379 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v5410 : Async<string option> = _v5375 
            let _v5293 = v5410 
            #endif
#else
            let v5411 : unit = ()
            let _v5411 =
                async {
                    let! v5292 = v5292 
                    let v5414 : string = v5292 
                    let v5415 : string option = Some v5414 
                    return v5415 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v5446 : Async<string option> = _v5411 
            let _v5293 = v5446 
            #endif
            let v5447 : Async<string option> = _v5293 
            return! v5447 
            with ex ->
                let v5469 : exn = ex
                let v5470 : bool = v1 = 0L
                let v5471 : bool = v5470 <> true
                if v5471 then
                    let v5472 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v5473 : string = $"%A{v5469}"
                    let _v5472 = v5473 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v5476 : string = $"%A{v5469}"
                    let _v5472 = v5476 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v5479 : string = $"%A{v5469}"
                    let _v5472 = v5479 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v5482 : string = $"%A{v5469}"
                    let _v5472 = v5482 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v5485 : string = $"%A{v5469}"
                    let _v5472 = v5485 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v5488 : string = $"%A{v5469}"
                    let _v5472 = v5488 
                    #endif
#else
                    let v5491 : string = $"{v5469.GetType ()}: {v5469.Message}"
                    let _v5472 = v5491 
                    #endif
                    let v5492 : string = _v5472 
                    let v5497 : unit = ()
                    let v5498 : (unit -> unit) = closure31(v1, v5492)
                    let v5499 : unit = (fun () -> v5498 (); v5497) ()
                    let v5539 : string option = None
                    return v5539 
                    (*
                    ()
                else
                    *) else
                    let v5540 : int64 = v1 + 1L
                    let v5541 : Async<string option> = method50(v0, v5540)
                    return! v5541 
                    (*
                    ()
                *)
                (*
                ()
            *)
            (*
            let v5615 : string option = *)
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v7919 : Async<string option> = _v5284 
    let _v2 = v7919 
    #endif
#else
    let v7920 : unit = ()
    let _v7920 =
        async {
            try
            let v7923 : bool = v1 > 0L
            if v7923 then
                let v7924 : Async<int64> = method29(v0)
                let v7925 : int32 = 1000
                let v7926 : Async<US2> = method51(v7925, v7924)
                let v7927 : Async<unit> = method63(v7926)
                do! v7927 
                ()
            let v7928 : Async<string> = method30(v0)
            let v7929 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v7930 : Async<string option> = null |> unbox<Async<string option>>
            let _v7929 = v7930 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v7933 : Async<string option> = null |> unbox<Async<string option>>
            let _v7929 = v7933 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v7936 : Async<string option> = null |> unbox<Async<string option>>
            let _v7929 = v7936 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v7939 : unit = ()
            let _v7939 =
                async {
                    let! v7928 = v7928 
                    let v7942 : string = v7928 
                    let v7943 : string option = Some v7942 
                    return v7943 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v7974 : Async<string option> = _v7939 
            let _v7929 = v7974 
            #endif
#if FABLE_COMPILER_PYTHON
            let v7975 : unit = ()
            let _v7975 =
                async {
                    let! v7928 = v7928 
                    let v7978 : string = v7928 
                    let v7979 : string option = Some v7978 
                    return v7979 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v8010 : Async<string option> = _v7975 
            let _v7929 = v8010 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v8011 : unit = ()
            let _v8011 =
                async {
                    let! v7928 = v7928 
                    let v8014 : string = v7928 
                    let v8015 : string option = Some v8014 
                    return v8015 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v8046 : Async<string option> = _v8011 
            let _v7929 = v8046 
            #endif
#else
            let v8047 : unit = ()
            let _v8047 =
                async {
                    let! v7928 = v7928 
                    let v8050 : string = v7928 
                    let v8051 : string option = Some v8050 
                    return v8051 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v8082 : Async<string option> = _v8047 
            let _v7929 = v8082 
            #endif
            let v8083 : Async<string option> = _v7929 
            return! v8083 
            with ex ->
                let v8105 : exn = ex
                let v8106 : bool = v1 = 0L
                let v8107 : bool = v8106 <> true
                if v8107 then
                    let v8108 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v8109 : string = $"%A{v8105}"
                    let _v8108 = v8109 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v8112 : string = $"%A{v8105}"
                    let _v8108 = v8112 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v8115 : string = $"%A{v8105}"
                    let _v8108 = v8115 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v8118 : string = $"%A{v8105}"
                    let _v8108 = v8118 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v8121 : string = $"%A{v8105}"
                    let _v8108 = v8121 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v8124 : string = $"%A{v8105}"
                    let _v8108 = v8124 
                    #endif
#else
                    let v8127 : string = $"{v8105.GetType ()}: {v8105.Message}"
                    let _v8108 = v8127 
                    #endif
                    let v8128 : string = _v8108 
                    let v8133 : unit = ()
                    let v8134 : (unit -> unit) = closure31(v1, v8128)
                    let v8135 : unit = (fun () -> v8134 (); v8133) ()
                    let v8175 : string option = None
                    return v8175 
                    (*
                    ()
                else
                    *) else
                    let v8176 : int64 = v1 + 1L
                    let v8177 : Async<string option> = method50(v0, v8176)
                    return! v8177 
                    (*
                    ()
                *)
                (*
                ()
            *)
            (*
            let v8251 : string option = *)
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v10555 : Async<string option> = _v7920 
    let _v2 = v10555 
    #endif
    let v10556 : Async<string option> = _v2 
    v10556
and method49 (v0 : string) : Async<string option> =
    let v1 : int64 = 0L
    method50(v0, v1)
and closure26 () (v0 : string) : Async<string option> =
    method49(v0)
and closure33 () (v0 : chrono_DateTime<chrono_Utc>) : US11 =
    US11_0(v0)
and method68 () : (chrono_DateTime<chrono_Utc> -> US11) =
    closure33()
and method69 () : string =
    let v0 : string = "hh:mm"
    v0
and method70 () : string =
    let v0 : string = "yyyyMMdd-HHmm-ssff-ffff-f"
    v0
and method71 () : string =
    let v0 : string = "hhmm"
    v0
and method67 (v0 : System.Guid, v1 : System.DateTime) : System.Guid =
    let v2 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : System.DateTime = System.DateTime.UnixEpoch
    let v6 : (System.DateTime -> System.DateTime) = _.ToUniversalTime()
    let v7 : System.DateTime = v6 v3
    let v10 : System.DateTimeKind = System.DateTimeKind.Local
    let v11 : System.DateTime = System.DateTime.SpecifyKind (v1, v10)
    let v14 : (System.DateTime -> System.DateTime) = _.ToUniversalTime()
    let v15 : System.DateTime = v14 v11
    let v18 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v19 : (System.DateTime -> int64) = _.Ticks
    let v20 : int64 = v19 v15
    let _v18 = v20 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v21 : (System.DateTime -> int64) = _.Ticks
    let v22 : int64 = v21 v15
    let _v18 = v22 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v23 : int64 = null |> unbox<int64>
    let _v18 = v23 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v26 : (System.DateTime -> int64) = _.Ticks
    let v27 : int64 = v26 v15
    let _v18 = v27 
    #endif
#if FABLE_COMPILER_PYTHON
    let v28 : (System.DateTime -> int64) = _.Ticks
    let v29 : int64 = v28 v15
    let _v18 = v29 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v30 : (System.DateTime -> int64) = _.Ticks
    let v31 : int64 = v30 v15
    let _v18 = v31 
    #endif
#else
    let v32 : (System.DateTime -> int64) = _.Ticks
    let v33 : int64 = v32 v15
    let _v18 = v33 
    #endif
    let v34 : int64 = _v18 
    let v51 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v52 : (System.DateTime -> int64) = _.Ticks
    let v53 : int64 = v52 v7
    let _v51 = v53 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v54 : (System.DateTime -> int64) = _.Ticks
    let v55 : int64 = v54 v7
    let _v51 = v55 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v56 : int64 = null |> unbox<int64>
    let _v51 = v56 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v59 : (System.DateTime -> int64) = _.Ticks
    let v60 : int64 = v59 v7
    let _v51 = v60 
    #endif
#if FABLE_COMPILER_PYTHON
    let v61 : (System.DateTime -> int64) = _.Ticks
    let v62 : int64 = v61 v7
    let _v51 = v62 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v63 : (System.DateTime -> int64) = _.Ticks
    let v64 : int64 = v63 v7
    let _v51 = v64 
    #endif
#else
    let v65 : (System.DateTime -> int64) = _.Ticks
    let v66 : int64 = v65 v7
    let _v51 = v66 
    #endif
    let v67 : int64 = _v51 
    let v84 : int64 = v34 |> int64 
    let v87 : int64 = v67 |> int64 
    let v90 : int64 = v84 - v87
    let v91 : int64 = v90 / 10L
    let v92 : string = "chrono::DateTime::from_timestamp_micros($0)"
    let v93 : chrono_DateTime<chrono_Utc> option = Fable.Core.RustInterop.emitRustExpr v91 v92 
    let v94 : (chrono_DateTime<chrono_Utc> -> US11) = method68()
    let v95 : US11 option = v93 |> Option.map v94 
    let v106 : US11 = US11_1
    let v107 : US11 = v95 |> Option.defaultValue v106 
    let v127 : US5 =
        match v107 with
        | US11_1 -> (* None *)
            US5_1
        | US11_0(v111) -> (* Some *)
            let v112 : string = "$0.naive_utc()"
            let v113 : chrono_NaiveDateTime = Fable.Core.RustInterop.emitRustExpr v111 v112 
            let v114 : string = "chrono::offset::TimeZone::from_utc_datetime(&chrono::Local, &$0)"
            let v115 : chrono_DateTime<chrono_Local> = Fable.Core.RustInterop.emitRustExpr v113 v114 
            let v116 : string = "%Y%m%d-%H%M-%S%f"
            let v117 : string = "r#\"" + v116 + "\"#"
            let v118 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v117 
            let v119 : string = "$0.format($1).to_string()"
            let v120 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v115, v118) v119 
            let v121 : string = "fable_library_rust::String_::fromString($0)"
            let v122 : string = Fable.Core.RustInterop.emitRustExpr v120 v121 
            let v123 : string = $"{v122.[0..17]}-{v122.[18..21]}-{v122.[22]}"
            US5_0(v123)
    let v131 : string =
        match v127 with
        | US5_1 -> (* None *)
            let v129 : string = ""
            v129
        | US5_0(v128) -> (* Some *)
            v128
    let v132 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v133 : string = "std::sync::Arc::new(chrono::FixedOffset::local_minus_utc(chrono::Local::now().offset()) as i64)"
    let v134 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v133 
    let _v132 = v134 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v135 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v132 = v135 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v138 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v132 = v138 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v141 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v132 = v141 
    #endif
#if FABLE_COMPILER_PYTHON
    let v144 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v132 = v144 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v147 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v132 = v147 
    #endif
#else
    let v148 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v132 = v148 
    #endif
    let v149 : System.TimeZoneInfo = _v132 
    let v154 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v155 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v156 : (System.DateTime -> int64) = _.Ticks
    let v157 : int64 = v156 v15
    let _v155 = v157 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v158 : (System.DateTime -> int64) = _.Ticks
    let v159 : int64 = v158 v15
    let _v155 = v159 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v160 : int64 = null |> unbox<int64>
    let _v155 = v160 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v163 : (System.DateTime -> int64) = _.Ticks
    let v164 : int64 = v163 v15
    let _v155 = v164 
    #endif
#if FABLE_COMPILER_PYTHON
    let v165 : (System.DateTime -> int64) = _.Ticks
    let v166 : int64 = v165 v15
    let _v155 = v166 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v167 : (System.DateTime -> int64) = _.Ticks
    let v168 : int64 = v167 v15
    let _v155 = v168 
    #endif
#else
    let v169 : (System.DateTime -> int64) = _.Ticks
    let v170 : int64 = v169 v15
    let _v155 = v170 
    #endif
    let v171 : int64 = _v155 
    let v188 : string = "chrono::FixedOffset::local_minus_utc(&chrono::DateTime::timezone(&chrono::DateTime::fixed_offset(&chrono::DateTime::from_timestamp_nanos($1))))"
    let v189 : int32 = Fable.Core.RustInterop.emitRustExpr struct (v15, v171) v188 
    let v190 : System.TimeSpan = v189 |> System.TimeSpan 
    let _v154 = v190 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v193 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v194 : (System.DateTime -> int64) = _.Ticks
    let v195 : int64 = v194 v15
    let _v193 = v195 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v196 : (System.DateTime -> int64) = _.Ticks
    let v197 : int64 = v196 v15
    let _v193 = v197 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v198 : int64 = null |> unbox<int64>
    let _v193 = v198 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v201 : (System.DateTime -> int64) = _.Ticks
    let v202 : int64 = v201 v15
    let _v193 = v202 
    #endif
#if FABLE_COMPILER_PYTHON
    let v203 : (System.DateTime -> int64) = _.Ticks
    let v204 : int64 = v203 v15
    let _v193 = v204 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v205 : (System.DateTime -> int64) = _.Ticks
    let v206 : int64 = v205 v15
    let _v193 = v206 
    #endif
#else
    let v207 : (System.DateTime -> int64) = _.Ticks
    let v208 : int64 = v207 v15
    let _v193 = v208 
    #endif
    let v209 : int64 = _v193 
    let v226 : string = "chrono::FixedOffset::local_minus_utc(&chrono::DateTime::timezone(&chrono::DateTime::fixed_offset(&chrono::DateTime::from_timestamp_nanos($1))))"
    let v227 : int32 = Fable.Core.RustInterop.emitRustExpr struct (v15, v209) v226 
    let v228 : System.TimeSpan = v227 |> System.TimeSpan 
    let _v154 = v228 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v231 : US3 = US3_2
    let v232 : US4 = US4_2(v231)
    let v233 : string = $"date_time.get_utc_offset / target: {v232}"
    let v234 : System.TimeSpan = failwith<System.TimeSpan> v233
    let _v154 = v234 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v237 : US3 = US3_0
    let v238 : US4 = US4_3(v237)
    let v239 : string = $"date_time.get_utc_offset / target: {v238}"
    let v240 : System.TimeSpan = failwith<System.TimeSpan> v239
    let _v154 = v240 
    #endif
#if FABLE_COMPILER_PYTHON
    let v243 : US3 = US3_0
    let v244 : US4 = US4_4(v243)
    let v245 : string = $"date_time.get_utc_offset / target: {v244}"
    let v246 : System.TimeSpan = failwith<System.TimeSpan> v245
    let _v154 = v246 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v249 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v250 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v251 : string = "std::sync::Arc::new(chrono::FixedOffset::local_minus_utc(chrono::Local::now().offset()) as i64)"
    let v252 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v251 
    let _v250 = v252 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v253 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v250 = v253 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v256 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v250 = v256 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v259 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v250 = v259 
    #endif
#if FABLE_COMPILER_PYTHON
    let v262 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v250 = v262 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v265 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v250 = v265 
    #endif
#else
    let v266 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v250 = v266 
    #endif
    let v267 : System.TimeZoneInfo = _v250 
    let v272 : (System.DateTime -> System.TimeSpan) = v249 v267
    let v273 : System.TimeSpan = v272 v15
    let _v154 = v273 
    #endif
#else
    let v274 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v275 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v276 : string = "std::sync::Arc::new(chrono::FixedOffset::local_minus_utc(chrono::Local::now().offset()) as i64)"
    let v277 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v276 
    let _v275 = v277 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v278 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v275 = v278 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v281 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v275 = v281 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v284 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v275 = v284 
    #endif
#if FABLE_COMPILER_PYTHON
    let v287 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v275 = v287 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v290 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v275 = v290 
    #endif
#else
    let v291 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v275 = v291 
    #endif
    let v292 : System.TimeZoneInfo = _v275 
    let v297 : (System.DateTime -> System.TimeSpan) = v274 v292
    let v298 : System.TimeSpan = v297 v15
    let _v154 = v298 
    #endif
    let v299 : System.TimeSpan = _v154 
    let v307 : (System.TimeSpan -> int32) = _.Hours
    let v308 : int32 = v307 v299
    let v311 : bool = v308 > 0
    let v312 : uint8 =
        if v311 then
            1uy
        else
            0uy
    let v313 : string = method69()
    let v314 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v315 : string = v299.ToString v313 
    let _v314 = v315 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v318 : string = v299.ToString v313 
    let _v314 = v318 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v321 : string = v299.ToString v313 
    let _v314 = v321 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v324 : string = v299.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _v314 = v324 
    #endif
#if FABLE_COMPILER_PYTHON
    let v325 : string = v299.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _v314 = v325 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v326 : string = v299.ToString v313 
    let _v314 = v326 
    #endif
#else
    let v329 : string = v299.ToString v313 
    let _v314 = v329 
    #endif
    let v332 : string = _v314 
    let v337 : string = $"{v312}{v332.[0..1]}{v332.[3..4]}"
    let v338 : (System.Guid -> string) = _.ToString()
    let v339 : string = v338 v0
    let v342 : int32 = v131.Length
    let v343 : int32 = v337.Length
    let v344 : int32 = v342 + v343
    let v345 : (string -> int32) = String.length
    let v346 : int32 = v345 v339
    let v349 : int32 = v344 |> int32 
    let v356 : int32 = v346 |> int32 
    let v363 : int32 = v356 - 1
    let v364 : string = v339.[int v349..int v363]
    let v368 : string = $"{v131}{v337}{v364}"
    let v369 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v370 : System.Guid = v368 |> System.Guid 
    let _v369 = v370 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v373 : System.Guid = v368 |> System.Guid 
    let _v369 = v373 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v376 : System.Guid = null |> unbox<System.Guid>
    let _v369 = v376 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v379 : System.Guid = v368 |> System.Guid 
    let _v369 = v379 
    #endif
#if FABLE_COMPILER_PYTHON
    let v382 : System.Guid = v368 |> System.Guid 
    let _v369 = v382 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v385 : System.Guid = v368 |> System.Guid 
    let _v369 = v385 
    #endif
#else
    let v388 : System.Guid = v368 |> System.Guid 
    let _v369 = v388 
    #endif
    let v391 : System.Guid = _v369 
    let _v2 = v391 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v396 : System.DateTime = System.DateTime.UnixEpoch
    let v399 : (System.DateTime -> System.DateTime) = _.ToUniversalTime()
    let v400 : System.DateTime = v399 v396
    let v403 : System.DateTimeKind = System.DateTimeKind.Local
    let v404 : System.DateTime = System.DateTime.SpecifyKind (v1, v403)
    let v407 : (System.DateTime -> System.DateTime) = _.ToUniversalTime()
    let v408 : System.DateTime = v407 v404
    let v411 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v412 : (System.DateTime -> int64) = _.Ticks
    let v413 : int64 = v412 v408
    let _v411 = v413 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v414 : (System.DateTime -> int64) = _.Ticks
    let v415 : int64 = v414 v408
    let _v411 = v415 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v416 : int64 = null |> unbox<int64>
    let _v411 = v416 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v419 : (System.DateTime -> int64) = _.Ticks
    let v420 : int64 = v419 v408
    let _v411 = v420 
    #endif
#if FABLE_COMPILER_PYTHON
    let v421 : (System.DateTime -> int64) = _.Ticks
    let v422 : int64 = v421 v408
    let _v411 = v422 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v423 : (System.DateTime -> int64) = _.Ticks
    let v424 : int64 = v423 v408
    let _v411 = v424 
    #endif
#else
    let v425 : (System.DateTime -> int64) = _.Ticks
    let v426 : int64 = v425 v408
    let _v411 = v426 
    #endif
    let v427 : int64 = _v411 
    let v444 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v445 : (System.DateTime -> int64) = _.Ticks
    let v446 : int64 = v445 v400
    let _v444 = v446 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v447 : (System.DateTime -> int64) = _.Ticks
    let v448 : int64 = v447 v400
    let _v444 = v448 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v449 : int64 = null |> unbox<int64>
    let _v444 = v449 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v452 : (System.DateTime -> int64) = _.Ticks
    let v453 : int64 = v452 v400
    let _v444 = v453 
    #endif
#if FABLE_COMPILER_PYTHON
    let v454 : (System.DateTime -> int64) = _.Ticks
    let v455 : int64 = v454 v400
    let _v444 = v455 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v456 : (System.DateTime -> int64) = _.Ticks
    let v457 : int64 = v456 v400
    let _v444 = v457 
    #endif
#else
    let v458 : (System.DateTime -> int64) = _.Ticks
    let v459 : int64 = v458 v400
    let _v444 = v459 
    #endif
    let v460 : int64 = _v444 
    let v477 : int64 = v427 |> int64 
    let v480 : int64 = v460 |> int64 
    let v483 : int64 = v477 - v480
    let v484 : int64 = v483 / 10L
    let v485 : string = "chrono::DateTime::from_timestamp_micros($0)"
    let v486 : chrono_DateTime<chrono_Utc> option = Fable.Core.RustInterop.emitRustExpr v484 v485 
    let v487 : (chrono_DateTime<chrono_Utc> -> US11) = method68()
    let v488 : US11 option = v486 |> Option.map v487 
    let v499 : US11 = US11_1
    let v500 : US11 = v488 |> Option.defaultValue v499 
    let v520 : US5 =
        match v500 with
        | US11_1 -> (* None *)
            US5_1
        | US11_0(v504) -> (* Some *)
            let v505 : string = "$0.naive_utc()"
            let v506 : chrono_NaiveDateTime = Fable.Core.RustInterop.emitRustExpr v504 v505 
            let v507 : string = "chrono::offset::TimeZone::from_utc_datetime(&chrono::Local, &$0)"
            let v508 : chrono_DateTime<chrono_Local> = Fable.Core.RustInterop.emitRustExpr v506 v507 
            let v509 : string = "%Y%m%d-%H%M-%S%f"
            let v510 : string = "r#\"" + v509 + "\"#"
            let v511 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v510 
            let v512 : string = "$0.format($1).to_string()"
            let v513 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v508, v511) v512 
            let v514 : string = "fable_library_rust::String_::fromString($0)"
            let v515 : string = Fable.Core.RustInterop.emitRustExpr v513 v514 
            let v516 : string = $"{v515.[0..17]}-{v515.[18..21]}-{v515.[22]}"
            US5_0(v516)
    let v524 : string =
        match v520 with
        | US5_1 -> (* None *)
            let v522 : string = ""
            v522
        | US5_0(v521) -> (* Some *)
            v521
    let v525 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v526 : string = "std::sync::Arc::new(chrono::FixedOffset::local_minus_utc(chrono::Local::now().offset()) as i64)"
    let v527 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v526 
    let _v525 = v527 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v528 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v525 = v528 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v531 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v525 = v531 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v534 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v525 = v534 
    #endif
#if FABLE_COMPILER_PYTHON
    let v537 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v525 = v537 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v540 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v525 = v540 
    #endif
#else
    let v541 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v525 = v541 
    #endif
    let v542 : System.TimeZoneInfo = _v525 
    let v547 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v548 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v549 : (System.DateTime -> int64) = _.Ticks
    let v550 : int64 = v549 v408
    let _v548 = v550 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v551 : (System.DateTime -> int64) = _.Ticks
    let v552 : int64 = v551 v408
    let _v548 = v552 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v553 : int64 = null |> unbox<int64>
    let _v548 = v553 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v556 : (System.DateTime -> int64) = _.Ticks
    let v557 : int64 = v556 v408
    let _v548 = v557 
    #endif
#if FABLE_COMPILER_PYTHON
    let v558 : (System.DateTime -> int64) = _.Ticks
    let v559 : int64 = v558 v408
    let _v548 = v559 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v560 : (System.DateTime -> int64) = _.Ticks
    let v561 : int64 = v560 v408
    let _v548 = v561 
    #endif
#else
    let v562 : (System.DateTime -> int64) = _.Ticks
    let v563 : int64 = v562 v408
    let _v548 = v563 
    #endif
    let v564 : int64 = _v548 
    let v581 : string = "chrono::FixedOffset::local_minus_utc(&chrono::DateTime::timezone(&chrono::DateTime::fixed_offset(&chrono::DateTime::from_timestamp_nanos($1))))"
    let v582 : int32 = Fable.Core.RustInterop.emitRustExpr struct (v408, v564) v581 
    let v583 : System.TimeSpan = v582 |> System.TimeSpan 
    let _v547 = v583 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v586 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v587 : (System.DateTime -> int64) = _.Ticks
    let v588 : int64 = v587 v408
    let _v586 = v588 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v589 : (System.DateTime -> int64) = _.Ticks
    let v590 : int64 = v589 v408
    let _v586 = v590 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v591 : int64 = null |> unbox<int64>
    let _v586 = v591 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v594 : (System.DateTime -> int64) = _.Ticks
    let v595 : int64 = v594 v408
    let _v586 = v595 
    #endif
#if FABLE_COMPILER_PYTHON
    let v596 : (System.DateTime -> int64) = _.Ticks
    let v597 : int64 = v596 v408
    let _v586 = v597 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v598 : (System.DateTime -> int64) = _.Ticks
    let v599 : int64 = v598 v408
    let _v586 = v599 
    #endif
#else
    let v600 : (System.DateTime -> int64) = _.Ticks
    let v601 : int64 = v600 v408
    let _v586 = v601 
    #endif
    let v602 : int64 = _v586 
    let v619 : string = "chrono::FixedOffset::local_minus_utc(&chrono::DateTime::timezone(&chrono::DateTime::fixed_offset(&chrono::DateTime::from_timestamp_nanos($1))))"
    let v620 : int32 = Fable.Core.RustInterop.emitRustExpr struct (v408, v602) v619 
    let v621 : System.TimeSpan = v620 |> System.TimeSpan 
    let _v547 = v621 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v624 : US3 = US3_2
    let v625 : US4 = US4_2(v624)
    let v626 : string = $"date_time.get_utc_offset / target: {v625}"
    let v627 : System.TimeSpan = failwith<System.TimeSpan> v626
    let _v547 = v627 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v630 : US3 = US3_0
    let v631 : US4 = US4_3(v630)
    let v632 : string = $"date_time.get_utc_offset / target: {v631}"
    let v633 : System.TimeSpan = failwith<System.TimeSpan> v632
    let _v547 = v633 
    #endif
#if FABLE_COMPILER_PYTHON
    let v636 : US3 = US3_0
    let v637 : US4 = US4_4(v636)
    let v638 : string = $"date_time.get_utc_offset / target: {v637}"
    let v639 : System.TimeSpan = failwith<System.TimeSpan> v638
    let _v547 = v639 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v642 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v643 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v644 : string = "std::sync::Arc::new(chrono::FixedOffset::local_minus_utc(chrono::Local::now().offset()) as i64)"
    let v645 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v644 
    let _v643 = v645 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v646 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v643 = v646 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v649 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v643 = v649 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v652 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v643 = v652 
    #endif
#if FABLE_COMPILER_PYTHON
    let v655 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v643 = v655 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v658 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v643 = v658 
    #endif
#else
    let v659 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v643 = v659 
    #endif
    let v660 : System.TimeZoneInfo = _v643 
    let v665 : (System.DateTime -> System.TimeSpan) = v642 v660
    let v666 : System.TimeSpan = v665 v408
    let _v547 = v666 
    #endif
#else
    let v667 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v668 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v669 : string = "std::sync::Arc::new(chrono::FixedOffset::local_minus_utc(chrono::Local::now().offset()) as i64)"
    let v670 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v669 
    let _v668 = v670 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v671 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v668 = v671 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v674 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v668 = v674 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v677 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v668 = v677 
    #endif
#if FABLE_COMPILER_PYTHON
    let v680 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v668 = v680 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v683 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v668 = v683 
    #endif
#else
    let v684 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v668 = v684 
    #endif
    let v685 : System.TimeZoneInfo = _v668 
    let v690 : (System.DateTime -> System.TimeSpan) = v667 v685
    let v691 : System.TimeSpan = v690 v408
    let _v547 = v691 
    #endif
    let v692 : System.TimeSpan = _v547 
    let v700 : (System.TimeSpan -> int32) = _.Hours
    let v701 : int32 = v700 v692
    let v704 : bool = v701 > 0
    let v705 : uint8 =
        if v704 then
            1uy
        else
            0uy
    let v706 : string = method69()
    let v707 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v708 : string = v692.ToString v706 
    let _v707 = v708 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v711 : string = v692.ToString v706 
    let _v707 = v711 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v714 : string = v692.ToString v706 
    let _v707 = v714 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v717 : string = v692.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _v707 = v717 
    #endif
#if FABLE_COMPILER_PYTHON
    let v718 : string = v692.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _v707 = v718 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v719 : string = v692.ToString v706 
    let _v707 = v719 
    #endif
#else
    let v722 : string = v692.ToString v706 
    let _v707 = v722 
    #endif
    let v725 : string = _v707 
    let v730 : string = $"{v705}{v725.[0..1]}{v725.[3..4]}"
    let v731 : (System.Guid -> string) = _.ToString()
    let v732 : string = v731 v0
    let v735 : int32 = v524.Length
    let v736 : int32 = v730.Length
    let v737 : int32 = v735 + v736
    let v738 : (string -> int32) = String.length
    let v739 : int32 = v738 v732
    let v742 : int32 = v737 |> int32 
    let v749 : int32 = v739 |> int32 
    let v756 : int32 = v749 - 1
    let v757 : string = v732.[int v742..int v756]
    let v761 : string = $"{v524}{v730}{v757}"
    let v762 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v763 : System.Guid = v761 |> System.Guid 
    let _v762 = v763 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v766 : System.Guid = v761 |> System.Guid 
    let _v762 = v766 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v769 : System.Guid = null |> unbox<System.Guid>
    let _v762 = v769 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v772 : System.Guid = v761 |> System.Guid 
    let _v762 = v772 
    #endif
#if FABLE_COMPILER_PYTHON
    let v775 : System.Guid = v761 |> System.Guid 
    let _v762 = v775 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v778 : System.Guid = v761 |> System.Guid 
    let _v762 = v778 
    #endif
#else
    let v781 : System.Guid = v761 |> System.Guid 
    let _v762 = v781 
    #endif
    let v784 : System.Guid = _v762 
    let _v2 = v784 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v789 : System.Guid = null |> unbox<System.Guid>
    let _v2 = v789 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v792 : string = method70()
    let v793 : bool = v792 = ""
    let v795 : string =
        if v793 then
            let v794 : string = "M-d-y hh:mm:ss tt"
            v794
        else
            v792
    let v796 : (string -> string) = v1.ToString
    let v797 : string = v796 v795
    let v811 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v812 : string = "std::sync::Arc::new(chrono::FixedOffset::local_minus_utc(chrono::Local::now().offset()) as i64)"
    let v813 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v812 
    let _v811 = v813 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v814 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v811 = v814 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v817 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v811 = v817 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v820 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v811 = v820 
    #endif
#if FABLE_COMPILER_PYTHON
    let v823 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v811 = v823 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v826 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v811 = v826 
    #endif
#else
    let v827 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v811 = v827 
    #endif
    let v828 : System.TimeZoneInfo = _v811 
    let v833 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v834 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v835 : (System.DateTime -> int64) = _.Ticks
    let v836 : int64 = v835 v1
    let _v834 = v836 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v837 : (System.DateTime -> int64) = _.Ticks
    let v838 : int64 = v837 v1
    let _v834 = v838 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v839 : int64 = null |> unbox<int64>
    let _v834 = v839 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v842 : (System.DateTime -> int64) = _.Ticks
    let v843 : int64 = v842 v1
    let _v834 = v843 
    #endif
#if FABLE_COMPILER_PYTHON
    let v844 : (System.DateTime -> int64) = _.Ticks
    let v845 : int64 = v844 v1
    let _v834 = v845 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v846 : (System.DateTime -> int64) = _.Ticks
    let v847 : int64 = v846 v1
    let _v834 = v847 
    #endif
#else
    let v848 : (System.DateTime -> int64) = _.Ticks
    let v849 : int64 = v848 v1
    let _v834 = v849 
    #endif
    let v850 : int64 = _v834 
    let v867 : string = "chrono::FixedOffset::local_minus_utc(&chrono::DateTime::timezone(&chrono::DateTime::fixed_offset(&chrono::DateTime::from_timestamp_nanos($1))))"
    let v868 : int32 = Fable.Core.RustInterop.emitRustExpr struct (v1, v850) v867 
    let v869 : System.TimeSpan = v868 |> System.TimeSpan 
    let _v833 = v869 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v872 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v873 : (System.DateTime -> int64) = _.Ticks
    let v874 : int64 = v873 v1
    let _v872 = v874 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v875 : (System.DateTime -> int64) = _.Ticks
    let v876 : int64 = v875 v1
    let _v872 = v876 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v877 : int64 = null |> unbox<int64>
    let _v872 = v877 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v880 : (System.DateTime -> int64) = _.Ticks
    let v881 : int64 = v880 v1
    let _v872 = v881 
    #endif
#if FABLE_COMPILER_PYTHON
    let v882 : (System.DateTime -> int64) = _.Ticks
    let v883 : int64 = v882 v1
    let _v872 = v883 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v884 : (System.DateTime -> int64) = _.Ticks
    let v885 : int64 = v884 v1
    let _v872 = v885 
    #endif
#else
    let v886 : (System.DateTime -> int64) = _.Ticks
    let v887 : int64 = v886 v1
    let _v872 = v887 
    #endif
    let v888 : int64 = _v872 
    let v905 : string = "chrono::FixedOffset::local_minus_utc(&chrono::DateTime::timezone(&chrono::DateTime::fixed_offset(&chrono::DateTime::from_timestamp_nanos($1))))"
    let v906 : int32 = Fable.Core.RustInterop.emitRustExpr struct (v1, v888) v905 
    let v907 : System.TimeSpan = v906 |> System.TimeSpan 
    let _v833 = v907 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v910 : US3 = US3_2
    let v911 : US4 = US4_2(v910)
    let v912 : string = $"date_time.get_utc_offset / target: {v911}"
    let v913 : System.TimeSpan = failwith<System.TimeSpan> v912
    let _v833 = v913 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v916 : US3 = US3_0
    let v917 : US4 = US4_3(v916)
    let v918 : string = $"date_time.get_utc_offset / target: {v917}"
    let v919 : System.TimeSpan = failwith<System.TimeSpan> v918
    let _v833 = v919 
    #endif
#if FABLE_COMPILER_PYTHON
    let v922 : US3 = US3_0
    let v923 : US4 = US4_4(v922)
    let v924 : string = $"date_time.get_utc_offset / target: {v923}"
    let v925 : System.TimeSpan = failwith<System.TimeSpan> v924
    let _v833 = v925 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v928 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v929 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v930 : string = "std::sync::Arc::new(chrono::FixedOffset::local_minus_utc(chrono::Local::now().offset()) as i64)"
    let v931 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v930 
    let _v929 = v931 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v932 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v929 = v932 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v935 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v929 = v935 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v938 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v929 = v938 
    #endif
#if FABLE_COMPILER_PYTHON
    let v941 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v929 = v941 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v944 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v929 = v944 
    #endif
#else
    let v945 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v929 = v945 
    #endif
    let v946 : System.TimeZoneInfo = _v929 
    let v951 : (System.DateTime -> System.TimeSpan) = v928 v946
    let v952 : System.TimeSpan = v951 v1
    let _v833 = v952 
    #endif
#else
    let v953 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v954 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v955 : string = "std::sync::Arc::new(chrono::FixedOffset::local_minus_utc(chrono::Local::now().offset()) as i64)"
    let v956 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v955 
    let _v954 = v956 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v957 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v954 = v957 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v960 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v954 = v960 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v963 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v954 = v963 
    #endif
#if FABLE_COMPILER_PYTHON
    let v966 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v954 = v966 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v969 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v954 = v969 
    #endif
#else
    let v970 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v954 = v970 
    #endif
    let v971 : System.TimeZoneInfo = _v954 
    let v976 : (System.DateTime -> System.TimeSpan) = v953 v971
    let v977 : System.TimeSpan = v976 v1
    let _v833 = v977 
    #endif
    let v978 : System.TimeSpan = _v833 
    let v986 : (System.TimeSpan -> int32) = _.Hours
    let v987 : int32 = v986 v978
    let v990 : bool = v987 > 0
    let v991 : uint8 =
        if v990 then
            1uy
        else
            0uy
    let v992 : string = method71()
    let v993 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v994 : string = v978.ToString v992 
    let _v993 = v994 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v997 : string = v978.ToString v992 
    let _v993 = v997 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1000 : string = v978.ToString v992 
    let _v993 = v1000 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1003 : string = v978.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _v993 = v1003 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1004 : string = v978.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _v993 = v1004 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1005 : string = v978.ToString v992 
    let _v993 = v1005 
    #endif
#else
    let v1008 : string = v978.ToString v992 
    let _v993 = v1008 
    #endif
    let v1011 : string = _v993 
    let v1016 : string = $"{v991}{v1011}"
    let v1017 : (System.Guid -> string) = _.ToString()
    let v1018 : string = v1017 v0
    let v1021 : int32 = v797.Length
    let v1022 : int32 = v1016.Length
    let v1023 : int32 = v1021 + v1022
    let v1024 : (string -> int32) = String.length
    let v1025 : int32 = v1024 v1018
    let v1028 : int32 = v1023 |> int32 
    let v1035 : int32 = v1025 |> int32 
    let v1042 : int32 = v1035 - 1
    let v1043 : string = v1018.[int v1028..int v1042]
    let v1047 : string = $"{v797}{v1016}{v1043}"
    let v1048 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1049 : System.Guid = v1047 |> System.Guid 
    let _v1048 = v1049 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1052 : System.Guid = v1047 |> System.Guid 
    let _v1048 = v1052 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1055 : System.Guid = null |> unbox<System.Guid>
    let _v1048 = v1055 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1058 : System.Guid = v1047 |> System.Guid 
    let _v1048 = v1058 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1061 : System.Guid = v1047 |> System.Guid 
    let _v1048 = v1061 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1064 : System.Guid = v1047 |> System.Guid 
    let _v1048 = v1064 
    #endif
#else
    let v1067 : System.Guid = v1047 |> System.Guid 
    let _v1048 = v1067 
    #endif
    let v1070 : System.Guid = _v1048 
    let _v2 = v1070 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1075 : string = method70()
    let v1076 : bool = v1075 = ""
    let v1078 : string =
        if v1076 then
            let v1077 : string = "M-d-y hh:mm:ss tt"
            v1077
        else
            v1075
    let v1079 : (string -> string) = v1.ToString
    let v1080 : string = v1079 v1078
    let v1094 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1095 : string = "std::sync::Arc::new(chrono::FixedOffset::local_minus_utc(chrono::Local::now().offset()) as i64)"
    let v1096 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v1095 
    let _v1094 = v1096 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1097 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v1094 = v1097 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1100 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v1094 = v1100 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1103 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v1094 = v1103 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1106 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v1094 = v1106 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1109 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v1094 = v1109 
    #endif
#else
    let v1110 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v1094 = v1110 
    #endif
    let v1111 : System.TimeZoneInfo = _v1094 
    let v1116 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1117 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1118 : (System.DateTime -> int64) = _.Ticks
    let v1119 : int64 = v1118 v1
    let _v1117 = v1119 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1120 : (System.DateTime -> int64) = _.Ticks
    let v1121 : int64 = v1120 v1
    let _v1117 = v1121 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1122 : int64 = null |> unbox<int64>
    let _v1117 = v1122 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1125 : (System.DateTime -> int64) = _.Ticks
    let v1126 : int64 = v1125 v1
    let _v1117 = v1126 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1127 : (System.DateTime -> int64) = _.Ticks
    let v1128 : int64 = v1127 v1
    let _v1117 = v1128 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1129 : (System.DateTime -> int64) = _.Ticks
    let v1130 : int64 = v1129 v1
    let _v1117 = v1130 
    #endif
#else
    let v1131 : (System.DateTime -> int64) = _.Ticks
    let v1132 : int64 = v1131 v1
    let _v1117 = v1132 
    #endif
    let v1133 : int64 = _v1117 
    let v1150 : string = "chrono::FixedOffset::local_minus_utc(&chrono::DateTime::timezone(&chrono::DateTime::fixed_offset(&chrono::DateTime::from_timestamp_nanos($1))))"
    let v1151 : int32 = Fable.Core.RustInterop.emitRustExpr struct (v1, v1133) v1150 
    let v1152 : System.TimeSpan = v1151 |> System.TimeSpan 
    let _v1116 = v1152 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1155 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1156 : (System.DateTime -> int64) = _.Ticks
    let v1157 : int64 = v1156 v1
    let _v1155 = v1157 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1158 : (System.DateTime -> int64) = _.Ticks
    let v1159 : int64 = v1158 v1
    let _v1155 = v1159 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1160 : int64 = null |> unbox<int64>
    let _v1155 = v1160 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1163 : (System.DateTime -> int64) = _.Ticks
    let v1164 : int64 = v1163 v1
    let _v1155 = v1164 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1165 : (System.DateTime -> int64) = _.Ticks
    let v1166 : int64 = v1165 v1
    let _v1155 = v1166 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1167 : (System.DateTime -> int64) = _.Ticks
    let v1168 : int64 = v1167 v1
    let _v1155 = v1168 
    #endif
#else
    let v1169 : (System.DateTime -> int64) = _.Ticks
    let v1170 : int64 = v1169 v1
    let _v1155 = v1170 
    #endif
    let v1171 : int64 = _v1155 
    let v1188 : string = "chrono::FixedOffset::local_minus_utc(&chrono::DateTime::timezone(&chrono::DateTime::fixed_offset(&chrono::DateTime::from_timestamp_nanos($1))))"
    let v1189 : int32 = Fable.Core.RustInterop.emitRustExpr struct (v1, v1171) v1188 
    let v1190 : System.TimeSpan = v1189 |> System.TimeSpan 
    let _v1116 = v1190 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1193 : US3 = US3_2
    let v1194 : US4 = US4_2(v1193)
    let v1195 : string = $"date_time.get_utc_offset / target: {v1194}"
    let v1196 : System.TimeSpan = failwith<System.TimeSpan> v1195
    let _v1116 = v1196 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1199 : US3 = US3_0
    let v1200 : US4 = US4_3(v1199)
    let v1201 : string = $"date_time.get_utc_offset / target: {v1200}"
    let v1202 : System.TimeSpan = failwith<System.TimeSpan> v1201
    let _v1116 = v1202 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1205 : US3 = US3_0
    let v1206 : US4 = US4_4(v1205)
    let v1207 : string = $"date_time.get_utc_offset / target: {v1206}"
    let v1208 : System.TimeSpan = failwith<System.TimeSpan> v1207
    let _v1116 = v1208 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1211 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v1212 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1213 : string = "std::sync::Arc::new(chrono::FixedOffset::local_minus_utc(chrono::Local::now().offset()) as i64)"
    let v1214 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v1213 
    let _v1212 = v1214 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1215 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v1212 = v1215 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1218 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v1212 = v1218 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1221 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v1212 = v1221 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1224 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v1212 = v1224 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1227 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v1212 = v1227 
    #endif
#else
    let v1228 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v1212 = v1228 
    #endif
    let v1229 : System.TimeZoneInfo = _v1212 
    let v1234 : (System.DateTime -> System.TimeSpan) = v1211 v1229
    let v1235 : System.TimeSpan = v1234 v1
    let _v1116 = v1235 
    #endif
#else
    let v1236 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v1237 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1238 : string = "std::sync::Arc::new(chrono::FixedOffset::local_minus_utc(chrono::Local::now().offset()) as i64)"
    let v1239 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v1238 
    let _v1237 = v1239 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1240 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v1237 = v1240 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1243 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v1237 = v1243 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1246 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v1237 = v1246 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1249 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v1237 = v1249 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1252 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v1237 = v1252 
    #endif
#else
    let v1253 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v1237 = v1253 
    #endif
    let v1254 : System.TimeZoneInfo = _v1237 
    let v1259 : (System.DateTime -> System.TimeSpan) = v1236 v1254
    let v1260 : System.TimeSpan = v1259 v1
    let _v1116 = v1260 
    #endif
    let v1261 : System.TimeSpan = _v1116 
    let v1269 : (System.TimeSpan -> int32) = _.Hours
    let v1270 : int32 = v1269 v1261
    let v1273 : bool = v1270 > 0
    let v1274 : uint8 =
        if v1273 then
            1uy
        else
            0uy
    let v1275 : string = method71()
    let v1276 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1277 : string = v1261.ToString v1275 
    let _v1276 = v1277 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1280 : string = v1261.ToString v1275 
    let _v1276 = v1280 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1283 : string = v1261.ToString v1275 
    let _v1276 = v1283 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1286 : string = v1261.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _v1276 = v1286 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1287 : string = v1261.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _v1276 = v1287 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1288 : string = v1261.ToString v1275 
    let _v1276 = v1288 
    #endif
#else
    let v1291 : string = v1261.ToString v1275 
    let _v1276 = v1291 
    #endif
    let v1294 : string = _v1276 
    let v1299 : string = $"{v1274}{v1294}"
    let v1300 : (System.Guid -> string) = _.ToString()
    let v1301 : string = v1300 v0
    let v1304 : int32 = v1080.Length
    let v1305 : int32 = v1299.Length
    let v1306 : int32 = v1304 + v1305
    let v1307 : (string -> int32) = String.length
    let v1308 : int32 = v1307 v1301
    let v1311 : int32 = v1306 |> int32 
    let v1318 : int32 = v1308 |> int32 
    let v1325 : int32 = v1318 - 1
    let v1326 : string = v1301.[int v1311..int v1325]
    let v1330 : string = $"{v1080}{v1299}{v1326}"
    let v1331 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1332 : System.Guid = v1330 |> System.Guid 
    let _v1331 = v1332 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1335 : System.Guid = v1330 |> System.Guid 
    let _v1331 = v1335 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1338 : System.Guid = null |> unbox<System.Guid>
    let _v1331 = v1338 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1341 : System.Guid = v1330 |> System.Guid 
    let _v1331 = v1341 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1344 : System.Guid = v1330 |> System.Guid 
    let _v1331 = v1344 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1347 : System.Guid = v1330 |> System.Guid 
    let _v1331 = v1347 
    #endif
#else
    let v1350 : System.Guid = v1330 |> System.Guid 
    let _v1331 = v1350 
    #endif
    let v1353 : System.Guid = _v1331 
    let _v2 = v1353 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1358 : string = method70()
    let v1359 : bool = v1358 = ""
    let v1361 : string =
        if v1359 then
            let v1360 : string = "M-d-y hh:mm:ss tt"
            v1360
        else
            v1358
    let v1362 : (string -> string) = v1.ToString
    let v1363 : string = v1362 v1361
    let v1377 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1378 : string = "std::sync::Arc::new(chrono::FixedOffset::local_minus_utc(chrono::Local::now().offset()) as i64)"
    let v1379 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v1378 
    let _v1377 = v1379 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1380 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v1377 = v1380 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1383 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v1377 = v1383 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1386 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v1377 = v1386 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1389 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v1377 = v1389 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1392 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v1377 = v1392 
    #endif
#else
    let v1393 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v1377 = v1393 
    #endif
    let v1394 : System.TimeZoneInfo = _v1377 
    let v1399 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1400 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1401 : (System.DateTime -> int64) = _.Ticks
    let v1402 : int64 = v1401 v1
    let _v1400 = v1402 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1403 : (System.DateTime -> int64) = _.Ticks
    let v1404 : int64 = v1403 v1
    let _v1400 = v1404 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1405 : int64 = null |> unbox<int64>
    let _v1400 = v1405 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1408 : (System.DateTime -> int64) = _.Ticks
    let v1409 : int64 = v1408 v1
    let _v1400 = v1409 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1410 : (System.DateTime -> int64) = _.Ticks
    let v1411 : int64 = v1410 v1
    let _v1400 = v1411 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1412 : (System.DateTime -> int64) = _.Ticks
    let v1413 : int64 = v1412 v1
    let _v1400 = v1413 
    #endif
#else
    let v1414 : (System.DateTime -> int64) = _.Ticks
    let v1415 : int64 = v1414 v1
    let _v1400 = v1415 
    #endif
    let v1416 : int64 = _v1400 
    let v1433 : string = "chrono::FixedOffset::local_minus_utc(&chrono::DateTime::timezone(&chrono::DateTime::fixed_offset(&chrono::DateTime::from_timestamp_nanos($1))))"
    let v1434 : int32 = Fable.Core.RustInterop.emitRustExpr struct (v1, v1416) v1433 
    let v1435 : System.TimeSpan = v1434 |> System.TimeSpan 
    let _v1399 = v1435 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1438 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1439 : (System.DateTime -> int64) = _.Ticks
    let v1440 : int64 = v1439 v1
    let _v1438 = v1440 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1441 : (System.DateTime -> int64) = _.Ticks
    let v1442 : int64 = v1441 v1
    let _v1438 = v1442 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1443 : int64 = null |> unbox<int64>
    let _v1438 = v1443 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1446 : (System.DateTime -> int64) = _.Ticks
    let v1447 : int64 = v1446 v1
    let _v1438 = v1447 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1448 : (System.DateTime -> int64) = _.Ticks
    let v1449 : int64 = v1448 v1
    let _v1438 = v1449 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1450 : (System.DateTime -> int64) = _.Ticks
    let v1451 : int64 = v1450 v1
    let _v1438 = v1451 
    #endif
#else
    let v1452 : (System.DateTime -> int64) = _.Ticks
    let v1453 : int64 = v1452 v1
    let _v1438 = v1453 
    #endif
    let v1454 : int64 = _v1438 
    let v1471 : string = "chrono::FixedOffset::local_minus_utc(&chrono::DateTime::timezone(&chrono::DateTime::fixed_offset(&chrono::DateTime::from_timestamp_nanos($1))))"
    let v1472 : int32 = Fable.Core.RustInterop.emitRustExpr struct (v1, v1454) v1471 
    let v1473 : System.TimeSpan = v1472 |> System.TimeSpan 
    let _v1399 = v1473 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1476 : US3 = US3_2
    let v1477 : US4 = US4_2(v1476)
    let v1478 : string = $"date_time.get_utc_offset / target: {v1477}"
    let v1479 : System.TimeSpan = failwith<System.TimeSpan> v1478
    let _v1399 = v1479 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1482 : US3 = US3_0
    let v1483 : US4 = US4_3(v1482)
    let v1484 : string = $"date_time.get_utc_offset / target: {v1483}"
    let v1485 : System.TimeSpan = failwith<System.TimeSpan> v1484
    let _v1399 = v1485 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1488 : US3 = US3_0
    let v1489 : US4 = US4_4(v1488)
    let v1490 : string = $"date_time.get_utc_offset / target: {v1489}"
    let v1491 : System.TimeSpan = failwith<System.TimeSpan> v1490
    let _v1399 = v1491 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1494 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v1495 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1496 : string = "std::sync::Arc::new(chrono::FixedOffset::local_minus_utc(chrono::Local::now().offset()) as i64)"
    let v1497 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v1496 
    let _v1495 = v1497 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1498 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v1495 = v1498 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1501 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v1495 = v1501 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1504 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v1495 = v1504 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1507 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v1495 = v1507 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1510 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v1495 = v1510 
    #endif
#else
    let v1511 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v1495 = v1511 
    #endif
    let v1512 : System.TimeZoneInfo = _v1495 
    let v1517 : (System.DateTime -> System.TimeSpan) = v1494 v1512
    let v1518 : System.TimeSpan = v1517 v1
    let _v1399 = v1518 
    #endif
#else
    let v1519 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v1520 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1521 : string = "std::sync::Arc::new(chrono::FixedOffset::local_minus_utc(chrono::Local::now().offset()) as i64)"
    let v1522 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v1521 
    let _v1520 = v1522 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1523 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v1520 = v1523 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1526 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v1520 = v1526 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1529 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v1520 = v1529 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1532 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v1520 = v1532 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1535 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v1520 = v1535 
    #endif
#else
    let v1536 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v1520 = v1536 
    #endif
    let v1537 : System.TimeZoneInfo = _v1520 
    let v1542 : (System.DateTime -> System.TimeSpan) = v1519 v1537
    let v1543 : System.TimeSpan = v1542 v1
    let _v1399 = v1543 
    #endif
    let v1544 : System.TimeSpan = _v1399 
    let v1552 : (System.TimeSpan -> int32) = _.Hours
    let v1553 : int32 = v1552 v1544
    let v1556 : bool = v1553 > 0
    let v1557 : uint8 =
        if v1556 then
            1uy
        else
            0uy
    let v1558 : string = method71()
    let v1559 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1560 : string = v1544.ToString v1558 
    let _v1559 = v1560 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1563 : string = v1544.ToString v1558 
    let _v1559 = v1563 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1566 : string = v1544.ToString v1558 
    let _v1559 = v1566 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1569 : string = v1544.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _v1559 = v1569 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1570 : string = v1544.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _v1559 = v1570 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1571 : string = v1544.ToString v1558 
    let _v1559 = v1571 
    #endif
#else
    let v1574 : string = v1544.ToString v1558 
    let _v1559 = v1574 
    #endif
    let v1577 : string = _v1559 
    let v1582 : string = $"{v1557}{v1577}"
    let v1583 : (System.Guid -> string) = _.ToString()
    let v1584 : string = v1583 v0
    let v1587 : int32 = v1363.Length
    let v1588 : int32 = v1582.Length
    let v1589 : int32 = v1587 + v1588
    let v1590 : (string -> int32) = String.length
    let v1591 : int32 = v1590 v1584
    let v1594 : int32 = v1589 |> int32 
    let v1601 : int32 = v1591 |> int32 
    let v1608 : int32 = v1601 - 1
    let v1609 : string = v1584.[int v1594..int v1608]
    let v1613 : string = $"{v1363}{v1582}{v1609}"
    let v1614 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1615 : System.Guid = v1613 |> System.Guid 
    let _v1614 = v1615 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1618 : System.Guid = v1613 |> System.Guid 
    let _v1614 = v1618 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1621 : System.Guid = null |> unbox<System.Guid>
    let _v1614 = v1621 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1624 : System.Guid = v1613 |> System.Guid 
    let _v1614 = v1624 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1627 : System.Guid = v1613 |> System.Guid 
    let _v1614 = v1627 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1630 : System.Guid = v1613 |> System.Guid 
    let _v1614 = v1630 
    #endif
#else
    let v1633 : System.Guid = v1613 |> System.Guid 
    let _v1614 = v1633 
    #endif
    let v1636 : System.Guid = _v1614 
    let _v2 = v1636 
    #endif
#else
    let v1641 : string = method70()
    let v1642 : bool = v1641 = ""
    let v1644 : string =
        if v1642 then
            let v1643 : string = "M-d-y hh:mm:ss tt"
            v1643
        else
            v1641
    let v1645 : (string -> string) = v1.ToString
    let v1646 : string = v1645 v1644
    let v1660 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1661 : string = "std::sync::Arc::new(chrono::FixedOffset::local_minus_utc(chrono::Local::now().offset()) as i64)"
    let v1662 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v1661 
    let _v1660 = v1662 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1663 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v1660 = v1663 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1666 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v1660 = v1666 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1669 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v1660 = v1669 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1672 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v1660 = v1672 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1675 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v1660 = v1675 
    #endif
#else
    let v1676 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v1660 = v1676 
    #endif
    let v1677 : System.TimeZoneInfo = _v1660 
    let v1682 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1683 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1684 : (System.DateTime -> int64) = _.Ticks
    let v1685 : int64 = v1684 v1
    let _v1683 = v1685 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1686 : (System.DateTime -> int64) = _.Ticks
    let v1687 : int64 = v1686 v1
    let _v1683 = v1687 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1688 : int64 = null |> unbox<int64>
    let _v1683 = v1688 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1691 : (System.DateTime -> int64) = _.Ticks
    let v1692 : int64 = v1691 v1
    let _v1683 = v1692 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1693 : (System.DateTime -> int64) = _.Ticks
    let v1694 : int64 = v1693 v1
    let _v1683 = v1694 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1695 : (System.DateTime -> int64) = _.Ticks
    let v1696 : int64 = v1695 v1
    let _v1683 = v1696 
    #endif
#else
    let v1697 : (System.DateTime -> int64) = _.Ticks
    let v1698 : int64 = v1697 v1
    let _v1683 = v1698 
    #endif
    let v1699 : int64 = _v1683 
    let v1716 : string = "chrono::FixedOffset::local_minus_utc(&chrono::DateTime::timezone(&chrono::DateTime::fixed_offset(&chrono::DateTime::from_timestamp_nanos($1))))"
    let v1717 : int32 = Fable.Core.RustInterop.emitRustExpr struct (v1, v1699) v1716 
    let v1718 : System.TimeSpan = v1717 |> System.TimeSpan 
    let _v1682 = v1718 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1721 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1722 : (System.DateTime -> int64) = _.Ticks
    let v1723 : int64 = v1722 v1
    let _v1721 = v1723 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1724 : (System.DateTime -> int64) = _.Ticks
    let v1725 : int64 = v1724 v1
    let _v1721 = v1725 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1726 : int64 = null |> unbox<int64>
    let _v1721 = v1726 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1729 : (System.DateTime -> int64) = _.Ticks
    let v1730 : int64 = v1729 v1
    let _v1721 = v1730 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1731 : (System.DateTime -> int64) = _.Ticks
    let v1732 : int64 = v1731 v1
    let _v1721 = v1732 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1733 : (System.DateTime -> int64) = _.Ticks
    let v1734 : int64 = v1733 v1
    let _v1721 = v1734 
    #endif
#else
    let v1735 : (System.DateTime -> int64) = _.Ticks
    let v1736 : int64 = v1735 v1
    let _v1721 = v1736 
    #endif
    let v1737 : int64 = _v1721 
    let v1754 : string = "chrono::FixedOffset::local_minus_utc(&chrono::DateTime::timezone(&chrono::DateTime::fixed_offset(&chrono::DateTime::from_timestamp_nanos($1))))"
    let v1755 : int32 = Fable.Core.RustInterop.emitRustExpr struct (v1, v1737) v1754 
    let v1756 : System.TimeSpan = v1755 |> System.TimeSpan 
    let _v1682 = v1756 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1759 : US3 = US3_2
    let v1760 : US4 = US4_2(v1759)
    let v1761 : string = $"date_time.get_utc_offset / target: {v1760}"
    let v1762 : System.TimeSpan = failwith<System.TimeSpan> v1761
    let _v1682 = v1762 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1765 : US3 = US3_0
    let v1766 : US4 = US4_3(v1765)
    let v1767 : string = $"date_time.get_utc_offset / target: {v1766}"
    let v1768 : System.TimeSpan = failwith<System.TimeSpan> v1767
    let _v1682 = v1768 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1771 : US3 = US3_0
    let v1772 : US4 = US4_4(v1771)
    let v1773 : string = $"date_time.get_utc_offset / target: {v1772}"
    let v1774 : System.TimeSpan = failwith<System.TimeSpan> v1773
    let _v1682 = v1774 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1777 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v1778 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1779 : string = "std::sync::Arc::new(chrono::FixedOffset::local_minus_utc(chrono::Local::now().offset()) as i64)"
    let v1780 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v1779 
    let _v1778 = v1780 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1781 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v1778 = v1781 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1784 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v1778 = v1784 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1787 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v1778 = v1787 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1790 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v1778 = v1790 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1793 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v1778 = v1793 
    #endif
#else
    let v1794 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v1778 = v1794 
    #endif
    let v1795 : System.TimeZoneInfo = _v1778 
    let v1800 : (System.DateTime -> System.TimeSpan) = v1777 v1795
    let v1801 : System.TimeSpan = v1800 v1
    let _v1682 = v1801 
    #endif
#else
    let v1802 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v1803 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1804 : string = "std::sync::Arc::new(chrono::FixedOffset::local_minus_utc(chrono::Local::now().offset()) as i64)"
    let v1805 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v1804 
    let _v1803 = v1805 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1806 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v1803 = v1806 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1809 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v1803 = v1809 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1812 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v1803 = v1812 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1815 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v1803 = v1815 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1818 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v1803 = v1818 
    #endif
#else
    let v1819 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v1803 = v1819 
    #endif
    let v1820 : System.TimeZoneInfo = _v1803 
    let v1825 : (System.DateTime -> System.TimeSpan) = v1802 v1820
    let v1826 : System.TimeSpan = v1825 v1
    let _v1682 = v1826 
    #endif
    let v1827 : System.TimeSpan = _v1682 
    let v1835 : (System.TimeSpan -> int32) = _.Hours
    let v1836 : int32 = v1835 v1827
    let v1839 : bool = v1836 > 0
    let v1840 : uint8 =
        if v1839 then
            1uy
        else
            0uy
    let v1841 : string = method71()
    let v1842 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1843 : string = v1827.ToString v1841 
    let _v1842 = v1843 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1846 : string = v1827.ToString v1841 
    let _v1842 = v1846 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1849 : string = v1827.ToString v1841 
    let _v1842 = v1849 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1852 : string = v1827.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _v1842 = v1852 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1853 : string = v1827.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _v1842 = v1853 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1854 : string = v1827.ToString v1841 
    let _v1842 = v1854 
    #endif
#else
    let v1857 : string = v1827.ToString v1841 
    let _v1842 = v1857 
    #endif
    let v1860 : string = _v1842 
    let v1865 : string = $"{v1840}{v1860}"
    let v1866 : (System.Guid -> string) = _.ToString()
    let v1867 : string = v1866 v0
    let v1870 : int32 = v1646.Length
    let v1871 : int32 = v1865.Length
    let v1872 : int32 = v1870 + v1871
    let v1873 : (string -> int32) = String.length
    let v1874 : int32 = v1873 v1867
    let v1877 : int32 = v1872 |> int32 
    let v1884 : int32 = v1874 |> int32 
    let v1891 : int32 = v1884 - 1
    let v1892 : string = v1867.[int v1877..int v1891]
    let v1896 : string = $"{v1646}{v1865}{v1892}"
    let v1897 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1898 : System.Guid = v1896 |> System.Guid 
    let _v1897 = v1898 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1901 : System.Guid = v1896 |> System.Guid 
    let _v1897 = v1901 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1904 : System.Guid = null |> unbox<System.Guid>
    let _v1897 = v1904 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1907 : System.Guid = v1896 |> System.Guid 
    let _v1897 = v1907 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1910 : System.Guid = v1896 |> System.Guid 
    let _v1897 = v1910 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1913 : System.Guid = v1896 |> System.Guid 
    let _v1897 = v1913 
    #endif
#else
    let v1916 : System.Guid = v1896 |> System.Guid 
    let _v1897 = v1916 
    #endif
    let v1919 : System.Guid = _v1897 
    let _v2 = v1919 
    #endif
    let v1924 : System.Guid = _v2 
    v1924
and method73 () : string =
    let v0 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1 : string = "std::env::temp_dir()"
    let v2 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr () v1 
    let v3 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v4 : string = "$0.display()"
    let v5 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v2 v4 
    let _v3 = v5 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v6 : string = "$0.display()"
    let v7 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v2 v6 
    let _v3 = v7 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v8 : string = "$0.display()"
    let v9 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v2 v8 
    let _v3 = v9 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v10 : std_path_Display = v2 |> unbox<std_path_Display>
    let _v3 = v10 
    #endif
#if FABLE_COMPILER_PYTHON
    let v13 : std_path_Display = v2 |> unbox<std_path_Display>
    let _v3 = v13 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v16 : std_path_Display = v2 |> unbox<std_path_Display>
    let _v3 = v16 
    #endif
#else
    let v19 : std_path_Display = v2 |> unbox<std_path_Display>
    let _v3 = v19 
    #endif
    let v22 : std_path_Display = _v3 
    let v27 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v28 : string = "format!(\"{}\", $0)"
    let v29 : std_string_String = Fable.Core.RustInterop.emitRustExpr v22 v28 
    let _v27 = v29 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v30 : string = "format!(\"{}\", $0)"
    let v31 : std_string_String = Fable.Core.RustInterop.emitRustExpr v22 v30 
    let _v27 = v31 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v32 : string = "format!(\"{}\", $0)"
    let v33 : std_string_String = Fable.Core.RustInterop.emitRustExpr v22 v32 
    let _v27 = v33 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v34 : std_string_String = null |> unbox<std_string_String>
    let _v27 = v34 
    #endif
#if FABLE_COMPILER_PYTHON
    let v37 : std_string_String = null |> unbox<std_string_String>
    let _v27 = v37 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v40 : std_string_String = null |> unbox<std_string_String>
    let _v27 = v40 
    #endif
#else
    let v43 : std_string_String = null |> unbox<std_string_String>
    let _v27 = v43 
    #endif
    let v46 : std_string_String = _v27 
    let v51 : string = "fable_library_rust::String_::fromString($0)"
    let v52 : string = Fable.Core.RustInterop.emitRustExpr v46 v51 
    let _v0 = v52 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v53 : US3 = US3_1
    let v54 : US4 = US4_2(v53)
    let v55 : string = $"file_system.get_temp_path / target: {v54}"
    let v56 : string = failwith<string> v55
    let _v0 = v56 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v57 : string = null |> unbox<string>
    let _v0 = v57 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v60 : US3 = US3_0
    let v61 : US4 = US4_3(v60)
    let v62 : string = $"file_system.get_temp_path / target: {v61}"
    let v63 : string = failwith<string> v62
    let _v0 = v63 
    #endif
#if FABLE_COMPILER_PYTHON
    let v64 : US3 = US3_0
    let v65 : US4 = US4_4(v64)
    let v66 : string = $"file_system.get_temp_path / target: {v65}"
    let v67 : string = failwith<string> v66
    let _v0 = v67 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v68 : US3 = US3_1
    let v69 : US4 = US4_0(v68)
    let v70 : string = $"file_system.get_temp_path / target: {v69}"
    let v71 : string = failwith<string> v70
    let _v0 = v71 
    #endif
#else
    let v72 : (unit -> string) = System.IO.Path.GetTempPath
    let v73 : string = v72 ()
    let _v0 = v73 
    #endif
    let v74 : string = _v0 
    v74
and method74 () : string =
    let v0 : string = "!create_temp_path_"
    v0
and method75 (v0 : string, v1 : string) : string =
    let v2 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v4 : string = "&*$0"
    let v5 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v4 
    let _v3 = v5 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v6 : string = "&*$0"
    let v7 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v6 
    let _v3 = v7 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v8 : string = "&*$0"
    let v9 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v8 
    let _v3 = v9 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v10 : Ref<Str> = v0 |> unbox<Ref<Str>>
    let _v3 = v10 
    #endif
#if FABLE_COMPILER_PYTHON
    let v13 : Ref<Str> = v0 |> unbox<Ref<Str>>
    let _v3 = v13 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v16 : Ref<Str> = v0 |> unbox<Ref<Str>>
    let _v3 = v16 
    #endif
#else
    let v19 : Ref<Str> = v0 |> unbox<Ref<Str>>
    let _v3 = v19 
    #endif
    let v22 : Ref<Str> = _v3 
    let v27 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v28 : string = "String::from($0)"
    let v29 : std_string_String = Fable.Core.RustInterop.emitRustExpr v22 v28 
    let _v27 = v29 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v30 : string = "String::from($0)"
    let v31 : std_string_String = Fable.Core.RustInterop.emitRustExpr v22 v30 
    let _v27 = v31 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v32 : string = "String::from($0)"
    let v33 : std_string_String = Fable.Core.RustInterop.emitRustExpr v22 v32 
    let _v27 = v33 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v34 : std_string_String = v22 |> unbox<std_string_String>
    let _v27 = v34 
    #endif
#if FABLE_COMPILER_PYTHON
    let v37 : std_string_String = v22 |> unbox<std_string_String>
    let _v27 = v37 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v40 : std_string_String = v22 |> unbox<std_string_String>
    let _v27 = v40 
    #endif
#else
    let v43 : std_string_String = v22 |> unbox<std_string_String>
    let _v27 = v43 
    #endif
    let v46 : std_string_String = _v27 
    let v51 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v52 : string = "std::path::PathBuf::from($0)"
    let v53 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v46 v52 
    let _v51 = v53 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v54 : string = "std::path::PathBuf::from($0)"
    let v55 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v46 v54 
    let _v51 = v55 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v56 : string = "std::path::PathBuf::from($0)"
    let v57 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v46 v56 
    let _v51 = v57 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v58 : std_path_PathBuf = v46 |> unbox<std_path_PathBuf>
    let _v51 = v58 
    #endif
#if FABLE_COMPILER_PYTHON
    let v61 : std_path_PathBuf = v46 |> unbox<std_path_PathBuf>
    let _v51 = v61 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v64 : std_path_PathBuf = v46 |> unbox<std_path_PathBuf>
    let _v51 = v64 
    #endif
#else
    let v67 : std_path_PathBuf = v46 |> unbox<std_path_PathBuf>
    let _v51 = v67 
    #endif
    let v70 : std_path_PathBuf = _v51 
    let v75 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v76 : string = "&*$0"
    let v77 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1 v76 
    let _v75 = v77 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v78 : string = "&*$0"
    let v79 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1 v78 
    let _v75 = v79 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v80 : string = "&*$0"
    let v81 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1 v80 
    let _v75 = v81 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v82 : Ref<Str> = v1 |> unbox<Ref<Str>>
    let _v75 = v82 
    #endif
#if FABLE_COMPILER_PYTHON
    let v85 : Ref<Str> = v1 |> unbox<Ref<Str>>
    let _v75 = v85 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v88 : Ref<Str> = v1 |> unbox<Ref<Str>>
    let _v75 = v88 
    #endif
#else
    let v91 : Ref<Str> = v1 |> unbox<Ref<Str>>
    let _v75 = v91 
    #endif
    let v94 : Ref<Str> = _v75 
    let v99 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v100 : string = "String::from($0)"
    let v101 : std_string_String = Fable.Core.RustInterop.emitRustExpr v94 v100 
    let _v99 = v101 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v102 : string = "String::from($0)"
    let v103 : std_string_String = Fable.Core.RustInterop.emitRustExpr v94 v102 
    let _v99 = v103 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v104 : string = "String::from($0)"
    let v105 : std_string_String = Fable.Core.RustInterop.emitRustExpr v94 v104 
    let _v99 = v105 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v106 : std_string_String = v94 |> unbox<std_string_String>
    let _v99 = v106 
    #endif
#if FABLE_COMPILER_PYTHON
    let v109 : std_string_String = v94 |> unbox<std_string_String>
    let _v99 = v109 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v112 : std_string_String = v94 |> unbox<std_string_String>
    let _v99 = v112 
    #endif
#else
    let v115 : std_string_String = v94 |> unbox<std_string_String>
    let _v99 = v115 
    #endif
    let v118 : std_string_String = _v99 
    let v123 : string = "$0.join($1)"
    let v124 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr struct (v70, v118) v123 
    let v125 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v126 : string = "$0.display()"
    let v127 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v124 v126 
    let _v125 = v127 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v128 : string = "$0.display()"
    let v129 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v124 v128 
    let _v125 = v129 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v130 : string = "$0.display()"
    let v131 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v124 v130 
    let _v125 = v131 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v132 : std_path_Display = v124 |> unbox<std_path_Display>
    let _v125 = v132 
    #endif
#if FABLE_COMPILER_PYTHON
    let v135 : std_path_Display = v124 |> unbox<std_path_Display>
    let _v125 = v135 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v138 : std_path_Display = v124 |> unbox<std_path_Display>
    let _v125 = v138 
    #endif
#else
    let v141 : std_path_Display = v124 |> unbox<std_path_Display>
    let _v125 = v141 
    #endif
    let v144 : std_path_Display = _v125 
    let v149 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v150 : string = "format!(\"{}\", $0)"
    let v151 : std_string_String = Fable.Core.RustInterop.emitRustExpr v144 v150 
    let _v149 = v151 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v152 : string = "format!(\"{}\", $0)"
    let v153 : std_string_String = Fable.Core.RustInterop.emitRustExpr v144 v152 
    let _v149 = v153 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v154 : string = "format!(\"{}\", $0)"
    let v155 : std_string_String = Fable.Core.RustInterop.emitRustExpr v144 v154 
    let _v149 = v155 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v156 : std_string_String = null |> unbox<std_string_String>
    let _v149 = v156 
    #endif
#if FABLE_COMPILER_PYTHON
    let v159 : std_string_String = null |> unbox<std_string_String>
    let _v149 = v159 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v162 : std_string_String = null |> unbox<std_string_String>
    let _v149 = v162 
    #endif
#else
    let v165 : std_string_String = null |> unbox<std_string_String>
    let _v149 = v165 
    #endif
    let v168 : std_string_String = _v149 
    let v173 : string = "fable_library_rust::String_::fromString($0)"
    let v174 : string = Fable.Core.RustInterop.emitRustExpr v168 v173 
    let _v2 = v174 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v175 : US3 = US3_1
    let v176 : US4 = US4_2(v175)
    let v177 : string = $"file_system.(</>) / target: {v176} / a: {v0} / b: {v1}"
    let v178 : string = failwith<string> v177
    let _v2 = v178 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v179 : string = null |> unbox<string>
    let _v2 = v179 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v182 : string = "path"
    let v183 : IPathJoin = Fable.Core.JsInterop.importAll v182 
    let v184 : string = "v183.join($0, $1)"
    let v185 : string = Fable.Core.JsInterop.emitJsExpr struct (v0, v1) v184 
    let _v2 = v185 
    #endif
#if FABLE_COMPILER_PYTHON
    let v186 : US3 = US3_0
    let v187 : US4 = US4_4(v186)
    let v188 : string = $"file_system.(</>) / target: {v187} / a: {v0} / b: {v1}"
    let v189 : string = failwith<string> v188
    let _v2 = v189 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v190 : US3 = US3_1
    let v191 : US4 = US4_0(v190)
    let v192 : string = $"file_system.(</>) / target: {v191} / a: {v0} / b: {v1}"
    let v193 : string = failwith<string> v192
    let _v2 = v193 
    #endif
#else
    let v194 : string = System.IO.Path.Combine (v0, v1)
    let _v2 = v194 
    #endif
    let v195 : string = _v2 
    v195
and method77 () : string =
    let v0 : string = "CARGO_PKG_NAME"
    v0
and method76 () : string =
    let v0 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1 : string = method77()
    let v2 : string = method2(v1)
    let _v0 = v2 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v3 : string = method77()
    let v4 : string = method2(v3)
    let _v0 = v4 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v5 : string = method77()
    let v6 : string = method2(v5)
    let _v0 = v6 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v7 : US3 = US3_0
    let v8 : US4 = US4_3(v7)
    let v9 : string = $"env.get_entry_assembly_name / target: {v8}"
    let v10 : string = failwith<string> v9
    let _v0 = v10 
    #endif
#if FABLE_COMPILER_PYTHON
    let v11 : US3 = US3_0
    let v12 : US4 = US4_4(v11)
    let v13 : string = $"env.get_entry_assembly_name / target: {v12}"
    let v14 : string = failwith<string> v13
    let _v0 = v14 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v15 : string = System.Reflection.Assembly.GetEntryAssembly().GetName().Name
    let _v0 = v15 
    #endif
#else
    let v16 : string = System.Reflection.Assembly.GetEntryAssembly().GetName().Name
    let _v0 = v16 
    #endif
    let v17 : string = _v0 
    v17
and method72 (v0 : System.Guid) : string =
    let v1 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = method73()
    let v3 : string = method74()
    let v4 : string = method75(v2, v3)
    let v5 : string = method76()
    let v6 : string = method75(v4, v5)
    let v7 : (System.Guid -> string) = _.ToString()
    let v8 : string = v7 v0
    let v11 : string = method75(v6, v8)
    let _v1 = v11 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v12 : string = method73()
    let v13 : string = method74()
    let v14 : string = method75(v12, v13)
    let v15 : string = method76()
    let v16 : string = method75(v14, v15)
    let v17 : (System.Guid -> string) = _.ToString()
    let v18 : string = v17 v0
    let v21 : string = method75(v16, v18)
    let _v1 = v21 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v22 : string = null |> unbox<string>
    let _v1 = v22 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v25 : string = method73()
    let v26 : string = method74()
    let v27 : string = method75(v25, v26)
    let v28 : string = method76()
    let v29 : string = method75(v27, v28)
    let v30 : (System.Guid -> string) = _.ToString()
    let v31 : string = v30 v0
    let v34 : string = method75(v29, v31)
    let _v1 = v34 
    #endif
#if FABLE_COMPILER_PYTHON
    let v35 : string = method73()
    let v36 : string = method74()
    let v37 : string = method75(v35, v36)
    let v38 : string = method76()
    let v39 : string = method75(v37, v38)
    let v40 : (System.Guid -> string) = _.ToString()
    let v41 : string = v40 v0
    let v44 : string = method75(v39, v41)
    let _v1 = v44 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v45 : string = method73()
    let v46 : string = method74()
    let v47 : string = method75(v45, v46)
    let v48 : string = method76()
    let v49 : string = method75(v47, v48)
    let v50 : (System.Guid -> string) = _.ToString()
    let v51 : string = v50 v0
    let v54 : string = method75(v49, v51)
    let _v1 = v54 
    #endif
#else
    let v55 : string = method73()
    let v56 : string = method74()
    let v57 : string = method75(v55, v56)
    let v58 : string = method76()
    let v59 : string = method75(v57, v58)
    let v60 : (System.Guid -> string) = _.ToString()
    let v61 : string = v60 v0
    let v64 : string = method75(v59, v61)
    let _v1 = v64 
    #endif
    let v65 : string = _v1 
    v65
and method66 () : string =
    let v0 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : System.DateTime = System.DateTime.Now
    let _v1 = v2 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v3 : System.DateTime = System.DateTime.Now
    let _v1 = v3 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v4 : System.DateTime = null |> unbox<System.DateTime>
    let _v1 = v4 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v7 : System.DateTime = System.DateTime.Now
    let _v1 = v7 
    #endif
#if FABLE_COMPILER_PYTHON
    let v8 : System.DateTime = System.DateTime.Now
    let _v1 = v8 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v9 : System.DateTime = System.DateTime.Now
    let _v1 = v9 
    #endif
#else
    let v10 : System.DateTime = System.DateTime.Now
    let _v1 = v10 
    #endif
    let v11 : System.DateTime = _v1 
    let v16 : (unit -> System.Guid) = System.Guid.NewGuid
    let v17 : System.Guid = v16 ()
    let v20 : System.Guid = method67(v17, v11)
    let v21 : string = method72(v20)
    let _v0 = v21 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v22 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v23 : System.DateTime = System.DateTime.Now
    let _v22 = v23 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v24 : System.DateTime = System.DateTime.Now
    let _v22 = v24 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v25 : System.DateTime = null |> unbox<System.DateTime>
    let _v22 = v25 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v28 : System.DateTime = System.DateTime.Now
    let _v22 = v28 
    #endif
#if FABLE_COMPILER_PYTHON
    let v29 : System.DateTime = System.DateTime.Now
    let _v22 = v29 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v30 : System.DateTime = System.DateTime.Now
    let _v22 = v30 
    #endif
#else
    let v31 : System.DateTime = System.DateTime.Now
    let _v22 = v31 
    #endif
    let v32 : System.DateTime = _v22 
    let v37 : (unit -> System.Guid) = System.Guid.NewGuid
    let v38 : System.Guid = v37 ()
    let v41 : System.Guid = method67(v38, v32)
    let v42 : string = method72(v41)
    let _v0 = v42 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v43 : string = null |> unbox<string>
    let _v0 = v43 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v46 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v47 : System.DateTime = System.DateTime.Now
    let _v46 = v47 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v48 : System.DateTime = System.DateTime.Now
    let _v46 = v48 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v49 : System.DateTime = null |> unbox<System.DateTime>
    let _v46 = v49 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v52 : System.DateTime = System.DateTime.Now
    let _v46 = v52 
    #endif
#if FABLE_COMPILER_PYTHON
    let v53 : System.DateTime = System.DateTime.Now
    let _v46 = v53 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v54 : System.DateTime = System.DateTime.Now
    let _v46 = v54 
    #endif
#else
    let v55 : System.DateTime = System.DateTime.Now
    let _v46 = v55 
    #endif
    let v56 : System.DateTime = _v46 
    let v61 : (unit -> System.Guid) = System.Guid.NewGuid
    let v62 : System.Guid = v61 ()
    let v65 : System.Guid = method67(v62, v56)
    let v66 : string = method72(v65)
    let _v0 = v66 
    #endif
#if FABLE_COMPILER_PYTHON
    let v67 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v68 : System.DateTime = System.DateTime.Now
    let _v67 = v68 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v69 : System.DateTime = System.DateTime.Now
    let _v67 = v69 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v70 : System.DateTime = null |> unbox<System.DateTime>
    let _v67 = v70 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v73 : System.DateTime = System.DateTime.Now
    let _v67 = v73 
    #endif
#if FABLE_COMPILER_PYTHON
    let v74 : System.DateTime = System.DateTime.Now
    let _v67 = v74 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v75 : System.DateTime = System.DateTime.Now
    let _v67 = v75 
    #endif
#else
    let v76 : System.DateTime = System.DateTime.Now
    let _v67 = v76 
    #endif
    let v77 : System.DateTime = _v67 
    let v82 : (unit -> System.Guid) = System.Guid.NewGuid
    let v83 : System.Guid = v82 ()
    let v86 : System.Guid = method67(v83, v77)
    let v87 : string = method72(v86)
    let _v0 = v87 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v88 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v89 : System.DateTime = System.DateTime.Now
    let _v88 = v89 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v90 : System.DateTime = System.DateTime.Now
    let _v88 = v90 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v91 : System.DateTime = null |> unbox<System.DateTime>
    let _v88 = v91 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v94 : System.DateTime = System.DateTime.Now
    let _v88 = v94 
    #endif
#if FABLE_COMPILER_PYTHON
    let v95 : System.DateTime = System.DateTime.Now
    let _v88 = v95 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v96 : System.DateTime = System.DateTime.Now
    let _v88 = v96 
    #endif
#else
    let v97 : System.DateTime = System.DateTime.Now
    let _v88 = v97 
    #endif
    let v98 : System.DateTime = _v88 
    let v103 : (unit -> System.Guid) = System.Guid.NewGuid
    let v104 : System.Guid = v103 ()
    let v107 : System.Guid = method67(v104, v98)
    let v108 : string = method72(v107)
    let _v0 = v108 
    #endif
#else
    let v109 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v110 : System.DateTime = System.DateTime.Now
    let _v109 = v110 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v111 : System.DateTime = System.DateTime.Now
    let _v109 = v111 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v112 : System.DateTime = null |> unbox<System.DateTime>
    let _v109 = v112 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v115 : System.DateTime = System.DateTime.Now
    let _v109 = v115 
    #endif
#if FABLE_COMPILER_PYTHON
    let v116 : System.DateTime = System.DateTime.Now
    let _v109 = v116 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v117 : System.DateTime = System.DateTime.Now
    let _v109 = v117 
    #endif
#else
    let v118 : System.DateTime = System.DateTime.Now
    let _v109 = v118 
    #endif
    let v119 : System.DateTime = _v109 
    let v124 : (unit -> System.Guid) = System.Guid.NewGuid
    let v125 : System.Guid = v124 ()
    let v128 : System.Guid = method67(v125, v119)
    let v129 : string = method72(v128)
    let _v0 = v129 
    #endif
    let v130 : string = _v0 
    v130
and closure32 () () : string =
    method66()
and closure35 () (v0 : std_io_Error) : std_string_String =
    let v1 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = "format!(\"{}\", $0)"
    let v3 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v2 
    let _v1 = v3 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v4 : string = "format!(\"{}\", $0)"
    let v5 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v4 
    let _v1 = v5 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v6 : string = "format!(\"{}\", $0)"
    let v7 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v6 
    let _v1 = v7 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v8 : std_string_String = null |> unbox<std_string_String>
    let _v1 = v8 
    #endif
#if FABLE_COMPILER_PYTHON
    let v11 : std_string_String = null |> unbox<std_string_String>
    let _v1 = v11 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v14 : std_string_String = null |> unbox<std_string_String>
    let _v1 = v14 
    #endif
#else
    let v17 : std_string_String = null |> unbox<std_string_String>
    let _v1 = v17 
    #endif
    let v20 : std_string_String = _v1 
    v20
and method79 () : (std_io_Error -> std_string_String) =
    closure35()
and closure36 () () : US12 =
    US12_0
and method80 () : (unit -> US12) =
    closure36()
and closure37 () (v0 : std_string_String) : US12 =
    US12_1(v0)
and method81 () : (std_string_String -> US12) =
    closure37()
and method83 (v0 : string, v1 : std_string_String) : string =
    let v2 : string = method17()
    let v3 : Mut3 = {l0 = v2} : Mut3
    let v4 : string = "{ "
    let v5 : string = $"{v4}"
    let v8 : unit = ()
    let v9 : (unit -> unit) = closure6(v3, v5)
    let v10 : unit = (fun () -> v9 (); v8) ()
    let v13 : string = "dir"
    let v14 : string = $"{v13}"
    let v17 : unit = ()
    let v18 : (unit -> unit) = closure6(v3, v14)
    let v19 : unit = (fun () -> v18 (); v17) ()
    let v22 : string = " = "
    let v23 : string = $"{v22}"
    let v26 : unit = ()
    let v27 : (unit -> unit) = closure6(v3, v23)
    let v28 : unit = (fun () -> v27 (); v26) ()
    let v31 : string = $"{v0}"
    let v34 : unit = ()
    let v35 : (unit -> unit) = closure6(v3, v31)
    let v36 : unit = (fun () -> v35 (); v34) ()
    let v39 : string = "; "
    let v40 : string = $"{v39}"
    let v43 : unit = ()
    let v44 : (unit -> unit) = closure6(v3, v40)
    let v45 : unit = (fun () -> v44 (); v43) ()
    let v48 : string = "error"
    let v49 : string = $"{v48}"
    let v52 : unit = ()
    let v53 : (unit -> unit) = closure6(v3, v49)
    let v54 : unit = (fun () -> v53 (); v52) ()
    let v57 : string = $"{v22}"
    let v60 : unit = ()
    let v61 : (unit -> unit) = closure6(v3, v57)
    let v62 : unit = (fun () -> v61 (); v60) ()
    let v65 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v66 : string = "format!(\"{:#?}\", $0)"
    let v67 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1 v66 
    let v68 : string = "fable_library_rust::String_::fromString($0)"
    let v69 : string = Fable.Core.RustInterop.emitRustExpr v67 v68 
    let _v65 = v69 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v70 : string = "format!(\"{:#?}\", $0)"
    let v71 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1 v70 
    let v72 : string = "fable_library_rust::String_::fromString($0)"
    let v73 : string = Fable.Core.RustInterop.emitRustExpr v71 v72 
    let _v65 = v73 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v74 : string = "format!(\"{:#?}\", $0)"
    let v75 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1 v74 
    let v76 : string = "fable_library_rust::String_::fromString($0)"
    let v77 : string = Fable.Core.RustInterop.emitRustExpr v75 v76 
    let _v65 = v77 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v78 : string = $"%A{v1}"
    let _v65 = v78 
    #endif
#if FABLE_COMPILER_PYTHON
    let v81 : string = $"%A{v1}"
    let _v65 = v81 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v84 : string = $"%A{v1}"
    let _v65 = v84 
    #endif
#else
    let v87 : string = $"%A{v1}"
    let _v65 = v87 
    #endif
    let v90 : string = _v65 
    let v95 : string = $"{v90}"
    let v98 : unit = ()
    let v99 : (unit -> unit) = closure6(v3, v95)
    let v100 : unit = (fun () -> v99 (); v98) ()
    let v103 : string = " }"
    let v104 : string = $"{v103}"
    let v107 : unit = ()
    let v108 : (unit -> unit) = closure6(v3, v104)
    let v109 : unit = (fun () -> v108 (); v107) ()
    let v112 : string = v3.l0
    v112
and method82 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : string, v9 : std_string_String) : string =
    let v10 : string = method83(v8, v9)
    let v11 : int64 = v0.l0
    let v12 : string = "file_system.create_dir"
    let v13 : string = $"{v6} {v7} #{v11} %s{v12} / {v10}"
    method22(v13)
and closure38 (v0 : string, v1 : std_string_String) () : unit =
    let v2 : US0 = US0_4
    let v3 : bool = method10(v2)
    if v3 then
        let v4 : unit = ()
        let v5 : (unit -> unit) = closure0()
        let v6 : unit = (fun () -> v5 (); v4) ()
        let struct (v20 : Mut0, v21 : Mut1, v22 : Mut2, v23 : Mut3, v24 : Mut4, v25 : int64 option) = TraceState.trace_state.Value
        let v38 : string = method11(v20, v21, v22, v23, v24, v25)
        let v39 : string = method60()
        let v40 : string = method82(v20, v21, v22, v23, v24, v25, v38, v39, v0, v1)
        method23(v40)
and method85 (v0 : string) : string =
    let v1 : string = method17()
    let v2 : Mut3 = {l0 = v1} : Mut3
    let v3 : string = "{ "
    let v4 : string = $"{v3}"
    let v7 : unit = ()
    let v8 : (unit -> unit) = closure6(v2, v4)
    let v9 : unit = (fun () -> v8 (); v7) ()
    let v12 : string = "dir"
    let v13 : string = $"{v12}"
    let v16 : unit = ()
    let v17 : (unit -> unit) = closure6(v2, v13)
    let v18 : unit = (fun () -> v17 (); v16) ()
    let v21 : string = " = "
    let v22 : string = $"{v21}"
    let v25 : unit = ()
    let v26 : (unit -> unit) = closure6(v2, v22)
    let v27 : unit = (fun () -> v26 (); v25) ()
    let v30 : string = $"{v0}"
    let v33 : unit = ()
    let v34 : (unit -> unit) = closure6(v2, v30)
    let v35 : unit = (fun () -> v34 (); v33) ()
    let v38 : string = " }"
    let v39 : string = $"{v38}"
    let v42 : unit = ()
    let v43 : (unit -> unit) = closure6(v2, v39)
    let v44 : unit = (fun () -> v43 (); v42) ()
    let v47 : string = v2.l0
    v47
and method84 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : string) : string =
    let v9 : string = method85(v8)
    let v10 : int64 = v0.l0
    let v11 : string = "file_system.create_dir"
    let v12 : string = $"{v6} {v7} #{v10} %s{v11} / {v9}"
    method22(v12)
and closure39 (v0 : string) () : unit =
    let v1 : US0 = US0_0
    let v2 : bool = method10(v1)
    if v2 then
        let v3 : unit = ()
        let v4 : (unit -> unit) = closure0()
        let v5 : unit = (fun () -> v4 (); v3) ()
        let struct (v19 : Mut0, v20 : Mut1, v21 : Mut2, v22 : Mut3, v23 : Mut4, v24 : int64 option) = TraceState.trace_state.Value
        let v37 : string = method11(v19, v20, v21, v22, v23, v24)
        let v38 : string = method57()
        let v39 : string = method84(v19, v20, v21, v22, v23, v24, v37, v38, v0)
        method23(v39)
and closure40 (v0 : string) () : unit =
    let v1 : bool = true
    method8(v1, v0)
and method86 (v0 : string) : (unit -> unit) =
    closure40(v0)
and method87 (v0 : string) : (unit -> unit) =
    closure40(v0)
and method88 (v0 : string) : System_IO_DirectoryInfo =
    let v1 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : System_IO_DirectoryInfo = null |> unbox<System_IO_DirectoryInfo>
    let _v1 = v2 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v5 : System_IO_DirectoryInfo = null |> unbox<System_IO_DirectoryInfo>
    let _v1 = v5 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v8 : System_IO_DirectoryInfo = null |> unbox<System_IO_DirectoryInfo>
    let _v1 = v8 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v11 : System_IO_DirectoryInfo = null |> unbox<System_IO_DirectoryInfo>
    let _v1 = v11 
    #endif
#if FABLE_COMPILER_PYTHON
    let v14 : System_IO_DirectoryInfo = null |> unbox<System_IO_DirectoryInfo>
    let _v1 = v14 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v17 : System_IO_DirectoryInfo = null |> unbox<System_IO_DirectoryInfo>
    let _v1 = v17 
    #endif
#else
    let v20 : (string -> System_IO_DirectoryInfo) = System.IO.Directory.CreateDirectory
    let v21 : System_IO_DirectoryInfo = v20 v0
    let _v1 = v21 
    #endif
    let v22 : System_IO_DirectoryInfo = _v1 
    v22
and method90 (v0 : string, v1 : string) : string =
    let v2 : string = method17()
    let v3 : Mut3 = {l0 = v2} : Mut3
    let v4 : string = "{ "
    let v5 : string = $"{v4}"
    let v8 : unit = ()
    let v9 : (unit -> unit) = closure6(v3, v5)
    let v10 : unit = (fun () -> v9 (); v8) ()
    let v13 : string = "dir"
    let v14 : string = $"{v13}"
    let v17 : unit = ()
    let v18 : (unit -> unit) = closure6(v3, v14)
    let v19 : unit = (fun () -> v18 (); v17) ()
    let v22 : string = " = "
    let v23 : string = $"{v22}"
    let v26 : unit = ()
    let v27 : (unit -> unit) = closure6(v3, v23)
    let v28 : unit = (fun () -> v27 (); v26) ()
    let v31 : string = $"{v0}"
    let v34 : unit = ()
    let v35 : (unit -> unit) = closure6(v3, v31)
    let v36 : unit = (fun () -> v35 (); v34) ()
    let v39 : string = "; "
    let v40 : string = $"{v39}"
    let v43 : unit = ()
    let v44 : (unit -> unit) = closure6(v3, v40)
    let v45 : unit = (fun () -> v44 (); v43) ()
    let v48 : string = "result"
    let v49 : string = $"{v48}"
    let v52 : unit = ()
    let v53 : (unit -> unit) = closure6(v3, v49)
    let v54 : unit = (fun () -> v53 (); v52) ()
    let v57 : string = $"{v22}"
    let v60 : unit = ()
    let v61 : (unit -> unit) = closure6(v3, v57)
    let v62 : unit = (fun () -> v61 (); v60) ()
    let v65 : string = $"{v1}"
    let v68 : unit = ()
    let v69 : (unit -> unit) = closure6(v3, v65)
    let v70 : unit = (fun () -> v69 (); v68) ()
    let v73 : string = " }"
    let v74 : string = $"{v73}"
    let v77 : unit = ()
    let v78 : (unit -> unit) = closure6(v3, v74)
    let v79 : unit = (fun () -> v78 (); v77) ()
    let v82 : string = v3.l0
    v82
and method89 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : string, v9 : string) : string =
    let v10 : string = method90(v8, v9)
    let v11 : int64 = v0.l0
    let v12 : string = "file_system.create_dir"
    let v13 : string = $"{v6} {v7} #{v11} %s{v12} / {v10}"
    method22(v13)
and closure41 (v0 : string, v1 : string) () : unit =
    let v2 : US0 = US0_1
    let v3 : bool = method10(v2)
    if v3 then
        let v4 : unit = ()
        let v5 : (unit -> unit) = closure0()
        let v6 : unit = (fun () -> v5 (); v4) ()
        let struct (v20 : Mut0, v21 : Mut1, v22 : Mut2, v23 : Mut3, v24 : Mut4, v25 : int64 option) = TraceState.trace_state.Value
        let v38 : string = method11(v20, v21, v22, v23, v24, v25)
        let v39 : string = method15()
        let v40 : string = method89(v20, v21, v22, v23, v24, v25, v38, v39, v0, v1)
        method23(v40)
and method92 (v0 : Async<int64>) : Async<unit> =
    let v1 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : Async<unit> = null |> unbox<Async<unit>>
    let _v1 = v2 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v5 : Async<unit> = null |> unbox<Async<unit>>
    let _v1 = v5 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v8 : Async<unit> = null |> unbox<Async<unit>>
    let _v1 = v8 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v11 : (Async<int64> -> Async<unit>) = Async.Ignore
    let v12 : Async<unit> = v11 v0
    let _v1 = v12 
    #endif
#if FABLE_COMPILER_PYTHON
    let v13 : (Async<int64> -> Async<unit>) = Async.Ignore
    let v14 : Async<unit> = v13 v0
    let _v1 = v14 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v15 : (Async<int64> -> Async<unit>) = Async.Ignore
    let v16 : Async<unit> = v15 v0
    let _v1 = v16 
    #endif
#else
    let v17 : (Async<int64> -> Async<unit>) = Async.Ignore
    let v18 : Async<unit> = v17 v0
    let _v1 = v18 
    #endif
    let v19 : Async<unit> = _v1 
    v19
and method93 (v0 : Async<unit>) : unit =
    let v1 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    null |> unbox<unit>
    let _v1 = () 
    #endif
#if FABLE_COMPILER_RUST && WASM
    null |> unbox<unit>
    let _v1 = () 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    null |> unbox<unit>
    let _v1 = () 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    null |> unbox<unit>
    let _v1 = () 
    #endif
#if FABLE_COMPILER_PYTHON
    let v2 : (Async<unit> -> unit) = Async.RunSynchronously
    v2 v0
    let _v1 = () 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v3 : (Async<unit> -> unit) = Async.RunSynchronously
    v3 v0
    let _v1 = () 
    #endif
#else
    let v4 : (Async<unit> -> unit) = Async.RunSynchronously
    v4 v0
    let _v1 = () 
    #endif
    _v1 
    ()
and closure42 (v0 : string) () : unit =
    let v1 : Async<int64> = method6(v0)
    let v2 : Async<unit> = method92(v1)
    method93(v2)
and method91 (v0 : string) : (unit -> unit) =
    closure42(v0)
and method94 (v0 : string) : (unit -> unit) =
    closure42(v0)
and method78 (v0 : string) : System.IDisposable =
    let v1 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = "std::fs::create_dir_all(&*$0)"
    let v3 : Result<unit, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v0 v2 
    let v4 : (std_io_Error -> std_string_String) = method79()
    let v5 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v6 : string = "$0.map_err(|x| $1(x))"
    let v7 : Result<unit, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v3, v4) v6 
    let _v5 = v7 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v8 : string = "$0.map_err(|x| $1(x))"
    let v9 : Result<unit, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v3, v4) v8 
    let _v5 = v9 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v10 : string = "$0.map_err(|x| $1(x))"
    let v11 : Result<unit, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v3, v4) v10 
    let _v5 = v11 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v12 : Result<unit, std_string_String> = match v3 with Ok x -> Ok x | Error x -> Error (v4 x)
    let _v5 = v12 
    #endif
#if FABLE_COMPILER_PYTHON
    let v13 : Result<unit, std_string_String> = match v3 with Ok x -> Ok x | Error x -> Error (v4 x)
    let _v5 = v13 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v14 : Result<unit, std_string_String> = match v3 with Ok x -> Ok x | Error x -> Error (v4 x)
    let _v5 = v14 
    #endif
#else
    let v15 : Result<unit, std_string_String> = match v3 with Ok x -> Ok x | Error x -> Error (v4 x)
    let _v5 = v15 
    #endif
    let v16 : Result<unit, std_string_String> = _v5 
    let v19 : (unit -> US12) = method80()
    let v20 : (std_string_String -> US12) = method81()
    let v21 : US12 = match v16 with Ok () -> v19 () | Error x -> v20 x
    match v21 with
    | US12_1(v64) -> (* Error *)
        let v65 : unit = ()
        let v66 : (unit -> unit) = closure38(v0, v64)
        let v67 : unit = (fun () -> v66 (); v65) ()
        ()
    | US12_0 -> (* Ok *)
        let v22 : unit = ()
        let v23 : (unit -> unit) = closure39(v0)
        let v24 : unit = (fun () -> v23 (); v22) ()
        ()
    let v107 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v108 : (unit -> unit) = method86(v0)
    let v109 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v108 "$0()" )
    let _v107 = v109 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v110 : (unit -> unit) = method86(v0)
    let v111 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v110 "$0()" )
    let _v107 = v111 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v112 : (unit -> unit) = method86(v0)
    let v113 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v112 "$0()" )
    let _v107 = v113 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v114 : (unit -> unit) = method87(v0)
    let v115 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v114 () }
    let _v107 = v115 
    #endif
#if FABLE_COMPILER_PYTHON
    let v116 : (unit -> unit) = method87(v0)
    let v117 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v116 () }
    let _v107 = v117 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v118 : (unit -> unit) = method87(v0)
    let v119 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v118 () }
    let _v107 = v119 
    #endif
#else
    let v120 : (unit -> unit) = method87(v0)
    let v121 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v120 () }
    let _v107 = v121 
    #endif
    let v122 : System.IDisposable = _v107 
    let _v1 = v122 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v126 : System.IDisposable = null |> unbox<System.IDisposable>
    let _v1 = v126 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v129 : System.IDisposable = null |> unbox<System.IDisposable>
    let _v1 = v129 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v132 : System_IO_DirectoryInfo = method88(v0)
    let v133 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v134 : bool = null |> unbox<bool>
    let _v133 = v134 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v137 : bool = null |> unbox<bool>
    let _v133 = v137 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v140 : bool = null |> unbox<bool>
    let _v133 = v140 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v143 : bool = null |> unbox<bool>
    let _v133 = v143 
    #endif
#if FABLE_COMPILER_PYTHON
    let v146 : bool = null |> unbox<bool>
    let _v133 = v146 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v149 : bool = null |> unbox<bool>
    let _v133 = v149 
    #endif
#else
    let v152 : (System_IO_DirectoryInfo -> bool) = _.Exists
    let v153 : bool = v152 v132
    let _v133 = v153 
    #endif
    let v154 : bool = _v133 
    let v159 : bool = v154 = false
    if v159 then
        let v160 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v161 : System.DateTime = null |> unbox<System.DateTime>
        let _v160 = v161 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v164 : System.DateTime = null |> unbox<System.DateTime>
        let _v160 = v164 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v167 : System.DateTime = null |> unbox<System.DateTime>
        let _v160 = v167 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v170 : System.DateTime = null |> unbox<System.DateTime>
        let _v160 = v170 
        #endif
#if FABLE_COMPILER_PYTHON
        let v173 : System.DateTime = null |> unbox<System.DateTime>
        let _v160 = v173 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v176 : System.DateTime = null |> unbox<System.DateTime>
        let _v160 = v176 
        #endif
#else
        let v179 : (System_IO_DirectoryInfo -> System.DateTime) = _.CreationTime
        let v180 : System.DateTime = v179 v132
        let _v160 = v180 
        #endif
        let v181 : System.DateTime = _v160 
        let v186 : _ = {| Exists = v154; CreationTime = v181 |}
        let v187 : string = $"%A{v186}"
        let v190 : unit = ()
        let v191 : (unit -> unit) = closure41(v0, v187)
        let v192 : unit = (fun () -> v191 (); v190) ()
        ()
    let v232 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v233 : (unit -> unit) = method91(v0)
    let v234 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v233 "$0()" )
    let _v232 = v234 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v235 : (unit -> unit) = method91(v0)
    let v236 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v235 "$0()" )
    let _v232 = v236 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v237 : (unit -> unit) = method91(v0)
    let v238 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v237 "$0()" )
    let _v232 = v238 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v239 : (unit -> unit) = method94(v0)
    let v240 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v239 () }
    let _v232 = v240 
    #endif
#if FABLE_COMPILER_PYTHON
    let v241 : (unit -> unit) = method94(v0)
    let v242 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v241 () }
    let _v232 = v242 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v243 : (unit -> unit) = method94(v0)
    let v244 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v243 () }
    let _v232 = v244 
    #endif
#else
    let v245 : (unit -> unit) = method94(v0)
    let v246 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v245 () }
    let _v232 = v246 
    #endif
    let v247 : System.IDisposable = _v232 
    let _v1 = v247 
    #endif
#if FABLE_COMPILER_PYTHON
    let v251 : System_IO_DirectoryInfo = method88(v0)
    let v252 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v253 : bool = null |> unbox<bool>
    let _v252 = v253 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v256 : bool = null |> unbox<bool>
    let _v252 = v256 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v259 : bool = null |> unbox<bool>
    let _v252 = v259 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v262 : bool = null |> unbox<bool>
    let _v252 = v262 
    #endif
#if FABLE_COMPILER_PYTHON
    let v265 : bool = null |> unbox<bool>
    let _v252 = v265 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v268 : bool = null |> unbox<bool>
    let _v252 = v268 
    #endif
#else
    let v271 : (System_IO_DirectoryInfo -> bool) = _.Exists
    let v272 : bool = v271 v251
    let _v252 = v272 
    #endif
    let v273 : bool = _v252 
    let v278 : bool = v273 = false
    if v278 then
        let v279 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v280 : System.DateTime = null |> unbox<System.DateTime>
        let _v279 = v280 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v283 : System.DateTime = null |> unbox<System.DateTime>
        let _v279 = v283 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v286 : System.DateTime = null |> unbox<System.DateTime>
        let _v279 = v286 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v289 : System.DateTime = null |> unbox<System.DateTime>
        let _v279 = v289 
        #endif
#if FABLE_COMPILER_PYTHON
        let v292 : System.DateTime = null |> unbox<System.DateTime>
        let _v279 = v292 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v295 : System.DateTime = null |> unbox<System.DateTime>
        let _v279 = v295 
        #endif
#else
        let v298 : (System_IO_DirectoryInfo -> System.DateTime) = _.CreationTime
        let v299 : System.DateTime = v298 v251
        let _v279 = v299 
        #endif
        let v300 : System.DateTime = _v279 
        let v305 : _ = {| Exists = v273; CreationTime = v300 |}
        let v306 : string = $"%A{v305}"
        let v309 : unit = ()
        let v310 : (unit -> unit) = closure41(v0, v306)
        let v311 : unit = (fun () -> v310 (); v309) ()
        ()
    let v351 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v352 : (unit -> unit) = method91(v0)
    let v353 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v352 "$0()" )
    let _v351 = v353 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v354 : (unit -> unit) = method91(v0)
    let v355 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v354 "$0()" )
    let _v351 = v355 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v356 : (unit -> unit) = method91(v0)
    let v357 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v356 "$0()" )
    let _v351 = v357 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v358 : (unit -> unit) = method94(v0)
    let v359 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v358 () }
    let _v351 = v359 
    #endif
#if FABLE_COMPILER_PYTHON
    let v360 : (unit -> unit) = method94(v0)
    let v361 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v360 () }
    let _v351 = v361 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v362 : (unit -> unit) = method94(v0)
    let v363 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v362 () }
    let _v351 = v363 
    #endif
#else
    let v364 : (unit -> unit) = method94(v0)
    let v365 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v364 () }
    let _v351 = v365 
    #endif
    let v366 : System.IDisposable = _v351 
    let _v1 = v366 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v370 : System_IO_DirectoryInfo = method88(v0)
    let v371 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v372 : bool = null |> unbox<bool>
    let _v371 = v372 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v375 : bool = null |> unbox<bool>
    let _v371 = v375 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v378 : bool = null |> unbox<bool>
    let _v371 = v378 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v381 : bool = null |> unbox<bool>
    let _v371 = v381 
    #endif
#if FABLE_COMPILER_PYTHON
    let v384 : bool = null |> unbox<bool>
    let _v371 = v384 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v387 : bool = null |> unbox<bool>
    let _v371 = v387 
    #endif
#else
    let v390 : (System_IO_DirectoryInfo -> bool) = _.Exists
    let v391 : bool = v390 v370
    let _v371 = v391 
    #endif
    let v392 : bool = _v371 
    let v397 : bool = v392 = false
    if v397 then
        let v398 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v399 : System.DateTime = null |> unbox<System.DateTime>
        let _v398 = v399 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v402 : System.DateTime = null |> unbox<System.DateTime>
        let _v398 = v402 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v405 : System.DateTime = null |> unbox<System.DateTime>
        let _v398 = v405 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v408 : System.DateTime = null |> unbox<System.DateTime>
        let _v398 = v408 
        #endif
#if FABLE_COMPILER_PYTHON
        let v411 : System.DateTime = null |> unbox<System.DateTime>
        let _v398 = v411 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v414 : System.DateTime = null |> unbox<System.DateTime>
        let _v398 = v414 
        #endif
#else
        let v417 : (System_IO_DirectoryInfo -> System.DateTime) = _.CreationTime
        let v418 : System.DateTime = v417 v370
        let _v398 = v418 
        #endif
        let v419 : System.DateTime = _v398 
        let v424 : _ = {| Exists = v392; CreationTime = v419 |}
        let v425 : string = $"%A{v424}"
        let v428 : unit = ()
        let v429 : (unit -> unit) = closure41(v0, v425)
        let v430 : unit = (fun () -> v429 (); v428) ()
        ()
    let v470 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v471 : (unit -> unit) = method91(v0)
    let v472 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v471 "$0()" )
    let _v470 = v472 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v473 : (unit -> unit) = method91(v0)
    let v474 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v473 "$0()" )
    let _v470 = v474 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v475 : (unit -> unit) = method91(v0)
    let v476 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v475 "$0()" )
    let _v470 = v476 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v477 : (unit -> unit) = method94(v0)
    let v478 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v477 () }
    let _v470 = v478 
    #endif
#if FABLE_COMPILER_PYTHON
    let v479 : (unit -> unit) = method94(v0)
    let v480 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v479 () }
    let _v470 = v480 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v481 : (unit -> unit) = method94(v0)
    let v482 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v481 () }
    let _v470 = v482 
    #endif
#else
    let v483 : (unit -> unit) = method94(v0)
    let v484 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v483 () }
    let _v470 = v484 
    #endif
    let v485 : System.IDisposable = _v470 
    let _v1 = v485 
    #endif
#else
    let v489 : System_IO_DirectoryInfo = method88(v0)
    let v490 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v491 : bool = null |> unbox<bool>
    let _v490 = v491 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v494 : bool = null |> unbox<bool>
    let _v490 = v494 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v497 : bool = null |> unbox<bool>
    let _v490 = v497 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v500 : bool = null |> unbox<bool>
    let _v490 = v500 
    #endif
#if FABLE_COMPILER_PYTHON
    let v503 : bool = null |> unbox<bool>
    let _v490 = v503 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v506 : bool = null |> unbox<bool>
    let _v490 = v506 
    #endif
#else
    let v509 : (System_IO_DirectoryInfo -> bool) = _.Exists
    let v510 : bool = v509 v489
    let _v490 = v510 
    #endif
    let v511 : bool = _v490 
    let v516 : bool = v511 = false
    if v516 then
        let v517 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v518 : System.DateTime = null |> unbox<System.DateTime>
        let _v517 = v518 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v521 : System.DateTime = null |> unbox<System.DateTime>
        let _v517 = v521 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v524 : System.DateTime = null |> unbox<System.DateTime>
        let _v517 = v524 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v527 : System.DateTime = null |> unbox<System.DateTime>
        let _v517 = v527 
        #endif
#if FABLE_COMPILER_PYTHON
        let v530 : System.DateTime = null |> unbox<System.DateTime>
        let _v517 = v530 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v533 : System.DateTime = null |> unbox<System.DateTime>
        let _v517 = v533 
        #endif
#else
        let v536 : (System_IO_DirectoryInfo -> System.DateTime) = _.CreationTime
        let v537 : System.DateTime = v536 v489
        let _v517 = v537 
        #endif
        let v538 : System.DateTime = _v517 
        let v543 : _ = {| Exists = v511; CreationTime = v538 |}
        let v544 : string = $"%A{v543}"
        let v547 : unit = ()
        let v548 : (unit -> unit) = closure41(v0, v544)
        let v549 : unit = (fun () -> v548 (); v547) ()
        ()
    let v589 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v590 : (unit -> unit) = method91(v0)
    let v591 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v590 "$0()" )
    let _v589 = v591 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v592 : (unit -> unit) = method91(v0)
    let v593 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v592 "$0()" )
    let _v589 = v593 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v594 : (unit -> unit) = method91(v0)
    let v595 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v594 "$0()" )
    let _v589 = v595 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v596 : (unit -> unit) = method94(v0)
    let v597 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v596 () }
    let _v589 = v597 
    #endif
#if FABLE_COMPILER_PYTHON
    let v598 : (unit -> unit) = method94(v0)
    let v599 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v598 () }
    let _v589 = v599 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v600 : (unit -> unit) = method94(v0)
    let v601 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v600 () }
    let _v589 = v601 
    #endif
#else
    let v602 : (unit -> unit) = method94(v0)
    let v603 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v602 () }
    let _v589 = v603 
    #endif
    let v604 : System.IDisposable = _v589 
    let _v1 = v604 
    #endif
    let v608 : System.IDisposable = _v1 
    v608
and closure34 () () : struct (string * System.IDisposable) =
    let v0 : string = method66()
    let v1 : System.IDisposable = method78(v0)
    struct (v0, v1)
and method95 (v0 : string) : System.Guid =
    let v1 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = v0.PadLeft (32, '0')
    let v16 : int32 = 0 |> int32 
    let v23 : int32 = 8 |> int32 
    let v30 : int32 = v23 - 1
    let v31 : string = v2.[int v16..int v30]
    let v35 : int32 = 8 |> int32 
    let v42 : int32 = 12 |> int32 
    let v49 : int32 = v42 - 1
    let v50 : string = v2.[int v35..int v49]
    let v54 : int32 = 12 |> int32 
    let v61 : int32 = 16 |> int32 
    let v68 : int32 = v61 - 1
    let v69 : string = v2.[int v54..int v68]
    let v73 : int32 = 16 |> int32 
    let v80 : int32 = 20 |> int32 
    let v87 : int32 = v80 - 1
    let v88 : string = v2.[int v73..int v87]
    let v92 : int32 = 20 |> int32 
    let v99 : int32 = 32 |> int32 
    let v106 : int32 = v99 - 1
    let v107 : string = v2.[int v92..int v106]
    let v111 : string = $"{v31}-{v50}-{v69}-{v88}-{v107}"
    let v112 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v113 : System.Guid = v111 |> System.Guid 
    let _v112 = v113 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v116 : System.Guid = v111 |> System.Guid 
    let _v112 = v116 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v119 : System.Guid = null |> unbox<System.Guid>
    let _v112 = v119 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v122 : System.Guid = v111 |> System.Guid 
    let _v112 = v122 
    #endif
#if FABLE_COMPILER_PYTHON
    let v125 : System.Guid = v111 |> System.Guid 
    let _v112 = v125 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v128 : System.Guid = v111 |> System.Guid 
    let _v112 = v128 
    #endif
#else
    let v131 : System.Guid = v111 |> System.Guid 
    let _v112 = v131 
    #endif
    let v134 : System.Guid = _v112 
    let _v1 = v134 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v139 : string = v0.PadLeft (32, '0')
    let v153 : int32 = 0 |> int32 
    let v160 : int32 = 8 |> int32 
    let v167 : int32 = v160 - 1
    let v168 : string = v139.[int v153..int v167]
    let v172 : int32 = 8 |> int32 
    let v179 : int32 = 12 |> int32 
    let v186 : int32 = v179 - 1
    let v187 : string = v139.[int v172..int v186]
    let v191 : int32 = 12 |> int32 
    let v198 : int32 = 16 |> int32 
    let v205 : int32 = v198 - 1
    let v206 : string = v139.[int v191..int v205]
    let v210 : int32 = 16 |> int32 
    let v217 : int32 = 20 |> int32 
    let v224 : int32 = v217 - 1
    let v225 : string = v139.[int v210..int v224]
    let v229 : int32 = 20 |> int32 
    let v236 : int32 = 32 |> int32 
    let v243 : int32 = v236 - 1
    let v244 : string = v139.[int v229..int v243]
    let v248 : string = $"{v168}-{v187}-{v206}-{v225}-{v244}"
    let v249 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v250 : System.Guid = v248 |> System.Guid 
    let _v249 = v250 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v253 : System.Guid = v248 |> System.Guid 
    let _v249 = v253 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v256 : System.Guid = null |> unbox<System.Guid>
    let _v249 = v256 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v259 : System.Guid = v248 |> System.Guid 
    let _v249 = v259 
    #endif
#if FABLE_COMPILER_PYTHON
    let v262 : System.Guid = v248 |> System.Guid 
    let _v249 = v262 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v265 : System.Guid = v248 |> System.Guid 
    let _v249 = v265 
    #endif
#else
    let v268 : System.Guid = v248 |> System.Guid 
    let _v249 = v268 
    #endif
    let v271 : System.Guid = _v249 
    let _v1 = v271 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v276 : System.Guid = null |> unbox<System.Guid>
    let _v1 = v276 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v279 : string = v0.PadLeft (32, '0')
    let v293 : int32 = 0 |> int32 
    let v300 : int32 = 8 |> int32 
    let v307 : int32 = v300 - 1
    let v308 : string = v279.[int v293..int v307]
    let v312 : int32 = 8 |> int32 
    let v319 : int32 = 12 |> int32 
    let v326 : int32 = v319 - 1
    let v327 : string = v279.[int v312..int v326]
    let v331 : int32 = 12 |> int32 
    let v338 : int32 = 16 |> int32 
    let v345 : int32 = v338 - 1
    let v346 : string = v279.[int v331..int v345]
    let v350 : int32 = 16 |> int32 
    let v357 : int32 = 20 |> int32 
    let v364 : int32 = v357 - 1
    let v365 : string = v279.[int v350..int v364]
    let v369 : int32 = 20 |> int32 
    let v376 : int32 = 32 |> int32 
    let v383 : int32 = v376 - 1
    let v384 : string = v279.[int v369..int v383]
    let v388 : string = $"{v308}-{v327}-{v346}-{v365}-{v384}"
    let v389 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v390 : System.Guid = v388 |> System.Guid 
    let _v389 = v390 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v393 : System.Guid = v388 |> System.Guid 
    let _v389 = v393 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v396 : System.Guid = null |> unbox<System.Guid>
    let _v389 = v396 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v399 : System.Guid = v388 |> System.Guid 
    let _v389 = v399 
    #endif
#if FABLE_COMPILER_PYTHON
    let v402 : System.Guid = v388 |> System.Guid 
    let _v389 = v402 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v405 : System.Guid = v388 |> System.Guid 
    let _v389 = v405 
    #endif
#else
    let v408 : System.Guid = v388 |> System.Guid 
    let _v389 = v408 
    #endif
    let v411 : System.Guid = _v389 
    let _v1 = v411 
    #endif
#if FABLE_COMPILER_PYTHON
    let v416 : string = v0.PadLeft (32, '0')
    let v430 : int32 = 0 |> int32 
    let v437 : int32 = 8 |> int32 
    let v444 : int32 = v437 - 1
    let v445 : string = v416.[int v430..int v444]
    let v449 : int32 = 8 |> int32 
    let v456 : int32 = 12 |> int32 
    let v463 : int32 = v456 - 1
    let v464 : string = v416.[int v449..int v463]
    let v468 : int32 = 12 |> int32 
    let v475 : int32 = 16 |> int32 
    let v482 : int32 = v475 - 1
    let v483 : string = v416.[int v468..int v482]
    let v487 : int32 = 16 |> int32 
    let v494 : int32 = 20 |> int32 
    let v501 : int32 = v494 - 1
    let v502 : string = v416.[int v487..int v501]
    let v506 : int32 = 20 |> int32 
    let v513 : int32 = 32 |> int32 
    let v520 : int32 = v513 - 1
    let v521 : string = v416.[int v506..int v520]
    let v525 : string = $"{v445}-{v464}-{v483}-{v502}-{v521}"
    let v526 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v527 : System.Guid = v525 |> System.Guid 
    let _v526 = v527 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v530 : System.Guid = v525 |> System.Guid 
    let _v526 = v530 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v533 : System.Guid = null |> unbox<System.Guid>
    let _v526 = v533 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v536 : System.Guid = v525 |> System.Guid 
    let _v526 = v536 
    #endif
#if FABLE_COMPILER_PYTHON
    let v539 : System.Guid = v525 |> System.Guid 
    let _v526 = v539 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v542 : System.Guid = v525 |> System.Guid 
    let _v526 = v542 
    #endif
#else
    let v545 : System.Guid = v525 |> System.Guid 
    let _v526 = v545 
    #endif
    let v548 : System.Guid = _v526 
    let _v1 = v548 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v553 : string = v0.PadLeft (32, '0')
    let v567 : int32 = 0 |> int32 
    let v574 : int32 = 8 |> int32 
    let v581 : int32 = v574 - 1
    let v582 : string = v553.[int v567..int v581]
    let v586 : int32 = 8 |> int32 
    let v593 : int32 = 12 |> int32 
    let v600 : int32 = v593 - 1
    let v601 : string = v553.[int v586..int v600]
    let v605 : int32 = 12 |> int32 
    let v612 : int32 = 16 |> int32 
    let v619 : int32 = v612 - 1
    let v620 : string = v553.[int v605..int v619]
    let v624 : int32 = 16 |> int32 
    let v631 : int32 = 20 |> int32 
    let v638 : int32 = v631 - 1
    let v639 : string = v553.[int v624..int v638]
    let v643 : int32 = 20 |> int32 
    let v650 : int32 = 32 |> int32 
    let v657 : int32 = v650 - 1
    let v658 : string = v553.[int v643..int v657]
    let v662 : string = $"{v582}-{v601}-{v620}-{v639}-{v658}"
    let v663 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v664 : System.Guid = v662 |> System.Guid 
    let _v663 = v664 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v667 : System.Guid = v662 |> System.Guid 
    let _v663 = v667 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v670 : System.Guid = null |> unbox<System.Guid>
    let _v663 = v670 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v673 : System.Guid = v662 |> System.Guid 
    let _v663 = v673 
    #endif
#if FABLE_COMPILER_PYTHON
    let v676 : System.Guid = v662 |> System.Guid 
    let _v663 = v676 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v679 : System.Guid = v662 |> System.Guid 
    let _v663 = v679 
    #endif
#else
    let v682 : System.Guid = v662 |> System.Guid 
    let _v663 = v682 
    #endif
    let v685 : System.Guid = _v663 
    let _v1 = v685 
    #endif
#else
    let v690 : string = v0.PadLeft (32, '0')
    let v704 : int32 = 0 |> int32 
    let v711 : int32 = 8 |> int32 
    let v718 : int32 = v711 - 1
    let v719 : string = v690.[int v704..int v718]
    let v723 : int32 = 8 |> int32 
    let v730 : int32 = 12 |> int32 
    let v737 : int32 = v730 - 1
    let v738 : string = v690.[int v723..int v737]
    let v742 : int32 = 12 |> int32 
    let v749 : int32 = 16 |> int32 
    let v756 : int32 = v749 - 1
    let v757 : string = v690.[int v742..int v756]
    let v761 : int32 = 16 |> int32 
    let v768 : int32 = 20 |> int32 
    let v775 : int32 = v768 - 1
    let v776 : string = v690.[int v761..int v775]
    let v780 : int32 = 20 |> int32 
    let v787 : int32 = 32 |> int32 
    let v794 : int32 = v787 - 1
    let v795 : string = v690.[int v780..int v794]
    let v799 : string = $"{v719}-{v738}-{v757}-{v776}-{v795}"
    let v800 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v801 : System.Guid = v799 |> System.Guid 
    let _v800 = v801 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v804 : System.Guid = v799 |> System.Guid 
    let _v800 = v804 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v807 : System.Guid = null |> unbox<System.Guid>
    let _v800 = v807 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v810 : System.Guid = v799 |> System.Guid 
    let _v800 = v810 
    #endif
#if FABLE_COMPILER_PYTHON
    let v813 : System.Guid = v799 |> System.Guid 
    let _v800 = v813 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v816 : System.Guid = v799 |> System.Guid 
    let _v800 = v816 
    #endif
#else
    let v819 : System.Guid = v799 |> System.Guid 
    let _v800 = v819 
    #endif
    let v822 : System.Guid = _v800 
    let _v1 = v822 
    #endif
    let v827 : System.Guid = _v1 
    v827
and closure43 () (v0 : string) : struct (string * System.IDisposable) =
    let v1 : System.Guid = method95(v0)
    let v2 : string = method72(v1)
    let v3 : System.IDisposable = method78(v2)
    struct (v2, v3)
and closure44 () () : string =
    let v0 : string = __SOURCE_DIRECTORY__
    v0
and method100 (v0 : std_io_Error) : string =
    let v1 : string = method17()
    let v2 : Mut3 = {l0 = v1} : Mut3
    let v3 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v4 : string = "format!(\"{:#?}\", $0)"
    let v5 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v4 
    let v6 : string = "fable_library_rust::String_::fromString($0)"
    let v7 : string = Fable.Core.RustInterop.emitRustExpr v5 v6 
    let _v3 = v7 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v8 : string = "format!(\"{:#?}\", $0)"
    let v9 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v8 
    let v10 : string = "fable_library_rust::String_::fromString($0)"
    let v11 : string = Fable.Core.RustInterop.emitRustExpr v9 v10 
    let _v3 = v11 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v12 : string = "format!(\"{:#?}\", $0)"
    let v13 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v12 
    let v14 : string = "fable_library_rust::String_::fromString($0)"
    let v15 : string = Fable.Core.RustInterop.emitRustExpr v13 v14 
    let _v3 = v15 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v16 : string = $"%A{v0}"
    let _v3 = v16 
    #endif
#if FABLE_COMPILER_PYTHON
    let v19 : string = $"%A{v0}"
    let _v3 = v19 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v22 : string = $"%A{v0}"
    let _v3 = v22 
    #endif
#else
    let v25 : string = $"%A{v0}"
    let _v3 = v25 
    #endif
    let v28 : string = _v3 
    let v33 : string = $"{v28}"
    let v36 : unit = ()
    let v37 : (unit -> unit) = closure6(v2, v33)
    let v38 : unit = (fun () -> v37 (); v36) ()
    let v41 : string = v2.l0
    v41
and closure46 () (v0 : std_io_Error) : string =
    method100(v0)
and method99 () : (std_io_Error -> string) =
    closure46()
and closure47 () (v0 : std_path_PathBuf) : US13 =
    US13_0(v0)
and method101 () : (std_path_PathBuf -> US13) =
    closure47()
and closure48 () (v0 : string) : US13 =
    US13_1(v0)
and method102 () : (string -> US13) =
    closure48()
and method105 (v0 : string) : string option =
    let v1 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : string = "&*$0"
    let v4 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v3 
    let _v2 = v4 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v5 : string = "&*$0"
    let v6 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v5 
    let _v2 = v6 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v7 : string = "&*$0"
    let v8 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v7 
    let _v2 = v8 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v9 : Ref<Str> = v0 |> unbox<Ref<Str>>
    let _v2 = v9 
    #endif
#if FABLE_COMPILER_PYTHON
    let v12 : Ref<Str> = v0 |> unbox<Ref<Str>>
    let _v2 = v12 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v15 : Ref<Str> = v0 |> unbox<Ref<Str>>
    let _v2 = v15 
    #endif
#else
    let v18 : Ref<Str> = v0 |> unbox<Ref<Str>>
    let _v2 = v18 
    #endif
    let v21 : Ref<Str> = _v2 
    let v26 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v27 : string = "String::from($0)"
    let v28 : std_string_String = Fable.Core.RustInterop.emitRustExpr v21 v27 
    let _v26 = v28 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v29 : string = "String::from($0)"
    let v30 : std_string_String = Fable.Core.RustInterop.emitRustExpr v21 v29 
    let _v26 = v30 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v31 : string = "String::from($0)"
    let v32 : std_string_String = Fable.Core.RustInterop.emitRustExpr v21 v31 
    let _v26 = v32 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v33 : std_string_String = v21 |> unbox<std_string_String>
    let _v26 = v33 
    #endif
#if FABLE_COMPILER_PYTHON
    let v36 : std_string_String = v21 |> unbox<std_string_String>
    let _v26 = v36 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v39 : std_string_String = v21 |> unbox<std_string_String>
    let _v26 = v39 
    #endif
#else
    let v42 : std_string_String = v21 |> unbox<std_string_String>
    let _v26 = v42 
    #endif
    let v45 : std_string_String = _v26 
    let v50 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v51 : string = "std::path::PathBuf::from($0)"
    let v52 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v45 v51 
    let _v50 = v52 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v53 : string = "std::path::PathBuf::from($0)"
    let v54 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v45 v53 
    let _v50 = v54 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v55 : string = "std::path::PathBuf::from($0)"
    let v56 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v45 v55 
    let _v50 = v56 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v57 : std_path_PathBuf = v45 |> unbox<std_path_PathBuf>
    let _v50 = v57 
    #endif
#if FABLE_COMPILER_PYTHON
    let v60 : std_path_PathBuf = v45 |> unbox<std_path_PathBuf>
    let _v50 = v60 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v63 : std_path_PathBuf = v45 |> unbox<std_path_PathBuf>
    let _v50 = v63 
    #endif
#else
    let v66 : std_path_PathBuf = v45 |> unbox<std_path_PathBuf>
    let _v50 = v66 
    #endif
    let v69 : std_path_PathBuf = _v50 
    let v74 : string = "$0.parent().map(std::path::PathBuf::from)"
    let v75 : std_path_PathBuf option = Fable.Core.RustInterop.emitRustExpr v69 v74 
    let v76 : string = "true; let _optionm_map_ = $0.map(|x| { //"
    let v77 : bool = Fable.Core.RustInterop.emitRustExpr v75 v76 
    let v78 : string = "x"
    let v79 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr () v78 
    let v80 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v81 : string = "$0.display()"
    let v82 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v79 v81 
    let _v80 = v82 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v83 : string = "$0.display()"
    let v84 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v79 v83 
    let _v80 = v84 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v85 : string = "$0.display()"
    let v86 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v79 v85 
    let _v80 = v86 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v87 : std_path_Display = v79 |> unbox<std_path_Display>
    let _v80 = v87 
    #endif
#if FABLE_COMPILER_PYTHON
    let v90 : std_path_Display = v79 |> unbox<std_path_Display>
    let _v80 = v90 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v93 : std_path_Display = v79 |> unbox<std_path_Display>
    let _v80 = v93 
    #endif
#else
    let v96 : std_path_Display = v79 |> unbox<std_path_Display>
    let _v80 = v96 
    #endif
    let v99 : std_path_Display = _v80 
    let v104 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v105 : string = "format!(\"{}\", $0)"
    let v106 : std_string_String = Fable.Core.RustInterop.emitRustExpr v99 v105 
    let _v104 = v106 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v107 : string = "format!(\"{}\", $0)"
    let v108 : std_string_String = Fable.Core.RustInterop.emitRustExpr v99 v107 
    let _v104 = v108 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v109 : string = "format!(\"{}\", $0)"
    let v110 : std_string_String = Fable.Core.RustInterop.emitRustExpr v99 v109 
    let _v104 = v110 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v111 : std_string_String = null |> unbox<std_string_String>
    let _v104 = v111 
    #endif
#if FABLE_COMPILER_PYTHON
    let v114 : std_string_String = null |> unbox<std_string_String>
    let _v104 = v114 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v117 : std_string_String = null |> unbox<std_string_String>
    let _v104 = v117 
    #endif
#else
    let v120 : std_string_String = null |> unbox<std_string_String>
    let _v104 = v120 
    #endif
    let v123 : std_string_String = _v104 
    let v128 : string = "fable_library_rust::String_::fromString($0)"
    let v129 : string = Fable.Core.RustInterop.emitRustExpr v123 v128 
    let v130 : string = "true; $0 })"
    let v131 : bool = Fable.Core.RustInterop.emitRustExpr v129 v130 
    let v132 : string = "_optionm_map_"
    let v133 : string option = Fable.Core.RustInterop.emitRustExpr () v132 
    let _v1 = v133 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v134 : string option = null |> unbox<string option>
    let _v1 = v134 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v137 : string option = null |> unbox<string option>
    let _v1 = v137 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v140 : string = "path"
    let v141 : IPathDirname = Fable.Core.JsInterop.importAll v140 
    let v142 : string = "v141.dirname($0)"
    let v143 : string = Fable.Core.JsInterop.emitJsExpr v0 v142 
    let v144 : string option = Some v143 
    let _v1 = v144 
    #endif
#if FABLE_COMPILER_PYTHON
    let v147 : string option = null |> unbox<string option>
    let _v1 = v147 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v150 : string option = null |> unbox<string option>
    let _v1 = v150 
    #endif
#else
    let v153 : (string -> System_IO_DirectoryInfo) = System.IO.Directory.GetParent
    let v154 : System_IO_DirectoryInfo = v153 v0
    let v155 : System_IO_DirectoryInfo = null |> unbox<System_IO_DirectoryInfo>
    let v158 : bool = v154 = v155 
    let v189 : US5 =
        if v158 then
            US5_1
        else
            let v162 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v163 : string = null |> unbox<string>
            let _v162 = v163 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v166 : string = null |> unbox<string>
            let _v162 = v166 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v169 : string = null |> unbox<string>
            let _v162 = v169 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v172 : string = null |> unbox<string>
            let _v162 = v172 
            #endif
#if FABLE_COMPILER_PYTHON
            let v175 : string = null |> unbox<string>
            let _v162 = v175 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v178 : string = null |> unbox<string>
            let _v162 = v178 
            #endif
#else
            let v181 : (System_IO_DirectoryInfo -> string) = _.FullName
            let v182 : string = v181 v154
            let _v162 = v182 
            #endif
            let v183 : string = _v162 
            US5_0(v183)
    let v196 : string option =
        match v189 with
        | US5_1 -> (* None *)
            let v194 : string option = None
            v194
        | US5_0(v190) -> (* Some *)
            let v191 : string option = Some v190 
            v191
    let _v1 = v196 
    #endif
    let v197 : string option = _v1 
    v197
and method106 (v0 : string) : string =
    let v1 : string = method17()
    let v2 : Mut3 = {l0 = v1} : Mut3
    let v3 : string = $"{v0}"
    let v6 : unit = ()
    let v7 : (unit -> unit) = closure6(v2, v3)
    let v8 : unit = (fun () -> v7 (); v6) ()
    let v11 : string = v2.l0
    v11
and method104 (v0 : string, v1 : (uint8 -> (string -> Result<std_path_PathBuf, std_io_Error>)), v2 : uint8, v3 : string, v4 : string) : Result<std_path_PathBuf, std_io_Error> =
    let v5 : string = method19(v4)
    let v6 : string option = method105(v4)
    let v7 : (string -> US5) = method5()
    let v8 : US5 option = v6 |> Option.map v7 
    let v19 : US5 = US5_1
    let v20 : US5 = v8 |> Option.defaultValue v19 
    let v24 : string = method106(v3)
    let v25 : bool = v2 >= 11uy
    if v25 then
        let v26 : string = $"file_system.read_link / path: {v0} / n: {v2} / path': {v4} / name: {v5}"
        let v27 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v28 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
        let v29 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v26 v28 
        let _v27 = v29 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v30 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
        let v31 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v26 v30 
        let _v27 = v31 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v32 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
        let v33 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v26 v32 
        let _v27 = v33 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v34 : std_io_Error = v26 |> unbox<std_io_Error>
        let _v27 = v34 
        #endif
#if FABLE_COMPILER_PYTHON
        let v37 : std_io_Error = v26 |> unbox<std_io_Error>
        let _v27 = v37 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v40 : std_io_Error = v26 |> unbox<std_io_Error>
        let _v27 = v40 
        #endif
#else
        let v43 : std_io_Error = v26 |> unbox<std_io_Error>
        let _v27 = v43 
        #endif
        let v46 : std_io_Error = _v27 
        let v51 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v52 : string = "Err($0)"
        let v53 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v46 v52 
        let _v51 = v53 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v54 : string = "Err($0)"
        let v55 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v46 v54 
        let _v51 = v55 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v56 : string = "Err($0)"
        let v57 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v46 v56 
        let _v51 = v57 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v58 : Result<std_path_PathBuf, std_io_Error> = v46 |> Error
        let _v51 = v58 
        #endif
#if FABLE_COMPILER_PYTHON
        let v59 : Result<std_path_PathBuf, std_io_Error> = v46 |> Error
        let _v51 = v59 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v60 : Result<std_path_PathBuf, std_io_Error> = v46 |> Error
        let _v51 = v60 
        #endif
#else
        let v61 : Result<std_path_PathBuf, std_io_Error> = v46 |> Error
        let _v51 = v61 
        #endif
        let v62 : Result<std_path_PathBuf, std_io_Error> = _v51 
        v62
    else
        match v20 with
        | US5_0(v65) -> (* Some *)
            let v66 : string = ""
            let v67 : bool = v4 <> v66 
            if v67 then
                let v70 : uint8 = v2 + 1uy
                let v71 : (string -> Result<std_path_PathBuf, std_io_Error>) = v1 v70
                let v72 : Result<std_path_PathBuf, std_io_Error> = v71 v65
                let v73 : (std_io_Error -> string) = method99()
                let v74 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v75 : string = "$0.map_err(|x| $1(x))"
                let v76 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v72, v73) v75 
                let _v74 = v76 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v77 : string = "$0.map_err(|x| $1(x))"
                let v78 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v72, v73) v77 
                let _v74 = v78 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v79 : string = "$0.map_err(|x| $1(x))"
                let v80 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v72, v73) v79 
                let _v74 = v80 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v81 : Result<std_path_PathBuf, string> = match v72 with Ok x -> Ok x | Error x -> Error (v73 x)
                let _v74 = v81 
                #endif
#if FABLE_COMPILER_PYTHON
                let v82 : Result<std_path_PathBuf, string> = match v72 with Ok x -> Ok x | Error x -> Error (v73 x)
                let _v74 = v82 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v83 : Result<std_path_PathBuf, string> = match v72 with Ok x -> Ok x | Error x -> Error (v73 x)
                let _v74 = v83 
                #endif
#else
                let v84 : Result<std_path_PathBuf, string> = match v72 with Ok x -> Ok x | Error x -> Error (v73 x)
                let _v74 = v84 
                #endif
                let v85 : Result<std_path_PathBuf, string> = _v74 
                let v88 : (std_path_PathBuf -> US13) = method101()
                let v89 : (string -> US13) = method102()
                let v90 : US13 = match v85 with Ok x -> v88 x | Error x -> v89 x
                match v90 with
                | US13_1(v206) -> (* Error *)
                    let v207 : string = $"file_system.read_link / error': {v206} / error: {v24} / name: {v5}"
                    let v208 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v209 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                    let v210 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v207 v209 
                    let _v208 = v210 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v211 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                    let v212 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v207 v211 
                    let _v208 = v212 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v213 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                    let v214 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v207 v213 
                    let _v208 = v214 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v215 : std_io_Error = v207 |> unbox<std_io_Error>
                    let _v208 = v215 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v218 : std_io_Error = v207 |> unbox<std_io_Error>
                    let _v208 = v218 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v221 : std_io_Error = v207 |> unbox<std_io_Error>
                    let _v208 = v221 
                    #endif
#else
                    let v224 : std_io_Error = v207 |> unbox<std_io_Error>
                    let _v208 = v224 
                    #endif
                    let v227 : std_io_Error = _v208 
                    let v232 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v233 : string = "Err($0)"
                    let v234 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v227 v233 
                    let _v232 = v234 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v235 : string = "Err($0)"
                    let v236 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v227 v235 
                    let _v232 = v236 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v237 : string = "Err($0)"
                    let v238 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v227 v237 
                    let _v232 = v238 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v239 : Result<std_path_PathBuf, std_io_Error> = v227 |> Error
                    let _v232 = v239 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v240 : Result<std_path_PathBuf, std_io_Error> = v227 |> Error
                    let _v232 = v240 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v241 : Result<std_path_PathBuf, std_io_Error> = v227 |> Error
                    let _v232 = v241 
                    #endif
#else
                    let v242 : Result<std_path_PathBuf, std_io_Error> = v227 |> Error
                    let _v232 = v242 
                    #endif
                    let v243 : Result<std_path_PathBuf, std_io_Error> = _v232 
                    v243
                | US13_0(v91) -> (* Ok *)
                    let v92 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v93 : string = "$0.display()"
                    let v94 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v91 v93 
                    let _v92 = v94 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v95 : string = "$0.display()"
                    let v96 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v91 v95 
                    let _v92 = v96 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v97 : string = "$0.display()"
                    let v98 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v91 v97 
                    let _v92 = v98 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v99 : std_path_Display = v91 |> unbox<std_path_Display>
                    let _v92 = v99 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v102 : std_path_Display = v91 |> unbox<std_path_Display>
                    let _v92 = v102 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v105 : std_path_Display = v91 |> unbox<std_path_Display>
                    let _v92 = v105 
                    #endif
#else
                    let v108 : std_path_Display = v91 |> unbox<std_path_Display>
                    let _v92 = v108 
                    #endif
                    let v111 : std_path_Display = _v92 
                    let v116 : string = v111 |> string 
                    let v119 : string = method75(v116, v5)
                    let v120 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v121 : string = "&*$0"
                    let v122 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v119 v121 
                    let _v120 = v122 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v123 : string = "&*$0"
                    let v124 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v119 v123 
                    let _v120 = v124 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v125 : string = "&*$0"
                    let v126 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v119 v125 
                    let _v120 = v126 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v127 : Ref<Str> = v119 |> unbox<Ref<Str>>
                    let _v120 = v127 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v130 : Ref<Str> = v119 |> unbox<Ref<Str>>
                    let _v120 = v130 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v133 : Ref<Str> = v119 |> unbox<Ref<Str>>
                    let _v120 = v133 
                    #endif
#else
                    let v136 : Ref<Str> = v119 |> unbox<Ref<Str>>
                    let _v120 = v136 
                    #endif
                    let v139 : Ref<Str> = _v120 
                    let v144 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v145 : string = "String::from($0)"
                    let v146 : std_string_String = Fable.Core.RustInterop.emitRustExpr v139 v145 
                    let _v144 = v146 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v147 : string = "String::from($0)"
                    let v148 : std_string_String = Fable.Core.RustInterop.emitRustExpr v139 v147 
                    let _v144 = v148 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v149 : string = "String::from($0)"
                    let v150 : std_string_String = Fable.Core.RustInterop.emitRustExpr v139 v149 
                    let _v144 = v150 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v151 : std_string_String = v139 |> unbox<std_string_String>
                    let _v144 = v151 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v154 : std_string_String = v139 |> unbox<std_string_String>
                    let _v144 = v154 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v157 : std_string_String = v139 |> unbox<std_string_String>
                    let _v144 = v157 
                    #endif
#else
                    let v160 : std_string_String = v139 |> unbox<std_string_String>
                    let _v144 = v160 
                    #endif
                    let v163 : std_string_String = _v144 
                    let v168 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v169 : string = "std::path::PathBuf::from($0)"
                    let v170 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v163 v169 
                    let _v168 = v170 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v171 : string = "std::path::PathBuf::from($0)"
                    let v172 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v163 v171 
                    let _v168 = v172 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v173 : string = "std::path::PathBuf::from($0)"
                    let v174 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v163 v173 
                    let _v168 = v174 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v175 : std_path_PathBuf = v163 |> unbox<std_path_PathBuf>
                    let _v168 = v175 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v178 : std_path_PathBuf = v163 |> unbox<std_path_PathBuf>
                    let _v168 = v178 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v181 : std_path_PathBuf = v163 |> unbox<std_path_PathBuf>
                    let _v168 = v181 
                    #endif
#else
                    let v184 : std_path_PathBuf = v163 |> unbox<std_path_PathBuf>
                    let _v168 = v184 
                    #endif
                    let v187 : std_path_PathBuf = _v168 
                    let v192 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v193 : string = "Ok($0)"
                    let v194 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v187 v193 
                    let _v192 = v194 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v195 : string = "Ok($0)"
                    let v196 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v187 v195 
                    let _v192 = v196 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v197 : string = "Ok($0)"
                    let v198 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v187 v197 
                    let _v192 = v198 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v199 : Result<std_path_PathBuf, std_io_Error> = v187 |> Ok
                    let _v192 = v199 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v200 : Result<std_path_PathBuf, std_io_Error> = v187 |> Ok
                    let _v192 = v200 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v201 : Result<std_path_PathBuf, std_io_Error> = v187 |> Ok
                    let _v192 = v201 
                    #endif
#else
                    let v202 : Result<std_path_PathBuf, std_io_Error> = v187 |> Ok
                    let _v192 = v202 
                    #endif
                    let v203 : Result<std_path_PathBuf, std_io_Error> = _v192 
                    v203
            else
                let v248 : string = $"file_system.read_link / run / The file or directory is not a reparse point. / path: {v0} / error: {v24} / path': {v4} / name: {v5}"
                let v249 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v250 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                let v251 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v248 v250 
                let _v249 = v251 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v252 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                let v253 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v248 v252 
                let _v249 = v253 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v254 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                let v255 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v248 v254 
                let _v249 = v255 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v256 : std_io_Error = v248 |> unbox<std_io_Error>
                let _v249 = v256 
                #endif
#if FABLE_COMPILER_PYTHON
                let v259 : std_io_Error = v248 |> unbox<std_io_Error>
                let _v249 = v259 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v262 : std_io_Error = v248 |> unbox<std_io_Error>
                let _v249 = v262 
                #endif
#else
                let v265 : std_io_Error = v248 |> unbox<std_io_Error>
                let _v249 = v265 
                #endif
                let v268 : std_io_Error = _v249 
                let v273 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v274 : string = "Err($0)"
                let v275 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v268 v274 
                let _v273 = v275 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v276 : string = "Err($0)"
                let v277 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v268 v276 
                let _v273 = v277 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v278 : string = "Err($0)"
                let v279 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v268 v278 
                let _v273 = v279 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v280 : Result<std_path_PathBuf, std_io_Error> = v268 |> Error
                let _v273 = v280 
                #endif
#if FABLE_COMPILER_PYTHON
                let v281 : Result<std_path_PathBuf, std_io_Error> = v268 |> Error
                let _v273 = v281 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v282 : Result<std_path_PathBuf, std_io_Error> = v268 |> Error
                let _v273 = v282 
                #endif
#else
                let v283 : Result<std_path_PathBuf, std_io_Error> = v268 |> Error
                let _v273 = v283 
                #endif
                let v284 : Result<std_path_PathBuf, std_io_Error> = _v273 
                v284
        | _ ->
            let v288 : string = $"file_system.read_link / run / The file or directory is not a reparse point. / path: {v0} / error: {v24} / path': {v4} / name: {v5}"
            let v289 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v290 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
            let v291 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v288 v290 
            let _v289 = v291 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v292 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
            let v293 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v288 v292 
            let _v289 = v293 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v294 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
            let v295 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v288 v294 
            let _v289 = v295 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v296 : std_io_Error = v288 |> unbox<std_io_Error>
            let _v289 = v296 
            #endif
#if FABLE_COMPILER_PYTHON
            let v299 : std_io_Error = v288 |> unbox<std_io_Error>
            let _v289 = v299 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v302 : std_io_Error = v288 |> unbox<std_io_Error>
            let _v289 = v302 
            #endif
#else
            let v305 : std_io_Error = v288 |> unbox<std_io_Error>
            let _v289 = v305 
            #endif
            let v308 : std_io_Error = _v289 
            let v313 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v314 : string = "Err($0)"
            let v315 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v308 v314 
            let _v313 = v315 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v316 : string = "Err($0)"
            let v317 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v308 v316 
            let _v313 = v317 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v318 : string = "Err($0)"
            let v319 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v308 v318 
            let _v313 = v319 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v320 : Result<std_path_PathBuf, std_io_Error> = v308 |> Error
            let _v313 = v320 
            #endif
#if FABLE_COMPILER_PYTHON
            let v321 : Result<std_path_PathBuf, std_io_Error> = v308 |> Error
            let _v313 = v321 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v322 : Result<std_path_PathBuf, std_io_Error> = v308 |> Error
            let _v313 = v322 
            #endif
#else
            let v323 : Result<std_path_PathBuf, std_io_Error> = v308 |> Error
            let _v313 = v323 
            #endif
            let v324 : Result<std_path_PathBuf, std_io_Error> = _v313 
            v324
and method103 (v0 : string, v1 : uint8, v2 : string) : Result<std_path_PathBuf, std_io_Error> =
    let v3 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v4 : string = "std::fs::read_link(&*$0)"
    let v5 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v2 v4 
    let v6 : (std_io_Error -> string) = method99()
    let v7 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v8 : string = "$0.map_err(|x| $1(x))"
    let v9 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v5, v6) v8 
    let _v7 = v9 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v10 : string = "$0.map_err(|x| $1(x))"
    let v11 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v5, v6) v10 
    let _v7 = v11 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v12 : string = "$0.map_err(|x| $1(x))"
    let v13 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v5, v6) v12 
    let _v7 = v13 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v14 : Result<std_path_PathBuf, string> = match v5 with Ok x -> Ok x | Error x -> Error (v6 x)
    let _v7 = v14 
    #endif
#if FABLE_COMPILER_PYTHON
    let v15 : Result<std_path_PathBuf, string> = match v5 with Ok x -> Ok x | Error x -> Error (v6 x)
    let _v7 = v15 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v16 : Result<std_path_PathBuf, string> = match v5 with Ok x -> Ok x | Error x -> Error (v6 x)
    let _v7 = v16 
    #endif
#else
    let v17 : Result<std_path_PathBuf, string> = match v5 with Ok x -> Ok x | Error x -> Error (v6 x)
    let _v7 = v17 
    #endif
    let v18 : Result<std_path_PathBuf, string> = _v7 
    let v21 : (std_path_PathBuf -> US13) = method101()
    let v22 : (string -> US13) = method102()
    let v23 : US13 = match v18 with Ok x -> v21 x | Error x -> v22 x
    let v43 : Result<std_path_PathBuf, std_io_Error> =
        match v23 with
        | US13_1(v39) -> (* Error *)
            let v40 : (uint8 -> (string -> Result<std_path_PathBuf, std_io_Error>)) = closure49(v0)
            method104(v0, v40, v1, v39, v2)
        | US13_0(v24) -> (* Ok *)
            let v25 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v26 : string = "Ok($0)"
            let v27 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v24 v26 
            let _v25 = v27 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v28 : string = "Ok($0)"
            let v29 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v24 v28 
            let _v25 = v29 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v30 : string = "Ok($0)"
            let v31 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v24 v30 
            let _v25 = v31 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v32 : Result<std_path_PathBuf, std_io_Error> = v24 |> Ok
            let _v25 = v32 
            #endif
#if FABLE_COMPILER_PYTHON
            let v33 : Result<std_path_PathBuf, std_io_Error> = v24 |> Ok
            let _v25 = v33 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v34 : Result<std_path_PathBuf, std_io_Error> = v24 |> Ok
            let _v25 = v34 
            #endif
#else
            let v35 : Result<std_path_PathBuf, std_io_Error> = v24 |> Ok
            let _v25 = v35 
            #endif
            let v36 : Result<std_path_PathBuf, std_io_Error> = _v25 
            v36
    let _v3 = v43 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v44 : string = "std::fs::read_link(&*$0)"
    let v45 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v2 v44 
    let v46 : (std_io_Error -> string) = method99()
    let v47 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v48 : string = "$0.map_err(|x| $1(x))"
    let v49 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v45, v46) v48 
    let _v47 = v49 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v50 : string = "$0.map_err(|x| $1(x))"
    let v51 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v45, v46) v50 
    let _v47 = v51 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v52 : string = "$0.map_err(|x| $1(x))"
    let v53 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v45, v46) v52 
    let _v47 = v53 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v54 : Result<std_path_PathBuf, string> = match v45 with Ok x -> Ok x | Error x -> Error (v46 x)
    let _v47 = v54 
    #endif
#if FABLE_COMPILER_PYTHON
    let v55 : Result<std_path_PathBuf, string> = match v45 with Ok x -> Ok x | Error x -> Error (v46 x)
    let _v47 = v55 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v56 : Result<std_path_PathBuf, string> = match v45 with Ok x -> Ok x | Error x -> Error (v46 x)
    let _v47 = v56 
    #endif
#else
    let v57 : Result<std_path_PathBuf, string> = match v45 with Ok x -> Ok x | Error x -> Error (v46 x)
    let _v47 = v57 
    #endif
    let v58 : Result<std_path_PathBuf, string> = _v47 
    let v61 : (std_path_PathBuf -> US13) = method101()
    let v62 : (string -> US13) = method102()
    let v63 : US13 = match v58 with Ok x -> v61 x | Error x -> v62 x
    let v83 : Result<std_path_PathBuf, std_io_Error> =
        match v63 with
        | US13_1(v79) -> (* Error *)
            let v80 : (uint8 -> (string -> Result<std_path_PathBuf, std_io_Error>)) = closure49(v0)
            method104(v0, v80, v1, v79, v2)
        | US13_0(v64) -> (* Ok *)
            let v65 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v66 : string = "Ok($0)"
            let v67 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v64 v66 
            let _v65 = v67 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v68 : string = "Ok($0)"
            let v69 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v64 v68 
            let _v65 = v69 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v70 : string = "Ok($0)"
            let v71 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v64 v70 
            let _v65 = v71 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v72 : Result<std_path_PathBuf, std_io_Error> = v64 |> Ok
            let _v65 = v72 
            #endif
#if FABLE_COMPILER_PYTHON
            let v73 : Result<std_path_PathBuf, std_io_Error> = v64 |> Ok
            let _v65 = v73 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v74 : Result<std_path_PathBuf, std_io_Error> = v64 |> Ok
            let _v65 = v74 
            #endif
#else
            let v75 : Result<std_path_PathBuf, std_io_Error> = v64 |> Ok
            let _v65 = v75 
            #endif
            let v76 : Result<std_path_PathBuf, std_io_Error> = _v65 
            v76
    let _v3 = v83 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v84 : string = "std::fs::read_link(&*$0)"
    let v85 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v2 v84 
    let v86 : (std_io_Error -> string) = method99()
    let v87 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v88 : string = "$0.map_err(|x| $1(x))"
    let v89 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v85, v86) v88 
    let _v87 = v89 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v90 : string = "$0.map_err(|x| $1(x))"
    let v91 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v85, v86) v90 
    let _v87 = v91 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v92 : string = "$0.map_err(|x| $1(x))"
    let v93 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v85, v86) v92 
    let _v87 = v93 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v94 : Result<std_path_PathBuf, string> = match v85 with Ok x -> Ok x | Error x -> Error (v86 x)
    let _v87 = v94 
    #endif
#if FABLE_COMPILER_PYTHON
    let v95 : Result<std_path_PathBuf, string> = match v85 with Ok x -> Ok x | Error x -> Error (v86 x)
    let _v87 = v95 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v96 : Result<std_path_PathBuf, string> = match v85 with Ok x -> Ok x | Error x -> Error (v86 x)
    let _v87 = v96 
    #endif
#else
    let v97 : Result<std_path_PathBuf, string> = match v85 with Ok x -> Ok x | Error x -> Error (v86 x)
    let _v87 = v97 
    #endif
    let v98 : Result<std_path_PathBuf, string> = _v87 
    let v101 : (std_path_PathBuf -> US13) = method101()
    let v102 : (string -> US13) = method102()
    let v103 : US13 = match v98 with Ok x -> v101 x | Error x -> v102 x
    let v123 : Result<std_path_PathBuf, std_io_Error> =
        match v103 with
        | US13_1(v119) -> (* Error *)
            let v120 : (uint8 -> (string -> Result<std_path_PathBuf, std_io_Error>)) = closure49(v0)
            method104(v0, v120, v1, v119, v2)
        | US13_0(v104) -> (* Ok *)
            let v105 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v106 : string = "Ok($0)"
            let v107 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v104 v106 
            let _v105 = v107 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v108 : string = "Ok($0)"
            let v109 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v104 v108 
            let _v105 = v109 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v110 : string = "Ok($0)"
            let v111 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v104 v110 
            let _v105 = v111 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v112 : Result<std_path_PathBuf, std_io_Error> = v104 |> Ok
            let _v105 = v112 
            #endif
#if FABLE_COMPILER_PYTHON
            let v113 : Result<std_path_PathBuf, std_io_Error> = v104 |> Ok
            let _v105 = v113 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v114 : Result<std_path_PathBuf, std_io_Error> = v104 |> Ok
            let _v105 = v114 
            #endif
#else
            let v115 : Result<std_path_PathBuf, std_io_Error> = v104 |> Ok
            let _v105 = v115 
            #endif
            let v116 : Result<std_path_PathBuf, std_io_Error> = _v105 
            v116
    let _v3 = v123 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v124 : Result<std_path_PathBuf, std_io_Error> = null |> unbox<Result<std_path_PathBuf, std_io_Error>>
    let _v3 = v124 
    #endif
#if FABLE_COMPILER_PYTHON
    let v127 : Result<std_path_PathBuf, std_io_Error> = null |> unbox<Result<std_path_PathBuf, std_io_Error>>
    let _v3 = v127 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v130 : Result<std_path_PathBuf, std_io_Error> = null |> unbox<Result<std_path_PathBuf, std_io_Error>>
    let _v3 = v130 
    #endif
#else
    let v133 : Result<std_path_PathBuf, std_io_Error> = null |> unbox<Result<std_path_PathBuf, std_io_Error>>
    let _v3 = v133 
    #endif
    let v136 : Result<std_path_PathBuf, std_io_Error> = _v3 
    v136
and closure50 (v0 : string, v1 : uint8) (v2 : string) : Result<std_path_PathBuf, std_io_Error> =
    method103(v0, v1, v2)
and closure49 (v0 : string) (v1 : uint8) : (string -> Result<std_path_PathBuf, std_io_Error>) =
    closure50(v0, v1)
and method107 (v0 : string, v1 : (uint8 -> (string -> Result<std_path_PathBuf, std_io_Error>)), v2 : uint8, v3 : string) : Result<std_path_PathBuf, std_io_Error> =
    let v4 : string = method19(v0)
    let v5 : string option = method105(v0)
    let v6 : (string -> US5) = method5()
    let v7 : US5 option = v5 |> Option.map v6 
    let v18 : US5 = US5_1
    let v19 : US5 = v7 |> Option.defaultValue v18 
    let v23 : string = method106(v3)
    let v24 : bool = v2 >= 11uy
    if v24 then
        let v25 : string = $"file_system.read_link / path: {v0} / n: {v2} / path': {v0} / name: {v4}"
        let v26 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v27 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
        let v28 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v25 v27 
        let _v26 = v28 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v29 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
        let v30 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v25 v29 
        let _v26 = v30 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v31 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
        let v32 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v25 v31 
        let _v26 = v32 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v33 : std_io_Error = v25 |> unbox<std_io_Error>
        let _v26 = v33 
        #endif
#if FABLE_COMPILER_PYTHON
        let v36 : std_io_Error = v25 |> unbox<std_io_Error>
        let _v26 = v36 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v39 : std_io_Error = v25 |> unbox<std_io_Error>
        let _v26 = v39 
        #endif
#else
        let v42 : std_io_Error = v25 |> unbox<std_io_Error>
        let _v26 = v42 
        #endif
        let v45 : std_io_Error = _v26 
        let v50 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v51 : string = "Err($0)"
        let v52 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v45 v51 
        let _v50 = v52 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v53 : string = "Err($0)"
        let v54 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v45 v53 
        let _v50 = v54 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v55 : string = "Err($0)"
        let v56 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v45 v55 
        let _v50 = v56 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v57 : Result<std_path_PathBuf, std_io_Error> = v45 |> Error
        let _v50 = v57 
        #endif
#if FABLE_COMPILER_PYTHON
        let v58 : Result<std_path_PathBuf, std_io_Error> = v45 |> Error
        let _v50 = v58 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v59 : Result<std_path_PathBuf, std_io_Error> = v45 |> Error
        let _v50 = v59 
        #endif
#else
        let v60 : Result<std_path_PathBuf, std_io_Error> = v45 |> Error
        let _v50 = v60 
        #endif
        let v61 : Result<std_path_PathBuf, std_io_Error> = _v50 
        v61
    else
        match v19 with
        | US5_0(v64) -> (* Some *)
            let v65 : string = ""
            let v66 : bool = v0 <> v65 
            if v66 then
                let v69 : uint8 = v2 + 1uy
                let v70 : (string -> Result<std_path_PathBuf, std_io_Error>) = v1 v69
                let v71 : Result<std_path_PathBuf, std_io_Error> = v70 v64
                let v72 : (std_io_Error -> string) = method99()
                let v73 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v74 : string = "$0.map_err(|x| $1(x))"
                let v75 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v71, v72) v74 
                let _v73 = v75 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v76 : string = "$0.map_err(|x| $1(x))"
                let v77 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v71, v72) v76 
                let _v73 = v77 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v78 : string = "$0.map_err(|x| $1(x))"
                let v79 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v71, v72) v78 
                let _v73 = v79 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v80 : Result<std_path_PathBuf, string> = match v71 with Ok x -> Ok x | Error x -> Error (v72 x)
                let _v73 = v80 
                #endif
#if FABLE_COMPILER_PYTHON
                let v81 : Result<std_path_PathBuf, string> = match v71 with Ok x -> Ok x | Error x -> Error (v72 x)
                let _v73 = v81 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v82 : Result<std_path_PathBuf, string> = match v71 with Ok x -> Ok x | Error x -> Error (v72 x)
                let _v73 = v82 
                #endif
#else
                let v83 : Result<std_path_PathBuf, string> = match v71 with Ok x -> Ok x | Error x -> Error (v72 x)
                let _v73 = v83 
                #endif
                let v84 : Result<std_path_PathBuf, string> = _v73 
                let v87 : (std_path_PathBuf -> US13) = method101()
                let v88 : (string -> US13) = method102()
                let v89 : US13 = match v84 with Ok x -> v87 x | Error x -> v88 x
                match v89 with
                | US13_1(v205) -> (* Error *)
                    let v206 : string = $"file_system.read_link / error': {v205} / error: {v23} / name: {v4}"
                    let v207 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v208 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                    let v209 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v206 v208 
                    let _v207 = v209 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v210 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                    let v211 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v206 v210 
                    let _v207 = v211 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v212 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                    let v213 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v206 v212 
                    let _v207 = v213 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v214 : std_io_Error = v206 |> unbox<std_io_Error>
                    let _v207 = v214 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v217 : std_io_Error = v206 |> unbox<std_io_Error>
                    let _v207 = v217 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v220 : std_io_Error = v206 |> unbox<std_io_Error>
                    let _v207 = v220 
                    #endif
#else
                    let v223 : std_io_Error = v206 |> unbox<std_io_Error>
                    let _v207 = v223 
                    #endif
                    let v226 : std_io_Error = _v207 
                    let v231 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v232 : string = "Err($0)"
                    let v233 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v226 v232 
                    let _v231 = v233 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v234 : string = "Err($0)"
                    let v235 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v226 v234 
                    let _v231 = v235 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v236 : string = "Err($0)"
                    let v237 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v226 v236 
                    let _v231 = v237 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v238 : Result<std_path_PathBuf, std_io_Error> = v226 |> Error
                    let _v231 = v238 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v239 : Result<std_path_PathBuf, std_io_Error> = v226 |> Error
                    let _v231 = v239 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v240 : Result<std_path_PathBuf, std_io_Error> = v226 |> Error
                    let _v231 = v240 
                    #endif
#else
                    let v241 : Result<std_path_PathBuf, std_io_Error> = v226 |> Error
                    let _v231 = v241 
                    #endif
                    let v242 : Result<std_path_PathBuf, std_io_Error> = _v231 
                    v242
                | US13_0(v90) -> (* Ok *)
                    let v91 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v92 : string = "$0.display()"
                    let v93 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v90 v92 
                    let _v91 = v93 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v94 : string = "$0.display()"
                    let v95 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v90 v94 
                    let _v91 = v95 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v96 : string = "$0.display()"
                    let v97 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v90 v96 
                    let _v91 = v97 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v98 : std_path_Display = v90 |> unbox<std_path_Display>
                    let _v91 = v98 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v101 : std_path_Display = v90 |> unbox<std_path_Display>
                    let _v91 = v101 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v104 : std_path_Display = v90 |> unbox<std_path_Display>
                    let _v91 = v104 
                    #endif
#else
                    let v107 : std_path_Display = v90 |> unbox<std_path_Display>
                    let _v91 = v107 
                    #endif
                    let v110 : std_path_Display = _v91 
                    let v115 : string = v110 |> string 
                    let v118 : string = method75(v115, v4)
                    let v119 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v120 : string = "&*$0"
                    let v121 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v118 v120 
                    let _v119 = v121 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v122 : string = "&*$0"
                    let v123 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v118 v122 
                    let _v119 = v123 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v124 : string = "&*$0"
                    let v125 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v118 v124 
                    let _v119 = v125 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v126 : Ref<Str> = v118 |> unbox<Ref<Str>>
                    let _v119 = v126 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v129 : Ref<Str> = v118 |> unbox<Ref<Str>>
                    let _v119 = v129 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v132 : Ref<Str> = v118 |> unbox<Ref<Str>>
                    let _v119 = v132 
                    #endif
#else
                    let v135 : Ref<Str> = v118 |> unbox<Ref<Str>>
                    let _v119 = v135 
                    #endif
                    let v138 : Ref<Str> = _v119 
                    let v143 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v144 : string = "String::from($0)"
                    let v145 : std_string_String = Fable.Core.RustInterop.emitRustExpr v138 v144 
                    let _v143 = v145 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v146 : string = "String::from($0)"
                    let v147 : std_string_String = Fable.Core.RustInterop.emitRustExpr v138 v146 
                    let _v143 = v147 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v148 : string = "String::from($0)"
                    let v149 : std_string_String = Fable.Core.RustInterop.emitRustExpr v138 v148 
                    let _v143 = v149 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v150 : std_string_String = v138 |> unbox<std_string_String>
                    let _v143 = v150 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v153 : std_string_String = v138 |> unbox<std_string_String>
                    let _v143 = v153 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v156 : std_string_String = v138 |> unbox<std_string_String>
                    let _v143 = v156 
                    #endif
#else
                    let v159 : std_string_String = v138 |> unbox<std_string_String>
                    let _v143 = v159 
                    #endif
                    let v162 : std_string_String = _v143 
                    let v167 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v168 : string = "std::path::PathBuf::from($0)"
                    let v169 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v162 v168 
                    let _v167 = v169 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v170 : string = "std::path::PathBuf::from($0)"
                    let v171 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v162 v170 
                    let _v167 = v171 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v172 : string = "std::path::PathBuf::from($0)"
                    let v173 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v162 v172 
                    let _v167 = v173 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v174 : std_path_PathBuf = v162 |> unbox<std_path_PathBuf>
                    let _v167 = v174 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v177 : std_path_PathBuf = v162 |> unbox<std_path_PathBuf>
                    let _v167 = v177 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v180 : std_path_PathBuf = v162 |> unbox<std_path_PathBuf>
                    let _v167 = v180 
                    #endif
#else
                    let v183 : std_path_PathBuf = v162 |> unbox<std_path_PathBuf>
                    let _v167 = v183 
                    #endif
                    let v186 : std_path_PathBuf = _v167 
                    let v191 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v192 : string = "Ok($0)"
                    let v193 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v186 v192 
                    let _v191 = v193 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v194 : string = "Ok($0)"
                    let v195 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v186 v194 
                    let _v191 = v195 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v196 : string = "Ok($0)"
                    let v197 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v186 v196 
                    let _v191 = v197 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v198 : Result<std_path_PathBuf, std_io_Error> = v186 |> Ok
                    let _v191 = v198 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v199 : Result<std_path_PathBuf, std_io_Error> = v186 |> Ok
                    let _v191 = v199 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v200 : Result<std_path_PathBuf, std_io_Error> = v186 |> Ok
                    let _v191 = v200 
                    #endif
#else
                    let v201 : Result<std_path_PathBuf, std_io_Error> = v186 |> Ok
                    let _v191 = v201 
                    #endif
                    let v202 : Result<std_path_PathBuf, std_io_Error> = _v191 
                    v202
            else
                let v247 : string = $"file_system.read_link / run / The file or directory is not a reparse point. / path: {v0} / error: {v23} / path': {v0} / name: {v4}"
                let v248 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v249 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                let v250 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v247 v249 
                let _v248 = v250 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v251 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                let v252 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v247 v251 
                let _v248 = v252 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v253 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                let v254 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v247 v253 
                let _v248 = v254 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v255 : std_io_Error = v247 |> unbox<std_io_Error>
                let _v248 = v255 
                #endif
#if FABLE_COMPILER_PYTHON
                let v258 : std_io_Error = v247 |> unbox<std_io_Error>
                let _v248 = v258 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v261 : std_io_Error = v247 |> unbox<std_io_Error>
                let _v248 = v261 
                #endif
#else
                let v264 : std_io_Error = v247 |> unbox<std_io_Error>
                let _v248 = v264 
                #endif
                let v267 : std_io_Error = _v248 
                let v272 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v273 : string = "Err($0)"
                let v274 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v267 v273 
                let _v272 = v274 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v275 : string = "Err($0)"
                let v276 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v267 v275 
                let _v272 = v276 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v277 : string = "Err($0)"
                let v278 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v267 v277 
                let _v272 = v278 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v279 : Result<std_path_PathBuf, std_io_Error> = v267 |> Error
                let _v272 = v279 
                #endif
#if FABLE_COMPILER_PYTHON
                let v280 : Result<std_path_PathBuf, std_io_Error> = v267 |> Error
                let _v272 = v280 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v281 : Result<std_path_PathBuf, std_io_Error> = v267 |> Error
                let _v272 = v281 
                #endif
#else
                let v282 : Result<std_path_PathBuf, std_io_Error> = v267 |> Error
                let _v272 = v282 
                #endif
                let v283 : Result<std_path_PathBuf, std_io_Error> = _v272 
                v283
        | _ ->
            let v287 : string = $"file_system.read_link / run / The file or directory is not a reparse point. / path: {v0} / error: {v23} / path': {v0} / name: {v4}"
            let v288 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v289 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
            let v290 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v287 v289 
            let _v288 = v290 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v291 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
            let v292 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v287 v291 
            let _v288 = v292 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v293 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
            let v294 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v287 v293 
            let _v288 = v294 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v295 : std_io_Error = v287 |> unbox<std_io_Error>
            let _v288 = v295 
            #endif
#if FABLE_COMPILER_PYTHON
            let v298 : std_io_Error = v287 |> unbox<std_io_Error>
            let _v288 = v298 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v301 : std_io_Error = v287 |> unbox<std_io_Error>
            let _v288 = v301 
            #endif
#else
            let v304 : std_io_Error = v287 |> unbox<std_io_Error>
            let _v288 = v304 
            #endif
            let v307 : std_io_Error = _v288 
            let v312 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v313 : string = "Err($0)"
            let v314 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v307 v313 
            let _v312 = v314 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v315 : string = "Err($0)"
            let v316 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v307 v315 
            let _v312 = v316 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v317 : string = "Err($0)"
            let v318 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v307 v317 
            let _v312 = v318 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v319 : Result<std_path_PathBuf, std_io_Error> = v307 |> Error
            let _v312 = v319 
            #endif
#if FABLE_COMPILER_PYTHON
            let v320 : Result<std_path_PathBuf, std_io_Error> = v307 |> Error
            let _v312 = v320 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v321 : Result<std_path_PathBuf, std_io_Error> = v307 |> Error
            let _v312 = v321 
            #endif
#else
            let v322 : Result<std_path_PathBuf, std_io_Error> = v307 |> Error
            let _v312 = v322 
            #endif
            let v323 : Result<std_path_PathBuf, std_io_Error> = _v312 
            v323
and method98 (v0 : string, v1 : uint8) : Result<std_path_PathBuf, std_io_Error> =
    let v2 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : string = "std::fs::read_link(&*$0)"
    let v4 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v0 v3 
    let v5 : (std_io_Error -> string) = method99()
    let v6 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v7 : string = "$0.map_err(|x| $1(x))"
    let v8 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v4, v5) v7 
    let _v6 = v8 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v9 : string = "$0.map_err(|x| $1(x))"
    let v10 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v4, v5) v9 
    let _v6 = v10 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v11 : string = "$0.map_err(|x| $1(x))"
    let v12 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v4, v5) v11 
    let _v6 = v12 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v13 : Result<std_path_PathBuf, string> = match v4 with Ok x -> Ok x | Error x -> Error (v5 x)
    let _v6 = v13 
    #endif
#if FABLE_COMPILER_PYTHON
    let v14 : Result<std_path_PathBuf, string> = match v4 with Ok x -> Ok x | Error x -> Error (v5 x)
    let _v6 = v14 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v15 : Result<std_path_PathBuf, string> = match v4 with Ok x -> Ok x | Error x -> Error (v5 x)
    let _v6 = v15 
    #endif
#else
    let v16 : Result<std_path_PathBuf, string> = match v4 with Ok x -> Ok x | Error x -> Error (v5 x)
    let _v6 = v16 
    #endif
    let v17 : Result<std_path_PathBuf, string> = _v6 
    let v20 : (std_path_PathBuf -> US13) = method101()
    let v21 : (string -> US13) = method102()
    let v22 : US13 = match v17 with Ok x -> v20 x | Error x -> v21 x
    let v42 : Result<std_path_PathBuf, std_io_Error> =
        match v22 with
        | US13_1(v38) -> (* Error *)
            let v39 : (uint8 -> (string -> Result<std_path_PathBuf, std_io_Error>)) = closure49(v0)
            method107(v0, v39, v1, v38)
        | US13_0(v23) -> (* Ok *)
            let v24 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v25 : string = "Ok($0)"
            let v26 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v23 v25 
            let _v24 = v26 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v27 : string = "Ok($0)"
            let v28 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v23 v27 
            let _v24 = v28 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v29 : string = "Ok($0)"
            let v30 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v23 v29 
            let _v24 = v30 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v31 : Result<std_path_PathBuf, std_io_Error> = v23 |> Ok
            let _v24 = v31 
            #endif
#if FABLE_COMPILER_PYTHON
            let v32 : Result<std_path_PathBuf, std_io_Error> = v23 |> Ok
            let _v24 = v32 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v33 : Result<std_path_PathBuf, std_io_Error> = v23 |> Ok
            let _v24 = v33 
            #endif
#else
            let v34 : Result<std_path_PathBuf, std_io_Error> = v23 |> Ok
            let _v24 = v34 
            #endif
            let v35 : Result<std_path_PathBuf, std_io_Error> = _v24 
            v35
    let _v2 = v42 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v43 : string = "std::fs::read_link(&*$0)"
    let v44 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v0 v43 
    let v45 : (std_io_Error -> string) = method99()
    let v46 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v47 : string = "$0.map_err(|x| $1(x))"
    let v48 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v44, v45) v47 
    let _v46 = v48 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v49 : string = "$0.map_err(|x| $1(x))"
    let v50 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v44, v45) v49 
    let _v46 = v50 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v51 : string = "$0.map_err(|x| $1(x))"
    let v52 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v44, v45) v51 
    let _v46 = v52 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v53 : Result<std_path_PathBuf, string> = match v44 with Ok x -> Ok x | Error x -> Error (v45 x)
    let _v46 = v53 
    #endif
#if FABLE_COMPILER_PYTHON
    let v54 : Result<std_path_PathBuf, string> = match v44 with Ok x -> Ok x | Error x -> Error (v45 x)
    let _v46 = v54 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v55 : Result<std_path_PathBuf, string> = match v44 with Ok x -> Ok x | Error x -> Error (v45 x)
    let _v46 = v55 
    #endif
#else
    let v56 : Result<std_path_PathBuf, string> = match v44 with Ok x -> Ok x | Error x -> Error (v45 x)
    let _v46 = v56 
    #endif
    let v57 : Result<std_path_PathBuf, string> = _v46 
    let v60 : (std_path_PathBuf -> US13) = method101()
    let v61 : (string -> US13) = method102()
    let v62 : US13 = match v57 with Ok x -> v60 x | Error x -> v61 x
    let v82 : Result<std_path_PathBuf, std_io_Error> =
        match v62 with
        | US13_1(v78) -> (* Error *)
            let v79 : (uint8 -> (string -> Result<std_path_PathBuf, std_io_Error>)) = closure49(v0)
            method107(v0, v79, v1, v78)
        | US13_0(v63) -> (* Ok *)
            let v64 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v65 : string = "Ok($0)"
            let v66 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v63 v65 
            let _v64 = v66 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v67 : string = "Ok($0)"
            let v68 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v63 v67 
            let _v64 = v68 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v69 : string = "Ok($0)"
            let v70 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v63 v69 
            let _v64 = v70 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v71 : Result<std_path_PathBuf, std_io_Error> = v63 |> Ok
            let _v64 = v71 
            #endif
#if FABLE_COMPILER_PYTHON
            let v72 : Result<std_path_PathBuf, std_io_Error> = v63 |> Ok
            let _v64 = v72 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v73 : Result<std_path_PathBuf, std_io_Error> = v63 |> Ok
            let _v64 = v73 
            #endif
#else
            let v74 : Result<std_path_PathBuf, std_io_Error> = v63 |> Ok
            let _v64 = v74 
            #endif
            let v75 : Result<std_path_PathBuf, std_io_Error> = _v64 
            v75
    let _v2 = v82 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v83 : string = "std::fs::read_link(&*$0)"
    let v84 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v0 v83 
    let v85 : (std_io_Error -> string) = method99()
    let v86 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v87 : string = "$0.map_err(|x| $1(x))"
    let v88 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v84, v85) v87 
    let _v86 = v88 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v89 : string = "$0.map_err(|x| $1(x))"
    let v90 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v84, v85) v89 
    let _v86 = v90 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v91 : string = "$0.map_err(|x| $1(x))"
    let v92 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v84, v85) v91 
    let _v86 = v92 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v93 : Result<std_path_PathBuf, string> = match v84 with Ok x -> Ok x | Error x -> Error (v85 x)
    let _v86 = v93 
    #endif
#if FABLE_COMPILER_PYTHON
    let v94 : Result<std_path_PathBuf, string> = match v84 with Ok x -> Ok x | Error x -> Error (v85 x)
    let _v86 = v94 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v95 : Result<std_path_PathBuf, string> = match v84 with Ok x -> Ok x | Error x -> Error (v85 x)
    let _v86 = v95 
    #endif
#else
    let v96 : Result<std_path_PathBuf, string> = match v84 with Ok x -> Ok x | Error x -> Error (v85 x)
    let _v86 = v96 
    #endif
    let v97 : Result<std_path_PathBuf, string> = _v86 
    let v100 : (std_path_PathBuf -> US13) = method101()
    let v101 : (string -> US13) = method102()
    let v102 : US13 = match v97 with Ok x -> v100 x | Error x -> v101 x
    let v122 : Result<std_path_PathBuf, std_io_Error> =
        match v102 with
        | US13_1(v118) -> (* Error *)
            let v119 : (uint8 -> (string -> Result<std_path_PathBuf, std_io_Error>)) = closure49(v0)
            method107(v0, v119, v1, v118)
        | US13_0(v103) -> (* Ok *)
            let v104 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v105 : string = "Ok($0)"
            let v106 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v103 v105 
            let _v104 = v106 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v107 : string = "Ok($0)"
            let v108 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v103 v107 
            let _v104 = v108 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v109 : string = "Ok($0)"
            let v110 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v103 v109 
            let _v104 = v110 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v111 : Result<std_path_PathBuf, std_io_Error> = v103 |> Ok
            let _v104 = v111 
            #endif
#if FABLE_COMPILER_PYTHON
            let v112 : Result<std_path_PathBuf, std_io_Error> = v103 |> Ok
            let _v104 = v112 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v113 : Result<std_path_PathBuf, std_io_Error> = v103 |> Ok
            let _v104 = v113 
            #endif
#else
            let v114 : Result<std_path_PathBuf, std_io_Error> = v103 |> Ok
            let _v104 = v114 
            #endif
            let v115 : Result<std_path_PathBuf, std_io_Error> = _v104 
            v115
    let _v2 = v122 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v123 : Result<std_path_PathBuf, std_io_Error> = null |> unbox<Result<std_path_PathBuf, std_io_Error>>
    let _v2 = v123 
    #endif
#if FABLE_COMPILER_PYTHON
    let v126 : Result<std_path_PathBuf, std_io_Error> = null |> unbox<Result<std_path_PathBuf, std_io_Error>>
    let _v2 = v126 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v129 : Result<std_path_PathBuf, std_io_Error> = null |> unbox<Result<std_path_PathBuf, std_io_Error>>
    let _v2 = v129 
    #endif
#else
    let v132 : Result<std_path_PathBuf, std_io_Error> = null |> unbox<Result<std_path_PathBuf, std_io_Error>>
    let _v2 = v132 
    #endif
    let v135 : Result<std_path_PathBuf, std_io_Error> = _v2 
    v135
and method109 (v0 : System_IO_DirectoryInfo) : System.IO.FileAttributes =
    let v1 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : System.IO.FileAttributes = null |> unbox<System.IO.FileAttributes>
    let _v1 = v2 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v5 : System.IO.FileAttributes = null |> unbox<System.IO.FileAttributes>
    let _v1 = v5 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v8 : System.IO.FileAttributes = null |> unbox<System.IO.FileAttributes>
    let _v1 = v8 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v11 : System.IO.FileAttributes = null |> unbox<System.IO.FileAttributes>
    let _v1 = v11 
    #endif
#if FABLE_COMPILER_PYTHON
    let v14 : System.IO.FileAttributes = null |> unbox<System.IO.FileAttributes>
    let _v1 = v14 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v17 : System.IO.FileAttributes = null |> unbox<System.IO.FileAttributes>
    let _v1 = v17 
    #endif
#else
    let v20 : (System_IO_DirectoryInfo -> System.IO.FileAttributes) = _.Attributes
    let v21 : System.IO.FileAttributes = v20 v0
    let _v1 = v21 
    #endif
    let v22 : System.IO.FileAttributes = _v1 
    v22
and method110 () : System.IO.FileAttributes =
    let v0 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1 : System.IO.FileAttributes = null |> unbox<System.IO.FileAttributes>
    let _v0 = v1 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v4 : System.IO.FileAttributes = null |> unbox<System.IO.FileAttributes>
    let _v0 = v4 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v7 : System.IO.FileAttributes = null |> unbox<System.IO.FileAttributes>
    let _v0 = v7 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v10 : System.IO.FileAttributes = null |> unbox<System.IO.FileAttributes>
    let _v0 = v10 
    #endif
#if FABLE_COMPILER_PYTHON
    let v13 : System.IO.FileAttributes = null |> unbox<System.IO.FileAttributes>
    let _v0 = v13 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v16 : System.IO.FileAttributes = null |> unbox<System.IO.FileAttributes>
    let _v0 = v16 
    #endif
#else
    let v19 : System.IO.FileAttributes = System.IO.FileAttributes.ReparsePoint
    let _v0 = v19 
    #endif
    let v20 : System.IO.FileAttributes = _v0 
    v20
and method111 (v0 : System.IO.FileAttributes, v1 : System.IO.FileAttributes) : bool =
    let v2 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : bool = null |> unbox<bool>
    let _v2 = v3 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v6 : bool = null |> unbox<bool>
    let _v2 = v6 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v9 : bool = null |> unbox<bool>
    let _v2 = v9 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v12 : bool = null |> unbox<bool>
    let _v2 = v12 
    #endif
#if FABLE_COMPILER_PYTHON
    let v15 : bool = null |> unbox<bool>
    let _v2 = v15 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v18 : bool = null |> unbox<bool>
    let _v2 = v18 
    #endif
#else
    let v21 : bool = v1.HasFlag v0 
    let _v2 = v21 
    #endif
    let v22 : bool = _v2 
    v22
and method113 (v0 : string, v1 : (uint8 -> (string -> Result<std_path_PathBuf, std_io_Error>)), v2 : uint8, v3 : std_io_Error, v4 : string) : Result<std_path_PathBuf, std_io_Error> =
    let v5 : string = method19(v4)
    let v6 : string option = method105(v4)
    let v7 : (string -> US5) = method5()
    let v8 : US5 option = v6 |> Option.map v7 
    let v19 : US5 = US5_1
    let v20 : US5 = v8 |> Option.defaultValue v19 
    let v24 : string = method100(v3)
    let v25 : bool = v2 >= 11uy
    if v25 then
        let v26 : string = $"file_system.read_link / path: {v0} / n: {v2} / path': {v4} / name: {v5}"
        let v27 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v28 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
        let v29 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v26 v28 
        let _v27 = v29 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v30 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
        let v31 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v26 v30 
        let _v27 = v31 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v32 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
        let v33 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v26 v32 
        let _v27 = v33 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v34 : std_io_Error = v26 |> unbox<std_io_Error>
        let _v27 = v34 
        #endif
#if FABLE_COMPILER_PYTHON
        let v37 : std_io_Error = v26 |> unbox<std_io_Error>
        let _v27 = v37 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v40 : std_io_Error = v26 |> unbox<std_io_Error>
        let _v27 = v40 
        #endif
#else
        let v43 : std_io_Error = v26 |> unbox<std_io_Error>
        let _v27 = v43 
        #endif
        let v46 : std_io_Error = _v27 
        let v51 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v52 : string = "Err($0)"
        let v53 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v46 v52 
        let _v51 = v53 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v54 : string = "Err($0)"
        let v55 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v46 v54 
        let _v51 = v55 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v56 : string = "Err($0)"
        let v57 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v46 v56 
        let _v51 = v57 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v58 : Result<std_path_PathBuf, std_io_Error> = v46 |> Error
        let _v51 = v58 
        #endif
#if FABLE_COMPILER_PYTHON
        let v59 : Result<std_path_PathBuf, std_io_Error> = v46 |> Error
        let _v51 = v59 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v60 : Result<std_path_PathBuf, std_io_Error> = v46 |> Error
        let _v51 = v60 
        #endif
#else
        let v61 : Result<std_path_PathBuf, std_io_Error> = v46 |> Error
        let _v51 = v61 
        #endif
        let v62 : Result<std_path_PathBuf, std_io_Error> = _v51 
        v62
    else
        match v20 with
        | US5_0(v65) -> (* Some *)
            let v66 : string = ""
            let v67 : bool = v4 <> v66 
            if v67 then
                let v70 : uint8 = v2 + 1uy
                let v71 : (string -> Result<std_path_PathBuf, std_io_Error>) = v1 v70
                let v72 : Result<std_path_PathBuf, std_io_Error> = v71 v65
                let v73 : (std_io_Error -> string) = method99()
                let v74 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v75 : string = "$0.map_err(|x| $1(x))"
                let v76 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v72, v73) v75 
                let _v74 = v76 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v77 : string = "$0.map_err(|x| $1(x))"
                let v78 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v72, v73) v77 
                let _v74 = v78 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v79 : string = "$0.map_err(|x| $1(x))"
                let v80 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v72, v73) v79 
                let _v74 = v80 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v81 : Result<std_path_PathBuf, string> = match v72 with Ok x -> Ok x | Error x -> Error (v73 x)
                let _v74 = v81 
                #endif
#if FABLE_COMPILER_PYTHON
                let v82 : Result<std_path_PathBuf, string> = match v72 with Ok x -> Ok x | Error x -> Error (v73 x)
                let _v74 = v82 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v83 : Result<std_path_PathBuf, string> = match v72 with Ok x -> Ok x | Error x -> Error (v73 x)
                let _v74 = v83 
                #endif
#else
                let v84 : Result<std_path_PathBuf, string> = match v72 with Ok x -> Ok x | Error x -> Error (v73 x)
                let _v74 = v84 
                #endif
                let v85 : Result<std_path_PathBuf, string> = _v74 
                let v88 : (std_path_PathBuf -> US13) = method101()
                let v89 : (string -> US13) = method102()
                let v90 : US13 = match v85 with Ok x -> v88 x | Error x -> v89 x
                match v90 with
                | US13_1(v206) -> (* Error *)
                    let v207 : string = $"file_system.read_link / error': {v206} / error: {v24} / name: {v5}"
                    let v208 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v209 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                    let v210 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v207 v209 
                    let _v208 = v210 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v211 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                    let v212 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v207 v211 
                    let _v208 = v212 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v213 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                    let v214 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v207 v213 
                    let _v208 = v214 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v215 : std_io_Error = v207 |> unbox<std_io_Error>
                    let _v208 = v215 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v218 : std_io_Error = v207 |> unbox<std_io_Error>
                    let _v208 = v218 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v221 : std_io_Error = v207 |> unbox<std_io_Error>
                    let _v208 = v221 
                    #endif
#else
                    let v224 : std_io_Error = v207 |> unbox<std_io_Error>
                    let _v208 = v224 
                    #endif
                    let v227 : std_io_Error = _v208 
                    let v232 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v233 : string = "Err($0)"
                    let v234 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v227 v233 
                    let _v232 = v234 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v235 : string = "Err($0)"
                    let v236 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v227 v235 
                    let _v232 = v236 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v237 : string = "Err($0)"
                    let v238 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v227 v237 
                    let _v232 = v238 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v239 : Result<std_path_PathBuf, std_io_Error> = v227 |> Error
                    let _v232 = v239 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v240 : Result<std_path_PathBuf, std_io_Error> = v227 |> Error
                    let _v232 = v240 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v241 : Result<std_path_PathBuf, std_io_Error> = v227 |> Error
                    let _v232 = v241 
                    #endif
#else
                    let v242 : Result<std_path_PathBuf, std_io_Error> = v227 |> Error
                    let _v232 = v242 
                    #endif
                    let v243 : Result<std_path_PathBuf, std_io_Error> = _v232 
                    v243
                | US13_0(v91) -> (* Ok *)
                    let v92 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v93 : string = "$0.display()"
                    let v94 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v91 v93 
                    let _v92 = v94 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v95 : string = "$0.display()"
                    let v96 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v91 v95 
                    let _v92 = v96 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v97 : string = "$0.display()"
                    let v98 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v91 v97 
                    let _v92 = v98 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v99 : std_path_Display = v91 |> unbox<std_path_Display>
                    let _v92 = v99 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v102 : std_path_Display = v91 |> unbox<std_path_Display>
                    let _v92 = v102 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v105 : std_path_Display = v91 |> unbox<std_path_Display>
                    let _v92 = v105 
                    #endif
#else
                    let v108 : std_path_Display = v91 |> unbox<std_path_Display>
                    let _v92 = v108 
                    #endif
                    let v111 : std_path_Display = _v92 
                    let v116 : string = v111 |> string 
                    let v119 : string = method75(v116, v5)
                    let v120 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v121 : string = "&*$0"
                    let v122 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v119 v121 
                    let _v120 = v122 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v123 : string = "&*$0"
                    let v124 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v119 v123 
                    let _v120 = v124 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v125 : string = "&*$0"
                    let v126 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v119 v125 
                    let _v120 = v126 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v127 : Ref<Str> = v119 |> unbox<Ref<Str>>
                    let _v120 = v127 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v130 : Ref<Str> = v119 |> unbox<Ref<Str>>
                    let _v120 = v130 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v133 : Ref<Str> = v119 |> unbox<Ref<Str>>
                    let _v120 = v133 
                    #endif
#else
                    let v136 : Ref<Str> = v119 |> unbox<Ref<Str>>
                    let _v120 = v136 
                    #endif
                    let v139 : Ref<Str> = _v120 
                    let v144 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v145 : string = "String::from($0)"
                    let v146 : std_string_String = Fable.Core.RustInterop.emitRustExpr v139 v145 
                    let _v144 = v146 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v147 : string = "String::from($0)"
                    let v148 : std_string_String = Fable.Core.RustInterop.emitRustExpr v139 v147 
                    let _v144 = v148 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v149 : string = "String::from($0)"
                    let v150 : std_string_String = Fable.Core.RustInterop.emitRustExpr v139 v149 
                    let _v144 = v150 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v151 : std_string_String = v139 |> unbox<std_string_String>
                    let _v144 = v151 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v154 : std_string_String = v139 |> unbox<std_string_String>
                    let _v144 = v154 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v157 : std_string_String = v139 |> unbox<std_string_String>
                    let _v144 = v157 
                    #endif
#else
                    let v160 : std_string_String = v139 |> unbox<std_string_String>
                    let _v144 = v160 
                    #endif
                    let v163 : std_string_String = _v144 
                    let v168 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v169 : string = "std::path::PathBuf::from($0)"
                    let v170 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v163 v169 
                    let _v168 = v170 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v171 : string = "std::path::PathBuf::from($0)"
                    let v172 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v163 v171 
                    let _v168 = v172 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v173 : string = "std::path::PathBuf::from($0)"
                    let v174 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v163 v173 
                    let _v168 = v174 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v175 : std_path_PathBuf = v163 |> unbox<std_path_PathBuf>
                    let _v168 = v175 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v178 : std_path_PathBuf = v163 |> unbox<std_path_PathBuf>
                    let _v168 = v178 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v181 : std_path_PathBuf = v163 |> unbox<std_path_PathBuf>
                    let _v168 = v181 
                    #endif
#else
                    let v184 : std_path_PathBuf = v163 |> unbox<std_path_PathBuf>
                    let _v168 = v184 
                    #endif
                    let v187 : std_path_PathBuf = _v168 
                    let v192 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v193 : string = "Ok($0)"
                    let v194 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v187 v193 
                    let _v192 = v194 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v195 : string = "Ok($0)"
                    let v196 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v187 v195 
                    let _v192 = v196 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v197 : string = "Ok($0)"
                    let v198 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v187 v197 
                    let _v192 = v198 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v199 : Result<std_path_PathBuf, std_io_Error> = v187 |> Ok
                    let _v192 = v199 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v200 : Result<std_path_PathBuf, std_io_Error> = v187 |> Ok
                    let _v192 = v200 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v201 : Result<std_path_PathBuf, std_io_Error> = v187 |> Ok
                    let _v192 = v201 
                    #endif
#else
                    let v202 : Result<std_path_PathBuf, std_io_Error> = v187 |> Ok
                    let _v192 = v202 
                    #endif
                    let v203 : Result<std_path_PathBuf, std_io_Error> = _v192 
                    v203
            else
                let v248 : string = $"file_system.read_link / run / The file or directory is not a reparse point. / path: {v0} / error: {v24} / path': {v4} / name: {v5}"
                let v249 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v250 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                let v251 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v248 v250 
                let _v249 = v251 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v252 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                let v253 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v248 v252 
                let _v249 = v253 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v254 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                let v255 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v248 v254 
                let _v249 = v255 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v256 : std_io_Error = v248 |> unbox<std_io_Error>
                let _v249 = v256 
                #endif
#if FABLE_COMPILER_PYTHON
                let v259 : std_io_Error = v248 |> unbox<std_io_Error>
                let _v249 = v259 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v262 : std_io_Error = v248 |> unbox<std_io_Error>
                let _v249 = v262 
                #endif
#else
                let v265 : std_io_Error = v248 |> unbox<std_io_Error>
                let _v249 = v265 
                #endif
                let v268 : std_io_Error = _v249 
                let v273 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v274 : string = "Err($0)"
                let v275 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v268 v274 
                let _v273 = v275 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v276 : string = "Err($0)"
                let v277 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v268 v276 
                let _v273 = v277 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v278 : string = "Err($0)"
                let v279 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v268 v278 
                let _v273 = v279 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v280 : Result<std_path_PathBuf, std_io_Error> = v268 |> Error
                let _v273 = v280 
                #endif
#if FABLE_COMPILER_PYTHON
                let v281 : Result<std_path_PathBuf, std_io_Error> = v268 |> Error
                let _v273 = v281 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v282 : Result<std_path_PathBuf, std_io_Error> = v268 |> Error
                let _v273 = v282 
                #endif
#else
                let v283 : Result<std_path_PathBuf, std_io_Error> = v268 |> Error
                let _v273 = v283 
                #endif
                let v284 : Result<std_path_PathBuf, std_io_Error> = _v273 
                v284
        | _ ->
            let v288 : string = $"file_system.read_link / run / The file or directory is not a reparse point. / path: {v0} / error: {v24} / path': {v4} / name: {v5}"
            let v289 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v290 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
            let v291 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v288 v290 
            let _v289 = v291 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v292 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
            let v293 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v288 v292 
            let _v289 = v293 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v294 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
            let v295 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v288 v294 
            let _v289 = v295 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v296 : std_io_Error = v288 |> unbox<std_io_Error>
            let _v289 = v296 
            #endif
#if FABLE_COMPILER_PYTHON
            let v299 : std_io_Error = v288 |> unbox<std_io_Error>
            let _v289 = v299 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v302 : std_io_Error = v288 |> unbox<std_io_Error>
            let _v289 = v302 
            #endif
#else
            let v305 : std_io_Error = v288 |> unbox<std_io_Error>
            let _v289 = v305 
            #endif
            let v308 : std_io_Error = _v289 
            let v313 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v314 : string = "Err($0)"
            let v315 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v308 v314 
            let _v313 = v315 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v316 : string = "Err($0)"
            let v317 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v308 v316 
            let _v313 = v317 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v318 : string = "Err($0)"
            let v319 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v308 v318 
            let _v313 = v319 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v320 : Result<std_path_PathBuf, std_io_Error> = v308 |> Error
            let _v313 = v320 
            #endif
#if FABLE_COMPILER_PYTHON
            let v321 : Result<std_path_PathBuf, std_io_Error> = v308 |> Error
            let _v313 = v321 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v322 : Result<std_path_PathBuf, std_io_Error> = v308 |> Error
            let _v313 = v322 
            #endif
#else
            let v323 : Result<std_path_PathBuf, std_io_Error> = v308 |> Error
            let _v313 = v323 
            #endif
            let v324 : Result<std_path_PathBuf, std_io_Error> = _v313 
            v324
and method112 (v0 : string, v1 : uint8, v2 : string) : Result<std_path_PathBuf, std_io_Error> =
    let v3 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v4 : System_IO_DirectoryInfo = null |> unbox<System_IO_DirectoryInfo>
    let _v3 = v4 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v7 : System_IO_DirectoryInfo = null |> unbox<System_IO_DirectoryInfo>
    let _v3 = v7 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v10 : System_IO_DirectoryInfo = null |> unbox<System_IO_DirectoryInfo>
    let _v3 = v10 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v13 : System_IO_DirectoryInfo = null |> unbox<System_IO_DirectoryInfo>
    let _v3 = v13 
    #endif
#if FABLE_COMPILER_PYTHON
    let v16 : System_IO_DirectoryInfo = null |> unbox<System_IO_DirectoryInfo>
    let _v3 = v16 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v19 : System_IO_DirectoryInfo = null |> unbox<System_IO_DirectoryInfo>
    let _v3 = v19 
    #endif
#else
    let v22 : System_IO_DirectoryInfo = v2 |> System_IO_DirectoryInfo 
    let _v3 = v22 
    #endif
    let v25 : System_IO_DirectoryInfo = _v3 
    let v30 : System.IO.FileAttributes = method109(v25)
    let v31 : System.IO.FileAttributes = method110()
    let v32 : bool = method111(v31, v30)
    if v32 then
        let v33 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v34 : System_IO_FileInfo = null |> unbox<System_IO_FileInfo>
        let _v33 = v34 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v37 : System_IO_FileInfo = null |> unbox<System_IO_FileInfo>
        let _v33 = v37 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v40 : System_IO_FileInfo = null |> unbox<System_IO_FileInfo>
        let _v33 = v40 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v43 : System_IO_FileInfo = null |> unbox<System_IO_FileInfo>
        let _v33 = v43 
        #endif
#if FABLE_COMPILER_PYTHON
        let v46 : System_IO_FileInfo = null |> unbox<System_IO_FileInfo>
        let _v33 = v46 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v49 : System_IO_FileInfo = null |> unbox<System_IO_FileInfo>
        let _v33 = v49 
        #endif
#else
        let v52 : System_IO_FileInfo = v2 |> System_IO_FileInfo 
        let _v33 = v52 
        #endif
        let v55 : System_IO_FileInfo = _v33 
        let v60 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v61 : string = null |> unbox<string>
        let _v60 = v61 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v64 : string = null |> unbox<string>
        let _v60 = v64 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v67 : string = null |> unbox<string>
        let _v60 = v67 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v70 : string = null |> unbox<string>
        let _v60 = v70 
        #endif
#if FABLE_COMPILER_PYTHON
        let v73 : string = null |> unbox<string>
        let _v60 = v73 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v76 : string = null |> unbox<string>
        let _v60 = v76 
        #endif
#else
        let v79 : (System_IO_FileInfo -> string) = _.LinkTarget
        let v80 : string = v79 v55
        let _v60 = v80 
        #endif
        let v81 : string = _v60 
        let v86 : std_path_PathBuf = v81 |> unbox<std_path_PathBuf>
        let v89 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v90 : string = "Ok($0)"
        let v91 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v86 v90 
        let _v89 = v91 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v92 : string = "Ok($0)"
        let v93 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v86 v92 
        let _v89 = v93 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v94 : string = "Ok($0)"
        let v95 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v86 v94 
        let _v89 = v95 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v96 : Result<std_path_PathBuf, std_io_Error> = v86 |> Ok
        let _v89 = v96 
        #endif
#if FABLE_COMPILER_PYTHON
        let v97 : Result<std_path_PathBuf, std_io_Error> = v86 |> Ok
        let _v89 = v97 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v98 : Result<std_path_PathBuf, std_io_Error> = v86 |> Ok
        let _v89 = v98 
        #endif
#else
        let v99 : Result<std_path_PathBuf, std_io_Error> = v86 |> Ok
        let _v89 = v99 
        #endif
        let v100 : Result<std_path_PathBuf, std_io_Error> = _v89 
        v100
    else
        let v103 : string = $"file_system.read_link / Fsharp / The file or directory is not a reparse point. / path: {v0} / result: {v32} / path': {v2} / n: {v1}"
        let v104 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v105 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
        let v106 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v103 v105 
        let _v104 = v106 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v107 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
        let v108 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v103 v107 
        let _v104 = v108 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v109 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
        let v110 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v103 v109 
        let _v104 = v110 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v111 : std_io_Error = v103 |> unbox<std_io_Error>
        let _v104 = v111 
        #endif
#if FABLE_COMPILER_PYTHON
        let v114 : std_io_Error = v103 |> unbox<std_io_Error>
        let _v104 = v114 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v117 : std_io_Error = v103 |> unbox<std_io_Error>
        let _v104 = v117 
        #endif
#else
        let v120 : std_io_Error = v103 |> unbox<std_io_Error>
        let _v104 = v120 
        #endif
        let v123 : std_io_Error = _v104 
        let v128 : (uint8 -> (string -> Result<std_path_PathBuf, std_io_Error>)) = closure51(v0)
        method113(v0, v128, v1, v123, v2)
and closure52 (v0 : string, v1 : uint8) (v2 : string) : Result<std_path_PathBuf, std_io_Error> =
    method112(v0, v1, v2)
and closure51 (v0 : string) (v1 : uint8) : (string -> Result<std_path_PathBuf, std_io_Error>) =
    closure52(v0, v1)
and method114 (v0 : string, v1 : (uint8 -> (string -> Result<std_path_PathBuf, std_io_Error>)), v2 : uint8, v3 : std_io_Error) : Result<std_path_PathBuf, std_io_Error> =
    let v4 : string = method19(v0)
    let v5 : string option = method105(v0)
    let v6 : (string -> US5) = method5()
    let v7 : US5 option = v5 |> Option.map v6 
    let v18 : US5 = US5_1
    let v19 : US5 = v7 |> Option.defaultValue v18 
    let v23 : string = method100(v3)
    let v24 : bool = v2 >= 11uy
    if v24 then
        let v25 : string = $"file_system.read_link / path: {v0} / n: {v2} / path': {v0} / name: {v4}"
        let v26 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v27 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
        let v28 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v25 v27 
        let _v26 = v28 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v29 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
        let v30 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v25 v29 
        let _v26 = v30 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v31 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
        let v32 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v25 v31 
        let _v26 = v32 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v33 : std_io_Error = v25 |> unbox<std_io_Error>
        let _v26 = v33 
        #endif
#if FABLE_COMPILER_PYTHON
        let v36 : std_io_Error = v25 |> unbox<std_io_Error>
        let _v26 = v36 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v39 : std_io_Error = v25 |> unbox<std_io_Error>
        let _v26 = v39 
        #endif
#else
        let v42 : std_io_Error = v25 |> unbox<std_io_Error>
        let _v26 = v42 
        #endif
        let v45 : std_io_Error = _v26 
        let v50 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v51 : string = "Err($0)"
        let v52 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v45 v51 
        let _v50 = v52 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v53 : string = "Err($0)"
        let v54 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v45 v53 
        let _v50 = v54 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v55 : string = "Err($0)"
        let v56 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v45 v55 
        let _v50 = v56 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v57 : Result<std_path_PathBuf, std_io_Error> = v45 |> Error
        let _v50 = v57 
        #endif
#if FABLE_COMPILER_PYTHON
        let v58 : Result<std_path_PathBuf, std_io_Error> = v45 |> Error
        let _v50 = v58 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v59 : Result<std_path_PathBuf, std_io_Error> = v45 |> Error
        let _v50 = v59 
        #endif
#else
        let v60 : Result<std_path_PathBuf, std_io_Error> = v45 |> Error
        let _v50 = v60 
        #endif
        let v61 : Result<std_path_PathBuf, std_io_Error> = _v50 
        v61
    else
        match v19 with
        | US5_0(v64) -> (* Some *)
            let v65 : string = ""
            let v66 : bool = v0 <> v65 
            if v66 then
                let v69 : uint8 = v2 + 1uy
                let v70 : (string -> Result<std_path_PathBuf, std_io_Error>) = v1 v69
                let v71 : Result<std_path_PathBuf, std_io_Error> = v70 v64
                let v72 : (std_io_Error -> string) = method99()
                let v73 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v74 : string = "$0.map_err(|x| $1(x))"
                let v75 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v71, v72) v74 
                let _v73 = v75 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v76 : string = "$0.map_err(|x| $1(x))"
                let v77 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v71, v72) v76 
                let _v73 = v77 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v78 : string = "$0.map_err(|x| $1(x))"
                let v79 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v71, v72) v78 
                let _v73 = v79 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v80 : Result<std_path_PathBuf, string> = match v71 with Ok x -> Ok x | Error x -> Error (v72 x)
                let _v73 = v80 
                #endif
#if FABLE_COMPILER_PYTHON
                let v81 : Result<std_path_PathBuf, string> = match v71 with Ok x -> Ok x | Error x -> Error (v72 x)
                let _v73 = v81 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v82 : Result<std_path_PathBuf, string> = match v71 with Ok x -> Ok x | Error x -> Error (v72 x)
                let _v73 = v82 
                #endif
#else
                let v83 : Result<std_path_PathBuf, string> = match v71 with Ok x -> Ok x | Error x -> Error (v72 x)
                let _v73 = v83 
                #endif
                let v84 : Result<std_path_PathBuf, string> = _v73 
                let v87 : (std_path_PathBuf -> US13) = method101()
                let v88 : (string -> US13) = method102()
                let v89 : US13 = match v84 with Ok x -> v87 x | Error x -> v88 x
                match v89 with
                | US13_1(v205) -> (* Error *)
                    let v206 : string = $"file_system.read_link / error': {v205} / error: {v23} / name: {v4}"
                    let v207 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v208 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                    let v209 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v206 v208 
                    let _v207 = v209 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v210 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                    let v211 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v206 v210 
                    let _v207 = v211 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v212 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                    let v213 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v206 v212 
                    let _v207 = v213 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v214 : std_io_Error = v206 |> unbox<std_io_Error>
                    let _v207 = v214 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v217 : std_io_Error = v206 |> unbox<std_io_Error>
                    let _v207 = v217 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v220 : std_io_Error = v206 |> unbox<std_io_Error>
                    let _v207 = v220 
                    #endif
#else
                    let v223 : std_io_Error = v206 |> unbox<std_io_Error>
                    let _v207 = v223 
                    #endif
                    let v226 : std_io_Error = _v207 
                    let v231 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v232 : string = "Err($0)"
                    let v233 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v226 v232 
                    let _v231 = v233 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v234 : string = "Err($0)"
                    let v235 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v226 v234 
                    let _v231 = v235 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v236 : string = "Err($0)"
                    let v237 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v226 v236 
                    let _v231 = v237 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v238 : Result<std_path_PathBuf, std_io_Error> = v226 |> Error
                    let _v231 = v238 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v239 : Result<std_path_PathBuf, std_io_Error> = v226 |> Error
                    let _v231 = v239 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v240 : Result<std_path_PathBuf, std_io_Error> = v226 |> Error
                    let _v231 = v240 
                    #endif
#else
                    let v241 : Result<std_path_PathBuf, std_io_Error> = v226 |> Error
                    let _v231 = v241 
                    #endif
                    let v242 : Result<std_path_PathBuf, std_io_Error> = _v231 
                    v242
                | US13_0(v90) -> (* Ok *)
                    let v91 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v92 : string = "$0.display()"
                    let v93 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v90 v92 
                    let _v91 = v93 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v94 : string = "$0.display()"
                    let v95 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v90 v94 
                    let _v91 = v95 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v96 : string = "$0.display()"
                    let v97 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v90 v96 
                    let _v91 = v97 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v98 : std_path_Display = v90 |> unbox<std_path_Display>
                    let _v91 = v98 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v101 : std_path_Display = v90 |> unbox<std_path_Display>
                    let _v91 = v101 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v104 : std_path_Display = v90 |> unbox<std_path_Display>
                    let _v91 = v104 
                    #endif
#else
                    let v107 : std_path_Display = v90 |> unbox<std_path_Display>
                    let _v91 = v107 
                    #endif
                    let v110 : std_path_Display = _v91 
                    let v115 : string = v110 |> string 
                    let v118 : string = method75(v115, v4)
                    let v119 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v120 : string = "&*$0"
                    let v121 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v118 v120 
                    let _v119 = v121 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v122 : string = "&*$0"
                    let v123 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v118 v122 
                    let _v119 = v123 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v124 : string = "&*$0"
                    let v125 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v118 v124 
                    let _v119 = v125 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v126 : Ref<Str> = v118 |> unbox<Ref<Str>>
                    let _v119 = v126 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v129 : Ref<Str> = v118 |> unbox<Ref<Str>>
                    let _v119 = v129 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v132 : Ref<Str> = v118 |> unbox<Ref<Str>>
                    let _v119 = v132 
                    #endif
#else
                    let v135 : Ref<Str> = v118 |> unbox<Ref<Str>>
                    let _v119 = v135 
                    #endif
                    let v138 : Ref<Str> = _v119 
                    let v143 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v144 : string = "String::from($0)"
                    let v145 : std_string_String = Fable.Core.RustInterop.emitRustExpr v138 v144 
                    let _v143 = v145 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v146 : string = "String::from($0)"
                    let v147 : std_string_String = Fable.Core.RustInterop.emitRustExpr v138 v146 
                    let _v143 = v147 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v148 : string = "String::from($0)"
                    let v149 : std_string_String = Fable.Core.RustInterop.emitRustExpr v138 v148 
                    let _v143 = v149 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v150 : std_string_String = v138 |> unbox<std_string_String>
                    let _v143 = v150 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v153 : std_string_String = v138 |> unbox<std_string_String>
                    let _v143 = v153 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v156 : std_string_String = v138 |> unbox<std_string_String>
                    let _v143 = v156 
                    #endif
#else
                    let v159 : std_string_String = v138 |> unbox<std_string_String>
                    let _v143 = v159 
                    #endif
                    let v162 : std_string_String = _v143 
                    let v167 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v168 : string = "std::path::PathBuf::from($0)"
                    let v169 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v162 v168 
                    let _v167 = v169 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v170 : string = "std::path::PathBuf::from($0)"
                    let v171 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v162 v170 
                    let _v167 = v171 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v172 : string = "std::path::PathBuf::from($0)"
                    let v173 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v162 v172 
                    let _v167 = v173 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v174 : std_path_PathBuf = v162 |> unbox<std_path_PathBuf>
                    let _v167 = v174 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v177 : std_path_PathBuf = v162 |> unbox<std_path_PathBuf>
                    let _v167 = v177 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v180 : std_path_PathBuf = v162 |> unbox<std_path_PathBuf>
                    let _v167 = v180 
                    #endif
#else
                    let v183 : std_path_PathBuf = v162 |> unbox<std_path_PathBuf>
                    let _v167 = v183 
                    #endif
                    let v186 : std_path_PathBuf = _v167 
                    let v191 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v192 : string = "Ok($0)"
                    let v193 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v186 v192 
                    let _v191 = v193 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v194 : string = "Ok($0)"
                    let v195 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v186 v194 
                    let _v191 = v195 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v196 : string = "Ok($0)"
                    let v197 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v186 v196 
                    let _v191 = v197 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v198 : Result<std_path_PathBuf, std_io_Error> = v186 |> Ok
                    let _v191 = v198 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v199 : Result<std_path_PathBuf, std_io_Error> = v186 |> Ok
                    let _v191 = v199 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v200 : Result<std_path_PathBuf, std_io_Error> = v186 |> Ok
                    let _v191 = v200 
                    #endif
#else
                    let v201 : Result<std_path_PathBuf, std_io_Error> = v186 |> Ok
                    let _v191 = v201 
                    #endif
                    let v202 : Result<std_path_PathBuf, std_io_Error> = _v191 
                    v202
            else
                let v247 : string = $"file_system.read_link / run / The file or directory is not a reparse point. / path: {v0} / error: {v23} / path': {v0} / name: {v4}"
                let v248 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v249 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                let v250 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v247 v249 
                let _v248 = v250 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v251 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                let v252 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v247 v251 
                let _v248 = v252 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v253 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                let v254 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v247 v253 
                let _v248 = v254 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v255 : std_io_Error = v247 |> unbox<std_io_Error>
                let _v248 = v255 
                #endif
#if FABLE_COMPILER_PYTHON
                let v258 : std_io_Error = v247 |> unbox<std_io_Error>
                let _v248 = v258 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v261 : std_io_Error = v247 |> unbox<std_io_Error>
                let _v248 = v261 
                #endif
#else
                let v264 : std_io_Error = v247 |> unbox<std_io_Error>
                let _v248 = v264 
                #endif
                let v267 : std_io_Error = _v248 
                let v272 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v273 : string = "Err($0)"
                let v274 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v267 v273 
                let _v272 = v274 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v275 : string = "Err($0)"
                let v276 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v267 v275 
                let _v272 = v276 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v277 : string = "Err($0)"
                let v278 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v267 v277 
                let _v272 = v278 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v279 : Result<std_path_PathBuf, std_io_Error> = v267 |> Error
                let _v272 = v279 
                #endif
#if FABLE_COMPILER_PYTHON
                let v280 : Result<std_path_PathBuf, std_io_Error> = v267 |> Error
                let _v272 = v280 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v281 : Result<std_path_PathBuf, std_io_Error> = v267 |> Error
                let _v272 = v281 
                #endif
#else
                let v282 : Result<std_path_PathBuf, std_io_Error> = v267 |> Error
                let _v272 = v282 
                #endif
                let v283 : Result<std_path_PathBuf, std_io_Error> = _v272 
                v283
        | _ ->
            let v287 : string = $"file_system.read_link / run / The file or directory is not a reparse point. / path: {v0} / error: {v23} / path': {v0} / name: {v4}"
            let v288 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v289 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
            let v290 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v287 v289 
            let _v288 = v290 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v291 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
            let v292 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v287 v291 
            let _v288 = v292 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v293 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
            let v294 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v287 v293 
            let _v288 = v294 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v295 : std_io_Error = v287 |> unbox<std_io_Error>
            let _v288 = v295 
            #endif
#if FABLE_COMPILER_PYTHON
            let v298 : std_io_Error = v287 |> unbox<std_io_Error>
            let _v288 = v298 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v301 : std_io_Error = v287 |> unbox<std_io_Error>
            let _v288 = v301 
            #endif
#else
            let v304 : std_io_Error = v287 |> unbox<std_io_Error>
            let _v288 = v304 
            #endif
            let v307 : std_io_Error = _v288 
            let v312 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v313 : string = "Err($0)"
            let v314 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v307 v313 
            let _v312 = v314 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v315 : string = "Err($0)"
            let v316 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v307 v315 
            let _v312 = v316 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v317 : string = "Err($0)"
            let v318 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v307 v317 
            let _v312 = v318 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v319 : Result<std_path_PathBuf, std_io_Error> = v307 |> Error
            let _v312 = v319 
            #endif
#if FABLE_COMPILER_PYTHON
            let v320 : Result<std_path_PathBuf, std_io_Error> = v307 |> Error
            let _v312 = v320 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v321 : Result<std_path_PathBuf, std_io_Error> = v307 |> Error
            let _v312 = v321 
            #endif
#else
            let v322 : Result<std_path_PathBuf, std_io_Error> = v307 |> Error
            let _v312 = v322 
            #endif
            let v323 : Result<std_path_PathBuf, std_io_Error> = _v312 
            v323
and method108 (v0 : string, v1 : uint8) : Result<std_path_PathBuf, std_io_Error> =
    let v2 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : System_IO_DirectoryInfo = null |> unbox<System_IO_DirectoryInfo>
    let _v2 = v3 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v6 : System_IO_DirectoryInfo = null |> unbox<System_IO_DirectoryInfo>
    let _v2 = v6 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v9 : System_IO_DirectoryInfo = null |> unbox<System_IO_DirectoryInfo>
    let _v2 = v9 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v12 : System_IO_DirectoryInfo = null |> unbox<System_IO_DirectoryInfo>
    let _v2 = v12 
    #endif
#if FABLE_COMPILER_PYTHON
    let v15 : System_IO_DirectoryInfo = null |> unbox<System_IO_DirectoryInfo>
    let _v2 = v15 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v18 : System_IO_DirectoryInfo = null |> unbox<System_IO_DirectoryInfo>
    let _v2 = v18 
    #endif
#else
    let v21 : System_IO_DirectoryInfo = v0 |> System_IO_DirectoryInfo 
    let _v2 = v21 
    #endif
    let v24 : System_IO_DirectoryInfo = _v2 
    let v29 : System.IO.FileAttributes = method109(v24)
    let v30 : System.IO.FileAttributes = method110()
    let v31 : bool = method111(v30, v29)
    if v31 then
        let v32 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v33 : System_IO_FileInfo = null |> unbox<System_IO_FileInfo>
        let _v32 = v33 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v36 : System_IO_FileInfo = null |> unbox<System_IO_FileInfo>
        let _v32 = v36 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v39 : System_IO_FileInfo = null |> unbox<System_IO_FileInfo>
        let _v32 = v39 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v42 : System_IO_FileInfo = null |> unbox<System_IO_FileInfo>
        let _v32 = v42 
        #endif
#if FABLE_COMPILER_PYTHON
        let v45 : System_IO_FileInfo = null |> unbox<System_IO_FileInfo>
        let _v32 = v45 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v48 : System_IO_FileInfo = null |> unbox<System_IO_FileInfo>
        let _v32 = v48 
        #endif
#else
        let v51 : System_IO_FileInfo = v0 |> System_IO_FileInfo 
        let _v32 = v51 
        #endif
        let v54 : System_IO_FileInfo = _v32 
        let v59 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v60 : string = null |> unbox<string>
        let _v59 = v60 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v63 : string = null |> unbox<string>
        let _v59 = v63 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v66 : string = null |> unbox<string>
        let _v59 = v66 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v69 : string = null |> unbox<string>
        let _v59 = v69 
        #endif
#if FABLE_COMPILER_PYTHON
        let v72 : string = null |> unbox<string>
        let _v59 = v72 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v75 : string = null |> unbox<string>
        let _v59 = v75 
        #endif
#else
        let v78 : (System_IO_FileInfo -> string) = _.LinkTarget
        let v79 : string = v78 v54
        let _v59 = v79 
        #endif
        let v80 : string = _v59 
        let v85 : std_path_PathBuf = v80 |> unbox<std_path_PathBuf>
        let v88 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v89 : string = "Ok($0)"
        let v90 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v85 v89 
        let _v88 = v90 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v91 : string = "Ok($0)"
        let v92 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v85 v91 
        let _v88 = v92 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v93 : string = "Ok($0)"
        let v94 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v85 v93 
        let _v88 = v94 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v95 : Result<std_path_PathBuf, std_io_Error> = v85 |> Ok
        let _v88 = v95 
        #endif
#if FABLE_COMPILER_PYTHON
        let v96 : Result<std_path_PathBuf, std_io_Error> = v85 |> Ok
        let _v88 = v96 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v97 : Result<std_path_PathBuf, std_io_Error> = v85 |> Ok
        let _v88 = v97 
        #endif
#else
        let v98 : Result<std_path_PathBuf, std_io_Error> = v85 |> Ok
        let _v88 = v98 
        #endif
        let v99 : Result<std_path_PathBuf, std_io_Error> = _v88 
        v99
    else
        let v102 : string = $"file_system.read_link / Fsharp / The file or directory is not a reparse point. / path: {v0} / result: {v31} / path': {v0} / n: {v1}"
        let v103 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v104 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
        let v105 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v102 v104 
        let _v103 = v105 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v106 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
        let v107 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v102 v106 
        let _v103 = v107 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v108 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
        let v109 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v102 v108 
        let _v103 = v109 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v110 : std_io_Error = v102 |> unbox<std_io_Error>
        let _v103 = v110 
        #endif
#if FABLE_COMPILER_PYTHON
        let v113 : std_io_Error = v102 |> unbox<std_io_Error>
        let _v103 = v113 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v116 : std_io_Error = v102 |> unbox<std_io_Error>
        let _v103 = v116 
        #endif
#else
        let v119 : std_io_Error = v102 |> unbox<std_io_Error>
        let _v103 = v119 
        #endif
        let v122 : std_io_Error = _v103 
        let v127 : (uint8 -> (string -> Result<std_path_PathBuf, std_io_Error>)) = closure51(v0)
        method114(v0, v127, v1, v122)
and method97 (v0 : string) : Result<std_path_PathBuf, std_io_Error> =
    let v1 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : bool = method9(v0)
    let v7 : Result<std_path_PathBuf, std_io_Error> =
        if v2 then
            let v3 : string = "std::fs::read_link(&*$0)"
            let v4 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v0 v3 
            v4
        else
            let v5 : uint8 = 0uy
            method98(v0, v5)
    let _v1 = v7 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v8 : bool = method9(v0)
    let v13 : Result<std_path_PathBuf, std_io_Error> =
        if v8 then
            let v9 : string = "std::fs::read_link(&*$0)"
            let v10 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v0 v9 
            v10
        else
            let v11 : uint8 = 0uy
            method98(v0, v11)
    let _v1 = v13 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v14 : bool = method9(v0)
    let v19 : Result<std_path_PathBuf, std_io_Error> =
        if v14 then
            let v15 : string = "std::fs::read_link(&*$0)"
            let v16 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v0 v15 
            v16
        else
            let v17 : uint8 = 0uy
            method98(v0, v17)
    let _v1 = v19 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v20 : Result<std_path_PathBuf, std_io_Error> = null |> unbox<Result<std_path_PathBuf, std_io_Error>>
    let _v1 = v20 
    #endif
#if FABLE_COMPILER_PYTHON
    let v23 : Result<std_path_PathBuf, std_io_Error> = Unchecked.defaultof<_>
    let _v1 = v23 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v24 : uint8 = 0uy
    let v25 : Result<std_path_PathBuf, std_io_Error> = method108(v0, v24)
    let _v1 = v25 
    #endif
#else
    let v26 : uint8 = 0uy
    let v27 : Result<std_path_PathBuf, std_io_Error> = method108(v0, v26)
    let _v1 = v27 
    #endif
    let v28 : Result<std_path_PathBuf, std_io_Error> = _v1 
    v28
and closure53 () (v0 : std_path_PathBuf) : US14 =
    US14_0(v0)
and method115 () : (std_path_PathBuf -> US14) =
    closure53()
and method117 (v0 : string) : string =
    v0
and method116 (v0 : string, v1 : string, v2 : string) : string =
    let v3 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v4 : string = $"regex::Regex::new(&$0)"
    let v5 : Result<regex_Regex, regex_Error> = Fable.Core.RustInterop.emitRustExpr v0 v4 
    let v6 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v7 : string = "$0.unwrap()"
    let v8 : regex_Regex = Fable.Core.RustInterop.emitRustExpr v5 v7 
    let _v6 = v8 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v9 : string = "$0.unwrap()"
    let v10 : regex_Regex = Fable.Core.RustInterop.emitRustExpr v5 v9 
    let _v6 = v10 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v11 : string = "$0.unwrap()"
    let v12 : regex_Regex = Fable.Core.RustInterop.emitRustExpr v5 v11 
    let _v6 = v12 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v13 : regex_Regex = match v5 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v6 = v13 
    #endif
#if FABLE_COMPILER_PYTHON
    let v14 : regex_Regex = match v5 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v6 = v14 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v15 : regex_Regex = match v5 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v6 = v15 
    #endif
#else
    let v16 : regex_Regex = match v5 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v6 = v16 
    #endif
    let v17 : regex_Regex = _v6 
    let v20 : string = method117(v2)
    let v21 : string = $"$0.replace_all(&*$1, &*$2)"
    let v22 : std_borrow_Cow<Str> = Fable.Core.RustInterop.emitRustExpr struct (v17, v20, v1) v21 
    let v23 : string = "String::from($0)"
    let v24 : std_string_String = Fable.Core.RustInterop.emitRustExpr v22 v23 
    let v25 : string = "fable_library_rust::String_::fromString($0)"
    let v26 : string = Fable.Core.RustInterop.emitRustExpr v24 v25 
    let _v3 = v26 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v27 : string = null |> unbox<string>
    let _v3 = v27 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v30 : string = null |> unbox<string>
    let _v3 = v30 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v33 : string = null |> unbox<string>
    let _v3 = v33 
    #endif
#if FABLE_COMPILER_PYTHON
    let v36 : string = null |> unbox<string>
    let _v3 = v36 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v39 : string = null |> unbox<string>
    let _v3 = v39 
    #endif
#else
    let v42 : string = System.Text.RegularExpressions.Regex.Replace (v2, v0, v1)
    let _v3 = v42 
    #endif
    let v43 : string = _v3 
    v43
and method96 (v0 : string) : string =
    let v1 : bool = v0 = ""
    if v1 then
        let v2 : string = ""
        v2
    else
        let v3 : Result<std_path_PathBuf, std_io_Error> = method97(v0)
        let v4 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v5 : string = "$0.ok()"
        let v6 : std_path_PathBuf option = Fable.Core.RustInterop.emitRustExpr v3 v5 
        let _v4 = v6 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v7 : string = "$0.ok()"
        let v8 : std_path_PathBuf option = Fable.Core.RustInterop.emitRustExpr v3 v7 
        let _v4 = v8 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v9 : string = "$0.ok()"
        let v10 : std_path_PathBuf option = Fable.Core.RustInterop.emitRustExpr v3 v9 
        let _v4 = v10 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v11 : std_path_PathBuf option = match v3 with Ok x -> Some x | Error _ -> None
        let _v4 = v11 
        #endif
#if FABLE_COMPILER_PYTHON
        let v12 : std_path_PathBuf option = match v3 with Ok x -> Some x | Error _ -> None
        let _v4 = v12 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v13 : std_path_PathBuf option = match v3 with Ok x -> Some x | Error _ -> None
        let _v4 = v13 
        #endif
#else
        let v14 : std_path_PathBuf option = match v3 with Ok x -> Some x | Error _ -> None
        let _v4 = v14 
        #endif
        let v15 : std_path_PathBuf option = _v4 
        let v18 : (std_path_PathBuf -> US14) = method115()
        let v19 : US14 option = v15 |> Option.map v18 
        let v30 : US14 = US14_1
        let v31 : US14 = v19 |> Option.defaultValue v30 
        let v66 : string =
            match v31 with
            | US14_1 -> (* None *)
                v0
            | US14_0(v35) -> (* Some *)
                let v36 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v37 : string = "$0.display()"
                let v38 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v35 v37 
                let _v36 = v38 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v39 : string = "$0.display()"
                let v40 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v35 v39 
                let _v36 = v40 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v41 : string = "$0.display()"
                let v42 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v35 v41 
                let _v36 = v42 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v43 : std_path_Display = v35 |> unbox<std_path_Display>
                let _v36 = v43 
                #endif
#if FABLE_COMPILER_PYTHON
                let v46 : std_path_Display = v35 |> unbox<std_path_Display>
                let _v36 = v46 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v49 : std_path_Display = v35 |> unbox<std_path_Display>
                let _v36 = v49 
                #endif
#else
                let v52 : std_path_Display = v35 |> unbox<std_path_Display>
                let _v36 = v52 
                #endif
                let v55 : std_path_Display = _v36 
                let v60 : string = v55 |> string 
                let v63 : bool = v60 = ""
                if v63 then
                    v0
                else
                    v60
        let v67 : bool = v66 = ""
        if v67 then
            let v68 : string = ""
            v68
        else
            let v69 : string = "^\\\\\\\\\\?\\\\"
            let v70 : string = ""
            let v71 : string = method116(v69, v70, v66)
            let v72 : string = $"{v71.[0] |> string |> _.ToLower()}{v71.[1..]}"
            let v73 : string = "\\"
            let v74 : string = "/"
            let v75 : string = v72.Replace (v73, v74)
            v75
and closure45 () (v0 : string) : string =
    method96(v0)
and closure54 () (v0 : string) : string =
    let v1 : char list = []
    let v2 : char list = '/' :: v1 
    let v5 : (char list -> (char [])) = List.toArray
    let v6 : (char []) = v5 v2
    let v9 : string = v0.TrimStart v6 
    let v33 : string = $"file:///{v9}"
    v33
and method119 (v0 : string, v1 : string, v2 : string) : US15 =
    let v3 : string = method75(v2, v0)
    let v4 : bool = method9(v3)
    if v4 then
        US15_0(v2)
    else
        let v6 : string option = method105(v2)
        let v7 : (string -> US5) = method5()
        let v8 : US5 option = v6 |> Option.map v7 
        let v19 : US5 = US5_1
        let v20 : US5 = v8 |> Option.defaultValue v19 
        match v20 with
        | US5_1 -> (* None *)
            let v26 : string = $"""No parent for {if false then "file" else "dir"} '{v0}' at '{v1}' (until '{v2}')"""
            US15_1(v26)
        | US5_0(v24) -> (* Some *)
            method119(v0, v1, v24)
and method118 (v0 : string, v1 : string) : US15 =
    let v2 : string = method75(v1, v0)
    let v3 : bool = method9(v2)
    if v3 then
        US15_0(v1)
    else
        let v5 : string option = method105(v1)
        let v6 : (string -> US5) = method5()
        let v7 : US5 option = v5 |> Option.map v6 
        let v18 : US5 = US5_1
        let v19 : US5 = v7 |> Option.defaultValue v18 
        match v19 with
        | US5_1 -> (* None *)
            let v25 : string = $"""No parent for {if false then "file" else "dir"} '{v0}' at '{v1}' (until '{v1}')"""
            US15_1(v25)
        | US5_0(v23) -> (* Some *)
            method119(v0, v1, v23)
and method121 (v0 : string) : string =
    let v1 : string = method17()
    let v2 : Mut3 = {l0 = v1} : Mut3
    let v3 : string = "{ "
    let v4 : string = $"{v3}"
    let v7 : unit = ()
    let v8 : (unit -> unit) = closure6(v2, v4)
    let v9 : unit = (fun () -> v8 (); v7) ()
    let v12 : string = "error"
    let v13 : string = $"{v12}"
    let v16 : unit = ()
    let v17 : (unit -> unit) = closure6(v2, v13)
    let v18 : unit = (fun () -> v17 (); v16) ()
    let v21 : string = " = "
    let v22 : string = $"{v21}"
    let v25 : unit = ()
    let v26 : (unit -> unit) = closure6(v2, v22)
    let v27 : unit = (fun () -> v26 (); v25) ()
    let v30 : string = $"{v0}"
    let v33 : unit = ()
    let v34 : (unit -> unit) = closure6(v2, v30)
    let v35 : unit = (fun () -> v34 (); v33) ()
    let v38 : string = " }"
    let v39 : string = $"{v38}"
    let v42 : unit = ()
    let v43 : (unit -> unit) = closure6(v2, v39)
    let v44 : unit = (fun () -> v43 (); v42) ()
    let v47 : string = v2.l0
    v47
and method120 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : string) : string =
    let v9 : string = method121(v8)
    let v10 : int64 = v0.l0
    let v11 : string = "file_system.get_workspace_root"
    let v12 : string = $"{v6} {v7} #{v10} %s{v11} / {v9}"
    method22(v12)
and closure56 (v0 : string) () : unit =
    let v1 : US0 = US0_3
    let v2 : bool = method10(v1)
    if v2 then
        let v3 : unit = ()
        let v4 : (unit -> unit) = closure0()
        let v5 : unit = (fun () -> v4 (); v3) ()
        let struct (v19 : Mut0, v20 : Mut1, v21 : Mut2, v22 : Mut3, v23 : Mut4, v24 : int64 option) = TraceState.trace_state.Value
        let v37 : string = method11(v19, v20, v21, v22, v23, v24)
        let v38 : string = method41()
        let v39 : string = method120(v19, v20, v21, v22, v23, v24, v37, v38, v0)
        method23(v39)
and method122 () : string =
    let v0 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1 : string = "std::env::current_dir()"
    let v2 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v1 
    let v3 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v4 : string = "$0.unwrap()"
    let v5 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v2 v4 
    let _v3 = v5 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v6 : string = "$0.unwrap()"
    let v7 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v2 v6 
    let _v3 = v7 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v8 : string = "$0.unwrap()"
    let v9 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v2 v8 
    let _v3 = v9 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v10 : std_path_PathBuf = match v2 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v3 = v10 
    #endif
#if FABLE_COMPILER_PYTHON
    let v11 : std_path_PathBuf = match v2 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v3 = v11 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v12 : std_path_PathBuf = match v2 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v3 = v12 
    #endif
#else
    let v13 : std_path_PathBuf = match v2 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v3 = v13 
    #endif
    let v14 : std_path_PathBuf = _v3 
    let v17 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v18 : string = "$0.display()"
    let v19 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v14 v18 
    let _v17 = v19 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v20 : string = "$0.display()"
    let v21 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v14 v20 
    let _v17 = v21 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v22 : string = "$0.display()"
    let v23 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v14 v22 
    let _v17 = v23 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v24 : std_path_Display = v14 |> unbox<std_path_Display>
    let _v17 = v24 
    #endif
#if FABLE_COMPILER_PYTHON
    let v27 : std_path_Display = v14 |> unbox<std_path_Display>
    let _v17 = v27 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v30 : std_path_Display = v14 |> unbox<std_path_Display>
    let _v17 = v30 
    #endif
#else
    let v33 : std_path_Display = v14 |> unbox<std_path_Display>
    let _v17 = v33 
    #endif
    let v36 : std_path_Display = _v17 
    let v41 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v42 : string = "format!(\"{}\", $0)"
    let v43 : std_string_String = Fable.Core.RustInterop.emitRustExpr v36 v42 
    let _v41 = v43 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v44 : string = "format!(\"{}\", $0)"
    let v45 : std_string_String = Fable.Core.RustInterop.emitRustExpr v36 v44 
    let _v41 = v45 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v46 : string = "format!(\"{}\", $0)"
    let v47 : std_string_String = Fable.Core.RustInterop.emitRustExpr v36 v46 
    let _v41 = v47 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v48 : std_string_String = null |> unbox<std_string_String>
    let _v41 = v48 
    #endif
#if FABLE_COMPILER_PYTHON
    let v51 : std_string_String = null |> unbox<std_string_String>
    let _v41 = v51 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v54 : std_string_String = null |> unbox<std_string_String>
    let _v41 = v54 
    #endif
#else
    let v57 : std_string_String = null |> unbox<std_string_String>
    let _v41 = v57 
    #endif
    let v60 : std_string_String = _v41 
    let v65 : string = "fable_library_rust::String_::fromString($0)"
    let v66 : string = Fable.Core.RustInterop.emitRustExpr v60 v65 
    let _v0 = v66 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v67 : string = null |> unbox<string>
    let _v0 = v67 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v70 : string = null |> unbox<string>
    let _v0 = v70 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v73 : string = null |> unbox<string>
    let _v0 = v73 
    #endif
#if FABLE_COMPILER_PYTHON
    let v76 : string = null |> unbox<string>
    let _v0 = v76 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v79 : string = null |> unbox<string>
    let _v0 = v79 
    #endif
#else
    let v82 : (unit -> string) = System.IO.Directory.GetCurrentDirectory
    let v83 : string = v82 ()
    let _v0 = v83 
    #endif
    let v84 : string = _v0 
    v84
and closure55 () () : string =
    let v0 : string = __SOURCE_DIRECTORY__
    let v1 : string = "polyglot"
    let v2 : string = ".devcontainer"
    let v3 : string = method75(v1, v2)
    let v4 : US15 = method118(v3, v0)
    let v52 : US5 =
        match v4 with
        | US15_1(v7) -> (* Error *)
            let v8 : unit = ()
            let v9 : (unit -> unit) = closure56(v7)
            let v10 : unit = (fun () -> v9 (); v8) ()
            US5_1
        | US15_0(v5) -> (* Ok *)
            US5_0(v5)
    let v107 : US5 =
        match v52 with
        | US5_1 -> (* None *)
            let v55 : string = method122()
            let v56 : string = method75(v1, v2)
            let v57 : US15 = method118(v56, v55)
            match v57 with
            | US15_1(v60) -> (* Error *)
                let v61 : unit = ()
                let v62 : (unit -> unit) = closure56(v60)
                let v63 : unit = (fun () -> v62 (); v61) ()
                US5_1
            | US15_0(v58) -> (* Ok *)
                US5_0(v58)
        | US5_0(v53) -> (* Some *)
            US5_0(v53)
    let v111 : string =
        match v107 with
        | US5_1 -> (* None *)
            failwith<string> "Option does not have a value."
        | US5_0(v108) -> (* Some *)
            v108
    method75(v111, v1)
and method123 (v0 : string) : unit =
    let v1 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let _v1 = () 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let _v1 = () 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let _v1 = () 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let _v1 = () 
    #endif
#if FABLE_COMPILER_PYTHON
    let _v1 = () 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let _v1 = () 
    #endif
#else
    try
    let v2 : string = method76()
    let v3 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v4 : System.DateTime = System.DateTime.Now
    let _v3 = v4 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v5 : System.DateTime = System.DateTime.Now
    let _v3 = v5 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v6 : System.DateTime = null |> unbox<System.DateTime>
    let _v3 = v6 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v9 : System.DateTime = System.DateTime.Now
    let _v3 = v9 
    #endif
#if FABLE_COMPILER_PYTHON
    let v10 : System.DateTime = System.DateTime.Now
    let _v3 = v10 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v11 : System.DateTime = System.DateTime.Now
    let _v3 = v11 
    #endif
#else
    let v12 : System.DateTime = System.DateTime.Now
    let _v3 = v12 
    #endif
    let v13 : System.DateTime = _v3 
    let v18 : (unit -> System.Guid) = System.Guid.NewGuid
    let v19 : System.Guid = v18 ()
    let v22 : System.Guid = method67(v19, v13)
    let v23 : string = $"{v2}_{v22}.txt"
    let v24 : string = __SOURCE_DIRECTORY__
    let v25 : string = "polyglot"
    let v26 : string = ".devcontainer"
    let v27 : string = method75(v25, v26)
    let v28 : US15 = method118(v27, v24)
    let v76 : US5 =
        match v28 with
        | US15_1(v31) -> (* Error *)
            let v32 : unit = ()
            let v33 : (unit -> unit) = closure56(v31)
            let v34 : unit = (fun () -> v33 (); v32) ()
            US5_1
        | US15_0(v29) -> (* Ok *)
            US5_0(v29)
    let v131 : US5 =
        match v76 with
        | US5_1 -> (* None *)
            let v79 : string = method122()
            let v80 : string = method75(v25, v26)
            let v81 : US15 = method118(v80, v79)
            match v81 with
            | US15_1(v84) -> (* Error *)
                let v85 : unit = ()
                let v86 : (unit -> unit) = closure56(v84)
                let v87 : unit = (fun () -> v86 (); v85) ()
                US5_1
            | US15_0(v82) -> (* Ok *)
                US5_0(v82)
        | US5_0(v77) -> (* Some *)
            US5_0(v77)
    let v135 : string =
        match v131 with
        | US5_1 -> (* None *)
            failwith<string> "Option does not have a value."
        | US5_0(v132) -> (* Some *)
            v132
    let v136 : string = method75(v135, v25)
    let v137 : string = "target/trace"
    let v138 : string = method75(v136, v137)
    let v139 : System_IO_DirectoryInfo = method88(v138)
    let v140 : string = method75(v138, v23)
    let v141 : Async<unit> = method35(v140, v0)
    method93(v141)
    with ex ->
        let v142 : exn = ex
        let v143 : string = $"file_system.trace_file / ex: %A{v142}"
        method123(v143)
        (*
        ()
    *)
    (*
    *)
    let _v1 = () 
    #endif
    _v1 
    ()
and closure58 () (v0 : string) : unit =
    method123(v0)
and closure57 () (v0 : bool) : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure0()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v17 : Mut0, v18 : Mut1, v19 : Mut2, v20 : Mut3, v21 : Mut4, v22 : int64 option) = TraceState.trace_state.Value
    let v37 : (string -> unit) =
        if v0 then
            closure58()
        else
            closure2()
    v18.l0 <- v37
    ()
and method124 (v0 : string, v1 : string) : unit =
    let v2 : bool = method9(v0)
    let v3 : bool = v2 = false
    if v3 then
        let v4 : System.IDisposable = method78(v0)
        ()
    let v5 : string option = method105(v1)
    let v6 : string = ""
    let v7 : string = v5 |> Option.defaultValue v6 
    let v10 : bool = method9(v7)
    let v11 : bool = v10 = false
    if v11 then
        let v12 : System.IDisposable = method78(v7)
        ()
    let v13 : bool = method9(v1)
    let v24 : bool =
        if v13 then
            let v14 : Result<std_path_PathBuf, std_io_Error> = method97(v1)
            let v15 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v16 : string = "$0.is_err()"
            let v17 : bool = Fable.Core.RustInterop.emitRustExpr v14 v16 
            let _v15 = v17 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v18 : string = "$0.is_err()"
            let v19 : bool = Fable.Core.RustInterop.emitRustExpr v14 v18 
            let _v15 = v19 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v20 : string = "$0.is_err()"
            let v21 : bool = Fable.Core.RustInterop.emitRustExpr v14 v20 
            let _v15 = v21 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let _v15 = true 
            #endif
#if FABLE_COMPILER_PYTHON
            let _v15 = true 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let _v15 = true 
            #endif
#else
            let _v15 = true 
            #endif
            let v22 : bool = _v15 
            v22
        else
            false
    if v24 then
        let v25 : bool = true
        method8(v25, v1)
    let v26 : bool = method9(v1)
    let v27 : bool = v26 = false
    if v27 then
        let v28 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v29 : string = "true; #[cfg(windows)] std::os::windows::fs::symlink_dir(&*$0, &*$1).unwrap()"
        let v30 : bool = Fable.Core.RustInterop.emitRustExpr struct (v0, v1) v29 
        let v31 : string = "true; #[cfg(unix)] std::os::unix::fs::symlink(&*$0, &*$1).unwrap()"
        let v32 : bool = Fable.Core.RustInterop.emitRustExpr struct (v0, v1) v31 
        let _v28 = () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let _v28 = () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let _v28 = () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let _v28 = () 
        #endif
#if FABLE_COMPILER_PYTHON
        let _v28 = () 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let _v28 = () 
        #endif
#else
        let v33 : System.IO.FileSystemInfo = System.IO.Directory.CreateSymbolicLink (v1, v0)
        let _v28 = () 
        #endif
        _v28 
        ()
and closure60 (v0 : string) (v1 : string) : unit =
    method124(v0, v1)
and closure59 () (v0 : string) : (string -> unit) =
    closure60(v0)
and closure62 (v0 : string) (v1 : string) : string =
    method75(v0, v1)
and closure61 () (v0 : string) : (string -> string) =
    closure62(v0)
let v0 : unit = ()
let v1 : (unit -> unit) = closure0()
let v2 : unit = (fun () -> v1 (); v0) ()
let v16 : (string -> Async<int64>) = closure3()
let delete_directory_async x = v16 x
let v17 : (US6 -> (string -> Async<int64>)) = closure10()
let wait_for_file_access x = v17 x
let v18 : (string -> Async<int64>) = closure13()
let wait_for_file_access_read x = v18 x
let v19 : (string -> Async<string>) = closure14()
let read_all_text_async x = v19 x
let v20 : (string -> (string -> bool)) = closure15()
let file_exists_content x = v20 x
let v21 : (string -> (string -> Async<unit>)) = closure17()
let write_all_text_async x = v21 x
let v22 : (string -> (string -> Async<unit>)) = closure19()
let write_all_text_exists x = v22 x
let v23 : (string -> Async<int64>) = closure21()
let delete_file_async x = v23 x
let v24 : (string -> (string -> Async<int64>)) = closure23()
let move_file_async x = v24 x
let v25 : (string -> Async<string option>) = closure26()
let read_all_text_retry_async x = v25 x
let v26 : (unit -> string) = closure32()
let create_temp_path () = v26 ()
let v27 : (unit -> struct (string * System.IDisposable)) = closure34()
let create_temp_dir () = v27 ()
let v28 : (string -> struct (string * System.IDisposable)) = closure43()
let create_temp_dir' x = v28 x
let v29 : (unit -> string) = closure44()
let get_source_directory () = v29 ()
let v30 : (string -> string) = closure45()
let normalize_path x = v30 x
let v31 : (string -> string) = closure54()
let new_file_uri x = v31 x
let v32 : (unit -> string) = closure55()
let get_workspace_root () = v32 ()
let v33 : (bool -> unit) = closure57()
let init_trace_file x = v33 x
let v34 : (string -> (string -> unit)) = closure59()
let link_directory x = v34 x
let v35 : (string -> (string -> string)) = closure61()
let (</>) x = v35 x
()
