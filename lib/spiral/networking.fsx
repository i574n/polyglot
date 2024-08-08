#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::string::String")>]
#endif
type std_string_String = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("&$0")>]
#endif
type Ref<'T> = class end
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
    | US4_0 of f0_0 : bool
    | US4_1
and [<Struct>] US5 =
    | US5_0 of f0_0 : bool
    | US5_1 of f1_0 : exn
and [<Struct>] US6 =
    | US6_0 of f0_0 : bool
    | US6_1 of f1_0 : exn
and [<Struct>] US7 =
    | US7_0 of f0_0 : int32
    | US7_1
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
and method5 () : string =
    let v0 : string = "hh:mm:ss"
    v0
and method6 () : string =
    let v0 : string = "HH:mm:ss"
    v0
and method7 () : string =
    let v0 : string = "\u001b[0m"
    v0
and method8 () : string =
    let v0 : string = ""
    v0
and closure3 () () : string =
    let v0 : string = $"networking.test_port_open"
    v0
and closure2 (v0 : string) (v1 : int32) : Async<bool> =
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
#else
    let v18 : Async<bool> option = None
    let mutable _v18 = v18 
    async {
    let v19 : Async<System.Threading.CancellationToken> = Async.CancellationToken
    let! v19 = v19 
    let v20 : System.Threading.CancellationToken = v19 
    let v21 : System.Net.Sockets.TcpClient = new System.Net.Sockets.TcpClient ()
    use v21 = v21 
    let v22 : System.Net.Sockets.TcpClient = v21 
    try
    let v23 : System.Threading.Tasks.ValueTask = v22.ConnectAsync (v0, v1, v20)
    let v24 : (unit -> System.Threading.Tasks.Task) = v23.AsTask
    let v25 : System.Threading.Tasks.Task = v24 ()
    let v26 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v27 : Async<unit> = null |> unbox<Async<unit>>
    let _v26 = v27 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v30 : Async<unit> = null |> unbox<Async<unit>>
    let _v26 = v30 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v33 : Async<unit> = null |> unbox<Async<unit>>
    let _v26 = v33 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v36 : Async<unit> = null |> unbox<Async<unit>>
    let _v26 = v36 
    #endif
#if FABLE_COMPILER_PYTHON
    let v39 : Async<unit> = null |> unbox<Async<unit>>
    let _v26 = v39 
    #endif
#else
    let v42 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
    let v43 : Async<unit> = v42 v25
    let _v26 = v43 
    #endif
    let v44 : Async<unit> = _v26 
    do! v44 
    return true 
    with ex ->
    let v49 : exn = ex
    let v50 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v51 : string = $"%A{v49}"
    let _v50 = v51 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v54 : string = $"%A{v49}"
    let _v50 = v54 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v57 : string = $"%A{v49}"
    let _v50 = v57 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v60 : string = $"%A{v49}"
    let _v50 = v60 
    #endif
#if FABLE_COMPILER_PYTHON
    let v63 : string = $"%A{v49}"
    let _v50 = v63 
    #endif
#else
    let v66 : string = $"{v49.GetType ()}: {v49.Message}"
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
            let v130 : bool = 0 >= v129
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
        let v218 : string = method5()
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
        let v281 : string = method5()
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
        let v381 : string = method6()
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
        let v444 : string = method6()
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
        let v507 : string = method6()
        let v510 : (string -> string) = v506.ToString
        let v511 : string = v510 v507
        let _v161 = v511 
        #endif
        let v514 : string = _v161 
        let v579 : string = "Verbose"
        let v580 : (unit -> string) = v579.ToLower
        let v581 : string = v580 ()
        let v584 : string = v581.PadLeft (7, ' ')
        let v598 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v599 : string = "inline_colorization::color_bright_black"
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
        let v610 : string = "inline_colorization::color_bright_black"
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
        let v621 : string = "inline_colorization::color_bright_black"
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
        let v632 : string = "\u001b[90m"
        let v633 : string = method7()
        let v634 : string = v632 + v584 
        let v635 : string = v634 + v633 
        let _v598 = v635 
        #endif
#if FABLE_COMPILER_PYTHON
        let v636 : string = "\u001b[90m"
        let v637 : string = method7()
        let v638 : string = v636 + v584 
        let v639 : string = v638 + v637 
        let _v598 = v639 
        #endif
#else
        let v640 : string = "\u001b[90m"
        let v641 : string = method7()
        let v642 : string = v640 + v584 
        let v643 : string = v642 + v641 
        let _v598 = v643 
        #endif
        let v644 : string = _v598 
        let v650 : int64 = v146.l0
        let v651 : string = method8()
        let v652 : Mut4 = {l0 = v651} : Mut4
        let v653 : string = "{ "
        let v654 : string = $"{v653}"
        let v657 : string = v652.l0
        let v658 : string = v657 + v654 
        v652.l0 <- v658
        let v659 : string = "port"
        let v660 : string = $"{v659}"
        let v663 : string = v652.l0
        let v664 : string = v663 + v660 
        v652.l0 <- v664
        let v665 : string = " = "
        let v666 : string = $"{v665}"
        let v669 : string = v652.l0
        let v670 : string = v669 + v666 
        v652.l0 <- v670
        let v671 : string = $"{v1}"
        let v674 : string = v652.l0
        let v675 : string = v674 + v671 
        v652.l0 <- v675
        let v676 : string = "; "
        let v677 : string = $"{v676}"
        let v680 : string = v652.l0
        let v681 : string = v680 + v677 
        v652.l0 <- v681
        let v682 : string = "ex"
        let v683 : string = $"{v682}"
        let v686 : string = v652.l0
        let v687 : string = v686 + v683 
        v652.l0 <- v687
        let v688 : string = $"{v665}"
        let v691 : string = v652.l0
        let v692 : string = v691 + v688 
        v652.l0 <- v692
        let v693 : string = $"{v67}"
        let v696 : string = v652.l0
        let v697 : string = v696 + v693 
        v652.l0 <- v697
        let v698 : string = " }"
        let v699 : string = $"{v698}"
        let v702 : string = v652.l0
        let v703 : string = v702 + v699 
        v652.l0 <- v703
        let v704 : string = v652.l0
        let v705 : (unit -> string) = closure3()
        let v706 : string = $"{v514} {v644} #{v650} %s{v705 ()} / {v704}"
        let v709 : char list = []
        let v710 : (char list -> (char [])) = List.toArray
        let v711 : (char []) = v710 v709
        let v714 : string = v706.TrimStart v711 
        let v732 : char list = []
        let v733 : char list = '/' :: v732 
        let v736 : char list = ' ' :: v733 
        let v739 : (char list -> (char [])) = List.toArray
        let v740 : (char []) = v739 v736
        let v743 : string = v714.TrimEnd v740 
        let v761 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v762 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v743 v762 
        let _v761 = () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v763 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v743 v763 
        let _v761 = () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v764 : string = $"near_sdk::log!(\"{{}}\", $0)"
        Fable.Core.RustInterop.emitRustExpr v743 v764 
        let _v761 = () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        System.Console.WriteLine v743 
        let _v761 = () 
        #endif
#if FABLE_COMPILER_PYTHON
        System.Console.WriteLine v743 
        let _v761 = () 
        #endif
#else
        System.Console.WriteLine v743 
        let _v761 = () 
        #endif
        _v761 
        let v765 : (string -> unit) = v85.l0
        v765 v743
    return false 
    (*
    let v766 : bool = *)
    }
    |> fun x -> _v18 <- Some x
    let v767 : Async<bool> = match _v18 with Some x -> x | None -> failwith "async.new_async_unit / _v18=None"
    let _v2 = v767 
    #endif
    let v768 : Async<bool> = _v2 
    v768
and closure1 () (v0 : string) : (int32 -> Async<bool>) =
    closure2(v0)
and closure7 () (v0 : bool) : US5 =
    US5_0(v0)
and closure8 () (v0 : exn) : US5 =
    US5_1(v0)
and closure9 () () : string =
    let v0 : string = "async.run_with_timeout_async"
    v0
and closure10 () () : string =
    let v0 : string = $"async.run_with_timeout_async**"
    v0
and closure6 (v0 : int32, v1 : string) (v2 : int32) : Async<bool> =
    let v3 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v4 : Async<bool> = null |> unbox<Async<bool>>
    let _v3 = v4 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v7 : Async<bool> = null |> unbox<Async<bool>>
    let _v3 = v7 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v10 : Async<bool> = null |> unbox<Async<bool>>
    let _v3 = v10 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v13 : Async<bool> = null |> unbox<Async<bool>>
    let _v3 = v13 
    #endif
#if FABLE_COMPILER_PYTHON
    let v16 : Async<bool> = null |> unbox<Async<bool>>
    let _v3 = v16 
    #endif
#else
    let v19 : Async<bool> option = None
    let mutable _v19 = v19 
    async {
    let v20 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v21 : Async<bool> = null |> unbox<Async<bool>>
    let _v20 = v21 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v24 : Async<bool> = null |> unbox<Async<bool>>
    let _v20 = v24 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v27 : Async<bool> = null |> unbox<Async<bool>>
    let _v20 = v27 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v30 : Async<bool> = null |> unbox<Async<bool>>
    let _v20 = v30 
    #endif
#if FABLE_COMPILER_PYTHON
    let v33 : Async<bool> = null |> unbox<Async<bool>>
    let _v20 = v33 
    #endif
#else
    let v36 : Async<bool> option = None
    let mutable _v36 = v36 
    async {
    let v37 : Async<System.Threading.CancellationToken> = Async.CancellationToken
    let! v37 = v37 
    let v38 : System.Threading.CancellationToken = v37 
    let v39 : System.Net.Sockets.TcpClient = new System.Net.Sockets.TcpClient ()
    use v39 = v39 
    let v40 : System.Net.Sockets.TcpClient = v39 
    try
    let v41 : System.Threading.Tasks.ValueTask = v40.ConnectAsync (v1, v2, v38)
    let v42 : (unit -> System.Threading.Tasks.Task) = v41.AsTask
    let v43 : System.Threading.Tasks.Task = v42 ()
    let v44 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v45 : Async<unit> = null |> unbox<Async<unit>>
    let _v44 = v45 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v48 : Async<unit> = null |> unbox<Async<unit>>
    let _v44 = v48 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v51 : Async<unit> = null |> unbox<Async<unit>>
    let _v44 = v51 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v54 : Async<unit> = null |> unbox<Async<unit>>
    let _v44 = v54 
    #endif
#if FABLE_COMPILER_PYTHON
    let v57 : Async<unit> = null |> unbox<Async<unit>>
    let _v44 = v57 
    #endif
#else
    let v60 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
    let v61 : Async<unit> = v60 v43
    let _v44 = v61 
    #endif
    let v62 : Async<unit> = _v44 
    do! v62 
    return true 
    with ex ->
    let v67 : exn = ex
    let v68 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v69 : string = $"%A{v67}"
    let _v68 = v69 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v72 : string = $"%A{v67}"
    let _v68 = v72 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v75 : string = $"%A{v67}"
    let _v68 = v75 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v78 : string = $"%A{v67}"
    let _v68 = v78 
    #endif
#if FABLE_COMPILER_PYTHON
    let v81 : string = $"%A{v67}"
    let _v68 = v81 
    #endif
#else
    let v84 : string = $"{v67.GetType ()}: {v67.Message}"
    let _v68 = v84 
    #endif
    let v85 : string = _v68 
    let v90 : bool = State.trace_state.IsNone
    if v90 then
        let v91 : US0 = US0_0
        let struct (v92 : Mut0, v93 : Mut1, v94 : Mut2, v95 : Mut3, v96 : int64 option) = method0(v91)
        let v97 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v92, v93, v94, v95, v96) 
        State.trace_state <- v97 
        ()
    let struct (v102 : Mut0, v103 : Mut1, v104 : Mut2, v105 : Mut3, v106 : int64 option) = State.trace_state.Value
    let v117 : bool = State.trace_state.IsNone
    if v117 then
        let v118 : US0 = US0_0
        let struct (v119 : Mut0, v120 : Mut1, v121 : Mut2, v122 : Mut3, v123 : int64 option) = method0(v118)
        let v124 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v119, v120, v121, v122, v123) 
        State.trace_state <- v124 
        ()
    let struct (v129 : Mut0, v130 : Mut1, v131 : Mut2, v132 : Mut3, v133 : int64 option) = State.trace_state.Value
    let v144 : US0 = v132.l0
    let v145 : bool = v131.l0
    let v146 : bool = v145 = false
    let v149 : bool =
        if v146 then
            false
        else
            let v147 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v144
            let v148 : bool = 0 >= v147
            v148
    if v149 then
        let v150 : int64 = v102.l0
        let v151 : int64 = v150 + 1L
        v102.l0 <- v151
        let v152 : bool = State.trace_state.IsNone
        if v152 then
            let v153 : US0 = US0_0
            let struct (v154 : Mut0, v155 : Mut1, v156 : Mut2, v157 : Mut3, v158 : int64 option) = method0(v153)
            let v159 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v154, v155, v156, v157, v158) 
            State.trace_state <- v159 
            ()
        let struct (v164 : Mut0, v165 : Mut1, v166 : Mut2, v167 : Mut3, v168 : int64 option) = State.trace_state.Value
        let v179 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v180 : US3 option = None
        let _v180 = ref v180 
        match v168 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v181 : int64 = x
        let v182 : US3 = US3_0(v181)
        v182 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v180.Value <- x
        let v183 : US3 option = _v180.Value 
        let v194 : US3 = US3_1
        let v195 : US3 = v183 |> Option.defaultValue v194 
        let v235 : System.DateTime =
            match v195 with
            | US3_1 -> (* None *)
                let v231 : System.DateTime = System.DateTime.Now
                v231
            | US3_0(v199) -> (* Some *)
                let v200 : System.DateTime = System.DateTime.Now
                let v203 : (System.DateTime -> int64) = _.Ticks
                let v204 : int64 = v203 v200
                let v207 : int64 = v204 - v199
                let v208 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v209 : System.TimeSpan = v208 v207
                let v212 : (System.TimeSpan -> int32) = _.Hours
                let v213 : int32 = v212 v209
                let v216 : (System.TimeSpan -> int32) = _.Minutes
                let v217 : int32 = v216 v209
                let v220 : (System.TimeSpan -> int32) = _.Seconds
                let v221 : int32 = v220 v209
                let v224 : (System.TimeSpan -> int32) = _.Milliseconds
                let v225 : int32 = v224 v209
                let v228 : System.DateTime = System.DateTime (1, 1, 1, v213, v217, v221, v225)
                v228
        let v236 : string = method5()
        let v239 : (string -> string) = v235.ToString
        let v240 : string = v239 v236
        let _v179 = v240 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v243 : US3 option = None
        let _v243 = ref v243 
        match v168 with
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
        let v298 : System.DateTime =
            match v258 with
            | US3_1 -> (* None *)
                let v294 : System.DateTime = System.DateTime.Now
                v294
            | US3_0(v262) -> (* Some *)
                let v263 : System.DateTime = System.DateTime.Now
                let v266 : (System.DateTime -> int64) = _.Ticks
                let v267 : int64 = v266 v263
                let v270 : int64 = v267 - v262
                let v271 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v272 : System.TimeSpan = v271 v270
                let v275 : (System.TimeSpan -> int32) = _.Hours
                let v276 : int32 = v275 v272
                let v279 : (System.TimeSpan -> int32) = _.Minutes
                let v280 : int32 = v279 v272
                let v283 : (System.TimeSpan -> int32) = _.Seconds
                let v284 : int32 = v283 v272
                let v287 : (System.TimeSpan -> int32) = _.Milliseconds
                let v288 : int32 = v287 v272
                let v291 : System.DateTime = System.DateTime (1, 1, 1, v276, v280, v284, v288)
                v291
        let v299 : string = method5()
        let v302 : (string -> string) = v298.ToString
        let v303 : string = v302 v299
        let _v179 = v303 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v306 : string = $"near_sdk::env::block_timestamp()"
        let v307 : uint64 = Fable.Core.RustInterop.emitRustExpr () v306 
        let v308 : US3 option = None
        let _v308 = ref v308 
        match v168 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v309 : int64 = x
        let v310 : US3 = US3_0(v309)
        v310 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v308.Value <- x
        let v311 : US3 option = _v308.Value 
        let v322 : US3 = US3_1
        let v323 : US3 = v311 |> Option.defaultValue v322 
        let v332 : uint64 =
            match v323 with
            | US3_1 -> (* None *)
                v307
            | US3_0(v327) -> (* Some *)
                let v328 : (int64 -> uint64) = uint64
                let v329 : uint64 = v328 v327
                let v330 : uint64 = v307 - v329
                v330
        let v333 : uint64 = v332 / 1000000000UL
        let v334 : uint64 = v333 % 60UL
        let v335 : uint64 = v333 / 60UL
        let v336 : uint64 = v335 % 60UL
        let v337 : uint64 = v333 / 3600UL
        let v338 : uint64 = v337 % 24UL
        let v339 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
        let v340 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v338, v336, v334) v339 
        let v341 : string = "fable_library_rust::String_::fromString($0)"
        let v342 : string = Fable.Core.RustInterop.emitRustExpr v340 v341 
        let _v179 = v342 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v343 : US3 option = None
        let _v343 = ref v343 
        match v168 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v344 : int64 = x
        let v345 : US3 = US3_0(v344)
        v345 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v343.Value <- x
        let v346 : US3 option = _v343.Value 
        let v357 : US3 = US3_1
        let v358 : US3 = v346 |> Option.defaultValue v357 
        let v398 : System.DateTime =
            match v358 with
            | US3_1 -> (* None *)
                let v394 : System.DateTime = System.DateTime.Now
                v394
            | US3_0(v362) -> (* Some *)
                let v363 : System.DateTime = System.DateTime.Now
                let v366 : (System.DateTime -> int64) = _.Ticks
                let v367 : int64 = v366 v363
                let v370 : int64 = v367 - v362
                let v371 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v372 : System.TimeSpan = v371 v370
                let v375 : (System.TimeSpan -> int32) = _.Hours
                let v376 : int32 = v375 v372
                let v379 : (System.TimeSpan -> int32) = _.Minutes
                let v380 : int32 = v379 v372
                let v383 : (System.TimeSpan -> int32) = _.Seconds
                let v384 : int32 = v383 v372
                let v387 : (System.TimeSpan -> int32) = _.Milliseconds
                let v388 : int32 = v387 v372
                let v391 : System.DateTime = System.DateTime (1, 1, 1, v376, v380, v384, v388)
                v391
        let v399 : string = method6()
        let v402 : (string -> string) = v398.ToString
        let v403 : string = v402 v399
        let _v179 = v403 
        #endif
#if FABLE_COMPILER_PYTHON
        let v406 : US3 option = None
        let _v406 = ref v406 
        match v168 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v407 : int64 = x
        let v408 : US3 = US3_0(v407)
        v408 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v406.Value <- x
        let v409 : US3 option = _v406.Value 
        let v420 : US3 = US3_1
        let v421 : US3 = v409 |> Option.defaultValue v420 
        let v461 : System.DateTime =
            match v421 with
            | US3_1 -> (* None *)
                let v457 : System.DateTime = System.DateTime.Now
                v457
            | US3_0(v425) -> (* Some *)
                let v426 : System.DateTime = System.DateTime.Now
                let v429 : (System.DateTime -> int64) = _.Ticks
                let v430 : int64 = v429 v426
                let v433 : int64 = v430 - v425
                let v434 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v435 : System.TimeSpan = v434 v433
                let v438 : (System.TimeSpan -> int32) = _.Hours
                let v439 : int32 = v438 v435
                let v442 : (System.TimeSpan -> int32) = _.Minutes
                let v443 : int32 = v442 v435
                let v446 : (System.TimeSpan -> int32) = _.Seconds
                let v447 : int32 = v446 v435
                let v450 : (System.TimeSpan -> int32) = _.Milliseconds
                let v451 : int32 = v450 v435
                let v454 : System.DateTime = System.DateTime (1, 1, 1, v439, v443, v447, v451)
                v454
        let v462 : string = method6()
        let v465 : (string -> string) = v461.ToString
        let v466 : string = v465 v462
        let _v179 = v466 
        #endif
#else
        let v469 : US3 option = None
        let _v469 = ref v469 
        match v168 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v470 : int64 = x
        let v471 : US3 = US3_0(v470)
        v471 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v469.Value <- x
        let v472 : US3 option = _v469.Value 
        let v483 : US3 = US3_1
        let v484 : US3 = v472 |> Option.defaultValue v483 
        let v524 : System.DateTime =
            match v484 with
            | US3_1 -> (* None *)
                let v520 : System.DateTime = System.DateTime.Now
                v520
            | US3_0(v488) -> (* Some *)
                let v489 : System.DateTime = System.DateTime.Now
                let v492 : (System.DateTime -> int64) = _.Ticks
                let v493 : int64 = v492 v489
                let v496 : int64 = v493 - v488
                let v497 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v498 : System.TimeSpan = v497 v496
                let v501 : (System.TimeSpan -> int32) = _.Hours
                let v502 : int32 = v501 v498
                let v505 : (System.TimeSpan -> int32) = _.Minutes
                let v506 : int32 = v505 v498
                let v509 : (System.TimeSpan -> int32) = _.Seconds
                let v510 : int32 = v509 v498
                let v513 : (System.TimeSpan -> int32) = _.Milliseconds
                let v514 : int32 = v513 v498
                let v517 : System.DateTime = System.DateTime (1, 1, 1, v502, v506, v510, v514)
                v517
        let v525 : string = method6()
        let v528 : (string -> string) = v524.ToString
        let v529 : string = v528 v525
        let _v179 = v529 
        #endif
        let v532 : string = _v179 
        let v597 : string = "Verbose"
        let v598 : (unit -> string) = v597.ToLower
        let v599 : string = v598 ()
        let v602 : string = v599.PadLeft (7, ' ')
        let v616 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v617 : string = "inline_colorization::color_bright_black"
        let v618 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v617 
        let v619 : string = "&*$0"
        let v620 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v602 v619 
        let v621 : string = "inline_colorization::color_reset"
        let v622 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v621 
        let v623 : string = "\"{v618}{v620}{v622}\""
        let v624 : string = @$"format!(" + v623 + ")"
        let v625 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v624 
        let v626 : string = "fable_library_rust::String_::fromString($0)"
        let v627 : string = Fable.Core.RustInterop.emitRustExpr v625 v626 
        let _v616 = v627 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v628 : string = "inline_colorization::color_bright_black"
        let v629 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v628 
        let v630 : string = "&*$0"
        let v631 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v602 v630 
        let v632 : string = "inline_colorization::color_reset"
        let v633 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v632 
        let v634 : string = "\"{v629}{v631}{v633}\""
        let v635 : string = @$"format!(" + v634 + ")"
        let v636 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v635 
        let v637 : string = "fable_library_rust::String_::fromString($0)"
        let v638 : string = Fable.Core.RustInterop.emitRustExpr v636 v637 
        let _v616 = v638 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v639 : string = "inline_colorization::color_bright_black"
        let v640 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v639 
        let v641 : string = "&*$0"
        let v642 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v602 v641 
        let v643 : string = "inline_colorization::color_reset"
        let v644 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v643 
        let v645 : string = "\"{v640}{v642}{v644}\""
        let v646 : string = @$"format!(" + v645 + ")"
        let v647 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v646 
        let v648 : string = "fable_library_rust::String_::fromString($0)"
        let v649 : string = Fable.Core.RustInterop.emitRustExpr v647 v648 
        let _v616 = v649 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v650 : string = "\u001b[90m"
        let v651 : string = method7()
        let v652 : string = v650 + v602 
        let v653 : string = v652 + v651 
        let _v616 = v653 
        #endif
#if FABLE_COMPILER_PYTHON
        let v654 : string = "\u001b[90m"
        let v655 : string = method7()
        let v656 : string = v654 + v602 
        let v657 : string = v656 + v655 
        let _v616 = v657 
        #endif
#else
        let v658 : string = "\u001b[90m"
        let v659 : string = method7()
        let v660 : string = v658 + v602 
        let v661 : string = v660 + v659 
        let _v616 = v661 
        #endif
        let v662 : string = _v616 
        let v668 : int64 = v164.l0
        let v669 : string = method8()
        let v670 : Mut4 = {l0 = v669} : Mut4
        let v671 : string = "{ "
        let v672 : string = $"{v671}"
        let v675 : string = v670.l0
        let v676 : string = v675 + v672 
        v670.l0 <- v676
        let v677 : string = "port"
        let v678 : string = $"{v677}"
        let v681 : string = v670.l0
        let v682 : string = v681 + v678 
        v670.l0 <- v682
        let v683 : string = " = "
        let v684 : string = $"{v683}"
        let v687 : string = v670.l0
        let v688 : string = v687 + v684 
        v670.l0 <- v688
        let v689 : string = $"{v2}"
        let v692 : string = v670.l0
        let v693 : string = v692 + v689 
        v670.l0 <- v693
        let v694 : string = "; "
        let v695 : string = $"{v694}"
        let v698 : string = v670.l0
        let v699 : string = v698 + v695 
        v670.l0 <- v699
        let v700 : string = "ex"
        let v701 : string = $"{v700}"
        let v704 : string = v670.l0
        let v705 : string = v704 + v701 
        v670.l0 <- v705
        let v706 : string = $"{v683}"
        let v709 : string = v670.l0
        let v710 : string = v709 + v706 
        v670.l0 <- v710
        let v711 : string = $"{v85}"
        let v714 : string = v670.l0
        let v715 : string = v714 + v711 
        v670.l0 <- v715
        let v716 : string = " }"
        let v717 : string = $"{v716}"
        let v720 : string = v670.l0
        let v721 : string = v720 + v717 
        v670.l0 <- v721
        let v722 : string = v670.l0
        let v723 : (unit -> string) = closure3()
        let v724 : string = $"{v532} {v662} #{v668} %s{v723 ()} / {v722}"
        let v727 : char list = []
        let v728 : (char list -> (char [])) = List.toArray
        let v729 : (char []) = v728 v727
        let v732 : string = v724.TrimStart v729 
        let v750 : char list = []
        let v751 : char list = '/' :: v750 
        let v754 : char list = ' ' :: v751 
        let v757 : (char list -> (char [])) = List.toArray
        let v758 : (char []) = v757 v754
        let v761 : string = v732.TrimEnd v758 
        let v779 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v780 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v761 v780 
        let _v779 = () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v781 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v761 v781 
        let _v779 = () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v782 : string = $"near_sdk::log!(\"{{}}\", $0)"
        Fable.Core.RustInterop.emitRustExpr v761 v782 
        let _v779 = () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        System.Console.WriteLine v761 
        let _v779 = () 
        #endif
#if FABLE_COMPILER_PYTHON
        System.Console.WriteLine v761 
        let _v779 = () 
        #endif
#else
        System.Console.WriteLine v761 
        let _v779 = () 
        #endif
        _v779 
        let v783 : (string -> unit) = v103.l0
        v783 v761
    return false 
    (*
    let v784 : bool = *)
    }
    |> fun x -> _v36 <- Some x
    let v785 : Async<bool> = match _v36 with Some x -> x | None -> failwith "async.new_async_unit / _v36=None"
    let _v20 = v785 
    #endif
    let v786 : Async<bool> = _v20 
    let v791 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v792 : Async<US4> = null |> unbox<Async<US4>>
    let _v791 = v792 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v795 : Async<US4> = null |> unbox<Async<US4>>
    let _v791 = v795 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v798 : Async<US4> = null |> unbox<Async<US4>>
    let _v791 = v798 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v801 : Async<US4> = null |> unbox<Async<US4>>
    let _v791 = v801 
    #endif
#if FABLE_COMPILER_PYTHON
    let v804 : Async<US4> = null |> unbox<Async<US4>>
    let _v791 = v804 
    #endif
#else
    let v807 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v808 : Async<US4> = null |> unbox<Async<US4>>
    let _v807 = v808 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v811 : Async<US4> = null |> unbox<Async<US4>>
    let _v807 = v811 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v814 : Async<US4> = null |> unbox<Async<US4>>
    let _v807 = v814 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v817 : Async<US4> = null |> unbox<Async<US4>>
    let _v807 = v817 
    #endif
#if FABLE_COMPILER_PYTHON
    let v820 : Async<US4> = null |> unbox<Async<US4>>
    let _v807 = v820 
    #endif
#else
    let v823 : Async<US4> option = None
    let mutable _v823 = v823 
    async {
    let v824 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v825 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
    let _v824 = v825 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v828 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
    let _v824 = v828 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v831 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
    let _v824 = v831 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v834 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
    let _v824 = v834 
    #endif
#if FABLE_COMPILER_PYTHON
    let v837 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
    let _v824 = v837 
    #endif
#else
    let v840 : Async<Async<bool>> = Async.StartChild (v786, v0)
    let _v824 = v840 
    #endif
    let v841 : Async<Async<bool>> = _v824 
    let! v841 = v841 
    let v846 : Async<bool> = v841 
    let v847 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v848 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
    let _v847 = v848 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v851 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
    let _v847 = v851 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v854 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
    let _v847 = v854 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v857 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
    let _v847 = v857 
    #endif
#if FABLE_COMPILER_PYTHON
    let v860 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
    let _v847 = v860 
    #endif
#else
    let v863 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
    let v864 : Async<Choice<bool, exn>> = v863 v846
    let _v847 = v864 
    #endif
    let v865 : Async<Choice<bool, exn>> = _v847 
    let v870 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v871 : Async<US5> = null |> unbox<Async<US5>>
    let _v870 = v871 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v874 : Async<US5> = null |> unbox<Async<US5>>
    let _v870 = v874 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v877 : Async<US5> = null |> unbox<Async<US5>>
    let _v870 = v877 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v880 : Async<US5> = null |> unbox<Async<US5>>
    let _v870 = v880 
    #endif
#if FABLE_COMPILER_PYTHON
    let v883 : Async<US5> = null |> unbox<Async<US5>>
    let _v870 = v883 
    #endif
#else
    let v886 : Async<US5> option = None
    let mutable _v886 = v886 
    async {
    let! v865 = v865 
    let v887 : Choice<bool, exn> = v865 
    let v888 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v889 : US5 = null |> unbox<US5>
    let _v888 = v889 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v892 : US5 = null |> unbox<US5>
    let _v888 = v892 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v895 : US5 = null |> unbox<US5>
    let _v888 = v895 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v898 : US5 = null |> unbox<US5>
    let _v888 = v898 
    #endif
#if FABLE_COMPILER_PYTHON
    let v901 : US5 = null |> unbox<US5>
    let _v888 = v901 
    #endif
#else
    let v904 : (bool -> US5) = closure7()
    let v905 : (exn -> US5) = closure8()
    let v906 : US5 = match v887 with Choice1Of2 x -> v904 x | Choice2Of2 x -> v905 x
    let _v888 = v906 
    #endif
    let v907 : US5 = _v888 
    return v907 
    }
    |> fun x -> _v886 <- Some x
    let v912 : Async<US5> = match _v886 with Some x -> x | None -> failwith "async.new_async_unit / _v886=None"
    let _v870 = v912 
    #endif
    let v913 : Async<US5> = _v870 
    let v918 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v919 : Async<US6> = null |> unbox<Async<US6>>
    let _v918 = v919 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v922 : Async<US6> = null |> unbox<Async<US6>>
    let _v918 = v922 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v925 : Async<US6> = null |> unbox<Async<US6>>
    let _v918 = v925 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v928 : Async<US6> = null |> unbox<Async<US6>>
    let _v918 = v928 
    #endif
#if FABLE_COMPILER_PYTHON
    let v931 : Async<US6> = null |> unbox<Async<US6>>
    let _v918 = v931 
    #endif
#else
    let v934 : Async<US6> option = None
    let mutable _v934 = v934 
    async {
    let! v913 = v913 
    let v935 : US5 = v913 
    let v941 : US6 =
        match v935 with
        | US5_0(v936) -> (* C1of2 *)
            US6_0(v936)
        | US5_1(v938) -> (* C2of2 *)
            US6_1(v938)
    return v941 
    }
    |> fun x -> _v934 <- Some x
    let v942 : Async<US6> = match _v934 with Some x -> x | None -> failwith "async.new_async_unit / _v934=None"
    let _v918 = v942 
    #endif
    let v943 : Async<US6> = _v918 
    let v948 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v949 : Async<US4> = null |> unbox<Async<US4>>
    let _v948 = v949 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v952 : Async<US4> = null |> unbox<Async<US4>>
    let _v948 = v952 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v955 : Async<US4> = null |> unbox<Async<US4>>
    let _v948 = v955 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v958 : Async<US4> = null |> unbox<Async<US4>>
    let _v948 = v958 
    #endif
#if FABLE_COMPILER_PYTHON
    let v961 : Async<US4> = null |> unbox<Async<US4>>
    let _v948 = v961 
    #endif
#else
    let v964 : Async<US4> option = None
    let mutable _v964 = v964 
    async {
    let! v943 = v943 
    let v965 : US6 = v943 
    let v2368 : US4 =
        match v965 with
        | US6_1(v968) -> (* Error *)
            let v969 : string = $"%A{v968}"
            let v972 : string = "System.TimeoutException"
            let v973 : bool = v969.Contains v972 
            if v973 then
                let v976 : bool = State.trace_state.IsNone
                if v976 then
                    let v977 : US0 = US0_0
                    let struct (v978 : Mut0, v979 : Mut1, v980 : Mut2, v981 : Mut3, v982 : int64 option) = method0(v977)
                    let v983 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v978, v979, v980, v981, v982) 
                    State.trace_state <- v983 
                    ()
                let struct (v988 : Mut0, v989 : Mut1, v990 : Mut2, v991 : Mut3, v992 : int64 option) = State.trace_state.Value
                let v1003 : bool = State.trace_state.IsNone
                if v1003 then
                    let v1004 : US0 = US0_0
                    let struct (v1005 : Mut0, v1006 : Mut1, v1007 : Mut2, v1008 : Mut3, v1009 : int64 option) = method0(v1004)
                    let v1010 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v1005, v1006, v1007, v1008, v1009) 
                    State.trace_state <- v1010 
                    ()
                let struct (v1015 : Mut0, v1016 : Mut1, v1017 : Mut2, v1018 : Mut3, v1019 : int64 option) = State.trace_state.Value
                let v1030 : US0 = v1018.l0
                let v1031 : bool = v1017.l0
                let v1032 : bool = v1031 = false
                let v1035 : bool =
                    if v1032 then
                        false
                    else
                        let v1033 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v1030
                        let v1034 : bool = 0 >= v1033
                        v1034
                if v1035 then
                    let v1036 : int64 = v988.l0
                    let v1037 : int64 = v1036 + 1L
                    v988.l0 <- v1037
                    let v1038 : bool = State.trace_state.IsNone
                    if v1038 then
                        let v1039 : US0 = US0_0
                        let struct (v1040 : Mut0, v1041 : Mut1, v1042 : Mut2, v1043 : Mut3, v1044 : int64 option) = method0(v1039)
                        let v1045 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v1040, v1041, v1042, v1043, v1044) 
                        State.trace_state <- v1045 
                        ()
                    let struct (v1050 : Mut0, v1051 : Mut1, v1052 : Mut2, v1053 : Mut3, v1054 : int64 option) = State.trace_state.Value
                    let v1065 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1066 : US3 option = None
                    let _v1066 = ref v1066 
                    match v1054 with
                    | Some x -> (
                    (fun () ->
                    (fun () ->
                    let v1067 : int64 = x
                    let v1068 : US3 = US3_0(v1067)
                    v1068 
                    )
                    |> fun x -> x () |> Some
                    ) () ) | None -> None
                    |> fun x -> _v1066.Value <- x
                    let v1069 : US3 option = _v1066.Value 
                    let v1080 : US3 = US3_1
                    let v1081 : US3 = v1069 |> Option.defaultValue v1080 
                    let v1121 : System.DateTime =
                        match v1081 with
                        | US3_1 -> (* None *)
                            let v1117 : System.DateTime = System.DateTime.Now
                            v1117
                        | US3_0(v1085) -> (* Some *)
                            let v1086 : System.DateTime = System.DateTime.Now
                            let v1089 : (System.DateTime -> int64) = _.Ticks
                            let v1090 : int64 = v1089 v1086
                            let v1093 : int64 = v1090 - v1085
                            let v1094 : (int64 -> System.TimeSpan) = System.TimeSpan 
                            let v1095 : System.TimeSpan = v1094 v1093
                            let v1098 : (System.TimeSpan -> int32) = _.Hours
                            let v1099 : int32 = v1098 v1095
                            let v1102 : (System.TimeSpan -> int32) = _.Minutes
                            let v1103 : int32 = v1102 v1095
                            let v1106 : (System.TimeSpan -> int32) = _.Seconds
                            let v1107 : int32 = v1106 v1095
                            let v1110 : (System.TimeSpan -> int32) = _.Milliseconds
                            let v1111 : int32 = v1110 v1095
                            let v1114 : System.DateTime = System.DateTime (1, 1, 1, v1099, v1103, v1107, v1111)
                            v1114
                    let v1122 : string = method5()
                    let v1125 : (string -> string) = v1121.ToString
                    let v1126 : string = v1125 v1122
                    let _v1065 = v1126 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v1129 : US3 option = None
                    let _v1129 = ref v1129 
                    match v1054 with
                    | Some x -> (
                    (fun () ->
                    (fun () ->
                    let v1130 : int64 = x
                    let v1131 : US3 = US3_0(v1130)
                    v1131 
                    )
                    |> fun x -> x () |> Some
                    ) () ) | None -> None
                    |> fun x -> _v1129.Value <- x
                    let v1132 : US3 option = _v1129.Value 
                    let v1143 : US3 = US3_1
                    let v1144 : US3 = v1132 |> Option.defaultValue v1143 
                    let v1184 : System.DateTime =
                        match v1144 with
                        | US3_1 -> (* None *)
                            let v1180 : System.DateTime = System.DateTime.Now
                            v1180
                        | US3_0(v1148) -> (* Some *)
                            let v1149 : System.DateTime = System.DateTime.Now
                            let v1152 : (System.DateTime -> int64) = _.Ticks
                            let v1153 : int64 = v1152 v1149
                            let v1156 : int64 = v1153 - v1148
                            let v1157 : (int64 -> System.TimeSpan) = System.TimeSpan 
                            let v1158 : System.TimeSpan = v1157 v1156
                            let v1161 : (System.TimeSpan -> int32) = _.Hours
                            let v1162 : int32 = v1161 v1158
                            let v1165 : (System.TimeSpan -> int32) = _.Minutes
                            let v1166 : int32 = v1165 v1158
                            let v1169 : (System.TimeSpan -> int32) = _.Seconds
                            let v1170 : int32 = v1169 v1158
                            let v1173 : (System.TimeSpan -> int32) = _.Milliseconds
                            let v1174 : int32 = v1173 v1158
                            let v1177 : System.DateTime = System.DateTime (1, 1, 1, v1162, v1166, v1170, v1174)
                            v1177
                    let v1185 : string = method5()
                    let v1188 : (string -> string) = v1184.ToString
                    let v1189 : string = v1188 v1185
                    let _v1065 = v1189 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1192 : string = $"near_sdk::env::block_timestamp()"
                    let v1193 : uint64 = Fable.Core.RustInterop.emitRustExpr () v1192 
                    let v1194 : US3 option = None
                    let _v1194 = ref v1194 
                    match v1054 with
                    | Some x -> (
                    (fun () ->
                    (fun () ->
                    let v1195 : int64 = x
                    let v1196 : US3 = US3_0(v1195)
                    v1196 
                    )
                    |> fun x -> x () |> Some
                    ) () ) | None -> None
                    |> fun x -> _v1194.Value <- x
                    let v1197 : US3 option = _v1194.Value 
                    let v1208 : US3 = US3_1
                    let v1209 : US3 = v1197 |> Option.defaultValue v1208 
                    let v1218 : uint64 =
                        match v1209 with
                        | US3_1 -> (* None *)
                            v1193
                        | US3_0(v1213) -> (* Some *)
                            let v1214 : (int64 -> uint64) = uint64
                            let v1215 : uint64 = v1214 v1213
                            let v1216 : uint64 = v1193 - v1215
                            v1216
                    let v1219 : uint64 = v1218 / 1000000000UL
                    let v1220 : uint64 = v1219 % 60UL
                    let v1221 : uint64 = v1219 / 60UL
                    let v1222 : uint64 = v1221 % 60UL
                    let v1223 : uint64 = v1219 / 3600UL
                    let v1224 : uint64 = v1223 % 24UL
                    let v1225 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
                    let v1226 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v1224, v1222, v1220) v1225 
                    let v1227 : string = "fable_library_rust::String_::fromString($0)"
                    let v1228 : string = Fable.Core.RustInterop.emitRustExpr v1226 v1227 
                    let _v1065 = v1228 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v1229 : US3 option = None
                    let _v1229 = ref v1229 
                    match v1054 with
                    | Some x -> (
                    (fun () ->
                    (fun () ->
                    let v1230 : int64 = x
                    let v1231 : US3 = US3_0(v1230)
                    v1231 
                    )
                    |> fun x -> x () |> Some
                    ) () ) | None -> None
                    |> fun x -> _v1229.Value <- x
                    let v1232 : US3 option = _v1229.Value 
                    let v1243 : US3 = US3_1
                    let v1244 : US3 = v1232 |> Option.defaultValue v1243 
                    let v1284 : System.DateTime =
                        match v1244 with
                        | US3_1 -> (* None *)
                            let v1280 : System.DateTime = System.DateTime.Now
                            v1280
                        | US3_0(v1248) -> (* Some *)
                            let v1249 : System.DateTime = System.DateTime.Now
                            let v1252 : (System.DateTime -> int64) = _.Ticks
                            let v1253 : int64 = v1252 v1249
                            let v1256 : int64 = v1253 - v1248
                            let v1257 : (int64 -> System.TimeSpan) = System.TimeSpan 
                            let v1258 : System.TimeSpan = v1257 v1256
                            let v1261 : (System.TimeSpan -> int32) = _.Hours
                            let v1262 : int32 = v1261 v1258
                            let v1265 : (System.TimeSpan -> int32) = _.Minutes
                            let v1266 : int32 = v1265 v1258
                            let v1269 : (System.TimeSpan -> int32) = _.Seconds
                            let v1270 : int32 = v1269 v1258
                            let v1273 : (System.TimeSpan -> int32) = _.Milliseconds
                            let v1274 : int32 = v1273 v1258
                            let v1277 : System.DateTime = System.DateTime (1, 1, 1, v1262, v1266, v1270, v1274)
                            v1277
                    let v1285 : string = method6()
                    let v1288 : (string -> string) = v1284.ToString
                    let v1289 : string = v1288 v1285
                    let _v1065 = v1289 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v1292 : US3 option = None
                    let _v1292 = ref v1292 
                    match v1054 with
                    | Some x -> (
                    (fun () ->
                    (fun () ->
                    let v1293 : int64 = x
                    let v1294 : US3 = US3_0(v1293)
                    v1294 
                    )
                    |> fun x -> x () |> Some
                    ) () ) | None -> None
                    |> fun x -> _v1292.Value <- x
                    let v1295 : US3 option = _v1292.Value 
                    let v1306 : US3 = US3_1
                    let v1307 : US3 = v1295 |> Option.defaultValue v1306 
                    let v1347 : System.DateTime =
                        match v1307 with
                        | US3_1 -> (* None *)
                            let v1343 : System.DateTime = System.DateTime.Now
                            v1343
                        | US3_0(v1311) -> (* Some *)
                            let v1312 : System.DateTime = System.DateTime.Now
                            let v1315 : (System.DateTime -> int64) = _.Ticks
                            let v1316 : int64 = v1315 v1312
                            let v1319 : int64 = v1316 - v1311
                            let v1320 : (int64 -> System.TimeSpan) = System.TimeSpan 
                            let v1321 : System.TimeSpan = v1320 v1319
                            let v1324 : (System.TimeSpan -> int32) = _.Hours
                            let v1325 : int32 = v1324 v1321
                            let v1328 : (System.TimeSpan -> int32) = _.Minutes
                            let v1329 : int32 = v1328 v1321
                            let v1332 : (System.TimeSpan -> int32) = _.Seconds
                            let v1333 : int32 = v1332 v1321
                            let v1336 : (System.TimeSpan -> int32) = _.Milliseconds
                            let v1337 : int32 = v1336 v1321
                            let v1340 : System.DateTime = System.DateTime (1, 1, 1, v1325, v1329, v1333, v1337)
                            v1340
                    let v1348 : string = method6()
                    let v1351 : (string -> string) = v1347.ToString
                    let v1352 : string = v1351 v1348
                    let _v1065 = v1352 
                    #endif
#else
                    let v1355 : US3 option = None
                    let _v1355 = ref v1355 
                    match v1054 with
                    | Some x -> (
                    (fun () ->
                    (fun () ->
                    let v1356 : int64 = x
                    let v1357 : US3 = US3_0(v1356)
                    v1357 
                    )
                    |> fun x -> x () |> Some
                    ) () ) | None -> None
                    |> fun x -> _v1355.Value <- x
                    let v1358 : US3 option = _v1355.Value 
                    let v1369 : US3 = US3_1
                    let v1370 : US3 = v1358 |> Option.defaultValue v1369 
                    let v1410 : System.DateTime =
                        match v1370 with
                        | US3_1 -> (* None *)
                            let v1406 : System.DateTime = System.DateTime.Now
                            v1406
                        | US3_0(v1374) -> (* Some *)
                            let v1375 : System.DateTime = System.DateTime.Now
                            let v1378 : (System.DateTime -> int64) = _.Ticks
                            let v1379 : int64 = v1378 v1375
                            let v1382 : int64 = v1379 - v1374
                            let v1383 : (int64 -> System.TimeSpan) = System.TimeSpan 
                            let v1384 : System.TimeSpan = v1383 v1382
                            let v1387 : (System.TimeSpan -> int32) = _.Hours
                            let v1388 : int32 = v1387 v1384
                            let v1391 : (System.TimeSpan -> int32) = _.Minutes
                            let v1392 : int32 = v1391 v1384
                            let v1395 : (System.TimeSpan -> int32) = _.Seconds
                            let v1396 : int32 = v1395 v1384
                            let v1399 : (System.TimeSpan -> int32) = _.Milliseconds
                            let v1400 : int32 = v1399 v1384
                            let v1403 : System.DateTime = System.DateTime (1, 1, 1, v1388, v1392, v1396, v1400)
                            v1403
                    let v1411 : string = method6()
                    let v1414 : (string -> string) = v1410.ToString
                    let v1415 : string = v1414 v1411
                    let _v1065 = v1415 
                    #endif
                    let v1418 : string = _v1065 
                    let v1483 : string = "Verbose"
                    let v1484 : (unit -> string) = v1483.ToLower
                    let v1485 : string = v1484 ()
                    let v1488 : string = v1485.PadLeft (7, ' ')
                    let v1502 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1503 : string = "inline_colorization::color_bright_black"
                    let v1504 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1503 
                    let v1505 : string = "&*$0"
                    let v1506 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1488 v1505 
                    let v1507 : string = "inline_colorization::color_reset"
                    let v1508 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1507 
                    let v1509 : string = "\"{v1504}{v1506}{v1508}\""
                    let v1510 : string = @$"format!(" + v1509 + ")"
                    let v1511 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v1510 
                    let v1512 : string = "fable_library_rust::String_::fromString($0)"
                    let v1513 : string = Fable.Core.RustInterop.emitRustExpr v1511 v1512 
                    let _v1502 = v1513 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v1514 : string = "inline_colorization::color_bright_black"
                    let v1515 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1514 
                    let v1516 : string = "&*$0"
                    let v1517 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1488 v1516 
                    let v1518 : string = "inline_colorization::color_reset"
                    let v1519 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1518 
                    let v1520 : string = "\"{v1515}{v1517}{v1519}\""
                    let v1521 : string = @$"format!(" + v1520 + ")"
                    let v1522 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v1521 
                    let v1523 : string = "fable_library_rust::String_::fromString($0)"
                    let v1524 : string = Fable.Core.RustInterop.emitRustExpr v1522 v1523 
                    let _v1502 = v1524 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1525 : string = "inline_colorization::color_bright_black"
                    let v1526 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1525 
                    let v1527 : string = "&*$0"
                    let v1528 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1488 v1527 
                    let v1529 : string = "inline_colorization::color_reset"
                    let v1530 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1529 
                    let v1531 : string = "\"{v1526}{v1528}{v1530}\""
                    let v1532 : string = @$"format!(" + v1531 + ")"
                    let v1533 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v1532 
                    let v1534 : string = "fable_library_rust::String_::fromString($0)"
                    let v1535 : string = Fable.Core.RustInterop.emitRustExpr v1533 v1534 
                    let _v1502 = v1535 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v1536 : string = "\u001b[90m"
                    let v1537 : string = method7()
                    let v1538 : string = v1536 + v1488 
                    let v1539 : string = v1538 + v1537 
                    let _v1502 = v1539 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v1540 : string = "\u001b[90m"
                    let v1541 : string = method7()
                    let v1542 : string = v1540 + v1488 
                    let v1543 : string = v1542 + v1541 
                    let _v1502 = v1543 
                    #endif
#else
                    let v1544 : string = "\u001b[90m"
                    let v1545 : string = method7()
                    let v1546 : string = v1544 + v1488 
                    let v1547 : string = v1546 + v1545 
                    let _v1502 = v1547 
                    #endif
                    let v1548 : string = _v1502 
                    let v1554 : int64 = v1050.l0
                    let v1555 : string = method8()
                    let v1556 : Mut4 = {l0 = v1555} : Mut4
                    let v1557 : string = "{ "
                    let v1558 : string = $"{v1557}"
                    let v1561 : string = v1556.l0
                    let v1562 : string = v1561 + v1558 
                    v1556.l0 <- v1562
                    let v1563 : string = "timeout"
                    let v1564 : string = $"{v1563}"
                    let v1567 : string = v1556.l0
                    let v1568 : string = v1567 + v1564 
                    v1556.l0 <- v1568
                    let v1569 : string = " = "
                    let v1570 : string = $"{v1569}"
                    let v1573 : string = v1556.l0
                    let v1574 : string = v1573 + v1570 
                    v1556.l0 <- v1574
                    let v1575 : string = $"{v0}"
                    let v1578 : string = v1556.l0
                    let v1579 : string = v1578 + v1575 
                    v1556.l0 <- v1579
                    let v1580 : string = " }"
                    let v1581 : string = $"{v1580}"
                    let v1584 : string = v1556.l0
                    let v1585 : string = v1584 + v1581 
                    v1556.l0 <- v1585
                    let v1586 : string = v1556.l0
                    let v1587 : (unit -> string) = closure9()
                    let v1588 : string = $"{v1418} {v1548} #{v1554} %s{v1587 ()} / {v1586}"
                    let v1591 : char list = []
                    let v1592 : (char list -> (char [])) = List.toArray
                    let v1593 : (char []) = v1592 v1591
                    let v1596 : string = v1588.TrimStart v1593 
                    let v1614 : char list = []
                    let v1615 : char list = '/' :: v1614 
                    let v1618 : char list = ' ' :: v1615 
                    let v1621 : (char list -> (char [])) = List.toArray
                    let v1622 : (char []) = v1621 v1618
                    let v1625 : string = v1596.TrimEnd v1622 
                    let v1643 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1644 : string = @"println!(""{}"", $0)"
                    Fable.Core.RustInterop.emitRustExpr v1625 v1644 
                    let _v1643 = () 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v1645 : string = @"println!(""{}"", $0)"
                    Fable.Core.RustInterop.emitRustExpr v1625 v1645 
                    let _v1643 = () 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1646 : string = $"near_sdk::log!(\"{{}}\", $0)"
                    Fable.Core.RustInterop.emitRustExpr v1625 v1646 
                    let _v1643 = () 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    System.Console.WriteLine v1625 
                    let _v1643 = () 
                    #endif
#if FABLE_COMPILER_PYTHON
                    System.Console.WriteLine v1625 
                    let _v1643 = () 
                    #endif
#else
                    System.Console.WriteLine v1625 
                    let _v1643 = () 
                    #endif
                    _v1643 
                    let v1647 : (string -> unit) = v989.l0
                    v1647 v1625
                US4_1
            else
                let v1649 : bool = State.trace_state.IsNone
                if v1649 then
                    let v1650 : US0 = US0_0
                    let struct (v1651 : Mut0, v1652 : Mut1, v1653 : Mut2, v1654 : Mut3, v1655 : int64 option) = method0(v1650)
                    let v1656 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v1651, v1652, v1653, v1654, v1655) 
                    State.trace_state <- v1656 
                    ()
                let struct (v1661 : Mut0, v1662 : Mut1, v1663 : Mut2, v1664 : Mut3, v1665 : int64 option) = State.trace_state.Value
                let v1676 : bool = State.trace_state.IsNone
                if v1676 then
                    let v1677 : US0 = US0_0
                    let struct (v1678 : Mut0, v1679 : Mut1, v1680 : Mut2, v1681 : Mut3, v1682 : int64 option) = method0(v1677)
                    let v1683 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v1678, v1679, v1680, v1681, v1682) 
                    State.trace_state <- v1683 
                    ()
                let struct (v1688 : Mut0, v1689 : Mut1, v1690 : Mut2, v1691 : Mut3, v1692 : int64 option) = State.trace_state.Value
                let v1703 : US0 = v1691.l0
                let v1704 : bool = v1690.l0
                let v1705 : bool = v1704 = false
                let v1708 : bool =
                    if v1705 then
                        false
                    else
                        let v1706 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v1703
                        let v1707 : bool = 4 >= v1706
                        v1707
                if v1708 then
                    let v1709 : int64 = v1661.l0
                    let v1710 : int64 = v1709 + 1L
                    v1661.l0 <- v1710
                    let v1711 : bool = State.trace_state.IsNone
                    if v1711 then
                        let v1712 : US0 = US0_0
                        let struct (v1713 : Mut0, v1714 : Mut1, v1715 : Mut2, v1716 : Mut3, v1717 : int64 option) = method0(v1712)
                        let v1718 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v1713, v1714, v1715, v1716, v1717) 
                        State.trace_state <- v1718 
                        ()
                    let struct (v1723 : Mut0, v1724 : Mut1, v1725 : Mut2, v1726 : Mut3, v1727 : int64 option) = State.trace_state.Value
                    let v1738 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1739 : US3 option = None
                    let _v1739 = ref v1739 
                    match v1727 with
                    | Some x -> (
                    (fun () ->
                    (fun () ->
                    let v1740 : int64 = x
                    let v1741 : US3 = US3_0(v1740)
                    v1741 
                    )
                    |> fun x -> x () |> Some
                    ) () ) | None -> None
                    |> fun x -> _v1739.Value <- x
                    let v1742 : US3 option = _v1739.Value 
                    let v1753 : US3 = US3_1
                    let v1754 : US3 = v1742 |> Option.defaultValue v1753 
                    let v1794 : System.DateTime =
                        match v1754 with
                        | US3_1 -> (* None *)
                            let v1790 : System.DateTime = System.DateTime.Now
                            v1790
                        | US3_0(v1758) -> (* Some *)
                            let v1759 : System.DateTime = System.DateTime.Now
                            let v1762 : (System.DateTime -> int64) = _.Ticks
                            let v1763 : int64 = v1762 v1759
                            let v1766 : int64 = v1763 - v1758
                            let v1767 : (int64 -> System.TimeSpan) = System.TimeSpan 
                            let v1768 : System.TimeSpan = v1767 v1766
                            let v1771 : (System.TimeSpan -> int32) = _.Hours
                            let v1772 : int32 = v1771 v1768
                            let v1775 : (System.TimeSpan -> int32) = _.Minutes
                            let v1776 : int32 = v1775 v1768
                            let v1779 : (System.TimeSpan -> int32) = _.Seconds
                            let v1780 : int32 = v1779 v1768
                            let v1783 : (System.TimeSpan -> int32) = _.Milliseconds
                            let v1784 : int32 = v1783 v1768
                            let v1787 : System.DateTime = System.DateTime (1, 1, 1, v1772, v1776, v1780, v1784)
                            v1787
                    let v1795 : string = method5()
                    let v1798 : (string -> string) = v1794.ToString
                    let v1799 : string = v1798 v1795
                    let _v1738 = v1799 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v1802 : US3 option = None
                    let _v1802 = ref v1802 
                    match v1727 with
                    | Some x -> (
                    (fun () ->
                    (fun () ->
                    let v1803 : int64 = x
                    let v1804 : US3 = US3_0(v1803)
                    v1804 
                    )
                    |> fun x -> x () |> Some
                    ) () ) | None -> None
                    |> fun x -> _v1802.Value <- x
                    let v1805 : US3 option = _v1802.Value 
                    let v1816 : US3 = US3_1
                    let v1817 : US3 = v1805 |> Option.defaultValue v1816 
                    let v1857 : System.DateTime =
                        match v1817 with
                        | US3_1 -> (* None *)
                            let v1853 : System.DateTime = System.DateTime.Now
                            v1853
                        | US3_0(v1821) -> (* Some *)
                            let v1822 : System.DateTime = System.DateTime.Now
                            let v1825 : (System.DateTime -> int64) = _.Ticks
                            let v1826 : int64 = v1825 v1822
                            let v1829 : int64 = v1826 - v1821
                            let v1830 : (int64 -> System.TimeSpan) = System.TimeSpan 
                            let v1831 : System.TimeSpan = v1830 v1829
                            let v1834 : (System.TimeSpan -> int32) = _.Hours
                            let v1835 : int32 = v1834 v1831
                            let v1838 : (System.TimeSpan -> int32) = _.Minutes
                            let v1839 : int32 = v1838 v1831
                            let v1842 : (System.TimeSpan -> int32) = _.Seconds
                            let v1843 : int32 = v1842 v1831
                            let v1846 : (System.TimeSpan -> int32) = _.Milliseconds
                            let v1847 : int32 = v1846 v1831
                            let v1850 : System.DateTime = System.DateTime (1, 1, 1, v1835, v1839, v1843, v1847)
                            v1850
                    let v1858 : string = method5()
                    let v1861 : (string -> string) = v1857.ToString
                    let v1862 : string = v1861 v1858
                    let _v1738 = v1862 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1865 : string = $"near_sdk::env::block_timestamp()"
                    let v1866 : uint64 = Fable.Core.RustInterop.emitRustExpr () v1865 
                    let v1867 : US3 option = None
                    let _v1867 = ref v1867 
                    match v1727 with
                    | Some x -> (
                    (fun () ->
                    (fun () ->
                    let v1868 : int64 = x
                    let v1869 : US3 = US3_0(v1868)
                    v1869 
                    )
                    |> fun x -> x () |> Some
                    ) () ) | None -> None
                    |> fun x -> _v1867.Value <- x
                    let v1870 : US3 option = _v1867.Value 
                    let v1881 : US3 = US3_1
                    let v1882 : US3 = v1870 |> Option.defaultValue v1881 
                    let v1891 : uint64 =
                        match v1882 with
                        | US3_1 -> (* None *)
                            v1866
                        | US3_0(v1886) -> (* Some *)
                            let v1887 : (int64 -> uint64) = uint64
                            let v1888 : uint64 = v1887 v1886
                            let v1889 : uint64 = v1866 - v1888
                            v1889
                    let v1892 : uint64 = v1891 / 1000000000UL
                    let v1893 : uint64 = v1892 % 60UL
                    let v1894 : uint64 = v1892 / 60UL
                    let v1895 : uint64 = v1894 % 60UL
                    let v1896 : uint64 = v1892 / 3600UL
                    let v1897 : uint64 = v1896 % 24UL
                    let v1898 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
                    let v1899 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v1897, v1895, v1893) v1898 
                    let v1900 : string = "fable_library_rust::String_::fromString($0)"
                    let v1901 : string = Fable.Core.RustInterop.emitRustExpr v1899 v1900 
                    let _v1738 = v1901 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v1902 : US3 option = None
                    let _v1902 = ref v1902 
                    match v1727 with
                    | Some x -> (
                    (fun () ->
                    (fun () ->
                    let v1903 : int64 = x
                    let v1904 : US3 = US3_0(v1903)
                    v1904 
                    )
                    |> fun x -> x () |> Some
                    ) () ) | None -> None
                    |> fun x -> _v1902.Value <- x
                    let v1905 : US3 option = _v1902.Value 
                    let v1916 : US3 = US3_1
                    let v1917 : US3 = v1905 |> Option.defaultValue v1916 
                    let v1957 : System.DateTime =
                        match v1917 with
                        | US3_1 -> (* None *)
                            let v1953 : System.DateTime = System.DateTime.Now
                            v1953
                        | US3_0(v1921) -> (* Some *)
                            let v1922 : System.DateTime = System.DateTime.Now
                            let v1925 : (System.DateTime -> int64) = _.Ticks
                            let v1926 : int64 = v1925 v1922
                            let v1929 : int64 = v1926 - v1921
                            let v1930 : (int64 -> System.TimeSpan) = System.TimeSpan 
                            let v1931 : System.TimeSpan = v1930 v1929
                            let v1934 : (System.TimeSpan -> int32) = _.Hours
                            let v1935 : int32 = v1934 v1931
                            let v1938 : (System.TimeSpan -> int32) = _.Minutes
                            let v1939 : int32 = v1938 v1931
                            let v1942 : (System.TimeSpan -> int32) = _.Seconds
                            let v1943 : int32 = v1942 v1931
                            let v1946 : (System.TimeSpan -> int32) = _.Milliseconds
                            let v1947 : int32 = v1946 v1931
                            let v1950 : System.DateTime = System.DateTime (1, 1, 1, v1935, v1939, v1943, v1947)
                            v1950
                    let v1958 : string = method6()
                    let v1961 : (string -> string) = v1957.ToString
                    let v1962 : string = v1961 v1958
                    let _v1738 = v1962 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v1965 : US3 option = None
                    let _v1965 = ref v1965 
                    match v1727 with
                    | Some x -> (
                    (fun () ->
                    (fun () ->
                    let v1966 : int64 = x
                    let v1967 : US3 = US3_0(v1966)
                    v1967 
                    )
                    |> fun x -> x () |> Some
                    ) () ) | None -> None
                    |> fun x -> _v1965.Value <- x
                    let v1968 : US3 option = _v1965.Value 
                    let v1979 : US3 = US3_1
                    let v1980 : US3 = v1968 |> Option.defaultValue v1979 
                    let v2020 : System.DateTime =
                        match v1980 with
                        | US3_1 -> (* None *)
                            let v2016 : System.DateTime = System.DateTime.Now
                            v2016
                        | US3_0(v1984) -> (* Some *)
                            let v1985 : System.DateTime = System.DateTime.Now
                            let v1988 : (System.DateTime -> int64) = _.Ticks
                            let v1989 : int64 = v1988 v1985
                            let v1992 : int64 = v1989 - v1984
                            let v1993 : (int64 -> System.TimeSpan) = System.TimeSpan 
                            let v1994 : System.TimeSpan = v1993 v1992
                            let v1997 : (System.TimeSpan -> int32) = _.Hours
                            let v1998 : int32 = v1997 v1994
                            let v2001 : (System.TimeSpan -> int32) = _.Minutes
                            let v2002 : int32 = v2001 v1994
                            let v2005 : (System.TimeSpan -> int32) = _.Seconds
                            let v2006 : int32 = v2005 v1994
                            let v2009 : (System.TimeSpan -> int32) = _.Milliseconds
                            let v2010 : int32 = v2009 v1994
                            let v2013 : System.DateTime = System.DateTime (1, 1, 1, v1998, v2002, v2006, v2010)
                            v2013
                    let v2021 : string = method6()
                    let v2024 : (string -> string) = v2020.ToString
                    let v2025 : string = v2024 v2021
                    let _v1738 = v2025 
                    #endif
#else
                    let v2028 : US3 option = None
                    let _v2028 = ref v2028 
                    match v1727 with
                    | Some x -> (
                    (fun () ->
                    (fun () ->
                    let v2029 : int64 = x
                    let v2030 : US3 = US3_0(v2029)
                    v2030 
                    )
                    |> fun x -> x () |> Some
                    ) () ) | None -> None
                    |> fun x -> _v2028.Value <- x
                    let v2031 : US3 option = _v2028.Value 
                    let v2042 : US3 = US3_1
                    let v2043 : US3 = v2031 |> Option.defaultValue v2042 
                    let v2083 : System.DateTime =
                        match v2043 with
                        | US3_1 -> (* None *)
                            let v2079 : System.DateTime = System.DateTime.Now
                            v2079
                        | US3_0(v2047) -> (* Some *)
                            let v2048 : System.DateTime = System.DateTime.Now
                            let v2051 : (System.DateTime -> int64) = _.Ticks
                            let v2052 : int64 = v2051 v2048
                            let v2055 : int64 = v2052 - v2047
                            let v2056 : (int64 -> System.TimeSpan) = System.TimeSpan 
                            let v2057 : System.TimeSpan = v2056 v2055
                            let v2060 : (System.TimeSpan -> int32) = _.Hours
                            let v2061 : int32 = v2060 v2057
                            let v2064 : (System.TimeSpan -> int32) = _.Minutes
                            let v2065 : int32 = v2064 v2057
                            let v2068 : (System.TimeSpan -> int32) = _.Seconds
                            let v2069 : int32 = v2068 v2057
                            let v2072 : (System.TimeSpan -> int32) = _.Milliseconds
                            let v2073 : int32 = v2072 v2057
                            let v2076 : System.DateTime = System.DateTime (1, 1, 1, v2061, v2065, v2069, v2073)
                            v2076
                    let v2084 : string = method6()
                    let v2087 : (string -> string) = v2083.ToString
                    let v2088 : string = v2087 v2084
                    let _v1738 = v2088 
                    #endif
                    let v2091 : string = _v1738 
                    let v2156 : string = "Critical"
                    let v2157 : (unit -> string) = v2156.ToLower
                    let v2158 : string = v2157 ()
                    let v2161 : string = v2158.PadLeft (7, ' ')
                    let v2175 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v2176 : string = "inline_colorization::color_bright_red"
                    let v2177 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v2176 
                    let v2178 : string = "&*$0"
                    let v2179 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v2161 v2178 
                    let v2180 : string = "inline_colorization::color_reset"
                    let v2181 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v2180 
                    let v2182 : string = "\"{v2177}{v2179}{v2181}\""
                    let v2183 : string = @$"format!(" + v2182 + ")"
                    let v2184 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v2183 
                    let v2185 : string = "fable_library_rust::String_::fromString($0)"
                    let v2186 : string = Fable.Core.RustInterop.emitRustExpr v2184 v2185 
                    let _v2175 = v2186 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v2187 : string = "inline_colorization::color_bright_red"
                    let v2188 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v2187 
                    let v2189 : string = "&*$0"
                    let v2190 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v2161 v2189 
                    let v2191 : string = "inline_colorization::color_reset"
                    let v2192 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v2191 
                    let v2193 : string = "\"{v2188}{v2190}{v2192}\""
                    let v2194 : string = @$"format!(" + v2193 + ")"
                    let v2195 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v2194 
                    let v2196 : string = "fable_library_rust::String_::fromString($0)"
                    let v2197 : string = Fable.Core.RustInterop.emitRustExpr v2195 v2196 
                    let _v2175 = v2197 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v2198 : string = "inline_colorization::color_bright_red"
                    let v2199 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v2198 
                    let v2200 : string = "&*$0"
                    let v2201 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v2161 v2200 
                    let v2202 : string = "inline_colorization::color_reset"
                    let v2203 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v2202 
                    let v2204 : string = "\"{v2199}{v2201}{v2203}\""
                    let v2205 : string = @$"format!(" + v2204 + ")"
                    let v2206 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v2205 
                    let v2207 : string = "fable_library_rust::String_::fromString($0)"
                    let v2208 : string = Fable.Core.RustInterop.emitRustExpr v2206 v2207 
                    let _v2175 = v2208 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v2209 : string = "\u001b[91m"
                    let v2210 : string = method7()
                    let v2211 : string = v2209 + v2161 
                    let v2212 : string = v2211 + v2210 
                    let _v2175 = v2212 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v2213 : string = "\u001b[91m"
                    let v2214 : string = method7()
                    let v2215 : string = v2213 + v2161 
                    let v2216 : string = v2215 + v2214 
                    let _v2175 = v2216 
                    #endif
#else
                    let v2217 : string = "\u001b[91m"
                    let v2218 : string = method7()
                    let v2219 : string = v2217 + v2161 
                    let v2220 : string = v2219 + v2218 
                    let _v2175 = v2220 
                    #endif
                    let v2221 : string = _v2175 
                    let v2227 : int64 = v1723.l0
                    let v2228 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v2229 : string = $"%A{v968}"
                    let _v2228 = v2229 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v2232 : string = $"%A{v968}"
                    let _v2228 = v2232 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v2235 : string = $"%A{v968}"
                    let _v2228 = v2235 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v2238 : string = $"%A{v968}"
                    let _v2228 = v2238 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v2241 : string = $"%A{v968}"
                    let _v2228 = v2241 
                    #endif
#else
                    let v2244 : string = $"{v968.GetType ()}: {v968.Message}"
                    let _v2228 = v2244 
                    #endif
                    let v2245 : string = _v2228 
                    let v2250 : string = method8()
                    let v2251 : Mut4 = {l0 = v2250} : Mut4
                    let v2252 : string = "{ "
                    let v2253 : string = $"{v2252}"
                    let v2256 : string = v2251.l0
                    let v2257 : string = v2256 + v2253 
                    v2251.l0 <- v2257
                    let v2258 : string = "timeout"
                    let v2259 : string = $"{v2258}"
                    let v2262 : string = v2251.l0
                    let v2263 : string = v2262 + v2259 
                    v2251.l0 <- v2263
                    let v2264 : string = " = "
                    let v2265 : string = $"{v2264}"
                    let v2268 : string = v2251.l0
                    let v2269 : string = v2268 + v2265 
                    v2251.l0 <- v2269
                    let v2270 : string = $"{v0}"
                    let v2273 : string = v2251.l0
                    let v2274 : string = v2273 + v2270 
                    v2251.l0 <- v2274
                    let v2275 : string = "; "
                    let v2276 : string = $"{v2275}"
                    let v2279 : string = v2251.l0
                    let v2280 : string = v2279 + v2276 
                    v2251.l0 <- v2280
                    let v2281 : string = "ex"
                    let v2282 : string = $"{v2281}"
                    let v2285 : string = v2251.l0
                    let v2286 : string = v2285 + v2282 
                    v2251.l0 <- v2286
                    let v2287 : string = $"{v2264}"
                    let v2290 : string = v2251.l0
                    let v2291 : string = v2290 + v2287 
                    v2251.l0 <- v2291
                    let v2292 : string = $"{v2245}"
                    let v2295 : string = v2251.l0
                    let v2296 : string = v2295 + v2292 
                    v2251.l0 <- v2296
                    let v2297 : string = " }"
                    let v2298 : string = $"{v2297}"
                    let v2301 : string = v2251.l0
                    let v2302 : string = v2301 + v2298 
                    v2251.l0 <- v2302
                    let v2303 : string = v2251.l0
                    let v2304 : (unit -> string) = closure10()
                    let v2305 : string = $"{v2091} {v2221} #{v2227} %s{v2304 ()} / {v2303}"
                    let v2308 : char list = []
                    let v2309 : (char list -> (char [])) = List.toArray
                    let v2310 : (char []) = v2309 v2308
                    let v2313 : string = v2305.TrimStart v2310 
                    let v2331 : char list = []
                    let v2332 : char list = '/' :: v2331 
                    let v2335 : char list = ' ' :: v2332 
                    let v2338 : (char list -> (char [])) = List.toArray
                    let v2339 : (char []) = v2338 v2335
                    let v2342 : string = v2313.TrimEnd v2339 
                    let v2360 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v2361 : string = @"println!(""{}"", $0)"
                    Fable.Core.RustInterop.emitRustExpr v2342 v2361 
                    let _v2360 = () 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v2362 : string = @"println!(""{}"", $0)"
                    Fable.Core.RustInterop.emitRustExpr v2342 v2362 
                    let _v2360 = () 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v2363 : string = $"near_sdk::log!(\"{{}}\", $0)"
                    Fable.Core.RustInterop.emitRustExpr v2342 v2363 
                    let _v2360 = () 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    System.Console.WriteLine v2342 
                    let _v2360 = () 
                    #endif
#if FABLE_COMPILER_PYTHON
                    System.Console.WriteLine v2342 
                    let _v2360 = () 
                    #endif
#else
                    System.Console.WriteLine v2342 
                    let _v2360 = () 
                    #endif
                    _v2360 
                    let v2364 : (string -> unit) = v1662.l0
                    v2364 v2342
                US4_1
        | US6_0(v966) -> (* Ok *)
            US4_0(v966)
    return v2368 
    }
    |> fun x -> _v964 <- Some x
    let v2369 : Async<US4> = match _v964 with Some x -> x | None -> failwith "async.new_async_unit / _v964=None"
    let _v948 = v2369 
    #endif
    let v2370 : Async<US4> = _v948 
    return! v2370 
    }
    |> fun x -> _v823 <- Some x
    let v2375 : Async<US4> = match _v823 with Some x -> x | None -> failwith "async.new_async_unit / _v823=None"
    let _v807 = v2375 
    #endif
    let v2376 : Async<US4> = _v807 
    let _v791 = v2376 
    #endif
    let v2381 : Async<US4> = _v791 
    let! v2381 = v2381 
    let v2386 : US4 = v2381 
    let v2389 : bool =
        match v2386 with
        | US4_1 -> (* None *)
            false
        | US4_0(v2387) -> (* Some *)
            v2387
    return v2389 
    }
    |> fun x -> _v19 <- Some x
    let v2390 : Async<bool> = match _v19 with Some x -> x | None -> failwith "async.new_async_unit / _v19=None"
    let _v3 = v2390 
    #endif
    let v2391 : Async<bool> = _v3 
    v2391
and closure5 (v0 : int32) (v1 : string) : (int32 -> Async<bool>) =
    closure6(v0, v1)
and closure4 () (v0 : int32) : (string -> (int32 -> Async<bool>)) =
    closure5(v0)
and closure15 () () : string =
    let v0 : string = "networking.wait_for_port_access"
    v0
and method9 (v0 : int32 option, v1 : bool, v2 : string, v3 : int32, v4 : int64) : Async<int64> =
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
    let v15 : Async<int64> = null |> unbox<Async<int64>>
    let _v5 = v15 
    #endif
#if FABLE_COMPILER_PYTHON
    let v18 : Async<int64> = null |> unbox<Async<int64>>
    let _v5 = v18 
    #endif
#else
    let v21 : Async<int64> option = None
    let mutable _v21 = v21 
    async {
    let v22 : US7 option = None
    let _v22 = ref v22 
    match v0 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v23 : int32 = x
    let v24 : US7 = US7_0(v23)
    v24 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v22.Value <- x
    let v25 : US7 option = _v22.Value 
    let v36 : US7 = US7_1
    let v37 : US7 = v25 |> Option.defaultValue v36 
    let v3207 : Async<bool> =
        match v37 with
        | US7_1 -> (* None *)
            let v41 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v42 : Async<bool> = null |> unbox<Async<bool>>
            let _v41 = v42 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v45 : Async<bool> = null |> unbox<Async<bool>>
            let _v41 = v45 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v48 : Async<bool> = null |> unbox<Async<bool>>
            let _v41 = v48 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v51 : Async<bool> = null |> unbox<Async<bool>>
            let _v41 = v51 
            #endif
#if FABLE_COMPILER_PYTHON
            let v54 : Async<bool> = null |> unbox<Async<bool>>
            let _v41 = v54 
            #endif
#else
            let v57 : Async<bool> option = None
            let mutable _v57 = v57 
            async {
            let v58 : Async<System.Threading.CancellationToken> = Async.CancellationToken
            let! v58 = v58 
            let v59 : System.Threading.CancellationToken = v58 
            let v60 : System.Net.Sockets.TcpClient = new System.Net.Sockets.TcpClient ()
            use v60 = v60 
            let v61 : System.Net.Sockets.TcpClient = v60 
            try
            let v62 : System.Threading.Tasks.ValueTask = v61.ConnectAsync (v2, v3, v59)
            let v63 : (unit -> System.Threading.Tasks.Task) = v62.AsTask
            let v64 : System.Threading.Tasks.Task = v63 ()
            let v65 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v66 : Async<unit> = null |> unbox<Async<unit>>
            let _v65 = v66 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v69 : Async<unit> = null |> unbox<Async<unit>>
            let _v65 = v69 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v72 : Async<unit> = null |> unbox<Async<unit>>
            let _v65 = v72 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v75 : Async<unit> = null |> unbox<Async<unit>>
            let _v65 = v75 
            #endif
#if FABLE_COMPILER_PYTHON
            let v78 : Async<unit> = null |> unbox<Async<unit>>
            let _v65 = v78 
            #endif
#else
            let v81 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
            let v82 : Async<unit> = v81 v64
            let _v65 = v82 
            #endif
            let v83 : Async<unit> = _v65 
            do! v83 
            return true 
            with ex ->
            let v88 : exn = ex
            let v89 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v90 : string = $"%A{v88}"
            let _v89 = v90 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v93 : string = $"%A{v88}"
            let _v89 = v93 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v96 : string = $"%A{v88}"
            let _v89 = v96 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v99 : string = $"%A{v88}"
            let _v89 = v99 
            #endif
#if FABLE_COMPILER_PYTHON
            let v102 : string = $"%A{v88}"
            let _v89 = v102 
            #endif
#else
            let v105 : string = $"{v88.GetType ()}: {v88.Message}"
            let _v89 = v105 
            #endif
            let v106 : string = _v89 
            let v111 : bool = State.trace_state.IsNone
            if v111 then
                let v112 : US0 = US0_0
                let struct (v113 : Mut0, v114 : Mut1, v115 : Mut2, v116 : Mut3, v117 : int64 option) = method0(v112)
                let v118 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v113, v114, v115, v116, v117) 
                State.trace_state <- v118 
                ()
            let struct (v123 : Mut0, v124 : Mut1, v125 : Mut2, v126 : Mut3, v127 : int64 option) = State.trace_state.Value
            let v138 : bool = State.trace_state.IsNone
            if v138 then
                let v139 : US0 = US0_0
                let struct (v140 : Mut0, v141 : Mut1, v142 : Mut2, v143 : Mut3, v144 : int64 option) = method0(v139)
                let v145 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v140, v141, v142, v143, v144) 
                State.trace_state <- v145 
                ()
            let struct (v150 : Mut0, v151 : Mut1, v152 : Mut2, v153 : Mut3, v154 : int64 option) = State.trace_state.Value
            let v165 : US0 = v153.l0
            let v166 : bool = v152.l0
            let v167 : bool = v166 = false
            let v170 : bool =
                if v167 then
                    false
                else
                    let v168 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v165
                    let v169 : bool = 0 >= v168
                    v169
            if v170 then
                let v171 : int64 = v123.l0
                let v172 : int64 = v171 + 1L
                v123.l0 <- v172
                let v173 : bool = State.trace_state.IsNone
                if v173 then
                    let v174 : US0 = US0_0
                    let struct (v175 : Mut0, v176 : Mut1, v177 : Mut2, v178 : Mut3, v179 : int64 option) = method0(v174)
                    let v180 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v175, v176, v177, v178, v179) 
                    State.trace_state <- v180 
                    ()
                let struct (v185 : Mut0, v186 : Mut1, v187 : Mut2, v188 : Mut3, v189 : int64 option) = State.trace_state.Value
                let v200 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v201 : US3 option = None
                let _v201 = ref v201 
                match v189 with
                | Some x -> (
                (fun () ->
                (fun () ->
                let v202 : int64 = x
                let v203 : US3 = US3_0(v202)
                v203 
                )
                |> fun x -> x () |> Some
                ) () ) | None -> None
                |> fun x -> _v201.Value <- x
                let v204 : US3 option = _v201.Value 
                let v215 : US3 = US3_1
                let v216 : US3 = v204 |> Option.defaultValue v215 
                let v256 : System.DateTime =
                    match v216 with
                    | US3_1 -> (* None *)
                        let v252 : System.DateTime = System.DateTime.Now
                        v252
                    | US3_0(v220) -> (* Some *)
                        let v221 : System.DateTime = System.DateTime.Now
                        let v224 : (System.DateTime -> int64) = _.Ticks
                        let v225 : int64 = v224 v221
                        let v228 : int64 = v225 - v220
                        let v229 : (int64 -> System.TimeSpan) = System.TimeSpan 
                        let v230 : System.TimeSpan = v229 v228
                        let v233 : (System.TimeSpan -> int32) = _.Hours
                        let v234 : int32 = v233 v230
                        let v237 : (System.TimeSpan -> int32) = _.Minutes
                        let v238 : int32 = v237 v230
                        let v241 : (System.TimeSpan -> int32) = _.Seconds
                        let v242 : int32 = v241 v230
                        let v245 : (System.TimeSpan -> int32) = _.Milliseconds
                        let v246 : int32 = v245 v230
                        let v249 : System.DateTime = System.DateTime (1, 1, 1, v234, v238, v242, v246)
                        v249
                let v257 : string = method5()
                let v260 : (string -> string) = v256.ToString
                let v261 : string = v260 v257
                let _v200 = v261 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v264 : US3 option = None
                let _v264 = ref v264 
                match v189 with
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
                let v320 : string = method5()
                let v323 : (string -> string) = v319.ToString
                let v324 : string = v323 v320
                let _v200 = v324 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v327 : string = $"near_sdk::env::block_timestamp()"
                let v328 : uint64 = Fable.Core.RustInterop.emitRustExpr () v327 
                let v329 : US3 option = None
                let _v329 = ref v329 
                match v189 with
                | Some x -> (
                (fun () ->
                (fun () ->
                let v330 : int64 = x
                let v331 : US3 = US3_0(v330)
                v331 
                )
                |> fun x -> x () |> Some
                ) () ) | None -> None
                |> fun x -> _v329.Value <- x
                let v332 : US3 option = _v329.Value 
                let v343 : US3 = US3_1
                let v344 : US3 = v332 |> Option.defaultValue v343 
                let v353 : uint64 =
                    match v344 with
                    | US3_1 -> (* None *)
                        v328
                    | US3_0(v348) -> (* Some *)
                        let v349 : (int64 -> uint64) = uint64
                        let v350 : uint64 = v349 v348
                        let v351 : uint64 = v328 - v350
                        v351
                let v354 : uint64 = v353 / 1000000000UL
                let v355 : uint64 = v354 % 60UL
                let v356 : uint64 = v354 / 60UL
                let v357 : uint64 = v356 % 60UL
                let v358 : uint64 = v354 / 3600UL
                let v359 : uint64 = v358 % 24UL
                let v360 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
                let v361 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v359, v357, v355) v360 
                let v362 : string = "fable_library_rust::String_::fromString($0)"
                let v363 : string = Fable.Core.RustInterop.emitRustExpr v361 v362 
                let _v200 = v363 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v364 : US3 option = None
                let _v364 = ref v364 
                match v189 with
                | Some x -> (
                (fun () ->
                (fun () ->
                let v365 : int64 = x
                let v366 : US3 = US3_0(v365)
                v366 
                )
                |> fun x -> x () |> Some
                ) () ) | None -> None
                |> fun x -> _v364.Value <- x
                let v367 : US3 option = _v364.Value 
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
                let v420 : string = method6()
                let v423 : (string -> string) = v419.ToString
                let v424 : string = v423 v420
                let _v200 = v424 
                #endif
#if FABLE_COMPILER_PYTHON
                let v427 : US3 option = None
                let _v427 = ref v427 
                match v189 with
                | Some x -> (
                (fun () ->
                (fun () ->
                let v428 : int64 = x
                let v429 : US3 = US3_0(v428)
                v429 
                )
                |> fun x -> x () |> Some
                ) () ) | None -> None
                |> fun x -> _v427.Value <- x
                let v430 : US3 option = _v427.Value 
                let v441 : US3 = US3_1
                let v442 : US3 = v430 |> Option.defaultValue v441 
                let v482 : System.DateTime =
                    match v442 with
                    | US3_1 -> (* None *)
                        let v478 : System.DateTime = System.DateTime.Now
                        v478
                    | US3_0(v446) -> (* Some *)
                        let v447 : System.DateTime = System.DateTime.Now
                        let v450 : (System.DateTime -> int64) = _.Ticks
                        let v451 : int64 = v450 v447
                        let v454 : int64 = v451 - v446
                        let v455 : (int64 -> System.TimeSpan) = System.TimeSpan 
                        let v456 : System.TimeSpan = v455 v454
                        let v459 : (System.TimeSpan -> int32) = _.Hours
                        let v460 : int32 = v459 v456
                        let v463 : (System.TimeSpan -> int32) = _.Minutes
                        let v464 : int32 = v463 v456
                        let v467 : (System.TimeSpan -> int32) = _.Seconds
                        let v468 : int32 = v467 v456
                        let v471 : (System.TimeSpan -> int32) = _.Milliseconds
                        let v472 : int32 = v471 v456
                        let v475 : System.DateTime = System.DateTime (1, 1, 1, v460, v464, v468, v472)
                        v475
                let v483 : string = method6()
                let v486 : (string -> string) = v482.ToString
                let v487 : string = v486 v483
                let _v200 = v487 
                #endif
#else
                let v490 : US3 option = None
                let _v490 = ref v490 
                match v189 with
                | Some x -> (
                (fun () ->
                (fun () ->
                let v491 : int64 = x
                let v492 : US3 = US3_0(v491)
                v492 
                )
                |> fun x -> x () |> Some
                ) () ) | None -> None
                |> fun x -> _v490.Value <- x
                let v493 : US3 option = _v490.Value 
                let v504 : US3 = US3_1
                let v505 : US3 = v493 |> Option.defaultValue v504 
                let v545 : System.DateTime =
                    match v505 with
                    | US3_1 -> (* None *)
                        let v541 : System.DateTime = System.DateTime.Now
                        v541
                    | US3_0(v509) -> (* Some *)
                        let v510 : System.DateTime = System.DateTime.Now
                        let v513 : (System.DateTime -> int64) = _.Ticks
                        let v514 : int64 = v513 v510
                        let v517 : int64 = v514 - v509
                        let v518 : (int64 -> System.TimeSpan) = System.TimeSpan 
                        let v519 : System.TimeSpan = v518 v517
                        let v522 : (System.TimeSpan -> int32) = _.Hours
                        let v523 : int32 = v522 v519
                        let v526 : (System.TimeSpan -> int32) = _.Minutes
                        let v527 : int32 = v526 v519
                        let v530 : (System.TimeSpan -> int32) = _.Seconds
                        let v531 : int32 = v530 v519
                        let v534 : (System.TimeSpan -> int32) = _.Milliseconds
                        let v535 : int32 = v534 v519
                        let v538 : System.DateTime = System.DateTime (1, 1, 1, v523, v527, v531, v535)
                        v538
                let v546 : string = method6()
                let v549 : (string -> string) = v545.ToString
                let v550 : string = v549 v546
                let _v200 = v550 
                #endif
                let v553 : string = _v200 
                let v618 : string = "Verbose"
                let v619 : (unit -> string) = v618.ToLower
                let v620 : string = v619 ()
                let v623 : string = v620.PadLeft (7, ' ')
                let v637 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v638 : string = "inline_colorization::color_bright_black"
                let v639 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v638 
                let v640 : string = "&*$0"
                let v641 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v623 v640 
                let v642 : string = "inline_colorization::color_reset"
                let v643 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v642 
                let v644 : string = "\"{v639}{v641}{v643}\""
                let v645 : string = @$"format!(" + v644 + ")"
                let v646 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v645 
                let v647 : string = "fable_library_rust::String_::fromString($0)"
                let v648 : string = Fable.Core.RustInterop.emitRustExpr v646 v647 
                let _v637 = v648 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v649 : string = "inline_colorization::color_bright_black"
                let v650 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v649 
                let v651 : string = "&*$0"
                let v652 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v623 v651 
                let v653 : string = "inline_colorization::color_reset"
                let v654 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v653 
                let v655 : string = "\"{v650}{v652}{v654}\""
                let v656 : string = @$"format!(" + v655 + ")"
                let v657 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v656 
                let v658 : string = "fable_library_rust::String_::fromString($0)"
                let v659 : string = Fable.Core.RustInterop.emitRustExpr v657 v658 
                let _v637 = v659 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v660 : string = "inline_colorization::color_bright_black"
                let v661 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v660 
                let v662 : string = "&*$0"
                let v663 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v623 v662 
                let v664 : string = "inline_colorization::color_reset"
                let v665 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v664 
                let v666 : string = "\"{v661}{v663}{v665}\""
                let v667 : string = @$"format!(" + v666 + ")"
                let v668 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v667 
                let v669 : string = "fable_library_rust::String_::fromString($0)"
                let v670 : string = Fable.Core.RustInterop.emitRustExpr v668 v669 
                let _v637 = v670 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v671 : string = "\u001b[90m"
                let v672 : string = method7()
                let v673 : string = v671 + v623 
                let v674 : string = v673 + v672 
                let _v637 = v674 
                #endif
#if FABLE_COMPILER_PYTHON
                let v675 : string = "\u001b[90m"
                let v676 : string = method7()
                let v677 : string = v675 + v623 
                let v678 : string = v677 + v676 
                let _v637 = v678 
                #endif
#else
                let v679 : string = "\u001b[90m"
                let v680 : string = method7()
                let v681 : string = v679 + v623 
                let v682 : string = v681 + v680 
                let _v637 = v682 
                #endif
                let v683 : string = _v637 
                let v689 : int64 = v185.l0
                let v690 : string = method8()
                let v691 : Mut4 = {l0 = v690} : Mut4
                let v692 : string = "{ "
                let v693 : string = $"{v692}"
                let v696 : string = v691.l0
                let v697 : string = v696 + v693 
                v691.l0 <- v697
                let v698 : string = "port"
                let v699 : string = $"{v698}"
                let v702 : string = v691.l0
                let v703 : string = v702 + v699 
                v691.l0 <- v703
                let v704 : string = " = "
                let v705 : string = $"{v704}"
                let v708 : string = v691.l0
                let v709 : string = v708 + v705 
                v691.l0 <- v709
                let v710 : string = $"{v3}"
                let v713 : string = v691.l0
                let v714 : string = v713 + v710 
                v691.l0 <- v714
                let v715 : string = "; "
                let v716 : string = $"{v715}"
                let v719 : string = v691.l0
                let v720 : string = v719 + v716 
                v691.l0 <- v720
                let v721 : string = "ex"
                let v722 : string = $"{v721}"
                let v725 : string = v691.l0
                let v726 : string = v725 + v722 
                v691.l0 <- v726
                let v727 : string = $"{v704}"
                let v730 : string = v691.l0
                let v731 : string = v730 + v727 
                v691.l0 <- v731
                let v732 : string = $"{v106}"
                let v735 : string = v691.l0
                let v736 : string = v735 + v732 
                v691.l0 <- v736
                let v737 : string = " }"
                let v738 : string = $"{v737}"
                let v741 : string = v691.l0
                let v742 : string = v741 + v738 
                v691.l0 <- v742
                let v743 : string = v691.l0
                let v744 : (unit -> string) = closure3()
                let v745 : string = $"{v553} {v683} #{v689} %s{v744 ()} / {v743}"
                let v748 : char list = []
                let v749 : (char list -> (char [])) = List.toArray
                let v750 : (char []) = v749 v748
                let v753 : string = v745.TrimStart v750 
                let v771 : char list = []
                let v772 : char list = '/' :: v771 
                let v775 : char list = ' ' :: v772 
                let v778 : (char list -> (char [])) = List.toArray
                let v779 : (char []) = v778 v775
                let v782 : string = v753.TrimEnd v779 
                let v800 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v801 : string = @"println!(""{}"", $0)"
                Fable.Core.RustInterop.emitRustExpr v782 v801 
                let _v800 = () 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v802 : string = @"println!(""{}"", $0)"
                Fable.Core.RustInterop.emitRustExpr v782 v802 
                let _v800 = () 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v803 : string = $"near_sdk::log!(\"{{}}\", $0)"
                Fable.Core.RustInterop.emitRustExpr v782 v803 
                let _v800 = () 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                System.Console.WriteLine v782 
                let _v800 = () 
                #endif
#if FABLE_COMPILER_PYTHON
                System.Console.WriteLine v782 
                let _v800 = () 
                #endif
#else
                System.Console.WriteLine v782 
                let _v800 = () 
                #endif
                _v800 
                let v804 : (string -> unit) = v124.l0
                v804 v782
            return false 
            (*
            let v805 : bool = *)
            }
            |> fun x -> _v57 <- Some x
            let v806 : Async<bool> = match _v57 with Some x -> x | None -> failwith "async.new_async_unit / _v57=None"
            let _v41 = v806 
            #endif
            let v807 : Async<bool> = _v41 
            v807
        | US7_0(v812) -> (* Some *)
            let v813 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v814 : Async<bool> = null |> unbox<Async<bool>>
            let _v813 = v814 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v817 : Async<bool> = null |> unbox<Async<bool>>
            let _v813 = v817 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v820 : Async<bool> = null |> unbox<Async<bool>>
            let _v813 = v820 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v823 : Async<bool> = null |> unbox<Async<bool>>
            let _v813 = v823 
            #endif
#if FABLE_COMPILER_PYTHON
            let v826 : Async<bool> = null |> unbox<Async<bool>>
            let _v813 = v826 
            #endif
#else
            let v829 : Async<bool> option = None
            let mutable _v829 = v829 
            async {
            let v830 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v831 : Async<bool> = null |> unbox<Async<bool>>
            let _v830 = v831 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v834 : Async<bool> = null |> unbox<Async<bool>>
            let _v830 = v834 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v837 : Async<bool> = null |> unbox<Async<bool>>
            let _v830 = v837 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v840 : Async<bool> = null |> unbox<Async<bool>>
            let _v830 = v840 
            #endif
#if FABLE_COMPILER_PYTHON
            let v843 : Async<bool> = null |> unbox<Async<bool>>
            let _v830 = v843 
            #endif
#else
            let v846 : Async<bool> option = None
            let mutable _v846 = v846 
            async {
            let v847 : Async<System.Threading.CancellationToken> = Async.CancellationToken
            let! v847 = v847 
            let v848 : System.Threading.CancellationToken = v847 
            let v849 : System.Net.Sockets.TcpClient = new System.Net.Sockets.TcpClient ()
            use v849 = v849 
            let v850 : System.Net.Sockets.TcpClient = v849 
            try
            let v851 : System.Threading.Tasks.ValueTask = v850.ConnectAsync (v2, v3, v848)
            let v852 : (unit -> System.Threading.Tasks.Task) = v851.AsTask
            let v853 : System.Threading.Tasks.Task = v852 ()
            let v854 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v855 : Async<unit> = null |> unbox<Async<unit>>
            let _v854 = v855 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v858 : Async<unit> = null |> unbox<Async<unit>>
            let _v854 = v858 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v861 : Async<unit> = null |> unbox<Async<unit>>
            let _v854 = v861 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v864 : Async<unit> = null |> unbox<Async<unit>>
            let _v854 = v864 
            #endif
#if FABLE_COMPILER_PYTHON
            let v867 : Async<unit> = null |> unbox<Async<unit>>
            let _v854 = v867 
            #endif
#else
            let v870 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
            let v871 : Async<unit> = v870 v853
            let _v854 = v871 
            #endif
            let v872 : Async<unit> = _v854 
            do! v872 
            return true 
            with ex ->
            let v877 : exn = ex
            let v878 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v879 : string = $"%A{v877}"
            let _v878 = v879 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v882 : string = $"%A{v877}"
            let _v878 = v882 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v885 : string = $"%A{v877}"
            let _v878 = v885 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v888 : string = $"%A{v877}"
            let _v878 = v888 
            #endif
#if FABLE_COMPILER_PYTHON
            let v891 : string = $"%A{v877}"
            let _v878 = v891 
            #endif
#else
            let v894 : string = $"{v877.GetType ()}: {v877.Message}"
            let _v878 = v894 
            #endif
            let v895 : string = _v878 
            let v900 : bool = State.trace_state.IsNone
            if v900 then
                let v901 : US0 = US0_0
                let struct (v902 : Mut0, v903 : Mut1, v904 : Mut2, v905 : Mut3, v906 : int64 option) = method0(v901)
                let v907 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v902, v903, v904, v905, v906) 
                State.trace_state <- v907 
                ()
            let struct (v912 : Mut0, v913 : Mut1, v914 : Mut2, v915 : Mut3, v916 : int64 option) = State.trace_state.Value
            let v927 : bool = State.trace_state.IsNone
            if v927 then
                let v928 : US0 = US0_0
                let struct (v929 : Mut0, v930 : Mut1, v931 : Mut2, v932 : Mut3, v933 : int64 option) = method0(v928)
                let v934 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v929, v930, v931, v932, v933) 
                State.trace_state <- v934 
                ()
            let struct (v939 : Mut0, v940 : Mut1, v941 : Mut2, v942 : Mut3, v943 : int64 option) = State.trace_state.Value
            let v954 : US0 = v942.l0
            let v955 : bool = v941.l0
            let v956 : bool = v955 = false
            let v959 : bool =
                if v956 then
                    false
                else
                    let v957 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v954
                    let v958 : bool = 0 >= v957
                    v958
            if v959 then
                let v960 : int64 = v912.l0
                let v961 : int64 = v960 + 1L
                v912.l0 <- v961
                let v962 : bool = State.trace_state.IsNone
                if v962 then
                    let v963 : US0 = US0_0
                    let struct (v964 : Mut0, v965 : Mut1, v966 : Mut2, v967 : Mut3, v968 : int64 option) = method0(v963)
                    let v969 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v964, v965, v966, v967, v968) 
                    State.trace_state <- v969 
                    ()
                let struct (v974 : Mut0, v975 : Mut1, v976 : Mut2, v977 : Mut3, v978 : int64 option) = State.trace_state.Value
                let v989 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v990 : US3 option = None
                let _v990 = ref v990 
                match v978 with
                | Some x -> (
                (fun () ->
                (fun () ->
                let v991 : int64 = x
                let v992 : US3 = US3_0(v991)
                v992 
                )
                |> fun x -> x () |> Some
                ) () ) | None -> None
                |> fun x -> _v990.Value <- x
                let v993 : US3 option = _v990.Value 
                let v1004 : US3 = US3_1
                let v1005 : US3 = v993 |> Option.defaultValue v1004 
                let v1045 : System.DateTime =
                    match v1005 with
                    | US3_1 -> (* None *)
                        let v1041 : System.DateTime = System.DateTime.Now
                        v1041
                    | US3_0(v1009) -> (* Some *)
                        let v1010 : System.DateTime = System.DateTime.Now
                        let v1013 : (System.DateTime -> int64) = _.Ticks
                        let v1014 : int64 = v1013 v1010
                        let v1017 : int64 = v1014 - v1009
                        let v1018 : (int64 -> System.TimeSpan) = System.TimeSpan 
                        let v1019 : System.TimeSpan = v1018 v1017
                        let v1022 : (System.TimeSpan -> int32) = _.Hours
                        let v1023 : int32 = v1022 v1019
                        let v1026 : (System.TimeSpan -> int32) = _.Minutes
                        let v1027 : int32 = v1026 v1019
                        let v1030 : (System.TimeSpan -> int32) = _.Seconds
                        let v1031 : int32 = v1030 v1019
                        let v1034 : (System.TimeSpan -> int32) = _.Milliseconds
                        let v1035 : int32 = v1034 v1019
                        let v1038 : System.DateTime = System.DateTime (1, 1, 1, v1023, v1027, v1031, v1035)
                        v1038
                let v1046 : string = method5()
                let v1049 : (string -> string) = v1045.ToString
                let v1050 : string = v1049 v1046
                let _v989 = v1050 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v1053 : US3 option = None
                let _v1053 = ref v1053 
                match v978 with
                | Some x -> (
                (fun () ->
                (fun () ->
                let v1054 : int64 = x
                let v1055 : US3 = US3_0(v1054)
                v1055 
                )
                |> fun x -> x () |> Some
                ) () ) | None -> None
                |> fun x -> _v1053.Value <- x
                let v1056 : US3 option = _v1053.Value 
                let v1067 : US3 = US3_1
                let v1068 : US3 = v1056 |> Option.defaultValue v1067 
                let v1108 : System.DateTime =
                    match v1068 with
                    | US3_1 -> (* None *)
                        let v1104 : System.DateTime = System.DateTime.Now
                        v1104
                    | US3_0(v1072) -> (* Some *)
                        let v1073 : System.DateTime = System.DateTime.Now
                        let v1076 : (System.DateTime -> int64) = _.Ticks
                        let v1077 : int64 = v1076 v1073
                        let v1080 : int64 = v1077 - v1072
                        let v1081 : (int64 -> System.TimeSpan) = System.TimeSpan 
                        let v1082 : System.TimeSpan = v1081 v1080
                        let v1085 : (System.TimeSpan -> int32) = _.Hours
                        let v1086 : int32 = v1085 v1082
                        let v1089 : (System.TimeSpan -> int32) = _.Minutes
                        let v1090 : int32 = v1089 v1082
                        let v1093 : (System.TimeSpan -> int32) = _.Seconds
                        let v1094 : int32 = v1093 v1082
                        let v1097 : (System.TimeSpan -> int32) = _.Milliseconds
                        let v1098 : int32 = v1097 v1082
                        let v1101 : System.DateTime = System.DateTime (1, 1, 1, v1086, v1090, v1094, v1098)
                        v1101
                let v1109 : string = method5()
                let v1112 : (string -> string) = v1108.ToString
                let v1113 : string = v1112 v1109
                let _v989 = v1113 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v1116 : string = $"near_sdk::env::block_timestamp()"
                let v1117 : uint64 = Fable.Core.RustInterop.emitRustExpr () v1116 
                let v1118 : US3 option = None
                let _v1118 = ref v1118 
                match v978 with
                | Some x -> (
                (fun () ->
                (fun () ->
                let v1119 : int64 = x
                let v1120 : US3 = US3_0(v1119)
                v1120 
                )
                |> fun x -> x () |> Some
                ) () ) | None -> None
                |> fun x -> _v1118.Value <- x
                let v1121 : US3 option = _v1118.Value 
                let v1132 : US3 = US3_1
                let v1133 : US3 = v1121 |> Option.defaultValue v1132 
                let v1142 : uint64 =
                    match v1133 with
                    | US3_1 -> (* None *)
                        v1117
                    | US3_0(v1137) -> (* Some *)
                        let v1138 : (int64 -> uint64) = uint64
                        let v1139 : uint64 = v1138 v1137
                        let v1140 : uint64 = v1117 - v1139
                        v1140
                let v1143 : uint64 = v1142 / 1000000000UL
                let v1144 : uint64 = v1143 % 60UL
                let v1145 : uint64 = v1143 / 60UL
                let v1146 : uint64 = v1145 % 60UL
                let v1147 : uint64 = v1143 / 3600UL
                let v1148 : uint64 = v1147 % 24UL
                let v1149 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
                let v1150 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v1148, v1146, v1144) v1149 
                let v1151 : string = "fable_library_rust::String_::fromString($0)"
                let v1152 : string = Fable.Core.RustInterop.emitRustExpr v1150 v1151 
                let _v989 = v1152 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v1153 : US3 option = None
                let _v1153 = ref v1153 
                match v978 with
                | Some x -> (
                (fun () ->
                (fun () ->
                let v1154 : int64 = x
                let v1155 : US3 = US3_0(v1154)
                v1155 
                )
                |> fun x -> x () |> Some
                ) () ) | None -> None
                |> fun x -> _v1153.Value <- x
                let v1156 : US3 option = _v1153.Value 
                let v1167 : US3 = US3_1
                let v1168 : US3 = v1156 |> Option.defaultValue v1167 
                let v1208 : System.DateTime =
                    match v1168 with
                    | US3_1 -> (* None *)
                        let v1204 : System.DateTime = System.DateTime.Now
                        v1204
                    | US3_0(v1172) -> (* Some *)
                        let v1173 : System.DateTime = System.DateTime.Now
                        let v1176 : (System.DateTime -> int64) = _.Ticks
                        let v1177 : int64 = v1176 v1173
                        let v1180 : int64 = v1177 - v1172
                        let v1181 : (int64 -> System.TimeSpan) = System.TimeSpan 
                        let v1182 : System.TimeSpan = v1181 v1180
                        let v1185 : (System.TimeSpan -> int32) = _.Hours
                        let v1186 : int32 = v1185 v1182
                        let v1189 : (System.TimeSpan -> int32) = _.Minutes
                        let v1190 : int32 = v1189 v1182
                        let v1193 : (System.TimeSpan -> int32) = _.Seconds
                        let v1194 : int32 = v1193 v1182
                        let v1197 : (System.TimeSpan -> int32) = _.Milliseconds
                        let v1198 : int32 = v1197 v1182
                        let v1201 : System.DateTime = System.DateTime (1, 1, 1, v1186, v1190, v1194, v1198)
                        v1201
                let v1209 : string = method6()
                let v1212 : (string -> string) = v1208.ToString
                let v1213 : string = v1212 v1209
                let _v989 = v1213 
                #endif
#if FABLE_COMPILER_PYTHON
                let v1216 : US3 option = None
                let _v1216 = ref v1216 
                match v978 with
                | Some x -> (
                (fun () ->
                (fun () ->
                let v1217 : int64 = x
                let v1218 : US3 = US3_0(v1217)
                v1218 
                )
                |> fun x -> x () |> Some
                ) () ) | None -> None
                |> fun x -> _v1216.Value <- x
                let v1219 : US3 option = _v1216.Value 
                let v1230 : US3 = US3_1
                let v1231 : US3 = v1219 |> Option.defaultValue v1230 
                let v1271 : System.DateTime =
                    match v1231 with
                    | US3_1 -> (* None *)
                        let v1267 : System.DateTime = System.DateTime.Now
                        v1267
                    | US3_0(v1235) -> (* Some *)
                        let v1236 : System.DateTime = System.DateTime.Now
                        let v1239 : (System.DateTime -> int64) = _.Ticks
                        let v1240 : int64 = v1239 v1236
                        let v1243 : int64 = v1240 - v1235
                        let v1244 : (int64 -> System.TimeSpan) = System.TimeSpan 
                        let v1245 : System.TimeSpan = v1244 v1243
                        let v1248 : (System.TimeSpan -> int32) = _.Hours
                        let v1249 : int32 = v1248 v1245
                        let v1252 : (System.TimeSpan -> int32) = _.Minutes
                        let v1253 : int32 = v1252 v1245
                        let v1256 : (System.TimeSpan -> int32) = _.Seconds
                        let v1257 : int32 = v1256 v1245
                        let v1260 : (System.TimeSpan -> int32) = _.Milliseconds
                        let v1261 : int32 = v1260 v1245
                        let v1264 : System.DateTime = System.DateTime (1, 1, 1, v1249, v1253, v1257, v1261)
                        v1264
                let v1272 : string = method6()
                let v1275 : (string -> string) = v1271.ToString
                let v1276 : string = v1275 v1272
                let _v989 = v1276 
                #endif
#else
                let v1279 : US3 option = None
                let _v1279 = ref v1279 
                match v978 with
                | Some x -> (
                (fun () ->
                (fun () ->
                let v1280 : int64 = x
                let v1281 : US3 = US3_0(v1280)
                v1281 
                )
                |> fun x -> x () |> Some
                ) () ) | None -> None
                |> fun x -> _v1279.Value <- x
                let v1282 : US3 option = _v1279.Value 
                let v1293 : US3 = US3_1
                let v1294 : US3 = v1282 |> Option.defaultValue v1293 
                let v1334 : System.DateTime =
                    match v1294 with
                    | US3_1 -> (* None *)
                        let v1330 : System.DateTime = System.DateTime.Now
                        v1330
                    | US3_0(v1298) -> (* Some *)
                        let v1299 : System.DateTime = System.DateTime.Now
                        let v1302 : (System.DateTime -> int64) = _.Ticks
                        let v1303 : int64 = v1302 v1299
                        let v1306 : int64 = v1303 - v1298
                        let v1307 : (int64 -> System.TimeSpan) = System.TimeSpan 
                        let v1308 : System.TimeSpan = v1307 v1306
                        let v1311 : (System.TimeSpan -> int32) = _.Hours
                        let v1312 : int32 = v1311 v1308
                        let v1315 : (System.TimeSpan -> int32) = _.Minutes
                        let v1316 : int32 = v1315 v1308
                        let v1319 : (System.TimeSpan -> int32) = _.Seconds
                        let v1320 : int32 = v1319 v1308
                        let v1323 : (System.TimeSpan -> int32) = _.Milliseconds
                        let v1324 : int32 = v1323 v1308
                        let v1327 : System.DateTime = System.DateTime (1, 1, 1, v1312, v1316, v1320, v1324)
                        v1327
                let v1335 : string = method6()
                let v1338 : (string -> string) = v1334.ToString
                let v1339 : string = v1338 v1335
                let _v989 = v1339 
                #endif
                let v1342 : string = _v989 
                let v1407 : string = "Verbose"
                let v1408 : (unit -> string) = v1407.ToLower
                let v1409 : string = v1408 ()
                let v1412 : string = v1409.PadLeft (7, ' ')
                let v1426 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v1427 : string = "inline_colorization::color_bright_black"
                let v1428 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1427 
                let v1429 : string = "&*$0"
                let v1430 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1412 v1429 
                let v1431 : string = "inline_colorization::color_reset"
                let v1432 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1431 
                let v1433 : string = "\"{v1428}{v1430}{v1432}\""
                let v1434 : string = @$"format!(" + v1433 + ")"
                let v1435 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v1434 
                let v1436 : string = "fable_library_rust::String_::fromString($0)"
                let v1437 : string = Fable.Core.RustInterop.emitRustExpr v1435 v1436 
                let _v1426 = v1437 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v1438 : string = "inline_colorization::color_bright_black"
                let v1439 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1438 
                let v1440 : string = "&*$0"
                let v1441 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1412 v1440 
                let v1442 : string = "inline_colorization::color_reset"
                let v1443 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1442 
                let v1444 : string = "\"{v1439}{v1441}{v1443}\""
                let v1445 : string = @$"format!(" + v1444 + ")"
                let v1446 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v1445 
                let v1447 : string = "fable_library_rust::String_::fromString($0)"
                let v1448 : string = Fable.Core.RustInterop.emitRustExpr v1446 v1447 
                let _v1426 = v1448 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v1449 : string = "inline_colorization::color_bright_black"
                let v1450 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1449 
                let v1451 : string = "&*$0"
                let v1452 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1412 v1451 
                let v1453 : string = "inline_colorization::color_reset"
                let v1454 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1453 
                let v1455 : string = "\"{v1450}{v1452}{v1454}\""
                let v1456 : string = @$"format!(" + v1455 + ")"
                let v1457 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v1456 
                let v1458 : string = "fable_library_rust::String_::fromString($0)"
                let v1459 : string = Fable.Core.RustInterop.emitRustExpr v1457 v1458 
                let _v1426 = v1459 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v1460 : string = "\u001b[90m"
                let v1461 : string = method7()
                let v1462 : string = v1460 + v1412 
                let v1463 : string = v1462 + v1461 
                let _v1426 = v1463 
                #endif
#if FABLE_COMPILER_PYTHON
                let v1464 : string = "\u001b[90m"
                let v1465 : string = method7()
                let v1466 : string = v1464 + v1412 
                let v1467 : string = v1466 + v1465 
                let _v1426 = v1467 
                #endif
#else
                let v1468 : string = "\u001b[90m"
                let v1469 : string = method7()
                let v1470 : string = v1468 + v1412 
                let v1471 : string = v1470 + v1469 
                let _v1426 = v1471 
                #endif
                let v1472 : string = _v1426 
                let v1478 : int64 = v974.l0
                let v1479 : string = method8()
                let v1480 : Mut4 = {l0 = v1479} : Mut4
                let v1481 : string = "{ "
                let v1482 : string = $"{v1481}"
                let v1485 : string = v1480.l0
                let v1486 : string = v1485 + v1482 
                v1480.l0 <- v1486
                let v1487 : string = "port"
                let v1488 : string = $"{v1487}"
                let v1491 : string = v1480.l0
                let v1492 : string = v1491 + v1488 
                v1480.l0 <- v1492
                let v1493 : string = " = "
                let v1494 : string = $"{v1493}"
                let v1497 : string = v1480.l0
                let v1498 : string = v1497 + v1494 
                v1480.l0 <- v1498
                let v1499 : string = $"{v3}"
                let v1502 : string = v1480.l0
                let v1503 : string = v1502 + v1499 
                v1480.l0 <- v1503
                let v1504 : string = "; "
                let v1505 : string = $"{v1504}"
                let v1508 : string = v1480.l0
                let v1509 : string = v1508 + v1505 
                v1480.l0 <- v1509
                let v1510 : string = "ex"
                let v1511 : string = $"{v1510}"
                let v1514 : string = v1480.l0
                let v1515 : string = v1514 + v1511 
                v1480.l0 <- v1515
                let v1516 : string = $"{v1493}"
                let v1519 : string = v1480.l0
                let v1520 : string = v1519 + v1516 
                v1480.l0 <- v1520
                let v1521 : string = $"{v895}"
                let v1524 : string = v1480.l0
                let v1525 : string = v1524 + v1521 
                v1480.l0 <- v1525
                let v1526 : string = " }"
                let v1527 : string = $"{v1526}"
                let v1530 : string = v1480.l0
                let v1531 : string = v1530 + v1527 
                v1480.l0 <- v1531
                let v1532 : string = v1480.l0
                let v1533 : (unit -> string) = closure3()
                let v1534 : string = $"{v1342} {v1472} #{v1478} %s{v1533 ()} / {v1532}"
                let v1537 : char list = []
                let v1538 : (char list -> (char [])) = List.toArray
                let v1539 : (char []) = v1538 v1537
                let v1542 : string = v1534.TrimStart v1539 
                let v1560 : char list = []
                let v1561 : char list = '/' :: v1560 
                let v1564 : char list = ' ' :: v1561 
                let v1567 : (char list -> (char [])) = List.toArray
                let v1568 : (char []) = v1567 v1564
                let v1571 : string = v1542.TrimEnd v1568 
                let v1589 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v1590 : string = @"println!(""{}"", $0)"
                Fable.Core.RustInterop.emitRustExpr v1571 v1590 
                let _v1589 = () 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v1591 : string = @"println!(""{}"", $0)"
                Fable.Core.RustInterop.emitRustExpr v1571 v1591 
                let _v1589 = () 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v1592 : string = $"near_sdk::log!(\"{{}}\", $0)"
                Fable.Core.RustInterop.emitRustExpr v1571 v1592 
                let _v1589 = () 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                System.Console.WriteLine v1571 
                let _v1589 = () 
                #endif
#if FABLE_COMPILER_PYTHON
                System.Console.WriteLine v1571 
                let _v1589 = () 
                #endif
#else
                System.Console.WriteLine v1571 
                let _v1589 = () 
                #endif
                _v1589 
                let v1593 : (string -> unit) = v913.l0
                v1593 v1571
            return false 
            (*
            let v1594 : bool = *)
            }
            |> fun x -> _v846 <- Some x
            let v1595 : Async<bool> = match _v846 with Some x -> x | None -> failwith "async.new_async_unit / _v846=None"
            let _v830 = v1595 
            #endif
            let v1596 : Async<bool> = _v830 
            let v1601 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1602 : Async<US4> = null |> unbox<Async<US4>>
            let _v1601 = v1602 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1605 : Async<US4> = null |> unbox<Async<US4>>
            let _v1601 = v1605 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1608 : Async<US4> = null |> unbox<Async<US4>>
            let _v1601 = v1608 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1611 : Async<US4> = null |> unbox<Async<US4>>
            let _v1601 = v1611 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1614 : Async<US4> = null |> unbox<Async<US4>>
            let _v1601 = v1614 
            #endif
#else
            let v1617 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1618 : Async<US4> = null |> unbox<Async<US4>>
            let _v1617 = v1618 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1621 : Async<US4> = null |> unbox<Async<US4>>
            let _v1617 = v1621 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1624 : Async<US4> = null |> unbox<Async<US4>>
            let _v1617 = v1624 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1627 : Async<US4> = null |> unbox<Async<US4>>
            let _v1617 = v1627 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1630 : Async<US4> = null |> unbox<Async<US4>>
            let _v1617 = v1630 
            #endif
#else
            let v1633 : Async<US4> option = None
            let mutable _v1633 = v1633 
            async {
            let v1634 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1635 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v1634 = v1635 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1638 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v1634 = v1638 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1641 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v1634 = v1641 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1644 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v1634 = v1644 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1647 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v1634 = v1647 
            #endif
#else
            let v1650 : Async<Async<bool>> = Async.StartChild (v1596, v812)
            let _v1634 = v1650 
            #endif
            let v1651 : Async<Async<bool>> = _v1634 
            let! v1651 = v1651 
            let v1656 : Async<bool> = v1651 
            let v1657 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1658 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
            let _v1657 = v1658 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1661 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
            let _v1657 = v1661 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1664 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
            let _v1657 = v1664 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1667 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
            let _v1657 = v1667 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1670 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
            let _v1657 = v1670 
            #endif
#else
            let v1673 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v1674 : Async<Choice<bool, exn>> = v1673 v1656
            let _v1657 = v1674 
            #endif
            let v1675 : Async<Choice<bool, exn>> = _v1657 
            let v1680 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1681 : Async<US5> = null |> unbox<Async<US5>>
            let _v1680 = v1681 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1684 : Async<US5> = null |> unbox<Async<US5>>
            let _v1680 = v1684 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1687 : Async<US5> = null |> unbox<Async<US5>>
            let _v1680 = v1687 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1690 : Async<US5> = null |> unbox<Async<US5>>
            let _v1680 = v1690 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1693 : Async<US5> = null |> unbox<Async<US5>>
            let _v1680 = v1693 
            #endif
#else
            let v1696 : Async<US5> option = None
            let mutable _v1696 = v1696 
            async {
            let! v1675 = v1675 
            let v1697 : Choice<bool, exn> = v1675 
            let v1698 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1699 : US5 = null |> unbox<US5>
            let _v1698 = v1699 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1702 : US5 = null |> unbox<US5>
            let _v1698 = v1702 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1705 : US5 = null |> unbox<US5>
            let _v1698 = v1705 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1708 : US5 = null |> unbox<US5>
            let _v1698 = v1708 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1711 : US5 = null |> unbox<US5>
            let _v1698 = v1711 
            #endif
#else
            let v1714 : (bool -> US5) = closure7()
            let v1715 : (exn -> US5) = closure8()
            let v1716 : US5 = match v1697 with Choice1Of2 x -> v1714 x | Choice2Of2 x -> v1715 x
            let _v1698 = v1716 
            #endif
            let v1717 : US5 = _v1698 
            return v1717 
            }
            |> fun x -> _v1696 <- Some x
            let v1722 : Async<US5> = match _v1696 with Some x -> x | None -> failwith "async.new_async_unit / _v1696=None"
            let _v1680 = v1722 
            #endif
            let v1723 : Async<US5> = _v1680 
            let v1728 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1729 : Async<US6> = null |> unbox<Async<US6>>
            let _v1728 = v1729 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1732 : Async<US6> = null |> unbox<Async<US6>>
            let _v1728 = v1732 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1735 : Async<US6> = null |> unbox<Async<US6>>
            let _v1728 = v1735 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1738 : Async<US6> = null |> unbox<Async<US6>>
            let _v1728 = v1738 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1741 : Async<US6> = null |> unbox<Async<US6>>
            let _v1728 = v1741 
            #endif
#else
            let v1744 : Async<US6> option = None
            let mutable _v1744 = v1744 
            async {
            let! v1723 = v1723 
            let v1745 : US5 = v1723 
            let v1751 : US6 =
                match v1745 with
                | US5_0(v1746) -> (* C1of2 *)
                    US6_0(v1746)
                | US5_1(v1748) -> (* C2of2 *)
                    US6_1(v1748)
            return v1751 
            }
            |> fun x -> _v1744 <- Some x
            let v1752 : Async<US6> = match _v1744 with Some x -> x | None -> failwith "async.new_async_unit / _v1744=None"
            let _v1728 = v1752 
            #endif
            let v1753 : Async<US6> = _v1728 
            let v1758 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1759 : Async<US4> = null |> unbox<Async<US4>>
            let _v1758 = v1759 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1762 : Async<US4> = null |> unbox<Async<US4>>
            let _v1758 = v1762 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1765 : Async<US4> = null |> unbox<Async<US4>>
            let _v1758 = v1765 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1768 : Async<US4> = null |> unbox<Async<US4>>
            let _v1758 = v1768 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1771 : Async<US4> = null |> unbox<Async<US4>>
            let _v1758 = v1771 
            #endif
#else
            let v1774 : Async<US4> option = None
            let mutable _v1774 = v1774 
            async {
            let! v1753 = v1753 
            let v1775 : US6 = v1753 
            let v3178 : US4 =
                match v1775 with
                | US6_1(v1778) -> (* Error *)
                    let v1779 : string = $"%A{v1778}"
                    let v1782 : string = "System.TimeoutException"
                    let v1783 : bool = v1779.Contains v1782 
                    if v1783 then
                        let v1786 : bool = State.trace_state.IsNone
                        if v1786 then
                            let v1787 : US0 = US0_0
                            let struct (v1788 : Mut0, v1789 : Mut1, v1790 : Mut2, v1791 : Mut3, v1792 : int64 option) = method0(v1787)
                            let v1793 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v1788, v1789, v1790, v1791, v1792) 
                            State.trace_state <- v1793 
                            ()
                        let struct (v1798 : Mut0, v1799 : Mut1, v1800 : Mut2, v1801 : Mut3, v1802 : int64 option) = State.trace_state.Value
                        let v1813 : bool = State.trace_state.IsNone
                        if v1813 then
                            let v1814 : US0 = US0_0
                            let struct (v1815 : Mut0, v1816 : Mut1, v1817 : Mut2, v1818 : Mut3, v1819 : int64 option) = method0(v1814)
                            let v1820 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v1815, v1816, v1817, v1818, v1819) 
                            State.trace_state <- v1820 
                            ()
                        let struct (v1825 : Mut0, v1826 : Mut1, v1827 : Mut2, v1828 : Mut3, v1829 : int64 option) = State.trace_state.Value
                        let v1840 : US0 = v1828.l0
                        let v1841 : bool = v1827.l0
                        let v1842 : bool = v1841 = false
                        let v1845 : bool =
                            if v1842 then
                                false
                            else
                                let v1843 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v1840
                                let v1844 : bool = 0 >= v1843
                                v1844
                        if v1845 then
                            let v1846 : int64 = v1798.l0
                            let v1847 : int64 = v1846 + 1L
                            v1798.l0 <- v1847
                            let v1848 : bool = State.trace_state.IsNone
                            if v1848 then
                                let v1849 : US0 = US0_0
                                let struct (v1850 : Mut0, v1851 : Mut1, v1852 : Mut2, v1853 : Mut3, v1854 : int64 option) = method0(v1849)
                                let v1855 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v1850, v1851, v1852, v1853, v1854) 
                                State.trace_state <- v1855 
                                ()
                            let struct (v1860 : Mut0, v1861 : Mut1, v1862 : Mut2, v1863 : Mut3, v1864 : int64 option) = State.trace_state.Value
                            let v1875 : unit = ()
                            
#if FABLE_COMPILER || WASM || CONTRACT
                            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                            let v1876 : US3 option = None
                            let _v1876 = ref v1876 
                            match v1864 with
                            | Some x -> (
                            (fun () ->
                            (fun () ->
                            let v1877 : int64 = x
                            let v1878 : US3 = US3_0(v1877)
                            v1878 
                            )
                            |> fun x -> x () |> Some
                            ) () ) | None -> None
                            |> fun x -> _v1876.Value <- x
                            let v1879 : US3 option = _v1876.Value 
                            let v1890 : US3 = US3_1
                            let v1891 : US3 = v1879 |> Option.defaultValue v1890 
                            let v1931 : System.DateTime =
                                match v1891 with
                                | US3_1 -> (* None *)
                                    let v1927 : System.DateTime = System.DateTime.Now
                                    v1927
                                | US3_0(v1895) -> (* Some *)
                                    let v1896 : System.DateTime = System.DateTime.Now
                                    let v1899 : (System.DateTime -> int64) = _.Ticks
                                    let v1900 : int64 = v1899 v1896
                                    let v1903 : int64 = v1900 - v1895
                                    let v1904 : (int64 -> System.TimeSpan) = System.TimeSpan 
                                    let v1905 : System.TimeSpan = v1904 v1903
                                    let v1908 : (System.TimeSpan -> int32) = _.Hours
                                    let v1909 : int32 = v1908 v1905
                                    let v1912 : (System.TimeSpan -> int32) = _.Minutes
                                    let v1913 : int32 = v1912 v1905
                                    let v1916 : (System.TimeSpan -> int32) = _.Seconds
                                    let v1917 : int32 = v1916 v1905
                                    let v1920 : (System.TimeSpan -> int32) = _.Milliseconds
                                    let v1921 : int32 = v1920 v1905
                                    let v1924 : System.DateTime = System.DateTime (1, 1, 1, v1909, v1913, v1917, v1921)
                                    v1924
                            let v1932 : string = method5()
                            let v1935 : (string -> string) = v1931.ToString
                            let v1936 : string = v1935 v1932
                            let _v1875 = v1936 
                            #endif
#if FABLE_COMPILER_RUST && WASM
                            let v1939 : US3 option = None
                            let _v1939 = ref v1939 
                            match v1864 with
                            | Some x -> (
                            (fun () ->
                            (fun () ->
                            let v1940 : int64 = x
                            let v1941 : US3 = US3_0(v1940)
                            v1941 
                            )
                            |> fun x -> x () |> Some
                            ) () ) | None -> None
                            |> fun x -> _v1939.Value <- x
                            let v1942 : US3 option = _v1939.Value 
                            let v1953 : US3 = US3_1
                            let v1954 : US3 = v1942 |> Option.defaultValue v1953 
                            let v1994 : System.DateTime =
                                match v1954 with
                                | US3_1 -> (* None *)
                                    let v1990 : System.DateTime = System.DateTime.Now
                                    v1990
                                | US3_0(v1958) -> (* Some *)
                                    let v1959 : System.DateTime = System.DateTime.Now
                                    let v1962 : (System.DateTime -> int64) = _.Ticks
                                    let v1963 : int64 = v1962 v1959
                                    let v1966 : int64 = v1963 - v1958
                                    let v1967 : (int64 -> System.TimeSpan) = System.TimeSpan 
                                    let v1968 : System.TimeSpan = v1967 v1966
                                    let v1971 : (System.TimeSpan -> int32) = _.Hours
                                    let v1972 : int32 = v1971 v1968
                                    let v1975 : (System.TimeSpan -> int32) = _.Minutes
                                    let v1976 : int32 = v1975 v1968
                                    let v1979 : (System.TimeSpan -> int32) = _.Seconds
                                    let v1980 : int32 = v1979 v1968
                                    let v1983 : (System.TimeSpan -> int32) = _.Milliseconds
                                    let v1984 : int32 = v1983 v1968
                                    let v1987 : System.DateTime = System.DateTime (1, 1, 1, v1972, v1976, v1980, v1984)
                                    v1987
                            let v1995 : string = method5()
                            let v1998 : (string -> string) = v1994.ToString
                            let v1999 : string = v1998 v1995
                            let _v1875 = v1999 
                            #endif
#if FABLE_COMPILER_RUST && CONTRACT
                            let v2002 : string = $"near_sdk::env::block_timestamp()"
                            let v2003 : uint64 = Fable.Core.RustInterop.emitRustExpr () v2002 
                            let v2004 : US3 option = None
                            let _v2004 = ref v2004 
                            match v1864 with
                            | Some x -> (
                            (fun () ->
                            (fun () ->
                            let v2005 : int64 = x
                            let v2006 : US3 = US3_0(v2005)
                            v2006 
                            )
                            |> fun x -> x () |> Some
                            ) () ) | None -> None
                            |> fun x -> _v2004.Value <- x
                            let v2007 : US3 option = _v2004.Value 
                            let v2018 : US3 = US3_1
                            let v2019 : US3 = v2007 |> Option.defaultValue v2018 
                            let v2028 : uint64 =
                                match v2019 with
                                | US3_1 -> (* None *)
                                    v2003
                                | US3_0(v2023) -> (* Some *)
                                    let v2024 : (int64 -> uint64) = uint64
                                    let v2025 : uint64 = v2024 v2023
                                    let v2026 : uint64 = v2003 - v2025
                                    v2026
                            let v2029 : uint64 = v2028 / 1000000000UL
                            let v2030 : uint64 = v2029 % 60UL
                            let v2031 : uint64 = v2029 / 60UL
                            let v2032 : uint64 = v2031 % 60UL
                            let v2033 : uint64 = v2029 / 3600UL
                            let v2034 : uint64 = v2033 % 24UL
                            let v2035 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
                            let v2036 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v2034, v2032, v2030) v2035 
                            let v2037 : string = "fable_library_rust::String_::fromString($0)"
                            let v2038 : string = Fable.Core.RustInterop.emitRustExpr v2036 v2037 
                            let _v1875 = v2038 
                            #endif
#if FABLE_COMPILER_TYPESCRIPT
                            let v2039 : US3 option = None
                            let _v2039 = ref v2039 
                            match v1864 with
                            | Some x -> (
                            (fun () ->
                            (fun () ->
                            let v2040 : int64 = x
                            let v2041 : US3 = US3_0(v2040)
                            v2041 
                            )
                            |> fun x -> x () |> Some
                            ) () ) | None -> None
                            |> fun x -> _v2039.Value <- x
                            let v2042 : US3 option = _v2039.Value 
                            let v2053 : US3 = US3_1
                            let v2054 : US3 = v2042 |> Option.defaultValue v2053 
                            let v2094 : System.DateTime =
                                match v2054 with
                                | US3_1 -> (* None *)
                                    let v2090 : System.DateTime = System.DateTime.Now
                                    v2090
                                | US3_0(v2058) -> (* Some *)
                                    let v2059 : System.DateTime = System.DateTime.Now
                                    let v2062 : (System.DateTime -> int64) = _.Ticks
                                    let v2063 : int64 = v2062 v2059
                                    let v2066 : int64 = v2063 - v2058
                                    let v2067 : (int64 -> System.TimeSpan) = System.TimeSpan 
                                    let v2068 : System.TimeSpan = v2067 v2066
                                    let v2071 : (System.TimeSpan -> int32) = _.Hours
                                    let v2072 : int32 = v2071 v2068
                                    let v2075 : (System.TimeSpan -> int32) = _.Minutes
                                    let v2076 : int32 = v2075 v2068
                                    let v2079 : (System.TimeSpan -> int32) = _.Seconds
                                    let v2080 : int32 = v2079 v2068
                                    let v2083 : (System.TimeSpan -> int32) = _.Milliseconds
                                    let v2084 : int32 = v2083 v2068
                                    let v2087 : System.DateTime = System.DateTime (1, 1, 1, v2072, v2076, v2080, v2084)
                                    v2087
                            let v2095 : string = method6()
                            let v2098 : (string -> string) = v2094.ToString
                            let v2099 : string = v2098 v2095
                            let _v1875 = v2099 
                            #endif
#if FABLE_COMPILER_PYTHON
                            let v2102 : US3 option = None
                            let _v2102 = ref v2102 
                            match v1864 with
                            | Some x -> (
                            (fun () ->
                            (fun () ->
                            let v2103 : int64 = x
                            let v2104 : US3 = US3_0(v2103)
                            v2104 
                            )
                            |> fun x -> x () |> Some
                            ) () ) | None -> None
                            |> fun x -> _v2102.Value <- x
                            let v2105 : US3 option = _v2102.Value 
                            let v2116 : US3 = US3_1
                            let v2117 : US3 = v2105 |> Option.defaultValue v2116 
                            let v2157 : System.DateTime =
                                match v2117 with
                                | US3_1 -> (* None *)
                                    let v2153 : System.DateTime = System.DateTime.Now
                                    v2153
                                | US3_0(v2121) -> (* Some *)
                                    let v2122 : System.DateTime = System.DateTime.Now
                                    let v2125 : (System.DateTime -> int64) = _.Ticks
                                    let v2126 : int64 = v2125 v2122
                                    let v2129 : int64 = v2126 - v2121
                                    let v2130 : (int64 -> System.TimeSpan) = System.TimeSpan 
                                    let v2131 : System.TimeSpan = v2130 v2129
                                    let v2134 : (System.TimeSpan -> int32) = _.Hours
                                    let v2135 : int32 = v2134 v2131
                                    let v2138 : (System.TimeSpan -> int32) = _.Minutes
                                    let v2139 : int32 = v2138 v2131
                                    let v2142 : (System.TimeSpan -> int32) = _.Seconds
                                    let v2143 : int32 = v2142 v2131
                                    let v2146 : (System.TimeSpan -> int32) = _.Milliseconds
                                    let v2147 : int32 = v2146 v2131
                                    let v2150 : System.DateTime = System.DateTime (1, 1, 1, v2135, v2139, v2143, v2147)
                                    v2150
                            let v2158 : string = method6()
                            let v2161 : (string -> string) = v2157.ToString
                            let v2162 : string = v2161 v2158
                            let _v1875 = v2162 
                            #endif
#else
                            let v2165 : US3 option = None
                            let _v2165 = ref v2165 
                            match v1864 with
                            | Some x -> (
                            (fun () ->
                            (fun () ->
                            let v2166 : int64 = x
                            let v2167 : US3 = US3_0(v2166)
                            v2167 
                            )
                            |> fun x -> x () |> Some
                            ) () ) | None -> None
                            |> fun x -> _v2165.Value <- x
                            let v2168 : US3 option = _v2165.Value 
                            let v2179 : US3 = US3_1
                            let v2180 : US3 = v2168 |> Option.defaultValue v2179 
                            let v2220 : System.DateTime =
                                match v2180 with
                                | US3_1 -> (* None *)
                                    let v2216 : System.DateTime = System.DateTime.Now
                                    v2216
                                | US3_0(v2184) -> (* Some *)
                                    let v2185 : System.DateTime = System.DateTime.Now
                                    let v2188 : (System.DateTime -> int64) = _.Ticks
                                    let v2189 : int64 = v2188 v2185
                                    let v2192 : int64 = v2189 - v2184
                                    let v2193 : (int64 -> System.TimeSpan) = System.TimeSpan 
                                    let v2194 : System.TimeSpan = v2193 v2192
                                    let v2197 : (System.TimeSpan -> int32) = _.Hours
                                    let v2198 : int32 = v2197 v2194
                                    let v2201 : (System.TimeSpan -> int32) = _.Minutes
                                    let v2202 : int32 = v2201 v2194
                                    let v2205 : (System.TimeSpan -> int32) = _.Seconds
                                    let v2206 : int32 = v2205 v2194
                                    let v2209 : (System.TimeSpan -> int32) = _.Milliseconds
                                    let v2210 : int32 = v2209 v2194
                                    let v2213 : System.DateTime = System.DateTime (1, 1, 1, v2198, v2202, v2206, v2210)
                                    v2213
                            let v2221 : string = method6()
                            let v2224 : (string -> string) = v2220.ToString
                            let v2225 : string = v2224 v2221
                            let _v1875 = v2225 
                            #endif
                            let v2228 : string = _v1875 
                            let v2293 : string = "Verbose"
                            let v2294 : (unit -> string) = v2293.ToLower
                            let v2295 : string = v2294 ()
                            let v2298 : string = v2295.PadLeft (7, ' ')
                            let v2312 : unit = ()
                            
#if FABLE_COMPILER || WASM || CONTRACT
                            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                            let v2313 : string = "inline_colorization::color_bright_black"
                            let v2314 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v2313 
                            let v2315 : string = "&*$0"
                            let v2316 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v2298 v2315 
                            let v2317 : string = "inline_colorization::color_reset"
                            let v2318 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v2317 
                            let v2319 : string = "\"{v2314}{v2316}{v2318}\""
                            let v2320 : string = @$"format!(" + v2319 + ")"
                            let v2321 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v2320 
                            let v2322 : string = "fable_library_rust::String_::fromString($0)"
                            let v2323 : string = Fable.Core.RustInterop.emitRustExpr v2321 v2322 
                            let _v2312 = v2323 
                            #endif
#if FABLE_COMPILER_RUST && WASM
                            let v2324 : string = "inline_colorization::color_bright_black"
                            let v2325 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v2324 
                            let v2326 : string = "&*$0"
                            let v2327 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v2298 v2326 
                            let v2328 : string = "inline_colorization::color_reset"
                            let v2329 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v2328 
                            let v2330 : string = "\"{v2325}{v2327}{v2329}\""
                            let v2331 : string = @$"format!(" + v2330 + ")"
                            let v2332 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v2331 
                            let v2333 : string = "fable_library_rust::String_::fromString($0)"
                            let v2334 : string = Fable.Core.RustInterop.emitRustExpr v2332 v2333 
                            let _v2312 = v2334 
                            #endif
#if FABLE_COMPILER_RUST && CONTRACT
                            let v2335 : string = "inline_colorization::color_bright_black"
                            let v2336 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v2335 
                            let v2337 : string = "&*$0"
                            let v2338 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v2298 v2337 
                            let v2339 : string = "inline_colorization::color_reset"
                            let v2340 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v2339 
                            let v2341 : string = "\"{v2336}{v2338}{v2340}\""
                            let v2342 : string = @$"format!(" + v2341 + ")"
                            let v2343 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v2342 
                            let v2344 : string = "fable_library_rust::String_::fromString($0)"
                            let v2345 : string = Fable.Core.RustInterop.emitRustExpr v2343 v2344 
                            let _v2312 = v2345 
                            #endif
#if FABLE_COMPILER_TYPESCRIPT
                            let v2346 : string = "\u001b[90m"
                            let v2347 : string = method7()
                            let v2348 : string = v2346 + v2298 
                            let v2349 : string = v2348 + v2347 
                            let _v2312 = v2349 
                            #endif
#if FABLE_COMPILER_PYTHON
                            let v2350 : string = "\u001b[90m"
                            let v2351 : string = method7()
                            let v2352 : string = v2350 + v2298 
                            let v2353 : string = v2352 + v2351 
                            let _v2312 = v2353 
                            #endif
#else
                            let v2354 : string = "\u001b[90m"
                            let v2355 : string = method7()
                            let v2356 : string = v2354 + v2298 
                            let v2357 : string = v2356 + v2355 
                            let _v2312 = v2357 
                            #endif
                            let v2358 : string = _v2312 
                            let v2364 : int64 = v1860.l0
                            let v2365 : string = method8()
                            let v2366 : Mut4 = {l0 = v2365} : Mut4
                            let v2367 : string = "{ "
                            let v2368 : string = $"{v2367}"
                            let v2371 : string = v2366.l0
                            let v2372 : string = v2371 + v2368 
                            v2366.l0 <- v2372
                            let v2373 : string = "timeout"
                            let v2374 : string = $"{v2373}"
                            let v2377 : string = v2366.l0
                            let v2378 : string = v2377 + v2374 
                            v2366.l0 <- v2378
                            let v2379 : string = " = "
                            let v2380 : string = $"{v2379}"
                            let v2383 : string = v2366.l0
                            let v2384 : string = v2383 + v2380 
                            v2366.l0 <- v2384
                            let v2385 : string = $"{v812}"
                            let v2388 : string = v2366.l0
                            let v2389 : string = v2388 + v2385 
                            v2366.l0 <- v2389
                            let v2390 : string = " }"
                            let v2391 : string = $"{v2390}"
                            let v2394 : string = v2366.l0
                            let v2395 : string = v2394 + v2391 
                            v2366.l0 <- v2395
                            let v2396 : string = v2366.l0
                            let v2397 : (unit -> string) = closure9()
                            let v2398 : string = $"{v2228} {v2358} #{v2364} %s{v2397 ()} / {v2396}"
                            let v2401 : char list = []
                            let v2402 : (char list -> (char [])) = List.toArray
                            let v2403 : (char []) = v2402 v2401
                            let v2406 : string = v2398.TrimStart v2403 
                            let v2424 : char list = []
                            let v2425 : char list = '/' :: v2424 
                            let v2428 : char list = ' ' :: v2425 
                            let v2431 : (char list -> (char [])) = List.toArray
                            let v2432 : (char []) = v2431 v2428
                            let v2435 : string = v2406.TrimEnd v2432 
                            let v2453 : unit = ()
                            
#if FABLE_COMPILER || WASM || CONTRACT
                            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                            let v2454 : string = @"println!(""{}"", $0)"
                            Fable.Core.RustInterop.emitRustExpr v2435 v2454 
                            let _v2453 = () 
                            #endif
#if FABLE_COMPILER_RUST && WASM
                            let v2455 : string = @"println!(""{}"", $0)"
                            Fable.Core.RustInterop.emitRustExpr v2435 v2455 
                            let _v2453 = () 
                            #endif
#if FABLE_COMPILER_RUST && CONTRACT
                            let v2456 : string = $"near_sdk::log!(\"{{}}\", $0)"
                            Fable.Core.RustInterop.emitRustExpr v2435 v2456 
                            let _v2453 = () 
                            #endif
#if FABLE_COMPILER_TYPESCRIPT
                            System.Console.WriteLine v2435 
                            let _v2453 = () 
                            #endif
#if FABLE_COMPILER_PYTHON
                            System.Console.WriteLine v2435 
                            let _v2453 = () 
                            #endif
#else
                            System.Console.WriteLine v2435 
                            let _v2453 = () 
                            #endif
                            _v2453 
                            let v2457 : (string -> unit) = v1799.l0
                            v2457 v2435
                        US4_1
                    else
                        let v2459 : bool = State.trace_state.IsNone
                        if v2459 then
                            let v2460 : US0 = US0_0
                            let struct (v2461 : Mut0, v2462 : Mut1, v2463 : Mut2, v2464 : Mut3, v2465 : int64 option) = method0(v2460)
                            let v2466 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v2461, v2462, v2463, v2464, v2465) 
                            State.trace_state <- v2466 
                            ()
                        let struct (v2471 : Mut0, v2472 : Mut1, v2473 : Mut2, v2474 : Mut3, v2475 : int64 option) = State.trace_state.Value
                        let v2486 : bool = State.trace_state.IsNone
                        if v2486 then
                            let v2487 : US0 = US0_0
                            let struct (v2488 : Mut0, v2489 : Mut1, v2490 : Mut2, v2491 : Mut3, v2492 : int64 option) = method0(v2487)
                            let v2493 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v2488, v2489, v2490, v2491, v2492) 
                            State.trace_state <- v2493 
                            ()
                        let struct (v2498 : Mut0, v2499 : Mut1, v2500 : Mut2, v2501 : Mut3, v2502 : int64 option) = State.trace_state.Value
                        let v2513 : US0 = v2501.l0
                        let v2514 : bool = v2500.l0
                        let v2515 : bool = v2514 = false
                        let v2518 : bool =
                            if v2515 then
                                false
                            else
                                let v2516 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v2513
                                let v2517 : bool = 4 >= v2516
                                v2517
                        if v2518 then
                            let v2519 : int64 = v2471.l0
                            let v2520 : int64 = v2519 + 1L
                            v2471.l0 <- v2520
                            let v2521 : bool = State.trace_state.IsNone
                            if v2521 then
                                let v2522 : US0 = US0_0
                                let struct (v2523 : Mut0, v2524 : Mut1, v2525 : Mut2, v2526 : Mut3, v2527 : int64 option) = method0(v2522)
                                let v2528 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v2523, v2524, v2525, v2526, v2527) 
                                State.trace_state <- v2528 
                                ()
                            let struct (v2533 : Mut0, v2534 : Mut1, v2535 : Mut2, v2536 : Mut3, v2537 : int64 option) = State.trace_state.Value
                            let v2548 : unit = ()
                            
#if FABLE_COMPILER || WASM || CONTRACT
                            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                            let v2549 : US3 option = None
                            let _v2549 = ref v2549 
                            match v2537 with
                            | Some x -> (
                            (fun () ->
                            (fun () ->
                            let v2550 : int64 = x
                            let v2551 : US3 = US3_0(v2550)
                            v2551 
                            )
                            |> fun x -> x () |> Some
                            ) () ) | None -> None
                            |> fun x -> _v2549.Value <- x
                            let v2552 : US3 option = _v2549.Value 
                            let v2563 : US3 = US3_1
                            let v2564 : US3 = v2552 |> Option.defaultValue v2563 
                            let v2604 : System.DateTime =
                                match v2564 with
                                | US3_1 -> (* None *)
                                    let v2600 : System.DateTime = System.DateTime.Now
                                    v2600
                                | US3_0(v2568) -> (* Some *)
                                    let v2569 : System.DateTime = System.DateTime.Now
                                    let v2572 : (System.DateTime -> int64) = _.Ticks
                                    let v2573 : int64 = v2572 v2569
                                    let v2576 : int64 = v2573 - v2568
                                    let v2577 : (int64 -> System.TimeSpan) = System.TimeSpan 
                                    let v2578 : System.TimeSpan = v2577 v2576
                                    let v2581 : (System.TimeSpan -> int32) = _.Hours
                                    let v2582 : int32 = v2581 v2578
                                    let v2585 : (System.TimeSpan -> int32) = _.Minutes
                                    let v2586 : int32 = v2585 v2578
                                    let v2589 : (System.TimeSpan -> int32) = _.Seconds
                                    let v2590 : int32 = v2589 v2578
                                    let v2593 : (System.TimeSpan -> int32) = _.Milliseconds
                                    let v2594 : int32 = v2593 v2578
                                    let v2597 : System.DateTime = System.DateTime (1, 1, 1, v2582, v2586, v2590, v2594)
                                    v2597
                            let v2605 : string = method5()
                            let v2608 : (string -> string) = v2604.ToString
                            let v2609 : string = v2608 v2605
                            let _v2548 = v2609 
                            #endif
#if FABLE_COMPILER_RUST && WASM
                            let v2612 : US3 option = None
                            let _v2612 = ref v2612 
                            match v2537 with
                            | Some x -> (
                            (fun () ->
                            (fun () ->
                            let v2613 : int64 = x
                            let v2614 : US3 = US3_0(v2613)
                            v2614 
                            )
                            |> fun x -> x () |> Some
                            ) () ) | None -> None
                            |> fun x -> _v2612.Value <- x
                            let v2615 : US3 option = _v2612.Value 
                            let v2626 : US3 = US3_1
                            let v2627 : US3 = v2615 |> Option.defaultValue v2626 
                            let v2667 : System.DateTime =
                                match v2627 with
                                | US3_1 -> (* None *)
                                    let v2663 : System.DateTime = System.DateTime.Now
                                    v2663
                                | US3_0(v2631) -> (* Some *)
                                    let v2632 : System.DateTime = System.DateTime.Now
                                    let v2635 : (System.DateTime -> int64) = _.Ticks
                                    let v2636 : int64 = v2635 v2632
                                    let v2639 : int64 = v2636 - v2631
                                    let v2640 : (int64 -> System.TimeSpan) = System.TimeSpan 
                                    let v2641 : System.TimeSpan = v2640 v2639
                                    let v2644 : (System.TimeSpan -> int32) = _.Hours
                                    let v2645 : int32 = v2644 v2641
                                    let v2648 : (System.TimeSpan -> int32) = _.Minutes
                                    let v2649 : int32 = v2648 v2641
                                    let v2652 : (System.TimeSpan -> int32) = _.Seconds
                                    let v2653 : int32 = v2652 v2641
                                    let v2656 : (System.TimeSpan -> int32) = _.Milliseconds
                                    let v2657 : int32 = v2656 v2641
                                    let v2660 : System.DateTime = System.DateTime (1, 1, 1, v2645, v2649, v2653, v2657)
                                    v2660
                            let v2668 : string = method5()
                            let v2671 : (string -> string) = v2667.ToString
                            let v2672 : string = v2671 v2668
                            let _v2548 = v2672 
                            #endif
#if FABLE_COMPILER_RUST && CONTRACT
                            let v2675 : string = $"near_sdk::env::block_timestamp()"
                            let v2676 : uint64 = Fable.Core.RustInterop.emitRustExpr () v2675 
                            let v2677 : US3 option = None
                            let _v2677 = ref v2677 
                            match v2537 with
                            | Some x -> (
                            (fun () ->
                            (fun () ->
                            let v2678 : int64 = x
                            let v2679 : US3 = US3_0(v2678)
                            v2679 
                            )
                            |> fun x -> x () |> Some
                            ) () ) | None -> None
                            |> fun x -> _v2677.Value <- x
                            let v2680 : US3 option = _v2677.Value 
                            let v2691 : US3 = US3_1
                            let v2692 : US3 = v2680 |> Option.defaultValue v2691 
                            let v2701 : uint64 =
                                match v2692 with
                                | US3_1 -> (* None *)
                                    v2676
                                | US3_0(v2696) -> (* Some *)
                                    let v2697 : (int64 -> uint64) = uint64
                                    let v2698 : uint64 = v2697 v2696
                                    let v2699 : uint64 = v2676 - v2698
                                    v2699
                            let v2702 : uint64 = v2701 / 1000000000UL
                            let v2703 : uint64 = v2702 % 60UL
                            let v2704 : uint64 = v2702 / 60UL
                            let v2705 : uint64 = v2704 % 60UL
                            let v2706 : uint64 = v2702 / 3600UL
                            let v2707 : uint64 = v2706 % 24UL
                            let v2708 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
                            let v2709 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v2707, v2705, v2703) v2708 
                            let v2710 : string = "fable_library_rust::String_::fromString($0)"
                            let v2711 : string = Fable.Core.RustInterop.emitRustExpr v2709 v2710 
                            let _v2548 = v2711 
                            #endif
#if FABLE_COMPILER_TYPESCRIPT
                            let v2712 : US3 option = None
                            let _v2712 = ref v2712 
                            match v2537 with
                            | Some x -> (
                            (fun () ->
                            (fun () ->
                            let v2713 : int64 = x
                            let v2714 : US3 = US3_0(v2713)
                            v2714 
                            )
                            |> fun x -> x () |> Some
                            ) () ) | None -> None
                            |> fun x -> _v2712.Value <- x
                            let v2715 : US3 option = _v2712.Value 
                            let v2726 : US3 = US3_1
                            let v2727 : US3 = v2715 |> Option.defaultValue v2726 
                            let v2767 : System.DateTime =
                                match v2727 with
                                | US3_1 -> (* None *)
                                    let v2763 : System.DateTime = System.DateTime.Now
                                    v2763
                                | US3_0(v2731) -> (* Some *)
                                    let v2732 : System.DateTime = System.DateTime.Now
                                    let v2735 : (System.DateTime -> int64) = _.Ticks
                                    let v2736 : int64 = v2735 v2732
                                    let v2739 : int64 = v2736 - v2731
                                    let v2740 : (int64 -> System.TimeSpan) = System.TimeSpan 
                                    let v2741 : System.TimeSpan = v2740 v2739
                                    let v2744 : (System.TimeSpan -> int32) = _.Hours
                                    let v2745 : int32 = v2744 v2741
                                    let v2748 : (System.TimeSpan -> int32) = _.Minutes
                                    let v2749 : int32 = v2748 v2741
                                    let v2752 : (System.TimeSpan -> int32) = _.Seconds
                                    let v2753 : int32 = v2752 v2741
                                    let v2756 : (System.TimeSpan -> int32) = _.Milliseconds
                                    let v2757 : int32 = v2756 v2741
                                    let v2760 : System.DateTime = System.DateTime (1, 1, 1, v2745, v2749, v2753, v2757)
                                    v2760
                            let v2768 : string = method6()
                            let v2771 : (string -> string) = v2767.ToString
                            let v2772 : string = v2771 v2768
                            let _v2548 = v2772 
                            #endif
#if FABLE_COMPILER_PYTHON
                            let v2775 : US3 option = None
                            let _v2775 = ref v2775 
                            match v2537 with
                            | Some x -> (
                            (fun () ->
                            (fun () ->
                            let v2776 : int64 = x
                            let v2777 : US3 = US3_0(v2776)
                            v2777 
                            )
                            |> fun x -> x () |> Some
                            ) () ) | None -> None
                            |> fun x -> _v2775.Value <- x
                            let v2778 : US3 option = _v2775.Value 
                            let v2789 : US3 = US3_1
                            let v2790 : US3 = v2778 |> Option.defaultValue v2789 
                            let v2830 : System.DateTime =
                                match v2790 with
                                | US3_1 -> (* None *)
                                    let v2826 : System.DateTime = System.DateTime.Now
                                    v2826
                                | US3_0(v2794) -> (* Some *)
                                    let v2795 : System.DateTime = System.DateTime.Now
                                    let v2798 : (System.DateTime -> int64) = _.Ticks
                                    let v2799 : int64 = v2798 v2795
                                    let v2802 : int64 = v2799 - v2794
                                    let v2803 : (int64 -> System.TimeSpan) = System.TimeSpan 
                                    let v2804 : System.TimeSpan = v2803 v2802
                                    let v2807 : (System.TimeSpan -> int32) = _.Hours
                                    let v2808 : int32 = v2807 v2804
                                    let v2811 : (System.TimeSpan -> int32) = _.Minutes
                                    let v2812 : int32 = v2811 v2804
                                    let v2815 : (System.TimeSpan -> int32) = _.Seconds
                                    let v2816 : int32 = v2815 v2804
                                    let v2819 : (System.TimeSpan -> int32) = _.Milliseconds
                                    let v2820 : int32 = v2819 v2804
                                    let v2823 : System.DateTime = System.DateTime (1, 1, 1, v2808, v2812, v2816, v2820)
                                    v2823
                            let v2831 : string = method6()
                            let v2834 : (string -> string) = v2830.ToString
                            let v2835 : string = v2834 v2831
                            let _v2548 = v2835 
                            #endif
#else
                            let v2838 : US3 option = None
                            let _v2838 = ref v2838 
                            match v2537 with
                            | Some x -> (
                            (fun () ->
                            (fun () ->
                            let v2839 : int64 = x
                            let v2840 : US3 = US3_0(v2839)
                            v2840 
                            )
                            |> fun x -> x () |> Some
                            ) () ) | None -> None
                            |> fun x -> _v2838.Value <- x
                            let v2841 : US3 option = _v2838.Value 
                            let v2852 : US3 = US3_1
                            let v2853 : US3 = v2841 |> Option.defaultValue v2852 
                            let v2893 : System.DateTime =
                                match v2853 with
                                | US3_1 -> (* None *)
                                    let v2889 : System.DateTime = System.DateTime.Now
                                    v2889
                                | US3_0(v2857) -> (* Some *)
                                    let v2858 : System.DateTime = System.DateTime.Now
                                    let v2861 : (System.DateTime -> int64) = _.Ticks
                                    let v2862 : int64 = v2861 v2858
                                    let v2865 : int64 = v2862 - v2857
                                    let v2866 : (int64 -> System.TimeSpan) = System.TimeSpan 
                                    let v2867 : System.TimeSpan = v2866 v2865
                                    let v2870 : (System.TimeSpan -> int32) = _.Hours
                                    let v2871 : int32 = v2870 v2867
                                    let v2874 : (System.TimeSpan -> int32) = _.Minutes
                                    let v2875 : int32 = v2874 v2867
                                    let v2878 : (System.TimeSpan -> int32) = _.Seconds
                                    let v2879 : int32 = v2878 v2867
                                    let v2882 : (System.TimeSpan -> int32) = _.Milliseconds
                                    let v2883 : int32 = v2882 v2867
                                    let v2886 : System.DateTime = System.DateTime (1, 1, 1, v2871, v2875, v2879, v2883)
                                    v2886
                            let v2894 : string = method6()
                            let v2897 : (string -> string) = v2893.ToString
                            let v2898 : string = v2897 v2894
                            let _v2548 = v2898 
                            #endif
                            let v2901 : string = _v2548 
                            let v2966 : string = "Critical"
                            let v2967 : (unit -> string) = v2966.ToLower
                            let v2968 : string = v2967 ()
                            let v2971 : string = v2968.PadLeft (7, ' ')
                            let v2985 : unit = ()
                            
#if FABLE_COMPILER || WASM || CONTRACT
                            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                            let v2986 : string = "inline_colorization::color_bright_red"
                            let v2987 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v2986 
                            let v2988 : string = "&*$0"
                            let v2989 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v2971 v2988 
                            let v2990 : string = "inline_colorization::color_reset"
                            let v2991 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v2990 
                            let v2992 : string = "\"{v2987}{v2989}{v2991}\""
                            let v2993 : string = @$"format!(" + v2992 + ")"
                            let v2994 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v2993 
                            let v2995 : string = "fable_library_rust::String_::fromString($0)"
                            let v2996 : string = Fable.Core.RustInterop.emitRustExpr v2994 v2995 
                            let _v2985 = v2996 
                            #endif
#if FABLE_COMPILER_RUST && WASM
                            let v2997 : string = "inline_colorization::color_bright_red"
                            let v2998 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v2997 
                            let v2999 : string = "&*$0"
                            let v3000 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v2971 v2999 
                            let v3001 : string = "inline_colorization::color_reset"
                            let v3002 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v3001 
                            let v3003 : string = "\"{v2998}{v3000}{v3002}\""
                            let v3004 : string = @$"format!(" + v3003 + ")"
                            let v3005 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v3004 
                            let v3006 : string = "fable_library_rust::String_::fromString($0)"
                            let v3007 : string = Fable.Core.RustInterop.emitRustExpr v3005 v3006 
                            let _v2985 = v3007 
                            #endif
#if FABLE_COMPILER_RUST && CONTRACT
                            let v3008 : string = "inline_colorization::color_bright_red"
                            let v3009 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v3008 
                            let v3010 : string = "&*$0"
                            let v3011 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v2971 v3010 
                            let v3012 : string = "inline_colorization::color_reset"
                            let v3013 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v3012 
                            let v3014 : string = "\"{v3009}{v3011}{v3013}\""
                            let v3015 : string = @$"format!(" + v3014 + ")"
                            let v3016 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v3015 
                            let v3017 : string = "fable_library_rust::String_::fromString($0)"
                            let v3018 : string = Fable.Core.RustInterop.emitRustExpr v3016 v3017 
                            let _v2985 = v3018 
                            #endif
#if FABLE_COMPILER_TYPESCRIPT
                            let v3019 : string = "\u001b[91m"
                            let v3020 : string = method7()
                            let v3021 : string = v3019 + v2971 
                            let v3022 : string = v3021 + v3020 
                            let _v2985 = v3022 
                            #endif
#if FABLE_COMPILER_PYTHON
                            let v3023 : string = "\u001b[91m"
                            let v3024 : string = method7()
                            let v3025 : string = v3023 + v2971 
                            let v3026 : string = v3025 + v3024 
                            let _v2985 = v3026 
                            #endif
#else
                            let v3027 : string = "\u001b[91m"
                            let v3028 : string = method7()
                            let v3029 : string = v3027 + v2971 
                            let v3030 : string = v3029 + v3028 
                            let _v2985 = v3030 
                            #endif
                            let v3031 : string = _v2985 
                            let v3037 : int64 = v2533.l0
                            let v3038 : unit = ()
                            
#if FABLE_COMPILER || WASM || CONTRACT
                            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                            let v3039 : string = $"%A{v1778}"
                            let _v3038 = v3039 
                            #endif
#if FABLE_COMPILER_RUST && WASM
                            let v3042 : string = $"%A{v1778}"
                            let _v3038 = v3042 
                            #endif
#if FABLE_COMPILER_RUST && CONTRACT
                            let v3045 : string = $"%A{v1778}"
                            let _v3038 = v3045 
                            #endif
#if FABLE_COMPILER_TYPESCRIPT
                            let v3048 : string = $"%A{v1778}"
                            let _v3038 = v3048 
                            #endif
#if FABLE_COMPILER_PYTHON
                            let v3051 : string = $"%A{v1778}"
                            let _v3038 = v3051 
                            #endif
#else
                            let v3054 : string = $"{v1778.GetType ()}: {v1778.Message}"
                            let _v3038 = v3054 
                            #endif
                            let v3055 : string = _v3038 
                            let v3060 : string = method8()
                            let v3061 : Mut4 = {l0 = v3060} : Mut4
                            let v3062 : string = "{ "
                            let v3063 : string = $"{v3062}"
                            let v3066 : string = v3061.l0
                            let v3067 : string = v3066 + v3063 
                            v3061.l0 <- v3067
                            let v3068 : string = "timeout"
                            let v3069 : string = $"{v3068}"
                            let v3072 : string = v3061.l0
                            let v3073 : string = v3072 + v3069 
                            v3061.l0 <- v3073
                            let v3074 : string = " = "
                            let v3075 : string = $"{v3074}"
                            let v3078 : string = v3061.l0
                            let v3079 : string = v3078 + v3075 
                            v3061.l0 <- v3079
                            let v3080 : string = $"{v812}"
                            let v3083 : string = v3061.l0
                            let v3084 : string = v3083 + v3080 
                            v3061.l0 <- v3084
                            let v3085 : string = "; "
                            let v3086 : string = $"{v3085}"
                            let v3089 : string = v3061.l0
                            let v3090 : string = v3089 + v3086 
                            v3061.l0 <- v3090
                            let v3091 : string = "ex"
                            let v3092 : string = $"{v3091}"
                            let v3095 : string = v3061.l0
                            let v3096 : string = v3095 + v3092 
                            v3061.l0 <- v3096
                            let v3097 : string = $"{v3074}"
                            let v3100 : string = v3061.l0
                            let v3101 : string = v3100 + v3097 
                            v3061.l0 <- v3101
                            let v3102 : string = $"{v3055}"
                            let v3105 : string = v3061.l0
                            let v3106 : string = v3105 + v3102 
                            v3061.l0 <- v3106
                            let v3107 : string = " }"
                            let v3108 : string = $"{v3107}"
                            let v3111 : string = v3061.l0
                            let v3112 : string = v3111 + v3108 
                            v3061.l0 <- v3112
                            let v3113 : string = v3061.l0
                            let v3114 : (unit -> string) = closure10()
                            let v3115 : string = $"{v2901} {v3031} #{v3037} %s{v3114 ()} / {v3113}"
                            let v3118 : char list = []
                            let v3119 : (char list -> (char [])) = List.toArray
                            let v3120 : (char []) = v3119 v3118
                            let v3123 : string = v3115.TrimStart v3120 
                            let v3141 : char list = []
                            let v3142 : char list = '/' :: v3141 
                            let v3145 : char list = ' ' :: v3142 
                            let v3148 : (char list -> (char [])) = List.toArray
                            let v3149 : (char []) = v3148 v3145
                            let v3152 : string = v3123.TrimEnd v3149 
                            let v3170 : unit = ()
                            
#if FABLE_COMPILER || WASM || CONTRACT
                            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                            let v3171 : string = @"println!(""{}"", $0)"
                            Fable.Core.RustInterop.emitRustExpr v3152 v3171 
                            let _v3170 = () 
                            #endif
#if FABLE_COMPILER_RUST && WASM
                            let v3172 : string = @"println!(""{}"", $0)"
                            Fable.Core.RustInterop.emitRustExpr v3152 v3172 
                            let _v3170 = () 
                            #endif
#if FABLE_COMPILER_RUST && CONTRACT
                            let v3173 : string = $"near_sdk::log!(\"{{}}\", $0)"
                            Fable.Core.RustInterop.emitRustExpr v3152 v3173 
                            let _v3170 = () 
                            #endif
#if FABLE_COMPILER_TYPESCRIPT
                            System.Console.WriteLine v3152 
                            let _v3170 = () 
                            #endif
#if FABLE_COMPILER_PYTHON
                            System.Console.WriteLine v3152 
                            let _v3170 = () 
                            #endif
#else
                            System.Console.WriteLine v3152 
                            let _v3170 = () 
                            #endif
                            _v3170 
                            let v3174 : (string -> unit) = v2472.l0
                            v3174 v3152
                        US4_1
                | US6_0(v1776) -> (* Ok *)
                    US4_0(v1776)
            return v3178 
            }
            |> fun x -> _v1774 <- Some x
            let v3179 : Async<US4> = match _v1774 with Some x -> x | None -> failwith "async.new_async_unit / _v1774=None"
            let _v1758 = v3179 
            #endif
            let v3180 : Async<US4> = _v1758 
            return! v3180 
            }
            |> fun x -> _v1633 <- Some x
            let v3185 : Async<US4> = match _v1633 with Some x -> x | None -> failwith "async.new_async_unit / _v1633=None"
            let _v1617 = v3185 
            #endif
            let v3186 : Async<US4> = _v1617 
            let _v1601 = v3186 
            #endif
            let v3191 : Async<US4> = _v1601 
            let! v3191 = v3191 
            let v3196 : US4 = v3191 
            let v3199 : bool =
                match v3196 with
                | US4_1 -> (* None *)
                    false
                | US4_0(v3197) -> (* Some *)
                    v3197
            return v3199 
            }
            |> fun x -> _v829 <- Some x
            let v3200 : Async<bool> = match _v829 with Some x -> x | None -> failwith "async.new_async_unit / _v829=None"
            let _v813 = v3200 
            #endif
            let v3201 : Async<bool> = _v813 
            v3201
    let! v3207 = v3207 
    let v3208 : bool = v3207 
    let v3209 : bool = v3208 = v1
    if v3209 then
        return v4 
        (*
        ()
    else
        *) else
        let v3210 : int64 = v4 % 100L
        let v3211 : bool = v3210 = 0L
        if v3211 then
            let v3212 : bool = State.trace_state.IsNone
            if v3212 then
                let v3213 : US0 = US0_0
                let struct (v3214 : Mut0, v3215 : Mut1, v3216 : Mut2, v3217 : Mut3, v3218 : int64 option) = method0(v3213)
                let v3219 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v3214, v3215, v3216, v3217, v3218) 
                State.trace_state <- v3219 
                ()
            let struct (v3224 : Mut0, v3225 : Mut1, v3226 : Mut2, v3227 : Mut3, v3228 : int64 option) = State.trace_state.Value
            let v3239 : bool = State.trace_state.IsNone
            if v3239 then
                let v3240 : US0 = US0_0
                let struct (v3241 : Mut0, v3242 : Mut1, v3243 : Mut2, v3244 : Mut3, v3245 : int64 option) = method0(v3240)
                let v3246 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v3241, v3242, v3243, v3244, v3245) 
                State.trace_state <- v3246 
                ()
            let struct (v3251 : Mut0, v3252 : Mut1, v3253 : Mut2, v3254 : Mut3, v3255 : int64 option) = State.trace_state.Value
            let v3266 : US0 = v3254.l0
            let v3267 : bool = v3253.l0
            let v3268 : bool = v3267 = false
            let v3271 : bool =
                if v3268 then
                    false
                else
                    let v3269 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v3266
                    let v3270 : bool = 0 >= v3269
                    v3270
            if v3271 then
                let v3272 : int64 = v3224.l0
                let v3273 : int64 = v3272 + 1L
                v3224.l0 <- v3273
                let v3274 : bool = State.trace_state.IsNone
                if v3274 then
                    let v3275 : US0 = US0_0
                    let struct (v3276 : Mut0, v3277 : Mut1, v3278 : Mut2, v3279 : Mut3, v3280 : int64 option) = method0(v3275)
                    let v3281 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v3276, v3277, v3278, v3279, v3280) 
                    State.trace_state <- v3281 
                    ()
                let struct (v3286 : Mut0, v3287 : Mut1, v3288 : Mut2, v3289 : Mut3, v3290 : int64 option) = State.trace_state.Value
                let v3301 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v3302 : US3 option = None
                let _v3302 = ref v3302 
                match v3290 with
                | Some x -> (
                (fun () ->
                (fun () ->
                let v3303 : int64 = x
                let v3304 : US3 = US3_0(v3303)
                v3304 
                )
                |> fun x -> x () |> Some
                ) () ) | None -> None
                |> fun x -> _v3302.Value <- x
                let v3305 : US3 option = _v3302.Value 
                let v3316 : US3 = US3_1
                let v3317 : US3 = v3305 |> Option.defaultValue v3316 
                let v3357 : System.DateTime =
                    match v3317 with
                    | US3_1 -> (* None *)
                        let v3353 : System.DateTime = System.DateTime.Now
                        v3353
                    | US3_0(v3321) -> (* Some *)
                        let v3322 : System.DateTime = System.DateTime.Now
                        let v3325 : (System.DateTime -> int64) = _.Ticks
                        let v3326 : int64 = v3325 v3322
                        let v3329 : int64 = v3326 - v3321
                        let v3330 : (int64 -> System.TimeSpan) = System.TimeSpan 
                        let v3331 : System.TimeSpan = v3330 v3329
                        let v3334 : (System.TimeSpan -> int32) = _.Hours
                        let v3335 : int32 = v3334 v3331
                        let v3338 : (System.TimeSpan -> int32) = _.Minutes
                        let v3339 : int32 = v3338 v3331
                        let v3342 : (System.TimeSpan -> int32) = _.Seconds
                        let v3343 : int32 = v3342 v3331
                        let v3346 : (System.TimeSpan -> int32) = _.Milliseconds
                        let v3347 : int32 = v3346 v3331
                        let v3350 : System.DateTime = System.DateTime (1, 1, 1, v3335, v3339, v3343, v3347)
                        v3350
                let v3358 : string = method5()
                let v3361 : (string -> string) = v3357.ToString
                let v3362 : string = v3361 v3358
                let _v3301 = v3362 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v3365 : US3 option = None
                let _v3365 = ref v3365 
                match v3290 with
                | Some x -> (
                (fun () ->
                (fun () ->
                let v3366 : int64 = x
                let v3367 : US3 = US3_0(v3366)
                v3367 
                )
                |> fun x -> x () |> Some
                ) () ) | None -> None
                |> fun x -> _v3365.Value <- x
                let v3368 : US3 option = _v3365.Value 
                let v3379 : US3 = US3_1
                let v3380 : US3 = v3368 |> Option.defaultValue v3379 
                let v3420 : System.DateTime =
                    match v3380 with
                    | US3_1 -> (* None *)
                        let v3416 : System.DateTime = System.DateTime.Now
                        v3416
                    | US3_0(v3384) -> (* Some *)
                        let v3385 : System.DateTime = System.DateTime.Now
                        let v3388 : (System.DateTime -> int64) = _.Ticks
                        let v3389 : int64 = v3388 v3385
                        let v3392 : int64 = v3389 - v3384
                        let v3393 : (int64 -> System.TimeSpan) = System.TimeSpan 
                        let v3394 : System.TimeSpan = v3393 v3392
                        let v3397 : (System.TimeSpan -> int32) = _.Hours
                        let v3398 : int32 = v3397 v3394
                        let v3401 : (System.TimeSpan -> int32) = _.Minutes
                        let v3402 : int32 = v3401 v3394
                        let v3405 : (System.TimeSpan -> int32) = _.Seconds
                        let v3406 : int32 = v3405 v3394
                        let v3409 : (System.TimeSpan -> int32) = _.Milliseconds
                        let v3410 : int32 = v3409 v3394
                        let v3413 : System.DateTime = System.DateTime (1, 1, 1, v3398, v3402, v3406, v3410)
                        v3413
                let v3421 : string = method5()
                let v3424 : (string -> string) = v3420.ToString
                let v3425 : string = v3424 v3421
                let _v3301 = v3425 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v3428 : string = $"near_sdk::env::block_timestamp()"
                let v3429 : uint64 = Fable.Core.RustInterop.emitRustExpr () v3428 
                let v3430 : US3 option = None
                let _v3430 = ref v3430 
                match v3290 with
                | Some x -> (
                (fun () ->
                (fun () ->
                let v3431 : int64 = x
                let v3432 : US3 = US3_0(v3431)
                v3432 
                )
                |> fun x -> x () |> Some
                ) () ) | None -> None
                |> fun x -> _v3430.Value <- x
                let v3433 : US3 option = _v3430.Value 
                let v3444 : US3 = US3_1
                let v3445 : US3 = v3433 |> Option.defaultValue v3444 
                let v3454 : uint64 =
                    match v3445 with
                    | US3_1 -> (* None *)
                        v3429
                    | US3_0(v3449) -> (* Some *)
                        let v3450 : (int64 -> uint64) = uint64
                        let v3451 : uint64 = v3450 v3449
                        let v3452 : uint64 = v3429 - v3451
                        v3452
                let v3455 : uint64 = v3454 / 1000000000UL
                let v3456 : uint64 = v3455 % 60UL
                let v3457 : uint64 = v3455 / 60UL
                let v3458 : uint64 = v3457 % 60UL
                let v3459 : uint64 = v3455 / 3600UL
                let v3460 : uint64 = v3459 % 24UL
                let v3461 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
                let v3462 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v3460, v3458, v3456) v3461 
                let v3463 : string = "fable_library_rust::String_::fromString($0)"
                let v3464 : string = Fable.Core.RustInterop.emitRustExpr v3462 v3463 
                let _v3301 = v3464 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v3465 : US3 option = None
                let _v3465 = ref v3465 
                match v3290 with
                | Some x -> (
                (fun () ->
                (fun () ->
                let v3466 : int64 = x
                let v3467 : US3 = US3_0(v3466)
                v3467 
                )
                |> fun x -> x () |> Some
                ) () ) | None -> None
                |> fun x -> _v3465.Value <- x
                let v3468 : US3 option = _v3465.Value 
                let v3479 : US3 = US3_1
                let v3480 : US3 = v3468 |> Option.defaultValue v3479 
                let v3520 : System.DateTime =
                    match v3480 with
                    | US3_1 -> (* None *)
                        let v3516 : System.DateTime = System.DateTime.Now
                        v3516
                    | US3_0(v3484) -> (* Some *)
                        let v3485 : System.DateTime = System.DateTime.Now
                        let v3488 : (System.DateTime -> int64) = _.Ticks
                        let v3489 : int64 = v3488 v3485
                        let v3492 : int64 = v3489 - v3484
                        let v3493 : (int64 -> System.TimeSpan) = System.TimeSpan 
                        let v3494 : System.TimeSpan = v3493 v3492
                        let v3497 : (System.TimeSpan -> int32) = _.Hours
                        let v3498 : int32 = v3497 v3494
                        let v3501 : (System.TimeSpan -> int32) = _.Minutes
                        let v3502 : int32 = v3501 v3494
                        let v3505 : (System.TimeSpan -> int32) = _.Seconds
                        let v3506 : int32 = v3505 v3494
                        let v3509 : (System.TimeSpan -> int32) = _.Milliseconds
                        let v3510 : int32 = v3509 v3494
                        let v3513 : System.DateTime = System.DateTime (1, 1, 1, v3498, v3502, v3506, v3510)
                        v3513
                let v3521 : string = method6()
                let v3524 : (string -> string) = v3520.ToString
                let v3525 : string = v3524 v3521
                let _v3301 = v3525 
                #endif
#if FABLE_COMPILER_PYTHON
                let v3528 : US3 option = None
                let _v3528 = ref v3528 
                match v3290 with
                | Some x -> (
                (fun () ->
                (fun () ->
                let v3529 : int64 = x
                let v3530 : US3 = US3_0(v3529)
                v3530 
                )
                |> fun x -> x () |> Some
                ) () ) | None -> None
                |> fun x -> _v3528.Value <- x
                let v3531 : US3 option = _v3528.Value 
                let v3542 : US3 = US3_1
                let v3543 : US3 = v3531 |> Option.defaultValue v3542 
                let v3583 : System.DateTime =
                    match v3543 with
                    | US3_1 -> (* None *)
                        let v3579 : System.DateTime = System.DateTime.Now
                        v3579
                    | US3_0(v3547) -> (* Some *)
                        let v3548 : System.DateTime = System.DateTime.Now
                        let v3551 : (System.DateTime -> int64) = _.Ticks
                        let v3552 : int64 = v3551 v3548
                        let v3555 : int64 = v3552 - v3547
                        let v3556 : (int64 -> System.TimeSpan) = System.TimeSpan 
                        let v3557 : System.TimeSpan = v3556 v3555
                        let v3560 : (System.TimeSpan -> int32) = _.Hours
                        let v3561 : int32 = v3560 v3557
                        let v3564 : (System.TimeSpan -> int32) = _.Minutes
                        let v3565 : int32 = v3564 v3557
                        let v3568 : (System.TimeSpan -> int32) = _.Seconds
                        let v3569 : int32 = v3568 v3557
                        let v3572 : (System.TimeSpan -> int32) = _.Milliseconds
                        let v3573 : int32 = v3572 v3557
                        let v3576 : System.DateTime = System.DateTime (1, 1, 1, v3561, v3565, v3569, v3573)
                        v3576
                let v3584 : string = method6()
                let v3587 : (string -> string) = v3583.ToString
                let v3588 : string = v3587 v3584
                let _v3301 = v3588 
                #endif
#else
                let v3591 : US3 option = None
                let _v3591 = ref v3591 
                match v3290 with
                | Some x -> (
                (fun () ->
                (fun () ->
                let v3592 : int64 = x
                let v3593 : US3 = US3_0(v3592)
                v3593 
                )
                |> fun x -> x () |> Some
                ) () ) | None -> None
                |> fun x -> _v3591.Value <- x
                let v3594 : US3 option = _v3591.Value 
                let v3605 : US3 = US3_1
                let v3606 : US3 = v3594 |> Option.defaultValue v3605 
                let v3646 : System.DateTime =
                    match v3606 with
                    | US3_1 -> (* None *)
                        let v3642 : System.DateTime = System.DateTime.Now
                        v3642
                    | US3_0(v3610) -> (* Some *)
                        let v3611 : System.DateTime = System.DateTime.Now
                        let v3614 : (System.DateTime -> int64) = _.Ticks
                        let v3615 : int64 = v3614 v3611
                        let v3618 : int64 = v3615 - v3610
                        let v3619 : (int64 -> System.TimeSpan) = System.TimeSpan 
                        let v3620 : System.TimeSpan = v3619 v3618
                        let v3623 : (System.TimeSpan -> int32) = _.Hours
                        let v3624 : int32 = v3623 v3620
                        let v3627 : (System.TimeSpan -> int32) = _.Minutes
                        let v3628 : int32 = v3627 v3620
                        let v3631 : (System.TimeSpan -> int32) = _.Seconds
                        let v3632 : int32 = v3631 v3620
                        let v3635 : (System.TimeSpan -> int32) = _.Milliseconds
                        let v3636 : int32 = v3635 v3620
                        let v3639 : System.DateTime = System.DateTime (1, 1, 1, v3624, v3628, v3632, v3636)
                        v3639
                let v3647 : string = method6()
                let v3650 : (string -> string) = v3646.ToString
                let v3651 : string = v3650 v3647
                let _v3301 = v3651 
                #endif
                let v3654 : string = _v3301 
                let v3719 : string = "Verbose"
                let v3720 : (unit -> string) = v3719.ToLower
                let v3721 : string = v3720 ()
                let v3724 : string = v3721.PadLeft (7, ' ')
                let v3738 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v3739 : string = "inline_colorization::color_bright_black"
                let v3740 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v3739 
                let v3741 : string = "&*$0"
                let v3742 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v3724 v3741 
                let v3743 : string = "inline_colorization::color_reset"
                let v3744 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v3743 
                let v3745 : string = "\"{v3740}{v3742}{v3744}\""
                let v3746 : string = @$"format!(" + v3745 + ")"
                let v3747 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v3746 
                let v3748 : string = "fable_library_rust::String_::fromString($0)"
                let v3749 : string = Fable.Core.RustInterop.emitRustExpr v3747 v3748 
                let _v3738 = v3749 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v3750 : string = "inline_colorization::color_bright_black"
                let v3751 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v3750 
                let v3752 : string = "&*$0"
                let v3753 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v3724 v3752 
                let v3754 : string = "inline_colorization::color_reset"
                let v3755 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v3754 
                let v3756 : string = "\"{v3751}{v3753}{v3755}\""
                let v3757 : string = @$"format!(" + v3756 + ")"
                let v3758 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v3757 
                let v3759 : string = "fable_library_rust::String_::fromString($0)"
                let v3760 : string = Fable.Core.RustInterop.emitRustExpr v3758 v3759 
                let _v3738 = v3760 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v3761 : string = "inline_colorization::color_bright_black"
                let v3762 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v3761 
                let v3763 : string = "&*$0"
                let v3764 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v3724 v3763 
                let v3765 : string = "inline_colorization::color_reset"
                let v3766 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v3765 
                let v3767 : string = "\"{v3762}{v3764}{v3766}\""
                let v3768 : string = @$"format!(" + v3767 + ")"
                let v3769 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v3768 
                let v3770 : string = "fable_library_rust::String_::fromString($0)"
                let v3771 : string = Fable.Core.RustInterop.emitRustExpr v3769 v3770 
                let _v3738 = v3771 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v3772 : string = "\u001b[90m"
                let v3773 : string = method7()
                let v3774 : string = v3772 + v3724 
                let v3775 : string = v3774 + v3773 
                let _v3738 = v3775 
                #endif
#if FABLE_COMPILER_PYTHON
                let v3776 : string = "\u001b[90m"
                let v3777 : string = method7()
                let v3778 : string = v3776 + v3724 
                let v3779 : string = v3778 + v3777 
                let _v3738 = v3779 
                #endif
#else
                let v3780 : string = "\u001b[90m"
                let v3781 : string = method7()
                let v3782 : string = v3780 + v3724 
                let v3783 : string = v3782 + v3781 
                let _v3738 = v3783 
                #endif
                let v3784 : string = _v3738 
                let v3790 : int64 = v3286.l0
                let v3791 : string = method8()
                let v3792 : Mut4 = {l0 = v3791} : Mut4
                let v3793 : string = "{ "
                let v3794 : string = $"{v3793}"
                let v3797 : string = v3792.l0
                let v3798 : string = v3797 + v3794 
                v3792.l0 <- v3798
                let v3799 : string = "port"
                let v3800 : string = $"{v3799}"
                let v3803 : string = v3792.l0
                let v3804 : string = v3803 + v3800 
                v3792.l0 <- v3804
                let v3805 : string = " = "
                let v3806 : string = $"{v3805}"
                let v3809 : string = v3792.l0
                let v3810 : string = v3809 + v3806 
                v3792.l0 <- v3810
                let v3811 : string = $"{v3}"
                let v3814 : string = v3792.l0
                let v3815 : string = v3814 + v3811 
                v3792.l0 <- v3815
                let v3816 : string = "; "
                let v3817 : string = $"{v3816}"
                let v3820 : string = v3792.l0
                let v3821 : string = v3820 + v3817 
                v3792.l0 <- v3821
                let v3822 : string = "retry"
                let v3823 : string = $"{v3822}"
                let v3826 : string = v3792.l0
                let v3827 : string = v3826 + v3823 
                v3792.l0 <- v3827
                let v3828 : string = $"{v3805}"
                let v3831 : string = v3792.l0
                let v3832 : string = v3831 + v3828 
                v3792.l0 <- v3832
                let v3833 : string = $"{v4}"
                let v3836 : string = v3792.l0
                let v3837 : string = v3836 + v3833 
                v3792.l0 <- v3837
                let v3838 : string = $"{v3816}"
                let v3841 : string = v3792.l0
                let v3842 : string = v3841 + v3838 
                v3792.l0 <- v3842
                let v3843 : string = "timeout"
                let v3844 : string = $"{v3843}"
                let v3847 : string = v3792.l0
                let v3848 : string = v3847 + v3844 
                v3792.l0 <- v3848
                let v3849 : string = $"{v3805}"
                let v3852 : string = v3792.l0
                let v3853 : string = v3852 + v3849 
                v3792.l0 <- v3853
                let v3854 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v3855 : string = "format!(\"{:#?}\", $0)"
                let v3856 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v3855 
                let v3857 : string = "fable_library_rust::String_::fromString($0)"
                let v3858 : string = Fable.Core.RustInterop.emitRustExpr v3856 v3857 
                let _v3854 = v3858 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v3859 : string = "format!(\"{:#?}\", $0)"
                let v3860 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v3859 
                let v3861 : string = "fable_library_rust::String_::fromString($0)"
                let v3862 : string = Fable.Core.RustInterop.emitRustExpr v3860 v3861 
                let _v3854 = v3862 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v3863 : string = "format!(\"{:#?}\", $0)"
                let v3864 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v3863 
                let v3865 : string = "fable_library_rust::String_::fromString($0)"
                let v3866 : string = Fable.Core.RustInterop.emitRustExpr v3864 v3865 
                let _v3854 = v3866 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v3867 : string = $"%A{v0}"
                let _v3854 = v3867 
                #endif
#if FABLE_COMPILER_PYTHON
                let v3870 : string = $"%A{v0}"
                let _v3854 = v3870 
                #endif
#else
                let v3873 : string = $"%A{v0}"
                let _v3854 = v3873 
                #endif
                let v3876 : string = _v3854 
                let v3881 : string = $"{v3876}"
                let v3884 : string = v3792.l0
                let v3885 : string = v3884 + v3881 
                v3792.l0 <- v3885
                let v3886 : string = $"{v3816}"
                let v3889 : string = v3792.l0
                let v3890 : string = v3889 + v3886 
                v3792.l0 <- v3890
                let v3891 : string = "status"
                let v3892 : string = $"{v3891}"
                let v3895 : string = v3792.l0
                let v3896 : string = v3895 + v3892 
                v3792.l0 <- v3896
                let v3897 : string = $"{v3805}"
                let v3900 : string = v3792.l0
                let v3901 : string = v3900 + v3897 
                v3792.l0 <- v3901
                let v3904 : string =
                    if v1 then
                        let v3902 : string = "true"
                        v3902
                    else
                        let v3903 : string = "false"
                        v3903
                let v3905 : string = $"{v3904}"
                let v3908 : string = v3792.l0
                let v3909 : string = v3908 + v3905 
                v3792.l0 <- v3909
                let v3910 : string = " }"
                let v3911 : string = $"{v3910}"
                let v3914 : string = v3792.l0
                let v3915 : string = v3914 + v3911 
                v3792.l0 <- v3915
                let v3916 : string = v3792.l0
                let v3917 : (unit -> string) = closure15()
                let v3918 : string = $"{v3654} {v3784} #{v3790} %s{v3917 ()} / {v3916}"
                let v3921 : char list = []
                let v3922 : (char list -> (char [])) = List.toArray
                let v3923 : (char []) = v3922 v3921
                let v3926 : string = v3918.TrimStart v3923 
                let v3944 : char list = []
                let v3945 : char list = '/' :: v3944 
                let v3948 : char list = ' ' :: v3945 
                let v3951 : (char list -> (char [])) = List.toArray
                let v3952 : (char []) = v3951 v3948
                let v3955 : string = v3926.TrimEnd v3952 
                let v3973 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v3974 : string = @"println!(""{}"", $0)"
                Fable.Core.RustInterop.emitRustExpr v3955 v3974 
                let _v3973 = () 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v3975 : string = @"println!(""{}"", $0)"
                Fable.Core.RustInterop.emitRustExpr v3955 v3975 
                let _v3973 = () 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v3976 : string = $"near_sdk::log!(\"{{}}\", $0)"
                Fable.Core.RustInterop.emitRustExpr v3955 v3976 
                let _v3973 = () 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                System.Console.WriteLine v3955 
                let _v3973 = () 
                #endif
#if FABLE_COMPILER_PYTHON
                System.Console.WriteLine v3955 
                let _v3973 = () 
                #endif
#else
                System.Console.WriteLine v3955 
                let _v3973 = () 
                #endif
                _v3973 
                let v3977 : (string -> unit) = v3225.l0
                v3977 v3955
        let v3978 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v3979 : Async<unit> = null |> unbox<Async<unit>>
        let _v3978 = v3979 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v3982 : Async<unit> = null |> unbox<Async<unit>>
        let _v3978 = v3982 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v3985 : Async<unit> = null |> unbox<Async<unit>>
        let _v3978 = v3985 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v3988 : Async<unit> = null |> unbox<Async<unit>>
        let _v3978 = v3988 
        #endif
#if FABLE_COMPILER_PYTHON
        let v3991 : Async<unit> = null |> unbox<Async<unit>>
        let _v3978 = v3991 
        #endif
#else
        let v3994 : (int32 -> Async<unit>) = Async.Sleep
        let v3995 : Async<unit> = v3994 10
        let _v3978 = v3995 
        #endif
        let v3996 : Async<unit> = _v3978 
        do! v3996 
        let v4001 : int64 = v4 + 1L
        let v4002 : Async<int64> = method9(v0, v1, v2, v3, v4001)
        return! v4002 
        (*
        ()
    *)
    }
    |> fun x -> _v21 <- Some x
    let v4003 : Async<int64> = match _v21 with Some x -> x | None -> failwith "async.new_async_unit / _v21=None"
    let _v5 = v4003 
    #endif
    let v4004 : Async<int64> = _v5 
    v4004
and closure14 (v0 : int32 option, v1 : bool, v2 : string) (v3 : int32) : Async<int64> =
    let v4 : int64 = 0L
    method9(v0, v1, v2, v3, v4)
and closure13 (v0 : int32 option, v1 : bool) (v2 : string) : (int32 -> Async<int64>) =
    closure14(v0, v1, v2)
and closure12 (v0 : int32 option) (v1 : bool) : (string -> (int32 -> Async<int64>)) =
    closure13(v0, v1)
and closure11 () (v0 : int32 option) : (bool -> (string -> (int32 -> Async<int64>))) =
    closure12(v0)
and method10 (v0 : int32 option, v1 : string, v2 : int32) : Async<int32> =
    let v3 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v4 : Async<int32> = null |> unbox<Async<int32>>
    let _v3 = v4 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v7 : Async<int32> = null |> unbox<Async<int32>>
    let _v3 = v7 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v10 : Async<int32> = null |> unbox<Async<int32>>
    let _v3 = v10 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v13 : Async<int32> = null |> unbox<Async<int32>>
    let _v3 = v13 
    #endif
#if FABLE_COMPILER_PYTHON
    let v16 : Async<int32> = null |> unbox<Async<int32>>
    let _v3 = v16 
    #endif
#else
    let v19 : Async<int32> option = None
    let mutable _v19 = v19 
    async {
    let v20 : US7 option = None
    let _v20 = ref v20 
    match v0 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v21 : int32 = x
    let v22 : US7 = US7_0(v21)
    v22 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v20.Value <- x
    let v23 : US7 option = _v20.Value 
    let v34 : US7 = US7_1
    let v35 : US7 = v23 |> Option.defaultValue v34 
    let v3205 : Async<bool> =
        match v35 with
        | US7_1 -> (* None *)
            let v39 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v40 : Async<bool> = null |> unbox<Async<bool>>
            let _v39 = v40 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v43 : Async<bool> = null |> unbox<Async<bool>>
            let _v39 = v43 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v46 : Async<bool> = null |> unbox<Async<bool>>
            let _v39 = v46 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v49 : Async<bool> = null |> unbox<Async<bool>>
            let _v39 = v49 
            #endif
#if FABLE_COMPILER_PYTHON
            let v52 : Async<bool> = null |> unbox<Async<bool>>
            let _v39 = v52 
            #endif
#else
            let v55 : Async<bool> option = None
            let mutable _v55 = v55 
            async {
            let v56 : Async<System.Threading.CancellationToken> = Async.CancellationToken
            let! v56 = v56 
            let v57 : System.Threading.CancellationToken = v56 
            let v58 : System.Net.Sockets.TcpClient = new System.Net.Sockets.TcpClient ()
            use v58 = v58 
            let v59 : System.Net.Sockets.TcpClient = v58 
            try
            let v60 : System.Threading.Tasks.ValueTask = v59.ConnectAsync (v1, v2, v57)
            let v61 : (unit -> System.Threading.Tasks.Task) = v60.AsTask
            let v62 : System.Threading.Tasks.Task = v61 ()
            let v63 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v64 : Async<unit> = null |> unbox<Async<unit>>
            let _v63 = v64 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v67 : Async<unit> = null |> unbox<Async<unit>>
            let _v63 = v67 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v70 : Async<unit> = null |> unbox<Async<unit>>
            let _v63 = v70 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v73 : Async<unit> = null |> unbox<Async<unit>>
            let _v63 = v73 
            #endif
#if FABLE_COMPILER_PYTHON
            let v76 : Async<unit> = null |> unbox<Async<unit>>
            let _v63 = v76 
            #endif
#else
            let v79 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
            let v80 : Async<unit> = v79 v62
            let _v63 = v80 
            #endif
            let v81 : Async<unit> = _v63 
            do! v81 
            return true 
            with ex ->
            let v86 : exn = ex
            let v87 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v88 : string = $"%A{v86}"
            let _v87 = v88 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v91 : string = $"%A{v86}"
            let _v87 = v91 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v94 : string = $"%A{v86}"
            let _v87 = v94 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v97 : string = $"%A{v86}"
            let _v87 = v97 
            #endif
#if FABLE_COMPILER_PYTHON
            let v100 : string = $"%A{v86}"
            let _v87 = v100 
            #endif
#else
            let v103 : string = $"{v86.GetType ()}: {v86.Message}"
            let _v87 = v103 
            #endif
            let v104 : string = _v87 
            let v109 : bool = State.trace_state.IsNone
            if v109 then
                let v110 : US0 = US0_0
                let struct (v111 : Mut0, v112 : Mut1, v113 : Mut2, v114 : Mut3, v115 : int64 option) = method0(v110)
                let v116 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v111, v112, v113, v114, v115) 
                State.trace_state <- v116 
                ()
            let struct (v121 : Mut0, v122 : Mut1, v123 : Mut2, v124 : Mut3, v125 : int64 option) = State.trace_state.Value
            let v136 : bool = State.trace_state.IsNone
            if v136 then
                let v137 : US0 = US0_0
                let struct (v138 : Mut0, v139 : Mut1, v140 : Mut2, v141 : Mut3, v142 : int64 option) = method0(v137)
                let v143 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v138, v139, v140, v141, v142) 
                State.trace_state <- v143 
                ()
            let struct (v148 : Mut0, v149 : Mut1, v150 : Mut2, v151 : Mut3, v152 : int64 option) = State.trace_state.Value
            let v163 : US0 = v151.l0
            let v164 : bool = v150.l0
            let v165 : bool = v164 = false
            let v168 : bool =
                if v165 then
                    false
                else
                    let v166 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v163
                    let v167 : bool = 0 >= v166
                    v167
            if v168 then
                let v169 : int64 = v121.l0
                let v170 : int64 = v169 + 1L
                v121.l0 <- v170
                let v171 : bool = State.trace_state.IsNone
                if v171 then
                    let v172 : US0 = US0_0
                    let struct (v173 : Mut0, v174 : Mut1, v175 : Mut2, v176 : Mut3, v177 : int64 option) = method0(v172)
                    let v178 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v173, v174, v175, v176, v177) 
                    State.trace_state <- v178 
                    ()
                let struct (v183 : Mut0, v184 : Mut1, v185 : Mut2, v186 : Mut3, v187 : int64 option) = State.trace_state.Value
                let v198 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v199 : US3 option = None
                let _v199 = ref v199 
                match v187 with
                | Some x -> (
                (fun () ->
                (fun () ->
                let v200 : int64 = x
                let v201 : US3 = US3_0(v200)
                v201 
                )
                |> fun x -> x () |> Some
                ) () ) | None -> None
                |> fun x -> _v199.Value <- x
                let v202 : US3 option = _v199.Value 
                let v213 : US3 = US3_1
                let v214 : US3 = v202 |> Option.defaultValue v213 
                let v254 : System.DateTime =
                    match v214 with
                    | US3_1 -> (* None *)
                        let v250 : System.DateTime = System.DateTime.Now
                        v250
                    | US3_0(v218) -> (* Some *)
                        let v219 : System.DateTime = System.DateTime.Now
                        let v222 : (System.DateTime -> int64) = _.Ticks
                        let v223 : int64 = v222 v219
                        let v226 : int64 = v223 - v218
                        let v227 : (int64 -> System.TimeSpan) = System.TimeSpan 
                        let v228 : System.TimeSpan = v227 v226
                        let v231 : (System.TimeSpan -> int32) = _.Hours
                        let v232 : int32 = v231 v228
                        let v235 : (System.TimeSpan -> int32) = _.Minutes
                        let v236 : int32 = v235 v228
                        let v239 : (System.TimeSpan -> int32) = _.Seconds
                        let v240 : int32 = v239 v228
                        let v243 : (System.TimeSpan -> int32) = _.Milliseconds
                        let v244 : int32 = v243 v228
                        let v247 : System.DateTime = System.DateTime (1, 1, 1, v232, v236, v240, v244)
                        v247
                let v255 : string = method5()
                let v258 : (string -> string) = v254.ToString
                let v259 : string = v258 v255
                let _v198 = v259 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v262 : US3 option = None
                let _v262 = ref v262 
                match v187 with
                | Some x -> (
                (fun () ->
                (fun () ->
                let v263 : int64 = x
                let v264 : US3 = US3_0(v263)
                v264 
                )
                |> fun x -> x () |> Some
                ) () ) | None -> None
                |> fun x -> _v262.Value <- x
                let v265 : US3 option = _v262.Value 
                let v276 : US3 = US3_1
                let v277 : US3 = v265 |> Option.defaultValue v276 
                let v317 : System.DateTime =
                    match v277 with
                    | US3_1 -> (* None *)
                        let v313 : System.DateTime = System.DateTime.Now
                        v313
                    | US3_0(v281) -> (* Some *)
                        let v282 : System.DateTime = System.DateTime.Now
                        let v285 : (System.DateTime -> int64) = _.Ticks
                        let v286 : int64 = v285 v282
                        let v289 : int64 = v286 - v281
                        let v290 : (int64 -> System.TimeSpan) = System.TimeSpan 
                        let v291 : System.TimeSpan = v290 v289
                        let v294 : (System.TimeSpan -> int32) = _.Hours
                        let v295 : int32 = v294 v291
                        let v298 : (System.TimeSpan -> int32) = _.Minutes
                        let v299 : int32 = v298 v291
                        let v302 : (System.TimeSpan -> int32) = _.Seconds
                        let v303 : int32 = v302 v291
                        let v306 : (System.TimeSpan -> int32) = _.Milliseconds
                        let v307 : int32 = v306 v291
                        let v310 : System.DateTime = System.DateTime (1, 1, 1, v295, v299, v303, v307)
                        v310
                let v318 : string = method5()
                let v321 : (string -> string) = v317.ToString
                let v322 : string = v321 v318
                let _v198 = v322 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v325 : string = $"near_sdk::env::block_timestamp()"
                let v326 : uint64 = Fable.Core.RustInterop.emitRustExpr () v325 
                let v327 : US3 option = None
                let _v327 = ref v327 
                match v187 with
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
                let v351 : uint64 =
                    match v342 with
                    | US3_1 -> (* None *)
                        v326
                    | US3_0(v346) -> (* Some *)
                        let v347 : (int64 -> uint64) = uint64
                        let v348 : uint64 = v347 v346
                        let v349 : uint64 = v326 - v348
                        v349
                let v352 : uint64 = v351 / 1000000000UL
                let v353 : uint64 = v352 % 60UL
                let v354 : uint64 = v352 / 60UL
                let v355 : uint64 = v354 % 60UL
                let v356 : uint64 = v352 / 3600UL
                let v357 : uint64 = v356 % 24UL
                let v358 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
                let v359 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v357, v355, v353) v358 
                let v360 : string = "fable_library_rust::String_::fromString($0)"
                let v361 : string = Fable.Core.RustInterop.emitRustExpr v359 v360 
                let _v198 = v361 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v362 : US3 option = None
                let _v362 = ref v362 
                match v187 with
                | Some x -> (
                (fun () ->
                (fun () ->
                let v363 : int64 = x
                let v364 : US3 = US3_0(v363)
                v364 
                )
                |> fun x -> x () |> Some
                ) () ) | None -> None
                |> fun x -> _v362.Value <- x
                let v365 : US3 option = _v362.Value 
                let v376 : US3 = US3_1
                let v377 : US3 = v365 |> Option.defaultValue v376 
                let v417 : System.DateTime =
                    match v377 with
                    | US3_1 -> (* None *)
                        let v413 : System.DateTime = System.DateTime.Now
                        v413
                    | US3_0(v381) -> (* Some *)
                        let v382 : System.DateTime = System.DateTime.Now
                        let v385 : (System.DateTime -> int64) = _.Ticks
                        let v386 : int64 = v385 v382
                        let v389 : int64 = v386 - v381
                        let v390 : (int64 -> System.TimeSpan) = System.TimeSpan 
                        let v391 : System.TimeSpan = v390 v389
                        let v394 : (System.TimeSpan -> int32) = _.Hours
                        let v395 : int32 = v394 v391
                        let v398 : (System.TimeSpan -> int32) = _.Minutes
                        let v399 : int32 = v398 v391
                        let v402 : (System.TimeSpan -> int32) = _.Seconds
                        let v403 : int32 = v402 v391
                        let v406 : (System.TimeSpan -> int32) = _.Milliseconds
                        let v407 : int32 = v406 v391
                        let v410 : System.DateTime = System.DateTime (1, 1, 1, v395, v399, v403, v407)
                        v410
                let v418 : string = method6()
                let v421 : (string -> string) = v417.ToString
                let v422 : string = v421 v418
                let _v198 = v422 
                #endif
#if FABLE_COMPILER_PYTHON
                let v425 : US3 option = None
                let _v425 = ref v425 
                match v187 with
                | Some x -> (
                (fun () ->
                (fun () ->
                let v426 : int64 = x
                let v427 : US3 = US3_0(v426)
                v427 
                )
                |> fun x -> x () |> Some
                ) () ) | None -> None
                |> fun x -> _v425.Value <- x
                let v428 : US3 option = _v425.Value 
                let v439 : US3 = US3_1
                let v440 : US3 = v428 |> Option.defaultValue v439 
                let v480 : System.DateTime =
                    match v440 with
                    | US3_1 -> (* None *)
                        let v476 : System.DateTime = System.DateTime.Now
                        v476
                    | US3_0(v444) -> (* Some *)
                        let v445 : System.DateTime = System.DateTime.Now
                        let v448 : (System.DateTime -> int64) = _.Ticks
                        let v449 : int64 = v448 v445
                        let v452 : int64 = v449 - v444
                        let v453 : (int64 -> System.TimeSpan) = System.TimeSpan 
                        let v454 : System.TimeSpan = v453 v452
                        let v457 : (System.TimeSpan -> int32) = _.Hours
                        let v458 : int32 = v457 v454
                        let v461 : (System.TimeSpan -> int32) = _.Minutes
                        let v462 : int32 = v461 v454
                        let v465 : (System.TimeSpan -> int32) = _.Seconds
                        let v466 : int32 = v465 v454
                        let v469 : (System.TimeSpan -> int32) = _.Milliseconds
                        let v470 : int32 = v469 v454
                        let v473 : System.DateTime = System.DateTime (1, 1, 1, v458, v462, v466, v470)
                        v473
                let v481 : string = method6()
                let v484 : (string -> string) = v480.ToString
                let v485 : string = v484 v481
                let _v198 = v485 
                #endif
#else
                let v488 : US3 option = None
                let _v488 = ref v488 
                match v187 with
                | Some x -> (
                (fun () ->
                (fun () ->
                let v489 : int64 = x
                let v490 : US3 = US3_0(v489)
                v490 
                )
                |> fun x -> x () |> Some
                ) () ) | None -> None
                |> fun x -> _v488.Value <- x
                let v491 : US3 option = _v488.Value 
                let v502 : US3 = US3_1
                let v503 : US3 = v491 |> Option.defaultValue v502 
                let v543 : System.DateTime =
                    match v503 with
                    | US3_1 -> (* None *)
                        let v539 : System.DateTime = System.DateTime.Now
                        v539
                    | US3_0(v507) -> (* Some *)
                        let v508 : System.DateTime = System.DateTime.Now
                        let v511 : (System.DateTime -> int64) = _.Ticks
                        let v512 : int64 = v511 v508
                        let v515 : int64 = v512 - v507
                        let v516 : (int64 -> System.TimeSpan) = System.TimeSpan 
                        let v517 : System.TimeSpan = v516 v515
                        let v520 : (System.TimeSpan -> int32) = _.Hours
                        let v521 : int32 = v520 v517
                        let v524 : (System.TimeSpan -> int32) = _.Minutes
                        let v525 : int32 = v524 v517
                        let v528 : (System.TimeSpan -> int32) = _.Seconds
                        let v529 : int32 = v528 v517
                        let v532 : (System.TimeSpan -> int32) = _.Milliseconds
                        let v533 : int32 = v532 v517
                        let v536 : System.DateTime = System.DateTime (1, 1, 1, v521, v525, v529, v533)
                        v536
                let v544 : string = method6()
                let v547 : (string -> string) = v543.ToString
                let v548 : string = v547 v544
                let _v198 = v548 
                #endif
                let v551 : string = _v198 
                let v616 : string = "Verbose"
                let v617 : (unit -> string) = v616.ToLower
                let v618 : string = v617 ()
                let v621 : string = v618.PadLeft (7, ' ')
                let v635 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v636 : string = "inline_colorization::color_bright_black"
                let v637 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v636 
                let v638 : string = "&*$0"
                let v639 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v621 v638 
                let v640 : string = "inline_colorization::color_reset"
                let v641 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v640 
                let v642 : string = "\"{v637}{v639}{v641}\""
                let v643 : string = @$"format!(" + v642 + ")"
                let v644 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v643 
                let v645 : string = "fable_library_rust::String_::fromString($0)"
                let v646 : string = Fable.Core.RustInterop.emitRustExpr v644 v645 
                let _v635 = v646 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v647 : string = "inline_colorization::color_bright_black"
                let v648 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v647 
                let v649 : string = "&*$0"
                let v650 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v621 v649 
                let v651 : string = "inline_colorization::color_reset"
                let v652 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v651 
                let v653 : string = "\"{v648}{v650}{v652}\""
                let v654 : string = @$"format!(" + v653 + ")"
                let v655 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v654 
                let v656 : string = "fable_library_rust::String_::fromString($0)"
                let v657 : string = Fable.Core.RustInterop.emitRustExpr v655 v656 
                let _v635 = v657 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v658 : string = "inline_colorization::color_bright_black"
                let v659 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v658 
                let v660 : string = "&*$0"
                let v661 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v621 v660 
                let v662 : string = "inline_colorization::color_reset"
                let v663 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v662 
                let v664 : string = "\"{v659}{v661}{v663}\""
                let v665 : string = @$"format!(" + v664 + ")"
                let v666 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v665 
                let v667 : string = "fable_library_rust::String_::fromString($0)"
                let v668 : string = Fable.Core.RustInterop.emitRustExpr v666 v667 
                let _v635 = v668 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v669 : string = "\u001b[90m"
                let v670 : string = method7()
                let v671 : string = v669 + v621 
                let v672 : string = v671 + v670 
                let _v635 = v672 
                #endif
#if FABLE_COMPILER_PYTHON
                let v673 : string = "\u001b[90m"
                let v674 : string = method7()
                let v675 : string = v673 + v621 
                let v676 : string = v675 + v674 
                let _v635 = v676 
                #endif
#else
                let v677 : string = "\u001b[90m"
                let v678 : string = method7()
                let v679 : string = v677 + v621 
                let v680 : string = v679 + v678 
                let _v635 = v680 
                #endif
                let v681 : string = _v635 
                let v687 : int64 = v183.l0
                let v688 : string = method8()
                let v689 : Mut4 = {l0 = v688} : Mut4
                let v690 : string = "{ "
                let v691 : string = $"{v690}"
                let v694 : string = v689.l0
                let v695 : string = v694 + v691 
                v689.l0 <- v695
                let v696 : string = "port"
                let v697 : string = $"{v696}"
                let v700 : string = v689.l0
                let v701 : string = v700 + v697 
                v689.l0 <- v701
                let v702 : string = " = "
                let v703 : string = $"{v702}"
                let v706 : string = v689.l0
                let v707 : string = v706 + v703 
                v689.l0 <- v707
                let v708 : string = $"{v2}"
                let v711 : string = v689.l0
                let v712 : string = v711 + v708 
                v689.l0 <- v712
                let v713 : string = "; "
                let v714 : string = $"{v713}"
                let v717 : string = v689.l0
                let v718 : string = v717 + v714 
                v689.l0 <- v718
                let v719 : string = "ex"
                let v720 : string = $"{v719}"
                let v723 : string = v689.l0
                let v724 : string = v723 + v720 
                v689.l0 <- v724
                let v725 : string = $"{v702}"
                let v728 : string = v689.l0
                let v729 : string = v728 + v725 
                v689.l0 <- v729
                let v730 : string = $"{v104}"
                let v733 : string = v689.l0
                let v734 : string = v733 + v730 
                v689.l0 <- v734
                let v735 : string = " }"
                let v736 : string = $"{v735}"
                let v739 : string = v689.l0
                let v740 : string = v739 + v736 
                v689.l0 <- v740
                let v741 : string = v689.l0
                let v742 : (unit -> string) = closure3()
                let v743 : string = $"{v551} {v681} #{v687} %s{v742 ()} / {v741}"
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
                let v802 : (string -> unit) = v122.l0
                v802 v780
            return false 
            (*
            let v803 : bool = *)
            }
            |> fun x -> _v55 <- Some x
            let v804 : Async<bool> = match _v55 with Some x -> x | None -> failwith "async.new_async_unit / _v55=None"
            let _v39 = v804 
            #endif
            let v805 : Async<bool> = _v39 
            v805
        | US7_0(v810) -> (* Some *)
            let v811 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v812 : Async<bool> = null |> unbox<Async<bool>>
            let _v811 = v812 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v815 : Async<bool> = null |> unbox<Async<bool>>
            let _v811 = v815 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v818 : Async<bool> = null |> unbox<Async<bool>>
            let _v811 = v818 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v821 : Async<bool> = null |> unbox<Async<bool>>
            let _v811 = v821 
            #endif
#if FABLE_COMPILER_PYTHON
            let v824 : Async<bool> = null |> unbox<Async<bool>>
            let _v811 = v824 
            #endif
#else
            let v827 : Async<bool> option = None
            let mutable _v827 = v827 
            async {
            let v828 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v829 : Async<bool> = null |> unbox<Async<bool>>
            let _v828 = v829 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v832 : Async<bool> = null |> unbox<Async<bool>>
            let _v828 = v832 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v835 : Async<bool> = null |> unbox<Async<bool>>
            let _v828 = v835 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v838 : Async<bool> = null |> unbox<Async<bool>>
            let _v828 = v838 
            #endif
#if FABLE_COMPILER_PYTHON
            let v841 : Async<bool> = null |> unbox<Async<bool>>
            let _v828 = v841 
            #endif
#else
            let v844 : Async<bool> option = None
            let mutable _v844 = v844 
            async {
            let v845 : Async<System.Threading.CancellationToken> = Async.CancellationToken
            let! v845 = v845 
            let v846 : System.Threading.CancellationToken = v845 
            let v847 : System.Net.Sockets.TcpClient = new System.Net.Sockets.TcpClient ()
            use v847 = v847 
            let v848 : System.Net.Sockets.TcpClient = v847 
            try
            let v849 : System.Threading.Tasks.ValueTask = v848.ConnectAsync (v1, v2, v846)
            let v850 : (unit -> System.Threading.Tasks.Task) = v849.AsTask
            let v851 : System.Threading.Tasks.Task = v850 ()
            let v852 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v853 : Async<unit> = null |> unbox<Async<unit>>
            let _v852 = v853 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v856 : Async<unit> = null |> unbox<Async<unit>>
            let _v852 = v856 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v859 : Async<unit> = null |> unbox<Async<unit>>
            let _v852 = v859 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v862 : Async<unit> = null |> unbox<Async<unit>>
            let _v852 = v862 
            #endif
#if FABLE_COMPILER_PYTHON
            let v865 : Async<unit> = null |> unbox<Async<unit>>
            let _v852 = v865 
            #endif
#else
            let v868 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
            let v869 : Async<unit> = v868 v851
            let _v852 = v869 
            #endif
            let v870 : Async<unit> = _v852 
            do! v870 
            return true 
            with ex ->
            let v875 : exn = ex
            let v876 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v877 : string = $"%A{v875}"
            let _v876 = v877 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v880 : string = $"%A{v875}"
            let _v876 = v880 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v883 : string = $"%A{v875}"
            let _v876 = v883 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v886 : string = $"%A{v875}"
            let _v876 = v886 
            #endif
#if FABLE_COMPILER_PYTHON
            let v889 : string = $"%A{v875}"
            let _v876 = v889 
            #endif
#else
            let v892 : string = $"{v875.GetType ()}: {v875.Message}"
            let _v876 = v892 
            #endif
            let v893 : string = _v876 
            let v898 : bool = State.trace_state.IsNone
            if v898 then
                let v899 : US0 = US0_0
                let struct (v900 : Mut0, v901 : Mut1, v902 : Mut2, v903 : Mut3, v904 : int64 option) = method0(v899)
                let v905 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v900, v901, v902, v903, v904) 
                State.trace_state <- v905 
                ()
            let struct (v910 : Mut0, v911 : Mut1, v912 : Mut2, v913 : Mut3, v914 : int64 option) = State.trace_state.Value
            let v925 : bool = State.trace_state.IsNone
            if v925 then
                let v926 : US0 = US0_0
                let struct (v927 : Mut0, v928 : Mut1, v929 : Mut2, v930 : Mut3, v931 : int64 option) = method0(v926)
                let v932 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v927, v928, v929, v930, v931) 
                State.trace_state <- v932 
                ()
            let struct (v937 : Mut0, v938 : Mut1, v939 : Mut2, v940 : Mut3, v941 : int64 option) = State.trace_state.Value
            let v952 : US0 = v940.l0
            let v953 : bool = v939.l0
            let v954 : bool = v953 = false
            let v957 : bool =
                if v954 then
                    false
                else
                    let v955 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v952
                    let v956 : bool = 0 >= v955
                    v956
            if v957 then
                let v958 : int64 = v910.l0
                let v959 : int64 = v958 + 1L
                v910.l0 <- v959
                let v960 : bool = State.trace_state.IsNone
                if v960 then
                    let v961 : US0 = US0_0
                    let struct (v962 : Mut0, v963 : Mut1, v964 : Mut2, v965 : Mut3, v966 : int64 option) = method0(v961)
                    let v967 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v962, v963, v964, v965, v966) 
                    State.trace_state <- v967 
                    ()
                let struct (v972 : Mut0, v973 : Mut1, v974 : Mut2, v975 : Mut3, v976 : int64 option) = State.trace_state.Value
                let v987 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v988 : US3 option = None
                let _v988 = ref v988 
                match v976 with
                | Some x -> (
                (fun () ->
                (fun () ->
                let v989 : int64 = x
                let v990 : US3 = US3_0(v989)
                v990 
                )
                |> fun x -> x () |> Some
                ) () ) | None -> None
                |> fun x -> _v988.Value <- x
                let v991 : US3 option = _v988.Value 
                let v1002 : US3 = US3_1
                let v1003 : US3 = v991 |> Option.defaultValue v1002 
                let v1043 : System.DateTime =
                    match v1003 with
                    | US3_1 -> (* None *)
                        let v1039 : System.DateTime = System.DateTime.Now
                        v1039
                    | US3_0(v1007) -> (* Some *)
                        let v1008 : System.DateTime = System.DateTime.Now
                        let v1011 : (System.DateTime -> int64) = _.Ticks
                        let v1012 : int64 = v1011 v1008
                        let v1015 : int64 = v1012 - v1007
                        let v1016 : (int64 -> System.TimeSpan) = System.TimeSpan 
                        let v1017 : System.TimeSpan = v1016 v1015
                        let v1020 : (System.TimeSpan -> int32) = _.Hours
                        let v1021 : int32 = v1020 v1017
                        let v1024 : (System.TimeSpan -> int32) = _.Minutes
                        let v1025 : int32 = v1024 v1017
                        let v1028 : (System.TimeSpan -> int32) = _.Seconds
                        let v1029 : int32 = v1028 v1017
                        let v1032 : (System.TimeSpan -> int32) = _.Milliseconds
                        let v1033 : int32 = v1032 v1017
                        let v1036 : System.DateTime = System.DateTime (1, 1, 1, v1021, v1025, v1029, v1033)
                        v1036
                let v1044 : string = method5()
                let v1047 : (string -> string) = v1043.ToString
                let v1048 : string = v1047 v1044
                let _v987 = v1048 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v1051 : US3 option = None
                let _v1051 = ref v1051 
                match v976 with
                | Some x -> (
                (fun () ->
                (fun () ->
                let v1052 : int64 = x
                let v1053 : US3 = US3_0(v1052)
                v1053 
                )
                |> fun x -> x () |> Some
                ) () ) | None -> None
                |> fun x -> _v1051.Value <- x
                let v1054 : US3 option = _v1051.Value 
                let v1065 : US3 = US3_1
                let v1066 : US3 = v1054 |> Option.defaultValue v1065 
                let v1106 : System.DateTime =
                    match v1066 with
                    | US3_1 -> (* None *)
                        let v1102 : System.DateTime = System.DateTime.Now
                        v1102
                    | US3_0(v1070) -> (* Some *)
                        let v1071 : System.DateTime = System.DateTime.Now
                        let v1074 : (System.DateTime -> int64) = _.Ticks
                        let v1075 : int64 = v1074 v1071
                        let v1078 : int64 = v1075 - v1070
                        let v1079 : (int64 -> System.TimeSpan) = System.TimeSpan 
                        let v1080 : System.TimeSpan = v1079 v1078
                        let v1083 : (System.TimeSpan -> int32) = _.Hours
                        let v1084 : int32 = v1083 v1080
                        let v1087 : (System.TimeSpan -> int32) = _.Minutes
                        let v1088 : int32 = v1087 v1080
                        let v1091 : (System.TimeSpan -> int32) = _.Seconds
                        let v1092 : int32 = v1091 v1080
                        let v1095 : (System.TimeSpan -> int32) = _.Milliseconds
                        let v1096 : int32 = v1095 v1080
                        let v1099 : System.DateTime = System.DateTime (1, 1, 1, v1084, v1088, v1092, v1096)
                        v1099
                let v1107 : string = method5()
                let v1110 : (string -> string) = v1106.ToString
                let v1111 : string = v1110 v1107
                let _v987 = v1111 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v1114 : string = $"near_sdk::env::block_timestamp()"
                let v1115 : uint64 = Fable.Core.RustInterop.emitRustExpr () v1114 
                let v1116 : US3 option = None
                let _v1116 = ref v1116 
                match v976 with
                | Some x -> (
                (fun () ->
                (fun () ->
                let v1117 : int64 = x
                let v1118 : US3 = US3_0(v1117)
                v1118 
                )
                |> fun x -> x () |> Some
                ) () ) | None -> None
                |> fun x -> _v1116.Value <- x
                let v1119 : US3 option = _v1116.Value 
                let v1130 : US3 = US3_1
                let v1131 : US3 = v1119 |> Option.defaultValue v1130 
                let v1140 : uint64 =
                    match v1131 with
                    | US3_1 -> (* None *)
                        v1115
                    | US3_0(v1135) -> (* Some *)
                        let v1136 : (int64 -> uint64) = uint64
                        let v1137 : uint64 = v1136 v1135
                        let v1138 : uint64 = v1115 - v1137
                        v1138
                let v1141 : uint64 = v1140 / 1000000000UL
                let v1142 : uint64 = v1141 % 60UL
                let v1143 : uint64 = v1141 / 60UL
                let v1144 : uint64 = v1143 % 60UL
                let v1145 : uint64 = v1141 / 3600UL
                let v1146 : uint64 = v1145 % 24UL
                let v1147 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
                let v1148 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v1146, v1144, v1142) v1147 
                let v1149 : string = "fable_library_rust::String_::fromString($0)"
                let v1150 : string = Fable.Core.RustInterop.emitRustExpr v1148 v1149 
                let _v987 = v1150 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v1151 : US3 option = None
                let _v1151 = ref v1151 
                match v976 with
                | Some x -> (
                (fun () ->
                (fun () ->
                let v1152 : int64 = x
                let v1153 : US3 = US3_0(v1152)
                v1153 
                )
                |> fun x -> x () |> Some
                ) () ) | None -> None
                |> fun x -> _v1151.Value <- x
                let v1154 : US3 option = _v1151.Value 
                let v1165 : US3 = US3_1
                let v1166 : US3 = v1154 |> Option.defaultValue v1165 
                let v1206 : System.DateTime =
                    match v1166 with
                    | US3_1 -> (* None *)
                        let v1202 : System.DateTime = System.DateTime.Now
                        v1202
                    | US3_0(v1170) -> (* Some *)
                        let v1171 : System.DateTime = System.DateTime.Now
                        let v1174 : (System.DateTime -> int64) = _.Ticks
                        let v1175 : int64 = v1174 v1171
                        let v1178 : int64 = v1175 - v1170
                        let v1179 : (int64 -> System.TimeSpan) = System.TimeSpan 
                        let v1180 : System.TimeSpan = v1179 v1178
                        let v1183 : (System.TimeSpan -> int32) = _.Hours
                        let v1184 : int32 = v1183 v1180
                        let v1187 : (System.TimeSpan -> int32) = _.Minutes
                        let v1188 : int32 = v1187 v1180
                        let v1191 : (System.TimeSpan -> int32) = _.Seconds
                        let v1192 : int32 = v1191 v1180
                        let v1195 : (System.TimeSpan -> int32) = _.Milliseconds
                        let v1196 : int32 = v1195 v1180
                        let v1199 : System.DateTime = System.DateTime (1, 1, 1, v1184, v1188, v1192, v1196)
                        v1199
                let v1207 : string = method6()
                let v1210 : (string -> string) = v1206.ToString
                let v1211 : string = v1210 v1207
                let _v987 = v1211 
                #endif
#if FABLE_COMPILER_PYTHON
                let v1214 : US3 option = None
                let _v1214 = ref v1214 
                match v976 with
                | Some x -> (
                (fun () ->
                (fun () ->
                let v1215 : int64 = x
                let v1216 : US3 = US3_0(v1215)
                v1216 
                )
                |> fun x -> x () |> Some
                ) () ) | None -> None
                |> fun x -> _v1214.Value <- x
                let v1217 : US3 option = _v1214.Value 
                let v1228 : US3 = US3_1
                let v1229 : US3 = v1217 |> Option.defaultValue v1228 
                let v1269 : System.DateTime =
                    match v1229 with
                    | US3_1 -> (* None *)
                        let v1265 : System.DateTime = System.DateTime.Now
                        v1265
                    | US3_0(v1233) -> (* Some *)
                        let v1234 : System.DateTime = System.DateTime.Now
                        let v1237 : (System.DateTime -> int64) = _.Ticks
                        let v1238 : int64 = v1237 v1234
                        let v1241 : int64 = v1238 - v1233
                        let v1242 : (int64 -> System.TimeSpan) = System.TimeSpan 
                        let v1243 : System.TimeSpan = v1242 v1241
                        let v1246 : (System.TimeSpan -> int32) = _.Hours
                        let v1247 : int32 = v1246 v1243
                        let v1250 : (System.TimeSpan -> int32) = _.Minutes
                        let v1251 : int32 = v1250 v1243
                        let v1254 : (System.TimeSpan -> int32) = _.Seconds
                        let v1255 : int32 = v1254 v1243
                        let v1258 : (System.TimeSpan -> int32) = _.Milliseconds
                        let v1259 : int32 = v1258 v1243
                        let v1262 : System.DateTime = System.DateTime (1, 1, 1, v1247, v1251, v1255, v1259)
                        v1262
                let v1270 : string = method6()
                let v1273 : (string -> string) = v1269.ToString
                let v1274 : string = v1273 v1270
                let _v987 = v1274 
                #endif
#else
                let v1277 : US3 option = None
                let _v1277 = ref v1277 
                match v976 with
                | Some x -> (
                (fun () ->
                (fun () ->
                let v1278 : int64 = x
                let v1279 : US3 = US3_0(v1278)
                v1279 
                )
                |> fun x -> x () |> Some
                ) () ) | None -> None
                |> fun x -> _v1277.Value <- x
                let v1280 : US3 option = _v1277.Value 
                let v1291 : US3 = US3_1
                let v1292 : US3 = v1280 |> Option.defaultValue v1291 
                let v1332 : System.DateTime =
                    match v1292 with
                    | US3_1 -> (* None *)
                        let v1328 : System.DateTime = System.DateTime.Now
                        v1328
                    | US3_0(v1296) -> (* Some *)
                        let v1297 : System.DateTime = System.DateTime.Now
                        let v1300 : (System.DateTime -> int64) = _.Ticks
                        let v1301 : int64 = v1300 v1297
                        let v1304 : int64 = v1301 - v1296
                        let v1305 : (int64 -> System.TimeSpan) = System.TimeSpan 
                        let v1306 : System.TimeSpan = v1305 v1304
                        let v1309 : (System.TimeSpan -> int32) = _.Hours
                        let v1310 : int32 = v1309 v1306
                        let v1313 : (System.TimeSpan -> int32) = _.Minutes
                        let v1314 : int32 = v1313 v1306
                        let v1317 : (System.TimeSpan -> int32) = _.Seconds
                        let v1318 : int32 = v1317 v1306
                        let v1321 : (System.TimeSpan -> int32) = _.Milliseconds
                        let v1322 : int32 = v1321 v1306
                        let v1325 : System.DateTime = System.DateTime (1, 1, 1, v1310, v1314, v1318, v1322)
                        v1325
                let v1333 : string = method6()
                let v1336 : (string -> string) = v1332.ToString
                let v1337 : string = v1336 v1333
                let _v987 = v1337 
                #endif
                let v1340 : string = _v987 
                let v1405 : string = "Verbose"
                let v1406 : (unit -> string) = v1405.ToLower
                let v1407 : string = v1406 ()
                let v1410 : string = v1407.PadLeft (7, ' ')
                let v1424 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v1425 : string = "inline_colorization::color_bright_black"
                let v1426 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1425 
                let v1427 : string = "&*$0"
                let v1428 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1410 v1427 
                let v1429 : string = "inline_colorization::color_reset"
                let v1430 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1429 
                let v1431 : string = "\"{v1426}{v1428}{v1430}\""
                let v1432 : string = @$"format!(" + v1431 + ")"
                let v1433 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v1432 
                let v1434 : string = "fable_library_rust::String_::fromString($0)"
                let v1435 : string = Fable.Core.RustInterop.emitRustExpr v1433 v1434 
                let _v1424 = v1435 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v1436 : string = "inline_colorization::color_bright_black"
                let v1437 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1436 
                let v1438 : string = "&*$0"
                let v1439 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1410 v1438 
                let v1440 : string = "inline_colorization::color_reset"
                let v1441 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1440 
                let v1442 : string = "\"{v1437}{v1439}{v1441}\""
                let v1443 : string = @$"format!(" + v1442 + ")"
                let v1444 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v1443 
                let v1445 : string = "fable_library_rust::String_::fromString($0)"
                let v1446 : string = Fable.Core.RustInterop.emitRustExpr v1444 v1445 
                let _v1424 = v1446 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v1447 : string = "inline_colorization::color_bright_black"
                let v1448 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1447 
                let v1449 : string = "&*$0"
                let v1450 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1410 v1449 
                let v1451 : string = "inline_colorization::color_reset"
                let v1452 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1451 
                let v1453 : string = "\"{v1448}{v1450}{v1452}\""
                let v1454 : string = @$"format!(" + v1453 + ")"
                let v1455 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v1454 
                let v1456 : string = "fable_library_rust::String_::fromString($0)"
                let v1457 : string = Fable.Core.RustInterop.emitRustExpr v1455 v1456 
                let _v1424 = v1457 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v1458 : string = "\u001b[90m"
                let v1459 : string = method7()
                let v1460 : string = v1458 + v1410 
                let v1461 : string = v1460 + v1459 
                let _v1424 = v1461 
                #endif
#if FABLE_COMPILER_PYTHON
                let v1462 : string = "\u001b[90m"
                let v1463 : string = method7()
                let v1464 : string = v1462 + v1410 
                let v1465 : string = v1464 + v1463 
                let _v1424 = v1465 
                #endif
#else
                let v1466 : string = "\u001b[90m"
                let v1467 : string = method7()
                let v1468 : string = v1466 + v1410 
                let v1469 : string = v1468 + v1467 
                let _v1424 = v1469 
                #endif
                let v1470 : string = _v1424 
                let v1476 : int64 = v972.l0
                let v1477 : string = method8()
                let v1478 : Mut4 = {l0 = v1477} : Mut4
                let v1479 : string = "{ "
                let v1480 : string = $"{v1479}"
                let v1483 : string = v1478.l0
                let v1484 : string = v1483 + v1480 
                v1478.l0 <- v1484
                let v1485 : string = "port"
                let v1486 : string = $"{v1485}"
                let v1489 : string = v1478.l0
                let v1490 : string = v1489 + v1486 
                v1478.l0 <- v1490
                let v1491 : string = " = "
                let v1492 : string = $"{v1491}"
                let v1495 : string = v1478.l0
                let v1496 : string = v1495 + v1492 
                v1478.l0 <- v1496
                let v1497 : string = $"{v2}"
                let v1500 : string = v1478.l0
                let v1501 : string = v1500 + v1497 
                v1478.l0 <- v1501
                let v1502 : string = "; "
                let v1503 : string = $"{v1502}"
                let v1506 : string = v1478.l0
                let v1507 : string = v1506 + v1503 
                v1478.l0 <- v1507
                let v1508 : string = "ex"
                let v1509 : string = $"{v1508}"
                let v1512 : string = v1478.l0
                let v1513 : string = v1512 + v1509 
                v1478.l0 <- v1513
                let v1514 : string = $"{v1491}"
                let v1517 : string = v1478.l0
                let v1518 : string = v1517 + v1514 
                v1478.l0 <- v1518
                let v1519 : string = $"{v893}"
                let v1522 : string = v1478.l0
                let v1523 : string = v1522 + v1519 
                v1478.l0 <- v1523
                let v1524 : string = " }"
                let v1525 : string = $"{v1524}"
                let v1528 : string = v1478.l0
                let v1529 : string = v1528 + v1525 
                v1478.l0 <- v1529
                let v1530 : string = v1478.l0
                let v1531 : (unit -> string) = closure3()
                let v1532 : string = $"{v1340} {v1470} #{v1476} %s{v1531 ()} / {v1530}"
                let v1535 : char list = []
                let v1536 : (char list -> (char [])) = List.toArray
                let v1537 : (char []) = v1536 v1535
                let v1540 : string = v1532.TrimStart v1537 
                let v1558 : char list = []
                let v1559 : char list = '/' :: v1558 
                let v1562 : char list = ' ' :: v1559 
                let v1565 : (char list -> (char [])) = List.toArray
                let v1566 : (char []) = v1565 v1562
                let v1569 : string = v1540.TrimEnd v1566 
                let v1587 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v1588 : string = @"println!(""{}"", $0)"
                Fable.Core.RustInterop.emitRustExpr v1569 v1588 
                let _v1587 = () 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v1589 : string = @"println!(""{}"", $0)"
                Fable.Core.RustInterop.emitRustExpr v1569 v1589 
                let _v1587 = () 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v1590 : string = $"near_sdk::log!(\"{{}}\", $0)"
                Fable.Core.RustInterop.emitRustExpr v1569 v1590 
                let _v1587 = () 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                System.Console.WriteLine v1569 
                let _v1587 = () 
                #endif
#if FABLE_COMPILER_PYTHON
                System.Console.WriteLine v1569 
                let _v1587 = () 
                #endif
#else
                System.Console.WriteLine v1569 
                let _v1587 = () 
                #endif
                _v1587 
                let v1591 : (string -> unit) = v911.l0
                v1591 v1569
            return false 
            (*
            let v1592 : bool = *)
            }
            |> fun x -> _v844 <- Some x
            let v1593 : Async<bool> = match _v844 with Some x -> x | None -> failwith "async.new_async_unit / _v844=None"
            let _v828 = v1593 
            #endif
            let v1594 : Async<bool> = _v828 
            let v1599 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1600 : Async<US4> = null |> unbox<Async<US4>>
            let _v1599 = v1600 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1603 : Async<US4> = null |> unbox<Async<US4>>
            let _v1599 = v1603 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1606 : Async<US4> = null |> unbox<Async<US4>>
            let _v1599 = v1606 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1609 : Async<US4> = null |> unbox<Async<US4>>
            let _v1599 = v1609 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1612 : Async<US4> = null |> unbox<Async<US4>>
            let _v1599 = v1612 
            #endif
#else
            let v1615 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1616 : Async<US4> = null |> unbox<Async<US4>>
            let _v1615 = v1616 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1619 : Async<US4> = null |> unbox<Async<US4>>
            let _v1615 = v1619 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1622 : Async<US4> = null |> unbox<Async<US4>>
            let _v1615 = v1622 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1625 : Async<US4> = null |> unbox<Async<US4>>
            let _v1615 = v1625 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1628 : Async<US4> = null |> unbox<Async<US4>>
            let _v1615 = v1628 
            #endif
#else
            let v1631 : Async<US4> option = None
            let mutable _v1631 = v1631 
            async {
            let v1632 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1633 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v1632 = v1633 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1636 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v1632 = v1636 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1639 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v1632 = v1639 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1642 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v1632 = v1642 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1645 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v1632 = v1645 
            #endif
#else
            let v1648 : Async<Async<bool>> = Async.StartChild (v1594, v810)
            let _v1632 = v1648 
            #endif
            let v1649 : Async<Async<bool>> = _v1632 
            let! v1649 = v1649 
            let v1654 : Async<bool> = v1649 
            let v1655 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1656 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
            let _v1655 = v1656 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1659 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
            let _v1655 = v1659 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1662 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
            let _v1655 = v1662 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1665 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
            let _v1655 = v1665 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1668 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
            let _v1655 = v1668 
            #endif
#else
            let v1671 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v1672 : Async<Choice<bool, exn>> = v1671 v1654
            let _v1655 = v1672 
            #endif
            let v1673 : Async<Choice<bool, exn>> = _v1655 
            let v1678 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1679 : Async<US5> = null |> unbox<Async<US5>>
            let _v1678 = v1679 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1682 : Async<US5> = null |> unbox<Async<US5>>
            let _v1678 = v1682 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1685 : Async<US5> = null |> unbox<Async<US5>>
            let _v1678 = v1685 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1688 : Async<US5> = null |> unbox<Async<US5>>
            let _v1678 = v1688 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1691 : Async<US5> = null |> unbox<Async<US5>>
            let _v1678 = v1691 
            #endif
#else
            let v1694 : Async<US5> option = None
            let mutable _v1694 = v1694 
            async {
            let! v1673 = v1673 
            let v1695 : Choice<bool, exn> = v1673 
            let v1696 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1697 : US5 = null |> unbox<US5>
            let _v1696 = v1697 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1700 : US5 = null |> unbox<US5>
            let _v1696 = v1700 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1703 : US5 = null |> unbox<US5>
            let _v1696 = v1703 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1706 : US5 = null |> unbox<US5>
            let _v1696 = v1706 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1709 : US5 = null |> unbox<US5>
            let _v1696 = v1709 
            #endif
#else
            let v1712 : (bool -> US5) = closure7()
            let v1713 : (exn -> US5) = closure8()
            let v1714 : US5 = match v1695 with Choice1Of2 x -> v1712 x | Choice2Of2 x -> v1713 x
            let _v1696 = v1714 
            #endif
            let v1715 : US5 = _v1696 
            return v1715 
            }
            |> fun x -> _v1694 <- Some x
            let v1720 : Async<US5> = match _v1694 with Some x -> x | None -> failwith "async.new_async_unit / _v1694=None"
            let _v1678 = v1720 
            #endif
            let v1721 : Async<US5> = _v1678 
            let v1726 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1727 : Async<US6> = null |> unbox<Async<US6>>
            let _v1726 = v1727 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1730 : Async<US6> = null |> unbox<Async<US6>>
            let _v1726 = v1730 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1733 : Async<US6> = null |> unbox<Async<US6>>
            let _v1726 = v1733 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1736 : Async<US6> = null |> unbox<Async<US6>>
            let _v1726 = v1736 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1739 : Async<US6> = null |> unbox<Async<US6>>
            let _v1726 = v1739 
            #endif
#else
            let v1742 : Async<US6> option = None
            let mutable _v1742 = v1742 
            async {
            let! v1721 = v1721 
            let v1743 : US5 = v1721 
            let v1749 : US6 =
                match v1743 with
                | US5_0(v1744) -> (* C1of2 *)
                    US6_0(v1744)
                | US5_1(v1746) -> (* C2of2 *)
                    US6_1(v1746)
            return v1749 
            }
            |> fun x -> _v1742 <- Some x
            let v1750 : Async<US6> = match _v1742 with Some x -> x | None -> failwith "async.new_async_unit / _v1742=None"
            let _v1726 = v1750 
            #endif
            let v1751 : Async<US6> = _v1726 
            let v1756 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1757 : Async<US4> = null |> unbox<Async<US4>>
            let _v1756 = v1757 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1760 : Async<US4> = null |> unbox<Async<US4>>
            let _v1756 = v1760 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1763 : Async<US4> = null |> unbox<Async<US4>>
            let _v1756 = v1763 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1766 : Async<US4> = null |> unbox<Async<US4>>
            let _v1756 = v1766 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1769 : Async<US4> = null |> unbox<Async<US4>>
            let _v1756 = v1769 
            #endif
#else
            let v1772 : Async<US4> option = None
            let mutable _v1772 = v1772 
            async {
            let! v1751 = v1751 
            let v1773 : US6 = v1751 
            let v3176 : US4 =
                match v1773 with
                | US6_1(v1776) -> (* Error *)
                    let v1777 : string = $"%A{v1776}"
                    let v1780 : string = "System.TimeoutException"
                    let v1781 : bool = v1777.Contains v1780 
                    if v1781 then
                        let v1784 : bool = State.trace_state.IsNone
                        if v1784 then
                            let v1785 : US0 = US0_0
                            let struct (v1786 : Mut0, v1787 : Mut1, v1788 : Mut2, v1789 : Mut3, v1790 : int64 option) = method0(v1785)
                            let v1791 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v1786, v1787, v1788, v1789, v1790) 
                            State.trace_state <- v1791 
                            ()
                        let struct (v1796 : Mut0, v1797 : Mut1, v1798 : Mut2, v1799 : Mut3, v1800 : int64 option) = State.trace_state.Value
                        let v1811 : bool = State.trace_state.IsNone
                        if v1811 then
                            let v1812 : US0 = US0_0
                            let struct (v1813 : Mut0, v1814 : Mut1, v1815 : Mut2, v1816 : Mut3, v1817 : int64 option) = method0(v1812)
                            let v1818 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v1813, v1814, v1815, v1816, v1817) 
                            State.trace_state <- v1818 
                            ()
                        let struct (v1823 : Mut0, v1824 : Mut1, v1825 : Mut2, v1826 : Mut3, v1827 : int64 option) = State.trace_state.Value
                        let v1838 : US0 = v1826.l0
                        let v1839 : bool = v1825.l0
                        let v1840 : bool = v1839 = false
                        let v1843 : bool =
                            if v1840 then
                                false
                            else
                                let v1841 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v1838
                                let v1842 : bool = 0 >= v1841
                                v1842
                        if v1843 then
                            let v1844 : int64 = v1796.l0
                            let v1845 : int64 = v1844 + 1L
                            v1796.l0 <- v1845
                            let v1846 : bool = State.trace_state.IsNone
                            if v1846 then
                                let v1847 : US0 = US0_0
                                let struct (v1848 : Mut0, v1849 : Mut1, v1850 : Mut2, v1851 : Mut3, v1852 : int64 option) = method0(v1847)
                                let v1853 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v1848, v1849, v1850, v1851, v1852) 
                                State.trace_state <- v1853 
                                ()
                            let struct (v1858 : Mut0, v1859 : Mut1, v1860 : Mut2, v1861 : Mut3, v1862 : int64 option) = State.trace_state.Value
                            let v1873 : unit = ()
                            
#if FABLE_COMPILER || WASM || CONTRACT
                            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                            let v1874 : US3 option = None
                            let _v1874 = ref v1874 
                            match v1862 with
                            | Some x -> (
                            (fun () ->
                            (fun () ->
                            let v1875 : int64 = x
                            let v1876 : US3 = US3_0(v1875)
                            v1876 
                            )
                            |> fun x -> x () |> Some
                            ) () ) | None -> None
                            |> fun x -> _v1874.Value <- x
                            let v1877 : US3 option = _v1874.Value 
                            let v1888 : US3 = US3_1
                            let v1889 : US3 = v1877 |> Option.defaultValue v1888 
                            let v1929 : System.DateTime =
                                match v1889 with
                                | US3_1 -> (* None *)
                                    let v1925 : System.DateTime = System.DateTime.Now
                                    v1925
                                | US3_0(v1893) -> (* Some *)
                                    let v1894 : System.DateTime = System.DateTime.Now
                                    let v1897 : (System.DateTime -> int64) = _.Ticks
                                    let v1898 : int64 = v1897 v1894
                                    let v1901 : int64 = v1898 - v1893
                                    let v1902 : (int64 -> System.TimeSpan) = System.TimeSpan 
                                    let v1903 : System.TimeSpan = v1902 v1901
                                    let v1906 : (System.TimeSpan -> int32) = _.Hours
                                    let v1907 : int32 = v1906 v1903
                                    let v1910 : (System.TimeSpan -> int32) = _.Minutes
                                    let v1911 : int32 = v1910 v1903
                                    let v1914 : (System.TimeSpan -> int32) = _.Seconds
                                    let v1915 : int32 = v1914 v1903
                                    let v1918 : (System.TimeSpan -> int32) = _.Milliseconds
                                    let v1919 : int32 = v1918 v1903
                                    let v1922 : System.DateTime = System.DateTime (1, 1, 1, v1907, v1911, v1915, v1919)
                                    v1922
                            let v1930 : string = method5()
                            let v1933 : (string -> string) = v1929.ToString
                            let v1934 : string = v1933 v1930
                            let _v1873 = v1934 
                            #endif
#if FABLE_COMPILER_RUST && WASM
                            let v1937 : US3 option = None
                            let _v1937 = ref v1937 
                            match v1862 with
                            | Some x -> (
                            (fun () ->
                            (fun () ->
                            let v1938 : int64 = x
                            let v1939 : US3 = US3_0(v1938)
                            v1939 
                            )
                            |> fun x -> x () |> Some
                            ) () ) | None -> None
                            |> fun x -> _v1937.Value <- x
                            let v1940 : US3 option = _v1937.Value 
                            let v1951 : US3 = US3_1
                            let v1952 : US3 = v1940 |> Option.defaultValue v1951 
                            let v1992 : System.DateTime =
                                match v1952 with
                                | US3_1 -> (* None *)
                                    let v1988 : System.DateTime = System.DateTime.Now
                                    v1988
                                | US3_0(v1956) -> (* Some *)
                                    let v1957 : System.DateTime = System.DateTime.Now
                                    let v1960 : (System.DateTime -> int64) = _.Ticks
                                    let v1961 : int64 = v1960 v1957
                                    let v1964 : int64 = v1961 - v1956
                                    let v1965 : (int64 -> System.TimeSpan) = System.TimeSpan 
                                    let v1966 : System.TimeSpan = v1965 v1964
                                    let v1969 : (System.TimeSpan -> int32) = _.Hours
                                    let v1970 : int32 = v1969 v1966
                                    let v1973 : (System.TimeSpan -> int32) = _.Minutes
                                    let v1974 : int32 = v1973 v1966
                                    let v1977 : (System.TimeSpan -> int32) = _.Seconds
                                    let v1978 : int32 = v1977 v1966
                                    let v1981 : (System.TimeSpan -> int32) = _.Milliseconds
                                    let v1982 : int32 = v1981 v1966
                                    let v1985 : System.DateTime = System.DateTime (1, 1, 1, v1970, v1974, v1978, v1982)
                                    v1985
                            let v1993 : string = method5()
                            let v1996 : (string -> string) = v1992.ToString
                            let v1997 : string = v1996 v1993
                            let _v1873 = v1997 
                            #endif
#if FABLE_COMPILER_RUST && CONTRACT
                            let v2000 : string = $"near_sdk::env::block_timestamp()"
                            let v2001 : uint64 = Fable.Core.RustInterop.emitRustExpr () v2000 
                            let v2002 : US3 option = None
                            let _v2002 = ref v2002 
                            match v1862 with
                            | Some x -> (
                            (fun () ->
                            (fun () ->
                            let v2003 : int64 = x
                            let v2004 : US3 = US3_0(v2003)
                            v2004 
                            )
                            |> fun x -> x () |> Some
                            ) () ) | None -> None
                            |> fun x -> _v2002.Value <- x
                            let v2005 : US3 option = _v2002.Value 
                            let v2016 : US3 = US3_1
                            let v2017 : US3 = v2005 |> Option.defaultValue v2016 
                            let v2026 : uint64 =
                                match v2017 with
                                | US3_1 -> (* None *)
                                    v2001
                                | US3_0(v2021) -> (* Some *)
                                    let v2022 : (int64 -> uint64) = uint64
                                    let v2023 : uint64 = v2022 v2021
                                    let v2024 : uint64 = v2001 - v2023
                                    v2024
                            let v2027 : uint64 = v2026 / 1000000000UL
                            let v2028 : uint64 = v2027 % 60UL
                            let v2029 : uint64 = v2027 / 60UL
                            let v2030 : uint64 = v2029 % 60UL
                            let v2031 : uint64 = v2027 / 3600UL
                            let v2032 : uint64 = v2031 % 24UL
                            let v2033 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
                            let v2034 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v2032, v2030, v2028) v2033 
                            let v2035 : string = "fable_library_rust::String_::fromString($0)"
                            let v2036 : string = Fable.Core.RustInterop.emitRustExpr v2034 v2035 
                            let _v1873 = v2036 
                            #endif
#if FABLE_COMPILER_TYPESCRIPT
                            let v2037 : US3 option = None
                            let _v2037 = ref v2037 
                            match v1862 with
                            | Some x -> (
                            (fun () ->
                            (fun () ->
                            let v2038 : int64 = x
                            let v2039 : US3 = US3_0(v2038)
                            v2039 
                            )
                            |> fun x -> x () |> Some
                            ) () ) | None -> None
                            |> fun x -> _v2037.Value <- x
                            let v2040 : US3 option = _v2037.Value 
                            let v2051 : US3 = US3_1
                            let v2052 : US3 = v2040 |> Option.defaultValue v2051 
                            let v2092 : System.DateTime =
                                match v2052 with
                                | US3_1 -> (* None *)
                                    let v2088 : System.DateTime = System.DateTime.Now
                                    v2088
                                | US3_0(v2056) -> (* Some *)
                                    let v2057 : System.DateTime = System.DateTime.Now
                                    let v2060 : (System.DateTime -> int64) = _.Ticks
                                    let v2061 : int64 = v2060 v2057
                                    let v2064 : int64 = v2061 - v2056
                                    let v2065 : (int64 -> System.TimeSpan) = System.TimeSpan 
                                    let v2066 : System.TimeSpan = v2065 v2064
                                    let v2069 : (System.TimeSpan -> int32) = _.Hours
                                    let v2070 : int32 = v2069 v2066
                                    let v2073 : (System.TimeSpan -> int32) = _.Minutes
                                    let v2074 : int32 = v2073 v2066
                                    let v2077 : (System.TimeSpan -> int32) = _.Seconds
                                    let v2078 : int32 = v2077 v2066
                                    let v2081 : (System.TimeSpan -> int32) = _.Milliseconds
                                    let v2082 : int32 = v2081 v2066
                                    let v2085 : System.DateTime = System.DateTime (1, 1, 1, v2070, v2074, v2078, v2082)
                                    v2085
                            let v2093 : string = method6()
                            let v2096 : (string -> string) = v2092.ToString
                            let v2097 : string = v2096 v2093
                            let _v1873 = v2097 
                            #endif
#if FABLE_COMPILER_PYTHON
                            let v2100 : US3 option = None
                            let _v2100 = ref v2100 
                            match v1862 with
                            | Some x -> (
                            (fun () ->
                            (fun () ->
                            let v2101 : int64 = x
                            let v2102 : US3 = US3_0(v2101)
                            v2102 
                            )
                            |> fun x -> x () |> Some
                            ) () ) | None -> None
                            |> fun x -> _v2100.Value <- x
                            let v2103 : US3 option = _v2100.Value 
                            let v2114 : US3 = US3_1
                            let v2115 : US3 = v2103 |> Option.defaultValue v2114 
                            let v2155 : System.DateTime =
                                match v2115 with
                                | US3_1 -> (* None *)
                                    let v2151 : System.DateTime = System.DateTime.Now
                                    v2151
                                | US3_0(v2119) -> (* Some *)
                                    let v2120 : System.DateTime = System.DateTime.Now
                                    let v2123 : (System.DateTime -> int64) = _.Ticks
                                    let v2124 : int64 = v2123 v2120
                                    let v2127 : int64 = v2124 - v2119
                                    let v2128 : (int64 -> System.TimeSpan) = System.TimeSpan 
                                    let v2129 : System.TimeSpan = v2128 v2127
                                    let v2132 : (System.TimeSpan -> int32) = _.Hours
                                    let v2133 : int32 = v2132 v2129
                                    let v2136 : (System.TimeSpan -> int32) = _.Minutes
                                    let v2137 : int32 = v2136 v2129
                                    let v2140 : (System.TimeSpan -> int32) = _.Seconds
                                    let v2141 : int32 = v2140 v2129
                                    let v2144 : (System.TimeSpan -> int32) = _.Milliseconds
                                    let v2145 : int32 = v2144 v2129
                                    let v2148 : System.DateTime = System.DateTime (1, 1, 1, v2133, v2137, v2141, v2145)
                                    v2148
                            let v2156 : string = method6()
                            let v2159 : (string -> string) = v2155.ToString
                            let v2160 : string = v2159 v2156
                            let _v1873 = v2160 
                            #endif
#else
                            let v2163 : US3 option = None
                            let _v2163 = ref v2163 
                            match v1862 with
                            | Some x -> (
                            (fun () ->
                            (fun () ->
                            let v2164 : int64 = x
                            let v2165 : US3 = US3_0(v2164)
                            v2165 
                            )
                            |> fun x -> x () |> Some
                            ) () ) | None -> None
                            |> fun x -> _v2163.Value <- x
                            let v2166 : US3 option = _v2163.Value 
                            let v2177 : US3 = US3_1
                            let v2178 : US3 = v2166 |> Option.defaultValue v2177 
                            let v2218 : System.DateTime =
                                match v2178 with
                                | US3_1 -> (* None *)
                                    let v2214 : System.DateTime = System.DateTime.Now
                                    v2214
                                | US3_0(v2182) -> (* Some *)
                                    let v2183 : System.DateTime = System.DateTime.Now
                                    let v2186 : (System.DateTime -> int64) = _.Ticks
                                    let v2187 : int64 = v2186 v2183
                                    let v2190 : int64 = v2187 - v2182
                                    let v2191 : (int64 -> System.TimeSpan) = System.TimeSpan 
                                    let v2192 : System.TimeSpan = v2191 v2190
                                    let v2195 : (System.TimeSpan -> int32) = _.Hours
                                    let v2196 : int32 = v2195 v2192
                                    let v2199 : (System.TimeSpan -> int32) = _.Minutes
                                    let v2200 : int32 = v2199 v2192
                                    let v2203 : (System.TimeSpan -> int32) = _.Seconds
                                    let v2204 : int32 = v2203 v2192
                                    let v2207 : (System.TimeSpan -> int32) = _.Milliseconds
                                    let v2208 : int32 = v2207 v2192
                                    let v2211 : System.DateTime = System.DateTime (1, 1, 1, v2196, v2200, v2204, v2208)
                                    v2211
                            let v2219 : string = method6()
                            let v2222 : (string -> string) = v2218.ToString
                            let v2223 : string = v2222 v2219
                            let _v1873 = v2223 
                            #endif
                            let v2226 : string = _v1873 
                            let v2291 : string = "Verbose"
                            let v2292 : (unit -> string) = v2291.ToLower
                            let v2293 : string = v2292 ()
                            let v2296 : string = v2293.PadLeft (7, ' ')
                            let v2310 : unit = ()
                            
#if FABLE_COMPILER || WASM || CONTRACT
                            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                            let v2311 : string = "inline_colorization::color_bright_black"
                            let v2312 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v2311 
                            let v2313 : string = "&*$0"
                            let v2314 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v2296 v2313 
                            let v2315 : string = "inline_colorization::color_reset"
                            let v2316 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v2315 
                            let v2317 : string = "\"{v2312}{v2314}{v2316}\""
                            let v2318 : string = @$"format!(" + v2317 + ")"
                            let v2319 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v2318 
                            let v2320 : string = "fable_library_rust::String_::fromString($0)"
                            let v2321 : string = Fable.Core.RustInterop.emitRustExpr v2319 v2320 
                            let _v2310 = v2321 
                            #endif
#if FABLE_COMPILER_RUST && WASM
                            let v2322 : string = "inline_colorization::color_bright_black"
                            let v2323 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v2322 
                            let v2324 : string = "&*$0"
                            let v2325 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v2296 v2324 
                            let v2326 : string = "inline_colorization::color_reset"
                            let v2327 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v2326 
                            let v2328 : string = "\"{v2323}{v2325}{v2327}\""
                            let v2329 : string = @$"format!(" + v2328 + ")"
                            let v2330 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v2329 
                            let v2331 : string = "fable_library_rust::String_::fromString($0)"
                            let v2332 : string = Fable.Core.RustInterop.emitRustExpr v2330 v2331 
                            let _v2310 = v2332 
                            #endif
#if FABLE_COMPILER_RUST && CONTRACT
                            let v2333 : string = "inline_colorization::color_bright_black"
                            let v2334 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v2333 
                            let v2335 : string = "&*$0"
                            let v2336 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v2296 v2335 
                            let v2337 : string = "inline_colorization::color_reset"
                            let v2338 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v2337 
                            let v2339 : string = "\"{v2334}{v2336}{v2338}\""
                            let v2340 : string = @$"format!(" + v2339 + ")"
                            let v2341 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v2340 
                            let v2342 : string = "fable_library_rust::String_::fromString($0)"
                            let v2343 : string = Fable.Core.RustInterop.emitRustExpr v2341 v2342 
                            let _v2310 = v2343 
                            #endif
#if FABLE_COMPILER_TYPESCRIPT
                            let v2344 : string = "\u001b[90m"
                            let v2345 : string = method7()
                            let v2346 : string = v2344 + v2296 
                            let v2347 : string = v2346 + v2345 
                            let _v2310 = v2347 
                            #endif
#if FABLE_COMPILER_PYTHON
                            let v2348 : string = "\u001b[90m"
                            let v2349 : string = method7()
                            let v2350 : string = v2348 + v2296 
                            let v2351 : string = v2350 + v2349 
                            let _v2310 = v2351 
                            #endif
#else
                            let v2352 : string = "\u001b[90m"
                            let v2353 : string = method7()
                            let v2354 : string = v2352 + v2296 
                            let v2355 : string = v2354 + v2353 
                            let _v2310 = v2355 
                            #endif
                            let v2356 : string = _v2310 
                            let v2362 : int64 = v1858.l0
                            let v2363 : string = method8()
                            let v2364 : Mut4 = {l0 = v2363} : Mut4
                            let v2365 : string = "{ "
                            let v2366 : string = $"{v2365}"
                            let v2369 : string = v2364.l0
                            let v2370 : string = v2369 + v2366 
                            v2364.l0 <- v2370
                            let v2371 : string = "timeout"
                            let v2372 : string = $"{v2371}"
                            let v2375 : string = v2364.l0
                            let v2376 : string = v2375 + v2372 
                            v2364.l0 <- v2376
                            let v2377 : string = " = "
                            let v2378 : string = $"{v2377}"
                            let v2381 : string = v2364.l0
                            let v2382 : string = v2381 + v2378 
                            v2364.l0 <- v2382
                            let v2383 : string = $"{v810}"
                            let v2386 : string = v2364.l0
                            let v2387 : string = v2386 + v2383 
                            v2364.l0 <- v2387
                            let v2388 : string = " }"
                            let v2389 : string = $"{v2388}"
                            let v2392 : string = v2364.l0
                            let v2393 : string = v2392 + v2389 
                            v2364.l0 <- v2393
                            let v2394 : string = v2364.l0
                            let v2395 : (unit -> string) = closure9()
                            let v2396 : string = $"{v2226} {v2356} #{v2362} %s{v2395 ()} / {v2394}"
                            let v2399 : char list = []
                            let v2400 : (char list -> (char [])) = List.toArray
                            let v2401 : (char []) = v2400 v2399
                            let v2404 : string = v2396.TrimStart v2401 
                            let v2422 : char list = []
                            let v2423 : char list = '/' :: v2422 
                            let v2426 : char list = ' ' :: v2423 
                            let v2429 : (char list -> (char [])) = List.toArray
                            let v2430 : (char []) = v2429 v2426
                            let v2433 : string = v2404.TrimEnd v2430 
                            let v2451 : unit = ()
                            
#if FABLE_COMPILER || WASM || CONTRACT
                            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                            let v2452 : string = @"println!(""{}"", $0)"
                            Fable.Core.RustInterop.emitRustExpr v2433 v2452 
                            let _v2451 = () 
                            #endif
#if FABLE_COMPILER_RUST && WASM
                            let v2453 : string = @"println!(""{}"", $0)"
                            Fable.Core.RustInterop.emitRustExpr v2433 v2453 
                            let _v2451 = () 
                            #endif
#if FABLE_COMPILER_RUST && CONTRACT
                            let v2454 : string = $"near_sdk::log!(\"{{}}\", $0)"
                            Fable.Core.RustInterop.emitRustExpr v2433 v2454 
                            let _v2451 = () 
                            #endif
#if FABLE_COMPILER_TYPESCRIPT
                            System.Console.WriteLine v2433 
                            let _v2451 = () 
                            #endif
#if FABLE_COMPILER_PYTHON
                            System.Console.WriteLine v2433 
                            let _v2451 = () 
                            #endif
#else
                            System.Console.WriteLine v2433 
                            let _v2451 = () 
                            #endif
                            _v2451 
                            let v2455 : (string -> unit) = v1797.l0
                            v2455 v2433
                        US4_1
                    else
                        let v2457 : bool = State.trace_state.IsNone
                        if v2457 then
                            let v2458 : US0 = US0_0
                            let struct (v2459 : Mut0, v2460 : Mut1, v2461 : Mut2, v2462 : Mut3, v2463 : int64 option) = method0(v2458)
                            let v2464 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v2459, v2460, v2461, v2462, v2463) 
                            State.trace_state <- v2464 
                            ()
                        let struct (v2469 : Mut0, v2470 : Mut1, v2471 : Mut2, v2472 : Mut3, v2473 : int64 option) = State.trace_state.Value
                        let v2484 : bool = State.trace_state.IsNone
                        if v2484 then
                            let v2485 : US0 = US0_0
                            let struct (v2486 : Mut0, v2487 : Mut1, v2488 : Mut2, v2489 : Mut3, v2490 : int64 option) = method0(v2485)
                            let v2491 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v2486, v2487, v2488, v2489, v2490) 
                            State.trace_state <- v2491 
                            ()
                        let struct (v2496 : Mut0, v2497 : Mut1, v2498 : Mut2, v2499 : Mut3, v2500 : int64 option) = State.trace_state.Value
                        let v2511 : US0 = v2499.l0
                        let v2512 : bool = v2498.l0
                        let v2513 : bool = v2512 = false
                        let v2516 : bool =
                            if v2513 then
                                false
                            else
                                let v2514 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v2511
                                let v2515 : bool = 4 >= v2514
                                v2515
                        if v2516 then
                            let v2517 : int64 = v2469.l0
                            let v2518 : int64 = v2517 + 1L
                            v2469.l0 <- v2518
                            let v2519 : bool = State.trace_state.IsNone
                            if v2519 then
                                let v2520 : US0 = US0_0
                                let struct (v2521 : Mut0, v2522 : Mut1, v2523 : Mut2, v2524 : Mut3, v2525 : int64 option) = method0(v2520)
                                let v2526 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v2521, v2522, v2523, v2524, v2525) 
                                State.trace_state <- v2526 
                                ()
                            let struct (v2531 : Mut0, v2532 : Mut1, v2533 : Mut2, v2534 : Mut3, v2535 : int64 option) = State.trace_state.Value
                            let v2546 : unit = ()
                            
#if FABLE_COMPILER || WASM || CONTRACT
                            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                            let v2547 : US3 option = None
                            let _v2547 = ref v2547 
                            match v2535 with
                            | Some x -> (
                            (fun () ->
                            (fun () ->
                            let v2548 : int64 = x
                            let v2549 : US3 = US3_0(v2548)
                            v2549 
                            )
                            |> fun x -> x () |> Some
                            ) () ) | None -> None
                            |> fun x -> _v2547.Value <- x
                            let v2550 : US3 option = _v2547.Value 
                            let v2561 : US3 = US3_1
                            let v2562 : US3 = v2550 |> Option.defaultValue v2561 
                            let v2602 : System.DateTime =
                                match v2562 with
                                | US3_1 -> (* None *)
                                    let v2598 : System.DateTime = System.DateTime.Now
                                    v2598
                                | US3_0(v2566) -> (* Some *)
                                    let v2567 : System.DateTime = System.DateTime.Now
                                    let v2570 : (System.DateTime -> int64) = _.Ticks
                                    let v2571 : int64 = v2570 v2567
                                    let v2574 : int64 = v2571 - v2566
                                    let v2575 : (int64 -> System.TimeSpan) = System.TimeSpan 
                                    let v2576 : System.TimeSpan = v2575 v2574
                                    let v2579 : (System.TimeSpan -> int32) = _.Hours
                                    let v2580 : int32 = v2579 v2576
                                    let v2583 : (System.TimeSpan -> int32) = _.Minutes
                                    let v2584 : int32 = v2583 v2576
                                    let v2587 : (System.TimeSpan -> int32) = _.Seconds
                                    let v2588 : int32 = v2587 v2576
                                    let v2591 : (System.TimeSpan -> int32) = _.Milliseconds
                                    let v2592 : int32 = v2591 v2576
                                    let v2595 : System.DateTime = System.DateTime (1, 1, 1, v2580, v2584, v2588, v2592)
                                    v2595
                            let v2603 : string = method5()
                            let v2606 : (string -> string) = v2602.ToString
                            let v2607 : string = v2606 v2603
                            let _v2546 = v2607 
                            #endif
#if FABLE_COMPILER_RUST && WASM
                            let v2610 : US3 option = None
                            let _v2610 = ref v2610 
                            match v2535 with
                            | Some x -> (
                            (fun () ->
                            (fun () ->
                            let v2611 : int64 = x
                            let v2612 : US3 = US3_0(v2611)
                            v2612 
                            )
                            |> fun x -> x () |> Some
                            ) () ) | None -> None
                            |> fun x -> _v2610.Value <- x
                            let v2613 : US3 option = _v2610.Value 
                            let v2624 : US3 = US3_1
                            let v2625 : US3 = v2613 |> Option.defaultValue v2624 
                            let v2665 : System.DateTime =
                                match v2625 with
                                | US3_1 -> (* None *)
                                    let v2661 : System.DateTime = System.DateTime.Now
                                    v2661
                                | US3_0(v2629) -> (* Some *)
                                    let v2630 : System.DateTime = System.DateTime.Now
                                    let v2633 : (System.DateTime -> int64) = _.Ticks
                                    let v2634 : int64 = v2633 v2630
                                    let v2637 : int64 = v2634 - v2629
                                    let v2638 : (int64 -> System.TimeSpan) = System.TimeSpan 
                                    let v2639 : System.TimeSpan = v2638 v2637
                                    let v2642 : (System.TimeSpan -> int32) = _.Hours
                                    let v2643 : int32 = v2642 v2639
                                    let v2646 : (System.TimeSpan -> int32) = _.Minutes
                                    let v2647 : int32 = v2646 v2639
                                    let v2650 : (System.TimeSpan -> int32) = _.Seconds
                                    let v2651 : int32 = v2650 v2639
                                    let v2654 : (System.TimeSpan -> int32) = _.Milliseconds
                                    let v2655 : int32 = v2654 v2639
                                    let v2658 : System.DateTime = System.DateTime (1, 1, 1, v2643, v2647, v2651, v2655)
                                    v2658
                            let v2666 : string = method5()
                            let v2669 : (string -> string) = v2665.ToString
                            let v2670 : string = v2669 v2666
                            let _v2546 = v2670 
                            #endif
#if FABLE_COMPILER_RUST && CONTRACT
                            let v2673 : string = $"near_sdk::env::block_timestamp()"
                            let v2674 : uint64 = Fable.Core.RustInterop.emitRustExpr () v2673 
                            let v2675 : US3 option = None
                            let _v2675 = ref v2675 
                            match v2535 with
                            | Some x -> (
                            (fun () ->
                            (fun () ->
                            let v2676 : int64 = x
                            let v2677 : US3 = US3_0(v2676)
                            v2677 
                            )
                            |> fun x -> x () |> Some
                            ) () ) | None -> None
                            |> fun x -> _v2675.Value <- x
                            let v2678 : US3 option = _v2675.Value 
                            let v2689 : US3 = US3_1
                            let v2690 : US3 = v2678 |> Option.defaultValue v2689 
                            let v2699 : uint64 =
                                match v2690 with
                                | US3_1 -> (* None *)
                                    v2674
                                | US3_0(v2694) -> (* Some *)
                                    let v2695 : (int64 -> uint64) = uint64
                                    let v2696 : uint64 = v2695 v2694
                                    let v2697 : uint64 = v2674 - v2696
                                    v2697
                            let v2700 : uint64 = v2699 / 1000000000UL
                            let v2701 : uint64 = v2700 % 60UL
                            let v2702 : uint64 = v2700 / 60UL
                            let v2703 : uint64 = v2702 % 60UL
                            let v2704 : uint64 = v2700 / 3600UL
                            let v2705 : uint64 = v2704 % 24UL
                            let v2706 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
                            let v2707 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v2705, v2703, v2701) v2706 
                            let v2708 : string = "fable_library_rust::String_::fromString($0)"
                            let v2709 : string = Fable.Core.RustInterop.emitRustExpr v2707 v2708 
                            let _v2546 = v2709 
                            #endif
#if FABLE_COMPILER_TYPESCRIPT
                            let v2710 : US3 option = None
                            let _v2710 = ref v2710 
                            match v2535 with
                            | Some x -> (
                            (fun () ->
                            (fun () ->
                            let v2711 : int64 = x
                            let v2712 : US3 = US3_0(v2711)
                            v2712 
                            )
                            |> fun x -> x () |> Some
                            ) () ) | None -> None
                            |> fun x -> _v2710.Value <- x
                            let v2713 : US3 option = _v2710.Value 
                            let v2724 : US3 = US3_1
                            let v2725 : US3 = v2713 |> Option.defaultValue v2724 
                            let v2765 : System.DateTime =
                                match v2725 with
                                | US3_1 -> (* None *)
                                    let v2761 : System.DateTime = System.DateTime.Now
                                    v2761
                                | US3_0(v2729) -> (* Some *)
                                    let v2730 : System.DateTime = System.DateTime.Now
                                    let v2733 : (System.DateTime -> int64) = _.Ticks
                                    let v2734 : int64 = v2733 v2730
                                    let v2737 : int64 = v2734 - v2729
                                    let v2738 : (int64 -> System.TimeSpan) = System.TimeSpan 
                                    let v2739 : System.TimeSpan = v2738 v2737
                                    let v2742 : (System.TimeSpan -> int32) = _.Hours
                                    let v2743 : int32 = v2742 v2739
                                    let v2746 : (System.TimeSpan -> int32) = _.Minutes
                                    let v2747 : int32 = v2746 v2739
                                    let v2750 : (System.TimeSpan -> int32) = _.Seconds
                                    let v2751 : int32 = v2750 v2739
                                    let v2754 : (System.TimeSpan -> int32) = _.Milliseconds
                                    let v2755 : int32 = v2754 v2739
                                    let v2758 : System.DateTime = System.DateTime (1, 1, 1, v2743, v2747, v2751, v2755)
                                    v2758
                            let v2766 : string = method6()
                            let v2769 : (string -> string) = v2765.ToString
                            let v2770 : string = v2769 v2766
                            let _v2546 = v2770 
                            #endif
#if FABLE_COMPILER_PYTHON
                            let v2773 : US3 option = None
                            let _v2773 = ref v2773 
                            match v2535 with
                            | Some x -> (
                            (fun () ->
                            (fun () ->
                            let v2774 : int64 = x
                            let v2775 : US3 = US3_0(v2774)
                            v2775 
                            )
                            |> fun x -> x () |> Some
                            ) () ) | None -> None
                            |> fun x -> _v2773.Value <- x
                            let v2776 : US3 option = _v2773.Value 
                            let v2787 : US3 = US3_1
                            let v2788 : US3 = v2776 |> Option.defaultValue v2787 
                            let v2828 : System.DateTime =
                                match v2788 with
                                | US3_1 -> (* None *)
                                    let v2824 : System.DateTime = System.DateTime.Now
                                    v2824
                                | US3_0(v2792) -> (* Some *)
                                    let v2793 : System.DateTime = System.DateTime.Now
                                    let v2796 : (System.DateTime -> int64) = _.Ticks
                                    let v2797 : int64 = v2796 v2793
                                    let v2800 : int64 = v2797 - v2792
                                    let v2801 : (int64 -> System.TimeSpan) = System.TimeSpan 
                                    let v2802 : System.TimeSpan = v2801 v2800
                                    let v2805 : (System.TimeSpan -> int32) = _.Hours
                                    let v2806 : int32 = v2805 v2802
                                    let v2809 : (System.TimeSpan -> int32) = _.Minutes
                                    let v2810 : int32 = v2809 v2802
                                    let v2813 : (System.TimeSpan -> int32) = _.Seconds
                                    let v2814 : int32 = v2813 v2802
                                    let v2817 : (System.TimeSpan -> int32) = _.Milliseconds
                                    let v2818 : int32 = v2817 v2802
                                    let v2821 : System.DateTime = System.DateTime (1, 1, 1, v2806, v2810, v2814, v2818)
                                    v2821
                            let v2829 : string = method6()
                            let v2832 : (string -> string) = v2828.ToString
                            let v2833 : string = v2832 v2829
                            let _v2546 = v2833 
                            #endif
#else
                            let v2836 : US3 option = None
                            let _v2836 = ref v2836 
                            match v2535 with
                            | Some x -> (
                            (fun () ->
                            (fun () ->
                            let v2837 : int64 = x
                            let v2838 : US3 = US3_0(v2837)
                            v2838 
                            )
                            |> fun x -> x () |> Some
                            ) () ) | None -> None
                            |> fun x -> _v2836.Value <- x
                            let v2839 : US3 option = _v2836.Value 
                            let v2850 : US3 = US3_1
                            let v2851 : US3 = v2839 |> Option.defaultValue v2850 
                            let v2891 : System.DateTime =
                                match v2851 with
                                | US3_1 -> (* None *)
                                    let v2887 : System.DateTime = System.DateTime.Now
                                    v2887
                                | US3_0(v2855) -> (* Some *)
                                    let v2856 : System.DateTime = System.DateTime.Now
                                    let v2859 : (System.DateTime -> int64) = _.Ticks
                                    let v2860 : int64 = v2859 v2856
                                    let v2863 : int64 = v2860 - v2855
                                    let v2864 : (int64 -> System.TimeSpan) = System.TimeSpan 
                                    let v2865 : System.TimeSpan = v2864 v2863
                                    let v2868 : (System.TimeSpan -> int32) = _.Hours
                                    let v2869 : int32 = v2868 v2865
                                    let v2872 : (System.TimeSpan -> int32) = _.Minutes
                                    let v2873 : int32 = v2872 v2865
                                    let v2876 : (System.TimeSpan -> int32) = _.Seconds
                                    let v2877 : int32 = v2876 v2865
                                    let v2880 : (System.TimeSpan -> int32) = _.Milliseconds
                                    let v2881 : int32 = v2880 v2865
                                    let v2884 : System.DateTime = System.DateTime (1, 1, 1, v2869, v2873, v2877, v2881)
                                    v2884
                            let v2892 : string = method6()
                            let v2895 : (string -> string) = v2891.ToString
                            let v2896 : string = v2895 v2892
                            let _v2546 = v2896 
                            #endif
                            let v2899 : string = _v2546 
                            let v2964 : string = "Critical"
                            let v2965 : (unit -> string) = v2964.ToLower
                            let v2966 : string = v2965 ()
                            let v2969 : string = v2966.PadLeft (7, ' ')
                            let v2983 : unit = ()
                            
#if FABLE_COMPILER || WASM || CONTRACT
                            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                            let v2984 : string = "inline_colorization::color_bright_red"
                            let v2985 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v2984 
                            let v2986 : string = "&*$0"
                            let v2987 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v2969 v2986 
                            let v2988 : string = "inline_colorization::color_reset"
                            let v2989 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v2988 
                            let v2990 : string = "\"{v2985}{v2987}{v2989}\""
                            let v2991 : string = @$"format!(" + v2990 + ")"
                            let v2992 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v2991 
                            let v2993 : string = "fable_library_rust::String_::fromString($0)"
                            let v2994 : string = Fable.Core.RustInterop.emitRustExpr v2992 v2993 
                            let _v2983 = v2994 
                            #endif
#if FABLE_COMPILER_RUST && WASM
                            let v2995 : string = "inline_colorization::color_bright_red"
                            let v2996 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v2995 
                            let v2997 : string = "&*$0"
                            let v2998 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v2969 v2997 
                            let v2999 : string = "inline_colorization::color_reset"
                            let v3000 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v2999 
                            let v3001 : string = "\"{v2996}{v2998}{v3000}\""
                            let v3002 : string = @$"format!(" + v3001 + ")"
                            let v3003 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v3002 
                            let v3004 : string = "fable_library_rust::String_::fromString($0)"
                            let v3005 : string = Fable.Core.RustInterop.emitRustExpr v3003 v3004 
                            let _v2983 = v3005 
                            #endif
#if FABLE_COMPILER_RUST && CONTRACT
                            let v3006 : string = "inline_colorization::color_bright_red"
                            let v3007 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v3006 
                            let v3008 : string = "&*$0"
                            let v3009 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v2969 v3008 
                            let v3010 : string = "inline_colorization::color_reset"
                            let v3011 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v3010 
                            let v3012 : string = "\"{v3007}{v3009}{v3011}\""
                            let v3013 : string = @$"format!(" + v3012 + ")"
                            let v3014 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v3013 
                            let v3015 : string = "fable_library_rust::String_::fromString($0)"
                            let v3016 : string = Fable.Core.RustInterop.emitRustExpr v3014 v3015 
                            let _v2983 = v3016 
                            #endif
#if FABLE_COMPILER_TYPESCRIPT
                            let v3017 : string = "\u001b[91m"
                            let v3018 : string = method7()
                            let v3019 : string = v3017 + v2969 
                            let v3020 : string = v3019 + v3018 
                            let _v2983 = v3020 
                            #endif
#if FABLE_COMPILER_PYTHON
                            let v3021 : string = "\u001b[91m"
                            let v3022 : string = method7()
                            let v3023 : string = v3021 + v2969 
                            let v3024 : string = v3023 + v3022 
                            let _v2983 = v3024 
                            #endif
#else
                            let v3025 : string = "\u001b[91m"
                            let v3026 : string = method7()
                            let v3027 : string = v3025 + v2969 
                            let v3028 : string = v3027 + v3026 
                            let _v2983 = v3028 
                            #endif
                            let v3029 : string = _v2983 
                            let v3035 : int64 = v2531.l0
                            let v3036 : unit = ()
                            
#if FABLE_COMPILER || WASM || CONTRACT
                            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                            let v3037 : string = $"%A{v1776}"
                            let _v3036 = v3037 
                            #endif
#if FABLE_COMPILER_RUST && WASM
                            let v3040 : string = $"%A{v1776}"
                            let _v3036 = v3040 
                            #endif
#if FABLE_COMPILER_RUST && CONTRACT
                            let v3043 : string = $"%A{v1776}"
                            let _v3036 = v3043 
                            #endif
#if FABLE_COMPILER_TYPESCRIPT
                            let v3046 : string = $"%A{v1776}"
                            let _v3036 = v3046 
                            #endif
#if FABLE_COMPILER_PYTHON
                            let v3049 : string = $"%A{v1776}"
                            let _v3036 = v3049 
                            #endif
#else
                            let v3052 : string = $"{v1776.GetType ()}: {v1776.Message}"
                            let _v3036 = v3052 
                            #endif
                            let v3053 : string = _v3036 
                            let v3058 : string = method8()
                            let v3059 : Mut4 = {l0 = v3058} : Mut4
                            let v3060 : string = "{ "
                            let v3061 : string = $"{v3060}"
                            let v3064 : string = v3059.l0
                            let v3065 : string = v3064 + v3061 
                            v3059.l0 <- v3065
                            let v3066 : string = "timeout"
                            let v3067 : string = $"{v3066}"
                            let v3070 : string = v3059.l0
                            let v3071 : string = v3070 + v3067 
                            v3059.l0 <- v3071
                            let v3072 : string = " = "
                            let v3073 : string = $"{v3072}"
                            let v3076 : string = v3059.l0
                            let v3077 : string = v3076 + v3073 
                            v3059.l0 <- v3077
                            let v3078 : string = $"{v810}"
                            let v3081 : string = v3059.l0
                            let v3082 : string = v3081 + v3078 
                            v3059.l0 <- v3082
                            let v3083 : string = "; "
                            let v3084 : string = $"{v3083}"
                            let v3087 : string = v3059.l0
                            let v3088 : string = v3087 + v3084 
                            v3059.l0 <- v3088
                            let v3089 : string = "ex"
                            let v3090 : string = $"{v3089}"
                            let v3093 : string = v3059.l0
                            let v3094 : string = v3093 + v3090 
                            v3059.l0 <- v3094
                            let v3095 : string = $"{v3072}"
                            let v3098 : string = v3059.l0
                            let v3099 : string = v3098 + v3095 
                            v3059.l0 <- v3099
                            let v3100 : string = $"{v3053}"
                            let v3103 : string = v3059.l0
                            let v3104 : string = v3103 + v3100 
                            v3059.l0 <- v3104
                            let v3105 : string = " }"
                            let v3106 : string = $"{v3105}"
                            let v3109 : string = v3059.l0
                            let v3110 : string = v3109 + v3106 
                            v3059.l0 <- v3110
                            let v3111 : string = v3059.l0
                            let v3112 : (unit -> string) = closure10()
                            let v3113 : string = $"{v2899} {v3029} #{v3035} %s{v3112 ()} / {v3111}"
                            let v3116 : char list = []
                            let v3117 : (char list -> (char [])) = List.toArray
                            let v3118 : (char []) = v3117 v3116
                            let v3121 : string = v3113.TrimStart v3118 
                            let v3139 : char list = []
                            let v3140 : char list = '/' :: v3139 
                            let v3143 : char list = ' ' :: v3140 
                            let v3146 : (char list -> (char [])) = List.toArray
                            let v3147 : (char []) = v3146 v3143
                            let v3150 : string = v3121.TrimEnd v3147 
                            let v3168 : unit = ()
                            
#if FABLE_COMPILER || WASM || CONTRACT
                            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                            let v3169 : string = @"println!(""{}"", $0)"
                            Fable.Core.RustInterop.emitRustExpr v3150 v3169 
                            let _v3168 = () 
                            #endif
#if FABLE_COMPILER_RUST && WASM
                            let v3170 : string = @"println!(""{}"", $0)"
                            Fable.Core.RustInterop.emitRustExpr v3150 v3170 
                            let _v3168 = () 
                            #endif
#if FABLE_COMPILER_RUST && CONTRACT
                            let v3171 : string = $"near_sdk::log!(\"{{}}\", $0)"
                            Fable.Core.RustInterop.emitRustExpr v3150 v3171 
                            let _v3168 = () 
                            #endif
#if FABLE_COMPILER_TYPESCRIPT
                            System.Console.WriteLine v3150 
                            let _v3168 = () 
                            #endif
#if FABLE_COMPILER_PYTHON
                            System.Console.WriteLine v3150 
                            let _v3168 = () 
                            #endif
#else
                            System.Console.WriteLine v3150 
                            let _v3168 = () 
                            #endif
                            _v3168 
                            let v3172 : (string -> unit) = v2470.l0
                            v3172 v3150
                        US4_1
                | US6_0(v1774) -> (* Ok *)
                    US4_0(v1774)
            return v3176 
            }
            |> fun x -> _v1772 <- Some x
            let v3177 : Async<US4> = match _v1772 with Some x -> x | None -> failwith "async.new_async_unit / _v1772=None"
            let _v1756 = v3177 
            #endif
            let v3178 : Async<US4> = _v1756 
            return! v3178 
            }
            |> fun x -> _v1631 <- Some x
            let v3183 : Async<US4> = match _v1631 with Some x -> x | None -> failwith "async.new_async_unit / _v1631=None"
            let _v1615 = v3183 
            #endif
            let v3184 : Async<US4> = _v1615 
            let _v1599 = v3184 
            #endif
            let v3189 : Async<US4> = _v1599 
            let! v3189 = v3189 
            let v3194 : US4 = v3189 
            let v3197 : bool =
                match v3194 with
                | US4_1 -> (* None *)
                    false
                | US4_0(v3195) -> (* Some *)
                    v3195
            return v3197 
            }
            |> fun x -> _v827 <- Some x
            let v3198 : Async<bool> = match _v827 with Some x -> x | None -> failwith "async.new_async_unit / _v827=None"
            let _v811 = v3198 
            #endif
            let v3199 : Async<bool> = _v811 
            v3199
    let! v3205 = v3205 
    let v3206 : bool = v3205 
    let v3207 : bool = v3206 = false
    if v3207 then
        return v2 
        (*
        ()
    else
        *) else
        let v3208 : int32 = v2 + 1
        let v3209 : Async<int32> = method10(v0, v1, v3208)
        return! v3209 
        (*
        ()
    *)
    }
    |> fun x -> _v19 <- Some x
    let v3210 : Async<int32> = match _v19 with Some x -> x | None -> failwith "async.new_async_unit / _v19=None"
    let _v3 = v3210 
    #endif
    let v3211 : Async<int32> = _v3 
    v3211
and closure18 (v0 : int32 option, v1 : string) (v2 : int32) : Async<int32> =
    method10(v0, v1, v2)
and closure17 (v0 : int32 option) (v1 : string) : (int32 -> Async<int32>) =
    closure18(v0, v1)
and closure16 () (v0 : int32 option) : (string -> (int32 -> Async<int32>)) =
    closure17(v0)
let v0 : bool = State.trace_state.IsNone
if v0 then
    let v1 : US0 = US0_0
    let struct (v2 : Mut0, v3 : Mut1, v4 : Mut2, v5 : Mut3, v6 : int64 option) = method0(v1)
    let v7 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v2, v3, v4, v5, v6) 
    State.trace_state <- v7 
    ()
let v12 : (string -> (int32 -> Async<bool>)) = closure1()
let test_port_open x = v12 x
let v13 : (int32 -> (string -> (int32 -> Async<bool>))) = closure4()
let test_port_open_timeout x = v13 x
let v14 : (int32 option -> (bool -> (string -> (int32 -> Async<int64>)))) = closure11()
let wait_for_port_access x = v14 x
let v15 : (int32 option -> (string -> (int32 -> Async<int32>))) = closure16()
let get_available_port x = v15 x
()
