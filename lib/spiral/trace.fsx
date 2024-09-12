#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::string::String")>]
#endif
type std_string_String = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("&$0")>]
#endif
type Ref<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("mut $0")>]
#endif
type Mut<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("Vec<$0>")>]
#endif
type Vec<'T> = class end
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
and closure8 (v0 : Mut0) () : unit =
    let v1 : int64 = v0.l0
    let v2 : int64 = v1 + 1L
    v0.l0 <- v2
    ()
and closure9 (v0 : US3 option ref) (v1 : US3 option) : US3 option ref =
    v0.Value <- v1 
    v0
and closure10 (v0 : int64 option, v1 : (US3 option -> US3 option ref)) () : unit =
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
and closure11 (v0 : Mut3, v1 : string) () : unit =
    let v2 : string = v0.l0
    let v3 : string = v2 + v1 
    v0.l0 <- v3
    ()
and closure13 (v0 : string) () : unit =
    let v1 : (string -> unit) = System.Console.WriteLine
    v1 v0
and closure12 () (v0 : string) : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure13(v0)
    let v3 : unit = (fun () -> v2 (); v1) ()
    ()
and closure7 (v0 : US0, v1 : (unit -> string), v2 : (unit -> string)) () : unit =
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
    let v76 : bool =
        if v72 then
            false
        else
            let v73 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v0
            let v74 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v70
            let v75 : bool = v73 >= v74
            v75
    if v76 then
        let v77 : unit = ()
        let v78 : (unit -> unit) = closure8(v19)
        let v79 : unit = (fun () -> v78 (); v77) ()
        let v82 : unit = ()
        let v83 : unit = (fun () -> v4 (); v82) ()
        let struct (v97 : Mut0, v98 : Mut1, v99 : Mut2, v100 : Mut3, v101 : Mut4, v102 : int64 option) = TraceState.trace_state.Value
        let v115 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v116 : US3 option = None
        let _v116 = ref v116 
        let v117 : US3 option ref = _v116 
        let v118 : (US3 option -> US3 option ref) = closure9(v117)
        let v119 : unit = ()
        let v120 : (unit -> unit) = closure10(v102, v118)
        let v121 : unit = (fun () -> v120 (); v119) ()
        let v124 : US3 option = _v116.Value 
        let v135 : US3 = US3_1
        let v136 : US3 = v124 |> Option.defaultValue v135 
        let v176 : System.DateTime =
            match v136 with
            | US3_1 -> (* None *)
                let v172 : System.DateTime = System.DateTime.Now
                v172
            | US3_0(v140) -> (* Some *)
                let v141 : System.DateTime = System.DateTime.Now
                let v144 : (System.DateTime -> int64) = _.Ticks
                let v145 : int64 = v144 v141
                let v148 : int64 = v145 - v140
                let v149 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v150 : System.TimeSpan = v149 v148
                let v153 : (System.TimeSpan -> int32) = _.Hours
                let v154 : int32 = v153 v150
                let v157 : (System.TimeSpan -> int32) = _.Minutes
                let v158 : int32 = v157 v150
                let v161 : (System.TimeSpan -> int32) = _.Seconds
                let v162 : int32 = v161 v150
                let v165 : (System.TimeSpan -> int32) = _.Milliseconds
                let v166 : int32 = v165 v150
                let v169 : System.DateTime = System.DateTime (1, 1, 1, v154, v158, v162, v166)
                v169
        let v177 : string = method5()
        let v180 : (string -> string) = v176.ToString
        let v181 : string = v180 v177
        let _v115 = v181 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v184 : US3 option = None
        let _v184 = ref v184 
        let v185 : US3 option ref = _v184 
        let v186 : (US3 option -> US3 option ref) = closure9(v185)
        let v187 : unit = ()
        let v188 : (unit -> unit) = closure10(v102, v186)
        let v189 : unit = (fun () -> v188 (); v187) ()
        let v192 : US3 option = _v184.Value 
        let v203 : US3 = US3_1
        let v204 : US3 = v192 |> Option.defaultValue v203 
        let v244 : System.DateTime =
            match v204 with
            | US3_1 -> (* None *)
                let v240 : System.DateTime = System.DateTime.Now
                v240
            | US3_0(v208) -> (* Some *)
                let v209 : System.DateTime = System.DateTime.Now
                let v212 : (System.DateTime -> int64) = _.Ticks
                let v213 : int64 = v212 v209
                let v216 : int64 = v213 - v208
                let v217 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v218 : System.TimeSpan = v217 v216
                let v221 : (System.TimeSpan -> int32) = _.Hours
                let v222 : int32 = v221 v218
                let v225 : (System.TimeSpan -> int32) = _.Minutes
                let v226 : int32 = v225 v218
                let v229 : (System.TimeSpan -> int32) = _.Seconds
                let v230 : int32 = v229 v218
                let v233 : (System.TimeSpan -> int32) = _.Milliseconds
                let v234 : int32 = v233 v218
                let v237 : System.DateTime = System.DateTime (1, 1, 1, v222, v226, v230, v234)
                v237
        let v245 : string = method5()
        let v248 : (string -> string) = v244.ToString
        let v249 : string = v248 v245
        let _v115 = v249 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v252 : string = $"near_sdk::env::block_timestamp()"
        let v253 : uint64 = Fable.Core.RustInterop.emitRustExpr () v252 
        let v254 : US3 option = None
        let _v254 = ref v254 
        let v255 : US3 option ref = _v254 
        let v256 : (US3 option -> US3 option ref) = closure9(v255)
        let v257 : unit = ()
        let v258 : (unit -> unit) = closure10(v102, v256)
        let v259 : unit = (fun () -> v258 (); v257) ()
        let v262 : US3 option = _v254.Value 
        let v273 : US3 = US3_1
        let v274 : US3 = v262 |> Option.defaultValue v273 
        let v283 : uint64 =
            match v274 with
            | US3_1 -> (* None *)
                v253
            | US3_0(v278) -> (* Some *)
                let v279 : (int64 -> uint64) = uint64
                let v280 : uint64 = v279 v278
                let v281 : uint64 = v253 - v280
                v281
        let v284 : uint64 = v283 / 1000000000UL
        let v285 : uint64 = v284 % 60UL
        let v286 : uint64 = v284 / 60UL
        let v287 : uint64 = v286 % 60UL
        let v288 : uint64 = v284 / 3600UL
        let v289 : uint64 = v288 % 24UL
        let v290 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
        let v291 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v289, v287, v285) v290 
        let v292 : string = "fable_library_rust::String_::fromString($0)"
        let v293 : string = Fable.Core.RustInterop.emitRustExpr v291 v292 
        let _v115 = v293 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v294 : US3 option = None
        let _v294 = ref v294 
        let v295 : US3 option ref = _v294 
        let v296 : (US3 option -> US3 option ref) = closure9(v295)
        let v297 : unit = ()
        let v298 : (unit -> unit) = closure10(v102, v296)
        let v299 : unit = (fun () -> v298 (); v297) ()
        let v302 : US3 option = _v294.Value 
        let v313 : US3 = US3_1
        let v314 : US3 = v302 |> Option.defaultValue v313 
        let v354 : System.DateTime =
            match v314 with
            | US3_1 -> (* None *)
                let v350 : System.DateTime = System.DateTime.Now
                v350
            | US3_0(v318) -> (* Some *)
                let v319 : System.DateTime = System.DateTime.Now
                let v322 : (System.DateTime -> int64) = _.Ticks
                let v323 : int64 = v322 v319
                let v326 : int64 = v323 - v318
                let v327 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v328 : System.TimeSpan = v327 v326
                let v331 : (System.TimeSpan -> int32) = _.Hours
                let v332 : int32 = v331 v328
                let v335 : (System.TimeSpan -> int32) = _.Minutes
                let v336 : int32 = v335 v328
                let v339 : (System.TimeSpan -> int32) = _.Seconds
                let v340 : int32 = v339 v328
                let v343 : (System.TimeSpan -> int32) = _.Milliseconds
                let v344 : int32 = v343 v328
                let v347 : System.DateTime = System.DateTime (1, 1, 1, v332, v336, v340, v344)
                v347
        let v355 : string = method6()
        let v358 : (string -> string) = v354.ToString
        let v359 : string = v358 v355
        let _v115 = v359 
        #endif
#if FABLE_COMPILER_PYTHON
        let v362 : US3 option = None
        let _v362 = ref v362 
        let v363 : US3 option ref = _v362 
        let v364 : (US3 option -> US3 option ref) = closure9(v363)
        let v365 : unit = ()
        let v366 : (unit -> unit) = closure10(v102, v364)
        let v367 : unit = (fun () -> v366 (); v365) ()
        let v370 : US3 option = _v362.Value 
        let v381 : US3 = US3_1
        let v382 : US3 = v370 |> Option.defaultValue v381 
        let v422 : System.DateTime =
            match v382 with
            | US3_1 -> (* None *)
                let v418 : System.DateTime = System.DateTime.Now
                v418
            | US3_0(v386) -> (* Some *)
                let v387 : System.DateTime = System.DateTime.Now
                let v390 : (System.DateTime -> int64) = _.Ticks
                let v391 : int64 = v390 v387
                let v394 : int64 = v391 - v386
                let v395 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v396 : System.TimeSpan = v395 v394
                let v399 : (System.TimeSpan -> int32) = _.Hours
                let v400 : int32 = v399 v396
                let v403 : (System.TimeSpan -> int32) = _.Minutes
                let v404 : int32 = v403 v396
                let v407 : (System.TimeSpan -> int32) = _.Seconds
                let v408 : int32 = v407 v396
                let v411 : (System.TimeSpan -> int32) = _.Milliseconds
                let v412 : int32 = v411 v396
                let v415 : System.DateTime = System.DateTime (1, 1, 1, v400, v404, v408, v412)
                v415
        let v423 : string = method6()
        let v426 : (string -> string) = v422.ToString
        let v427 : string = v426 v423
        let _v115 = v427 
        #endif
#else
        let v430 : US3 option = None
        let _v430 = ref v430 
        let v431 : US3 option ref = _v430 
        let v432 : (US3 option -> US3 option ref) = closure9(v431)
        let v433 : unit = ()
        let v434 : (unit -> unit) = closure10(v102, v432)
        let v435 : unit = (fun () -> v434 (); v433) ()
        let v438 : US3 option = _v430.Value 
        let v449 : US3 = US3_1
        let v450 : US3 = v438 |> Option.defaultValue v449 
        let v490 : System.DateTime =
            match v450 with
            | US3_1 -> (* None *)
                let v486 : System.DateTime = System.DateTime.Now
                v486
            | US3_0(v454) -> (* Some *)
                let v455 : System.DateTime = System.DateTime.Now
                let v458 : (System.DateTime -> int64) = _.Ticks
                let v459 : int64 = v458 v455
                let v462 : int64 = v459 - v454
                let v463 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v464 : System.TimeSpan = v463 v462
                let v467 : (System.TimeSpan -> int32) = _.Hours
                let v468 : int32 = v467 v464
                let v471 : (System.TimeSpan -> int32) = _.Minutes
                let v472 : int32 = v471 v464
                let v475 : (System.TimeSpan -> int32) = _.Seconds
                let v476 : int32 = v475 v464
                let v479 : (System.TimeSpan -> int32) = _.Milliseconds
                let v480 : int32 = v479 v464
                let v483 : System.DateTime = System.DateTime (1, 1, 1, v468, v472, v476, v480)
                v483
        let v491 : string = method6()
        let v494 : (string -> string) = v490.ToString
        let v495 : string = v494 v491
        let _v115 = v495 
        #endif
        let v498 : string = _v115 
        
        
        
        
        
        let v568 : bool =
            match v0 with
            | US0_0 -> (* Verbose *)
                true
            | _ ->
                false
        let v572 : US1 =
            if v568 then
                let v569 : string = "Verbose"
                US1_0(v569)
            else
                US1_1
        let v613 : US1 =
            match v572 with
            | US1_1 -> (* None *)
                let v575 : bool =
                    match v0 with
                    | US0_1 -> (* Debug *)
                        true
                    | _ ->
                        false
                let v579 : US1 =
                    if v575 then
                        let v576 : string = "Debug"
                        US1_0(v576)
                    else
                        US1_1
                match v579 with
                | US1_1 -> (* None *)
                    let v582 : bool =
                        match v0 with
                        | US0_2 -> (* Info *)
                            true
                        | _ ->
                            false
                    let v586 : US1 =
                        if v582 then
                            let v583 : string = "Info"
                            US1_0(v583)
                        else
                            US1_1
                    match v586 with
                    | US1_1 -> (* None *)
                        let v589 : bool =
                            match v0 with
                            | US0_3 -> (* Warning *)
                                true
                            | _ ->
                                false
                        let v593 : US1 =
                            if v589 then
                                let v590 : string = "Warning"
                                US1_0(v590)
                            else
                                US1_1
                        match v593 with
                        | US1_1 -> (* None *)
                            let v596 : bool =
                                match v0 with
                                | US0_4 -> (* Critical *)
                                    true
                                | _ ->
                                    false
                            let v600 : US1 =
                                if v596 then
                                    let v597 : string = "Critical"
                                    US1_0(v597)
                                else
                                    US1_1
                            match v600 with
                            | US1_1 -> (* None *)
                                US1_1
                            | US1_0(v601) -> (* Some *)
                                US1_0(v601)
                        | US1_0(v594) -> (* Some *)
                            US1_0(v594)
                    | US1_0(v587) -> (* Some *)
                        US1_0(v587)
                | US1_0(v580) -> (* Some *)
                    US1_0(v580)
            | US1_0(v573) -> (* Some *)
                US1_0(v573)
        let v617 : string =
            match v613 with
            | US1_1 -> (* None *)
                failwith<string> "Option does not have a value."
            | US1_0(v614) -> (* Some *)
                v614
        let v618 : (unit -> string) = v617.ToLower
        let v619 : string = v618 ()
        let v622 : string = v619.PadLeft (7, ' ')
        let v636 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v651 : Ref<Str> =
            match v0 with
            | US0_4 -> (* Critical *)
                let v645 : string = "inline_colorization::color_bright_red"
                let v646 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v645 
                v646
            | US0_1 -> (* Debug *)
                let v639 : string = "inline_colorization::color_bright_blue"
                let v640 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v639 
                v640
            | US0_2 -> (* Info *)
                let v641 : string = "inline_colorization::color_bright_green"
                let v642 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v641 
                v642
            | US0_0 -> (* Verbose *)
                let v637 : string = "inline_colorization::color_bright_black"
                let v638 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v637 
                v638
            | US0_3 -> (* Warning *)
                let v643 : string = "inline_colorization::color_yellow"
                let v644 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v643 
                v644
        let v652 : string = "&*$0"
        let v653 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v622 v652 
        let v654 : string = "inline_colorization::color_reset"
        let v655 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v654 
        let v656 : string = "\"{v651}{v653}{v655}\""
        let v657 : string = @$"format!(" + v656 + ")"
        let v658 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v657 
        let v659 : string = "fable_library_rust::String_::fromString($0)"
        let v660 : string = Fable.Core.RustInterop.emitRustExpr v658 v659 
        let _v636 = v660 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v675 : Ref<Str> =
            match v0 with
            | US0_4 -> (* Critical *)
                let v669 : string = "inline_colorization::color_bright_red"
                let v670 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v669 
                v670
            | US0_1 -> (* Debug *)
                let v663 : string = "inline_colorization::color_bright_blue"
                let v664 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v663 
                v664
            | US0_2 -> (* Info *)
                let v665 : string = "inline_colorization::color_bright_green"
                let v666 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v665 
                v666
            | US0_0 -> (* Verbose *)
                let v661 : string = "inline_colorization::color_bright_black"
                let v662 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v661 
                v662
            | US0_3 -> (* Warning *)
                let v667 : string = "inline_colorization::color_yellow"
                let v668 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v667 
                v668
        let v676 : string = "&*$0"
        let v677 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v622 v676 
        let v678 : string = "inline_colorization::color_reset"
        let v679 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v678 
        let v680 : string = "\"{v675}{v677}{v679}\""
        let v681 : string = @$"format!(" + v680 + ")"
        let v682 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v681 
        let v683 : string = "fable_library_rust::String_::fromString($0)"
        let v684 : string = Fable.Core.RustInterop.emitRustExpr v682 v683 
        let _v636 = v684 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v699 : Ref<Str> =
            match v0 with
            | US0_4 -> (* Critical *)
                let v693 : string = "inline_colorization::color_bright_red"
                let v694 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v693 
                v694
            | US0_1 -> (* Debug *)
                let v687 : string = "inline_colorization::color_bright_blue"
                let v688 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v687 
                v688
            | US0_2 -> (* Info *)
                let v689 : string = "inline_colorization::color_bright_green"
                let v690 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v689 
                v690
            | US0_0 -> (* Verbose *)
                let v685 : string = "inline_colorization::color_bright_black"
                let v686 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v685 
                v686
            | US0_3 -> (* Warning *)
                let v691 : string = "inline_colorization::color_yellow"
                let v692 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v691 
                v692
        let v700 : string = "&*$0"
        let v701 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v622 v700 
        let v702 : string = "inline_colorization::color_reset"
        let v703 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v702 
        let v704 : string = "\"{v699}{v701}{v703}\""
        let v705 : string = @$"format!(" + v704 + ")"
        let v706 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v705 
        let v707 : string = "fable_library_rust::String_::fromString($0)"
        let v708 : string = Fable.Core.RustInterop.emitRustExpr v706 v707 
        let _v636 = v708 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v718 : string =
            match v0 with
            | US0_4 -> (* Critical *)
                let v713 : string = "\u001b[91m"
                v713
            | US0_1 -> (* Debug *)
                let v710 : string = "\u001b[94m"
                v710
            | US0_2 -> (* Info *)
                let v711 : string = "\u001b[92m"
                v711
            | US0_0 -> (* Verbose *)
                let v709 : string = "\u001b[90m"
                v709
            | US0_3 -> (* Warning *)
                let v712 : string = "\u001b[93m"
                v712
        let v719 : string = method7()
        let v720 : string = v718 + v622 
        let v721 : string = v720 + v719 
        let _v636 = v721 
        #endif
#if FABLE_COMPILER_PYTHON
        let v731 : string =
            match v0 with
            | US0_4 -> (* Critical *)
                let v726 : string = "\u001b[91m"
                v726
            | US0_1 -> (* Debug *)
                let v723 : string = "\u001b[94m"
                v723
            | US0_2 -> (* Info *)
                let v724 : string = "\u001b[92m"
                v724
            | US0_0 -> (* Verbose *)
                let v722 : string = "\u001b[90m"
                v722
            | US0_3 -> (* Warning *)
                let v725 : string = "\u001b[93m"
                v725
        let v732 : string = method7()
        let v733 : string = v731 + v622 
        let v734 : string = v733 + v732 
        let _v636 = v734 
        #endif
#else
        let v744 : string =
            match v0 with
            | US0_4 -> (* Critical *)
                let v739 : string = "\u001b[91m"
                v739
            | US0_1 -> (* Debug *)
                let v736 : string = "\u001b[94m"
                v736
            | US0_2 -> (* Info *)
                let v737 : string = "\u001b[92m"
                v737
            | US0_0 -> (* Verbose *)
                let v735 : string = "\u001b[90m"
                v735
            | US0_3 -> (* Warning *)
                let v738 : string = "\u001b[93m"
                v738
        let v745 : string = method7()
        let v746 : string = v744 + v622 
        let v747 : string = v746 + v745 
        let _v636 = v747 
        #endif
        let v748 : string = _v636 
        let v763 : int64 = v97.l0
        let v764 : string = v2 ()
        let v765 : string = method8()
        let v766 : Mut3 = {l0 = v765} : Mut3
        let v767 : string = $"{v764}"
        let v770 : unit = ()
        let v771 : (unit -> unit) = closure11(v766, v767)
        let v772 : unit = (fun () -> v771 (); v770) ()
        let v775 : string = v766.l0
        let v776 : string = v1 ()
        let v777 : bool = v776 = ""
        let v834 : string =
            if v777 then
                let v778 : string = ""
                v778
            else
                let v779 : string = $"{v498} {v748} #{v763} %s{v776} / {v775}"
                let v782 : char list = []
                let v783 : (char list -> (char [])) = List.toArray
                let v784 : (char []) = v783 v782
                let v787 : string = v779.TrimStart v784 
                let v805 : char list = []
                let v806 : char list = '/' :: v805 
                let v809 : char list = ' ' :: v806 
                let v812 : (char list -> (char [])) = List.toArray
                let v813 : (char []) = v812 v809
                let v816 : string = v787.TrimEnd v813 
                v816
        let v835 : (string -> unit) = closure12()
        let v836 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v837 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v834 v837 
        let _v836 = () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v838 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v834 v838 
        let _v836 = () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v839 : string = v22.l0
        let v840 : bool = v839 = ""
        let v848 : string =
            if v840 then
                v834
            else
                let v841 : bool = v834 = ""
                if v841 then
                    let v842 : string = v22.l0
                    v842
                else
                    let v843 : string = v22.l0
                    let v844 : string = "\n"
                    let v845 : string = v843 + v844 
                    let v846 : string = v845 + v834 
                    v846
        let v849 : string = "&*$0"
        let v850 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v848 v849 
        let v851 : string = $"$0.chars()"
        let v852 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v850 v851 
        let v853 : string = "v852"
        let v854 : _ = Fable.Core.RustInterop.emitRustExpr () v853 
        let v855 : string = "v854.collect::<Vec<_>>()"
        let v856 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v855 
        let v857 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
        let v858 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v856 v857 
        let v859 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
        let v860 : bool = Fable.Core.RustInterop.emitRustExpr v858 v859 
        let v861 : string = "x"
        let v862 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v861 
        let v863 : string = "String::from_iter($0)"
        let v864 : std_string_String = Fable.Core.RustInterop.emitRustExpr v862 v863 
        let v865 : string = "true; $0 }).collect::<Vec<_>>()"
        let v866 : bool = Fable.Core.RustInterop.emitRustExpr v864 v865 
        let v867 : string = "_vec_map"
        let v868 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v867 
        let v869 : string = "$0.len()"
        let v870 : unativeint = Fable.Core.RustInterop.emitRustExpr v868 v869 
        let v871 : (unativeint -> int32) = int32
        let v872 : int32 = v871 v870
        let v873 : string = ""
        let v874 : bool = v834 <> v873 
        let v878 : bool =
            if v874 then
                let v877 : bool = v872 <= 1
                v877
            else
                false
        if v878 then
            v22.l0 <- v848
            ()
        else
            v22.l0 <- v873
            let v879 : string = "true; $0.into_iter().for_each(|x| { //"
            let v880 : bool = Fable.Core.RustInterop.emitRustExpr v868 v879 
            let v881 : string = "x"
            let v882 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v881 
            let v883 : string = $"near_sdk::log!(\"{{}}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v882 v883 
            let v884 : string = $"true;"
            let v885 : bool = Fable.Core.RustInterop.emitRustExpr () v884 
            let v886 : string = "true; }}); { //"
            let v887 : bool = Fable.Core.RustInterop.emitRustExpr () v886 
            ()
        let _v836 = () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        v835 v834
        let _v836 = () 
        #endif
#if FABLE_COMPILER_PYTHON
        v835 v834
        let _v836 = () 
        #endif
#else
        v835 v834
        let _v836 = () 
        #endif
        _v836 
        let v888 : (string -> unit) = v20.l0
        v888 v834
and closure6 (v0 : US0, v1 : (unit -> string)) (v2 : (unit -> string)) : unit =
    let v3 : unit = ()
    let v4 : (unit -> unit) = closure7(v0, v1, v2)
    let v5 : unit = (fun () -> v4 (); v3) ()
    ()
and closure5 (v0 : US0) (v1 : (unit -> string)) : ((unit -> string) -> unit) =
    closure6(v0, v1)
and closure4 () (v0 : US0) : ((unit -> string) -> ((unit -> string) -> unit)) =
    closure5(v0)
let v0 : unit = ()
let v1 : (unit -> unit) = closure0()
let v2 : unit = (fun () -> v1 (); v0) ()
let v16 : (US0 -> ((unit -> string) -> ((unit -> string) -> unit))) = closure4()
let trace x = v16 x
()
