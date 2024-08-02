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
    | US1_0 of f0_0 : US0
    | US1_1
and [<Struct>] US2 =
    | US2_0 of f0_0 : int64
    | US2_1
and [<Struct>] US3 =
    | US3_0 of f0_0 : string
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
let rec method0 () : string =
    let v0 : string = "TRACE_LEVEL"
    v0
and method2 () : string =
    let v0 : string = ""
    v0
and method1 (v0 : string) : string =
    let v3 : bool = true
    let mutable _v3 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v4 : string = "std::env::var(&*$0)"
    let v5 : Result<std_string_String, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr v0 v4 
    let v6 : string = "true; let _result = $0.map(|x| { //"
    let v7 : bool = Fable.Core.RustInterop.emitRustExpr v5 v6 
    let v8 : string = "x"
    let v9 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v8 
    let v10 : string = "fable_library_rust::String_::fromString($0)"
    let v11 : string = Fable.Core.RustInterop.emitRustExpr v9 v10 
    let v12 : string = "true; $0 })"
    let v13 : bool = Fable.Core.RustInterop.emitRustExpr v11 v12 
    let v14 : string = "_result"
    let v15 : Result<string, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr () v14 
    let v16 : string = method2()
    let v17 : string = "$0.unwrap_or($1)"
    let v18 : string = Fable.Core.RustInterop.emitRustExpr struct (v15, v16) v17 
    v18 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v19 : string = "std::env::var(&*$0)"
    let v20 : Result<std_string_String, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr v0 v19 
    let v21 : string = "true; let _result = $0.map(|x| { //"
    let v22 : bool = Fable.Core.RustInterop.emitRustExpr v20 v21 
    let v23 : string = "x"
    let v24 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v23 
    let v25 : string = "fable_library_rust::String_::fromString($0)"
    let v26 : string = Fable.Core.RustInterop.emitRustExpr v24 v25 
    let v27 : string = "true; $0 })"
    let v28 : bool = Fable.Core.RustInterop.emitRustExpr v26 v27 
    let v29 : string = "_result"
    let v30 : Result<string, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr () v29 
    let v31 : string = method2()
    let v32 : string = "$0.unwrap_or($1)"
    let v33 : string = Fable.Core.RustInterop.emitRustExpr struct (v30, v31) v32 
    v33 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v34 : string = "std::env::var(&*$0)"
    let v35 : Result<std_string_String, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr v0 v34 
    let v36 : string = "true; let _result = $0.map(|x| { //"
    let v37 : bool = Fable.Core.RustInterop.emitRustExpr v35 v36 
    let v38 : string = "x"
    let v39 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v38 
    let v40 : string = "fable_library_rust::String_::fromString($0)"
    let v41 : string = Fable.Core.RustInterop.emitRustExpr v39 v40 
    let v42 : string = "true; $0 })"
    let v43 : bool = Fable.Core.RustInterop.emitRustExpr v41 v42 
    let v44 : string = "_result"
    let v45 : Result<string, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr () v44 
    let v46 : string = method2()
    let v47 : string = "$0.unwrap_or($1)"
    let v48 : string = Fable.Core.RustInterop.emitRustExpr struct (v45, v46) v47 
    v48 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v49 : string = "process.env[$0] ?? \"\""
    let v50 : string = Fable.Core.JsInterop.emitJsExpr v0 v49 
    v50 
    #endif
#if FABLE_COMPILER_PYTHON
    let v53 : string = "os"
    let v54 : IOsEnviron = Fable.Core.PyInterop.importAll v53 
    let v55 : string = "v54.environ"
    let v56 : obj = Fable.Core.PyInterop.emitPyExpr () v55 
    let v65 : string = "v56.get($0)"
    let v66 : string = Fable.Core.PyInterop.emitPyExpr v0 v65 
    let mutable _v66 = None
    #if !FABLE_COMPILER && !WASM && !CONTRACT
    let v75 : (string -> string option) = Option.ofObj
    let v76 : string option = v75 v66
    v76 
    #else
    Some v66 
    #endif
    |> fun x -> _v66 <- Some x
    let v77 : string option = match _v66 with Some x -> x | None -> failwith "optionm'.of_obj / _v66=None"
    let v86 : US3 option = None
    let _v86 = ref v86 
    match v77 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v87 : string = x
    let v88 : US3 = US3_0(v87)
    v88 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v86.Value <- x
    let v89 : US3 option = _v86.Value 
    let v112 : US3 = US3_1
    let v113 : US3 = v89 |> Option.defaultValue v112 
    let v124 : string =
        match v113 with
        | US3_1 -> (* None *)
            let v122 : string = ""
            v122
        | US3_0(v121) -> (* Some *)
            v121
    v124 
    #endif
#else
    let v125 : (string -> string) = System.Environment.GetEnvironmentVariable
    let v126 : string = v125 v0
    let mutable _v126 = None
    #if !FABLE_COMPILER && !WASM && !CONTRACT
    let v129 : (string -> string option) = Option.ofObj
    let v130 : string option = v129 v126
    v130 
    #else
    Some v126 
    #endif
    |> fun x -> _v126 <- Some x
    let v131 : string option = match _v126 with Some x -> x | None -> failwith "optionm'.of_obj / _v126=None"
    let v140 : US3 option = None
    let _v140 = ref v140 
    match v131 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v141 : string = x
    let v142 : US3 = US3_0(v141)
    v142 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v140.Value <- x
    let v143 : US3 option = _v140.Value 
    let v166 : US3 = US3_1
    let v167 : US3 = v143 |> Option.defaultValue v166 
    let v178 : string =
        match v167 with
        | US3_1 -> (* None *)
            let v176 : string = ""
            v176
        | US3_0(v175) -> (* Some *)
            v175
    v178 
    #endif
    |> fun x -> _v3 <- Some x
    let v179 : string = match _v3 with Some x -> x | None -> failwith "base.run_target / _v3=None"
    v179
and method3 () : string =
    let v0 : string = "AUTOMATION"
    v0
and closure1 () (v0 : string) : unit =
    ()
and closure0 () (v0 : US0) : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) =
    let v3 : bool = true
    let mutable _v3 : struct (US1 * US2) option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v4 : string = method0()
    let v5 : string = method1(v4)
    let v7 : bool = "Verbose" = v5
    let v11 : US1 =
        if v7 then
            let v8 : US0 = US0_0
            US1_0(v8)
        else
            US1_1
    let v56 : US1 =
        match v11 with
        | US1_1 -> (* None *)
            let v15 : bool = "Debug" = v5
            let v19 : US1 =
                if v15 then
                    let v16 : US0 = US0_1
                    US1_0(v16)
                else
                    US1_1
            match v19 with
            | US1_1 -> (* None *)
                let v23 : bool = "Info" = v5
                let v27 : US1 =
                    if v23 then
                        let v24 : US0 = US0_2
                        US1_0(v24)
                    else
                        US1_1
                match v27 with
                | US1_1 -> (* None *)
                    let v31 : bool = "Warning" = v5
                    let v35 : US1 =
                        if v31 then
                            let v32 : US0 = US0_3
                            US1_0(v32)
                        else
                            US1_1
                    match v35 with
                    | US1_1 -> (* None *)
                        let v39 : bool = "Critical" = v5
                        let v43 : US1 =
                            if v39 then
                                let v40 : US0 = US0_4
                                US1_0(v40)
                            else
                                US1_1
                        match v43 with
                        | US1_1 -> (* None *)
                            US1_1
                        | US1_0(v44) -> (* Some *)
                            US1_0(v44)
                    | US1_0(v36) -> (* Some *)
                        US1_0(v36)
                | US1_0(v28) -> (* Some *)
                    US1_0(v28)
            | US1_0(v20) -> (* Some *)
                US1_0(v20)
        | US1_0(v12) -> (* Some *)
            US1_0(v12)
    let v57 : string = method3()
    let v58 : string = method1(v57)
    let v60 : bool = v58 = "True"
    let v82 : US2 =
        if v60 then
            let v63 : System.DateTime = System.DateTime.Now
            let v72 : (System.DateTime -> int64) = _.Ticks
            let v73 : int64 = v72 v63
            US2_0(v73)
        else
            US2_1
    struct (v56, v82) 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v83 : US1 = US1_1
    let v84 : US2 = US2_1
    struct (v83, v84) 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v85 : string = "AUTOMATION"
    let v88 : bool = true
    let mutable _v88 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v89 : string = "env!(\"" + v85 + "\")"
    let v90 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v89 
    let v91 : string = "String::from($0)"
    let v92 : std_string_String = Fable.Core.RustInterop.emitRustExpr v90 v91 
    let v93 : string = "fable_library_rust::String_::fromString($0)"
    let v94 : string = Fable.Core.RustInterop.emitRustExpr v92 v93 
    v94 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v95 : string = "env!(\"" + v85 + "\")"
    let v96 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v95 
    let v97 : string = "String::from($0)"
    let v98 : std_string_String = Fable.Core.RustInterop.emitRustExpr v96 v97 
    let v99 : string = "fable_library_rust::String_::fromString($0)"
    let v100 : string = Fable.Core.RustInterop.emitRustExpr v98 v99 
    v100 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v101 : string = "env!(\"" + v85 + "\")"
    let v102 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v101 
    let v103 : string = "String::from($0)"
    let v104 : std_string_String = Fable.Core.RustInterop.emitRustExpr v102 v103 
    let v105 : string = "fable_library_rust::String_::fromString($0)"
    let v106 : string = Fable.Core.RustInterop.emitRustExpr v104 v105 
    v106 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v109 : string = null |> unbox<string>
    v109 
    #endif
#if FABLE_COMPILER_PYTHON
    let v118 : string = null |> unbox<string>
    v118 
    #endif
#else
    let v127 : string = null |> unbox<string>
    v127 
    #endif
    |> fun x -> _v88 <- Some x
    let v134 : string = match _v88 with Some x -> x | None -> failwith "base.run_target / _v88=None"
    let v151 : string = "True"
    let v152 : bool = v134 <> v151 
    let v165 : US2 =
        if v152 then
            US2_1
        else
            let v160 : string = $"near_sdk::env::block_timestamp()"
            let v161 : uint64 = Fable.Core.RustInterop.emitRustExpr () v160 
            let v162 : (uint64 -> int64) = int64
            let v163 : int64 = v162 v161
            US2_0(v163)
    let v166 : US1 = US1_1
    struct (v166, v165) 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v167 : string = method0()
    let v168 : string = method1(v167)
    let v170 : bool = "Verbose" = v168
    let v174 : US1 =
        if v170 then
            let v171 : US0 = US0_0
            US1_0(v171)
        else
            US1_1
    let v219 : US1 =
        match v174 with
        | US1_1 -> (* None *)
            let v178 : bool = "Debug" = v168
            let v182 : US1 =
                if v178 then
                    let v179 : US0 = US0_1
                    US1_0(v179)
                else
                    US1_1
            match v182 with
            | US1_1 -> (* None *)
                let v186 : bool = "Info" = v168
                let v190 : US1 =
                    if v186 then
                        let v187 : US0 = US0_2
                        US1_0(v187)
                    else
                        US1_1
                match v190 with
                | US1_1 -> (* None *)
                    let v194 : bool = "Warning" = v168
                    let v198 : US1 =
                        if v194 then
                            let v195 : US0 = US0_3
                            US1_0(v195)
                        else
                            US1_1
                    match v198 with
                    | US1_1 -> (* None *)
                        let v202 : bool = "Critical" = v168
                        let v206 : US1 =
                            if v202 then
                                let v203 : US0 = US0_4
                                US1_0(v203)
                            else
                                US1_1
                        match v206 with
                        | US1_1 -> (* None *)
                            US1_1
                        | US1_0(v207) -> (* Some *)
                            US1_0(v207)
                    | US1_0(v199) -> (* Some *)
                        US1_0(v199)
                | US1_0(v191) -> (* Some *)
                    US1_0(v191)
            | US1_0(v183) -> (* Some *)
                US1_0(v183)
        | US1_0(v175) -> (* Some *)
            US1_0(v175)
    let v220 : string = method3()
    let v221 : string = method1(v220)
    let v222 : bool = v221 = "True"
    let v244 : US2 =
        if v222 then
            let v225 : System.DateTime = System.DateTime.Now
            let v234 : (System.DateTime -> int64) = _.Ticks
            let v235 : int64 = v234 v225
            US2_0(v235)
        else
            US2_1
    struct (v219, v244) 
    #endif
#if FABLE_COMPILER_PYTHON
    let v245 : string = method0()
    let v246 : string = method1(v245)
    let v248 : bool = "Verbose" = v246
    let v252 : US1 =
        if v248 then
            let v249 : US0 = US0_0
            US1_0(v249)
        else
            US1_1
    let v297 : US1 =
        match v252 with
        | US1_1 -> (* None *)
            let v256 : bool = "Debug" = v246
            let v260 : US1 =
                if v256 then
                    let v257 : US0 = US0_1
                    US1_0(v257)
                else
                    US1_1
            match v260 with
            | US1_1 -> (* None *)
                let v264 : bool = "Info" = v246
                let v268 : US1 =
                    if v264 then
                        let v265 : US0 = US0_2
                        US1_0(v265)
                    else
                        US1_1
                match v268 with
                | US1_1 -> (* None *)
                    let v272 : bool = "Warning" = v246
                    let v276 : US1 =
                        if v272 then
                            let v273 : US0 = US0_3
                            US1_0(v273)
                        else
                            US1_1
                    match v276 with
                    | US1_1 -> (* None *)
                        let v280 : bool = "Critical" = v246
                        let v284 : US1 =
                            if v280 then
                                let v281 : US0 = US0_4
                                US1_0(v281)
                            else
                                US1_1
                        match v284 with
                        | US1_1 -> (* None *)
                            US1_1
                        | US1_0(v285) -> (* Some *)
                            US1_0(v285)
                    | US1_0(v277) -> (* Some *)
                        US1_0(v277)
                | US1_0(v269) -> (* Some *)
                    US1_0(v269)
            | US1_0(v261) -> (* Some *)
                US1_0(v261)
        | US1_0(v253) -> (* Some *)
            US1_0(v253)
    let v298 : string = method3()
    let v299 : string = method1(v298)
    let v300 : bool = v299 = "True"
    let v322 : US2 =
        if v300 then
            let v303 : System.DateTime = System.DateTime.Now
            let v312 : (System.DateTime -> int64) = _.Ticks
            let v313 : int64 = v312 v303
            US2_0(v313)
        else
            US2_1
    struct (v297, v322) 
    #endif
#else
    let v323 : string = method0()
    let v324 : string = method1(v323)
    let v326 : bool = "Verbose" = v324
    let v330 : US1 =
        if v326 then
            let v327 : US0 = US0_0
            US1_0(v327)
        else
            US1_1
    let v375 : US1 =
        match v330 with
        | US1_1 -> (* None *)
            let v334 : bool = "Debug" = v324
            let v338 : US1 =
                if v334 then
                    let v335 : US0 = US0_1
                    US1_0(v335)
                else
                    US1_1
            match v338 with
            | US1_1 -> (* None *)
                let v342 : bool = "Info" = v324
                let v346 : US1 =
                    if v342 then
                        let v343 : US0 = US0_2
                        US1_0(v343)
                    else
                        US1_1
                match v346 with
                | US1_1 -> (* None *)
                    let v350 : bool = "Warning" = v324
                    let v354 : US1 =
                        if v350 then
                            let v351 : US0 = US0_3
                            US1_0(v351)
                        else
                            US1_1
                    match v354 with
                    | US1_1 -> (* None *)
                        let v358 : bool = "Critical" = v324
                        let v362 : US1 =
                            if v358 then
                                let v359 : US0 = US0_4
                                US1_0(v359)
                            else
                                US1_1
                        match v362 with
                        | US1_1 -> (* None *)
                            US1_1
                        | US1_0(v363) -> (* Some *)
                            US1_0(v363)
                    | US1_0(v355) -> (* Some *)
                        US1_0(v355)
                | US1_0(v347) -> (* Some *)
                    US1_0(v347)
            | US1_0(v339) -> (* Some *)
                US1_0(v339)
        | US1_0(v331) -> (* Some *)
            US1_0(v331)
    let v376 : string = method3()
    let v377 : string = method1(v376)
    let v378 : bool = v377 = "True"
    let v400 : US2 =
        if v378 then
            let v381 : System.DateTime = System.DateTime.Now
            let v390 : (System.DateTime -> int64) = _.Ticks
            let v391 : int64 = v390 v381
            US2_0(v391)
        else
            US2_1
    struct (v375, v400) 
    #endif
    |> fun x -> _v3 <- Some x
    let struct (v401 : US1, v402 : US2) = match _v3 with Some x -> x | None -> failwith "base.run_target / _v3=None"
    let v487 : Mut2 = {l0 = true} : Mut2
    let v488 : Mut0 = {l0 = 0L} : Mut0
    let v491 : US0 =
        match v401 with
        | US1_1 -> (* None *)
            v0
        | US1_0(v489) -> (* Some *)
            v489
    let v492 : Mut3 = {l0 = v491} : Mut3
    let v493 : (string -> unit) = closure1()
    let v494 : Mut1 = {l0 = v493} : Mut1
    let v507 : int64 option =
        match v402 with
        | US2_1 -> (* None *)
            let v505 : int64 option = None
            v505
        | US2_0(v495) -> (* Some *)
            let v498 : int64 option = Some v495 
            v498
    struct (v488, v494, v487, v492, v507)
and method6 (v0 : string) : string =
    v0
and method7 (v0 : string) : bool =
    let v3 : bool = true
    let mutable _v3 : bool option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v4 : string = "&*$0"
    let v5 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v4 
    let v6 : string = "String::from($0)"
    let v7 : std_string_String = Fable.Core.RustInterop.emitRustExpr v5 v6 
    let v8 : string = "std::path::PathBuf::from($0)"
    let v9 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v7 v8 
    let v10 : string = "$0.exists()"
    let v11 : bool = Fable.Core.RustInterop.emitRustExpr v9 v10 
    let v17 : bool =
        if v11 then
            true
        else
            let v12 : string = "$0.is_dir()"
            let v13 : bool = Fable.Core.RustInterop.emitRustExpr v9 v12 
            if v13 then
                true
            else
                let v14 : string = "$0.is_symlink()"
                let v15 : bool = Fable.Core.RustInterop.emitRustExpr v9 v14 
                v15
    v17 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v20 : bool = null |> unbox<bool>
    v20 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v29 : bool = null |> unbox<bool>
    v29 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v36 : string = "fs"
    let v37 : IFsExistsSync = Fable.Core.JsInterop.importAll v36 
    let v38 : string = "$0.existsSync($1)"
    let v39 : bool = Fable.Core.JsInterop.emitJsExpr struct (v37, v0) v38 
    v39 
    #endif
#if FABLE_COMPILER_PYTHON
    let v42 : bool = null |> unbox<bool>
    v42 
    #endif
#else
    let v49 : (string -> bool) = System.IO.Directory.Exists
    let v50 : bool = v49 v0
    v50 
    #endif
    |> fun x -> _v3 <- Some x
    let v51 : bool = match _v3 with Some x -> x | None -> failwith "base.run_target / _v3=None"
    v51
and method5 (v0 : bool, v1 : string) : unit =
    let v4 : bool = true
    let mutable _v4 : unit option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v5 : string = method6(v1)
    let v6 : bool = method7(v5)
    if v6 then
        if v0 then
            let v7 : string = "std::fs::remove_dir_all(&*$0).unwrap()"
            Fable.Core.RustInterop.emitRustExpr v5 v7 
            ()
        else
            let v8 : string = "std::fs::remove_dir(&*$0).unwrap()"
            Fable.Core.RustInterop.emitRustExpr v5 v8 
            ()
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
#if FABLE_COMPILER_TYPESCRIPT
    null |> unbox<unit>
    () 
    #endif
#if FABLE_COMPILER_PYTHON
    null |> unbox<unit>
    () 
    #endif
#else
    System.IO.Directory.Delete (v1, v0)
    () 
    #endif
    |> fun x -> _v4 <- Some x
    match _v4 with Some x -> x | None -> failwith "base.run_target / _v4=None"
    ()
and closure3 () () : string =
    let v0 : string = "file_system.delete_directory_async"
    v0
and method8 (v0 : string) : string =
    let v3 : bool = true
    let mutable _v3 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v4 : string = "&*$0"
    let v5 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v4 
    let v6 : string = "String::from($0)"
    let v7 : std_string_String = Fable.Core.RustInterop.emitRustExpr v5 v6 
    let v8 : string = "std::path::PathBuf::from($0)"
    let v9 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v7 v8 
    let v10 : string = "$0.file_name()"
    let v11 : Ref<std_ffi_OsStr> option = Fable.Core.RustInterop.emitRustExpr v9 v10 
    let v12 : string = "$0.unwrap()"
    let v13 : Ref<std_ffi_OsStr> = Fable.Core.RustInterop.emitRustExpr v11 v12 
    let v14 : string = "$0.to_os_string()"
    let v15 : std_ffi_OsString = Fable.Core.RustInterop.emitRustExpr v13 v14 
    let v16 : string = "$0.to_str()"
    let v17 : Ref<Str> option = Fable.Core.RustInterop.emitRustExpr v15 v16 
    let v18 : string = "$0.unwrap()"
    let v19 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v17 v18 
    let v20 : string = "String::from($0)"
    let v21 : std_string_String = Fable.Core.RustInterop.emitRustExpr v19 v20 
    let v22 : string = "fable_library_rust::String_::fromString($0)"
    let v23 : string = Fable.Core.RustInterop.emitRustExpr v21 v22 
    v23 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v24 : US4 = US4_1
    let v25 : US5 = US5_2(v24)
    let v26 : string = $"file_system.get_file_name / target: {v25} / path: {v0}"
    let v27 : string = failwith<string> v26
    v27 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v30 : string = null |> unbox<string>
    v30 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v37 : US4 = US4_0
    let v38 : US5 = US5_3(v37)
    let v39 : string = $"file_system.get_file_name / target: {v38} / path: {v0}"
    let v40 : string = failwith<string> v39
    v40 
    #endif
#if FABLE_COMPILER_PYTHON
    let v41 : US4 = US4_0
    let v42 : US5 = US5_4(v41)
    let v43 : string = $"file_system.get_file_name / target: {v42} / path: {v0}"
    let v44 : string = failwith<string> v43
    v44 
    #endif
#else
    let v45 : (string -> string) = System.IO.Path.GetFileName
    let v46 : string = v45 v0
    v46 
    #endif
    |> fun x -> _v3 <- Some x
    let v47 : string = match _v3 with Some x -> x | None -> failwith "base.run_target / _v3=None"
    v47
and closure4 (v0 : string, v1 : string) () : struct (string * string) =
    let v2 : string = method8(v0)
    struct (v1, v2)
and method10 () : string =
    let v0 : string = "hh:mm:ss"
    v0
and method11 () : string =
    let v0 : string = "HH:mm:ss"
    v0
and method12 () : string =
    let v0 : string = "\u001b[0m"
    v0
and method14 (v0 : Mut4, v1 : string) : unit =
    let v4 : string = $"{v1}"
    let v11 : string = v0.l0
    let v12 : string = v11 + v4 
    v0.l0 <- v12
    ()
and method15 (v0 : Mut4) : unit =
    ()
and method13 (v0 : Mut4, v1 : string, v2 : string) : unit =
    let v3 : string = "{ "
    method14(v0, v3)
    method15(v0)
    let v4 : string = "ex"
    method14(v0, v4)
    let v5 : string = " = "
    method14(v0, v5)
    method14(v0, v1)
    let v6 : string = "; "
    method14(v0, v6)
    let v7 : string = "path"
    method14(v0, v7)
    method14(v0, v5)
    method14(v0, v2)
    let v8 : string = " }"
    method14(v0, v8)
and closure5 (v0 : US0, v1 : (unit -> string), v2 : (unit -> struct (string * string))) () : string =
    let v5 : (US0 -> struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option)) = closure0()
    let v6 : US0 = US0_0
    if State.trace_state.IsNone then State.trace_state <- v5 v6 |> Some
    let struct (v14 : Mut0, v15 : Mut1, v16 : Mut2, v17 : Mut3, v18 : int64 option) = State.trace_state.Value
    let v35 : bool = true
    let mutable _v35 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v38 : US2 option = None
    let _v38 = ref v38 
    match v18 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v39 : int64 = x
    let v40 : US2 = US2_0(v39)
    v40 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v38.Value <- x
    let v41 : US2 option = _v38.Value 
    let v64 : US2 = US2_1
    let v65 : US2 = v41 |> Option.defaultValue v64 
    let v163 : System.DateTime =
        match v65 with
        | US2_1 -> (* None *)
            let v155 : System.DateTime = System.DateTime.Now
            v155
        | US2_0(v73) -> (* Some *)
            let v76 : System.DateTime = System.DateTime.Now
            let v85 : (System.DateTime -> int64) = _.Ticks
            let v86 : int64 = v85 v76
            let v93 : int64 = v86 - v73
            let v96 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v97 : System.TimeSpan = v96 v93
            let v106 : (System.TimeSpan -> int32) = _.Hours
            let v107 : int32 = v106 v97
            let v116 : (System.TimeSpan -> int32) = _.Minutes
            let v117 : int32 = v116 v97
            let v126 : (System.TimeSpan -> int32) = _.Seconds
            let v127 : int32 = v126 v97
            let v136 : (System.TimeSpan -> int32) = _.Milliseconds
            let v137 : int32 = v136 v97
            let v146 : System.DateTime = System.DateTime (1, 1, 1, v107, v117, v127, v137)
            v146
    let v166 : string = method10()
    let v175 : (string -> string) = v163.ToString
    let v176 : string = v175 v166
    v176 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v185 : US2 option = None
    let _v185 = ref v185 
    match v18 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v186 : int64 = x
    let v187 : US2 = US2_0(v186)
    v187 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v185.Value <- x
    let v188 : US2 option = _v185.Value 
    let v211 : US2 = US2_1
    let v212 : US2 = v188 |> Option.defaultValue v211 
    let v310 : System.DateTime =
        match v212 with
        | US2_1 -> (* None *)
            let v302 : System.DateTime = System.DateTime.Now
            v302
        | US2_0(v220) -> (* Some *)
            let v223 : System.DateTime = System.DateTime.Now
            let v232 : (System.DateTime -> int64) = _.Ticks
            let v233 : int64 = v232 v223
            let v240 : int64 = v233 - v220
            let v243 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v244 : System.TimeSpan = v243 v240
            let v253 : (System.TimeSpan -> int32) = _.Hours
            let v254 : int32 = v253 v244
            let v263 : (System.TimeSpan -> int32) = _.Minutes
            let v264 : int32 = v263 v244
            let v273 : (System.TimeSpan -> int32) = _.Seconds
            let v274 : int32 = v273 v244
            let v283 : (System.TimeSpan -> int32) = _.Milliseconds
            let v284 : int32 = v283 v244
            let v293 : System.DateTime = System.DateTime (1, 1, 1, v254, v264, v274, v284)
            v293
    let v313 : string = method10()
    let v322 : (string -> string) = v310.ToString
    let v323 : string = v322 v313
    v323 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v330 : string = $"near_sdk::env::block_timestamp()"
    let v331 : uint64 = Fable.Core.RustInterop.emitRustExpr () v330 
    let v334 : US2 option = None
    let _v334 = ref v334 
    match v18 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v335 : int64 = x
    let v336 : US2 = US2_0(v335)
    v336 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v334.Value <- x
    let v337 : US2 option = _v334.Value 
    let v360 : US2 = US2_1
    let v361 : US2 = v337 |> Option.defaultValue v360 
    let v374 : uint64 =
        match v361 with
        | US2_1 -> (* None *)
            v331
        | US2_0(v369) -> (* Some *)
            let v370 : (int64 -> uint64) = uint64
            let v371 : uint64 = v370 v369
            let v372 : uint64 = v331 - v371
            v372
    let v375 : uint64 = v374 / 1000000000UL
    let v376 : uint64 = v375 % 60UL
    let v377 : uint64 = v375 / 60UL
    let v378 : uint64 = v377 % 60UL
    let v379 : uint64 = v375 / 3600UL
    let v380 : uint64 = v379 % 24UL
    let v381 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
    let v382 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v380, v378, v376) v381 
    let v383 : string = "fable_library_rust::String_::fromString($0)"
    let v384 : string = Fable.Core.RustInterop.emitRustExpr v382 v383 
    v384 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v387 : US2 option = None
    let _v387 = ref v387 
    match v18 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v388 : int64 = x
    let v389 : US2 = US2_0(v388)
    v389 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v387.Value <- x
    let v390 : US2 option = _v387.Value 
    let v413 : US2 = US2_1
    let v414 : US2 = v390 |> Option.defaultValue v413 
    let v512 : System.DateTime =
        match v414 with
        | US2_1 -> (* None *)
            let v504 : System.DateTime = System.DateTime.Now
            v504
        | US2_0(v422) -> (* Some *)
            let v425 : System.DateTime = System.DateTime.Now
            let v434 : (System.DateTime -> int64) = _.Ticks
            let v435 : int64 = v434 v425
            let v442 : int64 = v435 - v422
            let v445 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v446 : System.TimeSpan = v445 v442
            let v455 : (System.TimeSpan -> int32) = _.Hours
            let v456 : int32 = v455 v446
            let v465 : (System.TimeSpan -> int32) = _.Minutes
            let v466 : int32 = v465 v446
            let v475 : (System.TimeSpan -> int32) = _.Seconds
            let v476 : int32 = v475 v446
            let v485 : (System.TimeSpan -> int32) = _.Milliseconds
            let v486 : int32 = v485 v446
            let v495 : System.DateTime = System.DateTime (1, 1, 1, v456, v466, v476, v486)
            v495
    let v515 : string = method11()
    let v524 : (string -> string) = v512.ToString
    let v525 : string = v524 v515
    v525 
    #endif
#if FABLE_COMPILER_PYTHON
    let v534 : US2 option = None
    let _v534 = ref v534 
    match v18 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v535 : int64 = x
    let v536 : US2 = US2_0(v535)
    v536 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v534.Value <- x
    let v537 : US2 option = _v534.Value 
    let v560 : US2 = US2_1
    let v561 : US2 = v537 |> Option.defaultValue v560 
    let v659 : System.DateTime =
        match v561 with
        | US2_1 -> (* None *)
            let v651 : System.DateTime = System.DateTime.Now
            v651
        | US2_0(v569) -> (* Some *)
            let v572 : System.DateTime = System.DateTime.Now
            let v581 : (System.DateTime -> int64) = _.Ticks
            let v582 : int64 = v581 v572
            let v589 : int64 = v582 - v569
            let v592 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v593 : System.TimeSpan = v592 v589
            let v602 : (System.TimeSpan -> int32) = _.Hours
            let v603 : int32 = v602 v593
            let v612 : (System.TimeSpan -> int32) = _.Minutes
            let v613 : int32 = v612 v593
            let v622 : (System.TimeSpan -> int32) = _.Seconds
            let v623 : int32 = v622 v593
            let v632 : (System.TimeSpan -> int32) = _.Milliseconds
            let v633 : int32 = v632 v593
            let v642 : System.DateTime = System.DateTime (1, 1, 1, v603, v613, v623, v633)
            v642
    let v662 : string = method11()
    let v671 : (string -> string) = v659.ToString
    let v672 : string = v671 v662
    v672 
    #endif
#else
    let v681 : US2 option = None
    let _v681 = ref v681 
    match v18 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v682 : int64 = x
    let v683 : US2 = US2_0(v682)
    v683 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v681.Value <- x
    let v684 : US2 option = _v681.Value 
    let v707 : US2 = US2_1
    let v708 : US2 = v684 |> Option.defaultValue v707 
    let v806 : System.DateTime =
        match v708 with
        | US2_1 -> (* None *)
            let v798 : System.DateTime = System.DateTime.Now
            v798
        | US2_0(v716) -> (* Some *)
            let v719 : System.DateTime = System.DateTime.Now
            let v728 : (System.DateTime -> int64) = _.Ticks
            let v729 : int64 = v728 v719
            let v736 : int64 = v729 - v716
            let v739 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v740 : System.TimeSpan = v739 v736
            let v749 : (System.TimeSpan -> int32) = _.Hours
            let v750 : int32 = v749 v740
            let v759 : (System.TimeSpan -> int32) = _.Minutes
            let v760 : int32 = v759 v740
            let v769 : (System.TimeSpan -> int32) = _.Seconds
            let v770 : int32 = v769 v740
            let v779 : (System.TimeSpan -> int32) = _.Milliseconds
            let v780 : int32 = v779 v740
            let v789 : System.DateTime = System.DateTime (1, 1, 1, v750, v760, v770, v780)
            v789
    let v809 : string = method11()
    let v818 : (string -> string) = v806.ToString
    let v819 : string = v818 v809
    v819 
    #endif
    |> fun x -> _v35 <- Some x
    let v826 : string = match _v35 with Some x -> x | None -> failwith "base.run_target / _v35=None"
    let v981 : bool =
        match v0 with
        | US0_0 -> (* Verbose *)
            true
        | _ ->
            false
    let v985 : US3 =
        if v981 then
            let v982 : string = "Verbose"
            US3_0(v982)
        else
            US3_1
    let v1034 : US3 =
        match v985 with
        | US3_1 -> (* None *)
            let v990 : bool =
                match v0 with
                | US0_1 -> (* Debug *)
                    true
                | _ ->
                    false
            let v994 : US3 =
                if v990 then
                    let v991 : string = "Debug"
                    US3_0(v991)
                else
                    US3_1
            match v994 with
            | US3_1 -> (* None *)
                let v999 : bool =
                    match v0 with
                    | US0_2 -> (* Info *)
                        true
                    | _ ->
                        false
                let v1003 : US3 =
                    if v999 then
                        let v1000 : string = "Info"
                        US3_0(v1000)
                    else
                        US3_1
                match v1003 with
                | US3_1 -> (* None *)
                    let v1008 : bool =
                        match v0 with
                        | US0_3 -> (* Warning *)
                            true
                        | _ ->
                            false
                    let v1012 : US3 =
                        if v1008 then
                            let v1009 : string = "Warning"
                            US3_0(v1009)
                        else
                            US3_1
                    match v1012 with
                    | US3_1 -> (* None *)
                        let v1017 : bool =
                            match v0 with
                            | US0_4 -> (* Critical *)
                                true
                            | _ ->
                                false
                        let v1021 : US3 =
                            if v1017 then
                                let v1018 : string = "Critical"
                                US3_0(v1018)
                            else
                                US3_1
                        match v1021 with
                        | US3_1 -> (* None *)
                            US3_1
                        | US3_0(v1022) -> (* Some *)
                            US3_0(v1022)
                    | US3_0(v1013) -> (* Some *)
                        US3_0(v1013)
                | US3_0(v1004) -> (* Some *)
                    US3_0(v1004)
            | US3_0(v995) -> (* Some *)
                US3_0(v995)
        | US3_0(v986) -> (* Some *)
            US3_0(v986)
    let v1038 : string =
        match v1034 with
        | US3_1 -> (* None *)
            failwith<string> "Option does not have a value."
        | US3_0(v1035) -> (* Some *)
            v1035
    let v1041 : (unit -> string) = v1038.ToLower
    let v1042 : string = v1041 ()
    let v1051 : string = v1042.PadLeft (7, ' ')
    let v1083 : bool = true
    let mutable _v1083 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1098 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v1092 : string = "inline_colorization::color_bright_red"
            let v1093 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1092 
            v1093
        | US0_1 -> (* Debug *)
            let v1086 : string = "inline_colorization::color_bright_blue"
            let v1087 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1086 
            v1087
        | US0_2 -> (* Info *)
            let v1088 : string = "inline_colorization::color_bright_green"
            let v1089 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1088 
            v1089
        | US0_0 -> (* Verbose *)
            let v1084 : string = "inline_colorization::color_bright_black"
            let v1085 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1084 
            v1085
        | US0_3 -> (* Warning *)
            let v1090 : string = "inline_colorization::color_yellow"
            let v1091 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1090 
            v1091
    let v1099 : string = "&*$0"
    let v1100 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1051 v1099 
    let v1101 : string = "inline_colorization::color_reset"
    let v1102 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1101 
    let v1103 : string = "\"{v1098}{v1100}{v1102}\""
    let v1104 : string = @$"format!(" + v1103 + ")"
    let v1105 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v1104 
    let v1106 : string = "fable_library_rust::String_::fromString($0)"
    let v1107 : string = Fable.Core.RustInterop.emitRustExpr v1105 v1106 
    v1107 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1122 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v1116 : string = "inline_colorization::color_bright_red"
            let v1117 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1116 
            v1117
        | US0_1 -> (* Debug *)
            let v1110 : string = "inline_colorization::color_bright_blue"
            let v1111 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1110 
            v1111
        | US0_2 -> (* Info *)
            let v1112 : string = "inline_colorization::color_bright_green"
            let v1113 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1112 
            v1113
        | US0_0 -> (* Verbose *)
            let v1108 : string = "inline_colorization::color_bright_black"
            let v1109 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1108 
            v1109
        | US0_3 -> (* Warning *)
            let v1114 : string = "inline_colorization::color_yellow"
            let v1115 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1114 
            v1115
    let v1123 : string = "&*$0"
    let v1124 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1051 v1123 
    let v1125 : string = "inline_colorization::color_reset"
    let v1126 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1125 
    let v1127 : string = "\"{v1122}{v1124}{v1126}\""
    let v1128 : string = @$"format!(" + v1127 + ")"
    let v1129 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v1128 
    let v1130 : string = "fable_library_rust::String_::fromString($0)"
    let v1131 : string = Fable.Core.RustInterop.emitRustExpr v1129 v1130 
    v1131 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1146 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v1140 : string = "inline_colorization::color_bright_red"
            let v1141 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1140 
            v1141
        | US0_1 -> (* Debug *)
            let v1134 : string = "inline_colorization::color_bright_blue"
            let v1135 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1134 
            v1135
        | US0_2 -> (* Info *)
            let v1136 : string = "inline_colorization::color_bright_green"
            let v1137 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1136 
            v1137
        | US0_0 -> (* Verbose *)
            let v1132 : string = "inline_colorization::color_bright_black"
            let v1133 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1132 
            v1133
        | US0_3 -> (* Warning *)
            let v1138 : string = "inline_colorization::color_yellow"
            let v1139 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1138 
            v1139
    let v1147 : string = "&*$0"
    let v1148 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1051 v1147 
    let v1149 : string = "inline_colorization::color_reset"
    let v1150 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1149 
    let v1151 : string = "\"{v1146}{v1148}{v1150}\""
    let v1152 : string = @$"format!(" + v1151 + ")"
    let v1153 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v1152 
    let v1154 : string = "fable_library_rust::String_::fromString($0)"
    let v1155 : string = Fable.Core.RustInterop.emitRustExpr v1153 v1154 
    v1155 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1165 : string =
        match v0 with
        | US0_4 -> (* Critical *)
            let v1160 : string = "\u001b[91m"
            v1160
        | US0_1 -> (* Debug *)
            let v1157 : string = "\u001b[94m"
            v1157
        | US0_2 -> (* Info *)
            let v1158 : string = "\u001b[92m"
            v1158
        | US0_0 -> (* Verbose *)
            let v1156 : string = "\u001b[90m"
            v1156
        | US0_3 -> (* Warning *)
            let v1159 : string = "\u001b[93m"
            v1159
    let v1166 : string = method12()
    let v1167 : string = v1165 + v1051 
    let v1168 : string = v1167 + v1166 
    v1168 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1178 : string =
        match v0 with
        | US0_4 -> (* Critical *)
            let v1173 : string = "\u001b[91m"
            v1173
        | US0_1 -> (* Debug *)
            let v1170 : string = "\u001b[94m"
            v1170
        | US0_2 -> (* Info *)
            let v1171 : string = "\u001b[92m"
            v1171
        | US0_0 -> (* Verbose *)
            let v1169 : string = "\u001b[90m"
            v1169
        | US0_3 -> (* Warning *)
            let v1172 : string = "\u001b[93m"
            v1172
    let v1179 : string = method12()
    let v1180 : string = v1178 + v1051 
    let v1181 : string = v1180 + v1179 
    v1181 
    #endif
#else
    let v1191 : string =
        match v0 with
        | US0_4 -> (* Critical *)
            let v1186 : string = "\u001b[91m"
            v1186
        | US0_1 -> (* Debug *)
            let v1183 : string = "\u001b[94m"
            v1183
        | US0_2 -> (* Info *)
            let v1184 : string = "\u001b[92m"
            v1184
        | US0_0 -> (* Verbose *)
            let v1182 : string = "\u001b[90m"
            v1182
        | US0_3 -> (* Warning *)
            let v1185 : string = "\u001b[93m"
            v1185
    let v1192 : string = method12()
    let v1193 : string = v1191 + v1051 
    let v1194 : string = v1193 + v1192 
    v1194 
    #endif
    |> fun x -> _v1083 <- Some x
    let v1195 : string = match _v1083 with Some x -> x | None -> failwith "base.run_target / _v1083=None"
    let v1214 : int64 = v14.l0
    let struct (v1215 : string, v1216 : string) = v2 ()
    let v1217 : string = ""
    let v1218 : Mut4 = {l0 = v1217} : Mut4
    method13(v1218, v1215, v1216)
    let v1219 : string = v1218.l0
    let v1222 : string = $"{v826} {v1195} #{v1214} %s{v1 ()} / {v1219}"
    let v1229 : char list = []
    let v1234 : (char list -> (char [])) = List.toArray
    let v1235 : (char []) = v1234 v1229
    let v1242 : string = v1222.TrimStart v1235 
    let v1281 : char list = []
    let v1284 : char list = '/' :: v1281 
    let v1293 : char list = ' ' :: v1284 
    let v1304 : (char list -> (char [])) = List.toArray
    let v1305 : (char []) = v1304 v1293
    let v1312 : string = v1242.TrimEnd v1305 
    v1312
and method16 (v0 : US0, v1 : (unit -> string)) : unit =
    let v4 : (US0 -> struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option)) = closure0()
    let v5 : US0 = US0_0
    if State.trace_state.IsNone then State.trace_state <- v4 v5 |> Some
    let struct (v13 : Mut0, v14 : Mut1, v15 : Mut2, v16 : Mut3, v17 : int64 option) = State.trace_state.Value
    let v34 : US0 = US0_0
    if State.trace_state.IsNone then State.trace_state <- v4 v34 |> Some
    let struct (v42 : Mut0, v43 : Mut1, v44 : Mut2, v45 : Mut3, v46 : int64 option) = State.trace_state.Value
    let v61 : US0 = v45.l0
    let v62 : bool = v44.l0
    let v63 : bool = v62 = false
    let v67 : bool =
        if v63 then
            false
        else
            let v64 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v0
            let v65 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v61
            let v66 : bool = v64 >= v65
            v66
    if v67 then
        let v68 : int64 = v13.l0
        let v69 : int64 = v68 + 1L
        v13.l0 <- v69
        let v72 : string = $"%s{v1 ()}"
        let v81 : bool = true
        let mutable _v81 : unit option = None 
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v82 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v72 v82 
        () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v83 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v72 v83 
        () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v84 : string = $"near_sdk::log!(\"{{}}\", $0)"
        Fable.Core.RustInterop.emitRustExpr v72 v84 
        () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        System.Console.WriteLine v72 
        () 
        #endif
#if FABLE_COMPILER_PYTHON
        System.Console.WriteLine v72 
        () 
        #endif
#else
        System.Console.WriteLine v72 
        () 
        #endif
        |> fun x -> _v81 <- Some x
        match _v81 with Some x -> x | None -> failwith "base.run_target / _v81=None"
        let v113 : (string -> unit) = v14.l0
        v113 v72
and method9 (v0 : US0, v1 : (unit -> string), v2 : (unit -> struct (string * string))) : unit =
    let v3 : (unit -> string) = closure5(v0, v1, v2)
    method16(v0, v3)
and method4 (v0 : string, v1 : int64) : Async<int64> =
    let v4 : bool = true
    let mutable _v4 : Async<int64> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v7 : Async<int64> = null |> unbox<Async<int64>>
    v7 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v16 : Async<int64> = null |> unbox<Async<int64>>
    v16 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v25 : Async<int64> = null |> unbox<Async<int64>>
    v25 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v34 : Async<int64> = null |> unbox<Async<int64>>
    v34 
    #endif
#if FABLE_COMPILER_PYTHON
    let v43 : Async<int64> = null |> unbox<Async<int64>>
    v43 
    #endif
#else
    let v50 : Async<int64> option = None
    let mutable _v50 = v50 
    async {
    try
    let v51 : bool = true
    method5(v51, v0)
    return v1 
    with ex ->
    let v52 : exn = ex
    let v53 : int64 = v1 % 100L
    let v54 : bool = v53 = 0L
    if v54 then
        let v57 : bool = true
        let mutable _v57 : string option = None 
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v60 : string = $"%A{v52}"
        v60 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v69 : string = $"%A{v52}"
        v69 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v78 : string = $"%A{v52}"
        v78 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v87 : string = $"%A{v52}"
        v87 
        #endif
#if FABLE_COMPILER_PYTHON
        let v96 : string = $"%A{v52}"
        v96 
        #endif
#else
        let v103 : string = $"{v52.GetType ()}: {v52.Message}"
        v103 
        #endif
        |> fun x -> _v57 <- Some x
        let v104 : string = match _v57 with Some x -> x | None -> failwith "base.run_target / _v57=None"
        let v119 : US0 = US0_1
        let v120 : (unit -> string) = closure3()
        let v121 : (unit -> struct (string * string)) = closure4(v0, v104)
        method9(v119, v120, v121)
    let v124 : bool = true
    let mutable _v124 : Async<unit> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v127 : Async<unit> = null |> unbox<Async<unit>>
    v127 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v136 : Async<unit> = null |> unbox<Async<unit>>
    v136 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v145 : Async<unit> = null |> unbox<Async<unit>>
    v145 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v154 : Async<unit> = null |> unbox<Async<unit>>
    v154 
    #endif
#if FABLE_COMPILER_PYTHON
    let v163 : Async<unit> = null |> unbox<Async<unit>>
    v163 
    #endif
#else
    let v170 : (int32 -> Async<unit>) = Async.Sleep
    let v171 : Async<unit> = v170 10
    v171 
    #endif
    |> fun x -> _v124 <- Some x
    let v172 : Async<unit> = match _v124 with Some x -> x | None -> failwith "base.run_target / _v124=None"
    do! v172 
    let v187 : int64 = v1 + 1L
    let v188 : Async<int64> = method4(v0, v187)
    return! v188 
    (*
    let v189 : int64 = *)
    }
    |> fun x -> _v50 <- Some x
    let v190 : Async<int64> = match _v50 with Some x -> x | None -> failwith "async.new_async_unit / _v50=None"
    v190 
    #endif
    |> fun x -> _v4 <- Some x
    let v191 : Async<int64> = match _v4 with Some x -> x | None -> failwith "base.run_target / _v4=None"
    v191
and closure2 () (v0 : string) : Async<int64> =
    let v3 : bool = true
    let mutable _v3 : Async<int64> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v6 : Async<int64> = null |> unbox<Async<int64>>
    v6 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v15 : Async<int64> = null |> unbox<Async<int64>>
    v15 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v24 : Async<int64> = null |> unbox<Async<int64>>
    v24 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v33 : Async<int64> = null |> unbox<Async<int64>>
    v33 
    #endif
#if FABLE_COMPILER_PYTHON
    let v42 : Async<int64> = null |> unbox<Async<int64>>
    v42 
    #endif
#else
    let v49 : int64 = 0L
    let v50 : Async<int64> = method4(v0, v49)
    v50 
    #endif
    |> fun x -> _v3 <- Some x
    let v51 : Async<int64> = match _v3 with Some x -> x | None -> failwith "base.run_target / _v3=None"
    v51
and closure8 () () : string =
    let v0 : string = "file_system.wait_for_file_access"
    v0
and closure9 (v0 : string, v1 : int64, v2 : string) () : struct (string * int64 * string) =
    let v3 : string = method8(v0)
    struct (v3, v1, v2)
and method20 (v0 : Mut4, v1 : int64) : unit =
    let v4 : string = $"{v1}"
    let v11 : string = v0.l0
    let v12 : string = v11 + v4 
    v0.l0 <- v12
    ()
and method19 (v0 : Mut4, v1 : string, v2 : int64, v3 : string) : unit =
    let v4 : string = "{ "
    method14(v0, v4)
    method15(v0)
    let v5 : string = "path"
    method14(v0, v5)
    let v6 : string = " = "
    method14(v0, v6)
    method14(v0, v1)
    let v7 : string = "; "
    method14(v0, v7)
    let v8 : string = "retry"
    method14(v0, v8)
    method14(v0, v6)
    method20(v0, v2)
    method14(v0, v7)
    let v9 : string = "ex"
    method14(v0, v9)
    method14(v0, v6)
    method14(v0, v3)
    let v10 : string = " }"
    method14(v0, v10)
and closure10 (v0 : US0, v1 : (unit -> string), v2 : (unit -> struct (string * int64 * string))) () : string =
    let v5 : (US0 -> struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option)) = closure0()
    let v6 : US0 = US0_0
    if State.trace_state.IsNone then State.trace_state <- v5 v6 |> Some
    let struct (v14 : Mut0, v15 : Mut1, v16 : Mut2, v17 : Mut3, v18 : int64 option) = State.trace_state.Value
    let v35 : bool = true
    let mutable _v35 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v38 : US2 option = None
    let _v38 = ref v38 
    match v18 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v39 : int64 = x
    let v40 : US2 = US2_0(v39)
    v40 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v38.Value <- x
    let v41 : US2 option = _v38.Value 
    let v64 : US2 = US2_1
    let v65 : US2 = v41 |> Option.defaultValue v64 
    let v163 : System.DateTime =
        match v65 with
        | US2_1 -> (* None *)
            let v155 : System.DateTime = System.DateTime.Now
            v155
        | US2_0(v73) -> (* Some *)
            let v76 : System.DateTime = System.DateTime.Now
            let v85 : (System.DateTime -> int64) = _.Ticks
            let v86 : int64 = v85 v76
            let v93 : int64 = v86 - v73
            let v96 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v97 : System.TimeSpan = v96 v93
            let v106 : (System.TimeSpan -> int32) = _.Hours
            let v107 : int32 = v106 v97
            let v116 : (System.TimeSpan -> int32) = _.Minutes
            let v117 : int32 = v116 v97
            let v126 : (System.TimeSpan -> int32) = _.Seconds
            let v127 : int32 = v126 v97
            let v136 : (System.TimeSpan -> int32) = _.Milliseconds
            let v137 : int32 = v136 v97
            let v146 : System.DateTime = System.DateTime (1, 1, 1, v107, v117, v127, v137)
            v146
    let v166 : string = method10()
    let v175 : (string -> string) = v163.ToString
    let v176 : string = v175 v166
    v176 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v185 : US2 option = None
    let _v185 = ref v185 
    match v18 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v186 : int64 = x
    let v187 : US2 = US2_0(v186)
    v187 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v185.Value <- x
    let v188 : US2 option = _v185.Value 
    let v211 : US2 = US2_1
    let v212 : US2 = v188 |> Option.defaultValue v211 
    let v310 : System.DateTime =
        match v212 with
        | US2_1 -> (* None *)
            let v302 : System.DateTime = System.DateTime.Now
            v302
        | US2_0(v220) -> (* Some *)
            let v223 : System.DateTime = System.DateTime.Now
            let v232 : (System.DateTime -> int64) = _.Ticks
            let v233 : int64 = v232 v223
            let v240 : int64 = v233 - v220
            let v243 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v244 : System.TimeSpan = v243 v240
            let v253 : (System.TimeSpan -> int32) = _.Hours
            let v254 : int32 = v253 v244
            let v263 : (System.TimeSpan -> int32) = _.Minutes
            let v264 : int32 = v263 v244
            let v273 : (System.TimeSpan -> int32) = _.Seconds
            let v274 : int32 = v273 v244
            let v283 : (System.TimeSpan -> int32) = _.Milliseconds
            let v284 : int32 = v283 v244
            let v293 : System.DateTime = System.DateTime (1, 1, 1, v254, v264, v274, v284)
            v293
    let v313 : string = method10()
    let v322 : (string -> string) = v310.ToString
    let v323 : string = v322 v313
    v323 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v330 : string = $"near_sdk::env::block_timestamp()"
    let v331 : uint64 = Fable.Core.RustInterop.emitRustExpr () v330 
    let v334 : US2 option = None
    let _v334 = ref v334 
    match v18 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v335 : int64 = x
    let v336 : US2 = US2_0(v335)
    v336 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v334.Value <- x
    let v337 : US2 option = _v334.Value 
    let v360 : US2 = US2_1
    let v361 : US2 = v337 |> Option.defaultValue v360 
    let v374 : uint64 =
        match v361 with
        | US2_1 -> (* None *)
            v331
        | US2_0(v369) -> (* Some *)
            let v370 : (int64 -> uint64) = uint64
            let v371 : uint64 = v370 v369
            let v372 : uint64 = v331 - v371
            v372
    let v375 : uint64 = v374 / 1000000000UL
    let v376 : uint64 = v375 % 60UL
    let v377 : uint64 = v375 / 60UL
    let v378 : uint64 = v377 % 60UL
    let v379 : uint64 = v375 / 3600UL
    let v380 : uint64 = v379 % 24UL
    let v381 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
    let v382 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v380, v378, v376) v381 
    let v383 : string = "fable_library_rust::String_::fromString($0)"
    let v384 : string = Fable.Core.RustInterop.emitRustExpr v382 v383 
    v384 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v387 : US2 option = None
    let _v387 = ref v387 
    match v18 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v388 : int64 = x
    let v389 : US2 = US2_0(v388)
    v389 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v387.Value <- x
    let v390 : US2 option = _v387.Value 
    let v413 : US2 = US2_1
    let v414 : US2 = v390 |> Option.defaultValue v413 
    let v512 : System.DateTime =
        match v414 with
        | US2_1 -> (* None *)
            let v504 : System.DateTime = System.DateTime.Now
            v504
        | US2_0(v422) -> (* Some *)
            let v425 : System.DateTime = System.DateTime.Now
            let v434 : (System.DateTime -> int64) = _.Ticks
            let v435 : int64 = v434 v425
            let v442 : int64 = v435 - v422
            let v445 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v446 : System.TimeSpan = v445 v442
            let v455 : (System.TimeSpan -> int32) = _.Hours
            let v456 : int32 = v455 v446
            let v465 : (System.TimeSpan -> int32) = _.Minutes
            let v466 : int32 = v465 v446
            let v475 : (System.TimeSpan -> int32) = _.Seconds
            let v476 : int32 = v475 v446
            let v485 : (System.TimeSpan -> int32) = _.Milliseconds
            let v486 : int32 = v485 v446
            let v495 : System.DateTime = System.DateTime (1, 1, 1, v456, v466, v476, v486)
            v495
    let v515 : string = method11()
    let v524 : (string -> string) = v512.ToString
    let v525 : string = v524 v515
    v525 
    #endif
#if FABLE_COMPILER_PYTHON
    let v534 : US2 option = None
    let _v534 = ref v534 
    match v18 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v535 : int64 = x
    let v536 : US2 = US2_0(v535)
    v536 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v534.Value <- x
    let v537 : US2 option = _v534.Value 
    let v560 : US2 = US2_1
    let v561 : US2 = v537 |> Option.defaultValue v560 
    let v659 : System.DateTime =
        match v561 with
        | US2_1 -> (* None *)
            let v651 : System.DateTime = System.DateTime.Now
            v651
        | US2_0(v569) -> (* Some *)
            let v572 : System.DateTime = System.DateTime.Now
            let v581 : (System.DateTime -> int64) = _.Ticks
            let v582 : int64 = v581 v572
            let v589 : int64 = v582 - v569
            let v592 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v593 : System.TimeSpan = v592 v589
            let v602 : (System.TimeSpan -> int32) = _.Hours
            let v603 : int32 = v602 v593
            let v612 : (System.TimeSpan -> int32) = _.Minutes
            let v613 : int32 = v612 v593
            let v622 : (System.TimeSpan -> int32) = _.Seconds
            let v623 : int32 = v622 v593
            let v632 : (System.TimeSpan -> int32) = _.Milliseconds
            let v633 : int32 = v632 v593
            let v642 : System.DateTime = System.DateTime (1, 1, 1, v603, v613, v623, v633)
            v642
    let v662 : string = method11()
    let v671 : (string -> string) = v659.ToString
    let v672 : string = v671 v662
    v672 
    #endif
#else
    let v681 : US2 option = None
    let _v681 = ref v681 
    match v18 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v682 : int64 = x
    let v683 : US2 = US2_0(v682)
    v683 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v681.Value <- x
    let v684 : US2 option = _v681.Value 
    let v707 : US2 = US2_1
    let v708 : US2 = v684 |> Option.defaultValue v707 
    let v806 : System.DateTime =
        match v708 with
        | US2_1 -> (* None *)
            let v798 : System.DateTime = System.DateTime.Now
            v798
        | US2_0(v716) -> (* Some *)
            let v719 : System.DateTime = System.DateTime.Now
            let v728 : (System.DateTime -> int64) = _.Ticks
            let v729 : int64 = v728 v719
            let v736 : int64 = v729 - v716
            let v739 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v740 : System.TimeSpan = v739 v736
            let v749 : (System.TimeSpan -> int32) = _.Hours
            let v750 : int32 = v749 v740
            let v759 : (System.TimeSpan -> int32) = _.Minutes
            let v760 : int32 = v759 v740
            let v769 : (System.TimeSpan -> int32) = _.Seconds
            let v770 : int32 = v769 v740
            let v779 : (System.TimeSpan -> int32) = _.Milliseconds
            let v780 : int32 = v779 v740
            let v789 : System.DateTime = System.DateTime (1, 1, 1, v750, v760, v770, v780)
            v789
    let v809 : string = method11()
    let v818 : (string -> string) = v806.ToString
    let v819 : string = v818 v809
    v819 
    #endif
    |> fun x -> _v35 <- Some x
    let v826 : string = match _v35 with Some x -> x | None -> failwith "base.run_target / _v35=None"
    let v981 : bool =
        match v0 with
        | US0_0 -> (* Verbose *)
            true
        | _ ->
            false
    let v985 : US3 =
        if v981 then
            let v982 : string = "Verbose"
            US3_0(v982)
        else
            US3_1
    let v1034 : US3 =
        match v985 with
        | US3_1 -> (* None *)
            let v990 : bool =
                match v0 with
                | US0_1 -> (* Debug *)
                    true
                | _ ->
                    false
            let v994 : US3 =
                if v990 then
                    let v991 : string = "Debug"
                    US3_0(v991)
                else
                    US3_1
            match v994 with
            | US3_1 -> (* None *)
                let v999 : bool =
                    match v0 with
                    | US0_2 -> (* Info *)
                        true
                    | _ ->
                        false
                let v1003 : US3 =
                    if v999 then
                        let v1000 : string = "Info"
                        US3_0(v1000)
                    else
                        US3_1
                match v1003 with
                | US3_1 -> (* None *)
                    let v1008 : bool =
                        match v0 with
                        | US0_3 -> (* Warning *)
                            true
                        | _ ->
                            false
                    let v1012 : US3 =
                        if v1008 then
                            let v1009 : string = "Warning"
                            US3_0(v1009)
                        else
                            US3_1
                    match v1012 with
                    | US3_1 -> (* None *)
                        let v1017 : bool =
                            match v0 with
                            | US0_4 -> (* Critical *)
                                true
                            | _ ->
                                false
                        let v1021 : US3 =
                            if v1017 then
                                let v1018 : string = "Critical"
                                US3_0(v1018)
                            else
                                US3_1
                        match v1021 with
                        | US3_1 -> (* None *)
                            US3_1
                        | US3_0(v1022) -> (* Some *)
                            US3_0(v1022)
                    | US3_0(v1013) -> (* Some *)
                        US3_0(v1013)
                | US3_0(v1004) -> (* Some *)
                    US3_0(v1004)
            | US3_0(v995) -> (* Some *)
                US3_0(v995)
        | US3_0(v986) -> (* Some *)
            US3_0(v986)
    let v1038 : string =
        match v1034 with
        | US3_1 -> (* None *)
            failwith<string> "Option does not have a value."
        | US3_0(v1035) -> (* Some *)
            v1035
    let v1041 : (unit -> string) = v1038.ToLower
    let v1042 : string = v1041 ()
    let v1051 : string = v1042.PadLeft (7, ' ')
    let v1083 : bool = true
    let mutable _v1083 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1098 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v1092 : string = "inline_colorization::color_bright_red"
            let v1093 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1092 
            v1093
        | US0_1 -> (* Debug *)
            let v1086 : string = "inline_colorization::color_bright_blue"
            let v1087 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1086 
            v1087
        | US0_2 -> (* Info *)
            let v1088 : string = "inline_colorization::color_bright_green"
            let v1089 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1088 
            v1089
        | US0_0 -> (* Verbose *)
            let v1084 : string = "inline_colorization::color_bright_black"
            let v1085 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1084 
            v1085
        | US0_3 -> (* Warning *)
            let v1090 : string = "inline_colorization::color_yellow"
            let v1091 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1090 
            v1091
    let v1099 : string = "&*$0"
    let v1100 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1051 v1099 
    let v1101 : string = "inline_colorization::color_reset"
    let v1102 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1101 
    let v1103 : string = "\"{v1098}{v1100}{v1102}\""
    let v1104 : string = @$"format!(" + v1103 + ")"
    let v1105 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v1104 
    let v1106 : string = "fable_library_rust::String_::fromString($0)"
    let v1107 : string = Fable.Core.RustInterop.emitRustExpr v1105 v1106 
    v1107 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1122 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v1116 : string = "inline_colorization::color_bright_red"
            let v1117 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1116 
            v1117
        | US0_1 -> (* Debug *)
            let v1110 : string = "inline_colorization::color_bright_blue"
            let v1111 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1110 
            v1111
        | US0_2 -> (* Info *)
            let v1112 : string = "inline_colorization::color_bright_green"
            let v1113 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1112 
            v1113
        | US0_0 -> (* Verbose *)
            let v1108 : string = "inline_colorization::color_bright_black"
            let v1109 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1108 
            v1109
        | US0_3 -> (* Warning *)
            let v1114 : string = "inline_colorization::color_yellow"
            let v1115 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1114 
            v1115
    let v1123 : string = "&*$0"
    let v1124 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1051 v1123 
    let v1125 : string = "inline_colorization::color_reset"
    let v1126 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1125 
    let v1127 : string = "\"{v1122}{v1124}{v1126}\""
    let v1128 : string = @$"format!(" + v1127 + ")"
    let v1129 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v1128 
    let v1130 : string = "fable_library_rust::String_::fromString($0)"
    let v1131 : string = Fable.Core.RustInterop.emitRustExpr v1129 v1130 
    v1131 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1146 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v1140 : string = "inline_colorization::color_bright_red"
            let v1141 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1140 
            v1141
        | US0_1 -> (* Debug *)
            let v1134 : string = "inline_colorization::color_bright_blue"
            let v1135 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1134 
            v1135
        | US0_2 -> (* Info *)
            let v1136 : string = "inline_colorization::color_bright_green"
            let v1137 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1136 
            v1137
        | US0_0 -> (* Verbose *)
            let v1132 : string = "inline_colorization::color_bright_black"
            let v1133 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1132 
            v1133
        | US0_3 -> (* Warning *)
            let v1138 : string = "inline_colorization::color_yellow"
            let v1139 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1138 
            v1139
    let v1147 : string = "&*$0"
    let v1148 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1051 v1147 
    let v1149 : string = "inline_colorization::color_reset"
    let v1150 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1149 
    let v1151 : string = "\"{v1146}{v1148}{v1150}\""
    let v1152 : string = @$"format!(" + v1151 + ")"
    let v1153 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v1152 
    let v1154 : string = "fable_library_rust::String_::fromString($0)"
    let v1155 : string = Fable.Core.RustInterop.emitRustExpr v1153 v1154 
    v1155 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1165 : string =
        match v0 with
        | US0_4 -> (* Critical *)
            let v1160 : string = "\u001b[91m"
            v1160
        | US0_1 -> (* Debug *)
            let v1157 : string = "\u001b[94m"
            v1157
        | US0_2 -> (* Info *)
            let v1158 : string = "\u001b[92m"
            v1158
        | US0_0 -> (* Verbose *)
            let v1156 : string = "\u001b[90m"
            v1156
        | US0_3 -> (* Warning *)
            let v1159 : string = "\u001b[93m"
            v1159
    let v1166 : string = method12()
    let v1167 : string = v1165 + v1051 
    let v1168 : string = v1167 + v1166 
    v1168 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1178 : string =
        match v0 with
        | US0_4 -> (* Critical *)
            let v1173 : string = "\u001b[91m"
            v1173
        | US0_1 -> (* Debug *)
            let v1170 : string = "\u001b[94m"
            v1170
        | US0_2 -> (* Info *)
            let v1171 : string = "\u001b[92m"
            v1171
        | US0_0 -> (* Verbose *)
            let v1169 : string = "\u001b[90m"
            v1169
        | US0_3 -> (* Warning *)
            let v1172 : string = "\u001b[93m"
            v1172
    let v1179 : string = method12()
    let v1180 : string = v1178 + v1051 
    let v1181 : string = v1180 + v1179 
    v1181 
    #endif
#else
    let v1191 : string =
        match v0 with
        | US0_4 -> (* Critical *)
            let v1186 : string = "\u001b[91m"
            v1186
        | US0_1 -> (* Debug *)
            let v1183 : string = "\u001b[94m"
            v1183
        | US0_2 -> (* Info *)
            let v1184 : string = "\u001b[92m"
            v1184
        | US0_0 -> (* Verbose *)
            let v1182 : string = "\u001b[90m"
            v1182
        | US0_3 -> (* Warning *)
            let v1185 : string = "\u001b[93m"
            v1185
    let v1192 : string = method12()
    let v1193 : string = v1191 + v1051 
    let v1194 : string = v1193 + v1192 
    v1194 
    #endif
    |> fun x -> _v1083 <- Some x
    let v1195 : string = match _v1083 with Some x -> x | None -> failwith "base.run_target / _v1083=None"
    let v1214 : int64 = v14.l0
    let struct (v1215 : string, v1216 : int64, v1217 : string) = v2 ()
    let v1218 : string = ""
    let v1219 : Mut4 = {l0 = v1218} : Mut4
    method19(v1219, v1215, v1216, v1217)
    let v1220 : string = v1219.l0
    let v1223 : string = $"{v826} {v1195} #{v1214} %s{v1 ()} / {v1220}"
    let v1230 : char list = []
    let v1235 : (char list -> (char [])) = List.toArray
    let v1236 : (char []) = v1235 v1230
    let v1243 : string = v1223.TrimStart v1236 
    let v1282 : char list = []
    let v1285 : char list = '/' :: v1282 
    let v1294 : char list = ' ' :: v1285 
    let v1305 : (char list -> (char [])) = List.toArray
    let v1306 : (char []) = v1305 v1294
    let v1313 : string = v1243.TrimEnd v1306 
    v1313
and method18 (v0 : US0, v1 : (unit -> string), v2 : (unit -> struct (string * int64 * string))) : unit =
    let v3 : (unit -> string) = closure10(v0, v1, v2)
    method16(v0, v3)
and method17 (v0 : string, v1 : US8, v2 : US7, v3 : int64) : Async<int64> =
    let v6 : bool = true
    let mutable _v6 : Async<int64> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v9 : Async<int64> = null |> unbox<Async<int64>>
    v9 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v18 : Async<int64> = null |> unbox<Async<int64>>
    v18 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v27 : Async<int64> = null |> unbox<Async<int64>>
    v27 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v36 : Async<int64> = null |> unbox<Async<int64>>
    v36 
    #endif
#if FABLE_COMPILER_PYTHON
    let v45 : Async<int64> = null |> unbox<Async<int64>>
    v45 
    #endif
#else
    let v52 : Async<int64> option = None
    let mutable _v52 = v52 
    async {
    try
    let v55 : bool = true
    let mutable _v55 : System.IO.FileStream option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v58 : System.IO.FileStream = null |> unbox<System.IO.FileStream>
    v58 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v67 : System.IO.FileStream = null |> unbox<System.IO.FileStream>
    v67 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v76 : System.IO.FileStream = null |> unbox<System.IO.FileStream>
    v76 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v85 : System.IO.FileStream = null |> unbox<System.IO.FileStream>
    v85 
    #endif
#if FABLE_COMPILER_PYTHON
    let v94 : System.IO.FileStream = null |> unbox<System.IO.FileStream>
    v94 
    #endif
#else
    let v101 : System.IO.FileMode = System.IO.FileMode.Open
    let v107 : System.IO.FileAccess =
        match v2 with
        | US7_0 -> (* AccessRead *)
            let v102 : System.IO.FileAccess = System.IO.FileAccess.Read
            v102
        | US7_2 -> (* AccessReadWrite *)
            let v104 : System.IO.FileAccess = System.IO.FileAccess.ReadWrite
            v104
        | US7_1 -> (* AccessWrite *)
            let v103 : System.IO.FileAccess = System.IO.FileAccess.ReadWrite
            v103
    let v117 : System.IO.FileShare =
        match v1 with
        | US8_4 -> (* ShareDelete *)
            let v112 : System.IO.FileShare = System.IO.FileShare.Delete
            v112
        | US8_0 -> (* ShareNone *)
            let v108 : System.IO.FileShare = System.IO.FileShare.None
            v108
        | US8_1 -> (* ShareRead *)
            let v109 : System.IO.FileShare = System.IO.FileShare.Read
            v109
        | US8_3 -> (* ShareReadWrite *)
            let v111 : System.IO.FileShare = System.IO.FileShare.ReadWrite
            v111
        | US8_2 -> (* ShareWrite *)
            let v110 : System.IO.FileShare = System.IO.FileShare.Write
            v110
    let v118 : System.IO.FileStream = new System.IO.FileStream (v0, v101, v107, v117)
    v118 
    #endif
    |> fun x -> _v55 <- Some x
    let v119 : System.IO.FileStream = match _v55 with Some x -> x | None -> failwith "base.run_target / _v55=None"
    use v119 = v119 
    let v134 : System.IO.FileStream = v119 
    return v3 
    with ex ->
    let v135 : exn = ex
    let v136 : bool = v3 > 0L
    let v139 : bool =
        if v136 then
            let v137 : int64 = v3 % 100L
            let v138 : bool = v137 = 0L
            v138
        else
            false
    if v139 then
        let v142 : bool = true
        let mutable _v142 : string option = None 
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v145 : string = $"%A{v135}"
        v145 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v154 : string = $"%A{v135}"
        v154 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v163 : string = $"%A{v135}"
        v163 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v172 : string = $"%A{v135}"
        v172 
        #endif
#if FABLE_COMPILER_PYTHON
        let v181 : string = $"%A{v135}"
        v181 
        #endif
#else
        let v188 : string = $"{v135.GetType ()}: {v135.Message}"
        v188 
        #endif
        |> fun x -> _v142 <- Some x
        let v189 : string = match _v142 with Some x -> x | None -> failwith "base.run_target / _v142=None"
        let v204 : US0 = US0_1
        let v205 : (unit -> string) = closure8()
        let v206 : (unit -> struct (string * int64 * string)) = closure9(v0, v3, v189)
        method18(v204, v205, v206)
    let v209 : bool = true
    let mutable _v209 : Async<unit> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v212 : Async<unit> = null |> unbox<Async<unit>>
    v212 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v221 : Async<unit> = null |> unbox<Async<unit>>
    v221 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v230 : Async<unit> = null |> unbox<Async<unit>>
    v230 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v239 : Async<unit> = null |> unbox<Async<unit>>
    v239 
    #endif
#if FABLE_COMPILER_PYTHON
    let v248 : Async<unit> = null |> unbox<Async<unit>>
    v248 
    #endif
#else
    let v255 : (int32 -> Async<unit>) = Async.Sleep
    let v256 : Async<unit> = v255 10
    v256 
    #endif
    |> fun x -> _v209 <- Some x
    let v257 : Async<unit> = match _v209 with Some x -> x | None -> failwith "base.run_target / _v209=None"
    do! v257 
    let v272 : int64 = v3 + 1L
    let v273 : Async<int64> = method17(v0, v1, v2, v272)
    return! v273 
    (*
    let v274 : int64 = *)
    }
    |> fun x -> _v52 <- Some x
    let v275 : Async<int64> = match _v52 with Some x -> x | None -> failwith "async.new_async_unit / _v52=None"
    v275 
    #endif
    |> fun x -> _v6 <- Some x
    let v276 : Async<int64> = match _v6 with Some x -> x | None -> failwith "base.run_target / _v6=None"
    v276
and closure7 (v0 : US6) (v1 : string) : Async<int64> =
    let v4 : bool = true
    let mutable _v4 : Async<int64> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v7 : Async<int64> = null |> unbox<Async<int64>>
    v7 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v16 : Async<int64> = null |> unbox<Async<int64>>
    v16 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v25 : Async<int64> = null |> unbox<Async<int64>>
    v25 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v34 : Async<int64> = null |> unbox<Async<int64>>
    v34 
    #endif
#if FABLE_COMPILER_PYTHON
    let v43 : Async<int64> = null |> unbox<Async<int64>>
    v43 
    #endif
#else
    let struct (v56 : US7, v57 : US8) =
        match v0 with
        | US6_1 -> (* None *)
            let v52 : US7 = US7_2
            let v53 : US8 = US8_1
            struct (v52, v53)
        | US6_0(v50, v51) -> (* Some *)
            struct (v50, v51)
    let v58 : int64 = 0L
    let v59 : Async<int64> = method17(v1, v57, v56, v58)
    v59 
    #endif
    |> fun x -> _v4 <- Some x
    let v60 : Async<int64> = match _v4 with Some x -> x | None -> failwith "base.run_target / _v4=None"
    v60
and closure6 () (v0 : US6) : (string -> Async<int64>) =
    closure7(v0)
and method21 (v0 : string, v1 : int64) : Async<int64> =
    let v4 : bool = true
    let mutable _v4 : Async<int64> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v7 : Async<int64> = null |> unbox<Async<int64>>
    v7 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v16 : Async<int64> = null |> unbox<Async<int64>>
    v16 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v25 : Async<int64> = null |> unbox<Async<int64>>
    v25 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v34 : Async<int64> = null |> unbox<Async<int64>>
    v34 
    #endif
#if FABLE_COMPILER_PYTHON
    let v43 : Async<int64> = null |> unbox<Async<int64>>
    v43 
    #endif
#else
    let v50 : Async<int64> option = None
    let mutable _v50 = v50 
    async {
    try
    let v53 : bool = true
    let mutable _v53 : System.IO.FileStream option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v56 : System.IO.FileStream = null |> unbox<System.IO.FileStream>
    v56 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v65 : System.IO.FileStream = null |> unbox<System.IO.FileStream>
    v65 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v74 : System.IO.FileStream = null |> unbox<System.IO.FileStream>
    v74 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v83 : System.IO.FileStream = null |> unbox<System.IO.FileStream>
    v83 
    #endif
#if FABLE_COMPILER_PYTHON
    let v92 : System.IO.FileStream = null |> unbox<System.IO.FileStream>
    v92 
    #endif
#else
    let v99 : System.IO.FileMode = System.IO.FileMode.Open
    let v100 : System.IO.FileAccess = System.IO.FileAccess.Read
    let v101 : System.IO.FileShare = System.IO.FileShare.Read
    let v102 : System.IO.FileStream = new System.IO.FileStream (v0, v99, v100, v101)
    v102 
    #endif
    |> fun x -> _v53 <- Some x
    let v103 : System.IO.FileStream = match _v53 with Some x -> x | None -> failwith "base.run_target / _v53=None"
    use v103 = v103 
    let v118 : System.IO.FileStream = v103 
    return v1 
    with ex ->
    let v119 : exn = ex
    let v120 : bool = v1 > 0L
    let v123 : bool =
        if v120 then
            let v121 : int64 = v1 % 100L
            let v122 : bool = v121 = 0L
            v122
        else
            false
    if v123 then
        let v126 : bool = true
        let mutable _v126 : string option = None 
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v129 : string = $"%A{v119}"
        v129 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v138 : string = $"%A{v119}"
        v138 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v147 : string = $"%A{v119}"
        v147 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v156 : string = $"%A{v119}"
        v156 
        #endif
#if FABLE_COMPILER_PYTHON
        let v165 : string = $"%A{v119}"
        v165 
        #endif
#else
        let v172 : string = $"{v119.GetType ()}: {v119.Message}"
        v172 
        #endif
        |> fun x -> _v126 <- Some x
        let v173 : string = match _v126 with Some x -> x | None -> failwith "base.run_target / _v126=None"
        let v188 : US0 = US0_1
        let v189 : (unit -> string) = closure8()
        let v190 : (unit -> struct (string * int64 * string)) = closure9(v0, v1, v173)
        method18(v188, v189, v190)
    let v193 : bool = true
    let mutable _v193 : Async<unit> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v196 : Async<unit> = null |> unbox<Async<unit>>
    v196 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v205 : Async<unit> = null |> unbox<Async<unit>>
    v205 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v214 : Async<unit> = null |> unbox<Async<unit>>
    v214 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v223 : Async<unit> = null |> unbox<Async<unit>>
    v223 
    #endif
#if FABLE_COMPILER_PYTHON
    let v232 : Async<unit> = null |> unbox<Async<unit>>
    v232 
    #endif
#else
    let v239 : (int32 -> Async<unit>) = Async.Sleep
    let v240 : Async<unit> = v239 10
    v240 
    #endif
    |> fun x -> _v193 <- Some x
    let v241 : Async<unit> = match _v193 with Some x -> x | None -> failwith "base.run_target / _v193=None"
    do! v241 
    let v256 : int64 = v1 + 1L
    let v257 : Async<int64> = method21(v0, v256)
    return! v257 
    (*
    let v258 : int64 = *)
    }
    |> fun x -> _v50 <- Some x
    let v259 : Async<int64> = match _v50 with Some x -> x | None -> failwith "async.new_async_unit / _v50=None"
    v259 
    #endif
    |> fun x -> _v4 <- Some x
    let v260 : Async<int64> = match _v4 with Some x -> x | None -> failwith "base.run_target / _v4=None"
    v260
and closure11 () (v0 : string) : Async<int64> =
    let v3 : bool = true
    let mutable _v3 : Async<int64> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v6 : Async<int64> = null |> unbox<Async<int64>>
    v6 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v15 : Async<int64> = null |> unbox<Async<int64>>
    v15 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v24 : Async<int64> = null |> unbox<Async<int64>>
    v24 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v33 : Async<int64> = null |> unbox<Async<int64>>
    v33 
    #endif
#if FABLE_COMPILER_PYTHON
    let v42 : Async<int64> = null |> unbox<Async<int64>>
    v42 
    #endif
#else
    let v49 : int64 = 0L
    let v50 : Async<int64> = method21(v0, v49)
    v50 
    #endif
    |> fun x -> _v3 <- Some x
    let v51 : Async<int64> = match _v3 with Some x -> x | None -> failwith "base.run_target / _v3=None"
    v51
and closure12 () (v0 : string) : Async<string> =
    let v3 : bool = true
    let mutable _v3 : Async<string> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v6 : Async<string> = null |> unbox<Async<string>>
    v6 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v15 : Async<string> = null |> unbox<Async<string>>
    v15 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v24 : Async<string> = null |> unbox<Async<string>>
    v24 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v33 : Async<string> = null |> unbox<Async<string>>
    v33 
    #endif
#if FABLE_COMPILER_PYTHON
    let v42 : Async<string> = null |> unbox<Async<string>>
    v42 
    #endif
#else
    let v49 : (string -> System.Threading.Tasks.Task<string>) = System.IO.File.ReadAllTextAsync
    let v50 : System.Threading.Tasks.Task<string> = v49 v0
    let v53 : bool = true
    let mutable _v53 : Async<string> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v56 : Async<string> = null |> unbox<Async<string>>
    v56 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v65 : Async<string> = null |> unbox<Async<string>>
    v65 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v74 : Async<string> = null |> unbox<Async<string>>
    v74 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v83 : Async<string> = null |> unbox<Async<string>>
    v83 
    #endif
#if FABLE_COMPILER_PYTHON
    let v92 : Async<string> = null |> unbox<Async<string>>
    v92 
    #endif
#else
    let v99 : (System.Threading.Tasks.Task<string> -> Async<string>) = Async.AwaitTask
    let v100 : Async<string> = v99 v50
    v100 
    #endif
    |> fun x -> _v53 <- Some x
    let v101 : Async<string> = match _v53 with Some x -> x | None -> failwith "base.run_target / _v53=None"
    v101 
    #endif
    |> fun x -> _v3 <- Some x
    let v116 : Async<string> = match _v3 with Some x -> x | None -> failwith "base.run_target / _v3=None"
    v116
and method23 (v0 : string) : bool =
    let v3 : bool = true
    let mutable _v3 : bool option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v4 : string = "&*$0"
    let v5 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v4 
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
    let v17 : bool = null |> unbox<bool>
    v17 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v26 : bool = null |> unbox<bool>
    v26 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v33 : string = "fs"
    let v34 : IFsExistsSync = Fable.Core.JsInterop.importAll v33 
    let v35 : string = "$0.existsSync($1)"
    let v36 : bool = Fable.Core.JsInterop.emitJsExpr struct (v34, v0) v35 
    v36 
    #endif
#if FABLE_COMPILER_PYTHON
    let v39 : bool = null |> unbox<bool>
    v39 
    #endif
#else
    let v46 : (string -> bool) = System.IO.File.Exists
    let v47 : bool = v46 v0
    v47 
    #endif
    |> fun x -> _v3 <- Some x
    let v48 : bool = match _v3 with Some x -> x | None -> failwith "base.run_target / _v3=None"
    v48
and method24 (v0 : Vec<uint8>) : Vec<uint8> =
    v0
and method22 (v0 : string, v1 : string) : bool =
    let v4 : bool = true
    let mutable _v4 : bool option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v5 : bool = method23(v0)
    let v6 : bool = v5 = false
    let v129 : bool =
        if v6 then
            false
        else
            let v9 : bool = true
            let mutable _v9 : string option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v12 : bool = true
            let mutable _v12 : Vec<uint8> option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v13 : string = "std::fs::read(&*$0).unwrap()"
            let v14 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v0 v13 
            v14 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v17 : Vec<uint8> = null |> unbox<Vec<uint8>>
            v17 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v26 : Vec<uint8> = null |> unbox<Vec<uint8>>
            v26 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v35 : Vec<uint8> = null |> unbox<Vec<uint8>>
            v35 
            #endif
#if FABLE_COMPILER_PYTHON
            let v44 : Vec<uint8> = null |> unbox<Vec<uint8>>
            v44 
            #endif
#else
            let v51 : (uint8 []) = v0 |> System.IO.File.ReadAllBytes
            let v52 : string = "$0.to_vec()"
            let v53 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v51 v52 
            v53 
            #endif
            |> fun x -> _v12 <- Some x
            let v54 : Vec<uint8> = match _v12 with Some x -> x | None -> failwith "base.run_target / _v12=None"
            let v69 : Vec<uint8> = method24(v54)
            let v70 : string = "std::string::String::from_utf8($0)"
            let v71 : Result<std_string_String, std_string_FromUtf8Error> = Fable.Core.RustInterop.emitRustExpr v69 v70 
            let v72 : string = "$0.unwrap()"
            let v73 : std_string_String = Fable.Core.RustInterop.emitRustExpr v71 v72 
            let v74 : string = "fable_library_rust::String_::fromString($0)"
            let v75 : string = Fable.Core.RustInterop.emitRustExpr v73 v74 
            v75 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v78 : string = null |> unbox<string>
            v78 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v87 : string = null |> unbox<string>
            v87 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v96 : string = null |> unbox<string>
            v96 
            #endif
#if FABLE_COMPILER_PYTHON
            let v105 : string = null |> unbox<string>
            v105 
            #endif
#else
            let v112 : string = v0 |> System.IO.File.ReadAllText
            v112 
            #endif
            |> fun x -> _v9 <- Some x
            let v113 : string = match _v9 with Some x -> x | None -> failwith "base.run_target / _v9=None"
            let v128 : bool = v1 = v113
            v128
    v129 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v132 : bool = null |> unbox<bool>
    v132 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v141 : bool = null |> unbox<bool>
    v141 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v150 : bool = null |> unbox<bool>
    v150 
    #endif
#if FABLE_COMPILER_PYTHON
    let v159 : bool = null |> unbox<bool>
    v159 
    #endif
#else
    let v168 : bool = null |> unbox<bool>
    v168 
    #endif
    |> fun x -> _v4 <- Some x
    let v175 : bool = match _v4 with Some x -> x | None -> failwith "base.run_target / _v4=None"
    v175
and closure14 (v0 : string) (v1 : string) : bool =
    method22(v0, v1)
and closure13 () (v0 : string) : (string -> bool) =
    closure14(v0)
and closure16 (v0 : string) (v1 : string) : Async<unit> =
    let v4 : bool = true
    let mutable _v4 : Async<unit> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v7 : Async<unit> = null |> unbox<Async<unit>>
    v7 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v16 : Async<unit> = null |> unbox<Async<unit>>
    v16 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v25 : Async<unit> = null |> unbox<Async<unit>>
    v25 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v34 : Async<unit> = null |> unbox<Async<unit>>
    v34 
    #endif
#if FABLE_COMPILER_PYTHON
    let v43 : Async<unit> = null |> unbox<Async<unit>>
    v43 
    #endif
#else
    let v50 : System.Threading.Tasks.Task = System.IO.File.WriteAllTextAsync (v0, v1)
    let v53 : bool = true
    let mutable _v53 : Async<unit> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v56 : Async<unit> = null |> unbox<Async<unit>>
    v56 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v65 : Async<unit> = null |> unbox<Async<unit>>
    v65 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v74 : Async<unit> = null |> unbox<Async<unit>>
    v74 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v83 : Async<unit> = null |> unbox<Async<unit>>
    v83 
    #endif
#if FABLE_COMPILER_PYTHON
    let v92 : Async<unit> = null |> unbox<Async<unit>>
    v92 
    #endif
#else
    let v99 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
    let v100 : Async<unit> = v99 v50
    v100 
    #endif
    |> fun x -> _v53 <- Some x
    let v101 : Async<unit> = match _v53 with Some x -> x | None -> failwith "base.run_target / _v53=None"
    v101 
    #endif
    |> fun x -> _v4 <- Some x
    let v116 : Async<unit> = match _v4 with Some x -> x | None -> failwith "base.run_target / _v4=None"
    v116
and closure15 () (v0 : string) : (string -> Async<unit>) =
    closure16(v0)
and closure18 (v0 : string) (v1 : string) : Async<unit> =
    let v4 : bool = true
    let mutable _v4 : Async<unit> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v7 : Async<unit> = null |> unbox<Async<unit>>
    v7 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v16 : Async<unit> = null |> unbox<Async<unit>>
    v16 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v25 : Async<unit> = null |> unbox<Async<unit>>
    v25 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v34 : Async<unit> = null |> unbox<Async<unit>>
    v34 
    #endif
#if FABLE_COMPILER_PYTHON
    let v43 : Async<unit> = null |> unbox<Async<unit>>
    v43 
    #endif
#else
    let v50 : Async<unit> option = None
    let mutable _v50 = v50 
    async {
    let v53 : bool = true
    let mutable _v53 : Async<bool> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v56 : Async<bool> = null |> unbox<Async<bool>>
    v56 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v65 : Async<bool> = null |> unbox<Async<bool>>
    v65 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v74 : Async<bool> = null |> unbox<Async<bool>>
    v74 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v83 : Async<bool> = null |> unbox<Async<bool>>
    v83 
    #endif
#if FABLE_COMPILER_PYTHON
    let v92 : Async<bool> = null |> unbox<Async<bool>>
    v92 
    #endif
#else
    let v101 : bool = true
    let mutable _v101 : Async<bool> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v104 : Async<bool> = null |> unbox<Async<bool>>
    v104 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v113 : Async<bool> = null |> unbox<Async<bool>>
    v113 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v122 : Async<bool> = null |> unbox<Async<bool>>
    v122 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v131 : Async<bool> = null |> unbox<Async<bool>>
    v131 
    #endif
#if FABLE_COMPILER_PYTHON
    let v140 : Async<bool> = null |> unbox<Async<bool>>
    v140 
    #endif
#else
    let v147 : Async<bool> option = None
    let mutable _v147 = v147 
    async {
    let v148 : bool = method23(v0)
    let v149 : bool = v148 = false
    if v149 then
        return false 
        (*
        ()
    else
        *) else
        let v152 : bool = true
        let mutable _v152 : Async<string> option = None 
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v155 : Async<string> = null |> unbox<Async<string>>
        v155 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v164 : Async<string> = null |> unbox<Async<string>>
        v164 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v173 : Async<string> = null |> unbox<Async<string>>
        v173 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v182 : Async<string> = null |> unbox<Async<string>>
        v182 
        #endif
#if FABLE_COMPILER_PYTHON
        let v191 : Async<string> = null |> unbox<Async<string>>
        v191 
        #endif
#else
        let v198 : (string -> System.Threading.Tasks.Task<string>) = System.IO.File.ReadAllTextAsync
        let v199 : System.Threading.Tasks.Task<string> = v198 v0
        let v202 : bool = true
        let mutable _v202 : Async<string> option = None 
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v205 : Async<string> = null |> unbox<Async<string>>
        v205 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v214 : Async<string> = null |> unbox<Async<string>>
        v214 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v223 : Async<string> = null |> unbox<Async<string>>
        v223 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v232 : Async<string> = null |> unbox<Async<string>>
        v232 
        #endif
#if FABLE_COMPILER_PYTHON
        let v241 : Async<string> = null |> unbox<Async<string>>
        v241 
        #endif
#else
        let v248 : (System.Threading.Tasks.Task<string> -> Async<string>) = Async.AwaitTask
        let v249 : Async<string> = v248 v199
        v249 
        #endif
        |> fun x -> _v202 <- Some x
        let v250 : Async<string> = match _v202 with Some x -> x | None -> failwith "base.run_target / _v202=None"
        v250 
        #endif
        |> fun x -> _v152 <- Some x
        let v265 : Async<string> = match _v152 with Some x -> x | None -> failwith "base.run_target / _v152=None"
        let! v265 = v265 
        let v280 : string = v265 
        let v281 : bool = v1 = v280
        return v281 
        (*
        ()
    *)
    }
    |> fun x -> _v147 <- Some x
    let v282 : Async<bool> = match _v147 with Some x -> x | None -> failwith "async.new_async_unit / _v147=None"
    v282 
    #endif
    |> fun x -> _v101 <- Some x
    let v283 : Async<bool> = match _v101 with Some x -> x | None -> failwith "base.run_target / _v101=None"
    v283 
    #endif
    |> fun x -> _v53 <- Some x
    let v298 : Async<bool> = match _v53 with Some x -> x | None -> failwith "base.run_target / _v53=None"
    let! v298 = v298 
    let v313 : bool = v298 
    let v314 : bool = v313 = false
    if v314 then
        let v317 : bool = true
        let mutable _v317 : Async<unit> option = None 
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v320 : Async<unit> = null |> unbox<Async<unit>>
        v320 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v329 : Async<unit> = null |> unbox<Async<unit>>
        v329 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v338 : Async<unit> = null |> unbox<Async<unit>>
        v338 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v347 : Async<unit> = null |> unbox<Async<unit>>
        v347 
        #endif
#if FABLE_COMPILER_PYTHON
        let v356 : Async<unit> = null |> unbox<Async<unit>>
        v356 
        #endif
#else
        let v363 : System.Threading.Tasks.Task = System.IO.File.WriteAllTextAsync (v0, v1)
        let v366 : bool = true
        let mutable _v366 : Async<unit> option = None 
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v369 : Async<unit> = null |> unbox<Async<unit>>
        v369 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v378 : Async<unit> = null |> unbox<Async<unit>>
        v378 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v387 : Async<unit> = null |> unbox<Async<unit>>
        v387 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v396 : Async<unit> = null |> unbox<Async<unit>>
        v396 
        #endif
#if FABLE_COMPILER_PYTHON
        let v405 : Async<unit> = null |> unbox<Async<unit>>
        v405 
        #endif
#else
        let v412 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
        let v413 : Async<unit> = v412 v363
        v413 
        #endif
        |> fun x -> _v366 <- Some x
        let v414 : Async<unit> = match _v366 with Some x -> x | None -> failwith "base.run_target / _v366=None"
        v414 
        #endif
        |> fun x -> _v317 <- Some x
        let v429 : Async<unit> = match _v317 with Some x -> x | None -> failwith "base.run_target / _v317=None"
        do! v429 
        ()
    }
    |> fun x -> _v50 <- Some x
    let v444 : Async<unit> = match _v50 with Some x -> x | None -> failwith "async.new_async_unit / _v50=None"
    v444 
    #endif
    |> fun x -> _v4 <- Some x
    let v445 : Async<unit> = match _v4 with Some x -> x | None -> failwith "base.run_target / _v4=None"
    v445
and closure17 () (v0 : string) : (string -> Async<unit>) =
    closure18(v0)
and closure20 () () : string =
    let v0 : string = "delete_file_async"
    v0
and closure21 (v0 : string, v1 : exn) () : struct (string * string) =
    let v2 : string = method8(v0)
    let v5 : bool = true
    let mutable _v5 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v8 : string = $"%A{v1}"
    v8 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v17 : string = $"%A{v1}"
    v17 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v26 : string = $"%A{v1}"
    v26 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v35 : string = $"%A{v1}"
    v35 
    #endif
#if FABLE_COMPILER_PYTHON
    let v44 : string = $"%A{v1}"
    v44 
    #endif
#else
    let v51 : string = $"{v1.GetType ()}: {v1.Message}"
    v51 
    #endif
    |> fun x -> _v5 <- Some x
    let v52 : string = match _v5 with Some x -> x | None -> failwith "base.run_target / _v5=None"
    struct (v2, v52)
and method27 (v0 : Mut4, v1 : string, v2 : string) : unit =
    let v3 : string = "{ "
    method14(v0, v3)
    method15(v0)
    let v4 : string = "path"
    method14(v0, v4)
    let v5 : string = " = "
    method14(v0, v5)
    method14(v0, v1)
    let v6 : string = "; "
    method14(v0, v6)
    let v7 : string = "ex"
    method14(v0, v7)
    method14(v0, v5)
    method14(v0, v2)
    let v8 : string = " }"
    method14(v0, v8)
and closure22 (v0 : US0, v1 : (unit -> string), v2 : (unit -> struct (string * string))) () : string =
    let v5 : (US0 -> struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option)) = closure0()
    let v6 : US0 = US0_0
    if State.trace_state.IsNone then State.trace_state <- v5 v6 |> Some
    let struct (v14 : Mut0, v15 : Mut1, v16 : Mut2, v17 : Mut3, v18 : int64 option) = State.trace_state.Value
    let v35 : bool = true
    let mutable _v35 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v38 : US2 option = None
    let _v38 = ref v38 
    match v18 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v39 : int64 = x
    let v40 : US2 = US2_0(v39)
    v40 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v38.Value <- x
    let v41 : US2 option = _v38.Value 
    let v64 : US2 = US2_1
    let v65 : US2 = v41 |> Option.defaultValue v64 
    let v163 : System.DateTime =
        match v65 with
        | US2_1 -> (* None *)
            let v155 : System.DateTime = System.DateTime.Now
            v155
        | US2_0(v73) -> (* Some *)
            let v76 : System.DateTime = System.DateTime.Now
            let v85 : (System.DateTime -> int64) = _.Ticks
            let v86 : int64 = v85 v76
            let v93 : int64 = v86 - v73
            let v96 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v97 : System.TimeSpan = v96 v93
            let v106 : (System.TimeSpan -> int32) = _.Hours
            let v107 : int32 = v106 v97
            let v116 : (System.TimeSpan -> int32) = _.Minutes
            let v117 : int32 = v116 v97
            let v126 : (System.TimeSpan -> int32) = _.Seconds
            let v127 : int32 = v126 v97
            let v136 : (System.TimeSpan -> int32) = _.Milliseconds
            let v137 : int32 = v136 v97
            let v146 : System.DateTime = System.DateTime (1, 1, 1, v107, v117, v127, v137)
            v146
    let v166 : string = method10()
    let v175 : (string -> string) = v163.ToString
    let v176 : string = v175 v166
    v176 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v185 : US2 option = None
    let _v185 = ref v185 
    match v18 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v186 : int64 = x
    let v187 : US2 = US2_0(v186)
    v187 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v185.Value <- x
    let v188 : US2 option = _v185.Value 
    let v211 : US2 = US2_1
    let v212 : US2 = v188 |> Option.defaultValue v211 
    let v310 : System.DateTime =
        match v212 with
        | US2_1 -> (* None *)
            let v302 : System.DateTime = System.DateTime.Now
            v302
        | US2_0(v220) -> (* Some *)
            let v223 : System.DateTime = System.DateTime.Now
            let v232 : (System.DateTime -> int64) = _.Ticks
            let v233 : int64 = v232 v223
            let v240 : int64 = v233 - v220
            let v243 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v244 : System.TimeSpan = v243 v240
            let v253 : (System.TimeSpan -> int32) = _.Hours
            let v254 : int32 = v253 v244
            let v263 : (System.TimeSpan -> int32) = _.Minutes
            let v264 : int32 = v263 v244
            let v273 : (System.TimeSpan -> int32) = _.Seconds
            let v274 : int32 = v273 v244
            let v283 : (System.TimeSpan -> int32) = _.Milliseconds
            let v284 : int32 = v283 v244
            let v293 : System.DateTime = System.DateTime (1, 1, 1, v254, v264, v274, v284)
            v293
    let v313 : string = method10()
    let v322 : (string -> string) = v310.ToString
    let v323 : string = v322 v313
    v323 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v330 : string = $"near_sdk::env::block_timestamp()"
    let v331 : uint64 = Fable.Core.RustInterop.emitRustExpr () v330 
    let v334 : US2 option = None
    let _v334 = ref v334 
    match v18 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v335 : int64 = x
    let v336 : US2 = US2_0(v335)
    v336 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v334.Value <- x
    let v337 : US2 option = _v334.Value 
    let v360 : US2 = US2_1
    let v361 : US2 = v337 |> Option.defaultValue v360 
    let v374 : uint64 =
        match v361 with
        | US2_1 -> (* None *)
            v331
        | US2_0(v369) -> (* Some *)
            let v370 : (int64 -> uint64) = uint64
            let v371 : uint64 = v370 v369
            let v372 : uint64 = v331 - v371
            v372
    let v375 : uint64 = v374 / 1000000000UL
    let v376 : uint64 = v375 % 60UL
    let v377 : uint64 = v375 / 60UL
    let v378 : uint64 = v377 % 60UL
    let v379 : uint64 = v375 / 3600UL
    let v380 : uint64 = v379 % 24UL
    let v381 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
    let v382 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v380, v378, v376) v381 
    let v383 : string = "fable_library_rust::String_::fromString($0)"
    let v384 : string = Fable.Core.RustInterop.emitRustExpr v382 v383 
    v384 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v387 : US2 option = None
    let _v387 = ref v387 
    match v18 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v388 : int64 = x
    let v389 : US2 = US2_0(v388)
    v389 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v387.Value <- x
    let v390 : US2 option = _v387.Value 
    let v413 : US2 = US2_1
    let v414 : US2 = v390 |> Option.defaultValue v413 
    let v512 : System.DateTime =
        match v414 with
        | US2_1 -> (* None *)
            let v504 : System.DateTime = System.DateTime.Now
            v504
        | US2_0(v422) -> (* Some *)
            let v425 : System.DateTime = System.DateTime.Now
            let v434 : (System.DateTime -> int64) = _.Ticks
            let v435 : int64 = v434 v425
            let v442 : int64 = v435 - v422
            let v445 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v446 : System.TimeSpan = v445 v442
            let v455 : (System.TimeSpan -> int32) = _.Hours
            let v456 : int32 = v455 v446
            let v465 : (System.TimeSpan -> int32) = _.Minutes
            let v466 : int32 = v465 v446
            let v475 : (System.TimeSpan -> int32) = _.Seconds
            let v476 : int32 = v475 v446
            let v485 : (System.TimeSpan -> int32) = _.Milliseconds
            let v486 : int32 = v485 v446
            let v495 : System.DateTime = System.DateTime (1, 1, 1, v456, v466, v476, v486)
            v495
    let v515 : string = method11()
    let v524 : (string -> string) = v512.ToString
    let v525 : string = v524 v515
    v525 
    #endif
#if FABLE_COMPILER_PYTHON
    let v534 : US2 option = None
    let _v534 = ref v534 
    match v18 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v535 : int64 = x
    let v536 : US2 = US2_0(v535)
    v536 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v534.Value <- x
    let v537 : US2 option = _v534.Value 
    let v560 : US2 = US2_1
    let v561 : US2 = v537 |> Option.defaultValue v560 
    let v659 : System.DateTime =
        match v561 with
        | US2_1 -> (* None *)
            let v651 : System.DateTime = System.DateTime.Now
            v651
        | US2_0(v569) -> (* Some *)
            let v572 : System.DateTime = System.DateTime.Now
            let v581 : (System.DateTime -> int64) = _.Ticks
            let v582 : int64 = v581 v572
            let v589 : int64 = v582 - v569
            let v592 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v593 : System.TimeSpan = v592 v589
            let v602 : (System.TimeSpan -> int32) = _.Hours
            let v603 : int32 = v602 v593
            let v612 : (System.TimeSpan -> int32) = _.Minutes
            let v613 : int32 = v612 v593
            let v622 : (System.TimeSpan -> int32) = _.Seconds
            let v623 : int32 = v622 v593
            let v632 : (System.TimeSpan -> int32) = _.Milliseconds
            let v633 : int32 = v632 v593
            let v642 : System.DateTime = System.DateTime (1, 1, 1, v603, v613, v623, v633)
            v642
    let v662 : string = method11()
    let v671 : (string -> string) = v659.ToString
    let v672 : string = v671 v662
    v672 
    #endif
#else
    let v681 : US2 option = None
    let _v681 = ref v681 
    match v18 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v682 : int64 = x
    let v683 : US2 = US2_0(v682)
    v683 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v681.Value <- x
    let v684 : US2 option = _v681.Value 
    let v707 : US2 = US2_1
    let v708 : US2 = v684 |> Option.defaultValue v707 
    let v806 : System.DateTime =
        match v708 with
        | US2_1 -> (* None *)
            let v798 : System.DateTime = System.DateTime.Now
            v798
        | US2_0(v716) -> (* Some *)
            let v719 : System.DateTime = System.DateTime.Now
            let v728 : (System.DateTime -> int64) = _.Ticks
            let v729 : int64 = v728 v719
            let v736 : int64 = v729 - v716
            let v739 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v740 : System.TimeSpan = v739 v736
            let v749 : (System.TimeSpan -> int32) = _.Hours
            let v750 : int32 = v749 v740
            let v759 : (System.TimeSpan -> int32) = _.Minutes
            let v760 : int32 = v759 v740
            let v769 : (System.TimeSpan -> int32) = _.Seconds
            let v770 : int32 = v769 v740
            let v779 : (System.TimeSpan -> int32) = _.Milliseconds
            let v780 : int32 = v779 v740
            let v789 : System.DateTime = System.DateTime (1, 1, 1, v750, v760, v770, v780)
            v789
    let v809 : string = method11()
    let v818 : (string -> string) = v806.ToString
    let v819 : string = v818 v809
    v819 
    #endif
    |> fun x -> _v35 <- Some x
    let v826 : string = match _v35 with Some x -> x | None -> failwith "base.run_target / _v35=None"
    let v981 : bool =
        match v0 with
        | US0_0 -> (* Verbose *)
            true
        | _ ->
            false
    let v985 : US3 =
        if v981 then
            let v982 : string = "Verbose"
            US3_0(v982)
        else
            US3_1
    let v1034 : US3 =
        match v985 with
        | US3_1 -> (* None *)
            let v990 : bool =
                match v0 with
                | US0_1 -> (* Debug *)
                    true
                | _ ->
                    false
            let v994 : US3 =
                if v990 then
                    let v991 : string = "Debug"
                    US3_0(v991)
                else
                    US3_1
            match v994 with
            | US3_1 -> (* None *)
                let v999 : bool =
                    match v0 with
                    | US0_2 -> (* Info *)
                        true
                    | _ ->
                        false
                let v1003 : US3 =
                    if v999 then
                        let v1000 : string = "Info"
                        US3_0(v1000)
                    else
                        US3_1
                match v1003 with
                | US3_1 -> (* None *)
                    let v1008 : bool =
                        match v0 with
                        | US0_3 -> (* Warning *)
                            true
                        | _ ->
                            false
                    let v1012 : US3 =
                        if v1008 then
                            let v1009 : string = "Warning"
                            US3_0(v1009)
                        else
                            US3_1
                    match v1012 with
                    | US3_1 -> (* None *)
                        let v1017 : bool =
                            match v0 with
                            | US0_4 -> (* Critical *)
                                true
                            | _ ->
                                false
                        let v1021 : US3 =
                            if v1017 then
                                let v1018 : string = "Critical"
                                US3_0(v1018)
                            else
                                US3_1
                        match v1021 with
                        | US3_1 -> (* None *)
                            US3_1
                        | US3_0(v1022) -> (* Some *)
                            US3_0(v1022)
                    | US3_0(v1013) -> (* Some *)
                        US3_0(v1013)
                | US3_0(v1004) -> (* Some *)
                    US3_0(v1004)
            | US3_0(v995) -> (* Some *)
                US3_0(v995)
        | US3_0(v986) -> (* Some *)
            US3_0(v986)
    let v1038 : string =
        match v1034 with
        | US3_1 -> (* None *)
            failwith<string> "Option does not have a value."
        | US3_0(v1035) -> (* Some *)
            v1035
    let v1041 : (unit -> string) = v1038.ToLower
    let v1042 : string = v1041 ()
    let v1051 : string = v1042.PadLeft (7, ' ')
    let v1083 : bool = true
    let mutable _v1083 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1098 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v1092 : string = "inline_colorization::color_bright_red"
            let v1093 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1092 
            v1093
        | US0_1 -> (* Debug *)
            let v1086 : string = "inline_colorization::color_bright_blue"
            let v1087 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1086 
            v1087
        | US0_2 -> (* Info *)
            let v1088 : string = "inline_colorization::color_bright_green"
            let v1089 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1088 
            v1089
        | US0_0 -> (* Verbose *)
            let v1084 : string = "inline_colorization::color_bright_black"
            let v1085 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1084 
            v1085
        | US0_3 -> (* Warning *)
            let v1090 : string = "inline_colorization::color_yellow"
            let v1091 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1090 
            v1091
    let v1099 : string = "&*$0"
    let v1100 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1051 v1099 
    let v1101 : string = "inline_colorization::color_reset"
    let v1102 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1101 
    let v1103 : string = "\"{v1098}{v1100}{v1102}\""
    let v1104 : string = @$"format!(" + v1103 + ")"
    let v1105 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v1104 
    let v1106 : string = "fable_library_rust::String_::fromString($0)"
    let v1107 : string = Fable.Core.RustInterop.emitRustExpr v1105 v1106 
    v1107 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1122 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v1116 : string = "inline_colorization::color_bright_red"
            let v1117 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1116 
            v1117
        | US0_1 -> (* Debug *)
            let v1110 : string = "inline_colorization::color_bright_blue"
            let v1111 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1110 
            v1111
        | US0_2 -> (* Info *)
            let v1112 : string = "inline_colorization::color_bright_green"
            let v1113 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1112 
            v1113
        | US0_0 -> (* Verbose *)
            let v1108 : string = "inline_colorization::color_bright_black"
            let v1109 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1108 
            v1109
        | US0_3 -> (* Warning *)
            let v1114 : string = "inline_colorization::color_yellow"
            let v1115 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1114 
            v1115
    let v1123 : string = "&*$0"
    let v1124 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1051 v1123 
    let v1125 : string = "inline_colorization::color_reset"
    let v1126 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1125 
    let v1127 : string = "\"{v1122}{v1124}{v1126}\""
    let v1128 : string = @$"format!(" + v1127 + ")"
    let v1129 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v1128 
    let v1130 : string = "fable_library_rust::String_::fromString($0)"
    let v1131 : string = Fable.Core.RustInterop.emitRustExpr v1129 v1130 
    v1131 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1146 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v1140 : string = "inline_colorization::color_bright_red"
            let v1141 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1140 
            v1141
        | US0_1 -> (* Debug *)
            let v1134 : string = "inline_colorization::color_bright_blue"
            let v1135 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1134 
            v1135
        | US0_2 -> (* Info *)
            let v1136 : string = "inline_colorization::color_bright_green"
            let v1137 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1136 
            v1137
        | US0_0 -> (* Verbose *)
            let v1132 : string = "inline_colorization::color_bright_black"
            let v1133 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1132 
            v1133
        | US0_3 -> (* Warning *)
            let v1138 : string = "inline_colorization::color_yellow"
            let v1139 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1138 
            v1139
    let v1147 : string = "&*$0"
    let v1148 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1051 v1147 
    let v1149 : string = "inline_colorization::color_reset"
    let v1150 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1149 
    let v1151 : string = "\"{v1146}{v1148}{v1150}\""
    let v1152 : string = @$"format!(" + v1151 + ")"
    let v1153 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v1152 
    let v1154 : string = "fable_library_rust::String_::fromString($0)"
    let v1155 : string = Fable.Core.RustInterop.emitRustExpr v1153 v1154 
    v1155 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1165 : string =
        match v0 with
        | US0_4 -> (* Critical *)
            let v1160 : string = "\u001b[91m"
            v1160
        | US0_1 -> (* Debug *)
            let v1157 : string = "\u001b[94m"
            v1157
        | US0_2 -> (* Info *)
            let v1158 : string = "\u001b[92m"
            v1158
        | US0_0 -> (* Verbose *)
            let v1156 : string = "\u001b[90m"
            v1156
        | US0_3 -> (* Warning *)
            let v1159 : string = "\u001b[93m"
            v1159
    let v1166 : string = method12()
    let v1167 : string = v1165 + v1051 
    let v1168 : string = v1167 + v1166 
    v1168 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1178 : string =
        match v0 with
        | US0_4 -> (* Critical *)
            let v1173 : string = "\u001b[91m"
            v1173
        | US0_1 -> (* Debug *)
            let v1170 : string = "\u001b[94m"
            v1170
        | US0_2 -> (* Info *)
            let v1171 : string = "\u001b[92m"
            v1171
        | US0_0 -> (* Verbose *)
            let v1169 : string = "\u001b[90m"
            v1169
        | US0_3 -> (* Warning *)
            let v1172 : string = "\u001b[93m"
            v1172
    let v1179 : string = method12()
    let v1180 : string = v1178 + v1051 
    let v1181 : string = v1180 + v1179 
    v1181 
    #endif
#else
    let v1191 : string =
        match v0 with
        | US0_4 -> (* Critical *)
            let v1186 : string = "\u001b[91m"
            v1186
        | US0_1 -> (* Debug *)
            let v1183 : string = "\u001b[94m"
            v1183
        | US0_2 -> (* Info *)
            let v1184 : string = "\u001b[92m"
            v1184
        | US0_0 -> (* Verbose *)
            let v1182 : string = "\u001b[90m"
            v1182
        | US0_3 -> (* Warning *)
            let v1185 : string = "\u001b[93m"
            v1185
    let v1192 : string = method12()
    let v1193 : string = v1191 + v1051 
    let v1194 : string = v1193 + v1192 
    v1194 
    #endif
    |> fun x -> _v1083 <- Some x
    let v1195 : string = match _v1083 with Some x -> x | None -> failwith "base.run_target / _v1083=None"
    let v1214 : int64 = v14.l0
    let struct (v1215 : string, v1216 : string) = v2 ()
    let v1217 : string = ""
    let v1218 : Mut4 = {l0 = v1217} : Mut4
    method27(v1218, v1215, v1216)
    let v1219 : string = v1218.l0
    let v1222 : string = $"{v826} {v1195} #{v1214} %s{v1 ()} / {v1219}"
    let v1229 : char list = []
    let v1234 : (char list -> (char [])) = List.toArray
    let v1235 : (char []) = v1234 v1229
    let v1242 : string = v1222.TrimStart v1235 
    let v1281 : char list = []
    let v1284 : char list = '/' :: v1281 
    let v1293 : char list = ' ' :: v1284 
    let v1304 : (char list -> (char [])) = List.toArray
    let v1305 : (char []) = v1304 v1293
    let v1312 : string = v1242.TrimEnd v1305 
    v1312
and method26 (v0 : US0, v1 : (unit -> string), v2 : (unit -> struct (string * string))) : unit =
    let v3 : (unit -> string) = closure22(v0, v1, v2)
    method16(v0, v3)
and method25 (v0 : string, v1 : int64) : Async<int64> =
    let v4 : bool = true
    let mutable _v4 : Async<int64> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v7 : Async<int64> = null |> unbox<Async<int64>>
    v7 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v16 : Async<int64> = null |> unbox<Async<int64>>
    v16 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v25 : Async<int64> = null |> unbox<Async<int64>>
    v25 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v34 : Async<int64> = null |> unbox<Async<int64>>
    v34 
    #endif
#if FABLE_COMPILER_PYTHON
    let v43 : Async<int64> = null |> unbox<Async<int64>>
    v43 
    #endif
#else
    let v50 : Async<int64> option = None
    let mutable _v50 = v50 
    async {
    try
    let v53 : bool = true
    let mutable _v53 : unit option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v54 : string = "std::fs::remove_file(&*$0).unwrap()"
    Fable.Core.RustInterop.emitRustExpr v0 v54 
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
#if FABLE_COMPILER_TYPESCRIPT
    null |> unbox<unit>
    () 
    #endif
#if FABLE_COMPILER_PYTHON
    null |> unbox<unit>
    () 
    #endif
#else
    let v79 : (string -> unit) = System.IO.File.Delete
    v79 v0
    () 
    #endif
    |> fun x -> _v53 <- Some x
    match _v53 with Some x -> x | None -> failwith "base.run_target / _v53=None"
    return v1 
    with ex ->
    let v90 : exn = ex
    let v91 : int64 = v1 % 100L
    let v92 : bool = v91 = 0L
    if v92 then
        let v93 : US0 = US0_3
        let v94 : (unit -> string) = closure20()
        let v95 : (unit -> struct (string * string)) = closure21(v0, v90)
        method26(v93, v94, v95)
    let v98 : bool = true
    let mutable _v98 : Async<unit> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v101 : Async<unit> = null |> unbox<Async<unit>>
    v101 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v110 : Async<unit> = null |> unbox<Async<unit>>
    v110 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v119 : Async<unit> = null |> unbox<Async<unit>>
    v119 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v128 : Async<unit> = null |> unbox<Async<unit>>
    v128 
    #endif
#if FABLE_COMPILER_PYTHON
    let v137 : Async<unit> = null |> unbox<Async<unit>>
    v137 
    #endif
#else
    let v144 : (int32 -> Async<unit>) = Async.Sleep
    let v145 : Async<unit> = v144 10
    v145 
    #endif
    |> fun x -> _v98 <- Some x
    let v146 : Async<unit> = match _v98 with Some x -> x | None -> failwith "base.run_target / _v98=None"
    do! v146 
    let v161 : int64 = v1 + 1L
    let v162 : Async<int64> = method25(v0, v161)
    return! v162 
    (*
    let v163 : int64 = *)
    }
    |> fun x -> _v50 <- Some x
    let v164 : Async<int64> = match _v50 with Some x -> x | None -> failwith "async.new_async_unit / _v50=None"
    v164 
    #endif
    |> fun x -> _v4 <- Some x
    let v165 : Async<int64> = match _v4 with Some x -> x | None -> failwith "base.run_target / _v4=None"
    v165
and closure19 () (v0 : string) : Async<int64> =
    let v3 : bool = true
    let mutable _v3 : Async<int64> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v6 : Async<int64> = null |> unbox<Async<int64>>
    v6 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v15 : Async<int64> = null |> unbox<Async<int64>>
    v15 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v24 : Async<int64> = null |> unbox<Async<int64>>
    v24 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v33 : Async<int64> = null |> unbox<Async<int64>>
    v33 
    #endif
#if FABLE_COMPILER_PYTHON
    let v42 : Async<int64> = null |> unbox<Async<int64>>
    v42 
    #endif
#else
    let v49 : int64 = 0L
    let v50 : Async<int64> = method25(v0, v49)
    v50 
    #endif
    |> fun x -> _v3 <- Some x
    let v51 : Async<int64> = match _v3 with Some x -> x | None -> failwith "base.run_target / _v3=None"
    v51
and closure25 () () : string =
    let v0 : string = "move_file_async"
    v0
and closure26 (v0 : string, v1 : string, v2 : exn) () : struct (string * string * exn) =
    let v3 : string = method8(v1)
    let v4 : string = method8(v0)
    struct (v3, v4, v2)
and method31 (v0 : Mut4, v1 : exn) : unit =
    let v4 : string = $"%A{v1}"
    method14(v0, v4)
and method30 (v0 : Mut4, v1 : string, v2 : string, v3 : exn) : unit =
    let v4 : string = "{ "
    method14(v0, v4)
    method15(v0)
    let v5 : string = "old_path"
    method14(v0, v5)
    let v6 : string = " = "
    method14(v0, v6)
    method14(v0, v1)
    let v7 : string = "; "
    method14(v0, v7)
    let v8 : string = "new_path"
    method14(v0, v8)
    method14(v0, v6)
    method14(v0, v2)
    method14(v0, v7)
    let v9 : string = "ex"
    method14(v0, v9)
    method14(v0, v6)
    method31(v0, v3)
    let v10 : string = " }"
    method14(v0, v10)
and closure27 (v0 : US0, v1 : (unit -> string), v2 : (unit -> struct (string * string * exn))) () : string =
    let v5 : (US0 -> struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option)) = closure0()
    let v6 : US0 = US0_0
    if State.trace_state.IsNone then State.trace_state <- v5 v6 |> Some
    let struct (v14 : Mut0, v15 : Mut1, v16 : Mut2, v17 : Mut3, v18 : int64 option) = State.trace_state.Value
    let v35 : bool = true
    let mutable _v35 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v38 : US2 option = None
    let _v38 = ref v38 
    match v18 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v39 : int64 = x
    let v40 : US2 = US2_0(v39)
    v40 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v38.Value <- x
    let v41 : US2 option = _v38.Value 
    let v64 : US2 = US2_1
    let v65 : US2 = v41 |> Option.defaultValue v64 
    let v163 : System.DateTime =
        match v65 with
        | US2_1 -> (* None *)
            let v155 : System.DateTime = System.DateTime.Now
            v155
        | US2_0(v73) -> (* Some *)
            let v76 : System.DateTime = System.DateTime.Now
            let v85 : (System.DateTime -> int64) = _.Ticks
            let v86 : int64 = v85 v76
            let v93 : int64 = v86 - v73
            let v96 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v97 : System.TimeSpan = v96 v93
            let v106 : (System.TimeSpan -> int32) = _.Hours
            let v107 : int32 = v106 v97
            let v116 : (System.TimeSpan -> int32) = _.Minutes
            let v117 : int32 = v116 v97
            let v126 : (System.TimeSpan -> int32) = _.Seconds
            let v127 : int32 = v126 v97
            let v136 : (System.TimeSpan -> int32) = _.Milliseconds
            let v137 : int32 = v136 v97
            let v146 : System.DateTime = System.DateTime (1, 1, 1, v107, v117, v127, v137)
            v146
    let v166 : string = method10()
    let v175 : (string -> string) = v163.ToString
    let v176 : string = v175 v166
    v176 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v185 : US2 option = None
    let _v185 = ref v185 
    match v18 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v186 : int64 = x
    let v187 : US2 = US2_0(v186)
    v187 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v185.Value <- x
    let v188 : US2 option = _v185.Value 
    let v211 : US2 = US2_1
    let v212 : US2 = v188 |> Option.defaultValue v211 
    let v310 : System.DateTime =
        match v212 with
        | US2_1 -> (* None *)
            let v302 : System.DateTime = System.DateTime.Now
            v302
        | US2_0(v220) -> (* Some *)
            let v223 : System.DateTime = System.DateTime.Now
            let v232 : (System.DateTime -> int64) = _.Ticks
            let v233 : int64 = v232 v223
            let v240 : int64 = v233 - v220
            let v243 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v244 : System.TimeSpan = v243 v240
            let v253 : (System.TimeSpan -> int32) = _.Hours
            let v254 : int32 = v253 v244
            let v263 : (System.TimeSpan -> int32) = _.Minutes
            let v264 : int32 = v263 v244
            let v273 : (System.TimeSpan -> int32) = _.Seconds
            let v274 : int32 = v273 v244
            let v283 : (System.TimeSpan -> int32) = _.Milliseconds
            let v284 : int32 = v283 v244
            let v293 : System.DateTime = System.DateTime (1, 1, 1, v254, v264, v274, v284)
            v293
    let v313 : string = method10()
    let v322 : (string -> string) = v310.ToString
    let v323 : string = v322 v313
    v323 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v330 : string = $"near_sdk::env::block_timestamp()"
    let v331 : uint64 = Fable.Core.RustInterop.emitRustExpr () v330 
    let v334 : US2 option = None
    let _v334 = ref v334 
    match v18 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v335 : int64 = x
    let v336 : US2 = US2_0(v335)
    v336 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v334.Value <- x
    let v337 : US2 option = _v334.Value 
    let v360 : US2 = US2_1
    let v361 : US2 = v337 |> Option.defaultValue v360 
    let v374 : uint64 =
        match v361 with
        | US2_1 -> (* None *)
            v331
        | US2_0(v369) -> (* Some *)
            let v370 : (int64 -> uint64) = uint64
            let v371 : uint64 = v370 v369
            let v372 : uint64 = v331 - v371
            v372
    let v375 : uint64 = v374 / 1000000000UL
    let v376 : uint64 = v375 % 60UL
    let v377 : uint64 = v375 / 60UL
    let v378 : uint64 = v377 % 60UL
    let v379 : uint64 = v375 / 3600UL
    let v380 : uint64 = v379 % 24UL
    let v381 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
    let v382 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v380, v378, v376) v381 
    let v383 : string = "fable_library_rust::String_::fromString($0)"
    let v384 : string = Fable.Core.RustInterop.emitRustExpr v382 v383 
    v384 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v387 : US2 option = None
    let _v387 = ref v387 
    match v18 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v388 : int64 = x
    let v389 : US2 = US2_0(v388)
    v389 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v387.Value <- x
    let v390 : US2 option = _v387.Value 
    let v413 : US2 = US2_1
    let v414 : US2 = v390 |> Option.defaultValue v413 
    let v512 : System.DateTime =
        match v414 with
        | US2_1 -> (* None *)
            let v504 : System.DateTime = System.DateTime.Now
            v504
        | US2_0(v422) -> (* Some *)
            let v425 : System.DateTime = System.DateTime.Now
            let v434 : (System.DateTime -> int64) = _.Ticks
            let v435 : int64 = v434 v425
            let v442 : int64 = v435 - v422
            let v445 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v446 : System.TimeSpan = v445 v442
            let v455 : (System.TimeSpan -> int32) = _.Hours
            let v456 : int32 = v455 v446
            let v465 : (System.TimeSpan -> int32) = _.Minutes
            let v466 : int32 = v465 v446
            let v475 : (System.TimeSpan -> int32) = _.Seconds
            let v476 : int32 = v475 v446
            let v485 : (System.TimeSpan -> int32) = _.Milliseconds
            let v486 : int32 = v485 v446
            let v495 : System.DateTime = System.DateTime (1, 1, 1, v456, v466, v476, v486)
            v495
    let v515 : string = method11()
    let v524 : (string -> string) = v512.ToString
    let v525 : string = v524 v515
    v525 
    #endif
#if FABLE_COMPILER_PYTHON
    let v534 : US2 option = None
    let _v534 = ref v534 
    match v18 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v535 : int64 = x
    let v536 : US2 = US2_0(v535)
    v536 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v534.Value <- x
    let v537 : US2 option = _v534.Value 
    let v560 : US2 = US2_1
    let v561 : US2 = v537 |> Option.defaultValue v560 
    let v659 : System.DateTime =
        match v561 with
        | US2_1 -> (* None *)
            let v651 : System.DateTime = System.DateTime.Now
            v651
        | US2_0(v569) -> (* Some *)
            let v572 : System.DateTime = System.DateTime.Now
            let v581 : (System.DateTime -> int64) = _.Ticks
            let v582 : int64 = v581 v572
            let v589 : int64 = v582 - v569
            let v592 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v593 : System.TimeSpan = v592 v589
            let v602 : (System.TimeSpan -> int32) = _.Hours
            let v603 : int32 = v602 v593
            let v612 : (System.TimeSpan -> int32) = _.Minutes
            let v613 : int32 = v612 v593
            let v622 : (System.TimeSpan -> int32) = _.Seconds
            let v623 : int32 = v622 v593
            let v632 : (System.TimeSpan -> int32) = _.Milliseconds
            let v633 : int32 = v632 v593
            let v642 : System.DateTime = System.DateTime (1, 1, 1, v603, v613, v623, v633)
            v642
    let v662 : string = method11()
    let v671 : (string -> string) = v659.ToString
    let v672 : string = v671 v662
    v672 
    #endif
#else
    let v681 : US2 option = None
    let _v681 = ref v681 
    match v18 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v682 : int64 = x
    let v683 : US2 = US2_0(v682)
    v683 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v681.Value <- x
    let v684 : US2 option = _v681.Value 
    let v707 : US2 = US2_1
    let v708 : US2 = v684 |> Option.defaultValue v707 
    let v806 : System.DateTime =
        match v708 with
        | US2_1 -> (* None *)
            let v798 : System.DateTime = System.DateTime.Now
            v798
        | US2_0(v716) -> (* Some *)
            let v719 : System.DateTime = System.DateTime.Now
            let v728 : (System.DateTime -> int64) = _.Ticks
            let v729 : int64 = v728 v719
            let v736 : int64 = v729 - v716
            let v739 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v740 : System.TimeSpan = v739 v736
            let v749 : (System.TimeSpan -> int32) = _.Hours
            let v750 : int32 = v749 v740
            let v759 : (System.TimeSpan -> int32) = _.Minutes
            let v760 : int32 = v759 v740
            let v769 : (System.TimeSpan -> int32) = _.Seconds
            let v770 : int32 = v769 v740
            let v779 : (System.TimeSpan -> int32) = _.Milliseconds
            let v780 : int32 = v779 v740
            let v789 : System.DateTime = System.DateTime (1, 1, 1, v750, v760, v770, v780)
            v789
    let v809 : string = method11()
    let v818 : (string -> string) = v806.ToString
    let v819 : string = v818 v809
    v819 
    #endif
    |> fun x -> _v35 <- Some x
    let v826 : string = match _v35 with Some x -> x | None -> failwith "base.run_target / _v35=None"
    let v981 : bool =
        match v0 with
        | US0_0 -> (* Verbose *)
            true
        | _ ->
            false
    let v985 : US3 =
        if v981 then
            let v982 : string = "Verbose"
            US3_0(v982)
        else
            US3_1
    let v1034 : US3 =
        match v985 with
        | US3_1 -> (* None *)
            let v990 : bool =
                match v0 with
                | US0_1 -> (* Debug *)
                    true
                | _ ->
                    false
            let v994 : US3 =
                if v990 then
                    let v991 : string = "Debug"
                    US3_0(v991)
                else
                    US3_1
            match v994 with
            | US3_1 -> (* None *)
                let v999 : bool =
                    match v0 with
                    | US0_2 -> (* Info *)
                        true
                    | _ ->
                        false
                let v1003 : US3 =
                    if v999 then
                        let v1000 : string = "Info"
                        US3_0(v1000)
                    else
                        US3_1
                match v1003 with
                | US3_1 -> (* None *)
                    let v1008 : bool =
                        match v0 with
                        | US0_3 -> (* Warning *)
                            true
                        | _ ->
                            false
                    let v1012 : US3 =
                        if v1008 then
                            let v1009 : string = "Warning"
                            US3_0(v1009)
                        else
                            US3_1
                    match v1012 with
                    | US3_1 -> (* None *)
                        let v1017 : bool =
                            match v0 with
                            | US0_4 -> (* Critical *)
                                true
                            | _ ->
                                false
                        let v1021 : US3 =
                            if v1017 then
                                let v1018 : string = "Critical"
                                US3_0(v1018)
                            else
                                US3_1
                        match v1021 with
                        | US3_1 -> (* None *)
                            US3_1
                        | US3_0(v1022) -> (* Some *)
                            US3_0(v1022)
                    | US3_0(v1013) -> (* Some *)
                        US3_0(v1013)
                | US3_0(v1004) -> (* Some *)
                    US3_0(v1004)
            | US3_0(v995) -> (* Some *)
                US3_0(v995)
        | US3_0(v986) -> (* Some *)
            US3_0(v986)
    let v1038 : string =
        match v1034 with
        | US3_1 -> (* None *)
            failwith<string> "Option does not have a value."
        | US3_0(v1035) -> (* Some *)
            v1035
    let v1041 : (unit -> string) = v1038.ToLower
    let v1042 : string = v1041 ()
    let v1051 : string = v1042.PadLeft (7, ' ')
    let v1083 : bool = true
    let mutable _v1083 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1098 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v1092 : string = "inline_colorization::color_bright_red"
            let v1093 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1092 
            v1093
        | US0_1 -> (* Debug *)
            let v1086 : string = "inline_colorization::color_bright_blue"
            let v1087 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1086 
            v1087
        | US0_2 -> (* Info *)
            let v1088 : string = "inline_colorization::color_bright_green"
            let v1089 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1088 
            v1089
        | US0_0 -> (* Verbose *)
            let v1084 : string = "inline_colorization::color_bright_black"
            let v1085 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1084 
            v1085
        | US0_3 -> (* Warning *)
            let v1090 : string = "inline_colorization::color_yellow"
            let v1091 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1090 
            v1091
    let v1099 : string = "&*$0"
    let v1100 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1051 v1099 
    let v1101 : string = "inline_colorization::color_reset"
    let v1102 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1101 
    let v1103 : string = "\"{v1098}{v1100}{v1102}\""
    let v1104 : string = @$"format!(" + v1103 + ")"
    let v1105 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v1104 
    let v1106 : string = "fable_library_rust::String_::fromString($0)"
    let v1107 : string = Fable.Core.RustInterop.emitRustExpr v1105 v1106 
    v1107 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1122 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v1116 : string = "inline_colorization::color_bright_red"
            let v1117 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1116 
            v1117
        | US0_1 -> (* Debug *)
            let v1110 : string = "inline_colorization::color_bright_blue"
            let v1111 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1110 
            v1111
        | US0_2 -> (* Info *)
            let v1112 : string = "inline_colorization::color_bright_green"
            let v1113 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1112 
            v1113
        | US0_0 -> (* Verbose *)
            let v1108 : string = "inline_colorization::color_bright_black"
            let v1109 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1108 
            v1109
        | US0_3 -> (* Warning *)
            let v1114 : string = "inline_colorization::color_yellow"
            let v1115 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1114 
            v1115
    let v1123 : string = "&*$0"
    let v1124 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1051 v1123 
    let v1125 : string = "inline_colorization::color_reset"
    let v1126 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1125 
    let v1127 : string = "\"{v1122}{v1124}{v1126}\""
    let v1128 : string = @$"format!(" + v1127 + ")"
    let v1129 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v1128 
    let v1130 : string = "fable_library_rust::String_::fromString($0)"
    let v1131 : string = Fable.Core.RustInterop.emitRustExpr v1129 v1130 
    v1131 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1146 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v1140 : string = "inline_colorization::color_bright_red"
            let v1141 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1140 
            v1141
        | US0_1 -> (* Debug *)
            let v1134 : string = "inline_colorization::color_bright_blue"
            let v1135 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1134 
            v1135
        | US0_2 -> (* Info *)
            let v1136 : string = "inline_colorization::color_bright_green"
            let v1137 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1136 
            v1137
        | US0_0 -> (* Verbose *)
            let v1132 : string = "inline_colorization::color_bright_black"
            let v1133 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1132 
            v1133
        | US0_3 -> (* Warning *)
            let v1138 : string = "inline_colorization::color_yellow"
            let v1139 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1138 
            v1139
    let v1147 : string = "&*$0"
    let v1148 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1051 v1147 
    let v1149 : string = "inline_colorization::color_reset"
    let v1150 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1149 
    let v1151 : string = "\"{v1146}{v1148}{v1150}\""
    let v1152 : string = @$"format!(" + v1151 + ")"
    let v1153 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v1152 
    let v1154 : string = "fable_library_rust::String_::fromString($0)"
    let v1155 : string = Fable.Core.RustInterop.emitRustExpr v1153 v1154 
    v1155 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1165 : string =
        match v0 with
        | US0_4 -> (* Critical *)
            let v1160 : string = "\u001b[91m"
            v1160
        | US0_1 -> (* Debug *)
            let v1157 : string = "\u001b[94m"
            v1157
        | US0_2 -> (* Info *)
            let v1158 : string = "\u001b[92m"
            v1158
        | US0_0 -> (* Verbose *)
            let v1156 : string = "\u001b[90m"
            v1156
        | US0_3 -> (* Warning *)
            let v1159 : string = "\u001b[93m"
            v1159
    let v1166 : string = method12()
    let v1167 : string = v1165 + v1051 
    let v1168 : string = v1167 + v1166 
    v1168 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1178 : string =
        match v0 with
        | US0_4 -> (* Critical *)
            let v1173 : string = "\u001b[91m"
            v1173
        | US0_1 -> (* Debug *)
            let v1170 : string = "\u001b[94m"
            v1170
        | US0_2 -> (* Info *)
            let v1171 : string = "\u001b[92m"
            v1171
        | US0_0 -> (* Verbose *)
            let v1169 : string = "\u001b[90m"
            v1169
        | US0_3 -> (* Warning *)
            let v1172 : string = "\u001b[93m"
            v1172
    let v1179 : string = method12()
    let v1180 : string = v1178 + v1051 
    let v1181 : string = v1180 + v1179 
    v1181 
    #endif
#else
    let v1191 : string =
        match v0 with
        | US0_4 -> (* Critical *)
            let v1186 : string = "\u001b[91m"
            v1186
        | US0_1 -> (* Debug *)
            let v1183 : string = "\u001b[94m"
            v1183
        | US0_2 -> (* Info *)
            let v1184 : string = "\u001b[92m"
            v1184
        | US0_0 -> (* Verbose *)
            let v1182 : string = "\u001b[90m"
            v1182
        | US0_3 -> (* Warning *)
            let v1185 : string = "\u001b[93m"
            v1185
    let v1192 : string = method12()
    let v1193 : string = v1191 + v1051 
    let v1194 : string = v1193 + v1192 
    v1194 
    #endif
    |> fun x -> _v1083 <- Some x
    let v1195 : string = match _v1083 with Some x -> x | None -> failwith "base.run_target / _v1083=None"
    let v1214 : int64 = v14.l0
    let struct (v1215 : string, v1216 : string, v1217 : exn) = v2 ()
    let v1218 : string = ""
    let v1219 : Mut4 = {l0 = v1218} : Mut4
    method30(v1219, v1215, v1216, v1217)
    let v1220 : string = v1219.l0
    let v1223 : string = $"{v826} {v1195} #{v1214} %s{v1 ()} / {v1220}"
    let v1230 : char list = []
    let v1235 : (char list -> (char [])) = List.toArray
    let v1236 : (char []) = v1235 v1230
    let v1243 : string = v1223.TrimStart v1236 
    let v1282 : char list = []
    let v1285 : char list = '/' :: v1282 
    let v1294 : char list = ' ' :: v1285 
    let v1305 : (char list -> (char [])) = List.toArray
    let v1306 : (char []) = v1305 v1294
    let v1313 : string = v1243.TrimEnd v1306 
    v1313
and method29 (v0 : US0, v1 : (unit -> string), v2 : (unit -> struct (string * string * exn))) : unit =
    let v3 : (unit -> string) = closure27(v0, v1, v2)
    method16(v0, v3)
and method28 (v0 : string, v1 : string, v2 : int64) : Async<int64> =
    let v5 : bool = true
    let mutable _v5 : Async<int64> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v8 : Async<int64> = null |> unbox<Async<int64>>
    v8 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v17 : Async<int64> = null |> unbox<Async<int64>>
    v17 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v26 : Async<int64> = null |> unbox<Async<int64>>
    v26 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v35 : Async<int64> = null |> unbox<Async<int64>>
    v35 
    #endif
#if FABLE_COMPILER_PYTHON
    let v44 : Async<int64> = null |> unbox<Async<int64>>
    v44 
    #endif
#else
    let v51 : Async<int64> option = None
    let mutable _v51 = v51 
    async {
    try
    let v54 : bool = true
    let mutable _v54 : unit option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
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
#if FABLE_COMPILER_TYPESCRIPT
    null |> unbox<unit>
    () 
    #endif
#if FABLE_COMPILER_PYTHON
    null |> unbox<unit>
    () 
    #endif
#else
    System.IO.File.Move (v1, v0)
    () 
    #endif
    |> fun x -> _v54 <- Some x
    match _v54 with Some x -> x | None -> failwith "base.run_target / _v54=None"
    return v2 
    with ex ->
    let v95 : exn = ex
    let v96 : int64 = v2 % 100L
    let v97 : bool = v96 = 0L
    if v97 then
        let v98 : US0 = US0_3
        let v99 : (unit -> string) = closure25()
        let v100 : (unit -> struct (string * string * exn)) = closure26(v0, v1, v95)
        method29(v98, v99, v100)
    let v103 : bool = true
    let mutable _v103 : Async<unit> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v106 : Async<unit> = null |> unbox<Async<unit>>
    v106 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v115 : Async<unit> = null |> unbox<Async<unit>>
    v115 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v124 : Async<unit> = null |> unbox<Async<unit>>
    v124 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v133 : Async<unit> = null |> unbox<Async<unit>>
    v133 
    #endif
#if FABLE_COMPILER_PYTHON
    let v142 : Async<unit> = null |> unbox<Async<unit>>
    v142 
    #endif
#else
    let v149 : (int32 -> Async<unit>) = Async.Sleep
    let v150 : Async<unit> = v149 10
    v150 
    #endif
    |> fun x -> _v103 <- Some x
    let v151 : Async<unit> = match _v103 with Some x -> x | None -> failwith "base.run_target / _v103=None"
    do! v151 
    let v166 : int64 = v2 + 1L
    let v167 : Async<int64> = method28(v0, v1, v166)
    return! v167 
    (*
    *)
    }
    |> fun x -> _v51 <- Some x
    let v168 : Async<int64> = match _v51 with Some x -> x | None -> failwith "async.new_async_unit / _v51=None"
    v168 
    #endif
    |> fun x -> _v5 <- Some x
    let v169 : Async<int64> = match _v5 with Some x -> x | None -> failwith "base.run_target / _v5=None"
    v169
and closure24 (v0 : string) (v1 : string) : Async<int64> =
    let v4 : bool = true
    let mutable _v4 : Async<int64> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v7 : Async<int64> = null |> unbox<Async<int64>>
    v7 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v16 : Async<int64> = null |> unbox<Async<int64>>
    v16 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v25 : Async<int64> = null |> unbox<Async<int64>>
    v25 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v34 : Async<int64> = null |> unbox<Async<int64>>
    v34 
    #endif
#if FABLE_COMPILER_PYTHON
    let v43 : Async<int64> = null |> unbox<Async<int64>>
    v43 
    #endif
#else
    let v50 : int64 = 0L
    let v51 : Async<int64> = method28(v0, v1, v50)
    v51 
    #endif
    |> fun x -> _v4 <- Some x
    let v52 : Async<int64> = match _v4 with Some x -> x | None -> failwith "base.run_target / _v4=None"
    v52
and closure23 () (v0 : string) : (string -> Async<int64>) =
    closure24(v0)
and closure29 () (v0 : int64) : US9 =
    US9_0(v0)
and closure30 () (v0 : exn) : US9 =
    US9_1(v0)
and closure31 () () : string =
    let v0 : string = "async.run_with_timeout_async"
    v0
and closure32 () () : int32 =
    1000
and method35 (v0 : Mut4, v1 : int32) : unit =
    let v4 : string = $"{v1}"
    let v11 : string = v0.l0
    let v12 : string = v11 + v4 
    v0.l0 <- v12
    ()
and method34 (v0 : Mut4, v1 : int32) : unit =
    let v2 : string = "{ "
    method14(v0, v2)
    method15(v0)
    let v3 : string = "timeout"
    method14(v0, v3)
    let v4 : string = " = "
    method14(v0, v4)
    method35(v0, v1)
    let v5 : string = " }"
    method14(v0, v5)
and closure33 (v0 : US0, v1 : (unit -> string), v2 : (unit -> int32)) () : string =
    let v5 : (US0 -> struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option)) = closure0()
    let v6 : US0 = US0_0
    if State.trace_state.IsNone then State.trace_state <- v5 v6 |> Some
    let struct (v14 : Mut0, v15 : Mut1, v16 : Mut2, v17 : Mut3, v18 : int64 option) = State.trace_state.Value
    let v35 : bool = true
    let mutable _v35 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v38 : US2 option = None
    let _v38 = ref v38 
    match v18 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v39 : int64 = x
    let v40 : US2 = US2_0(v39)
    v40 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v38.Value <- x
    let v41 : US2 option = _v38.Value 
    let v64 : US2 = US2_1
    let v65 : US2 = v41 |> Option.defaultValue v64 
    let v163 : System.DateTime =
        match v65 with
        | US2_1 -> (* None *)
            let v155 : System.DateTime = System.DateTime.Now
            v155
        | US2_0(v73) -> (* Some *)
            let v76 : System.DateTime = System.DateTime.Now
            let v85 : (System.DateTime -> int64) = _.Ticks
            let v86 : int64 = v85 v76
            let v93 : int64 = v86 - v73
            let v96 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v97 : System.TimeSpan = v96 v93
            let v106 : (System.TimeSpan -> int32) = _.Hours
            let v107 : int32 = v106 v97
            let v116 : (System.TimeSpan -> int32) = _.Minutes
            let v117 : int32 = v116 v97
            let v126 : (System.TimeSpan -> int32) = _.Seconds
            let v127 : int32 = v126 v97
            let v136 : (System.TimeSpan -> int32) = _.Milliseconds
            let v137 : int32 = v136 v97
            let v146 : System.DateTime = System.DateTime (1, 1, 1, v107, v117, v127, v137)
            v146
    let v166 : string = method10()
    let v175 : (string -> string) = v163.ToString
    let v176 : string = v175 v166
    v176 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v185 : US2 option = None
    let _v185 = ref v185 
    match v18 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v186 : int64 = x
    let v187 : US2 = US2_0(v186)
    v187 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v185.Value <- x
    let v188 : US2 option = _v185.Value 
    let v211 : US2 = US2_1
    let v212 : US2 = v188 |> Option.defaultValue v211 
    let v310 : System.DateTime =
        match v212 with
        | US2_1 -> (* None *)
            let v302 : System.DateTime = System.DateTime.Now
            v302
        | US2_0(v220) -> (* Some *)
            let v223 : System.DateTime = System.DateTime.Now
            let v232 : (System.DateTime -> int64) = _.Ticks
            let v233 : int64 = v232 v223
            let v240 : int64 = v233 - v220
            let v243 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v244 : System.TimeSpan = v243 v240
            let v253 : (System.TimeSpan -> int32) = _.Hours
            let v254 : int32 = v253 v244
            let v263 : (System.TimeSpan -> int32) = _.Minutes
            let v264 : int32 = v263 v244
            let v273 : (System.TimeSpan -> int32) = _.Seconds
            let v274 : int32 = v273 v244
            let v283 : (System.TimeSpan -> int32) = _.Milliseconds
            let v284 : int32 = v283 v244
            let v293 : System.DateTime = System.DateTime (1, 1, 1, v254, v264, v274, v284)
            v293
    let v313 : string = method10()
    let v322 : (string -> string) = v310.ToString
    let v323 : string = v322 v313
    v323 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v330 : string = $"near_sdk::env::block_timestamp()"
    let v331 : uint64 = Fable.Core.RustInterop.emitRustExpr () v330 
    let v334 : US2 option = None
    let _v334 = ref v334 
    match v18 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v335 : int64 = x
    let v336 : US2 = US2_0(v335)
    v336 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v334.Value <- x
    let v337 : US2 option = _v334.Value 
    let v360 : US2 = US2_1
    let v361 : US2 = v337 |> Option.defaultValue v360 
    let v374 : uint64 =
        match v361 with
        | US2_1 -> (* None *)
            v331
        | US2_0(v369) -> (* Some *)
            let v370 : (int64 -> uint64) = uint64
            let v371 : uint64 = v370 v369
            let v372 : uint64 = v331 - v371
            v372
    let v375 : uint64 = v374 / 1000000000UL
    let v376 : uint64 = v375 % 60UL
    let v377 : uint64 = v375 / 60UL
    let v378 : uint64 = v377 % 60UL
    let v379 : uint64 = v375 / 3600UL
    let v380 : uint64 = v379 % 24UL
    let v381 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
    let v382 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v380, v378, v376) v381 
    let v383 : string = "fable_library_rust::String_::fromString($0)"
    let v384 : string = Fable.Core.RustInterop.emitRustExpr v382 v383 
    v384 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v387 : US2 option = None
    let _v387 = ref v387 
    match v18 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v388 : int64 = x
    let v389 : US2 = US2_0(v388)
    v389 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v387.Value <- x
    let v390 : US2 option = _v387.Value 
    let v413 : US2 = US2_1
    let v414 : US2 = v390 |> Option.defaultValue v413 
    let v512 : System.DateTime =
        match v414 with
        | US2_1 -> (* None *)
            let v504 : System.DateTime = System.DateTime.Now
            v504
        | US2_0(v422) -> (* Some *)
            let v425 : System.DateTime = System.DateTime.Now
            let v434 : (System.DateTime -> int64) = _.Ticks
            let v435 : int64 = v434 v425
            let v442 : int64 = v435 - v422
            let v445 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v446 : System.TimeSpan = v445 v442
            let v455 : (System.TimeSpan -> int32) = _.Hours
            let v456 : int32 = v455 v446
            let v465 : (System.TimeSpan -> int32) = _.Minutes
            let v466 : int32 = v465 v446
            let v475 : (System.TimeSpan -> int32) = _.Seconds
            let v476 : int32 = v475 v446
            let v485 : (System.TimeSpan -> int32) = _.Milliseconds
            let v486 : int32 = v485 v446
            let v495 : System.DateTime = System.DateTime (1, 1, 1, v456, v466, v476, v486)
            v495
    let v515 : string = method11()
    let v524 : (string -> string) = v512.ToString
    let v525 : string = v524 v515
    v525 
    #endif
#if FABLE_COMPILER_PYTHON
    let v534 : US2 option = None
    let _v534 = ref v534 
    match v18 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v535 : int64 = x
    let v536 : US2 = US2_0(v535)
    v536 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v534.Value <- x
    let v537 : US2 option = _v534.Value 
    let v560 : US2 = US2_1
    let v561 : US2 = v537 |> Option.defaultValue v560 
    let v659 : System.DateTime =
        match v561 with
        | US2_1 -> (* None *)
            let v651 : System.DateTime = System.DateTime.Now
            v651
        | US2_0(v569) -> (* Some *)
            let v572 : System.DateTime = System.DateTime.Now
            let v581 : (System.DateTime -> int64) = _.Ticks
            let v582 : int64 = v581 v572
            let v589 : int64 = v582 - v569
            let v592 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v593 : System.TimeSpan = v592 v589
            let v602 : (System.TimeSpan -> int32) = _.Hours
            let v603 : int32 = v602 v593
            let v612 : (System.TimeSpan -> int32) = _.Minutes
            let v613 : int32 = v612 v593
            let v622 : (System.TimeSpan -> int32) = _.Seconds
            let v623 : int32 = v622 v593
            let v632 : (System.TimeSpan -> int32) = _.Milliseconds
            let v633 : int32 = v632 v593
            let v642 : System.DateTime = System.DateTime (1, 1, 1, v603, v613, v623, v633)
            v642
    let v662 : string = method11()
    let v671 : (string -> string) = v659.ToString
    let v672 : string = v671 v662
    v672 
    #endif
#else
    let v681 : US2 option = None
    let _v681 = ref v681 
    match v18 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v682 : int64 = x
    let v683 : US2 = US2_0(v682)
    v683 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v681.Value <- x
    let v684 : US2 option = _v681.Value 
    let v707 : US2 = US2_1
    let v708 : US2 = v684 |> Option.defaultValue v707 
    let v806 : System.DateTime =
        match v708 with
        | US2_1 -> (* None *)
            let v798 : System.DateTime = System.DateTime.Now
            v798
        | US2_0(v716) -> (* Some *)
            let v719 : System.DateTime = System.DateTime.Now
            let v728 : (System.DateTime -> int64) = _.Ticks
            let v729 : int64 = v728 v719
            let v736 : int64 = v729 - v716
            let v739 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v740 : System.TimeSpan = v739 v736
            let v749 : (System.TimeSpan -> int32) = _.Hours
            let v750 : int32 = v749 v740
            let v759 : (System.TimeSpan -> int32) = _.Minutes
            let v760 : int32 = v759 v740
            let v769 : (System.TimeSpan -> int32) = _.Seconds
            let v770 : int32 = v769 v740
            let v779 : (System.TimeSpan -> int32) = _.Milliseconds
            let v780 : int32 = v779 v740
            let v789 : System.DateTime = System.DateTime (1, 1, 1, v750, v760, v770, v780)
            v789
    let v809 : string = method11()
    let v818 : (string -> string) = v806.ToString
    let v819 : string = v818 v809
    v819 
    #endif
    |> fun x -> _v35 <- Some x
    let v826 : string = match _v35 with Some x -> x | None -> failwith "base.run_target / _v35=None"
    let v981 : bool =
        match v0 with
        | US0_0 -> (* Verbose *)
            true
        | _ ->
            false
    let v985 : US3 =
        if v981 then
            let v982 : string = "Verbose"
            US3_0(v982)
        else
            US3_1
    let v1034 : US3 =
        match v985 with
        | US3_1 -> (* None *)
            let v990 : bool =
                match v0 with
                | US0_1 -> (* Debug *)
                    true
                | _ ->
                    false
            let v994 : US3 =
                if v990 then
                    let v991 : string = "Debug"
                    US3_0(v991)
                else
                    US3_1
            match v994 with
            | US3_1 -> (* None *)
                let v999 : bool =
                    match v0 with
                    | US0_2 -> (* Info *)
                        true
                    | _ ->
                        false
                let v1003 : US3 =
                    if v999 then
                        let v1000 : string = "Info"
                        US3_0(v1000)
                    else
                        US3_1
                match v1003 with
                | US3_1 -> (* None *)
                    let v1008 : bool =
                        match v0 with
                        | US0_3 -> (* Warning *)
                            true
                        | _ ->
                            false
                    let v1012 : US3 =
                        if v1008 then
                            let v1009 : string = "Warning"
                            US3_0(v1009)
                        else
                            US3_1
                    match v1012 with
                    | US3_1 -> (* None *)
                        let v1017 : bool =
                            match v0 with
                            | US0_4 -> (* Critical *)
                                true
                            | _ ->
                                false
                        let v1021 : US3 =
                            if v1017 then
                                let v1018 : string = "Critical"
                                US3_0(v1018)
                            else
                                US3_1
                        match v1021 with
                        | US3_1 -> (* None *)
                            US3_1
                        | US3_0(v1022) -> (* Some *)
                            US3_0(v1022)
                    | US3_0(v1013) -> (* Some *)
                        US3_0(v1013)
                | US3_0(v1004) -> (* Some *)
                    US3_0(v1004)
            | US3_0(v995) -> (* Some *)
                US3_0(v995)
        | US3_0(v986) -> (* Some *)
            US3_0(v986)
    let v1038 : string =
        match v1034 with
        | US3_1 -> (* None *)
            failwith<string> "Option does not have a value."
        | US3_0(v1035) -> (* Some *)
            v1035
    let v1041 : (unit -> string) = v1038.ToLower
    let v1042 : string = v1041 ()
    let v1051 : string = v1042.PadLeft (7, ' ')
    let v1083 : bool = true
    let mutable _v1083 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1098 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v1092 : string = "inline_colorization::color_bright_red"
            let v1093 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1092 
            v1093
        | US0_1 -> (* Debug *)
            let v1086 : string = "inline_colorization::color_bright_blue"
            let v1087 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1086 
            v1087
        | US0_2 -> (* Info *)
            let v1088 : string = "inline_colorization::color_bright_green"
            let v1089 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1088 
            v1089
        | US0_0 -> (* Verbose *)
            let v1084 : string = "inline_colorization::color_bright_black"
            let v1085 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1084 
            v1085
        | US0_3 -> (* Warning *)
            let v1090 : string = "inline_colorization::color_yellow"
            let v1091 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1090 
            v1091
    let v1099 : string = "&*$0"
    let v1100 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1051 v1099 
    let v1101 : string = "inline_colorization::color_reset"
    let v1102 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1101 
    let v1103 : string = "\"{v1098}{v1100}{v1102}\""
    let v1104 : string = @$"format!(" + v1103 + ")"
    let v1105 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v1104 
    let v1106 : string = "fable_library_rust::String_::fromString($0)"
    let v1107 : string = Fable.Core.RustInterop.emitRustExpr v1105 v1106 
    v1107 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1122 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v1116 : string = "inline_colorization::color_bright_red"
            let v1117 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1116 
            v1117
        | US0_1 -> (* Debug *)
            let v1110 : string = "inline_colorization::color_bright_blue"
            let v1111 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1110 
            v1111
        | US0_2 -> (* Info *)
            let v1112 : string = "inline_colorization::color_bright_green"
            let v1113 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1112 
            v1113
        | US0_0 -> (* Verbose *)
            let v1108 : string = "inline_colorization::color_bright_black"
            let v1109 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1108 
            v1109
        | US0_3 -> (* Warning *)
            let v1114 : string = "inline_colorization::color_yellow"
            let v1115 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1114 
            v1115
    let v1123 : string = "&*$0"
    let v1124 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1051 v1123 
    let v1125 : string = "inline_colorization::color_reset"
    let v1126 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1125 
    let v1127 : string = "\"{v1122}{v1124}{v1126}\""
    let v1128 : string = @$"format!(" + v1127 + ")"
    let v1129 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v1128 
    let v1130 : string = "fable_library_rust::String_::fromString($0)"
    let v1131 : string = Fable.Core.RustInterop.emitRustExpr v1129 v1130 
    v1131 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1146 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v1140 : string = "inline_colorization::color_bright_red"
            let v1141 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1140 
            v1141
        | US0_1 -> (* Debug *)
            let v1134 : string = "inline_colorization::color_bright_blue"
            let v1135 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1134 
            v1135
        | US0_2 -> (* Info *)
            let v1136 : string = "inline_colorization::color_bright_green"
            let v1137 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1136 
            v1137
        | US0_0 -> (* Verbose *)
            let v1132 : string = "inline_colorization::color_bright_black"
            let v1133 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1132 
            v1133
        | US0_3 -> (* Warning *)
            let v1138 : string = "inline_colorization::color_yellow"
            let v1139 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1138 
            v1139
    let v1147 : string = "&*$0"
    let v1148 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1051 v1147 
    let v1149 : string = "inline_colorization::color_reset"
    let v1150 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1149 
    let v1151 : string = "\"{v1146}{v1148}{v1150}\""
    let v1152 : string = @$"format!(" + v1151 + ")"
    let v1153 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v1152 
    let v1154 : string = "fable_library_rust::String_::fromString($0)"
    let v1155 : string = Fable.Core.RustInterop.emitRustExpr v1153 v1154 
    v1155 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1165 : string =
        match v0 with
        | US0_4 -> (* Critical *)
            let v1160 : string = "\u001b[91m"
            v1160
        | US0_1 -> (* Debug *)
            let v1157 : string = "\u001b[94m"
            v1157
        | US0_2 -> (* Info *)
            let v1158 : string = "\u001b[92m"
            v1158
        | US0_0 -> (* Verbose *)
            let v1156 : string = "\u001b[90m"
            v1156
        | US0_3 -> (* Warning *)
            let v1159 : string = "\u001b[93m"
            v1159
    let v1166 : string = method12()
    let v1167 : string = v1165 + v1051 
    let v1168 : string = v1167 + v1166 
    v1168 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1178 : string =
        match v0 with
        | US0_4 -> (* Critical *)
            let v1173 : string = "\u001b[91m"
            v1173
        | US0_1 -> (* Debug *)
            let v1170 : string = "\u001b[94m"
            v1170
        | US0_2 -> (* Info *)
            let v1171 : string = "\u001b[92m"
            v1171
        | US0_0 -> (* Verbose *)
            let v1169 : string = "\u001b[90m"
            v1169
        | US0_3 -> (* Warning *)
            let v1172 : string = "\u001b[93m"
            v1172
    let v1179 : string = method12()
    let v1180 : string = v1178 + v1051 
    let v1181 : string = v1180 + v1179 
    v1181 
    #endif
#else
    let v1191 : string =
        match v0 with
        | US0_4 -> (* Critical *)
            let v1186 : string = "\u001b[91m"
            v1186
        | US0_1 -> (* Debug *)
            let v1183 : string = "\u001b[94m"
            v1183
        | US0_2 -> (* Info *)
            let v1184 : string = "\u001b[92m"
            v1184
        | US0_0 -> (* Verbose *)
            let v1182 : string = "\u001b[90m"
            v1182
        | US0_3 -> (* Warning *)
            let v1185 : string = "\u001b[93m"
            v1185
    let v1192 : string = method12()
    let v1193 : string = v1191 + v1051 
    let v1194 : string = v1193 + v1192 
    v1194 
    #endif
    |> fun x -> _v1083 <- Some x
    let v1195 : string = match _v1083 with Some x -> x | None -> failwith "base.run_target / _v1083=None"
    let v1214 : int64 = v14.l0
    let v1215 : int32 = v2 ()
    let v1216 : string = ""
    let v1217 : Mut4 = {l0 = v1216} : Mut4
    method34(v1217, v1215)
    let v1218 : string = v1217.l0
    let v1221 : string = $"{v826} {v1195} #{v1214} %s{v1 ()} / {v1218}"
    let v1228 : char list = []
    let v1233 : (char list -> (char [])) = List.toArray
    let v1234 : (char []) = v1233 v1228
    let v1241 : string = v1221.TrimStart v1234 
    let v1280 : char list = []
    let v1283 : char list = '/' :: v1280 
    let v1292 : char list = ' ' :: v1283 
    let v1303 : (char list -> (char [])) = List.toArray
    let v1304 : (char []) = v1303 v1292
    let v1311 : string = v1241.TrimEnd v1304 
    v1311
and method33 (v0 : US0, v1 : (unit -> string), v2 : (unit -> int32)) : unit =
    let v3 : (unit -> string) = closure33(v0, v1, v2)
    method16(v0, v3)
and closure34 () () : string =
    let v0 : string = $"async.run_with_timeout_async**"
    v0
and closure35 (v0 : exn) () : struct (int32 * string) =
    let v3 : bool = true
    let mutable _v3 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v6 : string = $"%A{v0}"
    v6 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v15 : string = $"%A{v0}"
    v15 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v24 : string = $"%A{v0}"
    v24 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v33 : string = $"%A{v0}"
    v33 
    #endif
#if FABLE_COMPILER_PYTHON
    let v42 : string = $"%A{v0}"
    v42 
    #endif
#else
    let v49 : string = $"{v0.GetType ()}: {v0.Message}"
    v49 
    #endif
    |> fun x -> _v3 <- Some x
    let v50 : string = match _v3 with Some x -> x | None -> failwith "base.run_target / _v3=None"
    struct (1000, v50)
and method37 (v0 : Mut4, v1 : int32, v2 : string) : unit =
    let v3 : string = "{ "
    method14(v0, v3)
    method15(v0)
    let v4 : string = "timeout"
    method14(v0, v4)
    let v5 : string = " = "
    method14(v0, v5)
    method35(v0, v1)
    let v6 : string = "; "
    method14(v0, v6)
    let v7 : string = "ex"
    method14(v0, v7)
    method14(v0, v5)
    method14(v0, v2)
    let v8 : string = " }"
    method14(v0, v8)
and closure36 (v0 : US0, v1 : (unit -> string), v2 : (unit -> struct (int32 * string))) () : string =
    let v5 : (US0 -> struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option)) = closure0()
    let v6 : US0 = US0_0
    if State.trace_state.IsNone then State.trace_state <- v5 v6 |> Some
    let struct (v14 : Mut0, v15 : Mut1, v16 : Mut2, v17 : Mut3, v18 : int64 option) = State.trace_state.Value
    let v35 : bool = true
    let mutable _v35 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v38 : US2 option = None
    let _v38 = ref v38 
    match v18 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v39 : int64 = x
    let v40 : US2 = US2_0(v39)
    v40 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v38.Value <- x
    let v41 : US2 option = _v38.Value 
    let v64 : US2 = US2_1
    let v65 : US2 = v41 |> Option.defaultValue v64 
    let v163 : System.DateTime =
        match v65 with
        | US2_1 -> (* None *)
            let v155 : System.DateTime = System.DateTime.Now
            v155
        | US2_0(v73) -> (* Some *)
            let v76 : System.DateTime = System.DateTime.Now
            let v85 : (System.DateTime -> int64) = _.Ticks
            let v86 : int64 = v85 v76
            let v93 : int64 = v86 - v73
            let v96 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v97 : System.TimeSpan = v96 v93
            let v106 : (System.TimeSpan -> int32) = _.Hours
            let v107 : int32 = v106 v97
            let v116 : (System.TimeSpan -> int32) = _.Minutes
            let v117 : int32 = v116 v97
            let v126 : (System.TimeSpan -> int32) = _.Seconds
            let v127 : int32 = v126 v97
            let v136 : (System.TimeSpan -> int32) = _.Milliseconds
            let v137 : int32 = v136 v97
            let v146 : System.DateTime = System.DateTime (1, 1, 1, v107, v117, v127, v137)
            v146
    let v166 : string = method10()
    let v175 : (string -> string) = v163.ToString
    let v176 : string = v175 v166
    v176 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v185 : US2 option = None
    let _v185 = ref v185 
    match v18 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v186 : int64 = x
    let v187 : US2 = US2_0(v186)
    v187 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v185.Value <- x
    let v188 : US2 option = _v185.Value 
    let v211 : US2 = US2_1
    let v212 : US2 = v188 |> Option.defaultValue v211 
    let v310 : System.DateTime =
        match v212 with
        | US2_1 -> (* None *)
            let v302 : System.DateTime = System.DateTime.Now
            v302
        | US2_0(v220) -> (* Some *)
            let v223 : System.DateTime = System.DateTime.Now
            let v232 : (System.DateTime -> int64) = _.Ticks
            let v233 : int64 = v232 v223
            let v240 : int64 = v233 - v220
            let v243 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v244 : System.TimeSpan = v243 v240
            let v253 : (System.TimeSpan -> int32) = _.Hours
            let v254 : int32 = v253 v244
            let v263 : (System.TimeSpan -> int32) = _.Minutes
            let v264 : int32 = v263 v244
            let v273 : (System.TimeSpan -> int32) = _.Seconds
            let v274 : int32 = v273 v244
            let v283 : (System.TimeSpan -> int32) = _.Milliseconds
            let v284 : int32 = v283 v244
            let v293 : System.DateTime = System.DateTime (1, 1, 1, v254, v264, v274, v284)
            v293
    let v313 : string = method10()
    let v322 : (string -> string) = v310.ToString
    let v323 : string = v322 v313
    v323 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v330 : string = $"near_sdk::env::block_timestamp()"
    let v331 : uint64 = Fable.Core.RustInterop.emitRustExpr () v330 
    let v334 : US2 option = None
    let _v334 = ref v334 
    match v18 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v335 : int64 = x
    let v336 : US2 = US2_0(v335)
    v336 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v334.Value <- x
    let v337 : US2 option = _v334.Value 
    let v360 : US2 = US2_1
    let v361 : US2 = v337 |> Option.defaultValue v360 
    let v374 : uint64 =
        match v361 with
        | US2_1 -> (* None *)
            v331
        | US2_0(v369) -> (* Some *)
            let v370 : (int64 -> uint64) = uint64
            let v371 : uint64 = v370 v369
            let v372 : uint64 = v331 - v371
            v372
    let v375 : uint64 = v374 / 1000000000UL
    let v376 : uint64 = v375 % 60UL
    let v377 : uint64 = v375 / 60UL
    let v378 : uint64 = v377 % 60UL
    let v379 : uint64 = v375 / 3600UL
    let v380 : uint64 = v379 % 24UL
    let v381 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
    let v382 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v380, v378, v376) v381 
    let v383 : string = "fable_library_rust::String_::fromString($0)"
    let v384 : string = Fable.Core.RustInterop.emitRustExpr v382 v383 
    v384 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v387 : US2 option = None
    let _v387 = ref v387 
    match v18 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v388 : int64 = x
    let v389 : US2 = US2_0(v388)
    v389 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v387.Value <- x
    let v390 : US2 option = _v387.Value 
    let v413 : US2 = US2_1
    let v414 : US2 = v390 |> Option.defaultValue v413 
    let v512 : System.DateTime =
        match v414 with
        | US2_1 -> (* None *)
            let v504 : System.DateTime = System.DateTime.Now
            v504
        | US2_0(v422) -> (* Some *)
            let v425 : System.DateTime = System.DateTime.Now
            let v434 : (System.DateTime -> int64) = _.Ticks
            let v435 : int64 = v434 v425
            let v442 : int64 = v435 - v422
            let v445 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v446 : System.TimeSpan = v445 v442
            let v455 : (System.TimeSpan -> int32) = _.Hours
            let v456 : int32 = v455 v446
            let v465 : (System.TimeSpan -> int32) = _.Minutes
            let v466 : int32 = v465 v446
            let v475 : (System.TimeSpan -> int32) = _.Seconds
            let v476 : int32 = v475 v446
            let v485 : (System.TimeSpan -> int32) = _.Milliseconds
            let v486 : int32 = v485 v446
            let v495 : System.DateTime = System.DateTime (1, 1, 1, v456, v466, v476, v486)
            v495
    let v515 : string = method11()
    let v524 : (string -> string) = v512.ToString
    let v525 : string = v524 v515
    v525 
    #endif
#if FABLE_COMPILER_PYTHON
    let v534 : US2 option = None
    let _v534 = ref v534 
    match v18 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v535 : int64 = x
    let v536 : US2 = US2_0(v535)
    v536 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v534.Value <- x
    let v537 : US2 option = _v534.Value 
    let v560 : US2 = US2_1
    let v561 : US2 = v537 |> Option.defaultValue v560 
    let v659 : System.DateTime =
        match v561 with
        | US2_1 -> (* None *)
            let v651 : System.DateTime = System.DateTime.Now
            v651
        | US2_0(v569) -> (* Some *)
            let v572 : System.DateTime = System.DateTime.Now
            let v581 : (System.DateTime -> int64) = _.Ticks
            let v582 : int64 = v581 v572
            let v589 : int64 = v582 - v569
            let v592 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v593 : System.TimeSpan = v592 v589
            let v602 : (System.TimeSpan -> int32) = _.Hours
            let v603 : int32 = v602 v593
            let v612 : (System.TimeSpan -> int32) = _.Minutes
            let v613 : int32 = v612 v593
            let v622 : (System.TimeSpan -> int32) = _.Seconds
            let v623 : int32 = v622 v593
            let v632 : (System.TimeSpan -> int32) = _.Milliseconds
            let v633 : int32 = v632 v593
            let v642 : System.DateTime = System.DateTime (1, 1, 1, v603, v613, v623, v633)
            v642
    let v662 : string = method11()
    let v671 : (string -> string) = v659.ToString
    let v672 : string = v671 v662
    v672 
    #endif
#else
    let v681 : US2 option = None
    let _v681 = ref v681 
    match v18 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v682 : int64 = x
    let v683 : US2 = US2_0(v682)
    v683 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v681.Value <- x
    let v684 : US2 option = _v681.Value 
    let v707 : US2 = US2_1
    let v708 : US2 = v684 |> Option.defaultValue v707 
    let v806 : System.DateTime =
        match v708 with
        | US2_1 -> (* None *)
            let v798 : System.DateTime = System.DateTime.Now
            v798
        | US2_0(v716) -> (* Some *)
            let v719 : System.DateTime = System.DateTime.Now
            let v728 : (System.DateTime -> int64) = _.Ticks
            let v729 : int64 = v728 v719
            let v736 : int64 = v729 - v716
            let v739 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v740 : System.TimeSpan = v739 v736
            let v749 : (System.TimeSpan -> int32) = _.Hours
            let v750 : int32 = v749 v740
            let v759 : (System.TimeSpan -> int32) = _.Minutes
            let v760 : int32 = v759 v740
            let v769 : (System.TimeSpan -> int32) = _.Seconds
            let v770 : int32 = v769 v740
            let v779 : (System.TimeSpan -> int32) = _.Milliseconds
            let v780 : int32 = v779 v740
            let v789 : System.DateTime = System.DateTime (1, 1, 1, v750, v760, v770, v780)
            v789
    let v809 : string = method11()
    let v818 : (string -> string) = v806.ToString
    let v819 : string = v818 v809
    v819 
    #endif
    |> fun x -> _v35 <- Some x
    let v826 : string = match _v35 with Some x -> x | None -> failwith "base.run_target / _v35=None"
    let v981 : bool =
        match v0 with
        | US0_0 -> (* Verbose *)
            true
        | _ ->
            false
    let v985 : US3 =
        if v981 then
            let v982 : string = "Verbose"
            US3_0(v982)
        else
            US3_1
    let v1034 : US3 =
        match v985 with
        | US3_1 -> (* None *)
            let v990 : bool =
                match v0 with
                | US0_1 -> (* Debug *)
                    true
                | _ ->
                    false
            let v994 : US3 =
                if v990 then
                    let v991 : string = "Debug"
                    US3_0(v991)
                else
                    US3_1
            match v994 with
            | US3_1 -> (* None *)
                let v999 : bool =
                    match v0 with
                    | US0_2 -> (* Info *)
                        true
                    | _ ->
                        false
                let v1003 : US3 =
                    if v999 then
                        let v1000 : string = "Info"
                        US3_0(v1000)
                    else
                        US3_1
                match v1003 with
                | US3_1 -> (* None *)
                    let v1008 : bool =
                        match v0 with
                        | US0_3 -> (* Warning *)
                            true
                        | _ ->
                            false
                    let v1012 : US3 =
                        if v1008 then
                            let v1009 : string = "Warning"
                            US3_0(v1009)
                        else
                            US3_1
                    match v1012 with
                    | US3_1 -> (* None *)
                        let v1017 : bool =
                            match v0 with
                            | US0_4 -> (* Critical *)
                                true
                            | _ ->
                                false
                        let v1021 : US3 =
                            if v1017 then
                                let v1018 : string = "Critical"
                                US3_0(v1018)
                            else
                                US3_1
                        match v1021 with
                        | US3_1 -> (* None *)
                            US3_1
                        | US3_0(v1022) -> (* Some *)
                            US3_0(v1022)
                    | US3_0(v1013) -> (* Some *)
                        US3_0(v1013)
                | US3_0(v1004) -> (* Some *)
                    US3_0(v1004)
            | US3_0(v995) -> (* Some *)
                US3_0(v995)
        | US3_0(v986) -> (* Some *)
            US3_0(v986)
    let v1038 : string =
        match v1034 with
        | US3_1 -> (* None *)
            failwith<string> "Option does not have a value."
        | US3_0(v1035) -> (* Some *)
            v1035
    let v1041 : (unit -> string) = v1038.ToLower
    let v1042 : string = v1041 ()
    let v1051 : string = v1042.PadLeft (7, ' ')
    let v1083 : bool = true
    let mutable _v1083 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1098 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v1092 : string = "inline_colorization::color_bright_red"
            let v1093 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1092 
            v1093
        | US0_1 -> (* Debug *)
            let v1086 : string = "inline_colorization::color_bright_blue"
            let v1087 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1086 
            v1087
        | US0_2 -> (* Info *)
            let v1088 : string = "inline_colorization::color_bright_green"
            let v1089 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1088 
            v1089
        | US0_0 -> (* Verbose *)
            let v1084 : string = "inline_colorization::color_bright_black"
            let v1085 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1084 
            v1085
        | US0_3 -> (* Warning *)
            let v1090 : string = "inline_colorization::color_yellow"
            let v1091 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1090 
            v1091
    let v1099 : string = "&*$0"
    let v1100 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1051 v1099 
    let v1101 : string = "inline_colorization::color_reset"
    let v1102 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1101 
    let v1103 : string = "\"{v1098}{v1100}{v1102}\""
    let v1104 : string = @$"format!(" + v1103 + ")"
    let v1105 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v1104 
    let v1106 : string = "fable_library_rust::String_::fromString($0)"
    let v1107 : string = Fable.Core.RustInterop.emitRustExpr v1105 v1106 
    v1107 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1122 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v1116 : string = "inline_colorization::color_bright_red"
            let v1117 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1116 
            v1117
        | US0_1 -> (* Debug *)
            let v1110 : string = "inline_colorization::color_bright_blue"
            let v1111 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1110 
            v1111
        | US0_2 -> (* Info *)
            let v1112 : string = "inline_colorization::color_bright_green"
            let v1113 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1112 
            v1113
        | US0_0 -> (* Verbose *)
            let v1108 : string = "inline_colorization::color_bright_black"
            let v1109 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1108 
            v1109
        | US0_3 -> (* Warning *)
            let v1114 : string = "inline_colorization::color_yellow"
            let v1115 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1114 
            v1115
    let v1123 : string = "&*$0"
    let v1124 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1051 v1123 
    let v1125 : string = "inline_colorization::color_reset"
    let v1126 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1125 
    let v1127 : string = "\"{v1122}{v1124}{v1126}\""
    let v1128 : string = @$"format!(" + v1127 + ")"
    let v1129 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v1128 
    let v1130 : string = "fable_library_rust::String_::fromString($0)"
    let v1131 : string = Fable.Core.RustInterop.emitRustExpr v1129 v1130 
    v1131 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1146 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v1140 : string = "inline_colorization::color_bright_red"
            let v1141 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1140 
            v1141
        | US0_1 -> (* Debug *)
            let v1134 : string = "inline_colorization::color_bright_blue"
            let v1135 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1134 
            v1135
        | US0_2 -> (* Info *)
            let v1136 : string = "inline_colorization::color_bright_green"
            let v1137 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1136 
            v1137
        | US0_0 -> (* Verbose *)
            let v1132 : string = "inline_colorization::color_bright_black"
            let v1133 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1132 
            v1133
        | US0_3 -> (* Warning *)
            let v1138 : string = "inline_colorization::color_yellow"
            let v1139 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1138 
            v1139
    let v1147 : string = "&*$0"
    let v1148 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1051 v1147 
    let v1149 : string = "inline_colorization::color_reset"
    let v1150 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1149 
    let v1151 : string = "\"{v1146}{v1148}{v1150}\""
    let v1152 : string = @$"format!(" + v1151 + ")"
    let v1153 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v1152 
    let v1154 : string = "fable_library_rust::String_::fromString($0)"
    let v1155 : string = Fable.Core.RustInterop.emitRustExpr v1153 v1154 
    v1155 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1165 : string =
        match v0 with
        | US0_4 -> (* Critical *)
            let v1160 : string = "\u001b[91m"
            v1160
        | US0_1 -> (* Debug *)
            let v1157 : string = "\u001b[94m"
            v1157
        | US0_2 -> (* Info *)
            let v1158 : string = "\u001b[92m"
            v1158
        | US0_0 -> (* Verbose *)
            let v1156 : string = "\u001b[90m"
            v1156
        | US0_3 -> (* Warning *)
            let v1159 : string = "\u001b[93m"
            v1159
    let v1166 : string = method12()
    let v1167 : string = v1165 + v1051 
    let v1168 : string = v1167 + v1166 
    v1168 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1178 : string =
        match v0 with
        | US0_4 -> (* Critical *)
            let v1173 : string = "\u001b[91m"
            v1173
        | US0_1 -> (* Debug *)
            let v1170 : string = "\u001b[94m"
            v1170
        | US0_2 -> (* Info *)
            let v1171 : string = "\u001b[92m"
            v1171
        | US0_0 -> (* Verbose *)
            let v1169 : string = "\u001b[90m"
            v1169
        | US0_3 -> (* Warning *)
            let v1172 : string = "\u001b[93m"
            v1172
    let v1179 : string = method12()
    let v1180 : string = v1178 + v1051 
    let v1181 : string = v1180 + v1179 
    v1181 
    #endif
#else
    let v1191 : string =
        match v0 with
        | US0_4 -> (* Critical *)
            let v1186 : string = "\u001b[91m"
            v1186
        | US0_1 -> (* Debug *)
            let v1183 : string = "\u001b[94m"
            v1183
        | US0_2 -> (* Info *)
            let v1184 : string = "\u001b[92m"
            v1184
        | US0_0 -> (* Verbose *)
            let v1182 : string = "\u001b[90m"
            v1182
        | US0_3 -> (* Warning *)
            let v1185 : string = "\u001b[93m"
            v1185
    let v1192 : string = method12()
    let v1193 : string = v1191 + v1051 
    let v1194 : string = v1193 + v1192 
    v1194 
    #endif
    |> fun x -> _v1083 <- Some x
    let v1195 : string = match _v1083 with Some x -> x | None -> failwith "base.run_target / _v1083=None"
    let v1214 : int64 = v14.l0
    let struct (v1215 : int32, v1216 : string) = v2 ()
    let v1217 : string = ""
    let v1218 : Mut4 = {l0 = v1217} : Mut4
    method37(v1218, v1215, v1216)
    let v1219 : string = v1218.l0
    let v1222 : string = $"{v826} {v1195} #{v1214} %s{v1 ()} / {v1219}"
    let v1229 : char list = []
    let v1234 : (char list -> (char [])) = List.toArray
    let v1235 : (char []) = v1234 v1229
    let v1242 : string = v1222.TrimStart v1235 
    let v1281 : char list = []
    let v1284 : char list = '/' :: v1281 
    let v1293 : char list = ' ' :: v1284 
    let v1304 : (char list -> (char [])) = List.toArray
    let v1305 : (char []) = v1304 v1293
    let v1312 : string = v1242.TrimEnd v1305 
    v1312
and method36 (v0 : US0, v1 : (unit -> string), v2 : (unit -> struct (int32 * string))) : unit =
    let v3 : (unit -> string) = closure36(v0, v1, v2)
    method16(v0, v3)
and closure37 () () : string =
    let v0 : string = "read_all_text_retry_async"
    v0
and closure38 (v0 : int64, v1 : string) () : struct (int64 * string) =
    struct (v0, v1)
and method39 (v0 : Mut4, v1 : int64, v2 : string) : unit =
    let v3 : string = "{ "
    method14(v0, v3)
    method15(v0)
    let v4 : string = "retry"
    method14(v0, v4)
    let v5 : string = " = "
    method14(v0, v5)
    method20(v0, v1)
    let v6 : string = "; "
    method14(v0, v6)
    let v7 : string = "ex"
    method14(v0, v7)
    method14(v0, v5)
    method14(v0, v2)
    let v8 : string = " }"
    method14(v0, v8)
and closure39 (v0 : US0, v1 : (unit -> string), v2 : (unit -> struct (int64 * string))) () : string =
    let v5 : (US0 -> struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option)) = closure0()
    let v6 : US0 = US0_0
    if State.trace_state.IsNone then State.trace_state <- v5 v6 |> Some
    let struct (v14 : Mut0, v15 : Mut1, v16 : Mut2, v17 : Mut3, v18 : int64 option) = State.trace_state.Value
    let v35 : bool = true
    let mutable _v35 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v38 : US2 option = None
    let _v38 = ref v38 
    match v18 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v39 : int64 = x
    let v40 : US2 = US2_0(v39)
    v40 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v38.Value <- x
    let v41 : US2 option = _v38.Value 
    let v64 : US2 = US2_1
    let v65 : US2 = v41 |> Option.defaultValue v64 
    let v163 : System.DateTime =
        match v65 with
        | US2_1 -> (* None *)
            let v155 : System.DateTime = System.DateTime.Now
            v155
        | US2_0(v73) -> (* Some *)
            let v76 : System.DateTime = System.DateTime.Now
            let v85 : (System.DateTime -> int64) = _.Ticks
            let v86 : int64 = v85 v76
            let v93 : int64 = v86 - v73
            let v96 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v97 : System.TimeSpan = v96 v93
            let v106 : (System.TimeSpan -> int32) = _.Hours
            let v107 : int32 = v106 v97
            let v116 : (System.TimeSpan -> int32) = _.Minutes
            let v117 : int32 = v116 v97
            let v126 : (System.TimeSpan -> int32) = _.Seconds
            let v127 : int32 = v126 v97
            let v136 : (System.TimeSpan -> int32) = _.Milliseconds
            let v137 : int32 = v136 v97
            let v146 : System.DateTime = System.DateTime (1, 1, 1, v107, v117, v127, v137)
            v146
    let v166 : string = method10()
    let v175 : (string -> string) = v163.ToString
    let v176 : string = v175 v166
    v176 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v185 : US2 option = None
    let _v185 = ref v185 
    match v18 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v186 : int64 = x
    let v187 : US2 = US2_0(v186)
    v187 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v185.Value <- x
    let v188 : US2 option = _v185.Value 
    let v211 : US2 = US2_1
    let v212 : US2 = v188 |> Option.defaultValue v211 
    let v310 : System.DateTime =
        match v212 with
        | US2_1 -> (* None *)
            let v302 : System.DateTime = System.DateTime.Now
            v302
        | US2_0(v220) -> (* Some *)
            let v223 : System.DateTime = System.DateTime.Now
            let v232 : (System.DateTime -> int64) = _.Ticks
            let v233 : int64 = v232 v223
            let v240 : int64 = v233 - v220
            let v243 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v244 : System.TimeSpan = v243 v240
            let v253 : (System.TimeSpan -> int32) = _.Hours
            let v254 : int32 = v253 v244
            let v263 : (System.TimeSpan -> int32) = _.Minutes
            let v264 : int32 = v263 v244
            let v273 : (System.TimeSpan -> int32) = _.Seconds
            let v274 : int32 = v273 v244
            let v283 : (System.TimeSpan -> int32) = _.Milliseconds
            let v284 : int32 = v283 v244
            let v293 : System.DateTime = System.DateTime (1, 1, 1, v254, v264, v274, v284)
            v293
    let v313 : string = method10()
    let v322 : (string -> string) = v310.ToString
    let v323 : string = v322 v313
    v323 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v330 : string = $"near_sdk::env::block_timestamp()"
    let v331 : uint64 = Fable.Core.RustInterop.emitRustExpr () v330 
    let v334 : US2 option = None
    let _v334 = ref v334 
    match v18 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v335 : int64 = x
    let v336 : US2 = US2_0(v335)
    v336 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v334.Value <- x
    let v337 : US2 option = _v334.Value 
    let v360 : US2 = US2_1
    let v361 : US2 = v337 |> Option.defaultValue v360 
    let v374 : uint64 =
        match v361 with
        | US2_1 -> (* None *)
            v331
        | US2_0(v369) -> (* Some *)
            let v370 : (int64 -> uint64) = uint64
            let v371 : uint64 = v370 v369
            let v372 : uint64 = v331 - v371
            v372
    let v375 : uint64 = v374 / 1000000000UL
    let v376 : uint64 = v375 % 60UL
    let v377 : uint64 = v375 / 60UL
    let v378 : uint64 = v377 % 60UL
    let v379 : uint64 = v375 / 3600UL
    let v380 : uint64 = v379 % 24UL
    let v381 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
    let v382 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v380, v378, v376) v381 
    let v383 : string = "fable_library_rust::String_::fromString($0)"
    let v384 : string = Fable.Core.RustInterop.emitRustExpr v382 v383 
    v384 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v387 : US2 option = None
    let _v387 = ref v387 
    match v18 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v388 : int64 = x
    let v389 : US2 = US2_0(v388)
    v389 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v387.Value <- x
    let v390 : US2 option = _v387.Value 
    let v413 : US2 = US2_1
    let v414 : US2 = v390 |> Option.defaultValue v413 
    let v512 : System.DateTime =
        match v414 with
        | US2_1 -> (* None *)
            let v504 : System.DateTime = System.DateTime.Now
            v504
        | US2_0(v422) -> (* Some *)
            let v425 : System.DateTime = System.DateTime.Now
            let v434 : (System.DateTime -> int64) = _.Ticks
            let v435 : int64 = v434 v425
            let v442 : int64 = v435 - v422
            let v445 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v446 : System.TimeSpan = v445 v442
            let v455 : (System.TimeSpan -> int32) = _.Hours
            let v456 : int32 = v455 v446
            let v465 : (System.TimeSpan -> int32) = _.Minutes
            let v466 : int32 = v465 v446
            let v475 : (System.TimeSpan -> int32) = _.Seconds
            let v476 : int32 = v475 v446
            let v485 : (System.TimeSpan -> int32) = _.Milliseconds
            let v486 : int32 = v485 v446
            let v495 : System.DateTime = System.DateTime (1, 1, 1, v456, v466, v476, v486)
            v495
    let v515 : string = method11()
    let v524 : (string -> string) = v512.ToString
    let v525 : string = v524 v515
    v525 
    #endif
#if FABLE_COMPILER_PYTHON
    let v534 : US2 option = None
    let _v534 = ref v534 
    match v18 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v535 : int64 = x
    let v536 : US2 = US2_0(v535)
    v536 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v534.Value <- x
    let v537 : US2 option = _v534.Value 
    let v560 : US2 = US2_1
    let v561 : US2 = v537 |> Option.defaultValue v560 
    let v659 : System.DateTime =
        match v561 with
        | US2_1 -> (* None *)
            let v651 : System.DateTime = System.DateTime.Now
            v651
        | US2_0(v569) -> (* Some *)
            let v572 : System.DateTime = System.DateTime.Now
            let v581 : (System.DateTime -> int64) = _.Ticks
            let v582 : int64 = v581 v572
            let v589 : int64 = v582 - v569
            let v592 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v593 : System.TimeSpan = v592 v589
            let v602 : (System.TimeSpan -> int32) = _.Hours
            let v603 : int32 = v602 v593
            let v612 : (System.TimeSpan -> int32) = _.Minutes
            let v613 : int32 = v612 v593
            let v622 : (System.TimeSpan -> int32) = _.Seconds
            let v623 : int32 = v622 v593
            let v632 : (System.TimeSpan -> int32) = _.Milliseconds
            let v633 : int32 = v632 v593
            let v642 : System.DateTime = System.DateTime (1, 1, 1, v603, v613, v623, v633)
            v642
    let v662 : string = method11()
    let v671 : (string -> string) = v659.ToString
    let v672 : string = v671 v662
    v672 
    #endif
#else
    let v681 : US2 option = None
    let _v681 = ref v681 
    match v18 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v682 : int64 = x
    let v683 : US2 = US2_0(v682)
    v683 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v681.Value <- x
    let v684 : US2 option = _v681.Value 
    let v707 : US2 = US2_1
    let v708 : US2 = v684 |> Option.defaultValue v707 
    let v806 : System.DateTime =
        match v708 with
        | US2_1 -> (* None *)
            let v798 : System.DateTime = System.DateTime.Now
            v798
        | US2_0(v716) -> (* Some *)
            let v719 : System.DateTime = System.DateTime.Now
            let v728 : (System.DateTime -> int64) = _.Ticks
            let v729 : int64 = v728 v719
            let v736 : int64 = v729 - v716
            let v739 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v740 : System.TimeSpan = v739 v736
            let v749 : (System.TimeSpan -> int32) = _.Hours
            let v750 : int32 = v749 v740
            let v759 : (System.TimeSpan -> int32) = _.Minutes
            let v760 : int32 = v759 v740
            let v769 : (System.TimeSpan -> int32) = _.Seconds
            let v770 : int32 = v769 v740
            let v779 : (System.TimeSpan -> int32) = _.Milliseconds
            let v780 : int32 = v779 v740
            let v789 : System.DateTime = System.DateTime (1, 1, 1, v750, v760, v770, v780)
            v789
    let v809 : string = method11()
    let v818 : (string -> string) = v806.ToString
    let v819 : string = v818 v809
    v819 
    #endif
    |> fun x -> _v35 <- Some x
    let v826 : string = match _v35 with Some x -> x | None -> failwith "base.run_target / _v35=None"
    let v981 : bool =
        match v0 with
        | US0_0 -> (* Verbose *)
            true
        | _ ->
            false
    let v985 : US3 =
        if v981 then
            let v982 : string = "Verbose"
            US3_0(v982)
        else
            US3_1
    let v1034 : US3 =
        match v985 with
        | US3_1 -> (* None *)
            let v990 : bool =
                match v0 with
                | US0_1 -> (* Debug *)
                    true
                | _ ->
                    false
            let v994 : US3 =
                if v990 then
                    let v991 : string = "Debug"
                    US3_0(v991)
                else
                    US3_1
            match v994 with
            | US3_1 -> (* None *)
                let v999 : bool =
                    match v0 with
                    | US0_2 -> (* Info *)
                        true
                    | _ ->
                        false
                let v1003 : US3 =
                    if v999 then
                        let v1000 : string = "Info"
                        US3_0(v1000)
                    else
                        US3_1
                match v1003 with
                | US3_1 -> (* None *)
                    let v1008 : bool =
                        match v0 with
                        | US0_3 -> (* Warning *)
                            true
                        | _ ->
                            false
                    let v1012 : US3 =
                        if v1008 then
                            let v1009 : string = "Warning"
                            US3_0(v1009)
                        else
                            US3_1
                    match v1012 with
                    | US3_1 -> (* None *)
                        let v1017 : bool =
                            match v0 with
                            | US0_4 -> (* Critical *)
                                true
                            | _ ->
                                false
                        let v1021 : US3 =
                            if v1017 then
                                let v1018 : string = "Critical"
                                US3_0(v1018)
                            else
                                US3_1
                        match v1021 with
                        | US3_1 -> (* None *)
                            US3_1
                        | US3_0(v1022) -> (* Some *)
                            US3_0(v1022)
                    | US3_0(v1013) -> (* Some *)
                        US3_0(v1013)
                | US3_0(v1004) -> (* Some *)
                    US3_0(v1004)
            | US3_0(v995) -> (* Some *)
                US3_0(v995)
        | US3_0(v986) -> (* Some *)
            US3_0(v986)
    let v1038 : string =
        match v1034 with
        | US3_1 -> (* None *)
            failwith<string> "Option does not have a value."
        | US3_0(v1035) -> (* Some *)
            v1035
    let v1041 : (unit -> string) = v1038.ToLower
    let v1042 : string = v1041 ()
    let v1051 : string = v1042.PadLeft (7, ' ')
    let v1083 : bool = true
    let mutable _v1083 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1098 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v1092 : string = "inline_colorization::color_bright_red"
            let v1093 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1092 
            v1093
        | US0_1 -> (* Debug *)
            let v1086 : string = "inline_colorization::color_bright_blue"
            let v1087 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1086 
            v1087
        | US0_2 -> (* Info *)
            let v1088 : string = "inline_colorization::color_bright_green"
            let v1089 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1088 
            v1089
        | US0_0 -> (* Verbose *)
            let v1084 : string = "inline_colorization::color_bright_black"
            let v1085 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1084 
            v1085
        | US0_3 -> (* Warning *)
            let v1090 : string = "inline_colorization::color_yellow"
            let v1091 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1090 
            v1091
    let v1099 : string = "&*$0"
    let v1100 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1051 v1099 
    let v1101 : string = "inline_colorization::color_reset"
    let v1102 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1101 
    let v1103 : string = "\"{v1098}{v1100}{v1102}\""
    let v1104 : string = @$"format!(" + v1103 + ")"
    let v1105 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v1104 
    let v1106 : string = "fable_library_rust::String_::fromString($0)"
    let v1107 : string = Fable.Core.RustInterop.emitRustExpr v1105 v1106 
    v1107 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1122 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v1116 : string = "inline_colorization::color_bright_red"
            let v1117 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1116 
            v1117
        | US0_1 -> (* Debug *)
            let v1110 : string = "inline_colorization::color_bright_blue"
            let v1111 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1110 
            v1111
        | US0_2 -> (* Info *)
            let v1112 : string = "inline_colorization::color_bright_green"
            let v1113 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1112 
            v1113
        | US0_0 -> (* Verbose *)
            let v1108 : string = "inline_colorization::color_bright_black"
            let v1109 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1108 
            v1109
        | US0_3 -> (* Warning *)
            let v1114 : string = "inline_colorization::color_yellow"
            let v1115 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1114 
            v1115
    let v1123 : string = "&*$0"
    let v1124 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1051 v1123 
    let v1125 : string = "inline_colorization::color_reset"
    let v1126 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1125 
    let v1127 : string = "\"{v1122}{v1124}{v1126}\""
    let v1128 : string = @$"format!(" + v1127 + ")"
    let v1129 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v1128 
    let v1130 : string = "fable_library_rust::String_::fromString($0)"
    let v1131 : string = Fable.Core.RustInterop.emitRustExpr v1129 v1130 
    v1131 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1146 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v1140 : string = "inline_colorization::color_bright_red"
            let v1141 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1140 
            v1141
        | US0_1 -> (* Debug *)
            let v1134 : string = "inline_colorization::color_bright_blue"
            let v1135 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1134 
            v1135
        | US0_2 -> (* Info *)
            let v1136 : string = "inline_colorization::color_bright_green"
            let v1137 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1136 
            v1137
        | US0_0 -> (* Verbose *)
            let v1132 : string = "inline_colorization::color_bright_black"
            let v1133 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1132 
            v1133
        | US0_3 -> (* Warning *)
            let v1138 : string = "inline_colorization::color_yellow"
            let v1139 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1138 
            v1139
    let v1147 : string = "&*$0"
    let v1148 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1051 v1147 
    let v1149 : string = "inline_colorization::color_reset"
    let v1150 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1149 
    let v1151 : string = "\"{v1146}{v1148}{v1150}\""
    let v1152 : string = @$"format!(" + v1151 + ")"
    let v1153 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v1152 
    let v1154 : string = "fable_library_rust::String_::fromString($0)"
    let v1155 : string = Fable.Core.RustInterop.emitRustExpr v1153 v1154 
    v1155 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1165 : string =
        match v0 with
        | US0_4 -> (* Critical *)
            let v1160 : string = "\u001b[91m"
            v1160
        | US0_1 -> (* Debug *)
            let v1157 : string = "\u001b[94m"
            v1157
        | US0_2 -> (* Info *)
            let v1158 : string = "\u001b[92m"
            v1158
        | US0_0 -> (* Verbose *)
            let v1156 : string = "\u001b[90m"
            v1156
        | US0_3 -> (* Warning *)
            let v1159 : string = "\u001b[93m"
            v1159
    let v1166 : string = method12()
    let v1167 : string = v1165 + v1051 
    let v1168 : string = v1167 + v1166 
    v1168 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1178 : string =
        match v0 with
        | US0_4 -> (* Critical *)
            let v1173 : string = "\u001b[91m"
            v1173
        | US0_1 -> (* Debug *)
            let v1170 : string = "\u001b[94m"
            v1170
        | US0_2 -> (* Info *)
            let v1171 : string = "\u001b[92m"
            v1171
        | US0_0 -> (* Verbose *)
            let v1169 : string = "\u001b[90m"
            v1169
        | US0_3 -> (* Warning *)
            let v1172 : string = "\u001b[93m"
            v1172
    let v1179 : string = method12()
    let v1180 : string = v1178 + v1051 
    let v1181 : string = v1180 + v1179 
    v1181 
    #endif
#else
    let v1191 : string =
        match v0 with
        | US0_4 -> (* Critical *)
            let v1186 : string = "\u001b[91m"
            v1186
        | US0_1 -> (* Debug *)
            let v1183 : string = "\u001b[94m"
            v1183
        | US0_2 -> (* Info *)
            let v1184 : string = "\u001b[92m"
            v1184
        | US0_0 -> (* Verbose *)
            let v1182 : string = "\u001b[90m"
            v1182
        | US0_3 -> (* Warning *)
            let v1185 : string = "\u001b[93m"
            v1185
    let v1192 : string = method12()
    let v1193 : string = v1191 + v1051 
    let v1194 : string = v1193 + v1192 
    v1194 
    #endif
    |> fun x -> _v1083 <- Some x
    let v1195 : string = match _v1083 with Some x -> x | None -> failwith "base.run_target / _v1083=None"
    let v1214 : int64 = v14.l0
    let struct (v1215 : int64, v1216 : string) = v2 ()
    let v1217 : string = ""
    let v1218 : Mut4 = {l0 = v1217} : Mut4
    method39(v1218, v1215, v1216)
    let v1219 : string = v1218.l0
    let v1222 : string = $"{v826} {v1195} #{v1214} %s{v1 ()} / {v1219}"
    let v1229 : char list = []
    let v1234 : (char list -> (char [])) = List.toArray
    let v1235 : (char []) = v1234 v1229
    let v1242 : string = v1222.TrimStart v1235 
    let v1281 : char list = []
    let v1284 : char list = '/' :: v1281 
    let v1293 : char list = ' ' :: v1284 
    let v1304 : (char list -> (char [])) = List.toArray
    let v1305 : (char []) = v1304 v1293
    let v1312 : string = v1242.TrimEnd v1305 
    v1312
and method38 (v0 : US0, v1 : (unit -> string), v2 : (unit -> struct (int64 * string))) : unit =
    let v3 : (unit -> string) = closure39(v0, v1, v2)
    method16(v0, v3)
and method32 (v0 : string, v1 : int64) : Async<string option> =
    let v4 : bool = true
    let mutable _v4 : Async<string option> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v7 : Async<string option> = null |> unbox<Async<string option>>
    v7 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v16 : Async<string option> = null |> unbox<Async<string option>>
    v16 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v25 : Async<string option> = null |> unbox<Async<string option>>
    v25 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v34 : Async<string option> = null |> unbox<Async<string option>>
    v34 
    #endif
#if FABLE_COMPILER_PYTHON
    let v43 : Async<string option> = null |> unbox<Async<string option>>
    v43 
    #endif
#else
    let v50 : Async<string option> option = None
    let mutable _v50 = v50 
    async {
    try
    let v51 : bool = v1 > 0L
    if v51 then
        let v54 : bool = true
        let mutable _v54 : Async<int64> option = None 
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v57 : Async<int64> = null |> unbox<Async<int64>>
        v57 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v66 : Async<int64> = null |> unbox<Async<int64>>
        v66 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v75 : Async<int64> = null |> unbox<Async<int64>>
        v75 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v84 : Async<int64> = null |> unbox<Async<int64>>
        v84 
        #endif
#if FABLE_COMPILER_PYTHON
        let v93 : Async<int64> = null |> unbox<Async<int64>>
        v93 
        #endif
#else
        let v100 : int64 = 0L
        let v101 : Async<int64> = method21(v0, v100)
        v101 
        #endif
        |> fun x -> _v54 <- Some x
        let v102 : Async<int64> = match _v54 with Some x -> x | None -> failwith "base.run_target / _v54=None"
        let v119 : bool = true
        let mutable _v119 : Async<US2> option = None 
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v122 : Async<US2> = null |> unbox<Async<US2>>
        v122 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v131 : Async<US2> = null |> unbox<Async<US2>>
        v131 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v140 : Async<US2> = null |> unbox<Async<US2>>
        v140 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v149 : Async<US2> = null |> unbox<Async<US2>>
        v149 
        #endif
#if FABLE_COMPILER_PYTHON
        let v158 : Async<US2> = null |> unbox<Async<US2>>
        v158 
        #endif
#else
        let v167 : bool = true
        let mutable _v167 : Async<US2> option = None 
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v170 : Async<US2> = null |> unbox<Async<US2>>
        v170 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v179 : Async<US2> = null |> unbox<Async<US2>>
        v179 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v188 : Async<US2> = null |> unbox<Async<US2>>
        v188 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v197 : Async<US2> = null |> unbox<Async<US2>>
        v197 
        #endif
#if FABLE_COMPILER_PYTHON
        let v206 : Async<US2> = null |> unbox<Async<US2>>
        v206 
        #endif
#else
        let v213 : Async<US2> option = None
        let mutable _v213 = v213 
        async {
        let v216 : bool = true
        let mutable _v216 : Async<Async<int64>> option = None 
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v219 : Async<Async<int64>> = null |> unbox<Async<Async<int64>>>
        v219 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v228 : Async<Async<int64>> = null |> unbox<Async<Async<int64>>>
        v228 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v237 : Async<Async<int64>> = null |> unbox<Async<Async<int64>>>
        v237 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v246 : Async<Async<int64>> = null |> unbox<Async<Async<int64>>>
        v246 
        #endif
#if FABLE_COMPILER_PYTHON
        let v255 : Async<Async<int64>> = null |> unbox<Async<Async<int64>>>
        v255 
        #endif
#else
        let v262 : Async<Async<int64>> = Async.StartChild (v102, 1000)
        v262 
        #endif
        |> fun x -> _v216 <- Some x
        let v263 : Async<Async<int64>> = match _v216 with Some x -> x | None -> failwith "base.run_target / _v216=None"
        let! v263 = v263 
        let v278 : Async<int64> = v263 
        let v281 : bool = true
        let mutable _v281 : Async<Choice<int64, exn>> option = None 
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v284 : Async<Choice<int64, exn>> = null |> unbox<Async<Choice<int64, exn>>>
        v284 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v293 : Async<Choice<int64, exn>> = null |> unbox<Async<Choice<int64, exn>>>
        v293 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v302 : Async<Choice<int64, exn>> = null |> unbox<Async<Choice<int64, exn>>>
        v302 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v311 : Async<Choice<int64, exn>> = null |> unbox<Async<Choice<int64, exn>>>
        v311 
        #endif
#if FABLE_COMPILER_PYTHON
        let v320 : Async<Choice<int64, exn>> = null |> unbox<Async<Choice<int64, exn>>>
        v320 
        #endif
#else
        let v327 : (Async<int64> -> Async<Choice<int64, exn>>) = Async.Catch
        let v328 : Async<Choice<int64, exn>> = v327 v278
        v328 
        #endif
        |> fun x -> _v281 <- Some x
        let v329 : Async<Choice<int64, exn>> = match _v281 with Some x -> x | None -> failwith "base.run_target / _v281=None"
        let v346 : bool = true
        let mutable _v346 : Async<US9> option = None 
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v349 : Async<US9> = null |> unbox<Async<US9>>
        v349 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v358 : Async<US9> = null |> unbox<Async<US9>>
        v358 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v367 : Async<US9> = null |> unbox<Async<US9>>
        v367 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v376 : Async<US9> = null |> unbox<Async<US9>>
        v376 
        #endif
#if FABLE_COMPILER_PYTHON
        let v385 : Async<US9> = null |> unbox<Async<US9>>
        v385 
        #endif
#else
        let v392 : Async<US9> option = None
        let mutable _v392 = v392 
        async {
        let! v329 = v329 
        let v393 : Choice<int64, exn> = v329 
        let v396 : bool = true
        let mutable _v396 : US9 option = None 
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v399 : US9 = null |> unbox<US9>
        v399 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v408 : US9 = null |> unbox<US9>
        v408 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v417 : US9 = null |> unbox<US9>
        v417 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v426 : US9 = null |> unbox<US9>
        v426 
        #endif
#if FABLE_COMPILER_PYTHON
        let v435 : US9 = null |> unbox<US9>
        v435 
        #endif
#else
        let v442 : (int64 -> US9) = closure29()
        let v443 : (exn -> US9) = closure30()
        let v444 : US9 = match v393 with Choice1Of2 x -> v442 x | Choice2Of2 x -> v443 x
        v444 
        #endif
        |> fun x -> _v396 <- Some x
        let v445 : US9 = match _v396 with Some x -> x | None -> failwith "base.run_target / _v396=None"
        return v445 
        }
        |> fun x -> _v392 <- Some x
        let v460 : Async<US9> = match _v392 with Some x -> x | None -> failwith "async.new_async_unit / _v392=None"
        v460 
        #endif
        |> fun x -> _v346 <- Some x
        let v461 : Async<US9> = match _v346 with Some x -> x | None -> failwith "base.run_target / _v346=None"
        let v478 : bool = true
        let mutable _v478 : Async<US10> option = None 
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v481 : Async<US10> = null |> unbox<Async<US10>>
        v481 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v490 : Async<US10> = null |> unbox<Async<US10>>
        v490 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v499 : Async<US10> = null |> unbox<Async<US10>>
        v499 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v508 : Async<US10> = null |> unbox<Async<US10>>
        v508 
        #endif
#if FABLE_COMPILER_PYTHON
        let v517 : Async<US10> = null |> unbox<Async<US10>>
        v517 
        #endif
#else
        let v524 : Async<US10> option = None
        let mutable _v524 = v524 
        async {
        let! v461 = v461 
        let v525 : US9 = v461 
        let v531 : US10 =
            match v525 with
            | US9_0(v526) -> (* C1of2 *)
                US10_0(v526)
            | US9_1(v528) -> (* C2of2 *)
                US10_1(v528)
        return v531 
        }
        |> fun x -> _v524 <- Some x
        let v532 : Async<US10> = match _v524 with Some x -> x | None -> failwith "async.new_async_unit / _v524=None"
        v532 
        #endif
        |> fun x -> _v478 <- Some x
        let v533 : Async<US10> = match _v478 with Some x -> x | None -> failwith "base.run_target / _v478=None"
        let v550 : bool = true
        let mutable _v550 : Async<US2> option = None 
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v553 : Async<US2> = null |> unbox<Async<US2>>
        v553 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v562 : Async<US2> = null |> unbox<Async<US2>>
        v562 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v571 : Async<US2> = null |> unbox<Async<US2>>
        v571 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v580 : Async<US2> = null |> unbox<Async<US2>>
        v580 
        #endif
#if FABLE_COMPILER_PYTHON
        let v589 : Async<US2> = null |> unbox<Async<US2>>
        v589 
        #endif
#else
        let v596 : Async<US2> option = None
        let mutable _v596 = v596 
        async {
        let! v533 = v533 
        let v597 : US10 = v533 
        let v630 : US2 =
            match v597 with
            | US10_1(v600) -> (* Error *)
                let v603 : string = $"%A{v600}"
                let v612 : string = "System.TimeoutException"
                let v613 : bool = v603.Contains v612 
                if v613 then
                    let v620 : US0 = US0_0
                    let v621 : (unit -> string) = closure31()
                    let v622 : (unit -> int32) = closure32()
                    method33(v620, v621, v622)
                    US2_1
                else
                    let v624 : US0 = US0_4
                    let v625 : (unit -> string) = closure34()
                    let v626 : (unit -> struct (int32 * string)) = closure35(v600)
                    method36(v624, v625, v626)
                    US2_1
            | US10_0(v598) -> (* Ok *)
                US2_0(v598)
        return v630 
        }
        |> fun x -> _v596 <- Some x
        let v631 : Async<US2> = match _v596 with Some x -> x | None -> failwith "async.new_async_unit / _v596=None"
        v631 
        #endif
        |> fun x -> _v550 <- Some x
        let v632 : Async<US2> = match _v550 with Some x -> x | None -> failwith "base.run_target / _v550=None"
        return! v632 
        }
        |> fun x -> _v213 <- Some x
        let v647 : Async<US2> = match _v213 with Some x -> x | None -> failwith "async.new_async_unit / _v213=None"
        v647 
        #endif
        |> fun x -> _v167 <- Some x
        let v648 : Async<US2> = match _v167 with Some x -> x | None -> failwith "base.run_target / _v167=None"
        v648 
        #endif
        |> fun x -> _v119 <- Some x
        let v663 : Async<US2> = match _v119 with Some x -> x | None -> failwith "base.run_target / _v119=None"
        let v680 : bool = true
        let mutable _v680 : Async<unit> option = None 
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v683 : Async<unit> = null |> unbox<Async<unit>>
        v683 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v692 : Async<unit> = null |> unbox<Async<unit>>
        v692 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v701 : Async<unit> = null |> unbox<Async<unit>>
        v701 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v710 : Async<unit> = null |> unbox<Async<unit>>
        v710 
        #endif
#if FABLE_COMPILER_PYTHON
        let v719 : Async<unit> = null |> unbox<Async<unit>>
        v719 
        #endif
#else
        let v726 : (Async<US2> -> Async<unit>) = Async.Ignore
        let v727 : Async<unit> = v726 v663
        v727 
        #endif
        |> fun x -> _v680 <- Some x
        let v728 : Async<unit> = match _v680 with Some x -> x | None -> failwith "base.run_target / _v680=None"
        do! v728 
        ()
    let v745 : bool = true
    let mutable _v745 : Async<string> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v748 : Async<string> = null |> unbox<Async<string>>
    v748 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v757 : Async<string> = null |> unbox<Async<string>>
    v757 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v766 : Async<string> = null |> unbox<Async<string>>
    v766 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v775 : Async<string> = null |> unbox<Async<string>>
    v775 
    #endif
#if FABLE_COMPILER_PYTHON
    let v784 : Async<string> = null |> unbox<Async<string>>
    v784 
    #endif
#else
    let v791 : (string -> System.Threading.Tasks.Task<string>) = System.IO.File.ReadAllTextAsync
    let v792 : System.Threading.Tasks.Task<string> = v791 v0
    let v795 : bool = true
    let mutable _v795 : Async<string> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v798 : Async<string> = null |> unbox<Async<string>>
    v798 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v807 : Async<string> = null |> unbox<Async<string>>
    v807 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v816 : Async<string> = null |> unbox<Async<string>>
    v816 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v825 : Async<string> = null |> unbox<Async<string>>
    v825 
    #endif
#if FABLE_COMPILER_PYTHON
    let v834 : Async<string> = null |> unbox<Async<string>>
    v834 
    #endif
#else
    let v841 : (System.Threading.Tasks.Task<string> -> Async<string>) = Async.AwaitTask
    let v842 : Async<string> = v841 v792
    v842 
    #endif
    |> fun x -> _v795 <- Some x
    let v843 : Async<string> = match _v795 with Some x -> x | None -> failwith "base.run_target / _v795=None"
    v843 
    #endif
    |> fun x -> _v745 <- Some x
    let v858 : Async<string> = match _v745 with Some x -> x | None -> failwith "base.run_target / _v745=None"
    let v875 : bool = true
    let mutable _v875 : Async<string option> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v878 : Async<string option> = null |> unbox<Async<string option>>
    v878 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v887 : Async<string option> = null |> unbox<Async<string option>>
    v887 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v896 : Async<string option> = null |> unbox<Async<string option>>
    v896 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v905 : Async<string option> = null |> unbox<Async<string option>>
    v905 
    #endif
#if FABLE_COMPILER_PYTHON
    let v914 : Async<string option> = null |> unbox<Async<string option>>
    v914 
    #endif
#else
    let v921 : Async<string option> option = None
    let mutable _v921 = v921 
    async {
    let! v858 = v858 
    let v922 : string = v858 
    let v925 : string option = Some v922 
    return v925 
    }
    |> fun x -> _v921 <- Some x
    let v932 : Async<string option> = match _v921 with Some x -> x | None -> failwith "async.new_async_unit / _v921=None"
    v932 
    #endif
    |> fun x -> _v875 <- Some x
    let v933 : Async<string option> = match _v875 with Some x -> x | None -> failwith "base.run_target / _v875=None"
    return! v933 
    with ex ->
    let v948 : exn = ex
    let v949 : bool = v1 = 0L
    let v950 : bool = v949 <> true
    if v950 then
        let v953 : bool = true
        let mutable _v953 : string option = None 
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v956 : string = $"%A{v948}"
        v956 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v965 : string = $"%A{v948}"
        v965 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v974 : string = $"%A{v948}"
        v974 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v983 : string = $"%A{v948}"
        v983 
        #endif
#if FABLE_COMPILER_PYTHON
        let v992 : string = $"%A{v948}"
        v992 
        #endif
#else
        let v999 : string = $"{v948.GetType ()}: {v948.Message}"
        v999 
        #endif
        |> fun x -> _v953 <- Some x
        let v1000 : string = match _v953 with Some x -> x | None -> failwith "base.run_target / _v953=None"
        let v1015 : US0 = US0_1
        let v1016 : (unit -> string) = closure37()
        let v1017 : (unit -> struct (int64 * string)) = closure38(v1, v1000)
        method38(v1015, v1016, v1017)
        let v1018 : string option = None
        return v1018 
        (*
        ()
    else
        *) else
        let v1019 : int64 = v1 + 1L
        let v1020 : Async<string option> = method32(v0, v1019)
        return! v1020 
        (*
        ()
    *)
    (*
    let v1021 : string option = *)
    }
    |> fun x -> _v50 <- Some x
    let v1022 : Async<string option> = match _v50 with Some x -> x | None -> failwith "async.new_async_unit / _v50=None"
    v1022 
    #endif
    |> fun x -> _v4 <- Some x
    let v1023 : Async<string option> = match _v4 with Some x -> x | None -> failwith "base.run_target / _v4=None"
    v1023
and closure28 () (v0 : string) : Async<string option> =
    let v3 : bool = true
    let mutable _v3 : Async<string option> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v6 : Async<string option> = null |> unbox<Async<string option>>
    v6 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v15 : Async<string option> = null |> unbox<Async<string option>>
    v15 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v24 : Async<string option> = null |> unbox<Async<string option>>
    v24 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v33 : Async<string option> = null |> unbox<Async<string option>>
    v33 
    #endif
#if FABLE_COMPILER_PYTHON
    let v42 : Async<string option> = null |> unbox<Async<string option>>
    v42 
    #endif
#else
    let v49 : int64 = 0L
    let v50 : Async<string option> = method32(v0, v49)
    v50 
    #endif
    |> fun x -> _v3 <- Some x
    let v51 : Async<string option> = match _v3 with Some x -> x | None -> failwith "base.run_target / _v3=None"
    v51
and method42 () : string =
    let v0 : string = "hh:mm"
    v0
and method43 () : string =
    let v0 : string = "yyyyMMdd-HHmm-ssff-ffff-f"
    v0
and method44 () : string =
    let v0 : string = "hhmm"
    v0
and method41 (v0 : System.Guid, v1 : System.DateTime) : System.Guid =
    let v4 : bool = true
    let mutable _v4 : System.Guid option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v7 : System.DateTime = System.DateTime (1970, 1, 1, 0, 0, 0, System.DateTimeKind.Utc)
    let v16 : (System.DateTime -> System.DateTime) = _.ToUniversalTime()
    let v17 : System.DateTime = v16 v7
    let v24 : System.DateTimeKind = System.DateTimeKind.Local
    let v25 : System.DateTime = System.DateTime.SpecifyKind (v1, v24)
    let v28 : (System.DateTime -> System.DateTime) = _.ToUniversalTime()
    let v29 : System.DateTime = v28 v25
    let v38 : (System.DateTime -> int64) = _.Ticks
    let v39 : int64 = v38 v29
    let v48 : (System.DateTime -> int64) = _.Ticks
    let v49 : int64 = v48 v17
    let v56 : int64 = v39 - v49
    let v57 : int64 = v56 / 10L
    let v58 : string = "chrono::DateTime::from_timestamp_micros($0)"
    let v59 : chrono_DateTime<chrono_Utc> option = Fable.Core.RustInterop.emitRustExpr v57 v58 
    let v62 : US11 option = None
    let _v62 = ref v62 
    match v59 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v63 : chrono_DateTime<chrono_Utc> = x
    let v64 : US11 = US11_0(v63)
    v64 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v62.Value <- x
    let v65 : US11 option = _v62.Value 
    let v88 : US11 = US11_1
    let v89 : US11 = v65 |> Option.defaultValue v88 
    let v113 : US3 =
        match v89 with
        | US11_1 -> (* None *)
            US3_1
        | US11_0(v97) -> (* Some *)
            let v98 : string = "$0.naive_utc()"
            let v99 : chrono_NaiveDateTime = Fable.Core.RustInterop.emitRustExpr v97 v98 
            let v100 : string = "chrono::offset::TimeZone::from_utc_datetime(&chrono::Local, &$0)"
            let v101 : chrono_DateTime<chrono_Local> = Fable.Core.RustInterop.emitRustExpr v99 v100 
            let v102 : string = "%Y%m%d-%H%M-%S%f"
            let v103 : string = "r#\"" + v102 + "\"#"
            let v104 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v103 
            let v105 : string = "$0.format($1).to_string()"
            let v106 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v101, v104) v105 
            let v107 : string = "fable_library_rust::String_::fromString($0)"
            let v108 : string = Fable.Core.RustInterop.emitRustExpr v106 v107 
            let v109 : string = $"{v108.[0..17]}-{v108.[18..21]}-{v108.[22]}"
            US3_0(v109)
    let v117 : string =
        match v113 with
        | US3_1 -> (* None *)
            let v115 : string = ""
            v115
        | US3_0(v114) -> (* Some *)
            v114
    let v120 : bool = true
    let mutable _v120 : System.TimeZoneInfo option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v121 : string = "0i64.into()"
    let v122 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v121 
    v122 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v125 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v125 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v134 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v134 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v143 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v143 
    #endif
#if FABLE_COMPILER_PYTHON
    let v152 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v152 
    #endif
#else
    let v159 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    v159 
    #endif
    |> fun x -> _v120 <- Some x
    let v160 : System.TimeZoneInfo = match _v120 with Some x -> x | None -> failwith "base.run_target / _v120=None"
    let v177 : bool = true
    let mutable _v177 : System.TimeSpan option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v180 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v181 : System.TimeSpan = v180 ()
    v181 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v190 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v191 : System.TimeSpan = v190 ()
    v191 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v200 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v201 : System.TimeSpan = v200 ()
    v201 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v208 : US4 = US4_0
    let v209 : US5 = US5_3(v208)
    let v210 : string = $"date_time.get_utc_offset / target: {v209}"
    let v211 : System.TimeSpan = failwith<System.TimeSpan> v210
    v211 
    #endif
#if FABLE_COMPILER_PYTHON
    let v212 : US4 = US4_0
    let v213 : US5 = US5_4(v212)
    let v214 : string = $"date_time.get_utc_offset / target: {v213}"
    let v215 : System.TimeSpan = failwith<System.TimeSpan> v214
    v215 
    #endif
#else
    let v216 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v219 : bool = true
    let mutable _v219 : System.TimeZoneInfo option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v220 : string = "0i64.into()"
    let v221 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v220 
    v221 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v224 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v224 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v233 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v233 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v242 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v242 
    #endif
#if FABLE_COMPILER_PYTHON
    let v251 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v251 
    #endif
#else
    let v258 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    v258 
    #endif
    |> fun x -> _v219 <- Some x
    let v259 : System.TimeZoneInfo = match _v219 with Some x -> x | None -> failwith "base.run_target / _v219=None"
    let v274 : (System.DateTime -> System.TimeSpan) = v216 v259
    let v275 : System.TimeSpan = v274 v29
    v275 
    #endif
    |> fun x -> _v177 <- Some x
    let v276 : System.TimeSpan = match _v177 with Some x -> x | None -> failwith "base.run_target / _v177=None"
    let v288 : (System.TimeSpan -> int32) = _.Hours
    let v289 : int32 = v288 v276
    let v296 : bool = v289 > 0
    let v297 : uint8 =
        if v296 then
            1uy
        else
            0uy
    let v298 : string = method42()
    let v301 : bool = true
    let mutable _v301 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v302 : string = v276.ToString v298 
    v302 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v303 : string = v276.ToString v298 
    v303 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v304 : string = v276.ToString v298 
    v304 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v305 : string = v276.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    v305 
    #endif
#if FABLE_COMPILER_PYTHON
    let v306 : string = v276.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    v306 
    #endif
#else
    let v307 : string = v276.ToString v298 
    v307 
    #endif
    |> fun x -> _v301 <- Some x
    let v308 : string = match _v301 with Some x -> x | None -> failwith "base.run_target / _v301=None"
    let v315 : string = $"{v297}{v308.[0..1]}{v308.[3..4]}"
    let v318 : (System.Guid -> string) = _.ToString()
    let v319 : string = v318 v0
    let v326 : System.Guid = System.Guid $"{v117}{v315}{v319.[v117.Length + v315.Length..]}"
    v326 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v329 : System.DateTime = System.DateTime (1970, 1, 1, 0, 0, 0, System.DateTimeKind.Utc)
    let v338 : (System.DateTime -> System.DateTime) = _.ToUniversalTime()
    let v339 : System.DateTime = v338 v329
    let v346 : System.DateTimeKind = System.DateTimeKind.Local
    let v347 : System.DateTime = System.DateTime.SpecifyKind (v1, v346)
    let v350 : (System.DateTime -> System.DateTime) = _.ToUniversalTime()
    let v351 : System.DateTime = v350 v347
    let v360 : (System.DateTime -> int64) = _.Ticks
    let v361 : int64 = v360 v351
    let v370 : (System.DateTime -> int64) = _.Ticks
    let v371 : int64 = v370 v339
    let v378 : int64 = v361 - v371
    let v379 : int64 = v378 / 10L
    let v380 : string = "chrono::DateTime::from_timestamp_micros($0)"
    let v381 : chrono_DateTime<chrono_Utc> option = Fable.Core.RustInterop.emitRustExpr v379 v380 
    let v384 : US11 option = None
    let _v384 = ref v384 
    match v381 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v385 : chrono_DateTime<chrono_Utc> = x
    let v386 : US11 = US11_0(v385)
    v386 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v384.Value <- x
    let v387 : US11 option = _v384.Value 
    let v410 : US11 = US11_1
    let v411 : US11 = v387 |> Option.defaultValue v410 
    let v435 : US3 =
        match v411 with
        | US11_1 -> (* None *)
            US3_1
        | US11_0(v419) -> (* Some *)
            let v420 : string = "$0.naive_utc()"
            let v421 : chrono_NaiveDateTime = Fable.Core.RustInterop.emitRustExpr v419 v420 
            let v422 : string = "chrono::offset::TimeZone::from_utc_datetime(&chrono::Local, &$0)"
            let v423 : chrono_DateTime<chrono_Local> = Fable.Core.RustInterop.emitRustExpr v421 v422 
            let v424 : string = "%Y%m%d-%H%M-%S%f"
            let v425 : string = "r#\"" + v424 + "\"#"
            let v426 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v425 
            let v427 : string = "$0.format($1).to_string()"
            let v428 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v423, v426) v427 
            let v429 : string = "fable_library_rust::String_::fromString($0)"
            let v430 : string = Fable.Core.RustInterop.emitRustExpr v428 v429 
            let v431 : string = $"{v430.[0..17]}-{v430.[18..21]}-{v430.[22]}"
            US3_0(v431)
    let v439 : string =
        match v435 with
        | US3_1 -> (* None *)
            let v437 : string = ""
            v437
        | US3_0(v436) -> (* Some *)
            v436
    let v442 : bool = true
    let mutable _v442 : System.TimeZoneInfo option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v443 : string = "0i64.into()"
    let v444 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v443 
    v444 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v447 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v447 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v456 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v456 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v465 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v465 
    #endif
#if FABLE_COMPILER_PYTHON
    let v474 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v474 
    #endif
#else
    let v481 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    v481 
    #endif
    |> fun x -> _v442 <- Some x
    let v482 : System.TimeZoneInfo = match _v442 with Some x -> x | None -> failwith "base.run_target / _v442=None"
    let v499 : bool = true
    let mutable _v499 : System.TimeSpan option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v502 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v503 : System.TimeSpan = v502 ()
    v503 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v512 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v513 : System.TimeSpan = v512 ()
    v513 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v522 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v523 : System.TimeSpan = v522 ()
    v523 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v530 : US4 = US4_0
    let v531 : US5 = US5_3(v530)
    let v532 : string = $"date_time.get_utc_offset / target: {v531}"
    let v533 : System.TimeSpan = failwith<System.TimeSpan> v532
    v533 
    #endif
#if FABLE_COMPILER_PYTHON
    let v534 : US4 = US4_0
    let v535 : US5 = US5_4(v534)
    let v536 : string = $"date_time.get_utc_offset / target: {v535}"
    let v537 : System.TimeSpan = failwith<System.TimeSpan> v536
    v537 
    #endif
#else
    let v538 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v541 : bool = true
    let mutable _v541 : System.TimeZoneInfo option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v542 : string = "0i64.into()"
    let v543 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v542 
    v543 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v546 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v546 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v555 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v555 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v564 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v564 
    #endif
#if FABLE_COMPILER_PYTHON
    let v573 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v573 
    #endif
#else
    let v580 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    v580 
    #endif
    |> fun x -> _v541 <- Some x
    let v581 : System.TimeZoneInfo = match _v541 with Some x -> x | None -> failwith "base.run_target / _v541=None"
    let v596 : (System.DateTime -> System.TimeSpan) = v538 v581
    let v597 : System.TimeSpan = v596 v351
    v597 
    #endif
    |> fun x -> _v499 <- Some x
    let v598 : System.TimeSpan = match _v499 with Some x -> x | None -> failwith "base.run_target / _v499=None"
    let v610 : (System.TimeSpan -> int32) = _.Hours
    let v611 : int32 = v610 v598
    let v618 : bool = v611 > 0
    let v619 : uint8 =
        if v618 then
            1uy
        else
            0uy
    let v620 : string = method42()
    let v623 : bool = true
    let mutable _v623 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v624 : string = v598.ToString v620 
    v624 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v625 : string = v598.ToString v620 
    v625 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v626 : string = v598.ToString v620 
    v626 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v627 : string = v598.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    v627 
    #endif
#if FABLE_COMPILER_PYTHON
    let v628 : string = v598.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    v628 
    #endif
#else
    let v629 : string = v598.ToString v620 
    v629 
    #endif
    |> fun x -> _v623 <- Some x
    let v630 : string = match _v623 with Some x -> x | None -> failwith "base.run_target / _v623=None"
    let v637 : string = $"{v619}{v630.[0..1]}{v630.[3..4]}"
    let v640 : (System.Guid -> string) = _.ToString()
    let v641 : string = v640 v0
    let v648 : System.Guid = System.Guid $"{v439}{v637}{v641.[v439.Length + v637.Length..]}"
    v648 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v651 : System.Guid = null |> unbox<System.Guid>
    v651 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v658 : string = method43()
    let v661 : (string -> string) = v1.ToString
    let v662 : string = v661 v658
    let v671 : bool = true
    let mutable _v671 : System.TimeZoneInfo option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v672 : string = "0i64.into()"
    let v673 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v672 
    v673 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v676 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v676 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v685 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v685 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v694 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v694 
    #endif
#if FABLE_COMPILER_PYTHON
    let v703 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v703 
    #endif
#else
    let v710 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    v710 
    #endif
    |> fun x -> _v671 <- Some x
    let v711 : System.TimeZoneInfo = match _v671 with Some x -> x | None -> failwith "base.run_target / _v671=None"
    let v728 : bool = true
    let mutable _v728 : System.TimeSpan option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v731 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v732 : System.TimeSpan = v731 ()
    v732 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v741 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v742 : System.TimeSpan = v741 ()
    v742 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v751 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v752 : System.TimeSpan = v751 ()
    v752 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v759 : US4 = US4_0
    let v760 : US5 = US5_3(v759)
    let v761 : string = $"date_time.get_utc_offset / target: {v760}"
    let v762 : System.TimeSpan = failwith<System.TimeSpan> v761
    v762 
    #endif
#if FABLE_COMPILER_PYTHON
    let v763 : US4 = US4_0
    let v764 : US5 = US5_4(v763)
    let v765 : string = $"date_time.get_utc_offset / target: {v764}"
    let v766 : System.TimeSpan = failwith<System.TimeSpan> v765
    v766 
    #endif
#else
    let v767 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v770 : bool = true
    let mutable _v770 : System.TimeZoneInfo option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v771 : string = "0i64.into()"
    let v772 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v771 
    v772 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v775 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v775 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v784 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v784 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v793 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v793 
    #endif
#if FABLE_COMPILER_PYTHON
    let v802 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v802 
    #endif
#else
    let v809 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    v809 
    #endif
    |> fun x -> _v770 <- Some x
    let v810 : System.TimeZoneInfo = match _v770 with Some x -> x | None -> failwith "base.run_target / _v770=None"
    let v825 : (System.DateTime -> System.TimeSpan) = v767 v810
    let v826 : System.TimeSpan = v825 v1
    v826 
    #endif
    |> fun x -> _v728 <- Some x
    let v827 : System.TimeSpan = match _v728 with Some x -> x | None -> failwith "base.run_target / _v728=None"
    let v839 : (System.TimeSpan -> int32) = _.Hours
    let v840 : int32 = v839 v827
    let v847 : bool = v840 > 0
    let v848 : uint8 =
        if v847 then
            1uy
        else
            0uy
    let v849 : string = method44()
    let v852 : bool = true
    let mutable _v852 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v853 : string = v827.ToString v849 
    v853 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v854 : string = v827.ToString v849 
    v854 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v855 : string = v827.ToString v849 
    v855 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v856 : string = v827.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    v856 
    #endif
#if FABLE_COMPILER_PYTHON
    let v857 : string = v827.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    v857 
    #endif
#else
    let v858 : string = v827.ToString v849 
    v858 
    #endif
    |> fun x -> _v852 <- Some x
    let v859 : string = match _v852 with Some x -> x | None -> failwith "base.run_target / _v852=None"
    let v866 : string = $"{v848}{v859}"
    let v869 : (System.Guid -> string) = _.ToString()
    let v870 : string = v869 v0
    let v877 : System.Guid = System.Guid $"{v662}{v866}{v870.[v662.Length + v866.Length..]}"
    v877 
    #endif
#if FABLE_COMPILER_PYTHON
    let v878 : string = method43()
    let v881 : (string -> string) = v1.ToString
    let v882 : string = v881 v878
    let v891 : bool = true
    let mutable _v891 : System.TimeZoneInfo option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v892 : string = "0i64.into()"
    let v893 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v892 
    v893 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v896 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v896 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v905 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v905 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v914 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v914 
    #endif
#if FABLE_COMPILER_PYTHON
    let v923 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v923 
    #endif
#else
    let v930 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    v930 
    #endif
    |> fun x -> _v891 <- Some x
    let v931 : System.TimeZoneInfo = match _v891 with Some x -> x | None -> failwith "base.run_target / _v891=None"
    let v948 : bool = true
    let mutable _v948 : System.TimeSpan option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v951 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v952 : System.TimeSpan = v951 ()
    v952 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v961 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v962 : System.TimeSpan = v961 ()
    v962 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v971 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v972 : System.TimeSpan = v971 ()
    v972 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v979 : US4 = US4_0
    let v980 : US5 = US5_3(v979)
    let v981 : string = $"date_time.get_utc_offset / target: {v980}"
    let v982 : System.TimeSpan = failwith<System.TimeSpan> v981
    v982 
    #endif
#if FABLE_COMPILER_PYTHON
    let v983 : US4 = US4_0
    let v984 : US5 = US5_4(v983)
    let v985 : string = $"date_time.get_utc_offset / target: {v984}"
    let v986 : System.TimeSpan = failwith<System.TimeSpan> v985
    v986 
    #endif
#else
    let v987 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v990 : bool = true
    let mutable _v990 : System.TimeZoneInfo option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v991 : string = "0i64.into()"
    let v992 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v991 
    v992 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v995 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v995 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1004 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v1004 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1013 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v1013 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1022 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v1022 
    #endif
#else
    let v1029 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    v1029 
    #endif
    |> fun x -> _v990 <- Some x
    let v1030 : System.TimeZoneInfo = match _v990 with Some x -> x | None -> failwith "base.run_target / _v990=None"
    let v1045 : (System.DateTime -> System.TimeSpan) = v987 v1030
    let v1046 : System.TimeSpan = v1045 v1
    v1046 
    #endif
    |> fun x -> _v948 <- Some x
    let v1047 : System.TimeSpan = match _v948 with Some x -> x | None -> failwith "base.run_target / _v948=None"
    let v1059 : (System.TimeSpan -> int32) = _.Hours
    let v1060 : int32 = v1059 v1047
    let v1067 : bool = v1060 > 0
    let v1068 : uint8 =
        if v1067 then
            1uy
        else
            0uy
    let v1069 : string = method44()
    let v1072 : bool = true
    let mutable _v1072 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1073 : string = v1047.ToString v1069 
    v1073 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1074 : string = v1047.ToString v1069 
    v1074 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1075 : string = v1047.ToString v1069 
    v1075 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1076 : string = v1047.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    v1076 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1077 : string = v1047.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    v1077 
    #endif
#else
    let v1078 : string = v1047.ToString v1069 
    v1078 
    #endif
    |> fun x -> _v1072 <- Some x
    let v1079 : string = match _v1072 with Some x -> x | None -> failwith "base.run_target / _v1072=None"
    let v1086 : string = $"{v1068}{v1079}"
    let v1089 : (System.Guid -> string) = _.ToString()
    let v1090 : string = v1089 v0
    let v1097 : System.Guid = System.Guid $"{v882}{v1086}{v1090.[v882.Length + v1086.Length..]}"
    v1097 
    #endif
#else
    let v1098 : string = method43()
    let v1101 : (string -> string) = v1.ToString
    let v1102 : string = v1101 v1098
    let v1111 : bool = true
    let mutable _v1111 : System.TimeZoneInfo option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1112 : string = "0i64.into()"
    let v1113 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v1112 
    v1113 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1116 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v1116 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1125 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v1125 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1134 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v1134 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1143 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v1143 
    #endif
#else
    let v1150 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    v1150 
    #endif
    |> fun x -> _v1111 <- Some x
    let v1151 : System.TimeZoneInfo = match _v1111 with Some x -> x | None -> failwith "base.run_target / _v1111=None"
    let v1168 : bool = true
    let mutable _v1168 : System.TimeSpan option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1171 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v1172 : System.TimeSpan = v1171 ()
    v1172 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1181 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v1182 : System.TimeSpan = v1181 ()
    v1182 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1191 : (unit -> System.TimeSpan) = System.TimeSpan 
    let v1192 : System.TimeSpan = v1191 ()
    v1192 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1199 : US4 = US4_0
    let v1200 : US5 = US5_3(v1199)
    let v1201 : string = $"date_time.get_utc_offset / target: {v1200}"
    let v1202 : System.TimeSpan = failwith<System.TimeSpan> v1201
    v1202 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1203 : US4 = US4_0
    let v1204 : US5 = US5_4(v1203)
    let v1205 : string = $"date_time.get_utc_offset / target: {v1204}"
    let v1206 : System.TimeSpan = failwith<System.TimeSpan> v1205
    v1206 
    #endif
#else
    let v1207 : (System.TimeZoneInfo -> (System.DateTime -> System.TimeSpan)) = _.GetUtcOffset
    let v1210 : bool = true
    let mutable _v1210 : System.TimeZoneInfo option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1211 : string = "0i64.into()"
    let v1212 : System.TimeZoneInfo = Fable.Core.RustInterop.emitRustExpr () v1211 
    v1212 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1215 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v1215 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1224 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v1224 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1233 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v1233 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1242 : System.TimeZoneInfo = null |> unbox<System.TimeZoneInfo>
    v1242 
    #endif
#else
    let v1249 : System.TimeZoneInfo = System.TimeZoneInfo.Local
    v1249 
    #endif
    |> fun x -> _v1210 <- Some x
    let v1250 : System.TimeZoneInfo = match _v1210 with Some x -> x | None -> failwith "base.run_target / _v1210=None"
    let v1265 : (System.DateTime -> System.TimeSpan) = v1207 v1250
    let v1266 : System.TimeSpan = v1265 v1
    v1266 
    #endif
    |> fun x -> _v1168 <- Some x
    let v1267 : System.TimeSpan = match _v1168 with Some x -> x | None -> failwith "base.run_target / _v1168=None"
    let v1279 : (System.TimeSpan -> int32) = _.Hours
    let v1280 : int32 = v1279 v1267
    let v1287 : bool = v1280 > 0
    let v1288 : uint8 =
        if v1287 then
            1uy
        else
            0uy
    let v1289 : string = method44()
    let v1292 : bool = true
    let mutable _v1292 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1293 : string = v1267.ToString v1289 
    v1293 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1294 : string = v1267.ToString v1289 
    v1294 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1295 : string = v1267.ToString v1289 
    v1295 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1296 : string = v1267.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    v1296 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1297 : string = v1267.ToString ("c", System.Globalization.CultureInfo.InvariantCulture)
    v1297 
    #endif
#else
    let v1298 : string = v1267.ToString v1289 
    v1298 
    #endif
    |> fun x -> _v1292 <- Some x
    let v1299 : string = match _v1292 with Some x -> x | None -> failwith "base.run_target / _v1292=None"
    let v1306 : string = $"{v1288}{v1299}"
    let v1309 : (System.Guid -> string) = _.ToString()
    let v1310 : string = v1309 v0
    let v1317 : System.Guid = System.Guid $"{v1102}{v1306}{v1310.[v1102.Length + v1306.Length..]}"
    v1317 
    #endif
    |> fun x -> _v4 <- Some x
    let v1318 : System.Guid = match _v4 with Some x -> x | None -> failwith "base.run_target / _v4=None"
    v1318
and method46 () : string =
    let v2 : bool = true
    let mutable _v2 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : string = "std::env::temp_dir()"
    let v4 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr () v3 
    let v5 : string = "$0.display()"
    let v6 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v4 v5 
    let v9 : bool = true
    let mutable _v9 : std_string_String option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v10 : string = "format!(\"{}\", $0)"
    let v11 : std_string_String = Fable.Core.RustInterop.emitRustExpr v6 v10 
    v11 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v12 : string = "format!(\"{}\", $0)"
    let v13 : std_string_String = Fable.Core.RustInterop.emitRustExpr v6 v12 
    v13 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v14 : string = "format!(\"{}\", $0)"
    let v15 : std_string_String = Fable.Core.RustInterop.emitRustExpr v6 v14 
    v15 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v18 : std_string_String = null |> unbox<std_string_String>
    v18 
    #endif
#if FABLE_COMPILER_PYTHON
    let v27 : std_string_String = null |> unbox<std_string_String>
    v27 
    #endif
#else
    let v36 : std_string_String = null |> unbox<std_string_String>
    v36 
    #endif
    |> fun x -> _v9 <- Some x
    let v43 : std_string_String = match _v9 with Some x -> x | None -> failwith "base.run_target / _v9=None"
    let v58 : string = "fable_library_rust::String_::fromString($0)"
    let v59 : string = Fable.Core.RustInterop.emitRustExpr v43 v58 
    v59 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v60 : US4 = US4_1
    let v61 : US5 = US5_2(v60)
    let v62 : string = $"file_system.get_temp_path / target: {v61}"
    let v63 : string = failwith<string> v62
    v63 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v66 : string = null |> unbox<string>
    v66 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v73 : US4 = US4_0
    let v74 : US5 = US5_3(v73)
    let v75 : string = $"file_system.get_temp_path / target: {v74}"
    let v76 : string = failwith<string> v75
    v76 
    #endif
#if FABLE_COMPILER_PYTHON
    let v77 : US4 = US4_0
    let v78 : US5 = US5_4(v77)
    let v79 : string = $"file_system.get_temp_path / target: {v78}"
    let v80 : string = failwith<string> v79
    v80 
    #endif
#else
    let v81 : (unit -> string) = System.IO.Path.GetTempPath
    let v82 : string = v81 ()
    v82 
    #endif
    |> fun x -> _v2 <- Some x
    let v83 : string = match _v2 with Some x -> x | None -> failwith "base.run_target / _v2=None"
    v83
and method47 () : string =
    let v0 : string = "!create_temp_path_"
    v0
and method50 (v0 : string) : string =
    v0
and method49 (v0 : string, v1 : string) : struct (string * string) =
    let v2 : string = method50(v0)
    struct (v1, v2)
and method48 (v0 : string, v1 : string) : string =
    let v4 : bool = true
    let mutable _v4 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v5 : string = "&*$0"
    let v6 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v5 
    let v7 : string = "String::from($0)"
    let v8 : std_string_String = Fable.Core.RustInterop.emitRustExpr v6 v7 
    let v9 : string = "std::path::PathBuf::from($0)"
    let v10 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v8 v9 
    let v11 : string = "&*$0"
    let v12 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1 v11 
    let v13 : string = "String::from($0)"
    let v14 : std_string_String = Fable.Core.RustInterop.emitRustExpr v12 v13 
    let v15 : string = "$0.join($1)"
    let v16 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr struct (v10, v14) v15 
    let v17 : string = "$0.display()"
    let v18 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v16 v17 
    let v21 : bool = true
    let mutable _v21 : std_string_String option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v22 : string = "format!(\"{}\", $0)"
    let v23 : std_string_String = Fable.Core.RustInterop.emitRustExpr v18 v22 
    v23 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v24 : string = "format!(\"{}\", $0)"
    let v25 : std_string_String = Fable.Core.RustInterop.emitRustExpr v18 v24 
    v25 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v26 : string = "format!(\"{}\", $0)"
    let v27 : std_string_String = Fable.Core.RustInterop.emitRustExpr v18 v26 
    v27 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v30 : std_string_String = null |> unbox<std_string_String>
    v30 
    #endif
#if FABLE_COMPILER_PYTHON
    let v39 : std_string_String = null |> unbox<std_string_String>
    v39 
    #endif
#else
    let v48 : std_string_String = null |> unbox<std_string_String>
    v48 
    #endif
    |> fun x -> _v21 <- Some x
    let v55 : std_string_String = match _v21 with Some x -> x | None -> failwith "base.run_target / _v21=None"
    let v70 : string = "fable_library_rust::String_::fromString($0)"
    let v71 : string = Fable.Core.RustInterop.emitRustExpr v55 v70 
    v71 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v72 : US4 = US4_1
    let v73 : US5 = US5_2(v72)
    let v74 : string = $"file_system.(</>) / target: {v73} / a: {v0} / b: {v1}"
    let v75 : string = failwith<string> v74
    v75 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v78 : string = null |> unbox<string>
    v78 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v85 : string = "path"
    let v86 : IPathJoin = Fable.Core.JsInterop.importAll v85 
    let struct (v87 : string, v88 : string) = method49(v1, v0)
    let v89 : string = "v86.join($0, $1)"
    let v90 : string = Fable.Core.JsInterop.emitJsExpr struct (v87, v88) v89 
    v90 
    #endif
#if FABLE_COMPILER_PYTHON
    let v91 : US4 = US4_0
    let v92 : US5 = US5_4(v91)
    let v93 : string = $"file_system.(</>) / target: {v92} / a: {v0} / b: {v1}"
    let v94 : string = failwith<string> v93
    v94 
    #endif
#else
    let v95 : string = System.IO.Path.Combine (v0, v1)
    v95 
    #endif
    |> fun x -> _v4 <- Some x
    let v96 : string = match _v4 with Some x -> x | None -> failwith "base.run_target / _v4=None"
    v96
and method52 () : string =
    let v0 : string = "CARGO_PKG_NAME"
    v0
and method51 () : string =
    let v2 : bool = true
    let mutable _v2 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : string = method52()
    let v4 : string = method1(v3)
    v4 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v5 : string = method52()
    let v6 : string = method1(v5)
    v6 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v7 : string = method52()
    let v8 : string = method1(v7)
    v8 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v9 : US4 = US4_0
    let v10 : US5 = US5_3(v9)
    let v11 : string = $"env.get_entry_assembly_name / target: {v10}"
    let v12 : string = failwith<string> v11
    v12 
    #endif
#if FABLE_COMPILER_PYTHON
    let v13 : US4 = US4_0
    let v14 : US5 = US5_4(v13)
    let v15 : string = $"env.get_entry_assembly_name / target: {v14}"
    let v16 : string = failwith<string> v15
    v16 
    #endif
#else
    let v17 : string = System.Reflection.Assembly.GetEntryAssembly().GetName().Name
    v17 
    #endif
    |> fun x -> _v2 <- Some x
    let v18 : string = match _v2 with Some x -> x | None -> failwith "base.run_target / _v2=None"
    v18
and method45 (v0 : System.Guid) : string =
    let v3 : bool = true
    let mutable _v3 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v4 : string = method46()
    let v5 : string = method47()
    let v6 : string = method48(v4, v5)
    let v7 : string = method51()
    let v8 : string = method48(v6, v7)
    let v11 : (System.Guid -> string) = _.ToString()
    let v12 : string = v11 v0
    let v19 : string = method48(v8, v12)
    v19 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v20 : string = method46()
    let v21 : string = method47()
    let v22 : string = method48(v20, v21)
    let v23 : string = method51()
    let v24 : string = method48(v22, v23)
    let v27 : (System.Guid -> string) = _.ToString()
    let v28 : string = v27 v0
    let v35 : string = method48(v24, v28)
    v35 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v38 : string = null |> unbox<string>
    v38 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v45 : string = method46()
    let v46 : string = method47()
    let v47 : string = method48(v45, v46)
    let v48 : string = method51()
    let v49 : string = method48(v47, v48)
    let v52 : (System.Guid -> string) = _.ToString()
    let v53 : string = v52 v0
    let v60 : string = method48(v49, v53)
    v60 
    #endif
#if FABLE_COMPILER_PYTHON
    let v61 : string = method46()
    let v62 : string = method47()
    let v63 : string = method48(v61, v62)
    let v64 : string = method51()
    let v65 : string = method48(v63, v64)
    let v68 : (System.Guid -> string) = _.ToString()
    let v69 : string = v68 v0
    let v76 : string = method48(v65, v69)
    v76 
    #endif
#else
    let v77 : string = method46()
    let v78 : string = method47()
    let v79 : string = method48(v77, v78)
    let v80 : string = method51()
    let v81 : string = method48(v79, v80)
    let v84 : (System.Guid -> string) = _.ToString()
    let v85 : string = v84 v0
    let v92 : string = method48(v81, v85)
    v92 
    #endif
    |> fun x -> _v3 <- Some x
    let v93 : string = match _v3 with Some x -> x | None -> failwith "base.run_target / _v3=None"
    v93
and method40 () : string =
    let v2 : bool = true
    let mutable _v2 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v5 : System.DateTime = System.DateTime.Now
    let v14 : (unit -> System.Guid) = System.Guid.NewGuid
    let v15 : System.Guid = v14 ()
    let v22 : System.Guid = method41(v15, v5)
    let v23 : string = method45(v22)
    v23 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v26 : System.DateTime = System.DateTime.Now
    let v35 : (unit -> System.Guid) = System.Guid.NewGuid
    let v36 : System.Guid = v35 ()
    let v43 : System.Guid = method41(v36, v26)
    let v44 : string = method45(v43)
    v44 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v47 : string = null |> unbox<string>
    v47 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v56 : System.DateTime = System.DateTime.Now
    let v65 : (unit -> System.Guid) = System.Guid.NewGuid
    let v66 : System.Guid = v65 ()
    let v73 : System.Guid = method41(v66, v56)
    let v74 : string = method45(v73)
    v74 
    #endif
#if FABLE_COMPILER_PYTHON
    let v77 : System.DateTime = System.DateTime.Now
    let v86 : (unit -> System.Guid) = System.Guid.NewGuid
    let v87 : System.Guid = v86 ()
    let v94 : System.Guid = method41(v87, v77)
    let v95 : string = method45(v94)
    v95 
    #endif
#else
    let v98 : System.DateTime = System.DateTime.Now
    let v107 : (unit -> System.Guid) = System.Guid.NewGuid
    let v108 : System.Guid = v107 ()
    let v115 : System.Guid = method41(v108, v98)
    let v116 : string = method45(v115)
    v116 
    #endif
    |> fun x -> _v2 <- Some x
    let v117 : string = match _v2 with Some x -> x | None -> failwith "base.run_target / _v2=None"
    v117
and closure40 () () : string =
    method40()
and method54 (v0 : string) : string =
    v0
and closure42 () (v0 : std_io_Error) : std_string_String =
    let v3 : bool = true
    let mutable _v3 : std_string_String option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v4 : string = "format!(\"{}\", $0)"
    let v5 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v4 
    v5 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v6 : string = "format!(\"{}\", $0)"
    let v7 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v6 
    v7 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v8 : string = "format!(\"{}\", $0)"
    let v9 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v8 
    v9 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v12 : std_string_String = null |> unbox<std_string_String>
    v12 
    #endif
#if FABLE_COMPILER_PYTHON
    let v21 : std_string_String = null |> unbox<std_string_String>
    v21 
    #endif
#else
    let v30 : std_string_String = null |> unbox<std_string_String>
    v30 
    #endif
    |> fun x -> _v3 <- Some x
    let v37 : std_string_String = match _v3 with Some x -> x | None -> failwith "base.run_target / _v3=None"
    v37
and method55 () : (std_io_Error -> std_string_String) =
    closure42()
and closure43 () () : US12 =
    US12_0
and closure44 () (v0 : std_string_String) : US12 =
    US12_1(v0)
and closure45 () () : string =
    let v0 : string = "file_system.create_dir"
    v0
and closure46 (v0 : string, v1 : std_string_String) () : struct (string * std_string_String) =
    struct (v0, v1)
and method58 (v0 : Mut4, v1 : std_string_String) : unit =
    let v4 : string = $"%A{v1}"
    method14(v0, v4)
and method57 (v0 : Mut4, v1 : string, v2 : std_string_String) : unit =
    let v3 : string = "{ "
    method14(v0, v3)
    method15(v0)
    let v4 : string = "dir"
    method14(v0, v4)
    let v5 : string = " = "
    method14(v0, v5)
    method14(v0, v1)
    let v6 : string = "; "
    method14(v0, v6)
    let v7 : string = "error"
    method14(v0, v7)
    method14(v0, v5)
    method58(v0, v2)
    let v8 : string = " }"
    method14(v0, v8)
and closure47 (v0 : US0, v1 : (unit -> string), v2 : (unit -> struct (string * std_string_String))) () : string =
    let v5 : (US0 -> struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option)) = closure0()
    let v6 : US0 = US0_0
    if State.trace_state.IsNone then State.trace_state <- v5 v6 |> Some
    let struct (v14 : Mut0, v15 : Mut1, v16 : Mut2, v17 : Mut3, v18 : int64 option) = State.trace_state.Value
    let v35 : bool = true
    let mutable _v35 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v38 : US2 option = None
    let _v38 = ref v38 
    match v18 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v39 : int64 = x
    let v40 : US2 = US2_0(v39)
    v40 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v38.Value <- x
    let v41 : US2 option = _v38.Value 
    let v64 : US2 = US2_1
    let v65 : US2 = v41 |> Option.defaultValue v64 
    let v163 : System.DateTime =
        match v65 with
        | US2_1 -> (* None *)
            let v155 : System.DateTime = System.DateTime.Now
            v155
        | US2_0(v73) -> (* Some *)
            let v76 : System.DateTime = System.DateTime.Now
            let v85 : (System.DateTime -> int64) = _.Ticks
            let v86 : int64 = v85 v76
            let v93 : int64 = v86 - v73
            let v96 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v97 : System.TimeSpan = v96 v93
            let v106 : (System.TimeSpan -> int32) = _.Hours
            let v107 : int32 = v106 v97
            let v116 : (System.TimeSpan -> int32) = _.Minutes
            let v117 : int32 = v116 v97
            let v126 : (System.TimeSpan -> int32) = _.Seconds
            let v127 : int32 = v126 v97
            let v136 : (System.TimeSpan -> int32) = _.Milliseconds
            let v137 : int32 = v136 v97
            let v146 : System.DateTime = System.DateTime (1, 1, 1, v107, v117, v127, v137)
            v146
    let v166 : string = method10()
    let v175 : (string -> string) = v163.ToString
    let v176 : string = v175 v166
    v176 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v185 : US2 option = None
    let _v185 = ref v185 
    match v18 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v186 : int64 = x
    let v187 : US2 = US2_0(v186)
    v187 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v185.Value <- x
    let v188 : US2 option = _v185.Value 
    let v211 : US2 = US2_1
    let v212 : US2 = v188 |> Option.defaultValue v211 
    let v310 : System.DateTime =
        match v212 with
        | US2_1 -> (* None *)
            let v302 : System.DateTime = System.DateTime.Now
            v302
        | US2_0(v220) -> (* Some *)
            let v223 : System.DateTime = System.DateTime.Now
            let v232 : (System.DateTime -> int64) = _.Ticks
            let v233 : int64 = v232 v223
            let v240 : int64 = v233 - v220
            let v243 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v244 : System.TimeSpan = v243 v240
            let v253 : (System.TimeSpan -> int32) = _.Hours
            let v254 : int32 = v253 v244
            let v263 : (System.TimeSpan -> int32) = _.Minutes
            let v264 : int32 = v263 v244
            let v273 : (System.TimeSpan -> int32) = _.Seconds
            let v274 : int32 = v273 v244
            let v283 : (System.TimeSpan -> int32) = _.Milliseconds
            let v284 : int32 = v283 v244
            let v293 : System.DateTime = System.DateTime (1, 1, 1, v254, v264, v274, v284)
            v293
    let v313 : string = method10()
    let v322 : (string -> string) = v310.ToString
    let v323 : string = v322 v313
    v323 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v330 : string = $"near_sdk::env::block_timestamp()"
    let v331 : uint64 = Fable.Core.RustInterop.emitRustExpr () v330 
    let v334 : US2 option = None
    let _v334 = ref v334 
    match v18 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v335 : int64 = x
    let v336 : US2 = US2_0(v335)
    v336 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v334.Value <- x
    let v337 : US2 option = _v334.Value 
    let v360 : US2 = US2_1
    let v361 : US2 = v337 |> Option.defaultValue v360 
    let v374 : uint64 =
        match v361 with
        | US2_1 -> (* None *)
            v331
        | US2_0(v369) -> (* Some *)
            let v370 : (int64 -> uint64) = uint64
            let v371 : uint64 = v370 v369
            let v372 : uint64 = v331 - v371
            v372
    let v375 : uint64 = v374 / 1000000000UL
    let v376 : uint64 = v375 % 60UL
    let v377 : uint64 = v375 / 60UL
    let v378 : uint64 = v377 % 60UL
    let v379 : uint64 = v375 / 3600UL
    let v380 : uint64 = v379 % 24UL
    let v381 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
    let v382 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v380, v378, v376) v381 
    let v383 : string = "fable_library_rust::String_::fromString($0)"
    let v384 : string = Fable.Core.RustInterop.emitRustExpr v382 v383 
    v384 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v387 : US2 option = None
    let _v387 = ref v387 
    match v18 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v388 : int64 = x
    let v389 : US2 = US2_0(v388)
    v389 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v387.Value <- x
    let v390 : US2 option = _v387.Value 
    let v413 : US2 = US2_1
    let v414 : US2 = v390 |> Option.defaultValue v413 
    let v512 : System.DateTime =
        match v414 with
        | US2_1 -> (* None *)
            let v504 : System.DateTime = System.DateTime.Now
            v504
        | US2_0(v422) -> (* Some *)
            let v425 : System.DateTime = System.DateTime.Now
            let v434 : (System.DateTime -> int64) = _.Ticks
            let v435 : int64 = v434 v425
            let v442 : int64 = v435 - v422
            let v445 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v446 : System.TimeSpan = v445 v442
            let v455 : (System.TimeSpan -> int32) = _.Hours
            let v456 : int32 = v455 v446
            let v465 : (System.TimeSpan -> int32) = _.Minutes
            let v466 : int32 = v465 v446
            let v475 : (System.TimeSpan -> int32) = _.Seconds
            let v476 : int32 = v475 v446
            let v485 : (System.TimeSpan -> int32) = _.Milliseconds
            let v486 : int32 = v485 v446
            let v495 : System.DateTime = System.DateTime (1, 1, 1, v456, v466, v476, v486)
            v495
    let v515 : string = method11()
    let v524 : (string -> string) = v512.ToString
    let v525 : string = v524 v515
    v525 
    #endif
#if FABLE_COMPILER_PYTHON
    let v534 : US2 option = None
    let _v534 = ref v534 
    match v18 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v535 : int64 = x
    let v536 : US2 = US2_0(v535)
    v536 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v534.Value <- x
    let v537 : US2 option = _v534.Value 
    let v560 : US2 = US2_1
    let v561 : US2 = v537 |> Option.defaultValue v560 
    let v659 : System.DateTime =
        match v561 with
        | US2_1 -> (* None *)
            let v651 : System.DateTime = System.DateTime.Now
            v651
        | US2_0(v569) -> (* Some *)
            let v572 : System.DateTime = System.DateTime.Now
            let v581 : (System.DateTime -> int64) = _.Ticks
            let v582 : int64 = v581 v572
            let v589 : int64 = v582 - v569
            let v592 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v593 : System.TimeSpan = v592 v589
            let v602 : (System.TimeSpan -> int32) = _.Hours
            let v603 : int32 = v602 v593
            let v612 : (System.TimeSpan -> int32) = _.Minutes
            let v613 : int32 = v612 v593
            let v622 : (System.TimeSpan -> int32) = _.Seconds
            let v623 : int32 = v622 v593
            let v632 : (System.TimeSpan -> int32) = _.Milliseconds
            let v633 : int32 = v632 v593
            let v642 : System.DateTime = System.DateTime (1, 1, 1, v603, v613, v623, v633)
            v642
    let v662 : string = method11()
    let v671 : (string -> string) = v659.ToString
    let v672 : string = v671 v662
    v672 
    #endif
#else
    let v681 : US2 option = None
    let _v681 = ref v681 
    match v18 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v682 : int64 = x
    let v683 : US2 = US2_0(v682)
    v683 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v681.Value <- x
    let v684 : US2 option = _v681.Value 
    let v707 : US2 = US2_1
    let v708 : US2 = v684 |> Option.defaultValue v707 
    let v806 : System.DateTime =
        match v708 with
        | US2_1 -> (* None *)
            let v798 : System.DateTime = System.DateTime.Now
            v798
        | US2_0(v716) -> (* Some *)
            let v719 : System.DateTime = System.DateTime.Now
            let v728 : (System.DateTime -> int64) = _.Ticks
            let v729 : int64 = v728 v719
            let v736 : int64 = v729 - v716
            let v739 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v740 : System.TimeSpan = v739 v736
            let v749 : (System.TimeSpan -> int32) = _.Hours
            let v750 : int32 = v749 v740
            let v759 : (System.TimeSpan -> int32) = _.Minutes
            let v760 : int32 = v759 v740
            let v769 : (System.TimeSpan -> int32) = _.Seconds
            let v770 : int32 = v769 v740
            let v779 : (System.TimeSpan -> int32) = _.Milliseconds
            let v780 : int32 = v779 v740
            let v789 : System.DateTime = System.DateTime (1, 1, 1, v750, v760, v770, v780)
            v789
    let v809 : string = method11()
    let v818 : (string -> string) = v806.ToString
    let v819 : string = v818 v809
    v819 
    #endif
    |> fun x -> _v35 <- Some x
    let v826 : string = match _v35 with Some x -> x | None -> failwith "base.run_target / _v35=None"
    let v981 : bool =
        match v0 with
        | US0_0 -> (* Verbose *)
            true
        | _ ->
            false
    let v985 : US3 =
        if v981 then
            let v982 : string = "Verbose"
            US3_0(v982)
        else
            US3_1
    let v1034 : US3 =
        match v985 with
        | US3_1 -> (* None *)
            let v990 : bool =
                match v0 with
                | US0_1 -> (* Debug *)
                    true
                | _ ->
                    false
            let v994 : US3 =
                if v990 then
                    let v991 : string = "Debug"
                    US3_0(v991)
                else
                    US3_1
            match v994 with
            | US3_1 -> (* None *)
                let v999 : bool =
                    match v0 with
                    | US0_2 -> (* Info *)
                        true
                    | _ ->
                        false
                let v1003 : US3 =
                    if v999 then
                        let v1000 : string = "Info"
                        US3_0(v1000)
                    else
                        US3_1
                match v1003 with
                | US3_1 -> (* None *)
                    let v1008 : bool =
                        match v0 with
                        | US0_3 -> (* Warning *)
                            true
                        | _ ->
                            false
                    let v1012 : US3 =
                        if v1008 then
                            let v1009 : string = "Warning"
                            US3_0(v1009)
                        else
                            US3_1
                    match v1012 with
                    | US3_1 -> (* None *)
                        let v1017 : bool =
                            match v0 with
                            | US0_4 -> (* Critical *)
                                true
                            | _ ->
                                false
                        let v1021 : US3 =
                            if v1017 then
                                let v1018 : string = "Critical"
                                US3_0(v1018)
                            else
                                US3_1
                        match v1021 with
                        | US3_1 -> (* None *)
                            US3_1
                        | US3_0(v1022) -> (* Some *)
                            US3_0(v1022)
                    | US3_0(v1013) -> (* Some *)
                        US3_0(v1013)
                | US3_0(v1004) -> (* Some *)
                    US3_0(v1004)
            | US3_0(v995) -> (* Some *)
                US3_0(v995)
        | US3_0(v986) -> (* Some *)
            US3_0(v986)
    let v1038 : string =
        match v1034 with
        | US3_1 -> (* None *)
            failwith<string> "Option does not have a value."
        | US3_0(v1035) -> (* Some *)
            v1035
    let v1041 : (unit -> string) = v1038.ToLower
    let v1042 : string = v1041 ()
    let v1051 : string = v1042.PadLeft (7, ' ')
    let v1083 : bool = true
    let mutable _v1083 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1098 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v1092 : string = "inline_colorization::color_bright_red"
            let v1093 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1092 
            v1093
        | US0_1 -> (* Debug *)
            let v1086 : string = "inline_colorization::color_bright_blue"
            let v1087 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1086 
            v1087
        | US0_2 -> (* Info *)
            let v1088 : string = "inline_colorization::color_bright_green"
            let v1089 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1088 
            v1089
        | US0_0 -> (* Verbose *)
            let v1084 : string = "inline_colorization::color_bright_black"
            let v1085 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1084 
            v1085
        | US0_3 -> (* Warning *)
            let v1090 : string = "inline_colorization::color_yellow"
            let v1091 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1090 
            v1091
    let v1099 : string = "&*$0"
    let v1100 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1051 v1099 
    let v1101 : string = "inline_colorization::color_reset"
    let v1102 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1101 
    let v1103 : string = "\"{v1098}{v1100}{v1102}\""
    let v1104 : string = @$"format!(" + v1103 + ")"
    let v1105 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v1104 
    let v1106 : string = "fable_library_rust::String_::fromString($0)"
    let v1107 : string = Fable.Core.RustInterop.emitRustExpr v1105 v1106 
    v1107 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1122 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v1116 : string = "inline_colorization::color_bright_red"
            let v1117 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1116 
            v1117
        | US0_1 -> (* Debug *)
            let v1110 : string = "inline_colorization::color_bright_blue"
            let v1111 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1110 
            v1111
        | US0_2 -> (* Info *)
            let v1112 : string = "inline_colorization::color_bright_green"
            let v1113 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1112 
            v1113
        | US0_0 -> (* Verbose *)
            let v1108 : string = "inline_colorization::color_bright_black"
            let v1109 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1108 
            v1109
        | US0_3 -> (* Warning *)
            let v1114 : string = "inline_colorization::color_yellow"
            let v1115 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1114 
            v1115
    let v1123 : string = "&*$0"
    let v1124 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1051 v1123 
    let v1125 : string = "inline_colorization::color_reset"
    let v1126 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1125 
    let v1127 : string = "\"{v1122}{v1124}{v1126}\""
    let v1128 : string = @$"format!(" + v1127 + ")"
    let v1129 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v1128 
    let v1130 : string = "fable_library_rust::String_::fromString($0)"
    let v1131 : string = Fable.Core.RustInterop.emitRustExpr v1129 v1130 
    v1131 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1146 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v1140 : string = "inline_colorization::color_bright_red"
            let v1141 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1140 
            v1141
        | US0_1 -> (* Debug *)
            let v1134 : string = "inline_colorization::color_bright_blue"
            let v1135 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1134 
            v1135
        | US0_2 -> (* Info *)
            let v1136 : string = "inline_colorization::color_bright_green"
            let v1137 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1136 
            v1137
        | US0_0 -> (* Verbose *)
            let v1132 : string = "inline_colorization::color_bright_black"
            let v1133 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1132 
            v1133
        | US0_3 -> (* Warning *)
            let v1138 : string = "inline_colorization::color_yellow"
            let v1139 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1138 
            v1139
    let v1147 : string = "&*$0"
    let v1148 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1051 v1147 
    let v1149 : string = "inline_colorization::color_reset"
    let v1150 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1149 
    let v1151 : string = "\"{v1146}{v1148}{v1150}\""
    let v1152 : string = @$"format!(" + v1151 + ")"
    let v1153 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v1152 
    let v1154 : string = "fable_library_rust::String_::fromString($0)"
    let v1155 : string = Fable.Core.RustInterop.emitRustExpr v1153 v1154 
    v1155 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1165 : string =
        match v0 with
        | US0_4 -> (* Critical *)
            let v1160 : string = "\u001b[91m"
            v1160
        | US0_1 -> (* Debug *)
            let v1157 : string = "\u001b[94m"
            v1157
        | US0_2 -> (* Info *)
            let v1158 : string = "\u001b[92m"
            v1158
        | US0_0 -> (* Verbose *)
            let v1156 : string = "\u001b[90m"
            v1156
        | US0_3 -> (* Warning *)
            let v1159 : string = "\u001b[93m"
            v1159
    let v1166 : string = method12()
    let v1167 : string = v1165 + v1051 
    let v1168 : string = v1167 + v1166 
    v1168 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1178 : string =
        match v0 with
        | US0_4 -> (* Critical *)
            let v1173 : string = "\u001b[91m"
            v1173
        | US0_1 -> (* Debug *)
            let v1170 : string = "\u001b[94m"
            v1170
        | US0_2 -> (* Info *)
            let v1171 : string = "\u001b[92m"
            v1171
        | US0_0 -> (* Verbose *)
            let v1169 : string = "\u001b[90m"
            v1169
        | US0_3 -> (* Warning *)
            let v1172 : string = "\u001b[93m"
            v1172
    let v1179 : string = method12()
    let v1180 : string = v1178 + v1051 
    let v1181 : string = v1180 + v1179 
    v1181 
    #endif
#else
    let v1191 : string =
        match v0 with
        | US0_4 -> (* Critical *)
            let v1186 : string = "\u001b[91m"
            v1186
        | US0_1 -> (* Debug *)
            let v1183 : string = "\u001b[94m"
            v1183
        | US0_2 -> (* Info *)
            let v1184 : string = "\u001b[92m"
            v1184
        | US0_0 -> (* Verbose *)
            let v1182 : string = "\u001b[90m"
            v1182
        | US0_3 -> (* Warning *)
            let v1185 : string = "\u001b[93m"
            v1185
    let v1192 : string = method12()
    let v1193 : string = v1191 + v1051 
    let v1194 : string = v1193 + v1192 
    v1194 
    #endif
    |> fun x -> _v1083 <- Some x
    let v1195 : string = match _v1083 with Some x -> x | None -> failwith "base.run_target / _v1083=None"
    let v1214 : int64 = v14.l0
    let struct (v1215 : string, v1216 : std_string_String) = v2 ()
    let v1217 : string = ""
    let v1218 : Mut4 = {l0 = v1217} : Mut4
    method57(v1218, v1215, v1216)
    let v1219 : string = v1218.l0
    let v1222 : string = $"{v826} {v1195} #{v1214} %s{v1 ()} / {v1219}"
    let v1229 : char list = []
    let v1234 : (char list -> (char [])) = List.toArray
    let v1235 : (char []) = v1234 v1229
    let v1242 : string = v1222.TrimStart v1235 
    let v1281 : char list = []
    let v1284 : char list = '/' :: v1281 
    let v1293 : char list = ' ' :: v1284 
    let v1304 : (char list -> (char [])) = List.toArray
    let v1305 : (char []) = v1304 v1293
    let v1312 : string = v1242.TrimEnd v1305 
    v1312
and method56 (v0 : US0, v1 : (unit -> string), v2 : (unit -> struct (string * std_string_String))) : unit =
    let v3 : (unit -> string) = closure47(v0, v1, v2)
    method16(v0, v3)
and closure48 () () : string =
    let v0 : string = "file_system.create_dir"
    v0
and closure49 (v0 : string) () : string =
    v0
and method60 (v0 : Mut4, v1 : string) : unit =
    let v2 : string = "{ "
    method14(v0, v2)
    method15(v0)
    let v3 : string = "dir"
    method14(v0, v3)
    let v4 : string = " = "
    method14(v0, v4)
    method14(v0, v1)
    let v5 : string = " }"
    method14(v0, v5)
and closure50 (v0 : US0, v1 : (unit -> string), v2 : (unit -> string)) () : string =
    let v5 : (US0 -> struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option)) = closure0()
    let v6 : US0 = US0_0
    if State.trace_state.IsNone then State.trace_state <- v5 v6 |> Some
    let struct (v14 : Mut0, v15 : Mut1, v16 : Mut2, v17 : Mut3, v18 : int64 option) = State.trace_state.Value
    let v35 : bool = true
    let mutable _v35 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v38 : US2 option = None
    let _v38 = ref v38 
    match v18 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v39 : int64 = x
    let v40 : US2 = US2_0(v39)
    v40 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v38.Value <- x
    let v41 : US2 option = _v38.Value 
    let v64 : US2 = US2_1
    let v65 : US2 = v41 |> Option.defaultValue v64 
    let v163 : System.DateTime =
        match v65 with
        | US2_1 -> (* None *)
            let v155 : System.DateTime = System.DateTime.Now
            v155
        | US2_0(v73) -> (* Some *)
            let v76 : System.DateTime = System.DateTime.Now
            let v85 : (System.DateTime -> int64) = _.Ticks
            let v86 : int64 = v85 v76
            let v93 : int64 = v86 - v73
            let v96 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v97 : System.TimeSpan = v96 v93
            let v106 : (System.TimeSpan -> int32) = _.Hours
            let v107 : int32 = v106 v97
            let v116 : (System.TimeSpan -> int32) = _.Minutes
            let v117 : int32 = v116 v97
            let v126 : (System.TimeSpan -> int32) = _.Seconds
            let v127 : int32 = v126 v97
            let v136 : (System.TimeSpan -> int32) = _.Milliseconds
            let v137 : int32 = v136 v97
            let v146 : System.DateTime = System.DateTime (1, 1, 1, v107, v117, v127, v137)
            v146
    let v166 : string = method10()
    let v175 : (string -> string) = v163.ToString
    let v176 : string = v175 v166
    v176 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v185 : US2 option = None
    let _v185 = ref v185 
    match v18 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v186 : int64 = x
    let v187 : US2 = US2_0(v186)
    v187 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v185.Value <- x
    let v188 : US2 option = _v185.Value 
    let v211 : US2 = US2_1
    let v212 : US2 = v188 |> Option.defaultValue v211 
    let v310 : System.DateTime =
        match v212 with
        | US2_1 -> (* None *)
            let v302 : System.DateTime = System.DateTime.Now
            v302
        | US2_0(v220) -> (* Some *)
            let v223 : System.DateTime = System.DateTime.Now
            let v232 : (System.DateTime -> int64) = _.Ticks
            let v233 : int64 = v232 v223
            let v240 : int64 = v233 - v220
            let v243 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v244 : System.TimeSpan = v243 v240
            let v253 : (System.TimeSpan -> int32) = _.Hours
            let v254 : int32 = v253 v244
            let v263 : (System.TimeSpan -> int32) = _.Minutes
            let v264 : int32 = v263 v244
            let v273 : (System.TimeSpan -> int32) = _.Seconds
            let v274 : int32 = v273 v244
            let v283 : (System.TimeSpan -> int32) = _.Milliseconds
            let v284 : int32 = v283 v244
            let v293 : System.DateTime = System.DateTime (1, 1, 1, v254, v264, v274, v284)
            v293
    let v313 : string = method10()
    let v322 : (string -> string) = v310.ToString
    let v323 : string = v322 v313
    v323 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v330 : string = $"near_sdk::env::block_timestamp()"
    let v331 : uint64 = Fable.Core.RustInterop.emitRustExpr () v330 
    let v334 : US2 option = None
    let _v334 = ref v334 
    match v18 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v335 : int64 = x
    let v336 : US2 = US2_0(v335)
    v336 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v334.Value <- x
    let v337 : US2 option = _v334.Value 
    let v360 : US2 = US2_1
    let v361 : US2 = v337 |> Option.defaultValue v360 
    let v374 : uint64 =
        match v361 with
        | US2_1 -> (* None *)
            v331
        | US2_0(v369) -> (* Some *)
            let v370 : (int64 -> uint64) = uint64
            let v371 : uint64 = v370 v369
            let v372 : uint64 = v331 - v371
            v372
    let v375 : uint64 = v374 / 1000000000UL
    let v376 : uint64 = v375 % 60UL
    let v377 : uint64 = v375 / 60UL
    let v378 : uint64 = v377 % 60UL
    let v379 : uint64 = v375 / 3600UL
    let v380 : uint64 = v379 % 24UL
    let v381 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
    let v382 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v380, v378, v376) v381 
    let v383 : string = "fable_library_rust::String_::fromString($0)"
    let v384 : string = Fable.Core.RustInterop.emitRustExpr v382 v383 
    v384 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v387 : US2 option = None
    let _v387 = ref v387 
    match v18 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v388 : int64 = x
    let v389 : US2 = US2_0(v388)
    v389 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v387.Value <- x
    let v390 : US2 option = _v387.Value 
    let v413 : US2 = US2_1
    let v414 : US2 = v390 |> Option.defaultValue v413 
    let v512 : System.DateTime =
        match v414 with
        | US2_1 -> (* None *)
            let v504 : System.DateTime = System.DateTime.Now
            v504
        | US2_0(v422) -> (* Some *)
            let v425 : System.DateTime = System.DateTime.Now
            let v434 : (System.DateTime -> int64) = _.Ticks
            let v435 : int64 = v434 v425
            let v442 : int64 = v435 - v422
            let v445 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v446 : System.TimeSpan = v445 v442
            let v455 : (System.TimeSpan -> int32) = _.Hours
            let v456 : int32 = v455 v446
            let v465 : (System.TimeSpan -> int32) = _.Minutes
            let v466 : int32 = v465 v446
            let v475 : (System.TimeSpan -> int32) = _.Seconds
            let v476 : int32 = v475 v446
            let v485 : (System.TimeSpan -> int32) = _.Milliseconds
            let v486 : int32 = v485 v446
            let v495 : System.DateTime = System.DateTime (1, 1, 1, v456, v466, v476, v486)
            v495
    let v515 : string = method11()
    let v524 : (string -> string) = v512.ToString
    let v525 : string = v524 v515
    v525 
    #endif
#if FABLE_COMPILER_PYTHON
    let v534 : US2 option = None
    let _v534 = ref v534 
    match v18 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v535 : int64 = x
    let v536 : US2 = US2_0(v535)
    v536 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v534.Value <- x
    let v537 : US2 option = _v534.Value 
    let v560 : US2 = US2_1
    let v561 : US2 = v537 |> Option.defaultValue v560 
    let v659 : System.DateTime =
        match v561 with
        | US2_1 -> (* None *)
            let v651 : System.DateTime = System.DateTime.Now
            v651
        | US2_0(v569) -> (* Some *)
            let v572 : System.DateTime = System.DateTime.Now
            let v581 : (System.DateTime -> int64) = _.Ticks
            let v582 : int64 = v581 v572
            let v589 : int64 = v582 - v569
            let v592 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v593 : System.TimeSpan = v592 v589
            let v602 : (System.TimeSpan -> int32) = _.Hours
            let v603 : int32 = v602 v593
            let v612 : (System.TimeSpan -> int32) = _.Minutes
            let v613 : int32 = v612 v593
            let v622 : (System.TimeSpan -> int32) = _.Seconds
            let v623 : int32 = v622 v593
            let v632 : (System.TimeSpan -> int32) = _.Milliseconds
            let v633 : int32 = v632 v593
            let v642 : System.DateTime = System.DateTime (1, 1, 1, v603, v613, v623, v633)
            v642
    let v662 : string = method11()
    let v671 : (string -> string) = v659.ToString
    let v672 : string = v671 v662
    v672 
    #endif
#else
    let v681 : US2 option = None
    let _v681 = ref v681 
    match v18 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v682 : int64 = x
    let v683 : US2 = US2_0(v682)
    v683 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v681.Value <- x
    let v684 : US2 option = _v681.Value 
    let v707 : US2 = US2_1
    let v708 : US2 = v684 |> Option.defaultValue v707 
    let v806 : System.DateTime =
        match v708 with
        | US2_1 -> (* None *)
            let v798 : System.DateTime = System.DateTime.Now
            v798
        | US2_0(v716) -> (* Some *)
            let v719 : System.DateTime = System.DateTime.Now
            let v728 : (System.DateTime -> int64) = _.Ticks
            let v729 : int64 = v728 v719
            let v736 : int64 = v729 - v716
            let v739 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v740 : System.TimeSpan = v739 v736
            let v749 : (System.TimeSpan -> int32) = _.Hours
            let v750 : int32 = v749 v740
            let v759 : (System.TimeSpan -> int32) = _.Minutes
            let v760 : int32 = v759 v740
            let v769 : (System.TimeSpan -> int32) = _.Seconds
            let v770 : int32 = v769 v740
            let v779 : (System.TimeSpan -> int32) = _.Milliseconds
            let v780 : int32 = v779 v740
            let v789 : System.DateTime = System.DateTime (1, 1, 1, v750, v760, v770, v780)
            v789
    let v809 : string = method11()
    let v818 : (string -> string) = v806.ToString
    let v819 : string = v818 v809
    v819 
    #endif
    |> fun x -> _v35 <- Some x
    let v826 : string = match _v35 with Some x -> x | None -> failwith "base.run_target / _v35=None"
    let v981 : bool =
        match v0 with
        | US0_0 -> (* Verbose *)
            true
        | _ ->
            false
    let v985 : US3 =
        if v981 then
            let v982 : string = "Verbose"
            US3_0(v982)
        else
            US3_1
    let v1034 : US3 =
        match v985 with
        | US3_1 -> (* None *)
            let v990 : bool =
                match v0 with
                | US0_1 -> (* Debug *)
                    true
                | _ ->
                    false
            let v994 : US3 =
                if v990 then
                    let v991 : string = "Debug"
                    US3_0(v991)
                else
                    US3_1
            match v994 with
            | US3_1 -> (* None *)
                let v999 : bool =
                    match v0 with
                    | US0_2 -> (* Info *)
                        true
                    | _ ->
                        false
                let v1003 : US3 =
                    if v999 then
                        let v1000 : string = "Info"
                        US3_0(v1000)
                    else
                        US3_1
                match v1003 with
                | US3_1 -> (* None *)
                    let v1008 : bool =
                        match v0 with
                        | US0_3 -> (* Warning *)
                            true
                        | _ ->
                            false
                    let v1012 : US3 =
                        if v1008 then
                            let v1009 : string = "Warning"
                            US3_0(v1009)
                        else
                            US3_1
                    match v1012 with
                    | US3_1 -> (* None *)
                        let v1017 : bool =
                            match v0 with
                            | US0_4 -> (* Critical *)
                                true
                            | _ ->
                                false
                        let v1021 : US3 =
                            if v1017 then
                                let v1018 : string = "Critical"
                                US3_0(v1018)
                            else
                                US3_1
                        match v1021 with
                        | US3_1 -> (* None *)
                            US3_1
                        | US3_0(v1022) -> (* Some *)
                            US3_0(v1022)
                    | US3_0(v1013) -> (* Some *)
                        US3_0(v1013)
                | US3_0(v1004) -> (* Some *)
                    US3_0(v1004)
            | US3_0(v995) -> (* Some *)
                US3_0(v995)
        | US3_0(v986) -> (* Some *)
            US3_0(v986)
    let v1038 : string =
        match v1034 with
        | US3_1 -> (* None *)
            failwith<string> "Option does not have a value."
        | US3_0(v1035) -> (* Some *)
            v1035
    let v1041 : (unit -> string) = v1038.ToLower
    let v1042 : string = v1041 ()
    let v1051 : string = v1042.PadLeft (7, ' ')
    let v1083 : bool = true
    let mutable _v1083 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1098 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v1092 : string = "inline_colorization::color_bright_red"
            let v1093 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1092 
            v1093
        | US0_1 -> (* Debug *)
            let v1086 : string = "inline_colorization::color_bright_blue"
            let v1087 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1086 
            v1087
        | US0_2 -> (* Info *)
            let v1088 : string = "inline_colorization::color_bright_green"
            let v1089 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1088 
            v1089
        | US0_0 -> (* Verbose *)
            let v1084 : string = "inline_colorization::color_bright_black"
            let v1085 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1084 
            v1085
        | US0_3 -> (* Warning *)
            let v1090 : string = "inline_colorization::color_yellow"
            let v1091 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1090 
            v1091
    let v1099 : string = "&*$0"
    let v1100 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1051 v1099 
    let v1101 : string = "inline_colorization::color_reset"
    let v1102 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1101 
    let v1103 : string = "\"{v1098}{v1100}{v1102}\""
    let v1104 : string = @$"format!(" + v1103 + ")"
    let v1105 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v1104 
    let v1106 : string = "fable_library_rust::String_::fromString($0)"
    let v1107 : string = Fable.Core.RustInterop.emitRustExpr v1105 v1106 
    v1107 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1122 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v1116 : string = "inline_colorization::color_bright_red"
            let v1117 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1116 
            v1117
        | US0_1 -> (* Debug *)
            let v1110 : string = "inline_colorization::color_bright_blue"
            let v1111 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1110 
            v1111
        | US0_2 -> (* Info *)
            let v1112 : string = "inline_colorization::color_bright_green"
            let v1113 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1112 
            v1113
        | US0_0 -> (* Verbose *)
            let v1108 : string = "inline_colorization::color_bright_black"
            let v1109 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1108 
            v1109
        | US0_3 -> (* Warning *)
            let v1114 : string = "inline_colorization::color_yellow"
            let v1115 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1114 
            v1115
    let v1123 : string = "&*$0"
    let v1124 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1051 v1123 
    let v1125 : string = "inline_colorization::color_reset"
    let v1126 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1125 
    let v1127 : string = "\"{v1122}{v1124}{v1126}\""
    let v1128 : string = @$"format!(" + v1127 + ")"
    let v1129 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v1128 
    let v1130 : string = "fable_library_rust::String_::fromString($0)"
    let v1131 : string = Fable.Core.RustInterop.emitRustExpr v1129 v1130 
    v1131 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1146 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v1140 : string = "inline_colorization::color_bright_red"
            let v1141 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1140 
            v1141
        | US0_1 -> (* Debug *)
            let v1134 : string = "inline_colorization::color_bright_blue"
            let v1135 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1134 
            v1135
        | US0_2 -> (* Info *)
            let v1136 : string = "inline_colorization::color_bright_green"
            let v1137 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1136 
            v1137
        | US0_0 -> (* Verbose *)
            let v1132 : string = "inline_colorization::color_bright_black"
            let v1133 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1132 
            v1133
        | US0_3 -> (* Warning *)
            let v1138 : string = "inline_colorization::color_yellow"
            let v1139 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1138 
            v1139
    let v1147 : string = "&*$0"
    let v1148 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1051 v1147 
    let v1149 : string = "inline_colorization::color_reset"
    let v1150 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1149 
    let v1151 : string = "\"{v1146}{v1148}{v1150}\""
    let v1152 : string = @$"format!(" + v1151 + ")"
    let v1153 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v1152 
    let v1154 : string = "fable_library_rust::String_::fromString($0)"
    let v1155 : string = Fable.Core.RustInterop.emitRustExpr v1153 v1154 
    v1155 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1165 : string =
        match v0 with
        | US0_4 -> (* Critical *)
            let v1160 : string = "\u001b[91m"
            v1160
        | US0_1 -> (* Debug *)
            let v1157 : string = "\u001b[94m"
            v1157
        | US0_2 -> (* Info *)
            let v1158 : string = "\u001b[92m"
            v1158
        | US0_0 -> (* Verbose *)
            let v1156 : string = "\u001b[90m"
            v1156
        | US0_3 -> (* Warning *)
            let v1159 : string = "\u001b[93m"
            v1159
    let v1166 : string = method12()
    let v1167 : string = v1165 + v1051 
    let v1168 : string = v1167 + v1166 
    v1168 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1178 : string =
        match v0 with
        | US0_4 -> (* Critical *)
            let v1173 : string = "\u001b[91m"
            v1173
        | US0_1 -> (* Debug *)
            let v1170 : string = "\u001b[94m"
            v1170
        | US0_2 -> (* Info *)
            let v1171 : string = "\u001b[92m"
            v1171
        | US0_0 -> (* Verbose *)
            let v1169 : string = "\u001b[90m"
            v1169
        | US0_3 -> (* Warning *)
            let v1172 : string = "\u001b[93m"
            v1172
    let v1179 : string = method12()
    let v1180 : string = v1178 + v1051 
    let v1181 : string = v1180 + v1179 
    v1181 
    #endif
#else
    let v1191 : string =
        match v0 with
        | US0_4 -> (* Critical *)
            let v1186 : string = "\u001b[91m"
            v1186
        | US0_1 -> (* Debug *)
            let v1183 : string = "\u001b[94m"
            v1183
        | US0_2 -> (* Info *)
            let v1184 : string = "\u001b[92m"
            v1184
        | US0_0 -> (* Verbose *)
            let v1182 : string = "\u001b[90m"
            v1182
        | US0_3 -> (* Warning *)
            let v1185 : string = "\u001b[93m"
            v1185
    let v1192 : string = method12()
    let v1193 : string = v1191 + v1051 
    let v1194 : string = v1193 + v1192 
    v1194 
    #endif
    |> fun x -> _v1083 <- Some x
    let v1195 : string = match _v1083 with Some x -> x | None -> failwith "base.run_target / _v1083=None"
    let v1214 : int64 = v14.l0
    let v1215 : string = v2 ()
    let v1216 : string = ""
    let v1217 : Mut4 = {l0 = v1216} : Mut4
    method60(v1217, v1215)
    let v1218 : string = v1217.l0
    let v1221 : string = $"{v826} {v1195} #{v1214} %s{v1 ()} / {v1218}"
    let v1228 : char list = []
    let v1233 : (char list -> (char [])) = List.toArray
    let v1234 : (char []) = v1233 v1228
    let v1241 : string = v1221.TrimStart v1234 
    let v1280 : char list = []
    let v1283 : char list = '/' :: v1280 
    let v1292 : char list = ' ' :: v1283 
    let v1303 : (char list -> (char [])) = List.toArray
    let v1304 : (char []) = v1303 v1292
    let v1311 : string = v1241.TrimEnd v1304 
    v1311
and method59 (v0 : US0, v1 : (unit -> string), v2 : (unit -> string)) : unit =
    let v3 : (unit -> string) = closure50(v0, v1, v2)
    method16(v0, v3)
and closure51 (v0 : string) () : unit =
    let v1 : bool = true
    method5(v1, v0)
and method61 (v0 : string) : (unit -> unit) =
    closure51(v0)
and method62 (v0 : string) : (unit -> unit) =
    closure51(v0)
and closure52 () () : string =
    let v0 : string = "file_system.create_dir"
    v0
and closure53 (v0 : string, v1 : string) () : struct (string * string) =
    struct (v0, v1)
and method64 (v0 : Mut4, v1 : string, v2 : string) : unit =
    let v3 : string = "{ "
    method14(v0, v3)
    method15(v0)
    let v4 : string = "dir"
    method14(v0, v4)
    let v5 : string = " = "
    method14(v0, v5)
    method14(v0, v1)
    let v6 : string = "; "
    method14(v0, v6)
    let v7 : string = "result"
    method14(v0, v7)
    method14(v0, v5)
    method14(v0, v2)
    let v8 : string = " }"
    method14(v0, v8)
and closure54 (v0 : US0, v1 : (unit -> string), v2 : (unit -> struct (string * string))) () : string =
    let v5 : (US0 -> struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option)) = closure0()
    let v6 : US0 = US0_0
    if State.trace_state.IsNone then State.trace_state <- v5 v6 |> Some
    let struct (v14 : Mut0, v15 : Mut1, v16 : Mut2, v17 : Mut3, v18 : int64 option) = State.trace_state.Value
    let v35 : bool = true
    let mutable _v35 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v38 : US2 option = None
    let _v38 = ref v38 
    match v18 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v39 : int64 = x
    let v40 : US2 = US2_0(v39)
    v40 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v38.Value <- x
    let v41 : US2 option = _v38.Value 
    let v64 : US2 = US2_1
    let v65 : US2 = v41 |> Option.defaultValue v64 
    let v163 : System.DateTime =
        match v65 with
        | US2_1 -> (* None *)
            let v155 : System.DateTime = System.DateTime.Now
            v155
        | US2_0(v73) -> (* Some *)
            let v76 : System.DateTime = System.DateTime.Now
            let v85 : (System.DateTime -> int64) = _.Ticks
            let v86 : int64 = v85 v76
            let v93 : int64 = v86 - v73
            let v96 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v97 : System.TimeSpan = v96 v93
            let v106 : (System.TimeSpan -> int32) = _.Hours
            let v107 : int32 = v106 v97
            let v116 : (System.TimeSpan -> int32) = _.Minutes
            let v117 : int32 = v116 v97
            let v126 : (System.TimeSpan -> int32) = _.Seconds
            let v127 : int32 = v126 v97
            let v136 : (System.TimeSpan -> int32) = _.Milliseconds
            let v137 : int32 = v136 v97
            let v146 : System.DateTime = System.DateTime (1, 1, 1, v107, v117, v127, v137)
            v146
    let v166 : string = method10()
    let v175 : (string -> string) = v163.ToString
    let v176 : string = v175 v166
    v176 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v185 : US2 option = None
    let _v185 = ref v185 
    match v18 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v186 : int64 = x
    let v187 : US2 = US2_0(v186)
    v187 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v185.Value <- x
    let v188 : US2 option = _v185.Value 
    let v211 : US2 = US2_1
    let v212 : US2 = v188 |> Option.defaultValue v211 
    let v310 : System.DateTime =
        match v212 with
        | US2_1 -> (* None *)
            let v302 : System.DateTime = System.DateTime.Now
            v302
        | US2_0(v220) -> (* Some *)
            let v223 : System.DateTime = System.DateTime.Now
            let v232 : (System.DateTime -> int64) = _.Ticks
            let v233 : int64 = v232 v223
            let v240 : int64 = v233 - v220
            let v243 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v244 : System.TimeSpan = v243 v240
            let v253 : (System.TimeSpan -> int32) = _.Hours
            let v254 : int32 = v253 v244
            let v263 : (System.TimeSpan -> int32) = _.Minutes
            let v264 : int32 = v263 v244
            let v273 : (System.TimeSpan -> int32) = _.Seconds
            let v274 : int32 = v273 v244
            let v283 : (System.TimeSpan -> int32) = _.Milliseconds
            let v284 : int32 = v283 v244
            let v293 : System.DateTime = System.DateTime (1, 1, 1, v254, v264, v274, v284)
            v293
    let v313 : string = method10()
    let v322 : (string -> string) = v310.ToString
    let v323 : string = v322 v313
    v323 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v330 : string = $"near_sdk::env::block_timestamp()"
    let v331 : uint64 = Fable.Core.RustInterop.emitRustExpr () v330 
    let v334 : US2 option = None
    let _v334 = ref v334 
    match v18 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v335 : int64 = x
    let v336 : US2 = US2_0(v335)
    v336 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v334.Value <- x
    let v337 : US2 option = _v334.Value 
    let v360 : US2 = US2_1
    let v361 : US2 = v337 |> Option.defaultValue v360 
    let v374 : uint64 =
        match v361 with
        | US2_1 -> (* None *)
            v331
        | US2_0(v369) -> (* Some *)
            let v370 : (int64 -> uint64) = uint64
            let v371 : uint64 = v370 v369
            let v372 : uint64 = v331 - v371
            v372
    let v375 : uint64 = v374 / 1000000000UL
    let v376 : uint64 = v375 % 60UL
    let v377 : uint64 = v375 / 60UL
    let v378 : uint64 = v377 % 60UL
    let v379 : uint64 = v375 / 3600UL
    let v380 : uint64 = v379 % 24UL
    let v381 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
    let v382 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v380, v378, v376) v381 
    let v383 : string = "fable_library_rust::String_::fromString($0)"
    let v384 : string = Fable.Core.RustInterop.emitRustExpr v382 v383 
    v384 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v387 : US2 option = None
    let _v387 = ref v387 
    match v18 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v388 : int64 = x
    let v389 : US2 = US2_0(v388)
    v389 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v387.Value <- x
    let v390 : US2 option = _v387.Value 
    let v413 : US2 = US2_1
    let v414 : US2 = v390 |> Option.defaultValue v413 
    let v512 : System.DateTime =
        match v414 with
        | US2_1 -> (* None *)
            let v504 : System.DateTime = System.DateTime.Now
            v504
        | US2_0(v422) -> (* Some *)
            let v425 : System.DateTime = System.DateTime.Now
            let v434 : (System.DateTime -> int64) = _.Ticks
            let v435 : int64 = v434 v425
            let v442 : int64 = v435 - v422
            let v445 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v446 : System.TimeSpan = v445 v442
            let v455 : (System.TimeSpan -> int32) = _.Hours
            let v456 : int32 = v455 v446
            let v465 : (System.TimeSpan -> int32) = _.Minutes
            let v466 : int32 = v465 v446
            let v475 : (System.TimeSpan -> int32) = _.Seconds
            let v476 : int32 = v475 v446
            let v485 : (System.TimeSpan -> int32) = _.Milliseconds
            let v486 : int32 = v485 v446
            let v495 : System.DateTime = System.DateTime (1, 1, 1, v456, v466, v476, v486)
            v495
    let v515 : string = method11()
    let v524 : (string -> string) = v512.ToString
    let v525 : string = v524 v515
    v525 
    #endif
#if FABLE_COMPILER_PYTHON
    let v534 : US2 option = None
    let _v534 = ref v534 
    match v18 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v535 : int64 = x
    let v536 : US2 = US2_0(v535)
    v536 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v534.Value <- x
    let v537 : US2 option = _v534.Value 
    let v560 : US2 = US2_1
    let v561 : US2 = v537 |> Option.defaultValue v560 
    let v659 : System.DateTime =
        match v561 with
        | US2_1 -> (* None *)
            let v651 : System.DateTime = System.DateTime.Now
            v651
        | US2_0(v569) -> (* Some *)
            let v572 : System.DateTime = System.DateTime.Now
            let v581 : (System.DateTime -> int64) = _.Ticks
            let v582 : int64 = v581 v572
            let v589 : int64 = v582 - v569
            let v592 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v593 : System.TimeSpan = v592 v589
            let v602 : (System.TimeSpan -> int32) = _.Hours
            let v603 : int32 = v602 v593
            let v612 : (System.TimeSpan -> int32) = _.Minutes
            let v613 : int32 = v612 v593
            let v622 : (System.TimeSpan -> int32) = _.Seconds
            let v623 : int32 = v622 v593
            let v632 : (System.TimeSpan -> int32) = _.Milliseconds
            let v633 : int32 = v632 v593
            let v642 : System.DateTime = System.DateTime (1, 1, 1, v603, v613, v623, v633)
            v642
    let v662 : string = method11()
    let v671 : (string -> string) = v659.ToString
    let v672 : string = v671 v662
    v672 
    #endif
#else
    let v681 : US2 option = None
    let _v681 = ref v681 
    match v18 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v682 : int64 = x
    let v683 : US2 = US2_0(v682)
    v683 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v681.Value <- x
    let v684 : US2 option = _v681.Value 
    let v707 : US2 = US2_1
    let v708 : US2 = v684 |> Option.defaultValue v707 
    let v806 : System.DateTime =
        match v708 with
        | US2_1 -> (* None *)
            let v798 : System.DateTime = System.DateTime.Now
            v798
        | US2_0(v716) -> (* Some *)
            let v719 : System.DateTime = System.DateTime.Now
            let v728 : (System.DateTime -> int64) = _.Ticks
            let v729 : int64 = v728 v719
            let v736 : int64 = v729 - v716
            let v739 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v740 : System.TimeSpan = v739 v736
            let v749 : (System.TimeSpan -> int32) = _.Hours
            let v750 : int32 = v749 v740
            let v759 : (System.TimeSpan -> int32) = _.Minutes
            let v760 : int32 = v759 v740
            let v769 : (System.TimeSpan -> int32) = _.Seconds
            let v770 : int32 = v769 v740
            let v779 : (System.TimeSpan -> int32) = _.Milliseconds
            let v780 : int32 = v779 v740
            let v789 : System.DateTime = System.DateTime (1, 1, 1, v750, v760, v770, v780)
            v789
    let v809 : string = method11()
    let v818 : (string -> string) = v806.ToString
    let v819 : string = v818 v809
    v819 
    #endif
    |> fun x -> _v35 <- Some x
    let v826 : string = match _v35 with Some x -> x | None -> failwith "base.run_target / _v35=None"
    let v981 : bool =
        match v0 with
        | US0_0 -> (* Verbose *)
            true
        | _ ->
            false
    let v985 : US3 =
        if v981 then
            let v982 : string = "Verbose"
            US3_0(v982)
        else
            US3_1
    let v1034 : US3 =
        match v985 with
        | US3_1 -> (* None *)
            let v990 : bool =
                match v0 with
                | US0_1 -> (* Debug *)
                    true
                | _ ->
                    false
            let v994 : US3 =
                if v990 then
                    let v991 : string = "Debug"
                    US3_0(v991)
                else
                    US3_1
            match v994 with
            | US3_1 -> (* None *)
                let v999 : bool =
                    match v0 with
                    | US0_2 -> (* Info *)
                        true
                    | _ ->
                        false
                let v1003 : US3 =
                    if v999 then
                        let v1000 : string = "Info"
                        US3_0(v1000)
                    else
                        US3_1
                match v1003 with
                | US3_1 -> (* None *)
                    let v1008 : bool =
                        match v0 with
                        | US0_3 -> (* Warning *)
                            true
                        | _ ->
                            false
                    let v1012 : US3 =
                        if v1008 then
                            let v1009 : string = "Warning"
                            US3_0(v1009)
                        else
                            US3_1
                    match v1012 with
                    | US3_1 -> (* None *)
                        let v1017 : bool =
                            match v0 with
                            | US0_4 -> (* Critical *)
                                true
                            | _ ->
                                false
                        let v1021 : US3 =
                            if v1017 then
                                let v1018 : string = "Critical"
                                US3_0(v1018)
                            else
                                US3_1
                        match v1021 with
                        | US3_1 -> (* None *)
                            US3_1
                        | US3_0(v1022) -> (* Some *)
                            US3_0(v1022)
                    | US3_0(v1013) -> (* Some *)
                        US3_0(v1013)
                | US3_0(v1004) -> (* Some *)
                    US3_0(v1004)
            | US3_0(v995) -> (* Some *)
                US3_0(v995)
        | US3_0(v986) -> (* Some *)
            US3_0(v986)
    let v1038 : string =
        match v1034 with
        | US3_1 -> (* None *)
            failwith<string> "Option does not have a value."
        | US3_0(v1035) -> (* Some *)
            v1035
    let v1041 : (unit -> string) = v1038.ToLower
    let v1042 : string = v1041 ()
    let v1051 : string = v1042.PadLeft (7, ' ')
    let v1083 : bool = true
    let mutable _v1083 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1098 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v1092 : string = "inline_colorization::color_bright_red"
            let v1093 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1092 
            v1093
        | US0_1 -> (* Debug *)
            let v1086 : string = "inline_colorization::color_bright_blue"
            let v1087 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1086 
            v1087
        | US0_2 -> (* Info *)
            let v1088 : string = "inline_colorization::color_bright_green"
            let v1089 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1088 
            v1089
        | US0_0 -> (* Verbose *)
            let v1084 : string = "inline_colorization::color_bright_black"
            let v1085 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1084 
            v1085
        | US0_3 -> (* Warning *)
            let v1090 : string = "inline_colorization::color_yellow"
            let v1091 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1090 
            v1091
    let v1099 : string = "&*$0"
    let v1100 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1051 v1099 
    let v1101 : string = "inline_colorization::color_reset"
    let v1102 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1101 
    let v1103 : string = "\"{v1098}{v1100}{v1102}\""
    let v1104 : string = @$"format!(" + v1103 + ")"
    let v1105 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v1104 
    let v1106 : string = "fable_library_rust::String_::fromString($0)"
    let v1107 : string = Fable.Core.RustInterop.emitRustExpr v1105 v1106 
    v1107 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1122 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v1116 : string = "inline_colorization::color_bright_red"
            let v1117 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1116 
            v1117
        | US0_1 -> (* Debug *)
            let v1110 : string = "inline_colorization::color_bright_blue"
            let v1111 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1110 
            v1111
        | US0_2 -> (* Info *)
            let v1112 : string = "inline_colorization::color_bright_green"
            let v1113 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1112 
            v1113
        | US0_0 -> (* Verbose *)
            let v1108 : string = "inline_colorization::color_bright_black"
            let v1109 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1108 
            v1109
        | US0_3 -> (* Warning *)
            let v1114 : string = "inline_colorization::color_yellow"
            let v1115 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1114 
            v1115
    let v1123 : string = "&*$0"
    let v1124 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1051 v1123 
    let v1125 : string = "inline_colorization::color_reset"
    let v1126 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1125 
    let v1127 : string = "\"{v1122}{v1124}{v1126}\""
    let v1128 : string = @$"format!(" + v1127 + ")"
    let v1129 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v1128 
    let v1130 : string = "fable_library_rust::String_::fromString($0)"
    let v1131 : string = Fable.Core.RustInterop.emitRustExpr v1129 v1130 
    v1131 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1146 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v1140 : string = "inline_colorization::color_bright_red"
            let v1141 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1140 
            v1141
        | US0_1 -> (* Debug *)
            let v1134 : string = "inline_colorization::color_bright_blue"
            let v1135 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1134 
            v1135
        | US0_2 -> (* Info *)
            let v1136 : string = "inline_colorization::color_bright_green"
            let v1137 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1136 
            v1137
        | US0_0 -> (* Verbose *)
            let v1132 : string = "inline_colorization::color_bright_black"
            let v1133 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1132 
            v1133
        | US0_3 -> (* Warning *)
            let v1138 : string = "inline_colorization::color_yellow"
            let v1139 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1138 
            v1139
    let v1147 : string = "&*$0"
    let v1148 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1051 v1147 
    let v1149 : string = "inline_colorization::color_reset"
    let v1150 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1149 
    let v1151 : string = "\"{v1146}{v1148}{v1150}\""
    let v1152 : string = @$"format!(" + v1151 + ")"
    let v1153 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v1152 
    let v1154 : string = "fable_library_rust::String_::fromString($0)"
    let v1155 : string = Fable.Core.RustInterop.emitRustExpr v1153 v1154 
    v1155 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1165 : string =
        match v0 with
        | US0_4 -> (* Critical *)
            let v1160 : string = "\u001b[91m"
            v1160
        | US0_1 -> (* Debug *)
            let v1157 : string = "\u001b[94m"
            v1157
        | US0_2 -> (* Info *)
            let v1158 : string = "\u001b[92m"
            v1158
        | US0_0 -> (* Verbose *)
            let v1156 : string = "\u001b[90m"
            v1156
        | US0_3 -> (* Warning *)
            let v1159 : string = "\u001b[93m"
            v1159
    let v1166 : string = method12()
    let v1167 : string = v1165 + v1051 
    let v1168 : string = v1167 + v1166 
    v1168 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1178 : string =
        match v0 with
        | US0_4 -> (* Critical *)
            let v1173 : string = "\u001b[91m"
            v1173
        | US0_1 -> (* Debug *)
            let v1170 : string = "\u001b[94m"
            v1170
        | US0_2 -> (* Info *)
            let v1171 : string = "\u001b[92m"
            v1171
        | US0_0 -> (* Verbose *)
            let v1169 : string = "\u001b[90m"
            v1169
        | US0_3 -> (* Warning *)
            let v1172 : string = "\u001b[93m"
            v1172
    let v1179 : string = method12()
    let v1180 : string = v1178 + v1051 
    let v1181 : string = v1180 + v1179 
    v1181 
    #endif
#else
    let v1191 : string =
        match v0 with
        | US0_4 -> (* Critical *)
            let v1186 : string = "\u001b[91m"
            v1186
        | US0_1 -> (* Debug *)
            let v1183 : string = "\u001b[94m"
            v1183
        | US0_2 -> (* Info *)
            let v1184 : string = "\u001b[92m"
            v1184
        | US0_0 -> (* Verbose *)
            let v1182 : string = "\u001b[90m"
            v1182
        | US0_3 -> (* Warning *)
            let v1185 : string = "\u001b[93m"
            v1185
    let v1192 : string = method12()
    let v1193 : string = v1191 + v1051 
    let v1194 : string = v1193 + v1192 
    v1194 
    #endif
    |> fun x -> _v1083 <- Some x
    let v1195 : string = match _v1083 with Some x -> x | None -> failwith "base.run_target / _v1083=None"
    let v1214 : int64 = v14.l0
    let struct (v1215 : string, v1216 : string) = v2 ()
    let v1217 : string = ""
    let v1218 : Mut4 = {l0 = v1217} : Mut4
    method64(v1218, v1215, v1216)
    let v1219 : string = v1218.l0
    let v1222 : string = $"{v826} {v1195} #{v1214} %s{v1 ()} / {v1219}"
    let v1229 : char list = []
    let v1234 : (char list -> (char [])) = List.toArray
    let v1235 : (char []) = v1234 v1229
    let v1242 : string = v1222.TrimStart v1235 
    let v1281 : char list = []
    let v1284 : char list = '/' :: v1281 
    let v1293 : char list = ' ' :: v1284 
    let v1304 : (char list -> (char [])) = List.toArray
    let v1305 : (char []) = v1304 v1293
    let v1312 : string = v1242.TrimEnd v1305 
    v1312
and method63 (v0 : US0, v1 : (unit -> string), v2 : (unit -> struct (string * string))) : unit =
    let v3 : (unit -> string) = closure54(v0, v1, v2)
    method16(v0, v3)
and closure55 (v0 : string) () : unit =
    let v3 : bool = true
    let mutable _v3 : Async<int64> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v6 : Async<int64> = null |> unbox<Async<int64>>
    v6 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v15 : Async<int64> = null |> unbox<Async<int64>>
    v15 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v24 : Async<int64> = null |> unbox<Async<int64>>
    v24 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v33 : Async<int64> = null |> unbox<Async<int64>>
    v33 
    #endif
#if FABLE_COMPILER_PYTHON
    let v42 : Async<int64> = null |> unbox<Async<int64>>
    v42 
    #endif
#else
    let v49 : int64 = 0L
    let v50 : Async<int64> = method4(v0, v49)
    v50 
    #endif
    |> fun x -> _v3 <- Some x
    let v51 : Async<int64> = match _v3 with Some x -> x | None -> failwith "base.run_target / _v3=None"
    let v68 : bool = true
    let mutable _v68 : Async<unit> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v71 : Async<unit> = null |> unbox<Async<unit>>
    v71 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v80 : Async<unit> = null |> unbox<Async<unit>>
    v80 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v89 : Async<unit> = null |> unbox<Async<unit>>
    v89 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v98 : Async<unit> = null |> unbox<Async<unit>>
    v98 
    #endif
#if FABLE_COMPILER_PYTHON
    let v107 : Async<unit> = null |> unbox<Async<unit>>
    v107 
    #endif
#else
    let v114 : (Async<int64> -> Async<unit>) = Async.Ignore
    let v115 : Async<unit> = v114 v51
    v115 
    #endif
    |> fun x -> _v68 <- Some x
    let v116 : Async<unit> = match _v68 with Some x -> x | None -> failwith "base.run_target / _v68=None"
    let v133 : bool = true
    let mutable _v133 : unit option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
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
#if FABLE_COMPILER_TYPESCRIPT
    null |> unbox<unit>
    () 
    #endif
#if FABLE_COMPILER_PYTHON
    null |> unbox<unit>
    () 
    #endif
#else
    let v164 : (Async<unit> -> unit) = Async.RunSynchronously
    v164 v116
    () 
    #endif
    |> fun x -> _v133 <- Some x
    match _v133 with Some x -> x | None -> failwith "base.run_target / _v133=None"
    ()
and method65 (v0 : string) : (unit -> unit) =
    closure55(v0)
and method66 (v0 : string) : (unit -> unit) =
    closure55(v0)
and method53 (v0 : string) : System.IDisposable =
    let v3 : bool = true
    let mutable _v3 : System.IDisposable option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v4 : string = method54(v0)
    let v5 : string = "std::fs::create_dir_all(&*$0)"
    let v6 : Result<unit, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v4 v5 
    let v7 : (std_io_Error -> std_string_String) = method55()
    let v8 : string = "$0.map_err(|x| $1(x))"
    let v9 : Result<unit, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v6, v7) v8 
    let v10 : (unit -> US12) = closure43()
    let v11 : (std_string_String -> US12) = closure44()
    let v12 : US12 = match v9 with Ok () -> v10 () | Error x -> v11 x
    match v12 with
    | US12_1(v16) -> (* Error *)
        let v17 : US0 = US0_4
        let v18 : (unit -> string) = closure45()
        let v19 : (unit -> struct (string * std_string_String)) = closure46(v4, v16)
        method56(v17, v18, v19)
    | US12_0 -> (* Ok *)
        let v13 : US0 = US0_0
        let v14 : (unit -> string) = closure48()
        let v15 : (unit -> string) = closure49(v4)
        method59(v13, v14, v15)
    let v22 : bool = true
    let mutable _v22 : System.IDisposable option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v23 : (unit -> unit) = method61(v4)
    let v24 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v23 "$0()" )
    v24 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v25 : (unit -> unit) = method61(v4)
    let v26 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v25 "$0()" )
    v26 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v27 : (unit -> unit) = method61(v4)
    let v28 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v27 "$0()" )
    v28 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v29 : (unit -> unit) = method62(v4)
    let v30 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v29 () }
    v30 
    #endif
#if FABLE_COMPILER_PYTHON
    let v31 : (unit -> unit) = method62(v4)
    let v32 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v31 () }
    v32 
    #endif
#else
    let v33 : (unit -> unit) = method62(v4)
    let v34 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v33 () }
    v34 
    #endif
    |> fun x -> _v22 <- Some x
    let v35 : System.IDisposable = match _v22 with Some x -> x | None -> failwith "base.run_target / _v22=None"
    v35 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v45 : System.IDisposable = null |> unbox<System.IDisposable>
    v45 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v54 : System.IDisposable = null |> unbox<System.IDisposable>
    v54 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v63 : bool = true
    let mutable _v63 : System.IO.DirectoryInfo option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v66 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    v66 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v75 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    v75 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v84 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    v84 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v93 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    v93 
    #endif
#if FABLE_COMPILER_PYTHON
    let v102 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    v102 
    #endif
#else
    let v109 : (string -> System.IO.DirectoryInfo) = System.IO.Directory.CreateDirectory
    let v110 : System.IO.DirectoryInfo = v109 v0
    v110 
    #endif
    |> fun x -> _v63 <- Some x
    let v111 : System.IO.DirectoryInfo = match _v63 with Some x -> x | None -> failwith "base.run_target / _v63=None"
    let v128 : bool = true
    let mutable _v128 : bool option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v131 : bool = null |> unbox<bool>
    v131 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v140 : bool = null |> unbox<bool>
    v140 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v149 : bool = null |> unbox<bool>
    v149 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v158 : bool = null |> unbox<bool>
    v158 
    #endif
#if FABLE_COMPILER_PYTHON
    let v167 : bool = null |> unbox<bool>
    v167 
    #endif
#else
    let v174 : bool = v111.Exists
    v174 
    #endif
    |> fun x -> _v128 <- Some x
    let v175 : bool = match _v128 with Some x -> x | None -> failwith "base.run_target / _v128=None"
    let v190 : bool = v175 = false
    if v190 then
        let v193 : bool = true
        let mutable _v193 : System.DateTime option = None 
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v196 : System.DateTime = null |> unbox<System.DateTime>
        v196 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v205 : System.DateTime = null |> unbox<System.DateTime>
        v205 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v214 : System.DateTime = null |> unbox<System.DateTime>
        v214 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v223 : System.DateTime = null |> unbox<System.DateTime>
        v223 
        #endif
#if FABLE_COMPILER_PYTHON
        let v232 : System.DateTime = null |> unbox<System.DateTime>
        v232 
        #endif
#else
        let v239 : System.DateTime = v111.CreationTime
        v239 
        #endif
        |> fun x -> _v193 <- Some x
        let v240 : System.DateTime = match _v193 with Some x -> x | None -> failwith "base.run_target / _v193=None"
        let v255 : obj = {| Exists = v175; CreationTime = v240 |}
        let v258 : string = $"%A{v255}"
        let v265 : US0 = US0_1
        let v266 : (unit -> string) = closure52()
        let v267 : (unit -> struct (string * string)) = closure53(v0, v258)
        method63(v265, v266, v267)
    let v270 : bool = true
    let mutable _v270 : System.IDisposable option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v271 : (unit -> unit) = method65(v0)
    let v272 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v271 "$0()" )
    v272 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v273 : (unit -> unit) = method65(v0)
    let v274 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v273 "$0()" )
    v274 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v275 : (unit -> unit) = method65(v0)
    let v276 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v275 "$0()" )
    v276 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v277 : (unit -> unit) = method66(v0)
    let v278 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v277 () }
    v278 
    #endif
#if FABLE_COMPILER_PYTHON
    let v279 : (unit -> unit) = method66(v0)
    let v280 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v279 () }
    v280 
    #endif
#else
    let v281 : (unit -> unit) = method66(v0)
    let v282 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v281 () }
    v282 
    #endif
    |> fun x -> _v270 <- Some x
    let v283 : System.IDisposable = match _v270 with Some x -> x | None -> failwith "base.run_target / _v270=None"
    v283 
    #endif
#if FABLE_COMPILER_PYTHON
    let v293 : bool = true
    let mutable _v293 : System.IO.DirectoryInfo option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v296 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    v296 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v305 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    v305 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v314 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    v314 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v323 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    v323 
    #endif
#if FABLE_COMPILER_PYTHON
    let v332 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    v332 
    #endif
#else
    let v339 : (string -> System.IO.DirectoryInfo) = System.IO.Directory.CreateDirectory
    let v340 : System.IO.DirectoryInfo = v339 v0
    v340 
    #endif
    |> fun x -> _v293 <- Some x
    let v341 : System.IO.DirectoryInfo = match _v293 with Some x -> x | None -> failwith "base.run_target / _v293=None"
    let v358 : bool = true
    let mutable _v358 : bool option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v361 : bool = null |> unbox<bool>
    v361 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v370 : bool = null |> unbox<bool>
    v370 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v379 : bool = null |> unbox<bool>
    v379 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v388 : bool = null |> unbox<bool>
    v388 
    #endif
#if FABLE_COMPILER_PYTHON
    let v397 : bool = null |> unbox<bool>
    v397 
    #endif
#else
    let v404 : bool = v341.Exists
    v404 
    #endif
    |> fun x -> _v358 <- Some x
    let v405 : bool = match _v358 with Some x -> x | None -> failwith "base.run_target / _v358=None"
    let v420 : bool = v405 = false
    if v420 then
        let v423 : bool = true
        let mutable _v423 : System.DateTime option = None 
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v426 : System.DateTime = null |> unbox<System.DateTime>
        v426 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v435 : System.DateTime = null |> unbox<System.DateTime>
        v435 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v444 : System.DateTime = null |> unbox<System.DateTime>
        v444 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v453 : System.DateTime = null |> unbox<System.DateTime>
        v453 
        #endif
#if FABLE_COMPILER_PYTHON
        let v462 : System.DateTime = null |> unbox<System.DateTime>
        v462 
        #endif
#else
        let v469 : System.DateTime = v341.CreationTime
        v469 
        #endif
        |> fun x -> _v423 <- Some x
        let v470 : System.DateTime = match _v423 with Some x -> x | None -> failwith "base.run_target / _v423=None"
        let v485 : obj = {| Exists = v405; CreationTime = v470 |}
        let v488 : string = $"%A{v485}"
        let v495 : US0 = US0_1
        let v496 : (unit -> string) = closure52()
        let v497 : (unit -> struct (string * string)) = closure53(v0, v488)
        method63(v495, v496, v497)
    let v500 : bool = true
    let mutable _v500 : System.IDisposable option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v501 : (unit -> unit) = method65(v0)
    let v502 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v501 "$0()" )
    v502 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v503 : (unit -> unit) = method65(v0)
    let v504 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v503 "$0()" )
    v504 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v505 : (unit -> unit) = method65(v0)
    let v506 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v505 "$0()" )
    v506 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v507 : (unit -> unit) = method66(v0)
    let v508 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v507 () }
    v508 
    #endif
#if FABLE_COMPILER_PYTHON
    let v509 : (unit -> unit) = method66(v0)
    let v510 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v509 () }
    v510 
    #endif
#else
    let v511 : (unit -> unit) = method66(v0)
    let v512 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v511 () }
    v512 
    #endif
    |> fun x -> _v500 <- Some x
    let v513 : System.IDisposable = match _v500 with Some x -> x | None -> failwith "base.run_target / _v500=None"
    v513 
    #endif
#else
    let v523 : bool = true
    let mutable _v523 : System.IO.DirectoryInfo option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v526 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    v526 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v535 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    v535 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v544 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    v544 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v553 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    v553 
    #endif
#if FABLE_COMPILER_PYTHON
    let v562 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    v562 
    #endif
#else
    let v569 : (string -> System.IO.DirectoryInfo) = System.IO.Directory.CreateDirectory
    let v570 : System.IO.DirectoryInfo = v569 v0
    v570 
    #endif
    |> fun x -> _v523 <- Some x
    let v571 : System.IO.DirectoryInfo = match _v523 with Some x -> x | None -> failwith "base.run_target / _v523=None"
    let v588 : bool = true
    let mutable _v588 : bool option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v591 : bool = null |> unbox<bool>
    v591 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v600 : bool = null |> unbox<bool>
    v600 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v609 : bool = null |> unbox<bool>
    v609 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v618 : bool = null |> unbox<bool>
    v618 
    #endif
#if FABLE_COMPILER_PYTHON
    let v627 : bool = null |> unbox<bool>
    v627 
    #endif
#else
    let v634 : bool = v571.Exists
    v634 
    #endif
    |> fun x -> _v588 <- Some x
    let v635 : bool = match _v588 with Some x -> x | None -> failwith "base.run_target / _v588=None"
    let v650 : bool = v635 = false
    if v650 then
        let v653 : bool = true
        let mutable _v653 : System.DateTime option = None 
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v656 : System.DateTime = null |> unbox<System.DateTime>
        v656 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v665 : System.DateTime = null |> unbox<System.DateTime>
        v665 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v674 : System.DateTime = null |> unbox<System.DateTime>
        v674 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v683 : System.DateTime = null |> unbox<System.DateTime>
        v683 
        #endif
#if FABLE_COMPILER_PYTHON
        let v692 : System.DateTime = null |> unbox<System.DateTime>
        v692 
        #endif
#else
        let v699 : System.DateTime = v571.CreationTime
        v699 
        #endif
        |> fun x -> _v653 <- Some x
        let v700 : System.DateTime = match _v653 with Some x -> x | None -> failwith "base.run_target / _v653=None"
        let v715 : obj = {| Exists = v635; CreationTime = v700 |}
        let v718 : string = $"%A{v715}"
        let v725 : US0 = US0_1
        let v726 : (unit -> string) = closure52()
        let v727 : (unit -> struct (string * string)) = closure53(v0, v718)
        method63(v725, v726, v727)
    let v730 : bool = true
    let mutable _v730 : System.IDisposable option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v731 : (unit -> unit) = method65(v0)
    let v732 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v731 "$0()" )
    v732 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v733 : (unit -> unit) = method65(v0)
    let v734 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v733 "$0()" )
    v734 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v735 : (unit -> unit) = method65(v0)
    let v736 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v735 "$0()" )
    v736 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v737 : (unit -> unit) = method66(v0)
    let v738 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v737 () }
    v738 
    #endif
#if FABLE_COMPILER_PYTHON
    let v739 : (unit -> unit) = method66(v0)
    let v740 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v739 () }
    v740 
    #endif
#else
    let v741 : (unit -> unit) = method66(v0)
    let v742 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v741 () }
    v742 
    #endif
    |> fun x -> _v730 <- Some x
    let v743 : System.IDisposable = match _v730 with Some x -> x | None -> failwith "base.run_target / _v730=None"
    v743 
    #endif
    |> fun x -> _v3 <- Some x
    let v751 : System.IDisposable = match _v3 with Some x -> x | None -> failwith "base.run_target / _v3=None"
    v751
and closure41 () () : struct (string * System.IDisposable) =
    let v0 : string = method40()
    let v1 : System.IDisposable = method53(v0)
    struct (v0, v1)
and method67 (v0 : string) : System.Guid =
    let v3 : bool = true
    let mutable _v3 : System.Guid option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v6 : string = v0.PadLeft (32, '0')
    let v38 : System.Guid = System.Guid $"{v6.[0..7]}-{v6.[8..11]}-{v6.[12..15]}-{v6.[16..19]}-{v6.[20..31]}"
    v38 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v47 : string = v0.PadLeft (32, '0')
    let v79 : System.Guid = System.Guid $"{v47.[0..7]}-{v47.[8..11]}-{v47.[12..15]}-{v47.[16..19]}-{v47.[20..31]}"
    v79 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v88 : System.Guid = null |> unbox<System.Guid>
    v88 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v97 : string = v0.PadLeft (32, '0')
    let v129 : System.Guid = System.Guid $"{v97.[0..7]}-{v97.[8..11]}-{v97.[12..15]}-{v97.[16..19]}-{v97.[20..31]}"
    v129 
    #endif
#if FABLE_COMPILER_PYTHON
    let v138 : string = v0.PadLeft (32, '0')
    let v170 : System.Guid = System.Guid $"{v138.[0..7]}-{v138.[8..11]}-{v138.[12..15]}-{v138.[16..19]}-{v138.[20..31]}"
    v170 
    #endif
#else
    let v179 : string = v0.PadLeft (32, '0')
    let v211 : System.Guid = System.Guid $"{v179.[0..7]}-{v179.[8..11]}-{v179.[12..15]}-{v179.[16..19]}-{v179.[20..31]}"
    v211 
    #endif
    |> fun x -> _v3 <- Some x
    let v218 : System.Guid = match _v3 with Some x -> x | None -> failwith "base.run_target / _v3=None"
    v218
and closure56 () (v0 : string) : struct (string * System.IDisposable) =
    let v1 : System.Guid = method67(v0)
    let v2 : string = method45(v1)
    let v3 : System.IDisposable = method53(v2)
    struct (v2, v3)
and closure57 () () : string =
    let v0 : string = __SOURCE_DIRECTORY__
    v0
and method69 () : string =
    let v0 : string = ""
    v0
and method70 (v0 : string) : string =
    v0
and method71 () : string =
    let v0 : string = "^\\\\\\\\\\?\\\\"
    v0
and method68 (v0 : string) : string =
    let v2 : bool = v0 = ""
    if v2 then
        let v3 : string = ""
        v3
    else
        let v4 : string = method69()
        let v7 : bool = true
        let mutable _v7 : string option = None 
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v8 : string = method70(v0)
        let v9 : string = $"regex::Regex::new(&$0)"
        let v10 : string = "^\\\\\\\\\\?\\\\"
        let v11 : Result<regex_Regex, regex_Error> = Fable.Core.RustInterop.emitRustExpr v10 v9 
        let v12 : string = "$0.unwrap()"
        let v13 : regex_Regex = Fable.Core.RustInterop.emitRustExpr v11 v12 
        let v14 : string = $"$0.replace_all(&$1, &*$2)"
        let v15 : std_borrow_Cow<Str> = Fable.Core.RustInterop.emitRustExpr struct (v13, v8, v4) v14 
        let v16 : string = "String::from($0)"
        let v17 : std_string_String = Fable.Core.RustInterop.emitRustExpr v15 v16 
        let v18 : string = "fable_library_rust::String_::fromString($0)"
        let v19 : string = Fable.Core.RustInterop.emitRustExpr v17 v18 
        v19 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v22 : string = null |> unbox<string>
        v22 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v31 : string = null |> unbox<string>
        v31 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v40 : string = null |> unbox<string>
        v40 
        #endif
#if FABLE_COMPILER_PYTHON
        let v49 : string = null |> unbox<string>
        v49 
        #endif
#else
        let v56 : string = method71()
        let v57 : string = System.Text.RegularExpressions.Regex.Replace (v0, v56, v4)
        v57 
        #endif
        |> fun x -> _v7 <- Some x
        let v58 : string = match _v7 with Some x -> x | None -> failwith "base.run_target / _v7=None"
        let v73 : string = $"{v58.[0] |> string |> _.ToLower()}{v58.[1..]}"
        let v74 : string = "\\"
        let v75 : string = "/"
        let v76 : string = v73.Replace (v74, v75)
        v76
and closure58 () (v0 : string) : string =
    method68(v0)
and closure59 () (v0 : string) : string =
    let v1 : char list = []
    let v4 : char list = '/' :: v1 
    let v15 : (char list -> (char [])) = List.toArray
    let v16 : (char []) = v15 v4
    let v23 : string = v0.TrimStart v16 
    let v63 : string = $"file:///{v23}"
    v63
and method74 (v0 : string) : string option =
    let v3 : bool = true
    let mutable _v3 : US3 option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v4 : string = "&*$0"
    let v5 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v4 
    let v6 : string = "String::from($0)"
    let v7 : std_string_String = Fable.Core.RustInterop.emitRustExpr v5 v6 
    let v8 : string = "std::path::PathBuf::from($0)"
    let v9 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v7 v8 
    let v10 : string = "$0.parent().map(std::path::PathBuf::from)"
    let v11 : std_path_PathBuf option = Fable.Core.RustInterop.emitRustExpr v9 v10 
    let v12 : string = "$0?"
    let v13 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v11 v12 
    let v14 : string = "$0.display()"
    let v15 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v13 v14 
    let v18 : bool = true
    let mutable _v18 : std_string_String option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v19 : string = "format!(\"{}\", $0)"
    let v20 : std_string_String = Fable.Core.RustInterop.emitRustExpr v15 v19 
    v20 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v21 : string = "format!(\"{}\", $0)"
    let v22 : std_string_String = Fable.Core.RustInterop.emitRustExpr v15 v21 
    v22 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v23 : string = "format!(\"{}\", $0)"
    let v24 : std_string_String = Fable.Core.RustInterop.emitRustExpr v15 v23 
    v24 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v27 : std_string_String = null |> unbox<std_string_String>
    v27 
    #endif
#if FABLE_COMPILER_PYTHON
    let v36 : std_string_String = null |> unbox<std_string_String>
    v36 
    #endif
#else
    let v45 : std_string_String = null |> unbox<std_string_String>
    v45 
    #endif
    |> fun x -> _v18 <- Some x
    let v52 : std_string_String = match _v18 with Some x -> x | None -> failwith "base.run_target / _v18=None"
    let v67 : string = "fable_library_rust::String_::fromString($0)"
    let v68 : string = Fable.Core.RustInterop.emitRustExpr v52 v67 
    let v69 : US3 = US3_0(v68)
    v69 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v72 : US3 = null |> unbox<US3>
    v72 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v81 : US3 = null |> unbox<US3>
    v81 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v88 : string = "path"
    let v89 : IPathDirname = Fable.Core.JsInterop.importAll v88 
    let v90 : string = "v89.dirname($0)"
    let v91 : string = Fable.Core.JsInterop.emitJsExpr v0 v90 
    let v92 : US3 = US3_0(v91)
    v92 
    #endif
#if FABLE_COMPILER_PYTHON
    let v95 : US3 = null |> unbox<US3>
    v95 
    #endif
#else
    let v102 : (string -> System.IO.DirectoryInfo) = System.IO.Directory.GetParent
    let v103 : System.IO.DirectoryInfo = v102 v0
    let v106 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    let v115 : bool = v103 = v106 
    let v188 : US3 =
        if v115 then
            US3_1
        else
            let v125 : bool = true
            let mutable _v125 : string option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v128 : string = null |> unbox<string>
            v128 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v137 : string = null |> unbox<string>
            v137 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v146 : string = null |> unbox<string>
            v146 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v155 : string = null |> unbox<string>
            v155 
            #endif
#if FABLE_COMPILER_PYTHON
            let v164 : string = null |> unbox<string>
            v164 
            #endif
#else
            let v171 : string = v103.FullName
            v171 
            #endif
            |> fun x -> _v125 <- Some x
            let v172 : string = match _v125 with Some x -> x | None -> failwith "base.run_target / _v125=None"
            US3_0(v172)
    v188 
    #endif
    |> fun x -> _v3 <- Some x
    let v189 : US3 = match _v3 with Some x -> x | None -> failwith "base.run_target / _v3=None"
    match v189 with
    | US3_1 -> (* None *)
        let v214 : string option = None
        v214
    | US3_0(v204) -> (* Some *)
        let v207 : string option = Some v204 
        v207
and closure61 () (v0 : string) : string option =
    method74(v0)
and method73 () : (string -> string option) =
    closure61()
and method75 (v0 : string, v1 : string, v2 : string) : US13 =
    let v3 : string = method48(v2, v0)
    let v4 : bool = method7(v3)
    if v4 then
        US13_0(v2)
    else
        let v6 : (string -> string option) = method73()
        let v7 : string option = v6 v2
        let v10 : US3 option = None
        let _v10 = ref v10 
        match v7 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v11 : string = x
        let v12 : US3 = US3_0(v11)
        v12 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v10.Value <- x
        let v13 : US3 option = _v10.Value 
        let v36 : US3 = US3_1
        let v37 : US3 = v13 |> Option.defaultValue v36 
        match v37 with
        | US3_1 -> (* None *)
            let v47 : string = $"""No parent for {if false then "file" else "dir"} '{v0}' at '{v1}' (until '{v2}')"""
            US13_1(v47)
        | US3_0(v45) -> (* Some *)
            method75(v0, v1, v45)
and method72 (v0 : string, v1 : string) : US13 =
    let v2 : string = method48(v1, v0)
    let v3 : bool = method7(v2)
    if v3 then
        US13_0(v1)
    else
        let v5 : (string -> string option) = method73()
        let v6 : string option = v5 v1
        let v9 : US3 option = None
        let _v9 = ref v9 
        match v6 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v10 : string = x
        let v11 : US3 = US3_0(v10)
        v11 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v9.Value <- x
        let v12 : US3 option = _v9.Value 
        let v35 : US3 = US3_1
        let v36 : US3 = v12 |> Option.defaultValue v35 
        match v36 with
        | US3_1 -> (* None *)
            let v46 : string = $"""No parent for {if false then "file" else "dir"} '{v0}' at '{v1}' (until '{v1}')"""
            US13_1(v46)
        | US3_0(v44) -> (* Some *)
            method75(v0, v1, v44)
and closure62 () () : string =
    let v0 : string = "file_system.get_workspace_root"
    v0
and closure63 (v0 : string) () : string =
    v0
and method77 (v0 : Mut4, v1 : string) : unit =
    let v2 : string = "{ "
    method14(v0, v2)
    method15(v0)
    let v3 : string = "error"
    method14(v0, v3)
    let v4 : string = " = "
    method14(v0, v4)
    method14(v0, v1)
    let v5 : string = " }"
    method14(v0, v5)
and closure64 (v0 : US0, v1 : (unit -> string), v2 : (unit -> string)) () : string =
    let v5 : (US0 -> struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option)) = closure0()
    let v6 : US0 = US0_0
    if State.trace_state.IsNone then State.trace_state <- v5 v6 |> Some
    let struct (v14 : Mut0, v15 : Mut1, v16 : Mut2, v17 : Mut3, v18 : int64 option) = State.trace_state.Value
    let v35 : bool = true
    let mutable _v35 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v38 : US2 option = None
    let _v38 = ref v38 
    match v18 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v39 : int64 = x
    let v40 : US2 = US2_0(v39)
    v40 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v38.Value <- x
    let v41 : US2 option = _v38.Value 
    let v64 : US2 = US2_1
    let v65 : US2 = v41 |> Option.defaultValue v64 
    let v163 : System.DateTime =
        match v65 with
        | US2_1 -> (* None *)
            let v155 : System.DateTime = System.DateTime.Now
            v155
        | US2_0(v73) -> (* Some *)
            let v76 : System.DateTime = System.DateTime.Now
            let v85 : (System.DateTime -> int64) = _.Ticks
            let v86 : int64 = v85 v76
            let v93 : int64 = v86 - v73
            let v96 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v97 : System.TimeSpan = v96 v93
            let v106 : (System.TimeSpan -> int32) = _.Hours
            let v107 : int32 = v106 v97
            let v116 : (System.TimeSpan -> int32) = _.Minutes
            let v117 : int32 = v116 v97
            let v126 : (System.TimeSpan -> int32) = _.Seconds
            let v127 : int32 = v126 v97
            let v136 : (System.TimeSpan -> int32) = _.Milliseconds
            let v137 : int32 = v136 v97
            let v146 : System.DateTime = System.DateTime (1, 1, 1, v107, v117, v127, v137)
            v146
    let v166 : string = method10()
    let v175 : (string -> string) = v163.ToString
    let v176 : string = v175 v166
    v176 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v185 : US2 option = None
    let _v185 = ref v185 
    match v18 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v186 : int64 = x
    let v187 : US2 = US2_0(v186)
    v187 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v185.Value <- x
    let v188 : US2 option = _v185.Value 
    let v211 : US2 = US2_1
    let v212 : US2 = v188 |> Option.defaultValue v211 
    let v310 : System.DateTime =
        match v212 with
        | US2_1 -> (* None *)
            let v302 : System.DateTime = System.DateTime.Now
            v302
        | US2_0(v220) -> (* Some *)
            let v223 : System.DateTime = System.DateTime.Now
            let v232 : (System.DateTime -> int64) = _.Ticks
            let v233 : int64 = v232 v223
            let v240 : int64 = v233 - v220
            let v243 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v244 : System.TimeSpan = v243 v240
            let v253 : (System.TimeSpan -> int32) = _.Hours
            let v254 : int32 = v253 v244
            let v263 : (System.TimeSpan -> int32) = _.Minutes
            let v264 : int32 = v263 v244
            let v273 : (System.TimeSpan -> int32) = _.Seconds
            let v274 : int32 = v273 v244
            let v283 : (System.TimeSpan -> int32) = _.Milliseconds
            let v284 : int32 = v283 v244
            let v293 : System.DateTime = System.DateTime (1, 1, 1, v254, v264, v274, v284)
            v293
    let v313 : string = method10()
    let v322 : (string -> string) = v310.ToString
    let v323 : string = v322 v313
    v323 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v330 : string = $"near_sdk::env::block_timestamp()"
    let v331 : uint64 = Fable.Core.RustInterop.emitRustExpr () v330 
    let v334 : US2 option = None
    let _v334 = ref v334 
    match v18 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v335 : int64 = x
    let v336 : US2 = US2_0(v335)
    v336 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v334.Value <- x
    let v337 : US2 option = _v334.Value 
    let v360 : US2 = US2_1
    let v361 : US2 = v337 |> Option.defaultValue v360 
    let v374 : uint64 =
        match v361 with
        | US2_1 -> (* None *)
            v331
        | US2_0(v369) -> (* Some *)
            let v370 : (int64 -> uint64) = uint64
            let v371 : uint64 = v370 v369
            let v372 : uint64 = v331 - v371
            v372
    let v375 : uint64 = v374 / 1000000000UL
    let v376 : uint64 = v375 % 60UL
    let v377 : uint64 = v375 / 60UL
    let v378 : uint64 = v377 % 60UL
    let v379 : uint64 = v375 / 3600UL
    let v380 : uint64 = v379 % 24UL
    let v381 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
    let v382 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v380, v378, v376) v381 
    let v383 : string = "fable_library_rust::String_::fromString($0)"
    let v384 : string = Fable.Core.RustInterop.emitRustExpr v382 v383 
    v384 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v387 : US2 option = None
    let _v387 = ref v387 
    match v18 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v388 : int64 = x
    let v389 : US2 = US2_0(v388)
    v389 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v387.Value <- x
    let v390 : US2 option = _v387.Value 
    let v413 : US2 = US2_1
    let v414 : US2 = v390 |> Option.defaultValue v413 
    let v512 : System.DateTime =
        match v414 with
        | US2_1 -> (* None *)
            let v504 : System.DateTime = System.DateTime.Now
            v504
        | US2_0(v422) -> (* Some *)
            let v425 : System.DateTime = System.DateTime.Now
            let v434 : (System.DateTime -> int64) = _.Ticks
            let v435 : int64 = v434 v425
            let v442 : int64 = v435 - v422
            let v445 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v446 : System.TimeSpan = v445 v442
            let v455 : (System.TimeSpan -> int32) = _.Hours
            let v456 : int32 = v455 v446
            let v465 : (System.TimeSpan -> int32) = _.Minutes
            let v466 : int32 = v465 v446
            let v475 : (System.TimeSpan -> int32) = _.Seconds
            let v476 : int32 = v475 v446
            let v485 : (System.TimeSpan -> int32) = _.Milliseconds
            let v486 : int32 = v485 v446
            let v495 : System.DateTime = System.DateTime (1, 1, 1, v456, v466, v476, v486)
            v495
    let v515 : string = method11()
    let v524 : (string -> string) = v512.ToString
    let v525 : string = v524 v515
    v525 
    #endif
#if FABLE_COMPILER_PYTHON
    let v534 : US2 option = None
    let _v534 = ref v534 
    match v18 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v535 : int64 = x
    let v536 : US2 = US2_0(v535)
    v536 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v534.Value <- x
    let v537 : US2 option = _v534.Value 
    let v560 : US2 = US2_1
    let v561 : US2 = v537 |> Option.defaultValue v560 
    let v659 : System.DateTime =
        match v561 with
        | US2_1 -> (* None *)
            let v651 : System.DateTime = System.DateTime.Now
            v651
        | US2_0(v569) -> (* Some *)
            let v572 : System.DateTime = System.DateTime.Now
            let v581 : (System.DateTime -> int64) = _.Ticks
            let v582 : int64 = v581 v572
            let v589 : int64 = v582 - v569
            let v592 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v593 : System.TimeSpan = v592 v589
            let v602 : (System.TimeSpan -> int32) = _.Hours
            let v603 : int32 = v602 v593
            let v612 : (System.TimeSpan -> int32) = _.Minutes
            let v613 : int32 = v612 v593
            let v622 : (System.TimeSpan -> int32) = _.Seconds
            let v623 : int32 = v622 v593
            let v632 : (System.TimeSpan -> int32) = _.Milliseconds
            let v633 : int32 = v632 v593
            let v642 : System.DateTime = System.DateTime (1, 1, 1, v603, v613, v623, v633)
            v642
    let v662 : string = method11()
    let v671 : (string -> string) = v659.ToString
    let v672 : string = v671 v662
    v672 
    #endif
#else
    let v681 : US2 option = None
    let _v681 = ref v681 
    match v18 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v682 : int64 = x
    let v683 : US2 = US2_0(v682)
    v683 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v681.Value <- x
    let v684 : US2 option = _v681.Value 
    let v707 : US2 = US2_1
    let v708 : US2 = v684 |> Option.defaultValue v707 
    let v806 : System.DateTime =
        match v708 with
        | US2_1 -> (* None *)
            let v798 : System.DateTime = System.DateTime.Now
            v798
        | US2_0(v716) -> (* Some *)
            let v719 : System.DateTime = System.DateTime.Now
            let v728 : (System.DateTime -> int64) = _.Ticks
            let v729 : int64 = v728 v719
            let v736 : int64 = v729 - v716
            let v739 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v740 : System.TimeSpan = v739 v736
            let v749 : (System.TimeSpan -> int32) = _.Hours
            let v750 : int32 = v749 v740
            let v759 : (System.TimeSpan -> int32) = _.Minutes
            let v760 : int32 = v759 v740
            let v769 : (System.TimeSpan -> int32) = _.Seconds
            let v770 : int32 = v769 v740
            let v779 : (System.TimeSpan -> int32) = _.Milliseconds
            let v780 : int32 = v779 v740
            let v789 : System.DateTime = System.DateTime (1, 1, 1, v750, v760, v770, v780)
            v789
    let v809 : string = method11()
    let v818 : (string -> string) = v806.ToString
    let v819 : string = v818 v809
    v819 
    #endif
    |> fun x -> _v35 <- Some x
    let v826 : string = match _v35 with Some x -> x | None -> failwith "base.run_target / _v35=None"
    let v981 : bool =
        match v0 with
        | US0_0 -> (* Verbose *)
            true
        | _ ->
            false
    let v985 : US3 =
        if v981 then
            let v982 : string = "Verbose"
            US3_0(v982)
        else
            US3_1
    let v1034 : US3 =
        match v985 with
        | US3_1 -> (* None *)
            let v990 : bool =
                match v0 with
                | US0_1 -> (* Debug *)
                    true
                | _ ->
                    false
            let v994 : US3 =
                if v990 then
                    let v991 : string = "Debug"
                    US3_0(v991)
                else
                    US3_1
            match v994 with
            | US3_1 -> (* None *)
                let v999 : bool =
                    match v0 with
                    | US0_2 -> (* Info *)
                        true
                    | _ ->
                        false
                let v1003 : US3 =
                    if v999 then
                        let v1000 : string = "Info"
                        US3_0(v1000)
                    else
                        US3_1
                match v1003 with
                | US3_1 -> (* None *)
                    let v1008 : bool =
                        match v0 with
                        | US0_3 -> (* Warning *)
                            true
                        | _ ->
                            false
                    let v1012 : US3 =
                        if v1008 then
                            let v1009 : string = "Warning"
                            US3_0(v1009)
                        else
                            US3_1
                    match v1012 with
                    | US3_1 -> (* None *)
                        let v1017 : bool =
                            match v0 with
                            | US0_4 -> (* Critical *)
                                true
                            | _ ->
                                false
                        let v1021 : US3 =
                            if v1017 then
                                let v1018 : string = "Critical"
                                US3_0(v1018)
                            else
                                US3_1
                        match v1021 with
                        | US3_1 -> (* None *)
                            US3_1
                        | US3_0(v1022) -> (* Some *)
                            US3_0(v1022)
                    | US3_0(v1013) -> (* Some *)
                        US3_0(v1013)
                | US3_0(v1004) -> (* Some *)
                    US3_0(v1004)
            | US3_0(v995) -> (* Some *)
                US3_0(v995)
        | US3_0(v986) -> (* Some *)
            US3_0(v986)
    let v1038 : string =
        match v1034 with
        | US3_1 -> (* None *)
            failwith<string> "Option does not have a value."
        | US3_0(v1035) -> (* Some *)
            v1035
    let v1041 : (unit -> string) = v1038.ToLower
    let v1042 : string = v1041 ()
    let v1051 : string = v1042.PadLeft (7, ' ')
    let v1083 : bool = true
    let mutable _v1083 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1098 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v1092 : string = "inline_colorization::color_bright_red"
            let v1093 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1092 
            v1093
        | US0_1 -> (* Debug *)
            let v1086 : string = "inline_colorization::color_bright_blue"
            let v1087 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1086 
            v1087
        | US0_2 -> (* Info *)
            let v1088 : string = "inline_colorization::color_bright_green"
            let v1089 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1088 
            v1089
        | US0_0 -> (* Verbose *)
            let v1084 : string = "inline_colorization::color_bright_black"
            let v1085 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1084 
            v1085
        | US0_3 -> (* Warning *)
            let v1090 : string = "inline_colorization::color_yellow"
            let v1091 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1090 
            v1091
    let v1099 : string = "&*$0"
    let v1100 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1051 v1099 
    let v1101 : string = "inline_colorization::color_reset"
    let v1102 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1101 
    let v1103 : string = "\"{v1098}{v1100}{v1102}\""
    let v1104 : string = @$"format!(" + v1103 + ")"
    let v1105 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v1104 
    let v1106 : string = "fable_library_rust::String_::fromString($0)"
    let v1107 : string = Fable.Core.RustInterop.emitRustExpr v1105 v1106 
    v1107 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1122 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v1116 : string = "inline_colorization::color_bright_red"
            let v1117 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1116 
            v1117
        | US0_1 -> (* Debug *)
            let v1110 : string = "inline_colorization::color_bright_blue"
            let v1111 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1110 
            v1111
        | US0_2 -> (* Info *)
            let v1112 : string = "inline_colorization::color_bright_green"
            let v1113 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1112 
            v1113
        | US0_0 -> (* Verbose *)
            let v1108 : string = "inline_colorization::color_bright_black"
            let v1109 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1108 
            v1109
        | US0_3 -> (* Warning *)
            let v1114 : string = "inline_colorization::color_yellow"
            let v1115 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1114 
            v1115
    let v1123 : string = "&*$0"
    let v1124 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1051 v1123 
    let v1125 : string = "inline_colorization::color_reset"
    let v1126 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1125 
    let v1127 : string = "\"{v1122}{v1124}{v1126}\""
    let v1128 : string = @$"format!(" + v1127 + ")"
    let v1129 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v1128 
    let v1130 : string = "fable_library_rust::String_::fromString($0)"
    let v1131 : string = Fable.Core.RustInterop.emitRustExpr v1129 v1130 
    v1131 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1146 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v1140 : string = "inline_colorization::color_bright_red"
            let v1141 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1140 
            v1141
        | US0_1 -> (* Debug *)
            let v1134 : string = "inline_colorization::color_bright_blue"
            let v1135 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1134 
            v1135
        | US0_2 -> (* Info *)
            let v1136 : string = "inline_colorization::color_bright_green"
            let v1137 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1136 
            v1137
        | US0_0 -> (* Verbose *)
            let v1132 : string = "inline_colorization::color_bright_black"
            let v1133 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1132 
            v1133
        | US0_3 -> (* Warning *)
            let v1138 : string = "inline_colorization::color_yellow"
            let v1139 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1138 
            v1139
    let v1147 : string = "&*$0"
    let v1148 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1051 v1147 
    let v1149 : string = "inline_colorization::color_reset"
    let v1150 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1149 
    let v1151 : string = "\"{v1146}{v1148}{v1150}\""
    let v1152 : string = @$"format!(" + v1151 + ")"
    let v1153 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v1152 
    let v1154 : string = "fable_library_rust::String_::fromString($0)"
    let v1155 : string = Fable.Core.RustInterop.emitRustExpr v1153 v1154 
    v1155 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1165 : string =
        match v0 with
        | US0_4 -> (* Critical *)
            let v1160 : string = "\u001b[91m"
            v1160
        | US0_1 -> (* Debug *)
            let v1157 : string = "\u001b[94m"
            v1157
        | US0_2 -> (* Info *)
            let v1158 : string = "\u001b[92m"
            v1158
        | US0_0 -> (* Verbose *)
            let v1156 : string = "\u001b[90m"
            v1156
        | US0_3 -> (* Warning *)
            let v1159 : string = "\u001b[93m"
            v1159
    let v1166 : string = method12()
    let v1167 : string = v1165 + v1051 
    let v1168 : string = v1167 + v1166 
    v1168 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1178 : string =
        match v0 with
        | US0_4 -> (* Critical *)
            let v1173 : string = "\u001b[91m"
            v1173
        | US0_1 -> (* Debug *)
            let v1170 : string = "\u001b[94m"
            v1170
        | US0_2 -> (* Info *)
            let v1171 : string = "\u001b[92m"
            v1171
        | US0_0 -> (* Verbose *)
            let v1169 : string = "\u001b[90m"
            v1169
        | US0_3 -> (* Warning *)
            let v1172 : string = "\u001b[93m"
            v1172
    let v1179 : string = method12()
    let v1180 : string = v1178 + v1051 
    let v1181 : string = v1180 + v1179 
    v1181 
    #endif
#else
    let v1191 : string =
        match v0 with
        | US0_4 -> (* Critical *)
            let v1186 : string = "\u001b[91m"
            v1186
        | US0_1 -> (* Debug *)
            let v1183 : string = "\u001b[94m"
            v1183
        | US0_2 -> (* Info *)
            let v1184 : string = "\u001b[92m"
            v1184
        | US0_0 -> (* Verbose *)
            let v1182 : string = "\u001b[90m"
            v1182
        | US0_3 -> (* Warning *)
            let v1185 : string = "\u001b[93m"
            v1185
    let v1192 : string = method12()
    let v1193 : string = v1191 + v1051 
    let v1194 : string = v1193 + v1192 
    v1194 
    #endif
    |> fun x -> _v1083 <- Some x
    let v1195 : string = match _v1083 with Some x -> x | None -> failwith "base.run_target / _v1083=None"
    let v1214 : int64 = v14.l0
    let v1215 : string = v2 ()
    let v1216 : string = ""
    let v1217 : Mut4 = {l0 = v1216} : Mut4
    method77(v1217, v1215)
    let v1218 : string = v1217.l0
    let v1221 : string = $"{v826} {v1195} #{v1214} %s{v1 ()} / {v1218}"
    let v1228 : char list = []
    let v1233 : (char list -> (char [])) = List.toArray
    let v1234 : (char []) = v1233 v1228
    let v1241 : string = v1221.TrimStart v1234 
    let v1280 : char list = []
    let v1283 : char list = '/' :: v1280 
    let v1292 : char list = ' ' :: v1283 
    let v1303 : (char list -> (char [])) = List.toArray
    let v1304 : (char []) = v1303 v1292
    let v1311 : string = v1241.TrimEnd v1304 
    v1311
and method76 (v0 : US0, v1 : (unit -> string), v2 : (unit -> string)) : unit =
    let v3 : (unit -> string) = closure64(v0, v1, v2)
    method16(v0, v3)
and method78 () : string =
    let v2 : bool = true
    let mutable _v2 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : string = "std::env::current_dir()"
    let v4 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v3 
    let v5 : string = "$0.unwrap()"
    let v6 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v4 v5 
    let v7 : string = "$0.display()"
    let v8 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v6 v7 
    let v11 : bool = true
    let mutable _v11 : std_string_String option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v12 : string = "format!(\"{}\", $0)"
    let v13 : std_string_String = Fable.Core.RustInterop.emitRustExpr v8 v12 
    v13 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v14 : string = "format!(\"{}\", $0)"
    let v15 : std_string_String = Fable.Core.RustInterop.emitRustExpr v8 v14 
    v15 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v16 : string = "format!(\"{}\", $0)"
    let v17 : std_string_String = Fable.Core.RustInterop.emitRustExpr v8 v16 
    v17 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v20 : std_string_String = null |> unbox<std_string_String>
    v20 
    #endif
#if FABLE_COMPILER_PYTHON
    let v29 : std_string_String = null |> unbox<std_string_String>
    v29 
    #endif
#else
    let v38 : std_string_String = null |> unbox<std_string_String>
    v38 
    #endif
    |> fun x -> _v11 <- Some x
    let v45 : std_string_String = match _v11 with Some x -> x | None -> failwith "base.run_target / _v11=None"
    let v60 : string = "fable_library_rust::String_::fromString($0)"
    let v61 : string = Fable.Core.RustInterop.emitRustExpr v45 v60 
    v61 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v64 : string = null |> unbox<string>
    v64 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v73 : string = null |> unbox<string>
    v73 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v82 : string = null |> unbox<string>
    v82 
    #endif
#if FABLE_COMPILER_PYTHON
    let v91 : string = null |> unbox<string>
    v91 
    #endif
#else
    let v98 : (unit -> string) = System.IO.Directory.GetCurrentDirectory
    let v99 : string = v98 ()
    v99 
    #endif
    |> fun x -> _v2 <- Some x
    let v100 : string = match _v2 with Some x -> x | None -> failwith "base.run_target / _v2=None"
    v100
and closure60 () () : string =
    let v0 : string = __SOURCE_DIRECTORY__
    let v1 : string = "polyglot"
    let v2 : string = ".devcontainer"
    let v3 : string = method48(v1, v2)
    let v4 : US13 = method72(v3, v0)
    let v13 : US3 =
        match v4 with
        | US13_1(v7) -> (* Error *)
            let v8 : US0 = US0_3
            let v9 : (unit -> string) = closure62()
            let v10 : (unit -> string) = closure63(v7)
            method76(v8, v9, v10)
            US3_1
        | US13_0(v5) -> (* Ok *)
            US3_0(v5)
    let v29 : US3 =
        match v13 with
        | US3_1 -> (* None *)
            let v16 : string = method78()
            let v17 : string = method48(v1, v2)
            let v18 : US13 = method72(v17, v16)
            match v18 with
            | US13_1(v21) -> (* Error *)
                let v22 : US0 = US0_3
                let v23 : (unit -> string) = closure62()
                let v24 : (unit -> string) = closure63(v21)
                method76(v22, v23, v24)
                US3_1
            | US13_0(v19) -> (* Ok *)
                US3_0(v19)
        | US3_0(v14) -> (* Some *)
            US3_0(v14)
    let v33 : string =
        match v29 with
        | US3_1 -> (* None *)
            failwith<string> "Option does not have a value."
        | US3_0(v30) -> (* Some *)
            v30
    method48(v33, v1)
and method79 (v0 : string) : unit =
    let v3 : bool = true
    let mutable _v3 : unit option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    () 
    #endif
#if FABLE_COMPILER_RUST && WASM
    () 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    () 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    () 
    #endif
#if FABLE_COMPILER_PYTHON
    () 
    #endif
#else
    try
    let v4 : string = method51()
    let v7 : System.DateTime = System.DateTime.Now
    let v16 : (unit -> System.Guid) = System.Guid.NewGuid
    let v17 : System.Guid = v16 ()
    let v24 : System.Guid = method41(v17, v7)
    let v25 : string = $"{v4}_{v24}.txt"
    let v26 : string = __SOURCE_DIRECTORY__
    let v27 : string = "polyglot"
    let v28 : string = ".devcontainer"
    let v29 : string = method48(v27, v28)
    let v30 : US13 = method72(v29, v26)
    let v39 : US3 =
        match v30 with
        | US13_1(v33) -> (* Error *)
            let v34 : US0 = US0_3
            let v35 : (unit -> string) = closure62()
            let v36 : (unit -> string) = closure63(v33)
            method76(v34, v35, v36)
            US3_1
        | US13_0(v31) -> (* Ok *)
            US3_0(v31)
    let v55 : US3 =
        match v39 with
        | US3_1 -> (* None *)
            let v42 : string = method78()
            let v43 : string = method48(v27, v28)
            let v44 : US13 = method72(v43, v42)
            match v44 with
            | US13_1(v47) -> (* Error *)
                let v48 : US0 = US0_3
                let v49 : (unit -> string) = closure62()
                let v50 : (unit -> string) = closure63(v47)
                method76(v48, v49, v50)
                US3_1
            | US13_0(v45) -> (* Ok *)
                US3_0(v45)
        | US3_0(v40) -> (* Some *)
            US3_0(v40)
    let v59 : string =
        match v55 with
        | US3_1 -> (* None *)
            failwith<string> "Option does not have a value."
        | US3_0(v56) -> (* Some *)
            v56
    let v60 : string = method48(v59, v27)
    let v61 : string = "target/trace"
    let v62 : string = method48(v60, v61)
    let v65 : bool = true
    let mutable _v65 : System.IO.DirectoryInfo option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v68 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    v68 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v77 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    v77 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v86 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    v86 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v95 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    v95 
    #endif
#if FABLE_COMPILER_PYTHON
    let v104 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    v104 
    #endif
#else
    let v111 : (string -> System.IO.DirectoryInfo) = System.IO.Directory.CreateDirectory
    let v112 : System.IO.DirectoryInfo = v111 v62
    v112 
    #endif
    |> fun x -> _v65 <- Some x
    let v113 : System.IO.DirectoryInfo = match _v65 with Some x -> x | None -> failwith "base.run_target / _v65=None"
    let v128 : string = method48(v62, v25)
    let v131 : bool = true
    let mutable _v131 : Async<unit> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v134 : Async<unit> = null |> unbox<Async<unit>>
    v134 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v143 : Async<unit> = null |> unbox<Async<unit>>
    v143 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v152 : Async<unit> = null |> unbox<Async<unit>>
    v152 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v161 : Async<unit> = null |> unbox<Async<unit>>
    v161 
    #endif
#if FABLE_COMPILER_PYTHON
    let v170 : Async<unit> = null |> unbox<Async<unit>>
    v170 
    #endif
#else
    let v177 : System.Threading.Tasks.Task = System.IO.File.WriteAllTextAsync (v128, v0)
    let v180 : bool = true
    let mutable _v180 : Async<unit> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v183 : Async<unit> = null |> unbox<Async<unit>>
    v183 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v192 : Async<unit> = null |> unbox<Async<unit>>
    v192 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v201 : Async<unit> = null |> unbox<Async<unit>>
    v201 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v210 : Async<unit> = null |> unbox<Async<unit>>
    v210 
    #endif
#if FABLE_COMPILER_PYTHON
    let v219 : Async<unit> = null |> unbox<Async<unit>>
    v219 
    #endif
#else
    let v226 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
    let v227 : Async<unit> = v226 v177
    v227 
    #endif
    |> fun x -> _v180 <- Some x
    let v228 : Async<unit> = match _v180 with Some x -> x | None -> failwith "base.run_target / _v180=None"
    v228 
    #endif
    |> fun x -> _v131 <- Some x
    let v243 : Async<unit> = match _v131 with Some x -> x | None -> failwith "base.run_target / _v131=None"
    let v260 : bool = true
    let mutable _v260 : unit option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
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
#if FABLE_COMPILER_TYPESCRIPT
    null |> unbox<unit>
    () 
    #endif
#if FABLE_COMPILER_PYTHON
    null |> unbox<unit>
    () 
    #endif
#else
    let v291 : (Async<unit> -> unit) = Async.RunSynchronously
    v291 v243
    () 
    #endif
    |> fun x -> _v260 <- Some x
    match _v260 with Some x -> x | None -> failwith "base.run_target / _v260=None"
    with ex ->
    let v302 : exn = ex
    let v303 : string = $"file_system.trace_file / ex: %A{v302}"
    method79(v303)
    (*
    *)
    () 
    #endif
    |> fun x -> _v3 <- Some x
    match _v3 with Some x -> x | None -> failwith "base.run_target / _v3=None"
    ()
and closure66 () (v0 : string) : unit =
    method79(v0)
and closure65 () (v0 : bool) : unit =
    let v3 : (US0 -> struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option)) = closure0()
    let v4 : US0 = US0_0
    if State.trace_state.IsNone then State.trace_state <- v3 v4 |> Some
    let struct (v12 : Mut0, v13 : Mut1, v14 : Mut2, v15 : Mut3, v16 : int64 option) = State.trace_state.Value
    let v33 : (string -> unit) =
        if v0 then
            closure66()
        else
            closure1()
    v13.l0 <- v33
    ()
and closure68 (v0 : string) (v1 : string) : string =
    method48(v0, v1)
and closure67 () (v0 : string) : (string -> string) =
    closure68(v0)
let v2 : (US0 -> struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option)) = closure0()
let v3 : US0 = US0_0
if State.trace_state.IsNone then State.trace_state <- v2 v3 |> Some
let v9 : (string -> Async<int64>) = closure2()
let delete_directory_async x = v9 x
let v10 : (US6 -> (string -> Async<int64>)) = closure6()
let wait_for_file_access x = v10 x
let v11 : (string -> Async<int64>) = closure11()
let wait_for_file_access_read x = v11 x
let v12 : (string -> Async<string>) = closure12()
let read_all_text_async x = v12 x
let v13 : (string -> (string -> bool)) = closure13()
let file_exists_content x = v13 x
let v14 : (string -> (string -> Async<unit>)) = closure15()
let write_all_text_async x = v14 x
let v15 : (string -> (string -> Async<unit>)) = closure17()
let write_all_text_exists x = v15 x
let v16 : (string -> Async<int64>) = closure19()
let delete_file_async x = v16 x
let v17 : (string -> (string -> Async<int64>)) = closure23()
let move_file_async x = v17 x
let v18 : (string -> Async<string option>) = closure28()
let read_all_text_retry_async x = v18 x
let v19 : (unit -> string) = closure40()
let create_temp_path () = v19 ()
let v20 : (unit -> struct (string * System.IDisposable)) = closure41()
let create_temp_dir () = v20 ()
let v21 : (string -> struct (string * System.IDisposable)) = closure56()
let create_temp_dir' x = v21 x
let v22 : (unit -> string) = closure57()
let get_source_directory () = v22 ()
let v23 : (string -> string) = closure58()
let normalize_path x = v23 x
let v24 : (string -> string) = closure59()
let new_file_uri x = v24 x
let v25 : (unit -> string) = closure60()
let get_workspace_root () = v25 ()
let v26 : (bool -> unit) = closure65()
let init_trace_file x = v26 x
let v27 : (string -> (string -> string)) = closure67()
let (</>) x = v27 x
()
