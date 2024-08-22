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
and Mut4 = {mutable l0 : string}
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
    let v365 : (string -> unit) = closure3()
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
and closure0 () () : unit =
    let v0 : bool = State.trace_state.IsNone
    if v0 then
        let v1 : US0 = US0_0
        let struct (v2 : Mut0, v3 : Mut1, v4 : Mut2, v5 : Mut3, v6 : int64 option) = method0(v1)
        let v7 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v2, v3, v4, v5, v6) 
        State.trace_state <- v7 
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
    let v0 : string = "("
    v0
and method12 () : string =
    let v0 : string = " "
    v0
and method13 () : string =
    let v0 : string = ""
    v0
and closure9 (v0 : Mut4, v1 : string) () : unit =
    let v2 : string = v0.l0
    let v3 : string = v2 + v1 
    v0.l0 <- v3
    ()
and method14 () : string =
    let v0 : string = "\u001b[0m"
    v0
and method15 (v0 : string) : string =
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
and closure10 () () : string =
    let v0 : string = "file_system.delete_directory_async"
    v0
and closure12 (v0 : string) () : unit =
    let v1 : (string -> unit) = System.Console.WriteLine
    v1 v0
and closure11 () (v0 : string) : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure12(v0)
    let v3 : unit = (fun () -> v2 (); v1) ()
    ()
and closure5 (v0 : string, v1 : string) () : unit =
    let v2 : unit = ()
    let v3 : (unit -> unit) = closure0()
    let v4 : unit = (fun () -> v3 (); v2) ()
    let struct (v17 : Mut0, v18 : Mut1, v19 : Mut2, v20 : Mut3, v21 : int64 option) = State.trace_state.Value
    let v32 : unit = ()
    let v33 : unit = (fun () -> v3 (); v32) ()
    let struct (v46 : Mut0, v47 : Mut1, v48 : Mut2, v49 : Mut3, v50 : int64 option) = State.trace_state.Value
    let v61 : US0 = v49.l0
    let v62 : bool = v48.l0
    let v63 : bool = v62 = false
    let v66 : bool =
        if v63 then
            false
        else
            let v64 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v61
            let v65 : bool = 1 >= v64
            v65
    if v66 then
        let v67 : unit = ()
        let v68 : (unit -> unit) = closure6(v17)
        let v69 : unit = (fun () -> v68 (); v67) ()
        let v72 : unit = ()
        let v73 : unit = (fun () -> v3 (); v72) ()
        let struct (v86 : Mut0, v87 : Mut1, v88 : Mut2, v89 : Mut3, v90 : int64 option) = State.trace_state.Value
        let v101 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v102 : US3 option = None
        let _v102 = ref v102 
        let v103 : US3 option ref = _v102 
        let v104 : (US3 option -> US3 option ref) = closure7(v103)
        let v105 : unit = ()
        let v106 : (unit -> unit) = closure8(v90, v104)
        let v107 : unit = (fun () -> v106 (); v105) ()
        let v110 : US3 option = _v102.Value 
        let v121 : US3 = US3_1
        let v122 : US3 = v110 |> Option.defaultValue v121 
        let v162 : System.DateTime =
            match v122 with
            | US3_1 -> (* None *)
                let v158 : System.DateTime = System.DateTime.Now
                v158
            | US3_0(v126) -> (* Some *)
                let v127 : System.DateTime = System.DateTime.Now
                let v130 : (System.DateTime -> int64) = _.Ticks
                let v131 : int64 = v130 v127
                let v134 : int64 = v131 - v126
                let v135 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v136 : System.TimeSpan = v135 v134
                let v139 : (System.TimeSpan -> int32) = _.Hours
                let v140 : int32 = v139 v136
                let v143 : (System.TimeSpan -> int32) = _.Minutes
                let v144 : int32 = v143 v136
                let v147 : (System.TimeSpan -> int32) = _.Seconds
                let v148 : int32 = v147 v136
                let v151 : (System.TimeSpan -> int32) = _.Milliseconds
                let v152 : int32 = v151 v136
                let v155 : System.DateTime = System.DateTime (1, 1, 1, v140, v144, v148, v152)
                v155
        let v163 : string = method9()
        let v166 : (string -> string) = v162.ToString
        let v167 : string = v166 v163
        let _v101 = v167 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v170 : US3 option = None
        let _v170 = ref v170 
        let v171 : US3 option ref = _v170 
        let v172 : (US3 option -> US3 option ref) = closure7(v171)
        let v173 : unit = ()
        let v174 : (unit -> unit) = closure8(v90, v172)
        let v175 : unit = (fun () -> v174 (); v173) ()
        let v178 : US3 option = _v170.Value 
        let v189 : US3 = US3_1
        let v190 : US3 = v178 |> Option.defaultValue v189 
        let v230 : System.DateTime =
            match v190 with
            | US3_1 -> (* None *)
                let v226 : System.DateTime = System.DateTime.Now
                v226
            | US3_0(v194) -> (* Some *)
                let v195 : System.DateTime = System.DateTime.Now
                let v198 : (System.DateTime -> int64) = _.Ticks
                let v199 : int64 = v198 v195
                let v202 : int64 = v199 - v194
                let v203 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v204 : System.TimeSpan = v203 v202
                let v207 : (System.TimeSpan -> int32) = _.Hours
                let v208 : int32 = v207 v204
                let v211 : (System.TimeSpan -> int32) = _.Minutes
                let v212 : int32 = v211 v204
                let v215 : (System.TimeSpan -> int32) = _.Seconds
                let v216 : int32 = v215 v204
                let v219 : (System.TimeSpan -> int32) = _.Milliseconds
                let v220 : int32 = v219 v204
                let v223 : System.DateTime = System.DateTime (1, 1, 1, v208, v212, v216, v220)
                v223
        let v231 : string = method9()
        let v234 : (string -> string) = v230.ToString
        let v235 : string = v234 v231
        let _v101 = v235 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v238 : string = $"near_sdk::env::block_timestamp()"
        let v239 : uint64 = Fable.Core.RustInterop.emitRustExpr () v238 
        let v240 : US3 option = None
        let _v240 = ref v240 
        let v241 : US3 option ref = _v240 
        let v242 : (US3 option -> US3 option ref) = closure7(v241)
        let v243 : unit = ()
        let v244 : (unit -> unit) = closure8(v90, v242)
        let v245 : unit = (fun () -> v244 (); v243) ()
        let v248 : US3 option = _v240.Value 
        let v259 : US3 = US3_1
        let v260 : US3 = v248 |> Option.defaultValue v259 
        let v269 : uint64 =
            match v260 with
            | US3_1 -> (* None *)
                v239
            | US3_0(v264) -> (* Some *)
                let v265 : (int64 -> uint64) = uint64
                let v266 : uint64 = v265 v264
                let v267 : uint64 = v239 - v266
                v267
        let v270 : uint64 = v269 / 1000000000UL
        let v271 : uint64 = v270 % 60UL
        let v272 : uint64 = v270 / 60UL
        let v273 : uint64 = v272 % 60UL
        let v274 : uint64 = v270 / 3600UL
        let v275 : uint64 = v274 % 24UL
        let v276 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
        let v277 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v275, v273, v271) v276 
        let v278 : string = "fable_library_rust::String_::fromString($0)"
        let v279 : string = Fable.Core.RustInterop.emitRustExpr v277 v278 
        let _v101 = v279 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v280 : US3 option = None
        let _v280 = ref v280 
        let v281 : US3 option ref = _v280 
        let v282 : (US3 option -> US3 option ref) = closure7(v281)
        let v283 : unit = ()
        let v284 : (unit -> unit) = closure8(v90, v282)
        let v285 : unit = (fun () -> v284 (); v283) ()
        let v288 : US3 option = _v280.Value 
        let v299 : US3 = US3_1
        let v300 : US3 = v288 |> Option.defaultValue v299 
        let v340 : System.DateTime =
            match v300 with
            | US3_1 -> (* None *)
                let v336 : System.DateTime = System.DateTime.Now
                v336
            | US3_0(v304) -> (* Some *)
                let v305 : System.DateTime = System.DateTime.Now
                let v308 : (System.DateTime -> int64) = _.Ticks
                let v309 : int64 = v308 v305
                let v312 : int64 = v309 - v304
                let v313 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v314 : System.TimeSpan = v313 v312
                let v317 : (System.TimeSpan -> int32) = _.Hours
                let v318 : int32 = v317 v314
                let v321 : (System.TimeSpan -> int32) = _.Minutes
                let v322 : int32 = v321 v314
                let v325 : (System.TimeSpan -> int32) = _.Seconds
                let v326 : int32 = v325 v314
                let v329 : (System.TimeSpan -> int32) = _.Milliseconds
                let v330 : int32 = v329 v314
                let v333 : System.DateTime = System.DateTime (1, 1, 1, v318, v322, v326, v330)
                v333
        let v341 : string = method10()
        let v344 : (string -> string) = v340.ToString
        let v345 : string = v344 v341
        let _v101 = v345 
        #endif
#if FABLE_COMPILER_PYTHON
        let v348 : US3 option = None
        let _v348 = ref v348 
        let v349 : US3 option ref = _v348 
        let v350 : (US3 option -> US3 option ref) = closure7(v349)
        let v351 : unit = ()
        let v352 : (unit -> unit) = closure8(v90, v350)
        let v353 : unit = (fun () -> v352 (); v351) ()
        let v356 : US3 option = _v348.Value 
        let v367 : US3 = US3_1
        let v368 : US3 = v356 |> Option.defaultValue v367 
        let v408 : System.DateTime =
            match v368 with
            | US3_1 -> (* None *)
                let v404 : System.DateTime = System.DateTime.Now
                v404
            | US3_0(v372) -> (* Some *)
                let v373 : System.DateTime = System.DateTime.Now
                let v376 : (System.DateTime -> int64) = _.Ticks
                let v377 : int64 = v376 v373
                let v380 : int64 = v377 - v372
                let v381 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v382 : System.TimeSpan = v381 v380
                let v385 : (System.TimeSpan -> int32) = _.Hours
                let v386 : int32 = v385 v382
                let v389 : (System.TimeSpan -> int32) = _.Minutes
                let v390 : int32 = v389 v382
                let v393 : (System.TimeSpan -> int32) = _.Seconds
                let v394 : int32 = v393 v382
                let v397 : (System.TimeSpan -> int32) = _.Milliseconds
                let v398 : int32 = v397 v382
                let v401 : System.DateTime = System.DateTime (1, 1, 1, v386, v390, v394, v398)
                v401
        let v409 : string = method10()
        let v412 : (string -> string) = v408.ToString
        let v413 : string = v412 v409
        let _v101 = v413 
        #endif
#else
        let v416 : US3 option = None
        let _v416 = ref v416 
        let v417 : US3 option ref = _v416 
        let v418 : (US3 option -> US3 option ref) = closure7(v417)
        let v419 : unit = ()
        let v420 : (unit -> unit) = closure8(v90, v418)
        let v421 : unit = (fun () -> v420 (); v419) ()
        let v424 : US3 option = _v416.Value 
        let v435 : US3 = US3_1
        let v436 : US3 = v424 |> Option.defaultValue v435 
        let v476 : System.DateTime =
            match v436 with
            | US3_1 -> (* None *)
                let v472 : System.DateTime = System.DateTime.Now
                v472
            | US3_0(v440) -> (* Some *)
                let v441 : System.DateTime = System.DateTime.Now
                let v444 : (System.DateTime -> int64) = _.Ticks
                let v445 : int64 = v444 v441
                let v448 : int64 = v445 - v440
                let v449 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v450 : System.TimeSpan = v449 v448
                let v453 : (System.TimeSpan -> int32) = _.Hours
                let v454 : int32 = v453 v450
                let v457 : (System.TimeSpan -> int32) = _.Minutes
                let v458 : int32 = v457 v450
                let v461 : (System.TimeSpan -> int32) = _.Seconds
                let v462 : int32 = v461 v450
                let v465 : (System.TimeSpan -> int32) = _.Milliseconds
                let v466 : int32 = v465 v450
                let v469 : System.DateTime = System.DateTime (1, 1, 1, v454, v458, v462, v466)
                v469
        let v477 : string = method10()
        let v480 : (string -> string) = v476.ToString
        let v481 : string = v480 v477
        let _v101 = v481 
        #endif
        let v484 : string = _v101 
        
        
        
        
        
        let v554 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v555 : string = method11()
        let _v554 = v555 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v556 : string = method11()
        let _v554 = v556 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v557 : string = method11()
        let _v554 = v557 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v558 : string = method12()
        let _v554 = v558 
        #endif
#if FABLE_COMPILER_PYTHON
        let v559 : string = method12()
        let _v554 = v559 
        #endif
#else
        let v560 : string = method12()
        let _v554 = v560 
        #endif
        let v561 : string = _v554 
        let v566 : string = method13()
        let v567 : Mut4 = {l0 = v566} : Mut4
        let v568 : US0 = US0_0
        let v569 : string = $"%A{v568}"
        let v573 : string = $"{v569}"
        let v576 : unit = ()
        let v577 : (unit -> unit) = closure9(v567, v573)
        let v578 : unit = (fun () -> v577 (); v576) ()
        let v581 : string = v567.l0
        let v582 : (string []) = v581.Split v561 
        let v585 : string = v582.[int 0]
        let v588 : string = method13()
        let v589 : Mut4 = {l0 = v588} : Mut4
        let v590 : US0 = US0_1
        let v591 : string = $"%A{v590}"
        let v595 : string = $"{v591}"
        let v598 : unit = ()
        let v599 : (unit -> unit) = closure9(v589, v595)
        let v600 : unit = (fun () -> v599 (); v598) ()
        let v603 : string = v589.l0
        let v604 : bool = v603.StartsWith v585 
        let v610 : US1 =
            if v604 then
                let v607 : string = "Verbose"
                US1_0(v607)
            else
                US1_1
        let v616 : US1 =
            match v610 with
            | US1_1 -> (* None *)
                let v613 : string = "Debug"
                US1_0(v613)
            | US1_0(v611) -> (* Some *)
                US1_0(v611)
        let v620 : string =
            match v616 with
            | US1_1 -> (* None *)
                failwith<string> "Option does not have a value."
            | US1_0(v617) -> (* Some *)
                v617
        let v621 : (unit -> string) = v620.ToLower
        let v622 : string = v621 ()
        let v625 : string = v622.PadLeft (7, ' ')
        let v639 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v640 : string = "inline_colorization::color_bright_blue"
        let v641 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v640 
        let v642 : string = "&*$0"
        let v643 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v625 v642 
        let v644 : string = "inline_colorization::color_reset"
        let v645 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v644 
        let v646 : string = "\"{v641}{v643}{v645}\""
        let v647 : string = @$"format!(" + v646 + ")"
        let v648 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v647 
        let v649 : string = "fable_library_rust::String_::fromString($0)"
        let v650 : string = Fable.Core.RustInterop.emitRustExpr v648 v649 
        let _v639 = v650 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v651 : string = "inline_colorization::color_bright_blue"
        let v652 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v651 
        let v653 : string = "&*$0"
        let v654 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v625 v653 
        let v655 : string = "inline_colorization::color_reset"
        let v656 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v655 
        let v657 : string = "\"{v652}{v654}{v656}\""
        let v658 : string = @$"format!(" + v657 + ")"
        let v659 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v658 
        let v660 : string = "fable_library_rust::String_::fromString($0)"
        let v661 : string = Fable.Core.RustInterop.emitRustExpr v659 v660 
        let _v639 = v661 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v662 : string = "inline_colorization::color_bright_blue"
        let v663 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v662 
        let v664 : string = "&*$0"
        let v665 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v625 v664 
        let v666 : string = "inline_colorization::color_reset"
        let v667 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v666 
        let v668 : string = "\"{v663}{v665}{v667}\""
        let v669 : string = @$"format!(" + v668 + ")"
        let v670 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v669 
        let v671 : string = "fable_library_rust::String_::fromString($0)"
        let v672 : string = Fable.Core.RustInterop.emitRustExpr v670 v671 
        let _v639 = v672 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v673 : string = "\u001b[94m"
        let v674 : string = method14()
        let v675 : string = v673 + v625 
        let v676 : string = v675 + v674 
        let _v639 = v676 
        #endif
#if FABLE_COMPILER_PYTHON
        let v677 : string = "\u001b[94m"
        let v678 : string = method14()
        let v679 : string = v677 + v625 
        let v680 : string = v679 + v678 
        let _v639 = v680 
        #endif
#else
        let v681 : string = "\u001b[94m"
        let v682 : string = method14()
        let v683 : string = v681 + v625 
        let v684 : string = v683 + v682 
        let _v639 = v684 
        #endif
        let v685 : string = _v639 
        let v691 : int64 = v86.l0
        let v692 : string = method15(v0)
        let v693 : string = method13()
        let v694 : Mut4 = {l0 = v693} : Mut4
        let v695 : string = "{ "
        let v696 : string = $"{v695}"
        let v699 : unit = ()
        let v700 : (unit -> unit) = closure9(v694, v696)
        let v701 : unit = (fun () -> v700 (); v699) ()
        let v704 : string = "ex"
        let v705 : string = $"{v704}"
        let v708 : unit = ()
        let v709 : (unit -> unit) = closure9(v694, v705)
        let v710 : unit = (fun () -> v709 (); v708) ()
        let v713 : string = " = "
        let v714 : string = $"{v713}"
        let v717 : unit = ()
        let v718 : (unit -> unit) = closure9(v694, v714)
        let v719 : unit = (fun () -> v718 (); v717) ()
        let v722 : string = $"{v1}"
        let v725 : unit = ()
        let v726 : (unit -> unit) = closure9(v694, v722)
        let v727 : unit = (fun () -> v726 (); v725) ()
        let v730 : string = "; "
        let v731 : string = $"{v730}"
        let v734 : unit = ()
        let v735 : (unit -> unit) = closure9(v694, v731)
        let v736 : unit = (fun () -> v735 (); v734) ()
        let v739 : string = "path"
        let v740 : string = $"{v739}"
        let v743 : unit = ()
        let v744 : (unit -> unit) = closure9(v694, v740)
        let v745 : unit = (fun () -> v744 (); v743) ()
        let v748 : string = $"{v713}"
        let v751 : unit = ()
        let v752 : (unit -> unit) = closure9(v694, v748)
        let v753 : unit = (fun () -> v752 (); v751) ()
        let v756 : string = $"{v692}"
        let v759 : unit = ()
        let v760 : (unit -> unit) = closure9(v694, v756)
        let v761 : unit = (fun () -> v760 (); v759) ()
        let v764 : string = " }"
        let v765 : string = $"{v764}"
        let v768 : unit = ()
        let v769 : (unit -> unit) = closure9(v694, v765)
        let v770 : unit = (fun () -> v769 (); v768) ()
        let v773 : string = v694.l0
        let v774 : (unit -> string) = closure10()
        let v775 : string = $"{v484} {v685} #{v691} %s{v774 ()} / {v773}"
        let v778 : char list = []
        let v779 : (char list -> (char [])) = List.toArray
        let v780 : (char []) = v779 v778
        let v783 : string = v775.TrimStart v780 
        let v801 : char list = []
        let v802 : char list = '/' :: v801 
        let v805 : char list = ' ' :: v802 
        let v808 : (char list -> (char [])) = List.toArray
        let v809 : (char []) = v808 v805
        let v812 : string = v783.TrimEnd v809 
        let v830 : (string -> unit) = closure11()
        let v831 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v832 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v812 v832 
        let _v831 = () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v833 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v812 v833 
        let _v831 = () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v834 : string = $"near_sdk::log!(\"{{}}\", $0)"
        Fable.Core.RustInterop.emitRustExpr v812 v834 
        let _v831 = () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        v830 v812
        let _v831 = () 
        #endif
#if FABLE_COMPILER_PYTHON
        v830 v812
        let _v831 = () 
        #endif
#else
        v830 v812
        let _v831 = () 
        #endif
        _v831 
        let v835 : (string -> unit) = v18.l0
        v835 v812
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
    let v882 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v883 : Async<unit> = null |> unbox<Async<unit>>
    let _v882 = v883 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v886 : Async<unit> = null |> unbox<Async<unit>>
    let _v882 = v886 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v889 : Async<unit> = null |> unbox<Async<unit>>
    let _v882 = v889 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v892 : Async<unit> = null |> unbox<Async<unit>>
    let _v882 = v892 
    #endif
#if FABLE_COMPILER_PYTHON
    let v895 : Async<unit> = null |> unbox<Async<unit>>
    let _v882 = v895 
    #endif
#else
    let v898 : (int32 -> Async<unit>) = Async.Sleep
    let v899 : Async<unit> = v898 10
    let _v882 = v899 
    #endif
    let v900 : Async<unit> = _v882 
    do! v900 
    let v905 : int64 = v1 + 1L
    let v906 : Async<int64> = method5(v0, v905)
    return! v906 
    (*
    let v907 : int64 = *)
    }
    |> fun x -> _v18 <- Some x
    let v908 : Async<int64> = match _v18 with Some x -> x | None -> failwith "async.new_async_unit / _v18=None"
    let _v2 = v908 
    #endif
    let v909 : Async<int64> = _v2 
    v909
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
and closure16 () () : string =
    let v0 : string = "file_system.wait_for_file_access"
    v0
and closure15 (v0 : string, v1 : int64, v2 : string) () : unit =
    let v3 : unit = ()
    let v4 : (unit -> unit) = closure0()
    let v5 : unit = (fun () -> v4 (); v3) ()
    let struct (v18 : Mut0, v19 : Mut1, v20 : Mut2, v21 : Mut3, v22 : int64 option) = State.trace_state.Value
    let v33 : unit = ()
    let v34 : unit = (fun () -> v4 (); v33) ()
    let struct (v47 : Mut0, v48 : Mut1, v49 : Mut2, v50 : Mut3, v51 : int64 option) = State.trace_state.Value
    let v62 : US0 = v50.l0
    let v63 : bool = v49.l0
    let v64 : bool = v63 = false
    let v67 : bool =
        if v64 then
            false
        else
            let v65 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v62
            let v66 : bool = 1 >= v65
            v66
    if v67 then
        let v68 : unit = ()
        let v69 : (unit -> unit) = closure6(v18)
        let v70 : unit = (fun () -> v69 (); v68) ()
        let v73 : unit = ()
        let v74 : unit = (fun () -> v4 (); v73) ()
        let struct (v87 : Mut0, v88 : Mut1, v89 : Mut2, v90 : Mut3, v91 : int64 option) = State.trace_state.Value
        let v102 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v103 : US3 option = None
        let _v103 = ref v103 
        let v104 : US3 option ref = _v103 
        let v105 : (US3 option -> US3 option ref) = closure7(v104)
        let v106 : unit = ()
        let v107 : (unit -> unit) = closure8(v91, v105)
        let v108 : unit = (fun () -> v107 (); v106) ()
        let v111 : US3 option = _v103.Value 
        let v122 : US3 = US3_1
        let v123 : US3 = v111 |> Option.defaultValue v122 
        let v163 : System.DateTime =
            match v123 with
            | US3_1 -> (* None *)
                let v159 : System.DateTime = System.DateTime.Now
                v159
            | US3_0(v127) -> (* Some *)
                let v128 : System.DateTime = System.DateTime.Now
                let v131 : (System.DateTime -> int64) = _.Ticks
                let v132 : int64 = v131 v128
                let v135 : int64 = v132 - v127
                let v136 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v137 : System.TimeSpan = v136 v135
                let v140 : (System.TimeSpan -> int32) = _.Hours
                let v141 : int32 = v140 v137
                let v144 : (System.TimeSpan -> int32) = _.Minutes
                let v145 : int32 = v144 v137
                let v148 : (System.TimeSpan -> int32) = _.Seconds
                let v149 : int32 = v148 v137
                let v152 : (System.TimeSpan -> int32) = _.Milliseconds
                let v153 : int32 = v152 v137
                let v156 : System.DateTime = System.DateTime (1, 1, 1, v141, v145, v149, v153)
                v156
        let v164 : string = method9()
        let v167 : (string -> string) = v163.ToString
        let v168 : string = v167 v164
        let _v102 = v168 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v171 : US3 option = None
        let _v171 = ref v171 
        let v172 : US3 option ref = _v171 
        let v173 : (US3 option -> US3 option ref) = closure7(v172)
        let v174 : unit = ()
        let v175 : (unit -> unit) = closure8(v91, v173)
        let v176 : unit = (fun () -> v175 (); v174) ()
        let v179 : US3 option = _v171.Value 
        let v190 : US3 = US3_1
        let v191 : US3 = v179 |> Option.defaultValue v190 
        let v231 : System.DateTime =
            match v191 with
            | US3_1 -> (* None *)
                let v227 : System.DateTime = System.DateTime.Now
                v227
            | US3_0(v195) -> (* Some *)
                let v196 : System.DateTime = System.DateTime.Now
                let v199 : (System.DateTime -> int64) = _.Ticks
                let v200 : int64 = v199 v196
                let v203 : int64 = v200 - v195
                let v204 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v205 : System.TimeSpan = v204 v203
                let v208 : (System.TimeSpan -> int32) = _.Hours
                let v209 : int32 = v208 v205
                let v212 : (System.TimeSpan -> int32) = _.Minutes
                let v213 : int32 = v212 v205
                let v216 : (System.TimeSpan -> int32) = _.Seconds
                let v217 : int32 = v216 v205
                let v220 : (System.TimeSpan -> int32) = _.Milliseconds
                let v221 : int32 = v220 v205
                let v224 : System.DateTime = System.DateTime (1, 1, 1, v209, v213, v217, v221)
                v224
        let v232 : string = method9()
        let v235 : (string -> string) = v231.ToString
        let v236 : string = v235 v232
        let _v102 = v236 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v239 : string = $"near_sdk::env::block_timestamp()"
        let v240 : uint64 = Fable.Core.RustInterop.emitRustExpr () v239 
        let v241 : US3 option = None
        let _v241 = ref v241 
        let v242 : US3 option ref = _v241 
        let v243 : (US3 option -> US3 option ref) = closure7(v242)
        let v244 : unit = ()
        let v245 : (unit -> unit) = closure8(v91, v243)
        let v246 : unit = (fun () -> v245 (); v244) ()
        let v249 : US3 option = _v241.Value 
        let v260 : US3 = US3_1
        let v261 : US3 = v249 |> Option.defaultValue v260 
        let v270 : uint64 =
            match v261 with
            | US3_1 -> (* None *)
                v240
            | US3_0(v265) -> (* Some *)
                let v266 : (int64 -> uint64) = uint64
                let v267 : uint64 = v266 v265
                let v268 : uint64 = v240 - v267
                v268
        let v271 : uint64 = v270 / 1000000000UL
        let v272 : uint64 = v271 % 60UL
        let v273 : uint64 = v271 / 60UL
        let v274 : uint64 = v273 % 60UL
        let v275 : uint64 = v271 / 3600UL
        let v276 : uint64 = v275 % 24UL
        let v277 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
        let v278 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v276, v274, v272) v277 
        let v279 : string = "fable_library_rust::String_::fromString($0)"
        let v280 : string = Fable.Core.RustInterop.emitRustExpr v278 v279 
        let _v102 = v280 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v281 : US3 option = None
        let _v281 = ref v281 
        let v282 : US3 option ref = _v281 
        let v283 : (US3 option -> US3 option ref) = closure7(v282)
        let v284 : unit = ()
        let v285 : (unit -> unit) = closure8(v91, v283)
        let v286 : unit = (fun () -> v285 (); v284) ()
        let v289 : US3 option = _v281.Value 
        let v300 : US3 = US3_1
        let v301 : US3 = v289 |> Option.defaultValue v300 
        let v341 : System.DateTime =
            match v301 with
            | US3_1 -> (* None *)
                let v337 : System.DateTime = System.DateTime.Now
                v337
            | US3_0(v305) -> (* Some *)
                let v306 : System.DateTime = System.DateTime.Now
                let v309 : (System.DateTime -> int64) = _.Ticks
                let v310 : int64 = v309 v306
                let v313 : int64 = v310 - v305
                let v314 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v315 : System.TimeSpan = v314 v313
                let v318 : (System.TimeSpan -> int32) = _.Hours
                let v319 : int32 = v318 v315
                let v322 : (System.TimeSpan -> int32) = _.Minutes
                let v323 : int32 = v322 v315
                let v326 : (System.TimeSpan -> int32) = _.Seconds
                let v327 : int32 = v326 v315
                let v330 : (System.TimeSpan -> int32) = _.Milliseconds
                let v331 : int32 = v330 v315
                let v334 : System.DateTime = System.DateTime (1, 1, 1, v319, v323, v327, v331)
                v334
        let v342 : string = method10()
        let v345 : (string -> string) = v341.ToString
        let v346 : string = v345 v342
        let _v102 = v346 
        #endif
#if FABLE_COMPILER_PYTHON
        let v349 : US3 option = None
        let _v349 = ref v349 
        let v350 : US3 option ref = _v349 
        let v351 : (US3 option -> US3 option ref) = closure7(v350)
        let v352 : unit = ()
        let v353 : (unit -> unit) = closure8(v91, v351)
        let v354 : unit = (fun () -> v353 (); v352) ()
        let v357 : US3 option = _v349.Value 
        let v368 : US3 = US3_1
        let v369 : US3 = v357 |> Option.defaultValue v368 
        let v409 : System.DateTime =
            match v369 with
            | US3_1 -> (* None *)
                let v405 : System.DateTime = System.DateTime.Now
                v405
            | US3_0(v373) -> (* Some *)
                let v374 : System.DateTime = System.DateTime.Now
                let v377 : (System.DateTime -> int64) = _.Ticks
                let v378 : int64 = v377 v374
                let v381 : int64 = v378 - v373
                let v382 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v383 : System.TimeSpan = v382 v381
                let v386 : (System.TimeSpan -> int32) = _.Hours
                let v387 : int32 = v386 v383
                let v390 : (System.TimeSpan -> int32) = _.Minutes
                let v391 : int32 = v390 v383
                let v394 : (System.TimeSpan -> int32) = _.Seconds
                let v395 : int32 = v394 v383
                let v398 : (System.TimeSpan -> int32) = _.Milliseconds
                let v399 : int32 = v398 v383
                let v402 : System.DateTime = System.DateTime (1, 1, 1, v387, v391, v395, v399)
                v402
        let v410 : string = method10()
        let v413 : (string -> string) = v409.ToString
        let v414 : string = v413 v410
        let _v102 = v414 
        #endif
#else
        let v417 : US3 option = None
        let _v417 = ref v417 
        let v418 : US3 option ref = _v417 
        let v419 : (US3 option -> US3 option ref) = closure7(v418)
        let v420 : unit = ()
        let v421 : (unit -> unit) = closure8(v91, v419)
        let v422 : unit = (fun () -> v421 (); v420) ()
        let v425 : US3 option = _v417.Value 
        let v436 : US3 = US3_1
        let v437 : US3 = v425 |> Option.defaultValue v436 
        let v477 : System.DateTime =
            match v437 with
            | US3_1 -> (* None *)
                let v473 : System.DateTime = System.DateTime.Now
                v473
            | US3_0(v441) -> (* Some *)
                let v442 : System.DateTime = System.DateTime.Now
                let v445 : (System.DateTime -> int64) = _.Ticks
                let v446 : int64 = v445 v442
                let v449 : int64 = v446 - v441
                let v450 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v451 : System.TimeSpan = v450 v449
                let v454 : (System.TimeSpan -> int32) = _.Hours
                let v455 : int32 = v454 v451
                let v458 : (System.TimeSpan -> int32) = _.Minutes
                let v459 : int32 = v458 v451
                let v462 : (System.TimeSpan -> int32) = _.Seconds
                let v463 : int32 = v462 v451
                let v466 : (System.TimeSpan -> int32) = _.Milliseconds
                let v467 : int32 = v466 v451
                let v470 : System.DateTime = System.DateTime (1, 1, 1, v455, v459, v463, v467)
                v470
        let v478 : string = method10()
        let v481 : (string -> string) = v477.ToString
        let v482 : string = v481 v478
        let _v102 = v482 
        #endif
        let v485 : string = _v102 
        
        
        
        
        
        let v555 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v556 : string = method11()
        let _v555 = v556 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v557 : string = method11()
        let _v555 = v557 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v558 : string = method11()
        let _v555 = v558 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v559 : string = method12()
        let _v555 = v559 
        #endif
#if FABLE_COMPILER_PYTHON
        let v560 : string = method12()
        let _v555 = v560 
        #endif
#else
        let v561 : string = method12()
        let _v555 = v561 
        #endif
        let v562 : string = _v555 
        let v567 : string = method13()
        let v568 : Mut4 = {l0 = v567} : Mut4
        let v569 : US0 = US0_0
        let v570 : string = $"%A{v569}"
        let v574 : string = $"{v570}"
        let v577 : unit = ()
        let v578 : (unit -> unit) = closure9(v568, v574)
        let v579 : unit = (fun () -> v578 (); v577) ()
        let v582 : string = v568.l0
        let v583 : (string []) = v582.Split v562 
        let v586 : string = v583.[int 0]
        let v589 : string = method13()
        let v590 : Mut4 = {l0 = v589} : Mut4
        let v591 : US0 = US0_1
        let v592 : string = $"%A{v591}"
        let v596 : string = $"{v592}"
        let v599 : unit = ()
        let v600 : (unit -> unit) = closure9(v590, v596)
        let v601 : unit = (fun () -> v600 (); v599) ()
        let v604 : string = v590.l0
        let v605 : bool = v604.StartsWith v586 
        let v611 : US1 =
            if v605 then
                let v608 : string = "Verbose"
                US1_0(v608)
            else
                US1_1
        let v617 : US1 =
            match v611 with
            | US1_1 -> (* None *)
                let v614 : string = "Debug"
                US1_0(v614)
            | US1_0(v612) -> (* Some *)
                US1_0(v612)
        let v621 : string =
            match v617 with
            | US1_1 -> (* None *)
                failwith<string> "Option does not have a value."
            | US1_0(v618) -> (* Some *)
                v618
        let v622 : (unit -> string) = v621.ToLower
        let v623 : string = v622 ()
        let v626 : string = v623.PadLeft (7, ' ')
        let v640 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v641 : string = "inline_colorization::color_bright_blue"
        let v642 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v641 
        let v643 : string = "&*$0"
        let v644 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v626 v643 
        let v645 : string = "inline_colorization::color_reset"
        let v646 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v645 
        let v647 : string = "\"{v642}{v644}{v646}\""
        let v648 : string = @$"format!(" + v647 + ")"
        let v649 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v648 
        let v650 : string = "fable_library_rust::String_::fromString($0)"
        let v651 : string = Fable.Core.RustInterop.emitRustExpr v649 v650 
        let _v640 = v651 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v652 : string = "inline_colorization::color_bright_blue"
        let v653 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v652 
        let v654 : string = "&*$0"
        let v655 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v626 v654 
        let v656 : string = "inline_colorization::color_reset"
        let v657 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v656 
        let v658 : string = "\"{v653}{v655}{v657}\""
        let v659 : string = @$"format!(" + v658 + ")"
        let v660 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v659 
        let v661 : string = "fable_library_rust::String_::fromString($0)"
        let v662 : string = Fable.Core.RustInterop.emitRustExpr v660 v661 
        let _v640 = v662 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v663 : string = "inline_colorization::color_bright_blue"
        let v664 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v663 
        let v665 : string = "&*$0"
        let v666 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v626 v665 
        let v667 : string = "inline_colorization::color_reset"
        let v668 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v667 
        let v669 : string = "\"{v664}{v666}{v668}\""
        let v670 : string = @$"format!(" + v669 + ")"
        let v671 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v670 
        let v672 : string = "fable_library_rust::String_::fromString($0)"
        let v673 : string = Fable.Core.RustInterop.emitRustExpr v671 v672 
        let _v640 = v673 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v674 : string = "\u001b[94m"
        let v675 : string = method14()
        let v676 : string = v674 + v626 
        let v677 : string = v676 + v675 
        let _v640 = v677 
        #endif
#if FABLE_COMPILER_PYTHON
        let v678 : string = "\u001b[94m"
        let v679 : string = method14()
        let v680 : string = v678 + v626 
        let v681 : string = v680 + v679 
        let _v640 = v681 
        #endif
#else
        let v682 : string = "\u001b[94m"
        let v683 : string = method14()
        let v684 : string = v682 + v626 
        let v685 : string = v684 + v683 
        let _v640 = v685 
        #endif
        let v686 : string = _v640 
        let v692 : int64 = v87.l0
        let v693 : string = method15(v0)
        let v694 : string = method13()
        let v695 : Mut4 = {l0 = v694} : Mut4
        let v696 : string = "{ "
        let v697 : string = $"{v696}"
        let v700 : unit = ()
        let v701 : (unit -> unit) = closure9(v695, v697)
        let v702 : unit = (fun () -> v701 (); v700) ()
        let v705 : string = "path"
        let v706 : string = $"{v705}"
        let v709 : unit = ()
        let v710 : (unit -> unit) = closure9(v695, v706)
        let v711 : unit = (fun () -> v710 (); v709) ()
        let v714 : string = " = "
        let v715 : string = $"{v714}"
        let v718 : unit = ()
        let v719 : (unit -> unit) = closure9(v695, v715)
        let v720 : unit = (fun () -> v719 (); v718) ()
        let v723 : string = $"{v693}"
        let v726 : unit = ()
        let v727 : (unit -> unit) = closure9(v695, v723)
        let v728 : unit = (fun () -> v727 (); v726) ()
        let v731 : string = "; "
        let v732 : string = $"{v731}"
        let v735 : unit = ()
        let v736 : (unit -> unit) = closure9(v695, v732)
        let v737 : unit = (fun () -> v736 (); v735) ()
        let v740 : string = "retry"
        let v741 : string = $"{v740}"
        let v744 : unit = ()
        let v745 : (unit -> unit) = closure9(v695, v741)
        let v746 : unit = (fun () -> v745 (); v744) ()
        let v749 : string = $"{v714}"
        let v752 : unit = ()
        let v753 : (unit -> unit) = closure9(v695, v749)
        let v754 : unit = (fun () -> v753 (); v752) ()
        let v757 : string = $"{v1}"
        let v760 : unit = ()
        let v761 : (unit -> unit) = closure9(v695, v757)
        let v762 : unit = (fun () -> v761 (); v760) ()
        let v765 : string = $"{v731}"
        let v768 : unit = ()
        let v769 : (unit -> unit) = closure9(v695, v765)
        let v770 : unit = (fun () -> v769 (); v768) ()
        let v773 : string = "ex"
        let v774 : string = $"{v773}"
        let v777 : unit = ()
        let v778 : (unit -> unit) = closure9(v695, v774)
        let v779 : unit = (fun () -> v778 (); v777) ()
        let v782 : string = $"{v714}"
        let v785 : unit = ()
        let v786 : (unit -> unit) = closure9(v695, v782)
        let v787 : unit = (fun () -> v786 (); v785) ()
        let v790 : string = $"{v2}"
        let v793 : unit = ()
        let v794 : (unit -> unit) = closure9(v695, v790)
        let v795 : unit = (fun () -> v794 (); v793) ()
        let v798 : string = " }"
        let v799 : string = $"{v798}"
        let v802 : unit = ()
        let v803 : (unit -> unit) = closure9(v695, v799)
        let v804 : unit = (fun () -> v803 (); v802) ()
        let v807 : string = v695.l0
        let v808 : (unit -> string) = closure16()
        let v809 : string = $"{v485} {v686} #{v692} %s{v808 ()} / {v807}"
        let v812 : char list = []
        let v813 : (char list -> (char [])) = List.toArray
        let v814 : (char []) = v813 v812
        let v817 : string = v809.TrimStart v814 
        let v835 : char list = []
        let v836 : char list = '/' :: v835 
        let v839 : char list = ' ' :: v836 
        let v842 : (char list -> (char [])) = List.toArray
        let v843 : (char []) = v842 v839
        let v846 : string = v817.TrimEnd v843 
        let v864 : (string -> unit) = closure11()
        let v865 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v866 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v846 v866 
        let _v865 = () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v867 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v846 v867 
        let _v865 = () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v868 : string = $"near_sdk::log!(\"{{}}\", $0)"
        Fable.Core.RustInterop.emitRustExpr v846 v868 
        let _v865 = () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        v864 v846
        let _v865 = () 
        #endif
#if FABLE_COMPILER_PYTHON
        v864 v846
        let _v865 = () 
        #endif
#else
        v864 v846
        let _v865 = () 
        #endif
        _v865 
        let v869 : (string -> unit) = v19.l0
        v869 v846
and method16 (v0 : string, v1 : US8, v2 : US7, v3 : int64) : Async<int64> =
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
        let v89 : (unit -> unit) = closure15(v0, v3, v83)
        let v90 : unit = (fun () -> v89 (); v88) ()
        ()
    let v958 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v959 : Async<unit> = null |> unbox<Async<unit>>
    let _v958 = v959 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v962 : Async<unit> = null |> unbox<Async<unit>>
    let _v958 = v962 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v965 : Async<unit> = null |> unbox<Async<unit>>
    let _v958 = v965 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v968 : Async<unit> = null |> unbox<Async<unit>>
    let _v958 = v968 
    #endif
#if FABLE_COMPILER_PYTHON
    let v971 : Async<unit> = null |> unbox<Async<unit>>
    let _v958 = v971 
    #endif
#else
    let v974 : (int32 -> Async<unit>) = Async.Sleep
    let v975 : Async<unit> = v974 10
    let _v958 = v975 
    #endif
    let v976 : Async<unit> = _v958 
    do! v976 
    let v981 : int64 = v3 + 1L
    let v982 : Async<int64> = method16(v0, v1, v2, v981)
    return! v982 
    (*
    let v983 : int64 = *)
    }
    |> fun x -> _v20 <- Some x
    let v984 : Async<int64> = match _v20 with Some x -> x | None -> failwith "async.new_async_unit / _v20=None"
    let _v4 = v984 
    #endif
    let v985 : Async<int64> = _v4 
    v985
and closure14 (v0 : US6) (v1 : string) : Async<int64> =
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
    let v27 : Async<int64> = method16(v1, v25, v24, v26)
    let _v2 = v27 
    #endif
    let v28 : Async<int64> = _v2 
    v28
and closure13 () (v0 : US6) : (string -> Async<int64>) =
    closure14(v0)
and method17 (v0 : string, v1 : int64) : Async<int64> =
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
        let v73 : (unit -> unit) = closure15(v0, v1, v67)
        let v74 : unit = (fun () -> v73 (); v72) ()
        ()
    let v942 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v943 : Async<unit> = null |> unbox<Async<unit>>
    let _v942 = v943 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v946 : Async<unit> = null |> unbox<Async<unit>>
    let _v942 = v946 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v949 : Async<unit> = null |> unbox<Async<unit>>
    let _v942 = v949 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v952 : Async<unit> = null |> unbox<Async<unit>>
    let _v942 = v952 
    #endif
#if FABLE_COMPILER_PYTHON
    let v955 : Async<unit> = null |> unbox<Async<unit>>
    let _v942 = v955 
    #endif
#else
    let v958 : (int32 -> Async<unit>) = Async.Sleep
    let v959 : Async<unit> = v958 10
    let _v942 = v959 
    #endif
    let v960 : Async<unit> = _v942 
    do! v960 
    let v965 : int64 = v1 + 1L
    let v966 : Async<int64> = method17(v0, v965)
    return! v966 
    (*
    let v967 : int64 = *)
    }
    |> fun x -> _v18 <- Some x
    let v968 : Async<int64> = match _v18 with Some x -> x | None -> failwith "async.new_async_unit / _v18=None"
    let _v2 = v968 
    #endif
    let v969 : Async<int64> = _v2 
    v969
and closure17 () (v0 : string) : Async<int64> =
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
    let v18 : Async<int64> = method17(v0, v17)
    let _v1 = v18 
    #endif
    let v19 : Async<int64> = _v1 
    v19
and closure18 () (v0 : string) : Async<string> =
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
and method19 (v0 : string) : bool =
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
and method20 (v0 : Vec<uint8>) : Vec<uint8> =
    v0
and method18 (v0 : string, v1 : string) : bool =
    let v2 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : bool = method19(v0)
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
            let v31 : Vec<uint8> = method20(v26)
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
and closure20 (v0 : string) (v1 : string) : bool =
    method18(v0, v1)
and closure19 () (v0 : string) : (string -> bool) =
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
and closure21 () (v0 : string) : (string -> Async<unit>) =
    closure22(v0)
and closure24 (v0 : string) (v1 : string) : Async<unit> =
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
    let v52 : bool = method19(v0)
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
and closure23 () (v0 : string) : (string -> Async<unit>) =
    closure24(v0)
and closure27 () () : string =
    let v0 : string = "delete_file_async"
    v0
and closure26 (v0 : string, v1 : exn) () : unit =
    let v2 : unit = ()
    let v3 : (unit -> unit) = closure0()
    let v4 : unit = (fun () -> v3 (); v2) ()
    let struct (v17 : Mut0, v18 : Mut1, v19 : Mut2, v20 : Mut3, v21 : int64 option) = State.trace_state.Value
    let v32 : unit = ()
    let v33 : unit = (fun () -> v3 (); v32) ()
    let struct (v46 : Mut0, v47 : Mut1, v48 : Mut2, v49 : Mut3, v50 : int64 option) = State.trace_state.Value
    let v61 : US0 = v49.l0
    let v62 : bool = v48.l0
    let v63 : bool = v62 = false
    let v66 : bool =
        if v63 then
            false
        else
            let v64 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v61
            let v65 : bool = 3 >= v64
            v65
    if v66 then
        let v67 : unit = ()
        let v68 : (unit -> unit) = closure6(v17)
        let v69 : unit = (fun () -> v68 (); v67) ()
        let v72 : unit = ()
        let v73 : unit = (fun () -> v3 (); v72) ()
        let struct (v86 : Mut0, v87 : Mut1, v88 : Mut2, v89 : Mut3, v90 : int64 option) = State.trace_state.Value
        let v101 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v102 : US3 option = None
        let _v102 = ref v102 
        let v103 : US3 option ref = _v102 
        let v104 : (US3 option -> US3 option ref) = closure7(v103)
        let v105 : unit = ()
        let v106 : (unit -> unit) = closure8(v90, v104)
        let v107 : unit = (fun () -> v106 (); v105) ()
        let v110 : US3 option = _v102.Value 
        let v121 : US3 = US3_1
        let v122 : US3 = v110 |> Option.defaultValue v121 
        let v162 : System.DateTime =
            match v122 with
            | US3_1 -> (* None *)
                let v158 : System.DateTime = System.DateTime.Now
                v158
            | US3_0(v126) -> (* Some *)
                let v127 : System.DateTime = System.DateTime.Now
                let v130 : (System.DateTime -> int64) = _.Ticks
                let v131 : int64 = v130 v127
                let v134 : int64 = v131 - v126
                let v135 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v136 : System.TimeSpan = v135 v134
                let v139 : (System.TimeSpan -> int32) = _.Hours
                let v140 : int32 = v139 v136
                let v143 : (System.TimeSpan -> int32) = _.Minutes
                let v144 : int32 = v143 v136
                let v147 : (System.TimeSpan -> int32) = _.Seconds
                let v148 : int32 = v147 v136
                let v151 : (System.TimeSpan -> int32) = _.Milliseconds
                let v152 : int32 = v151 v136
                let v155 : System.DateTime = System.DateTime (1, 1, 1, v140, v144, v148, v152)
                v155
        let v163 : string = method9()
        let v166 : (string -> string) = v162.ToString
        let v167 : string = v166 v163
        let _v101 = v167 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v170 : US3 option = None
        let _v170 = ref v170 
        let v171 : US3 option ref = _v170 
        let v172 : (US3 option -> US3 option ref) = closure7(v171)
        let v173 : unit = ()
        let v174 : (unit -> unit) = closure8(v90, v172)
        let v175 : unit = (fun () -> v174 (); v173) ()
        let v178 : US3 option = _v170.Value 
        let v189 : US3 = US3_1
        let v190 : US3 = v178 |> Option.defaultValue v189 
        let v230 : System.DateTime =
            match v190 with
            | US3_1 -> (* None *)
                let v226 : System.DateTime = System.DateTime.Now
                v226
            | US3_0(v194) -> (* Some *)
                let v195 : System.DateTime = System.DateTime.Now
                let v198 : (System.DateTime -> int64) = _.Ticks
                let v199 : int64 = v198 v195
                let v202 : int64 = v199 - v194
                let v203 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v204 : System.TimeSpan = v203 v202
                let v207 : (System.TimeSpan -> int32) = _.Hours
                let v208 : int32 = v207 v204
                let v211 : (System.TimeSpan -> int32) = _.Minutes
                let v212 : int32 = v211 v204
                let v215 : (System.TimeSpan -> int32) = _.Seconds
                let v216 : int32 = v215 v204
                let v219 : (System.TimeSpan -> int32) = _.Milliseconds
                let v220 : int32 = v219 v204
                let v223 : System.DateTime = System.DateTime (1, 1, 1, v208, v212, v216, v220)
                v223
        let v231 : string = method9()
        let v234 : (string -> string) = v230.ToString
        let v235 : string = v234 v231
        let _v101 = v235 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v238 : string = $"near_sdk::env::block_timestamp()"
        let v239 : uint64 = Fable.Core.RustInterop.emitRustExpr () v238 
        let v240 : US3 option = None
        let _v240 = ref v240 
        let v241 : US3 option ref = _v240 
        let v242 : (US3 option -> US3 option ref) = closure7(v241)
        let v243 : unit = ()
        let v244 : (unit -> unit) = closure8(v90, v242)
        let v245 : unit = (fun () -> v244 (); v243) ()
        let v248 : US3 option = _v240.Value 
        let v259 : US3 = US3_1
        let v260 : US3 = v248 |> Option.defaultValue v259 
        let v269 : uint64 =
            match v260 with
            | US3_1 -> (* None *)
                v239
            | US3_0(v264) -> (* Some *)
                let v265 : (int64 -> uint64) = uint64
                let v266 : uint64 = v265 v264
                let v267 : uint64 = v239 - v266
                v267
        let v270 : uint64 = v269 / 1000000000UL
        let v271 : uint64 = v270 % 60UL
        let v272 : uint64 = v270 / 60UL
        let v273 : uint64 = v272 % 60UL
        let v274 : uint64 = v270 / 3600UL
        let v275 : uint64 = v274 % 24UL
        let v276 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
        let v277 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v275, v273, v271) v276 
        let v278 : string = "fable_library_rust::String_::fromString($0)"
        let v279 : string = Fable.Core.RustInterop.emitRustExpr v277 v278 
        let _v101 = v279 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v280 : US3 option = None
        let _v280 = ref v280 
        let v281 : US3 option ref = _v280 
        let v282 : (US3 option -> US3 option ref) = closure7(v281)
        let v283 : unit = ()
        let v284 : (unit -> unit) = closure8(v90, v282)
        let v285 : unit = (fun () -> v284 (); v283) ()
        let v288 : US3 option = _v280.Value 
        let v299 : US3 = US3_1
        let v300 : US3 = v288 |> Option.defaultValue v299 
        let v340 : System.DateTime =
            match v300 with
            | US3_1 -> (* None *)
                let v336 : System.DateTime = System.DateTime.Now
                v336
            | US3_0(v304) -> (* Some *)
                let v305 : System.DateTime = System.DateTime.Now
                let v308 : (System.DateTime -> int64) = _.Ticks
                let v309 : int64 = v308 v305
                let v312 : int64 = v309 - v304
                let v313 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v314 : System.TimeSpan = v313 v312
                let v317 : (System.TimeSpan -> int32) = _.Hours
                let v318 : int32 = v317 v314
                let v321 : (System.TimeSpan -> int32) = _.Minutes
                let v322 : int32 = v321 v314
                let v325 : (System.TimeSpan -> int32) = _.Seconds
                let v326 : int32 = v325 v314
                let v329 : (System.TimeSpan -> int32) = _.Milliseconds
                let v330 : int32 = v329 v314
                let v333 : System.DateTime = System.DateTime (1, 1, 1, v318, v322, v326, v330)
                v333
        let v341 : string = method10()
        let v344 : (string -> string) = v340.ToString
        let v345 : string = v344 v341
        let _v101 = v345 
        #endif
#if FABLE_COMPILER_PYTHON
        let v348 : US3 option = None
        let _v348 = ref v348 
        let v349 : US3 option ref = _v348 
        let v350 : (US3 option -> US3 option ref) = closure7(v349)
        let v351 : unit = ()
        let v352 : (unit -> unit) = closure8(v90, v350)
        let v353 : unit = (fun () -> v352 (); v351) ()
        let v356 : US3 option = _v348.Value 
        let v367 : US3 = US3_1
        let v368 : US3 = v356 |> Option.defaultValue v367 
        let v408 : System.DateTime =
            match v368 with
            | US3_1 -> (* None *)
                let v404 : System.DateTime = System.DateTime.Now
                v404
            | US3_0(v372) -> (* Some *)
                let v373 : System.DateTime = System.DateTime.Now
                let v376 : (System.DateTime -> int64) = _.Ticks
                let v377 : int64 = v376 v373
                let v380 : int64 = v377 - v372
                let v381 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v382 : System.TimeSpan = v381 v380
                let v385 : (System.TimeSpan -> int32) = _.Hours
                let v386 : int32 = v385 v382
                let v389 : (System.TimeSpan -> int32) = _.Minutes
                let v390 : int32 = v389 v382
                let v393 : (System.TimeSpan -> int32) = _.Seconds
                let v394 : int32 = v393 v382
                let v397 : (System.TimeSpan -> int32) = _.Milliseconds
                let v398 : int32 = v397 v382
                let v401 : System.DateTime = System.DateTime (1, 1, 1, v386, v390, v394, v398)
                v401
        let v409 : string = method10()
        let v412 : (string -> string) = v408.ToString
        let v413 : string = v412 v409
        let _v101 = v413 
        #endif
#else
        let v416 : US3 option = None
        let _v416 = ref v416 
        let v417 : US3 option ref = _v416 
        let v418 : (US3 option -> US3 option ref) = closure7(v417)
        let v419 : unit = ()
        let v420 : (unit -> unit) = closure8(v90, v418)
        let v421 : unit = (fun () -> v420 (); v419) ()
        let v424 : US3 option = _v416.Value 
        let v435 : US3 = US3_1
        let v436 : US3 = v424 |> Option.defaultValue v435 
        let v476 : System.DateTime =
            match v436 with
            | US3_1 -> (* None *)
                let v472 : System.DateTime = System.DateTime.Now
                v472
            | US3_0(v440) -> (* Some *)
                let v441 : System.DateTime = System.DateTime.Now
                let v444 : (System.DateTime -> int64) = _.Ticks
                let v445 : int64 = v444 v441
                let v448 : int64 = v445 - v440
                let v449 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v450 : System.TimeSpan = v449 v448
                let v453 : (System.TimeSpan -> int32) = _.Hours
                let v454 : int32 = v453 v450
                let v457 : (System.TimeSpan -> int32) = _.Minutes
                let v458 : int32 = v457 v450
                let v461 : (System.TimeSpan -> int32) = _.Seconds
                let v462 : int32 = v461 v450
                let v465 : (System.TimeSpan -> int32) = _.Milliseconds
                let v466 : int32 = v465 v450
                let v469 : System.DateTime = System.DateTime (1, 1, 1, v454, v458, v462, v466)
                v469
        let v477 : string = method10()
        let v480 : (string -> string) = v476.ToString
        let v481 : string = v480 v477
        let _v101 = v481 
        #endif
        let v484 : string = _v101 
        
        
        
        
        
        let v554 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v555 : string = method11()
        let _v554 = v555 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v556 : string = method11()
        let _v554 = v556 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v557 : string = method11()
        let _v554 = v557 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v558 : string = method12()
        let _v554 = v558 
        #endif
#if FABLE_COMPILER_PYTHON
        let v559 : string = method12()
        let _v554 = v559 
        #endif
#else
        let v560 : string = method12()
        let _v554 = v560 
        #endif
        let v561 : string = _v554 
        let v566 : string = method13()
        let v567 : Mut4 = {l0 = v566} : Mut4
        let v568 : US0 = US0_0
        let v569 : string = $"%A{v568}"
        let v573 : string = $"{v569}"
        let v576 : unit = ()
        let v577 : (unit -> unit) = closure9(v567, v573)
        let v578 : unit = (fun () -> v577 (); v576) ()
        let v581 : string = v567.l0
        let v582 : (string []) = v581.Split v561 
        let v585 : string = v582.[int 0]
        let v588 : string = method13()
        let v589 : Mut4 = {l0 = v588} : Mut4
        let v590 : US0 = US0_3
        let v591 : string = $"%A{v590}"
        let v595 : string = $"{v591}"
        let v598 : unit = ()
        let v599 : (unit -> unit) = closure9(v589, v595)
        let v600 : unit = (fun () -> v599 (); v598) ()
        let v603 : string = v589.l0
        let v604 : bool = v603.StartsWith v585 
        let v610 : US1 =
            if v604 then
                let v607 : string = "Verbose"
                US1_0(v607)
            else
                US1_1
        let v738 : US1 =
            match v610 with
            | US1_1 -> (* None *)
                let v613 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v614 : string = method11()
                let _v613 = v614 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v615 : string = method11()
                let _v613 = v615 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v616 : string = method11()
                let _v613 = v616 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v617 : string = method12()
                let _v613 = v617 
                #endif
#if FABLE_COMPILER_PYTHON
                let v618 : string = method12()
                let _v613 = v618 
                #endif
#else
                let v619 : string = method12()
                let _v613 = v619 
                #endif
                let v620 : string = _v613 
                let v625 : string = method13()
                let v626 : Mut4 = {l0 = v625} : Mut4
                let v627 : US0 = US0_1
                let v628 : string = $"%A{v627}"
                let v632 : string = $"{v628}"
                let v635 : unit = ()
                let v636 : (unit -> unit) = closure9(v626, v632)
                let v637 : unit = (fun () -> v636 (); v635) ()
                let v640 : string = v626.l0
                let v641 : (string []) = v640.Split v620 
                let v644 : string = v641.[int 0]
                let v647 : string = method13()
                let v648 : Mut4 = {l0 = v647} : Mut4
                let v649 : US0 = US0_3
                let v650 : string = $"%A{v649}"
                let v654 : string = $"{v650}"
                let v657 : unit = ()
                let v658 : (unit -> unit) = closure9(v648, v654)
                let v659 : unit = (fun () -> v658 (); v657) ()
                let v662 : string = v648.l0
                let v663 : bool = v662.StartsWith v644 
                let v669 : US1 =
                    if v663 then
                        let v666 : string = "Debug"
                        US1_0(v666)
                    else
                        US1_1
                match v669 with
                | US1_1 -> (* None *)
                    let v672 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v673 : string = method11()
                    let _v672 = v673 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v674 : string = method11()
                    let _v672 = v674 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v675 : string = method11()
                    let _v672 = v675 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v676 : string = method12()
                    let _v672 = v676 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v677 : string = method12()
                    let _v672 = v677 
                    #endif
#else
                    let v678 : string = method12()
                    let _v672 = v678 
                    #endif
                    let v679 : string = _v672 
                    let v684 : string = method13()
                    let v685 : Mut4 = {l0 = v684} : Mut4
                    let v686 : US0 = US0_2
                    let v687 : string = $"%A{v686}"
                    let v691 : string = $"{v687}"
                    let v694 : unit = ()
                    let v695 : (unit -> unit) = closure9(v685, v691)
                    let v696 : unit = (fun () -> v695 (); v694) ()
                    let v699 : string = v685.l0
                    let v700 : (string []) = v699.Split v679 
                    let v703 : string = v700.[int 0]
                    let v706 : string = method13()
                    let v707 : Mut4 = {l0 = v706} : Mut4
                    let v708 : US0 = US0_3
                    let v709 : string = $"%A{v708}"
                    let v713 : string = $"{v709}"
                    let v716 : unit = ()
                    let v717 : (unit -> unit) = closure9(v707, v713)
                    let v718 : unit = (fun () -> v717 (); v716) ()
                    let v721 : string = v707.l0
                    let v722 : bool = v721.StartsWith v703 
                    let v728 : US1 =
                        if v722 then
                            let v725 : string = "Info"
                            US1_0(v725)
                        else
                            US1_1
                    match v728 with
                    | US1_1 -> (* None *)
                        let v731 : string = "Warning"
                        US1_0(v731)
                    | US1_0(v729) -> (* Some *)
                        US1_0(v729)
                | US1_0(v670) -> (* Some *)
                    US1_0(v670)
            | US1_0(v611) -> (* Some *)
                US1_0(v611)
        let v742 : string =
            match v738 with
            | US1_1 -> (* None *)
                failwith<string> "Option does not have a value."
            | US1_0(v739) -> (* Some *)
                v739
        let v743 : (unit -> string) = v742.ToLower
        let v744 : string = v743 ()
        let v747 : string = v744.PadLeft (7, ' ')
        let v761 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v762 : string = "inline_colorization::color_yellow"
        let v763 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v762 
        let v764 : string = "&*$0"
        let v765 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v747 v764 
        let v766 : string = "inline_colorization::color_reset"
        let v767 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v766 
        let v768 : string = "\"{v763}{v765}{v767}\""
        let v769 : string = @$"format!(" + v768 + ")"
        let v770 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v769 
        let v771 : string = "fable_library_rust::String_::fromString($0)"
        let v772 : string = Fable.Core.RustInterop.emitRustExpr v770 v771 
        let _v761 = v772 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v773 : string = "inline_colorization::color_yellow"
        let v774 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v773 
        let v775 : string = "&*$0"
        let v776 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v747 v775 
        let v777 : string = "inline_colorization::color_reset"
        let v778 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v777 
        let v779 : string = "\"{v774}{v776}{v778}\""
        let v780 : string = @$"format!(" + v779 + ")"
        let v781 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v780 
        let v782 : string = "fable_library_rust::String_::fromString($0)"
        let v783 : string = Fable.Core.RustInterop.emitRustExpr v781 v782 
        let _v761 = v783 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v784 : string = "inline_colorization::color_yellow"
        let v785 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v784 
        let v786 : string = "&*$0"
        let v787 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v747 v786 
        let v788 : string = "inline_colorization::color_reset"
        let v789 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v788 
        let v790 : string = "\"{v785}{v787}{v789}\""
        let v791 : string = @$"format!(" + v790 + ")"
        let v792 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v791 
        let v793 : string = "fable_library_rust::String_::fromString($0)"
        let v794 : string = Fable.Core.RustInterop.emitRustExpr v792 v793 
        let _v761 = v794 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v795 : string = "\u001b[93m"
        let v796 : string = method14()
        let v797 : string = v795 + v747 
        let v798 : string = v797 + v796 
        let _v761 = v798 
        #endif
#if FABLE_COMPILER_PYTHON
        let v799 : string = "\u001b[93m"
        let v800 : string = method14()
        let v801 : string = v799 + v747 
        let v802 : string = v801 + v800 
        let _v761 = v802 
        #endif
#else
        let v803 : string = "\u001b[93m"
        let v804 : string = method14()
        let v805 : string = v803 + v747 
        let v806 : string = v805 + v804 
        let _v761 = v806 
        #endif
        let v807 : string = _v761 
        let v813 : int64 = v86.l0
        let v814 : string = method15(v0)
        let v815 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v816 : string = $"%A{v1}"
        let _v815 = v816 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v819 : string = $"%A{v1}"
        let _v815 = v819 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v822 : string = $"%A{v1}"
        let _v815 = v822 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v825 : string = $"%A{v1}"
        let _v815 = v825 
        #endif
#if FABLE_COMPILER_PYTHON
        let v828 : string = $"%A{v1}"
        let _v815 = v828 
        #endif
#else
        let v831 : string = $"{v1.GetType ()}: {v1.Message}"
        let _v815 = v831 
        #endif
        let v832 : string = _v815 
        let v837 : string = method13()
        let v838 : Mut4 = {l0 = v837} : Mut4
        let v839 : string = "{ "
        let v840 : string = $"{v839}"
        let v843 : unit = ()
        let v844 : (unit -> unit) = closure9(v838, v840)
        let v845 : unit = (fun () -> v844 (); v843) ()
        let v848 : string = "path"
        let v849 : string = $"{v848}"
        let v852 : unit = ()
        let v853 : (unit -> unit) = closure9(v838, v849)
        let v854 : unit = (fun () -> v853 (); v852) ()
        let v857 : string = " = "
        let v858 : string = $"{v857}"
        let v861 : unit = ()
        let v862 : (unit -> unit) = closure9(v838, v858)
        let v863 : unit = (fun () -> v862 (); v861) ()
        let v866 : string = $"{v814}"
        let v869 : unit = ()
        let v870 : (unit -> unit) = closure9(v838, v866)
        let v871 : unit = (fun () -> v870 (); v869) ()
        let v874 : string = "; "
        let v875 : string = $"{v874}"
        let v878 : unit = ()
        let v879 : (unit -> unit) = closure9(v838, v875)
        let v880 : unit = (fun () -> v879 (); v878) ()
        let v883 : string = "ex"
        let v884 : string = $"{v883}"
        let v887 : unit = ()
        let v888 : (unit -> unit) = closure9(v838, v884)
        let v889 : unit = (fun () -> v888 (); v887) ()
        let v892 : string = $"{v857}"
        let v895 : unit = ()
        let v896 : (unit -> unit) = closure9(v838, v892)
        let v897 : unit = (fun () -> v896 (); v895) ()
        let v900 : string = $"{v832}"
        let v903 : unit = ()
        let v904 : (unit -> unit) = closure9(v838, v900)
        let v905 : unit = (fun () -> v904 (); v903) ()
        let v908 : string = " }"
        let v909 : string = $"{v908}"
        let v912 : unit = ()
        let v913 : (unit -> unit) = closure9(v838, v909)
        let v914 : unit = (fun () -> v913 (); v912) ()
        let v917 : string = v838.l0
        let v918 : (unit -> string) = closure27()
        let v919 : string = $"{v484} {v807} #{v813} %s{v918 ()} / {v917}"
        let v922 : char list = []
        let v923 : (char list -> (char [])) = List.toArray
        let v924 : (char []) = v923 v922
        let v927 : string = v919.TrimStart v924 
        let v945 : char list = []
        let v946 : char list = '/' :: v945 
        let v949 : char list = ' ' :: v946 
        let v952 : (char list -> (char [])) = List.toArray
        let v953 : (char []) = v952 v949
        let v956 : string = v927.TrimEnd v953 
        let v974 : (string -> unit) = closure11()
        let v975 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v976 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v956 v976 
        let _v975 = () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v977 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v956 v977 
        let _v975 = () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v978 : string = $"near_sdk::log!(\"{{}}\", $0)"
        Fable.Core.RustInterop.emitRustExpr v956 v978 
        let _v975 = () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        v974 v956
        let _v975 = () 
        #endif
#if FABLE_COMPILER_PYTHON
        v974 v956
        let _v975 = () 
        #endif
#else
        v974 v956
        let _v975 = () 
        #endif
        _v975 
        let v979 : (string -> unit) = v18.l0
        v979 v956
and method21 (v0 : string, v1 : int64) : Async<int64> =
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
        let v26 : (unit -> unit) = closure26(v0, v22)
        let v27 : unit = (fun () -> v26 (); v25) ()
        ()
    let v1006 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1007 : Async<unit> = null |> unbox<Async<unit>>
    let _v1006 = v1007 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1010 : Async<unit> = null |> unbox<Async<unit>>
    let _v1006 = v1010 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1013 : Async<unit> = null |> unbox<Async<unit>>
    let _v1006 = v1013 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1016 : Async<unit> = null |> unbox<Async<unit>>
    let _v1006 = v1016 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1019 : Async<unit> = null |> unbox<Async<unit>>
    let _v1006 = v1019 
    #endif
#else
    let v1022 : (int32 -> Async<unit>) = Async.Sleep
    let v1023 : Async<unit> = v1022 10
    let _v1006 = v1023 
    #endif
    let v1024 : Async<unit> = _v1006 
    do! v1024 
    let v1029 : int64 = v1 + 1L
    let v1030 : Async<int64> = method21(v0, v1029)
    return! v1030 
    (*
    let v1031 : int64 = *)
    }
    |> fun x -> _v18 <- Some x
    let v1032 : Async<int64> = match _v18 with Some x -> x | None -> failwith "async.new_async_unit / _v18=None"
    let _v2 = v1032 
    #endif
    let v1033 : Async<int64> = _v2 
    v1033
and closure25 () (v0 : string) : Async<int64> =
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
    let v18 : Async<int64> = method21(v0, v17)
    let _v1 = v18 
    #endif
    let v19 : Async<int64> = _v1 
    v19
and closure31 () () : string =
    let v0 : string = "move_file_async"
    v0
and closure30 (v0 : string, v1 : string, v2 : exn) () : unit =
    let v3 : unit = ()
    let v4 : (unit -> unit) = closure0()
    let v5 : unit = (fun () -> v4 (); v3) ()
    let struct (v18 : Mut0, v19 : Mut1, v20 : Mut2, v21 : Mut3, v22 : int64 option) = State.trace_state.Value
    let v33 : unit = ()
    let v34 : unit = (fun () -> v4 (); v33) ()
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
        let v68 : unit = ()
        let v69 : (unit -> unit) = closure6(v18)
        let v70 : unit = (fun () -> v69 (); v68) ()
        let v73 : unit = ()
        let v74 : unit = (fun () -> v4 (); v73) ()
        let struct (v87 : Mut0, v88 : Mut1, v89 : Mut2, v90 : Mut3, v91 : int64 option) = State.trace_state.Value
        let v102 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v103 : US3 option = None
        let _v103 = ref v103 
        let v104 : US3 option ref = _v103 
        let v105 : (US3 option -> US3 option ref) = closure7(v104)
        let v106 : unit = ()
        let v107 : (unit -> unit) = closure8(v91, v105)
        let v108 : unit = (fun () -> v107 (); v106) ()
        let v111 : US3 option = _v103.Value 
        let v122 : US3 = US3_1
        let v123 : US3 = v111 |> Option.defaultValue v122 
        let v163 : System.DateTime =
            match v123 with
            | US3_1 -> (* None *)
                let v159 : System.DateTime = System.DateTime.Now
                v159
            | US3_0(v127) -> (* Some *)
                let v128 : System.DateTime = System.DateTime.Now
                let v131 : (System.DateTime -> int64) = _.Ticks
                let v132 : int64 = v131 v128
                let v135 : int64 = v132 - v127
                let v136 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v137 : System.TimeSpan = v136 v135
                let v140 : (System.TimeSpan -> int32) = _.Hours
                let v141 : int32 = v140 v137
                let v144 : (System.TimeSpan -> int32) = _.Minutes
                let v145 : int32 = v144 v137
                let v148 : (System.TimeSpan -> int32) = _.Seconds
                let v149 : int32 = v148 v137
                let v152 : (System.TimeSpan -> int32) = _.Milliseconds
                let v153 : int32 = v152 v137
                let v156 : System.DateTime = System.DateTime (1, 1, 1, v141, v145, v149, v153)
                v156
        let v164 : string = method9()
        let v167 : (string -> string) = v163.ToString
        let v168 : string = v167 v164
        let _v102 = v168 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v171 : US3 option = None
        let _v171 = ref v171 
        let v172 : US3 option ref = _v171 
        let v173 : (US3 option -> US3 option ref) = closure7(v172)
        let v174 : unit = ()
        let v175 : (unit -> unit) = closure8(v91, v173)
        let v176 : unit = (fun () -> v175 (); v174) ()
        let v179 : US3 option = _v171.Value 
        let v190 : US3 = US3_1
        let v191 : US3 = v179 |> Option.defaultValue v190 
        let v231 : System.DateTime =
            match v191 with
            | US3_1 -> (* None *)
                let v227 : System.DateTime = System.DateTime.Now
                v227
            | US3_0(v195) -> (* Some *)
                let v196 : System.DateTime = System.DateTime.Now
                let v199 : (System.DateTime -> int64) = _.Ticks
                let v200 : int64 = v199 v196
                let v203 : int64 = v200 - v195
                let v204 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v205 : System.TimeSpan = v204 v203
                let v208 : (System.TimeSpan -> int32) = _.Hours
                let v209 : int32 = v208 v205
                let v212 : (System.TimeSpan -> int32) = _.Minutes
                let v213 : int32 = v212 v205
                let v216 : (System.TimeSpan -> int32) = _.Seconds
                let v217 : int32 = v216 v205
                let v220 : (System.TimeSpan -> int32) = _.Milliseconds
                let v221 : int32 = v220 v205
                let v224 : System.DateTime = System.DateTime (1, 1, 1, v209, v213, v217, v221)
                v224
        let v232 : string = method9()
        let v235 : (string -> string) = v231.ToString
        let v236 : string = v235 v232
        let _v102 = v236 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v239 : string = $"near_sdk::env::block_timestamp()"
        let v240 : uint64 = Fable.Core.RustInterop.emitRustExpr () v239 
        let v241 : US3 option = None
        let _v241 = ref v241 
        let v242 : US3 option ref = _v241 
        let v243 : (US3 option -> US3 option ref) = closure7(v242)
        let v244 : unit = ()
        let v245 : (unit -> unit) = closure8(v91, v243)
        let v246 : unit = (fun () -> v245 (); v244) ()
        let v249 : US3 option = _v241.Value 
        let v260 : US3 = US3_1
        let v261 : US3 = v249 |> Option.defaultValue v260 
        let v270 : uint64 =
            match v261 with
            | US3_1 -> (* None *)
                v240
            | US3_0(v265) -> (* Some *)
                let v266 : (int64 -> uint64) = uint64
                let v267 : uint64 = v266 v265
                let v268 : uint64 = v240 - v267
                v268
        let v271 : uint64 = v270 / 1000000000UL
        let v272 : uint64 = v271 % 60UL
        let v273 : uint64 = v271 / 60UL
        let v274 : uint64 = v273 % 60UL
        let v275 : uint64 = v271 / 3600UL
        let v276 : uint64 = v275 % 24UL
        let v277 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
        let v278 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v276, v274, v272) v277 
        let v279 : string = "fable_library_rust::String_::fromString($0)"
        let v280 : string = Fable.Core.RustInterop.emitRustExpr v278 v279 
        let _v102 = v280 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v281 : US3 option = None
        let _v281 = ref v281 
        let v282 : US3 option ref = _v281 
        let v283 : (US3 option -> US3 option ref) = closure7(v282)
        let v284 : unit = ()
        let v285 : (unit -> unit) = closure8(v91, v283)
        let v286 : unit = (fun () -> v285 (); v284) ()
        let v289 : US3 option = _v281.Value 
        let v300 : US3 = US3_1
        let v301 : US3 = v289 |> Option.defaultValue v300 
        let v341 : System.DateTime =
            match v301 with
            | US3_1 -> (* None *)
                let v337 : System.DateTime = System.DateTime.Now
                v337
            | US3_0(v305) -> (* Some *)
                let v306 : System.DateTime = System.DateTime.Now
                let v309 : (System.DateTime -> int64) = _.Ticks
                let v310 : int64 = v309 v306
                let v313 : int64 = v310 - v305
                let v314 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v315 : System.TimeSpan = v314 v313
                let v318 : (System.TimeSpan -> int32) = _.Hours
                let v319 : int32 = v318 v315
                let v322 : (System.TimeSpan -> int32) = _.Minutes
                let v323 : int32 = v322 v315
                let v326 : (System.TimeSpan -> int32) = _.Seconds
                let v327 : int32 = v326 v315
                let v330 : (System.TimeSpan -> int32) = _.Milliseconds
                let v331 : int32 = v330 v315
                let v334 : System.DateTime = System.DateTime (1, 1, 1, v319, v323, v327, v331)
                v334
        let v342 : string = method10()
        let v345 : (string -> string) = v341.ToString
        let v346 : string = v345 v342
        let _v102 = v346 
        #endif
#if FABLE_COMPILER_PYTHON
        let v349 : US3 option = None
        let _v349 = ref v349 
        let v350 : US3 option ref = _v349 
        let v351 : (US3 option -> US3 option ref) = closure7(v350)
        let v352 : unit = ()
        let v353 : (unit -> unit) = closure8(v91, v351)
        let v354 : unit = (fun () -> v353 (); v352) ()
        let v357 : US3 option = _v349.Value 
        let v368 : US3 = US3_1
        let v369 : US3 = v357 |> Option.defaultValue v368 
        let v409 : System.DateTime =
            match v369 with
            | US3_1 -> (* None *)
                let v405 : System.DateTime = System.DateTime.Now
                v405
            | US3_0(v373) -> (* Some *)
                let v374 : System.DateTime = System.DateTime.Now
                let v377 : (System.DateTime -> int64) = _.Ticks
                let v378 : int64 = v377 v374
                let v381 : int64 = v378 - v373
                let v382 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v383 : System.TimeSpan = v382 v381
                let v386 : (System.TimeSpan -> int32) = _.Hours
                let v387 : int32 = v386 v383
                let v390 : (System.TimeSpan -> int32) = _.Minutes
                let v391 : int32 = v390 v383
                let v394 : (System.TimeSpan -> int32) = _.Seconds
                let v395 : int32 = v394 v383
                let v398 : (System.TimeSpan -> int32) = _.Milliseconds
                let v399 : int32 = v398 v383
                let v402 : System.DateTime = System.DateTime (1, 1, 1, v387, v391, v395, v399)
                v402
        let v410 : string = method10()
        let v413 : (string -> string) = v409.ToString
        let v414 : string = v413 v410
        let _v102 = v414 
        #endif
#else
        let v417 : US3 option = None
        let _v417 = ref v417 
        let v418 : US3 option ref = _v417 
        let v419 : (US3 option -> US3 option ref) = closure7(v418)
        let v420 : unit = ()
        let v421 : (unit -> unit) = closure8(v91, v419)
        let v422 : unit = (fun () -> v421 (); v420) ()
        let v425 : US3 option = _v417.Value 
        let v436 : US3 = US3_1
        let v437 : US3 = v425 |> Option.defaultValue v436 
        let v477 : System.DateTime =
            match v437 with
            | US3_1 -> (* None *)
                let v473 : System.DateTime = System.DateTime.Now
                v473
            | US3_0(v441) -> (* Some *)
                let v442 : System.DateTime = System.DateTime.Now
                let v445 : (System.DateTime -> int64) = _.Ticks
                let v446 : int64 = v445 v442
                let v449 : int64 = v446 - v441
                let v450 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v451 : System.TimeSpan = v450 v449
                let v454 : (System.TimeSpan -> int32) = _.Hours
                let v455 : int32 = v454 v451
                let v458 : (System.TimeSpan -> int32) = _.Minutes
                let v459 : int32 = v458 v451
                let v462 : (System.TimeSpan -> int32) = _.Seconds
                let v463 : int32 = v462 v451
                let v466 : (System.TimeSpan -> int32) = _.Milliseconds
                let v467 : int32 = v466 v451
                let v470 : System.DateTime = System.DateTime (1, 1, 1, v455, v459, v463, v467)
                v470
        let v478 : string = method10()
        let v481 : (string -> string) = v477.ToString
        let v482 : string = v481 v478
        let _v102 = v482 
        #endif
        let v485 : string = _v102 
        
        
        
        
        
        let v555 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v556 : string = method11()
        let _v555 = v556 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v557 : string = method11()
        let _v555 = v557 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v558 : string = method11()
        let _v555 = v558 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v559 : string = method12()
        let _v555 = v559 
        #endif
#if FABLE_COMPILER_PYTHON
        let v560 : string = method12()
        let _v555 = v560 
        #endif
#else
        let v561 : string = method12()
        let _v555 = v561 
        #endif
        let v562 : string = _v555 
        let v567 : string = method13()
        let v568 : Mut4 = {l0 = v567} : Mut4
        let v569 : US0 = US0_0
        let v570 : string = $"%A{v569}"
        let v574 : string = $"{v570}"
        let v577 : unit = ()
        let v578 : (unit -> unit) = closure9(v568, v574)
        let v579 : unit = (fun () -> v578 (); v577) ()
        let v582 : string = v568.l0
        let v583 : (string []) = v582.Split v562 
        let v586 : string = v583.[int 0]
        let v589 : string = method13()
        let v590 : Mut4 = {l0 = v589} : Mut4
        let v591 : US0 = US0_3
        let v592 : string = $"%A{v591}"
        let v596 : string = $"{v592}"
        let v599 : unit = ()
        let v600 : (unit -> unit) = closure9(v590, v596)
        let v601 : unit = (fun () -> v600 (); v599) ()
        let v604 : string = v590.l0
        let v605 : bool = v604.StartsWith v586 
        let v611 : US1 =
            if v605 then
                let v608 : string = "Verbose"
                US1_0(v608)
            else
                US1_1
        let v739 : US1 =
            match v611 with
            | US1_1 -> (* None *)
                let v614 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v615 : string = method11()
                let _v614 = v615 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v616 : string = method11()
                let _v614 = v616 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v617 : string = method11()
                let _v614 = v617 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v618 : string = method12()
                let _v614 = v618 
                #endif
#if FABLE_COMPILER_PYTHON
                let v619 : string = method12()
                let _v614 = v619 
                #endif
#else
                let v620 : string = method12()
                let _v614 = v620 
                #endif
                let v621 : string = _v614 
                let v626 : string = method13()
                let v627 : Mut4 = {l0 = v626} : Mut4
                let v628 : US0 = US0_1
                let v629 : string = $"%A{v628}"
                let v633 : string = $"{v629}"
                let v636 : unit = ()
                let v637 : (unit -> unit) = closure9(v627, v633)
                let v638 : unit = (fun () -> v637 (); v636) ()
                let v641 : string = v627.l0
                let v642 : (string []) = v641.Split v621 
                let v645 : string = v642.[int 0]
                let v648 : string = method13()
                let v649 : Mut4 = {l0 = v648} : Mut4
                let v650 : US0 = US0_3
                let v651 : string = $"%A{v650}"
                let v655 : string = $"{v651}"
                let v658 : unit = ()
                let v659 : (unit -> unit) = closure9(v649, v655)
                let v660 : unit = (fun () -> v659 (); v658) ()
                let v663 : string = v649.l0
                let v664 : bool = v663.StartsWith v645 
                let v670 : US1 =
                    if v664 then
                        let v667 : string = "Debug"
                        US1_0(v667)
                    else
                        US1_1
                match v670 with
                | US1_1 -> (* None *)
                    let v673 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v674 : string = method11()
                    let _v673 = v674 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v675 : string = method11()
                    let _v673 = v675 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v676 : string = method11()
                    let _v673 = v676 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v677 : string = method12()
                    let _v673 = v677 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v678 : string = method12()
                    let _v673 = v678 
                    #endif
#else
                    let v679 : string = method12()
                    let _v673 = v679 
                    #endif
                    let v680 : string = _v673 
                    let v685 : string = method13()
                    let v686 : Mut4 = {l0 = v685} : Mut4
                    let v687 : US0 = US0_2
                    let v688 : string = $"%A{v687}"
                    let v692 : string = $"{v688}"
                    let v695 : unit = ()
                    let v696 : (unit -> unit) = closure9(v686, v692)
                    let v697 : unit = (fun () -> v696 (); v695) ()
                    let v700 : string = v686.l0
                    let v701 : (string []) = v700.Split v680 
                    let v704 : string = v701.[int 0]
                    let v707 : string = method13()
                    let v708 : Mut4 = {l0 = v707} : Mut4
                    let v709 : US0 = US0_3
                    let v710 : string = $"%A{v709}"
                    let v714 : string = $"{v710}"
                    let v717 : unit = ()
                    let v718 : (unit -> unit) = closure9(v708, v714)
                    let v719 : unit = (fun () -> v718 (); v717) ()
                    let v722 : string = v708.l0
                    let v723 : bool = v722.StartsWith v704 
                    let v729 : US1 =
                        if v723 then
                            let v726 : string = "Info"
                            US1_0(v726)
                        else
                            US1_1
                    match v729 with
                    | US1_1 -> (* None *)
                        let v732 : string = "Warning"
                        US1_0(v732)
                    | US1_0(v730) -> (* Some *)
                        US1_0(v730)
                | US1_0(v671) -> (* Some *)
                    US1_0(v671)
            | US1_0(v612) -> (* Some *)
                US1_0(v612)
        let v743 : string =
            match v739 with
            | US1_1 -> (* None *)
                failwith<string> "Option does not have a value."
            | US1_0(v740) -> (* Some *)
                v740
        let v744 : (unit -> string) = v743.ToLower
        let v745 : string = v744 ()
        let v748 : string = v745.PadLeft (7, ' ')
        let v762 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v763 : string = "inline_colorization::color_yellow"
        let v764 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v763 
        let v765 : string = "&*$0"
        let v766 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v748 v765 
        let v767 : string = "inline_colorization::color_reset"
        let v768 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v767 
        let v769 : string = "\"{v764}{v766}{v768}\""
        let v770 : string = @$"format!(" + v769 + ")"
        let v771 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v770 
        let v772 : string = "fable_library_rust::String_::fromString($0)"
        let v773 : string = Fable.Core.RustInterop.emitRustExpr v771 v772 
        let _v762 = v773 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v774 : string = "inline_colorization::color_yellow"
        let v775 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v774 
        let v776 : string = "&*$0"
        let v777 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v748 v776 
        let v778 : string = "inline_colorization::color_reset"
        let v779 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v778 
        let v780 : string = "\"{v775}{v777}{v779}\""
        let v781 : string = @$"format!(" + v780 + ")"
        let v782 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v781 
        let v783 : string = "fable_library_rust::String_::fromString($0)"
        let v784 : string = Fable.Core.RustInterop.emitRustExpr v782 v783 
        let _v762 = v784 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v785 : string = "inline_colorization::color_yellow"
        let v786 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v785 
        let v787 : string = "&*$0"
        let v788 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v748 v787 
        let v789 : string = "inline_colorization::color_reset"
        let v790 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v789 
        let v791 : string = "\"{v786}{v788}{v790}\""
        let v792 : string = @$"format!(" + v791 + ")"
        let v793 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v792 
        let v794 : string = "fable_library_rust::String_::fromString($0)"
        let v795 : string = Fable.Core.RustInterop.emitRustExpr v793 v794 
        let _v762 = v795 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v796 : string = "\u001b[93m"
        let v797 : string = method14()
        let v798 : string = v796 + v748 
        let v799 : string = v798 + v797 
        let _v762 = v799 
        #endif
#if FABLE_COMPILER_PYTHON
        let v800 : string = "\u001b[93m"
        let v801 : string = method14()
        let v802 : string = v800 + v748 
        let v803 : string = v802 + v801 
        let _v762 = v803 
        #endif
#else
        let v804 : string = "\u001b[93m"
        let v805 : string = method14()
        let v806 : string = v804 + v748 
        let v807 : string = v806 + v805 
        let _v762 = v807 
        #endif
        let v808 : string = _v762 
        let v814 : int64 = v87.l0
        let v815 : string = method15(v1)
        let v816 : string = method15(v0)
        let v817 : string = method13()
        let v818 : Mut4 = {l0 = v817} : Mut4
        let v819 : string = "{ "
        let v820 : string = $"{v819}"
        let v823 : unit = ()
        let v824 : (unit -> unit) = closure9(v818, v820)
        let v825 : unit = (fun () -> v824 (); v823) ()
        let v828 : string = "old_path"
        let v829 : string = $"{v828}"
        let v832 : unit = ()
        let v833 : (unit -> unit) = closure9(v818, v829)
        let v834 : unit = (fun () -> v833 (); v832) ()
        let v837 : string = " = "
        let v838 : string = $"{v837}"
        let v841 : unit = ()
        let v842 : (unit -> unit) = closure9(v818, v838)
        let v843 : unit = (fun () -> v842 (); v841) ()
        let v846 : string = $"{v815}"
        let v849 : unit = ()
        let v850 : (unit -> unit) = closure9(v818, v846)
        let v851 : unit = (fun () -> v850 (); v849) ()
        let v854 : string = "; "
        let v855 : string = $"{v854}"
        let v858 : unit = ()
        let v859 : (unit -> unit) = closure9(v818, v855)
        let v860 : unit = (fun () -> v859 (); v858) ()
        let v863 : string = "new_path"
        let v864 : string = $"{v863}"
        let v867 : unit = ()
        let v868 : (unit -> unit) = closure9(v818, v864)
        let v869 : unit = (fun () -> v868 (); v867) ()
        let v872 : string = $"{v837}"
        let v875 : unit = ()
        let v876 : (unit -> unit) = closure9(v818, v872)
        let v877 : unit = (fun () -> v876 (); v875) ()
        let v880 : string = $"{v816}"
        let v883 : unit = ()
        let v884 : (unit -> unit) = closure9(v818, v880)
        let v885 : unit = (fun () -> v884 (); v883) ()
        let v888 : string = $"{v854}"
        let v891 : unit = ()
        let v892 : (unit -> unit) = closure9(v818, v888)
        let v893 : unit = (fun () -> v892 (); v891) ()
        let v896 : string = "ex"
        let v897 : string = $"{v896}"
        let v900 : unit = ()
        let v901 : (unit -> unit) = closure9(v818, v897)
        let v902 : unit = (fun () -> v901 (); v900) ()
        let v905 : string = $"{v837}"
        let v908 : unit = ()
        let v909 : (unit -> unit) = closure9(v818, v905)
        let v910 : unit = (fun () -> v909 (); v908) ()
        let v913 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v914 : string = "format!(\"{:#?}\", $0)"
        let v915 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v914 
        let v916 : string = "fable_library_rust::String_::fromString($0)"
        let v917 : string = Fable.Core.RustInterop.emitRustExpr v915 v916 
        let _v913 = v917 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v918 : string = "format!(\"{:#?}\", $0)"
        let v919 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v918 
        let v920 : string = "fable_library_rust::String_::fromString($0)"
        let v921 : string = Fable.Core.RustInterop.emitRustExpr v919 v920 
        let _v913 = v921 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v922 : string = "format!(\"{:#?}\", $0)"
        let v923 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v922 
        let v924 : string = "fable_library_rust::String_::fromString($0)"
        let v925 : string = Fable.Core.RustInterop.emitRustExpr v923 v924 
        let _v913 = v925 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v926 : string = $"%A{v2}"
        let _v913 = v926 
        #endif
#if FABLE_COMPILER_PYTHON
        let v929 : string = $"%A{v2}"
        let _v913 = v929 
        #endif
#else
        let v932 : string = $"%A{v2}"
        let _v913 = v932 
        #endif
        let v935 : string = _v913 
        let v940 : string = $"{v935}"
        let v943 : unit = ()
        let v944 : (unit -> unit) = closure9(v818, v940)
        let v945 : unit = (fun () -> v944 (); v943) ()
        let v948 : string = " }"
        let v949 : string = $"{v948}"
        let v952 : unit = ()
        let v953 : (unit -> unit) = closure9(v818, v949)
        let v954 : unit = (fun () -> v953 (); v952) ()
        let v957 : string = v818.l0
        let v958 : (unit -> string) = closure31()
        let v959 : string = $"{v485} {v808} #{v814} %s{v958 ()} / {v957}"
        let v962 : char list = []
        let v963 : (char list -> (char [])) = List.toArray
        let v964 : (char []) = v963 v962
        let v967 : string = v959.TrimStart v964 
        let v985 : char list = []
        let v986 : char list = '/' :: v985 
        let v989 : char list = ' ' :: v986 
        let v992 : (char list -> (char [])) = List.toArray
        let v993 : (char []) = v992 v989
        let v996 : string = v967.TrimEnd v993 
        let v1014 : (string -> unit) = closure11()
        let v1015 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v1016 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v996 v1016 
        let _v1015 = () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v1017 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v996 v1017 
        let _v1015 = () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v1018 : string = $"near_sdk::log!(\"{{}}\", $0)"
        Fable.Core.RustInterop.emitRustExpr v996 v1018 
        let _v1015 = () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        v1014 v996
        let _v1015 = () 
        #endif
#if FABLE_COMPILER_PYTHON
        v1014 v996
        let _v1015 = () 
        #endif
#else
        v1014 v996
        let _v1015 = () 
        #endif
        _v1015 
        let v1019 : (string -> unit) = v19.l0
        v1019 v996
and method22 (v0 : string, v1 : string, v2 : int64) : Async<int64> =
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
        let v25 : (unit -> unit) = closure30(v0, v1, v21)
        let v26 : unit = (fun () -> v25 (); v24) ()
        ()
    let v1044 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1045 : Async<unit> = null |> unbox<Async<unit>>
    let _v1044 = v1045 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1048 : Async<unit> = null |> unbox<Async<unit>>
    let _v1044 = v1048 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1051 : Async<unit> = null |> unbox<Async<unit>>
    let _v1044 = v1051 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1054 : Async<unit> = null |> unbox<Async<unit>>
    let _v1044 = v1054 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1057 : Async<unit> = null |> unbox<Async<unit>>
    let _v1044 = v1057 
    #endif
#else
    let v1060 : (int32 -> Async<unit>) = Async.Sleep
    let v1061 : Async<unit> = v1060 10
    let _v1044 = v1061 
    #endif
    let v1062 : Async<unit> = _v1044 
    do! v1062 
    let v1067 : int64 = v2 + 1L
    let v1068 : Async<int64> = method22(v0, v1, v1067)
    return! v1068 
    (*
    *)
    }
    |> fun x -> _v19 <- Some x
    let v1069 : Async<int64> = match _v19 with Some x -> x | None -> failwith "async.new_async_unit / _v19=None"
    let _v3 = v1069 
    #endif
    let v1070 : Async<int64> = _v3 
    v1070
and closure29 (v0 : string) (v1 : string) : Async<int64> =
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
    let v19 : Async<int64> = method22(v0, v1, v18)
    let _v2 = v19 
    #endif
    let v20 : Async<int64> = _v2 
    v20
and closure28 () (v0 : string) : (string -> Async<int64>) =
    closure29(v0)
and closure33 () (v0 : int64) : US9 =
    US9_0(v0)
and closure34 () (v0 : exn) : US9 =
    US9_1(v0)
and closure36 () () : string =
    let v0 : string = "async.run_with_timeout_async"
    v0
and closure35 () () : unit =
    let v0 : unit = ()
    let v1 : (unit -> unit) = closure0()
    let v2 : unit = (fun () -> v1 (); v0) ()
    let struct (v15 : Mut0, v16 : Mut1, v17 : Mut2, v18 : Mut3, v19 : int64 option) = State.trace_state.Value
    let v30 : unit = ()
    let v31 : unit = (fun () -> v1 (); v30) ()
    let struct (v44 : Mut0, v45 : Mut1, v46 : Mut2, v47 : Mut3, v48 : int64 option) = State.trace_state.Value
    let v59 : US0 = v47.l0
    let v60 : bool = v46.l0
    let v61 : bool = v60 = false
    let v64 : bool =
        if v61 then
            false
        else
            let v62 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v59
            let v63 : bool = 0 >= v62
            v63
    if v64 then
        let v65 : unit = ()
        let v66 : (unit -> unit) = closure6(v15)
        let v67 : unit = (fun () -> v66 (); v65) ()
        let v70 : unit = ()
        let v71 : unit = (fun () -> v1 (); v70) ()
        let struct (v84 : Mut0, v85 : Mut1, v86 : Mut2, v87 : Mut3, v88 : int64 option) = State.trace_state.Value
        let v99 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v100 : US3 option = None
        let _v100 = ref v100 
        let v101 : US3 option ref = _v100 
        let v102 : (US3 option -> US3 option ref) = closure7(v101)
        let v103 : unit = ()
        let v104 : (unit -> unit) = closure8(v88, v102)
        let v105 : unit = (fun () -> v104 (); v103) ()
        let v108 : US3 option = _v100.Value 
        let v119 : US3 = US3_1
        let v120 : US3 = v108 |> Option.defaultValue v119 
        let v160 : System.DateTime =
            match v120 with
            | US3_1 -> (* None *)
                let v156 : System.DateTime = System.DateTime.Now
                v156
            | US3_0(v124) -> (* Some *)
                let v125 : System.DateTime = System.DateTime.Now
                let v128 : (System.DateTime -> int64) = _.Ticks
                let v129 : int64 = v128 v125
                let v132 : int64 = v129 - v124
                let v133 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v134 : System.TimeSpan = v133 v132
                let v137 : (System.TimeSpan -> int32) = _.Hours
                let v138 : int32 = v137 v134
                let v141 : (System.TimeSpan -> int32) = _.Minutes
                let v142 : int32 = v141 v134
                let v145 : (System.TimeSpan -> int32) = _.Seconds
                let v146 : int32 = v145 v134
                let v149 : (System.TimeSpan -> int32) = _.Milliseconds
                let v150 : int32 = v149 v134
                let v153 : System.DateTime = System.DateTime (1, 1, 1, v138, v142, v146, v150)
                v153
        let v161 : string = method9()
        let v164 : (string -> string) = v160.ToString
        let v165 : string = v164 v161
        let _v99 = v165 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v168 : US3 option = None
        let _v168 = ref v168 
        let v169 : US3 option ref = _v168 
        let v170 : (US3 option -> US3 option ref) = closure7(v169)
        let v171 : unit = ()
        let v172 : (unit -> unit) = closure8(v88, v170)
        let v173 : unit = (fun () -> v172 (); v171) ()
        let v176 : US3 option = _v168.Value 
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
        let _v99 = v233 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v236 : string = $"near_sdk::env::block_timestamp()"
        let v237 : uint64 = Fable.Core.RustInterop.emitRustExpr () v236 
        let v238 : US3 option = None
        let _v238 = ref v238 
        let v239 : US3 option ref = _v238 
        let v240 : (US3 option -> US3 option ref) = closure7(v239)
        let v241 : unit = ()
        let v242 : (unit -> unit) = closure8(v88, v240)
        let v243 : unit = (fun () -> v242 (); v241) ()
        let v246 : US3 option = _v238.Value 
        let v257 : US3 = US3_1
        let v258 : US3 = v246 |> Option.defaultValue v257 
        let v267 : uint64 =
            match v258 with
            | US3_1 -> (* None *)
                v237
            | US3_0(v262) -> (* Some *)
                let v263 : (int64 -> uint64) = uint64
                let v264 : uint64 = v263 v262
                let v265 : uint64 = v237 - v264
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
        let _v99 = v277 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v278 : US3 option = None
        let _v278 = ref v278 
        let v279 : US3 option ref = _v278 
        let v280 : (US3 option -> US3 option ref) = closure7(v279)
        let v281 : unit = ()
        let v282 : (unit -> unit) = closure8(v88, v280)
        let v283 : unit = (fun () -> v282 (); v281) ()
        let v286 : US3 option = _v278.Value 
        let v297 : US3 = US3_1
        let v298 : US3 = v286 |> Option.defaultValue v297 
        let v338 : System.DateTime =
            match v298 with
            | US3_1 -> (* None *)
                let v334 : System.DateTime = System.DateTime.Now
                v334
            | US3_0(v302) -> (* Some *)
                let v303 : System.DateTime = System.DateTime.Now
                let v306 : (System.DateTime -> int64) = _.Ticks
                let v307 : int64 = v306 v303
                let v310 : int64 = v307 - v302
                let v311 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v312 : System.TimeSpan = v311 v310
                let v315 : (System.TimeSpan -> int32) = _.Hours
                let v316 : int32 = v315 v312
                let v319 : (System.TimeSpan -> int32) = _.Minutes
                let v320 : int32 = v319 v312
                let v323 : (System.TimeSpan -> int32) = _.Seconds
                let v324 : int32 = v323 v312
                let v327 : (System.TimeSpan -> int32) = _.Milliseconds
                let v328 : int32 = v327 v312
                let v331 : System.DateTime = System.DateTime (1, 1, 1, v316, v320, v324, v328)
                v331
        let v339 : string = method10()
        let v342 : (string -> string) = v338.ToString
        let v343 : string = v342 v339
        let _v99 = v343 
        #endif
#if FABLE_COMPILER_PYTHON
        let v346 : US3 option = None
        let _v346 = ref v346 
        let v347 : US3 option ref = _v346 
        let v348 : (US3 option -> US3 option ref) = closure7(v347)
        let v349 : unit = ()
        let v350 : (unit -> unit) = closure8(v88, v348)
        let v351 : unit = (fun () -> v350 (); v349) ()
        let v354 : US3 option = _v346.Value 
        let v365 : US3 = US3_1
        let v366 : US3 = v354 |> Option.defaultValue v365 
        let v406 : System.DateTime =
            match v366 with
            | US3_1 -> (* None *)
                let v402 : System.DateTime = System.DateTime.Now
                v402
            | US3_0(v370) -> (* Some *)
                let v371 : System.DateTime = System.DateTime.Now
                let v374 : (System.DateTime -> int64) = _.Ticks
                let v375 : int64 = v374 v371
                let v378 : int64 = v375 - v370
                let v379 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v380 : System.TimeSpan = v379 v378
                let v383 : (System.TimeSpan -> int32) = _.Hours
                let v384 : int32 = v383 v380
                let v387 : (System.TimeSpan -> int32) = _.Minutes
                let v388 : int32 = v387 v380
                let v391 : (System.TimeSpan -> int32) = _.Seconds
                let v392 : int32 = v391 v380
                let v395 : (System.TimeSpan -> int32) = _.Milliseconds
                let v396 : int32 = v395 v380
                let v399 : System.DateTime = System.DateTime (1, 1, 1, v384, v388, v392, v396)
                v399
        let v407 : string = method10()
        let v410 : (string -> string) = v406.ToString
        let v411 : string = v410 v407
        let _v99 = v411 
        #endif
#else
        let v414 : US3 option = None
        let _v414 = ref v414 
        let v415 : US3 option ref = _v414 
        let v416 : (US3 option -> US3 option ref) = closure7(v415)
        let v417 : unit = ()
        let v418 : (unit -> unit) = closure8(v88, v416)
        let v419 : unit = (fun () -> v418 (); v417) ()
        let v422 : US3 option = _v414.Value 
        let v433 : US3 = US3_1
        let v434 : US3 = v422 |> Option.defaultValue v433 
        let v474 : System.DateTime =
            match v434 with
            | US3_1 -> (* None *)
                let v470 : System.DateTime = System.DateTime.Now
                v470
            | US3_0(v438) -> (* Some *)
                let v439 : System.DateTime = System.DateTime.Now
                let v442 : (System.DateTime -> int64) = _.Ticks
                let v443 : int64 = v442 v439
                let v446 : int64 = v443 - v438
                let v447 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v448 : System.TimeSpan = v447 v446
                let v451 : (System.TimeSpan -> int32) = _.Hours
                let v452 : int32 = v451 v448
                let v455 : (System.TimeSpan -> int32) = _.Minutes
                let v456 : int32 = v455 v448
                let v459 : (System.TimeSpan -> int32) = _.Seconds
                let v460 : int32 = v459 v448
                let v463 : (System.TimeSpan -> int32) = _.Milliseconds
                let v464 : int32 = v463 v448
                let v467 : System.DateTime = System.DateTime (1, 1, 1, v452, v456, v460, v464)
                v467
        let v475 : string = method10()
        let v478 : (string -> string) = v474.ToString
        let v479 : string = v478 v475
        let _v99 = v479 
        #endif
        let v482 : string = _v99 
        
        
        
        
        
        let v552 : string = "Verbose"
        let v553 : (unit -> string) = v552.ToLower
        let v554 : string = v553 ()
        let v557 : string = v554.PadLeft (7, ' ')
        let v571 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v572 : string = "inline_colorization::color_bright_black"
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
        let v583 : string = "inline_colorization::color_bright_black"
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
        let v594 : string = "inline_colorization::color_bright_black"
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
        let v605 : string = "\u001b[90m"
        let v606 : string = method14()
        let v607 : string = v605 + v557 
        let v608 : string = v607 + v606 
        let _v571 = v608 
        #endif
#if FABLE_COMPILER_PYTHON
        let v609 : string = "\u001b[90m"
        let v610 : string = method14()
        let v611 : string = v609 + v557 
        let v612 : string = v611 + v610 
        let _v571 = v612 
        #endif
#else
        let v613 : string = "\u001b[90m"
        let v614 : string = method14()
        let v615 : string = v613 + v557 
        let v616 : string = v615 + v614 
        let _v571 = v616 
        #endif
        let v617 : string = _v571 
        let v623 : int64 = v84.l0
        let v624 : string = method13()
        let v625 : Mut4 = {l0 = v624} : Mut4
        let v626 : string = "{ "
        let v627 : string = $"{v626}"
        let v630 : unit = ()
        let v631 : (unit -> unit) = closure9(v625, v627)
        let v632 : unit = (fun () -> v631 (); v630) ()
        let v635 : string = "timeout"
        let v636 : string = $"{v635}"
        let v639 : unit = ()
        let v640 : (unit -> unit) = closure9(v625, v636)
        let v641 : unit = (fun () -> v640 (); v639) ()
        let v644 : string = " = "
        let v645 : string = $"{v644}"
        let v648 : unit = ()
        let v649 : (unit -> unit) = closure9(v625, v645)
        let v650 : unit = (fun () -> v649 (); v648) ()
        let v653 : string = $"{1000}"
        let v656 : unit = ()
        let v657 : (unit -> unit) = closure9(v625, v653)
        let v658 : unit = (fun () -> v657 (); v656) ()
        let v661 : string = " }"
        let v662 : string = $"{v661}"
        let v665 : unit = ()
        let v666 : (unit -> unit) = closure9(v625, v662)
        let v667 : unit = (fun () -> v666 (); v665) ()
        let v670 : string = v625.l0
        let v671 : (unit -> string) = closure36()
        let v672 : string = $"{v482} {v617} #{v623} %s{v671 ()} / {v670}"
        let v675 : char list = []
        let v676 : (char list -> (char [])) = List.toArray
        let v677 : (char []) = v676 v675
        let v680 : string = v672.TrimStart v677 
        let v698 : char list = []
        let v699 : char list = '/' :: v698 
        let v702 : char list = ' ' :: v699 
        let v705 : (char list -> (char [])) = List.toArray
        let v706 : (char []) = v705 v702
        let v709 : string = v680.TrimEnd v706 
        let v727 : (string -> unit) = closure11()
        let v728 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v729 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v709 v729 
        let _v728 = () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v730 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v709 v730 
        let _v728 = () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v731 : string = $"near_sdk::log!(\"{{}}\", $0)"
        Fable.Core.RustInterop.emitRustExpr v709 v731 
        let _v728 = () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        v727 v709
        let _v728 = () 
        #endif
#if FABLE_COMPILER_PYTHON
        v727 v709
        let _v728 = () 
        #endif
#else
        v727 v709
        let _v728 = () 
        #endif
        _v728 
        let v732 : (string -> unit) = v16.l0
        v732 v709
and closure38 () () : string =
    let v0 : string = $"async.run_with_timeout_async**"
    v0
and closure37 (v0 : exn) () : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure0()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v16 : Mut0, v17 : Mut1, v18 : Mut2, v19 : Mut3, v20 : int64 option) = State.trace_state.Value
    let v31 : unit = ()
    let v32 : unit = (fun () -> v2 (); v31) ()
    let struct (v45 : Mut0, v46 : Mut1, v47 : Mut2, v48 : Mut3, v49 : int64 option) = State.trace_state.Value
    let v60 : US0 = v48.l0
    let v61 : bool = v47.l0
    let v62 : bool = v61 = false
    let v65 : bool =
        if v62 then
            false
        else
            let v63 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v60
            let v64 : bool = 4 >= v63
            v64
    if v65 then
        let v66 : unit = ()
        let v67 : (unit -> unit) = closure6(v16)
        let v68 : unit = (fun () -> v67 (); v66) ()
        let v71 : unit = ()
        let v72 : unit = (fun () -> v2 (); v71) ()
        let struct (v85 : Mut0, v86 : Mut1, v87 : Mut2, v88 : Mut3, v89 : int64 option) = State.trace_state.Value
        let v100 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v101 : US3 option = None
        let _v101 = ref v101 
        let v102 : US3 option ref = _v101 
        let v103 : (US3 option -> US3 option ref) = closure7(v102)
        let v104 : unit = ()
        let v105 : (unit -> unit) = closure8(v89, v103)
        let v106 : unit = (fun () -> v105 (); v104) ()
        let v109 : US3 option = _v101.Value 
        let v120 : US3 = US3_1
        let v121 : US3 = v109 |> Option.defaultValue v120 
        let v161 : System.DateTime =
            match v121 with
            | US3_1 -> (* None *)
                let v157 : System.DateTime = System.DateTime.Now
                v157
            | US3_0(v125) -> (* Some *)
                let v126 : System.DateTime = System.DateTime.Now
                let v129 : (System.DateTime -> int64) = _.Ticks
                let v130 : int64 = v129 v126
                let v133 : int64 = v130 - v125
                let v134 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v135 : System.TimeSpan = v134 v133
                let v138 : (System.TimeSpan -> int32) = _.Hours
                let v139 : int32 = v138 v135
                let v142 : (System.TimeSpan -> int32) = _.Minutes
                let v143 : int32 = v142 v135
                let v146 : (System.TimeSpan -> int32) = _.Seconds
                let v147 : int32 = v146 v135
                let v150 : (System.TimeSpan -> int32) = _.Milliseconds
                let v151 : int32 = v150 v135
                let v154 : System.DateTime = System.DateTime (1, 1, 1, v139, v143, v147, v151)
                v154
        let v162 : string = method9()
        let v165 : (string -> string) = v161.ToString
        let v166 : string = v165 v162
        let _v100 = v166 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v169 : US3 option = None
        let _v169 = ref v169 
        let v170 : US3 option ref = _v169 
        let v171 : (US3 option -> US3 option ref) = closure7(v170)
        let v172 : unit = ()
        let v173 : (unit -> unit) = closure8(v89, v171)
        let v174 : unit = (fun () -> v173 (); v172) ()
        let v177 : US3 option = _v169.Value 
        let v188 : US3 = US3_1
        let v189 : US3 = v177 |> Option.defaultValue v188 
        let v229 : System.DateTime =
            match v189 with
            | US3_1 -> (* None *)
                let v225 : System.DateTime = System.DateTime.Now
                v225
            | US3_0(v193) -> (* Some *)
                let v194 : System.DateTime = System.DateTime.Now
                let v197 : (System.DateTime -> int64) = _.Ticks
                let v198 : int64 = v197 v194
                let v201 : int64 = v198 - v193
                let v202 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v203 : System.TimeSpan = v202 v201
                let v206 : (System.TimeSpan -> int32) = _.Hours
                let v207 : int32 = v206 v203
                let v210 : (System.TimeSpan -> int32) = _.Minutes
                let v211 : int32 = v210 v203
                let v214 : (System.TimeSpan -> int32) = _.Seconds
                let v215 : int32 = v214 v203
                let v218 : (System.TimeSpan -> int32) = _.Milliseconds
                let v219 : int32 = v218 v203
                let v222 : System.DateTime = System.DateTime (1, 1, 1, v207, v211, v215, v219)
                v222
        let v230 : string = method9()
        let v233 : (string -> string) = v229.ToString
        let v234 : string = v233 v230
        let _v100 = v234 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v237 : string = $"near_sdk::env::block_timestamp()"
        let v238 : uint64 = Fable.Core.RustInterop.emitRustExpr () v237 
        let v239 : US3 option = None
        let _v239 = ref v239 
        let v240 : US3 option ref = _v239 
        let v241 : (US3 option -> US3 option ref) = closure7(v240)
        let v242 : unit = ()
        let v243 : (unit -> unit) = closure8(v89, v241)
        let v244 : unit = (fun () -> v243 (); v242) ()
        let v247 : US3 option = _v239.Value 
        let v258 : US3 = US3_1
        let v259 : US3 = v247 |> Option.defaultValue v258 
        let v268 : uint64 =
            match v259 with
            | US3_1 -> (* None *)
                v238
            | US3_0(v263) -> (* Some *)
                let v264 : (int64 -> uint64) = uint64
                let v265 : uint64 = v264 v263
                let v266 : uint64 = v238 - v265
                v266
        let v269 : uint64 = v268 / 1000000000UL
        let v270 : uint64 = v269 % 60UL
        let v271 : uint64 = v269 / 60UL
        let v272 : uint64 = v271 % 60UL
        let v273 : uint64 = v269 / 3600UL
        let v274 : uint64 = v273 % 24UL
        let v275 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
        let v276 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v274, v272, v270) v275 
        let v277 : string = "fable_library_rust::String_::fromString($0)"
        let v278 : string = Fable.Core.RustInterop.emitRustExpr v276 v277 
        let _v100 = v278 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v279 : US3 option = None
        let _v279 = ref v279 
        let v280 : US3 option ref = _v279 
        let v281 : (US3 option -> US3 option ref) = closure7(v280)
        let v282 : unit = ()
        let v283 : (unit -> unit) = closure8(v89, v281)
        let v284 : unit = (fun () -> v283 (); v282) ()
        let v287 : US3 option = _v279.Value 
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
        let v340 : string = method10()
        let v343 : (string -> string) = v339.ToString
        let v344 : string = v343 v340
        let _v100 = v344 
        #endif
#if FABLE_COMPILER_PYTHON
        let v347 : US3 option = None
        let _v347 = ref v347 
        let v348 : US3 option ref = _v347 
        let v349 : (US3 option -> US3 option ref) = closure7(v348)
        let v350 : unit = ()
        let v351 : (unit -> unit) = closure8(v89, v349)
        let v352 : unit = (fun () -> v351 (); v350) ()
        let v355 : US3 option = _v347.Value 
        let v366 : US3 = US3_1
        let v367 : US3 = v355 |> Option.defaultValue v366 
        let v407 : System.DateTime =
            match v367 with
            | US3_1 -> (* None *)
                let v403 : System.DateTime = System.DateTime.Now
                v403
            | US3_0(v371) -> (* Some *)
                let v372 : System.DateTime = System.DateTime.Now
                let v375 : (System.DateTime -> int64) = _.Ticks
                let v376 : int64 = v375 v372
                let v379 : int64 = v376 - v371
                let v380 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v381 : System.TimeSpan = v380 v379
                let v384 : (System.TimeSpan -> int32) = _.Hours
                let v385 : int32 = v384 v381
                let v388 : (System.TimeSpan -> int32) = _.Minutes
                let v389 : int32 = v388 v381
                let v392 : (System.TimeSpan -> int32) = _.Seconds
                let v393 : int32 = v392 v381
                let v396 : (System.TimeSpan -> int32) = _.Milliseconds
                let v397 : int32 = v396 v381
                let v400 : System.DateTime = System.DateTime (1, 1, 1, v385, v389, v393, v397)
                v400
        let v408 : string = method10()
        let v411 : (string -> string) = v407.ToString
        let v412 : string = v411 v408
        let _v100 = v412 
        #endif
#else
        let v415 : US3 option = None
        let _v415 = ref v415 
        let v416 : US3 option ref = _v415 
        let v417 : (US3 option -> US3 option ref) = closure7(v416)
        let v418 : unit = ()
        let v419 : (unit -> unit) = closure8(v89, v417)
        let v420 : unit = (fun () -> v419 (); v418) ()
        let v423 : US3 option = _v415.Value 
        let v434 : US3 = US3_1
        let v435 : US3 = v423 |> Option.defaultValue v434 
        let v475 : System.DateTime =
            match v435 with
            | US3_1 -> (* None *)
                let v471 : System.DateTime = System.DateTime.Now
                v471
            | US3_0(v439) -> (* Some *)
                let v440 : System.DateTime = System.DateTime.Now
                let v443 : (System.DateTime -> int64) = _.Ticks
                let v444 : int64 = v443 v440
                let v447 : int64 = v444 - v439
                let v448 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v449 : System.TimeSpan = v448 v447
                let v452 : (System.TimeSpan -> int32) = _.Hours
                let v453 : int32 = v452 v449
                let v456 : (System.TimeSpan -> int32) = _.Minutes
                let v457 : int32 = v456 v449
                let v460 : (System.TimeSpan -> int32) = _.Seconds
                let v461 : int32 = v460 v449
                let v464 : (System.TimeSpan -> int32) = _.Milliseconds
                let v465 : int32 = v464 v449
                let v468 : System.DateTime = System.DateTime (1, 1, 1, v453, v457, v461, v465)
                v468
        let v476 : string = method10()
        let v479 : (string -> string) = v475.ToString
        let v480 : string = v479 v476
        let _v100 = v480 
        #endif
        let v483 : string = _v100 
        
        
        
        
        
        let v553 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v554 : string = method11()
        let _v553 = v554 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v555 : string = method11()
        let _v553 = v555 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v556 : string = method11()
        let _v553 = v556 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v557 : string = method12()
        let _v553 = v557 
        #endif
#if FABLE_COMPILER_PYTHON
        let v558 : string = method12()
        let _v553 = v558 
        #endif
#else
        let v559 : string = method12()
        let _v553 = v559 
        #endif
        let v560 : string = _v553 
        let v565 : string = method13()
        let v566 : Mut4 = {l0 = v565} : Mut4
        let v567 : US0 = US0_0
        let v568 : string = $"%A{v567}"
        let v572 : string = $"{v568}"
        let v575 : unit = ()
        let v576 : (unit -> unit) = closure9(v566, v572)
        let v577 : unit = (fun () -> v576 (); v575) ()
        let v580 : string = v566.l0
        let v581 : (string []) = v580.Split v560 
        let v584 : string = v581.[int 0]
        let v587 : string = method13()
        let v588 : Mut4 = {l0 = v587} : Mut4
        let v589 : US0 = US0_4
        let v590 : string = $"%A{v589}"
        let v594 : string = $"{v590}"
        let v597 : unit = ()
        let v598 : (unit -> unit) = closure9(v588, v594)
        let v599 : unit = (fun () -> v598 (); v597) ()
        let v602 : string = v588.l0
        let v603 : bool = v602.StartsWith v584 
        let v609 : US1 =
            if v603 then
                let v606 : string = "Verbose"
                US1_0(v606)
            else
                US1_1
        let v798 : US1 =
            match v609 with
            | US1_1 -> (* None *)
                let v612 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v613 : string = method11()
                let _v612 = v613 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v614 : string = method11()
                let _v612 = v614 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v615 : string = method11()
                let _v612 = v615 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v616 : string = method12()
                let _v612 = v616 
                #endif
#if FABLE_COMPILER_PYTHON
                let v617 : string = method12()
                let _v612 = v617 
                #endif
#else
                let v618 : string = method12()
                let _v612 = v618 
                #endif
                let v619 : string = _v612 
                let v624 : string = method13()
                let v625 : Mut4 = {l0 = v624} : Mut4
                let v626 : US0 = US0_1
                let v627 : string = $"%A{v626}"
                let v631 : string = $"{v627}"
                let v634 : unit = ()
                let v635 : (unit -> unit) = closure9(v625, v631)
                let v636 : unit = (fun () -> v635 (); v634) ()
                let v639 : string = v625.l0
                let v640 : (string []) = v639.Split v619 
                let v643 : string = v640.[int 0]
                let v646 : string = method13()
                let v647 : Mut4 = {l0 = v646} : Mut4
                let v648 : US0 = US0_4
                let v649 : string = $"%A{v648}"
                let v653 : string = $"{v649}"
                let v656 : unit = ()
                let v657 : (unit -> unit) = closure9(v647, v653)
                let v658 : unit = (fun () -> v657 (); v656) ()
                let v661 : string = v647.l0
                let v662 : bool = v661.StartsWith v643 
                let v668 : US1 =
                    if v662 then
                        let v665 : string = "Debug"
                        US1_0(v665)
                    else
                        US1_1
                match v668 with
                | US1_1 -> (* None *)
                    let v671 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v672 : string = method11()
                    let _v671 = v672 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v673 : string = method11()
                    let _v671 = v673 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v674 : string = method11()
                    let _v671 = v674 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v675 : string = method12()
                    let _v671 = v675 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v676 : string = method12()
                    let _v671 = v676 
                    #endif
#else
                    let v677 : string = method12()
                    let _v671 = v677 
                    #endif
                    let v678 : string = _v671 
                    let v683 : string = method13()
                    let v684 : Mut4 = {l0 = v683} : Mut4
                    let v685 : US0 = US0_2
                    let v686 : string = $"%A{v685}"
                    let v690 : string = $"{v686}"
                    let v693 : unit = ()
                    let v694 : (unit -> unit) = closure9(v684, v690)
                    let v695 : unit = (fun () -> v694 (); v693) ()
                    let v698 : string = v684.l0
                    let v699 : (string []) = v698.Split v678 
                    let v702 : string = v699.[int 0]
                    let v705 : string = method13()
                    let v706 : Mut4 = {l0 = v705} : Mut4
                    let v707 : US0 = US0_4
                    let v708 : string = $"%A{v707}"
                    let v712 : string = $"{v708}"
                    let v715 : unit = ()
                    let v716 : (unit -> unit) = closure9(v706, v712)
                    let v717 : unit = (fun () -> v716 (); v715) ()
                    let v720 : string = v706.l0
                    let v721 : bool = v720.StartsWith v702 
                    let v727 : US1 =
                        if v721 then
                            let v724 : string = "Info"
                            US1_0(v724)
                        else
                            US1_1
                    match v727 with
                    | US1_1 -> (* None *)
                        let v730 : unit = ()
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v731 : string = method11()
                        let _v730 = v731 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        let v732 : string = method11()
                        let _v730 = v732 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        let v733 : string = method11()
                        let _v730 = v733 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        let v734 : string = method12()
                        let _v730 = v734 
                        #endif
#if FABLE_COMPILER_PYTHON
                        let v735 : string = method12()
                        let _v730 = v735 
                        #endif
#else
                        let v736 : string = method12()
                        let _v730 = v736 
                        #endif
                        let v737 : string = _v730 
                        let v742 : string = method13()
                        let v743 : Mut4 = {l0 = v742} : Mut4
                        let v744 : US0 = US0_3
                        let v745 : string = $"%A{v744}"
                        let v749 : string = $"{v745}"
                        let v752 : unit = ()
                        let v753 : (unit -> unit) = closure9(v743, v749)
                        let v754 : unit = (fun () -> v753 (); v752) ()
                        let v757 : string = v743.l0
                        let v758 : (string []) = v757.Split v737 
                        let v761 : string = v758.[int 0]
                        let v764 : string = method13()
                        let v765 : Mut4 = {l0 = v764} : Mut4
                        let v766 : US0 = US0_4
                        let v767 : string = $"%A{v766}"
                        let v771 : string = $"{v767}"
                        let v774 : unit = ()
                        let v775 : (unit -> unit) = closure9(v765, v771)
                        let v776 : unit = (fun () -> v775 (); v774) ()
                        let v779 : string = v765.l0
                        let v780 : bool = v779.StartsWith v761 
                        let v786 : US1 =
                            if v780 then
                                let v783 : string = "Warning"
                                US1_0(v783)
                            else
                                US1_1
                        match v786 with
                        | US1_1 -> (* None *)
                            let v789 : string = "Critical"
                            US1_0(v789)
                        | US1_0(v787) -> (* Some *)
                            US1_0(v787)
                    | US1_0(v728) -> (* Some *)
                        US1_0(v728)
                | US1_0(v669) -> (* Some *)
                    US1_0(v669)
            | US1_0(v610) -> (* Some *)
                US1_0(v610)
        let v802 : string =
            match v798 with
            | US1_1 -> (* None *)
                failwith<string> "Option does not have a value."
            | US1_0(v799) -> (* Some *)
                v799
        let v803 : (unit -> string) = v802.ToLower
        let v804 : string = v803 ()
        let v807 : string = v804.PadLeft (7, ' ')
        let v821 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v822 : string = "inline_colorization::color_bright_red"
        let v823 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v822 
        let v824 : string = "&*$0"
        let v825 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v807 v824 
        let v826 : string = "inline_colorization::color_reset"
        let v827 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v826 
        let v828 : string = "\"{v823}{v825}{v827}\""
        let v829 : string = @$"format!(" + v828 + ")"
        let v830 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v829 
        let v831 : string = "fable_library_rust::String_::fromString($0)"
        let v832 : string = Fable.Core.RustInterop.emitRustExpr v830 v831 
        let _v821 = v832 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v833 : string = "inline_colorization::color_bright_red"
        let v834 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v833 
        let v835 : string = "&*$0"
        let v836 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v807 v835 
        let v837 : string = "inline_colorization::color_reset"
        let v838 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v837 
        let v839 : string = "\"{v834}{v836}{v838}\""
        let v840 : string = @$"format!(" + v839 + ")"
        let v841 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v840 
        let v842 : string = "fable_library_rust::String_::fromString($0)"
        let v843 : string = Fable.Core.RustInterop.emitRustExpr v841 v842 
        let _v821 = v843 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v844 : string = "inline_colorization::color_bright_red"
        let v845 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v844 
        let v846 : string = "&*$0"
        let v847 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v807 v846 
        let v848 : string = "inline_colorization::color_reset"
        let v849 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v848 
        let v850 : string = "\"{v845}{v847}{v849}\""
        let v851 : string = @$"format!(" + v850 + ")"
        let v852 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v851 
        let v853 : string = "fable_library_rust::String_::fromString($0)"
        let v854 : string = Fable.Core.RustInterop.emitRustExpr v852 v853 
        let _v821 = v854 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v855 : string = "\u001b[91m"
        let v856 : string = method14()
        let v857 : string = v855 + v807 
        let v858 : string = v857 + v856 
        let _v821 = v858 
        #endif
#if FABLE_COMPILER_PYTHON
        let v859 : string = "\u001b[91m"
        let v860 : string = method14()
        let v861 : string = v859 + v807 
        let v862 : string = v861 + v860 
        let _v821 = v862 
        #endif
#else
        let v863 : string = "\u001b[91m"
        let v864 : string = method14()
        let v865 : string = v863 + v807 
        let v866 : string = v865 + v864 
        let _v821 = v866 
        #endif
        let v867 : string = _v821 
        let v873 : int64 = v85.l0
        let v874 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v875 : string = $"%A{v0}"
        let _v874 = v875 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v878 : string = $"%A{v0}"
        let _v874 = v878 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v881 : string = $"%A{v0}"
        let _v874 = v881 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v884 : string = $"%A{v0}"
        let _v874 = v884 
        #endif
#if FABLE_COMPILER_PYTHON
        let v887 : string = $"%A{v0}"
        let _v874 = v887 
        #endif
#else
        let v890 : string = $"{v0.GetType ()}: {v0.Message}"
        let _v874 = v890 
        #endif
        let v891 : string = _v874 
        let v896 : string = method13()
        let v897 : Mut4 = {l0 = v896} : Mut4
        let v898 : string = "{ "
        let v899 : string = $"{v898}"
        let v902 : unit = ()
        let v903 : (unit -> unit) = closure9(v897, v899)
        let v904 : unit = (fun () -> v903 (); v902) ()
        let v907 : string = "timeout"
        let v908 : string = $"{v907}"
        let v911 : unit = ()
        let v912 : (unit -> unit) = closure9(v897, v908)
        let v913 : unit = (fun () -> v912 (); v911) ()
        let v916 : string = " = "
        let v917 : string = $"{v916}"
        let v920 : unit = ()
        let v921 : (unit -> unit) = closure9(v897, v917)
        let v922 : unit = (fun () -> v921 (); v920) ()
        let v925 : string = $"{1000}"
        let v928 : unit = ()
        let v929 : (unit -> unit) = closure9(v897, v925)
        let v930 : unit = (fun () -> v929 (); v928) ()
        let v933 : string = "; "
        let v934 : string = $"{v933}"
        let v937 : unit = ()
        let v938 : (unit -> unit) = closure9(v897, v934)
        let v939 : unit = (fun () -> v938 (); v937) ()
        let v942 : string = "ex"
        let v943 : string = $"{v942}"
        let v946 : unit = ()
        let v947 : (unit -> unit) = closure9(v897, v943)
        let v948 : unit = (fun () -> v947 (); v946) ()
        let v951 : string = $"{v916}"
        let v954 : unit = ()
        let v955 : (unit -> unit) = closure9(v897, v951)
        let v956 : unit = (fun () -> v955 (); v954) ()
        let v959 : string = $"{v891}"
        let v962 : unit = ()
        let v963 : (unit -> unit) = closure9(v897, v959)
        let v964 : unit = (fun () -> v963 (); v962) ()
        let v967 : string = " }"
        let v968 : string = $"{v967}"
        let v971 : unit = ()
        let v972 : (unit -> unit) = closure9(v897, v968)
        let v973 : unit = (fun () -> v972 (); v971) ()
        let v976 : string = v897.l0
        let v977 : (unit -> string) = closure38()
        let v978 : string = $"{v483} {v867} #{v873} %s{v977 ()} / {v976}"
        let v981 : char list = []
        let v982 : (char list -> (char [])) = List.toArray
        let v983 : (char []) = v982 v981
        let v986 : string = v978.TrimStart v983 
        let v1004 : char list = []
        let v1005 : char list = '/' :: v1004 
        let v1008 : char list = ' ' :: v1005 
        let v1011 : (char list -> (char [])) = List.toArray
        let v1012 : (char []) = v1011 v1008
        let v1015 : string = v986.TrimEnd v1012 
        let v1033 : (string -> unit) = closure11()
        let v1034 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v1035 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v1015 v1035 
        let _v1034 = () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v1036 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v1015 v1036 
        let _v1034 = () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v1037 : string = $"near_sdk::log!(\"{{}}\", $0)"
        Fable.Core.RustInterop.emitRustExpr v1015 v1037 
        let _v1034 = () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        v1033 v1015
        let _v1034 = () 
        #endif
#if FABLE_COMPILER_PYTHON
        v1033 v1015
        let _v1034 = () 
        #endif
#else
        v1033 v1015
        let _v1034 = () 
        #endif
        _v1034 
        let v1038 : (string -> unit) = v17.l0
        v1038 v1015
and closure40 () () : string =
    let v0 : string = "read_all_text_retry_async"
    v0
and closure39 (v0 : int64, v1 : string) () : unit =
    let v2 : unit = ()
    let v3 : (unit -> unit) = closure0()
    let v4 : unit = (fun () -> v3 (); v2) ()
    let struct (v17 : Mut0, v18 : Mut1, v19 : Mut2, v20 : Mut3, v21 : int64 option) = State.trace_state.Value
    let v32 : unit = ()
    let v33 : unit = (fun () -> v3 (); v32) ()
    let struct (v46 : Mut0, v47 : Mut1, v48 : Mut2, v49 : Mut3, v50 : int64 option) = State.trace_state.Value
    let v61 : US0 = v49.l0
    let v62 : bool = v48.l0
    let v63 : bool = v62 = false
    let v66 : bool =
        if v63 then
            false
        else
            let v64 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v61
            let v65 : bool = 1 >= v64
            v65
    if v66 then
        let v67 : unit = ()
        let v68 : (unit -> unit) = closure6(v17)
        let v69 : unit = (fun () -> v68 (); v67) ()
        let v72 : unit = ()
        let v73 : unit = (fun () -> v3 (); v72) ()
        let struct (v86 : Mut0, v87 : Mut1, v88 : Mut2, v89 : Mut3, v90 : int64 option) = State.trace_state.Value
        let v101 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v102 : US3 option = None
        let _v102 = ref v102 
        let v103 : US3 option ref = _v102 
        let v104 : (US3 option -> US3 option ref) = closure7(v103)
        let v105 : unit = ()
        let v106 : (unit -> unit) = closure8(v90, v104)
        let v107 : unit = (fun () -> v106 (); v105) ()
        let v110 : US3 option = _v102.Value 
        let v121 : US3 = US3_1
        let v122 : US3 = v110 |> Option.defaultValue v121 
        let v162 : System.DateTime =
            match v122 with
            | US3_1 -> (* None *)
                let v158 : System.DateTime = System.DateTime.Now
                v158
            | US3_0(v126) -> (* Some *)
                let v127 : System.DateTime = System.DateTime.Now
                let v130 : (System.DateTime -> int64) = _.Ticks
                let v131 : int64 = v130 v127
                let v134 : int64 = v131 - v126
                let v135 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v136 : System.TimeSpan = v135 v134
                let v139 : (System.TimeSpan -> int32) = _.Hours
                let v140 : int32 = v139 v136
                let v143 : (System.TimeSpan -> int32) = _.Minutes
                let v144 : int32 = v143 v136
                let v147 : (System.TimeSpan -> int32) = _.Seconds
                let v148 : int32 = v147 v136
                let v151 : (System.TimeSpan -> int32) = _.Milliseconds
                let v152 : int32 = v151 v136
                let v155 : System.DateTime = System.DateTime (1, 1, 1, v140, v144, v148, v152)
                v155
        let v163 : string = method9()
        let v166 : (string -> string) = v162.ToString
        let v167 : string = v166 v163
        let _v101 = v167 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v170 : US3 option = None
        let _v170 = ref v170 
        let v171 : US3 option ref = _v170 
        let v172 : (US3 option -> US3 option ref) = closure7(v171)
        let v173 : unit = ()
        let v174 : (unit -> unit) = closure8(v90, v172)
        let v175 : unit = (fun () -> v174 (); v173) ()
        let v178 : US3 option = _v170.Value 
        let v189 : US3 = US3_1
        let v190 : US3 = v178 |> Option.defaultValue v189 
        let v230 : System.DateTime =
            match v190 with
            | US3_1 -> (* None *)
                let v226 : System.DateTime = System.DateTime.Now
                v226
            | US3_0(v194) -> (* Some *)
                let v195 : System.DateTime = System.DateTime.Now
                let v198 : (System.DateTime -> int64) = _.Ticks
                let v199 : int64 = v198 v195
                let v202 : int64 = v199 - v194
                let v203 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v204 : System.TimeSpan = v203 v202
                let v207 : (System.TimeSpan -> int32) = _.Hours
                let v208 : int32 = v207 v204
                let v211 : (System.TimeSpan -> int32) = _.Minutes
                let v212 : int32 = v211 v204
                let v215 : (System.TimeSpan -> int32) = _.Seconds
                let v216 : int32 = v215 v204
                let v219 : (System.TimeSpan -> int32) = _.Milliseconds
                let v220 : int32 = v219 v204
                let v223 : System.DateTime = System.DateTime (1, 1, 1, v208, v212, v216, v220)
                v223
        let v231 : string = method9()
        let v234 : (string -> string) = v230.ToString
        let v235 : string = v234 v231
        let _v101 = v235 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v238 : string = $"near_sdk::env::block_timestamp()"
        let v239 : uint64 = Fable.Core.RustInterop.emitRustExpr () v238 
        let v240 : US3 option = None
        let _v240 = ref v240 
        let v241 : US3 option ref = _v240 
        let v242 : (US3 option -> US3 option ref) = closure7(v241)
        let v243 : unit = ()
        let v244 : (unit -> unit) = closure8(v90, v242)
        let v245 : unit = (fun () -> v244 (); v243) ()
        let v248 : US3 option = _v240.Value 
        let v259 : US3 = US3_1
        let v260 : US3 = v248 |> Option.defaultValue v259 
        let v269 : uint64 =
            match v260 with
            | US3_1 -> (* None *)
                v239
            | US3_0(v264) -> (* Some *)
                let v265 : (int64 -> uint64) = uint64
                let v266 : uint64 = v265 v264
                let v267 : uint64 = v239 - v266
                v267
        let v270 : uint64 = v269 / 1000000000UL
        let v271 : uint64 = v270 % 60UL
        let v272 : uint64 = v270 / 60UL
        let v273 : uint64 = v272 % 60UL
        let v274 : uint64 = v270 / 3600UL
        let v275 : uint64 = v274 % 24UL
        let v276 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
        let v277 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v275, v273, v271) v276 
        let v278 : string = "fable_library_rust::String_::fromString($0)"
        let v279 : string = Fable.Core.RustInterop.emitRustExpr v277 v278 
        let _v101 = v279 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v280 : US3 option = None
        let _v280 = ref v280 
        let v281 : US3 option ref = _v280 
        let v282 : (US3 option -> US3 option ref) = closure7(v281)
        let v283 : unit = ()
        let v284 : (unit -> unit) = closure8(v90, v282)
        let v285 : unit = (fun () -> v284 (); v283) ()
        let v288 : US3 option = _v280.Value 
        let v299 : US3 = US3_1
        let v300 : US3 = v288 |> Option.defaultValue v299 
        let v340 : System.DateTime =
            match v300 with
            | US3_1 -> (* None *)
                let v336 : System.DateTime = System.DateTime.Now
                v336
            | US3_0(v304) -> (* Some *)
                let v305 : System.DateTime = System.DateTime.Now
                let v308 : (System.DateTime -> int64) = _.Ticks
                let v309 : int64 = v308 v305
                let v312 : int64 = v309 - v304
                let v313 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v314 : System.TimeSpan = v313 v312
                let v317 : (System.TimeSpan -> int32) = _.Hours
                let v318 : int32 = v317 v314
                let v321 : (System.TimeSpan -> int32) = _.Minutes
                let v322 : int32 = v321 v314
                let v325 : (System.TimeSpan -> int32) = _.Seconds
                let v326 : int32 = v325 v314
                let v329 : (System.TimeSpan -> int32) = _.Milliseconds
                let v330 : int32 = v329 v314
                let v333 : System.DateTime = System.DateTime (1, 1, 1, v318, v322, v326, v330)
                v333
        let v341 : string = method10()
        let v344 : (string -> string) = v340.ToString
        let v345 : string = v344 v341
        let _v101 = v345 
        #endif
#if FABLE_COMPILER_PYTHON
        let v348 : US3 option = None
        let _v348 = ref v348 
        let v349 : US3 option ref = _v348 
        let v350 : (US3 option -> US3 option ref) = closure7(v349)
        let v351 : unit = ()
        let v352 : (unit -> unit) = closure8(v90, v350)
        let v353 : unit = (fun () -> v352 (); v351) ()
        let v356 : US3 option = _v348.Value 
        let v367 : US3 = US3_1
        let v368 : US3 = v356 |> Option.defaultValue v367 
        let v408 : System.DateTime =
            match v368 with
            | US3_1 -> (* None *)
                let v404 : System.DateTime = System.DateTime.Now
                v404
            | US3_0(v372) -> (* Some *)
                let v373 : System.DateTime = System.DateTime.Now
                let v376 : (System.DateTime -> int64) = _.Ticks
                let v377 : int64 = v376 v373
                let v380 : int64 = v377 - v372
                let v381 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v382 : System.TimeSpan = v381 v380
                let v385 : (System.TimeSpan -> int32) = _.Hours
                let v386 : int32 = v385 v382
                let v389 : (System.TimeSpan -> int32) = _.Minutes
                let v390 : int32 = v389 v382
                let v393 : (System.TimeSpan -> int32) = _.Seconds
                let v394 : int32 = v393 v382
                let v397 : (System.TimeSpan -> int32) = _.Milliseconds
                let v398 : int32 = v397 v382
                let v401 : System.DateTime = System.DateTime (1, 1, 1, v386, v390, v394, v398)
                v401
        let v409 : string = method10()
        let v412 : (string -> string) = v408.ToString
        let v413 : string = v412 v409
        let _v101 = v413 
        #endif
#else
        let v416 : US3 option = None
        let _v416 = ref v416 
        let v417 : US3 option ref = _v416 
        let v418 : (US3 option -> US3 option ref) = closure7(v417)
        let v419 : unit = ()
        let v420 : (unit -> unit) = closure8(v90, v418)
        let v421 : unit = (fun () -> v420 (); v419) ()
        let v424 : US3 option = _v416.Value 
        let v435 : US3 = US3_1
        let v436 : US3 = v424 |> Option.defaultValue v435 
        let v476 : System.DateTime =
            match v436 with
            | US3_1 -> (* None *)
                let v472 : System.DateTime = System.DateTime.Now
                v472
            | US3_0(v440) -> (* Some *)
                let v441 : System.DateTime = System.DateTime.Now
                let v444 : (System.DateTime -> int64) = _.Ticks
                let v445 : int64 = v444 v441
                let v448 : int64 = v445 - v440
                let v449 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v450 : System.TimeSpan = v449 v448
                let v453 : (System.TimeSpan -> int32) = _.Hours
                let v454 : int32 = v453 v450
                let v457 : (System.TimeSpan -> int32) = _.Minutes
                let v458 : int32 = v457 v450
                let v461 : (System.TimeSpan -> int32) = _.Seconds
                let v462 : int32 = v461 v450
                let v465 : (System.TimeSpan -> int32) = _.Milliseconds
                let v466 : int32 = v465 v450
                let v469 : System.DateTime = System.DateTime (1, 1, 1, v454, v458, v462, v466)
                v469
        let v477 : string = method10()
        let v480 : (string -> string) = v476.ToString
        let v481 : string = v480 v477
        let _v101 = v481 
        #endif
        let v484 : string = _v101 
        
        
        
        
        
        let v554 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v555 : string = method11()
        let _v554 = v555 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v556 : string = method11()
        let _v554 = v556 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v557 : string = method11()
        let _v554 = v557 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v558 : string = method12()
        let _v554 = v558 
        #endif
#if FABLE_COMPILER_PYTHON
        let v559 : string = method12()
        let _v554 = v559 
        #endif
#else
        let v560 : string = method12()
        let _v554 = v560 
        #endif
        let v561 : string = _v554 
        let v566 : string = method13()
        let v567 : Mut4 = {l0 = v566} : Mut4
        let v568 : US0 = US0_0
        let v569 : string = $"%A{v568}"
        let v573 : string = $"{v569}"
        let v576 : unit = ()
        let v577 : (unit -> unit) = closure9(v567, v573)
        let v578 : unit = (fun () -> v577 (); v576) ()
        let v581 : string = v567.l0
        let v582 : (string []) = v581.Split v561 
        let v585 : string = v582.[int 0]
        let v588 : string = method13()
        let v589 : Mut4 = {l0 = v588} : Mut4
        let v590 : US0 = US0_1
        let v591 : string = $"%A{v590}"
        let v595 : string = $"{v591}"
        let v598 : unit = ()
        let v599 : (unit -> unit) = closure9(v589, v595)
        let v600 : unit = (fun () -> v599 (); v598) ()
        let v603 : string = v589.l0
        let v604 : bool = v603.StartsWith v585 
        let v610 : US1 =
            if v604 then
                let v607 : string = "Verbose"
                US1_0(v607)
            else
                US1_1
        let v616 : US1 =
            match v610 with
            | US1_1 -> (* None *)
                let v613 : string = "Debug"
                US1_0(v613)
            | US1_0(v611) -> (* Some *)
                US1_0(v611)
        let v620 : string =
            match v616 with
            | US1_1 -> (* None *)
                failwith<string> "Option does not have a value."
            | US1_0(v617) -> (* Some *)
                v617
        let v621 : (unit -> string) = v620.ToLower
        let v622 : string = v621 ()
        let v625 : string = v622.PadLeft (7, ' ')
        let v639 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v640 : string = "inline_colorization::color_bright_blue"
        let v641 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v640 
        let v642 : string = "&*$0"
        let v643 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v625 v642 
        let v644 : string = "inline_colorization::color_reset"
        let v645 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v644 
        let v646 : string = "\"{v641}{v643}{v645}\""
        let v647 : string = @$"format!(" + v646 + ")"
        let v648 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v647 
        let v649 : string = "fable_library_rust::String_::fromString($0)"
        let v650 : string = Fable.Core.RustInterop.emitRustExpr v648 v649 
        let _v639 = v650 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v651 : string = "inline_colorization::color_bright_blue"
        let v652 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v651 
        let v653 : string = "&*$0"
        let v654 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v625 v653 
        let v655 : string = "inline_colorization::color_reset"
        let v656 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v655 
        let v657 : string = "\"{v652}{v654}{v656}\""
        let v658 : string = @$"format!(" + v657 + ")"
        let v659 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v658 
        let v660 : string = "fable_library_rust::String_::fromString($0)"
        let v661 : string = Fable.Core.RustInterop.emitRustExpr v659 v660 
        let _v639 = v661 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v662 : string = "inline_colorization::color_bright_blue"
        let v663 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v662 
        let v664 : string = "&*$0"
        let v665 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v625 v664 
        let v666 : string = "inline_colorization::color_reset"
        let v667 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v666 
        let v668 : string = "\"{v663}{v665}{v667}\""
        let v669 : string = @$"format!(" + v668 + ")"
        let v670 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v669 
        let v671 : string = "fable_library_rust::String_::fromString($0)"
        let v672 : string = Fable.Core.RustInterop.emitRustExpr v670 v671 
        let _v639 = v672 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v673 : string = "\u001b[94m"
        let v674 : string = method14()
        let v675 : string = v673 + v625 
        let v676 : string = v675 + v674 
        let _v639 = v676 
        #endif
#if FABLE_COMPILER_PYTHON
        let v677 : string = "\u001b[94m"
        let v678 : string = method14()
        let v679 : string = v677 + v625 
        let v680 : string = v679 + v678 
        let _v639 = v680 
        #endif
#else
        let v681 : string = "\u001b[94m"
        let v682 : string = method14()
        let v683 : string = v681 + v625 
        let v684 : string = v683 + v682 
        let _v639 = v684 
        #endif
        let v685 : string = _v639 
        let v691 : int64 = v86.l0
        let v692 : string = method13()
        let v693 : Mut4 = {l0 = v692} : Mut4
        let v694 : string = "{ "
        let v695 : string = $"{v694}"
        let v698 : unit = ()
        let v699 : (unit -> unit) = closure9(v693, v695)
        let v700 : unit = (fun () -> v699 (); v698) ()
        let v703 : string = "retry"
        let v704 : string = $"{v703}"
        let v707 : unit = ()
        let v708 : (unit -> unit) = closure9(v693, v704)
        let v709 : unit = (fun () -> v708 (); v707) ()
        let v712 : string = " = "
        let v713 : string = $"{v712}"
        let v716 : unit = ()
        let v717 : (unit -> unit) = closure9(v693, v713)
        let v718 : unit = (fun () -> v717 (); v716) ()
        let v721 : string = $"{v0}"
        let v724 : unit = ()
        let v725 : (unit -> unit) = closure9(v693, v721)
        let v726 : unit = (fun () -> v725 (); v724) ()
        let v729 : string = "; "
        let v730 : string = $"{v729}"
        let v733 : unit = ()
        let v734 : (unit -> unit) = closure9(v693, v730)
        let v735 : unit = (fun () -> v734 (); v733) ()
        let v738 : string = "ex"
        let v739 : string = $"{v738}"
        let v742 : unit = ()
        let v743 : (unit -> unit) = closure9(v693, v739)
        let v744 : unit = (fun () -> v743 (); v742) ()
        let v747 : string = $"{v712}"
        let v750 : unit = ()
        let v751 : (unit -> unit) = closure9(v693, v747)
        let v752 : unit = (fun () -> v751 (); v750) ()
        let v755 : string = $"{v1}"
        let v758 : unit = ()
        let v759 : (unit -> unit) = closure9(v693, v755)
        let v760 : unit = (fun () -> v759 (); v758) ()
        let v763 : string = " }"
        let v764 : string = $"{v763}"
        let v767 : unit = ()
        let v768 : (unit -> unit) = closure9(v693, v764)
        let v769 : unit = (fun () -> v768 (); v767) ()
        let v772 : string = v693.l0
        let v773 : (unit -> string) = closure40()
        let v774 : string = $"{v484} {v685} #{v691} %s{v773 ()} / {v772}"
        let v777 : char list = []
        let v778 : (char list -> (char [])) = List.toArray
        let v779 : (char []) = v778 v777
        let v782 : string = v774.TrimStart v779 
        let v800 : char list = []
        let v801 : char list = '/' :: v800 
        let v804 : char list = ' ' :: v801 
        let v807 : (char list -> (char [])) = List.toArray
        let v808 : (char []) = v807 v804
        let v811 : string = v782.TrimEnd v808 
        let v829 : (string -> unit) = closure11()
        let v830 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v831 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v811 v831 
        let _v830 = () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v832 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v811 v832 
        let _v830 = () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v833 : string = $"near_sdk::log!(\"{{}}\", $0)"
        Fable.Core.RustInterop.emitRustExpr v811 v833 
        let _v830 = () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        v829 v811
        let _v830 = () 
        #endif
#if FABLE_COMPILER_PYTHON
        v829 v811
        let _v830 = () 
        #endif
#else
        v829 v811
        let _v830 = () 
        #endif
        _v830 
        let v834 : (string -> unit) = v18.l0
        v834 v811
and method23 (v0 : string, v1 : int64) : Async<string option> =
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
        let v37 : Async<int64> = method17(v0, v36)
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
        let v156 : (int64 -> US9) = closure33()
        let v157 : (exn -> US9) = closure34()
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
        let v2009 : US3 =
            match v217 with
            | US10_1(v220) -> (* Error *)
                let v221 : string = $"%A{v220}"
                let v224 : string = "System.TimeoutException"
                let v225 : bool = v221.Contains v224 
                if v225 then
                    let v228 : unit = ()
                    let v229 : (unit -> unit) = closure35()
                    let v230 : unit = (fun () -> v229 (); v228) ()
                    US3_1
                else
                    let v965 : unit = ()
                    let v966 : (unit -> unit) = closure37(v220)
                    let v967 : unit = (fun () -> v966 (); v965) ()
                    US3_1
            | US10_0(v218) -> (* Ok *)
                US3_0(v218)
        return v2009 
        }
        |> fun x -> _v216 <- Some x
        let v2010 : Async<US3> = match _v216 with Some x -> x | None -> failwith "async.new_async_unit / _v216=None"
        let _v200 = v2010 
        #endif
        let v2011 : Async<US3> = _v200 
        return! v2011 
        }
        |> fun x -> _v75 <- Some x
        let v2016 : Async<US3> = match _v75 with Some x -> x | None -> failwith "async.new_async_unit / _v75=None"
        let _v59 = v2016 
        #endif
        let v2017 : Async<US3> = _v59 
        let _v43 = v2017 
        #endif
        let v2022 : Async<US3> = _v43 
        let v2027 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v2028 : Async<unit> = null |> unbox<Async<unit>>
        let _v2027 = v2028 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v2031 : Async<unit> = null |> unbox<Async<unit>>
        let _v2027 = v2031 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v2034 : Async<unit> = null |> unbox<Async<unit>>
        let _v2027 = v2034 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v2037 : Async<unit> = null |> unbox<Async<unit>>
        let _v2027 = v2037 
        #endif
#if FABLE_COMPILER_PYTHON
        let v2040 : Async<unit> = null |> unbox<Async<unit>>
        let _v2027 = v2040 
        #endif
#else
        let v2043 : (Async<US3> -> Async<unit>) = Async.Ignore
        let v2044 : Async<unit> = v2043 v2022
        let _v2027 = v2044 
        #endif
        let v2045 : Async<unit> = _v2027 
        do! v2045 
        ()
    let v2050 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2051 : Async<string> = null |> unbox<Async<string>>
    let _v2050 = v2051 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v2054 : Async<string> = null |> unbox<Async<string>>
    let _v2050 = v2054 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v2057 : Async<string> = null |> unbox<Async<string>>
    let _v2050 = v2057 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v2060 : Async<string> = null |> unbox<Async<string>>
    let _v2050 = v2060 
    #endif
#if FABLE_COMPILER_PYTHON
    let v2063 : Async<string> = null |> unbox<Async<string>>
    let _v2050 = v2063 
    #endif
#else
    let v2066 : (string -> System.Threading.Tasks.Task<string>) = System.IO.File.ReadAllTextAsync
    let v2067 : System.Threading.Tasks.Task<string> = v2066 v0
    let v2068 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2069 : Async<string> = null |> unbox<Async<string>>
    let _v2068 = v2069 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v2072 : Async<string> = null |> unbox<Async<string>>
    let _v2068 = v2072 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v2075 : Async<string> = null |> unbox<Async<string>>
    let _v2068 = v2075 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v2078 : Async<string> = null |> unbox<Async<string>>
    let _v2068 = v2078 
    #endif
#if FABLE_COMPILER_PYTHON
    let v2081 : Async<string> = null |> unbox<Async<string>>
    let _v2068 = v2081 
    #endif
#else
    let v2084 : (System.Threading.Tasks.Task<string> -> Async<string>) = Async.AwaitTask
    let v2085 : Async<string> = v2084 v2067
    let _v2068 = v2085 
    #endif
    let v2086 : Async<string> = _v2068 
    let _v2050 = v2086 
    #endif
    let v2091 : Async<string> = _v2050 
    let v2096 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2097 : Async<string option> = null |> unbox<Async<string option>>
    let _v2096 = v2097 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v2100 : Async<string option> = null |> unbox<Async<string option>>
    let _v2096 = v2100 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v2103 : Async<string option> = null |> unbox<Async<string option>>
    let _v2096 = v2103 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v2106 : Async<string option> = null |> unbox<Async<string option>>
    let _v2096 = v2106 
    #endif
#if FABLE_COMPILER_PYTHON
    let v2109 : Async<string option> = null |> unbox<Async<string option>>
    let _v2096 = v2109 
    #endif
#else
    let v2112 : Async<string option> option = None
    let mutable _v2112 = v2112 
    async {
    let! v2091 = v2091 
    let v2113 : string = v2091 
    let v2114 : string option = Some v2113 
    return v2114 
    }
    |> fun x -> _v2112 <- Some x
    let v2117 : Async<string option> = match _v2112 with Some x -> x | None -> failwith "async.new_async_unit / _v2112=None"
    let _v2096 = v2117 
    #endif
    let v2118 : Async<string option> = _v2096 
    return! v2118 
    with ex ->
    let v2123 : exn = ex
    let v2124 : bool = v1 = 0L
    let v2125 : bool = v2124 <> true
    if v2125 then
        let v2126 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v2127 : string = $"%A{v2123}"
        let _v2126 = v2127 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v2130 : string = $"%A{v2123}"
        let _v2126 = v2130 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v2133 : string = $"%A{v2123}"
        let _v2126 = v2133 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v2136 : string = $"%A{v2123}"
        let _v2126 = v2136 
        #endif
#if FABLE_COMPILER_PYTHON
        let v2139 : string = $"%A{v2123}"
        let _v2126 = v2139 
        #endif
#else
        let v2142 : string = $"{v2123.GetType ()}: {v2123.Message}"
        let _v2126 = v2142 
        #endif
        let v2143 : string = _v2126 
        let v2148 : unit = ()
        let v2149 : (unit -> unit) = closure39(v1, v2143)
        let v2150 : unit = (fun () -> v2149 (); v2148) ()
        let v2984 : string option = None
        return v2984 
        (*
        ()
    else
        *) else
        let v2985 : int64 = v1 + 1L
        let v2986 : Async<string option> = method23(v0, v2985)
        return! v2986 
        (*
        ()
    *)
    (*
    let v2987 : string option = *)
    }
    |> fun x -> _v18 <- Some x
    let v2988 : Async<string option> = match _v18 with Some x -> x | None -> failwith "async.new_async_unit / _v18=None"
    let _v2 = v2988 
    #endif
    let v2989 : Async<string option> = _v2 
    v2989
and closure32 () (v0 : string) : Async<string option> =
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
    let v18 : Async<string option> = method23(v0, v17)
    let _v1 = v18 
    #endif
    let v19 : Async<string option> = _v1 
    v19
and closure42 (v0 : US11 option ref) (v1 : US11 option) : US11 option ref =
    v0.Value <- v1 
    v0
and closure43 (v0 : chrono_DateTime<chrono_Utc> option, v1 : (US11 option -> US11 option ref)) () : unit =
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
and method26 () : string =
    let v0 : string = "hh:mm"
    v0
and method27 () : string =
    let v0 : string = "yyyyMMdd-HHmm-ssff-ffff-f"
    v0
and method28 () : string =
    let v0 : string = "hhmm"
    v0
and method25 (v0 : System.Guid, v1 : System.DateTime) : System.Guid =
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
    let v30 : (US11 option -> US11 option ref) = closure42(v29)
    let v31 : unit = ()
    let v32 : (unit -> unit) = closure43(v27, v30)
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
    let v151 : string = method26()
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
    let v195 : (US11 option -> US11 option ref) = closure42(v194)
    let v196 : unit = ()
    let v197 : (unit -> unit) = closure43(v192, v195)
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
    let v316 : string = method26()
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
    let v336 : string = method27()
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
    let v419 : string = method28()
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
    let v436 : string = method27()
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
    let v519 : string = method28()
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
    let v536 : string = method27()
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
    let v619 : string = method28()
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
and method30 () : string =
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
and method31 () : string =
    let v0 : string = "!create_temp_path_"
    v0
and method34 (v0 : string) : string =
    v0
and method33 (v0 : string, v1 : string) : struct (string * string) =
    let v2 : string = method34(v0)
    struct (v1, v2)
and method32 (v0 : string, v1 : string) : string =
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
    let struct (v49 : string, v50 : string) = method33(v1, v0)
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
and method36 () : string =
    let v0 : string = "CARGO_PKG_NAME"
    v0
and method35 () : string =
    let v0 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1 : string = method36()
    let v2 : string = method2(v1)
    let _v0 = v2 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v3 : string = method36()
    let v4 : string = method2(v3)
    let _v0 = v4 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v5 : string = method36()
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
and method29 (v0 : System.Guid) : string =
    let v1 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = method30()
    let v3 : string = method31()
    let v4 : string = method32(v2, v3)
    let v5 : string = method35()
    let v6 : string = method32(v4, v5)
    let v7 : (System.Guid -> string) = _.ToString()
    let v8 : string = v7 v0
    let v11 : string = method32(v6, v8)
    let _v1 = v11 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v12 : string = method30()
    let v13 : string = method31()
    let v14 : string = method32(v12, v13)
    let v15 : string = method35()
    let v16 : string = method32(v14, v15)
    let v17 : (System.Guid -> string) = _.ToString()
    let v18 : string = v17 v0
    let v21 : string = method32(v16, v18)
    let _v1 = v21 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v22 : string = null |> unbox<string>
    let _v1 = v22 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v25 : string = method30()
    let v26 : string = method31()
    let v27 : string = method32(v25, v26)
    let v28 : string = method35()
    let v29 : string = method32(v27, v28)
    let v30 : (System.Guid -> string) = _.ToString()
    let v31 : string = v30 v0
    let v34 : string = method32(v29, v31)
    let _v1 = v34 
    #endif
#if FABLE_COMPILER_PYTHON
    let v35 : string = method30()
    let v36 : string = method31()
    let v37 : string = method32(v35, v36)
    let v38 : string = method35()
    let v39 : string = method32(v37, v38)
    let v40 : (System.Guid -> string) = _.ToString()
    let v41 : string = v40 v0
    let v44 : string = method32(v39, v41)
    let _v1 = v44 
    #endif
#else
    let v45 : string = method30()
    let v46 : string = method31()
    let v47 : string = method32(v45, v46)
    let v48 : string = method35()
    let v49 : string = method32(v47, v48)
    let v50 : (System.Guid -> string) = _.ToString()
    let v51 : string = v50 v0
    let v54 : string = method32(v49, v51)
    let _v1 = v54 
    #endif
    let v55 : string = _v1 
    v55
and method24 () : string =
    let v0 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1 : System.DateTime = System.DateTime.Now
    let v4 : (unit -> System.Guid) = System.Guid.NewGuid
    let v5 : System.Guid = v4 ()
    let v8 : System.Guid = method25(v5, v1)
    let v9 : string = method29(v8)
    let _v0 = v9 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v10 : System.DateTime = System.DateTime.Now
    let v13 : (unit -> System.Guid) = System.Guid.NewGuid
    let v14 : System.Guid = v13 ()
    let v17 : System.Guid = method25(v14, v10)
    let v18 : string = method29(v17)
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
    let v29 : System.Guid = method25(v26, v22)
    let v30 : string = method29(v29)
    let _v0 = v30 
    #endif
#if FABLE_COMPILER_PYTHON
    let v31 : System.DateTime = System.DateTime.Now
    let v34 : (unit -> System.Guid) = System.Guid.NewGuid
    let v35 : System.Guid = v34 ()
    let v38 : System.Guid = method25(v35, v31)
    let v39 : string = method29(v38)
    let _v0 = v39 
    #endif
#else
    let v40 : System.DateTime = System.DateTime.Now
    let v43 : (unit -> System.Guid) = System.Guid.NewGuid
    let v44 : System.Guid = v43 ()
    let v47 : System.Guid = method25(v44, v40)
    let v48 : string = method29(v47)
    let _v0 = v48 
    #endif
    let v49 : string = _v0 
    v49
and closure41 () () : string =
    method24()
and method38 (v0 : string) : string =
    v0
and closure45 () (v0 : std_io_Error) : std_string_String =
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
and method39 () : (std_io_Error -> std_string_String) =
    closure45()
and closure46 () () : US12 =
    US12_0
and closure47 () (v0 : std_string_String) : US12 =
    US12_1(v0)
and closure49 () () : string =
    let v0 : string = "file_system.create_dir"
    v0
and closure48 (v0 : string, v1 : std_string_String) () : unit =
    let v2 : unit = ()
    let v3 : (unit -> unit) = closure0()
    let v4 : unit = (fun () -> v3 (); v2) ()
    let struct (v17 : Mut0, v18 : Mut1, v19 : Mut2, v20 : Mut3, v21 : int64 option) = State.trace_state.Value
    let v32 : unit = ()
    let v33 : unit = (fun () -> v3 (); v32) ()
    let struct (v46 : Mut0, v47 : Mut1, v48 : Mut2, v49 : Mut3, v50 : int64 option) = State.trace_state.Value
    let v61 : US0 = v49.l0
    let v62 : bool = v48.l0
    let v63 : bool = v62 = false
    let v66 : bool =
        if v63 then
            false
        else
            let v64 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v61
            let v65 : bool = 4 >= v64
            v65
    if v66 then
        let v67 : unit = ()
        let v68 : (unit -> unit) = closure6(v17)
        let v69 : unit = (fun () -> v68 (); v67) ()
        let v72 : unit = ()
        let v73 : unit = (fun () -> v3 (); v72) ()
        let struct (v86 : Mut0, v87 : Mut1, v88 : Mut2, v89 : Mut3, v90 : int64 option) = State.trace_state.Value
        let v101 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v102 : US3 option = None
        let _v102 = ref v102 
        let v103 : US3 option ref = _v102 
        let v104 : (US3 option -> US3 option ref) = closure7(v103)
        let v105 : unit = ()
        let v106 : (unit -> unit) = closure8(v90, v104)
        let v107 : unit = (fun () -> v106 (); v105) ()
        let v110 : US3 option = _v102.Value 
        let v121 : US3 = US3_1
        let v122 : US3 = v110 |> Option.defaultValue v121 
        let v162 : System.DateTime =
            match v122 with
            | US3_1 -> (* None *)
                let v158 : System.DateTime = System.DateTime.Now
                v158
            | US3_0(v126) -> (* Some *)
                let v127 : System.DateTime = System.DateTime.Now
                let v130 : (System.DateTime -> int64) = _.Ticks
                let v131 : int64 = v130 v127
                let v134 : int64 = v131 - v126
                let v135 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v136 : System.TimeSpan = v135 v134
                let v139 : (System.TimeSpan -> int32) = _.Hours
                let v140 : int32 = v139 v136
                let v143 : (System.TimeSpan -> int32) = _.Minutes
                let v144 : int32 = v143 v136
                let v147 : (System.TimeSpan -> int32) = _.Seconds
                let v148 : int32 = v147 v136
                let v151 : (System.TimeSpan -> int32) = _.Milliseconds
                let v152 : int32 = v151 v136
                let v155 : System.DateTime = System.DateTime (1, 1, 1, v140, v144, v148, v152)
                v155
        let v163 : string = method9()
        let v166 : (string -> string) = v162.ToString
        let v167 : string = v166 v163
        let _v101 = v167 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v170 : US3 option = None
        let _v170 = ref v170 
        let v171 : US3 option ref = _v170 
        let v172 : (US3 option -> US3 option ref) = closure7(v171)
        let v173 : unit = ()
        let v174 : (unit -> unit) = closure8(v90, v172)
        let v175 : unit = (fun () -> v174 (); v173) ()
        let v178 : US3 option = _v170.Value 
        let v189 : US3 = US3_1
        let v190 : US3 = v178 |> Option.defaultValue v189 
        let v230 : System.DateTime =
            match v190 with
            | US3_1 -> (* None *)
                let v226 : System.DateTime = System.DateTime.Now
                v226
            | US3_0(v194) -> (* Some *)
                let v195 : System.DateTime = System.DateTime.Now
                let v198 : (System.DateTime -> int64) = _.Ticks
                let v199 : int64 = v198 v195
                let v202 : int64 = v199 - v194
                let v203 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v204 : System.TimeSpan = v203 v202
                let v207 : (System.TimeSpan -> int32) = _.Hours
                let v208 : int32 = v207 v204
                let v211 : (System.TimeSpan -> int32) = _.Minutes
                let v212 : int32 = v211 v204
                let v215 : (System.TimeSpan -> int32) = _.Seconds
                let v216 : int32 = v215 v204
                let v219 : (System.TimeSpan -> int32) = _.Milliseconds
                let v220 : int32 = v219 v204
                let v223 : System.DateTime = System.DateTime (1, 1, 1, v208, v212, v216, v220)
                v223
        let v231 : string = method9()
        let v234 : (string -> string) = v230.ToString
        let v235 : string = v234 v231
        let _v101 = v235 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v238 : string = $"near_sdk::env::block_timestamp()"
        let v239 : uint64 = Fable.Core.RustInterop.emitRustExpr () v238 
        let v240 : US3 option = None
        let _v240 = ref v240 
        let v241 : US3 option ref = _v240 
        let v242 : (US3 option -> US3 option ref) = closure7(v241)
        let v243 : unit = ()
        let v244 : (unit -> unit) = closure8(v90, v242)
        let v245 : unit = (fun () -> v244 (); v243) ()
        let v248 : US3 option = _v240.Value 
        let v259 : US3 = US3_1
        let v260 : US3 = v248 |> Option.defaultValue v259 
        let v269 : uint64 =
            match v260 with
            | US3_1 -> (* None *)
                v239
            | US3_0(v264) -> (* Some *)
                let v265 : (int64 -> uint64) = uint64
                let v266 : uint64 = v265 v264
                let v267 : uint64 = v239 - v266
                v267
        let v270 : uint64 = v269 / 1000000000UL
        let v271 : uint64 = v270 % 60UL
        let v272 : uint64 = v270 / 60UL
        let v273 : uint64 = v272 % 60UL
        let v274 : uint64 = v270 / 3600UL
        let v275 : uint64 = v274 % 24UL
        let v276 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
        let v277 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v275, v273, v271) v276 
        let v278 : string = "fable_library_rust::String_::fromString($0)"
        let v279 : string = Fable.Core.RustInterop.emitRustExpr v277 v278 
        let _v101 = v279 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v280 : US3 option = None
        let _v280 = ref v280 
        let v281 : US3 option ref = _v280 
        let v282 : (US3 option -> US3 option ref) = closure7(v281)
        let v283 : unit = ()
        let v284 : (unit -> unit) = closure8(v90, v282)
        let v285 : unit = (fun () -> v284 (); v283) ()
        let v288 : US3 option = _v280.Value 
        let v299 : US3 = US3_1
        let v300 : US3 = v288 |> Option.defaultValue v299 
        let v340 : System.DateTime =
            match v300 with
            | US3_1 -> (* None *)
                let v336 : System.DateTime = System.DateTime.Now
                v336
            | US3_0(v304) -> (* Some *)
                let v305 : System.DateTime = System.DateTime.Now
                let v308 : (System.DateTime -> int64) = _.Ticks
                let v309 : int64 = v308 v305
                let v312 : int64 = v309 - v304
                let v313 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v314 : System.TimeSpan = v313 v312
                let v317 : (System.TimeSpan -> int32) = _.Hours
                let v318 : int32 = v317 v314
                let v321 : (System.TimeSpan -> int32) = _.Minutes
                let v322 : int32 = v321 v314
                let v325 : (System.TimeSpan -> int32) = _.Seconds
                let v326 : int32 = v325 v314
                let v329 : (System.TimeSpan -> int32) = _.Milliseconds
                let v330 : int32 = v329 v314
                let v333 : System.DateTime = System.DateTime (1, 1, 1, v318, v322, v326, v330)
                v333
        let v341 : string = method10()
        let v344 : (string -> string) = v340.ToString
        let v345 : string = v344 v341
        let _v101 = v345 
        #endif
#if FABLE_COMPILER_PYTHON
        let v348 : US3 option = None
        let _v348 = ref v348 
        let v349 : US3 option ref = _v348 
        let v350 : (US3 option -> US3 option ref) = closure7(v349)
        let v351 : unit = ()
        let v352 : (unit -> unit) = closure8(v90, v350)
        let v353 : unit = (fun () -> v352 (); v351) ()
        let v356 : US3 option = _v348.Value 
        let v367 : US3 = US3_1
        let v368 : US3 = v356 |> Option.defaultValue v367 
        let v408 : System.DateTime =
            match v368 with
            | US3_1 -> (* None *)
                let v404 : System.DateTime = System.DateTime.Now
                v404
            | US3_0(v372) -> (* Some *)
                let v373 : System.DateTime = System.DateTime.Now
                let v376 : (System.DateTime -> int64) = _.Ticks
                let v377 : int64 = v376 v373
                let v380 : int64 = v377 - v372
                let v381 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v382 : System.TimeSpan = v381 v380
                let v385 : (System.TimeSpan -> int32) = _.Hours
                let v386 : int32 = v385 v382
                let v389 : (System.TimeSpan -> int32) = _.Minutes
                let v390 : int32 = v389 v382
                let v393 : (System.TimeSpan -> int32) = _.Seconds
                let v394 : int32 = v393 v382
                let v397 : (System.TimeSpan -> int32) = _.Milliseconds
                let v398 : int32 = v397 v382
                let v401 : System.DateTime = System.DateTime (1, 1, 1, v386, v390, v394, v398)
                v401
        let v409 : string = method10()
        let v412 : (string -> string) = v408.ToString
        let v413 : string = v412 v409
        let _v101 = v413 
        #endif
#else
        let v416 : US3 option = None
        let _v416 = ref v416 
        let v417 : US3 option ref = _v416 
        let v418 : (US3 option -> US3 option ref) = closure7(v417)
        let v419 : unit = ()
        let v420 : (unit -> unit) = closure8(v90, v418)
        let v421 : unit = (fun () -> v420 (); v419) ()
        let v424 : US3 option = _v416.Value 
        let v435 : US3 = US3_1
        let v436 : US3 = v424 |> Option.defaultValue v435 
        let v476 : System.DateTime =
            match v436 with
            | US3_1 -> (* None *)
                let v472 : System.DateTime = System.DateTime.Now
                v472
            | US3_0(v440) -> (* Some *)
                let v441 : System.DateTime = System.DateTime.Now
                let v444 : (System.DateTime -> int64) = _.Ticks
                let v445 : int64 = v444 v441
                let v448 : int64 = v445 - v440
                let v449 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v450 : System.TimeSpan = v449 v448
                let v453 : (System.TimeSpan -> int32) = _.Hours
                let v454 : int32 = v453 v450
                let v457 : (System.TimeSpan -> int32) = _.Minutes
                let v458 : int32 = v457 v450
                let v461 : (System.TimeSpan -> int32) = _.Seconds
                let v462 : int32 = v461 v450
                let v465 : (System.TimeSpan -> int32) = _.Milliseconds
                let v466 : int32 = v465 v450
                let v469 : System.DateTime = System.DateTime (1, 1, 1, v454, v458, v462, v466)
                v469
        let v477 : string = method10()
        let v480 : (string -> string) = v476.ToString
        let v481 : string = v480 v477
        let _v101 = v481 
        #endif
        let v484 : string = _v101 
        
        
        
        
        
        let v554 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v555 : string = method11()
        let _v554 = v555 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v556 : string = method11()
        let _v554 = v556 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v557 : string = method11()
        let _v554 = v557 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v558 : string = method12()
        let _v554 = v558 
        #endif
#if FABLE_COMPILER_PYTHON
        let v559 : string = method12()
        let _v554 = v559 
        #endif
#else
        let v560 : string = method12()
        let _v554 = v560 
        #endif
        let v561 : string = _v554 
        let v566 : string = method13()
        let v567 : Mut4 = {l0 = v566} : Mut4
        let v568 : US0 = US0_0
        let v569 : string = $"%A{v568}"
        let v573 : string = $"{v569}"
        let v576 : unit = ()
        let v577 : (unit -> unit) = closure9(v567, v573)
        let v578 : unit = (fun () -> v577 (); v576) ()
        let v581 : string = v567.l0
        let v582 : (string []) = v581.Split v561 
        let v585 : string = v582.[int 0]
        let v588 : string = method13()
        let v589 : Mut4 = {l0 = v588} : Mut4
        let v590 : US0 = US0_4
        let v591 : string = $"%A{v590}"
        let v595 : string = $"{v591}"
        let v598 : unit = ()
        let v599 : (unit -> unit) = closure9(v589, v595)
        let v600 : unit = (fun () -> v599 (); v598) ()
        let v603 : string = v589.l0
        let v604 : bool = v603.StartsWith v585 
        let v610 : US1 =
            if v604 then
                let v607 : string = "Verbose"
                US1_0(v607)
            else
                US1_1
        let v799 : US1 =
            match v610 with
            | US1_1 -> (* None *)
                let v613 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v614 : string = method11()
                let _v613 = v614 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v615 : string = method11()
                let _v613 = v615 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v616 : string = method11()
                let _v613 = v616 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v617 : string = method12()
                let _v613 = v617 
                #endif
#if FABLE_COMPILER_PYTHON
                let v618 : string = method12()
                let _v613 = v618 
                #endif
#else
                let v619 : string = method12()
                let _v613 = v619 
                #endif
                let v620 : string = _v613 
                let v625 : string = method13()
                let v626 : Mut4 = {l0 = v625} : Mut4
                let v627 : US0 = US0_1
                let v628 : string = $"%A{v627}"
                let v632 : string = $"{v628}"
                let v635 : unit = ()
                let v636 : (unit -> unit) = closure9(v626, v632)
                let v637 : unit = (fun () -> v636 (); v635) ()
                let v640 : string = v626.l0
                let v641 : (string []) = v640.Split v620 
                let v644 : string = v641.[int 0]
                let v647 : string = method13()
                let v648 : Mut4 = {l0 = v647} : Mut4
                let v649 : US0 = US0_4
                let v650 : string = $"%A{v649}"
                let v654 : string = $"{v650}"
                let v657 : unit = ()
                let v658 : (unit -> unit) = closure9(v648, v654)
                let v659 : unit = (fun () -> v658 (); v657) ()
                let v662 : string = v648.l0
                let v663 : bool = v662.StartsWith v644 
                let v669 : US1 =
                    if v663 then
                        let v666 : string = "Debug"
                        US1_0(v666)
                    else
                        US1_1
                match v669 with
                | US1_1 -> (* None *)
                    let v672 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v673 : string = method11()
                    let _v672 = v673 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v674 : string = method11()
                    let _v672 = v674 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v675 : string = method11()
                    let _v672 = v675 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v676 : string = method12()
                    let _v672 = v676 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v677 : string = method12()
                    let _v672 = v677 
                    #endif
#else
                    let v678 : string = method12()
                    let _v672 = v678 
                    #endif
                    let v679 : string = _v672 
                    let v684 : string = method13()
                    let v685 : Mut4 = {l0 = v684} : Mut4
                    let v686 : US0 = US0_2
                    let v687 : string = $"%A{v686}"
                    let v691 : string = $"{v687}"
                    let v694 : unit = ()
                    let v695 : (unit -> unit) = closure9(v685, v691)
                    let v696 : unit = (fun () -> v695 (); v694) ()
                    let v699 : string = v685.l0
                    let v700 : (string []) = v699.Split v679 
                    let v703 : string = v700.[int 0]
                    let v706 : string = method13()
                    let v707 : Mut4 = {l0 = v706} : Mut4
                    let v708 : US0 = US0_4
                    let v709 : string = $"%A{v708}"
                    let v713 : string = $"{v709}"
                    let v716 : unit = ()
                    let v717 : (unit -> unit) = closure9(v707, v713)
                    let v718 : unit = (fun () -> v717 (); v716) ()
                    let v721 : string = v707.l0
                    let v722 : bool = v721.StartsWith v703 
                    let v728 : US1 =
                        if v722 then
                            let v725 : string = "Info"
                            US1_0(v725)
                        else
                            US1_1
                    match v728 with
                    | US1_1 -> (* None *)
                        let v731 : unit = ()
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v732 : string = method11()
                        let _v731 = v732 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        let v733 : string = method11()
                        let _v731 = v733 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        let v734 : string = method11()
                        let _v731 = v734 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        let v735 : string = method12()
                        let _v731 = v735 
                        #endif
#if FABLE_COMPILER_PYTHON
                        let v736 : string = method12()
                        let _v731 = v736 
                        #endif
#else
                        let v737 : string = method12()
                        let _v731 = v737 
                        #endif
                        let v738 : string = _v731 
                        let v743 : string = method13()
                        let v744 : Mut4 = {l0 = v743} : Mut4
                        let v745 : US0 = US0_3
                        let v746 : string = $"%A{v745}"
                        let v750 : string = $"{v746}"
                        let v753 : unit = ()
                        let v754 : (unit -> unit) = closure9(v744, v750)
                        let v755 : unit = (fun () -> v754 (); v753) ()
                        let v758 : string = v744.l0
                        let v759 : (string []) = v758.Split v738 
                        let v762 : string = v759.[int 0]
                        let v765 : string = method13()
                        let v766 : Mut4 = {l0 = v765} : Mut4
                        let v767 : US0 = US0_4
                        let v768 : string = $"%A{v767}"
                        let v772 : string = $"{v768}"
                        let v775 : unit = ()
                        let v776 : (unit -> unit) = closure9(v766, v772)
                        let v777 : unit = (fun () -> v776 (); v775) ()
                        let v780 : string = v766.l0
                        let v781 : bool = v780.StartsWith v762 
                        let v787 : US1 =
                            if v781 then
                                let v784 : string = "Warning"
                                US1_0(v784)
                            else
                                US1_1
                        match v787 with
                        | US1_1 -> (* None *)
                            let v790 : string = "Critical"
                            US1_0(v790)
                        | US1_0(v788) -> (* Some *)
                            US1_0(v788)
                    | US1_0(v729) -> (* Some *)
                        US1_0(v729)
                | US1_0(v670) -> (* Some *)
                    US1_0(v670)
            | US1_0(v611) -> (* Some *)
                US1_0(v611)
        let v803 : string =
            match v799 with
            | US1_1 -> (* None *)
                failwith<string> "Option does not have a value."
            | US1_0(v800) -> (* Some *)
                v800
        let v804 : (unit -> string) = v803.ToLower
        let v805 : string = v804 ()
        let v808 : string = v805.PadLeft (7, ' ')
        let v822 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v823 : string = "inline_colorization::color_bright_red"
        let v824 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v823 
        let v825 : string = "&*$0"
        let v826 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v808 v825 
        let v827 : string = "inline_colorization::color_reset"
        let v828 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v827 
        let v829 : string = "\"{v824}{v826}{v828}\""
        let v830 : string = @$"format!(" + v829 + ")"
        let v831 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v830 
        let v832 : string = "fable_library_rust::String_::fromString($0)"
        let v833 : string = Fable.Core.RustInterop.emitRustExpr v831 v832 
        let _v822 = v833 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v834 : string = "inline_colorization::color_bright_red"
        let v835 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v834 
        let v836 : string = "&*$0"
        let v837 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v808 v836 
        let v838 : string = "inline_colorization::color_reset"
        let v839 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v838 
        let v840 : string = "\"{v835}{v837}{v839}\""
        let v841 : string = @$"format!(" + v840 + ")"
        let v842 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v841 
        let v843 : string = "fable_library_rust::String_::fromString($0)"
        let v844 : string = Fable.Core.RustInterop.emitRustExpr v842 v843 
        let _v822 = v844 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v845 : string = "inline_colorization::color_bright_red"
        let v846 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v845 
        let v847 : string = "&*$0"
        let v848 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v808 v847 
        let v849 : string = "inline_colorization::color_reset"
        let v850 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v849 
        let v851 : string = "\"{v846}{v848}{v850}\""
        let v852 : string = @$"format!(" + v851 + ")"
        let v853 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v852 
        let v854 : string = "fable_library_rust::String_::fromString($0)"
        let v855 : string = Fable.Core.RustInterop.emitRustExpr v853 v854 
        let _v822 = v855 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v856 : string = "\u001b[91m"
        let v857 : string = method14()
        let v858 : string = v856 + v808 
        let v859 : string = v858 + v857 
        let _v822 = v859 
        #endif
#if FABLE_COMPILER_PYTHON
        let v860 : string = "\u001b[91m"
        let v861 : string = method14()
        let v862 : string = v860 + v808 
        let v863 : string = v862 + v861 
        let _v822 = v863 
        #endif
#else
        let v864 : string = "\u001b[91m"
        let v865 : string = method14()
        let v866 : string = v864 + v808 
        let v867 : string = v866 + v865 
        let _v822 = v867 
        #endif
        let v868 : string = _v822 
        let v874 : int64 = v86.l0
        let v875 : string = method13()
        let v876 : Mut4 = {l0 = v875} : Mut4
        let v877 : string = "{ "
        let v878 : string = $"{v877}"
        let v881 : unit = ()
        let v882 : (unit -> unit) = closure9(v876, v878)
        let v883 : unit = (fun () -> v882 (); v881) ()
        let v886 : string = "dir"
        let v887 : string = $"{v886}"
        let v890 : unit = ()
        let v891 : (unit -> unit) = closure9(v876, v887)
        let v892 : unit = (fun () -> v891 (); v890) ()
        let v895 : string = " = "
        let v896 : string = $"{v895}"
        let v899 : unit = ()
        let v900 : (unit -> unit) = closure9(v876, v896)
        let v901 : unit = (fun () -> v900 (); v899) ()
        let v904 : string = $"{v0}"
        let v907 : unit = ()
        let v908 : (unit -> unit) = closure9(v876, v904)
        let v909 : unit = (fun () -> v908 (); v907) ()
        let v912 : string = "; "
        let v913 : string = $"{v912}"
        let v916 : unit = ()
        let v917 : (unit -> unit) = closure9(v876, v913)
        let v918 : unit = (fun () -> v917 (); v916) ()
        let v921 : string = "error"
        let v922 : string = $"{v921}"
        let v925 : unit = ()
        let v926 : (unit -> unit) = closure9(v876, v922)
        let v927 : unit = (fun () -> v926 (); v925) ()
        let v930 : string = $"{v895}"
        let v933 : unit = ()
        let v934 : (unit -> unit) = closure9(v876, v930)
        let v935 : unit = (fun () -> v934 (); v933) ()
        let v938 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v939 : string = "format!(\"{:#?}\", $0)"
        let v940 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1 v939 
        let v941 : string = "fable_library_rust::String_::fromString($0)"
        let v942 : string = Fable.Core.RustInterop.emitRustExpr v940 v941 
        let _v938 = v942 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v943 : string = "format!(\"{:#?}\", $0)"
        let v944 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1 v943 
        let v945 : string = "fable_library_rust::String_::fromString($0)"
        let v946 : string = Fable.Core.RustInterop.emitRustExpr v944 v945 
        let _v938 = v946 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v947 : string = "format!(\"{:#?}\", $0)"
        let v948 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1 v947 
        let v949 : string = "fable_library_rust::String_::fromString($0)"
        let v950 : string = Fable.Core.RustInterop.emitRustExpr v948 v949 
        let _v938 = v950 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v951 : string = $"%A{v1}"
        let _v938 = v951 
        #endif
#if FABLE_COMPILER_PYTHON
        let v954 : string = $"%A{v1}"
        let _v938 = v954 
        #endif
#else
        let v957 : string = $"%A{v1}"
        let _v938 = v957 
        #endif
        let v960 : string = _v938 
        let v965 : string = $"{v960}"
        let v968 : unit = ()
        let v969 : (unit -> unit) = closure9(v876, v965)
        let v970 : unit = (fun () -> v969 (); v968) ()
        let v973 : string = " }"
        let v974 : string = $"{v973}"
        let v977 : unit = ()
        let v978 : (unit -> unit) = closure9(v876, v974)
        let v979 : unit = (fun () -> v978 (); v977) ()
        let v982 : string = v876.l0
        let v983 : (unit -> string) = closure49()
        let v984 : string = $"{v484} {v868} #{v874} %s{v983 ()} / {v982}"
        let v987 : char list = []
        let v988 : (char list -> (char [])) = List.toArray
        let v989 : (char []) = v988 v987
        let v992 : string = v984.TrimStart v989 
        let v1010 : char list = []
        let v1011 : char list = '/' :: v1010 
        let v1014 : char list = ' ' :: v1011 
        let v1017 : (char list -> (char [])) = List.toArray
        let v1018 : (char []) = v1017 v1014
        let v1021 : string = v992.TrimEnd v1018 
        let v1039 : (string -> unit) = closure11()
        let v1040 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v1041 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v1021 v1041 
        let _v1040 = () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v1042 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v1021 v1042 
        let _v1040 = () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v1043 : string = $"near_sdk::log!(\"{{}}\", $0)"
        Fable.Core.RustInterop.emitRustExpr v1021 v1043 
        let _v1040 = () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        v1039 v1021
        let _v1040 = () 
        #endif
#if FABLE_COMPILER_PYTHON
        v1039 v1021
        let _v1040 = () 
        #endif
#else
        v1039 v1021
        let _v1040 = () 
        #endif
        _v1040 
        let v1044 : (string -> unit) = v18.l0
        v1044 v1021
and closure51 () () : string =
    let v0 : string = "file_system.create_dir"
    v0
and closure50 (v0 : string) () : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure0()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v16 : Mut0, v17 : Mut1, v18 : Mut2, v19 : Mut3, v20 : int64 option) = State.trace_state.Value
    let v31 : unit = ()
    let v32 : unit = (fun () -> v2 (); v31) ()
    let struct (v45 : Mut0, v46 : Mut1, v47 : Mut2, v48 : Mut3, v49 : int64 option) = State.trace_state.Value
    let v60 : US0 = v48.l0
    let v61 : bool = v47.l0
    let v62 : bool = v61 = false
    let v65 : bool =
        if v62 then
            false
        else
            let v63 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v60
            let v64 : bool = 0 >= v63
            v64
    if v65 then
        let v66 : unit = ()
        let v67 : (unit -> unit) = closure6(v16)
        let v68 : unit = (fun () -> v67 (); v66) ()
        let v71 : unit = ()
        let v72 : unit = (fun () -> v2 (); v71) ()
        let struct (v85 : Mut0, v86 : Mut1, v87 : Mut2, v88 : Mut3, v89 : int64 option) = State.trace_state.Value
        let v100 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v101 : US3 option = None
        let _v101 = ref v101 
        let v102 : US3 option ref = _v101 
        let v103 : (US3 option -> US3 option ref) = closure7(v102)
        let v104 : unit = ()
        let v105 : (unit -> unit) = closure8(v89, v103)
        let v106 : unit = (fun () -> v105 (); v104) ()
        let v109 : US3 option = _v101.Value 
        let v120 : US3 = US3_1
        let v121 : US3 = v109 |> Option.defaultValue v120 
        let v161 : System.DateTime =
            match v121 with
            | US3_1 -> (* None *)
                let v157 : System.DateTime = System.DateTime.Now
                v157
            | US3_0(v125) -> (* Some *)
                let v126 : System.DateTime = System.DateTime.Now
                let v129 : (System.DateTime -> int64) = _.Ticks
                let v130 : int64 = v129 v126
                let v133 : int64 = v130 - v125
                let v134 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v135 : System.TimeSpan = v134 v133
                let v138 : (System.TimeSpan -> int32) = _.Hours
                let v139 : int32 = v138 v135
                let v142 : (System.TimeSpan -> int32) = _.Minutes
                let v143 : int32 = v142 v135
                let v146 : (System.TimeSpan -> int32) = _.Seconds
                let v147 : int32 = v146 v135
                let v150 : (System.TimeSpan -> int32) = _.Milliseconds
                let v151 : int32 = v150 v135
                let v154 : System.DateTime = System.DateTime (1, 1, 1, v139, v143, v147, v151)
                v154
        let v162 : string = method9()
        let v165 : (string -> string) = v161.ToString
        let v166 : string = v165 v162
        let _v100 = v166 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v169 : US3 option = None
        let _v169 = ref v169 
        let v170 : US3 option ref = _v169 
        let v171 : (US3 option -> US3 option ref) = closure7(v170)
        let v172 : unit = ()
        let v173 : (unit -> unit) = closure8(v89, v171)
        let v174 : unit = (fun () -> v173 (); v172) ()
        let v177 : US3 option = _v169.Value 
        let v188 : US3 = US3_1
        let v189 : US3 = v177 |> Option.defaultValue v188 
        let v229 : System.DateTime =
            match v189 with
            | US3_1 -> (* None *)
                let v225 : System.DateTime = System.DateTime.Now
                v225
            | US3_0(v193) -> (* Some *)
                let v194 : System.DateTime = System.DateTime.Now
                let v197 : (System.DateTime -> int64) = _.Ticks
                let v198 : int64 = v197 v194
                let v201 : int64 = v198 - v193
                let v202 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v203 : System.TimeSpan = v202 v201
                let v206 : (System.TimeSpan -> int32) = _.Hours
                let v207 : int32 = v206 v203
                let v210 : (System.TimeSpan -> int32) = _.Minutes
                let v211 : int32 = v210 v203
                let v214 : (System.TimeSpan -> int32) = _.Seconds
                let v215 : int32 = v214 v203
                let v218 : (System.TimeSpan -> int32) = _.Milliseconds
                let v219 : int32 = v218 v203
                let v222 : System.DateTime = System.DateTime (1, 1, 1, v207, v211, v215, v219)
                v222
        let v230 : string = method9()
        let v233 : (string -> string) = v229.ToString
        let v234 : string = v233 v230
        let _v100 = v234 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v237 : string = $"near_sdk::env::block_timestamp()"
        let v238 : uint64 = Fable.Core.RustInterop.emitRustExpr () v237 
        let v239 : US3 option = None
        let _v239 = ref v239 
        let v240 : US3 option ref = _v239 
        let v241 : (US3 option -> US3 option ref) = closure7(v240)
        let v242 : unit = ()
        let v243 : (unit -> unit) = closure8(v89, v241)
        let v244 : unit = (fun () -> v243 (); v242) ()
        let v247 : US3 option = _v239.Value 
        let v258 : US3 = US3_1
        let v259 : US3 = v247 |> Option.defaultValue v258 
        let v268 : uint64 =
            match v259 with
            | US3_1 -> (* None *)
                v238
            | US3_0(v263) -> (* Some *)
                let v264 : (int64 -> uint64) = uint64
                let v265 : uint64 = v264 v263
                let v266 : uint64 = v238 - v265
                v266
        let v269 : uint64 = v268 / 1000000000UL
        let v270 : uint64 = v269 % 60UL
        let v271 : uint64 = v269 / 60UL
        let v272 : uint64 = v271 % 60UL
        let v273 : uint64 = v269 / 3600UL
        let v274 : uint64 = v273 % 24UL
        let v275 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
        let v276 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v274, v272, v270) v275 
        let v277 : string = "fable_library_rust::String_::fromString($0)"
        let v278 : string = Fable.Core.RustInterop.emitRustExpr v276 v277 
        let _v100 = v278 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v279 : US3 option = None
        let _v279 = ref v279 
        let v280 : US3 option ref = _v279 
        let v281 : (US3 option -> US3 option ref) = closure7(v280)
        let v282 : unit = ()
        let v283 : (unit -> unit) = closure8(v89, v281)
        let v284 : unit = (fun () -> v283 (); v282) ()
        let v287 : US3 option = _v279.Value 
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
        let v340 : string = method10()
        let v343 : (string -> string) = v339.ToString
        let v344 : string = v343 v340
        let _v100 = v344 
        #endif
#if FABLE_COMPILER_PYTHON
        let v347 : US3 option = None
        let _v347 = ref v347 
        let v348 : US3 option ref = _v347 
        let v349 : (US3 option -> US3 option ref) = closure7(v348)
        let v350 : unit = ()
        let v351 : (unit -> unit) = closure8(v89, v349)
        let v352 : unit = (fun () -> v351 (); v350) ()
        let v355 : US3 option = _v347.Value 
        let v366 : US3 = US3_1
        let v367 : US3 = v355 |> Option.defaultValue v366 
        let v407 : System.DateTime =
            match v367 with
            | US3_1 -> (* None *)
                let v403 : System.DateTime = System.DateTime.Now
                v403
            | US3_0(v371) -> (* Some *)
                let v372 : System.DateTime = System.DateTime.Now
                let v375 : (System.DateTime -> int64) = _.Ticks
                let v376 : int64 = v375 v372
                let v379 : int64 = v376 - v371
                let v380 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v381 : System.TimeSpan = v380 v379
                let v384 : (System.TimeSpan -> int32) = _.Hours
                let v385 : int32 = v384 v381
                let v388 : (System.TimeSpan -> int32) = _.Minutes
                let v389 : int32 = v388 v381
                let v392 : (System.TimeSpan -> int32) = _.Seconds
                let v393 : int32 = v392 v381
                let v396 : (System.TimeSpan -> int32) = _.Milliseconds
                let v397 : int32 = v396 v381
                let v400 : System.DateTime = System.DateTime (1, 1, 1, v385, v389, v393, v397)
                v400
        let v408 : string = method10()
        let v411 : (string -> string) = v407.ToString
        let v412 : string = v411 v408
        let _v100 = v412 
        #endif
#else
        let v415 : US3 option = None
        let _v415 = ref v415 
        let v416 : US3 option ref = _v415 
        let v417 : (US3 option -> US3 option ref) = closure7(v416)
        let v418 : unit = ()
        let v419 : (unit -> unit) = closure8(v89, v417)
        let v420 : unit = (fun () -> v419 (); v418) ()
        let v423 : US3 option = _v415.Value 
        let v434 : US3 = US3_1
        let v435 : US3 = v423 |> Option.defaultValue v434 
        let v475 : System.DateTime =
            match v435 with
            | US3_1 -> (* None *)
                let v471 : System.DateTime = System.DateTime.Now
                v471
            | US3_0(v439) -> (* Some *)
                let v440 : System.DateTime = System.DateTime.Now
                let v443 : (System.DateTime -> int64) = _.Ticks
                let v444 : int64 = v443 v440
                let v447 : int64 = v444 - v439
                let v448 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v449 : System.TimeSpan = v448 v447
                let v452 : (System.TimeSpan -> int32) = _.Hours
                let v453 : int32 = v452 v449
                let v456 : (System.TimeSpan -> int32) = _.Minutes
                let v457 : int32 = v456 v449
                let v460 : (System.TimeSpan -> int32) = _.Seconds
                let v461 : int32 = v460 v449
                let v464 : (System.TimeSpan -> int32) = _.Milliseconds
                let v465 : int32 = v464 v449
                let v468 : System.DateTime = System.DateTime (1, 1, 1, v453, v457, v461, v465)
                v468
        let v476 : string = method10()
        let v479 : (string -> string) = v475.ToString
        let v480 : string = v479 v476
        let _v100 = v480 
        #endif
        let v483 : string = _v100 
        
        
        
        
        
        let v553 : string = "Verbose"
        let v554 : (unit -> string) = v553.ToLower
        let v555 : string = v554 ()
        let v558 : string = v555.PadLeft (7, ' ')
        let v572 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v573 : string = "inline_colorization::color_bright_black"
        let v574 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v573 
        let v575 : string = "&*$0"
        let v576 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v558 v575 
        let v577 : string = "inline_colorization::color_reset"
        let v578 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v577 
        let v579 : string = "\"{v574}{v576}{v578}\""
        let v580 : string = @$"format!(" + v579 + ")"
        let v581 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v580 
        let v582 : string = "fable_library_rust::String_::fromString($0)"
        let v583 : string = Fable.Core.RustInterop.emitRustExpr v581 v582 
        let _v572 = v583 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v584 : string = "inline_colorization::color_bright_black"
        let v585 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v584 
        let v586 : string = "&*$0"
        let v587 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v558 v586 
        let v588 : string = "inline_colorization::color_reset"
        let v589 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v588 
        let v590 : string = "\"{v585}{v587}{v589}\""
        let v591 : string = @$"format!(" + v590 + ")"
        let v592 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v591 
        let v593 : string = "fable_library_rust::String_::fromString($0)"
        let v594 : string = Fable.Core.RustInterop.emitRustExpr v592 v593 
        let _v572 = v594 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v595 : string = "inline_colorization::color_bright_black"
        let v596 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v595 
        let v597 : string = "&*$0"
        let v598 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v558 v597 
        let v599 : string = "inline_colorization::color_reset"
        let v600 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v599 
        let v601 : string = "\"{v596}{v598}{v600}\""
        let v602 : string = @$"format!(" + v601 + ")"
        let v603 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v602 
        let v604 : string = "fable_library_rust::String_::fromString($0)"
        let v605 : string = Fable.Core.RustInterop.emitRustExpr v603 v604 
        let _v572 = v605 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v606 : string = "\u001b[90m"
        let v607 : string = method14()
        let v608 : string = v606 + v558 
        let v609 : string = v608 + v607 
        let _v572 = v609 
        #endif
#if FABLE_COMPILER_PYTHON
        let v610 : string = "\u001b[90m"
        let v611 : string = method14()
        let v612 : string = v610 + v558 
        let v613 : string = v612 + v611 
        let _v572 = v613 
        #endif
#else
        let v614 : string = "\u001b[90m"
        let v615 : string = method14()
        let v616 : string = v614 + v558 
        let v617 : string = v616 + v615 
        let _v572 = v617 
        #endif
        let v618 : string = _v572 
        let v624 : int64 = v85.l0
        let v625 : string = method13()
        let v626 : Mut4 = {l0 = v625} : Mut4
        let v627 : string = "{ "
        let v628 : string = $"{v627}"
        let v631 : unit = ()
        let v632 : (unit -> unit) = closure9(v626, v628)
        let v633 : unit = (fun () -> v632 (); v631) ()
        let v636 : string = "dir"
        let v637 : string = $"{v636}"
        let v640 : unit = ()
        let v641 : (unit -> unit) = closure9(v626, v637)
        let v642 : unit = (fun () -> v641 (); v640) ()
        let v645 : string = " = "
        let v646 : string = $"{v645}"
        let v649 : unit = ()
        let v650 : (unit -> unit) = closure9(v626, v646)
        let v651 : unit = (fun () -> v650 (); v649) ()
        let v654 : string = $"{v0}"
        let v657 : unit = ()
        let v658 : (unit -> unit) = closure9(v626, v654)
        let v659 : unit = (fun () -> v658 (); v657) ()
        let v662 : string = " }"
        let v663 : string = $"{v662}"
        let v666 : unit = ()
        let v667 : (unit -> unit) = closure9(v626, v663)
        let v668 : unit = (fun () -> v667 (); v666) ()
        let v671 : string = v626.l0
        let v672 : (unit -> string) = closure51()
        let v673 : string = $"{v483} {v618} #{v624} %s{v672 ()} / {v671}"
        let v676 : char list = []
        let v677 : (char list -> (char [])) = List.toArray
        let v678 : (char []) = v677 v676
        let v681 : string = v673.TrimStart v678 
        let v699 : char list = []
        let v700 : char list = '/' :: v699 
        let v703 : char list = ' ' :: v700 
        let v706 : (char list -> (char [])) = List.toArray
        let v707 : (char []) = v706 v703
        let v710 : string = v681.TrimEnd v707 
        let v728 : (string -> unit) = closure11()
        let v729 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v730 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v710 v730 
        let _v729 = () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v731 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v710 v731 
        let _v729 = () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v732 : string = $"near_sdk::log!(\"{{}}\", $0)"
        Fable.Core.RustInterop.emitRustExpr v710 v732 
        let _v729 = () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        v728 v710
        let _v729 = () 
        #endif
#if FABLE_COMPILER_PYTHON
        v728 v710
        let _v729 = () 
        #endif
#else
        v728 v710
        let _v729 = () 
        #endif
        _v729 
        let v733 : (string -> unit) = v17.l0
        v733 v710
and closure52 (v0 : string) () : unit =
    let v1 : bool = true
    method6(v1, v0)
and method40 (v0 : string) : (unit -> unit) =
    closure52(v0)
and method41 (v0 : string) : (unit -> unit) =
    closure52(v0)
and closure54 () () : string =
    let v0 : string = "file_system.create_dir"
    v0
and closure53 (v0 : string, v1 : string) () : unit =
    let v2 : unit = ()
    let v3 : (unit -> unit) = closure0()
    let v4 : unit = (fun () -> v3 (); v2) ()
    let struct (v17 : Mut0, v18 : Mut1, v19 : Mut2, v20 : Mut3, v21 : int64 option) = State.trace_state.Value
    let v32 : unit = ()
    let v33 : unit = (fun () -> v3 (); v32) ()
    let struct (v46 : Mut0, v47 : Mut1, v48 : Mut2, v49 : Mut3, v50 : int64 option) = State.trace_state.Value
    let v61 : US0 = v49.l0
    let v62 : bool = v48.l0
    let v63 : bool = v62 = false
    let v66 : bool =
        if v63 then
            false
        else
            let v64 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v61
            let v65 : bool = 1 >= v64
            v65
    if v66 then
        let v67 : unit = ()
        let v68 : (unit -> unit) = closure6(v17)
        let v69 : unit = (fun () -> v68 (); v67) ()
        let v72 : unit = ()
        let v73 : unit = (fun () -> v3 (); v72) ()
        let struct (v86 : Mut0, v87 : Mut1, v88 : Mut2, v89 : Mut3, v90 : int64 option) = State.trace_state.Value
        let v101 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v102 : US3 option = None
        let _v102 = ref v102 
        let v103 : US3 option ref = _v102 
        let v104 : (US3 option -> US3 option ref) = closure7(v103)
        let v105 : unit = ()
        let v106 : (unit -> unit) = closure8(v90, v104)
        let v107 : unit = (fun () -> v106 (); v105) ()
        let v110 : US3 option = _v102.Value 
        let v121 : US3 = US3_1
        let v122 : US3 = v110 |> Option.defaultValue v121 
        let v162 : System.DateTime =
            match v122 with
            | US3_1 -> (* None *)
                let v158 : System.DateTime = System.DateTime.Now
                v158
            | US3_0(v126) -> (* Some *)
                let v127 : System.DateTime = System.DateTime.Now
                let v130 : (System.DateTime -> int64) = _.Ticks
                let v131 : int64 = v130 v127
                let v134 : int64 = v131 - v126
                let v135 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v136 : System.TimeSpan = v135 v134
                let v139 : (System.TimeSpan -> int32) = _.Hours
                let v140 : int32 = v139 v136
                let v143 : (System.TimeSpan -> int32) = _.Minutes
                let v144 : int32 = v143 v136
                let v147 : (System.TimeSpan -> int32) = _.Seconds
                let v148 : int32 = v147 v136
                let v151 : (System.TimeSpan -> int32) = _.Milliseconds
                let v152 : int32 = v151 v136
                let v155 : System.DateTime = System.DateTime (1, 1, 1, v140, v144, v148, v152)
                v155
        let v163 : string = method9()
        let v166 : (string -> string) = v162.ToString
        let v167 : string = v166 v163
        let _v101 = v167 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v170 : US3 option = None
        let _v170 = ref v170 
        let v171 : US3 option ref = _v170 
        let v172 : (US3 option -> US3 option ref) = closure7(v171)
        let v173 : unit = ()
        let v174 : (unit -> unit) = closure8(v90, v172)
        let v175 : unit = (fun () -> v174 (); v173) ()
        let v178 : US3 option = _v170.Value 
        let v189 : US3 = US3_1
        let v190 : US3 = v178 |> Option.defaultValue v189 
        let v230 : System.DateTime =
            match v190 with
            | US3_1 -> (* None *)
                let v226 : System.DateTime = System.DateTime.Now
                v226
            | US3_0(v194) -> (* Some *)
                let v195 : System.DateTime = System.DateTime.Now
                let v198 : (System.DateTime -> int64) = _.Ticks
                let v199 : int64 = v198 v195
                let v202 : int64 = v199 - v194
                let v203 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v204 : System.TimeSpan = v203 v202
                let v207 : (System.TimeSpan -> int32) = _.Hours
                let v208 : int32 = v207 v204
                let v211 : (System.TimeSpan -> int32) = _.Minutes
                let v212 : int32 = v211 v204
                let v215 : (System.TimeSpan -> int32) = _.Seconds
                let v216 : int32 = v215 v204
                let v219 : (System.TimeSpan -> int32) = _.Milliseconds
                let v220 : int32 = v219 v204
                let v223 : System.DateTime = System.DateTime (1, 1, 1, v208, v212, v216, v220)
                v223
        let v231 : string = method9()
        let v234 : (string -> string) = v230.ToString
        let v235 : string = v234 v231
        let _v101 = v235 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v238 : string = $"near_sdk::env::block_timestamp()"
        let v239 : uint64 = Fable.Core.RustInterop.emitRustExpr () v238 
        let v240 : US3 option = None
        let _v240 = ref v240 
        let v241 : US3 option ref = _v240 
        let v242 : (US3 option -> US3 option ref) = closure7(v241)
        let v243 : unit = ()
        let v244 : (unit -> unit) = closure8(v90, v242)
        let v245 : unit = (fun () -> v244 (); v243) ()
        let v248 : US3 option = _v240.Value 
        let v259 : US3 = US3_1
        let v260 : US3 = v248 |> Option.defaultValue v259 
        let v269 : uint64 =
            match v260 with
            | US3_1 -> (* None *)
                v239
            | US3_0(v264) -> (* Some *)
                let v265 : (int64 -> uint64) = uint64
                let v266 : uint64 = v265 v264
                let v267 : uint64 = v239 - v266
                v267
        let v270 : uint64 = v269 / 1000000000UL
        let v271 : uint64 = v270 % 60UL
        let v272 : uint64 = v270 / 60UL
        let v273 : uint64 = v272 % 60UL
        let v274 : uint64 = v270 / 3600UL
        let v275 : uint64 = v274 % 24UL
        let v276 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
        let v277 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v275, v273, v271) v276 
        let v278 : string = "fable_library_rust::String_::fromString($0)"
        let v279 : string = Fable.Core.RustInterop.emitRustExpr v277 v278 
        let _v101 = v279 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v280 : US3 option = None
        let _v280 = ref v280 
        let v281 : US3 option ref = _v280 
        let v282 : (US3 option -> US3 option ref) = closure7(v281)
        let v283 : unit = ()
        let v284 : (unit -> unit) = closure8(v90, v282)
        let v285 : unit = (fun () -> v284 (); v283) ()
        let v288 : US3 option = _v280.Value 
        let v299 : US3 = US3_1
        let v300 : US3 = v288 |> Option.defaultValue v299 
        let v340 : System.DateTime =
            match v300 with
            | US3_1 -> (* None *)
                let v336 : System.DateTime = System.DateTime.Now
                v336
            | US3_0(v304) -> (* Some *)
                let v305 : System.DateTime = System.DateTime.Now
                let v308 : (System.DateTime -> int64) = _.Ticks
                let v309 : int64 = v308 v305
                let v312 : int64 = v309 - v304
                let v313 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v314 : System.TimeSpan = v313 v312
                let v317 : (System.TimeSpan -> int32) = _.Hours
                let v318 : int32 = v317 v314
                let v321 : (System.TimeSpan -> int32) = _.Minutes
                let v322 : int32 = v321 v314
                let v325 : (System.TimeSpan -> int32) = _.Seconds
                let v326 : int32 = v325 v314
                let v329 : (System.TimeSpan -> int32) = _.Milliseconds
                let v330 : int32 = v329 v314
                let v333 : System.DateTime = System.DateTime (1, 1, 1, v318, v322, v326, v330)
                v333
        let v341 : string = method10()
        let v344 : (string -> string) = v340.ToString
        let v345 : string = v344 v341
        let _v101 = v345 
        #endif
#if FABLE_COMPILER_PYTHON
        let v348 : US3 option = None
        let _v348 = ref v348 
        let v349 : US3 option ref = _v348 
        let v350 : (US3 option -> US3 option ref) = closure7(v349)
        let v351 : unit = ()
        let v352 : (unit -> unit) = closure8(v90, v350)
        let v353 : unit = (fun () -> v352 (); v351) ()
        let v356 : US3 option = _v348.Value 
        let v367 : US3 = US3_1
        let v368 : US3 = v356 |> Option.defaultValue v367 
        let v408 : System.DateTime =
            match v368 with
            | US3_1 -> (* None *)
                let v404 : System.DateTime = System.DateTime.Now
                v404
            | US3_0(v372) -> (* Some *)
                let v373 : System.DateTime = System.DateTime.Now
                let v376 : (System.DateTime -> int64) = _.Ticks
                let v377 : int64 = v376 v373
                let v380 : int64 = v377 - v372
                let v381 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v382 : System.TimeSpan = v381 v380
                let v385 : (System.TimeSpan -> int32) = _.Hours
                let v386 : int32 = v385 v382
                let v389 : (System.TimeSpan -> int32) = _.Minutes
                let v390 : int32 = v389 v382
                let v393 : (System.TimeSpan -> int32) = _.Seconds
                let v394 : int32 = v393 v382
                let v397 : (System.TimeSpan -> int32) = _.Milliseconds
                let v398 : int32 = v397 v382
                let v401 : System.DateTime = System.DateTime (1, 1, 1, v386, v390, v394, v398)
                v401
        let v409 : string = method10()
        let v412 : (string -> string) = v408.ToString
        let v413 : string = v412 v409
        let _v101 = v413 
        #endif
#else
        let v416 : US3 option = None
        let _v416 = ref v416 
        let v417 : US3 option ref = _v416 
        let v418 : (US3 option -> US3 option ref) = closure7(v417)
        let v419 : unit = ()
        let v420 : (unit -> unit) = closure8(v90, v418)
        let v421 : unit = (fun () -> v420 (); v419) ()
        let v424 : US3 option = _v416.Value 
        let v435 : US3 = US3_1
        let v436 : US3 = v424 |> Option.defaultValue v435 
        let v476 : System.DateTime =
            match v436 with
            | US3_1 -> (* None *)
                let v472 : System.DateTime = System.DateTime.Now
                v472
            | US3_0(v440) -> (* Some *)
                let v441 : System.DateTime = System.DateTime.Now
                let v444 : (System.DateTime -> int64) = _.Ticks
                let v445 : int64 = v444 v441
                let v448 : int64 = v445 - v440
                let v449 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v450 : System.TimeSpan = v449 v448
                let v453 : (System.TimeSpan -> int32) = _.Hours
                let v454 : int32 = v453 v450
                let v457 : (System.TimeSpan -> int32) = _.Minutes
                let v458 : int32 = v457 v450
                let v461 : (System.TimeSpan -> int32) = _.Seconds
                let v462 : int32 = v461 v450
                let v465 : (System.TimeSpan -> int32) = _.Milliseconds
                let v466 : int32 = v465 v450
                let v469 : System.DateTime = System.DateTime (1, 1, 1, v454, v458, v462, v466)
                v469
        let v477 : string = method10()
        let v480 : (string -> string) = v476.ToString
        let v481 : string = v480 v477
        let _v101 = v481 
        #endif
        let v484 : string = _v101 
        
        
        
        
        
        let v554 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v555 : string = method11()
        let _v554 = v555 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v556 : string = method11()
        let _v554 = v556 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v557 : string = method11()
        let _v554 = v557 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v558 : string = method12()
        let _v554 = v558 
        #endif
#if FABLE_COMPILER_PYTHON
        let v559 : string = method12()
        let _v554 = v559 
        #endif
#else
        let v560 : string = method12()
        let _v554 = v560 
        #endif
        let v561 : string = _v554 
        let v566 : string = method13()
        let v567 : Mut4 = {l0 = v566} : Mut4
        let v568 : US0 = US0_0
        let v569 : string = $"%A{v568}"
        let v573 : string = $"{v569}"
        let v576 : unit = ()
        let v577 : (unit -> unit) = closure9(v567, v573)
        let v578 : unit = (fun () -> v577 (); v576) ()
        let v581 : string = v567.l0
        let v582 : (string []) = v581.Split v561 
        let v585 : string = v582.[int 0]
        let v588 : string = method13()
        let v589 : Mut4 = {l0 = v588} : Mut4
        let v590 : US0 = US0_1
        let v591 : string = $"%A{v590}"
        let v595 : string = $"{v591}"
        let v598 : unit = ()
        let v599 : (unit -> unit) = closure9(v589, v595)
        let v600 : unit = (fun () -> v599 (); v598) ()
        let v603 : string = v589.l0
        let v604 : bool = v603.StartsWith v585 
        let v610 : US1 =
            if v604 then
                let v607 : string = "Verbose"
                US1_0(v607)
            else
                US1_1
        let v616 : US1 =
            match v610 with
            | US1_1 -> (* None *)
                let v613 : string = "Debug"
                US1_0(v613)
            | US1_0(v611) -> (* Some *)
                US1_0(v611)
        let v620 : string =
            match v616 with
            | US1_1 -> (* None *)
                failwith<string> "Option does not have a value."
            | US1_0(v617) -> (* Some *)
                v617
        let v621 : (unit -> string) = v620.ToLower
        let v622 : string = v621 ()
        let v625 : string = v622.PadLeft (7, ' ')
        let v639 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v640 : string = "inline_colorization::color_bright_blue"
        let v641 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v640 
        let v642 : string = "&*$0"
        let v643 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v625 v642 
        let v644 : string = "inline_colorization::color_reset"
        let v645 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v644 
        let v646 : string = "\"{v641}{v643}{v645}\""
        let v647 : string = @$"format!(" + v646 + ")"
        let v648 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v647 
        let v649 : string = "fable_library_rust::String_::fromString($0)"
        let v650 : string = Fable.Core.RustInterop.emitRustExpr v648 v649 
        let _v639 = v650 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v651 : string = "inline_colorization::color_bright_blue"
        let v652 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v651 
        let v653 : string = "&*$0"
        let v654 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v625 v653 
        let v655 : string = "inline_colorization::color_reset"
        let v656 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v655 
        let v657 : string = "\"{v652}{v654}{v656}\""
        let v658 : string = @$"format!(" + v657 + ")"
        let v659 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v658 
        let v660 : string = "fable_library_rust::String_::fromString($0)"
        let v661 : string = Fable.Core.RustInterop.emitRustExpr v659 v660 
        let _v639 = v661 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v662 : string = "inline_colorization::color_bright_blue"
        let v663 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v662 
        let v664 : string = "&*$0"
        let v665 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v625 v664 
        let v666 : string = "inline_colorization::color_reset"
        let v667 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v666 
        let v668 : string = "\"{v663}{v665}{v667}\""
        let v669 : string = @$"format!(" + v668 + ")"
        let v670 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v669 
        let v671 : string = "fable_library_rust::String_::fromString($0)"
        let v672 : string = Fable.Core.RustInterop.emitRustExpr v670 v671 
        let _v639 = v672 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v673 : string = "\u001b[94m"
        let v674 : string = method14()
        let v675 : string = v673 + v625 
        let v676 : string = v675 + v674 
        let _v639 = v676 
        #endif
#if FABLE_COMPILER_PYTHON
        let v677 : string = "\u001b[94m"
        let v678 : string = method14()
        let v679 : string = v677 + v625 
        let v680 : string = v679 + v678 
        let _v639 = v680 
        #endif
#else
        let v681 : string = "\u001b[94m"
        let v682 : string = method14()
        let v683 : string = v681 + v625 
        let v684 : string = v683 + v682 
        let _v639 = v684 
        #endif
        let v685 : string = _v639 
        let v691 : int64 = v86.l0
        let v692 : string = method13()
        let v693 : Mut4 = {l0 = v692} : Mut4
        let v694 : string = "{ "
        let v695 : string = $"{v694}"
        let v698 : unit = ()
        let v699 : (unit -> unit) = closure9(v693, v695)
        let v700 : unit = (fun () -> v699 (); v698) ()
        let v703 : string = "dir"
        let v704 : string = $"{v703}"
        let v707 : unit = ()
        let v708 : (unit -> unit) = closure9(v693, v704)
        let v709 : unit = (fun () -> v708 (); v707) ()
        let v712 : string = " = "
        let v713 : string = $"{v712}"
        let v716 : unit = ()
        let v717 : (unit -> unit) = closure9(v693, v713)
        let v718 : unit = (fun () -> v717 (); v716) ()
        let v721 : string = $"{v0}"
        let v724 : unit = ()
        let v725 : (unit -> unit) = closure9(v693, v721)
        let v726 : unit = (fun () -> v725 (); v724) ()
        let v729 : string = "; "
        let v730 : string = $"{v729}"
        let v733 : unit = ()
        let v734 : (unit -> unit) = closure9(v693, v730)
        let v735 : unit = (fun () -> v734 (); v733) ()
        let v738 : string = "result"
        let v739 : string = $"{v738}"
        let v742 : unit = ()
        let v743 : (unit -> unit) = closure9(v693, v739)
        let v744 : unit = (fun () -> v743 (); v742) ()
        let v747 : string = $"{v712}"
        let v750 : unit = ()
        let v751 : (unit -> unit) = closure9(v693, v747)
        let v752 : unit = (fun () -> v751 (); v750) ()
        let v755 : string = $"{v1}"
        let v758 : unit = ()
        let v759 : (unit -> unit) = closure9(v693, v755)
        let v760 : unit = (fun () -> v759 (); v758) ()
        let v763 : string = " }"
        let v764 : string = $"{v763}"
        let v767 : unit = ()
        let v768 : (unit -> unit) = closure9(v693, v764)
        let v769 : unit = (fun () -> v768 (); v767) ()
        let v772 : string = v693.l0
        let v773 : (unit -> string) = closure54()
        let v774 : string = $"{v484} {v685} #{v691} %s{v773 ()} / {v772}"
        let v777 : char list = []
        let v778 : (char list -> (char [])) = List.toArray
        let v779 : (char []) = v778 v777
        let v782 : string = v774.TrimStart v779 
        let v800 : char list = []
        let v801 : char list = '/' :: v800 
        let v804 : char list = ' ' :: v801 
        let v807 : (char list -> (char [])) = List.toArray
        let v808 : (char []) = v807 v804
        let v811 : string = v782.TrimEnd v808 
        let v829 : (string -> unit) = closure11()
        let v830 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v831 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v811 v831 
        let _v830 = () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v832 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v811 v832 
        let _v830 = () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v833 : string = $"near_sdk::log!(\"{{}}\", $0)"
        Fable.Core.RustInterop.emitRustExpr v811 v833 
        let _v830 = () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        v829 v811
        let _v830 = () 
        #endif
#if FABLE_COMPILER_PYTHON
        v829 v811
        let _v830 = () 
        #endif
#else
        v829 v811
        let _v830 = () 
        #endif
        _v830 
        let v834 : (string -> unit) = v18.l0
        v834 v811
and closure55 (v0 : string) () : unit =
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
and method42 (v0 : string) : (unit -> unit) =
    closure55(v0)
and method43 (v0 : string) : (unit -> unit) =
    closure55(v0)
and method37 (v0 : string) : System.IDisposable =
    let v1 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = method38(v0)
    let v3 : string = "std::fs::create_dir_all(&*$0)"
    let v4 : Result<unit, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v2 v3 
    let v5 : (std_io_Error -> std_string_String) = method39()
    let v6 : string = "$0.map_err(|x| $1(x))"
    let v7 : Result<unit, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v4, v5) v6 
    let v8 : (unit -> US12) = closure46()
    let v9 : (std_string_String -> US12) = closure47()
    let v10 : US12 = match v7 with Ok () -> v8 () | Error x -> v9 x
    match v10 with
    | US12_1(v747) -> (* Error *)
        let v748 : unit = ()
        let v749 : (unit -> unit) = closure48(v2, v747)
        let v750 : unit = (fun () -> v749 (); v748) ()
        ()
    | US12_0 -> (* Ok *)
        let v11 : unit = ()
        let v12 : (unit -> unit) = closure50(v2)
        let v13 : unit = (fun () -> v12 (); v11) ()
        ()
    let v1794 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1795 : (unit -> unit) = method40(v2)
    let v1796 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v1795 "$0()" )
    let _v1794 = v1796 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1797 : (unit -> unit) = method40(v2)
    let v1798 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v1797 "$0()" )
    let _v1794 = v1798 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1799 : (unit -> unit) = method40(v2)
    let v1800 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v1799 "$0()" )
    let _v1794 = v1800 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1801 : (unit -> unit) = method41(v2)
    let v1802 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v1801 () }
    let _v1794 = v1802 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1803 : (unit -> unit) = method41(v2)
    let v1804 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v1803 () }
    let _v1794 = v1804 
    #endif
#else
    let v1805 : (unit -> unit) = method41(v2)
    let v1806 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v1805 () }
    let _v1794 = v1806 
    #endif
    let v1807 : System.IDisposable = _v1794 
    let _v1 = v1807 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1811 : System.IDisposable = null |> unbox<System.IDisposable>
    let _v1 = v1811 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1814 : System.IDisposable = null |> unbox<System.IDisposable>
    let _v1 = v1814 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1817 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1818 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    let _v1817 = v1818 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1821 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    let _v1817 = v1821 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1824 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    let _v1817 = v1824 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1827 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    let _v1817 = v1827 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1830 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    let _v1817 = v1830 
    #endif
#else
    let v1833 : (string -> System.IO.DirectoryInfo) = System.IO.Directory.CreateDirectory
    let v1834 : System.IO.DirectoryInfo = v1833 v0
    let _v1817 = v1834 
    #endif
    let v1835 : System.IO.DirectoryInfo = _v1817 
    let v1840 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1841 : bool = null |> unbox<bool>
    let _v1840 = v1841 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1844 : bool = null |> unbox<bool>
    let _v1840 = v1844 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1847 : bool = null |> unbox<bool>
    let _v1840 = v1847 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1850 : bool = null |> unbox<bool>
    let _v1840 = v1850 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1853 : bool = null |> unbox<bool>
    let _v1840 = v1853 
    #endif
#else
    let v1856 : bool = v1835.Exists
    let _v1840 = v1856 
    #endif
    let v1857 : bool = _v1840 
    let v1862 : bool = v1857 = false
    if v1862 then
        let v1863 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v1864 : System.DateTime = null |> unbox<System.DateTime>
        let _v1863 = v1864 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v1867 : System.DateTime = null |> unbox<System.DateTime>
        let _v1863 = v1867 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v1870 : System.DateTime = null |> unbox<System.DateTime>
        let _v1863 = v1870 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v1873 : System.DateTime = null |> unbox<System.DateTime>
        let _v1863 = v1873 
        #endif
#if FABLE_COMPILER_PYTHON
        let v1876 : System.DateTime = null |> unbox<System.DateTime>
        let _v1863 = v1876 
        #endif
#else
        let v1879 : System.DateTime = v1835.CreationTime
        let _v1863 = v1879 
        #endif
        let v1880 : System.DateTime = _v1863 
        let v1885 : obj = {| Exists = v1857; CreationTime = v1880 |}
        let v1886 : string = $"%A{v1885}"
        let v1889 : unit = ()
        let v1890 : (unit -> unit) = closure53(v0, v1886)
        let v1891 : unit = (fun () -> v1890 (); v1889) ()
        ()
    let v2725 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2726 : (unit -> unit) = method42(v0)
    let v2727 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v2726 "$0()" )
    let _v2725 = v2727 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v2728 : (unit -> unit) = method42(v0)
    let v2729 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v2728 "$0()" )
    let _v2725 = v2729 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v2730 : (unit -> unit) = method42(v0)
    let v2731 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v2730 "$0()" )
    let _v2725 = v2731 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v2732 : (unit -> unit) = method43(v0)
    let v2733 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v2732 () }
    let _v2725 = v2733 
    #endif
#if FABLE_COMPILER_PYTHON
    let v2734 : (unit -> unit) = method43(v0)
    let v2735 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v2734 () }
    let _v2725 = v2735 
    #endif
#else
    let v2736 : (unit -> unit) = method43(v0)
    let v2737 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v2736 () }
    let _v2725 = v2737 
    #endif
    let v2738 : System.IDisposable = _v2725 
    let _v1 = v2738 
    #endif
#if FABLE_COMPILER_PYTHON
    let v2742 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2743 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    let _v2742 = v2743 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v2746 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    let _v2742 = v2746 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v2749 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    let _v2742 = v2749 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v2752 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    let _v2742 = v2752 
    #endif
#if FABLE_COMPILER_PYTHON
    let v2755 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    let _v2742 = v2755 
    #endif
#else
    let v2758 : (string -> System.IO.DirectoryInfo) = System.IO.Directory.CreateDirectory
    let v2759 : System.IO.DirectoryInfo = v2758 v0
    let _v2742 = v2759 
    #endif
    let v2760 : System.IO.DirectoryInfo = _v2742 
    let v2765 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2766 : bool = null |> unbox<bool>
    let _v2765 = v2766 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v2769 : bool = null |> unbox<bool>
    let _v2765 = v2769 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v2772 : bool = null |> unbox<bool>
    let _v2765 = v2772 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v2775 : bool = null |> unbox<bool>
    let _v2765 = v2775 
    #endif
#if FABLE_COMPILER_PYTHON
    let v2778 : bool = null |> unbox<bool>
    let _v2765 = v2778 
    #endif
#else
    let v2781 : bool = v2760.Exists
    let _v2765 = v2781 
    #endif
    let v2782 : bool = _v2765 
    let v2787 : bool = v2782 = false
    if v2787 then
        let v2788 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v2789 : System.DateTime = null |> unbox<System.DateTime>
        let _v2788 = v2789 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v2792 : System.DateTime = null |> unbox<System.DateTime>
        let _v2788 = v2792 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v2795 : System.DateTime = null |> unbox<System.DateTime>
        let _v2788 = v2795 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v2798 : System.DateTime = null |> unbox<System.DateTime>
        let _v2788 = v2798 
        #endif
#if FABLE_COMPILER_PYTHON
        let v2801 : System.DateTime = null |> unbox<System.DateTime>
        let _v2788 = v2801 
        #endif
#else
        let v2804 : System.DateTime = v2760.CreationTime
        let _v2788 = v2804 
        #endif
        let v2805 : System.DateTime = _v2788 
        let v2810 : obj = {| Exists = v2782; CreationTime = v2805 |}
        let v2811 : string = $"%A{v2810}"
        let v2814 : unit = ()
        let v2815 : (unit -> unit) = closure53(v0, v2811)
        let v2816 : unit = (fun () -> v2815 (); v2814) ()
        ()
    let v3650 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3651 : (unit -> unit) = method42(v0)
    let v3652 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v3651 "$0()" )
    let _v3650 = v3652 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v3653 : (unit -> unit) = method42(v0)
    let v3654 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v3653 "$0()" )
    let _v3650 = v3654 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v3655 : (unit -> unit) = method42(v0)
    let v3656 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v3655 "$0()" )
    let _v3650 = v3656 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v3657 : (unit -> unit) = method43(v0)
    let v3658 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v3657 () }
    let _v3650 = v3658 
    #endif
#if FABLE_COMPILER_PYTHON
    let v3659 : (unit -> unit) = method43(v0)
    let v3660 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v3659 () }
    let _v3650 = v3660 
    #endif
#else
    let v3661 : (unit -> unit) = method43(v0)
    let v3662 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v3661 () }
    let _v3650 = v3662 
    #endif
    let v3663 : System.IDisposable = _v3650 
    let _v1 = v3663 
    #endif
#else
    let v3667 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3668 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    let _v3667 = v3668 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v3671 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    let _v3667 = v3671 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v3674 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    let _v3667 = v3674 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v3677 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    let _v3667 = v3677 
    #endif
#if FABLE_COMPILER_PYTHON
    let v3680 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    let _v3667 = v3680 
    #endif
#else
    let v3683 : (string -> System.IO.DirectoryInfo) = System.IO.Directory.CreateDirectory
    let v3684 : System.IO.DirectoryInfo = v3683 v0
    let _v3667 = v3684 
    #endif
    let v3685 : System.IO.DirectoryInfo = _v3667 
    let v3690 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3691 : bool = null |> unbox<bool>
    let _v3690 = v3691 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v3694 : bool = null |> unbox<bool>
    let _v3690 = v3694 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v3697 : bool = null |> unbox<bool>
    let _v3690 = v3697 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v3700 : bool = null |> unbox<bool>
    let _v3690 = v3700 
    #endif
#if FABLE_COMPILER_PYTHON
    let v3703 : bool = null |> unbox<bool>
    let _v3690 = v3703 
    #endif
#else
    let v3706 : bool = v3685.Exists
    let _v3690 = v3706 
    #endif
    let v3707 : bool = _v3690 
    let v3712 : bool = v3707 = false
    if v3712 then
        let v3713 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v3714 : System.DateTime = null |> unbox<System.DateTime>
        let _v3713 = v3714 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v3717 : System.DateTime = null |> unbox<System.DateTime>
        let _v3713 = v3717 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v3720 : System.DateTime = null |> unbox<System.DateTime>
        let _v3713 = v3720 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v3723 : System.DateTime = null |> unbox<System.DateTime>
        let _v3713 = v3723 
        #endif
#if FABLE_COMPILER_PYTHON
        let v3726 : System.DateTime = null |> unbox<System.DateTime>
        let _v3713 = v3726 
        #endif
#else
        let v3729 : System.DateTime = v3685.CreationTime
        let _v3713 = v3729 
        #endif
        let v3730 : System.DateTime = _v3713 
        let v3735 : obj = {| Exists = v3707; CreationTime = v3730 |}
        let v3736 : string = $"%A{v3735}"
        let v3739 : unit = ()
        let v3740 : (unit -> unit) = closure53(v0, v3736)
        let v3741 : unit = (fun () -> v3740 (); v3739) ()
        ()
    let v4575 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v4576 : (unit -> unit) = method42(v0)
    let v4577 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v4576 "$0()" )
    let _v4575 = v4577 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v4578 : (unit -> unit) = method42(v0)
    let v4579 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v4578 "$0()" )
    let _v4575 = v4579 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v4580 : (unit -> unit) = method42(v0)
    let v4581 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v4580 "$0()" )
    let _v4575 = v4581 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v4582 : (unit -> unit) = method43(v0)
    let v4583 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v4582 () }
    let _v4575 = v4583 
    #endif
#if FABLE_COMPILER_PYTHON
    let v4584 : (unit -> unit) = method43(v0)
    let v4585 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v4584 () }
    let _v4575 = v4585 
    #endif
#else
    let v4586 : (unit -> unit) = method43(v0)
    let v4587 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v4586 () }
    let _v4575 = v4587 
    #endif
    let v4588 : System.IDisposable = _v4575 
    let _v1 = v4588 
    #endif
    let v4592 : System.IDisposable = _v1 
    v4592
and closure44 () () : struct (string * System.IDisposable) =
    let v0 : string = method24()
    let v1 : System.IDisposable = method37(v0)
    struct (v0, v1)
and method44 (v0 : string) : System.Guid =
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
and closure56 () (v0 : string) : struct (string * System.IDisposable) =
    let v1 : System.Guid = method44(v0)
    let v2 : string = method29(v1)
    let v3 : System.IDisposable = method37(v2)
    struct (v2, v3)
and closure57 () () : string =
    let v0 : string = __SOURCE_DIRECTORY__
    v0
and method46 (v0 : string) : string =
    v0
and method45 (v0 : string) : string =
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
        let v10 : string = method46(v0)
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
and closure58 () (v0 : string) : string =
    method45(v0)
and closure59 () (v0 : string) : string =
    let v1 : char list = []
    let v2 : char list = '/' :: v1 
    let v5 : (char list -> (char [])) = List.toArray
    let v6 : (char []) = v5 v2
    let v9 : string = v0.TrimStart v6 
    let v27 : string = $"file:///{v9}"
    v27
and method49 (v0 : string) : string option =
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
and closure61 () (v0 : string) : string option =
    method49(v0)
and method48 () : (string -> string option) =
    closure61()
and method50 (v0 : string, v1 : string, v2 : string) : US13 =
    let v3 : string = method32(v2, v0)
    let v4 : bool = method8(v3)
    if v4 then
        US13_0(v2)
    else
        let v6 : (string -> string option) = method48()
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
            method50(v0, v1, v32)
and method47 (v0 : string, v1 : string) : US13 =
    let v2 : string = method32(v1, v0)
    let v3 : bool = method8(v2)
    if v3 then
        US13_0(v1)
    else
        let v5 : (string -> string option) = method48()
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
            method50(v0, v1, v31)
and closure63 () () : string =
    let v0 : string = "file_system.get_workspace_root"
    v0
and closure62 (v0 : string) () : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure0()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v16 : Mut0, v17 : Mut1, v18 : Mut2, v19 : Mut3, v20 : int64 option) = State.trace_state.Value
    let v31 : unit = ()
    let v32 : unit = (fun () -> v2 (); v31) ()
    let struct (v45 : Mut0, v46 : Mut1, v47 : Mut2, v48 : Mut3, v49 : int64 option) = State.trace_state.Value
    let v60 : US0 = v48.l0
    let v61 : bool = v47.l0
    let v62 : bool = v61 = false
    let v65 : bool =
        if v62 then
            false
        else
            let v63 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v60
            let v64 : bool = 3 >= v63
            v64
    if v65 then
        let v66 : unit = ()
        let v67 : (unit -> unit) = closure6(v16)
        let v68 : unit = (fun () -> v67 (); v66) ()
        let v71 : unit = ()
        let v72 : unit = (fun () -> v2 (); v71) ()
        let struct (v85 : Mut0, v86 : Mut1, v87 : Mut2, v88 : Mut3, v89 : int64 option) = State.trace_state.Value
        let v100 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v101 : US3 option = None
        let _v101 = ref v101 
        let v102 : US3 option ref = _v101 
        let v103 : (US3 option -> US3 option ref) = closure7(v102)
        let v104 : unit = ()
        let v105 : (unit -> unit) = closure8(v89, v103)
        let v106 : unit = (fun () -> v105 (); v104) ()
        let v109 : US3 option = _v101.Value 
        let v120 : US3 = US3_1
        let v121 : US3 = v109 |> Option.defaultValue v120 
        let v161 : System.DateTime =
            match v121 with
            | US3_1 -> (* None *)
                let v157 : System.DateTime = System.DateTime.Now
                v157
            | US3_0(v125) -> (* Some *)
                let v126 : System.DateTime = System.DateTime.Now
                let v129 : (System.DateTime -> int64) = _.Ticks
                let v130 : int64 = v129 v126
                let v133 : int64 = v130 - v125
                let v134 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v135 : System.TimeSpan = v134 v133
                let v138 : (System.TimeSpan -> int32) = _.Hours
                let v139 : int32 = v138 v135
                let v142 : (System.TimeSpan -> int32) = _.Minutes
                let v143 : int32 = v142 v135
                let v146 : (System.TimeSpan -> int32) = _.Seconds
                let v147 : int32 = v146 v135
                let v150 : (System.TimeSpan -> int32) = _.Milliseconds
                let v151 : int32 = v150 v135
                let v154 : System.DateTime = System.DateTime (1, 1, 1, v139, v143, v147, v151)
                v154
        let v162 : string = method9()
        let v165 : (string -> string) = v161.ToString
        let v166 : string = v165 v162
        let _v100 = v166 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v169 : US3 option = None
        let _v169 = ref v169 
        let v170 : US3 option ref = _v169 
        let v171 : (US3 option -> US3 option ref) = closure7(v170)
        let v172 : unit = ()
        let v173 : (unit -> unit) = closure8(v89, v171)
        let v174 : unit = (fun () -> v173 (); v172) ()
        let v177 : US3 option = _v169.Value 
        let v188 : US3 = US3_1
        let v189 : US3 = v177 |> Option.defaultValue v188 
        let v229 : System.DateTime =
            match v189 with
            | US3_1 -> (* None *)
                let v225 : System.DateTime = System.DateTime.Now
                v225
            | US3_0(v193) -> (* Some *)
                let v194 : System.DateTime = System.DateTime.Now
                let v197 : (System.DateTime -> int64) = _.Ticks
                let v198 : int64 = v197 v194
                let v201 : int64 = v198 - v193
                let v202 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v203 : System.TimeSpan = v202 v201
                let v206 : (System.TimeSpan -> int32) = _.Hours
                let v207 : int32 = v206 v203
                let v210 : (System.TimeSpan -> int32) = _.Minutes
                let v211 : int32 = v210 v203
                let v214 : (System.TimeSpan -> int32) = _.Seconds
                let v215 : int32 = v214 v203
                let v218 : (System.TimeSpan -> int32) = _.Milliseconds
                let v219 : int32 = v218 v203
                let v222 : System.DateTime = System.DateTime (1, 1, 1, v207, v211, v215, v219)
                v222
        let v230 : string = method9()
        let v233 : (string -> string) = v229.ToString
        let v234 : string = v233 v230
        let _v100 = v234 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v237 : string = $"near_sdk::env::block_timestamp()"
        let v238 : uint64 = Fable.Core.RustInterop.emitRustExpr () v237 
        let v239 : US3 option = None
        let _v239 = ref v239 
        let v240 : US3 option ref = _v239 
        let v241 : (US3 option -> US3 option ref) = closure7(v240)
        let v242 : unit = ()
        let v243 : (unit -> unit) = closure8(v89, v241)
        let v244 : unit = (fun () -> v243 (); v242) ()
        let v247 : US3 option = _v239.Value 
        let v258 : US3 = US3_1
        let v259 : US3 = v247 |> Option.defaultValue v258 
        let v268 : uint64 =
            match v259 with
            | US3_1 -> (* None *)
                v238
            | US3_0(v263) -> (* Some *)
                let v264 : (int64 -> uint64) = uint64
                let v265 : uint64 = v264 v263
                let v266 : uint64 = v238 - v265
                v266
        let v269 : uint64 = v268 / 1000000000UL
        let v270 : uint64 = v269 % 60UL
        let v271 : uint64 = v269 / 60UL
        let v272 : uint64 = v271 % 60UL
        let v273 : uint64 = v269 / 3600UL
        let v274 : uint64 = v273 % 24UL
        let v275 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
        let v276 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v274, v272, v270) v275 
        let v277 : string = "fable_library_rust::String_::fromString($0)"
        let v278 : string = Fable.Core.RustInterop.emitRustExpr v276 v277 
        let _v100 = v278 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v279 : US3 option = None
        let _v279 = ref v279 
        let v280 : US3 option ref = _v279 
        let v281 : (US3 option -> US3 option ref) = closure7(v280)
        let v282 : unit = ()
        let v283 : (unit -> unit) = closure8(v89, v281)
        let v284 : unit = (fun () -> v283 (); v282) ()
        let v287 : US3 option = _v279.Value 
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
        let v340 : string = method10()
        let v343 : (string -> string) = v339.ToString
        let v344 : string = v343 v340
        let _v100 = v344 
        #endif
#if FABLE_COMPILER_PYTHON
        let v347 : US3 option = None
        let _v347 = ref v347 
        let v348 : US3 option ref = _v347 
        let v349 : (US3 option -> US3 option ref) = closure7(v348)
        let v350 : unit = ()
        let v351 : (unit -> unit) = closure8(v89, v349)
        let v352 : unit = (fun () -> v351 (); v350) ()
        let v355 : US3 option = _v347.Value 
        let v366 : US3 = US3_1
        let v367 : US3 = v355 |> Option.defaultValue v366 
        let v407 : System.DateTime =
            match v367 with
            | US3_1 -> (* None *)
                let v403 : System.DateTime = System.DateTime.Now
                v403
            | US3_0(v371) -> (* Some *)
                let v372 : System.DateTime = System.DateTime.Now
                let v375 : (System.DateTime -> int64) = _.Ticks
                let v376 : int64 = v375 v372
                let v379 : int64 = v376 - v371
                let v380 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v381 : System.TimeSpan = v380 v379
                let v384 : (System.TimeSpan -> int32) = _.Hours
                let v385 : int32 = v384 v381
                let v388 : (System.TimeSpan -> int32) = _.Minutes
                let v389 : int32 = v388 v381
                let v392 : (System.TimeSpan -> int32) = _.Seconds
                let v393 : int32 = v392 v381
                let v396 : (System.TimeSpan -> int32) = _.Milliseconds
                let v397 : int32 = v396 v381
                let v400 : System.DateTime = System.DateTime (1, 1, 1, v385, v389, v393, v397)
                v400
        let v408 : string = method10()
        let v411 : (string -> string) = v407.ToString
        let v412 : string = v411 v408
        let _v100 = v412 
        #endif
#else
        let v415 : US3 option = None
        let _v415 = ref v415 
        let v416 : US3 option ref = _v415 
        let v417 : (US3 option -> US3 option ref) = closure7(v416)
        let v418 : unit = ()
        let v419 : (unit -> unit) = closure8(v89, v417)
        let v420 : unit = (fun () -> v419 (); v418) ()
        let v423 : US3 option = _v415.Value 
        let v434 : US3 = US3_1
        let v435 : US3 = v423 |> Option.defaultValue v434 
        let v475 : System.DateTime =
            match v435 with
            | US3_1 -> (* None *)
                let v471 : System.DateTime = System.DateTime.Now
                v471
            | US3_0(v439) -> (* Some *)
                let v440 : System.DateTime = System.DateTime.Now
                let v443 : (System.DateTime -> int64) = _.Ticks
                let v444 : int64 = v443 v440
                let v447 : int64 = v444 - v439
                let v448 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v449 : System.TimeSpan = v448 v447
                let v452 : (System.TimeSpan -> int32) = _.Hours
                let v453 : int32 = v452 v449
                let v456 : (System.TimeSpan -> int32) = _.Minutes
                let v457 : int32 = v456 v449
                let v460 : (System.TimeSpan -> int32) = _.Seconds
                let v461 : int32 = v460 v449
                let v464 : (System.TimeSpan -> int32) = _.Milliseconds
                let v465 : int32 = v464 v449
                let v468 : System.DateTime = System.DateTime (1, 1, 1, v453, v457, v461, v465)
                v468
        let v476 : string = method10()
        let v479 : (string -> string) = v475.ToString
        let v480 : string = v479 v476
        let _v100 = v480 
        #endif
        let v483 : string = _v100 
        
        
        
        
        
        let v553 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v554 : string = method11()
        let _v553 = v554 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v555 : string = method11()
        let _v553 = v555 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v556 : string = method11()
        let _v553 = v556 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v557 : string = method12()
        let _v553 = v557 
        #endif
#if FABLE_COMPILER_PYTHON
        let v558 : string = method12()
        let _v553 = v558 
        #endif
#else
        let v559 : string = method12()
        let _v553 = v559 
        #endif
        let v560 : string = _v553 
        let v565 : string = method13()
        let v566 : Mut4 = {l0 = v565} : Mut4
        let v567 : US0 = US0_0
        let v568 : string = $"%A{v567}"
        let v572 : string = $"{v568}"
        let v575 : unit = ()
        let v576 : (unit -> unit) = closure9(v566, v572)
        let v577 : unit = (fun () -> v576 (); v575) ()
        let v580 : string = v566.l0
        let v581 : (string []) = v580.Split v560 
        let v584 : string = v581.[int 0]
        let v587 : string = method13()
        let v588 : Mut4 = {l0 = v587} : Mut4
        let v589 : US0 = US0_3
        let v590 : string = $"%A{v589}"
        let v594 : string = $"{v590}"
        let v597 : unit = ()
        let v598 : (unit -> unit) = closure9(v588, v594)
        let v599 : unit = (fun () -> v598 (); v597) ()
        let v602 : string = v588.l0
        let v603 : bool = v602.StartsWith v584 
        let v609 : US1 =
            if v603 then
                let v606 : string = "Verbose"
                US1_0(v606)
            else
                US1_1
        let v737 : US1 =
            match v609 with
            | US1_1 -> (* None *)
                let v612 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v613 : string = method11()
                let _v612 = v613 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v614 : string = method11()
                let _v612 = v614 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v615 : string = method11()
                let _v612 = v615 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v616 : string = method12()
                let _v612 = v616 
                #endif
#if FABLE_COMPILER_PYTHON
                let v617 : string = method12()
                let _v612 = v617 
                #endif
#else
                let v618 : string = method12()
                let _v612 = v618 
                #endif
                let v619 : string = _v612 
                let v624 : string = method13()
                let v625 : Mut4 = {l0 = v624} : Mut4
                let v626 : US0 = US0_1
                let v627 : string = $"%A{v626}"
                let v631 : string = $"{v627}"
                let v634 : unit = ()
                let v635 : (unit -> unit) = closure9(v625, v631)
                let v636 : unit = (fun () -> v635 (); v634) ()
                let v639 : string = v625.l0
                let v640 : (string []) = v639.Split v619 
                let v643 : string = v640.[int 0]
                let v646 : string = method13()
                let v647 : Mut4 = {l0 = v646} : Mut4
                let v648 : US0 = US0_3
                let v649 : string = $"%A{v648}"
                let v653 : string = $"{v649}"
                let v656 : unit = ()
                let v657 : (unit -> unit) = closure9(v647, v653)
                let v658 : unit = (fun () -> v657 (); v656) ()
                let v661 : string = v647.l0
                let v662 : bool = v661.StartsWith v643 
                let v668 : US1 =
                    if v662 then
                        let v665 : string = "Debug"
                        US1_0(v665)
                    else
                        US1_1
                match v668 with
                | US1_1 -> (* None *)
                    let v671 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v672 : string = method11()
                    let _v671 = v672 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v673 : string = method11()
                    let _v671 = v673 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v674 : string = method11()
                    let _v671 = v674 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v675 : string = method12()
                    let _v671 = v675 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v676 : string = method12()
                    let _v671 = v676 
                    #endif
#else
                    let v677 : string = method12()
                    let _v671 = v677 
                    #endif
                    let v678 : string = _v671 
                    let v683 : string = method13()
                    let v684 : Mut4 = {l0 = v683} : Mut4
                    let v685 : US0 = US0_2
                    let v686 : string = $"%A{v685}"
                    let v690 : string = $"{v686}"
                    let v693 : unit = ()
                    let v694 : (unit -> unit) = closure9(v684, v690)
                    let v695 : unit = (fun () -> v694 (); v693) ()
                    let v698 : string = v684.l0
                    let v699 : (string []) = v698.Split v678 
                    let v702 : string = v699.[int 0]
                    let v705 : string = method13()
                    let v706 : Mut4 = {l0 = v705} : Mut4
                    let v707 : US0 = US0_3
                    let v708 : string = $"%A{v707}"
                    let v712 : string = $"{v708}"
                    let v715 : unit = ()
                    let v716 : (unit -> unit) = closure9(v706, v712)
                    let v717 : unit = (fun () -> v716 (); v715) ()
                    let v720 : string = v706.l0
                    let v721 : bool = v720.StartsWith v702 
                    let v727 : US1 =
                        if v721 then
                            let v724 : string = "Info"
                            US1_0(v724)
                        else
                            US1_1
                    match v727 with
                    | US1_1 -> (* None *)
                        let v730 : string = "Warning"
                        US1_0(v730)
                    | US1_0(v728) -> (* Some *)
                        US1_0(v728)
                | US1_0(v669) -> (* Some *)
                    US1_0(v669)
            | US1_0(v610) -> (* Some *)
                US1_0(v610)
        let v741 : string =
            match v737 with
            | US1_1 -> (* None *)
                failwith<string> "Option does not have a value."
            | US1_0(v738) -> (* Some *)
                v738
        let v742 : (unit -> string) = v741.ToLower
        let v743 : string = v742 ()
        let v746 : string = v743.PadLeft (7, ' ')
        let v760 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v761 : string = "inline_colorization::color_yellow"
        let v762 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v761 
        let v763 : string = "&*$0"
        let v764 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v746 v763 
        let v765 : string = "inline_colorization::color_reset"
        let v766 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v765 
        let v767 : string = "\"{v762}{v764}{v766}\""
        let v768 : string = @$"format!(" + v767 + ")"
        let v769 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v768 
        let v770 : string = "fable_library_rust::String_::fromString($0)"
        let v771 : string = Fable.Core.RustInterop.emitRustExpr v769 v770 
        let _v760 = v771 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v772 : string = "inline_colorization::color_yellow"
        let v773 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v772 
        let v774 : string = "&*$0"
        let v775 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v746 v774 
        let v776 : string = "inline_colorization::color_reset"
        let v777 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v776 
        let v778 : string = "\"{v773}{v775}{v777}\""
        let v779 : string = @$"format!(" + v778 + ")"
        let v780 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v779 
        let v781 : string = "fable_library_rust::String_::fromString($0)"
        let v782 : string = Fable.Core.RustInterop.emitRustExpr v780 v781 
        let _v760 = v782 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v783 : string = "inline_colorization::color_yellow"
        let v784 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v783 
        let v785 : string = "&*$0"
        let v786 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v746 v785 
        let v787 : string = "inline_colorization::color_reset"
        let v788 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v787 
        let v789 : string = "\"{v784}{v786}{v788}\""
        let v790 : string = @$"format!(" + v789 + ")"
        let v791 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v790 
        let v792 : string = "fable_library_rust::String_::fromString($0)"
        let v793 : string = Fable.Core.RustInterop.emitRustExpr v791 v792 
        let _v760 = v793 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v794 : string = "\u001b[93m"
        let v795 : string = method14()
        let v796 : string = v794 + v746 
        let v797 : string = v796 + v795 
        let _v760 = v797 
        #endif
#if FABLE_COMPILER_PYTHON
        let v798 : string = "\u001b[93m"
        let v799 : string = method14()
        let v800 : string = v798 + v746 
        let v801 : string = v800 + v799 
        let _v760 = v801 
        #endif
#else
        let v802 : string = "\u001b[93m"
        let v803 : string = method14()
        let v804 : string = v802 + v746 
        let v805 : string = v804 + v803 
        let _v760 = v805 
        #endif
        let v806 : string = _v760 
        let v812 : int64 = v85.l0
        let v813 : string = method13()
        let v814 : Mut4 = {l0 = v813} : Mut4
        let v815 : string = "{ "
        let v816 : string = $"{v815}"
        let v819 : unit = ()
        let v820 : (unit -> unit) = closure9(v814, v816)
        let v821 : unit = (fun () -> v820 (); v819) ()
        let v824 : string = "error"
        let v825 : string = $"{v824}"
        let v828 : unit = ()
        let v829 : (unit -> unit) = closure9(v814, v825)
        let v830 : unit = (fun () -> v829 (); v828) ()
        let v833 : string = " = "
        let v834 : string = $"{v833}"
        let v837 : unit = ()
        let v838 : (unit -> unit) = closure9(v814, v834)
        let v839 : unit = (fun () -> v838 (); v837) ()
        let v842 : string = $"{v0}"
        let v845 : unit = ()
        let v846 : (unit -> unit) = closure9(v814, v842)
        let v847 : unit = (fun () -> v846 (); v845) ()
        let v850 : string = " }"
        let v851 : string = $"{v850}"
        let v854 : unit = ()
        let v855 : (unit -> unit) = closure9(v814, v851)
        let v856 : unit = (fun () -> v855 (); v854) ()
        let v859 : string = v814.l0
        let v860 : (unit -> string) = closure63()
        let v861 : string = $"{v483} {v806} #{v812} %s{v860 ()} / {v859}"
        let v864 : char list = []
        let v865 : (char list -> (char [])) = List.toArray
        let v866 : (char []) = v865 v864
        let v869 : string = v861.TrimStart v866 
        let v887 : char list = []
        let v888 : char list = '/' :: v887 
        let v891 : char list = ' ' :: v888 
        let v894 : (char list -> (char [])) = List.toArray
        let v895 : (char []) = v894 v891
        let v898 : string = v869.TrimEnd v895 
        let v916 : (string -> unit) = closure11()
        let v917 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v918 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v898 v918 
        let _v917 = () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v919 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v898 v919 
        let _v917 = () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v920 : string = $"near_sdk::log!(\"{{}}\", $0)"
        Fable.Core.RustInterop.emitRustExpr v898 v920 
        let _v917 = () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        v916 v898
        let _v917 = () 
        #endif
#if FABLE_COMPILER_PYTHON
        v916 v898
        let _v917 = () 
        #endif
#else
        v916 v898
        let _v917 = () 
        #endif
        _v917 
        let v921 : (string -> unit) = v17.l0
        v921 v898
and method51 () : string =
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
and closure60 () () : string =
    let v0 : string = __SOURCE_DIRECTORY__
    let v1 : string = "polyglot"
    let v2 : string = ".devcontainer"
    let v3 : string = method32(v1, v2)
    let v4 : US13 = method47(v3, v0)
    let v934 : US1 =
        match v4 with
        | US13_1(v7) -> (* Error *)
            let v8 : unit = ()
            let v9 : (unit -> unit) = closure62(v7)
            let v10 : unit = (fun () -> v9 (); v8) ()
            US1_1
        | US13_0(v5) -> (* Ok *)
            US1_0(v5)
    let v1871 : US1 =
        match v934 with
        | US1_1 -> (* None *)
            let v937 : string = method51()
            let v938 : string = method32(v1, v2)
            let v939 : US13 = method47(v938, v937)
            match v939 with
            | US13_1(v942) -> (* Error *)
                let v943 : unit = ()
                let v944 : (unit -> unit) = closure62(v942)
                let v945 : unit = (fun () -> v944 (); v943) ()
                US1_1
            | US13_0(v940) -> (* Ok *)
                US1_0(v940)
        | US1_0(v935) -> (* Some *)
            US1_0(v935)
    let v1875 : string =
        match v1871 with
        | US1_1 -> (* None *)
            failwith<string> "Option does not have a value."
        | US1_0(v1872) -> (* Some *)
            v1872
    method32(v1875, v1)
and method52 (v0 : string) : unit =
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
    let v2 : string = method35()
    let v3 : System.DateTime = System.DateTime.Now
    let v6 : (unit -> System.Guid) = System.Guid.NewGuid
    let v7 : System.Guid = v6 ()
    let v10 : System.Guid = method25(v7, v3)
    let v11 : string = $"{v2}_{v10}.txt"
    let v12 : string = __SOURCE_DIRECTORY__
    let v13 : string = "polyglot"
    let v14 : string = ".devcontainer"
    let v15 : string = method32(v13, v14)
    let v16 : US13 = method47(v15, v12)
    let v946 : US1 =
        match v16 with
        | US13_1(v19) -> (* Error *)
            let v20 : unit = ()
            let v21 : (unit -> unit) = closure62(v19)
            let v22 : unit = (fun () -> v21 (); v20) ()
            US1_1
        | US13_0(v17) -> (* Ok *)
            US1_0(v17)
    let v1883 : US1 =
        match v946 with
        | US1_1 -> (* None *)
            let v949 : string = method51()
            let v950 : string = method32(v13, v14)
            let v951 : US13 = method47(v950, v949)
            match v951 with
            | US13_1(v954) -> (* Error *)
                let v955 : unit = ()
                let v956 : (unit -> unit) = closure62(v954)
                let v957 : unit = (fun () -> v956 (); v955) ()
                US1_1
            | US13_0(v952) -> (* Ok *)
                US1_0(v952)
        | US1_0(v947) -> (* Some *)
            US1_0(v947)
    let v1887 : string =
        match v1883 with
        | US1_1 -> (* None *)
            failwith<string> "Option does not have a value."
        | US1_0(v1884) -> (* Some *)
            v1884
    let v1888 : string = method32(v1887, v13)
    let v1889 : string = "target/trace"
    let v1890 : string = method32(v1888, v1889)
    let v1891 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1892 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    let _v1891 = v1892 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1895 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    let _v1891 = v1895 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1898 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    let _v1891 = v1898 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1901 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    let _v1891 = v1901 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1904 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    let _v1891 = v1904 
    #endif
#else
    let v1907 : (string -> System.IO.DirectoryInfo) = System.IO.Directory.CreateDirectory
    let v1908 : System.IO.DirectoryInfo = v1907 v1890
    let _v1891 = v1908 
    #endif
    let v1909 : System.IO.DirectoryInfo = _v1891 
    let v1914 : string = method32(v1890, v11)
    let v1915 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1916 : Async<unit> = null |> unbox<Async<unit>>
    let _v1915 = v1916 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1919 : Async<unit> = null |> unbox<Async<unit>>
    let _v1915 = v1919 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1922 : Async<unit> = null |> unbox<Async<unit>>
    let _v1915 = v1922 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1925 : Async<unit> = null |> unbox<Async<unit>>
    let _v1915 = v1925 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1928 : Async<unit> = null |> unbox<Async<unit>>
    let _v1915 = v1928 
    #endif
#else
    let v1931 : System.Threading.Tasks.Task = System.IO.File.WriteAllTextAsync (v1914, v0)
    let v1932 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1933 : Async<unit> = null |> unbox<Async<unit>>
    let _v1932 = v1933 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1936 : Async<unit> = null |> unbox<Async<unit>>
    let _v1932 = v1936 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1939 : Async<unit> = null |> unbox<Async<unit>>
    let _v1932 = v1939 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1942 : Async<unit> = null |> unbox<Async<unit>>
    let _v1932 = v1942 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1945 : Async<unit> = null |> unbox<Async<unit>>
    let _v1932 = v1945 
    #endif
#else
    let v1948 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
    let v1949 : Async<unit> = v1948 v1931
    let _v1932 = v1949 
    #endif
    let v1950 : Async<unit> = _v1932 
    let _v1915 = v1950 
    #endif
    let v1955 : Async<unit> = _v1915 
    let v1960 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    null |> unbox<unit>
    let _v1960 = () 
    #endif
#if FABLE_COMPILER_RUST && WASM
    null |> unbox<unit>
    let _v1960 = () 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    null |> unbox<unit>
    let _v1960 = () 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    null |> unbox<unit>
    let _v1960 = () 
    #endif
#if FABLE_COMPILER_PYTHON
    null |> unbox<unit>
    let _v1960 = () 
    #endif
#else
    let v1961 : (Async<unit> -> unit) = Async.RunSynchronously
    v1961 v1955
    let _v1960 = () 
    #endif
    _v1960 
    with ex ->
    let v1962 : exn = ex
    let v1963 : string = $"file_system.trace_file / ex: %A{v1962}"
    method52(v1963)
    (*
    *)
    let _v1 = () 
    #endif
    _v1 
    ()
and closure65 () (v0 : string) : unit =
    method52(v0)
and closure64 () (v0 : bool) : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure0()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v16 : Mut0, v17 : Mut1, v18 : Mut2, v19 : Mut3, v20 : int64 option) = State.trace_state.Value
    let v33 : (string -> unit) =
        if v0 then
            closure65()
        else
            closure3()
    v17.l0 <- v33
    ()
and closure67 (v0 : string) (v1 : string) : string =
    method32(v0, v1)
and closure66 () (v0 : string) : (string -> string) =
    closure67(v0)
let v0 : unit = ()
let v1 : (unit -> unit) = closure0()
let v2 : unit = (fun () -> v1 (); v0) ()
let v15 : (string -> Async<int64>) = closure4()
let delete_directory_async x = v15 x
let v16 : (US6 -> (string -> Async<int64>)) = closure13()
let wait_for_file_access x = v16 x
let v17 : (string -> Async<int64>) = closure17()
let wait_for_file_access_read x = v17 x
let v18 : (string -> Async<string>) = closure18()
let read_all_text_async x = v18 x
let v19 : (string -> (string -> bool)) = closure19()
let file_exists_content x = v19 x
let v20 : (string -> (string -> Async<unit>)) = closure21()
let write_all_text_async x = v20 x
let v21 : (string -> (string -> Async<unit>)) = closure23()
let write_all_text_exists x = v21 x
let v22 : (string -> Async<int64>) = closure25()
let delete_file_async x = v22 x
let v23 : (string -> (string -> Async<int64>)) = closure28()
let move_file_async x = v23 x
let v24 : (string -> Async<string option>) = closure32()
let read_all_text_retry_async x = v24 x
let v25 : (unit -> string) = closure41()
let create_temp_path () = v25 ()
let v26 : (unit -> struct (string * System.IDisposable)) = closure44()
let create_temp_dir () = v26 ()
let v27 : (string -> struct (string * System.IDisposable)) = closure56()
let create_temp_dir' x = v27 x
let v28 : (unit -> string) = closure57()
let get_source_directory () = v28 ()
let v29 : (string -> string) = closure58()
let normalize_path x = v29 x
let v30 : (string -> string) = closure59()
let new_file_uri x = v30 x
let v31 : (unit -> string) = closure60()
let get_workspace_root () = v31 ()
let v32 : (bool -> unit) = closure64()
let init_trace_file x = v32 x
let v33 : (string -> (string -> string)) = closure66()
let (</>) x = v33 x
()
