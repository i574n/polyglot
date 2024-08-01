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
    | US1_0 of f0_0 : US0
    | US1_1
and [<Struct>] US2 =
    | US2_0 of f0_0 : int64
    | US2_1
and [<Struct>] US3 =
    | US3_0 of f0_0 : string
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
let rec method0 () : string =
    let v0 : string = "TRACE_LEVEL"
    v0
and method2 () : string =
    let v0 : string = ""
    v0
and method1 (v0 : string) : string =
    let v3 : bool = true
    let mutable _v3 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v4 : string = "std::env::var(&*$0)"
    let v5 : Result<std_string_String, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr v0 v4 
    let v6 : string = "true; let _result = $0.map(|x| { //"
    let v7 : bool = Fable.Core.RustInterop.emitRustExpr v5 v6 
    let v8 : string = "x"
    let v9 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v8 
    let v10 : string = "fable_library_rust::String_::fromString($0)"
    let v11 : string = Fable.Core.RustInterop.emitRustExpr v9 v10 
    let v12 : string = "true; $0 })"
    let v13 : bool = Fable.Core.RustInterop.emitRustExpr v11 v12 
    let v14 : string = "_result"
    let v15 : Result<string, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr () v14 
    let v16 : string = method2()
    let v17 : string = "$0.unwrap_or($1)"
    let v18 : string = Fable.Core.RustInterop.emitRustExpr struct (v15, v16) v17 
    v18 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v19 : string = "std::env::var(&*$0)"
    let v20 : Result<std_string_String, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr v0 v19 
    let v21 : string = "true; let _result = $0.map(|x| { //"
    let v22 : bool = Fable.Core.RustInterop.emitRustExpr v20 v21 
    let v23 : string = "x"
    let v24 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v23 
    let v25 : string = "fable_library_rust::String_::fromString($0)"
    let v26 : string = Fable.Core.RustInterop.emitRustExpr v24 v25 
    let v27 : string = "true; $0 })"
    let v28 : bool = Fable.Core.RustInterop.emitRustExpr v26 v27 
    let v29 : string = "_result"
    let v30 : Result<string, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr () v29 
    let v31 : string = method2()
    let v32 : string = "$0.unwrap_or($1)"
    let v33 : string = Fable.Core.RustInterop.emitRustExpr struct (v30, v31) v32 
    v33 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v34 : string = "std::env::var(&*$0)"
    let v35 : Result<std_string_String, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr v0 v34 
    let v36 : string = "true; let _result = $0.map(|x| { //"
    let v37 : bool = Fable.Core.RustInterop.emitRustExpr v35 v36 
    let v38 : string = "x"
    let v39 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v38 
    let v40 : string = "fable_library_rust::String_::fromString($0)"
    let v41 : string = Fable.Core.RustInterop.emitRustExpr v39 v40 
    let v42 : string = "true; $0 })"
    let v43 : bool = Fable.Core.RustInterop.emitRustExpr v41 v42 
    let v44 : string = "_result"
    let v45 : Result<string, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr () v44 
    let v46 : string = method2()
    let v47 : string = "$0.unwrap_or($1)"
    let v48 : string = Fable.Core.RustInterop.emitRustExpr struct (v45, v46) v47 
    v48 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v49 : string = "process.env[$0] ?? \"\""
    let v50 : string = Fable.Core.JsInterop.emitJsExpr v0 v49 
    v50 
    #endif
#if FABLE_COMPILER_PYTHON
    let v53 : string = "os"
    let v54 : IOsEnviron = Fable.Core.PyInterop.importAll v53 
    let v55 : string = "v54.environ"
    let v56 : obj = Fable.Core.PyInterop.emitPyExpr () v55 
    let v65 : string = "v56.get($0)"
    let v66 : string = Fable.Core.PyInterop.emitPyExpr v0 v65 
    let mutable _v66 = None
    #if !FABLE_COMPILER && !WASM && !CONTRACT
    let v75 : (string -> string option) = Option.ofObj
    let v76 : string option = v75 v66
    v76 
    #else
    Some v66 
    #endif
    |> fun x -> _v66 <- Some x
    let v77 : string option = match _v66 with Some x -> x | None -> failwith "optionm'.of_obj / _v66=None"
    let v86 : US3 option = None
    let _v86 = ref v86 
    match v77 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v87 : string = x
    let v88 : US3 = US3_0(v87)
    v88 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v86.Value <- x
    let v89 : US3 option = _v86.Value 
    let v112 : US3 = US3_1
    let v113 : US3 = v89 |> Option.defaultValue v112 
    let v124 : string =
        match v113 with
        | US3_1 -> (* None *)
            let v122 : string = ""
            v122
        | US3_0(v121) -> (* Some *)
            v121
    v124 
    #endif
#else
    let v125 : (string -> string) = System.Environment.GetEnvironmentVariable
    let v126 : string = v125 v0
    let mutable _v126 = None
    #if !FABLE_COMPILER && !WASM && !CONTRACT
    let v129 : (string -> string option) = Option.ofObj
    let v130 : string option = v129 v126
    v130 
    #else
    Some v126 
    #endif
    |> fun x -> _v126 <- Some x
    let v131 : string option = match _v126 with Some x -> x | None -> failwith "optionm'.of_obj / _v126=None"
    let v140 : US3 option = None
    let _v140 = ref v140 
    match v131 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v141 : string = x
    let v142 : US3 = US3_0(v141)
    v142 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v140.Value <- x
    let v143 : US3 option = _v140.Value 
    let v166 : US3 = US3_1
    let v167 : US3 = v143 |> Option.defaultValue v166 
    let v178 : string =
        match v167 with
        | US3_1 -> (* None *)
            let v176 : string = ""
            v176
        | US3_0(v175) -> (* Some *)
            v175
    v178 
    #endif
    |> fun x -> _v3 <- Some x
    let v179 : string = match _v3 with Some x -> x | None -> failwith "base.run_target / _v3=None"
    v179
and method3 () : string =
    let v0 : string = "AUTOMATION"
    v0
and closure1 () (v0 : string) : unit =
    ()
and closure0 () (v0 : US0) : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) =
    let v3 : bool = true
    let mutable _v3 : struct (US1 * US2) option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v4 : string = method0()
    let v5 : string = method1(v4)
    let v7 : bool = "Verbose" = v5
    let v11 : US1 =
        if v7 then
            let v8 : US0 = US0_0
            US1_0(v8)
        else
            US1_1
    let v56 : US1 =
        match v11 with
        | US1_1 -> (* None *)
            let v15 : bool = "Debug" = v5
            let v19 : US1 =
                if v15 then
                    let v16 : US0 = US0_1
                    US1_0(v16)
                else
                    US1_1
            match v19 with
            | US1_1 -> (* None *)
                let v23 : bool = "Info" = v5
                let v27 : US1 =
                    if v23 then
                        let v24 : US0 = US0_2
                        US1_0(v24)
                    else
                        US1_1
                match v27 with
                | US1_1 -> (* None *)
                    let v31 : bool = "Warning" = v5
                    let v35 : US1 =
                        if v31 then
                            let v32 : US0 = US0_3
                            US1_0(v32)
                        else
                            US1_1
                    match v35 with
                    | US1_1 -> (* None *)
                        let v39 : bool = "Critical" = v5
                        let v43 : US1 =
                            if v39 then
                                let v40 : US0 = US0_4
                                US1_0(v40)
                            else
                                US1_1
                        match v43 with
                        | US1_1 -> (* None *)
                            US1_1
                        | US1_0(v44) -> (* Some *)
                            US1_0(v44)
                    | US1_0(v36) -> (* Some *)
                        US1_0(v36)
                | US1_0(v28) -> (* Some *)
                    US1_0(v28)
            | US1_0(v20) -> (* Some *)
                US1_0(v20)
        | US1_0(v12) -> (* Some *)
            US1_0(v12)
    let v57 : string = method3()
    let v58 : string = method1(v57)
    let v60 : bool = v58 = "True"
    let v82 : US2 =
        if v60 then
            let v63 : System.DateTime = System.DateTime.Now
            let v72 : (System.DateTime -> int64) = _.Ticks
            let v73 : int64 = v72 v63
            US2_0(v73)
        else
            US2_1
    struct (v56, v82) 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v83 : US1 = US1_1
    let v84 : US2 = US2_1
    struct (v83, v84) 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v85 : string = "AUTOMATION"
    let v88 : bool = true
    let mutable _v88 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v89 : string = "env!(\"" + v85 + "\")"
    let v90 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v89 
    let v91 : string = "String::from($0)"
    let v92 : std_string_String = Fable.Core.RustInterop.emitRustExpr v90 v91 
    let v93 : string = "fable_library_rust::String_::fromString($0)"
    let v94 : string = Fable.Core.RustInterop.emitRustExpr v92 v93 
    v94 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v95 : string = "env!(\"" + v85 + "\")"
    let v96 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v95 
    let v97 : string = "String::from($0)"
    let v98 : std_string_String = Fable.Core.RustInterop.emitRustExpr v96 v97 
    let v99 : string = "fable_library_rust::String_::fromString($0)"
    let v100 : string = Fable.Core.RustInterop.emitRustExpr v98 v99 
    v100 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v101 : string = "env!(\"" + v85 + "\")"
    let v102 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v101 
    let v103 : string = "String::from($0)"
    let v104 : std_string_String = Fable.Core.RustInterop.emitRustExpr v102 v103 
    let v105 : string = "fable_library_rust::String_::fromString($0)"
    let v106 : string = Fable.Core.RustInterop.emitRustExpr v104 v105 
    v106 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v109 : string = null |> unbox<string>
    v109 
    #endif
#if FABLE_COMPILER_PYTHON
    let v118 : string = null |> unbox<string>
    v118 
    #endif
#else
    let v127 : string = null |> unbox<string>
    v127 
    #endif
    |> fun x -> _v88 <- Some x
    let v134 : string = match _v88 with Some x -> x | None -> failwith "base.run_target / _v88=None"
    let v151 : string = "True"
    let v152 : bool = v134 <> v151 
    let v165 : US2 =
        if v152 then
            US2_1
        else
            let v160 : string = $"near_sdk::env::block_timestamp()"
            let v161 : uint64 = Fable.Core.RustInterop.emitRustExpr () v160 
            let v162 : (uint64 -> int64) = int64
            let v163 : int64 = v162 v161
            US2_0(v163)
    let v166 : US1 = US1_1
    struct (v166, v165) 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v167 : string = method0()
    let v168 : string = method1(v167)
    let v170 : bool = "Verbose" = v168
    let v174 : US1 =
        if v170 then
            let v171 : US0 = US0_0
            US1_0(v171)
        else
            US1_1
    let v219 : US1 =
        match v174 with
        | US1_1 -> (* None *)
            let v178 : bool = "Debug" = v168
            let v182 : US1 =
                if v178 then
                    let v179 : US0 = US0_1
                    US1_0(v179)
                else
                    US1_1
            match v182 with
            | US1_1 -> (* None *)
                let v186 : bool = "Info" = v168
                let v190 : US1 =
                    if v186 then
                        let v187 : US0 = US0_2
                        US1_0(v187)
                    else
                        US1_1
                match v190 with
                | US1_1 -> (* None *)
                    let v194 : bool = "Warning" = v168
                    let v198 : US1 =
                        if v194 then
                            let v195 : US0 = US0_3
                            US1_0(v195)
                        else
                            US1_1
                    match v198 with
                    | US1_1 -> (* None *)
                        let v202 : bool = "Critical" = v168
                        let v206 : US1 =
                            if v202 then
                                let v203 : US0 = US0_4
                                US1_0(v203)
                            else
                                US1_1
                        match v206 with
                        | US1_1 -> (* None *)
                            US1_1
                        | US1_0(v207) -> (* Some *)
                            US1_0(v207)
                    | US1_0(v199) -> (* Some *)
                        US1_0(v199)
                | US1_0(v191) -> (* Some *)
                    US1_0(v191)
            | US1_0(v183) -> (* Some *)
                US1_0(v183)
        | US1_0(v175) -> (* Some *)
            US1_0(v175)
    let v220 : string = method3()
    let v221 : string = method1(v220)
    let v222 : bool = v221 = "True"
    let v244 : US2 =
        if v222 then
            let v225 : System.DateTime = System.DateTime.Now
            let v234 : (System.DateTime -> int64) = _.Ticks
            let v235 : int64 = v234 v225
            US2_0(v235)
        else
            US2_1
    struct (v219, v244) 
    #endif
#if FABLE_COMPILER_PYTHON
    let v245 : string = method0()
    let v246 : string = method1(v245)
    let v248 : bool = "Verbose" = v246
    let v252 : US1 =
        if v248 then
            let v249 : US0 = US0_0
            US1_0(v249)
        else
            US1_1
    let v297 : US1 =
        match v252 with
        | US1_1 -> (* None *)
            let v256 : bool = "Debug" = v246
            let v260 : US1 =
                if v256 then
                    let v257 : US0 = US0_1
                    US1_0(v257)
                else
                    US1_1
            match v260 with
            | US1_1 -> (* None *)
                let v264 : bool = "Info" = v246
                let v268 : US1 =
                    if v264 then
                        let v265 : US0 = US0_2
                        US1_0(v265)
                    else
                        US1_1
                match v268 with
                | US1_1 -> (* None *)
                    let v272 : bool = "Warning" = v246
                    let v276 : US1 =
                        if v272 then
                            let v273 : US0 = US0_3
                            US1_0(v273)
                        else
                            US1_1
                    match v276 with
                    | US1_1 -> (* None *)
                        let v280 : bool = "Critical" = v246
                        let v284 : US1 =
                            if v280 then
                                let v281 : US0 = US0_4
                                US1_0(v281)
                            else
                                US1_1
                        match v284 with
                        | US1_1 -> (* None *)
                            US1_1
                        | US1_0(v285) -> (* Some *)
                            US1_0(v285)
                    | US1_0(v277) -> (* Some *)
                        US1_0(v277)
                | US1_0(v269) -> (* Some *)
                    US1_0(v269)
            | US1_0(v261) -> (* Some *)
                US1_0(v261)
        | US1_0(v253) -> (* Some *)
            US1_0(v253)
    let v298 : string = method3()
    let v299 : string = method1(v298)
    let v300 : bool = v299 = "True"
    let v322 : US2 =
        if v300 then
            let v303 : System.DateTime = System.DateTime.Now
            let v312 : (System.DateTime -> int64) = _.Ticks
            let v313 : int64 = v312 v303
            US2_0(v313)
        else
            US2_1
    struct (v297, v322) 
    #endif
#else
    let v323 : string = method0()
    let v324 : string = method1(v323)
    let v326 : bool = "Verbose" = v324
    let v330 : US1 =
        if v326 then
            let v327 : US0 = US0_0
            US1_0(v327)
        else
            US1_1
    let v375 : US1 =
        match v330 with
        | US1_1 -> (* None *)
            let v334 : bool = "Debug" = v324
            let v338 : US1 =
                if v334 then
                    let v335 : US0 = US0_1
                    US1_0(v335)
                else
                    US1_1
            match v338 with
            | US1_1 -> (* None *)
                let v342 : bool = "Info" = v324
                let v346 : US1 =
                    if v342 then
                        let v343 : US0 = US0_2
                        US1_0(v343)
                    else
                        US1_1
                match v346 with
                | US1_1 -> (* None *)
                    let v350 : bool = "Warning" = v324
                    let v354 : US1 =
                        if v350 then
                            let v351 : US0 = US0_3
                            US1_0(v351)
                        else
                            US1_1
                    match v354 with
                    | US1_1 -> (* None *)
                        let v358 : bool = "Critical" = v324
                        let v362 : US1 =
                            if v358 then
                                let v359 : US0 = US0_4
                                US1_0(v359)
                            else
                                US1_1
                        match v362 with
                        | US1_1 -> (* None *)
                            US1_1
                        | US1_0(v363) -> (* Some *)
                            US1_0(v363)
                    | US1_0(v355) -> (* Some *)
                        US1_0(v355)
                | US1_0(v347) -> (* Some *)
                    US1_0(v347)
            | US1_0(v339) -> (* Some *)
                US1_0(v339)
        | US1_0(v331) -> (* Some *)
            US1_0(v331)
    let v376 : string = method3()
    let v377 : string = method1(v376)
    let v378 : bool = v377 = "True"
    let v400 : US2 =
        if v378 then
            let v381 : System.DateTime = System.DateTime.Now
            let v390 : (System.DateTime -> int64) = _.Ticks
            let v391 : int64 = v390 v381
            US2_0(v391)
        else
            US2_1
    struct (v375, v400) 
    #endif
    |> fun x -> _v3 <- Some x
    let struct (v401 : US1, v402 : US2) = match _v3 with Some x -> x | None -> failwith "base.run_target / _v3=None"
    let v487 : Mut2 = {l0 = true} : Mut2
    let v488 : Mut0 = {l0 = 0L} : Mut0
    let v491 : US0 =
        match v401 with
        | US1_1 -> (* None *)
            v0
        | US1_0(v489) -> (* Some *)
            v489
    let v492 : Mut3 = {l0 = v491} : Mut3
    let v493 : (string -> unit) = closure1()
    let v494 : Mut1 = {l0 = v493} : Mut1
    let v507 : int64 option =
        match v402 with
        | US2_1 -> (* None *)
            let v505 : int64 option = None
            v505
        | US2_0(v495) -> (* Some *)
            let v498 : int64 option = Some v495 
            v498
    struct (v488, v494, v487, v492, v507)
and closure4 () () : string =
    let v0 : string = $"networking.test_port_open"
    v0
and closure5 (v0 : int32, v1 : string) () : struct (int32 * string) =
    struct (v0, v1)
and method5 () : string =
    let v0 : string = "hh:mm:ss"
    v0
and method6 () : string =
    let v0 : string = "HH:mm:ss"
    v0
and method7 () : string =
    let v0 : string = "\u001b[0m"
    v0
and method9 (v0 : Mut4, v1 : string) : unit =
    let v4 : string = $"{v1}"
    let v11 : string = v0.l0
    let v12 : string = v11 + v4 
    v0.l0 <- v12
    ()
and method10 (v0 : Mut4) : unit =
    ()
and method11 (v0 : Mut4, v1 : int32) : unit =
    let v4 : string = $"{v1}"
    let v11 : string = v0.l0
    let v12 : string = v11 + v4 
    v0.l0 <- v12
    ()
and method8 (v0 : Mut4, v1 : int32, v2 : string) : unit =
    let v3 : string = "{ "
    method9(v0, v3)
    method10(v0)
    let v4 : string = "port"
    method9(v0, v4)
    let v5 : string = " = "
    method9(v0, v5)
    method11(v0, v1)
    let v6 : string = "; "
    method9(v0, v6)
    let v7 : string = "ex"
    method9(v0, v7)
    method9(v0, v5)
    method9(v0, v2)
    let v8 : string = " }"
    method9(v0, v8)
and closure6 (v0 : US0, v1 : (unit -> string), v2 : (unit -> struct (int32 * string))) () : string =
    let v5 : (US0 -> struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option)) = closure0()
    let v6 : US0 = US0_0
    if State.trace_state.IsNone then State.trace_state <- v5 v6 |> Some
    let struct (v14 : Mut0, v15 : Mut1, v16 : Mut2, v17 : Mut3, v18 : int64 option) = State.trace_state.Value
    let v35 : bool = true
    let mutable _v35 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v38 : US2 option = None
    let _v38 = ref v38 
    match v18 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v39 : int64 = x
    let v40 : US2 = US2_0(v39)
    v40 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v38.Value <- x
    let v41 : US2 option = _v38.Value 
    let v64 : US2 = US2_1
    let v65 : US2 = v41 |> Option.defaultValue v64 
    let v163 : System.DateTime =
        match v65 with
        | US2_1 -> (* None *)
            let v155 : System.DateTime = System.DateTime.Now
            v155
        | US2_0(v73) -> (* Some *)
            let v76 : System.DateTime = System.DateTime.Now
            let v85 : (System.DateTime -> int64) = _.Ticks
            let v86 : int64 = v85 v76
            let v93 : int64 = v86 - v73
            let v96 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v97 : System.TimeSpan = v96 v93
            let v106 : (System.TimeSpan -> int32) = _.Hours
            let v107 : int32 = v106 v97
            let v116 : (System.TimeSpan -> int32) = _.Minutes
            let v117 : int32 = v116 v97
            let v126 : (System.TimeSpan -> int32) = _.Seconds
            let v127 : int32 = v126 v97
            let v136 : (System.TimeSpan -> int32) = _.Milliseconds
            let v137 : int32 = v136 v97
            let v146 : System.DateTime = System.DateTime (1, 1, 1, v107, v117, v127, v137)
            v146
    let v166 : string = method5()
    let v175 : (string -> string) = v163.ToString
    let v176 : string = v175 v166
    v176 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v185 : US2 option = None
    let _v185 = ref v185 
    match v18 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v186 : int64 = x
    let v187 : US2 = US2_0(v186)
    v187 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v185.Value <- x
    let v188 : US2 option = _v185.Value 
    let v211 : US2 = US2_1
    let v212 : US2 = v188 |> Option.defaultValue v211 
    let v310 : System.DateTime =
        match v212 with
        | US2_1 -> (* None *)
            let v302 : System.DateTime = System.DateTime.Now
            v302
        | US2_0(v220) -> (* Some *)
            let v223 : System.DateTime = System.DateTime.Now
            let v232 : (System.DateTime -> int64) = _.Ticks
            let v233 : int64 = v232 v223
            let v240 : int64 = v233 - v220
            let v243 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v244 : System.TimeSpan = v243 v240
            let v253 : (System.TimeSpan -> int32) = _.Hours
            let v254 : int32 = v253 v244
            let v263 : (System.TimeSpan -> int32) = _.Minutes
            let v264 : int32 = v263 v244
            let v273 : (System.TimeSpan -> int32) = _.Seconds
            let v274 : int32 = v273 v244
            let v283 : (System.TimeSpan -> int32) = _.Milliseconds
            let v284 : int32 = v283 v244
            let v293 : System.DateTime = System.DateTime (1, 1, 1, v254, v264, v274, v284)
            v293
    let v313 : string = method5()
    let v322 : (string -> string) = v310.ToString
    let v323 : string = v322 v313
    v323 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v330 : string = $"near_sdk::env::block_timestamp()"
    let v331 : uint64 = Fable.Core.RustInterop.emitRustExpr () v330 
    let v334 : US2 option = None
    let _v334 = ref v334 
    match v18 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v335 : int64 = x
    let v336 : US2 = US2_0(v335)
    v336 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v334.Value <- x
    let v337 : US2 option = _v334.Value 
    let v360 : US2 = US2_1
    let v361 : US2 = v337 |> Option.defaultValue v360 
    let v374 : uint64 =
        match v361 with
        | US2_1 -> (* None *)
            v331
        | US2_0(v369) -> (* Some *)
            let v370 : (int64 -> uint64) = uint64
            let v371 : uint64 = v370 v369
            let v372 : uint64 = v331 - v371
            v372
    let v375 : uint64 = v374 / 1000000000UL
    let v376 : uint64 = v375 % 60UL
    let v377 : uint64 = v375 / 60UL
    let v378 : uint64 = v377 % 60UL
    let v379 : uint64 = v375 / 3600UL
    let v380 : uint64 = v379 % 24UL
    let v381 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
    let v382 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v380, v378, v376) v381 
    let v383 : string = "fable_library_rust::String_::fromString($0)"
    let v384 : string = Fable.Core.RustInterop.emitRustExpr v382 v383 
    v384 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v387 : US2 option = None
    let _v387 = ref v387 
    match v18 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v388 : int64 = x
    let v389 : US2 = US2_0(v388)
    v389 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v387.Value <- x
    let v390 : US2 option = _v387.Value 
    let v413 : US2 = US2_1
    let v414 : US2 = v390 |> Option.defaultValue v413 
    let v512 : System.DateTime =
        match v414 with
        | US2_1 -> (* None *)
            let v504 : System.DateTime = System.DateTime.Now
            v504
        | US2_0(v422) -> (* Some *)
            let v425 : System.DateTime = System.DateTime.Now
            let v434 : (System.DateTime -> int64) = _.Ticks
            let v435 : int64 = v434 v425
            let v442 : int64 = v435 - v422
            let v445 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v446 : System.TimeSpan = v445 v442
            let v455 : (System.TimeSpan -> int32) = _.Hours
            let v456 : int32 = v455 v446
            let v465 : (System.TimeSpan -> int32) = _.Minutes
            let v466 : int32 = v465 v446
            let v475 : (System.TimeSpan -> int32) = _.Seconds
            let v476 : int32 = v475 v446
            let v485 : (System.TimeSpan -> int32) = _.Milliseconds
            let v486 : int32 = v485 v446
            let v495 : System.DateTime = System.DateTime (1, 1, 1, v456, v466, v476, v486)
            v495
    let v515 : string = method6()
    let v524 : (string -> string) = v512.ToString
    let v525 : string = v524 v515
    v525 
    #endif
#if FABLE_COMPILER_PYTHON
    let v534 : US2 option = None
    let _v534 = ref v534 
    match v18 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v535 : int64 = x
    let v536 : US2 = US2_0(v535)
    v536 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v534.Value <- x
    let v537 : US2 option = _v534.Value 
    let v560 : US2 = US2_1
    let v561 : US2 = v537 |> Option.defaultValue v560 
    let v659 : System.DateTime =
        match v561 with
        | US2_1 -> (* None *)
            let v651 : System.DateTime = System.DateTime.Now
            v651
        | US2_0(v569) -> (* Some *)
            let v572 : System.DateTime = System.DateTime.Now
            let v581 : (System.DateTime -> int64) = _.Ticks
            let v582 : int64 = v581 v572
            let v589 : int64 = v582 - v569
            let v592 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v593 : System.TimeSpan = v592 v589
            let v602 : (System.TimeSpan -> int32) = _.Hours
            let v603 : int32 = v602 v593
            let v612 : (System.TimeSpan -> int32) = _.Minutes
            let v613 : int32 = v612 v593
            let v622 : (System.TimeSpan -> int32) = _.Seconds
            let v623 : int32 = v622 v593
            let v632 : (System.TimeSpan -> int32) = _.Milliseconds
            let v633 : int32 = v632 v593
            let v642 : System.DateTime = System.DateTime (1, 1, 1, v603, v613, v623, v633)
            v642
    let v662 : string = method6()
    let v671 : (string -> string) = v659.ToString
    let v672 : string = v671 v662
    v672 
    #endif
#else
    let v681 : US2 option = None
    let _v681 = ref v681 
    match v18 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v682 : int64 = x
    let v683 : US2 = US2_0(v682)
    v683 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v681.Value <- x
    let v684 : US2 option = _v681.Value 
    let v707 : US2 = US2_1
    let v708 : US2 = v684 |> Option.defaultValue v707 
    let v806 : System.DateTime =
        match v708 with
        | US2_1 -> (* None *)
            let v798 : System.DateTime = System.DateTime.Now
            v798
        | US2_0(v716) -> (* Some *)
            let v719 : System.DateTime = System.DateTime.Now
            let v728 : (System.DateTime -> int64) = _.Ticks
            let v729 : int64 = v728 v719
            let v736 : int64 = v729 - v716
            let v739 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v740 : System.TimeSpan = v739 v736
            let v749 : (System.TimeSpan -> int32) = _.Hours
            let v750 : int32 = v749 v740
            let v759 : (System.TimeSpan -> int32) = _.Minutes
            let v760 : int32 = v759 v740
            let v769 : (System.TimeSpan -> int32) = _.Seconds
            let v770 : int32 = v769 v740
            let v779 : (System.TimeSpan -> int32) = _.Milliseconds
            let v780 : int32 = v779 v740
            let v789 : System.DateTime = System.DateTime (1, 1, 1, v750, v760, v770, v780)
            v789
    let v809 : string = method6()
    let v818 : (string -> string) = v806.ToString
    let v819 : string = v818 v809
    v819 
    #endif
    |> fun x -> _v35 <- Some x
    let v826 : string = match _v35 with Some x -> x | None -> failwith "base.run_target / _v35=None"
    let v981 : bool =
        match v0 with
        | US0_0 -> (* Verbose *)
            true
        | _ ->
            false
    let v985 : US3 =
        if v981 then
            let v982 : string = "Verbose"
            US3_0(v982)
        else
            US3_1
    let v1034 : US3 =
        match v985 with
        | US3_1 -> (* None *)
            let v990 : bool =
                match v0 with
                | US0_1 -> (* Debug *)
                    true
                | _ ->
                    false
            let v994 : US3 =
                if v990 then
                    let v991 : string = "Debug"
                    US3_0(v991)
                else
                    US3_1
            match v994 with
            | US3_1 -> (* None *)
                let v999 : bool =
                    match v0 with
                    | US0_2 -> (* Info *)
                        true
                    | _ ->
                        false
                let v1003 : US3 =
                    if v999 then
                        let v1000 : string = "Info"
                        US3_0(v1000)
                    else
                        US3_1
                match v1003 with
                | US3_1 -> (* None *)
                    let v1008 : bool =
                        match v0 with
                        | US0_3 -> (* Warning *)
                            true
                        | _ ->
                            false
                    let v1012 : US3 =
                        if v1008 then
                            let v1009 : string = "Warning"
                            US3_0(v1009)
                        else
                            US3_1
                    match v1012 with
                    | US3_1 -> (* None *)
                        let v1017 : bool =
                            match v0 with
                            | US0_4 -> (* Critical *)
                                true
                            | _ ->
                                false
                        let v1021 : US3 =
                            if v1017 then
                                let v1018 : string = "Critical"
                                US3_0(v1018)
                            else
                                US3_1
                        match v1021 with
                        | US3_1 -> (* None *)
                            US3_1
                        | US3_0(v1022) -> (* Some *)
                            US3_0(v1022)
                    | US3_0(v1013) -> (* Some *)
                        US3_0(v1013)
                | US3_0(v1004) -> (* Some *)
                    US3_0(v1004)
            | US3_0(v995) -> (* Some *)
                US3_0(v995)
        | US3_0(v986) -> (* Some *)
            US3_0(v986)
    let v1038 : string =
        match v1034 with
        | US3_1 -> (* None *)
            failwith<string> "Option does not have a value."
        | US3_0(v1035) -> (* Some *)
            v1035
    let v1041 : (unit -> string) = v1038.ToLower
    let v1042 : string = v1041 ()
    let v1051 : string = v1042.PadLeft (7, ' ')
    let v1083 : bool = true
    let mutable _v1083 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1098 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v1092 : string = "inline_colorization::color_bright_red"
            let v1093 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1092 
            v1093
        | US0_1 -> (* Debug *)
            let v1086 : string = "inline_colorization::color_bright_blue"
            let v1087 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1086 
            v1087
        | US0_2 -> (* Info *)
            let v1088 : string = "inline_colorization::color_bright_green"
            let v1089 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1088 
            v1089
        | US0_0 -> (* Verbose *)
            let v1084 : string = "inline_colorization::color_bright_black"
            let v1085 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1084 
            v1085
        | US0_3 -> (* Warning *)
            let v1090 : string = "inline_colorization::color_yellow"
            let v1091 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1090 
            v1091
    let v1099 : string = "&*$0"
    let v1100 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1051 v1099 
    let v1101 : string = "inline_colorization::color_reset"
    let v1102 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1101 
    let v1103 : string = "\"{v1098}{v1100}{v1102}\""
    let v1104 : string = @$"format!(" + v1103 + ")"
    let v1105 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v1104 
    let v1106 : string = "fable_library_rust::String_::fromString($0)"
    let v1107 : string = Fable.Core.RustInterop.emitRustExpr v1105 v1106 
    v1107 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1122 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v1116 : string = "inline_colorization::color_bright_red"
            let v1117 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1116 
            v1117
        | US0_1 -> (* Debug *)
            let v1110 : string = "inline_colorization::color_bright_blue"
            let v1111 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1110 
            v1111
        | US0_2 -> (* Info *)
            let v1112 : string = "inline_colorization::color_bright_green"
            let v1113 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1112 
            v1113
        | US0_0 -> (* Verbose *)
            let v1108 : string = "inline_colorization::color_bright_black"
            let v1109 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1108 
            v1109
        | US0_3 -> (* Warning *)
            let v1114 : string = "inline_colorization::color_yellow"
            let v1115 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1114 
            v1115
    let v1123 : string = "&*$0"
    let v1124 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1051 v1123 
    let v1125 : string = "inline_colorization::color_reset"
    let v1126 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1125 
    let v1127 : string = "\"{v1122}{v1124}{v1126}\""
    let v1128 : string = @$"format!(" + v1127 + ")"
    let v1129 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v1128 
    let v1130 : string = "fable_library_rust::String_::fromString($0)"
    let v1131 : string = Fable.Core.RustInterop.emitRustExpr v1129 v1130 
    v1131 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1146 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v1140 : string = "inline_colorization::color_bright_red"
            let v1141 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1140 
            v1141
        | US0_1 -> (* Debug *)
            let v1134 : string = "inline_colorization::color_bright_blue"
            let v1135 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1134 
            v1135
        | US0_2 -> (* Info *)
            let v1136 : string = "inline_colorization::color_bright_green"
            let v1137 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1136 
            v1137
        | US0_0 -> (* Verbose *)
            let v1132 : string = "inline_colorization::color_bright_black"
            let v1133 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1132 
            v1133
        | US0_3 -> (* Warning *)
            let v1138 : string = "inline_colorization::color_yellow"
            let v1139 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1138 
            v1139
    let v1147 : string = "&*$0"
    let v1148 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1051 v1147 
    let v1149 : string = "inline_colorization::color_reset"
    let v1150 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1149 
    let v1151 : string = "\"{v1146}{v1148}{v1150}\""
    let v1152 : string = @$"format!(" + v1151 + ")"
    let v1153 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v1152 
    let v1154 : string = "fable_library_rust::String_::fromString($0)"
    let v1155 : string = Fable.Core.RustInterop.emitRustExpr v1153 v1154 
    v1155 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1165 : string =
        match v0 with
        | US0_4 -> (* Critical *)
            let v1160 : string = "\u001b[91m"
            v1160
        | US0_1 -> (* Debug *)
            let v1157 : string = "\u001b[94m"
            v1157
        | US0_2 -> (* Info *)
            let v1158 : string = "\u001b[92m"
            v1158
        | US0_0 -> (* Verbose *)
            let v1156 : string = "\u001b[90m"
            v1156
        | US0_3 -> (* Warning *)
            let v1159 : string = "\u001b[93m"
            v1159
    let v1166 : string = method7()
    let v1167 : string = v1165 + v1051 
    let v1168 : string = v1167 + v1166 
    v1168 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1178 : string =
        match v0 with
        | US0_4 -> (* Critical *)
            let v1173 : string = "\u001b[91m"
            v1173
        | US0_1 -> (* Debug *)
            let v1170 : string = "\u001b[94m"
            v1170
        | US0_2 -> (* Info *)
            let v1171 : string = "\u001b[92m"
            v1171
        | US0_0 -> (* Verbose *)
            let v1169 : string = "\u001b[90m"
            v1169
        | US0_3 -> (* Warning *)
            let v1172 : string = "\u001b[93m"
            v1172
    let v1179 : string = method7()
    let v1180 : string = v1178 + v1051 
    let v1181 : string = v1180 + v1179 
    v1181 
    #endif
#else
    let v1191 : string =
        match v0 with
        | US0_4 -> (* Critical *)
            let v1186 : string = "\u001b[91m"
            v1186
        | US0_1 -> (* Debug *)
            let v1183 : string = "\u001b[94m"
            v1183
        | US0_2 -> (* Info *)
            let v1184 : string = "\u001b[92m"
            v1184
        | US0_0 -> (* Verbose *)
            let v1182 : string = "\u001b[90m"
            v1182
        | US0_3 -> (* Warning *)
            let v1185 : string = "\u001b[93m"
            v1185
    let v1192 : string = method7()
    let v1193 : string = v1191 + v1051 
    let v1194 : string = v1193 + v1192 
    v1194 
    #endif
    |> fun x -> _v1083 <- Some x
    let v1195 : string = match _v1083 with Some x -> x | None -> failwith "base.run_target / _v1083=None"
    let v1214 : int64 = v14.l0
    let struct (v1215 : int32, v1216 : string) = v2 ()
    let v1217 : string = ""
    let v1218 : Mut4 = {l0 = v1217} : Mut4
    method8(v1218, v1215, v1216)
    let v1219 : string = v1218.l0
    let v1222 : string = $"{v826} {v1195} #{v1214} %s{v1 ()} / {v1219}"
    let v1229 : char list = []
    let v1234 : (char list -> (char [])) = List.toArray
    let v1235 : (char []) = v1234 v1229
    let v1242 : string = v1222.TrimStart v1235 
    let v1281 : char list = []
    let v1284 : char list = '/' :: v1281 
    let v1293 : char list = ' ' :: v1284 
    let v1304 : (char list -> (char [])) = List.toArray
    let v1305 : (char []) = v1304 v1293
    let v1312 : string = v1242.TrimEnd v1305 
    v1312
and method12 (v0 : US0, v1 : (unit -> string)) : unit =
    let v4 : (US0 -> struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option)) = closure0()
    let v5 : US0 = US0_0
    if State.trace_state.IsNone then State.trace_state <- v4 v5 |> Some
    let struct (v13 : Mut0, v14 : Mut1, v15 : Mut2, v16 : Mut3, v17 : int64 option) = State.trace_state.Value
    let v34 : US0 = US0_0
    if State.trace_state.IsNone then State.trace_state <- v4 v34 |> Some
    let struct (v42 : Mut0, v43 : Mut1, v44 : Mut2, v45 : Mut3, v46 : int64 option) = State.trace_state.Value
    let v61 : US0 = v45.l0
    let v62 : bool = v44.l0
    let v63 : bool = v62 = false
    let v67 : bool =
        if v63 then
            false
        else
            let v64 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v0
            let v65 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v61
            let v66 : bool = v64 >= v65
            v66
    if v67 then
        let v68 : int64 = v13.l0
        let v69 : int64 = v68 + 1L
        v13.l0 <- v69
        let v72 : string = $"%s{v1 ()}"
        let v81 : bool = true
        let mutable _v81 : unit option = None 
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v82 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v72 v82 
        () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v83 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v72 v83 
        () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v84 : string = $"near_sdk::log!(\"{{}}\", $0)"
        Fable.Core.RustInterop.emitRustExpr v72 v84 
        () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        System.Console.WriteLine v72 
        () 
        #endif
#if FABLE_COMPILER_PYTHON
        System.Console.WriteLine v72 
        () 
        #endif
#else
        System.Console.WriteLine v72 
        () 
        #endif
        |> fun x -> _v81 <- Some x
        match _v81 with Some x -> x | None -> failwith "base.run_target / _v81=None"
        let v113 : (string -> unit) = v14.l0
        v113 v72
and method4 (v0 : US0, v1 : (unit -> string), v2 : (unit -> struct (int32 * string))) : unit =
    let v3 : (unit -> string) = closure6(v0, v1, v2)
    method12(v0, v3)
and closure3 (v0 : string) (v1 : int32) : Async<bool> =
    let v4 : bool = true
    let mutable _v4 : Async<bool> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v7 : Async<bool> = null |> unbox<Async<bool>>
    v7 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v16 : Async<bool> = null |> unbox<Async<bool>>
    v16 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v25 : Async<bool> = null |> unbox<Async<bool>>
    v25 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v34 : Async<bool> = null |> unbox<Async<bool>>
    v34 
    #endif
#if FABLE_COMPILER_PYTHON
    let v43 : Async<bool> = null |> unbox<Async<bool>>
    v43 
    #endif
#else
    let v50 : Async<bool> option = None
    let mutable _v50 = v50 
    async {
    let v51 : Async<System.Threading.CancellationToken> = Async.CancellationToken
    let! v51 = v51 
    let v52 : System.Threading.CancellationToken = v51 
    let v53 : System.Net.Sockets.TcpClient = new System.Net.Sockets.TcpClient ()
    use v53 = v53 
    let v54 : System.Net.Sockets.TcpClient = v53 
    try
    let v55 : System.Threading.Tasks.ValueTask = v54.ConnectAsync (v0, v1, v52)
    let v56 : (unit -> System.Threading.Tasks.Task) = v55.AsTask
    let v57 : System.Threading.Tasks.Task = v56 ()
    let v60 : bool = true
    let mutable _v60 : Async<unit> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v63 : Async<unit> = null |> unbox<Async<unit>>
    v63 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v72 : Async<unit> = null |> unbox<Async<unit>>
    v72 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v81 : Async<unit> = null |> unbox<Async<unit>>
    v81 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v90 : Async<unit> = null |> unbox<Async<unit>>
    v90 
    #endif
#if FABLE_COMPILER_PYTHON
    let v99 : Async<unit> = null |> unbox<Async<unit>>
    v99 
    #endif
#else
    let v106 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
    let v107 : Async<unit> = v106 v57
    v107 
    #endif
    |> fun x -> _v60 <- Some x
    let v108 : Async<unit> = match _v60 with Some x -> x | None -> failwith "base.run_target / _v60=None"
    do! v108 
    return true 
    with ex ->
    let v123 : exn = ex
    let v126 : bool = true
    let mutable _v126 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v129 : string = $"%A{v123}"
    v129 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v138 : string = $"%A{v123}"
    v138 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v147 : string = $"%A{v123}"
    v147 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v156 : string = $"%A{v123}"
    v156 
    #endif
#if FABLE_COMPILER_PYTHON
    let v165 : string = $"%A{v123}"
    v165 
    #endif
#else
    let v172 : string = $"{v123.GetType ()}: {v123.Message}"
    v172 
    #endif
    |> fun x -> _v126 <- Some x
    let v173 : string = match _v126 with Some x -> x | None -> failwith "base.run_target / _v126=None"
    let v188 : US0 = US0_0
    let v189 : (unit -> string) = closure4()
    let v190 : (unit -> struct (int32 * string)) = closure5(v1, v173)
    method4(v188, v189, v190)
    return false 
    (*
    let v191 : bool = *)
    }
    |> fun x -> _v50 <- Some x
    let v192 : Async<bool> = match _v50 with Some x -> x | None -> failwith "async.new_async_unit / _v50=None"
    v192 
    #endif
    |> fun x -> _v4 <- Some x
    let v193 : Async<bool> = match _v4 with Some x -> x | None -> failwith "base.run_target / _v4=None"
    v193
and closure2 () (v0 : string) : (int32 -> Async<bool>) =
    closure3(v0)
and closure10 () (v0 : bool) : US5 =
    US5_0(v0)
and closure11 () (v0 : exn) : US5 =
    US5_1(v0)
and closure12 () () : string =
    let v0 : string = "async.run_with_timeout_async"
    v0
and closure13 (v0 : int32) () : int32 =
    v0
and method14 (v0 : Mut4, v1 : int32) : unit =
    let v2 : string = "{ "
    method9(v0, v2)
    method10(v0)
    let v3 : string = "timeout"
    method9(v0, v3)
    let v4 : string = " = "
    method9(v0, v4)
    method11(v0, v1)
    let v5 : string = " }"
    method9(v0, v5)
and closure14 (v0 : US0, v1 : (unit -> string), v2 : (unit -> int32)) () : string =
    let v5 : (US0 -> struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option)) = closure0()
    let v6 : US0 = US0_0
    if State.trace_state.IsNone then State.trace_state <- v5 v6 |> Some
    let struct (v14 : Mut0, v15 : Mut1, v16 : Mut2, v17 : Mut3, v18 : int64 option) = State.trace_state.Value
    let v35 : bool = true
    let mutable _v35 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v38 : US2 option = None
    let _v38 = ref v38 
    match v18 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v39 : int64 = x
    let v40 : US2 = US2_0(v39)
    v40 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v38.Value <- x
    let v41 : US2 option = _v38.Value 
    let v64 : US2 = US2_1
    let v65 : US2 = v41 |> Option.defaultValue v64 
    let v163 : System.DateTime =
        match v65 with
        | US2_1 -> (* None *)
            let v155 : System.DateTime = System.DateTime.Now
            v155
        | US2_0(v73) -> (* Some *)
            let v76 : System.DateTime = System.DateTime.Now
            let v85 : (System.DateTime -> int64) = _.Ticks
            let v86 : int64 = v85 v76
            let v93 : int64 = v86 - v73
            let v96 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v97 : System.TimeSpan = v96 v93
            let v106 : (System.TimeSpan -> int32) = _.Hours
            let v107 : int32 = v106 v97
            let v116 : (System.TimeSpan -> int32) = _.Minutes
            let v117 : int32 = v116 v97
            let v126 : (System.TimeSpan -> int32) = _.Seconds
            let v127 : int32 = v126 v97
            let v136 : (System.TimeSpan -> int32) = _.Milliseconds
            let v137 : int32 = v136 v97
            let v146 : System.DateTime = System.DateTime (1, 1, 1, v107, v117, v127, v137)
            v146
    let v166 : string = method5()
    let v175 : (string -> string) = v163.ToString
    let v176 : string = v175 v166
    v176 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v185 : US2 option = None
    let _v185 = ref v185 
    match v18 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v186 : int64 = x
    let v187 : US2 = US2_0(v186)
    v187 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v185.Value <- x
    let v188 : US2 option = _v185.Value 
    let v211 : US2 = US2_1
    let v212 : US2 = v188 |> Option.defaultValue v211 
    let v310 : System.DateTime =
        match v212 with
        | US2_1 -> (* None *)
            let v302 : System.DateTime = System.DateTime.Now
            v302
        | US2_0(v220) -> (* Some *)
            let v223 : System.DateTime = System.DateTime.Now
            let v232 : (System.DateTime -> int64) = _.Ticks
            let v233 : int64 = v232 v223
            let v240 : int64 = v233 - v220
            let v243 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v244 : System.TimeSpan = v243 v240
            let v253 : (System.TimeSpan -> int32) = _.Hours
            let v254 : int32 = v253 v244
            let v263 : (System.TimeSpan -> int32) = _.Minutes
            let v264 : int32 = v263 v244
            let v273 : (System.TimeSpan -> int32) = _.Seconds
            let v274 : int32 = v273 v244
            let v283 : (System.TimeSpan -> int32) = _.Milliseconds
            let v284 : int32 = v283 v244
            let v293 : System.DateTime = System.DateTime (1, 1, 1, v254, v264, v274, v284)
            v293
    let v313 : string = method5()
    let v322 : (string -> string) = v310.ToString
    let v323 : string = v322 v313
    v323 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v330 : string = $"near_sdk::env::block_timestamp()"
    let v331 : uint64 = Fable.Core.RustInterop.emitRustExpr () v330 
    let v334 : US2 option = None
    let _v334 = ref v334 
    match v18 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v335 : int64 = x
    let v336 : US2 = US2_0(v335)
    v336 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v334.Value <- x
    let v337 : US2 option = _v334.Value 
    let v360 : US2 = US2_1
    let v361 : US2 = v337 |> Option.defaultValue v360 
    let v374 : uint64 =
        match v361 with
        | US2_1 -> (* None *)
            v331
        | US2_0(v369) -> (* Some *)
            let v370 : (int64 -> uint64) = uint64
            let v371 : uint64 = v370 v369
            let v372 : uint64 = v331 - v371
            v372
    let v375 : uint64 = v374 / 1000000000UL
    let v376 : uint64 = v375 % 60UL
    let v377 : uint64 = v375 / 60UL
    let v378 : uint64 = v377 % 60UL
    let v379 : uint64 = v375 / 3600UL
    let v380 : uint64 = v379 % 24UL
    let v381 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
    let v382 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v380, v378, v376) v381 
    let v383 : string = "fable_library_rust::String_::fromString($0)"
    let v384 : string = Fable.Core.RustInterop.emitRustExpr v382 v383 
    v384 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v387 : US2 option = None
    let _v387 = ref v387 
    match v18 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v388 : int64 = x
    let v389 : US2 = US2_0(v388)
    v389 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v387.Value <- x
    let v390 : US2 option = _v387.Value 
    let v413 : US2 = US2_1
    let v414 : US2 = v390 |> Option.defaultValue v413 
    let v512 : System.DateTime =
        match v414 with
        | US2_1 -> (* None *)
            let v504 : System.DateTime = System.DateTime.Now
            v504
        | US2_0(v422) -> (* Some *)
            let v425 : System.DateTime = System.DateTime.Now
            let v434 : (System.DateTime -> int64) = _.Ticks
            let v435 : int64 = v434 v425
            let v442 : int64 = v435 - v422
            let v445 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v446 : System.TimeSpan = v445 v442
            let v455 : (System.TimeSpan -> int32) = _.Hours
            let v456 : int32 = v455 v446
            let v465 : (System.TimeSpan -> int32) = _.Minutes
            let v466 : int32 = v465 v446
            let v475 : (System.TimeSpan -> int32) = _.Seconds
            let v476 : int32 = v475 v446
            let v485 : (System.TimeSpan -> int32) = _.Milliseconds
            let v486 : int32 = v485 v446
            let v495 : System.DateTime = System.DateTime (1, 1, 1, v456, v466, v476, v486)
            v495
    let v515 : string = method6()
    let v524 : (string -> string) = v512.ToString
    let v525 : string = v524 v515
    v525 
    #endif
#if FABLE_COMPILER_PYTHON
    let v534 : US2 option = None
    let _v534 = ref v534 
    match v18 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v535 : int64 = x
    let v536 : US2 = US2_0(v535)
    v536 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v534.Value <- x
    let v537 : US2 option = _v534.Value 
    let v560 : US2 = US2_1
    let v561 : US2 = v537 |> Option.defaultValue v560 
    let v659 : System.DateTime =
        match v561 with
        | US2_1 -> (* None *)
            let v651 : System.DateTime = System.DateTime.Now
            v651
        | US2_0(v569) -> (* Some *)
            let v572 : System.DateTime = System.DateTime.Now
            let v581 : (System.DateTime -> int64) = _.Ticks
            let v582 : int64 = v581 v572
            let v589 : int64 = v582 - v569
            let v592 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v593 : System.TimeSpan = v592 v589
            let v602 : (System.TimeSpan -> int32) = _.Hours
            let v603 : int32 = v602 v593
            let v612 : (System.TimeSpan -> int32) = _.Minutes
            let v613 : int32 = v612 v593
            let v622 : (System.TimeSpan -> int32) = _.Seconds
            let v623 : int32 = v622 v593
            let v632 : (System.TimeSpan -> int32) = _.Milliseconds
            let v633 : int32 = v632 v593
            let v642 : System.DateTime = System.DateTime (1, 1, 1, v603, v613, v623, v633)
            v642
    let v662 : string = method6()
    let v671 : (string -> string) = v659.ToString
    let v672 : string = v671 v662
    v672 
    #endif
#else
    let v681 : US2 option = None
    let _v681 = ref v681 
    match v18 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v682 : int64 = x
    let v683 : US2 = US2_0(v682)
    v683 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v681.Value <- x
    let v684 : US2 option = _v681.Value 
    let v707 : US2 = US2_1
    let v708 : US2 = v684 |> Option.defaultValue v707 
    let v806 : System.DateTime =
        match v708 with
        | US2_1 -> (* None *)
            let v798 : System.DateTime = System.DateTime.Now
            v798
        | US2_0(v716) -> (* Some *)
            let v719 : System.DateTime = System.DateTime.Now
            let v728 : (System.DateTime -> int64) = _.Ticks
            let v729 : int64 = v728 v719
            let v736 : int64 = v729 - v716
            let v739 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v740 : System.TimeSpan = v739 v736
            let v749 : (System.TimeSpan -> int32) = _.Hours
            let v750 : int32 = v749 v740
            let v759 : (System.TimeSpan -> int32) = _.Minutes
            let v760 : int32 = v759 v740
            let v769 : (System.TimeSpan -> int32) = _.Seconds
            let v770 : int32 = v769 v740
            let v779 : (System.TimeSpan -> int32) = _.Milliseconds
            let v780 : int32 = v779 v740
            let v789 : System.DateTime = System.DateTime (1, 1, 1, v750, v760, v770, v780)
            v789
    let v809 : string = method6()
    let v818 : (string -> string) = v806.ToString
    let v819 : string = v818 v809
    v819 
    #endif
    |> fun x -> _v35 <- Some x
    let v826 : string = match _v35 with Some x -> x | None -> failwith "base.run_target / _v35=None"
    let v981 : bool =
        match v0 with
        | US0_0 -> (* Verbose *)
            true
        | _ ->
            false
    let v985 : US3 =
        if v981 then
            let v982 : string = "Verbose"
            US3_0(v982)
        else
            US3_1
    let v1034 : US3 =
        match v985 with
        | US3_1 -> (* None *)
            let v990 : bool =
                match v0 with
                | US0_1 -> (* Debug *)
                    true
                | _ ->
                    false
            let v994 : US3 =
                if v990 then
                    let v991 : string = "Debug"
                    US3_0(v991)
                else
                    US3_1
            match v994 with
            | US3_1 -> (* None *)
                let v999 : bool =
                    match v0 with
                    | US0_2 -> (* Info *)
                        true
                    | _ ->
                        false
                let v1003 : US3 =
                    if v999 then
                        let v1000 : string = "Info"
                        US3_0(v1000)
                    else
                        US3_1
                match v1003 with
                | US3_1 -> (* None *)
                    let v1008 : bool =
                        match v0 with
                        | US0_3 -> (* Warning *)
                            true
                        | _ ->
                            false
                    let v1012 : US3 =
                        if v1008 then
                            let v1009 : string = "Warning"
                            US3_0(v1009)
                        else
                            US3_1
                    match v1012 with
                    | US3_1 -> (* None *)
                        let v1017 : bool =
                            match v0 with
                            | US0_4 -> (* Critical *)
                                true
                            | _ ->
                                false
                        let v1021 : US3 =
                            if v1017 then
                                let v1018 : string = "Critical"
                                US3_0(v1018)
                            else
                                US3_1
                        match v1021 with
                        | US3_1 -> (* None *)
                            US3_1
                        | US3_0(v1022) -> (* Some *)
                            US3_0(v1022)
                    | US3_0(v1013) -> (* Some *)
                        US3_0(v1013)
                | US3_0(v1004) -> (* Some *)
                    US3_0(v1004)
            | US3_0(v995) -> (* Some *)
                US3_0(v995)
        | US3_0(v986) -> (* Some *)
            US3_0(v986)
    let v1038 : string =
        match v1034 with
        | US3_1 -> (* None *)
            failwith<string> "Option does not have a value."
        | US3_0(v1035) -> (* Some *)
            v1035
    let v1041 : (unit -> string) = v1038.ToLower
    let v1042 : string = v1041 ()
    let v1051 : string = v1042.PadLeft (7, ' ')
    let v1083 : bool = true
    let mutable _v1083 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1098 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v1092 : string = "inline_colorization::color_bright_red"
            let v1093 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1092 
            v1093
        | US0_1 -> (* Debug *)
            let v1086 : string = "inline_colorization::color_bright_blue"
            let v1087 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1086 
            v1087
        | US0_2 -> (* Info *)
            let v1088 : string = "inline_colorization::color_bright_green"
            let v1089 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1088 
            v1089
        | US0_0 -> (* Verbose *)
            let v1084 : string = "inline_colorization::color_bright_black"
            let v1085 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1084 
            v1085
        | US0_3 -> (* Warning *)
            let v1090 : string = "inline_colorization::color_yellow"
            let v1091 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1090 
            v1091
    let v1099 : string = "&*$0"
    let v1100 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1051 v1099 
    let v1101 : string = "inline_colorization::color_reset"
    let v1102 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1101 
    let v1103 : string = "\"{v1098}{v1100}{v1102}\""
    let v1104 : string = @$"format!(" + v1103 + ")"
    let v1105 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v1104 
    let v1106 : string = "fable_library_rust::String_::fromString($0)"
    let v1107 : string = Fable.Core.RustInterop.emitRustExpr v1105 v1106 
    v1107 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1122 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v1116 : string = "inline_colorization::color_bright_red"
            let v1117 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1116 
            v1117
        | US0_1 -> (* Debug *)
            let v1110 : string = "inline_colorization::color_bright_blue"
            let v1111 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1110 
            v1111
        | US0_2 -> (* Info *)
            let v1112 : string = "inline_colorization::color_bright_green"
            let v1113 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1112 
            v1113
        | US0_0 -> (* Verbose *)
            let v1108 : string = "inline_colorization::color_bright_black"
            let v1109 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1108 
            v1109
        | US0_3 -> (* Warning *)
            let v1114 : string = "inline_colorization::color_yellow"
            let v1115 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1114 
            v1115
    let v1123 : string = "&*$0"
    let v1124 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1051 v1123 
    let v1125 : string = "inline_colorization::color_reset"
    let v1126 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1125 
    let v1127 : string = "\"{v1122}{v1124}{v1126}\""
    let v1128 : string = @$"format!(" + v1127 + ")"
    let v1129 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v1128 
    let v1130 : string = "fable_library_rust::String_::fromString($0)"
    let v1131 : string = Fable.Core.RustInterop.emitRustExpr v1129 v1130 
    v1131 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1146 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v1140 : string = "inline_colorization::color_bright_red"
            let v1141 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1140 
            v1141
        | US0_1 -> (* Debug *)
            let v1134 : string = "inline_colorization::color_bright_blue"
            let v1135 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1134 
            v1135
        | US0_2 -> (* Info *)
            let v1136 : string = "inline_colorization::color_bright_green"
            let v1137 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1136 
            v1137
        | US0_0 -> (* Verbose *)
            let v1132 : string = "inline_colorization::color_bright_black"
            let v1133 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1132 
            v1133
        | US0_3 -> (* Warning *)
            let v1138 : string = "inline_colorization::color_yellow"
            let v1139 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1138 
            v1139
    let v1147 : string = "&*$0"
    let v1148 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1051 v1147 
    let v1149 : string = "inline_colorization::color_reset"
    let v1150 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1149 
    let v1151 : string = "\"{v1146}{v1148}{v1150}\""
    let v1152 : string = @$"format!(" + v1151 + ")"
    let v1153 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v1152 
    let v1154 : string = "fable_library_rust::String_::fromString($0)"
    let v1155 : string = Fable.Core.RustInterop.emitRustExpr v1153 v1154 
    v1155 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1165 : string =
        match v0 with
        | US0_4 -> (* Critical *)
            let v1160 : string = "\u001b[91m"
            v1160
        | US0_1 -> (* Debug *)
            let v1157 : string = "\u001b[94m"
            v1157
        | US0_2 -> (* Info *)
            let v1158 : string = "\u001b[92m"
            v1158
        | US0_0 -> (* Verbose *)
            let v1156 : string = "\u001b[90m"
            v1156
        | US0_3 -> (* Warning *)
            let v1159 : string = "\u001b[93m"
            v1159
    let v1166 : string = method7()
    let v1167 : string = v1165 + v1051 
    let v1168 : string = v1167 + v1166 
    v1168 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1178 : string =
        match v0 with
        | US0_4 -> (* Critical *)
            let v1173 : string = "\u001b[91m"
            v1173
        | US0_1 -> (* Debug *)
            let v1170 : string = "\u001b[94m"
            v1170
        | US0_2 -> (* Info *)
            let v1171 : string = "\u001b[92m"
            v1171
        | US0_0 -> (* Verbose *)
            let v1169 : string = "\u001b[90m"
            v1169
        | US0_3 -> (* Warning *)
            let v1172 : string = "\u001b[93m"
            v1172
    let v1179 : string = method7()
    let v1180 : string = v1178 + v1051 
    let v1181 : string = v1180 + v1179 
    v1181 
    #endif
#else
    let v1191 : string =
        match v0 with
        | US0_4 -> (* Critical *)
            let v1186 : string = "\u001b[91m"
            v1186
        | US0_1 -> (* Debug *)
            let v1183 : string = "\u001b[94m"
            v1183
        | US0_2 -> (* Info *)
            let v1184 : string = "\u001b[92m"
            v1184
        | US0_0 -> (* Verbose *)
            let v1182 : string = "\u001b[90m"
            v1182
        | US0_3 -> (* Warning *)
            let v1185 : string = "\u001b[93m"
            v1185
    let v1192 : string = method7()
    let v1193 : string = v1191 + v1051 
    let v1194 : string = v1193 + v1192 
    v1194 
    #endif
    |> fun x -> _v1083 <- Some x
    let v1195 : string = match _v1083 with Some x -> x | None -> failwith "base.run_target / _v1083=None"
    let v1214 : int64 = v14.l0
    let v1215 : int32 = v2 ()
    let v1216 : string = ""
    let v1217 : Mut4 = {l0 = v1216} : Mut4
    method14(v1217, v1215)
    let v1218 : string = v1217.l0
    let v1221 : string = $"{v826} {v1195} #{v1214} %s{v1 ()} / {v1218}"
    let v1228 : char list = []
    let v1233 : (char list -> (char [])) = List.toArray
    let v1234 : (char []) = v1233 v1228
    let v1241 : string = v1221.TrimStart v1234 
    let v1280 : char list = []
    let v1283 : char list = '/' :: v1280 
    let v1292 : char list = ' ' :: v1283 
    let v1303 : (char list -> (char [])) = List.toArray
    let v1304 : (char []) = v1303 v1292
    let v1311 : string = v1241.TrimEnd v1304 
    v1311
and method13 (v0 : US0, v1 : (unit -> string), v2 : (unit -> int32)) : unit =
    let v3 : (unit -> string) = closure14(v0, v1, v2)
    method12(v0, v3)
and closure15 () () : string =
    let v0 : string = $"async.run_with_timeout_async**"
    v0
and closure16 (v0 : int32, v1 : exn) () : struct (int32 * string) =
    let v4 : bool = true
    let mutable _v4 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v7 : string = $"%A{v1}"
    v7 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v16 : string = $"%A{v1}"
    v16 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v25 : string = $"%A{v1}"
    v25 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v34 : string = $"%A{v1}"
    v34 
    #endif
#if FABLE_COMPILER_PYTHON
    let v43 : string = $"%A{v1}"
    v43 
    #endif
#else
    let v50 : string = $"{v1.GetType ()}: {v1.Message}"
    v50 
    #endif
    |> fun x -> _v4 <- Some x
    let v51 : string = match _v4 with Some x -> x | None -> failwith "base.run_target / _v4=None"
    struct (v0, v51)
and method16 (v0 : Mut4, v1 : int32, v2 : string) : unit =
    let v3 : string = "{ "
    method9(v0, v3)
    method10(v0)
    let v4 : string = "timeout"
    method9(v0, v4)
    let v5 : string = " = "
    method9(v0, v5)
    method11(v0, v1)
    let v6 : string = "; "
    method9(v0, v6)
    let v7 : string = "ex"
    method9(v0, v7)
    method9(v0, v5)
    method9(v0, v2)
    let v8 : string = " }"
    method9(v0, v8)
and closure17 (v0 : US0, v1 : (unit -> string), v2 : (unit -> struct (int32 * string))) () : string =
    let v5 : (US0 -> struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option)) = closure0()
    let v6 : US0 = US0_0
    if State.trace_state.IsNone then State.trace_state <- v5 v6 |> Some
    let struct (v14 : Mut0, v15 : Mut1, v16 : Mut2, v17 : Mut3, v18 : int64 option) = State.trace_state.Value
    let v35 : bool = true
    let mutable _v35 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v38 : US2 option = None
    let _v38 = ref v38 
    match v18 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v39 : int64 = x
    let v40 : US2 = US2_0(v39)
    v40 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v38.Value <- x
    let v41 : US2 option = _v38.Value 
    let v64 : US2 = US2_1
    let v65 : US2 = v41 |> Option.defaultValue v64 
    let v163 : System.DateTime =
        match v65 with
        | US2_1 -> (* None *)
            let v155 : System.DateTime = System.DateTime.Now
            v155
        | US2_0(v73) -> (* Some *)
            let v76 : System.DateTime = System.DateTime.Now
            let v85 : (System.DateTime -> int64) = _.Ticks
            let v86 : int64 = v85 v76
            let v93 : int64 = v86 - v73
            let v96 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v97 : System.TimeSpan = v96 v93
            let v106 : (System.TimeSpan -> int32) = _.Hours
            let v107 : int32 = v106 v97
            let v116 : (System.TimeSpan -> int32) = _.Minutes
            let v117 : int32 = v116 v97
            let v126 : (System.TimeSpan -> int32) = _.Seconds
            let v127 : int32 = v126 v97
            let v136 : (System.TimeSpan -> int32) = _.Milliseconds
            let v137 : int32 = v136 v97
            let v146 : System.DateTime = System.DateTime (1, 1, 1, v107, v117, v127, v137)
            v146
    let v166 : string = method5()
    let v175 : (string -> string) = v163.ToString
    let v176 : string = v175 v166
    v176 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v185 : US2 option = None
    let _v185 = ref v185 
    match v18 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v186 : int64 = x
    let v187 : US2 = US2_0(v186)
    v187 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v185.Value <- x
    let v188 : US2 option = _v185.Value 
    let v211 : US2 = US2_1
    let v212 : US2 = v188 |> Option.defaultValue v211 
    let v310 : System.DateTime =
        match v212 with
        | US2_1 -> (* None *)
            let v302 : System.DateTime = System.DateTime.Now
            v302
        | US2_0(v220) -> (* Some *)
            let v223 : System.DateTime = System.DateTime.Now
            let v232 : (System.DateTime -> int64) = _.Ticks
            let v233 : int64 = v232 v223
            let v240 : int64 = v233 - v220
            let v243 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v244 : System.TimeSpan = v243 v240
            let v253 : (System.TimeSpan -> int32) = _.Hours
            let v254 : int32 = v253 v244
            let v263 : (System.TimeSpan -> int32) = _.Minutes
            let v264 : int32 = v263 v244
            let v273 : (System.TimeSpan -> int32) = _.Seconds
            let v274 : int32 = v273 v244
            let v283 : (System.TimeSpan -> int32) = _.Milliseconds
            let v284 : int32 = v283 v244
            let v293 : System.DateTime = System.DateTime (1, 1, 1, v254, v264, v274, v284)
            v293
    let v313 : string = method5()
    let v322 : (string -> string) = v310.ToString
    let v323 : string = v322 v313
    v323 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v330 : string = $"near_sdk::env::block_timestamp()"
    let v331 : uint64 = Fable.Core.RustInterop.emitRustExpr () v330 
    let v334 : US2 option = None
    let _v334 = ref v334 
    match v18 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v335 : int64 = x
    let v336 : US2 = US2_0(v335)
    v336 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v334.Value <- x
    let v337 : US2 option = _v334.Value 
    let v360 : US2 = US2_1
    let v361 : US2 = v337 |> Option.defaultValue v360 
    let v374 : uint64 =
        match v361 with
        | US2_1 -> (* None *)
            v331
        | US2_0(v369) -> (* Some *)
            let v370 : (int64 -> uint64) = uint64
            let v371 : uint64 = v370 v369
            let v372 : uint64 = v331 - v371
            v372
    let v375 : uint64 = v374 / 1000000000UL
    let v376 : uint64 = v375 % 60UL
    let v377 : uint64 = v375 / 60UL
    let v378 : uint64 = v377 % 60UL
    let v379 : uint64 = v375 / 3600UL
    let v380 : uint64 = v379 % 24UL
    let v381 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
    let v382 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v380, v378, v376) v381 
    let v383 : string = "fable_library_rust::String_::fromString($0)"
    let v384 : string = Fable.Core.RustInterop.emitRustExpr v382 v383 
    v384 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v387 : US2 option = None
    let _v387 = ref v387 
    match v18 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v388 : int64 = x
    let v389 : US2 = US2_0(v388)
    v389 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v387.Value <- x
    let v390 : US2 option = _v387.Value 
    let v413 : US2 = US2_1
    let v414 : US2 = v390 |> Option.defaultValue v413 
    let v512 : System.DateTime =
        match v414 with
        | US2_1 -> (* None *)
            let v504 : System.DateTime = System.DateTime.Now
            v504
        | US2_0(v422) -> (* Some *)
            let v425 : System.DateTime = System.DateTime.Now
            let v434 : (System.DateTime -> int64) = _.Ticks
            let v435 : int64 = v434 v425
            let v442 : int64 = v435 - v422
            let v445 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v446 : System.TimeSpan = v445 v442
            let v455 : (System.TimeSpan -> int32) = _.Hours
            let v456 : int32 = v455 v446
            let v465 : (System.TimeSpan -> int32) = _.Minutes
            let v466 : int32 = v465 v446
            let v475 : (System.TimeSpan -> int32) = _.Seconds
            let v476 : int32 = v475 v446
            let v485 : (System.TimeSpan -> int32) = _.Milliseconds
            let v486 : int32 = v485 v446
            let v495 : System.DateTime = System.DateTime (1, 1, 1, v456, v466, v476, v486)
            v495
    let v515 : string = method6()
    let v524 : (string -> string) = v512.ToString
    let v525 : string = v524 v515
    v525 
    #endif
#if FABLE_COMPILER_PYTHON
    let v534 : US2 option = None
    let _v534 = ref v534 
    match v18 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v535 : int64 = x
    let v536 : US2 = US2_0(v535)
    v536 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v534.Value <- x
    let v537 : US2 option = _v534.Value 
    let v560 : US2 = US2_1
    let v561 : US2 = v537 |> Option.defaultValue v560 
    let v659 : System.DateTime =
        match v561 with
        | US2_1 -> (* None *)
            let v651 : System.DateTime = System.DateTime.Now
            v651
        | US2_0(v569) -> (* Some *)
            let v572 : System.DateTime = System.DateTime.Now
            let v581 : (System.DateTime -> int64) = _.Ticks
            let v582 : int64 = v581 v572
            let v589 : int64 = v582 - v569
            let v592 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v593 : System.TimeSpan = v592 v589
            let v602 : (System.TimeSpan -> int32) = _.Hours
            let v603 : int32 = v602 v593
            let v612 : (System.TimeSpan -> int32) = _.Minutes
            let v613 : int32 = v612 v593
            let v622 : (System.TimeSpan -> int32) = _.Seconds
            let v623 : int32 = v622 v593
            let v632 : (System.TimeSpan -> int32) = _.Milliseconds
            let v633 : int32 = v632 v593
            let v642 : System.DateTime = System.DateTime (1, 1, 1, v603, v613, v623, v633)
            v642
    let v662 : string = method6()
    let v671 : (string -> string) = v659.ToString
    let v672 : string = v671 v662
    v672 
    #endif
#else
    let v681 : US2 option = None
    let _v681 = ref v681 
    match v18 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v682 : int64 = x
    let v683 : US2 = US2_0(v682)
    v683 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v681.Value <- x
    let v684 : US2 option = _v681.Value 
    let v707 : US2 = US2_1
    let v708 : US2 = v684 |> Option.defaultValue v707 
    let v806 : System.DateTime =
        match v708 with
        | US2_1 -> (* None *)
            let v798 : System.DateTime = System.DateTime.Now
            v798
        | US2_0(v716) -> (* Some *)
            let v719 : System.DateTime = System.DateTime.Now
            let v728 : (System.DateTime -> int64) = _.Ticks
            let v729 : int64 = v728 v719
            let v736 : int64 = v729 - v716
            let v739 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v740 : System.TimeSpan = v739 v736
            let v749 : (System.TimeSpan -> int32) = _.Hours
            let v750 : int32 = v749 v740
            let v759 : (System.TimeSpan -> int32) = _.Minutes
            let v760 : int32 = v759 v740
            let v769 : (System.TimeSpan -> int32) = _.Seconds
            let v770 : int32 = v769 v740
            let v779 : (System.TimeSpan -> int32) = _.Milliseconds
            let v780 : int32 = v779 v740
            let v789 : System.DateTime = System.DateTime (1, 1, 1, v750, v760, v770, v780)
            v789
    let v809 : string = method6()
    let v818 : (string -> string) = v806.ToString
    let v819 : string = v818 v809
    v819 
    #endif
    |> fun x -> _v35 <- Some x
    let v826 : string = match _v35 with Some x -> x | None -> failwith "base.run_target / _v35=None"
    let v981 : bool =
        match v0 with
        | US0_0 -> (* Verbose *)
            true
        | _ ->
            false
    let v985 : US3 =
        if v981 then
            let v982 : string = "Verbose"
            US3_0(v982)
        else
            US3_1
    let v1034 : US3 =
        match v985 with
        | US3_1 -> (* None *)
            let v990 : bool =
                match v0 with
                | US0_1 -> (* Debug *)
                    true
                | _ ->
                    false
            let v994 : US3 =
                if v990 then
                    let v991 : string = "Debug"
                    US3_0(v991)
                else
                    US3_1
            match v994 with
            | US3_1 -> (* None *)
                let v999 : bool =
                    match v0 with
                    | US0_2 -> (* Info *)
                        true
                    | _ ->
                        false
                let v1003 : US3 =
                    if v999 then
                        let v1000 : string = "Info"
                        US3_0(v1000)
                    else
                        US3_1
                match v1003 with
                | US3_1 -> (* None *)
                    let v1008 : bool =
                        match v0 with
                        | US0_3 -> (* Warning *)
                            true
                        | _ ->
                            false
                    let v1012 : US3 =
                        if v1008 then
                            let v1009 : string = "Warning"
                            US3_0(v1009)
                        else
                            US3_1
                    match v1012 with
                    | US3_1 -> (* None *)
                        let v1017 : bool =
                            match v0 with
                            | US0_4 -> (* Critical *)
                                true
                            | _ ->
                                false
                        let v1021 : US3 =
                            if v1017 then
                                let v1018 : string = "Critical"
                                US3_0(v1018)
                            else
                                US3_1
                        match v1021 with
                        | US3_1 -> (* None *)
                            US3_1
                        | US3_0(v1022) -> (* Some *)
                            US3_0(v1022)
                    | US3_0(v1013) -> (* Some *)
                        US3_0(v1013)
                | US3_0(v1004) -> (* Some *)
                    US3_0(v1004)
            | US3_0(v995) -> (* Some *)
                US3_0(v995)
        | US3_0(v986) -> (* Some *)
            US3_0(v986)
    let v1038 : string =
        match v1034 with
        | US3_1 -> (* None *)
            failwith<string> "Option does not have a value."
        | US3_0(v1035) -> (* Some *)
            v1035
    let v1041 : (unit -> string) = v1038.ToLower
    let v1042 : string = v1041 ()
    let v1051 : string = v1042.PadLeft (7, ' ')
    let v1083 : bool = true
    let mutable _v1083 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1098 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v1092 : string = "inline_colorization::color_bright_red"
            let v1093 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1092 
            v1093
        | US0_1 -> (* Debug *)
            let v1086 : string = "inline_colorization::color_bright_blue"
            let v1087 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1086 
            v1087
        | US0_2 -> (* Info *)
            let v1088 : string = "inline_colorization::color_bright_green"
            let v1089 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1088 
            v1089
        | US0_0 -> (* Verbose *)
            let v1084 : string = "inline_colorization::color_bright_black"
            let v1085 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1084 
            v1085
        | US0_3 -> (* Warning *)
            let v1090 : string = "inline_colorization::color_yellow"
            let v1091 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1090 
            v1091
    let v1099 : string = "&*$0"
    let v1100 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1051 v1099 
    let v1101 : string = "inline_colorization::color_reset"
    let v1102 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1101 
    let v1103 : string = "\"{v1098}{v1100}{v1102}\""
    let v1104 : string = @$"format!(" + v1103 + ")"
    let v1105 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v1104 
    let v1106 : string = "fable_library_rust::String_::fromString($0)"
    let v1107 : string = Fable.Core.RustInterop.emitRustExpr v1105 v1106 
    v1107 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1122 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v1116 : string = "inline_colorization::color_bright_red"
            let v1117 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1116 
            v1117
        | US0_1 -> (* Debug *)
            let v1110 : string = "inline_colorization::color_bright_blue"
            let v1111 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1110 
            v1111
        | US0_2 -> (* Info *)
            let v1112 : string = "inline_colorization::color_bright_green"
            let v1113 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1112 
            v1113
        | US0_0 -> (* Verbose *)
            let v1108 : string = "inline_colorization::color_bright_black"
            let v1109 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1108 
            v1109
        | US0_3 -> (* Warning *)
            let v1114 : string = "inline_colorization::color_yellow"
            let v1115 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1114 
            v1115
    let v1123 : string = "&*$0"
    let v1124 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1051 v1123 
    let v1125 : string = "inline_colorization::color_reset"
    let v1126 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1125 
    let v1127 : string = "\"{v1122}{v1124}{v1126}\""
    let v1128 : string = @$"format!(" + v1127 + ")"
    let v1129 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v1128 
    let v1130 : string = "fable_library_rust::String_::fromString($0)"
    let v1131 : string = Fable.Core.RustInterop.emitRustExpr v1129 v1130 
    v1131 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1146 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v1140 : string = "inline_colorization::color_bright_red"
            let v1141 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1140 
            v1141
        | US0_1 -> (* Debug *)
            let v1134 : string = "inline_colorization::color_bright_blue"
            let v1135 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1134 
            v1135
        | US0_2 -> (* Info *)
            let v1136 : string = "inline_colorization::color_bright_green"
            let v1137 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1136 
            v1137
        | US0_0 -> (* Verbose *)
            let v1132 : string = "inline_colorization::color_bright_black"
            let v1133 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1132 
            v1133
        | US0_3 -> (* Warning *)
            let v1138 : string = "inline_colorization::color_yellow"
            let v1139 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1138 
            v1139
    let v1147 : string = "&*$0"
    let v1148 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1051 v1147 
    let v1149 : string = "inline_colorization::color_reset"
    let v1150 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1149 
    let v1151 : string = "\"{v1146}{v1148}{v1150}\""
    let v1152 : string = @$"format!(" + v1151 + ")"
    let v1153 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v1152 
    let v1154 : string = "fable_library_rust::String_::fromString($0)"
    let v1155 : string = Fable.Core.RustInterop.emitRustExpr v1153 v1154 
    v1155 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1165 : string =
        match v0 with
        | US0_4 -> (* Critical *)
            let v1160 : string = "\u001b[91m"
            v1160
        | US0_1 -> (* Debug *)
            let v1157 : string = "\u001b[94m"
            v1157
        | US0_2 -> (* Info *)
            let v1158 : string = "\u001b[92m"
            v1158
        | US0_0 -> (* Verbose *)
            let v1156 : string = "\u001b[90m"
            v1156
        | US0_3 -> (* Warning *)
            let v1159 : string = "\u001b[93m"
            v1159
    let v1166 : string = method7()
    let v1167 : string = v1165 + v1051 
    let v1168 : string = v1167 + v1166 
    v1168 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1178 : string =
        match v0 with
        | US0_4 -> (* Critical *)
            let v1173 : string = "\u001b[91m"
            v1173
        | US0_1 -> (* Debug *)
            let v1170 : string = "\u001b[94m"
            v1170
        | US0_2 -> (* Info *)
            let v1171 : string = "\u001b[92m"
            v1171
        | US0_0 -> (* Verbose *)
            let v1169 : string = "\u001b[90m"
            v1169
        | US0_3 -> (* Warning *)
            let v1172 : string = "\u001b[93m"
            v1172
    let v1179 : string = method7()
    let v1180 : string = v1178 + v1051 
    let v1181 : string = v1180 + v1179 
    v1181 
    #endif
#else
    let v1191 : string =
        match v0 with
        | US0_4 -> (* Critical *)
            let v1186 : string = "\u001b[91m"
            v1186
        | US0_1 -> (* Debug *)
            let v1183 : string = "\u001b[94m"
            v1183
        | US0_2 -> (* Info *)
            let v1184 : string = "\u001b[92m"
            v1184
        | US0_0 -> (* Verbose *)
            let v1182 : string = "\u001b[90m"
            v1182
        | US0_3 -> (* Warning *)
            let v1185 : string = "\u001b[93m"
            v1185
    let v1192 : string = method7()
    let v1193 : string = v1191 + v1051 
    let v1194 : string = v1193 + v1192 
    v1194 
    #endif
    |> fun x -> _v1083 <- Some x
    let v1195 : string = match _v1083 with Some x -> x | None -> failwith "base.run_target / _v1083=None"
    let v1214 : int64 = v14.l0
    let struct (v1215 : int32, v1216 : string) = v2 ()
    let v1217 : string = ""
    let v1218 : Mut4 = {l0 = v1217} : Mut4
    method16(v1218, v1215, v1216)
    let v1219 : string = v1218.l0
    let v1222 : string = $"{v826} {v1195} #{v1214} %s{v1 ()} / {v1219}"
    let v1229 : char list = []
    let v1234 : (char list -> (char [])) = List.toArray
    let v1235 : (char []) = v1234 v1229
    let v1242 : string = v1222.TrimStart v1235 
    let v1281 : char list = []
    let v1284 : char list = '/' :: v1281 
    let v1293 : char list = ' ' :: v1284 
    let v1304 : (char list -> (char [])) = List.toArray
    let v1305 : (char []) = v1304 v1293
    let v1312 : string = v1242.TrimEnd v1305 
    v1312
and method15 (v0 : US0, v1 : (unit -> string), v2 : (unit -> struct (int32 * string))) : unit =
    let v3 : (unit -> string) = closure17(v0, v1, v2)
    method12(v0, v3)
and closure9 (v0 : int32, v1 : string) (v2 : int32) : Async<bool> =
    let v5 : bool = true
    let mutable _v5 : Async<bool> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v8 : Async<bool> = null |> unbox<Async<bool>>
    v8 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v17 : Async<bool> = null |> unbox<Async<bool>>
    v17 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v26 : Async<bool> = null |> unbox<Async<bool>>
    v26 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v35 : Async<bool> = null |> unbox<Async<bool>>
    v35 
    #endif
#if FABLE_COMPILER_PYTHON
    let v44 : Async<bool> = null |> unbox<Async<bool>>
    v44 
    #endif
#else
    let v51 : Async<bool> option = None
    let mutable _v51 = v51 
    async {
    let v54 : bool = true
    let mutable _v54 : Async<bool> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v57 : Async<bool> = null |> unbox<Async<bool>>
    v57 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v66 : Async<bool> = null |> unbox<Async<bool>>
    v66 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v75 : Async<bool> = null |> unbox<Async<bool>>
    v75 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v84 : Async<bool> = null |> unbox<Async<bool>>
    v84 
    #endif
#if FABLE_COMPILER_PYTHON
    let v93 : Async<bool> = null |> unbox<Async<bool>>
    v93 
    #endif
#else
    let v100 : Async<bool> option = None
    let mutable _v100 = v100 
    async {
    let v101 : Async<System.Threading.CancellationToken> = Async.CancellationToken
    let! v101 = v101 
    let v102 : System.Threading.CancellationToken = v101 
    let v103 : System.Net.Sockets.TcpClient = new System.Net.Sockets.TcpClient ()
    use v103 = v103 
    let v104 : System.Net.Sockets.TcpClient = v103 
    try
    let v105 : System.Threading.Tasks.ValueTask = v104.ConnectAsync (v1, v2, v102)
    let v106 : (unit -> System.Threading.Tasks.Task) = v105.AsTask
    let v107 : System.Threading.Tasks.Task = v106 ()
    let v110 : bool = true
    let mutable _v110 : Async<unit> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v113 : Async<unit> = null |> unbox<Async<unit>>
    v113 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v122 : Async<unit> = null |> unbox<Async<unit>>
    v122 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v131 : Async<unit> = null |> unbox<Async<unit>>
    v131 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v140 : Async<unit> = null |> unbox<Async<unit>>
    v140 
    #endif
#if FABLE_COMPILER_PYTHON
    let v149 : Async<unit> = null |> unbox<Async<unit>>
    v149 
    #endif
#else
    let v156 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
    let v157 : Async<unit> = v156 v107
    v157 
    #endif
    |> fun x -> _v110 <- Some x
    let v158 : Async<unit> = match _v110 with Some x -> x | None -> failwith "base.run_target / _v110=None"
    do! v158 
    return true 
    with ex ->
    let v173 : exn = ex
    let v176 : bool = true
    let mutable _v176 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v179 : string = $"%A{v173}"
    v179 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v188 : string = $"%A{v173}"
    v188 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v197 : string = $"%A{v173}"
    v197 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v206 : string = $"%A{v173}"
    v206 
    #endif
#if FABLE_COMPILER_PYTHON
    let v215 : string = $"%A{v173}"
    v215 
    #endif
#else
    let v222 : string = $"{v173.GetType ()}: {v173.Message}"
    v222 
    #endif
    |> fun x -> _v176 <- Some x
    let v223 : string = match _v176 with Some x -> x | None -> failwith "base.run_target / _v176=None"
    let v238 : US0 = US0_0
    let v239 : (unit -> string) = closure4()
    let v240 : (unit -> struct (int32 * string)) = closure5(v2, v223)
    method4(v238, v239, v240)
    return false 
    (*
    let v241 : bool = *)
    }
    |> fun x -> _v100 <- Some x
    let v242 : Async<bool> = match _v100 with Some x -> x | None -> failwith "async.new_async_unit / _v100=None"
    v242 
    #endif
    |> fun x -> _v54 <- Some x
    let v243 : Async<bool> = match _v54 with Some x -> x | None -> failwith "base.run_target / _v54=None"
    let v260 : bool = true
    let mutable _v260 : Async<US4> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v263 : Async<US4> = null |> unbox<Async<US4>>
    v263 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v272 : Async<US4> = null |> unbox<Async<US4>>
    v272 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v281 : Async<US4> = null |> unbox<Async<US4>>
    v281 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v290 : Async<US4> = null |> unbox<Async<US4>>
    v290 
    #endif
#if FABLE_COMPILER_PYTHON
    let v299 : Async<US4> = null |> unbox<Async<US4>>
    v299 
    #endif
#else
    let v308 : bool = true
    let mutable _v308 : Async<US4> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v311 : Async<US4> = null |> unbox<Async<US4>>
    v311 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v320 : Async<US4> = null |> unbox<Async<US4>>
    v320 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v329 : Async<US4> = null |> unbox<Async<US4>>
    v329 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v338 : Async<US4> = null |> unbox<Async<US4>>
    v338 
    #endif
#if FABLE_COMPILER_PYTHON
    let v347 : Async<US4> = null |> unbox<Async<US4>>
    v347 
    #endif
#else
    let v354 : Async<US4> option = None
    let mutable _v354 = v354 
    async {
    let v357 : bool = true
    let mutable _v357 : Async<Async<bool>> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v360 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
    v360 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v369 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
    v369 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v378 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
    v378 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v387 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
    v387 
    #endif
#if FABLE_COMPILER_PYTHON
    let v396 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
    v396 
    #endif
#else
    let v403 : Async<Async<bool>> = Async.StartChild (v243, v0)
    v403 
    #endif
    |> fun x -> _v357 <- Some x
    let v404 : Async<Async<bool>> = match _v357 with Some x -> x | None -> failwith "base.run_target / _v357=None"
    let! v404 = v404 
    let v419 : Async<bool> = v404 
    let v422 : bool = true
    let mutable _v422 : Async<Choice<bool, exn>> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v425 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
    v425 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v434 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
    v434 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v443 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
    v443 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v452 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
    v452 
    #endif
#if FABLE_COMPILER_PYTHON
    let v461 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
    v461 
    #endif
#else
    let v468 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
    let v469 : Async<Choice<bool, exn>> = v468 v419
    v469 
    #endif
    |> fun x -> _v422 <- Some x
    let v470 : Async<Choice<bool, exn>> = match _v422 with Some x -> x | None -> failwith "base.run_target / _v422=None"
    let v487 : bool = true
    let mutable _v487 : Async<US5> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v490 : Async<US5> = null |> unbox<Async<US5>>
    v490 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v499 : Async<US5> = null |> unbox<Async<US5>>
    v499 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v508 : Async<US5> = null |> unbox<Async<US5>>
    v508 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v517 : Async<US5> = null |> unbox<Async<US5>>
    v517 
    #endif
#if FABLE_COMPILER_PYTHON
    let v526 : Async<US5> = null |> unbox<Async<US5>>
    v526 
    #endif
#else
    let v533 : Async<US5> option = None
    let mutable _v533 = v533 
    async {
    let! v470 = v470 
    let v534 : Choice<bool, exn> = v470 
    let v537 : bool = true
    let mutable _v537 : US5 option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v540 : US5 = null |> unbox<US5>
    v540 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v549 : US5 = null |> unbox<US5>
    v549 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v558 : US5 = null |> unbox<US5>
    v558 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v567 : US5 = null |> unbox<US5>
    v567 
    #endif
#if FABLE_COMPILER_PYTHON
    let v576 : US5 = null |> unbox<US5>
    v576 
    #endif
#else
    let v583 : (bool -> US5) = closure10()
    let v584 : (exn -> US5) = closure11()
    let v585 : US5 = match v534 with Choice1Of2 x -> v583 x | Choice2Of2 x -> v584 x
    v585 
    #endif
    |> fun x -> _v537 <- Some x
    let v586 : US5 = match _v537 with Some x -> x | None -> failwith "base.run_target / _v537=None"
    return v586 
    }
    |> fun x -> _v533 <- Some x
    let v601 : Async<US5> = match _v533 with Some x -> x | None -> failwith "async.new_async_unit / _v533=None"
    v601 
    #endif
    |> fun x -> _v487 <- Some x
    let v602 : Async<US5> = match _v487 with Some x -> x | None -> failwith "base.run_target / _v487=None"
    let v619 : bool = true
    let mutable _v619 : Async<US6> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v622 : Async<US6> = null |> unbox<Async<US6>>
    v622 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v631 : Async<US6> = null |> unbox<Async<US6>>
    v631 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v640 : Async<US6> = null |> unbox<Async<US6>>
    v640 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v649 : Async<US6> = null |> unbox<Async<US6>>
    v649 
    #endif
#if FABLE_COMPILER_PYTHON
    let v658 : Async<US6> = null |> unbox<Async<US6>>
    v658 
    #endif
#else
    let v665 : Async<US6> option = None
    let mutable _v665 = v665 
    async {
    let! v602 = v602 
    let v666 : US5 = v602 
    let v672 : US6 =
        match v666 with
        | US5_0(v667) -> (* C1of2 *)
            US6_0(v667)
        | US5_1(v669) -> (* C2of2 *)
            US6_1(v669)
    return v672 
    }
    |> fun x -> _v665 <- Some x
    let v673 : Async<US6> = match _v665 with Some x -> x | None -> failwith "async.new_async_unit / _v665=None"
    v673 
    #endif
    |> fun x -> _v619 <- Some x
    let v674 : Async<US6> = match _v619 with Some x -> x | None -> failwith "base.run_target / _v619=None"
    let v691 : bool = true
    let mutable _v691 : Async<US4> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v694 : Async<US4> = null |> unbox<Async<US4>>
    v694 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v703 : Async<US4> = null |> unbox<Async<US4>>
    v703 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v712 : Async<US4> = null |> unbox<Async<US4>>
    v712 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v721 : Async<US4> = null |> unbox<Async<US4>>
    v721 
    #endif
#if FABLE_COMPILER_PYTHON
    let v730 : Async<US4> = null |> unbox<Async<US4>>
    v730 
    #endif
#else
    let v737 : Async<US4> option = None
    let mutable _v737 = v737 
    async {
    let! v674 = v674 
    let v738 : US6 = v674 
    let v771 : US4 =
        match v738 with
        | US6_1(v741) -> (* Error *)
            let v744 : string = $"%A{v741}"
            let v753 : string = "System.TimeoutException"
            let v754 : bool = v744.Contains v753 
            if v754 then
                let v761 : US0 = US0_0
                let v762 : (unit -> string) = closure12()
                let v763 : (unit -> int32) = closure13(v0)
                method13(v761, v762, v763)
                US4_1
            else
                let v765 : US0 = US0_4
                let v766 : (unit -> string) = closure15()
                let v767 : (unit -> struct (int32 * string)) = closure16(v0, v741)
                method15(v765, v766, v767)
                US4_1
        | US6_0(v739) -> (* Ok *)
            US4_0(v739)
    return v771 
    }
    |> fun x -> _v737 <- Some x
    let v772 : Async<US4> = match _v737 with Some x -> x | None -> failwith "async.new_async_unit / _v737=None"
    v772 
    #endif
    |> fun x -> _v691 <- Some x
    let v773 : Async<US4> = match _v691 with Some x -> x | None -> failwith "base.run_target / _v691=None"
    return! v773 
    }
    |> fun x -> _v354 <- Some x
    let v788 : Async<US4> = match _v354 with Some x -> x | None -> failwith "async.new_async_unit / _v354=None"
    v788 
    #endif
    |> fun x -> _v308 <- Some x
    let v789 : Async<US4> = match _v308 with Some x -> x | None -> failwith "base.run_target / _v308=None"
    v789 
    #endif
    |> fun x -> _v260 <- Some x
    let v804 : Async<US4> = match _v260 with Some x -> x | None -> failwith "base.run_target / _v260=None"
    let! v804 = v804 
    let v819 : US4 = v804 
    let v822 : bool =
        match v819 with
        | US4_1 -> (* None *)
            false
        | US4_0(v820) -> (* Some *)
            v820
    return v822 
    }
    |> fun x -> _v51 <- Some x
    let v823 : Async<bool> = match _v51 with Some x -> x | None -> failwith "async.new_async_unit / _v51=None"
    v823 
    #endif
    |> fun x -> _v5 <- Some x
    let v824 : Async<bool> = match _v5 with Some x -> x | None -> failwith "base.run_target / _v5=None"
    v824
and closure8 (v0 : int32) (v1 : string) : (int32 -> Async<bool>) =
    closure9(v0, v1)
and closure7 () (v0 : int32) : (string -> (int32 -> Async<bool>)) =
    closure8(v0)
and closure22 () () : string =
    let v0 : string = "networking.wait_for_port_access"
    v0
and closure23 (v0 : int32 option, v1 : bool, v2 : int32, v3 : int64) () : struct (int32 * int64 * int32 option * bool) =
    struct (v2, v3, v0, v1)
and method20 (v0 : Mut4, v1 : int64) : unit =
    let v4 : string = $"{v1}"
    let v11 : string = v0.l0
    let v12 : string = v11 + v4 
    v0.l0 <- v12
    ()
and method21 (v0 : Mut4, v1 : int32 option) : unit =
    let v4 : string = $"%A{v1}"
    method9(v0, v4)
and method22 (v0 : Mut4, v1 : bool) : unit =
    let v4 : string =
        if v1 then
            let v2 : string = "true"
            v2
        else
            let v3 : string = "false"
            v3
    let v7 : string = $"{v4}"
    let v14 : string = v0.l0
    let v15 : string = v14 + v7 
    v0.l0 <- v15
    ()
and method19 (v0 : Mut4, v1 : int32, v2 : int64, v3 : int32 option, v4 : bool) : unit =
    let v5 : string = "{ "
    method9(v0, v5)
    method10(v0)
    let v6 : string = "port"
    method9(v0, v6)
    let v7 : string = " = "
    method9(v0, v7)
    method11(v0, v1)
    let v8 : string = "; "
    method9(v0, v8)
    let v9 : string = "retry"
    method9(v0, v9)
    method9(v0, v7)
    method20(v0, v2)
    method9(v0, v8)
    let v10 : string = "timeout"
    method9(v0, v10)
    method9(v0, v7)
    method21(v0, v3)
    method9(v0, v8)
    let v11 : string = "status"
    method9(v0, v11)
    method9(v0, v7)
    method22(v0, v4)
    let v12 : string = " }"
    method9(v0, v12)
and closure24 (v0 : US0, v1 : (unit -> string), v2 : (unit -> struct (int32 * int64 * int32 option * bool))) () : string =
    let v5 : (US0 -> struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option)) = closure0()
    let v6 : US0 = US0_0
    if State.trace_state.IsNone then State.trace_state <- v5 v6 |> Some
    let struct (v14 : Mut0, v15 : Mut1, v16 : Mut2, v17 : Mut3, v18 : int64 option) = State.trace_state.Value
    let v35 : bool = true
    let mutable _v35 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v38 : US2 option = None
    let _v38 = ref v38 
    match v18 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v39 : int64 = x
    let v40 : US2 = US2_0(v39)
    v40 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v38.Value <- x
    let v41 : US2 option = _v38.Value 
    let v64 : US2 = US2_1
    let v65 : US2 = v41 |> Option.defaultValue v64 
    let v163 : System.DateTime =
        match v65 with
        | US2_1 -> (* None *)
            let v155 : System.DateTime = System.DateTime.Now
            v155
        | US2_0(v73) -> (* Some *)
            let v76 : System.DateTime = System.DateTime.Now
            let v85 : (System.DateTime -> int64) = _.Ticks
            let v86 : int64 = v85 v76
            let v93 : int64 = v86 - v73
            let v96 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v97 : System.TimeSpan = v96 v93
            let v106 : (System.TimeSpan -> int32) = _.Hours
            let v107 : int32 = v106 v97
            let v116 : (System.TimeSpan -> int32) = _.Minutes
            let v117 : int32 = v116 v97
            let v126 : (System.TimeSpan -> int32) = _.Seconds
            let v127 : int32 = v126 v97
            let v136 : (System.TimeSpan -> int32) = _.Milliseconds
            let v137 : int32 = v136 v97
            let v146 : System.DateTime = System.DateTime (1, 1, 1, v107, v117, v127, v137)
            v146
    let v166 : string = method5()
    let v175 : (string -> string) = v163.ToString
    let v176 : string = v175 v166
    v176 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v185 : US2 option = None
    let _v185 = ref v185 
    match v18 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v186 : int64 = x
    let v187 : US2 = US2_0(v186)
    v187 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v185.Value <- x
    let v188 : US2 option = _v185.Value 
    let v211 : US2 = US2_1
    let v212 : US2 = v188 |> Option.defaultValue v211 
    let v310 : System.DateTime =
        match v212 with
        | US2_1 -> (* None *)
            let v302 : System.DateTime = System.DateTime.Now
            v302
        | US2_0(v220) -> (* Some *)
            let v223 : System.DateTime = System.DateTime.Now
            let v232 : (System.DateTime -> int64) = _.Ticks
            let v233 : int64 = v232 v223
            let v240 : int64 = v233 - v220
            let v243 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v244 : System.TimeSpan = v243 v240
            let v253 : (System.TimeSpan -> int32) = _.Hours
            let v254 : int32 = v253 v244
            let v263 : (System.TimeSpan -> int32) = _.Minutes
            let v264 : int32 = v263 v244
            let v273 : (System.TimeSpan -> int32) = _.Seconds
            let v274 : int32 = v273 v244
            let v283 : (System.TimeSpan -> int32) = _.Milliseconds
            let v284 : int32 = v283 v244
            let v293 : System.DateTime = System.DateTime (1, 1, 1, v254, v264, v274, v284)
            v293
    let v313 : string = method5()
    let v322 : (string -> string) = v310.ToString
    let v323 : string = v322 v313
    v323 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v330 : string = $"near_sdk::env::block_timestamp()"
    let v331 : uint64 = Fable.Core.RustInterop.emitRustExpr () v330 
    let v334 : US2 option = None
    let _v334 = ref v334 
    match v18 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v335 : int64 = x
    let v336 : US2 = US2_0(v335)
    v336 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v334.Value <- x
    let v337 : US2 option = _v334.Value 
    let v360 : US2 = US2_1
    let v361 : US2 = v337 |> Option.defaultValue v360 
    let v374 : uint64 =
        match v361 with
        | US2_1 -> (* None *)
            v331
        | US2_0(v369) -> (* Some *)
            let v370 : (int64 -> uint64) = uint64
            let v371 : uint64 = v370 v369
            let v372 : uint64 = v331 - v371
            v372
    let v375 : uint64 = v374 / 1000000000UL
    let v376 : uint64 = v375 % 60UL
    let v377 : uint64 = v375 / 60UL
    let v378 : uint64 = v377 % 60UL
    let v379 : uint64 = v375 / 3600UL
    let v380 : uint64 = v379 % 24UL
    let v381 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
    let v382 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v380, v378, v376) v381 
    let v383 : string = "fable_library_rust::String_::fromString($0)"
    let v384 : string = Fable.Core.RustInterop.emitRustExpr v382 v383 
    v384 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v387 : US2 option = None
    let _v387 = ref v387 
    match v18 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v388 : int64 = x
    let v389 : US2 = US2_0(v388)
    v389 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v387.Value <- x
    let v390 : US2 option = _v387.Value 
    let v413 : US2 = US2_1
    let v414 : US2 = v390 |> Option.defaultValue v413 
    let v512 : System.DateTime =
        match v414 with
        | US2_1 -> (* None *)
            let v504 : System.DateTime = System.DateTime.Now
            v504
        | US2_0(v422) -> (* Some *)
            let v425 : System.DateTime = System.DateTime.Now
            let v434 : (System.DateTime -> int64) = _.Ticks
            let v435 : int64 = v434 v425
            let v442 : int64 = v435 - v422
            let v445 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v446 : System.TimeSpan = v445 v442
            let v455 : (System.TimeSpan -> int32) = _.Hours
            let v456 : int32 = v455 v446
            let v465 : (System.TimeSpan -> int32) = _.Minutes
            let v466 : int32 = v465 v446
            let v475 : (System.TimeSpan -> int32) = _.Seconds
            let v476 : int32 = v475 v446
            let v485 : (System.TimeSpan -> int32) = _.Milliseconds
            let v486 : int32 = v485 v446
            let v495 : System.DateTime = System.DateTime (1, 1, 1, v456, v466, v476, v486)
            v495
    let v515 : string = method6()
    let v524 : (string -> string) = v512.ToString
    let v525 : string = v524 v515
    v525 
    #endif
#if FABLE_COMPILER_PYTHON
    let v534 : US2 option = None
    let _v534 = ref v534 
    match v18 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v535 : int64 = x
    let v536 : US2 = US2_0(v535)
    v536 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v534.Value <- x
    let v537 : US2 option = _v534.Value 
    let v560 : US2 = US2_1
    let v561 : US2 = v537 |> Option.defaultValue v560 
    let v659 : System.DateTime =
        match v561 with
        | US2_1 -> (* None *)
            let v651 : System.DateTime = System.DateTime.Now
            v651
        | US2_0(v569) -> (* Some *)
            let v572 : System.DateTime = System.DateTime.Now
            let v581 : (System.DateTime -> int64) = _.Ticks
            let v582 : int64 = v581 v572
            let v589 : int64 = v582 - v569
            let v592 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v593 : System.TimeSpan = v592 v589
            let v602 : (System.TimeSpan -> int32) = _.Hours
            let v603 : int32 = v602 v593
            let v612 : (System.TimeSpan -> int32) = _.Minutes
            let v613 : int32 = v612 v593
            let v622 : (System.TimeSpan -> int32) = _.Seconds
            let v623 : int32 = v622 v593
            let v632 : (System.TimeSpan -> int32) = _.Milliseconds
            let v633 : int32 = v632 v593
            let v642 : System.DateTime = System.DateTime (1, 1, 1, v603, v613, v623, v633)
            v642
    let v662 : string = method6()
    let v671 : (string -> string) = v659.ToString
    let v672 : string = v671 v662
    v672 
    #endif
#else
    let v681 : US2 option = None
    let _v681 = ref v681 
    match v18 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v682 : int64 = x
    let v683 : US2 = US2_0(v682)
    v683 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v681.Value <- x
    let v684 : US2 option = _v681.Value 
    let v707 : US2 = US2_1
    let v708 : US2 = v684 |> Option.defaultValue v707 
    let v806 : System.DateTime =
        match v708 with
        | US2_1 -> (* None *)
            let v798 : System.DateTime = System.DateTime.Now
            v798
        | US2_0(v716) -> (* Some *)
            let v719 : System.DateTime = System.DateTime.Now
            let v728 : (System.DateTime -> int64) = _.Ticks
            let v729 : int64 = v728 v719
            let v736 : int64 = v729 - v716
            let v739 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v740 : System.TimeSpan = v739 v736
            let v749 : (System.TimeSpan -> int32) = _.Hours
            let v750 : int32 = v749 v740
            let v759 : (System.TimeSpan -> int32) = _.Minutes
            let v760 : int32 = v759 v740
            let v769 : (System.TimeSpan -> int32) = _.Seconds
            let v770 : int32 = v769 v740
            let v779 : (System.TimeSpan -> int32) = _.Milliseconds
            let v780 : int32 = v779 v740
            let v789 : System.DateTime = System.DateTime (1, 1, 1, v750, v760, v770, v780)
            v789
    let v809 : string = method6()
    let v818 : (string -> string) = v806.ToString
    let v819 : string = v818 v809
    v819 
    #endif
    |> fun x -> _v35 <- Some x
    let v826 : string = match _v35 with Some x -> x | None -> failwith "base.run_target / _v35=None"
    let v981 : bool =
        match v0 with
        | US0_0 -> (* Verbose *)
            true
        | _ ->
            false
    let v985 : US3 =
        if v981 then
            let v982 : string = "Verbose"
            US3_0(v982)
        else
            US3_1
    let v1034 : US3 =
        match v985 with
        | US3_1 -> (* None *)
            let v990 : bool =
                match v0 with
                | US0_1 -> (* Debug *)
                    true
                | _ ->
                    false
            let v994 : US3 =
                if v990 then
                    let v991 : string = "Debug"
                    US3_0(v991)
                else
                    US3_1
            match v994 with
            | US3_1 -> (* None *)
                let v999 : bool =
                    match v0 with
                    | US0_2 -> (* Info *)
                        true
                    | _ ->
                        false
                let v1003 : US3 =
                    if v999 then
                        let v1000 : string = "Info"
                        US3_0(v1000)
                    else
                        US3_1
                match v1003 with
                | US3_1 -> (* None *)
                    let v1008 : bool =
                        match v0 with
                        | US0_3 -> (* Warning *)
                            true
                        | _ ->
                            false
                    let v1012 : US3 =
                        if v1008 then
                            let v1009 : string = "Warning"
                            US3_0(v1009)
                        else
                            US3_1
                    match v1012 with
                    | US3_1 -> (* None *)
                        let v1017 : bool =
                            match v0 with
                            | US0_4 -> (* Critical *)
                                true
                            | _ ->
                                false
                        let v1021 : US3 =
                            if v1017 then
                                let v1018 : string = "Critical"
                                US3_0(v1018)
                            else
                                US3_1
                        match v1021 with
                        | US3_1 -> (* None *)
                            US3_1
                        | US3_0(v1022) -> (* Some *)
                            US3_0(v1022)
                    | US3_0(v1013) -> (* Some *)
                        US3_0(v1013)
                | US3_0(v1004) -> (* Some *)
                    US3_0(v1004)
            | US3_0(v995) -> (* Some *)
                US3_0(v995)
        | US3_0(v986) -> (* Some *)
            US3_0(v986)
    let v1038 : string =
        match v1034 with
        | US3_1 -> (* None *)
            failwith<string> "Option does not have a value."
        | US3_0(v1035) -> (* Some *)
            v1035
    let v1041 : (unit -> string) = v1038.ToLower
    let v1042 : string = v1041 ()
    let v1051 : string = v1042.PadLeft (7, ' ')
    let v1083 : bool = true
    let mutable _v1083 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1098 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v1092 : string = "inline_colorization::color_bright_red"
            let v1093 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1092 
            v1093
        | US0_1 -> (* Debug *)
            let v1086 : string = "inline_colorization::color_bright_blue"
            let v1087 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1086 
            v1087
        | US0_2 -> (* Info *)
            let v1088 : string = "inline_colorization::color_bright_green"
            let v1089 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1088 
            v1089
        | US0_0 -> (* Verbose *)
            let v1084 : string = "inline_colorization::color_bright_black"
            let v1085 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1084 
            v1085
        | US0_3 -> (* Warning *)
            let v1090 : string = "inline_colorization::color_yellow"
            let v1091 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1090 
            v1091
    let v1099 : string = "&*$0"
    let v1100 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1051 v1099 
    let v1101 : string = "inline_colorization::color_reset"
    let v1102 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1101 
    let v1103 : string = "\"{v1098}{v1100}{v1102}\""
    let v1104 : string = @$"format!(" + v1103 + ")"
    let v1105 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v1104 
    let v1106 : string = "fable_library_rust::String_::fromString($0)"
    let v1107 : string = Fable.Core.RustInterop.emitRustExpr v1105 v1106 
    v1107 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1122 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v1116 : string = "inline_colorization::color_bright_red"
            let v1117 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1116 
            v1117
        | US0_1 -> (* Debug *)
            let v1110 : string = "inline_colorization::color_bright_blue"
            let v1111 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1110 
            v1111
        | US0_2 -> (* Info *)
            let v1112 : string = "inline_colorization::color_bright_green"
            let v1113 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1112 
            v1113
        | US0_0 -> (* Verbose *)
            let v1108 : string = "inline_colorization::color_bright_black"
            let v1109 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1108 
            v1109
        | US0_3 -> (* Warning *)
            let v1114 : string = "inline_colorization::color_yellow"
            let v1115 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1114 
            v1115
    let v1123 : string = "&*$0"
    let v1124 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1051 v1123 
    let v1125 : string = "inline_colorization::color_reset"
    let v1126 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1125 
    let v1127 : string = "\"{v1122}{v1124}{v1126}\""
    let v1128 : string = @$"format!(" + v1127 + ")"
    let v1129 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v1128 
    let v1130 : string = "fable_library_rust::String_::fromString($0)"
    let v1131 : string = Fable.Core.RustInterop.emitRustExpr v1129 v1130 
    v1131 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1146 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v1140 : string = "inline_colorization::color_bright_red"
            let v1141 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1140 
            v1141
        | US0_1 -> (* Debug *)
            let v1134 : string = "inline_colorization::color_bright_blue"
            let v1135 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1134 
            v1135
        | US0_2 -> (* Info *)
            let v1136 : string = "inline_colorization::color_bright_green"
            let v1137 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1136 
            v1137
        | US0_0 -> (* Verbose *)
            let v1132 : string = "inline_colorization::color_bright_black"
            let v1133 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1132 
            v1133
        | US0_3 -> (* Warning *)
            let v1138 : string = "inline_colorization::color_yellow"
            let v1139 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1138 
            v1139
    let v1147 : string = "&*$0"
    let v1148 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1051 v1147 
    let v1149 : string = "inline_colorization::color_reset"
    let v1150 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1149 
    let v1151 : string = "\"{v1146}{v1148}{v1150}\""
    let v1152 : string = @$"format!(" + v1151 + ")"
    let v1153 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v1152 
    let v1154 : string = "fable_library_rust::String_::fromString($0)"
    let v1155 : string = Fable.Core.RustInterop.emitRustExpr v1153 v1154 
    v1155 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1165 : string =
        match v0 with
        | US0_4 -> (* Critical *)
            let v1160 : string = "\u001b[91m"
            v1160
        | US0_1 -> (* Debug *)
            let v1157 : string = "\u001b[94m"
            v1157
        | US0_2 -> (* Info *)
            let v1158 : string = "\u001b[92m"
            v1158
        | US0_0 -> (* Verbose *)
            let v1156 : string = "\u001b[90m"
            v1156
        | US0_3 -> (* Warning *)
            let v1159 : string = "\u001b[93m"
            v1159
    let v1166 : string = method7()
    let v1167 : string = v1165 + v1051 
    let v1168 : string = v1167 + v1166 
    v1168 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1178 : string =
        match v0 with
        | US0_4 -> (* Critical *)
            let v1173 : string = "\u001b[91m"
            v1173
        | US0_1 -> (* Debug *)
            let v1170 : string = "\u001b[94m"
            v1170
        | US0_2 -> (* Info *)
            let v1171 : string = "\u001b[92m"
            v1171
        | US0_0 -> (* Verbose *)
            let v1169 : string = "\u001b[90m"
            v1169
        | US0_3 -> (* Warning *)
            let v1172 : string = "\u001b[93m"
            v1172
    let v1179 : string = method7()
    let v1180 : string = v1178 + v1051 
    let v1181 : string = v1180 + v1179 
    v1181 
    #endif
#else
    let v1191 : string =
        match v0 with
        | US0_4 -> (* Critical *)
            let v1186 : string = "\u001b[91m"
            v1186
        | US0_1 -> (* Debug *)
            let v1183 : string = "\u001b[94m"
            v1183
        | US0_2 -> (* Info *)
            let v1184 : string = "\u001b[92m"
            v1184
        | US0_0 -> (* Verbose *)
            let v1182 : string = "\u001b[90m"
            v1182
        | US0_3 -> (* Warning *)
            let v1185 : string = "\u001b[93m"
            v1185
    let v1192 : string = method7()
    let v1193 : string = v1191 + v1051 
    let v1194 : string = v1193 + v1192 
    v1194 
    #endif
    |> fun x -> _v1083 <- Some x
    let v1195 : string = match _v1083 with Some x -> x | None -> failwith "base.run_target / _v1083=None"
    let v1214 : int64 = v14.l0
    let struct (v1215 : int32, v1216 : int64, v1217 : int32 option, v1218 : bool) = v2 ()
    let v1219 : string = ""
    let v1220 : Mut4 = {l0 = v1219} : Mut4
    method19(v1220, v1215, v1216, v1217, v1218)
    let v1221 : string = v1220.l0
    let v1224 : string = $"{v826} {v1195} #{v1214} %s{v1 ()} / {v1221}"
    let v1231 : char list = []
    let v1236 : (char list -> (char [])) = List.toArray
    let v1237 : (char []) = v1236 v1231
    let v1244 : string = v1224.TrimStart v1237 
    let v1283 : char list = []
    let v1286 : char list = '/' :: v1283 
    let v1295 : char list = ' ' :: v1286 
    let v1306 : (char list -> (char [])) = List.toArray
    let v1307 : (char []) = v1306 v1295
    let v1314 : string = v1244.TrimEnd v1307 
    v1314
and method18 (v0 : US0, v1 : (unit -> string), v2 : (unit -> struct (int32 * int64 * int32 option * bool))) : unit =
    let v3 : (unit -> string) = closure24(v0, v1, v2)
    method12(v0, v3)
and method17 (v0 : int32 option, v1 : bool, v2 : string, v3 : int32, v4 : int64) : Async<int64> =
    let v7 : bool = true
    let mutable _v7 : Async<int64> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v10 : Async<int64> = null |> unbox<Async<int64>>
    v10 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v19 : Async<int64> = null |> unbox<Async<int64>>
    v19 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v28 : Async<int64> = null |> unbox<Async<int64>>
    v28 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v37 : Async<int64> = null |> unbox<Async<int64>>
    v37 
    #endif
#if FABLE_COMPILER_PYTHON
    let v46 : Async<int64> = null |> unbox<Async<int64>>
    v46 
    #endif
#else
    let v53 : Async<int64> option = None
    let mutable _v53 = v53 
    async {
    let v56 : US7 option = None
    let _v56 = ref v56 
    match v0 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v57 : int32 = x
    let v58 : US7 = US7_0(v57)
    v58 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v56.Value <- x
    let v59 : US7 option = _v56.Value 
    let v82 : US7 = US7_1
    let v83 : US7 = v59 |> Option.defaultValue v82 
    let v1135 : Async<bool> =
        match v83 with
        | US7_1 -> (* None *)
            let v93 : bool = true
            let mutable _v93 : Async<bool> option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v96 : Async<bool> = null |> unbox<Async<bool>>
            v96 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v105 : Async<bool> = null |> unbox<Async<bool>>
            v105 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v114 : Async<bool> = null |> unbox<Async<bool>>
            v114 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v123 : Async<bool> = null |> unbox<Async<bool>>
            v123 
            #endif
#if FABLE_COMPILER_PYTHON
            let v132 : Async<bool> = null |> unbox<Async<bool>>
            v132 
            #endif
#else
            let v139 : Async<bool> option = None
            let mutable _v139 = v139 
            async {
            let v140 : Async<System.Threading.CancellationToken> = Async.CancellationToken
            let! v140 = v140 
            let v141 : System.Threading.CancellationToken = v140 
            let v142 : System.Net.Sockets.TcpClient = new System.Net.Sockets.TcpClient ()
            use v142 = v142 
            let v143 : System.Net.Sockets.TcpClient = v142 
            try
            let v144 : System.Threading.Tasks.ValueTask = v143.ConnectAsync (v2, v3, v141)
            let v145 : (unit -> System.Threading.Tasks.Task) = v144.AsTask
            let v146 : System.Threading.Tasks.Task = v145 ()
            let v149 : bool = true
            let mutable _v149 : Async<unit> option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v152 : Async<unit> = null |> unbox<Async<unit>>
            v152 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v161 : Async<unit> = null |> unbox<Async<unit>>
            v161 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v170 : Async<unit> = null |> unbox<Async<unit>>
            v170 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v179 : Async<unit> = null |> unbox<Async<unit>>
            v179 
            #endif
#if FABLE_COMPILER_PYTHON
            let v188 : Async<unit> = null |> unbox<Async<unit>>
            v188 
            #endif
#else
            let v195 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
            let v196 : Async<unit> = v195 v146
            v196 
            #endif
            |> fun x -> _v149 <- Some x
            let v197 : Async<unit> = match _v149 with Some x -> x | None -> failwith "base.run_target / _v149=None"
            do! v197 
            return true 
            with ex ->
            let v212 : exn = ex
            let v215 : bool = true
            let mutable _v215 : string option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v218 : string = $"%A{v212}"
            v218 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v227 : string = $"%A{v212}"
            v227 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v236 : string = $"%A{v212}"
            v236 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v245 : string = $"%A{v212}"
            v245 
            #endif
#if FABLE_COMPILER_PYTHON
            let v254 : string = $"%A{v212}"
            v254 
            #endif
#else
            let v261 : string = $"{v212.GetType ()}: {v212.Message}"
            v261 
            #endif
            |> fun x -> _v215 <- Some x
            let v262 : string = match _v215 with Some x -> x | None -> failwith "base.run_target / _v215=None"
            let v277 : US0 = US0_0
            let v278 : (unit -> string) = closure4()
            let v279 : (unit -> struct (int32 * string)) = closure5(v3, v262)
            method4(v277, v278, v279)
            return false 
            (*
            let v280 : bool = *)
            }
            |> fun x -> _v139 <- Some x
            let v281 : Async<bool> = match _v139 with Some x -> x | None -> failwith "async.new_async_unit / _v139=None"
            v281 
            #endif
            |> fun x -> _v93 <- Some x
            let v282 : Async<bool> = match _v93 with Some x -> x | None -> failwith "base.run_target / _v93=None"
            v282
        | US7_0(v297) -> (* Some *)
            let v300 : bool = true
            let mutable _v300 : Async<bool> option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v303 : Async<bool> = null |> unbox<Async<bool>>
            v303 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v312 : Async<bool> = null |> unbox<Async<bool>>
            v312 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v321 : Async<bool> = null |> unbox<Async<bool>>
            v321 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v330 : Async<bool> = null |> unbox<Async<bool>>
            v330 
            #endif
#if FABLE_COMPILER_PYTHON
            let v339 : Async<bool> = null |> unbox<Async<bool>>
            v339 
            #endif
#else
            let v346 : Async<bool> option = None
            let mutable _v346 = v346 
            async {
            let v349 : bool = true
            let mutable _v349 : Async<bool> option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v352 : Async<bool> = null |> unbox<Async<bool>>
            v352 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v361 : Async<bool> = null |> unbox<Async<bool>>
            v361 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v370 : Async<bool> = null |> unbox<Async<bool>>
            v370 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v379 : Async<bool> = null |> unbox<Async<bool>>
            v379 
            #endif
#if FABLE_COMPILER_PYTHON
            let v388 : Async<bool> = null |> unbox<Async<bool>>
            v388 
            #endif
#else
            let v395 : Async<bool> option = None
            let mutable _v395 = v395 
            async {
            let v396 : Async<System.Threading.CancellationToken> = Async.CancellationToken
            let! v396 = v396 
            let v397 : System.Threading.CancellationToken = v396 
            let v398 : System.Net.Sockets.TcpClient = new System.Net.Sockets.TcpClient ()
            use v398 = v398 
            let v399 : System.Net.Sockets.TcpClient = v398 
            try
            let v400 : System.Threading.Tasks.ValueTask = v399.ConnectAsync (v2, v3, v397)
            let v401 : (unit -> System.Threading.Tasks.Task) = v400.AsTask
            let v402 : System.Threading.Tasks.Task = v401 ()
            let v405 : bool = true
            let mutable _v405 : Async<unit> option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v408 : Async<unit> = null |> unbox<Async<unit>>
            v408 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v417 : Async<unit> = null |> unbox<Async<unit>>
            v417 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v426 : Async<unit> = null |> unbox<Async<unit>>
            v426 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v435 : Async<unit> = null |> unbox<Async<unit>>
            v435 
            #endif
#if FABLE_COMPILER_PYTHON
            let v444 : Async<unit> = null |> unbox<Async<unit>>
            v444 
            #endif
#else
            let v451 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
            let v452 : Async<unit> = v451 v402
            v452 
            #endif
            |> fun x -> _v405 <- Some x
            let v453 : Async<unit> = match _v405 with Some x -> x | None -> failwith "base.run_target / _v405=None"
            do! v453 
            return true 
            with ex ->
            let v468 : exn = ex
            let v471 : bool = true
            let mutable _v471 : string option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v474 : string = $"%A{v468}"
            v474 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v483 : string = $"%A{v468}"
            v483 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v492 : string = $"%A{v468}"
            v492 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v501 : string = $"%A{v468}"
            v501 
            #endif
#if FABLE_COMPILER_PYTHON
            let v510 : string = $"%A{v468}"
            v510 
            #endif
#else
            let v517 : string = $"{v468.GetType ()}: {v468.Message}"
            v517 
            #endif
            |> fun x -> _v471 <- Some x
            let v518 : string = match _v471 with Some x -> x | None -> failwith "base.run_target / _v471=None"
            let v533 : US0 = US0_0
            let v534 : (unit -> string) = closure4()
            let v535 : (unit -> struct (int32 * string)) = closure5(v3, v518)
            method4(v533, v534, v535)
            return false 
            (*
            let v536 : bool = *)
            }
            |> fun x -> _v395 <- Some x
            let v537 : Async<bool> = match _v395 with Some x -> x | None -> failwith "async.new_async_unit / _v395=None"
            v537 
            #endif
            |> fun x -> _v349 <- Some x
            let v538 : Async<bool> = match _v349 with Some x -> x | None -> failwith "base.run_target / _v349=None"
            let v555 : bool = true
            let mutable _v555 : Async<US4> option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v558 : Async<US4> = null |> unbox<Async<US4>>
            v558 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v567 : Async<US4> = null |> unbox<Async<US4>>
            v567 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v576 : Async<US4> = null |> unbox<Async<US4>>
            v576 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v585 : Async<US4> = null |> unbox<Async<US4>>
            v585 
            #endif
#if FABLE_COMPILER_PYTHON
            let v594 : Async<US4> = null |> unbox<Async<US4>>
            v594 
            #endif
#else
            let v603 : bool = true
            let mutable _v603 : Async<US4> option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v606 : Async<US4> = null |> unbox<Async<US4>>
            v606 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v615 : Async<US4> = null |> unbox<Async<US4>>
            v615 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v624 : Async<US4> = null |> unbox<Async<US4>>
            v624 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v633 : Async<US4> = null |> unbox<Async<US4>>
            v633 
            #endif
#if FABLE_COMPILER_PYTHON
            let v642 : Async<US4> = null |> unbox<Async<US4>>
            v642 
            #endif
#else
            let v649 : Async<US4> option = None
            let mutable _v649 = v649 
            async {
            let v652 : bool = true
            let mutable _v652 : Async<Async<bool>> option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v655 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            v655 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v664 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            v664 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v673 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            v673 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v682 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            v682 
            #endif
#if FABLE_COMPILER_PYTHON
            let v691 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            v691 
            #endif
#else
            let v698 : Async<Async<bool>> = Async.StartChild (v538, v297)
            v698 
            #endif
            |> fun x -> _v652 <- Some x
            let v699 : Async<Async<bool>> = match _v652 with Some x -> x | None -> failwith "base.run_target / _v652=None"
            let! v699 = v699 
            let v714 : Async<bool> = v699 
            let v717 : bool = true
            let mutable _v717 : Async<Choice<bool, exn>> option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v720 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
            v720 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v729 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
            v729 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v738 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
            v738 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v747 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
            v747 
            #endif
#if FABLE_COMPILER_PYTHON
            let v756 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
            v756 
            #endif
#else
            let v763 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v764 : Async<Choice<bool, exn>> = v763 v714
            v764 
            #endif
            |> fun x -> _v717 <- Some x
            let v765 : Async<Choice<bool, exn>> = match _v717 with Some x -> x | None -> failwith "base.run_target / _v717=None"
            let v782 : bool = true
            let mutable _v782 : Async<US5> option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v785 : Async<US5> = null |> unbox<Async<US5>>
            v785 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v794 : Async<US5> = null |> unbox<Async<US5>>
            v794 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v803 : Async<US5> = null |> unbox<Async<US5>>
            v803 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v812 : Async<US5> = null |> unbox<Async<US5>>
            v812 
            #endif
#if FABLE_COMPILER_PYTHON
            let v821 : Async<US5> = null |> unbox<Async<US5>>
            v821 
            #endif
#else
            let v828 : Async<US5> option = None
            let mutable _v828 = v828 
            async {
            let! v765 = v765 
            let v829 : Choice<bool, exn> = v765 
            let v832 : bool = true
            let mutable _v832 : US5 option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v835 : US5 = null |> unbox<US5>
            v835 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v844 : US5 = null |> unbox<US5>
            v844 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v853 : US5 = null |> unbox<US5>
            v853 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v862 : US5 = null |> unbox<US5>
            v862 
            #endif
#if FABLE_COMPILER_PYTHON
            let v871 : US5 = null |> unbox<US5>
            v871 
            #endif
#else
            let v878 : (bool -> US5) = closure10()
            let v879 : (exn -> US5) = closure11()
            let v880 : US5 = match v829 with Choice1Of2 x -> v878 x | Choice2Of2 x -> v879 x
            v880 
            #endif
            |> fun x -> _v832 <- Some x
            let v881 : US5 = match _v832 with Some x -> x | None -> failwith "base.run_target / _v832=None"
            return v881 
            }
            |> fun x -> _v828 <- Some x
            let v896 : Async<US5> = match _v828 with Some x -> x | None -> failwith "async.new_async_unit / _v828=None"
            v896 
            #endif
            |> fun x -> _v782 <- Some x
            let v897 : Async<US5> = match _v782 with Some x -> x | None -> failwith "base.run_target / _v782=None"
            let v914 : bool = true
            let mutable _v914 : Async<US6> option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v917 : Async<US6> = null |> unbox<Async<US6>>
            v917 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v926 : Async<US6> = null |> unbox<Async<US6>>
            v926 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v935 : Async<US6> = null |> unbox<Async<US6>>
            v935 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v944 : Async<US6> = null |> unbox<Async<US6>>
            v944 
            #endif
#if FABLE_COMPILER_PYTHON
            let v953 : Async<US6> = null |> unbox<Async<US6>>
            v953 
            #endif
#else
            let v960 : Async<US6> option = None
            let mutable _v960 = v960 
            async {
            let! v897 = v897 
            let v961 : US5 = v897 
            let v967 : US6 =
                match v961 with
                | US5_0(v962) -> (* C1of2 *)
                    US6_0(v962)
                | US5_1(v964) -> (* C2of2 *)
                    US6_1(v964)
            return v967 
            }
            |> fun x -> _v960 <- Some x
            let v968 : Async<US6> = match _v960 with Some x -> x | None -> failwith "async.new_async_unit / _v960=None"
            v968 
            #endif
            |> fun x -> _v914 <- Some x
            let v969 : Async<US6> = match _v914 with Some x -> x | None -> failwith "base.run_target / _v914=None"
            let v986 : bool = true
            let mutable _v986 : Async<US4> option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v989 : Async<US4> = null |> unbox<Async<US4>>
            v989 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v998 : Async<US4> = null |> unbox<Async<US4>>
            v998 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1007 : Async<US4> = null |> unbox<Async<US4>>
            v1007 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1016 : Async<US4> = null |> unbox<Async<US4>>
            v1016 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1025 : Async<US4> = null |> unbox<Async<US4>>
            v1025 
            #endif
#else
            let v1032 : Async<US4> option = None
            let mutable _v1032 = v1032 
            async {
            let! v969 = v969 
            let v1033 : US6 = v969 
            let v1066 : US4 =
                match v1033 with
                | US6_1(v1036) -> (* Error *)
                    let v1039 : string = $"%A{v1036}"
                    let v1048 : string = "System.TimeoutException"
                    let v1049 : bool = v1039.Contains v1048 
                    if v1049 then
                        let v1056 : US0 = US0_0
                        let v1057 : (unit -> string) = closure12()
                        let v1058 : (unit -> int32) = closure13(v297)
                        method13(v1056, v1057, v1058)
                        US4_1
                    else
                        let v1060 : US0 = US0_4
                        let v1061 : (unit -> string) = closure15()
                        let v1062 : (unit -> struct (int32 * string)) = closure16(v297, v1036)
                        method15(v1060, v1061, v1062)
                        US4_1
                | US6_0(v1034) -> (* Ok *)
                    US4_0(v1034)
            return v1066 
            }
            |> fun x -> _v1032 <- Some x
            let v1067 : Async<US4> = match _v1032 with Some x -> x | None -> failwith "async.new_async_unit / _v1032=None"
            v1067 
            #endif
            |> fun x -> _v986 <- Some x
            let v1068 : Async<US4> = match _v986 with Some x -> x | None -> failwith "base.run_target / _v986=None"
            return! v1068 
            }
            |> fun x -> _v649 <- Some x
            let v1083 : Async<US4> = match _v649 with Some x -> x | None -> failwith "async.new_async_unit / _v649=None"
            v1083 
            #endif
            |> fun x -> _v603 <- Some x
            let v1084 : Async<US4> = match _v603 with Some x -> x | None -> failwith "base.run_target / _v603=None"
            v1084 
            #endif
            |> fun x -> _v555 <- Some x
            let v1099 : Async<US4> = match _v555 with Some x -> x | None -> failwith "base.run_target / _v555=None"
            let! v1099 = v1099 
            let v1114 : US4 = v1099 
            let v1117 : bool =
                match v1114 with
                | US4_1 -> (* None *)
                    false
                | US4_0(v1115) -> (* Some *)
                    v1115
            return v1117 
            }
            |> fun x -> _v346 <- Some x
            let v1118 : Async<bool> = match _v346 with Some x -> x | None -> failwith "async.new_async_unit / _v346=None"
            v1118 
            #endif
            |> fun x -> _v300 <- Some x
            let v1119 : Async<bool> = match _v300 with Some x -> x | None -> failwith "base.run_target / _v300=None"
            v1119
    let! v1135 = v1135 
    let v1136 : bool = v1135 
    let v1137 : bool = v1136 = v1
    if v1137 then
        return v4 
        (*
        ()
    else
        *) else
        let v1138 : int64 = v4 % 100L
        let v1139 : bool = v1138 = 0L
        if v1139 then
            let v1140 : US0 = US0_0
            let v1141 : (unit -> string) = closure22()
            let v1142 : (unit -> struct (int32 * int64 * int32 option * bool)) = closure23(v0, v1, v3, v4)
            method18(v1140, v1141, v1142)
        let v1145 : bool = true
        let mutable _v1145 : Async<unit> option = None 
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v1148 : Async<unit> = null |> unbox<Async<unit>>
        v1148 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v1157 : Async<unit> = null |> unbox<Async<unit>>
        v1157 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v1166 : Async<unit> = null |> unbox<Async<unit>>
        v1166 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v1175 : Async<unit> = null |> unbox<Async<unit>>
        v1175 
        #endif
#if FABLE_COMPILER_PYTHON
        let v1184 : Async<unit> = null |> unbox<Async<unit>>
        v1184 
        #endif
#else
        let v1191 : (int32 -> Async<unit>) = Async.Sleep
        let v1192 : Async<unit> = v1191 10
        v1192 
        #endif
        |> fun x -> _v1145 <- Some x
        let v1193 : Async<unit> = match _v1145 with Some x -> x | None -> failwith "base.run_target / _v1145=None"
        do! v1193 
        let v1208 : int64 = v4 + 1L
        let v1209 : Async<int64> = method17(v0, v1, v2, v3, v1208)
        return! v1209 
        (*
        ()
    *)
    }
    |> fun x -> _v53 <- Some x
    let v1210 : Async<int64> = match _v53 with Some x -> x | None -> failwith "async.new_async_unit / _v53=None"
    v1210 
    #endif
    |> fun x -> _v7 <- Some x
    let v1211 : Async<int64> = match _v7 with Some x -> x | None -> failwith "base.run_target / _v7=None"
    v1211
and closure21 (v0 : int32 option, v1 : bool, v2 : string) (v3 : int32) : Async<int64> =
    let v4 : int64 = 0L
    method17(v0, v1, v2, v3, v4)
and closure20 (v0 : int32 option, v1 : bool) (v2 : string) : (int32 -> Async<int64>) =
    closure21(v0, v1, v2)
and closure19 (v0 : int32 option) (v1 : bool) : (string -> (int32 -> Async<int64>)) =
    closure20(v0, v1)
and closure18 () (v0 : int32 option) : (bool -> (string -> (int32 -> Async<int64>))) =
    closure19(v0)
and method23 (v0 : int32 option, v1 : string, v2 : int32) : Async<int32> =
    let v5 : bool = true
    let mutable _v5 : Async<int32> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v8 : Async<int32> = null |> unbox<Async<int32>>
    v8 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v17 : Async<int32> = null |> unbox<Async<int32>>
    v17 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v26 : Async<int32> = null |> unbox<Async<int32>>
    v26 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v35 : Async<int32> = null |> unbox<Async<int32>>
    v35 
    #endif
#if FABLE_COMPILER_PYTHON
    let v44 : Async<int32> = null |> unbox<Async<int32>>
    v44 
    #endif
#else
    let v51 : Async<int32> option = None
    let mutable _v51 = v51 
    async {
    let v54 : US7 option = None
    let _v54 = ref v54 
    match v0 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v55 : int32 = x
    let v56 : US7 = US7_0(v55)
    v56 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v54.Value <- x
    let v57 : US7 option = _v54.Value 
    let v80 : US7 = US7_1
    let v81 : US7 = v57 |> Option.defaultValue v80 
    let v1133 : Async<bool> =
        match v81 with
        | US7_1 -> (* None *)
            let v91 : bool = true
            let mutable _v91 : Async<bool> option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v94 : Async<bool> = null |> unbox<Async<bool>>
            v94 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v103 : Async<bool> = null |> unbox<Async<bool>>
            v103 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v112 : Async<bool> = null |> unbox<Async<bool>>
            v112 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v121 : Async<bool> = null |> unbox<Async<bool>>
            v121 
            #endif
#if FABLE_COMPILER_PYTHON
            let v130 : Async<bool> = null |> unbox<Async<bool>>
            v130 
            #endif
#else
            let v137 : Async<bool> option = None
            let mutable _v137 = v137 
            async {
            let v138 : Async<System.Threading.CancellationToken> = Async.CancellationToken
            let! v138 = v138 
            let v139 : System.Threading.CancellationToken = v138 
            let v140 : System.Net.Sockets.TcpClient = new System.Net.Sockets.TcpClient ()
            use v140 = v140 
            let v141 : System.Net.Sockets.TcpClient = v140 
            try
            let v142 : System.Threading.Tasks.ValueTask = v141.ConnectAsync (v1, v2, v139)
            let v143 : (unit -> System.Threading.Tasks.Task) = v142.AsTask
            let v144 : System.Threading.Tasks.Task = v143 ()
            let v147 : bool = true
            let mutable _v147 : Async<unit> option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v150 : Async<unit> = null |> unbox<Async<unit>>
            v150 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v159 : Async<unit> = null |> unbox<Async<unit>>
            v159 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v168 : Async<unit> = null |> unbox<Async<unit>>
            v168 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v177 : Async<unit> = null |> unbox<Async<unit>>
            v177 
            #endif
#if FABLE_COMPILER_PYTHON
            let v186 : Async<unit> = null |> unbox<Async<unit>>
            v186 
            #endif
#else
            let v193 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
            let v194 : Async<unit> = v193 v144
            v194 
            #endif
            |> fun x -> _v147 <- Some x
            let v195 : Async<unit> = match _v147 with Some x -> x | None -> failwith "base.run_target / _v147=None"
            do! v195 
            return true 
            with ex ->
            let v210 : exn = ex
            let v213 : bool = true
            let mutable _v213 : string option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v216 : string = $"%A{v210}"
            v216 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v225 : string = $"%A{v210}"
            v225 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v234 : string = $"%A{v210}"
            v234 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v243 : string = $"%A{v210}"
            v243 
            #endif
#if FABLE_COMPILER_PYTHON
            let v252 : string = $"%A{v210}"
            v252 
            #endif
#else
            let v259 : string = $"{v210.GetType ()}: {v210.Message}"
            v259 
            #endif
            |> fun x -> _v213 <- Some x
            let v260 : string = match _v213 with Some x -> x | None -> failwith "base.run_target / _v213=None"
            let v275 : US0 = US0_0
            let v276 : (unit -> string) = closure4()
            let v277 : (unit -> struct (int32 * string)) = closure5(v2, v260)
            method4(v275, v276, v277)
            return false 
            (*
            let v278 : bool = *)
            }
            |> fun x -> _v137 <- Some x
            let v279 : Async<bool> = match _v137 with Some x -> x | None -> failwith "async.new_async_unit / _v137=None"
            v279 
            #endif
            |> fun x -> _v91 <- Some x
            let v280 : Async<bool> = match _v91 with Some x -> x | None -> failwith "base.run_target / _v91=None"
            v280
        | US7_0(v295) -> (* Some *)
            let v298 : bool = true
            let mutable _v298 : Async<bool> option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v301 : Async<bool> = null |> unbox<Async<bool>>
            v301 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v310 : Async<bool> = null |> unbox<Async<bool>>
            v310 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v319 : Async<bool> = null |> unbox<Async<bool>>
            v319 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v328 : Async<bool> = null |> unbox<Async<bool>>
            v328 
            #endif
#if FABLE_COMPILER_PYTHON
            let v337 : Async<bool> = null |> unbox<Async<bool>>
            v337 
            #endif
#else
            let v344 : Async<bool> option = None
            let mutable _v344 = v344 
            async {
            let v347 : bool = true
            let mutable _v347 : Async<bool> option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v350 : Async<bool> = null |> unbox<Async<bool>>
            v350 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v359 : Async<bool> = null |> unbox<Async<bool>>
            v359 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v368 : Async<bool> = null |> unbox<Async<bool>>
            v368 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v377 : Async<bool> = null |> unbox<Async<bool>>
            v377 
            #endif
#if FABLE_COMPILER_PYTHON
            let v386 : Async<bool> = null |> unbox<Async<bool>>
            v386 
            #endif
#else
            let v393 : Async<bool> option = None
            let mutable _v393 = v393 
            async {
            let v394 : Async<System.Threading.CancellationToken> = Async.CancellationToken
            let! v394 = v394 
            let v395 : System.Threading.CancellationToken = v394 
            let v396 : System.Net.Sockets.TcpClient = new System.Net.Sockets.TcpClient ()
            use v396 = v396 
            let v397 : System.Net.Sockets.TcpClient = v396 
            try
            let v398 : System.Threading.Tasks.ValueTask = v397.ConnectAsync (v1, v2, v395)
            let v399 : (unit -> System.Threading.Tasks.Task) = v398.AsTask
            let v400 : System.Threading.Tasks.Task = v399 ()
            let v403 : bool = true
            let mutable _v403 : Async<unit> option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v406 : Async<unit> = null |> unbox<Async<unit>>
            v406 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v415 : Async<unit> = null |> unbox<Async<unit>>
            v415 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v424 : Async<unit> = null |> unbox<Async<unit>>
            v424 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v433 : Async<unit> = null |> unbox<Async<unit>>
            v433 
            #endif
#if FABLE_COMPILER_PYTHON
            let v442 : Async<unit> = null |> unbox<Async<unit>>
            v442 
            #endif
#else
            let v449 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
            let v450 : Async<unit> = v449 v400
            v450 
            #endif
            |> fun x -> _v403 <- Some x
            let v451 : Async<unit> = match _v403 with Some x -> x | None -> failwith "base.run_target / _v403=None"
            do! v451 
            return true 
            with ex ->
            let v466 : exn = ex
            let v469 : bool = true
            let mutable _v469 : string option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v472 : string = $"%A{v466}"
            v472 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v481 : string = $"%A{v466}"
            v481 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v490 : string = $"%A{v466}"
            v490 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v499 : string = $"%A{v466}"
            v499 
            #endif
#if FABLE_COMPILER_PYTHON
            let v508 : string = $"%A{v466}"
            v508 
            #endif
#else
            let v515 : string = $"{v466.GetType ()}: {v466.Message}"
            v515 
            #endif
            |> fun x -> _v469 <- Some x
            let v516 : string = match _v469 with Some x -> x | None -> failwith "base.run_target / _v469=None"
            let v531 : US0 = US0_0
            let v532 : (unit -> string) = closure4()
            let v533 : (unit -> struct (int32 * string)) = closure5(v2, v516)
            method4(v531, v532, v533)
            return false 
            (*
            let v534 : bool = *)
            }
            |> fun x -> _v393 <- Some x
            let v535 : Async<bool> = match _v393 with Some x -> x | None -> failwith "async.new_async_unit / _v393=None"
            v535 
            #endif
            |> fun x -> _v347 <- Some x
            let v536 : Async<bool> = match _v347 with Some x -> x | None -> failwith "base.run_target / _v347=None"
            let v553 : bool = true
            let mutable _v553 : Async<US4> option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v556 : Async<US4> = null |> unbox<Async<US4>>
            v556 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v565 : Async<US4> = null |> unbox<Async<US4>>
            v565 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v574 : Async<US4> = null |> unbox<Async<US4>>
            v574 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v583 : Async<US4> = null |> unbox<Async<US4>>
            v583 
            #endif
#if FABLE_COMPILER_PYTHON
            let v592 : Async<US4> = null |> unbox<Async<US4>>
            v592 
            #endif
#else
            let v601 : bool = true
            let mutable _v601 : Async<US4> option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v604 : Async<US4> = null |> unbox<Async<US4>>
            v604 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v613 : Async<US4> = null |> unbox<Async<US4>>
            v613 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v622 : Async<US4> = null |> unbox<Async<US4>>
            v622 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v631 : Async<US4> = null |> unbox<Async<US4>>
            v631 
            #endif
#if FABLE_COMPILER_PYTHON
            let v640 : Async<US4> = null |> unbox<Async<US4>>
            v640 
            #endif
#else
            let v647 : Async<US4> option = None
            let mutable _v647 = v647 
            async {
            let v650 : bool = true
            let mutable _v650 : Async<Async<bool>> option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v653 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            v653 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v662 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            v662 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v671 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            v671 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v680 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            v680 
            #endif
#if FABLE_COMPILER_PYTHON
            let v689 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            v689 
            #endif
#else
            let v696 : Async<Async<bool>> = Async.StartChild (v536, v295)
            v696 
            #endif
            |> fun x -> _v650 <- Some x
            let v697 : Async<Async<bool>> = match _v650 with Some x -> x | None -> failwith "base.run_target / _v650=None"
            let! v697 = v697 
            let v712 : Async<bool> = v697 
            let v715 : bool = true
            let mutable _v715 : Async<Choice<bool, exn>> option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v718 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
            v718 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v727 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
            v727 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v736 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
            v736 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v745 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
            v745 
            #endif
#if FABLE_COMPILER_PYTHON
            let v754 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
            v754 
            #endif
#else
            let v761 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v762 : Async<Choice<bool, exn>> = v761 v712
            v762 
            #endif
            |> fun x -> _v715 <- Some x
            let v763 : Async<Choice<bool, exn>> = match _v715 with Some x -> x | None -> failwith "base.run_target / _v715=None"
            let v780 : bool = true
            let mutable _v780 : Async<US5> option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v783 : Async<US5> = null |> unbox<Async<US5>>
            v783 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v792 : Async<US5> = null |> unbox<Async<US5>>
            v792 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v801 : Async<US5> = null |> unbox<Async<US5>>
            v801 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v810 : Async<US5> = null |> unbox<Async<US5>>
            v810 
            #endif
#if FABLE_COMPILER_PYTHON
            let v819 : Async<US5> = null |> unbox<Async<US5>>
            v819 
            #endif
#else
            let v826 : Async<US5> option = None
            let mutable _v826 = v826 
            async {
            let! v763 = v763 
            let v827 : Choice<bool, exn> = v763 
            let v830 : bool = true
            let mutable _v830 : US5 option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v833 : US5 = null |> unbox<US5>
            v833 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v842 : US5 = null |> unbox<US5>
            v842 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v851 : US5 = null |> unbox<US5>
            v851 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v860 : US5 = null |> unbox<US5>
            v860 
            #endif
#if FABLE_COMPILER_PYTHON
            let v869 : US5 = null |> unbox<US5>
            v869 
            #endif
#else
            let v876 : (bool -> US5) = closure10()
            let v877 : (exn -> US5) = closure11()
            let v878 : US5 = match v827 with Choice1Of2 x -> v876 x | Choice2Of2 x -> v877 x
            v878 
            #endif
            |> fun x -> _v830 <- Some x
            let v879 : US5 = match _v830 with Some x -> x | None -> failwith "base.run_target / _v830=None"
            return v879 
            }
            |> fun x -> _v826 <- Some x
            let v894 : Async<US5> = match _v826 with Some x -> x | None -> failwith "async.new_async_unit / _v826=None"
            v894 
            #endif
            |> fun x -> _v780 <- Some x
            let v895 : Async<US5> = match _v780 with Some x -> x | None -> failwith "base.run_target / _v780=None"
            let v912 : bool = true
            let mutable _v912 : Async<US6> option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v915 : Async<US6> = null |> unbox<Async<US6>>
            v915 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v924 : Async<US6> = null |> unbox<Async<US6>>
            v924 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v933 : Async<US6> = null |> unbox<Async<US6>>
            v933 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v942 : Async<US6> = null |> unbox<Async<US6>>
            v942 
            #endif
#if FABLE_COMPILER_PYTHON
            let v951 : Async<US6> = null |> unbox<Async<US6>>
            v951 
            #endif
#else
            let v958 : Async<US6> option = None
            let mutable _v958 = v958 
            async {
            let! v895 = v895 
            let v959 : US5 = v895 
            let v965 : US6 =
                match v959 with
                | US5_0(v960) -> (* C1of2 *)
                    US6_0(v960)
                | US5_1(v962) -> (* C2of2 *)
                    US6_1(v962)
            return v965 
            }
            |> fun x -> _v958 <- Some x
            let v966 : Async<US6> = match _v958 with Some x -> x | None -> failwith "async.new_async_unit / _v958=None"
            v966 
            #endif
            |> fun x -> _v912 <- Some x
            let v967 : Async<US6> = match _v912 with Some x -> x | None -> failwith "base.run_target / _v912=None"
            let v984 : bool = true
            let mutable _v984 : Async<US4> option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v987 : Async<US4> = null |> unbox<Async<US4>>
            v987 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v996 : Async<US4> = null |> unbox<Async<US4>>
            v996 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1005 : Async<US4> = null |> unbox<Async<US4>>
            v1005 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1014 : Async<US4> = null |> unbox<Async<US4>>
            v1014 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1023 : Async<US4> = null |> unbox<Async<US4>>
            v1023 
            #endif
#else
            let v1030 : Async<US4> option = None
            let mutable _v1030 = v1030 
            async {
            let! v967 = v967 
            let v1031 : US6 = v967 
            let v1064 : US4 =
                match v1031 with
                | US6_1(v1034) -> (* Error *)
                    let v1037 : string = $"%A{v1034}"
                    let v1046 : string = "System.TimeoutException"
                    let v1047 : bool = v1037.Contains v1046 
                    if v1047 then
                        let v1054 : US0 = US0_0
                        let v1055 : (unit -> string) = closure12()
                        let v1056 : (unit -> int32) = closure13(v295)
                        method13(v1054, v1055, v1056)
                        US4_1
                    else
                        let v1058 : US0 = US0_4
                        let v1059 : (unit -> string) = closure15()
                        let v1060 : (unit -> struct (int32 * string)) = closure16(v295, v1034)
                        method15(v1058, v1059, v1060)
                        US4_1
                | US6_0(v1032) -> (* Ok *)
                    US4_0(v1032)
            return v1064 
            }
            |> fun x -> _v1030 <- Some x
            let v1065 : Async<US4> = match _v1030 with Some x -> x | None -> failwith "async.new_async_unit / _v1030=None"
            v1065 
            #endif
            |> fun x -> _v984 <- Some x
            let v1066 : Async<US4> = match _v984 with Some x -> x | None -> failwith "base.run_target / _v984=None"
            return! v1066 
            }
            |> fun x -> _v647 <- Some x
            let v1081 : Async<US4> = match _v647 with Some x -> x | None -> failwith "async.new_async_unit / _v647=None"
            v1081 
            #endif
            |> fun x -> _v601 <- Some x
            let v1082 : Async<US4> = match _v601 with Some x -> x | None -> failwith "base.run_target / _v601=None"
            v1082 
            #endif
            |> fun x -> _v553 <- Some x
            let v1097 : Async<US4> = match _v553 with Some x -> x | None -> failwith "base.run_target / _v553=None"
            let! v1097 = v1097 
            let v1112 : US4 = v1097 
            let v1115 : bool =
                match v1112 with
                | US4_1 -> (* None *)
                    false
                | US4_0(v1113) -> (* Some *)
                    v1113
            return v1115 
            }
            |> fun x -> _v344 <- Some x
            let v1116 : Async<bool> = match _v344 with Some x -> x | None -> failwith "async.new_async_unit / _v344=None"
            v1116 
            #endif
            |> fun x -> _v298 <- Some x
            let v1117 : Async<bool> = match _v298 with Some x -> x | None -> failwith "base.run_target / _v298=None"
            v1117
    let! v1133 = v1133 
    let v1134 : bool = v1133 
    let v1135 : bool = v1134 = false
    if v1135 then
        return v2 
        (*
        ()
    else
        *) else
        let v1136 : int32 = v2 + 1
        let v1137 : Async<int32> = method23(v0, v1, v1136)
        return! v1137 
        (*
        ()
    *)
    }
    |> fun x -> _v51 <- Some x
    let v1138 : Async<int32> = match _v51 with Some x -> x | None -> failwith "async.new_async_unit / _v51=None"
    v1138 
    #endif
    |> fun x -> _v5 <- Some x
    let v1139 : Async<int32> = match _v5 with Some x -> x | None -> failwith "base.run_target / _v5=None"
    v1139
and closure27 (v0 : int32 option, v1 : string) (v2 : int32) : Async<int32> =
    method23(v0, v1, v2)
and closure26 (v0 : int32 option) (v1 : string) : (int32 -> Async<int32>) =
    closure27(v0, v1)
and closure25 () (v0 : int32 option) : (string -> (int32 -> Async<int32>)) =
    closure26(v0)
let v2 : (US0 -> struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option)) = closure0()
let v3 : US0 = US0_0
if State.trace_state.IsNone then State.trace_state <- v2 v3 |> Some
let v9 : (string -> (int32 -> Async<bool>)) = closure2()
let test_port_open x = v9 x
let v10 : (int32 -> (string -> (int32 -> Async<bool>))) = closure7()
let test_port_open_timeout x = v10 x
let v11 : (int32 option -> (bool -> (string -> (int32 -> Async<int64>)))) = closure18()
let wait_for_port_access x = v11 x
let v12 : (int32 option -> (string -> (int32 -> Async<int32>))) = closure25()
let get_available_port x = v12 x
()
