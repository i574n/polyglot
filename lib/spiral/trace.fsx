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
    | US2_0
    | US2_1
    | US2_2
and [<Struct>] US3 =
    | US3_0 of f0_0 : US2
    | US3_1 of f1_0 : US2
    | US3_2 of f2_0 : US2
    | US3_3 of f3_0 : US2
    | US3_4 of f4_0 : US2
and [<Struct>] US4 =
    | US4_0 of f0_0 : US0
    | US4_1
and [<Struct>] US5 =
    | US5_0 of f0_0 : int64
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
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v85 : US2 = US2_1
    let v86 : US3 = US3_0(v85)
    let v87 : string = $"env.get_environment_variable / target: {v86} / var: {v0}"
    let v88 : string = failwith<string> v87
    let _v1 = v88 
    #endif
#else
    let v89 : (string -> string) = System.Environment.GetEnvironmentVariable
    let v90 : string = v89 v0
    let mutable _v90 = None
    #if !FABLE_COMPILER && !WASM && !CONTRACT
    let v91 : (string -> string option) = Option.ofObj
    let v92 : string option = v91 v90
    v92 
    #else
    Some v90 
    #endif
    |> fun x -> _v90 <- Some x
    let v93 : string option = match _v90 with Some x -> x | None -> failwith "optionm'.of_obj / _v90=None"
    let v96 : (string -> US1) = method4()
    let v97 : US1 option = v93 |> Option.map v96 
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
    let v8 : US4 =
        if v4 then
            let v5 : US0 = US0_0
            US4_0(v5)
        else
            US4_1
    let v49 : US4 =
        match v8 with
        | US4_1 -> (* None *)
            let v11 : bool = "Debug" = v3
            let v15 : US4 =
                if v11 then
                    let v12 : US0 = US0_1
                    US4_0(v12)
                else
                    US4_1
            match v15 with
            | US4_1 -> (* None *)
                let v18 : bool = "Info" = v3
                let v22 : US4 =
                    if v18 then
                        let v19 : US0 = US0_2
                        US4_0(v19)
                    else
                        US4_1
                match v22 with
                | US4_1 -> (* None *)
                    let v25 : bool = "Warning" = v3
                    let v29 : US4 =
                        if v25 then
                            let v26 : US0 = US0_3
                            US4_0(v26)
                        else
                            US4_1
                    match v29 with
                    | US4_1 -> (* None *)
                        let v32 : bool = "Critical" = v3
                        let v36 : US4 =
                            if v32 then
                                let v33 : US0 = US0_4
                                US4_0(v33)
                            else
                                US4_1
                        match v36 with
                        | US4_1 -> (* None *)
                            US4_1
                        | US4_0(v37) -> (* Some *)
                            US4_0(v37)
                    | US4_0(v30) -> (* Some *)
                        US4_0(v30)
                | US4_0(v23) -> (* Some *)
                    US4_0(v23)
            | US4_0(v16) -> (* Some *)
                US4_0(v16)
        | US4_0(v9) -> (* Some *)
            US4_0(v9)
    let v50 : string = method5()
    let v51 : string = method2(v50)
    let v52 : bool = v51 = "True"
    let v62 : US5 =
        if v52 then
            let v53 : System.DateTime = System.DateTime.Now
            let v56 : (System.DateTime -> int64) = _.Ticks
            let v57 : int64 = v56 v53
            US5_0(v57)
        else
            US5_1
    let _v1 = struct (v49, v62) 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v63 : US4 = US4_1
    let v64 : US5 = US5_1
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
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v82 : std_string_String = v68 |> unbox<std_string_String>
    let _v69 = v82 
    #endif
#else
    let v85 : std_string_String = v68 |> unbox<std_string_String>
    let _v69 = v85 
    #endif
    let v88 : std_string_String = _v69 
    let v93 : string = "fable_library_rust::String_::fromString($0)"
    let v94 : string = Fable.Core.RustInterop.emitRustExpr v88 v93 
    let _v66 = v94 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v95 : string = "env!(\"" + v65 + "\")"
    let v96 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v95 
    let v97 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v98 : string = "String::from($0)"
    let v99 : std_string_String = Fable.Core.RustInterop.emitRustExpr v96 v98 
    let _v97 = v99 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v100 : string = "String::from($0)"
    let v101 : std_string_String = Fable.Core.RustInterop.emitRustExpr v96 v100 
    let _v97 = v101 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v102 : string = "String::from($0)"
    let v103 : std_string_String = Fable.Core.RustInterop.emitRustExpr v96 v102 
    let _v97 = v103 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v104 : std_string_String = v96 |> unbox<std_string_String>
    let _v97 = v104 
    #endif
#if FABLE_COMPILER_PYTHON
    let v107 : std_string_String = v96 |> unbox<std_string_String>
    let _v97 = v107 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v110 : std_string_String = v96 |> unbox<std_string_String>
    let _v97 = v110 
    #endif
#else
    let v113 : std_string_String = v96 |> unbox<std_string_String>
    let _v97 = v113 
    #endif
    let v116 : std_string_String = _v97 
    let v121 : string = "fable_library_rust::String_::fromString($0)"
    let v122 : string = Fable.Core.RustInterop.emitRustExpr v116 v121 
    let _v66 = v122 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v123 : string = "env!(\"" + v65 + "\")"
    let v124 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v123 
    let v125 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v126 : string = "String::from($0)"
    let v127 : std_string_String = Fable.Core.RustInterop.emitRustExpr v124 v126 
    let _v125 = v127 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v128 : string = "String::from($0)"
    let v129 : std_string_String = Fable.Core.RustInterop.emitRustExpr v124 v128 
    let _v125 = v129 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v130 : string = "String::from($0)"
    let v131 : std_string_String = Fable.Core.RustInterop.emitRustExpr v124 v130 
    let _v125 = v131 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v132 : std_string_String = v124 |> unbox<std_string_String>
    let _v125 = v132 
    #endif
#if FABLE_COMPILER_PYTHON
    let v135 : std_string_String = v124 |> unbox<std_string_String>
    let _v125 = v135 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v138 : std_string_String = v124 |> unbox<std_string_String>
    let _v125 = v138 
    #endif
#else
    let v141 : std_string_String = v124 |> unbox<std_string_String>
    let _v125 = v141 
    #endif
    let v144 : std_string_String = _v125 
    let v149 : string = "fable_library_rust::String_::fromString($0)"
    let v150 : string = Fable.Core.RustInterop.emitRustExpr v144 v149 
    let _v66 = v150 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v151 : string = null |> unbox<string>
    let _v66 = v151 
    #endif
#if FABLE_COMPILER_PYTHON
    let v154 : string = null |> unbox<string>
    let _v66 = v154 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v157 : string = null |> unbox<string>
    let _v66 = v157 
    #endif
#else
    let v160 : string = null |> unbox<string>
    let _v66 = v160 
    #endif
    let v163 : string = _v66 
    let v168 : string = "True"
    let v169 : bool = v163 <> v168 
    let v178 : US5 =
        if v169 then
            US5_1
        else
            let v173 : string = $"near_sdk::env::block_timestamp()"
            let v174 : uint64 = Fable.Core.RustInterop.emitRustExpr () v173 
            let v175 : (uint64 -> int64) = int64
            let v176 : int64 = v175 v174
            US5_0(v176)
    let v179 : US4 = US4_1
    let _v1 = struct (v179, v178) 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v180 : string = method1()
    let v181 : string = method2(v180)
    
    
    
    
    
    let v182 : bool = "Verbose" = v181
    let v186 : US4 =
        if v182 then
            let v183 : US0 = US0_0
            US4_0(v183)
        else
            US4_1
    let v227 : US4 =
        match v186 with
        | US4_1 -> (* None *)
            let v189 : bool = "Debug" = v181
            let v193 : US4 =
                if v189 then
                    let v190 : US0 = US0_1
                    US4_0(v190)
                else
                    US4_1
            match v193 with
            | US4_1 -> (* None *)
                let v196 : bool = "Info" = v181
                let v200 : US4 =
                    if v196 then
                        let v197 : US0 = US0_2
                        US4_0(v197)
                    else
                        US4_1
                match v200 with
                | US4_1 -> (* None *)
                    let v203 : bool = "Warning" = v181
                    let v207 : US4 =
                        if v203 then
                            let v204 : US0 = US0_3
                            US4_0(v204)
                        else
                            US4_1
                    match v207 with
                    | US4_1 -> (* None *)
                        let v210 : bool = "Critical" = v181
                        let v214 : US4 =
                            if v210 then
                                let v211 : US0 = US0_4
                                US4_0(v211)
                            else
                                US4_1
                        match v214 with
                        | US4_1 -> (* None *)
                            US4_1
                        | US4_0(v215) -> (* Some *)
                            US4_0(v215)
                    | US4_0(v208) -> (* Some *)
                        US4_0(v208)
                | US4_0(v201) -> (* Some *)
                    US4_0(v201)
            | US4_0(v194) -> (* Some *)
                US4_0(v194)
        | US4_0(v187) -> (* Some *)
            US4_0(v187)
    let v228 : string = method5()
    let v229 : string = method2(v228)
    let v230 : bool = v229 = "True"
    let v240 : US5 =
        if v230 then
            let v231 : System.DateTime = System.DateTime.Now
            let v234 : (System.DateTime -> int64) = _.Ticks
            let v235 : int64 = v234 v231
            US5_0(v235)
        else
            US5_1
    let _v1 = struct (v227, v240) 
    #endif
#if FABLE_COMPILER_PYTHON
    let v241 : string = method1()
    let v242 : string = method2(v241)
    
    
    
    
    
    let v243 : bool = "Verbose" = v242
    let v247 : US4 =
        if v243 then
            let v244 : US0 = US0_0
            US4_0(v244)
        else
            US4_1
    let v288 : US4 =
        match v247 with
        | US4_1 -> (* None *)
            let v250 : bool = "Debug" = v242
            let v254 : US4 =
                if v250 then
                    let v251 : US0 = US0_1
                    US4_0(v251)
                else
                    US4_1
            match v254 with
            | US4_1 -> (* None *)
                let v257 : bool = "Info" = v242
                let v261 : US4 =
                    if v257 then
                        let v258 : US0 = US0_2
                        US4_0(v258)
                    else
                        US4_1
                match v261 with
                | US4_1 -> (* None *)
                    let v264 : bool = "Warning" = v242
                    let v268 : US4 =
                        if v264 then
                            let v265 : US0 = US0_3
                            US4_0(v265)
                        else
                            US4_1
                    match v268 with
                    | US4_1 -> (* None *)
                        let v271 : bool = "Critical" = v242
                        let v275 : US4 =
                            if v271 then
                                let v272 : US0 = US0_4
                                US4_0(v272)
                            else
                                US4_1
                        match v275 with
                        | US4_1 -> (* None *)
                            US4_1
                        | US4_0(v276) -> (* Some *)
                            US4_0(v276)
                    | US4_0(v269) -> (* Some *)
                        US4_0(v269)
                | US4_0(v262) -> (* Some *)
                    US4_0(v262)
            | US4_0(v255) -> (* Some *)
                US4_0(v255)
        | US4_0(v248) -> (* Some *)
            US4_0(v248)
    let v289 : string = method5()
    let v290 : string = method2(v289)
    let v291 : bool = v290 = "True"
    let v301 : US5 =
        if v291 then
            let v292 : System.DateTime = System.DateTime.Now
            let v295 : (System.DateTime -> int64) = _.Ticks
            let v296 : int64 = v295 v292
            US5_0(v296)
        else
            US5_1
    let _v1 = struct (v288, v301) 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v302 : string = method1()
    let v303 : string = method2(v302)
    
    
    
    
    
    let v304 : bool = "Verbose" = v303
    let v308 : US4 =
        if v304 then
            let v305 : US0 = US0_0
            US4_0(v305)
        else
            US4_1
    let v349 : US4 =
        match v308 with
        | US4_1 -> (* None *)
            let v311 : bool = "Debug" = v303
            let v315 : US4 =
                if v311 then
                    let v312 : US0 = US0_1
                    US4_0(v312)
                else
                    US4_1
            match v315 with
            | US4_1 -> (* None *)
                let v318 : bool = "Info" = v303
                let v322 : US4 =
                    if v318 then
                        let v319 : US0 = US0_2
                        US4_0(v319)
                    else
                        US4_1
                match v322 with
                | US4_1 -> (* None *)
                    let v325 : bool = "Warning" = v303
                    let v329 : US4 =
                        if v325 then
                            let v326 : US0 = US0_3
                            US4_0(v326)
                        else
                            US4_1
                    match v329 with
                    | US4_1 -> (* None *)
                        let v332 : bool = "Critical" = v303
                        let v336 : US4 =
                            if v332 then
                                let v333 : US0 = US0_4
                                US4_0(v333)
                            else
                                US4_1
                        match v336 with
                        | US4_1 -> (* None *)
                            US4_1
                        | US4_0(v337) -> (* Some *)
                            US4_0(v337)
                    | US4_0(v330) -> (* Some *)
                        US4_0(v330)
                | US4_0(v323) -> (* Some *)
                    US4_0(v323)
            | US4_0(v316) -> (* Some *)
                US4_0(v316)
        | US4_0(v309) -> (* Some *)
            US4_0(v309)
    let v350 : string = method5()
    let v351 : string = method2(v350)
    let v352 : bool = v351 = "True"
    let v362 : US5 =
        if v352 then
            let v353 : System.DateTime = System.DateTime.Now
            let v356 : (System.DateTime -> int64) = _.Ticks
            let v357 : int64 = v356 v353
            US5_0(v357)
        else
            US5_1
    let _v1 = struct (v349, v362) 
    #endif
#else
    let v363 : string = method1()
    let v364 : string = method2(v363)
    
    
    
    
    
    let v365 : bool = "Verbose" = v364
    let v369 : US4 =
        if v365 then
            let v366 : US0 = US0_0
            US4_0(v366)
        else
            US4_1
    let v410 : US4 =
        match v369 with
        | US4_1 -> (* None *)
            let v372 : bool = "Debug" = v364
            let v376 : US4 =
                if v372 then
                    let v373 : US0 = US0_1
                    US4_0(v373)
                else
                    US4_1
            match v376 with
            | US4_1 -> (* None *)
                let v379 : bool = "Info" = v364
                let v383 : US4 =
                    if v379 then
                        let v380 : US0 = US0_2
                        US4_0(v380)
                    else
                        US4_1
                match v383 with
                | US4_1 -> (* None *)
                    let v386 : bool = "Warning" = v364
                    let v390 : US4 =
                        if v386 then
                            let v387 : US0 = US0_3
                            US4_0(v387)
                        else
                            US4_1
                    match v390 with
                    | US4_1 -> (* None *)
                        let v393 : bool = "Critical" = v364
                        let v397 : US4 =
                            if v393 then
                                let v394 : US0 = US0_4
                                US4_0(v394)
                            else
                                US4_1
                        match v397 with
                        | US4_1 -> (* None *)
                            US4_1
                        | US4_0(v398) -> (* Some *)
                            US4_0(v398)
                    | US4_0(v391) -> (* Some *)
                        US4_0(v391)
                | US4_0(v384) -> (* Some *)
                    US4_0(v384)
            | US4_0(v377) -> (* Some *)
                US4_0(v377)
        | US4_0(v370) -> (* Some *)
            US4_0(v370)
    let v411 : string = method5()
    let v412 : string = method2(v411)
    let v413 : bool = v412 = "True"
    let v423 : US5 =
        if v413 then
            let v414 : System.DateTime = System.DateTime.Now
            let v417 : (System.DateTime -> int64) = _.Ticks
            let v418 : int64 = v417 v414
            US5_0(v418)
        else
            US5_1
    let _v1 = struct (v410, v423) 
    #endif
    let struct (v424 : US4, v425 : US5) = _v1 
    let v489 : Mut0 = {l0 = 1L} : Mut0
    let v490 : (string -> unit) = closure2()
    let v491 : Mut1 = {l0 = v490} : Mut1
    let v492 : Mut2 = {l0 = true} : Mut2
    let v493 : string = ""
    let v494 : Mut3 = {l0 = v493} : Mut3
    let v497 : US0 =
        match v424 with
        | US4_1 -> (* None *)
            v0
        | US4_0(v495) -> (* Some *)
            v495
    let v498 : Mut4 = {l0 = v497} : Mut4
    let v505 : int64 option =
        match v425 with
        | US5_1 -> (* None *)
            let v503 : int64 option = None
            v503
        | US5_0(v499) -> (* Some *)
            let v500 : int64 option = Some v499 
            v500
    struct (v489, v491, v492, v494, v498, v505)
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
and closure7 () (v0 : int64) : US5 =
    US5_0(v0)
and method8 () : (int64 -> US5) =
    closure7()
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
    let v7 : (int64 -> US5) = method8()
    let v8 : US5 option = v5 |> Option.map v7 
    let v19 : US5 = US5_1
    let v20 : US5 = v8 |> Option.defaultValue v19 
    let v60 : System.DateTime =
        match v20 with
        | US5_1 -> (* None *)
            let v56 : System.DateTime = System.DateTime.Now
            v56
        | US5_0(v24) -> (* Some *)
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
    let v68 : (int64 -> US5) = method8()
    let v69 : US5 option = v5 |> Option.map v68 
    let v80 : US5 = US5_1
    let v81 : US5 = v69 |> Option.defaultValue v80 
    let v121 : System.DateTime =
        match v81 with
        | US5_1 -> (* None *)
            let v117 : System.DateTime = System.DateTime.Now
            v117
        | US5_0(v85) -> (* Some *)
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
    let v131 : (int64 -> US5) = method8()
    let v132 : US5 option = v5 |> Option.map v131 
    let v143 : US5 = US5_1
    let v144 : US5 = v132 |> Option.defaultValue v143 
    let v153 : uint64 =
        match v144 with
        | US5_1 -> (* None *)
            v130
        | US5_0(v148) -> (* Some *)
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
    let v164 : (int64 -> US5) = method8()
    let v165 : US5 option = v5 |> Option.map v164 
    let v176 : US5 = US5_1
    let v177 : US5 = v165 |> Option.defaultValue v176 
    let v217 : System.DateTime =
        match v177 with
        | US5_1 -> (* None *)
            let v213 : System.DateTime = System.DateTime.Now
            v213
        | US5_0(v181) -> (* Some *)
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
    let v225 : (int64 -> US5) = method8()
    let v226 : US5 option = v5 |> Option.map v225 
    let v237 : US5 = US5_1
    let v238 : US5 = v226 |> Option.defaultValue v237 
    let v278 : System.DateTime =
        match v238 with
        | US5_1 -> (* None *)
            let v274 : System.DateTime = System.DateTime.Now
            v274
        | US5_0(v242) -> (* Some *)
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
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v286 : (int64 -> US5) = method8()
    let v287 : US5 option = v5 |> Option.map v286 
    let v298 : US5 = US5_1
    let v299 : US5 = v287 |> Option.defaultValue v298 
    let v339 : System.DateTime =
        match v299 with
        | US5_1 -> (* None *)
            let v335 : System.DateTime = System.DateTime.Now
            v335
        | US5_0(v303) -> (* Some *)
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
#else
    let v347 : (int64 -> US5) = method8()
    let v348 : US5 option = v5 |> Option.map v347 
    let v359 : US5 = US5_1
    let v360 : US5 = v348 |> Option.defaultValue v359 
    let v400 : System.DateTime =
        match v360 with
        | US5_1 -> (* None *)
            let v396 : System.DateTime = System.DateTime.Now
            v396
        | US5_0(v364) -> (* Some *)
            let v365 : System.DateTime = System.DateTime.Now
            let v368 : (System.DateTime -> int64) = _.Ticks
            let v369 : int64 = v368 v365
            let v372 : int64 = v369 - v364
            let v373 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v374 : System.TimeSpan = v373 v372
            let v377 : (System.TimeSpan -> int32) = _.Hours
            let v378 : int32 = v377 v374
            let v381 : (System.TimeSpan -> int32) = _.Minutes
            let v382 : int32 = v381 v374
            let v385 : (System.TimeSpan -> int32) = _.Seconds
            let v386 : int32 = v385 v374
            let v389 : (System.TimeSpan -> int32) = _.Milliseconds
            let v390 : int32 = v389 v374
            let v393 : System.DateTime = System.DateTime (1, 1, 1, v378, v382, v386, v390)
            v393
    let v401 : string = method10()
    let v404 : (string -> string) = v400.ToString
    let v405 : string = v404 v401
    let _v6 = v405 
    #endif
    let v408 : string = _v6 
    v408
and method13 () : string =
    let v0 : string = ""
    v0
and closure8 (v0 : Mut3, v1 : string) () : unit =
    let v2 : string = v0.l0
    let v3 : string = v2 + v1 
    v0.l0 <- v3
    ()
and method12 (v0 : char) : string =
    let v1 : string = method13()
    let v2 : Mut3 = {l0 = v1} : Mut3
    let v3 : string = $"{v0}"
    let v6 : unit = ()
    let v7 : (unit -> unit) = closure8(v2, v3)
    let v8 : unit = (fun () -> v7 (); v6) ()
    let v11 : string = v2.l0
    v11
and method14 () : string =
    let v0 : string = "\u001b[0m"
    v0
and method11 (v0 : US0) : string =
    
    
    
    
    
    let v1 : bool =
        match v0 with
        | US0_0 -> (* Verbose *)
            true
        | _ ->
            false
    let v5 : US1 =
        if v1 then
            let v2 : string = "Verbose"
            US1_0(v2)
        else
            US1_1
    let v46 : US1 =
        match v5 with
        | US1_1 -> (* None *)
            let v8 : bool =
                match v0 with
                | US0_1 -> (* Debug *)
                    true
                | _ ->
                    false
            let v12 : US1 =
                if v8 then
                    let v9 : string = "Debug"
                    US1_0(v9)
                else
                    US1_1
            match v12 with
            | US1_1 -> (* None *)
                let v15 : bool =
                    match v0 with
                    | US0_2 -> (* Info *)
                        true
                    | _ ->
                        false
                let v19 : US1 =
                    if v15 then
                        let v16 : string = "Info"
                        US1_0(v16)
                    else
                        US1_1
                match v19 with
                | US1_1 -> (* None *)
                    let v22 : bool =
                        match v0 with
                        | US0_3 -> (* Warning *)
                            true
                        | _ ->
                            false
                    let v26 : US1 =
                        if v22 then
                            let v23 : string = "Warning"
                            US1_0(v23)
                        else
                            US1_1
                    match v26 with
                    | US1_1 -> (* None *)
                        let v29 : bool =
                            match v0 with
                            | US0_4 -> (* Critical *)
                                true
                            | _ ->
                                false
                        let v33 : US1 =
                            if v29 then
                                let v30 : string = "Critical"
                                US1_0(v30)
                            else
                                US1_1
                        match v33 with
                        | US1_1 -> (* None *)
                            US1_1
                        | US1_0(v34) -> (* Some *)
                            US1_0(v34)
                    | US1_0(v27) -> (* Some *)
                        US1_0(v27)
                | US1_0(v20) -> (* Some *)
                    US1_0(v20)
            | US1_0(v13) -> (* Some *)
                US1_0(v13)
        | US1_0(v6) -> (* Some *)
            US1_0(v6)
    let v50 : string =
        match v46 with
        | US1_1 -> (* None *)
            failwith<string> "Option does not have a value."
        | US1_0(v47) -> (* Some *)
            v47
    let v51 : (unit -> string) = v50.ToLower
    let v52 : string = v51 ()
    let v55 : char = v52.[int 0]
    let v56 : string = method12(v55)
    let v57 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v72 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v66 : string = "inline_colorization::color_bright_red"
            let v67 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v66 
            v67
        | US0_1 -> (* Debug *)
            let v60 : string = "inline_colorization::color_bright_blue"
            let v61 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v60 
            v61
        | US0_2 -> (* Info *)
            let v62 : string = "inline_colorization::color_bright_green"
            let v63 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v62 
            v63
        | US0_0 -> (* Verbose *)
            let v58 : string = "inline_colorization::color_bright_black"
            let v59 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v58 
            v59
        | US0_3 -> (* Warning *)
            let v64 : string = "inline_colorization::color_yellow"
            let v65 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v64 
            v65
    let v73 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v74 : string = "&*$0"
    let v75 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v56 v74 
    let _v73 = v75 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v76 : string = "&*$0"
    let v77 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v56 v76 
    let _v73 = v77 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v78 : string = "&*$0"
    let v79 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v56 v78 
    let _v73 = v79 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v80 : Ref<Str> = v56 |> unbox<Ref<Str>>
    let _v73 = v80 
    #endif
#if FABLE_COMPILER_PYTHON
    let v83 : Ref<Str> = v56 |> unbox<Ref<Str>>
    let _v73 = v83 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v86 : Ref<Str> = v56 |> unbox<Ref<Str>>
    let _v73 = v86 
    #endif
#else
    let v89 : Ref<Str> = v56 |> unbox<Ref<Str>>
    let _v73 = v89 
    #endif
    let v92 : Ref<Str> = _v73 
    let v97 : string = "inline_colorization::color_reset"
    let v98 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v97 
    let v99 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v100 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v72, v92, v98) v99 
    let v101 : string = "fable_library_rust::String_::fromString($0)"
    let v102 : string = Fable.Core.RustInterop.emitRustExpr v100 v101 
    let _v57 = v102 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v117 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v111 : string = "inline_colorization::color_bright_red"
            let v112 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v111 
            v112
        | US0_1 -> (* Debug *)
            let v105 : string = "inline_colorization::color_bright_blue"
            let v106 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v105 
            v106
        | US0_2 -> (* Info *)
            let v107 : string = "inline_colorization::color_bright_green"
            let v108 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v107 
            v108
        | US0_0 -> (* Verbose *)
            let v103 : string = "inline_colorization::color_bright_black"
            let v104 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v103 
            v104
        | US0_3 -> (* Warning *)
            let v109 : string = "inline_colorization::color_yellow"
            let v110 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v109 
            v110
    let v118 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v119 : string = "&*$0"
    let v120 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v56 v119 
    let _v118 = v120 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v121 : string = "&*$0"
    let v122 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v56 v121 
    let _v118 = v122 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v123 : string = "&*$0"
    let v124 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v56 v123 
    let _v118 = v124 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v125 : Ref<Str> = v56 |> unbox<Ref<Str>>
    let _v118 = v125 
    #endif
#if FABLE_COMPILER_PYTHON
    let v128 : Ref<Str> = v56 |> unbox<Ref<Str>>
    let _v118 = v128 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v131 : Ref<Str> = v56 |> unbox<Ref<Str>>
    let _v118 = v131 
    #endif
#else
    let v134 : Ref<Str> = v56 |> unbox<Ref<Str>>
    let _v118 = v134 
    #endif
    let v137 : Ref<Str> = _v118 
    let v142 : string = "inline_colorization::color_reset"
    let v143 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v142 
    let v144 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v145 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v117, v137, v143) v144 
    let v146 : string = "fable_library_rust::String_::fromString($0)"
    let v147 : string = Fable.Core.RustInterop.emitRustExpr v145 v146 
    let _v57 = v147 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v162 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v156 : string = "inline_colorization::color_bright_red"
            let v157 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v156 
            v157
        | US0_1 -> (* Debug *)
            let v150 : string = "inline_colorization::color_bright_blue"
            let v151 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v150 
            v151
        | US0_2 -> (* Info *)
            let v152 : string = "inline_colorization::color_bright_green"
            let v153 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v152 
            v153
        | US0_0 -> (* Verbose *)
            let v148 : string = "inline_colorization::color_bright_black"
            let v149 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v148 
            v149
        | US0_3 -> (* Warning *)
            let v154 : string = "inline_colorization::color_yellow"
            let v155 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v154 
            v155
    let v163 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v164 : string = "&*$0"
    let v165 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v56 v164 
    let _v163 = v165 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v166 : string = "&*$0"
    let v167 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v56 v166 
    let _v163 = v167 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v168 : string = "&*$0"
    let v169 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v56 v168 
    let _v163 = v169 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v170 : Ref<Str> = v56 |> unbox<Ref<Str>>
    let _v163 = v170 
    #endif
#if FABLE_COMPILER_PYTHON
    let v173 : Ref<Str> = v56 |> unbox<Ref<Str>>
    let _v163 = v173 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v176 : Ref<Str> = v56 |> unbox<Ref<Str>>
    let _v163 = v176 
    #endif
#else
    let v179 : Ref<Str> = v56 |> unbox<Ref<Str>>
    let _v163 = v179 
    #endif
    let v182 : Ref<Str> = _v163 
    let v187 : string = "inline_colorization::color_reset"
    let v188 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v187 
    let v189 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v190 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v162, v182, v188) v189 
    let v191 : string = "fable_library_rust::String_::fromString($0)"
    let v192 : string = Fable.Core.RustInterop.emitRustExpr v190 v191 
    let _v57 = v192 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v202 : string =
        match v0 with
        | US0_4 -> (* Critical *)
            let v197 : string = "\u001b[91m"
            v197
        | US0_1 -> (* Debug *)
            let v194 : string = "\u001b[94m"
            v194
        | US0_2 -> (* Info *)
            let v195 : string = "\u001b[92m"
            v195
        | US0_0 -> (* Verbose *)
            let v193 : string = "\u001b[90m"
            v193
        | US0_3 -> (* Warning *)
            let v196 : string = "\u001b[93m"
            v196
    let v203 : string = method14()
    let v204 : string = v202 + v56 
    let v205 : string = v204 + v203 
    let _v57 = v205 
    #endif
#if FABLE_COMPILER_PYTHON
    let v215 : string =
        match v0 with
        | US0_4 -> (* Critical *)
            let v210 : string = "\u001b[91m"
            v210
        | US0_1 -> (* Debug *)
            let v207 : string = "\u001b[94m"
            v207
        | US0_2 -> (* Info *)
            let v208 : string = "\u001b[92m"
            v208
        | US0_0 -> (* Verbose *)
            let v206 : string = "\u001b[90m"
            v206
        | US0_3 -> (* Warning *)
            let v209 : string = "\u001b[93m"
            v209
    let v216 : string = method14()
    let v217 : string = v215 + v56 
    let v218 : string = v217 + v216 
    let _v57 = v218 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v228 : string =
        match v0 with
        | US0_4 -> (* Critical *)
            let v223 : string = "\u001b[91m"
            v223
        | US0_1 -> (* Debug *)
            let v220 : string = "\u001b[94m"
            v220
        | US0_2 -> (* Info *)
            let v221 : string = "\u001b[92m"
            v221
        | US0_0 -> (* Verbose *)
            let v219 : string = "\u001b[90m"
            v219
        | US0_3 -> (* Warning *)
            let v222 : string = "\u001b[93m"
            v222
    let v229 : string = method14()
    let v230 : string = v228 + v56 
    let v231 : string = v230 + v229 
    let _v57 = v231 
    #endif
#else
    let v241 : string =
        match v0 with
        | US0_4 -> (* Critical *)
            let v236 : string = "\u001b[91m"
            v236
        | US0_1 -> (* Debug *)
            let v233 : string = "\u001b[94m"
            v233
        | US0_2 -> (* Info *)
            let v234 : string = "\u001b[92m"
            v234
        | US0_0 -> (* Verbose *)
            let v232 : string = "\u001b[90m"
            v232
        | US0_3 -> (* Warning *)
            let v235 : string = "\u001b[93m"
            v235
    let v242 : string = method14()
    let v243 : string = v241 + v56 
    let v244 : string = v243 + v242 
    let _v57 = v244 
    #endif
    let v245 : string = _v57 
    v245
and method16 (v0 : string) : string =
    let v1 : string = method13()
    let v2 : Mut3 = {l0 = v1} : Mut3
    let v3 : string = $"{v0}"
    let v6 : unit = ()
    let v7 : (unit -> unit) = closure8(v2, v3)
    let v8 : unit = (fun () -> v7 (); v6) ()
    let v11 : string = v2.l0
    v11
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
and method15 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : string, v9 : string) : string =
    let v10 : string = method16(v9)
    let v11 : int64 = v0.l0
    let v12 : string = $"{v6} {v7} #{v11} %s{v8} / {v10}"
    method17(v12)
and closure9 (v0 : Mut0) () : unit =
    let v1 : int64 = v0.l0
    let v2 : int64 = v1 + 1L
    v0.l0 <- v2
    ()
and closure11 (v0 : string) () : unit =
    let v1 : (string -> unit) = System.Console.WriteLine
    v1 v0
and closure10 () (v0 : string) : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure11(v0)
    let v3 : unit = (fun () -> v2 (); v1) ()
    ()
and method18 (v0 : string) : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure0()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v17 : Mut0, v18 : Mut1, v19 : Mut2, v20 : Mut3, v21 : Mut4, v22 : int64 option) = TraceState.trace_state.Value
    let v35 : unit = ()
    let v36 : (unit -> unit) = closure9(v17)
    let v37 : unit = (fun () -> v36 (); v35) ()
    let v40 : (string -> unit) = closure10()
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
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v67 : Ref<Str> = v53 |> unbox<Ref<Str>>
    let _v54 = v67 
    #endif
#else
    let v70 : Ref<Str> = v53 |> unbox<Ref<Str>>
    let _v54 = v70 
    #endif
    let v73 : Ref<Str> = _v54 
    let v78 : string = $"$0.chars()"
    let v79 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v73 v78 
    let v80 : string = "$0"
    let v81 : _ = Fable.Core.RustInterop.emitRustExpr v79 v80 
    let v82 : string = "$0.collect::<Vec<_>>()"
    let v83 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v81 v82 
    let v84 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
    let v85 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v83 v84 
    let v86 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
    let v87 : bool = Fable.Core.RustInterop.emitRustExpr v85 v86 
    let v88 : string = "x"
    let v89 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v88 
    let v90 : string = "String::from_iter($0)"
    let v91 : std_string_String = Fable.Core.RustInterop.emitRustExpr v89 v90 
    let v92 : string = "true; $0 }).collect::<Vec<_>>()"
    let v93 : bool = Fable.Core.RustInterop.emitRustExpr v91 v92 
    let v94 : string = "_vec_map"
    let v95 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v94 
    let v96 : string = "$0.len()"
    let v97 : unativeint = Fable.Core.RustInterop.emitRustExpr v95 v96 
    let v98 : (unativeint -> int32) = int32
    let v99 : int32 = v98 v97
    let v100 : string = ""
    let v101 : bool = v0 <> v100 
    let v105 : bool =
        if v101 then
            let v104 : bool = v99 <= 1
            v104
        else
            false
    if v105 then
        v20.l0 <- v53
        ()
    else
        v20.l0 <- v100
        let v106 : string = "true; $0.into_iter().for_each(|x| { //"
        let v107 : bool = Fable.Core.RustInterop.emitRustExpr v95 v106 
        let v108 : string = "x"
        let v109 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v108 
        let v110 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
        let v111 : bool = Fable.Core.RustInterop.emitRustExpr v109 v110 
        let v112 : string = $"true"
        let v113 : bool = Fable.Core.RustInterop.emitRustExpr () v112 
        let v114 : string = "true; }); //"
        let v115 : bool = Fable.Core.RustInterop.emitRustExpr () v114 
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
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    v40 v0
    let _v41 = () 
    #endif
#else
    v40 v0
    let _v41 = () 
    #endif
    _v41 
    let v116 : (string -> unit) = v18.l0
    v116 v0
and closure6 (v0 : US0, v1 : (unit -> string), v2 : (unit -> string)) () : unit =
    let v3 : bool = method6(v0)
    if v3 then
        let v4 : unit = ()
        let v5 : (unit -> unit) = closure0()
        let v6 : unit = (fun () -> v5 (); v4) ()
        let struct (v20 : Mut0, v21 : Mut1, v22 : Mut2, v23 : Mut3, v24 : Mut4, v25 : int64 option) = TraceState.trace_state.Value
        let v38 : string = method7(v20, v21, v22, v23, v24, v25)
        let v39 : string = method11(v0)
        let v40 : string = v1 ()
        let v41 : bool = v40 = ""
        let v45 : string =
            if v41 then
                let v42 : string = ""
                v42
            else
                let v43 : string = v2 ()
                method15(v20, v21, v22, v23, v24, v25, v38, v39, v40, v43)
        method18(v45)
and closure5 (v0 : US0, v1 : (unit -> string)) (v2 : (unit -> string)) : unit =
    let v3 : unit = ()
    let v4 : (unit -> unit) = closure6(v0, v1, v2)
    let v5 : unit = (fun () -> v4 (); v3) ()
    ()
and closure4 (v0 : US0) (v1 : (unit -> string)) : ((unit -> string) -> unit) =
    closure5(v0, v1)
and closure3 () (v0 : US0) : ((unit -> string) -> ((unit -> string) -> unit)) =
    closure4(v0)
let v0 : unit = ()
let v1 : (unit -> unit) = closure0()
let v2 : unit = (fun () -> v1 (); v0) ()
let v16 : (US0 -> ((unit -> string) -> ((unit -> string) -> unit))) = closure3()
let trace x = v16 x
()
