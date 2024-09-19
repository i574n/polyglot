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
and closure1 (v0 : US1 option ref) (v1 : US1 option) : US1 option ref =
    v0.Value <- v1 
    v0
and closure2 (v0 : string option, v1 : (US1 option -> US1 option ref)) () : unit =
    match v0 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v2 : string = x
    let v3 : US1 = US1_0(v2)
    v3 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> v1 |> ignore
    ()
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
    let v64 : US1 option = None
    let _v64 = ref v64 
    let v65 : US1 option ref = _v64 
    let v66 : (US1 option -> US1 option ref) = closure1(v65)
    let v67 : unit = ()
    let v68 : (unit -> unit) = closure2(v61, v66)
    let v69 : unit = (fun () -> v68 (); v67) ()
    let v72 : US1 option = _v64.Value 
    let v83 : US1 = US1_1
    let v84 : US1 = v72 |> Option.defaultValue v83 
    let v91 : string =
        match v84 with
        | US1_1 -> (* None *)
            let v89 : string = ""
            v89
        | US1_0(v88) -> (* Some *)
            v88
    let _v1 = v91 
    #endif
#else
    let v92 : (string -> string) = System.Environment.GetEnvironmentVariable
    let v93 : string = v92 v0
    let mutable _v93 = None
    #if !FABLE_COMPILER && !WASM && !CONTRACT
    let v94 : (string -> string option) = Option.ofObj
    let v95 : string option = v94 v93
    v95 
    #else
    Some v93 
    #endif
    |> fun x -> _v93 <- Some x
    let v96 : string option = match _v93 with Some x -> x | None -> failwith "optionm'.of_obj / _v93=None"
    let v99 : US1 option = None
    let _v99 = ref v99 
    let v100 : US1 option ref = _v99 
    let v101 : (US1 option -> US1 option ref) = closure1(v100)
    let v102 : unit = ()
    let v103 : (unit -> unit) = closure2(v96, v101)
    let v104 : unit = (fun () -> v103 (); v102) ()
    let v107 : US1 option = _v99.Value 
    let v118 : US1 = US1_1
    let v119 : US1 = v107 |> Option.defaultValue v118 
    let v126 : string =
        match v119 with
        | US1_1 -> (* None *)
            let v124 : string = ""
            v124
        | US1_0(v123) -> (* Some *)
            v123
    let _v1 = v126 
    #endif
    let v127 : string = _v1 
    v127
and method4 () : string =
    let v0 : string = "AUTOMATION"
    v0
and closure3 () (v0 : string) : unit =
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
    let v50 : string = method4()
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
    let v159 : string = method4()
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
    let v220 : string = method4()
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
    let v281 : string = method4()
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
    let v359 : Mut0 = {l0 = 0L} : Mut0
    let v360 : (string -> unit) = closure3()
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
and method7 (v0 : string) : string =
    v0
and method8 (v0 : string) : bool =
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
and method6 (v0 : bool, v1 : string) : unit =
    let v2 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : string = method7(v1)
    let v4 : bool = method8(v3)
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
and closure6 (v0 : Mut0) () : unit =
    let v1 : int64 = v0.l0
    let v2 : int64 = v1 + 1L
    v0.l0 <- v2
    ()
and closure7 (v0 : US3 option ref) (v1 : US3 option) : US3 option ref =
    v0.Value <- v1 
    v0
and closure8 (v0 : int64 option, v1 : (US3 option -> US3 option ref)) () : unit =
    match v0 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v2 : int64 = x
    let v3 : US3 = US3_0(v2)
    v3 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> v1 |> ignore
    ()
and method9 () : string =
    let v0 : string = "hh:mm:ss"
    v0
and method10 () : string =
    let v0 : string = "HH:mm:ss"
    v0
and method11 () : string =
    let v0 : string = "\u001b[0m"
    v0
and method12 (v0 : string) : string =
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
and method13 () : string =
    let v0 : string = ""
    v0
and closure9 (v0 : Mut3, v1 : string) () : unit =
    let v2 : string = v0.l0
    let v3 : string = v2 + v1 
    v0.l0 <- v3
    ()
and closure11 (v0 : string) () : unit =
    let v1 : (string -> unit) = System.Console.WriteLine
    v1 v0
and closure10 () (v0 : string) : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure11(v0)
    let v3 : unit = (fun () -> v2 (); v1) ()
    ()
and closure5 (v0 : string, v1 : string) () : unit =
    let v2 : unit = ()
    let v3 : (unit -> unit) = closure0()
    let v4 : unit = (fun () -> v3 (); v2) ()
    let struct (v18 : Mut0, v19 : Mut1, v20 : Mut2, v21 : Mut3, v22 : Mut4, v23 : int64 option) = TraceState.trace_state.Value
    let v36 : unit = ()
    let v37 : unit = (fun () -> v3 (); v36) ()
    let struct (v51 : Mut0, v52 : Mut1, v53 : Mut2, v54 : Mut3, v55 : Mut4, v56 : int64 option) = TraceState.trace_state.Value
    let v69 : US0 = v55.l0
    let v70 : bool = v53.l0
    let v71 : bool = v70 = false
    let v74 : bool =
        if v71 then
            false
        else
            let v72 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v69
            let v73 : bool = 1 >= v72
            v73
    if v74 then
        let v75 : unit = ()
        let v76 : (unit -> unit) = closure6(v18)
        let v77 : unit = (fun () -> v76 (); v75) ()
        let v80 : unit = ()
        let v81 : unit = (fun () -> v3 (); v80) ()
        let struct (v95 : Mut0, v96 : Mut1, v97 : Mut2, v98 : Mut3, v99 : Mut4, v100 : int64 option) = TraceState.trace_state.Value
        let v113 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v114 : US3 option = None
        let _v114 = ref v114 
        let v115 : US3 option ref = _v114 
        let v116 : (US3 option -> US3 option ref) = closure7(v115)
        let v117 : unit = ()
        let v118 : (unit -> unit) = closure8(v100, v116)
        let v119 : unit = (fun () -> v118 (); v117) ()
        let v122 : US3 option = _v114.Value 
        let v133 : US3 = US3_1
        let v134 : US3 = v122 |> Option.defaultValue v133 
        let v174 : System.DateTime =
            match v134 with
            | US3_1 -> (* None *)
                let v170 : System.DateTime = System.DateTime.Now
                v170
            | US3_0(v138) -> (* Some *)
                let v139 : System.DateTime = System.DateTime.Now
                let v142 : (System.DateTime -> int64) = _.Ticks
                let v143 : int64 = v142 v139
                let v146 : int64 = v143 - v138
                let v147 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v148 : System.TimeSpan = v147 v146
                let v151 : (System.TimeSpan -> int32) = _.Hours
                let v152 : int32 = v151 v148
                let v155 : (System.TimeSpan -> int32) = _.Minutes
                let v156 : int32 = v155 v148
                let v159 : (System.TimeSpan -> int32) = _.Seconds
                let v160 : int32 = v159 v148
                let v163 : (System.TimeSpan -> int32) = _.Milliseconds
                let v164 : int32 = v163 v148
                let v167 : System.DateTime = System.DateTime (1, 1, 1, v152, v156, v160, v164)
                v167
        let v175 : string = method9()
        let v178 : (string -> string) = v174.ToString
        let v179 : string = v178 v175
        let _v113 = v179 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v182 : US3 option = None
        let _v182 = ref v182 
        let v183 : US3 option ref = _v182 
        let v184 : (US3 option -> US3 option ref) = closure7(v183)
        let v185 : unit = ()
        let v186 : (unit -> unit) = closure8(v100, v184)
        let v187 : unit = (fun () -> v186 (); v185) ()
        let v190 : US3 option = _v182.Value 
        let v201 : US3 = US3_1
        let v202 : US3 = v190 |> Option.defaultValue v201 
        let v242 : System.DateTime =
            match v202 with
            | US3_1 -> (* None *)
                let v238 : System.DateTime = System.DateTime.Now
                v238
            | US3_0(v206) -> (* Some *)
                let v207 : System.DateTime = System.DateTime.Now
                let v210 : (System.DateTime -> int64) = _.Ticks
                let v211 : int64 = v210 v207
                let v214 : int64 = v211 - v206
                let v215 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v216 : System.TimeSpan = v215 v214
                let v219 : (System.TimeSpan -> int32) = _.Hours
                let v220 : int32 = v219 v216
                let v223 : (System.TimeSpan -> int32) = _.Minutes
                let v224 : int32 = v223 v216
                let v227 : (System.TimeSpan -> int32) = _.Seconds
                let v228 : int32 = v227 v216
                let v231 : (System.TimeSpan -> int32) = _.Milliseconds
                let v232 : int32 = v231 v216
                let v235 : System.DateTime = System.DateTime (1, 1, 1, v220, v224, v228, v232)
                v235
        let v243 : string = method9()
        let v246 : (string -> string) = v242.ToString
        let v247 : string = v246 v243
        let _v113 = v247 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v250 : string = $"near_sdk::env::block_timestamp()"
        let v251 : uint64 = Fable.Core.RustInterop.emitRustExpr () v250 
        let v252 : US3 option = None
        let _v252 = ref v252 
        let v253 : US3 option ref = _v252 
        let v254 : (US3 option -> US3 option ref) = closure7(v253)
        let v255 : unit = ()
        let v256 : (unit -> unit) = closure8(v100, v254)
        let v257 : unit = (fun () -> v256 (); v255) ()
        let v260 : US3 option = _v252.Value 
        let v271 : US3 = US3_1
        let v272 : US3 = v260 |> Option.defaultValue v271 
        let v281 : uint64 =
            match v272 with
            | US3_1 -> (* None *)
                v251
            | US3_0(v276) -> (* Some *)
                let v277 : (int64 -> uint64) = uint64
                let v278 : uint64 = v277 v276
                let v279 : uint64 = v251 - v278
                v279
        let v282 : uint64 = v281 / 1000000000UL
        let v283 : uint64 = v282 % 60UL
        let v284 : uint64 = v282 / 60UL
        let v285 : uint64 = v284 % 60UL
        let v286 : uint64 = v282 / 3600UL
        let v287 : uint64 = v286 % 24UL
        let v288 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
        let v289 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v287, v285, v283) v288 
        let v290 : string = "fable_library_rust::String_::fromString($0)"
        let v291 : string = Fable.Core.RustInterop.emitRustExpr v289 v290 
        let _v113 = v291 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v292 : US3 option = None
        let _v292 = ref v292 
        let v293 : US3 option ref = _v292 
        let v294 : (US3 option -> US3 option ref) = closure7(v293)
        let v295 : unit = ()
        let v296 : (unit -> unit) = closure8(v100, v294)
        let v297 : unit = (fun () -> v296 (); v295) ()
        let v300 : US3 option = _v292.Value 
        let v311 : US3 = US3_1
        let v312 : US3 = v300 |> Option.defaultValue v311 
        let v352 : System.DateTime =
            match v312 with
            | US3_1 -> (* None *)
                let v348 : System.DateTime = System.DateTime.Now
                v348
            | US3_0(v316) -> (* Some *)
                let v317 : System.DateTime = System.DateTime.Now
                let v320 : (System.DateTime -> int64) = _.Ticks
                let v321 : int64 = v320 v317
                let v324 : int64 = v321 - v316
                let v325 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v326 : System.TimeSpan = v325 v324
                let v329 : (System.TimeSpan -> int32) = _.Hours
                let v330 : int32 = v329 v326
                let v333 : (System.TimeSpan -> int32) = _.Minutes
                let v334 : int32 = v333 v326
                let v337 : (System.TimeSpan -> int32) = _.Seconds
                let v338 : int32 = v337 v326
                let v341 : (System.TimeSpan -> int32) = _.Milliseconds
                let v342 : int32 = v341 v326
                let v345 : System.DateTime = System.DateTime (1, 1, 1, v330, v334, v338, v342)
                v345
        let v353 : string = method10()
        let v356 : (string -> string) = v352.ToString
        let v357 : string = v356 v353
        let _v113 = v357 
        #endif
#if FABLE_COMPILER_PYTHON
        let v360 : US3 option = None
        let _v360 = ref v360 
        let v361 : US3 option ref = _v360 
        let v362 : (US3 option -> US3 option ref) = closure7(v361)
        let v363 : unit = ()
        let v364 : (unit -> unit) = closure8(v100, v362)
        let v365 : unit = (fun () -> v364 (); v363) ()
        let v368 : US3 option = _v360.Value 
        let v379 : US3 = US3_1
        let v380 : US3 = v368 |> Option.defaultValue v379 
        let v420 : System.DateTime =
            match v380 with
            | US3_1 -> (* None *)
                let v416 : System.DateTime = System.DateTime.Now
                v416
            | US3_0(v384) -> (* Some *)
                let v385 : System.DateTime = System.DateTime.Now
                let v388 : (System.DateTime -> int64) = _.Ticks
                let v389 : int64 = v388 v385
                let v392 : int64 = v389 - v384
                let v393 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v394 : System.TimeSpan = v393 v392
                let v397 : (System.TimeSpan -> int32) = _.Hours
                let v398 : int32 = v397 v394
                let v401 : (System.TimeSpan -> int32) = _.Minutes
                let v402 : int32 = v401 v394
                let v405 : (System.TimeSpan -> int32) = _.Seconds
                let v406 : int32 = v405 v394
                let v409 : (System.TimeSpan -> int32) = _.Milliseconds
                let v410 : int32 = v409 v394
                let v413 : System.DateTime = System.DateTime (1, 1, 1, v398, v402, v406, v410)
                v413
        let v421 : string = method10()
        let v424 : (string -> string) = v420.ToString
        let v425 : string = v424 v421
        let _v113 = v425 
        #endif
#else
        let v428 : US3 option = None
        let _v428 = ref v428 
        let v429 : US3 option ref = _v428 
        let v430 : (US3 option -> US3 option ref) = closure7(v429)
        let v431 : unit = ()
        let v432 : (unit -> unit) = closure8(v100, v430)
        let v433 : unit = (fun () -> v432 (); v431) ()
        let v436 : US3 option = _v428.Value 
        let v447 : US3 = US3_1
        let v448 : US3 = v436 |> Option.defaultValue v447 
        let v488 : System.DateTime =
            match v448 with
            | US3_1 -> (* None *)
                let v484 : System.DateTime = System.DateTime.Now
                v484
            | US3_0(v452) -> (* Some *)
                let v453 : System.DateTime = System.DateTime.Now
                let v456 : (System.DateTime -> int64) = _.Ticks
                let v457 : int64 = v456 v453
                let v460 : int64 = v457 - v452
                let v461 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v462 : System.TimeSpan = v461 v460
                let v465 : (System.TimeSpan -> int32) = _.Hours
                let v466 : int32 = v465 v462
                let v469 : (System.TimeSpan -> int32) = _.Minutes
                let v470 : int32 = v469 v462
                let v473 : (System.TimeSpan -> int32) = _.Seconds
                let v474 : int32 = v473 v462
                let v477 : (System.TimeSpan -> int32) = _.Milliseconds
                let v478 : int32 = v477 v462
                let v481 : System.DateTime = System.DateTime (1, 1, 1, v466, v470, v474, v478)
                v481
        let v489 : string = method10()
        let v492 : (string -> string) = v488.ToString
        let v493 : string = v492 v489
        let _v113 = v493 
        #endif
        let v496 : string = _v113 
        
        
        
        
        
        let v566 : string = "Debug"
        let v567 : (unit -> string) = v566.ToLower
        let v568 : string = v567 ()
        let v571 : string = v568.PadLeft (7, ' ')
        let v585 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v586 : string = "inline_colorization::color_bright_blue"
        let v587 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v586 
        let v588 : string = "&*$0"
        let v589 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v571 v588 
        let v590 : string = "inline_colorization::color_reset"
        let v591 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v590 
        let v592 : string = "\"{v587}{v589}{v591}\""
        let v593 : string = @$"format!(" + v592 + ")"
        let v594 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v593 
        let v595 : string = "fable_library_rust::String_::fromString($0)"
        let v596 : string = Fable.Core.RustInterop.emitRustExpr v594 v595 
        let _v585 = v596 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v597 : string = "inline_colorization::color_bright_blue"
        let v598 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v597 
        let v599 : string = "&*$0"
        let v600 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v571 v599 
        let v601 : string = "inline_colorization::color_reset"
        let v602 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v601 
        let v603 : string = "\"{v598}{v600}{v602}\""
        let v604 : string = @$"format!(" + v603 + ")"
        let v605 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v604 
        let v606 : string = "fable_library_rust::String_::fromString($0)"
        let v607 : string = Fable.Core.RustInterop.emitRustExpr v605 v606 
        let _v585 = v607 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v608 : string = "inline_colorization::color_bright_blue"
        let v609 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v608 
        let v610 : string = "&*$0"
        let v611 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v571 v610 
        let v612 : string = "inline_colorization::color_reset"
        let v613 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v612 
        let v614 : string = "\"{v609}{v611}{v613}\""
        let v615 : string = @$"format!(" + v614 + ")"
        let v616 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v615 
        let v617 : string = "fable_library_rust::String_::fromString($0)"
        let v618 : string = Fable.Core.RustInterop.emitRustExpr v616 v617 
        let _v585 = v618 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v619 : string = "\u001b[94m"
        let v620 : string = method11()
        let v621 : string = v619 + v571 
        let v622 : string = v621 + v620 
        let _v585 = v622 
        #endif
#if FABLE_COMPILER_PYTHON
        let v623 : string = "\u001b[94m"
        let v624 : string = method11()
        let v625 : string = v623 + v571 
        let v626 : string = v625 + v624 
        let _v585 = v626 
        #endif
#else
        let v627 : string = "\u001b[94m"
        let v628 : string = method11()
        let v629 : string = v627 + v571 
        let v630 : string = v629 + v628 
        let _v585 = v630 
        #endif
        let v631 : string = _v585 
        let v637 : int64 = v95.l0
        let v638 : string = method12(v0)
        let v639 : string = method13()
        let v640 : Mut3 = {l0 = v639} : Mut3
        let v641 : string = "{ "
        let v642 : string = $"{v641}"
        let v645 : unit = ()
        let v646 : (unit -> unit) = closure9(v640, v642)
        let v647 : unit = (fun () -> v646 (); v645) ()
        let v650 : string = "ex"
        let v651 : string = $"{v650}"
        let v654 : unit = ()
        let v655 : (unit -> unit) = closure9(v640, v651)
        let v656 : unit = (fun () -> v655 (); v654) ()
        let v659 : string = " = "
        let v660 : string = $"{v659}"
        let v663 : unit = ()
        let v664 : (unit -> unit) = closure9(v640, v660)
        let v665 : unit = (fun () -> v664 (); v663) ()
        let v668 : string = $"{v1}"
        let v671 : unit = ()
        let v672 : (unit -> unit) = closure9(v640, v668)
        let v673 : unit = (fun () -> v672 (); v671) ()
        let v676 : string = "; "
        let v677 : string = $"{v676}"
        let v680 : unit = ()
        let v681 : (unit -> unit) = closure9(v640, v677)
        let v682 : unit = (fun () -> v681 (); v680) ()
        let v685 : string = "path"
        let v686 : string = $"{v685}"
        let v689 : unit = ()
        let v690 : (unit -> unit) = closure9(v640, v686)
        let v691 : unit = (fun () -> v690 (); v689) ()
        let v694 : string = $"{v659}"
        let v697 : unit = ()
        let v698 : (unit -> unit) = closure9(v640, v694)
        let v699 : unit = (fun () -> v698 (); v697) ()
        let v702 : string = $"{v638}"
        let v705 : unit = ()
        let v706 : (unit -> unit) = closure9(v640, v702)
        let v707 : unit = (fun () -> v706 (); v705) ()
        let v710 : string = " }"
        let v711 : string = $"{v710}"
        let v714 : unit = ()
        let v715 : (unit -> unit) = closure9(v640, v711)
        let v716 : unit = (fun () -> v715 (); v714) ()
        let v719 : string = v640.l0
        let v720 : string = "file_system.delete_directory_async"
        let v721 : string = $"{v496} {v631} #{v637} %s{v720} / {v719}"
        let v724 : char list = []
        let v725 : (char list -> (char [])) = List.toArray
        let v726 : (char []) = v725 v724
        let v729 : string = v721.TrimStart v726 
        let v747 : char list = []
        let v748 : char list = '/' :: v747 
        let v751 : char list = ' ' :: v748 
        let v754 : (char list -> (char [])) = List.toArray
        let v755 : (char []) = v754 v751
        let v758 : string = v729.TrimEnd v755 
        let v776 : (string -> unit) = closure10()
        let v777 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v778 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v758 v778 
        let _v777 = () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v779 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v758 v779 
        let _v777 = () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v780 : string = v21.l0
        let v781 : bool = v780 = ""
        let v789 : string =
            if v781 then
                v758
            else
                let v782 : bool = v758 = ""
                if v782 then
                    let v783 : string = v21.l0
                    v783
                else
                    let v784 : string = v21.l0
                    let v785 : string = "\n"
                    let v786 : string = v784 + v785 
                    let v787 : string = v786 + v758 
                    v787
        let v790 : string = "&*$0"
        let v791 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v789 v790 
        let v792 : string = $"$0.chars()"
        let v793 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v791 v792 
        let v794 : string = "v793"
        let v795 : _ = Fable.Core.RustInterop.emitRustExpr () v794 
        let v796 : string = "v795.collect::<Vec<_>>()"
        let v797 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v796 
        let v798 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
        let v799 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v797 v798 
        let v800 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
        let v801 : bool = Fable.Core.RustInterop.emitRustExpr v799 v800 
        let v802 : string = "x"
        let v803 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v802 
        let v804 : string = "String::from_iter($0)"
        let v805 : std_string_String = Fable.Core.RustInterop.emitRustExpr v803 v804 
        let v806 : string = "true; $0 }).collect::<Vec<_>>()"
        let v807 : bool = Fable.Core.RustInterop.emitRustExpr v805 v806 
        let v808 : string = "_vec_map"
        let v809 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v808 
        let v810 : string = "$0.len()"
        let v811 : unativeint = Fable.Core.RustInterop.emitRustExpr v809 v810 
        let v812 : (unativeint -> int32) = int32
        let v813 : int32 = v812 v811
        let v814 : string = ""
        let v815 : bool = v758 <> v814 
        let v819 : bool =
            if v815 then
                let v818 : bool = v813 <= 1
                v818
            else
                false
        if v819 then
            v21.l0 <- v789
            ()
        else
            v21.l0 <- v814
            let v820 : string = "true; $0.into_iter().for_each(|x| { //"
            let v821 : bool = Fable.Core.RustInterop.emitRustExpr v809 v820 
            let v822 : string = "x"
            let v823 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v822 
            let v824 : string = $"near_sdk::log!(\"{{}}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v823 v824 
            let v825 : string = $"true;"
            let v826 : bool = Fable.Core.RustInterop.emitRustExpr () v825 
            let v827 : string = "true; }}); { //"
            let v828 : bool = Fable.Core.RustInterop.emitRustExpr () v827 
            ()
        let _v777 = () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        v776 v758
        let _v777 = () 
        #endif
#if FABLE_COMPILER_PYTHON
        v776 v758
        let _v777 = () 
        #endif
#else
        v776 v758
        let _v777 = () 
        #endif
        _v777 
        let v829 : (string -> unit) = v19.l0
        v829 v758
and method5 (v0 : string, v1 : int64) : Async<int64> =
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
    method6(v19, v0)
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
        let v46 : (unit -> unit) = closure5(v0, v40)
        let v47 : unit = (fun () -> v46 (); v45) ()
        ()
    let v876 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v877 : Async<unit> = null |> unbox<Async<unit>>
    let _v876 = v877 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v880 : Async<unit> = null |> unbox<Async<unit>>
    let _v876 = v880 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v883 : Async<unit> = null |> unbox<Async<unit>>
    let _v876 = v883 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v886 : Async<unit> = null |> unbox<Async<unit>>
    let _v876 = v886 
    #endif
#if FABLE_COMPILER_PYTHON
    let v889 : Async<unit> = null |> unbox<Async<unit>>
    let _v876 = v889 
    #endif
#else
    let v892 : (int32 -> Async<unit>) = Async.Sleep
    let v893 : Async<unit> = v892 10
    let _v876 = v893 
    #endif
    let v894 : Async<unit> = _v876 
    do! v894 
    let v899 : int64 = v1 + 1L
    let v900 : Async<int64> = method5(v0, v899)
    return! v900 
    (*
    let v901 : int64 = *)
    }
    |> fun x -> _v18 <- Some x
    let v902 : Async<int64> = match _v18 with Some x -> x | None -> failwith "async.new_async_unit / _v18=None"
    let _v2 = v902 
    #endif
    let v903 : Async<int64> = _v2 
    v903
and closure4 () (v0 : string) : Async<int64> =
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
    let v18 : Async<int64> = method5(v0, v17)
    let _v1 = v18 
    #endif
    let v19 : Async<int64> = _v1 
    v19
and closure14 (v0 : string, v1 : int64, v2 : string) () : unit =
    let v3 : unit = ()
    let v4 : (unit -> unit) = closure0()
    let v5 : unit = (fun () -> v4 (); v3) ()
    let struct (v19 : Mut0, v20 : Mut1, v21 : Mut2, v22 : Mut3, v23 : Mut4, v24 : int64 option) = TraceState.trace_state.Value
    let v37 : unit = ()
    let v38 : unit = (fun () -> v4 (); v37) ()
    let struct (v52 : Mut0, v53 : Mut1, v54 : Mut2, v55 : Mut3, v56 : Mut4, v57 : int64 option) = TraceState.trace_state.Value
    let v70 : US0 = v56.l0
    let v71 : bool = v54.l0
    let v72 : bool = v71 = false
    let v75 : bool =
        if v72 then
            false
        else
            let v73 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v70
            let v74 : bool = 1 >= v73
            v74
    if v75 then
        let v76 : unit = ()
        let v77 : (unit -> unit) = closure6(v19)
        let v78 : unit = (fun () -> v77 (); v76) ()
        let v81 : unit = ()
        let v82 : unit = (fun () -> v4 (); v81) ()
        let struct (v96 : Mut0, v97 : Mut1, v98 : Mut2, v99 : Mut3, v100 : Mut4, v101 : int64 option) = TraceState.trace_state.Value
        let v114 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v115 : US3 option = None
        let _v115 = ref v115 
        let v116 : US3 option ref = _v115 
        let v117 : (US3 option -> US3 option ref) = closure7(v116)
        let v118 : unit = ()
        let v119 : (unit -> unit) = closure8(v101, v117)
        let v120 : unit = (fun () -> v119 (); v118) ()
        let v123 : US3 option = _v115.Value 
        let v134 : US3 = US3_1
        let v135 : US3 = v123 |> Option.defaultValue v134 
        let v175 : System.DateTime =
            match v135 with
            | US3_1 -> (* None *)
                let v171 : System.DateTime = System.DateTime.Now
                v171
            | US3_0(v139) -> (* Some *)
                let v140 : System.DateTime = System.DateTime.Now
                let v143 : (System.DateTime -> int64) = _.Ticks
                let v144 : int64 = v143 v140
                let v147 : int64 = v144 - v139
                let v148 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v149 : System.TimeSpan = v148 v147
                let v152 : (System.TimeSpan -> int32) = _.Hours
                let v153 : int32 = v152 v149
                let v156 : (System.TimeSpan -> int32) = _.Minutes
                let v157 : int32 = v156 v149
                let v160 : (System.TimeSpan -> int32) = _.Seconds
                let v161 : int32 = v160 v149
                let v164 : (System.TimeSpan -> int32) = _.Milliseconds
                let v165 : int32 = v164 v149
                let v168 : System.DateTime = System.DateTime (1, 1, 1, v153, v157, v161, v165)
                v168
        let v176 : string = method9()
        let v179 : (string -> string) = v175.ToString
        let v180 : string = v179 v176
        let _v114 = v180 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v183 : US3 option = None
        let _v183 = ref v183 
        let v184 : US3 option ref = _v183 
        let v185 : (US3 option -> US3 option ref) = closure7(v184)
        let v186 : unit = ()
        let v187 : (unit -> unit) = closure8(v101, v185)
        let v188 : unit = (fun () -> v187 (); v186) ()
        let v191 : US3 option = _v183.Value 
        let v202 : US3 = US3_1
        let v203 : US3 = v191 |> Option.defaultValue v202 
        let v243 : System.DateTime =
            match v203 with
            | US3_1 -> (* None *)
                let v239 : System.DateTime = System.DateTime.Now
                v239
            | US3_0(v207) -> (* Some *)
                let v208 : System.DateTime = System.DateTime.Now
                let v211 : (System.DateTime -> int64) = _.Ticks
                let v212 : int64 = v211 v208
                let v215 : int64 = v212 - v207
                let v216 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v217 : System.TimeSpan = v216 v215
                let v220 : (System.TimeSpan -> int32) = _.Hours
                let v221 : int32 = v220 v217
                let v224 : (System.TimeSpan -> int32) = _.Minutes
                let v225 : int32 = v224 v217
                let v228 : (System.TimeSpan -> int32) = _.Seconds
                let v229 : int32 = v228 v217
                let v232 : (System.TimeSpan -> int32) = _.Milliseconds
                let v233 : int32 = v232 v217
                let v236 : System.DateTime = System.DateTime (1, 1, 1, v221, v225, v229, v233)
                v236
        let v244 : string = method9()
        let v247 : (string -> string) = v243.ToString
        let v248 : string = v247 v244
        let _v114 = v248 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v251 : string = $"near_sdk::env::block_timestamp()"
        let v252 : uint64 = Fable.Core.RustInterop.emitRustExpr () v251 
        let v253 : US3 option = None
        let _v253 = ref v253 
        let v254 : US3 option ref = _v253 
        let v255 : (US3 option -> US3 option ref) = closure7(v254)
        let v256 : unit = ()
        let v257 : (unit -> unit) = closure8(v101, v255)
        let v258 : unit = (fun () -> v257 (); v256) ()
        let v261 : US3 option = _v253.Value 
        let v272 : US3 = US3_1
        let v273 : US3 = v261 |> Option.defaultValue v272 
        let v282 : uint64 =
            match v273 with
            | US3_1 -> (* None *)
                v252
            | US3_0(v277) -> (* Some *)
                let v278 : (int64 -> uint64) = uint64
                let v279 : uint64 = v278 v277
                let v280 : uint64 = v252 - v279
                v280
        let v283 : uint64 = v282 / 1000000000UL
        let v284 : uint64 = v283 % 60UL
        let v285 : uint64 = v283 / 60UL
        let v286 : uint64 = v285 % 60UL
        let v287 : uint64 = v283 / 3600UL
        let v288 : uint64 = v287 % 24UL
        let v289 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
        let v290 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v288, v286, v284) v289 
        let v291 : string = "fable_library_rust::String_::fromString($0)"
        let v292 : string = Fable.Core.RustInterop.emitRustExpr v290 v291 
        let _v114 = v292 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v293 : US3 option = None
        let _v293 = ref v293 
        let v294 : US3 option ref = _v293 
        let v295 : (US3 option -> US3 option ref) = closure7(v294)
        let v296 : unit = ()
        let v297 : (unit -> unit) = closure8(v101, v295)
        let v298 : unit = (fun () -> v297 (); v296) ()
        let v301 : US3 option = _v293.Value 
        let v312 : US3 = US3_1
        let v313 : US3 = v301 |> Option.defaultValue v312 
        let v353 : System.DateTime =
            match v313 with
            | US3_1 -> (* None *)
                let v349 : System.DateTime = System.DateTime.Now
                v349
            | US3_0(v317) -> (* Some *)
                let v318 : System.DateTime = System.DateTime.Now
                let v321 : (System.DateTime -> int64) = _.Ticks
                let v322 : int64 = v321 v318
                let v325 : int64 = v322 - v317
                let v326 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v327 : System.TimeSpan = v326 v325
                let v330 : (System.TimeSpan -> int32) = _.Hours
                let v331 : int32 = v330 v327
                let v334 : (System.TimeSpan -> int32) = _.Minutes
                let v335 : int32 = v334 v327
                let v338 : (System.TimeSpan -> int32) = _.Seconds
                let v339 : int32 = v338 v327
                let v342 : (System.TimeSpan -> int32) = _.Milliseconds
                let v343 : int32 = v342 v327
                let v346 : System.DateTime = System.DateTime (1, 1, 1, v331, v335, v339, v343)
                v346
        let v354 : string = method10()
        let v357 : (string -> string) = v353.ToString
        let v358 : string = v357 v354
        let _v114 = v358 
        #endif
#if FABLE_COMPILER_PYTHON
        let v361 : US3 option = None
        let _v361 = ref v361 
        let v362 : US3 option ref = _v361 
        let v363 : (US3 option -> US3 option ref) = closure7(v362)
        let v364 : unit = ()
        let v365 : (unit -> unit) = closure8(v101, v363)
        let v366 : unit = (fun () -> v365 (); v364) ()
        let v369 : US3 option = _v361.Value 
        let v380 : US3 = US3_1
        let v381 : US3 = v369 |> Option.defaultValue v380 
        let v421 : System.DateTime =
            match v381 with
            | US3_1 -> (* None *)
                let v417 : System.DateTime = System.DateTime.Now
                v417
            | US3_0(v385) -> (* Some *)
                let v386 : System.DateTime = System.DateTime.Now
                let v389 : (System.DateTime -> int64) = _.Ticks
                let v390 : int64 = v389 v386
                let v393 : int64 = v390 - v385
                let v394 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v395 : System.TimeSpan = v394 v393
                let v398 : (System.TimeSpan -> int32) = _.Hours
                let v399 : int32 = v398 v395
                let v402 : (System.TimeSpan -> int32) = _.Minutes
                let v403 : int32 = v402 v395
                let v406 : (System.TimeSpan -> int32) = _.Seconds
                let v407 : int32 = v406 v395
                let v410 : (System.TimeSpan -> int32) = _.Milliseconds
                let v411 : int32 = v410 v395
                let v414 : System.DateTime = System.DateTime (1, 1, 1, v399, v403, v407, v411)
                v414
        let v422 : string = method10()
        let v425 : (string -> string) = v421.ToString
        let v426 : string = v425 v422
        let _v114 = v426 
        #endif
#else
        let v429 : US3 option = None
        let _v429 = ref v429 
        let v430 : US3 option ref = _v429 
        let v431 : (US3 option -> US3 option ref) = closure7(v430)
        let v432 : unit = ()
        let v433 : (unit -> unit) = closure8(v101, v431)
        let v434 : unit = (fun () -> v433 (); v432) ()
        let v437 : US3 option = _v429.Value 
        let v448 : US3 = US3_1
        let v449 : US3 = v437 |> Option.defaultValue v448 
        let v489 : System.DateTime =
            match v449 with
            | US3_1 -> (* None *)
                let v485 : System.DateTime = System.DateTime.Now
                v485
            | US3_0(v453) -> (* Some *)
                let v454 : System.DateTime = System.DateTime.Now
                let v457 : (System.DateTime -> int64) = _.Ticks
                let v458 : int64 = v457 v454
                let v461 : int64 = v458 - v453
                let v462 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v463 : System.TimeSpan = v462 v461
                let v466 : (System.TimeSpan -> int32) = _.Hours
                let v467 : int32 = v466 v463
                let v470 : (System.TimeSpan -> int32) = _.Minutes
                let v471 : int32 = v470 v463
                let v474 : (System.TimeSpan -> int32) = _.Seconds
                let v475 : int32 = v474 v463
                let v478 : (System.TimeSpan -> int32) = _.Milliseconds
                let v479 : int32 = v478 v463
                let v482 : System.DateTime = System.DateTime (1, 1, 1, v467, v471, v475, v479)
                v482
        let v490 : string = method10()
        let v493 : (string -> string) = v489.ToString
        let v494 : string = v493 v490
        let _v114 = v494 
        #endif
        let v497 : string = _v114 
        
        
        
        
        
        let v567 : string = "Debug"
        let v568 : (unit -> string) = v567.ToLower
        let v569 : string = v568 ()
        let v572 : string = v569.PadLeft (7, ' ')
        let v586 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v587 : string = "inline_colorization::color_bright_blue"
        let v588 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v587 
        let v589 : string = "&*$0"
        let v590 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v572 v589 
        let v591 : string = "inline_colorization::color_reset"
        let v592 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v591 
        let v593 : string = "\"{v588}{v590}{v592}\""
        let v594 : string = @$"format!(" + v593 + ")"
        let v595 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v594 
        let v596 : string = "fable_library_rust::String_::fromString($0)"
        let v597 : string = Fable.Core.RustInterop.emitRustExpr v595 v596 
        let _v586 = v597 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v598 : string = "inline_colorization::color_bright_blue"
        let v599 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v598 
        let v600 : string = "&*$0"
        let v601 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v572 v600 
        let v602 : string = "inline_colorization::color_reset"
        let v603 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v602 
        let v604 : string = "\"{v599}{v601}{v603}\""
        let v605 : string = @$"format!(" + v604 + ")"
        let v606 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v605 
        let v607 : string = "fable_library_rust::String_::fromString($0)"
        let v608 : string = Fable.Core.RustInterop.emitRustExpr v606 v607 
        let _v586 = v608 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v609 : string = "inline_colorization::color_bright_blue"
        let v610 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v609 
        let v611 : string = "&*$0"
        let v612 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v572 v611 
        let v613 : string = "inline_colorization::color_reset"
        let v614 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v613 
        let v615 : string = "\"{v610}{v612}{v614}\""
        let v616 : string = @$"format!(" + v615 + ")"
        let v617 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v616 
        let v618 : string = "fable_library_rust::String_::fromString($0)"
        let v619 : string = Fable.Core.RustInterop.emitRustExpr v617 v618 
        let _v586 = v619 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v620 : string = "\u001b[94m"
        let v621 : string = method11()
        let v622 : string = v620 + v572 
        let v623 : string = v622 + v621 
        let _v586 = v623 
        #endif
#if FABLE_COMPILER_PYTHON
        let v624 : string = "\u001b[94m"
        let v625 : string = method11()
        let v626 : string = v624 + v572 
        let v627 : string = v626 + v625 
        let _v586 = v627 
        #endif
#else
        let v628 : string = "\u001b[94m"
        let v629 : string = method11()
        let v630 : string = v628 + v572 
        let v631 : string = v630 + v629 
        let _v586 = v631 
        #endif
        let v632 : string = _v586 
        let v638 : int64 = v96.l0
        let v639 : string = method12(v0)
        let v640 : string = method13()
        let v641 : Mut3 = {l0 = v640} : Mut3
        let v642 : string = "{ "
        let v643 : string = $"{v642}"
        let v646 : unit = ()
        let v647 : (unit -> unit) = closure9(v641, v643)
        let v648 : unit = (fun () -> v647 (); v646) ()
        let v651 : string = "path"
        let v652 : string = $"{v651}"
        let v655 : unit = ()
        let v656 : (unit -> unit) = closure9(v641, v652)
        let v657 : unit = (fun () -> v656 (); v655) ()
        let v660 : string = " = "
        let v661 : string = $"{v660}"
        let v664 : unit = ()
        let v665 : (unit -> unit) = closure9(v641, v661)
        let v666 : unit = (fun () -> v665 (); v664) ()
        let v669 : string = $"{v639}"
        let v672 : unit = ()
        let v673 : (unit -> unit) = closure9(v641, v669)
        let v674 : unit = (fun () -> v673 (); v672) ()
        let v677 : string = "; "
        let v678 : string = $"{v677}"
        let v681 : unit = ()
        let v682 : (unit -> unit) = closure9(v641, v678)
        let v683 : unit = (fun () -> v682 (); v681) ()
        let v686 : string = "retry"
        let v687 : string = $"{v686}"
        let v690 : unit = ()
        let v691 : (unit -> unit) = closure9(v641, v687)
        let v692 : unit = (fun () -> v691 (); v690) ()
        let v695 : string = $"{v660}"
        let v698 : unit = ()
        let v699 : (unit -> unit) = closure9(v641, v695)
        let v700 : unit = (fun () -> v699 (); v698) ()
        let v703 : string = $"{v1}"
        let v706 : unit = ()
        let v707 : (unit -> unit) = closure9(v641, v703)
        let v708 : unit = (fun () -> v707 (); v706) ()
        let v711 : string = $"{v677}"
        let v714 : unit = ()
        let v715 : (unit -> unit) = closure9(v641, v711)
        let v716 : unit = (fun () -> v715 (); v714) ()
        let v719 : string = "ex"
        let v720 : string = $"{v719}"
        let v723 : unit = ()
        let v724 : (unit -> unit) = closure9(v641, v720)
        let v725 : unit = (fun () -> v724 (); v723) ()
        let v728 : string = $"{v660}"
        let v731 : unit = ()
        let v732 : (unit -> unit) = closure9(v641, v728)
        let v733 : unit = (fun () -> v732 (); v731) ()
        let v736 : string = $"{v2}"
        let v739 : unit = ()
        let v740 : (unit -> unit) = closure9(v641, v736)
        let v741 : unit = (fun () -> v740 (); v739) ()
        let v744 : string = " }"
        let v745 : string = $"{v744}"
        let v748 : unit = ()
        let v749 : (unit -> unit) = closure9(v641, v745)
        let v750 : unit = (fun () -> v749 (); v748) ()
        let v753 : string = v641.l0
        let v754 : string = "file_system.wait_for_file_access"
        let v755 : string = $"{v497} {v632} #{v638} %s{v754} / {v753}"
        let v758 : char list = []
        let v759 : (char list -> (char [])) = List.toArray
        let v760 : (char []) = v759 v758
        let v763 : string = v755.TrimStart v760 
        let v781 : char list = []
        let v782 : char list = '/' :: v781 
        let v785 : char list = ' ' :: v782 
        let v788 : (char list -> (char [])) = List.toArray
        let v789 : (char []) = v788 v785
        let v792 : string = v763.TrimEnd v789 
        let v810 : (string -> unit) = closure10()
        let v811 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v812 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v792 v812 
        let _v811 = () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v813 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v792 v813 
        let _v811 = () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v814 : string = v22.l0
        let v815 : bool = v814 = ""
        let v823 : string =
            if v815 then
                v792
            else
                let v816 : bool = v792 = ""
                if v816 then
                    let v817 : string = v22.l0
                    v817
                else
                    let v818 : string = v22.l0
                    let v819 : string = "\n"
                    let v820 : string = v818 + v819 
                    let v821 : string = v820 + v792 
                    v821
        let v824 : string = "&*$0"
        let v825 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v823 v824 
        let v826 : string = $"$0.chars()"
        let v827 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v825 v826 
        let v828 : string = "v827"
        let v829 : _ = Fable.Core.RustInterop.emitRustExpr () v828 
        let v830 : string = "v829.collect::<Vec<_>>()"
        let v831 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v830 
        let v832 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
        let v833 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v831 v832 
        let v834 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
        let v835 : bool = Fable.Core.RustInterop.emitRustExpr v833 v834 
        let v836 : string = "x"
        let v837 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v836 
        let v838 : string = "String::from_iter($0)"
        let v839 : std_string_String = Fable.Core.RustInterop.emitRustExpr v837 v838 
        let v840 : string = "true; $0 }).collect::<Vec<_>>()"
        let v841 : bool = Fable.Core.RustInterop.emitRustExpr v839 v840 
        let v842 : string = "_vec_map"
        let v843 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v842 
        let v844 : string = "$0.len()"
        let v845 : unativeint = Fable.Core.RustInterop.emitRustExpr v843 v844 
        let v846 : (unativeint -> int32) = int32
        let v847 : int32 = v846 v845
        let v848 : string = ""
        let v849 : bool = v792 <> v848 
        let v853 : bool =
            if v849 then
                let v852 : bool = v847 <= 1
                v852
            else
                false
        if v853 then
            v22.l0 <- v823
            ()
        else
            v22.l0 <- v848
            let v854 : string = "true; $0.into_iter().for_each(|x| { //"
            let v855 : bool = Fable.Core.RustInterop.emitRustExpr v843 v854 
            let v856 : string = "x"
            let v857 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v856 
            let v858 : string = $"near_sdk::log!(\"{{}}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v857 v858 
            let v859 : string = $"true;"
            let v860 : bool = Fable.Core.RustInterop.emitRustExpr () v859 
            let v861 : string = "true; }}); { //"
            let v862 : bool = Fable.Core.RustInterop.emitRustExpr () v861 
            ()
        let _v811 = () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        v810 v792
        let _v811 = () 
        #endif
#if FABLE_COMPILER_PYTHON
        v810 v792
        let _v811 = () 
        #endif
#else
        v810 v792
        let _v811 = () 
        #endif
        _v811 
        let v863 : (string -> unit) = v20.l0
        v863 v792
and method14 (v0 : string, v1 : US8, v2 : US7, v3 : int64) : Async<int64> =
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
        let v89 : (unit -> unit) = closure14(v0, v3, v83)
        let v90 : unit = (fun () -> v89 (); v88) ()
        ()
    let v952 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v953 : Async<unit> = null |> unbox<Async<unit>>
    let _v952 = v953 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v956 : Async<unit> = null |> unbox<Async<unit>>
    let _v952 = v956 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v959 : Async<unit> = null |> unbox<Async<unit>>
    let _v952 = v959 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v962 : Async<unit> = null |> unbox<Async<unit>>
    let _v952 = v962 
    #endif
#if FABLE_COMPILER_PYTHON
    let v965 : Async<unit> = null |> unbox<Async<unit>>
    let _v952 = v965 
    #endif
#else
    let v968 : (int32 -> Async<unit>) = Async.Sleep
    let v969 : Async<unit> = v968 10
    let _v952 = v969 
    #endif
    let v970 : Async<unit> = _v952 
    do! v970 
    let v975 : int64 = v3 + 1L
    let v976 : Async<int64> = method14(v0, v1, v2, v975)
    return! v976 
    (*
    let v977 : int64 = *)
    }
    |> fun x -> _v20 <- Some x
    let v978 : Async<int64> = match _v20 with Some x -> x | None -> failwith "async.new_async_unit / _v20=None"
    let _v4 = v978 
    #endif
    let v979 : Async<int64> = _v4 
    v979
and closure13 (v0 : US6) (v1 : string) : Async<int64> =
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
    let v27 : Async<int64> = method14(v1, v25, v24, v26)
    let _v2 = v27 
    #endif
    let v28 : Async<int64> = _v2 
    v28
and closure12 () (v0 : US6) : (string -> Async<int64>) =
    closure13(v0)
and method15 (v0 : string, v1 : int64) : Async<int64> =
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
        let v73 : (unit -> unit) = closure14(v0, v1, v67)
        let v74 : unit = (fun () -> v73 (); v72) ()
        ()
    let v936 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v937 : Async<unit> = null |> unbox<Async<unit>>
    let _v936 = v937 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v940 : Async<unit> = null |> unbox<Async<unit>>
    let _v936 = v940 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v943 : Async<unit> = null |> unbox<Async<unit>>
    let _v936 = v943 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v946 : Async<unit> = null |> unbox<Async<unit>>
    let _v936 = v946 
    #endif
#if FABLE_COMPILER_PYTHON
    let v949 : Async<unit> = null |> unbox<Async<unit>>
    let _v936 = v949 
    #endif
#else
    let v952 : (int32 -> Async<unit>) = Async.Sleep
    let v953 : Async<unit> = v952 10
    let _v936 = v953 
    #endif
    let v954 : Async<unit> = _v936 
    do! v954 
    let v959 : int64 = v1 + 1L
    let v960 : Async<int64> = method15(v0, v959)
    return! v960 
    (*
    let v961 : int64 = *)
    }
    |> fun x -> _v18 <- Some x
    let v962 : Async<int64> = match _v18 with Some x -> x | None -> failwith "async.new_async_unit / _v18=None"
    let _v2 = v962 
    #endif
    let v963 : Async<int64> = _v2 
    v963
and closure15 () (v0 : string) : Async<int64> =
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
    let v18 : Async<int64> = method15(v0, v17)
    let _v1 = v18 
    #endif
    let v19 : Async<int64> = _v1 
    v19
and closure16 () (v0 : string) : Async<string> =
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
and method17 (v0 : string) : bool =
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
and method18 (v0 : Vec<uint8>) : Vec<uint8> =
    v0
and method16 (v0 : string, v1 : string) : bool =
    let v2 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : bool = method17(v0)
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
            let v31 : Vec<uint8> = method18(v26)
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
and closure18 (v0 : string) (v1 : string) : bool =
    method16(v0, v1)
and closure17 () (v0 : string) : (string -> bool) =
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
and closure19 () (v0 : string) : (string -> Async<unit>) =
    closure20(v0)
and closure22 (v0 : string) (v1 : string) : Async<unit> =
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
    let v52 : bool = method17(v0)
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
and closure21 () (v0 : string) : (string -> Async<unit>) =
    closure22(v0)
and closure24 (v0 : string, v1 : exn) () : unit =
    let v2 : unit = ()
    let v3 : (unit -> unit) = closure0()
    let v4 : unit = (fun () -> v3 (); v2) ()
    let struct (v18 : Mut0, v19 : Mut1, v20 : Mut2, v21 : Mut3, v22 : Mut4, v23 : int64 option) = TraceState.trace_state.Value
    let v36 : unit = ()
    let v37 : unit = (fun () -> v3 (); v36) ()
    let struct (v51 : Mut0, v52 : Mut1, v53 : Mut2, v54 : Mut3, v55 : Mut4, v56 : int64 option) = TraceState.trace_state.Value
    let v69 : US0 = v55.l0
    let v70 : bool = v53.l0
    let v71 : bool = v70 = false
    let v74 : bool =
        if v71 then
            false
        else
            let v72 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v69
            let v73 : bool = 3 >= v72
            v73
    if v74 then
        let v75 : unit = ()
        let v76 : (unit -> unit) = closure6(v18)
        let v77 : unit = (fun () -> v76 (); v75) ()
        let v80 : unit = ()
        let v81 : unit = (fun () -> v3 (); v80) ()
        let struct (v95 : Mut0, v96 : Mut1, v97 : Mut2, v98 : Mut3, v99 : Mut4, v100 : int64 option) = TraceState.trace_state.Value
        let v113 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v114 : US3 option = None
        let _v114 = ref v114 
        let v115 : US3 option ref = _v114 
        let v116 : (US3 option -> US3 option ref) = closure7(v115)
        let v117 : unit = ()
        let v118 : (unit -> unit) = closure8(v100, v116)
        let v119 : unit = (fun () -> v118 (); v117) ()
        let v122 : US3 option = _v114.Value 
        let v133 : US3 = US3_1
        let v134 : US3 = v122 |> Option.defaultValue v133 
        let v174 : System.DateTime =
            match v134 with
            | US3_1 -> (* None *)
                let v170 : System.DateTime = System.DateTime.Now
                v170
            | US3_0(v138) -> (* Some *)
                let v139 : System.DateTime = System.DateTime.Now
                let v142 : (System.DateTime -> int64) = _.Ticks
                let v143 : int64 = v142 v139
                let v146 : int64 = v143 - v138
                let v147 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v148 : System.TimeSpan = v147 v146
                let v151 : (System.TimeSpan -> int32) = _.Hours
                let v152 : int32 = v151 v148
                let v155 : (System.TimeSpan -> int32) = _.Minutes
                let v156 : int32 = v155 v148
                let v159 : (System.TimeSpan -> int32) = _.Seconds
                let v160 : int32 = v159 v148
                let v163 : (System.TimeSpan -> int32) = _.Milliseconds
                let v164 : int32 = v163 v148
                let v167 : System.DateTime = System.DateTime (1, 1, 1, v152, v156, v160, v164)
                v167
        let v175 : string = method9()
        let v178 : (string -> string) = v174.ToString
        let v179 : string = v178 v175
        let _v113 = v179 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v182 : US3 option = None
        let _v182 = ref v182 
        let v183 : US3 option ref = _v182 
        let v184 : (US3 option -> US3 option ref) = closure7(v183)
        let v185 : unit = ()
        let v186 : (unit -> unit) = closure8(v100, v184)
        let v187 : unit = (fun () -> v186 (); v185) ()
        let v190 : US3 option = _v182.Value 
        let v201 : US3 = US3_1
        let v202 : US3 = v190 |> Option.defaultValue v201 
        let v242 : System.DateTime =
            match v202 with
            | US3_1 -> (* None *)
                let v238 : System.DateTime = System.DateTime.Now
                v238
            | US3_0(v206) -> (* Some *)
                let v207 : System.DateTime = System.DateTime.Now
                let v210 : (System.DateTime -> int64) = _.Ticks
                let v211 : int64 = v210 v207
                let v214 : int64 = v211 - v206
                let v215 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v216 : System.TimeSpan = v215 v214
                let v219 : (System.TimeSpan -> int32) = _.Hours
                let v220 : int32 = v219 v216
                let v223 : (System.TimeSpan -> int32) = _.Minutes
                let v224 : int32 = v223 v216
                let v227 : (System.TimeSpan -> int32) = _.Seconds
                let v228 : int32 = v227 v216
                let v231 : (System.TimeSpan -> int32) = _.Milliseconds
                let v232 : int32 = v231 v216
                let v235 : System.DateTime = System.DateTime (1, 1, 1, v220, v224, v228, v232)
                v235
        let v243 : string = method9()
        let v246 : (string -> string) = v242.ToString
        let v247 : string = v246 v243
        let _v113 = v247 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v250 : string = $"near_sdk::env::block_timestamp()"
        let v251 : uint64 = Fable.Core.RustInterop.emitRustExpr () v250 
        let v252 : US3 option = None
        let _v252 = ref v252 
        let v253 : US3 option ref = _v252 
        let v254 : (US3 option -> US3 option ref) = closure7(v253)
        let v255 : unit = ()
        let v256 : (unit -> unit) = closure8(v100, v254)
        let v257 : unit = (fun () -> v256 (); v255) ()
        let v260 : US3 option = _v252.Value 
        let v271 : US3 = US3_1
        let v272 : US3 = v260 |> Option.defaultValue v271 
        let v281 : uint64 =
            match v272 with
            | US3_1 -> (* None *)
                v251
            | US3_0(v276) -> (* Some *)
                let v277 : (int64 -> uint64) = uint64
                let v278 : uint64 = v277 v276
                let v279 : uint64 = v251 - v278
                v279
        let v282 : uint64 = v281 / 1000000000UL
        let v283 : uint64 = v282 % 60UL
        let v284 : uint64 = v282 / 60UL
        let v285 : uint64 = v284 % 60UL
        let v286 : uint64 = v282 / 3600UL
        let v287 : uint64 = v286 % 24UL
        let v288 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
        let v289 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v287, v285, v283) v288 
        let v290 : string = "fable_library_rust::String_::fromString($0)"
        let v291 : string = Fable.Core.RustInterop.emitRustExpr v289 v290 
        let _v113 = v291 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v292 : US3 option = None
        let _v292 = ref v292 
        let v293 : US3 option ref = _v292 
        let v294 : (US3 option -> US3 option ref) = closure7(v293)
        let v295 : unit = ()
        let v296 : (unit -> unit) = closure8(v100, v294)
        let v297 : unit = (fun () -> v296 (); v295) ()
        let v300 : US3 option = _v292.Value 
        let v311 : US3 = US3_1
        let v312 : US3 = v300 |> Option.defaultValue v311 
        let v352 : System.DateTime =
            match v312 with
            | US3_1 -> (* None *)
                let v348 : System.DateTime = System.DateTime.Now
                v348
            | US3_0(v316) -> (* Some *)
                let v317 : System.DateTime = System.DateTime.Now
                let v320 : (System.DateTime -> int64) = _.Ticks
                let v321 : int64 = v320 v317
                let v324 : int64 = v321 - v316
                let v325 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v326 : System.TimeSpan = v325 v324
                let v329 : (System.TimeSpan -> int32) = _.Hours
                let v330 : int32 = v329 v326
                let v333 : (System.TimeSpan -> int32) = _.Minutes
                let v334 : int32 = v333 v326
                let v337 : (System.TimeSpan -> int32) = _.Seconds
                let v338 : int32 = v337 v326
                let v341 : (System.TimeSpan -> int32) = _.Milliseconds
                let v342 : int32 = v341 v326
                let v345 : System.DateTime = System.DateTime (1, 1, 1, v330, v334, v338, v342)
                v345
        let v353 : string = method10()
        let v356 : (string -> string) = v352.ToString
        let v357 : string = v356 v353
        let _v113 = v357 
        #endif
#if FABLE_COMPILER_PYTHON
        let v360 : US3 option = None
        let _v360 = ref v360 
        let v361 : US3 option ref = _v360 
        let v362 : (US3 option -> US3 option ref) = closure7(v361)
        let v363 : unit = ()
        let v364 : (unit -> unit) = closure8(v100, v362)
        let v365 : unit = (fun () -> v364 (); v363) ()
        let v368 : US3 option = _v360.Value 
        let v379 : US3 = US3_1
        let v380 : US3 = v368 |> Option.defaultValue v379 
        let v420 : System.DateTime =
            match v380 with
            | US3_1 -> (* None *)
                let v416 : System.DateTime = System.DateTime.Now
                v416
            | US3_0(v384) -> (* Some *)
                let v385 : System.DateTime = System.DateTime.Now
                let v388 : (System.DateTime -> int64) = _.Ticks
                let v389 : int64 = v388 v385
                let v392 : int64 = v389 - v384
                let v393 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v394 : System.TimeSpan = v393 v392
                let v397 : (System.TimeSpan -> int32) = _.Hours
                let v398 : int32 = v397 v394
                let v401 : (System.TimeSpan -> int32) = _.Minutes
                let v402 : int32 = v401 v394
                let v405 : (System.TimeSpan -> int32) = _.Seconds
                let v406 : int32 = v405 v394
                let v409 : (System.TimeSpan -> int32) = _.Milliseconds
                let v410 : int32 = v409 v394
                let v413 : System.DateTime = System.DateTime (1, 1, 1, v398, v402, v406, v410)
                v413
        let v421 : string = method10()
        let v424 : (string -> string) = v420.ToString
        let v425 : string = v424 v421
        let _v113 = v425 
        #endif
#else
        let v428 : US3 option = None
        let _v428 = ref v428 
        let v429 : US3 option ref = _v428 
        let v430 : (US3 option -> US3 option ref) = closure7(v429)
        let v431 : unit = ()
        let v432 : (unit -> unit) = closure8(v100, v430)
        let v433 : unit = (fun () -> v432 (); v431) ()
        let v436 : US3 option = _v428.Value 
        let v447 : US3 = US3_1
        let v448 : US3 = v436 |> Option.defaultValue v447 
        let v488 : System.DateTime =
            match v448 with
            | US3_1 -> (* None *)
                let v484 : System.DateTime = System.DateTime.Now
                v484
            | US3_0(v452) -> (* Some *)
                let v453 : System.DateTime = System.DateTime.Now
                let v456 : (System.DateTime -> int64) = _.Ticks
                let v457 : int64 = v456 v453
                let v460 : int64 = v457 - v452
                let v461 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v462 : System.TimeSpan = v461 v460
                let v465 : (System.TimeSpan -> int32) = _.Hours
                let v466 : int32 = v465 v462
                let v469 : (System.TimeSpan -> int32) = _.Minutes
                let v470 : int32 = v469 v462
                let v473 : (System.TimeSpan -> int32) = _.Seconds
                let v474 : int32 = v473 v462
                let v477 : (System.TimeSpan -> int32) = _.Milliseconds
                let v478 : int32 = v477 v462
                let v481 : System.DateTime = System.DateTime (1, 1, 1, v466, v470, v474, v478)
                v481
        let v489 : string = method10()
        let v492 : (string -> string) = v488.ToString
        let v493 : string = v492 v489
        let _v113 = v493 
        #endif
        let v496 : string = _v113 
        
        
        
        
        
        let v566 : string = "Warning"
        let v567 : (unit -> string) = v566.ToLower
        let v568 : string = v567 ()
        let v571 : string = v568.PadLeft (7, ' ')
        let v585 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v586 : string = "inline_colorization::color_yellow"
        let v587 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v586 
        let v588 : string = "&*$0"
        let v589 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v571 v588 
        let v590 : string = "inline_colorization::color_reset"
        let v591 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v590 
        let v592 : string = "\"{v587}{v589}{v591}\""
        let v593 : string = @$"format!(" + v592 + ")"
        let v594 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v593 
        let v595 : string = "fable_library_rust::String_::fromString($0)"
        let v596 : string = Fable.Core.RustInterop.emitRustExpr v594 v595 
        let _v585 = v596 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v597 : string = "inline_colorization::color_yellow"
        let v598 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v597 
        let v599 : string = "&*$0"
        let v600 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v571 v599 
        let v601 : string = "inline_colorization::color_reset"
        let v602 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v601 
        let v603 : string = "\"{v598}{v600}{v602}\""
        let v604 : string = @$"format!(" + v603 + ")"
        let v605 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v604 
        let v606 : string = "fable_library_rust::String_::fromString($0)"
        let v607 : string = Fable.Core.RustInterop.emitRustExpr v605 v606 
        let _v585 = v607 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v608 : string = "inline_colorization::color_yellow"
        let v609 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v608 
        let v610 : string = "&*$0"
        let v611 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v571 v610 
        let v612 : string = "inline_colorization::color_reset"
        let v613 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v612 
        let v614 : string = "\"{v609}{v611}{v613}\""
        let v615 : string = @$"format!(" + v614 + ")"
        let v616 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v615 
        let v617 : string = "fable_library_rust::String_::fromString($0)"
        let v618 : string = Fable.Core.RustInterop.emitRustExpr v616 v617 
        let _v585 = v618 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v619 : string = "\u001b[93m"
        let v620 : string = method11()
        let v621 : string = v619 + v571 
        let v622 : string = v621 + v620 
        let _v585 = v622 
        #endif
#if FABLE_COMPILER_PYTHON
        let v623 : string = "\u001b[93m"
        let v624 : string = method11()
        let v625 : string = v623 + v571 
        let v626 : string = v625 + v624 
        let _v585 = v626 
        #endif
#else
        let v627 : string = "\u001b[93m"
        let v628 : string = method11()
        let v629 : string = v627 + v571 
        let v630 : string = v629 + v628 
        let _v585 = v630 
        #endif
        let v631 : string = _v585 
        let v637 : int64 = v95.l0
        let v638 : string = method12(v0)
        let v639 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v640 : string = $"%A{v1}"
        let _v639 = v640 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v643 : string = $"%A{v1}"
        let _v639 = v643 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v646 : string = $"%A{v1}"
        let _v639 = v646 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v649 : string = $"%A{v1}"
        let _v639 = v649 
        #endif
#if FABLE_COMPILER_PYTHON
        let v652 : string = $"%A{v1}"
        let _v639 = v652 
        #endif
#else
        let v655 : string = $"{v1.GetType ()}: {v1.Message}"
        let _v639 = v655 
        #endif
        let v656 : string = _v639 
        let v661 : string = method13()
        let v662 : Mut3 = {l0 = v661} : Mut3
        let v663 : string = "{ "
        let v664 : string = $"{v663}"
        let v667 : unit = ()
        let v668 : (unit -> unit) = closure9(v662, v664)
        let v669 : unit = (fun () -> v668 (); v667) ()
        let v672 : string = "path"
        let v673 : string = $"{v672}"
        let v676 : unit = ()
        let v677 : (unit -> unit) = closure9(v662, v673)
        let v678 : unit = (fun () -> v677 (); v676) ()
        let v681 : string = " = "
        let v682 : string = $"{v681}"
        let v685 : unit = ()
        let v686 : (unit -> unit) = closure9(v662, v682)
        let v687 : unit = (fun () -> v686 (); v685) ()
        let v690 : string = $"{v638}"
        let v693 : unit = ()
        let v694 : (unit -> unit) = closure9(v662, v690)
        let v695 : unit = (fun () -> v694 (); v693) ()
        let v698 : string = "; "
        let v699 : string = $"{v698}"
        let v702 : unit = ()
        let v703 : (unit -> unit) = closure9(v662, v699)
        let v704 : unit = (fun () -> v703 (); v702) ()
        let v707 : string = "ex"
        let v708 : string = $"{v707}"
        let v711 : unit = ()
        let v712 : (unit -> unit) = closure9(v662, v708)
        let v713 : unit = (fun () -> v712 (); v711) ()
        let v716 : string = $"{v681}"
        let v719 : unit = ()
        let v720 : (unit -> unit) = closure9(v662, v716)
        let v721 : unit = (fun () -> v720 (); v719) ()
        let v724 : string = $"{v656}"
        let v727 : unit = ()
        let v728 : (unit -> unit) = closure9(v662, v724)
        let v729 : unit = (fun () -> v728 (); v727) ()
        let v732 : string = " }"
        let v733 : string = $"{v732}"
        let v736 : unit = ()
        let v737 : (unit -> unit) = closure9(v662, v733)
        let v738 : unit = (fun () -> v737 (); v736) ()
        let v741 : string = v662.l0
        let v742 : string = "delete_file_async"
        let v743 : string = $"{v496} {v631} #{v637} %s{v742} / {v741}"
        let v746 : char list = []
        let v747 : (char list -> (char [])) = List.toArray
        let v748 : (char []) = v747 v746
        let v751 : string = v743.TrimStart v748 
        let v769 : char list = []
        let v770 : char list = '/' :: v769 
        let v773 : char list = ' ' :: v770 
        let v776 : (char list -> (char [])) = List.toArray
        let v777 : (char []) = v776 v773
        let v780 : string = v751.TrimEnd v777 
        let v798 : (string -> unit) = closure10()
        let v799 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v800 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v780 v800 
        let _v799 = () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v801 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v780 v801 
        let _v799 = () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v802 : string = v21.l0
        let v803 : bool = v802 = ""
        let v811 : string =
            if v803 then
                v780
            else
                let v804 : bool = v780 = ""
                if v804 then
                    let v805 : string = v21.l0
                    v805
                else
                    let v806 : string = v21.l0
                    let v807 : string = "\n"
                    let v808 : string = v806 + v807 
                    let v809 : string = v808 + v780 
                    v809
        let v812 : string = "&*$0"
        let v813 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v811 v812 
        let v814 : string = $"$0.chars()"
        let v815 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v813 v814 
        let v816 : string = "v815"
        let v817 : _ = Fable.Core.RustInterop.emitRustExpr () v816 
        let v818 : string = "v817.collect::<Vec<_>>()"
        let v819 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v818 
        let v820 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
        let v821 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v819 v820 
        let v822 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
        let v823 : bool = Fable.Core.RustInterop.emitRustExpr v821 v822 
        let v824 : string = "x"
        let v825 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v824 
        let v826 : string = "String::from_iter($0)"
        let v827 : std_string_String = Fable.Core.RustInterop.emitRustExpr v825 v826 
        let v828 : string = "true; $0 }).collect::<Vec<_>>()"
        let v829 : bool = Fable.Core.RustInterop.emitRustExpr v827 v828 
        let v830 : string = "_vec_map"
        let v831 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v830 
        let v832 : string = "$0.len()"
        let v833 : unativeint = Fable.Core.RustInterop.emitRustExpr v831 v832 
        let v834 : (unativeint -> int32) = int32
        let v835 : int32 = v834 v833
        let v836 : string = ""
        let v837 : bool = v780 <> v836 
        let v841 : bool =
            if v837 then
                let v840 : bool = v835 <= 1
                v840
            else
                false
        if v841 then
            v21.l0 <- v811
            ()
        else
            v21.l0 <- v836
            let v842 : string = "true; $0.into_iter().for_each(|x| { //"
            let v843 : bool = Fable.Core.RustInterop.emitRustExpr v831 v842 
            let v844 : string = "x"
            let v845 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v844 
            let v846 : string = $"near_sdk::log!(\"{{}}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v845 v846 
            let v847 : string = $"true;"
            let v848 : bool = Fable.Core.RustInterop.emitRustExpr () v847 
            let v849 : string = "true; }}); { //"
            let v850 : bool = Fable.Core.RustInterop.emitRustExpr () v849 
            ()
        let _v799 = () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        v798 v780
        let _v799 = () 
        #endif
#if FABLE_COMPILER_PYTHON
        v798 v780
        let _v799 = () 
        #endif
#else
        v798 v780
        let _v799 = () 
        #endif
        _v799 
        let v851 : (string -> unit) = v19.l0
        v851 v780
and method19 (v0 : string, v1 : int64) : Async<int64> =
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
        let v26 : (unit -> unit) = closure24(v0, v22)
        let v27 : unit = (fun () -> v26 (); v25) ()
        ()
    let v878 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v879 : Async<unit> = null |> unbox<Async<unit>>
    let _v878 = v879 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v882 : Async<unit> = null |> unbox<Async<unit>>
    let _v878 = v882 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v885 : Async<unit> = null |> unbox<Async<unit>>
    let _v878 = v885 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v888 : Async<unit> = null |> unbox<Async<unit>>
    let _v878 = v888 
    #endif
#if FABLE_COMPILER_PYTHON
    let v891 : Async<unit> = null |> unbox<Async<unit>>
    let _v878 = v891 
    #endif
#else
    let v894 : (int32 -> Async<unit>) = Async.Sleep
    let v895 : Async<unit> = v894 10
    let _v878 = v895 
    #endif
    let v896 : Async<unit> = _v878 
    do! v896 
    let v901 : int64 = v1 + 1L
    let v902 : Async<int64> = method19(v0, v901)
    return! v902 
    (*
    let v903 : int64 = *)
    }
    |> fun x -> _v18 <- Some x
    let v904 : Async<int64> = match _v18 with Some x -> x | None -> failwith "async.new_async_unit / _v18=None"
    let _v2 = v904 
    #endif
    let v905 : Async<int64> = _v2 
    v905
and closure23 () (v0 : string) : Async<int64> =
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
    let v18 : Async<int64> = method19(v0, v17)
    let _v1 = v18 
    #endif
    let v19 : Async<int64> = _v1 
    v19
and closure27 (v0 : string, v1 : string, v2 : exn) () : unit =
    let v3 : unit = ()
    let v4 : (unit -> unit) = closure0()
    let v5 : unit = (fun () -> v4 (); v3) ()
    let struct (v19 : Mut0, v20 : Mut1, v21 : Mut2, v22 : Mut3, v23 : Mut4, v24 : int64 option) = TraceState.trace_state.Value
    let v37 : unit = ()
    let v38 : unit = (fun () -> v4 (); v37) ()
    let struct (v52 : Mut0, v53 : Mut1, v54 : Mut2, v55 : Mut3, v56 : Mut4, v57 : int64 option) = TraceState.trace_state.Value
    let v70 : US0 = v56.l0
    let v71 : bool = v54.l0
    let v72 : bool = v71 = false
    let v75 : bool =
        if v72 then
            false
        else
            let v73 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v70
            let v74 : bool = 3 >= v73
            v74
    if v75 then
        let v76 : unit = ()
        let v77 : (unit -> unit) = closure6(v19)
        let v78 : unit = (fun () -> v77 (); v76) ()
        let v81 : unit = ()
        let v82 : unit = (fun () -> v4 (); v81) ()
        let struct (v96 : Mut0, v97 : Mut1, v98 : Mut2, v99 : Mut3, v100 : Mut4, v101 : int64 option) = TraceState.trace_state.Value
        let v114 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v115 : US3 option = None
        let _v115 = ref v115 
        let v116 : US3 option ref = _v115 
        let v117 : (US3 option -> US3 option ref) = closure7(v116)
        let v118 : unit = ()
        let v119 : (unit -> unit) = closure8(v101, v117)
        let v120 : unit = (fun () -> v119 (); v118) ()
        let v123 : US3 option = _v115.Value 
        let v134 : US3 = US3_1
        let v135 : US3 = v123 |> Option.defaultValue v134 
        let v175 : System.DateTime =
            match v135 with
            | US3_1 -> (* None *)
                let v171 : System.DateTime = System.DateTime.Now
                v171
            | US3_0(v139) -> (* Some *)
                let v140 : System.DateTime = System.DateTime.Now
                let v143 : (System.DateTime -> int64) = _.Ticks
                let v144 : int64 = v143 v140
                let v147 : int64 = v144 - v139
                let v148 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v149 : System.TimeSpan = v148 v147
                let v152 : (System.TimeSpan -> int32) = _.Hours
                let v153 : int32 = v152 v149
                let v156 : (System.TimeSpan -> int32) = _.Minutes
                let v157 : int32 = v156 v149
                let v160 : (System.TimeSpan -> int32) = _.Seconds
                let v161 : int32 = v160 v149
                let v164 : (System.TimeSpan -> int32) = _.Milliseconds
                let v165 : int32 = v164 v149
                let v168 : System.DateTime = System.DateTime (1, 1, 1, v153, v157, v161, v165)
                v168
        let v176 : string = method9()
        let v179 : (string -> string) = v175.ToString
        let v180 : string = v179 v176
        let _v114 = v180 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v183 : US3 option = None
        let _v183 = ref v183 
        let v184 : US3 option ref = _v183 
        let v185 : (US3 option -> US3 option ref) = closure7(v184)
        let v186 : unit = ()
        let v187 : (unit -> unit) = closure8(v101, v185)
        let v188 : unit = (fun () -> v187 (); v186) ()
        let v191 : US3 option = _v183.Value 
        let v202 : US3 = US3_1
        let v203 : US3 = v191 |> Option.defaultValue v202 
        let v243 : System.DateTime =
            match v203 with
            | US3_1 -> (* None *)
                let v239 : System.DateTime = System.DateTime.Now
                v239
            | US3_0(v207) -> (* Some *)
                let v208 : System.DateTime = System.DateTime.Now
                let v211 : (System.DateTime -> int64) = _.Ticks
                let v212 : int64 = v211 v208
                let v215 : int64 = v212 - v207
                let v216 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v217 : System.TimeSpan = v216 v215
                let v220 : (System.TimeSpan -> int32) = _.Hours
                let v221 : int32 = v220 v217
                let v224 : (System.TimeSpan -> int32) = _.Minutes
                let v225 : int32 = v224 v217
                let v228 : (System.TimeSpan -> int32) = _.Seconds
                let v229 : int32 = v228 v217
                let v232 : (System.TimeSpan -> int32) = _.Milliseconds
                let v233 : int32 = v232 v217
                let v236 : System.DateTime = System.DateTime (1, 1, 1, v221, v225, v229, v233)
                v236
        let v244 : string = method9()
        let v247 : (string -> string) = v243.ToString
        let v248 : string = v247 v244
        let _v114 = v248 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v251 : string = $"near_sdk::env::block_timestamp()"
        let v252 : uint64 = Fable.Core.RustInterop.emitRustExpr () v251 
        let v253 : US3 option = None
        let _v253 = ref v253 
        let v254 : US3 option ref = _v253 
        let v255 : (US3 option -> US3 option ref) = closure7(v254)
        let v256 : unit = ()
        let v257 : (unit -> unit) = closure8(v101, v255)
        let v258 : unit = (fun () -> v257 (); v256) ()
        let v261 : US3 option = _v253.Value 
        let v272 : US3 = US3_1
        let v273 : US3 = v261 |> Option.defaultValue v272 
        let v282 : uint64 =
            match v273 with
            | US3_1 -> (* None *)
                v252
            | US3_0(v277) -> (* Some *)
                let v278 : (int64 -> uint64) = uint64
                let v279 : uint64 = v278 v277
                let v280 : uint64 = v252 - v279
                v280
        let v283 : uint64 = v282 / 1000000000UL
        let v284 : uint64 = v283 % 60UL
        let v285 : uint64 = v283 / 60UL
        let v286 : uint64 = v285 % 60UL
        let v287 : uint64 = v283 / 3600UL
        let v288 : uint64 = v287 % 24UL
        let v289 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
        let v290 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v288, v286, v284) v289 
        let v291 : string = "fable_library_rust::String_::fromString($0)"
        let v292 : string = Fable.Core.RustInterop.emitRustExpr v290 v291 
        let _v114 = v292 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v293 : US3 option = None
        let _v293 = ref v293 
        let v294 : US3 option ref = _v293 
        let v295 : (US3 option -> US3 option ref) = closure7(v294)
        let v296 : unit = ()
        let v297 : (unit -> unit) = closure8(v101, v295)
        let v298 : unit = (fun () -> v297 (); v296) ()
        let v301 : US3 option = _v293.Value 
        let v312 : US3 = US3_1
        let v313 : US3 = v301 |> Option.defaultValue v312 
        let v353 : System.DateTime =
            match v313 with
            | US3_1 -> (* None *)
                let v349 : System.DateTime = System.DateTime.Now
                v349
            | US3_0(v317) -> (* Some *)
                let v318 : System.DateTime = System.DateTime.Now
                let v321 : (System.DateTime -> int64) = _.Ticks
                let v322 : int64 = v321 v318
                let v325 : int64 = v322 - v317
                let v326 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v327 : System.TimeSpan = v326 v325
                let v330 : (System.TimeSpan -> int32) = _.Hours
                let v331 : int32 = v330 v327
                let v334 : (System.TimeSpan -> int32) = _.Minutes
                let v335 : int32 = v334 v327
                let v338 : (System.TimeSpan -> int32) = _.Seconds
                let v339 : int32 = v338 v327
                let v342 : (System.TimeSpan -> int32) = _.Milliseconds
                let v343 : int32 = v342 v327
                let v346 : System.DateTime = System.DateTime (1, 1, 1, v331, v335, v339, v343)
                v346
        let v354 : string = method10()
        let v357 : (string -> string) = v353.ToString
        let v358 : string = v357 v354
        let _v114 = v358 
        #endif
#if FABLE_COMPILER_PYTHON
        let v361 : US3 option = None
        let _v361 = ref v361 
        let v362 : US3 option ref = _v361 
        let v363 : (US3 option -> US3 option ref) = closure7(v362)
        let v364 : unit = ()
        let v365 : (unit -> unit) = closure8(v101, v363)
        let v366 : unit = (fun () -> v365 (); v364) ()
        let v369 : US3 option = _v361.Value 
        let v380 : US3 = US3_1
        let v381 : US3 = v369 |> Option.defaultValue v380 
        let v421 : System.DateTime =
            match v381 with
            | US3_1 -> (* None *)
                let v417 : System.DateTime = System.DateTime.Now
                v417
            | US3_0(v385) -> (* Some *)
                let v386 : System.DateTime = System.DateTime.Now
                let v389 : (System.DateTime -> int64) = _.Ticks
                let v390 : int64 = v389 v386
                let v393 : int64 = v390 - v385
                let v394 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v395 : System.TimeSpan = v394 v393
                let v398 : (System.TimeSpan -> int32) = _.Hours
                let v399 : int32 = v398 v395
                let v402 : (System.TimeSpan -> int32) = _.Minutes
                let v403 : int32 = v402 v395
                let v406 : (System.TimeSpan -> int32) = _.Seconds
                let v407 : int32 = v406 v395
                let v410 : (System.TimeSpan -> int32) = _.Milliseconds
                let v411 : int32 = v410 v395
                let v414 : System.DateTime = System.DateTime (1, 1, 1, v399, v403, v407, v411)
                v414
        let v422 : string = method10()
        let v425 : (string -> string) = v421.ToString
        let v426 : string = v425 v422
        let _v114 = v426 
        #endif
#else
        let v429 : US3 option = None
        let _v429 = ref v429 
        let v430 : US3 option ref = _v429 
        let v431 : (US3 option -> US3 option ref) = closure7(v430)
        let v432 : unit = ()
        let v433 : (unit -> unit) = closure8(v101, v431)
        let v434 : unit = (fun () -> v433 (); v432) ()
        let v437 : US3 option = _v429.Value 
        let v448 : US3 = US3_1
        let v449 : US3 = v437 |> Option.defaultValue v448 
        let v489 : System.DateTime =
            match v449 with
            | US3_1 -> (* None *)
                let v485 : System.DateTime = System.DateTime.Now
                v485
            | US3_0(v453) -> (* Some *)
                let v454 : System.DateTime = System.DateTime.Now
                let v457 : (System.DateTime -> int64) = _.Ticks
                let v458 : int64 = v457 v454
                let v461 : int64 = v458 - v453
                let v462 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v463 : System.TimeSpan = v462 v461
                let v466 : (System.TimeSpan -> int32) = _.Hours
                let v467 : int32 = v466 v463
                let v470 : (System.TimeSpan -> int32) = _.Minutes
                let v471 : int32 = v470 v463
                let v474 : (System.TimeSpan -> int32) = _.Seconds
                let v475 : int32 = v474 v463
                let v478 : (System.TimeSpan -> int32) = _.Milliseconds
                let v479 : int32 = v478 v463
                let v482 : System.DateTime = System.DateTime (1, 1, 1, v467, v471, v475, v479)
                v482
        let v490 : string = method10()
        let v493 : (string -> string) = v489.ToString
        let v494 : string = v493 v490
        let _v114 = v494 
        #endif
        let v497 : string = _v114 
        
        
        
        
        
        let v567 : string = "Warning"
        let v568 : (unit -> string) = v567.ToLower
        let v569 : string = v568 ()
        let v572 : string = v569.PadLeft (7, ' ')
        let v586 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v587 : string = "inline_colorization::color_yellow"
        let v588 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v587 
        let v589 : string = "&*$0"
        let v590 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v572 v589 
        let v591 : string = "inline_colorization::color_reset"
        let v592 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v591 
        let v593 : string = "\"{v588}{v590}{v592}\""
        let v594 : string = @$"format!(" + v593 + ")"
        let v595 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v594 
        let v596 : string = "fable_library_rust::String_::fromString($0)"
        let v597 : string = Fable.Core.RustInterop.emitRustExpr v595 v596 
        let _v586 = v597 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v598 : string = "inline_colorization::color_yellow"
        let v599 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v598 
        let v600 : string = "&*$0"
        let v601 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v572 v600 
        let v602 : string = "inline_colorization::color_reset"
        let v603 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v602 
        let v604 : string = "\"{v599}{v601}{v603}\""
        let v605 : string = @$"format!(" + v604 + ")"
        let v606 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v605 
        let v607 : string = "fable_library_rust::String_::fromString($0)"
        let v608 : string = Fable.Core.RustInterop.emitRustExpr v606 v607 
        let _v586 = v608 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v609 : string = "inline_colorization::color_yellow"
        let v610 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v609 
        let v611 : string = "&*$0"
        let v612 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v572 v611 
        let v613 : string = "inline_colorization::color_reset"
        let v614 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v613 
        let v615 : string = "\"{v610}{v612}{v614}\""
        let v616 : string = @$"format!(" + v615 + ")"
        let v617 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v616 
        let v618 : string = "fable_library_rust::String_::fromString($0)"
        let v619 : string = Fable.Core.RustInterop.emitRustExpr v617 v618 
        let _v586 = v619 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v620 : string = "\u001b[93m"
        let v621 : string = method11()
        let v622 : string = v620 + v572 
        let v623 : string = v622 + v621 
        let _v586 = v623 
        #endif
#if FABLE_COMPILER_PYTHON
        let v624 : string = "\u001b[93m"
        let v625 : string = method11()
        let v626 : string = v624 + v572 
        let v627 : string = v626 + v625 
        let _v586 = v627 
        #endif
#else
        let v628 : string = "\u001b[93m"
        let v629 : string = method11()
        let v630 : string = v628 + v572 
        let v631 : string = v630 + v629 
        let _v586 = v631 
        #endif
        let v632 : string = _v586 
        let v638 : int64 = v96.l0
        let v639 : string = method12(v1)
        let v640 : string = method12(v0)
        let v641 : string = method13()
        let v642 : Mut3 = {l0 = v641} : Mut3
        let v643 : string = "{ "
        let v644 : string = $"{v643}"
        let v647 : unit = ()
        let v648 : (unit -> unit) = closure9(v642, v644)
        let v649 : unit = (fun () -> v648 (); v647) ()
        let v652 : string = "old_path"
        let v653 : string = $"{v652}"
        let v656 : unit = ()
        let v657 : (unit -> unit) = closure9(v642, v653)
        let v658 : unit = (fun () -> v657 (); v656) ()
        let v661 : string = " = "
        let v662 : string = $"{v661}"
        let v665 : unit = ()
        let v666 : (unit -> unit) = closure9(v642, v662)
        let v667 : unit = (fun () -> v666 (); v665) ()
        let v670 : string = $"{v639}"
        let v673 : unit = ()
        let v674 : (unit -> unit) = closure9(v642, v670)
        let v675 : unit = (fun () -> v674 (); v673) ()
        let v678 : string = "; "
        let v679 : string = $"{v678}"
        let v682 : unit = ()
        let v683 : (unit -> unit) = closure9(v642, v679)
        let v684 : unit = (fun () -> v683 (); v682) ()
        let v687 : string = "new_path"
        let v688 : string = $"{v687}"
        let v691 : unit = ()
        let v692 : (unit -> unit) = closure9(v642, v688)
        let v693 : unit = (fun () -> v692 (); v691) ()
        let v696 : string = $"{v661}"
        let v699 : unit = ()
        let v700 : (unit -> unit) = closure9(v642, v696)
        let v701 : unit = (fun () -> v700 (); v699) ()
        let v704 : string = $"{v640}"
        let v707 : unit = ()
        let v708 : (unit -> unit) = closure9(v642, v704)
        let v709 : unit = (fun () -> v708 (); v707) ()
        let v712 : string = $"{v678}"
        let v715 : unit = ()
        let v716 : (unit -> unit) = closure9(v642, v712)
        let v717 : unit = (fun () -> v716 (); v715) ()
        let v720 : string = "ex"
        let v721 : string = $"{v720}"
        let v724 : unit = ()
        let v725 : (unit -> unit) = closure9(v642, v721)
        let v726 : unit = (fun () -> v725 (); v724) ()
        let v729 : string = $"{v661}"
        let v732 : unit = ()
        let v733 : (unit -> unit) = closure9(v642, v729)
        let v734 : unit = (fun () -> v733 (); v732) ()
        let v737 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v738 : string = "format!(\"{:#?}\", $0)"
        let v739 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v738 
        let v740 : string = "fable_library_rust::String_::fromString($0)"
        let v741 : string = Fable.Core.RustInterop.emitRustExpr v739 v740 
        let _v737 = v741 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v742 : string = "format!(\"{:#?}\", $0)"
        let v743 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v742 
        let v744 : string = "fable_library_rust::String_::fromString($0)"
        let v745 : string = Fable.Core.RustInterop.emitRustExpr v743 v744 
        let _v737 = v745 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v746 : string = "format!(\"{:#?}\", $0)"
        let v747 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v746 
        let v748 : string = "fable_library_rust::String_::fromString($0)"
        let v749 : string = Fable.Core.RustInterop.emitRustExpr v747 v748 
        let _v737 = v749 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v750 : string = $"%A{v2}"
        let _v737 = v750 
        #endif
#if FABLE_COMPILER_PYTHON
        let v753 : string = $"%A{v2}"
        let _v737 = v753 
        #endif
#else
        let v756 : string = $"%A{v2}"
        let _v737 = v756 
        #endif
        let v759 : string = _v737 
        let v764 : string = $"{v759}"
        let v767 : unit = ()
        let v768 : (unit -> unit) = closure9(v642, v764)
        let v769 : unit = (fun () -> v768 (); v767) ()
        let v772 : string = " }"
        let v773 : string = $"{v772}"
        let v776 : unit = ()
        let v777 : (unit -> unit) = closure9(v642, v773)
        let v778 : unit = (fun () -> v777 (); v776) ()
        let v781 : string = v642.l0
        let v782 : string = "move_file_async"
        let v783 : string = $"{v497} {v632} #{v638} %s{v782} / {v781}"
        let v786 : char list = []
        let v787 : (char list -> (char [])) = List.toArray
        let v788 : (char []) = v787 v786
        let v791 : string = v783.TrimStart v788 
        let v809 : char list = []
        let v810 : char list = '/' :: v809 
        let v813 : char list = ' ' :: v810 
        let v816 : (char list -> (char [])) = List.toArray
        let v817 : (char []) = v816 v813
        let v820 : string = v791.TrimEnd v817 
        let v838 : (string -> unit) = closure10()
        let v839 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v840 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v820 v840 
        let _v839 = () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v841 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v820 v841 
        let _v839 = () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v842 : string = v22.l0
        let v843 : bool = v842 = ""
        let v851 : string =
            if v843 then
                v820
            else
                let v844 : bool = v820 = ""
                if v844 then
                    let v845 : string = v22.l0
                    v845
                else
                    let v846 : string = v22.l0
                    let v847 : string = "\n"
                    let v848 : string = v846 + v847 
                    let v849 : string = v848 + v820 
                    v849
        let v852 : string = "&*$0"
        let v853 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v851 v852 
        let v854 : string = $"$0.chars()"
        let v855 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v853 v854 
        let v856 : string = "v855"
        let v857 : _ = Fable.Core.RustInterop.emitRustExpr () v856 
        let v858 : string = "v857.collect::<Vec<_>>()"
        let v859 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v858 
        let v860 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
        let v861 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v859 v860 
        let v862 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
        let v863 : bool = Fable.Core.RustInterop.emitRustExpr v861 v862 
        let v864 : string = "x"
        let v865 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v864 
        let v866 : string = "String::from_iter($0)"
        let v867 : std_string_String = Fable.Core.RustInterop.emitRustExpr v865 v866 
        let v868 : string = "true; $0 }).collect::<Vec<_>>()"
        let v869 : bool = Fable.Core.RustInterop.emitRustExpr v867 v868 
        let v870 : string = "_vec_map"
        let v871 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v870 
        let v872 : string = "$0.len()"
        let v873 : unativeint = Fable.Core.RustInterop.emitRustExpr v871 v872 
        let v874 : (unativeint -> int32) = int32
        let v875 : int32 = v874 v873
        let v876 : string = ""
        let v877 : bool = v820 <> v876 
        let v881 : bool =
            if v877 then
                let v880 : bool = v875 <= 1
                v880
            else
                false
        if v881 then
            v22.l0 <- v851
            ()
        else
            v22.l0 <- v876
            let v882 : string = "true; $0.into_iter().for_each(|x| { //"
            let v883 : bool = Fable.Core.RustInterop.emitRustExpr v871 v882 
            let v884 : string = "x"
            let v885 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v884 
            let v886 : string = $"near_sdk::log!(\"{{}}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v885 v886 
            let v887 : string = $"true;"
            let v888 : bool = Fable.Core.RustInterop.emitRustExpr () v887 
            let v889 : string = "true; }}); { //"
            let v890 : bool = Fable.Core.RustInterop.emitRustExpr () v889 
            ()
        let _v839 = () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        v838 v820
        let _v839 = () 
        #endif
#if FABLE_COMPILER_PYTHON
        v838 v820
        let _v839 = () 
        #endif
#else
        v838 v820
        let _v839 = () 
        #endif
        _v839 
        let v891 : (string -> unit) = v20.l0
        v891 v820
and method20 (v0 : string, v1 : string, v2 : int64) : Async<int64> =
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
        let v25 : (unit -> unit) = closure27(v0, v1, v21)
        let v26 : unit = (fun () -> v25 (); v24) ()
        ()
    let v916 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v917 : Async<unit> = null |> unbox<Async<unit>>
    let _v916 = v917 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v920 : Async<unit> = null |> unbox<Async<unit>>
    let _v916 = v920 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v923 : Async<unit> = null |> unbox<Async<unit>>
    let _v916 = v923 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v926 : Async<unit> = null |> unbox<Async<unit>>
    let _v916 = v926 
    #endif
#if FABLE_COMPILER_PYTHON
    let v929 : Async<unit> = null |> unbox<Async<unit>>
    let _v916 = v929 
    #endif
#else
    let v932 : (int32 -> Async<unit>) = Async.Sleep
    let v933 : Async<unit> = v932 10
    let _v916 = v933 
    #endif
    let v934 : Async<unit> = _v916 
    do! v934 
    let v939 : int64 = v2 + 1L
    let v940 : Async<int64> = method20(v0, v1, v939)
    return! v940 
    (*
    *)
    }
    |> fun x -> _v19 <- Some x
    let v941 : Async<int64> = match _v19 with Some x -> x | None -> failwith "async.new_async_unit / _v19=None"
    let _v3 = v941 
    #endif
    let v942 : Async<int64> = _v3 
    v942
and closure26 (v0 : string) (v1 : string) : Async<int64> =
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
    let v19 : Async<int64> = method20(v0, v1, v18)
    let _v2 = v19 
    #endif
    let v20 : Async<int64> = _v2 
    v20
and closure25 () (v0 : string) : (string -> Async<int64>) =
    closure26(v0)
and closure29 () (v0 : int64) : US9 =
    US9_0(v0)
and closure30 () (v0 : exn) : US9 =
    US9_1(v0)
and closure31 () () : unit =
    let v0 : unit = ()
    let v1 : (unit -> unit) = closure0()
    let v2 : unit = (fun () -> v1 (); v0) ()
    let struct (v16 : Mut0, v17 : Mut1, v18 : Mut2, v19 : Mut3, v20 : Mut4, v21 : int64 option) = TraceState.trace_state.Value
    let v34 : unit = ()
    let v35 : unit = (fun () -> v1 (); v34) ()
    let struct (v49 : Mut0, v50 : Mut1, v51 : Mut2, v52 : Mut3, v53 : Mut4, v54 : int64 option) = TraceState.trace_state.Value
    let v67 : US0 = v53.l0
    let v68 : bool = v51.l0
    let v69 : bool = v68 = false
    let v72 : bool =
        if v69 then
            false
        else
            let v70 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v67
            let v71 : bool = 0 >= v70
            v71
    if v72 then
        let v73 : unit = ()
        let v74 : (unit -> unit) = closure6(v16)
        let v75 : unit = (fun () -> v74 (); v73) ()
        let v78 : unit = ()
        let v79 : unit = (fun () -> v1 (); v78) ()
        let struct (v93 : Mut0, v94 : Mut1, v95 : Mut2, v96 : Mut3, v97 : Mut4, v98 : int64 option) = TraceState.trace_state.Value
        let v111 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v112 : US3 option = None
        let _v112 = ref v112 
        let v113 : US3 option ref = _v112 
        let v114 : (US3 option -> US3 option ref) = closure7(v113)
        let v115 : unit = ()
        let v116 : (unit -> unit) = closure8(v98, v114)
        let v117 : unit = (fun () -> v116 (); v115) ()
        let v120 : US3 option = _v112.Value 
        let v131 : US3 = US3_1
        let v132 : US3 = v120 |> Option.defaultValue v131 
        let v172 : System.DateTime =
            match v132 with
            | US3_1 -> (* None *)
                let v168 : System.DateTime = System.DateTime.Now
                v168
            | US3_0(v136) -> (* Some *)
                let v137 : System.DateTime = System.DateTime.Now
                let v140 : (System.DateTime -> int64) = _.Ticks
                let v141 : int64 = v140 v137
                let v144 : int64 = v141 - v136
                let v145 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v146 : System.TimeSpan = v145 v144
                let v149 : (System.TimeSpan -> int32) = _.Hours
                let v150 : int32 = v149 v146
                let v153 : (System.TimeSpan -> int32) = _.Minutes
                let v154 : int32 = v153 v146
                let v157 : (System.TimeSpan -> int32) = _.Seconds
                let v158 : int32 = v157 v146
                let v161 : (System.TimeSpan -> int32) = _.Milliseconds
                let v162 : int32 = v161 v146
                let v165 : System.DateTime = System.DateTime (1, 1, 1, v150, v154, v158, v162)
                v165
        let v173 : string = method9()
        let v176 : (string -> string) = v172.ToString
        let v177 : string = v176 v173
        let _v111 = v177 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v180 : US3 option = None
        let _v180 = ref v180 
        let v181 : US3 option ref = _v180 
        let v182 : (US3 option -> US3 option ref) = closure7(v181)
        let v183 : unit = ()
        let v184 : (unit -> unit) = closure8(v98, v182)
        let v185 : unit = (fun () -> v184 (); v183) ()
        let v188 : US3 option = _v180.Value 
        let v199 : US3 = US3_1
        let v200 : US3 = v188 |> Option.defaultValue v199 
        let v240 : System.DateTime =
            match v200 with
            | US3_1 -> (* None *)
                let v236 : System.DateTime = System.DateTime.Now
                v236
            | US3_0(v204) -> (* Some *)
                let v205 : System.DateTime = System.DateTime.Now
                let v208 : (System.DateTime -> int64) = _.Ticks
                let v209 : int64 = v208 v205
                let v212 : int64 = v209 - v204
                let v213 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v214 : System.TimeSpan = v213 v212
                let v217 : (System.TimeSpan -> int32) = _.Hours
                let v218 : int32 = v217 v214
                let v221 : (System.TimeSpan -> int32) = _.Minutes
                let v222 : int32 = v221 v214
                let v225 : (System.TimeSpan -> int32) = _.Seconds
                let v226 : int32 = v225 v214
                let v229 : (System.TimeSpan -> int32) = _.Milliseconds
                let v230 : int32 = v229 v214
                let v233 : System.DateTime = System.DateTime (1, 1, 1, v218, v222, v226, v230)
                v233
        let v241 : string = method9()
        let v244 : (string -> string) = v240.ToString
        let v245 : string = v244 v241
        let _v111 = v245 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v248 : string = $"near_sdk::env::block_timestamp()"
        let v249 : uint64 = Fable.Core.RustInterop.emitRustExpr () v248 
        let v250 : US3 option = None
        let _v250 = ref v250 
        let v251 : US3 option ref = _v250 
        let v252 : (US3 option -> US3 option ref) = closure7(v251)
        let v253 : unit = ()
        let v254 : (unit -> unit) = closure8(v98, v252)
        let v255 : unit = (fun () -> v254 (); v253) ()
        let v258 : US3 option = _v250.Value 
        let v269 : US3 = US3_1
        let v270 : US3 = v258 |> Option.defaultValue v269 
        let v279 : uint64 =
            match v270 with
            | US3_1 -> (* None *)
                v249
            | US3_0(v274) -> (* Some *)
                let v275 : (int64 -> uint64) = uint64
                let v276 : uint64 = v275 v274
                let v277 : uint64 = v249 - v276
                v277
        let v280 : uint64 = v279 / 1000000000UL
        let v281 : uint64 = v280 % 60UL
        let v282 : uint64 = v280 / 60UL
        let v283 : uint64 = v282 % 60UL
        let v284 : uint64 = v280 / 3600UL
        let v285 : uint64 = v284 % 24UL
        let v286 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
        let v287 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v285, v283, v281) v286 
        let v288 : string = "fable_library_rust::String_::fromString($0)"
        let v289 : string = Fable.Core.RustInterop.emitRustExpr v287 v288 
        let _v111 = v289 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v290 : US3 option = None
        let _v290 = ref v290 
        let v291 : US3 option ref = _v290 
        let v292 : (US3 option -> US3 option ref) = closure7(v291)
        let v293 : unit = ()
        let v294 : (unit -> unit) = closure8(v98, v292)
        let v295 : unit = (fun () -> v294 (); v293) ()
        let v298 : US3 option = _v290.Value 
        let v309 : US3 = US3_1
        let v310 : US3 = v298 |> Option.defaultValue v309 
        let v350 : System.DateTime =
            match v310 with
            | US3_1 -> (* None *)
                let v346 : System.DateTime = System.DateTime.Now
                v346
            | US3_0(v314) -> (* Some *)
                let v315 : System.DateTime = System.DateTime.Now
                let v318 : (System.DateTime -> int64) = _.Ticks
                let v319 : int64 = v318 v315
                let v322 : int64 = v319 - v314
                let v323 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v324 : System.TimeSpan = v323 v322
                let v327 : (System.TimeSpan -> int32) = _.Hours
                let v328 : int32 = v327 v324
                let v331 : (System.TimeSpan -> int32) = _.Minutes
                let v332 : int32 = v331 v324
                let v335 : (System.TimeSpan -> int32) = _.Seconds
                let v336 : int32 = v335 v324
                let v339 : (System.TimeSpan -> int32) = _.Milliseconds
                let v340 : int32 = v339 v324
                let v343 : System.DateTime = System.DateTime (1, 1, 1, v328, v332, v336, v340)
                v343
        let v351 : string = method10()
        let v354 : (string -> string) = v350.ToString
        let v355 : string = v354 v351
        let _v111 = v355 
        #endif
#if FABLE_COMPILER_PYTHON
        let v358 : US3 option = None
        let _v358 = ref v358 
        let v359 : US3 option ref = _v358 
        let v360 : (US3 option -> US3 option ref) = closure7(v359)
        let v361 : unit = ()
        let v362 : (unit -> unit) = closure8(v98, v360)
        let v363 : unit = (fun () -> v362 (); v361) ()
        let v366 : US3 option = _v358.Value 
        let v377 : US3 = US3_1
        let v378 : US3 = v366 |> Option.defaultValue v377 
        let v418 : System.DateTime =
            match v378 with
            | US3_1 -> (* None *)
                let v414 : System.DateTime = System.DateTime.Now
                v414
            | US3_0(v382) -> (* Some *)
                let v383 : System.DateTime = System.DateTime.Now
                let v386 : (System.DateTime -> int64) = _.Ticks
                let v387 : int64 = v386 v383
                let v390 : int64 = v387 - v382
                let v391 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v392 : System.TimeSpan = v391 v390
                let v395 : (System.TimeSpan -> int32) = _.Hours
                let v396 : int32 = v395 v392
                let v399 : (System.TimeSpan -> int32) = _.Minutes
                let v400 : int32 = v399 v392
                let v403 : (System.TimeSpan -> int32) = _.Seconds
                let v404 : int32 = v403 v392
                let v407 : (System.TimeSpan -> int32) = _.Milliseconds
                let v408 : int32 = v407 v392
                let v411 : System.DateTime = System.DateTime (1, 1, 1, v396, v400, v404, v408)
                v411
        let v419 : string = method10()
        let v422 : (string -> string) = v418.ToString
        let v423 : string = v422 v419
        let _v111 = v423 
        #endif
#else
        let v426 : US3 option = None
        let _v426 = ref v426 
        let v427 : US3 option ref = _v426 
        let v428 : (US3 option -> US3 option ref) = closure7(v427)
        let v429 : unit = ()
        let v430 : (unit -> unit) = closure8(v98, v428)
        let v431 : unit = (fun () -> v430 (); v429) ()
        let v434 : US3 option = _v426.Value 
        let v445 : US3 = US3_1
        let v446 : US3 = v434 |> Option.defaultValue v445 
        let v486 : System.DateTime =
            match v446 with
            | US3_1 -> (* None *)
                let v482 : System.DateTime = System.DateTime.Now
                v482
            | US3_0(v450) -> (* Some *)
                let v451 : System.DateTime = System.DateTime.Now
                let v454 : (System.DateTime -> int64) = _.Ticks
                let v455 : int64 = v454 v451
                let v458 : int64 = v455 - v450
                let v459 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v460 : System.TimeSpan = v459 v458
                let v463 : (System.TimeSpan -> int32) = _.Hours
                let v464 : int32 = v463 v460
                let v467 : (System.TimeSpan -> int32) = _.Minutes
                let v468 : int32 = v467 v460
                let v471 : (System.TimeSpan -> int32) = _.Seconds
                let v472 : int32 = v471 v460
                let v475 : (System.TimeSpan -> int32) = _.Milliseconds
                let v476 : int32 = v475 v460
                let v479 : System.DateTime = System.DateTime (1, 1, 1, v464, v468, v472, v476)
                v479
        let v487 : string = method10()
        let v490 : (string -> string) = v486.ToString
        let v491 : string = v490 v487
        let _v111 = v491 
        #endif
        let v494 : string = _v111 
        
        
        
        
        
        let v564 : string = "Verbose"
        let v565 : (unit -> string) = v564.ToLower
        let v566 : string = v565 ()
        let v569 : string = v566.PadLeft (7, ' ')
        let v583 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v584 : string = "inline_colorization::color_bright_black"
        let v585 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v584 
        let v586 : string = "&*$0"
        let v587 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v569 v586 
        let v588 : string = "inline_colorization::color_reset"
        let v589 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v588 
        let v590 : string = "\"{v585}{v587}{v589}\""
        let v591 : string = @$"format!(" + v590 + ")"
        let v592 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v591 
        let v593 : string = "fable_library_rust::String_::fromString($0)"
        let v594 : string = Fable.Core.RustInterop.emitRustExpr v592 v593 
        let _v583 = v594 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v595 : string = "inline_colorization::color_bright_black"
        let v596 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v595 
        let v597 : string = "&*$0"
        let v598 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v569 v597 
        let v599 : string = "inline_colorization::color_reset"
        let v600 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v599 
        let v601 : string = "\"{v596}{v598}{v600}\""
        let v602 : string = @$"format!(" + v601 + ")"
        let v603 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v602 
        let v604 : string = "fable_library_rust::String_::fromString($0)"
        let v605 : string = Fable.Core.RustInterop.emitRustExpr v603 v604 
        let _v583 = v605 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v606 : string = "inline_colorization::color_bright_black"
        let v607 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v606 
        let v608 : string = "&*$0"
        let v609 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v569 v608 
        let v610 : string = "inline_colorization::color_reset"
        let v611 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v610 
        let v612 : string = "\"{v607}{v609}{v611}\""
        let v613 : string = @$"format!(" + v612 + ")"
        let v614 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v613 
        let v615 : string = "fable_library_rust::String_::fromString($0)"
        let v616 : string = Fable.Core.RustInterop.emitRustExpr v614 v615 
        let _v583 = v616 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v617 : string = "\u001b[90m"
        let v618 : string = method11()
        let v619 : string = v617 + v569 
        let v620 : string = v619 + v618 
        let _v583 = v620 
        #endif
#if FABLE_COMPILER_PYTHON
        let v621 : string = "\u001b[90m"
        let v622 : string = method11()
        let v623 : string = v621 + v569 
        let v624 : string = v623 + v622 
        let _v583 = v624 
        #endif
#else
        let v625 : string = "\u001b[90m"
        let v626 : string = method11()
        let v627 : string = v625 + v569 
        let v628 : string = v627 + v626 
        let _v583 = v628 
        #endif
        let v629 : string = _v583 
        let v635 : int64 = v93.l0
        let v636 : string = method13()
        let v637 : Mut3 = {l0 = v636} : Mut3
        let v638 : string = "{ "
        let v639 : string = $"{v638}"
        let v642 : unit = ()
        let v643 : (unit -> unit) = closure9(v637, v639)
        let v644 : unit = (fun () -> v643 (); v642) ()
        let v647 : string = "timeout"
        let v648 : string = $"{v647}"
        let v651 : unit = ()
        let v652 : (unit -> unit) = closure9(v637, v648)
        let v653 : unit = (fun () -> v652 (); v651) ()
        let v656 : string = " = "
        let v657 : string = $"{v656}"
        let v660 : unit = ()
        let v661 : (unit -> unit) = closure9(v637, v657)
        let v662 : unit = (fun () -> v661 (); v660) ()
        let v665 : string = $"{1000}"
        let v668 : unit = ()
        let v669 : (unit -> unit) = closure9(v637, v665)
        let v670 : unit = (fun () -> v669 (); v668) ()
        let v673 : string = " }"
        let v674 : string = $"{v673}"
        let v677 : unit = ()
        let v678 : (unit -> unit) = closure9(v637, v674)
        let v679 : unit = (fun () -> v678 (); v677) ()
        let v682 : string = v637.l0
        let v683 : string = "async.run_with_timeout_async"
        let v684 : bool = v683 = ""
        let v741 : string =
            if v684 then
                let v685 : string = ""
                v685
            else
                let v686 : string = $"{v494} {v629} #{v635} %s{v683} / {v682}"
                let v689 : char list = []
                let v690 : (char list -> (char [])) = List.toArray
                let v691 : (char []) = v690 v689
                let v694 : string = v686.TrimStart v691 
                let v712 : char list = []
                let v713 : char list = '/' :: v712 
                let v716 : char list = ' ' :: v713 
                let v719 : (char list -> (char [])) = List.toArray
                let v720 : (char []) = v719 v716
                let v723 : string = v694.TrimEnd v720 
                v723
        let v742 : (string -> unit) = closure10()
        let v743 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v744 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v741 v744 
        let _v743 = () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v745 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v741 v745 
        let _v743 = () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v746 : string = v19.l0
        let v747 : bool = v746 = ""
        let v755 : string =
            if v747 then
                v741
            else
                let v748 : bool = v741 = ""
                if v748 then
                    let v749 : string = v19.l0
                    v749
                else
                    let v750 : string = v19.l0
                    let v751 : string = "\n"
                    let v752 : string = v750 + v751 
                    let v753 : string = v752 + v741 
                    v753
        let v756 : string = "&*$0"
        let v757 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v755 v756 
        let v758 : string = $"$0.chars()"
        let v759 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v757 v758 
        let v760 : string = "v759"
        let v761 : _ = Fable.Core.RustInterop.emitRustExpr () v760 
        let v762 : string = "v761.collect::<Vec<_>>()"
        let v763 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v762 
        let v764 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
        let v765 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v763 v764 
        let v766 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
        let v767 : bool = Fable.Core.RustInterop.emitRustExpr v765 v766 
        let v768 : string = "x"
        let v769 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v768 
        let v770 : string = "String::from_iter($0)"
        let v771 : std_string_String = Fable.Core.RustInterop.emitRustExpr v769 v770 
        let v772 : string = "true; $0 }).collect::<Vec<_>>()"
        let v773 : bool = Fable.Core.RustInterop.emitRustExpr v771 v772 
        let v774 : string = "_vec_map"
        let v775 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v774 
        let v776 : string = "$0.len()"
        let v777 : unativeint = Fable.Core.RustInterop.emitRustExpr v775 v776 
        let v778 : (unativeint -> int32) = int32
        let v779 : int32 = v778 v777
        let v780 : string = ""
        let v781 : bool = v741 <> v780 
        let v785 : bool =
            if v781 then
                let v784 : bool = v779 <= 1
                v784
            else
                false
        if v785 then
            v19.l0 <- v755
            ()
        else
            v19.l0 <- v780
            let v786 : string = "true; $0.into_iter().for_each(|x| { //"
            let v787 : bool = Fable.Core.RustInterop.emitRustExpr v775 v786 
            let v788 : string = "x"
            let v789 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v788 
            let v790 : string = $"near_sdk::log!(\"{{}}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v789 v790 
            let v791 : string = $"true;"
            let v792 : bool = Fable.Core.RustInterop.emitRustExpr () v791 
            let v793 : string = "true; }}); { //"
            let v794 : bool = Fable.Core.RustInterop.emitRustExpr () v793 
            ()
        let _v743 = () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        v742 v741
        let _v743 = () 
        #endif
#if FABLE_COMPILER_PYTHON
        v742 v741
        let _v743 = () 
        #endif
#else
        v742 v741
        let _v743 = () 
        #endif
        _v743 
        let v795 : (string -> unit) = v17.l0
        v795 v741
and closure32 (v0 : exn) () : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure0()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v17 : Mut0, v18 : Mut1, v19 : Mut2, v20 : Mut3, v21 : Mut4, v22 : int64 option) = TraceState.trace_state.Value
    let v35 : unit = ()
    let v36 : unit = (fun () -> v2 (); v35) ()
    let struct (v50 : Mut0, v51 : Mut1, v52 : Mut2, v53 : Mut3, v54 : Mut4, v55 : int64 option) = TraceState.trace_state.Value
    let v68 : US0 = v54.l0
    let v69 : bool = v52.l0
    let v70 : bool = v69 = false
    let v73 : bool =
        if v70 then
            false
        else
            let v71 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v68
            let v72 : bool = 4 >= v71
            v72
    if v73 then
        let v74 : unit = ()
        let v75 : (unit -> unit) = closure6(v17)
        let v76 : unit = (fun () -> v75 (); v74) ()
        let v79 : unit = ()
        let v80 : unit = (fun () -> v2 (); v79) ()
        let struct (v94 : Mut0, v95 : Mut1, v96 : Mut2, v97 : Mut3, v98 : Mut4, v99 : int64 option) = TraceState.trace_state.Value
        let v112 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v113 : US3 option = None
        let _v113 = ref v113 
        let v114 : US3 option ref = _v113 
        let v115 : (US3 option -> US3 option ref) = closure7(v114)
        let v116 : unit = ()
        let v117 : (unit -> unit) = closure8(v99, v115)
        let v118 : unit = (fun () -> v117 (); v116) ()
        let v121 : US3 option = _v113.Value 
        let v132 : US3 = US3_1
        let v133 : US3 = v121 |> Option.defaultValue v132 
        let v173 : System.DateTime =
            match v133 with
            | US3_1 -> (* None *)
                let v169 : System.DateTime = System.DateTime.Now
                v169
            | US3_0(v137) -> (* Some *)
                let v138 : System.DateTime = System.DateTime.Now
                let v141 : (System.DateTime -> int64) = _.Ticks
                let v142 : int64 = v141 v138
                let v145 : int64 = v142 - v137
                let v146 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v147 : System.TimeSpan = v146 v145
                let v150 : (System.TimeSpan -> int32) = _.Hours
                let v151 : int32 = v150 v147
                let v154 : (System.TimeSpan -> int32) = _.Minutes
                let v155 : int32 = v154 v147
                let v158 : (System.TimeSpan -> int32) = _.Seconds
                let v159 : int32 = v158 v147
                let v162 : (System.TimeSpan -> int32) = _.Milliseconds
                let v163 : int32 = v162 v147
                let v166 : System.DateTime = System.DateTime (1, 1, 1, v151, v155, v159, v163)
                v166
        let v174 : string = method9()
        let v177 : (string -> string) = v173.ToString
        let v178 : string = v177 v174
        let _v112 = v178 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v181 : US3 option = None
        let _v181 = ref v181 
        let v182 : US3 option ref = _v181 
        let v183 : (US3 option -> US3 option ref) = closure7(v182)
        let v184 : unit = ()
        let v185 : (unit -> unit) = closure8(v99, v183)
        let v186 : unit = (fun () -> v185 (); v184) ()
        let v189 : US3 option = _v181.Value 
        let v200 : US3 = US3_1
        let v201 : US3 = v189 |> Option.defaultValue v200 
        let v241 : System.DateTime =
            match v201 with
            | US3_1 -> (* None *)
                let v237 : System.DateTime = System.DateTime.Now
                v237
            | US3_0(v205) -> (* Some *)
                let v206 : System.DateTime = System.DateTime.Now
                let v209 : (System.DateTime -> int64) = _.Ticks
                let v210 : int64 = v209 v206
                let v213 : int64 = v210 - v205
                let v214 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v215 : System.TimeSpan = v214 v213
                let v218 : (System.TimeSpan -> int32) = _.Hours
                let v219 : int32 = v218 v215
                let v222 : (System.TimeSpan -> int32) = _.Minutes
                let v223 : int32 = v222 v215
                let v226 : (System.TimeSpan -> int32) = _.Seconds
                let v227 : int32 = v226 v215
                let v230 : (System.TimeSpan -> int32) = _.Milliseconds
                let v231 : int32 = v230 v215
                let v234 : System.DateTime = System.DateTime (1, 1, 1, v219, v223, v227, v231)
                v234
        let v242 : string = method9()
        let v245 : (string -> string) = v241.ToString
        let v246 : string = v245 v242
        let _v112 = v246 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v249 : string = $"near_sdk::env::block_timestamp()"
        let v250 : uint64 = Fable.Core.RustInterop.emitRustExpr () v249 
        let v251 : US3 option = None
        let _v251 = ref v251 
        let v252 : US3 option ref = _v251 
        let v253 : (US3 option -> US3 option ref) = closure7(v252)
        let v254 : unit = ()
        let v255 : (unit -> unit) = closure8(v99, v253)
        let v256 : unit = (fun () -> v255 (); v254) ()
        let v259 : US3 option = _v251.Value 
        let v270 : US3 = US3_1
        let v271 : US3 = v259 |> Option.defaultValue v270 
        let v280 : uint64 =
            match v271 with
            | US3_1 -> (* None *)
                v250
            | US3_0(v275) -> (* Some *)
                let v276 : (int64 -> uint64) = uint64
                let v277 : uint64 = v276 v275
                let v278 : uint64 = v250 - v277
                v278
        let v281 : uint64 = v280 / 1000000000UL
        let v282 : uint64 = v281 % 60UL
        let v283 : uint64 = v281 / 60UL
        let v284 : uint64 = v283 % 60UL
        let v285 : uint64 = v281 / 3600UL
        let v286 : uint64 = v285 % 24UL
        let v287 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
        let v288 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v286, v284, v282) v287 
        let v289 : string = "fable_library_rust::String_::fromString($0)"
        let v290 : string = Fable.Core.RustInterop.emitRustExpr v288 v289 
        let _v112 = v290 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v291 : US3 option = None
        let _v291 = ref v291 
        let v292 : US3 option ref = _v291 
        let v293 : (US3 option -> US3 option ref) = closure7(v292)
        let v294 : unit = ()
        let v295 : (unit -> unit) = closure8(v99, v293)
        let v296 : unit = (fun () -> v295 (); v294) ()
        let v299 : US3 option = _v291.Value 
        let v310 : US3 = US3_1
        let v311 : US3 = v299 |> Option.defaultValue v310 
        let v351 : System.DateTime =
            match v311 with
            | US3_1 -> (* None *)
                let v347 : System.DateTime = System.DateTime.Now
                v347
            | US3_0(v315) -> (* Some *)
                let v316 : System.DateTime = System.DateTime.Now
                let v319 : (System.DateTime -> int64) = _.Ticks
                let v320 : int64 = v319 v316
                let v323 : int64 = v320 - v315
                let v324 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v325 : System.TimeSpan = v324 v323
                let v328 : (System.TimeSpan -> int32) = _.Hours
                let v329 : int32 = v328 v325
                let v332 : (System.TimeSpan -> int32) = _.Minutes
                let v333 : int32 = v332 v325
                let v336 : (System.TimeSpan -> int32) = _.Seconds
                let v337 : int32 = v336 v325
                let v340 : (System.TimeSpan -> int32) = _.Milliseconds
                let v341 : int32 = v340 v325
                let v344 : System.DateTime = System.DateTime (1, 1, 1, v329, v333, v337, v341)
                v344
        let v352 : string = method10()
        let v355 : (string -> string) = v351.ToString
        let v356 : string = v355 v352
        let _v112 = v356 
        #endif
#if FABLE_COMPILER_PYTHON
        let v359 : US3 option = None
        let _v359 = ref v359 
        let v360 : US3 option ref = _v359 
        let v361 : (US3 option -> US3 option ref) = closure7(v360)
        let v362 : unit = ()
        let v363 : (unit -> unit) = closure8(v99, v361)
        let v364 : unit = (fun () -> v363 (); v362) ()
        let v367 : US3 option = _v359.Value 
        let v378 : US3 = US3_1
        let v379 : US3 = v367 |> Option.defaultValue v378 
        let v419 : System.DateTime =
            match v379 with
            | US3_1 -> (* None *)
                let v415 : System.DateTime = System.DateTime.Now
                v415
            | US3_0(v383) -> (* Some *)
                let v384 : System.DateTime = System.DateTime.Now
                let v387 : (System.DateTime -> int64) = _.Ticks
                let v388 : int64 = v387 v384
                let v391 : int64 = v388 - v383
                let v392 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v393 : System.TimeSpan = v392 v391
                let v396 : (System.TimeSpan -> int32) = _.Hours
                let v397 : int32 = v396 v393
                let v400 : (System.TimeSpan -> int32) = _.Minutes
                let v401 : int32 = v400 v393
                let v404 : (System.TimeSpan -> int32) = _.Seconds
                let v405 : int32 = v404 v393
                let v408 : (System.TimeSpan -> int32) = _.Milliseconds
                let v409 : int32 = v408 v393
                let v412 : System.DateTime = System.DateTime (1, 1, 1, v397, v401, v405, v409)
                v412
        let v420 : string = method10()
        let v423 : (string -> string) = v419.ToString
        let v424 : string = v423 v420
        let _v112 = v424 
        #endif
#else
        let v427 : US3 option = None
        let _v427 = ref v427 
        let v428 : US3 option ref = _v427 
        let v429 : (US3 option -> US3 option ref) = closure7(v428)
        let v430 : unit = ()
        let v431 : (unit -> unit) = closure8(v99, v429)
        let v432 : unit = (fun () -> v431 (); v430) ()
        let v435 : US3 option = _v427.Value 
        let v446 : US3 = US3_1
        let v447 : US3 = v435 |> Option.defaultValue v446 
        let v487 : System.DateTime =
            match v447 with
            | US3_1 -> (* None *)
                let v483 : System.DateTime = System.DateTime.Now
                v483
            | US3_0(v451) -> (* Some *)
                let v452 : System.DateTime = System.DateTime.Now
                let v455 : (System.DateTime -> int64) = _.Ticks
                let v456 : int64 = v455 v452
                let v459 : int64 = v456 - v451
                let v460 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v461 : System.TimeSpan = v460 v459
                let v464 : (System.TimeSpan -> int32) = _.Hours
                let v465 : int32 = v464 v461
                let v468 : (System.TimeSpan -> int32) = _.Minutes
                let v469 : int32 = v468 v461
                let v472 : (System.TimeSpan -> int32) = _.Seconds
                let v473 : int32 = v472 v461
                let v476 : (System.TimeSpan -> int32) = _.Milliseconds
                let v477 : int32 = v476 v461
                let v480 : System.DateTime = System.DateTime (1, 1, 1, v465, v469, v473, v477)
                v480
        let v488 : string = method10()
        let v491 : (string -> string) = v487.ToString
        let v492 : string = v491 v488
        let _v112 = v492 
        #endif
        let v495 : string = _v112 
        
        
        
        
        
        let v565 : string = "Critical"
        let v566 : (unit -> string) = v565.ToLower
        let v567 : string = v566 ()
        let v570 : string = v567.PadLeft (7, ' ')
        let v584 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v585 : string = "inline_colorization::color_bright_red"
        let v586 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v585 
        let v587 : string = "&*$0"
        let v588 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v570 v587 
        let v589 : string = "inline_colorization::color_reset"
        let v590 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v589 
        let v591 : string = "\"{v586}{v588}{v590}\""
        let v592 : string = @$"format!(" + v591 + ")"
        let v593 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v592 
        let v594 : string = "fable_library_rust::String_::fromString($0)"
        let v595 : string = Fable.Core.RustInterop.emitRustExpr v593 v594 
        let _v584 = v595 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v596 : string = "inline_colorization::color_bright_red"
        let v597 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v596 
        let v598 : string = "&*$0"
        let v599 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v570 v598 
        let v600 : string = "inline_colorization::color_reset"
        let v601 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v600 
        let v602 : string = "\"{v597}{v599}{v601}\""
        let v603 : string = @$"format!(" + v602 + ")"
        let v604 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v603 
        let v605 : string = "fable_library_rust::String_::fromString($0)"
        let v606 : string = Fable.Core.RustInterop.emitRustExpr v604 v605 
        let _v584 = v606 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v607 : string = "inline_colorization::color_bright_red"
        let v608 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v607 
        let v609 : string = "&*$0"
        let v610 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v570 v609 
        let v611 : string = "inline_colorization::color_reset"
        let v612 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v611 
        let v613 : string = "\"{v608}{v610}{v612}\""
        let v614 : string = @$"format!(" + v613 + ")"
        let v615 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v614 
        let v616 : string = "fable_library_rust::String_::fromString($0)"
        let v617 : string = Fable.Core.RustInterop.emitRustExpr v615 v616 
        let _v584 = v617 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v618 : string = "\u001b[91m"
        let v619 : string = method11()
        let v620 : string = v618 + v570 
        let v621 : string = v620 + v619 
        let _v584 = v621 
        #endif
#if FABLE_COMPILER_PYTHON
        let v622 : string = "\u001b[91m"
        let v623 : string = method11()
        let v624 : string = v622 + v570 
        let v625 : string = v624 + v623 
        let _v584 = v625 
        #endif
#else
        let v626 : string = "\u001b[91m"
        let v627 : string = method11()
        let v628 : string = v626 + v570 
        let v629 : string = v628 + v627 
        let _v584 = v629 
        #endif
        let v630 : string = _v584 
        let v636 : int64 = v94.l0
        let v637 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v638 : string = $"%A{v0}"
        let _v637 = v638 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v641 : string = $"%A{v0}"
        let _v637 = v641 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v644 : string = $"%A{v0}"
        let _v637 = v644 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v647 : string = $"%A{v0}"
        let _v637 = v647 
        #endif
#if FABLE_COMPILER_PYTHON
        let v650 : string = $"%A{v0}"
        let _v637 = v650 
        #endif
#else
        let v653 : string = $"{v0.GetType ()}: {v0.Message}"
        let _v637 = v653 
        #endif
        let v654 : string = _v637 
        let v659 : string = method13()
        let v660 : Mut3 = {l0 = v659} : Mut3
        let v661 : string = "{ "
        let v662 : string = $"{v661}"
        let v665 : unit = ()
        let v666 : (unit -> unit) = closure9(v660, v662)
        let v667 : unit = (fun () -> v666 (); v665) ()
        let v670 : string = "timeout"
        let v671 : string = $"{v670}"
        let v674 : unit = ()
        let v675 : (unit -> unit) = closure9(v660, v671)
        let v676 : unit = (fun () -> v675 (); v674) ()
        let v679 : string = " = "
        let v680 : string = $"{v679}"
        let v683 : unit = ()
        let v684 : (unit -> unit) = closure9(v660, v680)
        let v685 : unit = (fun () -> v684 (); v683) ()
        let v688 : string = $"{1000}"
        let v691 : unit = ()
        let v692 : (unit -> unit) = closure9(v660, v688)
        let v693 : unit = (fun () -> v692 (); v691) ()
        let v696 : string = "; "
        let v697 : string = $"{v696}"
        let v700 : unit = ()
        let v701 : (unit -> unit) = closure9(v660, v697)
        let v702 : unit = (fun () -> v701 (); v700) ()
        let v705 : string = "ex"
        let v706 : string = $"{v705}"
        let v709 : unit = ()
        let v710 : (unit -> unit) = closure9(v660, v706)
        let v711 : unit = (fun () -> v710 (); v709) ()
        let v714 : string = $"{v679}"
        let v717 : unit = ()
        let v718 : (unit -> unit) = closure9(v660, v714)
        let v719 : unit = (fun () -> v718 (); v717) ()
        let v722 : string = $"{v654}"
        let v725 : unit = ()
        let v726 : (unit -> unit) = closure9(v660, v722)
        let v727 : unit = (fun () -> v726 (); v725) ()
        let v730 : string = " }"
        let v731 : string = $"{v730}"
        let v734 : unit = ()
        let v735 : (unit -> unit) = closure9(v660, v731)
        let v736 : unit = (fun () -> v735 (); v734) ()
        let v739 : string = v660.l0
        let v740 : string = $"async.run_with_timeout_async**"
        let v741 : bool = v740 = ""
        let v798 : string =
            if v741 then
                let v742 : string = ""
                v742
            else
                let v743 : string = $"{v495} {v630} #{v636} %s{v740} / {v739}"
                let v746 : char list = []
                let v747 : (char list -> (char [])) = List.toArray
                let v748 : (char []) = v747 v746
                let v751 : string = v743.TrimStart v748 
                let v769 : char list = []
                let v770 : char list = '/' :: v769 
                let v773 : char list = ' ' :: v770 
                let v776 : (char list -> (char [])) = List.toArray
                let v777 : (char []) = v776 v773
                let v780 : string = v751.TrimEnd v777 
                v780
        let v799 : (string -> unit) = closure10()
        let v800 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v801 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v798 v801 
        let _v800 = () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v802 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v798 v802 
        let _v800 = () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v803 : string = v20.l0
        let v804 : bool = v803 = ""
        let v812 : string =
            if v804 then
                v798
            else
                let v805 : bool = v798 = ""
                if v805 then
                    let v806 : string = v20.l0
                    v806
                else
                    let v807 : string = v20.l0
                    let v808 : string = "\n"
                    let v809 : string = v807 + v808 
                    let v810 : string = v809 + v798 
                    v810
        let v813 : string = "&*$0"
        let v814 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v812 v813 
        let v815 : string = $"$0.chars()"
        let v816 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v814 v815 
        let v817 : string = "v816"
        let v818 : _ = Fable.Core.RustInterop.emitRustExpr () v817 
        let v819 : string = "v818.collect::<Vec<_>>()"
        let v820 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v819 
        let v821 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
        let v822 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v820 v821 
        let v823 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
        let v824 : bool = Fable.Core.RustInterop.emitRustExpr v822 v823 
        let v825 : string = "x"
        let v826 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v825 
        let v827 : string = "String::from_iter($0)"
        let v828 : std_string_String = Fable.Core.RustInterop.emitRustExpr v826 v827 
        let v829 : string = "true; $0 }).collect::<Vec<_>>()"
        let v830 : bool = Fable.Core.RustInterop.emitRustExpr v828 v829 
        let v831 : string = "_vec_map"
        let v832 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v831 
        let v833 : string = "$0.len()"
        let v834 : unativeint = Fable.Core.RustInterop.emitRustExpr v832 v833 
        let v835 : (unativeint -> int32) = int32
        let v836 : int32 = v835 v834
        let v837 : string = ""
        let v838 : bool = v798 <> v837 
        let v842 : bool =
            if v838 then
                let v841 : bool = v836 <= 1
                v841
            else
                false
        if v842 then
            v20.l0 <- v812
            ()
        else
            v20.l0 <- v837
            let v843 : string = "true; $0.into_iter().for_each(|x| { //"
            let v844 : bool = Fable.Core.RustInterop.emitRustExpr v832 v843 
            let v845 : string = "x"
            let v846 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v845 
            let v847 : string = $"near_sdk::log!(\"{{}}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v846 v847 
            let v848 : string = $"true;"
            let v849 : bool = Fable.Core.RustInterop.emitRustExpr () v848 
            let v850 : string = "true; }}); { //"
            let v851 : bool = Fable.Core.RustInterop.emitRustExpr () v850 
            ()
        let _v800 = () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        v799 v798
        let _v800 = () 
        #endif
#if FABLE_COMPILER_PYTHON
        v799 v798
        let _v800 = () 
        #endif
#else
        v799 v798
        let _v800 = () 
        #endif
        _v800 
        let v852 : (string -> unit) = v18.l0
        v852 v798
and closure33 (v0 : int64, v1 : string) () : unit =
    let v2 : unit = ()
    let v3 : (unit -> unit) = closure0()
    let v4 : unit = (fun () -> v3 (); v2) ()
    let struct (v18 : Mut0, v19 : Mut1, v20 : Mut2, v21 : Mut3, v22 : Mut4, v23 : int64 option) = TraceState.trace_state.Value
    let v36 : unit = ()
    let v37 : unit = (fun () -> v3 (); v36) ()
    let struct (v51 : Mut0, v52 : Mut1, v53 : Mut2, v54 : Mut3, v55 : Mut4, v56 : int64 option) = TraceState.trace_state.Value
    let v69 : US0 = v55.l0
    let v70 : bool = v53.l0
    let v71 : bool = v70 = false
    let v74 : bool =
        if v71 then
            false
        else
            let v72 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v69
            let v73 : bool = 1 >= v72
            v73
    if v74 then
        let v75 : unit = ()
        let v76 : (unit -> unit) = closure6(v18)
        let v77 : unit = (fun () -> v76 (); v75) ()
        let v80 : unit = ()
        let v81 : unit = (fun () -> v3 (); v80) ()
        let struct (v95 : Mut0, v96 : Mut1, v97 : Mut2, v98 : Mut3, v99 : Mut4, v100 : int64 option) = TraceState.trace_state.Value
        let v113 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v114 : US3 option = None
        let _v114 = ref v114 
        let v115 : US3 option ref = _v114 
        let v116 : (US3 option -> US3 option ref) = closure7(v115)
        let v117 : unit = ()
        let v118 : (unit -> unit) = closure8(v100, v116)
        let v119 : unit = (fun () -> v118 (); v117) ()
        let v122 : US3 option = _v114.Value 
        let v133 : US3 = US3_1
        let v134 : US3 = v122 |> Option.defaultValue v133 
        let v174 : System.DateTime =
            match v134 with
            | US3_1 -> (* None *)
                let v170 : System.DateTime = System.DateTime.Now
                v170
            | US3_0(v138) -> (* Some *)
                let v139 : System.DateTime = System.DateTime.Now
                let v142 : (System.DateTime -> int64) = _.Ticks
                let v143 : int64 = v142 v139
                let v146 : int64 = v143 - v138
                let v147 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v148 : System.TimeSpan = v147 v146
                let v151 : (System.TimeSpan -> int32) = _.Hours
                let v152 : int32 = v151 v148
                let v155 : (System.TimeSpan -> int32) = _.Minutes
                let v156 : int32 = v155 v148
                let v159 : (System.TimeSpan -> int32) = _.Seconds
                let v160 : int32 = v159 v148
                let v163 : (System.TimeSpan -> int32) = _.Milliseconds
                let v164 : int32 = v163 v148
                let v167 : System.DateTime = System.DateTime (1, 1, 1, v152, v156, v160, v164)
                v167
        let v175 : string = method9()
        let v178 : (string -> string) = v174.ToString
        let v179 : string = v178 v175
        let _v113 = v179 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v182 : US3 option = None
        let _v182 = ref v182 
        let v183 : US3 option ref = _v182 
        let v184 : (US3 option -> US3 option ref) = closure7(v183)
        let v185 : unit = ()
        let v186 : (unit -> unit) = closure8(v100, v184)
        let v187 : unit = (fun () -> v186 (); v185) ()
        let v190 : US3 option = _v182.Value 
        let v201 : US3 = US3_1
        let v202 : US3 = v190 |> Option.defaultValue v201 
        let v242 : System.DateTime =
            match v202 with
            | US3_1 -> (* None *)
                let v238 : System.DateTime = System.DateTime.Now
                v238
            | US3_0(v206) -> (* Some *)
                let v207 : System.DateTime = System.DateTime.Now
                let v210 : (System.DateTime -> int64) = _.Ticks
                let v211 : int64 = v210 v207
                let v214 : int64 = v211 - v206
                let v215 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v216 : System.TimeSpan = v215 v214
                let v219 : (System.TimeSpan -> int32) = _.Hours
                let v220 : int32 = v219 v216
                let v223 : (System.TimeSpan -> int32) = _.Minutes
                let v224 : int32 = v223 v216
                let v227 : (System.TimeSpan -> int32) = _.Seconds
                let v228 : int32 = v227 v216
                let v231 : (System.TimeSpan -> int32) = _.Milliseconds
                let v232 : int32 = v231 v216
                let v235 : System.DateTime = System.DateTime (1, 1, 1, v220, v224, v228, v232)
                v235
        let v243 : string = method9()
        let v246 : (string -> string) = v242.ToString
        let v247 : string = v246 v243
        let _v113 = v247 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v250 : string = $"near_sdk::env::block_timestamp()"
        let v251 : uint64 = Fable.Core.RustInterop.emitRustExpr () v250 
        let v252 : US3 option = None
        let _v252 = ref v252 
        let v253 : US3 option ref = _v252 
        let v254 : (US3 option -> US3 option ref) = closure7(v253)
        let v255 : unit = ()
        let v256 : (unit -> unit) = closure8(v100, v254)
        let v257 : unit = (fun () -> v256 (); v255) ()
        let v260 : US3 option = _v252.Value 
        let v271 : US3 = US3_1
        let v272 : US3 = v260 |> Option.defaultValue v271 
        let v281 : uint64 =
            match v272 with
            | US3_1 -> (* None *)
                v251
            | US3_0(v276) -> (* Some *)
                let v277 : (int64 -> uint64) = uint64
                let v278 : uint64 = v277 v276
                let v279 : uint64 = v251 - v278
                v279
        let v282 : uint64 = v281 / 1000000000UL
        let v283 : uint64 = v282 % 60UL
        let v284 : uint64 = v282 / 60UL
        let v285 : uint64 = v284 % 60UL
        let v286 : uint64 = v282 / 3600UL
        let v287 : uint64 = v286 % 24UL
        let v288 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
        let v289 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v287, v285, v283) v288 
        let v290 : string = "fable_library_rust::String_::fromString($0)"
        let v291 : string = Fable.Core.RustInterop.emitRustExpr v289 v290 
        let _v113 = v291 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v292 : US3 option = None
        let _v292 = ref v292 
        let v293 : US3 option ref = _v292 
        let v294 : (US3 option -> US3 option ref) = closure7(v293)
        let v295 : unit = ()
        let v296 : (unit -> unit) = closure8(v100, v294)
        let v297 : unit = (fun () -> v296 (); v295) ()
        let v300 : US3 option = _v292.Value 
        let v311 : US3 = US3_1
        let v312 : US3 = v300 |> Option.defaultValue v311 
        let v352 : System.DateTime =
            match v312 with
            | US3_1 -> (* None *)
                let v348 : System.DateTime = System.DateTime.Now
                v348
            | US3_0(v316) -> (* Some *)
                let v317 : System.DateTime = System.DateTime.Now
                let v320 : (System.DateTime -> int64) = _.Ticks
                let v321 : int64 = v320 v317
                let v324 : int64 = v321 - v316
                let v325 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v326 : System.TimeSpan = v325 v324
                let v329 : (System.TimeSpan -> int32) = _.Hours
                let v330 : int32 = v329 v326
                let v333 : (System.TimeSpan -> int32) = _.Minutes
                let v334 : int32 = v333 v326
                let v337 : (System.TimeSpan -> int32) = _.Seconds
                let v338 : int32 = v337 v326
                let v341 : (System.TimeSpan -> int32) = _.Milliseconds
                let v342 : int32 = v341 v326
                let v345 : System.DateTime = System.DateTime (1, 1, 1, v330, v334, v338, v342)
                v345
        let v353 : string = method10()
        let v356 : (string -> string) = v352.ToString
        let v357 : string = v356 v353
        let _v113 = v357 
        #endif
#if FABLE_COMPILER_PYTHON
        let v360 : US3 option = None
        let _v360 = ref v360 
        let v361 : US3 option ref = _v360 
        let v362 : (US3 option -> US3 option ref) = closure7(v361)
        let v363 : unit = ()
        let v364 : (unit -> unit) = closure8(v100, v362)
        let v365 : unit = (fun () -> v364 (); v363) ()
        let v368 : US3 option = _v360.Value 
        let v379 : US3 = US3_1
        let v380 : US3 = v368 |> Option.defaultValue v379 
        let v420 : System.DateTime =
            match v380 with
            | US3_1 -> (* None *)
                let v416 : System.DateTime = System.DateTime.Now
                v416
            | US3_0(v384) -> (* Some *)
                let v385 : System.DateTime = System.DateTime.Now
                let v388 : (System.DateTime -> int64) = _.Ticks
                let v389 : int64 = v388 v385
                let v392 : int64 = v389 - v384
                let v393 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v394 : System.TimeSpan = v393 v392
                let v397 : (System.TimeSpan -> int32) = _.Hours
                let v398 : int32 = v397 v394
                let v401 : (System.TimeSpan -> int32) = _.Minutes
                let v402 : int32 = v401 v394
                let v405 : (System.TimeSpan -> int32) = _.Seconds
                let v406 : int32 = v405 v394
                let v409 : (System.TimeSpan -> int32) = _.Milliseconds
                let v410 : int32 = v409 v394
                let v413 : System.DateTime = System.DateTime (1, 1, 1, v398, v402, v406, v410)
                v413
        let v421 : string = method10()
        let v424 : (string -> string) = v420.ToString
        let v425 : string = v424 v421
        let _v113 = v425 
        #endif
#else
        let v428 : US3 option = None
        let _v428 = ref v428 
        let v429 : US3 option ref = _v428 
        let v430 : (US3 option -> US3 option ref) = closure7(v429)
        let v431 : unit = ()
        let v432 : (unit -> unit) = closure8(v100, v430)
        let v433 : unit = (fun () -> v432 (); v431) ()
        let v436 : US3 option = _v428.Value 
        let v447 : US3 = US3_1
        let v448 : US3 = v436 |> Option.defaultValue v447 
        let v488 : System.DateTime =
            match v448 with
            | US3_1 -> (* None *)
                let v484 : System.DateTime = System.DateTime.Now
                v484
            | US3_0(v452) -> (* Some *)
                let v453 : System.DateTime = System.DateTime.Now
                let v456 : (System.DateTime -> int64) = _.Ticks
                let v457 : int64 = v456 v453
                let v460 : int64 = v457 - v452
                let v461 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v462 : System.TimeSpan = v461 v460
                let v465 : (System.TimeSpan -> int32) = _.Hours
                let v466 : int32 = v465 v462
                let v469 : (System.TimeSpan -> int32) = _.Minutes
                let v470 : int32 = v469 v462
                let v473 : (System.TimeSpan -> int32) = _.Seconds
                let v474 : int32 = v473 v462
                let v477 : (System.TimeSpan -> int32) = _.Milliseconds
                let v478 : int32 = v477 v462
                let v481 : System.DateTime = System.DateTime (1, 1, 1, v466, v470, v474, v478)
                v481
        let v489 : string = method10()
        let v492 : (string -> string) = v488.ToString
        let v493 : string = v492 v489
        let _v113 = v493 
        #endif
        let v496 : string = _v113 
        
        
        
        
        
        let v566 : string = "Debug"
        let v567 : (unit -> string) = v566.ToLower
        let v568 : string = v567 ()
        let v571 : string = v568.PadLeft (7, ' ')
        let v585 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v586 : string = "inline_colorization::color_bright_blue"
        let v587 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v586 
        let v588 : string = "&*$0"
        let v589 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v571 v588 
        let v590 : string = "inline_colorization::color_reset"
        let v591 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v590 
        let v592 : string = "\"{v587}{v589}{v591}\""
        let v593 : string = @$"format!(" + v592 + ")"
        let v594 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v593 
        let v595 : string = "fable_library_rust::String_::fromString($0)"
        let v596 : string = Fable.Core.RustInterop.emitRustExpr v594 v595 
        let _v585 = v596 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v597 : string = "inline_colorization::color_bright_blue"
        let v598 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v597 
        let v599 : string = "&*$0"
        let v600 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v571 v599 
        let v601 : string = "inline_colorization::color_reset"
        let v602 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v601 
        let v603 : string = "\"{v598}{v600}{v602}\""
        let v604 : string = @$"format!(" + v603 + ")"
        let v605 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v604 
        let v606 : string = "fable_library_rust::String_::fromString($0)"
        let v607 : string = Fable.Core.RustInterop.emitRustExpr v605 v606 
        let _v585 = v607 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v608 : string = "inline_colorization::color_bright_blue"
        let v609 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v608 
        let v610 : string = "&*$0"
        let v611 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v571 v610 
        let v612 : string = "inline_colorization::color_reset"
        let v613 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v612 
        let v614 : string = "\"{v609}{v611}{v613}\""
        let v615 : string = @$"format!(" + v614 + ")"
        let v616 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v615 
        let v617 : string = "fable_library_rust::String_::fromString($0)"
        let v618 : string = Fable.Core.RustInterop.emitRustExpr v616 v617 
        let _v585 = v618 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v619 : string = "\u001b[94m"
        let v620 : string = method11()
        let v621 : string = v619 + v571 
        let v622 : string = v621 + v620 
        let _v585 = v622 
        #endif
#if FABLE_COMPILER_PYTHON
        let v623 : string = "\u001b[94m"
        let v624 : string = method11()
        let v625 : string = v623 + v571 
        let v626 : string = v625 + v624 
        let _v585 = v626 
        #endif
#else
        let v627 : string = "\u001b[94m"
        let v628 : string = method11()
        let v629 : string = v627 + v571 
        let v630 : string = v629 + v628 
        let _v585 = v630 
        #endif
        let v631 : string = _v585 
        let v637 : int64 = v95.l0
        let v638 : string = method13()
        let v639 : Mut3 = {l0 = v638} : Mut3
        let v640 : string = "{ "
        let v641 : string = $"{v640}"
        let v644 : unit = ()
        let v645 : (unit -> unit) = closure9(v639, v641)
        let v646 : unit = (fun () -> v645 (); v644) ()
        let v649 : string = "retry"
        let v650 : string = $"{v649}"
        let v653 : unit = ()
        let v654 : (unit -> unit) = closure9(v639, v650)
        let v655 : unit = (fun () -> v654 (); v653) ()
        let v658 : string = " = "
        let v659 : string = $"{v658}"
        let v662 : unit = ()
        let v663 : (unit -> unit) = closure9(v639, v659)
        let v664 : unit = (fun () -> v663 (); v662) ()
        let v667 : string = $"{v0}"
        let v670 : unit = ()
        let v671 : (unit -> unit) = closure9(v639, v667)
        let v672 : unit = (fun () -> v671 (); v670) ()
        let v675 : string = "; "
        let v676 : string = $"{v675}"
        let v679 : unit = ()
        let v680 : (unit -> unit) = closure9(v639, v676)
        let v681 : unit = (fun () -> v680 (); v679) ()
        let v684 : string = "ex"
        let v685 : string = $"{v684}"
        let v688 : unit = ()
        let v689 : (unit -> unit) = closure9(v639, v685)
        let v690 : unit = (fun () -> v689 (); v688) ()
        let v693 : string = $"{v658}"
        let v696 : unit = ()
        let v697 : (unit -> unit) = closure9(v639, v693)
        let v698 : unit = (fun () -> v697 (); v696) ()
        let v701 : string = $"{v1}"
        let v704 : unit = ()
        let v705 : (unit -> unit) = closure9(v639, v701)
        let v706 : unit = (fun () -> v705 (); v704) ()
        let v709 : string = " }"
        let v710 : string = $"{v709}"
        let v713 : unit = ()
        let v714 : (unit -> unit) = closure9(v639, v710)
        let v715 : unit = (fun () -> v714 (); v713) ()
        let v718 : string = v639.l0
        let v719 : string = "read_all_text_retry_async"
        let v720 : bool = v719 = ""
        let v777 : string =
            if v720 then
                let v721 : string = ""
                v721
            else
                let v722 : string = $"{v496} {v631} #{v637} %s{v719} / {v718}"
                let v725 : char list = []
                let v726 : (char list -> (char [])) = List.toArray
                let v727 : (char []) = v726 v725
                let v730 : string = v722.TrimStart v727 
                let v748 : char list = []
                let v749 : char list = '/' :: v748 
                let v752 : char list = ' ' :: v749 
                let v755 : (char list -> (char [])) = List.toArray
                let v756 : (char []) = v755 v752
                let v759 : string = v730.TrimEnd v756 
                v759
        let v778 : (string -> unit) = closure10()
        let v779 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v780 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v777 v780 
        let _v779 = () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v781 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v777 v781 
        let _v779 = () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v782 : string = v21.l0
        let v783 : bool = v782 = ""
        let v791 : string =
            if v783 then
                v777
            else
                let v784 : bool = v777 = ""
                if v784 then
                    let v785 : string = v21.l0
                    v785
                else
                    let v786 : string = v21.l0
                    let v787 : string = "\n"
                    let v788 : string = v786 + v787 
                    let v789 : string = v788 + v777 
                    v789
        let v792 : string = "&*$0"
        let v793 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v791 v792 
        let v794 : string = $"$0.chars()"
        let v795 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v793 v794 
        let v796 : string = "v795"
        let v797 : _ = Fable.Core.RustInterop.emitRustExpr () v796 
        let v798 : string = "v797.collect::<Vec<_>>()"
        let v799 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v798 
        let v800 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
        let v801 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v799 v800 
        let v802 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
        let v803 : bool = Fable.Core.RustInterop.emitRustExpr v801 v802 
        let v804 : string = "x"
        let v805 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v804 
        let v806 : string = "String::from_iter($0)"
        let v807 : std_string_String = Fable.Core.RustInterop.emitRustExpr v805 v806 
        let v808 : string = "true; $0 }).collect::<Vec<_>>()"
        let v809 : bool = Fable.Core.RustInterop.emitRustExpr v807 v808 
        let v810 : string = "_vec_map"
        let v811 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v810 
        let v812 : string = "$0.len()"
        let v813 : unativeint = Fable.Core.RustInterop.emitRustExpr v811 v812 
        let v814 : (unativeint -> int32) = int32
        let v815 : int32 = v814 v813
        let v816 : string = ""
        let v817 : bool = v777 <> v816 
        let v821 : bool =
            if v817 then
                let v820 : bool = v815 <= 1
                v820
            else
                false
        if v821 then
            v21.l0 <- v791
            ()
        else
            v21.l0 <- v816
            let v822 : string = "true; $0.into_iter().for_each(|x| { //"
            let v823 : bool = Fable.Core.RustInterop.emitRustExpr v811 v822 
            let v824 : string = "x"
            let v825 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v824 
            let v826 : string = $"near_sdk::log!(\"{{}}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v825 v826 
            let v827 : string = $"true;"
            let v828 : bool = Fable.Core.RustInterop.emitRustExpr () v827 
            let v829 : string = "true; }}); { //"
            let v830 : bool = Fable.Core.RustInterop.emitRustExpr () v829 
            ()
        let _v779 = () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        v778 v777
        let _v779 = () 
        #endif
#if FABLE_COMPILER_PYTHON
        v778 v777
        let _v779 = () 
        #endif
#else
        v778 v777
        let _v779 = () 
        #endif
        _v779 
        let v831 : (string -> unit) = v19.l0
        v831 v777
and method21 (v0 : string, v1 : int64) : Async<string option> =
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
        let v37 : Async<int64> = method15(v0, v36)
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
        let v156 : (int64 -> US9) = closure29()
        let v157 : (exn -> US9) = closure30()
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
        let v1886 : US3 =
            match v217 with
            | US10_1(v220) -> (* Error *)
                let v221 : string = $"%A{v220}"
                let v224 : string = "System.TimeoutException"
                let v225 : bool = v221.Contains v224 
                if v225 then
                    let v228 : unit = ()
                    let v229 : (unit -> unit) = closure31()
                    let v230 : unit = (fun () -> v229 (); v228) ()
                    US3_1
                else
                    let v1028 : unit = ()
                    let v1029 : (unit -> unit) = closure32(v220)
                    let v1030 : unit = (fun () -> v1029 (); v1028) ()
                    US3_1
            | US10_0(v218) -> (* Ok *)
                US3_0(v218)
        return v1886 
        }
        |> fun x -> _v216 <- Some x
        let v1887 : Async<US3> = match _v216 with Some x -> x | None -> failwith "async.new_async_unit / _v216=None"
        let _v200 = v1887 
        #endif
        let v1888 : Async<US3> = _v200 
        return! v1888 
        }
        |> fun x -> _v75 <- Some x
        let v1893 : Async<US3> = match _v75 with Some x -> x | None -> failwith "async.new_async_unit / _v75=None"
        let _v59 = v1893 
        #endif
        let v1894 : Async<US3> = _v59 
        let _v43 = v1894 
        #endif
        let v1899 : Async<US3> = _v43 
        let v1904 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v1905 : Async<unit> = null |> unbox<Async<unit>>
        let _v1904 = v1905 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v1908 : Async<unit> = null |> unbox<Async<unit>>
        let _v1904 = v1908 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v1911 : Async<unit> = null |> unbox<Async<unit>>
        let _v1904 = v1911 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v1914 : Async<unit> = null |> unbox<Async<unit>>
        let _v1904 = v1914 
        #endif
#if FABLE_COMPILER_PYTHON
        let v1917 : Async<unit> = null |> unbox<Async<unit>>
        let _v1904 = v1917 
        #endif
#else
        let v1920 : (Async<US3> -> Async<unit>) = Async.Ignore
        let v1921 : Async<unit> = v1920 v1899
        let _v1904 = v1921 
        #endif
        let v1922 : Async<unit> = _v1904 
        do! v1922 
        ()
    let v1927 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1928 : Async<string> = null |> unbox<Async<string>>
    let _v1927 = v1928 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1931 : Async<string> = null |> unbox<Async<string>>
    let _v1927 = v1931 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1934 : Async<string> = null |> unbox<Async<string>>
    let _v1927 = v1934 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1937 : Async<string> = null |> unbox<Async<string>>
    let _v1927 = v1937 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1940 : Async<string> = null |> unbox<Async<string>>
    let _v1927 = v1940 
    #endif
#else
    let v1943 : (string -> System.Threading.Tasks.Task<string>) = System.IO.File.ReadAllTextAsync
    let v1944 : System.Threading.Tasks.Task<string> = v1943 v0
    let v1945 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1946 : Async<string> = null |> unbox<Async<string>>
    let _v1945 = v1946 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1949 : Async<string> = null |> unbox<Async<string>>
    let _v1945 = v1949 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1952 : Async<string> = null |> unbox<Async<string>>
    let _v1945 = v1952 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1955 : Async<string> = null |> unbox<Async<string>>
    let _v1945 = v1955 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1958 : Async<string> = null |> unbox<Async<string>>
    let _v1945 = v1958 
    #endif
#else
    let v1961 : (System.Threading.Tasks.Task<string> -> Async<string>) = Async.AwaitTask
    let v1962 : Async<string> = v1961 v1944
    let _v1945 = v1962 
    #endif
    let v1963 : Async<string> = _v1945 
    let _v1927 = v1963 
    #endif
    let v1968 : Async<string> = _v1927 
    let v1973 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1974 : Async<string option> = null |> unbox<Async<string option>>
    let _v1973 = v1974 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1977 : Async<string option> = null |> unbox<Async<string option>>
    let _v1973 = v1977 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1980 : Async<string option> = null |> unbox<Async<string option>>
    let _v1973 = v1980 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1983 : Async<string option> = null |> unbox<Async<string option>>
    let _v1973 = v1983 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1986 : Async<string option> = null |> unbox<Async<string option>>
    let _v1973 = v1986 
    #endif
#else
    let v1989 : Async<string option> option = None
    let mutable _v1989 = v1989 
    async {
    let! v1968 = v1968 
    let v1990 : string = v1968 
    let v1991 : string option = Some v1990 
    return v1991 
    }
    |> fun x -> _v1989 <- Some x
    let v1994 : Async<string option> = match _v1989 with Some x -> x | None -> failwith "async.new_async_unit / _v1989=None"
    let _v1973 = v1994 
    #endif
    let v1995 : Async<string option> = _v1973 
    return! v1995 
    with ex ->
    let v2000 : exn = ex
    let v2001 : bool = v1 = 0L
    let v2002 : bool = v2001 <> true
    if v2002 then
        let v2003 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v2004 : string = $"%A{v2000}"
        let _v2003 = v2004 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v2007 : string = $"%A{v2000}"
        let _v2003 = v2007 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v2010 : string = $"%A{v2000}"
        let _v2003 = v2010 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v2013 : string = $"%A{v2000}"
        let _v2003 = v2013 
        #endif
#if FABLE_COMPILER_PYTHON
        let v2016 : string = $"%A{v2000}"
        let _v2003 = v2016 
        #endif
#else
        let v2019 : string = $"{v2000.GetType ()}: {v2000.Message}"
        let _v2003 = v2019 
        #endif
        let v2020 : string = _v2003 
        let v2025 : unit = ()
        let v2026 : (unit -> unit) = closure33(v1, v2020)
        let v2027 : unit = (fun () -> v2026 (); v2025) ()
        let v2858 : string option = None
        return v2858 
        (*
        ()
    else
        *) else
        let v2859 : int64 = v1 + 1L
        let v2860 : Async<string option> = method21(v0, v2859)
        return! v2860 
        (*
        ()
    *)
    (*
    let v2861 : string option = *)
    }
    |> fun x -> _v18 <- Some x
    let v2862 : Async<string option> = match _v18 with Some x -> x | None -> failwith "async.new_async_unit / _v18=None"
    let _v2 = v2862 
    #endif
    let v2863 : Async<string option> = _v2 
    v2863
and closure28 () (v0 : string) : Async<string option> =
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
    let v18 : Async<string option> = method21(v0, v17)
    let _v1 = v18 
    #endif
    let v19 : Async<string option> = _v1 
    v19
and closure35 (v0 : US11 option ref) (v1 : US11 option) : US11 option ref =
    v0.Value <- v1 
    v0
and closure36 (v0 : chrono_DateTime<chrono_Utc> option, v1 : (US11 option -> US11 option ref)) () : unit =
    match v0 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v2 : chrono_DateTime<chrono_Utc> = x
    let v3 : US11 = US11_0(v2)
    v3 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> v1 |> ignore
    ()
and method24 () : string =
    let v0 : string = "hh:mm"
    v0
and method25 () : string =
    let v0 : string = "yyyyMMdd-HHmm-ssff-ffff-f"
    v0
and method26 () : string =
    let v0 : string = "hhmm"
    v0
and method23 (v0 : System.Guid, v1 : System.DateTime) : System.Guid =
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
    let v28 : US11 option = None
    let _v28 = ref v28 
    let v29 : US11 option ref = _v28 
    let v30 : (US11 option -> US11 option ref) = closure35(v29)
    let v31 : unit = ()
    let v32 : (unit -> unit) = closure36(v27, v30)
    let v33 : unit = (fun () -> v32 (); v31) ()
    let v36 : US11 option = _v28.Value 
    let v47 : US11 = US11_1
    let v48 : US11 = v36 |> Option.defaultValue v47 
    let v68 : US1 =
        match v48 with
        | US11_1 -> (* None *)
            US1_1
        | US11_0(v52) -> (* Some *)
            let v53 : string = "$0.naive_utc()"
            let v54 : chrono_NaiveDateTime = Fable.Core.RustInterop.emitRustExpr v52 v53 
            let v55 : string = "chrono::offset::TimeZone::from_utc_datetime(&chrono::Local, &$0)"
            let v56 : chrono_DateTime<chrono_Local> = Fable.Core.RustInterop.emitRustExpr v54 v55 
            let v57 : string = "%Y%m%d-%H%M-%S%f"
            let v58 : string = "r#\"" + v57 + "\"#"
            let v59 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v58 
            let v60 : string = "$0.format($1).to_string()"
            let v61 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v56, v59) v60 
            let v62 : string = "fable_library_rust::String_::fromString($0)"
            let v63 : string = Fable.Core.RustInterop.emitRustExpr v61 v62 
            let v64 : string = $"{v63.[0..17]}-{v63.[18..21]}-{v63.[22]}"
            US1_0(v64)
    let v72 : string =
        match v68 with
        | US1_1 -> (* None *)
            let v70 : string = ""
            v70
        | US1_0(v69) -> (* Some *)
            v69
    let v73 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v74 : string = "0i64.into()"
    let v75 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v74 
    let _v73 = v75 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v76 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v73 = v76 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v79 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v73 = v79 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v82 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v73 = v82 
    #endif
#if FABLE_COMPILER_PYTHON
    let v85 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v73 = v85 
    #endif
#else
    let v88 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v73 = v88 
    #endif
    let v89 : System.TimeZoneInfo = _v73 
    let v94 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v95 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v96 : System.TimeSpan = v95 ()
    let _v94 = v96 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v99 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v100 : System.TimeSpan = v99 ()
    let _v94 = v100 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v103 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v104 : System.TimeSpan = v103 ()
    let _v94 = v104 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v107 : US4 = US4_0
    let v108 : US5 = US5_3(v107)
    let v109 : string = $"date_time.get_utc_offset / target: {v108}"
    let v110 : System.TimeSpan = failwith<System.TimeSpan> v109
    let _v94 = v110 
    #endif
#if FABLE_COMPILER_PYTHON
    let v111 : US4 = US4_0
    let v112 : US5 = US5_4(v111)
    let v113 : string = $"date_time.get_utc_offset / target: {v112}"
    let v114 : System.TimeSpan = failwith<System.TimeSpan> v113
    let _v94 = v114 
    #endif
#else
    let v115 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v116 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v117 : string = "0i64.into()"
    let v118 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v117 
    let _v116 = v118 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v119 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v116 = v119 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v122 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v116 = v122 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v125 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v116 = v125 
    #endif
#if FABLE_COMPILER_PYTHON
    let v128 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v116 = v128 
    #endif
#else
    let v131 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v116 = v131 
    #endif
    let v132 : System.TimeZoneInfo = _v116 
    let v137 : (System.DateTime -> System.TimeSpan) = v115 v132
    let v138 : System.TimeSpan = v137 v13
    let _v94 = v138 
    #endif
    let v139 : System.TimeSpan = _v94 
    let v145 : (System.TimeSpan -> int32) = _.Hours
    let v146 : int32 = v145 v139
    let v149 : bool = v146 > 0
    let v150 : uint8 =
        if v149 then
            1uy
        else
            0uy
    let v151 : string = method24()
    let v152 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v153 : string = v139.ToString v151 
    let _v152 = v153 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v154 : string = v139.ToString v151 
    let _v152 = v154 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v155 : string = v139.ToString v151 
    let _v152 = v155 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v156 : string = v139.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _v152 = v156 
    #endif
#if FABLE_COMPILER_PYTHON
    let v157 : string = v139.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _v152 = v157 
    #endif
#else
    let v158 : string = v139.ToString v151 
    let _v152 = v158 
    #endif
    let v159 : string = _v152 
    let v162 : string = $"{v150}{v159.[0..1]}{v159.[3..4]}"
    let v163 : (System.Guid -> string) = _.ToString()
    let v164 : string = v163 v0
    let v167 : System.Guid = System.Guid $"{v72}{v162}{v164.[v72.Length + v162.Length..]}"
    let _v2 = v167 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v168 : System.DateTime = System.DateTime (1970, 1, 1, 0, 0, 0, System.DateTimeKind.Utc)
    let v171 : (System.DateTime -> System.DateTime) = _.ToUniversalTime()
    let v172 : System.DateTime = v171 v168
    let v175 : System.DateTimeKind = System.DateTimeKind.Local
    let v176 : System.DateTime = System.DateTime.SpecifyKind (v1, v175)
    let v177 : (System.DateTime -> System.DateTime) = _.ToUniversalTime()
    let v178 : System.DateTime = v177 v176
    let v181 : (System.DateTime -> int64) = _.Ticks
    let v182 : int64 = v181 v178
    let v185 : (System.DateTime -> int64) = _.Ticks
    let v186 : int64 = v185 v172
    let v189 : int64 = v182 - v186
    let v190 : int64 = v189 / 10L
    let v191 : string = "chrono::DateTime::from_timestamp_micros($0)"
    let v192 : chrono_DateTime<chrono_Utc> option = Fable.Core.RustInterop.emitRustExpr v190 v191 
    let v193 : US11 option = None
    let _v193 = ref v193 
    let v194 : US11 option ref = _v193 
    let v195 : (US11 option -> US11 option ref) = closure35(v194)
    let v196 : unit = ()
    let v197 : (unit -> unit) = closure36(v192, v195)
    let v198 : unit = (fun () -> v197 (); v196) ()
    let v201 : US11 option = _v193.Value 
    let v212 : US11 = US11_1
    let v213 : US11 = v201 |> Option.defaultValue v212 
    let v233 : US1 =
        match v213 with
        | US11_1 -> (* None *)
            US1_1
        | US11_0(v217) -> (* Some *)
            let v218 : string = "$0.naive_utc()"
            let v219 : chrono_NaiveDateTime = Fable.Core.RustInterop.emitRustExpr v217 v218 
            let v220 : string = "chrono::offset::TimeZone::from_utc_datetime(&chrono::Local, &$0)"
            let v221 : chrono_DateTime<chrono_Local> = Fable.Core.RustInterop.emitRustExpr v219 v220 
            let v222 : string = "%Y%m%d-%H%M-%S%f"
            let v223 : string = "r#\"" + v222 + "\"#"
            let v224 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v223 
            let v225 : string = "$0.format($1).to_string()"
            let v226 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v221, v224) v225 
            let v227 : string = "fable_library_rust::String_::fromString($0)"
            let v228 : string = Fable.Core.RustInterop.emitRustExpr v226 v227 
            let v229 : string = $"{v228.[0..17]}-{v228.[18..21]}-{v228.[22]}"
            US1_0(v229)
    let v237 : string =
        match v233 with
        | US1_1 -> (* None *)
            let v235 : string = ""
            v235
        | US1_0(v234) -> (* Some *)
            v234
    let v238 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v239 : string = "0i64.into()"
    let v240 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v239 
    let _v238 = v240 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v241 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v238 = v241 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v244 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v238 = v244 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v247 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v238 = v247 
    #endif
#if FABLE_COMPILER_PYTHON
    let v250 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v238 = v250 
    #endif
#else
    let v253 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v238 = v253 
    #endif
    let v254 : System.TimeZoneInfo = _v238 
    let v259 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v260 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v261 : System.TimeSpan = v260 ()
    let _v259 = v261 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v264 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v265 : System.TimeSpan = v264 ()
    let _v259 = v265 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v268 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v269 : System.TimeSpan = v268 ()
    let _v259 = v269 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v272 : US4 = US4_0
    let v273 : US5 = US5_3(v272)
    let v274 : string = $"date_time.get_utc_offset / target: {v273}"
    let v275 : System.TimeSpan = failwith<System.TimeSpan> v274
    let _v259 = v275 
    #endif
#if FABLE_COMPILER_PYTHON
    let v276 : US4 = US4_0
    let v277 : US5 = US5_4(v276)
    let v278 : string = $"date_time.get_utc_offset / target: {v277}"
    let v279 : System.TimeSpan = failwith<System.TimeSpan> v278
    let _v259 = v279 
    #endif
#else
    let v280 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v281 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v282 : string = "0i64.into()"
    let v283 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v282 
    let _v281 = v283 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v284 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v281 = v284 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v287 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v281 = v287 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v290 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v281 = v290 
    #endif
#if FABLE_COMPILER_PYTHON
    let v293 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v281 = v293 
    #endif
#else
    let v296 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v281 = v296 
    #endif
    let v297 : System.TimeZoneInfo = _v281 
    let v302 : (System.DateTime -> System.TimeSpan) = v280 v297
    let v303 : System.TimeSpan = v302 v178
    let _v259 = v303 
    #endif
    let v304 : System.TimeSpan = _v259 
    let v310 : (System.TimeSpan -> int32) = _.Hours
    let v311 : int32 = v310 v304
    let v314 : bool = v311 > 0
    let v315 : uint8 =
        if v314 then
            1uy
        else
            0uy
    let v316 : string = method24()
    let v317 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v318 : string = v304.ToString v316 
    let _v317 = v318 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v319 : string = v304.ToString v316 
    let _v317 = v319 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v320 : string = v304.ToString v316 
    let _v317 = v320 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v321 : string = v304.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _v317 = v321 
    #endif
#if FABLE_COMPILER_PYTHON
    let v322 : string = v304.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _v317 = v322 
    #endif
#else
    let v323 : string = v304.ToString v316 
    let _v317 = v323 
    #endif
    let v324 : string = _v317 
    let v327 : string = $"{v315}{v324.[0..1]}{v324.[3..4]}"
    let v328 : (System.Guid -> string) = _.ToString()
    let v329 : string = v328 v0
    let v332 : System.Guid = System.Guid $"{v237}{v327}{v329.[v237.Length + v327.Length..]}"
    let _v2 = v332 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v333 : System.Guid = null |> unbox<System.Guid>
    let _v2 = v333 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v336 : string = method25()
    let v337 : (string -> string) = v1.ToString
    let v338 : string = v337 v336
    let v341 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v342 : string = "0i64.into()"
    let v343 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v342 
    let _v341 = v343 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v344 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v341 = v344 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v347 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v341 = v347 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v350 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v341 = v350 
    #endif
#if FABLE_COMPILER_PYTHON
    let v353 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v341 = v353 
    #endif
#else
    let v356 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v341 = v356 
    #endif
    let v357 : System.TimeZoneInfo = _v341 
    let v362 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v363 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v364 : System.TimeSpan = v363 ()
    let _v362 = v364 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v367 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v368 : System.TimeSpan = v367 ()
    let _v362 = v368 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v371 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v372 : System.TimeSpan = v371 ()
    let _v362 = v372 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v375 : US4 = US4_0
    let v376 : US5 = US5_3(v375)
    let v377 : string = $"date_time.get_utc_offset / target: {v376}"
    let v378 : System.TimeSpan = failwith<System.TimeSpan> v377
    let _v362 = v378 
    #endif
#if FABLE_COMPILER_PYTHON
    let v379 : US4 = US4_0
    let v380 : US5 = US5_4(v379)
    let v381 : string = $"date_time.get_utc_offset / target: {v380}"
    let v382 : System.TimeSpan = failwith<System.TimeSpan> v381
    let _v362 = v382 
    #endif
#else
    let v383 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v384 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v385 : string = "0i64.into()"
    let v386 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v385 
    let _v384 = v386 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v387 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v384 = v387 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v390 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v384 = v390 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v393 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v384 = v393 
    #endif
#if FABLE_COMPILER_PYTHON
    let v396 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v384 = v396 
    #endif
#else
    let v399 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v384 = v399 
    #endif
    let v400 : System.TimeZoneInfo = _v384 
    let v405 : (System.DateTime -> System.TimeSpan) = v383 v400
    let v406 : System.TimeSpan = v405 v1
    let _v362 = v406 
    #endif
    let v407 : System.TimeSpan = _v362 
    let v413 : (System.TimeSpan -> int32) = _.Hours
    let v414 : int32 = v413 v407
    let v417 : bool = v414 > 0
    let v418 : uint8 =
        if v417 then
            1uy
        else
            0uy
    let v419 : string = method26()
    let v420 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v421 : string = v407.ToString v419 
    let _v420 = v421 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v422 : string = v407.ToString v419 
    let _v420 = v422 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v423 : string = v407.ToString v419 
    let _v420 = v423 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v424 : string = v407.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _v420 = v424 
    #endif
#if FABLE_COMPILER_PYTHON
    let v425 : string = v407.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _v420 = v425 
    #endif
#else
    let v426 : string = v407.ToString v419 
    let _v420 = v426 
    #endif
    let v427 : string = _v420 
    let v430 : string = $"{v418}{v427}"
    let v431 : (System.Guid -> string) = _.ToString()
    let v432 : string = v431 v0
    let v435 : System.Guid = System.Guid $"{v338}{v430}{v432.[v338.Length + v430.Length..]}"
    let _v2 = v435 
    #endif
#if FABLE_COMPILER_PYTHON
    let v436 : string = method25()
    let v437 : (string -> string) = v1.ToString
    let v438 : string = v437 v436
    let v441 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v442 : string = "0i64.into()"
    let v443 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v442 
    let _v441 = v443 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v444 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v441 = v444 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v447 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v441 = v447 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v450 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v441 = v450 
    #endif
#if FABLE_COMPILER_PYTHON
    let v453 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v441 = v453 
    #endif
#else
    let v456 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v441 = v456 
    #endif
    let v457 : System.TimeZoneInfo = _v441 
    let v462 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v463 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v464 : System.TimeSpan = v463 ()
    let _v462 = v464 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v467 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v468 : System.TimeSpan = v467 ()
    let _v462 = v468 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v471 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v472 : System.TimeSpan = v471 ()
    let _v462 = v472 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v475 : US4 = US4_0
    let v476 : US5 = US5_3(v475)
    let v477 : string = $"date_time.get_utc_offset / target: {v476}"
    let v478 : System.TimeSpan = failwith<System.TimeSpan> v477
    let _v462 = v478 
    #endif
#if FABLE_COMPILER_PYTHON
    let v479 : US4 = US4_0
    let v480 : US5 = US5_4(v479)
    let v481 : string = $"date_time.get_utc_offset / target: {v480}"
    let v482 : System.TimeSpan = failwith<System.TimeSpan> v481
    let _v462 = v482 
    #endif
#else
    let v483 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v484 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v485 : string = "0i64.into()"
    let v486 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v485 
    let _v484 = v486 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v487 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v484 = v487 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v490 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v484 = v490 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v493 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v484 = v493 
    #endif
#if FABLE_COMPILER_PYTHON
    let v496 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v484 = v496 
    #endif
#else
    let v499 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v484 = v499 
    #endif
    let v500 : System.TimeZoneInfo = _v484 
    let v505 : (System.DateTime -> System.TimeSpan) = v483 v500
    let v506 : System.TimeSpan = v505 v1
    let _v462 = v506 
    #endif
    let v507 : System.TimeSpan = _v462 
    let v513 : (System.TimeSpan -> int32) = _.Hours
    let v514 : int32 = v513 v507
    let v517 : bool = v514 > 0
    let v518 : uint8 =
        if v517 then
            1uy
        else
            0uy
    let v519 : string = method26()
    let v520 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v521 : string = v507.ToString v519 
    let _v520 = v521 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v522 : string = v507.ToString v519 
    let _v520 = v522 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v523 : string = v507.ToString v519 
    let _v520 = v523 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v524 : string = v507.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _v520 = v524 
    #endif
#if FABLE_COMPILER_PYTHON
    let v525 : string = v507.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _v520 = v525 
    #endif
#else
    let v526 : string = v507.ToString v519 
    let _v520 = v526 
    #endif
    let v527 : string = _v520 
    let v530 : string = $"{v518}{v527}"
    let v531 : (System.Guid -> string) = _.ToString()
    let v532 : string = v531 v0
    let v535 : System.Guid = System.Guid $"{v438}{v530}{v532.[v438.Length + v530.Length..]}"
    let _v2 = v535 
    #endif
#else
    let v536 : string = method25()
    let v537 : (string -> string) = v1.ToString
    let v538 : string = v537 v536
    let v541 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v542 : string = "0i64.into()"
    let v543 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v542 
    let _v541 = v543 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v544 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v541 = v544 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v547 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v541 = v547 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v550 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v541 = v550 
    #endif
#if FABLE_COMPILER_PYTHON
    let v553 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v541 = v553 
    #endif
#else
    let v556 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v541 = v556 
    #endif
    let v557 : System.TimeZoneInfo = _v541 
    let v562 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v563 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v564 : System.TimeSpan = v563 ()
    let _v562 = v564 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v567 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v568 : System.TimeSpan = v567 ()
    let _v562 = v568 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v571 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v572 : System.TimeSpan = v571 ()
    let _v562 = v572 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v575 : US4 = US4_0
    let v576 : US5 = US5_3(v575)
    let v577 : string = $"date_time.get_utc_offset / target: {v576}"
    let v578 : System.TimeSpan = failwith<System.TimeSpan> v577
    let _v562 = v578 
    #endif
#if FABLE_COMPILER_PYTHON
    let v579 : US4 = US4_0
    let v580 : US5 = US5_4(v579)
    let v581 : string = $"date_time.get_utc_offset / target: {v580}"
    let v582 : System.TimeSpan = failwith<System.TimeSpan> v581
    let _v562 = v582 
    #endif
#else
    let v583 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v584 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v585 : string = "0i64.into()"
    let v586 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v585 
    let _v584 = v586 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v587 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v584 = v587 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v590 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v584 = v590 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v593 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v584 = v593 
    #endif
#if FABLE_COMPILER_PYTHON
    let v596 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v584 = v596 
    #endif
#else
    let v599 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v584 = v599 
    #endif
    let v600 : System.TimeZoneInfo = _v584 
    let v605 : (System.DateTime -> System.TimeSpan) = v583 v600
    let v606 : System.TimeSpan = v605 v1
    let _v562 = v606 
    #endif
    let v607 : System.TimeSpan = _v562 
    let v613 : (System.TimeSpan -> int32) = _.Hours
    let v614 : int32 = v613 v607
    let v617 : bool = v614 > 0
    let v618 : uint8 =
        if v617 then
            1uy
        else
            0uy
    let v619 : string = method26()
    let v620 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v621 : string = v607.ToString v619 
    let _v620 = v621 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v622 : string = v607.ToString v619 
    let _v620 = v622 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v623 : string = v607.ToString v619 
    let _v620 = v623 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v624 : string = v607.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _v620 = v624 
    #endif
#if FABLE_COMPILER_PYTHON
    let v625 : string = v607.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _v620 = v625 
    #endif
#else
    let v626 : string = v607.ToString v619 
    let _v620 = v626 
    #endif
    let v627 : string = _v620 
    let v630 : string = $"{v618}{v627}"
    let v631 : (System.Guid -> string) = _.ToString()
    let v632 : string = v631 v0
    let v635 : System.Guid = System.Guid $"{v538}{v630}{v632.[v538.Length + v630.Length..]}"
    let _v2 = v635 
    #endif
    let v636 : System.Guid = _v2 
    v636
and method28 () : string =
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
and method29 () : string =
    let v0 : string = "!create_temp_path_"
    v0
and method32 (v0 : string) : string =
    v0
and method31 (v0 : string, v1 : string) : struct (string * string) =
    let v2 : string = method32(v0)
    struct (v1, v2)
and method30 (v0 : string, v1 : string) : string =
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
    let struct (v49 : string, v50 : string) = method31(v1, v0)
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
and method34 () : string =
    let v0 : string = "CARGO_PKG_NAME"
    v0
and method33 () : string =
    let v0 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1 : string = method34()
    let v2 : string = method2(v1)
    let _v0 = v2 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v3 : string = method34()
    let v4 : string = method2(v3)
    let _v0 = v4 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v5 : string = method34()
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
and method27 (v0 : System.Guid) : string =
    let v1 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = method28()
    let v3 : string = method29()
    let v4 : string = method30(v2, v3)
    let v5 : string = method33()
    let v6 : string = method30(v4, v5)
    let v7 : (System.Guid -> string) = _.ToString()
    let v8 : string = v7 v0
    let v11 : string = method30(v6, v8)
    let _v1 = v11 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v12 : string = method28()
    let v13 : string = method29()
    let v14 : string = method30(v12, v13)
    let v15 : string = method33()
    let v16 : string = method30(v14, v15)
    let v17 : (System.Guid -> string) = _.ToString()
    let v18 : string = v17 v0
    let v21 : string = method30(v16, v18)
    let _v1 = v21 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v22 : string = null |> unbox<string>
    let _v1 = v22 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v25 : string = method28()
    let v26 : string = method29()
    let v27 : string = method30(v25, v26)
    let v28 : string = method33()
    let v29 : string = method30(v27, v28)
    let v30 : (System.Guid -> string) = _.ToString()
    let v31 : string = v30 v0
    let v34 : string = method30(v29, v31)
    let _v1 = v34 
    #endif
#if FABLE_COMPILER_PYTHON
    let v35 : string = method28()
    let v36 : string = method29()
    let v37 : string = method30(v35, v36)
    let v38 : string = method33()
    let v39 : string = method30(v37, v38)
    let v40 : (System.Guid -> string) = _.ToString()
    let v41 : string = v40 v0
    let v44 : string = method30(v39, v41)
    let _v1 = v44 
    #endif
#else
    let v45 : string = method28()
    let v46 : string = method29()
    let v47 : string = method30(v45, v46)
    let v48 : string = method33()
    let v49 : string = method30(v47, v48)
    let v50 : (System.Guid -> string) = _.ToString()
    let v51 : string = v50 v0
    let v54 : string = method30(v49, v51)
    let _v1 = v54 
    #endif
    let v55 : string = _v1 
    v55
and method22 () : string =
    let v0 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1 : System.DateTime = System.DateTime.Now
    let v4 : (unit -> System.Guid) = System.Guid.NewGuid
    let v5 : System.Guid = v4 ()
    let v8 : System.Guid = method23(v5, v1)
    let v9 : string = method27(v8)
    let _v0 = v9 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v10 : System.DateTime = System.DateTime.Now
    let v13 : (unit -> System.Guid) = System.Guid.NewGuid
    let v14 : System.Guid = v13 ()
    let v17 : System.Guid = method23(v14, v10)
    let v18 : string = method27(v17)
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
    let v29 : System.Guid = method23(v26, v22)
    let v30 : string = method27(v29)
    let _v0 = v30 
    #endif
#if FABLE_COMPILER_PYTHON
    let v31 : System.DateTime = System.DateTime.Now
    let v34 : (unit -> System.Guid) = System.Guid.NewGuid
    let v35 : System.Guid = v34 ()
    let v38 : System.Guid = method23(v35, v31)
    let v39 : string = method27(v38)
    let _v0 = v39 
    #endif
#else
    let v40 : System.DateTime = System.DateTime.Now
    let v43 : (unit -> System.Guid) = System.Guid.NewGuid
    let v44 : System.Guid = v43 ()
    let v47 : System.Guid = method23(v44, v40)
    let v48 : string = method27(v47)
    let _v0 = v48 
    #endif
    let v49 : string = _v0 
    v49
and closure34 () () : string =
    method22()
and method36 (v0 : string) : string =
    v0
and closure38 () (v0 : std_io_Error) : std_string_String =
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
and method37 () : (std_io_Error -> std_string_String) =
    closure38()
and closure39 () () : US12 =
    US12_0
and closure40 () (v0 : std_string_String) : US12 =
    US12_1(v0)
and closure41 (v0 : string, v1 : std_string_String) () : unit =
    let v2 : unit = ()
    let v3 : (unit -> unit) = closure0()
    let v4 : unit = (fun () -> v3 (); v2) ()
    let struct (v18 : Mut0, v19 : Mut1, v20 : Mut2, v21 : Mut3, v22 : Mut4, v23 : int64 option) = TraceState.trace_state.Value
    let v36 : unit = ()
    let v37 : unit = (fun () -> v3 (); v36) ()
    let struct (v51 : Mut0, v52 : Mut1, v53 : Mut2, v54 : Mut3, v55 : Mut4, v56 : int64 option) = TraceState.trace_state.Value
    let v69 : US0 = v55.l0
    let v70 : bool = v53.l0
    let v71 : bool = v70 = false
    let v74 : bool =
        if v71 then
            false
        else
            let v72 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v69
            let v73 : bool = 4 >= v72
            v73
    if v74 then
        let v75 : unit = ()
        let v76 : (unit -> unit) = closure6(v18)
        let v77 : unit = (fun () -> v76 (); v75) ()
        let v80 : unit = ()
        let v81 : unit = (fun () -> v3 (); v80) ()
        let struct (v95 : Mut0, v96 : Mut1, v97 : Mut2, v98 : Mut3, v99 : Mut4, v100 : int64 option) = TraceState.trace_state.Value
        let v113 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v114 : US3 option = None
        let _v114 = ref v114 
        let v115 : US3 option ref = _v114 
        let v116 : (US3 option -> US3 option ref) = closure7(v115)
        let v117 : unit = ()
        let v118 : (unit -> unit) = closure8(v100, v116)
        let v119 : unit = (fun () -> v118 (); v117) ()
        let v122 : US3 option = _v114.Value 
        let v133 : US3 = US3_1
        let v134 : US3 = v122 |> Option.defaultValue v133 
        let v174 : System.DateTime =
            match v134 with
            | US3_1 -> (* None *)
                let v170 : System.DateTime = System.DateTime.Now
                v170
            | US3_0(v138) -> (* Some *)
                let v139 : System.DateTime = System.DateTime.Now
                let v142 : (System.DateTime -> int64) = _.Ticks
                let v143 : int64 = v142 v139
                let v146 : int64 = v143 - v138
                let v147 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v148 : System.TimeSpan = v147 v146
                let v151 : (System.TimeSpan -> int32) = _.Hours
                let v152 : int32 = v151 v148
                let v155 : (System.TimeSpan -> int32) = _.Minutes
                let v156 : int32 = v155 v148
                let v159 : (System.TimeSpan -> int32) = _.Seconds
                let v160 : int32 = v159 v148
                let v163 : (System.TimeSpan -> int32) = _.Milliseconds
                let v164 : int32 = v163 v148
                let v167 : System.DateTime = System.DateTime (1, 1, 1, v152, v156, v160, v164)
                v167
        let v175 : string = method9()
        let v178 : (string -> string) = v174.ToString
        let v179 : string = v178 v175
        let _v113 = v179 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v182 : US3 option = None
        let _v182 = ref v182 
        let v183 : US3 option ref = _v182 
        let v184 : (US3 option -> US3 option ref) = closure7(v183)
        let v185 : unit = ()
        let v186 : (unit -> unit) = closure8(v100, v184)
        let v187 : unit = (fun () -> v186 (); v185) ()
        let v190 : US3 option = _v182.Value 
        let v201 : US3 = US3_1
        let v202 : US3 = v190 |> Option.defaultValue v201 
        let v242 : System.DateTime =
            match v202 with
            | US3_1 -> (* None *)
                let v238 : System.DateTime = System.DateTime.Now
                v238
            | US3_0(v206) -> (* Some *)
                let v207 : System.DateTime = System.DateTime.Now
                let v210 : (System.DateTime -> int64) = _.Ticks
                let v211 : int64 = v210 v207
                let v214 : int64 = v211 - v206
                let v215 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v216 : System.TimeSpan = v215 v214
                let v219 : (System.TimeSpan -> int32) = _.Hours
                let v220 : int32 = v219 v216
                let v223 : (System.TimeSpan -> int32) = _.Minutes
                let v224 : int32 = v223 v216
                let v227 : (System.TimeSpan -> int32) = _.Seconds
                let v228 : int32 = v227 v216
                let v231 : (System.TimeSpan -> int32) = _.Milliseconds
                let v232 : int32 = v231 v216
                let v235 : System.DateTime = System.DateTime (1, 1, 1, v220, v224, v228, v232)
                v235
        let v243 : string = method9()
        let v246 : (string -> string) = v242.ToString
        let v247 : string = v246 v243
        let _v113 = v247 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v250 : string = $"near_sdk::env::block_timestamp()"
        let v251 : uint64 = Fable.Core.RustInterop.emitRustExpr () v250 
        let v252 : US3 option = None
        let _v252 = ref v252 
        let v253 : US3 option ref = _v252 
        let v254 : (US3 option -> US3 option ref) = closure7(v253)
        let v255 : unit = ()
        let v256 : (unit -> unit) = closure8(v100, v254)
        let v257 : unit = (fun () -> v256 (); v255) ()
        let v260 : US3 option = _v252.Value 
        let v271 : US3 = US3_1
        let v272 : US3 = v260 |> Option.defaultValue v271 
        let v281 : uint64 =
            match v272 with
            | US3_1 -> (* None *)
                v251
            | US3_0(v276) -> (* Some *)
                let v277 : (int64 -> uint64) = uint64
                let v278 : uint64 = v277 v276
                let v279 : uint64 = v251 - v278
                v279
        let v282 : uint64 = v281 / 1000000000UL
        let v283 : uint64 = v282 % 60UL
        let v284 : uint64 = v282 / 60UL
        let v285 : uint64 = v284 % 60UL
        let v286 : uint64 = v282 / 3600UL
        let v287 : uint64 = v286 % 24UL
        let v288 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
        let v289 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v287, v285, v283) v288 
        let v290 : string = "fable_library_rust::String_::fromString($0)"
        let v291 : string = Fable.Core.RustInterop.emitRustExpr v289 v290 
        let _v113 = v291 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v292 : US3 option = None
        let _v292 = ref v292 
        let v293 : US3 option ref = _v292 
        let v294 : (US3 option -> US3 option ref) = closure7(v293)
        let v295 : unit = ()
        let v296 : (unit -> unit) = closure8(v100, v294)
        let v297 : unit = (fun () -> v296 (); v295) ()
        let v300 : US3 option = _v292.Value 
        let v311 : US3 = US3_1
        let v312 : US3 = v300 |> Option.defaultValue v311 
        let v352 : System.DateTime =
            match v312 with
            | US3_1 -> (* None *)
                let v348 : System.DateTime = System.DateTime.Now
                v348
            | US3_0(v316) -> (* Some *)
                let v317 : System.DateTime = System.DateTime.Now
                let v320 : (System.DateTime -> int64) = _.Ticks
                let v321 : int64 = v320 v317
                let v324 : int64 = v321 - v316
                let v325 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v326 : System.TimeSpan = v325 v324
                let v329 : (System.TimeSpan -> int32) = _.Hours
                let v330 : int32 = v329 v326
                let v333 : (System.TimeSpan -> int32) = _.Minutes
                let v334 : int32 = v333 v326
                let v337 : (System.TimeSpan -> int32) = _.Seconds
                let v338 : int32 = v337 v326
                let v341 : (System.TimeSpan -> int32) = _.Milliseconds
                let v342 : int32 = v341 v326
                let v345 : System.DateTime = System.DateTime (1, 1, 1, v330, v334, v338, v342)
                v345
        let v353 : string = method10()
        let v356 : (string -> string) = v352.ToString
        let v357 : string = v356 v353
        let _v113 = v357 
        #endif
#if FABLE_COMPILER_PYTHON
        let v360 : US3 option = None
        let _v360 = ref v360 
        let v361 : US3 option ref = _v360 
        let v362 : (US3 option -> US3 option ref) = closure7(v361)
        let v363 : unit = ()
        let v364 : (unit -> unit) = closure8(v100, v362)
        let v365 : unit = (fun () -> v364 (); v363) ()
        let v368 : US3 option = _v360.Value 
        let v379 : US3 = US3_1
        let v380 : US3 = v368 |> Option.defaultValue v379 
        let v420 : System.DateTime =
            match v380 with
            | US3_1 -> (* None *)
                let v416 : System.DateTime = System.DateTime.Now
                v416
            | US3_0(v384) -> (* Some *)
                let v385 : System.DateTime = System.DateTime.Now
                let v388 : (System.DateTime -> int64) = _.Ticks
                let v389 : int64 = v388 v385
                let v392 : int64 = v389 - v384
                let v393 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v394 : System.TimeSpan = v393 v392
                let v397 : (System.TimeSpan -> int32) = _.Hours
                let v398 : int32 = v397 v394
                let v401 : (System.TimeSpan -> int32) = _.Minutes
                let v402 : int32 = v401 v394
                let v405 : (System.TimeSpan -> int32) = _.Seconds
                let v406 : int32 = v405 v394
                let v409 : (System.TimeSpan -> int32) = _.Milliseconds
                let v410 : int32 = v409 v394
                let v413 : System.DateTime = System.DateTime (1, 1, 1, v398, v402, v406, v410)
                v413
        let v421 : string = method10()
        let v424 : (string -> string) = v420.ToString
        let v425 : string = v424 v421
        let _v113 = v425 
        #endif
#else
        let v428 : US3 option = None
        let _v428 = ref v428 
        let v429 : US3 option ref = _v428 
        let v430 : (US3 option -> US3 option ref) = closure7(v429)
        let v431 : unit = ()
        let v432 : (unit -> unit) = closure8(v100, v430)
        let v433 : unit = (fun () -> v432 (); v431) ()
        let v436 : US3 option = _v428.Value 
        let v447 : US3 = US3_1
        let v448 : US3 = v436 |> Option.defaultValue v447 
        let v488 : System.DateTime =
            match v448 with
            | US3_1 -> (* None *)
                let v484 : System.DateTime = System.DateTime.Now
                v484
            | US3_0(v452) -> (* Some *)
                let v453 : System.DateTime = System.DateTime.Now
                let v456 : (System.DateTime -> int64) = _.Ticks
                let v457 : int64 = v456 v453
                let v460 : int64 = v457 - v452
                let v461 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v462 : System.TimeSpan = v461 v460
                let v465 : (System.TimeSpan -> int32) = _.Hours
                let v466 : int32 = v465 v462
                let v469 : (System.TimeSpan -> int32) = _.Minutes
                let v470 : int32 = v469 v462
                let v473 : (System.TimeSpan -> int32) = _.Seconds
                let v474 : int32 = v473 v462
                let v477 : (System.TimeSpan -> int32) = _.Milliseconds
                let v478 : int32 = v477 v462
                let v481 : System.DateTime = System.DateTime (1, 1, 1, v466, v470, v474, v478)
                v481
        let v489 : string = method10()
        let v492 : (string -> string) = v488.ToString
        let v493 : string = v492 v489
        let _v113 = v493 
        #endif
        let v496 : string = _v113 
        
        
        
        
        
        let v566 : string = "Critical"
        let v567 : (unit -> string) = v566.ToLower
        let v568 : string = v567 ()
        let v571 : string = v568.PadLeft (7, ' ')
        let v585 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v586 : string = "inline_colorization::color_bright_red"
        let v587 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v586 
        let v588 : string = "&*$0"
        let v589 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v571 v588 
        let v590 : string = "inline_colorization::color_reset"
        let v591 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v590 
        let v592 : string = "\"{v587}{v589}{v591}\""
        let v593 : string = @$"format!(" + v592 + ")"
        let v594 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v593 
        let v595 : string = "fable_library_rust::String_::fromString($0)"
        let v596 : string = Fable.Core.RustInterop.emitRustExpr v594 v595 
        let _v585 = v596 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v597 : string = "inline_colorization::color_bright_red"
        let v598 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v597 
        let v599 : string = "&*$0"
        let v600 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v571 v599 
        let v601 : string = "inline_colorization::color_reset"
        let v602 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v601 
        let v603 : string = "\"{v598}{v600}{v602}\""
        let v604 : string = @$"format!(" + v603 + ")"
        let v605 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v604 
        let v606 : string = "fable_library_rust::String_::fromString($0)"
        let v607 : string = Fable.Core.RustInterop.emitRustExpr v605 v606 
        let _v585 = v607 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v608 : string = "inline_colorization::color_bright_red"
        let v609 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v608 
        let v610 : string = "&*$0"
        let v611 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v571 v610 
        let v612 : string = "inline_colorization::color_reset"
        let v613 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v612 
        let v614 : string = "\"{v609}{v611}{v613}\""
        let v615 : string = @$"format!(" + v614 + ")"
        let v616 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v615 
        let v617 : string = "fable_library_rust::String_::fromString($0)"
        let v618 : string = Fable.Core.RustInterop.emitRustExpr v616 v617 
        let _v585 = v618 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v619 : string = "\u001b[91m"
        let v620 : string = method11()
        let v621 : string = v619 + v571 
        let v622 : string = v621 + v620 
        let _v585 = v622 
        #endif
#if FABLE_COMPILER_PYTHON
        let v623 : string = "\u001b[91m"
        let v624 : string = method11()
        let v625 : string = v623 + v571 
        let v626 : string = v625 + v624 
        let _v585 = v626 
        #endif
#else
        let v627 : string = "\u001b[91m"
        let v628 : string = method11()
        let v629 : string = v627 + v571 
        let v630 : string = v629 + v628 
        let _v585 = v630 
        #endif
        let v631 : string = _v585 
        let v637 : int64 = v95.l0
        let v638 : string = method13()
        let v639 : Mut3 = {l0 = v638} : Mut3
        let v640 : string = "{ "
        let v641 : string = $"{v640}"
        let v644 : unit = ()
        let v645 : (unit -> unit) = closure9(v639, v641)
        let v646 : unit = (fun () -> v645 (); v644) ()
        let v649 : string = "dir"
        let v650 : string = $"{v649}"
        let v653 : unit = ()
        let v654 : (unit -> unit) = closure9(v639, v650)
        let v655 : unit = (fun () -> v654 (); v653) ()
        let v658 : string = " = "
        let v659 : string = $"{v658}"
        let v662 : unit = ()
        let v663 : (unit -> unit) = closure9(v639, v659)
        let v664 : unit = (fun () -> v663 (); v662) ()
        let v667 : string = $"{v0}"
        let v670 : unit = ()
        let v671 : (unit -> unit) = closure9(v639, v667)
        let v672 : unit = (fun () -> v671 (); v670) ()
        let v675 : string = "; "
        let v676 : string = $"{v675}"
        let v679 : unit = ()
        let v680 : (unit -> unit) = closure9(v639, v676)
        let v681 : unit = (fun () -> v680 (); v679) ()
        let v684 : string = "error"
        let v685 : string = $"{v684}"
        let v688 : unit = ()
        let v689 : (unit -> unit) = closure9(v639, v685)
        let v690 : unit = (fun () -> v689 (); v688) ()
        let v693 : string = $"{v658}"
        let v696 : unit = ()
        let v697 : (unit -> unit) = closure9(v639, v693)
        let v698 : unit = (fun () -> v697 (); v696) ()
        let v701 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v702 : string = "format!(\"{:#?}\", $0)"
        let v703 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1 v702 
        let v704 : string = "fable_library_rust::String_::fromString($0)"
        let v705 : string = Fable.Core.RustInterop.emitRustExpr v703 v704 
        let _v701 = v705 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v706 : string = "format!(\"{:#?}\", $0)"
        let v707 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1 v706 
        let v708 : string = "fable_library_rust::String_::fromString($0)"
        let v709 : string = Fable.Core.RustInterop.emitRustExpr v707 v708 
        let _v701 = v709 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v710 : string = "format!(\"{:#?}\", $0)"
        let v711 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1 v710 
        let v712 : string = "fable_library_rust::String_::fromString($0)"
        let v713 : string = Fable.Core.RustInterop.emitRustExpr v711 v712 
        let _v701 = v713 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v714 : string = $"%A{v1}"
        let _v701 = v714 
        #endif
#if FABLE_COMPILER_PYTHON
        let v717 : string = $"%A{v1}"
        let _v701 = v717 
        #endif
#else
        let v720 : string = $"%A{v1}"
        let _v701 = v720 
        #endif
        let v723 : string = _v701 
        let v728 : string = $"{v723}"
        let v731 : unit = ()
        let v732 : (unit -> unit) = closure9(v639, v728)
        let v733 : unit = (fun () -> v732 (); v731) ()
        let v736 : string = " }"
        let v737 : string = $"{v736}"
        let v740 : unit = ()
        let v741 : (unit -> unit) = closure9(v639, v737)
        let v742 : unit = (fun () -> v741 (); v740) ()
        let v745 : string = v639.l0
        let v746 : string = "file_system.create_dir"
        let v747 : string = $"{v496} {v631} #{v637} %s{v746} / {v745}"
        let v750 : char list = []
        let v751 : (char list -> (char [])) = List.toArray
        let v752 : (char []) = v751 v750
        let v755 : string = v747.TrimStart v752 
        let v773 : char list = []
        let v774 : char list = '/' :: v773 
        let v777 : char list = ' ' :: v774 
        let v780 : (char list -> (char [])) = List.toArray
        let v781 : (char []) = v780 v777
        let v784 : string = v755.TrimEnd v781 
        let v802 : (string -> unit) = closure10()
        let v803 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v804 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v784 v804 
        let _v803 = () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v805 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v784 v805 
        let _v803 = () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v806 : string = v21.l0
        let v807 : bool = v806 = ""
        let v815 : string =
            if v807 then
                v784
            else
                let v808 : bool = v784 = ""
                if v808 then
                    let v809 : string = v21.l0
                    v809
                else
                    let v810 : string = v21.l0
                    let v811 : string = "\n"
                    let v812 : string = v810 + v811 
                    let v813 : string = v812 + v784 
                    v813
        let v816 : string = "&*$0"
        let v817 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v815 v816 
        let v818 : string = $"$0.chars()"
        let v819 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v817 v818 
        let v820 : string = "v819"
        let v821 : _ = Fable.Core.RustInterop.emitRustExpr () v820 
        let v822 : string = "v821.collect::<Vec<_>>()"
        let v823 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v822 
        let v824 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
        let v825 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v823 v824 
        let v826 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
        let v827 : bool = Fable.Core.RustInterop.emitRustExpr v825 v826 
        let v828 : string = "x"
        let v829 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v828 
        let v830 : string = "String::from_iter($0)"
        let v831 : std_string_String = Fable.Core.RustInterop.emitRustExpr v829 v830 
        let v832 : string = "true; $0 }).collect::<Vec<_>>()"
        let v833 : bool = Fable.Core.RustInterop.emitRustExpr v831 v832 
        let v834 : string = "_vec_map"
        let v835 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v834 
        let v836 : string = "$0.len()"
        let v837 : unativeint = Fable.Core.RustInterop.emitRustExpr v835 v836 
        let v838 : (unativeint -> int32) = int32
        let v839 : int32 = v838 v837
        let v840 : string = ""
        let v841 : bool = v784 <> v840 
        let v845 : bool =
            if v841 then
                let v844 : bool = v839 <= 1
                v844
            else
                false
        if v845 then
            v21.l0 <- v815
            ()
        else
            v21.l0 <- v840
            let v846 : string = "true; $0.into_iter().for_each(|x| { //"
            let v847 : bool = Fable.Core.RustInterop.emitRustExpr v835 v846 
            let v848 : string = "x"
            let v849 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v848 
            let v850 : string = $"near_sdk::log!(\"{{}}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v849 v850 
            let v851 : string = $"true;"
            let v852 : bool = Fable.Core.RustInterop.emitRustExpr () v851 
            let v853 : string = "true; }}); { //"
            let v854 : bool = Fable.Core.RustInterop.emitRustExpr () v853 
            ()
        let _v803 = () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        v802 v784
        let _v803 = () 
        #endif
#if FABLE_COMPILER_PYTHON
        v802 v784
        let _v803 = () 
        #endif
#else
        v802 v784
        let _v803 = () 
        #endif
        _v803 
        let v855 : (string -> unit) = v19.l0
        v855 v784
and closure42 (v0 : string) () : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure0()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v17 : Mut0, v18 : Mut1, v19 : Mut2, v20 : Mut3, v21 : Mut4, v22 : int64 option) = TraceState.trace_state.Value
    let v35 : unit = ()
    let v36 : unit = (fun () -> v2 (); v35) ()
    let struct (v50 : Mut0, v51 : Mut1, v52 : Mut2, v53 : Mut3, v54 : Mut4, v55 : int64 option) = TraceState.trace_state.Value
    let v68 : US0 = v54.l0
    let v69 : bool = v52.l0
    let v70 : bool = v69 = false
    let v73 : bool =
        if v70 then
            false
        else
            let v71 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v68
            let v72 : bool = 0 >= v71
            v72
    if v73 then
        let v74 : unit = ()
        let v75 : (unit -> unit) = closure6(v17)
        let v76 : unit = (fun () -> v75 (); v74) ()
        let v79 : unit = ()
        let v80 : unit = (fun () -> v2 (); v79) ()
        let struct (v94 : Mut0, v95 : Mut1, v96 : Mut2, v97 : Mut3, v98 : Mut4, v99 : int64 option) = TraceState.trace_state.Value
        let v112 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v113 : US3 option = None
        let _v113 = ref v113 
        let v114 : US3 option ref = _v113 
        let v115 : (US3 option -> US3 option ref) = closure7(v114)
        let v116 : unit = ()
        let v117 : (unit -> unit) = closure8(v99, v115)
        let v118 : unit = (fun () -> v117 (); v116) ()
        let v121 : US3 option = _v113.Value 
        let v132 : US3 = US3_1
        let v133 : US3 = v121 |> Option.defaultValue v132 
        let v173 : System.DateTime =
            match v133 with
            | US3_1 -> (* None *)
                let v169 : System.DateTime = System.DateTime.Now
                v169
            | US3_0(v137) -> (* Some *)
                let v138 : System.DateTime = System.DateTime.Now
                let v141 : (System.DateTime -> int64) = _.Ticks
                let v142 : int64 = v141 v138
                let v145 : int64 = v142 - v137
                let v146 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v147 : System.TimeSpan = v146 v145
                let v150 : (System.TimeSpan -> int32) = _.Hours
                let v151 : int32 = v150 v147
                let v154 : (System.TimeSpan -> int32) = _.Minutes
                let v155 : int32 = v154 v147
                let v158 : (System.TimeSpan -> int32) = _.Seconds
                let v159 : int32 = v158 v147
                let v162 : (System.TimeSpan -> int32) = _.Milliseconds
                let v163 : int32 = v162 v147
                let v166 : System.DateTime = System.DateTime (1, 1, 1, v151, v155, v159, v163)
                v166
        let v174 : string = method9()
        let v177 : (string -> string) = v173.ToString
        let v178 : string = v177 v174
        let _v112 = v178 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v181 : US3 option = None
        let _v181 = ref v181 
        let v182 : US3 option ref = _v181 
        let v183 : (US3 option -> US3 option ref) = closure7(v182)
        let v184 : unit = ()
        let v185 : (unit -> unit) = closure8(v99, v183)
        let v186 : unit = (fun () -> v185 (); v184) ()
        let v189 : US3 option = _v181.Value 
        let v200 : US3 = US3_1
        let v201 : US3 = v189 |> Option.defaultValue v200 
        let v241 : System.DateTime =
            match v201 with
            | US3_1 -> (* None *)
                let v237 : System.DateTime = System.DateTime.Now
                v237
            | US3_0(v205) -> (* Some *)
                let v206 : System.DateTime = System.DateTime.Now
                let v209 : (System.DateTime -> int64) = _.Ticks
                let v210 : int64 = v209 v206
                let v213 : int64 = v210 - v205
                let v214 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v215 : System.TimeSpan = v214 v213
                let v218 : (System.TimeSpan -> int32) = _.Hours
                let v219 : int32 = v218 v215
                let v222 : (System.TimeSpan -> int32) = _.Minutes
                let v223 : int32 = v222 v215
                let v226 : (System.TimeSpan -> int32) = _.Seconds
                let v227 : int32 = v226 v215
                let v230 : (System.TimeSpan -> int32) = _.Milliseconds
                let v231 : int32 = v230 v215
                let v234 : System.DateTime = System.DateTime (1, 1, 1, v219, v223, v227, v231)
                v234
        let v242 : string = method9()
        let v245 : (string -> string) = v241.ToString
        let v246 : string = v245 v242
        let _v112 = v246 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v249 : string = $"near_sdk::env::block_timestamp()"
        let v250 : uint64 = Fable.Core.RustInterop.emitRustExpr () v249 
        let v251 : US3 option = None
        let _v251 = ref v251 
        let v252 : US3 option ref = _v251 
        let v253 : (US3 option -> US3 option ref) = closure7(v252)
        let v254 : unit = ()
        let v255 : (unit -> unit) = closure8(v99, v253)
        let v256 : unit = (fun () -> v255 (); v254) ()
        let v259 : US3 option = _v251.Value 
        let v270 : US3 = US3_1
        let v271 : US3 = v259 |> Option.defaultValue v270 
        let v280 : uint64 =
            match v271 with
            | US3_1 -> (* None *)
                v250
            | US3_0(v275) -> (* Some *)
                let v276 : (int64 -> uint64) = uint64
                let v277 : uint64 = v276 v275
                let v278 : uint64 = v250 - v277
                v278
        let v281 : uint64 = v280 / 1000000000UL
        let v282 : uint64 = v281 % 60UL
        let v283 : uint64 = v281 / 60UL
        let v284 : uint64 = v283 % 60UL
        let v285 : uint64 = v281 / 3600UL
        let v286 : uint64 = v285 % 24UL
        let v287 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
        let v288 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v286, v284, v282) v287 
        let v289 : string = "fable_library_rust::String_::fromString($0)"
        let v290 : string = Fable.Core.RustInterop.emitRustExpr v288 v289 
        let _v112 = v290 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v291 : US3 option = None
        let _v291 = ref v291 
        let v292 : US3 option ref = _v291 
        let v293 : (US3 option -> US3 option ref) = closure7(v292)
        let v294 : unit = ()
        let v295 : (unit -> unit) = closure8(v99, v293)
        let v296 : unit = (fun () -> v295 (); v294) ()
        let v299 : US3 option = _v291.Value 
        let v310 : US3 = US3_1
        let v311 : US3 = v299 |> Option.defaultValue v310 
        let v351 : System.DateTime =
            match v311 with
            | US3_1 -> (* None *)
                let v347 : System.DateTime = System.DateTime.Now
                v347
            | US3_0(v315) -> (* Some *)
                let v316 : System.DateTime = System.DateTime.Now
                let v319 : (System.DateTime -> int64) = _.Ticks
                let v320 : int64 = v319 v316
                let v323 : int64 = v320 - v315
                let v324 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v325 : System.TimeSpan = v324 v323
                let v328 : (System.TimeSpan -> int32) = _.Hours
                let v329 : int32 = v328 v325
                let v332 : (System.TimeSpan -> int32) = _.Minutes
                let v333 : int32 = v332 v325
                let v336 : (System.TimeSpan -> int32) = _.Seconds
                let v337 : int32 = v336 v325
                let v340 : (System.TimeSpan -> int32) = _.Milliseconds
                let v341 : int32 = v340 v325
                let v344 : System.DateTime = System.DateTime (1, 1, 1, v329, v333, v337, v341)
                v344
        let v352 : string = method10()
        let v355 : (string -> string) = v351.ToString
        let v356 : string = v355 v352
        let _v112 = v356 
        #endif
#if FABLE_COMPILER_PYTHON
        let v359 : US3 option = None
        let _v359 = ref v359 
        let v360 : US3 option ref = _v359 
        let v361 : (US3 option -> US3 option ref) = closure7(v360)
        let v362 : unit = ()
        let v363 : (unit -> unit) = closure8(v99, v361)
        let v364 : unit = (fun () -> v363 (); v362) ()
        let v367 : US3 option = _v359.Value 
        let v378 : US3 = US3_1
        let v379 : US3 = v367 |> Option.defaultValue v378 
        let v419 : System.DateTime =
            match v379 with
            | US3_1 -> (* None *)
                let v415 : System.DateTime = System.DateTime.Now
                v415
            | US3_0(v383) -> (* Some *)
                let v384 : System.DateTime = System.DateTime.Now
                let v387 : (System.DateTime -> int64) = _.Ticks
                let v388 : int64 = v387 v384
                let v391 : int64 = v388 - v383
                let v392 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v393 : System.TimeSpan = v392 v391
                let v396 : (System.TimeSpan -> int32) = _.Hours
                let v397 : int32 = v396 v393
                let v400 : (System.TimeSpan -> int32) = _.Minutes
                let v401 : int32 = v400 v393
                let v404 : (System.TimeSpan -> int32) = _.Seconds
                let v405 : int32 = v404 v393
                let v408 : (System.TimeSpan -> int32) = _.Milliseconds
                let v409 : int32 = v408 v393
                let v412 : System.DateTime = System.DateTime (1, 1, 1, v397, v401, v405, v409)
                v412
        let v420 : string = method10()
        let v423 : (string -> string) = v419.ToString
        let v424 : string = v423 v420
        let _v112 = v424 
        #endif
#else
        let v427 : US3 option = None
        let _v427 = ref v427 
        let v428 : US3 option ref = _v427 
        let v429 : (US3 option -> US3 option ref) = closure7(v428)
        let v430 : unit = ()
        let v431 : (unit -> unit) = closure8(v99, v429)
        let v432 : unit = (fun () -> v431 (); v430) ()
        let v435 : US3 option = _v427.Value 
        let v446 : US3 = US3_1
        let v447 : US3 = v435 |> Option.defaultValue v446 
        let v487 : System.DateTime =
            match v447 with
            | US3_1 -> (* None *)
                let v483 : System.DateTime = System.DateTime.Now
                v483
            | US3_0(v451) -> (* Some *)
                let v452 : System.DateTime = System.DateTime.Now
                let v455 : (System.DateTime -> int64) = _.Ticks
                let v456 : int64 = v455 v452
                let v459 : int64 = v456 - v451
                let v460 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v461 : System.TimeSpan = v460 v459
                let v464 : (System.TimeSpan -> int32) = _.Hours
                let v465 : int32 = v464 v461
                let v468 : (System.TimeSpan -> int32) = _.Minutes
                let v469 : int32 = v468 v461
                let v472 : (System.TimeSpan -> int32) = _.Seconds
                let v473 : int32 = v472 v461
                let v476 : (System.TimeSpan -> int32) = _.Milliseconds
                let v477 : int32 = v476 v461
                let v480 : System.DateTime = System.DateTime (1, 1, 1, v465, v469, v473, v477)
                v480
        let v488 : string = method10()
        let v491 : (string -> string) = v487.ToString
        let v492 : string = v491 v488
        let _v112 = v492 
        #endif
        let v495 : string = _v112 
        
        
        
        
        
        let v565 : string = "Verbose"
        let v566 : (unit -> string) = v565.ToLower
        let v567 : string = v566 ()
        let v570 : string = v567.PadLeft (7, ' ')
        let v584 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v585 : string = "inline_colorization::color_bright_black"
        let v586 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v585 
        let v587 : string = "&*$0"
        let v588 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v570 v587 
        let v589 : string = "inline_colorization::color_reset"
        let v590 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v589 
        let v591 : string = "\"{v586}{v588}{v590}\""
        let v592 : string = @$"format!(" + v591 + ")"
        let v593 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v592 
        let v594 : string = "fable_library_rust::String_::fromString($0)"
        let v595 : string = Fable.Core.RustInterop.emitRustExpr v593 v594 
        let _v584 = v595 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v596 : string = "inline_colorization::color_bright_black"
        let v597 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v596 
        let v598 : string = "&*$0"
        let v599 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v570 v598 
        let v600 : string = "inline_colorization::color_reset"
        let v601 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v600 
        let v602 : string = "\"{v597}{v599}{v601}\""
        let v603 : string = @$"format!(" + v602 + ")"
        let v604 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v603 
        let v605 : string = "fable_library_rust::String_::fromString($0)"
        let v606 : string = Fable.Core.RustInterop.emitRustExpr v604 v605 
        let _v584 = v606 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v607 : string = "inline_colorization::color_bright_black"
        let v608 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v607 
        let v609 : string = "&*$0"
        let v610 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v570 v609 
        let v611 : string = "inline_colorization::color_reset"
        let v612 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v611 
        let v613 : string = "\"{v608}{v610}{v612}\""
        let v614 : string = @$"format!(" + v613 + ")"
        let v615 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v614 
        let v616 : string = "fable_library_rust::String_::fromString($0)"
        let v617 : string = Fable.Core.RustInterop.emitRustExpr v615 v616 
        let _v584 = v617 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v618 : string = "\u001b[90m"
        let v619 : string = method11()
        let v620 : string = v618 + v570 
        let v621 : string = v620 + v619 
        let _v584 = v621 
        #endif
#if FABLE_COMPILER_PYTHON
        let v622 : string = "\u001b[90m"
        let v623 : string = method11()
        let v624 : string = v622 + v570 
        let v625 : string = v624 + v623 
        let _v584 = v625 
        #endif
#else
        let v626 : string = "\u001b[90m"
        let v627 : string = method11()
        let v628 : string = v626 + v570 
        let v629 : string = v628 + v627 
        let _v584 = v629 
        #endif
        let v630 : string = _v584 
        let v636 : int64 = v94.l0
        let v637 : string = method13()
        let v638 : Mut3 = {l0 = v637} : Mut3
        let v639 : string = "{ "
        let v640 : string = $"{v639}"
        let v643 : unit = ()
        let v644 : (unit -> unit) = closure9(v638, v640)
        let v645 : unit = (fun () -> v644 (); v643) ()
        let v648 : string = "dir"
        let v649 : string = $"{v648}"
        let v652 : unit = ()
        let v653 : (unit -> unit) = closure9(v638, v649)
        let v654 : unit = (fun () -> v653 (); v652) ()
        let v657 : string = " = "
        let v658 : string = $"{v657}"
        let v661 : unit = ()
        let v662 : (unit -> unit) = closure9(v638, v658)
        let v663 : unit = (fun () -> v662 (); v661) ()
        let v666 : string = $"{v0}"
        let v669 : unit = ()
        let v670 : (unit -> unit) = closure9(v638, v666)
        let v671 : unit = (fun () -> v670 (); v669) ()
        let v674 : string = " }"
        let v675 : string = $"{v674}"
        let v678 : unit = ()
        let v679 : (unit -> unit) = closure9(v638, v675)
        let v680 : unit = (fun () -> v679 (); v678) ()
        let v683 : string = v638.l0
        let v684 : string = "file_system.create_dir"
        let v685 : string = $"{v495} {v630} #{v636} %s{v684} / {v683}"
        let v688 : char list = []
        let v689 : (char list -> (char [])) = List.toArray
        let v690 : (char []) = v689 v688
        let v693 : string = v685.TrimStart v690 
        let v711 : char list = []
        let v712 : char list = '/' :: v711 
        let v715 : char list = ' ' :: v712 
        let v718 : (char list -> (char [])) = List.toArray
        let v719 : (char []) = v718 v715
        let v722 : string = v693.TrimEnd v719 
        let v740 : (string -> unit) = closure10()
        let v741 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v742 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v722 v742 
        let _v741 = () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v743 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v722 v743 
        let _v741 = () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v744 : string = v20.l0
        let v745 : bool = v744 = ""
        let v753 : string =
            if v745 then
                v722
            else
                let v746 : bool = v722 = ""
                if v746 then
                    let v747 : string = v20.l0
                    v747
                else
                    let v748 : string = v20.l0
                    let v749 : string = "\n"
                    let v750 : string = v748 + v749 
                    let v751 : string = v750 + v722 
                    v751
        let v754 : string = "&*$0"
        let v755 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v753 v754 
        let v756 : string = $"$0.chars()"
        let v757 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v755 v756 
        let v758 : string = "v757"
        let v759 : _ = Fable.Core.RustInterop.emitRustExpr () v758 
        let v760 : string = "v759.collect::<Vec<_>>()"
        let v761 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v760 
        let v762 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
        let v763 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v761 v762 
        let v764 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
        let v765 : bool = Fable.Core.RustInterop.emitRustExpr v763 v764 
        let v766 : string = "x"
        let v767 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v766 
        let v768 : string = "String::from_iter($0)"
        let v769 : std_string_String = Fable.Core.RustInterop.emitRustExpr v767 v768 
        let v770 : string = "true; $0 }).collect::<Vec<_>>()"
        let v771 : bool = Fable.Core.RustInterop.emitRustExpr v769 v770 
        let v772 : string = "_vec_map"
        let v773 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v772 
        let v774 : string = "$0.len()"
        let v775 : unativeint = Fable.Core.RustInterop.emitRustExpr v773 v774 
        let v776 : (unativeint -> int32) = int32
        let v777 : int32 = v776 v775
        let v778 : string = ""
        let v779 : bool = v722 <> v778 
        let v783 : bool =
            if v779 then
                let v782 : bool = v777 <= 1
                v782
            else
                false
        if v783 then
            v20.l0 <- v753
            ()
        else
            v20.l0 <- v778
            let v784 : string = "true; $0.into_iter().for_each(|x| { //"
            let v785 : bool = Fable.Core.RustInterop.emitRustExpr v773 v784 
            let v786 : string = "x"
            let v787 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v786 
            let v788 : string = $"near_sdk::log!(\"{{}}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v787 v788 
            let v789 : string = $"true;"
            let v790 : bool = Fable.Core.RustInterop.emitRustExpr () v789 
            let v791 : string = "true; }}); { //"
            let v792 : bool = Fable.Core.RustInterop.emitRustExpr () v791 
            ()
        let _v741 = () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        v740 v722
        let _v741 = () 
        #endif
#if FABLE_COMPILER_PYTHON
        v740 v722
        let _v741 = () 
        #endif
#else
        v740 v722
        let _v741 = () 
        #endif
        _v741 
        let v793 : (string -> unit) = v18.l0
        v793 v722
and closure43 (v0 : string) () : unit =
    let v1 : bool = true
    method6(v1, v0)
and method38 (v0 : string) : (unit -> unit) =
    closure43(v0)
and method39 (v0 : string) : (unit -> unit) =
    closure43(v0)
and closure44 (v0 : string, v1 : string) () : unit =
    let v2 : unit = ()
    let v3 : (unit -> unit) = closure0()
    let v4 : unit = (fun () -> v3 (); v2) ()
    let struct (v18 : Mut0, v19 : Mut1, v20 : Mut2, v21 : Mut3, v22 : Mut4, v23 : int64 option) = TraceState.trace_state.Value
    let v36 : unit = ()
    let v37 : unit = (fun () -> v3 (); v36) ()
    let struct (v51 : Mut0, v52 : Mut1, v53 : Mut2, v54 : Mut3, v55 : Mut4, v56 : int64 option) = TraceState.trace_state.Value
    let v69 : US0 = v55.l0
    let v70 : bool = v53.l0
    let v71 : bool = v70 = false
    let v74 : bool =
        if v71 then
            false
        else
            let v72 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v69
            let v73 : bool = 1 >= v72
            v73
    if v74 then
        let v75 : unit = ()
        let v76 : (unit -> unit) = closure6(v18)
        let v77 : unit = (fun () -> v76 (); v75) ()
        let v80 : unit = ()
        let v81 : unit = (fun () -> v3 (); v80) ()
        let struct (v95 : Mut0, v96 : Mut1, v97 : Mut2, v98 : Mut3, v99 : Mut4, v100 : int64 option) = TraceState.trace_state.Value
        let v113 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v114 : US3 option = None
        let _v114 = ref v114 
        let v115 : US3 option ref = _v114 
        let v116 : (US3 option -> US3 option ref) = closure7(v115)
        let v117 : unit = ()
        let v118 : (unit -> unit) = closure8(v100, v116)
        let v119 : unit = (fun () -> v118 (); v117) ()
        let v122 : US3 option = _v114.Value 
        let v133 : US3 = US3_1
        let v134 : US3 = v122 |> Option.defaultValue v133 
        let v174 : System.DateTime =
            match v134 with
            | US3_1 -> (* None *)
                let v170 : System.DateTime = System.DateTime.Now
                v170
            | US3_0(v138) -> (* Some *)
                let v139 : System.DateTime = System.DateTime.Now
                let v142 : (System.DateTime -> int64) = _.Ticks
                let v143 : int64 = v142 v139
                let v146 : int64 = v143 - v138
                let v147 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v148 : System.TimeSpan = v147 v146
                let v151 : (System.TimeSpan -> int32) = _.Hours
                let v152 : int32 = v151 v148
                let v155 : (System.TimeSpan -> int32) = _.Minutes
                let v156 : int32 = v155 v148
                let v159 : (System.TimeSpan -> int32) = _.Seconds
                let v160 : int32 = v159 v148
                let v163 : (System.TimeSpan -> int32) = _.Milliseconds
                let v164 : int32 = v163 v148
                let v167 : System.DateTime = System.DateTime (1, 1, 1, v152, v156, v160, v164)
                v167
        let v175 : string = method9()
        let v178 : (string -> string) = v174.ToString
        let v179 : string = v178 v175
        let _v113 = v179 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v182 : US3 option = None
        let _v182 = ref v182 
        let v183 : US3 option ref = _v182 
        let v184 : (US3 option -> US3 option ref) = closure7(v183)
        let v185 : unit = ()
        let v186 : (unit -> unit) = closure8(v100, v184)
        let v187 : unit = (fun () -> v186 (); v185) ()
        let v190 : US3 option = _v182.Value 
        let v201 : US3 = US3_1
        let v202 : US3 = v190 |> Option.defaultValue v201 
        let v242 : System.DateTime =
            match v202 with
            | US3_1 -> (* None *)
                let v238 : System.DateTime = System.DateTime.Now
                v238
            | US3_0(v206) -> (* Some *)
                let v207 : System.DateTime = System.DateTime.Now
                let v210 : (System.DateTime -> int64) = _.Ticks
                let v211 : int64 = v210 v207
                let v214 : int64 = v211 - v206
                let v215 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v216 : System.TimeSpan = v215 v214
                let v219 : (System.TimeSpan -> int32) = _.Hours
                let v220 : int32 = v219 v216
                let v223 : (System.TimeSpan -> int32) = _.Minutes
                let v224 : int32 = v223 v216
                let v227 : (System.TimeSpan -> int32) = _.Seconds
                let v228 : int32 = v227 v216
                let v231 : (System.TimeSpan -> int32) = _.Milliseconds
                let v232 : int32 = v231 v216
                let v235 : System.DateTime = System.DateTime (1, 1, 1, v220, v224, v228, v232)
                v235
        let v243 : string = method9()
        let v246 : (string -> string) = v242.ToString
        let v247 : string = v246 v243
        let _v113 = v247 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v250 : string = $"near_sdk::env::block_timestamp()"
        let v251 : uint64 = Fable.Core.RustInterop.emitRustExpr () v250 
        let v252 : US3 option = None
        let _v252 = ref v252 
        let v253 : US3 option ref = _v252 
        let v254 : (US3 option -> US3 option ref) = closure7(v253)
        let v255 : unit = ()
        let v256 : (unit -> unit) = closure8(v100, v254)
        let v257 : unit = (fun () -> v256 (); v255) ()
        let v260 : US3 option = _v252.Value 
        let v271 : US3 = US3_1
        let v272 : US3 = v260 |> Option.defaultValue v271 
        let v281 : uint64 =
            match v272 with
            | US3_1 -> (* None *)
                v251
            | US3_0(v276) -> (* Some *)
                let v277 : (int64 -> uint64) = uint64
                let v278 : uint64 = v277 v276
                let v279 : uint64 = v251 - v278
                v279
        let v282 : uint64 = v281 / 1000000000UL
        let v283 : uint64 = v282 % 60UL
        let v284 : uint64 = v282 / 60UL
        let v285 : uint64 = v284 % 60UL
        let v286 : uint64 = v282 / 3600UL
        let v287 : uint64 = v286 % 24UL
        let v288 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
        let v289 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v287, v285, v283) v288 
        let v290 : string = "fable_library_rust::String_::fromString($0)"
        let v291 : string = Fable.Core.RustInterop.emitRustExpr v289 v290 
        let _v113 = v291 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v292 : US3 option = None
        let _v292 = ref v292 
        let v293 : US3 option ref = _v292 
        let v294 : (US3 option -> US3 option ref) = closure7(v293)
        let v295 : unit = ()
        let v296 : (unit -> unit) = closure8(v100, v294)
        let v297 : unit = (fun () -> v296 (); v295) ()
        let v300 : US3 option = _v292.Value 
        let v311 : US3 = US3_1
        let v312 : US3 = v300 |> Option.defaultValue v311 
        let v352 : System.DateTime =
            match v312 with
            | US3_1 -> (* None *)
                let v348 : System.DateTime = System.DateTime.Now
                v348
            | US3_0(v316) -> (* Some *)
                let v317 : System.DateTime = System.DateTime.Now
                let v320 : (System.DateTime -> int64) = _.Ticks
                let v321 : int64 = v320 v317
                let v324 : int64 = v321 - v316
                let v325 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v326 : System.TimeSpan = v325 v324
                let v329 : (System.TimeSpan -> int32) = _.Hours
                let v330 : int32 = v329 v326
                let v333 : (System.TimeSpan -> int32) = _.Minutes
                let v334 : int32 = v333 v326
                let v337 : (System.TimeSpan -> int32) = _.Seconds
                let v338 : int32 = v337 v326
                let v341 : (System.TimeSpan -> int32) = _.Milliseconds
                let v342 : int32 = v341 v326
                let v345 : System.DateTime = System.DateTime (1, 1, 1, v330, v334, v338, v342)
                v345
        let v353 : string = method10()
        let v356 : (string -> string) = v352.ToString
        let v357 : string = v356 v353
        let _v113 = v357 
        #endif
#if FABLE_COMPILER_PYTHON
        let v360 : US3 option = None
        let _v360 = ref v360 
        let v361 : US3 option ref = _v360 
        let v362 : (US3 option -> US3 option ref) = closure7(v361)
        let v363 : unit = ()
        let v364 : (unit -> unit) = closure8(v100, v362)
        let v365 : unit = (fun () -> v364 (); v363) ()
        let v368 : US3 option = _v360.Value 
        let v379 : US3 = US3_1
        let v380 : US3 = v368 |> Option.defaultValue v379 
        let v420 : System.DateTime =
            match v380 with
            | US3_1 -> (* None *)
                let v416 : System.DateTime = System.DateTime.Now
                v416
            | US3_0(v384) -> (* Some *)
                let v385 : System.DateTime = System.DateTime.Now
                let v388 : (System.DateTime -> int64) = _.Ticks
                let v389 : int64 = v388 v385
                let v392 : int64 = v389 - v384
                let v393 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v394 : System.TimeSpan = v393 v392
                let v397 : (System.TimeSpan -> int32) = _.Hours
                let v398 : int32 = v397 v394
                let v401 : (System.TimeSpan -> int32) = _.Minutes
                let v402 : int32 = v401 v394
                let v405 : (System.TimeSpan -> int32) = _.Seconds
                let v406 : int32 = v405 v394
                let v409 : (System.TimeSpan -> int32) = _.Milliseconds
                let v410 : int32 = v409 v394
                let v413 : System.DateTime = System.DateTime (1, 1, 1, v398, v402, v406, v410)
                v413
        let v421 : string = method10()
        let v424 : (string -> string) = v420.ToString
        let v425 : string = v424 v421
        let _v113 = v425 
        #endif
#else
        let v428 : US3 option = None
        let _v428 = ref v428 
        let v429 : US3 option ref = _v428 
        let v430 : (US3 option -> US3 option ref) = closure7(v429)
        let v431 : unit = ()
        let v432 : (unit -> unit) = closure8(v100, v430)
        let v433 : unit = (fun () -> v432 (); v431) ()
        let v436 : US3 option = _v428.Value 
        let v447 : US3 = US3_1
        let v448 : US3 = v436 |> Option.defaultValue v447 
        let v488 : System.DateTime =
            match v448 with
            | US3_1 -> (* None *)
                let v484 : System.DateTime = System.DateTime.Now
                v484
            | US3_0(v452) -> (* Some *)
                let v453 : System.DateTime = System.DateTime.Now
                let v456 : (System.DateTime -> int64) = _.Ticks
                let v457 : int64 = v456 v453
                let v460 : int64 = v457 - v452
                let v461 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v462 : System.TimeSpan = v461 v460
                let v465 : (System.TimeSpan -> int32) = _.Hours
                let v466 : int32 = v465 v462
                let v469 : (System.TimeSpan -> int32) = _.Minutes
                let v470 : int32 = v469 v462
                let v473 : (System.TimeSpan -> int32) = _.Seconds
                let v474 : int32 = v473 v462
                let v477 : (System.TimeSpan -> int32) = _.Milliseconds
                let v478 : int32 = v477 v462
                let v481 : System.DateTime = System.DateTime (1, 1, 1, v466, v470, v474, v478)
                v481
        let v489 : string = method10()
        let v492 : (string -> string) = v488.ToString
        let v493 : string = v492 v489
        let _v113 = v493 
        #endif
        let v496 : string = _v113 
        
        
        
        
        
        let v566 : string = "Debug"
        let v567 : (unit -> string) = v566.ToLower
        let v568 : string = v567 ()
        let v571 : string = v568.PadLeft (7, ' ')
        let v585 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v586 : string = "inline_colorization::color_bright_blue"
        let v587 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v586 
        let v588 : string = "&*$0"
        let v589 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v571 v588 
        let v590 : string = "inline_colorization::color_reset"
        let v591 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v590 
        let v592 : string = "\"{v587}{v589}{v591}\""
        let v593 : string = @$"format!(" + v592 + ")"
        let v594 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v593 
        let v595 : string = "fable_library_rust::String_::fromString($0)"
        let v596 : string = Fable.Core.RustInterop.emitRustExpr v594 v595 
        let _v585 = v596 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v597 : string = "inline_colorization::color_bright_blue"
        let v598 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v597 
        let v599 : string = "&*$0"
        let v600 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v571 v599 
        let v601 : string = "inline_colorization::color_reset"
        let v602 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v601 
        let v603 : string = "\"{v598}{v600}{v602}\""
        let v604 : string = @$"format!(" + v603 + ")"
        let v605 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v604 
        let v606 : string = "fable_library_rust::String_::fromString($0)"
        let v607 : string = Fable.Core.RustInterop.emitRustExpr v605 v606 
        let _v585 = v607 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v608 : string = "inline_colorization::color_bright_blue"
        let v609 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v608 
        let v610 : string = "&*$0"
        let v611 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v571 v610 
        let v612 : string = "inline_colorization::color_reset"
        let v613 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v612 
        let v614 : string = "\"{v609}{v611}{v613}\""
        let v615 : string = @$"format!(" + v614 + ")"
        let v616 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v615 
        let v617 : string = "fable_library_rust::String_::fromString($0)"
        let v618 : string = Fable.Core.RustInterop.emitRustExpr v616 v617 
        let _v585 = v618 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v619 : string = "\u001b[94m"
        let v620 : string = method11()
        let v621 : string = v619 + v571 
        let v622 : string = v621 + v620 
        let _v585 = v622 
        #endif
#if FABLE_COMPILER_PYTHON
        let v623 : string = "\u001b[94m"
        let v624 : string = method11()
        let v625 : string = v623 + v571 
        let v626 : string = v625 + v624 
        let _v585 = v626 
        #endif
#else
        let v627 : string = "\u001b[94m"
        let v628 : string = method11()
        let v629 : string = v627 + v571 
        let v630 : string = v629 + v628 
        let _v585 = v630 
        #endif
        let v631 : string = _v585 
        let v637 : int64 = v95.l0
        let v638 : string = method13()
        let v639 : Mut3 = {l0 = v638} : Mut3
        let v640 : string = "{ "
        let v641 : string = $"{v640}"
        let v644 : unit = ()
        let v645 : (unit -> unit) = closure9(v639, v641)
        let v646 : unit = (fun () -> v645 (); v644) ()
        let v649 : string = "dir"
        let v650 : string = $"{v649}"
        let v653 : unit = ()
        let v654 : (unit -> unit) = closure9(v639, v650)
        let v655 : unit = (fun () -> v654 (); v653) ()
        let v658 : string = " = "
        let v659 : string = $"{v658}"
        let v662 : unit = ()
        let v663 : (unit -> unit) = closure9(v639, v659)
        let v664 : unit = (fun () -> v663 (); v662) ()
        let v667 : string = $"{v0}"
        let v670 : unit = ()
        let v671 : (unit -> unit) = closure9(v639, v667)
        let v672 : unit = (fun () -> v671 (); v670) ()
        let v675 : string = "; "
        let v676 : string = $"{v675}"
        let v679 : unit = ()
        let v680 : (unit -> unit) = closure9(v639, v676)
        let v681 : unit = (fun () -> v680 (); v679) ()
        let v684 : string = "result"
        let v685 : string = $"{v684}"
        let v688 : unit = ()
        let v689 : (unit -> unit) = closure9(v639, v685)
        let v690 : unit = (fun () -> v689 (); v688) ()
        let v693 : string = $"{v658}"
        let v696 : unit = ()
        let v697 : (unit -> unit) = closure9(v639, v693)
        let v698 : unit = (fun () -> v697 (); v696) ()
        let v701 : string = $"{v1}"
        let v704 : unit = ()
        let v705 : (unit -> unit) = closure9(v639, v701)
        let v706 : unit = (fun () -> v705 (); v704) ()
        let v709 : string = " }"
        let v710 : string = $"{v709}"
        let v713 : unit = ()
        let v714 : (unit -> unit) = closure9(v639, v710)
        let v715 : unit = (fun () -> v714 (); v713) ()
        let v718 : string = v639.l0
        let v719 : string = "file_system.create_dir"
        let v720 : string = $"{v496} {v631} #{v637} %s{v719} / {v718}"
        let v723 : char list = []
        let v724 : (char list -> (char [])) = List.toArray
        let v725 : (char []) = v724 v723
        let v728 : string = v720.TrimStart v725 
        let v746 : char list = []
        let v747 : char list = '/' :: v746 
        let v750 : char list = ' ' :: v747 
        let v753 : (char list -> (char [])) = List.toArray
        let v754 : (char []) = v753 v750
        let v757 : string = v728.TrimEnd v754 
        let v775 : (string -> unit) = closure10()
        let v776 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v777 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v757 v777 
        let _v776 = () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v778 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v757 v778 
        let _v776 = () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v779 : string = v21.l0
        let v780 : bool = v779 = ""
        let v788 : string =
            if v780 then
                v757
            else
                let v781 : bool = v757 = ""
                if v781 then
                    let v782 : string = v21.l0
                    v782
                else
                    let v783 : string = v21.l0
                    let v784 : string = "\n"
                    let v785 : string = v783 + v784 
                    let v786 : string = v785 + v757 
                    v786
        let v789 : string = "&*$0"
        let v790 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v788 v789 
        let v791 : string = $"$0.chars()"
        let v792 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v790 v791 
        let v793 : string = "v792"
        let v794 : _ = Fable.Core.RustInterop.emitRustExpr () v793 
        let v795 : string = "v794.collect::<Vec<_>>()"
        let v796 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v795 
        let v797 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
        let v798 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v796 v797 
        let v799 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
        let v800 : bool = Fable.Core.RustInterop.emitRustExpr v798 v799 
        let v801 : string = "x"
        let v802 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v801 
        let v803 : string = "String::from_iter($0)"
        let v804 : std_string_String = Fable.Core.RustInterop.emitRustExpr v802 v803 
        let v805 : string = "true; $0 }).collect::<Vec<_>>()"
        let v806 : bool = Fable.Core.RustInterop.emitRustExpr v804 v805 
        let v807 : string = "_vec_map"
        let v808 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v807 
        let v809 : string = "$0.len()"
        let v810 : unativeint = Fable.Core.RustInterop.emitRustExpr v808 v809 
        let v811 : (unativeint -> int32) = int32
        let v812 : int32 = v811 v810
        let v813 : string = ""
        let v814 : bool = v757 <> v813 
        let v818 : bool =
            if v814 then
                let v817 : bool = v812 <= 1
                v817
            else
                false
        if v818 then
            v21.l0 <- v788
            ()
        else
            v21.l0 <- v813
            let v819 : string = "true; $0.into_iter().for_each(|x| { //"
            let v820 : bool = Fable.Core.RustInterop.emitRustExpr v808 v819 
            let v821 : string = "x"
            let v822 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v821 
            let v823 : string = $"near_sdk::log!(\"{{}}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v822 v823 
            let v824 : string = $"true;"
            let v825 : bool = Fable.Core.RustInterop.emitRustExpr () v824 
            let v826 : string = "true; }}); { //"
            let v827 : bool = Fable.Core.RustInterop.emitRustExpr () v826 
            ()
        let _v776 = () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        v775 v757
        let _v776 = () 
        #endif
#if FABLE_COMPILER_PYTHON
        v775 v757
        let _v776 = () 
        #endif
#else
        v775 v757
        let _v776 = () 
        #endif
        _v776 
        let v828 : (string -> unit) = v19.l0
        v828 v757
and closure45 (v0 : string) () : unit =
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
    let v18 : Async<int64> = method5(v0, v17)
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
and method40 (v0 : string) : (unit -> unit) =
    closure45(v0)
and method41 (v0 : string) : (unit -> unit) =
    closure45(v0)
and method35 (v0 : string) : System.IDisposable =
    let v1 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = method36(v0)
    let v3 : string = "std::fs::create_dir_all(&*$0)"
    let v4 : Result<unit, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v2 v3 
    let v5 : (std_io_Error -> std_string_String) = method37()
    let v6 : string = "$0.map_err(|x| $1(x))"
    let v7 : Result<unit, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v4, v5) v6 
    let v8 : (unit -> US12) = closure39()
    let v9 : (std_string_String -> US12) = closure40()
    let v10 : US12 = match v7 with Ok () -> v8 () | Error x -> v9 x
    match v10 with
    | US12_1(v807) -> (* Error *)
        let v808 : unit = ()
        let v809 : (unit -> unit) = closure41(v2, v807)
        let v810 : unit = (fun () -> v809 (); v808) ()
        ()
    | US12_0 -> (* Ok *)
        let v11 : unit = ()
        let v12 : (unit -> unit) = closure42(v2)
        let v13 : unit = (fun () -> v12 (); v11) ()
        ()
    let v1665 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1666 : (unit -> unit) = method38(v2)
    let v1667 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v1666 "$0()" )
    let _v1665 = v1667 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1668 : (unit -> unit) = method38(v2)
    let v1669 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v1668 "$0()" )
    let _v1665 = v1669 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1670 : (unit -> unit) = method38(v2)
    let v1671 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v1670 "$0()" )
    let _v1665 = v1671 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1672 : (unit -> unit) = method39(v2)
    let v1673 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v1672 () }
    let _v1665 = v1673 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1674 : (unit -> unit) = method39(v2)
    let v1675 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v1674 () }
    let _v1665 = v1675 
    #endif
#else
    let v1676 : (unit -> unit) = method39(v2)
    let v1677 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v1676 () }
    let _v1665 = v1677 
    #endif
    let v1678 : System.IDisposable = _v1665 
    let _v1 = v1678 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1682 : System.IDisposable = null |> unbox<System.IDisposable>
    let _v1 = v1682 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1685 : System.IDisposable = null |> unbox<System.IDisposable>
    let _v1 = v1685 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1688 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1689 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    let _v1688 = v1689 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1692 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    let _v1688 = v1692 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1695 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    let _v1688 = v1695 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1698 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    let _v1688 = v1698 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1701 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    let _v1688 = v1701 
    #endif
#else
    let v1704 : (string -> System.IO.DirectoryInfo) = System.IO.Directory.CreateDirectory
    let v1705 : System.IO.DirectoryInfo = v1704 v0
    let _v1688 = v1705 
    #endif
    let v1706 : System.IO.DirectoryInfo = _v1688 
    let v1711 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1712 : bool = null |> unbox<bool>
    let _v1711 = v1712 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1715 : bool = null |> unbox<bool>
    let _v1711 = v1715 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1718 : bool = null |> unbox<bool>
    let _v1711 = v1718 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1721 : bool = null |> unbox<bool>
    let _v1711 = v1721 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1724 : bool = null |> unbox<bool>
    let _v1711 = v1724 
    #endif
#else
    let v1727 : bool = v1706.Exists
    let _v1711 = v1727 
    #endif
    let v1728 : bool = _v1711 
    let v1733 : bool = v1728 = false
    if v1733 then
        let v1734 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v1735 : System.DateTime = null |> unbox<System.DateTime>
        let _v1734 = v1735 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v1738 : System.DateTime = null |> unbox<System.DateTime>
        let _v1734 = v1738 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v1741 : System.DateTime = null |> unbox<System.DateTime>
        let _v1734 = v1741 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v1744 : System.DateTime = null |> unbox<System.DateTime>
        let _v1734 = v1744 
        #endif
#if FABLE_COMPILER_PYTHON
        let v1747 : System.DateTime = null |> unbox<System.DateTime>
        let _v1734 = v1747 
        #endif
#else
        let v1750 : System.DateTime = v1706.CreationTime
        let _v1734 = v1750 
        #endif
        let v1751 : System.DateTime = _v1734 
        let v1756 : obj = {| Exists = v1728; CreationTime = v1751 |}
        let v1757 : string = $"%A{v1756}"
        let v1760 : unit = ()
        let v1761 : (unit -> unit) = closure44(v0, v1757)
        let v1762 : unit = (fun () -> v1761 (); v1760) ()
        ()
    let v2590 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2591 : (unit -> unit) = method40(v0)
    let v2592 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v2591 "$0()" )
    let _v2590 = v2592 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v2593 : (unit -> unit) = method40(v0)
    let v2594 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v2593 "$0()" )
    let _v2590 = v2594 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v2595 : (unit -> unit) = method40(v0)
    let v2596 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v2595 "$0()" )
    let _v2590 = v2596 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v2597 : (unit -> unit) = method41(v0)
    let v2598 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v2597 () }
    let _v2590 = v2598 
    #endif
#if FABLE_COMPILER_PYTHON
    let v2599 : (unit -> unit) = method41(v0)
    let v2600 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v2599 () }
    let _v2590 = v2600 
    #endif
#else
    let v2601 : (unit -> unit) = method41(v0)
    let v2602 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v2601 () }
    let _v2590 = v2602 
    #endif
    let v2603 : System.IDisposable = _v2590 
    let _v1 = v2603 
    #endif
#if FABLE_COMPILER_PYTHON
    let v2607 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2608 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    let _v2607 = v2608 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v2611 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    let _v2607 = v2611 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v2614 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    let _v2607 = v2614 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v2617 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    let _v2607 = v2617 
    #endif
#if FABLE_COMPILER_PYTHON
    let v2620 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    let _v2607 = v2620 
    #endif
#else
    let v2623 : (string -> System.IO.DirectoryInfo) = System.IO.Directory.CreateDirectory
    let v2624 : System.IO.DirectoryInfo = v2623 v0
    let _v2607 = v2624 
    #endif
    let v2625 : System.IO.DirectoryInfo = _v2607 
    let v2630 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2631 : bool = null |> unbox<bool>
    let _v2630 = v2631 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v2634 : bool = null |> unbox<bool>
    let _v2630 = v2634 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v2637 : bool = null |> unbox<bool>
    let _v2630 = v2637 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v2640 : bool = null |> unbox<bool>
    let _v2630 = v2640 
    #endif
#if FABLE_COMPILER_PYTHON
    let v2643 : bool = null |> unbox<bool>
    let _v2630 = v2643 
    #endif
#else
    let v2646 : bool = v2625.Exists
    let _v2630 = v2646 
    #endif
    let v2647 : bool = _v2630 
    let v2652 : bool = v2647 = false
    if v2652 then
        let v2653 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v2654 : System.DateTime = null |> unbox<System.DateTime>
        let _v2653 = v2654 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v2657 : System.DateTime = null |> unbox<System.DateTime>
        let _v2653 = v2657 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v2660 : System.DateTime = null |> unbox<System.DateTime>
        let _v2653 = v2660 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v2663 : System.DateTime = null |> unbox<System.DateTime>
        let _v2653 = v2663 
        #endif
#if FABLE_COMPILER_PYTHON
        let v2666 : System.DateTime = null |> unbox<System.DateTime>
        let _v2653 = v2666 
        #endif
#else
        let v2669 : System.DateTime = v2625.CreationTime
        let _v2653 = v2669 
        #endif
        let v2670 : System.DateTime = _v2653 
        let v2675 : obj = {| Exists = v2647; CreationTime = v2670 |}
        let v2676 : string = $"%A{v2675}"
        let v2679 : unit = ()
        let v2680 : (unit -> unit) = closure44(v0, v2676)
        let v2681 : unit = (fun () -> v2680 (); v2679) ()
        ()
    let v3509 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3510 : (unit -> unit) = method40(v0)
    let v3511 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v3510 "$0()" )
    let _v3509 = v3511 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v3512 : (unit -> unit) = method40(v0)
    let v3513 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v3512 "$0()" )
    let _v3509 = v3513 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v3514 : (unit -> unit) = method40(v0)
    let v3515 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v3514 "$0()" )
    let _v3509 = v3515 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v3516 : (unit -> unit) = method41(v0)
    let v3517 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v3516 () }
    let _v3509 = v3517 
    #endif
#if FABLE_COMPILER_PYTHON
    let v3518 : (unit -> unit) = method41(v0)
    let v3519 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v3518 () }
    let _v3509 = v3519 
    #endif
#else
    let v3520 : (unit -> unit) = method41(v0)
    let v3521 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v3520 () }
    let _v3509 = v3521 
    #endif
    let v3522 : System.IDisposable = _v3509 
    let _v1 = v3522 
    #endif
#else
    let v3526 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3527 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    let _v3526 = v3527 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v3530 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    let _v3526 = v3530 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v3533 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    let _v3526 = v3533 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v3536 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    let _v3526 = v3536 
    #endif
#if FABLE_COMPILER_PYTHON
    let v3539 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    let _v3526 = v3539 
    #endif
#else
    let v3542 : (string -> System.IO.DirectoryInfo) = System.IO.Directory.CreateDirectory
    let v3543 : System.IO.DirectoryInfo = v3542 v0
    let _v3526 = v3543 
    #endif
    let v3544 : System.IO.DirectoryInfo = _v3526 
    let v3549 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3550 : bool = null |> unbox<bool>
    let _v3549 = v3550 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v3553 : bool = null |> unbox<bool>
    let _v3549 = v3553 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v3556 : bool = null |> unbox<bool>
    let _v3549 = v3556 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v3559 : bool = null |> unbox<bool>
    let _v3549 = v3559 
    #endif
#if FABLE_COMPILER_PYTHON
    let v3562 : bool = null |> unbox<bool>
    let _v3549 = v3562 
    #endif
#else
    let v3565 : bool = v3544.Exists
    let _v3549 = v3565 
    #endif
    let v3566 : bool = _v3549 
    let v3571 : bool = v3566 = false
    if v3571 then
        let v3572 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v3573 : System.DateTime = null |> unbox<System.DateTime>
        let _v3572 = v3573 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v3576 : System.DateTime = null |> unbox<System.DateTime>
        let _v3572 = v3576 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v3579 : System.DateTime = null |> unbox<System.DateTime>
        let _v3572 = v3579 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v3582 : System.DateTime = null |> unbox<System.DateTime>
        let _v3572 = v3582 
        #endif
#if FABLE_COMPILER_PYTHON
        let v3585 : System.DateTime = null |> unbox<System.DateTime>
        let _v3572 = v3585 
        #endif
#else
        let v3588 : System.DateTime = v3544.CreationTime
        let _v3572 = v3588 
        #endif
        let v3589 : System.DateTime = _v3572 
        let v3594 : obj = {| Exists = v3566; CreationTime = v3589 |}
        let v3595 : string = $"%A{v3594}"
        let v3598 : unit = ()
        let v3599 : (unit -> unit) = closure44(v0, v3595)
        let v3600 : unit = (fun () -> v3599 (); v3598) ()
        ()
    let v4428 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v4429 : (unit -> unit) = method40(v0)
    let v4430 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v4429 "$0()" )
    let _v4428 = v4430 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v4431 : (unit -> unit) = method40(v0)
    let v4432 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v4431 "$0()" )
    let _v4428 = v4432 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v4433 : (unit -> unit) = method40(v0)
    let v4434 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v4433 "$0()" )
    let _v4428 = v4434 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v4435 : (unit -> unit) = method41(v0)
    let v4436 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v4435 () }
    let _v4428 = v4436 
    #endif
#if FABLE_COMPILER_PYTHON
    let v4437 : (unit -> unit) = method41(v0)
    let v4438 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v4437 () }
    let _v4428 = v4438 
    #endif
#else
    let v4439 : (unit -> unit) = method41(v0)
    let v4440 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v4439 () }
    let _v4428 = v4440 
    #endif
    let v4441 : System.IDisposable = _v4428 
    let _v1 = v4441 
    #endif
    let v4445 : System.IDisposable = _v1 
    v4445
and closure37 () () : struct (string * System.IDisposable) =
    let v0 : string = method22()
    let v1 : System.IDisposable = method35(v0)
    struct (v0, v1)
and method42 (v0 : string) : System.Guid =
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
and closure46 () (v0 : string) : struct (string * System.IDisposable) =
    let v1 : System.Guid = method42(v0)
    let v2 : string = method27(v1)
    let v3 : System.IDisposable = method35(v2)
    struct (v2, v3)
and closure47 () () : string =
    let v0 : string = __SOURCE_DIRECTORY__
    v0
and method44 (v0 : string) : string =
    v0
and method43 (v0 : string) : string =
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
        let v10 : string = method44(v0)
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
and closure48 () (v0 : string) : string =
    method43(v0)
and closure49 () (v0 : string) : string =
    let v1 : char list = []
    let v2 : char list = '/' :: v1 
    let v5 : (char list -> (char [])) = List.toArray
    let v6 : (char []) = v5 v2
    let v9 : string = v0.TrimStart v6 
    let v27 : string = $"file:///{v9}"
    v27
and method47 (v0 : string) : string option =
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
and closure51 () (v0 : string) : string option =
    method47(v0)
and method46 () : (string -> string option) =
    closure51()
and method48 (v0 : string, v1 : string, v2 : string) : US13 =
    let v3 : string = method30(v2, v0)
    let v4 : bool = method8(v3)
    if v4 then
        US13_0(v2)
    else
        let v6 : (string -> string option) = method46()
        let v7 : string option = v6 v2
        let v8 : US1 option = None
        let _v8 = ref v8 
        let v9 : US1 option ref = _v8 
        let v10 : (US1 option -> US1 option ref) = closure1(v9)
        let v11 : unit = ()
        let v12 : (unit -> unit) = closure2(v7, v10)
        let v13 : unit = (fun () -> v12 (); v11) ()
        let v16 : US1 option = _v8.Value 
        let v27 : US1 = US1_1
        let v28 : US1 = v16 |> Option.defaultValue v27 
        match v28 with
        | US1_1 -> (* None *)
            let v34 : string = $"""No parent for {if false then "file" else "dir"} '{v0}' at '{v1}' (until '{v2}')"""
            US13_1(v34)
        | US1_0(v32) -> (* Some *)
            method48(v0, v1, v32)
and method45 (v0 : string, v1 : string) : US13 =
    let v2 : string = method30(v1, v0)
    let v3 : bool = method8(v2)
    if v3 then
        US13_0(v1)
    else
        let v5 : (string -> string option) = method46()
        let v6 : string option = v5 v1
        let v7 : US1 option = None
        let _v7 = ref v7 
        let v8 : US1 option ref = _v7 
        let v9 : (US1 option -> US1 option ref) = closure1(v8)
        let v10 : unit = ()
        let v11 : (unit -> unit) = closure2(v6, v9)
        let v12 : unit = (fun () -> v11 (); v10) ()
        let v15 : US1 option = _v7.Value 
        let v26 : US1 = US1_1
        let v27 : US1 = v15 |> Option.defaultValue v26 
        match v27 with
        | US1_1 -> (* None *)
            let v33 : string = $"""No parent for {if false then "file" else "dir"} '{v0}' at '{v1}' (until '{v1}')"""
            US13_1(v33)
        | US1_0(v31) -> (* Some *)
            method48(v0, v1, v31)
and closure52 (v0 : string) () : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure0()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v17 : Mut0, v18 : Mut1, v19 : Mut2, v20 : Mut3, v21 : Mut4, v22 : int64 option) = TraceState.trace_state.Value
    let v35 : unit = ()
    let v36 : unit = (fun () -> v2 (); v35) ()
    let struct (v50 : Mut0, v51 : Mut1, v52 : Mut2, v53 : Mut3, v54 : Mut4, v55 : int64 option) = TraceState.trace_state.Value
    let v68 : US0 = v54.l0
    let v69 : bool = v52.l0
    let v70 : bool = v69 = false
    let v73 : bool =
        if v70 then
            false
        else
            let v71 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v68
            let v72 : bool = 3 >= v71
            v72
    if v73 then
        let v74 : unit = ()
        let v75 : (unit -> unit) = closure6(v17)
        let v76 : unit = (fun () -> v75 (); v74) ()
        let v79 : unit = ()
        let v80 : unit = (fun () -> v2 (); v79) ()
        let struct (v94 : Mut0, v95 : Mut1, v96 : Mut2, v97 : Mut3, v98 : Mut4, v99 : int64 option) = TraceState.trace_state.Value
        let v112 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v113 : US3 option = None
        let _v113 = ref v113 
        let v114 : US3 option ref = _v113 
        let v115 : (US3 option -> US3 option ref) = closure7(v114)
        let v116 : unit = ()
        let v117 : (unit -> unit) = closure8(v99, v115)
        let v118 : unit = (fun () -> v117 (); v116) ()
        let v121 : US3 option = _v113.Value 
        let v132 : US3 = US3_1
        let v133 : US3 = v121 |> Option.defaultValue v132 
        let v173 : System.DateTime =
            match v133 with
            | US3_1 -> (* None *)
                let v169 : System.DateTime = System.DateTime.Now
                v169
            | US3_0(v137) -> (* Some *)
                let v138 : System.DateTime = System.DateTime.Now
                let v141 : (System.DateTime -> int64) = _.Ticks
                let v142 : int64 = v141 v138
                let v145 : int64 = v142 - v137
                let v146 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v147 : System.TimeSpan = v146 v145
                let v150 : (System.TimeSpan -> int32) = _.Hours
                let v151 : int32 = v150 v147
                let v154 : (System.TimeSpan -> int32) = _.Minutes
                let v155 : int32 = v154 v147
                let v158 : (System.TimeSpan -> int32) = _.Seconds
                let v159 : int32 = v158 v147
                let v162 : (System.TimeSpan -> int32) = _.Milliseconds
                let v163 : int32 = v162 v147
                let v166 : System.DateTime = System.DateTime (1, 1, 1, v151, v155, v159, v163)
                v166
        let v174 : string = method9()
        let v177 : (string -> string) = v173.ToString
        let v178 : string = v177 v174
        let _v112 = v178 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v181 : US3 option = None
        let _v181 = ref v181 
        let v182 : US3 option ref = _v181 
        let v183 : (US3 option -> US3 option ref) = closure7(v182)
        let v184 : unit = ()
        let v185 : (unit -> unit) = closure8(v99, v183)
        let v186 : unit = (fun () -> v185 (); v184) ()
        let v189 : US3 option = _v181.Value 
        let v200 : US3 = US3_1
        let v201 : US3 = v189 |> Option.defaultValue v200 
        let v241 : System.DateTime =
            match v201 with
            | US3_1 -> (* None *)
                let v237 : System.DateTime = System.DateTime.Now
                v237
            | US3_0(v205) -> (* Some *)
                let v206 : System.DateTime = System.DateTime.Now
                let v209 : (System.DateTime -> int64) = _.Ticks
                let v210 : int64 = v209 v206
                let v213 : int64 = v210 - v205
                let v214 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v215 : System.TimeSpan = v214 v213
                let v218 : (System.TimeSpan -> int32) = _.Hours
                let v219 : int32 = v218 v215
                let v222 : (System.TimeSpan -> int32) = _.Minutes
                let v223 : int32 = v222 v215
                let v226 : (System.TimeSpan -> int32) = _.Seconds
                let v227 : int32 = v226 v215
                let v230 : (System.TimeSpan -> int32) = _.Milliseconds
                let v231 : int32 = v230 v215
                let v234 : System.DateTime = System.DateTime (1, 1, 1, v219, v223, v227, v231)
                v234
        let v242 : string = method9()
        let v245 : (string -> string) = v241.ToString
        let v246 : string = v245 v242
        let _v112 = v246 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v249 : string = $"near_sdk::env::block_timestamp()"
        let v250 : uint64 = Fable.Core.RustInterop.emitRustExpr () v249 
        let v251 : US3 option = None
        let _v251 = ref v251 
        let v252 : US3 option ref = _v251 
        let v253 : (US3 option -> US3 option ref) = closure7(v252)
        let v254 : unit = ()
        let v255 : (unit -> unit) = closure8(v99, v253)
        let v256 : unit = (fun () -> v255 (); v254) ()
        let v259 : US3 option = _v251.Value 
        let v270 : US3 = US3_1
        let v271 : US3 = v259 |> Option.defaultValue v270 
        let v280 : uint64 =
            match v271 with
            | US3_1 -> (* None *)
                v250
            | US3_0(v275) -> (* Some *)
                let v276 : (int64 -> uint64) = uint64
                let v277 : uint64 = v276 v275
                let v278 : uint64 = v250 - v277
                v278
        let v281 : uint64 = v280 / 1000000000UL
        let v282 : uint64 = v281 % 60UL
        let v283 : uint64 = v281 / 60UL
        let v284 : uint64 = v283 % 60UL
        let v285 : uint64 = v281 / 3600UL
        let v286 : uint64 = v285 % 24UL
        let v287 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
        let v288 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v286, v284, v282) v287 
        let v289 : string = "fable_library_rust::String_::fromString($0)"
        let v290 : string = Fable.Core.RustInterop.emitRustExpr v288 v289 
        let _v112 = v290 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v291 : US3 option = None
        let _v291 = ref v291 
        let v292 : US3 option ref = _v291 
        let v293 : (US3 option -> US3 option ref) = closure7(v292)
        let v294 : unit = ()
        let v295 : (unit -> unit) = closure8(v99, v293)
        let v296 : unit = (fun () -> v295 (); v294) ()
        let v299 : US3 option = _v291.Value 
        let v310 : US3 = US3_1
        let v311 : US3 = v299 |> Option.defaultValue v310 
        let v351 : System.DateTime =
            match v311 with
            | US3_1 -> (* None *)
                let v347 : System.DateTime = System.DateTime.Now
                v347
            | US3_0(v315) -> (* Some *)
                let v316 : System.DateTime = System.DateTime.Now
                let v319 : (System.DateTime -> int64) = _.Ticks
                let v320 : int64 = v319 v316
                let v323 : int64 = v320 - v315
                let v324 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v325 : System.TimeSpan = v324 v323
                let v328 : (System.TimeSpan -> int32) = _.Hours
                let v329 : int32 = v328 v325
                let v332 : (System.TimeSpan -> int32) = _.Minutes
                let v333 : int32 = v332 v325
                let v336 : (System.TimeSpan -> int32) = _.Seconds
                let v337 : int32 = v336 v325
                let v340 : (System.TimeSpan -> int32) = _.Milliseconds
                let v341 : int32 = v340 v325
                let v344 : System.DateTime = System.DateTime (1, 1, 1, v329, v333, v337, v341)
                v344
        let v352 : string = method10()
        let v355 : (string -> string) = v351.ToString
        let v356 : string = v355 v352
        let _v112 = v356 
        #endif
#if FABLE_COMPILER_PYTHON
        let v359 : US3 option = None
        let _v359 = ref v359 
        let v360 : US3 option ref = _v359 
        let v361 : (US3 option -> US3 option ref) = closure7(v360)
        let v362 : unit = ()
        let v363 : (unit -> unit) = closure8(v99, v361)
        let v364 : unit = (fun () -> v363 (); v362) ()
        let v367 : US3 option = _v359.Value 
        let v378 : US3 = US3_1
        let v379 : US3 = v367 |> Option.defaultValue v378 
        let v419 : System.DateTime =
            match v379 with
            | US3_1 -> (* None *)
                let v415 : System.DateTime = System.DateTime.Now
                v415
            | US3_0(v383) -> (* Some *)
                let v384 : System.DateTime = System.DateTime.Now
                let v387 : (System.DateTime -> int64) = _.Ticks
                let v388 : int64 = v387 v384
                let v391 : int64 = v388 - v383
                let v392 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v393 : System.TimeSpan = v392 v391
                let v396 : (System.TimeSpan -> int32) = _.Hours
                let v397 : int32 = v396 v393
                let v400 : (System.TimeSpan -> int32) = _.Minutes
                let v401 : int32 = v400 v393
                let v404 : (System.TimeSpan -> int32) = _.Seconds
                let v405 : int32 = v404 v393
                let v408 : (System.TimeSpan -> int32) = _.Milliseconds
                let v409 : int32 = v408 v393
                let v412 : System.DateTime = System.DateTime (1, 1, 1, v397, v401, v405, v409)
                v412
        let v420 : string = method10()
        let v423 : (string -> string) = v419.ToString
        let v424 : string = v423 v420
        let _v112 = v424 
        #endif
#else
        let v427 : US3 option = None
        let _v427 = ref v427 
        let v428 : US3 option ref = _v427 
        let v429 : (US3 option -> US3 option ref) = closure7(v428)
        let v430 : unit = ()
        let v431 : (unit -> unit) = closure8(v99, v429)
        let v432 : unit = (fun () -> v431 (); v430) ()
        let v435 : US3 option = _v427.Value 
        let v446 : US3 = US3_1
        let v447 : US3 = v435 |> Option.defaultValue v446 
        let v487 : System.DateTime =
            match v447 with
            | US3_1 -> (* None *)
                let v483 : System.DateTime = System.DateTime.Now
                v483
            | US3_0(v451) -> (* Some *)
                let v452 : System.DateTime = System.DateTime.Now
                let v455 : (System.DateTime -> int64) = _.Ticks
                let v456 : int64 = v455 v452
                let v459 : int64 = v456 - v451
                let v460 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v461 : System.TimeSpan = v460 v459
                let v464 : (System.TimeSpan -> int32) = _.Hours
                let v465 : int32 = v464 v461
                let v468 : (System.TimeSpan -> int32) = _.Minutes
                let v469 : int32 = v468 v461
                let v472 : (System.TimeSpan -> int32) = _.Seconds
                let v473 : int32 = v472 v461
                let v476 : (System.TimeSpan -> int32) = _.Milliseconds
                let v477 : int32 = v476 v461
                let v480 : System.DateTime = System.DateTime (1, 1, 1, v465, v469, v473, v477)
                v480
        let v488 : string = method10()
        let v491 : (string -> string) = v487.ToString
        let v492 : string = v491 v488
        let _v112 = v492 
        #endif
        let v495 : string = _v112 
        
        
        
        
        
        let v565 : string = "Warning"
        let v566 : (unit -> string) = v565.ToLower
        let v567 : string = v566 ()
        let v570 : string = v567.PadLeft (7, ' ')
        let v584 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v585 : string = "inline_colorization::color_yellow"
        let v586 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v585 
        let v587 : string = "&*$0"
        let v588 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v570 v587 
        let v589 : string = "inline_colorization::color_reset"
        let v590 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v589 
        let v591 : string = "\"{v586}{v588}{v590}\""
        let v592 : string = @$"format!(" + v591 + ")"
        let v593 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v592 
        let v594 : string = "fable_library_rust::String_::fromString($0)"
        let v595 : string = Fable.Core.RustInterop.emitRustExpr v593 v594 
        let _v584 = v595 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v596 : string = "inline_colorization::color_yellow"
        let v597 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v596 
        let v598 : string = "&*$0"
        let v599 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v570 v598 
        let v600 : string = "inline_colorization::color_reset"
        let v601 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v600 
        let v602 : string = "\"{v597}{v599}{v601}\""
        let v603 : string = @$"format!(" + v602 + ")"
        let v604 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v603 
        let v605 : string = "fable_library_rust::String_::fromString($0)"
        let v606 : string = Fable.Core.RustInterop.emitRustExpr v604 v605 
        let _v584 = v606 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v607 : string = "inline_colorization::color_yellow"
        let v608 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v607 
        let v609 : string = "&*$0"
        let v610 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v570 v609 
        let v611 : string = "inline_colorization::color_reset"
        let v612 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v611 
        let v613 : string = "\"{v608}{v610}{v612}\""
        let v614 : string = @$"format!(" + v613 + ")"
        let v615 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v614 
        let v616 : string = "fable_library_rust::String_::fromString($0)"
        let v617 : string = Fable.Core.RustInterop.emitRustExpr v615 v616 
        let _v584 = v617 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v618 : string = "\u001b[93m"
        let v619 : string = method11()
        let v620 : string = v618 + v570 
        let v621 : string = v620 + v619 
        let _v584 = v621 
        #endif
#if FABLE_COMPILER_PYTHON
        let v622 : string = "\u001b[93m"
        let v623 : string = method11()
        let v624 : string = v622 + v570 
        let v625 : string = v624 + v623 
        let _v584 = v625 
        #endif
#else
        let v626 : string = "\u001b[93m"
        let v627 : string = method11()
        let v628 : string = v626 + v570 
        let v629 : string = v628 + v627 
        let _v584 = v629 
        #endif
        let v630 : string = _v584 
        let v636 : int64 = v94.l0
        let v637 : string = method13()
        let v638 : Mut3 = {l0 = v637} : Mut3
        let v639 : string = "{ "
        let v640 : string = $"{v639}"
        let v643 : unit = ()
        let v644 : (unit -> unit) = closure9(v638, v640)
        let v645 : unit = (fun () -> v644 (); v643) ()
        let v648 : string = "error"
        let v649 : string = $"{v648}"
        let v652 : unit = ()
        let v653 : (unit -> unit) = closure9(v638, v649)
        let v654 : unit = (fun () -> v653 (); v652) ()
        let v657 : string = " = "
        let v658 : string = $"{v657}"
        let v661 : unit = ()
        let v662 : (unit -> unit) = closure9(v638, v658)
        let v663 : unit = (fun () -> v662 (); v661) ()
        let v666 : string = $"{v0}"
        let v669 : unit = ()
        let v670 : (unit -> unit) = closure9(v638, v666)
        let v671 : unit = (fun () -> v670 (); v669) ()
        let v674 : string = " }"
        let v675 : string = $"{v674}"
        let v678 : unit = ()
        let v679 : (unit -> unit) = closure9(v638, v675)
        let v680 : unit = (fun () -> v679 (); v678) ()
        let v683 : string = v638.l0
        let v684 : string = "file_system.get_workspace_root"
        let v685 : string = $"{v495} {v630} #{v636} %s{v684} / {v683}"
        let v688 : char list = []
        let v689 : (char list -> (char [])) = List.toArray
        let v690 : (char []) = v689 v688
        let v693 : string = v685.TrimStart v690 
        let v711 : char list = []
        let v712 : char list = '/' :: v711 
        let v715 : char list = ' ' :: v712 
        let v718 : (char list -> (char [])) = List.toArray
        let v719 : (char []) = v718 v715
        let v722 : string = v693.TrimEnd v719 
        let v740 : (string -> unit) = closure10()
        let v741 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v742 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v722 v742 
        let _v741 = () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v743 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v722 v743 
        let _v741 = () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v744 : string = v20.l0
        let v745 : bool = v744 = ""
        let v753 : string =
            if v745 then
                v722
            else
                let v746 : bool = v722 = ""
                if v746 then
                    let v747 : string = v20.l0
                    v747
                else
                    let v748 : string = v20.l0
                    let v749 : string = "\n"
                    let v750 : string = v748 + v749 
                    let v751 : string = v750 + v722 
                    v751
        let v754 : string = "&*$0"
        let v755 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v753 v754 
        let v756 : string = $"$0.chars()"
        let v757 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v755 v756 
        let v758 : string = "v757"
        let v759 : _ = Fable.Core.RustInterop.emitRustExpr () v758 
        let v760 : string = "v759.collect::<Vec<_>>()"
        let v761 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v760 
        let v762 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
        let v763 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v761 v762 
        let v764 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
        let v765 : bool = Fable.Core.RustInterop.emitRustExpr v763 v764 
        let v766 : string = "x"
        let v767 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v766 
        let v768 : string = "String::from_iter($0)"
        let v769 : std_string_String = Fable.Core.RustInterop.emitRustExpr v767 v768 
        let v770 : string = "true; $0 }).collect::<Vec<_>>()"
        let v771 : bool = Fable.Core.RustInterop.emitRustExpr v769 v770 
        let v772 : string = "_vec_map"
        let v773 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v772 
        let v774 : string = "$0.len()"
        let v775 : unativeint = Fable.Core.RustInterop.emitRustExpr v773 v774 
        let v776 : (unativeint -> int32) = int32
        let v777 : int32 = v776 v775
        let v778 : string = ""
        let v779 : bool = v722 <> v778 
        let v783 : bool =
            if v779 then
                let v782 : bool = v777 <= 1
                v782
            else
                false
        if v783 then
            v20.l0 <- v753
            ()
        else
            v20.l0 <- v778
            let v784 : string = "true; $0.into_iter().for_each(|x| { //"
            let v785 : bool = Fable.Core.RustInterop.emitRustExpr v773 v784 
            let v786 : string = "x"
            let v787 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v786 
            let v788 : string = $"near_sdk::log!(\"{{}}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v787 v788 
            let v789 : string = $"true;"
            let v790 : bool = Fable.Core.RustInterop.emitRustExpr () v789 
            let v791 : string = "true; }}); { //"
            let v792 : bool = Fable.Core.RustInterop.emitRustExpr () v791 
            ()
        let _v741 = () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        v740 v722
        let _v741 = () 
        #endif
#if FABLE_COMPILER_PYTHON
        v740 v722
        let _v741 = () 
        #endif
#else
        v740 v722
        let _v741 = () 
        #endif
        _v741 
        let v793 : (string -> unit) = v18.l0
        v793 v722
and method49 () : string =
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
and closure50 () () : string =
    let v0 : string = __SOURCE_DIRECTORY__
    let v1 : string = "polyglot"
    let v2 : string = ".devcontainer"
    let v3 : string = method30(v1, v2)
    let v4 : US13 = method45(v3, v0)
    let v806 : US1 =
        match v4 with
        | US13_1(v7) -> (* Error *)
            let v8 : unit = ()
            let v9 : (unit -> unit) = closure52(v7)
            let v10 : unit = (fun () -> v9 (); v8) ()
            US1_1
        | US13_0(v5) -> (* Ok *)
            US1_0(v5)
    let v1615 : US1 =
        match v806 with
        | US1_1 -> (* None *)
            let v809 : string = method49()
            let v810 : string = method30(v1, v2)
            let v811 : US13 = method45(v810, v809)
            match v811 with
            | US13_1(v814) -> (* Error *)
                let v815 : unit = ()
                let v816 : (unit -> unit) = closure52(v814)
                let v817 : unit = (fun () -> v816 (); v815) ()
                US1_1
            | US13_0(v812) -> (* Ok *)
                US1_0(v812)
        | US1_0(v807) -> (* Some *)
            US1_0(v807)
    let v1619 : string =
        match v1615 with
        | US1_1 -> (* None *)
            failwith<string> "Option does not have a value."
        | US1_0(v1616) -> (* Some *)
            v1616
    method30(v1619, v1)
and method50 (v0 : string) : unit =
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
    let v2 : string = method33()
    let v3 : System.DateTime = System.DateTime.Now
    let v6 : (unit -> System.Guid) = System.Guid.NewGuid
    let v7 : System.Guid = v6 ()
    let v10 : System.Guid = method23(v7, v3)
    let v11 : string = $"{v2}_{v10}.txt"
    let v12 : string = __SOURCE_DIRECTORY__
    let v13 : string = "polyglot"
    let v14 : string = ".devcontainer"
    let v15 : string = method30(v13, v14)
    let v16 : US13 = method45(v15, v12)
    let v818 : US1 =
        match v16 with
        | US13_1(v19) -> (* Error *)
            let v20 : unit = ()
            let v21 : (unit -> unit) = closure52(v19)
            let v22 : unit = (fun () -> v21 (); v20) ()
            US1_1
        | US13_0(v17) -> (* Ok *)
            US1_0(v17)
    let v1627 : US1 =
        match v818 with
        | US1_1 -> (* None *)
            let v821 : string = method49()
            let v822 : string = method30(v13, v14)
            let v823 : US13 = method45(v822, v821)
            match v823 with
            | US13_1(v826) -> (* Error *)
                let v827 : unit = ()
                let v828 : (unit -> unit) = closure52(v826)
                let v829 : unit = (fun () -> v828 (); v827) ()
                US1_1
            | US13_0(v824) -> (* Ok *)
                US1_0(v824)
        | US1_0(v819) -> (* Some *)
            US1_0(v819)
    let v1631 : string =
        match v1627 with
        | US1_1 -> (* None *)
            failwith<string> "Option does not have a value."
        | US1_0(v1628) -> (* Some *)
            v1628
    let v1632 : string = method30(v1631, v13)
    let v1633 : string = "target/trace"
    let v1634 : string = method30(v1632, v1633)
    let v1635 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1636 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    let _v1635 = v1636 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1639 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    let _v1635 = v1639 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1642 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    let _v1635 = v1642 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1645 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    let _v1635 = v1645 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1648 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    let _v1635 = v1648 
    #endif
#else
    let v1651 : (string -> System.IO.DirectoryInfo) = System.IO.Directory.CreateDirectory
    let v1652 : System.IO.DirectoryInfo = v1651 v1634
    let _v1635 = v1652 
    #endif
    let v1653 : System.IO.DirectoryInfo = _v1635 
    let v1658 : string = method30(v1634, v11)
    let v1659 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1660 : Async<unit> = null |> unbox<Async<unit>>
    let _v1659 = v1660 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1663 : Async<unit> = null |> unbox<Async<unit>>
    let _v1659 = v1663 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1666 : Async<unit> = null |> unbox<Async<unit>>
    let _v1659 = v1666 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1669 : Async<unit> = null |> unbox<Async<unit>>
    let _v1659 = v1669 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1672 : Async<unit> = null |> unbox<Async<unit>>
    let _v1659 = v1672 
    #endif
#else
    let v1675 : System.Threading.Tasks.Task = System.IO.File.WriteAllTextAsync (v1658, v0)
    let v1676 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1677 : Async<unit> = null |> unbox<Async<unit>>
    let _v1676 = v1677 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1680 : Async<unit> = null |> unbox<Async<unit>>
    let _v1676 = v1680 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1683 : Async<unit> = null |> unbox<Async<unit>>
    let _v1676 = v1683 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1686 : Async<unit> = null |> unbox<Async<unit>>
    let _v1676 = v1686 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1689 : Async<unit> = null |> unbox<Async<unit>>
    let _v1676 = v1689 
    #endif
#else
    let v1692 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
    let v1693 : Async<unit> = v1692 v1675
    let _v1676 = v1693 
    #endif
    let v1694 : Async<unit> = _v1676 
    let _v1659 = v1694 
    #endif
    let v1699 : Async<unit> = _v1659 
    let v1704 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    null |> unbox<unit>
    let _v1704 = () 
    #endif
#if FABLE_COMPILER_RUST && WASM
    null |> unbox<unit>
    let _v1704 = () 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    null |> unbox<unit>
    let _v1704 = () 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    null |> unbox<unit>
    let _v1704 = () 
    #endif
#if FABLE_COMPILER_PYTHON
    null |> unbox<unit>
    let _v1704 = () 
    #endif
#else
    let v1705 : (Async<unit> -> unit) = Async.RunSynchronously
    v1705 v1699
    let _v1704 = () 
    #endif
    _v1704 
    with ex ->
    let v1706 : exn = ex
    let v1707 : string = $"file_system.trace_file / ex: %A{v1706}"
    method50(v1707)
    (*
    *)
    let _v1 = () 
    #endif
    _v1 
    ()
and closure54 () (v0 : string) : unit =
    method50(v0)
and closure53 () (v0 : bool) : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure0()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v17 : Mut0, v18 : Mut1, v19 : Mut2, v20 : Mut3, v21 : Mut4, v22 : int64 option) = TraceState.trace_state.Value
    let v37 : (string -> unit) =
        if v0 then
            closure54()
        else
            closure3()
    v18.l0 <- v37
    ()
and method52 (v0 : string) : string =
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
and method51 (v0 : string, v1 : string) : unit =
    let v2 : bool = method8(v0)
    let v3 : bool = v2 = false
    if v3 then
        let v4 : System.IDisposable = method35(v0)
        ()
    let v5 : string = method52(v1)
    let v6 : bool = method8(v5)
    let v7 : bool = v6 = false
    if v7 then
        let v8 : System.IDisposable = method35(v5)
        ()
    let v9 : bool = method8(v1)
    let v32 : bool =
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
            let v17 : Result<std_path_PathBuf, std_io_Error> = Unchecked.defaultof<_>
            let _v10 = v17 
            #endif
#if FABLE_COMPILER_PYTHON
            let v18 : Result<std_path_PathBuf, std_io_Error> = Unchecked.defaultof<_>
            let _v10 = v18 
            #endif
#else
            let v19 : Result<std_path_PathBuf, std_io_Error> = Unchecked.defaultof<_>
            let _v10 = v19 
            #endif
            let v20 : Result<std_path_PathBuf, std_io_Error> = _v10 
            let v23 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v24 : string = "$0.is_err()"
            let v25 : bool = Fable.Core.RustInterop.emitRustExpr v20 v24 
            let _v23 = v25 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v26 : string = "$0.is_err()"
            let v27 : bool = Fable.Core.RustInterop.emitRustExpr v20 v26 
            let _v23 = v27 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v28 : string = "$0.is_err()"
            let v29 : bool = Fable.Core.RustInterop.emitRustExpr v20 v28 
            let _v23 = v29 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let _v23 = true 
            #endif
#if FABLE_COMPILER_PYTHON
            let _v23 = true 
            #endif
#else
            let _v23 = true 
            #endif
            let v30 : bool = _v23 
            v30
        else
            false
    if v32 then
        let v33 : bool = true
        method6(v33, v1)
    let v34 : bool = method8(v1)
    let v35 : bool = v34 = false
    if v35 then
        let v36 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v37 : bool = true
        let mutable _v37 : unit option = None 
        
#if _FREEBSD
        let v38 : string = "std::os::unix::fs::symlink(&*$0, &*$1).unwrap()"
        Fable.Core.RustInterop.emitRustExpr struct (v0, v1) v38 
        () 
        #endif
#if _LINUX
        let v39 : string = "std::os::unix::fs::symlink(&*$0, &*$1).unwrap()"
        Fable.Core.RustInterop.emitRustExpr struct (v0, v1) v39 
        () 
        #endif
#if _OSX
        let v40 : string = "std::os::unix::fs::symlink(&*$0, &*$1).unwrap()"
        Fable.Core.RustInterop.emitRustExpr struct (v0, v1) v40 
        () 
        #endif
#if _WINDOWS
        let v41 : string = "std::os::windows::fs::symlink_dir(&*$0, &*$1).unwrap()"
        Fable.Core.RustInterop.emitRustExpr struct (v0, v1) v41 
        () 
        #endif
        |> fun x -> _v37 <- Some x
        match _v37 with Some x -> x | None -> failwith "runtime.run_platform / _v37=None"
        let _v36 = () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let _v36 = () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let _v36 = () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let _v36 = () 
        #endif
#if FABLE_COMPILER_PYTHON
        let _v36 = () 
        #endif
#else
        let v42 : System.IO.FileSystemInfo = System.IO.Directory.CreateSymbolicLink (v1, v0)
        let _v36 = () 
        #endif
        _v36 
        ()
and closure56 (v0 : string) (v1 : string) : unit =
    method51(v0, v1)
and closure55 () (v0 : string) : (string -> unit) =
    closure56(v0)
and closure58 (v0 : string) (v1 : string) : string =
    method30(v0, v1)
and closure57 () (v0 : string) : (string -> string) =
    closure58(v0)
let v0 : unit = ()
let v1 : (unit -> unit) = closure0()
let v2 : unit = (fun () -> v1 (); v0) ()
let v16 : (string -> Async<int64>) = closure4()
let delete_directory_async x = v16 x
let v17 : (US6 -> (string -> Async<int64>)) = closure12()
let wait_for_file_access x = v17 x
let v18 : (string -> Async<int64>) = closure15()
let wait_for_file_access_read x = v18 x
let v19 : (string -> Async<string>) = closure16()
let read_all_text_async x = v19 x
let v20 : (string -> (string -> bool)) = closure17()
let file_exists_content x = v20 x
let v21 : (string -> (string -> Async<unit>)) = closure19()
let write_all_text_async x = v21 x
let v22 : (string -> (string -> Async<unit>)) = closure21()
let write_all_text_exists x = v22 x
let v23 : (string -> Async<int64>) = closure23()
let delete_file_async x = v23 x
let v24 : (string -> (string -> Async<int64>)) = closure25()
let move_file_async x = v24 x
let v25 : (string -> Async<string option>) = closure28()
let read_all_text_retry_async x = v25 x
let v26 : (unit -> string) = closure34()
let create_temp_path () = v26 ()
let v27 : (unit -> struct (string * System.IDisposable)) = closure37()
let create_temp_dir () = v27 ()
let v28 : (string -> struct (string * System.IDisposable)) = closure46()
let create_temp_dir' x = v28 x
let v29 : (unit -> string) = closure47()
let get_source_directory () = v29 ()
let v30 : (string -> string) = closure48()
let normalize_path x = v30 x
let v31 : (string -> string) = closure49()
let new_file_uri x = v31 x
let v32 : (unit -> string) = closure50()
let get_workspace_root () = v32 ()
let v33 : (bool -> unit) = closure53()
let init_trace_file x = v33 x
let v34 : (string -> (string -> unit)) = closure55()
let link_directory x = v34 x
let v35 : (string -> (string -> string)) = closure57()
let (</>) x = v35 x
()
