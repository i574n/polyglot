#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("*/ $0 /*")>]
#endif
type TypeEmit<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("&$0")>]
type Ref<'T> = class end
#else
type Ref<'T> = 'T
#endif

#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("near_sdk::store::LookupMap<$0, $1>")>]
#endif
type near_sdk_store_LookupMap<'K, 'V> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::string::String")>]
type std_string_String = class end
#else
type std_string_String = string
#endif

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
type Str = class end
#else
type Str = string
#endif

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
and closure4 () (v0 : string) : US1 =
    US1_0(v0)
and method4 () : (string -> US1) =
    closure4()
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
and closure5 () (v0 : string) : unit =
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
    let v417 : (string -> unit) = closure5()
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
and closure3 () () : unit =
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
    
    
    
    
    
    let v0 : string = "Debug"
    let v1 : (unit -> string) = v0.ToLower
    let v2 : string = v1 ()
    let v5 : string = v2.PadLeft (7, ' ')
    let v19 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v20 : string = "inline_colorization::color_bright_blue"
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
    let v49 : string = "inline_colorization::color_bright_blue"
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
    let v78 : string = "inline_colorization::color_bright_blue"
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
    let v107 : string = "\u001b[94m"
    let v108 : string = method11()
    let v109 : string = v107 + v5 
    let v110 : string = v109 + v108 
    let _v19 = v110 
    #endif
#if FABLE_COMPILER_PYTHON
    let v111 : string = "\u001b[94m"
    let v112 : string = method11()
    let v113 : string = v111 + v5 
    let v114 : string = v113 + v112 
    let _v19 = v114 
    #endif
#else
    let v115 : string = "\u001b[94m"
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
and method12 (v0 : std_string_String, v1 : uint64, v2 : std_string_String) : string =
    let v3 : string = method13()
    let v4 : Mut3 = {l0 = v3} : Mut3
    let v5 : string = "{ "
    let v6 : string = $"{v5}"
    let v9 : unit = ()
    let v10 : (unit -> unit) = closure7(v4, v6)
    let v11 : unit = (fun () -> v10 (); v9) ()
    let v14 : string = "alias"
    let v15 : string = $"{v14}"
    let v18 : unit = ()
    let v19 : (unit -> unit) = closure7(v4, v15)
    let v20 : unit = (fun () -> v19 (); v18) ()
    let v23 : string = " = "
    let v24 : string = $"{v23}"
    let v27 : unit = ()
    let v28 : (unit -> unit) = closure7(v4, v24)
    let v29 : unit = (fun () -> v28 (); v27) ()
    let v32 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v33 : string = "format!(\"{:#?}\", $0)"
    let v34 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v33 
    let v35 : string = "fable_library_rust::String_::fromString($0)"
    let v36 : string = Fable.Core.RustInterop.emitRustExpr v34 v35 
    let _v32 = v36 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v37 : string = "format!(\"{:#?}\", $0)"
    let v38 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v37 
    let v39 : string = "fable_library_rust::String_::fromString($0)"
    let v40 : string = Fable.Core.RustInterop.emitRustExpr v38 v39 
    let _v32 = v40 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v41 : string = "format!(\"{:#?}\", $0)"
    let v42 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v41 
    let v43 : string = "fable_library_rust::String_::fromString($0)"
    let v44 : string = Fable.Core.RustInterop.emitRustExpr v42 v43 
    let _v32 = v44 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v45 : string = $"%A{v0}"
    let _v32 = v45 
    #endif
#if FABLE_COMPILER_PYTHON
    let v48 : string = $"%A{v0}"
    let _v32 = v48 
    #endif
#else
    let v51 : string = $"%A{v0}"
    let _v32 = v51 
    #endif
    let v54 : string = _v32 
    let v59 : string = $"{v54}"
    let v62 : unit = ()
    let v63 : (unit -> unit) = closure7(v4, v59)
    let v64 : unit = (fun () -> v63 (); v62) ()
    let v67 : string = "; "
    let v68 : string = $"{v67}"
    let v71 : unit = ()
    let v72 : (unit -> unit) = closure7(v4, v68)
    let v73 : unit = (fun () -> v72 (); v71) ()
    let v76 : string = "block_timestamp"
    let v77 : string = $"{v76}"
    let v80 : unit = ()
    let v81 : (unit -> unit) = closure7(v4, v77)
    let v82 : unit = (fun () -> v81 (); v80) ()
    let v85 : string = $"{v23}"
    let v88 : unit = ()
    let v89 : (unit -> unit) = closure7(v4, v85)
    let v90 : unit = (fun () -> v89 (); v88) ()
    let v93 : string = $"{v1}"
    let v96 : unit = ()
    let v97 : (unit -> unit) = closure7(v4, v93)
    let v98 : unit = (fun () -> v97 (); v96) ()
    let v101 : string = $"{v67}"
    let v104 : unit = ()
    let v105 : (unit -> unit) = closure7(v4, v101)
    let v106 : unit = (fun () -> v105 (); v104) ()
    let v109 : string = "account_id"
    let v110 : string = $"{v109}"
    let v113 : unit = ()
    let v114 : (unit -> unit) = closure7(v4, v110)
    let v115 : unit = (fun () -> v114 (); v113) ()
    let v118 : string = $"{v23}"
    let v121 : unit = ()
    let v122 : (unit -> unit) = closure7(v4, v118)
    let v123 : unit = (fun () -> v122 (); v121) ()
    let v126 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v127 : string = "format!(\"{:#?}\", $0)"
    let v128 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v127 
    let v129 : string = "fable_library_rust::String_::fromString($0)"
    let v130 : string = Fable.Core.RustInterop.emitRustExpr v128 v129 
    let _v126 = v130 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v131 : string = "format!(\"{:#?}\", $0)"
    let v132 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v131 
    let v133 : string = "fable_library_rust::String_::fromString($0)"
    let v134 : string = Fable.Core.RustInterop.emitRustExpr v132 v133 
    let _v126 = v134 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v135 : string = "format!(\"{:#?}\", $0)"
    let v136 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v135 
    let v137 : string = "fable_library_rust::String_::fromString($0)"
    let v138 : string = Fable.Core.RustInterop.emitRustExpr v136 v137 
    let _v126 = v138 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v139 : string = $"%A{v2}"
    let _v126 = v139 
    #endif
#if FABLE_COMPILER_PYTHON
    let v142 : string = $"%A{v2}"
    let _v126 = v142 
    #endif
#else
    let v145 : string = $"%A{v2}"
    let _v126 = v145 
    #endif
    let v148 : string = _v126 
    let v153 : string = $"{v148}"
    let v156 : unit = ()
    let v157 : (unit -> unit) = closure7(v4, v153)
    let v158 : unit = (fun () -> v157 (); v156) ()
    let v161 : string = " }"
    let v162 : string = $"{v161}"
    let v165 : unit = ()
    let v166 : (unit -> unit) = closure7(v4, v162)
    let v167 : unit = (fun () -> v166 (); v165) ()
    let v170 : string = v4.l0
    v170
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
and closure2 (v0 : std_string_String, v1 : near_sdk_AccountId, v2 : uint64) () : unit =
    let v3 : unit = ()
    let v4 : (unit -> unit) = closure3()
    let v5 : unit = (fun () -> v4 (); v3) ()
    let struct (v19 : Mut0, v20 : Mut1, v21 : Mut2, v22 : Mut3, v23 : Mut4, v24 : int64 option) = TraceState.trace_state.Value
    let v37 : US0 = v23.l0
    let v38 : bool = v21.l0
    let v39 : bool = v38 = false
    let v42 : bool =
        if v39 then
            false
        else
            let v40 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v37
            let v41 : bool = 1 >= v40
            v41
    if v42 then
        let v43 : unit = ()
        let v44 : unit = (fun () -> v4 (); v43) ()
        let struct (v58 : Mut0, v59 : Mut1, v60 : Mut2, v61 : Mut3, v62 : Mut4, v63 : int64 option) = TraceState.trace_state.Value
        let v76 : string = method6(v58, v59, v60, v61, v62, v63)
        let v77 : string = method10()
        let v78 : string = $"chat_contract.claim_alias"
        let v79 : bool = v78 = ""
        let v86 : string =
            if v79 then
                let v80 : string = ""
                v80
            else
                let v81 : int64 = v58.l0
                let v82 : string = $"v1.to_string()"
                let v83 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v82 
                let v84 : string = method12(v0, v2, v83)
                method14(v76, v77, v78, v81, v84)
        let v87 : unit = ()
        let v88 : unit = (fun () -> v4 (); v87) ()
        let struct (v102 : Mut0, v103 : Mut1, v104 : Mut2, v105 : Mut3, v106 : Mut4, v107 : int64 option) = TraceState.trace_state.Value
        method15(v86, v102, v103, v104, v105, v106, v107)
and closure11 () (v0 : std_string_String) : US4 =
    US4_0(v0)
and method16 () : (std_string_String -> US4) =
    closure11()
and method17 () : string =
    
    
    
    
    
    let v0 : string = "Warning"
    let v1 : (unit -> string) = v0.ToLower
    let v2 : string = v1 ()
    let v5 : string = v2.PadLeft (7, ' ')
    let v19 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v20 : string = "inline_colorization::color_yellow"
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
    let v49 : string = "inline_colorization::color_yellow"
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
    let v78 : string = "inline_colorization::color_yellow"
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
    let v107 : string = "\u001b[93m"
    let v108 : string = method11()
    let v109 : string = v107 + v5 
    let v110 : string = v109 + v108 
    let _v19 = v110 
    #endif
#if FABLE_COMPILER_PYTHON
    let v111 : string = "\u001b[93m"
    let v112 : string = method11()
    let v113 : string = v111 + v5 
    let v114 : string = v113 + v112 
    let _v19 = v114 
    #endif
#else
    let v115 : string = "\u001b[93m"
    let v116 : string = method11()
    let v117 : string = v115 + v5 
    let v118 : string = v117 + v116 
    let _v19 = v118 
    #endif
    let v119 : string = _v19 
    v119
and method18 (v0 : string) : string =
    let v1 : string = method13()
    let v2 : Mut3 = {l0 = v1} : Mut3
    let v3 : string = "{ "
    let v4 : string = $"{v3}"
    let v7 : unit = ()
    let v8 : (unit -> unit) = closure7(v2, v4)
    let v9 : unit = (fun () -> v8 (); v7) ()
    let v12 : string = "account_alias"
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
and closure12 (v0 : std_string_String) () : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure3()
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
            let v39 : bool = 3 >= v38
            v39
    if v40 then
        let v41 : unit = ()
        let v42 : unit = (fun () -> v2 (); v41) ()
        let struct (v56 : Mut0, v57 : Mut1, v58 : Mut2, v59 : Mut3, v60 : Mut4, v61 : int64 option) = TraceState.trace_state.Value
        let v74 : string = method6(v56, v57, v58, v59, v60, v61)
        let v75 : string = method17()
        let v76 : string = $"chat_contract.claim_alias / alias already claimed"
        let v77 : bool = v76 = ""
        let v85 : string =
            if v77 then
                let v78 : string = ""
                v78
            else
                let v79 : int64 = v56.l0
                let v80 : string = $"%A{v0}"
                let v83 : string = method18(v80)
                method14(v74, v75, v76, v79, v83)
        let v86 : unit = ()
        let v87 : unit = (fun () -> v2 (); v86) ()
        let struct (v101 : Mut0, v102 : Mut1, v103 : Mut2, v104 : Mut3, v105 : Mut4, v106 : int64 option) = TraceState.trace_state.Value
        method15(v85, v101, v102, v103, v104, v105, v106)
and closure13 (v0 : std_string_String option) () : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure3()
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
            let v39 : bool = 1 >= v38
            v39
    if v40 then
        let v41 : unit = ()
        let v42 : unit = (fun () -> v2 (); v41) ()
        let struct (v56 : Mut0, v57 : Mut1, v58 : Mut2, v59 : Mut3, v60 : Mut4, v61 : int64 option) = TraceState.trace_state.Value
        let v74 : string = method6(v56, v57, v58, v59, v60, v61)
        let v75 : string = method10()
        let v76 : string = $"chat_contract.claim_alias"
        let v77 : bool = v76 = ""
        let v85 : string =
            if v77 then
                let v78 : string = ""
                v78
            else
                let v79 : int64 = v56.l0
                let v80 : string = $"%A{v0}"
                let v83 : string = method18(v80)
                method14(v74, v75, v76, v79, v83)
        let v86 : unit = ()
        let v87 : unit = (fun () -> v2 (); v86) ()
        let struct (v101 : Mut0, v102 : Mut1, v103 : Mut2, v104 : Mut3, v105 : Mut4, v106 : int64 option) = TraceState.trace_state.Value
        method15(v85, v101, v102, v103, v104, v105, v106)
and closure14 () () : unit =
    ()
and method19 () : (unit -> unit) =
    closure14()
and method20 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option) : unit =
    let v6 : unit = ()
    let v7 : (unit -> unit) = closure8(v0)
    let v8 : unit = (fun () -> v7 (); v6) ()
    let v11 : string = ""
    let v12 : (string -> unit) = closure9()
    let v13 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v14 : string = @"println!(""{}"", $0)"
    Fable.Core.RustInterop.emitRustExpr v11 v14 
    let _v13 = () 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v15 : string = @"println!(""{}"", $0)"
    Fable.Core.RustInterop.emitRustExpr v11 v15 
    let _v13 = () 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v16 : string = v3.l0
    let v17 : bool = v16 = ""
    let v25 : string =
        if v17 then
            v11
        else
            let v18 : bool = v11 = ""
            if v18 then
                let v19 : string = v3.l0
                v19
            else
                let v20 : string = v3.l0
                let v21 : string = "\n"
                let v22 : string = v20 + v21 
                let v23 : string = v22 + v11 
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
    let v69 : bool = v11 <> v11 
    let v73 : bool =
        if v69 then
            let v72 : bool = v68 <= 1
            v72
        else
            false
    if v73 then
        v3.l0 <- v25
        ()
    else
        v3.l0 <- v11
        let v74 : string = "true; $0.into_iter().for_each(|x| { //"
        let v75 : bool = Fable.Core.RustInterop.emitRustExpr v64 v74 
        let v76 : string = "x"
        let v77 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v76 
        let v78 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
        let v79 : bool = Fable.Core.RustInterop.emitRustExpr v77 v78 
        let v80 : string = $"true"
        let v81 : bool = Fable.Core.RustInterop.emitRustExpr () v80 
        let v82 : string = "true; }); //"
        let v83 : bool = Fable.Core.RustInterop.emitRustExpr () v82 
        ()
    let _v13 = () 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    v12 v11
    let _v13 = () 
    #endif
#if FABLE_COMPILER_PYTHON
    v12 v11
    let _v13 = () 
    #endif
#else
    v12 v11
    let _v13 = () 
    #endif
    _v13 
    let v84 : (string -> unit) = v1.l0
    v84 v11
and closure15 (v0 : (unit -> unit)) () : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure3()
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
            let v39 : bool = 1 >= v38
            v39
    if v40 then
        let v41 : unit = ()
        let v42 : unit = (fun () -> v2 (); v41) ()
        let struct (v56 : Mut0, v57 : Mut1, v58 : Mut2, v59 : Mut3, v60 : Mut4, v61 : int64 option) = TraceState.trace_state.Value
        let v74 : string = method6(v56, v57, v58, v59, v60, v61)
        let v75 : string = method10()
        let v76 : unit = ()
        let v77 : unit = (fun () -> v2 (); v76) ()
        let struct (v91 : Mut0, v92 : Mut1, v93 : Mut2, v94 : Mut3, v95 : Mut4, v96 : int64 option) = TraceState.trace_state.Value
        method20(v91, v92, v93, v94, v95, v96)
and method21 (v0 : near_sdk_AccountId, v1 : struct (std_string_String * uint64 * uint32) option) : string =
    let v2 : string = method13()
    let v3 : Mut3 = {l0 = v2} : Mut3
    let v4 : string = "{ "
    let v5 : string = $"{v4}"
    let v8 : unit = ()
    let v9 : (unit -> unit) = closure7(v3, v5)
    let v10 : unit = (fun () -> v9 (); v8) ()
    let v13 : string = "account_id"
    let v14 : string = $"{v13}"
    let v17 : unit = ()
    let v18 : (unit -> unit) = closure7(v3, v14)
    let v19 : unit = (fun () -> v18 (); v17) ()
    let v22 : string = " = "
    let v23 : string = $"{v22}"
    let v26 : unit = ()
    let v27 : (unit -> unit) = closure7(v3, v23)
    let v28 : unit = (fun () -> v27 (); v26) ()
    let v31 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v32 : string = "format!(\"{:#?}\", $0)"
    let v33 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v32 
    let v34 : string = "fable_library_rust::String_::fromString($0)"
    let v35 : string = Fable.Core.RustInterop.emitRustExpr v33 v34 
    let _v31 = v35 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v36 : string = "format!(\"{:#?}\", $0)"
    let v37 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v36 
    let v38 : string = "fable_library_rust::String_::fromString($0)"
    let v39 : string = Fable.Core.RustInterop.emitRustExpr v37 v38 
    let _v31 = v39 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v40 : string = "format!(\"{:#?}\", $0)"
    let v41 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v40 
    let v42 : string = "fable_library_rust::String_::fromString($0)"
    let v43 : string = Fable.Core.RustInterop.emitRustExpr v41 v42 
    let _v31 = v43 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v44 : string = $"%A{v0}"
    let _v31 = v44 
    #endif
#if FABLE_COMPILER_PYTHON
    let v47 : string = $"%A{v0}"
    let _v31 = v47 
    #endif
#else
    let v50 : string = $"%A{v0}"
    let _v31 = v50 
    #endif
    let v53 : string = _v31 
    let v58 : string = $"{v53}"
    let v61 : unit = ()
    let v62 : (unit -> unit) = closure7(v3, v58)
    let v63 : unit = (fun () -> v62 (); v61) ()
    let v66 : string = "; "
    let v67 : string = $"{v66}"
    let v70 : unit = ()
    let v71 : (unit -> unit) = closure7(v3, v67)
    let v72 : unit = (fun () -> v71 (); v70) ()
    let v75 : string = "result"
    let v76 : string = $"{v75}"
    let v79 : unit = ()
    let v80 : (unit -> unit) = closure7(v3, v76)
    let v81 : unit = (fun () -> v80 (); v79) ()
    let v84 : string = $"{v22}"
    let v87 : unit = ()
    let v88 : (unit -> unit) = closure7(v3, v84)
    let v89 : unit = (fun () -> v88 (); v87) ()
    let v92 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v93 : string = "format!(\"{:#?}\", $0)"
    let v94 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1 v93 
    let v95 : string = "fable_library_rust::String_::fromString($0)"
    let v96 : string = Fable.Core.RustInterop.emitRustExpr v94 v95 
    let _v92 = v96 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v97 : string = "format!(\"{:#?}\", $0)"
    let v98 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1 v97 
    let v99 : string = "fable_library_rust::String_::fromString($0)"
    let v100 : string = Fable.Core.RustInterop.emitRustExpr v98 v99 
    let _v92 = v100 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v101 : string = "format!(\"{:#?}\", $0)"
    let v102 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1 v101 
    let v103 : string = "fable_library_rust::String_::fromString($0)"
    let v104 : string = Fable.Core.RustInterop.emitRustExpr v102 v103 
    let _v92 = v104 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v105 : string = $"%A{v1}"
    let _v92 = v105 
    #endif
#if FABLE_COMPILER_PYTHON
    let v108 : string = $"%A{v1}"
    let _v92 = v108 
    #endif
#else
    let v111 : string = $"%A{v1}"
    let _v92 = v111 
    #endif
    let v114 : string = _v92 
    let v119 : string = $"{v114}"
    let v122 : unit = ()
    let v123 : (unit -> unit) = closure7(v3, v119)
    let v124 : unit = (fun () -> v123 (); v122) ()
    let v127 : string = " }"
    let v128 : string = $"{v127}"
    let v131 : unit = ()
    let v132 : (unit -> unit) = closure7(v3, v128)
    let v133 : unit = (fun () -> v132 (); v131) ()
    let v136 : string = v3.l0
    v136
and closure16 (v0 : near_sdk_AccountId, v1 : struct (std_string_String * uint64 * uint32) option) () : unit =
    let v2 : unit = ()
    let v3 : (unit -> unit) = closure3()
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
            let v40 : bool = 1 >= v39
            v40
    if v41 then
        let v42 : unit = ()
        let v43 : unit = (fun () -> v3 (); v42) ()
        let struct (v57 : Mut0, v58 : Mut1, v59 : Mut2, v60 : Mut3, v61 : Mut4, v62 : int64 option) = TraceState.trace_state.Value
        let v75 : string = method6(v57, v58, v59, v60, v61, v62)
        let v76 : string = method10()
        let v77 : string = $"chat_contract.get_account_info"
        let v78 : bool = v77 = ""
        let v83 : string =
            if v78 then
                let v79 : string = ""
                v79
            else
                let v80 : int64 = v57.l0
                let v81 : string = method21(v0, v1)
                method14(v75, v76, v77, v80, v81)
        let v84 : unit = ()
        let v85 : unit = (fun () -> v3 (); v84) ()
        let struct (v99 : Mut0, v100 : Mut1, v101 : Mut2, v102 : Mut3, v103 : Mut4, v104 : int64 option) = TraceState.trace_state.Value
        method15(v83, v99, v100, v101, v102, v103, v104)
and closure17 () () : unit =
    let v0 : unit = ()
    let v1 : (unit -> unit) = closure3()
    let v2 : unit = (fun () -> v1 (); v0) ()
    let struct (v16 : Mut0, v17 : Mut1, v18 : Mut2, v19 : Mut3, v20 : Mut4, v21 : int64 option) = TraceState.trace_state.Value
    let v34 : US0 = v20.l0
    let v35 : bool = v18.l0
    let v36 : bool = v35 = false
    let v39 : bool =
        if v36 then
            false
        else
            let v37 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v34
            let v38 : bool = 1 >= v37
            v38
    if v39 then
        let v40 : unit = ()
        let v41 : unit = (fun () -> v1 (); v40) ()
        let struct (v55 : Mut0, v56 : Mut1, v57 : Mut2, v58 : Mut3, v59 : Mut4, v60 : int64 option) = TraceState.trace_state.Value
        let v73 : string = method6(v55, v56, v57, v58, v59, v60)
        let v74 : string = method10()
        let v75 : unit = ()
        let v76 : unit = (fun () -> v1 (); v75) ()
        let struct (v90 : Mut0, v91 : Mut1, v92 : Mut2, v93 : Mut3, v94 : Mut4, v95 : int64 option) = TraceState.trace_state.Value
        method20(v90, v91, v92, v93, v94, v95)
and method22 (v0 : std_string_String) : string =
    let v1 : string = method13()
    let v2 : Mut3 = {l0 = v1} : Mut3
    let v3 : string = "{ "
    let v4 : string = $"{v3}"
    let v7 : unit = ()
    let v8 : (unit -> unit) = closure7(v2, v4)
    let v9 : unit = (fun () -> v8 (); v7) ()
    let v12 : string = "alias"
    let v13 : string = $"{v12}"
    let v16 : unit = ()
    let v17 : (unit -> unit) = closure7(v2, v13)
    let v18 : unit = (fun () -> v17 (); v16) ()
    let v21 : string = " = "
    let v22 : string = $"{v21}"
    let v25 : unit = ()
    let v26 : (unit -> unit) = closure7(v2, v22)
    let v27 : unit = (fun () -> v26 (); v25) ()
    let v30 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v31 : string = "format!(\"{:#?}\", $0)"
    let v32 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v31 
    let v33 : string = "fable_library_rust::String_::fromString($0)"
    let v34 : string = Fable.Core.RustInterop.emitRustExpr v32 v33 
    let _v30 = v34 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v35 : string = "format!(\"{:#?}\", $0)"
    let v36 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v35 
    let v37 : string = "fable_library_rust::String_::fromString($0)"
    let v38 : string = Fable.Core.RustInterop.emitRustExpr v36 v37 
    let _v30 = v38 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v39 : string = "format!(\"{:#?}\", $0)"
    let v40 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v39 
    let v41 : string = "fable_library_rust::String_::fromString($0)"
    let v42 : string = Fable.Core.RustInterop.emitRustExpr v40 v41 
    let _v30 = v42 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v43 : string = $"%A{v0}"
    let _v30 = v43 
    #endif
#if FABLE_COMPILER_PYTHON
    let v46 : string = $"%A{v0}"
    let _v30 = v46 
    #endif
#else
    let v49 : string = $"%A{v0}"
    let _v30 = v49 
    #endif
    let v52 : string = _v30 
    let v57 : string = $"{v52}"
    let v60 : unit = ()
    let v61 : (unit -> unit) = closure7(v2, v57)
    let v62 : unit = (fun () -> v61 (); v60) ()
    let v65 : string = " }"
    let v66 : string = $"{v65}"
    let v69 : unit = ()
    let v70 : (unit -> unit) = closure7(v2, v66)
    let v71 : unit = (fun () -> v70 (); v69) ()
    let v74 : string = v2.l0
    v74
and closure18 (v0 : std_string_String) () : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure3()
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
            let v39 : bool = 1 >= v38
            v39
    if v40 then
        let v41 : unit = ()
        let v42 : unit = (fun () -> v2 (); v41) ()
        let struct (v56 : Mut0, v57 : Mut1, v58 : Mut2, v59 : Mut3, v60 : Mut4, v61 : int64 option) = TraceState.trace_state.Value
        let v74 : string = method6(v56, v57, v58, v59, v60, v61)
        let v75 : string = method10()
        let v76 : string = $"chat_contract.get_alias_map"
        let v77 : bool = v76 = ""
        let v82 : string =
            if v77 then
                let v78 : string = ""
                v78
            else
                let v79 : int64 = v56.l0
                let v80 : string = method22(v0)
                method14(v74, v75, v76, v79, v80)
        let v83 : unit = ()
        let v84 : unit = (fun () -> v2 (); v83) ()
        let struct (v98 : Mut0, v99 : Mut1, v100 : Mut2, v101 : Mut3, v102 : Mut4, v103 : int64 option) = TraceState.trace_state.Value
        method15(v82, v98, v99, v100, v101, v102, v103)
and method23 () : (unit -> unit) =
    closure14()
and closure19 (v0 : (unit -> unit)) () : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure3()
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
            let v39 : bool = 1 >= v38
            v39
    if v40 then
        let v41 : unit = ()
        let v42 : unit = (fun () -> v2 (); v41) ()
        let struct (v56 : Mut0, v57 : Mut1, v58 : Mut2, v59 : Mut3, v60 : Mut4, v61 : int64 option) = TraceState.trace_state.Value
        let v74 : string = method6(v56, v57, v58, v59, v60, v61)
        let v75 : string = method10()
        let v76 : unit = ()
        let v77 : unit = (fun () -> v2 (); v76) ()
        let struct (v91 : Mut0, v92 : Mut1, v93 : Mut2, v94 : Mut3, v95 : Mut4, v96 : int64 option) = TraceState.trace_state.Value
        method20(v91, v92, v93, v94, v95, v96)
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
    let v90 : bool =
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
                        let v58 : unit = ()
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v59 : string = "&*$0"
                        let v60 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v47 v59 
                        let _v58 = v60 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        let v61 : string = "&*$0"
                        let v62 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v47 v61 
                        let _v58 = v62 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        let v63 : string = "&*$0"
                        let v64 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v47 v63 
                        let _v58 = v64 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        let v65 : Ref<Str> = v47 |> unbox<Ref<Str>>
                        let _v58 = v65 
                        #endif
#if FABLE_COMPILER_PYTHON
                        let v68 : Ref<Str> = v47 |> unbox<Ref<Str>>
                        let _v58 = v68 
                        #endif
#else
                        let v71 : Ref<Str> = v47 |> unbox<Ref<Str>>
                        let _v58 = v71 
                        #endif
                        let v74 : Ref<Str> = _v58 
                        let v79 : string = $"$0.chars()"
                        let v80 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v74 v79 
                        let v81 : string = "true; // 1"
                        let v82 : bool = Fable.Core.RustInterop.emitRustExpr () v81 
                        let v83 : string = "let mut v80 = v80"
                        Fable.Core.RustInterop.emitRustExpr () v83 
                        let v84 : string = $"v80.all(|x| $0(x))"
                        let v85 : (char -> bool) = closure1()
                        let v86 : bool = Fable.Core.RustInterop.emitRustExpr v85 v84 
                        v86
                    else
                        false
                else
                    false
            else
                false
        else
            false
    let _result = v90 in _result |> (fun x -> Fable.Core.RustInterop.emitRustExpr x "$0 }") // 2
    let v91 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v91 
    let v92 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v92 
    let v93 : string = "true; // ??? / i: 2uy / i': 1uy / acc: 2uy / n: 1uy"
    let v94 : bool = Fable.Core.RustInterop.emitRustExpr () v93 
    let v95 : string = "true; */ // ???? / i: 2uy / i': 2uy / acc: 2uy / n: 1uy"
    let v96 : bool = Fable.Core.RustInterop.emitRustExpr () v95 
    let v97 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v97 
    let v98 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v98 
    let v99 : string = "pub fn generate_cid( //"
    Fable.Core.RustInterop.emitRustExpr () v99 
    let v100 : string = "  &self, //"
    Fable.Core.RustInterop.emitRustExpr () v100 
    let v101 : string = "  content: Vec<u8>, //"
    Fable.Core.RustInterop.emitRustExpr () v101 
    let v102 : string = ") -> String { //"
    Fable.Core.RustInterop.emitRustExpr () v102 
    let v103 : string = $"content"
    let v104 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v103 
    let v105 : string = "  fn encode_u64(value: u64) -> Vec<u8> { //"
    Fable.Core.RustInterop.emitRustExpr () v105 
    let v106 : string = "    let mut buffer = unsigned_varint::encode::u64_buffer(); //"
    Fable.Core.RustInterop.emitRustExpr () v106 
    let v107 : string = "    unsigned_varint::encode::u64(value, &mut buffer).to_vec() //"
    Fable.Core.RustInterop.emitRustExpr () v107 
    let v108 : string = "  } //"
    Fable.Core.RustInterop.emitRustExpr () v108 
    let v109 : string = "  fn sha256_hash(content: &[u8]) -> Vec<u8> { //"
    Fable.Core.RustInterop.emitRustExpr () v109 
    let v110 : string = "    let mut hasher: sha2::Sha256 = sha2::Digest::new(); //"
    Fable.Core.RustInterop.emitRustExpr () v110 
    let v111 : string = "    sha2::Digest::update(&mut hasher, content); //"
    Fable.Core.RustInterop.emitRustExpr () v111 
    let v112 : string = "    sha2::Digest::finalize(hasher).to_vec() //"
    Fable.Core.RustInterop.emitRustExpr () v112 
    let v113 : string = "  } //"
    Fable.Core.RustInterop.emitRustExpr () v113 
    let v114 : string = "  let version: u8 = 1; //"
    Fable.Core.RustInterop.emitRustExpr () v114 
    let v115 : string = "  let codec_raw: u64 = 0x55; //"
    Fable.Core.RustInterop.emitRustExpr () v115 
    let v116 : string = "  let codec_bytes = encode_u64(codec_raw); //"
    Fable.Core.RustInterop.emitRustExpr () v116 
    let v117 : string = "  let hash_result = sha256_hash(&v104); //"
    Fable.Core.RustInterop.emitRustExpr () v117 
    let v118 : string = "  let multihash = std::iter::once(0x12) //"
    Fable.Core.RustInterop.emitRustExpr () v118 
    let v119 : string = "    .chain(std::iter::once(32)) //"
    Fable.Core.RustInterop.emitRustExpr () v119 
    let v120 : string = "    .chain(hash_result.into_iter()) //"
    Fable.Core.RustInterop.emitRustExpr () v120 
    let v121 : string = "    .collect(); //"
    Fable.Core.RustInterop.emitRustExpr () v121 
    let v122 : string = "  let cid_bytes = [vec![version], codec_bytes, multihash].concat(); //"
    Fable.Core.RustInterop.emitRustExpr () v122 
    let v123 : string = "  let result = multibase::encode(multibase::Base::Base32Lower, &cid_bytes); //"
    Fable.Core.RustInterop.emitRustExpr () v123 
    let v124 : string = "result"
    let v125 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v124 
    let _result = v125 in _result |> (fun x -> Fable.Core.RustInterop.emitRustExpr x "$0 }") // 2
    let v126 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v126 
    let v127 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v127 
    let v128 : string = "true; // ??? / i: 3uy / i': 1uy / acc: 3uy / n: 2uy"
    let v129 : bool = Fable.Core.RustInterop.emitRustExpr () v128 
    let v130 : string = "true; */ // ???? / i: 3uy / i': 2uy / acc: 3uy / n: 2uy"
    let v131 : bool = Fable.Core.RustInterop.emitRustExpr () v130 
    let v132 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v132 
    let v133 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v133 
    let v134 : string = "#[result_serializer(borsh)] //"
    Fable.Core.RustInterop.emitRustExpr () v134 
    let v135 : string = "pub fn generate_cid_borsh( //"
    Fable.Core.RustInterop.emitRustExpr () v135 
    let v136 : string = "  &self, //"
    Fable.Core.RustInterop.emitRustExpr () v136 
    let v137 : string = "  #[serializer(borsh)] content: Vec<u8>, //"
    Fable.Core.RustInterop.emitRustExpr () v137 
    let v138 : string = ") -> String { //"
    Fable.Core.RustInterop.emitRustExpr () v138 
    let v139 : string = "  self.generate_cid(content) //"
    Fable.Core.RustInterop.emitRustExpr () v139 
    let v140 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v140 
    let v141 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v141 
    let v142 : string = "true; // ??? / i: 4uy / i': 1uy / acc: 5uy / n: 1uy"
    let v143 : bool = Fable.Core.RustInterop.emitRustExpr () v142 
    let v144 : string = "true; */ // ???? / i: 4uy / i': 2uy / acc: 5uy / n: 1uy"
    let v145 : bool = Fable.Core.RustInterop.emitRustExpr () v144 
    let v146 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v146 
    let v147 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v147 
    let v148 : string = "pub fn claim_alias( //"
    Fable.Core.RustInterop.emitRustExpr () v148 
    let v149 : string = "  &mut self, //"
    Fable.Core.RustInterop.emitRustExpr () v149 
    let v150 : string = "  alias: String, //"
    Fable.Core.RustInterop.emitRustExpr () v150 
    let v151 : string = ") { //"
    Fable.Core.RustInterop.emitRustExpr () v151 
    let v152 : string = $"&mut self.0"
    let v153 : Ref<Mut<struct (uint32 * near_sdk_store_LookupMap<std_string_String, std_collections_HashMap<near_sdk_AccountId, struct (uint64 * uint32)>> * near_sdk_store_LookupMap<near_sdk_AccountId, std_string_String>)>> = Fable.Core.RustInterop.emitRustExpr () v152 
    let v154 : string = $"alias"
    let v155 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v154 
    let v156 : string = $"&mut v153.2"
    let v157 : Ref<Mut<near_sdk_store_LookupMap<near_sdk_AccountId, std_string_String>>> = Fable.Core.RustInterop.emitRustExpr () v156 
    let v158 : string = $"&mut v153.1"
    let v159 : Ref<Mut<near_sdk_store_LookupMap<std_string_String, std_collections_HashMap<near_sdk_AccountId, struct (uint64 * uint32)>>>> = Fable.Core.RustInterop.emitRustExpr () v158 
    let v160 : string = $"near_sdk::env::signer_account_id()"
    let v161 : near_sdk_AccountId = Fable.Core.RustInterop.emitRustExpr () v160 
    let v162 : string = $"near_sdk::env::block_timestamp()"
    let v163 : uint64 = Fable.Core.RustInterop.emitRustExpr () v162 
    let v164 : unit = ()
    let v165 : (unit -> unit) = closure2(v155, v161, v163)
    let v166 : unit = (fun () -> v165 (); v164) ()
    let v284 : string = "fable_library_rust::String_::fromString($0)"
    let v285 : string = Fable.Core.RustInterop.emitRustExpr v155 v284 
    let v286 : int32 = v285.Length
    let v287 : bool = v286 > 0
    let v328 : bool =
        if v287 then
            let v288 : bool = v286 < 64
            if v288 then
                let v289 : string = "-"
                let v290 : bool = v285.StartsWith v289 
                let v293 : bool = v290 = false
                if v293 then
                    let v294 : bool = v285.EndsWith v289 
                    let v295 : bool = v294 = false
                    if v295 then
                        let v296 : unit = ()
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v297 : string = "&*$0"
                        let v298 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v285 v297 
                        let _v296 = v298 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        let v299 : string = "&*$0"
                        let v300 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v285 v299 
                        let _v296 = v300 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        let v301 : string = "&*$0"
                        let v302 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v285 v301 
                        let _v296 = v302 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        let v303 : Ref<Str> = v285 |> unbox<Ref<Str>>
                        let _v296 = v303 
                        #endif
#if FABLE_COMPILER_PYTHON
                        let v306 : Ref<Str> = v285 |> unbox<Ref<Str>>
                        let _v296 = v306 
                        #endif
#else
                        let v309 : Ref<Str> = v285 |> unbox<Ref<Str>>
                        let _v296 = v309 
                        #endif
                        let v312 : Ref<Str> = _v296 
                        let v317 : string = $"$0.chars()"
                        let v318 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v312 v317 
                        let v319 : string = "true; // 1"
                        let v320 : bool = Fable.Core.RustInterop.emitRustExpr () v319 
                        let v321 : string = "let mut v318 = v318"
                        Fable.Core.RustInterop.emitRustExpr () v321 
                        let v322 : string = $"v318.all(|x| $0(x))"
                        let v323 : (char -> bool) = closure1()
                        let v324 : bool = Fable.Core.RustInterop.emitRustExpr v323 v322 
                        v324
                    else
                        false
                else
                    false
            else
                false
        else
            false
    let v329 : bool = v328 = false
    let v333 : bool =
        if v329 then
            let v330 : string = $"true; near_sdk::env::panic_str(&*$0); //"
            let v331 : string = "chat_contract.claim_alias / invalid alias"
            let v332 : bool = Fable.Core.RustInterop.emitRustExpr v331 v330 
            true
        else
            false
    let v334 : string = $"v157.get(&$0)"
    let v335 : Ref<std_string_String> option = Fable.Core.RustInterop.emitRustExpr v161 v334 
    let v336 : string = "$0.cloned()"
    let v337 : std_string_String option = Fable.Core.RustInterop.emitRustExpr v335 v336 
    let v338 : (std_string_String -> US4) = method16()
    let v339 : US4 option = v337 |> Option.map v338 
    let v350 : US4 = US4_1
    let v351 : US4 = v339 |> Option.defaultValue v350 
    match v351 with
    | US4_0(v355) -> (* Some *)
        let v356 : bool = v355 = v155 
        if v356 then
            let v359 : unit = ()
            let v360 : (unit -> unit) = closure12(v355)
            let v361 : unit = (fun () -> v360 (); v359) ()
            ()
        else
            let v480 : unit = ()
            let v481 : (unit -> unit) = closure13(v337)
            let v482 : unit = (fun () -> v481 (); v480) ()
            let v601 : string = "    v159 //"
            Fable.Core.RustInterop.emitRustExpr () v601 
            let v602 : string = "      .get_mut(&v355) //"
            Fable.Core.RustInterop.emitRustExpr () v602 
            let v603 : string = "      .unwrap() //"
            Fable.Core.RustInterop.emitRustExpr () v603 
            let v604 : string = "      .remove(&$0); //"
            Fable.Core.RustInterop.emitRustExpr v161 v604 
            let v605 : string = "  v157.insert($0.clone(), v155.clone()); //"
            Fable.Core.RustInterop.emitRustExpr v161 v605 
            let v606 : string = "  let new_alias_account_map = match v159.get(&v155) { //"
            Fable.Core.RustInterop.emitRustExpr () v606 
            let v607 : string = "    None => { //"
            Fable.Core.RustInterop.emitRustExpr () v607 
            let v608 : string = "      let mut new_map = std::collections::HashMap::new(); //"
            Fable.Core.RustInterop.emitRustExpr () v608 
            let v609 : string = "      new_map.insert($0, ($1, 0u32)); //"
            Fable.Core.RustInterop.emitRustExpr struct (v161, v163) v609 
            let v610 : string = "      new_map //"
            Fable.Core.RustInterop.emitRustExpr () v610 
            let v611 : string = "    } //"
            Fable.Core.RustInterop.emitRustExpr () v611 
            let v612 : string = "    Some(accounts) => { //"
            Fable.Core.RustInterop.emitRustExpr () v612 
            let v613 : string = "      let mut accounts_vec = accounts.iter().collect::<Vec<_>>(); //"
            Fable.Core.RustInterop.emitRustExpr () v613 
            let v614 : string = "      accounts_vec.sort_unstable_by_key(|(_, (_, index))| index); //"
            Fable.Core.RustInterop.emitRustExpr () v614 
            let v615 : string = "      let mut new_map = accounts_vec //"
            Fable.Core.RustInterop.emitRustExpr () v615 
            let v616 : string = "        .iter() //"
            Fable.Core.RustInterop.emitRustExpr () v616 
            let v617 : string = "        .enumerate() //"
            Fable.Core.RustInterop.emitRustExpr () v617 
            let v618 : string = "        .map(|(i, (account_id, (timestamp, _)))| { //"
            Fable.Core.RustInterop.emitRustExpr () v618 
            let v619 : string = "          ((*account_id).clone(), (*timestamp, i as u32)) //"
            Fable.Core.RustInterop.emitRustExpr () v619 
            let v620 : string = "        }) //"
            Fable.Core.RustInterop.emitRustExpr () v620 
            let v621 : string = "        .collect::<std::collections::HashMap<_, _>>(); //"
            Fable.Core.RustInterop.emitRustExpr () v621 
            let v622 : string = "      new_map.insert(v161, (v163, accounts_vec.len() as u32)); //"
            Fable.Core.RustInterop.emitRustExpr () v622 
            let v623 : string = "      new_map //"
            Fable.Core.RustInterop.emitRustExpr () v623 
            let v624 : string = "    } //"
            Fable.Core.RustInterop.emitRustExpr () v624 
            let v625 : string = "  }; //"
            Fable.Core.RustInterop.emitRustExpr () v625 
            let v626 : string = "  v159.insert(v155, new_alias_account_map); //"
            Fable.Core.RustInterop.emitRustExpr () v626 
            ()
    | _ ->
        let v627 : unit = ()
        let v628 : (unit -> unit) = closure13(v337)
        let v629 : unit = (fun () -> v628 (); v627) ()
        match v351 with
        | US4_1 -> (* None *)
            ()
        let v748 : string = "  v157.insert($0.clone(), v155.clone()); //"
        Fable.Core.RustInterop.emitRustExpr v161 v748 
        let v749 : string = "  let new_alias_account_map = match v159.get(&v155) { //"
        Fable.Core.RustInterop.emitRustExpr () v749 
        let v750 : string = "    None => { //"
        Fable.Core.RustInterop.emitRustExpr () v750 
        let v751 : string = "      let mut new_map = std::collections::HashMap::new(); //"
        Fable.Core.RustInterop.emitRustExpr () v751 
        let v752 : string = "      new_map.insert($0, ($1, 0u32)); //"
        Fable.Core.RustInterop.emitRustExpr struct (v161, v163) v752 
        let v753 : string = "      new_map //"
        Fable.Core.RustInterop.emitRustExpr () v753 
        let v754 : string = "    } //"
        Fable.Core.RustInterop.emitRustExpr () v754 
        let v755 : string = "    Some(accounts) => { //"
        Fable.Core.RustInterop.emitRustExpr () v755 
        let v756 : string = "      let mut accounts_vec = accounts.iter().collect::<Vec<_>>(); //"
        Fable.Core.RustInterop.emitRustExpr () v756 
        let v757 : string = "      accounts_vec.sort_unstable_by_key(|(_, (_, index))| index); //"
        Fable.Core.RustInterop.emitRustExpr () v757 
        let v758 : string = "      let mut new_map = accounts_vec //"
        Fable.Core.RustInterop.emitRustExpr () v758 
        let v759 : string = "        .iter() //"
        Fable.Core.RustInterop.emitRustExpr () v759 
        let v760 : string = "        .enumerate() //"
        Fable.Core.RustInterop.emitRustExpr () v760 
        let v761 : string = "        .map(|(i, (account_id, (timestamp, _)))| { //"
        Fable.Core.RustInterop.emitRustExpr () v761 
        let v762 : string = "          ((*account_id).clone(), (*timestamp, i as u32)) //"
        Fable.Core.RustInterop.emitRustExpr () v762 
        let v763 : string = "        }) //"
        Fable.Core.RustInterop.emitRustExpr () v763 
        let v764 : string = "        .collect::<std::collections::HashMap<_, _>>(); //"
        Fable.Core.RustInterop.emitRustExpr () v764 
        let v765 : string = "      new_map.insert(v161, (v163, accounts_vec.len() as u32)); //"
        Fable.Core.RustInterop.emitRustExpr () v765 
        let v766 : string = "      new_map //"
        Fable.Core.RustInterop.emitRustExpr () v766 
        let v767 : string = "    } //"
        Fable.Core.RustInterop.emitRustExpr () v767 
        let v768 : string = "  }; //"
        Fable.Core.RustInterop.emitRustExpr () v768 
        let v769 : string = "  v159.insert(v155, new_alias_account_map); //"
        Fable.Core.RustInterop.emitRustExpr () v769 
        ()
    let v770 : (unit -> unit) = method19()
    let v771 : unit = ()
    let v772 : (unit -> unit) = closure15(v770)
    let v773 : unit = (fun () -> v772 (); v771) ()
    let v882 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v882 
    let v883 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v883 
    let v884 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v884 
    let v885 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v885 
    let v886 : string = "true; // ??? / i: 5uy / i': 1uy / acc: 6uy / n: 3uy"
    let v887 : bool = Fable.Core.RustInterop.emitRustExpr () v886 
    let v888 : string = "true; */ // ???? / i: 5uy / i': 2uy / acc: 6uy / n: 3uy"
    let v889 : bool = Fable.Core.RustInterop.emitRustExpr () v888 
    let v890 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v890 
    let v891 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v891 
    let v892 : string = "pub fn get_account_info( //"
    Fable.Core.RustInterop.emitRustExpr () v892 
    let v893 : string = "  &self, //"
    Fable.Core.RustInterop.emitRustExpr () v893 
    let v894 : string = "  account_id: near_sdk::AccountId, //"
    Fable.Core.RustInterop.emitRustExpr () v894 
    let v895 : string = ") -> Option<(String, u64, u32)> { //"
    Fable.Core.RustInterop.emitRustExpr () v895 
    let v896 : string = $"&self.0"
    let v897 : Ref<struct (uint32 * near_sdk_store_LookupMap<std_string_String, std_collections_HashMap<near_sdk_AccountId, struct (uint64 * uint32)>> * near_sdk_store_LookupMap<near_sdk_AccountId, std_string_String>)> = Fable.Core.RustInterop.emitRustExpr () v896 
    let v898 : string = $"account_id"
    let v899 : near_sdk_AccountId = Fable.Core.RustInterop.emitRustExpr () v898 
    let v900 : string = $"&v897.2"
    let v901 : Ref<near_sdk_store_LookupMap<near_sdk_AccountId, std_string_String>> = Fable.Core.RustInterop.emitRustExpr () v900 
    let v902 : string = $"&v897.1"
    let v903 : Ref<near_sdk_store_LookupMap<std_string_String, std_collections_HashMap<near_sdk_AccountId, struct (uint64 * uint32)>>> = Fable.Core.RustInterop.emitRustExpr () v902 
    let v904 : string = "let result = v901.get(&$0).and_then(|alias| { //"
    Fable.Core.RustInterop.emitRustExpr v899 v904 
    let v905 : string = "    v903 //"
    Fable.Core.RustInterop.emitRustExpr () v905 
    let v906 : string = "      .get(alias) //"
    Fable.Core.RustInterop.emitRustExpr () v906 
    let v907 : string = "      .map(|accounts| { //"
    Fable.Core.RustInterop.emitRustExpr () v907 
    let v908 : string = "          let result = (alias.clone(), *accounts.get(&v899).unwrap()); //"
    Fable.Core.RustInterop.emitRustExpr () v908 
    let v909 : string = "          (result.0, result.1.0, result.1.1) //"
    Fable.Core.RustInterop.emitRustExpr () v909 
    let v910 : string = "      }) //"
    Fable.Core.RustInterop.emitRustExpr () v910 
    let v911 : string = "}); //"
    Fable.Core.RustInterop.emitRustExpr () v911 
    let v912 : string = "result"
    let v913 : struct (std_string_String * uint64 * uint32) option = Fable.Core.RustInterop.emitRustExpr () v912 
    let v914 : unit = ()
    let v915 : (unit -> unit) = closure16(v899, v913)
    let v916 : unit = (fun () -> v915 (); v914) ()
    let v1032 : unit = ()
    let v1033 : (unit -> unit) = closure17()
    let v1034 : unit = (fun () -> v1033 (); v1032) ()
    let _result = v913 in _result |> (fun x -> Fable.Core.RustInterop.emitRustExpr x "$0 } // 4") // 3
    let v1143 : string = "} // 2"
    Fable.Core.RustInterop.emitRustExpr () v1143 
    let v1144 : string = "} // 1"
    Fable.Core.RustInterop.emitRustExpr () v1144 
    let v1145 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v1145 
    let v1146 : string = "true; // ??? / i: 6uy / i': 1uy / acc: 9uy / n: 2uy"
    let v1147 : bool = Fable.Core.RustInterop.emitRustExpr () v1146 
    let v1148 : string = "true; */ // ???? / i: 6uy / i': 2uy / acc: 9uy / n: 2uy"
    let v1149 : bool = Fable.Core.RustInterop.emitRustExpr () v1148 
    let v1150 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v1150 
    let v1151 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v1151 
    let v1152 : string = "pub fn get_alias_map( //"
    Fable.Core.RustInterop.emitRustExpr () v1152 
    let v1153 : string = "  &self, //"
    Fable.Core.RustInterop.emitRustExpr () v1153 
    let v1154 : string = "  alias: String, //"
    Fable.Core.RustInterop.emitRustExpr () v1154 
    let v1155 : string = ") -> Option<std::collections::HashMap<near_sdk::AccountId, (u64, u32)>> { //"
    Fable.Core.RustInterop.emitRustExpr () v1155 
    let v1156 : string = $"&self.0.1"
    let v1157 : Ref<near_sdk_store_LookupMap<std_string_String, std_collections_HashMap<near_sdk_AccountId, struct (uint64 * uint32)>>> = Fable.Core.RustInterop.emitRustExpr () v1156 
    let v1158 : string = $"alias"
    let v1159 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v1158 
    let v1160 : unit = ()
    let v1161 : (unit -> unit) = closure18(v1159)
    let v1162 : unit = (fun () -> v1161 (); v1160) ()
    let v1278 : (unit -> unit) = method23()
    let v1279 : unit = ()
    let v1280 : (unit -> unit) = closure19(v1278)
    let v1281 : unit = (fun () -> v1280 (); v1279) ()
    let v1390 : string = "  v1157.get(&$0).cloned() //"
    Fable.Core.RustInterop.emitRustExpr v1159 v1390 
    let v1391 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v1391 
    let v1392 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v1392 
    let v1393 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v1393 
    let v1394 : string = "true; // ??? / i: 7uy / i': 1uy / acc: 11uy / n: 2uy"
    let v1395 : bool = Fable.Core.RustInterop.emitRustExpr () v1394 
    let v1396 : string = "true; */ // ???? / i: 7uy / i': 2uy / acc: 11uy / n: 2uy"
    let v1397 : bool = Fable.Core.RustInterop.emitRustExpr () v1396 
    let v1398 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v1398 
    let v1399 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v1399 
    let v1400 : string = "#[result_serializer(borsh)] //"
    Fable.Core.RustInterop.emitRustExpr () v1400 
    let v1401 : string = "pub fn get_alias_map_borsh( //"
    Fable.Core.RustInterop.emitRustExpr () v1401 
    let v1402 : string = "  &self, //"
    Fable.Core.RustInterop.emitRustExpr () v1402 
    let v1403 : string = "  #[serializer(borsh)] alias: String, //"
    Fable.Core.RustInterop.emitRustExpr () v1403 
    let v1404 : string = ") -> Option<std::collections::HashMap<near_sdk::AccountId, (u64, u32)>> { //"
    Fable.Core.RustInterop.emitRustExpr () v1404 
    let v1405 : string = "  self.get_alias_map(alias) //"
    Fable.Core.RustInterop.emitRustExpr () v1405 
    let v1406 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v1406 
    let v1407 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v1407 
    let v1408 : string = "true; // ??? / i: 8uy / i': 1uy / acc: 13uy / n: 1uy"
    let v1409 : bool = Fable.Core.RustInterop.emitRustExpr () v1408 
    let v1410 : string = "true; */ // ???? / i: 8uy / i': 2uy / acc: 13uy / n: 1uy"
    let v1411 : bool = Fable.Core.RustInterop.emitRustExpr () v1410 
    let v1412 : string = "fn _main() //"
    Fable.Core.RustInterop.emitRustExpr () v1412 
    let v1413 : string = "{ { //"
    Fable.Core.RustInterop.emitRustExpr () v1413 
    let v1414 : string = "true; { (); // ?? / i': 1uy / n: 14uy"
    let v1415 : bool = Fable.Core.RustInterop.emitRustExpr () v1414 
    let v1416 : string = "true; { (); // ?? / i': 2uy / n: 14uy"
    let v1417 : bool = Fable.Core.RustInterop.emitRustExpr () v1416 
    let v1418 : string = "true; { (); // ?? / i': 3uy / n: 14uy"
    let v1419 : bool = Fable.Core.RustInterop.emitRustExpr () v1418 
    let v1420 : string = "true; { (); // ?? / i': 4uy / n: 14uy"
    let v1421 : bool = Fable.Core.RustInterop.emitRustExpr () v1420 
    let v1422 : string = "true; { (); // ?? / i': 5uy / n: 14uy"
    let v1423 : bool = Fable.Core.RustInterop.emitRustExpr () v1422 
    let v1424 : string = "true; { (); // ?? / i': 6uy / n: 14uy"
    let v1425 : bool = Fable.Core.RustInterop.emitRustExpr () v1424 
    let v1426 : string = "true; { (); // ?? / i': 7uy / n: 14uy"
    let v1427 : bool = Fable.Core.RustInterop.emitRustExpr () v1426 
    let v1428 : string = "true; { (); // ?? / i': 8uy / n: 14uy"
    let v1429 : bool = Fable.Core.RustInterop.emitRustExpr () v1428 
    let v1430 : string = "true; { (); // ?? / i': 9uy / n: 14uy"
    let v1431 : bool = Fable.Core.RustInterop.emitRustExpr () v1430 
    let v1432 : string = "true; { (); // ?? / i': 10uy / n: 14uy"
    let v1433 : bool = Fable.Core.RustInterop.emitRustExpr () v1432 
    let v1434 : string = "true; { (); // ?? / i': 11uy / n: 14uy"
    let v1435 : bool = Fable.Core.RustInterop.emitRustExpr () v1434 
    let v1436 : string = "true; { (); // ?? / i': 12uy / n: 14uy"
    let v1437 : bool = Fable.Core.RustInterop.emitRustExpr () v1436 
    let v1438 : string = "true; { (); // ?? / i': 13uy / n: 14uy"
    let v1439 : bool = Fable.Core.RustInterop.emitRustExpr () v1438 
    let v1440 : string = "true; { (); // ?? / i': 14uy / n: 14uy"
    let v1441 : bool = Fable.Core.RustInterop.emitRustExpr () v1440 
    let v1442 : string = "true; { { (); // ? / i': 15uy / n: 14uy"
    let v1443 : bool = Fable.Core.RustInterop.emitRustExpr () v1442 
    ()
let v0 : (unit -> unit) = closure0()
v0 |> ignore
()
