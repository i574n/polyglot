#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::string::String")>]
type std_string_String = class end
#else
type std_string_String = string
#endif

#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("&$0")>]
type Ref<'T> = class end
#else
type Ref<'T> = 'T
#endif

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
type Str = class end
#else
type Str = string
#endif

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
and closure1 () (v0 : string) : US1 =
    US1_0(v0)
and method4 () : (string -> US1) =
    closure1()
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
and closure2 () (v0 : string) : unit =
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
    let v69 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v70 : string = "String::from($0)"
    let v71 : std_string_String = Fable.Core.RustInterop.emitRustExpr v68 v70 
    let _v69 = v71 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v72 : string = "String::from($0)"
    let v73 : std_string_String = Fable.Core.RustInterop.emitRustExpr v68 v72 
    let _v69 = v73 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v74 : string = "String::from($0)"
    let v75 : std_string_String = Fable.Core.RustInterop.emitRustExpr v68 v74 
    let _v69 = v75 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v76 : std_string_String = v68 |> unbox<std_string_String>
    let _v69 = v76 
    #endif
#if FABLE_COMPILER_PYTHON
    let v79 : std_string_String = v68 |> unbox<std_string_String>
    let _v69 = v79 
    #endif
#else
    let v82 : std_string_String = v68 |> unbox<std_string_String>
    let _v69 = v82 
    #endif
    let v85 : std_string_String = _v69 
    let v90 : string = "fable_library_rust::String_::fromString($0)"
    let v91 : string = Fable.Core.RustInterop.emitRustExpr v85 v90 
    let _v66 = v91 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v92 : string = "env!(\"" + v65 + "\")"
    let v93 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v92 
    let v94 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v95 : string = "String::from($0)"
    let v96 : std_string_String = Fable.Core.RustInterop.emitRustExpr v93 v95 
    let _v94 = v96 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v97 : string = "String::from($0)"
    let v98 : std_string_String = Fable.Core.RustInterop.emitRustExpr v93 v97 
    let _v94 = v98 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v99 : string = "String::from($0)"
    let v100 : std_string_String = Fable.Core.RustInterop.emitRustExpr v93 v99 
    let _v94 = v100 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v101 : std_string_String = v93 |> unbox<std_string_String>
    let _v94 = v101 
    #endif
#if FABLE_COMPILER_PYTHON
    let v104 : std_string_String = v93 |> unbox<std_string_String>
    let _v94 = v104 
    #endif
#else
    let v107 : std_string_String = v93 |> unbox<std_string_String>
    let _v94 = v107 
    #endif
    let v110 : std_string_String = _v94 
    let v115 : string = "fable_library_rust::String_::fromString($0)"
    let v116 : string = Fable.Core.RustInterop.emitRustExpr v110 v115 
    let _v66 = v116 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v117 : string = "env!(\"" + v65 + "\")"
    let v118 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v117 
    let v119 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v120 : string = "String::from($0)"
    let v121 : std_string_String = Fable.Core.RustInterop.emitRustExpr v118 v120 
    let _v119 = v121 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v122 : string = "String::from($0)"
    let v123 : std_string_String = Fable.Core.RustInterop.emitRustExpr v118 v122 
    let _v119 = v123 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v124 : string = "String::from($0)"
    let v125 : std_string_String = Fable.Core.RustInterop.emitRustExpr v118 v124 
    let _v119 = v125 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v126 : std_string_String = v118 |> unbox<std_string_String>
    let _v119 = v126 
    #endif
#if FABLE_COMPILER_PYTHON
    let v129 : std_string_String = v118 |> unbox<std_string_String>
    let _v119 = v129 
    #endif
#else
    let v132 : std_string_String = v118 |> unbox<std_string_String>
    let _v119 = v132 
    #endif
    let v135 : std_string_String = _v119 
    let v140 : string = "fable_library_rust::String_::fromString($0)"
    let v141 : string = Fable.Core.RustInterop.emitRustExpr v135 v140 
    let _v66 = v141 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v142 : string = null |> unbox<string>
    let _v66 = v142 
    #endif
#if FABLE_COMPILER_PYTHON
    let v145 : string = null |> unbox<string>
    let _v66 = v145 
    #endif
#else
    let v148 : string = null |> unbox<string>
    let _v66 = v148 
    #endif
    let v151 : string = _v66 
    let v156 : string = "True"
    let v157 : bool = v151 <> v156 
    let v166 : US3 =
        if v157 then
            US3_1
        else
            let v161 : string = $"near_sdk::env::block_timestamp()"
            let v162 : uint64 = Fable.Core.RustInterop.emitRustExpr () v161 
            let v163 : (uint64 -> int64) = int64
            let v164 : int64 = v163 v162
            US3_0(v164)
    let v167 : US2 = US2_1
    let _v1 = struct (v167, v166) 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v168 : string = method1()
    let v169 : string = method2(v168)
    
    
    
    
    
    let v170 : bool = "Verbose" = v169
    let v174 : US2 =
        if v170 then
            let v171 : US0 = US0_0
            US2_0(v171)
        else
            US2_1
    let v215 : US2 =
        match v174 with
        | US2_1 -> (* None *)
            let v177 : bool = "Debug" = v169
            let v181 : US2 =
                if v177 then
                    let v178 : US0 = US0_1
                    US2_0(v178)
                else
                    US2_1
            match v181 with
            | US2_1 -> (* None *)
                let v184 : bool = "Info" = v169
                let v188 : US2 =
                    if v184 then
                        let v185 : US0 = US0_2
                        US2_0(v185)
                    else
                        US2_1
                match v188 with
                | US2_1 -> (* None *)
                    let v191 : bool = "Warning" = v169
                    let v195 : US2 =
                        if v191 then
                            let v192 : US0 = US0_3
                            US2_0(v192)
                        else
                            US2_1
                    match v195 with
                    | US2_1 -> (* None *)
                        let v198 : bool = "Critical" = v169
                        let v202 : US2 =
                            if v198 then
                                let v199 : US0 = US0_4
                                US2_0(v199)
                            else
                                US2_1
                        match v202 with
                        | US2_1 -> (* None *)
                            US2_1
                        | US2_0(v203) -> (* Some *)
                            US2_0(v203)
                    | US2_0(v196) -> (* Some *)
                        US2_0(v196)
                | US2_0(v189) -> (* Some *)
                    US2_0(v189)
            | US2_0(v182) -> (* Some *)
                US2_0(v182)
        | US2_0(v175) -> (* Some *)
            US2_0(v175)
    let v216 : string = method5()
    let v217 : string = method2(v216)
    let v218 : bool = v217 = "True"
    let v228 : US3 =
        if v218 then
            let v219 : System.DateTime = System.DateTime.Now
            let v222 : (System.DateTime -> int64) = _.Ticks
            let v223 : int64 = v222 v219
            US3_0(v223)
        else
            US3_1
    let _v1 = struct (v215, v228) 
    #endif
#if FABLE_COMPILER_PYTHON
    let v229 : string = method1()
    let v230 : string = method2(v229)
    
    
    
    
    
    let v231 : bool = "Verbose" = v230
    let v235 : US2 =
        if v231 then
            let v232 : US0 = US0_0
            US2_0(v232)
        else
            US2_1
    let v276 : US2 =
        match v235 with
        | US2_1 -> (* None *)
            let v238 : bool = "Debug" = v230
            let v242 : US2 =
                if v238 then
                    let v239 : US0 = US0_1
                    US2_0(v239)
                else
                    US2_1
            match v242 with
            | US2_1 -> (* None *)
                let v245 : bool = "Info" = v230
                let v249 : US2 =
                    if v245 then
                        let v246 : US0 = US0_2
                        US2_0(v246)
                    else
                        US2_1
                match v249 with
                | US2_1 -> (* None *)
                    let v252 : bool = "Warning" = v230
                    let v256 : US2 =
                        if v252 then
                            let v253 : US0 = US0_3
                            US2_0(v253)
                        else
                            US2_1
                    match v256 with
                    | US2_1 -> (* None *)
                        let v259 : bool = "Critical" = v230
                        let v263 : US2 =
                            if v259 then
                                let v260 : US0 = US0_4
                                US2_0(v260)
                            else
                                US2_1
                        match v263 with
                        | US2_1 -> (* None *)
                            US2_1
                        | US2_0(v264) -> (* Some *)
                            US2_0(v264)
                    | US2_0(v257) -> (* Some *)
                        US2_0(v257)
                | US2_0(v250) -> (* Some *)
                    US2_0(v250)
            | US2_0(v243) -> (* Some *)
                US2_0(v243)
        | US2_0(v236) -> (* Some *)
            US2_0(v236)
    let v277 : string = method5()
    let v278 : string = method2(v277)
    let v279 : bool = v278 = "True"
    let v289 : US3 =
        if v279 then
            let v280 : System.DateTime = System.DateTime.Now
            let v283 : (System.DateTime -> int64) = _.Ticks
            let v284 : int64 = v283 v280
            US3_0(v284)
        else
            US3_1
    let _v1 = struct (v276, v289) 
    #endif
#else
    let v290 : string = method1()
    let v291 : string = method2(v290)
    
    
    
    
    
    let v292 : bool = "Verbose" = v291
    let v296 : US2 =
        if v292 then
            let v293 : US0 = US0_0
            US2_0(v293)
        else
            US2_1
    let v337 : US2 =
        match v296 with
        | US2_1 -> (* None *)
            let v299 : bool = "Debug" = v291
            let v303 : US2 =
                if v299 then
                    let v300 : US0 = US0_1
                    US2_0(v300)
                else
                    US2_1
            match v303 with
            | US2_1 -> (* None *)
                let v306 : bool = "Info" = v291
                let v310 : US2 =
                    if v306 then
                        let v307 : US0 = US0_2
                        US2_0(v307)
                    else
                        US2_1
                match v310 with
                | US2_1 -> (* None *)
                    let v313 : bool = "Warning" = v291
                    let v317 : US2 =
                        if v313 then
                            let v314 : US0 = US0_3
                            US2_0(v314)
                        else
                            US2_1
                    match v317 with
                    | US2_1 -> (* None *)
                        let v320 : bool = "Critical" = v291
                        let v324 : US2 =
                            if v320 then
                                let v321 : US0 = US0_4
                                US2_0(v321)
                            else
                                US2_1
                        match v324 with
                        | US2_1 -> (* None *)
                            US2_1
                        | US2_0(v325) -> (* Some *)
                            US2_0(v325)
                    | US2_0(v318) -> (* Some *)
                        US2_0(v318)
                | US2_0(v311) -> (* Some *)
                    US2_0(v311)
            | US2_0(v304) -> (* Some *)
                US2_0(v304)
        | US2_0(v297) -> (* Some *)
            US2_0(v297)
    let v338 : string = method5()
    let v339 : string = method2(v338)
    let v340 : bool = v339 = "True"
    let v350 : US3 =
        if v340 then
            let v341 : System.DateTime = System.DateTime.Now
            let v344 : (System.DateTime -> int64) = _.Ticks
            let v345 : int64 = v344 v341
            US3_0(v345)
        else
            US3_1
    let _v1 = struct (v337, v350) 
    #endif
    let struct (v351 : US2, v352 : US3) = _v1 
    let v416 : Mut0 = {l0 = 1L} : Mut0
    let v417 : (string -> unit) = closure2()
    let v418 : Mut1 = {l0 = v417} : Mut1
    let v419 : Mut2 = {l0 = true} : Mut2
    let v420 : string = ""
    let v421 : Mut3 = {l0 = v420} : Mut3
    let v424 : US0 =
        match v351 with
        | US2_1 -> (* None *)
            v0
        | US2_0(v422) -> (* Some *)
            v422
    let v425 : Mut4 = {l0 = v424} : Mut4
    let v432 : int64 option =
        match v352 with
        | US3_1 -> (* None *)
            let v430 : int64 option = None
            v430
        | US3_0(v426) -> (* Some *)
            let v427 : int64 option = Some v426 
            v427
    struct (v416, v418, v419, v421, v425, v432)
and closure0 () () : unit =
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
    
    
    
    
    
    let v0 : string = "Verbose"
    let v1 : (unit -> string) = v0.ToLower
    let v2 : string = v1 ()
    let v5 : string = v2.PadLeft (7, ' ')
    let v19 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v20 : string = "inline_colorization::color_bright_black"
    let v21 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v20 
    let v22 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v23 : string = "&*$0"
    let v24 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v23 
    let _v22 = v24 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v25 : string = "&*$0"
    let v26 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v25 
    let _v22 = v26 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v27 : string = "&*$0"
    let v28 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v27 
    let _v22 = v28 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v29 : Ref<Str> = v5 |> unbox<Ref<Str>>
    let _v22 = v29 
    #endif
#if FABLE_COMPILER_PYTHON
    let v32 : Ref<Str> = v5 |> unbox<Ref<Str>>
    let _v22 = v32 
    #endif
#else
    let v35 : Ref<Str> = v5 |> unbox<Ref<Str>>
    let _v22 = v35 
    #endif
    let v38 : Ref<Str> = _v22 
    let v43 : string = "inline_colorization::color_reset"
    let v44 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v43 
    let v45 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v46 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v21, v38, v44) v45 
    let v47 : string = "fable_library_rust::String_::fromString($0)"
    let v48 : string = Fable.Core.RustInterop.emitRustExpr v46 v47 
    let _v19 = v48 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v49 : string = "inline_colorization::color_bright_black"
    let v50 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v49 
    let v51 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v52 : string = "&*$0"
    let v53 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v52 
    let _v51 = v53 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v54 : string = "&*$0"
    let v55 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v54 
    let _v51 = v55 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v56 : string = "&*$0"
    let v57 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v56 
    let _v51 = v57 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v58 : Ref<Str> = v5 |> unbox<Ref<Str>>
    let _v51 = v58 
    #endif
#if FABLE_COMPILER_PYTHON
    let v61 : Ref<Str> = v5 |> unbox<Ref<Str>>
    let _v51 = v61 
    #endif
#else
    let v64 : Ref<Str> = v5 |> unbox<Ref<Str>>
    let _v51 = v64 
    #endif
    let v67 : Ref<Str> = _v51 
    let v72 : string = "inline_colorization::color_reset"
    let v73 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v72 
    let v74 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v75 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v50, v67, v73) v74 
    let v76 : string = "fable_library_rust::String_::fromString($0)"
    let v77 : string = Fable.Core.RustInterop.emitRustExpr v75 v76 
    let _v19 = v77 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v78 : string = "inline_colorization::color_bright_black"
    let v79 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v78 
    let v80 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v81 : string = "&*$0"
    let v82 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v81 
    let _v80 = v82 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v83 : string = "&*$0"
    let v84 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v83 
    let _v80 = v84 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v85 : string = "&*$0"
    let v86 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v85 
    let _v80 = v86 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v87 : Ref<Str> = v5 |> unbox<Ref<Str>>
    let _v80 = v87 
    #endif
#if FABLE_COMPILER_PYTHON
    let v90 : Ref<Str> = v5 |> unbox<Ref<Str>>
    let _v80 = v90 
    #endif
#else
    let v93 : Ref<Str> = v5 |> unbox<Ref<Str>>
    let _v80 = v93 
    #endif
    let v96 : Ref<Str> = _v80 
    let v101 : string = "inline_colorization::color_reset"
    let v102 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v101 
    let v103 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v104 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v79, v96, v102) v103 
    let v105 : string = "fable_library_rust::String_::fromString($0)"
    let v106 : string = Fable.Core.RustInterop.emitRustExpr v104 v105 
    let _v19 = v106 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v107 : string = "\u001b[90m"
    let v108 : string = method11()
    let v109 : string = v107 + v5 
    let v110 : string = v109 + v108 
    let _v19 = v110 
    #endif
#if FABLE_COMPILER_PYTHON
    let v111 : string = "\u001b[90m"
    let v112 : string = method11()
    let v113 : string = v111 + v5 
    let v114 : string = v113 + v112 
    let _v19 = v114 
    #endif
#else
    let v115 : string = "\u001b[90m"
    let v116 : string = method11()
    let v117 : string = v115 + v5 
    let v118 : string = v117 + v116 
    let _v19 = v118 
    #endif
    let v119 : string = _v19 
    v119
and method13 () : string =
    let v0 : string = ""
    v0
and closure7 (v0 : Mut3, v1 : string) () : unit =
    let v2 : string = v0.l0
    let v3 : string = v2 + v1 
    v0.l0 <- v3
    ()
and method12 (v0 : int32, v1 : string) : string =
    let v2 : string = method13()
    let v3 : Mut3 = {l0 = v2} : Mut3
    let v4 : string = "{ "
    let v5 : string = $"{v4}"
    let v8 : unit = ()
    let v9 : (unit -> unit) = closure7(v3, v5)
    let v10 : unit = (fun () -> v9 (); v8) ()
    let v13 : string = "port"
    let v14 : string = $"{v13}"
    let v17 : unit = ()
    let v18 : (unit -> unit) = closure7(v3, v14)
    let v19 : unit = (fun () -> v18 (); v17) ()
    let v22 : string = " = "
    let v23 : string = $"{v22}"
    let v26 : unit = ()
    let v27 : (unit -> unit) = closure7(v3, v23)
    let v28 : unit = (fun () -> v27 (); v26) ()
    let v31 : string = $"{v0}"
    let v34 : unit = ()
    let v35 : (unit -> unit) = closure7(v3, v31)
    let v36 : unit = (fun () -> v35 (); v34) ()
    let v39 : string = "; "
    let v40 : string = $"{v39}"
    let v43 : unit = ()
    let v44 : (unit -> unit) = closure7(v3, v40)
    let v45 : unit = (fun () -> v44 (); v43) ()
    let v48 : string = "ex"
    let v49 : string = $"{v48}"
    let v52 : unit = ()
    let v53 : (unit -> unit) = closure7(v3, v49)
    let v54 : unit = (fun () -> v53 (); v52) ()
    let v57 : string = $"{v22}"
    let v60 : unit = ()
    let v61 : (unit -> unit) = closure7(v3, v57)
    let v62 : unit = (fun () -> v61 (); v60) ()
    let v65 : string = $"{v1}"
    let v68 : unit = ()
    let v69 : (unit -> unit) = closure7(v3, v65)
    let v70 : unit = (fun () -> v69 (); v68) ()
    let v73 : string = " }"
    let v74 : string = $"{v73}"
    let v77 : unit = ()
    let v78 : (unit -> unit) = closure7(v3, v74)
    let v79 : unit = (fun () -> v78 (); v77) ()
    let v82 : string = v3.l0
    v82
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
    let v26 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v27 : string = "&*$0"
    let v28 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v25 v27 
    let _v26 = v28 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v29 : string = "&*$0"
    let v30 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v25 v29 
    let _v26 = v30 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v31 : string = "&*$0"
    let v32 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v25 v31 
    let _v26 = v32 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v33 : Ref<Str> = v25 |> unbox<Ref<Str>>
    let _v26 = v33 
    #endif
#if FABLE_COMPILER_PYTHON
    let v36 : Ref<Str> = v25 |> unbox<Ref<Str>>
    let _v26 = v36 
    #endif
#else
    let v39 : Ref<Str> = v25 |> unbox<Ref<Str>>
    let _v26 = v39 
    #endif
    let v42 : Ref<Str> = _v26 
    let v47 : string = $"$0.chars()"
    let v48 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v42 v47 
    let v49 : string = "$0"
    let v50 : _ = Fable.Core.RustInterop.emitRustExpr v48 v49 
    let v51 : string = "$0.collect::<Vec<_>>()"
    let v52 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v50 v51 
    let v53 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
    let v54 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v52 v53 
    let v55 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
    let v56 : bool = Fable.Core.RustInterop.emitRustExpr v54 v55 
    let v57 : string = "x"
    let v58 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v57 
    let v59 : string = "String::from_iter($0)"
    let v60 : std_string_String = Fable.Core.RustInterop.emitRustExpr v58 v59 
    let v61 : string = "true; $0 }).collect::<Vec<_>>()"
    let v62 : bool = Fable.Core.RustInterop.emitRustExpr v60 v61 
    let v63 : string = "_vec_map"
    let v64 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v63 
    let v65 : string = "$0.len()"
    let v66 : unativeint = Fable.Core.RustInterop.emitRustExpr v64 v65 
    let v67 : (unativeint -> int32) = int32
    let v68 : int32 = v67 v66
    let v69 : string = ""
    let v70 : bool = v0 <> v69 
    let v74 : bool =
        if v70 then
            let v73 : bool = v68 <= 1
            v73
        else
            false
    if v74 then
        v4.l0 <- v25
        ()
    else
        v4.l0 <- v69
        let v75 : string = "true; $0.into_iter().for_each(|x| { //"
        let v76 : bool = Fable.Core.RustInterop.emitRustExpr v64 v75 
        let v77 : string = "x"
        let v78 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v77 
        let v79 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
        let v80 : bool = Fable.Core.RustInterop.emitRustExpr v78 v79 
        let v81 : string = $"true"
        let v82 : bool = Fable.Core.RustInterop.emitRustExpr () v81 
        let v83 : string = "true; }); //"
        let v84 : bool = Fable.Core.RustInterop.emitRustExpr () v83 
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
    let v85 : (string -> unit) = v2.l0
    v85 v0
and closure5 (v0 : int32, v1 : string) () : unit =
    let v2 : unit = ()
    let v3 : (unit -> unit) = closure0()
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
            let v40 : bool = 0 >= v39
            v40
    if v41 then
        let v42 : unit = ()
        let v43 : unit = (fun () -> v3 (); v42) ()
        let struct (v57 : Mut0, v58 : Mut1, v59 : Mut2, v60 : Mut3, v61 : Mut4, v62 : int64 option) = TraceState.trace_state.Value
        let v75 : string = method6(v57, v58, v59, v60, v61, v62)
        let v76 : string = method10()
        let v77 : string = $"networking.test_port_open"
        let v78 : bool = v77 = ""
        let v83 : string =
            if v78 then
                let v79 : string = ""
                v79
            else
                let v80 : int64 = v57.l0
                let v81 : string = method12(v0, v1)
                method14(v75, v76, v77, v80, v81)
        let v84 : unit = ()
        let v85 : unit = (fun () -> v3 (); v84) ()
        let struct (v99 : Mut0, v100 : Mut1, v101 : Mut2, v102 : Mut3, v103 : Mut4, v104 : int64 option) = TraceState.trace_state.Value
        method15(v83, v99, v100, v101, v102, v103, v104)
and closure4 (v0 : string) (v1 : int32) : Async<bool> =
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
    let v73 : (unit -> unit) = closure5(v1, v67)
    let v74 : unit = (fun () -> v73 (); v72) ()
    return false 
    (*
    let v190 : bool = *)
    }
    |> fun x -> _v18 <- Some x
    let v191 : Async<bool> = match _v18 with Some x -> x | None -> failwith "async.new_async_unit / _v18=None"
    let _v2 = v191 
    #endif
    let v192 : Async<bool> = _v2 
    v192
and closure3 () (v0 : string) : (int32 -> Async<bool>) =
    closure4(v0)
and closure14 () (v0 : bool) : US5 =
    US5_0(v0)
and closure15 () (v0 : exn) : US5 =
    US5_1(v0)
and method16 (v0 : int32) : string =
    let v1 : string = method13()
    let v2 : Mut3 = {l0 = v1} : Mut3
    let v3 : string = "{ "
    let v4 : string = $"{v3}"
    let v7 : unit = ()
    let v8 : (unit -> unit) = closure7(v2, v4)
    let v9 : unit = (fun () -> v8 (); v7) ()
    let v12 : string = "timeout"
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
and closure16 (v0 : int32) () : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure0()
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
            let v39 : bool = 0 >= v38
            v39
    if v40 then
        let v41 : unit = ()
        let v42 : unit = (fun () -> v2 (); v41) ()
        let struct (v56 : Mut0, v57 : Mut1, v58 : Mut2, v59 : Mut3, v60 : Mut4, v61 : int64 option) = TraceState.trace_state.Value
        let v74 : string = method6(v56, v57, v58, v59, v60, v61)
        let v75 : string = method10()
        let v76 : string = "async.run_with_timeout_async"
        let v77 : bool = v76 = ""
        let v82 : string =
            if v77 then
                let v78 : string = ""
                v78
            else
                let v79 : int64 = v56.l0
                let v80 : string = method16(v0)
                method14(v74, v75, v76, v79, v80)
        let v83 : unit = ()
        let v84 : unit = (fun () -> v2 (); v83) ()
        let struct (v98 : Mut0, v99 : Mut1, v100 : Mut2, v101 : Mut3, v102 : Mut4, v103 : int64 option) = TraceState.trace_state.Value
        method15(v82, v98, v99, v100, v101, v102, v103)
and method17 () : string =
    
    
    
    
    
    let v0 : string = "Critical"
    let v1 : (unit -> string) = v0.ToLower
    let v2 : string = v1 ()
    let v5 : string = v2.PadLeft (7, ' ')
    let v19 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v20 : string = "inline_colorization::color_bright_red"
    let v21 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v20 
    let v22 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v23 : string = "&*$0"
    let v24 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v23 
    let _v22 = v24 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v25 : string = "&*$0"
    let v26 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v25 
    let _v22 = v26 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v27 : string = "&*$0"
    let v28 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v27 
    let _v22 = v28 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v29 : Ref<Str> = v5 |> unbox<Ref<Str>>
    let _v22 = v29 
    #endif
#if FABLE_COMPILER_PYTHON
    let v32 : Ref<Str> = v5 |> unbox<Ref<Str>>
    let _v22 = v32 
    #endif
#else
    let v35 : Ref<Str> = v5 |> unbox<Ref<Str>>
    let _v22 = v35 
    #endif
    let v38 : Ref<Str> = _v22 
    let v43 : string = "inline_colorization::color_reset"
    let v44 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v43 
    let v45 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v46 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v21, v38, v44) v45 
    let v47 : string = "fable_library_rust::String_::fromString($0)"
    let v48 : string = Fable.Core.RustInterop.emitRustExpr v46 v47 
    let _v19 = v48 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v49 : string = "inline_colorization::color_bright_red"
    let v50 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v49 
    let v51 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v52 : string = "&*$0"
    let v53 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v52 
    let _v51 = v53 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v54 : string = "&*$0"
    let v55 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v54 
    let _v51 = v55 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v56 : string = "&*$0"
    let v57 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v56 
    let _v51 = v57 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v58 : Ref<Str> = v5 |> unbox<Ref<Str>>
    let _v51 = v58 
    #endif
#if FABLE_COMPILER_PYTHON
    let v61 : Ref<Str> = v5 |> unbox<Ref<Str>>
    let _v51 = v61 
    #endif
#else
    let v64 : Ref<Str> = v5 |> unbox<Ref<Str>>
    let _v51 = v64 
    #endif
    let v67 : Ref<Str> = _v51 
    let v72 : string = "inline_colorization::color_reset"
    let v73 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v72 
    let v74 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v75 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v50, v67, v73) v74 
    let v76 : string = "fable_library_rust::String_::fromString($0)"
    let v77 : string = Fable.Core.RustInterop.emitRustExpr v75 v76 
    let _v19 = v77 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v78 : string = "inline_colorization::color_bright_red"
    let v79 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v78 
    let v80 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v81 : string = "&*$0"
    let v82 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v81 
    let _v80 = v82 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v83 : string = "&*$0"
    let v84 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v83 
    let _v80 = v84 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v85 : string = "&*$0"
    let v86 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v85 
    let _v80 = v86 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v87 : Ref<Str> = v5 |> unbox<Ref<Str>>
    let _v80 = v87 
    #endif
#if FABLE_COMPILER_PYTHON
    let v90 : Ref<Str> = v5 |> unbox<Ref<Str>>
    let _v80 = v90 
    #endif
#else
    let v93 : Ref<Str> = v5 |> unbox<Ref<Str>>
    let _v80 = v93 
    #endif
    let v96 : Ref<Str> = _v80 
    let v101 : string = "inline_colorization::color_reset"
    let v102 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v101 
    let v103 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v104 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v79, v96, v102) v103 
    let v105 : string = "fable_library_rust::String_::fromString($0)"
    let v106 : string = Fable.Core.RustInterop.emitRustExpr v104 v105 
    let _v19 = v106 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v107 : string = "\u001b[91m"
    let v108 : string = method11()
    let v109 : string = v107 + v5 
    let v110 : string = v109 + v108 
    let _v19 = v110 
    #endif
#if FABLE_COMPILER_PYTHON
    let v111 : string = "\u001b[91m"
    let v112 : string = method11()
    let v113 : string = v111 + v5 
    let v114 : string = v113 + v112 
    let _v19 = v114 
    #endif
#else
    let v115 : string = "\u001b[91m"
    let v116 : string = method11()
    let v117 : string = v115 + v5 
    let v118 : string = v117 + v116 
    let _v19 = v118 
    #endif
    let v119 : string = _v19 
    v119
and method18 (v0 : int32, v1 : string) : string =
    let v2 : string = method13()
    let v3 : Mut3 = {l0 = v2} : Mut3
    let v4 : string = "{ "
    let v5 : string = $"{v4}"
    let v8 : unit = ()
    let v9 : (unit -> unit) = closure7(v3, v5)
    let v10 : unit = (fun () -> v9 (); v8) ()
    let v13 : string = "timeout"
    let v14 : string = $"{v13}"
    let v17 : unit = ()
    let v18 : (unit -> unit) = closure7(v3, v14)
    let v19 : unit = (fun () -> v18 (); v17) ()
    let v22 : string = " = "
    let v23 : string = $"{v22}"
    let v26 : unit = ()
    let v27 : (unit -> unit) = closure7(v3, v23)
    let v28 : unit = (fun () -> v27 (); v26) ()
    let v31 : string = $"{v0}"
    let v34 : unit = ()
    let v35 : (unit -> unit) = closure7(v3, v31)
    let v36 : unit = (fun () -> v35 (); v34) ()
    let v39 : string = "; "
    let v40 : string = $"{v39}"
    let v43 : unit = ()
    let v44 : (unit -> unit) = closure7(v3, v40)
    let v45 : unit = (fun () -> v44 (); v43) ()
    let v48 : string = "ex"
    let v49 : string = $"{v48}"
    let v52 : unit = ()
    let v53 : (unit -> unit) = closure7(v3, v49)
    let v54 : unit = (fun () -> v53 (); v52) ()
    let v57 : string = $"{v22}"
    let v60 : unit = ()
    let v61 : (unit -> unit) = closure7(v3, v57)
    let v62 : unit = (fun () -> v61 (); v60) ()
    let v65 : string = $"{v1}"
    let v68 : unit = ()
    let v69 : (unit -> unit) = closure7(v3, v65)
    let v70 : unit = (fun () -> v69 (); v68) ()
    let v73 : string = " }"
    let v74 : string = $"{v73}"
    let v77 : unit = ()
    let v78 : (unit -> unit) = closure7(v3, v74)
    let v79 : unit = (fun () -> v78 (); v77) ()
    let v82 : string = v3.l0
    v82
and closure17 (v0 : int32, v1 : exn) () : unit =
    let v2 : unit = ()
    let v3 : (unit -> unit) = closure0()
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
            let v40 : bool = 4 >= v39
            v40
    if v41 then
        let v42 : unit = ()
        let v43 : unit = (fun () -> v3 (); v42) ()
        let struct (v57 : Mut0, v58 : Mut1, v59 : Mut2, v60 : Mut3, v61 : Mut4, v62 : int64 option) = TraceState.trace_state.Value
        let v75 : string = method6(v57, v58, v59, v60, v61, v62)
        let v76 : string = method17()
        let v77 : string = $"async.run_with_timeout_async**"
        let v78 : bool = v77 = ""
        let v105 : string =
            if v78 then
                let v79 : string = ""
                v79
            else
                let v80 : int64 = v57.l0
                let v81 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v82 : string = $"%A{v1}"
                let _v81 = v82 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v85 : string = $"%A{v1}"
                let _v81 = v85 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v88 : string = $"%A{v1}"
                let _v81 = v88 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v91 : string = $"%A{v1}"
                let _v81 = v91 
                #endif
#if FABLE_COMPILER_PYTHON
                let v94 : string = $"%A{v1}"
                let _v81 = v94 
                #endif
#else
                let v97 : string = $"{v1.GetType ()}: {v1.Message}"
                let _v81 = v97 
                #endif
                let v98 : string = _v81 
                let v103 : string = method18(v0, v98)
                method14(v75, v76, v77, v80, v103)
        let v106 : unit = ()
        let v107 : unit = (fun () -> v3 (); v106) ()
        let struct (v121 : Mut0, v122 : Mut1, v123 : Mut2, v124 : Mut3, v125 : Mut4, v126 : int64 option) = TraceState.trace_state.Value
        method15(v105, v121, v122, v123, v124, v125, v126)
and closure13 (v0 : int32, v1 : string) (v2 : int32) : Async<bool> =
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
    let v91 : (unit -> unit) = closure5(v2, v85)
    let v92 : unit = (fun () -> v91 (); v90) ()
    return false 
    (*
    let v208 : bool = *)
    }
    |> fun x -> _v36 <- Some x
    let v209 : Async<bool> = match _v36 with Some x -> x | None -> failwith "async.new_async_unit / _v36=None"
    let _v20 = v209 
    #endif
    let v210 : Async<bool> = _v20 
    let v215 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v216 : Async<US4> = null |> unbox<Async<US4>>
    let _v215 = v216 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v219 : Async<US4> = null |> unbox<Async<US4>>
    let _v215 = v219 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v222 : Async<US4> = null |> unbox<Async<US4>>
    let _v215 = v222 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v225 : Async<US4> = null |> unbox<Async<US4>>
    let _v215 = v225 
    #endif
#if FABLE_COMPILER_PYTHON
    let v228 : Async<US4> = null |> unbox<Async<US4>>
    let _v215 = v228 
    #endif
#else
    let v231 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v232 : Async<US4> = null |> unbox<Async<US4>>
    let _v231 = v232 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v235 : Async<US4> = null |> unbox<Async<US4>>
    let _v231 = v235 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v238 : Async<US4> = null |> unbox<Async<US4>>
    let _v231 = v238 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v241 : Async<US4> = null |> unbox<Async<US4>>
    let _v231 = v241 
    #endif
#if FABLE_COMPILER_PYTHON
    let v244 : Async<US4> = null |> unbox<Async<US4>>
    let _v231 = v244 
    #endif
#else
    let v247 : Async<US4> option = None
    let mutable _v247 = v247 
    async {
    let v248 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v249 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
    let _v248 = v249 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v252 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
    let _v248 = v252 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v255 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
    let _v248 = v255 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v258 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
    let _v248 = v258 
    #endif
#if FABLE_COMPILER_PYTHON
    let v261 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
    let _v248 = v261 
    #endif
#else
    let v264 : Async<Async<bool>> = Async.StartChild (v210, v0)
    let _v248 = v264 
    #endif
    let v265 : Async<Async<bool>> = _v248 
    let! v265 = v265 
    let v270 : Async<bool> = v265 
    let v271 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v272 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
    let _v271 = v272 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v275 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
    let _v271 = v275 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v278 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
    let _v271 = v278 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v281 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
    let _v271 = v281 
    #endif
#if FABLE_COMPILER_PYTHON
    let v284 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
    let _v271 = v284 
    #endif
#else
    let v287 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
    let v288 : Async<Choice<bool, exn>> = v287 v270
    let _v271 = v288 
    #endif
    let v289 : Async<Choice<bool, exn>> = _v271 
    let v294 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v295 : Async<US5> = null |> unbox<Async<US5>>
    let _v294 = v295 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v298 : Async<US5> = null |> unbox<Async<US5>>
    let _v294 = v298 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v301 : Async<US5> = null |> unbox<Async<US5>>
    let _v294 = v301 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v304 : Async<US5> = null |> unbox<Async<US5>>
    let _v294 = v304 
    #endif
#if FABLE_COMPILER_PYTHON
    let v307 : Async<US5> = null |> unbox<Async<US5>>
    let _v294 = v307 
    #endif
#else
    let v310 : Async<US5> option = None
    let mutable _v310 = v310 
    async {
    let! v289 = v289 
    let v311 : Choice<bool, exn> = v289 
    let v312 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v313 : US5 = null |> unbox<US5>
    let _v312 = v313 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v316 : US5 = null |> unbox<US5>
    let _v312 = v316 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v319 : US5 = null |> unbox<US5>
    let _v312 = v319 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v322 : US5 = null |> unbox<US5>
    let _v312 = v322 
    #endif
#if FABLE_COMPILER_PYTHON
    let v325 : US5 = null |> unbox<US5>
    let _v312 = v325 
    #endif
#else
    let v328 : (bool -> US5) = closure14()
    let v329 : (exn -> US5) = closure15()
    let v330 : US5 = match v311 with Choice1Of2 x -> v328 x | Choice2Of2 x -> v329 x
    let _v312 = v330 
    #endif
    let v331 : US5 = _v312 
    return v331 
    }
    |> fun x -> _v310 <- Some x
    let v336 : Async<US5> = match _v310 with Some x -> x | None -> failwith "async.new_async_unit / _v310=None"
    let _v294 = v336 
    #endif
    let v337 : Async<US5> = _v294 
    let v342 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v343 : Async<US6> = null |> unbox<Async<US6>>
    let _v342 = v343 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v346 : Async<US6> = null |> unbox<Async<US6>>
    let _v342 = v346 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v349 : Async<US6> = null |> unbox<Async<US6>>
    let _v342 = v349 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v352 : Async<US6> = null |> unbox<Async<US6>>
    let _v342 = v352 
    #endif
#if FABLE_COMPILER_PYTHON
    let v355 : Async<US6> = null |> unbox<Async<US6>>
    let _v342 = v355 
    #endif
#else
    let v358 : Async<US6> option = None
    let mutable _v358 = v358 
    async {
    let! v337 = v337 
    let v359 : US5 = v337 
    let v365 : US6 =
        match v359 with
        | US5_0(v360) -> (* C1of2 *)
            US6_0(v360)
        | US5_1(v362) -> (* C2of2 *)
            US6_1(v362)
    return v365 
    }
    |> fun x -> _v358 <- Some x
    let v366 : Async<US6> = match _v358 with Some x -> x | None -> failwith "async.new_async_unit / _v358=None"
    let _v342 = v366 
    #endif
    let v367 : Async<US6> = _v342 
    let v372 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v373 : Async<US4> = null |> unbox<Async<US4>>
    let _v372 = v373 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v376 : Async<US4> = null |> unbox<Async<US4>>
    let _v372 = v376 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v379 : Async<US4> = null |> unbox<Async<US4>>
    let _v372 = v379 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v382 : Async<US4> = null |> unbox<Async<US4>>
    let _v372 = v382 
    #endif
#if FABLE_COMPILER_PYTHON
    let v385 : Async<US4> = null |> unbox<Async<US4>>
    let _v372 = v385 
    #endif
#else
    let v388 : Async<US4> option = None
    let mutable _v388 = v388 
    async {
    let! v367 = v367 
    let v389 : US6 = v367 
    let v662 : US4 =
        match v389 with
        | US6_1(v392) -> (* Error *)
            let v393 : string = $"%A{v392}"
            let v396 : string = "System.TimeoutException"
            let v397 : bool = v393.Contains v396 
            if v397 then
                let v400 : unit = ()
                let v401 : (unit -> unit) = closure16(v0)
                let v402 : unit = (fun () -> v401 (); v400) ()
                US4_1
            else
                let v519 : unit = ()
                let v520 : (unit -> unit) = closure17(v0, v392)
                let v521 : unit = (fun () -> v520 (); v519) ()
                US4_1
        | US6_0(v390) -> (* Ok *)
            US4_0(v390)
    return v662 
    }
    |> fun x -> _v388 <- Some x
    let v663 : Async<US4> = match _v388 with Some x -> x | None -> failwith "async.new_async_unit / _v388=None"
    let _v372 = v663 
    #endif
    let v664 : Async<US4> = _v372 
    return! v664 
    }
    |> fun x -> _v247 <- Some x
    let v669 : Async<US4> = match _v247 with Some x -> x | None -> failwith "async.new_async_unit / _v247=None"
    let _v231 = v669 
    #endif
    let v670 : Async<US4> = _v231 
    let _v215 = v670 
    #endif
    let v675 : Async<US4> = _v215 
    let! v675 = v675 
    let v680 : US4 = v675 
    let v683 : bool =
        match v680 with
        | US4_1 -> (* None *)
            false
        | US4_0(v681) -> (* Some *)
            v681
    return v683 
    }
    |> fun x -> _v19 <- Some x
    let v684 : Async<bool> = match _v19 with Some x -> x | None -> failwith "async.new_async_unit / _v19=None"
    let _v3 = v684 
    #endif
    let v685 : Async<bool> = _v3 
    v685
and closure12 (v0 : int32) (v1 : string) : (int32 -> Async<bool>) =
    closure13(v0, v1)
and closure11 () (v0 : int32) : (string -> (int32 -> Async<bool>)) =
    closure12(v0)
and closure22 () (v0 : int32) : US7 =
    US7_0(v0)
and method20 () : (int32 -> US7) =
    closure22()
and method21 (v0 : int32, v1 : int64, v2 : int32 option, v3 : bool) : string =
    let v4 : string = method13()
    let v5 : Mut3 = {l0 = v4} : Mut3
    let v6 : string = "{ "
    let v7 : string = $"{v6}"
    let v10 : unit = ()
    let v11 : (unit -> unit) = closure7(v5, v7)
    let v12 : unit = (fun () -> v11 (); v10) ()
    let v15 : string = "port"
    let v16 : string = $"{v15}"
    let v19 : unit = ()
    let v20 : (unit -> unit) = closure7(v5, v16)
    let v21 : unit = (fun () -> v20 (); v19) ()
    let v24 : string = " = "
    let v25 : string = $"{v24}"
    let v28 : unit = ()
    let v29 : (unit -> unit) = closure7(v5, v25)
    let v30 : unit = (fun () -> v29 (); v28) ()
    let v33 : string = $"{v0}"
    let v36 : unit = ()
    let v37 : (unit -> unit) = closure7(v5, v33)
    let v38 : unit = (fun () -> v37 (); v36) ()
    let v41 : string = "; "
    let v42 : string = $"{v41}"
    let v45 : unit = ()
    let v46 : (unit -> unit) = closure7(v5, v42)
    let v47 : unit = (fun () -> v46 (); v45) ()
    let v50 : string = "retry"
    let v51 : string = $"{v50}"
    let v54 : unit = ()
    let v55 : (unit -> unit) = closure7(v5, v51)
    let v56 : unit = (fun () -> v55 (); v54) ()
    let v59 : string = $"{v24}"
    let v62 : unit = ()
    let v63 : (unit -> unit) = closure7(v5, v59)
    let v64 : unit = (fun () -> v63 (); v62) ()
    let v67 : string = $"{v1}"
    let v70 : unit = ()
    let v71 : (unit -> unit) = closure7(v5, v67)
    let v72 : unit = (fun () -> v71 (); v70) ()
    let v75 : string = $"{v41}"
    let v78 : unit = ()
    let v79 : (unit -> unit) = closure7(v5, v75)
    let v80 : unit = (fun () -> v79 (); v78) ()
    let v83 : string = "timeout"
    let v84 : string = $"{v83}"
    let v87 : unit = ()
    let v88 : (unit -> unit) = closure7(v5, v84)
    let v89 : unit = (fun () -> v88 (); v87) ()
    let v92 : string = $"{v24}"
    let v95 : unit = ()
    let v96 : (unit -> unit) = closure7(v5, v92)
    let v97 : unit = (fun () -> v96 (); v95) ()
    let v100 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v101 : string = "format!(\"{:#?}\", $0)"
    let v102 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v101 
    let v103 : string = "fable_library_rust::String_::fromString($0)"
    let v104 : string = Fable.Core.RustInterop.emitRustExpr v102 v103 
    let _v100 = v104 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v105 : string = "format!(\"{:#?}\", $0)"
    let v106 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v105 
    let v107 : string = "fable_library_rust::String_::fromString($0)"
    let v108 : string = Fable.Core.RustInterop.emitRustExpr v106 v107 
    let _v100 = v108 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v109 : string = "format!(\"{:#?}\", $0)"
    let v110 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v109 
    let v111 : string = "fable_library_rust::String_::fromString($0)"
    let v112 : string = Fable.Core.RustInterop.emitRustExpr v110 v111 
    let _v100 = v112 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v113 : string = $"%A{v2}"
    let _v100 = v113 
    #endif
#if FABLE_COMPILER_PYTHON
    let v116 : string = $"%A{v2}"
    let _v100 = v116 
    #endif
#else
    let v119 : string = $"%A{v2}"
    let _v100 = v119 
    #endif
    let v122 : string = _v100 
    let v127 : string = $"{v122}"
    let v130 : unit = ()
    let v131 : (unit -> unit) = closure7(v5, v127)
    let v132 : unit = (fun () -> v131 (); v130) ()
    let v135 : string = $"{v41}"
    let v138 : unit = ()
    let v139 : (unit -> unit) = closure7(v5, v135)
    let v140 : unit = (fun () -> v139 (); v138) ()
    let v143 : string = "status"
    let v144 : string = $"{v143}"
    let v147 : unit = ()
    let v148 : (unit -> unit) = closure7(v5, v144)
    let v149 : unit = (fun () -> v148 (); v147) ()
    let v152 : string = $"{v24}"
    let v155 : unit = ()
    let v156 : (unit -> unit) = closure7(v5, v152)
    let v157 : unit = (fun () -> v156 (); v155) ()
    let v162 : string =
        if v3 then
            let v160 : string = "true"
            v160
        else
            let v161 : string = "false"
            v161
    let v163 : string = $"{v162}"
    let v166 : unit = ()
    let v167 : (unit -> unit) = closure7(v5, v163)
    let v168 : unit = (fun () -> v167 (); v166) ()
    let v171 : string = " }"
    let v172 : string = $"{v171}"
    let v175 : unit = ()
    let v176 : (unit -> unit) = closure7(v5, v172)
    let v177 : unit = (fun () -> v176 (); v175) ()
    let v180 : string = v5.l0
    v180
and method22 (v0 : string, v1 : string, v2 : int64, v3 : string) : string =
    let v4 : string = "networking.wait_for_port_access"
    let v5 : string = $"{v0} {v1} #{v2} %s{v4} / {v3}"
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
and closure23 (v0 : int32 option, v1 : bool, v2 : int32, v3 : int64) () : unit =
    let v4 : unit = ()
    let v5 : (unit -> unit) = closure0()
    let v6 : unit = (fun () -> v5 (); v4) ()
    let struct (v20 : Mut0, v21 : Mut1, v22 : Mut2, v23 : Mut3, v24 : Mut4, v25 : int64 option) = TraceState.trace_state.Value
    let v38 : US0 = v24.l0
    let v39 : bool = v22.l0
    let v40 : bool = v39 = false
    let v43 : bool =
        if v40 then
            false
        else
            let v41 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v38
            let v42 : bool = 0 >= v41
            v42
    if v43 then
        let v44 : unit = ()
        let v45 : unit = (fun () -> v5 (); v44) ()
        let struct (v59 : Mut0, v60 : Mut1, v61 : Mut2, v62 : Mut3, v63 : Mut4, v64 : int64 option) = TraceState.trace_state.Value
        let v77 : string = method6(v59, v60, v61, v62, v63, v64)
        let v78 : string = method10()
        let v79 : int64 = v59.l0
        let v80 : string = method21(v2, v3, v0, v1)
        let v81 : string = method22(v77, v78, v79, v80)
        let v82 : unit = ()
        let v83 : unit = (fun () -> v5 (); v82) ()
        let struct (v97 : Mut0, v98 : Mut1, v99 : Mut2, v100 : Mut3, v101 : Mut4, v102 : int64 option) = TraceState.trace_state.Value
        method15(v81, v97, v98, v99, v100, v101, v102)
and method19 (v0 : int32 option, v1 : bool, v2 : string, v3 : int32, v4 : int64) : Async<int64> =
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
    let v22 : (int32 -> US7) = method20()
    let v23 : US7 option = v0 |> Option.map v22 
    let v34 : US7 = US7_1
    let v35 : US7 = v23 |> Option.defaultValue v34 
    let v923 : Async<bool> =
        match v35 with
        | US7_1 -> (* None *)
            let v39 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v40 : Async<bool> = null |> unbox<Async<bool>>
            let _v39 = v40 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v43 : Async<bool> = null |> unbox<Async<bool>>
            let _v39 = v43 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v46 : Async<bool> = null |> unbox<Async<bool>>
            let _v39 = v46 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v49 : Async<bool> = null |> unbox<Async<bool>>
            let _v39 = v49 
            #endif
#if FABLE_COMPILER_PYTHON
            let v52 : Async<bool> = null |> unbox<Async<bool>>
            let _v39 = v52 
            #endif
#else
            let v55 : Async<bool> option = None
            let mutable _v55 = v55 
            async {
            let v56 : Async<System.Threading.CancellationToken> = Async.CancellationToken
            let! v56 = v56 
            let v57 : System.Threading.CancellationToken = v56 
            let v58 : System.Net.Sockets.TcpClient = new System.Net.Sockets.TcpClient ()
            use v58 = v58 
            let v59 : System.Net.Sockets.TcpClient = v58 
            try
            let v60 : System.Threading.Tasks.ValueTask = v59.ConnectAsync (v2, v3, v57)
            let v61 : (unit -> System.Threading.Tasks.Task) = v60.AsTask
            let v62 : System.Threading.Tasks.Task = v61 ()
            let v63 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v64 : Async<unit> = null |> unbox<Async<unit>>
            let _v63 = v64 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v67 : Async<unit> = null |> unbox<Async<unit>>
            let _v63 = v67 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v70 : Async<unit> = null |> unbox<Async<unit>>
            let _v63 = v70 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v73 : Async<unit> = null |> unbox<Async<unit>>
            let _v63 = v73 
            #endif
#if FABLE_COMPILER_PYTHON
            let v76 : Async<unit> = null |> unbox<Async<unit>>
            let _v63 = v76 
            #endif
#else
            let v79 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
            let v80 : Async<unit> = v79 v62
            let _v63 = v80 
            #endif
            let v81 : Async<unit> = _v63 
            do! v81 
            return true 
            with ex ->
            let v86 : exn = ex
            let v87 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v88 : string = $"%A{v86}"
            let _v87 = v88 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v91 : string = $"%A{v86}"
            let _v87 = v91 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v94 : string = $"%A{v86}"
            let _v87 = v94 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v97 : string = $"%A{v86}"
            let _v87 = v97 
            #endif
#if FABLE_COMPILER_PYTHON
            let v100 : string = $"%A{v86}"
            let _v87 = v100 
            #endif
#else
            let v103 : string = $"{v86.GetType ()}: {v86.Message}"
            let _v87 = v103 
            #endif
            let v104 : string = _v87 
            let v109 : unit = ()
            let v110 : (unit -> unit) = closure5(v3, v104)
            let v111 : unit = (fun () -> v110 (); v109) ()
            return false 
            (*
            let v227 : bool = *)
            }
            |> fun x -> _v55 <- Some x
            let v228 : Async<bool> = match _v55 with Some x -> x | None -> failwith "async.new_async_unit / _v55=None"
            let _v39 = v228 
            #endif
            let v229 : Async<bool> = _v39 
            v229
        | US7_0(v234) -> (* Some *)
            let v235 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v236 : Async<bool> = null |> unbox<Async<bool>>
            let _v235 = v236 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v239 : Async<bool> = null |> unbox<Async<bool>>
            let _v235 = v239 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v242 : Async<bool> = null |> unbox<Async<bool>>
            let _v235 = v242 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v245 : Async<bool> = null |> unbox<Async<bool>>
            let _v235 = v245 
            #endif
#if FABLE_COMPILER_PYTHON
            let v248 : Async<bool> = null |> unbox<Async<bool>>
            let _v235 = v248 
            #endif
#else
            let v251 : Async<bool> option = None
            let mutable _v251 = v251 
            async {
            let v252 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v253 : Async<bool> = null |> unbox<Async<bool>>
            let _v252 = v253 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v256 : Async<bool> = null |> unbox<Async<bool>>
            let _v252 = v256 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v259 : Async<bool> = null |> unbox<Async<bool>>
            let _v252 = v259 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v262 : Async<bool> = null |> unbox<Async<bool>>
            let _v252 = v262 
            #endif
#if FABLE_COMPILER_PYTHON
            let v265 : Async<bool> = null |> unbox<Async<bool>>
            let _v252 = v265 
            #endif
#else
            let v268 : Async<bool> option = None
            let mutable _v268 = v268 
            async {
            let v269 : Async<System.Threading.CancellationToken> = Async.CancellationToken
            let! v269 = v269 
            let v270 : System.Threading.CancellationToken = v269 
            let v271 : System.Net.Sockets.TcpClient = new System.Net.Sockets.TcpClient ()
            use v271 = v271 
            let v272 : System.Net.Sockets.TcpClient = v271 
            try
            let v273 : System.Threading.Tasks.ValueTask = v272.ConnectAsync (v2, v3, v270)
            let v274 : (unit -> System.Threading.Tasks.Task) = v273.AsTask
            let v275 : System.Threading.Tasks.Task = v274 ()
            let v276 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v277 : Async<unit> = null |> unbox<Async<unit>>
            let _v276 = v277 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v280 : Async<unit> = null |> unbox<Async<unit>>
            let _v276 = v280 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v283 : Async<unit> = null |> unbox<Async<unit>>
            let _v276 = v283 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v286 : Async<unit> = null |> unbox<Async<unit>>
            let _v276 = v286 
            #endif
#if FABLE_COMPILER_PYTHON
            let v289 : Async<unit> = null |> unbox<Async<unit>>
            let _v276 = v289 
            #endif
#else
            let v292 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
            let v293 : Async<unit> = v292 v275
            let _v276 = v293 
            #endif
            let v294 : Async<unit> = _v276 
            do! v294 
            return true 
            with ex ->
            let v299 : exn = ex
            let v300 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v301 : string = $"%A{v299}"
            let _v300 = v301 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v304 : string = $"%A{v299}"
            let _v300 = v304 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v307 : string = $"%A{v299}"
            let _v300 = v307 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v310 : string = $"%A{v299}"
            let _v300 = v310 
            #endif
#if FABLE_COMPILER_PYTHON
            let v313 : string = $"%A{v299}"
            let _v300 = v313 
            #endif
#else
            let v316 : string = $"{v299.GetType ()}: {v299.Message}"
            let _v300 = v316 
            #endif
            let v317 : string = _v300 
            let v322 : unit = ()
            let v323 : (unit -> unit) = closure5(v3, v317)
            let v324 : unit = (fun () -> v323 (); v322) ()
            return false 
            (*
            let v440 : bool = *)
            }
            |> fun x -> _v268 <- Some x
            let v441 : Async<bool> = match _v268 with Some x -> x | None -> failwith "async.new_async_unit / _v268=None"
            let _v252 = v441 
            #endif
            let v442 : Async<bool> = _v252 
            let v447 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v448 : Async<US4> = null |> unbox<Async<US4>>
            let _v447 = v448 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v451 : Async<US4> = null |> unbox<Async<US4>>
            let _v447 = v451 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v454 : Async<US4> = null |> unbox<Async<US4>>
            let _v447 = v454 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v457 : Async<US4> = null |> unbox<Async<US4>>
            let _v447 = v457 
            #endif
#if FABLE_COMPILER_PYTHON
            let v460 : Async<US4> = null |> unbox<Async<US4>>
            let _v447 = v460 
            #endif
#else
            let v463 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v464 : Async<US4> = null |> unbox<Async<US4>>
            let _v463 = v464 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v467 : Async<US4> = null |> unbox<Async<US4>>
            let _v463 = v467 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v470 : Async<US4> = null |> unbox<Async<US4>>
            let _v463 = v470 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v473 : Async<US4> = null |> unbox<Async<US4>>
            let _v463 = v473 
            #endif
#if FABLE_COMPILER_PYTHON
            let v476 : Async<US4> = null |> unbox<Async<US4>>
            let _v463 = v476 
            #endif
#else
            let v479 : Async<US4> option = None
            let mutable _v479 = v479 
            async {
            let v480 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v481 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v480 = v481 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v484 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v480 = v484 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v487 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v480 = v487 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v490 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v480 = v490 
            #endif
#if FABLE_COMPILER_PYTHON
            let v493 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v480 = v493 
            #endif
#else
            let v496 : Async<Async<bool>> = Async.StartChild (v442, v234)
            let _v480 = v496 
            #endif
            let v497 : Async<Async<bool>> = _v480 
            let! v497 = v497 
            let v502 : Async<bool> = v497 
            let v503 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v504 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
            let _v503 = v504 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v507 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
            let _v503 = v507 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v510 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
            let _v503 = v510 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v513 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
            let _v503 = v513 
            #endif
#if FABLE_COMPILER_PYTHON
            let v516 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
            let _v503 = v516 
            #endif
#else
            let v519 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v520 : Async<Choice<bool, exn>> = v519 v502
            let _v503 = v520 
            #endif
            let v521 : Async<Choice<bool, exn>> = _v503 
            let v526 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v527 : Async<US5> = null |> unbox<Async<US5>>
            let _v526 = v527 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v530 : Async<US5> = null |> unbox<Async<US5>>
            let _v526 = v530 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v533 : Async<US5> = null |> unbox<Async<US5>>
            let _v526 = v533 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v536 : Async<US5> = null |> unbox<Async<US5>>
            let _v526 = v536 
            #endif
#if FABLE_COMPILER_PYTHON
            let v539 : Async<US5> = null |> unbox<Async<US5>>
            let _v526 = v539 
            #endif
#else
            let v542 : Async<US5> option = None
            let mutable _v542 = v542 
            async {
            let! v521 = v521 
            let v543 : Choice<bool, exn> = v521 
            let v544 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v545 : US5 = null |> unbox<US5>
            let _v544 = v545 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v548 : US5 = null |> unbox<US5>
            let _v544 = v548 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v551 : US5 = null |> unbox<US5>
            let _v544 = v551 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v554 : US5 = null |> unbox<US5>
            let _v544 = v554 
            #endif
#if FABLE_COMPILER_PYTHON
            let v557 : US5 = null |> unbox<US5>
            let _v544 = v557 
            #endif
#else
            let v560 : (bool -> US5) = closure14()
            let v561 : (exn -> US5) = closure15()
            let v562 : US5 = match v543 with Choice1Of2 x -> v560 x | Choice2Of2 x -> v561 x
            let _v544 = v562 
            #endif
            let v563 : US5 = _v544 
            return v563 
            }
            |> fun x -> _v542 <- Some x
            let v568 : Async<US5> = match _v542 with Some x -> x | None -> failwith "async.new_async_unit / _v542=None"
            let _v526 = v568 
            #endif
            let v569 : Async<US5> = _v526 
            let v574 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v575 : Async<US6> = null |> unbox<Async<US6>>
            let _v574 = v575 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v578 : Async<US6> = null |> unbox<Async<US6>>
            let _v574 = v578 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v581 : Async<US6> = null |> unbox<Async<US6>>
            let _v574 = v581 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v584 : Async<US6> = null |> unbox<Async<US6>>
            let _v574 = v584 
            #endif
#if FABLE_COMPILER_PYTHON
            let v587 : Async<US6> = null |> unbox<Async<US6>>
            let _v574 = v587 
            #endif
#else
            let v590 : Async<US6> option = None
            let mutable _v590 = v590 
            async {
            let! v569 = v569 
            let v591 : US5 = v569 
            let v597 : US6 =
                match v591 with
                | US5_0(v592) -> (* C1of2 *)
                    US6_0(v592)
                | US5_1(v594) -> (* C2of2 *)
                    US6_1(v594)
            return v597 
            }
            |> fun x -> _v590 <- Some x
            let v598 : Async<US6> = match _v590 with Some x -> x | None -> failwith "async.new_async_unit / _v590=None"
            let _v574 = v598 
            #endif
            let v599 : Async<US6> = _v574 
            let v604 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v605 : Async<US4> = null |> unbox<Async<US4>>
            let _v604 = v605 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v608 : Async<US4> = null |> unbox<Async<US4>>
            let _v604 = v608 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v611 : Async<US4> = null |> unbox<Async<US4>>
            let _v604 = v611 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v614 : Async<US4> = null |> unbox<Async<US4>>
            let _v604 = v614 
            #endif
#if FABLE_COMPILER_PYTHON
            let v617 : Async<US4> = null |> unbox<Async<US4>>
            let _v604 = v617 
            #endif
#else
            let v620 : Async<US4> option = None
            let mutable _v620 = v620 
            async {
            let! v599 = v599 
            let v621 : US6 = v599 
            let v894 : US4 =
                match v621 with
                | US6_1(v624) -> (* Error *)
                    let v625 : string = $"%A{v624}"
                    let v628 : string = "System.TimeoutException"
                    let v629 : bool = v625.Contains v628 
                    if v629 then
                        let v632 : unit = ()
                        let v633 : (unit -> unit) = closure16(v234)
                        let v634 : unit = (fun () -> v633 (); v632) ()
                        US4_1
                    else
                        let v751 : unit = ()
                        let v752 : (unit -> unit) = closure17(v234, v624)
                        let v753 : unit = (fun () -> v752 (); v751) ()
                        US4_1
                | US6_0(v622) -> (* Ok *)
                    US4_0(v622)
            return v894 
            }
            |> fun x -> _v620 <- Some x
            let v895 : Async<US4> = match _v620 with Some x -> x | None -> failwith "async.new_async_unit / _v620=None"
            let _v604 = v895 
            #endif
            let v896 : Async<US4> = _v604 
            return! v896 
            }
            |> fun x -> _v479 <- Some x
            let v901 : Async<US4> = match _v479 with Some x -> x | None -> failwith "async.new_async_unit / _v479=None"
            let _v463 = v901 
            #endif
            let v902 : Async<US4> = _v463 
            let _v447 = v902 
            #endif
            let v907 : Async<US4> = _v447 
            let! v907 = v907 
            let v912 : US4 = v907 
            let v915 : bool =
                match v912 with
                | US4_1 -> (* None *)
                    false
                | US4_0(v913) -> (* Some *)
                    v913
            return v915 
            }
            |> fun x -> _v251 <- Some x
            let v916 : Async<bool> = match _v251 with Some x -> x | None -> failwith "async.new_async_unit / _v251=None"
            let _v235 = v916 
            #endif
            let v917 : Async<bool> = _v235 
            v917
    let! v923 = v923 
    let v924 : bool = v923 
    let v925 : bool = v924 = v1
    if v925 then
        return v4 
        (*
        ()
    else
        *) else
        let v926 : int64 = v4 % 100L
        let v927 : bool = v926 = 0L
        if v927 then
            let v928 : unit = ()
            let v929 : (unit -> unit) = closure23(v0, v1, v3, v4)
            let v930 : unit = (fun () -> v929 (); v928) ()
            ()
        let v1042 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v1043 : Async<unit> = null |> unbox<Async<unit>>
        let _v1042 = v1043 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v1046 : Async<unit> = null |> unbox<Async<unit>>
        let _v1042 = v1046 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v1049 : Async<unit> = null |> unbox<Async<unit>>
        let _v1042 = v1049 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v1052 : Async<unit> = null |> unbox<Async<unit>>
        let _v1042 = v1052 
        #endif
#if FABLE_COMPILER_PYTHON
        let v1055 : Async<unit> = null |> unbox<Async<unit>>
        let _v1042 = v1055 
        #endif
#else
        let v1058 : (int32 -> Async<unit>) = Async.Sleep
        let v1059 : Async<unit> = v1058 10
        let _v1042 = v1059 
        #endif
        let v1060 : Async<unit> = _v1042 
        do! v1060 
        let v1065 : int64 = v4 + 1L
        let v1066 : Async<int64> = method19(v0, v1, v2, v3, v1065)
        return! v1066 
        (*
        ()
    *)
    }
    |> fun x -> _v21 <- Some x
    let v1067 : Async<int64> = match _v21 with Some x -> x | None -> failwith "async.new_async_unit / _v21=None"
    let _v5 = v1067 
    #endif
    let v1068 : Async<int64> = _v5 
    v1068
and closure21 (v0 : int32 option, v1 : bool, v2 : string) (v3 : int32) : Async<int64> =
    let v4 : int64 = 0L
    method19(v0, v1, v2, v3, v4)
and closure20 (v0 : int32 option, v1 : bool) (v2 : string) : (int32 -> Async<int64>) =
    closure21(v0, v1, v2)
and closure19 (v0 : int32 option) (v1 : bool) : (string -> (int32 -> Async<int64>)) =
    closure20(v0, v1)
and closure18 () (v0 : int32 option) : (bool -> (string -> (int32 -> Async<int64>))) =
    closure19(v0)
and method23 (v0 : int32 option, v1 : string, v2 : int32) : Async<int32> =
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
    let v20 : (int32 -> US7) = method20()
    let v21 : US7 option = v0 |> Option.map v20 
    let v32 : US7 = US7_1
    let v33 : US7 = v21 |> Option.defaultValue v32 
    let v921 : Async<bool> =
        match v33 with
        | US7_1 -> (* None *)
            let v37 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v38 : Async<bool> = null |> unbox<Async<bool>>
            let _v37 = v38 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v41 : Async<bool> = null |> unbox<Async<bool>>
            let _v37 = v41 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v44 : Async<bool> = null |> unbox<Async<bool>>
            let _v37 = v44 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v47 : Async<bool> = null |> unbox<Async<bool>>
            let _v37 = v47 
            #endif
#if FABLE_COMPILER_PYTHON
            let v50 : Async<bool> = null |> unbox<Async<bool>>
            let _v37 = v50 
            #endif
#else
            let v53 : Async<bool> option = None
            let mutable _v53 = v53 
            async {
            let v54 : Async<System.Threading.CancellationToken> = Async.CancellationToken
            let! v54 = v54 
            let v55 : System.Threading.CancellationToken = v54 
            let v56 : System.Net.Sockets.TcpClient = new System.Net.Sockets.TcpClient ()
            use v56 = v56 
            let v57 : System.Net.Sockets.TcpClient = v56 
            try
            let v58 : System.Threading.Tasks.ValueTask = v57.ConnectAsync (v1, v2, v55)
            let v59 : (unit -> System.Threading.Tasks.Task) = v58.AsTask
            let v60 : System.Threading.Tasks.Task = v59 ()
            let v61 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v62 : Async<unit> = null |> unbox<Async<unit>>
            let _v61 = v62 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v65 : Async<unit> = null |> unbox<Async<unit>>
            let _v61 = v65 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v68 : Async<unit> = null |> unbox<Async<unit>>
            let _v61 = v68 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v71 : Async<unit> = null |> unbox<Async<unit>>
            let _v61 = v71 
            #endif
#if FABLE_COMPILER_PYTHON
            let v74 : Async<unit> = null |> unbox<Async<unit>>
            let _v61 = v74 
            #endif
#else
            let v77 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
            let v78 : Async<unit> = v77 v60
            let _v61 = v78 
            #endif
            let v79 : Async<unit> = _v61 
            do! v79 
            return true 
            with ex ->
            let v84 : exn = ex
            let v85 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v86 : string = $"%A{v84}"
            let _v85 = v86 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v89 : string = $"%A{v84}"
            let _v85 = v89 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v92 : string = $"%A{v84}"
            let _v85 = v92 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v95 : string = $"%A{v84}"
            let _v85 = v95 
            #endif
#if FABLE_COMPILER_PYTHON
            let v98 : string = $"%A{v84}"
            let _v85 = v98 
            #endif
#else
            let v101 : string = $"{v84.GetType ()}: {v84.Message}"
            let _v85 = v101 
            #endif
            let v102 : string = _v85 
            let v107 : unit = ()
            let v108 : (unit -> unit) = closure5(v2, v102)
            let v109 : unit = (fun () -> v108 (); v107) ()
            return false 
            (*
            let v225 : bool = *)
            }
            |> fun x -> _v53 <- Some x
            let v226 : Async<bool> = match _v53 with Some x -> x | None -> failwith "async.new_async_unit / _v53=None"
            let _v37 = v226 
            #endif
            let v227 : Async<bool> = _v37 
            v227
        | US7_0(v232) -> (* Some *)
            let v233 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v234 : Async<bool> = null |> unbox<Async<bool>>
            let _v233 = v234 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v237 : Async<bool> = null |> unbox<Async<bool>>
            let _v233 = v237 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v240 : Async<bool> = null |> unbox<Async<bool>>
            let _v233 = v240 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v243 : Async<bool> = null |> unbox<Async<bool>>
            let _v233 = v243 
            #endif
#if FABLE_COMPILER_PYTHON
            let v246 : Async<bool> = null |> unbox<Async<bool>>
            let _v233 = v246 
            #endif
#else
            let v249 : Async<bool> option = None
            let mutable _v249 = v249 
            async {
            let v250 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v251 : Async<bool> = null |> unbox<Async<bool>>
            let _v250 = v251 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v254 : Async<bool> = null |> unbox<Async<bool>>
            let _v250 = v254 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v257 : Async<bool> = null |> unbox<Async<bool>>
            let _v250 = v257 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v260 : Async<bool> = null |> unbox<Async<bool>>
            let _v250 = v260 
            #endif
#if FABLE_COMPILER_PYTHON
            let v263 : Async<bool> = null |> unbox<Async<bool>>
            let _v250 = v263 
            #endif
#else
            let v266 : Async<bool> option = None
            let mutable _v266 = v266 
            async {
            let v267 : Async<System.Threading.CancellationToken> = Async.CancellationToken
            let! v267 = v267 
            let v268 : System.Threading.CancellationToken = v267 
            let v269 : System.Net.Sockets.TcpClient = new System.Net.Sockets.TcpClient ()
            use v269 = v269 
            let v270 : System.Net.Sockets.TcpClient = v269 
            try
            let v271 : System.Threading.Tasks.ValueTask = v270.ConnectAsync (v1, v2, v268)
            let v272 : (unit -> System.Threading.Tasks.Task) = v271.AsTask
            let v273 : System.Threading.Tasks.Task = v272 ()
            let v274 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v275 : Async<unit> = null |> unbox<Async<unit>>
            let _v274 = v275 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v278 : Async<unit> = null |> unbox<Async<unit>>
            let _v274 = v278 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v281 : Async<unit> = null |> unbox<Async<unit>>
            let _v274 = v281 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v284 : Async<unit> = null |> unbox<Async<unit>>
            let _v274 = v284 
            #endif
#if FABLE_COMPILER_PYTHON
            let v287 : Async<unit> = null |> unbox<Async<unit>>
            let _v274 = v287 
            #endif
#else
            let v290 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
            let v291 : Async<unit> = v290 v273
            let _v274 = v291 
            #endif
            let v292 : Async<unit> = _v274 
            do! v292 
            return true 
            with ex ->
            let v297 : exn = ex
            let v298 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v299 : string = $"%A{v297}"
            let _v298 = v299 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v302 : string = $"%A{v297}"
            let _v298 = v302 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v305 : string = $"%A{v297}"
            let _v298 = v305 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v308 : string = $"%A{v297}"
            let _v298 = v308 
            #endif
#if FABLE_COMPILER_PYTHON
            let v311 : string = $"%A{v297}"
            let _v298 = v311 
            #endif
#else
            let v314 : string = $"{v297.GetType ()}: {v297.Message}"
            let _v298 = v314 
            #endif
            let v315 : string = _v298 
            let v320 : unit = ()
            let v321 : (unit -> unit) = closure5(v2, v315)
            let v322 : unit = (fun () -> v321 (); v320) ()
            return false 
            (*
            let v438 : bool = *)
            }
            |> fun x -> _v266 <- Some x
            let v439 : Async<bool> = match _v266 with Some x -> x | None -> failwith "async.new_async_unit / _v266=None"
            let _v250 = v439 
            #endif
            let v440 : Async<bool> = _v250 
            let v445 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v446 : Async<US4> = null |> unbox<Async<US4>>
            let _v445 = v446 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v449 : Async<US4> = null |> unbox<Async<US4>>
            let _v445 = v449 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v452 : Async<US4> = null |> unbox<Async<US4>>
            let _v445 = v452 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v455 : Async<US4> = null |> unbox<Async<US4>>
            let _v445 = v455 
            #endif
#if FABLE_COMPILER_PYTHON
            let v458 : Async<US4> = null |> unbox<Async<US4>>
            let _v445 = v458 
            #endif
#else
            let v461 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v462 : Async<US4> = null |> unbox<Async<US4>>
            let _v461 = v462 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v465 : Async<US4> = null |> unbox<Async<US4>>
            let _v461 = v465 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v468 : Async<US4> = null |> unbox<Async<US4>>
            let _v461 = v468 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v471 : Async<US4> = null |> unbox<Async<US4>>
            let _v461 = v471 
            #endif
#if FABLE_COMPILER_PYTHON
            let v474 : Async<US4> = null |> unbox<Async<US4>>
            let _v461 = v474 
            #endif
#else
            let v477 : Async<US4> option = None
            let mutable _v477 = v477 
            async {
            let v478 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v479 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v478 = v479 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v482 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v478 = v482 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v485 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v478 = v485 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v488 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v478 = v488 
            #endif
#if FABLE_COMPILER_PYTHON
            let v491 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v478 = v491 
            #endif
#else
            let v494 : Async<Async<bool>> = Async.StartChild (v440, v232)
            let _v478 = v494 
            #endif
            let v495 : Async<Async<bool>> = _v478 
            let! v495 = v495 
            let v500 : Async<bool> = v495 
            let v501 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v502 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
            let _v501 = v502 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v505 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
            let _v501 = v505 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v508 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
            let _v501 = v508 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v511 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
            let _v501 = v511 
            #endif
#if FABLE_COMPILER_PYTHON
            let v514 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
            let _v501 = v514 
            #endif
#else
            let v517 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v518 : Async<Choice<bool, exn>> = v517 v500
            let _v501 = v518 
            #endif
            let v519 : Async<Choice<bool, exn>> = _v501 
            let v524 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v525 : Async<US5> = null |> unbox<Async<US5>>
            let _v524 = v525 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v528 : Async<US5> = null |> unbox<Async<US5>>
            let _v524 = v528 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v531 : Async<US5> = null |> unbox<Async<US5>>
            let _v524 = v531 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v534 : Async<US5> = null |> unbox<Async<US5>>
            let _v524 = v534 
            #endif
#if FABLE_COMPILER_PYTHON
            let v537 : Async<US5> = null |> unbox<Async<US5>>
            let _v524 = v537 
            #endif
#else
            let v540 : Async<US5> option = None
            let mutable _v540 = v540 
            async {
            let! v519 = v519 
            let v541 : Choice<bool, exn> = v519 
            let v542 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v543 : US5 = null |> unbox<US5>
            let _v542 = v543 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v546 : US5 = null |> unbox<US5>
            let _v542 = v546 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v549 : US5 = null |> unbox<US5>
            let _v542 = v549 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v552 : US5 = null |> unbox<US5>
            let _v542 = v552 
            #endif
#if FABLE_COMPILER_PYTHON
            let v555 : US5 = null |> unbox<US5>
            let _v542 = v555 
            #endif
#else
            let v558 : (bool -> US5) = closure14()
            let v559 : (exn -> US5) = closure15()
            let v560 : US5 = match v541 with Choice1Of2 x -> v558 x | Choice2Of2 x -> v559 x
            let _v542 = v560 
            #endif
            let v561 : US5 = _v542 
            return v561 
            }
            |> fun x -> _v540 <- Some x
            let v566 : Async<US5> = match _v540 with Some x -> x | None -> failwith "async.new_async_unit / _v540=None"
            let _v524 = v566 
            #endif
            let v567 : Async<US5> = _v524 
            let v572 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v573 : Async<US6> = null |> unbox<Async<US6>>
            let _v572 = v573 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v576 : Async<US6> = null |> unbox<Async<US6>>
            let _v572 = v576 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v579 : Async<US6> = null |> unbox<Async<US6>>
            let _v572 = v579 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v582 : Async<US6> = null |> unbox<Async<US6>>
            let _v572 = v582 
            #endif
#if FABLE_COMPILER_PYTHON
            let v585 : Async<US6> = null |> unbox<Async<US6>>
            let _v572 = v585 
            #endif
#else
            let v588 : Async<US6> option = None
            let mutable _v588 = v588 
            async {
            let! v567 = v567 
            let v589 : US5 = v567 
            let v595 : US6 =
                match v589 with
                | US5_0(v590) -> (* C1of2 *)
                    US6_0(v590)
                | US5_1(v592) -> (* C2of2 *)
                    US6_1(v592)
            return v595 
            }
            |> fun x -> _v588 <- Some x
            let v596 : Async<US6> = match _v588 with Some x -> x | None -> failwith "async.new_async_unit / _v588=None"
            let _v572 = v596 
            #endif
            let v597 : Async<US6> = _v572 
            let v602 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v603 : Async<US4> = null |> unbox<Async<US4>>
            let _v602 = v603 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v606 : Async<US4> = null |> unbox<Async<US4>>
            let _v602 = v606 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v609 : Async<US4> = null |> unbox<Async<US4>>
            let _v602 = v609 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v612 : Async<US4> = null |> unbox<Async<US4>>
            let _v602 = v612 
            #endif
#if FABLE_COMPILER_PYTHON
            let v615 : Async<US4> = null |> unbox<Async<US4>>
            let _v602 = v615 
            #endif
#else
            let v618 : Async<US4> option = None
            let mutable _v618 = v618 
            async {
            let! v597 = v597 
            let v619 : US6 = v597 
            let v892 : US4 =
                match v619 with
                | US6_1(v622) -> (* Error *)
                    let v623 : string = $"%A{v622}"
                    let v626 : string = "System.TimeoutException"
                    let v627 : bool = v623.Contains v626 
                    if v627 then
                        let v630 : unit = ()
                        let v631 : (unit -> unit) = closure16(v232)
                        let v632 : unit = (fun () -> v631 (); v630) ()
                        US4_1
                    else
                        let v749 : unit = ()
                        let v750 : (unit -> unit) = closure17(v232, v622)
                        let v751 : unit = (fun () -> v750 (); v749) ()
                        US4_1
                | US6_0(v620) -> (* Ok *)
                    US4_0(v620)
            return v892 
            }
            |> fun x -> _v618 <- Some x
            let v893 : Async<US4> = match _v618 with Some x -> x | None -> failwith "async.new_async_unit / _v618=None"
            let _v602 = v893 
            #endif
            let v894 : Async<US4> = _v602 
            return! v894 
            }
            |> fun x -> _v477 <- Some x
            let v899 : Async<US4> = match _v477 with Some x -> x | None -> failwith "async.new_async_unit / _v477=None"
            let _v461 = v899 
            #endif
            let v900 : Async<US4> = _v461 
            let _v445 = v900 
            #endif
            let v905 : Async<US4> = _v445 
            let! v905 = v905 
            let v910 : US4 = v905 
            let v913 : bool =
                match v910 with
                | US4_1 -> (* None *)
                    false
                | US4_0(v911) -> (* Some *)
                    v911
            return v913 
            }
            |> fun x -> _v249 <- Some x
            let v914 : Async<bool> = match _v249 with Some x -> x | None -> failwith "async.new_async_unit / _v249=None"
            let _v233 = v914 
            #endif
            let v915 : Async<bool> = _v233 
            v915
    let! v921 = v921 
    let v922 : bool = v921 
    let v923 : bool = v922 = false
    if v923 then
        return v2 
        (*
        ()
    else
        *) else
        let v924 : int32 = v2 + 1
        let v925 : Async<int32> = method23(v0, v1, v924)
        return! v925 
        (*
        ()
    *)
    }
    |> fun x -> _v19 <- Some x
    let v926 : Async<int32> = match _v19 with Some x -> x | None -> failwith "async.new_async_unit / _v19=None"
    let _v3 = v926 
    #endif
    let v927 : Async<int32> = _v3 
    v927
and closure26 (v0 : int32 option, v1 : string) (v2 : int32) : Async<int32> =
    method23(v0, v1, v2)
and closure25 (v0 : int32 option) (v1 : string) : (int32 -> Async<int32>) =
    closure26(v0, v1)
and closure24 () (v0 : int32 option) : (string -> (int32 -> Async<int32>)) =
    closure25(v0)
let v0 : unit = ()
let v1 : (unit -> unit) = closure0()
let v2 : unit = (fun () -> v1 (); v0) ()
let v16 : (string -> (int32 -> Async<bool>)) = closure3()
let test_port_open x = v16 x
let v17 : (int32 -> (string -> (int32 -> Async<bool>))) = closure11()
let test_port_open_timeout x = v17 x
let v18 : (int32 option -> (bool -> (string -> (int32 -> Async<int64>)))) = closure18()
let wait_for_port_access x = v18 x
let v19 : (int32 option -> (string -> (int32 -> Async<int32>))) = closure24()
let get_available_port x = v19 x
()
