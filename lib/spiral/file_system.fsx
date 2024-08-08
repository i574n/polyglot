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
module State = let mutable trace_state = None
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
type [<Struct>] US0 =
    | US0_0
    | US0_1
    | US0_2
    | US0_3
    | US0_4
and Mut0 = {mutable l0 : int64}
and Mut1 = {mutable l0 : (string -> unit)}
and Mut2 = {mutable l0 : bool}
and Mut3 = {mutable l0 : US0}
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
and Mut4 = {mutable l0 : string}
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
and method2 (v0 : string) : string =
    let v1 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = "std::env::var(&*$0)"
    let v3 : Result<std_string_String, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr v0 v2 
    let v4 : string = "true; let _result = $0.map(|x| { //"
    let v5 : bool = Fable.Core.RustInterop.emitRustExpr v3 v4 
    let v6 : string = "x"
    let v7 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v6 
    let v8 : string = "fable_library_rust::String_::fromString($0)"
    let v9 : string = Fable.Core.RustInterop.emitRustExpr v7 v8 
    let v10 : string = "true; $0 })"
    let v11 : bool = Fable.Core.RustInterop.emitRustExpr v9 v10 
    let v12 : string = "_result"
    let v13 : Result<string, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr () v12 
    let v14 : string = method3()
    let v15 : string = "$0.unwrap_or($1)"
    let v16 : string = Fable.Core.RustInterop.emitRustExpr struct (v13, v14) v15 
    let _v1 = v16 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v17 : string = "std::env::var(&*$0)"
    let v18 : Result<std_string_String, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr v0 v17 
    let v19 : string = "true; let _result = $0.map(|x| { //"
    let v20 : bool = Fable.Core.RustInterop.emitRustExpr v18 v19 
    let v21 : string = "x"
    let v22 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v21 
    let v23 : string = "fable_library_rust::String_::fromString($0)"
    let v24 : string = Fable.Core.RustInterop.emitRustExpr v22 v23 
    let v25 : string = "true; $0 })"
    let v26 : bool = Fable.Core.RustInterop.emitRustExpr v24 v25 
    let v27 : string = "_result"
    let v28 : Result<string, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr () v27 
    let v29 : string = method3()
    let v30 : string = "$0.unwrap_or($1)"
    let v31 : string = Fable.Core.RustInterop.emitRustExpr struct (v28, v29) v30 
    let _v1 = v31 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v32 : string = "std::env::var(&*$0)"
    let v33 : Result<std_string_String, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr v0 v32 
    let v34 : string = "true; let _result = $0.map(|x| { //"
    let v35 : bool = Fable.Core.RustInterop.emitRustExpr v33 v34 
    let v36 : string = "x"
    let v37 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v36 
    let v38 : string = "fable_library_rust::String_::fromString($0)"
    let v39 : string = Fable.Core.RustInterop.emitRustExpr v37 v38 
    let v40 : string = "true; $0 })"
    let v41 : bool = Fable.Core.RustInterop.emitRustExpr v39 v40 
    let v42 : string = "_result"
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
    match v61 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v65 : string = x
    let v66 : US1 = US1_0(v65)
    v66 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v64.Value <- x
    let v67 : US1 option = _v64.Value 
    let v78 : US1 = US1_1
    let v79 : US1 = v67 |> Option.defaultValue v78 
    let v86 : string =
        match v79 with
        | US1_1 -> (* None *)
            let v84 : string = ""
            v84
        | US1_0(v83) -> (* Some *)
            v83
    let _v1 = v86 
    #endif
#else
    let v87 : (string -> string) = System.Environment.GetEnvironmentVariable
    let v88 : string = v87 v0
    let mutable _v88 = None
    #if !FABLE_COMPILER && !WASM && !CONTRACT
    let v89 : (string -> string option) = Option.ofObj
    let v90 : string option = v89 v88
    v90 
    #else
    Some v88 
    #endif
    |> fun x -> _v88 <- Some x
    let v91 : string option = match _v88 with Some x -> x | None -> failwith "optionm'.of_obj / _v88=None"
    let v94 : US1 option = None
    let _v94 = ref v94 
    match v91 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v95 : string = x
    let v96 : US1 = US1_0(v95)
    v96 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v94.Value <- x
    let v97 : US1 option = _v94.Value 
    let v108 : US1 = US1_1
    let v109 : US1 = v97 |> Option.defaultValue v108 
    let v116 : string =
        match v109 with
        | US1_1 -> (* None *)
            let v114 : string = ""
            v114
        | US1_0(v113) -> (* Some *)
            v113
    let _v1 = v116 
    #endif
    let v117 : string = _v1 
    v117
and method4 () : string =
    let v0 : string = "AUTOMATION"
    v0
and closure0 () (v0 : string) : unit =
    ()
and method0 (v0 : US0) : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) =
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
    let v359 : Mut2 = {l0 = true} : Mut2
    let v360 : Mut0 = {l0 = 0L} : Mut0
    let v363 : US0 =
        match v294 with
        | US2_1 -> (* None *)
            v0
        | US2_0(v361) -> (* Some *)
            v361
    let v364 : Mut3 = {l0 = v363} : Mut3
    let v365 : (string -> unit) = closure0()
    let v366 : Mut1 = {l0 = v365} : Mut1
    let v373 : int64 option =
        match v295 with
        | US3_1 -> (* None *)
            let v371 : int64 option = None
            v371
        | US3_0(v367) -> (* Some *)
            let v368 : int64 option = Some v367 
            v368
    struct (v360, v366, v359, v364, v373)
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
and closure2 () () : string =
    let v0 : string = "file_system.delete_directory_async"
    v0
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
        let v45 : bool = State.trace_state.IsNone
        if v45 then
            let v46 : US0 = US0_0
            let struct (v47 : Mut0, v48 : Mut1, v49 : Mut2, v50 : Mut3, v51 : int64 option) = method0(v46)
            let v52 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v47, v48, v49, v50, v51) 
            State.trace_state <- v52 
            ()
        let struct (v57 : Mut0, v58 : Mut1, v59 : Mut2, v60 : Mut3, v61 : int64 option) = State.trace_state.Value
        let v72 : bool = State.trace_state.IsNone
        if v72 then
            let v73 : US0 = US0_0
            let struct (v74 : Mut0, v75 : Mut1, v76 : Mut2, v77 : Mut3, v78 : int64 option) = method0(v73)
            let v79 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v74, v75, v76, v77, v78) 
            State.trace_state <- v79 
            ()
        let struct (v84 : Mut0, v85 : Mut1, v86 : Mut2, v87 : Mut3, v88 : int64 option) = State.trace_state.Value
        let v99 : US0 = v87.l0
        let v100 : bool = v86.l0
        let v101 : bool = v100 = false
        let v104 : bool =
            if v101 then
                false
            else
                let v102 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v99
                let v103 : bool = 1 >= v102
                v103
        if v104 then
            let v105 : int64 = v57.l0
            let v106 : int64 = v105 + 1L
            v57.l0 <- v106
            let v107 : bool = State.trace_state.IsNone
            if v107 then
                let v108 : US0 = US0_0
                let struct (v109 : Mut0, v110 : Mut1, v111 : Mut2, v112 : Mut3, v113 : int64 option) = method0(v108)
                let v114 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v109, v110, v111, v112, v113) 
                State.trace_state <- v114 
                ()
            let struct (v119 : Mut0, v120 : Mut1, v121 : Mut2, v122 : Mut3, v123 : int64 option) = State.trace_state.Value
            let v134 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v135 : US3 option = None
            let _v135 = ref v135 
            match v123 with
            | Some x -> (
            (fun () ->
            (fun () ->
            let v136 : int64 = x
            let v137 : US3 = US3_0(v136)
            v137 
            )
            |> fun x -> x () |> Some
            ) () ) | None -> None
            |> fun x -> _v135.Value <- x
            let v138 : US3 option = _v135.Value 
            let v149 : US3 = US3_1
            let v150 : US3 = v138 |> Option.defaultValue v149 
            let v190 : System.DateTime =
                match v150 with
                | US3_1 -> (* None *)
                    let v186 : System.DateTime = System.DateTime.Now
                    v186
                | US3_0(v154) -> (* Some *)
                    let v155 : System.DateTime = System.DateTime.Now
                    let v158 : (System.DateTime -> int64) = _.Ticks
                    let v159 : int64 = v158 v155
                    let v162 : int64 = v159 - v154
                    let v163 : (int64 -> System.TimeSpan) = System.TimeSpan 
                    let v164 : System.TimeSpan = v163 v162
                    let v167 : (System.TimeSpan -> int32) = _.Hours
                    let v168 : int32 = v167 v164
                    let v171 : (System.TimeSpan -> int32) = _.Minutes
                    let v172 : int32 = v171 v164
                    let v175 : (System.TimeSpan -> int32) = _.Seconds
                    let v176 : int32 = v175 v164
                    let v179 : (System.TimeSpan -> int32) = _.Milliseconds
                    let v180 : int32 = v179 v164
                    let v183 : System.DateTime = System.DateTime (1, 1, 1, v168, v172, v176, v180)
                    v183
            let v191 : string = method9()
            let v194 : (string -> string) = v190.ToString
            let v195 : string = v194 v191
            let _v134 = v195 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v198 : US3 option = None
            let _v198 = ref v198 
            match v123 with
            | Some x -> (
            (fun () ->
            (fun () ->
            let v199 : int64 = x
            let v200 : US3 = US3_0(v199)
            v200 
            )
            |> fun x -> x () |> Some
            ) () ) | None -> None
            |> fun x -> _v198.Value <- x
            let v201 : US3 option = _v198.Value 
            let v212 : US3 = US3_1
            let v213 : US3 = v201 |> Option.defaultValue v212 
            let v253 : System.DateTime =
                match v213 with
                | US3_1 -> (* None *)
                    let v249 : System.DateTime = System.DateTime.Now
                    v249
                | US3_0(v217) -> (* Some *)
                    let v218 : System.DateTime = System.DateTime.Now
                    let v221 : (System.DateTime -> int64) = _.Ticks
                    let v222 : int64 = v221 v218
                    let v225 : int64 = v222 - v217
                    let v226 : (int64 -> System.TimeSpan) = System.TimeSpan 
                    let v227 : System.TimeSpan = v226 v225
                    let v230 : (System.TimeSpan -> int32) = _.Hours
                    let v231 : int32 = v230 v227
                    let v234 : (System.TimeSpan -> int32) = _.Minutes
                    let v235 : int32 = v234 v227
                    let v238 : (System.TimeSpan -> int32) = _.Seconds
                    let v239 : int32 = v238 v227
                    let v242 : (System.TimeSpan -> int32) = _.Milliseconds
                    let v243 : int32 = v242 v227
                    let v246 : System.DateTime = System.DateTime (1, 1, 1, v231, v235, v239, v243)
                    v246
            let v254 : string = method9()
            let v257 : (string -> string) = v253.ToString
            let v258 : string = v257 v254
            let _v134 = v258 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v261 : string = $"near_sdk::env::block_timestamp()"
            let v262 : uint64 = Fable.Core.RustInterop.emitRustExpr () v261 
            let v263 : US3 option = None
            let _v263 = ref v263 
            match v123 with
            | Some x -> (
            (fun () ->
            (fun () ->
            let v264 : int64 = x
            let v265 : US3 = US3_0(v264)
            v265 
            )
            |> fun x -> x () |> Some
            ) () ) | None -> None
            |> fun x -> _v263.Value <- x
            let v266 : US3 option = _v263.Value 
            let v277 : US3 = US3_1
            let v278 : US3 = v266 |> Option.defaultValue v277 
            let v287 : uint64 =
                match v278 with
                | US3_1 -> (* None *)
                    v262
                | US3_0(v282) -> (* Some *)
                    let v283 : (int64 -> uint64) = uint64
                    let v284 : uint64 = v283 v282
                    let v285 : uint64 = v262 - v284
                    v285
            let v288 : uint64 = v287 / 1000000000UL
            let v289 : uint64 = v288 % 60UL
            let v290 : uint64 = v288 / 60UL
            let v291 : uint64 = v290 % 60UL
            let v292 : uint64 = v288 / 3600UL
            let v293 : uint64 = v292 % 24UL
            let v294 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
            let v295 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v293, v291, v289) v294 
            let v296 : string = "fable_library_rust::String_::fromString($0)"
            let v297 : string = Fable.Core.RustInterop.emitRustExpr v295 v296 
            let _v134 = v297 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v298 : US3 option = None
            let _v298 = ref v298 
            match v123 with
            | Some x -> (
            (fun () ->
            (fun () ->
            let v299 : int64 = x
            let v300 : US3 = US3_0(v299)
            v300 
            )
            |> fun x -> x () |> Some
            ) () ) | None -> None
            |> fun x -> _v298.Value <- x
            let v301 : US3 option = _v298.Value 
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
            let _v134 = v358 
            #endif
#if FABLE_COMPILER_PYTHON
            let v361 : US3 option = None
            let _v361 = ref v361 
            match v123 with
            | Some x -> (
            (fun () ->
            (fun () ->
            let v362 : int64 = x
            let v363 : US3 = US3_0(v362)
            v363 
            )
            |> fun x -> x () |> Some
            ) () ) | None -> None
            |> fun x -> _v361.Value <- x
            let v364 : US3 option = _v361.Value 
            let v375 : US3 = US3_1
            let v376 : US3 = v364 |> Option.defaultValue v375 
            let v416 : System.DateTime =
                match v376 with
                | US3_1 -> (* None *)
                    let v412 : System.DateTime = System.DateTime.Now
                    v412
                | US3_0(v380) -> (* Some *)
                    let v381 : System.DateTime = System.DateTime.Now
                    let v384 : (System.DateTime -> int64) = _.Ticks
                    let v385 : int64 = v384 v381
                    let v388 : int64 = v385 - v380
                    let v389 : (int64 -> System.TimeSpan) = System.TimeSpan 
                    let v390 : System.TimeSpan = v389 v388
                    let v393 : (System.TimeSpan -> int32) = _.Hours
                    let v394 : int32 = v393 v390
                    let v397 : (System.TimeSpan -> int32) = _.Minutes
                    let v398 : int32 = v397 v390
                    let v401 : (System.TimeSpan -> int32) = _.Seconds
                    let v402 : int32 = v401 v390
                    let v405 : (System.TimeSpan -> int32) = _.Milliseconds
                    let v406 : int32 = v405 v390
                    let v409 : System.DateTime = System.DateTime (1, 1, 1, v394, v398, v402, v406)
                    v409
            let v417 : string = method10()
            let v420 : (string -> string) = v416.ToString
            let v421 : string = v420 v417
            let _v134 = v421 
            #endif
#else
            let v424 : US3 option = None
            let _v424 = ref v424 
            match v123 with
            | Some x -> (
            (fun () ->
            (fun () ->
            let v425 : int64 = x
            let v426 : US3 = US3_0(v425)
            v426 
            )
            |> fun x -> x () |> Some
            ) () ) | None -> None
            |> fun x -> _v424.Value <- x
            let v427 : US3 option = _v424.Value 
            let v438 : US3 = US3_1
            let v439 : US3 = v427 |> Option.defaultValue v438 
            let v479 : System.DateTime =
                match v439 with
                | US3_1 -> (* None *)
                    let v475 : System.DateTime = System.DateTime.Now
                    v475
                | US3_0(v443) -> (* Some *)
                    let v444 : System.DateTime = System.DateTime.Now
                    let v447 : (System.DateTime -> int64) = _.Ticks
                    let v448 : int64 = v447 v444
                    let v451 : int64 = v448 - v443
                    let v452 : (int64 -> System.TimeSpan) = System.TimeSpan 
                    let v453 : System.TimeSpan = v452 v451
                    let v456 : (System.TimeSpan -> int32) = _.Hours
                    let v457 : int32 = v456 v453
                    let v460 : (System.TimeSpan -> int32) = _.Minutes
                    let v461 : int32 = v460 v453
                    let v464 : (System.TimeSpan -> int32) = _.Seconds
                    let v465 : int32 = v464 v453
                    let v468 : (System.TimeSpan -> int32) = _.Milliseconds
                    let v469 : int32 = v468 v453
                    let v472 : System.DateTime = System.DateTime (1, 1, 1, v457, v461, v465, v469)
                    v472
            let v480 : string = method10()
            let v483 : (string -> string) = v479.ToString
            let v484 : string = v483 v480
            let _v134 = v484 
            #endif
            let v487 : string = _v134 
            let v552 : string = "Debug"
            let v553 : (unit -> string) = v552.ToLower
            let v554 : string = v553 ()
            let v557 : string = v554.PadLeft (7, ' ')
            let v571 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v572 : string = "inline_colorization::color_bright_blue"
            let v573 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v572 
            let v574 : string = "&*$0"
            let v575 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v557 v574 
            let v576 : string = "inline_colorization::color_reset"
            let v577 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v576 
            let v578 : string = "\"{v573}{v575}{v577}\""
            let v579 : string = @$"format!(" + v578 + ")"
            let v580 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v579 
            let v581 : string = "fable_library_rust::String_::fromString($0)"
            let v582 : string = Fable.Core.RustInterop.emitRustExpr v580 v581 
            let _v571 = v582 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v583 : string = "inline_colorization::color_bright_blue"
            let v584 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v583 
            let v585 : string = "&*$0"
            let v586 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v557 v585 
            let v587 : string = "inline_colorization::color_reset"
            let v588 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v587 
            let v589 : string = "\"{v584}{v586}{v588}\""
            let v590 : string = @$"format!(" + v589 + ")"
            let v591 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v590 
            let v592 : string = "fable_library_rust::String_::fromString($0)"
            let v593 : string = Fable.Core.RustInterop.emitRustExpr v591 v592 
            let _v571 = v593 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v594 : string = "inline_colorization::color_bright_blue"
            let v595 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v594 
            let v596 : string = "&*$0"
            let v597 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v557 v596 
            let v598 : string = "inline_colorization::color_reset"
            let v599 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v598 
            let v600 : string = "\"{v595}{v597}{v599}\""
            let v601 : string = @$"format!(" + v600 + ")"
            let v602 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v601 
            let v603 : string = "fable_library_rust::String_::fromString($0)"
            let v604 : string = Fable.Core.RustInterop.emitRustExpr v602 v603 
            let _v571 = v604 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v605 : string = "\u001b[94m"
            let v606 : string = method11()
            let v607 : string = v605 + v557 
            let v608 : string = v607 + v606 
            let _v571 = v608 
            #endif
#if FABLE_COMPILER_PYTHON
            let v609 : string = "\u001b[94m"
            let v610 : string = method11()
            let v611 : string = v609 + v557 
            let v612 : string = v611 + v610 
            let _v571 = v612 
            #endif
#else
            let v613 : string = "\u001b[94m"
            let v614 : string = method11()
            let v615 : string = v613 + v557 
            let v616 : string = v615 + v614 
            let _v571 = v616 
            #endif
            let v617 : string = _v571 
            let v623 : int64 = v119.l0
            let v624 : string = method12(v0)
            let v625 : string = method13()
            let v626 : Mut4 = {l0 = v625} : Mut4
            let v627 : string = "{ "
            let v628 : string = $"{v627}"
            let v631 : string = v626.l0
            let v632 : string = v631 + v628 
            v626.l0 <- v632
            let v633 : string = "ex"
            let v634 : string = $"{v633}"
            let v637 : string = v626.l0
            let v638 : string = v637 + v634 
            v626.l0 <- v638
            let v639 : string = " = "
            let v640 : string = $"{v639}"
            let v643 : string = v626.l0
            let v644 : string = v643 + v640 
            v626.l0 <- v644
            let v645 : string = $"{v40}"
            let v648 : string = v626.l0
            let v649 : string = v648 + v645 
            v626.l0 <- v649
            let v650 : string = "; "
            let v651 : string = $"{v650}"
            let v654 : string = v626.l0
            let v655 : string = v654 + v651 
            v626.l0 <- v655
            let v656 : string = "path"
            let v657 : string = $"{v656}"
            let v660 : string = v626.l0
            let v661 : string = v660 + v657 
            v626.l0 <- v661
            let v662 : string = $"{v639}"
            let v665 : string = v626.l0
            let v666 : string = v665 + v662 
            v626.l0 <- v666
            let v667 : string = $"{v624}"
            let v670 : string = v626.l0
            let v671 : string = v670 + v667 
            v626.l0 <- v671
            let v672 : string = " }"
            let v673 : string = $"{v672}"
            let v676 : string = v626.l0
            let v677 : string = v676 + v673 
            v626.l0 <- v677
            let v678 : string = v626.l0
            let v679 : (unit -> string) = closure2()
            let v680 : string = $"{v487} {v617} #{v623} %s{v679 ()} / {v678}"
            let v683 : char list = []
            let v684 : (char list -> (char [])) = List.toArray
            let v685 : (char []) = v684 v683
            let v688 : string = v680.TrimStart v685 
            let v706 : char list = []
            let v707 : char list = '/' :: v706 
            let v710 : char list = ' ' :: v707 
            let v713 : (char list -> (char [])) = List.toArray
            let v714 : (char []) = v713 v710
            let v717 : string = v688.TrimEnd v714 
            let v735 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v736 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v717 v736 
            let _v735 = () 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v737 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v717 v737 
            let _v735 = () 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v738 : string = $"near_sdk::log!(\"{{}}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v717 v738 
            let _v735 = () 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            System.Console.WriteLine v717 
            let _v735 = () 
            #endif
#if FABLE_COMPILER_PYTHON
            System.Console.WriteLine v717 
            let _v735 = () 
            #endif
#else
            System.Console.WriteLine v717 
            let _v735 = () 
            #endif
            _v735 
            let v739 : (string -> unit) = v58.l0
            v739 v717
    let v740 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v741 : Async<unit> = null |> unbox<Async<unit>>
    let _v740 = v741 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v744 : Async<unit> = null |> unbox<Async<unit>>
    let _v740 = v744 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v747 : Async<unit> = null |> unbox<Async<unit>>
    let _v740 = v747 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v750 : Async<unit> = null |> unbox<Async<unit>>
    let _v740 = v750 
    #endif
#if FABLE_COMPILER_PYTHON
    let v753 : Async<unit> = null |> unbox<Async<unit>>
    let _v740 = v753 
    #endif
#else
    let v756 : (int32 -> Async<unit>) = Async.Sleep
    let v757 : Async<unit> = v756 10
    let _v740 = v757 
    #endif
    let v758 : Async<unit> = _v740 
    do! v758 
    let v763 : int64 = v1 + 1L
    let v764 : Async<int64> = method5(v0, v763)
    return! v764 
    (*
    let v765 : int64 = *)
    }
    |> fun x -> _v18 <- Some x
    let v766 : Async<int64> = match _v18 with Some x -> x | None -> failwith "async.new_async_unit / _v18=None"
    let _v2 = v766 
    #endif
    let v767 : Async<int64> = _v2 
    v767
and closure1 () (v0 : string) : Async<int64> =
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
and closure5 () () : string =
    let v0 : string = "file_system.wait_for_file_access"
    v0
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
        let v88 : bool = State.trace_state.IsNone
        if v88 then
            let v89 : US0 = US0_0
            let struct (v90 : Mut0, v91 : Mut1, v92 : Mut2, v93 : Mut3, v94 : int64 option) = method0(v89)
            let v95 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v90, v91, v92, v93, v94) 
            State.trace_state <- v95 
            ()
        let struct (v100 : Mut0, v101 : Mut1, v102 : Mut2, v103 : Mut3, v104 : int64 option) = State.trace_state.Value
        let v115 : bool = State.trace_state.IsNone
        if v115 then
            let v116 : US0 = US0_0
            let struct (v117 : Mut0, v118 : Mut1, v119 : Mut2, v120 : Mut3, v121 : int64 option) = method0(v116)
            let v122 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v117, v118, v119, v120, v121) 
            State.trace_state <- v122 
            ()
        let struct (v127 : Mut0, v128 : Mut1, v129 : Mut2, v130 : Mut3, v131 : int64 option) = State.trace_state.Value
        let v142 : US0 = v130.l0
        let v143 : bool = v129.l0
        let v144 : bool = v143 = false
        let v147 : bool =
            if v144 then
                false
            else
                let v145 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v142
                let v146 : bool = 1 >= v145
                v146
        if v147 then
            let v148 : int64 = v100.l0
            let v149 : int64 = v148 + 1L
            v100.l0 <- v149
            let v150 : bool = State.trace_state.IsNone
            if v150 then
                let v151 : US0 = US0_0
                let struct (v152 : Mut0, v153 : Mut1, v154 : Mut2, v155 : Mut3, v156 : int64 option) = method0(v151)
                let v157 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v152, v153, v154, v155, v156) 
                State.trace_state <- v157 
                ()
            let struct (v162 : Mut0, v163 : Mut1, v164 : Mut2, v165 : Mut3, v166 : int64 option) = State.trace_state.Value
            let v177 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v178 : US3 option = None
            let _v178 = ref v178 
            match v166 with
            | Some x -> (
            (fun () ->
            (fun () ->
            let v179 : int64 = x
            let v180 : US3 = US3_0(v179)
            v180 
            )
            |> fun x -> x () |> Some
            ) () ) | None -> None
            |> fun x -> _v178.Value <- x
            let v181 : US3 option = _v178.Value 
            let v192 : US3 = US3_1
            let v193 : US3 = v181 |> Option.defaultValue v192 
            let v233 : System.DateTime =
                match v193 with
                | US3_1 -> (* None *)
                    let v229 : System.DateTime = System.DateTime.Now
                    v229
                | US3_0(v197) -> (* Some *)
                    let v198 : System.DateTime = System.DateTime.Now
                    let v201 : (System.DateTime -> int64) = _.Ticks
                    let v202 : int64 = v201 v198
                    let v205 : int64 = v202 - v197
                    let v206 : (int64 -> System.TimeSpan) = System.TimeSpan 
                    let v207 : System.TimeSpan = v206 v205
                    let v210 : (System.TimeSpan -> int32) = _.Hours
                    let v211 : int32 = v210 v207
                    let v214 : (System.TimeSpan -> int32) = _.Minutes
                    let v215 : int32 = v214 v207
                    let v218 : (System.TimeSpan -> int32) = _.Seconds
                    let v219 : int32 = v218 v207
                    let v222 : (System.TimeSpan -> int32) = _.Milliseconds
                    let v223 : int32 = v222 v207
                    let v226 : System.DateTime = System.DateTime (1, 1, 1, v211, v215, v219, v223)
                    v226
            let v234 : string = method9()
            let v237 : (string -> string) = v233.ToString
            let v238 : string = v237 v234
            let _v177 = v238 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v241 : US3 option = None
            let _v241 = ref v241 
            match v166 with
            | Some x -> (
            (fun () ->
            (fun () ->
            let v242 : int64 = x
            let v243 : US3 = US3_0(v242)
            v243 
            )
            |> fun x -> x () |> Some
            ) () ) | None -> None
            |> fun x -> _v241.Value <- x
            let v244 : US3 option = _v241.Value 
            let v255 : US3 = US3_1
            let v256 : US3 = v244 |> Option.defaultValue v255 
            let v296 : System.DateTime =
                match v256 with
                | US3_1 -> (* None *)
                    let v292 : System.DateTime = System.DateTime.Now
                    v292
                | US3_0(v260) -> (* Some *)
                    let v261 : System.DateTime = System.DateTime.Now
                    let v264 : (System.DateTime -> int64) = _.Ticks
                    let v265 : int64 = v264 v261
                    let v268 : int64 = v265 - v260
                    let v269 : (int64 -> System.TimeSpan) = System.TimeSpan 
                    let v270 : System.TimeSpan = v269 v268
                    let v273 : (System.TimeSpan -> int32) = _.Hours
                    let v274 : int32 = v273 v270
                    let v277 : (System.TimeSpan -> int32) = _.Minutes
                    let v278 : int32 = v277 v270
                    let v281 : (System.TimeSpan -> int32) = _.Seconds
                    let v282 : int32 = v281 v270
                    let v285 : (System.TimeSpan -> int32) = _.Milliseconds
                    let v286 : int32 = v285 v270
                    let v289 : System.DateTime = System.DateTime (1, 1, 1, v274, v278, v282, v286)
                    v289
            let v297 : string = method9()
            let v300 : (string -> string) = v296.ToString
            let v301 : string = v300 v297
            let _v177 = v301 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v304 : string = $"near_sdk::env::block_timestamp()"
            let v305 : uint64 = Fable.Core.RustInterop.emitRustExpr () v304 
            let v306 : US3 option = None
            let _v306 = ref v306 
            match v166 with
            | Some x -> (
            (fun () ->
            (fun () ->
            let v307 : int64 = x
            let v308 : US3 = US3_0(v307)
            v308 
            )
            |> fun x -> x () |> Some
            ) () ) | None -> None
            |> fun x -> _v306.Value <- x
            let v309 : US3 option = _v306.Value 
            let v320 : US3 = US3_1
            let v321 : US3 = v309 |> Option.defaultValue v320 
            let v330 : uint64 =
                match v321 with
                | US3_1 -> (* None *)
                    v305
                | US3_0(v325) -> (* Some *)
                    let v326 : (int64 -> uint64) = uint64
                    let v327 : uint64 = v326 v325
                    let v328 : uint64 = v305 - v327
                    v328
            let v331 : uint64 = v330 / 1000000000UL
            let v332 : uint64 = v331 % 60UL
            let v333 : uint64 = v331 / 60UL
            let v334 : uint64 = v333 % 60UL
            let v335 : uint64 = v331 / 3600UL
            let v336 : uint64 = v335 % 24UL
            let v337 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
            let v338 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v336, v334, v332) v337 
            let v339 : string = "fable_library_rust::String_::fromString($0)"
            let v340 : string = Fable.Core.RustInterop.emitRustExpr v338 v339 
            let _v177 = v340 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v341 : US3 option = None
            let _v341 = ref v341 
            match v166 with
            | Some x -> (
            (fun () ->
            (fun () ->
            let v342 : int64 = x
            let v343 : US3 = US3_0(v342)
            v343 
            )
            |> fun x -> x () |> Some
            ) () ) | None -> None
            |> fun x -> _v341.Value <- x
            let v344 : US3 option = _v341.Value 
            let v355 : US3 = US3_1
            let v356 : US3 = v344 |> Option.defaultValue v355 
            let v396 : System.DateTime =
                match v356 with
                | US3_1 -> (* None *)
                    let v392 : System.DateTime = System.DateTime.Now
                    v392
                | US3_0(v360) -> (* Some *)
                    let v361 : System.DateTime = System.DateTime.Now
                    let v364 : (System.DateTime -> int64) = _.Ticks
                    let v365 : int64 = v364 v361
                    let v368 : int64 = v365 - v360
                    let v369 : (int64 -> System.TimeSpan) = System.TimeSpan 
                    let v370 : System.TimeSpan = v369 v368
                    let v373 : (System.TimeSpan -> int32) = _.Hours
                    let v374 : int32 = v373 v370
                    let v377 : (System.TimeSpan -> int32) = _.Minutes
                    let v378 : int32 = v377 v370
                    let v381 : (System.TimeSpan -> int32) = _.Seconds
                    let v382 : int32 = v381 v370
                    let v385 : (System.TimeSpan -> int32) = _.Milliseconds
                    let v386 : int32 = v385 v370
                    let v389 : System.DateTime = System.DateTime (1, 1, 1, v374, v378, v382, v386)
                    v389
            let v397 : string = method10()
            let v400 : (string -> string) = v396.ToString
            let v401 : string = v400 v397
            let _v177 = v401 
            #endif
#if FABLE_COMPILER_PYTHON
            let v404 : US3 option = None
            let _v404 = ref v404 
            match v166 with
            | Some x -> (
            (fun () ->
            (fun () ->
            let v405 : int64 = x
            let v406 : US3 = US3_0(v405)
            v406 
            )
            |> fun x -> x () |> Some
            ) () ) | None -> None
            |> fun x -> _v404.Value <- x
            let v407 : US3 option = _v404.Value 
            let v418 : US3 = US3_1
            let v419 : US3 = v407 |> Option.defaultValue v418 
            let v459 : System.DateTime =
                match v419 with
                | US3_1 -> (* None *)
                    let v455 : System.DateTime = System.DateTime.Now
                    v455
                | US3_0(v423) -> (* Some *)
                    let v424 : System.DateTime = System.DateTime.Now
                    let v427 : (System.DateTime -> int64) = _.Ticks
                    let v428 : int64 = v427 v424
                    let v431 : int64 = v428 - v423
                    let v432 : (int64 -> System.TimeSpan) = System.TimeSpan 
                    let v433 : System.TimeSpan = v432 v431
                    let v436 : (System.TimeSpan -> int32) = _.Hours
                    let v437 : int32 = v436 v433
                    let v440 : (System.TimeSpan -> int32) = _.Minutes
                    let v441 : int32 = v440 v433
                    let v444 : (System.TimeSpan -> int32) = _.Seconds
                    let v445 : int32 = v444 v433
                    let v448 : (System.TimeSpan -> int32) = _.Milliseconds
                    let v449 : int32 = v448 v433
                    let v452 : System.DateTime = System.DateTime (1, 1, 1, v437, v441, v445, v449)
                    v452
            let v460 : string = method10()
            let v463 : (string -> string) = v459.ToString
            let v464 : string = v463 v460
            let _v177 = v464 
            #endif
#else
            let v467 : US3 option = None
            let _v467 = ref v467 
            match v166 with
            | Some x -> (
            (fun () ->
            (fun () ->
            let v468 : int64 = x
            let v469 : US3 = US3_0(v468)
            v469 
            )
            |> fun x -> x () |> Some
            ) () ) | None -> None
            |> fun x -> _v467.Value <- x
            let v470 : US3 option = _v467.Value 
            let v481 : US3 = US3_1
            let v482 : US3 = v470 |> Option.defaultValue v481 
            let v522 : System.DateTime =
                match v482 with
                | US3_1 -> (* None *)
                    let v518 : System.DateTime = System.DateTime.Now
                    v518
                | US3_0(v486) -> (* Some *)
                    let v487 : System.DateTime = System.DateTime.Now
                    let v490 : (System.DateTime -> int64) = _.Ticks
                    let v491 : int64 = v490 v487
                    let v494 : int64 = v491 - v486
                    let v495 : (int64 -> System.TimeSpan) = System.TimeSpan 
                    let v496 : System.TimeSpan = v495 v494
                    let v499 : (System.TimeSpan -> int32) = _.Hours
                    let v500 : int32 = v499 v496
                    let v503 : (System.TimeSpan -> int32) = _.Minutes
                    let v504 : int32 = v503 v496
                    let v507 : (System.TimeSpan -> int32) = _.Seconds
                    let v508 : int32 = v507 v496
                    let v511 : (System.TimeSpan -> int32) = _.Milliseconds
                    let v512 : int32 = v511 v496
                    let v515 : System.DateTime = System.DateTime (1, 1, 1, v500, v504, v508, v512)
                    v515
            let v523 : string = method10()
            let v526 : (string -> string) = v522.ToString
            let v527 : string = v526 v523
            let _v177 = v527 
            #endif
            let v530 : string = _v177 
            let v595 : string = "Debug"
            let v596 : (unit -> string) = v595.ToLower
            let v597 : string = v596 ()
            let v600 : string = v597.PadLeft (7, ' ')
            let v614 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v615 : string = "inline_colorization::color_bright_blue"
            let v616 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v615 
            let v617 : string = "&*$0"
            let v618 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v600 v617 
            let v619 : string = "inline_colorization::color_reset"
            let v620 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v619 
            let v621 : string = "\"{v616}{v618}{v620}\""
            let v622 : string = @$"format!(" + v621 + ")"
            let v623 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v622 
            let v624 : string = "fable_library_rust::String_::fromString($0)"
            let v625 : string = Fable.Core.RustInterop.emitRustExpr v623 v624 
            let _v614 = v625 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v626 : string = "inline_colorization::color_bright_blue"
            let v627 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v626 
            let v628 : string = "&*$0"
            let v629 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v600 v628 
            let v630 : string = "inline_colorization::color_reset"
            let v631 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v630 
            let v632 : string = "\"{v627}{v629}{v631}\""
            let v633 : string = @$"format!(" + v632 + ")"
            let v634 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v633 
            let v635 : string = "fable_library_rust::String_::fromString($0)"
            let v636 : string = Fable.Core.RustInterop.emitRustExpr v634 v635 
            let _v614 = v636 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v637 : string = "inline_colorization::color_bright_blue"
            let v638 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v637 
            let v639 : string = "&*$0"
            let v640 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v600 v639 
            let v641 : string = "inline_colorization::color_reset"
            let v642 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v641 
            let v643 : string = "\"{v638}{v640}{v642}\""
            let v644 : string = @$"format!(" + v643 + ")"
            let v645 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v644 
            let v646 : string = "fable_library_rust::String_::fromString($0)"
            let v647 : string = Fable.Core.RustInterop.emitRustExpr v645 v646 
            let _v614 = v647 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v648 : string = "\u001b[94m"
            let v649 : string = method11()
            let v650 : string = v648 + v600 
            let v651 : string = v650 + v649 
            let _v614 = v651 
            #endif
#if FABLE_COMPILER_PYTHON
            let v652 : string = "\u001b[94m"
            let v653 : string = method11()
            let v654 : string = v652 + v600 
            let v655 : string = v654 + v653 
            let _v614 = v655 
            #endif
#else
            let v656 : string = "\u001b[94m"
            let v657 : string = method11()
            let v658 : string = v656 + v600 
            let v659 : string = v658 + v657 
            let _v614 = v659 
            #endif
            let v660 : string = _v614 
            let v666 : int64 = v162.l0
            let v667 : string = method12(v0)
            let v668 : string = method13()
            let v669 : Mut4 = {l0 = v668} : Mut4
            let v670 : string = "{ "
            let v671 : string = $"{v670}"
            let v674 : string = v669.l0
            let v675 : string = v674 + v671 
            v669.l0 <- v675
            let v676 : string = "path"
            let v677 : string = $"{v676}"
            let v680 : string = v669.l0
            let v681 : string = v680 + v677 
            v669.l0 <- v681
            let v682 : string = " = "
            let v683 : string = $"{v682}"
            let v686 : string = v669.l0
            let v687 : string = v686 + v683 
            v669.l0 <- v687
            let v688 : string = $"{v667}"
            let v691 : string = v669.l0
            let v692 : string = v691 + v688 
            v669.l0 <- v692
            let v693 : string = "; "
            let v694 : string = $"{v693}"
            let v697 : string = v669.l0
            let v698 : string = v697 + v694 
            v669.l0 <- v698
            let v699 : string = "retry"
            let v700 : string = $"{v699}"
            let v703 : string = v669.l0
            let v704 : string = v703 + v700 
            v669.l0 <- v704
            let v705 : string = $"{v682}"
            let v708 : string = v669.l0
            let v709 : string = v708 + v705 
            v669.l0 <- v709
            let v710 : string = $"{v3}"
            let v713 : string = v669.l0
            let v714 : string = v713 + v710 
            v669.l0 <- v714
            let v715 : string = $"{v693}"
            let v718 : string = v669.l0
            let v719 : string = v718 + v715 
            v669.l0 <- v719
            let v720 : string = "ex"
            let v721 : string = $"{v720}"
            let v724 : string = v669.l0
            let v725 : string = v724 + v721 
            v669.l0 <- v725
            let v726 : string = $"{v682}"
            let v729 : string = v669.l0
            let v730 : string = v729 + v726 
            v669.l0 <- v730
            let v731 : string = $"{v83}"
            let v734 : string = v669.l0
            let v735 : string = v734 + v731 
            v669.l0 <- v735
            let v736 : string = " }"
            let v737 : string = $"{v736}"
            let v740 : string = v669.l0
            let v741 : string = v740 + v737 
            v669.l0 <- v741
            let v742 : string = v669.l0
            let v743 : (unit -> string) = closure5()
            let v744 : string = $"{v530} {v660} #{v666} %s{v743 ()} / {v742}"
            let v747 : char list = []
            let v748 : (char list -> (char [])) = List.toArray
            let v749 : (char []) = v748 v747
            let v752 : string = v744.TrimStart v749 
            let v770 : char list = []
            let v771 : char list = '/' :: v770 
            let v774 : char list = ' ' :: v771 
            let v777 : (char list -> (char [])) = List.toArray
            let v778 : (char []) = v777 v774
            let v781 : string = v752.TrimEnd v778 
            let v799 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v800 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v781 v800 
            let _v799 = () 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v801 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v781 v801 
            let _v799 = () 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v802 : string = $"near_sdk::log!(\"{{}}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v781 v802 
            let _v799 = () 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            System.Console.WriteLine v781 
            let _v799 = () 
            #endif
#if FABLE_COMPILER_PYTHON
            System.Console.WriteLine v781 
            let _v799 = () 
            #endif
#else
            System.Console.WriteLine v781 
            let _v799 = () 
            #endif
            _v799 
            let v803 : (string -> unit) = v101.l0
            v803 v781
    let v804 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v805 : Async<unit> = null |> unbox<Async<unit>>
    let _v804 = v805 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v808 : Async<unit> = null |> unbox<Async<unit>>
    let _v804 = v808 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v811 : Async<unit> = null |> unbox<Async<unit>>
    let _v804 = v811 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v814 : Async<unit> = null |> unbox<Async<unit>>
    let _v804 = v814 
    #endif
#if FABLE_COMPILER_PYTHON
    let v817 : Async<unit> = null |> unbox<Async<unit>>
    let _v804 = v817 
    #endif
#else
    let v820 : (int32 -> Async<unit>) = Async.Sleep
    let v821 : Async<unit> = v820 10
    let _v804 = v821 
    #endif
    let v822 : Async<unit> = _v804 
    do! v822 
    let v827 : int64 = v3 + 1L
    let v828 : Async<int64> = method14(v0, v1, v2, v827)
    return! v828 
    (*
    let v829 : int64 = *)
    }
    |> fun x -> _v20 <- Some x
    let v830 : Async<int64> = match _v20 with Some x -> x | None -> failwith "async.new_async_unit / _v20=None"
    let _v4 = v830 
    #endif
    let v831 : Async<int64> = _v4 
    v831
and closure4 (v0 : US6) (v1 : string) : Async<int64> =
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
and closure3 () (v0 : US6) : (string -> Async<int64>) =
    closure4(v0)
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
        let v72 : bool = State.trace_state.IsNone
        if v72 then
            let v73 : US0 = US0_0
            let struct (v74 : Mut0, v75 : Mut1, v76 : Mut2, v77 : Mut3, v78 : int64 option) = method0(v73)
            let v79 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v74, v75, v76, v77, v78) 
            State.trace_state <- v79 
            ()
        let struct (v84 : Mut0, v85 : Mut1, v86 : Mut2, v87 : Mut3, v88 : int64 option) = State.trace_state.Value
        let v99 : bool = State.trace_state.IsNone
        if v99 then
            let v100 : US0 = US0_0
            let struct (v101 : Mut0, v102 : Mut1, v103 : Mut2, v104 : Mut3, v105 : int64 option) = method0(v100)
            let v106 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v101, v102, v103, v104, v105) 
            State.trace_state <- v106 
            ()
        let struct (v111 : Mut0, v112 : Mut1, v113 : Mut2, v114 : Mut3, v115 : int64 option) = State.trace_state.Value
        let v126 : US0 = v114.l0
        let v127 : bool = v113.l0
        let v128 : bool = v127 = false
        let v131 : bool =
            if v128 then
                false
            else
                let v129 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v126
                let v130 : bool = 1 >= v129
                v130
        if v131 then
            let v132 : int64 = v84.l0
            let v133 : int64 = v132 + 1L
            v84.l0 <- v133
            let v134 : bool = State.trace_state.IsNone
            if v134 then
                let v135 : US0 = US0_0
                let struct (v136 : Mut0, v137 : Mut1, v138 : Mut2, v139 : Mut3, v140 : int64 option) = method0(v135)
                let v141 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v136, v137, v138, v139, v140) 
                State.trace_state <- v141 
                ()
            let struct (v146 : Mut0, v147 : Mut1, v148 : Mut2, v149 : Mut3, v150 : int64 option) = State.trace_state.Value
            let v161 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v162 : US3 option = None
            let _v162 = ref v162 
            match v150 with
            | Some x -> (
            (fun () ->
            (fun () ->
            let v163 : int64 = x
            let v164 : US3 = US3_0(v163)
            v164 
            )
            |> fun x -> x () |> Some
            ) () ) | None -> None
            |> fun x -> _v162.Value <- x
            let v165 : US3 option = _v162.Value 
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
            let v218 : string = method9()
            let v221 : (string -> string) = v217.ToString
            let v222 : string = v221 v218
            let _v161 = v222 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v225 : US3 option = None
            let _v225 = ref v225 
            match v150 with
            | Some x -> (
            (fun () ->
            (fun () ->
            let v226 : int64 = x
            let v227 : US3 = US3_0(v226)
            v227 
            )
            |> fun x -> x () |> Some
            ) () ) | None -> None
            |> fun x -> _v225.Value <- x
            let v228 : US3 option = _v225.Value 
            let v239 : US3 = US3_1
            let v240 : US3 = v228 |> Option.defaultValue v239 
            let v280 : System.DateTime =
                match v240 with
                | US3_1 -> (* None *)
                    let v276 : System.DateTime = System.DateTime.Now
                    v276
                | US3_0(v244) -> (* Some *)
                    let v245 : System.DateTime = System.DateTime.Now
                    let v248 : (System.DateTime -> int64) = _.Ticks
                    let v249 : int64 = v248 v245
                    let v252 : int64 = v249 - v244
                    let v253 : (int64 -> System.TimeSpan) = System.TimeSpan 
                    let v254 : System.TimeSpan = v253 v252
                    let v257 : (System.TimeSpan -> int32) = _.Hours
                    let v258 : int32 = v257 v254
                    let v261 : (System.TimeSpan -> int32) = _.Minutes
                    let v262 : int32 = v261 v254
                    let v265 : (System.TimeSpan -> int32) = _.Seconds
                    let v266 : int32 = v265 v254
                    let v269 : (System.TimeSpan -> int32) = _.Milliseconds
                    let v270 : int32 = v269 v254
                    let v273 : System.DateTime = System.DateTime (1, 1, 1, v258, v262, v266, v270)
                    v273
            let v281 : string = method9()
            let v284 : (string -> string) = v280.ToString
            let v285 : string = v284 v281
            let _v161 = v285 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v288 : string = $"near_sdk::env::block_timestamp()"
            let v289 : uint64 = Fable.Core.RustInterop.emitRustExpr () v288 
            let v290 : US3 option = None
            let _v290 = ref v290 
            match v150 with
            | Some x -> (
            (fun () ->
            (fun () ->
            let v291 : int64 = x
            let v292 : US3 = US3_0(v291)
            v292 
            )
            |> fun x -> x () |> Some
            ) () ) | None -> None
            |> fun x -> _v290.Value <- x
            let v293 : US3 option = _v290.Value 
            let v304 : US3 = US3_1
            let v305 : US3 = v293 |> Option.defaultValue v304 
            let v314 : uint64 =
                match v305 with
                | US3_1 -> (* None *)
                    v289
                | US3_0(v309) -> (* Some *)
                    let v310 : (int64 -> uint64) = uint64
                    let v311 : uint64 = v310 v309
                    let v312 : uint64 = v289 - v311
                    v312
            let v315 : uint64 = v314 / 1000000000UL
            let v316 : uint64 = v315 % 60UL
            let v317 : uint64 = v315 / 60UL
            let v318 : uint64 = v317 % 60UL
            let v319 : uint64 = v315 / 3600UL
            let v320 : uint64 = v319 % 24UL
            let v321 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
            let v322 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v320, v318, v316) v321 
            let v323 : string = "fable_library_rust::String_::fromString($0)"
            let v324 : string = Fable.Core.RustInterop.emitRustExpr v322 v323 
            let _v161 = v324 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v325 : US3 option = None
            let _v325 = ref v325 
            match v150 with
            | Some x -> (
            (fun () ->
            (fun () ->
            let v326 : int64 = x
            let v327 : US3 = US3_0(v326)
            v327 
            )
            |> fun x -> x () |> Some
            ) () ) | None -> None
            |> fun x -> _v325.Value <- x
            let v328 : US3 option = _v325.Value 
            let v339 : US3 = US3_1
            let v340 : US3 = v328 |> Option.defaultValue v339 
            let v380 : System.DateTime =
                match v340 with
                | US3_1 -> (* None *)
                    let v376 : System.DateTime = System.DateTime.Now
                    v376
                | US3_0(v344) -> (* Some *)
                    let v345 : System.DateTime = System.DateTime.Now
                    let v348 : (System.DateTime -> int64) = _.Ticks
                    let v349 : int64 = v348 v345
                    let v352 : int64 = v349 - v344
                    let v353 : (int64 -> System.TimeSpan) = System.TimeSpan 
                    let v354 : System.TimeSpan = v353 v352
                    let v357 : (System.TimeSpan -> int32) = _.Hours
                    let v358 : int32 = v357 v354
                    let v361 : (System.TimeSpan -> int32) = _.Minutes
                    let v362 : int32 = v361 v354
                    let v365 : (System.TimeSpan -> int32) = _.Seconds
                    let v366 : int32 = v365 v354
                    let v369 : (System.TimeSpan -> int32) = _.Milliseconds
                    let v370 : int32 = v369 v354
                    let v373 : System.DateTime = System.DateTime (1, 1, 1, v358, v362, v366, v370)
                    v373
            let v381 : string = method10()
            let v384 : (string -> string) = v380.ToString
            let v385 : string = v384 v381
            let _v161 = v385 
            #endif
#if FABLE_COMPILER_PYTHON
            let v388 : US3 option = None
            let _v388 = ref v388 
            match v150 with
            | Some x -> (
            (fun () ->
            (fun () ->
            let v389 : int64 = x
            let v390 : US3 = US3_0(v389)
            v390 
            )
            |> fun x -> x () |> Some
            ) () ) | None -> None
            |> fun x -> _v388.Value <- x
            let v391 : US3 option = _v388.Value 
            let v402 : US3 = US3_1
            let v403 : US3 = v391 |> Option.defaultValue v402 
            let v443 : System.DateTime =
                match v403 with
                | US3_1 -> (* None *)
                    let v439 : System.DateTime = System.DateTime.Now
                    v439
                | US3_0(v407) -> (* Some *)
                    let v408 : System.DateTime = System.DateTime.Now
                    let v411 : (System.DateTime -> int64) = _.Ticks
                    let v412 : int64 = v411 v408
                    let v415 : int64 = v412 - v407
                    let v416 : (int64 -> System.TimeSpan) = System.TimeSpan 
                    let v417 : System.TimeSpan = v416 v415
                    let v420 : (System.TimeSpan -> int32) = _.Hours
                    let v421 : int32 = v420 v417
                    let v424 : (System.TimeSpan -> int32) = _.Minutes
                    let v425 : int32 = v424 v417
                    let v428 : (System.TimeSpan -> int32) = _.Seconds
                    let v429 : int32 = v428 v417
                    let v432 : (System.TimeSpan -> int32) = _.Milliseconds
                    let v433 : int32 = v432 v417
                    let v436 : System.DateTime = System.DateTime (1, 1, 1, v421, v425, v429, v433)
                    v436
            let v444 : string = method10()
            let v447 : (string -> string) = v443.ToString
            let v448 : string = v447 v444
            let _v161 = v448 
            #endif
#else
            let v451 : US3 option = None
            let _v451 = ref v451 
            match v150 with
            | Some x -> (
            (fun () ->
            (fun () ->
            let v452 : int64 = x
            let v453 : US3 = US3_0(v452)
            v453 
            )
            |> fun x -> x () |> Some
            ) () ) | None -> None
            |> fun x -> _v451.Value <- x
            let v454 : US3 option = _v451.Value 
            let v465 : US3 = US3_1
            let v466 : US3 = v454 |> Option.defaultValue v465 
            let v506 : System.DateTime =
                match v466 with
                | US3_1 -> (* None *)
                    let v502 : System.DateTime = System.DateTime.Now
                    v502
                | US3_0(v470) -> (* Some *)
                    let v471 : System.DateTime = System.DateTime.Now
                    let v474 : (System.DateTime -> int64) = _.Ticks
                    let v475 : int64 = v474 v471
                    let v478 : int64 = v475 - v470
                    let v479 : (int64 -> System.TimeSpan) = System.TimeSpan 
                    let v480 : System.TimeSpan = v479 v478
                    let v483 : (System.TimeSpan -> int32) = _.Hours
                    let v484 : int32 = v483 v480
                    let v487 : (System.TimeSpan -> int32) = _.Minutes
                    let v488 : int32 = v487 v480
                    let v491 : (System.TimeSpan -> int32) = _.Seconds
                    let v492 : int32 = v491 v480
                    let v495 : (System.TimeSpan -> int32) = _.Milliseconds
                    let v496 : int32 = v495 v480
                    let v499 : System.DateTime = System.DateTime (1, 1, 1, v484, v488, v492, v496)
                    v499
            let v507 : string = method10()
            let v510 : (string -> string) = v506.ToString
            let v511 : string = v510 v507
            let _v161 = v511 
            #endif
            let v514 : string = _v161 
            let v579 : string = "Debug"
            let v580 : (unit -> string) = v579.ToLower
            let v581 : string = v580 ()
            let v584 : string = v581.PadLeft (7, ' ')
            let v598 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v599 : string = "inline_colorization::color_bright_blue"
            let v600 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v599 
            let v601 : string = "&*$0"
            let v602 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v584 v601 
            let v603 : string = "inline_colorization::color_reset"
            let v604 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v603 
            let v605 : string = "\"{v600}{v602}{v604}\""
            let v606 : string = @$"format!(" + v605 + ")"
            let v607 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v606 
            let v608 : string = "fable_library_rust::String_::fromString($0)"
            let v609 : string = Fable.Core.RustInterop.emitRustExpr v607 v608 
            let _v598 = v609 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v610 : string = "inline_colorization::color_bright_blue"
            let v611 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v610 
            let v612 : string = "&*$0"
            let v613 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v584 v612 
            let v614 : string = "inline_colorization::color_reset"
            let v615 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v614 
            let v616 : string = "\"{v611}{v613}{v615}\""
            let v617 : string = @$"format!(" + v616 + ")"
            let v618 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v617 
            let v619 : string = "fable_library_rust::String_::fromString($0)"
            let v620 : string = Fable.Core.RustInterop.emitRustExpr v618 v619 
            let _v598 = v620 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v621 : string = "inline_colorization::color_bright_blue"
            let v622 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v621 
            let v623 : string = "&*$0"
            let v624 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v584 v623 
            let v625 : string = "inline_colorization::color_reset"
            let v626 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v625 
            let v627 : string = "\"{v622}{v624}{v626}\""
            let v628 : string = @$"format!(" + v627 + ")"
            let v629 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v628 
            let v630 : string = "fable_library_rust::String_::fromString($0)"
            let v631 : string = Fable.Core.RustInterop.emitRustExpr v629 v630 
            let _v598 = v631 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v632 : string = "\u001b[94m"
            let v633 : string = method11()
            let v634 : string = v632 + v584 
            let v635 : string = v634 + v633 
            let _v598 = v635 
            #endif
#if FABLE_COMPILER_PYTHON
            let v636 : string = "\u001b[94m"
            let v637 : string = method11()
            let v638 : string = v636 + v584 
            let v639 : string = v638 + v637 
            let _v598 = v639 
            #endif
#else
            let v640 : string = "\u001b[94m"
            let v641 : string = method11()
            let v642 : string = v640 + v584 
            let v643 : string = v642 + v641 
            let _v598 = v643 
            #endif
            let v644 : string = _v598 
            let v650 : int64 = v146.l0
            let v651 : string = method12(v0)
            let v652 : string = method13()
            let v653 : Mut4 = {l0 = v652} : Mut4
            let v654 : string = "{ "
            let v655 : string = $"{v654}"
            let v658 : string = v653.l0
            let v659 : string = v658 + v655 
            v653.l0 <- v659
            let v660 : string = "path"
            let v661 : string = $"{v660}"
            let v664 : string = v653.l0
            let v665 : string = v664 + v661 
            v653.l0 <- v665
            let v666 : string = " = "
            let v667 : string = $"{v666}"
            let v670 : string = v653.l0
            let v671 : string = v670 + v667 
            v653.l0 <- v671
            let v672 : string = $"{v651}"
            let v675 : string = v653.l0
            let v676 : string = v675 + v672 
            v653.l0 <- v676
            let v677 : string = "; "
            let v678 : string = $"{v677}"
            let v681 : string = v653.l0
            let v682 : string = v681 + v678 
            v653.l0 <- v682
            let v683 : string = "retry"
            let v684 : string = $"{v683}"
            let v687 : string = v653.l0
            let v688 : string = v687 + v684 
            v653.l0 <- v688
            let v689 : string = $"{v666}"
            let v692 : string = v653.l0
            let v693 : string = v692 + v689 
            v653.l0 <- v693
            let v694 : string = $"{v1}"
            let v697 : string = v653.l0
            let v698 : string = v697 + v694 
            v653.l0 <- v698
            let v699 : string = $"{v677}"
            let v702 : string = v653.l0
            let v703 : string = v702 + v699 
            v653.l0 <- v703
            let v704 : string = "ex"
            let v705 : string = $"{v704}"
            let v708 : string = v653.l0
            let v709 : string = v708 + v705 
            v653.l0 <- v709
            let v710 : string = $"{v666}"
            let v713 : string = v653.l0
            let v714 : string = v713 + v710 
            v653.l0 <- v714
            let v715 : string = $"{v67}"
            let v718 : string = v653.l0
            let v719 : string = v718 + v715 
            v653.l0 <- v719
            let v720 : string = " }"
            let v721 : string = $"{v720}"
            let v724 : string = v653.l0
            let v725 : string = v724 + v721 
            v653.l0 <- v725
            let v726 : string = v653.l0
            let v727 : (unit -> string) = closure5()
            let v728 : string = $"{v514} {v644} #{v650} %s{v727 ()} / {v726}"
            let v731 : char list = []
            let v732 : (char list -> (char [])) = List.toArray
            let v733 : (char []) = v732 v731
            let v736 : string = v728.TrimStart v733 
            let v754 : char list = []
            let v755 : char list = '/' :: v754 
            let v758 : char list = ' ' :: v755 
            let v761 : (char list -> (char [])) = List.toArray
            let v762 : (char []) = v761 v758
            let v765 : string = v736.TrimEnd v762 
            let v783 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v784 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v765 v784 
            let _v783 = () 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v785 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v765 v785 
            let _v783 = () 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v786 : string = $"near_sdk::log!(\"{{}}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v765 v786 
            let _v783 = () 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            System.Console.WriteLine v765 
            let _v783 = () 
            #endif
#if FABLE_COMPILER_PYTHON
            System.Console.WriteLine v765 
            let _v783 = () 
            #endif
#else
            System.Console.WriteLine v765 
            let _v783 = () 
            #endif
            _v783 
            let v787 : (string -> unit) = v85.l0
            v787 v765
    let v788 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v789 : Async<unit> = null |> unbox<Async<unit>>
    let _v788 = v789 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v792 : Async<unit> = null |> unbox<Async<unit>>
    let _v788 = v792 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v795 : Async<unit> = null |> unbox<Async<unit>>
    let _v788 = v795 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v798 : Async<unit> = null |> unbox<Async<unit>>
    let _v788 = v798 
    #endif
#if FABLE_COMPILER_PYTHON
    let v801 : Async<unit> = null |> unbox<Async<unit>>
    let _v788 = v801 
    #endif
#else
    let v804 : (int32 -> Async<unit>) = Async.Sleep
    let v805 : Async<unit> = v804 10
    let _v788 = v805 
    #endif
    let v806 : Async<unit> = _v788 
    do! v806 
    let v811 : int64 = v1 + 1L
    let v812 : Async<int64> = method15(v0, v811)
    return! v812 
    (*
    let v813 : int64 = *)
    }
    |> fun x -> _v18 <- Some x
    let v814 : Async<int64> = match _v18 with Some x -> x | None -> failwith "async.new_async_unit / _v18=None"
    let _v2 = v814 
    #endif
    let v815 : Async<int64> = _v2 
    v815
and closure6 () (v0 : string) : Async<int64> =
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
and closure7 () (v0 : string) : Async<string> =
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
and closure9 (v0 : string) (v1 : string) : bool =
    method16(v0, v1)
and closure8 () (v0 : string) : (string -> bool) =
    closure9(v0)
and closure11 (v0 : string) (v1 : string) : Async<unit> =
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
and closure10 () (v0 : string) : (string -> Async<unit>) =
    closure11(v0)
and closure13 (v0 : string) (v1 : string) : Async<unit> =
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
    }
    |> fun x -> _v18 <- Some x
    let v160 : Async<unit> = match _v18 with Some x -> x | None -> failwith "async.new_async_unit / _v18=None"
    let _v2 = v160 
    #endif
    let v161 : Async<unit> = _v2 
    v161
and closure12 () (v0 : string) : (string -> Async<unit>) =
    closure13(v0)
and closure15 () () : string =
    let v0 : string = "delete_file_async"
    v0
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
        let v25 : bool = State.trace_state.IsNone
        if v25 then
            let v26 : US0 = US0_0
            let struct (v27 : Mut0, v28 : Mut1, v29 : Mut2, v30 : Mut3, v31 : int64 option) = method0(v26)
            let v32 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v27, v28, v29, v30, v31) 
            State.trace_state <- v32 
            ()
        let struct (v37 : Mut0, v38 : Mut1, v39 : Mut2, v40 : Mut3, v41 : int64 option) = State.trace_state.Value
        let v52 : bool = State.trace_state.IsNone
        if v52 then
            let v53 : US0 = US0_0
            let struct (v54 : Mut0, v55 : Mut1, v56 : Mut2, v57 : Mut3, v58 : int64 option) = method0(v53)
            let v59 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v54, v55, v56, v57, v58) 
            State.trace_state <- v59 
            ()
        let struct (v64 : Mut0, v65 : Mut1, v66 : Mut2, v67 : Mut3, v68 : int64 option) = State.trace_state.Value
        let v79 : US0 = v67.l0
        let v80 : bool = v66.l0
        let v81 : bool = v80 = false
        let v84 : bool =
            if v81 then
                false
            else
                let v82 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v79
                let v83 : bool = 3 >= v82
                v83
        if v84 then
            let v85 : int64 = v37.l0
            let v86 : int64 = v85 + 1L
            v37.l0 <- v86
            let v87 : bool = State.trace_state.IsNone
            if v87 then
                let v88 : US0 = US0_0
                let struct (v89 : Mut0, v90 : Mut1, v91 : Mut2, v92 : Mut3, v93 : int64 option) = method0(v88)
                let v94 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v89, v90, v91, v92, v93) 
                State.trace_state <- v94 
                ()
            let struct (v99 : Mut0, v100 : Mut1, v101 : Mut2, v102 : Mut3, v103 : int64 option) = State.trace_state.Value
            let v114 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v115 : US3 option = None
            let _v115 = ref v115 
            match v103 with
            | Some x -> (
            (fun () ->
            (fun () ->
            let v116 : int64 = x
            let v117 : US3 = US3_0(v116)
            v117 
            )
            |> fun x -> x () |> Some
            ) () ) | None -> None
            |> fun x -> _v115.Value <- x
            let v118 : US3 option = _v115.Value 
            let v129 : US3 = US3_1
            let v130 : US3 = v118 |> Option.defaultValue v129 
            let v170 : System.DateTime =
                match v130 with
                | US3_1 -> (* None *)
                    let v166 : System.DateTime = System.DateTime.Now
                    v166
                | US3_0(v134) -> (* Some *)
                    let v135 : System.DateTime = System.DateTime.Now
                    let v138 : (System.DateTime -> int64) = _.Ticks
                    let v139 : int64 = v138 v135
                    let v142 : int64 = v139 - v134
                    let v143 : (int64 -> System.TimeSpan) = System.TimeSpan 
                    let v144 : System.TimeSpan = v143 v142
                    let v147 : (System.TimeSpan -> int32) = _.Hours
                    let v148 : int32 = v147 v144
                    let v151 : (System.TimeSpan -> int32) = _.Minutes
                    let v152 : int32 = v151 v144
                    let v155 : (System.TimeSpan -> int32) = _.Seconds
                    let v156 : int32 = v155 v144
                    let v159 : (System.TimeSpan -> int32) = _.Milliseconds
                    let v160 : int32 = v159 v144
                    let v163 : System.DateTime = System.DateTime (1, 1, 1, v148, v152, v156, v160)
                    v163
            let v171 : string = method9()
            let v174 : (string -> string) = v170.ToString
            let v175 : string = v174 v171
            let _v114 = v175 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v178 : US3 option = None
            let _v178 = ref v178 
            match v103 with
            | Some x -> (
            (fun () ->
            (fun () ->
            let v179 : int64 = x
            let v180 : US3 = US3_0(v179)
            v180 
            )
            |> fun x -> x () |> Some
            ) () ) | None -> None
            |> fun x -> _v178.Value <- x
            let v181 : US3 option = _v178.Value 
            let v192 : US3 = US3_1
            let v193 : US3 = v181 |> Option.defaultValue v192 
            let v233 : System.DateTime =
                match v193 with
                | US3_1 -> (* None *)
                    let v229 : System.DateTime = System.DateTime.Now
                    v229
                | US3_0(v197) -> (* Some *)
                    let v198 : System.DateTime = System.DateTime.Now
                    let v201 : (System.DateTime -> int64) = _.Ticks
                    let v202 : int64 = v201 v198
                    let v205 : int64 = v202 - v197
                    let v206 : (int64 -> System.TimeSpan) = System.TimeSpan 
                    let v207 : System.TimeSpan = v206 v205
                    let v210 : (System.TimeSpan -> int32) = _.Hours
                    let v211 : int32 = v210 v207
                    let v214 : (System.TimeSpan -> int32) = _.Minutes
                    let v215 : int32 = v214 v207
                    let v218 : (System.TimeSpan -> int32) = _.Seconds
                    let v219 : int32 = v218 v207
                    let v222 : (System.TimeSpan -> int32) = _.Milliseconds
                    let v223 : int32 = v222 v207
                    let v226 : System.DateTime = System.DateTime (1, 1, 1, v211, v215, v219, v223)
                    v226
            let v234 : string = method9()
            let v237 : (string -> string) = v233.ToString
            let v238 : string = v237 v234
            let _v114 = v238 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v241 : string = $"near_sdk::env::block_timestamp()"
            let v242 : uint64 = Fable.Core.RustInterop.emitRustExpr () v241 
            let v243 : US3 option = None
            let _v243 = ref v243 
            match v103 with
            | Some x -> (
            (fun () ->
            (fun () ->
            let v244 : int64 = x
            let v245 : US3 = US3_0(v244)
            v245 
            )
            |> fun x -> x () |> Some
            ) () ) | None -> None
            |> fun x -> _v243.Value <- x
            let v246 : US3 option = _v243.Value 
            let v257 : US3 = US3_1
            let v258 : US3 = v246 |> Option.defaultValue v257 
            let v267 : uint64 =
                match v258 with
                | US3_1 -> (* None *)
                    v242
                | US3_0(v262) -> (* Some *)
                    let v263 : (int64 -> uint64) = uint64
                    let v264 : uint64 = v263 v262
                    let v265 : uint64 = v242 - v264
                    v265
            let v268 : uint64 = v267 / 1000000000UL
            let v269 : uint64 = v268 % 60UL
            let v270 : uint64 = v268 / 60UL
            let v271 : uint64 = v270 % 60UL
            let v272 : uint64 = v268 / 3600UL
            let v273 : uint64 = v272 % 24UL
            let v274 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
            let v275 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v273, v271, v269) v274 
            let v276 : string = "fable_library_rust::String_::fromString($0)"
            let v277 : string = Fable.Core.RustInterop.emitRustExpr v275 v276 
            let _v114 = v277 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v278 : US3 option = None
            let _v278 = ref v278 
            match v103 with
            | Some x -> (
            (fun () ->
            (fun () ->
            let v279 : int64 = x
            let v280 : US3 = US3_0(v279)
            v280 
            )
            |> fun x -> x () |> Some
            ) () ) | None -> None
            |> fun x -> _v278.Value <- x
            let v281 : US3 option = _v278.Value 
            let v292 : US3 = US3_1
            let v293 : US3 = v281 |> Option.defaultValue v292 
            let v333 : System.DateTime =
                match v293 with
                | US3_1 -> (* None *)
                    let v329 : System.DateTime = System.DateTime.Now
                    v329
                | US3_0(v297) -> (* Some *)
                    let v298 : System.DateTime = System.DateTime.Now
                    let v301 : (System.DateTime -> int64) = _.Ticks
                    let v302 : int64 = v301 v298
                    let v305 : int64 = v302 - v297
                    let v306 : (int64 -> System.TimeSpan) = System.TimeSpan 
                    let v307 : System.TimeSpan = v306 v305
                    let v310 : (System.TimeSpan -> int32) = _.Hours
                    let v311 : int32 = v310 v307
                    let v314 : (System.TimeSpan -> int32) = _.Minutes
                    let v315 : int32 = v314 v307
                    let v318 : (System.TimeSpan -> int32) = _.Seconds
                    let v319 : int32 = v318 v307
                    let v322 : (System.TimeSpan -> int32) = _.Milliseconds
                    let v323 : int32 = v322 v307
                    let v326 : System.DateTime = System.DateTime (1, 1, 1, v311, v315, v319, v323)
                    v326
            let v334 : string = method10()
            let v337 : (string -> string) = v333.ToString
            let v338 : string = v337 v334
            let _v114 = v338 
            #endif
#if FABLE_COMPILER_PYTHON
            let v341 : US3 option = None
            let _v341 = ref v341 
            match v103 with
            | Some x -> (
            (fun () ->
            (fun () ->
            let v342 : int64 = x
            let v343 : US3 = US3_0(v342)
            v343 
            )
            |> fun x -> x () |> Some
            ) () ) | None -> None
            |> fun x -> _v341.Value <- x
            let v344 : US3 option = _v341.Value 
            let v355 : US3 = US3_1
            let v356 : US3 = v344 |> Option.defaultValue v355 
            let v396 : System.DateTime =
                match v356 with
                | US3_1 -> (* None *)
                    let v392 : System.DateTime = System.DateTime.Now
                    v392
                | US3_0(v360) -> (* Some *)
                    let v361 : System.DateTime = System.DateTime.Now
                    let v364 : (System.DateTime -> int64) = _.Ticks
                    let v365 : int64 = v364 v361
                    let v368 : int64 = v365 - v360
                    let v369 : (int64 -> System.TimeSpan) = System.TimeSpan 
                    let v370 : System.TimeSpan = v369 v368
                    let v373 : (System.TimeSpan -> int32) = _.Hours
                    let v374 : int32 = v373 v370
                    let v377 : (System.TimeSpan -> int32) = _.Minutes
                    let v378 : int32 = v377 v370
                    let v381 : (System.TimeSpan -> int32) = _.Seconds
                    let v382 : int32 = v381 v370
                    let v385 : (System.TimeSpan -> int32) = _.Milliseconds
                    let v386 : int32 = v385 v370
                    let v389 : System.DateTime = System.DateTime (1, 1, 1, v374, v378, v382, v386)
                    v389
            let v397 : string = method10()
            let v400 : (string -> string) = v396.ToString
            let v401 : string = v400 v397
            let _v114 = v401 
            #endif
#else
            let v404 : US3 option = None
            let _v404 = ref v404 
            match v103 with
            | Some x -> (
            (fun () ->
            (fun () ->
            let v405 : int64 = x
            let v406 : US3 = US3_0(v405)
            v406 
            )
            |> fun x -> x () |> Some
            ) () ) | None -> None
            |> fun x -> _v404.Value <- x
            let v407 : US3 option = _v404.Value 
            let v418 : US3 = US3_1
            let v419 : US3 = v407 |> Option.defaultValue v418 
            let v459 : System.DateTime =
                match v419 with
                | US3_1 -> (* None *)
                    let v455 : System.DateTime = System.DateTime.Now
                    v455
                | US3_0(v423) -> (* Some *)
                    let v424 : System.DateTime = System.DateTime.Now
                    let v427 : (System.DateTime -> int64) = _.Ticks
                    let v428 : int64 = v427 v424
                    let v431 : int64 = v428 - v423
                    let v432 : (int64 -> System.TimeSpan) = System.TimeSpan 
                    let v433 : System.TimeSpan = v432 v431
                    let v436 : (System.TimeSpan -> int32) = _.Hours
                    let v437 : int32 = v436 v433
                    let v440 : (System.TimeSpan -> int32) = _.Minutes
                    let v441 : int32 = v440 v433
                    let v444 : (System.TimeSpan -> int32) = _.Seconds
                    let v445 : int32 = v444 v433
                    let v448 : (System.TimeSpan -> int32) = _.Milliseconds
                    let v449 : int32 = v448 v433
                    let v452 : System.DateTime = System.DateTime (1, 1, 1, v437, v441, v445, v449)
                    v452
            let v460 : string = method10()
            let v463 : (string -> string) = v459.ToString
            let v464 : string = v463 v460
            let _v114 = v464 
            #endif
            let v467 : string = _v114 
            let v532 : string = "Warning"
            let v533 : (unit -> string) = v532.ToLower
            let v534 : string = v533 ()
            let v537 : string = v534.PadLeft (7, ' ')
            let v551 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v552 : string = "inline_colorization::color_yellow"
            let v553 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v552 
            let v554 : string = "&*$0"
            let v555 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v537 v554 
            let v556 : string = "inline_colorization::color_reset"
            let v557 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v556 
            let v558 : string = "\"{v553}{v555}{v557}\""
            let v559 : string = @$"format!(" + v558 + ")"
            let v560 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v559 
            let v561 : string = "fable_library_rust::String_::fromString($0)"
            let v562 : string = Fable.Core.RustInterop.emitRustExpr v560 v561 
            let _v551 = v562 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v563 : string = "inline_colorization::color_yellow"
            let v564 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v563 
            let v565 : string = "&*$0"
            let v566 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v537 v565 
            let v567 : string = "inline_colorization::color_reset"
            let v568 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v567 
            let v569 : string = "\"{v564}{v566}{v568}\""
            let v570 : string = @$"format!(" + v569 + ")"
            let v571 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v570 
            let v572 : string = "fable_library_rust::String_::fromString($0)"
            let v573 : string = Fable.Core.RustInterop.emitRustExpr v571 v572 
            let _v551 = v573 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v574 : string = "inline_colorization::color_yellow"
            let v575 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v574 
            let v576 : string = "&*$0"
            let v577 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v537 v576 
            let v578 : string = "inline_colorization::color_reset"
            let v579 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v578 
            let v580 : string = "\"{v575}{v577}{v579}\""
            let v581 : string = @$"format!(" + v580 + ")"
            let v582 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v581 
            let v583 : string = "fable_library_rust::String_::fromString($0)"
            let v584 : string = Fable.Core.RustInterop.emitRustExpr v582 v583 
            let _v551 = v584 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v585 : string = "\u001b[93m"
            let v586 : string = method11()
            let v587 : string = v585 + v537 
            let v588 : string = v587 + v586 
            let _v551 = v588 
            #endif
#if FABLE_COMPILER_PYTHON
            let v589 : string = "\u001b[93m"
            let v590 : string = method11()
            let v591 : string = v589 + v537 
            let v592 : string = v591 + v590 
            let _v551 = v592 
            #endif
#else
            let v593 : string = "\u001b[93m"
            let v594 : string = method11()
            let v595 : string = v593 + v537 
            let v596 : string = v595 + v594 
            let _v551 = v596 
            #endif
            let v597 : string = _v551 
            let v603 : int64 = v99.l0
            let v604 : string = method12(v0)
            let v605 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v606 : string = $"%A{v22}"
            let _v605 = v606 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v609 : string = $"%A{v22}"
            let _v605 = v609 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v612 : string = $"%A{v22}"
            let _v605 = v612 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v615 : string = $"%A{v22}"
            let _v605 = v615 
            #endif
#if FABLE_COMPILER_PYTHON
            let v618 : string = $"%A{v22}"
            let _v605 = v618 
            #endif
#else
            let v621 : string = $"{v22.GetType ()}: {v22.Message}"
            let _v605 = v621 
            #endif
            let v622 : string = _v605 
            let v627 : string = method13()
            let v628 : Mut4 = {l0 = v627} : Mut4
            let v629 : string = "{ "
            let v630 : string = $"{v629}"
            let v633 : string = v628.l0
            let v634 : string = v633 + v630 
            v628.l0 <- v634
            let v635 : string = "path"
            let v636 : string = $"{v635}"
            let v639 : string = v628.l0
            let v640 : string = v639 + v636 
            v628.l0 <- v640
            let v641 : string = " = "
            let v642 : string = $"{v641}"
            let v645 : string = v628.l0
            let v646 : string = v645 + v642 
            v628.l0 <- v646
            let v647 : string = $"{v604}"
            let v650 : string = v628.l0
            let v651 : string = v650 + v647 
            v628.l0 <- v651
            let v652 : string = "; "
            let v653 : string = $"{v652}"
            let v656 : string = v628.l0
            let v657 : string = v656 + v653 
            v628.l0 <- v657
            let v658 : string = "ex"
            let v659 : string = $"{v658}"
            let v662 : string = v628.l0
            let v663 : string = v662 + v659 
            v628.l0 <- v663
            let v664 : string = $"{v641}"
            let v667 : string = v628.l0
            let v668 : string = v667 + v664 
            v628.l0 <- v668
            let v669 : string = $"{v622}"
            let v672 : string = v628.l0
            let v673 : string = v672 + v669 
            v628.l0 <- v673
            let v674 : string = " }"
            let v675 : string = $"{v674}"
            let v678 : string = v628.l0
            let v679 : string = v678 + v675 
            v628.l0 <- v679
            let v680 : string = v628.l0
            let v681 : (unit -> string) = closure15()
            let v682 : string = $"{v467} {v597} #{v603} %s{v681 ()} / {v680}"
            let v685 : char list = []
            let v686 : (char list -> (char [])) = List.toArray
            let v687 : (char []) = v686 v685
            let v690 : string = v682.TrimStart v687 
            let v708 : char list = []
            let v709 : char list = '/' :: v708 
            let v712 : char list = ' ' :: v709 
            let v715 : (char list -> (char [])) = List.toArray
            let v716 : (char []) = v715 v712
            let v719 : string = v690.TrimEnd v716 
            let v737 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v738 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v719 v738 
            let _v737 = () 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v739 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v719 v739 
            let _v737 = () 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v740 : string = $"near_sdk::log!(\"{{}}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v719 v740 
            let _v737 = () 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            System.Console.WriteLine v719 
            let _v737 = () 
            #endif
#if FABLE_COMPILER_PYTHON
            System.Console.WriteLine v719 
            let _v737 = () 
            #endif
#else
            System.Console.WriteLine v719 
            let _v737 = () 
            #endif
            _v737 
            let v741 : (string -> unit) = v38.l0
            v741 v719
    let v742 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v743 : Async<unit> = null |> unbox<Async<unit>>
    let _v742 = v743 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v746 : Async<unit> = null |> unbox<Async<unit>>
    let _v742 = v746 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v749 : Async<unit> = null |> unbox<Async<unit>>
    let _v742 = v749 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v752 : Async<unit> = null |> unbox<Async<unit>>
    let _v742 = v752 
    #endif
#if FABLE_COMPILER_PYTHON
    let v755 : Async<unit> = null |> unbox<Async<unit>>
    let _v742 = v755 
    #endif
#else
    let v758 : (int32 -> Async<unit>) = Async.Sleep
    let v759 : Async<unit> = v758 10
    let _v742 = v759 
    #endif
    let v760 : Async<unit> = _v742 
    do! v760 
    let v765 : int64 = v1 + 1L
    let v766 : Async<int64> = method19(v0, v765)
    return! v766 
    (*
    let v767 : int64 = *)
    }
    |> fun x -> _v18 <- Some x
    let v768 : Async<int64> = match _v18 with Some x -> x | None -> failwith "async.new_async_unit / _v18=None"
    let _v2 = v768 
    #endif
    let v769 : Async<int64> = _v2 
    v769
and closure14 () (v0 : string) : Async<int64> =
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
and closure18 () () : string =
    let v0 : string = "move_file_async"
    v0
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
        let v24 : bool = State.trace_state.IsNone
        if v24 then
            let v25 : US0 = US0_0
            let struct (v26 : Mut0, v27 : Mut1, v28 : Mut2, v29 : Mut3, v30 : int64 option) = method0(v25)
            let v31 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v26, v27, v28, v29, v30) 
            State.trace_state <- v31 
            ()
        let struct (v36 : Mut0, v37 : Mut1, v38 : Mut2, v39 : Mut3, v40 : int64 option) = State.trace_state.Value
        let v51 : bool = State.trace_state.IsNone
        if v51 then
            let v52 : US0 = US0_0
            let struct (v53 : Mut0, v54 : Mut1, v55 : Mut2, v56 : Mut3, v57 : int64 option) = method0(v52)
            let v58 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v53, v54, v55, v56, v57) 
            State.trace_state <- v58 
            ()
        let struct (v63 : Mut0, v64 : Mut1, v65 : Mut2, v66 : Mut3, v67 : int64 option) = State.trace_state.Value
        let v78 : US0 = v66.l0
        let v79 : bool = v65.l0
        let v80 : bool = v79 = false
        let v83 : bool =
            if v80 then
                false
            else
                let v81 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v78
                let v82 : bool = 3 >= v81
                v82
        if v83 then
            let v84 : int64 = v36.l0
            let v85 : int64 = v84 + 1L
            v36.l0 <- v85
            let v86 : bool = State.trace_state.IsNone
            if v86 then
                let v87 : US0 = US0_0
                let struct (v88 : Mut0, v89 : Mut1, v90 : Mut2, v91 : Mut3, v92 : int64 option) = method0(v87)
                let v93 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v88, v89, v90, v91, v92) 
                State.trace_state <- v93 
                ()
            let struct (v98 : Mut0, v99 : Mut1, v100 : Mut2, v101 : Mut3, v102 : int64 option) = State.trace_state.Value
            let v113 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v114 : US3 option = None
            let _v114 = ref v114 
            match v102 with
            | Some x -> (
            (fun () ->
            (fun () ->
            let v115 : int64 = x
            let v116 : US3 = US3_0(v115)
            v116 
            )
            |> fun x -> x () |> Some
            ) () ) | None -> None
            |> fun x -> _v114.Value <- x
            let v117 : US3 option = _v114.Value 
            let v128 : US3 = US3_1
            let v129 : US3 = v117 |> Option.defaultValue v128 
            let v169 : System.DateTime =
                match v129 with
                | US3_1 -> (* None *)
                    let v165 : System.DateTime = System.DateTime.Now
                    v165
                | US3_0(v133) -> (* Some *)
                    let v134 : System.DateTime = System.DateTime.Now
                    let v137 : (System.DateTime -> int64) = _.Ticks
                    let v138 : int64 = v137 v134
                    let v141 : int64 = v138 - v133
                    let v142 : (int64 -> System.TimeSpan) = System.TimeSpan 
                    let v143 : System.TimeSpan = v142 v141
                    let v146 : (System.TimeSpan -> int32) = _.Hours
                    let v147 : int32 = v146 v143
                    let v150 : (System.TimeSpan -> int32) = _.Minutes
                    let v151 : int32 = v150 v143
                    let v154 : (System.TimeSpan -> int32) = _.Seconds
                    let v155 : int32 = v154 v143
                    let v158 : (System.TimeSpan -> int32) = _.Milliseconds
                    let v159 : int32 = v158 v143
                    let v162 : System.DateTime = System.DateTime (1, 1, 1, v147, v151, v155, v159)
                    v162
            let v170 : string = method9()
            let v173 : (string -> string) = v169.ToString
            let v174 : string = v173 v170
            let _v113 = v174 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v177 : US3 option = None
            let _v177 = ref v177 
            match v102 with
            | Some x -> (
            (fun () ->
            (fun () ->
            let v178 : int64 = x
            let v179 : US3 = US3_0(v178)
            v179 
            )
            |> fun x -> x () |> Some
            ) () ) | None -> None
            |> fun x -> _v177.Value <- x
            let v180 : US3 option = _v177.Value 
            let v191 : US3 = US3_1
            let v192 : US3 = v180 |> Option.defaultValue v191 
            let v232 : System.DateTime =
                match v192 with
                | US3_1 -> (* None *)
                    let v228 : System.DateTime = System.DateTime.Now
                    v228
                | US3_0(v196) -> (* Some *)
                    let v197 : System.DateTime = System.DateTime.Now
                    let v200 : (System.DateTime -> int64) = _.Ticks
                    let v201 : int64 = v200 v197
                    let v204 : int64 = v201 - v196
                    let v205 : (int64 -> System.TimeSpan) = System.TimeSpan 
                    let v206 : System.TimeSpan = v205 v204
                    let v209 : (System.TimeSpan -> int32) = _.Hours
                    let v210 : int32 = v209 v206
                    let v213 : (System.TimeSpan -> int32) = _.Minutes
                    let v214 : int32 = v213 v206
                    let v217 : (System.TimeSpan -> int32) = _.Seconds
                    let v218 : int32 = v217 v206
                    let v221 : (System.TimeSpan -> int32) = _.Milliseconds
                    let v222 : int32 = v221 v206
                    let v225 : System.DateTime = System.DateTime (1, 1, 1, v210, v214, v218, v222)
                    v225
            let v233 : string = method9()
            let v236 : (string -> string) = v232.ToString
            let v237 : string = v236 v233
            let _v113 = v237 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v240 : string = $"near_sdk::env::block_timestamp()"
            let v241 : uint64 = Fable.Core.RustInterop.emitRustExpr () v240 
            let v242 : US3 option = None
            let _v242 = ref v242 
            match v102 with
            | Some x -> (
            (fun () ->
            (fun () ->
            let v243 : int64 = x
            let v244 : US3 = US3_0(v243)
            v244 
            )
            |> fun x -> x () |> Some
            ) () ) | None -> None
            |> fun x -> _v242.Value <- x
            let v245 : US3 option = _v242.Value 
            let v256 : US3 = US3_1
            let v257 : US3 = v245 |> Option.defaultValue v256 
            let v266 : uint64 =
                match v257 with
                | US3_1 -> (* None *)
                    v241
                | US3_0(v261) -> (* Some *)
                    let v262 : (int64 -> uint64) = uint64
                    let v263 : uint64 = v262 v261
                    let v264 : uint64 = v241 - v263
                    v264
            let v267 : uint64 = v266 / 1000000000UL
            let v268 : uint64 = v267 % 60UL
            let v269 : uint64 = v267 / 60UL
            let v270 : uint64 = v269 % 60UL
            let v271 : uint64 = v267 / 3600UL
            let v272 : uint64 = v271 % 24UL
            let v273 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
            let v274 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v272, v270, v268) v273 
            let v275 : string = "fable_library_rust::String_::fromString($0)"
            let v276 : string = Fable.Core.RustInterop.emitRustExpr v274 v275 
            let _v113 = v276 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v277 : US3 option = None
            let _v277 = ref v277 
            match v102 with
            | Some x -> (
            (fun () ->
            (fun () ->
            let v278 : int64 = x
            let v279 : US3 = US3_0(v278)
            v279 
            )
            |> fun x -> x () |> Some
            ) () ) | None -> None
            |> fun x -> _v277.Value <- x
            let v280 : US3 option = _v277.Value 
            let v291 : US3 = US3_1
            let v292 : US3 = v280 |> Option.defaultValue v291 
            let v332 : System.DateTime =
                match v292 with
                | US3_1 -> (* None *)
                    let v328 : System.DateTime = System.DateTime.Now
                    v328
                | US3_0(v296) -> (* Some *)
                    let v297 : System.DateTime = System.DateTime.Now
                    let v300 : (System.DateTime -> int64) = _.Ticks
                    let v301 : int64 = v300 v297
                    let v304 : int64 = v301 - v296
                    let v305 : (int64 -> System.TimeSpan) = System.TimeSpan 
                    let v306 : System.TimeSpan = v305 v304
                    let v309 : (System.TimeSpan -> int32) = _.Hours
                    let v310 : int32 = v309 v306
                    let v313 : (System.TimeSpan -> int32) = _.Minutes
                    let v314 : int32 = v313 v306
                    let v317 : (System.TimeSpan -> int32) = _.Seconds
                    let v318 : int32 = v317 v306
                    let v321 : (System.TimeSpan -> int32) = _.Milliseconds
                    let v322 : int32 = v321 v306
                    let v325 : System.DateTime = System.DateTime (1, 1, 1, v310, v314, v318, v322)
                    v325
            let v333 : string = method10()
            let v336 : (string -> string) = v332.ToString
            let v337 : string = v336 v333
            let _v113 = v337 
            #endif
#if FABLE_COMPILER_PYTHON
            let v340 : US3 option = None
            let _v340 = ref v340 
            match v102 with
            | Some x -> (
            (fun () ->
            (fun () ->
            let v341 : int64 = x
            let v342 : US3 = US3_0(v341)
            v342 
            )
            |> fun x -> x () |> Some
            ) () ) | None -> None
            |> fun x -> _v340.Value <- x
            let v343 : US3 option = _v340.Value 
            let v354 : US3 = US3_1
            let v355 : US3 = v343 |> Option.defaultValue v354 
            let v395 : System.DateTime =
                match v355 with
                | US3_1 -> (* None *)
                    let v391 : System.DateTime = System.DateTime.Now
                    v391
                | US3_0(v359) -> (* Some *)
                    let v360 : System.DateTime = System.DateTime.Now
                    let v363 : (System.DateTime -> int64) = _.Ticks
                    let v364 : int64 = v363 v360
                    let v367 : int64 = v364 - v359
                    let v368 : (int64 -> System.TimeSpan) = System.TimeSpan 
                    let v369 : System.TimeSpan = v368 v367
                    let v372 : (System.TimeSpan -> int32) = _.Hours
                    let v373 : int32 = v372 v369
                    let v376 : (System.TimeSpan -> int32) = _.Minutes
                    let v377 : int32 = v376 v369
                    let v380 : (System.TimeSpan -> int32) = _.Seconds
                    let v381 : int32 = v380 v369
                    let v384 : (System.TimeSpan -> int32) = _.Milliseconds
                    let v385 : int32 = v384 v369
                    let v388 : System.DateTime = System.DateTime (1, 1, 1, v373, v377, v381, v385)
                    v388
            let v396 : string = method10()
            let v399 : (string -> string) = v395.ToString
            let v400 : string = v399 v396
            let _v113 = v400 
            #endif
#else
            let v403 : US3 option = None
            let _v403 = ref v403 
            match v102 with
            | Some x -> (
            (fun () ->
            (fun () ->
            let v404 : int64 = x
            let v405 : US3 = US3_0(v404)
            v405 
            )
            |> fun x -> x () |> Some
            ) () ) | None -> None
            |> fun x -> _v403.Value <- x
            let v406 : US3 option = _v403.Value 
            let v417 : US3 = US3_1
            let v418 : US3 = v406 |> Option.defaultValue v417 
            let v458 : System.DateTime =
                match v418 with
                | US3_1 -> (* None *)
                    let v454 : System.DateTime = System.DateTime.Now
                    v454
                | US3_0(v422) -> (* Some *)
                    let v423 : System.DateTime = System.DateTime.Now
                    let v426 : (System.DateTime -> int64) = _.Ticks
                    let v427 : int64 = v426 v423
                    let v430 : int64 = v427 - v422
                    let v431 : (int64 -> System.TimeSpan) = System.TimeSpan 
                    let v432 : System.TimeSpan = v431 v430
                    let v435 : (System.TimeSpan -> int32) = _.Hours
                    let v436 : int32 = v435 v432
                    let v439 : (System.TimeSpan -> int32) = _.Minutes
                    let v440 : int32 = v439 v432
                    let v443 : (System.TimeSpan -> int32) = _.Seconds
                    let v444 : int32 = v443 v432
                    let v447 : (System.TimeSpan -> int32) = _.Milliseconds
                    let v448 : int32 = v447 v432
                    let v451 : System.DateTime = System.DateTime (1, 1, 1, v436, v440, v444, v448)
                    v451
            let v459 : string = method10()
            let v462 : (string -> string) = v458.ToString
            let v463 : string = v462 v459
            let _v113 = v463 
            #endif
            let v466 : string = _v113 
            let v531 : string = "Warning"
            let v532 : (unit -> string) = v531.ToLower
            let v533 : string = v532 ()
            let v536 : string = v533.PadLeft (7, ' ')
            let v550 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v551 : string = "inline_colorization::color_yellow"
            let v552 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v551 
            let v553 : string = "&*$0"
            let v554 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v536 v553 
            let v555 : string = "inline_colorization::color_reset"
            let v556 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v555 
            let v557 : string = "\"{v552}{v554}{v556}\""
            let v558 : string = @$"format!(" + v557 + ")"
            let v559 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v558 
            let v560 : string = "fable_library_rust::String_::fromString($0)"
            let v561 : string = Fable.Core.RustInterop.emitRustExpr v559 v560 
            let _v550 = v561 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v562 : string = "inline_colorization::color_yellow"
            let v563 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v562 
            let v564 : string = "&*$0"
            let v565 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v536 v564 
            let v566 : string = "inline_colorization::color_reset"
            let v567 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v566 
            let v568 : string = "\"{v563}{v565}{v567}\""
            let v569 : string = @$"format!(" + v568 + ")"
            let v570 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v569 
            let v571 : string = "fable_library_rust::String_::fromString($0)"
            let v572 : string = Fable.Core.RustInterop.emitRustExpr v570 v571 
            let _v550 = v572 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v573 : string = "inline_colorization::color_yellow"
            let v574 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v573 
            let v575 : string = "&*$0"
            let v576 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v536 v575 
            let v577 : string = "inline_colorization::color_reset"
            let v578 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v577 
            let v579 : string = "\"{v574}{v576}{v578}\""
            let v580 : string = @$"format!(" + v579 + ")"
            let v581 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v580 
            let v582 : string = "fable_library_rust::String_::fromString($0)"
            let v583 : string = Fable.Core.RustInterop.emitRustExpr v581 v582 
            let _v550 = v583 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v584 : string = "\u001b[93m"
            let v585 : string = method11()
            let v586 : string = v584 + v536 
            let v587 : string = v586 + v585 
            let _v550 = v587 
            #endif
#if FABLE_COMPILER_PYTHON
            let v588 : string = "\u001b[93m"
            let v589 : string = method11()
            let v590 : string = v588 + v536 
            let v591 : string = v590 + v589 
            let _v550 = v591 
            #endif
#else
            let v592 : string = "\u001b[93m"
            let v593 : string = method11()
            let v594 : string = v592 + v536 
            let v595 : string = v594 + v593 
            let _v550 = v595 
            #endif
            let v596 : string = _v550 
            let v602 : int64 = v98.l0
            let v603 : string = method12(v1)
            let v604 : string = method12(v0)
            let v605 : string = method13()
            let v606 : Mut4 = {l0 = v605} : Mut4
            let v607 : string = "{ "
            let v608 : string = $"{v607}"
            let v611 : string = v606.l0
            let v612 : string = v611 + v608 
            v606.l0 <- v612
            let v613 : string = "old_path"
            let v614 : string = $"{v613}"
            let v617 : string = v606.l0
            let v618 : string = v617 + v614 
            v606.l0 <- v618
            let v619 : string = " = "
            let v620 : string = $"{v619}"
            let v623 : string = v606.l0
            let v624 : string = v623 + v620 
            v606.l0 <- v624
            let v625 : string = $"{v603}"
            let v628 : string = v606.l0
            let v629 : string = v628 + v625 
            v606.l0 <- v629
            let v630 : string = "; "
            let v631 : string = $"{v630}"
            let v634 : string = v606.l0
            let v635 : string = v634 + v631 
            v606.l0 <- v635
            let v636 : string = "new_path"
            let v637 : string = $"{v636}"
            let v640 : string = v606.l0
            let v641 : string = v640 + v637 
            v606.l0 <- v641
            let v642 : string = $"{v619}"
            let v645 : string = v606.l0
            let v646 : string = v645 + v642 
            v606.l0 <- v646
            let v647 : string = $"{v604}"
            let v650 : string = v606.l0
            let v651 : string = v650 + v647 
            v606.l0 <- v651
            let v652 : string = $"{v630}"
            let v655 : string = v606.l0
            let v656 : string = v655 + v652 
            v606.l0 <- v656
            let v657 : string = "ex"
            let v658 : string = $"{v657}"
            let v661 : string = v606.l0
            let v662 : string = v661 + v658 
            v606.l0 <- v662
            let v663 : string = $"{v619}"
            let v666 : string = v606.l0
            let v667 : string = v666 + v663 
            v606.l0 <- v667
            let v668 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v669 : string = "format!(\"{:#?}\", $0)"
            let v670 : std_string_String = Fable.Core.RustInterop.emitRustExpr v21 v669 
            let v671 : string = "fable_library_rust::String_::fromString($0)"
            let v672 : string = Fable.Core.RustInterop.emitRustExpr v670 v671 
            let _v668 = v672 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v673 : string = "format!(\"{:#?}\", $0)"
            let v674 : std_string_String = Fable.Core.RustInterop.emitRustExpr v21 v673 
            let v675 : string = "fable_library_rust::String_::fromString($0)"
            let v676 : string = Fable.Core.RustInterop.emitRustExpr v674 v675 
            let _v668 = v676 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v677 : string = "format!(\"{:#?}\", $0)"
            let v678 : std_string_String = Fable.Core.RustInterop.emitRustExpr v21 v677 
            let v679 : string = "fable_library_rust::String_::fromString($0)"
            let v680 : string = Fable.Core.RustInterop.emitRustExpr v678 v679 
            let _v668 = v680 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v681 : string = $"%A{v21}"
            let _v668 = v681 
            #endif
#if FABLE_COMPILER_PYTHON
            let v684 : string = $"%A{v21}"
            let _v668 = v684 
            #endif
#else
            let v687 : string = $"%A{v21}"
            let _v668 = v687 
            #endif
            let v690 : string = _v668 
            let v695 : string = $"{v690}"
            let v698 : string = v606.l0
            let v699 : string = v698 + v695 
            v606.l0 <- v699
            let v700 : string = " }"
            let v701 : string = $"{v700}"
            let v704 : string = v606.l0
            let v705 : string = v704 + v701 
            v606.l0 <- v705
            let v706 : string = v606.l0
            let v707 : (unit -> string) = closure18()
            let v708 : string = $"{v466} {v596} #{v602} %s{v707 ()} / {v706}"
            let v711 : char list = []
            let v712 : (char list -> (char [])) = List.toArray
            let v713 : (char []) = v712 v711
            let v716 : string = v708.TrimStart v713 
            let v734 : char list = []
            let v735 : char list = '/' :: v734 
            let v738 : char list = ' ' :: v735 
            let v741 : (char list -> (char [])) = List.toArray
            let v742 : (char []) = v741 v738
            let v745 : string = v716.TrimEnd v742 
            let v763 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v764 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v745 v764 
            let _v763 = () 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v765 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v745 v765 
            let _v763 = () 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v766 : string = $"near_sdk::log!(\"{{}}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v745 v766 
            let _v763 = () 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            System.Console.WriteLine v745 
            let _v763 = () 
            #endif
#if FABLE_COMPILER_PYTHON
            System.Console.WriteLine v745 
            let _v763 = () 
            #endif
#else
            System.Console.WriteLine v745 
            let _v763 = () 
            #endif
            _v763 
            let v767 : (string -> unit) = v37.l0
            v767 v745
    let v768 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v769 : Async<unit> = null |> unbox<Async<unit>>
    let _v768 = v769 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v772 : Async<unit> = null |> unbox<Async<unit>>
    let _v768 = v772 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v775 : Async<unit> = null |> unbox<Async<unit>>
    let _v768 = v775 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v778 : Async<unit> = null |> unbox<Async<unit>>
    let _v768 = v778 
    #endif
#if FABLE_COMPILER_PYTHON
    let v781 : Async<unit> = null |> unbox<Async<unit>>
    let _v768 = v781 
    #endif
#else
    let v784 : (int32 -> Async<unit>) = Async.Sleep
    let v785 : Async<unit> = v784 10
    let _v768 = v785 
    #endif
    let v786 : Async<unit> = _v768 
    do! v786 
    let v791 : int64 = v2 + 1L
    let v792 : Async<int64> = method20(v0, v1, v791)
    return! v792 
    (*
    *)
    }
    |> fun x -> _v19 <- Some x
    let v793 : Async<int64> = match _v19 with Some x -> x | None -> failwith "async.new_async_unit / _v19=None"
    let _v3 = v793 
    #endif
    let v794 : Async<int64> = _v3 
    v794
and closure17 (v0 : string) (v1 : string) : Async<int64> =
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
and closure16 () (v0 : string) : (string -> Async<int64>) =
    closure17(v0)
and closure20 () (v0 : int64) : US9 =
    US9_0(v0)
and closure21 () (v0 : exn) : US9 =
    US9_1(v0)
and closure22 () () : string =
    let v0 : string = "async.run_with_timeout_async"
    v0
and closure23 () () : string =
    let v0 : string = $"async.run_with_timeout_async**"
    v0
and closure24 () () : string =
    let v0 : string = "read_all_text_retry_async"
    v0
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
        let v156 : (int64 -> US9) = closure20()
        let v157 : (exn -> US9) = closure21()
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
        let v1620 : US3 =
            match v217 with
            | US10_1(v220) -> (* Error *)
                let v221 : string = $"%A{v220}"
                let v224 : string = "System.TimeoutException"
                let v225 : bool = v221.Contains v224 
                if v225 then
                    let v228 : bool = State.trace_state.IsNone
                    if v228 then
                        let v229 : US0 = US0_0
                        let struct (v230 : Mut0, v231 : Mut1, v232 : Mut2, v233 : Mut3, v234 : int64 option) = method0(v229)
                        let v235 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v230, v231, v232, v233, v234) 
                        State.trace_state <- v235 
                        ()
                    let struct (v240 : Mut0, v241 : Mut1, v242 : Mut2, v243 : Mut3, v244 : int64 option) = State.trace_state.Value
                    let v255 : bool = State.trace_state.IsNone
                    if v255 then
                        let v256 : US0 = US0_0
                        let struct (v257 : Mut0, v258 : Mut1, v259 : Mut2, v260 : Mut3, v261 : int64 option) = method0(v256)
                        let v262 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v257, v258, v259, v260, v261) 
                        State.trace_state <- v262 
                        ()
                    let struct (v267 : Mut0, v268 : Mut1, v269 : Mut2, v270 : Mut3, v271 : int64 option) = State.trace_state.Value
                    let v282 : US0 = v270.l0
                    let v283 : bool = v269.l0
                    let v284 : bool = v283 = false
                    let v287 : bool =
                        if v284 then
                            false
                        else
                            let v285 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v282
                            let v286 : bool = 0 >= v285
                            v286
                    if v287 then
                        let v288 : int64 = v240.l0
                        let v289 : int64 = v288 + 1L
                        v240.l0 <- v289
                        let v290 : bool = State.trace_state.IsNone
                        if v290 then
                            let v291 : US0 = US0_0
                            let struct (v292 : Mut0, v293 : Mut1, v294 : Mut2, v295 : Mut3, v296 : int64 option) = method0(v291)
                            let v297 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v292, v293, v294, v295, v296) 
                            State.trace_state <- v297 
                            ()
                        let struct (v302 : Mut0, v303 : Mut1, v304 : Mut2, v305 : Mut3, v306 : int64 option) = State.trace_state.Value
                        let v317 : unit = ()
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v318 : US3 option = None
                        let _v318 = ref v318 
                        match v306 with
                        | Some x -> (
                        (fun () ->
                        (fun () ->
                        let v319 : int64 = x
                        let v320 : US3 = US3_0(v319)
                        v320 
                        )
                        |> fun x -> x () |> Some
                        ) () ) | None -> None
                        |> fun x -> _v318.Value <- x
                        let v321 : US3 option = _v318.Value 
                        let v332 : US3 = US3_1
                        let v333 : US3 = v321 |> Option.defaultValue v332 
                        let v373 : System.DateTime =
                            match v333 with
                            | US3_1 -> (* None *)
                                let v369 : System.DateTime = System.DateTime.Now
                                v369
                            | US3_0(v337) -> (* Some *)
                                let v338 : System.DateTime = System.DateTime.Now
                                let v341 : (System.DateTime -> int64) = _.Ticks
                                let v342 : int64 = v341 v338
                                let v345 : int64 = v342 - v337
                                let v346 : (int64 -> System.TimeSpan) = System.TimeSpan 
                                let v347 : System.TimeSpan = v346 v345
                                let v350 : (System.TimeSpan -> int32) = _.Hours
                                let v351 : int32 = v350 v347
                                let v354 : (System.TimeSpan -> int32) = _.Minutes
                                let v355 : int32 = v354 v347
                                let v358 : (System.TimeSpan -> int32) = _.Seconds
                                let v359 : int32 = v358 v347
                                let v362 : (System.TimeSpan -> int32) = _.Milliseconds
                                let v363 : int32 = v362 v347
                                let v366 : System.DateTime = System.DateTime (1, 1, 1, v351, v355, v359, v363)
                                v366
                        let v374 : string = method9()
                        let v377 : (string -> string) = v373.ToString
                        let v378 : string = v377 v374
                        let _v317 = v378 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        let v381 : US3 option = None
                        let _v381 = ref v381 
                        match v306 with
                        | Some x -> (
                        (fun () ->
                        (fun () ->
                        let v382 : int64 = x
                        let v383 : US3 = US3_0(v382)
                        v383 
                        )
                        |> fun x -> x () |> Some
                        ) () ) | None -> None
                        |> fun x -> _v381.Value <- x
                        let v384 : US3 option = _v381.Value 
                        let v395 : US3 = US3_1
                        let v396 : US3 = v384 |> Option.defaultValue v395 
                        let v436 : System.DateTime =
                            match v396 with
                            | US3_1 -> (* None *)
                                let v432 : System.DateTime = System.DateTime.Now
                                v432
                            | US3_0(v400) -> (* Some *)
                                let v401 : System.DateTime = System.DateTime.Now
                                let v404 : (System.DateTime -> int64) = _.Ticks
                                let v405 : int64 = v404 v401
                                let v408 : int64 = v405 - v400
                                let v409 : (int64 -> System.TimeSpan) = System.TimeSpan 
                                let v410 : System.TimeSpan = v409 v408
                                let v413 : (System.TimeSpan -> int32) = _.Hours
                                let v414 : int32 = v413 v410
                                let v417 : (System.TimeSpan -> int32) = _.Minutes
                                let v418 : int32 = v417 v410
                                let v421 : (System.TimeSpan -> int32) = _.Seconds
                                let v422 : int32 = v421 v410
                                let v425 : (System.TimeSpan -> int32) = _.Milliseconds
                                let v426 : int32 = v425 v410
                                let v429 : System.DateTime = System.DateTime (1, 1, 1, v414, v418, v422, v426)
                                v429
                        let v437 : string = method9()
                        let v440 : (string -> string) = v436.ToString
                        let v441 : string = v440 v437
                        let _v317 = v441 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        let v444 : string = $"near_sdk::env::block_timestamp()"
                        let v445 : uint64 = Fable.Core.RustInterop.emitRustExpr () v444 
                        let v446 : US3 option = None
                        let _v446 = ref v446 
                        match v306 with
                        | Some x -> (
                        (fun () ->
                        (fun () ->
                        let v447 : int64 = x
                        let v448 : US3 = US3_0(v447)
                        v448 
                        )
                        |> fun x -> x () |> Some
                        ) () ) | None -> None
                        |> fun x -> _v446.Value <- x
                        let v449 : US3 option = _v446.Value 
                        let v460 : US3 = US3_1
                        let v461 : US3 = v449 |> Option.defaultValue v460 
                        let v470 : uint64 =
                            match v461 with
                            | US3_1 -> (* None *)
                                v445
                            | US3_0(v465) -> (* Some *)
                                let v466 : (int64 -> uint64) = uint64
                                let v467 : uint64 = v466 v465
                                let v468 : uint64 = v445 - v467
                                v468
                        let v471 : uint64 = v470 / 1000000000UL
                        let v472 : uint64 = v471 % 60UL
                        let v473 : uint64 = v471 / 60UL
                        let v474 : uint64 = v473 % 60UL
                        let v475 : uint64 = v471 / 3600UL
                        let v476 : uint64 = v475 % 24UL
                        let v477 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
                        let v478 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v476, v474, v472) v477 
                        let v479 : string = "fable_library_rust::String_::fromString($0)"
                        let v480 : string = Fable.Core.RustInterop.emitRustExpr v478 v479 
                        let _v317 = v480 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        let v481 : US3 option = None
                        let _v481 = ref v481 
                        match v306 with
                        | Some x -> (
                        (fun () ->
                        (fun () ->
                        let v482 : int64 = x
                        let v483 : US3 = US3_0(v482)
                        v483 
                        )
                        |> fun x -> x () |> Some
                        ) () ) | None -> None
                        |> fun x -> _v481.Value <- x
                        let v484 : US3 option = _v481.Value 
                        let v495 : US3 = US3_1
                        let v496 : US3 = v484 |> Option.defaultValue v495 
                        let v536 : System.DateTime =
                            match v496 with
                            | US3_1 -> (* None *)
                                let v532 : System.DateTime = System.DateTime.Now
                                v532
                            | US3_0(v500) -> (* Some *)
                                let v501 : System.DateTime = System.DateTime.Now
                                let v504 : (System.DateTime -> int64) = _.Ticks
                                let v505 : int64 = v504 v501
                                let v508 : int64 = v505 - v500
                                let v509 : (int64 -> System.TimeSpan) = System.TimeSpan 
                                let v510 : System.TimeSpan = v509 v508
                                let v513 : (System.TimeSpan -> int32) = _.Hours
                                let v514 : int32 = v513 v510
                                let v517 : (System.TimeSpan -> int32) = _.Minutes
                                let v518 : int32 = v517 v510
                                let v521 : (System.TimeSpan -> int32) = _.Seconds
                                let v522 : int32 = v521 v510
                                let v525 : (System.TimeSpan -> int32) = _.Milliseconds
                                let v526 : int32 = v525 v510
                                let v529 : System.DateTime = System.DateTime (1, 1, 1, v514, v518, v522, v526)
                                v529
                        let v537 : string = method10()
                        let v540 : (string -> string) = v536.ToString
                        let v541 : string = v540 v537
                        let _v317 = v541 
                        #endif
#if FABLE_COMPILER_PYTHON
                        let v544 : US3 option = None
                        let _v544 = ref v544 
                        match v306 with
                        | Some x -> (
                        (fun () ->
                        (fun () ->
                        let v545 : int64 = x
                        let v546 : US3 = US3_0(v545)
                        v546 
                        )
                        |> fun x -> x () |> Some
                        ) () ) | None -> None
                        |> fun x -> _v544.Value <- x
                        let v547 : US3 option = _v544.Value 
                        let v558 : US3 = US3_1
                        let v559 : US3 = v547 |> Option.defaultValue v558 
                        let v599 : System.DateTime =
                            match v559 with
                            | US3_1 -> (* None *)
                                let v595 : System.DateTime = System.DateTime.Now
                                v595
                            | US3_0(v563) -> (* Some *)
                                let v564 : System.DateTime = System.DateTime.Now
                                let v567 : (System.DateTime -> int64) = _.Ticks
                                let v568 : int64 = v567 v564
                                let v571 : int64 = v568 - v563
                                let v572 : (int64 -> System.TimeSpan) = System.TimeSpan 
                                let v573 : System.TimeSpan = v572 v571
                                let v576 : (System.TimeSpan -> int32) = _.Hours
                                let v577 : int32 = v576 v573
                                let v580 : (System.TimeSpan -> int32) = _.Minutes
                                let v581 : int32 = v580 v573
                                let v584 : (System.TimeSpan -> int32) = _.Seconds
                                let v585 : int32 = v584 v573
                                let v588 : (System.TimeSpan -> int32) = _.Milliseconds
                                let v589 : int32 = v588 v573
                                let v592 : System.DateTime = System.DateTime (1, 1, 1, v577, v581, v585, v589)
                                v592
                        let v600 : string = method10()
                        let v603 : (string -> string) = v599.ToString
                        let v604 : string = v603 v600
                        let _v317 = v604 
                        #endif
#else
                        let v607 : US3 option = None
                        let _v607 = ref v607 
                        match v306 with
                        | Some x -> (
                        (fun () ->
                        (fun () ->
                        let v608 : int64 = x
                        let v609 : US3 = US3_0(v608)
                        v609 
                        )
                        |> fun x -> x () |> Some
                        ) () ) | None -> None
                        |> fun x -> _v607.Value <- x
                        let v610 : US3 option = _v607.Value 
                        let v621 : US3 = US3_1
                        let v622 : US3 = v610 |> Option.defaultValue v621 
                        let v662 : System.DateTime =
                            match v622 with
                            | US3_1 -> (* None *)
                                let v658 : System.DateTime = System.DateTime.Now
                                v658
                            | US3_0(v626) -> (* Some *)
                                let v627 : System.DateTime = System.DateTime.Now
                                let v630 : (System.DateTime -> int64) = _.Ticks
                                let v631 : int64 = v630 v627
                                let v634 : int64 = v631 - v626
                                let v635 : (int64 -> System.TimeSpan) = System.TimeSpan 
                                let v636 : System.TimeSpan = v635 v634
                                let v639 : (System.TimeSpan -> int32) = _.Hours
                                let v640 : int32 = v639 v636
                                let v643 : (System.TimeSpan -> int32) = _.Minutes
                                let v644 : int32 = v643 v636
                                let v647 : (System.TimeSpan -> int32) = _.Seconds
                                let v648 : int32 = v647 v636
                                let v651 : (System.TimeSpan -> int32) = _.Milliseconds
                                let v652 : int32 = v651 v636
                                let v655 : System.DateTime = System.DateTime (1, 1, 1, v640, v644, v648, v652)
                                v655
                        let v663 : string = method10()
                        let v666 : (string -> string) = v662.ToString
                        let v667 : string = v666 v663
                        let _v317 = v667 
                        #endif
                        let v670 : string = _v317 
                        let v735 : string = "Verbose"
                        let v736 : (unit -> string) = v735.ToLower
                        let v737 : string = v736 ()
                        let v740 : string = v737.PadLeft (7, ' ')
                        let v754 : unit = ()
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v755 : string = "inline_colorization::color_bright_black"
                        let v756 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v755 
                        let v757 : string = "&*$0"
                        let v758 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v740 v757 
                        let v759 : string = "inline_colorization::color_reset"
                        let v760 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v759 
                        let v761 : string = "\"{v756}{v758}{v760}\""
                        let v762 : string = @$"format!(" + v761 + ")"
                        let v763 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v762 
                        let v764 : string = "fable_library_rust::String_::fromString($0)"
                        let v765 : string = Fable.Core.RustInterop.emitRustExpr v763 v764 
                        let _v754 = v765 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        let v766 : string = "inline_colorization::color_bright_black"
                        let v767 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v766 
                        let v768 : string = "&*$0"
                        let v769 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v740 v768 
                        let v770 : string = "inline_colorization::color_reset"
                        let v771 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v770 
                        let v772 : string = "\"{v767}{v769}{v771}\""
                        let v773 : string = @$"format!(" + v772 + ")"
                        let v774 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v773 
                        let v775 : string = "fable_library_rust::String_::fromString($0)"
                        let v776 : string = Fable.Core.RustInterop.emitRustExpr v774 v775 
                        let _v754 = v776 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        let v777 : string = "inline_colorization::color_bright_black"
                        let v778 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v777 
                        let v779 : string = "&*$0"
                        let v780 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v740 v779 
                        let v781 : string = "inline_colorization::color_reset"
                        let v782 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v781 
                        let v783 : string = "\"{v778}{v780}{v782}\""
                        let v784 : string = @$"format!(" + v783 + ")"
                        let v785 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v784 
                        let v786 : string = "fable_library_rust::String_::fromString($0)"
                        let v787 : string = Fable.Core.RustInterop.emitRustExpr v785 v786 
                        let _v754 = v787 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        let v788 : string = "\u001b[90m"
                        let v789 : string = method11()
                        let v790 : string = v788 + v740 
                        let v791 : string = v790 + v789 
                        let _v754 = v791 
                        #endif
#if FABLE_COMPILER_PYTHON
                        let v792 : string = "\u001b[90m"
                        let v793 : string = method11()
                        let v794 : string = v792 + v740 
                        let v795 : string = v794 + v793 
                        let _v754 = v795 
                        #endif
#else
                        let v796 : string = "\u001b[90m"
                        let v797 : string = method11()
                        let v798 : string = v796 + v740 
                        let v799 : string = v798 + v797 
                        let _v754 = v799 
                        #endif
                        let v800 : string = _v754 
                        let v806 : int64 = v302.l0
                        let v807 : string = method13()
                        let v808 : Mut4 = {l0 = v807} : Mut4
                        let v809 : string = "{ "
                        let v810 : string = $"{v809}"
                        let v813 : string = v808.l0
                        let v814 : string = v813 + v810 
                        v808.l0 <- v814
                        let v815 : string = "timeout"
                        let v816 : string = $"{v815}"
                        let v819 : string = v808.l0
                        let v820 : string = v819 + v816 
                        v808.l0 <- v820
                        let v821 : string = " = "
                        let v822 : string = $"{v821}"
                        let v825 : string = v808.l0
                        let v826 : string = v825 + v822 
                        v808.l0 <- v826
                        let v827 : string = $"{1000}"
                        let v830 : string = v808.l0
                        let v831 : string = v830 + v827 
                        v808.l0 <- v831
                        let v832 : string = " }"
                        let v833 : string = $"{v832}"
                        let v836 : string = v808.l0
                        let v837 : string = v836 + v833 
                        v808.l0 <- v837
                        let v838 : string = v808.l0
                        let v839 : (unit -> string) = closure22()
                        let v840 : string = $"{v670} {v800} #{v806} %s{v839 ()} / {v838}"
                        let v843 : char list = []
                        let v844 : (char list -> (char [])) = List.toArray
                        let v845 : (char []) = v844 v843
                        let v848 : string = v840.TrimStart v845 
                        let v866 : char list = []
                        let v867 : char list = '/' :: v866 
                        let v870 : char list = ' ' :: v867 
                        let v873 : (char list -> (char [])) = List.toArray
                        let v874 : (char []) = v873 v870
                        let v877 : string = v848.TrimEnd v874 
                        let v895 : unit = ()
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v896 : string = @"println!(""{}"", $0)"
                        Fable.Core.RustInterop.emitRustExpr v877 v896 
                        let _v895 = () 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        let v897 : string = @"println!(""{}"", $0)"
                        Fable.Core.RustInterop.emitRustExpr v877 v897 
                        let _v895 = () 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        let v898 : string = $"near_sdk::log!(\"{{}}\", $0)"
                        Fable.Core.RustInterop.emitRustExpr v877 v898 
                        let _v895 = () 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        System.Console.WriteLine v877 
                        let _v895 = () 
                        #endif
#if FABLE_COMPILER_PYTHON
                        System.Console.WriteLine v877 
                        let _v895 = () 
                        #endif
#else
                        System.Console.WriteLine v877 
                        let _v895 = () 
                        #endif
                        _v895 
                        let v899 : (string -> unit) = v241.l0
                        v899 v877
                    US3_1
                else
                    let v901 : bool = State.trace_state.IsNone
                    if v901 then
                        let v902 : US0 = US0_0
                        let struct (v903 : Mut0, v904 : Mut1, v905 : Mut2, v906 : Mut3, v907 : int64 option) = method0(v902)
                        let v908 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v903, v904, v905, v906, v907) 
                        State.trace_state <- v908 
                        ()
                    let struct (v913 : Mut0, v914 : Mut1, v915 : Mut2, v916 : Mut3, v917 : int64 option) = State.trace_state.Value
                    let v928 : bool = State.trace_state.IsNone
                    if v928 then
                        let v929 : US0 = US0_0
                        let struct (v930 : Mut0, v931 : Mut1, v932 : Mut2, v933 : Mut3, v934 : int64 option) = method0(v929)
                        let v935 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v930, v931, v932, v933, v934) 
                        State.trace_state <- v935 
                        ()
                    let struct (v940 : Mut0, v941 : Mut1, v942 : Mut2, v943 : Mut3, v944 : int64 option) = State.trace_state.Value
                    let v955 : US0 = v943.l0
                    let v956 : bool = v942.l0
                    let v957 : bool = v956 = false
                    let v960 : bool =
                        if v957 then
                            false
                        else
                            let v958 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v955
                            let v959 : bool = 4 >= v958
                            v959
                    if v960 then
                        let v961 : int64 = v913.l0
                        let v962 : int64 = v961 + 1L
                        v913.l0 <- v962
                        let v963 : bool = State.trace_state.IsNone
                        if v963 then
                            let v964 : US0 = US0_0
                            let struct (v965 : Mut0, v966 : Mut1, v967 : Mut2, v968 : Mut3, v969 : int64 option) = method0(v964)
                            let v970 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v965, v966, v967, v968, v969) 
                            State.trace_state <- v970 
                            ()
                        let struct (v975 : Mut0, v976 : Mut1, v977 : Mut2, v978 : Mut3, v979 : int64 option) = State.trace_state.Value
                        let v990 : unit = ()
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v991 : US3 option = None
                        let _v991 = ref v991 
                        match v979 with
                        | Some x -> (
                        (fun () ->
                        (fun () ->
                        let v992 : int64 = x
                        let v993 : US3 = US3_0(v992)
                        v993 
                        )
                        |> fun x -> x () |> Some
                        ) () ) | None -> None
                        |> fun x -> _v991.Value <- x
                        let v994 : US3 option = _v991.Value 
                        let v1005 : US3 = US3_1
                        let v1006 : US3 = v994 |> Option.defaultValue v1005 
                        let v1046 : System.DateTime =
                            match v1006 with
                            | US3_1 -> (* None *)
                                let v1042 : System.DateTime = System.DateTime.Now
                                v1042
                            | US3_0(v1010) -> (* Some *)
                                let v1011 : System.DateTime = System.DateTime.Now
                                let v1014 : (System.DateTime -> int64) = _.Ticks
                                let v1015 : int64 = v1014 v1011
                                let v1018 : int64 = v1015 - v1010
                                let v1019 : (int64 -> System.TimeSpan) = System.TimeSpan 
                                let v1020 : System.TimeSpan = v1019 v1018
                                let v1023 : (System.TimeSpan -> int32) = _.Hours
                                let v1024 : int32 = v1023 v1020
                                let v1027 : (System.TimeSpan -> int32) = _.Minutes
                                let v1028 : int32 = v1027 v1020
                                let v1031 : (System.TimeSpan -> int32) = _.Seconds
                                let v1032 : int32 = v1031 v1020
                                let v1035 : (System.TimeSpan -> int32) = _.Milliseconds
                                let v1036 : int32 = v1035 v1020
                                let v1039 : System.DateTime = System.DateTime (1, 1, 1, v1024, v1028, v1032, v1036)
                                v1039
                        let v1047 : string = method9()
                        let v1050 : (string -> string) = v1046.ToString
                        let v1051 : string = v1050 v1047
                        let _v990 = v1051 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        let v1054 : US3 option = None
                        let _v1054 = ref v1054 
                        match v979 with
                        | Some x -> (
                        (fun () ->
                        (fun () ->
                        let v1055 : int64 = x
                        let v1056 : US3 = US3_0(v1055)
                        v1056 
                        )
                        |> fun x -> x () |> Some
                        ) () ) | None -> None
                        |> fun x -> _v1054.Value <- x
                        let v1057 : US3 option = _v1054.Value 
                        let v1068 : US3 = US3_1
                        let v1069 : US3 = v1057 |> Option.defaultValue v1068 
                        let v1109 : System.DateTime =
                            match v1069 with
                            | US3_1 -> (* None *)
                                let v1105 : System.DateTime = System.DateTime.Now
                                v1105
                            | US3_0(v1073) -> (* Some *)
                                let v1074 : System.DateTime = System.DateTime.Now
                                let v1077 : (System.DateTime -> int64) = _.Ticks
                                let v1078 : int64 = v1077 v1074
                                let v1081 : int64 = v1078 - v1073
                                let v1082 : (int64 -> System.TimeSpan) = System.TimeSpan 
                                let v1083 : System.TimeSpan = v1082 v1081
                                let v1086 : (System.TimeSpan -> int32) = _.Hours
                                let v1087 : int32 = v1086 v1083
                                let v1090 : (System.TimeSpan -> int32) = _.Minutes
                                let v1091 : int32 = v1090 v1083
                                let v1094 : (System.TimeSpan -> int32) = _.Seconds
                                let v1095 : int32 = v1094 v1083
                                let v1098 : (System.TimeSpan -> int32) = _.Milliseconds
                                let v1099 : int32 = v1098 v1083
                                let v1102 : System.DateTime = System.DateTime (1, 1, 1, v1087, v1091, v1095, v1099)
                                v1102
                        let v1110 : string = method9()
                        let v1113 : (string -> string) = v1109.ToString
                        let v1114 : string = v1113 v1110
                        let _v990 = v1114 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        let v1117 : string = $"near_sdk::env::block_timestamp()"
                        let v1118 : uint64 = Fable.Core.RustInterop.emitRustExpr () v1117 
                        let v1119 : US3 option = None
                        let _v1119 = ref v1119 
                        match v979 with
                        | Some x -> (
                        (fun () ->
                        (fun () ->
                        let v1120 : int64 = x
                        let v1121 : US3 = US3_0(v1120)
                        v1121 
                        )
                        |> fun x -> x () |> Some
                        ) () ) | None -> None
                        |> fun x -> _v1119.Value <- x
                        let v1122 : US3 option = _v1119.Value 
                        let v1133 : US3 = US3_1
                        let v1134 : US3 = v1122 |> Option.defaultValue v1133 
                        let v1143 : uint64 =
                            match v1134 with
                            | US3_1 -> (* None *)
                                v1118
                            | US3_0(v1138) -> (* Some *)
                                let v1139 : (int64 -> uint64) = uint64
                                let v1140 : uint64 = v1139 v1138
                                let v1141 : uint64 = v1118 - v1140
                                v1141
                        let v1144 : uint64 = v1143 / 1000000000UL
                        let v1145 : uint64 = v1144 % 60UL
                        let v1146 : uint64 = v1144 / 60UL
                        let v1147 : uint64 = v1146 % 60UL
                        let v1148 : uint64 = v1144 / 3600UL
                        let v1149 : uint64 = v1148 % 24UL
                        let v1150 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
                        let v1151 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v1149, v1147, v1145) v1150 
                        let v1152 : string = "fable_library_rust::String_::fromString($0)"
                        let v1153 : string = Fable.Core.RustInterop.emitRustExpr v1151 v1152 
                        let _v990 = v1153 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        let v1154 : US3 option = None
                        let _v1154 = ref v1154 
                        match v979 with
                        | Some x -> (
                        (fun () ->
                        (fun () ->
                        let v1155 : int64 = x
                        let v1156 : US3 = US3_0(v1155)
                        v1156 
                        )
                        |> fun x -> x () |> Some
                        ) () ) | None -> None
                        |> fun x -> _v1154.Value <- x
                        let v1157 : US3 option = _v1154.Value 
                        let v1168 : US3 = US3_1
                        let v1169 : US3 = v1157 |> Option.defaultValue v1168 
                        let v1209 : System.DateTime =
                            match v1169 with
                            | US3_1 -> (* None *)
                                let v1205 : System.DateTime = System.DateTime.Now
                                v1205
                            | US3_0(v1173) -> (* Some *)
                                let v1174 : System.DateTime = System.DateTime.Now
                                let v1177 : (System.DateTime -> int64) = _.Ticks
                                let v1178 : int64 = v1177 v1174
                                let v1181 : int64 = v1178 - v1173
                                let v1182 : (int64 -> System.TimeSpan) = System.TimeSpan 
                                let v1183 : System.TimeSpan = v1182 v1181
                                let v1186 : (System.TimeSpan -> int32) = _.Hours
                                let v1187 : int32 = v1186 v1183
                                let v1190 : (System.TimeSpan -> int32) = _.Minutes
                                let v1191 : int32 = v1190 v1183
                                let v1194 : (System.TimeSpan -> int32) = _.Seconds
                                let v1195 : int32 = v1194 v1183
                                let v1198 : (System.TimeSpan -> int32) = _.Milliseconds
                                let v1199 : int32 = v1198 v1183
                                let v1202 : System.DateTime = System.DateTime (1, 1, 1, v1187, v1191, v1195, v1199)
                                v1202
                        let v1210 : string = method10()
                        let v1213 : (string -> string) = v1209.ToString
                        let v1214 : string = v1213 v1210
                        let _v990 = v1214 
                        #endif
#if FABLE_COMPILER_PYTHON
                        let v1217 : US3 option = None
                        let _v1217 = ref v1217 
                        match v979 with
                        | Some x -> (
                        (fun () ->
                        (fun () ->
                        let v1218 : int64 = x
                        let v1219 : US3 = US3_0(v1218)
                        v1219 
                        )
                        |> fun x -> x () |> Some
                        ) () ) | None -> None
                        |> fun x -> _v1217.Value <- x
                        let v1220 : US3 option = _v1217.Value 
                        let v1231 : US3 = US3_1
                        let v1232 : US3 = v1220 |> Option.defaultValue v1231 
                        let v1272 : System.DateTime =
                            match v1232 with
                            | US3_1 -> (* None *)
                                let v1268 : System.DateTime = System.DateTime.Now
                                v1268
                            | US3_0(v1236) -> (* Some *)
                                let v1237 : System.DateTime = System.DateTime.Now
                                let v1240 : (System.DateTime -> int64) = _.Ticks
                                let v1241 : int64 = v1240 v1237
                                let v1244 : int64 = v1241 - v1236
                                let v1245 : (int64 -> System.TimeSpan) = System.TimeSpan 
                                let v1246 : System.TimeSpan = v1245 v1244
                                let v1249 : (System.TimeSpan -> int32) = _.Hours
                                let v1250 : int32 = v1249 v1246
                                let v1253 : (System.TimeSpan -> int32) = _.Minutes
                                let v1254 : int32 = v1253 v1246
                                let v1257 : (System.TimeSpan -> int32) = _.Seconds
                                let v1258 : int32 = v1257 v1246
                                let v1261 : (System.TimeSpan -> int32) = _.Milliseconds
                                let v1262 : int32 = v1261 v1246
                                let v1265 : System.DateTime = System.DateTime (1, 1, 1, v1250, v1254, v1258, v1262)
                                v1265
                        let v1273 : string = method10()
                        let v1276 : (string -> string) = v1272.ToString
                        let v1277 : string = v1276 v1273
                        let _v990 = v1277 
                        #endif
#else
                        let v1280 : US3 option = None
                        let _v1280 = ref v1280 
                        match v979 with
                        | Some x -> (
                        (fun () ->
                        (fun () ->
                        let v1281 : int64 = x
                        let v1282 : US3 = US3_0(v1281)
                        v1282 
                        )
                        |> fun x -> x () |> Some
                        ) () ) | None -> None
                        |> fun x -> _v1280.Value <- x
                        let v1283 : US3 option = _v1280.Value 
                        let v1294 : US3 = US3_1
                        let v1295 : US3 = v1283 |> Option.defaultValue v1294 
                        let v1335 : System.DateTime =
                            match v1295 with
                            | US3_1 -> (* None *)
                                let v1331 : System.DateTime = System.DateTime.Now
                                v1331
                            | US3_0(v1299) -> (* Some *)
                                let v1300 : System.DateTime = System.DateTime.Now
                                let v1303 : (System.DateTime -> int64) = _.Ticks
                                let v1304 : int64 = v1303 v1300
                                let v1307 : int64 = v1304 - v1299
                                let v1308 : (int64 -> System.TimeSpan) = System.TimeSpan 
                                let v1309 : System.TimeSpan = v1308 v1307
                                let v1312 : (System.TimeSpan -> int32) = _.Hours
                                let v1313 : int32 = v1312 v1309
                                let v1316 : (System.TimeSpan -> int32) = _.Minutes
                                let v1317 : int32 = v1316 v1309
                                let v1320 : (System.TimeSpan -> int32) = _.Seconds
                                let v1321 : int32 = v1320 v1309
                                let v1324 : (System.TimeSpan -> int32) = _.Milliseconds
                                let v1325 : int32 = v1324 v1309
                                let v1328 : System.DateTime = System.DateTime (1, 1, 1, v1313, v1317, v1321, v1325)
                                v1328
                        let v1336 : string = method10()
                        let v1339 : (string -> string) = v1335.ToString
                        let v1340 : string = v1339 v1336
                        let _v990 = v1340 
                        #endif
                        let v1343 : string = _v990 
                        let v1408 : string = "Critical"
                        let v1409 : (unit -> string) = v1408.ToLower
                        let v1410 : string = v1409 ()
                        let v1413 : string = v1410.PadLeft (7, ' ')
                        let v1427 : unit = ()
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v1428 : string = "inline_colorization::color_bright_red"
                        let v1429 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1428 
                        let v1430 : string = "&*$0"
                        let v1431 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1413 v1430 
                        let v1432 : string = "inline_colorization::color_reset"
                        let v1433 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1432 
                        let v1434 : string = "\"{v1429}{v1431}{v1433}\""
                        let v1435 : string = @$"format!(" + v1434 + ")"
                        let v1436 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v1435 
                        let v1437 : string = "fable_library_rust::String_::fromString($0)"
                        let v1438 : string = Fable.Core.RustInterop.emitRustExpr v1436 v1437 
                        let _v1427 = v1438 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        let v1439 : string = "inline_colorization::color_bright_red"
                        let v1440 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1439 
                        let v1441 : string = "&*$0"
                        let v1442 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1413 v1441 
                        let v1443 : string = "inline_colorization::color_reset"
                        let v1444 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1443 
                        let v1445 : string = "\"{v1440}{v1442}{v1444}\""
                        let v1446 : string = @$"format!(" + v1445 + ")"
                        let v1447 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v1446 
                        let v1448 : string = "fable_library_rust::String_::fromString($0)"
                        let v1449 : string = Fable.Core.RustInterop.emitRustExpr v1447 v1448 
                        let _v1427 = v1449 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        let v1450 : string = "inline_colorization::color_bright_red"
                        let v1451 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1450 
                        let v1452 : string = "&*$0"
                        let v1453 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1413 v1452 
                        let v1454 : string = "inline_colorization::color_reset"
                        let v1455 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1454 
                        let v1456 : string = "\"{v1451}{v1453}{v1455}\""
                        let v1457 : string = @$"format!(" + v1456 + ")"
                        let v1458 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v1457 
                        let v1459 : string = "fable_library_rust::String_::fromString($0)"
                        let v1460 : string = Fable.Core.RustInterop.emitRustExpr v1458 v1459 
                        let _v1427 = v1460 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        let v1461 : string = "\u001b[91m"
                        let v1462 : string = method11()
                        let v1463 : string = v1461 + v1413 
                        let v1464 : string = v1463 + v1462 
                        let _v1427 = v1464 
                        #endif
#if FABLE_COMPILER_PYTHON
                        let v1465 : string = "\u001b[91m"
                        let v1466 : string = method11()
                        let v1467 : string = v1465 + v1413 
                        let v1468 : string = v1467 + v1466 
                        let _v1427 = v1468 
                        #endif
#else
                        let v1469 : string = "\u001b[91m"
                        let v1470 : string = method11()
                        let v1471 : string = v1469 + v1413 
                        let v1472 : string = v1471 + v1470 
                        let _v1427 = v1472 
                        #endif
                        let v1473 : string = _v1427 
                        let v1479 : int64 = v975.l0
                        let v1480 : unit = ()
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v1481 : string = $"%A{v220}"
                        let _v1480 = v1481 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        let v1484 : string = $"%A{v220}"
                        let _v1480 = v1484 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        let v1487 : string = $"%A{v220}"
                        let _v1480 = v1487 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        let v1490 : string = $"%A{v220}"
                        let _v1480 = v1490 
                        #endif
#if FABLE_COMPILER_PYTHON
                        let v1493 : string = $"%A{v220}"
                        let _v1480 = v1493 
                        #endif
#else
                        let v1496 : string = $"{v220.GetType ()}: {v220.Message}"
                        let _v1480 = v1496 
                        #endif
                        let v1497 : string = _v1480 
                        let v1502 : string = method13()
                        let v1503 : Mut4 = {l0 = v1502} : Mut4
                        let v1504 : string = "{ "
                        let v1505 : string = $"{v1504}"
                        let v1508 : string = v1503.l0
                        let v1509 : string = v1508 + v1505 
                        v1503.l0 <- v1509
                        let v1510 : string = "timeout"
                        let v1511 : string = $"{v1510}"
                        let v1514 : string = v1503.l0
                        let v1515 : string = v1514 + v1511 
                        v1503.l0 <- v1515
                        let v1516 : string = " = "
                        let v1517 : string = $"{v1516}"
                        let v1520 : string = v1503.l0
                        let v1521 : string = v1520 + v1517 
                        v1503.l0 <- v1521
                        let v1522 : string = $"{1000}"
                        let v1525 : string = v1503.l0
                        let v1526 : string = v1525 + v1522 
                        v1503.l0 <- v1526
                        let v1527 : string = "; "
                        let v1528 : string = $"{v1527}"
                        let v1531 : string = v1503.l0
                        let v1532 : string = v1531 + v1528 
                        v1503.l0 <- v1532
                        let v1533 : string = "ex"
                        let v1534 : string = $"{v1533}"
                        let v1537 : string = v1503.l0
                        let v1538 : string = v1537 + v1534 
                        v1503.l0 <- v1538
                        let v1539 : string = $"{v1516}"
                        let v1542 : string = v1503.l0
                        let v1543 : string = v1542 + v1539 
                        v1503.l0 <- v1543
                        let v1544 : string = $"{v1497}"
                        let v1547 : string = v1503.l0
                        let v1548 : string = v1547 + v1544 
                        v1503.l0 <- v1548
                        let v1549 : string = " }"
                        let v1550 : string = $"{v1549}"
                        let v1553 : string = v1503.l0
                        let v1554 : string = v1553 + v1550 
                        v1503.l0 <- v1554
                        let v1555 : string = v1503.l0
                        let v1556 : (unit -> string) = closure23()
                        let v1557 : string = $"{v1343} {v1473} #{v1479} %s{v1556 ()} / {v1555}"
                        let v1560 : char list = []
                        let v1561 : (char list -> (char [])) = List.toArray
                        let v1562 : (char []) = v1561 v1560
                        let v1565 : string = v1557.TrimStart v1562 
                        let v1583 : char list = []
                        let v1584 : char list = '/' :: v1583 
                        let v1587 : char list = ' ' :: v1584 
                        let v1590 : (char list -> (char [])) = List.toArray
                        let v1591 : (char []) = v1590 v1587
                        let v1594 : string = v1565.TrimEnd v1591 
                        let v1612 : unit = ()
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v1613 : string = @"println!(""{}"", $0)"
                        Fable.Core.RustInterop.emitRustExpr v1594 v1613 
                        let _v1612 = () 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        let v1614 : string = @"println!(""{}"", $0)"
                        Fable.Core.RustInterop.emitRustExpr v1594 v1614 
                        let _v1612 = () 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        let v1615 : string = $"near_sdk::log!(\"{{}}\", $0)"
                        Fable.Core.RustInterop.emitRustExpr v1594 v1615 
                        let _v1612 = () 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        System.Console.WriteLine v1594 
                        let _v1612 = () 
                        #endif
#if FABLE_COMPILER_PYTHON
                        System.Console.WriteLine v1594 
                        let _v1612 = () 
                        #endif
#else
                        System.Console.WriteLine v1594 
                        let _v1612 = () 
                        #endif
                        _v1612 
                        let v1616 : (string -> unit) = v914.l0
                        v1616 v1594
                    US3_1
            | US10_0(v218) -> (* Ok *)
                US3_0(v218)
        return v1620 
        }
        |> fun x -> _v216 <- Some x
        let v1621 : Async<US3> = match _v216 with Some x -> x | None -> failwith "async.new_async_unit / _v216=None"
        let _v200 = v1621 
        #endif
        let v1622 : Async<US3> = _v200 
        return! v1622 
        }
        |> fun x -> _v75 <- Some x
        let v1627 : Async<US3> = match _v75 with Some x -> x | None -> failwith "async.new_async_unit / _v75=None"
        let _v59 = v1627 
        #endif
        let v1628 : Async<US3> = _v59 
        let _v43 = v1628 
        #endif
        let v1633 : Async<US3> = _v43 
        let v1638 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v1639 : Async<unit> = null |> unbox<Async<unit>>
        let _v1638 = v1639 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v1642 : Async<unit> = null |> unbox<Async<unit>>
        let _v1638 = v1642 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v1645 : Async<unit> = null |> unbox<Async<unit>>
        let _v1638 = v1645 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v1648 : Async<unit> = null |> unbox<Async<unit>>
        let _v1638 = v1648 
        #endif
#if FABLE_COMPILER_PYTHON
        let v1651 : Async<unit> = null |> unbox<Async<unit>>
        let _v1638 = v1651 
        #endif
#else
        let v1654 : (Async<US3> -> Async<unit>) = Async.Ignore
        let v1655 : Async<unit> = v1654 v1633
        let _v1638 = v1655 
        #endif
        let v1656 : Async<unit> = _v1638 
        do! v1656 
        ()
    let v1661 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1662 : Async<string> = null |> unbox<Async<string>>
    let _v1661 = v1662 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1665 : Async<string> = null |> unbox<Async<string>>
    let _v1661 = v1665 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1668 : Async<string> = null |> unbox<Async<string>>
    let _v1661 = v1668 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1671 : Async<string> = null |> unbox<Async<string>>
    let _v1661 = v1671 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1674 : Async<string> = null |> unbox<Async<string>>
    let _v1661 = v1674 
    #endif
#else
    let v1677 : (string -> System.Threading.Tasks.Task<string>) = System.IO.File.ReadAllTextAsync
    let v1678 : System.Threading.Tasks.Task<string> = v1677 v0
    let v1679 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1680 : Async<string> = null |> unbox<Async<string>>
    let _v1679 = v1680 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1683 : Async<string> = null |> unbox<Async<string>>
    let _v1679 = v1683 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1686 : Async<string> = null |> unbox<Async<string>>
    let _v1679 = v1686 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1689 : Async<string> = null |> unbox<Async<string>>
    let _v1679 = v1689 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1692 : Async<string> = null |> unbox<Async<string>>
    let _v1679 = v1692 
    #endif
#else
    let v1695 : (System.Threading.Tasks.Task<string> -> Async<string>) = Async.AwaitTask
    let v1696 : Async<string> = v1695 v1678
    let _v1679 = v1696 
    #endif
    let v1697 : Async<string> = _v1679 
    let _v1661 = v1697 
    #endif
    let v1702 : Async<string> = _v1661 
    let v1707 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1708 : Async<string option> = null |> unbox<Async<string option>>
    let _v1707 = v1708 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1711 : Async<string option> = null |> unbox<Async<string option>>
    let _v1707 = v1711 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1714 : Async<string option> = null |> unbox<Async<string option>>
    let _v1707 = v1714 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1717 : Async<string option> = null |> unbox<Async<string option>>
    let _v1707 = v1717 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1720 : Async<string option> = null |> unbox<Async<string option>>
    let _v1707 = v1720 
    #endif
#else
    let v1723 : Async<string option> option = None
    let mutable _v1723 = v1723 
    async {
    let! v1702 = v1702 
    let v1724 : string = v1702 
    let v1725 : string option = Some v1724 
    return v1725 
    }
    |> fun x -> _v1723 <- Some x
    let v1728 : Async<string option> = match _v1723 with Some x -> x | None -> failwith "async.new_async_unit / _v1723=None"
    let _v1707 = v1728 
    #endif
    let v1729 : Async<string option> = _v1707 
    return! v1729 
    with ex ->
    let v1734 : exn = ex
    let v1735 : bool = v1 = 0L
    let v1736 : bool = v1735 <> true
    if v1736 then
        let v1737 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v1738 : string = $"%A{v1734}"
        let _v1737 = v1738 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v1741 : string = $"%A{v1734}"
        let _v1737 = v1741 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v1744 : string = $"%A{v1734}"
        let _v1737 = v1744 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v1747 : string = $"%A{v1734}"
        let _v1737 = v1747 
        #endif
#if FABLE_COMPILER_PYTHON
        let v1750 : string = $"%A{v1734}"
        let _v1737 = v1750 
        #endif
#else
        let v1753 : string = $"{v1734.GetType ()}: {v1734.Message}"
        let _v1737 = v1753 
        #endif
        let v1754 : string = _v1737 
        let v1759 : bool = State.trace_state.IsNone
        if v1759 then
            let v1760 : US0 = US0_0
            let struct (v1761 : Mut0, v1762 : Mut1, v1763 : Mut2, v1764 : Mut3, v1765 : int64 option) = method0(v1760)
            let v1766 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v1761, v1762, v1763, v1764, v1765) 
            State.trace_state <- v1766 
            ()
        let struct (v1771 : Mut0, v1772 : Mut1, v1773 : Mut2, v1774 : Mut3, v1775 : int64 option) = State.trace_state.Value
        let v1786 : bool = State.trace_state.IsNone
        if v1786 then
            let v1787 : US0 = US0_0
            let struct (v1788 : Mut0, v1789 : Mut1, v1790 : Mut2, v1791 : Mut3, v1792 : int64 option) = method0(v1787)
            let v1793 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v1788, v1789, v1790, v1791, v1792) 
            State.trace_state <- v1793 
            ()
        let struct (v1798 : Mut0, v1799 : Mut1, v1800 : Mut2, v1801 : Mut3, v1802 : int64 option) = State.trace_state.Value
        let v1813 : US0 = v1801.l0
        let v1814 : bool = v1800.l0
        let v1815 : bool = v1814 = false
        let v1818 : bool =
            if v1815 then
                false
            else
                let v1816 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v1813
                let v1817 : bool = 1 >= v1816
                v1817
        if v1818 then
            let v1819 : int64 = v1771.l0
            let v1820 : int64 = v1819 + 1L
            v1771.l0 <- v1820
            let v1821 : bool = State.trace_state.IsNone
            if v1821 then
                let v1822 : US0 = US0_0
                let struct (v1823 : Mut0, v1824 : Mut1, v1825 : Mut2, v1826 : Mut3, v1827 : int64 option) = method0(v1822)
                let v1828 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v1823, v1824, v1825, v1826, v1827) 
                State.trace_state <- v1828 
                ()
            let struct (v1833 : Mut0, v1834 : Mut1, v1835 : Mut2, v1836 : Mut3, v1837 : int64 option) = State.trace_state.Value
            let v1848 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1849 : US3 option = None
            let _v1849 = ref v1849 
            match v1837 with
            | Some x -> (
            (fun () ->
            (fun () ->
            let v1850 : int64 = x
            let v1851 : US3 = US3_0(v1850)
            v1851 
            )
            |> fun x -> x () |> Some
            ) () ) | None -> None
            |> fun x -> _v1849.Value <- x
            let v1852 : US3 option = _v1849.Value 
            let v1863 : US3 = US3_1
            let v1864 : US3 = v1852 |> Option.defaultValue v1863 
            let v1904 : System.DateTime =
                match v1864 with
                | US3_1 -> (* None *)
                    let v1900 : System.DateTime = System.DateTime.Now
                    v1900
                | US3_0(v1868) -> (* Some *)
                    let v1869 : System.DateTime = System.DateTime.Now
                    let v1872 : (System.DateTime -> int64) = _.Ticks
                    let v1873 : int64 = v1872 v1869
                    let v1876 : int64 = v1873 - v1868
                    let v1877 : (int64 -> System.TimeSpan) = System.TimeSpan 
                    let v1878 : System.TimeSpan = v1877 v1876
                    let v1881 : (System.TimeSpan -> int32) = _.Hours
                    let v1882 : int32 = v1881 v1878
                    let v1885 : (System.TimeSpan -> int32) = _.Minutes
                    let v1886 : int32 = v1885 v1878
                    let v1889 : (System.TimeSpan -> int32) = _.Seconds
                    let v1890 : int32 = v1889 v1878
                    let v1893 : (System.TimeSpan -> int32) = _.Milliseconds
                    let v1894 : int32 = v1893 v1878
                    let v1897 : System.DateTime = System.DateTime (1, 1, 1, v1882, v1886, v1890, v1894)
                    v1897
            let v1905 : string = method9()
            let v1908 : (string -> string) = v1904.ToString
            let v1909 : string = v1908 v1905
            let _v1848 = v1909 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1912 : US3 option = None
            let _v1912 = ref v1912 
            match v1837 with
            | Some x -> (
            (fun () ->
            (fun () ->
            let v1913 : int64 = x
            let v1914 : US3 = US3_0(v1913)
            v1914 
            )
            |> fun x -> x () |> Some
            ) () ) | None -> None
            |> fun x -> _v1912.Value <- x
            let v1915 : US3 option = _v1912.Value 
            let v1926 : US3 = US3_1
            let v1927 : US3 = v1915 |> Option.defaultValue v1926 
            let v1967 : System.DateTime =
                match v1927 with
                | US3_1 -> (* None *)
                    let v1963 : System.DateTime = System.DateTime.Now
                    v1963
                | US3_0(v1931) -> (* Some *)
                    let v1932 : System.DateTime = System.DateTime.Now
                    let v1935 : (System.DateTime -> int64) = _.Ticks
                    let v1936 : int64 = v1935 v1932
                    let v1939 : int64 = v1936 - v1931
                    let v1940 : (int64 -> System.TimeSpan) = System.TimeSpan 
                    let v1941 : System.TimeSpan = v1940 v1939
                    let v1944 : (System.TimeSpan -> int32) = _.Hours
                    let v1945 : int32 = v1944 v1941
                    let v1948 : (System.TimeSpan -> int32) = _.Minutes
                    let v1949 : int32 = v1948 v1941
                    let v1952 : (System.TimeSpan -> int32) = _.Seconds
                    let v1953 : int32 = v1952 v1941
                    let v1956 : (System.TimeSpan -> int32) = _.Milliseconds
                    let v1957 : int32 = v1956 v1941
                    let v1960 : System.DateTime = System.DateTime (1, 1, 1, v1945, v1949, v1953, v1957)
                    v1960
            let v1968 : string = method9()
            let v1971 : (string -> string) = v1967.ToString
            let v1972 : string = v1971 v1968
            let _v1848 = v1972 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1975 : string = $"near_sdk::env::block_timestamp()"
            let v1976 : uint64 = Fable.Core.RustInterop.emitRustExpr () v1975 
            let v1977 : US3 option = None
            let _v1977 = ref v1977 
            match v1837 with
            | Some x -> (
            (fun () ->
            (fun () ->
            let v1978 : int64 = x
            let v1979 : US3 = US3_0(v1978)
            v1979 
            )
            |> fun x -> x () |> Some
            ) () ) | None -> None
            |> fun x -> _v1977.Value <- x
            let v1980 : US3 option = _v1977.Value 
            let v1991 : US3 = US3_1
            let v1992 : US3 = v1980 |> Option.defaultValue v1991 
            let v2001 : uint64 =
                match v1992 with
                | US3_1 -> (* None *)
                    v1976
                | US3_0(v1996) -> (* Some *)
                    let v1997 : (int64 -> uint64) = uint64
                    let v1998 : uint64 = v1997 v1996
                    let v1999 : uint64 = v1976 - v1998
                    v1999
            let v2002 : uint64 = v2001 / 1000000000UL
            let v2003 : uint64 = v2002 % 60UL
            let v2004 : uint64 = v2002 / 60UL
            let v2005 : uint64 = v2004 % 60UL
            let v2006 : uint64 = v2002 / 3600UL
            let v2007 : uint64 = v2006 % 24UL
            let v2008 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
            let v2009 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v2007, v2005, v2003) v2008 
            let v2010 : string = "fable_library_rust::String_::fromString($0)"
            let v2011 : string = Fable.Core.RustInterop.emitRustExpr v2009 v2010 
            let _v1848 = v2011 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v2012 : US3 option = None
            let _v2012 = ref v2012 
            match v1837 with
            | Some x -> (
            (fun () ->
            (fun () ->
            let v2013 : int64 = x
            let v2014 : US3 = US3_0(v2013)
            v2014 
            )
            |> fun x -> x () |> Some
            ) () ) | None -> None
            |> fun x -> _v2012.Value <- x
            let v2015 : US3 option = _v2012.Value 
            let v2026 : US3 = US3_1
            let v2027 : US3 = v2015 |> Option.defaultValue v2026 
            let v2067 : System.DateTime =
                match v2027 with
                | US3_1 -> (* None *)
                    let v2063 : System.DateTime = System.DateTime.Now
                    v2063
                | US3_0(v2031) -> (* Some *)
                    let v2032 : System.DateTime = System.DateTime.Now
                    let v2035 : (System.DateTime -> int64) = _.Ticks
                    let v2036 : int64 = v2035 v2032
                    let v2039 : int64 = v2036 - v2031
                    let v2040 : (int64 -> System.TimeSpan) = System.TimeSpan 
                    let v2041 : System.TimeSpan = v2040 v2039
                    let v2044 : (System.TimeSpan -> int32) = _.Hours
                    let v2045 : int32 = v2044 v2041
                    let v2048 : (System.TimeSpan -> int32) = _.Minutes
                    let v2049 : int32 = v2048 v2041
                    let v2052 : (System.TimeSpan -> int32) = _.Seconds
                    let v2053 : int32 = v2052 v2041
                    let v2056 : (System.TimeSpan -> int32) = _.Milliseconds
                    let v2057 : int32 = v2056 v2041
                    let v2060 : System.DateTime = System.DateTime (1, 1, 1, v2045, v2049, v2053, v2057)
                    v2060
            let v2068 : string = method10()
            let v2071 : (string -> string) = v2067.ToString
            let v2072 : string = v2071 v2068
            let _v1848 = v2072 
            #endif
#if FABLE_COMPILER_PYTHON
            let v2075 : US3 option = None
            let _v2075 = ref v2075 
            match v1837 with
            | Some x -> (
            (fun () ->
            (fun () ->
            let v2076 : int64 = x
            let v2077 : US3 = US3_0(v2076)
            v2077 
            )
            |> fun x -> x () |> Some
            ) () ) | None -> None
            |> fun x -> _v2075.Value <- x
            let v2078 : US3 option = _v2075.Value 
            let v2089 : US3 = US3_1
            let v2090 : US3 = v2078 |> Option.defaultValue v2089 
            let v2130 : System.DateTime =
                match v2090 with
                | US3_1 -> (* None *)
                    let v2126 : System.DateTime = System.DateTime.Now
                    v2126
                | US3_0(v2094) -> (* Some *)
                    let v2095 : System.DateTime = System.DateTime.Now
                    let v2098 : (System.DateTime -> int64) = _.Ticks
                    let v2099 : int64 = v2098 v2095
                    let v2102 : int64 = v2099 - v2094
                    let v2103 : (int64 -> System.TimeSpan) = System.TimeSpan 
                    let v2104 : System.TimeSpan = v2103 v2102
                    let v2107 : (System.TimeSpan -> int32) = _.Hours
                    let v2108 : int32 = v2107 v2104
                    let v2111 : (System.TimeSpan -> int32) = _.Minutes
                    let v2112 : int32 = v2111 v2104
                    let v2115 : (System.TimeSpan -> int32) = _.Seconds
                    let v2116 : int32 = v2115 v2104
                    let v2119 : (System.TimeSpan -> int32) = _.Milliseconds
                    let v2120 : int32 = v2119 v2104
                    let v2123 : System.DateTime = System.DateTime (1, 1, 1, v2108, v2112, v2116, v2120)
                    v2123
            let v2131 : string = method10()
            let v2134 : (string -> string) = v2130.ToString
            let v2135 : string = v2134 v2131
            let _v1848 = v2135 
            #endif
#else
            let v2138 : US3 option = None
            let _v2138 = ref v2138 
            match v1837 with
            | Some x -> (
            (fun () ->
            (fun () ->
            let v2139 : int64 = x
            let v2140 : US3 = US3_0(v2139)
            v2140 
            )
            |> fun x -> x () |> Some
            ) () ) | None -> None
            |> fun x -> _v2138.Value <- x
            let v2141 : US3 option = _v2138.Value 
            let v2152 : US3 = US3_1
            let v2153 : US3 = v2141 |> Option.defaultValue v2152 
            let v2193 : System.DateTime =
                match v2153 with
                | US3_1 -> (* None *)
                    let v2189 : System.DateTime = System.DateTime.Now
                    v2189
                | US3_0(v2157) -> (* Some *)
                    let v2158 : System.DateTime = System.DateTime.Now
                    let v2161 : (System.DateTime -> int64) = _.Ticks
                    let v2162 : int64 = v2161 v2158
                    let v2165 : int64 = v2162 - v2157
                    let v2166 : (int64 -> System.TimeSpan) = System.TimeSpan 
                    let v2167 : System.TimeSpan = v2166 v2165
                    let v2170 : (System.TimeSpan -> int32) = _.Hours
                    let v2171 : int32 = v2170 v2167
                    let v2174 : (System.TimeSpan -> int32) = _.Minutes
                    let v2175 : int32 = v2174 v2167
                    let v2178 : (System.TimeSpan -> int32) = _.Seconds
                    let v2179 : int32 = v2178 v2167
                    let v2182 : (System.TimeSpan -> int32) = _.Milliseconds
                    let v2183 : int32 = v2182 v2167
                    let v2186 : System.DateTime = System.DateTime (1, 1, 1, v2171, v2175, v2179, v2183)
                    v2186
            let v2194 : string = method10()
            let v2197 : (string -> string) = v2193.ToString
            let v2198 : string = v2197 v2194
            let _v1848 = v2198 
            #endif
            let v2201 : string = _v1848 
            let v2266 : string = "Debug"
            let v2267 : (unit -> string) = v2266.ToLower
            let v2268 : string = v2267 ()
            let v2271 : string = v2268.PadLeft (7, ' ')
            let v2285 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v2286 : string = "inline_colorization::color_bright_blue"
            let v2287 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v2286 
            let v2288 : string = "&*$0"
            let v2289 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v2271 v2288 
            let v2290 : string = "inline_colorization::color_reset"
            let v2291 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v2290 
            let v2292 : string = "\"{v2287}{v2289}{v2291}\""
            let v2293 : string = @$"format!(" + v2292 + ")"
            let v2294 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v2293 
            let v2295 : string = "fable_library_rust::String_::fromString($0)"
            let v2296 : string = Fable.Core.RustInterop.emitRustExpr v2294 v2295 
            let _v2285 = v2296 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v2297 : string = "inline_colorization::color_bright_blue"
            let v2298 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v2297 
            let v2299 : string = "&*$0"
            let v2300 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v2271 v2299 
            let v2301 : string = "inline_colorization::color_reset"
            let v2302 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v2301 
            let v2303 : string = "\"{v2298}{v2300}{v2302}\""
            let v2304 : string = @$"format!(" + v2303 + ")"
            let v2305 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v2304 
            let v2306 : string = "fable_library_rust::String_::fromString($0)"
            let v2307 : string = Fable.Core.RustInterop.emitRustExpr v2305 v2306 
            let _v2285 = v2307 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v2308 : string = "inline_colorization::color_bright_blue"
            let v2309 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v2308 
            let v2310 : string = "&*$0"
            let v2311 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v2271 v2310 
            let v2312 : string = "inline_colorization::color_reset"
            let v2313 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v2312 
            let v2314 : string = "\"{v2309}{v2311}{v2313}\""
            let v2315 : string = @$"format!(" + v2314 + ")"
            let v2316 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v2315 
            let v2317 : string = "fable_library_rust::String_::fromString($0)"
            let v2318 : string = Fable.Core.RustInterop.emitRustExpr v2316 v2317 
            let _v2285 = v2318 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v2319 : string = "\u001b[94m"
            let v2320 : string = method11()
            let v2321 : string = v2319 + v2271 
            let v2322 : string = v2321 + v2320 
            let _v2285 = v2322 
            #endif
#if FABLE_COMPILER_PYTHON
            let v2323 : string = "\u001b[94m"
            let v2324 : string = method11()
            let v2325 : string = v2323 + v2271 
            let v2326 : string = v2325 + v2324 
            let _v2285 = v2326 
            #endif
#else
            let v2327 : string = "\u001b[94m"
            let v2328 : string = method11()
            let v2329 : string = v2327 + v2271 
            let v2330 : string = v2329 + v2328 
            let _v2285 = v2330 
            #endif
            let v2331 : string = _v2285 
            let v2337 : int64 = v1833.l0
            let v2338 : string = method13()
            let v2339 : Mut4 = {l0 = v2338} : Mut4
            let v2340 : string = "{ "
            let v2341 : string = $"{v2340}"
            let v2344 : string = v2339.l0
            let v2345 : string = v2344 + v2341 
            v2339.l0 <- v2345
            let v2346 : string = "retry"
            let v2347 : string = $"{v2346}"
            let v2350 : string = v2339.l0
            let v2351 : string = v2350 + v2347 
            v2339.l0 <- v2351
            let v2352 : string = " = "
            let v2353 : string = $"{v2352}"
            let v2356 : string = v2339.l0
            let v2357 : string = v2356 + v2353 
            v2339.l0 <- v2357
            let v2358 : string = $"{v1}"
            let v2361 : string = v2339.l0
            let v2362 : string = v2361 + v2358 
            v2339.l0 <- v2362
            let v2363 : string = "; "
            let v2364 : string = $"{v2363}"
            let v2367 : string = v2339.l0
            let v2368 : string = v2367 + v2364 
            v2339.l0 <- v2368
            let v2369 : string = "ex"
            let v2370 : string = $"{v2369}"
            let v2373 : string = v2339.l0
            let v2374 : string = v2373 + v2370 
            v2339.l0 <- v2374
            let v2375 : string = $"{v2352}"
            let v2378 : string = v2339.l0
            let v2379 : string = v2378 + v2375 
            v2339.l0 <- v2379
            let v2380 : string = $"{v1754}"
            let v2383 : string = v2339.l0
            let v2384 : string = v2383 + v2380 
            v2339.l0 <- v2384
            let v2385 : string = " }"
            let v2386 : string = $"{v2385}"
            let v2389 : string = v2339.l0
            let v2390 : string = v2389 + v2386 
            v2339.l0 <- v2390
            let v2391 : string = v2339.l0
            let v2392 : (unit -> string) = closure24()
            let v2393 : string = $"{v2201} {v2331} #{v2337} %s{v2392 ()} / {v2391}"
            let v2396 : char list = []
            let v2397 : (char list -> (char [])) = List.toArray
            let v2398 : (char []) = v2397 v2396
            let v2401 : string = v2393.TrimStart v2398 
            let v2419 : char list = []
            let v2420 : char list = '/' :: v2419 
            let v2423 : char list = ' ' :: v2420 
            let v2426 : (char list -> (char [])) = List.toArray
            let v2427 : (char []) = v2426 v2423
            let v2430 : string = v2401.TrimEnd v2427 
            let v2448 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v2449 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v2430 v2449 
            let _v2448 = () 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v2450 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v2430 v2450 
            let _v2448 = () 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v2451 : string = $"near_sdk::log!(\"{{}}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v2430 v2451 
            let _v2448 = () 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            System.Console.WriteLine v2430 
            let _v2448 = () 
            #endif
#if FABLE_COMPILER_PYTHON
            System.Console.WriteLine v2430 
            let _v2448 = () 
            #endif
#else
            System.Console.WriteLine v2430 
            let _v2448 = () 
            #endif
            _v2448 
            let v2452 : (string -> unit) = v1772.l0
            v2452 v2430
        let v2453 : string option = None
        return v2453 
        (*
        ()
    else
        *) else
        let v2454 : int64 = v1 + 1L
        let v2455 : Async<string option> = method21(v0, v2454)
        return! v2455 
        (*
        ()
    *)
    (*
    let v2456 : string option = *)
    }
    |> fun x -> _v18 <- Some x
    let v2457 : Async<string option> = match _v18 with Some x -> x | None -> failwith "async.new_async_unit / _v18=None"
    let _v2 = v2457 
    #endif
    let v2458 : Async<string option> = _v2 
    v2458
and closure19 () (v0 : string) : Async<string option> =
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
    match v27 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v29 : chrono_DateTime<chrono_Utc> = x
    let v30 : US11 = US11_0(v29)
    v30 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v28.Value <- x
    let v31 : US11 option = _v28.Value 
    let v42 : US11 = US11_1
    let v43 : US11 = v31 |> Option.defaultValue v42 
    let v63 : US1 =
        match v43 with
        | US11_1 -> (* None *)
            US1_1
        | US11_0(v47) -> (* Some *)
            let v48 : string = "$0.naive_utc()"
            let v49 : chrono_NaiveDateTime = Fable.Core.RustInterop.emitRustExpr v47 v48 
            let v50 : string = "chrono::offset::TimeZone::from_utc_datetime(&chrono::Local, &$0)"
            let v51 : chrono_DateTime<chrono_Local> = Fable.Core.RustInterop.emitRustExpr v49 v50 
            let v52 : string = "%Y%m%d-%H%M-%S%f"
            let v53 : string = "r#\"" + v52 + "\"#"
            let v54 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v53 
            let v55 : string = "$0.format($1).to_string()"
            let v56 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v51, v54) v55 
            let v57 : string = "fable_library_rust::String_::fromString($0)"
            let v58 : string = Fable.Core.RustInterop.emitRustExpr v56 v57 
            let v59 : string = $"{v58.[0..17]}-{v58.[18..21]}-{v58.[22]}"
            US1_0(v59)
    let v67 : string =
        match v63 with
        | US1_1 -> (* None *)
            let v65 : string = ""
            v65
        | US1_0(v64) -> (* Some *)
            v64
    let v68 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v69 : string = "0i64.into()"
    let v70 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v69 
    let _v68 = v70 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v71 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v68 = v71 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v74 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v68 = v74 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v77 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v68 = v77 
    #endif
#if FABLE_COMPILER_PYTHON
    let v80 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v68 = v80 
    #endif
#else
    let v83 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v68 = v83 
    #endif
    let v84 : System.TimeZoneInfo = _v68 
    let v89 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v90 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v91 : System.TimeSpan = v90 ()
    let _v89 = v91 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v94 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v95 : System.TimeSpan = v94 ()
    let _v89 = v95 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v98 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v99 : System.TimeSpan = v98 ()
    let _v89 = v99 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v102 : US4 = US4_0
    let v103 : US5 = US5_3(v102)
    let v104 : string = $"date_time.get_utc_offset / target: {v103}"
    let v105 : System.TimeSpan = failwith<System.TimeSpan> v104
    let _v89 = v105 
    #endif
#if FABLE_COMPILER_PYTHON
    let v106 : US4 = US4_0
    let v107 : US5 = US5_4(v106)
    let v108 : string = $"date_time.get_utc_offset / target: {v107}"
    let v109 : System.TimeSpan = failwith<System.TimeSpan> v108
    let _v89 = v109 
    #endif
#else
    let v110 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v111 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v112 : string = "0i64.into()"
    let v113 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v112 
    let _v111 = v113 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v114 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v111 = v114 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v117 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v111 = v117 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v120 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v111 = v120 
    #endif
#if FABLE_COMPILER_PYTHON
    let v123 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v111 = v123 
    #endif
#else
    let v126 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v111 = v126 
    #endif
    let v127 : System.TimeZoneInfo = _v111 
    let v132 : (System.DateTime -> System.TimeSpan) = v110 v127
    let v133 : System.TimeSpan = v132 v13
    let _v89 = v133 
    #endif
    let v134 : System.TimeSpan = _v89 
    let v140 : (System.TimeSpan -> int32) = _.Hours
    let v141 : int32 = v140 v134
    let v144 : bool = v141 > 0
    let v145 : uint8 =
        if v144 then
            1uy
        else
            0uy
    let v146 : string = method24()
    let v147 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v148 : string = v134.ToString v146 
    let _v147 = v148 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v149 : string = v134.ToString v146 
    let _v147 = v149 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v150 : string = v134.ToString v146 
    let _v147 = v150 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v151 : string = v134.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _v147 = v151 
    #endif
#if FABLE_COMPILER_PYTHON
    let v152 : string = v134.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _v147 = v152 
    #endif
#else
    let v153 : string = v134.ToString v146 
    let _v147 = v153 
    #endif
    let v154 : string = _v147 
    let v157 : string = $"{v145}{v154.[0..1]}{v154.[3..4]}"
    let v158 : (System.Guid -> string) = _.ToString()
    let v159 : string = v158 v0
    let v162 : System.Guid = System.Guid $"{v67}{v157}{v159.[v67.Length + v157.Length..]}"
    let _v2 = v162 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v163 : System.DateTime = System.DateTime (1970, 1, 1, 0, 0, 0, System.DateTimeKind.Utc)
    let v166 : (System.DateTime -> System.DateTime) = _.ToUniversalTime()
    let v167 : System.DateTime = v166 v163
    let v170 : System.DateTimeKind = System.DateTimeKind.Local
    let v171 : System.DateTime = System.DateTime.SpecifyKind (v1, v170)
    let v172 : (System.DateTime -> System.DateTime) = _.ToUniversalTime()
    let v173 : System.DateTime = v172 v171
    let v176 : (System.DateTime -> int64) = _.Ticks
    let v177 : int64 = v176 v173
    let v180 : (System.DateTime -> int64) = _.Ticks
    let v181 : int64 = v180 v167
    let v184 : int64 = v177 - v181
    let v185 : int64 = v184 / 10L
    let v186 : string = "chrono::DateTime::from_timestamp_micros($0)"
    let v187 : chrono_DateTime<chrono_Utc> option = Fable.Core.RustInterop.emitRustExpr v185 v186 
    let v188 : US11 option = None
    let _v188 = ref v188 
    match v187 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v189 : chrono_DateTime<chrono_Utc> = x
    let v190 : US11 = US11_0(v189)
    v190 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v188.Value <- x
    let v191 : US11 option = _v188.Value 
    let v202 : US11 = US11_1
    let v203 : US11 = v191 |> Option.defaultValue v202 
    let v223 : US1 =
        match v203 with
        | US11_1 -> (* None *)
            US1_1
        | US11_0(v207) -> (* Some *)
            let v208 : string = "$0.naive_utc()"
            let v209 : chrono_NaiveDateTime = Fable.Core.RustInterop.emitRustExpr v207 v208 
            let v210 : string = "chrono::offset::TimeZone::from_utc_datetime(&chrono::Local, &$0)"
            let v211 : chrono_DateTime<chrono_Local> = Fable.Core.RustInterop.emitRustExpr v209 v210 
            let v212 : string = "%Y%m%d-%H%M-%S%f"
            let v213 : string = "r#\"" + v212 + "\"#"
            let v214 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v213 
            let v215 : string = "$0.format($1).to_string()"
            let v216 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v211, v214) v215 
            let v217 : string = "fable_library_rust::String_::fromString($0)"
            let v218 : string = Fable.Core.RustInterop.emitRustExpr v216 v217 
            let v219 : string = $"{v218.[0..17]}-{v218.[18..21]}-{v218.[22]}"
            US1_0(v219)
    let v227 : string =
        match v223 with
        | US1_1 -> (* None *)
            let v225 : string = ""
            v225
        | US1_0(v224) -> (* Some *)
            v224
    let v228 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v229 : string = "0i64.into()"
    let v230 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v229 
    let _v228 = v230 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v231 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v228 = v231 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v234 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v228 = v234 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v237 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v228 = v237 
    #endif
#if FABLE_COMPILER_PYTHON
    let v240 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v228 = v240 
    #endif
#else
    let v243 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v228 = v243 
    #endif
    let v244 : System.TimeZoneInfo = _v228 
    let v249 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v250 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v251 : System.TimeSpan = v250 ()
    let _v249 = v251 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v254 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v255 : System.TimeSpan = v254 ()
    let _v249 = v255 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v258 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v259 : System.TimeSpan = v258 ()
    let _v249 = v259 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v262 : US4 = US4_0
    let v263 : US5 = US5_3(v262)
    let v264 : string = $"date_time.get_utc_offset / target: {v263}"
    let v265 : System.TimeSpan = failwith<System.TimeSpan> v264
    let _v249 = v265 
    #endif
#if FABLE_COMPILER_PYTHON
    let v266 : US4 = US4_0
    let v267 : US5 = US5_4(v266)
    let v268 : string = $"date_time.get_utc_offset / target: {v267}"
    let v269 : System.TimeSpan = failwith<System.TimeSpan> v268
    let _v249 = v269 
    #endif
#else
    let v270 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v271 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v272 : string = "0i64.into()"
    let v273 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v272 
    let _v271 = v273 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v274 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v271 = v274 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v277 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v271 = v277 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v280 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v271 = v280 
    #endif
#if FABLE_COMPILER_PYTHON
    let v283 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v271 = v283 
    #endif
#else
    let v286 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v271 = v286 
    #endif
    let v287 : System.TimeZoneInfo = _v271 
    let v292 : (System.DateTime -> System.TimeSpan) = v270 v287
    let v293 : System.TimeSpan = v292 v173
    let _v249 = v293 
    #endif
    let v294 : System.TimeSpan = _v249 
    let v300 : (System.TimeSpan -> int32) = _.Hours
    let v301 : int32 = v300 v294
    let v304 : bool = v301 > 0
    let v305 : uint8 =
        if v304 then
            1uy
        else
            0uy
    let v306 : string = method24()
    let v307 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v308 : string = v294.ToString v306 
    let _v307 = v308 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v309 : string = v294.ToString v306 
    let _v307 = v309 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v310 : string = v294.ToString v306 
    let _v307 = v310 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v311 : string = v294.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _v307 = v311 
    #endif
#if FABLE_COMPILER_PYTHON
    let v312 : string = v294.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _v307 = v312 
    #endif
#else
    let v313 : string = v294.ToString v306 
    let _v307 = v313 
    #endif
    let v314 : string = _v307 
    let v317 : string = $"{v305}{v314.[0..1]}{v314.[3..4]}"
    let v318 : (System.Guid -> string) = _.ToString()
    let v319 : string = v318 v0
    let v322 : System.Guid = System.Guid $"{v227}{v317}{v319.[v227.Length + v317.Length..]}"
    let _v2 = v322 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v323 : System.Guid = null |> unbox<System.Guid>
    let _v2 = v323 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v326 : string = method25()
    let v327 : (string -> string) = v1.ToString
    let v328 : string = v327 v326
    let v331 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v332 : string = "0i64.into()"
    let v333 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v332 
    let _v331 = v333 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v334 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v331 = v334 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v337 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v331 = v337 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v340 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v331 = v340 
    #endif
#if FABLE_COMPILER_PYTHON
    let v343 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v331 = v343 
    #endif
#else
    let v346 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v331 = v346 
    #endif
    let v347 : System.TimeZoneInfo = _v331 
    let v352 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v353 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v354 : System.TimeSpan = v353 ()
    let _v352 = v354 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v357 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v358 : System.TimeSpan = v357 ()
    let _v352 = v358 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v361 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v362 : System.TimeSpan = v361 ()
    let _v352 = v362 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v365 : US4 = US4_0
    let v366 : US5 = US5_3(v365)
    let v367 : string = $"date_time.get_utc_offset / target: {v366}"
    let v368 : System.TimeSpan = failwith<System.TimeSpan> v367
    let _v352 = v368 
    #endif
#if FABLE_COMPILER_PYTHON
    let v369 : US4 = US4_0
    let v370 : US5 = US5_4(v369)
    let v371 : string = $"date_time.get_utc_offset / target: {v370}"
    let v372 : System.TimeSpan = failwith<System.TimeSpan> v371
    let _v352 = v372 
    #endif
#else
    let v373 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v374 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v375 : string = "0i64.into()"
    let v376 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v375 
    let _v374 = v376 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v377 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v374 = v377 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v380 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v374 = v380 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v383 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v374 = v383 
    #endif
#if FABLE_COMPILER_PYTHON
    let v386 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v374 = v386 
    #endif
#else
    let v389 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v374 = v389 
    #endif
    let v390 : System.TimeZoneInfo = _v374 
    let v395 : (System.DateTime -> System.TimeSpan) = v373 v390
    let v396 : System.TimeSpan = v395 v1
    let _v352 = v396 
    #endif
    let v397 : System.TimeSpan = _v352 
    let v403 : (System.TimeSpan -> int32) = _.Hours
    let v404 : int32 = v403 v397
    let v407 : bool = v404 > 0
    let v408 : uint8 =
        if v407 then
            1uy
        else
            0uy
    let v409 : string = method26()
    let v410 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v411 : string = v397.ToString v409 
    let _v410 = v411 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v412 : string = v397.ToString v409 
    let _v410 = v412 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v413 : string = v397.ToString v409 
    let _v410 = v413 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v414 : string = v397.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _v410 = v414 
    #endif
#if FABLE_COMPILER_PYTHON
    let v415 : string = v397.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _v410 = v415 
    #endif
#else
    let v416 : string = v397.ToString v409 
    let _v410 = v416 
    #endif
    let v417 : string = _v410 
    let v420 : string = $"{v408}{v417}"
    let v421 : (System.Guid -> string) = _.ToString()
    let v422 : string = v421 v0
    let v425 : System.Guid = System.Guid $"{v328}{v420}{v422.[v328.Length + v420.Length..]}"
    let _v2 = v425 
    #endif
#if FABLE_COMPILER_PYTHON
    let v426 : string = method25()
    let v427 : (string -> string) = v1.ToString
    let v428 : string = v427 v426
    let v431 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v432 : string = "0i64.into()"
    let v433 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v432 
    let _v431 = v433 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v434 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v431 = v434 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v437 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v431 = v437 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v440 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v431 = v440 
    #endif
#if FABLE_COMPILER_PYTHON
    let v443 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v431 = v443 
    #endif
#else
    let v446 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v431 = v446 
    #endif
    let v447 : System.TimeZoneInfo = _v431 
    let v452 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v453 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v454 : System.TimeSpan = v453 ()
    let _v452 = v454 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v457 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v458 : System.TimeSpan = v457 ()
    let _v452 = v458 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v461 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v462 : System.TimeSpan = v461 ()
    let _v452 = v462 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v465 : US4 = US4_0
    let v466 : US5 = US5_3(v465)
    let v467 : string = $"date_time.get_utc_offset / target: {v466}"
    let v468 : System.TimeSpan = failwith<System.TimeSpan> v467
    let _v452 = v468 
    #endif
#if FABLE_COMPILER_PYTHON
    let v469 : US4 = US4_0
    let v470 : US5 = US5_4(v469)
    let v471 : string = $"date_time.get_utc_offset / target: {v470}"
    let v472 : System.TimeSpan = failwith<System.TimeSpan> v471
    let _v452 = v472 
    #endif
#else
    let v473 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v474 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v475 : string = "0i64.into()"
    let v476 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v475 
    let _v474 = v476 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v477 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v474 = v477 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v480 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v474 = v480 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v483 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v474 = v483 
    #endif
#if FABLE_COMPILER_PYTHON
    let v486 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v474 = v486 
    #endif
#else
    let v489 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v474 = v489 
    #endif
    let v490 : System.TimeZoneInfo = _v474 
    let v495 : (System.DateTime -> System.TimeSpan) = v473 v490
    let v496 : System.TimeSpan = v495 v1
    let _v452 = v496 
    #endif
    let v497 : System.TimeSpan = _v452 
    let v503 : (System.TimeSpan -> int32) = _.Hours
    let v504 : int32 = v503 v497
    let v507 : bool = v504 > 0
    let v508 : uint8 =
        if v507 then
            1uy
        else
            0uy
    let v509 : string = method26()
    let v510 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v511 : string = v497.ToString v509 
    let _v510 = v511 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v512 : string = v497.ToString v509 
    let _v510 = v512 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v513 : string = v497.ToString v509 
    let _v510 = v513 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v514 : string = v497.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _v510 = v514 
    #endif
#if FABLE_COMPILER_PYTHON
    let v515 : string = v497.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _v510 = v515 
    #endif
#else
    let v516 : string = v497.ToString v509 
    let _v510 = v516 
    #endif
    let v517 : string = _v510 
    let v520 : string = $"{v508}{v517}"
    let v521 : (System.Guid -> string) = _.ToString()
    let v522 : string = v521 v0
    let v525 : System.Guid = System.Guid $"{v428}{v520}{v522.[v428.Length + v520.Length..]}"
    let _v2 = v525 
    #endif
#else
    let v526 : string = method25()
    let v527 : (string -> string) = v1.ToString
    let v528 : string = v527 v526
    let v531 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v532 : string = "0i64.into()"
    let v533 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v532 
    let _v531 = v533 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v534 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v531 = v534 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v537 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v531 = v537 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v540 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v531 = v540 
    #endif
#if FABLE_COMPILER_PYTHON
    let v543 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v531 = v543 
    #endif
#else
    let v546 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v531 = v546 
    #endif
    let v547 : System.TimeZoneInfo = _v531 
    let v552 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v553 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v554 : System.TimeSpan = v553 ()
    let _v552 = v554 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v557 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v558 : System.TimeSpan = v557 ()
    let _v552 = v558 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v561 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v562 : System.TimeSpan = v561 ()
    let _v552 = v562 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v565 : US4 = US4_0
    let v566 : US5 = US5_3(v565)
    let v567 : string = $"date_time.get_utc_offset / target: {v566}"
    let v568 : System.TimeSpan = failwith<System.TimeSpan> v567
    let _v552 = v568 
    #endif
#if FABLE_COMPILER_PYTHON
    let v569 : US4 = US4_0
    let v570 : US5 = US5_4(v569)
    let v571 : string = $"date_time.get_utc_offset / target: {v570}"
    let v572 : System.TimeSpan = failwith<System.TimeSpan> v571
    let _v552 = v572 
    #endif
#else
    let v573 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v574 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v575 : string = "0i64.into()"
    let v576 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v575 
    let _v574 = v576 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v577 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v574 = v577 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v580 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v574 = v580 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v583 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v574 = v583 
    #endif
#if FABLE_COMPILER_PYTHON
    let v586 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    let _v574 = v586 
    #endif
#else
    let v589 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    let _v574 = v589 
    #endif
    let v590 : System.TimeZoneInfo = _v574 
    let v595 : (System.DateTime -> System.TimeSpan) = v573 v590
    let v596 : System.TimeSpan = v595 v1
    let _v552 = v596 
    #endif
    let v597 : System.TimeSpan = _v552 
    let v603 : (System.TimeSpan -> int32) = _.Hours
    let v604 : int32 = v603 v597
    let v607 : bool = v604 > 0
    let v608 : uint8 =
        if v607 then
            1uy
        else
            0uy
    let v609 : string = method26()
    let v610 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v611 : string = v597.ToString v609 
    let _v610 = v611 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v612 : string = v597.ToString v609 
    let _v610 = v612 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v613 : string = v597.ToString v609 
    let _v610 = v613 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v614 : string = v597.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _v610 = v614 
    #endif
#if FABLE_COMPILER_PYTHON
    let v615 : string = v597.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    let _v610 = v615 
    #endif
#else
    let v616 : string = v597.ToString v609 
    let _v610 = v616 
    #endif
    let v617 : string = _v610 
    let v620 : string = $"{v608}{v617}"
    let v621 : (System.Guid -> string) = _.ToString()
    let v622 : string = v621 v0
    let v625 : System.Guid = System.Guid $"{v528}{v620}{v622.[v528.Length + v620.Length..]}"
    let _v2 = v625 
    #endif
    let v626 : System.Guid = _v2 
    v626
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
and closure25 () () : string =
    method22()
and method36 (v0 : string) : string =
    v0
and closure27 () (v0 : std_io_Error) : std_string_String =
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
    closure27()
and closure28 () () : US12 =
    US12_0
and closure29 () (v0 : std_string_String) : US12 =
    US12_1(v0)
and closure30 () () : string =
    let v0 : string = "file_system.create_dir"
    v0
and closure31 () () : string =
    let v0 : string = "file_system.create_dir"
    v0
and closure32 (v0 : string) () : unit =
    let v1 : bool = true
    method6(v1, v0)
and method38 (v0 : string) : (unit -> unit) =
    closure32(v0)
and method39 (v0 : string) : (unit -> unit) =
    closure32(v0)
and closure33 () () : string =
    let v0 : string = "file_system.create_dir"
    v0
and closure34 (v0 : string) () : unit =
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
    closure34(v0)
and method41 (v0 : string) : (unit -> unit) =
    closure34(v0)
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
    let v8 : (unit -> US12) = closure28()
    let v9 : (std_string_String -> US12) = closure29()
    let v10 : US12 = match v7 with Ok () -> v8 () | Error x -> v9 x
    match v10 with
    | US12_1(v683) -> (* Error *)
        let v684 : bool = State.trace_state.IsNone
        if v684 then
            let v685 : US0 = US0_0
            let struct (v686 : Mut0, v687 : Mut1, v688 : Mut2, v689 : Mut3, v690 : int64 option) = method0(v685)
            let v691 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v686, v687, v688, v689, v690) 
            State.trace_state <- v691 
            ()
        let struct (v696 : Mut0, v697 : Mut1, v698 : Mut2, v699 : Mut3, v700 : int64 option) = State.trace_state.Value
        let v711 : bool = State.trace_state.IsNone
        if v711 then
            let v712 : US0 = US0_0
            let struct (v713 : Mut0, v714 : Mut1, v715 : Mut2, v716 : Mut3, v717 : int64 option) = method0(v712)
            let v718 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v713, v714, v715, v716, v717) 
            State.trace_state <- v718 
            ()
        let struct (v723 : Mut0, v724 : Mut1, v725 : Mut2, v726 : Mut3, v727 : int64 option) = State.trace_state.Value
        let v738 : US0 = v726.l0
        let v739 : bool = v725.l0
        let v740 : bool = v739 = false
        let v743 : bool =
            if v740 then
                false
            else
                let v741 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v738
                let v742 : bool = 4 >= v741
                v742
        if v743 then
            let v744 : int64 = v696.l0
            let v745 : int64 = v744 + 1L
            v696.l0 <- v745
            let v746 : bool = State.trace_state.IsNone
            if v746 then
                let v747 : US0 = US0_0
                let struct (v748 : Mut0, v749 : Mut1, v750 : Mut2, v751 : Mut3, v752 : int64 option) = method0(v747)
                let v753 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v748, v749, v750, v751, v752) 
                State.trace_state <- v753 
                ()
            let struct (v758 : Mut0, v759 : Mut1, v760 : Mut2, v761 : Mut3, v762 : int64 option) = State.trace_state.Value
            let v773 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v774 : US3 option = None
            let _v774 = ref v774 
            match v762 with
            | Some x -> (
            (fun () ->
            (fun () ->
            let v775 : int64 = x
            let v776 : US3 = US3_0(v775)
            v776 
            )
            |> fun x -> x () |> Some
            ) () ) | None -> None
            |> fun x -> _v774.Value <- x
            let v777 : US3 option = _v774.Value 
            let v788 : US3 = US3_1
            let v789 : US3 = v777 |> Option.defaultValue v788 
            let v829 : System.DateTime =
                match v789 with
                | US3_1 -> (* None *)
                    let v825 : System.DateTime = System.DateTime.Now
                    v825
                | US3_0(v793) -> (* Some *)
                    let v794 : System.DateTime = System.DateTime.Now
                    let v797 : (System.DateTime -> int64) = _.Ticks
                    let v798 : int64 = v797 v794
                    let v801 : int64 = v798 - v793
                    let v802 : (int64 -> System.TimeSpan) = System.TimeSpan 
                    let v803 : System.TimeSpan = v802 v801
                    let v806 : (System.TimeSpan -> int32) = _.Hours
                    let v807 : int32 = v806 v803
                    let v810 : (System.TimeSpan -> int32) = _.Minutes
                    let v811 : int32 = v810 v803
                    let v814 : (System.TimeSpan -> int32) = _.Seconds
                    let v815 : int32 = v814 v803
                    let v818 : (System.TimeSpan -> int32) = _.Milliseconds
                    let v819 : int32 = v818 v803
                    let v822 : System.DateTime = System.DateTime (1, 1, 1, v807, v811, v815, v819)
                    v822
            let v830 : string = method9()
            let v833 : (string -> string) = v829.ToString
            let v834 : string = v833 v830
            let _v773 = v834 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v837 : US3 option = None
            let _v837 = ref v837 
            match v762 with
            | Some x -> (
            (fun () ->
            (fun () ->
            let v838 : int64 = x
            let v839 : US3 = US3_0(v838)
            v839 
            )
            |> fun x -> x () |> Some
            ) () ) | None -> None
            |> fun x -> _v837.Value <- x
            let v840 : US3 option = _v837.Value 
            let v851 : US3 = US3_1
            let v852 : US3 = v840 |> Option.defaultValue v851 
            let v892 : System.DateTime =
                match v852 with
                | US3_1 -> (* None *)
                    let v888 : System.DateTime = System.DateTime.Now
                    v888
                | US3_0(v856) -> (* Some *)
                    let v857 : System.DateTime = System.DateTime.Now
                    let v860 : (System.DateTime -> int64) = _.Ticks
                    let v861 : int64 = v860 v857
                    let v864 : int64 = v861 - v856
                    let v865 : (int64 -> System.TimeSpan) = System.TimeSpan 
                    let v866 : System.TimeSpan = v865 v864
                    let v869 : (System.TimeSpan -> int32) = _.Hours
                    let v870 : int32 = v869 v866
                    let v873 : (System.TimeSpan -> int32) = _.Minutes
                    let v874 : int32 = v873 v866
                    let v877 : (System.TimeSpan -> int32) = _.Seconds
                    let v878 : int32 = v877 v866
                    let v881 : (System.TimeSpan -> int32) = _.Milliseconds
                    let v882 : int32 = v881 v866
                    let v885 : System.DateTime = System.DateTime (1, 1, 1, v870, v874, v878, v882)
                    v885
            let v893 : string = method9()
            let v896 : (string -> string) = v892.ToString
            let v897 : string = v896 v893
            let _v773 = v897 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v900 : string = $"near_sdk::env::block_timestamp()"
            let v901 : uint64 = Fable.Core.RustInterop.emitRustExpr () v900 
            let v902 : US3 option = None
            let _v902 = ref v902 
            match v762 with
            | Some x -> (
            (fun () ->
            (fun () ->
            let v903 : int64 = x
            let v904 : US3 = US3_0(v903)
            v904 
            )
            |> fun x -> x () |> Some
            ) () ) | None -> None
            |> fun x -> _v902.Value <- x
            let v905 : US3 option = _v902.Value 
            let v916 : US3 = US3_1
            let v917 : US3 = v905 |> Option.defaultValue v916 
            let v926 : uint64 =
                match v917 with
                | US3_1 -> (* None *)
                    v901
                | US3_0(v921) -> (* Some *)
                    let v922 : (int64 -> uint64) = uint64
                    let v923 : uint64 = v922 v921
                    let v924 : uint64 = v901 - v923
                    v924
            let v927 : uint64 = v926 / 1000000000UL
            let v928 : uint64 = v927 % 60UL
            let v929 : uint64 = v927 / 60UL
            let v930 : uint64 = v929 % 60UL
            let v931 : uint64 = v927 / 3600UL
            let v932 : uint64 = v931 % 24UL
            let v933 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
            let v934 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v932, v930, v928) v933 
            let v935 : string = "fable_library_rust::String_::fromString($0)"
            let v936 : string = Fable.Core.RustInterop.emitRustExpr v934 v935 
            let _v773 = v936 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v937 : US3 option = None
            let _v937 = ref v937 
            match v762 with
            | Some x -> (
            (fun () ->
            (fun () ->
            let v938 : int64 = x
            let v939 : US3 = US3_0(v938)
            v939 
            )
            |> fun x -> x () |> Some
            ) () ) | None -> None
            |> fun x -> _v937.Value <- x
            let v940 : US3 option = _v937.Value 
            let v951 : US3 = US3_1
            let v952 : US3 = v940 |> Option.defaultValue v951 
            let v992 : System.DateTime =
                match v952 with
                | US3_1 -> (* None *)
                    let v988 : System.DateTime = System.DateTime.Now
                    v988
                | US3_0(v956) -> (* Some *)
                    let v957 : System.DateTime = System.DateTime.Now
                    let v960 : (System.DateTime -> int64) = _.Ticks
                    let v961 : int64 = v960 v957
                    let v964 : int64 = v961 - v956
                    let v965 : (int64 -> System.TimeSpan) = System.TimeSpan 
                    let v966 : System.TimeSpan = v965 v964
                    let v969 : (System.TimeSpan -> int32) = _.Hours
                    let v970 : int32 = v969 v966
                    let v973 : (System.TimeSpan -> int32) = _.Minutes
                    let v974 : int32 = v973 v966
                    let v977 : (System.TimeSpan -> int32) = _.Seconds
                    let v978 : int32 = v977 v966
                    let v981 : (System.TimeSpan -> int32) = _.Milliseconds
                    let v982 : int32 = v981 v966
                    let v985 : System.DateTime = System.DateTime (1, 1, 1, v970, v974, v978, v982)
                    v985
            let v993 : string = method10()
            let v996 : (string -> string) = v992.ToString
            let v997 : string = v996 v993
            let _v773 = v997 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1000 : US3 option = None
            let _v1000 = ref v1000 
            match v762 with
            | Some x -> (
            (fun () ->
            (fun () ->
            let v1001 : int64 = x
            let v1002 : US3 = US3_0(v1001)
            v1002 
            )
            |> fun x -> x () |> Some
            ) () ) | None -> None
            |> fun x -> _v1000.Value <- x
            let v1003 : US3 option = _v1000.Value 
            let v1014 : US3 = US3_1
            let v1015 : US3 = v1003 |> Option.defaultValue v1014 
            let v1055 : System.DateTime =
                match v1015 with
                | US3_1 -> (* None *)
                    let v1051 : System.DateTime = System.DateTime.Now
                    v1051
                | US3_0(v1019) -> (* Some *)
                    let v1020 : System.DateTime = System.DateTime.Now
                    let v1023 : (System.DateTime -> int64) = _.Ticks
                    let v1024 : int64 = v1023 v1020
                    let v1027 : int64 = v1024 - v1019
                    let v1028 : (int64 -> System.TimeSpan) = System.TimeSpan 
                    let v1029 : System.TimeSpan = v1028 v1027
                    let v1032 : (System.TimeSpan -> int32) = _.Hours
                    let v1033 : int32 = v1032 v1029
                    let v1036 : (System.TimeSpan -> int32) = _.Minutes
                    let v1037 : int32 = v1036 v1029
                    let v1040 : (System.TimeSpan -> int32) = _.Seconds
                    let v1041 : int32 = v1040 v1029
                    let v1044 : (System.TimeSpan -> int32) = _.Milliseconds
                    let v1045 : int32 = v1044 v1029
                    let v1048 : System.DateTime = System.DateTime (1, 1, 1, v1033, v1037, v1041, v1045)
                    v1048
            let v1056 : string = method10()
            let v1059 : (string -> string) = v1055.ToString
            let v1060 : string = v1059 v1056
            let _v773 = v1060 
            #endif
#else
            let v1063 : US3 option = None
            let _v1063 = ref v1063 
            match v762 with
            | Some x -> (
            (fun () ->
            (fun () ->
            let v1064 : int64 = x
            let v1065 : US3 = US3_0(v1064)
            v1065 
            )
            |> fun x -> x () |> Some
            ) () ) | None -> None
            |> fun x -> _v1063.Value <- x
            let v1066 : US3 option = _v1063.Value 
            let v1077 : US3 = US3_1
            let v1078 : US3 = v1066 |> Option.defaultValue v1077 
            let v1118 : System.DateTime =
                match v1078 with
                | US3_1 -> (* None *)
                    let v1114 : System.DateTime = System.DateTime.Now
                    v1114
                | US3_0(v1082) -> (* Some *)
                    let v1083 : System.DateTime = System.DateTime.Now
                    let v1086 : (System.DateTime -> int64) = _.Ticks
                    let v1087 : int64 = v1086 v1083
                    let v1090 : int64 = v1087 - v1082
                    let v1091 : (int64 -> System.TimeSpan) = System.TimeSpan 
                    let v1092 : System.TimeSpan = v1091 v1090
                    let v1095 : (System.TimeSpan -> int32) = _.Hours
                    let v1096 : int32 = v1095 v1092
                    let v1099 : (System.TimeSpan -> int32) = _.Minutes
                    let v1100 : int32 = v1099 v1092
                    let v1103 : (System.TimeSpan -> int32) = _.Seconds
                    let v1104 : int32 = v1103 v1092
                    let v1107 : (System.TimeSpan -> int32) = _.Milliseconds
                    let v1108 : int32 = v1107 v1092
                    let v1111 : System.DateTime = System.DateTime (1, 1, 1, v1096, v1100, v1104, v1108)
                    v1111
            let v1119 : string = method10()
            let v1122 : (string -> string) = v1118.ToString
            let v1123 : string = v1122 v1119
            let _v773 = v1123 
            #endif
            let v1126 : string = _v773 
            let v1191 : string = "Critical"
            let v1192 : (unit -> string) = v1191.ToLower
            let v1193 : string = v1192 ()
            let v1196 : string = v1193.PadLeft (7, ' ')
            let v1210 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1211 : string = "inline_colorization::color_bright_red"
            let v1212 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1211 
            let v1213 : string = "&*$0"
            let v1214 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1196 v1213 
            let v1215 : string = "inline_colorization::color_reset"
            let v1216 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1215 
            let v1217 : string = "\"{v1212}{v1214}{v1216}\""
            let v1218 : string = @$"format!(" + v1217 + ")"
            let v1219 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v1218 
            let v1220 : string = "fable_library_rust::String_::fromString($0)"
            let v1221 : string = Fable.Core.RustInterop.emitRustExpr v1219 v1220 
            let _v1210 = v1221 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1222 : string = "inline_colorization::color_bright_red"
            let v1223 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1222 
            let v1224 : string = "&*$0"
            let v1225 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1196 v1224 
            let v1226 : string = "inline_colorization::color_reset"
            let v1227 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1226 
            let v1228 : string = "\"{v1223}{v1225}{v1227}\""
            let v1229 : string = @$"format!(" + v1228 + ")"
            let v1230 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v1229 
            let v1231 : string = "fable_library_rust::String_::fromString($0)"
            let v1232 : string = Fable.Core.RustInterop.emitRustExpr v1230 v1231 
            let _v1210 = v1232 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1233 : string = "inline_colorization::color_bright_red"
            let v1234 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1233 
            let v1235 : string = "&*$0"
            let v1236 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1196 v1235 
            let v1237 : string = "inline_colorization::color_reset"
            let v1238 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1237 
            let v1239 : string = "\"{v1234}{v1236}{v1238}\""
            let v1240 : string = @$"format!(" + v1239 + ")"
            let v1241 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v1240 
            let v1242 : string = "fable_library_rust::String_::fromString($0)"
            let v1243 : string = Fable.Core.RustInterop.emitRustExpr v1241 v1242 
            let _v1210 = v1243 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1244 : string = "\u001b[91m"
            let v1245 : string = method11()
            let v1246 : string = v1244 + v1196 
            let v1247 : string = v1246 + v1245 
            let _v1210 = v1247 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1248 : string = "\u001b[91m"
            let v1249 : string = method11()
            let v1250 : string = v1248 + v1196 
            let v1251 : string = v1250 + v1249 
            let _v1210 = v1251 
            #endif
#else
            let v1252 : string = "\u001b[91m"
            let v1253 : string = method11()
            let v1254 : string = v1252 + v1196 
            let v1255 : string = v1254 + v1253 
            let _v1210 = v1255 
            #endif
            let v1256 : string = _v1210 
            let v1262 : int64 = v758.l0
            let v1263 : string = method13()
            let v1264 : Mut4 = {l0 = v1263} : Mut4
            let v1265 : string = "{ "
            let v1266 : string = $"{v1265}"
            let v1269 : string = v1264.l0
            let v1270 : string = v1269 + v1266 
            v1264.l0 <- v1270
            let v1271 : string = "dir"
            let v1272 : string = $"{v1271}"
            let v1275 : string = v1264.l0
            let v1276 : string = v1275 + v1272 
            v1264.l0 <- v1276
            let v1277 : string = " = "
            let v1278 : string = $"{v1277}"
            let v1281 : string = v1264.l0
            let v1282 : string = v1281 + v1278 
            v1264.l0 <- v1282
            let v1283 : string = $"{v2}"
            let v1286 : string = v1264.l0
            let v1287 : string = v1286 + v1283 
            v1264.l0 <- v1287
            let v1288 : string = "; "
            let v1289 : string = $"{v1288}"
            let v1292 : string = v1264.l0
            let v1293 : string = v1292 + v1289 
            v1264.l0 <- v1293
            let v1294 : string = "error"
            let v1295 : string = $"{v1294}"
            let v1298 : string = v1264.l0
            let v1299 : string = v1298 + v1295 
            v1264.l0 <- v1299
            let v1300 : string = $"{v1277}"
            let v1303 : string = v1264.l0
            let v1304 : string = v1303 + v1300 
            v1264.l0 <- v1304
            let v1305 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1306 : string = "format!(\"{:#?}\", $0)"
            let v1307 : std_string_String = Fable.Core.RustInterop.emitRustExpr v683 v1306 
            let v1308 : string = "fable_library_rust::String_::fromString($0)"
            let v1309 : string = Fable.Core.RustInterop.emitRustExpr v1307 v1308 
            let _v1305 = v1309 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1310 : string = "format!(\"{:#?}\", $0)"
            let v1311 : std_string_String = Fable.Core.RustInterop.emitRustExpr v683 v1310 
            let v1312 : string = "fable_library_rust::String_::fromString($0)"
            let v1313 : string = Fable.Core.RustInterop.emitRustExpr v1311 v1312 
            let _v1305 = v1313 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1314 : string = "format!(\"{:#?}\", $0)"
            let v1315 : std_string_String = Fable.Core.RustInterop.emitRustExpr v683 v1314 
            let v1316 : string = "fable_library_rust::String_::fromString($0)"
            let v1317 : string = Fable.Core.RustInterop.emitRustExpr v1315 v1316 
            let _v1305 = v1317 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1318 : string = $"%A{v683}"
            let _v1305 = v1318 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1321 : string = $"%A{v683}"
            let _v1305 = v1321 
            #endif
#else
            let v1324 : string = $"%A{v683}"
            let _v1305 = v1324 
            #endif
            let v1327 : string = _v1305 
            let v1332 : string = $"{v1327}"
            let v1335 : string = v1264.l0
            let v1336 : string = v1335 + v1332 
            v1264.l0 <- v1336
            let v1337 : string = " }"
            let v1338 : string = $"{v1337}"
            let v1341 : string = v1264.l0
            let v1342 : string = v1341 + v1338 
            v1264.l0 <- v1342
            let v1343 : string = v1264.l0
            let v1344 : (unit -> string) = closure30()
            let v1345 : string = $"{v1126} {v1256} #{v1262} %s{v1344 ()} / {v1343}"
            let v1348 : char list = []
            let v1349 : (char list -> (char [])) = List.toArray
            let v1350 : (char []) = v1349 v1348
            let v1353 : string = v1345.TrimStart v1350 
            let v1371 : char list = []
            let v1372 : char list = '/' :: v1371 
            let v1375 : char list = ' ' :: v1372 
            let v1378 : (char list -> (char [])) = List.toArray
            let v1379 : (char []) = v1378 v1375
            let v1382 : string = v1353.TrimEnd v1379 
            let v1400 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1401 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v1382 v1401 
            let _v1400 = () 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1402 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v1382 v1402 
            let _v1400 = () 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1403 : string = $"near_sdk::log!(\"{{}}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v1382 v1403 
            let _v1400 = () 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            System.Console.WriteLine v1382 
            let _v1400 = () 
            #endif
#if FABLE_COMPILER_PYTHON
            System.Console.WriteLine v1382 
            let _v1400 = () 
            #endif
#else
            System.Console.WriteLine v1382 
            let _v1400 = () 
            #endif
            _v1400 
            let v1404 : (string -> unit) = v697.l0
            v1404 v1382
    | US12_0 -> (* Ok *)
        let v11 : bool = State.trace_state.IsNone
        if v11 then
            let v12 : US0 = US0_0
            let struct (v13 : Mut0, v14 : Mut1, v15 : Mut2, v16 : Mut3, v17 : int64 option) = method0(v12)
            let v18 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v13, v14, v15, v16, v17) 
            State.trace_state <- v18 
            ()
        let struct (v23 : Mut0, v24 : Mut1, v25 : Mut2, v26 : Mut3, v27 : int64 option) = State.trace_state.Value
        let v38 : bool = State.trace_state.IsNone
        if v38 then
            let v39 : US0 = US0_0
            let struct (v40 : Mut0, v41 : Mut1, v42 : Mut2, v43 : Mut3, v44 : int64 option) = method0(v39)
            let v45 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v40, v41, v42, v43, v44) 
            State.trace_state <- v45 
            ()
        let struct (v50 : Mut0, v51 : Mut1, v52 : Mut2, v53 : Mut3, v54 : int64 option) = State.trace_state.Value
        let v65 : US0 = v53.l0
        let v66 : bool = v52.l0
        let v67 : bool = v66 = false
        let v70 : bool =
            if v67 then
                false
            else
                let v68 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v65
                let v69 : bool = 0 >= v68
                v69
        if v70 then
            let v71 : int64 = v23.l0
            let v72 : int64 = v71 + 1L
            v23.l0 <- v72
            let v73 : bool = State.trace_state.IsNone
            if v73 then
                let v74 : US0 = US0_0
                let struct (v75 : Mut0, v76 : Mut1, v77 : Mut2, v78 : Mut3, v79 : int64 option) = method0(v74)
                let v80 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v75, v76, v77, v78, v79) 
                State.trace_state <- v80 
                ()
            let struct (v85 : Mut0, v86 : Mut1, v87 : Mut2, v88 : Mut3, v89 : int64 option) = State.trace_state.Value
            let v100 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v101 : US3 option = None
            let _v101 = ref v101 
            match v89 with
            | Some x -> (
            (fun () ->
            (fun () ->
            let v102 : int64 = x
            let v103 : US3 = US3_0(v102)
            v103 
            )
            |> fun x -> x () |> Some
            ) () ) | None -> None
            |> fun x -> _v101.Value <- x
            let v104 : US3 option = _v101.Value 
            let v115 : US3 = US3_1
            let v116 : US3 = v104 |> Option.defaultValue v115 
            let v156 : System.DateTime =
                match v116 with
                | US3_1 -> (* None *)
                    let v152 : System.DateTime = System.DateTime.Now
                    v152
                | US3_0(v120) -> (* Some *)
                    let v121 : System.DateTime = System.DateTime.Now
                    let v124 : (System.DateTime -> int64) = _.Ticks
                    let v125 : int64 = v124 v121
                    let v128 : int64 = v125 - v120
                    let v129 : (int64 -> System.TimeSpan) = System.TimeSpan 
                    let v130 : System.TimeSpan = v129 v128
                    let v133 : (System.TimeSpan -> int32) = _.Hours
                    let v134 : int32 = v133 v130
                    let v137 : (System.TimeSpan -> int32) = _.Minutes
                    let v138 : int32 = v137 v130
                    let v141 : (System.TimeSpan -> int32) = _.Seconds
                    let v142 : int32 = v141 v130
                    let v145 : (System.TimeSpan -> int32) = _.Milliseconds
                    let v146 : int32 = v145 v130
                    let v149 : System.DateTime = System.DateTime (1, 1, 1, v134, v138, v142, v146)
                    v149
            let v157 : string = method9()
            let v160 : (string -> string) = v156.ToString
            let v161 : string = v160 v157
            let _v100 = v161 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v164 : US3 option = None
            let _v164 = ref v164 
            match v89 with
            | Some x -> (
            (fun () ->
            (fun () ->
            let v165 : int64 = x
            let v166 : US3 = US3_0(v165)
            v166 
            )
            |> fun x -> x () |> Some
            ) () ) | None -> None
            |> fun x -> _v164.Value <- x
            let v167 : US3 option = _v164.Value 
            let v178 : US3 = US3_1
            let v179 : US3 = v167 |> Option.defaultValue v178 
            let v219 : System.DateTime =
                match v179 with
                | US3_1 -> (* None *)
                    let v215 : System.DateTime = System.DateTime.Now
                    v215
                | US3_0(v183) -> (* Some *)
                    let v184 : System.DateTime = System.DateTime.Now
                    let v187 : (System.DateTime -> int64) = _.Ticks
                    let v188 : int64 = v187 v184
                    let v191 : int64 = v188 - v183
                    let v192 : (int64 -> System.TimeSpan) = System.TimeSpan 
                    let v193 : System.TimeSpan = v192 v191
                    let v196 : (System.TimeSpan -> int32) = _.Hours
                    let v197 : int32 = v196 v193
                    let v200 : (System.TimeSpan -> int32) = _.Minutes
                    let v201 : int32 = v200 v193
                    let v204 : (System.TimeSpan -> int32) = _.Seconds
                    let v205 : int32 = v204 v193
                    let v208 : (System.TimeSpan -> int32) = _.Milliseconds
                    let v209 : int32 = v208 v193
                    let v212 : System.DateTime = System.DateTime (1, 1, 1, v197, v201, v205, v209)
                    v212
            let v220 : string = method9()
            let v223 : (string -> string) = v219.ToString
            let v224 : string = v223 v220
            let _v100 = v224 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v227 : string = $"near_sdk::env::block_timestamp()"
            let v228 : uint64 = Fable.Core.RustInterop.emitRustExpr () v227 
            let v229 : US3 option = None
            let _v229 = ref v229 
            match v89 with
            | Some x -> (
            (fun () ->
            (fun () ->
            let v230 : int64 = x
            let v231 : US3 = US3_0(v230)
            v231 
            )
            |> fun x -> x () |> Some
            ) () ) | None -> None
            |> fun x -> _v229.Value <- x
            let v232 : US3 option = _v229.Value 
            let v243 : US3 = US3_1
            let v244 : US3 = v232 |> Option.defaultValue v243 
            let v253 : uint64 =
                match v244 with
                | US3_1 -> (* None *)
                    v228
                | US3_0(v248) -> (* Some *)
                    let v249 : (int64 -> uint64) = uint64
                    let v250 : uint64 = v249 v248
                    let v251 : uint64 = v228 - v250
                    v251
            let v254 : uint64 = v253 / 1000000000UL
            let v255 : uint64 = v254 % 60UL
            let v256 : uint64 = v254 / 60UL
            let v257 : uint64 = v256 % 60UL
            let v258 : uint64 = v254 / 3600UL
            let v259 : uint64 = v258 % 24UL
            let v260 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
            let v261 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v259, v257, v255) v260 
            let v262 : string = "fable_library_rust::String_::fromString($0)"
            let v263 : string = Fable.Core.RustInterop.emitRustExpr v261 v262 
            let _v100 = v263 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v264 : US3 option = None
            let _v264 = ref v264 
            match v89 with
            | Some x -> (
            (fun () ->
            (fun () ->
            let v265 : int64 = x
            let v266 : US3 = US3_0(v265)
            v266 
            )
            |> fun x -> x () |> Some
            ) () ) | None -> None
            |> fun x -> _v264.Value <- x
            let v267 : US3 option = _v264.Value 
            let v278 : US3 = US3_1
            let v279 : US3 = v267 |> Option.defaultValue v278 
            let v319 : System.DateTime =
                match v279 with
                | US3_1 -> (* None *)
                    let v315 : System.DateTime = System.DateTime.Now
                    v315
                | US3_0(v283) -> (* Some *)
                    let v284 : System.DateTime = System.DateTime.Now
                    let v287 : (System.DateTime -> int64) = _.Ticks
                    let v288 : int64 = v287 v284
                    let v291 : int64 = v288 - v283
                    let v292 : (int64 -> System.TimeSpan) = System.TimeSpan 
                    let v293 : System.TimeSpan = v292 v291
                    let v296 : (System.TimeSpan -> int32) = _.Hours
                    let v297 : int32 = v296 v293
                    let v300 : (System.TimeSpan -> int32) = _.Minutes
                    let v301 : int32 = v300 v293
                    let v304 : (System.TimeSpan -> int32) = _.Seconds
                    let v305 : int32 = v304 v293
                    let v308 : (System.TimeSpan -> int32) = _.Milliseconds
                    let v309 : int32 = v308 v293
                    let v312 : System.DateTime = System.DateTime (1, 1, 1, v297, v301, v305, v309)
                    v312
            let v320 : string = method10()
            let v323 : (string -> string) = v319.ToString
            let v324 : string = v323 v320
            let _v100 = v324 
            #endif
#if FABLE_COMPILER_PYTHON
            let v327 : US3 option = None
            let _v327 = ref v327 
            match v89 with
            | Some x -> (
            (fun () ->
            (fun () ->
            let v328 : int64 = x
            let v329 : US3 = US3_0(v328)
            v329 
            )
            |> fun x -> x () |> Some
            ) () ) | None -> None
            |> fun x -> _v327.Value <- x
            let v330 : US3 option = _v327.Value 
            let v341 : US3 = US3_1
            let v342 : US3 = v330 |> Option.defaultValue v341 
            let v382 : System.DateTime =
                match v342 with
                | US3_1 -> (* None *)
                    let v378 : System.DateTime = System.DateTime.Now
                    v378
                | US3_0(v346) -> (* Some *)
                    let v347 : System.DateTime = System.DateTime.Now
                    let v350 : (System.DateTime -> int64) = _.Ticks
                    let v351 : int64 = v350 v347
                    let v354 : int64 = v351 - v346
                    let v355 : (int64 -> System.TimeSpan) = System.TimeSpan 
                    let v356 : System.TimeSpan = v355 v354
                    let v359 : (System.TimeSpan -> int32) = _.Hours
                    let v360 : int32 = v359 v356
                    let v363 : (System.TimeSpan -> int32) = _.Minutes
                    let v364 : int32 = v363 v356
                    let v367 : (System.TimeSpan -> int32) = _.Seconds
                    let v368 : int32 = v367 v356
                    let v371 : (System.TimeSpan -> int32) = _.Milliseconds
                    let v372 : int32 = v371 v356
                    let v375 : System.DateTime = System.DateTime (1, 1, 1, v360, v364, v368, v372)
                    v375
            let v383 : string = method10()
            let v386 : (string -> string) = v382.ToString
            let v387 : string = v386 v383
            let _v100 = v387 
            #endif
#else
            let v390 : US3 option = None
            let _v390 = ref v390 
            match v89 with
            | Some x -> (
            (fun () ->
            (fun () ->
            let v391 : int64 = x
            let v392 : US3 = US3_0(v391)
            v392 
            )
            |> fun x -> x () |> Some
            ) () ) | None -> None
            |> fun x -> _v390.Value <- x
            let v393 : US3 option = _v390.Value 
            let v404 : US3 = US3_1
            let v405 : US3 = v393 |> Option.defaultValue v404 
            let v445 : System.DateTime =
                match v405 with
                | US3_1 -> (* None *)
                    let v441 : System.DateTime = System.DateTime.Now
                    v441
                | US3_0(v409) -> (* Some *)
                    let v410 : System.DateTime = System.DateTime.Now
                    let v413 : (System.DateTime -> int64) = _.Ticks
                    let v414 : int64 = v413 v410
                    let v417 : int64 = v414 - v409
                    let v418 : (int64 -> System.TimeSpan) = System.TimeSpan 
                    let v419 : System.TimeSpan = v418 v417
                    let v422 : (System.TimeSpan -> int32) = _.Hours
                    let v423 : int32 = v422 v419
                    let v426 : (System.TimeSpan -> int32) = _.Minutes
                    let v427 : int32 = v426 v419
                    let v430 : (System.TimeSpan -> int32) = _.Seconds
                    let v431 : int32 = v430 v419
                    let v434 : (System.TimeSpan -> int32) = _.Milliseconds
                    let v435 : int32 = v434 v419
                    let v438 : System.DateTime = System.DateTime (1, 1, 1, v423, v427, v431, v435)
                    v438
            let v446 : string = method10()
            let v449 : (string -> string) = v445.ToString
            let v450 : string = v449 v446
            let _v100 = v450 
            #endif
            let v453 : string = _v100 
            let v518 : string = "Verbose"
            let v519 : (unit -> string) = v518.ToLower
            let v520 : string = v519 ()
            let v523 : string = v520.PadLeft (7, ' ')
            let v537 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v538 : string = "inline_colorization::color_bright_black"
            let v539 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v538 
            let v540 : string = "&*$0"
            let v541 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v523 v540 
            let v542 : string = "inline_colorization::color_reset"
            let v543 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v542 
            let v544 : string = "\"{v539}{v541}{v543}\""
            let v545 : string = @$"format!(" + v544 + ")"
            let v546 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v545 
            let v547 : string = "fable_library_rust::String_::fromString($0)"
            let v548 : string = Fable.Core.RustInterop.emitRustExpr v546 v547 
            let _v537 = v548 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v549 : string = "inline_colorization::color_bright_black"
            let v550 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v549 
            let v551 : string = "&*$0"
            let v552 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v523 v551 
            let v553 : string = "inline_colorization::color_reset"
            let v554 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v553 
            let v555 : string = "\"{v550}{v552}{v554}\""
            let v556 : string = @$"format!(" + v555 + ")"
            let v557 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v556 
            let v558 : string = "fable_library_rust::String_::fromString($0)"
            let v559 : string = Fable.Core.RustInterop.emitRustExpr v557 v558 
            let _v537 = v559 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v560 : string = "inline_colorization::color_bright_black"
            let v561 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v560 
            let v562 : string = "&*$0"
            let v563 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v523 v562 
            let v564 : string = "inline_colorization::color_reset"
            let v565 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v564 
            let v566 : string = "\"{v561}{v563}{v565}\""
            let v567 : string = @$"format!(" + v566 + ")"
            let v568 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v567 
            let v569 : string = "fable_library_rust::String_::fromString($0)"
            let v570 : string = Fable.Core.RustInterop.emitRustExpr v568 v569 
            let _v537 = v570 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v571 : string = "\u001b[90m"
            let v572 : string = method11()
            let v573 : string = v571 + v523 
            let v574 : string = v573 + v572 
            let _v537 = v574 
            #endif
#if FABLE_COMPILER_PYTHON
            let v575 : string = "\u001b[90m"
            let v576 : string = method11()
            let v577 : string = v575 + v523 
            let v578 : string = v577 + v576 
            let _v537 = v578 
            #endif
#else
            let v579 : string = "\u001b[90m"
            let v580 : string = method11()
            let v581 : string = v579 + v523 
            let v582 : string = v581 + v580 
            let _v537 = v582 
            #endif
            let v583 : string = _v537 
            let v589 : int64 = v85.l0
            let v590 : string = method13()
            let v591 : Mut4 = {l0 = v590} : Mut4
            let v592 : string = "{ "
            let v593 : string = $"{v592}"
            let v596 : string = v591.l0
            let v597 : string = v596 + v593 
            v591.l0 <- v597
            let v598 : string = "dir"
            let v599 : string = $"{v598}"
            let v602 : string = v591.l0
            let v603 : string = v602 + v599 
            v591.l0 <- v603
            let v604 : string = " = "
            let v605 : string = $"{v604}"
            let v608 : string = v591.l0
            let v609 : string = v608 + v605 
            v591.l0 <- v609
            let v610 : string = $"{v2}"
            let v613 : string = v591.l0
            let v614 : string = v613 + v610 
            v591.l0 <- v614
            let v615 : string = " }"
            let v616 : string = $"{v615}"
            let v619 : string = v591.l0
            let v620 : string = v619 + v616 
            v591.l0 <- v620
            let v621 : string = v591.l0
            let v622 : (unit -> string) = closure31()
            let v623 : string = $"{v453} {v583} #{v589} %s{v622 ()} / {v621}"
            let v626 : char list = []
            let v627 : (char list -> (char [])) = List.toArray
            let v628 : (char []) = v627 v626
            let v631 : string = v623.TrimStart v628 
            let v649 : char list = []
            let v650 : char list = '/' :: v649 
            let v653 : char list = ' ' :: v650 
            let v656 : (char list -> (char [])) = List.toArray
            let v657 : (char []) = v656 v653
            let v660 : string = v631.TrimEnd v657 
            let v678 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v679 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v660 v679 
            let _v678 = () 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v680 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v660 v680 
            let _v678 = () 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v681 : string = $"near_sdk::log!(\"{{}}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v660 v681 
            let _v678 = () 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            System.Console.WriteLine v660 
            let _v678 = () 
            #endif
#if FABLE_COMPILER_PYTHON
            System.Console.WriteLine v660 
            let _v678 = () 
            #endif
#else
            System.Console.WriteLine v660 
            let _v678 = () 
            #endif
            _v678 
            let v682 : (string -> unit) = v24.l0
            v682 v660
    let v1405 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1406 : (unit -> unit) = method38(v2)
    let v1407 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v1406 "$0()" )
    let _v1405 = v1407 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1408 : (unit -> unit) = method38(v2)
    let v1409 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v1408 "$0()" )
    let _v1405 = v1409 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1410 : (unit -> unit) = method38(v2)
    let v1411 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v1410 "$0()" )
    let _v1405 = v1411 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1412 : (unit -> unit) = method39(v2)
    let v1413 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v1412 () }
    let _v1405 = v1413 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1414 : (unit -> unit) = method39(v2)
    let v1415 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v1414 () }
    let _v1405 = v1415 
    #endif
#else
    let v1416 : (unit -> unit) = method39(v2)
    let v1417 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v1416 () }
    let _v1405 = v1417 
    #endif
    let v1418 : System.IDisposable = _v1405 
    let _v1 = v1418 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1422 : System.IDisposable = null |> unbox<System.IDisposable>
    let _v1 = v1422 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1425 : System.IDisposable = null |> unbox<System.IDisposable>
    let _v1 = v1425 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1428 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1429 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    let _v1428 = v1429 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1432 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    let _v1428 = v1432 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1435 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    let _v1428 = v1435 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1438 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    let _v1428 = v1438 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1441 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    let _v1428 = v1441 
    #endif
#else
    let v1444 : (string -> System.IO.DirectoryInfo) = System.IO.Directory.CreateDirectory
    let v1445 : System.IO.DirectoryInfo = v1444 v0
    let _v1428 = v1445 
    #endif
    let v1446 : System.IO.DirectoryInfo = _v1428 
    let v1451 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1452 : bool = null |> unbox<bool>
    let _v1451 = v1452 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1455 : bool = null |> unbox<bool>
    let _v1451 = v1455 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1458 : bool = null |> unbox<bool>
    let _v1451 = v1458 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1461 : bool = null |> unbox<bool>
    let _v1451 = v1461 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1464 : bool = null |> unbox<bool>
    let _v1451 = v1464 
    #endif
#else
    let v1467 : bool = v1446.Exists
    let _v1451 = v1467 
    #endif
    let v1468 : bool = _v1451 
    let v1473 : bool = v1468 = false
    if v1473 then
        let v1474 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v1475 : System.DateTime = null |> unbox<System.DateTime>
        let _v1474 = v1475 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v1478 : System.DateTime = null |> unbox<System.DateTime>
        let _v1474 = v1478 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v1481 : System.DateTime = null |> unbox<System.DateTime>
        let _v1474 = v1481 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v1484 : System.DateTime = null |> unbox<System.DateTime>
        let _v1474 = v1484 
        #endif
#if FABLE_COMPILER_PYTHON
        let v1487 : System.DateTime = null |> unbox<System.DateTime>
        let _v1474 = v1487 
        #endif
#else
        let v1490 : System.DateTime = v1446.CreationTime
        let _v1474 = v1490 
        #endif
        let v1491 : System.DateTime = _v1474 
        let v1496 : obj = {| Exists = v1468; CreationTime = v1491 |}
        let v1497 : string = $"%A{v1496}"
        let v1500 : bool = State.trace_state.IsNone
        if v1500 then
            let v1501 : US0 = US0_0
            let struct (v1502 : Mut0, v1503 : Mut1, v1504 : Mut2, v1505 : Mut3, v1506 : int64 option) = method0(v1501)
            let v1507 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v1502, v1503, v1504, v1505, v1506) 
            State.trace_state <- v1507 
            ()
        let struct (v1512 : Mut0, v1513 : Mut1, v1514 : Mut2, v1515 : Mut3, v1516 : int64 option) = State.trace_state.Value
        let v1527 : bool = State.trace_state.IsNone
        if v1527 then
            let v1528 : US0 = US0_0
            let struct (v1529 : Mut0, v1530 : Mut1, v1531 : Mut2, v1532 : Mut3, v1533 : int64 option) = method0(v1528)
            let v1534 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v1529, v1530, v1531, v1532, v1533) 
            State.trace_state <- v1534 
            ()
        let struct (v1539 : Mut0, v1540 : Mut1, v1541 : Mut2, v1542 : Mut3, v1543 : int64 option) = State.trace_state.Value
        let v1554 : US0 = v1542.l0
        let v1555 : bool = v1541.l0
        let v1556 : bool = v1555 = false
        let v1559 : bool =
            if v1556 then
                false
            else
                let v1557 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v1554
                let v1558 : bool = 1 >= v1557
                v1558
        if v1559 then
            let v1560 : int64 = v1512.l0
            let v1561 : int64 = v1560 + 1L
            v1512.l0 <- v1561
            let v1562 : bool = State.trace_state.IsNone
            if v1562 then
                let v1563 : US0 = US0_0
                let struct (v1564 : Mut0, v1565 : Mut1, v1566 : Mut2, v1567 : Mut3, v1568 : int64 option) = method0(v1563)
                let v1569 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v1564, v1565, v1566, v1567, v1568) 
                State.trace_state <- v1569 
                ()
            let struct (v1574 : Mut0, v1575 : Mut1, v1576 : Mut2, v1577 : Mut3, v1578 : int64 option) = State.trace_state.Value
            let v1589 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1590 : US3 option = None
            let _v1590 = ref v1590 
            match v1578 with
            | Some x -> (
            (fun () ->
            (fun () ->
            let v1591 : int64 = x
            let v1592 : US3 = US3_0(v1591)
            v1592 
            )
            |> fun x -> x () |> Some
            ) () ) | None -> None
            |> fun x -> _v1590.Value <- x
            let v1593 : US3 option = _v1590.Value 
            let v1604 : US3 = US3_1
            let v1605 : US3 = v1593 |> Option.defaultValue v1604 
            let v1645 : System.DateTime =
                match v1605 with
                | US3_1 -> (* None *)
                    let v1641 : System.DateTime = System.DateTime.Now
                    v1641
                | US3_0(v1609) -> (* Some *)
                    let v1610 : System.DateTime = System.DateTime.Now
                    let v1613 : (System.DateTime -> int64) = _.Ticks
                    let v1614 : int64 = v1613 v1610
                    let v1617 : int64 = v1614 - v1609
                    let v1618 : (int64 -> System.TimeSpan) = System.TimeSpan 
                    let v1619 : System.TimeSpan = v1618 v1617
                    let v1622 : (System.TimeSpan -> int32) = _.Hours
                    let v1623 : int32 = v1622 v1619
                    let v1626 : (System.TimeSpan -> int32) = _.Minutes
                    let v1627 : int32 = v1626 v1619
                    let v1630 : (System.TimeSpan -> int32) = _.Seconds
                    let v1631 : int32 = v1630 v1619
                    let v1634 : (System.TimeSpan -> int32) = _.Milliseconds
                    let v1635 : int32 = v1634 v1619
                    let v1638 : System.DateTime = System.DateTime (1, 1, 1, v1623, v1627, v1631, v1635)
                    v1638
            let v1646 : string = method9()
            let v1649 : (string -> string) = v1645.ToString
            let v1650 : string = v1649 v1646
            let _v1589 = v1650 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1653 : US3 option = None
            let _v1653 = ref v1653 
            match v1578 with
            | Some x -> (
            (fun () ->
            (fun () ->
            let v1654 : int64 = x
            let v1655 : US3 = US3_0(v1654)
            v1655 
            )
            |> fun x -> x () |> Some
            ) () ) | None -> None
            |> fun x -> _v1653.Value <- x
            let v1656 : US3 option = _v1653.Value 
            let v1667 : US3 = US3_1
            let v1668 : US3 = v1656 |> Option.defaultValue v1667 
            let v1708 : System.DateTime =
                match v1668 with
                | US3_1 -> (* None *)
                    let v1704 : System.DateTime = System.DateTime.Now
                    v1704
                | US3_0(v1672) -> (* Some *)
                    let v1673 : System.DateTime = System.DateTime.Now
                    let v1676 : (System.DateTime -> int64) = _.Ticks
                    let v1677 : int64 = v1676 v1673
                    let v1680 : int64 = v1677 - v1672
                    let v1681 : (int64 -> System.TimeSpan) = System.TimeSpan 
                    let v1682 : System.TimeSpan = v1681 v1680
                    let v1685 : (System.TimeSpan -> int32) = _.Hours
                    let v1686 : int32 = v1685 v1682
                    let v1689 : (System.TimeSpan -> int32) = _.Minutes
                    let v1690 : int32 = v1689 v1682
                    let v1693 : (System.TimeSpan -> int32) = _.Seconds
                    let v1694 : int32 = v1693 v1682
                    let v1697 : (System.TimeSpan -> int32) = _.Milliseconds
                    let v1698 : int32 = v1697 v1682
                    let v1701 : System.DateTime = System.DateTime (1, 1, 1, v1686, v1690, v1694, v1698)
                    v1701
            let v1709 : string = method9()
            let v1712 : (string -> string) = v1708.ToString
            let v1713 : string = v1712 v1709
            let _v1589 = v1713 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1716 : string = $"near_sdk::env::block_timestamp()"
            let v1717 : uint64 = Fable.Core.RustInterop.emitRustExpr () v1716 
            let v1718 : US3 option = None
            let _v1718 = ref v1718 
            match v1578 with
            | Some x -> (
            (fun () ->
            (fun () ->
            let v1719 : int64 = x
            let v1720 : US3 = US3_0(v1719)
            v1720 
            )
            |> fun x -> x () |> Some
            ) () ) | None -> None
            |> fun x -> _v1718.Value <- x
            let v1721 : US3 option = _v1718.Value 
            let v1732 : US3 = US3_1
            let v1733 : US3 = v1721 |> Option.defaultValue v1732 
            let v1742 : uint64 =
                match v1733 with
                | US3_1 -> (* None *)
                    v1717
                | US3_0(v1737) -> (* Some *)
                    let v1738 : (int64 -> uint64) = uint64
                    let v1739 : uint64 = v1738 v1737
                    let v1740 : uint64 = v1717 - v1739
                    v1740
            let v1743 : uint64 = v1742 / 1000000000UL
            let v1744 : uint64 = v1743 % 60UL
            let v1745 : uint64 = v1743 / 60UL
            let v1746 : uint64 = v1745 % 60UL
            let v1747 : uint64 = v1743 / 3600UL
            let v1748 : uint64 = v1747 % 24UL
            let v1749 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
            let v1750 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v1748, v1746, v1744) v1749 
            let v1751 : string = "fable_library_rust::String_::fromString($0)"
            let v1752 : string = Fable.Core.RustInterop.emitRustExpr v1750 v1751 
            let _v1589 = v1752 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1753 : US3 option = None
            let _v1753 = ref v1753 
            match v1578 with
            | Some x -> (
            (fun () ->
            (fun () ->
            let v1754 : int64 = x
            let v1755 : US3 = US3_0(v1754)
            v1755 
            )
            |> fun x -> x () |> Some
            ) () ) | None -> None
            |> fun x -> _v1753.Value <- x
            let v1756 : US3 option = _v1753.Value 
            let v1767 : US3 = US3_1
            let v1768 : US3 = v1756 |> Option.defaultValue v1767 
            let v1808 : System.DateTime =
                match v1768 with
                | US3_1 -> (* None *)
                    let v1804 : System.DateTime = System.DateTime.Now
                    v1804
                | US3_0(v1772) -> (* Some *)
                    let v1773 : System.DateTime = System.DateTime.Now
                    let v1776 : (System.DateTime -> int64) = _.Ticks
                    let v1777 : int64 = v1776 v1773
                    let v1780 : int64 = v1777 - v1772
                    let v1781 : (int64 -> System.TimeSpan) = System.TimeSpan 
                    let v1782 : System.TimeSpan = v1781 v1780
                    let v1785 : (System.TimeSpan -> int32) = _.Hours
                    let v1786 : int32 = v1785 v1782
                    let v1789 : (System.TimeSpan -> int32) = _.Minutes
                    let v1790 : int32 = v1789 v1782
                    let v1793 : (System.TimeSpan -> int32) = _.Seconds
                    let v1794 : int32 = v1793 v1782
                    let v1797 : (System.TimeSpan -> int32) = _.Milliseconds
                    let v1798 : int32 = v1797 v1782
                    let v1801 : System.DateTime = System.DateTime (1, 1, 1, v1786, v1790, v1794, v1798)
                    v1801
            let v1809 : string = method10()
            let v1812 : (string -> string) = v1808.ToString
            let v1813 : string = v1812 v1809
            let _v1589 = v1813 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1816 : US3 option = None
            let _v1816 = ref v1816 
            match v1578 with
            | Some x -> (
            (fun () ->
            (fun () ->
            let v1817 : int64 = x
            let v1818 : US3 = US3_0(v1817)
            v1818 
            )
            |> fun x -> x () |> Some
            ) () ) | None -> None
            |> fun x -> _v1816.Value <- x
            let v1819 : US3 option = _v1816.Value 
            let v1830 : US3 = US3_1
            let v1831 : US3 = v1819 |> Option.defaultValue v1830 
            let v1871 : System.DateTime =
                match v1831 with
                | US3_1 -> (* None *)
                    let v1867 : System.DateTime = System.DateTime.Now
                    v1867
                | US3_0(v1835) -> (* Some *)
                    let v1836 : System.DateTime = System.DateTime.Now
                    let v1839 : (System.DateTime -> int64) = _.Ticks
                    let v1840 : int64 = v1839 v1836
                    let v1843 : int64 = v1840 - v1835
                    let v1844 : (int64 -> System.TimeSpan) = System.TimeSpan 
                    let v1845 : System.TimeSpan = v1844 v1843
                    let v1848 : (System.TimeSpan -> int32) = _.Hours
                    let v1849 : int32 = v1848 v1845
                    let v1852 : (System.TimeSpan -> int32) = _.Minutes
                    let v1853 : int32 = v1852 v1845
                    let v1856 : (System.TimeSpan -> int32) = _.Seconds
                    let v1857 : int32 = v1856 v1845
                    let v1860 : (System.TimeSpan -> int32) = _.Milliseconds
                    let v1861 : int32 = v1860 v1845
                    let v1864 : System.DateTime = System.DateTime (1, 1, 1, v1849, v1853, v1857, v1861)
                    v1864
            let v1872 : string = method10()
            let v1875 : (string -> string) = v1871.ToString
            let v1876 : string = v1875 v1872
            let _v1589 = v1876 
            #endif
#else
            let v1879 : US3 option = None
            let _v1879 = ref v1879 
            match v1578 with
            | Some x -> (
            (fun () ->
            (fun () ->
            let v1880 : int64 = x
            let v1881 : US3 = US3_0(v1880)
            v1881 
            )
            |> fun x -> x () |> Some
            ) () ) | None -> None
            |> fun x -> _v1879.Value <- x
            let v1882 : US3 option = _v1879.Value 
            let v1893 : US3 = US3_1
            let v1894 : US3 = v1882 |> Option.defaultValue v1893 
            let v1934 : System.DateTime =
                match v1894 with
                | US3_1 -> (* None *)
                    let v1930 : System.DateTime = System.DateTime.Now
                    v1930
                | US3_0(v1898) -> (* Some *)
                    let v1899 : System.DateTime = System.DateTime.Now
                    let v1902 : (System.DateTime -> int64) = _.Ticks
                    let v1903 : int64 = v1902 v1899
                    let v1906 : int64 = v1903 - v1898
                    let v1907 : (int64 -> System.TimeSpan) = System.TimeSpan 
                    let v1908 : System.TimeSpan = v1907 v1906
                    let v1911 : (System.TimeSpan -> int32) = _.Hours
                    let v1912 : int32 = v1911 v1908
                    let v1915 : (System.TimeSpan -> int32) = _.Minutes
                    let v1916 : int32 = v1915 v1908
                    let v1919 : (System.TimeSpan -> int32) = _.Seconds
                    let v1920 : int32 = v1919 v1908
                    let v1923 : (System.TimeSpan -> int32) = _.Milliseconds
                    let v1924 : int32 = v1923 v1908
                    let v1927 : System.DateTime = System.DateTime (1, 1, 1, v1912, v1916, v1920, v1924)
                    v1927
            let v1935 : string = method10()
            let v1938 : (string -> string) = v1934.ToString
            let v1939 : string = v1938 v1935
            let _v1589 = v1939 
            #endif
            let v1942 : string = _v1589 
            let v2007 : string = "Debug"
            let v2008 : (unit -> string) = v2007.ToLower
            let v2009 : string = v2008 ()
            let v2012 : string = v2009.PadLeft (7, ' ')
            let v2026 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v2027 : string = "inline_colorization::color_bright_blue"
            let v2028 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v2027 
            let v2029 : string = "&*$0"
            let v2030 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v2012 v2029 
            let v2031 : string = "inline_colorization::color_reset"
            let v2032 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v2031 
            let v2033 : string = "\"{v2028}{v2030}{v2032}\""
            let v2034 : string = @$"format!(" + v2033 + ")"
            let v2035 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v2034 
            let v2036 : string = "fable_library_rust::String_::fromString($0)"
            let v2037 : string = Fable.Core.RustInterop.emitRustExpr v2035 v2036 
            let _v2026 = v2037 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v2038 : string = "inline_colorization::color_bright_blue"
            let v2039 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v2038 
            let v2040 : string = "&*$0"
            let v2041 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v2012 v2040 
            let v2042 : string = "inline_colorization::color_reset"
            let v2043 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v2042 
            let v2044 : string = "\"{v2039}{v2041}{v2043}\""
            let v2045 : string = @$"format!(" + v2044 + ")"
            let v2046 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v2045 
            let v2047 : string = "fable_library_rust::String_::fromString($0)"
            let v2048 : string = Fable.Core.RustInterop.emitRustExpr v2046 v2047 
            let _v2026 = v2048 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v2049 : string = "inline_colorization::color_bright_blue"
            let v2050 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v2049 
            let v2051 : string = "&*$0"
            let v2052 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v2012 v2051 
            let v2053 : string = "inline_colorization::color_reset"
            let v2054 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v2053 
            let v2055 : string = "\"{v2050}{v2052}{v2054}\""
            let v2056 : string = @$"format!(" + v2055 + ")"
            let v2057 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v2056 
            let v2058 : string = "fable_library_rust::String_::fromString($0)"
            let v2059 : string = Fable.Core.RustInterop.emitRustExpr v2057 v2058 
            let _v2026 = v2059 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v2060 : string = "\u001b[94m"
            let v2061 : string = method11()
            let v2062 : string = v2060 + v2012 
            let v2063 : string = v2062 + v2061 
            let _v2026 = v2063 
            #endif
#if FABLE_COMPILER_PYTHON
            let v2064 : string = "\u001b[94m"
            let v2065 : string = method11()
            let v2066 : string = v2064 + v2012 
            let v2067 : string = v2066 + v2065 
            let _v2026 = v2067 
            #endif
#else
            let v2068 : string = "\u001b[94m"
            let v2069 : string = method11()
            let v2070 : string = v2068 + v2012 
            let v2071 : string = v2070 + v2069 
            let _v2026 = v2071 
            #endif
            let v2072 : string = _v2026 
            let v2078 : int64 = v1574.l0
            let v2079 : string = method13()
            let v2080 : Mut4 = {l0 = v2079} : Mut4
            let v2081 : string = "{ "
            let v2082 : string = $"{v2081}"
            let v2085 : string = v2080.l0
            let v2086 : string = v2085 + v2082 
            v2080.l0 <- v2086
            let v2087 : string = "dir"
            let v2088 : string = $"{v2087}"
            let v2091 : string = v2080.l0
            let v2092 : string = v2091 + v2088 
            v2080.l0 <- v2092
            let v2093 : string = " = "
            let v2094 : string = $"{v2093}"
            let v2097 : string = v2080.l0
            let v2098 : string = v2097 + v2094 
            v2080.l0 <- v2098
            let v2099 : string = $"{v0}"
            let v2102 : string = v2080.l0
            let v2103 : string = v2102 + v2099 
            v2080.l0 <- v2103
            let v2104 : string = "; "
            let v2105 : string = $"{v2104}"
            let v2108 : string = v2080.l0
            let v2109 : string = v2108 + v2105 
            v2080.l0 <- v2109
            let v2110 : string = "result"
            let v2111 : string = $"{v2110}"
            let v2114 : string = v2080.l0
            let v2115 : string = v2114 + v2111 
            v2080.l0 <- v2115
            let v2116 : string = $"{v2093}"
            let v2119 : string = v2080.l0
            let v2120 : string = v2119 + v2116 
            v2080.l0 <- v2120
            let v2121 : string = $"{v1497}"
            let v2124 : string = v2080.l0
            let v2125 : string = v2124 + v2121 
            v2080.l0 <- v2125
            let v2126 : string = " }"
            let v2127 : string = $"{v2126}"
            let v2130 : string = v2080.l0
            let v2131 : string = v2130 + v2127 
            v2080.l0 <- v2131
            let v2132 : string = v2080.l0
            let v2133 : (unit -> string) = closure33()
            let v2134 : string = $"{v1942} {v2072} #{v2078} %s{v2133 ()} / {v2132}"
            let v2137 : char list = []
            let v2138 : (char list -> (char [])) = List.toArray
            let v2139 : (char []) = v2138 v2137
            let v2142 : string = v2134.TrimStart v2139 
            let v2160 : char list = []
            let v2161 : char list = '/' :: v2160 
            let v2164 : char list = ' ' :: v2161 
            let v2167 : (char list -> (char [])) = List.toArray
            let v2168 : (char []) = v2167 v2164
            let v2171 : string = v2142.TrimEnd v2168 
            let v2189 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v2190 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v2171 v2190 
            let _v2189 = () 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v2191 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v2171 v2191 
            let _v2189 = () 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v2192 : string = $"near_sdk::log!(\"{{}}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v2171 v2192 
            let _v2189 = () 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            System.Console.WriteLine v2171 
            let _v2189 = () 
            #endif
#if FABLE_COMPILER_PYTHON
            System.Console.WriteLine v2171 
            let _v2189 = () 
            #endif
#else
            System.Console.WriteLine v2171 
            let _v2189 = () 
            #endif
            _v2189 
            let v2193 : (string -> unit) = v1513.l0
            v2193 v2171
    let v2194 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2195 : (unit -> unit) = method40(v0)
    let v2196 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v2195 "$0()" )
    let _v2194 = v2196 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v2197 : (unit -> unit) = method40(v0)
    let v2198 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v2197 "$0()" )
    let _v2194 = v2198 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v2199 : (unit -> unit) = method40(v0)
    let v2200 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v2199 "$0()" )
    let _v2194 = v2200 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v2201 : (unit -> unit) = method41(v0)
    let v2202 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v2201 () }
    let _v2194 = v2202 
    #endif
#if FABLE_COMPILER_PYTHON
    let v2203 : (unit -> unit) = method41(v0)
    let v2204 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v2203 () }
    let _v2194 = v2204 
    #endif
#else
    let v2205 : (unit -> unit) = method41(v0)
    let v2206 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v2205 () }
    let _v2194 = v2206 
    #endif
    let v2207 : System.IDisposable = _v2194 
    let _v1 = v2207 
    #endif
#if FABLE_COMPILER_PYTHON
    let v2211 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2212 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    let _v2211 = v2212 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v2215 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    let _v2211 = v2215 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v2218 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    let _v2211 = v2218 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v2221 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    let _v2211 = v2221 
    #endif
#if FABLE_COMPILER_PYTHON
    let v2224 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    let _v2211 = v2224 
    #endif
#else
    let v2227 : (string -> System.IO.DirectoryInfo) = System.IO.Directory.CreateDirectory
    let v2228 : System.IO.DirectoryInfo = v2227 v0
    let _v2211 = v2228 
    #endif
    let v2229 : System.IO.DirectoryInfo = _v2211 
    let v2234 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2235 : bool = null |> unbox<bool>
    let _v2234 = v2235 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v2238 : bool = null |> unbox<bool>
    let _v2234 = v2238 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v2241 : bool = null |> unbox<bool>
    let _v2234 = v2241 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v2244 : bool = null |> unbox<bool>
    let _v2234 = v2244 
    #endif
#if FABLE_COMPILER_PYTHON
    let v2247 : bool = null |> unbox<bool>
    let _v2234 = v2247 
    #endif
#else
    let v2250 : bool = v2229.Exists
    let _v2234 = v2250 
    #endif
    let v2251 : bool = _v2234 
    let v2256 : bool = v2251 = false
    if v2256 then
        let v2257 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v2258 : System.DateTime = null |> unbox<System.DateTime>
        let _v2257 = v2258 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v2261 : System.DateTime = null |> unbox<System.DateTime>
        let _v2257 = v2261 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v2264 : System.DateTime = null |> unbox<System.DateTime>
        let _v2257 = v2264 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v2267 : System.DateTime = null |> unbox<System.DateTime>
        let _v2257 = v2267 
        #endif
#if FABLE_COMPILER_PYTHON
        let v2270 : System.DateTime = null |> unbox<System.DateTime>
        let _v2257 = v2270 
        #endif
#else
        let v2273 : System.DateTime = v2229.CreationTime
        let _v2257 = v2273 
        #endif
        let v2274 : System.DateTime = _v2257 
        let v2279 : obj = {| Exists = v2251; CreationTime = v2274 |}
        let v2280 : string = $"%A{v2279}"
        let v2283 : bool = State.trace_state.IsNone
        if v2283 then
            let v2284 : US0 = US0_0
            let struct (v2285 : Mut0, v2286 : Mut1, v2287 : Mut2, v2288 : Mut3, v2289 : int64 option) = method0(v2284)
            let v2290 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v2285, v2286, v2287, v2288, v2289) 
            State.trace_state <- v2290 
            ()
        let struct (v2295 : Mut0, v2296 : Mut1, v2297 : Mut2, v2298 : Mut3, v2299 : int64 option) = State.trace_state.Value
        let v2310 : bool = State.trace_state.IsNone
        if v2310 then
            let v2311 : US0 = US0_0
            let struct (v2312 : Mut0, v2313 : Mut1, v2314 : Mut2, v2315 : Mut3, v2316 : int64 option) = method0(v2311)
            let v2317 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v2312, v2313, v2314, v2315, v2316) 
            State.trace_state <- v2317 
            ()
        let struct (v2322 : Mut0, v2323 : Mut1, v2324 : Mut2, v2325 : Mut3, v2326 : int64 option) = State.trace_state.Value
        let v2337 : US0 = v2325.l0
        let v2338 : bool = v2324.l0
        let v2339 : bool = v2338 = false
        let v2342 : bool =
            if v2339 then
                false
            else
                let v2340 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v2337
                let v2341 : bool = 1 >= v2340
                v2341
        if v2342 then
            let v2343 : int64 = v2295.l0
            let v2344 : int64 = v2343 + 1L
            v2295.l0 <- v2344
            let v2345 : bool = State.trace_state.IsNone
            if v2345 then
                let v2346 : US0 = US0_0
                let struct (v2347 : Mut0, v2348 : Mut1, v2349 : Mut2, v2350 : Mut3, v2351 : int64 option) = method0(v2346)
                let v2352 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v2347, v2348, v2349, v2350, v2351) 
                State.trace_state <- v2352 
                ()
            let struct (v2357 : Mut0, v2358 : Mut1, v2359 : Mut2, v2360 : Mut3, v2361 : int64 option) = State.trace_state.Value
            let v2372 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v2373 : US3 option = None
            let _v2373 = ref v2373 
            match v2361 with
            | Some x -> (
            (fun () ->
            (fun () ->
            let v2374 : int64 = x
            let v2375 : US3 = US3_0(v2374)
            v2375 
            )
            |> fun x -> x () |> Some
            ) () ) | None -> None
            |> fun x -> _v2373.Value <- x
            let v2376 : US3 option = _v2373.Value 
            let v2387 : US3 = US3_1
            let v2388 : US3 = v2376 |> Option.defaultValue v2387 
            let v2428 : System.DateTime =
                match v2388 with
                | US3_1 -> (* None *)
                    let v2424 : System.DateTime = System.DateTime.Now
                    v2424
                | US3_0(v2392) -> (* Some *)
                    let v2393 : System.DateTime = System.DateTime.Now
                    let v2396 : (System.DateTime -> int64) = _.Ticks
                    let v2397 : int64 = v2396 v2393
                    let v2400 : int64 = v2397 - v2392
                    let v2401 : (int64 -> System.TimeSpan) = System.TimeSpan 
                    let v2402 : System.TimeSpan = v2401 v2400
                    let v2405 : (System.TimeSpan -> int32) = _.Hours
                    let v2406 : int32 = v2405 v2402
                    let v2409 : (System.TimeSpan -> int32) = _.Minutes
                    let v2410 : int32 = v2409 v2402
                    let v2413 : (System.TimeSpan -> int32) = _.Seconds
                    let v2414 : int32 = v2413 v2402
                    let v2417 : (System.TimeSpan -> int32) = _.Milliseconds
                    let v2418 : int32 = v2417 v2402
                    let v2421 : System.DateTime = System.DateTime (1, 1, 1, v2406, v2410, v2414, v2418)
                    v2421
            let v2429 : string = method9()
            let v2432 : (string -> string) = v2428.ToString
            let v2433 : string = v2432 v2429
            let _v2372 = v2433 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v2436 : US3 option = None
            let _v2436 = ref v2436 
            match v2361 with
            | Some x -> (
            (fun () ->
            (fun () ->
            let v2437 : int64 = x
            let v2438 : US3 = US3_0(v2437)
            v2438 
            )
            |> fun x -> x () |> Some
            ) () ) | None -> None
            |> fun x -> _v2436.Value <- x
            let v2439 : US3 option = _v2436.Value 
            let v2450 : US3 = US3_1
            let v2451 : US3 = v2439 |> Option.defaultValue v2450 
            let v2491 : System.DateTime =
                match v2451 with
                | US3_1 -> (* None *)
                    let v2487 : System.DateTime = System.DateTime.Now
                    v2487
                | US3_0(v2455) -> (* Some *)
                    let v2456 : System.DateTime = System.DateTime.Now
                    let v2459 : (System.DateTime -> int64) = _.Ticks
                    let v2460 : int64 = v2459 v2456
                    let v2463 : int64 = v2460 - v2455
                    let v2464 : (int64 -> System.TimeSpan) = System.TimeSpan 
                    let v2465 : System.TimeSpan = v2464 v2463
                    let v2468 : (System.TimeSpan -> int32) = _.Hours
                    let v2469 : int32 = v2468 v2465
                    let v2472 : (System.TimeSpan -> int32) = _.Minutes
                    let v2473 : int32 = v2472 v2465
                    let v2476 : (System.TimeSpan -> int32) = _.Seconds
                    let v2477 : int32 = v2476 v2465
                    let v2480 : (System.TimeSpan -> int32) = _.Milliseconds
                    let v2481 : int32 = v2480 v2465
                    let v2484 : System.DateTime = System.DateTime (1, 1, 1, v2469, v2473, v2477, v2481)
                    v2484
            let v2492 : string = method9()
            let v2495 : (string -> string) = v2491.ToString
            let v2496 : string = v2495 v2492
            let _v2372 = v2496 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v2499 : string = $"near_sdk::env::block_timestamp()"
            let v2500 : uint64 = Fable.Core.RustInterop.emitRustExpr () v2499 
            let v2501 : US3 option = None
            let _v2501 = ref v2501 
            match v2361 with
            | Some x -> (
            (fun () ->
            (fun () ->
            let v2502 : int64 = x
            let v2503 : US3 = US3_0(v2502)
            v2503 
            )
            |> fun x -> x () |> Some
            ) () ) | None -> None
            |> fun x -> _v2501.Value <- x
            let v2504 : US3 option = _v2501.Value 
            let v2515 : US3 = US3_1
            let v2516 : US3 = v2504 |> Option.defaultValue v2515 
            let v2525 : uint64 =
                match v2516 with
                | US3_1 -> (* None *)
                    v2500
                | US3_0(v2520) -> (* Some *)
                    let v2521 : (int64 -> uint64) = uint64
                    let v2522 : uint64 = v2521 v2520
                    let v2523 : uint64 = v2500 - v2522
                    v2523
            let v2526 : uint64 = v2525 / 1000000000UL
            let v2527 : uint64 = v2526 % 60UL
            let v2528 : uint64 = v2526 / 60UL
            let v2529 : uint64 = v2528 % 60UL
            let v2530 : uint64 = v2526 / 3600UL
            let v2531 : uint64 = v2530 % 24UL
            let v2532 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
            let v2533 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v2531, v2529, v2527) v2532 
            let v2534 : string = "fable_library_rust::String_::fromString($0)"
            let v2535 : string = Fable.Core.RustInterop.emitRustExpr v2533 v2534 
            let _v2372 = v2535 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v2536 : US3 option = None
            let _v2536 = ref v2536 
            match v2361 with
            | Some x -> (
            (fun () ->
            (fun () ->
            let v2537 : int64 = x
            let v2538 : US3 = US3_0(v2537)
            v2538 
            )
            |> fun x -> x () |> Some
            ) () ) | None -> None
            |> fun x -> _v2536.Value <- x
            let v2539 : US3 option = _v2536.Value 
            let v2550 : US3 = US3_1
            let v2551 : US3 = v2539 |> Option.defaultValue v2550 
            let v2591 : System.DateTime =
                match v2551 with
                | US3_1 -> (* None *)
                    let v2587 : System.DateTime = System.DateTime.Now
                    v2587
                | US3_0(v2555) -> (* Some *)
                    let v2556 : System.DateTime = System.DateTime.Now
                    let v2559 : (System.DateTime -> int64) = _.Ticks
                    let v2560 : int64 = v2559 v2556
                    let v2563 : int64 = v2560 - v2555
                    let v2564 : (int64 -> System.TimeSpan) = System.TimeSpan 
                    let v2565 : System.TimeSpan = v2564 v2563
                    let v2568 : (System.TimeSpan -> int32) = _.Hours
                    let v2569 : int32 = v2568 v2565
                    let v2572 : (System.TimeSpan -> int32) = _.Minutes
                    let v2573 : int32 = v2572 v2565
                    let v2576 : (System.TimeSpan -> int32) = _.Seconds
                    let v2577 : int32 = v2576 v2565
                    let v2580 : (System.TimeSpan -> int32) = _.Milliseconds
                    let v2581 : int32 = v2580 v2565
                    let v2584 : System.DateTime = System.DateTime (1, 1, 1, v2569, v2573, v2577, v2581)
                    v2584
            let v2592 : string = method10()
            let v2595 : (string -> string) = v2591.ToString
            let v2596 : string = v2595 v2592
            let _v2372 = v2596 
            #endif
#if FABLE_COMPILER_PYTHON
            let v2599 : US3 option = None
            let _v2599 = ref v2599 
            match v2361 with
            | Some x -> (
            (fun () ->
            (fun () ->
            let v2600 : int64 = x
            let v2601 : US3 = US3_0(v2600)
            v2601 
            )
            |> fun x -> x () |> Some
            ) () ) | None -> None
            |> fun x -> _v2599.Value <- x
            let v2602 : US3 option = _v2599.Value 
            let v2613 : US3 = US3_1
            let v2614 : US3 = v2602 |> Option.defaultValue v2613 
            let v2654 : System.DateTime =
                match v2614 with
                | US3_1 -> (* None *)
                    let v2650 : System.DateTime = System.DateTime.Now
                    v2650
                | US3_0(v2618) -> (* Some *)
                    let v2619 : System.DateTime = System.DateTime.Now
                    let v2622 : (System.DateTime -> int64) = _.Ticks
                    let v2623 : int64 = v2622 v2619
                    let v2626 : int64 = v2623 - v2618
                    let v2627 : (int64 -> System.TimeSpan) = System.TimeSpan 
                    let v2628 : System.TimeSpan = v2627 v2626
                    let v2631 : (System.TimeSpan -> int32) = _.Hours
                    let v2632 : int32 = v2631 v2628
                    let v2635 : (System.TimeSpan -> int32) = _.Minutes
                    let v2636 : int32 = v2635 v2628
                    let v2639 : (System.TimeSpan -> int32) = _.Seconds
                    let v2640 : int32 = v2639 v2628
                    let v2643 : (System.TimeSpan -> int32) = _.Milliseconds
                    let v2644 : int32 = v2643 v2628
                    let v2647 : System.DateTime = System.DateTime (1, 1, 1, v2632, v2636, v2640, v2644)
                    v2647
            let v2655 : string = method10()
            let v2658 : (string -> string) = v2654.ToString
            let v2659 : string = v2658 v2655
            let _v2372 = v2659 
            #endif
#else
            let v2662 : US3 option = None
            let _v2662 = ref v2662 
            match v2361 with
            | Some x -> (
            (fun () ->
            (fun () ->
            let v2663 : int64 = x
            let v2664 : US3 = US3_0(v2663)
            v2664 
            )
            |> fun x -> x () |> Some
            ) () ) | None -> None
            |> fun x -> _v2662.Value <- x
            let v2665 : US3 option = _v2662.Value 
            let v2676 : US3 = US3_1
            let v2677 : US3 = v2665 |> Option.defaultValue v2676 
            let v2717 : System.DateTime =
                match v2677 with
                | US3_1 -> (* None *)
                    let v2713 : System.DateTime = System.DateTime.Now
                    v2713
                | US3_0(v2681) -> (* Some *)
                    let v2682 : System.DateTime = System.DateTime.Now
                    let v2685 : (System.DateTime -> int64) = _.Ticks
                    let v2686 : int64 = v2685 v2682
                    let v2689 : int64 = v2686 - v2681
                    let v2690 : (int64 -> System.TimeSpan) = System.TimeSpan 
                    let v2691 : System.TimeSpan = v2690 v2689
                    let v2694 : (System.TimeSpan -> int32) = _.Hours
                    let v2695 : int32 = v2694 v2691
                    let v2698 : (System.TimeSpan -> int32) = _.Minutes
                    let v2699 : int32 = v2698 v2691
                    let v2702 : (System.TimeSpan -> int32) = _.Seconds
                    let v2703 : int32 = v2702 v2691
                    let v2706 : (System.TimeSpan -> int32) = _.Milliseconds
                    let v2707 : int32 = v2706 v2691
                    let v2710 : System.DateTime = System.DateTime (1, 1, 1, v2695, v2699, v2703, v2707)
                    v2710
            let v2718 : string = method10()
            let v2721 : (string -> string) = v2717.ToString
            let v2722 : string = v2721 v2718
            let _v2372 = v2722 
            #endif
            let v2725 : string = _v2372 
            let v2790 : string = "Debug"
            let v2791 : (unit -> string) = v2790.ToLower
            let v2792 : string = v2791 ()
            let v2795 : string = v2792.PadLeft (7, ' ')
            let v2809 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v2810 : string = "inline_colorization::color_bright_blue"
            let v2811 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v2810 
            let v2812 : string = "&*$0"
            let v2813 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v2795 v2812 
            let v2814 : string = "inline_colorization::color_reset"
            let v2815 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v2814 
            let v2816 : string = "\"{v2811}{v2813}{v2815}\""
            let v2817 : string = @$"format!(" + v2816 + ")"
            let v2818 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v2817 
            let v2819 : string = "fable_library_rust::String_::fromString($0)"
            let v2820 : string = Fable.Core.RustInterop.emitRustExpr v2818 v2819 
            let _v2809 = v2820 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v2821 : string = "inline_colorization::color_bright_blue"
            let v2822 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v2821 
            let v2823 : string = "&*$0"
            let v2824 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v2795 v2823 
            let v2825 : string = "inline_colorization::color_reset"
            let v2826 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v2825 
            let v2827 : string = "\"{v2822}{v2824}{v2826}\""
            let v2828 : string = @$"format!(" + v2827 + ")"
            let v2829 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v2828 
            let v2830 : string = "fable_library_rust::String_::fromString($0)"
            let v2831 : string = Fable.Core.RustInterop.emitRustExpr v2829 v2830 
            let _v2809 = v2831 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v2832 : string = "inline_colorization::color_bright_blue"
            let v2833 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v2832 
            let v2834 : string = "&*$0"
            let v2835 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v2795 v2834 
            let v2836 : string = "inline_colorization::color_reset"
            let v2837 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v2836 
            let v2838 : string = "\"{v2833}{v2835}{v2837}\""
            let v2839 : string = @$"format!(" + v2838 + ")"
            let v2840 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v2839 
            let v2841 : string = "fable_library_rust::String_::fromString($0)"
            let v2842 : string = Fable.Core.RustInterop.emitRustExpr v2840 v2841 
            let _v2809 = v2842 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v2843 : string = "\u001b[94m"
            let v2844 : string = method11()
            let v2845 : string = v2843 + v2795 
            let v2846 : string = v2845 + v2844 
            let _v2809 = v2846 
            #endif
#if FABLE_COMPILER_PYTHON
            let v2847 : string = "\u001b[94m"
            let v2848 : string = method11()
            let v2849 : string = v2847 + v2795 
            let v2850 : string = v2849 + v2848 
            let _v2809 = v2850 
            #endif
#else
            let v2851 : string = "\u001b[94m"
            let v2852 : string = method11()
            let v2853 : string = v2851 + v2795 
            let v2854 : string = v2853 + v2852 
            let _v2809 = v2854 
            #endif
            let v2855 : string = _v2809 
            let v2861 : int64 = v2357.l0
            let v2862 : string = method13()
            let v2863 : Mut4 = {l0 = v2862} : Mut4
            let v2864 : string = "{ "
            let v2865 : string = $"{v2864}"
            let v2868 : string = v2863.l0
            let v2869 : string = v2868 + v2865 
            v2863.l0 <- v2869
            let v2870 : string = "dir"
            let v2871 : string = $"{v2870}"
            let v2874 : string = v2863.l0
            let v2875 : string = v2874 + v2871 
            v2863.l0 <- v2875
            let v2876 : string = " = "
            let v2877 : string = $"{v2876}"
            let v2880 : string = v2863.l0
            let v2881 : string = v2880 + v2877 
            v2863.l0 <- v2881
            let v2882 : string = $"{v0}"
            let v2885 : string = v2863.l0
            let v2886 : string = v2885 + v2882 
            v2863.l0 <- v2886
            let v2887 : string = "; "
            let v2888 : string = $"{v2887}"
            let v2891 : string = v2863.l0
            let v2892 : string = v2891 + v2888 
            v2863.l0 <- v2892
            let v2893 : string = "result"
            let v2894 : string = $"{v2893}"
            let v2897 : string = v2863.l0
            let v2898 : string = v2897 + v2894 
            v2863.l0 <- v2898
            let v2899 : string = $"{v2876}"
            let v2902 : string = v2863.l0
            let v2903 : string = v2902 + v2899 
            v2863.l0 <- v2903
            let v2904 : string = $"{v2280}"
            let v2907 : string = v2863.l0
            let v2908 : string = v2907 + v2904 
            v2863.l0 <- v2908
            let v2909 : string = " }"
            let v2910 : string = $"{v2909}"
            let v2913 : string = v2863.l0
            let v2914 : string = v2913 + v2910 
            v2863.l0 <- v2914
            let v2915 : string = v2863.l0
            let v2916 : (unit -> string) = closure33()
            let v2917 : string = $"{v2725} {v2855} #{v2861} %s{v2916 ()} / {v2915}"
            let v2920 : char list = []
            let v2921 : (char list -> (char [])) = List.toArray
            let v2922 : (char []) = v2921 v2920
            let v2925 : string = v2917.TrimStart v2922 
            let v2943 : char list = []
            let v2944 : char list = '/' :: v2943 
            let v2947 : char list = ' ' :: v2944 
            let v2950 : (char list -> (char [])) = List.toArray
            let v2951 : (char []) = v2950 v2947
            let v2954 : string = v2925.TrimEnd v2951 
            let v2972 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v2973 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v2954 v2973 
            let _v2972 = () 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v2974 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v2954 v2974 
            let _v2972 = () 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v2975 : string = $"near_sdk::log!(\"{{}}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v2954 v2975 
            let _v2972 = () 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            System.Console.WriteLine v2954 
            let _v2972 = () 
            #endif
#if FABLE_COMPILER_PYTHON
            System.Console.WriteLine v2954 
            let _v2972 = () 
            #endif
#else
            System.Console.WriteLine v2954 
            let _v2972 = () 
            #endif
            _v2972 
            let v2976 : (string -> unit) = v2296.l0
            v2976 v2954
    let v2977 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2978 : (unit -> unit) = method40(v0)
    let v2979 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v2978 "$0()" )
    let _v2977 = v2979 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v2980 : (unit -> unit) = method40(v0)
    let v2981 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v2980 "$0()" )
    let _v2977 = v2981 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v2982 : (unit -> unit) = method40(v0)
    let v2983 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v2982 "$0()" )
    let _v2977 = v2983 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v2984 : (unit -> unit) = method41(v0)
    let v2985 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v2984 () }
    let _v2977 = v2985 
    #endif
#if FABLE_COMPILER_PYTHON
    let v2986 : (unit -> unit) = method41(v0)
    let v2987 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v2986 () }
    let _v2977 = v2987 
    #endif
#else
    let v2988 : (unit -> unit) = method41(v0)
    let v2989 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v2988 () }
    let _v2977 = v2989 
    #endif
    let v2990 : System.IDisposable = _v2977 
    let _v1 = v2990 
    #endif
#else
    let v2994 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2995 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    let _v2994 = v2995 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v2998 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    let _v2994 = v2998 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v3001 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    let _v2994 = v3001 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v3004 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    let _v2994 = v3004 
    #endif
#if FABLE_COMPILER_PYTHON
    let v3007 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    let _v2994 = v3007 
    #endif
#else
    let v3010 : (string -> System.IO.DirectoryInfo) = System.IO.Directory.CreateDirectory
    let v3011 : System.IO.DirectoryInfo = v3010 v0
    let _v2994 = v3011 
    #endif
    let v3012 : System.IO.DirectoryInfo = _v2994 
    let v3017 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3018 : bool = null |> unbox<bool>
    let _v3017 = v3018 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v3021 : bool = null |> unbox<bool>
    let _v3017 = v3021 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v3024 : bool = null |> unbox<bool>
    let _v3017 = v3024 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v3027 : bool = null |> unbox<bool>
    let _v3017 = v3027 
    #endif
#if FABLE_COMPILER_PYTHON
    let v3030 : bool = null |> unbox<bool>
    let _v3017 = v3030 
    #endif
#else
    let v3033 : bool = v3012.Exists
    let _v3017 = v3033 
    #endif
    let v3034 : bool = _v3017 
    let v3039 : bool = v3034 = false
    if v3039 then
        let v3040 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v3041 : System.DateTime = null |> unbox<System.DateTime>
        let _v3040 = v3041 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v3044 : System.DateTime = null |> unbox<System.DateTime>
        let _v3040 = v3044 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v3047 : System.DateTime = null |> unbox<System.DateTime>
        let _v3040 = v3047 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v3050 : System.DateTime = null |> unbox<System.DateTime>
        let _v3040 = v3050 
        #endif
#if FABLE_COMPILER_PYTHON
        let v3053 : System.DateTime = null |> unbox<System.DateTime>
        let _v3040 = v3053 
        #endif
#else
        let v3056 : System.DateTime = v3012.CreationTime
        let _v3040 = v3056 
        #endif
        let v3057 : System.DateTime = _v3040 
        let v3062 : obj = {| Exists = v3034; CreationTime = v3057 |}
        let v3063 : string = $"%A{v3062}"
        let v3066 : bool = State.trace_state.IsNone
        if v3066 then
            let v3067 : US0 = US0_0
            let struct (v3068 : Mut0, v3069 : Mut1, v3070 : Mut2, v3071 : Mut3, v3072 : int64 option) = method0(v3067)
            let v3073 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v3068, v3069, v3070, v3071, v3072) 
            State.trace_state <- v3073 
            ()
        let struct (v3078 : Mut0, v3079 : Mut1, v3080 : Mut2, v3081 : Mut3, v3082 : int64 option) = State.trace_state.Value
        let v3093 : bool = State.trace_state.IsNone
        if v3093 then
            let v3094 : US0 = US0_0
            let struct (v3095 : Mut0, v3096 : Mut1, v3097 : Mut2, v3098 : Mut3, v3099 : int64 option) = method0(v3094)
            let v3100 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v3095, v3096, v3097, v3098, v3099) 
            State.trace_state <- v3100 
            ()
        let struct (v3105 : Mut0, v3106 : Mut1, v3107 : Mut2, v3108 : Mut3, v3109 : int64 option) = State.trace_state.Value
        let v3120 : US0 = v3108.l0
        let v3121 : bool = v3107.l0
        let v3122 : bool = v3121 = false
        let v3125 : bool =
            if v3122 then
                false
            else
                let v3123 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v3120
                let v3124 : bool = 1 >= v3123
                v3124
        if v3125 then
            let v3126 : int64 = v3078.l0
            let v3127 : int64 = v3126 + 1L
            v3078.l0 <- v3127
            let v3128 : bool = State.trace_state.IsNone
            if v3128 then
                let v3129 : US0 = US0_0
                let struct (v3130 : Mut0, v3131 : Mut1, v3132 : Mut2, v3133 : Mut3, v3134 : int64 option) = method0(v3129)
                let v3135 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v3130, v3131, v3132, v3133, v3134) 
                State.trace_state <- v3135 
                ()
            let struct (v3140 : Mut0, v3141 : Mut1, v3142 : Mut2, v3143 : Mut3, v3144 : int64 option) = State.trace_state.Value
            let v3155 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v3156 : US3 option = None
            let _v3156 = ref v3156 
            match v3144 with
            | Some x -> (
            (fun () ->
            (fun () ->
            let v3157 : int64 = x
            let v3158 : US3 = US3_0(v3157)
            v3158 
            )
            |> fun x -> x () |> Some
            ) () ) | None -> None
            |> fun x -> _v3156.Value <- x
            let v3159 : US3 option = _v3156.Value 
            let v3170 : US3 = US3_1
            let v3171 : US3 = v3159 |> Option.defaultValue v3170 
            let v3211 : System.DateTime =
                match v3171 with
                | US3_1 -> (* None *)
                    let v3207 : System.DateTime = System.DateTime.Now
                    v3207
                | US3_0(v3175) -> (* Some *)
                    let v3176 : System.DateTime = System.DateTime.Now
                    let v3179 : (System.DateTime -> int64) = _.Ticks
                    let v3180 : int64 = v3179 v3176
                    let v3183 : int64 = v3180 - v3175
                    let v3184 : (int64 -> System.TimeSpan) = System.TimeSpan 
                    let v3185 : System.TimeSpan = v3184 v3183
                    let v3188 : (System.TimeSpan -> int32) = _.Hours
                    let v3189 : int32 = v3188 v3185
                    let v3192 : (System.TimeSpan -> int32) = _.Minutes
                    let v3193 : int32 = v3192 v3185
                    let v3196 : (System.TimeSpan -> int32) = _.Seconds
                    let v3197 : int32 = v3196 v3185
                    let v3200 : (System.TimeSpan -> int32) = _.Milliseconds
                    let v3201 : int32 = v3200 v3185
                    let v3204 : System.DateTime = System.DateTime (1, 1, 1, v3189, v3193, v3197, v3201)
                    v3204
            let v3212 : string = method9()
            let v3215 : (string -> string) = v3211.ToString
            let v3216 : string = v3215 v3212
            let _v3155 = v3216 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v3219 : US3 option = None
            let _v3219 = ref v3219 
            match v3144 with
            | Some x -> (
            (fun () ->
            (fun () ->
            let v3220 : int64 = x
            let v3221 : US3 = US3_0(v3220)
            v3221 
            )
            |> fun x -> x () |> Some
            ) () ) | None -> None
            |> fun x -> _v3219.Value <- x
            let v3222 : US3 option = _v3219.Value 
            let v3233 : US3 = US3_1
            let v3234 : US3 = v3222 |> Option.defaultValue v3233 
            let v3274 : System.DateTime =
                match v3234 with
                | US3_1 -> (* None *)
                    let v3270 : System.DateTime = System.DateTime.Now
                    v3270
                | US3_0(v3238) -> (* Some *)
                    let v3239 : System.DateTime = System.DateTime.Now
                    let v3242 : (System.DateTime -> int64) = _.Ticks
                    let v3243 : int64 = v3242 v3239
                    let v3246 : int64 = v3243 - v3238
                    let v3247 : (int64 -> System.TimeSpan) = System.TimeSpan 
                    let v3248 : System.TimeSpan = v3247 v3246
                    let v3251 : (System.TimeSpan -> int32) = _.Hours
                    let v3252 : int32 = v3251 v3248
                    let v3255 : (System.TimeSpan -> int32) = _.Minutes
                    let v3256 : int32 = v3255 v3248
                    let v3259 : (System.TimeSpan -> int32) = _.Seconds
                    let v3260 : int32 = v3259 v3248
                    let v3263 : (System.TimeSpan -> int32) = _.Milliseconds
                    let v3264 : int32 = v3263 v3248
                    let v3267 : System.DateTime = System.DateTime (1, 1, 1, v3252, v3256, v3260, v3264)
                    v3267
            let v3275 : string = method9()
            let v3278 : (string -> string) = v3274.ToString
            let v3279 : string = v3278 v3275
            let _v3155 = v3279 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v3282 : string = $"near_sdk::env::block_timestamp()"
            let v3283 : uint64 = Fable.Core.RustInterop.emitRustExpr () v3282 
            let v3284 : US3 option = None
            let _v3284 = ref v3284 
            match v3144 with
            | Some x -> (
            (fun () ->
            (fun () ->
            let v3285 : int64 = x
            let v3286 : US3 = US3_0(v3285)
            v3286 
            )
            |> fun x -> x () |> Some
            ) () ) | None -> None
            |> fun x -> _v3284.Value <- x
            let v3287 : US3 option = _v3284.Value 
            let v3298 : US3 = US3_1
            let v3299 : US3 = v3287 |> Option.defaultValue v3298 
            let v3308 : uint64 =
                match v3299 with
                | US3_1 -> (* None *)
                    v3283
                | US3_0(v3303) -> (* Some *)
                    let v3304 : (int64 -> uint64) = uint64
                    let v3305 : uint64 = v3304 v3303
                    let v3306 : uint64 = v3283 - v3305
                    v3306
            let v3309 : uint64 = v3308 / 1000000000UL
            let v3310 : uint64 = v3309 % 60UL
            let v3311 : uint64 = v3309 / 60UL
            let v3312 : uint64 = v3311 % 60UL
            let v3313 : uint64 = v3309 / 3600UL
            let v3314 : uint64 = v3313 % 24UL
            let v3315 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
            let v3316 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v3314, v3312, v3310) v3315 
            let v3317 : string = "fable_library_rust::String_::fromString($0)"
            let v3318 : string = Fable.Core.RustInterop.emitRustExpr v3316 v3317 
            let _v3155 = v3318 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v3319 : US3 option = None
            let _v3319 = ref v3319 
            match v3144 with
            | Some x -> (
            (fun () ->
            (fun () ->
            let v3320 : int64 = x
            let v3321 : US3 = US3_0(v3320)
            v3321 
            )
            |> fun x -> x () |> Some
            ) () ) | None -> None
            |> fun x -> _v3319.Value <- x
            let v3322 : US3 option = _v3319.Value 
            let v3333 : US3 = US3_1
            let v3334 : US3 = v3322 |> Option.defaultValue v3333 
            let v3374 : System.DateTime =
                match v3334 with
                | US3_1 -> (* None *)
                    let v3370 : System.DateTime = System.DateTime.Now
                    v3370
                | US3_0(v3338) -> (* Some *)
                    let v3339 : System.DateTime = System.DateTime.Now
                    let v3342 : (System.DateTime -> int64) = _.Ticks
                    let v3343 : int64 = v3342 v3339
                    let v3346 : int64 = v3343 - v3338
                    let v3347 : (int64 -> System.TimeSpan) = System.TimeSpan 
                    let v3348 : System.TimeSpan = v3347 v3346
                    let v3351 : (System.TimeSpan -> int32) = _.Hours
                    let v3352 : int32 = v3351 v3348
                    let v3355 : (System.TimeSpan -> int32) = _.Minutes
                    let v3356 : int32 = v3355 v3348
                    let v3359 : (System.TimeSpan -> int32) = _.Seconds
                    let v3360 : int32 = v3359 v3348
                    let v3363 : (System.TimeSpan -> int32) = _.Milliseconds
                    let v3364 : int32 = v3363 v3348
                    let v3367 : System.DateTime = System.DateTime (1, 1, 1, v3352, v3356, v3360, v3364)
                    v3367
            let v3375 : string = method10()
            let v3378 : (string -> string) = v3374.ToString
            let v3379 : string = v3378 v3375
            let _v3155 = v3379 
            #endif
#if FABLE_COMPILER_PYTHON
            let v3382 : US3 option = None
            let _v3382 = ref v3382 
            match v3144 with
            | Some x -> (
            (fun () ->
            (fun () ->
            let v3383 : int64 = x
            let v3384 : US3 = US3_0(v3383)
            v3384 
            )
            |> fun x -> x () |> Some
            ) () ) | None -> None
            |> fun x -> _v3382.Value <- x
            let v3385 : US3 option = _v3382.Value 
            let v3396 : US3 = US3_1
            let v3397 : US3 = v3385 |> Option.defaultValue v3396 
            let v3437 : System.DateTime =
                match v3397 with
                | US3_1 -> (* None *)
                    let v3433 : System.DateTime = System.DateTime.Now
                    v3433
                | US3_0(v3401) -> (* Some *)
                    let v3402 : System.DateTime = System.DateTime.Now
                    let v3405 : (System.DateTime -> int64) = _.Ticks
                    let v3406 : int64 = v3405 v3402
                    let v3409 : int64 = v3406 - v3401
                    let v3410 : (int64 -> System.TimeSpan) = System.TimeSpan 
                    let v3411 : System.TimeSpan = v3410 v3409
                    let v3414 : (System.TimeSpan -> int32) = _.Hours
                    let v3415 : int32 = v3414 v3411
                    let v3418 : (System.TimeSpan -> int32) = _.Minutes
                    let v3419 : int32 = v3418 v3411
                    let v3422 : (System.TimeSpan -> int32) = _.Seconds
                    let v3423 : int32 = v3422 v3411
                    let v3426 : (System.TimeSpan -> int32) = _.Milliseconds
                    let v3427 : int32 = v3426 v3411
                    let v3430 : System.DateTime = System.DateTime (1, 1, 1, v3415, v3419, v3423, v3427)
                    v3430
            let v3438 : string = method10()
            let v3441 : (string -> string) = v3437.ToString
            let v3442 : string = v3441 v3438
            let _v3155 = v3442 
            #endif
#else
            let v3445 : US3 option = None
            let _v3445 = ref v3445 
            match v3144 with
            | Some x -> (
            (fun () ->
            (fun () ->
            let v3446 : int64 = x
            let v3447 : US3 = US3_0(v3446)
            v3447 
            )
            |> fun x -> x () |> Some
            ) () ) | None -> None
            |> fun x -> _v3445.Value <- x
            let v3448 : US3 option = _v3445.Value 
            let v3459 : US3 = US3_1
            let v3460 : US3 = v3448 |> Option.defaultValue v3459 
            let v3500 : System.DateTime =
                match v3460 with
                | US3_1 -> (* None *)
                    let v3496 : System.DateTime = System.DateTime.Now
                    v3496
                | US3_0(v3464) -> (* Some *)
                    let v3465 : System.DateTime = System.DateTime.Now
                    let v3468 : (System.DateTime -> int64) = _.Ticks
                    let v3469 : int64 = v3468 v3465
                    let v3472 : int64 = v3469 - v3464
                    let v3473 : (int64 -> System.TimeSpan) = System.TimeSpan 
                    let v3474 : System.TimeSpan = v3473 v3472
                    let v3477 : (System.TimeSpan -> int32) = _.Hours
                    let v3478 : int32 = v3477 v3474
                    let v3481 : (System.TimeSpan -> int32) = _.Minutes
                    let v3482 : int32 = v3481 v3474
                    let v3485 : (System.TimeSpan -> int32) = _.Seconds
                    let v3486 : int32 = v3485 v3474
                    let v3489 : (System.TimeSpan -> int32) = _.Milliseconds
                    let v3490 : int32 = v3489 v3474
                    let v3493 : System.DateTime = System.DateTime (1, 1, 1, v3478, v3482, v3486, v3490)
                    v3493
            let v3501 : string = method10()
            let v3504 : (string -> string) = v3500.ToString
            let v3505 : string = v3504 v3501
            let _v3155 = v3505 
            #endif
            let v3508 : string = _v3155 
            let v3573 : string = "Debug"
            let v3574 : (unit -> string) = v3573.ToLower
            let v3575 : string = v3574 ()
            let v3578 : string = v3575.PadLeft (7, ' ')
            let v3592 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v3593 : string = "inline_colorization::color_bright_blue"
            let v3594 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v3593 
            let v3595 : string = "&*$0"
            let v3596 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v3578 v3595 
            let v3597 : string = "inline_colorization::color_reset"
            let v3598 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v3597 
            let v3599 : string = "\"{v3594}{v3596}{v3598}\""
            let v3600 : string = @$"format!(" + v3599 + ")"
            let v3601 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v3600 
            let v3602 : string = "fable_library_rust::String_::fromString($0)"
            let v3603 : string = Fable.Core.RustInterop.emitRustExpr v3601 v3602 
            let _v3592 = v3603 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v3604 : string = "inline_colorization::color_bright_blue"
            let v3605 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v3604 
            let v3606 : string = "&*$0"
            let v3607 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v3578 v3606 
            let v3608 : string = "inline_colorization::color_reset"
            let v3609 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v3608 
            let v3610 : string = "\"{v3605}{v3607}{v3609}\""
            let v3611 : string = @$"format!(" + v3610 + ")"
            let v3612 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v3611 
            let v3613 : string = "fable_library_rust::String_::fromString($0)"
            let v3614 : string = Fable.Core.RustInterop.emitRustExpr v3612 v3613 
            let _v3592 = v3614 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v3615 : string = "inline_colorization::color_bright_blue"
            let v3616 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v3615 
            let v3617 : string = "&*$0"
            let v3618 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v3578 v3617 
            let v3619 : string = "inline_colorization::color_reset"
            let v3620 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v3619 
            let v3621 : string = "\"{v3616}{v3618}{v3620}\""
            let v3622 : string = @$"format!(" + v3621 + ")"
            let v3623 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v3622 
            let v3624 : string = "fable_library_rust::String_::fromString($0)"
            let v3625 : string = Fable.Core.RustInterop.emitRustExpr v3623 v3624 
            let _v3592 = v3625 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v3626 : string = "\u001b[94m"
            let v3627 : string = method11()
            let v3628 : string = v3626 + v3578 
            let v3629 : string = v3628 + v3627 
            let _v3592 = v3629 
            #endif
#if FABLE_COMPILER_PYTHON
            let v3630 : string = "\u001b[94m"
            let v3631 : string = method11()
            let v3632 : string = v3630 + v3578 
            let v3633 : string = v3632 + v3631 
            let _v3592 = v3633 
            #endif
#else
            let v3634 : string = "\u001b[94m"
            let v3635 : string = method11()
            let v3636 : string = v3634 + v3578 
            let v3637 : string = v3636 + v3635 
            let _v3592 = v3637 
            #endif
            let v3638 : string = _v3592 
            let v3644 : int64 = v3140.l0
            let v3645 : string = method13()
            let v3646 : Mut4 = {l0 = v3645} : Mut4
            let v3647 : string = "{ "
            let v3648 : string = $"{v3647}"
            let v3651 : string = v3646.l0
            let v3652 : string = v3651 + v3648 
            v3646.l0 <- v3652
            let v3653 : string = "dir"
            let v3654 : string = $"{v3653}"
            let v3657 : string = v3646.l0
            let v3658 : string = v3657 + v3654 
            v3646.l0 <- v3658
            let v3659 : string = " = "
            let v3660 : string = $"{v3659}"
            let v3663 : string = v3646.l0
            let v3664 : string = v3663 + v3660 
            v3646.l0 <- v3664
            let v3665 : string = $"{v0}"
            let v3668 : string = v3646.l0
            let v3669 : string = v3668 + v3665 
            v3646.l0 <- v3669
            let v3670 : string = "; "
            let v3671 : string = $"{v3670}"
            let v3674 : string = v3646.l0
            let v3675 : string = v3674 + v3671 
            v3646.l0 <- v3675
            let v3676 : string = "result"
            let v3677 : string = $"{v3676}"
            let v3680 : string = v3646.l0
            let v3681 : string = v3680 + v3677 
            v3646.l0 <- v3681
            let v3682 : string = $"{v3659}"
            let v3685 : string = v3646.l0
            let v3686 : string = v3685 + v3682 
            v3646.l0 <- v3686
            let v3687 : string = $"{v3063}"
            let v3690 : string = v3646.l0
            let v3691 : string = v3690 + v3687 
            v3646.l0 <- v3691
            let v3692 : string = " }"
            let v3693 : string = $"{v3692}"
            let v3696 : string = v3646.l0
            let v3697 : string = v3696 + v3693 
            v3646.l0 <- v3697
            let v3698 : string = v3646.l0
            let v3699 : (unit -> string) = closure33()
            let v3700 : string = $"{v3508} {v3638} #{v3644} %s{v3699 ()} / {v3698}"
            let v3703 : char list = []
            let v3704 : (char list -> (char [])) = List.toArray
            let v3705 : (char []) = v3704 v3703
            let v3708 : string = v3700.TrimStart v3705 
            let v3726 : char list = []
            let v3727 : char list = '/' :: v3726 
            let v3730 : char list = ' ' :: v3727 
            let v3733 : (char list -> (char [])) = List.toArray
            let v3734 : (char []) = v3733 v3730
            let v3737 : string = v3708.TrimEnd v3734 
            let v3755 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v3756 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v3737 v3756 
            let _v3755 = () 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v3757 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v3737 v3757 
            let _v3755 = () 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v3758 : string = $"near_sdk::log!(\"{{}}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v3737 v3758 
            let _v3755 = () 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            System.Console.WriteLine v3737 
            let _v3755 = () 
            #endif
#if FABLE_COMPILER_PYTHON
            System.Console.WriteLine v3737 
            let _v3755 = () 
            #endif
#else
            System.Console.WriteLine v3737 
            let _v3755 = () 
            #endif
            _v3755 
            let v3759 : (string -> unit) = v3079.l0
            v3759 v3737
    let v3760 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3761 : (unit -> unit) = method40(v0)
    let v3762 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v3761 "$0()" )
    let _v3760 = v3762 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v3763 : (unit -> unit) = method40(v0)
    let v3764 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v3763 "$0()" )
    let _v3760 = v3764 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v3765 : (unit -> unit) = method40(v0)
    let v3766 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v3765 "$0()" )
    let _v3760 = v3766 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v3767 : (unit -> unit) = method41(v0)
    let v3768 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v3767 () }
    let _v3760 = v3768 
    #endif
#if FABLE_COMPILER_PYTHON
    let v3769 : (unit -> unit) = method41(v0)
    let v3770 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v3769 () }
    let _v3760 = v3770 
    #endif
#else
    let v3771 : (unit -> unit) = method41(v0)
    let v3772 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v3771 () }
    let _v3760 = v3772 
    #endif
    let v3773 : System.IDisposable = _v3760 
    let _v1 = v3773 
    #endif
    let v3777 : System.IDisposable = _v1 
    v3777
and closure26 () () : struct (string * System.IDisposable) =
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
and closure35 () (v0 : string) : struct (string * System.IDisposable) =
    let v1 : System.Guid = method42(v0)
    let v2 : string = method27(v1)
    let v3 : System.IDisposable = method35(v2)
    struct (v2, v3)
and closure36 () () : string =
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
and closure37 () (v0 : string) : string =
    method43(v0)
and closure38 () (v0 : string) : string =
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
and closure40 () (v0 : string) : string option =
    method47(v0)
and method46 () : (string -> string option) =
    closure40()
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
        match v7 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v9 : string = x
        let v10 : US1 = US1_0(v9)
        v10 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v8.Value <- x
        let v11 : US1 option = _v8.Value 
        let v22 : US1 = US1_1
        let v23 : US1 = v11 |> Option.defaultValue v22 
        match v23 with
        | US1_1 -> (* None *)
            let v29 : string = $"""No parent for {if false then "file" else "dir"} '{v0}' at '{v1}' (until '{v2}')"""
            US13_1(v29)
        | US1_0(v27) -> (* Some *)
            method48(v0, v1, v27)
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
        match v6 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v8 : string = x
        let v9 : US1 = US1_0(v8)
        v9 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v7.Value <- x
        let v10 : US1 option = _v7.Value 
        let v21 : US1 = US1_1
        let v22 : US1 = v10 |> Option.defaultValue v21 
        match v22 with
        | US1_1 -> (* None *)
            let v28 : string = $"""No parent for {if false then "file" else "dir"} '{v0}' at '{v1}' (until '{v1}')"""
            US13_1(v28)
        | US1_0(v26) -> (* Some *)
            method48(v0, v1, v26)
and closure41 () () : string =
    let v0 : string = "file_system.get_workspace_root"
    v0
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
and closure39 () () : string =
    let v0 : string = __SOURCE_DIRECTORY__
    let v1 : string = "polyglot"
    let v2 : string = ".devcontainer"
    let v3 : string = method30(v1, v2)
    let v4 : US13 = method45(v3, v0)
    let v682 : US1 =
        match v4 with
        | US13_1(v7) -> (* Error *)
            let v8 : bool = State.trace_state.IsNone
            if v8 then
                let v9 : US0 = US0_0
                let struct (v10 : Mut0, v11 : Mut1, v12 : Mut2, v13 : Mut3, v14 : int64 option) = method0(v9)
                let v15 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v10, v11, v12, v13, v14) 
                State.trace_state <- v15 
                ()
            let struct (v20 : Mut0, v21 : Mut1, v22 : Mut2, v23 : Mut3, v24 : int64 option) = State.trace_state.Value
            let v35 : bool = State.trace_state.IsNone
            if v35 then
                let v36 : US0 = US0_0
                let struct (v37 : Mut0, v38 : Mut1, v39 : Mut2, v40 : Mut3, v41 : int64 option) = method0(v36)
                let v42 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v37, v38, v39, v40, v41) 
                State.trace_state <- v42 
                ()
            let struct (v47 : Mut0, v48 : Mut1, v49 : Mut2, v50 : Mut3, v51 : int64 option) = State.trace_state.Value
            let v62 : US0 = v50.l0
            let v63 : bool = v49.l0
            let v64 : bool = v63 = false
            let v67 : bool =
                if v64 then
                    false
                else
                    let v65 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v62
                    let v66 : bool = 3 >= v65
                    v66
            if v67 then
                let v68 : int64 = v20.l0
                let v69 : int64 = v68 + 1L
                v20.l0 <- v69
                let v70 : bool = State.trace_state.IsNone
                if v70 then
                    let v71 : US0 = US0_0
                    let struct (v72 : Mut0, v73 : Mut1, v74 : Mut2, v75 : Mut3, v76 : int64 option) = method0(v71)
                    let v77 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v72, v73, v74, v75, v76) 
                    State.trace_state <- v77 
                    ()
                let struct (v82 : Mut0, v83 : Mut1, v84 : Mut2, v85 : Mut3, v86 : int64 option) = State.trace_state.Value
                let v97 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v98 : US3 option = None
                let _v98 = ref v98 
                match v86 with
                | Some x -> (
                (fun () ->
                (fun () ->
                let v99 : int64 = x
                let v100 : US3 = US3_0(v99)
                v100 
                )
                |> fun x -> x () |> Some
                ) () ) | None -> None
                |> fun x -> _v98.Value <- x
                let v101 : US3 option = _v98.Value 
                let v112 : US3 = US3_1
                let v113 : US3 = v101 |> Option.defaultValue v112 
                let v153 : System.DateTime =
                    match v113 with
                    | US3_1 -> (* None *)
                        let v149 : System.DateTime = System.DateTime.Now
                        v149
                    | US3_0(v117) -> (* Some *)
                        let v118 : System.DateTime = System.DateTime.Now
                        let v121 : (System.DateTime -> int64) = _.Ticks
                        let v122 : int64 = v121 v118
                        let v125 : int64 = v122 - v117
                        let v126 : (int64 -> System.TimeSpan) = System.TimeSpan 
                        let v127 : System.TimeSpan = v126 v125
                        let v130 : (System.TimeSpan -> int32) = _.Hours
                        let v131 : int32 = v130 v127
                        let v134 : (System.TimeSpan -> int32) = _.Minutes
                        let v135 : int32 = v134 v127
                        let v138 : (System.TimeSpan -> int32) = _.Seconds
                        let v139 : int32 = v138 v127
                        let v142 : (System.TimeSpan -> int32) = _.Milliseconds
                        let v143 : int32 = v142 v127
                        let v146 : System.DateTime = System.DateTime (1, 1, 1, v131, v135, v139, v143)
                        v146
                let v154 : string = method9()
                let v157 : (string -> string) = v153.ToString
                let v158 : string = v157 v154
                let _v97 = v158 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v161 : US3 option = None
                let _v161 = ref v161 
                match v86 with
                | Some x -> (
                (fun () ->
                (fun () ->
                let v162 : int64 = x
                let v163 : US3 = US3_0(v162)
                v163 
                )
                |> fun x -> x () |> Some
                ) () ) | None -> None
                |> fun x -> _v161.Value <- x
                let v164 : US3 option = _v161.Value 
                let v175 : US3 = US3_1
                let v176 : US3 = v164 |> Option.defaultValue v175 
                let v216 : System.DateTime =
                    match v176 with
                    | US3_1 -> (* None *)
                        let v212 : System.DateTime = System.DateTime.Now
                        v212
                    | US3_0(v180) -> (* Some *)
                        let v181 : System.DateTime = System.DateTime.Now
                        let v184 : (System.DateTime -> int64) = _.Ticks
                        let v185 : int64 = v184 v181
                        let v188 : int64 = v185 - v180
                        let v189 : (int64 -> System.TimeSpan) = System.TimeSpan 
                        let v190 : System.TimeSpan = v189 v188
                        let v193 : (System.TimeSpan -> int32) = _.Hours
                        let v194 : int32 = v193 v190
                        let v197 : (System.TimeSpan -> int32) = _.Minutes
                        let v198 : int32 = v197 v190
                        let v201 : (System.TimeSpan -> int32) = _.Seconds
                        let v202 : int32 = v201 v190
                        let v205 : (System.TimeSpan -> int32) = _.Milliseconds
                        let v206 : int32 = v205 v190
                        let v209 : System.DateTime = System.DateTime (1, 1, 1, v194, v198, v202, v206)
                        v209
                let v217 : string = method9()
                let v220 : (string -> string) = v216.ToString
                let v221 : string = v220 v217
                let _v97 = v221 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v224 : string = $"near_sdk::env::block_timestamp()"
                let v225 : uint64 = Fable.Core.RustInterop.emitRustExpr () v224 
                let v226 : US3 option = None
                let _v226 = ref v226 
                match v86 with
                | Some x -> (
                (fun () ->
                (fun () ->
                let v227 : int64 = x
                let v228 : US3 = US3_0(v227)
                v228 
                )
                |> fun x -> x () |> Some
                ) () ) | None -> None
                |> fun x -> _v226.Value <- x
                let v229 : US3 option = _v226.Value 
                let v240 : US3 = US3_1
                let v241 : US3 = v229 |> Option.defaultValue v240 
                let v250 : uint64 =
                    match v241 with
                    | US3_1 -> (* None *)
                        v225
                    | US3_0(v245) -> (* Some *)
                        let v246 : (int64 -> uint64) = uint64
                        let v247 : uint64 = v246 v245
                        let v248 : uint64 = v225 - v247
                        v248
                let v251 : uint64 = v250 / 1000000000UL
                let v252 : uint64 = v251 % 60UL
                let v253 : uint64 = v251 / 60UL
                let v254 : uint64 = v253 % 60UL
                let v255 : uint64 = v251 / 3600UL
                let v256 : uint64 = v255 % 24UL
                let v257 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
                let v258 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v256, v254, v252) v257 
                let v259 : string = "fable_library_rust::String_::fromString($0)"
                let v260 : string = Fable.Core.RustInterop.emitRustExpr v258 v259 
                let _v97 = v260 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v261 : US3 option = None
                let _v261 = ref v261 
                match v86 with
                | Some x -> (
                (fun () ->
                (fun () ->
                let v262 : int64 = x
                let v263 : US3 = US3_0(v262)
                v263 
                )
                |> fun x -> x () |> Some
                ) () ) | None -> None
                |> fun x -> _v261.Value <- x
                let v264 : US3 option = _v261.Value 
                let v275 : US3 = US3_1
                let v276 : US3 = v264 |> Option.defaultValue v275 
                let v316 : System.DateTime =
                    match v276 with
                    | US3_1 -> (* None *)
                        let v312 : System.DateTime = System.DateTime.Now
                        v312
                    | US3_0(v280) -> (* Some *)
                        let v281 : System.DateTime = System.DateTime.Now
                        let v284 : (System.DateTime -> int64) = _.Ticks
                        let v285 : int64 = v284 v281
                        let v288 : int64 = v285 - v280
                        let v289 : (int64 -> System.TimeSpan) = System.TimeSpan 
                        let v290 : System.TimeSpan = v289 v288
                        let v293 : (System.TimeSpan -> int32) = _.Hours
                        let v294 : int32 = v293 v290
                        let v297 : (System.TimeSpan -> int32) = _.Minutes
                        let v298 : int32 = v297 v290
                        let v301 : (System.TimeSpan -> int32) = _.Seconds
                        let v302 : int32 = v301 v290
                        let v305 : (System.TimeSpan -> int32) = _.Milliseconds
                        let v306 : int32 = v305 v290
                        let v309 : System.DateTime = System.DateTime (1, 1, 1, v294, v298, v302, v306)
                        v309
                let v317 : string = method10()
                let v320 : (string -> string) = v316.ToString
                let v321 : string = v320 v317
                let _v97 = v321 
                #endif
#if FABLE_COMPILER_PYTHON
                let v324 : US3 option = None
                let _v324 = ref v324 
                match v86 with
                | Some x -> (
                (fun () ->
                (fun () ->
                let v325 : int64 = x
                let v326 : US3 = US3_0(v325)
                v326 
                )
                |> fun x -> x () |> Some
                ) () ) | None -> None
                |> fun x -> _v324.Value <- x
                let v327 : US3 option = _v324.Value 
                let v338 : US3 = US3_1
                let v339 : US3 = v327 |> Option.defaultValue v338 
                let v379 : System.DateTime =
                    match v339 with
                    | US3_1 -> (* None *)
                        let v375 : System.DateTime = System.DateTime.Now
                        v375
                    | US3_0(v343) -> (* Some *)
                        let v344 : System.DateTime = System.DateTime.Now
                        let v347 : (System.DateTime -> int64) = _.Ticks
                        let v348 : int64 = v347 v344
                        let v351 : int64 = v348 - v343
                        let v352 : (int64 -> System.TimeSpan) = System.TimeSpan 
                        let v353 : System.TimeSpan = v352 v351
                        let v356 : (System.TimeSpan -> int32) = _.Hours
                        let v357 : int32 = v356 v353
                        let v360 : (System.TimeSpan -> int32) = _.Minutes
                        let v361 : int32 = v360 v353
                        let v364 : (System.TimeSpan -> int32) = _.Seconds
                        let v365 : int32 = v364 v353
                        let v368 : (System.TimeSpan -> int32) = _.Milliseconds
                        let v369 : int32 = v368 v353
                        let v372 : System.DateTime = System.DateTime (1, 1, 1, v357, v361, v365, v369)
                        v372
                let v380 : string = method10()
                let v383 : (string -> string) = v379.ToString
                let v384 : string = v383 v380
                let _v97 = v384 
                #endif
#else
                let v387 : US3 option = None
                let _v387 = ref v387 
                match v86 with
                | Some x -> (
                (fun () ->
                (fun () ->
                let v388 : int64 = x
                let v389 : US3 = US3_0(v388)
                v389 
                )
                |> fun x -> x () |> Some
                ) () ) | None -> None
                |> fun x -> _v387.Value <- x
                let v390 : US3 option = _v387.Value 
                let v401 : US3 = US3_1
                let v402 : US3 = v390 |> Option.defaultValue v401 
                let v442 : System.DateTime =
                    match v402 with
                    | US3_1 -> (* None *)
                        let v438 : System.DateTime = System.DateTime.Now
                        v438
                    | US3_0(v406) -> (* Some *)
                        let v407 : System.DateTime = System.DateTime.Now
                        let v410 : (System.DateTime -> int64) = _.Ticks
                        let v411 : int64 = v410 v407
                        let v414 : int64 = v411 - v406
                        let v415 : (int64 -> System.TimeSpan) = System.TimeSpan 
                        let v416 : System.TimeSpan = v415 v414
                        let v419 : (System.TimeSpan -> int32) = _.Hours
                        let v420 : int32 = v419 v416
                        let v423 : (System.TimeSpan -> int32) = _.Minutes
                        let v424 : int32 = v423 v416
                        let v427 : (System.TimeSpan -> int32) = _.Seconds
                        let v428 : int32 = v427 v416
                        let v431 : (System.TimeSpan -> int32) = _.Milliseconds
                        let v432 : int32 = v431 v416
                        let v435 : System.DateTime = System.DateTime (1, 1, 1, v420, v424, v428, v432)
                        v435
                let v443 : string = method10()
                let v446 : (string -> string) = v442.ToString
                let v447 : string = v446 v443
                let _v97 = v447 
                #endif
                let v450 : string = _v97 
                let v515 : string = "Warning"
                let v516 : (unit -> string) = v515.ToLower
                let v517 : string = v516 ()
                let v520 : string = v517.PadLeft (7, ' ')
                let v534 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v535 : string = "inline_colorization::color_yellow"
                let v536 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v535 
                let v537 : string = "&*$0"
                let v538 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v520 v537 
                let v539 : string = "inline_colorization::color_reset"
                let v540 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v539 
                let v541 : string = "\"{v536}{v538}{v540}\""
                let v542 : string = @$"format!(" + v541 + ")"
                let v543 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v542 
                let v544 : string = "fable_library_rust::String_::fromString($0)"
                let v545 : string = Fable.Core.RustInterop.emitRustExpr v543 v544 
                let _v534 = v545 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v546 : string = "inline_colorization::color_yellow"
                let v547 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v546 
                let v548 : string = "&*$0"
                let v549 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v520 v548 
                let v550 : string = "inline_colorization::color_reset"
                let v551 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v550 
                let v552 : string = "\"{v547}{v549}{v551}\""
                let v553 : string = @$"format!(" + v552 + ")"
                let v554 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v553 
                let v555 : string = "fable_library_rust::String_::fromString($0)"
                let v556 : string = Fable.Core.RustInterop.emitRustExpr v554 v555 
                let _v534 = v556 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v557 : string = "inline_colorization::color_yellow"
                let v558 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v557 
                let v559 : string = "&*$0"
                let v560 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v520 v559 
                let v561 : string = "inline_colorization::color_reset"
                let v562 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v561 
                let v563 : string = "\"{v558}{v560}{v562}\""
                let v564 : string = @$"format!(" + v563 + ")"
                let v565 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v564 
                let v566 : string = "fable_library_rust::String_::fromString($0)"
                let v567 : string = Fable.Core.RustInterop.emitRustExpr v565 v566 
                let _v534 = v567 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v568 : string = "\u001b[93m"
                let v569 : string = method11()
                let v570 : string = v568 + v520 
                let v571 : string = v570 + v569 
                let _v534 = v571 
                #endif
#if FABLE_COMPILER_PYTHON
                let v572 : string = "\u001b[93m"
                let v573 : string = method11()
                let v574 : string = v572 + v520 
                let v575 : string = v574 + v573 
                let _v534 = v575 
                #endif
#else
                let v576 : string = "\u001b[93m"
                let v577 : string = method11()
                let v578 : string = v576 + v520 
                let v579 : string = v578 + v577 
                let _v534 = v579 
                #endif
                let v580 : string = _v534 
                let v586 : int64 = v82.l0
                let v587 : string = method13()
                let v588 : Mut4 = {l0 = v587} : Mut4
                let v589 : string = "{ "
                let v590 : string = $"{v589}"
                let v593 : string = v588.l0
                let v594 : string = v593 + v590 
                v588.l0 <- v594
                let v595 : string = "error"
                let v596 : string = $"{v595}"
                let v599 : string = v588.l0
                let v600 : string = v599 + v596 
                v588.l0 <- v600
                let v601 : string = " = "
                let v602 : string = $"{v601}"
                let v605 : string = v588.l0
                let v606 : string = v605 + v602 
                v588.l0 <- v606
                let v607 : string = $"{v7}"
                let v610 : string = v588.l0
                let v611 : string = v610 + v607 
                v588.l0 <- v611
                let v612 : string = " }"
                let v613 : string = $"{v612}"
                let v616 : string = v588.l0
                let v617 : string = v616 + v613 
                v588.l0 <- v617
                let v618 : string = v588.l0
                let v619 : (unit -> string) = closure41()
                let v620 : string = $"{v450} {v580} #{v586} %s{v619 ()} / {v618}"
                let v623 : char list = []
                let v624 : (char list -> (char [])) = List.toArray
                let v625 : (char []) = v624 v623
                let v628 : string = v620.TrimStart v625 
                let v646 : char list = []
                let v647 : char list = '/' :: v646 
                let v650 : char list = ' ' :: v647 
                let v653 : (char list -> (char [])) = List.toArray
                let v654 : (char []) = v653 v650
                let v657 : string = v628.TrimEnd v654 
                let v675 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v676 : string = @"println!(""{}"", $0)"
                Fable.Core.RustInterop.emitRustExpr v657 v676 
                let _v675 = () 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v677 : string = @"println!(""{}"", $0)"
                Fable.Core.RustInterop.emitRustExpr v657 v677 
                let _v675 = () 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v678 : string = $"near_sdk::log!(\"{{}}\", $0)"
                Fable.Core.RustInterop.emitRustExpr v657 v678 
                let _v675 = () 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                System.Console.WriteLine v657 
                let _v675 = () 
                #endif
#if FABLE_COMPILER_PYTHON
                System.Console.WriteLine v657 
                let _v675 = () 
                #endif
#else
                System.Console.WriteLine v657 
                let _v675 = () 
                #endif
                _v675 
                let v679 : (string -> unit) = v21.l0
                v679 v657
            US1_1
        | US13_0(v5) -> (* Ok *)
            US1_0(v5)
    let v1367 : US1 =
        match v682 with
        | US1_1 -> (* None *)
            let v685 : string = method49()
            let v686 : string = method30(v1, v2)
            let v687 : US13 = method45(v686, v685)
            match v687 with
            | US13_1(v690) -> (* Error *)
                let v691 : bool = State.trace_state.IsNone
                if v691 then
                    let v692 : US0 = US0_0
                    let struct (v693 : Mut0, v694 : Mut1, v695 : Mut2, v696 : Mut3, v697 : int64 option) = method0(v692)
                    let v698 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v693, v694, v695, v696, v697) 
                    State.trace_state <- v698 
                    ()
                let struct (v703 : Mut0, v704 : Mut1, v705 : Mut2, v706 : Mut3, v707 : int64 option) = State.trace_state.Value
                let v718 : bool = State.trace_state.IsNone
                if v718 then
                    let v719 : US0 = US0_0
                    let struct (v720 : Mut0, v721 : Mut1, v722 : Mut2, v723 : Mut3, v724 : int64 option) = method0(v719)
                    let v725 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v720, v721, v722, v723, v724) 
                    State.trace_state <- v725 
                    ()
                let struct (v730 : Mut0, v731 : Mut1, v732 : Mut2, v733 : Mut3, v734 : int64 option) = State.trace_state.Value
                let v745 : US0 = v733.l0
                let v746 : bool = v732.l0
                let v747 : bool = v746 = false
                let v750 : bool =
                    if v747 then
                        false
                    else
                        let v748 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v745
                        let v749 : bool = 3 >= v748
                        v749
                if v750 then
                    let v751 : int64 = v703.l0
                    let v752 : int64 = v751 + 1L
                    v703.l0 <- v752
                    let v753 : bool = State.trace_state.IsNone
                    if v753 then
                        let v754 : US0 = US0_0
                        let struct (v755 : Mut0, v756 : Mut1, v757 : Mut2, v758 : Mut3, v759 : int64 option) = method0(v754)
                        let v760 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v755, v756, v757, v758, v759) 
                        State.trace_state <- v760 
                        ()
                    let struct (v765 : Mut0, v766 : Mut1, v767 : Mut2, v768 : Mut3, v769 : int64 option) = State.trace_state.Value
                    let v780 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v781 : US3 option = None
                    let _v781 = ref v781 
                    match v769 with
                    | Some x -> (
                    (fun () ->
                    (fun () ->
                    let v782 : int64 = x
                    let v783 : US3 = US3_0(v782)
                    v783 
                    )
                    |> fun x -> x () |> Some
                    ) () ) | None -> None
                    |> fun x -> _v781.Value <- x
                    let v784 : US3 option = _v781.Value 
                    let v795 : US3 = US3_1
                    let v796 : US3 = v784 |> Option.defaultValue v795 
                    let v836 : System.DateTime =
                        match v796 with
                        | US3_1 -> (* None *)
                            let v832 : System.DateTime = System.DateTime.Now
                            v832
                        | US3_0(v800) -> (* Some *)
                            let v801 : System.DateTime = System.DateTime.Now
                            let v804 : (System.DateTime -> int64) = _.Ticks
                            let v805 : int64 = v804 v801
                            let v808 : int64 = v805 - v800
                            let v809 : (int64 -> System.TimeSpan) = System.TimeSpan 
                            let v810 : System.TimeSpan = v809 v808
                            let v813 : (System.TimeSpan -> int32) = _.Hours
                            let v814 : int32 = v813 v810
                            let v817 : (System.TimeSpan -> int32) = _.Minutes
                            let v818 : int32 = v817 v810
                            let v821 : (System.TimeSpan -> int32) = _.Seconds
                            let v822 : int32 = v821 v810
                            let v825 : (System.TimeSpan -> int32) = _.Milliseconds
                            let v826 : int32 = v825 v810
                            let v829 : System.DateTime = System.DateTime (1, 1, 1, v814, v818, v822, v826)
                            v829
                    let v837 : string = method9()
                    let v840 : (string -> string) = v836.ToString
                    let v841 : string = v840 v837
                    let _v780 = v841 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v844 : US3 option = None
                    let _v844 = ref v844 
                    match v769 with
                    | Some x -> (
                    (fun () ->
                    (fun () ->
                    let v845 : int64 = x
                    let v846 : US3 = US3_0(v845)
                    v846 
                    )
                    |> fun x -> x () |> Some
                    ) () ) | None -> None
                    |> fun x -> _v844.Value <- x
                    let v847 : US3 option = _v844.Value 
                    let v858 : US3 = US3_1
                    let v859 : US3 = v847 |> Option.defaultValue v858 
                    let v899 : System.DateTime =
                        match v859 with
                        | US3_1 -> (* None *)
                            let v895 : System.DateTime = System.DateTime.Now
                            v895
                        | US3_0(v863) -> (* Some *)
                            let v864 : System.DateTime = System.DateTime.Now
                            let v867 : (System.DateTime -> int64) = _.Ticks
                            let v868 : int64 = v867 v864
                            let v871 : int64 = v868 - v863
                            let v872 : (int64 -> System.TimeSpan) = System.TimeSpan 
                            let v873 : System.TimeSpan = v872 v871
                            let v876 : (System.TimeSpan -> int32) = _.Hours
                            let v877 : int32 = v876 v873
                            let v880 : (System.TimeSpan -> int32) = _.Minutes
                            let v881 : int32 = v880 v873
                            let v884 : (System.TimeSpan -> int32) = _.Seconds
                            let v885 : int32 = v884 v873
                            let v888 : (System.TimeSpan -> int32) = _.Milliseconds
                            let v889 : int32 = v888 v873
                            let v892 : System.DateTime = System.DateTime (1, 1, 1, v877, v881, v885, v889)
                            v892
                    let v900 : string = method9()
                    let v903 : (string -> string) = v899.ToString
                    let v904 : string = v903 v900
                    let _v780 = v904 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v907 : string = $"near_sdk::env::block_timestamp()"
                    let v908 : uint64 = Fable.Core.RustInterop.emitRustExpr () v907 
                    let v909 : US3 option = None
                    let _v909 = ref v909 
                    match v769 with
                    | Some x -> (
                    (fun () ->
                    (fun () ->
                    let v910 : int64 = x
                    let v911 : US3 = US3_0(v910)
                    v911 
                    )
                    |> fun x -> x () |> Some
                    ) () ) | None -> None
                    |> fun x -> _v909.Value <- x
                    let v912 : US3 option = _v909.Value 
                    let v923 : US3 = US3_1
                    let v924 : US3 = v912 |> Option.defaultValue v923 
                    let v933 : uint64 =
                        match v924 with
                        | US3_1 -> (* None *)
                            v908
                        | US3_0(v928) -> (* Some *)
                            let v929 : (int64 -> uint64) = uint64
                            let v930 : uint64 = v929 v928
                            let v931 : uint64 = v908 - v930
                            v931
                    let v934 : uint64 = v933 / 1000000000UL
                    let v935 : uint64 = v934 % 60UL
                    let v936 : uint64 = v934 / 60UL
                    let v937 : uint64 = v936 % 60UL
                    let v938 : uint64 = v934 / 3600UL
                    let v939 : uint64 = v938 % 24UL
                    let v940 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
                    let v941 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v939, v937, v935) v940 
                    let v942 : string = "fable_library_rust::String_::fromString($0)"
                    let v943 : string = Fable.Core.RustInterop.emitRustExpr v941 v942 
                    let _v780 = v943 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v944 : US3 option = None
                    let _v944 = ref v944 
                    match v769 with
                    | Some x -> (
                    (fun () ->
                    (fun () ->
                    let v945 : int64 = x
                    let v946 : US3 = US3_0(v945)
                    v946 
                    )
                    |> fun x -> x () |> Some
                    ) () ) | None -> None
                    |> fun x -> _v944.Value <- x
                    let v947 : US3 option = _v944.Value 
                    let v958 : US3 = US3_1
                    let v959 : US3 = v947 |> Option.defaultValue v958 
                    let v999 : System.DateTime =
                        match v959 with
                        | US3_1 -> (* None *)
                            let v995 : System.DateTime = System.DateTime.Now
                            v995
                        | US3_0(v963) -> (* Some *)
                            let v964 : System.DateTime = System.DateTime.Now
                            let v967 : (System.DateTime -> int64) = _.Ticks
                            let v968 : int64 = v967 v964
                            let v971 : int64 = v968 - v963
                            let v972 : (int64 -> System.TimeSpan) = System.TimeSpan 
                            let v973 : System.TimeSpan = v972 v971
                            let v976 : (System.TimeSpan -> int32) = _.Hours
                            let v977 : int32 = v976 v973
                            let v980 : (System.TimeSpan -> int32) = _.Minutes
                            let v981 : int32 = v980 v973
                            let v984 : (System.TimeSpan -> int32) = _.Seconds
                            let v985 : int32 = v984 v973
                            let v988 : (System.TimeSpan -> int32) = _.Milliseconds
                            let v989 : int32 = v988 v973
                            let v992 : System.DateTime = System.DateTime (1, 1, 1, v977, v981, v985, v989)
                            v992
                    let v1000 : string = method10()
                    let v1003 : (string -> string) = v999.ToString
                    let v1004 : string = v1003 v1000
                    let _v780 = v1004 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v1007 : US3 option = None
                    let _v1007 = ref v1007 
                    match v769 with
                    | Some x -> (
                    (fun () ->
                    (fun () ->
                    let v1008 : int64 = x
                    let v1009 : US3 = US3_0(v1008)
                    v1009 
                    )
                    |> fun x -> x () |> Some
                    ) () ) | None -> None
                    |> fun x -> _v1007.Value <- x
                    let v1010 : US3 option = _v1007.Value 
                    let v1021 : US3 = US3_1
                    let v1022 : US3 = v1010 |> Option.defaultValue v1021 
                    let v1062 : System.DateTime =
                        match v1022 with
                        | US3_1 -> (* None *)
                            let v1058 : System.DateTime = System.DateTime.Now
                            v1058
                        | US3_0(v1026) -> (* Some *)
                            let v1027 : System.DateTime = System.DateTime.Now
                            let v1030 : (System.DateTime -> int64) = _.Ticks
                            let v1031 : int64 = v1030 v1027
                            let v1034 : int64 = v1031 - v1026
                            let v1035 : (int64 -> System.TimeSpan) = System.TimeSpan 
                            let v1036 : System.TimeSpan = v1035 v1034
                            let v1039 : (System.TimeSpan -> int32) = _.Hours
                            let v1040 : int32 = v1039 v1036
                            let v1043 : (System.TimeSpan -> int32) = _.Minutes
                            let v1044 : int32 = v1043 v1036
                            let v1047 : (System.TimeSpan -> int32) = _.Seconds
                            let v1048 : int32 = v1047 v1036
                            let v1051 : (System.TimeSpan -> int32) = _.Milliseconds
                            let v1052 : int32 = v1051 v1036
                            let v1055 : System.DateTime = System.DateTime (1, 1, 1, v1040, v1044, v1048, v1052)
                            v1055
                    let v1063 : string = method10()
                    let v1066 : (string -> string) = v1062.ToString
                    let v1067 : string = v1066 v1063
                    let _v780 = v1067 
                    #endif
#else
                    let v1070 : US3 option = None
                    let _v1070 = ref v1070 
                    match v769 with
                    | Some x -> (
                    (fun () ->
                    (fun () ->
                    let v1071 : int64 = x
                    let v1072 : US3 = US3_0(v1071)
                    v1072 
                    )
                    |> fun x -> x () |> Some
                    ) () ) | None -> None
                    |> fun x -> _v1070.Value <- x
                    let v1073 : US3 option = _v1070.Value 
                    let v1084 : US3 = US3_1
                    let v1085 : US3 = v1073 |> Option.defaultValue v1084 
                    let v1125 : System.DateTime =
                        match v1085 with
                        | US3_1 -> (* None *)
                            let v1121 : System.DateTime = System.DateTime.Now
                            v1121
                        | US3_0(v1089) -> (* Some *)
                            let v1090 : System.DateTime = System.DateTime.Now
                            let v1093 : (System.DateTime -> int64) = _.Ticks
                            let v1094 : int64 = v1093 v1090
                            let v1097 : int64 = v1094 - v1089
                            let v1098 : (int64 -> System.TimeSpan) = System.TimeSpan 
                            let v1099 : System.TimeSpan = v1098 v1097
                            let v1102 : (System.TimeSpan -> int32) = _.Hours
                            let v1103 : int32 = v1102 v1099
                            let v1106 : (System.TimeSpan -> int32) = _.Minutes
                            let v1107 : int32 = v1106 v1099
                            let v1110 : (System.TimeSpan -> int32) = _.Seconds
                            let v1111 : int32 = v1110 v1099
                            let v1114 : (System.TimeSpan -> int32) = _.Milliseconds
                            let v1115 : int32 = v1114 v1099
                            let v1118 : System.DateTime = System.DateTime (1, 1, 1, v1103, v1107, v1111, v1115)
                            v1118
                    let v1126 : string = method10()
                    let v1129 : (string -> string) = v1125.ToString
                    let v1130 : string = v1129 v1126
                    let _v780 = v1130 
                    #endif
                    let v1133 : string = _v780 
                    let v1198 : string = "Warning"
                    let v1199 : (unit -> string) = v1198.ToLower
                    let v1200 : string = v1199 ()
                    let v1203 : string = v1200.PadLeft (7, ' ')
                    let v1217 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1218 : string = "inline_colorization::color_yellow"
                    let v1219 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1218 
                    let v1220 : string = "&*$0"
                    let v1221 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1203 v1220 
                    let v1222 : string = "inline_colorization::color_reset"
                    let v1223 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1222 
                    let v1224 : string = "\"{v1219}{v1221}{v1223}\""
                    let v1225 : string = @$"format!(" + v1224 + ")"
                    let v1226 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v1225 
                    let v1227 : string = "fable_library_rust::String_::fromString($0)"
                    let v1228 : string = Fable.Core.RustInterop.emitRustExpr v1226 v1227 
                    let _v1217 = v1228 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v1229 : string = "inline_colorization::color_yellow"
                    let v1230 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1229 
                    let v1231 : string = "&*$0"
                    let v1232 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1203 v1231 
                    let v1233 : string = "inline_colorization::color_reset"
                    let v1234 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1233 
                    let v1235 : string = "\"{v1230}{v1232}{v1234}\""
                    let v1236 : string = @$"format!(" + v1235 + ")"
                    let v1237 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v1236 
                    let v1238 : string = "fable_library_rust::String_::fromString($0)"
                    let v1239 : string = Fable.Core.RustInterop.emitRustExpr v1237 v1238 
                    let _v1217 = v1239 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1240 : string = "inline_colorization::color_yellow"
                    let v1241 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1240 
                    let v1242 : string = "&*$0"
                    let v1243 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1203 v1242 
                    let v1244 : string = "inline_colorization::color_reset"
                    let v1245 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1244 
                    let v1246 : string = "\"{v1241}{v1243}{v1245}\""
                    let v1247 : string = @$"format!(" + v1246 + ")"
                    let v1248 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v1247 
                    let v1249 : string = "fable_library_rust::String_::fromString($0)"
                    let v1250 : string = Fable.Core.RustInterop.emitRustExpr v1248 v1249 
                    let _v1217 = v1250 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v1251 : string = "\u001b[93m"
                    let v1252 : string = method11()
                    let v1253 : string = v1251 + v1203 
                    let v1254 : string = v1253 + v1252 
                    let _v1217 = v1254 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v1255 : string = "\u001b[93m"
                    let v1256 : string = method11()
                    let v1257 : string = v1255 + v1203 
                    let v1258 : string = v1257 + v1256 
                    let _v1217 = v1258 
                    #endif
#else
                    let v1259 : string = "\u001b[93m"
                    let v1260 : string = method11()
                    let v1261 : string = v1259 + v1203 
                    let v1262 : string = v1261 + v1260 
                    let _v1217 = v1262 
                    #endif
                    let v1263 : string = _v1217 
                    let v1269 : int64 = v765.l0
                    let v1270 : string = method13()
                    let v1271 : Mut4 = {l0 = v1270} : Mut4
                    let v1272 : string = "{ "
                    let v1273 : string = $"{v1272}"
                    let v1276 : string = v1271.l0
                    let v1277 : string = v1276 + v1273 
                    v1271.l0 <- v1277
                    let v1278 : string = "error"
                    let v1279 : string = $"{v1278}"
                    let v1282 : string = v1271.l0
                    let v1283 : string = v1282 + v1279 
                    v1271.l0 <- v1283
                    let v1284 : string = " = "
                    let v1285 : string = $"{v1284}"
                    let v1288 : string = v1271.l0
                    let v1289 : string = v1288 + v1285 
                    v1271.l0 <- v1289
                    let v1290 : string = $"{v690}"
                    let v1293 : string = v1271.l0
                    let v1294 : string = v1293 + v1290 
                    v1271.l0 <- v1294
                    let v1295 : string = " }"
                    let v1296 : string = $"{v1295}"
                    let v1299 : string = v1271.l0
                    let v1300 : string = v1299 + v1296 
                    v1271.l0 <- v1300
                    let v1301 : string = v1271.l0
                    let v1302 : (unit -> string) = closure41()
                    let v1303 : string = $"{v1133} {v1263} #{v1269} %s{v1302 ()} / {v1301}"
                    let v1306 : char list = []
                    let v1307 : (char list -> (char [])) = List.toArray
                    let v1308 : (char []) = v1307 v1306
                    let v1311 : string = v1303.TrimStart v1308 
                    let v1329 : char list = []
                    let v1330 : char list = '/' :: v1329 
                    let v1333 : char list = ' ' :: v1330 
                    let v1336 : (char list -> (char [])) = List.toArray
                    let v1337 : (char []) = v1336 v1333
                    let v1340 : string = v1311.TrimEnd v1337 
                    let v1358 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1359 : string = @"println!(""{}"", $0)"
                    Fable.Core.RustInterop.emitRustExpr v1340 v1359 
                    let _v1358 = () 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v1360 : string = @"println!(""{}"", $0)"
                    Fable.Core.RustInterop.emitRustExpr v1340 v1360 
                    let _v1358 = () 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1361 : string = $"near_sdk::log!(\"{{}}\", $0)"
                    Fable.Core.RustInterop.emitRustExpr v1340 v1361 
                    let _v1358 = () 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    System.Console.WriteLine v1340 
                    let _v1358 = () 
                    #endif
#if FABLE_COMPILER_PYTHON
                    System.Console.WriteLine v1340 
                    let _v1358 = () 
                    #endif
#else
                    System.Console.WriteLine v1340 
                    let _v1358 = () 
                    #endif
                    _v1358 
                    let v1362 : (string -> unit) = v704.l0
                    v1362 v1340
                US1_1
            | US13_0(v688) -> (* Ok *)
                US1_0(v688)
        | US1_0(v683) -> (* Some *)
            US1_0(v683)
    let v1371 : string =
        match v1367 with
        | US1_1 -> (* None *)
            failwith<string> "Option does not have a value."
        | US1_0(v1368) -> (* Some *)
            v1368
    method30(v1371, v1)
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
    let v694 : US1 =
        match v16 with
        | US13_1(v19) -> (* Error *)
            let v20 : bool = State.trace_state.IsNone
            if v20 then
                let v21 : US0 = US0_0
                let struct (v22 : Mut0, v23 : Mut1, v24 : Mut2, v25 : Mut3, v26 : int64 option) = method0(v21)
                let v27 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v22, v23, v24, v25, v26) 
                State.trace_state <- v27 
                ()
            let struct (v32 : Mut0, v33 : Mut1, v34 : Mut2, v35 : Mut3, v36 : int64 option) = State.trace_state.Value
            let v47 : bool = State.trace_state.IsNone
            if v47 then
                let v48 : US0 = US0_0
                let struct (v49 : Mut0, v50 : Mut1, v51 : Mut2, v52 : Mut3, v53 : int64 option) = method0(v48)
                let v54 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v49, v50, v51, v52, v53) 
                State.trace_state <- v54 
                ()
            let struct (v59 : Mut0, v60 : Mut1, v61 : Mut2, v62 : Mut3, v63 : int64 option) = State.trace_state.Value
            let v74 : US0 = v62.l0
            let v75 : bool = v61.l0
            let v76 : bool = v75 = false
            let v79 : bool =
                if v76 then
                    false
                else
                    let v77 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v74
                    let v78 : bool = 3 >= v77
                    v78
            if v79 then
                let v80 : int64 = v32.l0
                let v81 : int64 = v80 + 1L
                v32.l0 <- v81
                let v82 : bool = State.trace_state.IsNone
                if v82 then
                    let v83 : US0 = US0_0
                    let struct (v84 : Mut0, v85 : Mut1, v86 : Mut2, v87 : Mut3, v88 : int64 option) = method0(v83)
                    let v89 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v84, v85, v86, v87, v88) 
                    State.trace_state <- v89 
                    ()
                let struct (v94 : Mut0, v95 : Mut1, v96 : Mut2, v97 : Mut3, v98 : int64 option) = State.trace_state.Value
                let v109 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v110 : US3 option = None
                let _v110 = ref v110 
                match v98 with
                | Some x -> (
                (fun () ->
                (fun () ->
                let v111 : int64 = x
                let v112 : US3 = US3_0(v111)
                v112 
                )
                |> fun x -> x () |> Some
                ) () ) | None -> None
                |> fun x -> _v110.Value <- x
                let v113 : US3 option = _v110.Value 
                let v124 : US3 = US3_1
                let v125 : US3 = v113 |> Option.defaultValue v124 
                let v165 : System.DateTime =
                    match v125 with
                    | US3_1 -> (* None *)
                        let v161 : System.DateTime = System.DateTime.Now
                        v161
                    | US3_0(v129) -> (* Some *)
                        let v130 : System.DateTime = System.DateTime.Now
                        let v133 : (System.DateTime -> int64) = _.Ticks
                        let v134 : int64 = v133 v130
                        let v137 : int64 = v134 - v129
                        let v138 : (int64 -> System.TimeSpan) = System.TimeSpan 
                        let v139 : System.TimeSpan = v138 v137
                        let v142 : (System.TimeSpan -> int32) = _.Hours
                        let v143 : int32 = v142 v139
                        let v146 : (System.TimeSpan -> int32) = _.Minutes
                        let v147 : int32 = v146 v139
                        let v150 : (System.TimeSpan -> int32) = _.Seconds
                        let v151 : int32 = v150 v139
                        let v154 : (System.TimeSpan -> int32) = _.Milliseconds
                        let v155 : int32 = v154 v139
                        let v158 : System.DateTime = System.DateTime (1, 1, 1, v143, v147, v151, v155)
                        v158
                let v166 : string = method9()
                let v169 : (string -> string) = v165.ToString
                let v170 : string = v169 v166
                let _v109 = v170 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v173 : US3 option = None
                let _v173 = ref v173 
                match v98 with
                | Some x -> (
                (fun () ->
                (fun () ->
                let v174 : int64 = x
                let v175 : US3 = US3_0(v174)
                v175 
                )
                |> fun x -> x () |> Some
                ) () ) | None -> None
                |> fun x -> _v173.Value <- x
                let v176 : US3 option = _v173.Value 
                let v187 : US3 = US3_1
                let v188 : US3 = v176 |> Option.defaultValue v187 
                let v228 : System.DateTime =
                    match v188 with
                    | US3_1 -> (* None *)
                        let v224 : System.DateTime = System.DateTime.Now
                        v224
                    | US3_0(v192) -> (* Some *)
                        let v193 : System.DateTime = System.DateTime.Now
                        let v196 : (System.DateTime -> int64) = _.Ticks
                        let v197 : int64 = v196 v193
                        let v200 : int64 = v197 - v192
                        let v201 : (int64 -> System.TimeSpan) = System.TimeSpan 
                        let v202 : System.TimeSpan = v201 v200
                        let v205 : (System.TimeSpan -> int32) = _.Hours
                        let v206 : int32 = v205 v202
                        let v209 : (System.TimeSpan -> int32) = _.Minutes
                        let v210 : int32 = v209 v202
                        let v213 : (System.TimeSpan -> int32) = _.Seconds
                        let v214 : int32 = v213 v202
                        let v217 : (System.TimeSpan -> int32) = _.Milliseconds
                        let v218 : int32 = v217 v202
                        let v221 : System.DateTime = System.DateTime (1, 1, 1, v206, v210, v214, v218)
                        v221
                let v229 : string = method9()
                let v232 : (string -> string) = v228.ToString
                let v233 : string = v232 v229
                let _v109 = v233 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v236 : string = $"near_sdk::env::block_timestamp()"
                let v237 : uint64 = Fable.Core.RustInterop.emitRustExpr () v236 
                let v238 : US3 option = None
                let _v238 = ref v238 
                match v98 with
                | Some x -> (
                (fun () ->
                (fun () ->
                let v239 : int64 = x
                let v240 : US3 = US3_0(v239)
                v240 
                )
                |> fun x -> x () |> Some
                ) () ) | None -> None
                |> fun x -> _v238.Value <- x
                let v241 : US3 option = _v238.Value 
                let v252 : US3 = US3_1
                let v253 : US3 = v241 |> Option.defaultValue v252 
                let v262 : uint64 =
                    match v253 with
                    | US3_1 -> (* None *)
                        v237
                    | US3_0(v257) -> (* Some *)
                        let v258 : (int64 -> uint64) = uint64
                        let v259 : uint64 = v258 v257
                        let v260 : uint64 = v237 - v259
                        v260
                let v263 : uint64 = v262 / 1000000000UL
                let v264 : uint64 = v263 % 60UL
                let v265 : uint64 = v263 / 60UL
                let v266 : uint64 = v265 % 60UL
                let v267 : uint64 = v263 / 3600UL
                let v268 : uint64 = v267 % 24UL
                let v269 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
                let v270 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v268, v266, v264) v269 
                let v271 : string = "fable_library_rust::String_::fromString($0)"
                let v272 : string = Fable.Core.RustInterop.emitRustExpr v270 v271 
                let _v109 = v272 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v273 : US3 option = None
                let _v273 = ref v273 
                match v98 with
                | Some x -> (
                (fun () ->
                (fun () ->
                let v274 : int64 = x
                let v275 : US3 = US3_0(v274)
                v275 
                )
                |> fun x -> x () |> Some
                ) () ) | None -> None
                |> fun x -> _v273.Value <- x
                let v276 : US3 option = _v273.Value 
                let v287 : US3 = US3_1
                let v288 : US3 = v276 |> Option.defaultValue v287 
                let v328 : System.DateTime =
                    match v288 with
                    | US3_1 -> (* None *)
                        let v324 : System.DateTime = System.DateTime.Now
                        v324
                    | US3_0(v292) -> (* Some *)
                        let v293 : System.DateTime = System.DateTime.Now
                        let v296 : (System.DateTime -> int64) = _.Ticks
                        let v297 : int64 = v296 v293
                        let v300 : int64 = v297 - v292
                        let v301 : (int64 -> System.TimeSpan) = System.TimeSpan 
                        let v302 : System.TimeSpan = v301 v300
                        let v305 : (System.TimeSpan -> int32) = _.Hours
                        let v306 : int32 = v305 v302
                        let v309 : (System.TimeSpan -> int32) = _.Minutes
                        let v310 : int32 = v309 v302
                        let v313 : (System.TimeSpan -> int32) = _.Seconds
                        let v314 : int32 = v313 v302
                        let v317 : (System.TimeSpan -> int32) = _.Milliseconds
                        let v318 : int32 = v317 v302
                        let v321 : System.DateTime = System.DateTime (1, 1, 1, v306, v310, v314, v318)
                        v321
                let v329 : string = method10()
                let v332 : (string -> string) = v328.ToString
                let v333 : string = v332 v329
                let _v109 = v333 
                #endif
#if FABLE_COMPILER_PYTHON
                let v336 : US3 option = None
                let _v336 = ref v336 
                match v98 with
                | Some x -> (
                (fun () ->
                (fun () ->
                let v337 : int64 = x
                let v338 : US3 = US3_0(v337)
                v338 
                )
                |> fun x -> x () |> Some
                ) () ) | None -> None
                |> fun x -> _v336.Value <- x
                let v339 : US3 option = _v336.Value 
                let v350 : US3 = US3_1
                let v351 : US3 = v339 |> Option.defaultValue v350 
                let v391 : System.DateTime =
                    match v351 with
                    | US3_1 -> (* None *)
                        let v387 : System.DateTime = System.DateTime.Now
                        v387
                    | US3_0(v355) -> (* Some *)
                        let v356 : System.DateTime = System.DateTime.Now
                        let v359 : (System.DateTime -> int64) = _.Ticks
                        let v360 : int64 = v359 v356
                        let v363 : int64 = v360 - v355
                        let v364 : (int64 -> System.TimeSpan) = System.TimeSpan 
                        let v365 : System.TimeSpan = v364 v363
                        let v368 : (System.TimeSpan -> int32) = _.Hours
                        let v369 : int32 = v368 v365
                        let v372 : (System.TimeSpan -> int32) = _.Minutes
                        let v373 : int32 = v372 v365
                        let v376 : (System.TimeSpan -> int32) = _.Seconds
                        let v377 : int32 = v376 v365
                        let v380 : (System.TimeSpan -> int32) = _.Milliseconds
                        let v381 : int32 = v380 v365
                        let v384 : System.DateTime = System.DateTime (1, 1, 1, v369, v373, v377, v381)
                        v384
                let v392 : string = method10()
                let v395 : (string -> string) = v391.ToString
                let v396 : string = v395 v392
                let _v109 = v396 
                #endif
#else
                let v399 : US3 option = None
                let _v399 = ref v399 
                match v98 with
                | Some x -> (
                (fun () ->
                (fun () ->
                let v400 : int64 = x
                let v401 : US3 = US3_0(v400)
                v401 
                )
                |> fun x -> x () |> Some
                ) () ) | None -> None
                |> fun x -> _v399.Value <- x
                let v402 : US3 option = _v399.Value 
                let v413 : US3 = US3_1
                let v414 : US3 = v402 |> Option.defaultValue v413 
                let v454 : System.DateTime =
                    match v414 with
                    | US3_1 -> (* None *)
                        let v450 : System.DateTime = System.DateTime.Now
                        v450
                    | US3_0(v418) -> (* Some *)
                        let v419 : System.DateTime = System.DateTime.Now
                        let v422 : (System.DateTime -> int64) = _.Ticks
                        let v423 : int64 = v422 v419
                        let v426 : int64 = v423 - v418
                        let v427 : (int64 -> System.TimeSpan) = System.TimeSpan 
                        let v428 : System.TimeSpan = v427 v426
                        let v431 : (System.TimeSpan -> int32) = _.Hours
                        let v432 : int32 = v431 v428
                        let v435 : (System.TimeSpan -> int32) = _.Minutes
                        let v436 : int32 = v435 v428
                        let v439 : (System.TimeSpan -> int32) = _.Seconds
                        let v440 : int32 = v439 v428
                        let v443 : (System.TimeSpan -> int32) = _.Milliseconds
                        let v444 : int32 = v443 v428
                        let v447 : System.DateTime = System.DateTime (1, 1, 1, v432, v436, v440, v444)
                        v447
                let v455 : string = method10()
                let v458 : (string -> string) = v454.ToString
                let v459 : string = v458 v455
                let _v109 = v459 
                #endif
                let v462 : string = _v109 
                let v527 : string = "Warning"
                let v528 : (unit -> string) = v527.ToLower
                let v529 : string = v528 ()
                let v532 : string = v529.PadLeft (7, ' ')
                let v546 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v547 : string = "inline_colorization::color_yellow"
                let v548 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v547 
                let v549 : string = "&*$0"
                let v550 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v532 v549 
                let v551 : string = "inline_colorization::color_reset"
                let v552 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v551 
                let v553 : string = "\"{v548}{v550}{v552}\""
                let v554 : string = @$"format!(" + v553 + ")"
                let v555 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v554 
                let v556 : string = "fable_library_rust::String_::fromString($0)"
                let v557 : string = Fable.Core.RustInterop.emitRustExpr v555 v556 
                let _v546 = v557 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v558 : string = "inline_colorization::color_yellow"
                let v559 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v558 
                let v560 : string = "&*$0"
                let v561 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v532 v560 
                let v562 : string = "inline_colorization::color_reset"
                let v563 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v562 
                let v564 : string = "\"{v559}{v561}{v563}\""
                let v565 : string = @$"format!(" + v564 + ")"
                let v566 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v565 
                let v567 : string = "fable_library_rust::String_::fromString($0)"
                let v568 : string = Fable.Core.RustInterop.emitRustExpr v566 v567 
                let _v546 = v568 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v569 : string = "inline_colorization::color_yellow"
                let v570 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v569 
                let v571 : string = "&*$0"
                let v572 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v532 v571 
                let v573 : string = "inline_colorization::color_reset"
                let v574 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v573 
                let v575 : string = "\"{v570}{v572}{v574}\""
                let v576 : string = @$"format!(" + v575 + ")"
                let v577 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v576 
                let v578 : string = "fable_library_rust::String_::fromString($0)"
                let v579 : string = Fable.Core.RustInterop.emitRustExpr v577 v578 
                let _v546 = v579 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v580 : string = "\u001b[93m"
                let v581 : string = method11()
                let v582 : string = v580 + v532 
                let v583 : string = v582 + v581 
                let _v546 = v583 
                #endif
#if FABLE_COMPILER_PYTHON
                let v584 : string = "\u001b[93m"
                let v585 : string = method11()
                let v586 : string = v584 + v532 
                let v587 : string = v586 + v585 
                let _v546 = v587 
                #endif
#else
                let v588 : string = "\u001b[93m"
                let v589 : string = method11()
                let v590 : string = v588 + v532 
                let v591 : string = v590 + v589 
                let _v546 = v591 
                #endif
                let v592 : string = _v546 
                let v598 : int64 = v94.l0
                let v599 : string = method13()
                let v600 : Mut4 = {l0 = v599} : Mut4
                let v601 : string = "{ "
                let v602 : string = $"{v601}"
                let v605 : string = v600.l0
                let v606 : string = v605 + v602 
                v600.l0 <- v606
                let v607 : string = "error"
                let v608 : string = $"{v607}"
                let v611 : string = v600.l0
                let v612 : string = v611 + v608 
                v600.l0 <- v612
                let v613 : string = " = "
                let v614 : string = $"{v613}"
                let v617 : string = v600.l0
                let v618 : string = v617 + v614 
                v600.l0 <- v618
                let v619 : string = $"{v19}"
                let v622 : string = v600.l0
                let v623 : string = v622 + v619 
                v600.l0 <- v623
                let v624 : string = " }"
                let v625 : string = $"{v624}"
                let v628 : string = v600.l0
                let v629 : string = v628 + v625 
                v600.l0 <- v629
                let v630 : string = v600.l0
                let v631 : (unit -> string) = closure41()
                let v632 : string = $"{v462} {v592} #{v598} %s{v631 ()} / {v630}"
                let v635 : char list = []
                let v636 : (char list -> (char [])) = List.toArray
                let v637 : (char []) = v636 v635
                let v640 : string = v632.TrimStart v637 
                let v658 : char list = []
                let v659 : char list = '/' :: v658 
                let v662 : char list = ' ' :: v659 
                let v665 : (char list -> (char [])) = List.toArray
                let v666 : (char []) = v665 v662
                let v669 : string = v640.TrimEnd v666 
                let v687 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v688 : string = @"println!(""{}"", $0)"
                Fable.Core.RustInterop.emitRustExpr v669 v688 
                let _v687 = () 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v689 : string = @"println!(""{}"", $0)"
                Fable.Core.RustInterop.emitRustExpr v669 v689 
                let _v687 = () 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v690 : string = $"near_sdk::log!(\"{{}}\", $0)"
                Fable.Core.RustInterop.emitRustExpr v669 v690 
                let _v687 = () 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                System.Console.WriteLine v669 
                let _v687 = () 
                #endif
#if FABLE_COMPILER_PYTHON
                System.Console.WriteLine v669 
                let _v687 = () 
                #endif
#else
                System.Console.WriteLine v669 
                let _v687 = () 
                #endif
                _v687 
                let v691 : (string -> unit) = v33.l0
                v691 v669
            US1_1
        | US13_0(v17) -> (* Ok *)
            US1_0(v17)
    let v1379 : US1 =
        match v694 with
        | US1_1 -> (* None *)
            let v697 : string = method49()
            let v698 : string = method30(v13, v14)
            let v699 : US13 = method45(v698, v697)
            match v699 with
            | US13_1(v702) -> (* Error *)
                let v703 : bool = State.trace_state.IsNone
                if v703 then
                    let v704 : US0 = US0_0
                    let struct (v705 : Mut0, v706 : Mut1, v707 : Mut2, v708 : Mut3, v709 : int64 option) = method0(v704)
                    let v710 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v705, v706, v707, v708, v709) 
                    State.trace_state <- v710 
                    ()
                let struct (v715 : Mut0, v716 : Mut1, v717 : Mut2, v718 : Mut3, v719 : int64 option) = State.trace_state.Value
                let v730 : bool = State.trace_state.IsNone
                if v730 then
                    let v731 : US0 = US0_0
                    let struct (v732 : Mut0, v733 : Mut1, v734 : Mut2, v735 : Mut3, v736 : int64 option) = method0(v731)
                    let v737 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v732, v733, v734, v735, v736) 
                    State.trace_state <- v737 
                    ()
                let struct (v742 : Mut0, v743 : Mut1, v744 : Mut2, v745 : Mut3, v746 : int64 option) = State.trace_state.Value
                let v757 : US0 = v745.l0
                let v758 : bool = v744.l0
                let v759 : bool = v758 = false
                let v762 : bool =
                    if v759 then
                        false
                    else
                        let v760 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v757
                        let v761 : bool = 3 >= v760
                        v761
                if v762 then
                    let v763 : int64 = v715.l0
                    let v764 : int64 = v763 + 1L
                    v715.l0 <- v764
                    let v765 : bool = State.trace_state.IsNone
                    if v765 then
                        let v766 : US0 = US0_0
                        let struct (v767 : Mut0, v768 : Mut1, v769 : Mut2, v770 : Mut3, v771 : int64 option) = method0(v766)
                        let v772 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v767, v768, v769, v770, v771) 
                        State.trace_state <- v772 
                        ()
                    let struct (v777 : Mut0, v778 : Mut1, v779 : Mut2, v780 : Mut3, v781 : int64 option) = State.trace_state.Value
                    let v792 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v793 : US3 option = None
                    let _v793 = ref v793 
                    match v781 with
                    | Some x -> (
                    (fun () ->
                    (fun () ->
                    let v794 : int64 = x
                    let v795 : US3 = US3_0(v794)
                    v795 
                    )
                    |> fun x -> x () |> Some
                    ) () ) | None -> None
                    |> fun x -> _v793.Value <- x
                    let v796 : US3 option = _v793.Value 
                    let v807 : US3 = US3_1
                    let v808 : US3 = v796 |> Option.defaultValue v807 
                    let v848 : System.DateTime =
                        match v808 with
                        | US3_1 -> (* None *)
                            let v844 : System.DateTime = System.DateTime.Now
                            v844
                        | US3_0(v812) -> (* Some *)
                            let v813 : System.DateTime = System.DateTime.Now
                            let v816 : (System.DateTime -> int64) = _.Ticks
                            let v817 : int64 = v816 v813
                            let v820 : int64 = v817 - v812
                            let v821 : (int64 -> System.TimeSpan) = System.TimeSpan 
                            let v822 : System.TimeSpan = v821 v820
                            let v825 : (System.TimeSpan -> int32) = _.Hours
                            let v826 : int32 = v825 v822
                            let v829 : (System.TimeSpan -> int32) = _.Minutes
                            let v830 : int32 = v829 v822
                            let v833 : (System.TimeSpan -> int32) = _.Seconds
                            let v834 : int32 = v833 v822
                            let v837 : (System.TimeSpan -> int32) = _.Milliseconds
                            let v838 : int32 = v837 v822
                            let v841 : System.DateTime = System.DateTime (1, 1, 1, v826, v830, v834, v838)
                            v841
                    let v849 : string = method9()
                    let v852 : (string -> string) = v848.ToString
                    let v853 : string = v852 v849
                    let _v792 = v853 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v856 : US3 option = None
                    let _v856 = ref v856 
                    match v781 with
                    | Some x -> (
                    (fun () ->
                    (fun () ->
                    let v857 : int64 = x
                    let v858 : US3 = US3_0(v857)
                    v858 
                    )
                    |> fun x -> x () |> Some
                    ) () ) | None -> None
                    |> fun x -> _v856.Value <- x
                    let v859 : US3 option = _v856.Value 
                    let v870 : US3 = US3_1
                    let v871 : US3 = v859 |> Option.defaultValue v870 
                    let v911 : System.DateTime =
                        match v871 with
                        | US3_1 -> (* None *)
                            let v907 : System.DateTime = System.DateTime.Now
                            v907
                        | US3_0(v875) -> (* Some *)
                            let v876 : System.DateTime = System.DateTime.Now
                            let v879 : (System.DateTime -> int64) = _.Ticks
                            let v880 : int64 = v879 v876
                            let v883 : int64 = v880 - v875
                            let v884 : (int64 -> System.TimeSpan) = System.TimeSpan 
                            let v885 : System.TimeSpan = v884 v883
                            let v888 : (System.TimeSpan -> int32) = _.Hours
                            let v889 : int32 = v888 v885
                            let v892 : (System.TimeSpan -> int32) = _.Minutes
                            let v893 : int32 = v892 v885
                            let v896 : (System.TimeSpan -> int32) = _.Seconds
                            let v897 : int32 = v896 v885
                            let v900 : (System.TimeSpan -> int32) = _.Milliseconds
                            let v901 : int32 = v900 v885
                            let v904 : System.DateTime = System.DateTime (1, 1, 1, v889, v893, v897, v901)
                            v904
                    let v912 : string = method9()
                    let v915 : (string -> string) = v911.ToString
                    let v916 : string = v915 v912
                    let _v792 = v916 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v919 : string = $"near_sdk::env::block_timestamp()"
                    let v920 : uint64 = Fable.Core.RustInterop.emitRustExpr () v919 
                    let v921 : US3 option = None
                    let _v921 = ref v921 
                    match v781 with
                    | Some x -> (
                    (fun () ->
                    (fun () ->
                    let v922 : int64 = x
                    let v923 : US3 = US3_0(v922)
                    v923 
                    )
                    |> fun x -> x () |> Some
                    ) () ) | None -> None
                    |> fun x -> _v921.Value <- x
                    let v924 : US3 option = _v921.Value 
                    let v935 : US3 = US3_1
                    let v936 : US3 = v924 |> Option.defaultValue v935 
                    let v945 : uint64 =
                        match v936 with
                        | US3_1 -> (* None *)
                            v920
                        | US3_0(v940) -> (* Some *)
                            let v941 : (int64 -> uint64) = uint64
                            let v942 : uint64 = v941 v940
                            let v943 : uint64 = v920 - v942
                            v943
                    let v946 : uint64 = v945 / 1000000000UL
                    let v947 : uint64 = v946 % 60UL
                    let v948 : uint64 = v946 / 60UL
                    let v949 : uint64 = v948 % 60UL
                    let v950 : uint64 = v946 / 3600UL
                    let v951 : uint64 = v950 % 24UL
                    let v952 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
                    let v953 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v951, v949, v947) v952 
                    let v954 : string = "fable_library_rust::String_::fromString($0)"
                    let v955 : string = Fable.Core.RustInterop.emitRustExpr v953 v954 
                    let _v792 = v955 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v956 : US3 option = None
                    let _v956 = ref v956 
                    match v781 with
                    | Some x -> (
                    (fun () ->
                    (fun () ->
                    let v957 : int64 = x
                    let v958 : US3 = US3_0(v957)
                    v958 
                    )
                    |> fun x -> x () |> Some
                    ) () ) | None -> None
                    |> fun x -> _v956.Value <- x
                    let v959 : US3 option = _v956.Value 
                    let v970 : US3 = US3_1
                    let v971 : US3 = v959 |> Option.defaultValue v970 
                    let v1011 : System.DateTime =
                        match v971 with
                        | US3_1 -> (* None *)
                            let v1007 : System.DateTime = System.DateTime.Now
                            v1007
                        | US3_0(v975) -> (* Some *)
                            let v976 : System.DateTime = System.DateTime.Now
                            let v979 : (System.DateTime -> int64) = _.Ticks
                            let v980 : int64 = v979 v976
                            let v983 : int64 = v980 - v975
                            let v984 : (int64 -> System.TimeSpan) = System.TimeSpan 
                            let v985 : System.TimeSpan = v984 v983
                            let v988 : (System.TimeSpan -> int32) = _.Hours
                            let v989 : int32 = v988 v985
                            let v992 : (System.TimeSpan -> int32) = _.Minutes
                            let v993 : int32 = v992 v985
                            let v996 : (System.TimeSpan -> int32) = _.Seconds
                            let v997 : int32 = v996 v985
                            let v1000 : (System.TimeSpan -> int32) = _.Milliseconds
                            let v1001 : int32 = v1000 v985
                            let v1004 : System.DateTime = System.DateTime (1, 1, 1, v989, v993, v997, v1001)
                            v1004
                    let v1012 : string = method10()
                    let v1015 : (string -> string) = v1011.ToString
                    let v1016 : string = v1015 v1012
                    let _v792 = v1016 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v1019 : US3 option = None
                    let _v1019 = ref v1019 
                    match v781 with
                    | Some x -> (
                    (fun () ->
                    (fun () ->
                    let v1020 : int64 = x
                    let v1021 : US3 = US3_0(v1020)
                    v1021 
                    )
                    |> fun x -> x () |> Some
                    ) () ) | None -> None
                    |> fun x -> _v1019.Value <- x
                    let v1022 : US3 option = _v1019.Value 
                    let v1033 : US3 = US3_1
                    let v1034 : US3 = v1022 |> Option.defaultValue v1033 
                    let v1074 : System.DateTime =
                        match v1034 with
                        | US3_1 -> (* None *)
                            let v1070 : System.DateTime = System.DateTime.Now
                            v1070
                        | US3_0(v1038) -> (* Some *)
                            let v1039 : System.DateTime = System.DateTime.Now
                            let v1042 : (System.DateTime -> int64) = _.Ticks
                            let v1043 : int64 = v1042 v1039
                            let v1046 : int64 = v1043 - v1038
                            let v1047 : (int64 -> System.TimeSpan) = System.TimeSpan 
                            let v1048 : System.TimeSpan = v1047 v1046
                            let v1051 : (System.TimeSpan -> int32) = _.Hours
                            let v1052 : int32 = v1051 v1048
                            let v1055 : (System.TimeSpan -> int32) = _.Minutes
                            let v1056 : int32 = v1055 v1048
                            let v1059 : (System.TimeSpan -> int32) = _.Seconds
                            let v1060 : int32 = v1059 v1048
                            let v1063 : (System.TimeSpan -> int32) = _.Milliseconds
                            let v1064 : int32 = v1063 v1048
                            let v1067 : System.DateTime = System.DateTime (1, 1, 1, v1052, v1056, v1060, v1064)
                            v1067
                    let v1075 : string = method10()
                    let v1078 : (string -> string) = v1074.ToString
                    let v1079 : string = v1078 v1075
                    let _v792 = v1079 
                    #endif
#else
                    let v1082 : US3 option = None
                    let _v1082 = ref v1082 
                    match v781 with
                    | Some x -> (
                    (fun () ->
                    (fun () ->
                    let v1083 : int64 = x
                    let v1084 : US3 = US3_0(v1083)
                    v1084 
                    )
                    |> fun x -> x () |> Some
                    ) () ) | None -> None
                    |> fun x -> _v1082.Value <- x
                    let v1085 : US3 option = _v1082.Value 
                    let v1096 : US3 = US3_1
                    let v1097 : US3 = v1085 |> Option.defaultValue v1096 
                    let v1137 : System.DateTime =
                        match v1097 with
                        | US3_1 -> (* None *)
                            let v1133 : System.DateTime = System.DateTime.Now
                            v1133
                        | US3_0(v1101) -> (* Some *)
                            let v1102 : System.DateTime = System.DateTime.Now
                            let v1105 : (System.DateTime -> int64) = _.Ticks
                            let v1106 : int64 = v1105 v1102
                            let v1109 : int64 = v1106 - v1101
                            let v1110 : (int64 -> System.TimeSpan) = System.TimeSpan 
                            let v1111 : System.TimeSpan = v1110 v1109
                            let v1114 : (System.TimeSpan -> int32) = _.Hours
                            let v1115 : int32 = v1114 v1111
                            let v1118 : (System.TimeSpan -> int32) = _.Minutes
                            let v1119 : int32 = v1118 v1111
                            let v1122 : (System.TimeSpan -> int32) = _.Seconds
                            let v1123 : int32 = v1122 v1111
                            let v1126 : (System.TimeSpan -> int32) = _.Milliseconds
                            let v1127 : int32 = v1126 v1111
                            let v1130 : System.DateTime = System.DateTime (1, 1, 1, v1115, v1119, v1123, v1127)
                            v1130
                    let v1138 : string = method10()
                    let v1141 : (string -> string) = v1137.ToString
                    let v1142 : string = v1141 v1138
                    let _v792 = v1142 
                    #endif
                    let v1145 : string = _v792 
                    let v1210 : string = "Warning"
                    let v1211 : (unit -> string) = v1210.ToLower
                    let v1212 : string = v1211 ()
                    let v1215 : string = v1212.PadLeft (7, ' ')
                    let v1229 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1230 : string = "inline_colorization::color_yellow"
                    let v1231 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1230 
                    let v1232 : string = "&*$0"
                    let v1233 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1215 v1232 
                    let v1234 : string = "inline_colorization::color_reset"
                    let v1235 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1234 
                    let v1236 : string = "\"{v1231}{v1233}{v1235}\""
                    let v1237 : string = @$"format!(" + v1236 + ")"
                    let v1238 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v1237 
                    let v1239 : string = "fable_library_rust::String_::fromString($0)"
                    let v1240 : string = Fable.Core.RustInterop.emitRustExpr v1238 v1239 
                    let _v1229 = v1240 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v1241 : string = "inline_colorization::color_yellow"
                    let v1242 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1241 
                    let v1243 : string = "&*$0"
                    let v1244 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1215 v1243 
                    let v1245 : string = "inline_colorization::color_reset"
                    let v1246 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1245 
                    let v1247 : string = "\"{v1242}{v1244}{v1246}\""
                    let v1248 : string = @$"format!(" + v1247 + ")"
                    let v1249 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v1248 
                    let v1250 : string = "fable_library_rust::String_::fromString($0)"
                    let v1251 : string = Fable.Core.RustInterop.emitRustExpr v1249 v1250 
                    let _v1229 = v1251 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1252 : string = "inline_colorization::color_yellow"
                    let v1253 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1252 
                    let v1254 : string = "&*$0"
                    let v1255 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1215 v1254 
                    let v1256 : string = "inline_colorization::color_reset"
                    let v1257 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1256 
                    let v1258 : string = "\"{v1253}{v1255}{v1257}\""
                    let v1259 : string = @$"format!(" + v1258 + ")"
                    let v1260 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v1259 
                    let v1261 : string = "fable_library_rust::String_::fromString($0)"
                    let v1262 : string = Fable.Core.RustInterop.emitRustExpr v1260 v1261 
                    let _v1229 = v1262 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v1263 : string = "\u001b[93m"
                    let v1264 : string = method11()
                    let v1265 : string = v1263 + v1215 
                    let v1266 : string = v1265 + v1264 
                    let _v1229 = v1266 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v1267 : string = "\u001b[93m"
                    let v1268 : string = method11()
                    let v1269 : string = v1267 + v1215 
                    let v1270 : string = v1269 + v1268 
                    let _v1229 = v1270 
                    #endif
#else
                    let v1271 : string = "\u001b[93m"
                    let v1272 : string = method11()
                    let v1273 : string = v1271 + v1215 
                    let v1274 : string = v1273 + v1272 
                    let _v1229 = v1274 
                    #endif
                    let v1275 : string = _v1229 
                    let v1281 : int64 = v777.l0
                    let v1282 : string = method13()
                    let v1283 : Mut4 = {l0 = v1282} : Mut4
                    let v1284 : string = "{ "
                    let v1285 : string = $"{v1284}"
                    let v1288 : string = v1283.l0
                    let v1289 : string = v1288 + v1285 
                    v1283.l0 <- v1289
                    let v1290 : string = "error"
                    let v1291 : string = $"{v1290}"
                    let v1294 : string = v1283.l0
                    let v1295 : string = v1294 + v1291 
                    v1283.l0 <- v1295
                    let v1296 : string = " = "
                    let v1297 : string = $"{v1296}"
                    let v1300 : string = v1283.l0
                    let v1301 : string = v1300 + v1297 
                    v1283.l0 <- v1301
                    let v1302 : string = $"{v702}"
                    let v1305 : string = v1283.l0
                    let v1306 : string = v1305 + v1302 
                    v1283.l0 <- v1306
                    let v1307 : string = " }"
                    let v1308 : string = $"{v1307}"
                    let v1311 : string = v1283.l0
                    let v1312 : string = v1311 + v1308 
                    v1283.l0 <- v1312
                    let v1313 : string = v1283.l0
                    let v1314 : (unit -> string) = closure41()
                    let v1315 : string = $"{v1145} {v1275} #{v1281} %s{v1314 ()} / {v1313}"
                    let v1318 : char list = []
                    let v1319 : (char list -> (char [])) = List.toArray
                    let v1320 : (char []) = v1319 v1318
                    let v1323 : string = v1315.TrimStart v1320 
                    let v1341 : char list = []
                    let v1342 : char list = '/' :: v1341 
                    let v1345 : char list = ' ' :: v1342 
                    let v1348 : (char list -> (char [])) = List.toArray
                    let v1349 : (char []) = v1348 v1345
                    let v1352 : string = v1323.TrimEnd v1349 
                    let v1370 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1371 : string = @"println!(""{}"", $0)"
                    Fable.Core.RustInterop.emitRustExpr v1352 v1371 
                    let _v1370 = () 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v1372 : string = @"println!(""{}"", $0)"
                    Fable.Core.RustInterop.emitRustExpr v1352 v1372 
                    let _v1370 = () 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1373 : string = $"near_sdk::log!(\"{{}}\", $0)"
                    Fable.Core.RustInterop.emitRustExpr v1352 v1373 
                    let _v1370 = () 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    System.Console.WriteLine v1352 
                    let _v1370 = () 
                    #endif
#if FABLE_COMPILER_PYTHON
                    System.Console.WriteLine v1352 
                    let _v1370 = () 
                    #endif
#else
                    System.Console.WriteLine v1352 
                    let _v1370 = () 
                    #endif
                    _v1370 
                    let v1374 : (string -> unit) = v716.l0
                    v1374 v1352
                US1_1
            | US13_0(v700) -> (* Ok *)
                US1_0(v700)
        | US1_0(v695) -> (* Some *)
            US1_0(v695)
    let v1383 : string =
        match v1379 with
        | US1_1 -> (* None *)
            failwith<string> "Option does not have a value."
        | US1_0(v1380) -> (* Some *)
            v1380
    let v1384 : string = method30(v1383, v13)
    let v1385 : string = "target/trace"
    let v1386 : string = method30(v1384, v1385)
    let v1387 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1388 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    let _v1387 = v1388 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1391 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    let _v1387 = v1391 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1394 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    let _v1387 = v1394 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1397 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    let _v1387 = v1397 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1400 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    let _v1387 = v1400 
    #endif
#else
    let v1403 : (string -> System.IO.DirectoryInfo) = System.IO.Directory.CreateDirectory
    let v1404 : System.IO.DirectoryInfo = v1403 v1386
    let _v1387 = v1404 
    #endif
    let v1405 : System.IO.DirectoryInfo = _v1387 
    let v1410 : string = method30(v1386, v11)
    let v1411 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1412 : Async<unit> = null |> unbox<Async<unit>>
    let _v1411 = v1412 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1415 : Async<unit> = null |> unbox<Async<unit>>
    let _v1411 = v1415 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1418 : Async<unit> = null |> unbox<Async<unit>>
    let _v1411 = v1418 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1421 : Async<unit> = null |> unbox<Async<unit>>
    let _v1411 = v1421 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1424 : Async<unit> = null |> unbox<Async<unit>>
    let _v1411 = v1424 
    #endif
#else
    let v1427 : System.Threading.Tasks.Task = System.IO.File.WriteAllTextAsync (v1410, v0)
    let v1428 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1429 : Async<unit> = null |> unbox<Async<unit>>
    let _v1428 = v1429 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1432 : Async<unit> = null |> unbox<Async<unit>>
    let _v1428 = v1432 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1435 : Async<unit> = null |> unbox<Async<unit>>
    let _v1428 = v1435 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1438 : Async<unit> = null |> unbox<Async<unit>>
    let _v1428 = v1438 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1441 : Async<unit> = null |> unbox<Async<unit>>
    let _v1428 = v1441 
    #endif
#else
    let v1444 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
    let v1445 : Async<unit> = v1444 v1427
    let _v1428 = v1445 
    #endif
    let v1446 : Async<unit> = _v1428 
    let _v1411 = v1446 
    #endif
    let v1451 : Async<unit> = _v1411 
    let v1456 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    null |> unbox<unit>
    let _v1456 = () 
    #endif
#if FABLE_COMPILER_RUST && WASM
    null |> unbox<unit>
    let _v1456 = () 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    null |> unbox<unit>
    let _v1456 = () 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    null |> unbox<unit>
    let _v1456 = () 
    #endif
#if FABLE_COMPILER_PYTHON
    null |> unbox<unit>
    let _v1456 = () 
    #endif
#else
    let v1457 : (Async<unit> -> unit) = Async.RunSynchronously
    v1457 v1451
    let _v1456 = () 
    #endif
    _v1456 
    with ex ->
    let v1458 : exn = ex
    let v1459 : string = $"file_system.trace_file / ex: %A{v1458}"
    method50(v1459)
    (*
    *)
    let _v1 = () 
    #endif
    _v1 
    ()
and closure43 () (v0 : string) : unit =
    method50(v0)
and closure42 () (v0 : bool) : unit =
    let v1 : bool = State.trace_state.IsNone
    if v1 then
        let v2 : US0 = US0_0
        let struct (v3 : Mut0, v4 : Mut1, v5 : Mut2, v6 : Mut3, v7 : int64 option) = method0(v2)
        let v8 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v3, v4, v5, v6, v7) 
        State.trace_state <- v8 
        ()
    let struct (v13 : Mut0, v14 : Mut1, v15 : Mut2, v16 : Mut3, v17 : int64 option) = State.trace_state.Value
    let v30 : (string -> unit) =
        if v0 then
            closure43()
        else
            closure0()
    v14.l0 <- v30
    ()
and closure45 (v0 : string) (v1 : string) : string =
    method30(v0, v1)
and closure44 () (v0 : string) : (string -> string) =
    closure45(v0)
let v0 : bool = State.trace_state.IsNone
if v0 then
    let v1 : US0 = US0_0
    let struct (v2 : Mut0, v3 : Mut1, v4 : Mut2, v5 : Mut3, v6 : int64 option) = method0(v1)
    let v7 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v2, v3, v4, v5, v6) 
    State.trace_state <- v7 
    ()
let v12 : (string -> Async<int64>) = closure1()
let delete_directory_async x = v12 x
let v13 : (US6 -> (string -> Async<int64>)) = closure3()
let wait_for_file_access x = v13 x
let v14 : (string -> Async<int64>) = closure6()
let wait_for_file_access_read x = v14 x
let v15 : (string -> Async<string>) = closure7()
let read_all_text_async x = v15 x
let v16 : (string -> (string -> bool)) = closure8()
let file_exists_content x = v16 x
let v17 : (string -> (string -> Async<unit>)) = closure10()
let write_all_text_async x = v17 x
let v18 : (string -> (string -> Async<unit>)) = closure12()
let write_all_text_exists x = v18 x
let v19 : (string -> Async<int64>) = closure14()
let delete_file_async x = v19 x
let v20 : (string -> (string -> Async<int64>)) = closure16()
let move_file_async x = v20 x
let v21 : (string -> Async<string option>) = closure19()
let read_all_text_retry_async x = v21 x
let v22 : (unit -> string) = closure25()
let create_temp_path () = v22 ()
let v23 : (unit -> struct (string * System.IDisposable)) = closure26()
let create_temp_dir () = v23 ()
let v24 : (string -> struct (string * System.IDisposable)) = closure35()
let create_temp_dir' x = v24 x
let v25 : (unit -> string) = closure36()
let get_source_directory () = v25 ()
let v26 : (string -> string) = closure37()
let normalize_path x = v26 x
let v27 : (string -> string) = closure38()
let new_file_uri x = v27 x
let v28 : (unit -> string) = closure39()
let get_workspace_root () = v28 ()
let v29 : (bool -> unit) = closure42()
let init_trace_file x = v29 x
let v30 : (string -> (string -> string)) = closure44()
let (</>) x = v30 x
()
