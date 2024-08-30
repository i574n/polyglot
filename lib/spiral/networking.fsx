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
and closure7 (v0 : Mut0) () : unit =
    let v1 : int64 = v0.l0
    let v2 : int64 = v1 + 1L
    v0.l0 <- v2
    ()
and closure8 (v0 : US3 option ref) (v1 : US3 option) : US3 option ref =
    v0.Value <- v1 
    v0
and closure9 (v0 : int64 option, v1 : (US3 option -> US3 option ref)) () : unit =
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
and closure10 (v0 : Mut4, v1 : string) () : unit =
    let v2 : string = v0.l0
    let v3 : string = v2 + v1 
    v0.l0 <- v3
    ()
and closure11 () () : string =
    let v0 : string = $"networking.test_port_open"
    v0
and closure13 (v0 : string) () : unit =
    let v1 : (string -> unit) = System.Console.WriteLine
    v1 v0
and closure12 () (v0 : string) : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure13(v0)
    let v3 : unit = (fun () -> v2 (); v1) ()
    ()
and closure6 (v0 : int32, v1 : string) () : unit =
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
            let v65 : bool = 0 >= v64
            v65
    if v66 then
        let v67 : unit = ()
        let v68 : (unit -> unit) = closure7(v17)
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
        let v104 : (US3 option -> US3 option ref) = closure8(v103)
        let v105 : unit = ()
        let v106 : (unit -> unit) = closure9(v90, v104)
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
        let v163 : string = method5()
        let v166 : (string -> string) = v162.ToString
        let v167 : string = v166 v163
        let _v101 = v167 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v170 : US3 option = None
        let _v170 = ref v170 
        let v171 : US3 option ref = _v170 
        let v172 : (US3 option -> US3 option ref) = closure8(v171)
        let v173 : unit = ()
        let v174 : (unit -> unit) = closure9(v90, v172)
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
        let v231 : string = method5()
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
        let v242 : (US3 option -> US3 option ref) = closure8(v241)
        let v243 : unit = ()
        let v244 : (unit -> unit) = closure9(v90, v242)
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
        let v282 : (US3 option -> US3 option ref) = closure8(v281)
        let v283 : unit = ()
        let v284 : (unit -> unit) = closure9(v90, v282)
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
        let v341 : string = method6()
        let v344 : (string -> string) = v340.ToString
        let v345 : string = v344 v341
        let _v101 = v345 
        #endif
#if FABLE_COMPILER_PYTHON
        let v348 : US3 option = None
        let _v348 = ref v348 
        let v349 : US3 option ref = _v348 
        let v350 : (US3 option -> US3 option ref) = closure8(v349)
        let v351 : unit = ()
        let v352 : (unit -> unit) = closure9(v90, v350)
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
        let v409 : string = method6()
        let v412 : (string -> string) = v408.ToString
        let v413 : string = v412 v409
        let _v101 = v413 
        #endif
#else
        let v416 : US3 option = None
        let _v416 = ref v416 
        let v417 : US3 option ref = _v416 
        let v418 : (US3 option -> US3 option ref) = closure8(v417)
        let v419 : unit = ()
        let v420 : (unit -> unit) = closure9(v90, v418)
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
        let v477 : string = method6()
        let v480 : (string -> string) = v476.ToString
        let v481 : string = v480 v477
        let _v101 = v481 
        #endif
        let v484 : string = _v101 
        
        
        
        
        
        let v554 : string = "Verbose"
        let v555 : (unit -> string) = v554.ToLower
        let v556 : string = v555 ()
        let v559 : string = v556.PadLeft (7, ' ')
        let v573 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v574 : string = "inline_colorization::color_bright_black"
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
        let v585 : string = "inline_colorization::color_bright_black"
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
        let v596 : string = "inline_colorization::color_bright_black"
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
        let v607 : string = "\u001b[90m"
        let v608 : string = method7()
        let v609 : string = v607 + v559 
        let v610 : string = v609 + v608 
        let _v573 = v610 
        #endif
#if FABLE_COMPILER_PYTHON
        let v611 : string = "\u001b[90m"
        let v612 : string = method7()
        let v613 : string = v611 + v559 
        let v614 : string = v613 + v612 
        let _v573 = v614 
        #endif
#else
        let v615 : string = "\u001b[90m"
        let v616 : string = method7()
        let v617 : string = v615 + v559 
        let v618 : string = v617 + v616 
        let _v573 = v618 
        #endif
        let v619 : string = _v573 
        let v625 : int64 = v86.l0
        let v626 : string = method8()
        let v627 : Mut4 = {l0 = v626} : Mut4
        let v628 : string = "{ "
        let v629 : string = $"{v628}"
        let v632 : unit = ()
        let v633 : (unit -> unit) = closure10(v627, v629)
        let v634 : unit = (fun () -> v633 (); v632) ()
        let v637 : string = "port"
        let v638 : string = $"{v637}"
        let v641 : unit = ()
        let v642 : (unit -> unit) = closure10(v627, v638)
        let v643 : unit = (fun () -> v642 (); v641) ()
        let v646 : string = " = "
        let v647 : string = $"{v646}"
        let v650 : unit = ()
        let v651 : (unit -> unit) = closure10(v627, v647)
        let v652 : unit = (fun () -> v651 (); v650) ()
        let v655 : string = $"{v0}"
        let v658 : unit = ()
        let v659 : (unit -> unit) = closure10(v627, v655)
        let v660 : unit = (fun () -> v659 (); v658) ()
        let v663 : string = "; "
        let v664 : string = $"{v663}"
        let v667 : unit = ()
        let v668 : (unit -> unit) = closure10(v627, v664)
        let v669 : unit = (fun () -> v668 (); v667) ()
        let v672 : string = "ex"
        let v673 : string = $"{v672}"
        let v676 : unit = ()
        let v677 : (unit -> unit) = closure10(v627, v673)
        let v678 : unit = (fun () -> v677 (); v676) ()
        let v681 : string = $"{v646}"
        let v684 : unit = ()
        let v685 : (unit -> unit) = closure10(v627, v681)
        let v686 : unit = (fun () -> v685 (); v684) ()
        let v689 : string = $"{v1}"
        let v692 : unit = ()
        let v693 : (unit -> unit) = closure10(v627, v689)
        let v694 : unit = (fun () -> v693 (); v692) ()
        let v697 : string = " }"
        let v698 : string = $"{v697}"
        let v701 : unit = ()
        let v702 : (unit -> unit) = closure10(v627, v698)
        let v703 : unit = (fun () -> v702 (); v701) ()
        let v706 : string = v627.l0
        let v707 : (unit -> string) = closure11()
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
        let v763 : (string -> unit) = closure12()
        let v764 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v765 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v745 v765 
        let _v764 = () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v766 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v745 v766 
        let _v764 = () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v767 : string = $"near_sdk::log!(\"{{}}\", $0)"
        Fable.Core.RustInterop.emitRustExpr v745 v767 
        let _v764 = () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        v763 v745
        let _v764 = () 
        #endif
#if FABLE_COMPILER_PYTHON
        v763 v745
        let _v764 = () 
        #endif
#else
        v763 v745
        let _v764 = () 
        #endif
        _v764 
        let v768 : (string -> unit) = v18.l0
        v768 v745
and closure5 (v0 : string) (v1 : int32) : Async<bool> =
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
    let v72 : unit = ()
    let v73 : (unit -> unit) = closure6(v1, v67)
    let v74 : unit = (fun () -> v73 (); v72) ()
    return false 
    (*
    let v842 : bool = *)
    }
    |> fun x -> _v18 <- Some x
    let v843 : Async<bool> = match _v18 with Some x -> x | None -> failwith "async.new_async_unit / _v18=None"
    let _v2 = v843 
    #endif
    let v844 : Async<bool> = _v2 
    v844
and closure4 () (v0 : string) : (int32 -> Async<bool>) =
    closure5(v0)
and closure17 () (v0 : bool) : US5 =
    US5_0(v0)
and closure18 () (v0 : exn) : US5 =
    US5_1(v0)
and closure20 () () : string =
    let v0 : string = "async.run_with_timeout_async"
    v0
and closure19 (v0 : int32) () : unit =
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
        let v67 : (unit -> unit) = closure7(v16)
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
        let v103 : (US3 option -> US3 option ref) = closure8(v102)
        let v104 : unit = ()
        let v105 : (unit -> unit) = closure9(v89, v103)
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
        let v162 : string = method5()
        let v165 : (string -> string) = v161.ToString
        let v166 : string = v165 v162
        let _v100 = v166 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v169 : US3 option = None
        let _v169 = ref v169 
        let v170 : US3 option ref = _v169 
        let v171 : (US3 option -> US3 option ref) = closure8(v170)
        let v172 : unit = ()
        let v173 : (unit -> unit) = closure9(v89, v171)
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
        let v230 : string = method5()
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
        let v241 : (US3 option -> US3 option ref) = closure8(v240)
        let v242 : unit = ()
        let v243 : (unit -> unit) = closure9(v89, v241)
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
        let v281 : (US3 option -> US3 option ref) = closure8(v280)
        let v282 : unit = ()
        let v283 : (unit -> unit) = closure9(v89, v281)
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
        let v340 : string = method6()
        let v343 : (string -> string) = v339.ToString
        let v344 : string = v343 v340
        let _v100 = v344 
        #endif
#if FABLE_COMPILER_PYTHON
        let v347 : US3 option = None
        let _v347 = ref v347 
        let v348 : US3 option ref = _v347 
        let v349 : (US3 option -> US3 option ref) = closure8(v348)
        let v350 : unit = ()
        let v351 : (unit -> unit) = closure9(v89, v349)
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
        let v408 : string = method6()
        let v411 : (string -> string) = v407.ToString
        let v412 : string = v411 v408
        let _v100 = v412 
        #endif
#else
        let v415 : US3 option = None
        let _v415 = ref v415 
        let v416 : US3 option ref = _v415 
        let v417 : (US3 option -> US3 option ref) = closure8(v416)
        let v418 : unit = ()
        let v419 : (unit -> unit) = closure9(v89, v417)
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
        let v476 : string = method6()
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
        let v607 : string = method7()
        let v608 : string = v606 + v558 
        let v609 : string = v608 + v607 
        let _v572 = v609 
        #endif
#if FABLE_COMPILER_PYTHON
        let v610 : string = "\u001b[90m"
        let v611 : string = method7()
        let v612 : string = v610 + v558 
        let v613 : string = v612 + v611 
        let _v572 = v613 
        #endif
#else
        let v614 : string = "\u001b[90m"
        let v615 : string = method7()
        let v616 : string = v614 + v558 
        let v617 : string = v616 + v615 
        let _v572 = v617 
        #endif
        let v618 : string = _v572 
        let v624 : int64 = v85.l0
        let v625 : string = method8()
        let v626 : Mut4 = {l0 = v625} : Mut4
        let v627 : string = "{ "
        let v628 : string = $"{v627}"
        let v631 : unit = ()
        let v632 : (unit -> unit) = closure10(v626, v628)
        let v633 : unit = (fun () -> v632 (); v631) ()
        let v636 : string = "timeout"
        let v637 : string = $"{v636}"
        let v640 : unit = ()
        let v641 : (unit -> unit) = closure10(v626, v637)
        let v642 : unit = (fun () -> v641 (); v640) ()
        let v645 : string = " = "
        let v646 : string = $"{v645}"
        let v649 : unit = ()
        let v650 : (unit -> unit) = closure10(v626, v646)
        let v651 : unit = (fun () -> v650 (); v649) ()
        let v654 : string = $"{v0}"
        let v657 : unit = ()
        let v658 : (unit -> unit) = closure10(v626, v654)
        let v659 : unit = (fun () -> v658 (); v657) ()
        let v662 : string = " }"
        let v663 : string = $"{v662}"
        let v666 : unit = ()
        let v667 : (unit -> unit) = closure10(v626, v663)
        let v668 : unit = (fun () -> v667 (); v666) ()
        let v671 : string = v626.l0
        let v672 : (unit -> string) = closure20()
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
        let v728 : (string -> unit) = closure12()
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
and method9 () : string =
    let v0 : string = "("
    v0
and method10 () : string =
    let v0 : string = " "
    v0
and closure22 () () : string =
    let v0 : string = $"async.run_with_timeout_async**"
    v0
and closure21 (v0 : int32, v1 : exn) () : unit =
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
        let v68 : (unit -> unit) = closure7(v17)
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
        let v104 : (US3 option -> US3 option ref) = closure8(v103)
        let v105 : unit = ()
        let v106 : (unit -> unit) = closure9(v90, v104)
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
        let v163 : string = method5()
        let v166 : (string -> string) = v162.ToString
        let v167 : string = v166 v163
        let _v101 = v167 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v170 : US3 option = None
        let _v170 = ref v170 
        let v171 : US3 option ref = _v170 
        let v172 : (US3 option -> US3 option ref) = closure8(v171)
        let v173 : unit = ()
        let v174 : (unit -> unit) = closure9(v90, v172)
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
        let v231 : string = method5()
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
        let v242 : (US3 option -> US3 option ref) = closure8(v241)
        let v243 : unit = ()
        let v244 : (unit -> unit) = closure9(v90, v242)
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
        let v282 : (US3 option -> US3 option ref) = closure8(v281)
        let v283 : unit = ()
        let v284 : (unit -> unit) = closure9(v90, v282)
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
        let v341 : string = method6()
        let v344 : (string -> string) = v340.ToString
        let v345 : string = v344 v341
        let _v101 = v345 
        #endif
#if FABLE_COMPILER_PYTHON
        let v348 : US3 option = None
        let _v348 = ref v348 
        let v349 : US3 option ref = _v348 
        let v350 : (US3 option -> US3 option ref) = closure8(v349)
        let v351 : unit = ()
        let v352 : (unit -> unit) = closure9(v90, v350)
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
        let v409 : string = method6()
        let v412 : (string -> string) = v408.ToString
        let v413 : string = v412 v409
        let _v101 = v413 
        #endif
#else
        let v416 : US3 option = None
        let _v416 = ref v416 
        let v417 : US3 option ref = _v416 
        let v418 : (US3 option -> US3 option ref) = closure8(v417)
        let v419 : unit = ()
        let v420 : (unit -> unit) = closure9(v90, v418)
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
        let v477 : string = method6()
        let v480 : (string -> string) = v476.ToString
        let v481 : string = v480 v477
        let _v101 = v481 
        #endif
        let v484 : string = _v101 
        
        
        
        
        
        let v554 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v555 : string = method9()
        let _v554 = v555 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v556 : string = method9()
        let _v554 = v556 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v557 : string = method9()
        let _v554 = v557 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v558 : string = method10()
        let _v554 = v558 
        #endif
#if FABLE_COMPILER_PYTHON
        let v559 : string = method10()
        let _v554 = v559 
        #endif
#else
        let v560 : string = method10()
        let _v554 = v560 
        #endif
        let v561 : string = _v554 
        let v566 : string = method8()
        let v567 : Mut4 = {l0 = v566} : Mut4
        let v568 : US0 = US0_0
        let v569 : string = $"%A{v568}"
        let v573 : string = $"{v569}"
        let v576 : unit = ()
        let v577 : (unit -> unit) = closure10(v567, v573)
        let v578 : unit = (fun () -> v577 (); v576) ()
        let v581 : string = v567.l0
        let v582 : (string []) = v581.Split v561 
        let v585 : string = v582.[int 0]
        let v588 : string = method8()
        let v589 : Mut4 = {l0 = v588} : Mut4
        let v590 : US0 = US0_4
        let v591 : string = $"%A{v590}"
        let v595 : string = $"{v591}"
        let v598 : unit = ()
        let v599 : (unit -> unit) = closure10(v589, v595)
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
                let v614 : string = method9()
                let _v613 = v614 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v615 : string = method9()
                let _v613 = v615 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v616 : string = method9()
                let _v613 = v616 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v617 : string = method10()
                let _v613 = v617 
                #endif
#if FABLE_COMPILER_PYTHON
                let v618 : string = method10()
                let _v613 = v618 
                #endif
#else
                let v619 : string = method10()
                let _v613 = v619 
                #endif
                let v620 : string = _v613 
                let v625 : string = method8()
                let v626 : Mut4 = {l0 = v625} : Mut4
                let v627 : US0 = US0_1
                let v628 : string = $"%A{v627}"
                let v632 : string = $"{v628}"
                let v635 : unit = ()
                let v636 : (unit -> unit) = closure10(v626, v632)
                let v637 : unit = (fun () -> v636 (); v635) ()
                let v640 : string = v626.l0
                let v641 : (string []) = v640.Split v620 
                let v644 : string = v641.[int 0]
                let v647 : string = method8()
                let v648 : Mut4 = {l0 = v647} : Mut4
                let v649 : US0 = US0_4
                let v650 : string = $"%A{v649}"
                let v654 : string = $"{v650}"
                let v657 : unit = ()
                let v658 : (unit -> unit) = closure10(v648, v654)
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
                    let v673 : string = method9()
                    let _v672 = v673 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v674 : string = method9()
                    let _v672 = v674 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v675 : string = method9()
                    let _v672 = v675 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v676 : string = method10()
                    let _v672 = v676 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v677 : string = method10()
                    let _v672 = v677 
                    #endif
#else
                    let v678 : string = method10()
                    let _v672 = v678 
                    #endif
                    let v679 : string = _v672 
                    let v684 : string = method8()
                    let v685 : Mut4 = {l0 = v684} : Mut4
                    let v686 : US0 = US0_2
                    let v687 : string = $"%A{v686}"
                    let v691 : string = $"{v687}"
                    let v694 : unit = ()
                    let v695 : (unit -> unit) = closure10(v685, v691)
                    let v696 : unit = (fun () -> v695 (); v694) ()
                    let v699 : string = v685.l0
                    let v700 : (string []) = v699.Split v679 
                    let v703 : string = v700.[int 0]
                    let v706 : string = method8()
                    let v707 : Mut4 = {l0 = v706} : Mut4
                    let v708 : US0 = US0_4
                    let v709 : string = $"%A{v708}"
                    let v713 : string = $"{v709}"
                    let v716 : unit = ()
                    let v717 : (unit -> unit) = closure10(v707, v713)
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
                        let v732 : string = method9()
                        let _v731 = v732 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        let v733 : string = method9()
                        let _v731 = v733 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        let v734 : string = method9()
                        let _v731 = v734 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        let v735 : string = method10()
                        let _v731 = v735 
                        #endif
#if FABLE_COMPILER_PYTHON
                        let v736 : string = method10()
                        let _v731 = v736 
                        #endif
#else
                        let v737 : string = method10()
                        let _v731 = v737 
                        #endif
                        let v738 : string = _v731 
                        let v743 : string = method8()
                        let v744 : Mut4 = {l0 = v743} : Mut4
                        let v745 : US0 = US0_3
                        let v746 : string = $"%A{v745}"
                        let v750 : string = $"{v746}"
                        let v753 : unit = ()
                        let v754 : (unit -> unit) = closure10(v744, v750)
                        let v755 : unit = (fun () -> v754 (); v753) ()
                        let v758 : string = v744.l0
                        let v759 : (string []) = v758.Split v738 
                        let v762 : string = v759.[int 0]
                        let v765 : string = method8()
                        let v766 : Mut4 = {l0 = v765} : Mut4
                        let v767 : US0 = US0_4
                        let v768 : string = $"%A{v767}"
                        let v772 : string = $"{v768}"
                        let v775 : unit = ()
                        let v776 : (unit -> unit) = closure10(v766, v772)
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
        let v857 : string = method7()
        let v858 : string = v856 + v808 
        let v859 : string = v858 + v857 
        let _v822 = v859 
        #endif
#if FABLE_COMPILER_PYTHON
        let v860 : string = "\u001b[91m"
        let v861 : string = method7()
        let v862 : string = v860 + v808 
        let v863 : string = v862 + v861 
        let _v822 = v863 
        #endif
#else
        let v864 : string = "\u001b[91m"
        let v865 : string = method7()
        let v866 : string = v864 + v808 
        let v867 : string = v866 + v865 
        let _v822 = v867 
        #endif
        let v868 : string = _v822 
        let v874 : int64 = v86.l0
        let v875 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v876 : string = $"%A{v1}"
        let _v875 = v876 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v879 : string = $"%A{v1}"
        let _v875 = v879 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v882 : string = $"%A{v1}"
        let _v875 = v882 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v885 : string = $"%A{v1}"
        let _v875 = v885 
        #endif
#if FABLE_COMPILER_PYTHON
        let v888 : string = $"%A{v1}"
        let _v875 = v888 
        #endif
#else
        let v891 : string = $"{v1.GetType ()}: {v1.Message}"
        let _v875 = v891 
        #endif
        let v892 : string = _v875 
        let v897 : string = method8()
        let v898 : Mut4 = {l0 = v897} : Mut4
        let v899 : string = "{ "
        let v900 : string = $"{v899}"
        let v903 : unit = ()
        let v904 : (unit -> unit) = closure10(v898, v900)
        let v905 : unit = (fun () -> v904 (); v903) ()
        let v908 : string = "timeout"
        let v909 : string = $"{v908}"
        let v912 : unit = ()
        let v913 : (unit -> unit) = closure10(v898, v909)
        let v914 : unit = (fun () -> v913 (); v912) ()
        let v917 : string = " = "
        let v918 : string = $"{v917}"
        let v921 : unit = ()
        let v922 : (unit -> unit) = closure10(v898, v918)
        let v923 : unit = (fun () -> v922 (); v921) ()
        let v926 : string = $"{v0}"
        let v929 : unit = ()
        let v930 : (unit -> unit) = closure10(v898, v926)
        let v931 : unit = (fun () -> v930 (); v929) ()
        let v934 : string = "; "
        let v935 : string = $"{v934}"
        let v938 : unit = ()
        let v939 : (unit -> unit) = closure10(v898, v935)
        let v940 : unit = (fun () -> v939 (); v938) ()
        let v943 : string = "ex"
        let v944 : string = $"{v943}"
        let v947 : unit = ()
        let v948 : (unit -> unit) = closure10(v898, v944)
        let v949 : unit = (fun () -> v948 (); v947) ()
        let v952 : string = $"{v917}"
        let v955 : unit = ()
        let v956 : (unit -> unit) = closure10(v898, v952)
        let v957 : unit = (fun () -> v956 (); v955) ()
        let v960 : string = $"{v892}"
        let v963 : unit = ()
        let v964 : (unit -> unit) = closure10(v898, v960)
        let v965 : unit = (fun () -> v964 (); v963) ()
        let v968 : string = " }"
        let v969 : string = $"{v968}"
        let v972 : unit = ()
        let v973 : (unit -> unit) = closure10(v898, v969)
        let v974 : unit = (fun () -> v973 (); v972) ()
        let v977 : string = v898.l0
        let v978 : (unit -> string) = closure22()
        let v979 : string = $"{v484} {v868} #{v874} %s{v978 ()} / {v977}"
        let v982 : char list = []
        let v983 : (char list -> (char [])) = List.toArray
        let v984 : (char []) = v983 v982
        let v987 : string = v979.TrimStart v984 
        let v1005 : char list = []
        let v1006 : char list = '/' :: v1005 
        let v1009 : char list = ' ' :: v1006 
        let v1012 : (char list -> (char [])) = List.toArray
        let v1013 : (char []) = v1012 v1009
        let v1016 : string = v987.TrimEnd v1013 
        let v1034 : (string -> unit) = closure12()
        let v1035 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v1036 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v1016 v1036 
        let _v1035 = () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v1037 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v1016 v1037 
        let _v1035 = () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v1038 : string = $"near_sdk::log!(\"{{}}\", $0)"
        Fable.Core.RustInterop.emitRustExpr v1016 v1038 
        let _v1035 = () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        v1034 v1016
        let _v1035 = () 
        #endif
#if FABLE_COMPILER_PYTHON
        v1034 v1016
        let _v1035 = () 
        #endif
#else
        v1034 v1016
        let _v1035 = () 
        #endif
        _v1035 
        let v1039 : (string -> unit) = v18.l0
        v1039 v1016
and closure16 (v0 : int32, v1 : string) (v2 : int32) : Async<bool> =
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
    let v90 : unit = ()
    let v91 : (unit -> unit) = closure6(v2, v85)
    let v92 : unit = (fun () -> v91 (); v90) ()
    return false 
    (*
    let v860 : bool = *)
    }
    |> fun x -> _v36 <- Some x
    let v861 : Async<bool> = match _v36 with Some x -> x | None -> failwith "async.new_async_unit / _v36=None"
    let _v20 = v861 
    #endif
    let v862 : Async<bool> = _v20 
    let v867 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v868 : Async<US4> = null |> unbox<Async<US4>>
    let _v867 = v868 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v871 : Async<US4> = null |> unbox<Async<US4>>
    let _v867 = v871 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v874 : Async<US4> = null |> unbox<Async<US4>>
    let _v867 = v874 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v877 : Async<US4> = null |> unbox<Async<US4>>
    let _v867 = v877 
    #endif
#if FABLE_COMPILER_PYTHON
    let v880 : Async<US4> = null |> unbox<Async<US4>>
    let _v867 = v880 
    #endif
#else
    let v883 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v884 : Async<US4> = null |> unbox<Async<US4>>
    let _v883 = v884 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v887 : Async<US4> = null |> unbox<Async<US4>>
    let _v883 = v887 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v890 : Async<US4> = null |> unbox<Async<US4>>
    let _v883 = v890 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v893 : Async<US4> = null |> unbox<Async<US4>>
    let _v883 = v893 
    #endif
#if FABLE_COMPILER_PYTHON
    let v896 : Async<US4> = null |> unbox<Async<US4>>
    let _v883 = v896 
    #endif
#else
    let v899 : Async<US4> option = None
    let mutable _v899 = v899 
    async {
    let v900 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v901 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
    let _v900 = v901 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v904 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
    let _v900 = v904 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v907 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
    let _v900 = v907 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v910 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
    let _v900 = v910 
    #endif
#if FABLE_COMPILER_PYTHON
    let v913 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
    let _v900 = v913 
    #endif
#else
    let v916 : Async<Async<bool>> = Async.StartChild (v862, v0)
    let _v900 = v916 
    #endif
    let v917 : Async<Async<bool>> = _v900 
    let! v917 = v917 
    let v922 : Async<bool> = v917 
    let v923 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v924 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
    let _v923 = v924 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v927 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
    let _v923 = v927 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v930 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
    let _v923 = v930 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v933 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
    let _v923 = v933 
    #endif
#if FABLE_COMPILER_PYTHON
    let v936 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
    let _v923 = v936 
    #endif
#else
    let v939 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
    let v940 : Async<Choice<bool, exn>> = v939 v922
    let _v923 = v940 
    #endif
    let v941 : Async<Choice<bool, exn>> = _v923 
    let v946 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v947 : Async<US5> = null |> unbox<Async<US5>>
    let _v946 = v947 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v950 : Async<US5> = null |> unbox<Async<US5>>
    let _v946 = v950 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v953 : Async<US5> = null |> unbox<Async<US5>>
    let _v946 = v953 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v956 : Async<US5> = null |> unbox<Async<US5>>
    let _v946 = v956 
    #endif
#if FABLE_COMPILER_PYTHON
    let v959 : Async<US5> = null |> unbox<Async<US5>>
    let _v946 = v959 
    #endif
#else
    let v962 : Async<US5> option = None
    let mutable _v962 = v962 
    async {
    let! v941 = v941 
    let v963 : Choice<bool, exn> = v941 
    let v964 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v965 : US5 = null |> unbox<US5>
    let _v964 = v965 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v968 : US5 = null |> unbox<US5>
    let _v964 = v968 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v971 : US5 = null |> unbox<US5>
    let _v964 = v971 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v974 : US5 = null |> unbox<US5>
    let _v964 = v974 
    #endif
#if FABLE_COMPILER_PYTHON
    let v977 : US5 = null |> unbox<US5>
    let _v964 = v977 
    #endif
#else
    let v980 : (bool -> US5) = closure17()
    let v981 : (exn -> US5) = closure18()
    let v982 : US5 = match v963 with Choice1Of2 x -> v980 x | Choice2Of2 x -> v981 x
    let _v964 = v982 
    #endif
    let v983 : US5 = _v964 
    return v983 
    }
    |> fun x -> _v962 <- Some x
    let v988 : Async<US5> = match _v962 with Some x -> x | None -> failwith "async.new_async_unit / _v962=None"
    let _v946 = v988 
    #endif
    let v989 : Async<US5> = _v946 
    let v994 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v995 : Async<US6> = null |> unbox<Async<US6>>
    let _v994 = v995 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v998 : Async<US6> = null |> unbox<Async<US6>>
    let _v994 = v998 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1001 : Async<US6> = null |> unbox<Async<US6>>
    let _v994 = v1001 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1004 : Async<US6> = null |> unbox<Async<US6>>
    let _v994 = v1004 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1007 : Async<US6> = null |> unbox<Async<US6>>
    let _v994 = v1007 
    #endif
#else
    let v1010 : Async<US6> option = None
    let mutable _v1010 = v1010 
    async {
    let! v989 = v989 
    let v1011 : US5 = v989 
    let v1017 : US6 =
        match v1011 with
        | US5_0(v1012) -> (* C1of2 *)
            US6_0(v1012)
        | US5_1(v1014) -> (* C2of2 *)
            US6_1(v1014)
    return v1017 
    }
    |> fun x -> _v1010 <- Some x
    let v1018 : Async<US6> = match _v1010 with Some x -> x | None -> failwith "async.new_async_unit / _v1010=None"
    let _v994 = v1018 
    #endif
    let v1019 : Async<US6> = _v994 
    let v1024 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1025 : Async<US4> = null |> unbox<Async<US4>>
    let _v1024 = v1025 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1028 : Async<US4> = null |> unbox<Async<US4>>
    let _v1024 = v1028 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1031 : Async<US4> = null |> unbox<Async<US4>>
    let _v1024 = v1031 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1034 : Async<US4> = null |> unbox<Async<US4>>
    let _v1024 = v1034 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1037 : Async<US4> = null |> unbox<Async<US4>>
    let _v1024 = v1037 
    #endif
#else
    let v1040 : Async<US4> option = None
    let mutable _v1040 = v1040 
    async {
    let! v1019 = v1019 
    let v1041 : US6 = v1019 
    let v2833 : US4 =
        match v1041 with
        | US6_1(v1044) -> (* Error *)
            let v1045 : string = $"%A{v1044}"
            let v1048 : string = "System.TimeoutException"
            let v1049 : bool = v1045.Contains v1048 
            if v1049 then
                let v1052 : unit = ()
                let v1053 : (unit -> unit) = closure19(v0)
                let v1054 : unit = (fun () -> v1053 (); v1052) ()
                US4_1
            else
                let v1789 : unit = ()
                let v1790 : (unit -> unit) = closure21(v0, v1044)
                let v1791 : unit = (fun () -> v1790 (); v1789) ()
                US4_1
        | US6_0(v1042) -> (* Ok *)
            US4_0(v1042)
    return v2833 
    }
    |> fun x -> _v1040 <- Some x
    let v2834 : Async<US4> = match _v1040 with Some x -> x | None -> failwith "async.new_async_unit / _v1040=None"
    let _v1024 = v2834 
    #endif
    let v2835 : Async<US4> = _v1024 
    return! v2835 
    }
    |> fun x -> _v899 <- Some x
    let v2840 : Async<US4> = match _v899 with Some x -> x | None -> failwith "async.new_async_unit / _v899=None"
    let _v883 = v2840 
    #endif
    let v2841 : Async<US4> = _v883 
    let _v867 = v2841 
    #endif
    let v2846 : Async<US4> = _v867 
    let! v2846 = v2846 
    let v2851 : US4 = v2846 
    let v2854 : bool =
        match v2851 with
        | US4_1 -> (* None *)
            false
        | US4_0(v2852) -> (* Some *)
            v2852
    return v2854 
    }
    |> fun x -> _v19 <- Some x
    let v2855 : Async<bool> = match _v19 with Some x -> x | None -> failwith "async.new_async_unit / _v19=None"
    let _v3 = v2855 
    #endif
    let v2856 : Async<bool> = _v3 
    v2856
and closure15 (v0 : int32) (v1 : string) : (int32 -> Async<bool>) =
    closure16(v0, v1)
and closure14 () (v0 : int32) : (string -> (int32 -> Async<bool>)) =
    closure15(v0)
and closure27 (v0 : US7 option ref) (v1 : US7 option) : US7 option ref =
    v0.Value <- v1 
    v0
and closure28 (v0 : int32 option, v1 : (US7 option -> US7 option ref)) () : unit =
    match v0 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v2 : int32 = x
    let v3 : US7 = US7_0(v2)
    v3 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> v1 |> ignore
    ()
and closure30 () () : string =
    let v0 : string = "networking.wait_for_port_access"
    v0
and closure29 (v0 : int32 option, v1 : bool, v2 : int32, v3 : int64) () : unit =
    let v4 : unit = ()
    let v5 : (unit -> unit) = closure0()
    let v6 : unit = (fun () -> v5 (); v4) ()
    let struct (v19 : Mut0, v20 : Mut1, v21 : Mut2, v22 : Mut3, v23 : int64 option) = State.trace_state.Value
    let v34 : unit = ()
    let v35 : unit = (fun () -> v5 (); v34) ()
    let struct (v48 : Mut0, v49 : Mut1, v50 : Mut2, v51 : Mut3, v52 : int64 option) = State.trace_state.Value
    let v63 : US0 = v51.l0
    let v64 : bool = v50.l0
    let v65 : bool = v64 = false
    let v68 : bool =
        if v65 then
            false
        else
            let v66 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v63
            let v67 : bool = 0 >= v66
            v67
    if v68 then
        let v69 : unit = ()
        let v70 : (unit -> unit) = closure7(v19)
        let v71 : unit = (fun () -> v70 (); v69) ()
        let v74 : unit = ()
        let v75 : unit = (fun () -> v5 (); v74) ()
        let struct (v88 : Mut0, v89 : Mut1, v90 : Mut2, v91 : Mut3, v92 : int64 option) = State.trace_state.Value
        let v103 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v104 : US3 option = None
        let _v104 = ref v104 
        let v105 : US3 option ref = _v104 
        let v106 : (US3 option -> US3 option ref) = closure8(v105)
        let v107 : unit = ()
        let v108 : (unit -> unit) = closure9(v92, v106)
        let v109 : unit = (fun () -> v108 (); v107) ()
        let v112 : US3 option = _v104.Value 
        let v123 : US3 = US3_1
        let v124 : US3 = v112 |> Option.defaultValue v123 
        let v164 : System.DateTime =
            match v124 with
            | US3_1 -> (* None *)
                let v160 : System.DateTime = System.DateTime.Now
                v160
            | US3_0(v128) -> (* Some *)
                let v129 : System.DateTime = System.DateTime.Now
                let v132 : (System.DateTime -> int64) = _.Ticks
                let v133 : int64 = v132 v129
                let v136 : int64 = v133 - v128
                let v137 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v138 : System.TimeSpan = v137 v136
                let v141 : (System.TimeSpan -> int32) = _.Hours
                let v142 : int32 = v141 v138
                let v145 : (System.TimeSpan -> int32) = _.Minutes
                let v146 : int32 = v145 v138
                let v149 : (System.TimeSpan -> int32) = _.Seconds
                let v150 : int32 = v149 v138
                let v153 : (System.TimeSpan -> int32) = _.Milliseconds
                let v154 : int32 = v153 v138
                let v157 : System.DateTime = System.DateTime (1, 1, 1, v142, v146, v150, v154)
                v157
        let v165 : string = method5()
        let v168 : (string -> string) = v164.ToString
        let v169 : string = v168 v165
        let _v103 = v169 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v172 : US3 option = None
        let _v172 = ref v172 
        let v173 : US3 option ref = _v172 
        let v174 : (US3 option -> US3 option ref) = closure8(v173)
        let v175 : unit = ()
        let v176 : (unit -> unit) = closure9(v92, v174)
        let v177 : unit = (fun () -> v176 (); v175) ()
        let v180 : US3 option = _v172.Value 
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
        let v233 : string = method5()
        let v236 : (string -> string) = v232.ToString
        let v237 : string = v236 v233
        let _v103 = v237 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v240 : string = $"near_sdk::env::block_timestamp()"
        let v241 : uint64 = Fable.Core.RustInterop.emitRustExpr () v240 
        let v242 : US3 option = None
        let _v242 = ref v242 
        let v243 : US3 option ref = _v242 
        let v244 : (US3 option -> US3 option ref) = closure8(v243)
        let v245 : unit = ()
        let v246 : (unit -> unit) = closure9(v92, v244)
        let v247 : unit = (fun () -> v246 (); v245) ()
        let v250 : US3 option = _v242.Value 
        let v261 : US3 = US3_1
        let v262 : US3 = v250 |> Option.defaultValue v261 
        let v271 : uint64 =
            match v262 with
            | US3_1 -> (* None *)
                v241
            | US3_0(v266) -> (* Some *)
                let v267 : (int64 -> uint64) = uint64
                let v268 : uint64 = v267 v266
                let v269 : uint64 = v241 - v268
                v269
        let v272 : uint64 = v271 / 1000000000UL
        let v273 : uint64 = v272 % 60UL
        let v274 : uint64 = v272 / 60UL
        let v275 : uint64 = v274 % 60UL
        let v276 : uint64 = v272 / 3600UL
        let v277 : uint64 = v276 % 24UL
        let v278 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
        let v279 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v277, v275, v273) v278 
        let v280 : string = "fable_library_rust::String_::fromString($0)"
        let v281 : string = Fable.Core.RustInterop.emitRustExpr v279 v280 
        let _v103 = v281 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v282 : US3 option = None
        let _v282 = ref v282 
        let v283 : US3 option ref = _v282 
        let v284 : (US3 option -> US3 option ref) = closure8(v283)
        let v285 : unit = ()
        let v286 : (unit -> unit) = closure9(v92, v284)
        let v287 : unit = (fun () -> v286 (); v285) ()
        let v290 : US3 option = _v282.Value 
        let v301 : US3 = US3_1
        let v302 : US3 = v290 |> Option.defaultValue v301 
        let v342 : System.DateTime =
            match v302 with
            | US3_1 -> (* None *)
                let v338 : System.DateTime = System.DateTime.Now
                v338
            | US3_0(v306) -> (* Some *)
                let v307 : System.DateTime = System.DateTime.Now
                let v310 : (System.DateTime -> int64) = _.Ticks
                let v311 : int64 = v310 v307
                let v314 : int64 = v311 - v306
                let v315 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v316 : System.TimeSpan = v315 v314
                let v319 : (System.TimeSpan -> int32) = _.Hours
                let v320 : int32 = v319 v316
                let v323 : (System.TimeSpan -> int32) = _.Minutes
                let v324 : int32 = v323 v316
                let v327 : (System.TimeSpan -> int32) = _.Seconds
                let v328 : int32 = v327 v316
                let v331 : (System.TimeSpan -> int32) = _.Milliseconds
                let v332 : int32 = v331 v316
                let v335 : System.DateTime = System.DateTime (1, 1, 1, v320, v324, v328, v332)
                v335
        let v343 : string = method6()
        let v346 : (string -> string) = v342.ToString
        let v347 : string = v346 v343
        let _v103 = v347 
        #endif
#if FABLE_COMPILER_PYTHON
        let v350 : US3 option = None
        let _v350 = ref v350 
        let v351 : US3 option ref = _v350 
        let v352 : (US3 option -> US3 option ref) = closure8(v351)
        let v353 : unit = ()
        let v354 : (unit -> unit) = closure9(v92, v352)
        let v355 : unit = (fun () -> v354 (); v353) ()
        let v358 : US3 option = _v350.Value 
        let v369 : US3 = US3_1
        let v370 : US3 = v358 |> Option.defaultValue v369 
        let v410 : System.DateTime =
            match v370 with
            | US3_1 -> (* None *)
                let v406 : System.DateTime = System.DateTime.Now
                v406
            | US3_0(v374) -> (* Some *)
                let v375 : System.DateTime = System.DateTime.Now
                let v378 : (System.DateTime -> int64) = _.Ticks
                let v379 : int64 = v378 v375
                let v382 : int64 = v379 - v374
                let v383 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v384 : System.TimeSpan = v383 v382
                let v387 : (System.TimeSpan -> int32) = _.Hours
                let v388 : int32 = v387 v384
                let v391 : (System.TimeSpan -> int32) = _.Minutes
                let v392 : int32 = v391 v384
                let v395 : (System.TimeSpan -> int32) = _.Seconds
                let v396 : int32 = v395 v384
                let v399 : (System.TimeSpan -> int32) = _.Milliseconds
                let v400 : int32 = v399 v384
                let v403 : System.DateTime = System.DateTime (1, 1, 1, v388, v392, v396, v400)
                v403
        let v411 : string = method6()
        let v414 : (string -> string) = v410.ToString
        let v415 : string = v414 v411
        let _v103 = v415 
        #endif
#else
        let v418 : US3 option = None
        let _v418 = ref v418 
        let v419 : US3 option ref = _v418 
        let v420 : (US3 option -> US3 option ref) = closure8(v419)
        let v421 : unit = ()
        let v422 : (unit -> unit) = closure9(v92, v420)
        let v423 : unit = (fun () -> v422 (); v421) ()
        let v426 : US3 option = _v418.Value 
        let v437 : US3 = US3_1
        let v438 : US3 = v426 |> Option.defaultValue v437 
        let v478 : System.DateTime =
            match v438 with
            | US3_1 -> (* None *)
                let v474 : System.DateTime = System.DateTime.Now
                v474
            | US3_0(v442) -> (* Some *)
                let v443 : System.DateTime = System.DateTime.Now
                let v446 : (System.DateTime -> int64) = _.Ticks
                let v447 : int64 = v446 v443
                let v450 : int64 = v447 - v442
                let v451 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v452 : System.TimeSpan = v451 v450
                let v455 : (System.TimeSpan -> int32) = _.Hours
                let v456 : int32 = v455 v452
                let v459 : (System.TimeSpan -> int32) = _.Minutes
                let v460 : int32 = v459 v452
                let v463 : (System.TimeSpan -> int32) = _.Seconds
                let v464 : int32 = v463 v452
                let v467 : (System.TimeSpan -> int32) = _.Milliseconds
                let v468 : int32 = v467 v452
                let v471 : System.DateTime = System.DateTime (1, 1, 1, v456, v460, v464, v468)
                v471
        let v479 : string = method6()
        let v482 : (string -> string) = v478.ToString
        let v483 : string = v482 v479
        let _v103 = v483 
        #endif
        let v486 : string = _v103 
        
        
        
        
        
        let v556 : string = "Verbose"
        let v557 : (unit -> string) = v556.ToLower
        let v558 : string = v557 ()
        let v561 : string = v558.PadLeft (7, ' ')
        let v575 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v576 : string = "inline_colorization::color_bright_black"
        let v577 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v576 
        let v578 : string = "&*$0"
        let v579 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v561 v578 
        let v580 : string = "inline_colorization::color_reset"
        let v581 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v580 
        let v582 : string = "\"{v577}{v579}{v581}\""
        let v583 : string = @$"format!(" + v582 + ")"
        let v584 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v583 
        let v585 : string = "fable_library_rust::String_::fromString($0)"
        let v586 : string = Fable.Core.RustInterop.emitRustExpr v584 v585 
        let _v575 = v586 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v587 : string = "inline_colorization::color_bright_black"
        let v588 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v587 
        let v589 : string = "&*$0"
        let v590 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v561 v589 
        let v591 : string = "inline_colorization::color_reset"
        let v592 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v591 
        let v593 : string = "\"{v588}{v590}{v592}\""
        let v594 : string = @$"format!(" + v593 + ")"
        let v595 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v594 
        let v596 : string = "fable_library_rust::String_::fromString($0)"
        let v597 : string = Fable.Core.RustInterop.emitRustExpr v595 v596 
        let _v575 = v597 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v598 : string = "inline_colorization::color_bright_black"
        let v599 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v598 
        let v600 : string = "&*$0"
        let v601 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v561 v600 
        let v602 : string = "inline_colorization::color_reset"
        let v603 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v602 
        let v604 : string = "\"{v599}{v601}{v603}\""
        let v605 : string = @$"format!(" + v604 + ")"
        let v606 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v605 
        let v607 : string = "fable_library_rust::String_::fromString($0)"
        let v608 : string = Fable.Core.RustInterop.emitRustExpr v606 v607 
        let _v575 = v608 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v609 : string = "\u001b[90m"
        let v610 : string = method7()
        let v611 : string = v609 + v561 
        let v612 : string = v611 + v610 
        let _v575 = v612 
        #endif
#if FABLE_COMPILER_PYTHON
        let v613 : string = "\u001b[90m"
        let v614 : string = method7()
        let v615 : string = v613 + v561 
        let v616 : string = v615 + v614 
        let _v575 = v616 
        #endif
#else
        let v617 : string = "\u001b[90m"
        let v618 : string = method7()
        let v619 : string = v617 + v561 
        let v620 : string = v619 + v618 
        let _v575 = v620 
        #endif
        let v621 : string = _v575 
        let v627 : int64 = v88.l0
        let v628 : string = method8()
        let v629 : Mut4 = {l0 = v628} : Mut4
        let v630 : string = "{ "
        let v631 : string = $"{v630}"
        let v634 : unit = ()
        let v635 : (unit -> unit) = closure10(v629, v631)
        let v636 : unit = (fun () -> v635 (); v634) ()
        let v639 : string = "port"
        let v640 : string = $"{v639}"
        let v643 : unit = ()
        let v644 : (unit -> unit) = closure10(v629, v640)
        let v645 : unit = (fun () -> v644 (); v643) ()
        let v648 : string = " = "
        let v649 : string = $"{v648}"
        let v652 : unit = ()
        let v653 : (unit -> unit) = closure10(v629, v649)
        let v654 : unit = (fun () -> v653 (); v652) ()
        let v657 : string = $"{v2}"
        let v660 : unit = ()
        let v661 : (unit -> unit) = closure10(v629, v657)
        let v662 : unit = (fun () -> v661 (); v660) ()
        let v665 : string = "; "
        let v666 : string = $"{v665}"
        let v669 : unit = ()
        let v670 : (unit -> unit) = closure10(v629, v666)
        let v671 : unit = (fun () -> v670 (); v669) ()
        let v674 : string = "retry"
        let v675 : string = $"{v674}"
        let v678 : unit = ()
        let v679 : (unit -> unit) = closure10(v629, v675)
        let v680 : unit = (fun () -> v679 (); v678) ()
        let v683 : string = $"{v648}"
        let v686 : unit = ()
        let v687 : (unit -> unit) = closure10(v629, v683)
        let v688 : unit = (fun () -> v687 (); v686) ()
        let v691 : string = $"{v3}"
        let v694 : unit = ()
        let v695 : (unit -> unit) = closure10(v629, v691)
        let v696 : unit = (fun () -> v695 (); v694) ()
        let v699 : string = $"{v665}"
        let v702 : unit = ()
        let v703 : (unit -> unit) = closure10(v629, v699)
        let v704 : unit = (fun () -> v703 (); v702) ()
        let v707 : string = "timeout"
        let v708 : string = $"{v707}"
        let v711 : unit = ()
        let v712 : (unit -> unit) = closure10(v629, v708)
        let v713 : unit = (fun () -> v712 (); v711) ()
        let v716 : string = $"{v648}"
        let v719 : unit = ()
        let v720 : (unit -> unit) = closure10(v629, v716)
        let v721 : unit = (fun () -> v720 (); v719) ()
        let v724 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v725 : string = "format!(\"{:#?}\", $0)"
        let v726 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v725 
        let v727 : string = "fable_library_rust::String_::fromString($0)"
        let v728 : string = Fable.Core.RustInterop.emitRustExpr v726 v727 
        let _v724 = v728 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v729 : string = "format!(\"{:#?}\", $0)"
        let v730 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v729 
        let v731 : string = "fable_library_rust::String_::fromString($0)"
        let v732 : string = Fable.Core.RustInterop.emitRustExpr v730 v731 
        let _v724 = v732 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v733 : string = "format!(\"{:#?}\", $0)"
        let v734 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v733 
        let v735 : string = "fable_library_rust::String_::fromString($0)"
        let v736 : string = Fable.Core.RustInterop.emitRustExpr v734 v735 
        let _v724 = v736 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v737 : string = $"%A{v0}"
        let _v724 = v737 
        #endif
#if FABLE_COMPILER_PYTHON
        let v740 : string = $"%A{v0}"
        let _v724 = v740 
        #endif
#else
        let v743 : string = $"%A{v0}"
        let _v724 = v743 
        #endif
        let v746 : string = _v724 
        let v751 : string = $"{v746}"
        let v754 : unit = ()
        let v755 : (unit -> unit) = closure10(v629, v751)
        let v756 : unit = (fun () -> v755 (); v754) ()
        let v759 : string = $"{v665}"
        let v762 : unit = ()
        let v763 : (unit -> unit) = closure10(v629, v759)
        let v764 : unit = (fun () -> v763 (); v762) ()
        let v767 : string = "status"
        let v768 : string = $"{v767}"
        let v771 : unit = ()
        let v772 : (unit -> unit) = closure10(v629, v768)
        let v773 : unit = (fun () -> v772 (); v771) ()
        let v776 : string = $"{v648}"
        let v779 : unit = ()
        let v780 : (unit -> unit) = closure10(v629, v776)
        let v781 : unit = (fun () -> v780 (); v779) ()
        let v786 : string =
            if v1 then
                let v784 : string = "true"
                v784
            else
                let v785 : string = "false"
                v785
        let v787 : string = $"{v786}"
        let v790 : unit = ()
        let v791 : (unit -> unit) = closure10(v629, v787)
        let v792 : unit = (fun () -> v791 (); v790) ()
        let v795 : string = " }"
        let v796 : string = $"{v795}"
        let v799 : unit = ()
        let v800 : (unit -> unit) = closure10(v629, v796)
        let v801 : unit = (fun () -> v800 (); v799) ()
        let v804 : string = v629.l0
        let v805 : (unit -> string) = closure30()
        let v806 : string = $"{v486} {v621} #{v627} %s{v805 ()} / {v804}"
        let v809 : char list = []
        let v810 : (char list -> (char [])) = List.toArray
        let v811 : (char []) = v810 v809
        let v814 : string = v806.TrimStart v811 
        let v832 : char list = []
        let v833 : char list = '/' :: v832 
        let v836 : char list = ' ' :: v833 
        let v839 : (char list -> (char [])) = List.toArray
        let v840 : (char []) = v839 v836
        let v843 : string = v814.TrimEnd v840 
        let v861 : (string -> unit) = closure12()
        let v862 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v863 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v843 v863 
        let _v862 = () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v864 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v843 v864 
        let _v862 = () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v865 : string = $"near_sdk::log!(\"{{}}\", $0)"
        Fable.Core.RustInterop.emitRustExpr v843 v865 
        let _v862 = () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        v861 v843
        let _v862 = () 
        #endif
#if FABLE_COMPILER_PYTHON
        v861 v843
        let _v862 = () 
        #endif
#else
        v861 v843
        let _v862 = () 
        #endif
        _v862 
        let v866 : (string -> unit) = v20.l0
        v866 v843
and method11 (v0 : int32 option, v1 : bool, v2 : string, v3 : int32, v4 : int64) : Async<int64> =
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
    let v23 : US7 option ref = _v22 
    let v24 : (US7 option -> US7 option ref) = closure27(v23)
    let v25 : unit = ()
    let v26 : (unit -> unit) = closure28(v0, v24)
    let v27 : unit = (fun () -> v26 (); v25) ()
    let v30 : US7 option = _v22.Value 
    let v41 : US7 = US7_1
    let v42 : US7 = v30 |> Option.defaultValue v41 
    let v3753 : Async<bool> =
        match v42 with
        | US7_1 -> (* None *)
            let v46 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v47 : Async<bool> = null |> unbox<Async<bool>>
            let _v46 = v47 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v50 : Async<bool> = null |> unbox<Async<bool>>
            let _v46 = v50 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v53 : Async<bool> = null |> unbox<Async<bool>>
            let _v46 = v53 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v56 : Async<bool> = null |> unbox<Async<bool>>
            let _v46 = v56 
            #endif
#if FABLE_COMPILER_PYTHON
            let v59 : Async<bool> = null |> unbox<Async<bool>>
            let _v46 = v59 
            #endif
#else
            let v62 : Async<bool> option = None
            let mutable _v62 = v62 
            async {
            let v63 : Async<System.Threading.CancellationToken> = Async.CancellationToken
            let! v63 = v63 
            let v64 : System.Threading.CancellationToken = v63 
            let v65 : System.Net.Sockets.TcpClient = new System.Net.Sockets.TcpClient ()
            use v65 = v65 
            let v66 : System.Net.Sockets.TcpClient = v65 
            try
            let v67 : System.Threading.Tasks.ValueTask = v66.ConnectAsync (v2, v3, v64)
            let v68 : (unit -> System.Threading.Tasks.Task) = v67.AsTask
            let v69 : System.Threading.Tasks.Task = v68 ()
            let v70 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v71 : Async<unit> = null |> unbox<Async<unit>>
            let _v70 = v71 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v74 : Async<unit> = null |> unbox<Async<unit>>
            let _v70 = v74 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v77 : Async<unit> = null |> unbox<Async<unit>>
            let _v70 = v77 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v80 : Async<unit> = null |> unbox<Async<unit>>
            let _v70 = v80 
            #endif
#if FABLE_COMPILER_PYTHON
            let v83 : Async<unit> = null |> unbox<Async<unit>>
            let _v70 = v83 
            #endif
#else
            let v86 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
            let v87 : Async<unit> = v86 v69
            let _v70 = v87 
            #endif
            let v88 : Async<unit> = _v70 
            do! v88 
            return true 
            with ex ->
            let v93 : exn = ex
            let v94 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v95 : string = $"%A{v93}"
            let _v94 = v95 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v98 : string = $"%A{v93}"
            let _v94 = v98 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v101 : string = $"%A{v93}"
            let _v94 = v101 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v104 : string = $"%A{v93}"
            let _v94 = v104 
            #endif
#if FABLE_COMPILER_PYTHON
            let v107 : string = $"%A{v93}"
            let _v94 = v107 
            #endif
#else
            let v110 : string = $"{v93.GetType ()}: {v93.Message}"
            let _v94 = v110 
            #endif
            let v111 : string = _v94 
            let v116 : unit = ()
            let v117 : (unit -> unit) = closure6(v3, v111)
            let v118 : unit = (fun () -> v117 (); v116) ()
            return false 
            (*
            let v886 : bool = *)
            }
            |> fun x -> _v62 <- Some x
            let v887 : Async<bool> = match _v62 with Some x -> x | None -> failwith "async.new_async_unit / _v62=None"
            let _v46 = v887 
            #endif
            let v888 : Async<bool> = _v46 
            v888
        | US7_0(v893) -> (* Some *)
            let v894 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v895 : Async<bool> = null |> unbox<Async<bool>>
            let _v894 = v895 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v898 : Async<bool> = null |> unbox<Async<bool>>
            let _v894 = v898 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v901 : Async<bool> = null |> unbox<Async<bool>>
            let _v894 = v901 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v904 : Async<bool> = null |> unbox<Async<bool>>
            let _v894 = v904 
            #endif
#if FABLE_COMPILER_PYTHON
            let v907 : Async<bool> = null |> unbox<Async<bool>>
            let _v894 = v907 
            #endif
#else
            let v910 : Async<bool> option = None
            let mutable _v910 = v910 
            async {
            let v911 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v912 : Async<bool> = null |> unbox<Async<bool>>
            let _v911 = v912 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v915 : Async<bool> = null |> unbox<Async<bool>>
            let _v911 = v915 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v918 : Async<bool> = null |> unbox<Async<bool>>
            let _v911 = v918 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v921 : Async<bool> = null |> unbox<Async<bool>>
            let _v911 = v921 
            #endif
#if FABLE_COMPILER_PYTHON
            let v924 : Async<bool> = null |> unbox<Async<bool>>
            let _v911 = v924 
            #endif
#else
            let v927 : Async<bool> option = None
            let mutable _v927 = v927 
            async {
            let v928 : Async<System.Threading.CancellationToken> = Async.CancellationToken
            let! v928 = v928 
            let v929 : System.Threading.CancellationToken = v928 
            let v930 : System.Net.Sockets.TcpClient = new System.Net.Sockets.TcpClient ()
            use v930 = v930 
            let v931 : System.Net.Sockets.TcpClient = v930 
            try
            let v932 : System.Threading.Tasks.ValueTask = v931.ConnectAsync (v2, v3, v929)
            let v933 : (unit -> System.Threading.Tasks.Task) = v932.AsTask
            let v934 : System.Threading.Tasks.Task = v933 ()
            let v935 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v936 : Async<unit> = null |> unbox<Async<unit>>
            let _v935 = v936 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v939 : Async<unit> = null |> unbox<Async<unit>>
            let _v935 = v939 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v942 : Async<unit> = null |> unbox<Async<unit>>
            let _v935 = v942 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v945 : Async<unit> = null |> unbox<Async<unit>>
            let _v935 = v945 
            #endif
#if FABLE_COMPILER_PYTHON
            let v948 : Async<unit> = null |> unbox<Async<unit>>
            let _v935 = v948 
            #endif
#else
            let v951 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
            let v952 : Async<unit> = v951 v934
            let _v935 = v952 
            #endif
            let v953 : Async<unit> = _v935 
            do! v953 
            return true 
            with ex ->
            let v958 : exn = ex
            let v959 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v960 : string = $"%A{v958}"
            let _v959 = v960 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v963 : string = $"%A{v958}"
            let _v959 = v963 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v966 : string = $"%A{v958}"
            let _v959 = v966 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v969 : string = $"%A{v958}"
            let _v959 = v969 
            #endif
#if FABLE_COMPILER_PYTHON
            let v972 : string = $"%A{v958}"
            let _v959 = v972 
            #endif
#else
            let v975 : string = $"{v958.GetType ()}: {v958.Message}"
            let _v959 = v975 
            #endif
            let v976 : string = _v959 
            let v981 : unit = ()
            let v982 : (unit -> unit) = closure6(v3, v976)
            let v983 : unit = (fun () -> v982 (); v981) ()
            return false 
            (*
            let v1751 : bool = *)
            }
            |> fun x -> _v927 <- Some x
            let v1752 : Async<bool> = match _v927 with Some x -> x | None -> failwith "async.new_async_unit / _v927=None"
            let _v911 = v1752 
            #endif
            let v1753 : Async<bool> = _v911 
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
            let v1774 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1775 : Async<US4> = null |> unbox<Async<US4>>
            let _v1774 = v1775 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1778 : Async<US4> = null |> unbox<Async<US4>>
            let _v1774 = v1778 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1781 : Async<US4> = null |> unbox<Async<US4>>
            let _v1774 = v1781 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1784 : Async<US4> = null |> unbox<Async<US4>>
            let _v1774 = v1784 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1787 : Async<US4> = null |> unbox<Async<US4>>
            let _v1774 = v1787 
            #endif
#else
            let v1790 : Async<US4> option = None
            let mutable _v1790 = v1790 
            async {
            let v1791 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1792 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v1791 = v1792 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1795 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v1791 = v1795 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1798 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v1791 = v1798 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1801 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v1791 = v1801 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1804 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v1791 = v1804 
            #endif
#else
            let v1807 : Async<Async<bool>> = Async.StartChild (v1753, v893)
            let _v1791 = v1807 
            #endif
            let v1808 : Async<Async<bool>> = _v1791 
            let! v1808 = v1808 
            let v1813 : Async<bool> = v1808 
            let v1814 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1815 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
            let _v1814 = v1815 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1818 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
            let _v1814 = v1818 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1821 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
            let _v1814 = v1821 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1824 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
            let _v1814 = v1824 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1827 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
            let _v1814 = v1827 
            #endif
#else
            let v1830 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v1831 : Async<Choice<bool, exn>> = v1830 v1813
            let _v1814 = v1831 
            #endif
            let v1832 : Async<Choice<bool, exn>> = _v1814 
            let v1837 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1838 : Async<US5> = null |> unbox<Async<US5>>
            let _v1837 = v1838 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1841 : Async<US5> = null |> unbox<Async<US5>>
            let _v1837 = v1841 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1844 : Async<US5> = null |> unbox<Async<US5>>
            let _v1837 = v1844 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1847 : Async<US5> = null |> unbox<Async<US5>>
            let _v1837 = v1847 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1850 : Async<US5> = null |> unbox<Async<US5>>
            let _v1837 = v1850 
            #endif
#else
            let v1853 : Async<US5> option = None
            let mutable _v1853 = v1853 
            async {
            let! v1832 = v1832 
            let v1854 : Choice<bool, exn> = v1832 
            let v1855 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1856 : US5 = null |> unbox<US5>
            let _v1855 = v1856 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1859 : US5 = null |> unbox<US5>
            let _v1855 = v1859 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1862 : US5 = null |> unbox<US5>
            let _v1855 = v1862 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1865 : US5 = null |> unbox<US5>
            let _v1855 = v1865 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1868 : US5 = null |> unbox<US5>
            let _v1855 = v1868 
            #endif
#else
            let v1871 : (bool -> US5) = closure17()
            let v1872 : (exn -> US5) = closure18()
            let v1873 : US5 = match v1854 with Choice1Of2 x -> v1871 x | Choice2Of2 x -> v1872 x
            let _v1855 = v1873 
            #endif
            let v1874 : US5 = _v1855 
            return v1874 
            }
            |> fun x -> _v1853 <- Some x
            let v1879 : Async<US5> = match _v1853 with Some x -> x | None -> failwith "async.new_async_unit / _v1853=None"
            let _v1837 = v1879 
            #endif
            let v1880 : Async<US5> = _v1837 
            let v1885 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1886 : Async<US6> = null |> unbox<Async<US6>>
            let _v1885 = v1886 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1889 : Async<US6> = null |> unbox<Async<US6>>
            let _v1885 = v1889 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1892 : Async<US6> = null |> unbox<Async<US6>>
            let _v1885 = v1892 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1895 : Async<US6> = null |> unbox<Async<US6>>
            let _v1885 = v1895 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1898 : Async<US6> = null |> unbox<Async<US6>>
            let _v1885 = v1898 
            #endif
#else
            let v1901 : Async<US6> option = None
            let mutable _v1901 = v1901 
            async {
            let! v1880 = v1880 
            let v1902 : US5 = v1880 
            let v1908 : US6 =
                match v1902 with
                | US5_0(v1903) -> (* C1of2 *)
                    US6_0(v1903)
                | US5_1(v1905) -> (* C2of2 *)
                    US6_1(v1905)
            return v1908 
            }
            |> fun x -> _v1901 <- Some x
            let v1909 : Async<US6> = match _v1901 with Some x -> x | None -> failwith "async.new_async_unit / _v1901=None"
            let _v1885 = v1909 
            #endif
            let v1910 : Async<US6> = _v1885 
            let v1915 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1916 : Async<US4> = null |> unbox<Async<US4>>
            let _v1915 = v1916 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1919 : Async<US4> = null |> unbox<Async<US4>>
            let _v1915 = v1919 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1922 : Async<US4> = null |> unbox<Async<US4>>
            let _v1915 = v1922 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1925 : Async<US4> = null |> unbox<Async<US4>>
            let _v1915 = v1925 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1928 : Async<US4> = null |> unbox<Async<US4>>
            let _v1915 = v1928 
            #endif
#else
            let v1931 : Async<US4> option = None
            let mutable _v1931 = v1931 
            async {
            let! v1910 = v1910 
            let v1932 : US6 = v1910 
            let v3724 : US4 =
                match v1932 with
                | US6_1(v1935) -> (* Error *)
                    let v1936 : string = $"%A{v1935}"
                    let v1939 : string = "System.TimeoutException"
                    let v1940 : bool = v1936.Contains v1939 
                    if v1940 then
                        let v1943 : unit = ()
                        let v1944 : (unit -> unit) = closure19(v893)
                        let v1945 : unit = (fun () -> v1944 (); v1943) ()
                        US4_1
                    else
                        let v2680 : unit = ()
                        let v2681 : (unit -> unit) = closure21(v893, v1935)
                        let v2682 : unit = (fun () -> v2681 (); v2680) ()
                        US4_1
                | US6_0(v1933) -> (* Ok *)
                    US4_0(v1933)
            return v3724 
            }
            |> fun x -> _v1931 <- Some x
            let v3725 : Async<US4> = match _v1931 with Some x -> x | None -> failwith "async.new_async_unit / _v1931=None"
            let _v1915 = v3725 
            #endif
            let v3726 : Async<US4> = _v1915 
            return! v3726 
            }
            |> fun x -> _v1790 <- Some x
            let v3731 : Async<US4> = match _v1790 with Some x -> x | None -> failwith "async.new_async_unit / _v1790=None"
            let _v1774 = v3731 
            #endif
            let v3732 : Async<US4> = _v1774 
            let _v1758 = v3732 
            #endif
            let v3737 : Async<US4> = _v1758 
            let! v3737 = v3737 
            let v3742 : US4 = v3737 
            let v3745 : bool =
                match v3742 with
                | US4_1 -> (* None *)
                    false
                | US4_0(v3743) -> (* Some *)
                    v3743
            return v3745 
            }
            |> fun x -> _v910 <- Some x
            let v3746 : Async<bool> = match _v910 with Some x -> x | None -> failwith "async.new_async_unit / _v910=None"
            let _v894 = v3746 
            #endif
            let v3747 : Async<bool> = _v894 
            v3747
    let! v3753 = v3753 
    let v3754 : bool = v3753 
    let v3755 : bool = v3754 = v1
    if v3755 then
        return v4 
        (*
        ()
    else
        *) else
        let v3756 : int64 = v4 % 100L
        let v3757 : bool = v3756 = 0L
        if v3757 then
            let v3758 : unit = ()
            let v3759 : (unit -> unit) = closure29(v0, v1, v3, v4)
            let v3760 : unit = (fun () -> v3759 (); v3758) ()
            ()
        let v4624 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v4625 : Async<unit> = null |> unbox<Async<unit>>
        let _v4624 = v4625 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v4628 : Async<unit> = null |> unbox<Async<unit>>
        let _v4624 = v4628 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v4631 : Async<unit> = null |> unbox<Async<unit>>
        let _v4624 = v4631 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v4634 : Async<unit> = null |> unbox<Async<unit>>
        let _v4624 = v4634 
        #endif
#if FABLE_COMPILER_PYTHON
        let v4637 : Async<unit> = null |> unbox<Async<unit>>
        let _v4624 = v4637 
        #endif
#else
        let v4640 : (int32 -> Async<unit>) = Async.Sleep
        let v4641 : Async<unit> = v4640 10
        let _v4624 = v4641 
        #endif
        let v4642 : Async<unit> = _v4624 
        do! v4642 
        let v4647 : int64 = v4 + 1L
        let v4648 : Async<int64> = method11(v0, v1, v2, v3, v4647)
        return! v4648 
        (*
        ()
    *)
    }
    |> fun x -> _v21 <- Some x
    let v4649 : Async<int64> = match _v21 with Some x -> x | None -> failwith "async.new_async_unit / _v21=None"
    let _v5 = v4649 
    #endif
    let v4650 : Async<int64> = _v5 
    v4650
and closure26 (v0 : int32 option, v1 : bool, v2 : string) (v3 : int32) : Async<int64> =
    let v4 : int64 = 0L
    method11(v0, v1, v2, v3, v4)
and closure25 (v0 : int32 option, v1 : bool) (v2 : string) : (int32 -> Async<int64>) =
    closure26(v0, v1, v2)
and closure24 (v0 : int32 option) (v1 : bool) : (string -> (int32 -> Async<int64>)) =
    closure25(v0, v1)
and closure23 () (v0 : int32 option) : (bool -> (string -> (int32 -> Async<int64>))) =
    closure24(v0)
and method12 (v0 : int32 option, v1 : string, v2 : int32) : Async<int32> =
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
    let v21 : US7 option ref = _v20 
    let v22 : (US7 option -> US7 option ref) = closure27(v21)
    let v23 : unit = ()
    let v24 : (unit -> unit) = closure28(v0, v22)
    let v25 : unit = (fun () -> v24 (); v23) ()
    let v28 : US7 option = _v20.Value 
    let v39 : US7 = US7_1
    let v40 : US7 = v28 |> Option.defaultValue v39 
    let v3751 : Async<bool> =
        match v40 with
        | US7_1 -> (* None *)
            let v44 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v45 : Async<bool> = null |> unbox<Async<bool>>
            let _v44 = v45 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v48 : Async<bool> = null |> unbox<Async<bool>>
            let _v44 = v48 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v51 : Async<bool> = null |> unbox<Async<bool>>
            let _v44 = v51 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v54 : Async<bool> = null |> unbox<Async<bool>>
            let _v44 = v54 
            #endif
#if FABLE_COMPILER_PYTHON
            let v57 : Async<bool> = null |> unbox<Async<bool>>
            let _v44 = v57 
            #endif
#else
            let v60 : Async<bool> option = None
            let mutable _v60 = v60 
            async {
            let v61 : Async<System.Threading.CancellationToken> = Async.CancellationToken
            let! v61 = v61 
            let v62 : System.Threading.CancellationToken = v61 
            let v63 : System.Net.Sockets.TcpClient = new System.Net.Sockets.TcpClient ()
            use v63 = v63 
            let v64 : System.Net.Sockets.TcpClient = v63 
            try
            let v65 : System.Threading.Tasks.ValueTask = v64.ConnectAsync (v1, v2, v62)
            let v66 : (unit -> System.Threading.Tasks.Task) = v65.AsTask
            let v67 : System.Threading.Tasks.Task = v66 ()
            let v68 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v69 : Async<unit> = null |> unbox<Async<unit>>
            let _v68 = v69 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v72 : Async<unit> = null |> unbox<Async<unit>>
            let _v68 = v72 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v75 : Async<unit> = null |> unbox<Async<unit>>
            let _v68 = v75 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v78 : Async<unit> = null |> unbox<Async<unit>>
            let _v68 = v78 
            #endif
#if FABLE_COMPILER_PYTHON
            let v81 : Async<unit> = null |> unbox<Async<unit>>
            let _v68 = v81 
            #endif
#else
            let v84 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
            let v85 : Async<unit> = v84 v67
            let _v68 = v85 
            #endif
            let v86 : Async<unit> = _v68 
            do! v86 
            return true 
            with ex ->
            let v91 : exn = ex
            let v92 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v93 : string = $"%A{v91}"
            let _v92 = v93 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v96 : string = $"%A{v91}"
            let _v92 = v96 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v99 : string = $"%A{v91}"
            let _v92 = v99 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v102 : string = $"%A{v91}"
            let _v92 = v102 
            #endif
#if FABLE_COMPILER_PYTHON
            let v105 : string = $"%A{v91}"
            let _v92 = v105 
            #endif
#else
            let v108 : string = $"{v91.GetType ()}: {v91.Message}"
            let _v92 = v108 
            #endif
            let v109 : string = _v92 
            let v114 : unit = ()
            let v115 : (unit -> unit) = closure6(v2, v109)
            let v116 : unit = (fun () -> v115 (); v114) ()
            return false 
            (*
            let v884 : bool = *)
            }
            |> fun x -> _v60 <- Some x
            let v885 : Async<bool> = match _v60 with Some x -> x | None -> failwith "async.new_async_unit / _v60=None"
            let _v44 = v885 
            #endif
            let v886 : Async<bool> = _v44 
            v886
        | US7_0(v891) -> (* Some *)
            let v892 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v893 : Async<bool> = null |> unbox<Async<bool>>
            let _v892 = v893 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v896 : Async<bool> = null |> unbox<Async<bool>>
            let _v892 = v896 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v899 : Async<bool> = null |> unbox<Async<bool>>
            let _v892 = v899 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v902 : Async<bool> = null |> unbox<Async<bool>>
            let _v892 = v902 
            #endif
#if FABLE_COMPILER_PYTHON
            let v905 : Async<bool> = null |> unbox<Async<bool>>
            let _v892 = v905 
            #endif
#else
            let v908 : Async<bool> option = None
            let mutable _v908 = v908 
            async {
            let v909 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v910 : Async<bool> = null |> unbox<Async<bool>>
            let _v909 = v910 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v913 : Async<bool> = null |> unbox<Async<bool>>
            let _v909 = v913 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v916 : Async<bool> = null |> unbox<Async<bool>>
            let _v909 = v916 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v919 : Async<bool> = null |> unbox<Async<bool>>
            let _v909 = v919 
            #endif
#if FABLE_COMPILER_PYTHON
            let v922 : Async<bool> = null |> unbox<Async<bool>>
            let _v909 = v922 
            #endif
#else
            let v925 : Async<bool> option = None
            let mutable _v925 = v925 
            async {
            let v926 : Async<System.Threading.CancellationToken> = Async.CancellationToken
            let! v926 = v926 
            let v927 : System.Threading.CancellationToken = v926 
            let v928 : System.Net.Sockets.TcpClient = new System.Net.Sockets.TcpClient ()
            use v928 = v928 
            let v929 : System.Net.Sockets.TcpClient = v928 
            try
            let v930 : System.Threading.Tasks.ValueTask = v929.ConnectAsync (v1, v2, v927)
            let v931 : (unit -> System.Threading.Tasks.Task) = v930.AsTask
            let v932 : System.Threading.Tasks.Task = v931 ()
            let v933 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v934 : Async<unit> = null |> unbox<Async<unit>>
            let _v933 = v934 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v937 : Async<unit> = null |> unbox<Async<unit>>
            let _v933 = v937 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v940 : Async<unit> = null |> unbox<Async<unit>>
            let _v933 = v940 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v943 : Async<unit> = null |> unbox<Async<unit>>
            let _v933 = v943 
            #endif
#if FABLE_COMPILER_PYTHON
            let v946 : Async<unit> = null |> unbox<Async<unit>>
            let _v933 = v946 
            #endif
#else
            let v949 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
            let v950 : Async<unit> = v949 v932
            let _v933 = v950 
            #endif
            let v951 : Async<unit> = _v933 
            do! v951 
            return true 
            with ex ->
            let v956 : exn = ex
            let v957 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v958 : string = $"%A{v956}"
            let _v957 = v958 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v961 : string = $"%A{v956}"
            let _v957 = v961 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v964 : string = $"%A{v956}"
            let _v957 = v964 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v967 : string = $"%A{v956}"
            let _v957 = v967 
            #endif
#if FABLE_COMPILER_PYTHON
            let v970 : string = $"%A{v956}"
            let _v957 = v970 
            #endif
#else
            let v973 : string = $"{v956.GetType ()}: {v956.Message}"
            let _v957 = v973 
            #endif
            let v974 : string = _v957 
            let v979 : unit = ()
            let v980 : (unit -> unit) = closure6(v2, v974)
            let v981 : unit = (fun () -> v980 (); v979) ()
            return false 
            (*
            let v1749 : bool = *)
            }
            |> fun x -> _v925 <- Some x
            let v1750 : Async<bool> = match _v925 with Some x -> x | None -> failwith "async.new_async_unit / _v925=None"
            let _v909 = v1750 
            #endif
            let v1751 : Async<bool> = _v909 
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
            let v1772 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1773 : Async<US4> = null |> unbox<Async<US4>>
            let _v1772 = v1773 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1776 : Async<US4> = null |> unbox<Async<US4>>
            let _v1772 = v1776 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1779 : Async<US4> = null |> unbox<Async<US4>>
            let _v1772 = v1779 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1782 : Async<US4> = null |> unbox<Async<US4>>
            let _v1772 = v1782 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1785 : Async<US4> = null |> unbox<Async<US4>>
            let _v1772 = v1785 
            #endif
#else
            let v1788 : Async<US4> option = None
            let mutable _v1788 = v1788 
            async {
            let v1789 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1790 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v1789 = v1790 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1793 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v1789 = v1793 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1796 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v1789 = v1796 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1799 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v1789 = v1799 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1802 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v1789 = v1802 
            #endif
#else
            let v1805 : Async<Async<bool>> = Async.StartChild (v1751, v891)
            let _v1789 = v1805 
            #endif
            let v1806 : Async<Async<bool>> = _v1789 
            let! v1806 = v1806 
            let v1811 : Async<bool> = v1806 
            let v1812 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1813 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
            let _v1812 = v1813 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1816 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
            let _v1812 = v1816 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1819 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
            let _v1812 = v1819 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1822 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
            let _v1812 = v1822 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1825 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
            let _v1812 = v1825 
            #endif
#else
            let v1828 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v1829 : Async<Choice<bool, exn>> = v1828 v1811
            let _v1812 = v1829 
            #endif
            let v1830 : Async<Choice<bool, exn>> = _v1812 
            let v1835 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1836 : Async<US5> = null |> unbox<Async<US5>>
            let _v1835 = v1836 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1839 : Async<US5> = null |> unbox<Async<US5>>
            let _v1835 = v1839 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1842 : Async<US5> = null |> unbox<Async<US5>>
            let _v1835 = v1842 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1845 : Async<US5> = null |> unbox<Async<US5>>
            let _v1835 = v1845 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1848 : Async<US5> = null |> unbox<Async<US5>>
            let _v1835 = v1848 
            #endif
#else
            let v1851 : Async<US5> option = None
            let mutable _v1851 = v1851 
            async {
            let! v1830 = v1830 
            let v1852 : Choice<bool, exn> = v1830 
            let v1853 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1854 : US5 = null |> unbox<US5>
            let _v1853 = v1854 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1857 : US5 = null |> unbox<US5>
            let _v1853 = v1857 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1860 : US5 = null |> unbox<US5>
            let _v1853 = v1860 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1863 : US5 = null |> unbox<US5>
            let _v1853 = v1863 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1866 : US5 = null |> unbox<US5>
            let _v1853 = v1866 
            #endif
#else
            let v1869 : (bool -> US5) = closure17()
            let v1870 : (exn -> US5) = closure18()
            let v1871 : US5 = match v1852 with Choice1Of2 x -> v1869 x | Choice2Of2 x -> v1870 x
            let _v1853 = v1871 
            #endif
            let v1872 : US5 = _v1853 
            return v1872 
            }
            |> fun x -> _v1851 <- Some x
            let v1877 : Async<US5> = match _v1851 with Some x -> x | None -> failwith "async.new_async_unit / _v1851=None"
            let _v1835 = v1877 
            #endif
            let v1878 : Async<US5> = _v1835 
            let v1883 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1884 : Async<US6> = null |> unbox<Async<US6>>
            let _v1883 = v1884 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1887 : Async<US6> = null |> unbox<Async<US6>>
            let _v1883 = v1887 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1890 : Async<US6> = null |> unbox<Async<US6>>
            let _v1883 = v1890 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1893 : Async<US6> = null |> unbox<Async<US6>>
            let _v1883 = v1893 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1896 : Async<US6> = null |> unbox<Async<US6>>
            let _v1883 = v1896 
            #endif
#else
            let v1899 : Async<US6> option = None
            let mutable _v1899 = v1899 
            async {
            let! v1878 = v1878 
            let v1900 : US5 = v1878 
            let v1906 : US6 =
                match v1900 with
                | US5_0(v1901) -> (* C1of2 *)
                    US6_0(v1901)
                | US5_1(v1903) -> (* C2of2 *)
                    US6_1(v1903)
            return v1906 
            }
            |> fun x -> _v1899 <- Some x
            let v1907 : Async<US6> = match _v1899 with Some x -> x | None -> failwith "async.new_async_unit / _v1899=None"
            let _v1883 = v1907 
            #endif
            let v1908 : Async<US6> = _v1883 
            let v1913 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1914 : Async<US4> = null |> unbox<Async<US4>>
            let _v1913 = v1914 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1917 : Async<US4> = null |> unbox<Async<US4>>
            let _v1913 = v1917 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1920 : Async<US4> = null |> unbox<Async<US4>>
            let _v1913 = v1920 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1923 : Async<US4> = null |> unbox<Async<US4>>
            let _v1913 = v1923 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1926 : Async<US4> = null |> unbox<Async<US4>>
            let _v1913 = v1926 
            #endif
#else
            let v1929 : Async<US4> option = None
            let mutable _v1929 = v1929 
            async {
            let! v1908 = v1908 
            let v1930 : US6 = v1908 
            let v3722 : US4 =
                match v1930 with
                | US6_1(v1933) -> (* Error *)
                    let v1934 : string = $"%A{v1933}"
                    let v1937 : string = "System.TimeoutException"
                    let v1938 : bool = v1934.Contains v1937 
                    if v1938 then
                        let v1941 : unit = ()
                        let v1942 : (unit -> unit) = closure19(v891)
                        let v1943 : unit = (fun () -> v1942 (); v1941) ()
                        US4_1
                    else
                        let v2678 : unit = ()
                        let v2679 : (unit -> unit) = closure21(v891, v1933)
                        let v2680 : unit = (fun () -> v2679 (); v2678) ()
                        US4_1
                | US6_0(v1931) -> (* Ok *)
                    US4_0(v1931)
            return v3722 
            }
            |> fun x -> _v1929 <- Some x
            let v3723 : Async<US4> = match _v1929 with Some x -> x | None -> failwith "async.new_async_unit / _v1929=None"
            let _v1913 = v3723 
            #endif
            let v3724 : Async<US4> = _v1913 
            return! v3724 
            }
            |> fun x -> _v1788 <- Some x
            let v3729 : Async<US4> = match _v1788 with Some x -> x | None -> failwith "async.new_async_unit / _v1788=None"
            let _v1772 = v3729 
            #endif
            let v3730 : Async<US4> = _v1772 
            let _v1756 = v3730 
            #endif
            let v3735 : Async<US4> = _v1756 
            let! v3735 = v3735 
            let v3740 : US4 = v3735 
            let v3743 : bool =
                match v3740 with
                | US4_1 -> (* None *)
                    false
                | US4_0(v3741) -> (* Some *)
                    v3741
            return v3743 
            }
            |> fun x -> _v908 <- Some x
            let v3744 : Async<bool> = match _v908 with Some x -> x | None -> failwith "async.new_async_unit / _v908=None"
            let _v892 = v3744 
            #endif
            let v3745 : Async<bool> = _v892 
            v3745
    let! v3751 = v3751 
    let v3752 : bool = v3751 
    let v3753 : bool = v3752 = false
    if v3753 then
        return v2 
        (*
        ()
    else
        *) else
        let v3754 : int32 = v2 + 1
        let v3755 : Async<int32> = method12(v0, v1, v3754)
        return! v3755 
        (*
        ()
    *)
    }
    |> fun x -> _v19 <- Some x
    let v3756 : Async<int32> = match _v19 with Some x -> x | None -> failwith "async.new_async_unit / _v19=None"
    let _v3 = v3756 
    #endif
    let v3757 : Async<int32> = _v3 
    v3757
and closure33 (v0 : int32 option, v1 : string) (v2 : int32) : Async<int32> =
    method12(v0, v1, v2)
and closure32 (v0 : int32 option) (v1 : string) : (int32 -> Async<int32>) =
    closure33(v0, v1)
and closure31 () (v0 : int32 option) : (string -> (int32 -> Async<int32>)) =
    closure32(v0)
let v0 : unit = ()
let v1 : (unit -> unit) = closure0()
let v2 : unit = (fun () -> v1 (); v0) ()
let v15 : (string -> (int32 -> Async<bool>)) = closure4()
let test_port_open x = v15 x
let v16 : (int32 -> (string -> (int32 -> Async<bool>))) = closure14()
let test_port_open_timeout x = v16 x
let v17 : (int32 option -> (bool -> (string -> (int32 -> Async<int64>)))) = closure23()
let wait_for_port_access x = v17 x
let v18 : (int32 option -> (string -> (int32 -> Async<int32>))) = closure31()
let get_available_port x = v18 x
()
