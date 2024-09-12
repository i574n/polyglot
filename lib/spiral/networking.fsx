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
and closure10 (v0 : Mut3, v1 : string) () : unit =
    let v2 : string = v0.l0
    let v3 : string = v2 + v1 
    v0.l0 <- v3
    ()
and closure12 (v0 : string) () : unit =
    let v1 : (string -> unit) = System.Console.WriteLine
    v1 v0
and closure11 () (v0 : string) : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure12(v0)
    let v3 : unit = (fun () -> v2 (); v1) ()
    ()
and closure6 (v0 : int32, v1 : string) () : unit =
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
            let v73 : bool = 0 >= v72
            v73
    if v74 then
        let v75 : unit = ()
        let v76 : (unit -> unit) = closure7(v18)
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
        let v116 : (US3 option -> US3 option ref) = closure8(v115)
        let v117 : unit = ()
        let v118 : (unit -> unit) = closure9(v100, v116)
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
        let v175 : string = method5()
        let v178 : (string -> string) = v174.ToString
        let v179 : string = v178 v175
        let _v113 = v179 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v182 : US3 option = None
        let _v182 = ref v182 
        let v183 : US3 option ref = _v182 
        let v184 : (US3 option -> US3 option ref) = closure8(v183)
        let v185 : unit = ()
        let v186 : (unit -> unit) = closure9(v100, v184)
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
        let v243 : string = method5()
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
        let v254 : (US3 option -> US3 option ref) = closure8(v253)
        let v255 : unit = ()
        let v256 : (unit -> unit) = closure9(v100, v254)
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
        let v294 : (US3 option -> US3 option ref) = closure8(v293)
        let v295 : unit = ()
        let v296 : (unit -> unit) = closure9(v100, v294)
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
        let v353 : string = method6()
        let v356 : (string -> string) = v352.ToString
        let v357 : string = v356 v353
        let _v113 = v357 
        #endif
#if FABLE_COMPILER_PYTHON
        let v360 : US3 option = None
        let _v360 = ref v360 
        let v361 : US3 option ref = _v360 
        let v362 : (US3 option -> US3 option ref) = closure8(v361)
        let v363 : unit = ()
        let v364 : (unit -> unit) = closure9(v100, v362)
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
        let v421 : string = method6()
        let v424 : (string -> string) = v420.ToString
        let v425 : string = v424 v421
        let _v113 = v425 
        #endif
#else
        let v428 : US3 option = None
        let _v428 = ref v428 
        let v429 : US3 option ref = _v428 
        let v430 : (US3 option -> US3 option ref) = closure8(v429)
        let v431 : unit = ()
        let v432 : (unit -> unit) = closure9(v100, v430)
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
        let v489 : string = method6()
        let v492 : (string -> string) = v488.ToString
        let v493 : string = v492 v489
        let _v113 = v493 
        #endif
        let v496 : string = _v113 
        
        
        
        
        
        let v566 : string = "Verbose"
        let v567 : (unit -> string) = v566.ToLower
        let v568 : string = v567 ()
        let v571 : string = v568.PadLeft (7, ' ')
        let v585 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v586 : string = "inline_colorization::color_bright_black"
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
        let v597 : string = "inline_colorization::color_bright_black"
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
        let v608 : string = "inline_colorization::color_bright_black"
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
        let v619 : string = "\u001b[90m"
        let v620 : string = method7()
        let v621 : string = v619 + v571 
        let v622 : string = v621 + v620 
        let _v585 = v622 
        #endif
#if FABLE_COMPILER_PYTHON
        let v623 : string = "\u001b[90m"
        let v624 : string = method7()
        let v625 : string = v623 + v571 
        let v626 : string = v625 + v624 
        let _v585 = v626 
        #endif
#else
        let v627 : string = "\u001b[90m"
        let v628 : string = method7()
        let v629 : string = v627 + v571 
        let v630 : string = v629 + v628 
        let _v585 = v630 
        #endif
        let v631 : string = _v585 
        let v637 : int64 = v95.l0
        let v638 : string = method8()
        let v639 : Mut3 = {l0 = v638} : Mut3
        let v640 : string = "{ "
        let v641 : string = $"{v640}"
        let v644 : unit = ()
        let v645 : (unit -> unit) = closure10(v639, v641)
        let v646 : unit = (fun () -> v645 (); v644) ()
        let v649 : string = "port"
        let v650 : string = $"{v649}"
        let v653 : unit = ()
        let v654 : (unit -> unit) = closure10(v639, v650)
        let v655 : unit = (fun () -> v654 (); v653) ()
        let v658 : string = " = "
        let v659 : string = $"{v658}"
        let v662 : unit = ()
        let v663 : (unit -> unit) = closure10(v639, v659)
        let v664 : unit = (fun () -> v663 (); v662) ()
        let v667 : string = $"{v0}"
        let v670 : unit = ()
        let v671 : (unit -> unit) = closure10(v639, v667)
        let v672 : unit = (fun () -> v671 (); v670) ()
        let v675 : string = "; "
        let v676 : string = $"{v675}"
        let v679 : unit = ()
        let v680 : (unit -> unit) = closure10(v639, v676)
        let v681 : unit = (fun () -> v680 (); v679) ()
        let v684 : string = "ex"
        let v685 : string = $"{v684}"
        let v688 : unit = ()
        let v689 : (unit -> unit) = closure10(v639, v685)
        let v690 : unit = (fun () -> v689 (); v688) ()
        let v693 : string = $"{v658}"
        let v696 : unit = ()
        let v697 : (unit -> unit) = closure10(v639, v693)
        let v698 : unit = (fun () -> v697 (); v696) ()
        let v701 : string = $"{v1}"
        let v704 : unit = ()
        let v705 : (unit -> unit) = closure10(v639, v701)
        let v706 : unit = (fun () -> v705 (); v704) ()
        let v709 : string = " }"
        let v710 : string = $"{v709}"
        let v713 : unit = ()
        let v714 : (unit -> unit) = closure10(v639, v710)
        let v715 : unit = (fun () -> v714 (); v713) ()
        let v718 : string = v639.l0
        let v719 : string = $"networking.test_port_open"
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
        let v778 : (string -> unit) = closure11()
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
    let v905 : bool = *)
    }
    |> fun x -> _v18 <- Some x
    let v906 : Async<bool> = match _v18 with Some x -> x | None -> failwith "async.new_async_unit / _v18=None"
    let _v2 = v906 
    #endif
    let v907 : Async<bool> = _v2 
    v907
and closure4 () (v0 : string) : (int32 -> Async<bool>) =
    closure5(v0)
and closure16 () (v0 : bool) : US5 =
    US5_0(v0)
and closure17 () (v0 : exn) : US5 =
    US5_1(v0)
and closure18 (v0 : int32) () : unit =
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
        let v75 : (unit -> unit) = closure7(v17)
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
        let v115 : (US3 option -> US3 option ref) = closure8(v114)
        let v116 : unit = ()
        let v117 : (unit -> unit) = closure9(v99, v115)
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
        let v174 : string = method5()
        let v177 : (string -> string) = v173.ToString
        let v178 : string = v177 v174
        let _v112 = v178 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v181 : US3 option = None
        let _v181 = ref v181 
        let v182 : US3 option ref = _v181 
        let v183 : (US3 option -> US3 option ref) = closure8(v182)
        let v184 : unit = ()
        let v185 : (unit -> unit) = closure9(v99, v183)
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
        let v242 : string = method5()
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
        let v253 : (US3 option -> US3 option ref) = closure8(v252)
        let v254 : unit = ()
        let v255 : (unit -> unit) = closure9(v99, v253)
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
        let v293 : (US3 option -> US3 option ref) = closure8(v292)
        let v294 : unit = ()
        let v295 : (unit -> unit) = closure9(v99, v293)
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
        let v352 : string = method6()
        let v355 : (string -> string) = v351.ToString
        let v356 : string = v355 v352
        let _v112 = v356 
        #endif
#if FABLE_COMPILER_PYTHON
        let v359 : US3 option = None
        let _v359 = ref v359 
        let v360 : US3 option ref = _v359 
        let v361 : (US3 option -> US3 option ref) = closure8(v360)
        let v362 : unit = ()
        let v363 : (unit -> unit) = closure9(v99, v361)
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
        let v420 : string = method6()
        let v423 : (string -> string) = v419.ToString
        let v424 : string = v423 v420
        let _v112 = v424 
        #endif
#else
        let v427 : US3 option = None
        let _v427 = ref v427 
        let v428 : US3 option ref = _v427 
        let v429 : (US3 option -> US3 option ref) = closure8(v428)
        let v430 : unit = ()
        let v431 : (unit -> unit) = closure9(v99, v429)
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
        let v488 : string = method6()
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
        let v619 : string = method7()
        let v620 : string = v618 + v570 
        let v621 : string = v620 + v619 
        let _v584 = v621 
        #endif
#if FABLE_COMPILER_PYTHON
        let v622 : string = "\u001b[90m"
        let v623 : string = method7()
        let v624 : string = v622 + v570 
        let v625 : string = v624 + v623 
        let _v584 = v625 
        #endif
#else
        let v626 : string = "\u001b[90m"
        let v627 : string = method7()
        let v628 : string = v626 + v570 
        let v629 : string = v628 + v627 
        let _v584 = v629 
        #endif
        let v630 : string = _v584 
        let v636 : int64 = v94.l0
        let v637 : string = method8()
        let v638 : Mut3 = {l0 = v637} : Mut3
        let v639 : string = "{ "
        let v640 : string = $"{v639}"
        let v643 : unit = ()
        let v644 : (unit -> unit) = closure10(v638, v640)
        let v645 : unit = (fun () -> v644 (); v643) ()
        let v648 : string = "timeout"
        let v649 : string = $"{v648}"
        let v652 : unit = ()
        let v653 : (unit -> unit) = closure10(v638, v649)
        let v654 : unit = (fun () -> v653 (); v652) ()
        let v657 : string = " = "
        let v658 : string = $"{v657}"
        let v661 : unit = ()
        let v662 : (unit -> unit) = closure10(v638, v658)
        let v663 : unit = (fun () -> v662 (); v661) ()
        let v666 : string = $"{v0}"
        let v669 : unit = ()
        let v670 : (unit -> unit) = closure10(v638, v666)
        let v671 : unit = (fun () -> v670 (); v669) ()
        let v674 : string = " }"
        let v675 : string = $"{v674}"
        let v678 : unit = ()
        let v679 : (unit -> unit) = closure10(v638, v675)
        let v680 : unit = (fun () -> v679 (); v678) ()
        let v683 : string = v638.l0
        let v684 : string = "async.run_with_timeout_async"
        let v685 : bool = v684 = ""
        let v742 : string =
            if v685 then
                let v686 : string = ""
                v686
            else
                let v687 : string = $"{v495} {v630} #{v636} %s{v684} / {v683}"
                let v690 : char list = []
                let v691 : (char list -> (char [])) = List.toArray
                let v692 : (char []) = v691 v690
                let v695 : string = v687.TrimStart v692 
                let v713 : char list = []
                let v714 : char list = '/' :: v713 
                let v717 : char list = ' ' :: v714 
                let v720 : (char list -> (char [])) = List.toArray
                let v721 : (char []) = v720 v717
                let v724 : string = v695.TrimEnd v721 
                v724
        let v743 : (string -> unit) = closure11()
        let v744 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v745 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v742 v745 
        let _v744 = () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v746 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v742 v746 
        let _v744 = () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v747 : string = v20.l0
        let v748 : bool = v747 = ""
        let v756 : string =
            if v748 then
                v742
            else
                let v749 : bool = v742 = ""
                if v749 then
                    let v750 : string = v20.l0
                    v750
                else
                    let v751 : string = v20.l0
                    let v752 : string = "\n"
                    let v753 : string = v751 + v752 
                    let v754 : string = v753 + v742 
                    v754
        let v757 : string = "&*$0"
        let v758 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v756 v757 
        let v759 : string = $"$0.chars()"
        let v760 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v758 v759 
        let v761 : string = "v760"
        let v762 : _ = Fable.Core.RustInterop.emitRustExpr () v761 
        let v763 : string = "v762.collect::<Vec<_>>()"
        let v764 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v763 
        let v765 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
        let v766 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v764 v765 
        let v767 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
        let v768 : bool = Fable.Core.RustInterop.emitRustExpr v766 v767 
        let v769 : string = "x"
        let v770 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v769 
        let v771 : string = "String::from_iter($0)"
        let v772 : std_string_String = Fable.Core.RustInterop.emitRustExpr v770 v771 
        let v773 : string = "true; $0 }).collect::<Vec<_>>()"
        let v774 : bool = Fable.Core.RustInterop.emitRustExpr v772 v773 
        let v775 : string = "_vec_map"
        let v776 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v775 
        let v777 : string = "$0.len()"
        let v778 : unativeint = Fable.Core.RustInterop.emitRustExpr v776 v777 
        let v779 : (unativeint -> int32) = int32
        let v780 : int32 = v779 v778
        let v781 : string = ""
        let v782 : bool = v742 <> v781 
        let v786 : bool =
            if v782 then
                let v785 : bool = v780 <= 1
                v785
            else
                false
        if v786 then
            v20.l0 <- v756
            ()
        else
            v20.l0 <- v781
            let v787 : string = "true; $0.into_iter().for_each(|x| { //"
            let v788 : bool = Fable.Core.RustInterop.emitRustExpr v776 v787 
            let v789 : string = "x"
            let v790 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v789 
            let v791 : string = $"near_sdk::log!(\"{{}}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v790 v791 
            let v792 : string = $"true;"
            let v793 : bool = Fable.Core.RustInterop.emitRustExpr () v792 
            let v794 : string = "true; }}); { //"
            let v795 : bool = Fable.Core.RustInterop.emitRustExpr () v794 
            ()
        let _v744 = () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        v743 v742
        let _v744 = () 
        #endif
#if FABLE_COMPILER_PYTHON
        v743 v742
        let _v744 = () 
        #endif
#else
        v743 v742
        let _v744 = () 
        #endif
        _v744 
        let v796 : (string -> unit) = v18.l0
        v796 v742
and closure19 (v0 : int32, v1 : exn) () : unit =
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
        let v76 : (unit -> unit) = closure7(v18)
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
        let v116 : (US3 option -> US3 option ref) = closure8(v115)
        let v117 : unit = ()
        let v118 : (unit -> unit) = closure9(v100, v116)
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
        let v175 : string = method5()
        let v178 : (string -> string) = v174.ToString
        let v179 : string = v178 v175
        let _v113 = v179 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v182 : US3 option = None
        let _v182 = ref v182 
        let v183 : US3 option ref = _v182 
        let v184 : (US3 option -> US3 option ref) = closure8(v183)
        let v185 : unit = ()
        let v186 : (unit -> unit) = closure9(v100, v184)
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
        let v243 : string = method5()
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
        let v254 : (US3 option -> US3 option ref) = closure8(v253)
        let v255 : unit = ()
        let v256 : (unit -> unit) = closure9(v100, v254)
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
        let v294 : (US3 option -> US3 option ref) = closure8(v293)
        let v295 : unit = ()
        let v296 : (unit -> unit) = closure9(v100, v294)
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
        let v353 : string = method6()
        let v356 : (string -> string) = v352.ToString
        let v357 : string = v356 v353
        let _v113 = v357 
        #endif
#if FABLE_COMPILER_PYTHON
        let v360 : US3 option = None
        let _v360 = ref v360 
        let v361 : US3 option ref = _v360 
        let v362 : (US3 option -> US3 option ref) = closure8(v361)
        let v363 : unit = ()
        let v364 : (unit -> unit) = closure9(v100, v362)
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
        let v421 : string = method6()
        let v424 : (string -> string) = v420.ToString
        let v425 : string = v424 v421
        let _v113 = v425 
        #endif
#else
        let v428 : US3 option = None
        let _v428 = ref v428 
        let v429 : US3 option ref = _v428 
        let v430 : (US3 option -> US3 option ref) = closure8(v429)
        let v431 : unit = ()
        let v432 : (unit -> unit) = closure9(v100, v430)
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
        let v489 : string = method6()
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
        let v620 : string = method7()
        let v621 : string = v619 + v571 
        let v622 : string = v621 + v620 
        let _v585 = v622 
        #endif
#if FABLE_COMPILER_PYTHON
        let v623 : string = "\u001b[91m"
        let v624 : string = method7()
        let v625 : string = v623 + v571 
        let v626 : string = v625 + v624 
        let _v585 = v626 
        #endif
#else
        let v627 : string = "\u001b[91m"
        let v628 : string = method7()
        let v629 : string = v627 + v571 
        let v630 : string = v629 + v628 
        let _v585 = v630 
        #endif
        let v631 : string = _v585 
        let v637 : int64 = v95.l0
        let v638 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v639 : string = $"%A{v1}"
        let _v638 = v639 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v642 : string = $"%A{v1}"
        let _v638 = v642 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v645 : string = $"%A{v1}"
        let _v638 = v645 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v648 : string = $"%A{v1}"
        let _v638 = v648 
        #endif
#if FABLE_COMPILER_PYTHON
        let v651 : string = $"%A{v1}"
        let _v638 = v651 
        #endif
#else
        let v654 : string = $"{v1.GetType ()}: {v1.Message}"
        let _v638 = v654 
        #endif
        let v655 : string = _v638 
        let v660 : string = method8()
        let v661 : Mut3 = {l0 = v660} : Mut3
        let v662 : string = "{ "
        let v663 : string = $"{v662}"
        let v666 : unit = ()
        let v667 : (unit -> unit) = closure10(v661, v663)
        let v668 : unit = (fun () -> v667 (); v666) ()
        let v671 : string = "timeout"
        let v672 : string = $"{v671}"
        let v675 : unit = ()
        let v676 : (unit -> unit) = closure10(v661, v672)
        let v677 : unit = (fun () -> v676 (); v675) ()
        let v680 : string = " = "
        let v681 : string = $"{v680}"
        let v684 : unit = ()
        let v685 : (unit -> unit) = closure10(v661, v681)
        let v686 : unit = (fun () -> v685 (); v684) ()
        let v689 : string = $"{v0}"
        let v692 : unit = ()
        let v693 : (unit -> unit) = closure10(v661, v689)
        let v694 : unit = (fun () -> v693 (); v692) ()
        let v697 : string = "; "
        let v698 : string = $"{v697}"
        let v701 : unit = ()
        let v702 : (unit -> unit) = closure10(v661, v698)
        let v703 : unit = (fun () -> v702 (); v701) ()
        let v706 : string = "ex"
        let v707 : string = $"{v706}"
        let v710 : unit = ()
        let v711 : (unit -> unit) = closure10(v661, v707)
        let v712 : unit = (fun () -> v711 (); v710) ()
        let v715 : string = $"{v680}"
        let v718 : unit = ()
        let v719 : (unit -> unit) = closure10(v661, v715)
        let v720 : unit = (fun () -> v719 (); v718) ()
        let v723 : string = $"{v655}"
        let v726 : unit = ()
        let v727 : (unit -> unit) = closure10(v661, v723)
        let v728 : unit = (fun () -> v727 (); v726) ()
        let v731 : string = " }"
        let v732 : string = $"{v731}"
        let v735 : unit = ()
        let v736 : (unit -> unit) = closure10(v661, v732)
        let v737 : unit = (fun () -> v736 (); v735) ()
        let v740 : string = v661.l0
        let v741 : string = $"async.run_with_timeout_async**"
        let v742 : bool = v741 = ""
        let v799 : string =
            if v742 then
                let v743 : string = ""
                v743
            else
                let v744 : string = $"{v496} {v631} #{v637} %s{v741} / {v740}"
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
                v781
        let v800 : (string -> unit) = closure11()
        let v801 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v802 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v799 v802 
        let _v801 = () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v803 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v799 v803 
        let _v801 = () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v804 : string = v21.l0
        let v805 : bool = v804 = ""
        let v813 : string =
            if v805 then
                v799
            else
                let v806 : bool = v799 = ""
                if v806 then
                    let v807 : string = v21.l0
                    v807
                else
                    let v808 : string = v21.l0
                    let v809 : string = "\n"
                    let v810 : string = v808 + v809 
                    let v811 : string = v810 + v799 
                    v811
        let v814 : string = "&*$0"
        let v815 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v813 v814 
        let v816 : string = $"$0.chars()"
        let v817 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v815 v816 
        let v818 : string = "v817"
        let v819 : _ = Fable.Core.RustInterop.emitRustExpr () v818 
        let v820 : string = "v819.collect::<Vec<_>>()"
        let v821 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v820 
        let v822 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
        let v823 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v821 v822 
        let v824 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
        let v825 : bool = Fable.Core.RustInterop.emitRustExpr v823 v824 
        let v826 : string = "x"
        let v827 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v826 
        let v828 : string = "String::from_iter($0)"
        let v829 : std_string_String = Fable.Core.RustInterop.emitRustExpr v827 v828 
        let v830 : string = "true; $0 }).collect::<Vec<_>>()"
        let v831 : bool = Fable.Core.RustInterop.emitRustExpr v829 v830 
        let v832 : string = "_vec_map"
        let v833 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v832 
        let v834 : string = "$0.len()"
        let v835 : unativeint = Fable.Core.RustInterop.emitRustExpr v833 v834 
        let v836 : (unativeint -> int32) = int32
        let v837 : int32 = v836 v835
        let v838 : string = ""
        let v839 : bool = v799 <> v838 
        let v843 : bool =
            if v839 then
                let v842 : bool = v837 <= 1
                v842
            else
                false
        if v843 then
            v21.l0 <- v813
            ()
        else
            v21.l0 <- v838
            let v844 : string = "true; $0.into_iter().for_each(|x| { //"
            let v845 : bool = Fable.Core.RustInterop.emitRustExpr v833 v844 
            let v846 : string = "x"
            let v847 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v846 
            let v848 : string = $"near_sdk::log!(\"{{}}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v847 v848 
            let v849 : string = $"true;"
            let v850 : bool = Fable.Core.RustInterop.emitRustExpr () v849 
            let v851 : string = "true; }}); { //"
            let v852 : bool = Fable.Core.RustInterop.emitRustExpr () v851 
            ()
        let _v801 = () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        v800 v799
        let _v801 = () 
        #endif
#if FABLE_COMPILER_PYTHON
        v800 v799
        let _v801 = () 
        #endif
#else
        v800 v799
        let _v801 = () 
        #endif
        _v801 
        let v853 : (string -> unit) = v19.l0
        v853 v799
and closure15 (v0 : int32, v1 : string) (v2 : int32) : Async<bool> =
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
    let v923 : bool = *)
    }
    |> fun x -> _v36 <- Some x
    let v924 : Async<bool> = match _v36 with Some x -> x | None -> failwith "async.new_async_unit / _v36=None"
    let _v20 = v924 
    #endif
    let v925 : Async<bool> = _v20 
    let v930 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v931 : Async<US4> = null |> unbox<Async<US4>>
    let _v930 = v931 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v934 : Async<US4> = null |> unbox<Async<US4>>
    let _v930 = v934 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v937 : Async<US4> = null |> unbox<Async<US4>>
    let _v930 = v937 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v940 : Async<US4> = null |> unbox<Async<US4>>
    let _v930 = v940 
    #endif
#if FABLE_COMPILER_PYTHON
    let v943 : Async<US4> = null |> unbox<Async<US4>>
    let _v930 = v943 
    #endif
#else
    let v946 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v947 : Async<US4> = null |> unbox<Async<US4>>
    let _v946 = v947 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v950 : Async<US4> = null |> unbox<Async<US4>>
    let _v946 = v950 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v953 : Async<US4> = null |> unbox<Async<US4>>
    let _v946 = v953 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v956 : Async<US4> = null |> unbox<Async<US4>>
    let _v946 = v956 
    #endif
#if FABLE_COMPILER_PYTHON
    let v959 : Async<US4> = null |> unbox<Async<US4>>
    let _v946 = v959 
    #endif
#else
    let v962 : Async<US4> option = None
    let mutable _v962 = v962 
    async {
    let v963 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v964 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
    let _v963 = v964 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v967 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
    let _v963 = v967 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v970 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
    let _v963 = v970 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v973 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
    let _v963 = v973 
    #endif
#if FABLE_COMPILER_PYTHON
    let v976 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
    let _v963 = v976 
    #endif
#else
    let v979 : Async<Async<bool>> = Async.StartChild (v925, v0)
    let _v963 = v979 
    #endif
    let v980 : Async<Async<bool>> = _v963 
    let! v980 = v980 
    let v985 : Async<bool> = v980 
    let v986 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v987 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
    let _v986 = v987 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v990 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
    let _v986 = v990 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v993 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
    let _v986 = v993 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v996 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
    let _v986 = v996 
    #endif
#if FABLE_COMPILER_PYTHON
    let v999 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
    let _v986 = v999 
    #endif
#else
    let v1002 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
    let v1003 : Async<Choice<bool, exn>> = v1002 v985
    let _v986 = v1003 
    #endif
    let v1004 : Async<Choice<bool, exn>> = _v986 
    let v1009 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1010 : Async<US5> = null |> unbox<Async<US5>>
    let _v1009 = v1010 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1013 : Async<US5> = null |> unbox<Async<US5>>
    let _v1009 = v1013 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1016 : Async<US5> = null |> unbox<Async<US5>>
    let _v1009 = v1016 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1019 : Async<US5> = null |> unbox<Async<US5>>
    let _v1009 = v1019 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1022 : Async<US5> = null |> unbox<Async<US5>>
    let _v1009 = v1022 
    #endif
#else
    let v1025 : Async<US5> option = None
    let mutable _v1025 = v1025 
    async {
    let! v1004 = v1004 
    let v1026 : Choice<bool, exn> = v1004 
    let v1027 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1028 : US5 = null |> unbox<US5>
    let _v1027 = v1028 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1031 : US5 = null |> unbox<US5>
    let _v1027 = v1031 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1034 : US5 = null |> unbox<US5>
    let _v1027 = v1034 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1037 : US5 = null |> unbox<US5>
    let _v1027 = v1037 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1040 : US5 = null |> unbox<US5>
    let _v1027 = v1040 
    #endif
#else
    let v1043 : (bool -> US5) = closure16()
    let v1044 : (exn -> US5) = closure17()
    let v1045 : US5 = match v1026 with Choice1Of2 x -> v1043 x | Choice2Of2 x -> v1044 x
    let _v1027 = v1045 
    #endif
    let v1046 : US5 = _v1027 
    return v1046 
    }
    |> fun x -> _v1025 <- Some x
    let v1051 : Async<US5> = match _v1025 with Some x -> x | None -> failwith "async.new_async_unit / _v1025=None"
    let _v1009 = v1051 
    #endif
    let v1052 : Async<US5> = _v1009 
    let v1057 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1058 : Async<US6> = null |> unbox<Async<US6>>
    let _v1057 = v1058 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1061 : Async<US6> = null |> unbox<Async<US6>>
    let _v1057 = v1061 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1064 : Async<US6> = null |> unbox<Async<US6>>
    let _v1057 = v1064 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1067 : Async<US6> = null |> unbox<Async<US6>>
    let _v1057 = v1067 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1070 : Async<US6> = null |> unbox<Async<US6>>
    let _v1057 = v1070 
    #endif
#else
    let v1073 : Async<US6> option = None
    let mutable _v1073 = v1073 
    async {
    let! v1052 = v1052 
    let v1074 : US5 = v1052 
    let v1080 : US6 =
        match v1074 with
        | US5_0(v1075) -> (* C1of2 *)
            US6_0(v1075)
        | US5_1(v1077) -> (* C2of2 *)
            US6_1(v1077)
    return v1080 
    }
    |> fun x -> _v1073 <- Some x
    let v1081 : Async<US6> = match _v1073 with Some x -> x | None -> failwith "async.new_async_unit / _v1073=None"
    let _v1057 = v1081 
    #endif
    let v1082 : Async<US6> = _v1057 
    let v1087 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1088 : Async<US4> = null |> unbox<Async<US4>>
    let _v1087 = v1088 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1091 : Async<US4> = null |> unbox<Async<US4>>
    let _v1087 = v1091 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1094 : Async<US4> = null |> unbox<Async<US4>>
    let _v1087 = v1094 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1097 : Async<US4> = null |> unbox<Async<US4>>
    let _v1087 = v1097 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1100 : Async<US4> = null |> unbox<Async<US4>>
    let _v1087 = v1100 
    #endif
#else
    let v1103 : Async<US4> option = None
    let mutable _v1103 = v1103 
    async {
    let! v1082 = v1082 
    let v1104 : US6 = v1082 
    let v2773 : US4 =
        match v1104 with
        | US6_1(v1107) -> (* Error *)
            let v1108 : string = $"%A{v1107}"
            let v1111 : string = "System.TimeoutException"
            let v1112 : bool = v1108.Contains v1111 
            if v1112 then
                let v1115 : unit = ()
                let v1116 : (unit -> unit) = closure18(v0)
                let v1117 : unit = (fun () -> v1116 (); v1115) ()
                US4_1
            else
                let v1915 : unit = ()
                let v1916 : (unit -> unit) = closure19(v0, v1107)
                let v1917 : unit = (fun () -> v1916 (); v1915) ()
                US4_1
        | US6_0(v1105) -> (* Ok *)
            US4_0(v1105)
    return v2773 
    }
    |> fun x -> _v1103 <- Some x
    let v2774 : Async<US4> = match _v1103 with Some x -> x | None -> failwith "async.new_async_unit / _v1103=None"
    let _v1087 = v2774 
    #endif
    let v2775 : Async<US4> = _v1087 
    return! v2775 
    }
    |> fun x -> _v962 <- Some x
    let v2780 : Async<US4> = match _v962 with Some x -> x | None -> failwith "async.new_async_unit / _v962=None"
    let _v946 = v2780 
    #endif
    let v2781 : Async<US4> = _v946 
    let _v930 = v2781 
    #endif
    let v2786 : Async<US4> = _v930 
    let! v2786 = v2786 
    let v2791 : US4 = v2786 
    let v2794 : bool =
        match v2791 with
        | US4_1 -> (* None *)
            false
        | US4_0(v2792) -> (* Some *)
            v2792
    return v2794 
    }
    |> fun x -> _v19 <- Some x
    let v2795 : Async<bool> = match _v19 with Some x -> x | None -> failwith "async.new_async_unit / _v19=None"
    let _v3 = v2795 
    #endif
    let v2796 : Async<bool> = _v3 
    v2796
and closure14 (v0 : int32) (v1 : string) : (int32 -> Async<bool>) =
    closure15(v0, v1)
and closure13 () (v0 : int32) : (string -> (int32 -> Async<bool>)) =
    closure14(v0)
and closure24 (v0 : US7 option ref) (v1 : US7 option) : US7 option ref =
    v0.Value <- v1 
    v0
and closure25 (v0 : int32 option, v1 : (US7 option -> US7 option ref)) () : unit =
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
and closure26 (v0 : int32 option, v1 : bool, v2 : int32, v3 : int64) () : unit =
    let v4 : unit = ()
    let v5 : (unit -> unit) = closure0()
    let v6 : unit = (fun () -> v5 (); v4) ()
    let struct (v20 : Mut0, v21 : Mut1, v22 : Mut2, v23 : Mut3, v24 : Mut4, v25 : int64 option) = TraceState.trace_state.Value
    let v38 : unit = ()
    let v39 : unit = (fun () -> v5 (); v38) ()
    let struct (v53 : Mut0, v54 : Mut1, v55 : Mut2, v56 : Mut3, v57 : Mut4, v58 : int64 option) = TraceState.trace_state.Value
    let v71 : US0 = v57.l0
    let v72 : bool = v55.l0
    let v73 : bool = v72 = false
    let v76 : bool =
        if v73 then
            false
        else
            let v74 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v71
            let v75 : bool = 0 >= v74
            v75
    if v76 then
        let v77 : unit = ()
        let v78 : (unit -> unit) = closure7(v20)
        let v79 : unit = (fun () -> v78 (); v77) ()
        let v82 : unit = ()
        let v83 : unit = (fun () -> v5 (); v82) ()
        let struct (v97 : Mut0, v98 : Mut1, v99 : Mut2, v100 : Mut3, v101 : Mut4, v102 : int64 option) = TraceState.trace_state.Value
        let v115 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v116 : US3 option = None
        let _v116 = ref v116 
        let v117 : US3 option ref = _v116 
        let v118 : (US3 option -> US3 option ref) = closure8(v117)
        let v119 : unit = ()
        let v120 : (unit -> unit) = closure9(v102, v118)
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
        let v186 : (US3 option -> US3 option ref) = closure8(v185)
        let v187 : unit = ()
        let v188 : (unit -> unit) = closure9(v102, v186)
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
        let v256 : (US3 option -> US3 option ref) = closure8(v255)
        let v257 : unit = ()
        let v258 : (unit -> unit) = closure9(v102, v256)
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
        let v296 : (US3 option -> US3 option ref) = closure8(v295)
        let v297 : unit = ()
        let v298 : (unit -> unit) = closure9(v102, v296)
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
        let v364 : (US3 option -> US3 option ref) = closure8(v363)
        let v365 : unit = ()
        let v366 : (unit -> unit) = closure9(v102, v364)
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
        let v432 : (US3 option -> US3 option ref) = closure8(v431)
        let v433 : unit = ()
        let v434 : (unit -> unit) = closure9(v102, v432)
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
        
        
        
        
        
        let v568 : string = "Verbose"
        let v569 : (unit -> string) = v568.ToLower
        let v570 : string = v569 ()
        let v573 : string = v570.PadLeft (7, ' ')
        let v587 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v588 : string = "inline_colorization::color_bright_black"
        let v589 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v588 
        let v590 : string = "&*$0"
        let v591 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v573 v590 
        let v592 : string = "inline_colorization::color_reset"
        let v593 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v592 
        let v594 : string = "\"{v589}{v591}{v593}\""
        let v595 : string = @$"format!(" + v594 + ")"
        let v596 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v595 
        let v597 : string = "fable_library_rust::String_::fromString($0)"
        let v598 : string = Fable.Core.RustInterop.emitRustExpr v596 v597 
        let _v587 = v598 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v599 : string = "inline_colorization::color_bright_black"
        let v600 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v599 
        let v601 : string = "&*$0"
        let v602 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v573 v601 
        let v603 : string = "inline_colorization::color_reset"
        let v604 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v603 
        let v605 : string = "\"{v600}{v602}{v604}\""
        let v606 : string = @$"format!(" + v605 + ")"
        let v607 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v606 
        let v608 : string = "fable_library_rust::String_::fromString($0)"
        let v609 : string = Fable.Core.RustInterop.emitRustExpr v607 v608 
        let _v587 = v609 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v610 : string = "inline_colorization::color_bright_black"
        let v611 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v610 
        let v612 : string = "&*$0"
        let v613 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v573 v612 
        let v614 : string = "inline_colorization::color_reset"
        let v615 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v614 
        let v616 : string = "\"{v611}{v613}{v615}\""
        let v617 : string = @$"format!(" + v616 + ")"
        let v618 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v617 
        let v619 : string = "fable_library_rust::String_::fromString($0)"
        let v620 : string = Fable.Core.RustInterop.emitRustExpr v618 v619 
        let _v587 = v620 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v621 : string = "\u001b[90m"
        let v622 : string = method7()
        let v623 : string = v621 + v573 
        let v624 : string = v623 + v622 
        let _v587 = v624 
        #endif
#if FABLE_COMPILER_PYTHON
        let v625 : string = "\u001b[90m"
        let v626 : string = method7()
        let v627 : string = v625 + v573 
        let v628 : string = v627 + v626 
        let _v587 = v628 
        #endif
#else
        let v629 : string = "\u001b[90m"
        let v630 : string = method7()
        let v631 : string = v629 + v573 
        let v632 : string = v631 + v630 
        let _v587 = v632 
        #endif
        let v633 : string = _v587 
        let v639 : int64 = v97.l0
        let v640 : string = method8()
        let v641 : Mut3 = {l0 = v640} : Mut3
        let v642 : string = "{ "
        let v643 : string = $"{v642}"
        let v646 : unit = ()
        let v647 : (unit -> unit) = closure10(v641, v643)
        let v648 : unit = (fun () -> v647 (); v646) ()
        let v651 : string = "port"
        let v652 : string = $"{v651}"
        let v655 : unit = ()
        let v656 : (unit -> unit) = closure10(v641, v652)
        let v657 : unit = (fun () -> v656 (); v655) ()
        let v660 : string = " = "
        let v661 : string = $"{v660}"
        let v664 : unit = ()
        let v665 : (unit -> unit) = closure10(v641, v661)
        let v666 : unit = (fun () -> v665 (); v664) ()
        let v669 : string = $"{v2}"
        let v672 : unit = ()
        let v673 : (unit -> unit) = closure10(v641, v669)
        let v674 : unit = (fun () -> v673 (); v672) ()
        let v677 : string = "; "
        let v678 : string = $"{v677}"
        let v681 : unit = ()
        let v682 : (unit -> unit) = closure10(v641, v678)
        let v683 : unit = (fun () -> v682 (); v681) ()
        let v686 : string = "retry"
        let v687 : string = $"{v686}"
        let v690 : unit = ()
        let v691 : (unit -> unit) = closure10(v641, v687)
        let v692 : unit = (fun () -> v691 (); v690) ()
        let v695 : string = $"{v660}"
        let v698 : unit = ()
        let v699 : (unit -> unit) = closure10(v641, v695)
        let v700 : unit = (fun () -> v699 (); v698) ()
        let v703 : string = $"{v3}"
        let v706 : unit = ()
        let v707 : (unit -> unit) = closure10(v641, v703)
        let v708 : unit = (fun () -> v707 (); v706) ()
        let v711 : string = $"{v677}"
        let v714 : unit = ()
        let v715 : (unit -> unit) = closure10(v641, v711)
        let v716 : unit = (fun () -> v715 (); v714) ()
        let v719 : string = "timeout"
        let v720 : string = $"{v719}"
        let v723 : unit = ()
        let v724 : (unit -> unit) = closure10(v641, v720)
        let v725 : unit = (fun () -> v724 (); v723) ()
        let v728 : string = $"{v660}"
        let v731 : unit = ()
        let v732 : (unit -> unit) = closure10(v641, v728)
        let v733 : unit = (fun () -> v732 (); v731) ()
        let v736 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v737 : string = "format!(\"{:#?}\", $0)"
        let v738 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v737 
        let v739 : string = "fable_library_rust::String_::fromString($0)"
        let v740 : string = Fable.Core.RustInterop.emitRustExpr v738 v739 
        let _v736 = v740 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v741 : string = "format!(\"{:#?}\", $0)"
        let v742 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v741 
        let v743 : string = "fable_library_rust::String_::fromString($0)"
        let v744 : string = Fable.Core.RustInterop.emitRustExpr v742 v743 
        let _v736 = v744 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v745 : string = "format!(\"{:#?}\", $0)"
        let v746 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v745 
        let v747 : string = "fable_library_rust::String_::fromString($0)"
        let v748 : string = Fable.Core.RustInterop.emitRustExpr v746 v747 
        let _v736 = v748 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v749 : string = $"%A{v0}"
        let _v736 = v749 
        #endif
#if FABLE_COMPILER_PYTHON
        let v752 : string = $"%A{v0}"
        let _v736 = v752 
        #endif
#else
        let v755 : string = $"%A{v0}"
        let _v736 = v755 
        #endif
        let v758 : string = _v736 
        let v763 : string = $"{v758}"
        let v766 : unit = ()
        let v767 : (unit -> unit) = closure10(v641, v763)
        let v768 : unit = (fun () -> v767 (); v766) ()
        let v771 : string = $"{v677}"
        let v774 : unit = ()
        let v775 : (unit -> unit) = closure10(v641, v771)
        let v776 : unit = (fun () -> v775 (); v774) ()
        let v779 : string = "status"
        let v780 : string = $"{v779}"
        let v783 : unit = ()
        let v784 : (unit -> unit) = closure10(v641, v780)
        let v785 : unit = (fun () -> v784 (); v783) ()
        let v788 : string = $"{v660}"
        let v791 : unit = ()
        let v792 : (unit -> unit) = closure10(v641, v788)
        let v793 : unit = (fun () -> v792 (); v791) ()
        let v798 : string =
            if v1 then
                let v796 : string = "true"
                v796
            else
                let v797 : string = "false"
                v797
        let v799 : string = $"{v798}"
        let v802 : unit = ()
        let v803 : (unit -> unit) = closure10(v641, v799)
        let v804 : unit = (fun () -> v803 (); v802) ()
        let v807 : string = " }"
        let v808 : string = $"{v807}"
        let v811 : unit = ()
        let v812 : (unit -> unit) = closure10(v641, v808)
        let v813 : unit = (fun () -> v812 (); v811) ()
        let v816 : string = v641.l0
        let v817 : string = "networking.wait_for_port_access"
        let v818 : string = $"{v498} {v633} #{v639} %s{v817} / {v816}"
        let v821 : char list = []
        let v822 : (char list -> (char [])) = List.toArray
        let v823 : (char []) = v822 v821
        let v826 : string = v818.TrimStart v823 
        let v844 : char list = []
        let v845 : char list = '/' :: v844 
        let v848 : char list = ' ' :: v845 
        let v851 : (char list -> (char [])) = List.toArray
        let v852 : (char []) = v851 v848
        let v855 : string = v826.TrimEnd v852 
        let v873 : (string -> unit) = closure11()
        let v874 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v875 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v855 v875 
        let _v874 = () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v876 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v855 v876 
        let _v874 = () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v877 : string = v23.l0
        let v878 : bool = v877 = ""
        let v886 : string =
            if v878 then
                v855
            else
                let v879 : bool = v855 = ""
                if v879 then
                    let v880 : string = v23.l0
                    v880
                else
                    let v881 : string = v23.l0
                    let v882 : string = "\n"
                    let v883 : string = v881 + v882 
                    let v884 : string = v883 + v855 
                    v884
        let v887 : string = "&*$0"
        let v888 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v886 v887 
        let v889 : string = $"$0.chars()"
        let v890 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v888 v889 
        let v891 : string = "v890"
        let v892 : _ = Fable.Core.RustInterop.emitRustExpr () v891 
        let v893 : string = "v892.collect::<Vec<_>>()"
        let v894 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v893 
        let v895 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
        let v896 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v894 v895 
        let v897 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
        let v898 : bool = Fable.Core.RustInterop.emitRustExpr v896 v897 
        let v899 : string = "x"
        let v900 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v899 
        let v901 : string = "String::from_iter($0)"
        let v902 : std_string_String = Fable.Core.RustInterop.emitRustExpr v900 v901 
        let v903 : string = "true; $0 }).collect::<Vec<_>>()"
        let v904 : bool = Fable.Core.RustInterop.emitRustExpr v902 v903 
        let v905 : string = "_vec_map"
        let v906 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v905 
        let v907 : string = "$0.len()"
        let v908 : unativeint = Fable.Core.RustInterop.emitRustExpr v906 v907 
        let v909 : (unativeint -> int32) = int32
        let v910 : int32 = v909 v908
        let v911 : string = ""
        let v912 : bool = v855 <> v911 
        let v916 : bool =
            if v912 then
                let v915 : bool = v910 <= 1
                v915
            else
                false
        if v916 then
            v23.l0 <- v886
            ()
        else
            v23.l0 <- v911
            let v917 : string = "true; $0.into_iter().for_each(|x| { //"
            let v918 : bool = Fable.Core.RustInterop.emitRustExpr v906 v917 
            let v919 : string = "x"
            let v920 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v919 
            let v921 : string = $"near_sdk::log!(\"{{}}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v920 v921 
            let v922 : string = $"true;"
            let v923 : bool = Fable.Core.RustInterop.emitRustExpr () v922 
            let v924 : string = "true; }}); { //"
            let v925 : bool = Fable.Core.RustInterop.emitRustExpr () v924 
            ()
        let _v874 = () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        v873 v855
        let _v874 = () 
        #endif
#if FABLE_COMPILER_PYTHON
        v873 v855
        let _v874 = () 
        #endif
#else
        v873 v855
        let _v874 = () 
        #endif
        _v874 
        let v926 : (string -> unit) = v21.l0
        v926 v855
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
    let v23 : US7 option ref = _v22 
    let v24 : (US7 option -> US7 option ref) = closure24(v23)
    let v25 : unit = ()
    let v26 : (unit -> unit) = closure25(v0, v24)
    let v27 : unit = (fun () -> v26 (); v25) ()
    let v30 : US7 option = _v22.Value 
    let v41 : US7 = US7_1
    let v42 : US7 = v30 |> Option.defaultValue v41 
    let v3756 : Async<bool> =
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
            let v949 : bool = *)
            }
            |> fun x -> _v62 <- Some x
            let v950 : Async<bool> = match _v62 with Some x -> x | None -> failwith "async.new_async_unit / _v62=None"
            let _v46 = v950 
            #endif
            let v951 : Async<bool> = _v46 
            v951
        | US7_0(v956) -> (* Some *)
            let v957 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v958 : Async<bool> = null |> unbox<Async<bool>>
            let _v957 = v958 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v961 : Async<bool> = null |> unbox<Async<bool>>
            let _v957 = v961 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v964 : Async<bool> = null |> unbox<Async<bool>>
            let _v957 = v964 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v967 : Async<bool> = null |> unbox<Async<bool>>
            let _v957 = v967 
            #endif
#if FABLE_COMPILER_PYTHON
            let v970 : Async<bool> = null |> unbox<Async<bool>>
            let _v957 = v970 
            #endif
#else
            let v973 : Async<bool> option = None
            let mutable _v973 = v973 
            async {
            let v974 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v975 : Async<bool> = null |> unbox<Async<bool>>
            let _v974 = v975 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v978 : Async<bool> = null |> unbox<Async<bool>>
            let _v974 = v978 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v981 : Async<bool> = null |> unbox<Async<bool>>
            let _v974 = v981 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v984 : Async<bool> = null |> unbox<Async<bool>>
            let _v974 = v984 
            #endif
#if FABLE_COMPILER_PYTHON
            let v987 : Async<bool> = null |> unbox<Async<bool>>
            let _v974 = v987 
            #endif
#else
            let v990 : Async<bool> option = None
            let mutable _v990 = v990 
            async {
            let v991 : Async<System.Threading.CancellationToken> = Async.CancellationToken
            let! v991 = v991 
            let v992 : System.Threading.CancellationToken = v991 
            let v993 : System.Net.Sockets.TcpClient = new System.Net.Sockets.TcpClient ()
            use v993 = v993 
            let v994 : System.Net.Sockets.TcpClient = v993 
            try
            let v995 : System.Threading.Tasks.ValueTask = v994.ConnectAsync (v2, v3, v992)
            let v996 : (unit -> System.Threading.Tasks.Task) = v995.AsTask
            let v997 : System.Threading.Tasks.Task = v996 ()
            let v998 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v999 : Async<unit> = null |> unbox<Async<unit>>
            let _v998 = v999 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1002 : Async<unit> = null |> unbox<Async<unit>>
            let _v998 = v1002 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1005 : Async<unit> = null |> unbox<Async<unit>>
            let _v998 = v1005 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1008 : Async<unit> = null |> unbox<Async<unit>>
            let _v998 = v1008 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1011 : Async<unit> = null |> unbox<Async<unit>>
            let _v998 = v1011 
            #endif
#else
            let v1014 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
            let v1015 : Async<unit> = v1014 v997
            let _v998 = v1015 
            #endif
            let v1016 : Async<unit> = _v998 
            do! v1016 
            return true 
            with ex ->
            let v1021 : exn = ex
            let v1022 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1023 : string = $"%A{v1021}"
            let _v1022 = v1023 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1026 : string = $"%A{v1021}"
            let _v1022 = v1026 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1029 : string = $"%A{v1021}"
            let _v1022 = v1029 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1032 : string = $"%A{v1021}"
            let _v1022 = v1032 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1035 : string = $"%A{v1021}"
            let _v1022 = v1035 
            #endif
#else
            let v1038 : string = $"{v1021.GetType ()}: {v1021.Message}"
            let _v1022 = v1038 
            #endif
            let v1039 : string = _v1022 
            let v1044 : unit = ()
            let v1045 : (unit -> unit) = closure6(v3, v1039)
            let v1046 : unit = (fun () -> v1045 (); v1044) ()
            return false 
            (*
            let v1877 : bool = *)
            }
            |> fun x -> _v990 <- Some x
            let v1878 : Async<bool> = match _v990 with Some x -> x | None -> failwith "async.new_async_unit / _v990=None"
            let _v974 = v1878 
            #endif
            let v1879 : Async<bool> = _v974 
            let v1884 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1885 : Async<US4> = null |> unbox<Async<US4>>
            let _v1884 = v1885 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1888 : Async<US4> = null |> unbox<Async<US4>>
            let _v1884 = v1888 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1891 : Async<US4> = null |> unbox<Async<US4>>
            let _v1884 = v1891 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1894 : Async<US4> = null |> unbox<Async<US4>>
            let _v1884 = v1894 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1897 : Async<US4> = null |> unbox<Async<US4>>
            let _v1884 = v1897 
            #endif
#else
            let v1900 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1901 : Async<US4> = null |> unbox<Async<US4>>
            let _v1900 = v1901 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1904 : Async<US4> = null |> unbox<Async<US4>>
            let _v1900 = v1904 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1907 : Async<US4> = null |> unbox<Async<US4>>
            let _v1900 = v1907 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1910 : Async<US4> = null |> unbox<Async<US4>>
            let _v1900 = v1910 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1913 : Async<US4> = null |> unbox<Async<US4>>
            let _v1900 = v1913 
            #endif
#else
            let v1916 : Async<US4> option = None
            let mutable _v1916 = v1916 
            async {
            let v1917 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1918 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v1917 = v1918 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1921 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v1917 = v1921 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1924 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v1917 = v1924 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1927 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v1917 = v1927 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1930 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v1917 = v1930 
            #endif
#else
            let v1933 : Async<Async<bool>> = Async.StartChild (v1879, v956)
            let _v1917 = v1933 
            #endif
            let v1934 : Async<Async<bool>> = _v1917 
            let! v1934 = v1934 
            let v1939 : Async<bool> = v1934 
            let v1940 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1941 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
            let _v1940 = v1941 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1944 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
            let _v1940 = v1944 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1947 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
            let _v1940 = v1947 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1950 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
            let _v1940 = v1950 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1953 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
            let _v1940 = v1953 
            #endif
#else
            let v1956 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v1957 : Async<Choice<bool, exn>> = v1956 v1939
            let _v1940 = v1957 
            #endif
            let v1958 : Async<Choice<bool, exn>> = _v1940 
            let v1963 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1964 : Async<US5> = null |> unbox<Async<US5>>
            let _v1963 = v1964 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1967 : Async<US5> = null |> unbox<Async<US5>>
            let _v1963 = v1967 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1970 : Async<US5> = null |> unbox<Async<US5>>
            let _v1963 = v1970 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1973 : Async<US5> = null |> unbox<Async<US5>>
            let _v1963 = v1973 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1976 : Async<US5> = null |> unbox<Async<US5>>
            let _v1963 = v1976 
            #endif
#else
            let v1979 : Async<US5> option = None
            let mutable _v1979 = v1979 
            async {
            let! v1958 = v1958 
            let v1980 : Choice<bool, exn> = v1958 
            let v1981 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1982 : US5 = null |> unbox<US5>
            let _v1981 = v1982 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1985 : US5 = null |> unbox<US5>
            let _v1981 = v1985 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1988 : US5 = null |> unbox<US5>
            let _v1981 = v1988 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1991 : US5 = null |> unbox<US5>
            let _v1981 = v1991 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1994 : US5 = null |> unbox<US5>
            let _v1981 = v1994 
            #endif
#else
            let v1997 : (bool -> US5) = closure16()
            let v1998 : (exn -> US5) = closure17()
            let v1999 : US5 = match v1980 with Choice1Of2 x -> v1997 x | Choice2Of2 x -> v1998 x
            let _v1981 = v1999 
            #endif
            let v2000 : US5 = _v1981 
            return v2000 
            }
            |> fun x -> _v1979 <- Some x
            let v2005 : Async<US5> = match _v1979 with Some x -> x | None -> failwith "async.new_async_unit / _v1979=None"
            let _v1963 = v2005 
            #endif
            let v2006 : Async<US5> = _v1963 
            let v2011 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v2012 : Async<US6> = null |> unbox<Async<US6>>
            let _v2011 = v2012 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v2015 : Async<US6> = null |> unbox<Async<US6>>
            let _v2011 = v2015 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v2018 : Async<US6> = null |> unbox<Async<US6>>
            let _v2011 = v2018 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v2021 : Async<US6> = null |> unbox<Async<US6>>
            let _v2011 = v2021 
            #endif
#if FABLE_COMPILER_PYTHON
            let v2024 : Async<US6> = null |> unbox<Async<US6>>
            let _v2011 = v2024 
            #endif
#else
            let v2027 : Async<US6> option = None
            let mutable _v2027 = v2027 
            async {
            let! v2006 = v2006 
            let v2028 : US5 = v2006 
            let v2034 : US6 =
                match v2028 with
                | US5_0(v2029) -> (* C1of2 *)
                    US6_0(v2029)
                | US5_1(v2031) -> (* C2of2 *)
                    US6_1(v2031)
            return v2034 
            }
            |> fun x -> _v2027 <- Some x
            let v2035 : Async<US6> = match _v2027 with Some x -> x | None -> failwith "async.new_async_unit / _v2027=None"
            let _v2011 = v2035 
            #endif
            let v2036 : Async<US6> = _v2011 
            let v2041 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v2042 : Async<US4> = null |> unbox<Async<US4>>
            let _v2041 = v2042 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v2045 : Async<US4> = null |> unbox<Async<US4>>
            let _v2041 = v2045 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v2048 : Async<US4> = null |> unbox<Async<US4>>
            let _v2041 = v2048 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v2051 : Async<US4> = null |> unbox<Async<US4>>
            let _v2041 = v2051 
            #endif
#if FABLE_COMPILER_PYTHON
            let v2054 : Async<US4> = null |> unbox<Async<US4>>
            let _v2041 = v2054 
            #endif
#else
            let v2057 : Async<US4> option = None
            let mutable _v2057 = v2057 
            async {
            let! v2036 = v2036 
            let v2058 : US6 = v2036 
            let v3727 : US4 =
                match v2058 with
                | US6_1(v2061) -> (* Error *)
                    let v2062 : string = $"%A{v2061}"
                    let v2065 : string = "System.TimeoutException"
                    let v2066 : bool = v2062.Contains v2065 
                    if v2066 then
                        let v2069 : unit = ()
                        let v2070 : (unit -> unit) = closure18(v956)
                        let v2071 : unit = (fun () -> v2070 (); v2069) ()
                        US4_1
                    else
                        let v2869 : unit = ()
                        let v2870 : (unit -> unit) = closure19(v956, v2061)
                        let v2871 : unit = (fun () -> v2870 (); v2869) ()
                        US4_1
                | US6_0(v2059) -> (* Ok *)
                    US4_0(v2059)
            return v3727 
            }
            |> fun x -> _v2057 <- Some x
            let v3728 : Async<US4> = match _v2057 with Some x -> x | None -> failwith "async.new_async_unit / _v2057=None"
            let _v2041 = v3728 
            #endif
            let v3729 : Async<US4> = _v2041 
            return! v3729 
            }
            |> fun x -> _v1916 <- Some x
            let v3734 : Async<US4> = match _v1916 with Some x -> x | None -> failwith "async.new_async_unit / _v1916=None"
            let _v1900 = v3734 
            #endif
            let v3735 : Async<US4> = _v1900 
            let _v1884 = v3735 
            #endif
            let v3740 : Async<US4> = _v1884 
            let! v3740 = v3740 
            let v3745 : US4 = v3740 
            let v3748 : bool =
                match v3745 with
                | US4_1 -> (* None *)
                    false
                | US4_0(v3746) -> (* Some *)
                    v3746
            return v3748 
            }
            |> fun x -> _v973 <- Some x
            let v3749 : Async<bool> = match _v973 with Some x -> x | None -> failwith "async.new_async_unit / _v973=None"
            let _v957 = v3749 
            #endif
            let v3750 : Async<bool> = _v957 
            v3750
    let! v3756 = v3756 
    let v3757 : bool = v3756 
    let v3758 : bool = v3757 = v1
    if v3758 then
        return v4 
        (*
        ()
    else
        *) else
        let v3759 : int64 = v4 % 100L
        let v3760 : bool = v3759 = 0L
        if v3760 then
            let v3761 : unit = ()
            let v3762 : (unit -> unit) = closure26(v0, v1, v3, v4)
            let v3763 : unit = (fun () -> v3762 (); v3761) ()
            ()
        let v4687 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v4688 : Async<unit> = null |> unbox<Async<unit>>
        let _v4687 = v4688 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v4691 : Async<unit> = null |> unbox<Async<unit>>
        let _v4687 = v4691 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v4694 : Async<unit> = null |> unbox<Async<unit>>
        let _v4687 = v4694 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v4697 : Async<unit> = null |> unbox<Async<unit>>
        let _v4687 = v4697 
        #endif
#if FABLE_COMPILER_PYTHON
        let v4700 : Async<unit> = null |> unbox<Async<unit>>
        let _v4687 = v4700 
        #endif
#else
        let v4703 : (int32 -> Async<unit>) = Async.Sleep
        let v4704 : Async<unit> = v4703 10
        let _v4687 = v4704 
        #endif
        let v4705 : Async<unit> = _v4687 
        do! v4705 
        let v4710 : int64 = v4 + 1L
        let v4711 : Async<int64> = method9(v0, v1, v2, v3, v4710)
        return! v4711 
        (*
        ()
    *)
    }
    |> fun x -> _v21 <- Some x
    let v4712 : Async<int64> = match _v21 with Some x -> x | None -> failwith "async.new_async_unit / _v21=None"
    let _v5 = v4712 
    #endif
    let v4713 : Async<int64> = _v5 
    v4713
and closure23 (v0 : int32 option, v1 : bool, v2 : string) (v3 : int32) : Async<int64> =
    let v4 : int64 = 0L
    method9(v0, v1, v2, v3, v4)
and closure22 (v0 : int32 option, v1 : bool) (v2 : string) : (int32 -> Async<int64>) =
    closure23(v0, v1, v2)
and closure21 (v0 : int32 option) (v1 : bool) : (string -> (int32 -> Async<int64>)) =
    closure22(v0, v1)
and closure20 () (v0 : int32 option) : (bool -> (string -> (int32 -> Async<int64>))) =
    closure21(v0)
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
    let v21 : US7 option ref = _v20 
    let v22 : (US7 option -> US7 option ref) = closure24(v21)
    let v23 : unit = ()
    let v24 : (unit -> unit) = closure25(v0, v22)
    let v25 : unit = (fun () -> v24 (); v23) ()
    let v28 : US7 option = _v20.Value 
    let v39 : US7 = US7_1
    let v40 : US7 = v28 |> Option.defaultValue v39 
    let v3754 : Async<bool> =
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
            let v947 : bool = *)
            }
            |> fun x -> _v60 <- Some x
            let v948 : Async<bool> = match _v60 with Some x -> x | None -> failwith "async.new_async_unit / _v60=None"
            let _v44 = v948 
            #endif
            let v949 : Async<bool> = _v44 
            v949
        | US7_0(v954) -> (* Some *)
            let v955 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v956 : Async<bool> = null |> unbox<Async<bool>>
            let _v955 = v956 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v959 : Async<bool> = null |> unbox<Async<bool>>
            let _v955 = v959 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v962 : Async<bool> = null |> unbox<Async<bool>>
            let _v955 = v962 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v965 : Async<bool> = null |> unbox<Async<bool>>
            let _v955 = v965 
            #endif
#if FABLE_COMPILER_PYTHON
            let v968 : Async<bool> = null |> unbox<Async<bool>>
            let _v955 = v968 
            #endif
#else
            let v971 : Async<bool> option = None
            let mutable _v971 = v971 
            async {
            let v972 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v973 : Async<bool> = null |> unbox<Async<bool>>
            let _v972 = v973 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v976 : Async<bool> = null |> unbox<Async<bool>>
            let _v972 = v976 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v979 : Async<bool> = null |> unbox<Async<bool>>
            let _v972 = v979 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v982 : Async<bool> = null |> unbox<Async<bool>>
            let _v972 = v982 
            #endif
#if FABLE_COMPILER_PYTHON
            let v985 : Async<bool> = null |> unbox<Async<bool>>
            let _v972 = v985 
            #endif
#else
            let v988 : Async<bool> option = None
            let mutable _v988 = v988 
            async {
            let v989 : Async<System.Threading.CancellationToken> = Async.CancellationToken
            let! v989 = v989 
            let v990 : System.Threading.CancellationToken = v989 
            let v991 : System.Net.Sockets.TcpClient = new System.Net.Sockets.TcpClient ()
            use v991 = v991 
            let v992 : System.Net.Sockets.TcpClient = v991 
            try
            let v993 : System.Threading.Tasks.ValueTask = v992.ConnectAsync (v1, v2, v990)
            let v994 : (unit -> System.Threading.Tasks.Task) = v993.AsTask
            let v995 : System.Threading.Tasks.Task = v994 ()
            let v996 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v997 : Async<unit> = null |> unbox<Async<unit>>
            let _v996 = v997 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1000 : Async<unit> = null |> unbox<Async<unit>>
            let _v996 = v1000 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1003 : Async<unit> = null |> unbox<Async<unit>>
            let _v996 = v1003 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1006 : Async<unit> = null |> unbox<Async<unit>>
            let _v996 = v1006 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1009 : Async<unit> = null |> unbox<Async<unit>>
            let _v996 = v1009 
            #endif
#else
            let v1012 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
            let v1013 : Async<unit> = v1012 v995
            let _v996 = v1013 
            #endif
            let v1014 : Async<unit> = _v996 
            do! v1014 
            return true 
            with ex ->
            let v1019 : exn = ex
            let v1020 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1021 : string = $"%A{v1019}"
            let _v1020 = v1021 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1024 : string = $"%A{v1019}"
            let _v1020 = v1024 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1027 : string = $"%A{v1019}"
            let _v1020 = v1027 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1030 : string = $"%A{v1019}"
            let _v1020 = v1030 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1033 : string = $"%A{v1019}"
            let _v1020 = v1033 
            #endif
#else
            let v1036 : string = $"{v1019.GetType ()}: {v1019.Message}"
            let _v1020 = v1036 
            #endif
            let v1037 : string = _v1020 
            let v1042 : unit = ()
            let v1043 : (unit -> unit) = closure6(v2, v1037)
            let v1044 : unit = (fun () -> v1043 (); v1042) ()
            return false 
            (*
            let v1875 : bool = *)
            }
            |> fun x -> _v988 <- Some x
            let v1876 : Async<bool> = match _v988 with Some x -> x | None -> failwith "async.new_async_unit / _v988=None"
            let _v972 = v1876 
            #endif
            let v1877 : Async<bool> = _v972 
            let v1882 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1883 : Async<US4> = null |> unbox<Async<US4>>
            let _v1882 = v1883 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1886 : Async<US4> = null |> unbox<Async<US4>>
            let _v1882 = v1886 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1889 : Async<US4> = null |> unbox<Async<US4>>
            let _v1882 = v1889 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1892 : Async<US4> = null |> unbox<Async<US4>>
            let _v1882 = v1892 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1895 : Async<US4> = null |> unbox<Async<US4>>
            let _v1882 = v1895 
            #endif
#else
            let v1898 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1899 : Async<US4> = null |> unbox<Async<US4>>
            let _v1898 = v1899 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1902 : Async<US4> = null |> unbox<Async<US4>>
            let _v1898 = v1902 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1905 : Async<US4> = null |> unbox<Async<US4>>
            let _v1898 = v1905 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1908 : Async<US4> = null |> unbox<Async<US4>>
            let _v1898 = v1908 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1911 : Async<US4> = null |> unbox<Async<US4>>
            let _v1898 = v1911 
            #endif
#else
            let v1914 : Async<US4> option = None
            let mutable _v1914 = v1914 
            async {
            let v1915 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1916 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v1915 = v1916 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1919 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v1915 = v1919 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1922 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v1915 = v1922 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1925 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v1915 = v1925 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1928 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v1915 = v1928 
            #endif
#else
            let v1931 : Async<Async<bool>> = Async.StartChild (v1877, v954)
            let _v1915 = v1931 
            #endif
            let v1932 : Async<Async<bool>> = _v1915 
            let! v1932 = v1932 
            let v1937 : Async<bool> = v1932 
            let v1938 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1939 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
            let _v1938 = v1939 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1942 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
            let _v1938 = v1942 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1945 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
            let _v1938 = v1945 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1948 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
            let _v1938 = v1948 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1951 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
            let _v1938 = v1951 
            #endif
#else
            let v1954 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v1955 : Async<Choice<bool, exn>> = v1954 v1937
            let _v1938 = v1955 
            #endif
            let v1956 : Async<Choice<bool, exn>> = _v1938 
            let v1961 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1962 : Async<US5> = null |> unbox<Async<US5>>
            let _v1961 = v1962 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1965 : Async<US5> = null |> unbox<Async<US5>>
            let _v1961 = v1965 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1968 : Async<US5> = null |> unbox<Async<US5>>
            let _v1961 = v1968 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1971 : Async<US5> = null |> unbox<Async<US5>>
            let _v1961 = v1971 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1974 : Async<US5> = null |> unbox<Async<US5>>
            let _v1961 = v1974 
            #endif
#else
            let v1977 : Async<US5> option = None
            let mutable _v1977 = v1977 
            async {
            let! v1956 = v1956 
            let v1978 : Choice<bool, exn> = v1956 
            let v1979 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1980 : US5 = null |> unbox<US5>
            let _v1979 = v1980 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1983 : US5 = null |> unbox<US5>
            let _v1979 = v1983 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1986 : US5 = null |> unbox<US5>
            let _v1979 = v1986 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1989 : US5 = null |> unbox<US5>
            let _v1979 = v1989 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1992 : US5 = null |> unbox<US5>
            let _v1979 = v1992 
            #endif
#else
            let v1995 : (bool -> US5) = closure16()
            let v1996 : (exn -> US5) = closure17()
            let v1997 : US5 = match v1978 with Choice1Of2 x -> v1995 x | Choice2Of2 x -> v1996 x
            let _v1979 = v1997 
            #endif
            let v1998 : US5 = _v1979 
            return v1998 
            }
            |> fun x -> _v1977 <- Some x
            let v2003 : Async<US5> = match _v1977 with Some x -> x | None -> failwith "async.new_async_unit / _v1977=None"
            let _v1961 = v2003 
            #endif
            let v2004 : Async<US5> = _v1961 
            let v2009 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v2010 : Async<US6> = null |> unbox<Async<US6>>
            let _v2009 = v2010 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v2013 : Async<US6> = null |> unbox<Async<US6>>
            let _v2009 = v2013 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v2016 : Async<US6> = null |> unbox<Async<US6>>
            let _v2009 = v2016 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v2019 : Async<US6> = null |> unbox<Async<US6>>
            let _v2009 = v2019 
            #endif
#if FABLE_COMPILER_PYTHON
            let v2022 : Async<US6> = null |> unbox<Async<US6>>
            let _v2009 = v2022 
            #endif
#else
            let v2025 : Async<US6> option = None
            let mutable _v2025 = v2025 
            async {
            let! v2004 = v2004 
            let v2026 : US5 = v2004 
            let v2032 : US6 =
                match v2026 with
                | US5_0(v2027) -> (* C1of2 *)
                    US6_0(v2027)
                | US5_1(v2029) -> (* C2of2 *)
                    US6_1(v2029)
            return v2032 
            }
            |> fun x -> _v2025 <- Some x
            let v2033 : Async<US6> = match _v2025 with Some x -> x | None -> failwith "async.new_async_unit / _v2025=None"
            let _v2009 = v2033 
            #endif
            let v2034 : Async<US6> = _v2009 
            let v2039 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v2040 : Async<US4> = null |> unbox<Async<US4>>
            let _v2039 = v2040 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v2043 : Async<US4> = null |> unbox<Async<US4>>
            let _v2039 = v2043 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v2046 : Async<US4> = null |> unbox<Async<US4>>
            let _v2039 = v2046 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v2049 : Async<US4> = null |> unbox<Async<US4>>
            let _v2039 = v2049 
            #endif
#if FABLE_COMPILER_PYTHON
            let v2052 : Async<US4> = null |> unbox<Async<US4>>
            let _v2039 = v2052 
            #endif
#else
            let v2055 : Async<US4> option = None
            let mutable _v2055 = v2055 
            async {
            let! v2034 = v2034 
            let v2056 : US6 = v2034 
            let v3725 : US4 =
                match v2056 with
                | US6_1(v2059) -> (* Error *)
                    let v2060 : string = $"%A{v2059}"
                    let v2063 : string = "System.TimeoutException"
                    let v2064 : bool = v2060.Contains v2063 
                    if v2064 then
                        let v2067 : unit = ()
                        let v2068 : (unit -> unit) = closure18(v954)
                        let v2069 : unit = (fun () -> v2068 (); v2067) ()
                        US4_1
                    else
                        let v2867 : unit = ()
                        let v2868 : (unit -> unit) = closure19(v954, v2059)
                        let v2869 : unit = (fun () -> v2868 (); v2867) ()
                        US4_1
                | US6_0(v2057) -> (* Ok *)
                    US4_0(v2057)
            return v3725 
            }
            |> fun x -> _v2055 <- Some x
            let v3726 : Async<US4> = match _v2055 with Some x -> x | None -> failwith "async.new_async_unit / _v2055=None"
            let _v2039 = v3726 
            #endif
            let v3727 : Async<US4> = _v2039 
            return! v3727 
            }
            |> fun x -> _v1914 <- Some x
            let v3732 : Async<US4> = match _v1914 with Some x -> x | None -> failwith "async.new_async_unit / _v1914=None"
            let _v1898 = v3732 
            #endif
            let v3733 : Async<US4> = _v1898 
            let _v1882 = v3733 
            #endif
            let v3738 : Async<US4> = _v1882 
            let! v3738 = v3738 
            let v3743 : US4 = v3738 
            let v3746 : bool =
                match v3743 with
                | US4_1 -> (* None *)
                    false
                | US4_0(v3744) -> (* Some *)
                    v3744
            return v3746 
            }
            |> fun x -> _v971 <- Some x
            let v3747 : Async<bool> = match _v971 with Some x -> x | None -> failwith "async.new_async_unit / _v971=None"
            let _v955 = v3747 
            #endif
            let v3748 : Async<bool> = _v955 
            v3748
    let! v3754 = v3754 
    let v3755 : bool = v3754 
    let v3756 : bool = v3755 = false
    if v3756 then
        return v2 
        (*
        ()
    else
        *) else
        let v3757 : int32 = v2 + 1
        let v3758 : Async<int32> = method10(v0, v1, v3757)
        return! v3758 
        (*
        ()
    *)
    }
    |> fun x -> _v19 <- Some x
    let v3759 : Async<int32> = match _v19 with Some x -> x | None -> failwith "async.new_async_unit / _v19=None"
    let _v3 = v3759 
    #endif
    let v3760 : Async<int32> = _v3 
    v3760
and closure29 (v0 : int32 option, v1 : string) (v2 : int32) : Async<int32> =
    method10(v0, v1, v2)
and closure28 (v0 : int32 option) (v1 : string) : (int32 -> Async<int32>) =
    closure29(v0, v1)
and closure27 () (v0 : int32 option) : (string -> (int32 -> Async<int32>)) =
    closure28(v0)
let v0 : unit = ()
let v1 : (unit -> unit) = closure0()
let v2 : unit = (fun () -> v1 (); v0) ()
let v16 : (string -> (int32 -> Async<bool>)) = closure4()
let test_port_open x = v16 x
let v17 : (int32 -> (string -> (int32 -> Async<bool>))) = closure13()
let test_port_open_timeout x = v17 x
let v18 : (int32 option -> (bool -> (string -> (int32 -> Async<int64>)))) = closure20()
let wait_for_port_access x = v18 x
let v19 : (int32 option -> (string -> (int32 -> Async<int32>))) = closure27()
let get_available_port x = v19 x
()
