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
    let v0 : string = "\u001b[0m"
    v0
and method8 () : string =
    let v0 : string = ""
    v0
and closure11 (v0 : Mut4, v1 : string) () : unit =
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
        let v560 : US1 =
            if v556 then
                let v557 : string = "Verbose"
                US1_0(v557)
            else
                US1_1
        let v601 : US1 =
            match v560 with
            | US1_1 -> (* None *)
                let v563 : bool =
                    match v0 with
                    | US0_1 -> (* Debug *)
                        true
                    | _ ->
                        false
                let v567 : US1 =
                    if v563 then
                        let v564 : string = "Debug"
                        US1_0(v564)
                    else
                        US1_1
                match v567 with
                | US1_1 -> (* None *)
                    let v570 : bool =
                        match v0 with
                        | US0_2 -> (* Info *)
                            true
                        | _ ->
                            false
                    let v574 : US1 =
                        if v570 then
                            let v571 : string = "Info"
                            US1_0(v571)
                        else
                            US1_1
                    match v574 with
                    | US1_1 -> (* None *)
                        let v577 : bool =
                            match v0 with
                            | US0_3 -> (* Warning *)
                                true
                            | _ ->
                                false
                        let v581 : US1 =
                            if v577 then
                                let v578 : string = "Warning"
                                US1_0(v578)
                            else
                                US1_1
                        match v581 with
                        | US1_1 -> (* None *)
                            let v584 : bool =
                                match v0 with
                                | US0_4 -> (* Critical *)
                                    true
                                | _ ->
                                    false
                            let v588 : US1 =
                                if v584 then
                                    let v585 : string = "Critical"
                                    US1_0(v585)
                                else
                                    US1_1
                            match v588 with
                            | US1_1 -> (* None *)
                                US1_1
                            | US1_0(v589) -> (* Some *)
                                US1_0(v589)
                        | US1_0(v582) -> (* Some *)
                            US1_0(v582)
                    | US1_0(v575) -> (* Some *)
                        US1_0(v575)
                | US1_0(v568) -> (* Some *)
                    US1_0(v568)
            | US1_0(v561) -> (* Some *)
                US1_0(v561)
        let v605 : string =
            match v601 with
            | US1_1 -> (* None *)
                failwith<string> "Option does not have a value."
            | US1_0(v602) -> (* Some *)
                v602
        let v606 : (unit -> string) = v605.ToLower
        let v607 : string = v606 ()
        let v610 : string = v607.PadLeft (7, ' ')
        let v624 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v639 : Ref<Str> =
            match v0 with
            | US0_4 -> (* Critical *)
                let v633 : string = "inline_colorization::color_bright_red"
                let v634 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v633 
                v634
            | US0_1 -> (* Debug *)
                let v627 : string = "inline_colorization::color_bright_blue"
                let v628 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v627 
                v628
            | US0_2 -> (* Info *)
                let v629 : string = "inline_colorization::color_bright_green"
                let v630 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v629 
                v630
            | US0_0 -> (* Verbose *)
                let v625 : string = "inline_colorization::color_bright_black"
                let v626 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v625 
                v626
            | US0_3 -> (* Warning *)
                let v631 : string = "inline_colorization::color_yellow"
                let v632 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v631 
                v632
        let v640 : string = "&*$0"
        let v641 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v610 v640 
        let v642 : string = "inline_colorization::color_reset"
        let v643 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v642 
        let v644 : string = "\"{v639}{v641}{v643}\""
        let v645 : string = @$"format!(" + v644 + ")"
        let v646 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v645 
        let v647 : string = "fable_library_rust::String_::fromString($0)"
        let v648 : string = Fable.Core.RustInterop.emitRustExpr v646 v647 
        let _v624 = v648 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v663 : Ref<Str> =
            match v0 with
            | US0_4 -> (* Critical *)
                let v657 : string = "inline_colorization::color_bright_red"
                let v658 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v657 
                v658
            | US0_1 -> (* Debug *)
                let v651 : string = "inline_colorization::color_bright_blue"
                let v652 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v651 
                v652
            | US0_2 -> (* Info *)
                let v653 : string = "inline_colorization::color_bright_green"
                let v654 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v653 
                v654
            | US0_0 -> (* Verbose *)
                let v649 : string = "inline_colorization::color_bright_black"
                let v650 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v649 
                v650
            | US0_3 -> (* Warning *)
                let v655 : string = "inline_colorization::color_yellow"
                let v656 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v655 
                v656
        let v664 : string = "&*$0"
        let v665 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v610 v664 
        let v666 : string = "inline_colorization::color_reset"
        let v667 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v666 
        let v668 : string = "\"{v663}{v665}{v667}\""
        let v669 : string = @$"format!(" + v668 + ")"
        let v670 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v669 
        let v671 : string = "fable_library_rust::String_::fromString($0)"
        let v672 : string = Fable.Core.RustInterop.emitRustExpr v670 v671 
        let _v624 = v672 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v687 : Ref<Str> =
            match v0 with
            | US0_4 -> (* Critical *)
                let v681 : string = "inline_colorization::color_bright_red"
                let v682 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v681 
                v682
            | US0_1 -> (* Debug *)
                let v675 : string = "inline_colorization::color_bright_blue"
                let v676 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v675 
                v676
            | US0_2 -> (* Info *)
                let v677 : string = "inline_colorization::color_bright_green"
                let v678 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v677 
                v678
            | US0_0 -> (* Verbose *)
                let v673 : string = "inline_colorization::color_bright_black"
                let v674 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v673 
                v674
            | US0_3 -> (* Warning *)
                let v679 : string = "inline_colorization::color_yellow"
                let v680 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v679 
                v680
        let v688 : string = "&*$0"
        let v689 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v610 v688 
        let v690 : string = "inline_colorization::color_reset"
        let v691 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v690 
        let v692 : string = "\"{v687}{v689}{v691}\""
        let v693 : string = @$"format!(" + v692 + ")"
        let v694 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v693 
        let v695 : string = "fable_library_rust::String_::fromString($0)"
        let v696 : string = Fable.Core.RustInterop.emitRustExpr v694 v695 
        let _v624 = v696 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v706 : string =
            match v0 with
            | US0_4 -> (* Critical *)
                let v701 : string = "\u001b[91m"
                v701
            | US0_1 -> (* Debug *)
                let v698 : string = "\u001b[94m"
                v698
            | US0_2 -> (* Info *)
                let v699 : string = "\u001b[92m"
                v699
            | US0_0 -> (* Verbose *)
                let v697 : string = "\u001b[90m"
                v697
            | US0_3 -> (* Warning *)
                let v700 : string = "\u001b[93m"
                v700
        let v707 : string = method7()
        let v708 : string = v706 + v610 
        let v709 : string = v708 + v707 
        let _v624 = v709 
        #endif
#if FABLE_COMPILER_PYTHON
        let v719 : string =
            match v0 with
            | US0_4 -> (* Critical *)
                let v714 : string = "\u001b[91m"
                v714
            | US0_1 -> (* Debug *)
                let v711 : string = "\u001b[94m"
                v711
            | US0_2 -> (* Info *)
                let v712 : string = "\u001b[92m"
                v712
            | US0_0 -> (* Verbose *)
                let v710 : string = "\u001b[90m"
                v710
            | US0_3 -> (* Warning *)
                let v713 : string = "\u001b[93m"
                v713
        let v720 : string = method7()
        let v721 : string = v719 + v610 
        let v722 : string = v721 + v720 
        let _v624 = v722 
        #endif
#else
        let v732 : string =
            match v0 with
            | US0_4 -> (* Critical *)
                let v727 : string = "\u001b[91m"
                v727
            | US0_1 -> (* Debug *)
                let v724 : string = "\u001b[94m"
                v724
            | US0_2 -> (* Info *)
                let v725 : string = "\u001b[92m"
                v725
            | US0_0 -> (* Verbose *)
                let v723 : string = "\u001b[90m"
                v723
            | US0_3 -> (* Warning *)
                let v726 : string = "\u001b[93m"
                v726
        let v733 : string = method7()
        let v734 : string = v732 + v610 
        let v735 : string = v734 + v733 
        let _v624 = v735 
        #endif
        let v736 : string = _v624 
        let v751 : int64 = v88.l0
        let v752 : string = v2 ()
        let v753 : string = method8()
        let v754 : Mut4 = {l0 = v753} : Mut4
        let v755 : string = $"{v752}"
        let v758 : unit = ()
        let v759 : (unit -> unit) = closure11(v754, v755)
        let v760 : unit = (fun () -> v759 (); v758) ()
        let v763 : string = v754.l0
        let v764 : string = $"{v486} {v736} #{v751} %s{v1 ()} / {v763}"
        let v767 : char list = []
        let v768 : (char list -> (char [])) = List.toArray
        let v769 : (char []) = v768 v767
        let v772 : string = v764.TrimStart v769 
        let v790 : char list = []
        let v791 : char list = '/' :: v790 
        let v794 : char list = ' ' :: v791 
        let v797 : (char list -> (char [])) = List.toArray
        let v798 : (char []) = v797 v794
        let v801 : string = v772.TrimEnd v798 
        let v819 : (string -> unit) = closure12()
        let v820 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v821 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v801 v821 
        let _v820 = () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v822 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v801 v822 
        let _v820 = () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v823 : string = $"near_sdk::log!(\"{{}}\", $0)"
        Fable.Core.RustInterop.emitRustExpr v801 v823 
        let _v820 = () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        v819 v801
        let _v820 = () 
        #endif
#if FABLE_COMPILER_PYTHON
        v819 v801
        let _v820 = () 
        #endif
#else
        v819 v801
        let _v820 = () 
        #endif
        _v820 
        let v824 : (string -> unit) = v19.l0
        v824 v801
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
