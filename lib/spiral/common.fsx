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
type Disposable (f : unit -> unit) = interface System.IDisposable with member _.Dispose () = f ()
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
and [<Struct>] US5 =
    | US5_0 of f0_0 : US4
    | US5_1
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
and method5 (v0 : (unit -> unit)) : (unit -> unit) =
    v0
and method6 (v0 : (unit -> unit)) : (unit -> unit) =
    v0
and closure4 () (v0 : (unit -> unit)) : System.IDisposable =
    let v1 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : (unit -> unit) = method5(v0)
    let v3 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v2 "$0()" )
    let _v1 = v3 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v4 : (unit -> unit) = method5(v0)
    let v5 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v4 "$0()" )
    let _v1 = v5 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v6 : (unit -> unit) = method5(v0)
    let v7 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v6 "$0()" )
    let _v1 = v7 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v8 : (unit -> unit) = method6(v0)
    let v9 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v8 () }
    let _v1 = v9 
    #endif
#if FABLE_COMPILER_PYTHON
    let v10 : (unit -> unit) = method6(v0)
    let v11 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v10 () }
    let _v1 = v11 
    #endif
#else
    let v12 : (unit -> unit) = method6(v0)
    let v13 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v12 () }
    let _v1 = v13 
    #endif
    let v14 : System.IDisposable = _v1 
    v14
and closure7 () (v0 : US4) : US5 =
    US5_0(v0)
and closure8 (v0 : int32, v1 : (unit -> unit), v2 : int32) () : US4 =
    let v3 : bool = v2 < v0
    if v3 then
        v1 ()
        US4_0
    else
        US4_1
and closure11 (v0 : Mut0) () : unit =
    let v1 : int64 = v0.l0
    let v2 : int64 = v1 + 1L
    v0.l0 <- v2
    ()
and closure12 (v0 : US3 option ref) (v1 : US3 option) : US3 option ref =
    v0.Value <- v1 
    v0
and closure13 (v0 : int64 option, v1 : (US3 option -> US3 option ref)) () : unit =
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
and method8 () : string =
    let v0 : string = "hh:mm:ss"
    v0
and method9 () : string =
    let v0 : string = "HH:mm:ss"
    v0
and method10 () : string =
    let v0 : string = "\u001b[0m"
    v0
and method11 () : string =
    let v0 : string = ""
    v0
and closure14 (v0 : Mut3, v1 : string) () : unit =
    let v2 : string = v0.l0
    let v3 : string = v2 + v1 
    v0.l0 <- v3
    ()
and closure16 (v0 : string) () : unit =
    let v1 : (string -> unit) = System.Console.WriteLine
    v1 v0
and closure15 () (v0 : string) : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure16(v0)
    let v3 : unit = (fun () -> v2 (); v1) ()
    ()
and closure10 (v0 : int32, v1 : exn) () : unit =
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
        let v76 : (unit -> unit) = closure11(v18)
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
        let v116 : (US3 option -> US3 option ref) = closure12(v115)
        let v117 : unit = ()
        let v118 : (unit -> unit) = closure13(v100, v116)
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
        let v175 : string = method8()
        let v178 : (string -> string) = v174.ToString
        let v179 : string = v178 v175
        let _v113 = v179 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v182 : US3 option = None
        let _v182 = ref v182 
        let v183 : US3 option ref = _v182 
        let v184 : (US3 option -> US3 option ref) = closure12(v183)
        let v185 : unit = ()
        let v186 : (unit -> unit) = closure13(v100, v184)
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
        let v243 : string = method8()
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
        let v254 : (US3 option -> US3 option ref) = closure12(v253)
        let v255 : unit = ()
        let v256 : (unit -> unit) = closure13(v100, v254)
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
        let v294 : (US3 option -> US3 option ref) = closure12(v293)
        let v295 : unit = ()
        let v296 : (unit -> unit) = closure13(v100, v294)
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
        let v353 : string = method9()
        let v356 : (string -> string) = v352.ToString
        let v357 : string = v356 v353
        let _v113 = v357 
        #endif
#if FABLE_COMPILER_PYTHON
        let v360 : US3 option = None
        let _v360 = ref v360 
        let v361 : US3 option ref = _v360 
        let v362 : (US3 option -> US3 option ref) = closure12(v361)
        let v363 : unit = ()
        let v364 : (unit -> unit) = closure13(v100, v362)
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
        let v421 : string = method9()
        let v424 : (string -> string) = v420.ToString
        let v425 : string = v424 v421
        let _v113 = v425 
        #endif
#else
        let v428 : US3 option = None
        let _v428 = ref v428 
        let v429 : US3 option ref = _v428 
        let v430 : (US3 option -> US3 option ref) = closure12(v429)
        let v431 : unit = ()
        let v432 : (unit -> unit) = closure13(v100, v430)
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
        let v489 : string = method9()
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
        let v620 : string = method10()
        let v621 : string = v619 + v571 
        let v622 : string = v621 + v620 
        let _v585 = v622 
        #endif
#if FABLE_COMPILER_PYTHON
        let v623 : string = "\u001b[93m"
        let v624 : string = method10()
        let v625 : string = v623 + v571 
        let v626 : string = v625 + v624 
        let _v585 = v626 
        #endif
#else
        let v627 : string = "\u001b[93m"
        let v628 : string = method10()
        let v629 : string = v627 + v571 
        let v630 : string = v629 + v628 
        let _v585 = v630 
        #endif
        let v631 : string = _v585 
        let v637 : int64 = v95.l0
        let v638 : string = method11()
        let v639 : Mut3 = {l0 = v638} : Mut3
        let v640 : string = "{ "
        let v641 : string = $"{v640}"
        let v644 : unit = ()
        let v645 : (unit -> unit) = closure14(v639, v641)
        let v646 : unit = (fun () -> v645 (); v644) ()
        let v649 : string = "retry"
        let v650 : string = $"{v649}"
        let v653 : unit = ()
        let v654 : (unit -> unit) = closure14(v639, v650)
        let v655 : unit = (fun () -> v654 (); v653) ()
        let v658 : string = " = "
        let v659 : string = $"{v658}"
        let v662 : unit = ()
        let v663 : (unit -> unit) = closure14(v639, v659)
        let v664 : unit = (fun () -> v663 (); v662) ()
        let v667 : string = $"{v0}"
        let v670 : unit = ()
        let v671 : (unit -> unit) = closure14(v639, v667)
        let v672 : unit = (fun () -> v671 (); v670) ()
        let v675 : string = "; "
        let v676 : string = $"{v675}"
        let v679 : unit = ()
        let v680 : (unit -> unit) = closure14(v639, v676)
        let v681 : unit = (fun () -> v680 (); v679) ()
        let v684 : string = "ex"
        let v685 : string = $"{v684}"
        let v688 : unit = ()
        let v689 : (unit -> unit) = closure14(v639, v685)
        let v690 : unit = (fun () -> v689 (); v688) ()
        let v693 : string = $"{v658}"
        let v696 : unit = ()
        let v697 : (unit -> unit) = closure14(v639, v693)
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
        let v732 : (unit -> unit) = closure14(v639, v728)
        let v733 : unit = (fun () -> v732 (); v731) ()
        let v736 : string = " }"
        let v737 : string = $"{v736}"
        let v740 : unit = ()
        let v741 : (unit -> unit) = closure14(v639, v737)
        let v742 : unit = (fun () -> v741 (); v740) ()
        let v745 : string = v639.l0
        let v746 : string = "common.retry_fn"
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
        let v802 : (string -> unit) = closure15()
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
and closure9 (v0 : int32) (v1 : exn) : US5 =
    let v2 : unit = ()
    let v3 : (unit -> unit) = closure10(v0, v1)
    let v4 : unit = (fun () -> v3 (); v2) ()
    US5_1
and method7 (v0 : int32, v1 : (unit -> unit), v2 : int32) : US4 =
    let v3 : (US4 -> US5) = closure7()
    let v4 : (unit -> US4) = closure8(v0, v1, v2)
    let v5 : (exn -> US5) = closure9(v2)
    let v6 : US5 = US5_1
    let result = ref v6
    try
        result.Value <- v4 () |> v3 
    with ex ->
        result.Value <- v5 ex 
    let v7 : US5 = result.Value
    match v7 with
    | US5_1 -> (* None *)
        let v12 : int32 = v2 + 1
        method7(v0, v1, v12)
    | US5_0(v11) -> (* Some *)
        v11
and closure6 (v0 : int32) (v1 : (unit -> unit)) : unit option =
    let v2 : int32 = 0
    let v3 : US4 = method7(v0, v1, v2)
    match v3 with
    | US4_1 -> (* None *)
        let v7 : unit option = None
        v7
    | US4_0 -> (* Some *)
        let v4 : unit option = Some () 
        v4
and closure5 () (v0 : int32) : ((unit -> unit) -> unit option) =
    closure6(v0)
and method12 (v0 : (unit -> unit)) : (unit -> unit) =
    v0
and closure18 (v0 : Lazy<unit>) () : unit =
    v0.Value
    ()
and closure17 () (v0 : (unit -> unit)) : (unit -> unit) =
    let v1 : (unit -> unit) = method12(v0)
    let v2 : Lazy<unit> = lazy v1 ()
    closure18(v2)
let v0 : unit = ()
let v1 : (unit -> unit) = closure0()
let v2 : unit = (fun () -> v1 (); v0) ()
let v16 : ((unit -> unit) -> System.IDisposable) = closure4()
let new_disposable x = v16 x
let v17 : (int32 -> ((unit -> unit) -> unit option)) = closure5()
let retry_fn x = v17 x
let v18 : ((unit -> unit) -> (unit -> unit)) = closure17()
let memoize x = v18 x
()
