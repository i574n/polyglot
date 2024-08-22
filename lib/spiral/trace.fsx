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
    let v0 : string = "("
    v0
and method8 () : string =
    let v0 : string = " "
    v0
and method9 () : string =
    let v0 : string = ""
    v0
and closure11 (v0 : Mut4, v1 : string) () : unit =
    let v2 : string = v0.l0
    let v3 : string = v2 + v1 
    v0.l0 <- v3
    ()
and method10 () : string =
    let v0 : string = "\u001b[0m"
    v0
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
    let struct (v18 : Mut0, v19 : Mut1, v20 : Mut2, v21 : Mut3, v22 : int64 option) = State.trace_state.Value
    let v33 : unit = ()
    let v34 : unit = (fun () -> v4 (); v33) ()
    let struct (v47 : Mut0, v48 : Mut1, v49 : Mut2, v50 : Mut3, v51 : int64 option) = State.trace_state.Value
    let v62 : US0 = v50.l0
    let v63 : bool = v49.l0
    let v64 : bool = v63 = false
    let v68 : bool =
        if v64 then
            false
        else
            let v65 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v0
            let v66 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v62
            let v67 : bool = v65 >= v66
            v67
    if v68 then
        let v69 : unit = ()
        let v70 : (unit -> unit) = closure8(v18)
        let v71 : unit = (fun () -> v70 (); v69) ()
        let v74 : unit = ()
        let v75 : unit = (fun () -> v4 (); v74) ()
        let struct (v88 : Mut0, v89 : Mut1, v90 : Mut2, v91 : Mut3, v92 : int64 option) = State.trace_state.Value
        let v103 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v104 : US3 option = None
        let _v104 = ref v104 
        let v105 : US3 option ref = _v104 
        let v106 : (US3 option -> US3 option ref) = closure9(v105)
        let v107 : unit = ()
        let v108 : (unit -> unit) = closure10(v92, v106)
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
        let v174 : (US3 option -> US3 option ref) = closure9(v173)
        let v175 : unit = ()
        let v176 : (unit -> unit) = closure10(v92, v174)
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
        let v244 : (US3 option -> US3 option ref) = closure9(v243)
        let v245 : unit = ()
        let v246 : (unit -> unit) = closure10(v92, v244)
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
        let v284 : (US3 option -> US3 option ref) = closure9(v283)
        let v285 : unit = ()
        let v286 : (unit -> unit) = closure10(v92, v284)
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
        let v352 : (US3 option -> US3 option ref) = closure9(v351)
        let v353 : unit = ()
        let v354 : (unit -> unit) = closure10(v92, v352)
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
        let v420 : (US3 option -> US3 option ref) = closure9(v419)
        let v421 : unit = ()
        let v422 : (unit -> unit) = closure10(v92, v420)
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
        
        
        
        
        
        let v556 : bool =
            match v0 with
            | US0_0 -> (* Verbose *)
                true
            | _ ->
                false
        let v614 : US1 =
            if v556 then
                let v557 : string = "Verbose"
                US1_0(v557)
            else
                let v559 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v560 : string = method7()
                let _v559 = v560 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v561 : string = method7()
                let _v559 = v561 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v562 : string = method7()
                let _v559 = v562 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v563 : string = method8()
                let _v559 = v563 
                #endif
#if FABLE_COMPILER_PYTHON
                let v564 : string = method8()
                let _v559 = v564 
                #endif
#else
                let v565 : string = method8()
                let _v559 = v565 
                #endif
                let v566 : string = _v559 
                let v571 : string = method9()
                let v572 : Mut4 = {l0 = v571} : Mut4
                let v573 : US0 = US0_0
                let v574 : string = $"%A{v573}"
                let v578 : string = $"{v574}"
                let v581 : unit = ()
                let v582 : (unit -> unit) = closure11(v572, v578)
                let v583 : unit = (fun () -> v582 (); v581) ()
                let v586 : string = v572.l0
                let v587 : (string []) = v586.Split v566 
                let v590 : string = v587.[int 0]
                let v593 : string = method9()
                let v594 : Mut4 = {l0 = v593} : Mut4
                let v595 : string = $"%A{v0}"
                let v598 : string = $"{v595}"
                let v601 : unit = ()
                let v602 : (unit -> unit) = closure11(v594, v598)
                let v603 : unit = (fun () -> v602 (); v601) ()
                let v606 : string = v594.l0
                let v607 : bool = v606.StartsWith v590 
                if v607 then
                    let v610 : string = "Verbose"
                    US1_0(v610)
                else
                    US1_1
        let v871 : US1 =
            match v614 with
            | US1_1 -> (* None *)
                let v617 : bool =
                    match v0 with
                    | US0_1 -> (* Debug *)
                        true
                    | _ ->
                        false
                let v675 : US1 =
                    if v617 then
                        let v618 : string = "Debug"
                        US1_0(v618)
                    else
                        let v620 : unit = ()
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v621 : string = method7()
                        let _v620 = v621 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        let v622 : string = method7()
                        let _v620 = v622 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        let v623 : string = method7()
                        let _v620 = v623 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        let v624 : string = method8()
                        let _v620 = v624 
                        #endif
#if FABLE_COMPILER_PYTHON
                        let v625 : string = method8()
                        let _v620 = v625 
                        #endif
#else
                        let v626 : string = method8()
                        let _v620 = v626 
                        #endif
                        let v627 : string = _v620 
                        let v632 : string = method9()
                        let v633 : Mut4 = {l0 = v632} : Mut4
                        let v634 : US0 = US0_1
                        let v635 : string = $"%A{v634}"
                        let v639 : string = $"{v635}"
                        let v642 : unit = ()
                        let v643 : (unit -> unit) = closure11(v633, v639)
                        let v644 : unit = (fun () -> v643 (); v642) ()
                        let v647 : string = v633.l0
                        let v648 : (string []) = v647.Split v627 
                        let v651 : string = v648.[int 0]
                        let v654 : string = method9()
                        let v655 : Mut4 = {l0 = v654} : Mut4
                        let v656 : string = $"%A{v0}"
                        let v659 : string = $"{v656}"
                        let v662 : unit = ()
                        let v663 : (unit -> unit) = closure11(v655, v659)
                        let v664 : unit = (fun () -> v663 (); v662) ()
                        let v667 : string = v655.l0
                        let v668 : bool = v667.StartsWith v651 
                        if v668 then
                            let v671 : string = "Debug"
                            US1_0(v671)
                        else
                            US1_1
                match v675 with
                | US1_1 -> (* None *)
                    let v678 : bool =
                        match v0 with
                        | US0_2 -> (* Info *)
                            true
                        | _ ->
                            false
                    let v736 : US1 =
                        if v678 then
                            let v679 : string = "Info"
                            US1_0(v679)
                        else
                            let v681 : unit = ()
                            
#if FABLE_COMPILER || WASM || CONTRACT
                            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                            let v682 : string = method7()
                            let _v681 = v682 
                            #endif
#if FABLE_COMPILER_RUST && WASM
                            let v683 : string = method7()
                            let _v681 = v683 
                            #endif
#if FABLE_COMPILER_RUST && CONTRACT
                            let v684 : string = method7()
                            let _v681 = v684 
                            #endif
#if FABLE_COMPILER_TYPESCRIPT
                            let v685 : string = method8()
                            let _v681 = v685 
                            #endif
#if FABLE_COMPILER_PYTHON
                            let v686 : string = method8()
                            let _v681 = v686 
                            #endif
#else
                            let v687 : string = method8()
                            let _v681 = v687 
                            #endif
                            let v688 : string = _v681 
                            let v693 : string = method9()
                            let v694 : Mut4 = {l0 = v693} : Mut4
                            let v695 : US0 = US0_2
                            let v696 : string = $"%A{v695}"
                            let v700 : string = $"{v696}"
                            let v703 : unit = ()
                            let v704 : (unit -> unit) = closure11(v694, v700)
                            let v705 : unit = (fun () -> v704 (); v703) ()
                            let v708 : string = v694.l0
                            let v709 : (string []) = v708.Split v688 
                            let v712 : string = v709.[int 0]
                            let v715 : string = method9()
                            let v716 : Mut4 = {l0 = v715} : Mut4
                            let v717 : string = $"%A{v0}"
                            let v720 : string = $"{v717}"
                            let v723 : unit = ()
                            let v724 : (unit -> unit) = closure11(v716, v720)
                            let v725 : unit = (fun () -> v724 (); v723) ()
                            let v728 : string = v716.l0
                            let v729 : bool = v728.StartsWith v712 
                            if v729 then
                                let v732 : string = "Info"
                                US1_0(v732)
                            else
                                US1_1
                    match v736 with
                    | US1_1 -> (* None *)
                        let v739 : bool =
                            match v0 with
                            | US0_3 -> (* Warning *)
                                true
                            | _ ->
                                false
                        let v797 : US1 =
                            if v739 then
                                let v740 : string = "Warning"
                                US1_0(v740)
                            else
                                let v742 : unit = ()
                                
#if FABLE_COMPILER || WASM || CONTRACT
                                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                let v743 : string = method7()
                                let _v742 = v743 
                                #endif
#if FABLE_COMPILER_RUST && WASM
                                let v744 : string = method7()
                                let _v742 = v744 
                                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                                let v745 : string = method7()
                                let _v742 = v745 
                                #endif
#if FABLE_COMPILER_TYPESCRIPT
                                let v746 : string = method8()
                                let _v742 = v746 
                                #endif
#if FABLE_COMPILER_PYTHON
                                let v747 : string = method8()
                                let _v742 = v747 
                                #endif
#else
                                let v748 : string = method8()
                                let _v742 = v748 
                                #endif
                                let v749 : string = _v742 
                                let v754 : string = method9()
                                let v755 : Mut4 = {l0 = v754} : Mut4
                                let v756 : US0 = US0_3
                                let v757 : string = $"%A{v756}"
                                let v761 : string = $"{v757}"
                                let v764 : unit = ()
                                let v765 : (unit -> unit) = closure11(v755, v761)
                                let v766 : unit = (fun () -> v765 (); v764) ()
                                let v769 : string = v755.l0
                                let v770 : (string []) = v769.Split v749 
                                let v773 : string = v770.[int 0]
                                let v776 : string = method9()
                                let v777 : Mut4 = {l0 = v776} : Mut4
                                let v778 : string = $"%A{v0}"
                                let v781 : string = $"{v778}"
                                let v784 : unit = ()
                                let v785 : (unit -> unit) = closure11(v777, v781)
                                let v786 : unit = (fun () -> v785 (); v784) ()
                                let v789 : string = v777.l0
                                let v790 : bool = v789.StartsWith v773 
                                if v790 then
                                    let v793 : string = "Warning"
                                    US1_0(v793)
                                else
                                    US1_1
                        match v797 with
                        | US1_1 -> (* None *)
                            let v800 : bool =
                                match v0 with
                                | US0_4 -> (* Critical *)
                                    true
                                | _ ->
                                    false
                            let v858 : US1 =
                                if v800 then
                                    let v801 : string = "Critical"
                                    US1_0(v801)
                                else
                                    let v803 : unit = ()
                                    
#if FABLE_COMPILER || WASM || CONTRACT
                                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                    let v804 : string = method7()
                                    let _v803 = v804 
                                    #endif
#if FABLE_COMPILER_RUST && WASM
                                    let v805 : string = method7()
                                    let _v803 = v805 
                                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                                    let v806 : string = method7()
                                    let _v803 = v806 
                                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                                    let v807 : string = method8()
                                    let _v803 = v807 
                                    #endif
#if FABLE_COMPILER_PYTHON
                                    let v808 : string = method8()
                                    let _v803 = v808 
                                    #endif
#else
                                    let v809 : string = method8()
                                    let _v803 = v809 
                                    #endif
                                    let v810 : string = _v803 
                                    let v815 : string = method9()
                                    let v816 : Mut4 = {l0 = v815} : Mut4
                                    let v817 : US0 = US0_4
                                    let v818 : string = $"%A{v817}"
                                    let v822 : string = $"{v818}"
                                    let v825 : unit = ()
                                    let v826 : (unit -> unit) = closure11(v816, v822)
                                    let v827 : unit = (fun () -> v826 (); v825) ()
                                    let v830 : string = v816.l0
                                    let v831 : (string []) = v830.Split v810 
                                    let v834 : string = v831.[int 0]
                                    let v837 : string = method9()
                                    let v838 : Mut4 = {l0 = v837} : Mut4
                                    let v839 : string = $"%A{v0}"
                                    let v842 : string = $"{v839}"
                                    let v845 : unit = ()
                                    let v846 : (unit -> unit) = closure11(v838, v842)
                                    let v847 : unit = (fun () -> v846 (); v845) ()
                                    let v850 : string = v838.l0
                                    let v851 : bool = v850.StartsWith v834 
                                    if v851 then
                                        let v854 : string = "Critical"
                                        US1_0(v854)
                                    else
                                        US1_1
                            match v858 with
                            | US1_1 -> (* None *)
                                US1_1
                            | US1_0(v859) -> (* Some *)
                                US1_0(v859)
                        | US1_0(v798) -> (* Some *)
                            US1_0(v798)
                    | US1_0(v737) -> (* Some *)
                        US1_0(v737)
                | US1_0(v676) -> (* Some *)
                    US1_0(v676)
            | US1_0(v615) -> (* Some *)
                US1_0(v615)
        let v875 : string =
            match v871 with
            | US1_1 -> (* None *)
                failwith<string> "Option does not have a value."
            | US1_0(v872) -> (* Some *)
                v872
        let v876 : (unit -> string) = v875.ToLower
        let v877 : string = v876 ()
        let v880 : string = v877.PadLeft (7, ' ')
        let v894 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v909 : Ref<Str> =
            match v0 with
            | US0_4 -> (* Critical *)
                let v903 : string = "inline_colorization::color_bright_red"
                let v904 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v903 
                v904
            | US0_1 -> (* Debug *)
                let v897 : string = "inline_colorization::color_bright_blue"
                let v898 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v897 
                v898
            | US0_2 -> (* Info *)
                let v899 : string = "inline_colorization::color_bright_green"
                let v900 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v899 
                v900
            | US0_0 -> (* Verbose *)
                let v895 : string = "inline_colorization::color_bright_black"
                let v896 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v895 
                v896
            | US0_3 -> (* Warning *)
                let v901 : string = "inline_colorization::color_yellow"
                let v902 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v901 
                v902
        let v910 : string = "&*$0"
        let v911 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v880 v910 
        let v912 : string = "inline_colorization::color_reset"
        let v913 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v912 
        let v914 : string = "\"{v909}{v911}{v913}\""
        let v915 : string = @$"format!(" + v914 + ")"
        let v916 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v915 
        let v917 : string = "fable_library_rust::String_::fromString($0)"
        let v918 : string = Fable.Core.RustInterop.emitRustExpr v916 v917 
        let _v894 = v918 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v933 : Ref<Str> =
            match v0 with
            | US0_4 -> (* Critical *)
                let v927 : string = "inline_colorization::color_bright_red"
                let v928 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v927 
                v928
            | US0_1 -> (* Debug *)
                let v921 : string = "inline_colorization::color_bright_blue"
                let v922 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v921 
                v922
            | US0_2 -> (* Info *)
                let v923 : string = "inline_colorization::color_bright_green"
                let v924 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v923 
                v924
            | US0_0 -> (* Verbose *)
                let v919 : string = "inline_colorization::color_bright_black"
                let v920 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v919 
                v920
            | US0_3 -> (* Warning *)
                let v925 : string = "inline_colorization::color_yellow"
                let v926 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v925 
                v926
        let v934 : string = "&*$0"
        let v935 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v880 v934 
        let v936 : string = "inline_colorization::color_reset"
        let v937 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v936 
        let v938 : string = "\"{v933}{v935}{v937}\""
        let v939 : string = @$"format!(" + v938 + ")"
        let v940 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v939 
        let v941 : string = "fable_library_rust::String_::fromString($0)"
        let v942 : string = Fable.Core.RustInterop.emitRustExpr v940 v941 
        let _v894 = v942 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v957 : Ref<Str> =
            match v0 with
            | US0_4 -> (* Critical *)
                let v951 : string = "inline_colorization::color_bright_red"
                let v952 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v951 
                v952
            | US0_1 -> (* Debug *)
                let v945 : string = "inline_colorization::color_bright_blue"
                let v946 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v945 
                v946
            | US0_2 -> (* Info *)
                let v947 : string = "inline_colorization::color_bright_green"
                let v948 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v947 
                v948
            | US0_0 -> (* Verbose *)
                let v943 : string = "inline_colorization::color_bright_black"
                let v944 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v943 
                v944
            | US0_3 -> (* Warning *)
                let v949 : string = "inline_colorization::color_yellow"
                let v950 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v949 
                v950
        let v958 : string = "&*$0"
        let v959 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v880 v958 
        let v960 : string = "inline_colorization::color_reset"
        let v961 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v960 
        let v962 : string = "\"{v957}{v959}{v961}\""
        let v963 : string = @$"format!(" + v962 + ")"
        let v964 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v963 
        let v965 : string = "fable_library_rust::String_::fromString($0)"
        let v966 : string = Fable.Core.RustInterop.emitRustExpr v964 v965 
        let _v894 = v966 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v976 : string =
            match v0 with
            | US0_4 -> (* Critical *)
                let v971 : string = "\u001b[91m"
                v971
            | US0_1 -> (* Debug *)
                let v968 : string = "\u001b[94m"
                v968
            | US0_2 -> (* Info *)
                let v969 : string = "\u001b[92m"
                v969
            | US0_0 -> (* Verbose *)
                let v967 : string = "\u001b[90m"
                v967
            | US0_3 -> (* Warning *)
                let v970 : string = "\u001b[93m"
                v970
        let v977 : string = method10()
        let v978 : string = v976 + v880 
        let v979 : string = v978 + v977 
        let _v894 = v979 
        #endif
#if FABLE_COMPILER_PYTHON
        let v989 : string =
            match v0 with
            | US0_4 -> (* Critical *)
                let v984 : string = "\u001b[91m"
                v984
            | US0_1 -> (* Debug *)
                let v981 : string = "\u001b[94m"
                v981
            | US0_2 -> (* Info *)
                let v982 : string = "\u001b[92m"
                v982
            | US0_0 -> (* Verbose *)
                let v980 : string = "\u001b[90m"
                v980
            | US0_3 -> (* Warning *)
                let v983 : string = "\u001b[93m"
                v983
        let v990 : string = method10()
        let v991 : string = v989 + v880 
        let v992 : string = v991 + v990 
        let _v894 = v992 
        #endif
#else
        let v1002 : string =
            match v0 with
            | US0_4 -> (* Critical *)
                let v997 : string = "\u001b[91m"
                v997
            | US0_1 -> (* Debug *)
                let v994 : string = "\u001b[94m"
                v994
            | US0_2 -> (* Info *)
                let v995 : string = "\u001b[92m"
                v995
            | US0_0 -> (* Verbose *)
                let v993 : string = "\u001b[90m"
                v993
            | US0_3 -> (* Warning *)
                let v996 : string = "\u001b[93m"
                v996
        let v1003 : string = method10()
        let v1004 : string = v1002 + v880 
        let v1005 : string = v1004 + v1003 
        let _v894 = v1005 
        #endif
        let v1006 : string = _v894 
        let v1021 : int64 = v88.l0
        let v1022 : string = v2 ()
        let v1023 : string = method9()
        let v1024 : Mut4 = {l0 = v1023} : Mut4
        let v1025 : string = $"{v1022}"
        let v1028 : unit = ()
        let v1029 : (unit -> unit) = closure11(v1024, v1025)
        let v1030 : unit = (fun () -> v1029 (); v1028) ()
        let v1033 : string = v1024.l0
        let v1034 : string = $"{v486} {v1006} #{v1021} %s{v1 ()} / {v1033}"
        let v1037 : char list = []
        let v1038 : (char list -> (char [])) = List.toArray
        let v1039 : (char []) = v1038 v1037
        let v1042 : string = v1034.TrimStart v1039 
        let v1060 : char list = []
        let v1061 : char list = '/' :: v1060 
        let v1064 : char list = ' ' :: v1061 
        let v1067 : (char list -> (char [])) = List.toArray
        let v1068 : (char []) = v1067 v1064
        let v1071 : string = v1042.TrimEnd v1068 
        let v1089 : (string -> unit) = closure12()
        let v1090 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v1091 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v1071 v1091 
        let _v1090 = () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v1092 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v1071 v1092 
        let _v1090 = () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v1093 : string = $"near_sdk::log!(\"{{}}\", $0)"
        Fable.Core.RustInterop.emitRustExpr v1071 v1093 
        let _v1090 = () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        v1089 v1071
        let _v1090 = () 
        #endif
#if FABLE_COMPILER_PYTHON
        v1089 v1071
        let _v1090 = () 
        #endif
#else
        v1089 v1071
        let _v1090 = () 
        #endif
        _v1090 
        let v1094 : (string -> unit) = v19.l0
        v1094 v1071
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
let v15 : (US0 -> ((unit -> string) -> ((unit -> string) -> unit))) = closure4()
let trace x = v15 x
()
