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
and method15 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : int32, v9 : string) : string =
    let v10 : string = method16(v8, v9)
    let v11 : int64 = v0.l0
    let v12 : string = "networking.test_port_open"
    let v13 : string = $"{v6} {v7} #{v11} %s{v12} / {v10}"
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
        let v40 : string = method15(v20, v21, v22, v23, v24, v25, v38, v39, v0, v1)
        method18(v40)
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
    let v114 : bool = *)
    }
    |> fun x -> _v18 <- Some x
    let v115 : Async<bool> = match _v18 with Some x -> x | None -> failwith "async.new_async_unit / _v18=None"
    let _v2 = v115 
    #endif
    let v116 : Async<bool> = _v2 
    v116
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
and method19 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : int32) : string =
    let v9 : string = method20(v8)
    let v10 : int64 = v0.l0
    let v11 : string = "async.run_with_timeout_async"
    let v12 : string = $"{v6} {v7} #{v10} %s{v11} / {v9}"
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
        let v39 : string = method19(v19, v20, v21, v22, v23, v24, v37, v38, v0)
        method18(v39)
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
and method22 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : int32, v9 : string) : string =
    let v10 : string = method23(v8, v9)
    let v11 : int64 = v0.l0
    let v12 : string = "async.run_with_timeout_async**"
    let v13 : string = $"{v6} {v7} #{v11} %s{v12} / {v10}"
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
        let v40 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v41 : string = $"%A{v1}"
        let _v40 = v41 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v44 : string = $"%A{v1}"
        let _v40 = v44 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v47 : string = $"%A{v1}"
        let _v40 = v47 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v50 : string = $"%A{v1}"
        let _v40 = v50 
        #endif
#if FABLE_COMPILER_PYTHON
        let v53 : string = $"%A{v1}"
        let _v40 = v53 
        #endif
#else
        let v56 : string = $"{v1.GetType ()}: {v1.Message}"
        let _v40 = v56 
        #endif
        let v57 : string = _v40 
        let v62 : string = method22(v20, v21, v22, v23, v24, v25, v38, v39, v0, v57)
        method18(v62)
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
    let v132 : bool = *)
    }
    |> fun x -> _v36 <- Some x
    let v133 : Async<bool> = match _v36 with Some x -> x | None -> failwith "async.new_async_unit / _v36=None"
    let _v20 = v133 
    #endif
    let v134 : Async<bool> = _v20 
    let v139 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v140 : Async<US4> = null |> unbox<Async<US4>>
    let _v139 = v140 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v143 : Async<US4> = null |> unbox<Async<US4>>
    let _v139 = v143 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v146 : Async<US4> = null |> unbox<Async<US4>>
    let _v139 = v146 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v149 : Async<US4> = null |> unbox<Async<US4>>
    let _v139 = v149 
    #endif
#if FABLE_COMPILER_PYTHON
    let v152 : Async<US4> = null |> unbox<Async<US4>>
    let _v139 = v152 
    #endif
#else
    let v155 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v156 : Async<US4> = null |> unbox<Async<US4>>
    let _v155 = v156 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v159 : Async<US4> = null |> unbox<Async<US4>>
    let _v155 = v159 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v162 : Async<US4> = null |> unbox<Async<US4>>
    let _v155 = v162 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v165 : Async<US4> = null |> unbox<Async<US4>>
    let _v155 = v165 
    #endif
#if FABLE_COMPILER_PYTHON
    let v168 : Async<US4> = null |> unbox<Async<US4>>
    let _v155 = v168 
    #endif
#else
    let v171 : Async<US4> option = None
    let mutable _v171 = v171 
    async {
    let v172 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v173 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
    let _v172 = v173 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v176 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
    let _v172 = v176 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v179 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
    let _v172 = v179 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v182 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
    let _v172 = v182 
    #endif
#if FABLE_COMPILER_PYTHON
    let v185 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
    let _v172 = v185 
    #endif
#else
    let v188 : Async<Async<bool>> = Async.StartChild (v134, v0)
    let _v172 = v188 
    #endif
    let v189 : Async<Async<bool>> = _v172 
    let! v189 = v189 
    let v194 : Async<bool> = v189 
    let v195 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v196 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
    let _v195 = v196 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v199 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
    let _v195 = v199 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v202 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
    let _v195 = v202 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v205 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
    let _v195 = v205 
    #endif
#if FABLE_COMPILER_PYTHON
    let v208 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
    let _v195 = v208 
    #endif
#else
    let v211 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
    let v212 : Async<Choice<bool, exn>> = v211 v194
    let _v195 = v212 
    #endif
    let v213 : Async<Choice<bool, exn>> = _v195 
    let v218 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v219 : Async<US5> = null |> unbox<Async<US5>>
    let _v218 = v219 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v222 : Async<US5> = null |> unbox<Async<US5>>
    let _v218 = v222 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v225 : Async<US5> = null |> unbox<Async<US5>>
    let _v218 = v225 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v228 : Async<US5> = null |> unbox<Async<US5>>
    let _v218 = v228 
    #endif
#if FABLE_COMPILER_PYTHON
    let v231 : Async<US5> = null |> unbox<Async<US5>>
    let _v218 = v231 
    #endif
#else
    let v234 : Async<US5> option = None
    let mutable _v234 = v234 
    async {
    let! v213 = v213 
    let v235 : Choice<bool, exn> = v213 
    let v236 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v237 : US5 = null |> unbox<US5>
    let _v236 = v237 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v240 : US5 = null |> unbox<US5>
    let _v236 = v240 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v243 : US5 = null |> unbox<US5>
    let _v236 = v243 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v246 : US5 = null |> unbox<US5>
    let _v236 = v246 
    #endif
#if FABLE_COMPILER_PYTHON
    let v249 : US5 = null |> unbox<US5>
    let _v236 = v249 
    #endif
#else
    let v252 : (bool -> US5) = closure14()
    let v253 : (exn -> US5) = closure15()
    let v254 : US5 = match v235 with Choice1Of2 x -> v252 x | Choice2Of2 x -> v253 x
    let _v236 = v254 
    #endif
    let v255 : US5 = _v236 
    return v255 
    }
    |> fun x -> _v234 <- Some x
    let v260 : Async<US5> = match _v234 with Some x -> x | None -> failwith "async.new_async_unit / _v234=None"
    let _v218 = v260 
    #endif
    let v261 : Async<US5> = _v218 
    let v266 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v267 : Async<US6> = null |> unbox<Async<US6>>
    let _v266 = v267 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v270 : Async<US6> = null |> unbox<Async<US6>>
    let _v266 = v270 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v273 : Async<US6> = null |> unbox<Async<US6>>
    let _v266 = v273 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v276 : Async<US6> = null |> unbox<Async<US6>>
    let _v266 = v276 
    #endif
#if FABLE_COMPILER_PYTHON
    let v279 : Async<US6> = null |> unbox<Async<US6>>
    let _v266 = v279 
    #endif
#else
    let v282 : Async<US6> option = None
    let mutable _v282 = v282 
    async {
    let! v261 = v261 
    let v283 : US5 = v261 
    let v289 : US6 =
        match v283 with
        | US5_0(v284) -> (* C1of2 *)
            US6_0(v284)
        | US5_1(v286) -> (* C2of2 *)
            US6_1(v286)
    return v289 
    }
    |> fun x -> _v282 <- Some x
    let v290 : Async<US6> = match _v282 with Some x -> x | None -> failwith "async.new_async_unit / _v282=None"
    let _v266 = v290 
    #endif
    let v291 : Async<US6> = _v266 
    let v296 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v297 : Async<US4> = null |> unbox<Async<US4>>
    let _v296 = v297 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v300 : Async<US4> = null |> unbox<Async<US4>>
    let _v296 = v300 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v303 : Async<US4> = null |> unbox<Async<US4>>
    let _v296 = v303 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v306 : Async<US4> = null |> unbox<Async<US4>>
    let _v296 = v306 
    #endif
#if FABLE_COMPILER_PYTHON
    let v309 : Async<US4> = null |> unbox<Async<US4>>
    let _v296 = v309 
    #endif
#else
    let v312 : Async<US4> option = None
    let mutable _v312 = v312 
    async {
    let! v291 = v291 
    let v313 : US6 = v291 
    let v434 : US4 =
        match v313 with
        | US6_1(v316) -> (* Error *)
            let v317 : string = $"%A{v316}"
            let v320 : string = "System.TimeoutException"
            let v321 : bool = v317.Contains v320 
            if v321 then
                let v324 : unit = ()
                let v325 : (unit -> unit) = closure16(v0)
                let v326 : unit = (fun () -> v325 (); v324) ()
                US4_1
            else
                let v367 : unit = ()
                let v368 : (unit -> unit) = closure17(v0, v316)
                let v369 : unit = (fun () -> v368 (); v367) ()
                US4_1
        | US6_0(v314) -> (* Ok *)
            US4_0(v314)
    return v434 
    }
    |> fun x -> _v312 <- Some x
    let v435 : Async<US4> = match _v312 with Some x -> x | None -> failwith "async.new_async_unit / _v312=None"
    let _v296 = v435 
    #endif
    let v436 : Async<US4> = _v296 
    return! v436 
    }
    |> fun x -> _v171 <- Some x
    let v441 : Async<US4> = match _v171 with Some x -> x | None -> failwith "async.new_async_unit / _v171=None"
    let _v155 = v441 
    #endif
    let v442 : Async<US4> = _v155 
    let _v139 = v442 
    #endif
    let v447 : Async<US4> = _v139 
    let! v447 = v447 
    let v452 : US4 = v447 
    let v455 : bool =
        match v452 with
        | US4_1 -> (* None *)
            false
        | US4_0(v453) -> (* Some *)
            v453
    return v455 
    }
    |> fun x -> _v19 <- Some x
    let v456 : Async<bool> = match _v19 with Some x -> x | None -> failwith "async.new_async_unit / _v19=None"
    let _v3 = v456 
    #endif
    let v457 : Async<bool> = _v3 
    v457
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
    let v619 : Async<bool> =
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
            let v151 : bool = *)
            }
            |> fun x -> _v55 <- Some x
            let v152 : Async<bool> = match _v55 with Some x -> x | None -> failwith "async.new_async_unit / _v55=None"
            let _v39 = v152 
            #endif
            let v153 : Async<bool> = _v39 
            v153
        | US7_0(v158) -> (* Some *)
            let v159 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v160 : Async<bool> = null |> unbox<Async<bool>>
            let _v159 = v160 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v163 : Async<bool> = null |> unbox<Async<bool>>
            let _v159 = v163 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v166 : Async<bool> = null |> unbox<Async<bool>>
            let _v159 = v166 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v169 : Async<bool> = null |> unbox<Async<bool>>
            let _v159 = v169 
            #endif
#if FABLE_COMPILER_PYTHON
            let v172 : Async<bool> = null |> unbox<Async<bool>>
            let _v159 = v172 
            #endif
#else
            let v175 : Async<bool> option = None
            let mutable _v175 = v175 
            async {
            let v176 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v177 : Async<bool> = null |> unbox<Async<bool>>
            let _v176 = v177 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v180 : Async<bool> = null |> unbox<Async<bool>>
            let _v176 = v180 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v183 : Async<bool> = null |> unbox<Async<bool>>
            let _v176 = v183 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v186 : Async<bool> = null |> unbox<Async<bool>>
            let _v176 = v186 
            #endif
#if FABLE_COMPILER_PYTHON
            let v189 : Async<bool> = null |> unbox<Async<bool>>
            let _v176 = v189 
            #endif
#else
            let v192 : Async<bool> option = None
            let mutable _v192 = v192 
            async {
            let v193 : Async<System.Threading.CancellationToken> = Async.CancellationToken
            let! v193 = v193 
            let v194 : System.Threading.CancellationToken = v193 
            let v195 : System.Net.Sockets.TcpClient = new System.Net.Sockets.TcpClient ()
            use v195 = v195 
            let v196 : System.Net.Sockets.TcpClient = v195 
            try
            let v197 : System.Threading.Tasks.ValueTask = v196.ConnectAsync (v2, v3, v194)
            let v198 : (unit -> System.Threading.Tasks.Task) = v197.AsTask
            let v199 : System.Threading.Tasks.Task = v198 ()
            let v200 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v201 : Async<unit> = null |> unbox<Async<unit>>
            let _v200 = v201 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v204 : Async<unit> = null |> unbox<Async<unit>>
            let _v200 = v204 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v207 : Async<unit> = null |> unbox<Async<unit>>
            let _v200 = v207 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v210 : Async<unit> = null |> unbox<Async<unit>>
            let _v200 = v210 
            #endif
#if FABLE_COMPILER_PYTHON
            let v213 : Async<unit> = null |> unbox<Async<unit>>
            let _v200 = v213 
            #endif
#else
            let v216 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
            let v217 : Async<unit> = v216 v199
            let _v200 = v217 
            #endif
            let v218 : Async<unit> = _v200 
            do! v218 
            return true 
            with ex ->
            let v223 : exn = ex
            let v224 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v225 : string = $"%A{v223}"
            let _v224 = v225 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v228 : string = $"%A{v223}"
            let _v224 = v228 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v231 : string = $"%A{v223}"
            let _v224 = v231 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v234 : string = $"%A{v223}"
            let _v224 = v234 
            #endif
#if FABLE_COMPILER_PYTHON
            let v237 : string = $"%A{v223}"
            let _v224 = v237 
            #endif
#else
            let v240 : string = $"{v223.GetType ()}: {v223.Message}"
            let _v224 = v240 
            #endif
            let v241 : string = _v224 
            let v246 : unit = ()
            let v247 : (unit -> unit) = closure5(v3, v241)
            let v248 : unit = (fun () -> v247 (); v246) ()
            return false 
            (*
            let v288 : bool = *)
            }
            |> fun x -> _v192 <- Some x
            let v289 : Async<bool> = match _v192 with Some x -> x | None -> failwith "async.new_async_unit / _v192=None"
            let _v176 = v289 
            #endif
            let v290 : Async<bool> = _v176 
            let v295 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v296 : Async<US4> = null |> unbox<Async<US4>>
            let _v295 = v296 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v299 : Async<US4> = null |> unbox<Async<US4>>
            let _v295 = v299 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v302 : Async<US4> = null |> unbox<Async<US4>>
            let _v295 = v302 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v305 : Async<US4> = null |> unbox<Async<US4>>
            let _v295 = v305 
            #endif
#if FABLE_COMPILER_PYTHON
            let v308 : Async<US4> = null |> unbox<Async<US4>>
            let _v295 = v308 
            #endif
#else
            let v311 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v312 : Async<US4> = null |> unbox<Async<US4>>
            let _v311 = v312 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v315 : Async<US4> = null |> unbox<Async<US4>>
            let _v311 = v315 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v318 : Async<US4> = null |> unbox<Async<US4>>
            let _v311 = v318 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v321 : Async<US4> = null |> unbox<Async<US4>>
            let _v311 = v321 
            #endif
#if FABLE_COMPILER_PYTHON
            let v324 : Async<US4> = null |> unbox<Async<US4>>
            let _v311 = v324 
            #endif
#else
            let v327 : Async<US4> option = None
            let mutable _v327 = v327 
            async {
            let v328 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v329 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v328 = v329 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v332 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v328 = v332 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v335 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v328 = v335 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v338 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v328 = v338 
            #endif
#if FABLE_COMPILER_PYTHON
            let v341 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v328 = v341 
            #endif
#else
            let v344 : Async<Async<bool>> = Async.StartChild (v290, v158)
            let _v328 = v344 
            #endif
            let v345 : Async<Async<bool>> = _v328 
            let! v345 = v345 
            let v350 : Async<bool> = v345 
            let v351 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v352 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
            let _v351 = v352 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v355 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
            let _v351 = v355 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v358 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
            let _v351 = v358 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v361 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
            let _v351 = v361 
            #endif
#if FABLE_COMPILER_PYTHON
            let v364 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
            let _v351 = v364 
            #endif
#else
            let v367 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v368 : Async<Choice<bool, exn>> = v367 v350
            let _v351 = v368 
            #endif
            let v369 : Async<Choice<bool, exn>> = _v351 
            let v374 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v375 : Async<US5> = null |> unbox<Async<US5>>
            let _v374 = v375 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v378 : Async<US5> = null |> unbox<Async<US5>>
            let _v374 = v378 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v381 : Async<US5> = null |> unbox<Async<US5>>
            let _v374 = v381 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v384 : Async<US5> = null |> unbox<Async<US5>>
            let _v374 = v384 
            #endif
#if FABLE_COMPILER_PYTHON
            let v387 : Async<US5> = null |> unbox<Async<US5>>
            let _v374 = v387 
            #endif
#else
            let v390 : Async<US5> option = None
            let mutable _v390 = v390 
            async {
            let! v369 = v369 
            let v391 : Choice<bool, exn> = v369 
            let v392 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v393 : US5 = null |> unbox<US5>
            let _v392 = v393 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v396 : US5 = null |> unbox<US5>
            let _v392 = v396 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v399 : US5 = null |> unbox<US5>
            let _v392 = v399 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v402 : US5 = null |> unbox<US5>
            let _v392 = v402 
            #endif
#if FABLE_COMPILER_PYTHON
            let v405 : US5 = null |> unbox<US5>
            let _v392 = v405 
            #endif
#else
            let v408 : (bool -> US5) = closure14()
            let v409 : (exn -> US5) = closure15()
            let v410 : US5 = match v391 with Choice1Of2 x -> v408 x | Choice2Of2 x -> v409 x
            let _v392 = v410 
            #endif
            let v411 : US5 = _v392 
            return v411 
            }
            |> fun x -> _v390 <- Some x
            let v416 : Async<US5> = match _v390 with Some x -> x | None -> failwith "async.new_async_unit / _v390=None"
            let _v374 = v416 
            #endif
            let v417 : Async<US5> = _v374 
            let v422 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v423 : Async<US6> = null |> unbox<Async<US6>>
            let _v422 = v423 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v426 : Async<US6> = null |> unbox<Async<US6>>
            let _v422 = v426 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v429 : Async<US6> = null |> unbox<Async<US6>>
            let _v422 = v429 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v432 : Async<US6> = null |> unbox<Async<US6>>
            let _v422 = v432 
            #endif
#if FABLE_COMPILER_PYTHON
            let v435 : Async<US6> = null |> unbox<Async<US6>>
            let _v422 = v435 
            #endif
#else
            let v438 : Async<US6> option = None
            let mutable _v438 = v438 
            async {
            let! v417 = v417 
            let v439 : US5 = v417 
            let v445 : US6 =
                match v439 with
                | US5_0(v440) -> (* C1of2 *)
                    US6_0(v440)
                | US5_1(v442) -> (* C2of2 *)
                    US6_1(v442)
            return v445 
            }
            |> fun x -> _v438 <- Some x
            let v446 : Async<US6> = match _v438 with Some x -> x | None -> failwith "async.new_async_unit / _v438=None"
            let _v422 = v446 
            #endif
            let v447 : Async<US6> = _v422 
            let v452 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v453 : Async<US4> = null |> unbox<Async<US4>>
            let _v452 = v453 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v456 : Async<US4> = null |> unbox<Async<US4>>
            let _v452 = v456 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v459 : Async<US4> = null |> unbox<Async<US4>>
            let _v452 = v459 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v462 : Async<US4> = null |> unbox<Async<US4>>
            let _v452 = v462 
            #endif
#if FABLE_COMPILER_PYTHON
            let v465 : Async<US4> = null |> unbox<Async<US4>>
            let _v452 = v465 
            #endif
#else
            let v468 : Async<US4> option = None
            let mutable _v468 = v468 
            async {
            let! v447 = v447 
            let v469 : US6 = v447 
            let v590 : US4 =
                match v469 with
                | US6_1(v472) -> (* Error *)
                    let v473 : string = $"%A{v472}"
                    let v476 : string = "System.TimeoutException"
                    let v477 : bool = v473.Contains v476 
                    if v477 then
                        let v480 : unit = ()
                        let v481 : (unit -> unit) = closure16(v158)
                        let v482 : unit = (fun () -> v481 (); v480) ()
                        US4_1
                    else
                        let v523 : unit = ()
                        let v524 : (unit -> unit) = closure17(v158, v472)
                        let v525 : unit = (fun () -> v524 (); v523) ()
                        US4_1
                | US6_0(v470) -> (* Ok *)
                    US4_0(v470)
            return v590 
            }
            |> fun x -> _v468 <- Some x
            let v591 : Async<US4> = match _v468 with Some x -> x | None -> failwith "async.new_async_unit / _v468=None"
            let _v452 = v591 
            #endif
            let v592 : Async<US4> = _v452 
            return! v592 
            }
            |> fun x -> _v327 <- Some x
            let v597 : Async<US4> = match _v327 with Some x -> x | None -> failwith "async.new_async_unit / _v327=None"
            let _v311 = v597 
            #endif
            let v598 : Async<US4> = _v311 
            let _v295 = v598 
            #endif
            let v603 : Async<US4> = _v295 
            let! v603 = v603 
            let v608 : US4 = v603 
            let v611 : bool =
                match v608 with
                | US4_1 -> (* None *)
                    false
                | US4_0(v609) -> (* Some *)
                    v609
            return v611 
            }
            |> fun x -> _v175 <- Some x
            let v612 : Async<bool> = match _v175 with Some x -> x | None -> failwith "async.new_async_unit / _v175=None"
            let _v159 = v612 
            #endif
            let v613 : Async<bool> = _v159 
            v613
    let! v619 = v619 
    let v620 : bool = v619 
    let v621 : bool = v620 = v1
    if v621 then
        return v4 
        (*
        ()
    else
        *) else
        let v622 : int64 = v4 % 100L
        let v623 : bool = v622 = 0L
        if v623 then
            let v624 : unit = ()
            let v625 : (unit -> unit) = closure23(v0, v1, v3, v4)
            let v626 : unit = (fun () -> v625 (); v624) ()
            ()
        let v666 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v667 : Async<unit> = null |> unbox<Async<unit>>
        let _v666 = v667 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v670 : Async<unit> = null |> unbox<Async<unit>>
        let _v666 = v670 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v673 : Async<unit> = null |> unbox<Async<unit>>
        let _v666 = v673 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v676 : Async<unit> = null |> unbox<Async<unit>>
        let _v666 = v676 
        #endif
#if FABLE_COMPILER_PYTHON
        let v679 : Async<unit> = null |> unbox<Async<unit>>
        let _v666 = v679 
        #endif
#else
        let v682 : (int32 -> Async<unit>) = Async.Sleep
        let v683 : Async<unit> = v682 10
        let _v666 = v683 
        #endif
        let v684 : Async<unit> = _v666 
        do! v684 
        let v689 : int64 = v4 + 1L
        let v690 : Async<int64> = method24(v0, v1, v2, v3, v689)
        return! v690 
        (*
        ()
    *)
    }
    |> fun x -> _v21 <- Some x
    let v691 : Async<int64> = match _v21 with Some x -> x | None -> failwith "async.new_async_unit / _v21=None"
    let _v5 = v691 
    #endif
    let v692 : Async<int64> = _v5 
    v692
and closure21 (v0 : int32 option, v1 : bool, v2 : string) (v3 : int32) : Async<int64> =
    let v4 : int64 = 1L
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
    let v617 : Async<bool> =
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
            let v149 : bool = *)
            }
            |> fun x -> _v53 <- Some x
            let v150 : Async<bool> = match _v53 with Some x -> x | None -> failwith "async.new_async_unit / _v53=None"
            let _v37 = v150 
            #endif
            let v151 : Async<bool> = _v37 
            v151
        | US7_0(v156) -> (* Some *)
            let v157 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v158 : Async<bool> = null |> unbox<Async<bool>>
            let _v157 = v158 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v161 : Async<bool> = null |> unbox<Async<bool>>
            let _v157 = v161 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v164 : Async<bool> = null |> unbox<Async<bool>>
            let _v157 = v164 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v167 : Async<bool> = null |> unbox<Async<bool>>
            let _v157 = v167 
            #endif
#if FABLE_COMPILER_PYTHON
            let v170 : Async<bool> = null |> unbox<Async<bool>>
            let _v157 = v170 
            #endif
#else
            let v173 : Async<bool> option = None
            let mutable _v173 = v173 
            async {
            let v174 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v175 : Async<bool> = null |> unbox<Async<bool>>
            let _v174 = v175 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v178 : Async<bool> = null |> unbox<Async<bool>>
            let _v174 = v178 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v181 : Async<bool> = null |> unbox<Async<bool>>
            let _v174 = v181 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v184 : Async<bool> = null |> unbox<Async<bool>>
            let _v174 = v184 
            #endif
#if FABLE_COMPILER_PYTHON
            let v187 : Async<bool> = null |> unbox<Async<bool>>
            let _v174 = v187 
            #endif
#else
            let v190 : Async<bool> option = None
            let mutable _v190 = v190 
            async {
            let v191 : Async<System.Threading.CancellationToken> = Async.CancellationToken
            let! v191 = v191 
            let v192 : System.Threading.CancellationToken = v191 
            let v193 : System.Net.Sockets.TcpClient = new System.Net.Sockets.TcpClient ()
            use v193 = v193 
            let v194 : System.Net.Sockets.TcpClient = v193 
            try
            let v195 : System.Threading.Tasks.ValueTask = v194.ConnectAsync (v1, v2, v192)
            let v196 : (unit -> System.Threading.Tasks.Task) = v195.AsTask
            let v197 : System.Threading.Tasks.Task = v196 ()
            let v198 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v199 : Async<unit> = null |> unbox<Async<unit>>
            let _v198 = v199 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v202 : Async<unit> = null |> unbox<Async<unit>>
            let _v198 = v202 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v205 : Async<unit> = null |> unbox<Async<unit>>
            let _v198 = v205 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v208 : Async<unit> = null |> unbox<Async<unit>>
            let _v198 = v208 
            #endif
#if FABLE_COMPILER_PYTHON
            let v211 : Async<unit> = null |> unbox<Async<unit>>
            let _v198 = v211 
            #endif
#else
            let v214 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
            let v215 : Async<unit> = v214 v197
            let _v198 = v215 
            #endif
            let v216 : Async<unit> = _v198 
            do! v216 
            return true 
            with ex ->
            let v221 : exn = ex
            let v222 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v223 : string = $"%A{v221}"
            let _v222 = v223 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v226 : string = $"%A{v221}"
            let _v222 = v226 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v229 : string = $"%A{v221}"
            let _v222 = v229 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v232 : string = $"%A{v221}"
            let _v222 = v232 
            #endif
#if FABLE_COMPILER_PYTHON
            let v235 : string = $"%A{v221}"
            let _v222 = v235 
            #endif
#else
            let v238 : string = $"{v221.GetType ()}: {v221.Message}"
            let _v222 = v238 
            #endif
            let v239 : string = _v222 
            let v244 : unit = ()
            let v245 : (unit -> unit) = closure5(v2, v239)
            let v246 : unit = (fun () -> v245 (); v244) ()
            return false 
            (*
            let v286 : bool = *)
            }
            |> fun x -> _v190 <- Some x
            let v287 : Async<bool> = match _v190 with Some x -> x | None -> failwith "async.new_async_unit / _v190=None"
            let _v174 = v287 
            #endif
            let v288 : Async<bool> = _v174 
            let v293 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v294 : Async<US4> = null |> unbox<Async<US4>>
            let _v293 = v294 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v297 : Async<US4> = null |> unbox<Async<US4>>
            let _v293 = v297 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v300 : Async<US4> = null |> unbox<Async<US4>>
            let _v293 = v300 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v303 : Async<US4> = null |> unbox<Async<US4>>
            let _v293 = v303 
            #endif
#if FABLE_COMPILER_PYTHON
            let v306 : Async<US4> = null |> unbox<Async<US4>>
            let _v293 = v306 
            #endif
#else
            let v309 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v310 : Async<US4> = null |> unbox<Async<US4>>
            let _v309 = v310 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v313 : Async<US4> = null |> unbox<Async<US4>>
            let _v309 = v313 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v316 : Async<US4> = null |> unbox<Async<US4>>
            let _v309 = v316 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v319 : Async<US4> = null |> unbox<Async<US4>>
            let _v309 = v319 
            #endif
#if FABLE_COMPILER_PYTHON
            let v322 : Async<US4> = null |> unbox<Async<US4>>
            let _v309 = v322 
            #endif
#else
            let v325 : Async<US4> option = None
            let mutable _v325 = v325 
            async {
            let v326 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v327 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v326 = v327 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v330 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v326 = v330 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v333 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v326 = v333 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v336 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v326 = v336 
            #endif
#if FABLE_COMPILER_PYTHON
            let v339 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v326 = v339 
            #endif
#else
            let v342 : Async<Async<bool>> = Async.StartChild (v288, v156)
            let _v326 = v342 
            #endif
            let v343 : Async<Async<bool>> = _v326 
            let! v343 = v343 
            let v348 : Async<bool> = v343 
            let v349 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v350 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
            let _v349 = v350 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v353 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
            let _v349 = v353 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v356 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
            let _v349 = v356 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v359 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
            let _v349 = v359 
            #endif
#if FABLE_COMPILER_PYTHON
            let v362 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
            let _v349 = v362 
            #endif
#else
            let v365 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v366 : Async<Choice<bool, exn>> = v365 v348
            let _v349 = v366 
            #endif
            let v367 : Async<Choice<bool, exn>> = _v349 
            let v372 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v373 : Async<US5> = null |> unbox<Async<US5>>
            let _v372 = v373 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v376 : Async<US5> = null |> unbox<Async<US5>>
            let _v372 = v376 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v379 : Async<US5> = null |> unbox<Async<US5>>
            let _v372 = v379 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v382 : Async<US5> = null |> unbox<Async<US5>>
            let _v372 = v382 
            #endif
#if FABLE_COMPILER_PYTHON
            let v385 : Async<US5> = null |> unbox<Async<US5>>
            let _v372 = v385 
            #endif
#else
            let v388 : Async<US5> option = None
            let mutable _v388 = v388 
            async {
            let! v367 = v367 
            let v389 : Choice<bool, exn> = v367 
            let v390 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v391 : US5 = null |> unbox<US5>
            let _v390 = v391 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v394 : US5 = null |> unbox<US5>
            let _v390 = v394 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v397 : US5 = null |> unbox<US5>
            let _v390 = v397 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v400 : US5 = null |> unbox<US5>
            let _v390 = v400 
            #endif
#if FABLE_COMPILER_PYTHON
            let v403 : US5 = null |> unbox<US5>
            let _v390 = v403 
            #endif
#else
            let v406 : (bool -> US5) = closure14()
            let v407 : (exn -> US5) = closure15()
            let v408 : US5 = match v389 with Choice1Of2 x -> v406 x | Choice2Of2 x -> v407 x
            let _v390 = v408 
            #endif
            let v409 : US5 = _v390 
            return v409 
            }
            |> fun x -> _v388 <- Some x
            let v414 : Async<US5> = match _v388 with Some x -> x | None -> failwith "async.new_async_unit / _v388=None"
            let _v372 = v414 
            #endif
            let v415 : Async<US5> = _v372 
            let v420 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v421 : Async<US6> = null |> unbox<Async<US6>>
            let _v420 = v421 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v424 : Async<US6> = null |> unbox<Async<US6>>
            let _v420 = v424 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v427 : Async<US6> = null |> unbox<Async<US6>>
            let _v420 = v427 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v430 : Async<US6> = null |> unbox<Async<US6>>
            let _v420 = v430 
            #endif
#if FABLE_COMPILER_PYTHON
            let v433 : Async<US6> = null |> unbox<Async<US6>>
            let _v420 = v433 
            #endif
#else
            let v436 : Async<US6> option = None
            let mutable _v436 = v436 
            async {
            let! v415 = v415 
            let v437 : US5 = v415 
            let v443 : US6 =
                match v437 with
                | US5_0(v438) -> (* C1of2 *)
                    US6_0(v438)
                | US5_1(v440) -> (* C2of2 *)
                    US6_1(v440)
            return v443 
            }
            |> fun x -> _v436 <- Some x
            let v444 : Async<US6> = match _v436 with Some x -> x | None -> failwith "async.new_async_unit / _v436=None"
            let _v420 = v444 
            #endif
            let v445 : Async<US6> = _v420 
            let v450 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v451 : Async<US4> = null |> unbox<Async<US4>>
            let _v450 = v451 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v454 : Async<US4> = null |> unbox<Async<US4>>
            let _v450 = v454 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v457 : Async<US4> = null |> unbox<Async<US4>>
            let _v450 = v457 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v460 : Async<US4> = null |> unbox<Async<US4>>
            let _v450 = v460 
            #endif
#if FABLE_COMPILER_PYTHON
            let v463 : Async<US4> = null |> unbox<Async<US4>>
            let _v450 = v463 
            #endif
#else
            let v466 : Async<US4> option = None
            let mutable _v466 = v466 
            async {
            let! v445 = v445 
            let v467 : US6 = v445 
            let v588 : US4 =
                match v467 with
                | US6_1(v470) -> (* Error *)
                    let v471 : string = $"%A{v470}"
                    let v474 : string = "System.TimeoutException"
                    let v475 : bool = v471.Contains v474 
                    if v475 then
                        let v478 : unit = ()
                        let v479 : (unit -> unit) = closure16(v156)
                        let v480 : unit = (fun () -> v479 (); v478) ()
                        US4_1
                    else
                        let v521 : unit = ()
                        let v522 : (unit -> unit) = closure17(v156, v470)
                        let v523 : unit = (fun () -> v522 (); v521) ()
                        US4_1
                | US6_0(v468) -> (* Ok *)
                    US4_0(v468)
            return v588 
            }
            |> fun x -> _v466 <- Some x
            let v589 : Async<US4> = match _v466 with Some x -> x | None -> failwith "async.new_async_unit / _v466=None"
            let _v450 = v589 
            #endif
            let v590 : Async<US4> = _v450 
            return! v590 
            }
            |> fun x -> _v325 <- Some x
            let v595 : Async<US4> = match _v325 with Some x -> x | None -> failwith "async.new_async_unit / _v325=None"
            let _v309 = v595 
            #endif
            let v596 : Async<US4> = _v309 
            let _v293 = v596 
            #endif
            let v601 : Async<US4> = _v293 
            let! v601 = v601 
            let v606 : US4 = v601 
            let v609 : bool =
                match v606 with
                | US4_1 -> (* None *)
                    false
                | US4_0(v607) -> (* Some *)
                    v607
            return v609 
            }
            |> fun x -> _v173 <- Some x
            let v610 : Async<bool> = match _v173 with Some x -> x | None -> failwith "async.new_async_unit / _v173=None"
            let _v157 = v610 
            #endif
            let v611 : Async<bool> = _v157 
            v611
    let! v617 = v617 
    let v618 : bool = v617 
    let v619 : bool = v618 = false
    if v619 then
        return v2 
        (*
        ()
    else
        *) else
        let v620 : int32 = v2 + 1
        let v621 : Async<int32> = method28(v0, v1, v620)
        return! v621 
        (*
        ()
    *)
    }
    |> fun x -> _v19 <- Some x
    let v622 : Async<int32> = match _v19 with Some x -> x | None -> failwith "async.new_async_unit / _v19=None"
    let _v3 = v622 
    #endif
    let v623 : Async<int32> = _v3 
    v623
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
