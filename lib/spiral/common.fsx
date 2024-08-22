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
and [<Struct>] US4 =
    | US4_0
    | US4_1
and [<Struct>] US5 =
    | US5_0 of f0_0 : US4
    | US5_1
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
    let v0 : string = "("
    v0
and method11 () : string =
    let v0 : string = " "
    v0
and method12 () : string =
    let v0 : string = ""
    v0
and closure14 (v0 : Mut4, v1 : string) () : unit =
    let v2 : string = v0.l0
    let v3 : string = v2 + v1 
    v0.l0 <- v3
    ()
and method13 () : string =
    let v0 : string = "\u001b[0m"
    v0
and closure15 () () : string =
    let v0 : string = "common.retry_fn"
    v0
and closure17 (v0 : string) () : unit =
    let v1 : (string -> unit) = System.Console.WriteLine
    v1 v0
and closure16 () (v0 : string) : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure17(v0)
    let v3 : unit = (fun () -> v2 (); v1) ()
    ()
and closure10 (v0 : int32, v1 : exn) () : unit =
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
            let v65 : bool = 3 >= v64
            v65
    if v66 then
        let v67 : unit = ()
        let v68 : (unit -> unit) = closure11(v17)
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
        let v104 : (US3 option -> US3 option ref) = closure12(v103)
        let v105 : unit = ()
        let v106 : (unit -> unit) = closure13(v90, v104)
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
        let v163 : string = method8()
        let v166 : (string -> string) = v162.ToString
        let v167 : string = v166 v163
        let _v101 = v167 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v170 : US3 option = None
        let _v170 = ref v170 
        let v171 : US3 option ref = _v170 
        let v172 : (US3 option -> US3 option ref) = closure12(v171)
        let v173 : unit = ()
        let v174 : (unit -> unit) = closure13(v90, v172)
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
        let v231 : string = method8()
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
        let v242 : (US3 option -> US3 option ref) = closure12(v241)
        let v243 : unit = ()
        let v244 : (unit -> unit) = closure13(v90, v242)
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
        let v282 : (US3 option -> US3 option ref) = closure12(v281)
        let v283 : unit = ()
        let v284 : (unit -> unit) = closure13(v90, v282)
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
        let v341 : string = method9()
        let v344 : (string -> string) = v340.ToString
        let v345 : string = v344 v341
        let _v101 = v345 
        #endif
#if FABLE_COMPILER_PYTHON
        let v348 : US3 option = None
        let _v348 = ref v348 
        let v349 : US3 option ref = _v348 
        let v350 : (US3 option -> US3 option ref) = closure12(v349)
        let v351 : unit = ()
        let v352 : (unit -> unit) = closure13(v90, v350)
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
        let v409 : string = method9()
        let v412 : (string -> string) = v408.ToString
        let v413 : string = v412 v409
        let _v101 = v413 
        #endif
#else
        let v416 : US3 option = None
        let _v416 = ref v416 
        let v417 : US3 option ref = _v416 
        let v418 : (US3 option -> US3 option ref) = closure12(v417)
        let v419 : unit = ()
        let v420 : (unit -> unit) = closure13(v90, v418)
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
        let v477 : string = method9()
        let v480 : (string -> string) = v476.ToString
        let v481 : string = v480 v477
        let _v101 = v481 
        #endif
        let v484 : string = _v101 
        
        
        
        
        
        let v554 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v555 : string = method10()
        let _v554 = v555 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v556 : string = method10()
        let _v554 = v556 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v557 : string = method10()
        let _v554 = v557 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v558 : string = method11()
        let _v554 = v558 
        #endif
#if FABLE_COMPILER_PYTHON
        let v559 : string = method11()
        let _v554 = v559 
        #endif
#else
        let v560 : string = method11()
        let _v554 = v560 
        #endif
        let v561 : string = _v554 
        let v566 : string = method12()
        let v567 : Mut4 = {l0 = v566} : Mut4
        let v568 : US0 = US0_0
        let v569 : string = $"%A{v568}"
        let v573 : string = $"{v569}"
        let v576 : unit = ()
        let v577 : (unit -> unit) = closure14(v567, v573)
        let v578 : unit = (fun () -> v577 (); v576) ()
        let v581 : string = v567.l0
        let v582 : (string []) = v581.Split v561 
        let v585 : string = v582.[int 0]
        let v588 : string = method12()
        let v589 : Mut4 = {l0 = v588} : Mut4
        let v590 : US0 = US0_3
        let v591 : string = $"%A{v590}"
        let v595 : string = $"{v591}"
        let v598 : unit = ()
        let v599 : (unit -> unit) = closure14(v589, v595)
        let v600 : unit = (fun () -> v599 (); v598) ()
        let v603 : string = v589.l0
        let v604 : bool = v603.StartsWith v585 
        let v610 : US1 =
            if v604 then
                let v607 : string = "Verbose"
                US1_0(v607)
            else
                US1_1
        let v738 : US1 =
            match v610 with
            | US1_1 -> (* None *)
                let v613 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v614 : string = method10()
                let _v613 = v614 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v615 : string = method10()
                let _v613 = v615 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v616 : string = method10()
                let _v613 = v616 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v617 : string = method11()
                let _v613 = v617 
                #endif
#if FABLE_COMPILER_PYTHON
                let v618 : string = method11()
                let _v613 = v618 
                #endif
#else
                let v619 : string = method11()
                let _v613 = v619 
                #endif
                let v620 : string = _v613 
                let v625 : string = method12()
                let v626 : Mut4 = {l0 = v625} : Mut4
                let v627 : US0 = US0_1
                let v628 : string = $"%A{v627}"
                let v632 : string = $"{v628}"
                let v635 : unit = ()
                let v636 : (unit -> unit) = closure14(v626, v632)
                let v637 : unit = (fun () -> v636 (); v635) ()
                let v640 : string = v626.l0
                let v641 : (string []) = v640.Split v620 
                let v644 : string = v641.[int 0]
                let v647 : string = method12()
                let v648 : Mut4 = {l0 = v647} : Mut4
                let v649 : US0 = US0_3
                let v650 : string = $"%A{v649}"
                let v654 : string = $"{v650}"
                let v657 : unit = ()
                let v658 : (unit -> unit) = closure14(v648, v654)
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
                    let v673 : string = method10()
                    let _v672 = v673 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v674 : string = method10()
                    let _v672 = v674 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v675 : string = method10()
                    let _v672 = v675 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v676 : string = method11()
                    let _v672 = v676 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v677 : string = method11()
                    let _v672 = v677 
                    #endif
#else
                    let v678 : string = method11()
                    let _v672 = v678 
                    #endif
                    let v679 : string = _v672 
                    let v684 : string = method12()
                    let v685 : Mut4 = {l0 = v684} : Mut4
                    let v686 : US0 = US0_2
                    let v687 : string = $"%A{v686}"
                    let v691 : string = $"{v687}"
                    let v694 : unit = ()
                    let v695 : (unit -> unit) = closure14(v685, v691)
                    let v696 : unit = (fun () -> v695 (); v694) ()
                    let v699 : string = v685.l0
                    let v700 : (string []) = v699.Split v679 
                    let v703 : string = v700.[int 0]
                    let v706 : string = method12()
                    let v707 : Mut4 = {l0 = v706} : Mut4
                    let v708 : US0 = US0_3
                    let v709 : string = $"%A{v708}"
                    let v713 : string = $"{v709}"
                    let v716 : unit = ()
                    let v717 : (unit -> unit) = closure14(v707, v713)
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
                        let v731 : string = "Warning"
                        US1_0(v731)
                    | US1_0(v729) -> (* Some *)
                        US1_0(v729)
                | US1_0(v670) -> (* Some *)
                    US1_0(v670)
            | US1_0(v611) -> (* Some *)
                US1_0(v611)
        let v742 : string =
            match v738 with
            | US1_1 -> (* None *)
                failwith<string> "Option does not have a value."
            | US1_0(v739) -> (* Some *)
                v739
        let v743 : (unit -> string) = v742.ToLower
        let v744 : string = v743 ()
        let v747 : string = v744.PadLeft (7, ' ')
        let v761 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v762 : string = "inline_colorization::color_yellow"
        let v763 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v762 
        let v764 : string = "&*$0"
        let v765 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v747 v764 
        let v766 : string = "inline_colorization::color_reset"
        let v767 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v766 
        let v768 : string = "\"{v763}{v765}{v767}\""
        let v769 : string = @$"format!(" + v768 + ")"
        let v770 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v769 
        let v771 : string = "fable_library_rust::String_::fromString($0)"
        let v772 : string = Fable.Core.RustInterop.emitRustExpr v770 v771 
        let _v761 = v772 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v773 : string = "inline_colorization::color_yellow"
        let v774 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v773 
        let v775 : string = "&*$0"
        let v776 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v747 v775 
        let v777 : string = "inline_colorization::color_reset"
        let v778 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v777 
        let v779 : string = "\"{v774}{v776}{v778}\""
        let v780 : string = @$"format!(" + v779 + ")"
        let v781 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v780 
        let v782 : string = "fable_library_rust::String_::fromString($0)"
        let v783 : string = Fable.Core.RustInterop.emitRustExpr v781 v782 
        let _v761 = v783 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v784 : string = "inline_colorization::color_yellow"
        let v785 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v784 
        let v786 : string = "&*$0"
        let v787 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v747 v786 
        let v788 : string = "inline_colorization::color_reset"
        let v789 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v788 
        let v790 : string = "\"{v785}{v787}{v789}\""
        let v791 : string = @$"format!(" + v790 + ")"
        let v792 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v791 
        let v793 : string = "fable_library_rust::String_::fromString($0)"
        let v794 : string = Fable.Core.RustInterop.emitRustExpr v792 v793 
        let _v761 = v794 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v795 : string = "\u001b[93m"
        let v796 : string = method13()
        let v797 : string = v795 + v747 
        let v798 : string = v797 + v796 
        let _v761 = v798 
        #endif
#if FABLE_COMPILER_PYTHON
        let v799 : string = "\u001b[93m"
        let v800 : string = method13()
        let v801 : string = v799 + v747 
        let v802 : string = v801 + v800 
        let _v761 = v802 
        #endif
#else
        let v803 : string = "\u001b[93m"
        let v804 : string = method13()
        let v805 : string = v803 + v747 
        let v806 : string = v805 + v804 
        let _v761 = v806 
        #endif
        let v807 : string = _v761 
        let v813 : int64 = v86.l0
        let v814 : string = method12()
        let v815 : Mut4 = {l0 = v814} : Mut4
        let v816 : string = "{ "
        let v817 : string = $"{v816}"
        let v820 : unit = ()
        let v821 : (unit -> unit) = closure14(v815, v817)
        let v822 : unit = (fun () -> v821 (); v820) ()
        let v825 : string = "retry"
        let v826 : string = $"{v825}"
        let v829 : unit = ()
        let v830 : (unit -> unit) = closure14(v815, v826)
        let v831 : unit = (fun () -> v830 (); v829) ()
        let v834 : string = " = "
        let v835 : string = $"{v834}"
        let v838 : unit = ()
        let v839 : (unit -> unit) = closure14(v815, v835)
        let v840 : unit = (fun () -> v839 (); v838) ()
        let v843 : string = $"{v0}"
        let v846 : unit = ()
        let v847 : (unit -> unit) = closure14(v815, v843)
        let v848 : unit = (fun () -> v847 (); v846) ()
        let v851 : string = "; "
        let v852 : string = $"{v851}"
        let v855 : unit = ()
        let v856 : (unit -> unit) = closure14(v815, v852)
        let v857 : unit = (fun () -> v856 (); v855) ()
        let v860 : string = "ex"
        let v861 : string = $"{v860}"
        let v864 : unit = ()
        let v865 : (unit -> unit) = closure14(v815, v861)
        let v866 : unit = (fun () -> v865 (); v864) ()
        let v869 : string = $"{v834}"
        let v872 : unit = ()
        let v873 : (unit -> unit) = closure14(v815, v869)
        let v874 : unit = (fun () -> v873 (); v872) ()
        let v877 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v878 : string = "format!(\"{:#?}\", $0)"
        let v879 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1 v878 
        let v880 : string = "fable_library_rust::String_::fromString($0)"
        let v881 : string = Fable.Core.RustInterop.emitRustExpr v879 v880 
        let _v877 = v881 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v882 : string = "format!(\"{:#?}\", $0)"
        let v883 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1 v882 
        let v884 : string = "fable_library_rust::String_::fromString($0)"
        let v885 : string = Fable.Core.RustInterop.emitRustExpr v883 v884 
        let _v877 = v885 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v886 : string = "format!(\"{:#?}\", $0)"
        let v887 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1 v886 
        let v888 : string = "fable_library_rust::String_::fromString($0)"
        let v889 : string = Fable.Core.RustInterop.emitRustExpr v887 v888 
        let _v877 = v889 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v890 : string = $"%A{v1}"
        let _v877 = v890 
        #endif
#if FABLE_COMPILER_PYTHON
        let v893 : string = $"%A{v1}"
        let _v877 = v893 
        #endif
#else
        let v896 : string = $"%A{v1}"
        let _v877 = v896 
        #endif
        let v899 : string = _v877 
        let v904 : string = $"{v899}"
        let v907 : unit = ()
        let v908 : (unit -> unit) = closure14(v815, v904)
        let v909 : unit = (fun () -> v908 (); v907) ()
        let v912 : string = " }"
        let v913 : string = $"{v912}"
        let v916 : unit = ()
        let v917 : (unit -> unit) = closure14(v815, v913)
        let v918 : unit = (fun () -> v917 (); v916) ()
        let v921 : string = v815.l0
        let v922 : (unit -> string) = closure15()
        let v923 : string = $"{v484} {v807} #{v813} %s{v922 ()} / {v921}"
        let v926 : char list = []
        let v927 : (char list -> (char [])) = List.toArray
        let v928 : (char []) = v927 v926
        let v931 : string = v923.TrimStart v928 
        let v949 : char list = []
        let v950 : char list = '/' :: v949 
        let v953 : char list = ' ' :: v950 
        let v956 : (char list -> (char [])) = List.toArray
        let v957 : (char []) = v956 v953
        let v960 : string = v931.TrimEnd v957 
        let v978 : (string -> unit) = closure16()
        let v979 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v980 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v960 v980 
        let _v979 = () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v981 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v960 v981 
        let _v979 = () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v982 : string = $"near_sdk::log!(\"{{}}\", $0)"
        Fable.Core.RustInterop.emitRustExpr v960 v982 
        let _v979 = () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        v978 v960
        let _v979 = () 
        #endif
#if FABLE_COMPILER_PYTHON
        v978 v960
        let _v979 = () 
        #endif
#else
        v978 v960
        let _v979 = () 
        #endif
        _v979 
        let v983 : (string -> unit) = v18.l0
        v983 v960
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
and method14 (v0 : (unit -> unit)) : (unit -> unit) =
    v0
and closure19 (v0 : Lazy<unit>) () : unit =
    v0.Value
    ()
and closure18 () (v0 : (unit -> unit)) : (unit -> unit) =
    let v1 : (unit -> unit) = method14(v0)
    let v2 : Lazy<unit> = lazy v1 ()
    closure19(v2)
let v0 : unit = ()
let v1 : (unit -> unit) = closure0()
let v2 : unit = (fun () -> v1 (); v0) ()
let v15 : ((unit -> unit) -> System.IDisposable) = closure4()
let new_disposable x = v15 x
let v16 : (int32 -> ((unit -> unit) -> unit option)) = closure5()
let retry_fn x = v16 x
let v17 : ((unit -> unit) -> (unit -> unit)) = closure18()
let memoize x = v17 x
()
