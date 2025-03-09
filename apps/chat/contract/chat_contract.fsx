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
    | US1_0 of f0_0 : US0
    | US1_1
and [<Struct>] US2 =
    | US2_0 of f0_0 : int64
    | US2_1
and [<Struct>] US3 =
    | US3_0
    | US3_1
    | US3_2
and [<Struct>] US4 =
    | US4_0 of f0_0 : US3
    | US4_1 of f1_0 : US3
    | US4_2 of f2_0 : US3
    | US4_3 of f3_0 : US3
    | US4_4 of f4_0 : US3
    | US4_5 of f5_0 : US3
and [<Struct>] US5 =
    | US5_0 of f0_0 : string
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
and method4 (v0 : string) : string =
    v0
and method5 () : string =
    let v0 : string = ""
    v0
and closure4 () (v0 : string) : US5 =
    US5_0(v0)
and method6 () : (string -> US5) =
    closure4()
and method3 (v0 : string) : string =
    (* run_target_args'
    let v5 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v6 : string = method4(v0)
    let v7 : string = "std::env::var(&*$0)"
    let v8 : Result<std_string_String, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr v6 v7 
    let v9 : string = "true; let _result_map_ = $0.map(|x| { //"
    let v10 : bool = Fable.Core.RustInterop.emitRustExpr v8 v9 
    let v11 : string = "x"
    let v12 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v11 
    let v13 : string = "fable_library_rust::String_::fromString($0)"
    let v14 : string = Fable.Core.RustInterop.emitRustExpr v12 v13 
    let v15 : string = "true; $0 })"
    let v16 : bool = Fable.Core.RustInterop.emitRustExpr v14 v15 
    let v17 : string = "_result_map_"
    let v18 : Result<string, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr () v17 
    let v19 : string = method5()
    let v20 : string = "$0.unwrap_or($1)"
    let v21 : string = Fable.Core.RustInterop.emitRustExpr struct (v18, v19) v20 
    let _run_target_args'_v5 = v21 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v22 : US3 = US3_1
    let v23 : US4 = US4_3(v22)
    let v24 : string = $"env.get_environment_variable / target: {v23} / var: {v0}"
    let v25 : string = failwith<string> v24
    let _run_target_args'_v5 = v25 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v26 : US3 = US3_2
    let v27 : US4 = US4_3(v26)
    let v28 : string = $"env.get_environment_variable / target: {v27} / var: {v0}"
    let v29 : string = failwith<string> v28
    let _run_target_args'_v5 = v29 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v30 : string = "process.env[$0] ?? \"\""
    let v31 : string = Fable.Core.JsInterop.emitJsExpr v0 v30 
    let _run_target_args'_v5 = v31 
    #endif
#if FABLE_COMPILER_PYTHON
    let v33 : string = "os"
    let v34 : IOsEnviron = Fable.Core.PyInterop.importAll v33 
    let v35 : string = "v34.environ"
    let v36 : obj = Fable.Core.PyInterop.emitPyExpr () v35 
    let v40 : string = "v36.get($0)"
    let v41 : string = Fable.Core.PyInterop.emitPyExpr v0 v40 
    let mutable _v41 = None
    #if !FABLE_COMPILER && !WASM && !CONTRACT
    let v45 : (string -> string option) = Option.ofObj
    let v46 : string option = v45 v41
    v46 
    #else
    Some v41 
    #endif
    |> fun x -> _v41 <- Some x
    let v47 : string option = match _v41 with Some x -> x | None -> failwith "optionm'.of_obj / _v41=None"
    let v52 : (string -> US5) = method6()
    let v53 : US5 option = v47 |> Option.map v52 
    let v67 : US5 = US5_1
    let v68 : US5 = v53 |> Option.defaultValue v67 
    let v75 : string =
        match v68 with
        | US5_1 -> (* None *)
            let v73 : string = ""
            v73
        | US5_0(v72) -> (* Some *)
            v72
    let _run_target_args'_v5 = v75 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v76 : US3 = US3_1
    let v77 : US4 = US4_1(v76)
    let v78 : string = $"env.get_environment_variable / target: {v77} / var: {v0}"
    let v79 : string = failwith<string> v78
    let _run_target_args'_v5 = v79 
    #endif
#else
    let v80 : (string -> string) = System.Environment.GetEnvironmentVariable
    let v81 : string = v80 v0
    let mutable _v81 = None
    #if !FABLE_COMPILER && !WASM && !CONTRACT
    let v83 : (string -> string option) = Option.ofObj
    let v84 : string option = v83 v81
    v84 
    #else
    Some v81 
    #endif
    |> fun x -> _v81 <- Some x
    let v85 : string option = match _v81 with Some x -> x | None -> failwith "optionm'.of_obj / _v81=None"
    let v90 : (string -> US5) = method6()
    let v91 : US5 option = v85 |> Option.map v90 
    let v105 : US5 = US5_1
    let v106 : US5 = v91 |> Option.defaultValue v105 
    let v113 : string =
        match v106 with
        | US5_1 -> (* None *)
            let v111 : string = ""
            v111
        | US5_0(v110) -> (* Some *)
            v110
    let _run_target_args'_v5 = v113 
    #endif
    let v114 : string = _run_target_args'_v5 
    v114
and method2 () : struct (US1 * US2) =
    let v0 : string = "TRACE_LEVEL"
    let v1 : string = method3(v0)
    
    
    
    
    
    
    
    
    
    
    let v4 : string = "Critical"
    let v5 : (unit -> string) = v4.ToLower
    let v6 : string = v5 ()
    let v11 : string = "Warning"
    let v12 : (unit -> string) = v11.ToLower
    let v13 : string = v12 ()
    let v18 : string = "Info"
    let v19 : (unit -> string) = v18.ToLower
    let v20 : string = v19 ()
    let v25 : string = "Debug"
    let v26 : (unit -> string) = v25.ToLower
    let v27 : string = v26 ()
    let v32 : string = "Verbose"
    let v33 : (unit -> string) = v32.ToLower
    let v34 : string = v33 ()
    let v37 : bool = "Verbose" = v1
    let v41 : US1 =
        if v37 then
            let v38 : US0 = US0_0
            US1_0(v38)
        else
            US1_1
    let v127 : US1 =
        match v41 with
        | US1_1 -> (* None *)
            let v44 : bool = "Debug" = v1
            let v48 : US1 =
                if v44 then
                    let v45 : US0 = US0_1
                    US1_0(v45)
                else
                    US1_1
            match v48 with
            | US1_1 -> (* None *)
                let v51 : bool = "Info" = v1
                let v55 : US1 =
                    if v51 then
                        let v52 : US0 = US0_2
                        US1_0(v52)
                    else
                        US1_1
                match v55 with
                | US1_1 -> (* None *)
                    let v58 : bool = "Warning" = v1
                    let v62 : US1 =
                        if v58 then
                            let v59 : US0 = US0_3
                            US1_0(v59)
                        else
                            US1_1
                    match v62 with
                    | US1_1 -> (* None *)
                        let v65 : bool = "Critical" = v1
                        let v69 : US1 =
                            if v65 then
                                let v66 : US0 = US0_4
                                US1_0(v66)
                            else
                                US1_1
                        match v69 with
                        | US1_1 -> (* None *)
                            let v72 : bool = v34 = v1
                            let v76 : US1 =
                                if v72 then
                                    let v73 : US0 = US0_0
                                    US1_0(v73)
                                else
                                    US1_1
                            match v76 with
                            | US1_1 -> (* None *)
                                let v79 : bool = v27 = v1
                                let v83 : US1 =
                                    if v79 then
                                        let v80 : US0 = US0_1
                                        US1_0(v80)
                                    else
                                        US1_1
                                match v83 with
                                | US1_1 -> (* None *)
                                    let v86 : bool = v20 = v1
                                    let v90 : US1 =
                                        if v86 then
                                            let v87 : US0 = US0_2
                                            US1_0(v87)
                                        else
                                            US1_1
                                    match v90 with
                                    | US1_1 -> (* None *)
                                        let v93 : bool = v13 = v1
                                        let v97 : US1 =
                                            if v93 then
                                                let v94 : US0 = US0_3
                                                US1_0(v94)
                                            else
                                                US1_1
                                        match v97 with
                                        | US1_1 -> (* None *)
                                            let v100 : bool = v6 = v1
                                            let v104 : US1 =
                                                if v100 then
                                                    let v101 : US0 = US0_4
                                                    US1_0(v101)
                                                else
                                                    US1_1
                                            match v104 with
                                            | US1_1 -> (* None *)
                                                US1_1
                                            | US1_0(v105) -> (* Some *)
                                                US1_0(v105)
                                        | US1_0(v98) -> (* Some *)
                                            US1_0(v98)
                                    | US1_0(v91) -> (* Some *)
                                        US1_0(v91)
                                | US1_0(v84) -> (* Some *)
                                    US1_0(v84)
                            | US1_0(v77) -> (* Some *)
                                US1_0(v77)
                        | US1_0(v70) -> (* Some *)
                            US1_0(v70)
                    | US1_0(v63) -> (* Some *)
                        US1_0(v63)
                | US1_0(v56) -> (* Some *)
                    US1_0(v56)
            | US1_0(v49) -> (* Some *)
                US1_0(v49)
        | US1_0(v42) -> (* Some *)
            US1_0(v42)
    let v128 : string = "AUTOMATION"
    let v129 : string = method3(v128)
    let v132 : string = "True"
    let v133 : bool = v129 <> v132 
    let v200 : US2 =
        if v133 then
            US2_1
        else
            (* run_target_args'
            let v139 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v140 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v139 = v140 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v141 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v139 = v141 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v143 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v139 = v143 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v146 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v139 = v146 
            #endif
#if FABLE_COMPILER_PYTHON
            let v147 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v139 = v147 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v148 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v139 = v148 
            #endif
#else
            let v149 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v139 = v149 
            #endif
            let v150 : System.DateTime = _run_target_args'_v139 
            (* run_target_args'
            let v158 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v159 : (System.DateTime -> int64) = _.Ticks
            let v160 : int64 = v159 v150
            let _run_target_args'_v158 = v160 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v161 : (System.DateTime -> int64) = _.Ticks
            let v162 : int64 = v161 v150
            let _run_target_args'_v158 = v162 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v164 : int64 = null |> unbox<int64>
            let _run_target_args'_v158 = v164 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v167 : (System.DateTime -> int64) = _.Ticks
            let v168 : int64 = v167 v150
            let _run_target_args'_v158 = v168 
            #endif
#if FABLE_COMPILER_PYTHON
            let v169 : (System.DateTime -> int64) = _.Ticks
            let v170 : int64 = v169 v150
            let _run_target_args'_v158 = v170 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v171 : (System.DateTime -> int64) = _.Ticks
            let v172 : int64 = v171 v150
            let _run_target_args'_v158 = v172 
            #endif
#else
            let v173 : (System.DateTime -> int64) = _.Ticks
            let v174 : int64 = v173 v150
            let _run_target_args'_v158 = v174 
            #endif
            let v175 : int64 = _run_target_args'_v158 
            let v196 : int64 = v175 |> int64 
            US2_0(v196)
    struct (v127, v200)
and closure5 () (v0 : string) : unit =
    ()
and method1 (v0 : US0) : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) =
    (* run_target_args'
    let v3 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let struct (v4 : US1, v5 : US2) = method2()
    let _run_target_args'_v3 = struct (v4, v5) 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v6 : US1 = US1_1
    let v7 : US2 = US2_1
    let _run_target_args'_v3 = struct (v6, v7) 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v8 : string = "AUTOMATION"
    (* run_target_args'
    let v13 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v14 : string = "option_env!(\"" + v8 + "\").unwrap_or(\"\")"
    let v15 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v14 
    (* run_target_args'
    let v20 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v21 : string = "String::from($0)"
    let v22 : std_string_String = Fable.Core.RustInterop.emitRustExpr v15 v21 
    let _run_target_args'_v20 = v22 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v23 : string = "String::from($0)"
    let v24 : std_string_String = Fable.Core.RustInterop.emitRustExpr v15 v23 
    let _run_target_args'_v20 = v24 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v25 : string = "String::from($0)"
    let v26 : std_string_String = Fable.Core.RustInterop.emitRustExpr v15 v25 
    let _run_target_args'_v20 = v26 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v28 : std_string_String = v15 |> unbox<std_string_String>
    let _run_target_args'_v20 = v28 
    #endif
#if FABLE_COMPILER_PYTHON
    let v32 : std_string_String = v15 |> unbox<std_string_String>
    let _run_target_args'_v20 = v32 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v36 : std_string_String = v15 |> unbox<std_string_String>
    let _run_target_args'_v20 = v36 
    #endif
#else
    let v40 : std_string_String = v15 |> unbox<std_string_String>
    let _run_target_args'_v20 = v40 
    #endif
    let v43 : std_string_String = _run_target_args'_v20 
    let v49 : string = "fable_library_rust::String_::fromString($0)"
    let v50 : string = Fable.Core.RustInterop.emitRustExpr v43 v49 
    let _run_target_args'_v13 = v50 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v51 : string = "option_env!(\"" + v8 + "\").unwrap_or(\"\")"
    let v52 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v51 
    (* run_target_args'
    let v57 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v58 : string = "String::from($0)"
    let v59 : std_string_String = Fable.Core.RustInterop.emitRustExpr v52 v58 
    let _run_target_args'_v57 = v59 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v60 : string = "String::from($0)"
    let v61 : std_string_String = Fable.Core.RustInterop.emitRustExpr v52 v60 
    let _run_target_args'_v57 = v61 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v62 : string = "String::from($0)"
    let v63 : std_string_String = Fable.Core.RustInterop.emitRustExpr v52 v62 
    let _run_target_args'_v57 = v63 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v65 : std_string_String = v52 |> unbox<std_string_String>
    let _run_target_args'_v57 = v65 
    #endif
#if FABLE_COMPILER_PYTHON
    let v69 : std_string_String = v52 |> unbox<std_string_String>
    let _run_target_args'_v57 = v69 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v73 : std_string_String = v52 |> unbox<std_string_String>
    let _run_target_args'_v57 = v73 
    #endif
#else
    let v77 : std_string_String = v52 |> unbox<std_string_String>
    let _run_target_args'_v57 = v77 
    #endif
    let v80 : std_string_String = _run_target_args'_v57 
    let v86 : string = "fable_library_rust::String_::fromString($0)"
    let v87 : string = Fable.Core.RustInterop.emitRustExpr v80 v86 
    let _run_target_args'_v13 = v87 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v88 : string = "option_env!(\"" + v8 + "\").unwrap_or(\"\")"
    let v89 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v88 
    (* run_target_args'
    let v94 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v95 : string = "String::from($0)"
    let v96 : std_string_String = Fable.Core.RustInterop.emitRustExpr v89 v95 
    let _run_target_args'_v94 = v96 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v97 : string = "String::from($0)"
    let v98 : std_string_String = Fable.Core.RustInterop.emitRustExpr v89 v97 
    let _run_target_args'_v94 = v98 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v99 : string = "String::from($0)"
    let v100 : std_string_String = Fable.Core.RustInterop.emitRustExpr v89 v99 
    let _run_target_args'_v94 = v100 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v102 : std_string_String = v89 |> unbox<std_string_String>
    let _run_target_args'_v94 = v102 
    #endif
#if FABLE_COMPILER_PYTHON
    let v106 : std_string_String = v89 |> unbox<std_string_String>
    let _run_target_args'_v94 = v106 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v110 : std_string_String = v89 |> unbox<std_string_String>
    let _run_target_args'_v94 = v110 
    #endif
#else
    let v114 : std_string_String = v89 |> unbox<std_string_String>
    let _run_target_args'_v94 = v114 
    #endif
    let v117 : std_string_String = _run_target_args'_v94 
    let v123 : string = "fable_library_rust::String_::fromString($0)"
    let v124 : string = Fable.Core.RustInterop.emitRustExpr v117 v123 
    let _run_target_args'_v13 = v124 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v126 : string = null |> unbox<string>
    let _run_target_args'_v13 = v126 
    #endif
#if FABLE_COMPILER_PYTHON
    let v130 : string = null |> unbox<string>
    let _run_target_args'_v13 = v130 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v134 : string = null |> unbox<string>
    let _run_target_args'_v13 = v134 
    #endif
#else
    let v138 : string = null |> unbox<string>
    let _run_target_args'_v13 = v138 
    #endif
    let v141 : string = _run_target_args'_v13 
    let v149 : string = "True"
    let v150 : bool = v141 <> v149 
    let v162 : US2 =
        if v150 then
            US2_1
        else
            let v154 : string = $"near_sdk::env::block_timestamp()"
            let v155 : uint64 = Fable.Core.RustInterop.emitRustExpr () v154 
            let v157 : (uint64 -> int64) = int64
            let v158 : int64 = v157 v155
            US2_0(v158)
    let v163 : US1 = US1_1
    let _run_target_args'_v3 = struct (v163, v162) 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let struct (v164 : US1, v165 : US2) = method2()
    let _run_target_args'_v3 = struct (v164, v165) 
    #endif
#if FABLE_COMPILER_PYTHON
    let struct (v166 : US1, v167 : US2) = method2()
    let _run_target_args'_v3 = struct (v166, v167) 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let struct (v168 : US1, v169 : US2) = method2()
    let _run_target_args'_v3 = struct (v168, v169) 
    #endif
#else
    let struct (v170 : US1, v171 : US2) = method2()
    let _run_target_args'_v3 = struct (v170, v171) 
    #endif
    let struct (v172 : US1, v173 : US2) = _run_target_args'_v3 
    let v178 : Mut0 = {l0 = 1L} : Mut0
    let v179 : (string -> unit) = closure5()
    let v180 : Mut1 = {l0 = v179} : Mut1
    let v181 : Mut2 = {l0 = true} : Mut2
    let v182 : string = ""
    let v183 : Mut3 = {l0 = v182} : Mut3
    let v186 : US0 =
        match v172 with
        | US1_1 -> (* None *)
            v0
        | US1_0(v184) -> (* Some *)
            v184
    let v187 : Mut4 = {l0 = v186} : Mut4
    let v195 : int64 option =
        match v173 with
        | US2_1 -> (* None *)
            let v193 : int64 option = None
            v193
        | US2_0(v188) -> (* Some *)
            let v190 : int64 option = Some v188 
            v190
    struct (v178, v180, v181, v183, v187, v195)
and closure3 () () : unit =
    let v0 : bool = TraceState.trace_state.IsNone
    if v0 then
        let v1 : US0 = US0_0
        let struct (v2 : Mut0, v3 : Mut1, v4 : Mut2, v5 : Mut3, v6 : Mut4, v7 : int64 option) = method1(v1)
        let v9 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v2, v3, v4, v5, v6, v7) 
        TraceState.trace_state <- v9 
        ()
and method0 (v0 : US0) : bool =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure3()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v24 : Mut0, v25 : Mut1, v26 : Mut2, v27 : Mut3, v28 : Mut4, v29 : int64 option) = TraceState.trace_state.Value
    let v42 : US0 = v28.l0
    let v43 : bool = v26.l0
    let v44 : bool = v43 = false
    if v44 then
        false
    else
        let v45 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v0
        let v46 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v42
        let v47 : bool = v45 >= v46
        v47
and closure6 () (v0 : int64) : US2 =
    US2_0(v0)
and method8 () : (int64 -> US2) =
    closure6()
and method9 () : string =
    let v0 : string = "hh:mm:ss"
    v0
and method10 () : string =
    let v0 : string = "HH:mm:ss"
    v0
and method7 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option) : string =
    (* run_target_args'
    let v167 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v170 : (int64 -> US2) = method8()
    let v171 : US2 option = v5 |> Option.map v170 
    let v185 : US2 = US2_1
    let v186 : US2 = v171 |> Option.defaultValue v185 
    let v304 : System.DateTime =
        match v186 with
        | US2_1 -> (* None *)
            (* run_target_args'
            let v287 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v288 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v287 = v288 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v289 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v287 = v289 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v291 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v287 = v291 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v294 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v287 = v294 
            #endif
#if FABLE_COMPILER_PYTHON
            let v295 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v287 = v295 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v296 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v287 = v296 
            #endif
#else
            let v297 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v287 = v297 
            #endif
            let v298 : System.DateTime = _run_target_args'_v287 
            v298
        | US2_0(v190) -> (* Some *)
            (* run_target_args'
            let v193 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v194 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v193 = v194 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v195 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v193 = v195 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v197 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v193 = v197 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v200 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v193 = v200 
            #endif
#if FABLE_COMPILER_PYTHON
            let v201 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v193 = v201 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v202 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v193 = v202 
            #endif
#else
            let v203 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v193 = v203 
            #endif
            let v204 : System.DateTime = _run_target_args'_v193 
            (* run_target_args'
            let v212 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v213 : (System.DateTime -> int64) = _.Ticks
            let v214 : int64 = v213 v204
            let _run_target_args'_v212 = v214 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v215 : (System.DateTime -> int64) = _.Ticks
            let v216 : int64 = v215 v204
            let _run_target_args'_v212 = v216 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v218 : int64 = null |> unbox<int64>
            let _run_target_args'_v212 = v218 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v221 : (System.DateTime -> int64) = _.Ticks
            let v222 : int64 = v221 v204
            let _run_target_args'_v212 = v222 
            #endif
#if FABLE_COMPILER_PYTHON
            let v223 : (System.DateTime -> int64) = _.Ticks
            let v224 : int64 = v223 v204
            let _run_target_args'_v212 = v224 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v225 : (System.DateTime -> int64) = _.Ticks
            let v226 : int64 = v225 v204
            let _run_target_args'_v212 = v226 
            #endif
#else
            let v227 : (System.DateTime -> int64) = _.Ticks
            let v228 : int64 = v227 v204
            let _run_target_args'_v212 = v228 
            #endif
            let v229 : int64 = _run_target_args'_v212 
            let v250 : int64 = v229 |> int64 
            let v253 : int64 = v250 - v190
            let v256 : System.TimeSpan = v253 |> System.TimeSpan 
            let v262 : (System.TimeSpan -> int32) = _.Hours
            let v263 : int32 = v262 v256
            let v267 : (System.TimeSpan -> int32) = _.Minutes
            let v268 : int32 = v267 v256
            let v272 : (System.TimeSpan -> int32) = _.Seconds
            let v273 : int32 = v272 v256
            let v277 : (System.TimeSpan -> int32) = _.Milliseconds
            let v278 : int32 = v277 v256
            let v282 : System.DateTime = System.DateTime (1, 1, 1, v263, v268, v273, v278)
            v282
    let v306 : string = method9()
    let v310 : bool = v306 = ""
    let v312 : string =
        if v310 then
            let v311 : string = "M-d-y hh:mm:ss tt"
            v311
        else
            v306
    let v313 : (string -> string) = v304.ToString
    let v314 : string = v313 v312
    let _run_target_args'_v167 = v314 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v331 : (int64 -> US2) = method8()
    let v332 : US2 option = v5 |> Option.map v331 
    let v346 : US2 = US2_1
    let v347 : US2 = v332 |> Option.defaultValue v346 
    let v465 : System.DateTime =
        match v347 with
        | US2_1 -> (* None *)
            (* run_target_args'
            let v448 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v449 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v448 = v449 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v450 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v448 = v450 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v452 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v448 = v452 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v455 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v448 = v455 
            #endif
#if FABLE_COMPILER_PYTHON
            let v456 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v448 = v456 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v457 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v448 = v457 
            #endif
#else
            let v458 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v448 = v458 
            #endif
            let v459 : System.DateTime = _run_target_args'_v448 
            v459
        | US2_0(v351) -> (* Some *)
            (* run_target_args'
            let v354 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v355 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v354 = v355 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v356 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v354 = v356 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v358 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v354 = v358 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v361 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v354 = v361 
            #endif
#if FABLE_COMPILER_PYTHON
            let v362 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v354 = v362 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v363 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v354 = v363 
            #endif
#else
            let v364 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v354 = v364 
            #endif
            let v365 : System.DateTime = _run_target_args'_v354 
            (* run_target_args'
            let v373 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v374 : (System.DateTime -> int64) = _.Ticks
            let v375 : int64 = v374 v365
            let _run_target_args'_v373 = v375 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v376 : (System.DateTime -> int64) = _.Ticks
            let v377 : int64 = v376 v365
            let _run_target_args'_v373 = v377 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v379 : int64 = null |> unbox<int64>
            let _run_target_args'_v373 = v379 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v382 : (System.DateTime -> int64) = _.Ticks
            let v383 : int64 = v382 v365
            let _run_target_args'_v373 = v383 
            #endif
#if FABLE_COMPILER_PYTHON
            let v384 : (System.DateTime -> int64) = _.Ticks
            let v385 : int64 = v384 v365
            let _run_target_args'_v373 = v385 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v386 : (System.DateTime -> int64) = _.Ticks
            let v387 : int64 = v386 v365
            let _run_target_args'_v373 = v387 
            #endif
#else
            let v388 : (System.DateTime -> int64) = _.Ticks
            let v389 : int64 = v388 v365
            let _run_target_args'_v373 = v389 
            #endif
            let v390 : int64 = _run_target_args'_v373 
            let v411 : int64 = v390 |> int64 
            let v414 : int64 = v411 - v351
            let v417 : System.TimeSpan = v414 |> System.TimeSpan 
            let v423 : (System.TimeSpan -> int32) = _.Hours
            let v424 : int32 = v423 v417
            let v428 : (System.TimeSpan -> int32) = _.Minutes
            let v429 : int32 = v428 v417
            let v433 : (System.TimeSpan -> int32) = _.Seconds
            let v434 : int32 = v433 v417
            let v438 : (System.TimeSpan -> int32) = _.Milliseconds
            let v439 : int32 = v438 v417
            let v443 : System.DateTime = System.DateTime (1, 1, 1, v424, v429, v434, v439)
            v443
    let v467 : string = method9()
    let v471 : bool = v467 = ""
    let v473 : string =
        if v471 then
            let v472 : string = "M-d-y hh:mm:ss tt"
            v472
        else
            v467
    let v474 : (string -> string) = v465.ToString
    let v475 : string = v474 v473
    let _run_target_args'_v167 = v475 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v490 : string = $"near_sdk::env::block_timestamp()"
    let v491 : uint64 = Fable.Core.RustInterop.emitRustExpr () v490 
    let v494 : (int64 -> US2) = method8()
    let v495 : US2 option = v5 |> Option.map v494 
    let v509 : US2 = US2_1
    let v510 : US2 = v495 |> Option.defaultValue v509 
    let v522 : uint64 =
        match v510 with
        | US2_1 -> (* None *)
            v491
        | US2_0(v514) -> (* Some *)
            let v516 : (int64 -> uint64) = uint64
            let v517 : uint64 = v516 v514
            let v520 : uint64 = v491 - v517
            v520
    let v523 : uint64 = v522 / 1000000000UL
    let v524 : uint64 = v523 % 60UL
    let v525 : uint64 = v523 / 60UL
    let v526 : uint64 = v525 % 60UL
    let v527 : uint64 = v523 / 3600UL
    let v528 : uint64 = v527 % 24UL
    let v529 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
    let v530 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v528, v526, v524) v529 
    let v531 : string = "fable_library_rust::String_::fromString($0)"
    let v532 : string = Fable.Core.RustInterop.emitRustExpr v530 v531 
    let _run_target_args'_v167 = v532 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v535 : (int64 -> US2) = method8()
    let v536 : US2 option = v5 |> Option.map v535 
    let v550 : US2 = US2_1
    let v551 : US2 = v536 |> Option.defaultValue v550 
    let v669 : System.DateTime =
        match v551 with
        | US2_1 -> (* None *)
            (* run_target_args'
            let v652 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v653 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v652 = v653 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v654 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v652 = v654 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v656 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v652 = v656 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v659 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v652 = v659 
            #endif
#if FABLE_COMPILER_PYTHON
            let v660 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v652 = v660 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v661 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v652 = v661 
            #endif
#else
            let v662 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v652 = v662 
            #endif
            let v663 : System.DateTime = _run_target_args'_v652 
            v663
        | US2_0(v555) -> (* Some *)
            (* run_target_args'
            let v558 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v559 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v558 = v559 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v560 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v558 = v560 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v562 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v558 = v562 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v565 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v558 = v565 
            #endif
#if FABLE_COMPILER_PYTHON
            let v566 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v558 = v566 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v567 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v558 = v567 
            #endif
#else
            let v568 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v558 = v568 
            #endif
            let v569 : System.DateTime = _run_target_args'_v558 
            (* run_target_args'
            let v577 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v578 : (System.DateTime -> int64) = _.Ticks
            let v579 : int64 = v578 v569
            let _run_target_args'_v577 = v579 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v580 : (System.DateTime -> int64) = _.Ticks
            let v581 : int64 = v580 v569
            let _run_target_args'_v577 = v581 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v583 : int64 = null |> unbox<int64>
            let _run_target_args'_v577 = v583 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v586 : (System.DateTime -> int64) = _.Ticks
            let v587 : int64 = v586 v569
            let _run_target_args'_v577 = v587 
            #endif
#if FABLE_COMPILER_PYTHON
            let v588 : (System.DateTime -> int64) = _.Ticks
            let v589 : int64 = v588 v569
            let _run_target_args'_v577 = v589 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v590 : (System.DateTime -> int64) = _.Ticks
            let v591 : int64 = v590 v569
            let _run_target_args'_v577 = v591 
            #endif
#else
            let v592 : (System.DateTime -> int64) = _.Ticks
            let v593 : int64 = v592 v569
            let _run_target_args'_v577 = v593 
            #endif
            let v594 : int64 = _run_target_args'_v577 
            let v615 : int64 = v594 |> int64 
            let v618 : int64 = v615 - v555
            let v621 : System.TimeSpan = v618 |> System.TimeSpan 
            let v627 : (System.TimeSpan -> int32) = _.Hours
            let v628 : int32 = v627 v621
            let v632 : (System.TimeSpan -> int32) = _.Minutes
            let v633 : int32 = v632 v621
            let v637 : (System.TimeSpan -> int32) = _.Seconds
            let v638 : int32 = v637 v621
            let v642 : (System.TimeSpan -> int32) = _.Milliseconds
            let v643 : int32 = v642 v621
            let v647 : System.DateTime = System.DateTime (1, 1, 1, v628, v633, v638, v643)
            v647
    let v671 : string = method10()
    let v675 : bool = v671 = ""
    let v677 : string =
        if v675 then
            let v676 : string = "M-d-y hh:mm:ss tt"
            v676
        else
            v671
    let v678 : (string -> string) = v669.ToString
    let v679 : string = v678 v677
    let _run_target_args'_v167 = v679 
    #endif
#if FABLE_COMPILER_PYTHON
    let v696 : (int64 -> US2) = method8()
    let v697 : US2 option = v5 |> Option.map v696 
    let v711 : US2 = US2_1
    let v712 : US2 = v697 |> Option.defaultValue v711 
    let v830 : System.DateTime =
        match v712 with
        | US2_1 -> (* None *)
            (* run_target_args'
            let v813 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v814 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v813 = v814 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v815 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v813 = v815 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v817 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v813 = v817 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v820 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v813 = v820 
            #endif
#if FABLE_COMPILER_PYTHON
            let v821 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v813 = v821 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v822 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v813 = v822 
            #endif
#else
            let v823 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v813 = v823 
            #endif
            let v824 : System.DateTime = _run_target_args'_v813 
            v824
        | US2_0(v716) -> (* Some *)
            (* run_target_args'
            let v719 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v720 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v719 = v720 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v721 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v719 = v721 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v723 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v719 = v723 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v726 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v719 = v726 
            #endif
#if FABLE_COMPILER_PYTHON
            let v727 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v719 = v727 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v728 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v719 = v728 
            #endif
#else
            let v729 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v719 = v729 
            #endif
            let v730 : System.DateTime = _run_target_args'_v719 
            (* run_target_args'
            let v738 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v739 : (System.DateTime -> int64) = _.Ticks
            let v740 : int64 = v739 v730
            let _run_target_args'_v738 = v740 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v741 : (System.DateTime -> int64) = _.Ticks
            let v742 : int64 = v741 v730
            let _run_target_args'_v738 = v742 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v744 : int64 = null |> unbox<int64>
            let _run_target_args'_v738 = v744 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v747 : (System.DateTime -> int64) = _.Ticks
            let v748 : int64 = v747 v730
            let _run_target_args'_v738 = v748 
            #endif
#if FABLE_COMPILER_PYTHON
            let v749 : (System.DateTime -> int64) = _.Ticks
            let v750 : int64 = v749 v730
            let _run_target_args'_v738 = v750 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v751 : (System.DateTime -> int64) = _.Ticks
            let v752 : int64 = v751 v730
            let _run_target_args'_v738 = v752 
            #endif
#else
            let v753 : (System.DateTime -> int64) = _.Ticks
            let v754 : int64 = v753 v730
            let _run_target_args'_v738 = v754 
            #endif
            let v755 : int64 = _run_target_args'_v738 
            let v776 : int64 = v755 |> int64 
            let v779 : int64 = v776 - v716
            let v782 : System.TimeSpan = v779 |> System.TimeSpan 
            let v788 : (System.TimeSpan -> int32) = _.Hours
            let v789 : int32 = v788 v782
            let v793 : (System.TimeSpan -> int32) = _.Minutes
            let v794 : int32 = v793 v782
            let v798 : (System.TimeSpan -> int32) = _.Seconds
            let v799 : int32 = v798 v782
            let v803 : (System.TimeSpan -> int32) = _.Milliseconds
            let v804 : int32 = v803 v782
            let v808 : System.DateTime = System.DateTime (1, 1, 1, v789, v794, v799, v804)
            v808
    let v832 : string = method10()
    let v836 : bool = v832 = ""
    let v838 : string =
        if v836 then
            let v837 : string = "M-d-y hh:mm:ss tt"
            v837
        else
            v832
    let v839 : (string -> string) = v830.ToString
    let v840 : string = v839 v838
    let _run_target_args'_v167 = v840 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v857 : (int64 -> US2) = method8()
    let v858 : US2 option = v5 |> Option.map v857 
    let v872 : US2 = US2_1
    let v873 : US2 = v858 |> Option.defaultValue v872 
    let v991 : System.DateTime =
        match v873 with
        | US2_1 -> (* None *)
            (* run_target_args'
            let v974 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v975 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v974 = v975 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v976 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v974 = v976 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v978 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v974 = v978 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v981 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v974 = v981 
            #endif
#if FABLE_COMPILER_PYTHON
            let v982 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v974 = v982 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v983 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v974 = v983 
            #endif
#else
            let v984 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v974 = v984 
            #endif
            let v985 : System.DateTime = _run_target_args'_v974 
            v985
        | US2_0(v877) -> (* Some *)
            (* run_target_args'
            let v880 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v881 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v880 = v881 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v882 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v880 = v882 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v884 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v880 = v884 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v887 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v880 = v887 
            #endif
#if FABLE_COMPILER_PYTHON
            let v888 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v880 = v888 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v889 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v880 = v889 
            #endif
#else
            let v890 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v880 = v890 
            #endif
            let v891 : System.DateTime = _run_target_args'_v880 
            (* run_target_args'
            let v899 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v900 : (System.DateTime -> int64) = _.Ticks
            let v901 : int64 = v900 v891
            let _run_target_args'_v899 = v901 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v902 : (System.DateTime -> int64) = _.Ticks
            let v903 : int64 = v902 v891
            let _run_target_args'_v899 = v903 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v905 : int64 = null |> unbox<int64>
            let _run_target_args'_v899 = v905 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v908 : (System.DateTime -> int64) = _.Ticks
            let v909 : int64 = v908 v891
            let _run_target_args'_v899 = v909 
            #endif
#if FABLE_COMPILER_PYTHON
            let v910 : (System.DateTime -> int64) = _.Ticks
            let v911 : int64 = v910 v891
            let _run_target_args'_v899 = v911 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v912 : (System.DateTime -> int64) = _.Ticks
            let v913 : int64 = v912 v891
            let _run_target_args'_v899 = v913 
            #endif
#else
            let v914 : (System.DateTime -> int64) = _.Ticks
            let v915 : int64 = v914 v891
            let _run_target_args'_v899 = v915 
            #endif
            let v916 : int64 = _run_target_args'_v899 
            let v937 : int64 = v916 |> int64 
            let v940 : int64 = v937 - v877
            let v943 : System.TimeSpan = v940 |> System.TimeSpan 
            let v949 : (System.TimeSpan -> int32) = _.Hours
            let v950 : int32 = v949 v943
            let v954 : (System.TimeSpan -> int32) = _.Minutes
            let v955 : int32 = v954 v943
            let v959 : (System.TimeSpan -> int32) = _.Seconds
            let v960 : int32 = v959 v943
            let v964 : (System.TimeSpan -> int32) = _.Milliseconds
            let v965 : int32 = v964 v943
            let v969 : System.DateTime = System.DateTime (1, 1, 1, v950, v955, v960, v965)
            v969
    let v993 : string = method10()
    let v997 : bool = v993 = ""
    let v999 : string =
        if v997 then
            let v998 : string = "M-d-y hh:mm:ss tt"
            v998
        else
            v993
    let v1000 : (string -> string) = v991.ToString
    let v1001 : string = v1000 v999
    let _run_target_args'_v167 = v1001 
    #endif
#else
    let v1018 : (int64 -> US2) = method8()
    let v1019 : US2 option = v5 |> Option.map v1018 
    let v1033 : US2 = US2_1
    let v1034 : US2 = v1019 |> Option.defaultValue v1033 
    let v1152 : System.DateTime =
        match v1034 with
        | US2_1 -> (* None *)
            (* run_target_args'
            let v1135 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1136 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1135 = v1136 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1137 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1135 = v1137 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1139 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v1135 = v1139 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1142 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1135 = v1142 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1143 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1135 = v1143 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1144 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1135 = v1144 
            #endif
#else
            let v1145 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1135 = v1145 
            #endif
            let v1146 : System.DateTime = _run_target_args'_v1135 
            v1146
        | US2_0(v1038) -> (* Some *)
            (* run_target_args'
            let v1041 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1042 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1041 = v1042 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1043 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1041 = v1043 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1045 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v1041 = v1045 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1048 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1041 = v1048 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1049 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1041 = v1049 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1050 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1041 = v1050 
            #endif
#else
            let v1051 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1041 = v1051 
            #endif
            let v1052 : System.DateTime = _run_target_args'_v1041 
            (* run_target_args'
            let v1060 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1061 : (System.DateTime -> int64) = _.Ticks
            let v1062 : int64 = v1061 v1052
            let _run_target_args'_v1060 = v1062 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1063 : (System.DateTime -> int64) = _.Ticks
            let v1064 : int64 = v1063 v1052
            let _run_target_args'_v1060 = v1064 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1066 : int64 = null |> unbox<int64>
            let _run_target_args'_v1060 = v1066 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1069 : (System.DateTime -> int64) = _.Ticks
            let v1070 : int64 = v1069 v1052
            let _run_target_args'_v1060 = v1070 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1071 : (System.DateTime -> int64) = _.Ticks
            let v1072 : int64 = v1071 v1052
            let _run_target_args'_v1060 = v1072 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1073 : (System.DateTime -> int64) = _.Ticks
            let v1074 : int64 = v1073 v1052
            let _run_target_args'_v1060 = v1074 
            #endif
#else
            let v1075 : (System.DateTime -> int64) = _.Ticks
            let v1076 : int64 = v1075 v1052
            let _run_target_args'_v1060 = v1076 
            #endif
            let v1077 : int64 = _run_target_args'_v1060 
            let v1098 : int64 = v1077 |> int64 
            let v1101 : int64 = v1098 - v1038
            let v1104 : System.TimeSpan = v1101 |> System.TimeSpan 
            let v1110 : (System.TimeSpan -> int32) = _.Hours
            let v1111 : int32 = v1110 v1104
            let v1115 : (System.TimeSpan -> int32) = _.Minutes
            let v1116 : int32 = v1115 v1104
            let v1120 : (System.TimeSpan -> int32) = _.Seconds
            let v1121 : int32 = v1120 v1104
            let v1125 : (System.TimeSpan -> int32) = _.Milliseconds
            let v1126 : int32 = v1125 v1104
            let v1130 : System.DateTime = System.DateTime (1, 1, 1, v1111, v1116, v1121, v1126)
            v1130
    let v1154 : string = method10()
    let v1158 : bool = v1154 = ""
    let v1160 : string =
        if v1158 then
            let v1159 : string = "M-d-y hh:mm:ss tt"
            v1159
        else
            v1154
    let v1161 : (string -> string) = v1152.ToString
    let v1162 : string = v1161 v1160
    let _run_target_args'_v167 = v1162 
    #endif
    let v1177 : string = _run_target_args'_v167 
    v1177
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
    let v4 : string = $"{v0}"
    let v7 : unit = ()
    let v8 : (unit -> unit) = closure7(v2, v4)
    let v9 : unit = (fun () -> v8 (); v7) ()
    let v12 : string = v2.l0
    v12
and method14 () : string =
    let v0 : string = "\u001b[0m"
    v0
and method11 () : string =
    
    
    
    
    
    let v2 : string = "Debug"
    let v3 : (unit -> string) = v2.ToLower
    let v4 : string = v3 ()
    let v7 : char = v4.[int 0]
    let v8 : string = method12(v7)
    (* run_target_args'
    let v13 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v14 : string = "inline_colorization::color_bright_blue"
    let v15 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v14 
    (* run_target_args'
    let v20 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v21 : string = "&*$0"
    let v22 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v8 v21 
    let _run_target_args'_v20 = v22 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v23 : string = "&*$0"
    let v24 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v8 v23 
    let _run_target_args'_v20 = v24 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v25 : string = "&*$0"
    let v26 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v8 v25 
    let _run_target_args'_v20 = v26 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v28 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v20 = v28 
    #endif
#if FABLE_COMPILER_PYTHON
    let v32 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v20 = v32 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v36 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v20 = v36 
    #endif
#else
    let v40 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v20 = v40 
    #endif
    let v43 : Ref<Str> = _run_target_args'_v20 
    let v49 : string = "inline_colorization::color_reset"
    let v50 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v49 
    let v51 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v52 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v15, v43, v50) v51 
    let v53 : string = "fable_library_rust::String_::fromString($0)"
    let v54 : string = Fable.Core.RustInterop.emitRustExpr v52 v53 
    let _run_target_args'_v13 = v54 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v55 : string = "inline_colorization::color_bright_blue"
    let v56 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v55 
    (* run_target_args'
    let v61 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v62 : string = "&*$0"
    let v63 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v8 v62 
    let _run_target_args'_v61 = v63 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v64 : string = "&*$0"
    let v65 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v8 v64 
    let _run_target_args'_v61 = v65 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v66 : string = "&*$0"
    let v67 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v8 v66 
    let _run_target_args'_v61 = v67 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v69 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v61 = v69 
    #endif
#if FABLE_COMPILER_PYTHON
    let v73 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v61 = v73 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v77 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v61 = v77 
    #endif
#else
    let v81 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v61 = v81 
    #endif
    let v84 : Ref<Str> = _run_target_args'_v61 
    let v90 : string = "inline_colorization::color_reset"
    let v91 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v90 
    let v92 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v93 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v56, v84, v91) v92 
    let v94 : string = "fable_library_rust::String_::fromString($0)"
    let v95 : string = Fable.Core.RustInterop.emitRustExpr v93 v94 
    let _run_target_args'_v13 = v95 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v96 : string = "inline_colorization::color_bright_blue"
    let v97 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v96 
    (* run_target_args'
    let v102 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v103 : string = "&*$0"
    let v104 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v8 v103 
    let _run_target_args'_v102 = v104 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v105 : string = "&*$0"
    let v106 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v8 v105 
    let _run_target_args'_v102 = v106 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v107 : string = "&*$0"
    let v108 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v8 v107 
    let _run_target_args'_v102 = v108 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v110 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v102 = v110 
    #endif
#if FABLE_COMPILER_PYTHON
    let v114 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v102 = v114 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v118 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v102 = v118 
    #endif
#else
    let v122 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v102 = v122 
    #endif
    let v125 : Ref<Str> = _run_target_args'_v102 
    let v131 : string = "inline_colorization::color_reset"
    let v132 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v131 
    let v133 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v134 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v97, v125, v132) v133 
    let v135 : string = "fable_library_rust::String_::fromString($0)"
    let v136 : string = Fable.Core.RustInterop.emitRustExpr v134 v135 
    let _run_target_args'_v13 = v136 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v137 : string = "\u001b[94m"
    let v138 : string = method14()
    let v139 : string = v137 + v8 
    let v140 : string = v139 + v138 
    let _run_target_args'_v13 = v140 
    #endif
#if FABLE_COMPILER_PYTHON
    let v141 : string = "\u001b[94m"
    let v142 : string = method14()
    let v143 : string = v141 + v8 
    let v144 : string = v143 + v142 
    let _run_target_args'_v13 = v144 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v145 : string = "\u001b[94m"
    let v146 : string = method14()
    let v147 : string = v145 + v8 
    let v148 : string = v147 + v146 
    let _run_target_args'_v13 = v148 
    #endif
#else
    let v149 : string = "\u001b[94m"
    let v150 : string = method14()
    let v151 : string = v149 + v8 
    let v152 : string = v151 + v150 
    let _run_target_args'_v13 = v152 
    #endif
    let v153 : string = _run_target_args'_v13 
    v153
and method16 (v0 : std_string_String, v1 : uint64, v2 : std_string_String, v3 : std_string_String) : string =
    let v4 : string = method13()
    let v5 : Mut3 = {l0 = v4} : Mut3
    let v8 : string = "{ "
    let v9 : string = $"{v8}"
    let v12 : unit = ()
    let v13 : (unit -> unit) = closure7(v5, v9)
    let v14 : unit = (fun () -> v13 (); v12) ()
    let v19 : string = "alias"
    let v20 : string = $"{v19}"
    let v23 : unit = ()
    let v24 : (unit -> unit) = closure7(v5, v20)
    let v25 : unit = (fun () -> v24 (); v23) ()
    let v30 : string = " = "
    let v31 : string = $"{v30}"
    let v34 : unit = ()
    let v35 : (unit -> unit) = closure7(v5, v31)
    let v36 : unit = (fun () -> v35 (); v34) ()
    (* run_target_args'
    let v43 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v44 : string = "format!(\"{:#?}\", $0)"
    let v45 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v44 
    let v46 : string = "fable_library_rust::String_::fromString($0)"
    let v47 : string = Fable.Core.RustInterop.emitRustExpr v45 v46 
    let _run_target_args'_v43 = v47 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v48 : string = "format!(\"{:#?}\", $0)"
    let v49 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v48 
    let v50 : string = "fable_library_rust::String_::fromString($0)"
    let v51 : string = Fable.Core.RustInterop.emitRustExpr v49 v50 
    let _run_target_args'_v43 = v51 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v52 : string = "format!(\"{:#?}\", $0)"
    let v53 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v52 
    let v54 : string = "fable_library_rust::String_::fromString($0)"
    let v55 : string = Fable.Core.RustInterop.emitRustExpr v53 v54 
    let _run_target_args'_v43 = v55 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v57 : string = $"%A{v0}"
    let _run_target_args'_v43 = v57 
    #endif
#if FABLE_COMPILER_PYTHON
    let v61 : string = $"%A{v0}"
    let _run_target_args'_v43 = v61 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v65 : string = $"%A{v0}"
    let _run_target_args'_v43 = v65 
    #endif
#else
    let v69 : string = $"%A{v0}"
    let _run_target_args'_v43 = v69 
    #endif
    let v72 : string = _run_target_args'_v43 
    let v79 : string = $"{v72}"
    let v82 : unit = ()
    let v83 : (unit -> unit) = closure7(v5, v79)
    let v84 : unit = (fun () -> v83 (); v82) ()
    let v89 : string = "; "
    let v90 : string = $"{v89}"
    let v93 : unit = ()
    let v94 : (unit -> unit) = closure7(v5, v90)
    let v95 : unit = (fun () -> v94 (); v93) ()
    let v100 : string = "block_timestamp"
    let v101 : string = $"{v100}"
    let v104 : unit = ()
    let v105 : (unit -> unit) = closure7(v5, v101)
    let v106 : unit = (fun () -> v105 (); v104) ()
    let v110 : string = $"{v30}"
    let v113 : unit = ()
    let v114 : (unit -> unit) = closure7(v5, v110)
    let v115 : unit = (fun () -> v114 (); v113) ()
    let v119 : string = $"{v1}"
    let v122 : unit = ()
    let v123 : (unit -> unit) = closure7(v5, v119)
    let v124 : unit = (fun () -> v123 (); v122) ()
    let v128 : string = $"{v89}"
    let v131 : unit = ()
    let v132 : (unit -> unit) = closure7(v5, v128)
    let v133 : unit = (fun () -> v132 (); v131) ()
    let v138 : string = "signer_account_id"
    let v139 : string = $"{v138}"
    let v142 : unit = ()
    let v143 : (unit -> unit) = closure7(v5, v139)
    let v144 : unit = (fun () -> v143 (); v142) ()
    let v148 : string = $"{v30}"
    let v151 : unit = ()
    let v152 : (unit -> unit) = closure7(v5, v148)
    let v153 : unit = (fun () -> v152 (); v151) ()
    (* run_target_args'
    let v160 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v161 : string = "format!(\"{:#?}\", $0)"
    let v162 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v161 
    let v163 : string = "fable_library_rust::String_::fromString($0)"
    let v164 : string = Fable.Core.RustInterop.emitRustExpr v162 v163 
    let _run_target_args'_v160 = v164 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v165 : string = "format!(\"{:#?}\", $0)"
    let v166 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v165 
    let v167 : string = "fable_library_rust::String_::fromString($0)"
    let v168 : string = Fable.Core.RustInterop.emitRustExpr v166 v167 
    let _run_target_args'_v160 = v168 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v169 : string = "format!(\"{:#?}\", $0)"
    let v170 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v169 
    let v171 : string = "fable_library_rust::String_::fromString($0)"
    let v172 : string = Fable.Core.RustInterop.emitRustExpr v170 v171 
    let _run_target_args'_v160 = v172 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v174 : string = $"%A{v2}"
    let _run_target_args'_v160 = v174 
    #endif
#if FABLE_COMPILER_PYTHON
    let v178 : string = $"%A{v2}"
    let _run_target_args'_v160 = v178 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v182 : string = $"%A{v2}"
    let _run_target_args'_v160 = v182 
    #endif
#else
    let v186 : string = $"%A{v2}"
    let _run_target_args'_v160 = v186 
    #endif
    let v189 : string = _run_target_args'_v160 
    let v196 : string = $"{v189}"
    let v199 : unit = ()
    let v200 : (unit -> unit) = closure7(v5, v196)
    let v201 : unit = (fun () -> v200 (); v199) ()
    let v205 : string = $"{v89}"
    let v208 : unit = ()
    let v209 : (unit -> unit) = closure7(v5, v205)
    let v210 : unit = (fun () -> v209 (); v208) ()
    let v215 : string = "predecessor_account_id"
    let v216 : string = $"{v215}"
    let v219 : unit = ()
    let v220 : (unit -> unit) = closure7(v5, v216)
    let v221 : unit = (fun () -> v220 (); v219) ()
    let v225 : string = $"{v30}"
    let v228 : unit = ()
    let v229 : (unit -> unit) = closure7(v5, v225)
    let v230 : unit = (fun () -> v229 (); v228) ()
    (* run_target_args'
    let v237 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v238 : string = "format!(\"{:#?}\", $0)"
    let v239 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3 v238 
    let v240 : string = "fable_library_rust::String_::fromString($0)"
    let v241 : string = Fable.Core.RustInterop.emitRustExpr v239 v240 
    let _run_target_args'_v237 = v241 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v242 : string = "format!(\"{:#?}\", $0)"
    let v243 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3 v242 
    let v244 : string = "fable_library_rust::String_::fromString($0)"
    let v245 : string = Fable.Core.RustInterop.emitRustExpr v243 v244 
    let _run_target_args'_v237 = v245 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v246 : string = "format!(\"{:#?}\", $0)"
    let v247 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3 v246 
    let v248 : string = "fable_library_rust::String_::fromString($0)"
    let v249 : string = Fable.Core.RustInterop.emitRustExpr v247 v248 
    let _run_target_args'_v237 = v249 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v251 : string = $"%A{v3}"
    let _run_target_args'_v237 = v251 
    #endif
#if FABLE_COMPILER_PYTHON
    let v255 : string = $"%A{v3}"
    let _run_target_args'_v237 = v255 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v259 : string = $"%A{v3}"
    let _run_target_args'_v237 = v259 
    #endif
#else
    let v263 : string = $"%A{v3}"
    let _run_target_args'_v237 = v263 
    #endif
    let v266 : string = _run_target_args'_v237 
    let v273 : string = $"{v266}"
    let v276 : unit = ()
    let v277 : (unit -> unit) = closure7(v5, v273)
    let v278 : unit = (fun () -> v277 (); v276) ()
    let v283 : string = " }"
    let v284 : string = $"{v283}"
    let v287 : unit = ()
    let v288 : (unit -> unit) = closure7(v5, v284)
    let v289 : unit = (fun () -> v288 (); v287) ()
    let v292 : string = v5.l0
    v292
and method17 (v0 : string) : string =
    let v1 : char list = []
    let v4 : (char list -> (char [])) = List.toArray
    let v5 : (char []) = v4 v1
    let v8 : string = v0.TrimStart v5 
    let v40 : char list = []
    let v42 : char list = '/' :: v40 
    let v46 : char list = ' ' :: v42 
    let v51 : (char list -> (char [])) = List.toArray
    let v52 : (char []) = v51 v46
    let v55 : string = v8.TrimEnd v52 
    v55
and method15 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : std_string_String, v9 : uint64, v10 : std_string_String, v11 : std_string_String) : string =
    let v12 : string = method16(v8, v9, v10, v11)
    let v13 : int64 = v0.l0
    let v15 : string = "chat_contract.claim_alias"
    let v16 : string = $"{v6} {v7} #{v13} %s{v15} / {v12}"
    method17(v16)
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
    let struct (v24 : Mut0, v25 : Mut1, v26 : Mut2, v27 : Mut3, v28 : Mut4, v29 : int64 option) = TraceState.trace_state.Value
    let v42 : unit = ()
    let v43 : (unit -> unit) = closure8(v24)
    let v44 : unit = (fun () -> v43 (); v42) ()
    let v47 : (string -> unit) = closure9()
    (* run_target_args'
    let v48 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v49 : string = @"println!(""{}"", $0)"
    Fable.Core.RustInterop.emitRustExpr v0 v49 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v50 : string = @"println!(""{}"", $0)"
    Fable.Core.RustInterop.emitRustExpr v0 v50 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v51 : string = v27.l0
    let v52 : bool = v51 = ""
    let v60 : string =
        if v52 then
            v0
        else
            let v53 : bool = v0 = ""
            if v53 then
                let v54 : string = v27.l0
                v54
            else
                let v55 : string = v27.l0
                let v56 : string = "\n"
                let v57 : string = v55 + v56 
                let v58 : string = v57 + v0 
                v58
    (* run_target_args'
    let v65 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v66 : string = "&*$0"
    let v67 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v60 v66 
    let _run_target_args'_v65 = v67 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v68 : string = "&*$0"
    let v69 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v60 v68 
    let _run_target_args'_v65 = v69 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v70 : string = "&*$0"
    let v71 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v60 v70 
    let _run_target_args'_v65 = v71 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v73 : Ref<Str> = v60 |> unbox<Ref<Str>>
    let _run_target_args'_v65 = v73 
    #endif
#if FABLE_COMPILER_PYTHON
    let v77 : Ref<Str> = v60 |> unbox<Ref<Str>>
    let _run_target_args'_v65 = v77 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v81 : Ref<Str> = v60 |> unbox<Ref<Str>>
    let _run_target_args'_v65 = v81 
    #endif
#else
    let v85 : Ref<Str> = v60 |> unbox<Ref<Str>>
    let _run_target_args'_v65 = v85 
    #endif
    let v88 : Ref<Str> = _run_target_args'_v65 
    let v94 : string = $"$0.chars()"
    let v95 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v88 v94 
    let v96 : string = "$0"
    let v97 : _ = Fable.Core.RustInterop.emitRustExpr v95 v96 
    let v98 : string = "$0.collect::<Vec<_>>()"
    let v99 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v97 v98 
    let v100 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
    let v101 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v99 v100 
    let v102 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
    let v103 : bool = Fable.Core.RustInterop.emitRustExpr v101 v102 
    let v104 : string = "x"
    let v105 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v104 
    let v106 : string = "String::from_iter($0)"
    let v107 : std_string_String = Fable.Core.RustInterop.emitRustExpr v105 v106 
    let v108 : string = "true; $0 }).collect::<Vec<_>>()"
    let v109 : bool = Fable.Core.RustInterop.emitRustExpr v107 v108 
    let v110 : string = "_vec_map"
    let v111 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v110 
    let v112 : string = "$0.len()"
    let v113 : unativeint = Fable.Core.RustInterop.emitRustExpr v111 v112 
    let v119 : int32 = v113 |> int32 
    let v129 : string = ""
    let v130 : bool = v0 <> v129 
    let v134 : bool =
        if v130 then
            let v133 : bool = v119 <= 1
            v133
        else
            false
    if v134 then
        v27.l0 <- v60
        ()
    else
        v27.l0 <- v129
        let v135 : string = "true; $0.into_iter().for_each(|x| { //"
        let v136 : bool = Fable.Core.RustInterop.emitRustExpr v111 v135 
        let v137 : string = "x"
        let v138 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v137 
        let v139 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
        let v140 : bool = Fable.Core.RustInterop.emitRustExpr v138 v139 
        let v141 : string = $"true"
        let v142 : bool = Fable.Core.RustInterop.emitRustExpr () v141 
        let v143 : string = "true; }); //"
        let v144 : bool = Fable.Core.RustInterop.emitRustExpr () v143 
        ()
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    v47 v0
    #endif
#if FABLE_COMPILER_PYTHON
    v47 v0
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    v47 v0
    #endif
#else
    v47 v0
    #endif
    // run_target_args' is_unit
    let v145 : (string -> unit) = v25.l0
    v145 v0
and closure2 (v0 : std_string_String, v1 : near_sdk_AccountId, v2 : near_sdk_AccountId, v3 : uint64) () : unit =
    let v4 : US0 = US0_1
    let v5 : bool = method0(v4)
    if v5 then
        let v6 : unit = ()
        let v7 : (unit -> unit) = closure3()
        let v8 : unit = (fun () -> v7 (); v6) ()
        let struct (v29 : Mut0, v30 : Mut1, v31 : Mut2, v32 : Mut3, v33 : Mut4, v34 : int64 option) = TraceState.trace_state.Value
        let v47 : string = method7(v29, v30, v31, v32, v33, v34)
        let v48 : string = method11()
        let v49 : string = $"v1.to_string()"
        let v50 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v49 
        let v51 : string = $"v2.to_string()"
        let v52 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v51 
        let v53 : string = method15(v29, v30, v31, v32, v33, v34, v47, v48, v0, v3, v50, v52)
        method18(v53)
and closure11 () (v0 : std_string_String) : US6 =
    US6_0(v0)
and method19 () : (std_string_String -> US6) =
    closure11()
and method20 () : string =
    
    
    
    
    
    let v2 : string = "Warning"
    let v3 : (unit -> string) = v2.ToLower
    let v4 : string = v3 ()
    let v7 : char = v4.[int 0]
    let v8 : string = method12(v7)
    (* run_target_args'
    let v13 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v14 : string = "inline_colorization::color_yellow"
    let v15 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v14 
    (* run_target_args'
    let v20 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v21 : string = "&*$0"
    let v22 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v8 v21 
    let _run_target_args'_v20 = v22 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v23 : string = "&*$0"
    let v24 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v8 v23 
    let _run_target_args'_v20 = v24 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v25 : string = "&*$0"
    let v26 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v8 v25 
    let _run_target_args'_v20 = v26 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v28 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v20 = v28 
    #endif
#if FABLE_COMPILER_PYTHON
    let v32 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v20 = v32 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v36 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v20 = v36 
    #endif
#else
    let v40 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v20 = v40 
    #endif
    let v43 : Ref<Str> = _run_target_args'_v20 
    let v49 : string = "inline_colorization::color_reset"
    let v50 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v49 
    let v51 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v52 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v15, v43, v50) v51 
    let v53 : string = "fable_library_rust::String_::fromString($0)"
    let v54 : string = Fable.Core.RustInterop.emitRustExpr v52 v53 
    let _run_target_args'_v13 = v54 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v55 : string = "inline_colorization::color_yellow"
    let v56 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v55 
    (* run_target_args'
    let v61 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v62 : string = "&*$0"
    let v63 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v8 v62 
    let _run_target_args'_v61 = v63 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v64 : string = "&*$0"
    let v65 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v8 v64 
    let _run_target_args'_v61 = v65 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v66 : string = "&*$0"
    let v67 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v8 v66 
    let _run_target_args'_v61 = v67 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v69 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v61 = v69 
    #endif
#if FABLE_COMPILER_PYTHON
    let v73 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v61 = v73 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v77 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v61 = v77 
    #endif
#else
    let v81 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v61 = v81 
    #endif
    let v84 : Ref<Str> = _run_target_args'_v61 
    let v90 : string = "inline_colorization::color_reset"
    let v91 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v90 
    let v92 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v93 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v56, v84, v91) v92 
    let v94 : string = "fable_library_rust::String_::fromString($0)"
    let v95 : string = Fable.Core.RustInterop.emitRustExpr v93 v94 
    let _run_target_args'_v13 = v95 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v96 : string = "inline_colorization::color_yellow"
    let v97 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v96 
    (* run_target_args'
    let v102 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v103 : string = "&*$0"
    let v104 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v8 v103 
    let _run_target_args'_v102 = v104 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v105 : string = "&*$0"
    let v106 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v8 v105 
    let _run_target_args'_v102 = v106 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v107 : string = "&*$0"
    let v108 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v8 v107 
    let _run_target_args'_v102 = v108 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v110 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v102 = v110 
    #endif
#if FABLE_COMPILER_PYTHON
    let v114 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v102 = v114 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v118 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v102 = v118 
    #endif
#else
    let v122 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v102 = v122 
    #endif
    let v125 : Ref<Str> = _run_target_args'_v102 
    let v131 : string = "inline_colorization::color_reset"
    let v132 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v131 
    let v133 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v134 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v97, v125, v132) v133 
    let v135 : string = "fable_library_rust::String_::fromString($0)"
    let v136 : string = Fable.Core.RustInterop.emitRustExpr v134 v135 
    let _run_target_args'_v13 = v136 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v137 : string = "\u001b[93m"
    let v138 : string = method14()
    let v139 : string = v137 + v8 
    let v140 : string = v139 + v138 
    let _run_target_args'_v13 = v140 
    #endif
#if FABLE_COMPILER_PYTHON
    let v141 : string = "\u001b[93m"
    let v142 : string = method14()
    let v143 : string = v141 + v8 
    let v144 : string = v143 + v142 
    let _run_target_args'_v13 = v144 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v145 : string = "\u001b[93m"
    let v146 : string = method14()
    let v147 : string = v145 + v8 
    let v148 : string = v147 + v146 
    let _run_target_args'_v13 = v148 
    #endif
#else
    let v149 : string = "\u001b[93m"
    let v150 : string = method14()
    let v151 : string = v149 + v8 
    let v152 : string = v151 + v150 
    let _run_target_args'_v13 = v152 
    #endif
    let v153 : string = _run_target_args'_v13 
    v153
and method22 (v0 : string) : string =
    let v1 : string = method13()
    let v2 : Mut3 = {l0 = v1} : Mut3
    let v5 : string = "{ "
    let v6 : string = $"{v5}"
    let v9 : unit = ()
    let v10 : (unit -> unit) = closure7(v2, v6)
    let v11 : unit = (fun () -> v10 (); v9) ()
    let v16 : string = "account_alias"
    let v17 : string = $"{v16}"
    let v20 : unit = ()
    let v21 : (unit -> unit) = closure7(v2, v17)
    let v22 : unit = (fun () -> v21 (); v20) ()
    let v27 : string = " = "
    let v28 : string = $"{v27}"
    let v31 : unit = ()
    let v32 : (unit -> unit) = closure7(v2, v28)
    let v33 : unit = (fun () -> v32 (); v31) ()
    let v37 : string = $"{v0}"
    let v40 : unit = ()
    let v41 : (unit -> unit) = closure7(v2, v37)
    let v42 : unit = (fun () -> v41 (); v40) ()
    let v47 : string = " }"
    let v48 : string = $"{v47}"
    let v51 : unit = ()
    let v52 : (unit -> unit) = closure7(v2, v48)
    let v53 : unit = (fun () -> v52 (); v51) ()
    let v56 : string = v2.l0
    v56
and method21 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : string) : string =
    let v9 : string = method22(v8)
    let v10 : int64 = v0.l0
    let v12 : string = "chat_contract.claim_alias / alias already claimed"
    let v13 : string = $"{v6} {v7} #{v10} %s{v12} / {v9}"
    method17(v13)
and closure12 (v0 : std_string_String) () : unit =
    let v1 : US0 = US0_3
    let v2 : bool = method0(v1)
    if v2 then
        let v3 : unit = ()
        let v4 : (unit -> unit) = closure3()
        let v5 : unit = (fun () -> v4 (); v3) ()
        let struct (v26 : Mut0, v27 : Mut1, v28 : Mut2, v29 : Mut3, v30 : Mut4, v31 : int64 option) = TraceState.trace_state.Value
        let v44 : string = method7(v26, v27, v28, v29, v30, v31)
        let v45 : string = method20()
        let v47 : string = $"%A{v0}"
        let v50 : string = method21(v26, v27, v28, v29, v30, v31, v44, v45, v47)
        method18(v50)
and method23 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : string) : string =
    let v9 : string = method22(v8)
    let v10 : int64 = v0.l0
    let v12 : string = "chat_contract.claim_alias"
    let v13 : string = $"{v6} {v7} #{v10} %s{v12} / {v9}"
    method17(v13)
and closure13 (v0 : std_string_String option) () : unit =
    let v1 : US0 = US0_1
    let v2 : bool = method0(v1)
    if v2 then
        let v3 : unit = ()
        let v4 : (unit -> unit) = closure3()
        let v5 : unit = (fun () -> v4 (); v3) ()
        let struct (v26 : Mut0, v27 : Mut1, v28 : Mut2, v29 : Mut3, v30 : Mut4, v31 : int64 option) = TraceState.trace_state.Value
        let v44 : string = method7(v26, v27, v28, v29, v30, v31)
        let v45 : string = method11()
        let v47 : string = $"%A{v0}"
        let v50 : string = method23(v26, v27, v28, v29, v30, v31, v44, v45, v47)
        method18(v50)
and closure14 () () : unit =
    ()
and method24 () : (unit -> unit) =
    closure14()
and method25 () : unit =
    let v0 : unit = ()
    let v1 : (unit -> unit) = closure3()
    let v2 : unit = (fun () -> v1 (); v0) ()
    let struct (v23 : Mut0, v24 : Mut1, v25 : Mut2, v26 : Mut3, v27 : Mut4, v28 : int64 option) = TraceState.trace_state.Value
    let v41 : unit = ()
    let v42 : (unit -> unit) = closure8(v23)
    let v43 : unit = (fun () -> v42 (); v41) ()
    let v46 : string = ""
    let v47 : (string -> unit) = closure9()
    (* run_target_args'
    let v48 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v49 : string = @"println!(""{}"", $0)"
    Fable.Core.RustInterop.emitRustExpr v46 v49 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v50 : string = @"println!(""{}"", $0)"
    Fable.Core.RustInterop.emitRustExpr v46 v50 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v51 : string = v26.l0
    let v52 : bool = v51 = ""
    let v60 : string =
        if v52 then
            v46
        else
            let v53 : bool = v46 = ""
            if v53 then
                let v54 : string = v26.l0
                v54
            else
                let v55 : string = v26.l0
                let v56 : string = "\n"
                let v57 : string = v55 + v56 
                let v58 : string = v57 + v46 
                v58
    (* run_target_args'
    let v65 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v66 : string = "&*$0"
    let v67 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v60 v66 
    let _run_target_args'_v65 = v67 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v68 : string = "&*$0"
    let v69 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v60 v68 
    let _run_target_args'_v65 = v69 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v70 : string = "&*$0"
    let v71 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v60 v70 
    let _run_target_args'_v65 = v71 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v73 : Ref<Str> = v60 |> unbox<Ref<Str>>
    let _run_target_args'_v65 = v73 
    #endif
#if FABLE_COMPILER_PYTHON
    let v77 : Ref<Str> = v60 |> unbox<Ref<Str>>
    let _run_target_args'_v65 = v77 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v81 : Ref<Str> = v60 |> unbox<Ref<Str>>
    let _run_target_args'_v65 = v81 
    #endif
#else
    let v85 : Ref<Str> = v60 |> unbox<Ref<Str>>
    let _run_target_args'_v65 = v85 
    #endif
    let v88 : Ref<Str> = _run_target_args'_v65 
    let v94 : string = $"$0.chars()"
    let v95 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v88 v94 
    let v96 : string = "$0"
    let v97 : _ = Fable.Core.RustInterop.emitRustExpr v95 v96 
    let v98 : string = "$0.collect::<Vec<_>>()"
    let v99 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v97 v98 
    let v100 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
    let v101 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v99 v100 
    let v102 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
    let v103 : bool = Fable.Core.RustInterop.emitRustExpr v101 v102 
    let v104 : string = "x"
    let v105 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v104 
    let v106 : string = "String::from_iter($0)"
    let v107 : std_string_String = Fable.Core.RustInterop.emitRustExpr v105 v106 
    let v108 : string = "true; $0 }).collect::<Vec<_>>()"
    let v109 : bool = Fable.Core.RustInterop.emitRustExpr v107 v108 
    let v110 : string = "_vec_map"
    let v111 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v110 
    let v112 : string = "$0.len()"
    let v113 : unativeint = Fable.Core.RustInterop.emitRustExpr v111 v112 
    let v119 : int32 = v113 |> int32 
    let v128 : bool = v46 <> v46 
    let v132 : bool =
        if v128 then
            let v131 : bool = v119 <= 1
            v131
        else
            false
    if v132 then
        v26.l0 <- v60
        ()
    else
        v26.l0 <- v46
        let v133 : string = "true; $0.into_iter().for_each(|x| { //"
        let v134 : bool = Fable.Core.RustInterop.emitRustExpr v111 v133 
        let v135 : string = "x"
        let v136 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v135 
        let v137 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
        let v138 : bool = Fable.Core.RustInterop.emitRustExpr v136 v137 
        let v139 : string = $"true"
        let v140 : bool = Fable.Core.RustInterop.emitRustExpr () v139 
        let v141 : string = "true; }); //"
        let v142 : bool = Fable.Core.RustInterop.emitRustExpr () v141 
        ()
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    v47 v46
    #endif
#if FABLE_COMPILER_PYTHON
    v47 v46
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    v47 v46
    #endif
#else
    v47 v46
    #endif
    // run_target_args' is_unit
    let v143 : (string -> unit) = v24.l0
    v143 v46
and closure15 (v0 : (unit -> unit)) () : unit =
    let v1 : US0 = US0_1
    let v2 : bool = method0(v1)
    if v2 then
        let v3 : unit = ()
        let v4 : (unit -> unit) = closure3()
        let v5 : unit = (fun () -> v4 (); v3) ()
        let struct (v26 : Mut0, v27 : Mut1, v28 : Mut2, v29 : Mut3, v30 : Mut4, v31 : int64 option) = TraceState.trace_state.Value
        let v44 : string = method7(v26, v27, v28, v29, v30, v31)
        let v45 : string = method11()
        method25()
and method27 (v0 : near_sdk_AccountId, v1 : struct (std_string_String * uint64 * uint32) option) : string =
    let v2 : string = method13()
    let v3 : Mut3 = {l0 = v2} : Mut3
    let v6 : string = "{ "
    let v7 : string = $"{v6}"
    let v10 : unit = ()
    let v11 : (unit -> unit) = closure7(v3, v7)
    let v12 : unit = (fun () -> v11 (); v10) ()
    let v17 : string = "account_id"
    let v18 : string = $"{v17}"
    let v21 : unit = ()
    let v22 : (unit -> unit) = closure7(v3, v18)
    let v23 : unit = (fun () -> v22 (); v21) ()
    let v28 : string = " = "
    let v29 : string = $"{v28}"
    let v32 : unit = ()
    let v33 : (unit -> unit) = closure7(v3, v29)
    let v34 : unit = (fun () -> v33 (); v32) ()
    (* run_target_args'
    let v41 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v42 : string = "format!(\"{:#?}\", $0)"
    let v43 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v42 
    let v44 : string = "fable_library_rust::String_::fromString($0)"
    let v45 : string = Fable.Core.RustInterop.emitRustExpr v43 v44 
    let _run_target_args'_v41 = v45 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v46 : string = "format!(\"{:#?}\", $0)"
    let v47 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v46 
    let v48 : string = "fable_library_rust::String_::fromString($0)"
    let v49 : string = Fable.Core.RustInterop.emitRustExpr v47 v48 
    let _run_target_args'_v41 = v49 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v50 : string = "format!(\"{:#?}\", $0)"
    let v51 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v50 
    let v52 : string = "fable_library_rust::String_::fromString($0)"
    let v53 : string = Fable.Core.RustInterop.emitRustExpr v51 v52 
    let _run_target_args'_v41 = v53 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v55 : string = $"%A{v0}"
    let _run_target_args'_v41 = v55 
    #endif
#if FABLE_COMPILER_PYTHON
    let v59 : string = $"%A{v0}"
    let _run_target_args'_v41 = v59 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v63 : string = $"%A{v0}"
    let _run_target_args'_v41 = v63 
    #endif
#else
    let v67 : string = $"%A{v0}"
    let _run_target_args'_v41 = v67 
    #endif
    let v70 : string = _run_target_args'_v41 
    let v77 : string = $"{v70}"
    let v80 : unit = ()
    let v81 : (unit -> unit) = closure7(v3, v77)
    let v82 : unit = (fun () -> v81 (); v80) ()
    let v87 : string = "; "
    let v88 : string = $"{v87}"
    let v91 : unit = ()
    let v92 : (unit -> unit) = closure7(v3, v88)
    let v93 : unit = (fun () -> v92 (); v91) ()
    let v98 : string = "result"
    let v99 : string = $"{v98}"
    let v102 : unit = ()
    let v103 : (unit -> unit) = closure7(v3, v99)
    let v104 : unit = (fun () -> v103 (); v102) ()
    let v108 : string = $"{v28}"
    let v111 : unit = ()
    let v112 : (unit -> unit) = closure7(v3, v108)
    let v113 : unit = (fun () -> v112 (); v111) ()
    (* run_target_args'
    let v120 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v121 : string = "format!(\"{:#?}\", $0)"
    let v122 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1 v121 
    let v123 : string = "fable_library_rust::String_::fromString($0)"
    let v124 : string = Fable.Core.RustInterop.emitRustExpr v122 v123 
    let _run_target_args'_v120 = v124 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v125 : string = "format!(\"{:#?}\", $0)"
    let v126 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1 v125 
    let v127 : string = "fable_library_rust::String_::fromString($0)"
    let v128 : string = Fable.Core.RustInterop.emitRustExpr v126 v127 
    let _run_target_args'_v120 = v128 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v129 : string = "format!(\"{:#?}\", $0)"
    let v130 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1 v129 
    let v131 : string = "fable_library_rust::String_::fromString($0)"
    let v132 : string = Fable.Core.RustInterop.emitRustExpr v130 v131 
    let _run_target_args'_v120 = v132 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v134 : string = $"%A{v1}"
    let _run_target_args'_v120 = v134 
    #endif
#if FABLE_COMPILER_PYTHON
    let v138 : string = $"%A{v1}"
    let _run_target_args'_v120 = v138 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v142 : string = $"%A{v1}"
    let _run_target_args'_v120 = v142 
    #endif
#else
    let v146 : string = $"%A{v1}"
    let _run_target_args'_v120 = v146 
    #endif
    let v149 : string = _run_target_args'_v120 
    let v156 : string = $"{v149}"
    let v159 : unit = ()
    let v160 : (unit -> unit) = closure7(v3, v156)
    let v161 : unit = (fun () -> v160 (); v159) ()
    let v166 : string = " }"
    let v167 : string = $"{v166}"
    let v170 : unit = ()
    let v171 : (unit -> unit) = closure7(v3, v167)
    let v172 : unit = (fun () -> v171 (); v170) ()
    let v175 : string = v3.l0
    v175
and method26 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : near_sdk_AccountId, v9 : struct (std_string_String * uint64 * uint32) option) : string =
    let v10 : string = method27(v8, v9)
    let v11 : int64 = v0.l0
    let v13 : string = "chat_contract.get_account_info"
    let v14 : string = $"{v6} {v7} #{v11} %s{v13} / {v10}"
    method17(v14)
and closure16 (v0 : near_sdk_AccountId, v1 : struct (std_string_String * uint64 * uint32) option) () : unit =
    let v2 : US0 = US0_1
    let v3 : bool = method0(v2)
    if v3 then
        let v4 : unit = ()
        let v5 : (unit -> unit) = closure3()
        let v6 : unit = (fun () -> v5 (); v4) ()
        let struct (v27 : Mut0, v28 : Mut1, v29 : Mut2, v30 : Mut3, v31 : Mut4, v32 : int64 option) = TraceState.trace_state.Value
        let v45 : string = method7(v27, v28, v29, v30, v31, v32)
        let v46 : string = method11()
        let v47 : string = method26(v27, v28, v29, v30, v31, v32, v45, v46, v0, v1)
        method18(v47)
and closure17 () () : unit =
    let v0 : US0 = US0_1
    let v1 : bool = method0(v0)
    if v1 then
        let v2 : unit = ()
        let v3 : (unit -> unit) = closure3()
        let v4 : unit = (fun () -> v3 (); v2) ()
        let struct (v25 : Mut0, v26 : Mut1, v27 : Mut2, v28 : Mut3, v29 : Mut4, v30 : int64 option) = TraceState.trace_state.Value
        let v43 : string = method7(v25, v26, v27, v28, v29, v30)
        let v44 : string = method11()
        method25()
and method29 (v0 : std_string_String) : string =
    let v1 : string = method13()
    let v2 : Mut3 = {l0 = v1} : Mut3
    let v5 : string = "{ "
    let v6 : string = $"{v5}"
    let v9 : unit = ()
    let v10 : (unit -> unit) = closure7(v2, v6)
    let v11 : unit = (fun () -> v10 (); v9) ()
    let v16 : string = "alias"
    let v17 : string = $"{v16}"
    let v20 : unit = ()
    let v21 : (unit -> unit) = closure7(v2, v17)
    let v22 : unit = (fun () -> v21 (); v20) ()
    let v27 : string = " = "
    let v28 : string = $"{v27}"
    let v31 : unit = ()
    let v32 : (unit -> unit) = closure7(v2, v28)
    let v33 : unit = (fun () -> v32 (); v31) ()
    (* run_target_args'
    let v40 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v41 : string = "format!(\"{:#?}\", $0)"
    let v42 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v41 
    let v43 : string = "fable_library_rust::String_::fromString($0)"
    let v44 : string = Fable.Core.RustInterop.emitRustExpr v42 v43 
    let _run_target_args'_v40 = v44 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v45 : string = "format!(\"{:#?}\", $0)"
    let v46 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v45 
    let v47 : string = "fable_library_rust::String_::fromString($0)"
    let v48 : string = Fable.Core.RustInterop.emitRustExpr v46 v47 
    let _run_target_args'_v40 = v48 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v49 : string = "format!(\"{:#?}\", $0)"
    let v50 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v49 
    let v51 : string = "fable_library_rust::String_::fromString($0)"
    let v52 : string = Fable.Core.RustInterop.emitRustExpr v50 v51 
    let _run_target_args'_v40 = v52 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v54 : string = $"%A{v0}"
    let _run_target_args'_v40 = v54 
    #endif
#if FABLE_COMPILER_PYTHON
    let v58 : string = $"%A{v0}"
    let _run_target_args'_v40 = v58 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v62 : string = $"%A{v0}"
    let _run_target_args'_v40 = v62 
    #endif
#else
    let v66 : string = $"%A{v0}"
    let _run_target_args'_v40 = v66 
    #endif
    let v69 : string = _run_target_args'_v40 
    let v76 : string = $"{v69}"
    let v79 : unit = ()
    let v80 : (unit -> unit) = closure7(v2, v76)
    let v81 : unit = (fun () -> v80 (); v79) ()
    let v86 : string = " }"
    let v87 : string = $"{v86}"
    let v90 : unit = ()
    let v91 : (unit -> unit) = closure7(v2, v87)
    let v92 : unit = (fun () -> v91 (); v90) ()
    let v95 : string = v2.l0
    v95
and method28 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : std_string_String) : string =
    let v9 : string = method29(v8)
    let v10 : int64 = v0.l0
    let v12 : string = "chat_contract.get_alias_map"
    let v13 : string = $"{v6} {v7} #{v10} %s{v12} / {v9}"
    method17(v13)
and closure18 (v0 : std_string_String) () : unit =
    let v1 : US0 = US0_1
    let v2 : bool = method0(v1)
    if v2 then
        let v3 : unit = ()
        let v4 : (unit -> unit) = closure3()
        let v5 : unit = (fun () -> v4 (); v3) ()
        let struct (v26 : Mut0, v27 : Mut1, v28 : Mut2, v29 : Mut3, v30 : Mut4, v31 : int64 option) = TraceState.trace_state.Value
        let v44 : string = method7(v26, v27, v28, v29, v30, v31)
        let v45 : string = method11()
        let v46 : string = method28(v26, v27, v28, v29, v30, v31, v44, v45, v0)
        method18(v46)
and method30 () : (unit -> unit) =
    closure14()
and closure19 (v0 : (unit -> unit)) () : unit =
    let v1 : US0 = US0_1
    let v2 : bool = method0(v1)
    if v2 then
        let v3 : unit = ()
        let v4 : (unit -> unit) = closure3()
        let v5 : unit = (fun () -> v4 (); v3) ()
        let struct (v26 : Mut0, v27 : Mut1, v28 : Mut2, v29 : Mut3, v30 : Mut4, v31 : int64 option) = TraceState.trace_state.Value
        let v44 : string = method7(v26, v27, v28, v29, v30, v31)
        let v45 : string = method11()
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
    let v10 : TypeEmit<struct (uint32 * near_sdk_store_IterableSet<near_sdk_AccountId> * near_sdk_store_IterableSet<std_string_String> * near_sdk_store_LookupMap<near_sdk_AccountId, std_string_String> * near_sdk_store_LookupMap<std_string_String, std_collections_HashMap<near_sdk_AccountId, struct (uint64 * uint32)>>)> = null |> unbox<TypeEmit<struct (uint32 * near_sdk_store_IterableSet<near_sdk_AccountId> * near_sdk_store_IterableSet<std_string_String> * near_sdk_store_LookupMap<near_sdk_AccountId, std_string_String> * near_sdk_store_LookupMap<std_string_String, std_collections_HashMap<near_sdk_AccountId, struct (uint64 * uint32)>>)>>
    let v13 : string = "*/ )"
    Fable.Core.RustInterop.emitRustExpr () v13 
    let v14 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v14 
    let v15 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v15 
    let v16 : string = "#[init] //"
    Fable.Core.RustInterop.emitRustExpr () v16 
    let v17 : string = "pub fn new() -> Self { // 1"
    Fable.Core.RustInterop.emitRustExpr () v17 
    let v18 : string = "true; /*"
    let v19 : bool = Fable.Core.RustInterop.emitRustExpr () v18 
    let v21 : TypeEmit<unit> = null |> unbox<TypeEmit<unit>>
    let v24 : string = "true; */"
    let v25 : bool = Fable.Core.RustInterop.emitRustExpr () v24 
    let v26 : string = "account_set"
    let v27 : string = "b\"" + v26 + "\""
    let v28 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v27 
    let v29 : string = "near_sdk::store::IterableSet::new(v28)"
    let v30 : near_sdk_store_IterableSet<near_sdk_AccountId> = Fable.Core.RustInterop.emitRustExpr () v29 
    let v31 : string = "alias_set"
    let v32 : string = "b\"" + v31 + "\""
    let v33 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v32 
    let v34 : string = "near_sdk::store::IterableSet::new(v33)"
    let v35 : near_sdk_store_IterableSet<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v34 
    let v36 : string = "account_map"
    let v37 : string = "b\"" + v36 + "\""
    let v38 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v37 
    let v39 : string = "near_sdk::store::LookupMap::new(v38)"
    let v40 : near_sdk_store_LookupMap<near_sdk_AccountId, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v39 
    let v41 : string = "alias_map"
    let v42 : string = "b\"" + v41 + "\""
    let v43 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v42 
    let v44 : string = "near_sdk::store::LookupMap::new(v43)"
    let v45 : near_sdk_store_LookupMap<std_string_String, std_collections_HashMap<near_sdk_AccountId, struct (uint64 * uint32)>> = Fable.Core.RustInterop.emitRustExpr () v44 
    let _result = struct (2u, v30, v35, v40, v45) in _result |> (fun x -> Fable.Core.RustInterop.emitRustExpr x $"Self($0) // x") // 2
    let v46 : string = "} // 2."
    Fable.Core.RustInterop.emitRustExpr () v46 
    let v47 : string = "} // 1."
    Fable.Core.RustInterop.emitRustExpr () v47 
    let v48 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v48 
    let v49 : string = "true; // ??? / i: 1uy / i': 1uy / acc: 0uy / n: 2uy"
    let v50 : bool = Fable.Core.RustInterop.emitRustExpr () v49 
    let v51 : string = "true; */ // ???? / i: 1uy / i': 2uy / acc: 0uy / n: 2uy"
    let v52 : bool = Fable.Core.RustInterop.emitRustExpr () v51 
    let v53 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v53 
    let v54 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v54 
    let v55 : string = "fn is_valid_alias(alias: String) -> bool { //"
    Fable.Core.RustInterop.emitRustExpr () v55 
    let v56 : string = $"alias"
    let v57 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v56 
    let v58 : string = "fable_library_rust::String_::fromString($0)"
    let v59 : string = Fable.Core.RustInterop.emitRustExpr v57 v58 
    let v60 : int32 = v59.Length
    let v61 : bool = v60 > 0
    let v119 : bool =
        if v61 then
            let v62 : bool = v60 < 64
            if v62 then
                let v65 : string = "-"
                let v66 : bool = v59.StartsWith (v65, false, null)
                let v69 : bool = v66 = false
                if v69 then
                    let v71 : bool = v59.EndsWith (v65, false, null)
                    let v74 : bool = v71 = false
                    if v74 then
                        (* run_target_args'
                        let v79 : unit = ()
                        run_target_args' *)
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v80 : string = "&*$0"
                        let v81 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v59 v80 
                        let _run_target_args'_v79 = v81 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        let v82 : string = "&*$0"
                        let v83 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v59 v82 
                        let _run_target_args'_v79 = v83 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        let v84 : string = "&*$0"
                        let v85 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v59 v84 
                        let _run_target_args'_v79 = v85 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        let v87 : Ref<Str> = v59 |> unbox<Ref<Str>>
                        let _run_target_args'_v79 = v87 
                        #endif
#if FABLE_COMPILER_PYTHON
                        let v91 : Ref<Str> = v59 |> unbox<Ref<Str>>
                        let _run_target_args'_v79 = v91 
                        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                        let v95 : Ref<Str> = v59 |> unbox<Ref<Str>>
                        let _run_target_args'_v79 = v95 
                        #endif
#else
                        let v99 : Ref<Str> = v59 |> unbox<Ref<Str>>
                        let _run_target_args'_v79 = v99 
                        #endif
                        let v102 : Ref<Str> = _run_target_args'_v79 
                        let v108 : string = $"$0.chars()"
                        let v109 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v102 v108 
                        let v110 : string = "true; // 1"
                        let v111 : bool = Fable.Core.RustInterop.emitRustExpr () v110 
                        let v112 : string = "let mut v109 = v109"
                        Fable.Core.RustInterop.emitRustExpr () v112 
                        let v113 : string = $"v109.all(|x| $0(x))"
                        let v114 : (char -> bool) = closure1()
                        let v115 : bool = Fable.Core.RustInterop.emitRustExpr v114 v113 
                        v115
                    else
                        false
                else
                    false
            else
                false
        else
            false
    let _result = v119 in _result |> (fun x -> Fable.Core.RustInterop.emitRustExpr x "$0 }") // 2
    let v120 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v120 
    let v121 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v121 
    let v122 : string = "true; // ??? / i: 2uy / i': 1uy / acc: 2uy / n: 1uy"
    let v123 : bool = Fable.Core.RustInterop.emitRustExpr () v122 
    let v124 : string = "true; */ // ???? / i: 2uy / i': 2uy / acc: 2uy / n: 1uy"
    let v125 : bool = Fable.Core.RustInterop.emitRustExpr () v124 
    let v126 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v126 
    let v127 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v127 
    let v128 : string = "pub fn generate_cid( //"
    Fable.Core.RustInterop.emitRustExpr () v128 
    let v129 : string = "  &self, //"
    Fable.Core.RustInterop.emitRustExpr () v129 
    let v130 : string = "  content: Vec<u8>, //"
    Fable.Core.RustInterop.emitRustExpr () v130 
    let v131 : string = ") -> String { //"
    Fable.Core.RustInterop.emitRustExpr () v131 
    let v132 : string = $"content"
    let v133 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v132 
    let v134 : string = "  fn encode_u64(value: u64) -> Vec<u8> { //"
    Fable.Core.RustInterop.emitRustExpr () v134 
    let v135 : string = "    let mut buffer = unsigned_varint::encode::u64_buffer(); //"
    Fable.Core.RustInterop.emitRustExpr () v135 
    let v136 : string = "    unsigned_varint::encode::u64(value, &mut buffer).to_vec() //"
    Fable.Core.RustInterop.emitRustExpr () v136 
    let v137 : string = "  } //"
    Fable.Core.RustInterop.emitRustExpr () v137 
    let v138 : string = "  fn sha256_hash(content: &[u8]) -> Vec<u8> { //"
    Fable.Core.RustInterop.emitRustExpr () v138 
    let v139 : string = "    let mut hasher: sha2::Sha256 = sha2::Digest::new(); //"
    Fable.Core.RustInterop.emitRustExpr () v139 
    let v140 : string = "    sha2::Digest::update(&mut hasher, content); //"
    Fable.Core.RustInterop.emitRustExpr () v140 
    let v141 : string = "    sha2::Digest::finalize(hasher).to_vec() //"
    Fable.Core.RustInterop.emitRustExpr () v141 
    let v142 : string = "  } //"
    Fable.Core.RustInterop.emitRustExpr () v142 
    let v143 : string = "  let version: u8 = 1; //"
    Fable.Core.RustInterop.emitRustExpr () v143 
    let v144 : string = "  let codec_raw: u64 = 0x55; //"
    Fable.Core.RustInterop.emitRustExpr () v144 
    let v145 : string = "  let codec_bytes = encode_u64(codec_raw); //"
    Fable.Core.RustInterop.emitRustExpr () v145 
    let v146 : string = "  let hash_result = sha256_hash(&v133); //"
    Fable.Core.RustInterop.emitRustExpr () v146 
    let v147 : string = "  let multihash = std::iter::once(0x12) //"
    Fable.Core.RustInterop.emitRustExpr () v147 
    let v148 : string = "    .chain(std::iter::once(32)) //"
    Fable.Core.RustInterop.emitRustExpr () v148 
    let v149 : string = "    .chain(hash_result.into_iter()) //"
    Fable.Core.RustInterop.emitRustExpr () v149 
    let v150 : string = "    .collect(); //"
    Fable.Core.RustInterop.emitRustExpr () v150 
    let v151 : string = "  let cid_bytes = [vec![version], codec_bytes, multihash].concat(); //"
    Fable.Core.RustInterop.emitRustExpr () v151 
    let v152 : string = "  let result = multibase::encode(multibase::Base::Base32Lower, &cid_bytes); //"
    Fable.Core.RustInterop.emitRustExpr () v152 
    let v153 : string = "result"
    let v154 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v153 
    let _result = v154 in _result |> (fun x -> Fable.Core.RustInterop.emitRustExpr x "$0 }") // 2
    let v155 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v155 
    let v156 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v156 
    let v157 : string = "true; // ??? / i: 3uy / i': 1uy / acc: 3uy / n: 2uy"
    let v158 : bool = Fable.Core.RustInterop.emitRustExpr () v157 
    let v159 : string = "true; */ // ???? / i: 3uy / i': 2uy / acc: 3uy / n: 2uy"
    let v160 : bool = Fable.Core.RustInterop.emitRustExpr () v159 
    let v161 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v161 
    let v162 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v162 
    let v163 : string = "#[result_serializer(borsh)] //"
    Fable.Core.RustInterop.emitRustExpr () v163 
    let v164 : string = "pub fn generate_cid_borsh( //"
    Fable.Core.RustInterop.emitRustExpr () v164 
    let v165 : string = "  &self, //"
    Fable.Core.RustInterop.emitRustExpr () v165 
    let v166 : string = "  #[serializer(borsh)] content: Vec<u8>, //"
    Fable.Core.RustInterop.emitRustExpr () v166 
    let v167 : string = ") -> String { //"
    Fable.Core.RustInterop.emitRustExpr () v167 
    let v168 : string = "  self.generate_cid(content) //"
    Fable.Core.RustInterop.emitRustExpr () v168 
    let v169 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v169 
    let v170 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v170 
    let v171 : string = "true; // ??? / i: 4uy / i': 1uy / acc: 5uy / n: 1uy"
    let v172 : bool = Fable.Core.RustInterop.emitRustExpr () v171 
    let v173 : string = "true; */ // ???? / i: 4uy / i': 2uy / acc: 5uy / n: 1uy"
    let v174 : bool = Fable.Core.RustInterop.emitRustExpr () v173 
    let v175 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v175 
    let v176 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v176 
    let v177 : string = "pub fn claim_alias( //"
    Fable.Core.RustInterop.emitRustExpr () v177 
    let v178 : string = "  &mut self, //"
    Fable.Core.RustInterop.emitRustExpr () v178 
    let v179 : string = "  alias: String, //"
    Fable.Core.RustInterop.emitRustExpr () v179 
    let v180 : string = ") { //"
    Fable.Core.RustInterop.emitRustExpr () v180 
    let v181 : string = $"&mut self.0"
    let v182 : Ref<Mut<struct (uint32 * near_sdk_store_IterableSet<near_sdk_AccountId> * near_sdk_store_IterableSet<std_string_String> * near_sdk_store_LookupMap<near_sdk_AccountId, std_string_String> * near_sdk_store_LookupMap<std_string_String, std_collections_HashMap<near_sdk_AccountId, struct (uint64 * uint32)>>)>> = Fable.Core.RustInterop.emitRustExpr () v181 
    let v183 : string = $"alias"
    let v184 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v183 
    let v185 : string = $"&mut v182.1"
    let v186 : Ref<Mut<near_sdk_store_IterableSet<near_sdk_AccountId>>> = Fable.Core.RustInterop.emitRustExpr () v185 
    let v187 : string = $"&mut v182.2"
    let v188 : Ref<Mut<near_sdk_store_IterableSet<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr () v187 
    let v189 : string = $"&mut v182.3"
    let v190 : Ref<Mut<near_sdk_store_LookupMap<near_sdk_AccountId, std_string_String>>> = Fable.Core.RustInterop.emitRustExpr () v189 
    let v191 : string = $"&mut v182.4"
    let v192 : Ref<Mut<near_sdk_store_LookupMap<std_string_String, std_collections_HashMap<near_sdk_AccountId, struct (uint64 * uint32)>>>> = Fable.Core.RustInterop.emitRustExpr () v191 
    let v193 : string = $"near_sdk::env::signer_account_id()"
    let v194 : near_sdk_AccountId = Fable.Core.RustInterop.emitRustExpr () v193 
    let v195 : string = $"near_sdk::env::predecessor_account_id()"
    let v196 : near_sdk_AccountId = Fable.Core.RustInterop.emitRustExpr () v195 
    let v197 : string = $"near_sdk::env::block_timestamp()"
    let v198 : uint64 = Fable.Core.RustInterop.emitRustExpr () v197 
    let v199 : unit = ()
    let v200 : (unit -> unit) = closure2(v184, v194, v196, v198)
    let v201 : unit = (fun () -> v200 (); v199) ()
    let v252 : string = "fable_library_rust::String_::fromString($0)"
    let v253 : string = Fable.Core.RustInterop.emitRustExpr v184 v252 
    let v254 : int32 = v253.Length
    let v255 : bool = v254 > 0
    let v313 : bool =
        if v255 then
            let v256 : bool = v254 < 64
            if v256 then
                let v259 : string = "-"
                let v260 : bool = v253.StartsWith (v259, false, null)
                let v263 : bool = v260 = false
                if v263 then
                    let v265 : bool = v253.EndsWith (v259, false, null)
                    let v268 : bool = v265 = false
                    if v268 then
                        (* run_target_args'
                        let v273 : unit = ()
                        run_target_args' *)
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v274 : string = "&*$0"
                        let v275 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v253 v274 
                        let _run_target_args'_v273 = v275 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        let v276 : string = "&*$0"
                        let v277 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v253 v276 
                        let _run_target_args'_v273 = v277 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        let v278 : string = "&*$0"
                        let v279 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v253 v278 
                        let _run_target_args'_v273 = v279 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        let v281 : Ref<Str> = v253 |> unbox<Ref<Str>>
                        let _run_target_args'_v273 = v281 
                        #endif
#if FABLE_COMPILER_PYTHON
                        let v285 : Ref<Str> = v253 |> unbox<Ref<Str>>
                        let _run_target_args'_v273 = v285 
                        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                        let v289 : Ref<Str> = v253 |> unbox<Ref<Str>>
                        let _run_target_args'_v273 = v289 
                        #endif
#else
                        let v293 : Ref<Str> = v253 |> unbox<Ref<Str>>
                        let _run_target_args'_v273 = v293 
                        #endif
                        let v296 : Ref<Str> = _run_target_args'_v273 
                        let v302 : string = $"$0.chars()"
                        let v303 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v296 v302 
                        let v304 : string = "true; // 1"
                        let v305 : bool = Fable.Core.RustInterop.emitRustExpr () v304 
                        let v306 : string = "let mut v303 = v303"
                        Fable.Core.RustInterop.emitRustExpr () v306 
                        let v307 : string = $"v303.all(|x| $0(x))"
                        let v308 : (char -> bool) = closure1()
                        let v309 : bool = Fable.Core.RustInterop.emitRustExpr v308 v307 
                        v309
                    else
                        false
                else
                    false
            else
                false
        else
            false
    let v314 : bool = v313 = false
    let v318 : bool =
        if v314 then
            let v315 : string = $"true; near_sdk::env::panic_str(&*$0); //"
            let v316 : string = "chat_contract.claim_alias / invalid alias"
            let v317 : bool = Fable.Core.RustInterop.emitRustExpr v316 v315 
            true
        else
            false
    let v319 : string = $"v190.get(&$0)"
    let v320 : Ref<std_string_String> option = Fable.Core.RustInterop.emitRustExpr v194 v319 
    let v321 : string = "$0.cloned()"
    let v322 : std_string_String option = Fable.Core.RustInterop.emitRustExpr v320 v321 
    let v325 : (std_string_String -> US6) = method19()
    let v326 : US6 option = v322 |> Option.map v325 
    let v340 : US6 = US6_1
    let v341 : US6 = v326 |> Option.defaultValue v340 
    match v341 with
    | US6_0(v345) -> (* Some *)
        let v347 : bool = v345 = v184 
        if v347 then
            let v350 : unit = ()
            let v351 : (unit -> unit) = closure12(v345)
            let v352 : unit = (fun () -> v351 (); v350) ()
            ()
        else
            let v403 : unit = ()
            let v404 : (unit -> unit) = closure13(v322)
            let v405 : unit = (fun () -> v404 (); v403) ()
            let v456 : string = "    v192 //"
            Fable.Core.RustInterop.emitRustExpr () v456 
            let v457 : string = "      .get_mut(&v345) //"
            Fable.Core.RustInterop.emitRustExpr () v457 
            let v458 : string = "      .unwrap() //"
            Fable.Core.RustInterop.emitRustExpr () v458 
            let v459 : string = "      .remove(&$0); //"
            Fable.Core.RustInterop.emitRustExpr v194 v459 
            let v460 : string = "  v190.insert($0.clone(), $1.clone()); //"
            Fable.Core.RustInterop.emitRustExpr struct (v194, v184) v460 
            let v461 : string = $"v186.insert($0)"
            let v462 : bool = Fable.Core.RustInterop.emitRustExpr v194 v461 
            let v463 : string = $"v188.insert($0)"
            let v464 : bool = Fable.Core.RustInterop.emitRustExpr v184 v463 
            let v465 : string = "  let new_alias_account_map = match v192.get(&$0) { //"
            Fable.Core.RustInterop.emitRustExpr v184 v465 
            let v466 : string = "    None => { //"
            Fable.Core.RustInterop.emitRustExpr () v466 
            let v467 : string = "      let mut new_map = std::collections::HashMap::new(); //"
            Fable.Core.RustInterop.emitRustExpr () v467 
            let v468 : string = "      new_map.insert($0, ($1, 0u32)); //"
            Fable.Core.RustInterop.emitRustExpr struct (v194, v198) v468 
            let v469 : string = "      new_map //"
            Fable.Core.RustInterop.emitRustExpr () v469 
            let v470 : string = "    } //"
            Fable.Core.RustInterop.emitRustExpr () v470 
            let v471 : string = "    Some(accounts) => { //"
            Fable.Core.RustInterop.emitRustExpr () v471 
            let v472 : string = "      let mut accounts_vec = accounts.iter().collect::<Vec<_>>(); //"
            Fable.Core.RustInterop.emitRustExpr () v472 
            let v473 : string = "      accounts_vec.sort_unstable_by_key(|(_, (_, index))| index); //"
            Fable.Core.RustInterop.emitRustExpr () v473 
            let v474 : string = "      let mut new_map = accounts_vec //"
            Fable.Core.RustInterop.emitRustExpr () v474 
            let v475 : string = "        .iter() //"
            Fable.Core.RustInterop.emitRustExpr () v475 
            let v476 : string = "        .enumerate() //"
            Fable.Core.RustInterop.emitRustExpr () v476 
            let v477 : string = "        .map(|(i, (signer_account_id, (timestamp, _)))| { //"
            Fable.Core.RustInterop.emitRustExpr () v477 
            let v478 : string = "          ((*signer_account_id).clone(), (*timestamp, i as u32)) //"
            Fable.Core.RustInterop.emitRustExpr () v478 
            let v479 : string = "        }) //"
            Fable.Core.RustInterop.emitRustExpr () v479 
            let v480 : string = "        .collect::<std::collections::HashMap<_, _>>(); //"
            Fable.Core.RustInterop.emitRustExpr () v480 
            let v481 : string = "      new_map.insert($0, (v198, accounts_vec.len() as u32)); //"
            Fable.Core.RustInterop.emitRustExpr v194 v481 
            let v482 : string = "      new_map //"
            Fable.Core.RustInterop.emitRustExpr () v482 
            let v483 : string = "    } //"
            Fable.Core.RustInterop.emitRustExpr () v483 
            let v484 : string = "  }; //"
            Fable.Core.RustInterop.emitRustExpr () v484 
            let v485 : string = "  v192.insert($0, new_alias_account_map); //"
            Fable.Core.RustInterop.emitRustExpr v184 v485 
            ()
    | _ ->
        let v486 : unit = ()
        let v487 : (unit -> unit) = closure13(v322)
        let v488 : unit = (fun () -> v487 (); v486) ()
        match v341 with
        | US6_1 -> (* None *)
            ()
        let v539 : string = "  v190.insert($0.clone(), $1.clone()); //"
        Fable.Core.RustInterop.emitRustExpr struct (v194, v184) v539 
        let v540 : string = $"v186.insert($0)"
        let v541 : bool = Fable.Core.RustInterop.emitRustExpr v194 v540 
        let v542 : string = $"v188.insert($0)"
        let v543 : bool = Fable.Core.RustInterop.emitRustExpr v184 v542 
        let v544 : string = "  let new_alias_account_map = match v192.get(&$0) { //"
        Fable.Core.RustInterop.emitRustExpr v184 v544 
        let v545 : string = "    None => { //"
        Fable.Core.RustInterop.emitRustExpr () v545 
        let v546 : string = "      let mut new_map = std::collections::HashMap::new(); //"
        Fable.Core.RustInterop.emitRustExpr () v546 
        let v547 : string = "      new_map.insert($0, ($1, 0u32)); //"
        Fable.Core.RustInterop.emitRustExpr struct (v194, v198) v547 
        let v548 : string = "      new_map //"
        Fable.Core.RustInterop.emitRustExpr () v548 
        let v549 : string = "    } //"
        Fable.Core.RustInterop.emitRustExpr () v549 
        let v550 : string = "    Some(accounts) => { //"
        Fable.Core.RustInterop.emitRustExpr () v550 
        let v551 : string = "      let mut accounts_vec = accounts.iter().collect::<Vec<_>>(); //"
        Fable.Core.RustInterop.emitRustExpr () v551 
        let v552 : string = "      accounts_vec.sort_unstable_by_key(|(_, (_, index))| index); //"
        Fable.Core.RustInterop.emitRustExpr () v552 
        let v553 : string = "      let mut new_map = accounts_vec //"
        Fable.Core.RustInterop.emitRustExpr () v553 
        let v554 : string = "        .iter() //"
        Fable.Core.RustInterop.emitRustExpr () v554 
        let v555 : string = "        .enumerate() //"
        Fable.Core.RustInterop.emitRustExpr () v555 
        let v556 : string = "        .map(|(i, (signer_account_id, (timestamp, _)))| { //"
        Fable.Core.RustInterop.emitRustExpr () v556 
        let v557 : string = "          ((*signer_account_id).clone(), (*timestamp, i as u32)) //"
        Fable.Core.RustInterop.emitRustExpr () v557 
        let v558 : string = "        }) //"
        Fable.Core.RustInterop.emitRustExpr () v558 
        let v559 : string = "        .collect::<std::collections::HashMap<_, _>>(); //"
        Fable.Core.RustInterop.emitRustExpr () v559 
        let v560 : string = "      new_map.insert($0, (v198, accounts_vec.len() as u32)); //"
        Fable.Core.RustInterop.emitRustExpr v194 v560 
        let v561 : string = "      new_map //"
        Fable.Core.RustInterop.emitRustExpr () v561 
        let v562 : string = "    } //"
        Fable.Core.RustInterop.emitRustExpr () v562 
        let v563 : string = "  }; //"
        Fable.Core.RustInterop.emitRustExpr () v563 
        let v564 : string = "  v192.insert($0, new_alias_account_map); //"
        Fable.Core.RustInterop.emitRustExpr v184 v564 
        ()
    let v565 : (unit -> unit) = method24()
    let v566 : unit = ()
    let v567 : (unit -> unit) = closure15(v565)
    let v568 : unit = (fun () -> v567 (); v566) ()
    let v614 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v614 
    let v615 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v615 
    let v616 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v616 
    let v617 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v617 
    let v618 : string = "true; // ??? / i: 5uy / i': 1uy / acc: 6uy / n: 3uy"
    let v619 : bool = Fable.Core.RustInterop.emitRustExpr () v618 
    let v620 : string = "true; */ // ???? / i: 5uy / i': 2uy / acc: 6uy / n: 3uy"
    let v621 : bool = Fable.Core.RustInterop.emitRustExpr () v620 
    let v622 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v622 
    let v623 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v623 
    let v624 : string = "pub fn get_account_info( //"
    Fable.Core.RustInterop.emitRustExpr () v624 
    let v625 : string = "  &self, //"
    Fable.Core.RustInterop.emitRustExpr () v625 
    let v626 : string = "  account_id: near_sdk::AccountId, //"
    Fable.Core.RustInterop.emitRustExpr () v626 
    let v627 : string = ") -> Option<(String, u64, u32)> { //"
    Fable.Core.RustInterop.emitRustExpr () v627 
    let v628 : string = $"&self.0"
    let v629 : Ref<struct (uint32 * near_sdk_store_IterableSet<near_sdk_AccountId> * near_sdk_store_IterableSet<std_string_String> * near_sdk_store_LookupMap<near_sdk_AccountId, std_string_String> * near_sdk_store_LookupMap<std_string_String, std_collections_HashMap<near_sdk_AccountId, struct (uint64 * uint32)>>)> = Fable.Core.RustInterop.emitRustExpr () v628 
    let v630 : string = $"account_id"
    let v631 : near_sdk_AccountId = Fable.Core.RustInterop.emitRustExpr () v630 
    let v632 : string = $"&v629.3"
    let v633 : Ref<near_sdk_store_LookupMap<near_sdk_AccountId, std_string_String>> = Fable.Core.RustInterop.emitRustExpr () v632 
    let v634 : string = $"&v629.4"
    let v635 : Ref<near_sdk_store_LookupMap<std_string_String, std_collections_HashMap<near_sdk_AccountId, struct (uint64 * uint32)>>> = Fable.Core.RustInterop.emitRustExpr () v634 
    let v636 : string = "true; let result = v633.get(&$0).and_then(|alias| { //"
    let v637 : bool = Fable.Core.RustInterop.emitRustExpr v631 v636 
    let v638 : string = "true;    v635.get(alias).map(|accounts| { //"
    let v639 : bool = Fable.Core.RustInterop.emitRustExpr () v638 
    let v640 : string = "true;        let result = (alias.clone(), *accounts.get(&v631).unwrap()); //"
    let v641 : bool = Fable.Core.RustInterop.emitRustExpr () v640 
    let v642 : string = "true;        (result.0, result.1.0, result.1.1)  }) }); //"
    let v643 : bool = Fable.Core.RustInterop.emitRustExpr () v642 
    let v644 : string = "result"
    let v645 : struct (std_string_String * uint64 * uint32) option = Fable.Core.RustInterop.emitRustExpr () v644 
    let v646 : unit = ()
    let v647 : (unit -> unit) = closure16(v631, v645)
    let v648 : unit = (fun () -> v647 (); v646) ()
    let v695 : unit = ()
    let v696 : (unit -> unit) = closure17()
    let v697 : unit = (fun () -> v696 (); v695) ()
    let _result = v645 in _result |> (fun x -> Fable.Core.RustInterop.emitRustExpr x "$0 } // 4") // 3
    let v743 : string = "} // 1"
    Fable.Core.RustInterop.emitRustExpr () v743 
    let v744 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v744 
    let v745 : string = "true; // ??? / i: 6uy / i': 1uy / acc: 9uy / n: 1uy"
    let v746 : bool = Fable.Core.RustInterop.emitRustExpr () v745 
    let v747 : string = "true; */ // ???? / i: 6uy / i': 2uy / acc: 9uy / n: 1uy"
    let v748 : bool = Fable.Core.RustInterop.emitRustExpr () v747 
    let v749 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v749 
    let v750 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v750 
    let v751 : string = "pub fn get_alias_map( //"
    Fable.Core.RustInterop.emitRustExpr () v751 
    let v752 : string = "  &self, //"
    Fable.Core.RustInterop.emitRustExpr () v752 
    let v753 : string = "  alias: String, //"
    Fable.Core.RustInterop.emitRustExpr () v753 
    let v754 : string = ") -> Option<std::collections::HashMap<near_sdk::AccountId, (u64, u32)>> { //"
    Fable.Core.RustInterop.emitRustExpr () v754 
    let v755 : string = $"&self.0.4"
    let v756 : Ref<near_sdk_store_LookupMap<std_string_String, std_collections_HashMap<near_sdk_AccountId, struct (uint64 * uint32)>>> = Fable.Core.RustInterop.emitRustExpr () v755 
    let v757 : string = $"alias"
    let v758 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v757 
    let v759 : unit = ()
    let v760 : (unit -> unit) = closure18(v758)
    let v761 : unit = (fun () -> v760 (); v759) ()
    let v808 : (unit -> unit) = method30()
    let v809 : unit = ()
    let v810 : (unit -> unit) = closure19(v808)
    let v811 : unit = (fun () -> v810 (); v809) ()
    let v857 : string = "  v756.get(&$0).cloned() //"
    Fable.Core.RustInterop.emitRustExpr v758 v857 
    let v858 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v858 
    let v859 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v859 
    let v860 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v860 
    let v861 : string = "true; // ??? / i: 7uy / i': 1uy / acc: 10uy / n: 2uy"
    let v862 : bool = Fable.Core.RustInterop.emitRustExpr () v861 
    let v863 : string = "true; */ // ???? / i: 7uy / i': 2uy / acc: 10uy / n: 2uy"
    let v864 : bool = Fable.Core.RustInterop.emitRustExpr () v863 
    let v865 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v865 
    let v866 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v866 
    let v867 : string = "#[result_serializer(borsh)] //"
    Fable.Core.RustInterop.emitRustExpr () v867 
    let v868 : string = "pub fn get_alias_map_borsh( //"
    Fable.Core.RustInterop.emitRustExpr () v868 
    let v869 : string = "  &self, //"
    Fable.Core.RustInterop.emitRustExpr () v869 
    let v870 : string = "  #[serializer(borsh)] alias: String, //"
    Fable.Core.RustInterop.emitRustExpr () v870 
    let v871 : string = ") -> Option<std::collections::HashMap<near_sdk::AccountId, (u64, u32)>> { //"
    Fable.Core.RustInterop.emitRustExpr () v871 
    let v872 : string = "  self.get_alias_map(alias) //"
    Fable.Core.RustInterop.emitRustExpr () v872 
    let v873 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v873 
    let v874 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v874 
    let v875 : string = "true; // ??? / i: 8uy / i': 1uy / acc: 12uy / n: 1uy"
    let v876 : bool = Fable.Core.RustInterop.emitRustExpr () v875 
    let v877 : string = "true; */ // ???? / i: 8uy / i': 2uy / acc: 12uy / n: 1uy"
    let v878 : bool = Fable.Core.RustInterop.emitRustExpr () v877 
    let v879 : string = "fn _main() //"
    Fable.Core.RustInterop.emitRustExpr () v879 
    let v880 : string = "{ { //"
    Fable.Core.RustInterop.emitRustExpr () v880 
    let v881 : string = "true; { (); // ?? / i': 1uy / n: 13uy"
    let v882 : bool = Fable.Core.RustInterop.emitRustExpr () v881 
    let v883 : string = "true; { (); // ?? / i': 2uy / n: 13uy"
    let v884 : bool = Fable.Core.RustInterop.emitRustExpr () v883 
    let v885 : string = "true; { (); // ?? / i': 3uy / n: 13uy"
    let v886 : bool = Fable.Core.RustInterop.emitRustExpr () v885 
    let v887 : string = "true; { (); // ?? / i': 4uy / n: 13uy"
    let v888 : bool = Fable.Core.RustInterop.emitRustExpr () v887 
    let v889 : string = "true; { (); // ?? / i': 5uy / n: 13uy"
    let v890 : bool = Fable.Core.RustInterop.emitRustExpr () v889 
    let v891 : string = "true; { (); // ?? / i': 6uy / n: 13uy"
    let v892 : bool = Fable.Core.RustInterop.emitRustExpr () v891 
    let v893 : string = "true; { (); // ?? / i': 7uy / n: 13uy"
    let v894 : bool = Fable.Core.RustInterop.emitRustExpr () v893 
    let v895 : string = "true; { (); // ?? / i': 8uy / n: 13uy"
    let v896 : bool = Fable.Core.RustInterop.emitRustExpr () v895 
    let v897 : string = "true; { (); // ?? / i': 9uy / n: 13uy"
    let v898 : bool = Fable.Core.RustInterop.emitRustExpr () v897 
    let v899 : string = "true; { (); // ?? / i': 10uy / n: 13uy"
    let v900 : bool = Fable.Core.RustInterop.emitRustExpr () v899 
    let v901 : string = "true; { (); // ?? / i': 11uy / n: 13uy"
    let v902 : bool = Fable.Core.RustInterop.emitRustExpr () v901 
    let v903 : string = "true; { (); // ?? / i': 12uy / n: 13uy"
    let v904 : bool = Fable.Core.RustInterop.emitRustExpr () v903 
    let v905 : string = "true; { (); // ?? / i': 13uy / n: 13uy"
    let v906 : bool = Fable.Core.RustInterop.emitRustExpr () v905 
    let v907 : string = "true; { { (); // ? / i': 14uy / n: 13uy"
    let v908 : bool = Fable.Core.RustInterop.emitRustExpr () v907 
    ()
let v0 : (unit -> unit) = closure0()
v0 |> ignore
()
