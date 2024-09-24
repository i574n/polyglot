#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("*/ $0 /*")>]
#endif
type TypeEmit<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("&$0")>]
#endif
type Ref<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("near_sdk::store::LookupMap<$0, $1>")>]
#endif
type near_sdk_store_LookupMap<'K, 'V> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::string::String")>]
#endif
type std_string_String = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("mut $0")>]
#endif
type Mut<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("Vec<$0>")>]
#endif
type Vec<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("near_sdk::AccountId")>]
#endif
type near_sdk_AccountId = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::collections::HashMap<$0, $1>")>]
#endif
type std_collections_HashMap<'K, 'V> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("[$0]")>]
#endif
type Slice<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("str")>]
#endif
type Str = class end
module TraceState = let mutable trace_state = None
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::env::VarError")>]
#endif
type std_env_VarError = class end
type IOsEnviron = abstract environ: x: unit -> obj
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
    | US4_0 of f0_0 : std_string_String
    | US4_1
let rec closure1 () (v0 : char) : bool =
    let v1 : string = $"$0.is_alphanumeric()"
    let v2 : bool = Fable.Core.RustInterop.emitRustExpr v0 v1 
    if v2 then
        true
    else
        let v3 : bool = v0 = '-'
        v3
and method1 () : string =
    let v0 : string = "TRACE_LEVEL"
    v0
and method3 () : string =
    let v0 : string = ""
    v0
and closure4 () (v0 : string) : US1 =
    US1_0(v0)
and method4 () : (string -> US1) =
    closure4()
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
    let v64 : (string -> US1) = method4()
    let v65 : US1 option = v61 |> Option.map v64 
    let v76 : US1 = US1_1
    let v77 : US1 = v65 |> Option.defaultValue v76 
    let v84 : string =
        match v77 with
        | US1_1 -> (* None *)
            let v82 : string = ""
            v82
        | US1_0(v81) -> (* Some *)
            v81
    let _v1 = v84 
    #endif
#else
    let v85 : (string -> string) = System.Environment.GetEnvironmentVariable
    let v86 : string = v85 v0
    let mutable _v86 = None
    #if !FABLE_COMPILER && !WASM && !CONTRACT
    let v87 : (string -> string option) = Option.ofObj
    let v88 : string option = v87 v86
    v88 
    #else
    Some v86 
    #endif
    |> fun x -> _v86 <- Some x
    let v89 : string option = match _v86 with Some x -> x | None -> failwith "optionm'.of_obj / _v86=None"
    let v92 : (string -> US1) = method4()
    let v93 : US1 option = v89 |> Option.map v92 
    let v104 : US1 = US1_1
    let v105 : US1 = v93 |> Option.defaultValue v104 
    let v112 : string =
        match v105 with
        | US1_1 -> (* None *)
            let v110 : string = ""
            v110
        | US1_0(v109) -> (* Some *)
            v109
    let _v1 = v112 
    #endif
    let v113 : string = _v1 
    v113
and method5 () : string =
    let v0 : string = "AUTOMATION"
    v0
and closure5 () (v0 : string) : unit =
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
    let v50 : string = method5()
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
    let v159 : string = method5()
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
    let v220 : string = method5()
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
    let v281 : string = method5()
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
    let v359 : Mut0 = {l0 = 1L} : Mut0
    let v360 : (string -> unit) = closure5()
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
and closure3 () () : unit =
    let v0 : bool = TraceState.trace_state.IsNone
    if v0 then
        let v1 : US0 = US0_0
        let struct (v2 : Mut0, v3 : Mut1, v4 : Mut2, v5 : Mut3, v6 : Mut4, v7 : int64 option) = method0(v1)
        let v8 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v2, v3, v4, v5, v6, v7) 
        TraceState.trace_state <- v8 
        ()
and closure6 () (v0 : int64) : US3 =
    US3_0(v0)
and method7 () : (int64 -> US3) =
    closure6()
and method8 () : string =
    let v0 : string = "hh:mm:ss"
    v0
and method9 () : string =
    let v0 : string = "HH:mm:ss"
    v0
and method6 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option) : string =
    let v6 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v7 : (int64 -> US3) = method7()
    let v8 : US3 option = v5 |> Option.map v7 
    let v19 : US3 = US3_1
    let v20 : US3 = v8 |> Option.defaultValue v19 
    let v60 : System.DateTime =
        match v20 with
        | US3_1 -> (* None *)
            let v56 : System.DateTime = System.DateTime.Now
            v56
        | US3_0(v24) -> (* Some *)
            let v25 : System.DateTime = System.DateTime.Now
            let v28 : (System.DateTime -> int64) = _.Ticks
            let v29 : int64 = v28 v25
            let v32 : int64 = v29 - v24
            let v33 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v34 : System.TimeSpan = v33 v32
            let v37 : (System.TimeSpan -> int32) = _.Hours
            let v38 : int32 = v37 v34
            let v41 : (System.TimeSpan -> int32) = _.Minutes
            let v42 : int32 = v41 v34
            let v45 : (System.TimeSpan -> int32) = _.Seconds
            let v46 : int32 = v45 v34
            let v49 : (System.TimeSpan -> int32) = _.Milliseconds
            let v50 : int32 = v49 v34
            let v53 : System.DateTime = System.DateTime (1, 1, 1, v38, v42, v46, v50)
            v53
    let v61 : string = method8()
    let v64 : (string -> string) = v60.ToString
    let v65 : string = v64 v61
    let _v6 = v65 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v68 : (int64 -> US3) = method7()
    let v69 : US3 option = v5 |> Option.map v68 
    let v80 : US3 = US3_1
    let v81 : US3 = v69 |> Option.defaultValue v80 
    let v121 : System.DateTime =
        match v81 with
        | US3_1 -> (* None *)
            let v117 : System.DateTime = System.DateTime.Now
            v117
        | US3_0(v85) -> (* Some *)
            let v86 : System.DateTime = System.DateTime.Now
            let v89 : (System.DateTime -> int64) = _.Ticks
            let v90 : int64 = v89 v86
            let v93 : int64 = v90 - v85
            let v94 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v95 : System.TimeSpan = v94 v93
            let v98 : (System.TimeSpan -> int32) = _.Hours
            let v99 : int32 = v98 v95
            let v102 : (System.TimeSpan -> int32) = _.Minutes
            let v103 : int32 = v102 v95
            let v106 : (System.TimeSpan -> int32) = _.Seconds
            let v107 : int32 = v106 v95
            let v110 : (System.TimeSpan -> int32) = _.Milliseconds
            let v111 : int32 = v110 v95
            let v114 : System.DateTime = System.DateTime (1, 1, 1, v99, v103, v107, v111)
            v114
    let v122 : string = method8()
    let v125 : (string -> string) = v121.ToString
    let v126 : string = v125 v122
    let _v6 = v126 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v129 : string = $"near_sdk::env::block_timestamp()"
    let v130 : uint64 = Fable.Core.RustInterop.emitRustExpr () v129 
    let v131 : (int64 -> US3) = method7()
    let v132 : US3 option = v5 |> Option.map v131 
    let v143 : US3 = US3_1
    let v144 : US3 = v132 |> Option.defaultValue v143 
    let v153 : uint64 =
        match v144 with
        | US3_1 -> (* None *)
            v130
        | US3_0(v148) -> (* Some *)
            let v149 : (int64 -> uint64) = uint64
            let v150 : uint64 = v149 v148
            let v151 : uint64 = v130 - v150
            v151
    let v154 : uint64 = v153 / 1000000000UL
    let v155 : uint64 = v154 % 60UL
    let v156 : uint64 = v154 / 60UL
    let v157 : uint64 = v156 % 60UL
    let v158 : uint64 = v154 / 3600UL
    let v159 : uint64 = v158 % 24UL
    let v160 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
    let v161 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v159, v157, v155) v160 
    let v162 : string = "fable_library_rust::String_::fromString($0)"
    let v163 : string = Fable.Core.RustInterop.emitRustExpr v161 v162 
    let _v6 = v163 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v164 : (int64 -> US3) = method7()
    let v165 : US3 option = v5 |> Option.map v164 
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
    let _v6 = v222 
    #endif
#if FABLE_COMPILER_PYTHON
    let v225 : (int64 -> US3) = method7()
    let v226 : US3 option = v5 |> Option.map v225 
    let v237 : US3 = US3_1
    let v238 : US3 = v226 |> Option.defaultValue v237 
    let v278 : System.DateTime =
        match v238 with
        | US3_1 -> (* None *)
            let v274 : System.DateTime = System.DateTime.Now
            v274
        | US3_0(v242) -> (* Some *)
            let v243 : System.DateTime = System.DateTime.Now
            let v246 : (System.DateTime -> int64) = _.Ticks
            let v247 : int64 = v246 v243
            let v250 : int64 = v247 - v242
            let v251 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v252 : System.TimeSpan = v251 v250
            let v255 : (System.TimeSpan -> int32) = _.Hours
            let v256 : int32 = v255 v252
            let v259 : (System.TimeSpan -> int32) = _.Minutes
            let v260 : int32 = v259 v252
            let v263 : (System.TimeSpan -> int32) = _.Seconds
            let v264 : int32 = v263 v252
            let v267 : (System.TimeSpan -> int32) = _.Milliseconds
            let v268 : int32 = v267 v252
            let v271 : System.DateTime = System.DateTime (1, 1, 1, v256, v260, v264, v268)
            v271
    let v279 : string = method9()
    let v282 : (string -> string) = v278.ToString
    let v283 : string = v282 v279
    let _v6 = v283 
    #endif
#else
    let v286 : (int64 -> US3) = method7()
    let v287 : US3 option = v5 |> Option.map v286 
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
    let v340 : string = method9()
    let v343 : (string -> string) = v339.ToString
    let v344 : string = v343 v340
    let _v6 = v344 
    #endif
    let v347 : string = _v6 
    v347
and method11 () : string =
    let v0 : string = "\u001b[0m"
    v0
and method10 () : string =
    
    
    
    
    
    let v0 : string = "Debug"
    let v1 : (unit -> string) = v0.ToLower
    let v2 : string = v1 ()
    let v5 : string = v2.PadLeft (7, ' ')
    let v19 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v20 : string = "inline_colorization::color_bright_blue"
    let v21 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v20 
    let v22 : string = "&*$0"
    let v23 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v22 
    let v24 : string = "inline_colorization::color_reset"
    let v25 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v24 
    let v26 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v27 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v21, v23, v25) v26 
    let v28 : string = "fable_library_rust::String_::fromString($0)"
    let v29 : string = Fable.Core.RustInterop.emitRustExpr v27 v28 
    let _v19 = v29 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v30 : string = "inline_colorization::color_bright_blue"
    let v31 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v30 
    let v32 : string = "&*$0"
    let v33 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v32 
    let v34 : string = "inline_colorization::color_reset"
    let v35 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v34 
    let v36 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v37 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v31, v33, v35) v36 
    let v38 : string = "fable_library_rust::String_::fromString($0)"
    let v39 : string = Fable.Core.RustInterop.emitRustExpr v37 v38 
    let _v19 = v39 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v40 : string = "inline_colorization::color_bright_blue"
    let v41 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v40 
    let v42 : string = "&*$0"
    let v43 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v42 
    let v44 : string = "inline_colorization::color_reset"
    let v45 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v44 
    let v46 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v47 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v41, v43, v45) v46 
    let v48 : string = "fable_library_rust::String_::fromString($0)"
    let v49 : string = Fable.Core.RustInterop.emitRustExpr v47 v48 
    let _v19 = v49 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v50 : string = "\u001b[94m"
    let v51 : string = method11()
    let v52 : string = v50 + v5 
    let v53 : string = v52 + v51 
    let _v19 = v53 
    #endif
#if FABLE_COMPILER_PYTHON
    let v54 : string = "\u001b[94m"
    let v55 : string = method11()
    let v56 : string = v54 + v5 
    let v57 : string = v56 + v55 
    let _v19 = v57 
    #endif
#else
    let v58 : string = "\u001b[94m"
    let v59 : string = method11()
    let v60 : string = v58 + v5 
    let v61 : string = v60 + v59 
    let _v19 = v61 
    #endif
    let v62 : string = _v19 
    v62
and method13 () : string =
    let v0 : string = ""
    v0
and closure7 (v0 : Mut3, v1 : string) () : unit =
    let v2 : string = v0.l0
    let v3 : string = v2 + v1 
    v0.l0 <- v3
    ()
and method12 (v0 : std_string_String, v1 : uint64, v2 : std_string_String) : string =
    let v3 : string = method13()
    let v4 : Mut3 = {l0 = v3} : Mut3
    let v5 : string = "{ "
    let v6 : string = $"{v5}"
    let v9 : unit = ()
    let v10 : (unit -> unit) = closure7(v4, v6)
    let v11 : unit = (fun () -> v10 (); v9) ()
    let v14 : string = "alias"
    let v15 : string = $"{v14}"
    let v18 : unit = ()
    let v19 : (unit -> unit) = closure7(v4, v15)
    let v20 : unit = (fun () -> v19 (); v18) ()
    let v23 : string = " = "
    let v24 : string = $"{v23}"
    let v27 : unit = ()
    let v28 : (unit -> unit) = closure7(v4, v24)
    let v29 : unit = (fun () -> v28 (); v27) ()
    let v32 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v33 : string = "format!(\"{:#?}\", $0)"
    let v34 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v33 
    let v35 : string = "fable_library_rust::String_::fromString($0)"
    let v36 : string = Fable.Core.RustInterop.emitRustExpr v34 v35 
    let _v32 = v36 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v37 : string = "format!(\"{:#?}\", $0)"
    let v38 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v37 
    let v39 : string = "fable_library_rust::String_::fromString($0)"
    let v40 : string = Fable.Core.RustInterop.emitRustExpr v38 v39 
    let _v32 = v40 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v41 : string = "format!(\"{:#?}\", $0)"
    let v42 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v41 
    let v43 : string = "fable_library_rust::String_::fromString($0)"
    let v44 : string = Fable.Core.RustInterop.emitRustExpr v42 v43 
    let _v32 = v44 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v45 : string = $"%A{v0}"
    let _v32 = v45 
    #endif
#if FABLE_COMPILER_PYTHON
    let v48 : string = $"%A{v0}"
    let _v32 = v48 
    #endif
#else
    let v51 : string = $"%A{v0}"
    let _v32 = v51 
    #endif
    let v54 : string = _v32 
    let v59 : string = $"{v54}"
    let v62 : unit = ()
    let v63 : (unit -> unit) = closure7(v4, v59)
    let v64 : unit = (fun () -> v63 (); v62) ()
    let v67 : string = "; "
    let v68 : string = $"{v67}"
    let v71 : unit = ()
    let v72 : (unit -> unit) = closure7(v4, v68)
    let v73 : unit = (fun () -> v72 (); v71) ()
    let v76 : string = "block_timestamp"
    let v77 : string = $"{v76}"
    let v80 : unit = ()
    let v81 : (unit -> unit) = closure7(v4, v77)
    let v82 : unit = (fun () -> v81 (); v80) ()
    let v85 : string = $"{v23}"
    let v88 : unit = ()
    let v89 : (unit -> unit) = closure7(v4, v85)
    let v90 : unit = (fun () -> v89 (); v88) ()
    let v93 : string = $"{v1}"
    let v96 : unit = ()
    let v97 : (unit -> unit) = closure7(v4, v93)
    let v98 : unit = (fun () -> v97 (); v96) ()
    let v101 : string = $"{v67}"
    let v104 : unit = ()
    let v105 : (unit -> unit) = closure7(v4, v101)
    let v106 : unit = (fun () -> v105 (); v104) ()
    let v109 : string = "account_id"
    let v110 : string = $"{v109}"
    let v113 : unit = ()
    let v114 : (unit -> unit) = closure7(v4, v110)
    let v115 : unit = (fun () -> v114 (); v113) ()
    let v118 : string = $"{v23}"
    let v121 : unit = ()
    let v122 : (unit -> unit) = closure7(v4, v118)
    let v123 : unit = (fun () -> v122 (); v121) ()
    let v126 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v127 : string = "format!(\"{:#?}\", $0)"
    let v128 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v127 
    let v129 : string = "fable_library_rust::String_::fromString($0)"
    let v130 : string = Fable.Core.RustInterop.emitRustExpr v128 v129 
    let _v126 = v130 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v131 : string = "format!(\"{:#?}\", $0)"
    let v132 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v131 
    let v133 : string = "fable_library_rust::String_::fromString($0)"
    let v134 : string = Fable.Core.RustInterop.emitRustExpr v132 v133 
    let _v126 = v134 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v135 : string = "format!(\"{:#?}\", $0)"
    let v136 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v135 
    let v137 : string = "fable_library_rust::String_::fromString($0)"
    let v138 : string = Fable.Core.RustInterop.emitRustExpr v136 v137 
    let _v126 = v138 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v139 : string = $"%A{v2}"
    let _v126 = v139 
    #endif
#if FABLE_COMPILER_PYTHON
    let v142 : string = $"%A{v2}"
    let _v126 = v142 
    #endif
#else
    let v145 : string = $"%A{v2}"
    let _v126 = v145 
    #endif
    let v148 : string = _v126 
    let v153 : string = $"{v148}"
    let v156 : unit = ()
    let v157 : (unit -> unit) = closure7(v4, v153)
    let v158 : unit = (fun () -> v157 (); v156) ()
    let v161 : string = " }"
    let v162 : string = $"{v161}"
    let v165 : unit = ()
    let v166 : (unit -> unit) = closure7(v4, v162)
    let v167 : unit = (fun () -> v166 (); v165) ()
    let v170 : string = v4.l0
    v170
and method14 (v0 : string, v1 : string, v2 : string, v3 : int64, v4 : string) : string =
    let v5 : string = $"{v0} {v1} #{v3} %s{v2} / {v4}"
    let v8 : char list = []
    let v9 : (char list -> (char [])) = List.toArray
    let v10 : (char []) = v9 v8
    let v13 : string = v5.TrimStart v10 
    let v31 : char list = []
    let v32 : char list = '/' :: v31 
    let v35 : char list = ' ' :: v32 
    let v38 : (char list -> (char [])) = List.toArray
    let v39 : (char []) = v38 v35
    let v42 : string = v13.TrimEnd v39 
    v42
and closure8 (v0 : Mut0) () : unit =
    let v1 : int64 = v0.l0
    let v2 : int64 = v1 + 1L
    v0.l0 <- v2
    ()
and closure10 (v0 : string) () : unit =
    let v1 : (string -> unit) = System.Console.WriteLine
    v1 v0
and closure9 () (v0 : string) : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure10(v0)
    let v3 : unit = (fun () -> v2 (); v1) ()
    ()
and method15 (v0 : string, v1 : Mut0, v2 : Mut1, v3 : Mut2, v4 : Mut3, v5 : Mut4, v6 : int64 option) : unit =
    let v7 : unit = ()
    let v8 : (unit -> unit) = closure8(v1)
    let v9 : unit = (fun () -> v8 (); v7) ()
    let v12 : (string -> unit) = closure9()
    let v13 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v14 : string = @"println!(""{}"", $0)"
    Fable.Core.RustInterop.emitRustExpr v0 v14 
    let _v13 = () 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v15 : string = @"println!(""{}"", $0)"
    Fable.Core.RustInterop.emitRustExpr v0 v15 
    let _v13 = () 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v16 : string = v4.l0
    let v17 : bool = v16 = ""
    let v25 : string =
        if v17 then
            v0
        else
            let v18 : bool = v0 = ""
            if v18 then
                let v19 : string = v4.l0
                v19
            else
                let v20 : string = v4.l0
                let v21 : string = "\n"
                let v22 : string = v20 + v21 
                let v23 : string = v22 + v0 
                v23
    let v26 : string = "&*$0"
    let v27 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v25 v26 
    let v28 : string = $"$0.chars()"
    let v29 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v27 v28 
    let v30 : string = "$0"
    let v31 : _ = Fable.Core.RustInterop.emitRustExpr v29 v30 
    let v32 : string = "$0.collect::<Vec<_>>()"
    let v33 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v31 v32 
    let v34 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
    let v35 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v33 v34 
    let v36 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
    let v37 : bool = Fable.Core.RustInterop.emitRustExpr v35 v36 
    let v38 : string = "x"
    let v39 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v38 
    let v40 : string = "String::from_iter($0)"
    let v41 : std_string_String = Fable.Core.RustInterop.emitRustExpr v39 v40 
    let v42 : string = "true; $0 }).collect::<Vec<_>>()"
    let v43 : bool = Fable.Core.RustInterop.emitRustExpr v41 v42 
    let v44 : string = "_vec_map"
    let v45 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v44 
    let v46 : string = "$0.len()"
    let v47 : unativeint = Fable.Core.RustInterop.emitRustExpr v45 v46 
    let v48 : (unativeint -> int32) = int32
    let v49 : int32 = v48 v47
    let v50 : string = ""
    let v51 : bool = v0 <> v50 
    let v55 : bool =
        if v51 then
            let v54 : bool = v49 <= 1
            v54
        else
            false
    if v55 then
        v4.l0 <- v25
        ()
    else
        v4.l0 <- v50
        let v56 : string = "true; $0.into_iter().for_each(|x| { //"
        let v57 : bool = Fable.Core.RustInterop.emitRustExpr v45 v56 
        let v58 : string = "x"
        let v59 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v58 
        let v60 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
        let v61 : bool = Fable.Core.RustInterop.emitRustExpr v59 v60 
        let v62 : string = $"true"
        let v63 : bool = Fable.Core.RustInterop.emitRustExpr () v62 
        let v64 : string = "true; }); //"
        let v65 : bool = Fable.Core.RustInterop.emitRustExpr () v64 
        ()
    let _v13 = () 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    v12 v0
    let _v13 = () 
    #endif
#if FABLE_COMPILER_PYTHON
    v12 v0
    let _v13 = () 
    #endif
#else
    v12 v0
    let _v13 = () 
    #endif
    _v13 
    let v66 : (string -> unit) = v2.l0
    v66 v0
and closure2 (v0 : std_string_String, v1 : near_sdk_AccountId, v2 : uint64) () : unit =
    let v3 : unit = ()
    let v4 : (unit -> unit) = closure3()
    let v5 : unit = (fun () -> v4 (); v3) ()
    let struct (v19 : Mut0, v20 : Mut1, v21 : Mut2, v22 : Mut3, v23 : Mut4, v24 : int64 option) = TraceState.trace_state.Value
    let v37 : US0 = v23.l0
    let v38 : bool = v21.l0
    let v39 : bool = v38 = false
    let v42 : bool =
        if v39 then
            false
        else
            let v40 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v37
            let v41 : bool = 1 >= v40
            v41
    if v42 then
        let v43 : unit = ()
        let v44 : unit = (fun () -> v4 (); v43) ()
        let struct (v58 : Mut0, v59 : Mut1, v60 : Mut2, v61 : Mut3, v62 : Mut4, v63 : int64 option) = TraceState.trace_state.Value
        let v76 : string = method6(v58, v59, v60, v61, v62, v63)
        let v77 : string = method10()
        let v78 : string = $"chat_contract.claim_alias"
        let v79 : bool = v78 = ""
        let v86 : string =
            if v79 then
                let v80 : string = ""
                v80
            else
                let v81 : int64 = v58.l0
                let v82 : string = $"v1.to_string()"
                let v83 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v82 
                let v84 : string = method12(v0, v2, v83)
                method14(v76, v77, v78, v81, v84)
        let v87 : unit = ()
        let v88 : unit = (fun () -> v4 (); v87) ()
        let struct (v102 : Mut0, v103 : Mut1, v104 : Mut2, v105 : Mut3, v106 : Mut4, v107 : int64 option) = TraceState.trace_state.Value
        method15(v86, v102, v103, v104, v105, v106, v107)
and closure11 () (v0 : std_string_String) : US4 =
    US4_0(v0)
and method16 () : (std_string_String -> US4) =
    closure11()
and method17 () : string =
    
    
    
    
    
    let v0 : string = "Warning"
    let v1 : (unit -> string) = v0.ToLower
    let v2 : string = v1 ()
    let v5 : string = v2.PadLeft (7, ' ')
    let v19 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v20 : string = "inline_colorization::color_yellow"
    let v21 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v20 
    let v22 : string = "&*$0"
    let v23 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v22 
    let v24 : string = "inline_colorization::color_reset"
    let v25 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v24 
    let v26 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v27 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v21, v23, v25) v26 
    let v28 : string = "fable_library_rust::String_::fromString($0)"
    let v29 : string = Fable.Core.RustInterop.emitRustExpr v27 v28 
    let _v19 = v29 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v30 : string = "inline_colorization::color_yellow"
    let v31 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v30 
    let v32 : string = "&*$0"
    let v33 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v32 
    let v34 : string = "inline_colorization::color_reset"
    let v35 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v34 
    let v36 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v37 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v31, v33, v35) v36 
    let v38 : string = "fable_library_rust::String_::fromString($0)"
    let v39 : string = Fable.Core.RustInterop.emitRustExpr v37 v38 
    let _v19 = v39 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v40 : string = "inline_colorization::color_yellow"
    let v41 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v40 
    let v42 : string = "&*$0"
    let v43 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v42 
    let v44 : string = "inline_colorization::color_reset"
    let v45 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v44 
    let v46 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v47 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v41, v43, v45) v46 
    let v48 : string = "fable_library_rust::String_::fromString($0)"
    let v49 : string = Fable.Core.RustInterop.emitRustExpr v47 v48 
    let _v19 = v49 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v50 : string = "\u001b[93m"
    let v51 : string = method11()
    let v52 : string = v50 + v5 
    let v53 : string = v52 + v51 
    let _v19 = v53 
    #endif
#if FABLE_COMPILER_PYTHON
    let v54 : string = "\u001b[93m"
    let v55 : string = method11()
    let v56 : string = v54 + v5 
    let v57 : string = v56 + v55 
    let _v19 = v57 
    #endif
#else
    let v58 : string = "\u001b[93m"
    let v59 : string = method11()
    let v60 : string = v58 + v5 
    let v61 : string = v60 + v59 
    let _v19 = v61 
    #endif
    let v62 : string = _v19 
    v62
and method18 (v0 : string) : string =
    let v1 : string = method13()
    let v2 : Mut3 = {l0 = v1} : Mut3
    let v3 : string = "{ "
    let v4 : string = $"{v3}"
    let v7 : unit = ()
    let v8 : (unit -> unit) = closure7(v2, v4)
    let v9 : unit = (fun () -> v8 (); v7) ()
    let v12 : string = "account_alias"
    let v13 : string = $"{v12}"
    let v16 : unit = ()
    let v17 : (unit -> unit) = closure7(v2, v13)
    let v18 : unit = (fun () -> v17 (); v16) ()
    let v21 : string = " = "
    let v22 : string = $"{v21}"
    let v25 : unit = ()
    let v26 : (unit -> unit) = closure7(v2, v22)
    let v27 : unit = (fun () -> v26 (); v25) ()
    let v30 : string = $"{v0}"
    let v33 : unit = ()
    let v34 : (unit -> unit) = closure7(v2, v30)
    let v35 : unit = (fun () -> v34 (); v33) ()
    let v38 : string = " }"
    let v39 : string = $"{v38}"
    let v42 : unit = ()
    let v43 : (unit -> unit) = closure7(v2, v39)
    let v44 : unit = (fun () -> v43 (); v42) ()
    let v47 : string = v2.l0
    v47
and closure12 (v0 : std_string_String) () : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure3()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v17 : Mut0, v18 : Mut1, v19 : Mut2, v20 : Mut3, v21 : Mut4, v22 : int64 option) = TraceState.trace_state.Value
    let v35 : US0 = v21.l0
    let v36 : bool = v19.l0
    let v37 : bool = v36 = false
    let v40 : bool =
        if v37 then
            false
        else
            let v38 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v35
            let v39 : bool = 3 >= v38
            v39
    if v40 then
        let v41 : unit = ()
        let v42 : unit = (fun () -> v2 (); v41) ()
        let struct (v56 : Mut0, v57 : Mut1, v58 : Mut2, v59 : Mut3, v60 : Mut4, v61 : int64 option) = TraceState.trace_state.Value
        let v74 : string = method6(v56, v57, v58, v59, v60, v61)
        let v75 : string = method17()
        let v76 : string = $"chat_contract.claim_alias / alias already claimed"
        let v77 : bool = v76 = ""
        let v85 : string =
            if v77 then
                let v78 : string = ""
                v78
            else
                let v79 : int64 = v56.l0
                let v80 : string = $"%A{v0}"
                let v83 : string = method18(v80)
                method14(v74, v75, v76, v79, v83)
        let v86 : unit = ()
        let v87 : unit = (fun () -> v2 (); v86) ()
        let struct (v101 : Mut0, v102 : Mut1, v103 : Mut2, v104 : Mut3, v105 : Mut4, v106 : int64 option) = TraceState.trace_state.Value
        method15(v85, v101, v102, v103, v104, v105, v106)
and closure13 (v0 : std_string_String option) () : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure3()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v17 : Mut0, v18 : Mut1, v19 : Mut2, v20 : Mut3, v21 : Mut4, v22 : int64 option) = TraceState.trace_state.Value
    let v35 : US0 = v21.l0
    let v36 : bool = v19.l0
    let v37 : bool = v36 = false
    let v40 : bool =
        if v37 then
            false
        else
            let v38 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v35
            let v39 : bool = 1 >= v38
            v39
    if v40 then
        let v41 : unit = ()
        let v42 : unit = (fun () -> v2 (); v41) ()
        let struct (v56 : Mut0, v57 : Mut1, v58 : Mut2, v59 : Mut3, v60 : Mut4, v61 : int64 option) = TraceState.trace_state.Value
        let v74 : string = method6(v56, v57, v58, v59, v60, v61)
        let v75 : string = method10()
        let v76 : string = $"chat_contract.claim_alias"
        let v77 : bool = v76 = ""
        let v85 : string =
            if v77 then
                let v78 : string = ""
                v78
            else
                let v79 : int64 = v56.l0
                let v80 : string = $"%A{v0}"
                let v83 : string = method18(v80)
                method14(v74, v75, v76, v79, v83)
        let v86 : unit = ()
        let v87 : unit = (fun () -> v2 (); v86) ()
        let struct (v101 : Mut0, v102 : Mut1, v103 : Mut2, v104 : Mut3, v105 : Mut4, v106 : int64 option) = TraceState.trace_state.Value
        method15(v85, v101, v102, v103, v104, v105, v106)
and closure14 () () : unit =
    ()
and method19 () : (unit -> unit) =
    closure14()
and method20 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option) : unit =
    let v6 : unit = ()
    let v7 : (unit -> unit) = closure8(v0)
    let v8 : unit = (fun () -> v7 (); v6) ()
    let v11 : string = ""
    let v12 : (string -> unit) = closure9()
    let v13 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v14 : string = @"println!(""{}"", $0)"
    Fable.Core.RustInterop.emitRustExpr v11 v14 
    let _v13 = () 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v15 : string = @"println!(""{}"", $0)"
    Fable.Core.RustInterop.emitRustExpr v11 v15 
    let _v13 = () 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v16 : string = v3.l0
    let v17 : bool = v16 = ""
    let v25 : string =
        if v17 then
            v11
        else
            let v18 : bool = v11 = ""
            if v18 then
                let v19 : string = v3.l0
                v19
            else
                let v20 : string = v3.l0
                let v21 : string = "\n"
                let v22 : string = v20 + v21 
                let v23 : string = v22 + v11 
                v23
    let v26 : string = "&*$0"
    let v27 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v25 v26 
    let v28 : string = $"$0.chars()"
    let v29 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v27 v28 
    let v30 : string = "$0"
    let v31 : _ = Fable.Core.RustInterop.emitRustExpr v29 v30 
    let v32 : string = "$0.collect::<Vec<_>>()"
    let v33 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v31 v32 
    let v34 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
    let v35 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v33 v34 
    let v36 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
    let v37 : bool = Fable.Core.RustInterop.emitRustExpr v35 v36 
    let v38 : string = "x"
    let v39 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v38 
    let v40 : string = "String::from_iter($0)"
    let v41 : std_string_String = Fable.Core.RustInterop.emitRustExpr v39 v40 
    let v42 : string = "true; $0 }).collect::<Vec<_>>()"
    let v43 : bool = Fable.Core.RustInterop.emitRustExpr v41 v42 
    let v44 : string = "_vec_map"
    let v45 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v44 
    let v46 : string = "$0.len()"
    let v47 : unativeint = Fable.Core.RustInterop.emitRustExpr v45 v46 
    let v48 : (unativeint -> int32) = int32
    let v49 : int32 = v48 v47
    let v50 : bool = v11 <> v11 
    let v54 : bool =
        if v50 then
            let v53 : bool = v49 <= 1
            v53
        else
            false
    if v54 then
        v3.l0 <- v25
        ()
    else
        v3.l0 <- v11
        let v55 : string = "true; $0.into_iter().for_each(|x| { //"
        let v56 : bool = Fable.Core.RustInterop.emitRustExpr v45 v55 
        let v57 : string = "x"
        let v58 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v57 
        let v59 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
        let v60 : bool = Fable.Core.RustInterop.emitRustExpr v58 v59 
        let v61 : string = $"true"
        let v62 : bool = Fable.Core.RustInterop.emitRustExpr () v61 
        let v63 : string = "true; }); //"
        let v64 : bool = Fable.Core.RustInterop.emitRustExpr () v63 
        ()
    let _v13 = () 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    v12 v11
    let _v13 = () 
    #endif
#if FABLE_COMPILER_PYTHON
    v12 v11
    let _v13 = () 
    #endif
#else
    v12 v11
    let _v13 = () 
    #endif
    _v13 
    let v65 : (string -> unit) = v1.l0
    v65 v11
and closure15 (v0 : (unit -> unit)) () : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure3()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v17 : Mut0, v18 : Mut1, v19 : Mut2, v20 : Mut3, v21 : Mut4, v22 : int64 option) = TraceState.trace_state.Value
    let v35 : US0 = v21.l0
    let v36 : bool = v19.l0
    let v37 : bool = v36 = false
    let v40 : bool =
        if v37 then
            false
        else
            let v38 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v35
            let v39 : bool = 1 >= v38
            v39
    if v40 then
        let v41 : unit = ()
        let v42 : unit = (fun () -> v2 (); v41) ()
        let struct (v56 : Mut0, v57 : Mut1, v58 : Mut2, v59 : Mut3, v60 : Mut4, v61 : int64 option) = TraceState.trace_state.Value
        let v74 : string = method6(v56, v57, v58, v59, v60, v61)
        let v75 : string = method10()
        let v76 : unit = ()
        let v77 : unit = (fun () -> v2 (); v76) ()
        let struct (v91 : Mut0, v92 : Mut1, v93 : Mut2, v94 : Mut3, v95 : Mut4, v96 : int64 option) = TraceState.trace_state.Value
        method20(v91, v92, v93, v94, v95, v96)
and method21 (v0 : near_sdk_AccountId, v1 : struct (std_string_String * uint64 * uint32) option) : string =
    let v2 : string = method13()
    let v3 : Mut3 = {l0 = v2} : Mut3
    let v4 : string = "{ "
    let v5 : string = $"{v4}"
    let v8 : unit = ()
    let v9 : (unit -> unit) = closure7(v3, v5)
    let v10 : unit = (fun () -> v9 (); v8) ()
    let v13 : string = "account_id"
    let v14 : string = $"{v13}"
    let v17 : unit = ()
    let v18 : (unit -> unit) = closure7(v3, v14)
    let v19 : unit = (fun () -> v18 (); v17) ()
    let v22 : string = " = "
    let v23 : string = $"{v22}"
    let v26 : unit = ()
    let v27 : (unit -> unit) = closure7(v3, v23)
    let v28 : unit = (fun () -> v27 (); v26) ()
    let v31 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v32 : string = "format!(\"{:#?}\", $0)"
    let v33 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v32 
    let v34 : string = "fable_library_rust::String_::fromString($0)"
    let v35 : string = Fable.Core.RustInterop.emitRustExpr v33 v34 
    let _v31 = v35 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v36 : string = "format!(\"{:#?}\", $0)"
    let v37 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v36 
    let v38 : string = "fable_library_rust::String_::fromString($0)"
    let v39 : string = Fable.Core.RustInterop.emitRustExpr v37 v38 
    let _v31 = v39 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v40 : string = "format!(\"{:#?}\", $0)"
    let v41 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v40 
    let v42 : string = "fable_library_rust::String_::fromString($0)"
    let v43 : string = Fable.Core.RustInterop.emitRustExpr v41 v42 
    let _v31 = v43 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v44 : string = $"%A{v0}"
    let _v31 = v44 
    #endif
#if FABLE_COMPILER_PYTHON
    let v47 : string = $"%A{v0}"
    let _v31 = v47 
    #endif
#else
    let v50 : string = $"%A{v0}"
    let _v31 = v50 
    #endif
    let v53 : string = _v31 
    let v58 : string = $"{v53}"
    let v61 : unit = ()
    let v62 : (unit -> unit) = closure7(v3, v58)
    let v63 : unit = (fun () -> v62 (); v61) ()
    let v66 : string = "; "
    let v67 : string = $"{v66}"
    let v70 : unit = ()
    let v71 : (unit -> unit) = closure7(v3, v67)
    let v72 : unit = (fun () -> v71 (); v70) ()
    let v75 : string = "result"
    let v76 : string = $"{v75}"
    let v79 : unit = ()
    let v80 : (unit -> unit) = closure7(v3, v76)
    let v81 : unit = (fun () -> v80 (); v79) ()
    let v84 : string = $"{v22}"
    let v87 : unit = ()
    let v88 : (unit -> unit) = closure7(v3, v84)
    let v89 : unit = (fun () -> v88 (); v87) ()
    let v92 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v93 : string = "format!(\"{:#?}\", $0)"
    let v94 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1 v93 
    let v95 : string = "fable_library_rust::String_::fromString($0)"
    let v96 : string = Fable.Core.RustInterop.emitRustExpr v94 v95 
    let _v92 = v96 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v97 : string = "format!(\"{:#?}\", $0)"
    let v98 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1 v97 
    let v99 : string = "fable_library_rust::String_::fromString($0)"
    let v100 : string = Fable.Core.RustInterop.emitRustExpr v98 v99 
    let _v92 = v100 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v101 : string = "format!(\"{:#?}\", $0)"
    let v102 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1 v101 
    let v103 : string = "fable_library_rust::String_::fromString($0)"
    let v104 : string = Fable.Core.RustInterop.emitRustExpr v102 v103 
    let _v92 = v104 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v105 : string = $"%A{v1}"
    let _v92 = v105 
    #endif
#if FABLE_COMPILER_PYTHON
    let v108 : string = $"%A{v1}"
    let _v92 = v108 
    #endif
#else
    let v111 : string = $"%A{v1}"
    let _v92 = v111 
    #endif
    let v114 : string = _v92 
    let v119 : string = $"{v114}"
    let v122 : unit = ()
    let v123 : (unit -> unit) = closure7(v3, v119)
    let v124 : unit = (fun () -> v123 (); v122) ()
    let v127 : string = " }"
    let v128 : string = $"{v127}"
    let v131 : unit = ()
    let v132 : (unit -> unit) = closure7(v3, v128)
    let v133 : unit = (fun () -> v132 (); v131) ()
    let v136 : string = v3.l0
    v136
and closure16 (v0 : near_sdk_AccountId, v1 : struct (std_string_String * uint64 * uint32) option) () : unit =
    let v2 : unit = ()
    let v3 : (unit -> unit) = closure3()
    let v4 : unit = (fun () -> v3 (); v2) ()
    let struct (v18 : Mut0, v19 : Mut1, v20 : Mut2, v21 : Mut3, v22 : Mut4, v23 : int64 option) = TraceState.trace_state.Value
    let v36 : US0 = v22.l0
    let v37 : bool = v20.l0
    let v38 : bool = v37 = false
    let v41 : bool =
        if v38 then
            false
        else
            let v39 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v36
            let v40 : bool = 1 >= v39
            v40
    if v41 then
        let v42 : unit = ()
        let v43 : unit = (fun () -> v3 (); v42) ()
        let struct (v57 : Mut0, v58 : Mut1, v59 : Mut2, v60 : Mut3, v61 : Mut4, v62 : int64 option) = TraceState.trace_state.Value
        let v75 : string = method6(v57, v58, v59, v60, v61, v62)
        let v76 : string = method10()
        let v77 : string = $"chat_contract.get_account_info"
        let v78 : bool = v77 = ""
        let v83 : string =
            if v78 then
                let v79 : string = ""
                v79
            else
                let v80 : int64 = v57.l0
                let v81 : string = method21(v0, v1)
                method14(v75, v76, v77, v80, v81)
        let v84 : unit = ()
        let v85 : unit = (fun () -> v3 (); v84) ()
        let struct (v99 : Mut0, v100 : Mut1, v101 : Mut2, v102 : Mut3, v103 : Mut4, v104 : int64 option) = TraceState.trace_state.Value
        method15(v83, v99, v100, v101, v102, v103, v104)
and closure17 () () : unit =
    let v0 : unit = ()
    let v1 : (unit -> unit) = closure3()
    let v2 : unit = (fun () -> v1 (); v0) ()
    let struct (v16 : Mut0, v17 : Mut1, v18 : Mut2, v19 : Mut3, v20 : Mut4, v21 : int64 option) = TraceState.trace_state.Value
    let v34 : US0 = v20.l0
    let v35 : bool = v18.l0
    let v36 : bool = v35 = false
    let v39 : bool =
        if v36 then
            false
        else
            let v37 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v34
            let v38 : bool = 1 >= v37
            v38
    if v39 then
        let v40 : unit = ()
        let v41 : unit = (fun () -> v1 (); v40) ()
        let struct (v55 : Mut0, v56 : Mut1, v57 : Mut2, v58 : Mut3, v59 : Mut4, v60 : int64 option) = TraceState.trace_state.Value
        let v73 : string = method6(v55, v56, v57, v58, v59, v60)
        let v74 : string = method10()
        let v75 : unit = ()
        let v76 : unit = (fun () -> v1 (); v75) ()
        let struct (v90 : Mut0, v91 : Mut1, v92 : Mut2, v93 : Mut3, v94 : Mut4, v95 : int64 option) = TraceState.trace_state.Value
        method20(v90, v91, v92, v93, v94, v95)
and method22 (v0 : std_string_String) : string =
    let v1 : string = method13()
    let v2 : Mut3 = {l0 = v1} : Mut3
    let v3 : string = "{ "
    let v4 : string = $"{v3}"
    let v7 : unit = ()
    let v8 : (unit -> unit) = closure7(v2, v4)
    let v9 : unit = (fun () -> v8 (); v7) ()
    let v12 : string = "alias"
    let v13 : string = $"{v12}"
    let v16 : unit = ()
    let v17 : (unit -> unit) = closure7(v2, v13)
    let v18 : unit = (fun () -> v17 (); v16) ()
    let v21 : string = " = "
    let v22 : string = $"{v21}"
    let v25 : unit = ()
    let v26 : (unit -> unit) = closure7(v2, v22)
    let v27 : unit = (fun () -> v26 (); v25) ()
    let v30 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v31 : string = "format!(\"{:#?}\", $0)"
    let v32 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v31 
    let v33 : string = "fable_library_rust::String_::fromString($0)"
    let v34 : string = Fable.Core.RustInterop.emitRustExpr v32 v33 
    let _v30 = v34 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v35 : string = "format!(\"{:#?}\", $0)"
    let v36 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v35 
    let v37 : string = "fable_library_rust::String_::fromString($0)"
    let v38 : string = Fable.Core.RustInterop.emitRustExpr v36 v37 
    let _v30 = v38 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v39 : string = "format!(\"{:#?}\", $0)"
    let v40 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v39 
    let v41 : string = "fable_library_rust::String_::fromString($0)"
    let v42 : string = Fable.Core.RustInterop.emitRustExpr v40 v41 
    let _v30 = v42 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v43 : string = $"%A{v0}"
    let _v30 = v43 
    #endif
#if FABLE_COMPILER_PYTHON
    let v46 : string = $"%A{v0}"
    let _v30 = v46 
    #endif
#else
    let v49 : string = $"%A{v0}"
    let _v30 = v49 
    #endif
    let v52 : string = _v30 
    let v57 : string = $"{v52}"
    let v60 : unit = ()
    let v61 : (unit -> unit) = closure7(v2, v57)
    let v62 : unit = (fun () -> v61 (); v60) ()
    let v65 : string = " }"
    let v66 : string = $"{v65}"
    let v69 : unit = ()
    let v70 : (unit -> unit) = closure7(v2, v66)
    let v71 : unit = (fun () -> v70 (); v69) ()
    let v74 : string = v2.l0
    v74
and closure18 (v0 : std_string_String) () : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure3()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v17 : Mut0, v18 : Mut1, v19 : Mut2, v20 : Mut3, v21 : Mut4, v22 : int64 option) = TraceState.trace_state.Value
    let v35 : US0 = v21.l0
    let v36 : bool = v19.l0
    let v37 : bool = v36 = false
    let v40 : bool =
        if v37 then
            false
        else
            let v38 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v35
            let v39 : bool = 1 >= v38
            v39
    if v40 then
        let v41 : unit = ()
        let v42 : unit = (fun () -> v2 (); v41) ()
        let struct (v56 : Mut0, v57 : Mut1, v58 : Mut2, v59 : Mut3, v60 : Mut4, v61 : int64 option) = TraceState.trace_state.Value
        let v74 : string = method6(v56, v57, v58, v59, v60, v61)
        let v75 : string = method10()
        let v76 : string = $"chat_contract.get_alias_map"
        let v77 : bool = v76 = ""
        let v82 : string =
            if v77 then
                let v78 : string = ""
                v78
            else
                let v79 : int64 = v56.l0
                let v80 : string = method22(v0)
                method14(v74, v75, v76, v79, v80)
        let v83 : unit = ()
        let v84 : unit = (fun () -> v2 (); v83) ()
        let struct (v98 : Mut0, v99 : Mut1, v100 : Mut2, v101 : Mut3, v102 : Mut4, v103 : int64 option) = TraceState.trace_state.Value
        method15(v82, v98, v99, v100, v101, v102, v103)
and method23 () : (unit -> unit) =
    closure14()
and closure19 (v0 : (unit -> unit)) () : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure3()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v17 : Mut0, v18 : Mut1, v19 : Mut2, v20 : Mut3, v21 : Mut4, v22 : int64 option) = TraceState.trace_state.Value
    let v35 : US0 = v21.l0
    let v36 : bool = v19.l0
    let v37 : bool = v36 = false
    let v40 : bool =
        if v37 then
            false
        else
            let v38 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v35
            let v39 : bool = 1 >= v38
            v39
    if v40 then
        let v41 : unit = ()
        let v42 : unit = (fun () -> v2 (); v41) ()
        let struct (v56 : Mut0, v57 : Mut1, v58 : Mut2, v59 : Mut3, v60 : Mut4, v61 : int64 option) = TraceState.trace_state.Value
        let v74 : string = method6(v56, v57, v58, v59, v60, v61)
        let v75 : string = method10()
        let v76 : unit = ()
        let v77 : unit = (fun () -> v2 (); v76) ()
        let struct (v91 : Mut0, v92 : Mut1, v93 : Mut2, v94 : Mut3, v95 : Mut4, v96 : int64 option) = TraceState.trace_state.Value
        method20(v91, v92, v93, v94, v95, v96)
and closure0 () () : unit =
    let v0 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v0 
    let v1 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v1 
    let v2 : string = "#[derive( //"
    Fable.Core.RustInterop.emitRustExpr () v2 
    let v3 : string = "  near_sdk::PanicOnDefault, //"
    Fable.Core.RustInterop.emitRustExpr () v3 
    let v4 : string = "  borsh::BorshDeserialize, //"
    Fable.Core.RustInterop.emitRustExpr () v4 
    let v5 : string = "  borsh::BorshSerialize, //"
    Fable.Core.RustInterop.emitRustExpr () v5 
    let v6 : string = ")] //"
    Fable.Core.RustInterop.emitRustExpr () v6 
    let v7 : string = "pub struct State ( //"
    Fable.Core.RustInterop.emitRustExpr () v7 
    let v8 : string = "/*"
    Fable.Core.RustInterop.emitRustExpr () v8 
    let v9 : TypeEmit<struct (uint32 * near_sdk_store_LookupMap<std_string_String, std_collections_HashMap<near_sdk_AccountId, struct (uint64 * uint32)>> * near_sdk_store_LookupMap<near_sdk_AccountId, std_string_String>)> = null |> unbox<TypeEmit<struct (uint32 * near_sdk_store_LookupMap<std_string_String, std_collections_HashMap<near_sdk_AccountId, struct (uint64 * uint32)>> * near_sdk_store_LookupMap<near_sdk_AccountId, std_string_String>)>>
    let v12 : string = "*/ )"
    Fable.Core.RustInterop.emitRustExpr () v12 
    let v13 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v13 
    let v14 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v14 
    let v15 : string = "#[init] //"
    Fable.Core.RustInterop.emitRustExpr () v15 
    let v16 : string = "pub fn new() -> Self { // 1"
    Fable.Core.RustInterop.emitRustExpr () v16 
    let v17 : string = "true; /*"
    let v18 : bool = Fable.Core.RustInterop.emitRustExpr () v17 
    let v19 : TypeEmit<unit> = null |> unbox<TypeEmit<unit>>
    let v22 : string = "true; */"
    let v23 : bool = Fable.Core.RustInterop.emitRustExpr () v22 
    let v24 : string = "alias_map"
    let v25 : string = "b\"" + v24 + "\""
    let v26 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v25 
    let v27 : string = "near_sdk::store::LookupMap::new(v26)"
    let v28 : near_sdk_store_LookupMap<std_string_String, std_collections_HashMap<near_sdk_AccountId, struct (uint64 * uint32)>> = Fable.Core.RustInterop.emitRustExpr () v27 
    let v29 : string = "account_map"
    let v30 : string = "b\"" + v29 + "\""
    let v31 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v30 
    let v32 : string = "near_sdk::store::LookupMap::new(v31)"
    let v33 : near_sdk_store_LookupMap<near_sdk_AccountId, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v32 
    let _result = struct (1u, v28, v33) in _result |> (fun x -> Fable.Core.RustInterop.emitRustExpr x $"Self($0) // x") // 2
    let v34 : string = "} // 2."
    Fable.Core.RustInterop.emitRustExpr () v34 
    let v35 : string = "} // 1."
    Fable.Core.RustInterop.emitRustExpr () v35 
    let v36 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v36 
    let v37 : string = "true; // ??? / i: 1uy / i': 1uy / acc: 0uy / n: 2uy"
    let v38 : bool = Fable.Core.RustInterop.emitRustExpr () v37 
    let v39 : string = "true; */ // ???? / i: 1uy / i': 2uy / acc: 0uy / n: 2uy"
    let v40 : bool = Fable.Core.RustInterop.emitRustExpr () v39 
    let v41 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v41 
    let v42 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v42 
    let v43 : string = "fn is_valid_alias(alias: String) -> bool { //"
    Fable.Core.RustInterop.emitRustExpr () v43 
    let v44 : string = $"alias"
    let v45 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v44 
    let v46 : string = "fable_library_rust::String_::fromString($0)"
    let v47 : string = Fable.Core.RustInterop.emitRustExpr v45 v46 
    let v48 : int32 = v47.Length
    let v49 : bool = v48 > 0
    let v71 : bool =
        if v49 then
            let v50 : bool = v48 < 64
            if v50 then
                let v51 : string = "-"
                let v52 : bool = v47.StartsWith v51 
                let v55 : bool = v52 = false
                if v55 then
                    let v56 : bool = v47.EndsWith v51 
                    let v57 : bool = v56 = false
                    if v57 then
                        let v58 : string = "&*$0"
                        let v59 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v47 v58 
                        let v60 : string = $"$0.chars()"
                        let v61 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v59 v60 
                        let v62 : string = "true; // 1"
                        let v63 : bool = Fable.Core.RustInterop.emitRustExpr () v62 
                        let v64 : string = "let mut v61 = v61"
                        Fable.Core.RustInterop.emitRustExpr () v64 
                        let v65 : string = $"v61.all(|x| $0(x))"
                        let v66 : (char -> bool) = closure1()
                        let v67 : bool = Fable.Core.RustInterop.emitRustExpr v66 v65 
                        v67
                    else
                        false
                else
                    false
            else
                false
        else
            false
    let _result = v71 in _result |> (fun x -> Fable.Core.RustInterop.emitRustExpr x "$0 }") // 2
    let v72 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v72 
    let v73 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v73 
    let v74 : string = "true; // ??? / i: 2uy / i': 1uy / acc: 2uy / n: 1uy"
    let v75 : bool = Fable.Core.RustInterop.emitRustExpr () v74 
    let v76 : string = "true; */ // ???? / i: 2uy / i': 2uy / acc: 2uy / n: 1uy"
    let v77 : bool = Fable.Core.RustInterop.emitRustExpr () v76 
    let v78 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v78 
    let v79 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v79 
    let v80 : string = "pub fn generate_cid( //"
    Fable.Core.RustInterop.emitRustExpr () v80 
    let v81 : string = "  &self, //"
    Fable.Core.RustInterop.emitRustExpr () v81 
    let v82 : string = "  content: Vec<u8>, //"
    Fable.Core.RustInterop.emitRustExpr () v82 
    let v83 : string = ") -> String { //"
    Fable.Core.RustInterop.emitRustExpr () v83 
    let v84 : string = $"content"
    let v85 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v84 
    let v86 : string = "  fn encode_u64(value: u64) -> Vec<u8> { //"
    Fable.Core.RustInterop.emitRustExpr () v86 
    let v87 : string = "    let mut buffer = unsigned_varint::encode::u64_buffer(); //"
    Fable.Core.RustInterop.emitRustExpr () v87 
    let v88 : string = "    unsigned_varint::encode::u64(value, &mut buffer).to_vec() //"
    Fable.Core.RustInterop.emitRustExpr () v88 
    let v89 : string = "  } //"
    Fable.Core.RustInterop.emitRustExpr () v89 
    let v90 : string = "  fn sha256_hash(content: &[u8]) -> Vec<u8> { //"
    Fable.Core.RustInterop.emitRustExpr () v90 
    let v91 : string = "    let mut hasher: sha2::Sha256 = sha2::Digest::new(); //"
    Fable.Core.RustInterop.emitRustExpr () v91 
    let v92 : string = "    sha2::Digest::update(&mut hasher, content); //"
    Fable.Core.RustInterop.emitRustExpr () v92 
    let v93 : string = "    sha2::Digest::finalize(hasher).to_vec() //"
    Fable.Core.RustInterop.emitRustExpr () v93 
    let v94 : string = "  } //"
    Fable.Core.RustInterop.emitRustExpr () v94 
    let v95 : string = "  let version: u8 = 1; //"
    Fable.Core.RustInterop.emitRustExpr () v95 
    let v96 : string = "  let codec_raw: u64 = 0x55; //"
    Fable.Core.RustInterop.emitRustExpr () v96 
    let v97 : string = "  let codec_bytes = encode_u64(codec_raw); //"
    Fable.Core.RustInterop.emitRustExpr () v97 
    let v98 : string = "  let hash_result = sha256_hash(&v85); //"
    Fable.Core.RustInterop.emitRustExpr () v98 
    let v99 : string = "  let multihash = std::iter::once(0x12) //"
    Fable.Core.RustInterop.emitRustExpr () v99 
    let v100 : string = "    .chain(std::iter::once(32)) //"
    Fable.Core.RustInterop.emitRustExpr () v100 
    let v101 : string = "    .chain(hash_result.into_iter()) //"
    Fable.Core.RustInterop.emitRustExpr () v101 
    let v102 : string = "    .collect(); //"
    Fable.Core.RustInterop.emitRustExpr () v102 
    let v103 : string = "  let cid_bytes = [vec![version], codec_bytes, multihash].concat(); //"
    Fable.Core.RustInterop.emitRustExpr () v103 
    let v104 : string = "  let result = multibase::encode(multibase::Base::Base32Lower, &cid_bytes); //"
    Fable.Core.RustInterop.emitRustExpr () v104 
    let v105 : string = "result"
    let v106 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v105 
    let _result = v106 in _result |> (fun x -> Fable.Core.RustInterop.emitRustExpr x "$0 }") // 2
    let v107 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v107 
    let v108 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v108 
    let v109 : string = "true; // ??? / i: 3uy / i': 1uy / acc: 3uy / n: 2uy"
    let v110 : bool = Fable.Core.RustInterop.emitRustExpr () v109 
    let v111 : string = "true; */ // ???? / i: 3uy / i': 2uy / acc: 3uy / n: 2uy"
    let v112 : bool = Fable.Core.RustInterop.emitRustExpr () v111 
    let v113 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v113 
    let v114 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v114 
    let v115 : string = "#[result_serializer(borsh)] //"
    Fable.Core.RustInterop.emitRustExpr () v115 
    let v116 : string = "pub fn generate_cid_borsh( //"
    Fable.Core.RustInterop.emitRustExpr () v116 
    let v117 : string = "  &self, //"
    Fable.Core.RustInterop.emitRustExpr () v117 
    let v118 : string = "  #[serializer(borsh)] content: Vec<u8>, //"
    Fable.Core.RustInterop.emitRustExpr () v118 
    let v119 : string = ") -> String { //"
    Fable.Core.RustInterop.emitRustExpr () v119 
    let v120 : string = "  self.generate_cid(content) //"
    Fable.Core.RustInterop.emitRustExpr () v120 
    let v121 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v121 
    let v122 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v122 
    let v123 : string = "true; // ??? / i: 4uy / i': 1uy / acc: 5uy / n: 1uy"
    let v124 : bool = Fable.Core.RustInterop.emitRustExpr () v123 
    let v125 : string = "true; */ // ???? / i: 4uy / i': 2uy / acc: 5uy / n: 1uy"
    let v126 : bool = Fable.Core.RustInterop.emitRustExpr () v125 
    let v127 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v127 
    let v128 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v128 
    let v129 : string = "pub fn claim_alias( //"
    Fable.Core.RustInterop.emitRustExpr () v129 
    let v130 : string = "  &mut self, //"
    Fable.Core.RustInterop.emitRustExpr () v130 
    let v131 : string = "  alias: String, //"
    Fable.Core.RustInterop.emitRustExpr () v131 
    let v132 : string = ") { //"
    Fable.Core.RustInterop.emitRustExpr () v132 
    let v133 : string = $"&mut self.0"
    let v134 : Ref<Mut<struct (uint32 * near_sdk_store_LookupMap<std_string_String, std_collections_HashMap<near_sdk_AccountId, struct (uint64 * uint32)>> * near_sdk_store_LookupMap<near_sdk_AccountId, std_string_String>)>> = Fable.Core.RustInterop.emitRustExpr () v133 
    let v135 : string = $"alias"
    let v136 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v135 
    let v137 : string = $"&mut v134.2"
    let v138 : Ref<Mut<near_sdk_store_LookupMap<near_sdk_AccountId, std_string_String>>> = Fable.Core.RustInterop.emitRustExpr () v137 
    let v139 : string = $"&mut v134.1"
    let v140 : Ref<Mut<near_sdk_store_LookupMap<std_string_String, std_collections_HashMap<near_sdk_AccountId, struct (uint64 * uint32)>>>> = Fable.Core.RustInterop.emitRustExpr () v139 
    let v141 : string = $"near_sdk::env::signer_account_id()"
    let v142 : near_sdk_AccountId = Fable.Core.RustInterop.emitRustExpr () v141 
    let v143 : string = $"near_sdk::env::block_timestamp()"
    let v144 : uint64 = Fable.Core.RustInterop.emitRustExpr () v143 
    let v145 : unit = ()
    let v146 : (unit -> unit) = closure2(v136, v142, v144)
    let v147 : unit = (fun () -> v146 (); v145) ()
    let v265 : string = "fable_library_rust::String_::fromString($0)"
    let v266 : string = Fable.Core.RustInterop.emitRustExpr v136 v265 
    let v267 : int32 = v266.Length
    let v268 : bool = v267 > 0
    let v290 : bool =
        if v268 then
            let v269 : bool = v267 < 64
            if v269 then
                let v270 : string = "-"
                let v271 : bool = v266.StartsWith v270 
                let v274 : bool = v271 = false
                if v274 then
                    let v275 : bool = v266.EndsWith v270 
                    let v276 : bool = v275 = false
                    if v276 then
                        let v277 : string = "&*$0"
                        let v278 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v266 v277 
                        let v279 : string = $"$0.chars()"
                        let v280 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v278 v279 
                        let v281 : string = "true; // 1"
                        let v282 : bool = Fable.Core.RustInterop.emitRustExpr () v281 
                        let v283 : string = "let mut v280 = v280"
                        Fable.Core.RustInterop.emitRustExpr () v283 
                        let v284 : string = $"v280.all(|x| $0(x))"
                        let v285 : (char -> bool) = closure1()
                        let v286 : bool = Fable.Core.RustInterop.emitRustExpr v285 v284 
                        v286
                    else
                        false
                else
                    false
            else
                false
        else
            false
    let v291 : bool = v290 = false
    let v295 : bool =
        if v291 then
            let v292 : string = $"true; near_sdk::env::panic_str(&*$0); //"
            let v293 : string = "chat_contract.claim_alias / invalid alias"
            let v294 : bool = Fable.Core.RustInterop.emitRustExpr v293 v292 
            true
        else
            false
    let v296 : string = $"v138.get(&$0)"
    let v297 : Ref<std_string_String> option = Fable.Core.RustInterop.emitRustExpr v142 v296 
    let v298 : string = "$0.cloned()"
    let v299 : std_string_String option = Fable.Core.RustInterop.emitRustExpr v297 v298 
    let v300 : (std_string_String -> US4) = method16()
    let v301 : US4 option = v299 |> Option.map v300 
    let v312 : US4 = US4_1
    let v313 : US4 = v301 |> Option.defaultValue v312 
    match v313 with
    | US4_0(v317) -> (* Some *)
        let v318 : bool = v317 = v136 
        if v318 then
            let v321 : unit = ()
            let v322 : (unit -> unit) = closure12(v317)
            let v323 : unit = (fun () -> v322 (); v321) ()
            ()
        else
            let v442 : unit = ()
            let v443 : (unit -> unit) = closure13(v299)
            let v444 : unit = (fun () -> v443 (); v442) ()
            let v563 : string = "    v140 //"
            Fable.Core.RustInterop.emitRustExpr () v563 
            let v564 : string = "      .get_mut(&v317) //"
            Fable.Core.RustInterop.emitRustExpr () v564 
            let v565 : string = "      .unwrap() //"
            Fable.Core.RustInterop.emitRustExpr () v565 
            let v566 : string = "      .remove(&$0); //"
            Fable.Core.RustInterop.emitRustExpr v142 v566 
            let v567 : string = "  v138.insert($0.clone(), v136.clone()); //"
            Fable.Core.RustInterop.emitRustExpr v142 v567 
            let v568 : string = "  let new_alias_account_map = match v140.get(&v136) { //"
            Fable.Core.RustInterop.emitRustExpr () v568 
            let v569 : string = "    None => { //"
            Fable.Core.RustInterop.emitRustExpr () v569 
            let v570 : string = "      let mut new_map = std::collections::HashMap::new(); //"
            Fable.Core.RustInterop.emitRustExpr () v570 
            let v571 : string = "      new_map.insert($0, ($1, 0u32)); //"
            Fable.Core.RustInterop.emitRustExpr struct (v142, v144) v571 
            let v572 : string = "      new_map //"
            Fable.Core.RustInterop.emitRustExpr () v572 
            let v573 : string = "    } //"
            Fable.Core.RustInterop.emitRustExpr () v573 
            let v574 : string = "    Some(accounts) => { //"
            Fable.Core.RustInterop.emitRustExpr () v574 
            let v575 : string = "      let mut accounts_vec = accounts.iter().collect::<Vec<_>>(); //"
            Fable.Core.RustInterop.emitRustExpr () v575 
            let v576 : string = "      accounts_vec.sort_unstable_by_key(|(_, (_, index))| index); //"
            Fable.Core.RustInterop.emitRustExpr () v576 
            let v577 : string = "      let mut new_map = accounts_vec //"
            Fable.Core.RustInterop.emitRustExpr () v577 
            let v578 : string = "        .iter() //"
            Fable.Core.RustInterop.emitRustExpr () v578 
            let v579 : string = "        .enumerate() //"
            Fable.Core.RustInterop.emitRustExpr () v579 
            let v580 : string = "        .map(|(i, (account_id, (timestamp, _)))| { //"
            Fable.Core.RustInterop.emitRustExpr () v580 
            let v581 : string = "          ((*account_id).clone(), (*timestamp, i as u32)) //"
            Fable.Core.RustInterop.emitRustExpr () v581 
            let v582 : string = "        }) //"
            Fable.Core.RustInterop.emitRustExpr () v582 
            let v583 : string = "        .collect::<std::collections::HashMap<_, _>>(); //"
            Fable.Core.RustInterop.emitRustExpr () v583 
            let v584 : string = "      new_map.insert(v142, (v144, accounts_vec.len() as u32)); //"
            Fable.Core.RustInterop.emitRustExpr () v584 
            let v585 : string = "      new_map //"
            Fable.Core.RustInterop.emitRustExpr () v585 
            let v586 : string = "    } //"
            Fable.Core.RustInterop.emitRustExpr () v586 
            let v587 : string = "  }; //"
            Fable.Core.RustInterop.emitRustExpr () v587 
            let v588 : string = "  v140.insert(v136, new_alias_account_map); //"
            Fable.Core.RustInterop.emitRustExpr () v588 
            ()
    | _ ->
        let v589 : unit = ()
        let v590 : (unit -> unit) = closure13(v299)
        let v591 : unit = (fun () -> v590 (); v589) ()
        match v313 with
        | US4_1 -> (* None *)
            ()
        let v710 : string = "  v138.insert($0.clone(), v136.clone()); //"
        Fable.Core.RustInterop.emitRustExpr v142 v710 
        let v711 : string = "  let new_alias_account_map = match v140.get(&v136) { //"
        Fable.Core.RustInterop.emitRustExpr () v711 
        let v712 : string = "    None => { //"
        Fable.Core.RustInterop.emitRustExpr () v712 
        let v713 : string = "      let mut new_map = std::collections::HashMap::new(); //"
        Fable.Core.RustInterop.emitRustExpr () v713 
        let v714 : string = "      new_map.insert($0, ($1, 0u32)); //"
        Fable.Core.RustInterop.emitRustExpr struct (v142, v144) v714 
        let v715 : string = "      new_map //"
        Fable.Core.RustInterop.emitRustExpr () v715 
        let v716 : string = "    } //"
        Fable.Core.RustInterop.emitRustExpr () v716 
        let v717 : string = "    Some(accounts) => { //"
        Fable.Core.RustInterop.emitRustExpr () v717 
        let v718 : string = "      let mut accounts_vec = accounts.iter().collect::<Vec<_>>(); //"
        Fable.Core.RustInterop.emitRustExpr () v718 
        let v719 : string = "      accounts_vec.sort_unstable_by_key(|(_, (_, index))| index); //"
        Fable.Core.RustInterop.emitRustExpr () v719 
        let v720 : string = "      let mut new_map = accounts_vec //"
        Fable.Core.RustInterop.emitRustExpr () v720 
        let v721 : string = "        .iter() //"
        Fable.Core.RustInterop.emitRustExpr () v721 
        let v722 : string = "        .enumerate() //"
        Fable.Core.RustInterop.emitRustExpr () v722 
        let v723 : string = "        .map(|(i, (account_id, (timestamp, _)))| { //"
        Fable.Core.RustInterop.emitRustExpr () v723 
        let v724 : string = "          ((*account_id).clone(), (*timestamp, i as u32)) //"
        Fable.Core.RustInterop.emitRustExpr () v724 
        let v725 : string = "        }) //"
        Fable.Core.RustInterop.emitRustExpr () v725 
        let v726 : string = "        .collect::<std::collections::HashMap<_, _>>(); //"
        Fable.Core.RustInterop.emitRustExpr () v726 
        let v727 : string = "      new_map.insert(v142, (v144, accounts_vec.len() as u32)); //"
        Fable.Core.RustInterop.emitRustExpr () v727 
        let v728 : string = "      new_map //"
        Fable.Core.RustInterop.emitRustExpr () v728 
        let v729 : string = "    } //"
        Fable.Core.RustInterop.emitRustExpr () v729 
        let v730 : string = "  }; //"
        Fable.Core.RustInterop.emitRustExpr () v730 
        let v731 : string = "  v140.insert(v136, new_alias_account_map); //"
        Fable.Core.RustInterop.emitRustExpr () v731 
        ()
    let v732 : (unit -> unit) = method19()
    let v733 : unit = ()
    let v734 : (unit -> unit) = closure15(v732)
    let v735 : unit = (fun () -> v734 (); v733) ()
    let v844 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v844 
    let v845 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v845 
    let v846 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v846 
    let v847 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v847 
    let v848 : string = "true; // ??? / i: 5uy / i': 1uy / acc: 6uy / n: 3uy"
    let v849 : bool = Fable.Core.RustInterop.emitRustExpr () v848 
    let v850 : string = "true; */ // ???? / i: 5uy / i': 2uy / acc: 6uy / n: 3uy"
    let v851 : bool = Fable.Core.RustInterop.emitRustExpr () v850 
    let v852 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v852 
    let v853 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v853 
    let v854 : string = "pub fn get_account_info( //"
    Fable.Core.RustInterop.emitRustExpr () v854 
    let v855 : string = "  &self, //"
    Fable.Core.RustInterop.emitRustExpr () v855 
    let v856 : string = "  account_id: near_sdk::AccountId, //"
    Fable.Core.RustInterop.emitRustExpr () v856 
    let v857 : string = ") -> Option<(String, u64, u32)> { //"
    Fable.Core.RustInterop.emitRustExpr () v857 
    let v858 : string = $"&self.0"
    let v859 : Ref<struct (uint32 * near_sdk_store_LookupMap<std_string_String, std_collections_HashMap<near_sdk_AccountId, struct (uint64 * uint32)>> * near_sdk_store_LookupMap<near_sdk_AccountId, std_string_String>)> = Fable.Core.RustInterop.emitRustExpr () v858 
    let v860 : string = $"account_id"
    let v861 : near_sdk_AccountId = Fable.Core.RustInterop.emitRustExpr () v860 
    let v862 : string = $"&v859.2"
    let v863 : Ref<near_sdk_store_LookupMap<near_sdk_AccountId, std_string_String>> = Fable.Core.RustInterop.emitRustExpr () v862 
    let v864 : string = $"&v859.1"
    let v865 : Ref<near_sdk_store_LookupMap<std_string_String, std_collections_HashMap<near_sdk_AccountId, struct (uint64 * uint32)>>> = Fable.Core.RustInterop.emitRustExpr () v864 
    let v866 : string = "let result = v863.get(&$0).and_then(|alias| { //"
    Fable.Core.RustInterop.emitRustExpr v861 v866 
    let v867 : string = "    v865 //"
    Fable.Core.RustInterop.emitRustExpr () v867 
    let v868 : string = "      .get(alias) //"
    Fable.Core.RustInterop.emitRustExpr () v868 
    let v869 : string = "      .map(|accounts| { //"
    Fable.Core.RustInterop.emitRustExpr () v869 
    let v870 : string = "          let result = (alias.clone(), *accounts.get(&v861).unwrap()); //"
    Fable.Core.RustInterop.emitRustExpr () v870 
    let v871 : string = "          (result.0, result.1.0, result.1.1) //"
    Fable.Core.RustInterop.emitRustExpr () v871 
    let v872 : string = "      }) //"
    Fable.Core.RustInterop.emitRustExpr () v872 
    let v873 : string = "}); //"
    Fable.Core.RustInterop.emitRustExpr () v873 
    let v874 : string = "result"
    let v875 : struct (std_string_String * uint64 * uint32) option = Fable.Core.RustInterop.emitRustExpr () v874 
    let v876 : unit = ()
    let v877 : (unit -> unit) = closure16(v861, v875)
    let v878 : unit = (fun () -> v877 (); v876) ()
    let v994 : unit = ()
    let v995 : (unit -> unit) = closure17()
    let v996 : unit = (fun () -> v995 (); v994) ()
    let _result = v875 in _result |> (fun x -> Fable.Core.RustInterop.emitRustExpr x "$0 } // 4") // 3
    let v1105 : string = "} // 2"
    Fable.Core.RustInterop.emitRustExpr () v1105 
    let v1106 : string = "} // 1"
    Fable.Core.RustInterop.emitRustExpr () v1106 
    let v1107 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v1107 
    let v1108 : string = "true; // ??? / i: 6uy / i': 1uy / acc: 9uy / n: 2uy"
    let v1109 : bool = Fable.Core.RustInterop.emitRustExpr () v1108 
    let v1110 : string = "true; */ // ???? / i: 6uy / i': 2uy / acc: 9uy / n: 2uy"
    let v1111 : bool = Fable.Core.RustInterop.emitRustExpr () v1110 
    let v1112 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v1112 
    let v1113 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v1113 
    let v1114 : string = "pub fn get_alias_map( //"
    Fable.Core.RustInterop.emitRustExpr () v1114 
    let v1115 : string = "  &self, //"
    Fable.Core.RustInterop.emitRustExpr () v1115 
    let v1116 : string = "  alias: String, //"
    Fable.Core.RustInterop.emitRustExpr () v1116 
    let v1117 : string = ") -> Option<std::collections::HashMap<near_sdk::AccountId, (u64, u32)>> { //"
    Fable.Core.RustInterop.emitRustExpr () v1117 
    let v1118 : string = $"&self.0.1"
    let v1119 : Ref<near_sdk_store_LookupMap<std_string_String, std_collections_HashMap<near_sdk_AccountId, struct (uint64 * uint32)>>> = Fable.Core.RustInterop.emitRustExpr () v1118 
    let v1120 : string = $"alias"
    let v1121 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v1120 
    let v1122 : unit = ()
    let v1123 : (unit -> unit) = closure18(v1121)
    let v1124 : unit = (fun () -> v1123 (); v1122) ()
    let v1240 : (unit -> unit) = method23()
    let v1241 : unit = ()
    let v1242 : (unit -> unit) = closure19(v1240)
    let v1243 : unit = (fun () -> v1242 (); v1241) ()
    let v1352 : string = "  v1119.get(&$0).cloned() //"
    Fable.Core.RustInterop.emitRustExpr v1121 v1352 
    let v1353 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v1353 
    let v1354 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v1354 
    let v1355 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v1355 
    let v1356 : string = "true; // ??? / i: 7uy / i': 1uy / acc: 11uy / n: 2uy"
    let v1357 : bool = Fable.Core.RustInterop.emitRustExpr () v1356 
    let v1358 : string = "true; */ // ???? / i: 7uy / i': 2uy / acc: 11uy / n: 2uy"
    let v1359 : bool = Fable.Core.RustInterop.emitRustExpr () v1358 
    let v1360 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v1360 
    let v1361 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v1361 
    let v1362 : string = "#[result_serializer(borsh)] //"
    Fable.Core.RustInterop.emitRustExpr () v1362 
    let v1363 : string = "pub fn get_alias_map_borsh( //"
    Fable.Core.RustInterop.emitRustExpr () v1363 
    let v1364 : string = "  &self, //"
    Fable.Core.RustInterop.emitRustExpr () v1364 
    let v1365 : string = "  #[serializer(borsh)] alias: String, //"
    Fable.Core.RustInterop.emitRustExpr () v1365 
    let v1366 : string = ") -> Option<std::collections::HashMap<near_sdk::AccountId, (u64, u32)>> { //"
    Fable.Core.RustInterop.emitRustExpr () v1366 
    let v1367 : string = "  self.get_alias_map(alias) //"
    Fable.Core.RustInterop.emitRustExpr () v1367 
    let v1368 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v1368 
    let v1369 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v1369 
    let v1370 : string = "true; // ??? / i: 8uy / i': 1uy / acc: 13uy / n: 1uy"
    let v1371 : bool = Fable.Core.RustInterop.emitRustExpr () v1370 
    let v1372 : string = "true; */ // ???? / i: 8uy / i': 2uy / acc: 13uy / n: 1uy"
    let v1373 : bool = Fable.Core.RustInterop.emitRustExpr () v1372 
    let v1374 : string = "fn _main() //"
    Fable.Core.RustInterop.emitRustExpr () v1374 
    let v1375 : string = "{ { //"
    Fable.Core.RustInterop.emitRustExpr () v1375 
    let v1376 : string = "true; { (); // ?? / i': 1uy / n: 14uy"
    let v1377 : bool = Fable.Core.RustInterop.emitRustExpr () v1376 
    let v1378 : string = "true; { (); // ?? / i': 2uy / n: 14uy"
    let v1379 : bool = Fable.Core.RustInterop.emitRustExpr () v1378 
    let v1380 : string = "true; { (); // ?? / i': 3uy / n: 14uy"
    let v1381 : bool = Fable.Core.RustInterop.emitRustExpr () v1380 
    let v1382 : string = "true; { (); // ?? / i': 4uy / n: 14uy"
    let v1383 : bool = Fable.Core.RustInterop.emitRustExpr () v1382 
    let v1384 : string = "true; { (); // ?? / i': 5uy / n: 14uy"
    let v1385 : bool = Fable.Core.RustInterop.emitRustExpr () v1384 
    let v1386 : string = "true; { (); // ?? / i': 6uy / n: 14uy"
    let v1387 : bool = Fable.Core.RustInterop.emitRustExpr () v1386 
    let v1388 : string = "true; { (); // ?? / i': 7uy / n: 14uy"
    let v1389 : bool = Fable.Core.RustInterop.emitRustExpr () v1388 
    let v1390 : string = "true; { (); // ?? / i': 8uy / n: 14uy"
    let v1391 : bool = Fable.Core.RustInterop.emitRustExpr () v1390 
    let v1392 : string = "true; { (); // ?? / i': 9uy / n: 14uy"
    let v1393 : bool = Fable.Core.RustInterop.emitRustExpr () v1392 
    let v1394 : string = "true; { (); // ?? / i': 10uy / n: 14uy"
    let v1395 : bool = Fable.Core.RustInterop.emitRustExpr () v1394 
    let v1396 : string = "true; { (); // ?? / i': 11uy / n: 14uy"
    let v1397 : bool = Fable.Core.RustInterop.emitRustExpr () v1396 
    let v1398 : string = "true; { (); // ?? / i': 12uy / n: 14uy"
    let v1399 : bool = Fable.Core.RustInterop.emitRustExpr () v1398 
    let v1400 : string = "true; { (); // ?? / i': 13uy / n: 14uy"
    let v1401 : bool = Fable.Core.RustInterop.emitRustExpr () v1400 
    let v1402 : string = "true; { (); // ?? / i': 14uy / n: 14uy"
    let v1403 : bool = Fable.Core.RustInterop.emitRustExpr () v1402 
    let v1404 : string = "true; { { (); // ? / i': 15uy / n: 14uy"
    let v1405 : bool = Fable.Core.RustInterop.emitRustExpr () v1404 
    ()
let v0 : (unit -> unit) = closure0()
v0 |> ignore
()
