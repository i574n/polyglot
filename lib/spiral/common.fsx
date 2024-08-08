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
and method5 (v0 : (unit -> unit)) : (unit -> unit) =
    v0
and method6 (v0 : (unit -> unit)) : (unit -> unit) =
    v0
and closure1 () (v0 : (unit -> unit)) : System.IDisposable =
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
and closure4 () (v0 : US4) : US5 =
    US5_0(v0)
and closure5 (v0 : int32, v1 : (unit -> unit), v2 : int32) () : US4 =
    let v3 : bool = v2 < v0
    if v3 then
        v1 ()
        US4_0
    else
        US4_1
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
and closure7 () () : string =
    let v0 : string = "common.retry_fn"
    v0
and closure6 (v0 : int32) (v1 : exn) : US5 =
    let v2 : bool = State.trace_state.IsNone
    if v2 then
        let v3 : US0 = US0_0
        let struct (v4 : Mut0, v5 : Mut1, v6 : Mut2, v7 : Mut3, v8 : int64 option) = method0(v3)
        let v9 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v4, v5, v6, v7, v8) 
        State.trace_state <- v9 
        ()
    let struct (v14 : Mut0, v15 : Mut1, v16 : Mut2, v17 : Mut3, v18 : int64 option) = State.trace_state.Value
    let v29 : bool = State.trace_state.IsNone
    if v29 then
        let v30 : US0 = US0_0
        let struct (v31 : Mut0, v32 : Mut1, v33 : Mut2, v34 : Mut3, v35 : int64 option) = method0(v30)
        let v36 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v31, v32, v33, v34, v35) 
        State.trace_state <- v36 
        ()
    let struct (v41 : Mut0, v42 : Mut1, v43 : Mut2, v44 : Mut3, v45 : int64 option) = State.trace_state.Value
    let v56 : US0 = v44.l0
    let v57 : bool = v43.l0
    let v58 : bool = v57 = false
    let v61 : bool =
        if v58 then
            false
        else
            let v59 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v56
            let v60 : bool = 3 >= v59
            v60
    if v61 then
        let v62 : int64 = v14.l0
        let v63 : int64 = v62 + 1L
        v14.l0 <- v63
        let v64 : bool = State.trace_state.IsNone
        if v64 then
            let v65 : US0 = US0_0
            let struct (v66 : Mut0, v67 : Mut1, v68 : Mut2, v69 : Mut3, v70 : int64 option) = method0(v65)
            let v71 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v66, v67, v68, v69, v70) 
            State.trace_state <- v71 
            ()
        let struct (v76 : Mut0, v77 : Mut1, v78 : Mut2, v79 : Mut3, v80 : int64 option) = State.trace_state.Value
        let v91 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v92 : US3 option = None
        let _v92 = ref v92 
        match v80 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v93 : int64 = x
        let v94 : US3 = US3_0(v93)
        v94 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v92.Value <- x
        let v95 : US3 option = _v92.Value 
        let v106 : US3 = US3_1
        let v107 : US3 = v95 |> Option.defaultValue v106 
        let v147 : System.DateTime =
            match v107 with
            | US3_1 -> (* None *)
                let v143 : System.DateTime = System.DateTime.Now
                v143
            | US3_0(v111) -> (* Some *)
                let v112 : System.DateTime = System.DateTime.Now
                let v115 : (System.DateTime -> int64) = _.Ticks
                let v116 : int64 = v115 v112
                let v119 : int64 = v116 - v111
                let v120 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v121 : System.TimeSpan = v120 v119
                let v124 : (System.TimeSpan -> int32) = _.Hours
                let v125 : int32 = v124 v121
                let v128 : (System.TimeSpan -> int32) = _.Minutes
                let v129 : int32 = v128 v121
                let v132 : (System.TimeSpan -> int32) = _.Seconds
                let v133 : int32 = v132 v121
                let v136 : (System.TimeSpan -> int32) = _.Milliseconds
                let v137 : int32 = v136 v121
                let v140 : System.DateTime = System.DateTime (1, 1, 1, v125, v129, v133, v137)
                v140
        let v148 : string = method8()
        let v151 : (string -> string) = v147.ToString
        let v152 : string = v151 v148
        let _v91 = v152 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v155 : US3 option = None
        let _v155 = ref v155 
        match v80 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v156 : int64 = x
        let v157 : US3 = US3_0(v156)
        v157 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v155.Value <- x
        let v158 : US3 option = _v155.Value 
        let v169 : US3 = US3_1
        let v170 : US3 = v158 |> Option.defaultValue v169 
        let v210 : System.DateTime =
            match v170 with
            | US3_1 -> (* None *)
                let v206 : System.DateTime = System.DateTime.Now
                v206
            | US3_0(v174) -> (* Some *)
                let v175 : System.DateTime = System.DateTime.Now
                let v178 : (System.DateTime -> int64) = _.Ticks
                let v179 : int64 = v178 v175
                let v182 : int64 = v179 - v174
                let v183 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v184 : System.TimeSpan = v183 v182
                let v187 : (System.TimeSpan -> int32) = _.Hours
                let v188 : int32 = v187 v184
                let v191 : (System.TimeSpan -> int32) = _.Minutes
                let v192 : int32 = v191 v184
                let v195 : (System.TimeSpan -> int32) = _.Seconds
                let v196 : int32 = v195 v184
                let v199 : (System.TimeSpan -> int32) = _.Milliseconds
                let v200 : int32 = v199 v184
                let v203 : System.DateTime = System.DateTime (1, 1, 1, v188, v192, v196, v200)
                v203
        let v211 : string = method8()
        let v214 : (string -> string) = v210.ToString
        let v215 : string = v214 v211
        let _v91 = v215 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v218 : string = $"near_sdk::env::block_timestamp()"
        let v219 : uint64 = Fable.Core.RustInterop.emitRustExpr () v218 
        let v220 : US3 option = None
        let _v220 = ref v220 
        match v80 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v221 : int64 = x
        let v222 : US3 = US3_0(v221)
        v222 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v220.Value <- x
        let v223 : US3 option = _v220.Value 
        let v234 : US3 = US3_1
        let v235 : US3 = v223 |> Option.defaultValue v234 
        let v244 : uint64 =
            match v235 with
            | US3_1 -> (* None *)
                v219
            | US3_0(v239) -> (* Some *)
                let v240 : (int64 -> uint64) = uint64
                let v241 : uint64 = v240 v239
                let v242 : uint64 = v219 - v241
                v242
        let v245 : uint64 = v244 / 1000000000UL
        let v246 : uint64 = v245 % 60UL
        let v247 : uint64 = v245 / 60UL
        let v248 : uint64 = v247 % 60UL
        let v249 : uint64 = v245 / 3600UL
        let v250 : uint64 = v249 % 24UL
        let v251 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
        let v252 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v250, v248, v246) v251 
        let v253 : string = "fable_library_rust::String_::fromString($0)"
        let v254 : string = Fable.Core.RustInterop.emitRustExpr v252 v253 
        let _v91 = v254 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v255 : US3 option = None
        let _v255 = ref v255 
        match v80 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v256 : int64 = x
        let v257 : US3 = US3_0(v256)
        v257 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v255.Value <- x
        let v258 : US3 option = _v255.Value 
        let v269 : US3 = US3_1
        let v270 : US3 = v258 |> Option.defaultValue v269 
        let v310 : System.DateTime =
            match v270 with
            | US3_1 -> (* None *)
                let v306 : System.DateTime = System.DateTime.Now
                v306
            | US3_0(v274) -> (* Some *)
                let v275 : System.DateTime = System.DateTime.Now
                let v278 : (System.DateTime -> int64) = _.Ticks
                let v279 : int64 = v278 v275
                let v282 : int64 = v279 - v274
                let v283 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v284 : System.TimeSpan = v283 v282
                let v287 : (System.TimeSpan -> int32) = _.Hours
                let v288 : int32 = v287 v284
                let v291 : (System.TimeSpan -> int32) = _.Minutes
                let v292 : int32 = v291 v284
                let v295 : (System.TimeSpan -> int32) = _.Seconds
                let v296 : int32 = v295 v284
                let v299 : (System.TimeSpan -> int32) = _.Milliseconds
                let v300 : int32 = v299 v284
                let v303 : System.DateTime = System.DateTime (1, 1, 1, v288, v292, v296, v300)
                v303
        let v311 : string = method9()
        let v314 : (string -> string) = v310.ToString
        let v315 : string = v314 v311
        let _v91 = v315 
        #endif
#if FABLE_COMPILER_PYTHON
        let v318 : US3 option = None
        let _v318 = ref v318 
        match v80 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v319 : int64 = x
        let v320 : US3 = US3_0(v319)
        v320 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v318.Value <- x
        let v321 : US3 option = _v318.Value 
        let v332 : US3 = US3_1
        let v333 : US3 = v321 |> Option.defaultValue v332 
        let v373 : System.DateTime =
            match v333 with
            | US3_1 -> (* None *)
                let v369 : System.DateTime = System.DateTime.Now
                v369
            | US3_0(v337) -> (* Some *)
                let v338 : System.DateTime = System.DateTime.Now
                let v341 : (System.DateTime -> int64) = _.Ticks
                let v342 : int64 = v341 v338
                let v345 : int64 = v342 - v337
                let v346 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v347 : System.TimeSpan = v346 v345
                let v350 : (System.TimeSpan -> int32) = _.Hours
                let v351 : int32 = v350 v347
                let v354 : (System.TimeSpan -> int32) = _.Minutes
                let v355 : int32 = v354 v347
                let v358 : (System.TimeSpan -> int32) = _.Seconds
                let v359 : int32 = v358 v347
                let v362 : (System.TimeSpan -> int32) = _.Milliseconds
                let v363 : int32 = v362 v347
                let v366 : System.DateTime = System.DateTime (1, 1, 1, v351, v355, v359, v363)
                v366
        let v374 : string = method9()
        let v377 : (string -> string) = v373.ToString
        let v378 : string = v377 v374
        let _v91 = v378 
        #endif
#else
        let v381 : US3 option = None
        let _v381 = ref v381 
        match v80 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v382 : int64 = x
        let v383 : US3 = US3_0(v382)
        v383 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v381.Value <- x
        let v384 : US3 option = _v381.Value 
        let v395 : US3 = US3_1
        let v396 : US3 = v384 |> Option.defaultValue v395 
        let v436 : System.DateTime =
            match v396 with
            | US3_1 -> (* None *)
                let v432 : System.DateTime = System.DateTime.Now
                v432
            | US3_0(v400) -> (* Some *)
                let v401 : System.DateTime = System.DateTime.Now
                let v404 : (System.DateTime -> int64) = _.Ticks
                let v405 : int64 = v404 v401
                let v408 : int64 = v405 - v400
                let v409 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v410 : System.TimeSpan = v409 v408
                let v413 : (System.TimeSpan -> int32) = _.Hours
                let v414 : int32 = v413 v410
                let v417 : (System.TimeSpan -> int32) = _.Minutes
                let v418 : int32 = v417 v410
                let v421 : (System.TimeSpan -> int32) = _.Seconds
                let v422 : int32 = v421 v410
                let v425 : (System.TimeSpan -> int32) = _.Milliseconds
                let v426 : int32 = v425 v410
                let v429 : System.DateTime = System.DateTime (1, 1, 1, v414, v418, v422, v426)
                v429
        let v437 : string = method9()
        let v440 : (string -> string) = v436.ToString
        let v441 : string = v440 v437
        let _v91 = v441 
        #endif
        let v444 : string = _v91 
        let v509 : string = "Warning"
        let v510 : (unit -> string) = v509.ToLower
        let v511 : string = v510 ()
        let v514 : string = v511.PadLeft (7, ' ')
        let v528 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v529 : string = "inline_colorization::color_yellow"
        let v530 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v529 
        let v531 : string = "&*$0"
        let v532 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v514 v531 
        let v533 : string = "inline_colorization::color_reset"
        let v534 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v533 
        let v535 : string = "\"{v530}{v532}{v534}\""
        let v536 : string = @$"format!(" + v535 + ")"
        let v537 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v536 
        let v538 : string = "fable_library_rust::String_::fromString($0)"
        let v539 : string = Fable.Core.RustInterop.emitRustExpr v537 v538 
        let _v528 = v539 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v540 : string = "inline_colorization::color_yellow"
        let v541 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v540 
        let v542 : string = "&*$0"
        let v543 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v514 v542 
        let v544 : string = "inline_colorization::color_reset"
        let v545 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v544 
        let v546 : string = "\"{v541}{v543}{v545}\""
        let v547 : string = @$"format!(" + v546 + ")"
        let v548 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v547 
        let v549 : string = "fable_library_rust::String_::fromString($0)"
        let v550 : string = Fable.Core.RustInterop.emitRustExpr v548 v549 
        let _v528 = v550 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v551 : string = "inline_colorization::color_yellow"
        let v552 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v551 
        let v553 : string = "&*$0"
        let v554 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v514 v553 
        let v555 : string = "inline_colorization::color_reset"
        let v556 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v555 
        let v557 : string = "\"{v552}{v554}{v556}\""
        let v558 : string = @$"format!(" + v557 + ")"
        let v559 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v558 
        let v560 : string = "fable_library_rust::String_::fromString($0)"
        let v561 : string = Fable.Core.RustInterop.emitRustExpr v559 v560 
        let _v528 = v561 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v562 : string = "\u001b[93m"
        let v563 : string = method10()
        let v564 : string = v562 + v514 
        let v565 : string = v564 + v563 
        let _v528 = v565 
        #endif
#if FABLE_COMPILER_PYTHON
        let v566 : string = "\u001b[93m"
        let v567 : string = method10()
        let v568 : string = v566 + v514 
        let v569 : string = v568 + v567 
        let _v528 = v569 
        #endif
#else
        let v570 : string = "\u001b[93m"
        let v571 : string = method10()
        let v572 : string = v570 + v514 
        let v573 : string = v572 + v571 
        let _v528 = v573 
        #endif
        let v574 : string = _v528 
        let v580 : int64 = v76.l0
        let v581 : string = method11()
        let v582 : Mut4 = {l0 = v581} : Mut4
        let v583 : string = "{ "
        let v584 : string = $"{v583}"
        let v587 : string = v582.l0
        let v588 : string = v587 + v584 
        v582.l0 <- v588
        let v589 : string = "retry"
        let v590 : string = $"{v589}"
        let v593 : string = v582.l0
        let v594 : string = v593 + v590 
        v582.l0 <- v594
        let v595 : string = " = "
        let v596 : string = $"{v595}"
        let v599 : string = v582.l0
        let v600 : string = v599 + v596 
        v582.l0 <- v600
        let v601 : string = $"{v0}"
        let v604 : string = v582.l0
        let v605 : string = v604 + v601 
        v582.l0 <- v605
        let v606 : string = "; "
        let v607 : string = $"{v606}"
        let v610 : string = v582.l0
        let v611 : string = v610 + v607 
        v582.l0 <- v611
        let v612 : string = "ex"
        let v613 : string = $"{v612}"
        let v616 : string = v582.l0
        let v617 : string = v616 + v613 
        v582.l0 <- v617
        let v618 : string = $"{v595}"
        let v621 : string = v582.l0
        let v622 : string = v621 + v618 
        v582.l0 <- v622
        let v623 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v624 : string = "format!(\"{:#?}\", $0)"
        let v625 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1 v624 
        let v626 : string = "fable_library_rust::String_::fromString($0)"
        let v627 : string = Fable.Core.RustInterop.emitRustExpr v625 v626 
        let _v623 = v627 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v628 : string = "format!(\"{:#?}\", $0)"
        let v629 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1 v628 
        let v630 : string = "fable_library_rust::String_::fromString($0)"
        let v631 : string = Fable.Core.RustInterop.emitRustExpr v629 v630 
        let _v623 = v631 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v632 : string = "format!(\"{:#?}\", $0)"
        let v633 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1 v632 
        let v634 : string = "fable_library_rust::String_::fromString($0)"
        let v635 : string = Fable.Core.RustInterop.emitRustExpr v633 v634 
        let _v623 = v635 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v636 : string = $"%A{v1}"
        let _v623 = v636 
        #endif
#if FABLE_COMPILER_PYTHON
        let v639 : string = $"%A{v1}"
        let _v623 = v639 
        #endif
#else
        let v642 : string = $"%A{v1}"
        let _v623 = v642 
        #endif
        let v645 : string = _v623 
        let v650 : string = $"{v645}"
        let v653 : string = v582.l0
        let v654 : string = v653 + v650 
        v582.l0 <- v654
        let v655 : string = " }"
        let v656 : string = $"{v655}"
        let v659 : string = v582.l0
        let v660 : string = v659 + v656 
        v582.l0 <- v660
        let v661 : string = v582.l0
        let v662 : (unit -> string) = closure7()
        let v663 : string = $"{v444} {v574} #{v580} %s{v662 ()} / {v661}"
        let v666 : char list = []
        let v667 : (char list -> (char [])) = List.toArray
        let v668 : (char []) = v667 v666
        let v671 : string = v663.TrimStart v668 
        let v689 : char list = []
        let v690 : char list = '/' :: v689 
        let v693 : char list = ' ' :: v690 
        let v696 : (char list -> (char [])) = List.toArray
        let v697 : (char []) = v696 v693
        let v700 : string = v671.TrimEnd v697 
        let v718 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v719 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v700 v719 
        let _v718 = () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v720 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v700 v720 
        let _v718 = () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v721 : string = $"near_sdk::log!(\"{{}}\", $0)"
        Fable.Core.RustInterop.emitRustExpr v700 v721 
        let _v718 = () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        System.Console.WriteLine v700 
        let _v718 = () 
        #endif
#if FABLE_COMPILER_PYTHON
        System.Console.WriteLine v700 
        let _v718 = () 
        #endif
#else
        System.Console.WriteLine v700 
        let _v718 = () 
        #endif
        _v718 
        let v722 : (string -> unit) = v15.l0
        v722 v700
    US5_1
and method7 (v0 : int32, v1 : (unit -> unit), v2 : int32) : US4 =
    let v3 : (US4 -> US5) = closure4()
    let v4 : (unit -> US4) = closure5(v0, v1, v2)
    let v5 : (exn -> US5) = closure6(v2)
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
and closure3 (v0 : int32) (v1 : (unit -> unit)) : unit option =
    let v2 : int32 = 0
    let v3 : US4 = method7(v0, v1, v2)
    match v3 with
    | US4_1 -> (* None *)
        let v7 : unit option = None
        v7
    | US4_0 -> (* Some *)
        let v4 : unit option = Some () 
        v4
and closure2 () (v0 : int32) : ((unit -> unit) -> unit option) =
    closure3(v0)
and method12 (v0 : (unit -> unit)) : (unit -> unit) =
    v0
and closure9 (v0 : Lazy<unit>) () : unit =
    v0.Value
    ()
and closure8 () (v0 : (unit -> unit)) : (unit -> unit) =
    let v1 : (unit -> unit) = method12(v0)
    let v2 : Lazy<unit> = lazy v1 ()
    closure9(v2)
let v0 : bool = State.trace_state.IsNone
if v0 then
    let v1 : US0 = US0_0
    let struct (v2 : Mut0, v3 : Mut1, v4 : Mut2, v5 : Mut3, v6 : int64 option) = method0(v1)
    let v7 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v2, v3, v4, v5, v6) 
    State.trace_state <- v7 
    ()
let v12 : ((unit -> unit) -> System.IDisposable) = closure1()
let new_disposable x = v12 x
let v13 : (int32 -> ((unit -> unit) -> unit option)) = closure2()
let retry_fn x = v13 x
let v14 : ((unit -> unit) -> (unit -> unit)) = closure8()
let memoize x = v14 x
()
