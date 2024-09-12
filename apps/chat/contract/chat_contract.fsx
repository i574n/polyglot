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
and closure4 (v0 : US1 option ref) (v1 : US1 option) : US1 option ref =
    v0.Value <- v1 
    v0
and closure5 (v0 : string option, v1 : (US1 option -> US1 option ref)) () : unit =
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
    let v66 : (US1 option -> US1 option ref) = closure4(v65)
    let v67 : unit = ()
    let v68 : (unit -> unit) = closure5(v61, v66)
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
    let v101 : (US1 option -> US1 option ref) = closure4(v100)
    let v102 : unit = ()
    let v103 : (unit -> unit) = closure5(v96, v101)
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
and closure6 () (v0 : string) : unit =
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
    let v360 : (string -> unit) = closure6()
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
and closure2 (v0 : std_string_String, v1 : near_sdk_AccountId, v2 : uint64) () : unit =
    let v3 : unit = ()
    let v4 : (unit -> unit) = closure3()
    let v5 : unit = (fun () -> v4 (); v3) ()
    let struct (v19 : Mut0, v20 : Mut1, v21 : Mut2, v22 : Mut3, v23 : Mut4, v24 : int64 option) = TraceState.trace_state.Value
    let v37 : unit = ()
    let v38 : unit = (fun () -> v4 (); v37) ()
    let struct (v52 : Mut0, v53 : Mut1, v54 : Mut2, v55 : Mut3, v56 : Mut4, v57 : int64 option) = TraceState.trace_state.Value
    let v70 : US0 = v56.l0
    let v71 : bool = v54.l0
    let v72 : bool = v71 = false
    let v75 : bool =
        if v72 then
            false
        else
            let v73 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v70
            let v74 : bool = 1 >= v73
            v74
    if v75 then
        let v76 : unit = ()
        let v77 : (unit -> unit) = closure7(v19)
        let v78 : unit = (fun () -> v77 (); v76) ()
        let v81 : unit = ()
        let v82 : unit = (fun () -> v4 (); v81) ()
        let struct (v96 : Mut0, v97 : Mut1, v98 : Mut2, v99 : Mut3, v100 : Mut4, v101 : int64 option) = TraceState.trace_state.Value
        let v114 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v115 : US3 option = None
        let _v115 = ref v115 
        let v116 : US3 option ref = _v115 
        let v117 : (US3 option -> US3 option ref) = closure8(v116)
        let v118 : unit = ()
        let v119 : (unit -> unit) = closure9(v101, v117)
        let v120 : unit = (fun () -> v119 (); v118) ()
        let v123 : US3 option = _v115.Value 
        let v134 : US3 = US3_1
        let v135 : US3 = v123 |> Option.defaultValue v134 
        let v175 : System.DateTime =
            match v135 with
            | US3_1 -> (* None *)
                let v171 : System.DateTime = System.DateTime.Now
                v171
            | US3_0(v139) -> (* Some *)
                let v140 : System.DateTime = System.DateTime.Now
                let v143 : (System.DateTime -> int64) = _.Ticks
                let v144 : int64 = v143 v140
                let v147 : int64 = v144 - v139
                let v148 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v149 : System.TimeSpan = v148 v147
                let v152 : (System.TimeSpan -> int32) = _.Hours
                let v153 : int32 = v152 v149
                let v156 : (System.TimeSpan -> int32) = _.Minutes
                let v157 : int32 = v156 v149
                let v160 : (System.TimeSpan -> int32) = _.Seconds
                let v161 : int32 = v160 v149
                let v164 : (System.TimeSpan -> int32) = _.Milliseconds
                let v165 : int32 = v164 v149
                let v168 : System.DateTime = System.DateTime (1, 1, 1, v153, v157, v161, v165)
                v168
        let v176 : string = method5()
        let v179 : (string -> string) = v175.ToString
        let v180 : string = v179 v176
        let _v114 = v180 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v183 : US3 option = None
        let _v183 = ref v183 
        let v184 : US3 option ref = _v183 
        let v185 : (US3 option -> US3 option ref) = closure8(v184)
        let v186 : unit = ()
        let v187 : (unit -> unit) = closure9(v101, v185)
        let v188 : unit = (fun () -> v187 (); v186) ()
        let v191 : US3 option = _v183.Value 
        let v202 : US3 = US3_1
        let v203 : US3 = v191 |> Option.defaultValue v202 
        let v243 : System.DateTime =
            match v203 with
            | US3_1 -> (* None *)
                let v239 : System.DateTime = System.DateTime.Now
                v239
            | US3_0(v207) -> (* Some *)
                let v208 : System.DateTime = System.DateTime.Now
                let v211 : (System.DateTime -> int64) = _.Ticks
                let v212 : int64 = v211 v208
                let v215 : int64 = v212 - v207
                let v216 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v217 : System.TimeSpan = v216 v215
                let v220 : (System.TimeSpan -> int32) = _.Hours
                let v221 : int32 = v220 v217
                let v224 : (System.TimeSpan -> int32) = _.Minutes
                let v225 : int32 = v224 v217
                let v228 : (System.TimeSpan -> int32) = _.Seconds
                let v229 : int32 = v228 v217
                let v232 : (System.TimeSpan -> int32) = _.Milliseconds
                let v233 : int32 = v232 v217
                let v236 : System.DateTime = System.DateTime (1, 1, 1, v221, v225, v229, v233)
                v236
        let v244 : string = method5()
        let v247 : (string -> string) = v243.ToString
        let v248 : string = v247 v244
        let _v114 = v248 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v251 : string = $"near_sdk::env::block_timestamp()"
        let v252 : uint64 = Fable.Core.RustInterop.emitRustExpr () v251 
        let v253 : US3 option = None
        let _v253 = ref v253 
        let v254 : US3 option ref = _v253 
        let v255 : (US3 option -> US3 option ref) = closure8(v254)
        let v256 : unit = ()
        let v257 : (unit -> unit) = closure9(v101, v255)
        let v258 : unit = (fun () -> v257 (); v256) ()
        let v261 : US3 option = _v253.Value 
        let v272 : US3 = US3_1
        let v273 : US3 = v261 |> Option.defaultValue v272 
        let v282 : uint64 =
            match v273 with
            | US3_1 -> (* None *)
                v252
            | US3_0(v277) -> (* Some *)
                let v278 : (int64 -> uint64) = uint64
                let v279 : uint64 = v278 v277
                let v280 : uint64 = v252 - v279
                v280
        let v283 : uint64 = v282 / 1000000000UL
        let v284 : uint64 = v283 % 60UL
        let v285 : uint64 = v283 / 60UL
        let v286 : uint64 = v285 % 60UL
        let v287 : uint64 = v283 / 3600UL
        let v288 : uint64 = v287 % 24UL
        let v289 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
        let v290 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v288, v286, v284) v289 
        let v291 : string = "fable_library_rust::String_::fromString($0)"
        let v292 : string = Fable.Core.RustInterop.emitRustExpr v290 v291 
        let _v114 = v292 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v293 : US3 option = None
        let _v293 = ref v293 
        let v294 : US3 option ref = _v293 
        let v295 : (US3 option -> US3 option ref) = closure8(v294)
        let v296 : unit = ()
        let v297 : (unit -> unit) = closure9(v101, v295)
        let v298 : unit = (fun () -> v297 (); v296) ()
        let v301 : US3 option = _v293.Value 
        let v312 : US3 = US3_1
        let v313 : US3 = v301 |> Option.defaultValue v312 
        let v353 : System.DateTime =
            match v313 with
            | US3_1 -> (* None *)
                let v349 : System.DateTime = System.DateTime.Now
                v349
            | US3_0(v317) -> (* Some *)
                let v318 : System.DateTime = System.DateTime.Now
                let v321 : (System.DateTime -> int64) = _.Ticks
                let v322 : int64 = v321 v318
                let v325 : int64 = v322 - v317
                let v326 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v327 : System.TimeSpan = v326 v325
                let v330 : (System.TimeSpan -> int32) = _.Hours
                let v331 : int32 = v330 v327
                let v334 : (System.TimeSpan -> int32) = _.Minutes
                let v335 : int32 = v334 v327
                let v338 : (System.TimeSpan -> int32) = _.Seconds
                let v339 : int32 = v338 v327
                let v342 : (System.TimeSpan -> int32) = _.Milliseconds
                let v343 : int32 = v342 v327
                let v346 : System.DateTime = System.DateTime (1, 1, 1, v331, v335, v339, v343)
                v346
        let v354 : string = method6()
        let v357 : (string -> string) = v353.ToString
        let v358 : string = v357 v354
        let _v114 = v358 
        #endif
#if FABLE_COMPILER_PYTHON
        let v361 : US3 option = None
        let _v361 = ref v361 
        let v362 : US3 option ref = _v361 
        let v363 : (US3 option -> US3 option ref) = closure8(v362)
        let v364 : unit = ()
        let v365 : (unit -> unit) = closure9(v101, v363)
        let v366 : unit = (fun () -> v365 (); v364) ()
        let v369 : US3 option = _v361.Value 
        let v380 : US3 = US3_1
        let v381 : US3 = v369 |> Option.defaultValue v380 
        let v421 : System.DateTime =
            match v381 with
            | US3_1 -> (* None *)
                let v417 : System.DateTime = System.DateTime.Now
                v417
            | US3_0(v385) -> (* Some *)
                let v386 : System.DateTime = System.DateTime.Now
                let v389 : (System.DateTime -> int64) = _.Ticks
                let v390 : int64 = v389 v386
                let v393 : int64 = v390 - v385
                let v394 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v395 : System.TimeSpan = v394 v393
                let v398 : (System.TimeSpan -> int32) = _.Hours
                let v399 : int32 = v398 v395
                let v402 : (System.TimeSpan -> int32) = _.Minutes
                let v403 : int32 = v402 v395
                let v406 : (System.TimeSpan -> int32) = _.Seconds
                let v407 : int32 = v406 v395
                let v410 : (System.TimeSpan -> int32) = _.Milliseconds
                let v411 : int32 = v410 v395
                let v414 : System.DateTime = System.DateTime (1, 1, 1, v399, v403, v407, v411)
                v414
        let v422 : string = method6()
        let v425 : (string -> string) = v421.ToString
        let v426 : string = v425 v422
        let _v114 = v426 
        #endif
#else
        let v429 : US3 option = None
        let _v429 = ref v429 
        let v430 : US3 option ref = _v429 
        let v431 : (US3 option -> US3 option ref) = closure8(v430)
        let v432 : unit = ()
        let v433 : (unit -> unit) = closure9(v101, v431)
        let v434 : unit = (fun () -> v433 (); v432) ()
        let v437 : US3 option = _v429.Value 
        let v448 : US3 = US3_1
        let v449 : US3 = v437 |> Option.defaultValue v448 
        let v489 : System.DateTime =
            match v449 with
            | US3_1 -> (* None *)
                let v485 : System.DateTime = System.DateTime.Now
                v485
            | US3_0(v453) -> (* Some *)
                let v454 : System.DateTime = System.DateTime.Now
                let v457 : (System.DateTime -> int64) = _.Ticks
                let v458 : int64 = v457 v454
                let v461 : int64 = v458 - v453
                let v462 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v463 : System.TimeSpan = v462 v461
                let v466 : (System.TimeSpan -> int32) = _.Hours
                let v467 : int32 = v466 v463
                let v470 : (System.TimeSpan -> int32) = _.Minutes
                let v471 : int32 = v470 v463
                let v474 : (System.TimeSpan -> int32) = _.Seconds
                let v475 : int32 = v474 v463
                let v478 : (System.TimeSpan -> int32) = _.Milliseconds
                let v479 : int32 = v478 v463
                let v482 : System.DateTime = System.DateTime (1, 1, 1, v467, v471, v475, v479)
                v482
        let v490 : string = method6()
        let v493 : (string -> string) = v489.ToString
        let v494 : string = v493 v490
        let _v114 = v494 
        #endif
        let v497 : string = _v114 
        
        
        
        
        
        let v567 : string = "Debug"
        let v568 : (unit -> string) = v567.ToLower
        let v569 : string = v568 ()
        let v572 : string = v569.PadLeft (7, ' ')
        let v586 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v587 : string = "inline_colorization::color_bright_blue"
        let v588 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v587 
        let v589 : string = "&*$0"
        let v590 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v572 v589 
        let v591 : string = "inline_colorization::color_reset"
        let v592 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v591 
        let v593 : string = "\"{v588}{v590}{v592}\""
        let v594 : string = @$"format!(" + v593 + ")"
        let v595 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v594 
        let v596 : string = "fable_library_rust::String_::fromString($0)"
        let v597 : string = Fable.Core.RustInterop.emitRustExpr v595 v596 
        let _v586 = v597 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v598 : string = "inline_colorization::color_bright_blue"
        let v599 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v598 
        let v600 : string = "&*$0"
        let v601 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v572 v600 
        let v602 : string = "inline_colorization::color_reset"
        let v603 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v602 
        let v604 : string = "\"{v599}{v601}{v603}\""
        let v605 : string = @$"format!(" + v604 + ")"
        let v606 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v605 
        let v607 : string = "fable_library_rust::String_::fromString($0)"
        let v608 : string = Fable.Core.RustInterop.emitRustExpr v606 v607 
        let _v586 = v608 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v609 : string = "inline_colorization::color_bright_blue"
        let v610 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v609 
        let v611 : string = "&*$0"
        let v612 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v572 v611 
        let v613 : string = "inline_colorization::color_reset"
        let v614 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v613 
        let v615 : string = "\"{v610}{v612}{v614}\""
        let v616 : string = @$"format!(" + v615 + ")"
        let v617 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v616 
        let v618 : string = "fable_library_rust::String_::fromString($0)"
        let v619 : string = Fable.Core.RustInterop.emitRustExpr v617 v618 
        let _v586 = v619 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v620 : string = "\u001b[94m"
        let v621 : string = method7()
        let v622 : string = v620 + v572 
        let v623 : string = v622 + v621 
        let _v586 = v623 
        #endif
#if FABLE_COMPILER_PYTHON
        let v624 : string = "\u001b[94m"
        let v625 : string = method7()
        let v626 : string = v624 + v572 
        let v627 : string = v626 + v625 
        let _v586 = v627 
        #endif
#else
        let v628 : string = "\u001b[94m"
        let v629 : string = method7()
        let v630 : string = v628 + v572 
        let v631 : string = v630 + v629 
        let _v586 = v631 
        #endif
        let v632 : string = _v586 
        let v638 : int64 = v96.l0
        let v639 : string = $"v1.to_string()"
        let v640 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v639 
        let v641 : string = method8()
        let v642 : Mut3 = {l0 = v641} : Mut3
        let v643 : string = "{ "
        let v644 : string = $"{v643}"
        let v647 : unit = ()
        let v648 : (unit -> unit) = closure10(v642, v644)
        let v649 : unit = (fun () -> v648 (); v647) ()
        let v652 : string = "alias"
        let v653 : string = $"{v652}"
        let v656 : unit = ()
        let v657 : (unit -> unit) = closure10(v642, v653)
        let v658 : unit = (fun () -> v657 (); v656) ()
        let v661 : string = " = "
        let v662 : string = $"{v661}"
        let v665 : unit = ()
        let v666 : (unit -> unit) = closure10(v642, v662)
        let v667 : unit = (fun () -> v666 (); v665) ()
        let v670 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v671 : string = "format!(\"{:#?}\", $0)"
        let v672 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v671 
        let v673 : string = "fable_library_rust::String_::fromString($0)"
        let v674 : string = Fable.Core.RustInterop.emitRustExpr v672 v673 
        let _v670 = v674 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v675 : string = "format!(\"{:#?}\", $0)"
        let v676 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v675 
        let v677 : string = "fable_library_rust::String_::fromString($0)"
        let v678 : string = Fable.Core.RustInterop.emitRustExpr v676 v677 
        let _v670 = v678 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v679 : string = "format!(\"{:#?}\", $0)"
        let v680 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v679 
        let v681 : string = "fable_library_rust::String_::fromString($0)"
        let v682 : string = Fable.Core.RustInterop.emitRustExpr v680 v681 
        let _v670 = v682 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v683 : string = $"%A{v0}"
        let _v670 = v683 
        #endif
#if FABLE_COMPILER_PYTHON
        let v686 : string = $"%A{v0}"
        let _v670 = v686 
        #endif
#else
        let v689 : string = $"%A{v0}"
        let _v670 = v689 
        #endif
        let v692 : string = _v670 
        let v697 : string = $"{v692}"
        let v700 : unit = ()
        let v701 : (unit -> unit) = closure10(v642, v697)
        let v702 : unit = (fun () -> v701 (); v700) ()
        let v705 : string = "; "
        let v706 : string = $"{v705}"
        let v709 : unit = ()
        let v710 : (unit -> unit) = closure10(v642, v706)
        let v711 : unit = (fun () -> v710 (); v709) ()
        let v714 : string = "block_timestamp"
        let v715 : string = $"{v714}"
        let v718 : unit = ()
        let v719 : (unit -> unit) = closure10(v642, v715)
        let v720 : unit = (fun () -> v719 (); v718) ()
        let v723 : string = $"{v661}"
        let v726 : unit = ()
        let v727 : (unit -> unit) = closure10(v642, v723)
        let v728 : unit = (fun () -> v727 (); v726) ()
        let v731 : string = $"{v2}"
        let v734 : unit = ()
        let v735 : (unit -> unit) = closure10(v642, v731)
        let v736 : unit = (fun () -> v735 (); v734) ()
        let v739 : string = $"{v705}"
        let v742 : unit = ()
        let v743 : (unit -> unit) = closure10(v642, v739)
        let v744 : unit = (fun () -> v743 (); v742) ()
        let v747 : string = "account_id"
        let v748 : string = $"{v747}"
        let v751 : unit = ()
        let v752 : (unit -> unit) = closure10(v642, v748)
        let v753 : unit = (fun () -> v752 (); v751) ()
        let v756 : string = $"{v661}"
        let v759 : unit = ()
        let v760 : (unit -> unit) = closure10(v642, v756)
        let v761 : unit = (fun () -> v760 (); v759) ()
        let v764 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v765 : string = "format!(\"{:#?}\", $0)"
        let v766 : std_string_String = Fable.Core.RustInterop.emitRustExpr v640 v765 
        let v767 : string = "fable_library_rust::String_::fromString($0)"
        let v768 : string = Fable.Core.RustInterop.emitRustExpr v766 v767 
        let _v764 = v768 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v769 : string = "format!(\"{:#?}\", $0)"
        let v770 : std_string_String = Fable.Core.RustInterop.emitRustExpr v640 v769 
        let v771 : string = "fable_library_rust::String_::fromString($0)"
        let v772 : string = Fable.Core.RustInterop.emitRustExpr v770 v771 
        let _v764 = v772 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v773 : string = "format!(\"{:#?}\", $0)"
        let v774 : std_string_String = Fable.Core.RustInterop.emitRustExpr v640 v773 
        let v775 : string = "fable_library_rust::String_::fromString($0)"
        let v776 : string = Fable.Core.RustInterop.emitRustExpr v774 v775 
        let _v764 = v776 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v777 : string = $"%A{v640}"
        let _v764 = v777 
        #endif
#if FABLE_COMPILER_PYTHON
        let v780 : string = $"%A{v640}"
        let _v764 = v780 
        #endif
#else
        let v783 : string = $"%A{v640}"
        let _v764 = v783 
        #endif
        let v786 : string = _v764 
        let v791 : string = $"{v786}"
        let v794 : unit = ()
        let v795 : (unit -> unit) = closure10(v642, v791)
        let v796 : unit = (fun () -> v795 (); v794) ()
        let v799 : string = " }"
        let v800 : string = $"{v799}"
        let v803 : unit = ()
        let v804 : (unit -> unit) = closure10(v642, v800)
        let v805 : unit = (fun () -> v804 (); v803) ()
        let v808 : string = v642.l0
        let v809 : string = $"chat_contract.claim_alias"
        let v810 : bool = v809 = ""
        let v867 : string =
            if v810 then
                let v811 : string = ""
                v811
            else
                let v812 : string = $"{v497} {v632} #{v638} %s{v809} / {v808}"
                let v815 : char list = []
                let v816 : (char list -> (char [])) = List.toArray
                let v817 : (char []) = v816 v815
                let v820 : string = v812.TrimStart v817 
                let v838 : char list = []
                let v839 : char list = '/' :: v838 
                let v842 : char list = ' ' :: v839 
                let v845 : (char list -> (char [])) = List.toArray
                let v846 : (char []) = v845 v842
                let v849 : string = v820.TrimEnd v846 
                v849
        let v868 : (string -> unit) = closure11()
        let v869 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v870 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v867 v870 
        let _v869 = () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v871 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v867 v871 
        let _v869 = () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v872 : string = v22.l0
        let v873 : bool = v872 = ""
        let v881 : string =
            if v873 then
                v867
            else
                let v874 : bool = v867 = ""
                if v874 then
                    let v875 : string = v22.l0
                    v875
                else
                    let v876 : string = v22.l0
                    let v877 : string = "\n"
                    let v878 : string = v876 + v877 
                    let v879 : string = v878 + v867 
                    v879
        let v882 : string = "&*$0"
        let v883 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v881 v882 
        let v884 : string = $"$0.chars()"
        let v885 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v883 v884 
        let v886 : string = "v885"
        let v887 : _ = Fable.Core.RustInterop.emitRustExpr () v886 
        let v888 : string = "v887.collect::<Vec<_>>()"
        let v889 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v888 
        let v890 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
        let v891 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v889 v890 
        let v892 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
        let v893 : bool = Fable.Core.RustInterop.emitRustExpr v891 v892 
        let v894 : string = "x"
        let v895 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v894 
        let v896 : string = "String::from_iter($0)"
        let v897 : std_string_String = Fable.Core.RustInterop.emitRustExpr v895 v896 
        let v898 : string = "true; $0 }).collect::<Vec<_>>()"
        let v899 : bool = Fable.Core.RustInterop.emitRustExpr v897 v898 
        let v900 : string = "_vec_map"
        let v901 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v900 
        let v902 : string = "$0.len()"
        let v903 : unativeint = Fable.Core.RustInterop.emitRustExpr v901 v902 
        let v904 : (unativeint -> int32) = int32
        let v905 : int32 = v904 v903
        let v906 : string = ""
        let v907 : bool = v867 <> v906 
        let v911 : bool =
            if v907 then
                let v910 : bool = v905 <= 1
                v910
            else
                false
        if v911 then
            v22.l0 <- v881
            ()
        else
            v22.l0 <- v906
            let v912 : string = "true; $0.into_iter().for_each(|x| { //"
            let v913 : bool = Fable.Core.RustInterop.emitRustExpr v901 v912 
            let v914 : string = "x"
            let v915 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v914 
            let v916 : string = $"near_sdk::log!(\"{{}}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v915 v916 
            let v917 : string = $"true;"
            let v918 : bool = Fable.Core.RustInterop.emitRustExpr () v917 
            let v919 : string = "true; }}); { //"
            let v920 : bool = Fable.Core.RustInterop.emitRustExpr () v919 
            ()
        let _v869 = () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        v868 v867
        let _v869 = () 
        #endif
#if FABLE_COMPILER_PYTHON
        v868 v867
        let _v869 = () 
        #endif
#else
        v868 v867
        let _v869 = () 
        #endif
        _v869 
        let v921 : (string -> unit) = v20.l0
        v921 v867
and closure13 (v0 : US4 option ref) (v1 : US4 option) : US4 option ref =
    v0.Value <- v1 
    v0
and closure14 (v0 : std_string_String option, v1 : (US4 option -> US4 option ref)) () : unit =
    match v0 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v2 : std_string_String = x
    let v3 : US4 = US4_0(v2)
    v3 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> v1 |> ignore
    ()
and closure15 (v0 : std_string_String) () : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure3()
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
            let v72 : bool = 3 >= v71
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
        
        
        
        
        
        let v565 : string = "Warning"
        let v566 : (unit -> string) = v565.ToLower
        let v567 : string = v566 ()
        let v570 : string = v567.PadLeft (7, ' ')
        let v584 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v585 : string = "inline_colorization::color_yellow"
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
        let v596 : string = "inline_colorization::color_yellow"
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
        let v607 : string = "inline_colorization::color_yellow"
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
        let v618 : string = "\u001b[93m"
        let v619 : string = method7()
        let v620 : string = v618 + v570 
        let v621 : string = v620 + v619 
        let _v584 = v621 
        #endif
#if FABLE_COMPILER_PYTHON
        let v622 : string = "\u001b[93m"
        let v623 : string = method7()
        let v624 : string = v622 + v570 
        let v625 : string = v624 + v623 
        let _v584 = v625 
        #endif
#else
        let v626 : string = "\u001b[93m"
        let v627 : string = method7()
        let v628 : string = v626 + v570 
        let v629 : string = v628 + v627 
        let _v584 = v629 
        #endif
        let v630 : string = _v584 
        let v636 : int64 = v94.l0
        let v637 : string = $"%A{v0}"
        let v640 : string = method8()
        let v641 : Mut3 = {l0 = v640} : Mut3
        let v642 : string = "{ "
        let v643 : string = $"{v642}"
        let v646 : unit = ()
        let v647 : (unit -> unit) = closure10(v641, v643)
        let v648 : unit = (fun () -> v647 (); v646) ()
        let v651 : string = "account_alias"
        let v652 : string = $"{v651}"
        let v655 : unit = ()
        let v656 : (unit -> unit) = closure10(v641, v652)
        let v657 : unit = (fun () -> v656 (); v655) ()
        let v660 : string = " = "
        let v661 : string = $"{v660}"
        let v664 : unit = ()
        let v665 : (unit -> unit) = closure10(v641, v661)
        let v666 : unit = (fun () -> v665 (); v664) ()
        let v669 : string = $"{v637}"
        let v672 : unit = ()
        let v673 : (unit -> unit) = closure10(v641, v669)
        let v674 : unit = (fun () -> v673 (); v672) ()
        let v677 : string = " }"
        let v678 : string = $"{v677}"
        let v681 : unit = ()
        let v682 : (unit -> unit) = closure10(v641, v678)
        let v683 : unit = (fun () -> v682 (); v681) ()
        let v686 : string = v641.l0
        let v687 : string = $"chat_contract.claim_alias / alias already claimed"
        let v688 : bool = v687 = ""
        let v745 : string =
            if v688 then
                let v689 : string = ""
                v689
            else
                let v690 : string = $"{v495} {v630} #{v636} %s{v687} / {v686}"
                let v693 : char list = []
                let v694 : (char list -> (char [])) = List.toArray
                let v695 : (char []) = v694 v693
                let v698 : string = v690.TrimStart v695 
                let v716 : char list = []
                let v717 : char list = '/' :: v716 
                let v720 : char list = ' ' :: v717 
                let v723 : (char list -> (char [])) = List.toArray
                let v724 : (char []) = v723 v720
                let v727 : string = v698.TrimEnd v724 
                v727
        let v746 : (string -> unit) = closure11()
        let v747 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v748 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v745 v748 
        let _v747 = () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v749 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v745 v749 
        let _v747 = () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v750 : string = v20.l0
        let v751 : bool = v750 = ""
        let v759 : string =
            if v751 then
                v745
            else
                let v752 : bool = v745 = ""
                if v752 then
                    let v753 : string = v20.l0
                    v753
                else
                    let v754 : string = v20.l0
                    let v755 : string = "\n"
                    let v756 : string = v754 + v755 
                    let v757 : string = v756 + v745 
                    v757
        let v760 : string = "&*$0"
        let v761 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v759 v760 
        let v762 : string = $"$0.chars()"
        let v763 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v761 v762 
        let v764 : string = "v763"
        let v765 : _ = Fable.Core.RustInterop.emitRustExpr () v764 
        let v766 : string = "v765.collect::<Vec<_>>()"
        let v767 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v766 
        let v768 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
        let v769 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v767 v768 
        let v770 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
        let v771 : bool = Fable.Core.RustInterop.emitRustExpr v769 v770 
        let v772 : string = "x"
        let v773 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v772 
        let v774 : string = "String::from_iter($0)"
        let v775 : std_string_String = Fable.Core.RustInterop.emitRustExpr v773 v774 
        let v776 : string = "true; $0 }).collect::<Vec<_>>()"
        let v777 : bool = Fable.Core.RustInterop.emitRustExpr v775 v776 
        let v778 : string = "_vec_map"
        let v779 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v778 
        let v780 : string = "$0.len()"
        let v781 : unativeint = Fable.Core.RustInterop.emitRustExpr v779 v780 
        let v782 : (unativeint -> int32) = int32
        let v783 : int32 = v782 v781
        let v784 : string = ""
        let v785 : bool = v745 <> v784 
        let v789 : bool =
            if v785 then
                let v788 : bool = v783 <= 1
                v788
            else
                false
        if v789 then
            v20.l0 <- v759
            ()
        else
            v20.l0 <- v784
            let v790 : string = "true; $0.into_iter().for_each(|x| { //"
            let v791 : bool = Fable.Core.RustInterop.emitRustExpr v779 v790 
            let v792 : string = "x"
            let v793 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v792 
            let v794 : string = $"near_sdk::log!(\"{{}}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v793 v794 
            let v795 : string = $"true;"
            let v796 : bool = Fable.Core.RustInterop.emitRustExpr () v795 
            let v797 : string = "true; }}); { //"
            let v798 : bool = Fable.Core.RustInterop.emitRustExpr () v797 
            ()
        let _v747 = () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        v746 v745
        let _v747 = () 
        #endif
#if FABLE_COMPILER_PYTHON
        v746 v745
        let _v747 = () 
        #endif
#else
        v746 v745
        let _v747 = () 
        #endif
        _v747 
        let v799 : (string -> unit) = v18.l0
        v799 v745
and closure16 (v0 : std_string_String option) () : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure3()
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
            let v72 : bool = 1 >= v71
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
        
        
        
        
        
        let v565 : string = "Debug"
        let v566 : (unit -> string) = v565.ToLower
        let v567 : string = v566 ()
        let v570 : string = v567.PadLeft (7, ' ')
        let v584 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v585 : string = "inline_colorization::color_bright_blue"
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
        let v596 : string = "inline_colorization::color_bright_blue"
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
        let v607 : string = "inline_colorization::color_bright_blue"
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
        let v618 : string = "\u001b[94m"
        let v619 : string = method7()
        let v620 : string = v618 + v570 
        let v621 : string = v620 + v619 
        let _v584 = v621 
        #endif
#if FABLE_COMPILER_PYTHON
        let v622 : string = "\u001b[94m"
        let v623 : string = method7()
        let v624 : string = v622 + v570 
        let v625 : string = v624 + v623 
        let _v584 = v625 
        #endif
#else
        let v626 : string = "\u001b[94m"
        let v627 : string = method7()
        let v628 : string = v626 + v570 
        let v629 : string = v628 + v627 
        let _v584 = v629 
        #endif
        let v630 : string = _v584 
        let v636 : int64 = v94.l0
        let v637 : string = $"%A{v0}"
        let v640 : string = method8()
        let v641 : Mut3 = {l0 = v640} : Mut3
        let v642 : string = "{ "
        let v643 : string = $"{v642}"
        let v646 : unit = ()
        let v647 : (unit -> unit) = closure10(v641, v643)
        let v648 : unit = (fun () -> v647 (); v646) ()
        let v651 : string = "account_alias"
        let v652 : string = $"{v651}"
        let v655 : unit = ()
        let v656 : (unit -> unit) = closure10(v641, v652)
        let v657 : unit = (fun () -> v656 (); v655) ()
        let v660 : string = " = "
        let v661 : string = $"{v660}"
        let v664 : unit = ()
        let v665 : (unit -> unit) = closure10(v641, v661)
        let v666 : unit = (fun () -> v665 (); v664) ()
        let v669 : string = $"{v637}"
        let v672 : unit = ()
        let v673 : (unit -> unit) = closure10(v641, v669)
        let v674 : unit = (fun () -> v673 (); v672) ()
        let v677 : string = " }"
        let v678 : string = $"{v677}"
        let v681 : unit = ()
        let v682 : (unit -> unit) = closure10(v641, v678)
        let v683 : unit = (fun () -> v682 (); v681) ()
        let v686 : string = v641.l0
        let v687 : string = $"chat_contract.claim_alias"
        let v688 : bool = v687 = ""
        let v745 : string =
            if v688 then
                let v689 : string = ""
                v689
            else
                let v690 : string = $"{v495} {v630} #{v636} %s{v687} / {v686}"
                let v693 : char list = []
                let v694 : (char list -> (char [])) = List.toArray
                let v695 : (char []) = v694 v693
                let v698 : string = v690.TrimStart v695 
                let v716 : char list = []
                let v717 : char list = '/' :: v716 
                let v720 : char list = ' ' :: v717 
                let v723 : (char list -> (char [])) = List.toArray
                let v724 : (char []) = v723 v720
                let v727 : string = v698.TrimEnd v724 
                v727
        let v746 : (string -> unit) = closure11()
        let v747 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v748 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v745 v748 
        let _v747 = () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v749 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v745 v749 
        let _v747 = () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v750 : string = v20.l0
        let v751 : bool = v750 = ""
        let v759 : string =
            if v751 then
                v745
            else
                let v752 : bool = v745 = ""
                if v752 then
                    let v753 : string = v20.l0
                    v753
                else
                    let v754 : string = v20.l0
                    let v755 : string = "\n"
                    let v756 : string = v754 + v755 
                    let v757 : string = v756 + v745 
                    v757
        let v760 : string = "&*$0"
        let v761 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v759 v760 
        let v762 : string = $"$0.chars()"
        let v763 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v761 v762 
        let v764 : string = "v763"
        let v765 : _ = Fable.Core.RustInterop.emitRustExpr () v764 
        let v766 : string = "v765.collect::<Vec<_>>()"
        let v767 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v766 
        let v768 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
        let v769 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v767 v768 
        let v770 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
        let v771 : bool = Fable.Core.RustInterop.emitRustExpr v769 v770 
        let v772 : string = "x"
        let v773 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v772 
        let v774 : string = "String::from_iter($0)"
        let v775 : std_string_String = Fable.Core.RustInterop.emitRustExpr v773 v774 
        let v776 : string = "true; $0 }).collect::<Vec<_>>()"
        let v777 : bool = Fable.Core.RustInterop.emitRustExpr v775 v776 
        let v778 : string = "_vec_map"
        let v779 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v778 
        let v780 : string = "$0.len()"
        let v781 : unativeint = Fable.Core.RustInterop.emitRustExpr v779 v780 
        let v782 : (unativeint -> int32) = int32
        let v783 : int32 = v782 v781
        let v784 : string = ""
        let v785 : bool = v745 <> v784 
        let v789 : bool =
            if v785 then
                let v788 : bool = v783 <= 1
                v788
            else
                false
        if v789 then
            v20.l0 <- v759
            ()
        else
            v20.l0 <- v784
            let v790 : string = "true; $0.into_iter().for_each(|x| { //"
            let v791 : bool = Fable.Core.RustInterop.emitRustExpr v779 v790 
            let v792 : string = "x"
            let v793 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v792 
            let v794 : string = $"near_sdk::log!(\"{{}}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v793 v794 
            let v795 : string = $"true;"
            let v796 : bool = Fable.Core.RustInterop.emitRustExpr () v795 
            let v797 : string = "true; }}); { //"
            let v798 : bool = Fable.Core.RustInterop.emitRustExpr () v797 
            ()
        let _v747 = () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        v746 v745
        let _v747 = () 
        #endif
#if FABLE_COMPILER_PYTHON
        v746 v745
        let _v747 = () 
        #endif
#else
        v746 v745
        let _v747 = () 
        #endif
        _v747 
        let v799 : (string -> unit) = v18.l0
        v799 v745
and closure17 () () : unit =
    let v0 : unit = ()
    let v1 : (unit -> unit) = closure3()
    let v2 : unit = (fun () -> v1 (); v0) ()
    let struct (v16 : Mut0, v17 : Mut1, v18 : Mut2, v19 : Mut3, v20 : Mut4, v21 : int64 option) = TraceState.trace_state.Value
    let v34 : unit = ()
    let v35 : unit = (fun () -> v1 (); v34) ()
    let struct (v49 : Mut0, v50 : Mut1, v51 : Mut2, v52 : Mut3, v53 : Mut4, v54 : int64 option) = TraceState.trace_state.Value
    let v67 : US0 = v53.l0
    let v68 : bool = v51.l0
    let v69 : bool = v68 = false
    let v72 : bool =
        if v69 then
            false
        else
            let v70 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v67
            let v71 : bool = 1 >= v70
            v71
    if v72 then
        let v73 : unit = ()
        let v74 : (unit -> unit) = closure7(v16)
        let v75 : unit = (fun () -> v74 (); v73) ()
        let v78 : unit = ()
        let v79 : unit = (fun () -> v1 (); v78) ()
        let struct (v93 : Mut0, v94 : Mut1, v95 : Mut2, v96 : Mut3, v97 : Mut4, v98 : int64 option) = TraceState.trace_state.Value
        let v111 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v112 : US3 option = None
        let _v112 = ref v112 
        let v113 : US3 option ref = _v112 
        let v114 : (US3 option -> US3 option ref) = closure8(v113)
        let v115 : unit = ()
        let v116 : (unit -> unit) = closure9(v98, v114)
        let v117 : unit = (fun () -> v116 (); v115) ()
        let v120 : US3 option = _v112.Value 
        let v131 : US3 = US3_1
        let v132 : US3 = v120 |> Option.defaultValue v131 
        let v172 : System.DateTime =
            match v132 with
            | US3_1 -> (* None *)
                let v168 : System.DateTime = System.DateTime.Now
                v168
            | US3_0(v136) -> (* Some *)
                let v137 : System.DateTime = System.DateTime.Now
                let v140 : (System.DateTime -> int64) = _.Ticks
                let v141 : int64 = v140 v137
                let v144 : int64 = v141 - v136
                let v145 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v146 : System.TimeSpan = v145 v144
                let v149 : (System.TimeSpan -> int32) = _.Hours
                let v150 : int32 = v149 v146
                let v153 : (System.TimeSpan -> int32) = _.Minutes
                let v154 : int32 = v153 v146
                let v157 : (System.TimeSpan -> int32) = _.Seconds
                let v158 : int32 = v157 v146
                let v161 : (System.TimeSpan -> int32) = _.Milliseconds
                let v162 : int32 = v161 v146
                let v165 : System.DateTime = System.DateTime (1, 1, 1, v150, v154, v158, v162)
                v165
        let v173 : string = method5()
        let v176 : (string -> string) = v172.ToString
        let v177 : string = v176 v173
        let _v111 = v177 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v180 : US3 option = None
        let _v180 = ref v180 
        let v181 : US3 option ref = _v180 
        let v182 : (US3 option -> US3 option ref) = closure8(v181)
        let v183 : unit = ()
        let v184 : (unit -> unit) = closure9(v98, v182)
        let v185 : unit = (fun () -> v184 (); v183) ()
        let v188 : US3 option = _v180.Value 
        let v199 : US3 = US3_1
        let v200 : US3 = v188 |> Option.defaultValue v199 
        let v240 : System.DateTime =
            match v200 with
            | US3_1 -> (* None *)
                let v236 : System.DateTime = System.DateTime.Now
                v236
            | US3_0(v204) -> (* Some *)
                let v205 : System.DateTime = System.DateTime.Now
                let v208 : (System.DateTime -> int64) = _.Ticks
                let v209 : int64 = v208 v205
                let v212 : int64 = v209 - v204
                let v213 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v214 : System.TimeSpan = v213 v212
                let v217 : (System.TimeSpan -> int32) = _.Hours
                let v218 : int32 = v217 v214
                let v221 : (System.TimeSpan -> int32) = _.Minutes
                let v222 : int32 = v221 v214
                let v225 : (System.TimeSpan -> int32) = _.Seconds
                let v226 : int32 = v225 v214
                let v229 : (System.TimeSpan -> int32) = _.Milliseconds
                let v230 : int32 = v229 v214
                let v233 : System.DateTime = System.DateTime (1, 1, 1, v218, v222, v226, v230)
                v233
        let v241 : string = method5()
        let v244 : (string -> string) = v240.ToString
        let v245 : string = v244 v241
        let _v111 = v245 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v248 : string = $"near_sdk::env::block_timestamp()"
        let v249 : uint64 = Fable.Core.RustInterop.emitRustExpr () v248 
        let v250 : US3 option = None
        let _v250 = ref v250 
        let v251 : US3 option ref = _v250 
        let v252 : (US3 option -> US3 option ref) = closure8(v251)
        let v253 : unit = ()
        let v254 : (unit -> unit) = closure9(v98, v252)
        let v255 : unit = (fun () -> v254 (); v253) ()
        let v258 : US3 option = _v250.Value 
        let v269 : US3 = US3_1
        let v270 : US3 = v258 |> Option.defaultValue v269 
        let v279 : uint64 =
            match v270 with
            | US3_1 -> (* None *)
                v249
            | US3_0(v274) -> (* Some *)
                let v275 : (int64 -> uint64) = uint64
                let v276 : uint64 = v275 v274
                let v277 : uint64 = v249 - v276
                v277
        let v280 : uint64 = v279 / 1000000000UL
        let v281 : uint64 = v280 % 60UL
        let v282 : uint64 = v280 / 60UL
        let v283 : uint64 = v282 % 60UL
        let v284 : uint64 = v280 / 3600UL
        let v285 : uint64 = v284 % 24UL
        let v286 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
        let v287 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v285, v283, v281) v286 
        let v288 : string = "fable_library_rust::String_::fromString($0)"
        let v289 : string = Fable.Core.RustInterop.emitRustExpr v287 v288 
        let _v111 = v289 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v290 : US3 option = None
        let _v290 = ref v290 
        let v291 : US3 option ref = _v290 
        let v292 : (US3 option -> US3 option ref) = closure8(v291)
        let v293 : unit = ()
        let v294 : (unit -> unit) = closure9(v98, v292)
        let v295 : unit = (fun () -> v294 (); v293) ()
        let v298 : US3 option = _v290.Value 
        let v309 : US3 = US3_1
        let v310 : US3 = v298 |> Option.defaultValue v309 
        let v350 : System.DateTime =
            match v310 with
            | US3_1 -> (* None *)
                let v346 : System.DateTime = System.DateTime.Now
                v346
            | US3_0(v314) -> (* Some *)
                let v315 : System.DateTime = System.DateTime.Now
                let v318 : (System.DateTime -> int64) = _.Ticks
                let v319 : int64 = v318 v315
                let v322 : int64 = v319 - v314
                let v323 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v324 : System.TimeSpan = v323 v322
                let v327 : (System.TimeSpan -> int32) = _.Hours
                let v328 : int32 = v327 v324
                let v331 : (System.TimeSpan -> int32) = _.Minutes
                let v332 : int32 = v331 v324
                let v335 : (System.TimeSpan -> int32) = _.Seconds
                let v336 : int32 = v335 v324
                let v339 : (System.TimeSpan -> int32) = _.Milliseconds
                let v340 : int32 = v339 v324
                let v343 : System.DateTime = System.DateTime (1, 1, 1, v328, v332, v336, v340)
                v343
        let v351 : string = method6()
        let v354 : (string -> string) = v350.ToString
        let v355 : string = v354 v351
        let _v111 = v355 
        #endif
#if FABLE_COMPILER_PYTHON
        let v358 : US3 option = None
        let _v358 = ref v358 
        let v359 : US3 option ref = _v358 
        let v360 : (US3 option -> US3 option ref) = closure8(v359)
        let v361 : unit = ()
        let v362 : (unit -> unit) = closure9(v98, v360)
        let v363 : unit = (fun () -> v362 (); v361) ()
        let v366 : US3 option = _v358.Value 
        let v377 : US3 = US3_1
        let v378 : US3 = v366 |> Option.defaultValue v377 
        let v418 : System.DateTime =
            match v378 with
            | US3_1 -> (* None *)
                let v414 : System.DateTime = System.DateTime.Now
                v414
            | US3_0(v382) -> (* Some *)
                let v383 : System.DateTime = System.DateTime.Now
                let v386 : (System.DateTime -> int64) = _.Ticks
                let v387 : int64 = v386 v383
                let v390 : int64 = v387 - v382
                let v391 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v392 : System.TimeSpan = v391 v390
                let v395 : (System.TimeSpan -> int32) = _.Hours
                let v396 : int32 = v395 v392
                let v399 : (System.TimeSpan -> int32) = _.Minutes
                let v400 : int32 = v399 v392
                let v403 : (System.TimeSpan -> int32) = _.Seconds
                let v404 : int32 = v403 v392
                let v407 : (System.TimeSpan -> int32) = _.Milliseconds
                let v408 : int32 = v407 v392
                let v411 : System.DateTime = System.DateTime (1, 1, 1, v396, v400, v404, v408)
                v411
        let v419 : string = method6()
        let v422 : (string -> string) = v418.ToString
        let v423 : string = v422 v419
        let _v111 = v423 
        #endif
#else
        let v426 : US3 option = None
        let _v426 = ref v426 
        let v427 : US3 option ref = _v426 
        let v428 : (US3 option -> US3 option ref) = closure8(v427)
        let v429 : unit = ()
        let v430 : (unit -> unit) = closure9(v98, v428)
        let v431 : unit = (fun () -> v430 (); v429) ()
        let v434 : US3 option = _v426.Value 
        let v445 : US3 = US3_1
        let v446 : US3 = v434 |> Option.defaultValue v445 
        let v486 : System.DateTime =
            match v446 with
            | US3_1 -> (* None *)
                let v482 : System.DateTime = System.DateTime.Now
                v482
            | US3_0(v450) -> (* Some *)
                let v451 : System.DateTime = System.DateTime.Now
                let v454 : (System.DateTime -> int64) = _.Ticks
                let v455 : int64 = v454 v451
                let v458 : int64 = v455 - v450
                let v459 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v460 : System.TimeSpan = v459 v458
                let v463 : (System.TimeSpan -> int32) = _.Hours
                let v464 : int32 = v463 v460
                let v467 : (System.TimeSpan -> int32) = _.Minutes
                let v468 : int32 = v467 v460
                let v471 : (System.TimeSpan -> int32) = _.Seconds
                let v472 : int32 = v471 v460
                let v475 : (System.TimeSpan -> int32) = _.Milliseconds
                let v476 : int32 = v475 v460
                let v479 : System.DateTime = System.DateTime (1, 1, 1, v464, v468, v472, v476)
                v479
        let v487 : string = method6()
        let v490 : (string -> string) = v486.ToString
        let v491 : string = v490 v487
        let _v111 = v491 
        #endif
        let v494 : string = _v111 
        
        
        
        
        
        let v564 : string = "Debug"
        let v565 : (unit -> string) = v564.ToLower
        let v566 : string = v565 ()
        let v569 : string = v566.PadLeft (7, ' ')
        let v583 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v584 : string = "inline_colorization::color_bright_blue"
        let v585 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v584 
        let v586 : string = "&*$0"
        let v587 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v569 v586 
        let v588 : string = "inline_colorization::color_reset"
        let v589 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v588 
        let v590 : string = "\"{v585}{v587}{v589}\""
        let v591 : string = @$"format!(" + v590 + ")"
        let v592 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v591 
        let v593 : string = "fable_library_rust::String_::fromString($0)"
        let v594 : string = Fable.Core.RustInterop.emitRustExpr v592 v593 
        let _v583 = v594 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v595 : string = "inline_colorization::color_bright_blue"
        let v596 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v595 
        let v597 : string = "&*$0"
        let v598 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v569 v597 
        let v599 : string = "inline_colorization::color_reset"
        let v600 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v599 
        let v601 : string = "\"{v596}{v598}{v600}\""
        let v602 : string = @$"format!(" + v601 + ")"
        let v603 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v602 
        let v604 : string = "fable_library_rust::String_::fromString($0)"
        let v605 : string = Fable.Core.RustInterop.emitRustExpr v603 v604 
        let _v583 = v605 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v606 : string = "inline_colorization::color_bright_blue"
        let v607 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v606 
        let v608 : string = "&*$0"
        let v609 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v569 v608 
        let v610 : string = "inline_colorization::color_reset"
        let v611 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v610 
        let v612 : string = "\"{v607}{v609}{v611}\""
        let v613 : string = @$"format!(" + v612 + ")"
        let v614 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v613 
        let v615 : string = "fable_library_rust::String_::fromString($0)"
        let v616 : string = Fable.Core.RustInterop.emitRustExpr v614 v615 
        let _v583 = v616 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v617 : string = "\u001b[94m"
        let v618 : string = method7()
        let v619 : string = v617 + v569 
        let v620 : string = v619 + v618 
        let _v583 = v620 
        #endif
#if FABLE_COMPILER_PYTHON
        let v621 : string = "\u001b[94m"
        let v622 : string = method7()
        let v623 : string = v621 + v569 
        let v624 : string = v623 + v622 
        let _v583 = v624 
        #endif
#else
        let v625 : string = "\u001b[94m"
        let v626 : string = method7()
        let v627 : string = v625 + v569 
        let v628 : string = v627 + v626 
        let _v583 = v628 
        #endif
        let v629 : string = _v583 
        let v635 : int64 = v93.l0
        let v636 : string = method8()
        let v637 : Mut3 = {l0 = v636} : Mut3
        let v638 : string = v637.l0
        let v639 : string = ""
        let v640 : (string -> unit) = closure11()
        let v641 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v642 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v639 v642 
        let _v641 = () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v643 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v639 v643 
        let _v641 = () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v644 : string = v19.l0
        let v645 : bool = v644 = ""
        let v653 : string =
            if v645 then
                v639
            else
                let v646 : bool = v639 = ""
                if v646 then
                    let v647 : string = v19.l0
                    v647
                else
                    let v648 : string = v19.l0
                    let v649 : string = "\n"
                    let v650 : string = v648 + v649 
                    let v651 : string = v650 + v639 
                    v651
        let v654 : string = "&*$0"
        let v655 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v653 v654 
        let v656 : string = $"$0.chars()"
        let v657 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v655 v656 
        let v658 : string = "v657"
        let v659 : _ = Fable.Core.RustInterop.emitRustExpr () v658 
        let v660 : string = "v659.collect::<Vec<_>>()"
        let v661 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v660 
        let v662 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
        let v663 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v661 v662 
        let v664 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
        let v665 : bool = Fable.Core.RustInterop.emitRustExpr v663 v664 
        let v666 : string = "x"
        let v667 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v666 
        let v668 : string = "String::from_iter($0)"
        let v669 : std_string_String = Fable.Core.RustInterop.emitRustExpr v667 v668 
        let v670 : string = "true; $0 }).collect::<Vec<_>>()"
        let v671 : bool = Fable.Core.RustInterop.emitRustExpr v669 v670 
        let v672 : string = "_vec_map"
        let v673 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v672 
        let v674 : string = "$0.len()"
        let v675 : unativeint = Fable.Core.RustInterop.emitRustExpr v673 v674 
        let v676 : (unativeint -> int32) = int32
        let v677 : int32 = v676 v675
        let v678 : bool = v639 <> v639 
        let v682 : bool =
            if v678 then
                let v681 : bool = v677 <= 1
                v681
            else
                false
        if v682 then
            v19.l0 <- v653
            ()
        else
            v19.l0 <- v639
            let v683 : string = "true; $0.into_iter().for_each(|x| { //"
            let v684 : bool = Fable.Core.RustInterop.emitRustExpr v673 v683 
            let v685 : string = "x"
            let v686 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v685 
            let v687 : string = $"near_sdk::log!(\"{{}}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v686 v687 
            let v688 : string = $"true;"
            let v689 : bool = Fable.Core.RustInterop.emitRustExpr () v688 
            let v690 : string = "true; }}); { //"
            let v691 : bool = Fable.Core.RustInterop.emitRustExpr () v690 
            ()
        let _v641 = () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        v640 v639
        let _v641 = () 
        #endif
#if FABLE_COMPILER_PYTHON
        v640 v639
        let _v641 = () 
        #endif
#else
        v640 v639
        let _v641 = () 
        #endif
        _v641 
        let v692 : (string -> unit) = v17.l0
        v692 v639
and closure18 (v0 : near_sdk_AccountId) () : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure3()
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
            let v72 : bool = 1 >= v71
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
        
        
        
        
        
        let v565 : string = "Debug"
        let v566 : (unit -> string) = v565.ToLower
        let v567 : string = v566 ()
        let v570 : string = v567.PadLeft (7, ' ')
        let v584 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v585 : string = "inline_colorization::color_bright_blue"
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
        let v596 : string = "inline_colorization::color_bright_blue"
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
        let v607 : string = "inline_colorization::color_bright_blue"
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
        let v618 : string = "\u001b[94m"
        let v619 : string = method7()
        let v620 : string = v618 + v570 
        let v621 : string = v620 + v619 
        let _v584 = v621 
        #endif
#if FABLE_COMPILER_PYTHON
        let v622 : string = "\u001b[94m"
        let v623 : string = method7()
        let v624 : string = v622 + v570 
        let v625 : string = v624 + v623 
        let _v584 = v625 
        #endif
#else
        let v626 : string = "\u001b[94m"
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
        let v648 : string = "account_id"
        let v649 : string = $"{v648}"
        let v652 : unit = ()
        let v653 : (unit -> unit) = closure10(v638, v649)
        let v654 : unit = (fun () -> v653 (); v652) ()
        let v657 : string = " = "
        let v658 : string = $"{v657}"
        let v661 : unit = ()
        let v662 : (unit -> unit) = closure10(v638, v658)
        let v663 : unit = (fun () -> v662 (); v661) ()
        let v666 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v667 : string = "format!(\"{:#?}\", $0)"
        let v668 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v667 
        let v669 : string = "fable_library_rust::String_::fromString($0)"
        let v670 : string = Fable.Core.RustInterop.emitRustExpr v668 v669 
        let _v666 = v670 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v671 : string = "format!(\"{:#?}\", $0)"
        let v672 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v671 
        let v673 : string = "fable_library_rust::String_::fromString($0)"
        let v674 : string = Fable.Core.RustInterop.emitRustExpr v672 v673 
        let _v666 = v674 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v675 : string = "format!(\"{:#?}\", $0)"
        let v676 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v675 
        let v677 : string = "fable_library_rust::String_::fromString($0)"
        let v678 : string = Fable.Core.RustInterop.emitRustExpr v676 v677 
        let _v666 = v678 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v679 : string = $"%A{v0}"
        let _v666 = v679 
        #endif
#if FABLE_COMPILER_PYTHON
        let v682 : string = $"%A{v0}"
        let _v666 = v682 
        #endif
#else
        let v685 : string = $"%A{v0}"
        let _v666 = v685 
        #endif
        let v688 : string = _v666 
        let v693 : string = $"{v688}"
        let v696 : unit = ()
        let v697 : (unit -> unit) = closure10(v638, v693)
        let v698 : unit = (fun () -> v697 (); v696) ()
        let v701 : string = " }"
        let v702 : string = $"{v701}"
        let v705 : unit = ()
        let v706 : (unit -> unit) = closure10(v638, v702)
        let v707 : unit = (fun () -> v706 (); v705) ()
        let v710 : string = v638.l0
        let v711 : string = $"chat_contract.get_account_info"
        let v712 : bool = v711 = ""
        let v769 : string =
            if v712 then
                let v713 : string = ""
                v713
            else
                let v714 : string = $"{v495} {v630} #{v636} %s{v711} / {v710}"
                let v717 : char list = []
                let v718 : (char list -> (char [])) = List.toArray
                let v719 : (char []) = v718 v717
                let v722 : string = v714.TrimStart v719 
                let v740 : char list = []
                let v741 : char list = '/' :: v740 
                let v744 : char list = ' ' :: v741 
                let v747 : (char list -> (char [])) = List.toArray
                let v748 : (char []) = v747 v744
                let v751 : string = v722.TrimEnd v748 
                v751
        let v770 : (string -> unit) = closure11()
        let v771 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v772 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v769 v772 
        let _v771 = () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v773 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v769 v773 
        let _v771 = () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v774 : string = v20.l0
        let v775 : bool = v774 = ""
        let v783 : string =
            if v775 then
                v769
            else
                let v776 : bool = v769 = ""
                if v776 then
                    let v777 : string = v20.l0
                    v777
                else
                    let v778 : string = v20.l0
                    let v779 : string = "\n"
                    let v780 : string = v778 + v779 
                    let v781 : string = v780 + v769 
                    v781
        let v784 : string = "&*$0"
        let v785 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v783 v784 
        let v786 : string = $"$0.chars()"
        let v787 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v785 v786 
        let v788 : string = "v787"
        let v789 : _ = Fable.Core.RustInterop.emitRustExpr () v788 
        let v790 : string = "v789.collect::<Vec<_>>()"
        let v791 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v790 
        let v792 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
        let v793 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v791 v792 
        let v794 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
        let v795 : bool = Fable.Core.RustInterop.emitRustExpr v793 v794 
        let v796 : string = "x"
        let v797 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v796 
        let v798 : string = "String::from_iter($0)"
        let v799 : std_string_String = Fable.Core.RustInterop.emitRustExpr v797 v798 
        let v800 : string = "true; $0 }).collect::<Vec<_>>()"
        let v801 : bool = Fable.Core.RustInterop.emitRustExpr v799 v800 
        let v802 : string = "_vec_map"
        let v803 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v802 
        let v804 : string = "$0.len()"
        let v805 : unativeint = Fable.Core.RustInterop.emitRustExpr v803 v804 
        let v806 : (unativeint -> int32) = int32
        let v807 : int32 = v806 v805
        let v808 : string = ""
        let v809 : bool = v769 <> v808 
        let v813 : bool =
            if v809 then
                let v812 : bool = v807 <= 1
                v812
            else
                false
        if v813 then
            v20.l0 <- v783
            ()
        else
            v20.l0 <- v808
            let v814 : string = "true; $0.into_iter().for_each(|x| { //"
            let v815 : bool = Fable.Core.RustInterop.emitRustExpr v803 v814 
            let v816 : string = "x"
            let v817 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v816 
            let v818 : string = $"near_sdk::log!(\"{{}}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v817 v818 
            let v819 : string = $"true;"
            let v820 : bool = Fable.Core.RustInterop.emitRustExpr () v819 
            let v821 : string = "true; }}); { //"
            let v822 : bool = Fable.Core.RustInterop.emitRustExpr () v821 
            ()
        let _v771 = () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        v770 v769
        let _v771 = () 
        #endif
#if FABLE_COMPILER_PYTHON
        v770 v769
        let _v771 = () 
        #endif
#else
        v770 v769
        let _v771 = () 
        #endif
        _v771 
        let v823 : (string -> unit) = v18.l0
        v823 v769
and closure19 () () : unit =
    let v0 : unit = ()
    let v1 : (unit -> unit) = closure3()
    let v2 : unit = (fun () -> v1 (); v0) ()
    let struct (v16 : Mut0, v17 : Mut1, v18 : Mut2, v19 : Mut3, v20 : Mut4, v21 : int64 option) = TraceState.trace_state.Value
    let v34 : unit = ()
    let v35 : unit = (fun () -> v1 (); v34) ()
    let struct (v49 : Mut0, v50 : Mut1, v51 : Mut2, v52 : Mut3, v53 : Mut4, v54 : int64 option) = TraceState.trace_state.Value
    let v67 : US0 = v53.l0
    let v68 : bool = v51.l0
    let v69 : bool = v68 = false
    let v72 : bool =
        if v69 then
            false
        else
            let v70 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v67
            let v71 : bool = 1 >= v70
            v71
    if v72 then
        let v73 : unit = ()
        let v74 : (unit -> unit) = closure7(v16)
        let v75 : unit = (fun () -> v74 (); v73) ()
        let v78 : unit = ()
        let v79 : unit = (fun () -> v1 (); v78) ()
        let struct (v93 : Mut0, v94 : Mut1, v95 : Mut2, v96 : Mut3, v97 : Mut4, v98 : int64 option) = TraceState.trace_state.Value
        let v111 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v112 : US3 option = None
        let _v112 = ref v112 
        let v113 : US3 option ref = _v112 
        let v114 : (US3 option -> US3 option ref) = closure8(v113)
        let v115 : unit = ()
        let v116 : (unit -> unit) = closure9(v98, v114)
        let v117 : unit = (fun () -> v116 (); v115) ()
        let v120 : US3 option = _v112.Value 
        let v131 : US3 = US3_1
        let v132 : US3 = v120 |> Option.defaultValue v131 
        let v172 : System.DateTime =
            match v132 with
            | US3_1 -> (* None *)
                let v168 : System.DateTime = System.DateTime.Now
                v168
            | US3_0(v136) -> (* Some *)
                let v137 : System.DateTime = System.DateTime.Now
                let v140 : (System.DateTime -> int64) = _.Ticks
                let v141 : int64 = v140 v137
                let v144 : int64 = v141 - v136
                let v145 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v146 : System.TimeSpan = v145 v144
                let v149 : (System.TimeSpan -> int32) = _.Hours
                let v150 : int32 = v149 v146
                let v153 : (System.TimeSpan -> int32) = _.Minutes
                let v154 : int32 = v153 v146
                let v157 : (System.TimeSpan -> int32) = _.Seconds
                let v158 : int32 = v157 v146
                let v161 : (System.TimeSpan -> int32) = _.Milliseconds
                let v162 : int32 = v161 v146
                let v165 : System.DateTime = System.DateTime (1, 1, 1, v150, v154, v158, v162)
                v165
        let v173 : string = method5()
        let v176 : (string -> string) = v172.ToString
        let v177 : string = v176 v173
        let _v111 = v177 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v180 : US3 option = None
        let _v180 = ref v180 
        let v181 : US3 option ref = _v180 
        let v182 : (US3 option -> US3 option ref) = closure8(v181)
        let v183 : unit = ()
        let v184 : (unit -> unit) = closure9(v98, v182)
        let v185 : unit = (fun () -> v184 (); v183) ()
        let v188 : US3 option = _v180.Value 
        let v199 : US3 = US3_1
        let v200 : US3 = v188 |> Option.defaultValue v199 
        let v240 : System.DateTime =
            match v200 with
            | US3_1 -> (* None *)
                let v236 : System.DateTime = System.DateTime.Now
                v236
            | US3_0(v204) -> (* Some *)
                let v205 : System.DateTime = System.DateTime.Now
                let v208 : (System.DateTime -> int64) = _.Ticks
                let v209 : int64 = v208 v205
                let v212 : int64 = v209 - v204
                let v213 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v214 : System.TimeSpan = v213 v212
                let v217 : (System.TimeSpan -> int32) = _.Hours
                let v218 : int32 = v217 v214
                let v221 : (System.TimeSpan -> int32) = _.Minutes
                let v222 : int32 = v221 v214
                let v225 : (System.TimeSpan -> int32) = _.Seconds
                let v226 : int32 = v225 v214
                let v229 : (System.TimeSpan -> int32) = _.Milliseconds
                let v230 : int32 = v229 v214
                let v233 : System.DateTime = System.DateTime (1, 1, 1, v218, v222, v226, v230)
                v233
        let v241 : string = method5()
        let v244 : (string -> string) = v240.ToString
        let v245 : string = v244 v241
        let _v111 = v245 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v248 : string = $"near_sdk::env::block_timestamp()"
        let v249 : uint64 = Fable.Core.RustInterop.emitRustExpr () v248 
        let v250 : US3 option = None
        let _v250 = ref v250 
        let v251 : US3 option ref = _v250 
        let v252 : (US3 option -> US3 option ref) = closure8(v251)
        let v253 : unit = ()
        let v254 : (unit -> unit) = closure9(v98, v252)
        let v255 : unit = (fun () -> v254 (); v253) ()
        let v258 : US3 option = _v250.Value 
        let v269 : US3 = US3_1
        let v270 : US3 = v258 |> Option.defaultValue v269 
        let v279 : uint64 =
            match v270 with
            | US3_1 -> (* None *)
                v249
            | US3_0(v274) -> (* Some *)
                let v275 : (int64 -> uint64) = uint64
                let v276 : uint64 = v275 v274
                let v277 : uint64 = v249 - v276
                v277
        let v280 : uint64 = v279 / 1000000000UL
        let v281 : uint64 = v280 % 60UL
        let v282 : uint64 = v280 / 60UL
        let v283 : uint64 = v282 % 60UL
        let v284 : uint64 = v280 / 3600UL
        let v285 : uint64 = v284 % 24UL
        let v286 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
        let v287 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v285, v283, v281) v286 
        let v288 : string = "fable_library_rust::String_::fromString($0)"
        let v289 : string = Fable.Core.RustInterop.emitRustExpr v287 v288 
        let _v111 = v289 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v290 : US3 option = None
        let _v290 = ref v290 
        let v291 : US3 option ref = _v290 
        let v292 : (US3 option -> US3 option ref) = closure8(v291)
        let v293 : unit = ()
        let v294 : (unit -> unit) = closure9(v98, v292)
        let v295 : unit = (fun () -> v294 (); v293) ()
        let v298 : US3 option = _v290.Value 
        let v309 : US3 = US3_1
        let v310 : US3 = v298 |> Option.defaultValue v309 
        let v350 : System.DateTime =
            match v310 with
            | US3_1 -> (* None *)
                let v346 : System.DateTime = System.DateTime.Now
                v346
            | US3_0(v314) -> (* Some *)
                let v315 : System.DateTime = System.DateTime.Now
                let v318 : (System.DateTime -> int64) = _.Ticks
                let v319 : int64 = v318 v315
                let v322 : int64 = v319 - v314
                let v323 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v324 : System.TimeSpan = v323 v322
                let v327 : (System.TimeSpan -> int32) = _.Hours
                let v328 : int32 = v327 v324
                let v331 : (System.TimeSpan -> int32) = _.Minutes
                let v332 : int32 = v331 v324
                let v335 : (System.TimeSpan -> int32) = _.Seconds
                let v336 : int32 = v335 v324
                let v339 : (System.TimeSpan -> int32) = _.Milliseconds
                let v340 : int32 = v339 v324
                let v343 : System.DateTime = System.DateTime (1, 1, 1, v328, v332, v336, v340)
                v343
        let v351 : string = method6()
        let v354 : (string -> string) = v350.ToString
        let v355 : string = v354 v351
        let _v111 = v355 
        #endif
#if FABLE_COMPILER_PYTHON
        let v358 : US3 option = None
        let _v358 = ref v358 
        let v359 : US3 option ref = _v358 
        let v360 : (US3 option -> US3 option ref) = closure8(v359)
        let v361 : unit = ()
        let v362 : (unit -> unit) = closure9(v98, v360)
        let v363 : unit = (fun () -> v362 (); v361) ()
        let v366 : US3 option = _v358.Value 
        let v377 : US3 = US3_1
        let v378 : US3 = v366 |> Option.defaultValue v377 
        let v418 : System.DateTime =
            match v378 with
            | US3_1 -> (* None *)
                let v414 : System.DateTime = System.DateTime.Now
                v414
            | US3_0(v382) -> (* Some *)
                let v383 : System.DateTime = System.DateTime.Now
                let v386 : (System.DateTime -> int64) = _.Ticks
                let v387 : int64 = v386 v383
                let v390 : int64 = v387 - v382
                let v391 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v392 : System.TimeSpan = v391 v390
                let v395 : (System.TimeSpan -> int32) = _.Hours
                let v396 : int32 = v395 v392
                let v399 : (System.TimeSpan -> int32) = _.Minutes
                let v400 : int32 = v399 v392
                let v403 : (System.TimeSpan -> int32) = _.Seconds
                let v404 : int32 = v403 v392
                let v407 : (System.TimeSpan -> int32) = _.Milliseconds
                let v408 : int32 = v407 v392
                let v411 : System.DateTime = System.DateTime (1, 1, 1, v396, v400, v404, v408)
                v411
        let v419 : string = method6()
        let v422 : (string -> string) = v418.ToString
        let v423 : string = v422 v419
        let _v111 = v423 
        #endif
#else
        let v426 : US3 option = None
        let _v426 = ref v426 
        let v427 : US3 option ref = _v426 
        let v428 : (US3 option -> US3 option ref) = closure8(v427)
        let v429 : unit = ()
        let v430 : (unit -> unit) = closure9(v98, v428)
        let v431 : unit = (fun () -> v430 (); v429) ()
        let v434 : US3 option = _v426.Value 
        let v445 : US3 = US3_1
        let v446 : US3 = v434 |> Option.defaultValue v445 
        let v486 : System.DateTime =
            match v446 with
            | US3_1 -> (* None *)
                let v482 : System.DateTime = System.DateTime.Now
                v482
            | US3_0(v450) -> (* Some *)
                let v451 : System.DateTime = System.DateTime.Now
                let v454 : (System.DateTime -> int64) = _.Ticks
                let v455 : int64 = v454 v451
                let v458 : int64 = v455 - v450
                let v459 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v460 : System.TimeSpan = v459 v458
                let v463 : (System.TimeSpan -> int32) = _.Hours
                let v464 : int32 = v463 v460
                let v467 : (System.TimeSpan -> int32) = _.Minutes
                let v468 : int32 = v467 v460
                let v471 : (System.TimeSpan -> int32) = _.Seconds
                let v472 : int32 = v471 v460
                let v475 : (System.TimeSpan -> int32) = _.Milliseconds
                let v476 : int32 = v475 v460
                let v479 : System.DateTime = System.DateTime (1, 1, 1, v464, v468, v472, v476)
                v479
        let v487 : string = method6()
        let v490 : (string -> string) = v486.ToString
        let v491 : string = v490 v487
        let _v111 = v491 
        #endif
        let v494 : string = _v111 
        
        
        
        
        
        let v564 : string = "Debug"
        let v565 : (unit -> string) = v564.ToLower
        let v566 : string = v565 ()
        let v569 : string = v566.PadLeft (7, ' ')
        let v583 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v584 : string = "inline_colorization::color_bright_blue"
        let v585 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v584 
        let v586 : string = "&*$0"
        let v587 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v569 v586 
        let v588 : string = "inline_colorization::color_reset"
        let v589 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v588 
        let v590 : string = "\"{v585}{v587}{v589}\""
        let v591 : string = @$"format!(" + v590 + ")"
        let v592 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v591 
        let v593 : string = "fable_library_rust::String_::fromString($0)"
        let v594 : string = Fable.Core.RustInterop.emitRustExpr v592 v593 
        let _v583 = v594 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v595 : string = "inline_colorization::color_bright_blue"
        let v596 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v595 
        let v597 : string = "&*$0"
        let v598 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v569 v597 
        let v599 : string = "inline_colorization::color_reset"
        let v600 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v599 
        let v601 : string = "\"{v596}{v598}{v600}\""
        let v602 : string = @$"format!(" + v601 + ")"
        let v603 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v602 
        let v604 : string = "fable_library_rust::String_::fromString($0)"
        let v605 : string = Fable.Core.RustInterop.emitRustExpr v603 v604 
        let _v583 = v605 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v606 : string = "inline_colorization::color_bright_blue"
        let v607 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v606 
        let v608 : string = "&*$0"
        let v609 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v569 v608 
        let v610 : string = "inline_colorization::color_reset"
        let v611 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v610 
        let v612 : string = "\"{v607}{v609}{v611}\""
        let v613 : string = @$"format!(" + v612 + ")"
        let v614 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v613 
        let v615 : string = "fable_library_rust::String_::fromString($0)"
        let v616 : string = Fable.Core.RustInterop.emitRustExpr v614 v615 
        let _v583 = v616 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v617 : string = "\u001b[94m"
        let v618 : string = method7()
        let v619 : string = v617 + v569 
        let v620 : string = v619 + v618 
        let _v583 = v620 
        #endif
#if FABLE_COMPILER_PYTHON
        let v621 : string = "\u001b[94m"
        let v622 : string = method7()
        let v623 : string = v621 + v569 
        let v624 : string = v623 + v622 
        let _v583 = v624 
        #endif
#else
        let v625 : string = "\u001b[94m"
        let v626 : string = method7()
        let v627 : string = v625 + v569 
        let v628 : string = v627 + v626 
        let _v583 = v628 
        #endif
        let v629 : string = _v583 
        let v635 : int64 = v93.l0
        let v636 : string = method8()
        let v637 : Mut3 = {l0 = v636} : Mut3
        let v638 : string = v637.l0
        let v639 : string = ""
        let v640 : (string -> unit) = closure11()
        let v641 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v642 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v639 v642 
        let _v641 = () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v643 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v639 v643 
        let _v641 = () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v644 : string = v19.l0
        let v645 : bool = v644 = ""
        let v653 : string =
            if v645 then
                v639
            else
                let v646 : bool = v639 = ""
                if v646 then
                    let v647 : string = v19.l0
                    v647
                else
                    let v648 : string = v19.l0
                    let v649 : string = "\n"
                    let v650 : string = v648 + v649 
                    let v651 : string = v650 + v639 
                    v651
        let v654 : string = "&*$0"
        let v655 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v653 v654 
        let v656 : string = $"$0.chars()"
        let v657 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v655 v656 
        let v658 : string = "v657"
        let v659 : _ = Fable.Core.RustInterop.emitRustExpr () v658 
        let v660 : string = "v659.collect::<Vec<_>>()"
        let v661 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v660 
        let v662 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
        let v663 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v661 v662 
        let v664 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
        let v665 : bool = Fable.Core.RustInterop.emitRustExpr v663 v664 
        let v666 : string = "x"
        let v667 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v666 
        let v668 : string = "String::from_iter($0)"
        let v669 : std_string_String = Fable.Core.RustInterop.emitRustExpr v667 v668 
        let v670 : string = "true; $0 }).collect::<Vec<_>>()"
        let v671 : bool = Fable.Core.RustInterop.emitRustExpr v669 v670 
        let v672 : string = "_vec_map"
        let v673 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v672 
        let v674 : string = "$0.len()"
        let v675 : unativeint = Fable.Core.RustInterop.emitRustExpr v673 v674 
        let v676 : (unativeint -> int32) = int32
        let v677 : int32 = v676 v675
        let v678 : bool = v639 <> v639 
        let v682 : bool =
            if v678 then
                let v681 : bool = v677 <= 1
                v681
            else
                false
        if v682 then
            v19.l0 <- v653
            ()
        else
            v19.l0 <- v639
            let v683 : string = "true; $0.into_iter().for_each(|x| { //"
            let v684 : bool = Fable.Core.RustInterop.emitRustExpr v673 v683 
            let v685 : string = "x"
            let v686 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v685 
            let v687 : string = $"near_sdk::log!(\"{{}}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v686 v687 
            let v688 : string = $"true;"
            let v689 : bool = Fable.Core.RustInterop.emitRustExpr () v688 
            let v690 : string = "true; }}); { //"
            let v691 : bool = Fable.Core.RustInterop.emitRustExpr () v690 
            ()
        let _v641 = () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        v640 v639
        let _v641 = () 
        #endif
#if FABLE_COMPILER_PYTHON
        v640 v639
        let _v641 = () 
        #endif
#else
        v640 v639
        let _v641 = () 
        #endif
        _v641 
        let v692 : (string -> unit) = v17.l0
        v692 v639
and closure20 (v0 : std_string_String) () : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure3()
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
            let v72 : bool = 1 >= v71
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
        
        
        
        
        
        let v565 : string = "Debug"
        let v566 : (unit -> string) = v565.ToLower
        let v567 : string = v566 ()
        let v570 : string = v567.PadLeft (7, ' ')
        let v584 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v585 : string = "inline_colorization::color_bright_blue"
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
        let v596 : string = "inline_colorization::color_bright_blue"
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
        let v607 : string = "inline_colorization::color_bright_blue"
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
        let v618 : string = "\u001b[94m"
        let v619 : string = method7()
        let v620 : string = v618 + v570 
        let v621 : string = v620 + v619 
        let _v584 = v621 
        #endif
#if FABLE_COMPILER_PYTHON
        let v622 : string = "\u001b[94m"
        let v623 : string = method7()
        let v624 : string = v622 + v570 
        let v625 : string = v624 + v623 
        let _v584 = v625 
        #endif
#else
        let v626 : string = "\u001b[94m"
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
        let v648 : string = "alias"
        let v649 : string = $"{v648}"
        let v652 : unit = ()
        let v653 : (unit -> unit) = closure10(v638, v649)
        let v654 : unit = (fun () -> v653 (); v652) ()
        let v657 : string = " = "
        let v658 : string = $"{v657}"
        let v661 : unit = ()
        let v662 : (unit -> unit) = closure10(v638, v658)
        let v663 : unit = (fun () -> v662 (); v661) ()
        let v666 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v667 : string = "format!(\"{:#?}\", $0)"
        let v668 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v667 
        let v669 : string = "fable_library_rust::String_::fromString($0)"
        let v670 : string = Fable.Core.RustInterop.emitRustExpr v668 v669 
        let _v666 = v670 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v671 : string = "format!(\"{:#?}\", $0)"
        let v672 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v671 
        let v673 : string = "fable_library_rust::String_::fromString($0)"
        let v674 : string = Fable.Core.RustInterop.emitRustExpr v672 v673 
        let _v666 = v674 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v675 : string = "format!(\"{:#?}\", $0)"
        let v676 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v675 
        let v677 : string = "fable_library_rust::String_::fromString($0)"
        let v678 : string = Fable.Core.RustInterop.emitRustExpr v676 v677 
        let _v666 = v678 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v679 : string = $"%A{v0}"
        let _v666 = v679 
        #endif
#if FABLE_COMPILER_PYTHON
        let v682 : string = $"%A{v0}"
        let _v666 = v682 
        #endif
#else
        let v685 : string = $"%A{v0}"
        let _v666 = v685 
        #endif
        let v688 : string = _v666 
        let v693 : string = $"{v688}"
        let v696 : unit = ()
        let v697 : (unit -> unit) = closure10(v638, v693)
        let v698 : unit = (fun () -> v697 (); v696) ()
        let v701 : string = " }"
        let v702 : string = $"{v701}"
        let v705 : unit = ()
        let v706 : (unit -> unit) = closure10(v638, v702)
        let v707 : unit = (fun () -> v706 (); v705) ()
        let v710 : string = v638.l0
        let v711 : string = $"chat_contract.get_alias_map"
        let v712 : bool = v711 = ""
        let v769 : string =
            if v712 then
                let v713 : string = ""
                v713
            else
                let v714 : string = $"{v495} {v630} #{v636} %s{v711} / {v710}"
                let v717 : char list = []
                let v718 : (char list -> (char [])) = List.toArray
                let v719 : (char []) = v718 v717
                let v722 : string = v714.TrimStart v719 
                let v740 : char list = []
                let v741 : char list = '/' :: v740 
                let v744 : char list = ' ' :: v741 
                let v747 : (char list -> (char [])) = List.toArray
                let v748 : (char []) = v747 v744
                let v751 : string = v722.TrimEnd v748 
                v751
        let v770 : (string -> unit) = closure11()
        let v771 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v772 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v769 v772 
        let _v771 = () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v773 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v769 v773 
        let _v771 = () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v774 : string = v20.l0
        let v775 : bool = v774 = ""
        let v783 : string =
            if v775 then
                v769
            else
                let v776 : bool = v769 = ""
                if v776 then
                    let v777 : string = v20.l0
                    v777
                else
                    let v778 : string = v20.l0
                    let v779 : string = "\n"
                    let v780 : string = v778 + v779 
                    let v781 : string = v780 + v769 
                    v781
        let v784 : string = "&*$0"
        let v785 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v783 v784 
        let v786 : string = $"$0.chars()"
        let v787 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v785 v786 
        let v788 : string = "v787"
        let v789 : _ = Fable.Core.RustInterop.emitRustExpr () v788 
        let v790 : string = "v789.collect::<Vec<_>>()"
        let v791 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v790 
        let v792 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
        let v793 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v791 v792 
        let v794 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
        let v795 : bool = Fable.Core.RustInterop.emitRustExpr v793 v794 
        let v796 : string = "x"
        let v797 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v796 
        let v798 : string = "String::from_iter($0)"
        let v799 : std_string_String = Fable.Core.RustInterop.emitRustExpr v797 v798 
        let v800 : string = "true; $0 }).collect::<Vec<_>>()"
        let v801 : bool = Fable.Core.RustInterop.emitRustExpr v799 v800 
        let v802 : string = "_vec_map"
        let v803 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v802 
        let v804 : string = "$0.len()"
        let v805 : unativeint = Fable.Core.RustInterop.emitRustExpr v803 v804 
        let v806 : (unativeint -> int32) = int32
        let v807 : int32 = v806 v805
        let v808 : string = ""
        let v809 : bool = v769 <> v808 
        let v813 : bool =
            if v809 then
                let v812 : bool = v807 <= 1
                v812
            else
                false
        if v813 then
            v20.l0 <- v783
            ()
        else
            v20.l0 <- v808
            let v814 : string = "true; $0.into_iter().for_each(|x| { //"
            let v815 : bool = Fable.Core.RustInterop.emitRustExpr v803 v814 
            let v816 : string = "x"
            let v817 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v816 
            let v818 : string = $"near_sdk::log!(\"{{}}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v817 v818 
            let v819 : string = $"true;"
            let v820 : bool = Fable.Core.RustInterop.emitRustExpr () v819 
            let v821 : string = "true; }}); { //"
            let v822 : bool = Fable.Core.RustInterop.emitRustExpr () v821 
            ()
        let _v771 = () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        v770 v769
        let _v771 = () 
        #endif
#if FABLE_COMPILER_PYTHON
        v770 v769
        let _v771 = () 
        #endif
#else
        v770 v769
        let _v771 = () 
        #endif
        _v771 
        let v823 : (string -> unit) = v18.l0
        v823 v769
and closure21 () () : unit =
    let v0 : unit = ()
    let v1 : (unit -> unit) = closure3()
    let v2 : unit = (fun () -> v1 (); v0) ()
    let struct (v16 : Mut0, v17 : Mut1, v18 : Mut2, v19 : Mut3, v20 : Mut4, v21 : int64 option) = TraceState.trace_state.Value
    let v34 : unit = ()
    let v35 : unit = (fun () -> v1 (); v34) ()
    let struct (v49 : Mut0, v50 : Mut1, v51 : Mut2, v52 : Mut3, v53 : Mut4, v54 : int64 option) = TraceState.trace_state.Value
    let v67 : US0 = v53.l0
    let v68 : bool = v51.l0
    let v69 : bool = v68 = false
    let v72 : bool =
        if v69 then
            false
        else
            let v70 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v67
            let v71 : bool = 1 >= v70
            v71
    if v72 then
        let v73 : unit = ()
        let v74 : (unit -> unit) = closure7(v16)
        let v75 : unit = (fun () -> v74 (); v73) ()
        let v78 : unit = ()
        let v79 : unit = (fun () -> v1 (); v78) ()
        let struct (v93 : Mut0, v94 : Mut1, v95 : Mut2, v96 : Mut3, v97 : Mut4, v98 : int64 option) = TraceState.trace_state.Value
        let v111 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v112 : US3 option = None
        let _v112 = ref v112 
        let v113 : US3 option ref = _v112 
        let v114 : (US3 option -> US3 option ref) = closure8(v113)
        let v115 : unit = ()
        let v116 : (unit -> unit) = closure9(v98, v114)
        let v117 : unit = (fun () -> v116 (); v115) ()
        let v120 : US3 option = _v112.Value 
        let v131 : US3 = US3_1
        let v132 : US3 = v120 |> Option.defaultValue v131 
        let v172 : System.DateTime =
            match v132 with
            | US3_1 -> (* None *)
                let v168 : System.DateTime = System.DateTime.Now
                v168
            | US3_0(v136) -> (* Some *)
                let v137 : System.DateTime = System.DateTime.Now
                let v140 : (System.DateTime -> int64) = _.Ticks
                let v141 : int64 = v140 v137
                let v144 : int64 = v141 - v136
                let v145 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v146 : System.TimeSpan = v145 v144
                let v149 : (System.TimeSpan -> int32) = _.Hours
                let v150 : int32 = v149 v146
                let v153 : (System.TimeSpan -> int32) = _.Minutes
                let v154 : int32 = v153 v146
                let v157 : (System.TimeSpan -> int32) = _.Seconds
                let v158 : int32 = v157 v146
                let v161 : (System.TimeSpan -> int32) = _.Milliseconds
                let v162 : int32 = v161 v146
                let v165 : System.DateTime = System.DateTime (1, 1, 1, v150, v154, v158, v162)
                v165
        let v173 : string = method5()
        let v176 : (string -> string) = v172.ToString
        let v177 : string = v176 v173
        let _v111 = v177 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v180 : US3 option = None
        let _v180 = ref v180 
        let v181 : US3 option ref = _v180 
        let v182 : (US3 option -> US3 option ref) = closure8(v181)
        let v183 : unit = ()
        let v184 : (unit -> unit) = closure9(v98, v182)
        let v185 : unit = (fun () -> v184 (); v183) ()
        let v188 : US3 option = _v180.Value 
        let v199 : US3 = US3_1
        let v200 : US3 = v188 |> Option.defaultValue v199 
        let v240 : System.DateTime =
            match v200 with
            | US3_1 -> (* None *)
                let v236 : System.DateTime = System.DateTime.Now
                v236
            | US3_0(v204) -> (* Some *)
                let v205 : System.DateTime = System.DateTime.Now
                let v208 : (System.DateTime -> int64) = _.Ticks
                let v209 : int64 = v208 v205
                let v212 : int64 = v209 - v204
                let v213 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v214 : System.TimeSpan = v213 v212
                let v217 : (System.TimeSpan -> int32) = _.Hours
                let v218 : int32 = v217 v214
                let v221 : (System.TimeSpan -> int32) = _.Minutes
                let v222 : int32 = v221 v214
                let v225 : (System.TimeSpan -> int32) = _.Seconds
                let v226 : int32 = v225 v214
                let v229 : (System.TimeSpan -> int32) = _.Milliseconds
                let v230 : int32 = v229 v214
                let v233 : System.DateTime = System.DateTime (1, 1, 1, v218, v222, v226, v230)
                v233
        let v241 : string = method5()
        let v244 : (string -> string) = v240.ToString
        let v245 : string = v244 v241
        let _v111 = v245 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v248 : string = $"near_sdk::env::block_timestamp()"
        let v249 : uint64 = Fable.Core.RustInterop.emitRustExpr () v248 
        let v250 : US3 option = None
        let _v250 = ref v250 
        let v251 : US3 option ref = _v250 
        let v252 : (US3 option -> US3 option ref) = closure8(v251)
        let v253 : unit = ()
        let v254 : (unit -> unit) = closure9(v98, v252)
        let v255 : unit = (fun () -> v254 (); v253) ()
        let v258 : US3 option = _v250.Value 
        let v269 : US3 = US3_1
        let v270 : US3 = v258 |> Option.defaultValue v269 
        let v279 : uint64 =
            match v270 with
            | US3_1 -> (* None *)
                v249
            | US3_0(v274) -> (* Some *)
                let v275 : (int64 -> uint64) = uint64
                let v276 : uint64 = v275 v274
                let v277 : uint64 = v249 - v276
                v277
        let v280 : uint64 = v279 / 1000000000UL
        let v281 : uint64 = v280 % 60UL
        let v282 : uint64 = v280 / 60UL
        let v283 : uint64 = v282 % 60UL
        let v284 : uint64 = v280 / 3600UL
        let v285 : uint64 = v284 % 24UL
        let v286 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
        let v287 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v285, v283, v281) v286 
        let v288 : string = "fable_library_rust::String_::fromString($0)"
        let v289 : string = Fable.Core.RustInterop.emitRustExpr v287 v288 
        let _v111 = v289 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v290 : US3 option = None
        let _v290 = ref v290 
        let v291 : US3 option ref = _v290 
        let v292 : (US3 option -> US3 option ref) = closure8(v291)
        let v293 : unit = ()
        let v294 : (unit -> unit) = closure9(v98, v292)
        let v295 : unit = (fun () -> v294 (); v293) ()
        let v298 : US3 option = _v290.Value 
        let v309 : US3 = US3_1
        let v310 : US3 = v298 |> Option.defaultValue v309 
        let v350 : System.DateTime =
            match v310 with
            | US3_1 -> (* None *)
                let v346 : System.DateTime = System.DateTime.Now
                v346
            | US3_0(v314) -> (* Some *)
                let v315 : System.DateTime = System.DateTime.Now
                let v318 : (System.DateTime -> int64) = _.Ticks
                let v319 : int64 = v318 v315
                let v322 : int64 = v319 - v314
                let v323 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v324 : System.TimeSpan = v323 v322
                let v327 : (System.TimeSpan -> int32) = _.Hours
                let v328 : int32 = v327 v324
                let v331 : (System.TimeSpan -> int32) = _.Minutes
                let v332 : int32 = v331 v324
                let v335 : (System.TimeSpan -> int32) = _.Seconds
                let v336 : int32 = v335 v324
                let v339 : (System.TimeSpan -> int32) = _.Milliseconds
                let v340 : int32 = v339 v324
                let v343 : System.DateTime = System.DateTime (1, 1, 1, v328, v332, v336, v340)
                v343
        let v351 : string = method6()
        let v354 : (string -> string) = v350.ToString
        let v355 : string = v354 v351
        let _v111 = v355 
        #endif
#if FABLE_COMPILER_PYTHON
        let v358 : US3 option = None
        let _v358 = ref v358 
        let v359 : US3 option ref = _v358 
        let v360 : (US3 option -> US3 option ref) = closure8(v359)
        let v361 : unit = ()
        let v362 : (unit -> unit) = closure9(v98, v360)
        let v363 : unit = (fun () -> v362 (); v361) ()
        let v366 : US3 option = _v358.Value 
        let v377 : US3 = US3_1
        let v378 : US3 = v366 |> Option.defaultValue v377 
        let v418 : System.DateTime =
            match v378 with
            | US3_1 -> (* None *)
                let v414 : System.DateTime = System.DateTime.Now
                v414
            | US3_0(v382) -> (* Some *)
                let v383 : System.DateTime = System.DateTime.Now
                let v386 : (System.DateTime -> int64) = _.Ticks
                let v387 : int64 = v386 v383
                let v390 : int64 = v387 - v382
                let v391 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v392 : System.TimeSpan = v391 v390
                let v395 : (System.TimeSpan -> int32) = _.Hours
                let v396 : int32 = v395 v392
                let v399 : (System.TimeSpan -> int32) = _.Minutes
                let v400 : int32 = v399 v392
                let v403 : (System.TimeSpan -> int32) = _.Seconds
                let v404 : int32 = v403 v392
                let v407 : (System.TimeSpan -> int32) = _.Milliseconds
                let v408 : int32 = v407 v392
                let v411 : System.DateTime = System.DateTime (1, 1, 1, v396, v400, v404, v408)
                v411
        let v419 : string = method6()
        let v422 : (string -> string) = v418.ToString
        let v423 : string = v422 v419
        let _v111 = v423 
        #endif
#else
        let v426 : US3 option = None
        let _v426 = ref v426 
        let v427 : US3 option ref = _v426 
        let v428 : (US3 option -> US3 option ref) = closure8(v427)
        let v429 : unit = ()
        let v430 : (unit -> unit) = closure9(v98, v428)
        let v431 : unit = (fun () -> v430 (); v429) ()
        let v434 : US3 option = _v426.Value 
        let v445 : US3 = US3_1
        let v446 : US3 = v434 |> Option.defaultValue v445 
        let v486 : System.DateTime =
            match v446 with
            | US3_1 -> (* None *)
                let v482 : System.DateTime = System.DateTime.Now
                v482
            | US3_0(v450) -> (* Some *)
                let v451 : System.DateTime = System.DateTime.Now
                let v454 : (System.DateTime -> int64) = _.Ticks
                let v455 : int64 = v454 v451
                let v458 : int64 = v455 - v450
                let v459 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v460 : System.TimeSpan = v459 v458
                let v463 : (System.TimeSpan -> int32) = _.Hours
                let v464 : int32 = v463 v460
                let v467 : (System.TimeSpan -> int32) = _.Minutes
                let v468 : int32 = v467 v460
                let v471 : (System.TimeSpan -> int32) = _.Seconds
                let v472 : int32 = v471 v460
                let v475 : (System.TimeSpan -> int32) = _.Milliseconds
                let v476 : int32 = v475 v460
                let v479 : System.DateTime = System.DateTime (1, 1, 1, v464, v468, v472, v476)
                v479
        let v487 : string = method6()
        let v490 : (string -> string) = v486.ToString
        let v491 : string = v490 v487
        let _v111 = v491 
        #endif
        let v494 : string = _v111 
        
        
        
        
        
        let v564 : string = "Debug"
        let v565 : (unit -> string) = v564.ToLower
        let v566 : string = v565 ()
        let v569 : string = v566.PadLeft (7, ' ')
        let v583 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v584 : string = "inline_colorization::color_bright_blue"
        let v585 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v584 
        let v586 : string = "&*$0"
        let v587 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v569 v586 
        let v588 : string = "inline_colorization::color_reset"
        let v589 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v588 
        let v590 : string = "\"{v585}{v587}{v589}\""
        let v591 : string = @$"format!(" + v590 + ")"
        let v592 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v591 
        let v593 : string = "fable_library_rust::String_::fromString($0)"
        let v594 : string = Fable.Core.RustInterop.emitRustExpr v592 v593 
        let _v583 = v594 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v595 : string = "inline_colorization::color_bright_blue"
        let v596 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v595 
        let v597 : string = "&*$0"
        let v598 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v569 v597 
        let v599 : string = "inline_colorization::color_reset"
        let v600 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v599 
        let v601 : string = "\"{v596}{v598}{v600}\""
        let v602 : string = @$"format!(" + v601 + ")"
        let v603 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v602 
        let v604 : string = "fable_library_rust::String_::fromString($0)"
        let v605 : string = Fable.Core.RustInterop.emitRustExpr v603 v604 
        let _v583 = v605 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v606 : string = "inline_colorization::color_bright_blue"
        let v607 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v606 
        let v608 : string = "&*$0"
        let v609 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v569 v608 
        let v610 : string = "inline_colorization::color_reset"
        let v611 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v610 
        let v612 : string = "\"{v607}{v609}{v611}\""
        let v613 : string = @$"format!(" + v612 + ")"
        let v614 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v613 
        let v615 : string = "fable_library_rust::String_::fromString($0)"
        let v616 : string = Fable.Core.RustInterop.emitRustExpr v614 v615 
        let _v583 = v616 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v617 : string = "\u001b[94m"
        let v618 : string = method7()
        let v619 : string = v617 + v569 
        let v620 : string = v619 + v618 
        let _v583 = v620 
        #endif
#if FABLE_COMPILER_PYTHON
        let v621 : string = "\u001b[94m"
        let v622 : string = method7()
        let v623 : string = v621 + v569 
        let v624 : string = v623 + v622 
        let _v583 = v624 
        #endif
#else
        let v625 : string = "\u001b[94m"
        let v626 : string = method7()
        let v627 : string = v625 + v569 
        let v628 : string = v627 + v626 
        let _v583 = v628 
        #endif
        let v629 : string = _v583 
        let v635 : int64 = v93.l0
        let v636 : string = method8()
        let v637 : Mut3 = {l0 = v636} : Mut3
        let v638 : string = v637.l0
        let v639 : string = ""
        let v640 : (string -> unit) = closure11()
        let v641 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v642 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v639 v642 
        let _v641 = () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v643 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v639 v643 
        let _v641 = () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v644 : string = v19.l0
        let v645 : bool = v644 = ""
        let v653 : string =
            if v645 then
                v639
            else
                let v646 : bool = v639 = ""
                if v646 then
                    let v647 : string = v19.l0
                    v647
                else
                    let v648 : string = v19.l0
                    let v649 : string = "\n"
                    let v650 : string = v648 + v649 
                    let v651 : string = v650 + v639 
                    v651
        let v654 : string = "&*$0"
        let v655 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v653 v654 
        let v656 : string = $"$0.chars()"
        let v657 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v655 v656 
        let v658 : string = "v657"
        let v659 : _ = Fable.Core.RustInterop.emitRustExpr () v658 
        let v660 : string = "v659.collect::<Vec<_>>()"
        let v661 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v660 
        let v662 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
        let v663 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v661 v662 
        let v664 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
        let v665 : bool = Fable.Core.RustInterop.emitRustExpr v663 v664 
        let v666 : string = "x"
        let v667 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v666 
        let v668 : string = "String::from_iter($0)"
        let v669 : std_string_String = Fable.Core.RustInterop.emitRustExpr v667 v668 
        let v670 : string = "true; $0 }).collect::<Vec<_>>()"
        let v671 : bool = Fable.Core.RustInterop.emitRustExpr v669 v670 
        let v672 : string = "_vec_map"
        let v673 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v672 
        let v674 : string = "$0.len()"
        let v675 : unativeint = Fable.Core.RustInterop.emitRustExpr v673 v674 
        let v676 : (unativeint -> int32) = int32
        let v677 : int32 = v676 v675
        let v678 : bool = v639 <> v639 
        let v682 : bool =
            if v678 then
                let v681 : bool = v677 <= 1
                v681
            else
                false
        if v682 then
            v19.l0 <- v653
            ()
        else
            v19.l0 <- v639
            let v683 : string = "true; $0.into_iter().for_each(|x| { //"
            let v684 : bool = Fable.Core.RustInterop.emitRustExpr v673 v683 
            let v685 : string = "x"
            let v686 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v685 
            let v687 : string = $"near_sdk::log!(\"{{}}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v686 v687 
            let v688 : string = $"true;"
            let v689 : bool = Fable.Core.RustInterop.emitRustExpr () v688 
            let v690 : string = "true; }}); { //"
            let v691 : bool = Fable.Core.RustInterop.emitRustExpr () v690 
            ()
        let _v641 = () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        v640 v639
        let _v641 = () 
        #endif
#if FABLE_COMPILER_PYTHON
        v640 v639
        let _v641 = () 
        #endif
#else
        v640 v639
        let _v641 = () 
        #endif
        _v641 
        let v692 : (string -> unit) = v17.l0
        v692 v639
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
    let v1067 : string = "fable_library_rust::String_::fromString($0)"
    let v1068 : string = Fable.Core.RustInterop.emitRustExpr v136 v1067 
    let v1069 : int32 = v1068.Length
    let v1070 : bool = v1069 > 0
    let v1092 : bool =
        if v1070 then
            let v1071 : bool = v1069 < 64
            if v1071 then
                let v1072 : string = "-"
                let v1073 : bool = v1068.StartsWith v1072 
                let v1076 : bool = v1073 = false
                if v1076 then
                    let v1077 : bool = v1068.EndsWith v1072 
                    let v1078 : bool = v1077 = false
                    if v1078 then
                        let v1079 : string = "&*$0"
                        let v1080 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1068 v1079 
                        let v1081 : string = $"$0.chars()"
                        let v1082 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v1080 v1081 
                        let v1083 : string = "true; // 1"
                        let v1084 : bool = Fable.Core.RustInterop.emitRustExpr () v1083 
                        let v1085 : string = "let mut v1082 = v1082"
                        Fable.Core.RustInterop.emitRustExpr () v1085 
                        let v1086 : string = $"v1082.all(|x| $0(x))"
                        let v1087 : (char -> bool) = closure1()
                        let v1088 : bool = Fable.Core.RustInterop.emitRustExpr v1087 v1086 
                        v1088
                    else
                        false
                else
                    false
            else
                false
        else
            false
    let v1093 : bool = v1092 = false
    let v1097 : bool =
        if v1093 then
            let v1094 : string = $"true; near_sdk::env::panic_str(&*$0); //"
            let v1095 : string = "chat_contract.claim_alias / invalid alias"
            let v1096 : bool = Fable.Core.RustInterop.emitRustExpr v1095 v1094 
            true
        else
            false
    let v1098 : string = $"v138.get(&$0)"
    let v1099 : Ref<std_string_String> option = Fable.Core.RustInterop.emitRustExpr v142 v1098 
    let v1100 : string = "$0.cloned()"
    let v1101 : std_string_String option = Fable.Core.RustInterop.emitRustExpr v1099 v1100 
    let v1102 : US4 option = None
    let _v1102 = ref v1102 
    let v1103 : US4 option ref = _v1102 
    let v1104 : (US4 option -> US4 option ref) = closure13(v1103)
    let v1105 : unit = ()
    let v1106 : (unit -> unit) = closure14(v1101, v1104)
    let v1107 : unit = (fun () -> v1106 (); v1105) ()
    let v1110 : US4 option = _v1102.Value 
    let v1121 : US4 = US4_1
    let v1122 : US4 = v1110 |> Option.defaultValue v1121 
    match v1122 with
    | US4_0(v1126) -> (* Some *)
        let v1127 : bool = v1126 = v136 
        if v1127 then
            let v1130 : unit = ()
            let v1131 : (unit -> unit) = closure15(v1126)
            let v1132 : unit = (fun () -> v1131 (); v1130) ()
            ()
        else
            let v1932 : unit = ()
            let v1933 : (unit -> unit) = closure16(v1101)
            let v1934 : unit = (fun () -> v1933 (); v1932) ()
            let v2734 : string = "    v140 //"
            Fable.Core.RustInterop.emitRustExpr () v2734 
            let v2735 : string = "      .get_mut(&v1126) //"
            Fable.Core.RustInterop.emitRustExpr () v2735 
            let v2736 : string = "      .unwrap() //"
            Fable.Core.RustInterop.emitRustExpr () v2736 
            let v2737 : string = "      .remove(&$0); //"
            Fable.Core.RustInterop.emitRustExpr v142 v2737 
            let v2738 : string = "  v138.insert($0.clone(), v136.clone()); //"
            Fable.Core.RustInterop.emitRustExpr v142 v2738 
            let v2739 : string = "  let new_alias_account_map = match v140.get(&v136) { //"
            Fable.Core.RustInterop.emitRustExpr () v2739 
            let v2740 : string = "    None => { //"
            Fable.Core.RustInterop.emitRustExpr () v2740 
            let v2741 : string = "      let mut new_map = std::collections::HashMap::new(); //"
            Fable.Core.RustInterop.emitRustExpr () v2741 
            let v2742 : string = "      new_map.insert($0, ($1, 0u32)); //"
            Fable.Core.RustInterop.emitRustExpr struct (v142, v144) v2742 
            let v2743 : string = "      new_map //"
            Fable.Core.RustInterop.emitRustExpr () v2743 
            let v2744 : string = "    } //"
            Fable.Core.RustInterop.emitRustExpr () v2744 
            let v2745 : string = "    Some(accounts) => { //"
            Fable.Core.RustInterop.emitRustExpr () v2745 
            let v2746 : string = "      let mut accounts_vec = accounts.iter().collect::<Vec<_>>(); //"
            Fable.Core.RustInterop.emitRustExpr () v2746 
            let v2747 : string = "      accounts_vec.sort_unstable_by_key(|(_, (_, index))| index); //"
            Fable.Core.RustInterop.emitRustExpr () v2747 
            let v2748 : string = "      let mut new_map = accounts_vec //"
            Fable.Core.RustInterop.emitRustExpr () v2748 
            let v2749 : string = "        .iter() //"
            Fable.Core.RustInterop.emitRustExpr () v2749 
            let v2750 : string = "        .enumerate() //"
            Fable.Core.RustInterop.emitRustExpr () v2750 
            let v2751 : string = "        .map(|(i, (account_id, (timestamp, _)))| { //"
            Fable.Core.RustInterop.emitRustExpr () v2751 
            let v2752 : string = "          ((*account_id).clone(), (*timestamp, i as u32)) //"
            Fable.Core.RustInterop.emitRustExpr () v2752 
            let v2753 : string = "        }) //"
            Fable.Core.RustInterop.emitRustExpr () v2753 
            let v2754 : string = "        .collect::<std::collections::HashMap<_, _>>(); //"
            Fable.Core.RustInterop.emitRustExpr () v2754 
            let v2755 : string = "      new_map.insert(v142, (v144, accounts_vec.len() as u32)); //"
            Fable.Core.RustInterop.emitRustExpr () v2755 
            let v2756 : string = "      new_map //"
            Fable.Core.RustInterop.emitRustExpr () v2756 
            let v2757 : string = "    } //"
            Fable.Core.RustInterop.emitRustExpr () v2757 
            let v2758 : string = "  }; //"
            Fable.Core.RustInterop.emitRustExpr () v2758 
            let v2759 : string = "  v140.insert(v136, new_alias_account_map); //"
            Fable.Core.RustInterop.emitRustExpr () v2759 
            ()
    | _ ->
        let v2760 : unit = ()
        let v2761 : (unit -> unit) = closure16(v1101)
        let v2762 : unit = (fun () -> v2761 (); v2760) ()
        match v1122 with
        | US4_1 -> (* None *)
            ()
        let v3562 : string = "  v138.insert($0.clone(), v136.clone()); //"
        Fable.Core.RustInterop.emitRustExpr v142 v3562 
        let v3563 : string = "  let new_alias_account_map = match v140.get(&v136) { //"
        Fable.Core.RustInterop.emitRustExpr () v3563 
        let v3564 : string = "    None => { //"
        Fable.Core.RustInterop.emitRustExpr () v3564 
        let v3565 : string = "      let mut new_map = std::collections::HashMap::new(); //"
        Fable.Core.RustInterop.emitRustExpr () v3565 
        let v3566 : string = "      new_map.insert($0, ($1, 0u32)); //"
        Fable.Core.RustInterop.emitRustExpr struct (v142, v144) v3566 
        let v3567 : string = "      new_map //"
        Fable.Core.RustInterop.emitRustExpr () v3567 
        let v3568 : string = "    } //"
        Fable.Core.RustInterop.emitRustExpr () v3568 
        let v3569 : string = "    Some(accounts) => { //"
        Fable.Core.RustInterop.emitRustExpr () v3569 
        let v3570 : string = "      let mut accounts_vec = accounts.iter().collect::<Vec<_>>(); //"
        Fable.Core.RustInterop.emitRustExpr () v3570 
        let v3571 : string = "      accounts_vec.sort_unstable_by_key(|(_, (_, index))| index); //"
        Fable.Core.RustInterop.emitRustExpr () v3571 
        let v3572 : string = "      let mut new_map = accounts_vec //"
        Fable.Core.RustInterop.emitRustExpr () v3572 
        let v3573 : string = "        .iter() //"
        Fable.Core.RustInterop.emitRustExpr () v3573 
        let v3574 : string = "        .enumerate() //"
        Fable.Core.RustInterop.emitRustExpr () v3574 
        let v3575 : string = "        .map(|(i, (account_id, (timestamp, _)))| { //"
        Fable.Core.RustInterop.emitRustExpr () v3575 
        let v3576 : string = "          ((*account_id).clone(), (*timestamp, i as u32)) //"
        Fable.Core.RustInterop.emitRustExpr () v3576 
        let v3577 : string = "        }) //"
        Fable.Core.RustInterop.emitRustExpr () v3577 
        let v3578 : string = "        .collect::<std::collections::HashMap<_, _>>(); //"
        Fable.Core.RustInterop.emitRustExpr () v3578 
        let v3579 : string = "      new_map.insert(v142, (v144, accounts_vec.len() as u32)); //"
        Fable.Core.RustInterop.emitRustExpr () v3579 
        let v3580 : string = "      new_map //"
        Fable.Core.RustInterop.emitRustExpr () v3580 
        let v3581 : string = "    } //"
        Fable.Core.RustInterop.emitRustExpr () v3581 
        let v3582 : string = "  }; //"
        Fable.Core.RustInterop.emitRustExpr () v3582 
        let v3583 : string = "  v140.insert(v136, new_alias_account_map); //"
        Fable.Core.RustInterop.emitRustExpr () v3583 
        ()
    let v3584 : unit = ()
    let v3585 : (unit -> unit) = closure17()
    let v3586 : unit = (fun () -> v3585 (); v3584) ()
    let v4280 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v4280 
    let v4281 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v4281 
    let v4282 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v4282 
    let v4283 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v4283 
    let v4284 : string = "true; // ??? / i: 5uy / i': 1uy / acc: 6uy / n: 3uy"
    let v4285 : bool = Fable.Core.RustInterop.emitRustExpr () v4284 
    let v4286 : string = "true; */ // ???? / i: 5uy / i': 2uy / acc: 6uy / n: 3uy"
    let v4287 : bool = Fable.Core.RustInterop.emitRustExpr () v4286 
    let v4288 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v4288 
    let v4289 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v4289 
    let v4290 : string = "pub fn get_account_info( //"
    Fable.Core.RustInterop.emitRustExpr () v4290 
    let v4291 : string = "  &self, //"
    Fable.Core.RustInterop.emitRustExpr () v4291 
    let v4292 : string = "  account_id: near_sdk::AccountId, //"
    Fable.Core.RustInterop.emitRustExpr () v4292 
    let v4293 : string = ") -> Option<(String, (u64, u32))> { //"
    Fable.Core.RustInterop.emitRustExpr () v4293 
    let v4294 : string = $"&self.0.2"
    let v4295 : Ref<near_sdk_store_LookupMap<near_sdk_AccountId, std_string_String>> = Fable.Core.RustInterop.emitRustExpr () v4294 
    let v4296 : string = $"&self.0.1"
    let v4297 : Ref<near_sdk_store_LookupMap<std_string_String, std_collections_HashMap<near_sdk_AccountId, struct (uint64 * uint32)>>> = Fable.Core.RustInterop.emitRustExpr () v4296 
    let v4298 : string = $"account_id"
    let v4299 : near_sdk_AccountId = Fable.Core.RustInterop.emitRustExpr () v4298 
    let v4300 : unit = ()
    let v4301 : (unit -> unit) = closure18(v4299)
    let v4302 : unit = (fun () -> v4301 (); v4300) ()
    let v5126 : unit = ()
    let v5127 : (unit -> unit) = closure19()
    let v5128 : unit = (fun () -> v5127 (); v5126) ()
    let v5822 : string = "  v4295.get(&$0).and_then(|alias| { //"
    Fable.Core.RustInterop.emitRustExpr v4299 v5822 
    let v5823 : string = "    v4297 //"
    Fable.Core.RustInterop.emitRustExpr () v5823 
    let v5824 : string = "      .get(alias) //"
    Fable.Core.RustInterop.emitRustExpr () v5824 
    let v5825 : string = "      .map(|accounts| (alias.clone(), *accounts.get(&v4299).unwrap())) //"
    Fable.Core.RustInterop.emitRustExpr () v5825 
    let v5826 : string = "  }) //"
    Fable.Core.RustInterop.emitRustExpr () v5826 
    let v5827 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v5827 
    let v5828 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v5828 
    let v5829 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v5829 
    let v5830 : string = "true; // ??? / i: 6uy / i': 1uy / acc: 9uy / n: 2uy"
    let v5831 : bool = Fable.Core.RustInterop.emitRustExpr () v5830 
    let v5832 : string = "true; */ // ???? / i: 6uy / i': 2uy / acc: 9uy / n: 2uy"
    let v5833 : bool = Fable.Core.RustInterop.emitRustExpr () v5832 
    let v5834 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v5834 
    let v5835 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v5835 
    let v5836 : string = "pub fn get_alias_map( //"
    Fable.Core.RustInterop.emitRustExpr () v5836 
    let v5837 : string = "  &self, //"
    Fable.Core.RustInterop.emitRustExpr () v5837 
    let v5838 : string = "  alias: String, //"
    Fable.Core.RustInterop.emitRustExpr () v5838 
    let v5839 : string = ") -> Option<std::collections::HashMap<near_sdk::AccountId, (u64, u32)>> { //"
    Fable.Core.RustInterop.emitRustExpr () v5839 
    let v5840 : string = $"&self.0.1"
    let v5841 : Ref<near_sdk_store_LookupMap<std_string_String, std_collections_HashMap<near_sdk_AccountId, struct (uint64 * uint32)>>> = Fable.Core.RustInterop.emitRustExpr () v5840 
    let v5842 : string = $"alias"
    let v5843 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v5842 
    let v5844 : unit = ()
    let v5845 : (unit -> unit) = closure20(v5843)
    let v5846 : unit = (fun () -> v5845 (); v5844) ()
    let v6670 : unit = ()
    let v6671 : (unit -> unit) = closure21()
    let v6672 : unit = (fun () -> v6671 (); v6670) ()
    let v7366 : string = "  v5841.get(&$0).cloned() //"
    Fable.Core.RustInterop.emitRustExpr v5843 v7366 
    let v7367 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v7367 
    let v7368 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v7368 
    let v7369 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v7369 
    let v7370 : string = "true; // ??? / i: 7uy / i': 1uy / acc: 11uy / n: 2uy"
    let v7371 : bool = Fable.Core.RustInterop.emitRustExpr () v7370 
    let v7372 : string = "true; */ // ???? / i: 7uy / i': 2uy / acc: 11uy / n: 2uy"
    let v7373 : bool = Fable.Core.RustInterop.emitRustExpr () v7372 
    let v7374 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v7374 
    let v7375 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v7375 
    let v7376 : string = "#[result_serializer(borsh)] //"
    Fable.Core.RustInterop.emitRustExpr () v7376 
    let v7377 : string = "pub fn get_alias_map_borsh( //"
    Fable.Core.RustInterop.emitRustExpr () v7377 
    let v7378 : string = "  &self, //"
    Fable.Core.RustInterop.emitRustExpr () v7378 
    let v7379 : string = "  #[serializer(borsh)] alias: String, //"
    Fable.Core.RustInterop.emitRustExpr () v7379 
    let v7380 : string = ") -> Option<std::collections::HashMap<near_sdk::AccountId, (u64, u32)>> { //"
    Fable.Core.RustInterop.emitRustExpr () v7380 
    let v7381 : string = "  self.get_alias_map(alias) //"
    Fable.Core.RustInterop.emitRustExpr () v7381 
    let v7382 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v7382 
    let v7383 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v7383 
    let v7384 : string = "true; // ??? / i: 8uy / i': 1uy / acc: 13uy / n: 1uy"
    let v7385 : bool = Fable.Core.RustInterop.emitRustExpr () v7384 
    let v7386 : string = "true; */ // ???? / i: 8uy / i': 2uy / acc: 13uy / n: 1uy"
    let v7387 : bool = Fable.Core.RustInterop.emitRustExpr () v7386 
    let v7388 : string = "fn _main() //"
    Fable.Core.RustInterop.emitRustExpr () v7388 
    let v7389 : string = "{ //"
    Fable.Core.RustInterop.emitRustExpr () v7389 
    let v7390 : string = "true; { (); // ?? / i': 1uy / n: 14uy"
    let v7391 : bool = Fable.Core.RustInterop.emitRustExpr () v7390 
    let v7392 : string = "true; { (); // ?? / i': 2uy / n: 14uy"
    let v7393 : bool = Fable.Core.RustInterop.emitRustExpr () v7392 
    let v7394 : string = "true; { (); // ?? / i': 3uy / n: 14uy"
    let v7395 : bool = Fable.Core.RustInterop.emitRustExpr () v7394 
    let v7396 : string = "true; { (); // ?? / i': 4uy / n: 14uy"
    let v7397 : bool = Fable.Core.RustInterop.emitRustExpr () v7396 
    let v7398 : string = "true; { (); // ?? / i': 5uy / n: 14uy"
    let v7399 : bool = Fable.Core.RustInterop.emitRustExpr () v7398 
    let v7400 : string = "true; { (); // ?? / i': 6uy / n: 14uy"
    let v7401 : bool = Fable.Core.RustInterop.emitRustExpr () v7400 
    let v7402 : string = "true; { (); // ?? / i': 7uy / n: 14uy"
    let v7403 : bool = Fable.Core.RustInterop.emitRustExpr () v7402 
    let v7404 : string = "true; { (); // ?? / i': 8uy / n: 14uy"
    let v7405 : bool = Fable.Core.RustInterop.emitRustExpr () v7404 
    let v7406 : string = "true; { (); // ?? / i': 9uy / n: 14uy"
    let v7407 : bool = Fable.Core.RustInterop.emitRustExpr () v7406 
    let v7408 : string = "true; { (); // ?? / i': 10uy / n: 14uy"
    let v7409 : bool = Fable.Core.RustInterop.emitRustExpr () v7408 
    let v7410 : string = "true; { (); // ?? / i': 11uy / n: 14uy"
    let v7411 : bool = Fable.Core.RustInterop.emitRustExpr () v7410 
    let v7412 : string = "true; { (); // ?? / i': 12uy / n: 14uy"
    let v7413 : bool = Fable.Core.RustInterop.emitRustExpr () v7412 
    let v7414 : string = "true; { (); // ?? / i': 13uy / n: 14uy"
    let v7415 : bool = Fable.Core.RustInterop.emitRustExpr () v7414 
    let v7416 : string = "true; { (); // ?? / i': 14uy / n: 14uy"
    let v7417 : bool = Fable.Core.RustInterop.emitRustExpr () v7416 
    let v7418 : string = "true; { { (); // ? / i': 15uy / n: 14uy"
    let v7419 : bool = Fable.Core.RustInterop.emitRustExpr () v7418 
    ()
let v0 : (unit -> unit) = closure0()
v0 |> ignore
()
