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
and method6 (v0 : US0) : bool =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure0()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v17 : Mut0, v18 : Mut1, v19 : Mut2, v20 : Mut3, v21 : Mut4, v22 : int64 option) = TraceState.trace_state.Value
    let v35 : US0 = v21.l0
    let v36 : bool = v19.l0
    let v37 : bool = v36 = false
    if v37 then
        false
    else
        let v38 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v0
        let v39 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v35
        let v40 : bool = v38 >= v39
        v40
and closure6 () (v0 : int64) : US3 =
    US3_0(v0)
and method8 () : (int64 -> US3) =
    closure6()
and method9 () : string =
    let v0 : string = "hh:mm:ss"
    v0
and method10 () : string =
    let v0 : string = "HH:mm:ss"
    v0
and method7 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option) : string =
    let v6 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v7 : (int64 -> US3) = method8()
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
    let v61 : string = method9()
    let v64 : (string -> string) = v60.ToString
    let v65 : string = v64 v61
    let _v6 = v65 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v68 : (int64 -> US3) = method8()
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
    let v122 : string = method9()
    let v125 : (string -> string) = v121.ToString
    let v126 : string = v125 v122
    let _v6 = v126 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v129 : string = $"near_sdk::env::block_timestamp()"
    let v130 : uint64 = Fable.Core.RustInterop.emitRustExpr () v129 
    let v131 : (int64 -> US3) = method8()
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
    let v164 : (int64 -> US3) = method8()
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
    let v218 : string = method10()
    let v221 : (string -> string) = v217.ToString
    let v222 : string = v221 v218
    let _v6 = v222 
    #endif
#if FABLE_COMPILER_PYTHON
    let v225 : (int64 -> US3) = method8()
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
    let v279 : string = method10()
    let v282 : (string -> string) = v278.ToString
    let v283 : string = v282 v279
    let _v6 = v283 
    #endif
#else
    let v286 : (int64 -> US3) = method8()
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
    let v340 : string = method10()
    let v343 : (string -> string) = v339.ToString
    let v344 : string = v343 v340
    let _v6 = v344 
    #endif
    let v347 : string = _v6 
    v347
and method13 () : string =
    let v0 : string = ""
    v0
and closure7 (v0 : Mut3, v1 : string) () : unit =
    let v2 : string = v0.l0
    let v3 : string = v2 + v1 
    v0.l0 <- v3
    ()
and method12 (v0 : char) : string =
    let v1 : string = method13()
    let v2 : Mut3 = {l0 = v1} : Mut3
    let v3 : string = $"{v0}"
    let v6 : unit = ()
    let v7 : (unit -> unit) = closure7(v2, v3)
    let v8 : unit = (fun () -> v7 (); v6) ()
    let v11 : string = v2.l0
    v11
and method14 () : string =
    let v0 : string = "\u001b[0m"
    v0
and method11 () : string =
    
    
    
    
    
    let v0 : string = "Verbose"
    let v1 : (unit -> string) = v0.ToLower
    let v2 : string = v1 ()
    let v5 : char = v2.[int 0]
    let v6 : string = method12(v5)
    let v7 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v8 : string = "inline_colorization::color_bright_black"
    let v9 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v8 
    let v10 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v11 : string = "&*$0"
    let v12 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v11 
    let _v10 = v12 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v13 : string = "&*$0"
    let v14 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v13 
    let _v10 = v14 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v15 : string = "&*$0"
    let v16 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v15 
    let _v10 = v16 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v17 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v10 = v17 
    #endif
#if FABLE_COMPILER_PYTHON
    let v20 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v10 = v20 
    #endif
#else
    let v23 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v10 = v23 
    #endif
    let v26 : Ref<Str> = _v10 
    let v31 : string = "inline_colorization::color_reset"
    let v32 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v31 
    let v33 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v34 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v9, v26, v32) v33 
    let v35 : string = "fable_library_rust::String_::fromString($0)"
    let v36 : string = Fable.Core.RustInterop.emitRustExpr v34 v35 
    let _v7 = v36 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v37 : string = "inline_colorization::color_bright_black"
    let v38 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v37 
    let v39 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v40 : string = "&*$0"
    let v41 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v40 
    let _v39 = v41 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v42 : string = "&*$0"
    let v43 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v42 
    let _v39 = v43 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v44 : string = "&*$0"
    let v45 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v44 
    let _v39 = v45 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v46 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v39 = v46 
    #endif
#if FABLE_COMPILER_PYTHON
    let v49 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v39 = v49 
    #endif
#else
    let v52 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v39 = v52 
    #endif
    let v55 : Ref<Str> = _v39 
    let v60 : string = "inline_colorization::color_reset"
    let v61 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v60 
    let v62 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v63 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v38, v55, v61) v62 
    let v64 : string = "fable_library_rust::String_::fromString($0)"
    let v65 : string = Fable.Core.RustInterop.emitRustExpr v63 v64 
    let _v7 = v65 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v66 : string = "inline_colorization::color_bright_black"
    let v67 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v66 
    let v68 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v69 : string = "&*$0"
    let v70 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v69 
    let _v68 = v70 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v71 : string = "&*$0"
    let v72 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v71 
    let _v68 = v72 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v73 : string = "&*$0"
    let v74 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v73 
    let _v68 = v74 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v75 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v68 = v75 
    #endif
#if FABLE_COMPILER_PYTHON
    let v78 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v68 = v78 
    #endif
#else
    let v81 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v68 = v81 
    #endif
    let v84 : Ref<Str> = _v68 
    let v89 : string = "inline_colorization::color_reset"
    let v90 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v89 
    let v91 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v92 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v67, v84, v90) v91 
    let v93 : string = "fable_library_rust::String_::fromString($0)"
    let v94 : string = Fable.Core.RustInterop.emitRustExpr v92 v93 
    let _v7 = v94 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v95 : string = "\u001b[90m"
    let v96 : string = method14()
    let v97 : string = v95 + v6 
    let v98 : string = v97 + v96 
    let _v7 = v98 
    #endif
#if FABLE_COMPILER_PYTHON
    let v99 : string = "\u001b[90m"
    let v100 : string = method14()
    let v101 : string = v99 + v6 
    let v102 : string = v101 + v100 
    let _v7 = v102 
    #endif
#else
    let v103 : string = "\u001b[90m"
    let v104 : string = method14()
    let v105 : string = v103 + v6 
    let v106 : string = v105 + v104 
    let _v7 = v106 
    #endif
    let v107 : string = _v7 
    v107
and method16 (v0 : int32, v1 : string) : string =
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
and method17 (v0 : string) : string =
    let v1 : char list = []
    let v2 : (char list -> (char [])) = List.toArray
    let v3 : (char []) = v2 v1
    let v6 : string = v0.TrimStart v3 
    let v24 : char list = []
    let v25 : char list = '/' :: v24 
    let v28 : char list = ' ' :: v25 
    let v31 : (char list -> (char [])) = List.toArray
    let v32 : (char []) = v31 v28
    let v35 : string = v6.TrimEnd v32 
    v35
and method15 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : string, v9 : int32, v10 : string) : string =
    let v11 : string = method16(v9, v10)
    let v12 : int64 = v0.l0
    let v13 : string = $"{v6} {v7} #{v12} %s{v8} / {v11}"
    method17(v13)
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
and method18 (v0 : string) : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure0()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v17 : Mut0, v18 : Mut1, v19 : Mut2, v20 : Mut3, v21 : Mut4, v22 : int64 option) = TraceState.trace_state.Value
    let v35 : unit = ()
    let v36 : (unit -> unit) = closure8(v17)
    let v37 : unit = (fun () -> v36 (); v35) ()
    let v40 : (string -> unit) = closure9()
    let v41 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v42 : string = @"println!(""{}"", $0)"
    Fable.Core.RustInterop.emitRustExpr v0 v42 
    let _v41 = () 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v43 : string = @"println!(""{}"", $0)"
    Fable.Core.RustInterop.emitRustExpr v0 v43 
    let _v41 = () 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v44 : string = v20.l0
    let v45 : bool = v44 = ""
    let v53 : string =
        if v45 then
            v0
        else
            let v46 : bool = v0 = ""
            if v46 then
                let v47 : string = v20.l0
                v47
            else
                let v48 : string = v20.l0
                let v49 : string = "\n"
                let v50 : string = v48 + v49 
                let v51 : string = v50 + v0 
                v51
    let v54 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v55 : string = "&*$0"
    let v56 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v53 v55 
    let _v54 = v56 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v57 : string = "&*$0"
    let v58 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v53 v57 
    let _v54 = v58 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v59 : string = "&*$0"
    let v60 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v53 v59 
    let _v54 = v60 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v61 : Ref<Str> = v53 |> unbox<Ref<Str>>
    let _v54 = v61 
    #endif
#if FABLE_COMPILER_PYTHON
    let v64 : Ref<Str> = v53 |> unbox<Ref<Str>>
    let _v54 = v64 
    #endif
#else
    let v67 : Ref<Str> = v53 |> unbox<Ref<Str>>
    let _v54 = v67 
    #endif
    let v70 : Ref<Str> = _v54 
    let v75 : string = $"$0.chars()"
    let v76 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v70 v75 
    let v77 : string = "$0"
    let v78 : _ = Fable.Core.RustInterop.emitRustExpr v76 v77 
    let v79 : string = "$0.collect::<Vec<_>>()"
    let v80 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v78 v79 
    let v81 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
    let v82 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v80 v81 
    let v83 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
    let v84 : bool = Fable.Core.RustInterop.emitRustExpr v82 v83 
    let v85 : string = "x"
    let v86 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v85 
    let v87 : string = "String::from_iter($0)"
    let v88 : std_string_String = Fable.Core.RustInterop.emitRustExpr v86 v87 
    let v89 : string = "true; $0 }).collect::<Vec<_>>()"
    let v90 : bool = Fable.Core.RustInterop.emitRustExpr v88 v89 
    let v91 : string = "_vec_map"
    let v92 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v91 
    let v93 : string = "$0.len()"
    let v94 : unativeint = Fable.Core.RustInterop.emitRustExpr v92 v93 
    let v95 : (unativeint -> int32) = int32
    let v96 : int32 = v95 v94
    let v97 : string = ""
    let v98 : bool = v0 <> v97 
    let v102 : bool =
        if v98 then
            let v101 : bool = v96 <= 1
            v101
        else
            false
    if v102 then
        v20.l0 <- v53
        ()
    else
        v20.l0 <- v97
        let v103 : string = "true; $0.into_iter().for_each(|x| { //"
        let v104 : bool = Fable.Core.RustInterop.emitRustExpr v92 v103 
        let v105 : string = "x"
        let v106 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v105 
        let v107 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
        let v108 : bool = Fable.Core.RustInterop.emitRustExpr v106 v107 
        let v109 : string = $"true"
        let v110 : bool = Fable.Core.RustInterop.emitRustExpr () v109 
        let v111 : string = "true; }); //"
        let v112 : bool = Fable.Core.RustInterop.emitRustExpr () v111 
        ()
    let _v41 = () 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    v40 v0
    let _v41 = () 
    #endif
#if FABLE_COMPILER_PYTHON
    v40 v0
    let _v41 = () 
    #endif
#else
    v40 v0
    let _v41 = () 
    #endif
    _v41 
    let v113 : (string -> unit) = v18.l0
    v113 v0
and closure5 (v0 : int32, v1 : string) () : unit =
    let v2 : US0 = US0_0
    let v3 : bool = method6(v2)
    if v3 then
        let v4 : unit = ()
        let v5 : (unit -> unit) = closure0()
        let v6 : unit = (fun () -> v5 (); v4) ()
        let struct (v20 : Mut0, v21 : Mut1, v22 : Mut2, v23 : Mut3, v24 : Mut4, v25 : int64 option) = TraceState.trace_state.Value
        let v38 : string = method7(v20, v21, v22, v23, v24, v25)
        let v39 : string = method11()
        let v40 : string = $"networking.test_port_open"
        let v41 : bool = v40 = ""
        let v44 : string =
            if v41 then
                let v42 : string = ""
                v42
            else
                method15(v20, v21, v22, v23, v24, v25, v38, v39, v40, v0, v1)
        method18(v44)
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
    let v118 : bool = *)
    }
    |> fun x -> _v18 <- Some x
    let v119 : Async<bool> = match _v18 with Some x -> x | None -> failwith "async.new_async_unit / _v18=None"
    let _v2 = v119 
    #endif
    let v120 : Async<bool> = _v2 
    v120
and closure3 () (v0 : string) : (int32 -> Async<bool>) =
    closure4(v0)
and closure14 () (v0 : bool) : US5 =
    US5_0(v0)
and closure15 () (v0 : exn) : US5 =
    US5_1(v0)
and method20 (v0 : int32) : string =
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
and method19 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : string, v9 : int32) : string =
    let v10 : string = method20(v9)
    let v11 : int64 = v0.l0
    let v12 : string = $"{v6} {v7} #{v11} %s{v8} / {v10}"
    method17(v12)
and closure16 (v0 : int32) () : unit =
    let v1 : US0 = US0_0
    let v2 : bool = method6(v1)
    if v2 then
        let v3 : unit = ()
        let v4 : (unit -> unit) = closure0()
        let v5 : unit = (fun () -> v4 (); v3) ()
        let struct (v19 : Mut0, v20 : Mut1, v21 : Mut2, v22 : Mut3, v23 : Mut4, v24 : int64 option) = TraceState.trace_state.Value
        let v37 : string = method7(v19, v20, v21, v22, v23, v24)
        let v38 : string = method11()
        let v39 : string = "async.run_with_timeout_async"
        let v40 : bool = v39 = ""
        let v43 : string =
            if v40 then
                let v41 : string = ""
                v41
            else
                method19(v19, v20, v21, v22, v23, v24, v37, v38, v39, v0)
        method18(v43)
and method21 () : string =
    
    
    
    
    
    let v0 : string = "Critical"
    let v1 : (unit -> string) = v0.ToLower
    let v2 : string = v1 ()
    let v5 : char = v2.[int 0]
    let v6 : string = method12(v5)
    let v7 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v8 : string = "inline_colorization::color_bright_red"
    let v9 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v8 
    let v10 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v11 : string = "&*$0"
    let v12 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v11 
    let _v10 = v12 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v13 : string = "&*$0"
    let v14 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v13 
    let _v10 = v14 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v15 : string = "&*$0"
    let v16 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v15 
    let _v10 = v16 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v17 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v10 = v17 
    #endif
#if FABLE_COMPILER_PYTHON
    let v20 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v10 = v20 
    #endif
#else
    let v23 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v10 = v23 
    #endif
    let v26 : Ref<Str> = _v10 
    let v31 : string = "inline_colorization::color_reset"
    let v32 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v31 
    let v33 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v34 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v9, v26, v32) v33 
    let v35 : string = "fable_library_rust::String_::fromString($0)"
    let v36 : string = Fable.Core.RustInterop.emitRustExpr v34 v35 
    let _v7 = v36 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v37 : string = "inline_colorization::color_bright_red"
    let v38 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v37 
    let v39 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v40 : string = "&*$0"
    let v41 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v40 
    let _v39 = v41 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v42 : string = "&*$0"
    let v43 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v42 
    let _v39 = v43 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v44 : string = "&*$0"
    let v45 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v44 
    let _v39 = v45 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v46 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v39 = v46 
    #endif
#if FABLE_COMPILER_PYTHON
    let v49 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v39 = v49 
    #endif
#else
    let v52 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v39 = v52 
    #endif
    let v55 : Ref<Str> = _v39 
    let v60 : string = "inline_colorization::color_reset"
    let v61 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v60 
    let v62 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v63 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v38, v55, v61) v62 
    let v64 : string = "fable_library_rust::String_::fromString($0)"
    let v65 : string = Fable.Core.RustInterop.emitRustExpr v63 v64 
    let _v7 = v65 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v66 : string = "inline_colorization::color_bright_red"
    let v67 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v66 
    let v68 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v69 : string = "&*$0"
    let v70 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v69 
    let _v68 = v70 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v71 : string = "&*$0"
    let v72 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v71 
    let _v68 = v72 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v73 : string = "&*$0"
    let v74 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v73 
    let _v68 = v74 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v75 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v68 = v75 
    #endif
#if FABLE_COMPILER_PYTHON
    let v78 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v68 = v78 
    #endif
#else
    let v81 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v68 = v81 
    #endif
    let v84 : Ref<Str> = _v68 
    let v89 : string = "inline_colorization::color_reset"
    let v90 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v89 
    let v91 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v92 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v67, v84, v90) v91 
    let v93 : string = "fable_library_rust::String_::fromString($0)"
    let v94 : string = Fable.Core.RustInterop.emitRustExpr v92 v93 
    let _v7 = v94 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v95 : string = "\u001b[91m"
    let v96 : string = method14()
    let v97 : string = v95 + v6 
    let v98 : string = v97 + v96 
    let _v7 = v98 
    #endif
#if FABLE_COMPILER_PYTHON
    let v99 : string = "\u001b[91m"
    let v100 : string = method14()
    let v101 : string = v99 + v6 
    let v102 : string = v101 + v100 
    let _v7 = v102 
    #endif
#else
    let v103 : string = "\u001b[91m"
    let v104 : string = method14()
    let v105 : string = v103 + v6 
    let v106 : string = v105 + v104 
    let _v7 = v106 
    #endif
    let v107 : string = _v7 
    v107
and method23 (v0 : int32, v1 : string) : string =
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
and method22 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : string, v9 : int32, v10 : string) : string =
    let v11 : string = method23(v9, v10)
    let v12 : int64 = v0.l0
    let v13 : string = $"{v6} {v7} #{v12} %s{v8} / {v11}"
    method17(v13)
and closure17 (v0 : int32, v1 : exn) () : unit =
    let v2 : US0 = US0_4
    let v3 : bool = method6(v2)
    if v3 then
        let v4 : unit = ()
        let v5 : (unit -> unit) = closure0()
        let v6 : unit = (fun () -> v5 (); v4) ()
        let struct (v20 : Mut0, v21 : Mut1, v22 : Mut2, v23 : Mut3, v24 : Mut4, v25 : int64 option) = TraceState.trace_state.Value
        let v38 : string = method7(v20, v21, v22, v23, v24, v25)
        let v39 : string = method21()
        let v40 : string = $"async.run_with_timeout_async**"
        let v41 : bool = v40 = ""
        let v66 : string =
            if v41 then
                let v42 : string = ""
                v42
            else
                let v43 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v44 : string = $"%A{v1}"
                let _v43 = v44 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v47 : string = $"%A{v1}"
                let _v43 = v47 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v50 : string = $"%A{v1}"
                let _v43 = v50 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v53 : string = $"%A{v1}"
                let _v43 = v53 
                #endif
#if FABLE_COMPILER_PYTHON
                let v56 : string = $"%A{v1}"
                let _v43 = v56 
                #endif
#else
                let v59 : string = $"{v1.GetType ()}: {v1.Message}"
                let _v43 = v59 
                #endif
                let v60 : string = _v43 
                method22(v20, v21, v22, v23, v24, v25, v38, v39, v40, v0, v60)
        method18(v66)
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
    let v136 : bool = *)
    }
    |> fun x -> _v36 <- Some x
    let v137 : Async<bool> = match _v36 with Some x -> x | None -> failwith "async.new_async_unit / _v36=None"
    let _v20 = v137 
    #endif
    let v138 : Async<bool> = _v20 
    let v143 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v144 : Async<US4> = null |> unbox<Async<US4>>
    let _v143 = v144 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v147 : Async<US4> = null |> unbox<Async<US4>>
    let _v143 = v147 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v150 : Async<US4> = null |> unbox<Async<US4>>
    let _v143 = v150 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v153 : Async<US4> = null |> unbox<Async<US4>>
    let _v143 = v153 
    #endif
#if FABLE_COMPILER_PYTHON
    let v156 : Async<US4> = null |> unbox<Async<US4>>
    let _v143 = v156 
    #endif
#else
    let v159 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v160 : Async<US4> = null |> unbox<Async<US4>>
    let _v159 = v160 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v163 : Async<US4> = null |> unbox<Async<US4>>
    let _v159 = v163 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v166 : Async<US4> = null |> unbox<Async<US4>>
    let _v159 = v166 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v169 : Async<US4> = null |> unbox<Async<US4>>
    let _v159 = v169 
    #endif
#if FABLE_COMPILER_PYTHON
    let v172 : Async<US4> = null |> unbox<Async<US4>>
    let _v159 = v172 
    #endif
#else
    let v175 : Async<US4> option = None
    let mutable _v175 = v175 
    async {
    let v176 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v177 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
    let _v176 = v177 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v180 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
    let _v176 = v180 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v183 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
    let _v176 = v183 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v186 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
    let _v176 = v186 
    #endif
#if FABLE_COMPILER_PYTHON
    let v189 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
    let _v176 = v189 
    #endif
#else
    let v192 : Async<Async<bool>> = Async.StartChild (v138, v0)
    let _v176 = v192 
    #endif
    let v193 : Async<Async<bool>> = _v176 
    let! v193 = v193 
    let v198 : Async<bool> = v193 
    let v199 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v200 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
    let _v199 = v200 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v203 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
    let _v199 = v203 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v206 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
    let _v199 = v206 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v209 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
    let _v199 = v209 
    #endif
#if FABLE_COMPILER_PYTHON
    let v212 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
    let _v199 = v212 
    #endif
#else
    let v215 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
    let v216 : Async<Choice<bool, exn>> = v215 v198
    let _v199 = v216 
    #endif
    let v217 : Async<Choice<bool, exn>> = _v199 
    let v222 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v223 : Async<US5> = null |> unbox<Async<US5>>
    let _v222 = v223 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v226 : Async<US5> = null |> unbox<Async<US5>>
    let _v222 = v226 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v229 : Async<US5> = null |> unbox<Async<US5>>
    let _v222 = v229 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v232 : Async<US5> = null |> unbox<Async<US5>>
    let _v222 = v232 
    #endif
#if FABLE_COMPILER_PYTHON
    let v235 : Async<US5> = null |> unbox<Async<US5>>
    let _v222 = v235 
    #endif
#else
    let v238 : Async<US5> option = None
    let mutable _v238 = v238 
    async {
    let! v217 = v217 
    let v239 : Choice<bool, exn> = v217 
    let v240 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v241 : US5 = null |> unbox<US5>
    let _v240 = v241 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v244 : US5 = null |> unbox<US5>
    let _v240 = v244 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v247 : US5 = null |> unbox<US5>
    let _v240 = v247 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v250 : US5 = null |> unbox<US5>
    let _v240 = v250 
    #endif
#if FABLE_COMPILER_PYTHON
    let v253 : US5 = null |> unbox<US5>
    let _v240 = v253 
    #endif
#else
    let v256 : (bool -> US5) = closure14()
    let v257 : (exn -> US5) = closure15()
    let v258 : US5 = match v239 with Choice1Of2 x -> v256 x | Choice2Of2 x -> v257 x
    let _v240 = v258 
    #endif
    let v259 : US5 = _v240 
    return v259 
    }
    |> fun x -> _v238 <- Some x
    let v264 : Async<US5> = match _v238 with Some x -> x | None -> failwith "async.new_async_unit / _v238=None"
    let _v222 = v264 
    #endif
    let v265 : Async<US5> = _v222 
    let v270 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v271 : Async<US6> = null |> unbox<Async<US6>>
    let _v270 = v271 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v274 : Async<US6> = null |> unbox<Async<US6>>
    let _v270 = v274 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v277 : Async<US6> = null |> unbox<Async<US6>>
    let _v270 = v277 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v280 : Async<US6> = null |> unbox<Async<US6>>
    let _v270 = v280 
    #endif
#if FABLE_COMPILER_PYTHON
    let v283 : Async<US6> = null |> unbox<Async<US6>>
    let _v270 = v283 
    #endif
#else
    let v286 : Async<US6> option = None
    let mutable _v286 = v286 
    async {
    let! v265 = v265 
    let v287 : US5 = v265 
    let v293 : US6 =
        match v287 with
        | US5_0(v288) -> (* C1of2 *)
            US6_0(v288)
        | US5_1(v290) -> (* C2of2 *)
            US6_1(v290)
    return v293 
    }
    |> fun x -> _v286 <- Some x
    let v294 : Async<US6> = match _v286 with Some x -> x | None -> failwith "async.new_async_unit / _v286=None"
    let _v270 = v294 
    #endif
    let v295 : Async<US6> = _v270 
    let v300 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v301 : Async<US4> = null |> unbox<Async<US4>>
    let _v300 = v301 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v304 : Async<US4> = null |> unbox<Async<US4>>
    let _v300 = v304 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v307 : Async<US4> = null |> unbox<Async<US4>>
    let _v300 = v307 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v310 : Async<US4> = null |> unbox<Async<US4>>
    let _v300 = v310 
    #endif
#if FABLE_COMPILER_PYTHON
    let v313 : Async<US4> = null |> unbox<Async<US4>>
    let _v300 = v313 
    #endif
#else
    let v316 : Async<US4> option = None
    let mutable _v316 = v316 
    async {
    let! v295 = v295 
    let v317 : US6 = v295 
    let v446 : US4 =
        match v317 with
        | US6_1(v320) -> (* Error *)
            let v321 : string = $"%A{v320}"
            let v324 : string = "System.TimeoutException"
            let v325 : bool = v321.Contains v324 
            if v325 then
                let v328 : unit = ()
                let v329 : (unit -> unit) = closure16(v0)
                let v330 : unit = (fun () -> v329 (); v328) ()
                US4_1
            else
                let v375 : unit = ()
                let v376 : (unit -> unit) = closure17(v0, v320)
                let v377 : unit = (fun () -> v376 (); v375) ()
                US4_1
        | US6_0(v318) -> (* Ok *)
            US4_0(v318)
    return v446 
    }
    |> fun x -> _v316 <- Some x
    let v447 : Async<US4> = match _v316 with Some x -> x | None -> failwith "async.new_async_unit / _v316=None"
    let _v300 = v447 
    #endif
    let v448 : Async<US4> = _v300 
    return! v448 
    }
    |> fun x -> _v175 <- Some x
    let v453 : Async<US4> = match _v175 with Some x -> x | None -> failwith "async.new_async_unit / _v175=None"
    let _v159 = v453 
    #endif
    let v454 : Async<US4> = _v159 
    let _v143 = v454 
    #endif
    let v459 : Async<US4> = _v143 
    let! v459 = v459 
    let v464 : US4 = v459 
    let v467 : bool =
        match v464 with
        | US4_1 -> (* None *)
            false
        | US4_0(v465) -> (* Some *)
            v465
    return v467 
    }
    |> fun x -> _v19 <- Some x
    let v468 : Async<bool> = match _v19 with Some x -> x | None -> failwith "async.new_async_unit / _v19=None"
    let _v3 = v468 
    #endif
    let v469 : Async<bool> = _v3 
    v469
and closure12 (v0 : int32) (v1 : string) : (int32 -> Async<bool>) =
    closure13(v0, v1)
and closure11 () (v0 : int32) : (string -> (int32 -> Async<bool>)) =
    closure12(v0)
and closure22 () (v0 : int32) : US7 =
    US7_0(v0)
and method25 () : (int32 -> US7) =
    closure22()
and method27 (v0 : int32, v1 : int64, v2 : int32 option, v3 : bool) : string =
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
and method26 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : int32, v9 : int64, v10 : int32 option, v11 : bool) : string =
    let v12 : string = method27(v8, v9, v10, v11)
    let v13 : int64 = v0.l0
    let v14 : string = "networking.wait_for_port_access"
    let v15 : string = $"{v6} {v7} #{v13} %s{v14} / {v12}"
    method17(v15)
and closure23 (v0 : int32 option, v1 : bool, v2 : int32, v3 : int64) () : unit =
    let v4 : US0 = US0_0
    let v5 : bool = method6(v4)
    if v5 then
        let v6 : unit = ()
        let v7 : (unit -> unit) = closure0()
        let v8 : unit = (fun () -> v7 (); v6) ()
        let struct (v22 : Mut0, v23 : Mut1, v24 : Mut2, v25 : Mut3, v26 : Mut4, v27 : int64 option) = TraceState.trace_state.Value
        let v40 : string = method7(v22, v23, v24, v25, v26, v27)
        let v41 : string = method11()
        let v42 : string = method26(v22, v23, v24, v25, v26, v27, v40, v41, v2, v3, v0, v1)
        method18(v42)
and method24 (v0 : int32 option, v1 : bool, v2 : string, v3 : int32, v4 : int64) : Async<int64> =
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
    let v22 : (int32 -> US7) = method25()
    let v23 : US7 option = v0 |> Option.map v22 
    let v34 : US7 = US7_1
    let v35 : US7 = v23 |> Option.defaultValue v34 
    let v635 : Async<bool> =
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
            let v155 : bool = *)
            }
            |> fun x -> _v55 <- Some x
            let v156 : Async<bool> = match _v55 with Some x -> x | None -> failwith "async.new_async_unit / _v55=None"
            let _v39 = v156 
            #endif
            let v157 : Async<bool> = _v39 
            v157
        | US7_0(v162) -> (* Some *)
            let v163 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v164 : Async<bool> = null |> unbox<Async<bool>>
            let _v163 = v164 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v167 : Async<bool> = null |> unbox<Async<bool>>
            let _v163 = v167 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v170 : Async<bool> = null |> unbox<Async<bool>>
            let _v163 = v170 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v173 : Async<bool> = null |> unbox<Async<bool>>
            let _v163 = v173 
            #endif
#if FABLE_COMPILER_PYTHON
            let v176 : Async<bool> = null |> unbox<Async<bool>>
            let _v163 = v176 
            #endif
#else
            let v179 : Async<bool> option = None
            let mutable _v179 = v179 
            async {
            let v180 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v181 : Async<bool> = null |> unbox<Async<bool>>
            let _v180 = v181 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v184 : Async<bool> = null |> unbox<Async<bool>>
            let _v180 = v184 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v187 : Async<bool> = null |> unbox<Async<bool>>
            let _v180 = v187 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v190 : Async<bool> = null |> unbox<Async<bool>>
            let _v180 = v190 
            #endif
#if FABLE_COMPILER_PYTHON
            let v193 : Async<bool> = null |> unbox<Async<bool>>
            let _v180 = v193 
            #endif
#else
            let v196 : Async<bool> option = None
            let mutable _v196 = v196 
            async {
            let v197 : Async<System.Threading.CancellationToken> = Async.CancellationToken
            let! v197 = v197 
            let v198 : System.Threading.CancellationToken = v197 
            let v199 : System.Net.Sockets.TcpClient = new System.Net.Sockets.TcpClient ()
            use v199 = v199 
            let v200 : System.Net.Sockets.TcpClient = v199 
            try
            let v201 : System.Threading.Tasks.ValueTask = v200.ConnectAsync (v2, v3, v198)
            let v202 : (unit -> System.Threading.Tasks.Task) = v201.AsTask
            let v203 : System.Threading.Tasks.Task = v202 ()
            let v204 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v205 : Async<unit> = null |> unbox<Async<unit>>
            let _v204 = v205 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v208 : Async<unit> = null |> unbox<Async<unit>>
            let _v204 = v208 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v211 : Async<unit> = null |> unbox<Async<unit>>
            let _v204 = v211 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v214 : Async<unit> = null |> unbox<Async<unit>>
            let _v204 = v214 
            #endif
#if FABLE_COMPILER_PYTHON
            let v217 : Async<unit> = null |> unbox<Async<unit>>
            let _v204 = v217 
            #endif
#else
            let v220 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
            let v221 : Async<unit> = v220 v203
            let _v204 = v221 
            #endif
            let v222 : Async<unit> = _v204 
            do! v222 
            return true 
            with ex ->
            let v227 : exn = ex
            let v228 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v229 : string = $"%A{v227}"
            let _v228 = v229 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v232 : string = $"%A{v227}"
            let _v228 = v232 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v235 : string = $"%A{v227}"
            let _v228 = v235 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v238 : string = $"%A{v227}"
            let _v228 = v238 
            #endif
#if FABLE_COMPILER_PYTHON
            let v241 : string = $"%A{v227}"
            let _v228 = v241 
            #endif
#else
            let v244 : string = $"{v227.GetType ()}: {v227.Message}"
            let _v228 = v244 
            #endif
            let v245 : string = _v228 
            let v250 : unit = ()
            let v251 : (unit -> unit) = closure5(v3, v245)
            let v252 : unit = (fun () -> v251 (); v250) ()
            return false 
            (*
            let v296 : bool = *)
            }
            |> fun x -> _v196 <- Some x
            let v297 : Async<bool> = match _v196 with Some x -> x | None -> failwith "async.new_async_unit / _v196=None"
            let _v180 = v297 
            #endif
            let v298 : Async<bool> = _v180 
            let v303 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v304 : Async<US4> = null |> unbox<Async<US4>>
            let _v303 = v304 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v307 : Async<US4> = null |> unbox<Async<US4>>
            let _v303 = v307 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v310 : Async<US4> = null |> unbox<Async<US4>>
            let _v303 = v310 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v313 : Async<US4> = null |> unbox<Async<US4>>
            let _v303 = v313 
            #endif
#if FABLE_COMPILER_PYTHON
            let v316 : Async<US4> = null |> unbox<Async<US4>>
            let _v303 = v316 
            #endif
#else
            let v319 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v320 : Async<US4> = null |> unbox<Async<US4>>
            let _v319 = v320 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v323 : Async<US4> = null |> unbox<Async<US4>>
            let _v319 = v323 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v326 : Async<US4> = null |> unbox<Async<US4>>
            let _v319 = v326 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v329 : Async<US4> = null |> unbox<Async<US4>>
            let _v319 = v329 
            #endif
#if FABLE_COMPILER_PYTHON
            let v332 : Async<US4> = null |> unbox<Async<US4>>
            let _v319 = v332 
            #endif
#else
            let v335 : Async<US4> option = None
            let mutable _v335 = v335 
            async {
            let v336 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v337 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v336 = v337 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v340 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v336 = v340 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v343 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v336 = v343 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v346 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v336 = v346 
            #endif
#if FABLE_COMPILER_PYTHON
            let v349 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v336 = v349 
            #endif
#else
            let v352 : Async<Async<bool>> = Async.StartChild (v298, v162)
            let _v336 = v352 
            #endif
            let v353 : Async<Async<bool>> = _v336 
            let! v353 = v353 
            let v358 : Async<bool> = v353 
            let v359 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v360 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
            let _v359 = v360 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v363 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
            let _v359 = v363 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v366 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
            let _v359 = v366 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v369 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
            let _v359 = v369 
            #endif
#if FABLE_COMPILER_PYTHON
            let v372 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
            let _v359 = v372 
            #endif
#else
            let v375 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v376 : Async<Choice<bool, exn>> = v375 v358
            let _v359 = v376 
            #endif
            let v377 : Async<Choice<bool, exn>> = _v359 
            let v382 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v383 : Async<US5> = null |> unbox<Async<US5>>
            let _v382 = v383 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v386 : Async<US5> = null |> unbox<Async<US5>>
            let _v382 = v386 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v389 : Async<US5> = null |> unbox<Async<US5>>
            let _v382 = v389 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v392 : Async<US5> = null |> unbox<Async<US5>>
            let _v382 = v392 
            #endif
#if FABLE_COMPILER_PYTHON
            let v395 : Async<US5> = null |> unbox<Async<US5>>
            let _v382 = v395 
            #endif
#else
            let v398 : Async<US5> option = None
            let mutable _v398 = v398 
            async {
            let! v377 = v377 
            let v399 : Choice<bool, exn> = v377 
            let v400 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v401 : US5 = null |> unbox<US5>
            let _v400 = v401 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v404 : US5 = null |> unbox<US5>
            let _v400 = v404 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v407 : US5 = null |> unbox<US5>
            let _v400 = v407 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v410 : US5 = null |> unbox<US5>
            let _v400 = v410 
            #endif
#if FABLE_COMPILER_PYTHON
            let v413 : US5 = null |> unbox<US5>
            let _v400 = v413 
            #endif
#else
            let v416 : (bool -> US5) = closure14()
            let v417 : (exn -> US5) = closure15()
            let v418 : US5 = match v399 with Choice1Of2 x -> v416 x | Choice2Of2 x -> v417 x
            let _v400 = v418 
            #endif
            let v419 : US5 = _v400 
            return v419 
            }
            |> fun x -> _v398 <- Some x
            let v424 : Async<US5> = match _v398 with Some x -> x | None -> failwith "async.new_async_unit / _v398=None"
            let _v382 = v424 
            #endif
            let v425 : Async<US5> = _v382 
            let v430 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v431 : Async<US6> = null |> unbox<Async<US6>>
            let _v430 = v431 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v434 : Async<US6> = null |> unbox<Async<US6>>
            let _v430 = v434 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v437 : Async<US6> = null |> unbox<Async<US6>>
            let _v430 = v437 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v440 : Async<US6> = null |> unbox<Async<US6>>
            let _v430 = v440 
            #endif
#if FABLE_COMPILER_PYTHON
            let v443 : Async<US6> = null |> unbox<Async<US6>>
            let _v430 = v443 
            #endif
#else
            let v446 : Async<US6> option = None
            let mutable _v446 = v446 
            async {
            let! v425 = v425 
            let v447 : US5 = v425 
            let v453 : US6 =
                match v447 with
                | US5_0(v448) -> (* C1of2 *)
                    US6_0(v448)
                | US5_1(v450) -> (* C2of2 *)
                    US6_1(v450)
            return v453 
            }
            |> fun x -> _v446 <- Some x
            let v454 : Async<US6> = match _v446 with Some x -> x | None -> failwith "async.new_async_unit / _v446=None"
            let _v430 = v454 
            #endif
            let v455 : Async<US6> = _v430 
            let v460 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v461 : Async<US4> = null |> unbox<Async<US4>>
            let _v460 = v461 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v464 : Async<US4> = null |> unbox<Async<US4>>
            let _v460 = v464 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v467 : Async<US4> = null |> unbox<Async<US4>>
            let _v460 = v467 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v470 : Async<US4> = null |> unbox<Async<US4>>
            let _v460 = v470 
            #endif
#if FABLE_COMPILER_PYTHON
            let v473 : Async<US4> = null |> unbox<Async<US4>>
            let _v460 = v473 
            #endif
#else
            let v476 : Async<US4> option = None
            let mutable _v476 = v476 
            async {
            let! v455 = v455 
            let v477 : US6 = v455 
            let v606 : US4 =
                match v477 with
                | US6_1(v480) -> (* Error *)
                    let v481 : string = $"%A{v480}"
                    let v484 : string = "System.TimeoutException"
                    let v485 : bool = v481.Contains v484 
                    if v485 then
                        let v488 : unit = ()
                        let v489 : (unit -> unit) = closure16(v162)
                        let v490 : unit = (fun () -> v489 (); v488) ()
                        US4_1
                    else
                        let v535 : unit = ()
                        let v536 : (unit -> unit) = closure17(v162, v480)
                        let v537 : unit = (fun () -> v536 (); v535) ()
                        US4_1
                | US6_0(v478) -> (* Ok *)
                    US4_0(v478)
            return v606 
            }
            |> fun x -> _v476 <- Some x
            let v607 : Async<US4> = match _v476 with Some x -> x | None -> failwith "async.new_async_unit / _v476=None"
            let _v460 = v607 
            #endif
            let v608 : Async<US4> = _v460 
            return! v608 
            }
            |> fun x -> _v335 <- Some x
            let v613 : Async<US4> = match _v335 with Some x -> x | None -> failwith "async.new_async_unit / _v335=None"
            let _v319 = v613 
            #endif
            let v614 : Async<US4> = _v319 
            let _v303 = v614 
            #endif
            let v619 : Async<US4> = _v303 
            let! v619 = v619 
            let v624 : US4 = v619 
            let v627 : bool =
                match v624 with
                | US4_1 -> (* None *)
                    false
                | US4_0(v625) -> (* Some *)
                    v625
            return v627 
            }
            |> fun x -> _v179 <- Some x
            let v628 : Async<bool> = match _v179 with Some x -> x | None -> failwith "async.new_async_unit / _v179=None"
            let _v163 = v628 
            #endif
            let v629 : Async<bool> = _v163 
            v629
    let! v635 = v635 
    let v636 : bool = v635 
    let v637 : bool = v636 = v1
    if v637 then
        return v4 
        (*
        ()
    else
        *) else
        let v638 : int64 = v4 % 100L
        let v639 : bool = v638 = 0L
        if v639 then
            let v640 : unit = ()
            let v641 : (unit -> unit) = closure23(v0, v1, v3, v4)
            let v642 : unit = (fun () -> v641 (); v640) ()
            ()
        let v682 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v683 : Async<unit> = null |> unbox<Async<unit>>
        let _v682 = v683 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v686 : Async<unit> = null |> unbox<Async<unit>>
        let _v682 = v686 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v689 : Async<unit> = null |> unbox<Async<unit>>
        let _v682 = v689 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v692 : Async<unit> = null |> unbox<Async<unit>>
        let _v682 = v692 
        #endif
#if FABLE_COMPILER_PYTHON
        let v695 : Async<unit> = null |> unbox<Async<unit>>
        let _v682 = v695 
        #endif
#else
        let v698 : (int32 -> Async<unit>) = Async.Sleep
        let v699 : Async<unit> = v698 10
        let _v682 = v699 
        #endif
        let v700 : Async<unit> = _v682 
        do! v700 
        let v705 : int64 = v4 + 1L
        let v706 : Async<int64> = method24(v0, v1, v2, v3, v705)
        return! v706 
        (*
        ()
    *)
    }
    |> fun x -> _v21 <- Some x
    let v707 : Async<int64> = match _v21 with Some x -> x | None -> failwith "async.new_async_unit / _v21=None"
    let _v5 = v707 
    #endif
    let v708 : Async<int64> = _v5 
    v708
and closure21 (v0 : int32 option, v1 : bool, v2 : string) (v3 : int32) : Async<int64> =
    let v4 : int64 = 0L
    method24(v0, v1, v2, v3, v4)
and closure20 (v0 : int32 option, v1 : bool) (v2 : string) : (int32 -> Async<int64>) =
    closure21(v0, v1, v2)
and closure19 (v0 : int32 option) (v1 : bool) : (string -> (int32 -> Async<int64>)) =
    closure20(v0, v1)
and closure18 () (v0 : int32 option) : (bool -> (string -> (int32 -> Async<int64>))) =
    closure19(v0)
and method28 (v0 : int32 option, v1 : string, v2 : int32) : Async<int32> =
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
    let v20 : (int32 -> US7) = method25()
    let v21 : US7 option = v0 |> Option.map v20 
    let v32 : US7 = US7_1
    let v33 : US7 = v21 |> Option.defaultValue v32 
    let v633 : Async<bool> =
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
            let v153 : bool = *)
            }
            |> fun x -> _v53 <- Some x
            let v154 : Async<bool> = match _v53 with Some x -> x | None -> failwith "async.new_async_unit / _v53=None"
            let _v37 = v154 
            #endif
            let v155 : Async<bool> = _v37 
            v155
        | US7_0(v160) -> (* Some *)
            let v161 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v162 : Async<bool> = null |> unbox<Async<bool>>
            let _v161 = v162 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v165 : Async<bool> = null |> unbox<Async<bool>>
            let _v161 = v165 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v168 : Async<bool> = null |> unbox<Async<bool>>
            let _v161 = v168 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v171 : Async<bool> = null |> unbox<Async<bool>>
            let _v161 = v171 
            #endif
#if FABLE_COMPILER_PYTHON
            let v174 : Async<bool> = null |> unbox<Async<bool>>
            let _v161 = v174 
            #endif
#else
            let v177 : Async<bool> option = None
            let mutable _v177 = v177 
            async {
            let v178 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v179 : Async<bool> = null |> unbox<Async<bool>>
            let _v178 = v179 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v182 : Async<bool> = null |> unbox<Async<bool>>
            let _v178 = v182 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v185 : Async<bool> = null |> unbox<Async<bool>>
            let _v178 = v185 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v188 : Async<bool> = null |> unbox<Async<bool>>
            let _v178 = v188 
            #endif
#if FABLE_COMPILER_PYTHON
            let v191 : Async<bool> = null |> unbox<Async<bool>>
            let _v178 = v191 
            #endif
#else
            let v194 : Async<bool> option = None
            let mutable _v194 = v194 
            async {
            let v195 : Async<System.Threading.CancellationToken> = Async.CancellationToken
            let! v195 = v195 
            let v196 : System.Threading.CancellationToken = v195 
            let v197 : System.Net.Sockets.TcpClient = new System.Net.Sockets.TcpClient ()
            use v197 = v197 
            let v198 : System.Net.Sockets.TcpClient = v197 
            try
            let v199 : System.Threading.Tasks.ValueTask = v198.ConnectAsync (v1, v2, v196)
            let v200 : (unit -> System.Threading.Tasks.Task) = v199.AsTask
            let v201 : System.Threading.Tasks.Task = v200 ()
            let v202 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v203 : Async<unit> = null |> unbox<Async<unit>>
            let _v202 = v203 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v206 : Async<unit> = null |> unbox<Async<unit>>
            let _v202 = v206 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v209 : Async<unit> = null |> unbox<Async<unit>>
            let _v202 = v209 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v212 : Async<unit> = null |> unbox<Async<unit>>
            let _v202 = v212 
            #endif
#if FABLE_COMPILER_PYTHON
            let v215 : Async<unit> = null |> unbox<Async<unit>>
            let _v202 = v215 
            #endif
#else
            let v218 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
            let v219 : Async<unit> = v218 v201
            let _v202 = v219 
            #endif
            let v220 : Async<unit> = _v202 
            do! v220 
            return true 
            with ex ->
            let v225 : exn = ex
            let v226 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v227 : string = $"%A{v225}"
            let _v226 = v227 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v230 : string = $"%A{v225}"
            let _v226 = v230 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v233 : string = $"%A{v225}"
            let _v226 = v233 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v236 : string = $"%A{v225}"
            let _v226 = v236 
            #endif
#if FABLE_COMPILER_PYTHON
            let v239 : string = $"%A{v225}"
            let _v226 = v239 
            #endif
#else
            let v242 : string = $"{v225.GetType ()}: {v225.Message}"
            let _v226 = v242 
            #endif
            let v243 : string = _v226 
            let v248 : unit = ()
            let v249 : (unit -> unit) = closure5(v2, v243)
            let v250 : unit = (fun () -> v249 (); v248) ()
            return false 
            (*
            let v294 : bool = *)
            }
            |> fun x -> _v194 <- Some x
            let v295 : Async<bool> = match _v194 with Some x -> x | None -> failwith "async.new_async_unit / _v194=None"
            let _v178 = v295 
            #endif
            let v296 : Async<bool> = _v178 
            let v301 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v302 : Async<US4> = null |> unbox<Async<US4>>
            let _v301 = v302 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v305 : Async<US4> = null |> unbox<Async<US4>>
            let _v301 = v305 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v308 : Async<US4> = null |> unbox<Async<US4>>
            let _v301 = v308 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v311 : Async<US4> = null |> unbox<Async<US4>>
            let _v301 = v311 
            #endif
#if FABLE_COMPILER_PYTHON
            let v314 : Async<US4> = null |> unbox<Async<US4>>
            let _v301 = v314 
            #endif
#else
            let v317 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v318 : Async<US4> = null |> unbox<Async<US4>>
            let _v317 = v318 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v321 : Async<US4> = null |> unbox<Async<US4>>
            let _v317 = v321 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v324 : Async<US4> = null |> unbox<Async<US4>>
            let _v317 = v324 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v327 : Async<US4> = null |> unbox<Async<US4>>
            let _v317 = v327 
            #endif
#if FABLE_COMPILER_PYTHON
            let v330 : Async<US4> = null |> unbox<Async<US4>>
            let _v317 = v330 
            #endif
#else
            let v333 : Async<US4> option = None
            let mutable _v333 = v333 
            async {
            let v334 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v335 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v334 = v335 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v338 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v334 = v338 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v341 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v334 = v341 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v344 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v334 = v344 
            #endif
#if FABLE_COMPILER_PYTHON
            let v347 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v334 = v347 
            #endif
#else
            let v350 : Async<Async<bool>> = Async.StartChild (v296, v160)
            let _v334 = v350 
            #endif
            let v351 : Async<Async<bool>> = _v334 
            let! v351 = v351 
            let v356 : Async<bool> = v351 
            let v357 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v358 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
            let _v357 = v358 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v361 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
            let _v357 = v361 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v364 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
            let _v357 = v364 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v367 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
            let _v357 = v367 
            #endif
#if FABLE_COMPILER_PYTHON
            let v370 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
            let _v357 = v370 
            #endif
#else
            let v373 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v374 : Async<Choice<bool, exn>> = v373 v356
            let _v357 = v374 
            #endif
            let v375 : Async<Choice<bool, exn>> = _v357 
            let v380 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v381 : Async<US5> = null |> unbox<Async<US5>>
            let _v380 = v381 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v384 : Async<US5> = null |> unbox<Async<US5>>
            let _v380 = v384 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v387 : Async<US5> = null |> unbox<Async<US5>>
            let _v380 = v387 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v390 : Async<US5> = null |> unbox<Async<US5>>
            let _v380 = v390 
            #endif
#if FABLE_COMPILER_PYTHON
            let v393 : Async<US5> = null |> unbox<Async<US5>>
            let _v380 = v393 
            #endif
#else
            let v396 : Async<US5> option = None
            let mutable _v396 = v396 
            async {
            let! v375 = v375 
            let v397 : Choice<bool, exn> = v375 
            let v398 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v399 : US5 = null |> unbox<US5>
            let _v398 = v399 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v402 : US5 = null |> unbox<US5>
            let _v398 = v402 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v405 : US5 = null |> unbox<US5>
            let _v398 = v405 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v408 : US5 = null |> unbox<US5>
            let _v398 = v408 
            #endif
#if FABLE_COMPILER_PYTHON
            let v411 : US5 = null |> unbox<US5>
            let _v398 = v411 
            #endif
#else
            let v414 : (bool -> US5) = closure14()
            let v415 : (exn -> US5) = closure15()
            let v416 : US5 = match v397 with Choice1Of2 x -> v414 x | Choice2Of2 x -> v415 x
            let _v398 = v416 
            #endif
            let v417 : US5 = _v398 
            return v417 
            }
            |> fun x -> _v396 <- Some x
            let v422 : Async<US5> = match _v396 with Some x -> x | None -> failwith "async.new_async_unit / _v396=None"
            let _v380 = v422 
            #endif
            let v423 : Async<US5> = _v380 
            let v428 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v429 : Async<US6> = null |> unbox<Async<US6>>
            let _v428 = v429 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v432 : Async<US6> = null |> unbox<Async<US6>>
            let _v428 = v432 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v435 : Async<US6> = null |> unbox<Async<US6>>
            let _v428 = v435 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v438 : Async<US6> = null |> unbox<Async<US6>>
            let _v428 = v438 
            #endif
#if FABLE_COMPILER_PYTHON
            let v441 : Async<US6> = null |> unbox<Async<US6>>
            let _v428 = v441 
            #endif
#else
            let v444 : Async<US6> option = None
            let mutable _v444 = v444 
            async {
            let! v423 = v423 
            let v445 : US5 = v423 
            let v451 : US6 =
                match v445 with
                | US5_0(v446) -> (* C1of2 *)
                    US6_0(v446)
                | US5_1(v448) -> (* C2of2 *)
                    US6_1(v448)
            return v451 
            }
            |> fun x -> _v444 <- Some x
            let v452 : Async<US6> = match _v444 with Some x -> x | None -> failwith "async.new_async_unit / _v444=None"
            let _v428 = v452 
            #endif
            let v453 : Async<US6> = _v428 
            let v458 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v459 : Async<US4> = null |> unbox<Async<US4>>
            let _v458 = v459 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v462 : Async<US4> = null |> unbox<Async<US4>>
            let _v458 = v462 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v465 : Async<US4> = null |> unbox<Async<US4>>
            let _v458 = v465 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v468 : Async<US4> = null |> unbox<Async<US4>>
            let _v458 = v468 
            #endif
#if FABLE_COMPILER_PYTHON
            let v471 : Async<US4> = null |> unbox<Async<US4>>
            let _v458 = v471 
            #endif
#else
            let v474 : Async<US4> option = None
            let mutable _v474 = v474 
            async {
            let! v453 = v453 
            let v475 : US6 = v453 
            let v604 : US4 =
                match v475 with
                | US6_1(v478) -> (* Error *)
                    let v479 : string = $"%A{v478}"
                    let v482 : string = "System.TimeoutException"
                    let v483 : bool = v479.Contains v482 
                    if v483 then
                        let v486 : unit = ()
                        let v487 : (unit -> unit) = closure16(v160)
                        let v488 : unit = (fun () -> v487 (); v486) ()
                        US4_1
                    else
                        let v533 : unit = ()
                        let v534 : (unit -> unit) = closure17(v160, v478)
                        let v535 : unit = (fun () -> v534 (); v533) ()
                        US4_1
                | US6_0(v476) -> (* Ok *)
                    US4_0(v476)
            return v604 
            }
            |> fun x -> _v474 <- Some x
            let v605 : Async<US4> = match _v474 with Some x -> x | None -> failwith "async.new_async_unit / _v474=None"
            let _v458 = v605 
            #endif
            let v606 : Async<US4> = _v458 
            return! v606 
            }
            |> fun x -> _v333 <- Some x
            let v611 : Async<US4> = match _v333 with Some x -> x | None -> failwith "async.new_async_unit / _v333=None"
            let _v317 = v611 
            #endif
            let v612 : Async<US4> = _v317 
            let _v301 = v612 
            #endif
            let v617 : Async<US4> = _v301 
            let! v617 = v617 
            let v622 : US4 = v617 
            let v625 : bool =
                match v622 with
                | US4_1 -> (* None *)
                    false
                | US4_0(v623) -> (* Some *)
                    v623
            return v625 
            }
            |> fun x -> _v177 <- Some x
            let v626 : Async<bool> = match _v177 with Some x -> x | None -> failwith "async.new_async_unit / _v177=None"
            let _v161 = v626 
            #endif
            let v627 : Async<bool> = _v161 
            v627
    let! v633 = v633 
    let v634 : bool = v633 
    let v635 : bool = v634 = false
    if v635 then
        return v2 
        (*
        ()
    else
        *) else
        let v636 : int32 = v2 + 1
        let v637 : Async<int32> = method28(v0, v1, v636)
        return! v637 
        (*
        ()
    *)
    }
    |> fun x -> _v19 <- Some x
    let v638 : Async<int32> = match _v19 with Some x -> x | None -> failwith "async.new_async_unit / _v19=None"
    let _v3 = v638 
    #endif
    let v639 : Async<int32> = _v3 
    v639
and closure26 (v0 : int32 option, v1 : string) (v2 : int32) : Async<int32> =
    method28(v0, v1, v2)
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
