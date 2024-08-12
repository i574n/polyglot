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
and closure9 (v0 : Mut4, v1 : string) () : unit =
    let v2 : string = v0.l0
    let v3 : string = v2 + v1 
    v0.l0 <- v3
    ()
and closure10 () () : string =
    let v0 : string = "file_system.delete_directory_async"
    v0
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
        let v554 : string = "Debug"
        let v555 : (unit -> string) = v554.ToLower
        let v556 : string = v555 ()
        let v559 : string = v556.PadLeft (7, ' ')
        let v573 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v574 : string = "inline_colorization::color_bright_blue"
        let v575 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v574 
        let v576 : string = "&*$0"
        let v577 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v559 v576 
        let v578 : string = "inline_colorization::color_reset"
        let v579 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v578 
        let v580 : string = "\"{v575}{v577}{v579}\""
        let v581 : string = @$"format!(" + v580 + ")"
        let v582 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v581 
        let v583 : string = "fable_library_rust::String_::fromString($0)"
        let v584 : string = Fable.Core.RustInterop.emitRustExpr v582 v583 
        let _v573 = v584 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v585 : string = "inline_colorization::color_bright_blue"
        let v586 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v585 
        let v587 : string = "&*$0"
        let v588 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v559 v587 
        let v589 : string = "inline_colorization::color_reset"
        let v590 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v589 
        let v591 : string = "\"{v586}{v588}{v590}\""
        let v592 : string = @$"format!(" + v591 + ")"
        let v593 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v592 
        let v594 : string = "fable_library_rust::String_::fromString($0)"
        let v595 : string = Fable.Core.RustInterop.emitRustExpr v593 v594 
        let _v573 = v595 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v596 : string = "inline_colorization::color_bright_blue"
        let v597 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v596 
        let v598 : string = "&*$0"
        let v599 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v559 v598 
        let v600 : string = "inline_colorization::color_reset"
        let v601 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v600 
        let v602 : string = "\"{v597}{v599}{v601}\""
        let v603 : string = @$"format!(" + v602 + ")"
        let v604 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v603 
        let v605 : string = "fable_library_rust::String_::fromString($0)"
        let v606 : string = Fable.Core.RustInterop.emitRustExpr v604 v605 
        let _v573 = v606 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v607 : string = "\u001b[94m"
        let v608 : string = method11()
        let v609 : string = v607 + v559 
        let v610 : string = v609 + v608 
        let _v573 = v610 
        #endif
#if FABLE_COMPILER_PYTHON
        let v611 : string = "\u001b[94m"
        let v612 : string = method11()
        let v613 : string = v611 + v559 
        let v614 : string = v613 + v612 
        let _v573 = v614 
        #endif
#else
        let v615 : string = "\u001b[94m"
        let v616 : string = method11()
        let v617 : string = v615 + v559 
        let v618 : string = v617 + v616 
        let _v573 = v618 
        #endif
        let v619 : string = _v573 
        let v625 : int64 = v86.l0
        let v626 : string = method12(v0)
        let v627 : string = method13()
        let v628 : Mut4 = {l0 = v627} : Mut4
        let v629 : string = "{ "
        let v630 : string = $"{v629}"
        let v633 : unit = ()
        let v634 : (unit -> unit) = closure9(v628, v630)
        let v635 : unit = (fun () -> v634 (); v633) ()
        let v638 : string = "ex"
        let v639 : string = $"{v638}"
        let v642 : unit = ()
        let v643 : (unit -> unit) = closure9(v628, v639)
        let v644 : unit = (fun () -> v643 (); v642) ()
        let v647 : string = " = "
        let v648 : string = $"{v647}"
        let v651 : unit = ()
        let v652 : (unit -> unit) = closure9(v628, v648)
        let v653 : unit = (fun () -> v652 (); v651) ()
        let v656 : string = $"{v1}"
        let v659 : unit = ()
        let v660 : (unit -> unit) = closure9(v628, v656)
        let v661 : unit = (fun () -> v660 (); v659) ()
        let v664 : string = "; "
        let v665 : string = $"{v664}"
        let v668 : unit = ()
        let v669 : (unit -> unit) = closure9(v628, v665)
        let v670 : unit = (fun () -> v669 (); v668) ()
        let v673 : string = "path"
        let v674 : string = $"{v673}"
        let v677 : unit = ()
        let v678 : (unit -> unit) = closure9(v628, v674)
        let v679 : unit = (fun () -> v678 (); v677) ()
        let v682 : string = $"{v647}"
        let v685 : unit = ()
        let v686 : (unit -> unit) = closure9(v628, v682)
        let v687 : unit = (fun () -> v686 (); v685) ()
        let v690 : string = $"{v626}"
        let v693 : unit = ()
        let v694 : (unit -> unit) = closure9(v628, v690)
        let v695 : unit = (fun () -> v694 (); v693) ()
        let v698 : string = " }"
        let v699 : string = $"{v698}"
        let v702 : unit = ()
        let v703 : (unit -> unit) = closure9(v628, v699)
        let v704 : unit = (fun () -> v703 (); v702) ()
        let v707 : string = v628.l0
        let v708 : (unit -> string) = closure10()
        let v709 : string = $"{v484} {v619} #{v625} %s{v708 ()} / {v707}"
        let v712 : char list = []
        let v713 : (char list -> (char [])) = List.toArray
        let v714 : (char []) = v713 v712
        let v717 : string = v709.TrimStart v714 
        let v735 : char list = []
        let v736 : char list = '/' :: v735 
        let v739 : char list = ' ' :: v736 
        let v742 : (char list -> (char [])) = List.toArray
        let v743 : (char []) = v742 v739
        let v746 : string = v717.TrimEnd v743 
        let v764 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v765 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v746 v765 
        let _v764 = () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v766 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v746 v766 
        let _v764 = () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v767 : string = $"near_sdk::log!(\"{{}}\", $0)"
        Fable.Core.RustInterop.emitRustExpr v746 v767 
        let _v764 = () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        System.Console.WriteLine v746 
        let _v764 = () 
        #endif
#if FABLE_COMPILER_PYTHON
        System.Console.WriteLine v746 
        let _v764 = () 
        #endif
#else
        System.Console.WriteLine v746 
        let _v764 = () 
        #endif
        _v764 
        let v768 : (string -> unit) = v18.l0
        v768 v746
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
    let v815 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v816 : Async<unit> = null |> unbox<Async<unit>>
    let _v815 = v816 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v819 : Async<unit> = null |> unbox<Async<unit>>
    let _v815 = v819 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v822 : Async<unit> = null |> unbox<Async<unit>>
    let _v815 = v822 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v825 : Async<unit> = null |> unbox<Async<unit>>
    let _v815 = v825 
    #endif
#if FABLE_COMPILER_PYTHON
    let v828 : Async<unit> = null |> unbox<Async<unit>>
    let _v815 = v828 
    #endif
#else
    let v831 : (int32 -> Async<unit>) = Async.Sleep
    let v832 : Async<unit> = v831 10
    let _v815 = v832 
    #endif
    let v833 : Async<unit> = _v815 
    do! v833 
    let v838 : int64 = v1 + 1L
    let v839 : Async<int64> = method5(v0, v838)
    return! v839 
    (*
    let v840 : int64 = *)
    }
    |> fun x -> _v18 <- Some x
    let v841 : Async<int64> = match _v18 with Some x -> x | None -> failwith "async.new_async_unit / _v18=None"
    let _v2 = v841 
    #endif
    let v842 : Async<int64> = _v2 
    v842
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
and closure14 () () : string =
    let v0 : string = "file_system.wait_for_file_access"
    v0
and closure13 (v0 : string, v1 : int64, v2 : string) () : unit =
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
        let v555 : string = "Debug"
        let v556 : (unit -> string) = v555.ToLower
        let v557 : string = v556 ()
        let v560 : string = v557.PadLeft (7, ' ')
        let v574 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v575 : string = "inline_colorization::color_bright_blue"
        let v576 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v575 
        let v577 : string = "&*$0"
        let v578 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v560 v577 
        let v579 : string = "inline_colorization::color_reset"
        let v580 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v579 
        let v581 : string = "\"{v576}{v578}{v580}\""
        let v582 : string = @$"format!(" + v581 + ")"
        let v583 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v582 
        let v584 : string = "fable_library_rust::String_::fromString($0)"
        let v585 : string = Fable.Core.RustInterop.emitRustExpr v583 v584 
        let _v574 = v585 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v586 : string = "inline_colorization::color_bright_blue"
        let v587 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v586 
        let v588 : string = "&*$0"
        let v589 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v560 v588 
        let v590 : string = "inline_colorization::color_reset"
        let v591 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v590 
        let v592 : string = "\"{v587}{v589}{v591}\""
        let v593 : string = @$"format!(" + v592 + ")"
        let v594 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v593 
        let v595 : string = "fable_library_rust::String_::fromString($0)"
        let v596 : string = Fable.Core.RustInterop.emitRustExpr v594 v595 
        let _v574 = v596 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v597 : string = "inline_colorization::color_bright_blue"
        let v598 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v597 
        let v599 : string = "&*$0"
        let v600 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v560 v599 
        let v601 : string = "inline_colorization::color_reset"
        let v602 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v601 
        let v603 : string = "\"{v598}{v600}{v602}\""
        let v604 : string = @$"format!(" + v603 + ")"
        let v605 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v604 
        let v606 : string = "fable_library_rust::String_::fromString($0)"
        let v607 : string = Fable.Core.RustInterop.emitRustExpr v605 v606 
        let _v574 = v607 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v608 : string = "\u001b[94m"
        let v609 : string = method11()
        let v610 : string = v608 + v560 
        let v611 : string = v610 + v609 
        let _v574 = v611 
        #endif
#if FABLE_COMPILER_PYTHON
        let v612 : string = "\u001b[94m"
        let v613 : string = method11()
        let v614 : string = v612 + v560 
        let v615 : string = v614 + v613 
        let _v574 = v615 
        #endif
#else
        let v616 : string = "\u001b[94m"
        let v617 : string = method11()
        let v618 : string = v616 + v560 
        let v619 : string = v618 + v617 
        let _v574 = v619 
        #endif
        let v620 : string = _v574 
        let v626 : int64 = v87.l0
        let v627 : string = method12(v0)
        let v628 : string = method13()
        let v629 : Mut4 = {l0 = v628} : Mut4
        let v630 : string = "{ "
        let v631 : string = $"{v630}"
        let v634 : unit = ()
        let v635 : (unit -> unit) = closure9(v629, v631)
        let v636 : unit = (fun () -> v635 (); v634) ()
        let v639 : string = "path"
        let v640 : string = $"{v639}"
        let v643 : unit = ()
        let v644 : (unit -> unit) = closure9(v629, v640)
        let v645 : unit = (fun () -> v644 (); v643) ()
        let v648 : string = " = "
        let v649 : string = $"{v648}"
        let v652 : unit = ()
        let v653 : (unit -> unit) = closure9(v629, v649)
        let v654 : unit = (fun () -> v653 (); v652) ()
        let v657 : string = $"{v627}"
        let v660 : unit = ()
        let v661 : (unit -> unit) = closure9(v629, v657)
        let v662 : unit = (fun () -> v661 (); v660) ()
        let v665 : string = "; "
        let v666 : string = $"{v665}"
        let v669 : unit = ()
        let v670 : (unit -> unit) = closure9(v629, v666)
        let v671 : unit = (fun () -> v670 (); v669) ()
        let v674 : string = "retry"
        let v675 : string = $"{v674}"
        let v678 : unit = ()
        let v679 : (unit -> unit) = closure9(v629, v675)
        let v680 : unit = (fun () -> v679 (); v678) ()
        let v683 : string = $"{v648}"
        let v686 : unit = ()
        let v687 : (unit -> unit) = closure9(v629, v683)
        let v688 : unit = (fun () -> v687 (); v686) ()
        let v691 : string = $"{v1}"
        let v694 : unit = ()
        let v695 : (unit -> unit) = closure9(v629, v691)
        let v696 : unit = (fun () -> v695 (); v694) ()
        let v699 : string = $"{v665}"
        let v702 : unit = ()
        let v703 : (unit -> unit) = closure9(v629, v699)
        let v704 : unit = (fun () -> v703 (); v702) ()
        let v707 : string = "ex"
        let v708 : string = $"{v707}"
        let v711 : unit = ()
        let v712 : (unit -> unit) = closure9(v629, v708)
        let v713 : unit = (fun () -> v712 (); v711) ()
        let v716 : string = $"{v648}"
        let v719 : unit = ()
        let v720 : (unit -> unit) = closure9(v629, v716)
        let v721 : unit = (fun () -> v720 (); v719) ()
        let v724 : string = $"{v2}"
        let v727 : unit = ()
        let v728 : (unit -> unit) = closure9(v629, v724)
        let v729 : unit = (fun () -> v728 (); v727) ()
        let v732 : string = " }"
        let v733 : string = $"{v732}"
        let v736 : unit = ()
        let v737 : (unit -> unit) = closure9(v629, v733)
        let v738 : unit = (fun () -> v737 (); v736) ()
        let v741 : string = v629.l0
        let v742 : (unit -> string) = closure14()
        let v743 : string = $"{v485} {v620} #{v626} %s{v742 ()} / {v741}"
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
        let v798 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v799 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v780 v799 
        let _v798 = () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v800 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v780 v800 
        let _v798 = () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v801 : string = $"near_sdk::log!(\"{{}}\", $0)"
        Fable.Core.RustInterop.emitRustExpr v780 v801 
        let _v798 = () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        System.Console.WriteLine v780 
        let _v798 = () 
        #endif
#if FABLE_COMPILER_PYTHON
        System.Console.WriteLine v780 
        let _v798 = () 
        #endif
#else
        System.Console.WriteLine v780 
        let _v798 = () 
        #endif
        _v798 
        let v802 : (string -> unit) = v19.l0
        v802 v780
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
        let v89 : (unit -> unit) = closure13(v0, v3, v83)
        let v90 : unit = (fun () -> v89 (); v88) ()
        ()
    let v891 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v892 : Async<unit> = null |> unbox<Async<unit>>
    let _v891 = v892 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v895 : Async<unit> = null |> unbox<Async<unit>>
    let _v891 = v895 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v898 : Async<unit> = null |> unbox<Async<unit>>
    let _v891 = v898 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v901 : Async<unit> = null |> unbox<Async<unit>>
    let _v891 = v901 
    #endif
#if FABLE_COMPILER_PYTHON
    let v904 : Async<unit> = null |> unbox<Async<unit>>
    let _v891 = v904 
    #endif
#else
    let v907 : (int32 -> Async<unit>) = Async.Sleep
    let v908 : Async<unit> = v907 10
    let _v891 = v908 
    #endif
    let v909 : Async<unit> = _v891 
    do! v909 
    let v914 : int64 = v3 + 1L
    let v915 : Async<int64> = method14(v0, v1, v2, v914)
    return! v915 
    (*
    let v916 : int64 = *)
    }
    |> fun x -> _v20 <- Some x
    let v917 : Async<int64> = match _v20 with Some x -> x | None -> failwith "async.new_async_unit / _v20=None"
    let _v4 = v917 
    #endif
    let v918 : Async<int64> = _v4 
    v918
and closure12 (v0 : US6) (v1 : string) : Async<int64> =
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
and closure11 () (v0 : US6) : (string -> Async<int64>) =
    closure12(v0)
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
        let v73 : (unit -> unit) = closure13(v0, v1, v67)
        let v74 : unit = (fun () -> v73 (); v72) ()
        ()
    let v875 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v876 : Async<unit> = null |> unbox<Async<unit>>
    let _v875 = v876 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v879 : Async<unit> = null |> unbox<Async<unit>>
    let _v875 = v879 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v882 : Async<unit> = null |> unbox<Async<unit>>
    let _v875 = v882 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v885 : Async<unit> = null |> unbox<Async<unit>>
    let _v875 = v885 
    #endif
#if FABLE_COMPILER_PYTHON
    let v888 : Async<unit> = null |> unbox<Async<unit>>
    let _v875 = v888 
    #endif
#else
    let v891 : (int32 -> Async<unit>) = Async.Sleep
    let v892 : Async<unit> = v891 10
    let _v875 = v892 
    #endif
    let v893 : Async<unit> = _v875 
    do! v893 
    let v898 : int64 = v1 + 1L
    let v899 : Async<int64> = method15(v0, v898)
    return! v899 
    (*
    let v900 : int64 = *)
    }
    |> fun x -> _v18 <- Some x
    let v901 : Async<int64> = match _v18 with Some x -> x | None -> failwith "async.new_async_unit / _v18=None"
    let _v2 = v901 
    #endif
    let v902 : Async<int64> = _v2 
    v902
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
and closure25 () () : string =
    let v0 : string = "delete_file_async"
    v0
and closure24 (v0 : string, v1 : exn) () : unit =
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
        let v554 : string = "Warning"
        let v555 : (unit -> string) = v554.ToLower
        let v556 : string = v555 ()
        let v559 : string = v556.PadLeft (7, ' ')
        let v573 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v574 : string = "inline_colorization::color_yellow"
        let v575 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v574 
        let v576 : string = "&*$0"
        let v577 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v559 v576 
        let v578 : string = "inline_colorization::color_reset"
        let v579 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v578 
        let v580 : string = "\"{v575}{v577}{v579}\""
        let v581 : string = @$"format!(" + v580 + ")"
        let v582 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v581 
        let v583 : string = "fable_library_rust::String_::fromString($0)"
        let v584 : string = Fable.Core.RustInterop.emitRustExpr v582 v583 
        let _v573 = v584 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v585 : string = "inline_colorization::color_yellow"
        let v586 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v585 
        let v587 : string = "&*$0"
        let v588 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v559 v587 
        let v589 : string = "inline_colorization::color_reset"
        let v590 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v589 
        let v591 : string = "\"{v586}{v588}{v590}\""
        let v592 : string = @$"format!(" + v591 + ")"
        let v593 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v592 
        let v594 : string = "fable_library_rust::String_::fromString($0)"
        let v595 : string = Fable.Core.RustInterop.emitRustExpr v593 v594 
        let _v573 = v595 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v596 : string = "inline_colorization::color_yellow"
        let v597 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v596 
        let v598 : string = "&*$0"
        let v599 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v559 v598 
        let v600 : string = "inline_colorization::color_reset"
        let v601 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v600 
        let v602 : string = "\"{v597}{v599}{v601}\""
        let v603 : string = @$"format!(" + v602 + ")"
        let v604 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v603 
        let v605 : string = "fable_library_rust::String_::fromString($0)"
        let v606 : string = Fable.Core.RustInterop.emitRustExpr v604 v605 
        let _v573 = v606 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v607 : string = "\u001b[93m"
        let v608 : string = method11()
        let v609 : string = v607 + v559 
        let v610 : string = v609 + v608 
        let _v573 = v610 
        #endif
#if FABLE_COMPILER_PYTHON
        let v611 : string = "\u001b[93m"
        let v612 : string = method11()
        let v613 : string = v611 + v559 
        let v614 : string = v613 + v612 
        let _v573 = v614 
        #endif
#else
        let v615 : string = "\u001b[93m"
        let v616 : string = method11()
        let v617 : string = v615 + v559 
        let v618 : string = v617 + v616 
        let _v573 = v618 
        #endif
        let v619 : string = _v573 
        let v625 : int64 = v86.l0
        let v626 : string = method12(v0)
        let v627 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v628 : string = $"%A{v1}"
        let _v627 = v628 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v631 : string = $"%A{v1}"
        let _v627 = v631 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v634 : string = $"%A{v1}"
        let _v627 = v634 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v637 : string = $"%A{v1}"
        let _v627 = v637 
        #endif
#if FABLE_COMPILER_PYTHON
        let v640 : string = $"%A{v1}"
        let _v627 = v640 
        #endif
#else
        let v643 : string = $"{v1.GetType ()}: {v1.Message}"
        let _v627 = v643 
        #endif
        let v644 : string = _v627 
        let v649 : string = method13()
        let v650 : Mut4 = {l0 = v649} : Mut4
        let v651 : string = "{ "
        let v652 : string = $"{v651}"
        let v655 : unit = ()
        let v656 : (unit -> unit) = closure9(v650, v652)
        let v657 : unit = (fun () -> v656 (); v655) ()
        let v660 : string = "path"
        let v661 : string = $"{v660}"
        let v664 : unit = ()
        let v665 : (unit -> unit) = closure9(v650, v661)
        let v666 : unit = (fun () -> v665 (); v664) ()
        let v669 : string = " = "
        let v670 : string = $"{v669}"
        let v673 : unit = ()
        let v674 : (unit -> unit) = closure9(v650, v670)
        let v675 : unit = (fun () -> v674 (); v673) ()
        let v678 : string = $"{v626}"
        let v681 : unit = ()
        let v682 : (unit -> unit) = closure9(v650, v678)
        let v683 : unit = (fun () -> v682 (); v681) ()
        let v686 : string = "; "
        let v687 : string = $"{v686}"
        let v690 : unit = ()
        let v691 : (unit -> unit) = closure9(v650, v687)
        let v692 : unit = (fun () -> v691 (); v690) ()
        let v695 : string = "ex"
        let v696 : string = $"{v695}"
        let v699 : unit = ()
        let v700 : (unit -> unit) = closure9(v650, v696)
        let v701 : unit = (fun () -> v700 (); v699) ()
        let v704 : string = $"{v669}"
        let v707 : unit = ()
        let v708 : (unit -> unit) = closure9(v650, v704)
        let v709 : unit = (fun () -> v708 (); v707) ()
        let v712 : string = $"{v644}"
        let v715 : unit = ()
        let v716 : (unit -> unit) = closure9(v650, v712)
        let v717 : unit = (fun () -> v716 (); v715) ()
        let v720 : string = " }"
        let v721 : string = $"{v720}"
        let v724 : unit = ()
        let v725 : (unit -> unit) = closure9(v650, v721)
        let v726 : unit = (fun () -> v725 (); v724) ()
        let v729 : string = v650.l0
        let v730 : (unit -> string) = closure25()
        let v731 : string = $"{v484} {v619} #{v625} %s{v730 ()} / {v729}"
        let v734 : char list = []
        let v735 : (char list -> (char [])) = List.toArray
        let v736 : (char []) = v735 v734
        let v739 : string = v731.TrimStart v736 
        let v757 : char list = []
        let v758 : char list = '/' :: v757 
        let v761 : char list = ' ' :: v758 
        let v764 : (char list -> (char [])) = List.toArray
        let v765 : (char []) = v764 v761
        let v768 : string = v739.TrimEnd v765 
        let v786 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v787 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v768 v787 
        let _v786 = () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v788 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v768 v788 
        let _v786 = () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v789 : string = $"near_sdk::log!(\"{{}}\", $0)"
        Fable.Core.RustInterop.emitRustExpr v768 v789 
        let _v786 = () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        System.Console.WriteLine v768 
        let _v786 = () 
        #endif
#if FABLE_COMPILER_PYTHON
        System.Console.WriteLine v768 
        let _v786 = () 
        #endif
#else
        System.Console.WriteLine v768 
        let _v786 = () 
        #endif
        _v786 
        let v790 : (string -> unit) = v18.l0
        v790 v768
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
    let v817 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v818 : Async<unit> = null |> unbox<Async<unit>>
    let _v817 = v818 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v821 : Async<unit> = null |> unbox<Async<unit>>
    let _v817 = v821 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v824 : Async<unit> = null |> unbox<Async<unit>>
    let _v817 = v824 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v827 : Async<unit> = null |> unbox<Async<unit>>
    let _v817 = v827 
    #endif
#if FABLE_COMPILER_PYTHON
    let v830 : Async<unit> = null |> unbox<Async<unit>>
    let _v817 = v830 
    #endif
#else
    let v833 : (int32 -> Async<unit>) = Async.Sleep
    let v834 : Async<unit> = v833 10
    let _v817 = v834 
    #endif
    let v835 : Async<unit> = _v817 
    do! v835 
    let v840 : int64 = v1 + 1L
    let v841 : Async<int64> = method19(v0, v840)
    return! v841 
    (*
    let v842 : int64 = *)
    }
    |> fun x -> _v18 <- Some x
    let v843 : Async<int64> = match _v18 with Some x -> x | None -> failwith "async.new_async_unit / _v18=None"
    let _v2 = v843 
    #endif
    let v844 : Async<int64> = _v2 
    v844
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
and closure29 () () : string =
    let v0 : string = "move_file_async"
    v0
and closure28 (v0 : string, v1 : string, v2 : exn) () : unit =
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
        let v555 : string = "Warning"
        let v556 : (unit -> string) = v555.ToLower
        let v557 : string = v556 ()
        let v560 : string = v557.PadLeft (7, ' ')
        let v574 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v575 : string = "inline_colorization::color_yellow"
        let v576 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v575 
        let v577 : string = "&*$0"
        let v578 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v560 v577 
        let v579 : string = "inline_colorization::color_reset"
        let v580 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v579 
        let v581 : string = "\"{v576}{v578}{v580}\""
        let v582 : string = @$"format!(" + v581 + ")"
        let v583 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v582 
        let v584 : string = "fable_library_rust::String_::fromString($0)"
        let v585 : string = Fable.Core.RustInterop.emitRustExpr v583 v584 
        let _v574 = v585 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v586 : string = "inline_colorization::color_yellow"
        let v587 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v586 
        let v588 : string = "&*$0"
        let v589 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v560 v588 
        let v590 : string = "inline_colorization::color_reset"
        let v591 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v590 
        let v592 : string = "\"{v587}{v589}{v591}\""
        let v593 : string = @$"format!(" + v592 + ")"
        let v594 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v593 
        let v595 : string = "fable_library_rust::String_::fromString($0)"
        let v596 : string = Fable.Core.RustInterop.emitRustExpr v594 v595 
        let _v574 = v596 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v597 : string = "inline_colorization::color_yellow"
        let v598 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v597 
        let v599 : string = "&*$0"
        let v600 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v560 v599 
        let v601 : string = "inline_colorization::color_reset"
        let v602 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v601 
        let v603 : string = "\"{v598}{v600}{v602}\""
        let v604 : string = @$"format!(" + v603 + ")"
        let v605 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v604 
        let v606 : string = "fable_library_rust::String_::fromString($0)"
        let v607 : string = Fable.Core.RustInterop.emitRustExpr v605 v606 
        let _v574 = v607 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v608 : string = "\u001b[93m"
        let v609 : string = method11()
        let v610 : string = v608 + v560 
        let v611 : string = v610 + v609 
        let _v574 = v611 
        #endif
#if FABLE_COMPILER_PYTHON
        let v612 : string = "\u001b[93m"
        let v613 : string = method11()
        let v614 : string = v612 + v560 
        let v615 : string = v614 + v613 
        let _v574 = v615 
        #endif
#else
        let v616 : string = "\u001b[93m"
        let v617 : string = method11()
        let v618 : string = v616 + v560 
        let v619 : string = v618 + v617 
        let _v574 = v619 
        #endif
        let v620 : string = _v574 
        let v626 : int64 = v87.l0
        let v627 : string = method12(v1)
        let v628 : string = method12(v0)
        let v629 : string = method13()
        let v630 : Mut4 = {l0 = v629} : Mut4
        let v631 : string = "{ "
        let v632 : string = $"{v631}"
        let v635 : unit = ()
        let v636 : (unit -> unit) = closure9(v630, v632)
        let v637 : unit = (fun () -> v636 (); v635) ()
        let v640 : string = "old_path"
        let v641 : string = $"{v640}"
        let v644 : unit = ()
        let v645 : (unit -> unit) = closure9(v630, v641)
        let v646 : unit = (fun () -> v645 (); v644) ()
        let v649 : string = " = "
        let v650 : string = $"{v649}"
        let v653 : unit = ()
        let v654 : (unit -> unit) = closure9(v630, v650)
        let v655 : unit = (fun () -> v654 (); v653) ()
        let v658 : string = $"{v627}"
        let v661 : unit = ()
        let v662 : (unit -> unit) = closure9(v630, v658)
        let v663 : unit = (fun () -> v662 (); v661) ()
        let v666 : string = "; "
        let v667 : string = $"{v666}"
        let v670 : unit = ()
        let v671 : (unit -> unit) = closure9(v630, v667)
        let v672 : unit = (fun () -> v671 (); v670) ()
        let v675 : string = "new_path"
        let v676 : string = $"{v675}"
        let v679 : unit = ()
        let v680 : (unit -> unit) = closure9(v630, v676)
        let v681 : unit = (fun () -> v680 (); v679) ()
        let v684 : string = $"{v649}"
        let v687 : unit = ()
        let v688 : (unit -> unit) = closure9(v630, v684)
        let v689 : unit = (fun () -> v688 (); v687) ()
        let v692 : string = $"{v628}"
        let v695 : unit = ()
        let v696 : (unit -> unit) = closure9(v630, v692)
        let v697 : unit = (fun () -> v696 (); v695) ()
        let v700 : string = $"{v666}"
        let v703 : unit = ()
        let v704 : (unit -> unit) = closure9(v630, v700)
        let v705 : unit = (fun () -> v704 (); v703) ()
        let v708 : string = "ex"
        let v709 : string = $"{v708}"
        let v712 : unit = ()
        let v713 : (unit -> unit) = closure9(v630, v709)
        let v714 : unit = (fun () -> v713 (); v712) ()
        let v717 : string = $"{v649}"
        let v720 : unit = ()
        let v721 : (unit -> unit) = closure9(v630, v717)
        let v722 : unit = (fun () -> v721 (); v720) ()
        let v725 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v726 : string = "format!(\"{:#?}\", $0)"
        let v727 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v726 
        let v728 : string = "fable_library_rust::String_::fromString($0)"
        let v729 : string = Fable.Core.RustInterop.emitRustExpr v727 v728 
        let _v725 = v729 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v730 : string = "format!(\"{:#?}\", $0)"
        let v731 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v730 
        let v732 : string = "fable_library_rust::String_::fromString($0)"
        let v733 : string = Fable.Core.RustInterop.emitRustExpr v731 v732 
        let _v725 = v733 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v734 : string = "format!(\"{:#?}\", $0)"
        let v735 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v734 
        let v736 : string = "fable_library_rust::String_::fromString($0)"
        let v737 : string = Fable.Core.RustInterop.emitRustExpr v735 v736 
        let _v725 = v737 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v738 : string = $"%A{v2}"
        let _v725 = v738 
        #endif
#if FABLE_COMPILER_PYTHON
        let v741 : string = $"%A{v2}"
        let _v725 = v741 
        #endif
#else
        let v744 : string = $"%A{v2}"
        let _v725 = v744 
        #endif
        let v747 : string = _v725 
        let v752 : string = $"{v747}"
        let v755 : unit = ()
        let v756 : (unit -> unit) = closure9(v630, v752)
        let v757 : unit = (fun () -> v756 (); v755) ()
        let v760 : string = " }"
        let v761 : string = $"{v760}"
        let v764 : unit = ()
        let v765 : (unit -> unit) = closure9(v630, v761)
        let v766 : unit = (fun () -> v765 (); v764) ()
        let v769 : string = v630.l0
        let v770 : (unit -> string) = closure29()
        let v771 : string = $"{v485} {v620} #{v626} %s{v770 ()} / {v769}"
        let v774 : char list = []
        let v775 : (char list -> (char [])) = List.toArray
        let v776 : (char []) = v775 v774
        let v779 : string = v771.TrimStart v776 
        let v797 : char list = []
        let v798 : char list = '/' :: v797 
        let v801 : char list = ' ' :: v798 
        let v804 : (char list -> (char [])) = List.toArray
        let v805 : (char []) = v804 v801
        let v808 : string = v779.TrimEnd v805 
        let v826 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v827 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v808 v827 
        let _v826 = () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v828 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v808 v828 
        let _v826 = () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v829 : string = $"near_sdk::log!(\"{{}}\", $0)"
        Fable.Core.RustInterop.emitRustExpr v808 v829 
        let _v826 = () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        System.Console.WriteLine v808 
        let _v826 = () 
        #endif
#if FABLE_COMPILER_PYTHON
        System.Console.WriteLine v808 
        let _v826 = () 
        #endif
#else
        System.Console.WriteLine v808 
        let _v826 = () 
        #endif
        _v826 
        let v830 : (string -> unit) = v19.l0
        v830 v808
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
        let v25 : (unit -> unit) = closure28(v0, v1, v21)
        let v26 : unit = (fun () -> v25 (); v24) ()
        ()
    let v855 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v856 : Async<unit> = null |> unbox<Async<unit>>
    let _v855 = v856 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v859 : Async<unit> = null |> unbox<Async<unit>>
    let _v855 = v859 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v862 : Async<unit> = null |> unbox<Async<unit>>
    let _v855 = v862 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v865 : Async<unit> = null |> unbox<Async<unit>>
    let _v855 = v865 
    #endif
#if FABLE_COMPILER_PYTHON
    let v868 : Async<unit> = null |> unbox<Async<unit>>
    let _v855 = v868 
    #endif
#else
    let v871 : (int32 -> Async<unit>) = Async.Sleep
    let v872 : Async<unit> = v871 10
    let _v855 = v872 
    #endif
    let v873 : Async<unit> = _v855 
    do! v873 
    let v878 : int64 = v2 + 1L
    let v879 : Async<int64> = method20(v0, v1, v878)
    return! v879 
    (*
    *)
    }
    |> fun x -> _v19 <- Some x
    let v880 : Async<int64> = match _v19 with Some x -> x | None -> failwith "async.new_async_unit / _v19=None"
    let _v3 = v880 
    #endif
    let v881 : Async<int64> = _v3 
    v881
and closure27 (v0 : string) (v1 : string) : Async<int64> =
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
and closure26 () (v0 : string) : (string -> Async<int64>) =
    closure27(v0)
and closure31 () (v0 : int64) : US9 =
    US9_0(v0)
and closure32 () (v0 : exn) : US9 =
    US9_1(v0)
and closure34 () () : string =
    let v0 : string = "async.run_with_timeout_async"
    v0
and closure33 () () : unit =
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
        let v606 : string = method11()
        let v607 : string = v605 + v557 
        let v608 : string = v607 + v606 
        let _v571 = v608 
        #endif
#if FABLE_COMPILER_PYTHON
        let v609 : string = "\u001b[90m"
        let v610 : string = method11()
        let v611 : string = v609 + v557 
        let v612 : string = v611 + v610 
        let _v571 = v612 
        #endif
#else
        let v613 : string = "\u001b[90m"
        let v614 : string = method11()
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
        let v671 : (unit -> string) = closure34()
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
        let v727 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v728 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v709 v728 
        let _v727 = () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v729 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v709 v729 
        let _v727 = () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v730 : string = $"near_sdk::log!(\"{{}}\", $0)"
        Fable.Core.RustInterop.emitRustExpr v709 v730 
        let _v727 = () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        System.Console.WriteLine v709 
        let _v727 = () 
        #endif
#if FABLE_COMPILER_PYTHON
        System.Console.WriteLine v709 
        let _v727 = () 
        #endif
#else
        System.Console.WriteLine v709 
        let _v727 = () 
        #endif
        _v727 
        let v731 : (string -> unit) = v16.l0
        v731 v709
and closure36 () () : string =
    let v0 : string = $"async.run_with_timeout_async**"
    v0
and closure35 (v0 : exn) () : unit =
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
        let v553 : string = "Critical"
        let v554 : (unit -> string) = v553.ToLower
        let v555 : string = v554 ()
        let v558 : string = v555.PadLeft (7, ' ')
        let v572 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v573 : string = "inline_colorization::color_bright_red"
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
        let v584 : string = "inline_colorization::color_bright_red"
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
        let v595 : string = "inline_colorization::color_bright_red"
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
        let v606 : string = "\u001b[91m"
        let v607 : string = method11()
        let v608 : string = v606 + v558 
        let v609 : string = v608 + v607 
        let _v572 = v609 
        #endif
#if FABLE_COMPILER_PYTHON
        let v610 : string = "\u001b[91m"
        let v611 : string = method11()
        let v612 : string = v610 + v558 
        let v613 : string = v612 + v611 
        let _v572 = v613 
        #endif
#else
        let v614 : string = "\u001b[91m"
        let v615 : string = method11()
        let v616 : string = v614 + v558 
        let v617 : string = v616 + v615 
        let _v572 = v617 
        #endif
        let v618 : string = _v572 
        let v624 : int64 = v85.l0
        let v625 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v626 : string = $"%A{v0}"
        let _v625 = v626 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v629 : string = $"%A{v0}"
        let _v625 = v629 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v632 : string = $"%A{v0}"
        let _v625 = v632 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v635 : string = $"%A{v0}"
        let _v625 = v635 
        #endif
#if FABLE_COMPILER_PYTHON
        let v638 : string = $"%A{v0}"
        let _v625 = v638 
        #endif
#else
        let v641 : string = $"{v0.GetType ()}: {v0.Message}"
        let _v625 = v641 
        #endif
        let v642 : string = _v625 
        let v647 : string = method13()
        let v648 : Mut4 = {l0 = v647} : Mut4
        let v649 : string = "{ "
        let v650 : string = $"{v649}"
        let v653 : unit = ()
        let v654 : (unit -> unit) = closure9(v648, v650)
        let v655 : unit = (fun () -> v654 (); v653) ()
        let v658 : string = "timeout"
        let v659 : string = $"{v658}"
        let v662 : unit = ()
        let v663 : (unit -> unit) = closure9(v648, v659)
        let v664 : unit = (fun () -> v663 (); v662) ()
        let v667 : string = " = "
        let v668 : string = $"{v667}"
        let v671 : unit = ()
        let v672 : (unit -> unit) = closure9(v648, v668)
        let v673 : unit = (fun () -> v672 (); v671) ()
        let v676 : string = $"{1000}"
        let v679 : unit = ()
        let v680 : (unit -> unit) = closure9(v648, v676)
        let v681 : unit = (fun () -> v680 (); v679) ()
        let v684 : string = "; "
        let v685 : string = $"{v684}"
        let v688 : unit = ()
        let v689 : (unit -> unit) = closure9(v648, v685)
        let v690 : unit = (fun () -> v689 (); v688) ()
        let v693 : string = "ex"
        let v694 : string = $"{v693}"
        let v697 : unit = ()
        let v698 : (unit -> unit) = closure9(v648, v694)
        let v699 : unit = (fun () -> v698 (); v697) ()
        let v702 : string = $"{v667}"
        let v705 : unit = ()
        let v706 : (unit -> unit) = closure9(v648, v702)
        let v707 : unit = (fun () -> v706 (); v705) ()
        let v710 : string = $"{v642}"
        let v713 : unit = ()
        let v714 : (unit -> unit) = closure9(v648, v710)
        let v715 : unit = (fun () -> v714 (); v713) ()
        let v718 : string = " }"
        let v719 : string = $"{v718}"
        let v722 : unit = ()
        let v723 : (unit -> unit) = closure9(v648, v719)
        let v724 : unit = (fun () -> v723 (); v722) ()
        let v727 : string = v648.l0
        let v728 : (unit -> string) = closure36()
        let v729 : string = $"{v483} {v618} #{v624} %s{v728 ()} / {v727}"
        let v732 : char list = []
        let v733 : (char list -> (char [])) = List.toArray
        let v734 : (char []) = v733 v732
        let v737 : string = v729.TrimStart v734 
        let v755 : char list = []
        let v756 : char list = '/' :: v755 
        let v759 : char list = ' ' :: v756 
        let v762 : (char list -> (char [])) = List.toArray
        let v763 : (char []) = v762 v759
        let v766 : string = v737.TrimEnd v763 
        let v784 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v785 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v766 v785 
        let _v784 = () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v786 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v766 v786 
        let _v784 = () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v787 : string = $"near_sdk::log!(\"{{}}\", $0)"
        Fable.Core.RustInterop.emitRustExpr v766 v787 
        let _v784 = () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        System.Console.WriteLine v766 
        let _v784 = () 
        #endif
#if FABLE_COMPILER_PYTHON
        System.Console.WriteLine v766 
        let _v784 = () 
        #endif
#else
        System.Console.WriteLine v766 
        let _v784 = () 
        #endif
        _v784 
        let v788 : (string -> unit) = v17.l0
        v788 v766
and closure38 () () : string =
    let v0 : string = "read_all_text_retry_async"
    v0
and closure37 (v0 : int64, v1 : string) () : unit =
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
        let v554 : string = "Debug"
        let v555 : (unit -> string) = v554.ToLower
        let v556 : string = v555 ()
        let v559 : string = v556.PadLeft (7, ' ')
        let v573 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v574 : string = "inline_colorization::color_bright_blue"
        let v575 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v574 
        let v576 : string = "&*$0"
        let v577 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v559 v576 
        let v578 : string = "inline_colorization::color_reset"
        let v579 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v578 
        let v580 : string = "\"{v575}{v577}{v579}\""
        let v581 : string = @$"format!(" + v580 + ")"
        let v582 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v581 
        let v583 : string = "fable_library_rust::String_::fromString($0)"
        let v584 : string = Fable.Core.RustInterop.emitRustExpr v582 v583 
        let _v573 = v584 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v585 : string = "inline_colorization::color_bright_blue"
        let v586 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v585 
        let v587 : string = "&*$0"
        let v588 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v559 v587 
        let v589 : string = "inline_colorization::color_reset"
        let v590 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v589 
        let v591 : string = "\"{v586}{v588}{v590}\""
        let v592 : string = @$"format!(" + v591 + ")"
        let v593 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v592 
        let v594 : string = "fable_library_rust::String_::fromString($0)"
        let v595 : string = Fable.Core.RustInterop.emitRustExpr v593 v594 
        let _v573 = v595 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v596 : string = "inline_colorization::color_bright_blue"
        let v597 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v596 
        let v598 : string = "&*$0"
        let v599 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v559 v598 
        let v600 : string = "inline_colorization::color_reset"
        let v601 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v600 
        let v602 : string = "\"{v597}{v599}{v601}\""
        let v603 : string = @$"format!(" + v602 + ")"
        let v604 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v603 
        let v605 : string = "fable_library_rust::String_::fromString($0)"
        let v606 : string = Fable.Core.RustInterop.emitRustExpr v604 v605 
        let _v573 = v606 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v607 : string = "\u001b[94m"
        let v608 : string = method11()
        let v609 : string = v607 + v559 
        let v610 : string = v609 + v608 
        let _v573 = v610 
        #endif
#if FABLE_COMPILER_PYTHON
        let v611 : string = "\u001b[94m"
        let v612 : string = method11()
        let v613 : string = v611 + v559 
        let v614 : string = v613 + v612 
        let _v573 = v614 
        #endif
#else
        let v615 : string = "\u001b[94m"
        let v616 : string = method11()
        let v617 : string = v615 + v559 
        let v618 : string = v617 + v616 
        let _v573 = v618 
        #endif
        let v619 : string = _v573 
        let v625 : int64 = v86.l0
        let v626 : string = method13()
        let v627 : Mut4 = {l0 = v626} : Mut4
        let v628 : string = "{ "
        let v629 : string = $"{v628}"
        let v632 : unit = ()
        let v633 : (unit -> unit) = closure9(v627, v629)
        let v634 : unit = (fun () -> v633 (); v632) ()
        let v637 : string = "retry"
        let v638 : string = $"{v637}"
        let v641 : unit = ()
        let v642 : (unit -> unit) = closure9(v627, v638)
        let v643 : unit = (fun () -> v642 (); v641) ()
        let v646 : string = " = "
        let v647 : string = $"{v646}"
        let v650 : unit = ()
        let v651 : (unit -> unit) = closure9(v627, v647)
        let v652 : unit = (fun () -> v651 (); v650) ()
        let v655 : string = $"{v0}"
        let v658 : unit = ()
        let v659 : (unit -> unit) = closure9(v627, v655)
        let v660 : unit = (fun () -> v659 (); v658) ()
        let v663 : string = "; "
        let v664 : string = $"{v663}"
        let v667 : unit = ()
        let v668 : (unit -> unit) = closure9(v627, v664)
        let v669 : unit = (fun () -> v668 (); v667) ()
        let v672 : string = "ex"
        let v673 : string = $"{v672}"
        let v676 : unit = ()
        let v677 : (unit -> unit) = closure9(v627, v673)
        let v678 : unit = (fun () -> v677 (); v676) ()
        let v681 : string = $"{v646}"
        let v684 : unit = ()
        let v685 : (unit -> unit) = closure9(v627, v681)
        let v686 : unit = (fun () -> v685 (); v684) ()
        let v689 : string = $"{v1}"
        let v692 : unit = ()
        let v693 : (unit -> unit) = closure9(v627, v689)
        let v694 : unit = (fun () -> v693 (); v692) ()
        let v697 : string = " }"
        let v698 : string = $"{v697}"
        let v701 : unit = ()
        let v702 : (unit -> unit) = closure9(v627, v698)
        let v703 : unit = (fun () -> v702 (); v701) ()
        let v706 : string = v627.l0
        let v707 : (unit -> string) = closure38()
        let v708 : string = $"{v484} {v619} #{v625} %s{v707 ()} / {v706}"
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
        let v767 : (string -> unit) = v18.l0
        v767 v745
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
        let v156 : (int64 -> US9) = closure31()
        let v157 : (exn -> US9) = closure32()
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
        let v1758 : US3 =
            match v217 with
            | US10_1(v220) -> (* Error *)
                let v221 : string = $"%A{v220}"
                let v224 : string = "System.TimeoutException"
                let v225 : bool = v221.Contains v224 
                if v225 then
                    let v228 : unit = ()
                    let v229 : (unit -> unit) = closure33()
                    let v230 : unit = (fun () -> v229 (); v228) ()
                    US3_1
                else
                    let v964 : unit = ()
                    let v965 : (unit -> unit) = closure35(v220)
                    let v966 : unit = (fun () -> v965 (); v964) ()
                    US3_1
            | US10_0(v218) -> (* Ok *)
                US3_0(v218)
        return v1758 
        }
        |> fun x -> _v216 <- Some x
        let v1759 : Async<US3> = match _v216 with Some x -> x | None -> failwith "async.new_async_unit / _v216=None"
        let _v200 = v1759 
        #endif
        let v1760 : Async<US3> = _v200 
        return! v1760 
        }
        |> fun x -> _v75 <- Some x
        let v1765 : Async<US3> = match _v75 with Some x -> x | None -> failwith "async.new_async_unit / _v75=None"
        let _v59 = v1765 
        #endif
        let v1766 : Async<US3> = _v59 
        let _v43 = v1766 
        #endif
        let v1771 : Async<US3> = _v43 
        let v1776 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v1777 : Async<unit> = null |> unbox<Async<unit>>
        let _v1776 = v1777 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v1780 : Async<unit> = null |> unbox<Async<unit>>
        let _v1776 = v1780 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v1783 : Async<unit> = null |> unbox<Async<unit>>
        let _v1776 = v1783 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v1786 : Async<unit> = null |> unbox<Async<unit>>
        let _v1776 = v1786 
        #endif
#if FABLE_COMPILER_PYTHON
        let v1789 : Async<unit> = null |> unbox<Async<unit>>
        let _v1776 = v1789 
        #endif
#else
        let v1792 : (Async<US3> -> Async<unit>) = Async.Ignore
        let v1793 : Async<unit> = v1792 v1771
        let _v1776 = v1793 
        #endif
        let v1794 : Async<unit> = _v1776 
        do! v1794 
        ()
    let v1799 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1800 : Async<string> = null |> unbox<Async<string>>
    let _v1799 = v1800 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1803 : Async<string> = null |> unbox<Async<string>>
    let _v1799 = v1803 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1806 : Async<string> = null |> unbox<Async<string>>
    let _v1799 = v1806 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1809 : Async<string> = null |> unbox<Async<string>>
    let _v1799 = v1809 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1812 : Async<string> = null |> unbox<Async<string>>
    let _v1799 = v1812 
    #endif
#else
    let v1815 : (string -> System.Threading.Tasks.Task<string>) = System.IO.File.ReadAllTextAsync
    let v1816 : System.Threading.Tasks.Task<string> = v1815 v0
    let v1817 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1818 : Async<string> = null |> unbox<Async<string>>
    let _v1817 = v1818 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1821 : Async<string> = null |> unbox<Async<string>>
    let _v1817 = v1821 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1824 : Async<string> = null |> unbox<Async<string>>
    let _v1817 = v1824 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1827 : Async<string> = null |> unbox<Async<string>>
    let _v1817 = v1827 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1830 : Async<string> = null |> unbox<Async<string>>
    let _v1817 = v1830 
    #endif
#else
    let v1833 : (System.Threading.Tasks.Task<string> -> Async<string>) = Async.AwaitTask
    let v1834 : Async<string> = v1833 v1816
    let _v1817 = v1834 
    #endif
    let v1835 : Async<string> = _v1817 
    let _v1799 = v1835 
    #endif
    let v1840 : Async<string> = _v1799 
    let v1845 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1846 : Async<string option> = null |> unbox<Async<string option>>
    let _v1845 = v1846 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1849 : Async<string option> = null |> unbox<Async<string option>>
    let _v1845 = v1849 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1852 : Async<string option> = null |> unbox<Async<string option>>
    let _v1845 = v1852 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1855 : Async<string option> = null |> unbox<Async<string option>>
    let _v1845 = v1855 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1858 : Async<string option> = null |> unbox<Async<string option>>
    let _v1845 = v1858 
    #endif
#else
    let v1861 : Async<string option> option = None
    let mutable _v1861 = v1861 
    async {
    let! v1840 = v1840 
    let v1862 : string = v1840 
    let v1863 : string option = Some v1862 
    return v1863 
    }
    |> fun x -> _v1861 <- Some x
    let v1866 : Async<string option> = match _v1861 with Some x -> x | None -> failwith "async.new_async_unit / _v1861=None"
    let _v1845 = v1866 
    #endif
    let v1867 : Async<string option> = _v1845 
    return! v1867 
    with ex ->
    let v1872 : exn = ex
    let v1873 : bool = v1 = 0L
    let v1874 : bool = v1873 <> true
    if v1874 then
        let v1875 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v1876 : string = $"%A{v1872}"
        let _v1875 = v1876 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v1879 : string = $"%A{v1872}"
        let _v1875 = v1879 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v1882 : string = $"%A{v1872}"
        let _v1875 = v1882 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v1885 : string = $"%A{v1872}"
        let _v1875 = v1885 
        #endif
#if FABLE_COMPILER_PYTHON
        let v1888 : string = $"%A{v1872}"
        let _v1875 = v1888 
        #endif
#else
        let v1891 : string = $"{v1872.GetType ()}: {v1872.Message}"
        let _v1875 = v1891 
        #endif
        let v1892 : string = _v1875 
        let v1897 : unit = ()
        let v1898 : (unit -> unit) = closure37(v1, v1892)
        let v1899 : unit = (fun () -> v1898 (); v1897) ()
        let v2666 : string option = None
        return v2666 
        (*
        ()
    else
        *) else
        let v2667 : int64 = v1 + 1L
        let v2668 : Async<string option> = method21(v0, v2667)
        return! v2668 
        (*
        ()
    *)
    (*
    let v2669 : string option = *)
    }
    |> fun x -> _v18 <- Some x
    let v2670 : Async<string option> = match _v18 with Some x -> x | None -> failwith "async.new_async_unit / _v18=None"
    let _v2 = v2670 
    #endif
    let v2671 : Async<string option> = _v2 
    v2671
and closure30 () (v0 : string) : Async<string option> =
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
and closure40 (v0 : US11 option ref) (v1 : US11 option) : US11 option ref =
    v0.Value <- v1 
    v0
and closure41 (v0 : chrono_DateTime<chrono_Utc> option, v1 : (US11 option -> US11 option ref)) () : unit =
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
    let v30 : (US11 option -> US11 option ref) = closure40(v29)
    let v31 : unit = ()
    let v32 : (unit -> unit) = closure41(v27, v30)
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
    let v195 : (US11 option -> US11 option ref) = closure40(v194)
    let v196 : unit = ()
    let v197 : (unit -> unit) = closure41(v192, v195)
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
and closure39 () () : string =
    method22()
and method36 (v0 : string) : string =
    v0
and closure43 () (v0 : std_io_Error) : std_string_String =
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
    closure43()
and closure44 () () : US12 =
    US12_0
and closure45 () (v0 : std_string_String) : US12 =
    US12_1(v0)
and closure47 () () : string =
    let v0 : string = "file_system.create_dir"
    v0
and closure46 (v0 : string, v1 : std_string_String) () : unit =
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
        let v554 : string = "Critical"
        let v555 : (unit -> string) = v554.ToLower
        let v556 : string = v555 ()
        let v559 : string = v556.PadLeft (7, ' ')
        let v573 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v574 : string = "inline_colorization::color_bright_red"
        let v575 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v574 
        let v576 : string = "&*$0"
        let v577 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v559 v576 
        let v578 : string = "inline_colorization::color_reset"
        let v579 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v578 
        let v580 : string = "\"{v575}{v577}{v579}\""
        let v581 : string = @$"format!(" + v580 + ")"
        let v582 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v581 
        let v583 : string = "fable_library_rust::String_::fromString($0)"
        let v584 : string = Fable.Core.RustInterop.emitRustExpr v582 v583 
        let _v573 = v584 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v585 : string = "inline_colorization::color_bright_red"
        let v586 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v585 
        let v587 : string = "&*$0"
        let v588 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v559 v587 
        let v589 : string = "inline_colorization::color_reset"
        let v590 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v589 
        let v591 : string = "\"{v586}{v588}{v590}\""
        let v592 : string = @$"format!(" + v591 + ")"
        let v593 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v592 
        let v594 : string = "fable_library_rust::String_::fromString($0)"
        let v595 : string = Fable.Core.RustInterop.emitRustExpr v593 v594 
        let _v573 = v595 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v596 : string = "inline_colorization::color_bright_red"
        let v597 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v596 
        let v598 : string = "&*$0"
        let v599 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v559 v598 
        let v600 : string = "inline_colorization::color_reset"
        let v601 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v600 
        let v602 : string = "\"{v597}{v599}{v601}\""
        let v603 : string = @$"format!(" + v602 + ")"
        let v604 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v603 
        let v605 : string = "fable_library_rust::String_::fromString($0)"
        let v606 : string = Fable.Core.RustInterop.emitRustExpr v604 v605 
        let _v573 = v606 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v607 : string = "\u001b[91m"
        let v608 : string = method11()
        let v609 : string = v607 + v559 
        let v610 : string = v609 + v608 
        let _v573 = v610 
        #endif
#if FABLE_COMPILER_PYTHON
        let v611 : string = "\u001b[91m"
        let v612 : string = method11()
        let v613 : string = v611 + v559 
        let v614 : string = v613 + v612 
        let _v573 = v614 
        #endif
#else
        let v615 : string = "\u001b[91m"
        let v616 : string = method11()
        let v617 : string = v615 + v559 
        let v618 : string = v617 + v616 
        let _v573 = v618 
        #endif
        let v619 : string = _v573 
        let v625 : int64 = v86.l0
        let v626 : string = method13()
        let v627 : Mut4 = {l0 = v626} : Mut4
        let v628 : string = "{ "
        let v629 : string = $"{v628}"
        let v632 : unit = ()
        let v633 : (unit -> unit) = closure9(v627, v629)
        let v634 : unit = (fun () -> v633 (); v632) ()
        let v637 : string = "dir"
        let v638 : string = $"{v637}"
        let v641 : unit = ()
        let v642 : (unit -> unit) = closure9(v627, v638)
        let v643 : unit = (fun () -> v642 (); v641) ()
        let v646 : string = " = "
        let v647 : string = $"{v646}"
        let v650 : unit = ()
        let v651 : (unit -> unit) = closure9(v627, v647)
        let v652 : unit = (fun () -> v651 (); v650) ()
        let v655 : string = $"{v0}"
        let v658 : unit = ()
        let v659 : (unit -> unit) = closure9(v627, v655)
        let v660 : unit = (fun () -> v659 (); v658) ()
        let v663 : string = "; "
        let v664 : string = $"{v663}"
        let v667 : unit = ()
        let v668 : (unit -> unit) = closure9(v627, v664)
        let v669 : unit = (fun () -> v668 (); v667) ()
        let v672 : string = "error"
        let v673 : string = $"{v672}"
        let v676 : unit = ()
        let v677 : (unit -> unit) = closure9(v627, v673)
        let v678 : unit = (fun () -> v677 (); v676) ()
        let v681 : string = $"{v646}"
        let v684 : unit = ()
        let v685 : (unit -> unit) = closure9(v627, v681)
        let v686 : unit = (fun () -> v685 (); v684) ()
        let v689 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v690 : string = "format!(\"{:#?}\", $0)"
        let v691 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1 v690 
        let v692 : string = "fable_library_rust::String_::fromString($0)"
        let v693 : string = Fable.Core.RustInterop.emitRustExpr v691 v692 
        let _v689 = v693 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v694 : string = "format!(\"{:#?}\", $0)"
        let v695 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1 v694 
        let v696 : string = "fable_library_rust::String_::fromString($0)"
        let v697 : string = Fable.Core.RustInterop.emitRustExpr v695 v696 
        let _v689 = v697 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v698 : string = "format!(\"{:#?}\", $0)"
        let v699 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1 v698 
        let v700 : string = "fable_library_rust::String_::fromString($0)"
        let v701 : string = Fable.Core.RustInterop.emitRustExpr v699 v700 
        let _v689 = v701 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v702 : string = $"%A{v1}"
        let _v689 = v702 
        #endif
#if FABLE_COMPILER_PYTHON
        let v705 : string = $"%A{v1}"
        let _v689 = v705 
        #endif
#else
        let v708 : string = $"%A{v1}"
        let _v689 = v708 
        #endif
        let v711 : string = _v689 
        let v716 : string = $"{v711}"
        let v719 : unit = ()
        let v720 : (unit -> unit) = closure9(v627, v716)
        let v721 : unit = (fun () -> v720 (); v719) ()
        let v724 : string = " }"
        let v725 : string = $"{v724}"
        let v728 : unit = ()
        let v729 : (unit -> unit) = closure9(v627, v725)
        let v730 : unit = (fun () -> v729 (); v728) ()
        let v733 : string = v627.l0
        let v734 : (unit -> string) = closure47()
        let v735 : string = $"{v484} {v619} #{v625} %s{v734 ()} / {v733}"
        let v738 : char list = []
        let v739 : (char list -> (char [])) = List.toArray
        let v740 : (char []) = v739 v738
        let v743 : string = v735.TrimStart v740 
        let v761 : char list = []
        let v762 : char list = '/' :: v761 
        let v765 : char list = ' ' :: v762 
        let v768 : (char list -> (char [])) = List.toArray
        let v769 : (char []) = v768 v765
        let v772 : string = v743.TrimEnd v769 
        let v790 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v791 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v772 v791 
        let _v790 = () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v792 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v772 v792 
        let _v790 = () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v793 : string = $"near_sdk::log!(\"{{}}\", $0)"
        Fable.Core.RustInterop.emitRustExpr v772 v793 
        let _v790 = () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        System.Console.WriteLine v772 
        let _v790 = () 
        #endif
#if FABLE_COMPILER_PYTHON
        System.Console.WriteLine v772 
        let _v790 = () 
        #endif
#else
        System.Console.WriteLine v772 
        let _v790 = () 
        #endif
        _v790 
        let v794 : (string -> unit) = v18.l0
        v794 v772
and closure49 () () : string =
    let v0 : string = "file_system.create_dir"
    v0
and closure48 (v0 : string) () : unit =
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
        let v607 : string = method11()
        let v608 : string = v606 + v558 
        let v609 : string = v608 + v607 
        let _v572 = v609 
        #endif
#if FABLE_COMPILER_PYTHON
        let v610 : string = "\u001b[90m"
        let v611 : string = method11()
        let v612 : string = v610 + v558 
        let v613 : string = v612 + v611 
        let _v572 = v613 
        #endif
#else
        let v614 : string = "\u001b[90m"
        let v615 : string = method11()
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
        let v672 : (unit -> string) = closure49()
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
        let v728 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v729 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v710 v729 
        let _v728 = () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v730 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v710 v730 
        let _v728 = () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v731 : string = $"near_sdk::log!(\"{{}}\", $0)"
        Fable.Core.RustInterop.emitRustExpr v710 v731 
        let _v728 = () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        System.Console.WriteLine v710 
        let _v728 = () 
        #endif
#if FABLE_COMPILER_PYTHON
        System.Console.WriteLine v710 
        let _v728 = () 
        #endif
#else
        System.Console.WriteLine v710 
        let _v728 = () 
        #endif
        _v728 
        let v732 : (string -> unit) = v17.l0
        v732 v710
and closure50 (v0 : string) () : unit =
    let v1 : bool = true
    method6(v1, v0)
and method38 (v0 : string) : (unit -> unit) =
    closure50(v0)
and method39 (v0 : string) : (unit -> unit) =
    closure50(v0)
and closure52 () () : string =
    let v0 : string = "file_system.create_dir"
    v0
and closure51 (v0 : string, v1 : string) () : unit =
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
        let v554 : string = "Debug"
        let v555 : (unit -> string) = v554.ToLower
        let v556 : string = v555 ()
        let v559 : string = v556.PadLeft (7, ' ')
        let v573 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v574 : string = "inline_colorization::color_bright_blue"
        let v575 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v574 
        let v576 : string = "&*$0"
        let v577 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v559 v576 
        let v578 : string = "inline_colorization::color_reset"
        let v579 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v578 
        let v580 : string = "\"{v575}{v577}{v579}\""
        let v581 : string = @$"format!(" + v580 + ")"
        let v582 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v581 
        let v583 : string = "fable_library_rust::String_::fromString($0)"
        let v584 : string = Fable.Core.RustInterop.emitRustExpr v582 v583 
        let _v573 = v584 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v585 : string = "inline_colorization::color_bright_blue"
        let v586 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v585 
        let v587 : string = "&*$0"
        let v588 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v559 v587 
        let v589 : string = "inline_colorization::color_reset"
        let v590 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v589 
        let v591 : string = "\"{v586}{v588}{v590}\""
        let v592 : string = @$"format!(" + v591 + ")"
        let v593 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v592 
        let v594 : string = "fable_library_rust::String_::fromString($0)"
        let v595 : string = Fable.Core.RustInterop.emitRustExpr v593 v594 
        let _v573 = v595 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v596 : string = "inline_colorization::color_bright_blue"
        let v597 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v596 
        let v598 : string = "&*$0"
        let v599 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v559 v598 
        let v600 : string = "inline_colorization::color_reset"
        let v601 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v600 
        let v602 : string = "\"{v597}{v599}{v601}\""
        let v603 : string = @$"format!(" + v602 + ")"
        let v604 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v603 
        let v605 : string = "fable_library_rust::String_::fromString($0)"
        let v606 : string = Fable.Core.RustInterop.emitRustExpr v604 v605 
        let _v573 = v606 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v607 : string = "\u001b[94m"
        let v608 : string = method11()
        let v609 : string = v607 + v559 
        let v610 : string = v609 + v608 
        let _v573 = v610 
        #endif
#if FABLE_COMPILER_PYTHON
        let v611 : string = "\u001b[94m"
        let v612 : string = method11()
        let v613 : string = v611 + v559 
        let v614 : string = v613 + v612 
        let _v573 = v614 
        #endif
#else
        let v615 : string = "\u001b[94m"
        let v616 : string = method11()
        let v617 : string = v615 + v559 
        let v618 : string = v617 + v616 
        let _v573 = v618 
        #endif
        let v619 : string = _v573 
        let v625 : int64 = v86.l0
        let v626 : string = method13()
        let v627 : Mut4 = {l0 = v626} : Mut4
        let v628 : string = "{ "
        let v629 : string = $"{v628}"
        let v632 : unit = ()
        let v633 : (unit -> unit) = closure9(v627, v629)
        let v634 : unit = (fun () -> v633 (); v632) ()
        let v637 : string = "dir"
        let v638 : string = $"{v637}"
        let v641 : unit = ()
        let v642 : (unit -> unit) = closure9(v627, v638)
        let v643 : unit = (fun () -> v642 (); v641) ()
        let v646 : string = " = "
        let v647 : string = $"{v646}"
        let v650 : unit = ()
        let v651 : (unit -> unit) = closure9(v627, v647)
        let v652 : unit = (fun () -> v651 (); v650) ()
        let v655 : string = $"{v0}"
        let v658 : unit = ()
        let v659 : (unit -> unit) = closure9(v627, v655)
        let v660 : unit = (fun () -> v659 (); v658) ()
        let v663 : string = "; "
        let v664 : string = $"{v663}"
        let v667 : unit = ()
        let v668 : (unit -> unit) = closure9(v627, v664)
        let v669 : unit = (fun () -> v668 (); v667) ()
        let v672 : string = "result"
        let v673 : string = $"{v672}"
        let v676 : unit = ()
        let v677 : (unit -> unit) = closure9(v627, v673)
        let v678 : unit = (fun () -> v677 (); v676) ()
        let v681 : string = $"{v646}"
        let v684 : unit = ()
        let v685 : (unit -> unit) = closure9(v627, v681)
        let v686 : unit = (fun () -> v685 (); v684) ()
        let v689 : string = $"{v1}"
        let v692 : unit = ()
        let v693 : (unit -> unit) = closure9(v627, v689)
        let v694 : unit = (fun () -> v693 (); v692) ()
        let v697 : string = " }"
        let v698 : string = $"{v697}"
        let v701 : unit = ()
        let v702 : (unit -> unit) = closure9(v627, v698)
        let v703 : unit = (fun () -> v702 (); v701) ()
        let v706 : string = v627.l0
        let v707 : (unit -> string) = closure52()
        let v708 : string = $"{v484} {v619} #{v625} %s{v707 ()} / {v706}"
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
        let v767 : (string -> unit) = v18.l0
        v767 v745
and closure53 (v0 : string) () : unit =
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
    closure53(v0)
and method41 (v0 : string) : (unit -> unit) =
    closure53(v0)
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
    let v8 : (unit -> US12) = closure44()
    let v9 : (std_string_String -> US12) = closure45()
    let v10 : US12 = match v7 with Ok () -> v8 () | Error x -> v9 x
    match v10 with
    | US12_1(v746) -> (* Error *)
        let v747 : unit = ()
        let v748 : (unit -> unit) = closure46(v2, v746)
        let v749 : unit = (fun () -> v748 (); v747) ()
        ()
    | US12_0 -> (* Ok *)
        let v11 : unit = ()
        let v12 : (unit -> unit) = closure48(v2)
        let v13 : unit = (fun () -> v12 (); v11) ()
        ()
    let v1543 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1544 : (unit -> unit) = method38(v2)
    let v1545 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v1544 "$0()" )
    let _v1543 = v1545 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1546 : (unit -> unit) = method38(v2)
    let v1547 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v1546 "$0()" )
    let _v1543 = v1547 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1548 : (unit -> unit) = method38(v2)
    let v1549 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v1548 "$0()" )
    let _v1543 = v1549 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1550 : (unit -> unit) = method39(v2)
    let v1551 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v1550 () }
    let _v1543 = v1551 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1552 : (unit -> unit) = method39(v2)
    let v1553 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v1552 () }
    let _v1543 = v1553 
    #endif
#else
    let v1554 : (unit -> unit) = method39(v2)
    let v1555 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v1554 () }
    let _v1543 = v1555 
    #endif
    let v1556 : System.IDisposable = _v1543 
    let _v1 = v1556 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1560 : System.IDisposable = null |> unbox<System.IDisposable>
    let _v1 = v1560 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1563 : System.IDisposable = null |> unbox<System.IDisposable>
    let _v1 = v1563 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1566 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1567 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    let _v1566 = v1567 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1570 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    let _v1566 = v1570 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1573 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    let _v1566 = v1573 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1576 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    let _v1566 = v1576 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1579 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    let _v1566 = v1579 
    #endif
#else
    let v1582 : (string -> System.IO.DirectoryInfo) = System.IO.Directory.CreateDirectory
    let v1583 : System.IO.DirectoryInfo = v1582 v0
    let _v1566 = v1583 
    #endif
    let v1584 : System.IO.DirectoryInfo = _v1566 
    let v1589 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1590 : bool = null |> unbox<bool>
    let _v1589 = v1590 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1593 : bool = null |> unbox<bool>
    let _v1589 = v1593 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1596 : bool = null |> unbox<bool>
    let _v1589 = v1596 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1599 : bool = null |> unbox<bool>
    let _v1589 = v1599 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1602 : bool = null |> unbox<bool>
    let _v1589 = v1602 
    #endif
#else
    let v1605 : bool = v1584.Exists
    let _v1589 = v1605 
    #endif
    let v1606 : bool = _v1589 
    let v1611 : bool = v1606 = false
    if v1611 then
        let v1612 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v1613 : System.DateTime = null |> unbox<System.DateTime>
        let _v1612 = v1613 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v1616 : System.DateTime = null |> unbox<System.DateTime>
        let _v1612 = v1616 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v1619 : System.DateTime = null |> unbox<System.DateTime>
        let _v1612 = v1619 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v1622 : System.DateTime = null |> unbox<System.DateTime>
        let _v1612 = v1622 
        #endif
#if FABLE_COMPILER_PYTHON
        let v1625 : System.DateTime = null |> unbox<System.DateTime>
        let _v1612 = v1625 
        #endif
#else
        let v1628 : System.DateTime = v1584.CreationTime
        let _v1612 = v1628 
        #endif
        let v1629 : System.DateTime = _v1612 
        let v1634 : obj = {| Exists = v1606; CreationTime = v1629 |}
        let v1635 : string = $"%A{v1634}"
        let v1638 : unit = ()
        let v1639 : (unit -> unit) = closure51(v0, v1635)
        let v1640 : unit = (fun () -> v1639 (); v1638) ()
        ()
    let v2407 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2408 : (unit -> unit) = method40(v0)
    let v2409 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v2408 "$0()" )
    let _v2407 = v2409 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v2410 : (unit -> unit) = method40(v0)
    let v2411 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v2410 "$0()" )
    let _v2407 = v2411 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v2412 : (unit -> unit) = method40(v0)
    let v2413 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v2412 "$0()" )
    let _v2407 = v2413 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v2414 : (unit -> unit) = method41(v0)
    let v2415 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v2414 () }
    let _v2407 = v2415 
    #endif
#if FABLE_COMPILER_PYTHON
    let v2416 : (unit -> unit) = method41(v0)
    let v2417 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v2416 () }
    let _v2407 = v2417 
    #endif
#else
    let v2418 : (unit -> unit) = method41(v0)
    let v2419 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v2418 () }
    let _v2407 = v2419 
    #endif
    let v2420 : System.IDisposable = _v2407 
    let _v1 = v2420 
    #endif
#if FABLE_COMPILER_PYTHON
    let v2424 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2425 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    let _v2424 = v2425 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v2428 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    let _v2424 = v2428 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v2431 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    let _v2424 = v2431 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v2434 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    let _v2424 = v2434 
    #endif
#if FABLE_COMPILER_PYTHON
    let v2437 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    let _v2424 = v2437 
    #endif
#else
    let v2440 : (string -> System.IO.DirectoryInfo) = System.IO.Directory.CreateDirectory
    let v2441 : System.IO.DirectoryInfo = v2440 v0
    let _v2424 = v2441 
    #endif
    let v2442 : System.IO.DirectoryInfo = _v2424 
    let v2447 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2448 : bool = null |> unbox<bool>
    let _v2447 = v2448 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v2451 : bool = null |> unbox<bool>
    let _v2447 = v2451 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v2454 : bool = null |> unbox<bool>
    let _v2447 = v2454 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v2457 : bool = null |> unbox<bool>
    let _v2447 = v2457 
    #endif
#if FABLE_COMPILER_PYTHON
    let v2460 : bool = null |> unbox<bool>
    let _v2447 = v2460 
    #endif
#else
    let v2463 : bool = v2442.Exists
    let _v2447 = v2463 
    #endif
    let v2464 : bool = _v2447 
    let v2469 : bool = v2464 = false
    if v2469 then
        let v2470 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v2471 : System.DateTime = null |> unbox<System.DateTime>
        let _v2470 = v2471 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v2474 : System.DateTime = null |> unbox<System.DateTime>
        let _v2470 = v2474 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v2477 : System.DateTime = null |> unbox<System.DateTime>
        let _v2470 = v2477 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v2480 : System.DateTime = null |> unbox<System.DateTime>
        let _v2470 = v2480 
        #endif
#if FABLE_COMPILER_PYTHON
        let v2483 : System.DateTime = null |> unbox<System.DateTime>
        let _v2470 = v2483 
        #endif
#else
        let v2486 : System.DateTime = v2442.CreationTime
        let _v2470 = v2486 
        #endif
        let v2487 : System.DateTime = _v2470 
        let v2492 : obj = {| Exists = v2464; CreationTime = v2487 |}
        let v2493 : string = $"%A{v2492}"
        let v2496 : unit = ()
        let v2497 : (unit -> unit) = closure51(v0, v2493)
        let v2498 : unit = (fun () -> v2497 (); v2496) ()
        ()
    let v3265 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3266 : (unit -> unit) = method40(v0)
    let v3267 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v3266 "$0()" )
    let _v3265 = v3267 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v3268 : (unit -> unit) = method40(v0)
    let v3269 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v3268 "$0()" )
    let _v3265 = v3269 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v3270 : (unit -> unit) = method40(v0)
    let v3271 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v3270 "$0()" )
    let _v3265 = v3271 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v3272 : (unit -> unit) = method41(v0)
    let v3273 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v3272 () }
    let _v3265 = v3273 
    #endif
#if FABLE_COMPILER_PYTHON
    let v3274 : (unit -> unit) = method41(v0)
    let v3275 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v3274 () }
    let _v3265 = v3275 
    #endif
#else
    let v3276 : (unit -> unit) = method41(v0)
    let v3277 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v3276 () }
    let _v3265 = v3277 
    #endif
    let v3278 : System.IDisposable = _v3265 
    let _v1 = v3278 
    #endif
#else
    let v3282 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3283 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    let _v3282 = v3283 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v3286 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    let _v3282 = v3286 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v3289 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    let _v3282 = v3289 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v3292 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    let _v3282 = v3292 
    #endif
#if FABLE_COMPILER_PYTHON
    let v3295 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    let _v3282 = v3295 
    #endif
#else
    let v3298 : (string -> System.IO.DirectoryInfo) = System.IO.Directory.CreateDirectory
    let v3299 : System.IO.DirectoryInfo = v3298 v0
    let _v3282 = v3299 
    #endif
    let v3300 : System.IO.DirectoryInfo = _v3282 
    let v3305 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3306 : bool = null |> unbox<bool>
    let _v3305 = v3306 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v3309 : bool = null |> unbox<bool>
    let _v3305 = v3309 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v3312 : bool = null |> unbox<bool>
    let _v3305 = v3312 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v3315 : bool = null |> unbox<bool>
    let _v3305 = v3315 
    #endif
#if FABLE_COMPILER_PYTHON
    let v3318 : bool = null |> unbox<bool>
    let _v3305 = v3318 
    #endif
#else
    let v3321 : bool = v3300.Exists
    let _v3305 = v3321 
    #endif
    let v3322 : bool = _v3305 
    let v3327 : bool = v3322 = false
    if v3327 then
        let v3328 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v3329 : System.DateTime = null |> unbox<System.DateTime>
        let _v3328 = v3329 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v3332 : System.DateTime = null |> unbox<System.DateTime>
        let _v3328 = v3332 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v3335 : System.DateTime = null |> unbox<System.DateTime>
        let _v3328 = v3335 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v3338 : System.DateTime = null |> unbox<System.DateTime>
        let _v3328 = v3338 
        #endif
#if FABLE_COMPILER_PYTHON
        let v3341 : System.DateTime = null |> unbox<System.DateTime>
        let _v3328 = v3341 
        #endif
#else
        let v3344 : System.DateTime = v3300.CreationTime
        let _v3328 = v3344 
        #endif
        let v3345 : System.DateTime = _v3328 
        let v3350 : obj = {| Exists = v3322; CreationTime = v3345 |}
        let v3351 : string = $"%A{v3350}"
        let v3354 : unit = ()
        let v3355 : (unit -> unit) = closure51(v0, v3351)
        let v3356 : unit = (fun () -> v3355 (); v3354) ()
        ()
    let v4123 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v4124 : (unit -> unit) = method40(v0)
    let v4125 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v4124 "$0()" )
    let _v4123 = v4125 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v4126 : (unit -> unit) = method40(v0)
    let v4127 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v4126 "$0()" )
    let _v4123 = v4127 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v4128 : (unit -> unit) = method40(v0)
    let v4129 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v4128 "$0()" )
    let _v4123 = v4129 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v4130 : (unit -> unit) = method41(v0)
    let v4131 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v4130 () }
    let _v4123 = v4131 
    #endif
#if FABLE_COMPILER_PYTHON
    let v4132 : (unit -> unit) = method41(v0)
    let v4133 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v4132 () }
    let _v4123 = v4133 
    #endif
#else
    let v4134 : (unit -> unit) = method41(v0)
    let v4135 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v4134 () }
    let _v4123 = v4135 
    #endif
    let v4136 : System.IDisposable = _v4123 
    let _v1 = v4136 
    #endif
    let v4140 : System.IDisposable = _v1 
    v4140
and closure42 () () : struct (string * System.IDisposable) =
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
and closure54 () (v0 : string) : struct (string * System.IDisposable) =
    let v1 : System.Guid = method42(v0)
    let v2 : string = method27(v1)
    let v3 : System.IDisposable = method35(v2)
    struct (v2, v3)
and closure55 () () : string =
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
and closure56 () (v0 : string) : string =
    method43(v0)
and closure57 () (v0 : string) : string =
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
and closure59 () (v0 : string) : string option =
    method47(v0)
and method46 () : (string -> string option) =
    closure59()
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
and closure61 () () : string =
    let v0 : string = "file_system.get_workspace_root"
    v0
and closure60 (v0 : string) () : unit =
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
        let v553 : string = "Warning"
        let v554 : (unit -> string) = v553.ToLower
        let v555 : string = v554 ()
        let v558 : string = v555.PadLeft (7, ' ')
        let v572 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v573 : string = "inline_colorization::color_yellow"
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
        let v584 : string = "inline_colorization::color_yellow"
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
        let v595 : string = "inline_colorization::color_yellow"
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
        let v606 : string = "\u001b[93m"
        let v607 : string = method11()
        let v608 : string = v606 + v558 
        let v609 : string = v608 + v607 
        let _v572 = v609 
        #endif
#if FABLE_COMPILER_PYTHON
        let v610 : string = "\u001b[93m"
        let v611 : string = method11()
        let v612 : string = v610 + v558 
        let v613 : string = v612 + v611 
        let _v572 = v613 
        #endif
#else
        let v614 : string = "\u001b[93m"
        let v615 : string = method11()
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
        let v636 : string = "error"
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
        let v672 : (unit -> string) = closure61()
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
        let v728 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v729 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v710 v729 
        let _v728 = () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v730 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v710 v730 
        let _v728 = () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v731 : string = $"near_sdk::log!(\"{{}}\", $0)"
        Fable.Core.RustInterop.emitRustExpr v710 v731 
        let _v728 = () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        System.Console.WriteLine v710 
        let _v728 = () 
        #endif
#if FABLE_COMPILER_PYTHON
        System.Console.WriteLine v710 
        let _v728 = () 
        #endif
#else
        System.Console.WriteLine v710 
        let _v728 = () 
        #endif
        _v728 
        let v732 : (string -> unit) = v17.l0
        v732 v710
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
and closure58 () () : string =
    let v0 : string = __SOURCE_DIRECTORY__
    let v1 : string = "polyglot"
    let v2 : string = ".devcontainer"
    let v3 : string = method30(v1, v2)
    let v4 : US13 = method45(v3, v0)
    let v745 : US1 =
        match v4 with
        | US13_1(v7) -> (* Error *)
            let v8 : unit = ()
            let v9 : (unit -> unit) = closure60(v7)
            let v10 : unit = (fun () -> v9 (); v8) ()
            US1_1
        | US13_0(v5) -> (* Ok *)
            US1_0(v5)
    let v1493 : US1 =
        match v745 with
        | US1_1 -> (* None *)
            let v748 : string = method49()
            let v749 : string = method30(v1, v2)
            let v750 : US13 = method45(v749, v748)
            match v750 with
            | US13_1(v753) -> (* Error *)
                let v754 : unit = ()
                let v755 : (unit -> unit) = closure60(v753)
                let v756 : unit = (fun () -> v755 (); v754) ()
                US1_1
            | US13_0(v751) -> (* Ok *)
                US1_0(v751)
        | US1_0(v746) -> (* Some *)
            US1_0(v746)
    let v1497 : string =
        match v1493 with
        | US1_1 -> (* None *)
            failwith<string> "Option does not have a value."
        | US1_0(v1494) -> (* Some *)
            v1494
    method30(v1497, v1)
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
    let v757 : US1 =
        match v16 with
        | US13_1(v19) -> (* Error *)
            let v20 : unit = ()
            let v21 : (unit -> unit) = closure60(v19)
            let v22 : unit = (fun () -> v21 (); v20) ()
            US1_1
        | US13_0(v17) -> (* Ok *)
            US1_0(v17)
    let v1505 : US1 =
        match v757 with
        | US1_1 -> (* None *)
            let v760 : string = method49()
            let v761 : string = method30(v13, v14)
            let v762 : US13 = method45(v761, v760)
            match v762 with
            | US13_1(v765) -> (* Error *)
                let v766 : unit = ()
                let v767 : (unit -> unit) = closure60(v765)
                let v768 : unit = (fun () -> v767 (); v766) ()
                US1_1
            | US13_0(v763) -> (* Ok *)
                US1_0(v763)
        | US1_0(v758) -> (* Some *)
            US1_0(v758)
    let v1509 : string =
        match v1505 with
        | US1_1 -> (* None *)
            failwith<string> "Option does not have a value."
        | US1_0(v1506) -> (* Some *)
            v1506
    let v1510 : string = method30(v1509, v13)
    let v1511 : string = "target/trace"
    let v1512 : string = method30(v1510, v1511)
    let v1513 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1514 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    let _v1513 = v1514 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1517 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    let _v1513 = v1517 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1520 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    let _v1513 = v1520 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1523 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    let _v1513 = v1523 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1526 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    let _v1513 = v1526 
    #endif
#else
    let v1529 : (string -> System.IO.DirectoryInfo) = System.IO.Directory.CreateDirectory
    let v1530 : System.IO.DirectoryInfo = v1529 v1512
    let _v1513 = v1530 
    #endif
    let v1531 : System.IO.DirectoryInfo = _v1513 
    let v1536 : string = method30(v1512, v11)
    let v1537 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1538 : Async<unit> = null |> unbox<Async<unit>>
    let _v1537 = v1538 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1541 : Async<unit> = null |> unbox<Async<unit>>
    let _v1537 = v1541 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1544 : Async<unit> = null |> unbox<Async<unit>>
    let _v1537 = v1544 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1547 : Async<unit> = null |> unbox<Async<unit>>
    let _v1537 = v1547 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1550 : Async<unit> = null |> unbox<Async<unit>>
    let _v1537 = v1550 
    #endif
#else
    let v1553 : System.Threading.Tasks.Task = System.IO.File.WriteAllTextAsync (v1536, v0)
    let v1554 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1555 : Async<unit> = null |> unbox<Async<unit>>
    let _v1554 = v1555 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1558 : Async<unit> = null |> unbox<Async<unit>>
    let _v1554 = v1558 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1561 : Async<unit> = null |> unbox<Async<unit>>
    let _v1554 = v1561 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1564 : Async<unit> = null |> unbox<Async<unit>>
    let _v1554 = v1564 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1567 : Async<unit> = null |> unbox<Async<unit>>
    let _v1554 = v1567 
    #endif
#else
    let v1570 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
    let v1571 : Async<unit> = v1570 v1553
    let _v1554 = v1571 
    #endif
    let v1572 : Async<unit> = _v1554 
    let _v1537 = v1572 
    #endif
    let v1577 : Async<unit> = _v1537 
    let v1582 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    null |> unbox<unit>
    let _v1582 = () 
    #endif
#if FABLE_COMPILER_RUST && WASM
    null |> unbox<unit>
    let _v1582 = () 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    null |> unbox<unit>
    let _v1582 = () 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    null |> unbox<unit>
    let _v1582 = () 
    #endif
#if FABLE_COMPILER_PYTHON
    null |> unbox<unit>
    let _v1582 = () 
    #endif
#else
    let v1583 : (Async<unit> -> unit) = Async.RunSynchronously
    v1583 v1577
    let _v1582 = () 
    #endif
    _v1582 
    with ex ->
    let v1584 : exn = ex
    let v1585 : string = $"file_system.trace_file / ex: %A{v1584}"
    method50(v1585)
    (*
    *)
    let _v1 = () 
    #endif
    _v1 
    ()
and closure63 () (v0 : string) : unit =
    method50(v0)
and closure62 () (v0 : bool) : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure0()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v16 : Mut0, v17 : Mut1, v18 : Mut2, v19 : Mut3, v20 : int64 option) = State.trace_state.Value
    let v33 : (string -> unit) =
        if v0 then
            closure63()
        else
            closure3()
    v17.l0 <- v33
    ()
and closure65 (v0 : string) (v1 : string) : string =
    method30(v0, v1)
and closure64 () (v0 : string) : (string -> string) =
    closure65(v0)
let v0 : unit = ()
let v1 : (unit -> unit) = closure0()
let v2 : unit = (fun () -> v1 (); v0) ()
let v15 : (string -> Async<int64>) = closure4()
let delete_directory_async x = v15 x
let v16 : (US6 -> (string -> Async<int64>)) = closure11()
let wait_for_file_access x = v16 x
let v17 : (string -> Async<int64>) = closure15()
let wait_for_file_access_read x = v17 x
let v18 : (string -> Async<string>) = closure16()
let read_all_text_async x = v18 x
let v19 : (string -> (string -> bool)) = closure17()
let file_exists_content x = v19 x
let v20 : (string -> (string -> Async<unit>)) = closure19()
let write_all_text_async x = v20 x
let v21 : (string -> (string -> Async<unit>)) = closure21()
let write_all_text_exists x = v21 x
let v22 : (string -> Async<int64>) = closure23()
let delete_file_async x = v22 x
let v23 : (string -> (string -> Async<int64>)) = closure26()
let move_file_async x = v23 x
let v24 : (string -> Async<string option>) = closure30()
let read_all_text_retry_async x = v24 x
let v25 : (unit -> string) = closure39()
let create_temp_path () = v25 ()
let v26 : (unit -> struct (string * System.IDisposable)) = closure42()
let create_temp_dir () = v26 ()
let v27 : (string -> struct (string * System.IDisposable)) = closure54()
let create_temp_dir' x = v27 x
let v28 : (unit -> string) = closure55()
let get_source_directory () = v28 ()
let v29 : (string -> string) = closure56()
let normalize_path x = v29 x
let v30 : (string -> string) = closure57()
let new_file_uri x = v30 x
let v31 : (unit -> string) = closure58()
let get_workspace_root () = v31 ()
let v32 : (bool -> unit) = closure62()
let init_trace_file x = v32 x
let v33 : (string -> (string -> string)) = closure64()
let (</>) x = v33 x
()
