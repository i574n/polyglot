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
and closure3 (v0 : US0, v1 : (unit -> string)) (v2 : (unit -> string)) : unit =
    let v3 : bool = State.trace_state.IsNone
    if v3 then
        let v4 : US0 = US0_0
        let struct (v5 : Mut0, v6 : Mut1, v7 : Mut2, v8 : Mut3, v9 : int64 option) = method0(v4)
        let v10 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v5, v6, v7, v8, v9) 
        State.trace_state <- v10 
        ()
    let struct (v15 : Mut0, v16 : Mut1, v17 : Mut2, v18 : Mut3, v19 : int64 option) = State.trace_state.Value
    let v30 : bool = State.trace_state.IsNone
    if v30 then
        let v31 : US0 = US0_0
        let struct (v32 : Mut0, v33 : Mut1, v34 : Mut2, v35 : Mut3, v36 : int64 option) = method0(v31)
        let v37 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v32, v33, v34, v35, v36) 
        State.trace_state <- v37 
        ()
    let struct (v42 : Mut0, v43 : Mut1, v44 : Mut2, v45 : Mut3, v46 : int64 option) = State.trace_state.Value
    let v57 : US0 = v45.l0
    let v58 : bool = v44.l0
    let v59 : bool = v58 = false
    let v63 : bool =
        if v59 then
            false
        else
            let v60 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v0
            let v61 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v57
            let v62 : bool = v60 >= v61
            v62
    if v63 then
        let v64 : int64 = v15.l0
        let v65 : int64 = v64 + 1L
        v15.l0 <- v65
        let v66 : bool = State.trace_state.IsNone
        if v66 then
            let v67 : US0 = US0_0
            let struct (v68 : Mut0, v69 : Mut1, v70 : Mut2, v71 : Mut3, v72 : int64 option) = method0(v67)
            let v73 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v68, v69, v70, v71, v72) 
            State.trace_state <- v73 
            ()
        let struct (v78 : Mut0, v79 : Mut1, v80 : Mut2, v81 : Mut3, v82 : int64 option) = State.trace_state.Value
        let v93 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v94 : US3 option = None
        let _v94 = ref v94 
        match v82 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v95 : int64 = x
        let v96 : US3 = US3_0(v95)
        v96 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v94.Value <- x
        let v97 : US3 option = _v94.Value 
        let v108 : US3 = US3_1
        let v109 : US3 = v97 |> Option.defaultValue v108 
        let v149 : System.DateTime =
            match v109 with
            | US3_1 -> (* None *)
                let v145 : System.DateTime = System.DateTime.Now
                v145
            | US3_0(v113) -> (* Some *)
                let v114 : System.DateTime = System.DateTime.Now
                let v117 : (System.DateTime -> int64) = _.Ticks
                let v118 : int64 = v117 v114
                let v121 : int64 = v118 - v113
                let v122 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v123 : System.TimeSpan = v122 v121
                let v126 : (System.TimeSpan -> int32) = _.Hours
                let v127 : int32 = v126 v123
                let v130 : (System.TimeSpan -> int32) = _.Minutes
                let v131 : int32 = v130 v123
                let v134 : (System.TimeSpan -> int32) = _.Seconds
                let v135 : int32 = v134 v123
                let v138 : (System.TimeSpan -> int32) = _.Milliseconds
                let v139 : int32 = v138 v123
                let v142 : System.DateTime = System.DateTime (1, 1, 1, v127, v131, v135, v139)
                v142
        let v150 : string = method5()
        let v153 : (string -> string) = v149.ToString
        let v154 : string = v153 v150
        let _v93 = v154 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v157 : US3 option = None
        let _v157 = ref v157 
        match v82 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v158 : int64 = x
        let v159 : US3 = US3_0(v158)
        v159 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v157.Value <- x
        let v160 : US3 option = _v157.Value 
        let v171 : US3 = US3_1
        let v172 : US3 = v160 |> Option.defaultValue v171 
        let v212 : System.DateTime =
            match v172 with
            | US3_1 -> (* None *)
                let v208 : System.DateTime = System.DateTime.Now
                v208
            | US3_0(v176) -> (* Some *)
                let v177 : System.DateTime = System.DateTime.Now
                let v180 : (System.DateTime -> int64) = _.Ticks
                let v181 : int64 = v180 v177
                let v184 : int64 = v181 - v176
                let v185 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v186 : System.TimeSpan = v185 v184
                let v189 : (System.TimeSpan -> int32) = _.Hours
                let v190 : int32 = v189 v186
                let v193 : (System.TimeSpan -> int32) = _.Minutes
                let v194 : int32 = v193 v186
                let v197 : (System.TimeSpan -> int32) = _.Seconds
                let v198 : int32 = v197 v186
                let v201 : (System.TimeSpan -> int32) = _.Milliseconds
                let v202 : int32 = v201 v186
                let v205 : System.DateTime = System.DateTime (1, 1, 1, v190, v194, v198, v202)
                v205
        let v213 : string = method5()
        let v216 : (string -> string) = v212.ToString
        let v217 : string = v216 v213
        let _v93 = v217 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v220 : string = $"near_sdk::env::block_timestamp()"
        let v221 : uint64 = Fable.Core.RustInterop.emitRustExpr () v220 
        let v222 : US3 option = None
        let _v222 = ref v222 
        match v82 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v223 : int64 = x
        let v224 : US3 = US3_0(v223)
        v224 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v222.Value <- x
        let v225 : US3 option = _v222.Value 
        let v236 : US3 = US3_1
        let v237 : US3 = v225 |> Option.defaultValue v236 
        let v246 : uint64 =
            match v237 with
            | US3_1 -> (* None *)
                v221
            | US3_0(v241) -> (* Some *)
                let v242 : (int64 -> uint64) = uint64
                let v243 : uint64 = v242 v241
                let v244 : uint64 = v221 - v243
                v244
        let v247 : uint64 = v246 / 1000000000UL
        let v248 : uint64 = v247 % 60UL
        let v249 : uint64 = v247 / 60UL
        let v250 : uint64 = v249 % 60UL
        let v251 : uint64 = v247 / 3600UL
        let v252 : uint64 = v251 % 24UL
        let v253 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
        let v254 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v252, v250, v248) v253 
        let v255 : string = "fable_library_rust::String_::fromString($0)"
        let v256 : string = Fable.Core.RustInterop.emitRustExpr v254 v255 
        let _v93 = v256 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v257 : US3 option = None
        let _v257 = ref v257 
        match v82 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v258 : int64 = x
        let v259 : US3 = US3_0(v258)
        v259 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v257.Value <- x
        let v260 : US3 option = _v257.Value 
        let v271 : US3 = US3_1
        let v272 : US3 = v260 |> Option.defaultValue v271 
        let v312 : System.DateTime =
            match v272 with
            | US3_1 -> (* None *)
                let v308 : System.DateTime = System.DateTime.Now
                v308
            | US3_0(v276) -> (* Some *)
                let v277 : System.DateTime = System.DateTime.Now
                let v280 : (System.DateTime -> int64) = _.Ticks
                let v281 : int64 = v280 v277
                let v284 : int64 = v281 - v276
                let v285 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v286 : System.TimeSpan = v285 v284
                let v289 : (System.TimeSpan -> int32) = _.Hours
                let v290 : int32 = v289 v286
                let v293 : (System.TimeSpan -> int32) = _.Minutes
                let v294 : int32 = v293 v286
                let v297 : (System.TimeSpan -> int32) = _.Seconds
                let v298 : int32 = v297 v286
                let v301 : (System.TimeSpan -> int32) = _.Milliseconds
                let v302 : int32 = v301 v286
                let v305 : System.DateTime = System.DateTime (1, 1, 1, v290, v294, v298, v302)
                v305
        let v313 : string = method6()
        let v316 : (string -> string) = v312.ToString
        let v317 : string = v316 v313
        let _v93 = v317 
        #endif
#if FABLE_COMPILER_PYTHON
        let v320 : US3 option = None
        let _v320 = ref v320 
        match v82 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v321 : int64 = x
        let v322 : US3 = US3_0(v321)
        v322 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v320.Value <- x
        let v323 : US3 option = _v320.Value 
        let v334 : US3 = US3_1
        let v335 : US3 = v323 |> Option.defaultValue v334 
        let v375 : System.DateTime =
            match v335 with
            | US3_1 -> (* None *)
                let v371 : System.DateTime = System.DateTime.Now
                v371
            | US3_0(v339) -> (* Some *)
                let v340 : System.DateTime = System.DateTime.Now
                let v343 : (System.DateTime -> int64) = _.Ticks
                let v344 : int64 = v343 v340
                let v347 : int64 = v344 - v339
                let v348 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v349 : System.TimeSpan = v348 v347
                let v352 : (System.TimeSpan -> int32) = _.Hours
                let v353 : int32 = v352 v349
                let v356 : (System.TimeSpan -> int32) = _.Minutes
                let v357 : int32 = v356 v349
                let v360 : (System.TimeSpan -> int32) = _.Seconds
                let v361 : int32 = v360 v349
                let v364 : (System.TimeSpan -> int32) = _.Milliseconds
                let v365 : int32 = v364 v349
                let v368 : System.DateTime = System.DateTime (1, 1, 1, v353, v357, v361, v365)
                v368
        let v376 : string = method6()
        let v379 : (string -> string) = v375.ToString
        let v380 : string = v379 v376
        let _v93 = v380 
        #endif
#else
        let v383 : US3 option = None
        let _v383 = ref v383 
        match v82 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v384 : int64 = x
        let v385 : US3 = US3_0(v384)
        v385 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v383.Value <- x
        let v386 : US3 option = _v383.Value 
        let v397 : US3 = US3_1
        let v398 : US3 = v386 |> Option.defaultValue v397 
        let v438 : System.DateTime =
            match v398 with
            | US3_1 -> (* None *)
                let v434 : System.DateTime = System.DateTime.Now
                v434
            | US3_0(v402) -> (* Some *)
                let v403 : System.DateTime = System.DateTime.Now
                let v406 : (System.DateTime -> int64) = _.Ticks
                let v407 : int64 = v406 v403
                let v410 : int64 = v407 - v402
                let v411 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v412 : System.TimeSpan = v411 v410
                let v415 : (System.TimeSpan -> int32) = _.Hours
                let v416 : int32 = v415 v412
                let v419 : (System.TimeSpan -> int32) = _.Minutes
                let v420 : int32 = v419 v412
                let v423 : (System.TimeSpan -> int32) = _.Seconds
                let v424 : int32 = v423 v412
                let v427 : (System.TimeSpan -> int32) = _.Milliseconds
                let v428 : int32 = v427 v412
                let v431 : System.DateTime = System.DateTime (1, 1, 1, v416, v420, v424, v428)
                v431
        let v439 : string = method6()
        let v442 : (string -> string) = v438.ToString
        let v443 : string = v442 v439
        let _v93 = v443 
        #endif
        let v446 : string = _v93 
        let v511 : bool =
            match v0 with
            | US0_0 -> (* Verbose *)
                true
            | _ ->
                false
        let v515 : US1 =
            if v511 then
                let v512 : string = "Verbose"
                US1_0(v512)
            else
                US1_1
        let v556 : US1 =
            match v515 with
            | US1_1 -> (* None *)
                let v518 : bool =
                    match v0 with
                    | US0_1 -> (* Debug *)
                        true
                    | _ ->
                        false
                let v522 : US1 =
                    if v518 then
                        let v519 : string = "Debug"
                        US1_0(v519)
                    else
                        US1_1
                match v522 with
                | US1_1 -> (* None *)
                    let v525 : bool =
                        match v0 with
                        | US0_2 -> (* Info *)
                            true
                        | _ ->
                            false
                    let v529 : US1 =
                        if v525 then
                            let v526 : string = "Info"
                            US1_0(v526)
                        else
                            US1_1
                    match v529 with
                    | US1_1 -> (* None *)
                        let v532 : bool =
                            match v0 with
                            | US0_3 -> (* Warning *)
                                true
                            | _ ->
                                false
                        let v536 : US1 =
                            if v532 then
                                let v533 : string = "Warning"
                                US1_0(v533)
                            else
                                US1_1
                        match v536 with
                        | US1_1 -> (* None *)
                            let v539 : bool =
                                match v0 with
                                | US0_4 -> (* Critical *)
                                    true
                                | _ ->
                                    false
                            let v543 : US1 =
                                if v539 then
                                    let v540 : string = "Critical"
                                    US1_0(v540)
                                else
                                    US1_1
                            match v543 with
                            | US1_1 -> (* None *)
                                US1_1
                            | US1_0(v544) -> (* Some *)
                                US1_0(v544)
                        | US1_0(v537) -> (* Some *)
                            US1_0(v537)
                    | US1_0(v530) -> (* Some *)
                        US1_0(v530)
                | US1_0(v523) -> (* Some *)
                    US1_0(v523)
            | US1_0(v516) -> (* Some *)
                US1_0(v516)
        let v560 : string =
            match v556 with
            | US1_1 -> (* None *)
                failwith<string> "Option does not have a value."
            | US1_0(v557) -> (* Some *)
                v557
        let v561 : (unit -> string) = v560.ToLower
        let v562 : string = v561 ()
        let v565 : string = v562.PadLeft (7, ' ')
        let v579 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v594 : Ref<Str> =
            match v0 with
            | US0_4 -> (* Critical *)
                let v588 : string = "inline_colorization::color_bright_red"
                let v589 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v588 
                v589
            | US0_1 -> (* Debug *)
                let v582 : string = "inline_colorization::color_bright_blue"
                let v583 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v582 
                v583
            | US0_2 -> (* Info *)
                let v584 : string = "inline_colorization::color_bright_green"
                let v585 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v584 
                v585
            | US0_0 -> (* Verbose *)
                let v580 : string = "inline_colorization::color_bright_black"
                let v581 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v580 
                v581
            | US0_3 -> (* Warning *)
                let v586 : string = "inline_colorization::color_yellow"
                let v587 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v586 
                v587
        let v595 : string = "&*$0"
        let v596 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v565 v595 
        let v597 : string = "inline_colorization::color_reset"
        let v598 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v597 
        let v599 : string = "\"{v594}{v596}{v598}\""
        let v600 : string = @$"format!(" + v599 + ")"
        let v601 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v600 
        let v602 : string = "fable_library_rust::String_::fromString($0)"
        let v603 : string = Fable.Core.RustInterop.emitRustExpr v601 v602 
        let _v579 = v603 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v618 : Ref<Str> =
            match v0 with
            | US0_4 -> (* Critical *)
                let v612 : string = "inline_colorization::color_bright_red"
                let v613 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v612 
                v613
            | US0_1 -> (* Debug *)
                let v606 : string = "inline_colorization::color_bright_blue"
                let v607 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v606 
                v607
            | US0_2 -> (* Info *)
                let v608 : string = "inline_colorization::color_bright_green"
                let v609 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v608 
                v609
            | US0_0 -> (* Verbose *)
                let v604 : string = "inline_colorization::color_bright_black"
                let v605 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v604 
                v605
            | US0_3 -> (* Warning *)
                let v610 : string = "inline_colorization::color_yellow"
                let v611 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v610 
                v611
        let v619 : string = "&*$0"
        let v620 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v565 v619 
        let v621 : string = "inline_colorization::color_reset"
        let v622 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v621 
        let v623 : string = "\"{v618}{v620}{v622}\""
        let v624 : string = @$"format!(" + v623 + ")"
        let v625 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v624 
        let v626 : string = "fable_library_rust::String_::fromString($0)"
        let v627 : string = Fable.Core.RustInterop.emitRustExpr v625 v626 
        let _v579 = v627 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v642 : Ref<Str> =
            match v0 with
            | US0_4 -> (* Critical *)
                let v636 : string = "inline_colorization::color_bright_red"
                let v637 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v636 
                v637
            | US0_1 -> (* Debug *)
                let v630 : string = "inline_colorization::color_bright_blue"
                let v631 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v630 
                v631
            | US0_2 -> (* Info *)
                let v632 : string = "inline_colorization::color_bright_green"
                let v633 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v632 
                v633
            | US0_0 -> (* Verbose *)
                let v628 : string = "inline_colorization::color_bright_black"
                let v629 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v628 
                v629
            | US0_3 -> (* Warning *)
                let v634 : string = "inline_colorization::color_yellow"
                let v635 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v634 
                v635
        let v643 : string = "&*$0"
        let v644 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v565 v643 
        let v645 : string = "inline_colorization::color_reset"
        let v646 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v645 
        let v647 : string = "\"{v642}{v644}{v646}\""
        let v648 : string = @$"format!(" + v647 + ")"
        let v649 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v648 
        let v650 : string = "fable_library_rust::String_::fromString($0)"
        let v651 : string = Fable.Core.RustInterop.emitRustExpr v649 v650 
        let _v579 = v651 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v661 : string =
            match v0 with
            | US0_4 -> (* Critical *)
                let v656 : string = "\u001b[91m"
                v656
            | US0_1 -> (* Debug *)
                let v653 : string = "\u001b[94m"
                v653
            | US0_2 -> (* Info *)
                let v654 : string = "\u001b[92m"
                v654
            | US0_0 -> (* Verbose *)
                let v652 : string = "\u001b[90m"
                v652
            | US0_3 -> (* Warning *)
                let v655 : string = "\u001b[93m"
                v655
        let v662 : string = method7()
        let v663 : string = v661 + v565 
        let v664 : string = v663 + v662 
        let _v579 = v664 
        #endif
#if FABLE_COMPILER_PYTHON
        let v674 : string =
            match v0 with
            | US0_4 -> (* Critical *)
                let v669 : string = "\u001b[91m"
                v669
            | US0_1 -> (* Debug *)
                let v666 : string = "\u001b[94m"
                v666
            | US0_2 -> (* Info *)
                let v667 : string = "\u001b[92m"
                v667
            | US0_0 -> (* Verbose *)
                let v665 : string = "\u001b[90m"
                v665
            | US0_3 -> (* Warning *)
                let v668 : string = "\u001b[93m"
                v668
        let v675 : string = method7()
        let v676 : string = v674 + v565 
        let v677 : string = v676 + v675 
        let _v579 = v677 
        #endif
#else
        let v687 : string =
            match v0 with
            | US0_4 -> (* Critical *)
                let v682 : string = "\u001b[91m"
                v682
            | US0_1 -> (* Debug *)
                let v679 : string = "\u001b[94m"
                v679
            | US0_2 -> (* Info *)
                let v680 : string = "\u001b[92m"
                v680
            | US0_0 -> (* Verbose *)
                let v678 : string = "\u001b[90m"
                v678
            | US0_3 -> (* Warning *)
                let v681 : string = "\u001b[93m"
                v681
        let v688 : string = method7()
        let v689 : string = v687 + v565 
        let v690 : string = v689 + v688 
        let _v579 = v690 
        #endif
        let v691 : string = _v579 
        let v706 : int64 = v78.l0
        let v707 : string = v2 ()
        let v708 : string = method8()
        let v709 : Mut4 = {l0 = v708} : Mut4
        let v710 : string = $"{v707}"
        let v713 : string = v709.l0
        let v714 : string = v713 + v710 
        v709.l0 <- v714
        let v715 : string = v709.l0
        let v716 : string = $"{v446} {v691} #{v706} %s{v1 ()} / {v715}"
        let v719 : char list = []
        let v720 : (char list -> (char [])) = List.toArray
        let v721 : (char []) = v720 v719
        let v724 : string = v716.TrimStart v721 
        let v742 : char list = []
        let v743 : char list = '/' :: v742 
        let v746 : char list = ' ' :: v743 
        let v749 : (char list -> (char [])) = List.toArray
        let v750 : (char []) = v749 v746
        let v753 : string = v724.TrimEnd v750 
        let v771 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v772 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v753 v772 
        let _v771 = () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v773 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v753 v773 
        let _v771 = () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v774 : string = $"near_sdk::log!(\"{{}}\", $0)"
        Fable.Core.RustInterop.emitRustExpr v753 v774 
        let _v771 = () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        System.Console.WriteLine v753 
        let _v771 = () 
        #endif
#if FABLE_COMPILER_PYTHON
        System.Console.WriteLine v753 
        let _v771 = () 
        #endif
#else
        System.Console.WriteLine v753 
        let _v771 = () 
        #endif
        _v771 
        let v775 : (string -> unit) = v16.l0
        v775 v753
and closure2 (v0 : US0) (v1 : (unit -> string)) : ((unit -> string) -> unit) =
    closure3(v0, v1)
and closure1 () (v0 : US0) : ((unit -> string) -> ((unit -> string) -> unit)) =
    closure2(v0)
let v0 : bool = State.trace_state.IsNone
if v0 then
    let v1 : US0 = US0_0
    let struct (v2 : Mut0, v3 : Mut1, v4 : Mut2, v5 : Mut3, v6 : int64 option) = method0(v1)
    let v7 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v2, v3, v4, v5, v6) 
    State.trace_state <- v7 
    ()
let v12 : (US0 -> ((unit -> string) -> ((unit -> string) -> unit))) = closure1()
let trace x = v12 x
()
