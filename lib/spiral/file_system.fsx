#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::string::String")>]
#endif
type std_string_String = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("&$0")>]
#endif
type Ref<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::path::PathBuf")>]
#endif
type std_path_PathBuf = class end
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
#endif
type std_path_Display = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::io::Error")>]
#endif
type std_io_Error = class end
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
#endif
type Str = class end
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
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("regex::Error")>]
#endif
type regex_Error = class end
type IPathDirname = abstract dirname: path: string -> string
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::path::Path")>]
#endif
type std_path_Path = class end
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
    | US1_0 of f0_0 : string
    | US1_1
and [<Struct>] US2 =
    | US2_0 of f0_0 : US0
    | US2_1
and [<Struct>] US3 =
    | US3_0 of f0_0 : int64
    | US3_1
and [<Struct>] US4 =
    | US4_0
    | US4_1
    | US4_2
and [<Struct>] US5 =
    | US5_0 of f0_0 : US4
    | US5_1 of f1_0 : US4
    | US5_2 of f2_0 : US4
    | US5_3 of f3_0 : US4
    | US5_4 of f4_0 : US4
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
    | US13_0 of f0_0 : string
    | US13_1 of f1_0 : string
let rec method1 () : string =
    let v0 : string = "TRACE_LEVEL"
    v0
and method3 () : string =
    let v0 : string = ""
    v0
and closure1 () (v0 : string) : US1 =
    US1_0(v0)
and method4 () : (string -> US1) =
    closure1()
and method2 (v0 : string) : string =
    let v1 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = "std::env::var(&*$0)"
    let v3 : Result<std_string_String, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr v0 v2 
    let v4 : string = "true; let _result_map_ = $0.map(|x| { //"
    let v5 : bool = Fable.Core.RustInterop.emitRustExpr v3 v4 
    let v6 : string = "x"
    let v7 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v6 
    let v8 : string = "fable_library_rust::String_::fromString($0)"
    let v9 : string = Fable.Core.RustInterop.emitRustExpr v7 v8 
    let v10 : string = "true; $0 })"
    let v11 : bool = Fable.Core.RustInterop.emitRustExpr v9 v10 
    let v12 : string = "_result_map_"
    let v13 : Result<string, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr () v12 
    let v14 : string = method3()
    let v15 : string = "$0.unwrap_or($1)"
    let v16 : string = Fable.Core.RustInterop.emitRustExpr struct (v13, v14) v15 
    let _v1 = v16 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v17 : string = "std::env::var(&*$0)"
    let v18 : Result<std_string_String, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr v0 v17 
    let v19 : string = "true; let _result_map_ = $0.map(|x| { //"
    let v20 : bool = Fable.Core.RustInterop.emitRustExpr v18 v19 
    let v21 : string = "x"
    let v22 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v21 
    let v23 : string = "fable_library_rust::String_::fromString($0)"
    let v24 : string = Fable.Core.RustInterop.emitRustExpr v22 v23 
    let v25 : string = "true; $0 })"
    let v26 : bool = Fable.Core.RustInterop.emitRustExpr v24 v25 
    let v27 : string = "_result_map_"
    let v28 : Result<string, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr () v27 
    let v29 : string = method3()
    let v30 : string = "$0.unwrap_or($1)"
    let v31 : string = Fable.Core.RustInterop.emitRustExpr struct (v28, v29) v30 
    let _v1 = v31 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v32 : string = "std::env::var(&*$0)"
    let v33 : Result<std_string_String, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr v0 v32 
    let v34 : string = "true; let _result_map_ = $0.map(|x| { //"
    let v35 : bool = Fable.Core.RustInterop.emitRustExpr v33 v34 
    let v36 : string = "x"
    let v37 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v36 
    let v38 : string = "fable_library_rust::String_::fromString($0)"
    let v39 : string = Fable.Core.RustInterop.emitRustExpr v37 v38 
    let v40 : string = "true; $0 })"
    let v41 : bool = Fable.Core.RustInterop.emitRustExpr v39 v40 
    let v42 : string = "_result_map_"
    let v43 : Result<string, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr () v42 
    let v44 : string = method3()
    let v45 : string = "$0.unwrap_or($1)"
    let v46 : string = Fable.Core.RustInterop.emitRustExpr struct (v43, v44) v45 
    let _v1 = v46 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v47 : string = "process.env[$0] ?? \"\""
    let v48 : string = Fable.Core.JsInterop.emitJsExpr v0 v47 
    let _v1 = v48 
    #endif
#if FABLE_COMPILER_PYTHON
    let v49 : string = "os"
    let v50 : IOsEnviron = Fable.Core.PyInterop.importAll v49 
    let v51 : string = "v50.environ"
    let v52 : obj = Fable.Core.PyInterop.emitPyExpr () v51 
    let v55 : string = "v52.get($0)"
    let v56 : string = Fable.Core.PyInterop.emitPyExpr v0 v55 
    let mutable _v56 = None
    #if !FABLE_COMPILER && !WASM && !CONTRACT
    let v59 : (string -> string option) = Option.ofObj
    let v60 : string option = v59 v56
    v60 
    #else
    Some v56 
    #endif
    |> fun x -> _v56 <- Some x
    let v61 : string option = match _v56 with Some x -> x | None -> failwith "optionm'.of_obj / _v56=None"
    let v64 : (string -> US1) = method4()
    let v65 : US1 option = v61 |> Option.map v64 
    let v76 : US1 = US1_1
    let v77 : US1 = v65 |> Option.defaultValue v76 
    let v84 : string =
        match v77 with
        | US1_1 -> (* None *)
            let v82 : string = ""
            v82
        | US1_0(v81) -> (* Some *)
            v81
    let _v1 = v84 
    #endif
#else
    let v85 : (string -> string) = System.Environment.GetEnvironmentVariable
    let v86 : string = v85 v0
    let mutable _v86 = None
    #if !FABLE_COMPILER && !WASM && !CONTRACT
    let v87 : (string -> string option) = Option.ofObj
    let v88 : string option = v87 v86
    v88 
    #else
    Some v86 
    #endif
    |> fun x -> _v86 <- Some x
    let v89 : string option = match _v86 with Some x -> x | None -> failwith "optionm'.of_obj / _v86=None"
    let v92 : (string -> US1) = method4()
    let v93 : US1 option = v89 |> Option.map v92 
    let v104 : US1 = US1_1
    let v105 : US1 = v93 |> Option.defaultValue v104 
    let v112 : string =
        match v105 with
        | US1_1 -> (* None *)
            let v110 : string = ""
            v110
        | US1_0(v109) -> (* Some *)
            v109
    let _v1 = v112 
    #endif
    let v113 : string = _v1 
    v113
and method5 () : string =
    let v0 : string = "AUTOMATION"
    v0
and closure2 () (v0 : string) : unit =
    ()
and method0 (v0 : US0) : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) =
    let v1 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = method1()
    let v3 : string = method2(v2)
    
    
    
    
    
    let v4 : bool = "Verbose" = v3
    let v8 : US2 =
        if v4 then
            let v5 : US0 = US0_0
            US2_0(v5)
        else
            US2_1
    let v49 : US2 =
        match v8 with
        | US2_1 -> (* None *)
            let v11 : bool = "Debug" = v3
            let v15 : US2 =
                if v11 then
                    let v12 : US0 = US0_1
                    US2_0(v12)
                else
                    US2_1
            match v15 with
            | US2_1 -> (* None *)
                let v18 : bool = "Info" = v3
                let v22 : US2 =
                    if v18 then
                        let v19 : US0 = US0_2
                        US2_0(v19)
                    else
                        US2_1
                match v22 with
                | US2_1 -> (* None *)
                    let v25 : bool = "Warning" = v3
                    let v29 : US2 =
                        if v25 then
                            let v26 : US0 = US0_3
                            US2_0(v26)
                        else
                            US2_1
                    match v29 with
                    | US2_1 -> (* None *)
                        let v32 : bool = "Critical" = v3
                        let v36 : US2 =
                            if v32 then
                                let v33 : US0 = US0_4
                                US2_0(v33)
                            else
                                US2_1
                        match v36 with
                        | US2_1 -> (* None *)
                            US2_1
                        | US2_0(v37) -> (* Some *)
                            US2_0(v37)
                    | US2_0(v30) -> (* Some *)
                        US2_0(v30)
                | US2_0(v23) -> (* Some *)
                    US2_0(v23)
            | US2_0(v16) -> (* Some *)
                US2_0(v16)
        | US2_0(v9) -> (* Some *)
            US2_0(v9)
    let v50 : string = method5()
    let v51 : string = method2(v50)
    let v52 : bool = v51 = "True"
    let v62 : US3 =
        if v52 then
            let v53 : System.DateTime = System.DateTime.Now
            let v56 : (System.DateTime -> int64) = _.Ticks
            let v57 : int64 = v56 v53
            US3_0(v57)
        else
            US3_1
    let _v1 = struct (v49, v62) 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v63 : US2 = US2_1
    let v64 : US3 = US3_1
    let _v1 = struct (v63, v64) 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v65 : string = "AUTOMATION"
    let v66 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v67 : string = "env!(\"" + v65 + "\")"
    let v68 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v67 
    let v69 : string = "String::from($0)"
    let v70 : std_string_String = Fable.Core.RustInterop.emitRustExpr v68 v69 
    let v71 : string = "fable_library_rust::String_::fromString($0)"
    let v72 : string = Fable.Core.RustInterop.emitRustExpr v70 v71 
    let _v66 = v72 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v73 : string = "env!(\"" + v65 + "\")"
    let v74 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v73 
    let v75 : string = "String::from($0)"
    let v76 : std_string_String = Fable.Core.RustInterop.emitRustExpr v74 v75 
    let v77 : string = "fable_library_rust::String_::fromString($0)"
    let v78 : string = Fable.Core.RustInterop.emitRustExpr v76 v77 
    let _v66 = v78 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v79 : string = "env!(\"" + v65 + "\")"
    let v80 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v79 
    let v81 : string = "String::from($0)"
    let v82 : std_string_String = Fable.Core.RustInterop.emitRustExpr v80 v81 
    let v83 : string = "fable_library_rust::String_::fromString($0)"
    let v84 : string = Fable.Core.RustInterop.emitRustExpr v82 v83 
    let _v66 = v84 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v85 : string = null |> unbox<string>
    let _v66 = v85 
    #endif
#if FABLE_COMPILER_PYTHON
    let v88 : string = null |> unbox<string>
    let _v66 = v88 
    #endif
#else
    let v91 : string = null |> unbox<string>
    let _v66 = v91 
    #endif
    let v94 : string = _v66 
    let v99 : string = "True"
    let v100 : bool = v94 <> v99 
    let v109 : US3 =
        if v100 then
            US3_1
        else
            let v104 : string = $"near_sdk::env::block_timestamp()"
            let v105 : uint64 = Fable.Core.RustInterop.emitRustExpr () v104 
            let v106 : (uint64 -> int64) = int64
            let v107 : int64 = v106 v105
            US3_0(v107)
    let v110 : US2 = US2_1
    let _v1 = struct (v110, v109) 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v111 : string = method1()
    let v112 : string = method2(v111)
    
    
    
    
    
    let v113 : bool = "Verbose" = v112
    let v117 : US2 =
        if v113 then
            let v114 : US0 = US0_0
            US2_0(v114)
        else
            US2_1
    let v158 : US2 =
        match v117 with
        | US2_1 -> (* None *)
            let v120 : bool = "Debug" = v112
            let v124 : US2 =
                if v120 then
                    let v121 : US0 = US0_1
                    US2_0(v121)
                else
                    US2_1
            match v124 with
            | US2_1 -> (* None *)
                let v127 : bool = "Info" = v112
                let v131 : US2 =
                    if v127 then
                        let v128 : US0 = US0_2
                        US2_0(v128)
                    else
                        US2_1
                match v131 with
                | US2_1 -> (* None *)
                    let v134 : bool = "Warning" = v112
                    let v138 : US2 =
                        if v134 then
                            let v135 : US0 = US0_3
                            US2_0(v135)
                        else
                            US2_1
                    match v138 with
                    | US2_1 -> (* None *)
                        let v141 : bool = "Critical" = v112
                        let v145 : US2 =
                            if v141 then
                                let v142 : US0 = US0_4
                                US2_0(v142)
                            else
                                US2_1
                        match v145 with
                        | US2_1 -> (* None *)
                            US2_1
                        | US2_0(v146) -> (* Some *)
                            US2_0(v146)
                    | US2_0(v139) -> (* Some *)
                        US2_0(v139)
                | US2_0(v132) -> (* Some *)
                    US2_0(v132)
            | US2_0(v125) -> (* Some *)
                US2_0(v125)
        | US2_0(v118) -> (* Some *)
            US2_0(v118)
    let v159 : string = method5()
    let v160 : string = method2(v159)
    let v161 : bool = v160 = "True"
    let v171 : US3 =
        if v161 then
            let v162 : System.DateTime = System.DateTime.Now
            let v165 : (System.DateTime -> int64) = _.Ticks
            let v166 : int64 = v165 v162
            US3_0(v166)
        else
            US3_1
    let _v1 = struct (v158, v171) 
    #endif
#if FABLE_COMPILER_PYTHON
    let v172 : string = method1()
    let v173 : string = method2(v172)
    
    
    
    
    
    let v174 : bool = "Verbose" = v173
    let v178 : US2 =
        if v174 then
            let v175 : US0 = US0_0
            US2_0(v175)
        else
            US2_1
    let v219 : US2 =
        match v178 with
        | US2_1 -> (* None *)
            let v181 : bool = "Debug" = v173
            let v185 : US2 =
                if v181 then
                    let v182 : US0 = US0_1
                    US2_0(v182)
                else
                    US2_1
            match v185 with
            | US2_1 -> (* None *)
                let v188 : bool = "Info" = v173
                let v192 : US2 =
                    if v188 then
                        let v189 : US0 = US0_2
                        US2_0(v189)
                    else
                        US2_1
                match v192 with
                | US2_1 -> (* None *)
                    let v195 : bool = "Warning" = v173
                    let v199 : US2 =
                        if v195 then
                            let v196 : US0 = US0_3
                            US2_0(v196)
                        else
                            US2_1
                    match v199 with
                    | US2_1 -> (* None *)
                        let v202 : bool = "Critical" = v173
                        let v206 : US2 =
                            if v202 then
                                let v203 : US0 = US0_4
                                US2_0(v203)
                            else
                                US2_1
                        match v206 with
                        | US2_1 -> (* None *)
                            US2_1
                        | US2_0(v207) -> (* Some *)
                            US2_0(v207)
                    | US2_0(v200) -> (* Some *)
                        US2_0(v200)
                | US2_0(v193) -> (* Some *)
                    US2_0(v193)
            | US2_0(v186) -> (* Some *)
                US2_0(v186)
        | US2_0(v179) -> (* Some *)
            US2_0(v179)
    let v220 : string = method5()
    let v221 : string = method2(v220)
    let v222 : bool = v221 = "True"
    let v232 : US3 =
        if v222 then
            let v223 : System.DateTime = System.DateTime.Now
            let v226 : (System.DateTime -> int64) = _.Ticks
            let v227 : int64 = v226 v223
            US3_0(v227)
        else
            US3_1
    let _v1 = struct (v219, v232) 
    #endif
#else
    let v233 : string = method1()
    let v234 : string = method2(v233)
    
    
    
    
    
    let v235 : bool = "Verbose" = v234
    let v239 : US2 =
        if v235 then
            let v236 : US0 = US0_0
            US2_0(v236)
        else
            US2_1
    let v280 : US2 =
        match v239 with
        | US2_1 -> (* None *)
            let v242 : bool = "Debug" = v234
            let v246 : US2 =
                if v242 then
                    let v243 : US0 = US0_1
                    US2_0(v243)
                else
                    US2_1
            match v246 with
            | US2_1 -> (* None *)
                let v249 : bool = "Info" = v234
                let v253 : US2 =
                    if v249 then
                        let v250 : US0 = US0_2
                        US2_0(v250)
                    else
                        US2_1
                match v253 with
                | US2_1 -> (* None *)
                    let v256 : bool = "Warning" = v234
                    let v260 : US2 =
                        if v256 then
                            let v257 : US0 = US0_3
                            US2_0(v257)
                        else
                            US2_1
                    match v260 with
                    | US2_1 -> (* None *)
                        let v263 : bool = "Critical" = v234
                        let v267 : US2 =
                            if v263 then
                                let v264 : US0 = US0_4
                                US2_0(v264)
                            else
                                US2_1
                        match v267 with
                        | US2_1 -> (* None *)
                            US2_1
                        | US2_0(v268) -> (* Some *)
                            US2_0(v268)
                    | US2_0(v261) -> (* Some *)
                        US2_0(v261)
                | US2_0(v254) -> (* Some *)
                    US2_0(v254)
            | US2_0(v247) -> (* Some *)
                US2_0(v247)
        | US2_0(v240) -> (* Some *)
            US2_0(v240)
    let v281 : string = method5()
    let v282 : string = method2(v281)
    let v283 : bool = v282 = "True"
    let v293 : US3 =
        if v283 then
            let v284 : System.DateTime = System.DateTime.Now
            let v287 : (System.DateTime -> int64) = _.Ticks
            let v288 : int64 = v287 v284
            US3_0(v288)
        else
            US3_1
    let _v1 = struct (v280, v293) 
    #endif
    let struct (v294 : US2, v295 : US3) = _v1 
    let v359 : Mut0 = {l0 = 1L} : Mut0
    let v360 : (string -> unit) = closure2()
    let v361 : Mut1 = {l0 = v360} : Mut1
    let v362 : Mut2 = {l0 = true} : Mut2
    let v363 : string = ""
    let v364 : Mut3 = {l0 = v363} : Mut3
    let v367 : US0 =
        match v294 with
        | US2_1 -> (* None *)
            v0
        | US2_0(v365) -> (* Some *)
            v365
    let v368 : Mut4 = {l0 = v367} : Mut4
    let v375 : int64 option =
        match v295 with
        | US3_1 -> (* None *)
            let v373 : int64 option = None
            v373
        | US3_0(v369) -> (* Some *)
            let v370 : int64 option = Some v369 
            v370
    struct (v359, v361, v362, v364, v368, v375)
and closure0 () () : unit =
    let v0 : bool = TraceState.trace_state.IsNone
    if v0 then
        let v1 : US0 = US0_0
        let struct (v2 : Mut0, v3 : Mut1, v4 : Mut2, v5 : Mut3, v6 : Mut4, v7 : int64 option) = method0(v1)
        let v8 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v2, v3, v4, v5, v6, v7) 
        TraceState.trace_state <- v8 
        ()
and method8 (v0 : string) : string =
    v0
and method9 (v0 : string) : bool =
    let v1 : unit = ()
    
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
    let v15 : bool =
        if v9 then
            true
        else
            let v10 : string = "$0.is_dir()"
            let v11 : bool = Fable.Core.RustInterop.emitRustExpr v7 v10 
            if v11 then
                true
            else
                let v12 : string = "$0.is_symlink()"
                let v13 : bool = Fable.Core.RustInterop.emitRustExpr v7 v12 
                v13
    let _v1 = v15 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v16 : bool = null |> unbox<bool>
    let _v1 = v16 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v19 : bool = null |> unbox<bool>
    let _v1 = v19 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v22 : string = "fs"
    let v23 : IFsExistsSync = Fable.Core.JsInterop.importAll v22 
    let v24 : string = "$0.existsSync($1)"
    let v25 : bool = Fable.Core.JsInterop.emitJsExpr struct (v23, v0) v24 
    let _v1 = v25 
    #endif
#if FABLE_COMPILER_PYTHON
    let v26 : bool = null |> unbox<bool>
    let _v1 = v26 
    #endif
#else
    let v29 : (string -> bool) = System.IO.Directory.Exists
    let v30 : bool = v29 v0
    let _v1 = v30 
    #endif
    let v31 : bool = _v1 
    v31
and method7 (v0 : bool, v1 : string) : unit =
    let v2 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : string = method8(v1)
    let v4 : bool = method9(v3)
    if v4 then
        if v0 then
            let v5 : string = "std::fs::remove_dir_all(&*$0).unwrap()"
            Fable.Core.RustInterop.emitRustExpr v3 v5 
            ()
        else
            let v6 : string = "std::fs::remove_dir(&*$0).unwrap()"
            Fable.Core.RustInterop.emitRustExpr v3 v6 
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
#else
    System.IO.Directory.Delete (v1, v0)
    let _v2 = () 
    #endif
    _v2 
    ()
and closure5 () (v0 : int64) : US3 =
    US3_0(v0)
and method11 () : (int64 -> US3) =
    closure5()
and method12 () : string =
    let v0 : string = "hh:mm:ss"
    v0
and method13 () : string =
    let v0 : string = "HH:mm:ss"
    v0
and method10 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option) : string =
    let v6 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v7 : (int64 -> US3) = method11()
    let v8 : US3 option = v5 |> Option.map v7 
    let v19 : US3 = US3_1
    let v20 : US3 = v8 |> Option.defaultValue v19 
    let v60 : System.DateTime =
        match v20 with
        | US3_1 -> (* None *)
            let v56 : System.DateTime = System.DateTime.Now
            v56
        | US3_0(v24) -> (* Some *)
            let v25 : System.DateTime = System.DateTime.Now
            let v28 : (System.DateTime -> int64) = _.Ticks
            let v29 : int64 = v28 v25
            let v32 : int64 = v29 - v24
            let v33 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v34 : System.TimeSpan = v33 v32
            let v37 : (System.TimeSpan -> int32) = _.Hours
            let v38 : int32 = v37 v34
            let v41 : (System.TimeSpan -> int32) = _.Minutes
            let v42 : int32 = v41 v34
            let v45 : (System.TimeSpan -> int32) = _.Seconds
            let v46 : int32 = v45 v34
            let v49 : (System.TimeSpan -> int32) = _.Milliseconds
            let v50 : int32 = v49 v34
            let v53 : System.DateTime = System.DateTime (1, 1, 1, v38, v42, v46, v50)
            v53
    let v61 : string = method12()
    let v64 : (string -> string) = v60.ToString
    let v65 : string = v64 v61
    let _v6 = v65 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v68 : (int64 -> US3) = method11()
    let v69 : US3 option = v5 |> Option.map v68 
    let v80 : US3 = US3_1
    let v81 : US3 = v69 |> Option.defaultValue v80 
    let v121 : System.DateTime =
        match v81 with
        | US3_1 -> (* None *)
            let v117 : System.DateTime = System.DateTime.Now
            v117
        | US3_0(v85) -> (* Some *)
            let v86 : System.DateTime = System.DateTime.Now
            let v89 : (System.DateTime -> int64) = _.Ticks
            let v90 : int64 = v89 v86
            let v93 : int64 = v90 - v85
            let v94 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v95 : System.TimeSpan = v94 v93
            let v98 : (System.TimeSpan -> int32) = _.Hours
            let v99 : int32 = v98 v95
            let v102 : (System.TimeSpan -> int32) = _.Minutes
            let v103 : int32 = v102 v95
            let v106 : (System.TimeSpan -> int32) = _.Seconds
            let v107 : int32 = v106 v95
            let v110 : (System.TimeSpan -> int32) = _.Milliseconds
            let v111 : int32 = v110 v95
            let v114 : System.DateTime = System.DateTime (1, 1, 1, v99, v103, v107, v111)
            v114
    let v122 : string = method12()
    let v125 : (string -> string) = v121.ToString
    let v126 : string = v125 v122
    let _v6 = v126 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v129 : string = $"near_sdk::env::block_timestamp()"
    let v130 : uint64 = Fable.Core.RustInterop.emitRustExpr () v129 
    let v131 : (int64 -> US3) = method11()
    let v132 : US3 option = v5 |> Option.map v131 
    let v143 : US3 = US3_1
    let v144 : US3 = v132 |> Option.defaultValue v143 
    let v153 : uint64 =
        match v144 with
        | US3_1 -> (* None *)
            v130
        | US3_0(v148) -> (* Some *)
            let v149 : (int64 -> uint64) = uint64
            let v150 : uint64 = v149 v148
            let v151 : uint64 = v130 - v150
            v151
    let v154 : uint64 = v153 / 1000000000UL
    let v155 : uint64 = v154 % 60UL
    let v156 : uint64 = v154 / 60UL
    let v157 : uint64 = v156 % 60UL
    let v158 : uint64 = v154 / 3600UL
    let v159 : uint64 = v158 % 24UL
    let v160 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
    let v161 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v159, v157, v155) v160 
    let v162 : string = "fable_library_rust::String_::fromString($0)"
    let v163 : string = Fable.Core.RustInterop.emitRustExpr v161 v162 
    let _v6 = v163 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v164 : (int64 -> US3) = method11()
    let v165 : US3 option = v5 |> Option.map v164 
    let v176 : US3 = US3_1
    let v177 : US3 = v165 |> Option.defaultValue v176 
    let v217 : System.DateTime =
        match v177 with
        | US3_1 -> (* None *)
            let v213 : System.DateTime = System.DateTime.Now
            v213
        | US3_0(v181) -> (* Some *)
            let v182 : System.DateTime = System.DateTime.Now
            let v185 : (System.DateTime -> int64) = _.Ticks
            let v186 : int64 = v185 v182
            let v189 : int64 = v186 - v181
            let v190 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v191 : System.TimeSpan = v190 v189
            let v194 : (System.TimeSpan -> int32) = _.Hours
            let v195 : int32 = v194 v191
            let v198 : (System.TimeSpan -> int32) = _.Minutes
            let v199 : int32 = v198 v191
            let v202 : (System.TimeSpan -> int32) = _.Seconds
            let v203 : int32 = v202 v191
            let v206 : (System.TimeSpan -> int32) = _.Milliseconds
            let v207 : int32 = v206 v191
            let v210 : System.DateTime = System.DateTime (1, 1, 1, v195, v199, v203, v207)
            v210
    let v218 : string = method13()
    let v221 : (string -> string) = v217.ToString
    let v222 : string = v221 v218
    let _v6 = v222 
    #endif
#if FABLE_COMPILER_PYTHON
    let v225 : (int64 -> US3) = method11()
    let v226 : US3 option = v5 |> Option.map v225 
    let v237 : US3 = US3_1
    let v238 : US3 = v226 |> Option.defaultValue v237 
    let v278 : System.DateTime =
        match v238 with
        | US3_1 -> (* None *)
            let v274 : System.DateTime = System.DateTime.Now
            v274
        | US3_0(v242) -> (* Some *)
            let v243 : System.DateTime = System.DateTime.Now
            let v246 : (System.DateTime -> int64) = _.Ticks
            let v247 : int64 = v246 v243
            let v250 : int64 = v247 - v242
            let v251 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v252 : System.TimeSpan = v251 v250
            let v255 : (System.TimeSpan -> int32) = _.Hours
            let v256 : int32 = v255 v252
            let v259 : (System.TimeSpan -> int32) = _.Minutes
            let v260 : int32 = v259 v252
            let v263 : (System.TimeSpan -> int32) = _.Seconds
            let v264 : int32 = v263 v252
            let v267 : (System.TimeSpan -> int32) = _.Milliseconds
            let v268 : int32 = v267 v252
            let v271 : System.DateTime = System.DateTime (1, 1, 1, v256, v260, v264, v268)
            v271
    let v279 : string = method13()
    let v282 : (string -> string) = v278.ToString
    let v283 : string = v282 v279
    let _v6 = v283 
    #endif
#else
    let v286 : (int64 -> US3) = method11()
    let v287 : US3 option = v5 |> Option.map v286 
    let v298 : US3 = US3_1
    let v299 : US3 = v287 |> Option.defaultValue v298 
    let v339 : System.DateTime =
        match v299 with
        | US3_1 -> (* None *)
            let v335 : System.DateTime = System.DateTime.Now
            v335
        | US3_0(v303) -> (* Some *)
            let v304 : System.DateTime = System.DateTime.Now
            let v307 : (System.DateTime -> int64) = _.Ticks
            let v308 : int64 = v307 v304
            let v311 : int64 = v308 - v303
            let v312 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v313 : System.TimeSpan = v312 v311
            let v316 : (System.TimeSpan -> int32) = _.Hours
            let v317 : int32 = v316 v313
            let v320 : (System.TimeSpan -> int32) = _.Minutes
            let v321 : int32 = v320 v313
            let v324 : (System.TimeSpan -> int32) = _.Seconds
            let v325 : int32 = v324 v313
            let v328 : (System.TimeSpan -> int32) = _.Milliseconds
            let v329 : int32 = v328 v313
            let v332 : System.DateTime = System.DateTime (1, 1, 1, v317, v321, v325, v329)
            v332
    let v340 : string = method13()
    let v343 : (string -> string) = v339.ToString
    let v344 : string = v343 v340
    let _v6 = v344 
    #endif
    let v347 : string = _v6 
    v347
and method15 () : string =
    let v0 : string = "\u001b[0m"
    v0
and method14 () : string =
    
    
    
    
    
    let v0 : string = "Debug"
    let v1 : (unit -> string) = v0.ToLower
    let v2 : string = v1 ()
    let v5 : string = v2.PadLeft (7, ' ')
    let v19 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v20 : string = "inline_colorization::color_bright_blue"
    let v21 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v20 
    let v22 : string = "&*$0"
    let v23 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v22 
    let v24 : string = "inline_colorization::color_reset"
    let v25 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v24 
    let v26 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v27 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v21, v23, v25) v26 
    let v28 : string = "fable_library_rust::String_::fromString($0)"
    let v29 : string = Fable.Core.RustInterop.emitRustExpr v27 v28 
    let _v19 = v29 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v30 : string = "inline_colorization::color_bright_blue"
    let v31 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v30 
    let v32 : string = "&*$0"
    let v33 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v32 
    let v34 : string = "inline_colorization::color_reset"
    let v35 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v34 
    let v36 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v37 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v31, v33, v35) v36 
    let v38 : string = "fable_library_rust::String_::fromString($0)"
    let v39 : string = Fable.Core.RustInterop.emitRustExpr v37 v38 
    let _v19 = v39 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v40 : string = "inline_colorization::color_bright_blue"
    let v41 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v40 
    let v42 : string = "&*$0"
    let v43 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v42 
    let v44 : string = "inline_colorization::color_reset"
    let v45 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v44 
    let v46 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v47 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v41, v43, v45) v46 
    let v48 : string = "fable_library_rust::String_::fromString($0)"
    let v49 : string = Fable.Core.RustInterop.emitRustExpr v47 v48 
    let _v19 = v49 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v50 : string = "\u001b[94m"
    let v51 : string = method15()
    let v52 : string = v50 + v5 
    let v53 : string = v52 + v51 
    let _v19 = v53 
    #endif
#if FABLE_COMPILER_PYTHON
    let v54 : string = "\u001b[94m"
    let v55 : string = method15()
    let v56 : string = v54 + v5 
    let v57 : string = v56 + v55 
    let _v19 = v57 
    #endif
#else
    let v58 : string = "\u001b[94m"
    let v59 : string = method15()
    let v60 : string = v58 + v5 
    let v61 : string = v60 + v59 
    let _v19 = v61 
    #endif
    let v62 : string = _v19 
    v62
and method16 (v0 : string) : string =
    let v1 : unit = ()
    
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
    let _v1 = v21 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v22 : US4 = US4_1
    let v23 : US5 = US5_2(v22)
    let v24 : string = $"file_system.get_file_name / target: {v23} / path: {v0}"
    let v25 : string = failwith<string> v24
    let _v1 = v25 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v26 : string = null |> unbox<string>
    let _v1 = v26 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v29 : US4 = US4_0
    let v30 : US5 = US5_3(v29)
    let v31 : string = $"file_system.get_file_name / target: {v30} / path: {v0}"
    let v32 : string = failwith<string> v31
    let _v1 = v32 
    #endif
#if FABLE_COMPILER_PYTHON
    let v33 : US4 = US4_0
    let v34 : US5 = US5_4(v33)
    let v35 : string = $"file_system.get_file_name / target: {v34} / path: {v0}"
    let v36 : string = failwith<string> v35
    let _v1 = v36 
    #endif
#else
    let v37 : (string -> string) = System.IO.Path.GetFileName
    let v38 : string = v37 v0
    let _v1 = v38 
    #endif
    let v39 : string = _v1 
    v39
and method18 () : string =
    let v0 : string = ""
    v0
and closure6 (v0 : Mut3, v1 : string) () : unit =
    let v2 : string = v0.l0
    let v3 : string = v2 + v1 
    v0.l0 <- v3
    ()
and method17 (v0 : string, v1 : string) : string =
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
and method19 (v0 : string, v1 : string, v2 : int64, v3 : string) : string =
    let v4 : string = "file_system.delete_directory_async"
    let v5 : string = $"{v0} {v1} #{v2} %s{v4} / {v3}"
    let v8 : char list = []
    let v9 : (char list -> (char [])) = List.toArray
    let v10 : (char []) = v9 v8
    let v13 : string = v5.TrimStart v10 
    let v31 : char list = []
    let v32 : char list = '/' :: v31 
    let v35 : char list = ' ' :: v32 
    let v38 : (char list -> (char [])) = List.toArray
    let v39 : (char []) = v38 v35
    let v42 : string = v13.TrimEnd v39 
    v42
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
and method20 (v0 : string, v1 : Mut0, v2 : Mut1, v3 : Mut2, v4 : Mut3, v5 : Mut4, v6 : int64 option) : unit =
    let v7 : unit = ()
    let v8 : (unit -> unit) = closure7(v1)
    let v9 : unit = (fun () -> v8 (); v7) ()
    let v12 : (string -> unit) = closure8()
    let v13 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v14 : string = @"println!(""{}"", $0)"
    Fable.Core.RustInterop.emitRustExpr v0 v14 
    let _v13 = () 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v15 : string = @"println!(""{}"", $0)"
    Fable.Core.RustInterop.emitRustExpr v0 v15 
    let _v13 = () 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v16 : string = v4.l0
    let v17 : bool = v16 = ""
    let v25 : string =
        if v17 then
            v0
        else
            let v18 : bool = v0 = ""
            if v18 then
                let v19 : string = v4.l0
                v19
            else
                let v20 : string = v4.l0
                let v21 : string = "\n"
                let v22 : string = v20 + v21 
                let v23 : string = v22 + v0 
                v23
    let v26 : string = "&*$0"
    let v27 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v25 v26 
    let v28 : string = $"$0.chars()"
    let v29 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v27 v28 
    let v30 : string = "$0"
    let v31 : _ = Fable.Core.RustInterop.emitRustExpr v29 v30 
    let v32 : string = "$0.collect::<Vec<_>>()"
    let v33 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v31 v32 
    let v34 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
    let v35 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v33 v34 
    let v36 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
    let v37 : bool = Fable.Core.RustInterop.emitRustExpr v35 v36 
    let v38 : string = "x"
    let v39 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v38 
    let v40 : string = "String::from_iter($0)"
    let v41 : std_string_String = Fable.Core.RustInterop.emitRustExpr v39 v40 
    let v42 : string = "true; $0 }).collect::<Vec<_>>()"
    let v43 : bool = Fable.Core.RustInterop.emitRustExpr v41 v42 
    let v44 : string = "_vec_map"
    let v45 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v44 
    let v46 : string = "$0.len()"
    let v47 : unativeint = Fable.Core.RustInterop.emitRustExpr v45 v46 
    let v48 : (unativeint -> int32) = int32
    let v49 : int32 = v48 v47
    let v50 : string = ""
    let v51 : bool = v0 <> v50 
    let v55 : bool =
        if v51 then
            let v54 : bool = v49 <= 1
            v54
        else
            false
    if v55 then
        v4.l0 <- v25
        ()
    else
        v4.l0 <- v50
        let v56 : string = "true; $0.into_iter().for_each(|x| { //"
        let v57 : bool = Fable.Core.RustInterop.emitRustExpr v45 v56 
        let v58 : string = "x"
        let v59 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v58 
        let v60 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
        let v61 : bool = Fable.Core.RustInterop.emitRustExpr v59 v60 
        let v62 : string = $"true"
        let v63 : bool = Fable.Core.RustInterop.emitRustExpr () v62 
        let v64 : string = "true; }); //"
        let v65 : bool = Fable.Core.RustInterop.emitRustExpr () v64 
        ()
    let _v13 = () 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    v12 v0
    let _v13 = () 
    #endif
#if FABLE_COMPILER_PYTHON
    v12 v0
    let _v13 = () 
    #endif
#else
    v12 v0
    let _v13 = () 
    #endif
    _v13 
    let v66 : (string -> unit) = v2.l0
    v66 v0
and closure4 (v0 : string, v1 : string) () : unit =
    let v2 : unit = ()
    let v3 : (unit -> unit) = closure0()
    let v4 : unit = (fun () -> v3 (); v2) ()
    let struct (v18 : Mut0, v19 : Mut1, v20 : Mut2, v21 : Mut3, v22 : Mut4, v23 : int64 option) = TraceState.trace_state.Value
    let v36 : US0 = v22.l0
    let v37 : bool = v20.l0
    let v38 : bool = v37 = false
    let v41 : bool =
        if v38 then
            false
        else
            let v39 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v36
            let v40 : bool = 1 >= v39
            v40
    if v41 then
        let v42 : unit = ()
        let v43 : unit = (fun () -> v3 (); v42) ()
        let struct (v57 : Mut0, v58 : Mut1, v59 : Mut2, v60 : Mut3, v61 : Mut4, v62 : int64 option) = TraceState.trace_state.Value
        let v75 : string = method10(v57, v58, v59, v60, v61, v62)
        let v76 : string = method14()
        let v77 : int64 = v57.l0
        let v78 : string = method16(v0)
        let v79 : string = method17(v1, v78)
        let v80 : string = method19(v75, v76, v77, v79)
        let v81 : unit = ()
        let v82 : unit = (fun () -> v3 (); v81) ()
        let struct (v96 : Mut0, v97 : Mut1, v98 : Mut2, v99 : Mut3, v100 : Mut4, v101 : int64 option) = TraceState.trace_state.Value
        method20(v80, v96, v97, v98, v99, v100, v101)
and method6 (v0 : string, v1 : int64) : Async<int64> =
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
#else
    let v18 : Async<int64> option = None
    let mutable _v18 = v18 
    async {
    try
    let v19 : bool = true
    method7(v19, v0)
    return v1 
    with ex ->
    let v20 : exn = ex
    let v21 : int64 = v1 % 100L
    let v22 : bool = v21 = 0L
    if v22 then
        let v23 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v24 : string = $"%A{v20}"
        let _v23 = v24 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v27 : string = $"%A{v20}"
        let _v23 = v27 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v30 : string = $"%A{v20}"
        let _v23 = v30 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v33 : string = $"%A{v20}"
        let _v23 = v33 
        #endif
#if FABLE_COMPILER_PYTHON
        let v36 : string = $"%A{v20}"
        let _v23 = v36 
        #endif
#else
        let v39 : string = $"{v20.GetType ()}: {v20.Message}"
        let _v23 = v39 
        #endif
        let v40 : string = _v23 
        let v45 : unit = ()
        let v46 : (unit -> unit) = closure4(v0, v40)
        let v47 : unit = (fun () -> v46 (); v45) ()
        ()
    let v160 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v161 : Async<unit> = null |> unbox<Async<unit>>
    let _v160 = v161 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v164 : Async<unit> = null |> unbox<Async<unit>>
    let _v160 = v164 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v167 : Async<unit> = null |> unbox<Async<unit>>
    let _v160 = v167 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v170 : Async<unit> = null |> unbox<Async<unit>>
    let _v160 = v170 
    #endif
#if FABLE_COMPILER_PYTHON
    let v173 : Async<unit> = null |> unbox<Async<unit>>
    let _v160 = v173 
    #endif
#else
    let v176 : (int32 -> Async<unit>) = Async.Sleep
    let v177 : Async<unit> = v176 10
    let _v160 = v177 
    #endif
    let v178 : Async<unit> = _v160 
    do! v178 
    let v183 : int64 = v1 + 1L
    let v184 : Async<int64> = method6(v0, v183)
    return! v184 
    (*
    let v185 : int64 = *)
    }
    |> fun x -> _v18 <- Some x
    let v186 : Async<int64> = match _v18 with Some x -> x | None -> failwith "async.new_async_unit / _v18=None"
    let _v2 = v186 
    #endif
    let v187 : Async<int64> = _v2 
    v187
and closure3 () (v0 : string) : Async<int64> =
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
#else
    let v17 : int64 = 0L
    let v18 : Async<int64> = method6(v0, v17)
    let _v1 = v18 
    #endif
    let v19 : Async<int64> = _v1 
    v19
and method22 (v0 : string, v1 : int64, v2 : string) : string =
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
and method23 (v0 : string, v1 : string, v2 : int64, v3 : string) : string =
    let v4 : string = "file_system.wait_for_file_access"
    let v5 : string = $"{v0} {v1} #{v2} %s{v4} / {v3}"
    let v8 : char list = []
    let v9 : (char list -> (char [])) = List.toArray
    let v10 : (char []) = v9 v8
    let v13 : string = v5.TrimStart v10 
    let v31 : char list = []
    let v32 : char list = '/' :: v31 
    let v35 : char list = ' ' :: v32 
    let v38 : (char list -> (char [])) = List.toArray
    let v39 : (char []) = v38 v35
    let v42 : string = v13.TrimEnd v39 
    v42
and closure12 (v0 : string, v1 : int64, v2 : string) () : unit =
    let v3 : unit = ()
    let v4 : (unit -> unit) = closure0()
    let v5 : unit = (fun () -> v4 (); v3) ()
    let struct (v19 : Mut0, v20 : Mut1, v21 : Mut2, v22 : Mut3, v23 : Mut4, v24 : int64 option) = TraceState.trace_state.Value
    let v37 : US0 = v23.l0
    let v38 : bool = v21.l0
    let v39 : bool = v38 = false
    let v42 : bool =
        if v39 then
            false
        else
            let v40 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v37
            let v41 : bool = 1 >= v40
            v41
    if v42 then
        let v43 : unit = ()
        let v44 : unit = (fun () -> v4 (); v43) ()
        let struct (v58 : Mut0, v59 : Mut1, v60 : Mut2, v61 : Mut3, v62 : Mut4, v63 : int64 option) = TraceState.trace_state.Value
        let v76 : string = method10(v58, v59, v60, v61, v62, v63)
        let v77 : string = method14()
        let v78 : int64 = v58.l0
        let v79 : string = method16(v0)
        let v80 : string = method22(v79, v1, v2)
        let v81 : string = method23(v76, v77, v78, v80)
        let v82 : unit = ()
        let v83 : unit = (fun () -> v4 (); v82) ()
        let struct (v97 : Mut0, v98 : Mut1, v99 : Mut2, v100 : Mut3, v101 : Mut4, v102 : int64 option) = TraceState.trace_state.Value
        method20(v81, v97, v98, v99, v100, v101, v102)
and method21 (v0 : string, v1 : US8, v2 : US7, v3 : int64) : Async<int64> =
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
    let v14 : Async<int64> = null |> unbox<Async<int64>>
    let _v4 = v14 
    #endif
#if FABLE_COMPILER_PYTHON
    let v17 : Async<int64> = null |> unbox<Async<int64>>
    let _v4 = v17 
    #endif
#else
    let v20 : Async<int64> option = None
    let mutable _v20 = v20 
    async {
    try
    let v21 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v22 : System.IO.FileStream = null |> unbox<System.IO.FileStream>
    let _v21 = v22 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v25 : System.IO.FileStream = null |> unbox<System.IO.FileStream>
    let _v21 = v25 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v28 : System.IO.FileStream = null |> unbox<System.IO.FileStream>
    let _v21 = v28 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v31 : System.IO.FileStream = null |> unbox<System.IO.FileStream>
    let _v21 = v31 
    #endif
#if FABLE_COMPILER_PYTHON
    let v34 : System.IO.FileStream = null |> unbox<System.IO.FileStream>
    let _v21 = v34 
    #endif
#else
    let v37 : System.IO.FileMode = System.IO.FileMode.Open
    let v43 : System.IO.FileAccess =
        match v2 with
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
        match v1 with
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
    let v54 : System.IO.FileStream = new System.IO.FileStream (v0, v37, v43, v53)
    let _v21 = v54 
    #endif
    let v55 : System.IO.FileStream = _v21 
    use v55 = v55 
    let v60 : System.IO.FileStream = v55 
    return v3 
    with ex ->
    let v61 : exn = ex
    let v62 : bool = v3 > 0L
    let v65 : bool =
        if v62 then
            let v63 : int64 = v3 % 100L
            let v64 : bool = v63 = 0L
            v64
        else
            false
    if v65 then
        let v66 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v67 : string = $"%A{v61}"
        let _v66 = v67 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v70 : string = $"%A{v61}"
        let _v66 = v70 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v73 : string = $"%A{v61}"
        let _v66 = v73 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v76 : string = $"%A{v61}"
        let _v66 = v76 
        #endif
#if FABLE_COMPILER_PYTHON
        let v79 : string = $"%A{v61}"
        let _v66 = v79 
        #endif
#else
        let v82 : string = $"{v61.GetType ()}: {v61.Message}"
        let _v66 = v82 
        #endif
        let v83 : string = _v66 
        let v88 : unit = ()
        let v89 : (unit -> unit) = closure12(v0, v3, v83)
        let v90 : unit = (fun () -> v89 (); v88) ()
        ()
    let v203 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v204 : Async<unit> = null |> unbox<Async<unit>>
    let _v203 = v204 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v207 : Async<unit> = null |> unbox<Async<unit>>
    let _v203 = v207 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v210 : Async<unit> = null |> unbox<Async<unit>>
    let _v203 = v210 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v213 : Async<unit> = null |> unbox<Async<unit>>
    let _v203 = v213 
    #endif
#if FABLE_COMPILER_PYTHON
    let v216 : Async<unit> = null |> unbox<Async<unit>>
    let _v203 = v216 
    #endif
#else
    let v219 : (int32 -> Async<unit>) = Async.Sleep
    let v220 : Async<unit> = v219 10
    let _v203 = v220 
    #endif
    let v221 : Async<unit> = _v203 
    do! v221 
    let v226 : int64 = v3 + 1L
    let v227 : Async<int64> = method21(v0, v1, v2, v226)
    return! v227 
    (*
    let v228 : int64 = *)
    }
    |> fun x -> _v20 <- Some x
    let v229 : Async<int64> = match _v20 with Some x -> x | None -> failwith "async.new_async_unit / _v20=None"
    let _v4 = v229 
    #endif
    let v230 : Async<int64> = _v4 
    v230
and closure11 (v0 : US6) (v1 : string) : Async<int64> =
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
#else
    let struct (v24 : US7, v25 : US8) =
        match v0 with
        | US6_1 -> (* None *)
            let v20 : US7 = US7_2
            let v21 : US8 = US8_1
            struct (v20, v21)
        | US6_0(v18, v19) -> (* Some *)
            struct (v18, v19)
    let v26 : int64 = 0L
    let v27 : Async<int64> = method21(v1, v25, v24, v26)
    let _v2 = v27 
    #endif
    let v28 : Async<int64> = _v2 
    v28
and closure10 () (v0 : US6) : (string -> Async<int64>) =
    closure11(v0)
and method24 (v0 : string, v1 : int64) : Async<int64> =
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
#else
    let v18 : Async<int64> option = None
    let mutable _v18 = v18 
    async {
    try
    let v19 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v20 : System.IO.FileStream = null |> unbox<System.IO.FileStream>
    let _v19 = v20 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v23 : System.IO.FileStream = null |> unbox<System.IO.FileStream>
    let _v19 = v23 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v26 : System.IO.FileStream = null |> unbox<System.IO.FileStream>
    let _v19 = v26 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v29 : System.IO.FileStream = null |> unbox<System.IO.FileStream>
    let _v19 = v29 
    #endif
#if FABLE_COMPILER_PYTHON
    let v32 : System.IO.FileStream = null |> unbox<System.IO.FileStream>
    let _v19 = v32 
    #endif
#else
    let v35 : System.IO.FileMode = System.IO.FileMode.Open
    let v36 : System.IO.FileAccess = System.IO.FileAccess.Read
    let v37 : System.IO.FileShare = System.IO.FileShare.Read
    let v38 : System.IO.FileStream = new System.IO.FileStream (v0, v35, v36, v37)
    let _v19 = v38 
    #endif
    let v39 : System.IO.FileStream = _v19 
    use v39 = v39 
    let v44 : System.IO.FileStream = v39 
    return v1 
    with ex ->
    let v45 : exn = ex
    let v46 : bool = v1 > 0L
    let v49 : bool =
        if v46 then
            let v47 : int64 = v1 % 100L
            let v48 : bool = v47 = 0L
            v48
        else
            false
    if v49 then
        let v50 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v51 : string = $"%A{v45}"
        let _v50 = v51 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v54 : string = $"%A{v45}"
        let _v50 = v54 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v57 : string = $"%A{v45}"
        let _v50 = v57 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v60 : string = $"%A{v45}"
        let _v50 = v60 
        #endif
#if FABLE_COMPILER_PYTHON
        let v63 : string = $"%A{v45}"
        let _v50 = v63 
        #endif
#else
        let v66 : string = $"{v45.GetType ()}: {v45.Message}"
        let _v50 = v66 
        #endif
        let v67 : string = _v50 
        let v72 : unit = ()
        let v73 : (unit -> unit) = closure12(v0, v1, v67)
        let v74 : unit = (fun () -> v73 (); v72) ()
        ()
    let v187 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v188 : Async<unit> = null |> unbox<Async<unit>>
    let _v187 = v188 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v191 : Async<unit> = null |> unbox<Async<unit>>
    let _v187 = v191 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v194 : Async<unit> = null |> unbox<Async<unit>>
    let _v187 = v194 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v197 : Async<unit> = null |> unbox<Async<unit>>
    let _v187 = v197 
    #endif
#if FABLE_COMPILER_PYTHON
    let v200 : Async<unit> = null |> unbox<Async<unit>>
    let _v187 = v200 
    #endif
#else
    let v203 : (int32 -> Async<unit>) = Async.Sleep
    let v204 : Async<unit> = v203 10
    let _v187 = v204 
    #endif
    let v205 : Async<unit> = _v187 
    do! v205 
    let v210 : int64 = v1 + 1L
    let v211 : Async<int64> = method24(v0, v210)
    return! v211 
    (*
    let v212 : int64 = *)
    }
    |> fun x -> _v18 <- Some x
    let v213 : Async<int64> = match _v18 with Some x -> x | None -> failwith "async.new_async_unit / _v18=None"
    let _v2 = v213 
    #endif
    let v214 : Async<int64> = _v2 
    v214
and closure13 () (v0 : string) : Async<int64> =
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
#else
    let v17 : int64 = 0L
    let v18 : Async<int64> = method24(v0, v17)
    let _v1 = v18 
    #endif
    let v19 : Async<int64> = _v1 
    v19
and closure14 () (v0 : string) : Async<string> =
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
#else
    let v17 : (string -> System.Threading.Tasks.Task<string>) = System.IO.File.ReadAllTextAsync
    let v18 : System.Threading.Tasks.Task<string> = v17 v0
    let v19 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v20 : Async<string> = null |> unbox<Async<string>>
    let _v19 = v20 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v23 : Async<string> = null |> unbox<Async<string>>
    let _v19 = v23 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v26 : Async<string> = null |> unbox<Async<string>>
    let _v19 = v26 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v29 : Async<string> = null |> unbox<Async<string>>
    let _v19 = v29 
    #endif
#if FABLE_COMPILER_PYTHON
    let v32 : Async<string> = null |> unbox<Async<string>>
    let _v19 = v32 
    #endif
#else
    let v35 : (System.Threading.Tasks.Task<string> -> Async<string>) = Async.AwaitTask
    let v36 : Async<string> = v35 v18
    let _v19 = v36 
    #endif
    let v37 : Async<string> = _v19 
    let _v1 = v37 
    #endif
    let v42 : Async<string> = _v1 
    v42
and method26 (v0 : string) : bool =
    let v1 : unit = ()
    
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
    let _v1 = v12 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v13 : bool = null |> unbox<bool>
    let _v1 = v13 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v16 : bool = null |> unbox<bool>
    let _v1 = v16 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v19 : string = "fs"
    let v20 : IFsExistsSync = Fable.Core.JsInterop.importAll v19 
    let v21 : string = "$0.existsSync($1)"
    let v22 : bool = Fable.Core.JsInterop.emitJsExpr struct (v20, v0) v21 
    let _v1 = v22 
    #endif
#if FABLE_COMPILER_PYTHON
    let v23 : bool = null |> unbox<bool>
    let _v1 = v23 
    #endif
#else
    let v26 : (string -> bool) = System.IO.File.Exists
    let v27 : bool = v26 v0
    let _v1 = v27 
    #endif
    let v28 : bool = _v1 
    v28
and method27 (v0 : Vec<uint8>) : Vec<uint8> =
    v0
and method25 (v0 : string, v1 : string) : bool =
    let v2 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : bool = method26(v0)
    let v4 : bool = v3 = false
    let v57 : bool =
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
            let v9 : string = "$0.unwrap()"
            let v10 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v8 v9 
            let _v6 = v10 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v11 : Vec<uint8> = null |> unbox<Vec<uint8>>
            let _v6 = v11 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v14 : Vec<uint8> = null |> unbox<Vec<uint8>>
            let _v6 = v14 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v17 : Vec<uint8> = null |> unbox<Vec<uint8>>
            let _v6 = v17 
            #endif
#if FABLE_COMPILER_PYTHON
            let v20 : Vec<uint8> = null |> unbox<Vec<uint8>>
            let _v6 = v20 
            #endif
#else
            let v23 : (uint8 []) = v0 |> System.IO.File.ReadAllBytes
            let v24 : string = "$0.to_vec()"
            let v25 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v23 v24 
            let _v6 = v25 
            #endif
            let v26 : Vec<uint8> = _v6 
            let v31 : Vec<uint8> = method27(v26)
            let v32 : string = "std::string::String::from_utf8($0)"
            let v33 : Result<std_string_String, std_string_FromUtf8Error> = Fable.Core.RustInterop.emitRustExpr v31 v32 
            let v34 : string = "$0.unwrap()"
            let v35 : std_string_String = Fable.Core.RustInterop.emitRustExpr v33 v34 
            let v36 : string = "fable_library_rust::String_::fromString($0)"
            let v37 : string = Fable.Core.RustInterop.emitRustExpr v35 v36 
            let _v5 = v37 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v38 : string = null |> unbox<string>
            let _v5 = v38 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v41 : string = null |> unbox<string>
            let _v5 = v41 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v44 : string = null |> unbox<string>
            let _v5 = v44 
            #endif
#if FABLE_COMPILER_PYTHON
            let v47 : string = null |> unbox<string>
            let _v5 = v47 
            #endif
#else
            let v50 : string = v0 |> System.IO.File.ReadAllText
            let _v5 = v50 
            #endif
            let v51 : string = _v5 
            let v56 : bool = v1 = v51
            v56
    let _v2 = v57 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v58 : bool = null |> unbox<bool>
    let _v2 = v58 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v61 : bool = null |> unbox<bool>
    let _v2 = v61 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v64 : bool = null |> unbox<bool>
    let _v2 = v64 
    #endif
#if FABLE_COMPILER_PYTHON
    let v67 : bool = null |> unbox<bool>
    let _v2 = v67 
    #endif
#else
    let v70 : bool = null |> unbox<bool>
    let _v2 = v70 
    #endif
    let v73 : bool = _v2 
    v73
and closure16 (v0 : string) (v1 : string) : bool =
    method25(v0, v1)
and closure15 () (v0 : string) : (string -> bool) =
    closure16(v0)
and closure18 (v0 : string) (v1 : string) : Async<unit> =
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
#else
    let v18 : System.Threading.Tasks.Task = System.IO.File.WriteAllTextAsync (v0, v1)
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
    let v29 : Async<unit> = null |> unbox<Async<unit>>
    let _v19 = v29 
    #endif
#if FABLE_COMPILER_PYTHON
    let v32 : Async<unit> = null |> unbox<Async<unit>>
    let _v19 = v32 
    #endif
#else
    let v35 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
    let v36 : Async<unit> = v35 v18
    let _v19 = v36 
    #endif
    let v37 : Async<unit> = _v19 
    let _v2 = v37 
    #endif
    let v42 : Async<unit> = _v2 
    v42
and closure17 () (v0 : string) : (string -> Async<unit>) =
    closure18(v0)
and closure20 (v0 : string) (v1 : string) : Async<unit> =
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
#else
    let v18 : Async<unit> option = None
    let mutable _v18 = v18 
    async {
    let v19 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v20 : Async<bool> = null |> unbox<Async<bool>>
    let _v19 = v20 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v23 : Async<bool> = null |> unbox<Async<bool>>
    let _v19 = v23 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v26 : Async<bool> = null |> unbox<Async<bool>>
    let _v19 = v26 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v29 : Async<bool> = null |> unbox<Async<bool>>
    let _v19 = v29 
    #endif
#if FABLE_COMPILER_PYTHON
    let v32 : Async<bool> = null |> unbox<Async<bool>>
    let _v19 = v32 
    #endif
#else
    let v35 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v36 : Async<bool> = null |> unbox<Async<bool>>
    let _v35 = v36 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v39 : Async<bool> = null |> unbox<Async<bool>>
    let _v35 = v39 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v42 : Async<bool> = null |> unbox<Async<bool>>
    let _v35 = v42 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v45 : Async<bool> = null |> unbox<Async<bool>>
    let _v35 = v45 
    #endif
#if FABLE_COMPILER_PYTHON
    let v48 : Async<bool> = null |> unbox<Async<bool>>
    let _v35 = v48 
    #endif
#else
    let v51 : Async<bool> option = None
    let mutable _v51 = v51 
    async {
    let v52 : bool = method26(v0)
    let v53 : bool = v52 = false
    if v53 then
        return false 
        (*
        ()
    else
        *) else
        let v54 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v55 : Async<string> = null |> unbox<Async<string>>
        let _v54 = v55 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v58 : Async<string> = null |> unbox<Async<string>>
        let _v54 = v58 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v61 : Async<string> = null |> unbox<Async<string>>
        let _v54 = v61 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v64 : Async<string> = null |> unbox<Async<string>>
        let _v54 = v64 
        #endif
#if FABLE_COMPILER_PYTHON
        let v67 : Async<string> = null |> unbox<Async<string>>
        let _v54 = v67 
        #endif
#else
        let v70 : (string -> System.Threading.Tasks.Task<string>) = System.IO.File.ReadAllTextAsync
        let v71 : System.Threading.Tasks.Task<string> = v70 v0
        let v72 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v73 : Async<string> = null |> unbox<Async<string>>
        let _v72 = v73 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v76 : Async<string> = null |> unbox<Async<string>>
        let _v72 = v76 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v79 : Async<string> = null |> unbox<Async<string>>
        let _v72 = v79 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v82 : Async<string> = null |> unbox<Async<string>>
        let _v72 = v82 
        #endif
#if FABLE_COMPILER_PYTHON
        let v85 : Async<string> = null |> unbox<Async<string>>
        let _v72 = v85 
        #endif
#else
        let v88 : (System.Threading.Tasks.Task<string> -> Async<string>) = Async.AwaitTask
        let v89 : Async<string> = v88 v71
        let _v72 = v89 
        #endif
        let v90 : Async<string> = _v72 
        let _v54 = v90 
        #endif
        let v95 : Async<string> = _v54 
        let! v95 = v95 
        let v100 : string = v95 
        let v101 : bool = v1 = v100
        return v101 
        (*
        ()
    *)
    }
    |> fun x -> _v51 <- Some x
    let v102 : Async<bool> = match _v51 with Some x -> x | None -> failwith "async.new_async_unit / _v51=None"
    let _v35 = v102 
    #endif
    let v103 : Async<bool> = _v35 
    let _v19 = v103 
    #endif
    let v108 : Async<bool> = _v19 
    let! v108 = v108 
    let v113 : bool = v108 
    let v114 : bool = v113 = false
    if v114 then
        let v115 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v116 : Async<unit> = null |> unbox<Async<unit>>
        let _v115 = v116 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v119 : Async<unit> = null |> unbox<Async<unit>>
        let _v115 = v119 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v122 : Async<unit> = null |> unbox<Async<unit>>
        let _v115 = v122 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v125 : Async<unit> = null |> unbox<Async<unit>>
        let _v115 = v125 
        #endif
#if FABLE_COMPILER_PYTHON
        let v128 : Async<unit> = null |> unbox<Async<unit>>
        let _v115 = v128 
        #endif
#else
        let v131 : System.Threading.Tasks.Task = System.IO.File.WriteAllTextAsync (v0, v1)
        let v132 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v133 : Async<unit> = null |> unbox<Async<unit>>
        let _v132 = v133 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v136 : Async<unit> = null |> unbox<Async<unit>>
        let _v132 = v136 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v139 : Async<unit> = null |> unbox<Async<unit>>
        let _v132 = v139 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v142 : Async<unit> = null |> unbox<Async<unit>>
        let _v132 = v142 
        #endif
#if FABLE_COMPILER_PYTHON
        let v145 : Async<unit> = null |> unbox<Async<unit>>
        let _v132 = v145 
        #endif
#else
        let v148 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
        let v149 : Async<unit> = v148 v131
        let _v132 = v149 
        #endif
        let v150 : Async<unit> = _v132 
        let _v115 = v150 
        #endif
        let v155 : Async<unit> = _v115 
        do! v155 
        ()
    ()
    }
    |> fun x -> _v18 <- Some x
    let v160 : Async<unit> = match _v18 with Some x -> x | None -> failwith "async.new_async_unit / _v18=None"
    let _v2 = v160 
    #endif
    let v161 : Async<unit> = _v2 
    v161
and closure19 () (v0 : string) : (string -> Async<unit>) =
    closure20(v0)
and method29 () : string =
    
    
    
    
    
    let v0 : string = "Warning"
    let v1 : (unit -> string) = v0.ToLower
    let v2 : string = v1 ()
    let v5 : string = v2.PadLeft (7, ' ')
    let v19 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v20 : string = "inline_colorization::color_yellow"
    let v21 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v20 
    let v22 : string = "&*$0"
    let v23 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v22 
    let v24 : string = "inline_colorization::color_reset"
    let v25 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v24 
    let v26 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v27 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v21, v23, v25) v26 
    let v28 : string = "fable_library_rust::String_::fromString($0)"
    let v29 : string = Fable.Core.RustInterop.emitRustExpr v27 v28 
    let _v19 = v29 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v30 : string = "inline_colorization::color_yellow"
    let v31 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v30 
    let v32 : string = "&*$0"
    let v33 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v32 
    let v34 : string = "inline_colorization::color_reset"
    let v35 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v34 
    let v36 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v37 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v31, v33, v35) v36 
    let v38 : string = "fable_library_rust::String_::fromString($0)"
    let v39 : string = Fable.Core.RustInterop.emitRustExpr v37 v38 
    let _v19 = v39 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v40 : string = "inline_colorization::color_yellow"
    let v41 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v40 
    let v42 : string = "&*$0"
    let v43 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v42 
    let v44 : string = "inline_colorization::color_reset"
    let v45 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v44 
    let v46 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v47 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v41, v43, v45) v46 
    let v48 : string = "fable_library_rust::String_::fromString($0)"
    let v49 : string = Fable.Core.RustInterop.emitRustExpr v47 v48 
    let _v19 = v49 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v50 : string = "\u001b[93m"
    let v51 : string = method15()
    let v52 : string = v50 + v5 
    let v53 : string = v52 + v51 
    let _v19 = v53 
    #endif
#if FABLE_COMPILER_PYTHON
    let v54 : string = "\u001b[93m"
    let v55 : string = method15()
    let v56 : string = v54 + v5 
    let v57 : string = v56 + v55 
    let _v19 = v57 
    #endif
#else
    let v58 : string = "\u001b[93m"
    let v59 : string = method15()
    let v60 : string = v58 + v5 
    let v61 : string = v60 + v59 
    let _v19 = v61 
    #endif
    let v62 : string = _v19 
    v62
and method30 (v0 : string, v1 : string) : string =
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
and method31 (v0 : string, v1 : string, v2 : int64, v3 : string) : string =
    let v4 : string = "delete_file_async"
    let v5 : string = $"{v0} {v1} #{v2} %s{v4} / {v3}"
    let v8 : char list = []
    let v9 : (char list -> (char [])) = List.toArray
    let v10 : (char []) = v9 v8
    let v13 : string = v5.TrimStart v10 
    let v31 : char list = []
    let v32 : char list = '/' :: v31 
    let v35 : char list = ' ' :: v32 
    let v38 : (char list -> (char [])) = List.toArray
    let v39 : (char []) = v38 v35
    let v42 : string = v13.TrimEnd v39 
    v42
and closure22 (v0 : string, v1 : exn) () : unit =
    let v2 : unit = ()
    let v3 : (unit -> unit) = closure0()
    let v4 : unit = (fun () -> v3 (); v2) ()
    let struct (v18 : Mut0, v19 : Mut1, v20 : Mut2, v21 : Mut3, v22 : Mut4, v23 : int64 option) = TraceState.trace_state.Value
    let v36 : US0 = v22.l0
    let v37 : bool = v20.l0
    let v38 : bool = v37 = false
    let v41 : bool =
        if v38 then
            false
        else
            let v39 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v36
            let v40 : bool = 3 >= v39
            v40
    if v41 then
        let v42 : unit = ()
        let v43 : unit = (fun () -> v3 (); v42) ()
        let struct (v57 : Mut0, v58 : Mut1, v59 : Mut2, v60 : Mut3, v61 : Mut4, v62 : int64 option) = TraceState.trace_state.Value
        let v75 : string = method10(v57, v58, v59, v60, v61, v62)
        let v76 : string = method29()
        let v77 : int64 = v57.l0
        let v78 : string = method16(v0)
        let v79 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v80 : string = $"%A{v1}"
        let _v79 = v80 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v83 : string = $"%A{v1}"
        let _v79 = v83 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v86 : string = $"%A{v1}"
        let _v79 = v86 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v89 : string = $"%A{v1}"
        let _v79 = v89 
        #endif
#if FABLE_COMPILER_PYTHON
        let v92 : string = $"%A{v1}"
        let _v79 = v92 
        #endif
#else
        let v95 : string = $"{v1.GetType ()}: {v1.Message}"
        let _v79 = v95 
        #endif
        let v96 : string = _v79 
        let v101 : string = method30(v78, v96)
        let v102 : string = method31(v75, v76, v77, v101)
        let v103 : unit = ()
        let v104 : unit = (fun () -> v3 (); v103) ()
        let struct (v118 : Mut0, v119 : Mut1, v120 : Mut2, v121 : Mut3, v122 : Mut4, v123 : int64 option) = TraceState.trace_state.Value
        method20(v102, v118, v119, v120, v121, v122, v123)
and method28 (v0 : string, v1 : int64) : Async<int64> =
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
#else
    let v18 : Async<int64> option = None
    let mutable _v18 = v18 
    async {
    try
    let v19 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v20 : string = "std::fs::remove_file(&*$0).unwrap()"
    Fable.Core.RustInterop.emitRustExpr v0 v20 
    let _v19 = () 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let _v19 = () 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let _v19 = () 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let _v19 = () 
    #endif
#if FABLE_COMPILER_PYTHON
    let _v19 = () 
    #endif
#else
    let v21 : (string -> unit) = System.IO.File.Delete
    v21 v0
    let _v19 = () 
    #endif
    _v19 
    return v1 
    with ex ->
    let v22 : exn = ex
    let v23 : int64 = v1 % 100L
    let v24 : bool = v23 = 0L
    if v24 then
        let v25 : unit = ()
        let v26 : (unit -> unit) = closure22(v0, v22)
        let v27 : unit = (fun () -> v26 (); v25) ()
        ()
    let v162 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v163 : Async<unit> = null |> unbox<Async<unit>>
    let _v162 = v163 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v166 : Async<unit> = null |> unbox<Async<unit>>
    let _v162 = v166 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v169 : Async<unit> = null |> unbox<Async<unit>>
    let _v162 = v169 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v172 : Async<unit> = null |> unbox<Async<unit>>
    let _v162 = v172 
    #endif
#if FABLE_COMPILER_PYTHON
    let v175 : Async<unit> = null |> unbox<Async<unit>>
    let _v162 = v175 
    #endif
#else
    let v178 : (int32 -> Async<unit>) = Async.Sleep
    let v179 : Async<unit> = v178 10
    let _v162 = v179 
    #endif
    let v180 : Async<unit> = _v162 
    do! v180 
    let v185 : int64 = v1 + 1L
    let v186 : Async<int64> = method28(v0, v185)
    return! v186 
    (*
    let v187 : int64 = *)
    }
    |> fun x -> _v18 <- Some x
    let v188 : Async<int64> = match _v18 with Some x -> x | None -> failwith "async.new_async_unit / _v18=None"
    let _v2 = v188 
    #endif
    let v189 : Async<int64> = _v2 
    v189
and closure21 () (v0 : string) : Async<int64> =
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
#else
    let v17 : int64 = 0L
    let v18 : Async<int64> = method28(v0, v17)
    let _v1 = v18 
    #endif
    let v19 : Async<int64> = _v1 
    v19
and method33 (v0 : string, v1 : string, v2 : exn) : string =
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
#else
    let v118 : string = $"%A{v2}"
    let _v99 = v118 
    #endif
    let v121 : string = _v99 
    let v126 : string = $"{v121}"
    let v129 : unit = ()
    let v130 : (unit -> unit) = closure6(v4, v126)
    let v131 : unit = (fun () -> v130 (); v129) ()
    let v134 : string = " }"
    let v135 : string = $"{v134}"
    let v138 : unit = ()
    let v139 : (unit -> unit) = closure6(v4, v135)
    let v140 : unit = (fun () -> v139 (); v138) ()
    let v143 : string = v4.l0
    v143
and method34 (v0 : string, v1 : string, v2 : int64, v3 : string) : string =
    let v4 : string = "move_file_async"
    let v5 : string = $"{v0} {v1} #{v2} %s{v4} / {v3}"
    let v8 : char list = []
    let v9 : (char list -> (char [])) = List.toArray
    let v10 : (char []) = v9 v8
    let v13 : string = v5.TrimStart v10 
    let v31 : char list = []
    let v32 : char list = '/' :: v31 
    let v35 : char list = ' ' :: v32 
    let v38 : (char list -> (char [])) = List.toArray
    let v39 : (char []) = v38 v35
    let v42 : string = v13.TrimEnd v39 
    v42
and closure25 (v0 : string, v1 : string, v2 : exn) () : unit =
    let v3 : unit = ()
    let v4 : (unit -> unit) = closure0()
    let v5 : unit = (fun () -> v4 (); v3) ()
    let struct (v19 : Mut0, v20 : Mut1, v21 : Mut2, v22 : Mut3, v23 : Mut4, v24 : int64 option) = TraceState.trace_state.Value
    let v37 : US0 = v23.l0
    let v38 : bool = v21.l0
    let v39 : bool = v38 = false
    let v42 : bool =
        if v39 then
            false
        else
            let v40 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v37
            let v41 : bool = 3 >= v40
            v41
    if v42 then
        let v43 : unit = ()
        let v44 : unit = (fun () -> v4 (); v43) ()
        let struct (v58 : Mut0, v59 : Mut1, v60 : Mut2, v61 : Mut3, v62 : Mut4, v63 : int64 option) = TraceState.trace_state.Value
        let v76 : string = method10(v58, v59, v60, v61, v62, v63)
        let v77 : string = method29()
        let v78 : int64 = v58.l0
        let v79 : string = method16(v1)
        let v80 : string = method16(v0)
        let v81 : string = method33(v79, v80, v2)
        let v82 : string = method34(v76, v77, v78, v81)
        let v83 : unit = ()
        let v84 : unit = (fun () -> v4 (); v83) ()
        let struct (v98 : Mut0, v99 : Mut1, v100 : Mut2, v101 : Mut3, v102 : Mut4, v103 : int64 option) = TraceState.trace_state.Value
        method20(v82, v98, v99, v100, v101, v102, v103)
and method32 (v0 : string, v1 : string, v2 : int64) : Async<int64> =
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
#else
    let v19 : Async<int64> option = None
    let mutable _v19 = v19 
    async {
    try
    let v20 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let _v20 = () 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let _v20 = () 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let _v20 = () 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let _v20 = () 
    #endif
#if FABLE_COMPILER_PYTHON
    let _v20 = () 
    #endif
#else
    System.IO.File.Move (v1, v0)
    let _v20 = () 
    #endif
    _v20 
    return v2 
    with ex ->
    let v21 : exn = ex
    let v22 : int64 = v2 % 100L
    let v23 : bool = v22 = 0L
    if v23 then
        let v24 : unit = ()
        let v25 : (unit -> unit) = closure25(v0, v1, v21)
        let v26 : unit = (fun () -> v25 (); v24) ()
        ()
    let v140 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v141 : Async<unit> = null |> unbox<Async<unit>>
    let _v140 = v141 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v144 : Async<unit> = null |> unbox<Async<unit>>
    let _v140 = v144 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v147 : Async<unit> = null |> unbox<Async<unit>>
    let _v140 = v147 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v150 : Async<unit> = null |> unbox<Async<unit>>
    let _v140 = v150 
    #endif
#if FABLE_COMPILER_PYTHON
    let v153 : Async<unit> = null |> unbox<Async<unit>>
    let _v140 = v153 
    #endif
#else
    let v156 : (int32 -> Async<unit>) = Async.Sleep
    let v157 : Async<unit> = v156 10
    let _v140 = v157 
    #endif
    let v158 : Async<unit> = _v140 
    do! v158 
    let v163 : int64 = v2 + 1L
    let v164 : Async<int64> = method32(v0, v1, v163)
    return! v164 
    (*
    *)
    }
    |> fun x -> _v19 <- Some x
    let v165 : Async<int64> = match _v19 with Some x -> x | None -> failwith "async.new_async_unit / _v19=None"
    let _v3 = v165 
    #endif
    let v166 : Async<int64> = _v3 
    v166
and closure24 (v0 : string) (v1 : string) : Async<int64> =
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
#else
    let v18 : int64 = 0L
    let v19 : Async<int64> = method32(v0, v1, v18)
    let _v2 = v19 
    #endif
    let v20 : Async<int64> = _v2 
    v20
and closure23 () (v0 : string) : (string -> Async<int64>) =
    closure24(v0)
and closure27 () (v0 : int64) : US9 =
    US9_0(v0)
and closure28 () (v0 : exn) : US9 =
    US9_1(v0)
and method36 () : string =
    
    
    
    
    
    let v0 : string = "Verbose"
    let v1 : (unit -> string) = v0.ToLower
    let v2 : string = v1 ()
    let v5 : string = v2.PadLeft (7, ' ')
    let v19 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v20 : string = "inline_colorization::color_bright_black"
    let v21 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v20 
    let v22 : string = "&*$0"
    let v23 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v22 
    let v24 : string = "inline_colorization::color_reset"
    let v25 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v24 
    let v26 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v27 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v21, v23, v25) v26 
    let v28 : string = "fable_library_rust::String_::fromString($0)"
    let v29 : string = Fable.Core.RustInterop.emitRustExpr v27 v28 
    let _v19 = v29 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v30 : string = "inline_colorization::color_bright_black"
    let v31 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v30 
    let v32 : string = "&*$0"
    let v33 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v32 
    let v34 : string = "inline_colorization::color_reset"
    let v35 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v34 
    let v36 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v37 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v31, v33, v35) v36 
    let v38 : string = "fable_library_rust::String_::fromString($0)"
    let v39 : string = Fable.Core.RustInterop.emitRustExpr v37 v38 
    let _v19 = v39 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v40 : string = "inline_colorization::color_bright_black"
    let v41 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v40 
    let v42 : string = "&*$0"
    let v43 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v42 
    let v44 : string = "inline_colorization::color_reset"
    let v45 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v44 
    let v46 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v47 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v41, v43, v45) v46 
    let v48 : string = "fable_library_rust::String_::fromString($0)"
    let v49 : string = Fable.Core.RustInterop.emitRustExpr v47 v48 
    let _v19 = v49 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v50 : string = "\u001b[90m"
    let v51 : string = method15()
    let v52 : string = v50 + v5 
    let v53 : string = v52 + v51 
    let _v19 = v53 
    #endif
#if FABLE_COMPILER_PYTHON
    let v54 : string = "\u001b[90m"
    let v55 : string = method15()
    let v56 : string = v54 + v5 
    let v57 : string = v56 + v55 
    let _v19 = v57 
    #endif
#else
    let v58 : string = "\u001b[90m"
    let v59 : string = method15()
    let v60 : string = v58 + v5 
    let v61 : string = v60 + v59 
    let _v19 = v61 
    #endif
    let v62 : string = _v19 
    v62
and method37 (v0 : int32) : string =
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
and method38 (v0 : string, v1 : string, v2 : string, v3 : int64, v4 : string) : string =
    let v5 : string = $"{v0} {v1} #{v3} %s{v2} / {v4}"
    let v8 : char list = []
    let v9 : (char list -> (char [])) = List.toArray
    let v10 : (char []) = v9 v8
    let v13 : string = v5.TrimStart v10 
    let v31 : char list = []
    let v32 : char list = '/' :: v31 
    let v35 : char list = ' ' :: v32 
    let v38 : (char list -> (char [])) = List.toArray
    let v39 : (char []) = v38 v35
    let v42 : string = v13.TrimEnd v39 
    v42
and closure29 () () : unit =
    let v0 : unit = ()
    let v1 : (unit -> unit) = closure0()
    let v2 : unit = (fun () -> v1 (); v0) ()
    let struct (v16 : Mut0, v17 : Mut1, v18 : Mut2, v19 : Mut3, v20 : Mut4, v21 : int64 option) = TraceState.trace_state.Value
    let v34 : US0 = v20.l0
    let v35 : bool = v18.l0
    let v36 : bool = v35 = false
    let v39 : bool =
        if v36 then
            false
        else
            let v37 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v34
            let v38 : bool = 0 >= v37
            v38
    if v39 then
        let v40 : unit = ()
        let v41 : unit = (fun () -> v1 (); v40) ()
        let struct (v55 : Mut0, v56 : Mut1, v57 : Mut2, v58 : Mut3, v59 : Mut4, v60 : int64 option) = TraceState.trace_state.Value
        let v73 : string = method10(v55, v56, v57, v58, v59, v60)
        let v74 : string = method36()
        let v75 : string = "async.run_with_timeout_async"
        let v76 : bool = v75 = ""
        let v82 : string =
            if v76 then
                let v77 : string = ""
                v77
            else
                let v78 : int64 = v55.l0
                let v79 : int32 = 1000
                let v80 : string = method37(v79)
                method38(v73, v74, v75, v78, v80)
        let v83 : unit = ()
        let v84 : unit = (fun () -> v1 (); v83) ()
        let struct (v98 : Mut0, v99 : Mut1, v100 : Mut2, v101 : Mut3, v102 : Mut4, v103 : int64 option) = TraceState.trace_state.Value
        method20(v82, v98, v99, v100, v101, v102, v103)
and method39 () : string =
    
    
    
    
    
    let v0 : string = "Critical"
    let v1 : (unit -> string) = v0.ToLower
    let v2 : string = v1 ()
    let v5 : string = v2.PadLeft (7, ' ')
    let v19 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v20 : string = "inline_colorization::color_bright_red"
    let v21 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v20 
    let v22 : string = "&*$0"
    let v23 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v22 
    let v24 : string = "inline_colorization::color_reset"
    let v25 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v24 
    let v26 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v27 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v21, v23, v25) v26 
    let v28 : string = "fable_library_rust::String_::fromString($0)"
    let v29 : string = Fable.Core.RustInterop.emitRustExpr v27 v28 
    let _v19 = v29 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v30 : string = "inline_colorization::color_bright_red"
    let v31 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v30 
    let v32 : string = "&*$0"
    let v33 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v32 
    let v34 : string = "inline_colorization::color_reset"
    let v35 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v34 
    let v36 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v37 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v31, v33, v35) v36 
    let v38 : string = "fable_library_rust::String_::fromString($0)"
    let v39 : string = Fable.Core.RustInterop.emitRustExpr v37 v38 
    let _v19 = v39 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v40 : string = "inline_colorization::color_bright_red"
    let v41 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v40 
    let v42 : string = "&*$0"
    let v43 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v42 
    let v44 : string = "inline_colorization::color_reset"
    let v45 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v44 
    let v46 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v47 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v41, v43, v45) v46 
    let v48 : string = "fable_library_rust::String_::fromString($0)"
    let v49 : string = Fable.Core.RustInterop.emitRustExpr v47 v48 
    let _v19 = v49 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v50 : string = "\u001b[91m"
    let v51 : string = method15()
    let v52 : string = v50 + v5 
    let v53 : string = v52 + v51 
    let _v19 = v53 
    #endif
#if FABLE_COMPILER_PYTHON
    let v54 : string = "\u001b[91m"
    let v55 : string = method15()
    let v56 : string = v54 + v5 
    let v57 : string = v56 + v55 
    let _v19 = v57 
    #endif
#else
    let v58 : string = "\u001b[91m"
    let v59 : string = method15()
    let v60 : string = v58 + v5 
    let v61 : string = v60 + v59 
    let _v19 = v61 
    #endif
    let v62 : string = _v19 
    v62
and method40 (v0 : int32, v1 : string) : string =
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
and closure30 (v0 : exn) () : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure0()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v17 : Mut0, v18 : Mut1, v19 : Mut2, v20 : Mut3, v21 : Mut4, v22 : int64 option) = TraceState.trace_state.Value
    let v35 : US0 = v21.l0
    let v36 : bool = v19.l0
    let v37 : bool = v36 = false
    let v40 : bool =
        if v37 then
            false
        else
            let v38 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v35
            let v39 : bool = 4 >= v38
            v39
    if v40 then
        let v41 : unit = ()
        let v42 : unit = (fun () -> v2 (); v41) ()
        let struct (v56 : Mut0, v57 : Mut1, v58 : Mut2, v59 : Mut3, v60 : Mut4, v61 : int64 option) = TraceState.trace_state.Value
        let v74 : string = method10(v56, v57, v58, v59, v60, v61)
        let v75 : string = method39()
        let v76 : string = $"async.run_with_timeout_async**"
        let v77 : bool = v76 = ""
        let v105 : string =
            if v77 then
                let v78 : string = ""
                v78
            else
                let v79 : int64 = v56.l0
                let v80 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v81 : string = $"%A{v0}"
                let _v80 = v81 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v84 : string = $"%A{v0}"
                let _v80 = v84 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v87 : string = $"%A{v0}"
                let _v80 = v87 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v90 : string = $"%A{v0}"
                let _v80 = v90 
                #endif
#if FABLE_COMPILER_PYTHON
                let v93 : string = $"%A{v0}"
                let _v80 = v93 
                #endif
#else
                let v96 : string = $"{v0.GetType ()}: {v0.Message}"
                let _v80 = v96 
                #endif
                let v97 : string = _v80 
                let v102 : int32 = 1000
                let v103 : string = method40(v102, v97)
                method38(v74, v75, v76, v79, v103)
        let v106 : unit = ()
        let v107 : unit = (fun () -> v2 (); v106) ()
        let struct (v121 : Mut0, v122 : Mut1, v123 : Mut2, v124 : Mut3, v125 : Mut4, v126 : int64 option) = TraceState.trace_state.Value
        method20(v105, v121, v122, v123, v124, v125, v126)
and method41 (v0 : int64, v1 : string) : string =
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
and closure31 (v0 : int64, v1 : string) () : unit =
    let v2 : unit = ()
    let v3 : (unit -> unit) = closure0()
    let v4 : unit = (fun () -> v3 (); v2) ()
    let struct (v18 : Mut0, v19 : Mut1, v20 : Mut2, v21 : Mut3, v22 : Mut4, v23 : int64 option) = TraceState.trace_state.Value
    let v36 : US0 = v22.l0
    let v37 : bool = v20.l0
    let v38 : bool = v37 = false
    let v41 : bool =
        if v38 then
            false
        else
            let v39 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v36
            let v40 : bool = 1 >= v39
            v40
    if v41 then
        let v42 : unit = ()
        let v43 : unit = (fun () -> v3 (); v42) ()
        let struct (v57 : Mut0, v58 : Mut1, v59 : Mut2, v60 : Mut3, v61 : Mut4, v62 : int64 option) = TraceState.trace_state.Value
        let v75 : string = method10(v57, v58, v59, v60, v61, v62)
        let v76 : string = method14()
        let v77 : string = "read_all_text_retry_async"
        let v78 : bool = v77 = ""
        let v83 : string =
            if v78 then
                let v79 : string = ""
                v79
            else
                let v80 : int64 = v57.l0
                let v81 : string = method41(v0, v1)
                method38(v75, v76, v77, v80, v81)
        let v84 : unit = ()
        let v85 : unit = (fun () -> v3 (); v84) ()
        let struct (v99 : Mut0, v100 : Mut1, v101 : Mut2, v102 : Mut3, v103 : Mut4, v104 : int64 option) = TraceState.trace_state.Value
        method20(v83, v99, v100, v101, v102, v103, v104)
and method35 (v0 : string, v1 : int64) : Async<string option> =
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
    let v12 : Async<string option> = null |> unbox<Async<string option>>
    let _v2 = v12 
    #endif
#if FABLE_COMPILER_PYTHON
    let v15 : Async<string option> = null |> unbox<Async<string option>>
    let _v2 = v15 
    #endif
#else
    let v18 : Async<string option> option = None
    let mutable _v18 = v18 
    async {
    try
    let v19 : bool = v1 > 0L
    if v19 then
        let v20 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v21 : Async<int64> = null |> unbox<Async<int64>>
        let _v20 = v21 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v24 : Async<int64> = null |> unbox<Async<int64>>
        let _v20 = v24 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v27 : Async<int64> = null |> unbox<Async<int64>>
        let _v20 = v27 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v30 : Async<int64> = null |> unbox<Async<int64>>
        let _v20 = v30 
        #endif
#if FABLE_COMPILER_PYTHON
        let v33 : Async<int64> = null |> unbox<Async<int64>>
        let _v20 = v33 
        #endif
#else
        let v36 : int64 = 0L
        let v37 : Async<int64> = method24(v0, v36)
        let _v20 = v37 
        #endif
        let v38 : Async<int64> = _v20 
        let v43 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v44 : Async<US3> = null |> unbox<Async<US3>>
        let _v43 = v44 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v47 : Async<US3> = null |> unbox<Async<US3>>
        let _v43 = v47 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v50 : Async<US3> = null |> unbox<Async<US3>>
        let _v43 = v50 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v53 : Async<US3> = null |> unbox<Async<US3>>
        let _v43 = v53 
        #endif
#if FABLE_COMPILER_PYTHON
        let v56 : Async<US3> = null |> unbox<Async<US3>>
        let _v43 = v56 
        #endif
#else
        let v59 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v60 : Async<US3> = null |> unbox<Async<US3>>
        let _v59 = v60 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v63 : Async<US3> = null |> unbox<Async<US3>>
        let _v59 = v63 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v66 : Async<US3> = null |> unbox<Async<US3>>
        let _v59 = v66 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v69 : Async<US3> = null |> unbox<Async<US3>>
        let _v59 = v69 
        #endif
#if FABLE_COMPILER_PYTHON
        let v72 : Async<US3> = null |> unbox<Async<US3>>
        let _v59 = v72 
        #endif
#else
        let v75 : Async<US3> option = None
        let mutable _v75 = v75 
        async {
        let v76 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v77 : Async<Async<int64>> = null |> unbox<Async<Async<int64>>>
        let _v76 = v77 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v80 : Async<Async<int64>> = null |> unbox<Async<Async<int64>>>
        let _v76 = v80 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v83 : Async<Async<int64>> = null |> unbox<Async<Async<int64>>>
        let _v76 = v83 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v86 : Async<Async<int64>> = null |> unbox<Async<Async<int64>>>
        let _v76 = v86 
        #endif
#if FABLE_COMPILER_PYTHON
        let v89 : Async<Async<int64>> = null |> unbox<Async<Async<int64>>>
        let _v76 = v89 
        #endif
#else
        let v92 : Async<Async<int64>> = Async.StartChild (v38, 1000)
        let _v76 = v92 
        #endif
        let v93 : Async<Async<int64>> = _v76 
        let! v93 = v93 
        let v98 : Async<int64> = v93 
        let v99 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v100 : Async<Choice<int64, exn>> = null |> unbox<Async<Choice<int64, exn>>>
        let _v99 = v100 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v103 : Async<Choice<int64, exn>> = null |> unbox<Async<Choice<int64, exn>>>
        let _v99 = v103 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v106 : Async<Choice<int64, exn>> = null |> unbox<Async<Choice<int64, exn>>>
        let _v99 = v106 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v109 : Async<Choice<int64, exn>> = null |> unbox<Async<Choice<int64, exn>>>
        let _v99 = v109 
        #endif
#if FABLE_COMPILER_PYTHON
        let v112 : Async<Choice<int64, exn>> = null |> unbox<Async<Choice<int64, exn>>>
        let _v99 = v112 
        #endif
#else
        let v115 : (Async<int64> -> Async<Choice<int64, exn>>) = Async.Catch
        let v116 : Async<Choice<int64, exn>> = v115 v98
        let _v99 = v116 
        #endif
        let v117 : Async<Choice<int64, exn>> = _v99 
        let v122 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v123 : Async<US9> = null |> unbox<Async<US9>>
        let _v122 = v123 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v126 : Async<US9> = null |> unbox<Async<US9>>
        let _v122 = v126 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v129 : Async<US9> = null |> unbox<Async<US9>>
        let _v122 = v129 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v132 : Async<US9> = null |> unbox<Async<US9>>
        let _v122 = v132 
        #endif
#if FABLE_COMPILER_PYTHON
        let v135 : Async<US9> = null |> unbox<Async<US9>>
        let _v122 = v135 
        #endif
#else
        let v138 : Async<US9> option = None
        let mutable _v138 = v138 
        async {
        let! v117 = v117 
        let v139 : Choice<int64, exn> = v117 
        let v140 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v141 : US9 = null |> unbox<US9>
        let _v140 = v141 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v144 : US9 = null |> unbox<US9>
        let _v140 = v144 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v147 : US9 = null |> unbox<US9>
        let _v140 = v147 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v150 : US9 = null |> unbox<US9>
        let _v140 = v150 
        #endif
#if FABLE_COMPILER_PYTHON
        let v153 : US9 = null |> unbox<US9>
        let _v140 = v153 
        #endif
#else
        let v156 : (int64 -> US9) = closure27()
        let v157 : (exn -> US9) = closure28()
        let v158 : US9 = match v139 with Choice1Of2 x -> v156 x | Choice2Of2 x -> v157 x
        let _v140 = v158 
        #endif
        let v159 : US9 = _v140 
        return v159 
        }
        |> fun x -> _v138 <- Some x
        let v164 : Async<US9> = match _v138 with Some x -> x | None -> failwith "async.new_async_unit / _v138=None"
        let _v122 = v164 
        #endif
        let v165 : Async<US9> = _v122 
        let v170 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v171 : Async<US10> = null |> unbox<Async<US10>>
        let _v170 = v171 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v174 : Async<US10> = null |> unbox<Async<US10>>
        let _v170 = v174 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v177 : Async<US10> = null |> unbox<Async<US10>>
        let _v170 = v177 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v180 : Async<US10> = null |> unbox<Async<US10>>
        let _v170 = v180 
        #endif
#if FABLE_COMPILER_PYTHON
        let v183 : Async<US10> = null |> unbox<Async<US10>>
        let _v170 = v183 
        #endif
#else
        let v186 : Async<US10> option = None
        let mutable _v186 = v186 
        async {
        let! v165 = v165 
        let v187 : US9 = v165 
        let v193 : US10 =
            match v187 with
            | US9_0(v188) -> (* C1of2 *)
                US10_0(v188)
            | US9_1(v190) -> (* C2of2 *)
                US10_1(v190)
        return v193 
        }
        |> fun x -> _v186 <- Some x
        let v194 : Async<US10> = match _v186 with Some x -> x | None -> failwith "async.new_async_unit / _v186=None"
        let _v170 = v194 
        #endif
        let v195 : Async<US10> = _v170 
        let v200 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v201 : Async<US3> = null |> unbox<Async<US3>>
        let _v200 = v201 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v204 : Async<US3> = null |> unbox<Async<US3>>
        let _v200 = v204 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v207 : Async<US3> = null |> unbox<Async<US3>>
        let _v200 = v207 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v210 : Async<US3> = null |> unbox<Async<US3>>
        let _v200 = v210 
        #endif
#if FABLE_COMPILER_PYTHON
        let v213 : Async<US3> = null |> unbox<Async<US3>>
        let _v200 = v213 
        #endif
#else
        let v216 : Async<US3> option = None
        let mutable _v216 = v216 
        async {
        let! v195 = v195 
        let v217 : US10 = v195 
        let v492 : US3 =
            match v217 with
            | US10_1(v220) -> (* Error *)
                let v221 : string = $"%A{v220}"
                let v224 : string = "System.TimeoutException"
                let v225 : bool = v221.Contains v224 
                if v225 then
                    let v228 : unit = ()
                    let v229 : (unit -> unit) = closure29()
                    let v230 : unit = (fun () -> v229 (); v228) ()
                    US3_1
                else
                    let v348 : unit = ()
                    let v349 : (unit -> unit) = closure30(v220)
                    let v350 : unit = (fun () -> v349 (); v348) ()
                    US3_1
            | US10_0(v218) -> (* Ok *)
                US3_0(v218)
        return v492 
        }
        |> fun x -> _v216 <- Some x
        let v493 : Async<US3> = match _v216 with Some x -> x | None -> failwith "async.new_async_unit / _v216=None"
        let _v200 = v493 
        #endif
        let v494 : Async<US3> = _v200 
        return! v494 
        }
        |> fun x -> _v75 <- Some x
        let v499 : Async<US3> = match _v75 with Some x -> x | None -> failwith "async.new_async_unit / _v75=None"
        let _v59 = v499 
        #endif
        let v500 : Async<US3> = _v59 
        let _v43 = v500 
        #endif
        let v505 : Async<US3> = _v43 
        let v510 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v511 : Async<unit> = null |> unbox<Async<unit>>
        let _v510 = v511 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v514 : Async<unit> = null |> unbox<Async<unit>>
        let _v510 = v514 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v517 : Async<unit> = null |> unbox<Async<unit>>
        let _v510 = v517 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v520 : Async<unit> = null |> unbox<Async<unit>>
        let _v510 = v520 
        #endif
#if FABLE_COMPILER_PYTHON
        let v523 : Async<unit> = null |> unbox<Async<unit>>
        let _v510 = v523 
        #endif
#else
        let v526 : (Async<US3> -> Async<unit>) = Async.Ignore
        let v527 : Async<unit> = v526 v505
        let _v510 = v527 
        #endif
        let v528 : Async<unit> = _v510 
        do! v528 
        ()
    let v533 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v534 : Async<string> = null |> unbox<Async<string>>
    let _v533 = v534 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v537 : Async<string> = null |> unbox<Async<string>>
    let _v533 = v537 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v540 : Async<string> = null |> unbox<Async<string>>
    let _v533 = v540 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v543 : Async<string> = null |> unbox<Async<string>>
    let _v533 = v543 
    #endif
#if FABLE_COMPILER_PYTHON
    let v546 : Async<string> = null |> unbox<Async<string>>
    let _v533 = v546 
    #endif
#else
    let v549 : (string -> System.Threading.Tasks.Task<string>) = System.IO.File.ReadAllTextAsync
    let v550 : System.Threading.Tasks.Task<string> = v549 v0
    let v551 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v552 : Async<string> = null |> unbox<Async<string>>
    let _v551 = v552 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v555 : Async<string> = null |> unbox<Async<string>>
    let _v551 = v555 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v558 : Async<string> = null |> unbox<Async<string>>
    let _v551 = v558 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v561 : Async<string> = null |> unbox<Async<string>>
    let _v551 = v561 
    #endif
#if FABLE_COMPILER_PYTHON
    let v564 : Async<string> = null |> unbox<Async<string>>
    let _v551 = v564 
    #endif
#else
    let v567 : (System.Threading.Tasks.Task<string> -> Async<string>) = Async.AwaitTask
    let v568 : Async<string> = v567 v550
    let _v551 = v568 
    #endif
    let v569 : Async<string> = _v551 
    let _v533 = v569 
    #endif
    let v574 : Async<string> = _v533 
    let v579 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v580 : Async<string option> = null |> unbox<Async<string option>>
    let _v579 = v580 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v583 : Async<string option> = null |> unbox<Async<string option>>
    let _v579 = v583 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v586 : Async<string option> = null |> unbox<Async<string option>>
    let _v579 = v586 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v589 : Async<string option> = null |> unbox<Async<string option>>
    let _v579 = v589 
    #endif
#if FABLE_COMPILER_PYTHON
    let v592 : Async<string option> = null |> unbox<Async<string option>>
    let _v579 = v592 
    #endif
#else
    let v595 : Async<string option> option = None
    let mutable _v595 = v595 
    async {
    let! v574 = v574 
    let v596 : string = v574 
    let v597 : string option = Some v596 
    return v597 
    }
    |> fun x -> _v595 <- Some x
    let v600 : Async<string option> = match _v595 with Some x -> x | None -> failwith "async.new_async_unit / _v595=None"
    let _v579 = v600 
    #endif
    let v601 : Async<string option> = _v579 
    return! v601 
    with ex ->
    let v606 : exn = ex
    let v607 : bool = v1 = 0L
    let v608 : bool = v607 <> true
    if v608 then
        let v609 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v610 : string = $"%A{v606}"
        let _v609 = v610 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v613 : string = $"%A{v606}"
        let _v609 = v613 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v616 : string = $"%A{v606}"
        let _v609 = v616 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v619 : string = $"%A{v606}"
        let _v609 = v619 
        #endif
#if FABLE_COMPILER_PYTHON
        let v622 : string = $"%A{v606}"
        let _v609 = v622 
        #endif
#else
        let v625 : string = $"{v606.GetType ()}: {v606.Message}"
        let _v609 = v625 
        #endif
        let v626 : string = _v609 
        let v631 : unit = ()
        let v632 : (unit -> unit) = closure31(v1, v626)
        let v633 : unit = (fun () -> v632 (); v631) ()
        let v749 : string option = None
        return v749 
        (*
        ()
    else
        *) else
        let v750 : int64 = v1 + 1L
        let v751 : Async<string option> = method35(v0, v750)
        return! v751 
        (*
        ()
    *)
    (*
    let v752 : string option = *)
    }
    |> fun x -> _v18 <- Some x
    let v753 : Async<string option> = match _v18 with Some x -> x | None -> failwith "async.new_async_unit / _v18=None"
    let _v2 = v753 
    #endif
    let v754 : Async<string option> = _v2 
    v754
and closure26 () (v0 : string) : Async<string option> =
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
    let v11 : Async<string option> = null |> unbox<Async<string option>>
    let _v1 = v11 
    #endif
#if FABLE_COMPILER_PYTHON
    let v14 : Async<string option> = null |> unbox<Async<string option>>
    let _v1 = v14 
    #endif
#else
    let v17 : int64 = 0L
    let v18 : Async<string option> = method35(v0, v17)
    let _v1 = v18 
    #endif
    let v19 : Async<string option> = _v1 
    v19
and closure33 () (v0 : chrono_DateTime<chrono_Utc>) : US11 =
    US11_0(v0)
and method44 () : (chrono_DateTime<chrono_Utc> -> US11) =
    closure33()
and method45 () : string =
    let v0 : string = "hh:mm"
    v0
and method46 () : string =
    let v0 : string = "yyyyMMdd-HHmm-ssff-ffff-f"
    v0
and method47 () : string =
    let v0 : string = "hhmm"
    v0
and method43 (v0 : System.Guid, v1 : System.DateTime) : System.Guid =
    let v2 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : System.DateTime = System.DateTime (1970, 1, 1, 0, 0, 0, System.DateTimeKind.Utc)
    let v6 : (System.DateTime -> System.DateTime) = _.ToUniversalTime()
    let v7 : System.DateTime = v6 v3
    let v10 : System.DateTimeKind = System.DateTimeKind.Local
    let v11 : System.DateTime = System.DateTime.SpecifyKind (v1, v10)
    let v12 : (System.DateTime -> System.DateTime) = _.ToUniversalTime()
    let v13 : System.DateTime = v12 v11
    let v16 : (System.DateTime -> int64) = _.Ticks
    let v17 : int64 = v16 v13
    let v20 : (System.DateTime -> int64) = _.Ticks
    let v21 : int64 = v20 v7
    let v24 : int64 = v17 - v21
    let v25 : int64 = v24 / 10L
    let v26 : string = "chrono::DateTime::from_timestamp_micros($0)"
    let v27 : chrono_DateTime<chrono_Utc> option = Fable.Core.RustInterop.emitRustExpr v25 v26 
    let v28 : (chrono_DateTime<chrono_Utc> -> US11) = method44()
    let v29 : US11 option = v27 |> Option.map v28 
    let v40 : US11 = US11_1
    let v41 : US11 = v29 |> Option.defaultValue v40 
    let v61 : US1 =
        match v41 with
        | US11_1 -> (* None *)
            US1_1
        | US11_0(v45) -> (* Some *)
            let v46 : string = "$0.naive_utc()"
            let v47 : chrono_NaiveDateTime = Fable.Core.RustInterop.emitRustExpr v45 v46 
            let v48 : string = "chrono::offset::TimeZone::from_utc_datetime(&chrono::Local, &$0)"
            let v49 : chrono_DateTime<chrono_Local> = Fable.Core.RustInterop.emitRustExpr v47 v48 
            let v50 : string = "%Y%m%d-%H%M-%S%f"
            let v51 : string = "r#\"" + v50 + "\"#"
            let v52 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v51 
            let v53 : string = "$0.format($1).to_string()"
            let v54 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v49, v52) v53 
            let v55 : string = "fable_library_rust::String_::fromString($0)"
            let v56 : string = Fable.Core.RustInterop.emitRustExpr v54 v55 
            let v57 : string = $"{v56.[0..17]}-{v56.[18..21]}-{v56.[22]}"
            US1_0(v57)
    let v65 : string =
        match v61 with
        | US1_1 -> (* None *)
            let v63 : string = ""
            v63
        | US1_0(v62) -> (* Some *)
            v62
    let v66 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v67 : string = "0i64.into()"
    let v68 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v67 
    let _v66 = v68 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v69 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v66 = v69 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v72 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v66 = v72 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v75 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v66 = v75 
    #endif
#if FABLE_COMPILER_PYTHON
    let v78 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v66 = v78 
    #endif
#else
    let v81 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v66 = v81 
    #endif
    let v82 : System.TimeZoneInfo = _v66 
    let v87 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v88 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v89 : System.TimeSpan = v88 ()
    let _v87 = v89 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v92 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v93 : System.TimeSpan = v92 ()
    let _v87 = v93 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v96 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v97 : System.TimeSpan = v96 ()
    let _v87 = v97 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v100 : US4 = US4_0
    let v101 : US5 = US5_3(v100)
    let v102 : string = $"date_time.get_utc_offset / target: {v101}"
    let v103 : System.TimeSpan = failwith<System.TimeSpan> v102
    let _v87 = v103 
    #endif
#if FABLE_COMPILER_PYTHON
    let v104 : US4 = US4_0
    let v105 : US5 = US5_4(v104)
    let v106 : string = $"date_time.get_utc_offset / target: {v105}"
    let v107 : System.TimeSpan = failwith<System.TimeSpan> v106
    let _v87 = v107 
    #endif
#else
    let v108 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v109 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v110 : string = "0i64.into()"
    let v111 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v110 
    let _v109 = v111 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v112 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v109 = v112 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v115 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v109 = v115 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v118 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v109 = v118 
    #endif
#if FABLE_COMPILER_PYTHON
    let v121 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v109 = v121 
    #endif
#else
    let v124 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v109 = v124 
    #endif
    let v125 : System.TimeZoneInfo = _v109 
    let v130 : (System.DateTime -> System.TimeSpan) = v108 v125
    let v131 : System.TimeSpan = v130 v13
    let _v87 = v131 
    #endif
    let v132 : System.TimeSpan = _v87 
    let v138 : (System.TimeSpan -> int32) = _.Hours
    let v139 : int32 = v138 v132
    let v142 : bool = v139 > 0
    let v143 : uint8 =
        if v142 then
            1uy
        else
            0uy
    let v144 : string = method45()
    let v145 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v146 : string = v132.ToString v144 
    let _v145 = v146 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v147 : string = v132.ToString v144 
    let _v145 = v147 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v148 : string = v132.ToString v144 
    let _v145 = v148 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v149 : string = v132.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _v145 = v149 
    #endif
#if FABLE_COMPILER_PYTHON
    let v150 : string = v132.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _v145 = v150 
    #endif
#else
    let v151 : string = v132.ToString v144 
    let _v145 = v151 
    #endif
    let v152 : string = _v145 
    let v155 : string = $"{v143}{v152.[0..1]}{v152.[3..4]}"
    let v156 : (System.Guid -> string) = _.ToString()
    let v157 : string = v156 v0
    let v160 : System.Guid = System.Guid $"{v65}{v155}{v157.[v65.Length + v155.Length..]}"
    let _v2 = v160 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v161 : System.DateTime = System.DateTime (1970, 1, 1, 0, 0, 0, System.DateTimeKind.Utc)
    let v164 : (System.DateTime -> System.DateTime) = _.ToUniversalTime()
    let v165 : System.DateTime = v164 v161
    let v168 : System.DateTimeKind = System.DateTimeKind.Local
    let v169 : System.DateTime = System.DateTime.SpecifyKind (v1, v168)
    let v170 : (System.DateTime -> System.DateTime) = _.ToUniversalTime()
    let v171 : System.DateTime = v170 v169
    let v174 : (System.DateTime -> int64) = _.Ticks
    let v175 : int64 = v174 v171
    let v178 : (System.DateTime -> int64) = _.Ticks
    let v179 : int64 = v178 v165
    let v182 : int64 = v175 - v179
    let v183 : int64 = v182 / 10L
    let v184 : string = "chrono::DateTime::from_timestamp_micros($0)"
    let v185 : chrono_DateTime<chrono_Utc> option = Fable.Core.RustInterop.emitRustExpr v183 v184 
    let v186 : (chrono_DateTime<chrono_Utc> -> US11) = method44()
    let v187 : US11 option = v185 |> Option.map v186 
    let v198 : US11 = US11_1
    let v199 : US11 = v187 |> Option.defaultValue v198 
    let v219 : US1 =
        match v199 with
        | US11_1 -> (* None *)
            US1_1
        | US11_0(v203) -> (* Some *)
            let v204 : string = "$0.naive_utc()"
            let v205 : chrono_NaiveDateTime = Fable.Core.RustInterop.emitRustExpr v203 v204 
            let v206 : string = "chrono::offset::TimeZone::from_utc_datetime(&chrono::Local, &$0)"
            let v207 : chrono_DateTime<chrono_Local> = Fable.Core.RustInterop.emitRustExpr v205 v206 
            let v208 : string = "%Y%m%d-%H%M-%S%f"
            let v209 : string = "r#\"" + v208 + "\"#"
            let v210 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v209 
            let v211 : string = "$0.format($1).to_string()"
            let v212 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v207, v210) v211 
            let v213 : string = "fable_library_rust::String_::fromString($0)"
            let v214 : string = Fable.Core.RustInterop.emitRustExpr v212 v213 
            let v215 : string = $"{v214.[0..17]}-{v214.[18..21]}-{v214.[22]}"
            US1_0(v215)
    let v223 : string =
        match v219 with
        | US1_1 -> (* None *)
            let v221 : string = ""
            v221
        | US1_0(v220) -> (* Some *)
            v220
    let v224 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v225 : string = "0i64.into()"
    let v226 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v225 
    let _v224 = v226 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v227 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v224 = v227 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v230 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v224 = v230 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v233 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v224 = v233 
    #endif
#if FABLE_COMPILER_PYTHON
    let v236 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v224 = v236 
    #endif
#else
    let v239 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v224 = v239 
    #endif
    let v240 : System.TimeZoneInfo = _v224 
    let v245 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v246 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v247 : System.TimeSpan = v246 ()
    let _v245 = v247 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v250 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v251 : System.TimeSpan = v250 ()
    let _v245 = v251 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v254 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v255 : System.TimeSpan = v254 ()
    let _v245 = v255 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v258 : US4 = US4_0
    let v259 : US5 = US5_3(v258)
    let v260 : string = $"date_time.get_utc_offset / target: {v259}"
    let v261 : System.TimeSpan = failwith<System.TimeSpan> v260
    let _v245 = v261 
    #endif
#if FABLE_COMPILER_PYTHON
    let v262 : US4 = US4_0
    let v263 : US5 = US5_4(v262)
    let v264 : string = $"date_time.get_utc_offset / target: {v263}"
    let v265 : System.TimeSpan = failwith<System.TimeSpan> v264
    let _v245 = v265 
    #endif
#else
    let v266 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v267 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v268 : string = "0i64.into()"
    let v269 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v268 
    let _v267 = v269 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v270 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v267 = v270 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v273 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v267 = v273 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v276 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v267 = v276 
    #endif
#if FABLE_COMPILER_PYTHON
    let v279 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v267 = v279 
    #endif
#else
    let v282 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v267 = v282 
    #endif
    let v283 : System.TimeZoneInfo = _v267 
    let v288 : (System.DateTime -> System.TimeSpan) = v266 v283
    let v289 : System.TimeSpan = v288 v171
    let _v245 = v289 
    #endif
    let v290 : System.TimeSpan = _v245 
    let v296 : (System.TimeSpan -> int32) = _.Hours
    let v297 : int32 = v296 v290
    let v300 : bool = v297 > 0
    let v301 : uint8 =
        if v300 then
            1uy
        else
            0uy
    let v302 : string = method45()
    let v303 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v304 : string = v290.ToString v302 
    let _v303 = v304 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v305 : string = v290.ToString v302 
    let _v303 = v305 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v306 : string = v290.ToString v302 
    let _v303 = v306 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v307 : string = v290.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _v303 = v307 
    #endif
#if FABLE_COMPILER_PYTHON
    let v308 : string = v290.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _v303 = v308 
    #endif
#else
    let v309 : string = v290.ToString v302 
    let _v303 = v309 
    #endif
    let v310 : string = _v303 
    let v313 : string = $"{v301}{v310.[0..1]}{v310.[3..4]}"
    let v314 : (System.Guid -> string) = _.ToString()
    let v315 : string = v314 v0
    let v318 : System.Guid = System.Guid $"{v223}{v313}{v315.[v223.Length + v313.Length..]}"
    let _v2 = v318 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v319 : System.Guid = null |> unbox<System.Guid>
    let _v2 = v319 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v322 : string = method46()
    let v323 : (string -> string) = v1.ToString
    let v324 : string = v323 v322
    let v327 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v328 : string = "0i64.into()"
    let v329 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v328 
    let _v327 = v329 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v330 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v327 = v330 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v333 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v327 = v333 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v336 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v327 = v336 
    #endif
#if FABLE_COMPILER_PYTHON
    let v339 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v327 = v339 
    #endif
#else
    let v342 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v327 = v342 
    #endif
    let v343 : System.TimeZoneInfo = _v327 
    let v348 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v349 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v350 : System.TimeSpan = v349 ()
    let _v348 = v350 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v353 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v354 : System.TimeSpan = v353 ()
    let _v348 = v354 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v357 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v358 : System.TimeSpan = v357 ()
    let _v348 = v358 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v361 : US4 = US4_0
    let v362 : US5 = US5_3(v361)
    let v363 : string = $"date_time.get_utc_offset / target: {v362}"
    let v364 : System.TimeSpan = failwith<System.TimeSpan> v363
    let _v348 = v364 
    #endif
#if FABLE_COMPILER_PYTHON
    let v365 : US4 = US4_0
    let v366 : US5 = US5_4(v365)
    let v367 : string = $"date_time.get_utc_offset / target: {v366}"
    let v368 : System.TimeSpan = failwith<System.TimeSpan> v367
    let _v348 = v368 
    #endif
#else
    let v369 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v370 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v371 : string = "0i64.into()"
    let v372 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v371 
    let _v370 = v372 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v373 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v370 = v373 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v376 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v370 = v376 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v379 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v370 = v379 
    #endif
#if FABLE_COMPILER_PYTHON
    let v382 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v370 = v382 
    #endif
#else
    let v385 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v370 = v385 
    #endif
    let v386 : System.TimeZoneInfo = _v370 
    let v391 : (System.DateTime -> System.TimeSpan) = v369 v386
    let v392 : System.TimeSpan = v391 v1
    let _v348 = v392 
    #endif
    let v393 : System.TimeSpan = _v348 
    let v399 : (System.TimeSpan -> int32) = _.Hours
    let v400 : int32 = v399 v393
    let v403 : bool = v400 > 0
    let v404 : uint8 =
        if v403 then
            1uy
        else
            0uy
    let v405 : string = method47()
    let v406 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v407 : string = v393.ToString v405 
    let _v406 = v407 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v408 : string = v393.ToString v405 
    let _v406 = v408 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v409 : string = v393.ToString v405 
    let _v406 = v409 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v410 : string = v393.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _v406 = v410 
    #endif
#if FABLE_COMPILER_PYTHON
    let v411 : string = v393.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _v406 = v411 
    #endif
#else
    let v412 : string = v393.ToString v405 
    let _v406 = v412 
    #endif
    let v413 : string = _v406 
    let v416 : string = $"{v404}{v413}"
    let v417 : (System.Guid -> string) = _.ToString()
    let v418 : string = v417 v0
    let v421 : System.Guid = System.Guid $"{v324}{v416}{v418.[v324.Length + v416.Length..]}"
    let _v2 = v421 
    #endif
#if FABLE_COMPILER_PYTHON
    let v422 : string = method46()
    let v423 : (string -> string) = v1.ToString
    let v424 : string = v423 v422
    let v427 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v428 : string = "0i64.into()"
    let v429 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v428 
    let _v427 = v429 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v430 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v427 = v430 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v433 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v427 = v433 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v436 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v427 = v436 
    #endif
#if FABLE_COMPILER_PYTHON
    let v439 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v427 = v439 
    #endif
#else
    let v442 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v427 = v442 
    #endif
    let v443 : System.TimeZoneInfo = _v427 
    let v448 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v449 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v450 : System.TimeSpan = v449 ()
    let _v448 = v450 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v453 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v454 : System.TimeSpan = v453 ()
    let _v448 = v454 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v457 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v458 : System.TimeSpan = v457 ()
    let _v448 = v458 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v461 : US4 = US4_0
    let v462 : US5 = US5_3(v461)
    let v463 : string = $"date_time.get_utc_offset / target: {v462}"
    let v464 : System.TimeSpan = failwith<System.TimeSpan> v463
    let _v448 = v464 
    #endif
#if FABLE_COMPILER_PYTHON
    let v465 : US4 = US4_0
    let v466 : US5 = US5_4(v465)
    let v467 : string = $"date_time.get_utc_offset / target: {v466}"
    let v468 : System.TimeSpan = failwith<System.TimeSpan> v467
    let _v448 = v468 
    #endif
#else
    let v469 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v470 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v471 : string = "0i64.into()"
    let v472 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v471 
    let _v470 = v472 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v473 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v470 = v473 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v476 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v470 = v476 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v479 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v470 = v479 
    #endif
#if FABLE_COMPILER_PYTHON
    let v482 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v470 = v482 
    #endif
#else
    let v485 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v470 = v485 
    #endif
    let v486 : System.TimeZoneInfo = _v470 
    let v491 : (System.DateTime -> System.TimeSpan) = v469 v486
    let v492 : System.TimeSpan = v491 v1
    let _v448 = v492 
    #endif
    let v493 : System.TimeSpan = _v448 
    let v499 : (System.TimeSpan -> int32) = _.Hours
    let v500 : int32 = v499 v493
    let v503 : bool = v500 > 0
    let v504 : uint8 =
        if v503 then
            1uy
        else
            0uy
    let v505 : string = method47()
    let v506 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v507 : string = v493.ToString v505 
    let _v506 = v507 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v508 : string = v493.ToString v505 
    let _v506 = v508 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v509 : string = v493.ToString v505 
    let _v506 = v509 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v510 : string = v493.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _v506 = v510 
    #endif
#if FABLE_COMPILER_PYTHON
    let v511 : string = v493.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _v506 = v511 
    #endif
#else
    let v512 : string = v493.ToString v505 
    let _v506 = v512 
    #endif
    let v513 : string = _v506 
    let v516 : string = $"{v504}{v513}"
    let v517 : (System.Guid -> string) = _.ToString()
    let v518 : string = v517 v0
    let v521 : System.Guid = System.Guid $"{v424}{v516}{v518.[v424.Length + v516.Length..]}"
    let _v2 = v521 
    #endif
#else
    let v522 : string = method46()
    let v523 : (string -> string) = v1.ToString
    let v524 : string = v523 v522
    let v527 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v528 : string = "0i64.into()"
    let v529 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v528 
    let _v527 = v529 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v530 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v527 = v530 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v533 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v527 = v533 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v536 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v527 = v536 
    #endif
#if FABLE_COMPILER_PYTHON
    let v539 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v527 = v539 
    #endif
#else
    let v542 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v527 = v542 
    #endif
    let v543 : System.TimeZoneInfo = _v527 
    let v548 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v549 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v550 : System.TimeSpan = v549 ()
    let _v548 = v550 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v553 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v554 : System.TimeSpan = v553 ()
    let _v548 = v554 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v557 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v558 : System.TimeSpan = v557 ()
    let _v548 = v558 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v561 : US4 = US4_0
    let v562 : US5 = US5_3(v561)
    let v563 : string = $"date_time.get_utc_offset / target: {v562}"
    let v564 : System.TimeSpan = failwith<System.TimeSpan> v563
    let _v548 = v564 
    #endif
#if FABLE_COMPILER_PYTHON
    let v565 : US4 = US4_0
    let v566 : US5 = US5_4(v565)
    let v567 : string = $"date_time.get_utc_offset / target: {v566}"
    let v568 : System.TimeSpan = failwith<System.TimeSpan> v567
    let _v548 = v568 
    #endif
#else
    let v569 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v570 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v571 : string = "0i64.into()"
    let v572 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v571 
    let _v570 = v572 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v573 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v570 = v573 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v576 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v570 = v576 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v579 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v570 = v579 
    #endif
#if FABLE_COMPILER_PYTHON
    let v582 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v570 = v582 
    #endif
#else
    let v585 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v570 = v585 
    #endif
    let v586 : System.TimeZoneInfo = _v570 
    let v591 : (System.DateTime -> System.TimeSpan) = v569 v586
    let v592 : System.TimeSpan = v591 v1
    let _v548 = v592 
    #endif
    let v593 : System.TimeSpan = _v548 
    let v599 : (System.TimeSpan -> int32) = _.Hours
    let v600 : int32 = v599 v593
    let v603 : bool = v600 > 0
    let v604 : uint8 =
        if v603 then
            1uy
        else
            0uy
    let v605 : string = method47()
    let v606 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v607 : string = v593.ToString v605 
    let _v606 = v607 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v608 : string = v593.ToString v605 
    let _v606 = v608 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v609 : string = v593.ToString v605 
    let _v606 = v609 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v610 : string = v593.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _v606 = v610 
    #endif
#if FABLE_COMPILER_PYTHON
    let v611 : string = v593.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _v606 = v611 
    #endif
#else
    let v612 : string = v593.ToString v605 
    let _v606 = v612 
    #endif
    let v613 : string = _v606 
    let v616 : string = $"{v604}{v613}"
    let v617 : (System.Guid -> string) = _.ToString()
    let v618 : string = v617 v0
    let v621 : System.Guid = System.Guid $"{v524}{v616}{v618.[v524.Length + v616.Length..]}"
    let _v2 = v621 
    #endif
    let v622 : System.Guid = _v2 
    v622
and method49 () : string =
    let v0 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1 : string = "std::env::temp_dir()"
    let v2 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr () v1 
    let v3 : string = "$0.display()"
    let v4 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v2 v3 
    let v5 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v6 : string = "format!(\"{}\", $0)"
    let v7 : std_string_String = Fable.Core.RustInterop.emitRustExpr v4 v6 
    let _v5 = v7 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v8 : string = "format!(\"{}\", $0)"
    let v9 : std_string_String = Fable.Core.RustInterop.emitRustExpr v4 v8 
    let _v5 = v9 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v10 : string = "format!(\"{}\", $0)"
    let v11 : std_string_String = Fable.Core.RustInterop.emitRustExpr v4 v10 
    let _v5 = v11 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v12 : std_string_String = null |> unbox<std_string_String>
    let _v5 = v12 
    #endif
#if FABLE_COMPILER_PYTHON
    let v15 : std_string_String = null |> unbox<std_string_String>
    let _v5 = v15 
    #endif
#else
    let v18 : std_string_String = null |> unbox<std_string_String>
    let _v5 = v18 
    #endif
    let v21 : std_string_String = _v5 
    let v26 : string = "fable_library_rust::String_::fromString($0)"
    let v27 : string = Fable.Core.RustInterop.emitRustExpr v21 v26 
    let _v0 = v27 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v28 : US4 = US4_1
    let v29 : US5 = US5_2(v28)
    let v30 : string = $"file_system.get_temp_path / target: {v29}"
    let v31 : string = failwith<string> v30
    let _v0 = v31 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v32 : string = null |> unbox<string>
    let _v0 = v32 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v35 : US4 = US4_0
    let v36 : US5 = US5_3(v35)
    let v37 : string = $"file_system.get_temp_path / target: {v36}"
    let v38 : string = failwith<string> v37
    let _v0 = v38 
    #endif
#if FABLE_COMPILER_PYTHON
    let v39 : US4 = US4_0
    let v40 : US5 = US5_4(v39)
    let v41 : string = $"file_system.get_temp_path / target: {v40}"
    let v42 : string = failwith<string> v41
    let _v0 = v42 
    #endif
#else
    let v43 : (unit -> string) = System.IO.Path.GetTempPath
    let v44 : string = v43 ()
    let _v0 = v44 
    #endif
    let v45 : string = _v0 
    v45
and method50 () : string =
    let v0 : string = "!create_temp_path_"
    v0
and method53 (v0 : string) : string =
    v0
and method52 (v0 : string, v1 : string) : struct (string * string) =
    let v2 : string = method53(v0)
    struct (v1, v2)
and method51 (v0 : string, v1 : string) : string =
    let v2 : unit = ()
    
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
    let v17 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v18 : string = "format!(\"{}\", $0)"
    let v19 : std_string_String = Fable.Core.RustInterop.emitRustExpr v16 v18 
    let _v17 = v19 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v20 : string = "format!(\"{}\", $0)"
    let v21 : std_string_String = Fable.Core.RustInterop.emitRustExpr v16 v20 
    let _v17 = v21 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v22 : string = "format!(\"{}\", $0)"
    let v23 : std_string_String = Fable.Core.RustInterop.emitRustExpr v16 v22 
    let _v17 = v23 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v24 : std_string_String = null |> unbox<std_string_String>
    let _v17 = v24 
    #endif
#if FABLE_COMPILER_PYTHON
    let v27 : std_string_String = null |> unbox<std_string_String>
    let _v17 = v27 
    #endif
#else
    let v30 : std_string_String = null |> unbox<std_string_String>
    let _v17 = v30 
    #endif
    let v33 : std_string_String = _v17 
    let v38 : string = "fable_library_rust::String_::fromString($0)"
    let v39 : string = Fable.Core.RustInterop.emitRustExpr v33 v38 
    let _v2 = v39 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v40 : US4 = US4_1
    let v41 : US5 = US5_2(v40)
    let v42 : string = $"file_system.(</>) / target: {v41} / a: {v0} / b: {v1}"
    let v43 : string = failwith<string> v42
    let _v2 = v43 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v44 : string = null |> unbox<string>
    let _v2 = v44 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v47 : string = "path"
    let v48 : IPathJoin = Fable.Core.JsInterop.importAll v47 
    let struct (v49 : string, v50 : string) = method52(v1, v0)
    let v51 : string = "v48.join($0, $1)"
    let v52 : string = Fable.Core.JsInterop.emitJsExpr struct (v49, v50) v51 
    let _v2 = v52 
    #endif
#if FABLE_COMPILER_PYTHON
    let v53 : US4 = US4_0
    let v54 : US5 = US5_4(v53)
    let v55 : string = $"file_system.(</>) / target: {v54} / a: {v0} / b: {v1}"
    let v56 : string = failwith<string> v55
    let _v2 = v56 
    #endif
#else
    let v57 : string = System.IO.Path.Combine (v0, v1)
    let _v2 = v57 
    #endif
    let v58 : string = _v2 
    v58
and method55 () : string =
    let v0 : string = "CARGO_PKG_NAME"
    v0
and method54 () : string =
    let v0 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1 : string = method55()
    let v2 : string = method2(v1)
    let _v0 = v2 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v3 : string = method55()
    let v4 : string = method2(v3)
    let _v0 = v4 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v5 : string = method55()
    let v6 : string = method2(v5)
    let _v0 = v6 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v7 : US4 = US4_0
    let v8 : US5 = US5_3(v7)
    let v9 : string = $"env.get_entry_assembly_name / target: {v8}"
    let v10 : string = failwith<string> v9
    let _v0 = v10 
    #endif
#if FABLE_COMPILER_PYTHON
    let v11 : US4 = US4_0
    let v12 : US5 = US5_4(v11)
    let v13 : string = $"env.get_entry_assembly_name / target: {v12}"
    let v14 : string = failwith<string> v13
    let _v0 = v14 
    #endif
#else
    let v15 : string = System.Reflection.Assembly.GetEntryAssembly().GetName().Name
    let _v0 = v15 
    #endif
    let v16 : string = _v0 
    v16
and method48 (v0 : System.Guid) : string =
    let v1 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = method49()
    let v3 : string = method50()
    let v4 : string = method51(v2, v3)
    let v5 : string = method54()
    let v6 : string = method51(v4, v5)
    let v7 : (System.Guid -> string) = _.ToString()
    let v8 : string = v7 v0
    let v11 : string = method51(v6, v8)
    let _v1 = v11 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v12 : string = method49()
    let v13 : string = method50()
    let v14 : string = method51(v12, v13)
    let v15 : string = method54()
    let v16 : string = method51(v14, v15)
    let v17 : (System.Guid -> string) = _.ToString()
    let v18 : string = v17 v0
    let v21 : string = method51(v16, v18)
    let _v1 = v21 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v22 : string = null |> unbox<string>
    let _v1 = v22 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v25 : string = method49()
    let v26 : string = method50()
    let v27 : string = method51(v25, v26)
    let v28 : string = method54()
    let v29 : string = method51(v27, v28)
    let v30 : (System.Guid -> string) = _.ToString()
    let v31 : string = v30 v0
    let v34 : string = method51(v29, v31)
    let _v1 = v34 
    #endif
#if FABLE_COMPILER_PYTHON
    let v35 : string = method49()
    let v36 : string = method50()
    let v37 : string = method51(v35, v36)
    let v38 : string = method54()
    let v39 : string = method51(v37, v38)
    let v40 : (System.Guid -> string) = _.ToString()
    let v41 : string = v40 v0
    let v44 : string = method51(v39, v41)
    let _v1 = v44 
    #endif
#else
    let v45 : string = method49()
    let v46 : string = method50()
    let v47 : string = method51(v45, v46)
    let v48 : string = method54()
    let v49 : string = method51(v47, v48)
    let v50 : (System.Guid -> string) = _.ToString()
    let v51 : string = v50 v0
    let v54 : string = method51(v49, v51)
    let _v1 = v54 
    #endif
    let v55 : string = _v1 
    v55
and method42 () : string =
    let v0 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1 : System.DateTime = System.DateTime.Now
    let v4 : (unit -> System.Guid) = System.Guid.NewGuid
    let v5 : System.Guid = v4 ()
    let v8 : System.Guid = method43(v5, v1)
    let v9 : string = method48(v8)
    let _v0 = v9 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v10 : System.DateTime = System.DateTime.Now
    let v13 : (unit -> System.Guid) = System.Guid.NewGuid
    let v14 : System.Guid = v13 ()
    let v17 : System.Guid = method43(v14, v10)
    let v18 : string = method48(v17)
    let _v0 = v18 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v19 : string = null |> unbox<string>
    let _v0 = v19 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v22 : System.DateTime = System.DateTime.Now
    let v25 : (unit -> System.Guid) = System.Guid.NewGuid
    let v26 : System.Guid = v25 ()
    let v29 : System.Guid = method43(v26, v22)
    let v30 : string = method48(v29)
    let _v0 = v30 
    #endif
#if FABLE_COMPILER_PYTHON
    let v31 : System.DateTime = System.DateTime.Now
    let v34 : (unit -> System.Guid) = System.Guid.NewGuid
    let v35 : System.Guid = v34 ()
    let v38 : System.Guid = method43(v35, v31)
    let v39 : string = method48(v38)
    let _v0 = v39 
    #endif
#else
    let v40 : System.DateTime = System.DateTime.Now
    let v43 : (unit -> System.Guid) = System.Guid.NewGuid
    let v44 : System.Guid = v43 ()
    let v47 : System.Guid = method43(v44, v40)
    let v48 : string = method48(v47)
    let _v0 = v48 
    #endif
    let v49 : string = _v0 
    v49
and closure32 () () : string =
    method42()
and method57 (v0 : string) : string =
    v0
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
#else
    let v14 : std_string_String = null |> unbox<std_string_String>
    let _v1 = v14 
    #endif
    let v17 : std_string_String = _v1 
    v17
and method58 () : (std_io_Error -> std_string_String) =
    closure35()
and closure36 () () : US12 =
    US12_0
and closure37 () (v0 : std_string_String) : US12 =
    US12_1(v0)
and method59 (v0 : string, v1 : std_string_String) : string =
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
#else
    let v84 : string = $"%A{v1}"
    let _v65 = v84 
    #endif
    let v87 : string = _v65 
    let v92 : string = $"{v87}"
    let v95 : unit = ()
    let v96 : (unit -> unit) = closure6(v3, v92)
    let v97 : unit = (fun () -> v96 (); v95) ()
    let v100 : string = " }"
    let v101 : string = $"{v100}"
    let v104 : unit = ()
    let v105 : (unit -> unit) = closure6(v3, v101)
    let v106 : unit = (fun () -> v105 (); v104) ()
    let v109 : string = v3.l0
    v109
and method60 (v0 : string, v1 : string, v2 : int64, v3 : string) : string =
    let v4 : string = "file_system.create_dir"
    let v5 : string = $"{v0} {v1} #{v2} %s{v4} / {v3}"
    let v8 : char list = []
    let v9 : (char list -> (char [])) = List.toArray
    let v10 : (char []) = v9 v8
    let v13 : string = v5.TrimStart v10 
    let v31 : char list = []
    let v32 : char list = '/' :: v31 
    let v35 : char list = ' ' :: v32 
    let v38 : (char list -> (char [])) = List.toArray
    let v39 : (char []) = v38 v35
    let v42 : string = v13.TrimEnd v39 
    v42
and closure38 (v0 : string, v1 : std_string_String) () : unit =
    let v2 : unit = ()
    let v3 : (unit -> unit) = closure0()
    let v4 : unit = (fun () -> v3 (); v2) ()
    let struct (v18 : Mut0, v19 : Mut1, v20 : Mut2, v21 : Mut3, v22 : Mut4, v23 : int64 option) = TraceState.trace_state.Value
    let v36 : US0 = v22.l0
    let v37 : bool = v20.l0
    let v38 : bool = v37 = false
    let v41 : bool =
        if v38 then
            false
        else
            let v39 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v36
            let v40 : bool = 4 >= v39
            v40
    if v41 then
        let v42 : unit = ()
        let v43 : unit = (fun () -> v3 (); v42) ()
        let struct (v57 : Mut0, v58 : Mut1, v59 : Mut2, v60 : Mut3, v61 : Mut4, v62 : int64 option) = TraceState.trace_state.Value
        let v75 : string = method10(v57, v58, v59, v60, v61, v62)
        let v76 : string = method39()
        let v77 : int64 = v57.l0
        let v78 : string = method59(v0, v1)
        let v79 : string = method60(v75, v76, v77, v78)
        let v80 : unit = ()
        let v81 : unit = (fun () -> v3 (); v80) ()
        let struct (v95 : Mut0, v96 : Mut1, v97 : Mut2, v98 : Mut3, v99 : Mut4, v100 : int64 option) = TraceState.trace_state.Value
        method20(v79, v95, v96, v97, v98, v99, v100)
and method61 (v0 : string) : string =
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
and closure39 (v0 : string) () : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure0()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v17 : Mut0, v18 : Mut1, v19 : Mut2, v20 : Mut3, v21 : Mut4, v22 : int64 option) = TraceState.trace_state.Value
    let v35 : US0 = v21.l0
    let v36 : bool = v19.l0
    let v37 : bool = v36 = false
    let v40 : bool =
        if v37 then
            false
        else
            let v38 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v35
            let v39 : bool = 0 >= v38
            v39
    if v40 then
        let v41 : unit = ()
        let v42 : unit = (fun () -> v2 (); v41) ()
        let struct (v56 : Mut0, v57 : Mut1, v58 : Mut2, v59 : Mut3, v60 : Mut4, v61 : int64 option) = TraceState.trace_state.Value
        let v74 : string = method10(v56, v57, v58, v59, v60, v61)
        let v75 : string = method36()
        let v76 : int64 = v56.l0
        let v77 : string = method61(v0)
        let v78 : string = method60(v74, v75, v76, v77)
        let v79 : unit = ()
        let v80 : unit = (fun () -> v2 (); v79) ()
        let struct (v94 : Mut0, v95 : Mut1, v96 : Mut2, v97 : Mut3, v98 : Mut4, v99 : int64 option) = TraceState.trace_state.Value
        method20(v78, v94, v95, v96, v97, v98, v99)
and closure40 (v0 : string) () : unit =
    let v1 : bool = true
    method7(v1, v0)
and method62 (v0 : string) : (unit -> unit) =
    closure40(v0)
and method63 (v0 : string) : (unit -> unit) =
    closure40(v0)
and method64 (v0 : string, v1 : string) : string =
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
and closure41 (v0 : string, v1 : string) () : unit =
    let v2 : unit = ()
    let v3 : (unit -> unit) = closure0()
    let v4 : unit = (fun () -> v3 (); v2) ()
    let struct (v18 : Mut0, v19 : Mut1, v20 : Mut2, v21 : Mut3, v22 : Mut4, v23 : int64 option) = TraceState.trace_state.Value
    let v36 : US0 = v22.l0
    let v37 : bool = v20.l0
    let v38 : bool = v37 = false
    let v41 : bool =
        if v38 then
            false
        else
            let v39 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v36
            let v40 : bool = 1 >= v39
            v40
    if v41 then
        let v42 : unit = ()
        let v43 : unit = (fun () -> v3 (); v42) ()
        let struct (v57 : Mut0, v58 : Mut1, v59 : Mut2, v60 : Mut3, v61 : Mut4, v62 : int64 option) = TraceState.trace_state.Value
        let v75 : string = method10(v57, v58, v59, v60, v61, v62)
        let v76 : string = method14()
        let v77 : int64 = v57.l0
        let v78 : string = method64(v0, v1)
        let v79 : string = method60(v75, v76, v77, v78)
        let v80 : unit = ()
        let v81 : unit = (fun () -> v3 (); v80) ()
        let struct (v95 : Mut0, v96 : Mut1, v97 : Mut2, v98 : Mut3, v99 : Mut4, v100 : int64 option) = TraceState.trace_state.Value
        method20(v79, v95, v96, v97, v98, v99, v100)
and closure42 (v0 : string) () : unit =
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
#else
    let v17 : int64 = 0L
    let v18 : Async<int64> = method6(v0, v17)
    let _v1 = v18 
    #endif
    let v19 : Async<int64> = _v1 
    let v24 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v25 : Async<unit> = null |> unbox<Async<unit>>
    let _v24 = v25 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v28 : Async<unit> = null |> unbox<Async<unit>>
    let _v24 = v28 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v31 : Async<unit> = null |> unbox<Async<unit>>
    let _v24 = v31 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v34 : Async<unit> = null |> unbox<Async<unit>>
    let _v24 = v34 
    #endif
#if FABLE_COMPILER_PYTHON
    let v37 : Async<unit> = null |> unbox<Async<unit>>
    let _v24 = v37 
    #endif
#else
    let v40 : (Async<int64> -> Async<unit>) = Async.Ignore
    let v41 : Async<unit> = v40 v19
    let _v24 = v41 
    #endif
    let v42 : Async<unit> = _v24 
    let v47 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    null |> unbox<unit>
    let _v47 = () 
    #endif
#if FABLE_COMPILER_RUST && WASM
    null |> unbox<unit>
    let _v47 = () 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    null |> unbox<unit>
    let _v47 = () 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    null |> unbox<unit>
    let _v47 = () 
    #endif
#if FABLE_COMPILER_PYTHON
    null |> unbox<unit>
    let _v47 = () 
    #endif
#else
    let v48 : (Async<unit> -> unit) = Async.RunSynchronously
    v48 v42
    let _v47 = () 
    #endif
    _v47 
    ()
and method65 (v0 : string) : (unit -> unit) =
    closure42(v0)
and method66 (v0 : string) : (unit -> unit) =
    closure42(v0)
and method56 (v0 : string) : System.IDisposable =
    let v1 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = method57(v0)
    let v3 : string = "std::fs::create_dir_all(&*$0)"
    let v4 : Result<unit, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v2 v3 
    let v5 : (std_io_Error -> std_string_String) = method58()
    let v6 : string = "$0.map_err(|x| $1(x))"
    let v7 : Result<unit, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v4, v5) v6 
    let v8 : (unit -> US12) = closure36()
    let v9 : (std_string_String -> US12) = closure37()
    let v10 : US12 = match v7 with Ok () -> v8 () | Error x -> v9 x
    match v10 with
    | US12_1(v125) -> (* Error *)
        let v126 : unit = ()
        let v127 : (unit -> unit) = closure38(v2, v125)
        let v128 : unit = (fun () -> v127 (); v126) ()
        ()
    | US12_0 -> (* Ok *)
        let v11 : unit = ()
        let v12 : (unit -> unit) = closure39(v2)
        let v13 : unit = (fun () -> v12 (); v11) ()
        ()
    let v240 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v241 : (unit -> unit) = method62(v2)
    let v242 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v241 "$0()" )
    let _v240 = v242 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v243 : (unit -> unit) = method62(v2)
    let v244 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v243 "$0()" )
    let _v240 = v244 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v245 : (unit -> unit) = method62(v2)
    let v246 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v245 "$0()" )
    let _v240 = v246 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v247 : (unit -> unit) = method63(v2)
    let v248 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v247 () }
    let _v240 = v248 
    #endif
#if FABLE_COMPILER_PYTHON
    let v249 : (unit -> unit) = method63(v2)
    let v250 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v249 () }
    let _v240 = v250 
    #endif
#else
    let v251 : (unit -> unit) = method63(v2)
    let v252 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v251 () }
    let _v240 = v252 
    #endif
    let v253 : System.IDisposable = _v240 
    let _v1 = v253 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v257 : System.IDisposable = null |> unbox<System.IDisposable>
    let _v1 = v257 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v260 : System.IDisposable = null |> unbox<System.IDisposable>
    let _v1 = v260 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v263 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v264 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    let _v263 = v264 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v267 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    let _v263 = v267 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v270 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    let _v263 = v270 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v273 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    let _v263 = v273 
    #endif
#if FABLE_COMPILER_PYTHON
    let v276 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    let _v263 = v276 
    #endif
#else
    let v279 : (string -> System.IO.DirectoryInfo) = System.IO.Directory.CreateDirectory
    let v280 : System.IO.DirectoryInfo = v279 v0
    let _v263 = v280 
    #endif
    let v281 : System.IO.DirectoryInfo = _v263 
    let v286 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v287 : bool = null |> unbox<bool>
    let _v286 = v287 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v290 : bool = null |> unbox<bool>
    let _v286 = v290 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v293 : bool = null |> unbox<bool>
    let _v286 = v293 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v296 : bool = null |> unbox<bool>
    let _v286 = v296 
    #endif
#if FABLE_COMPILER_PYTHON
    let v299 : bool = null |> unbox<bool>
    let _v286 = v299 
    #endif
#else
    let v302 : bool = v281.Exists
    let _v286 = v302 
    #endif
    let v303 : bool = _v286 
    let v308 : bool = v303 = false
    if v308 then
        let v309 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v310 : System.DateTime = null |> unbox<System.DateTime>
        let _v309 = v310 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v313 : System.DateTime = null |> unbox<System.DateTime>
        let _v309 = v313 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v316 : System.DateTime = null |> unbox<System.DateTime>
        let _v309 = v316 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v319 : System.DateTime = null |> unbox<System.DateTime>
        let _v309 = v319 
        #endif
#if FABLE_COMPILER_PYTHON
        let v322 : System.DateTime = null |> unbox<System.DateTime>
        let _v309 = v322 
        #endif
#else
        let v325 : System.DateTime = v281.CreationTime
        let _v309 = v325 
        #endif
        let v326 : System.DateTime = _v309 
        let v331 : obj = {| Exists = v303; CreationTime = v326 |}
        let v332 : string = $"%A{v331}"
        let v335 : unit = ()
        let v336 : (unit -> unit) = closure41(v0, v332)
        let v337 : unit = (fun () -> v336 (); v335) ()
        ()
    let v449 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v450 : (unit -> unit) = method65(v0)
    let v451 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v450 "$0()" )
    let _v449 = v451 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v452 : (unit -> unit) = method65(v0)
    let v453 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v452 "$0()" )
    let _v449 = v453 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v454 : (unit -> unit) = method65(v0)
    let v455 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v454 "$0()" )
    let _v449 = v455 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v456 : (unit -> unit) = method66(v0)
    let v457 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v456 () }
    let _v449 = v457 
    #endif
#if FABLE_COMPILER_PYTHON
    let v458 : (unit -> unit) = method66(v0)
    let v459 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v458 () }
    let _v449 = v459 
    #endif
#else
    let v460 : (unit -> unit) = method66(v0)
    let v461 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v460 () }
    let _v449 = v461 
    #endif
    let v462 : System.IDisposable = _v449 
    let _v1 = v462 
    #endif
#if FABLE_COMPILER_PYTHON
    let v466 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v467 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    let _v466 = v467 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v470 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    let _v466 = v470 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v473 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    let _v466 = v473 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v476 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    let _v466 = v476 
    #endif
#if FABLE_COMPILER_PYTHON
    let v479 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    let _v466 = v479 
    #endif
#else
    let v482 : (string -> System.IO.DirectoryInfo) = System.IO.Directory.CreateDirectory
    let v483 : System.IO.DirectoryInfo = v482 v0
    let _v466 = v483 
    #endif
    let v484 : System.IO.DirectoryInfo = _v466 
    let v489 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v490 : bool = null |> unbox<bool>
    let _v489 = v490 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v493 : bool = null |> unbox<bool>
    let _v489 = v493 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v496 : bool = null |> unbox<bool>
    let _v489 = v496 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v499 : bool = null |> unbox<bool>
    let _v489 = v499 
    #endif
#if FABLE_COMPILER_PYTHON
    let v502 : bool = null |> unbox<bool>
    let _v489 = v502 
    #endif
#else
    let v505 : bool = v484.Exists
    let _v489 = v505 
    #endif
    let v506 : bool = _v489 
    let v511 : bool = v506 = false
    if v511 then
        let v512 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v513 : System.DateTime = null |> unbox<System.DateTime>
        let _v512 = v513 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v516 : System.DateTime = null |> unbox<System.DateTime>
        let _v512 = v516 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v519 : System.DateTime = null |> unbox<System.DateTime>
        let _v512 = v519 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v522 : System.DateTime = null |> unbox<System.DateTime>
        let _v512 = v522 
        #endif
#if FABLE_COMPILER_PYTHON
        let v525 : System.DateTime = null |> unbox<System.DateTime>
        let _v512 = v525 
        #endif
#else
        let v528 : System.DateTime = v484.CreationTime
        let _v512 = v528 
        #endif
        let v529 : System.DateTime = _v512 
        let v534 : obj = {| Exists = v506; CreationTime = v529 |}
        let v535 : string = $"%A{v534}"
        let v538 : unit = ()
        let v539 : (unit -> unit) = closure41(v0, v535)
        let v540 : unit = (fun () -> v539 (); v538) ()
        ()
    let v652 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v653 : (unit -> unit) = method65(v0)
    let v654 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v653 "$0()" )
    let _v652 = v654 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v655 : (unit -> unit) = method65(v0)
    let v656 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v655 "$0()" )
    let _v652 = v656 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v657 : (unit -> unit) = method65(v0)
    let v658 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v657 "$0()" )
    let _v652 = v658 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v659 : (unit -> unit) = method66(v0)
    let v660 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v659 () }
    let _v652 = v660 
    #endif
#if FABLE_COMPILER_PYTHON
    let v661 : (unit -> unit) = method66(v0)
    let v662 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v661 () }
    let _v652 = v662 
    #endif
#else
    let v663 : (unit -> unit) = method66(v0)
    let v664 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v663 () }
    let _v652 = v664 
    #endif
    let v665 : System.IDisposable = _v652 
    let _v1 = v665 
    #endif
#else
    let v669 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v670 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    let _v669 = v670 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v673 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    let _v669 = v673 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v676 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    let _v669 = v676 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v679 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    let _v669 = v679 
    #endif
#if FABLE_COMPILER_PYTHON
    let v682 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    let _v669 = v682 
    #endif
#else
    let v685 : (string -> System.IO.DirectoryInfo) = System.IO.Directory.CreateDirectory
    let v686 : System.IO.DirectoryInfo = v685 v0
    let _v669 = v686 
    #endif
    let v687 : System.IO.DirectoryInfo = _v669 
    let v692 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v693 : bool = null |> unbox<bool>
    let _v692 = v693 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v696 : bool = null |> unbox<bool>
    let _v692 = v696 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v699 : bool = null |> unbox<bool>
    let _v692 = v699 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v702 : bool = null |> unbox<bool>
    let _v692 = v702 
    #endif
#if FABLE_COMPILER_PYTHON
    let v705 : bool = null |> unbox<bool>
    let _v692 = v705 
    #endif
#else
    let v708 : bool = v687.Exists
    let _v692 = v708 
    #endif
    let v709 : bool = _v692 
    let v714 : bool = v709 = false
    if v714 then
        let v715 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v716 : System.DateTime = null |> unbox<System.DateTime>
        let _v715 = v716 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v719 : System.DateTime = null |> unbox<System.DateTime>
        let _v715 = v719 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v722 : System.DateTime = null |> unbox<System.DateTime>
        let _v715 = v722 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v725 : System.DateTime = null |> unbox<System.DateTime>
        let _v715 = v725 
        #endif
#if FABLE_COMPILER_PYTHON
        let v728 : System.DateTime = null |> unbox<System.DateTime>
        let _v715 = v728 
        #endif
#else
        let v731 : System.DateTime = v687.CreationTime
        let _v715 = v731 
        #endif
        let v732 : System.DateTime = _v715 
        let v737 : obj = {| Exists = v709; CreationTime = v732 |}
        let v738 : string = $"%A{v737}"
        let v741 : unit = ()
        let v742 : (unit -> unit) = closure41(v0, v738)
        let v743 : unit = (fun () -> v742 (); v741) ()
        ()
    let v855 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v856 : (unit -> unit) = method65(v0)
    let v857 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v856 "$0()" )
    let _v855 = v857 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v858 : (unit -> unit) = method65(v0)
    let v859 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v858 "$0()" )
    let _v855 = v859 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v860 : (unit -> unit) = method65(v0)
    let v861 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v860 "$0()" )
    let _v855 = v861 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v862 : (unit -> unit) = method66(v0)
    let v863 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v862 () }
    let _v855 = v863 
    #endif
#if FABLE_COMPILER_PYTHON
    let v864 : (unit -> unit) = method66(v0)
    let v865 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v864 () }
    let _v855 = v865 
    #endif
#else
    let v866 : (unit -> unit) = method66(v0)
    let v867 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v866 () }
    let _v855 = v867 
    #endif
    let v868 : System.IDisposable = _v855 
    let _v1 = v868 
    #endif
    let v872 : System.IDisposable = _v1 
    v872
and closure34 () () : struct (string * System.IDisposable) =
    let v0 : string = method42()
    let v1 : System.IDisposable = method56(v0)
    struct (v0, v1)
and method67 (v0 : string) : System.Guid =
    let v1 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = v0.PadLeft (32, '0')
    let v16 : System.Guid = System.Guid $"{v2.[0..7]}-{v2.[8..11]}-{v2.[12..15]}-{v2.[16..19]}-{v2.[20..31]}"
    let _v1 = v16 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v19 : string = v0.PadLeft (32, '0')
    let v33 : System.Guid = System.Guid $"{v19.[0..7]}-{v19.[8..11]}-{v19.[12..15]}-{v19.[16..19]}-{v19.[20..31]}"
    let _v1 = v33 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v36 : System.Guid = null |> unbox<System.Guid>
    let _v1 = v36 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v39 : string = v0.PadLeft (32, '0')
    let v53 : System.Guid = System.Guid $"{v39.[0..7]}-{v39.[8..11]}-{v39.[12..15]}-{v39.[16..19]}-{v39.[20..31]}"
    let _v1 = v53 
    #endif
#if FABLE_COMPILER_PYTHON
    let v56 : string = v0.PadLeft (32, '0')
    let v70 : System.Guid = System.Guid $"{v56.[0..7]}-{v56.[8..11]}-{v56.[12..15]}-{v56.[16..19]}-{v56.[20..31]}"
    let _v1 = v70 
    #endif
#else
    let v73 : string = v0.PadLeft (32, '0')
    let v87 : System.Guid = System.Guid $"{v73.[0..7]}-{v73.[8..11]}-{v73.[12..15]}-{v73.[16..19]}-{v73.[20..31]}"
    let _v1 = v87 
    #endif
    let v90 : System.Guid = _v1 
    v90
and closure43 () (v0 : string) : struct (string * System.IDisposable) =
    let v1 : System.Guid = method67(v0)
    let v2 : string = method48(v1)
    let v3 : System.IDisposable = method56(v2)
    struct (v2, v3)
and closure44 () () : string =
    let v0 : string = __SOURCE_DIRECTORY__
    v0
and method69 (v0 : string) : string =
    v0
and method68 (v0 : string) : string =
    let v1 : bool = v0 = ""
    if v1 then
        let v2 : string = ""
        v2
    else
        let v3 : string = "^\\\\\\\\\\?\\\\"
        let v4 : string = ""
        let v5 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v6 : string = $"regex::Regex::new(&$0)"
        let v7 : Result<regex_Regex, regex_Error> = Fable.Core.RustInterop.emitRustExpr v3 v6 
        let v8 : string = "$0.unwrap()"
        let v9 : regex_Regex = Fable.Core.RustInterop.emitRustExpr v7 v8 
        let v10 : string = method69(v0)
        let v11 : string = $"$0.replace_all(&*$1, &*$2)"
        let v12 : std_borrow_Cow<Str> = Fable.Core.RustInterop.emitRustExpr struct (v9, v10, v4) v11 
        let v13 : string = "String::from($0)"
        let v14 : std_string_String = Fable.Core.RustInterop.emitRustExpr v12 v13 
        let v15 : string = "fable_library_rust::String_::fromString($0)"
        let v16 : string = Fable.Core.RustInterop.emitRustExpr v14 v15 
        let _v5 = v16 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v17 : string = null |> unbox<string>
        let _v5 = v17 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v20 : string = null |> unbox<string>
        let _v5 = v20 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v23 : string = null |> unbox<string>
        let _v5 = v23 
        #endif
#if FABLE_COMPILER_PYTHON
        let v26 : string = null |> unbox<string>
        let _v5 = v26 
        #endif
#else
        let v29 : string = System.Text.RegularExpressions.Regex.Replace (v0, v3, v4)
        let _v5 = v29 
        #endif
        let v30 : string = _v5 
        let v35 : string = $"{v30.[0] |> string |> _.ToLower()}{v30.[1..]}"
        let v36 : string = "\\"
        let v37 : string = "/"
        let v38 : string = v35.Replace (v36, v37)
        v38
and closure45 () (v0 : string) : string =
    method68(v0)
and closure46 () (v0 : string) : string =
    let v1 : char list = []
    let v2 : char list = '/' :: v1 
    let v5 : (char list -> (char [])) = List.toArray
    let v6 : (char []) = v5 v2
    let v9 : string = v0.TrimStart v6 
    let v27 : string = $"file:///{v9}"
    v27
and method72 (v0 : string) : string option =
    let v1 : unit = ()
    
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
    let v14 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v15 : string = "format!(\"{}\", $0)"
    let v16 : std_string_String = Fable.Core.RustInterop.emitRustExpr v13 v15 
    let _v14 = v16 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v17 : string = "format!(\"{}\", $0)"
    let v18 : std_string_String = Fable.Core.RustInterop.emitRustExpr v13 v17 
    let _v14 = v18 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v19 : string = "format!(\"{}\", $0)"
    let v20 : std_string_String = Fable.Core.RustInterop.emitRustExpr v13 v19 
    let _v14 = v20 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v21 : std_string_String = null |> unbox<std_string_String>
    let _v14 = v21 
    #endif
#if FABLE_COMPILER_PYTHON
    let v24 : std_string_String = null |> unbox<std_string_String>
    let _v14 = v24 
    #endif
#else
    let v27 : std_string_String = null |> unbox<std_string_String>
    let _v14 = v27 
    #endif
    let v30 : std_string_String = _v14 
    let v35 : string = "fable_library_rust::String_::fromString($0)"
    let v36 : string = Fable.Core.RustInterop.emitRustExpr v30 v35 
    let v37 : US1 = US1_0(v36)
    let _v1 = v37 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v38 : US1 = null |> unbox<US1>
    let _v1 = v38 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v41 : US1 = null |> unbox<US1>
    let _v1 = v41 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v44 : string = "path"
    let v45 : IPathDirname = Fable.Core.JsInterop.importAll v44 
    let v46 : string = "v45.dirname($0)"
    let v47 : string = Fable.Core.JsInterop.emitJsExpr v0 v46 
    let v48 : US1 = US1_0(v47)
    let _v1 = v48 
    #endif
#if FABLE_COMPILER_PYTHON
    let v49 : US1 = null |> unbox<US1>
    let _v1 = v49 
    #endif
#else
    let v52 : (string -> System.IO.DirectoryInfo) = System.IO.Directory.GetParent
    let v53 : System.IO.DirectoryInfo = v52 v0
    let v54 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    let v57 : bool = v53 = v54 
    let v84 : US1 =
        if v57 then
            US1_1
        else
            let v61 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v62 : string = null |> unbox<string>
            let _v61 = v62 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v65 : string = null |> unbox<string>
            let _v61 = v65 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v68 : string = null |> unbox<string>
            let _v61 = v68 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v71 : string = null |> unbox<string>
            let _v61 = v71 
            #endif
#if FABLE_COMPILER_PYTHON
            let v74 : string = null |> unbox<string>
            let _v61 = v74 
            #endif
#else
            let v77 : string = v53.FullName
            let _v61 = v77 
            #endif
            let v78 : string = _v61 
            US1_0(v78)
    let _v1 = v84 
    #endif
    let v85 : US1 = _v1 
    match v85 with
    | US1_1 -> (* None *)
        let v94 : string option = None
        v94
    | US1_0(v90) -> (* Some *)
        let v91 : string option = Some v90 
        v91
and closure48 () (v0 : string) : string option =
    method72(v0)
and method71 () : (string -> string option) =
    closure48()
and method73 (v0 : string, v1 : string, v2 : string) : US13 =
    let v3 : string = method51(v2, v0)
    let v4 : bool = method9(v3)
    if v4 then
        US13_0(v2)
    else
        let v6 : (string -> string option) = method71()
        let v7 : string option = v6 v2
        let v8 : (string -> US1) = method4()
        let v9 : US1 option = v7 |> Option.map v8 
        let v20 : US1 = US1_1
        let v21 : US1 = v9 |> Option.defaultValue v20 
        match v21 with
        | US1_1 -> (* None *)
            let v27 : string = $"""No parent for {if false then "file" else "dir"} '{v0}' at '{v1}' (until '{v2}')"""
            US13_1(v27)
        | US1_0(v25) -> (* Some *)
            method73(v0, v1, v25)
and method70 (v0 : string, v1 : string) : US13 =
    let v2 : string = method51(v1, v0)
    let v3 : bool = method9(v2)
    if v3 then
        US13_0(v1)
    else
        let v5 : (string -> string option) = method71()
        let v6 : string option = v5 v1
        let v7 : (string -> US1) = method4()
        let v8 : US1 option = v6 |> Option.map v7 
        let v19 : US1 = US1_1
        let v20 : US1 = v8 |> Option.defaultValue v19 
        match v20 with
        | US1_1 -> (* None *)
            let v26 : string = $"""No parent for {if false then "file" else "dir"} '{v0}' at '{v1}' (until '{v1}')"""
            US13_1(v26)
        | US1_0(v24) -> (* Some *)
            method73(v0, v1, v24)
and method74 (v0 : string) : string =
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
and method75 (v0 : string, v1 : string, v2 : int64, v3 : string) : string =
    let v4 : string = "file_system.get_workspace_root"
    let v5 : string = $"{v0} {v1} #{v2} %s{v4} / {v3}"
    let v8 : char list = []
    let v9 : (char list -> (char [])) = List.toArray
    let v10 : (char []) = v9 v8
    let v13 : string = v5.TrimStart v10 
    let v31 : char list = []
    let v32 : char list = '/' :: v31 
    let v35 : char list = ' ' :: v32 
    let v38 : (char list -> (char [])) = List.toArray
    let v39 : (char []) = v38 v35
    let v42 : string = v13.TrimEnd v39 
    v42
and closure49 (v0 : string) () : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure0()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v17 : Mut0, v18 : Mut1, v19 : Mut2, v20 : Mut3, v21 : Mut4, v22 : int64 option) = TraceState.trace_state.Value
    let v35 : US0 = v21.l0
    let v36 : bool = v19.l0
    let v37 : bool = v36 = false
    let v40 : bool =
        if v37 then
            false
        else
            let v38 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v35
            let v39 : bool = 3 >= v38
            v39
    if v40 then
        let v41 : unit = ()
        let v42 : unit = (fun () -> v2 (); v41) ()
        let struct (v56 : Mut0, v57 : Mut1, v58 : Mut2, v59 : Mut3, v60 : Mut4, v61 : int64 option) = TraceState.trace_state.Value
        let v74 : string = method10(v56, v57, v58, v59, v60, v61)
        let v75 : string = method29()
        let v76 : int64 = v56.l0
        let v77 : string = method74(v0)
        let v78 : string = method75(v74, v75, v76, v77)
        let v79 : unit = ()
        let v80 : unit = (fun () -> v2 (); v79) ()
        let struct (v94 : Mut0, v95 : Mut1, v96 : Mut2, v97 : Mut3, v98 : Mut4, v99 : int64 option) = TraceState.trace_state.Value
        method20(v78, v94, v95, v96, v97, v98, v99)
and method76 () : string =
    let v0 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1 : string = "std::env::current_dir()"
    let v2 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v1 
    let v3 : string = "$0.unwrap()"
    let v4 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v2 v3 
    let v5 : string = "$0.display()"
    let v6 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v4 v5 
    let v7 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v8 : string = "format!(\"{}\", $0)"
    let v9 : std_string_String = Fable.Core.RustInterop.emitRustExpr v6 v8 
    let _v7 = v9 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v10 : string = "format!(\"{}\", $0)"
    let v11 : std_string_String = Fable.Core.RustInterop.emitRustExpr v6 v10 
    let _v7 = v11 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v12 : string = "format!(\"{}\", $0)"
    let v13 : std_string_String = Fable.Core.RustInterop.emitRustExpr v6 v12 
    let _v7 = v13 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v14 : std_string_String = null |> unbox<std_string_String>
    let _v7 = v14 
    #endif
#if FABLE_COMPILER_PYTHON
    let v17 : std_string_String = null |> unbox<std_string_String>
    let _v7 = v17 
    #endif
#else
    let v20 : std_string_String = null |> unbox<std_string_String>
    let _v7 = v20 
    #endif
    let v23 : std_string_String = _v7 
    let v28 : string = "fable_library_rust::String_::fromString($0)"
    let v29 : string = Fable.Core.RustInterop.emitRustExpr v23 v28 
    let _v0 = v29 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v30 : string = null |> unbox<string>
    let _v0 = v30 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v33 : string = null |> unbox<string>
    let _v0 = v33 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v36 : string = null |> unbox<string>
    let _v0 = v36 
    #endif
#if FABLE_COMPILER_PYTHON
    let v39 : string = null |> unbox<string>
    let _v0 = v39 
    #endif
#else
    let v42 : (unit -> string) = System.IO.Directory.GetCurrentDirectory
    let v43 : string = v42 ()
    let _v0 = v43 
    #endif
    let v44 : string = _v0 
    v44
and closure47 () () : string =
    let v0 : string = __SOURCE_DIRECTORY__
    let v1 : string = "polyglot"
    let v2 : string = ".devcontainer"
    let v3 : string = method51(v1, v2)
    let v4 : US13 = method70(v3, v0)
    let v124 : US1 =
        match v4 with
        | US13_1(v7) -> (* Error *)
            let v8 : unit = ()
            let v9 : (unit -> unit) = closure49(v7)
            let v10 : unit = (fun () -> v9 (); v8) ()
            US1_1
        | US13_0(v5) -> (* Ok *)
            US1_0(v5)
    let v251 : US1 =
        match v124 with
        | US1_1 -> (* None *)
            let v127 : string = method76()
            let v128 : string = method51(v1, v2)
            let v129 : US13 = method70(v128, v127)
            match v129 with
            | US13_1(v132) -> (* Error *)
                let v133 : unit = ()
                let v134 : (unit -> unit) = closure49(v132)
                let v135 : unit = (fun () -> v134 (); v133) ()
                US1_1
            | US13_0(v130) -> (* Ok *)
                US1_0(v130)
        | US1_0(v125) -> (* Some *)
            US1_0(v125)
    let v255 : string =
        match v251 with
        | US1_1 -> (* None *)
            failwith<string> "Option does not have a value."
        | US1_0(v252) -> (* Some *)
            v252
    method51(v255, v1)
and method77 (v0 : string) : unit =
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
#else
    try
    let v2 : string = method54()
    let v3 : System.DateTime = System.DateTime.Now
    let v6 : (unit -> System.Guid) = System.Guid.NewGuid
    let v7 : System.Guid = v6 ()
    let v10 : System.Guid = method43(v7, v3)
    let v11 : string = $"{v2}_{v10}.txt"
    let v12 : string = __SOURCE_DIRECTORY__
    let v13 : string = "polyglot"
    let v14 : string = ".devcontainer"
    let v15 : string = method51(v13, v14)
    let v16 : US13 = method70(v15, v12)
    let v136 : US1 =
        match v16 with
        | US13_1(v19) -> (* Error *)
            let v20 : unit = ()
            let v21 : (unit -> unit) = closure49(v19)
            let v22 : unit = (fun () -> v21 (); v20) ()
            US1_1
        | US13_0(v17) -> (* Ok *)
            US1_0(v17)
    let v263 : US1 =
        match v136 with
        | US1_1 -> (* None *)
            let v139 : string = method76()
            let v140 : string = method51(v13, v14)
            let v141 : US13 = method70(v140, v139)
            match v141 with
            | US13_1(v144) -> (* Error *)
                let v145 : unit = ()
                let v146 : (unit -> unit) = closure49(v144)
                let v147 : unit = (fun () -> v146 (); v145) ()
                US1_1
            | US13_0(v142) -> (* Ok *)
                US1_0(v142)
        | US1_0(v137) -> (* Some *)
            US1_0(v137)
    let v267 : string =
        match v263 with
        | US1_1 -> (* None *)
            failwith<string> "Option does not have a value."
        | US1_0(v264) -> (* Some *)
            v264
    let v268 : string = method51(v267, v13)
    let v269 : string = "target/trace"
    let v270 : string = method51(v268, v269)
    let v271 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v272 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    let _v271 = v272 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v275 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    let _v271 = v275 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v278 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    let _v271 = v278 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v281 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    let _v271 = v281 
    #endif
#if FABLE_COMPILER_PYTHON
    let v284 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    let _v271 = v284 
    #endif
#else
    let v287 : (string -> System.IO.DirectoryInfo) = System.IO.Directory.CreateDirectory
    let v288 : System.IO.DirectoryInfo = v287 v270
    let _v271 = v288 
    #endif
    let v289 : System.IO.DirectoryInfo = _v271 
    let v294 : string = method51(v270, v11)
    let v295 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v296 : Async<unit> = null |> unbox<Async<unit>>
    let _v295 = v296 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v299 : Async<unit> = null |> unbox<Async<unit>>
    let _v295 = v299 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v302 : Async<unit> = null |> unbox<Async<unit>>
    let _v295 = v302 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v305 : Async<unit> = null |> unbox<Async<unit>>
    let _v295 = v305 
    #endif
#if FABLE_COMPILER_PYTHON
    let v308 : Async<unit> = null |> unbox<Async<unit>>
    let _v295 = v308 
    #endif
#else
    let v311 : System.Threading.Tasks.Task = System.IO.File.WriteAllTextAsync (v294, v0)
    let v312 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v313 : Async<unit> = null |> unbox<Async<unit>>
    let _v312 = v313 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v316 : Async<unit> = null |> unbox<Async<unit>>
    let _v312 = v316 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v319 : Async<unit> = null |> unbox<Async<unit>>
    let _v312 = v319 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v322 : Async<unit> = null |> unbox<Async<unit>>
    let _v312 = v322 
    #endif
#if FABLE_COMPILER_PYTHON
    let v325 : Async<unit> = null |> unbox<Async<unit>>
    let _v312 = v325 
    #endif
#else
    let v328 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
    let v329 : Async<unit> = v328 v311
    let _v312 = v329 
    #endif
    let v330 : Async<unit> = _v312 
    let _v295 = v330 
    #endif
    let v335 : Async<unit> = _v295 
    let v340 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    null |> unbox<unit>
    let _v340 = () 
    #endif
#if FABLE_COMPILER_RUST && WASM
    null |> unbox<unit>
    let _v340 = () 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    null |> unbox<unit>
    let _v340 = () 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    null |> unbox<unit>
    let _v340 = () 
    #endif
#if FABLE_COMPILER_PYTHON
    null |> unbox<unit>
    let _v340 = () 
    #endif
#else
    let v341 : (Async<unit> -> unit) = Async.RunSynchronously
    v341 v335
    let _v340 = () 
    #endif
    _v340 
    with ex ->
    let v342 : exn = ex
    let v343 : string = $"file_system.trace_file / ex: %A{v342}"
    method77(v343)
    (*
    *)
    let _v1 = () 
    #endif
    _v1 
    ()
and closure51 () (v0 : string) : unit =
    method77(v0)
and closure50 () (v0 : bool) : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure0()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v17 : Mut0, v18 : Mut1, v19 : Mut2, v20 : Mut3, v21 : Mut4, v22 : int64 option) = TraceState.trace_state.Value
    let v37 : (string -> unit) =
        if v0 then
            closure51()
        else
            closure2()
    v18.l0 <- v37
    ()
and method79 (v0 : string) : string =
    let v1 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = "&*$0"
    let v3 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v2 
    let v4 : string = "String::from($0)"
    let v5 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3 v4 
    let v6 : string = "std::path::PathBuf::from($0)"
    let v7 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v5 v6 
    let v8 : string = "$0.parent()"
    let v9 : Ref<std_path_Path> option = Fable.Core.RustInterop.emitRustExpr v7 v8 
    let v10 : string = "$0.unwrap()"
    let v11 : Ref<std_path_Path> = Fable.Core.RustInterop.emitRustExpr v9 v10 
    let v12 : string = "$0.display()"
    let v13 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v11 v12 
    let v14 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v15 : string = "format!(\"{}\", $0)"
    let v16 : std_string_String = Fable.Core.RustInterop.emitRustExpr v13 v15 
    let _v14 = v16 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v17 : string = "format!(\"{}\", $0)"
    let v18 : std_string_String = Fable.Core.RustInterop.emitRustExpr v13 v17 
    let _v14 = v18 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v19 : string = "format!(\"{}\", $0)"
    let v20 : std_string_String = Fable.Core.RustInterop.emitRustExpr v13 v19 
    let _v14 = v20 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v21 : std_string_String = null |> unbox<std_string_String>
    let _v14 = v21 
    #endif
#if FABLE_COMPILER_PYTHON
    let v24 : std_string_String = null |> unbox<std_string_String>
    let _v14 = v24 
    #endif
#else
    let v27 : std_string_String = null |> unbox<std_string_String>
    let _v14 = v27 
    #endif
    let v30 : std_string_String = _v14 
    let v35 : string = "fable_library_rust::String_::fromString($0)"
    let v36 : string = Fable.Core.RustInterop.emitRustExpr v30 v35 
    let _v1 = v36 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v37 : string = null |> unbox<string>
    let _v1 = v37 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v40 : string = null |> unbox<string>
    let _v1 = v40 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v43 : string = null |> unbox<string>
    let _v1 = v43 
    #endif
#if FABLE_COMPILER_PYTHON
    let v46 : string = null |> unbox<string>
    let _v1 = v46 
    #endif
#else
    let v49 : (string -> string) = System.IO.Path.GetDirectoryName
    let v50 : string = v49 v0
    let _v1 = v50 
    #endif
    let v51 : string = _v1 
    v51
and method78 (v0 : string, v1 : string) : unit =
    let v2 : bool = method9(v0)
    let v3 : bool = v2 = false
    if v3 then
        let v4 : System.IDisposable = method56(v0)
        ()
    let v5 : string = method79(v1)
    let v6 : bool = method9(v5)
    let v7 : bool = v6 = false
    if v7 then
        let v8 : System.IDisposable = method56(v5)
        ()
    let v9 : bool = method9(v1)
    let v34 : bool =
        if v9 then
            let v10 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v11 : string = "std::fs::read_link(&*$0)"
            let v12 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v1 v11 
            let _v10 = v12 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v13 : string = "std::fs::read_link(&*$0)"
            let v14 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v1 v13 
            let _v10 = v14 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v15 : string = "std::fs::read_link(&*$0)"
            let v16 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v1 v15 
            let _v10 = v16 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v17 : Result<std_path_PathBuf, std_io_Error> = null |> unbox<Result<std_path_PathBuf, std_io_Error>>
            let _v10 = v17 
            #endif
#if FABLE_COMPILER_PYTHON
            let v20 : Result<std_path_PathBuf, std_io_Error> = Unchecked.defaultof<_>
            let _v10 = v20 
            #endif
#else
            let v21 : Result<std_path_PathBuf, std_io_Error> = Unchecked.defaultof<_>
            let _v10 = v21 
            #endif
            let v22 : Result<std_path_PathBuf, std_io_Error> = _v10 
            let v25 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v26 : string = "$0.is_err()"
            let v27 : bool = Fable.Core.RustInterop.emitRustExpr v22 v26 
            let _v25 = v27 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v28 : string = "$0.is_err()"
            let v29 : bool = Fable.Core.RustInterop.emitRustExpr v22 v28 
            let _v25 = v29 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v30 : string = "$0.is_err()"
            let v31 : bool = Fable.Core.RustInterop.emitRustExpr v22 v30 
            let _v25 = v31 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let _v25 = true 
            #endif
#if FABLE_COMPILER_PYTHON
            let _v25 = true 
            #endif
#else
            let _v25 = true 
            #endif
            let v32 : bool = _v25 
            v32
        else
            false
    if v34 then
        let v35 : bool = true
        method7(v35, v1)
    let v36 : bool = method9(v1)
    let v37 : bool = v36 = false
    if v37 then
        let v38 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v39 : string = "true; #[cfg(windows)] std::os::windows::fs::symlink_dir(&*$0, &*$1).unwrap()"
        let v40 : bool = Fable.Core.RustInterop.emitRustExpr struct (v0, v1) v39 
        let v41 : string = "true; #[cfg(unix)] std::os::unix::fs::symlink(&*$0, &*$1).unwrap()"
        let v42 : bool = Fable.Core.RustInterop.emitRustExpr struct (v0, v1) v41 
        let _v38 = () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let _v38 = () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let _v38 = () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let _v38 = () 
        #endif
#if FABLE_COMPILER_PYTHON
        let _v38 = () 
        #endif
#else
        let v43 : System.IO.FileSystemInfo = System.IO.Directory.CreateSymbolicLink (v1, v0)
        let _v38 = () 
        #endif
        _v38 
        ()
and closure53 (v0 : string) (v1 : string) : unit =
    method78(v0, v1)
and closure52 () (v0 : string) : (string -> unit) =
    closure53(v0)
and closure55 (v0 : string) (v1 : string) : string =
    method51(v0, v1)
and closure54 () (v0 : string) : (string -> string) =
    closure55(v0)
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
let v31 : (string -> string) = closure46()
let new_file_uri x = v31 x
let v32 : (unit -> string) = closure47()
let get_workspace_root () = v32 ()
let v33 : (bool -> unit) = closure50()
let init_trace_file x = v33 x
let v34 : (string -> (string -> unit)) = closure52()
let link_directory x = v34 x
let v35 : (string -> (string -> string)) = closure54()
let (</>) x = v35 x
()
