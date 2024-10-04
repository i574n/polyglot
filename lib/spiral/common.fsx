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
    | US4_0
    | US4_1
and [<Struct>] US5 =
    | US5_0 of f0_0 : US4
    | US5_1
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
and method6 (v0 : (unit -> unit)) : (unit -> unit) =
    v0
and method7 (v0 : (unit -> unit)) : (unit -> unit) =
    v0
and closure3 () (v0 : (unit -> unit)) : System.IDisposable =
    let v1 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : (unit -> unit) = method6(v0)
    let v3 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v2 "$0()" )
    let _v1 = v3 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v4 : (unit -> unit) = method6(v0)
    let v5 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v4 "$0()" )
    let _v1 = v5 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v6 : (unit -> unit) = method6(v0)
    let v7 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v6 "$0()" )
    let _v1 = v7 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v8 : (unit -> unit) = method7(v0)
    let v9 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v8 () }
    let _v1 = v9 
    #endif
#if FABLE_COMPILER_PYTHON
    let v10 : (unit -> unit) = method7(v0)
    let v11 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v10 () }
    let _v1 = v11 
    #endif
#else
    let v12 : (unit -> unit) = method7(v0)
    let v13 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v12 () }
    let _v1 = v13 
    #endif
    let v14 : System.IDisposable = _v1 
    v14
and closure6 () (v0 : US4) : US5 =
    US5_0(v0)
and closure7 (v0 : int32, v1 : (unit -> unit), v2 : int32) () : US4 =
    let v3 : bool = v2 < v0
    if v3 then
        v1 ()
        US4_0
    else
        US4_1
and method9 (v0 : US0) : bool =
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
and closure10 () (v0 : int64) : US3 =
    US3_0(v0)
and method11 () : (int64 -> US3) =
    closure10()
and method12 () : string =
    let v0 : string = "hh:mm:ss"
    v0
and method13 () : string =
    let v0 : string = "HH:mm:ss"
    v0
and method10 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option) : string =
    let v6 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v7 : (int64 -> US3) = method11()
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
    let v61 : string = method12()
    let v64 : (string -> string) = v60.ToString
    let v65 : string = v64 v61
    let _v6 = v65 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v68 : (int64 -> US3) = method11()
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
    let v122 : string = method12()
    let v125 : (string -> string) = v121.ToString
    let v126 : string = v125 v122
    let _v6 = v126 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v129 : string = $"near_sdk::env::block_timestamp()"
    let v130 : uint64 = Fable.Core.RustInterop.emitRustExpr () v129 
    let v131 : (int64 -> US3) = method11()
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
    let v164 : (int64 -> US3) = method11()
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
    let v218 : string = method13()
    let v221 : (string -> string) = v217.ToString
    let v222 : string = v221 v218
    let _v6 = v222 
    #endif
#if FABLE_COMPILER_PYTHON
    let v225 : (int64 -> US3) = method11()
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
    let v279 : string = method13()
    let v282 : (string -> string) = v278.ToString
    let v283 : string = v282 v279
    let _v6 = v283 
    #endif
#else
    let v286 : (int64 -> US3) = method11()
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
    let v340 : string = method13()
    let v343 : (string -> string) = v339.ToString
    let v344 : string = v343 v340
    let _v6 = v344 
    #endif
    let v347 : string = _v6 
    v347
and method16 () : string =
    let v0 : string = ""
    v0
and closure11 (v0 : Mut3, v1 : string) () : unit =
    let v2 : string = v0.l0
    let v3 : string = v2 + v1 
    v0.l0 <- v3
    ()
and method15 (v0 : char) : string =
    let v1 : string = method16()
    let v2 : Mut3 = {l0 = v1} : Mut3
    let v3 : string = $"{v0}"
    let v6 : unit = ()
    let v7 : (unit -> unit) = closure11(v2, v3)
    let v8 : unit = (fun () -> v7 (); v6) ()
    let v11 : string = v2.l0
    v11
and method17 () : string =
    let v0 : string = "\u001b[0m"
    v0
and method14 () : string =
    
    
    
    
    
    let v0 : string = "Warning"
    let v1 : (unit -> string) = v0.ToLower
    let v2 : string = v1 ()
    let v5 : char = v2.[int 0]
    let v6 : string = method15(v5)
    let v7 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v8 : string = "inline_colorization::color_yellow"
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
    let v37 : string = "inline_colorization::color_yellow"
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
    let v66 : string = "inline_colorization::color_yellow"
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
    let v95 : string = "\u001b[93m"
    let v96 : string = method17()
    let v97 : string = v95 + v6 
    let v98 : string = v97 + v96 
    let _v7 = v98 
    #endif
#if FABLE_COMPILER_PYTHON
    let v99 : string = "\u001b[93m"
    let v100 : string = method17()
    let v101 : string = v99 + v6 
    let v102 : string = v101 + v100 
    let _v7 = v102 
    #endif
#else
    let v103 : string = "\u001b[93m"
    let v104 : string = method17()
    let v105 : string = v103 + v6 
    let v106 : string = v105 + v104 
    let _v7 = v106 
    #endif
    let v107 : string = _v7 
    v107
and method19 (v0 : int32, v1 : exn) : string =
    let v2 : string = method16()
    let v3 : Mut3 = {l0 = v2} : Mut3
    let v4 : string = "{ "
    let v5 : string = $"{v4}"
    let v8 : unit = ()
    let v9 : (unit -> unit) = closure11(v3, v5)
    let v10 : unit = (fun () -> v9 (); v8) ()
    let v13 : string = "retry"
    let v14 : string = $"{v13}"
    let v17 : unit = ()
    let v18 : (unit -> unit) = closure11(v3, v14)
    let v19 : unit = (fun () -> v18 (); v17) ()
    let v22 : string = " = "
    let v23 : string = $"{v22}"
    let v26 : unit = ()
    let v27 : (unit -> unit) = closure11(v3, v23)
    let v28 : unit = (fun () -> v27 (); v26) ()
    let v31 : string = $"{v0}"
    let v34 : unit = ()
    let v35 : (unit -> unit) = closure11(v3, v31)
    let v36 : unit = (fun () -> v35 (); v34) ()
    let v39 : string = "; "
    let v40 : string = $"{v39}"
    let v43 : unit = ()
    let v44 : (unit -> unit) = closure11(v3, v40)
    let v45 : unit = (fun () -> v44 (); v43) ()
    let v48 : string = "ex"
    let v49 : string = $"{v48}"
    let v52 : unit = ()
    let v53 : (unit -> unit) = closure11(v3, v49)
    let v54 : unit = (fun () -> v53 (); v52) ()
    let v57 : string = $"{v22}"
    let v60 : unit = ()
    let v61 : (unit -> unit) = closure11(v3, v57)
    let v62 : unit = (fun () -> v61 (); v60) ()
    let v65 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v66 : string = "format!(\"{:#?}\", $0)"
    let v67 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1 v66 
    let v68 : string = "fable_library_rust::String_::fromString($0)"
    let v69 : string = Fable.Core.RustInterop.emitRustExpr v67 v68 
    let _v65 = v69 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v70 : string = "format!(\"{:#?}\", $0)"
    let v71 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1 v70 
    let v72 : string = "fable_library_rust::String_::fromString($0)"
    let v73 : string = Fable.Core.RustInterop.emitRustExpr v71 v72 
    let _v65 = v73 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v74 : string = "format!(\"{:#?}\", $0)"
    let v75 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1 v74 
    let v76 : string = "fable_library_rust::String_::fromString($0)"
    let v77 : string = Fable.Core.RustInterop.emitRustExpr v75 v76 
    let _v65 = v77 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v78 : string = $"%A{v1}"
    let _v65 = v78 
    #endif
#if FABLE_COMPILER_PYTHON
    let v81 : string = $"%A{v1}"
    let _v65 = v81 
    #endif
#else
    let v84 : string = $"%A{v1}"
    let _v65 = v84 
    #endif
    let v87 : string = _v65 
    let v92 : string = $"{v87}"
    let v95 : unit = ()
    let v96 : (unit -> unit) = closure11(v3, v92)
    let v97 : unit = (fun () -> v96 (); v95) ()
    let v100 : string = " }"
    let v101 : string = $"{v100}"
    let v104 : unit = ()
    let v105 : (unit -> unit) = closure11(v3, v101)
    let v106 : unit = (fun () -> v105 (); v104) ()
    let v109 : string = v3.l0
    v109
and method20 (v0 : string) : string =
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
and method18 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : int32, v9 : exn) : string =
    let v10 : string = method19(v8, v9)
    let v11 : int64 = v0.l0
    let v12 : string = "common.retry_fn"
    let v13 : string = $"{v6} {v7} #{v11} %s{v12} / {v10}"
    method20(v13)
and closure12 (v0 : Mut0) () : unit =
    let v1 : int64 = v0.l0
    let v2 : int64 = v1 + 1L
    v0.l0 <- v2
    ()
and closure14 (v0 : string) () : unit =
    let v1 : (string -> unit) = System.Console.WriteLine
    v1 v0
and closure13 () (v0 : string) : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure14(v0)
    let v3 : unit = (fun () -> v2 (); v1) ()
    ()
and method21 (v0 : string) : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure0()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v17 : Mut0, v18 : Mut1, v19 : Mut2, v20 : Mut3, v21 : Mut4, v22 : int64 option) = TraceState.trace_state.Value
    let v35 : unit = ()
    let v36 : (unit -> unit) = closure12(v17)
    let v37 : unit = (fun () -> v36 (); v35) ()
    let v40 : (string -> unit) = closure13()
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
and closure9 (v0 : int32, v1 : exn) () : unit =
    let v2 : US0 = US0_3
    let v3 : bool = method9(v2)
    if v3 then
        let v4 : unit = ()
        let v5 : (unit -> unit) = closure0()
        let v6 : unit = (fun () -> v5 (); v4) ()
        let struct (v20 : Mut0, v21 : Mut1, v22 : Mut2, v23 : Mut3, v24 : Mut4, v25 : int64 option) = TraceState.trace_state.Value
        let v38 : string = method10(v20, v21, v22, v23, v24, v25)
        let v39 : string = method14()
        let v40 : string = method18(v20, v21, v22, v23, v24, v25, v38, v39, v0, v1)
        method21(v40)
and closure8 (v0 : int32) (v1 : exn) : US5 =
    let v2 : unit = ()
    let v3 : (unit -> unit) = closure9(v0, v1)
    let v4 : unit = (fun () -> v3 (); v2) ()
    US5_1
and method8 (v0 : int32, v1 : (unit -> unit), v2 : int32) : US4 =
    let v3 : (US4 -> US5) = closure6()
    let v4 : (unit -> US4) = closure7(v0, v1, v2)
    let v5 : (exn -> US5) = closure8(v2)
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
        method8(v0, v1, v12)
    | US5_0(v11) -> (* Some *)
        v11
and closure5 (v0 : int32) (v1 : (unit -> unit)) : unit option =
    let v2 : int32 = 0
    let v3 : US4 = method8(v0, v1, v2)
    match v3 with
    | US4_1 -> (* None *)
        let v7 : unit option = None
        v7
    | US4_0 -> (* Some *)
        let v4 : unit option = Some () 
        v4
and closure4 () (v0 : int32) : ((unit -> unit) -> unit option) =
    closure5(v0)
and method22 (v0 : (unit -> unit)) : (unit -> unit) =
    v0
and closure16 (v0 : Lazy<unit>) () : unit =
    v0.Value
    ()
and closure15 () (v0 : (unit -> unit)) : (unit -> unit) =
    let v1 : (unit -> unit) = method22(v0)
    let v2 : Lazy<unit> = lazy v1 ()
    closure16(v2)
let v0 : unit = ()
let v1 : (unit -> unit) = closure0()
let v2 : unit = (fun () -> v1 (); v0) ()
let v16 : ((unit -> unit) -> System.IDisposable) = closure3()
let new_disposable x = v16 x
let v17 : (int32 -> ((unit -> unit) -> unit option)) = closure4()
let retry_fn x = v17 x
let v18 : ((unit -> unit) -> (unit -> unit)) = closure15()
let memoize x = v18 x
()
