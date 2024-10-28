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
[<Fable.Core.Erase; Fable.Core.Emit("near_sdk::store::IterableSet<$0>")>]
#endif
type near_sdk_store_IterableSet<'T> = class end
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
and [<Struct>] US6 =
    | US6_0 of f0_0 : std_string_String
    | US6_1
let rec closure1 () (v0 : char) : bool =
    let v1 : string = $"$0.is_alphanumeric()"
    let v2 : bool = Fable.Core.RustInterop.emitRustExpr v0 v1 
    if v2 then
        true
    else
        let v3 : bool = v0 = '-'
        v3
and method2 () : string =
    let v0 : string = "TRACE_LEVEL"
    v0
and method4 () : string =
    let v0 : string = ""
    v0
and closure4 () (v0 : string) : US1 =
    US1_0(v0)
and method5 () : (string -> US1) =
    closure4()
and method3 (v0 : string) : string =
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
    let v14 : string = method4()
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
    let v29 : string = method4()
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
    let v44 : string = method4()
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
    let v64 : (string -> US1) = method5()
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
    let v96 : (string -> US1) = method5()
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
and method6 () : string =
    let v0 : string = "AUTOMATION"
    v0
and closure5 () (v0 : string) : unit =
    ()
and method1 (v0 : US0) : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) =
    let v1 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = method2()
    let v3 : string = method3(v2)
    
    
    
    
    
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
    let v50 : string = method6()
    let v51 : string = method3(v50)
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
    let v180 : string = method2()
    let v181 : string = method3(v180)
    
    
    
    
    
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
    let v228 : string = method6()
    let v229 : string = method3(v228)
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
    let v241 : string = method2()
    let v242 : string = method3(v241)
    
    
    
    
    
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
    let v289 : string = method6()
    let v290 : string = method3(v289)
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
    let v302 : string = method2()
    let v303 : string = method3(v302)
    
    
    
    
    
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
    let v350 : string = method6()
    let v351 : string = method3(v350)
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
    let v363 : string = method2()
    let v364 : string = method3(v363)
    
    
    
    
    
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
    let v411 : string = method6()
    let v412 : string = method3(v411)
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
    let v490 : (string -> unit) = closure5()
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
and closure3 () () : unit =
    let v0 : bool = TraceState.trace_state.IsNone
    if v0 then
        let v1 : US0 = US0_0
        let struct (v2 : Mut0, v3 : Mut1, v4 : Mut2, v5 : Mut3, v6 : Mut4, v7 : int64 option) = method1(v1)
        let v8 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v2, v3, v4, v5, v6, v7) 
        TraceState.trace_state <- v8 
        ()
and method0 (v0 : US0) : bool =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure3()
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
and closure6 () (v0 : int64) : US5 =
    US5_0(v0)
and method8 () : (int64 -> US5) =
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
    
    
    
    
    
    let v0 : string = "Debug"
    let v1 : (unit -> string) = v0.ToLower
    let v2 : string = v1 ()
    let v5 : char = v2.[int 0]
    let v6 : string = method12(v5)
    let v7 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v8 : string = "inline_colorization::color_bright_blue"
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
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v23 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v10 = v23 
    #endif
#else
    let v26 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v10 = v26 
    #endif
    let v29 : Ref<Str> = _v10 
    let v34 : string = "inline_colorization::color_reset"
    let v35 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v34 
    let v36 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v37 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v9, v29, v35) v36 
    let v38 : string = "fable_library_rust::String_::fromString($0)"
    let v39 : string = Fable.Core.RustInterop.emitRustExpr v37 v38 
    let _v7 = v39 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v40 : string = "inline_colorization::color_bright_blue"
    let v41 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v40 
    let v42 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v43 : string = "&*$0"
    let v44 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v43 
    let _v42 = v44 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v45 : string = "&*$0"
    let v46 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v45 
    let _v42 = v46 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v47 : string = "&*$0"
    let v48 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v47 
    let _v42 = v48 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v49 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v42 = v49 
    #endif
#if FABLE_COMPILER_PYTHON
    let v52 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v42 = v52 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v55 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v42 = v55 
    #endif
#else
    let v58 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v42 = v58 
    #endif
    let v61 : Ref<Str> = _v42 
    let v66 : string = "inline_colorization::color_reset"
    let v67 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v66 
    let v68 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v69 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v41, v61, v67) v68 
    let v70 : string = "fable_library_rust::String_::fromString($0)"
    let v71 : string = Fable.Core.RustInterop.emitRustExpr v69 v70 
    let _v7 = v71 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v72 : string = "inline_colorization::color_bright_blue"
    let v73 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v72 
    let v74 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v75 : string = "&*$0"
    let v76 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v75 
    let _v74 = v76 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v77 : string = "&*$0"
    let v78 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v77 
    let _v74 = v78 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v79 : string = "&*$0"
    let v80 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v79 
    let _v74 = v80 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v81 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v74 = v81 
    #endif
#if FABLE_COMPILER_PYTHON
    let v84 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v74 = v84 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v87 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v74 = v87 
    #endif
#else
    let v90 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v74 = v90 
    #endif
    let v93 : Ref<Str> = _v74 
    let v98 : string = "inline_colorization::color_reset"
    let v99 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v98 
    let v100 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v101 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v73, v93, v99) v100 
    let v102 : string = "fable_library_rust::String_::fromString($0)"
    let v103 : string = Fable.Core.RustInterop.emitRustExpr v101 v102 
    let _v7 = v103 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v104 : string = "\u001b[94m"
    let v105 : string = method14()
    let v106 : string = v104 + v6 
    let v107 : string = v106 + v105 
    let _v7 = v107 
    #endif
#if FABLE_COMPILER_PYTHON
    let v108 : string = "\u001b[94m"
    let v109 : string = method14()
    let v110 : string = v108 + v6 
    let v111 : string = v110 + v109 
    let _v7 = v111 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v112 : string = "\u001b[94m"
    let v113 : string = method14()
    let v114 : string = v112 + v6 
    let v115 : string = v114 + v113 
    let _v7 = v115 
    #endif
#else
    let v116 : string = "\u001b[94m"
    let v117 : string = method14()
    let v118 : string = v116 + v6 
    let v119 : string = v118 + v117 
    let _v7 = v119 
    #endif
    let v120 : string = _v7 
    v120
and method16 (v0 : std_string_String, v1 : uint64, v2 : std_string_String, v3 : std_string_String) : string =
    let v4 : string = method13()
    let v5 : Mut3 = {l0 = v4} : Mut3
    let v6 : string = "{ "
    let v7 : string = $"{v6}"
    let v10 : unit = ()
    let v11 : (unit -> unit) = closure7(v5, v7)
    let v12 : unit = (fun () -> v11 (); v10) ()
    let v15 : string = "alias"
    let v16 : string = $"{v15}"
    let v19 : unit = ()
    let v20 : (unit -> unit) = closure7(v5, v16)
    let v21 : unit = (fun () -> v20 (); v19) ()
    let v24 : string = " = "
    let v25 : string = $"{v24}"
    let v28 : unit = ()
    let v29 : (unit -> unit) = closure7(v5, v25)
    let v30 : unit = (fun () -> v29 (); v28) ()
    let v33 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v34 : string = "format!(\"{:#?}\", $0)"
    let v35 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v34 
    let v36 : string = "fable_library_rust::String_::fromString($0)"
    let v37 : string = Fable.Core.RustInterop.emitRustExpr v35 v36 
    let _v33 = v37 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v38 : string = "format!(\"{:#?}\", $0)"
    let v39 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v38 
    let v40 : string = "fable_library_rust::String_::fromString($0)"
    let v41 : string = Fable.Core.RustInterop.emitRustExpr v39 v40 
    let _v33 = v41 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v42 : string = "format!(\"{:#?}\", $0)"
    let v43 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v42 
    let v44 : string = "fable_library_rust::String_::fromString($0)"
    let v45 : string = Fable.Core.RustInterop.emitRustExpr v43 v44 
    let _v33 = v45 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v46 : string = $"%A{v0}"
    let _v33 = v46 
    #endif
#if FABLE_COMPILER_PYTHON
    let v49 : string = $"%A{v0}"
    let _v33 = v49 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v52 : string = $"%A{v0}"
    let _v33 = v52 
    #endif
#else
    let v55 : string = $"%A{v0}"
    let _v33 = v55 
    #endif
    let v58 : string = _v33 
    let v63 : string = $"{v58}"
    let v66 : unit = ()
    let v67 : (unit -> unit) = closure7(v5, v63)
    let v68 : unit = (fun () -> v67 (); v66) ()
    let v71 : string = "; "
    let v72 : string = $"{v71}"
    let v75 : unit = ()
    let v76 : (unit -> unit) = closure7(v5, v72)
    let v77 : unit = (fun () -> v76 (); v75) ()
    let v80 : string = "block_timestamp"
    let v81 : string = $"{v80}"
    let v84 : unit = ()
    let v85 : (unit -> unit) = closure7(v5, v81)
    let v86 : unit = (fun () -> v85 (); v84) ()
    let v89 : string = $"{v24}"
    let v92 : unit = ()
    let v93 : (unit -> unit) = closure7(v5, v89)
    let v94 : unit = (fun () -> v93 (); v92) ()
    let v97 : string = $"{v1}"
    let v100 : unit = ()
    let v101 : (unit -> unit) = closure7(v5, v97)
    let v102 : unit = (fun () -> v101 (); v100) ()
    let v105 : string = $"{v71}"
    let v108 : unit = ()
    let v109 : (unit -> unit) = closure7(v5, v105)
    let v110 : unit = (fun () -> v109 (); v108) ()
    let v113 : string = "signer_account_id"
    let v114 : string = $"{v113}"
    let v117 : unit = ()
    let v118 : (unit -> unit) = closure7(v5, v114)
    let v119 : unit = (fun () -> v118 (); v117) ()
    let v122 : string = $"{v24}"
    let v125 : unit = ()
    let v126 : (unit -> unit) = closure7(v5, v122)
    let v127 : unit = (fun () -> v126 (); v125) ()
    let v130 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v131 : string = "format!(\"{:#?}\", $0)"
    let v132 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v131 
    let v133 : string = "fable_library_rust::String_::fromString($0)"
    let v134 : string = Fable.Core.RustInterop.emitRustExpr v132 v133 
    let _v130 = v134 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v135 : string = "format!(\"{:#?}\", $0)"
    let v136 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v135 
    let v137 : string = "fable_library_rust::String_::fromString($0)"
    let v138 : string = Fable.Core.RustInterop.emitRustExpr v136 v137 
    let _v130 = v138 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v139 : string = "format!(\"{:#?}\", $0)"
    let v140 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v139 
    let v141 : string = "fable_library_rust::String_::fromString($0)"
    let v142 : string = Fable.Core.RustInterop.emitRustExpr v140 v141 
    let _v130 = v142 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v143 : string = $"%A{v2}"
    let _v130 = v143 
    #endif
#if FABLE_COMPILER_PYTHON
    let v146 : string = $"%A{v2}"
    let _v130 = v146 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v149 : string = $"%A{v2}"
    let _v130 = v149 
    #endif
#else
    let v152 : string = $"%A{v2}"
    let _v130 = v152 
    #endif
    let v155 : string = _v130 
    let v160 : string = $"{v155}"
    let v163 : unit = ()
    let v164 : (unit -> unit) = closure7(v5, v160)
    let v165 : unit = (fun () -> v164 (); v163) ()
    let v168 : string = $"{v71}"
    let v171 : unit = ()
    let v172 : (unit -> unit) = closure7(v5, v168)
    let v173 : unit = (fun () -> v172 (); v171) ()
    let v176 : string = "predecessor_account_id"
    let v177 : string = $"{v176}"
    let v180 : unit = ()
    let v181 : (unit -> unit) = closure7(v5, v177)
    let v182 : unit = (fun () -> v181 (); v180) ()
    let v185 : string = $"{v24}"
    let v188 : unit = ()
    let v189 : (unit -> unit) = closure7(v5, v185)
    let v190 : unit = (fun () -> v189 (); v188) ()
    let v193 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v194 : string = "format!(\"{:#?}\", $0)"
    let v195 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3 v194 
    let v196 : string = "fable_library_rust::String_::fromString($0)"
    let v197 : string = Fable.Core.RustInterop.emitRustExpr v195 v196 
    let _v193 = v197 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v198 : string = "format!(\"{:#?}\", $0)"
    let v199 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3 v198 
    let v200 : string = "fable_library_rust::String_::fromString($0)"
    let v201 : string = Fable.Core.RustInterop.emitRustExpr v199 v200 
    let _v193 = v201 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v202 : string = "format!(\"{:#?}\", $0)"
    let v203 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3 v202 
    let v204 : string = "fable_library_rust::String_::fromString($0)"
    let v205 : string = Fable.Core.RustInterop.emitRustExpr v203 v204 
    let _v193 = v205 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v206 : string = $"%A{v3}"
    let _v193 = v206 
    #endif
#if FABLE_COMPILER_PYTHON
    let v209 : string = $"%A{v3}"
    let _v193 = v209 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v212 : string = $"%A{v3}"
    let _v193 = v212 
    #endif
#else
    let v215 : string = $"%A{v3}"
    let _v193 = v215 
    #endif
    let v218 : string = _v193 
    let v223 : string = $"{v218}"
    let v226 : unit = ()
    let v227 : (unit -> unit) = closure7(v5, v223)
    let v228 : unit = (fun () -> v227 (); v226) ()
    let v231 : string = " }"
    let v232 : string = $"{v231}"
    let v235 : unit = ()
    let v236 : (unit -> unit) = closure7(v5, v232)
    let v237 : unit = (fun () -> v236 (); v235) ()
    let v240 : string = v5.l0
    v240
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
and method15 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : std_string_String, v9 : uint64, v10 : std_string_String, v11 : std_string_String) : string =
    let v12 : string = method16(v8, v9, v10, v11)
    let v13 : int64 = v0.l0
    let v14 : string = "chat_contract.claim_alias"
    let v15 : string = $"{v6} {v7} #{v13} %s{v14} / {v12}"
    method17(v15)
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
    let v2 : (unit -> unit) = closure3()
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
and closure2 (v0 : std_string_String, v1 : near_sdk_AccountId, v2 : near_sdk_AccountId, v3 : uint64) () : unit =
    let v4 : US0 = US0_1
    let v5 : bool = method0(v4)
    if v5 then
        let v6 : unit = ()
        let v7 : (unit -> unit) = closure3()
        let v8 : unit = (fun () -> v7 (); v6) ()
        let struct (v22 : Mut0, v23 : Mut1, v24 : Mut2, v25 : Mut3, v26 : Mut4, v27 : int64 option) = TraceState.trace_state.Value
        let v40 : string = method7(v22, v23, v24, v25, v26, v27)
        let v41 : string = method11()
        let v42 : string = $"v1.to_string()"
        let v43 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v42 
        let v44 : string = $"v2.to_string()"
        let v45 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v44 
        let v46 : string = method15(v22, v23, v24, v25, v26, v27, v40, v41, v0, v3, v43, v45)
        method18(v46)
and closure11 () (v0 : std_string_String) : US6 =
    US6_0(v0)
and method19 () : (std_string_String -> US6) =
    closure11()
and method20 () : string =
    
    
    
    
    
    let v0 : string = "Warning"
    let v1 : (unit -> string) = v0.ToLower
    let v2 : string = v1 ()
    let v5 : char = v2.[int 0]
    let v6 : string = method12(v5)
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
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v23 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v10 = v23 
    #endif
#else
    let v26 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v10 = v26 
    #endif
    let v29 : Ref<Str> = _v10 
    let v34 : string = "inline_colorization::color_reset"
    let v35 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v34 
    let v36 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v37 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v9, v29, v35) v36 
    let v38 : string = "fable_library_rust::String_::fromString($0)"
    let v39 : string = Fable.Core.RustInterop.emitRustExpr v37 v38 
    let _v7 = v39 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v40 : string = "inline_colorization::color_yellow"
    let v41 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v40 
    let v42 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v43 : string = "&*$0"
    let v44 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v43 
    let _v42 = v44 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v45 : string = "&*$0"
    let v46 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v45 
    let _v42 = v46 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v47 : string = "&*$0"
    let v48 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v47 
    let _v42 = v48 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v49 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v42 = v49 
    #endif
#if FABLE_COMPILER_PYTHON
    let v52 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v42 = v52 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v55 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v42 = v55 
    #endif
#else
    let v58 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v42 = v58 
    #endif
    let v61 : Ref<Str> = _v42 
    let v66 : string = "inline_colorization::color_reset"
    let v67 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v66 
    let v68 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v69 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v41, v61, v67) v68 
    let v70 : string = "fable_library_rust::String_::fromString($0)"
    let v71 : string = Fable.Core.RustInterop.emitRustExpr v69 v70 
    let _v7 = v71 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v72 : string = "inline_colorization::color_yellow"
    let v73 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v72 
    let v74 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v75 : string = "&*$0"
    let v76 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v75 
    let _v74 = v76 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v77 : string = "&*$0"
    let v78 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v77 
    let _v74 = v78 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v79 : string = "&*$0"
    let v80 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v79 
    let _v74 = v80 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v81 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v74 = v81 
    #endif
#if FABLE_COMPILER_PYTHON
    let v84 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v74 = v84 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v87 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v74 = v87 
    #endif
#else
    let v90 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v74 = v90 
    #endif
    let v93 : Ref<Str> = _v74 
    let v98 : string = "inline_colorization::color_reset"
    let v99 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v98 
    let v100 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v101 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v73, v93, v99) v100 
    let v102 : string = "fable_library_rust::String_::fromString($0)"
    let v103 : string = Fable.Core.RustInterop.emitRustExpr v101 v102 
    let _v7 = v103 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v104 : string = "\u001b[93m"
    let v105 : string = method14()
    let v106 : string = v104 + v6 
    let v107 : string = v106 + v105 
    let _v7 = v107 
    #endif
#if FABLE_COMPILER_PYTHON
    let v108 : string = "\u001b[93m"
    let v109 : string = method14()
    let v110 : string = v108 + v6 
    let v111 : string = v110 + v109 
    let _v7 = v111 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v112 : string = "\u001b[93m"
    let v113 : string = method14()
    let v114 : string = v112 + v6 
    let v115 : string = v114 + v113 
    let _v7 = v115 
    #endif
#else
    let v116 : string = "\u001b[93m"
    let v117 : string = method14()
    let v118 : string = v116 + v6 
    let v119 : string = v118 + v117 
    let _v7 = v119 
    #endif
    let v120 : string = _v7 
    v120
and method22 (v0 : string) : string =
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
and method21 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : string) : string =
    let v9 : string = method22(v8)
    let v10 : int64 = v0.l0
    let v11 : string = "chat_contract.claim_alias / alias already claimed"
    let v12 : string = $"{v6} {v7} #{v10} %s{v11} / {v9}"
    method17(v12)
and closure12 (v0 : std_string_String) () : unit =
    let v1 : US0 = US0_3
    let v2 : bool = method0(v1)
    if v2 then
        let v3 : unit = ()
        let v4 : (unit -> unit) = closure3()
        let v5 : unit = (fun () -> v4 (); v3) ()
        let struct (v19 : Mut0, v20 : Mut1, v21 : Mut2, v22 : Mut3, v23 : Mut4, v24 : int64 option) = TraceState.trace_state.Value
        let v37 : string = method7(v19, v20, v21, v22, v23, v24)
        let v38 : string = method20()
        let v39 : string = $"%A{v0}"
        let v42 : string = method21(v19, v20, v21, v22, v23, v24, v37, v38, v39)
        method18(v42)
and method23 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : string) : string =
    let v9 : string = method22(v8)
    let v10 : int64 = v0.l0
    let v11 : string = "chat_contract.claim_alias"
    let v12 : string = $"{v6} {v7} #{v10} %s{v11} / {v9}"
    method17(v12)
and closure13 (v0 : std_string_String option) () : unit =
    let v1 : US0 = US0_1
    let v2 : bool = method0(v1)
    if v2 then
        let v3 : unit = ()
        let v4 : (unit -> unit) = closure3()
        let v5 : unit = (fun () -> v4 (); v3) ()
        let struct (v19 : Mut0, v20 : Mut1, v21 : Mut2, v22 : Mut3, v23 : Mut4, v24 : int64 option) = TraceState.trace_state.Value
        let v37 : string = method7(v19, v20, v21, v22, v23, v24)
        let v38 : string = method11()
        let v39 : string = $"%A{v0}"
        let v42 : string = method23(v19, v20, v21, v22, v23, v24, v37, v38, v39)
        method18(v42)
and closure14 () () : unit =
    ()
and method24 () : (unit -> unit) =
    closure14()
and method25 () : unit =
    let v0 : unit = ()
    let v1 : (unit -> unit) = closure3()
    let v2 : unit = (fun () -> v1 (); v0) ()
    let struct (v16 : Mut0, v17 : Mut1, v18 : Mut2, v19 : Mut3, v20 : Mut4, v21 : int64 option) = TraceState.trace_state.Value
    let v34 : unit = ()
    let v35 : (unit -> unit) = closure8(v16)
    let v36 : unit = (fun () -> v35 (); v34) ()
    let v39 : string = ""
    let v40 : (string -> unit) = closure9()
    let v41 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v42 : string = @"println!(""{}"", $0)"
    Fable.Core.RustInterop.emitRustExpr v39 v42 
    let _v41 = () 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v43 : string = @"println!(""{}"", $0)"
    Fable.Core.RustInterop.emitRustExpr v39 v43 
    let _v41 = () 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v44 : string = v19.l0
    let v45 : bool = v44 = ""
    let v53 : string =
        if v45 then
            v39
        else
            let v46 : bool = v39 = ""
            if v46 then
                let v47 : string = v19.l0
                v47
            else
                let v48 : string = v19.l0
                let v49 : string = "\n"
                let v50 : string = v48 + v49 
                let v51 : string = v50 + v39 
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
    let v100 : bool = v39 <> v39 
    let v104 : bool =
        if v100 then
            let v103 : bool = v99 <= 1
            v103
        else
            false
    if v104 then
        v19.l0 <- v53
        ()
    else
        v19.l0 <- v39
        let v105 : string = "true; $0.into_iter().for_each(|x| { //"
        let v106 : bool = Fable.Core.RustInterop.emitRustExpr v95 v105 
        let v107 : string = "x"
        let v108 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v107 
        let v109 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
        let v110 : bool = Fable.Core.RustInterop.emitRustExpr v108 v109 
        let v111 : string = $"true"
        let v112 : bool = Fable.Core.RustInterop.emitRustExpr () v111 
        let v113 : string = "true; }); //"
        let v114 : bool = Fable.Core.RustInterop.emitRustExpr () v113 
        ()
    let _v41 = () 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    v40 v39
    let _v41 = () 
    #endif
#if FABLE_COMPILER_PYTHON
    v40 v39
    let _v41 = () 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    v40 v39
    let _v41 = () 
    #endif
#else
    v40 v39
    let _v41 = () 
    #endif
    _v41 
    let v115 : (string -> unit) = v17.l0
    v115 v39
and closure15 (v0 : (unit -> unit)) () : unit =
    let v1 : US0 = US0_1
    let v2 : bool = method0(v1)
    if v2 then
        let v3 : unit = ()
        let v4 : (unit -> unit) = closure3()
        let v5 : unit = (fun () -> v4 (); v3) ()
        let struct (v19 : Mut0, v20 : Mut1, v21 : Mut2, v22 : Mut3, v23 : Mut4, v24 : int64 option) = TraceState.trace_state.Value
        let v37 : string = method7(v19, v20, v21, v22, v23, v24)
        let v38 : string = method11()
        method25()
and method27 (v0 : near_sdk_AccountId, v1 : struct (std_string_String * uint64 * uint32) option) : string =
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
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v50 : string = $"%A{v0}"
    let _v31 = v50 
    #endif
#else
    let v53 : string = $"%A{v0}"
    let _v31 = v53 
    #endif
    let v56 : string = _v31 
    let v61 : string = $"{v56}"
    let v64 : unit = ()
    let v65 : (unit -> unit) = closure7(v3, v61)
    let v66 : unit = (fun () -> v65 (); v64) ()
    let v69 : string = "; "
    let v70 : string = $"{v69}"
    let v73 : unit = ()
    let v74 : (unit -> unit) = closure7(v3, v70)
    let v75 : unit = (fun () -> v74 (); v73) ()
    let v78 : string = "result"
    let v79 : string = $"{v78}"
    let v82 : unit = ()
    let v83 : (unit -> unit) = closure7(v3, v79)
    let v84 : unit = (fun () -> v83 (); v82) ()
    let v87 : string = $"{v22}"
    let v90 : unit = ()
    let v91 : (unit -> unit) = closure7(v3, v87)
    let v92 : unit = (fun () -> v91 (); v90) ()
    let v95 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v96 : string = "format!(\"{:#?}\", $0)"
    let v97 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1 v96 
    let v98 : string = "fable_library_rust::String_::fromString($0)"
    let v99 : string = Fable.Core.RustInterop.emitRustExpr v97 v98 
    let _v95 = v99 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v100 : string = "format!(\"{:#?}\", $0)"
    let v101 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1 v100 
    let v102 : string = "fable_library_rust::String_::fromString($0)"
    let v103 : string = Fable.Core.RustInterop.emitRustExpr v101 v102 
    let _v95 = v103 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v104 : string = "format!(\"{:#?}\", $0)"
    let v105 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1 v104 
    let v106 : string = "fable_library_rust::String_::fromString($0)"
    let v107 : string = Fable.Core.RustInterop.emitRustExpr v105 v106 
    let _v95 = v107 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v108 : string = $"%A{v1}"
    let _v95 = v108 
    #endif
#if FABLE_COMPILER_PYTHON
    let v111 : string = $"%A{v1}"
    let _v95 = v111 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v114 : string = $"%A{v1}"
    let _v95 = v114 
    #endif
#else
    let v117 : string = $"%A{v1}"
    let _v95 = v117 
    #endif
    let v120 : string = _v95 
    let v125 : string = $"{v120}"
    let v128 : unit = ()
    let v129 : (unit -> unit) = closure7(v3, v125)
    let v130 : unit = (fun () -> v129 (); v128) ()
    let v133 : string = " }"
    let v134 : string = $"{v133}"
    let v137 : unit = ()
    let v138 : (unit -> unit) = closure7(v3, v134)
    let v139 : unit = (fun () -> v138 (); v137) ()
    let v142 : string = v3.l0
    v142
and method26 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : near_sdk_AccountId, v9 : struct (std_string_String * uint64 * uint32) option) : string =
    let v10 : string = method27(v8, v9)
    let v11 : int64 = v0.l0
    let v12 : string = "chat_contract.get_account_info"
    let v13 : string = $"{v6} {v7} #{v11} %s{v12} / {v10}"
    method17(v13)
and closure16 (v0 : near_sdk_AccountId, v1 : struct (std_string_String * uint64 * uint32) option) () : unit =
    let v2 : US0 = US0_1
    let v3 : bool = method0(v2)
    if v3 then
        let v4 : unit = ()
        let v5 : (unit -> unit) = closure3()
        let v6 : unit = (fun () -> v5 (); v4) ()
        let struct (v20 : Mut0, v21 : Mut1, v22 : Mut2, v23 : Mut3, v24 : Mut4, v25 : int64 option) = TraceState.trace_state.Value
        let v38 : string = method7(v20, v21, v22, v23, v24, v25)
        let v39 : string = method11()
        let v40 : string = method26(v20, v21, v22, v23, v24, v25, v38, v39, v0, v1)
        method18(v40)
and closure17 () () : unit =
    let v0 : US0 = US0_1
    let v1 : bool = method0(v0)
    if v1 then
        let v2 : unit = ()
        let v3 : (unit -> unit) = closure3()
        let v4 : unit = (fun () -> v3 (); v2) ()
        let struct (v18 : Mut0, v19 : Mut1, v20 : Mut2, v21 : Mut3, v22 : Mut4, v23 : int64 option) = TraceState.trace_state.Value
        let v36 : string = method7(v18, v19, v20, v21, v22, v23)
        let v37 : string = method11()
        method25()
and method29 (v0 : std_string_String) : string =
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
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v49 : string = $"%A{v0}"
    let _v30 = v49 
    #endif
#else
    let v52 : string = $"%A{v0}"
    let _v30 = v52 
    #endif
    let v55 : string = _v30 
    let v60 : string = $"{v55}"
    let v63 : unit = ()
    let v64 : (unit -> unit) = closure7(v2, v60)
    let v65 : unit = (fun () -> v64 (); v63) ()
    let v68 : string = " }"
    let v69 : string = $"{v68}"
    let v72 : unit = ()
    let v73 : (unit -> unit) = closure7(v2, v69)
    let v74 : unit = (fun () -> v73 (); v72) ()
    let v77 : string = v2.l0
    v77
and method28 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : std_string_String) : string =
    let v9 : string = method29(v8)
    let v10 : int64 = v0.l0
    let v11 : string = "chat_contract.get_alias_map"
    let v12 : string = $"{v6} {v7} #{v10} %s{v11} / {v9}"
    method17(v12)
and closure18 (v0 : std_string_String) () : unit =
    let v1 : US0 = US0_1
    let v2 : bool = method0(v1)
    if v2 then
        let v3 : unit = ()
        let v4 : (unit -> unit) = closure3()
        let v5 : unit = (fun () -> v4 (); v3) ()
        let struct (v19 : Mut0, v20 : Mut1, v21 : Mut2, v22 : Mut3, v23 : Mut4, v24 : int64 option) = TraceState.trace_state.Value
        let v37 : string = method7(v19, v20, v21, v22, v23, v24)
        let v38 : string = method11()
        let v39 : string = method28(v19, v20, v21, v22, v23, v24, v37, v38, v0)
        method18(v39)
and method30 () : (unit -> unit) =
    closure14()
and closure19 (v0 : (unit -> unit)) () : unit =
    let v1 : US0 = US0_1
    let v2 : bool = method0(v1)
    if v2 then
        let v3 : unit = ()
        let v4 : (unit -> unit) = closure3()
        let v5 : unit = (fun () -> v4 (); v3) ()
        let struct (v19 : Mut0, v20 : Mut1, v21 : Mut2, v22 : Mut3, v23 : Mut4, v24 : int64 option) = TraceState.trace_state.Value
        let v37 : string = method7(v19, v20, v21, v22, v23, v24)
        let v38 : string = method11()
        method25()
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
    let v9 : TypeEmit<struct (uint32 * near_sdk_store_IterableSet<near_sdk_AccountId> * near_sdk_store_IterableSet<std_string_String> * near_sdk_store_LookupMap<near_sdk_AccountId, std_string_String> * near_sdk_store_LookupMap<std_string_String, std_collections_HashMap<near_sdk_AccountId, struct (uint64 * uint32)>>)> = null |> unbox<TypeEmit<struct (uint32 * near_sdk_store_IterableSet<near_sdk_AccountId> * near_sdk_store_IterableSet<std_string_String> * near_sdk_store_LookupMap<near_sdk_AccountId, std_string_String> * near_sdk_store_LookupMap<std_string_String, std_collections_HashMap<near_sdk_AccountId, struct (uint64 * uint32)>>)>>
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
    let v24 : string = "account_set"
    let v25 : string = "b\"" + v24 + "\""
    let v26 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v25 
    let v27 : string = "near_sdk::store::IterableSet::new(v26)"
    let v28 : near_sdk_store_IterableSet<near_sdk_AccountId> = Fable.Core.RustInterop.emitRustExpr () v27 
    let v29 : string = "alias_set"
    let v30 : string = "b\"" + v29 + "\""
    let v31 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v30 
    let v32 : string = "near_sdk::store::IterableSet::new(v31)"
    let v33 : near_sdk_store_IterableSet<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v32 
    let v34 : string = "account_map"
    let v35 : string = "b\"" + v34 + "\""
    let v36 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v35 
    let v37 : string = "near_sdk::store::LookupMap::new(v36)"
    let v38 : near_sdk_store_LookupMap<near_sdk_AccountId, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v37 
    let v39 : string = "alias_map"
    let v40 : string = "b\"" + v39 + "\""
    let v41 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v40 
    let v42 : string = "near_sdk::store::LookupMap::new(v41)"
    let v43 : near_sdk_store_LookupMap<std_string_String, std_collections_HashMap<near_sdk_AccountId, struct (uint64 * uint32)>> = Fable.Core.RustInterop.emitRustExpr () v42 
    let _result = struct (2u, v28, v33, v38, v43) in _result |> (fun x -> Fable.Core.RustInterop.emitRustExpr x $"Self($0) // x") // 2
    let v44 : string = "} // 2."
    Fable.Core.RustInterop.emitRustExpr () v44 
    let v45 : string = "} // 1."
    Fable.Core.RustInterop.emitRustExpr () v45 
    let v46 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v46 
    let v47 : string = "true; // ??? / i: 1uy / i': 1uy / acc: 0uy / n: 2uy"
    let v48 : bool = Fable.Core.RustInterop.emitRustExpr () v47 
    let v49 : string = "true; */ // ???? / i: 1uy / i': 2uy / acc: 0uy / n: 2uy"
    let v50 : bool = Fable.Core.RustInterop.emitRustExpr () v49 
    let v51 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v51 
    let v52 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v52 
    let v53 : string = "fn is_valid_alias(alias: String) -> bool { //"
    Fable.Core.RustInterop.emitRustExpr () v53 
    let v54 : string = $"alias"
    let v55 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v54 
    let v56 : string = "fable_library_rust::String_::fromString($0)"
    let v57 : string = Fable.Core.RustInterop.emitRustExpr v55 v56 
    let v58 : int32 = v57.Length
    let v59 : bool = v58 > 0
    let v103 : bool =
        if v59 then
            let v60 : bool = v58 < 64
            if v60 then
                let v61 : string = "-"
                let v62 : bool = v57.StartsWith v61 
                let v65 : bool = v62 = false
                if v65 then
                    let v66 : bool = v57.EndsWith v61 
                    let v67 : bool = v66 = false
                    if v67 then
                        let v68 : unit = ()
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v69 : string = "&*$0"
                        let v70 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v57 v69 
                        let _v68 = v70 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        let v71 : string = "&*$0"
                        let v72 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v57 v71 
                        let _v68 = v72 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        let v73 : string = "&*$0"
                        let v74 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v57 v73 
                        let _v68 = v74 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        let v75 : Ref<Str> = v57 |> unbox<Ref<Str>>
                        let _v68 = v75 
                        #endif
#if FABLE_COMPILER_PYTHON
                        let v78 : Ref<Str> = v57 |> unbox<Ref<Str>>
                        let _v68 = v78 
                        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                        let v81 : Ref<Str> = v57 |> unbox<Ref<Str>>
                        let _v68 = v81 
                        #endif
#else
                        let v84 : Ref<Str> = v57 |> unbox<Ref<Str>>
                        let _v68 = v84 
                        #endif
                        let v87 : Ref<Str> = _v68 
                        let v92 : string = $"$0.chars()"
                        let v93 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v87 v92 
                        let v94 : string = "true; // 1"
                        let v95 : bool = Fable.Core.RustInterop.emitRustExpr () v94 
                        let v96 : string = "let mut v93 = v93"
                        Fable.Core.RustInterop.emitRustExpr () v96 
                        let v97 : string = $"v93.all(|x| $0(x))"
                        let v98 : (char -> bool) = closure1()
                        let v99 : bool = Fable.Core.RustInterop.emitRustExpr v98 v97 
                        v99
                    else
                        false
                else
                    false
            else
                false
        else
            false
    let _result = v103 in _result |> (fun x -> Fable.Core.RustInterop.emitRustExpr x "$0 }") // 2
    let v104 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v104 
    let v105 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v105 
    let v106 : string = "true; // ??? / i: 2uy / i': 1uy / acc: 2uy / n: 1uy"
    let v107 : bool = Fable.Core.RustInterop.emitRustExpr () v106 
    let v108 : string = "true; */ // ???? / i: 2uy / i': 2uy / acc: 2uy / n: 1uy"
    let v109 : bool = Fable.Core.RustInterop.emitRustExpr () v108 
    let v110 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v110 
    let v111 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v111 
    let v112 : string = "pub fn generate_cid( //"
    Fable.Core.RustInterop.emitRustExpr () v112 
    let v113 : string = "  &self, //"
    Fable.Core.RustInterop.emitRustExpr () v113 
    let v114 : string = "  content: Vec<u8>, //"
    Fable.Core.RustInterop.emitRustExpr () v114 
    let v115 : string = ") -> String { //"
    Fable.Core.RustInterop.emitRustExpr () v115 
    let v116 : string = $"content"
    let v117 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v116 
    let v118 : string = "  fn encode_u64(value: u64) -> Vec<u8> { //"
    Fable.Core.RustInterop.emitRustExpr () v118 
    let v119 : string = "    let mut buffer = unsigned_varint::encode::u64_buffer(); //"
    Fable.Core.RustInterop.emitRustExpr () v119 
    let v120 : string = "    unsigned_varint::encode::u64(value, &mut buffer).to_vec() //"
    Fable.Core.RustInterop.emitRustExpr () v120 
    let v121 : string = "  } //"
    Fable.Core.RustInterop.emitRustExpr () v121 
    let v122 : string = "  fn sha256_hash(content: &[u8]) -> Vec<u8> { //"
    Fable.Core.RustInterop.emitRustExpr () v122 
    let v123 : string = "    let mut hasher: sha2::Sha256 = sha2::Digest::new(); //"
    Fable.Core.RustInterop.emitRustExpr () v123 
    let v124 : string = "    sha2::Digest::update(&mut hasher, content); //"
    Fable.Core.RustInterop.emitRustExpr () v124 
    let v125 : string = "    sha2::Digest::finalize(hasher).to_vec() //"
    Fable.Core.RustInterop.emitRustExpr () v125 
    let v126 : string = "  } //"
    Fable.Core.RustInterop.emitRustExpr () v126 
    let v127 : string = "  let version: u8 = 1; //"
    Fable.Core.RustInterop.emitRustExpr () v127 
    let v128 : string = "  let codec_raw: u64 = 0x55; //"
    Fable.Core.RustInterop.emitRustExpr () v128 
    let v129 : string = "  let codec_bytes = encode_u64(codec_raw); //"
    Fable.Core.RustInterop.emitRustExpr () v129 
    let v130 : string = "  let hash_result = sha256_hash(&v117); //"
    Fable.Core.RustInterop.emitRustExpr () v130 
    let v131 : string = "  let multihash = std::iter::once(0x12) //"
    Fable.Core.RustInterop.emitRustExpr () v131 
    let v132 : string = "    .chain(std::iter::once(32)) //"
    Fable.Core.RustInterop.emitRustExpr () v132 
    let v133 : string = "    .chain(hash_result.into_iter()) //"
    Fable.Core.RustInterop.emitRustExpr () v133 
    let v134 : string = "    .collect(); //"
    Fable.Core.RustInterop.emitRustExpr () v134 
    let v135 : string = "  let cid_bytes = [vec![version], codec_bytes, multihash].concat(); //"
    Fable.Core.RustInterop.emitRustExpr () v135 
    let v136 : string = "  let result = multibase::encode(multibase::Base::Base32Lower, &cid_bytes); //"
    Fable.Core.RustInterop.emitRustExpr () v136 
    let v137 : string = "result"
    let v138 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v137 
    let _result = v138 in _result |> (fun x -> Fable.Core.RustInterop.emitRustExpr x "$0 }") // 2
    let v139 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v139 
    let v140 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v140 
    let v141 : string = "true; // ??? / i: 3uy / i': 1uy / acc: 3uy / n: 2uy"
    let v142 : bool = Fable.Core.RustInterop.emitRustExpr () v141 
    let v143 : string = "true; */ // ???? / i: 3uy / i': 2uy / acc: 3uy / n: 2uy"
    let v144 : bool = Fable.Core.RustInterop.emitRustExpr () v143 
    let v145 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v145 
    let v146 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v146 
    let v147 : string = "#[result_serializer(borsh)] //"
    Fable.Core.RustInterop.emitRustExpr () v147 
    let v148 : string = "pub fn generate_cid_borsh( //"
    Fable.Core.RustInterop.emitRustExpr () v148 
    let v149 : string = "  &self, //"
    Fable.Core.RustInterop.emitRustExpr () v149 
    let v150 : string = "  #[serializer(borsh)] content: Vec<u8>, //"
    Fable.Core.RustInterop.emitRustExpr () v150 
    let v151 : string = ") -> String { //"
    Fable.Core.RustInterop.emitRustExpr () v151 
    let v152 : string = "  self.generate_cid(content) //"
    Fable.Core.RustInterop.emitRustExpr () v152 
    let v153 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v153 
    let v154 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v154 
    let v155 : string = "true; // ??? / i: 4uy / i': 1uy / acc: 5uy / n: 1uy"
    let v156 : bool = Fable.Core.RustInterop.emitRustExpr () v155 
    let v157 : string = "true; */ // ???? / i: 4uy / i': 2uy / acc: 5uy / n: 1uy"
    let v158 : bool = Fable.Core.RustInterop.emitRustExpr () v157 
    let v159 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v159 
    let v160 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v160 
    let v161 : string = "pub fn claim_alias( //"
    Fable.Core.RustInterop.emitRustExpr () v161 
    let v162 : string = "  &mut self, //"
    Fable.Core.RustInterop.emitRustExpr () v162 
    let v163 : string = "  alias: String, //"
    Fable.Core.RustInterop.emitRustExpr () v163 
    let v164 : string = ") { //"
    Fable.Core.RustInterop.emitRustExpr () v164 
    let v165 : string = $"&mut self.0"
    let v166 : Ref<Mut<struct (uint32 * near_sdk_store_IterableSet<near_sdk_AccountId> * near_sdk_store_IterableSet<std_string_String> * near_sdk_store_LookupMap<near_sdk_AccountId, std_string_String> * near_sdk_store_LookupMap<std_string_String, std_collections_HashMap<near_sdk_AccountId, struct (uint64 * uint32)>>)>> = Fable.Core.RustInterop.emitRustExpr () v165 
    let v167 : string = $"alias"
    let v168 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v167 
    let v169 : string = $"&mut v166.1"
    let v170 : Ref<Mut<near_sdk_store_IterableSet<near_sdk_AccountId>>> = Fable.Core.RustInterop.emitRustExpr () v169 
    let v171 : string = $"&mut v166.2"
    let v172 : Ref<Mut<near_sdk_store_IterableSet<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr () v171 
    let v173 : string = $"&mut v166.3"
    let v174 : Ref<Mut<near_sdk_store_LookupMap<near_sdk_AccountId, std_string_String>>> = Fable.Core.RustInterop.emitRustExpr () v173 
    let v175 : string = $"&mut v166.4"
    let v176 : Ref<Mut<near_sdk_store_LookupMap<std_string_String, std_collections_HashMap<near_sdk_AccountId, struct (uint64 * uint32)>>>> = Fable.Core.RustInterop.emitRustExpr () v175 
    let v177 : string = $"near_sdk::env::signer_account_id()"
    let v178 : near_sdk_AccountId = Fable.Core.RustInterop.emitRustExpr () v177 
    let v179 : string = $"near_sdk::env::predecessor_account_id()"
    let v180 : near_sdk_AccountId = Fable.Core.RustInterop.emitRustExpr () v179 
    let v181 : string = $"near_sdk::env::block_timestamp()"
    let v182 : uint64 = Fable.Core.RustInterop.emitRustExpr () v181 
    let v183 : unit = ()
    let v184 : (unit -> unit) = closure2(v168, v178, v180, v182)
    let v185 : unit = (fun () -> v184 (); v183) ()
    let v229 : string = "fable_library_rust::String_::fromString($0)"
    let v230 : string = Fable.Core.RustInterop.emitRustExpr v168 v229 
    let v231 : int32 = v230.Length
    let v232 : bool = v231 > 0
    let v276 : bool =
        if v232 then
            let v233 : bool = v231 < 64
            if v233 then
                let v234 : string = "-"
                let v235 : bool = v230.StartsWith v234 
                let v238 : bool = v235 = false
                if v238 then
                    let v239 : bool = v230.EndsWith v234 
                    let v240 : bool = v239 = false
                    if v240 then
                        let v241 : unit = ()
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v242 : string = "&*$0"
                        let v243 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v230 v242 
                        let _v241 = v243 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        let v244 : string = "&*$0"
                        let v245 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v230 v244 
                        let _v241 = v245 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        let v246 : string = "&*$0"
                        let v247 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v230 v246 
                        let _v241 = v247 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        let v248 : Ref<Str> = v230 |> unbox<Ref<Str>>
                        let _v241 = v248 
                        #endif
#if FABLE_COMPILER_PYTHON
                        let v251 : Ref<Str> = v230 |> unbox<Ref<Str>>
                        let _v241 = v251 
                        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                        let v254 : Ref<Str> = v230 |> unbox<Ref<Str>>
                        let _v241 = v254 
                        #endif
#else
                        let v257 : Ref<Str> = v230 |> unbox<Ref<Str>>
                        let _v241 = v257 
                        #endif
                        let v260 : Ref<Str> = _v241 
                        let v265 : string = $"$0.chars()"
                        let v266 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v260 v265 
                        let v267 : string = "true; // 1"
                        let v268 : bool = Fable.Core.RustInterop.emitRustExpr () v267 
                        let v269 : string = "let mut v266 = v266"
                        Fable.Core.RustInterop.emitRustExpr () v269 
                        let v270 : string = $"v266.all(|x| $0(x))"
                        let v271 : (char -> bool) = closure1()
                        let v272 : bool = Fable.Core.RustInterop.emitRustExpr v271 v270 
                        v272
                    else
                        false
                else
                    false
            else
                false
        else
            false
    let v277 : bool = v276 = false
    let v281 : bool =
        if v277 then
            let v278 : string = $"true; near_sdk::env::panic_str(&*$0); //"
            let v279 : string = "chat_contract.claim_alias / invalid alias"
            let v280 : bool = Fable.Core.RustInterop.emitRustExpr v279 v278 
            true
        else
            false
    let v282 : string = $"v174.get(&$0)"
    let v283 : Ref<std_string_String> option = Fable.Core.RustInterop.emitRustExpr v178 v282 
    let v284 : string = "$0.cloned()"
    let v285 : std_string_String option = Fable.Core.RustInterop.emitRustExpr v283 v284 
    let v286 : (std_string_String -> US6) = method19()
    let v287 : US6 option = v285 |> Option.map v286 
    let v298 : US6 = US6_1
    let v299 : US6 = v287 |> Option.defaultValue v298 
    match v299 with
    | US6_0(v303) -> (* Some *)
        let v304 : bool = v303 = v168 
        if v304 then
            let v307 : unit = ()
            let v308 : (unit -> unit) = closure12(v303)
            let v309 : unit = (fun () -> v308 (); v307) ()
            ()
        else
            let v352 : unit = ()
            let v353 : (unit -> unit) = closure13(v285)
            let v354 : unit = (fun () -> v353 (); v352) ()
            let v397 : string = "    v176 //"
            Fable.Core.RustInterop.emitRustExpr () v397 
            let v398 : string = "      .get_mut(&v303) //"
            Fable.Core.RustInterop.emitRustExpr () v398 
            let v399 : string = "      .unwrap() //"
            Fable.Core.RustInterop.emitRustExpr () v399 
            let v400 : string = "      .remove(&$0); //"
            Fable.Core.RustInterop.emitRustExpr v178 v400 
            let v401 : string = "  v174.insert($0.clone(), $1.clone()); //"
            Fable.Core.RustInterop.emitRustExpr struct (v178, v168) v401 
            let v402 : string = $"v170.insert($0)"
            let v403 : bool = Fable.Core.RustInterop.emitRustExpr v178 v402 
            let v404 : string = $"v172.insert($0)"
            let v405 : bool = Fable.Core.RustInterop.emitRustExpr v168 v404 
            let v406 : string = "  let new_alias_account_map = match v176.get(&$0) { //"
            Fable.Core.RustInterop.emitRustExpr v168 v406 
            let v407 : string = "    None => { //"
            Fable.Core.RustInterop.emitRustExpr () v407 
            let v408 : string = "      let mut new_map = std::collections::HashMap::new(); //"
            Fable.Core.RustInterop.emitRustExpr () v408 
            let v409 : string = "      new_map.insert($0, ($1, 0u32)); //"
            Fable.Core.RustInterop.emitRustExpr struct (v178, v182) v409 
            let v410 : string = "      new_map //"
            Fable.Core.RustInterop.emitRustExpr () v410 
            let v411 : string = "    } //"
            Fable.Core.RustInterop.emitRustExpr () v411 
            let v412 : string = "    Some(accounts) => { //"
            Fable.Core.RustInterop.emitRustExpr () v412 
            let v413 : string = "      let mut accounts_vec = accounts.iter().collect::<Vec<_>>(); //"
            Fable.Core.RustInterop.emitRustExpr () v413 
            let v414 : string = "      accounts_vec.sort_unstable_by_key(|(_, (_, index))| index); //"
            Fable.Core.RustInterop.emitRustExpr () v414 
            let v415 : string = "      let mut new_map = accounts_vec //"
            Fable.Core.RustInterop.emitRustExpr () v415 
            let v416 : string = "        .iter() //"
            Fable.Core.RustInterop.emitRustExpr () v416 
            let v417 : string = "        .enumerate() //"
            Fable.Core.RustInterop.emitRustExpr () v417 
            let v418 : string = "        .map(|(i, (signer_account_id, (timestamp, _)))| { //"
            Fable.Core.RustInterop.emitRustExpr () v418 
            let v419 : string = "          ((*signer_account_id).clone(), (*timestamp, i as u32)) //"
            Fable.Core.RustInterop.emitRustExpr () v419 
            let v420 : string = "        }) //"
            Fable.Core.RustInterop.emitRustExpr () v420 
            let v421 : string = "        .collect::<std::collections::HashMap<_, _>>(); //"
            Fable.Core.RustInterop.emitRustExpr () v421 
            let v422 : string = "      new_map.insert($0, (v182, accounts_vec.len() as u32)); //"
            Fable.Core.RustInterop.emitRustExpr v178 v422 
            let v423 : string = "      new_map //"
            Fable.Core.RustInterop.emitRustExpr () v423 
            let v424 : string = "    } //"
            Fable.Core.RustInterop.emitRustExpr () v424 
            let v425 : string = "  }; //"
            Fable.Core.RustInterop.emitRustExpr () v425 
            let v426 : string = "  v176.insert($0, new_alias_account_map); //"
            Fable.Core.RustInterop.emitRustExpr v168 v426 
            ()
    | _ ->
        let v427 : unit = ()
        let v428 : (unit -> unit) = closure13(v285)
        let v429 : unit = (fun () -> v428 (); v427) ()
        match v299 with
        | US6_1 -> (* None *)
            ()
        let v472 : string = "  v174.insert($0.clone(), $1.clone()); //"
        Fable.Core.RustInterop.emitRustExpr struct (v178, v168) v472 
        let v473 : string = $"v170.insert($0)"
        let v474 : bool = Fable.Core.RustInterop.emitRustExpr v178 v473 
        let v475 : string = $"v172.insert($0)"
        let v476 : bool = Fable.Core.RustInterop.emitRustExpr v168 v475 
        let v477 : string = "  let new_alias_account_map = match v176.get(&$0) { //"
        Fable.Core.RustInterop.emitRustExpr v168 v477 
        let v478 : string = "    None => { //"
        Fable.Core.RustInterop.emitRustExpr () v478 
        let v479 : string = "      let mut new_map = std::collections::HashMap::new(); //"
        Fable.Core.RustInterop.emitRustExpr () v479 
        let v480 : string = "      new_map.insert($0, ($1, 0u32)); //"
        Fable.Core.RustInterop.emitRustExpr struct (v178, v182) v480 
        let v481 : string = "      new_map //"
        Fable.Core.RustInterop.emitRustExpr () v481 
        let v482 : string = "    } //"
        Fable.Core.RustInterop.emitRustExpr () v482 
        let v483 : string = "    Some(accounts) => { //"
        Fable.Core.RustInterop.emitRustExpr () v483 
        let v484 : string = "      let mut accounts_vec = accounts.iter().collect::<Vec<_>>(); //"
        Fable.Core.RustInterop.emitRustExpr () v484 
        let v485 : string = "      accounts_vec.sort_unstable_by_key(|(_, (_, index))| index); //"
        Fable.Core.RustInterop.emitRustExpr () v485 
        let v486 : string = "      let mut new_map = accounts_vec //"
        Fable.Core.RustInterop.emitRustExpr () v486 
        let v487 : string = "        .iter() //"
        Fable.Core.RustInterop.emitRustExpr () v487 
        let v488 : string = "        .enumerate() //"
        Fable.Core.RustInterop.emitRustExpr () v488 
        let v489 : string = "        .map(|(i, (signer_account_id, (timestamp, _)))| { //"
        Fable.Core.RustInterop.emitRustExpr () v489 
        let v490 : string = "          ((*signer_account_id).clone(), (*timestamp, i as u32)) //"
        Fable.Core.RustInterop.emitRustExpr () v490 
        let v491 : string = "        }) //"
        Fable.Core.RustInterop.emitRustExpr () v491 
        let v492 : string = "        .collect::<std::collections::HashMap<_, _>>(); //"
        Fable.Core.RustInterop.emitRustExpr () v492 
        let v493 : string = "      new_map.insert($0, (v182, accounts_vec.len() as u32)); //"
        Fable.Core.RustInterop.emitRustExpr v178 v493 
        let v494 : string = "      new_map //"
        Fable.Core.RustInterop.emitRustExpr () v494 
        let v495 : string = "    } //"
        Fable.Core.RustInterop.emitRustExpr () v495 
        let v496 : string = "  }; //"
        Fable.Core.RustInterop.emitRustExpr () v496 
        let v497 : string = "  v176.insert($0, new_alias_account_map); //"
        Fable.Core.RustInterop.emitRustExpr v168 v497 
        ()
    let v498 : (unit -> unit) = method24()
    let v499 : unit = ()
    let v500 : (unit -> unit) = closure15(v498)
    let v501 : unit = (fun () -> v500 (); v499) ()
    let v540 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v540 
    let v541 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v541 
    let v542 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v542 
    let v543 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v543 
    let v544 : string = "true; // ??? / i: 5uy / i': 1uy / acc: 6uy / n: 3uy"
    let v545 : bool = Fable.Core.RustInterop.emitRustExpr () v544 
    let v546 : string = "true; */ // ???? / i: 5uy / i': 2uy / acc: 6uy / n: 3uy"
    let v547 : bool = Fable.Core.RustInterop.emitRustExpr () v546 
    let v548 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v548 
    let v549 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v549 
    let v550 : string = "pub fn get_account_info( //"
    Fable.Core.RustInterop.emitRustExpr () v550 
    let v551 : string = "  &self, //"
    Fable.Core.RustInterop.emitRustExpr () v551 
    let v552 : string = "  account_id: near_sdk::AccountId, //"
    Fable.Core.RustInterop.emitRustExpr () v552 
    let v553 : string = ") -> Option<(String, u64, u32)> { //"
    Fable.Core.RustInterop.emitRustExpr () v553 
    let v554 : string = $"&self.0"
    let v555 : Ref<struct (uint32 * near_sdk_store_IterableSet<near_sdk_AccountId> * near_sdk_store_IterableSet<std_string_String> * near_sdk_store_LookupMap<near_sdk_AccountId, std_string_String> * near_sdk_store_LookupMap<std_string_String, std_collections_HashMap<near_sdk_AccountId, struct (uint64 * uint32)>>)> = Fable.Core.RustInterop.emitRustExpr () v554 
    let v556 : string = $"account_id"
    let v557 : near_sdk_AccountId = Fable.Core.RustInterop.emitRustExpr () v556 
    let v558 : string = $"&v555.3"
    let v559 : Ref<near_sdk_store_LookupMap<near_sdk_AccountId, std_string_String>> = Fable.Core.RustInterop.emitRustExpr () v558 
    let v560 : string = $"&v555.4"
    let v561 : Ref<near_sdk_store_LookupMap<std_string_String, std_collections_HashMap<near_sdk_AccountId, struct (uint64 * uint32)>>> = Fable.Core.RustInterop.emitRustExpr () v560 
    let v562 : string = "let result = v559.get(&$0).and_then(|alias| { //"
    Fable.Core.RustInterop.emitRustExpr v557 v562 
    let v563 : string = "    v561 //"
    Fable.Core.RustInterop.emitRustExpr () v563 
    let v564 : string = "      .get(alias) //"
    Fable.Core.RustInterop.emitRustExpr () v564 
    let v565 : string = "      .map(|accounts| { //"
    Fable.Core.RustInterop.emitRustExpr () v565 
    let v566 : string = "          let result = (alias.clone(), *accounts.get(&v557).unwrap()); //"
    Fable.Core.RustInterop.emitRustExpr () v566 
    let v567 : string = "          (result.0, result.1.0, result.1.1) //"
    Fable.Core.RustInterop.emitRustExpr () v567 
    let v568 : string = "      }) //"
    Fable.Core.RustInterop.emitRustExpr () v568 
    let v569 : string = "}); //"
    Fable.Core.RustInterop.emitRustExpr () v569 
    let v570 : string = "result"
    let v571 : struct (std_string_String * uint64 * uint32) option = Fable.Core.RustInterop.emitRustExpr () v570 
    let v572 : unit = ()
    let v573 : (unit -> unit) = closure16(v557, v571)
    let v574 : unit = (fun () -> v573 (); v572) ()
    let v614 : unit = ()
    let v615 : (unit -> unit) = closure17()
    let v616 : unit = (fun () -> v615 (); v614) ()
    let _result = v571 in _result |> (fun x -> Fable.Core.RustInterop.emitRustExpr x "$0 } // 4") // 3
    let v655 : string = "} // 2"
    Fable.Core.RustInterop.emitRustExpr () v655 
    let v656 : string = "} // 1"
    Fable.Core.RustInterop.emitRustExpr () v656 
    let v657 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v657 
    let v658 : string = "true; // ??? / i: 6uy / i': 1uy / acc: 9uy / n: 2uy"
    let v659 : bool = Fable.Core.RustInterop.emitRustExpr () v658 
    let v660 : string = "true; */ // ???? / i: 6uy / i': 2uy / acc: 9uy / n: 2uy"
    let v661 : bool = Fable.Core.RustInterop.emitRustExpr () v660 
    let v662 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v662 
    let v663 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v663 
    let v664 : string = "pub fn get_alias_map( //"
    Fable.Core.RustInterop.emitRustExpr () v664 
    let v665 : string = "  &self, //"
    Fable.Core.RustInterop.emitRustExpr () v665 
    let v666 : string = "  alias: String, //"
    Fable.Core.RustInterop.emitRustExpr () v666 
    let v667 : string = ") -> Option<std::collections::HashMap<near_sdk::AccountId, (u64, u32)>> { //"
    Fable.Core.RustInterop.emitRustExpr () v667 
    let v668 : string = $"&self.0.4"
    let v669 : Ref<near_sdk_store_LookupMap<std_string_String, std_collections_HashMap<near_sdk_AccountId, struct (uint64 * uint32)>>> = Fable.Core.RustInterop.emitRustExpr () v668 
    let v670 : string = $"alias"
    let v671 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v670 
    let v672 : unit = ()
    let v673 : (unit -> unit) = closure18(v671)
    let v674 : unit = (fun () -> v673 (); v672) ()
    let v714 : (unit -> unit) = method30()
    let v715 : unit = ()
    let v716 : (unit -> unit) = closure19(v714)
    let v717 : unit = (fun () -> v716 (); v715) ()
    let v756 : string = "  v669.get(&$0).cloned() //"
    Fable.Core.RustInterop.emitRustExpr v671 v756 
    let v757 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v757 
    let v758 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v758 
    let v759 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v759 
    let v760 : string = "true; // ??? / i: 7uy / i': 1uy / acc: 11uy / n: 2uy"
    let v761 : bool = Fable.Core.RustInterop.emitRustExpr () v760 
    let v762 : string = "true; */ // ???? / i: 7uy / i': 2uy / acc: 11uy / n: 2uy"
    let v763 : bool = Fable.Core.RustInterop.emitRustExpr () v762 
    let v764 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v764 
    let v765 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v765 
    let v766 : string = "#[result_serializer(borsh)] //"
    Fable.Core.RustInterop.emitRustExpr () v766 
    let v767 : string = "pub fn get_alias_map_borsh( //"
    Fable.Core.RustInterop.emitRustExpr () v767 
    let v768 : string = "  &self, //"
    Fable.Core.RustInterop.emitRustExpr () v768 
    let v769 : string = "  #[serializer(borsh)] alias: String, //"
    Fable.Core.RustInterop.emitRustExpr () v769 
    let v770 : string = ") -> Option<std::collections::HashMap<near_sdk::AccountId, (u64, u32)>> { //"
    Fable.Core.RustInterop.emitRustExpr () v770 
    let v771 : string = "  self.get_alias_map(alias) //"
    Fable.Core.RustInterop.emitRustExpr () v771 
    let v772 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v772 
    let v773 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v773 
    let v774 : string = "true; // ??? / i: 8uy / i': 1uy / acc: 13uy / n: 1uy"
    let v775 : bool = Fable.Core.RustInterop.emitRustExpr () v774 
    let v776 : string = "true; */ // ???? / i: 8uy / i': 2uy / acc: 13uy / n: 1uy"
    let v777 : bool = Fable.Core.RustInterop.emitRustExpr () v776 
    let v778 : string = "fn _main() //"
    Fable.Core.RustInterop.emitRustExpr () v778 
    let v779 : string = "{ { //"
    Fable.Core.RustInterop.emitRustExpr () v779 
    let v780 : string = "true; { (); // ?? / i': 1uy / n: 14uy"
    let v781 : bool = Fable.Core.RustInterop.emitRustExpr () v780 
    let v782 : string = "true; { (); // ?? / i': 2uy / n: 14uy"
    let v783 : bool = Fable.Core.RustInterop.emitRustExpr () v782 
    let v784 : string = "true; { (); // ?? / i': 3uy / n: 14uy"
    let v785 : bool = Fable.Core.RustInterop.emitRustExpr () v784 
    let v786 : string = "true; { (); // ?? / i': 4uy / n: 14uy"
    let v787 : bool = Fable.Core.RustInterop.emitRustExpr () v786 
    let v788 : string = "true; { (); // ?? / i': 5uy / n: 14uy"
    let v789 : bool = Fable.Core.RustInterop.emitRustExpr () v788 
    let v790 : string = "true; { (); // ?? / i': 6uy / n: 14uy"
    let v791 : bool = Fable.Core.RustInterop.emitRustExpr () v790 
    let v792 : string = "true; { (); // ?? / i': 7uy / n: 14uy"
    let v793 : bool = Fable.Core.RustInterop.emitRustExpr () v792 
    let v794 : string = "true; { (); // ?? / i': 8uy / n: 14uy"
    let v795 : bool = Fable.Core.RustInterop.emitRustExpr () v794 
    let v796 : string = "true; { (); // ?? / i': 9uy / n: 14uy"
    let v797 : bool = Fable.Core.RustInterop.emitRustExpr () v796 
    let v798 : string = "true; { (); // ?? / i': 10uy / n: 14uy"
    let v799 : bool = Fable.Core.RustInterop.emitRustExpr () v798 
    let v800 : string = "true; { (); // ?? / i': 11uy / n: 14uy"
    let v801 : bool = Fable.Core.RustInterop.emitRustExpr () v800 
    let v802 : string = "true; { (); // ?? / i': 12uy / n: 14uy"
    let v803 : bool = Fable.Core.RustInterop.emitRustExpr () v802 
    let v804 : string = "true; { (); // ?? / i': 13uy / n: 14uy"
    let v805 : bool = Fable.Core.RustInterop.emitRustExpr () v804 
    let v806 : string = "true; { (); // ?? / i': 14uy / n: 14uy"
    let v807 : bool = Fable.Core.RustInterop.emitRustExpr () v806 
    let v808 : string = "true; { { (); // ? / i': 15uy / n: 14uy"
    let v809 : bool = Fable.Core.RustInterop.emitRustExpr () v808 
    ()
let v0 : (unit -> unit) = closure0()
v0 |> ignore
()
