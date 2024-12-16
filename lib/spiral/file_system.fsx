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
and method10 (v0 : string) : bool =
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
and method9 (v0 : bool, v1 : string) : unit =
    let v2 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : bool = method10(v1)
    if v3 then
        if v0 then
            let v4 : string = "std::fs::remove_dir_all(&*$0).unwrap()"
            Fable.Core.RustInterop.emitRustExpr v1 v4 
            ()
        else
            let v5 : string = "std::fs::remove_dir(&*$0).unwrap()"
            Fable.Core.RustInterop.emitRustExpr v1 v5 
            ()
    #endif
#if FABLE_COMPILER_RUST && WASM
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    #endif
#if FABLE_COMPILER_PYTHON
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    #endif
#else
    System.IO.Directory.Delete (v1, v0)
    #endif
    // run_target_args' is_unit
    ()
and method11 (v0 : US0) : bool =
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
and method13 () : (int64 -> US2) =
    closure5()
and method14 () : string =
    let v0 : string = "hh:mm:ss"
    v0
and method15 () : string =
    let v0 : string = "HH:mm:ss"
    v0
and method12 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option) : string =
    let v6 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v7 : (int64 -> US2) = method13()
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
    let v118 : string = method14()
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
    let v139 : (int64 -> US2) = method13()
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
    let v250 : string = method14()
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
    let v273 : (int64 -> US2) = method13()
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
    let v308 : (int64 -> US2) = method13()
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
    let v419 : string = method15()
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
    let v440 : (int64 -> US2) = method13()
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
    let v551 : string = method15()
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
    let v572 : (int64 -> US2) = method13()
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
    let v683 : string = method15()
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
    let v704 : (int64 -> US2) = method13()
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
    let v815 : string = method15()
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
and method18 () : string =
    let v0 : string = ""
    v0
and closure6 (v0 : Mut3, v1 : string) () : unit =
    let v2 : string = v0.l0
    let v3 : string = v2 + v1 
    v0.l0 <- v3
    ()
and method17 (v0 : char) : string =
    let v1 : string = method18()
    let v2 : Mut3 = {l0 = v1} : Mut3
    let v3 : string = $"{v0}"
    let v6 : unit = ()
    let v7 : (unit -> unit) = closure6(v2, v3)
    let v8 : unit = (fun () -> v7 (); v6) ()
    let v11 : string = v2.l0
    v11
and method19 () : string =
    let v0 : string = "\u001b[0m"
    v0
and method16 () : string =
    
    
    
    
    
    let v0 : string = "Debug"
    let v1 : (unit -> string) = v0.ToLower
    let v2 : string = v1 ()
    let v5 : char = v2.[int 0]
    let v6 : string = method17(v5)
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
    let v105 : string = method19()
    let v106 : string = v104 + v6 
    let v107 : string = v106 + v105 
    let _v7 = v107 
    #endif
#if FABLE_COMPILER_PYTHON
    let v108 : string = "\u001b[94m"
    let v109 : string = method19()
    let v110 : string = v108 + v6 
    let v111 : string = v110 + v109 
    let _v7 = v111 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v112 : string = "\u001b[94m"
    let v113 : string = method19()
    let v114 : string = v112 + v6 
    let v115 : string = v114 + v113 
    let _v7 = v115 
    #endif
#else
    let v116 : string = "\u001b[94m"
    let v117 : string = method19()
    let v118 : string = v116 + v6 
    let v119 : string = v118 + v117 
    let _v7 = v119 
    #endif
    let v120 : string = _v7 
    v120
and method20 (v0 : string) : string =
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
and method22 (v0 : string, v1 : string) : string =
    let v2 : string = method18()
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
and method23 (v0 : string) : string =
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
and method21 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : string, v9 : string) : string =
    let v10 : string = method22(v8, v9)
    let v11 : int64 = v0.l0
    let v12 : string = "file_system.delete_directory_async"
    let v13 : string = $"{v6} {v7} #{v11} %s{v12} / {v10}"
    method23(v13)
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
and method24 (v0 : string) : unit =
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
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v43 : string = @"println!(""{}"", $0)"
    Fable.Core.RustInterop.emitRustExpr v0 v43 
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
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    v40 v0
    #endif
#if FABLE_COMPILER_PYTHON
    v40 v0
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    v40 v0
    #endif
#else
    v40 v0
    #endif
    // run_target_args' is_unit
    let v121 : (string -> unit) = v18.l0
    v121 v0
and closure4 (v0 : string, v1 : exn) () : unit =
    let v2 : US0 = US0_1
    let v3 : bool = method11(v2)
    if v3 then
        let v4 : unit = ()
        let v5 : (unit -> unit) = closure0()
        let v6 : unit = (fun () -> v5 (); v4) ()
        let struct (v20 : Mut0, v21 : Mut1, v22 : Mut2, v23 : Mut3, v24 : Mut4, v25 : int64 option) = TraceState.trace_state.Value
        let v38 : string = method12(v20, v21, v22, v23, v24, v25)
        let v39 : string = method16()
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
        let v65 : string = method20(v0)
        let v66 : string = method21(v20, v21, v22, v23, v24, v25, v38, v39, v60, v65)
        method24(v66)
and method8 (v0 : string, v1 : int64) : Async<int64> =
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
                method9(v15, v0)
                return v1 
                (* indent
                ()
            indent *)
            with ex ->
                let v17 : exn = ex
                let v18 : int64 = v1 % 100L
                let v19 : bool = v18 = 0L
                if v19 then
                    let v20 : unit = ()
                    let v21 : (unit -> unit) = closure4(v0, v17)
                    let v22 : unit = (fun () -> v21 (); v20) ()
                    ()
                let v88 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v89 : (int32 -> Async<unit>) = Async.Sleep
                let v90 : Async<unit> = v89 10
                let _v88 = v90 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v91 : (int32 -> Async<unit>) = Async.Sleep
                let v92 : Async<unit> = v91 10
                let _v88 = v92 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v93 : (int32 -> Async<unit>) = Async.Sleep
                let v94 : Async<unit> = v93 10
                let _v88 = v94 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v95 : (int32 -> Async<unit>) = Async.Sleep
                let v96 : Async<unit> = v95 10
                let _v88 = v96 
                #endif
#if FABLE_COMPILER_PYTHON
                let v97 : (int32 -> Async<unit>) = Async.Sleep
                let v98 : Async<unit> = v97 10
                let _v88 = v98 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v99 : (int32 -> Async<unit>) = Async.Sleep
                let v100 : Async<unit> = v99 10
                let _v88 = v100 
                #endif
#else
                let v101 : (int32 -> Async<unit>) = Async.Sleep
                let v102 : Async<unit> = v101 10
                let _v88 = v102 
                #endif
                let v103 : Async<unit> = _v88 
                do! v103 
                let v106 : int64 = v1 + 1L
                let v107 : Async<int64> = method7(v0, v106)
                return! v107 
                (* indent
                ()
            indent *)
            (* try_unit
            let v199 : int64 = try_unit *)
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v1511 : Async<int64> = _v12 
    let _v2 = v1511 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1512 : unit = ()
    let _v1512 =
        async {
            try
                let v1515 : bool = true
                method9(v1515, v0)
                return v1 
                (* indent
                ()
            indent *)
            with ex ->
                let v1517 : exn = ex
                let v1518 : int64 = v1 % 100L
                let v1519 : bool = v1518 = 0L
                if v1519 then
                    let v1520 : unit = ()
                    let v1521 : (unit -> unit) = closure4(v0, v1517)
                    let v1522 : unit = (fun () -> v1521 (); v1520) ()
                    ()
                let v1588 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v1589 : (int32 -> Async<unit>) = Async.Sleep
                let v1590 : Async<unit> = v1589 10
                let _v1588 = v1590 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v1591 : (int32 -> Async<unit>) = Async.Sleep
                let v1592 : Async<unit> = v1591 10
                let _v1588 = v1592 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v1593 : (int32 -> Async<unit>) = Async.Sleep
                let v1594 : Async<unit> = v1593 10
                let _v1588 = v1594 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v1595 : (int32 -> Async<unit>) = Async.Sleep
                let v1596 : Async<unit> = v1595 10
                let _v1588 = v1596 
                #endif
#if FABLE_COMPILER_PYTHON
                let v1597 : (int32 -> Async<unit>) = Async.Sleep
                let v1598 : Async<unit> = v1597 10
                let _v1588 = v1598 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v1599 : (int32 -> Async<unit>) = Async.Sleep
                let v1600 : Async<unit> = v1599 10
                let _v1588 = v1600 
                #endif
#else
                let v1601 : (int32 -> Async<unit>) = Async.Sleep
                let v1602 : Async<unit> = v1601 10
                let _v1588 = v1602 
                #endif
                let v1603 : Async<unit> = _v1588 
                do! v1603 
                let v1606 : int64 = v1 + 1L
                let v1607 : Async<int64> = method7(v0, v1606)
                return! v1607 
                (* indent
                ()
            indent *)
            (* try_unit
            let v1699 : int64 = try_unit *)
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v3011 : Async<int64> = _v1512 
    let _v2 = v3011 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v3012 : unit = ()
    let _v3012 =
        async {
            try
                let v3015 : bool = true
                method9(v3015, v0)
                return v1 
                (* indent
                ()
            indent *)
            with ex ->
                let v3017 : exn = ex
                let v3018 : int64 = v1 % 100L
                let v3019 : bool = v3018 = 0L
                if v3019 then
                    let v3020 : unit = ()
                    let v3021 : (unit -> unit) = closure4(v0, v3017)
                    let v3022 : unit = (fun () -> v3021 (); v3020) ()
                    ()
                let v3088 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v3089 : (int32 -> Async<unit>) = Async.Sleep
                let v3090 : Async<unit> = v3089 10
                let _v3088 = v3090 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v3091 : (int32 -> Async<unit>) = Async.Sleep
                let v3092 : Async<unit> = v3091 10
                let _v3088 = v3092 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v3093 : (int32 -> Async<unit>) = Async.Sleep
                let v3094 : Async<unit> = v3093 10
                let _v3088 = v3094 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v3095 : (int32 -> Async<unit>) = Async.Sleep
                let v3096 : Async<unit> = v3095 10
                let _v3088 = v3096 
                #endif
#if FABLE_COMPILER_PYTHON
                let v3097 : (int32 -> Async<unit>) = Async.Sleep
                let v3098 : Async<unit> = v3097 10
                let _v3088 = v3098 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v3099 : (int32 -> Async<unit>) = Async.Sleep
                let v3100 : Async<unit> = v3099 10
                let _v3088 = v3100 
                #endif
#else
                let v3101 : (int32 -> Async<unit>) = Async.Sleep
                let v3102 : Async<unit> = v3101 10
                let _v3088 = v3102 
                #endif
                let v3103 : Async<unit> = _v3088 
                do! v3103 
                let v3106 : int64 = v1 + 1L
                let v3107 : Async<int64> = method7(v0, v3106)
                return! v3107 
                (* indent
                ()
            indent *)
            (* try_unit
            let v3199 : int64 = try_unit *)
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v4511 : Async<int64> = _v3012 
    let _v2 = v4511 
    #endif
#else
    let v4512 : unit = ()
    let _v4512 =
        async {
            try
                let v4515 : bool = true
                method9(v4515, v0)
                return v1 
                (* indent
                ()
            indent *)
            with ex ->
                let v4517 : exn = ex
                let v4518 : int64 = v1 % 100L
                let v4519 : bool = v4518 = 0L
                if v4519 then
                    let v4520 : unit = ()
                    let v4521 : (unit -> unit) = closure4(v0, v4517)
                    let v4522 : unit = (fun () -> v4521 (); v4520) ()
                    ()
                let v4588 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v4589 : (int32 -> Async<unit>) = Async.Sleep
                let v4590 : Async<unit> = v4589 10
                let _v4588 = v4590 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v4591 : (int32 -> Async<unit>) = Async.Sleep
                let v4592 : Async<unit> = v4591 10
                let _v4588 = v4592 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v4593 : (int32 -> Async<unit>) = Async.Sleep
                let v4594 : Async<unit> = v4593 10
                let _v4588 = v4594 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v4595 : (int32 -> Async<unit>) = Async.Sleep
                let v4596 : Async<unit> = v4595 10
                let _v4588 = v4596 
                #endif
#if FABLE_COMPILER_PYTHON
                let v4597 : (int32 -> Async<unit>) = Async.Sleep
                let v4598 : Async<unit> = v4597 10
                let _v4588 = v4598 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v4599 : (int32 -> Async<unit>) = Async.Sleep
                let v4600 : Async<unit> = v4599 10
                let _v4588 = v4600 
                #endif
#else
                let v4601 : (int32 -> Async<unit>) = Async.Sleep
                let v4602 : Async<unit> = v4601 10
                let _v4588 = v4602 
                #endif
                let v4603 : Async<unit> = _v4588 
                do! v4603 
                let v4606 : int64 = v1 + 1L
                let v4607 : Async<int64> = method7(v0, v4606)
                return! v4607 
                (* indent
                ()
            indent *)
            (* try_unit
            let v4699 : int64 = try_unit *)
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v6011 : Async<int64> = _v4512 
    let _v2 = v6011 
    #endif
    let v6012 : Async<int64> = _v2 
    v6012
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
    let v21 : Async<int64> = method8(v0, v1)
    let _v2 = v21 
    #endif
    let v22 : Async<int64> = _v2 
    v22
and method6 (v0 : string) : Async<int64> =
    let v1 : int64 = 0L
    method7(v0, v1)
and closure3 () (v0 : string) : Async<int64> =
    method6(v0)
and method29 (v0 : string, v1 : int64, v2 : string) : string =
    let v3 : string = method18()
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
and method28 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : string, v9 : int64, v10 : string) : string =
    let v11 : string = method29(v8, v9, v10)
    let v12 : int64 = v0.l0
    let v13 : string = "file_system.wait_for_file_access"
    let v14 : string = $"{v6} {v7} #{v12} %s{v13} / {v11}"
    method23(v14)
and closure12 (v0 : string, v1 : int64, v2 : exn) () : unit =
    let v3 : US0 = US0_1
    let v4 : bool = method11(v3)
    if v4 then
        let v5 : unit = ()
        let v6 : (unit -> unit) = closure0()
        let v7 : unit = (fun () -> v6 (); v5) ()
        let struct (v21 : Mut0, v22 : Mut1, v23 : Mut2, v24 : Mut3, v25 : Mut4, v26 : int64 option) = TraceState.trace_state.Value
        let v39 : string = method12(v21, v22, v23, v24, v25, v26)
        let v40 : string = method16()
        let v41 : string = method20(v0)
        let v42 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v43 : string = $"%A{v2}"
        let _v42 = v43 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v46 : string = $"%A{v2}"
        let _v42 = v46 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v49 : string = $"%A{v2}"
        let _v42 = v49 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v52 : string = $"%A{v2}"
        let _v42 = v52 
        #endif
#if FABLE_COMPILER_PYTHON
        let v55 : string = $"%A{v2}"
        let _v42 = v55 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v58 : string = $"%A{v2}"
        let _v42 = v58 
        #endif
#else
        let v61 : string = $"{v2.GetType ()}: {v2.Message}"
        let _v42 = v61 
        #endif
        let v62 : string = _v42 
        let v67 : string = method28(v21, v22, v23, v24, v25, v26, v39, v40, v41, v1, v62)
        method24(v67)
and method27 (v0 : US6, v1 : string, v2 : int64, v3 : US8, v4 : US7) : Async<int64> =
    let v5 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v6 : Async<int64> = null |> unbox<Async<int64>>
    let _v5 = v6 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v9 : Async<int64> = null |> unbox<Async<int64>>
    let _v5 = v9 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v12 : Async<int64> = null |> unbox<Async<int64>>
    let _v5 = v12 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v15 : unit = ()
    let _v15 =
        async {
            try
                let v18 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v19 : System.IO.FileStream = null |> unbox<System.IO.FileStream>
                let _v18 = v19 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v22 : System.IO.FileStream = null |> unbox<System.IO.FileStream>
                let _v18 = v22 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v25 : System.IO.FileStream = null |> unbox<System.IO.FileStream>
                let _v18 = v25 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v28 : System.IO.FileStream = null |> unbox<System.IO.FileStream>
                let _v18 = v28 
                #endif
#if FABLE_COMPILER_PYTHON
                let v31 : System.IO.FileStream = null |> unbox<System.IO.FileStream>
                let _v18 = v31 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v34 : System.IO.FileStream = null |> unbox<System.IO.FileStream>
                let _v18 = v34 
                #endif
#else
                let v37 : System.IO.FileMode = System.IO.FileMode.Open
                let v43 : System.IO.FileAccess =
                    match v4 with
                    | US7_0 -> (* AccessRead *)
                        let v38 : System.IO.FileAccess = System.IO.FileAccess.Read
                        v38
                    | US7_2 -> (* AccessReadWrite *)
                        let v40 : System.IO.FileAccess = System.IO.FileAccess.ReadWrite
                        v40
                    | US7_1 -> (* AccessWrite *)
                        let v39 : System.IO.FileAccess = System.IO.FileAccess.ReadWrite
                        v39
                let v53 : System.IO.FileShare =
                    match v3 with
                    | US8_4 -> (* ShareDelete *)
                        let v48 : System.IO.FileShare = System.IO.FileShare.Delete
                        v48
                    | US8_0 -> (* ShareNone *)
                        let v44 : System.IO.FileShare = System.IO.FileShare.None
                        v44
                    | US8_1 -> (* ShareRead *)
                        let v45 : System.IO.FileShare = System.IO.FileShare.Read
                        v45
                    | US8_3 -> (* ShareReadWrite *)
                        let v47 : System.IO.FileShare = System.IO.FileShare.ReadWrite
                        v47
                    | US8_2 -> (* ShareWrite *)
                        let v46 : System.IO.FileShare = System.IO.FileShare.Write
                        v46
                let v54 : System.IO.FileStream = new System.IO.FileStream (v1, v37, v43, v53)
                let _v18 = v54 
                #endif
                let v55 : System.IO.FileStream = _v18 
                use v55 = v55 
                let v60 : System.IO.FileStream = v55 
                return v2 
                (* indent
                ()
            indent *)
            with ex ->
                let v104 : exn = ex
                let v105 : bool = v2 > 0L
                let v108 : bool =
                    if v105 then
                        let v106 : int64 = v2 % 100L
                        let v107 : bool = v106 = 0L
                        v107
                    else
                        false
                if v108 then
                    let v109 : unit = ()
                    let v110 : (unit -> unit) = closure12(v1, v2, v104)
                    let v111 : unit = (fun () -> v110 (); v109) ()
                    ()
                let v177 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v178 : (int32 -> Async<unit>) = Async.Sleep
                let v179 : Async<unit> = v178 10
                let _v177 = v179 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v180 : (int32 -> Async<unit>) = Async.Sleep
                let v181 : Async<unit> = v180 10
                let _v177 = v181 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v182 : (int32 -> Async<unit>) = Async.Sleep
                let v183 : Async<unit> = v182 10
                let _v177 = v183 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v184 : (int32 -> Async<unit>) = Async.Sleep
                let v185 : Async<unit> = v184 10
                let _v177 = v185 
                #endif
#if FABLE_COMPILER_PYTHON
                let v186 : (int32 -> Async<unit>) = Async.Sleep
                let v187 : Async<unit> = v186 10
                let _v177 = v187 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v188 : (int32 -> Async<unit>) = Async.Sleep
                let v189 : Async<unit> = v188 10
                let _v177 = v189 
                #endif
#else
                let v190 : (int32 -> Async<unit>) = Async.Sleep
                let v191 : Async<unit> = v190 10
                let _v177 = v191 
                #endif
                let v192 : Async<unit> = _v177 
                do! v192 
                let v195 : int64 = v2 + 1L
                let v196 : Async<int64> = method26(v0, v1, v195)
                return! v196 
                (* indent
                ()
            indent *)
            (* try_unit
            let v290 : int64 = try_unit *)
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v2218 : Async<int64> = _v15 
    let _v5 = v2218 
    #endif
#if FABLE_COMPILER_PYTHON
    let v2219 : unit = ()
    let _v2219 =
        async {
            try
                let v2222 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v2223 : System.IO.FileStream = null |> unbox<System.IO.FileStream>
                let _v2222 = v2223 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v2226 : System.IO.FileStream = null |> unbox<System.IO.FileStream>
                let _v2222 = v2226 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v2229 : System.IO.FileStream = null |> unbox<System.IO.FileStream>
                let _v2222 = v2229 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v2232 : System.IO.FileStream = null |> unbox<System.IO.FileStream>
                let _v2222 = v2232 
                #endif
#if FABLE_COMPILER_PYTHON
                let v2235 : System.IO.FileStream = null |> unbox<System.IO.FileStream>
                let _v2222 = v2235 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v2238 : System.IO.FileStream = null |> unbox<System.IO.FileStream>
                let _v2222 = v2238 
                #endif
#else
                let v2241 : System.IO.FileMode = System.IO.FileMode.Open
                let v2247 : System.IO.FileAccess =
                    match v4 with
                    | US7_0 -> (* AccessRead *)
                        let v2242 : System.IO.FileAccess = System.IO.FileAccess.Read
                        v2242
                    | US7_2 -> (* AccessReadWrite *)
                        let v2244 : System.IO.FileAccess = System.IO.FileAccess.ReadWrite
                        v2244
                    | US7_1 -> (* AccessWrite *)
                        let v2243 : System.IO.FileAccess = System.IO.FileAccess.ReadWrite
                        v2243
                let v2257 : System.IO.FileShare =
                    match v3 with
                    | US8_4 -> (* ShareDelete *)
                        let v2252 : System.IO.FileShare = System.IO.FileShare.Delete
                        v2252
                    | US8_0 -> (* ShareNone *)
                        let v2248 : System.IO.FileShare = System.IO.FileShare.None
                        v2248
                    | US8_1 -> (* ShareRead *)
                        let v2249 : System.IO.FileShare = System.IO.FileShare.Read
                        v2249
                    | US8_3 -> (* ShareReadWrite *)
                        let v2251 : System.IO.FileShare = System.IO.FileShare.ReadWrite
                        v2251
                    | US8_2 -> (* ShareWrite *)
                        let v2250 : System.IO.FileShare = System.IO.FileShare.Write
                        v2250
                let v2258 : System.IO.FileStream = new System.IO.FileStream (v1, v2241, v2247, v2257)
                let _v2222 = v2258 
                #endif
                let v2259 : System.IO.FileStream = _v2222 
                use v2259 = v2259 
                let v2264 : System.IO.FileStream = v2259 
                return v2 
                (* indent
                ()
            indent *)
            with ex ->
                let v2308 : exn = ex
                let v2309 : bool = v2 > 0L
                let v2312 : bool =
                    if v2309 then
                        let v2310 : int64 = v2 % 100L
                        let v2311 : bool = v2310 = 0L
                        v2311
                    else
                        false
                if v2312 then
                    let v2313 : unit = ()
                    let v2314 : (unit -> unit) = closure12(v1, v2, v2308)
                    let v2315 : unit = (fun () -> v2314 (); v2313) ()
                    ()
                let v2381 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v2382 : (int32 -> Async<unit>) = Async.Sleep
                let v2383 : Async<unit> = v2382 10
                let _v2381 = v2383 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v2384 : (int32 -> Async<unit>) = Async.Sleep
                let v2385 : Async<unit> = v2384 10
                let _v2381 = v2385 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v2386 : (int32 -> Async<unit>) = Async.Sleep
                let v2387 : Async<unit> = v2386 10
                let _v2381 = v2387 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v2388 : (int32 -> Async<unit>) = Async.Sleep
                let v2389 : Async<unit> = v2388 10
                let _v2381 = v2389 
                #endif
#if FABLE_COMPILER_PYTHON
                let v2390 : (int32 -> Async<unit>) = Async.Sleep
                let v2391 : Async<unit> = v2390 10
                let _v2381 = v2391 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v2392 : (int32 -> Async<unit>) = Async.Sleep
                let v2393 : Async<unit> = v2392 10
                let _v2381 = v2393 
                #endif
#else
                let v2394 : (int32 -> Async<unit>) = Async.Sleep
                let v2395 : Async<unit> = v2394 10
                let _v2381 = v2395 
                #endif
                let v2396 : Async<unit> = _v2381 
                do! v2396 
                let v2399 : int64 = v2 + 1L
                let v2400 : Async<int64> = method26(v0, v1, v2399)
                return! v2400 
                (* indent
                ()
            indent *)
            (* try_unit
            let v2494 : int64 = try_unit *)
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v4422 : Async<int64> = _v2219 
    let _v5 = v4422 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v4423 : unit = ()
    let _v4423 =
        async {
            try
                let v4426 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v4427 : System.IO.FileStream = null |> unbox<System.IO.FileStream>
                let _v4426 = v4427 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v4430 : System.IO.FileStream = null |> unbox<System.IO.FileStream>
                let _v4426 = v4430 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v4433 : System.IO.FileStream = null |> unbox<System.IO.FileStream>
                let _v4426 = v4433 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v4436 : System.IO.FileStream = null |> unbox<System.IO.FileStream>
                let _v4426 = v4436 
                #endif
#if FABLE_COMPILER_PYTHON
                let v4439 : System.IO.FileStream = null |> unbox<System.IO.FileStream>
                let _v4426 = v4439 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v4442 : System.IO.FileStream = null |> unbox<System.IO.FileStream>
                let _v4426 = v4442 
                #endif
#else
                let v4445 : System.IO.FileMode = System.IO.FileMode.Open
                let v4451 : System.IO.FileAccess =
                    match v4 with
                    | US7_0 -> (* AccessRead *)
                        let v4446 : System.IO.FileAccess = System.IO.FileAccess.Read
                        v4446
                    | US7_2 -> (* AccessReadWrite *)
                        let v4448 : System.IO.FileAccess = System.IO.FileAccess.ReadWrite
                        v4448
                    | US7_1 -> (* AccessWrite *)
                        let v4447 : System.IO.FileAccess = System.IO.FileAccess.ReadWrite
                        v4447
                let v4461 : System.IO.FileShare =
                    match v3 with
                    | US8_4 -> (* ShareDelete *)
                        let v4456 : System.IO.FileShare = System.IO.FileShare.Delete
                        v4456
                    | US8_0 -> (* ShareNone *)
                        let v4452 : System.IO.FileShare = System.IO.FileShare.None
                        v4452
                    | US8_1 -> (* ShareRead *)
                        let v4453 : System.IO.FileShare = System.IO.FileShare.Read
                        v4453
                    | US8_3 -> (* ShareReadWrite *)
                        let v4455 : System.IO.FileShare = System.IO.FileShare.ReadWrite
                        v4455
                    | US8_2 -> (* ShareWrite *)
                        let v4454 : System.IO.FileShare = System.IO.FileShare.Write
                        v4454
                let v4462 : System.IO.FileStream = new System.IO.FileStream (v1, v4445, v4451, v4461)
                let _v4426 = v4462 
                #endif
                let v4463 : System.IO.FileStream = _v4426 
                use v4463 = v4463 
                let v4468 : System.IO.FileStream = v4463 
                return v2 
                (* indent
                ()
            indent *)
            with ex ->
                let v4512 : exn = ex
                let v4513 : bool = v2 > 0L
                let v4516 : bool =
                    if v4513 then
                        let v4514 : int64 = v2 % 100L
                        let v4515 : bool = v4514 = 0L
                        v4515
                    else
                        false
                if v4516 then
                    let v4517 : unit = ()
                    let v4518 : (unit -> unit) = closure12(v1, v2, v4512)
                    let v4519 : unit = (fun () -> v4518 (); v4517) ()
                    ()
                let v4585 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v4586 : (int32 -> Async<unit>) = Async.Sleep
                let v4587 : Async<unit> = v4586 10
                let _v4585 = v4587 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v4588 : (int32 -> Async<unit>) = Async.Sleep
                let v4589 : Async<unit> = v4588 10
                let _v4585 = v4589 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v4590 : (int32 -> Async<unit>) = Async.Sleep
                let v4591 : Async<unit> = v4590 10
                let _v4585 = v4591 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v4592 : (int32 -> Async<unit>) = Async.Sleep
                let v4593 : Async<unit> = v4592 10
                let _v4585 = v4593 
                #endif
#if FABLE_COMPILER_PYTHON
                let v4594 : (int32 -> Async<unit>) = Async.Sleep
                let v4595 : Async<unit> = v4594 10
                let _v4585 = v4595 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v4596 : (int32 -> Async<unit>) = Async.Sleep
                let v4597 : Async<unit> = v4596 10
                let _v4585 = v4597 
                #endif
#else
                let v4598 : (int32 -> Async<unit>) = Async.Sleep
                let v4599 : Async<unit> = v4598 10
                let _v4585 = v4599 
                #endif
                let v4600 : Async<unit> = _v4585 
                do! v4600 
                let v4603 : int64 = v2 + 1L
                let v4604 : Async<int64> = method26(v0, v1, v4603)
                return! v4604 
                (* indent
                ()
            indent *)
            (* try_unit
            let v4698 : int64 = try_unit *)
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v6626 : Async<int64> = _v4423 
    let _v5 = v6626 
    #endif
#else
    let v6627 : unit = ()
    let _v6627 =
        async {
            try
                let v6630 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v6631 : System.IO.FileStream = null |> unbox<System.IO.FileStream>
                let _v6630 = v6631 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v6634 : System.IO.FileStream = null |> unbox<System.IO.FileStream>
                let _v6630 = v6634 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v6637 : System.IO.FileStream = null |> unbox<System.IO.FileStream>
                let _v6630 = v6637 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v6640 : System.IO.FileStream = null |> unbox<System.IO.FileStream>
                let _v6630 = v6640 
                #endif
#if FABLE_COMPILER_PYTHON
                let v6643 : System.IO.FileStream = null |> unbox<System.IO.FileStream>
                let _v6630 = v6643 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v6646 : System.IO.FileStream = null |> unbox<System.IO.FileStream>
                let _v6630 = v6646 
                #endif
#else
                let v6649 : System.IO.FileMode = System.IO.FileMode.Open
                let v6655 : System.IO.FileAccess =
                    match v4 with
                    | US7_0 -> (* AccessRead *)
                        let v6650 : System.IO.FileAccess = System.IO.FileAccess.Read
                        v6650
                    | US7_2 -> (* AccessReadWrite *)
                        let v6652 : System.IO.FileAccess = System.IO.FileAccess.ReadWrite
                        v6652
                    | US7_1 -> (* AccessWrite *)
                        let v6651 : System.IO.FileAccess = System.IO.FileAccess.ReadWrite
                        v6651
                let v6665 : System.IO.FileShare =
                    match v3 with
                    | US8_4 -> (* ShareDelete *)
                        let v6660 : System.IO.FileShare = System.IO.FileShare.Delete
                        v6660
                    | US8_0 -> (* ShareNone *)
                        let v6656 : System.IO.FileShare = System.IO.FileShare.None
                        v6656
                    | US8_1 -> (* ShareRead *)
                        let v6657 : System.IO.FileShare = System.IO.FileShare.Read
                        v6657
                    | US8_3 -> (* ShareReadWrite *)
                        let v6659 : System.IO.FileShare = System.IO.FileShare.ReadWrite
                        v6659
                    | US8_2 -> (* ShareWrite *)
                        let v6658 : System.IO.FileShare = System.IO.FileShare.Write
                        v6658
                let v6666 : System.IO.FileStream = new System.IO.FileStream (v1, v6649, v6655, v6665)
                let _v6630 = v6666 
                #endif
                let v6667 : System.IO.FileStream = _v6630 
                use v6667 = v6667 
                let v6672 : System.IO.FileStream = v6667 
                return v2 
                (* indent
                ()
            indent *)
            with ex ->
                let v6716 : exn = ex
                let v6717 : bool = v2 > 0L
                let v6720 : bool =
                    if v6717 then
                        let v6718 : int64 = v2 % 100L
                        let v6719 : bool = v6718 = 0L
                        v6719
                    else
                        false
                if v6720 then
                    let v6721 : unit = ()
                    let v6722 : (unit -> unit) = closure12(v1, v2, v6716)
                    let v6723 : unit = (fun () -> v6722 (); v6721) ()
                    ()
                let v6789 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v6790 : (int32 -> Async<unit>) = Async.Sleep
                let v6791 : Async<unit> = v6790 10
                let _v6789 = v6791 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v6792 : (int32 -> Async<unit>) = Async.Sleep
                let v6793 : Async<unit> = v6792 10
                let _v6789 = v6793 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v6794 : (int32 -> Async<unit>) = Async.Sleep
                let v6795 : Async<unit> = v6794 10
                let _v6789 = v6795 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v6796 : (int32 -> Async<unit>) = Async.Sleep
                let v6797 : Async<unit> = v6796 10
                let _v6789 = v6797 
                #endif
#if FABLE_COMPILER_PYTHON
                let v6798 : (int32 -> Async<unit>) = Async.Sleep
                let v6799 : Async<unit> = v6798 10
                let _v6789 = v6799 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v6800 : (int32 -> Async<unit>) = Async.Sleep
                let v6801 : Async<unit> = v6800 10
                let _v6789 = v6801 
                #endif
#else
                let v6802 : (int32 -> Async<unit>) = Async.Sleep
                let v6803 : Async<unit> = v6802 10
                let _v6789 = v6803 
                #endif
                let v6804 : Async<unit> = _v6789 
                do! v6804 
                let v6807 : int64 = v2 + 1L
                let v6808 : Async<int64> = method26(v0, v1, v6807)
                return! v6808 
                (* indent
                ()
            indent *)
            (* try_unit
            let v6902 : int64 = try_unit *)
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v8830 : Async<int64> = _v6627 
    let _v5 = v8830 
    #endif
    let v8831 : Async<int64> = _v5 
    v8831
and method26 (v0 : US6, v1 : string, v2 : int64) : Async<int64> =
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
    let v13 : Async<int64> = null |> unbox<Async<int64>>
    let _v3 = v13 
    #endif
#if FABLE_COMPILER_PYTHON
    let v16 : Async<int64> = null |> unbox<Async<int64>>
    let _v3 = v16 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v19 : Async<int64> = null |> unbox<Async<int64>>
    let _v3 = v19 
    #endif
#else
    let struct (v28 : US7, v29 : US8) =
        match v0 with
        | US6_1 -> (* None *)
            let v24 : US7 = US7_2
            let v25 : US8 = US8_1
            struct (v24, v25)
        | US6_0(v22, v23) -> (* Some *)
            struct (v22, v23)
    let v30 : Async<int64> = method27(v0, v1, v2, v29, v28)
    let _v3 = v30 
    #endif
    let v31 : Async<int64> = _v3 
    v31
and method25 (v0 : US6, v1 : string) : Async<int64> =
    let v2 : int64 = 0L
    method26(v0, v1, v2)
and closure11 (v0 : US6) (v1 : string) : Async<int64> =
    method25(v0, v1)
and closure10 () (v0 : US6) : (string -> Async<int64>) =
    closure11(v0)
and method30 (v0 : string) : Async<int64> =
    let v1 : US7 = US7_0
    let v2 : US8 = US8_1
    let v3 : US6 = US6_0(v1, v2)
    method25(v3, v0)
and closure13 () (v0 : string) : Async<int64> =
    method30(v0)
and method31 (v0 : string) : Async<string> =
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
    let v22 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v23 : Async<string> = null |> unbox<Async<string>>
    let _v22 = v23 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v26 : Async<string> = null |> unbox<Async<string>>
    let _v22 = v26 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v29 : Async<string> = null |> unbox<Async<string>>
    let _v22 = v29 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v32 : (System.Threading.Tasks.Task<string> -> Async<string>) = Async.AwaitTask
    let v33 : Async<string> = v32 v21
    let _v22 = v33 
    #endif
#if FABLE_COMPILER_PYTHON
    let v34 : (System.Threading.Tasks.Task<string> -> Async<string>) = Async.AwaitTask
    let v35 : Async<string> = v34 v21
    let _v22 = v35 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v36 : (System.Threading.Tasks.Task<string> -> Async<string>) = Async.AwaitTask
    let v37 : Async<string> = v36 v21
    let _v22 = v37 
    #endif
#else
    let v38 : (System.Threading.Tasks.Task<string> -> Async<string>) = Async.AwaitTask
    let v39 : Async<string> = v38 v21
    let _v22 = v39 
    #endif
    let v40 : Async<string> = _v22 
    let _v1 = v40 
    #endif
    let v45 : Async<string> = _v1 
    v45
and closure14 () (v0 : string) : Async<string> =
    method31(v0)
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
    let v22 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v23 : Async<unit> = null |> unbox<Async<unit>>
    let _v22 = v23 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v26 : Async<unit> = null |> unbox<Async<unit>>
    let _v22 = v26 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v29 : Async<unit> = null |> unbox<Async<unit>>
    let _v22 = v29 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v32 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
    let v33 : Async<unit> = v32 v21
    let _v22 = v33 
    #endif
#if FABLE_COMPILER_PYTHON
    let v34 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
    let v35 : Async<unit> = v34 v21
    let _v22 = v35 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v36 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
    let v37 : Async<unit> = v36 v21
    let _v22 = v37 
    #endif
#else
    let v38 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
    let v39 : Async<unit> = v38 v21
    let _v22 = v39 
    #endif
    let v40 : Async<unit> = _v22 
    let _v2 = v40 
    #endif
    let v45 : Async<unit> = _v2 
    v45
and closure18 (v0 : string) (v1 : string) : Async<unit> =
    method35(v0, v1)
and closure17 () (v0 : string) : (string -> Async<unit>) =
    closure18(v0)
and method39 (v0 : string, v1 : string) : Async<bool> =
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
    let v12 : unit = ()
    let _v12 =
        async {
            let v15 : bool = method33(v0)
            let v16 : bool = v15 = false
            if v16 then
                return false 
                (* fix_condition then
                ()
            else
                fix_condition then *) else
                let v17 : Async<string> = method31(v0)
                let! v17 = v17 
                let v18 : string = v17 
                let v19 : bool = v1 = v18
                return v19 
                (* fix_condition else
                ()
            fix_condition else *)
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v55 : Async<bool> = _v12 
    let _v2 = v55 
    #endif
#if FABLE_COMPILER_PYTHON
    let v56 : unit = ()
    let _v56 =
        async {
            let v59 : bool = method33(v0)
            let v60 : bool = v59 = false
            if v60 then
                return false 
                (* fix_condition then
                ()
            else
                fix_condition then *) else
                let v61 : Async<string> = method31(v0)
                let! v61 = v61 
                let v62 : string = v61 
                let v63 : bool = v1 = v62
                return v63 
                (* fix_condition else
                ()
            fix_condition else *)
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v99 : Async<bool> = _v56 
    let _v2 = v99 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v100 : unit = ()
    let _v100 =
        async {
            let v103 : bool = method33(v0)
            let v104 : bool = v103 = false
            if v104 then
                return false 
                (* fix_condition then
                ()
            else
                fix_condition then *) else
                let v105 : Async<string> = method31(v0)
                let! v105 = v105 
                let v106 : string = v105 
                let v107 : bool = v1 = v106
                return v107 
                (* fix_condition else
                ()
            fix_condition else *)
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v143 : Async<bool> = _v100 
    let _v2 = v143 
    #endif
#else
    let v144 : unit = ()
    let _v144 =
        async {
            let v147 : bool = method33(v0)
            let v148 : bool = v147 = false
            if v148 then
                return false 
                (* fix_condition then
                ()
            else
                fix_condition then *) else
                let v149 : Async<string> = method31(v0)
                let! v149 = v149 
                let v150 : string = v149 
                let v151 : bool = v1 = v150
                return v151 
                (* fix_condition else
                ()
            fix_condition else *)
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v187 : Async<bool> = _v144 
    let _v2 = v187 
    #endif
    let v188 : Async<bool> = _v2 
    v188
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
    let v21 : Async<bool> = method39(v0, v1)
    let _v2 = v21 
    #endif
    let v22 : Async<bool> = _v2 
    v22
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
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
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
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
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
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
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
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v155 : Async<unit> = _v120 
    let _v2 = v155 
    #endif
    let v156 : Async<unit> = _v2 
    v156
and method36 (v0 : string, v1 : string) : Async<unit> =
    method37(v0, v1)
and closure20 (v0 : string) (v1 : string) : Async<unit> =
    method36(v0, v1)
and closure19 () (v0 : string) : (string -> Async<unit>) =
    closure20(v0)
and method43 () : string =
    
    
    
    
    
    let v0 : string = "Warning"
    let v1 : (unit -> string) = v0.ToLower
    let v2 : string = v1 ()
    let v5 : char = v2.[int 0]
    let v6 : string = method17(v5)
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
    let v105 : string = method19()
    let v106 : string = v104 + v6 
    let v107 : string = v106 + v105 
    let _v7 = v107 
    #endif
#if FABLE_COMPILER_PYTHON
    let v108 : string = "\u001b[93m"
    let v109 : string = method19()
    let v110 : string = v108 + v6 
    let v111 : string = v110 + v109 
    let _v7 = v111 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v112 : string = "\u001b[93m"
    let v113 : string = method19()
    let v114 : string = v112 + v6 
    let v115 : string = v114 + v113 
    let _v7 = v115 
    #endif
#else
    let v116 : string = "\u001b[93m"
    let v117 : string = method19()
    let v118 : string = v116 + v6 
    let v119 : string = v118 + v117 
    let _v7 = v119 
    #endif
    let v120 : string = _v7 
    v120
and method45 (v0 : string, v1 : string) : string =
    let v2 : string = method18()
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
and method44 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : string, v9 : string) : string =
    let v10 : string = method45(v8, v9)
    let v11 : int64 = v0.l0
    let v12 : string = "delete_file_async"
    let v13 : string = $"{v6} {v7} #{v11} %s{v12} / {v10}"
    method23(v13)
and closure22 (v0 : string, v1 : exn) () : unit =
    let v2 : US0 = US0_3
    let v3 : bool = method11(v2)
    if v3 then
        let v4 : unit = ()
        let v5 : (unit -> unit) = closure0()
        let v6 : unit = (fun () -> v5 (); v4) ()
        let struct (v20 : Mut0, v21 : Mut1, v22 : Mut2, v23 : Mut3, v24 : Mut4, v25 : int64 option) = TraceState.trace_state.Value
        let v38 : string = method12(v20, v21, v22, v23, v24, v25)
        let v39 : string = method43()
        let v40 : string = method20(v0)
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
        let v66 : string = method44(v20, v21, v22, v23, v24, v25, v38, v39, v40, v61)
        method24(v66)
and method42 (v0 : string, v1 : int64) : Async<int64> =
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
                #endif
#if FABLE_COMPILER_RUST && WASM
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                #endif
#if FABLE_COMPILER_PYTHON
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                #endif
#else
                let v17 : (string -> unit) = System.IO.File.Delete
                v17 v0
                #endif
                // run_target_args' is_unit
                return v1 
                (* indent
                ()
            indent *)
            with ex ->
                let v21 : exn = ex
                let v22 : int64 = v1 % 100L
                let v23 : bool = v22 = 0L
                if v23 then
                    let v24 : unit = ()
                    let v25 : (unit -> unit) = closure22(v0, v21)
                    let v26 : unit = (fun () -> v25 (); v24) ()
                    ()
                let v92 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v93 : (int32 -> Async<unit>) = Async.Sleep
                let v94 : Async<unit> = v93 10
                let _v92 = v94 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v95 : (int32 -> Async<unit>) = Async.Sleep
                let v96 : Async<unit> = v95 10
                let _v92 = v96 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v97 : (int32 -> Async<unit>) = Async.Sleep
                let v98 : Async<unit> = v97 10
                let _v92 = v98 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v99 : (int32 -> Async<unit>) = Async.Sleep
                let v100 : Async<unit> = v99 10
                let _v92 = v100 
                #endif
#if FABLE_COMPILER_PYTHON
                let v101 : (int32 -> Async<unit>) = Async.Sleep
                let v102 : Async<unit> = v101 10
                let _v92 = v102 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v103 : (int32 -> Async<unit>) = Async.Sleep
                let v104 : Async<unit> = v103 10
                let _v92 = v104 
                #endif
#else
                let v105 : (int32 -> Async<unit>) = Async.Sleep
                let v106 : Async<unit> = v105 10
                let _v92 = v106 
                #endif
                let v107 : Async<unit> = _v92 
                do! v107 
                let v110 : int64 = v1 + 1L
                let v111 : Async<int64> = method41(v0, v110)
                return! v111 
                (* indent
                ()
            indent *)
            (* try_unit
            let v203 : int64 = try_unit *)
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v1543 : Async<int64> = _v12 
    let _v2 = v1543 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1544 : unit = ()
    let _v1544 =
        async {
            try
                let v1547 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v1548 : string = "std::fs::remove_file(&*$0).unwrap()"
                Fable.Core.RustInterop.emitRustExpr v0 v1548 
                #endif
#if FABLE_COMPILER_RUST && WASM
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                #endif
#if FABLE_COMPILER_PYTHON
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                #endif
#else
                let v1549 : (string -> unit) = System.IO.File.Delete
                v1549 v0
                #endif
                // run_target_args' is_unit
                return v1 
                (* indent
                ()
            indent *)
            with ex ->
                let v1553 : exn = ex
                let v1554 : int64 = v1 % 100L
                let v1555 : bool = v1554 = 0L
                if v1555 then
                    let v1556 : unit = ()
                    let v1557 : (unit -> unit) = closure22(v0, v1553)
                    let v1558 : unit = (fun () -> v1557 (); v1556) ()
                    ()
                let v1624 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v1625 : (int32 -> Async<unit>) = Async.Sleep
                let v1626 : Async<unit> = v1625 10
                let _v1624 = v1626 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v1627 : (int32 -> Async<unit>) = Async.Sleep
                let v1628 : Async<unit> = v1627 10
                let _v1624 = v1628 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v1629 : (int32 -> Async<unit>) = Async.Sleep
                let v1630 : Async<unit> = v1629 10
                let _v1624 = v1630 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v1631 : (int32 -> Async<unit>) = Async.Sleep
                let v1632 : Async<unit> = v1631 10
                let _v1624 = v1632 
                #endif
#if FABLE_COMPILER_PYTHON
                let v1633 : (int32 -> Async<unit>) = Async.Sleep
                let v1634 : Async<unit> = v1633 10
                let _v1624 = v1634 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v1635 : (int32 -> Async<unit>) = Async.Sleep
                let v1636 : Async<unit> = v1635 10
                let _v1624 = v1636 
                #endif
#else
                let v1637 : (int32 -> Async<unit>) = Async.Sleep
                let v1638 : Async<unit> = v1637 10
                let _v1624 = v1638 
                #endif
                let v1639 : Async<unit> = _v1624 
                do! v1639 
                let v1642 : int64 = v1 + 1L
                let v1643 : Async<int64> = method41(v0, v1642)
                return! v1643 
                (* indent
                ()
            indent *)
            (* try_unit
            let v1735 : int64 = try_unit *)
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v3075 : Async<int64> = _v1544 
    let _v2 = v3075 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v3076 : unit = ()
    let _v3076 =
        async {
            try
                let v3079 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v3080 : string = "std::fs::remove_file(&*$0).unwrap()"
                Fable.Core.RustInterop.emitRustExpr v0 v3080 
                #endif
#if FABLE_COMPILER_RUST && WASM
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                #endif
#if FABLE_COMPILER_PYTHON
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                #endif
#else
                let v3081 : (string -> unit) = System.IO.File.Delete
                v3081 v0
                #endif
                // run_target_args' is_unit
                return v1 
                (* indent
                ()
            indent *)
            with ex ->
                let v3085 : exn = ex
                let v3086 : int64 = v1 % 100L
                let v3087 : bool = v3086 = 0L
                if v3087 then
                    let v3088 : unit = ()
                    let v3089 : (unit -> unit) = closure22(v0, v3085)
                    let v3090 : unit = (fun () -> v3089 (); v3088) ()
                    ()
                let v3156 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v3157 : (int32 -> Async<unit>) = Async.Sleep
                let v3158 : Async<unit> = v3157 10
                let _v3156 = v3158 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v3159 : (int32 -> Async<unit>) = Async.Sleep
                let v3160 : Async<unit> = v3159 10
                let _v3156 = v3160 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v3161 : (int32 -> Async<unit>) = Async.Sleep
                let v3162 : Async<unit> = v3161 10
                let _v3156 = v3162 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v3163 : (int32 -> Async<unit>) = Async.Sleep
                let v3164 : Async<unit> = v3163 10
                let _v3156 = v3164 
                #endif
#if FABLE_COMPILER_PYTHON
                let v3165 : (int32 -> Async<unit>) = Async.Sleep
                let v3166 : Async<unit> = v3165 10
                let _v3156 = v3166 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v3167 : (int32 -> Async<unit>) = Async.Sleep
                let v3168 : Async<unit> = v3167 10
                let _v3156 = v3168 
                #endif
#else
                let v3169 : (int32 -> Async<unit>) = Async.Sleep
                let v3170 : Async<unit> = v3169 10
                let _v3156 = v3170 
                #endif
                let v3171 : Async<unit> = _v3156 
                do! v3171 
                let v3174 : int64 = v1 + 1L
                let v3175 : Async<int64> = method41(v0, v3174)
                return! v3175 
                (* indent
                ()
            indent *)
            (* try_unit
            let v3267 : int64 = try_unit *)
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v4607 : Async<int64> = _v3076 
    let _v2 = v4607 
    #endif
#else
    let v4608 : unit = ()
    let _v4608 =
        async {
            try
                let v4611 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v4612 : string = "std::fs::remove_file(&*$0).unwrap()"
                Fable.Core.RustInterop.emitRustExpr v0 v4612 
                #endif
#if FABLE_COMPILER_RUST && WASM
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                #endif
#if FABLE_COMPILER_PYTHON
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                #endif
#else
                let v4613 : (string -> unit) = System.IO.File.Delete
                v4613 v0
                #endif
                // run_target_args' is_unit
                return v1 
                (* indent
                ()
            indent *)
            with ex ->
                let v4617 : exn = ex
                let v4618 : int64 = v1 % 100L
                let v4619 : bool = v4618 = 0L
                if v4619 then
                    let v4620 : unit = ()
                    let v4621 : (unit -> unit) = closure22(v0, v4617)
                    let v4622 : unit = (fun () -> v4621 (); v4620) ()
                    ()
                let v4688 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v4689 : (int32 -> Async<unit>) = Async.Sleep
                let v4690 : Async<unit> = v4689 10
                let _v4688 = v4690 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v4691 : (int32 -> Async<unit>) = Async.Sleep
                let v4692 : Async<unit> = v4691 10
                let _v4688 = v4692 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v4693 : (int32 -> Async<unit>) = Async.Sleep
                let v4694 : Async<unit> = v4693 10
                let _v4688 = v4694 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v4695 : (int32 -> Async<unit>) = Async.Sleep
                let v4696 : Async<unit> = v4695 10
                let _v4688 = v4696 
                #endif
#if FABLE_COMPILER_PYTHON
                let v4697 : (int32 -> Async<unit>) = Async.Sleep
                let v4698 : Async<unit> = v4697 10
                let _v4688 = v4698 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v4699 : (int32 -> Async<unit>) = Async.Sleep
                let v4700 : Async<unit> = v4699 10
                let _v4688 = v4700 
                #endif
#else
                let v4701 : (int32 -> Async<unit>) = Async.Sleep
                let v4702 : Async<unit> = v4701 10
                let _v4688 = v4702 
                #endif
                let v4703 : Async<unit> = _v4688 
                do! v4703 
                let v4706 : int64 = v1 + 1L
                let v4707 : Async<int64> = method41(v0, v4706)
                return! v4707 
                (* indent
                ()
            indent *)
            (* try_unit
            let v4799 : int64 = try_unit *)
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v6139 : Async<int64> = _v4608 
    let _v2 = v6139 
    #endif
    let v6140 : Async<int64> = _v2 
    v6140
and method41 (v0 : string, v1 : int64) : Async<int64> =
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
    let v21 : Async<int64> = method42(v0, v1)
    let _v2 = v21 
    #endif
    let v22 : Async<int64> = _v2 
    v22
and method40 (v0 : string) : Async<int64> =
    let v1 : int64 = 0L
    method41(v0, v1)
and closure21 () (v0 : string) : Async<int64> =
    method40(v0)
and method49 (v0 : string, v1 : string) : unit =
    let v2 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    #endif
#if FABLE_COMPILER_RUST && WASM
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    #endif
#if FABLE_COMPILER_PYTHON
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    #endif
#else
    System.IO.File.Move (v1, v0)
    #endif
    // run_target_args' is_unit
    ()
and method51 (v0 : string, v1 : string, v2 : string) : string =
    let v3 : string = method18()
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
and method50 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : string, v9 : string, v10 : string) : string =
    let v11 : string = method51(v8, v9, v10)
    let v12 : int64 = v0.l0
    let v13 : string = "move_file_async"
    let v14 : string = $"{v6} {v7} #{v12} %s{v13} / {v11}"
    method23(v14)
and closure25 (v0 : string, v1 : string, v2 : exn) () : unit =
    let v3 : US0 = US0_3
    let v4 : bool = method11(v3)
    if v4 then
        let v5 : unit = ()
        let v6 : (unit -> unit) = closure0()
        let v7 : unit = (fun () -> v6 (); v5) ()
        let struct (v21 : Mut0, v22 : Mut1, v23 : Mut2, v24 : Mut3, v25 : Mut4, v26 : int64 option) = TraceState.trace_state.Value
        let v39 : string = method12(v21, v22, v23, v24, v25, v26)
        let v40 : string = method43()
        let v41 : string = method20(v1)
        let v42 : string = method20(v0)
        let v43 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v44 : string = $"%A{v2}"
        let _v43 = v44 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v47 : string = $"%A{v2}"
        let _v43 = v47 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v50 : string = $"%A{v2}"
        let _v43 = v50 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v53 : string = $"%A{v2}"
        let _v43 = v53 
        #endif
#if FABLE_COMPILER_PYTHON
        let v56 : string = $"%A{v2}"
        let _v43 = v56 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v59 : string = $"%A{v2}"
        let _v43 = v59 
        #endif
#else
        let v62 : string = $"{v2.GetType ()}: {v2.Message}"
        let _v43 = v62 
        #endif
        let v63 : string = _v43 
        let v68 : string = method50(v21, v22, v23, v24, v25, v26, v39, v40, v41, v42, v63)
        method24(v68)
and method48 (v0 : string, v1 : string, v2 : int64) : Async<int64> =
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
                method49(v0, v1)
                return v2 
                (* indent
                ()
            indent *)
            with ex ->
                let v16 : exn = ex
                let v17 : int64 = v2 % 100L
                let v18 : bool = v17 = 0L
                if v18 then
                    let v19 : unit = ()
                    let v20 : (unit -> unit) = closure25(v0, v1, v16)
                    let v21 : unit = (fun () -> v20 (); v19) ()
                    ()
                let v88 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v89 : (int32 -> Async<unit>) = Async.Sleep
                let v90 : Async<unit> = v89 10
                let _v88 = v90 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v91 : (int32 -> Async<unit>) = Async.Sleep
                let v92 : Async<unit> = v91 10
                let _v88 = v92 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v93 : (int32 -> Async<unit>) = Async.Sleep
                let v94 : Async<unit> = v93 10
                let _v88 = v94 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v95 : (int32 -> Async<unit>) = Async.Sleep
                let v96 : Async<unit> = v95 10
                let _v88 = v96 
                #endif
#if FABLE_COMPILER_PYTHON
                let v97 : (int32 -> Async<unit>) = Async.Sleep
                let v98 : Async<unit> = v97 10
                let _v88 = v98 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v99 : (int32 -> Async<unit>) = Async.Sleep
                let v100 : Async<unit> = v99 10
                let _v88 = v100 
                #endif
#else
                let v101 : (int32 -> Async<unit>) = Async.Sleep
                let v102 : Async<unit> = v101 10
                let _v88 = v102 
                #endif
                let v103 : Async<unit> = _v88 
                do! v103 
                let v106 : int64 = v2 + 1L
                let v107 : Async<int64> = method47(v0, v1, v106)
                return! v107 
                (* indent
                ()
            indent *)
            (* try_unit
            try_unit *)
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v1488 : Async<int64> = _v13 
    let _v3 = v1488 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1489 : unit = ()
    let _v1489 =
        async {
            try
                method49(v0, v1)
                return v2 
                (* indent
                ()
            indent *)
            with ex ->
                let v1492 : exn = ex
                let v1493 : int64 = v2 % 100L
                let v1494 : bool = v1493 = 0L
                if v1494 then
                    let v1495 : unit = ()
                    let v1496 : (unit -> unit) = closure25(v0, v1, v1492)
                    let v1497 : unit = (fun () -> v1496 (); v1495) ()
                    ()
                let v1564 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v1565 : (int32 -> Async<unit>) = Async.Sleep
                let v1566 : Async<unit> = v1565 10
                let _v1564 = v1566 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v1567 : (int32 -> Async<unit>) = Async.Sleep
                let v1568 : Async<unit> = v1567 10
                let _v1564 = v1568 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v1569 : (int32 -> Async<unit>) = Async.Sleep
                let v1570 : Async<unit> = v1569 10
                let _v1564 = v1570 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v1571 : (int32 -> Async<unit>) = Async.Sleep
                let v1572 : Async<unit> = v1571 10
                let _v1564 = v1572 
                #endif
#if FABLE_COMPILER_PYTHON
                let v1573 : (int32 -> Async<unit>) = Async.Sleep
                let v1574 : Async<unit> = v1573 10
                let _v1564 = v1574 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v1575 : (int32 -> Async<unit>) = Async.Sleep
                let v1576 : Async<unit> = v1575 10
                let _v1564 = v1576 
                #endif
#else
                let v1577 : (int32 -> Async<unit>) = Async.Sleep
                let v1578 : Async<unit> = v1577 10
                let _v1564 = v1578 
                #endif
                let v1579 : Async<unit> = _v1564 
                do! v1579 
                let v1582 : int64 = v2 + 1L
                let v1583 : Async<int64> = method47(v0, v1, v1582)
                return! v1583 
                (* indent
                ()
            indent *)
            (* try_unit
            try_unit *)
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v2964 : Async<int64> = _v1489 
    let _v3 = v2964 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v2965 : unit = ()
    let _v2965 =
        async {
            try
                method49(v0, v1)
                return v2 
                (* indent
                ()
            indent *)
            with ex ->
                let v2968 : exn = ex
                let v2969 : int64 = v2 % 100L
                let v2970 : bool = v2969 = 0L
                if v2970 then
                    let v2971 : unit = ()
                    let v2972 : (unit -> unit) = closure25(v0, v1, v2968)
                    let v2973 : unit = (fun () -> v2972 (); v2971) ()
                    ()
                let v3040 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v3041 : (int32 -> Async<unit>) = Async.Sleep
                let v3042 : Async<unit> = v3041 10
                let _v3040 = v3042 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v3043 : (int32 -> Async<unit>) = Async.Sleep
                let v3044 : Async<unit> = v3043 10
                let _v3040 = v3044 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v3045 : (int32 -> Async<unit>) = Async.Sleep
                let v3046 : Async<unit> = v3045 10
                let _v3040 = v3046 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v3047 : (int32 -> Async<unit>) = Async.Sleep
                let v3048 : Async<unit> = v3047 10
                let _v3040 = v3048 
                #endif
#if FABLE_COMPILER_PYTHON
                let v3049 : (int32 -> Async<unit>) = Async.Sleep
                let v3050 : Async<unit> = v3049 10
                let _v3040 = v3050 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v3051 : (int32 -> Async<unit>) = Async.Sleep
                let v3052 : Async<unit> = v3051 10
                let _v3040 = v3052 
                #endif
#else
                let v3053 : (int32 -> Async<unit>) = Async.Sleep
                let v3054 : Async<unit> = v3053 10
                let _v3040 = v3054 
                #endif
                let v3055 : Async<unit> = _v3040 
                do! v3055 
                let v3058 : int64 = v2 + 1L
                let v3059 : Async<int64> = method47(v0, v1, v3058)
                return! v3059 
                (* indent
                ()
            indent *)
            (* try_unit
            try_unit *)
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v4440 : Async<int64> = _v2965 
    let _v3 = v4440 
    #endif
#else
    let v4441 : unit = ()
    let _v4441 =
        async {
            try
                method49(v0, v1)
                return v2 
                (* indent
                ()
            indent *)
            with ex ->
                let v4444 : exn = ex
                let v4445 : int64 = v2 % 100L
                let v4446 : bool = v4445 = 0L
                if v4446 then
                    let v4447 : unit = ()
                    let v4448 : (unit -> unit) = closure25(v0, v1, v4444)
                    let v4449 : unit = (fun () -> v4448 (); v4447) ()
                    ()
                let v4516 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v4517 : (int32 -> Async<unit>) = Async.Sleep
                let v4518 : Async<unit> = v4517 10
                let _v4516 = v4518 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v4519 : (int32 -> Async<unit>) = Async.Sleep
                let v4520 : Async<unit> = v4519 10
                let _v4516 = v4520 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v4521 : (int32 -> Async<unit>) = Async.Sleep
                let v4522 : Async<unit> = v4521 10
                let _v4516 = v4522 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v4523 : (int32 -> Async<unit>) = Async.Sleep
                let v4524 : Async<unit> = v4523 10
                let _v4516 = v4524 
                #endif
#if FABLE_COMPILER_PYTHON
                let v4525 : (int32 -> Async<unit>) = Async.Sleep
                let v4526 : Async<unit> = v4525 10
                let _v4516 = v4526 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v4527 : (int32 -> Async<unit>) = Async.Sleep
                let v4528 : Async<unit> = v4527 10
                let _v4516 = v4528 
                #endif
#else
                let v4529 : (int32 -> Async<unit>) = Async.Sleep
                let v4530 : Async<unit> = v4529 10
                let _v4516 = v4530 
                #endif
                let v4531 : Async<unit> = _v4516 
                do! v4531 
                let v4534 : int64 = v2 + 1L
                let v4535 : Async<int64> = method47(v0, v1, v4534)
                return! v4535 
                (* indent
                ()
            indent *)
            (* try_unit
            try_unit *)
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v5916 : Async<int64> = _v4441 
    let _v3 = v5916 
    #endif
    let v5917 : Async<int64> = _v3 
    v5917
and method47 (v0 : string, v1 : string, v2 : int64) : Async<int64> =
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
    let v13 : Async<int64> = null |> unbox<Async<int64>>
    let _v3 = v13 
    #endif
#if FABLE_COMPILER_PYTHON
    let v16 : Async<int64> = null |> unbox<Async<int64>>
    let _v3 = v16 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v19 : Async<int64> = null |> unbox<Async<int64>>
    let _v3 = v19 
    #endif
#else
    let v22 : Async<int64> = method48(v0, v1, v2)
    let _v3 = v22 
    #endif
    let v23 : Async<int64> = _v3 
    v23
and method46 (v0 : string, v1 : string) : Async<int64> =
    let v2 : int64 = 0L
    method47(v0, v1, v2)
and closure24 (v0 : string) (v1 : string) : Async<int64> =
    method46(v0, v1)
and closure23 () (v0 : string) : (string -> Async<int64>) =
    closure24(v0)
and closure27 () (v0 : int64) : US9 =
    US9_0(v0)
and method58 () : (int64 -> US9) =
    closure27()
and closure28 () (v0 : exn) : US9 =
    US9_1(v0)
and method59 () : (exn -> US9) =
    closure28()
and method57 (v0 : Async<Choice<int64, exn>>) : Async<US9> =
    let v1 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : Async<US9> = null |> unbox<Async<US9>>
    let _v1 = v2 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v5 : Async<US9> = null |> unbox<Async<US9>>
    let _v1 = v5 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v8 : Async<US9> = null |> unbox<Async<US9>>
    let _v1 = v8 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v11 : unit = ()
    let _v11 =
        async {
            let! v0 = v0 
            let v14 : Choice<int64, exn> = v0 
            let v15 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v16 : US9 = null |> unbox<US9>
            let _v15 = v16 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v19 : US9 = null |> unbox<US9>
            let _v15 = v19 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v22 : US9 = null |> unbox<US9>
            let _v15 = v22 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v25 : US9 = null |> unbox<US9>
            let _v15 = v25 
            #endif
#if FABLE_COMPILER_PYTHON
            let v28 : US9 = null |> unbox<US9>
            let _v15 = v28 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v31 : (int64 -> US9) = method58()
            let v32 : (exn -> US9) = method59()
            let v33 : US9 = match v14 with Choice1Of2 x -> v31 x | Choice2Of2 x -> v32 x
            let _v15 = v33 
            #endif
#else
            let v34 : (int64 -> US9) = method58()
            let v35 : (exn -> US9) = method59()
            let v36 : US9 = match v14 with Choice1Of2 x -> v34 x | Choice2Of2 x -> v35 x
            let _v15 = v36 
            #endif
            let v37 : US9 = _v15 
            return v37 
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v238 : Async<US9> = _v11 
    let _v1 = v238 
    #endif
#if FABLE_COMPILER_PYTHON
    let v239 : unit = ()
    let _v239 =
        async {
            let! v0 = v0 
            let v242 : Choice<int64, exn> = v0 
            let v243 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v244 : US9 = null |> unbox<US9>
            let _v243 = v244 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v247 : US9 = null |> unbox<US9>
            let _v243 = v247 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v250 : US9 = null |> unbox<US9>
            let _v243 = v250 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v253 : US9 = null |> unbox<US9>
            let _v243 = v253 
            #endif
#if FABLE_COMPILER_PYTHON
            let v256 : US9 = null |> unbox<US9>
            let _v243 = v256 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v259 : (int64 -> US9) = method58()
            let v260 : (exn -> US9) = method59()
            let v261 : US9 = match v242 with Choice1Of2 x -> v259 x | Choice2Of2 x -> v260 x
            let _v243 = v261 
            #endif
#else
            let v262 : (int64 -> US9) = method58()
            let v263 : (exn -> US9) = method59()
            let v264 : US9 = match v242 with Choice1Of2 x -> v262 x | Choice2Of2 x -> v263 x
            let _v243 = v264 
            #endif
            let v265 : US9 = _v243 
            return v265 
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v466 : Async<US9> = _v239 
    let _v1 = v466 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v467 : unit = ()
    let _v467 =
        async {
            let! v0 = v0 
            let v470 : Choice<int64, exn> = v0 
            let v471 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v472 : US9 = null |> unbox<US9>
            let _v471 = v472 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v475 : US9 = null |> unbox<US9>
            let _v471 = v475 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v478 : US9 = null |> unbox<US9>
            let _v471 = v478 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v481 : US9 = null |> unbox<US9>
            let _v471 = v481 
            #endif
#if FABLE_COMPILER_PYTHON
            let v484 : US9 = null |> unbox<US9>
            let _v471 = v484 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v487 : (int64 -> US9) = method58()
            let v488 : (exn -> US9) = method59()
            let v489 : US9 = match v470 with Choice1Of2 x -> v487 x | Choice2Of2 x -> v488 x
            let _v471 = v489 
            #endif
#else
            let v490 : (int64 -> US9) = method58()
            let v491 : (exn -> US9) = method59()
            let v492 : US9 = match v470 with Choice1Of2 x -> v490 x | Choice2Of2 x -> v491 x
            let _v471 = v492 
            #endif
            let v493 : US9 = _v471 
            return v493 
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v694 : Async<US9> = _v467 
    let _v1 = v694 
    #endif
#else
    let v695 : unit = ()
    let _v695 =
        async {
            let! v0 = v0 
            let v698 : Choice<int64, exn> = v0 
            let v699 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v700 : US9 = null |> unbox<US9>
            let _v699 = v700 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v703 : US9 = null |> unbox<US9>
            let _v699 = v703 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v706 : US9 = null |> unbox<US9>
            let _v699 = v706 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v709 : US9 = null |> unbox<US9>
            let _v699 = v709 
            #endif
#if FABLE_COMPILER_PYTHON
            let v712 : US9 = null |> unbox<US9>
            let _v699 = v712 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v715 : (int64 -> US9) = method58()
            let v716 : (exn -> US9) = method59()
            let v717 : US9 = match v698 with Choice1Of2 x -> v715 x | Choice2Of2 x -> v716 x
            let _v699 = v717 
            #endif
#else
            let v718 : (int64 -> US9) = method58()
            let v719 : (exn -> US9) = method59()
            let v720 : US9 = match v698 with Choice1Of2 x -> v718 x | Choice2Of2 x -> v719 x
            let _v699 = v720 
            #endif
            let v721 : US9 = _v699 
            return v721 
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v922 : Async<US9> = _v695 
    let _v1 = v922 
    #endif
    let v923 : Async<US9> = _v1 
    v923
and method60 (v0 : Async<US9>) : Async<US10> =
    let v1 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : Async<US10> = null |> unbox<Async<US10>>
    let _v1 = v2 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v5 : Async<US10> = null |> unbox<Async<US10>>
    let _v1 = v5 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v8 : Async<US10> = null |> unbox<Async<US10>>
    let _v1 = v8 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v11 : unit = ()
    let _v11 =
        async {
            let! v0 = v0 
            let v14 : US9 = v0 
            let v20 : US10 =
                match v14 with
                | US9_0(v15) -> (* C1of2 *)
                    US10_0(v15)
                | US9_1(v17) -> (* C2of2 *)
                    US10_1(v17)
            return v20 
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v70 : Async<US10> = _v11 
    let _v1 = v70 
    #endif
#if FABLE_COMPILER_PYTHON
    let v71 : unit = ()
    let _v71 =
        async {
            let! v0 = v0 
            let v74 : US9 = v0 
            let v80 : US10 =
                match v74 with
                | US9_0(v75) -> (* C1of2 *)
                    US10_0(v75)
                | US9_1(v77) -> (* C2of2 *)
                    US10_1(v77)
            return v80 
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v130 : Async<US10> = _v71 
    let _v1 = v130 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v131 : unit = ()
    let _v131 =
        async {
            let! v0 = v0 
            let v134 : US9 = v0 
            let v140 : US10 =
                match v134 with
                | US9_0(v135) -> (* C1of2 *)
                    US10_0(v135)
                | US9_1(v137) -> (* C2of2 *)
                    US10_1(v137)
            return v140 
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v190 : Async<US10> = _v131 
    let _v1 = v190 
    #endif
#else
    let v191 : unit = ()
    let _v191 =
        async {
            let! v0 = v0 
            let v194 : US9 = v0 
            let v200 : US10 =
                match v194 with
                | US9_0(v195) -> (* C1of2 *)
                    US10_0(v195)
                | US9_1(v197) -> (* C2of2 *)
                    US10_1(v197)
            return v200 
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v250 : Async<US10> = _v191 
    let _v1 = v250 
    #endif
    let v251 : Async<US10> = _v1 
    v251
and method62 () : string =
    
    
    
    
    
    let v0 : string = "Verbose"
    let v1 : (unit -> string) = v0.ToLower
    let v2 : string = v1 ()
    let v5 : char = v2.[int 0]
    let v6 : string = method17(v5)
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
    let v105 : string = method19()
    let v106 : string = v104 + v6 
    let v107 : string = v106 + v105 
    let _v7 = v107 
    #endif
#if FABLE_COMPILER_PYTHON
    let v108 : string = "\u001b[90m"
    let v109 : string = method19()
    let v110 : string = v108 + v6 
    let v111 : string = v110 + v109 
    let _v7 = v111 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v112 : string = "\u001b[90m"
    let v113 : string = method19()
    let v114 : string = v112 + v6 
    let v115 : string = v114 + v113 
    let _v7 = v115 
    #endif
#else
    let v116 : string = "\u001b[90m"
    let v117 : string = method19()
    let v118 : string = v116 + v6 
    let v119 : string = v118 + v117 
    let _v7 = v119 
    #endif
    let v120 : string = _v7 
    v120
and method64 (v0 : int32) : string =
    let v1 : string = method18()
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
and method63 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : int32) : string =
    let v9 : string = method64(v8)
    let v10 : int64 = v0.l0
    let v11 : string = "async.run_with_timeout_async"
    let v12 : string = $"{v6} {v7} #{v10} %s{v11} / {v9}"
    method23(v12)
and closure29 (v0 : int32) () : unit =
    let v1 : US0 = US0_0
    let v2 : bool = method11(v1)
    if v2 then
        let v3 : unit = ()
        let v4 : (unit -> unit) = closure0()
        let v5 : unit = (fun () -> v4 (); v3) ()
        let struct (v19 : Mut0, v20 : Mut1, v21 : Mut2, v22 : Mut3, v23 : Mut4, v24 : int64 option) = TraceState.trace_state.Value
        let v37 : string = method12(v19, v20, v21, v22, v23, v24)
        let v38 : string = method62()
        let v39 : string = method63(v19, v20, v21, v22, v23, v24, v37, v38, v0)
        method24(v39)
and method65 () : string =
    
    
    
    
    
    let v0 : string = "Critical"
    let v1 : (unit -> string) = v0.ToLower
    let v2 : string = v1 ()
    let v5 : char = v2.[int 0]
    let v6 : string = method17(v5)
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
    let v105 : string = method19()
    let v106 : string = v104 + v6 
    let v107 : string = v106 + v105 
    let _v7 = v107 
    #endif
#if FABLE_COMPILER_PYTHON
    let v108 : string = "\u001b[91m"
    let v109 : string = method19()
    let v110 : string = v108 + v6 
    let v111 : string = v110 + v109 
    let _v7 = v111 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v112 : string = "\u001b[91m"
    let v113 : string = method19()
    let v114 : string = v112 + v6 
    let v115 : string = v114 + v113 
    let _v7 = v115 
    #endif
#else
    let v116 : string = "\u001b[91m"
    let v117 : string = method19()
    let v118 : string = v116 + v6 
    let v119 : string = v118 + v117 
    let _v7 = v119 
    #endif
    let v120 : string = _v7 
    v120
and method67 (v0 : int32, v1 : string) : string =
    let v2 : string = method18()
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
and method66 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : int32, v9 : string) : string =
    let v10 : string = method67(v8, v9)
    let v11 : int64 = v0.l0
    let v12 : string = "async.run_with_timeout_async**"
    let v13 : string = $"{v6} {v7} #{v11} %s{v12} / {v10}"
    method23(v13)
and closure30 (v0 : int32, v1 : exn) () : unit =
    let v2 : US0 = US0_4
    let v3 : bool = method11(v2)
    if v3 then
        let v4 : unit = ()
        let v5 : (unit -> unit) = closure0()
        let v6 : unit = (fun () -> v5 (); v4) ()
        let struct (v20 : Mut0, v21 : Mut1, v22 : Mut2, v23 : Mut3, v24 : Mut4, v25 : int64 option) = TraceState.trace_state.Value
        let v38 : string = method12(v20, v21, v22, v23, v24, v25)
        let v39 : string = method65()
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
        let v65 : string = method66(v20, v21, v22, v23, v24, v25, v38, v39, v0, v60)
        method24(v65)
and method61 (v0 : int32, v1 : Async<US10>) : Async<US2> =
    let v2 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : Async<US2> = null |> unbox<Async<US2>>
    let _v2 = v3 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v6 : Async<US2> = null |> unbox<Async<US2>>
    let _v2 = v6 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v9 : Async<US2> = null |> unbox<Async<US2>>
    let _v2 = v9 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v12 : unit = ()
    let _v12 =
        async {
            let! v1 = v1 
            let v15 : US10 = v1 
            let v139 : US2 =
                match v15 with
                | US10_1(v18) -> (* Error *)
                    let v19 : string = $"%A{v18}"
                    let v22 : string = "System.TimeoutException"
                    let v23 : bool = v19.Contains v22 
                    if v23 then
                        let v26 : unit = ()
                        let v27 : (unit -> unit) = closure29(v0)
                        let v28 : unit = (fun () -> v27 (); v26) ()
                        US2_1
                    else
                        let v69 : unit = ()
                        let v70 : (unit -> unit) = closure30(v0, v18)
                        let v71 : unit = (fun () -> v70 (); v69) ()
                        US2_1
                | US10_0(v16) -> (* Ok *)
                    US2_0(v16)
            return v139 
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v1015 : Async<US2> = _v12 
    let _v2 = v1015 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1016 : unit = ()
    let _v1016 =
        async {
            let! v1 = v1 
            let v1019 : US10 = v1 
            let v1143 : US2 =
                match v1019 with
                | US10_1(v1022) -> (* Error *)
                    let v1023 : string = $"%A{v1022}"
                    let v1026 : string = "System.TimeoutException"
                    let v1027 : bool = v1023.Contains v1026 
                    if v1027 then
                        let v1030 : unit = ()
                        let v1031 : (unit -> unit) = closure29(v0)
                        let v1032 : unit = (fun () -> v1031 (); v1030) ()
                        US2_1
                    else
                        let v1073 : unit = ()
                        let v1074 : (unit -> unit) = closure30(v0, v1022)
                        let v1075 : unit = (fun () -> v1074 (); v1073) ()
                        US2_1
                | US10_0(v1020) -> (* Ok *)
                    US2_0(v1020)
            return v1143 
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v2019 : Async<US2> = _v1016 
    let _v2 = v2019 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v2020 : unit = ()
    let _v2020 =
        async {
            let! v1 = v1 
            let v2023 : US10 = v1 
            let v2147 : US2 =
                match v2023 with
                | US10_1(v2026) -> (* Error *)
                    let v2027 : string = $"%A{v2026}"
                    let v2030 : string = "System.TimeoutException"
                    let v2031 : bool = v2027.Contains v2030 
                    if v2031 then
                        let v2034 : unit = ()
                        let v2035 : (unit -> unit) = closure29(v0)
                        let v2036 : unit = (fun () -> v2035 (); v2034) ()
                        US2_1
                    else
                        let v2077 : unit = ()
                        let v2078 : (unit -> unit) = closure30(v0, v2026)
                        let v2079 : unit = (fun () -> v2078 (); v2077) ()
                        US2_1
                | US10_0(v2024) -> (* Ok *)
                    US2_0(v2024)
            return v2147 
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v3023 : Async<US2> = _v2020 
    let _v2 = v3023 
    #endif
#else
    let v3024 : unit = ()
    let _v3024 =
        async {
            let! v1 = v1 
            let v3027 : US10 = v1 
            let v3151 : US2 =
                match v3027 with
                | US10_1(v3030) -> (* Error *)
                    let v3031 : string = $"%A{v3030}"
                    let v3034 : string = "System.TimeoutException"
                    let v3035 : bool = v3031.Contains v3034 
                    if v3035 then
                        let v3038 : unit = ()
                        let v3039 : (unit -> unit) = closure29(v0)
                        let v3040 : unit = (fun () -> v3039 (); v3038) ()
                        US2_1
                    else
                        let v3081 : unit = ()
                        let v3082 : (unit -> unit) = closure30(v0, v3030)
                        let v3083 : unit = (fun () -> v3082 (); v3081) ()
                        US2_1
                | US10_0(v3028) -> (* Ok *)
                    US2_0(v3028)
            return v3151 
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v4027 : Async<US2> = _v3024 
    let _v2 = v4027 
    #endif
    let v4028 : Async<US2> = _v2 
    v4028
and method56 (v0 : Async<int64>, v1 : int32) : Async<US2> =
    let v2 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : Async<US2> = null |> unbox<Async<US2>>
    let _v2 = v3 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v6 : Async<US2> = null |> unbox<Async<US2>>
    let _v2 = v6 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v9 : Async<US2> = null |> unbox<Async<US2>>
    let _v2 = v9 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v12 : unit = ()
    let _v12 =
        async {
            let v15 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v16 : Async<Async<int64>> = null |> unbox<Async<Async<int64>>>
            let _v15 = v16 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v19 : Async<Async<int64>> = null |> unbox<Async<Async<int64>>>
            let _v15 = v19 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v22 : Async<Async<int64>> = null |> unbox<Async<Async<int64>>>
            let _v15 = v22 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v25 : Async<Async<int64>> = Async.StartChild (v0, v1)
            let _v15 = v25 
            #endif
#if FABLE_COMPILER_PYTHON
            let v26 : Async<Async<int64>> = Async.StartChild (v0, v1)
            let _v15 = v26 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v27 : Async<Async<int64>> = Async.StartChild (v0, v1)
            let _v15 = v27 
            #endif
#else
            let v28 : Async<Async<int64>> = Async.StartChild (v0, v1)
            let _v15 = v28 
            #endif
            let v29 : Async<Async<int64>> = _v15 
            let! v29 = v29 
            let v34 : Async<int64> = v29 
            let v35 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v36 : Async<Choice<int64, exn>> = null |> unbox<Async<Choice<int64, exn>>>
            let _v35 = v36 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v39 : Async<Choice<int64, exn>> = null |> unbox<Async<Choice<int64, exn>>>
            let _v35 = v39 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v42 : Async<Choice<int64, exn>> = null |> unbox<Async<Choice<int64, exn>>>
            let _v35 = v42 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v45 : (Async<int64> -> Async<Choice<int64, exn>>) = Async.Catch
            let v46 : Async<Choice<int64, exn>> = v45 v34
            let _v35 = v46 
            #endif
#if FABLE_COMPILER_PYTHON
            let v47 : (Async<int64> -> Async<Choice<int64, exn>>) = Async.Catch
            let v48 : Async<Choice<int64, exn>> = v47 v34
            let _v35 = v48 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v49 : (Async<int64> -> Async<Choice<int64, exn>>) = Async.Catch
            let v50 : Async<Choice<int64, exn>> = v49 v34
            let _v35 = v50 
            #endif
#else
            let v51 : (Async<int64> -> Async<Choice<int64, exn>>) = Async.Catch
            let v52 : Async<Choice<int64, exn>> = v51 v34
            let _v35 = v52 
            #endif
            let v53 : Async<Choice<int64, exn>> = _v35 
            let v58 : Async<US9> = method57(v53)
            let v59 : Async<US10> = method60(v58)
            let v60 : Async<US2> = method61(v1, v59)
            return! v60 
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v383 : Async<US2> = _v12 
    let _v2 = v383 
    #endif
#if FABLE_COMPILER_PYTHON
    let v384 : unit = ()
    let _v384 =
        async {
            let v387 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v388 : Async<Async<int64>> = null |> unbox<Async<Async<int64>>>
            let _v387 = v388 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v391 : Async<Async<int64>> = null |> unbox<Async<Async<int64>>>
            let _v387 = v391 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v394 : Async<Async<int64>> = null |> unbox<Async<Async<int64>>>
            let _v387 = v394 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v397 : Async<Async<int64>> = Async.StartChild (v0, v1)
            let _v387 = v397 
            #endif
#if FABLE_COMPILER_PYTHON
            let v398 : Async<Async<int64>> = Async.StartChild (v0, v1)
            let _v387 = v398 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v399 : Async<Async<int64>> = Async.StartChild (v0, v1)
            let _v387 = v399 
            #endif
#else
            let v400 : Async<Async<int64>> = Async.StartChild (v0, v1)
            let _v387 = v400 
            #endif
            let v401 : Async<Async<int64>> = _v387 
            let! v401 = v401 
            let v406 : Async<int64> = v401 
            let v407 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v408 : Async<Choice<int64, exn>> = null |> unbox<Async<Choice<int64, exn>>>
            let _v407 = v408 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v411 : Async<Choice<int64, exn>> = null |> unbox<Async<Choice<int64, exn>>>
            let _v407 = v411 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v414 : Async<Choice<int64, exn>> = null |> unbox<Async<Choice<int64, exn>>>
            let _v407 = v414 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v417 : (Async<int64> -> Async<Choice<int64, exn>>) = Async.Catch
            let v418 : Async<Choice<int64, exn>> = v417 v406
            let _v407 = v418 
            #endif
#if FABLE_COMPILER_PYTHON
            let v419 : (Async<int64> -> Async<Choice<int64, exn>>) = Async.Catch
            let v420 : Async<Choice<int64, exn>> = v419 v406
            let _v407 = v420 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v421 : (Async<int64> -> Async<Choice<int64, exn>>) = Async.Catch
            let v422 : Async<Choice<int64, exn>> = v421 v406
            let _v407 = v422 
            #endif
#else
            let v423 : (Async<int64> -> Async<Choice<int64, exn>>) = Async.Catch
            let v424 : Async<Choice<int64, exn>> = v423 v406
            let _v407 = v424 
            #endif
            let v425 : Async<Choice<int64, exn>> = _v407 
            let v430 : Async<US9> = method57(v425)
            let v431 : Async<US10> = method60(v430)
            let v432 : Async<US2> = method61(v1, v431)
            return! v432 
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v755 : Async<US2> = _v384 
    let _v2 = v755 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v756 : unit = ()
    let _v756 =
        async {
            let v759 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v760 : Async<Async<int64>> = null |> unbox<Async<Async<int64>>>
            let _v759 = v760 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v763 : Async<Async<int64>> = null |> unbox<Async<Async<int64>>>
            let _v759 = v763 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v766 : Async<Async<int64>> = null |> unbox<Async<Async<int64>>>
            let _v759 = v766 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v769 : Async<Async<int64>> = Async.StartChild (v0, v1)
            let _v759 = v769 
            #endif
#if FABLE_COMPILER_PYTHON
            let v770 : Async<Async<int64>> = Async.StartChild (v0, v1)
            let _v759 = v770 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v771 : Async<Async<int64>> = Async.StartChild (v0, v1)
            let _v759 = v771 
            #endif
#else
            let v772 : Async<Async<int64>> = Async.StartChild (v0, v1)
            let _v759 = v772 
            #endif
            let v773 : Async<Async<int64>> = _v759 
            let! v773 = v773 
            let v778 : Async<int64> = v773 
            let v779 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v780 : Async<Choice<int64, exn>> = null |> unbox<Async<Choice<int64, exn>>>
            let _v779 = v780 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v783 : Async<Choice<int64, exn>> = null |> unbox<Async<Choice<int64, exn>>>
            let _v779 = v783 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v786 : Async<Choice<int64, exn>> = null |> unbox<Async<Choice<int64, exn>>>
            let _v779 = v786 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v789 : (Async<int64> -> Async<Choice<int64, exn>>) = Async.Catch
            let v790 : Async<Choice<int64, exn>> = v789 v778
            let _v779 = v790 
            #endif
#if FABLE_COMPILER_PYTHON
            let v791 : (Async<int64> -> Async<Choice<int64, exn>>) = Async.Catch
            let v792 : Async<Choice<int64, exn>> = v791 v778
            let _v779 = v792 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v793 : (Async<int64> -> Async<Choice<int64, exn>>) = Async.Catch
            let v794 : Async<Choice<int64, exn>> = v793 v778
            let _v779 = v794 
            #endif
#else
            let v795 : (Async<int64> -> Async<Choice<int64, exn>>) = Async.Catch
            let v796 : Async<Choice<int64, exn>> = v795 v778
            let _v779 = v796 
            #endif
            let v797 : Async<Choice<int64, exn>> = _v779 
            let v802 : Async<US9> = method57(v797)
            let v803 : Async<US10> = method60(v802)
            let v804 : Async<US2> = method61(v1, v803)
            return! v804 
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v1127 : Async<US2> = _v756 
    let _v2 = v1127 
    #endif
#else
    let v1128 : unit = ()
    let _v1128 =
        async {
            let v1131 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1132 : Async<Async<int64>> = null |> unbox<Async<Async<int64>>>
            let _v1131 = v1132 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1135 : Async<Async<int64>> = null |> unbox<Async<Async<int64>>>
            let _v1131 = v1135 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1138 : Async<Async<int64>> = null |> unbox<Async<Async<int64>>>
            let _v1131 = v1138 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1141 : Async<Async<int64>> = Async.StartChild (v0, v1)
            let _v1131 = v1141 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1142 : Async<Async<int64>> = Async.StartChild (v0, v1)
            let _v1131 = v1142 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1143 : Async<Async<int64>> = Async.StartChild (v0, v1)
            let _v1131 = v1143 
            #endif
#else
            let v1144 : Async<Async<int64>> = Async.StartChild (v0, v1)
            let _v1131 = v1144 
            #endif
            let v1145 : Async<Async<int64>> = _v1131 
            let! v1145 = v1145 
            let v1150 : Async<int64> = v1145 
            let v1151 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1152 : Async<Choice<int64, exn>> = null |> unbox<Async<Choice<int64, exn>>>
            let _v1151 = v1152 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1155 : Async<Choice<int64, exn>> = null |> unbox<Async<Choice<int64, exn>>>
            let _v1151 = v1155 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1158 : Async<Choice<int64, exn>> = null |> unbox<Async<Choice<int64, exn>>>
            let _v1151 = v1158 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1161 : (Async<int64> -> Async<Choice<int64, exn>>) = Async.Catch
            let v1162 : Async<Choice<int64, exn>> = v1161 v1150
            let _v1151 = v1162 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1163 : (Async<int64> -> Async<Choice<int64, exn>>) = Async.Catch
            let v1164 : Async<Choice<int64, exn>> = v1163 v1150
            let _v1151 = v1164 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1165 : (Async<int64> -> Async<Choice<int64, exn>>) = Async.Catch
            let v1166 : Async<Choice<int64, exn>> = v1165 v1150
            let _v1151 = v1166 
            #endif
#else
            let v1167 : (Async<int64> -> Async<Choice<int64, exn>>) = Async.Catch
            let v1168 : Async<Choice<int64, exn>> = v1167 v1150
            let _v1151 = v1168 
            #endif
            let v1169 : Async<Choice<int64, exn>> = _v1151 
            let v1174 : Async<US9> = method57(v1169)
            let v1175 : Async<US10> = method60(v1174)
            let v1176 : Async<US2> = method61(v1, v1175)
            return! v1176 
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v1499 : Async<US2> = _v1128 
    let _v2 = v1499 
    #endif
    let v1500 : Async<US2> = _v2 
    v1500
and method55 (v0 : int32, v1 : Async<int64>) : Async<US2> =
    let v2 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : Async<US2> = method56(v1, v0)
    let _v2 = v3 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v4 : Async<US2> = method56(v1, v0)
    let _v2 = v4 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v5 : Async<US2> = method56(v1, v0)
    let _v2 = v5 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v6 : Async<US2> = method56(v1, v0)
    let _v2 = v6 
    #endif
#if FABLE_COMPILER_PYTHON
    let v7 : Async<US2> = method56(v1, v0)
    let _v2 = v7 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v8 : Async<US2> = method56(v1, v0)
    let _v2 = v8 
    #endif
#else
    let v9 : Async<US2> = method56(v1, v0)
    let _v2 = v9 
    #endif
    let v10 : Async<US2> = _v2 
    v10
and method68 (v0 : Async<string>) : Async<string option> =
    let v1 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : Async<string option> = null |> unbox<Async<string option>>
    let _v1 = v2 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v5 : Async<string option> = null |> unbox<Async<string option>>
    let _v1 = v5 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v8 : Async<string option> = null |> unbox<Async<string option>>
    let _v1 = v8 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v11 : unit = ()
    let _v11 =
        async {
            let! v0 = v0 
            let v14 : string = v0 
            let v15 : string option = Some v14 
            return v15 
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v46 : Async<string option> = _v11 
    let _v1 = v46 
    #endif
#if FABLE_COMPILER_PYTHON
    let v47 : unit = ()
    let _v47 =
        async {
            let! v0 = v0 
            let v50 : string = v0 
            let v51 : string option = Some v50 
            return v51 
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v82 : Async<string option> = _v47 
    let _v1 = v82 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v83 : unit = ()
    let _v83 =
        async {
            let! v0 = v0 
            let v86 : string = v0 
            let v87 : string option = Some v86 
            return v87 
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v118 : Async<string option> = _v83 
    let _v1 = v118 
    #endif
#else
    let v119 : unit = ()
    let _v119 =
        async {
            let! v0 = v0 
            let v122 : string = v0 
            let v123 : string option = Some v122 
            return v123 
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v154 : Async<string option> = _v119 
    let _v1 = v154 
    #endif
    let v155 : Async<string option> = _v1 
    v155
and method70 (v0 : int64, v1 : string) : string =
    let v2 : string = method18()
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
and method69 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : int64, v9 : string) : string =
    let v10 : string = method70(v8, v9)
    let v11 : int64 = v0.l0
    let v12 : string = "file_system.read_all_text_retry_async"
    let v13 : string = $"{v6} {v7} #{v11} %s{v12} / {v10}"
    method23(v13)
and closure31 (v0 : int64, v1 : exn) () : unit =
    let v2 : US0 = US0_1
    let v3 : bool = method11(v2)
    if v3 then
        let v4 : unit = ()
        let v5 : (unit -> unit) = closure0()
        let v6 : unit = (fun () -> v5 (); v4) ()
        let struct (v20 : Mut0, v21 : Mut1, v22 : Mut2, v23 : Mut3, v24 : Mut4, v25 : int64 option) = TraceState.trace_state.Value
        let v38 : string = method12(v20, v21, v22, v23, v24, v25)
        let v39 : string = method16()
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
        let v65 : string = method69(v20, v21, v22, v23, v24, v25, v38, v39, v0, v60)
        method24(v65)
and method54 (v0 : string, v1 : int64) : Async<string option> =
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
                    let v16 : Async<int64> = method30(v0)
                    let v17 : int32 = 1000
                    let v18 : Async<US2> = method55(v17, v16)
                    let v19 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v20 : Async<unit> = null |> unbox<Async<unit>>
                    let _v19 = v20 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v23 : Async<unit> = null |> unbox<Async<unit>>
                    let _v19 = v23 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v26 : Async<unit> = null |> unbox<Async<unit>>
                    let _v19 = v26 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v29 : (Async<US2> -> Async<unit>) = Async.Ignore
                    let v30 : Async<unit> = v29 v18
                    let _v19 = v30 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v31 : (Async<US2> -> Async<unit>) = Async.Ignore
                    let v32 : Async<unit> = v31 v18
                    let _v19 = v32 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v33 : (Async<US2> -> Async<unit>) = Async.Ignore
                    let v34 : Async<unit> = v33 v18
                    let _v19 = v34 
                    #endif
#else
                    let v35 : (Async<US2> -> Async<unit>) = Async.Ignore
                    let v36 : Async<unit> = v35 v18
                    let _v19 = v36 
                    #endif
                    let v37 : Async<unit> = _v19 
                    do! v37 
                    ()
                let v42 : Async<string> = method31(v0)
                let v43 : Async<string option> = method68(v42)
                return! v43 
                (* indent
                ()
            indent *)
            with ex ->
                let v73 : exn = ex
                let v74 : bool = v1 = 0L
                let v75 : bool = v74 <> true
                if v75 then
                    let v76 : unit = ()
                    let v77 : (unit -> unit) = closure31(v1, v73)
                    let v78 : unit = (fun () -> v77 (); v76) ()
                    let v143 : string option = None
                    return v143 
                    (* fix_condition then
                    ()
                else
                    fix_condition then *) else
                    let v144 : int64 = v1 + 1L
                    let v145 : Async<string option> = method53(v0, v144)
                    return! v145 
                    (* fix_condition else
                    ()
                fix_condition else *)
                (* indent
                ()
            indent *)
            (* try_unit
            let v219 : string option = try_unit *)
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v1671 : Async<string option> = _v12 
    let _v2 = v1671 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1672 : unit = ()
    let _v1672 =
        async {
            try
                let v1675 : bool = v1 > 0L
                if v1675 then
                    let v1676 : Async<int64> = method30(v0)
                    let v1677 : int32 = 1000
                    let v1678 : Async<US2> = method55(v1677, v1676)
                    let v1679 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1680 : Async<unit> = null |> unbox<Async<unit>>
                    let _v1679 = v1680 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v1683 : Async<unit> = null |> unbox<Async<unit>>
                    let _v1679 = v1683 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1686 : Async<unit> = null |> unbox<Async<unit>>
                    let _v1679 = v1686 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v1689 : (Async<US2> -> Async<unit>) = Async.Ignore
                    let v1690 : Async<unit> = v1689 v1678
                    let _v1679 = v1690 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v1691 : (Async<US2> -> Async<unit>) = Async.Ignore
                    let v1692 : Async<unit> = v1691 v1678
                    let _v1679 = v1692 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v1693 : (Async<US2> -> Async<unit>) = Async.Ignore
                    let v1694 : Async<unit> = v1693 v1678
                    let _v1679 = v1694 
                    #endif
#else
                    let v1695 : (Async<US2> -> Async<unit>) = Async.Ignore
                    let v1696 : Async<unit> = v1695 v1678
                    let _v1679 = v1696 
                    #endif
                    let v1697 : Async<unit> = _v1679 
                    do! v1697 
                    ()
                let v1702 : Async<string> = method31(v0)
                let v1703 : Async<string option> = method68(v1702)
                return! v1703 
                (* indent
                ()
            indent *)
            with ex ->
                let v1733 : exn = ex
                let v1734 : bool = v1 = 0L
                let v1735 : bool = v1734 <> true
                if v1735 then
                    let v1736 : unit = ()
                    let v1737 : (unit -> unit) = closure31(v1, v1733)
                    let v1738 : unit = (fun () -> v1737 (); v1736) ()
                    let v1803 : string option = None
                    return v1803 
                    (* fix_condition then
                    ()
                else
                    fix_condition then *) else
                    let v1804 : int64 = v1 + 1L
                    let v1805 : Async<string option> = method53(v0, v1804)
                    return! v1805 
                    (* fix_condition else
                    ()
                fix_condition else *)
                (* indent
                ()
            indent *)
            (* try_unit
            let v1879 : string option = try_unit *)
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v3331 : Async<string option> = _v1672 
    let _v2 = v3331 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v3332 : unit = ()
    let _v3332 =
        async {
            try
                let v3335 : bool = v1 > 0L
                if v3335 then
                    let v3336 : Async<int64> = method30(v0)
                    let v3337 : int32 = 1000
                    let v3338 : Async<US2> = method55(v3337, v3336)
                    let v3339 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v3340 : Async<unit> = null |> unbox<Async<unit>>
                    let _v3339 = v3340 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v3343 : Async<unit> = null |> unbox<Async<unit>>
                    let _v3339 = v3343 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v3346 : Async<unit> = null |> unbox<Async<unit>>
                    let _v3339 = v3346 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v3349 : (Async<US2> -> Async<unit>) = Async.Ignore
                    let v3350 : Async<unit> = v3349 v3338
                    let _v3339 = v3350 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v3351 : (Async<US2> -> Async<unit>) = Async.Ignore
                    let v3352 : Async<unit> = v3351 v3338
                    let _v3339 = v3352 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v3353 : (Async<US2> -> Async<unit>) = Async.Ignore
                    let v3354 : Async<unit> = v3353 v3338
                    let _v3339 = v3354 
                    #endif
#else
                    let v3355 : (Async<US2> -> Async<unit>) = Async.Ignore
                    let v3356 : Async<unit> = v3355 v3338
                    let _v3339 = v3356 
                    #endif
                    let v3357 : Async<unit> = _v3339 
                    do! v3357 
                    ()
                let v3362 : Async<string> = method31(v0)
                let v3363 : Async<string option> = method68(v3362)
                return! v3363 
                (* indent
                ()
            indent *)
            with ex ->
                let v3393 : exn = ex
                let v3394 : bool = v1 = 0L
                let v3395 : bool = v3394 <> true
                if v3395 then
                    let v3396 : unit = ()
                    let v3397 : (unit -> unit) = closure31(v1, v3393)
                    let v3398 : unit = (fun () -> v3397 (); v3396) ()
                    let v3463 : string option = None
                    return v3463 
                    (* fix_condition then
                    ()
                else
                    fix_condition then *) else
                    let v3464 : int64 = v1 + 1L
                    let v3465 : Async<string option> = method53(v0, v3464)
                    return! v3465 
                    (* fix_condition else
                    ()
                fix_condition else *)
                (* indent
                ()
            indent *)
            (* try_unit
            let v3539 : string option = try_unit *)
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v4991 : Async<string option> = _v3332 
    let _v2 = v4991 
    #endif
#else
    let v4992 : unit = ()
    let _v4992 =
        async {
            try
                let v4995 : bool = v1 > 0L
                if v4995 then
                    let v4996 : Async<int64> = method30(v0)
                    let v4997 : int32 = 1000
                    let v4998 : Async<US2> = method55(v4997, v4996)
                    let v4999 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v5000 : Async<unit> = null |> unbox<Async<unit>>
                    let _v4999 = v5000 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v5003 : Async<unit> = null |> unbox<Async<unit>>
                    let _v4999 = v5003 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v5006 : Async<unit> = null |> unbox<Async<unit>>
                    let _v4999 = v5006 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v5009 : (Async<US2> -> Async<unit>) = Async.Ignore
                    let v5010 : Async<unit> = v5009 v4998
                    let _v4999 = v5010 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v5011 : (Async<US2> -> Async<unit>) = Async.Ignore
                    let v5012 : Async<unit> = v5011 v4998
                    let _v4999 = v5012 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v5013 : (Async<US2> -> Async<unit>) = Async.Ignore
                    let v5014 : Async<unit> = v5013 v4998
                    let _v4999 = v5014 
                    #endif
#else
                    let v5015 : (Async<US2> -> Async<unit>) = Async.Ignore
                    let v5016 : Async<unit> = v5015 v4998
                    let _v4999 = v5016 
                    #endif
                    let v5017 : Async<unit> = _v4999 
                    do! v5017 
                    ()
                let v5022 : Async<string> = method31(v0)
                let v5023 : Async<string option> = method68(v5022)
                return! v5023 
                (* indent
                ()
            indent *)
            with ex ->
                let v5053 : exn = ex
                let v5054 : bool = v1 = 0L
                let v5055 : bool = v5054 <> true
                if v5055 then
                    let v5056 : unit = ()
                    let v5057 : (unit -> unit) = closure31(v1, v5053)
                    let v5058 : unit = (fun () -> v5057 (); v5056) ()
                    let v5123 : string option = None
                    return v5123 
                    (* fix_condition then
                    ()
                else
                    fix_condition then *) else
                    let v5124 : int64 = v1 + 1L
                    let v5125 : Async<string option> = method53(v0, v5124)
                    return! v5125 
                    (* fix_condition else
                    ()
                fix_condition else *)
                (* indent
                ()
            indent *)
            (* try_unit
            let v5199 : string option = try_unit *)
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v6651 : Async<string option> = _v4992 
    let _v2 = v6651 
    #endif
    let v6652 : Async<string option> = _v2 
    v6652
and method53 (v0 : string, v1 : int64) : Async<string option> =
    method54(v0, v1)
and method52 (v0 : string) : Async<string option> =
    let v1 : int64 = 0L
    method53(v0, v1)
and closure26 () (v0 : string) : Async<string option> =
    method52(v0)
and closure33 () (v0 : chrono_DateTime<chrono_Utc>) : US11 =
    US11_0(v0)
and method73 () : (chrono_DateTime<chrono_Utc> -> US11) =
    closure33()
and method74 () : string =
    let v0 : string = "hh:mm"
    v0
and method75 () : string =
    let v0 : string = "yyyyMMdd-HHmm-ssff-ffff-f"
    v0
and method76 () : string =
    let v0 : string = "hhmm"
    v0
and method72 (v0 : System.Guid, v1 : System.DateTime) : System.Guid =
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
    let v94 : (chrono_DateTime<chrono_Utc> -> US11) = method73()
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
    let v313 : string = method74()
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
    let v487 : (chrono_DateTime<chrono_Utc> -> US11) = method73()
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
    let v706 : string = method74()
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
    let v792 : string = method75()
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
    let v992 : string = method76()
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
    let v1075 : string = method75()
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
    let v1275 : string = method76()
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
    let v1358 : string = method75()
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
    let v1558 : string = method76()
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
    let v1641 : string = method75()
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
    let v1841 : string = method76()
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
and method78 () : string =
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
and method79 () : string =
    let v0 : string = "!create_temp_path_"
    v0
and method80 (v0 : string, v1 : string) : string =
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
and method82 () : string =
    let v0 : string = "CARGO_PKG_NAME"
    v0
and method81 () : string =
    let v0 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1 : string = method82()
    let v2 : string = method2(v1)
    let _v0 = v2 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v3 : string = method82()
    let v4 : string = method2(v3)
    let _v0 = v4 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v5 : string = method82()
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
and method77 (v0 : System.Guid) : string =
    let v1 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = method78()
    let v3 : string = method79()
    let v4 : string = method80(v2, v3)
    let v5 : string = method81()
    let v6 : string = method80(v4, v5)
    let v7 : (System.Guid -> string) = _.ToString()
    let v8 : string = v7 v0
    let v11 : string = method80(v6, v8)
    let _v1 = v11 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v12 : string = method78()
    let v13 : string = method79()
    let v14 : string = method80(v12, v13)
    let v15 : string = method81()
    let v16 : string = method80(v14, v15)
    let v17 : (System.Guid -> string) = _.ToString()
    let v18 : string = v17 v0
    let v21 : string = method80(v16, v18)
    let _v1 = v21 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v22 : string = null |> unbox<string>
    let _v1 = v22 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v25 : string = method78()
    let v26 : string = method79()
    let v27 : string = method80(v25, v26)
    let v28 : string = method81()
    let v29 : string = method80(v27, v28)
    let v30 : (System.Guid -> string) = _.ToString()
    let v31 : string = v30 v0
    let v34 : string = method80(v29, v31)
    let _v1 = v34 
    #endif
#if FABLE_COMPILER_PYTHON
    let v35 : string = method78()
    let v36 : string = method79()
    let v37 : string = method80(v35, v36)
    let v38 : string = method81()
    let v39 : string = method80(v37, v38)
    let v40 : (System.Guid -> string) = _.ToString()
    let v41 : string = v40 v0
    let v44 : string = method80(v39, v41)
    let _v1 = v44 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v45 : string = method78()
    let v46 : string = method79()
    let v47 : string = method80(v45, v46)
    let v48 : string = method81()
    let v49 : string = method80(v47, v48)
    let v50 : (System.Guid -> string) = _.ToString()
    let v51 : string = v50 v0
    let v54 : string = method80(v49, v51)
    let _v1 = v54 
    #endif
#else
    let v55 : string = method78()
    let v56 : string = method79()
    let v57 : string = method80(v55, v56)
    let v58 : string = method81()
    let v59 : string = method80(v57, v58)
    let v60 : (System.Guid -> string) = _.ToString()
    let v61 : string = v60 v0
    let v64 : string = method80(v59, v61)
    let _v1 = v64 
    #endif
    let v65 : string = _v1 
    v65
and method71 () : string =
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
    let v20 : System.Guid = method72(v17, v11)
    let v21 : string = method77(v20)
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
    let v41 : System.Guid = method72(v38, v32)
    let v42 : string = method77(v41)
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
    let v65 : System.Guid = method72(v62, v56)
    let v66 : string = method77(v65)
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
    let v86 : System.Guid = method72(v83, v77)
    let v87 : string = method77(v86)
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
    let v107 : System.Guid = method72(v104, v98)
    let v108 : string = method77(v107)
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
    let v128 : System.Guid = method72(v125, v119)
    let v129 : string = method77(v128)
    let _v0 = v129 
    #endif
    let v130 : string = _v0 
    v130
and closure32 () () : string =
    method71()
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
and method84 () : (std_io_Error -> std_string_String) =
    closure35()
and closure36 () () : US12 =
    US12_0
and method85 () : (unit -> US12) =
    closure36()
and closure37 () (v0 : std_string_String) : US12 =
    US12_1(v0)
and method86 () : (std_string_String -> US12) =
    closure37()
and method88 (v0 : string, v1 : std_string_String) : string =
    let v2 : string = method18()
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
and method87 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : string, v9 : std_string_String) : string =
    let v10 : string = method88(v8, v9)
    let v11 : int64 = v0.l0
    let v12 : string = "file_system.create_dir"
    let v13 : string = $"{v6} {v7} #{v11} %s{v12} / {v10}"
    method23(v13)
and closure38 (v0 : string, v1 : std_string_String) () : unit =
    let v2 : US0 = US0_4
    let v3 : bool = method11(v2)
    if v3 then
        let v4 : unit = ()
        let v5 : (unit -> unit) = closure0()
        let v6 : unit = (fun () -> v5 (); v4) ()
        let struct (v20 : Mut0, v21 : Mut1, v22 : Mut2, v23 : Mut3, v24 : Mut4, v25 : int64 option) = TraceState.trace_state.Value
        let v38 : string = method12(v20, v21, v22, v23, v24, v25)
        let v39 : string = method65()
        let v40 : string = method87(v20, v21, v22, v23, v24, v25, v38, v39, v0, v1)
        method24(v40)
and method90 (v0 : string) : string =
    let v1 : string = method18()
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
and method89 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : string) : string =
    let v9 : string = method90(v8)
    let v10 : int64 = v0.l0
    let v11 : string = "file_system.create_dir"
    let v12 : string = $"{v6} {v7} #{v10} %s{v11} / {v9}"
    method23(v12)
and closure39 (v0 : string) () : unit =
    let v1 : US0 = US0_0
    let v2 : bool = method11(v1)
    if v2 then
        let v3 : unit = ()
        let v4 : (unit -> unit) = closure0()
        let v5 : unit = (fun () -> v4 (); v3) ()
        let struct (v19 : Mut0, v20 : Mut1, v21 : Mut2, v22 : Mut3, v23 : Mut4, v24 : int64 option) = TraceState.trace_state.Value
        let v37 : string = method12(v19, v20, v21, v22, v23, v24)
        let v38 : string = method62()
        let v39 : string = method89(v19, v20, v21, v22, v23, v24, v37, v38, v0)
        method24(v39)
and closure40 (v0 : string) () : unit =
    let v1 : bool = true
    method9(v1, v0)
and method91 (v0 : string) : (unit -> unit) =
    closure40(v0)
and method92 (v0 : string) : (unit -> unit) =
    closure40(v0)
and method93 (v0 : string) : System_IO_DirectoryInfo =
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
and method95 (v0 : string, v1 : string) : string =
    let v2 : string = method18()
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
and method94 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : string, v9 : string) : string =
    let v10 : string = method95(v8, v9)
    let v11 : int64 = v0.l0
    let v12 : string = "file_system.create_dir"
    let v13 : string = $"{v6} {v7} #{v11} %s{v12} / {v10}"
    method23(v13)
and closure41 (v0 : string, v1 : string) () : unit =
    let v2 : US0 = US0_1
    let v3 : bool = method11(v2)
    if v3 then
        let v4 : unit = ()
        let v5 : (unit -> unit) = closure0()
        let v6 : unit = (fun () -> v5 (); v4) ()
        let struct (v20 : Mut0, v21 : Mut1, v22 : Mut2, v23 : Mut3, v24 : Mut4, v25 : int64 option) = TraceState.trace_state.Value
        let v38 : string = method12(v20, v21, v22, v23, v24, v25)
        let v39 : string = method16()
        let v40 : string = method94(v20, v21, v22, v23, v24, v25, v38, v39, v0, v1)
        method24(v40)
and closure42 (v0 : string) () : unit =
    let v1 : Async<int64> = method6(v0)
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
    let v12 : (Async<int64> -> Async<unit>) = Async.Ignore
    let v13 : Async<unit> = v12 v1
    let _v2 = v13 
    #endif
#if FABLE_COMPILER_PYTHON
    let v14 : (Async<int64> -> Async<unit>) = Async.Ignore
    let v15 : Async<unit> = v14 v1
    let _v2 = v15 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v16 : (Async<int64> -> Async<unit>) = Async.Ignore
    let v17 : Async<unit> = v16 v1
    let _v2 = v17 
    #endif
#else
    let v18 : (Async<int64> -> Async<unit>) = Async.Ignore
    let v19 : Async<unit> = v18 v1
    let _v2 = v19 
    #endif
    let v20 : Async<unit> = _v2 
    let v25 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    null |> unbox<unit>
    #endif
#if FABLE_COMPILER_RUST && WASM
    null |> unbox<unit>
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    null |> unbox<unit>
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    null |> unbox<unit>
    #endif
#if FABLE_COMPILER_PYTHON
    let v26 : (Async<unit> -> unit) = Async.RunSynchronously
    v26 v20
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v27 : (Async<unit> -> unit) = Async.RunSynchronously
    v27 v20
    #endif
#else
    let v28 : (Async<unit> -> unit) = Async.RunSynchronously
    v28 v20
    #endif
    // run_target_args' is_unit
    ()
and method96 (v0 : string) : (unit -> unit) =
    closure42(v0)
and method97 (v0 : string) : (unit -> unit) =
    closure42(v0)
and method83 (v0 : string) : System.IDisposable =
    let v1 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = "std::fs::create_dir_all(&*$0)"
    let v3 : Result<unit, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v0 v2 
    let v4 : (std_io_Error -> std_string_String) = method84()
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
    let v19 : (unit -> US12) = method85()
    let v20 : (std_string_String -> US12) = method86()
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
    let v108 : (unit -> unit) = method91(v0)
    let v109 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v108 "$0()" )
    let _v107 = v109 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v110 : (unit -> unit) = method91(v0)
    let v111 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v110 "$0()" )
    let _v107 = v111 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v112 : (unit -> unit) = method91(v0)
    let v113 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v112 "$0()" )
    let _v107 = v113 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v114 : (unit -> unit) = method92(v0)
    let v115 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v114 () }
    let _v107 = v115 
    #endif
#if FABLE_COMPILER_PYTHON
    let v116 : (unit -> unit) = method92(v0)
    let v117 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v116 () }
    let _v107 = v117 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v118 : (unit -> unit) = method92(v0)
    let v119 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v118 () }
    let _v107 = v119 
    #endif
#else
    let v120 : (unit -> unit) = method92(v0)
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
    let v132 : System_IO_DirectoryInfo = method93(v0)
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
    let v233 : (unit -> unit) = method96(v0)
    let v234 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v233 "$0()" )
    let _v232 = v234 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v235 : (unit -> unit) = method96(v0)
    let v236 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v235 "$0()" )
    let _v232 = v236 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v237 : (unit -> unit) = method96(v0)
    let v238 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v237 "$0()" )
    let _v232 = v238 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v239 : (unit -> unit) = method97(v0)
    let v240 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v239 () }
    let _v232 = v240 
    #endif
#if FABLE_COMPILER_PYTHON
    let v241 : (unit -> unit) = method97(v0)
    let v242 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v241 () }
    let _v232 = v242 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v243 : (unit -> unit) = method97(v0)
    let v244 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v243 () }
    let _v232 = v244 
    #endif
#else
    let v245 : (unit -> unit) = method97(v0)
    let v246 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v245 () }
    let _v232 = v246 
    #endif
    let v247 : System.IDisposable = _v232 
    let _v1 = v247 
    #endif
#if FABLE_COMPILER_PYTHON
    let v251 : System_IO_DirectoryInfo = method93(v0)
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
    let v352 : (unit -> unit) = method96(v0)
    let v353 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v352 "$0()" )
    let _v351 = v353 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v354 : (unit -> unit) = method96(v0)
    let v355 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v354 "$0()" )
    let _v351 = v355 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v356 : (unit -> unit) = method96(v0)
    let v357 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v356 "$0()" )
    let _v351 = v357 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v358 : (unit -> unit) = method97(v0)
    let v359 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v358 () }
    let _v351 = v359 
    #endif
#if FABLE_COMPILER_PYTHON
    let v360 : (unit -> unit) = method97(v0)
    let v361 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v360 () }
    let _v351 = v361 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v362 : (unit -> unit) = method97(v0)
    let v363 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v362 () }
    let _v351 = v363 
    #endif
#else
    let v364 : (unit -> unit) = method97(v0)
    let v365 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v364 () }
    let _v351 = v365 
    #endif
    let v366 : System.IDisposable = _v351 
    let _v1 = v366 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v370 : System_IO_DirectoryInfo = method93(v0)
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
    let v471 : (unit -> unit) = method96(v0)
    let v472 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v471 "$0()" )
    let _v470 = v472 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v473 : (unit -> unit) = method96(v0)
    let v474 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v473 "$0()" )
    let _v470 = v474 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v475 : (unit -> unit) = method96(v0)
    let v476 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v475 "$0()" )
    let _v470 = v476 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v477 : (unit -> unit) = method97(v0)
    let v478 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v477 () }
    let _v470 = v478 
    #endif
#if FABLE_COMPILER_PYTHON
    let v479 : (unit -> unit) = method97(v0)
    let v480 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v479 () }
    let _v470 = v480 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v481 : (unit -> unit) = method97(v0)
    let v482 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v481 () }
    let _v470 = v482 
    #endif
#else
    let v483 : (unit -> unit) = method97(v0)
    let v484 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v483 () }
    let _v470 = v484 
    #endif
    let v485 : System.IDisposable = _v470 
    let _v1 = v485 
    #endif
#else
    let v489 : System_IO_DirectoryInfo = method93(v0)
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
    let v590 : (unit -> unit) = method96(v0)
    let v591 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v590 "$0()" )
    let _v589 = v591 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v592 : (unit -> unit) = method96(v0)
    let v593 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v592 "$0()" )
    let _v589 = v593 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v594 : (unit -> unit) = method96(v0)
    let v595 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v594 "$0()" )
    let _v589 = v595 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v596 : (unit -> unit) = method97(v0)
    let v597 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v596 () }
    let _v589 = v597 
    #endif
#if FABLE_COMPILER_PYTHON
    let v598 : (unit -> unit) = method97(v0)
    let v599 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v598 () }
    let _v589 = v599 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v600 : (unit -> unit) = method97(v0)
    let v601 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v600 () }
    let _v589 = v601 
    #endif
#else
    let v602 : (unit -> unit) = method97(v0)
    let v603 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v602 () }
    let _v589 = v603 
    #endif
    let v604 : System.IDisposable = _v589 
    let _v1 = v604 
    #endif
    let v608 : System.IDisposable = _v1 
    v608
and closure34 () () : struct (string * System.IDisposable) =
    let v0 : string = method71()
    let v1 : System.IDisposable = method83(v0)
    struct (v0, v1)
and method98 (v0 : string) : System.Guid =
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
    let v1 : System.Guid = method98(v0)
    let v2 : string = method77(v1)
    let v3 : System.IDisposable = method83(v2)
    struct (v2, v3)
and closure44 () () : string =
    let v0 : string = __SOURCE_DIRECTORY__
    v0
and method103 (v0 : std_io_Error) : string =
    let v1 : string = method18()
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
    method103(v0)
and method102 () : (std_io_Error -> string) =
    closure46()
and closure47 () (v0 : std_path_PathBuf) : US13 =
    US13_0(v0)
and method104 () : (std_path_PathBuf -> US13) =
    closure47()
and closure48 () (v0 : string) : US13 =
    US13_1(v0)
and method105 () : (string -> US13) =
    closure48()
and method108 (v0 : string) : string option =
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
and method109 (v0 : string) : string =
    let v1 : string = method18()
    let v2 : Mut3 = {l0 = v1} : Mut3
    let v3 : string = $"{v0}"
    let v6 : unit = ()
    let v7 : (unit -> unit) = closure6(v2, v3)
    let v8 : unit = (fun () -> v7 (); v6) ()
    let v11 : string = v2.l0
    v11
and method107 (v0 : string, v1 : (uint8 -> (string -> Result<std_path_PathBuf, std_io_Error>)), v2 : uint8, v3 : string, v4 : string) : Result<std_path_PathBuf, std_io_Error> =
    let v5 : string = method20(v4)
    let v6 : string option = method108(v4)
    let v7 : (string -> US5) = method5()
    let v8 : US5 option = v6 |> Option.map v7 
    let v19 : US5 = US5_1
    let v20 : US5 = v8 |> Option.defaultValue v19 
    let v24 : string = method109(v3)
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
                let v73 : (std_io_Error -> string) = method102()
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
                let v88 : (std_path_PathBuf -> US13) = method104()
                let v89 : (string -> US13) = method105()
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
                    let v119 : string = method80(v116, v5)
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
and method106 (v0 : string, v1 : uint8, v2 : string) : Result<std_path_PathBuf, std_io_Error> =
    let v3 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v4 : string = "std::fs::read_link(&*$0)"
    let v5 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v2 v4 
    let v6 : (std_io_Error -> string) = method102()
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
    let v21 : (std_path_PathBuf -> US13) = method104()
    let v22 : (string -> US13) = method105()
    let v23 : US13 = match v18 with Ok x -> v21 x | Error x -> v22 x
    let v43 : Result<std_path_PathBuf, std_io_Error> =
        match v23 with
        | US13_1(v39) -> (* Error *)
            let v40 : (uint8 -> (string -> Result<std_path_PathBuf, std_io_Error>)) = closure49(v0)
            method107(v0, v40, v1, v39, v2)
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
    let v46 : (std_io_Error -> string) = method102()
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
    let v61 : (std_path_PathBuf -> US13) = method104()
    let v62 : (string -> US13) = method105()
    let v63 : US13 = match v58 with Ok x -> v61 x | Error x -> v62 x
    let v83 : Result<std_path_PathBuf, std_io_Error> =
        match v63 with
        | US13_1(v79) -> (* Error *)
            let v80 : (uint8 -> (string -> Result<std_path_PathBuf, std_io_Error>)) = closure49(v0)
            method107(v0, v80, v1, v79, v2)
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
    let v86 : (std_io_Error -> string) = method102()
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
    let v101 : (std_path_PathBuf -> US13) = method104()
    let v102 : (string -> US13) = method105()
    let v103 : US13 = match v98 with Ok x -> v101 x | Error x -> v102 x
    let v123 : Result<std_path_PathBuf, std_io_Error> =
        match v103 with
        | US13_1(v119) -> (* Error *)
            let v120 : (uint8 -> (string -> Result<std_path_PathBuf, std_io_Error>)) = closure49(v0)
            method107(v0, v120, v1, v119, v2)
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
    method106(v0, v1, v2)
and closure49 (v0 : string) (v1 : uint8) : (string -> Result<std_path_PathBuf, std_io_Error>) =
    closure50(v0, v1)
and method110 (v0 : string, v1 : (uint8 -> (string -> Result<std_path_PathBuf, std_io_Error>)), v2 : uint8, v3 : string) : Result<std_path_PathBuf, std_io_Error> =
    let v4 : string = method20(v0)
    let v5 : string option = method108(v0)
    let v6 : (string -> US5) = method5()
    let v7 : US5 option = v5 |> Option.map v6 
    let v18 : US5 = US5_1
    let v19 : US5 = v7 |> Option.defaultValue v18 
    let v23 : string = method109(v3)
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
                let v72 : (std_io_Error -> string) = method102()
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
                let v87 : (std_path_PathBuf -> US13) = method104()
                let v88 : (string -> US13) = method105()
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
                    let v118 : string = method80(v115, v4)
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
and method101 (v0 : string, v1 : uint8) : Result<std_path_PathBuf, std_io_Error> =
    let v2 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : string = "std::fs::read_link(&*$0)"
    let v4 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v0 v3 
    let v5 : (std_io_Error -> string) = method102()
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
    let v20 : (std_path_PathBuf -> US13) = method104()
    let v21 : (string -> US13) = method105()
    let v22 : US13 = match v17 with Ok x -> v20 x | Error x -> v21 x
    let v42 : Result<std_path_PathBuf, std_io_Error> =
        match v22 with
        | US13_1(v38) -> (* Error *)
            let v39 : (uint8 -> (string -> Result<std_path_PathBuf, std_io_Error>)) = closure49(v0)
            method110(v0, v39, v1, v38)
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
    let v45 : (std_io_Error -> string) = method102()
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
    let v60 : (std_path_PathBuf -> US13) = method104()
    let v61 : (string -> US13) = method105()
    let v62 : US13 = match v57 with Ok x -> v60 x | Error x -> v61 x
    let v82 : Result<std_path_PathBuf, std_io_Error> =
        match v62 with
        | US13_1(v78) -> (* Error *)
            let v79 : (uint8 -> (string -> Result<std_path_PathBuf, std_io_Error>)) = closure49(v0)
            method110(v0, v79, v1, v78)
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
    let v85 : (std_io_Error -> string) = method102()
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
    let v100 : (std_path_PathBuf -> US13) = method104()
    let v101 : (string -> US13) = method105()
    let v102 : US13 = match v97 with Ok x -> v100 x | Error x -> v101 x
    let v122 : Result<std_path_PathBuf, std_io_Error> =
        match v102 with
        | US13_1(v118) -> (* Error *)
            let v119 : (uint8 -> (string -> Result<std_path_PathBuf, std_io_Error>)) = closure49(v0)
            method110(v0, v119, v1, v118)
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
and method112 (v0 : System_IO_DirectoryInfo) : System.IO.FileAttributes =
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
and method113 () : System.IO.FileAttributes =
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
and method114 (v0 : System.IO.FileAttributes, v1 : System.IO.FileAttributes) : bool =
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
and method116 (v0 : string, v1 : (uint8 -> (string -> Result<std_path_PathBuf, std_io_Error>)), v2 : uint8, v3 : std_io_Error, v4 : string) : Result<std_path_PathBuf, std_io_Error> =
    let v5 : string = method20(v4)
    let v6 : string option = method108(v4)
    let v7 : (string -> US5) = method5()
    let v8 : US5 option = v6 |> Option.map v7 
    let v19 : US5 = US5_1
    let v20 : US5 = v8 |> Option.defaultValue v19 
    let v24 : string = method103(v3)
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
                let v73 : (std_io_Error -> string) = method102()
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
                let v88 : (std_path_PathBuf -> US13) = method104()
                let v89 : (string -> US13) = method105()
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
                    let v119 : string = method80(v116, v5)
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
and method115 (v0 : string, v1 : uint8, v2 : string) : Result<std_path_PathBuf, std_io_Error> =
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
    let v30 : System.IO.FileAttributes = method112(v25)
    let v31 : System.IO.FileAttributes = method113()
    let v32 : bool = method114(v31, v30)
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
        method116(v0, v128, v1, v123, v2)
and closure52 (v0 : string, v1 : uint8) (v2 : string) : Result<std_path_PathBuf, std_io_Error> =
    method115(v0, v1, v2)
and closure51 (v0 : string) (v1 : uint8) : (string -> Result<std_path_PathBuf, std_io_Error>) =
    closure52(v0, v1)
and method117 (v0 : string, v1 : (uint8 -> (string -> Result<std_path_PathBuf, std_io_Error>)), v2 : uint8, v3 : std_io_Error) : Result<std_path_PathBuf, std_io_Error> =
    let v4 : string = method20(v0)
    let v5 : string option = method108(v0)
    let v6 : (string -> US5) = method5()
    let v7 : US5 option = v5 |> Option.map v6 
    let v18 : US5 = US5_1
    let v19 : US5 = v7 |> Option.defaultValue v18 
    let v23 : string = method103(v3)
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
                let v72 : (std_io_Error -> string) = method102()
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
                let v87 : (std_path_PathBuf -> US13) = method104()
                let v88 : (string -> US13) = method105()
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
                    let v118 : string = method80(v115, v4)
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
and method111 (v0 : string, v1 : uint8) : Result<std_path_PathBuf, std_io_Error> =
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
    let v29 : System.IO.FileAttributes = method112(v24)
    let v30 : System.IO.FileAttributes = method113()
    let v31 : bool = method114(v30, v29)
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
        method117(v0, v127, v1, v122)
and method100 (v0 : string) : Result<std_path_PathBuf, std_io_Error> =
    let v1 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : bool = method10(v0)
    let v7 : Result<std_path_PathBuf, std_io_Error> =
        if v2 then
            let v3 : string = "std::fs::read_link(&*$0)"
            let v4 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v0 v3 
            v4
        else
            let v5 : uint8 = 0uy
            method101(v0, v5)
    let _v1 = v7 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v8 : bool = method10(v0)
    let v13 : Result<std_path_PathBuf, std_io_Error> =
        if v8 then
            let v9 : string = "std::fs::read_link(&*$0)"
            let v10 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v0 v9 
            v10
        else
            let v11 : uint8 = 0uy
            method101(v0, v11)
    let _v1 = v13 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v14 : bool = method10(v0)
    let v19 : Result<std_path_PathBuf, std_io_Error> =
        if v14 then
            let v15 : string = "std::fs::read_link(&*$0)"
            let v16 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v0 v15 
            v16
        else
            let v17 : uint8 = 0uy
            method101(v0, v17)
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
    let v25 : Result<std_path_PathBuf, std_io_Error> = method111(v0, v24)
    let _v1 = v25 
    #endif
#else
    let v26 : uint8 = 0uy
    let v27 : Result<std_path_PathBuf, std_io_Error> = method111(v0, v26)
    let _v1 = v27 
    #endif
    let v28 : Result<std_path_PathBuf, std_io_Error> = _v1 
    v28
and closure53 () (v0 : std_path_PathBuf) : US14 =
    US14_0(v0)
and method118 () : (std_path_PathBuf -> US14) =
    closure53()
and method120 (v0 : string) : string =
    v0
and method119 (v0 : string, v1 : string, v2 : string) : string =
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
    let v20 : string = method120(v2)
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
and method99 (v0 : string) : string =
    let v1 : bool = v0 = ""
    if v1 then
        let v2 : string = ""
        v2
    else
        let v3 : Result<std_path_PathBuf, std_io_Error> = method100(v0)
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
        let v18 : (std_path_PathBuf -> US14) = method118()
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
            let v71 : string = method119(v69, v70, v66)
            let v72 : string = $"{v71.[0] |> string |> _.ToLower()}{v71.[1..]}"
            let v73 : string = "\\"
            let v74 : string = "/"
            let v75 : string = v72.Replace (v73, v74)
            v75
and closure45 () (v0 : string) : string =
    method99(v0)
and closure54 () (v0 : string) : string =
    let v1 : char list = []
    let v2 : char list = '/' :: v1 
    let v5 : (char list -> (char [])) = List.toArray
    let v6 : (char []) = v5 v2
    let v9 : string = v0.TrimStart v6 
    let v33 : string = $"file:///{v9}"
    v33
and method122 (v0 : string, v1 : string, v2 : string) : US15 =
    let v3 : string = method80(v2, v0)
    let v4 : bool = method10(v3)
    if v4 then
        US15_0(v2)
    else
        let v6 : string option = method108(v2)
        let v7 : (string -> US5) = method5()
        let v8 : US5 option = v6 |> Option.map v7 
        let v19 : US5 = US5_1
        let v20 : US5 = v8 |> Option.defaultValue v19 
        match v20 with
        | US5_1 -> (* None *)
            let v26 : string = $"""No parent for {if false then "file" else "dir"} '{v0}' at '{v1}' (until '{v2}')"""
            US15_1(v26)
        | US5_0(v24) -> (* Some *)
            method122(v0, v1, v24)
and method121 (v0 : string, v1 : string) : US15 =
    let v2 : string = method80(v1, v0)
    let v3 : bool = method10(v2)
    if v3 then
        US15_0(v1)
    else
        let v5 : string option = method108(v1)
        let v6 : (string -> US5) = method5()
        let v7 : US5 option = v5 |> Option.map v6 
        let v18 : US5 = US5_1
        let v19 : US5 = v7 |> Option.defaultValue v18 
        match v19 with
        | US5_1 -> (* None *)
            let v25 : string = $"""No parent for {if false then "file" else "dir"} '{v0}' at '{v1}' (until '{v1}')"""
            US15_1(v25)
        | US5_0(v23) -> (* Some *)
            method122(v0, v1, v23)
and method124 (v0 : string) : string =
    let v1 : string = method18()
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
and method123 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : string) : string =
    let v9 : string = method124(v8)
    let v10 : int64 = v0.l0
    let v11 : string = "file_system.get_workspace_root"
    let v12 : string = $"{v6} {v7} #{v10} %s{v11} / {v9}"
    method23(v12)
and closure56 (v0 : string) () : unit =
    let v1 : US0 = US0_3
    let v2 : bool = method11(v1)
    if v2 then
        let v3 : unit = ()
        let v4 : (unit -> unit) = closure0()
        let v5 : unit = (fun () -> v4 (); v3) ()
        let struct (v19 : Mut0, v20 : Mut1, v21 : Mut2, v22 : Mut3, v23 : Mut4, v24 : int64 option) = TraceState.trace_state.Value
        let v37 : string = method12(v19, v20, v21, v22, v23, v24)
        let v38 : string = method43()
        let v39 : string = method123(v19, v20, v21, v22, v23, v24, v37, v38, v0)
        method24(v39)
and method125 () : string =
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
    let v3 : string = method80(v1, v2)
    let v4 : US15 = method121(v3, v0)
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
            let v55 : string = method125()
            let v56 : string = method80(v1, v2)
            let v57 : US15 = method121(v56, v55)
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
    method80(v111, v1)
and closure59 (v0 : exn) () : exn =
    v0
and method126 (v0 : string) : unit =
    let v1 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    #endif
#if FABLE_COMPILER_RUST && WASM
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    #endif
#if FABLE_COMPILER_PYTHON
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    #endif
#else
    try
        let v2 : string = method81()
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
        let v22 : System.Guid = method72(v19, v13)
        let v23 : string = $"{v2}_{v22}.txt"
        let v24 : string = __SOURCE_DIRECTORY__
        let v25 : string = "polyglot"
        let v26 : string = ".devcontainer"
        let v27 : string = method80(v25, v26)
        let v28 : US15 = method121(v27, v24)
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
                let v79 : string = method125()
                let v80 : string = method80(v25, v26)
                let v81 : US15 = method121(v80, v79)
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
        let v136 : string = method80(v135, v25)
        let v137 : string = "target/trace"
        let v138 : string = method80(v136, v137)
        let v139 : System_IO_DirectoryInfo = method93(v138)
        let v140 : string = method80(v138, v23)
        let v141 : Async<unit> = method35(v140, v0)
        let v142 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        null |> unbox<unit>
        #endif
#if FABLE_COMPILER_RUST && WASM
        null |> unbox<unit>
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        null |> unbox<unit>
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        null |> unbox<unit>
        #endif
#if FABLE_COMPILER_PYTHON
        let v143 : (Async<unit> -> unit) = Async.RunSynchronously
        v143 v141
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v144 : (Async<unit> -> unit) = Async.RunSynchronously
        v144 v141
        #endif
#else
        let v145 : (Async<unit> -> unit) = Async.RunSynchronously
        v145 v141
        #endif
        // run_target_args' is_unit
        (* indent
        ()
    indent *)
    with ex ->
        let v290 : exn = ex
        let v291 : (unit -> exn) = closure59(v290)
        let v292 : string = $"file_system.trace_file / ex: %A{v291}"
        method126(v292)
        (* indent
        ()
    indent *)
    (* try_unit
    try_unit *)
    #endif
    // run_target_args' is_unit
    ()
and closure58 () (v0 : string) : unit =
    method126(v0)
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
and method127 (v0 : string, v1 : string) : unit =
    let v2 : bool = method10(v0)
    let v3 : bool = v2 = false
    if v3 then
        let v4 : System.IDisposable = method83(v0)
        ()
    let v5 : string option = method108(v1)
    let v6 : string = ""
    let v7 : string = v5 |> Option.defaultValue v6 
    let v10 : bool = method10(v7)
    let v11 : bool = v10 = false
    if v11 then
        let v12 : System.IDisposable = method83(v7)
        ()
    let v13 : bool = method10(v1)
    let v24 : bool =
        if v13 then
            let v14 : Result<std_path_PathBuf, std_io_Error> = method100(v1)
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
        method9(v25, v1)
    let v26 : bool = method10(v1)
    let v27 : bool = v26 = false
    if v27 then
        let v28 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v29 : string = "true; #[cfg(windows)] std::os::windows::fs::symlink_dir(&*$0, &*$1).unwrap()"
        let v30 : bool = Fable.Core.RustInterop.emitRustExpr struct (v0, v1) v29 
        let v31 : string = "true; #[cfg(unix)] std::os::unix::fs::symlink(&*$0, &*$1).unwrap()"
        let v32 : bool = Fable.Core.RustInterop.emitRustExpr struct (v0, v1) v31 
        #endif
#if FABLE_COMPILER_RUST && WASM
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        #endif
#if FABLE_COMPILER_PYTHON
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        #endif
#else
        let v33 : System.IO.FileSystemInfo = System.IO.Directory.CreateSymbolicLink (v1, v0)
        #endif
        // run_target_args' is_unit
        ()
and closure61 (v0 : string) (v1 : string) : unit =
    method127(v0, v1)
and closure60 () (v0 : string) : (string -> unit) =
    closure61(v0)
and closure63 (v0 : string) (v1 : string) : string =
    method80(v0, v1)
and closure62 () (v0 : string) : (string -> string) =
    closure63(v0)
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
let v34 : (string -> (string -> unit)) = closure60()
let link_directory x = v34 x
let v35 : (string -> (string -> string)) = closure62()
let (</>) x = v35 x
()
