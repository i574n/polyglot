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
    let v2 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : string = method4(v0)
    let v4 : string = "std::env::var(&*$0)"
    let v5 : Result<std_string_String, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr v3 v4 
    let v6 : string = "true; let _result_map_ = $0.map(|x| { //"
    let v7 : bool = Fable.Core.RustInterop.emitRustExpr v5 v6 
    let v8 : string = "x"
    let v9 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v8 
    let v10 : string = "fable_library_rust::String_::fromString($0)"
    let v11 : string = Fable.Core.RustInterop.emitRustExpr v9 v10 
    let v12 : string = "true; $0 })"
    let v13 : bool = Fable.Core.RustInterop.emitRustExpr v11 v12 
    let v14 : string = "_result_map_"
    let v15 : Result<string, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr () v14 
    let v16 : string = method5()
    let v17 : string = "$0.unwrap_or($1)"
    let v18 : string = Fable.Core.RustInterop.emitRustExpr struct (v15, v16) v17 
    let _run_target_args'_v2 = v18 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v19 : US3 = US3_1
    let v20 : US4 = US4_3(v19)
    let v21 : string = $"env.get_environment_variable / target: {v20} / var: {v0}"
    let v22 : string = failwith<string> v21
    let _run_target_args'_v2 = v22 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v23 : US3 = US3_2
    let v24 : US4 = US4_3(v23)
    let v25 : string = $"env.get_environment_variable / target: {v24} / var: {v0}"
    let v26 : string = failwith<string> v25
    let _run_target_args'_v2 = v26 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v27 : string = "process.env[$0] ?? \"\""
    let v28 : string = Fable.Core.JsInterop.emitJsExpr v0 v27 
    let _run_target_args'_v2 = v28 
    #endif
#if FABLE_COMPILER_PYTHON
    let v30 : string = "os"
    let v31 : IOsEnviron = Fable.Core.PyInterop.importAll v30 
    let v32 : string = "v31.environ"
    let v33 : obj = Fable.Core.PyInterop.emitPyExpr () v32 
    let v37 : string = "v33.get($0)"
    let v38 : string = Fable.Core.PyInterop.emitPyExpr v0 v37 
    let mutable _v38 = None
    #if !FABLE_COMPILER && !WASM && !CONTRACT
    let v42 : (string -> string option) = Option.ofObj
    let v43 : string option = v42 v38
    v43 
    #else
    Some v38 
    #endif
    |> fun x -> _v38 <- Some x
    let v44 : string option = match _v38 with Some x -> x | None -> failwith "optionm'.of_obj / _v38=None"
    let v49 : (string -> US5) = method6()
    let v50 : US5 option = v44 |> Option.map v49 
    let v70 : US5 = US5_1
    let v71 : US5 = v50 |> Option.defaultValue v70 
    let v78 : string =
        match v71 with
        | US5_1 -> (* None *)
            let v76 : string = ""
            v76
        | US5_0(v75) -> (* Some *)
            v75
    let _run_target_args'_v2 = v78 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v79 : US3 = US3_1
    let v80 : US4 = US4_1(v79)
    let v81 : string = $"env.get_environment_variable / target: {v80} / var: {v0}"
    let v82 : string = failwith<string> v81
    let _run_target_args'_v2 = v82 
    #endif
#else
    let v83 : (string -> string) = System.Environment.GetEnvironmentVariable
    let v84 : string = v83 v0
    let mutable _v84 = None
    #if !FABLE_COMPILER && !WASM && !CONTRACT
    let v86 : (string -> string option) = Option.ofObj
    let v87 : string option = v86 v84
    v87 
    #else
    Some v84 
    #endif
    |> fun x -> _v84 <- Some x
    let v88 : string option = match _v84 with Some x -> x | None -> failwith "optionm'.of_obj / _v84=None"
    let v93 : (string -> US5) = method6()
    let v94 : US5 option = v88 |> Option.map v93 
    let v114 : US5 = US5_1
    let v115 : US5 = v94 |> Option.defaultValue v114 
    let v122 : string =
        match v115 with
        | US5_1 -> (* None *)
            let v120 : string = ""
            v120
        | US5_0(v119) -> (* Some *)
            v119
    let _run_target_args'_v2 = v122 
    #endif
    let v123 : string = _run_target_args'_v2 
    v123
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
    let v209 : US2 =
        if v133 then
            US2_1
        else
            (* run_target_args'
            let v143 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v144 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v143 = v144 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v145 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v143 = v145 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v147 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v143 = v147 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v150 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v143 = v150 
            #endif
#if FABLE_COMPILER_PYTHON
            let v151 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v143 = v151 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v152 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v143 = v152 
            #endif
#else
            let v153 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v143 = v153 
            #endif
            let v154 : System.DateTime = _run_target_args'_v143 
            (* run_target_args'
            let v165 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v166 : (System.DateTime -> int64) = _.Ticks
            let v167 : int64 = v166 v154
            let _run_target_args'_v165 = v167 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v168 : (System.DateTime -> int64) = _.Ticks
            let v169 : int64 = v168 v154
            let _run_target_args'_v165 = v169 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v171 : int64 = null |> unbox<int64>
            let _run_target_args'_v165 = v171 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v174 : (System.DateTime -> int64) = _.Ticks
            let v175 : int64 = v174 v154
            let _run_target_args'_v165 = v175 
            #endif
#if FABLE_COMPILER_PYTHON
            let v176 : (System.DateTime -> int64) = _.Ticks
            let v177 : int64 = v176 v154
            let _run_target_args'_v165 = v177 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v178 : (System.DateTime -> int64) = _.Ticks
            let v179 : int64 = v178 v154
            let _run_target_args'_v165 = v179 
            #endif
#else
            let v180 : (System.DateTime -> int64) = _.Ticks
            let v181 : int64 = v180 v154
            let _run_target_args'_v165 = v181 
            #endif
            let v182 : int64 = _run_target_args'_v165 
            let v203 : int64 = v182 |> int64 
            US2_0(v203)
    struct (v127, v209)
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
    let v198 : int64 option =
        match v173 with
        | US2_1 -> (* None *)
            let v194 : int64 option = None
            v194
        | US2_0(v188) -> (* Some *)
            let v190 : int64 option = Some v188 
            v190
    struct (v178, v180, v181, v183, v187, v198)
and closure3 () () : unit =
    let v0 : bool = TraceState.trace_state.IsNone
    if v0 then
        let v1 : US0 = US0_0
        let struct (v2 : Mut0, v3 : Mut1, v4 : Mut2, v5 : Mut3, v6 : Mut4, v7 : int64 option) = method1(v1)
        let v9 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v2, v3, v4, v5, v6, v7) 
        TraceState.trace_state <- v9 
        ()
and method0 (v0 : US0) : bool =
    let v15 : unit = ()
    let v16 : (unit -> unit) = closure3()
    let v17 : unit = (fun () -> v16 (); v15) ()
    let struct (v38 : Mut0, v39 : Mut1, v40 : Mut2, v41 : Mut3, v42 : Mut4, v43 : int64 option) = TraceState.trace_state.Value
    let v56 : US0 = v42.l0
    let v57 : bool = v40.l0
    let v58 : bool = v57 = false
    if v58 then
        false
    else
        let v59 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v0
        let v60 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v56
        let v61 : bool = v59 >= v60
        v61
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
    let v187 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v190 : (int64 -> US2) = method8()
    let v191 : US2 option = v5 |> Option.map v190 
    let v211 : US2 = US2_1
    let v212 : US2 = v191 |> Option.defaultValue v211 
    let v344 : System.DateTime =
        match v212 with
        | US2_1 -> (* None *)
            (* run_target_args'
            let v327 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v328 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v327 = v328 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v329 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v327 = v329 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v331 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v327 = v331 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v334 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v327 = v334 
            #endif
#if FABLE_COMPILER_PYTHON
            let v335 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v327 = v335 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v336 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v327 = v336 
            #endif
#else
            let v337 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v327 = v337 
            #endif
            let v338 : System.DateTime = _run_target_args'_v327 
            v338
        | US2_0(v216) -> (* Some *)
            (* run_target_args'
            let v223 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v224 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v223 = v224 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v225 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v223 = v225 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v227 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v223 = v227 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v230 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v223 = v230 
            #endif
#if FABLE_COMPILER_PYTHON
            let v231 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v223 = v231 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v232 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v223 = v232 
            #endif
#else
            let v233 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v223 = v233 
            #endif
            let v234 : System.DateTime = _run_target_args'_v223 
            (* run_target_args'
            let v245 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v246 : (System.DateTime -> int64) = _.Ticks
            let v247 : int64 = v246 v234
            let _run_target_args'_v245 = v247 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v248 : (System.DateTime -> int64) = _.Ticks
            let v249 : int64 = v248 v234
            let _run_target_args'_v245 = v249 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v251 : int64 = null |> unbox<int64>
            let _run_target_args'_v245 = v251 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v254 : (System.DateTime -> int64) = _.Ticks
            let v255 : int64 = v254 v234
            let _run_target_args'_v245 = v255 
            #endif
#if FABLE_COMPILER_PYTHON
            let v256 : (System.DateTime -> int64) = _.Ticks
            let v257 : int64 = v256 v234
            let _run_target_args'_v245 = v257 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v258 : (System.DateTime -> int64) = _.Ticks
            let v259 : int64 = v258 v234
            let _run_target_args'_v245 = v259 
            #endif
#else
            let v260 : (System.DateTime -> int64) = _.Ticks
            let v261 : int64 = v260 v234
            let _run_target_args'_v245 = v261 
            #endif
            let v262 : int64 = _run_target_args'_v245 
            let v283 : int64 = v262 |> int64 
            let v286 : int64 = v283 - v216
            let v292 : System.TimeSpan = v286 |> System.TimeSpan 
            let v298 : (System.TimeSpan -> int32) = _.Hours
            let v299 : int32 = v298 v292
            let v303 : (System.TimeSpan -> int32) = _.Minutes
            let v304 : int32 = v303 v292
            let v308 : (System.TimeSpan -> int32) = _.Seconds
            let v309 : int32 = v308 v292
            let v313 : (System.TimeSpan -> int32) = _.Milliseconds
            let v314 : int32 = v313 v292
            let v318 : System.DateTime = System.DateTime (1, 1, 1, v299, v304, v309, v314)
            v318
    let v346 : string = method9()
    let v350 : bool = v346 = ""
    let v352 : string =
        if v350 then
            let v351 : string = "M-d-y hh:mm:ss tt"
            v351
        else
            v346
    let v353 : (string -> string) = v344.ToString
    let v354 : string = v353 v352
    let _run_target_args'_v187 = v354 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v371 : (int64 -> US2) = method8()
    let v372 : US2 option = v5 |> Option.map v371 
    let v392 : US2 = US2_1
    let v393 : US2 = v372 |> Option.defaultValue v392 
    let v525 : System.DateTime =
        match v393 with
        | US2_1 -> (* None *)
            (* run_target_args'
            let v508 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v509 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v508 = v509 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v510 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v508 = v510 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v512 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v508 = v512 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v515 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v508 = v515 
            #endif
#if FABLE_COMPILER_PYTHON
            let v516 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v508 = v516 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v517 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v508 = v517 
            #endif
#else
            let v518 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v508 = v518 
            #endif
            let v519 : System.DateTime = _run_target_args'_v508 
            v519
        | US2_0(v397) -> (* Some *)
            (* run_target_args'
            let v404 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v405 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v404 = v405 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v406 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v404 = v406 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v408 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v404 = v408 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v411 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v404 = v411 
            #endif
#if FABLE_COMPILER_PYTHON
            let v412 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v404 = v412 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v413 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v404 = v413 
            #endif
#else
            let v414 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v404 = v414 
            #endif
            let v415 : System.DateTime = _run_target_args'_v404 
            (* run_target_args'
            let v426 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v427 : (System.DateTime -> int64) = _.Ticks
            let v428 : int64 = v427 v415
            let _run_target_args'_v426 = v428 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v429 : (System.DateTime -> int64) = _.Ticks
            let v430 : int64 = v429 v415
            let _run_target_args'_v426 = v430 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v432 : int64 = null |> unbox<int64>
            let _run_target_args'_v426 = v432 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v435 : (System.DateTime -> int64) = _.Ticks
            let v436 : int64 = v435 v415
            let _run_target_args'_v426 = v436 
            #endif
#if FABLE_COMPILER_PYTHON
            let v437 : (System.DateTime -> int64) = _.Ticks
            let v438 : int64 = v437 v415
            let _run_target_args'_v426 = v438 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v439 : (System.DateTime -> int64) = _.Ticks
            let v440 : int64 = v439 v415
            let _run_target_args'_v426 = v440 
            #endif
#else
            let v441 : (System.DateTime -> int64) = _.Ticks
            let v442 : int64 = v441 v415
            let _run_target_args'_v426 = v442 
            #endif
            let v443 : int64 = _run_target_args'_v426 
            let v464 : int64 = v443 |> int64 
            let v467 : int64 = v464 - v397
            let v473 : System.TimeSpan = v467 |> System.TimeSpan 
            let v479 : (System.TimeSpan -> int32) = _.Hours
            let v480 : int32 = v479 v473
            let v484 : (System.TimeSpan -> int32) = _.Minutes
            let v485 : int32 = v484 v473
            let v489 : (System.TimeSpan -> int32) = _.Seconds
            let v490 : int32 = v489 v473
            let v494 : (System.TimeSpan -> int32) = _.Milliseconds
            let v495 : int32 = v494 v473
            let v499 : System.DateTime = System.DateTime (1, 1, 1, v480, v485, v490, v495)
            v499
    let v527 : string = method9()
    let v531 : bool = v527 = ""
    let v533 : string =
        if v531 then
            let v532 : string = "M-d-y hh:mm:ss tt"
            v532
        else
            v527
    let v534 : (string -> string) = v525.ToString
    let v535 : string = v534 v533
    let _run_target_args'_v187 = v535 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v550 : string = $"near_sdk::env::block_timestamp()"
    let v551 : uint64 = Fable.Core.RustInterop.emitRustExpr () v550 
    let v554 : (int64 -> US2) = method8()
    let v555 : US2 option = v5 |> Option.map v554 
    let v575 : US2 = US2_1
    let v576 : US2 = v555 |> Option.defaultValue v575 
    let v588 : uint64 =
        match v576 with
        | US2_1 -> (* None *)
            v551
        | US2_0(v580) -> (* Some *)
            let v582 : (int64 -> uint64) = uint64
            let v583 : uint64 = v582 v580
            let v586 : uint64 = v551 - v583
            v586
    let v589 : uint64 = v588 / 1000000000UL
    let v590 : uint64 = v589 % 60UL
    let v591 : uint64 = v589 / 60UL
    let v592 : uint64 = v591 % 60UL
    let v593 : uint64 = v589 / 3600UL
    let v594 : uint64 = v593 % 24UL
    let v595 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
    let v596 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v594, v592, v590) v595 
    let v597 : string = "fable_library_rust::String_::fromString($0)"
    let v598 : string = Fable.Core.RustInterop.emitRustExpr v596 v597 
    let _run_target_args'_v187 = v598 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v601 : (int64 -> US2) = method8()
    let v602 : US2 option = v5 |> Option.map v601 
    let v622 : US2 = US2_1
    let v623 : US2 = v602 |> Option.defaultValue v622 
    let v755 : System.DateTime =
        match v623 with
        | US2_1 -> (* None *)
            (* run_target_args'
            let v738 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v739 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v738 = v739 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v740 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v738 = v740 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v742 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v738 = v742 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v745 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v738 = v745 
            #endif
#if FABLE_COMPILER_PYTHON
            let v746 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v738 = v746 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v747 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v738 = v747 
            #endif
#else
            let v748 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v738 = v748 
            #endif
            let v749 : System.DateTime = _run_target_args'_v738 
            v749
        | US2_0(v627) -> (* Some *)
            (* run_target_args'
            let v634 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v635 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v634 = v635 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v636 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v634 = v636 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v638 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v634 = v638 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v641 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v634 = v641 
            #endif
#if FABLE_COMPILER_PYTHON
            let v642 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v634 = v642 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v643 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v634 = v643 
            #endif
#else
            let v644 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v634 = v644 
            #endif
            let v645 : System.DateTime = _run_target_args'_v634 
            (* run_target_args'
            let v656 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v657 : (System.DateTime -> int64) = _.Ticks
            let v658 : int64 = v657 v645
            let _run_target_args'_v656 = v658 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v659 : (System.DateTime -> int64) = _.Ticks
            let v660 : int64 = v659 v645
            let _run_target_args'_v656 = v660 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v662 : int64 = null |> unbox<int64>
            let _run_target_args'_v656 = v662 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v665 : (System.DateTime -> int64) = _.Ticks
            let v666 : int64 = v665 v645
            let _run_target_args'_v656 = v666 
            #endif
#if FABLE_COMPILER_PYTHON
            let v667 : (System.DateTime -> int64) = _.Ticks
            let v668 : int64 = v667 v645
            let _run_target_args'_v656 = v668 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v669 : (System.DateTime -> int64) = _.Ticks
            let v670 : int64 = v669 v645
            let _run_target_args'_v656 = v670 
            #endif
#else
            let v671 : (System.DateTime -> int64) = _.Ticks
            let v672 : int64 = v671 v645
            let _run_target_args'_v656 = v672 
            #endif
            let v673 : int64 = _run_target_args'_v656 
            let v694 : int64 = v673 |> int64 
            let v697 : int64 = v694 - v627
            let v703 : System.TimeSpan = v697 |> System.TimeSpan 
            let v709 : (System.TimeSpan -> int32) = _.Hours
            let v710 : int32 = v709 v703
            let v714 : (System.TimeSpan -> int32) = _.Minutes
            let v715 : int32 = v714 v703
            let v719 : (System.TimeSpan -> int32) = _.Seconds
            let v720 : int32 = v719 v703
            let v724 : (System.TimeSpan -> int32) = _.Milliseconds
            let v725 : int32 = v724 v703
            let v729 : System.DateTime = System.DateTime (1, 1, 1, v710, v715, v720, v725)
            v729
    let v757 : string = method10()
    let v761 : bool = v757 = ""
    let v763 : string =
        if v761 then
            let v762 : string = "M-d-y hh:mm:ss tt"
            v762
        else
            v757
    let v764 : (string -> string) = v755.ToString
    let v765 : string = v764 v763
    let _run_target_args'_v187 = v765 
    #endif
#if FABLE_COMPILER_PYTHON
    let v782 : (int64 -> US2) = method8()
    let v783 : US2 option = v5 |> Option.map v782 
    let v803 : US2 = US2_1
    let v804 : US2 = v783 |> Option.defaultValue v803 
    let v936 : System.DateTime =
        match v804 with
        | US2_1 -> (* None *)
            (* run_target_args'
            let v919 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v920 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v919 = v920 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v921 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v919 = v921 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v923 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v919 = v923 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v926 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v919 = v926 
            #endif
#if FABLE_COMPILER_PYTHON
            let v927 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v919 = v927 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v928 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v919 = v928 
            #endif
#else
            let v929 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v919 = v929 
            #endif
            let v930 : System.DateTime = _run_target_args'_v919 
            v930
        | US2_0(v808) -> (* Some *)
            (* run_target_args'
            let v815 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v816 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v815 = v816 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v817 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v815 = v817 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v819 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v815 = v819 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v822 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v815 = v822 
            #endif
#if FABLE_COMPILER_PYTHON
            let v823 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v815 = v823 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v824 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v815 = v824 
            #endif
#else
            let v825 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v815 = v825 
            #endif
            let v826 : System.DateTime = _run_target_args'_v815 
            (* run_target_args'
            let v837 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v838 : (System.DateTime -> int64) = _.Ticks
            let v839 : int64 = v838 v826
            let _run_target_args'_v837 = v839 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v840 : (System.DateTime -> int64) = _.Ticks
            let v841 : int64 = v840 v826
            let _run_target_args'_v837 = v841 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v843 : int64 = null |> unbox<int64>
            let _run_target_args'_v837 = v843 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v846 : (System.DateTime -> int64) = _.Ticks
            let v847 : int64 = v846 v826
            let _run_target_args'_v837 = v847 
            #endif
#if FABLE_COMPILER_PYTHON
            let v848 : (System.DateTime -> int64) = _.Ticks
            let v849 : int64 = v848 v826
            let _run_target_args'_v837 = v849 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v850 : (System.DateTime -> int64) = _.Ticks
            let v851 : int64 = v850 v826
            let _run_target_args'_v837 = v851 
            #endif
#else
            let v852 : (System.DateTime -> int64) = _.Ticks
            let v853 : int64 = v852 v826
            let _run_target_args'_v837 = v853 
            #endif
            let v854 : int64 = _run_target_args'_v837 
            let v875 : int64 = v854 |> int64 
            let v878 : int64 = v875 - v808
            let v884 : System.TimeSpan = v878 |> System.TimeSpan 
            let v890 : (System.TimeSpan -> int32) = _.Hours
            let v891 : int32 = v890 v884
            let v895 : (System.TimeSpan -> int32) = _.Minutes
            let v896 : int32 = v895 v884
            let v900 : (System.TimeSpan -> int32) = _.Seconds
            let v901 : int32 = v900 v884
            let v905 : (System.TimeSpan -> int32) = _.Milliseconds
            let v906 : int32 = v905 v884
            let v910 : System.DateTime = System.DateTime (1, 1, 1, v891, v896, v901, v906)
            v910
    let v938 : string = method10()
    let v942 : bool = v938 = ""
    let v944 : string =
        if v942 then
            let v943 : string = "M-d-y hh:mm:ss tt"
            v943
        else
            v938
    let v945 : (string -> string) = v936.ToString
    let v946 : string = v945 v944
    let _run_target_args'_v187 = v946 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v963 : (int64 -> US2) = method8()
    let v964 : US2 option = v5 |> Option.map v963 
    let v984 : US2 = US2_1
    let v985 : US2 = v964 |> Option.defaultValue v984 
    let v1117 : System.DateTime =
        match v985 with
        | US2_1 -> (* None *)
            (* run_target_args'
            let v1100 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1101 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1100 = v1101 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1102 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1100 = v1102 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1104 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v1100 = v1104 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1107 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1100 = v1107 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1108 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1100 = v1108 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1109 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1100 = v1109 
            #endif
#else
            let v1110 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1100 = v1110 
            #endif
            let v1111 : System.DateTime = _run_target_args'_v1100 
            v1111
        | US2_0(v989) -> (* Some *)
            (* run_target_args'
            let v996 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v997 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v996 = v997 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v998 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v996 = v998 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1000 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v996 = v1000 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1003 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v996 = v1003 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1004 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v996 = v1004 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1005 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v996 = v1005 
            #endif
#else
            let v1006 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v996 = v1006 
            #endif
            let v1007 : System.DateTime = _run_target_args'_v996 
            (* run_target_args'
            let v1018 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1019 : (System.DateTime -> int64) = _.Ticks
            let v1020 : int64 = v1019 v1007
            let _run_target_args'_v1018 = v1020 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1021 : (System.DateTime -> int64) = _.Ticks
            let v1022 : int64 = v1021 v1007
            let _run_target_args'_v1018 = v1022 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1024 : int64 = null |> unbox<int64>
            let _run_target_args'_v1018 = v1024 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1027 : (System.DateTime -> int64) = _.Ticks
            let v1028 : int64 = v1027 v1007
            let _run_target_args'_v1018 = v1028 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1029 : (System.DateTime -> int64) = _.Ticks
            let v1030 : int64 = v1029 v1007
            let _run_target_args'_v1018 = v1030 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1031 : (System.DateTime -> int64) = _.Ticks
            let v1032 : int64 = v1031 v1007
            let _run_target_args'_v1018 = v1032 
            #endif
#else
            let v1033 : (System.DateTime -> int64) = _.Ticks
            let v1034 : int64 = v1033 v1007
            let _run_target_args'_v1018 = v1034 
            #endif
            let v1035 : int64 = _run_target_args'_v1018 
            let v1056 : int64 = v1035 |> int64 
            let v1059 : int64 = v1056 - v989
            let v1065 : System.TimeSpan = v1059 |> System.TimeSpan 
            let v1071 : (System.TimeSpan -> int32) = _.Hours
            let v1072 : int32 = v1071 v1065
            let v1076 : (System.TimeSpan -> int32) = _.Minutes
            let v1077 : int32 = v1076 v1065
            let v1081 : (System.TimeSpan -> int32) = _.Seconds
            let v1082 : int32 = v1081 v1065
            let v1086 : (System.TimeSpan -> int32) = _.Milliseconds
            let v1087 : int32 = v1086 v1065
            let v1091 : System.DateTime = System.DateTime (1, 1, 1, v1072, v1077, v1082, v1087)
            v1091
    let v1119 : string = method10()
    let v1123 : bool = v1119 = ""
    let v1125 : string =
        if v1123 then
            let v1124 : string = "M-d-y hh:mm:ss tt"
            v1124
        else
            v1119
    let v1126 : (string -> string) = v1117.ToString
    let v1127 : string = v1126 v1125
    let _run_target_args'_v187 = v1127 
    #endif
#else
    let v1144 : (int64 -> US2) = method8()
    let v1145 : US2 option = v5 |> Option.map v1144 
    let v1165 : US2 = US2_1
    let v1166 : US2 = v1145 |> Option.defaultValue v1165 
    let v1298 : System.DateTime =
        match v1166 with
        | US2_1 -> (* None *)
            (* run_target_args'
            let v1281 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1282 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1281 = v1282 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1283 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1281 = v1283 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1285 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v1281 = v1285 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1288 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1281 = v1288 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1289 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1281 = v1289 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1290 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1281 = v1290 
            #endif
#else
            let v1291 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1281 = v1291 
            #endif
            let v1292 : System.DateTime = _run_target_args'_v1281 
            v1292
        | US2_0(v1170) -> (* Some *)
            (* run_target_args'
            let v1177 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1178 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1177 = v1178 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1179 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1177 = v1179 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1181 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v1177 = v1181 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1184 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1177 = v1184 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1185 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1177 = v1185 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1186 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1177 = v1186 
            #endif
#else
            let v1187 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1177 = v1187 
            #endif
            let v1188 : System.DateTime = _run_target_args'_v1177 
            (* run_target_args'
            let v1199 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1200 : (System.DateTime -> int64) = _.Ticks
            let v1201 : int64 = v1200 v1188
            let _run_target_args'_v1199 = v1201 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1202 : (System.DateTime -> int64) = _.Ticks
            let v1203 : int64 = v1202 v1188
            let _run_target_args'_v1199 = v1203 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1205 : int64 = null |> unbox<int64>
            let _run_target_args'_v1199 = v1205 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1208 : (System.DateTime -> int64) = _.Ticks
            let v1209 : int64 = v1208 v1188
            let _run_target_args'_v1199 = v1209 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1210 : (System.DateTime -> int64) = _.Ticks
            let v1211 : int64 = v1210 v1188
            let _run_target_args'_v1199 = v1211 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1212 : (System.DateTime -> int64) = _.Ticks
            let v1213 : int64 = v1212 v1188
            let _run_target_args'_v1199 = v1213 
            #endif
#else
            let v1214 : (System.DateTime -> int64) = _.Ticks
            let v1215 : int64 = v1214 v1188
            let _run_target_args'_v1199 = v1215 
            #endif
            let v1216 : int64 = _run_target_args'_v1199 
            let v1237 : int64 = v1216 |> int64 
            let v1240 : int64 = v1237 - v1170
            let v1246 : System.TimeSpan = v1240 |> System.TimeSpan 
            let v1252 : (System.TimeSpan -> int32) = _.Hours
            let v1253 : int32 = v1252 v1246
            let v1257 : (System.TimeSpan -> int32) = _.Minutes
            let v1258 : int32 = v1257 v1246
            let v1262 : (System.TimeSpan -> int32) = _.Seconds
            let v1263 : int32 = v1262 v1246
            let v1267 : (System.TimeSpan -> int32) = _.Milliseconds
            let v1268 : int32 = v1267 v1246
            let v1272 : System.DateTime = System.DateTime (1, 1, 1, v1253, v1258, v1263, v1268)
            v1272
    let v1300 : string = method10()
    let v1304 : bool = v1300 = ""
    let v1306 : string =
        if v1304 then
            let v1305 : string = "M-d-y hh:mm:ss tt"
            v1305
        else
            v1300
    let v1307 : (string -> string) = v1298.ToString
    let v1308 : string = v1307 v1306
    let _run_target_args'_v187 = v1308 
    #endif
    let v1323 : string = _run_target_args'_v187 
    v1323
and method12 () : string =
    let v0 : string = ""
    v0
and closure7 (v0 : Mut3, v1 : string) () : unit =
    let v2 : string = v0.l0
    let v4 : string = v2 + v1 
    v0.l0 <- v4
    ()
and method13 () : string =
    let v0 : string = "\u001b[0m"
    v0
and method11 () : string =
    
    
    
    
    
    let v2 : string = "Debug"
    let v3 : (unit -> string) = v2.ToLower
    let v4 : string = v3 ()
    let v7 : char = v4.[int 0]
    let v8 : string = method12()
    let v9 : Mut3 = {l0 = v8} : Mut3
    let v14 : string = $"{v7}"
    let v22 : unit = ()
    let v23 : (unit -> unit) = closure7(v9, v14)
    let v24 : unit = (fun () -> v23 (); v22) ()
    let v30 : string = v9.l0
    (* run_target_args'
    let v47 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v48 : string = "inline_colorization::color_bright_blue"
    let v49 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v48 
    (* run_target_args'
    let v54 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v55 : string = "&*$0"
    let v56 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v30 v55 
    let _run_target_args'_v54 = v56 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v57 : string = "&*$0"
    let v58 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v30 v57 
    let _run_target_args'_v54 = v58 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v59 : string = "&*$0"
    let v60 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v30 v59 
    let _run_target_args'_v54 = v60 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v62 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v54 = v62 
    #endif
#if FABLE_COMPILER_PYTHON
    let v66 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v54 = v66 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v70 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v54 = v70 
    #endif
#else
    let v74 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v54 = v74 
    #endif
    let v77 : Ref<Str> = _run_target_args'_v54 
    let v83 : string = "inline_colorization::color_reset"
    let v84 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v83 
    let v85 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v86 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v49, v77, v84) v85 
    let v87 : string = "fable_library_rust::String_::fromString($0)"
    let v88 : string = Fable.Core.RustInterop.emitRustExpr v86 v87 
    let _run_target_args'_v47 = v88 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v89 : string = "inline_colorization::color_bright_blue"
    let v90 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v89 
    (* run_target_args'
    let v95 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v96 : string = "&*$0"
    let v97 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v30 v96 
    let _run_target_args'_v95 = v97 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v98 : string = "&*$0"
    let v99 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v30 v98 
    let _run_target_args'_v95 = v99 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v100 : string = "&*$0"
    let v101 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v30 v100 
    let _run_target_args'_v95 = v101 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v103 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v95 = v103 
    #endif
#if FABLE_COMPILER_PYTHON
    let v107 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v95 = v107 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v111 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v95 = v111 
    #endif
#else
    let v115 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v95 = v115 
    #endif
    let v118 : Ref<Str> = _run_target_args'_v95 
    let v124 : string = "inline_colorization::color_reset"
    let v125 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v124 
    let v126 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v127 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v90, v118, v125) v126 
    let v128 : string = "fable_library_rust::String_::fromString($0)"
    let v129 : string = Fable.Core.RustInterop.emitRustExpr v127 v128 
    let _run_target_args'_v47 = v129 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v130 : string = "inline_colorization::color_bright_blue"
    let v131 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v130 
    (* run_target_args'
    let v136 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v137 : string = "&*$0"
    let v138 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v30 v137 
    let _run_target_args'_v136 = v138 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v139 : string = "&*$0"
    let v140 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v30 v139 
    let _run_target_args'_v136 = v140 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v141 : string = "&*$0"
    let v142 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v30 v141 
    let _run_target_args'_v136 = v142 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v144 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v136 = v144 
    #endif
#if FABLE_COMPILER_PYTHON
    let v148 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v136 = v148 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v152 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v136 = v152 
    #endif
#else
    let v156 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v136 = v156 
    #endif
    let v159 : Ref<Str> = _run_target_args'_v136 
    let v165 : string = "inline_colorization::color_reset"
    let v166 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v165 
    let v167 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v168 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v131, v159, v166) v167 
    let v169 : string = "fable_library_rust::String_::fromString($0)"
    let v170 : string = Fable.Core.RustInterop.emitRustExpr v168 v169 
    let _run_target_args'_v47 = v170 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v172 : string = "\u001b[94m"
    let v176 : string = method13()
    let v180 : string = v172 + v30 
    let v184 : string = v180 + v176 
    let _run_target_args'_v47 = v184 
    #endif
#if FABLE_COMPILER_PYTHON
    let v188 : string = "\u001b[94m"
    let v192 : string = method13()
    let v196 : string = v188 + v30 
    let v200 : string = v196 + v192 
    let _run_target_args'_v47 = v200 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v204 : string = "\u001b[94m"
    let v208 : string = method13()
    let v212 : string = v204 + v30 
    let v216 : string = v212 + v208 
    let _run_target_args'_v47 = v216 
    #endif
#else
    let v220 : string = "\u001b[94m"
    let v224 : string = method13()
    let v228 : string = v220 + v30 
    let v232 : string = v228 + v224 
    let _run_target_args'_v47 = v232 
    #endif
    let v235 : string = _run_target_args'_v47 
    v235
and method15 (v0 : string) : string =
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
and method14 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : std_string_String, v9 : uint64, v10 : std_string_String, v11 : std_string_String) : string =
    let v12 : string = method12()
    let v13 : Mut3 = {l0 = v12} : Mut3
    let v16 : string = "{ "
    let v17 : string = $"{v16}"
    let v25 : unit = ()
    let v26 : (unit -> unit) = closure7(v13, v17)
    let v27 : unit = (fun () -> v26 (); v25) ()
    let v35 : string = "alias"
    let v36 : string = $"{v35}"
    let v44 : unit = ()
    let v45 : (unit -> unit) = closure7(v13, v36)
    let v46 : unit = (fun () -> v45 (); v44) ()
    let v54 : string = " = "
    let v55 : string = $"{v54}"
    let v63 : unit = ()
    let v64 : (unit -> unit) = closure7(v13, v55)
    let v65 : unit = (fun () -> v64 (); v63) ()
    (* run_target_args'
    let v75 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v76 : string = "format!(\"{:#?}\", $0)"
    let v77 : std_string_String = Fable.Core.RustInterop.emitRustExpr v8 v76 
    let v78 : string = "fable_library_rust::String_::fromString($0)"
    let v79 : string = Fable.Core.RustInterop.emitRustExpr v77 v78 
    let _run_target_args'_v75 = v79 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v80 : string = "format!(\"{:#?}\", $0)"
    let v81 : std_string_String = Fable.Core.RustInterop.emitRustExpr v8 v80 
    let v82 : string = "fable_library_rust::String_::fromString($0)"
    let v83 : string = Fable.Core.RustInterop.emitRustExpr v81 v82 
    let _run_target_args'_v75 = v83 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v84 : string = "format!(\"{:#?}\", $0)"
    let v85 : std_string_String = Fable.Core.RustInterop.emitRustExpr v8 v84 
    let v86 : string = "fable_library_rust::String_::fromString($0)"
    let v87 : string = Fable.Core.RustInterop.emitRustExpr v85 v86 
    let _run_target_args'_v75 = v87 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v89 : string = $"%A{v8}"
    let _run_target_args'_v75 = v89 
    #endif
#if FABLE_COMPILER_PYTHON
    let v93 : string = $"%A{v8}"
    let _run_target_args'_v75 = v93 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v97 : string = $"%A{v8}"
    let _run_target_args'_v75 = v97 
    #endif
#else
    let v101 : string = $"%A{v8}"
    let _run_target_args'_v75 = v101 
    #endif
    let v104 : string = _run_target_args'_v75 
    let v111 : string = $"{v104}"
    let v119 : unit = ()
    let v120 : (unit -> unit) = closure7(v13, v111)
    let v121 : unit = (fun () -> v120 (); v119) ()
    let v129 : string = "; "
    let v130 : string = $"{v129}"
    let v138 : unit = ()
    let v139 : (unit -> unit) = closure7(v13, v130)
    let v140 : unit = (fun () -> v139 (); v138) ()
    let v148 : string = "block_timestamp"
    let v149 : string = $"{v148}"
    let v157 : unit = ()
    let v158 : (unit -> unit) = closure7(v13, v149)
    let v159 : unit = (fun () -> v158 (); v157) ()
    let v166 : string = $"{v54}"
    let v174 : unit = ()
    let v175 : (unit -> unit) = closure7(v13, v166)
    let v176 : unit = (fun () -> v175 (); v174) ()
    let v186 : string = $"{v9}"
    let v194 : unit = ()
    let v195 : (unit -> unit) = closure7(v13, v186)
    let v196 : unit = (fun () -> v195 (); v194) ()
    let v203 : string = $"{v129}"
    let v211 : unit = ()
    let v212 : (unit -> unit) = closure7(v13, v203)
    let v213 : unit = (fun () -> v212 (); v211) ()
    let v221 : string = "signer_account_id"
    let v222 : string = $"{v221}"
    let v230 : unit = ()
    let v231 : (unit -> unit) = closure7(v13, v222)
    let v232 : unit = (fun () -> v231 (); v230) ()
    let v239 : string = $"{v54}"
    let v247 : unit = ()
    let v248 : (unit -> unit) = closure7(v13, v239)
    let v249 : unit = (fun () -> v248 (); v247) ()
    (* run_target_args'
    let v259 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v260 : string = "format!(\"{:#?}\", $0)"
    let v261 : std_string_String = Fable.Core.RustInterop.emitRustExpr v10 v260 
    let v262 : string = "fable_library_rust::String_::fromString($0)"
    let v263 : string = Fable.Core.RustInterop.emitRustExpr v261 v262 
    let _run_target_args'_v259 = v263 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v264 : string = "format!(\"{:#?}\", $0)"
    let v265 : std_string_String = Fable.Core.RustInterop.emitRustExpr v10 v264 
    let v266 : string = "fable_library_rust::String_::fromString($0)"
    let v267 : string = Fable.Core.RustInterop.emitRustExpr v265 v266 
    let _run_target_args'_v259 = v267 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v268 : string = "format!(\"{:#?}\", $0)"
    let v269 : std_string_String = Fable.Core.RustInterop.emitRustExpr v10 v268 
    let v270 : string = "fable_library_rust::String_::fromString($0)"
    let v271 : string = Fable.Core.RustInterop.emitRustExpr v269 v270 
    let _run_target_args'_v259 = v271 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v273 : string = $"%A{v10}"
    let _run_target_args'_v259 = v273 
    #endif
#if FABLE_COMPILER_PYTHON
    let v277 : string = $"%A{v10}"
    let _run_target_args'_v259 = v277 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v281 : string = $"%A{v10}"
    let _run_target_args'_v259 = v281 
    #endif
#else
    let v285 : string = $"%A{v10}"
    let _run_target_args'_v259 = v285 
    #endif
    let v288 : string = _run_target_args'_v259 
    let v295 : string = $"{v288}"
    let v303 : unit = ()
    let v304 : (unit -> unit) = closure7(v13, v295)
    let v305 : unit = (fun () -> v304 (); v303) ()
    let v312 : string = $"{v129}"
    let v320 : unit = ()
    let v321 : (unit -> unit) = closure7(v13, v312)
    let v322 : unit = (fun () -> v321 (); v320) ()
    let v330 : string = "predecessor_account_id"
    let v331 : string = $"{v330}"
    let v339 : unit = ()
    let v340 : (unit -> unit) = closure7(v13, v331)
    let v341 : unit = (fun () -> v340 (); v339) ()
    let v348 : string = $"{v54}"
    let v356 : unit = ()
    let v357 : (unit -> unit) = closure7(v13, v348)
    let v358 : unit = (fun () -> v357 (); v356) ()
    (* run_target_args'
    let v368 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v369 : string = "format!(\"{:#?}\", $0)"
    let v370 : std_string_String = Fable.Core.RustInterop.emitRustExpr v11 v369 
    let v371 : string = "fable_library_rust::String_::fromString($0)"
    let v372 : string = Fable.Core.RustInterop.emitRustExpr v370 v371 
    let _run_target_args'_v368 = v372 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v373 : string = "format!(\"{:#?}\", $0)"
    let v374 : std_string_String = Fable.Core.RustInterop.emitRustExpr v11 v373 
    let v375 : string = "fable_library_rust::String_::fromString($0)"
    let v376 : string = Fable.Core.RustInterop.emitRustExpr v374 v375 
    let _run_target_args'_v368 = v376 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v377 : string = "format!(\"{:#?}\", $0)"
    let v378 : std_string_String = Fable.Core.RustInterop.emitRustExpr v11 v377 
    let v379 : string = "fable_library_rust::String_::fromString($0)"
    let v380 : string = Fable.Core.RustInterop.emitRustExpr v378 v379 
    let _run_target_args'_v368 = v380 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v382 : string = $"%A{v11}"
    let _run_target_args'_v368 = v382 
    #endif
#if FABLE_COMPILER_PYTHON
    let v386 : string = $"%A{v11}"
    let _run_target_args'_v368 = v386 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v390 : string = $"%A{v11}"
    let _run_target_args'_v368 = v390 
    #endif
#else
    let v394 : string = $"%A{v11}"
    let _run_target_args'_v368 = v394 
    #endif
    let v397 : string = _run_target_args'_v368 
    let v404 : string = $"{v397}"
    let v412 : unit = ()
    let v413 : (unit -> unit) = closure7(v13, v404)
    let v414 : unit = (fun () -> v413 (); v412) ()
    let v422 : string = " }"
    let v423 : string = $"{v422}"
    let v431 : unit = ()
    let v432 : (unit -> unit) = closure7(v13, v423)
    let v433 : unit = (fun () -> v432 (); v431) ()
    let v439 : string = v13.l0
    let v440 : int64 = v0.l0
    let v443 : string = " "
    let v444 : string = v6 + v443 
    let v448 : string = v444 + v7 
    let v453 : string = " #"
    let v454 : string = v448 + v453 
    let v458 : (int64 -> string) = _.ToString()
    let v459 : string = v458 v440
    let v463 : string = v454 + v459 
    let v467 : string = v463 + v443 
    let v472 : string = "chat_contract.claim_alias"
    let v473 : string = v467 + v472 
    let v478 : string = " / "
    let v479 : string = v473 + v478 
    let v483 : string = v479 + v439 
    method15(v483)
and closure8 (v0 : Mut0) () : unit =
    let v1 : int64 = v0.l0
    let v2 : int64 = v1 + 1L
    v0.l0 <- v2
    ()
and closure10 (v0 : string) () : unit =
    let v1 : (string -> unit) = System.Console.WriteLine
    v1 v0
and closure9 () (v0 : string) : unit =
    let v2 : unit = ()
    let v3 : (unit -> unit) = closure10(v0)
    let v4 : unit = (fun () -> v3 (); v2) ()
    ()
and method16 (v0 : string) : unit =
    let v15 : unit = ()
    let v16 : (unit -> unit) = closure3()
    let v17 : unit = (fun () -> v16 (); v15) ()
    let struct (v38 : Mut0, v39 : Mut1, v40 : Mut2, v41 : Mut3, v42 : Mut4, v43 : int64 option) = TraceState.trace_state.Value
    let v58 : unit = ()
    let v59 : (unit -> unit) = closure8(v38)
    let v60 : unit = (fun () -> v59 (); v58) ()
    let v63 : (string -> unit) = closure9()
    (* run_target_args'
    let v64 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v65 : string = @"println!(""{}"", $0)"
    Fable.Core.RustInterop.emitRustExpr v0 v65 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v66 : string = @"println!(""{}"", $0)"
    Fable.Core.RustInterop.emitRustExpr v0 v66 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v67 : string = v41.l0
    let v68 : bool = v67 = ""
    let v83 : string =
        if v68 then
            v0
        else
            let v69 : bool = v0 = ""
            if v69 then
                let v70 : string = v41.l0
                v70
            else
                let v71 : string = v41.l0
                let v74 : string = "\n"
                let v75 : string = v71 + v74 
                let v79 : string = v75 + v0 
                v79
    (* run_target_args'
    let v88 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v89 : string = "&*$0"
    let v90 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v83 v89 
    let _run_target_args'_v88 = v90 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v91 : string = "&*$0"
    let v92 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v83 v91 
    let _run_target_args'_v88 = v92 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v93 : string = "&*$0"
    let v94 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v83 v93 
    let _run_target_args'_v88 = v94 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v96 : Ref<Str> = v83 |> unbox<Ref<Str>>
    let _run_target_args'_v88 = v96 
    #endif
#if FABLE_COMPILER_PYTHON
    let v100 : Ref<Str> = v83 |> unbox<Ref<Str>>
    let _run_target_args'_v88 = v100 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v104 : Ref<Str> = v83 |> unbox<Ref<Str>>
    let _run_target_args'_v88 = v104 
    #endif
#else
    let v108 : Ref<Str> = v83 |> unbox<Ref<Str>>
    let _run_target_args'_v88 = v108 
    #endif
    let v111 : Ref<Str> = _run_target_args'_v88 
    let v117 : string = $"$0.chars()"
    let v118 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v111 v117 
    let v119 : string = "$0"
    let v120 : _ = Fable.Core.RustInterop.emitRustExpr v118 v119 
    let v121 : string = "$0.collect::<Vec<_>>()"
    let v122 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v120 v121 
    let v123 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
    let v124 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v122 v123 
    let v125 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
    let v126 : bool = Fable.Core.RustInterop.emitRustExpr v124 v125 
    let v127 : string = "x"
    let v128 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v127 
    let v129 : string = "String::from_iter($0)"
    let v130 : std_string_String = Fable.Core.RustInterop.emitRustExpr v128 v129 
    let v131 : string = "true; $0 }).collect::<Vec<_>>()"
    let v132 : bool = Fable.Core.RustInterop.emitRustExpr v130 v131 
    let v133 : string = "_vec_map"
    let v134 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v133 
    let v135 : string = "$0.len()"
    let v136 : unativeint = Fable.Core.RustInterop.emitRustExpr v134 v135 
    let v142 : int32 = v136 |> int32 
    let v152 : string = ""
    let v153 : bool = v0 <> v152 
    let v157 : bool =
        if v153 then
            let v156 : bool = v142 <= 1
            v156
        else
            false
    if v157 then
        v41.l0 <- v83
        ()
    else
        v41.l0 <- v152
        let v158 : string = "true; $0.into_iter().for_each(|x| { //"
        let v159 : bool = Fable.Core.RustInterop.emitRustExpr v134 v158 
        let v160 : string = "x"
        let v161 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v160 
        let v162 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
        let v163 : bool = Fable.Core.RustInterop.emitRustExpr v161 v162 
        let v164 : string = $"true"
        let v165 : bool = Fable.Core.RustInterop.emitRustExpr () v164 
        let v166 : string = "true; }); //"
        let v167 : bool = Fable.Core.RustInterop.emitRustExpr () v166 
        ()
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    v63 v0
    #endif
#if FABLE_COMPILER_PYTHON
    v63 v0
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    v63 v0
    #endif
#else
    v63 v0
    #endif
    // run_target_args' is_unit
    let v168 : (string -> unit) = v39.l0
    v168 v0
and closure2 (v0 : std_string_String, v1 : near_sdk_AccountId, v2 : near_sdk_AccountId, v3 : uint64) () : unit =
    let v4 : US0 = US0_1
    let v5 : bool = method0(v4)
    if v5 then
        let v20 : unit = ()
        let v21 : (unit -> unit) = closure3()
        let v22 : unit = (fun () -> v21 (); v20) ()
        let struct (v43 : Mut0, v44 : Mut1, v45 : Mut2, v46 : Mut3, v47 : Mut4, v48 : int64 option) = TraceState.trace_state.Value
        let v61 : string = method7(v43, v44, v45, v46, v47, v48)
        let v62 : string = method11()
        let v63 : string = $"v1.to_string()"
        let v64 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v63 
        let v65 : string = $"v2.to_string()"
        let v66 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v65 
        let v67 : string = method14(v43, v44, v45, v46, v47, v48, v61, v62, v0, v3, v64, v66)
        method16(v67)
and closure11 () (v0 : std_string_String) : US6 =
    US6_0(v0)
and method17 () : (std_string_String -> US6) =
    closure11()
and method18 () : string =
    
    
    
    
    
    let v2 : string = "Warning"
    let v3 : (unit -> string) = v2.ToLower
    let v4 : string = v3 ()
    let v7 : char = v4.[int 0]
    let v8 : string = method12()
    let v9 : Mut3 = {l0 = v8} : Mut3
    let v14 : string = $"{v7}"
    let v22 : unit = ()
    let v23 : (unit -> unit) = closure7(v9, v14)
    let v24 : unit = (fun () -> v23 (); v22) ()
    let v30 : string = v9.l0
    (* run_target_args'
    let v47 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v48 : string = "inline_colorization::color_yellow"
    let v49 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v48 
    (* run_target_args'
    let v54 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v55 : string = "&*$0"
    let v56 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v30 v55 
    let _run_target_args'_v54 = v56 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v57 : string = "&*$0"
    let v58 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v30 v57 
    let _run_target_args'_v54 = v58 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v59 : string = "&*$0"
    let v60 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v30 v59 
    let _run_target_args'_v54 = v60 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v62 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v54 = v62 
    #endif
#if FABLE_COMPILER_PYTHON
    let v66 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v54 = v66 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v70 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v54 = v70 
    #endif
#else
    let v74 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v54 = v74 
    #endif
    let v77 : Ref<Str> = _run_target_args'_v54 
    let v83 : string = "inline_colorization::color_reset"
    let v84 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v83 
    let v85 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v86 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v49, v77, v84) v85 
    let v87 : string = "fable_library_rust::String_::fromString($0)"
    let v88 : string = Fable.Core.RustInterop.emitRustExpr v86 v87 
    let _run_target_args'_v47 = v88 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v89 : string = "inline_colorization::color_yellow"
    let v90 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v89 
    (* run_target_args'
    let v95 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v96 : string = "&*$0"
    let v97 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v30 v96 
    let _run_target_args'_v95 = v97 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v98 : string = "&*$0"
    let v99 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v30 v98 
    let _run_target_args'_v95 = v99 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v100 : string = "&*$0"
    let v101 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v30 v100 
    let _run_target_args'_v95 = v101 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v103 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v95 = v103 
    #endif
#if FABLE_COMPILER_PYTHON
    let v107 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v95 = v107 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v111 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v95 = v111 
    #endif
#else
    let v115 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v95 = v115 
    #endif
    let v118 : Ref<Str> = _run_target_args'_v95 
    let v124 : string = "inline_colorization::color_reset"
    let v125 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v124 
    let v126 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v127 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v90, v118, v125) v126 
    let v128 : string = "fable_library_rust::String_::fromString($0)"
    let v129 : string = Fable.Core.RustInterop.emitRustExpr v127 v128 
    let _run_target_args'_v47 = v129 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v130 : string = "inline_colorization::color_yellow"
    let v131 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v130 
    (* run_target_args'
    let v136 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v137 : string = "&*$0"
    let v138 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v30 v137 
    let _run_target_args'_v136 = v138 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v139 : string = "&*$0"
    let v140 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v30 v139 
    let _run_target_args'_v136 = v140 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v141 : string = "&*$0"
    let v142 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v30 v141 
    let _run_target_args'_v136 = v142 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v144 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v136 = v144 
    #endif
#if FABLE_COMPILER_PYTHON
    let v148 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v136 = v148 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v152 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v136 = v152 
    #endif
#else
    let v156 : Ref<Str> = v30 |> unbox<Ref<Str>>
    let _run_target_args'_v136 = v156 
    #endif
    let v159 : Ref<Str> = _run_target_args'_v136 
    let v165 : string = "inline_colorization::color_reset"
    let v166 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v165 
    let v167 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v168 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v131, v159, v166) v167 
    let v169 : string = "fable_library_rust::String_::fromString($0)"
    let v170 : string = Fable.Core.RustInterop.emitRustExpr v168 v169 
    let _run_target_args'_v47 = v170 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v172 : string = "\u001b[93m"
    let v176 : string = method13()
    let v180 : string = v172 + v30 
    let v184 : string = v180 + v176 
    let _run_target_args'_v47 = v184 
    #endif
#if FABLE_COMPILER_PYTHON
    let v188 : string = "\u001b[93m"
    let v192 : string = method13()
    let v196 : string = v188 + v30 
    let v200 : string = v196 + v192 
    let _run_target_args'_v47 = v200 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v204 : string = "\u001b[93m"
    let v208 : string = method13()
    let v212 : string = v204 + v30 
    let v216 : string = v212 + v208 
    let _run_target_args'_v47 = v216 
    #endif
#else
    let v220 : string = "\u001b[93m"
    let v224 : string = method13()
    let v228 : string = v220 + v30 
    let v232 : string = v228 + v224 
    let _run_target_args'_v47 = v232 
    #endif
    let v235 : string = _run_target_args'_v47 
    v235
and method19 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : string) : string =
    let v9 : string = method12()
    let v10 : Mut3 = {l0 = v9} : Mut3
    let v13 : string = "{ "
    let v14 : string = $"{v13}"
    let v22 : unit = ()
    let v23 : (unit -> unit) = closure7(v10, v14)
    let v24 : unit = (fun () -> v23 (); v22) ()
    let v32 : string = "account_alias"
    let v33 : string = $"{v32}"
    let v41 : unit = ()
    let v42 : (unit -> unit) = closure7(v10, v33)
    let v43 : unit = (fun () -> v42 (); v41) ()
    let v51 : string = " = "
    let v52 : string = $"{v51}"
    let v60 : unit = ()
    let v61 : (unit -> unit) = closure7(v10, v52)
    let v62 : unit = (fun () -> v61 (); v60) ()
    let v69 : string = $"{v8}"
    let v77 : unit = ()
    let v78 : (unit -> unit) = closure7(v10, v69)
    let v79 : unit = (fun () -> v78 (); v77) ()
    let v87 : string = " }"
    let v88 : string = $"{v87}"
    let v96 : unit = ()
    let v97 : (unit -> unit) = closure7(v10, v88)
    let v98 : unit = (fun () -> v97 (); v96) ()
    let v104 : string = v10.l0
    let v105 : int64 = v0.l0
    let v108 : string = " "
    let v109 : string = v6 + v108 
    let v113 : string = v109 + v7 
    let v118 : string = " #"
    let v119 : string = v113 + v118 
    let v123 : (int64 -> string) = _.ToString()
    let v124 : string = v123 v105
    let v128 : string = v119 + v124 
    let v132 : string = v128 + v108 
    let v137 : string = "chat_contract.claim_alias / alias already claimed"
    let v138 : string = v132 + v137 
    let v143 : string = " / "
    let v144 : string = v138 + v143 
    let v148 : string = v144 + v104 
    method15(v148)
and closure12 (v0 : std_string_String) () : unit =
    let v1 : US0 = US0_3
    let v2 : bool = method0(v1)
    if v2 then
        let v17 : unit = ()
        let v18 : (unit -> unit) = closure3()
        let v19 : unit = (fun () -> v18 (); v17) ()
        let struct (v40 : Mut0, v41 : Mut1, v42 : Mut2, v43 : Mut3, v44 : Mut4, v45 : int64 option) = TraceState.trace_state.Value
        let v58 : string = method7(v40, v41, v42, v43, v44, v45)
        let v59 : string = method18()
        let v61 : string = $"%A{v0}"
        let v64 : string = method19(v40, v41, v42, v43, v44, v45, v58, v59, v61)
        method16(v64)
and method20 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : string) : string =
    let v9 : string = method12()
    let v10 : Mut3 = {l0 = v9} : Mut3
    let v13 : string = "{ "
    let v14 : string = $"{v13}"
    let v22 : unit = ()
    let v23 : (unit -> unit) = closure7(v10, v14)
    let v24 : unit = (fun () -> v23 (); v22) ()
    let v32 : string = "account_alias"
    let v33 : string = $"{v32}"
    let v41 : unit = ()
    let v42 : (unit -> unit) = closure7(v10, v33)
    let v43 : unit = (fun () -> v42 (); v41) ()
    let v51 : string = " = "
    let v52 : string = $"{v51}"
    let v60 : unit = ()
    let v61 : (unit -> unit) = closure7(v10, v52)
    let v62 : unit = (fun () -> v61 (); v60) ()
    let v69 : string = $"{v8}"
    let v77 : unit = ()
    let v78 : (unit -> unit) = closure7(v10, v69)
    let v79 : unit = (fun () -> v78 (); v77) ()
    let v87 : string = " }"
    let v88 : string = $"{v87}"
    let v96 : unit = ()
    let v97 : (unit -> unit) = closure7(v10, v88)
    let v98 : unit = (fun () -> v97 (); v96) ()
    let v104 : string = v10.l0
    let v105 : int64 = v0.l0
    let v108 : string = " "
    let v109 : string = v6 + v108 
    let v113 : string = v109 + v7 
    let v118 : string = " #"
    let v119 : string = v113 + v118 
    let v123 : (int64 -> string) = _.ToString()
    let v124 : string = v123 v105
    let v128 : string = v119 + v124 
    let v132 : string = v128 + v108 
    let v137 : string = "chat_contract.claim_alias"
    let v138 : string = v132 + v137 
    let v143 : string = " / "
    let v144 : string = v138 + v143 
    let v148 : string = v144 + v104 
    method15(v148)
and closure13 (v0 : std_string_String option) () : unit =
    let v1 : US0 = US0_1
    let v2 : bool = method0(v1)
    if v2 then
        let v17 : unit = ()
        let v18 : (unit -> unit) = closure3()
        let v19 : unit = (fun () -> v18 (); v17) ()
        let struct (v40 : Mut0, v41 : Mut1, v42 : Mut2, v43 : Mut3, v44 : Mut4, v45 : int64 option) = TraceState.trace_state.Value
        let v58 : string = method7(v40, v41, v42, v43, v44, v45)
        let v59 : string = method11()
        let v61 : string = $"%A{v0}"
        let v64 : string = method20(v40, v41, v42, v43, v44, v45, v58, v59, v61)
        method16(v64)
and closure14 () () : unit =
    ()
and method21 () : (unit -> unit) =
    closure14()
and method22 () : unit =
    let v14 : unit = ()
    let v15 : (unit -> unit) = closure3()
    let v16 : unit = (fun () -> v15 (); v14) ()
    let struct (v37 : Mut0, v38 : Mut1, v39 : Mut2, v40 : Mut3, v41 : Mut4, v42 : int64 option) = TraceState.trace_state.Value
    let v57 : unit = ()
    let v58 : (unit -> unit) = closure8(v37)
    let v59 : unit = (fun () -> v58 (); v57) ()
    let v62 : string = ""
    let v63 : (string -> unit) = closure9()
    (* run_target_args'
    let v64 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v65 : string = @"println!(""{}"", $0)"
    Fable.Core.RustInterop.emitRustExpr v62 v65 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v66 : string = @"println!(""{}"", $0)"
    Fable.Core.RustInterop.emitRustExpr v62 v66 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v67 : string = v40.l0
    let v68 : bool = v67 = ""
    let v83 : string =
        if v68 then
            v62
        else
            let v69 : bool = v62 = ""
            if v69 then
                let v70 : string = v40.l0
                v70
            else
                let v71 : string = v40.l0
                let v74 : string = "\n"
                let v75 : string = v71 + v74 
                let v79 : string = v75 + v62 
                v79
    (* run_target_args'
    let v88 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v89 : string = "&*$0"
    let v90 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v83 v89 
    let _run_target_args'_v88 = v90 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v91 : string = "&*$0"
    let v92 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v83 v91 
    let _run_target_args'_v88 = v92 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v93 : string = "&*$0"
    let v94 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v83 v93 
    let _run_target_args'_v88 = v94 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v96 : Ref<Str> = v83 |> unbox<Ref<Str>>
    let _run_target_args'_v88 = v96 
    #endif
#if FABLE_COMPILER_PYTHON
    let v100 : Ref<Str> = v83 |> unbox<Ref<Str>>
    let _run_target_args'_v88 = v100 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v104 : Ref<Str> = v83 |> unbox<Ref<Str>>
    let _run_target_args'_v88 = v104 
    #endif
#else
    let v108 : Ref<Str> = v83 |> unbox<Ref<Str>>
    let _run_target_args'_v88 = v108 
    #endif
    let v111 : Ref<Str> = _run_target_args'_v88 
    let v117 : string = $"$0.chars()"
    let v118 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v111 v117 
    let v119 : string = "$0"
    let v120 : _ = Fable.Core.RustInterop.emitRustExpr v118 v119 
    let v121 : string = "$0.collect::<Vec<_>>()"
    let v122 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v120 v121 
    let v123 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
    let v124 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v122 v123 
    let v125 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
    let v126 : bool = Fable.Core.RustInterop.emitRustExpr v124 v125 
    let v127 : string = "x"
    let v128 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v127 
    let v129 : string = "String::from_iter($0)"
    let v130 : std_string_String = Fable.Core.RustInterop.emitRustExpr v128 v129 
    let v131 : string = "true; $0 }).collect::<Vec<_>>()"
    let v132 : bool = Fable.Core.RustInterop.emitRustExpr v130 v131 
    let v133 : string = "_vec_map"
    let v134 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v133 
    let v135 : string = "$0.len()"
    let v136 : unativeint = Fable.Core.RustInterop.emitRustExpr v134 v135 
    let v142 : int32 = v136 |> int32 
    let v151 : bool = v62 <> v62 
    let v155 : bool =
        if v151 then
            let v154 : bool = v142 <= 1
            v154
        else
            false
    if v155 then
        v40.l0 <- v83
        ()
    else
        v40.l0 <- v62
        let v156 : string = "true; $0.into_iter().for_each(|x| { //"
        let v157 : bool = Fable.Core.RustInterop.emitRustExpr v134 v156 
        let v158 : string = "x"
        let v159 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v158 
        let v160 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
        let v161 : bool = Fable.Core.RustInterop.emitRustExpr v159 v160 
        let v162 : string = $"true"
        let v163 : bool = Fable.Core.RustInterop.emitRustExpr () v162 
        let v164 : string = "true; }); //"
        let v165 : bool = Fable.Core.RustInterop.emitRustExpr () v164 
        ()
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    v63 v62
    #endif
#if FABLE_COMPILER_PYTHON
    v63 v62
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    v63 v62
    #endif
#else
    v63 v62
    #endif
    // run_target_args' is_unit
    let v166 : (string -> unit) = v38.l0
    v166 v62
and closure15 (v0 : (unit -> unit)) () : unit =
    let v1 : US0 = US0_1
    let v2 : bool = method0(v1)
    if v2 then
        let v17 : unit = ()
        let v18 : (unit -> unit) = closure3()
        let v19 : unit = (fun () -> v18 (); v17) ()
        let struct (v40 : Mut0, v41 : Mut1, v42 : Mut2, v43 : Mut3, v44 : Mut4, v45 : int64 option) = TraceState.trace_state.Value
        let v58 : string = method7(v40, v41, v42, v43, v44, v45)
        let v59 : string = method11()
        method22()
and method23 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : near_sdk_AccountId, v9 : struct (std_string_String * uint64 * uint32) option) : string =
    let v10 : string = method12()
    let v11 : Mut3 = {l0 = v10} : Mut3
    let v14 : string = "{ "
    let v15 : string = $"{v14}"
    let v23 : unit = ()
    let v24 : (unit -> unit) = closure7(v11, v15)
    let v25 : unit = (fun () -> v24 (); v23) ()
    let v33 : string = "account_id"
    let v34 : string = $"{v33}"
    let v42 : unit = ()
    let v43 : (unit -> unit) = closure7(v11, v34)
    let v44 : unit = (fun () -> v43 (); v42) ()
    let v52 : string = " = "
    let v53 : string = $"{v52}"
    let v61 : unit = ()
    let v62 : (unit -> unit) = closure7(v11, v53)
    let v63 : unit = (fun () -> v62 (); v61) ()
    (* run_target_args'
    let v73 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v74 : string = "format!(\"{:#?}\", $0)"
    let v75 : std_string_String = Fable.Core.RustInterop.emitRustExpr v8 v74 
    let v76 : string = "fable_library_rust::String_::fromString($0)"
    let v77 : string = Fable.Core.RustInterop.emitRustExpr v75 v76 
    let _run_target_args'_v73 = v77 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v78 : string = "format!(\"{:#?}\", $0)"
    let v79 : std_string_String = Fable.Core.RustInterop.emitRustExpr v8 v78 
    let v80 : string = "fable_library_rust::String_::fromString($0)"
    let v81 : string = Fable.Core.RustInterop.emitRustExpr v79 v80 
    let _run_target_args'_v73 = v81 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v82 : string = "format!(\"{:#?}\", $0)"
    let v83 : std_string_String = Fable.Core.RustInterop.emitRustExpr v8 v82 
    let v84 : string = "fable_library_rust::String_::fromString($0)"
    let v85 : string = Fable.Core.RustInterop.emitRustExpr v83 v84 
    let _run_target_args'_v73 = v85 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v87 : string = $"%A{v8}"
    let _run_target_args'_v73 = v87 
    #endif
#if FABLE_COMPILER_PYTHON
    let v91 : string = $"%A{v8}"
    let _run_target_args'_v73 = v91 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v95 : string = $"%A{v8}"
    let _run_target_args'_v73 = v95 
    #endif
#else
    let v99 : string = $"%A{v8}"
    let _run_target_args'_v73 = v99 
    #endif
    let v102 : string = _run_target_args'_v73 
    let v109 : string = $"{v102}"
    let v117 : unit = ()
    let v118 : (unit -> unit) = closure7(v11, v109)
    let v119 : unit = (fun () -> v118 (); v117) ()
    let v127 : string = "; "
    let v128 : string = $"{v127}"
    let v136 : unit = ()
    let v137 : (unit -> unit) = closure7(v11, v128)
    let v138 : unit = (fun () -> v137 (); v136) ()
    let v146 : string = "result"
    let v147 : string = $"{v146}"
    let v155 : unit = ()
    let v156 : (unit -> unit) = closure7(v11, v147)
    let v157 : unit = (fun () -> v156 (); v155) ()
    let v164 : string = $"{v52}"
    let v172 : unit = ()
    let v173 : (unit -> unit) = closure7(v11, v164)
    let v174 : unit = (fun () -> v173 (); v172) ()
    (* run_target_args'
    let v184 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v185 : string = "format!(\"{:#?}\", $0)"
    let v186 : std_string_String = Fable.Core.RustInterop.emitRustExpr v9 v185 
    let v187 : string = "fable_library_rust::String_::fromString($0)"
    let v188 : string = Fable.Core.RustInterop.emitRustExpr v186 v187 
    let _run_target_args'_v184 = v188 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v189 : string = "format!(\"{:#?}\", $0)"
    let v190 : std_string_String = Fable.Core.RustInterop.emitRustExpr v9 v189 
    let v191 : string = "fable_library_rust::String_::fromString($0)"
    let v192 : string = Fable.Core.RustInterop.emitRustExpr v190 v191 
    let _run_target_args'_v184 = v192 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v193 : string = "format!(\"{:#?}\", $0)"
    let v194 : std_string_String = Fable.Core.RustInterop.emitRustExpr v9 v193 
    let v195 : string = "fable_library_rust::String_::fromString($0)"
    let v196 : string = Fable.Core.RustInterop.emitRustExpr v194 v195 
    let _run_target_args'_v184 = v196 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v198 : string = $"%A{v9}"
    let _run_target_args'_v184 = v198 
    #endif
#if FABLE_COMPILER_PYTHON
    let v202 : string = $"%A{v9}"
    let _run_target_args'_v184 = v202 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v206 : string = $"%A{v9}"
    let _run_target_args'_v184 = v206 
    #endif
#else
    let v210 : string = $"%A{v9}"
    let _run_target_args'_v184 = v210 
    #endif
    let v213 : string = _run_target_args'_v184 
    let v220 : string = $"{v213}"
    let v228 : unit = ()
    let v229 : (unit -> unit) = closure7(v11, v220)
    let v230 : unit = (fun () -> v229 (); v228) ()
    let v238 : string = " }"
    let v239 : string = $"{v238}"
    let v247 : unit = ()
    let v248 : (unit -> unit) = closure7(v11, v239)
    let v249 : unit = (fun () -> v248 (); v247) ()
    let v255 : string = v11.l0
    let v256 : int64 = v0.l0
    let v259 : string = " "
    let v260 : string = v6 + v259 
    let v264 : string = v260 + v7 
    let v269 : string = " #"
    let v270 : string = v264 + v269 
    let v274 : (int64 -> string) = _.ToString()
    let v275 : string = v274 v256
    let v279 : string = v270 + v275 
    let v283 : string = v279 + v259 
    let v288 : string = "chat_contract.get_account_info"
    let v289 : string = v283 + v288 
    let v294 : string = " / "
    let v295 : string = v289 + v294 
    let v299 : string = v295 + v255 
    method15(v299)
and closure16 (v0 : near_sdk_AccountId, v1 : struct (std_string_String * uint64 * uint32) option) () : unit =
    let v2 : US0 = US0_1
    let v3 : bool = method0(v2)
    if v3 then
        let v18 : unit = ()
        let v19 : (unit -> unit) = closure3()
        let v20 : unit = (fun () -> v19 (); v18) ()
        let struct (v41 : Mut0, v42 : Mut1, v43 : Mut2, v44 : Mut3, v45 : Mut4, v46 : int64 option) = TraceState.trace_state.Value
        let v59 : string = method7(v41, v42, v43, v44, v45, v46)
        let v60 : string = method11()
        let v61 : string = method23(v41, v42, v43, v44, v45, v46, v59, v60, v0, v1)
        method16(v61)
and closure17 () () : unit =
    let v0 : US0 = US0_1
    let v1 : bool = method0(v0)
    if v1 then
        let v16 : unit = ()
        let v17 : (unit -> unit) = closure3()
        let v18 : unit = (fun () -> v17 (); v16) ()
        let struct (v39 : Mut0, v40 : Mut1, v41 : Mut2, v42 : Mut3, v43 : Mut4, v44 : int64 option) = TraceState.trace_state.Value
        let v57 : string = method7(v39, v40, v41, v42, v43, v44)
        let v58 : string = method11()
        method22()
and method24 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : std_string_String) : string =
    let v9 : string = method12()
    let v10 : Mut3 = {l0 = v9} : Mut3
    let v13 : string = "{ "
    let v14 : string = $"{v13}"
    let v22 : unit = ()
    let v23 : (unit -> unit) = closure7(v10, v14)
    let v24 : unit = (fun () -> v23 (); v22) ()
    let v32 : string = "alias"
    let v33 : string = $"{v32}"
    let v41 : unit = ()
    let v42 : (unit -> unit) = closure7(v10, v33)
    let v43 : unit = (fun () -> v42 (); v41) ()
    let v51 : string = " = "
    let v52 : string = $"{v51}"
    let v60 : unit = ()
    let v61 : (unit -> unit) = closure7(v10, v52)
    let v62 : unit = (fun () -> v61 (); v60) ()
    (* run_target_args'
    let v72 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v73 : string = "format!(\"{:#?}\", $0)"
    let v74 : std_string_String = Fable.Core.RustInterop.emitRustExpr v8 v73 
    let v75 : string = "fable_library_rust::String_::fromString($0)"
    let v76 : string = Fable.Core.RustInterop.emitRustExpr v74 v75 
    let _run_target_args'_v72 = v76 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v77 : string = "format!(\"{:#?}\", $0)"
    let v78 : std_string_String = Fable.Core.RustInterop.emitRustExpr v8 v77 
    let v79 : string = "fable_library_rust::String_::fromString($0)"
    let v80 : string = Fable.Core.RustInterop.emitRustExpr v78 v79 
    let _run_target_args'_v72 = v80 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v81 : string = "format!(\"{:#?}\", $0)"
    let v82 : std_string_String = Fable.Core.RustInterop.emitRustExpr v8 v81 
    let v83 : string = "fable_library_rust::String_::fromString($0)"
    let v84 : string = Fable.Core.RustInterop.emitRustExpr v82 v83 
    let _run_target_args'_v72 = v84 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v86 : string = $"%A{v8}"
    let _run_target_args'_v72 = v86 
    #endif
#if FABLE_COMPILER_PYTHON
    let v90 : string = $"%A{v8}"
    let _run_target_args'_v72 = v90 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v94 : string = $"%A{v8}"
    let _run_target_args'_v72 = v94 
    #endif
#else
    let v98 : string = $"%A{v8}"
    let _run_target_args'_v72 = v98 
    #endif
    let v101 : string = _run_target_args'_v72 
    let v108 : string = $"{v101}"
    let v116 : unit = ()
    let v117 : (unit -> unit) = closure7(v10, v108)
    let v118 : unit = (fun () -> v117 (); v116) ()
    let v126 : string = " }"
    let v127 : string = $"{v126}"
    let v135 : unit = ()
    let v136 : (unit -> unit) = closure7(v10, v127)
    let v137 : unit = (fun () -> v136 (); v135) ()
    let v143 : string = v10.l0
    let v144 : int64 = v0.l0
    let v147 : string = " "
    let v148 : string = v6 + v147 
    let v152 : string = v148 + v7 
    let v157 : string = " #"
    let v158 : string = v152 + v157 
    let v162 : (int64 -> string) = _.ToString()
    let v163 : string = v162 v144
    let v167 : string = v158 + v163 
    let v171 : string = v167 + v147 
    let v176 : string = "chat_contract.get_alias_map"
    let v177 : string = v171 + v176 
    let v182 : string = " / "
    let v183 : string = v177 + v182 
    let v187 : string = v183 + v143 
    method15(v187)
and closure18 (v0 : std_string_String) () : unit =
    let v1 : US0 = US0_1
    let v2 : bool = method0(v1)
    if v2 then
        let v17 : unit = ()
        let v18 : (unit -> unit) = closure3()
        let v19 : unit = (fun () -> v18 (); v17) ()
        let struct (v40 : Mut0, v41 : Mut1, v42 : Mut2, v43 : Mut3, v44 : Mut4, v45 : int64 option) = TraceState.trace_state.Value
        let v58 : string = method7(v40, v41, v42, v43, v44, v45)
        let v59 : string = method11()
        let v60 : string = method24(v40, v41, v42, v43, v44, v45, v58, v59, v0)
        method16(v60)
and method25 () : (unit -> unit) =
    closure14()
and closure19 (v0 : (unit -> unit)) () : unit =
    let v1 : US0 = US0_1
    let v2 : bool = method0(v1)
    if v2 then
        let v17 : unit = ()
        let v18 : (unit -> unit) = closure3()
        let v19 : unit = (fun () -> v18 (); v17) ()
        let struct (v40 : Mut0, v41 : Mut1, v42 : Mut2, v43 : Mut3, v44 : Mut4, v45 : int64 option) = TraceState.trace_state.Value
        let v58 : string = method7(v40, v41, v42, v43, v44, v45)
        let v59 : string = method11()
        method22()
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
    let v263 : unit = ()
    let v264 : (unit -> unit) = closure2(v184, v194, v196, v198)
    let v265 : unit = (fun () -> v264 (); v263) ()
    let v330 : string = "fable_library_rust::String_::fromString($0)"
    let v331 : string = Fable.Core.RustInterop.emitRustExpr v184 v330 
    let v332 : int32 = v331.Length
    let v333 : bool = v332 > 0
    let v391 : bool =
        if v333 then
            let v334 : bool = v332 < 64
            if v334 then
                let v337 : string = "-"
                let v338 : bool = v331.StartsWith (v337, false, null)
                let v341 : bool = v338 = false
                if v341 then
                    let v343 : bool = v331.EndsWith (v337, false, null)
                    let v346 : bool = v343 = false
                    if v346 then
                        (* run_target_args'
                        let v351 : unit = ()
                        run_target_args' *)
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v352 : string = "&*$0"
                        let v353 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v331 v352 
                        let _run_target_args'_v351 = v353 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        let v354 : string = "&*$0"
                        let v355 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v331 v354 
                        let _run_target_args'_v351 = v355 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        let v356 : string = "&*$0"
                        let v357 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v331 v356 
                        let _run_target_args'_v351 = v357 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        let v359 : Ref<Str> = v331 |> unbox<Ref<Str>>
                        let _run_target_args'_v351 = v359 
                        #endif
#if FABLE_COMPILER_PYTHON
                        let v363 : Ref<Str> = v331 |> unbox<Ref<Str>>
                        let _run_target_args'_v351 = v363 
                        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                        let v367 : Ref<Str> = v331 |> unbox<Ref<Str>>
                        let _run_target_args'_v351 = v367 
                        #endif
#else
                        let v371 : Ref<Str> = v331 |> unbox<Ref<Str>>
                        let _run_target_args'_v351 = v371 
                        #endif
                        let v374 : Ref<Str> = _run_target_args'_v351 
                        let v380 : string = $"$0.chars()"
                        let v381 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v374 v380 
                        let v382 : string = "true; // 1"
                        let v383 : bool = Fable.Core.RustInterop.emitRustExpr () v382 
                        let v384 : string = "let mut v381 = v381"
                        Fable.Core.RustInterop.emitRustExpr () v384 
                        let v385 : string = $"v381.all(|x| $0(x))"
                        let v386 : (char -> bool) = closure1()
                        let v387 : bool = Fable.Core.RustInterop.emitRustExpr v386 v385 
                        v387
                    else
                        false
                else
                    false
            else
                false
        else
            false
    let v392 : bool = v391 = false
    let v396 : bool =
        if v392 then
            let v393 : string = $"true; near_sdk::env::panic_str(&*$0); //"
            let v394 : string = "chat_contract.claim_alias / invalid alias"
            let v395 : bool = Fable.Core.RustInterop.emitRustExpr v394 v393 
            true
        else
            false
    let v397 : string = $"v190.get(&$0)"
    let v398 : Ref<std_string_String> option = Fable.Core.RustInterop.emitRustExpr v194 v397 
    let v399 : string = "$0.cloned()"
    let v400 : std_string_String option = Fable.Core.RustInterop.emitRustExpr v398 v399 
    let v403 : (std_string_String -> US6) = method17()
    let v404 : US6 option = v400 |> Option.map v403 
    let v424 : US6 = US6_1
    let v425 : US6 = v404 |> Option.defaultValue v424 
    match v425 with
    | US6_0(v429) -> (* Some *)
        let v431 : bool = v429 = v184 
        if v431 then
            let v498 : unit = ()
            let v499 : (unit -> unit) = closure12(v429)
            let v500 : unit = (fun () -> v499 (); v498) ()
            ()
        else
            let v629 : unit = ()
            let v630 : (unit -> unit) = closure13(v400)
            let v631 : unit = (fun () -> v630 (); v629) ()
            let v696 : string = "    v192 //"
            Fable.Core.RustInterop.emitRustExpr () v696 
            let v697 : string = "      .get_mut(&v429) //"
            Fable.Core.RustInterop.emitRustExpr () v697 
            let v698 : string = "      .unwrap() //"
            Fable.Core.RustInterop.emitRustExpr () v698 
            let v699 : string = "      .remove(&$0); //"
            Fable.Core.RustInterop.emitRustExpr v194 v699 
            let v700 : string = "  v190.insert($0.clone(), $1.clone()); //"
            Fable.Core.RustInterop.emitRustExpr struct (v194, v184) v700 
            let v701 : string = $"v186.insert($0)"
            let v702 : bool = Fable.Core.RustInterop.emitRustExpr v194 v701 
            let v703 : string = $"v188.insert($0)"
            let v704 : bool = Fable.Core.RustInterop.emitRustExpr v184 v703 
            let v705 : string = "  let new_alias_account_map = match v192.get(&$0) { //"
            Fable.Core.RustInterop.emitRustExpr v184 v705 
            let v706 : string = "    None => { //"
            Fable.Core.RustInterop.emitRustExpr () v706 
            let v707 : string = "      let mut new_map = std::collections::HashMap::new(); //"
            Fable.Core.RustInterop.emitRustExpr () v707 
            let v708 : string = "      new_map.insert($0, ($1, 0u32)); //"
            Fable.Core.RustInterop.emitRustExpr struct (v194, v198) v708 
            let v709 : string = "      new_map //"
            Fable.Core.RustInterop.emitRustExpr () v709 
            let v710 : string = "    } //"
            Fable.Core.RustInterop.emitRustExpr () v710 
            let v711 : string = "    Some(accounts) => { //"
            Fable.Core.RustInterop.emitRustExpr () v711 
            let v712 : string = "      let mut accounts_vec = accounts.iter().collect::<Vec<_>>(); //"
            Fable.Core.RustInterop.emitRustExpr () v712 
            let v713 : string = "      accounts_vec.sort_unstable_by_key(|(_, (_, index))| index); //"
            Fable.Core.RustInterop.emitRustExpr () v713 
            let v714 : string = "      let mut new_map = accounts_vec //"
            Fable.Core.RustInterop.emitRustExpr () v714 
            let v715 : string = "        .iter() //"
            Fable.Core.RustInterop.emitRustExpr () v715 
            let v716 : string = "        .enumerate() //"
            Fable.Core.RustInterop.emitRustExpr () v716 
            let v717 : string = "        .map(|(i, (signer_account_id, (timestamp, _)))| { //"
            Fable.Core.RustInterop.emitRustExpr () v717 
            let v718 : string = "          ((*signer_account_id).clone(), (*timestamp, i as u32)) //"
            Fable.Core.RustInterop.emitRustExpr () v718 
            let v719 : string = "        }) //"
            Fable.Core.RustInterop.emitRustExpr () v719 
            let v720 : string = "        .collect::<std::collections::HashMap<_, _>>(); //"
            Fable.Core.RustInterop.emitRustExpr () v720 
            let v721 : string = "      new_map.insert($0, (v198, accounts_vec.len() as u32)); //"
            Fable.Core.RustInterop.emitRustExpr v194 v721 
            let v722 : string = "      new_map //"
            Fable.Core.RustInterop.emitRustExpr () v722 
            let v723 : string = "    } //"
            Fable.Core.RustInterop.emitRustExpr () v723 
            let v724 : string = "  }; //"
            Fable.Core.RustInterop.emitRustExpr () v724 
            let v725 : string = "  v192.insert($0, new_alias_account_map); //"
            Fable.Core.RustInterop.emitRustExpr v184 v725 
            ()
    | _ ->
        let v790 : unit = ()
        let v791 : (unit -> unit) = closure13(v400)
        let v792 : unit = (fun () -> v791 (); v790) ()
        match v425 with
        | US6_1 -> (* None *)
            ()
        let v857 : string = "  v190.insert($0.clone(), $1.clone()); //"
        Fable.Core.RustInterop.emitRustExpr struct (v194, v184) v857 
        let v858 : string = $"v186.insert($0)"
        let v859 : bool = Fable.Core.RustInterop.emitRustExpr v194 v858 
        let v860 : string = $"v188.insert($0)"
        let v861 : bool = Fable.Core.RustInterop.emitRustExpr v184 v860 
        let v862 : string = "  let new_alias_account_map = match v192.get(&$0) { //"
        Fable.Core.RustInterop.emitRustExpr v184 v862 
        let v863 : string = "    None => { //"
        Fable.Core.RustInterop.emitRustExpr () v863 
        let v864 : string = "      let mut new_map = std::collections::HashMap::new(); //"
        Fable.Core.RustInterop.emitRustExpr () v864 
        let v865 : string = "      new_map.insert($0, ($1, 0u32)); //"
        Fable.Core.RustInterop.emitRustExpr struct (v194, v198) v865 
        let v866 : string = "      new_map //"
        Fable.Core.RustInterop.emitRustExpr () v866 
        let v867 : string = "    } //"
        Fable.Core.RustInterop.emitRustExpr () v867 
        let v868 : string = "    Some(accounts) => { //"
        Fable.Core.RustInterop.emitRustExpr () v868 
        let v869 : string = "      let mut accounts_vec = accounts.iter().collect::<Vec<_>>(); //"
        Fable.Core.RustInterop.emitRustExpr () v869 
        let v870 : string = "      accounts_vec.sort_unstable_by_key(|(_, (_, index))| index); //"
        Fable.Core.RustInterop.emitRustExpr () v870 
        let v871 : string = "      let mut new_map = accounts_vec //"
        Fable.Core.RustInterop.emitRustExpr () v871 
        let v872 : string = "        .iter() //"
        Fable.Core.RustInterop.emitRustExpr () v872 
        let v873 : string = "        .enumerate() //"
        Fable.Core.RustInterop.emitRustExpr () v873 
        let v874 : string = "        .map(|(i, (signer_account_id, (timestamp, _)))| { //"
        Fable.Core.RustInterop.emitRustExpr () v874 
        let v875 : string = "          ((*signer_account_id).clone(), (*timestamp, i as u32)) //"
        Fable.Core.RustInterop.emitRustExpr () v875 
        let v876 : string = "        }) //"
        Fable.Core.RustInterop.emitRustExpr () v876 
        let v877 : string = "        .collect::<std::collections::HashMap<_, _>>(); //"
        Fable.Core.RustInterop.emitRustExpr () v877 
        let v878 : string = "      new_map.insert($0, (v198, accounts_vec.len() as u32)); //"
        Fable.Core.RustInterop.emitRustExpr v194 v878 
        let v879 : string = "      new_map //"
        Fable.Core.RustInterop.emitRustExpr () v879 
        let v880 : string = "    } //"
        Fable.Core.RustInterop.emitRustExpr () v880 
        let v881 : string = "  }; //"
        Fable.Core.RustInterop.emitRustExpr () v881 
        let v882 : string = "  v192.insert($0, new_alias_account_map); //"
        Fable.Core.RustInterop.emitRustExpr v184 v882 
        ()
    let v883 : (unit -> unit) = method21()
    let v943 : unit = ()
    let v944 : (unit -> unit) = closure15(v883)
    let v945 : unit = (fun () -> v944 (); v943) ()
    let v1005 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v1005 
    let v1006 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v1006 
    let v1007 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v1007 
    let v1008 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v1008 
    let v1009 : string = "true; // ??? / i: 5uy / i': 1uy / acc: 6uy / n: 3uy"
    let v1010 : bool = Fable.Core.RustInterop.emitRustExpr () v1009 
    let v1011 : string = "true; */ // ???? / i: 5uy / i': 2uy / acc: 6uy / n: 3uy"
    let v1012 : bool = Fable.Core.RustInterop.emitRustExpr () v1011 
    let v1013 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v1013 
    let v1014 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v1014 
    let v1015 : string = "pub fn get_account_info( //"
    Fable.Core.RustInterop.emitRustExpr () v1015 
    let v1016 : string = "  &self, //"
    Fable.Core.RustInterop.emitRustExpr () v1016 
    let v1017 : string = "  account_id: near_sdk::AccountId, //"
    Fable.Core.RustInterop.emitRustExpr () v1017 
    let v1018 : string = ") -> Option<(String, u64, u32)> { //"
    Fable.Core.RustInterop.emitRustExpr () v1018 
    let v1019 : string = $"&self.0"
    let v1020 : Ref<struct (uint32 * near_sdk_store_IterableSet<near_sdk_AccountId> * near_sdk_store_IterableSet<std_string_String> * near_sdk_store_LookupMap<near_sdk_AccountId, std_string_String> * near_sdk_store_LookupMap<std_string_String, std_collections_HashMap<near_sdk_AccountId, struct (uint64 * uint32)>>)> = Fable.Core.RustInterop.emitRustExpr () v1019 
    let v1021 : string = $"account_id"
    let v1022 : near_sdk_AccountId = Fable.Core.RustInterop.emitRustExpr () v1021 
    let v1023 : string = $"&v1020.3"
    let v1024 : Ref<near_sdk_store_LookupMap<near_sdk_AccountId, std_string_String>> = Fable.Core.RustInterop.emitRustExpr () v1023 
    let v1025 : string = $"&v1020.4"
    let v1026 : Ref<near_sdk_store_LookupMap<std_string_String, std_collections_HashMap<near_sdk_AccountId, struct (uint64 * uint32)>>> = Fable.Core.RustInterop.emitRustExpr () v1025 
    let v1027 : string = "true; let result = v1024.get(&$0).and_then(|alias| { //"
    let v1028 : bool = Fable.Core.RustInterop.emitRustExpr v1022 v1027 
    let v1029 : string = "true;    v1026.get(alias).map(|accounts| { //"
    let v1030 : bool = Fable.Core.RustInterop.emitRustExpr () v1029 
    let v1031 : string = "true;        let result = (alias.clone(), *accounts.get(&v1022).unwrap()); //"
    let v1032 : bool = Fable.Core.RustInterop.emitRustExpr () v1031 
    let v1033 : string = "true;        (result.0, result.1.0, result.1.1)  }) }); //"
    let v1034 : bool = Fable.Core.RustInterop.emitRustExpr () v1033 
    let v1035 : string = "result"
    let v1036 : struct (std_string_String * uint64 * uint32) option = Fable.Core.RustInterop.emitRustExpr () v1035 
    let v1097 : unit = ()
    let v1098 : (unit -> unit) = closure16(v1022, v1036)
    let v1099 : unit = (fun () -> v1098 (); v1097) ()
    let v1219 : unit = ()
    let v1220 : (unit -> unit) = closure17()
    let v1221 : unit = (fun () -> v1220 (); v1219) ()
    let _result = v1036 in _result |> (fun x -> Fable.Core.RustInterop.emitRustExpr x "$0 } // 4") // 3
    let v1281 : string = "} // 1"
    Fable.Core.RustInterop.emitRustExpr () v1281 
    let v1282 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v1282 
    let v1283 : string = "true; // ??? / i: 6uy / i': 1uy / acc: 9uy / n: 1uy"
    let v1284 : bool = Fable.Core.RustInterop.emitRustExpr () v1283 
    let v1285 : string = "true; */ // ???? / i: 6uy / i': 2uy / acc: 9uy / n: 1uy"
    let v1286 : bool = Fable.Core.RustInterop.emitRustExpr () v1285 
    let v1287 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v1287 
    let v1288 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v1288 
    let v1289 : string = "pub fn get_alias_map( //"
    Fable.Core.RustInterop.emitRustExpr () v1289 
    let v1290 : string = "  &self, //"
    Fable.Core.RustInterop.emitRustExpr () v1290 
    let v1291 : string = "  alias: String, //"
    Fable.Core.RustInterop.emitRustExpr () v1291 
    let v1292 : string = ") -> Option<std::collections::HashMap<near_sdk::AccountId, (u64, u32)>> { //"
    Fable.Core.RustInterop.emitRustExpr () v1292 
    let v1293 : string = $"&self.0.4"
    let v1294 : Ref<near_sdk_store_LookupMap<std_string_String, std_collections_HashMap<near_sdk_AccountId, struct (uint64 * uint32)>>> = Fable.Core.RustInterop.emitRustExpr () v1293 
    let v1295 : string = $"alias"
    let v1296 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v1295 
    let v1357 : unit = ()
    let v1358 : (unit -> unit) = closure18(v1296)
    let v1359 : unit = (fun () -> v1358 (); v1357) ()
    let v1420 : (unit -> unit) = method25()
    let v1480 : unit = ()
    let v1481 : (unit -> unit) = closure19(v1420)
    let v1482 : unit = (fun () -> v1481 (); v1480) ()
    let v1542 : string = "  v1294.get(&$0).cloned() //"
    Fable.Core.RustInterop.emitRustExpr v1296 v1542 
    let v1543 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v1543 
    let v1544 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v1544 
    let v1545 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v1545 
    let v1546 : string = "true; // ??? / i: 7uy / i': 1uy / acc: 10uy / n: 2uy"
    let v1547 : bool = Fable.Core.RustInterop.emitRustExpr () v1546 
    let v1548 : string = "true; */ // ???? / i: 7uy / i': 2uy / acc: 10uy / n: 2uy"
    let v1549 : bool = Fable.Core.RustInterop.emitRustExpr () v1548 
    let v1550 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v1550 
    let v1551 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v1551 
    let v1552 : string = "#[result_serializer(borsh)] //"
    Fable.Core.RustInterop.emitRustExpr () v1552 
    let v1553 : string = "pub fn get_alias_map_borsh( //"
    Fable.Core.RustInterop.emitRustExpr () v1553 
    let v1554 : string = "  &self, //"
    Fable.Core.RustInterop.emitRustExpr () v1554 
    let v1555 : string = "  #[serializer(borsh)] alias: String, //"
    Fable.Core.RustInterop.emitRustExpr () v1555 
    let v1556 : string = ") -> Option<std::collections::HashMap<near_sdk::AccountId, (u64, u32)>> { //"
    Fable.Core.RustInterop.emitRustExpr () v1556 
    let v1557 : string = "  self.get_alias_map(alias) //"
    Fable.Core.RustInterop.emitRustExpr () v1557 
    let v1558 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v1558 
    let v1559 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v1559 
    let v1560 : string = "true; // ??? / i: 8uy / i': 1uy / acc: 12uy / n: 1uy"
    let v1561 : bool = Fable.Core.RustInterop.emitRustExpr () v1560 
    let v1562 : string = "true; */ // ???? / i: 8uy / i': 2uy / acc: 12uy / n: 1uy"
    let v1563 : bool = Fable.Core.RustInterop.emitRustExpr () v1562 
    let v1564 : string = "fn _main() //"
    Fable.Core.RustInterop.emitRustExpr () v1564 
    let v1565 : string = "{ { //"
    Fable.Core.RustInterop.emitRustExpr () v1565 
    let v1566 : string = "true; { (); // ?? / i': 1uy / n: 13uy"
    let v1567 : bool = Fable.Core.RustInterop.emitRustExpr () v1566 
    let v1568 : string = "true; { (); // ?? / i': 2uy / n: 13uy"
    let v1569 : bool = Fable.Core.RustInterop.emitRustExpr () v1568 
    let v1570 : string = "true; { (); // ?? / i': 3uy / n: 13uy"
    let v1571 : bool = Fable.Core.RustInterop.emitRustExpr () v1570 
    let v1572 : string = "true; { (); // ?? / i': 4uy / n: 13uy"
    let v1573 : bool = Fable.Core.RustInterop.emitRustExpr () v1572 
    let v1574 : string = "true; { (); // ?? / i': 5uy / n: 13uy"
    let v1575 : bool = Fable.Core.RustInterop.emitRustExpr () v1574 
    let v1576 : string = "true; { (); // ?? / i': 6uy / n: 13uy"
    let v1577 : bool = Fable.Core.RustInterop.emitRustExpr () v1576 
    let v1578 : string = "true; { (); // ?? / i': 7uy / n: 13uy"
    let v1579 : bool = Fable.Core.RustInterop.emitRustExpr () v1578 
    let v1580 : string = "true; { (); // ?? / i': 8uy / n: 13uy"
    let v1581 : bool = Fable.Core.RustInterop.emitRustExpr () v1580 
    let v1582 : string = "true; { (); // ?? / i': 9uy / n: 13uy"
    let v1583 : bool = Fable.Core.RustInterop.emitRustExpr () v1582 
    let v1584 : string = "true; { (); // ?? / i': 10uy / n: 13uy"
    let v1585 : bool = Fable.Core.RustInterop.emitRustExpr () v1584 
    let v1586 : string = "true; { (); // ?? / i': 11uy / n: 13uy"
    let v1587 : bool = Fable.Core.RustInterop.emitRustExpr () v1586 
    let v1588 : string = "true; { (); // ?? / i': 12uy / n: 13uy"
    let v1589 : bool = Fable.Core.RustInterop.emitRustExpr () v1588 
    let v1590 : string = "true; { (); // ?? / i': 13uy / n: 13uy"
    let v1591 : bool = Fable.Core.RustInterop.emitRustExpr () v1590 
    let v1592 : string = "true; { { (); // ? / i': 14uy / n: 13uy"
    let v1593 : bool = Fable.Core.RustInterop.emitRustExpr () v1592 
    ()
let v0 : (unit -> unit) = closure0()
v0 |> ignore
()
