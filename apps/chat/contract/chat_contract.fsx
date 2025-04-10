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
type IOsEnviron = abstract environ: x: unit -> obj
module TraceState = let mutable trace_state = None
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

#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::env::VarError")>]
#endif
type std_env_VarError = class end
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
    | US4_6 of f6_0 : US3
and [<Struct>] US5 =
    | US5_0 of f0_0 : string
    | US5_1
and [<Struct>] US6 =
    | US6_0 of f0_0 : Mut0 * f0_1 : Mut1 * f0_2 : Mut2 * f0_3 : Mut3 * f0_4 : Mut4 * f0_5 : int64 option
    | US6_1
and [<Struct>] US7 =
    | US7_0 of f0_0 : std_string_String
    | US7_1
let rec closure1 () (v0 : char) : bool =
    let v1 : string = $"$0.is_alphanumeric()"
    let v2 : bool = Fable.Core.RustInterop.emitRustExpr v0 v1 
    if v2 then
        true
    else
        let v3 : bool = v0 = '-'
        v3
and method3 (v0 : string) : string =
    v0
and method4 () : string =
    let v0 : string = ""
    v0
and closure4 () (v0 : string) : US5 =
    US5_0(v0)
and method5 () : (string -> US5) =
    closure4()
and method2 (v0 : string) : string =
    (* run_target_args'
    let v2 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : string = method3(v0)
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
    let v16 : string = method4()
    let v17 : string = "$0.unwrap_or($1)"
    let v18 : string = Fable.Core.RustInterop.emitRustExpr struct (v15, v16) v17 
    let _run_target_args'_v2 = v18 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v19 : US3 = US3_1
    let v20 : US4 = US4_4(v19)
    let v21 : string = $"env.get_environment_variable / target: {v20} / var: {v0}"
    let v22 : string = failwith<string> v21
    let _run_target_args'_v2 = v22 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v23 : US3 = US3_2
    let v24 : US4 = US4_4(v23)
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
    let v49 : (string -> US5) = method5()
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
    let v93 : (string -> US5) = method5()
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
and method1 () : struct (US1 * US2) =
    let v0 : string = "TRACE_LEVEL"
    let v1 : string = method2(v0)
    
    
    
    
    
    
    
    
    
    
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
    let v129 : string = method2(v128)
    let v132 : string = "True"
    let v133 : bool = v129 <> v132 
    let v210 : US2 =
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
            let v204 : int64 = v182 |> int64 
            US2_0(v204)
    struct (v127, v210)
and closure5 () (v0 : string) : unit =
    ()
and method0 (v0 : US0) : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) =
    (* run_target_args'
    let v3 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let struct (v4 : US1, v5 : US2) = method1()
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
    let v52 : string = "fable_library_rust::String_::fromString($0)"
    let v53 : string = Fable.Core.RustInterop.emitRustExpr v43 v52 
    let _run_target_args'_v13 = v53 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v54 : string = "option_env!(\"" + v8 + "\").unwrap_or(\"\")"
    let v55 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v54 
    (* run_target_args'
    let v60 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v61 : string = "String::from($0)"
    let v62 : std_string_String = Fable.Core.RustInterop.emitRustExpr v55 v61 
    let _run_target_args'_v60 = v62 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v63 : string = "String::from($0)"
    let v64 : std_string_String = Fable.Core.RustInterop.emitRustExpr v55 v63 
    let _run_target_args'_v60 = v64 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v65 : string = "String::from($0)"
    let v66 : std_string_String = Fable.Core.RustInterop.emitRustExpr v55 v65 
    let _run_target_args'_v60 = v66 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v68 : std_string_String = v55 |> unbox<std_string_String>
    let _run_target_args'_v60 = v68 
    #endif
#if FABLE_COMPILER_PYTHON
    let v72 : std_string_String = v55 |> unbox<std_string_String>
    let _run_target_args'_v60 = v72 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v76 : std_string_String = v55 |> unbox<std_string_String>
    let _run_target_args'_v60 = v76 
    #endif
#else
    let v80 : std_string_String = v55 |> unbox<std_string_String>
    let _run_target_args'_v60 = v80 
    #endif
    let v83 : std_string_String = _run_target_args'_v60 
    let v92 : string = "fable_library_rust::String_::fromString($0)"
    let v93 : string = Fable.Core.RustInterop.emitRustExpr v83 v92 
    let _run_target_args'_v13 = v93 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v94 : string = "option_env!(\"" + v8 + "\").unwrap_or(\"\")"
    let v95 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v94 
    (* run_target_args'
    let v100 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v101 : string = "String::from($0)"
    let v102 : std_string_String = Fable.Core.RustInterop.emitRustExpr v95 v101 
    let _run_target_args'_v100 = v102 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v103 : string = "String::from($0)"
    let v104 : std_string_String = Fable.Core.RustInterop.emitRustExpr v95 v103 
    let _run_target_args'_v100 = v104 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v105 : string = "String::from($0)"
    let v106 : std_string_String = Fable.Core.RustInterop.emitRustExpr v95 v105 
    let _run_target_args'_v100 = v106 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v108 : std_string_String = v95 |> unbox<std_string_String>
    let _run_target_args'_v100 = v108 
    #endif
#if FABLE_COMPILER_PYTHON
    let v112 : std_string_String = v95 |> unbox<std_string_String>
    let _run_target_args'_v100 = v112 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v116 : std_string_String = v95 |> unbox<std_string_String>
    let _run_target_args'_v100 = v116 
    #endif
#else
    let v120 : std_string_String = v95 |> unbox<std_string_String>
    let _run_target_args'_v100 = v120 
    #endif
    let v123 : std_string_String = _run_target_args'_v100 
    let v132 : string = "fable_library_rust::String_::fromString($0)"
    let v133 : string = Fable.Core.RustInterop.emitRustExpr v123 v132 
    let _run_target_args'_v13 = v133 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v135 : string = null |> unbox<string>
    let _run_target_args'_v13 = v135 
    #endif
#if FABLE_COMPILER_PYTHON
    let v139 : string = null |> unbox<string>
    let _run_target_args'_v13 = v139 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v143 : string = null |> unbox<string>
    let _run_target_args'_v13 = v143 
    #endif
#else
    let v147 : string = null |> unbox<string>
    let _run_target_args'_v13 = v147 
    #endif
    let v150 : string = _run_target_args'_v13 
    let v161 : string = "True"
    let v162 : bool = v150 <> v161 
    let v174 : US2 =
        if v162 then
            US2_1
        else
            let v166 : string = $"near_sdk::env::block_timestamp()"
            let v167 : uint64 = Fable.Core.RustInterop.emitRustExpr () v166 
            let v169 : (uint64 -> int64) = int64
            let v170 : int64 = v169 v167
            US2_0(v170)
    let v175 : US1 = US1_1
    let _run_target_args'_v3 = struct (v175, v174) 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let struct (v176 : US1, v177 : US2) = method1()
    let _run_target_args'_v3 = struct (v176, v177) 
    #endif
#if FABLE_COMPILER_PYTHON
    let struct (v178 : US1, v179 : US2) = method1()
    let _run_target_args'_v3 = struct (v178, v179) 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let struct (v180 : US1, v181 : US2) = method1()
    let _run_target_args'_v3 = struct (v180, v181) 
    #endif
#else
    let struct (v182 : US1, v183 : US2) = method1()
    let _run_target_args'_v3 = struct (v182, v183) 
    #endif
    let struct (v184 : US1, v185 : US2) = _run_target_args'_v3 
    let v190 : Mut0 = {l0 = 1L} : Mut0
    let v191 : (string -> unit) = closure5()
    let v192 : Mut1 = {l0 = v191} : Mut1
    let v193 : Mut2 = {l0 = true} : Mut2
    let v194 : string = ""
    let v195 : Mut3 = {l0 = v194} : Mut3
    let v198 : US0 =
        match v184 with
        | US1_1 -> (* None *)
            v0
        | US1_0(v196) -> (* Some *)
            v196
    let v199 : Mut4 = {l0 = v198} : Mut4
    let v210 : int64 option =
        match v185 with
        | US2_1 -> (* None *)
            let v206 : int64 option = None
            v206
        | US2_0(v200) -> (* Some *)
            let v202 : int64 option = Some v200 
            v202
    struct (v190, v192, v193, v195, v199, v210)
and closure3 () () : unit =
    let v0 : bool = TraceState.trace_state.IsNone
    if v0 then
        let v1 : US0 = US0_0
        let struct (v2 : Mut0, v3 : Mut1, v4 : Mut2, v5 : Mut3, v6 : Mut4, v7 : int64 option) = method0(v1)
        let v9 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v2, v3, v4, v5, v6, v7) 
        TraceState.trace_state <- v9 
        ()
and closure6 () (v0 : int64) : US2 =
    US2_0(v0)
and method7 () : (int64 -> US2) =
    closure6()
and method8 () : string =
    let v0 : string = "hh:mm:ss"
    v0
and method9 () : string =
    let v0 : string = "HH:mm:ss"
    v0
and method6 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option) : string =
    (* run_target_args'
    let v195 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v198 : (int64 -> US2) = method7()
    let v199 : US2 option = v5 |> Option.map v198 
    let v219 : US2 = US2_1
    let v220 : US2 = v199 |> Option.defaultValue v219 
    let v360 : System.DateTime =
        match v220 with
        | US2_1 -> (* None *)
            (* run_target_args'
            let v343 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v344 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v343 = v344 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v345 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v343 = v345 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v347 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v343 = v347 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v350 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v343 = v350 
            #endif
#if FABLE_COMPILER_PYTHON
            let v351 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v343 = v351 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v352 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v343 = v352 
            #endif
#else
            let v353 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v343 = v353 
            #endif
            let v354 : System.DateTime = _run_target_args'_v343 
            v354
        | US2_0(v224) -> (* Some *)
            (* run_target_args'
            let v231 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v232 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v231 = v232 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v233 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v231 = v233 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v235 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v231 = v235 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v238 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v231 = v238 
            #endif
#if FABLE_COMPILER_PYTHON
            let v239 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v231 = v239 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v240 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v231 = v240 
            #endif
#else
            let v241 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v231 = v241 
            #endif
            let v242 : System.DateTime = _run_target_args'_v231 
            (* run_target_args'
            let v253 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v254 : (System.DateTime -> int64) = _.Ticks
            let v255 : int64 = v254 v242
            let _run_target_args'_v253 = v255 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v256 : (System.DateTime -> int64) = _.Ticks
            let v257 : int64 = v256 v242
            let _run_target_args'_v253 = v257 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v259 : int64 = null |> unbox<int64>
            let _run_target_args'_v253 = v259 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v262 : (System.DateTime -> int64) = _.Ticks
            let v263 : int64 = v262 v242
            let _run_target_args'_v253 = v263 
            #endif
#if FABLE_COMPILER_PYTHON
            let v264 : (System.DateTime -> int64) = _.Ticks
            let v265 : int64 = v264 v242
            let _run_target_args'_v253 = v265 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v266 : (System.DateTime -> int64) = _.Ticks
            let v267 : int64 = v266 v242
            let _run_target_args'_v253 = v267 
            #endif
#else
            let v268 : (System.DateTime -> int64) = _.Ticks
            let v269 : int64 = v268 v242
            let _run_target_args'_v253 = v269 
            #endif
            let v270 : int64 = _run_target_args'_v253 
            let v292 : int64 = v270 |> int64 
            let v297 : int64 = v292 - v224
            let v303 : System.TimeSpan = v297 |> System.TimeSpan 
            let v309 : (System.TimeSpan -> int32) = _.Hours
            let v310 : int32 = v309 v303
            let v314 : (System.TimeSpan -> int32) = _.Minutes
            let v315 : int32 = v314 v303
            let v319 : (System.TimeSpan -> int32) = _.Seconds
            let v320 : int32 = v319 v303
            let v324 : (System.TimeSpan -> int32) = _.Milliseconds
            let v325 : int32 = v324 v303
            let v334 : System.DateTime = System.DateTime (1, 1, 1, v310, v315, v320, v325)
            v334
    let v361 : string = method8()
    let v363 : bool = v361 = ""
    let v365 : string =
        if v363 then
            let v364 : string = "M-d-y hh:mm:ss tt"
            v364
        else
            v361
    let v366 : (string -> string) = v360.ToString
    let v367 : string = v366 v365
    let _run_target_args'_v195 = v367 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v384 : (int64 -> US2) = method7()
    let v385 : US2 option = v5 |> Option.map v384 
    let v405 : US2 = US2_1
    let v406 : US2 = v385 |> Option.defaultValue v405 
    let v546 : System.DateTime =
        match v406 with
        | US2_1 -> (* None *)
            (* run_target_args'
            let v529 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v530 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v529 = v530 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v531 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v529 = v531 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v533 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v529 = v533 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v536 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v529 = v536 
            #endif
#if FABLE_COMPILER_PYTHON
            let v537 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v529 = v537 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v538 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v529 = v538 
            #endif
#else
            let v539 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v529 = v539 
            #endif
            let v540 : System.DateTime = _run_target_args'_v529 
            v540
        | US2_0(v410) -> (* Some *)
            (* run_target_args'
            let v417 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v418 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v417 = v418 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v419 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v417 = v419 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v421 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v417 = v421 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v424 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v417 = v424 
            #endif
#if FABLE_COMPILER_PYTHON
            let v425 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v417 = v425 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v426 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v417 = v426 
            #endif
#else
            let v427 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v417 = v427 
            #endif
            let v428 : System.DateTime = _run_target_args'_v417 
            (* run_target_args'
            let v439 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v440 : (System.DateTime -> int64) = _.Ticks
            let v441 : int64 = v440 v428
            let _run_target_args'_v439 = v441 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v442 : (System.DateTime -> int64) = _.Ticks
            let v443 : int64 = v442 v428
            let _run_target_args'_v439 = v443 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v445 : int64 = null |> unbox<int64>
            let _run_target_args'_v439 = v445 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v448 : (System.DateTime -> int64) = _.Ticks
            let v449 : int64 = v448 v428
            let _run_target_args'_v439 = v449 
            #endif
#if FABLE_COMPILER_PYTHON
            let v450 : (System.DateTime -> int64) = _.Ticks
            let v451 : int64 = v450 v428
            let _run_target_args'_v439 = v451 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v452 : (System.DateTime -> int64) = _.Ticks
            let v453 : int64 = v452 v428
            let _run_target_args'_v439 = v453 
            #endif
#else
            let v454 : (System.DateTime -> int64) = _.Ticks
            let v455 : int64 = v454 v428
            let _run_target_args'_v439 = v455 
            #endif
            let v456 : int64 = _run_target_args'_v439 
            let v478 : int64 = v456 |> int64 
            let v483 : int64 = v478 - v410
            let v489 : System.TimeSpan = v483 |> System.TimeSpan 
            let v495 : (System.TimeSpan -> int32) = _.Hours
            let v496 : int32 = v495 v489
            let v500 : (System.TimeSpan -> int32) = _.Minutes
            let v501 : int32 = v500 v489
            let v505 : (System.TimeSpan -> int32) = _.Seconds
            let v506 : int32 = v505 v489
            let v510 : (System.TimeSpan -> int32) = _.Milliseconds
            let v511 : int32 = v510 v489
            let v520 : System.DateTime = System.DateTime (1, 1, 1, v496, v501, v506, v511)
            v520
    let v547 : string = method8()
    let v549 : bool = v547 = ""
    let v551 : string =
        if v549 then
            let v550 : string = "M-d-y hh:mm:ss tt"
            v550
        else
            v547
    let v552 : (string -> string) = v546.ToString
    let v553 : string = v552 v551
    let _run_target_args'_v195 = v553 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v568 : string = $"near_sdk::env::block_timestamp()"
    let v569 : uint64 = Fable.Core.RustInterop.emitRustExpr () v568 
    let v572 : (int64 -> US2) = method7()
    let v573 : US2 option = v5 |> Option.map v572 
    let v593 : US2 = US2_1
    let v594 : US2 = v573 |> Option.defaultValue v593 
    let v606 : uint64 =
        match v594 with
        | US2_1 -> (* None *)
            v569
        | US2_0(v598) -> (* Some *)
            let v600 : (int64 -> uint64) = uint64
            let v601 : uint64 = v600 v598
            let v604 : uint64 = v569 - v601
            v604
    let v607 : uint64 = v606 / 1000000000UL
    let v608 : uint64 = v607 % 60UL
    let v609 : uint64 = v607 / 60UL
    let v610 : uint64 = v609 % 60UL
    let v611 : uint64 = v607 / 3600UL
    let v612 : uint64 = v611 % 24UL
    let v613 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
    let v614 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v612, v610, v608) v613 
    let v615 : string = "fable_library_rust::String_::fromString($0)"
    let v616 : string = Fable.Core.RustInterop.emitRustExpr v614 v615 
    let _run_target_args'_v195 = v616 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v619 : (int64 -> US2) = method7()
    let v620 : US2 option = v5 |> Option.map v619 
    let v640 : US2 = US2_1
    let v641 : US2 = v620 |> Option.defaultValue v640 
    let v781 : System.DateTime =
        match v641 with
        | US2_1 -> (* None *)
            (* run_target_args'
            let v764 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v765 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v764 = v765 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v766 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v764 = v766 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v768 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v764 = v768 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v771 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v764 = v771 
            #endif
#if FABLE_COMPILER_PYTHON
            let v772 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v764 = v772 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v773 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v764 = v773 
            #endif
#else
            let v774 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v764 = v774 
            #endif
            let v775 : System.DateTime = _run_target_args'_v764 
            v775
        | US2_0(v645) -> (* Some *)
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
            (* run_target_args'
            let v674 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v675 : (System.DateTime -> int64) = _.Ticks
            let v676 : int64 = v675 v663
            let _run_target_args'_v674 = v676 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v677 : (System.DateTime -> int64) = _.Ticks
            let v678 : int64 = v677 v663
            let _run_target_args'_v674 = v678 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v680 : int64 = null |> unbox<int64>
            let _run_target_args'_v674 = v680 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v683 : (System.DateTime -> int64) = _.Ticks
            let v684 : int64 = v683 v663
            let _run_target_args'_v674 = v684 
            #endif
#if FABLE_COMPILER_PYTHON
            let v685 : (System.DateTime -> int64) = _.Ticks
            let v686 : int64 = v685 v663
            let _run_target_args'_v674 = v686 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v687 : (System.DateTime -> int64) = _.Ticks
            let v688 : int64 = v687 v663
            let _run_target_args'_v674 = v688 
            #endif
#else
            let v689 : (System.DateTime -> int64) = _.Ticks
            let v690 : int64 = v689 v663
            let _run_target_args'_v674 = v690 
            #endif
            let v691 : int64 = _run_target_args'_v674 
            let v713 : int64 = v691 |> int64 
            let v718 : int64 = v713 - v645
            let v724 : System.TimeSpan = v718 |> System.TimeSpan 
            let v730 : (System.TimeSpan -> int32) = _.Hours
            let v731 : int32 = v730 v724
            let v735 : (System.TimeSpan -> int32) = _.Minutes
            let v736 : int32 = v735 v724
            let v740 : (System.TimeSpan -> int32) = _.Seconds
            let v741 : int32 = v740 v724
            let v745 : (System.TimeSpan -> int32) = _.Milliseconds
            let v746 : int32 = v745 v724
            let v755 : System.DateTime = System.DateTime (1, 1, 1, v731, v736, v741, v746)
            v755
    let v782 : string = method9()
    let v784 : bool = v782 = ""
    let v786 : string =
        if v784 then
            let v785 : string = "M-d-y hh:mm:ss tt"
            v785
        else
            v782
    let v787 : (string -> string) = v781.ToString
    let v788 : string = v787 v786
    let _run_target_args'_v195 = v788 
    #endif
#if FABLE_COMPILER_PYTHON
    let v805 : (int64 -> US2) = method7()
    let v806 : US2 option = v5 |> Option.map v805 
    let v826 : US2 = US2_1
    let v827 : US2 = v806 |> Option.defaultValue v826 
    let v967 : System.DateTime =
        match v827 with
        | US2_1 -> (* None *)
            (* run_target_args'
            let v950 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v951 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v950 = v951 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v952 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v950 = v952 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v954 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v950 = v954 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v957 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v950 = v957 
            #endif
#if FABLE_COMPILER_PYTHON
            let v958 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v950 = v958 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v959 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v950 = v959 
            #endif
#else
            let v960 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v950 = v960 
            #endif
            let v961 : System.DateTime = _run_target_args'_v950 
            v961
        | US2_0(v831) -> (* Some *)
            (* run_target_args'
            let v838 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v839 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v838 = v839 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v840 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v838 = v840 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v842 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v838 = v842 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v845 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v838 = v845 
            #endif
#if FABLE_COMPILER_PYTHON
            let v846 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v838 = v846 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v847 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v838 = v847 
            #endif
#else
            let v848 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v838 = v848 
            #endif
            let v849 : System.DateTime = _run_target_args'_v838 
            (* run_target_args'
            let v860 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v861 : (System.DateTime -> int64) = _.Ticks
            let v862 : int64 = v861 v849
            let _run_target_args'_v860 = v862 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v863 : (System.DateTime -> int64) = _.Ticks
            let v864 : int64 = v863 v849
            let _run_target_args'_v860 = v864 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v866 : int64 = null |> unbox<int64>
            let _run_target_args'_v860 = v866 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v869 : (System.DateTime -> int64) = _.Ticks
            let v870 : int64 = v869 v849
            let _run_target_args'_v860 = v870 
            #endif
#if FABLE_COMPILER_PYTHON
            let v871 : (System.DateTime -> int64) = _.Ticks
            let v872 : int64 = v871 v849
            let _run_target_args'_v860 = v872 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v873 : (System.DateTime -> int64) = _.Ticks
            let v874 : int64 = v873 v849
            let _run_target_args'_v860 = v874 
            #endif
#else
            let v875 : (System.DateTime -> int64) = _.Ticks
            let v876 : int64 = v875 v849
            let _run_target_args'_v860 = v876 
            #endif
            let v877 : int64 = _run_target_args'_v860 
            let v899 : int64 = v877 |> int64 
            let v904 : int64 = v899 - v831
            let v910 : System.TimeSpan = v904 |> System.TimeSpan 
            let v916 : (System.TimeSpan -> int32) = _.Hours
            let v917 : int32 = v916 v910
            let v921 : (System.TimeSpan -> int32) = _.Minutes
            let v922 : int32 = v921 v910
            let v926 : (System.TimeSpan -> int32) = _.Seconds
            let v927 : int32 = v926 v910
            let v931 : (System.TimeSpan -> int32) = _.Milliseconds
            let v932 : int32 = v931 v910
            let v941 : System.DateTime = System.DateTime (1, 1, 1, v917, v922, v927, v932)
            v941
    let v968 : string = method9()
    let v970 : bool = v968 = ""
    let v972 : string =
        if v970 then
            let v971 : string = "M-d-y hh:mm:ss tt"
            v971
        else
            v968
    let v973 : (string -> string) = v967.ToString
    let v974 : string = v973 v972
    let _run_target_args'_v195 = v974 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v991 : (int64 -> US2) = method7()
    let v992 : US2 option = v5 |> Option.map v991 
    let v1012 : US2 = US2_1
    let v1013 : US2 = v992 |> Option.defaultValue v1012 
    let v1153 : System.DateTime =
        match v1013 with
        | US2_1 -> (* None *)
            (* run_target_args'
            let v1136 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1137 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1136 = v1137 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1138 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1136 = v1138 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1140 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v1136 = v1140 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1143 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1136 = v1143 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1144 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1136 = v1144 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1145 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1136 = v1145 
            #endif
#else
            let v1146 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1136 = v1146 
            #endif
            let v1147 : System.DateTime = _run_target_args'_v1136 
            v1147
        | US2_0(v1017) -> (* Some *)
            (* run_target_args'
            let v1024 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1025 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1024 = v1025 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1026 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1024 = v1026 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1028 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v1024 = v1028 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1031 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1024 = v1031 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1032 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1024 = v1032 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1033 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1024 = v1033 
            #endif
#else
            let v1034 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1024 = v1034 
            #endif
            let v1035 : System.DateTime = _run_target_args'_v1024 
            (* run_target_args'
            let v1046 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1047 : (System.DateTime -> int64) = _.Ticks
            let v1048 : int64 = v1047 v1035
            let _run_target_args'_v1046 = v1048 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1049 : (System.DateTime -> int64) = _.Ticks
            let v1050 : int64 = v1049 v1035
            let _run_target_args'_v1046 = v1050 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1052 : int64 = null |> unbox<int64>
            let _run_target_args'_v1046 = v1052 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1055 : (System.DateTime -> int64) = _.Ticks
            let v1056 : int64 = v1055 v1035
            let _run_target_args'_v1046 = v1056 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1057 : (System.DateTime -> int64) = _.Ticks
            let v1058 : int64 = v1057 v1035
            let _run_target_args'_v1046 = v1058 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1059 : (System.DateTime -> int64) = _.Ticks
            let v1060 : int64 = v1059 v1035
            let _run_target_args'_v1046 = v1060 
            #endif
#else
            let v1061 : (System.DateTime -> int64) = _.Ticks
            let v1062 : int64 = v1061 v1035
            let _run_target_args'_v1046 = v1062 
            #endif
            let v1063 : int64 = _run_target_args'_v1046 
            let v1085 : int64 = v1063 |> int64 
            let v1090 : int64 = v1085 - v1017
            let v1096 : System.TimeSpan = v1090 |> System.TimeSpan 
            let v1102 : (System.TimeSpan -> int32) = _.Hours
            let v1103 : int32 = v1102 v1096
            let v1107 : (System.TimeSpan -> int32) = _.Minutes
            let v1108 : int32 = v1107 v1096
            let v1112 : (System.TimeSpan -> int32) = _.Seconds
            let v1113 : int32 = v1112 v1096
            let v1117 : (System.TimeSpan -> int32) = _.Milliseconds
            let v1118 : int32 = v1117 v1096
            let v1127 : System.DateTime = System.DateTime (1, 1, 1, v1103, v1108, v1113, v1118)
            v1127
    let v1154 : string = method9()
    let v1156 : bool = v1154 = ""
    let v1158 : string =
        if v1156 then
            let v1157 : string = "M-d-y hh:mm:ss tt"
            v1157
        else
            v1154
    let v1159 : (string -> string) = v1153.ToString
    let v1160 : string = v1159 v1158
    let _run_target_args'_v195 = v1160 
    #endif
#else
    let v1177 : (int64 -> US2) = method7()
    let v1178 : US2 option = v5 |> Option.map v1177 
    let v1198 : US2 = US2_1
    let v1199 : US2 = v1178 |> Option.defaultValue v1198 
    let v1339 : System.DateTime =
        match v1199 with
        | US2_1 -> (* None *)
            (* run_target_args'
            let v1322 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1323 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1322 = v1323 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1324 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1322 = v1324 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1326 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v1322 = v1326 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1329 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1322 = v1329 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1330 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1322 = v1330 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1331 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1322 = v1331 
            #endif
#else
            let v1332 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1322 = v1332 
            #endif
            let v1333 : System.DateTime = _run_target_args'_v1322 
            v1333
        | US2_0(v1203) -> (* Some *)
            (* run_target_args'
            let v1210 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1211 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1210 = v1211 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1212 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1210 = v1212 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1214 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v1210 = v1214 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1217 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1210 = v1217 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1218 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1210 = v1218 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1219 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1210 = v1219 
            #endif
#else
            let v1220 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v1210 = v1220 
            #endif
            let v1221 : System.DateTime = _run_target_args'_v1210 
            (* run_target_args'
            let v1232 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1233 : (System.DateTime -> int64) = _.Ticks
            let v1234 : int64 = v1233 v1221
            let _run_target_args'_v1232 = v1234 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1235 : (System.DateTime -> int64) = _.Ticks
            let v1236 : int64 = v1235 v1221
            let _run_target_args'_v1232 = v1236 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1238 : int64 = null |> unbox<int64>
            let _run_target_args'_v1232 = v1238 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1241 : (System.DateTime -> int64) = _.Ticks
            let v1242 : int64 = v1241 v1221
            let _run_target_args'_v1232 = v1242 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1243 : (System.DateTime -> int64) = _.Ticks
            let v1244 : int64 = v1243 v1221
            let _run_target_args'_v1232 = v1244 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1245 : (System.DateTime -> int64) = _.Ticks
            let v1246 : int64 = v1245 v1221
            let _run_target_args'_v1232 = v1246 
            #endif
#else
            let v1247 : (System.DateTime -> int64) = _.Ticks
            let v1248 : int64 = v1247 v1221
            let _run_target_args'_v1232 = v1248 
            #endif
            let v1249 : int64 = _run_target_args'_v1232 
            let v1271 : int64 = v1249 |> int64 
            let v1276 : int64 = v1271 - v1203
            let v1282 : System.TimeSpan = v1276 |> System.TimeSpan 
            let v1288 : (System.TimeSpan -> int32) = _.Hours
            let v1289 : int32 = v1288 v1282
            let v1293 : (System.TimeSpan -> int32) = _.Minutes
            let v1294 : int32 = v1293 v1282
            let v1298 : (System.TimeSpan -> int32) = _.Seconds
            let v1299 : int32 = v1298 v1282
            let v1303 : (System.TimeSpan -> int32) = _.Milliseconds
            let v1304 : int32 = v1303 v1282
            let v1313 : System.DateTime = System.DateTime (1, 1, 1, v1289, v1294, v1299, v1304)
            v1313
    let v1340 : string = method9()
    let v1342 : bool = v1340 = ""
    let v1344 : string =
        if v1342 then
            let v1343 : string = "M-d-y hh:mm:ss tt"
            v1343
        else
            v1340
    let v1345 : (string -> string) = v1339.ToString
    let v1346 : string = v1345 v1344
    let _run_target_args'_v195 = v1346 
    #endif
    let v1361 : string = _run_target_args'_v195 
    v1361
and method12 () : string =
    let v0 : string = ""
    v0
and closure7 (v0 : Mut3, v1 : string) () : unit =
    let v2 : string = v0.l0
    let v4 : string = v2 + v1 
    v0.l0 <- v4
    ()
and method11 (v0 : char) : string =
    let v1 : string = method12()
    let v2 : Mut3 = {l0 = v1} : Mut3
    let v7 : string = $"{v0}"
    let v15 : unit = ()
    let v16 : (unit -> unit) = closure7(v2, v7)
    let v17 : unit = (fun () -> v16 (); v15) ()
    let v23 : string = v2.l0
    v23
and method13 () : string =
    let v0 : string = "\u001b[0m"
    v0
and method10 () : string =
    
    
    
    
    
    let v2 : string = "Debug"
    let v3 : (unit -> string) = v2.ToLower
    let v4 : string = v3 ()
    let v7 : char = v4.[int 0]
    let v8 : string = method11(v7)
    (* run_target_args'
    let v25 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v26 : string = "inline_colorization::color_bright_blue"
    let v27 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v26 
    (* run_target_args'
    let v32 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v33 : string = "&*$0"
    let v34 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v8 v33 
    let _run_target_args'_v32 = v34 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v35 : string = "&*$0"
    let v36 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v8 v35 
    let _run_target_args'_v32 = v36 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v37 : string = "&*$0"
    let v38 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v8 v37 
    let _run_target_args'_v32 = v38 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v40 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v32 = v40 
    #endif
#if FABLE_COMPILER_PYTHON
    let v44 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v32 = v44 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v48 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v32 = v48 
    #endif
#else
    let v52 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v32 = v52 
    #endif
    let v55 : Ref<Str> = _run_target_args'_v32 
    let v64 : string = "inline_colorization::color_reset"
    let v65 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v64 
    let v66 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v67 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v27, v55, v65) v66 
    let v68 : string = "fable_library_rust::String_::fromString($0)"
    let v69 : string = Fable.Core.RustInterop.emitRustExpr v67 v68 
    let _run_target_args'_v25 = v69 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v70 : string = "inline_colorization::color_bright_blue"
    let v71 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v70 
    (* run_target_args'
    let v76 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v77 : string = "&*$0"
    let v78 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v8 v77 
    let _run_target_args'_v76 = v78 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v79 : string = "&*$0"
    let v80 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v8 v79 
    let _run_target_args'_v76 = v80 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v81 : string = "&*$0"
    let v82 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v8 v81 
    let _run_target_args'_v76 = v82 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v84 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v76 = v84 
    #endif
#if FABLE_COMPILER_PYTHON
    let v88 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v76 = v88 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v92 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v76 = v92 
    #endif
#else
    let v96 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v76 = v96 
    #endif
    let v99 : Ref<Str> = _run_target_args'_v76 
    let v108 : string = "inline_colorization::color_reset"
    let v109 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v108 
    let v110 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v111 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v71, v99, v109) v110 
    let v112 : string = "fable_library_rust::String_::fromString($0)"
    let v113 : string = Fable.Core.RustInterop.emitRustExpr v111 v112 
    let _run_target_args'_v25 = v113 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v114 : string = "inline_colorization::color_bright_blue"
    let v115 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v114 
    (* run_target_args'
    let v120 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v121 : string = "&*$0"
    let v122 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v8 v121 
    let _run_target_args'_v120 = v122 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v123 : string = "&*$0"
    let v124 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v8 v123 
    let _run_target_args'_v120 = v124 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v125 : string = "&*$0"
    let v126 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v8 v125 
    let _run_target_args'_v120 = v126 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v128 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v120 = v128 
    #endif
#if FABLE_COMPILER_PYTHON
    let v132 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v120 = v132 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v136 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v120 = v136 
    #endif
#else
    let v140 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v120 = v140 
    #endif
    let v143 : Ref<Str> = _run_target_args'_v120 
    let v152 : string = "inline_colorization::color_reset"
    let v153 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v152 
    let v154 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v155 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v115, v143, v153) v154 
    let v156 : string = "fable_library_rust::String_::fromString($0)"
    let v157 : string = Fable.Core.RustInterop.emitRustExpr v155 v156 
    let _run_target_args'_v25 = v157 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v159 : string = "\u001b[94m"
    let v163 : string = method13()
    let v167 : string = v159 + v8 
    let v171 : string = v167 + v163 
    let _run_target_args'_v25 = v171 
    #endif
#if FABLE_COMPILER_PYTHON
    let v175 : string = "\u001b[94m"
    let v179 : string = method13()
    let v183 : string = v175 + v8 
    let v187 : string = v183 + v179 
    let _run_target_args'_v25 = v187 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v191 : string = "\u001b[94m"
    let v195 : string = method13()
    let v199 : string = v191 + v8 
    let v203 : string = v199 + v195 
    let _run_target_args'_v25 = v203 
    #endif
#else
    let v207 : string = "\u001b[94m"
    let v211 : string = method13()
    let v215 : string = v207 + v8 
    let v219 : string = v215 + v211 
    let _run_target_args'_v25 = v219 
    #endif
    let v222 : string = _run_target_args'_v25 
    v222
and method15 (v0 : std_string_String, v1 : uint64, v2 : std_string_String, v3 : std_string_String) : string =
    let v4 : string = method12()
    let v5 : Mut3 = {l0 = v4} : Mut3
    let v8 : string = "{ "
    let v9 : string = $"{v8}"
    let v17 : unit = ()
    let v18 : (unit -> unit) = closure7(v5, v9)
    let v19 : unit = (fun () -> v18 (); v17) ()
    let v27 : string = "alias"
    let v28 : string = $"{v27}"
    let v36 : unit = ()
    let v37 : (unit -> unit) = closure7(v5, v28)
    let v38 : unit = (fun () -> v37 (); v36) ()
    let v46 : string = " = "
    let v47 : string = $"{v46}"
    let v55 : unit = ()
    let v56 : (unit -> unit) = closure7(v5, v47)
    let v57 : unit = (fun () -> v56 (); v55) ()
    (* run_target_args'
    let v67 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v68 : string = "format!(\"{:#?}\", $0)"
    let v69 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v68 
    let v70 : string = "fable_library_rust::String_::fromString($0)"
    let v71 : string = Fable.Core.RustInterop.emitRustExpr v69 v70 
    let _run_target_args'_v67 = v71 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v72 : string = "format!(\"{:#?}\", $0)"
    let v73 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v72 
    let v74 : string = "fable_library_rust::String_::fromString($0)"
    let v75 : string = Fable.Core.RustInterop.emitRustExpr v73 v74 
    let _run_target_args'_v67 = v75 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v76 : string = "format!(\"{:#?}\", $0)"
    let v77 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v76 
    let v78 : string = "fable_library_rust::String_::fromString($0)"
    let v79 : string = Fable.Core.RustInterop.emitRustExpr v77 v78 
    let _run_target_args'_v67 = v79 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v81 : string = $"%A{v0}"
    let _run_target_args'_v67 = v81 
    #endif
#if FABLE_COMPILER_PYTHON
    let v85 : string = $"%A{v0}"
    let _run_target_args'_v67 = v85 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v89 : string = $"%A{v0}"
    let _run_target_args'_v67 = v89 
    #endif
#else
    let v93 : string = $"%A{v0}"
    let _run_target_args'_v67 = v93 
    #endif
    let v96 : string = _run_target_args'_v67 
    let v106 : string = $"{v96}"
    let v114 : unit = ()
    let v115 : (unit -> unit) = closure7(v5, v106)
    let v116 : unit = (fun () -> v115 (); v114) ()
    let v124 : string = "; "
    let v125 : string = $"{v124}"
    let v133 : unit = ()
    let v134 : (unit -> unit) = closure7(v5, v125)
    let v135 : unit = (fun () -> v134 (); v133) ()
    let v143 : string = "block_timestamp"
    let v144 : string = $"{v143}"
    let v152 : unit = ()
    let v153 : (unit -> unit) = closure7(v5, v144)
    let v154 : unit = (fun () -> v153 (); v152) ()
    let v161 : string = $"{v46}"
    let v169 : unit = ()
    let v170 : (unit -> unit) = closure7(v5, v161)
    let v171 : unit = (fun () -> v170 (); v169) ()
    let v181 : string = $"{v1}"
    let v189 : unit = ()
    let v190 : (unit -> unit) = closure7(v5, v181)
    let v191 : unit = (fun () -> v190 (); v189) ()
    let v198 : string = $"{v124}"
    let v206 : unit = ()
    let v207 : (unit -> unit) = closure7(v5, v198)
    let v208 : unit = (fun () -> v207 (); v206) ()
    let v216 : string = "signer_account_id"
    let v217 : string = $"{v216}"
    let v225 : unit = ()
    let v226 : (unit -> unit) = closure7(v5, v217)
    let v227 : unit = (fun () -> v226 (); v225) ()
    let v234 : string = $"{v46}"
    let v242 : unit = ()
    let v243 : (unit -> unit) = closure7(v5, v234)
    let v244 : unit = (fun () -> v243 (); v242) ()
    (* run_target_args'
    let v254 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v255 : string = "format!(\"{:#?}\", $0)"
    let v256 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v255 
    let v257 : string = "fable_library_rust::String_::fromString($0)"
    let v258 : string = Fable.Core.RustInterop.emitRustExpr v256 v257 
    let _run_target_args'_v254 = v258 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v259 : string = "format!(\"{:#?}\", $0)"
    let v260 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v259 
    let v261 : string = "fable_library_rust::String_::fromString($0)"
    let v262 : string = Fable.Core.RustInterop.emitRustExpr v260 v261 
    let _run_target_args'_v254 = v262 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v263 : string = "format!(\"{:#?}\", $0)"
    let v264 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v263 
    let v265 : string = "fable_library_rust::String_::fromString($0)"
    let v266 : string = Fable.Core.RustInterop.emitRustExpr v264 v265 
    let _run_target_args'_v254 = v266 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v268 : string = $"%A{v2}"
    let _run_target_args'_v254 = v268 
    #endif
#if FABLE_COMPILER_PYTHON
    let v272 : string = $"%A{v2}"
    let _run_target_args'_v254 = v272 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v276 : string = $"%A{v2}"
    let _run_target_args'_v254 = v276 
    #endif
#else
    let v280 : string = $"%A{v2}"
    let _run_target_args'_v254 = v280 
    #endif
    let v283 : string = _run_target_args'_v254 
    let v293 : string = $"{v283}"
    let v301 : unit = ()
    let v302 : (unit -> unit) = closure7(v5, v293)
    let v303 : unit = (fun () -> v302 (); v301) ()
    let v310 : string = $"{v124}"
    let v318 : unit = ()
    let v319 : (unit -> unit) = closure7(v5, v310)
    let v320 : unit = (fun () -> v319 (); v318) ()
    let v328 : string = "predecessor_account_id"
    let v329 : string = $"{v328}"
    let v337 : unit = ()
    let v338 : (unit -> unit) = closure7(v5, v329)
    let v339 : unit = (fun () -> v338 (); v337) ()
    let v346 : string = $"{v46}"
    let v354 : unit = ()
    let v355 : (unit -> unit) = closure7(v5, v346)
    let v356 : unit = (fun () -> v355 (); v354) ()
    (* run_target_args'
    let v366 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v367 : string = "format!(\"{:#?}\", $0)"
    let v368 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3 v367 
    let v369 : string = "fable_library_rust::String_::fromString($0)"
    let v370 : string = Fable.Core.RustInterop.emitRustExpr v368 v369 
    let _run_target_args'_v366 = v370 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v371 : string = "format!(\"{:#?}\", $0)"
    let v372 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3 v371 
    let v373 : string = "fable_library_rust::String_::fromString($0)"
    let v374 : string = Fable.Core.RustInterop.emitRustExpr v372 v373 
    let _run_target_args'_v366 = v374 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v375 : string = "format!(\"{:#?}\", $0)"
    let v376 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3 v375 
    let v377 : string = "fable_library_rust::String_::fromString($0)"
    let v378 : string = Fable.Core.RustInterop.emitRustExpr v376 v377 
    let _run_target_args'_v366 = v378 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v380 : string = $"%A{v3}"
    let _run_target_args'_v366 = v380 
    #endif
#if FABLE_COMPILER_PYTHON
    let v384 : string = $"%A{v3}"
    let _run_target_args'_v366 = v384 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v388 : string = $"%A{v3}"
    let _run_target_args'_v366 = v388 
    #endif
#else
    let v392 : string = $"%A{v3}"
    let _run_target_args'_v366 = v392 
    #endif
    let v395 : string = _run_target_args'_v366 
    let v405 : string = $"{v395}"
    let v413 : unit = ()
    let v414 : (unit -> unit) = closure7(v5, v405)
    let v415 : unit = (fun () -> v414 (); v413) ()
    let v423 : string = " }"
    let v424 : string = $"{v423}"
    let v432 : unit = ()
    let v433 : (unit -> unit) = closure7(v5, v424)
    let v434 : unit = (fun () -> v433 (); v432) ()
    let v440 : string = v5.l0
    v440
and method16 (v0 : string) : string =
    let v1 : char list = []
    let v4 : (char list -> (char [])) = List.toArray
    let v5 : (char []) = v4 v1
    let v8 : string = v0.TrimStart v5 
    let v42 : char list = []
    let v44 : char list = '/' :: v42 
    let v48 : char list = ' ' :: v44 
    let v53 : (char list -> (char [])) = List.toArray
    let v54 : (char []) = v53 v48
    let v57 : string = v8.TrimEnd v54 
    v57
and method14 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : std_string_String, v9 : uint64, v10 : std_string_String, v11 : std_string_String) : string =
    let v12 : string = method15(v8, v9, v10, v11)
    let v13 : int64 = v0.l0
    let v16 : string = " "
    let v17 : string = v6 + v16 
    let v21 : string = v17 + v7 
    let v26 : string = " #"
    let v27 : string = v21 + v26 
    let v31 : (int64 -> string) = _.ToString()
    let v32 : string = v31 v13
    let v36 : string = v27 + v32 
    let v40 : string = v36 + v16 
    let v45 : string = "chat_contract.claim_alias"
    let v46 : string = v40 + v45 
    let v51 : string = " / "
    let v52 : string = v46 + v51 
    let v56 : string = v52 + v12 
    method16(v56)
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
and closure2 (v0 : std_string_String, v1 : near_sdk_AccountId, v2 : near_sdk_AccountId, v3 : uint64) () : unit =
    let v18 : unit = ()
    let v19 : (unit -> unit) = closure3()
    let v20 : unit = (fun () -> v19 (); v18) ()
    let struct (v43 : Mut0, v44 : Mut1, v45 : Mut2, v46 : Mut3, v47 : Mut4, v48 : int64 option) = TraceState.trace_state.Value
    let v61 : US0 = v47.l0
    let v62 : bool = v45.l0
    let v63 : bool = v62 = false
    let v66 : bool =
        if v63 then
            false
        else
            let v64 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v61
            let v65 : bool = 1 >= v64
            v65
    let v67 : bool = v66 = false
    let v305 : US6 =
        if v67 then
            US6_1
        else
            let v83 : unit = ()
            let v84 : unit = (fun () -> v19 (); v83) ()
            let struct (v107 : Mut0, v108 : Mut1, v109 : Mut2, v110 : Mut3, v111 : Mut4, v112 : int64 option) = TraceState.trace_state.Value
            let v125 : string = method6(v107, v108, v109, v110, v111, v112)
            let v126 : string = method10()
            let v127 : string = $"v1.to_string()"
            let v128 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v127 
            let v129 : string = $"v2.to_string()"
            let v130 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v129 
            let v131 : string = method14(v107, v108, v109, v110, v111, v112, v125, v126, v0, v3, v128, v130)
            let v146 : unit = ()
            let v147 : unit = (fun () -> v19 (); v146) ()
            let struct (v170 : Mut0, v171 : Mut1, v172 : Mut2, v173 : Mut3, v174 : Mut4, v175 : int64 option) = TraceState.trace_state.Value
            let v190 : unit = ()
            let v191 : (unit -> unit) = closure8(v170)
            let v192 : unit = (fun () -> v191 (); v190) ()
            let v195 : (string -> unit) = closure9()
            (* run_target_args'
            let v196 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v197 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v131 v197 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v198 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v131 v198 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v199 : string = v173.l0
            let v200 : bool = v199 = ""
            let v215 : string =
                if v200 then
                    v131
                else
                    let v201 : bool = v131 = ""
                    if v201 then
                        let v202 : string = v173.l0
                        v202
                    else
                        let v203 : string = v173.l0
                        let v206 : string = "\n"
                        let v207 : string = v203 + v206 
                        let v211 : string = v207 + v131 
                        v211
            (* run_target_args'
            let v220 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v221 : string = "&*$0"
            let v222 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v215 v221 
            let _run_target_args'_v220 = v222 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v223 : string = "&*$0"
            let v224 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v215 v223 
            let _run_target_args'_v220 = v224 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v225 : string = "&*$0"
            let v226 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v215 v225 
            let _run_target_args'_v220 = v226 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v228 : Ref<Str> = v215 |> unbox<Ref<Str>>
            let _run_target_args'_v220 = v228 
            #endif
#if FABLE_COMPILER_PYTHON
            let v232 : Ref<Str> = v215 |> unbox<Ref<Str>>
            let _run_target_args'_v220 = v232 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v236 : Ref<Str> = v215 |> unbox<Ref<Str>>
            let _run_target_args'_v220 = v236 
            #endif
#else
            let v240 : Ref<Str> = v215 |> unbox<Ref<Str>>
            let _run_target_args'_v220 = v240 
            #endif
            let v243 : Ref<Str> = _run_target_args'_v220 
            let v252 : string = $"$0.chars()"
            let v253 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v243 v252 
            let v254 : string = "$0"
            let v255 : _ = Fable.Core.RustInterop.emitRustExpr v253 v254 
            let v256 : string = "$0.collect::<Vec<_>>()"
            let v257 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v255 v256 
            let v258 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v259 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v257 v258 
            let v260 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v261 : bool = Fable.Core.RustInterop.emitRustExpr v259 v260 
            let v262 : string = "x"
            let v263 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v262 
            let v264 : string = "String::from_iter($0)"
            let v265 : std_string_String = Fable.Core.RustInterop.emitRustExpr v263 v264 
            let v266 : string = "true; $0 }).collect::<Vec<_>>()"
            let v267 : bool = Fable.Core.RustInterop.emitRustExpr v265 v266 
            let v268 : string = "_vec_map"
            let v269 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v268 
            let v270 : string = "$0.len()"
            let v271 : unativeint = Fable.Core.RustInterop.emitRustExpr v269 v270 
            let v277 : int32 = v271 |> int32 
            let v287 : string = ""
            let v288 : bool = v131 <> v287 
            let v292 : bool =
                if v288 then
                    let v291 : bool = v277 <= 1
                    v291
                else
                    false
            if v292 then
                v173.l0 <- v215
                ()
            else
                v173.l0 <- v287
                let v293 : string = "true; $0.into_iter().for_each(|x| { //"
                let v294 : bool = Fable.Core.RustInterop.emitRustExpr v269 v293 
                let v295 : string = "x"
                let v296 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v295 
                let v297 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                let v298 : bool = Fable.Core.RustInterop.emitRustExpr v296 v297 
                let v299 : string = $"true"
                let v300 : bool = Fable.Core.RustInterop.emitRustExpr () v299 
                let v301 : string = "true; }); //"
                let v302 : bool = Fable.Core.RustInterop.emitRustExpr () v301 
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v195 v131
            #endif
#if FABLE_COMPILER_PYTHON
            v195 v131
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v195 v131
            #endif
#else
            v195 v131
            #endif
            // run_target_args' is_unit
            let v303 : (string -> unit) = v171.l0
            v303 v131
            US6_0(v170, v171, v172, v173, v174, v175)
    
    ()
and closure11 () (v0 : std_string_String) : US7 =
    US7_0(v0)
and method17 () : (std_string_String -> US7) =
    closure11()
and method18 () : string =
    
    
    
    
    
    let v2 : string = "Warning"
    let v3 : (unit -> string) = v2.ToLower
    let v4 : string = v3 ()
    let v7 : char = v4.[int 0]
    let v8 : string = method11(v7)
    (* run_target_args'
    let v25 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v26 : string = "inline_colorization::color_yellow"
    let v27 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v26 
    (* run_target_args'
    let v32 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v33 : string = "&*$0"
    let v34 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v8 v33 
    let _run_target_args'_v32 = v34 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v35 : string = "&*$0"
    let v36 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v8 v35 
    let _run_target_args'_v32 = v36 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v37 : string = "&*$0"
    let v38 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v8 v37 
    let _run_target_args'_v32 = v38 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v40 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v32 = v40 
    #endif
#if FABLE_COMPILER_PYTHON
    let v44 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v32 = v44 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v48 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v32 = v48 
    #endif
#else
    let v52 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v32 = v52 
    #endif
    let v55 : Ref<Str> = _run_target_args'_v32 
    let v64 : string = "inline_colorization::color_reset"
    let v65 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v64 
    let v66 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v67 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v27, v55, v65) v66 
    let v68 : string = "fable_library_rust::String_::fromString($0)"
    let v69 : string = Fable.Core.RustInterop.emitRustExpr v67 v68 
    let _run_target_args'_v25 = v69 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v70 : string = "inline_colorization::color_yellow"
    let v71 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v70 
    (* run_target_args'
    let v76 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v77 : string = "&*$0"
    let v78 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v8 v77 
    let _run_target_args'_v76 = v78 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v79 : string = "&*$0"
    let v80 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v8 v79 
    let _run_target_args'_v76 = v80 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v81 : string = "&*$0"
    let v82 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v8 v81 
    let _run_target_args'_v76 = v82 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v84 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v76 = v84 
    #endif
#if FABLE_COMPILER_PYTHON
    let v88 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v76 = v88 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v92 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v76 = v92 
    #endif
#else
    let v96 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v76 = v96 
    #endif
    let v99 : Ref<Str> = _run_target_args'_v76 
    let v108 : string = "inline_colorization::color_reset"
    let v109 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v108 
    let v110 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v111 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v71, v99, v109) v110 
    let v112 : string = "fable_library_rust::String_::fromString($0)"
    let v113 : string = Fable.Core.RustInterop.emitRustExpr v111 v112 
    let _run_target_args'_v25 = v113 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v114 : string = "inline_colorization::color_yellow"
    let v115 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v114 
    (* run_target_args'
    let v120 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v121 : string = "&*$0"
    let v122 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v8 v121 
    let _run_target_args'_v120 = v122 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v123 : string = "&*$0"
    let v124 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v8 v123 
    let _run_target_args'_v120 = v124 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v125 : string = "&*$0"
    let v126 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v8 v125 
    let _run_target_args'_v120 = v126 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v128 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v120 = v128 
    #endif
#if FABLE_COMPILER_PYTHON
    let v132 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v120 = v132 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v136 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v120 = v136 
    #endif
#else
    let v140 : Ref<Str> = v8 |> unbox<Ref<Str>>
    let _run_target_args'_v120 = v140 
    #endif
    let v143 : Ref<Str> = _run_target_args'_v120 
    let v152 : string = "inline_colorization::color_reset"
    let v153 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v152 
    let v154 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v155 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v115, v143, v153) v154 
    let v156 : string = "fable_library_rust::String_::fromString($0)"
    let v157 : string = Fable.Core.RustInterop.emitRustExpr v155 v156 
    let _run_target_args'_v25 = v157 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v159 : string = "\u001b[93m"
    let v163 : string = method13()
    let v167 : string = v159 + v8 
    let v171 : string = v167 + v163 
    let _run_target_args'_v25 = v171 
    #endif
#if FABLE_COMPILER_PYTHON
    let v175 : string = "\u001b[93m"
    let v179 : string = method13()
    let v183 : string = v175 + v8 
    let v187 : string = v183 + v179 
    let _run_target_args'_v25 = v187 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v191 : string = "\u001b[93m"
    let v195 : string = method13()
    let v199 : string = v191 + v8 
    let v203 : string = v199 + v195 
    let _run_target_args'_v25 = v203 
    #endif
#else
    let v207 : string = "\u001b[93m"
    let v211 : string = method13()
    let v215 : string = v207 + v8 
    let v219 : string = v215 + v211 
    let _run_target_args'_v25 = v219 
    #endif
    let v222 : string = _run_target_args'_v25 
    v222
and method20 (v0 : string) : string =
    let v1 : string = method12()
    let v2 : Mut3 = {l0 = v1} : Mut3
    let v5 : string = "{ "
    let v6 : string = $"{v5}"
    let v14 : unit = ()
    let v15 : (unit -> unit) = closure7(v2, v6)
    let v16 : unit = (fun () -> v15 (); v14) ()
    let v24 : string = "account_alias"
    let v25 : string = $"{v24}"
    let v33 : unit = ()
    let v34 : (unit -> unit) = closure7(v2, v25)
    let v35 : unit = (fun () -> v34 (); v33) ()
    let v43 : string = " = "
    let v44 : string = $"{v43}"
    let v52 : unit = ()
    let v53 : (unit -> unit) = closure7(v2, v44)
    let v54 : unit = (fun () -> v53 (); v52) ()
    let v61 : string = $"{v0}"
    let v69 : unit = ()
    let v70 : (unit -> unit) = closure7(v2, v61)
    let v71 : unit = (fun () -> v70 (); v69) ()
    let v79 : string = " }"
    let v80 : string = $"{v79}"
    let v88 : unit = ()
    let v89 : (unit -> unit) = closure7(v2, v80)
    let v90 : unit = (fun () -> v89 (); v88) ()
    let v96 : string = v2.l0
    v96
and method19 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : string) : string =
    let v9 : string = method20(v8)
    let v10 : int64 = v0.l0
    let v13 : string = " "
    let v14 : string = v6 + v13 
    let v18 : string = v14 + v7 
    let v23 : string = " #"
    let v24 : string = v18 + v23 
    let v28 : (int64 -> string) = _.ToString()
    let v29 : string = v28 v10
    let v33 : string = v24 + v29 
    let v37 : string = v33 + v13 
    let v42 : string = "chat_contract.claim_alias / alias already claimed"
    let v43 : string = v37 + v42 
    let v48 : string = " / "
    let v49 : string = v43 + v48 
    let v53 : string = v49 + v9 
    method16(v53)
and closure12 (v0 : std_string_String) () : unit =
    let v15 : unit = ()
    let v16 : (unit -> unit) = closure3()
    let v17 : unit = (fun () -> v16 (); v15) ()
    let struct (v40 : Mut0, v41 : Mut1, v42 : Mut2, v43 : Mut3, v44 : Mut4, v45 : int64 option) = TraceState.trace_state.Value
    let v58 : US0 = v44.l0
    let v59 : bool = v42.l0
    let v60 : bool = v59 = false
    let v63 : bool =
        if v60 then
            false
        else
            let v61 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v58
            let v62 : bool = 3 >= v61
            v62
    let v64 : bool = v63 = false
    let v302 : US6 =
        if v64 then
            US6_1
        else
            let v80 : unit = ()
            let v81 : unit = (fun () -> v16 (); v80) ()
            let struct (v104 : Mut0, v105 : Mut1, v106 : Mut2, v107 : Mut3, v108 : Mut4, v109 : int64 option) = TraceState.trace_state.Value
            let v122 : string = method6(v104, v105, v106, v107, v108, v109)
            let v123 : string = method18()
            let v125 : string = $"%A{v0}"
            let v128 : string = method19(v104, v105, v106, v107, v108, v109, v122, v123, v125)
            let v143 : unit = ()
            let v144 : unit = (fun () -> v16 (); v143) ()
            let struct (v167 : Mut0, v168 : Mut1, v169 : Mut2, v170 : Mut3, v171 : Mut4, v172 : int64 option) = TraceState.trace_state.Value
            let v187 : unit = ()
            let v188 : (unit -> unit) = closure8(v167)
            let v189 : unit = (fun () -> v188 (); v187) ()
            let v192 : (string -> unit) = closure9()
            (* run_target_args'
            let v193 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v194 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v128 v194 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v195 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v128 v195 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v196 : string = v170.l0
            let v197 : bool = v196 = ""
            let v212 : string =
                if v197 then
                    v128
                else
                    let v198 : bool = v128 = ""
                    if v198 then
                        let v199 : string = v170.l0
                        v199
                    else
                        let v200 : string = v170.l0
                        let v203 : string = "\n"
                        let v204 : string = v200 + v203 
                        let v208 : string = v204 + v128 
                        v208
            (* run_target_args'
            let v217 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v218 : string = "&*$0"
            let v219 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v212 v218 
            let _run_target_args'_v217 = v219 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v220 : string = "&*$0"
            let v221 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v212 v220 
            let _run_target_args'_v217 = v221 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v222 : string = "&*$0"
            let v223 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v212 v222 
            let _run_target_args'_v217 = v223 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v225 : Ref<Str> = v212 |> unbox<Ref<Str>>
            let _run_target_args'_v217 = v225 
            #endif
#if FABLE_COMPILER_PYTHON
            let v229 : Ref<Str> = v212 |> unbox<Ref<Str>>
            let _run_target_args'_v217 = v229 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v233 : Ref<Str> = v212 |> unbox<Ref<Str>>
            let _run_target_args'_v217 = v233 
            #endif
#else
            let v237 : Ref<Str> = v212 |> unbox<Ref<Str>>
            let _run_target_args'_v217 = v237 
            #endif
            let v240 : Ref<Str> = _run_target_args'_v217 
            let v249 : string = $"$0.chars()"
            let v250 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v240 v249 
            let v251 : string = "$0"
            let v252 : _ = Fable.Core.RustInterop.emitRustExpr v250 v251 
            let v253 : string = "$0.collect::<Vec<_>>()"
            let v254 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v252 v253 
            let v255 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v256 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v254 v255 
            let v257 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v258 : bool = Fable.Core.RustInterop.emitRustExpr v256 v257 
            let v259 : string = "x"
            let v260 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v259 
            let v261 : string = "String::from_iter($0)"
            let v262 : std_string_String = Fable.Core.RustInterop.emitRustExpr v260 v261 
            let v263 : string = "true; $0 }).collect::<Vec<_>>()"
            let v264 : bool = Fable.Core.RustInterop.emitRustExpr v262 v263 
            let v265 : string = "_vec_map"
            let v266 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v265 
            let v267 : string = "$0.len()"
            let v268 : unativeint = Fable.Core.RustInterop.emitRustExpr v266 v267 
            let v274 : int32 = v268 |> int32 
            let v284 : string = ""
            let v285 : bool = v128 <> v284 
            let v289 : bool =
                if v285 then
                    let v288 : bool = v274 <= 1
                    v288
                else
                    false
            if v289 then
                v170.l0 <- v212
                ()
            else
                v170.l0 <- v284
                let v290 : string = "true; $0.into_iter().for_each(|x| { //"
                let v291 : bool = Fable.Core.RustInterop.emitRustExpr v266 v290 
                let v292 : string = "x"
                let v293 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v292 
                let v294 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                let v295 : bool = Fable.Core.RustInterop.emitRustExpr v293 v294 
                let v296 : string = $"true"
                let v297 : bool = Fable.Core.RustInterop.emitRustExpr () v296 
                let v298 : string = "true; }); //"
                let v299 : bool = Fable.Core.RustInterop.emitRustExpr () v298 
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v192 v128
            #endif
#if FABLE_COMPILER_PYTHON
            v192 v128
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v192 v128
            #endif
#else
            v192 v128
            #endif
            // run_target_args' is_unit
            let v300 : (string -> unit) = v168.l0
            v300 v128
            US6_0(v167, v168, v169, v170, v171, v172)
    
    ()
and method21 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : string) : string =
    let v9 : string = method20(v8)
    let v10 : int64 = v0.l0
    let v13 : string = " "
    let v14 : string = v6 + v13 
    let v18 : string = v14 + v7 
    let v23 : string = " #"
    let v24 : string = v18 + v23 
    let v28 : (int64 -> string) = _.ToString()
    let v29 : string = v28 v10
    let v33 : string = v24 + v29 
    let v37 : string = v33 + v13 
    let v42 : string = "chat_contract.claim_alias"
    let v43 : string = v37 + v42 
    let v48 : string = " / "
    let v49 : string = v43 + v48 
    let v53 : string = v49 + v9 
    method16(v53)
and closure13 (v0 : std_string_String option) () : unit =
    let v15 : unit = ()
    let v16 : (unit -> unit) = closure3()
    let v17 : unit = (fun () -> v16 (); v15) ()
    let struct (v40 : Mut0, v41 : Mut1, v42 : Mut2, v43 : Mut3, v44 : Mut4, v45 : int64 option) = TraceState.trace_state.Value
    let v58 : US0 = v44.l0
    let v59 : bool = v42.l0
    let v60 : bool = v59 = false
    let v63 : bool =
        if v60 then
            false
        else
            let v61 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v58
            let v62 : bool = 1 >= v61
            v62
    let v64 : bool = v63 = false
    let v302 : US6 =
        if v64 then
            US6_1
        else
            let v80 : unit = ()
            let v81 : unit = (fun () -> v16 (); v80) ()
            let struct (v104 : Mut0, v105 : Mut1, v106 : Mut2, v107 : Mut3, v108 : Mut4, v109 : int64 option) = TraceState.trace_state.Value
            let v122 : string = method6(v104, v105, v106, v107, v108, v109)
            let v123 : string = method10()
            let v125 : string = $"%A{v0}"
            let v128 : string = method21(v104, v105, v106, v107, v108, v109, v122, v123, v125)
            let v143 : unit = ()
            let v144 : unit = (fun () -> v16 (); v143) ()
            let struct (v167 : Mut0, v168 : Mut1, v169 : Mut2, v170 : Mut3, v171 : Mut4, v172 : int64 option) = TraceState.trace_state.Value
            let v187 : unit = ()
            let v188 : (unit -> unit) = closure8(v167)
            let v189 : unit = (fun () -> v188 (); v187) ()
            let v192 : (string -> unit) = closure9()
            (* run_target_args'
            let v193 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v194 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v128 v194 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v195 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v128 v195 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v196 : string = v170.l0
            let v197 : bool = v196 = ""
            let v212 : string =
                if v197 then
                    v128
                else
                    let v198 : bool = v128 = ""
                    if v198 then
                        let v199 : string = v170.l0
                        v199
                    else
                        let v200 : string = v170.l0
                        let v203 : string = "\n"
                        let v204 : string = v200 + v203 
                        let v208 : string = v204 + v128 
                        v208
            (* run_target_args'
            let v217 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v218 : string = "&*$0"
            let v219 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v212 v218 
            let _run_target_args'_v217 = v219 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v220 : string = "&*$0"
            let v221 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v212 v220 
            let _run_target_args'_v217 = v221 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v222 : string = "&*$0"
            let v223 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v212 v222 
            let _run_target_args'_v217 = v223 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v225 : Ref<Str> = v212 |> unbox<Ref<Str>>
            let _run_target_args'_v217 = v225 
            #endif
#if FABLE_COMPILER_PYTHON
            let v229 : Ref<Str> = v212 |> unbox<Ref<Str>>
            let _run_target_args'_v217 = v229 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v233 : Ref<Str> = v212 |> unbox<Ref<Str>>
            let _run_target_args'_v217 = v233 
            #endif
#else
            let v237 : Ref<Str> = v212 |> unbox<Ref<Str>>
            let _run_target_args'_v217 = v237 
            #endif
            let v240 : Ref<Str> = _run_target_args'_v217 
            let v249 : string = $"$0.chars()"
            let v250 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v240 v249 
            let v251 : string = "$0"
            let v252 : _ = Fable.Core.RustInterop.emitRustExpr v250 v251 
            let v253 : string = "$0.collect::<Vec<_>>()"
            let v254 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v252 v253 
            let v255 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v256 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v254 v255 
            let v257 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v258 : bool = Fable.Core.RustInterop.emitRustExpr v256 v257 
            let v259 : string = "x"
            let v260 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v259 
            let v261 : string = "String::from_iter($0)"
            let v262 : std_string_String = Fable.Core.RustInterop.emitRustExpr v260 v261 
            let v263 : string = "true; $0 }).collect::<Vec<_>>()"
            let v264 : bool = Fable.Core.RustInterop.emitRustExpr v262 v263 
            let v265 : string = "_vec_map"
            let v266 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v265 
            let v267 : string = "$0.len()"
            let v268 : unativeint = Fable.Core.RustInterop.emitRustExpr v266 v267 
            let v274 : int32 = v268 |> int32 
            let v284 : string = ""
            let v285 : bool = v128 <> v284 
            let v289 : bool =
                if v285 then
                    let v288 : bool = v274 <= 1
                    v288
                else
                    false
            if v289 then
                v170.l0 <- v212
                ()
            else
                v170.l0 <- v284
                let v290 : string = "true; $0.into_iter().for_each(|x| { //"
                let v291 : bool = Fable.Core.RustInterop.emitRustExpr v266 v290 
                let v292 : string = "x"
                let v293 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v292 
                let v294 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                let v295 : bool = Fable.Core.RustInterop.emitRustExpr v293 v294 
                let v296 : string = $"true"
                let v297 : bool = Fable.Core.RustInterop.emitRustExpr () v296 
                let v298 : string = "true; }); //"
                let v299 : bool = Fable.Core.RustInterop.emitRustExpr () v298 
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v192 v128
            #endif
#if FABLE_COMPILER_PYTHON
            v192 v128
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v192 v128
            #endif
#else
            v192 v128
            #endif
            // run_target_args' is_unit
            let v300 : (string -> unit) = v168.l0
            v300 v128
            US6_0(v167, v168, v169, v170, v171, v172)
    
    ()
and closure14 () () : unit =
    ()
and method22 () : (unit -> unit) =
    closure14()
and closure15 (v0 : (unit -> unit)) () : unit =
    let v15 : unit = ()
    let v16 : (unit -> unit) = closure3()
    let v17 : unit = (fun () -> v16 (); v15) ()
    let struct (v40 : Mut0, v41 : Mut1, v42 : Mut2, v43 : Mut3, v44 : Mut4, v45 : int64 option) = TraceState.trace_state.Value
    let v58 : US0 = v44.l0
    let v59 : bool = v42.l0
    let v60 : bool = v59 = false
    let v63 : bool =
        if v60 then
            false
        else
            let v61 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v58
            let v62 : bool = 1 >= v61
            v62
    let v64 : bool = v63 = false
    let v296 : US6 =
        if v64 then
            US6_1
        else
            let v80 : unit = ()
            let v81 : unit = (fun () -> v16 (); v80) ()
            let struct (v104 : Mut0, v105 : Mut1, v106 : Mut2, v107 : Mut3, v108 : Mut4, v109 : int64 option) = TraceState.trace_state.Value
            let v122 : string = method6(v104, v105, v106, v107, v108, v109)
            let v123 : string = method10()
            let v138 : unit = ()
            let v139 : unit = (fun () -> v16 (); v138) ()
            let struct (v162 : Mut0, v163 : Mut1, v164 : Mut2, v165 : Mut3, v166 : Mut4, v167 : int64 option) = TraceState.trace_state.Value
            let v182 : unit = ()
            let v183 : (unit -> unit) = closure8(v162)
            let v184 : unit = (fun () -> v183 (); v182) ()
            let v187 : string = ""
            let v188 : (string -> unit) = closure9()
            (* run_target_args'
            let v189 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v190 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v187 v190 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v191 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v187 v191 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v192 : string = v165.l0
            let v193 : bool = v192 = ""
            let v208 : string =
                if v193 then
                    v187
                else
                    let v194 : bool = v187 = ""
                    if v194 then
                        let v195 : string = v165.l0
                        v195
                    else
                        let v196 : string = v165.l0
                        let v199 : string = "\n"
                        let v200 : string = v196 + v199 
                        let v204 : string = v200 + v187 
                        v204
            (* run_target_args'
            let v213 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v214 : string = "&*$0"
            let v215 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v208 v214 
            let _run_target_args'_v213 = v215 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v216 : string = "&*$0"
            let v217 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v208 v216 
            let _run_target_args'_v213 = v217 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v218 : string = "&*$0"
            let v219 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v208 v218 
            let _run_target_args'_v213 = v219 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v221 : Ref<Str> = v208 |> unbox<Ref<Str>>
            let _run_target_args'_v213 = v221 
            #endif
#if FABLE_COMPILER_PYTHON
            let v225 : Ref<Str> = v208 |> unbox<Ref<Str>>
            let _run_target_args'_v213 = v225 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v229 : Ref<Str> = v208 |> unbox<Ref<Str>>
            let _run_target_args'_v213 = v229 
            #endif
#else
            let v233 : Ref<Str> = v208 |> unbox<Ref<Str>>
            let _run_target_args'_v213 = v233 
            #endif
            let v236 : Ref<Str> = _run_target_args'_v213 
            let v245 : string = $"$0.chars()"
            let v246 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v236 v245 
            let v247 : string = "$0"
            let v248 : _ = Fable.Core.RustInterop.emitRustExpr v246 v247 
            let v249 : string = "$0.collect::<Vec<_>>()"
            let v250 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v248 v249 
            let v251 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v252 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v250 v251 
            let v253 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v254 : bool = Fable.Core.RustInterop.emitRustExpr v252 v253 
            let v255 : string = "x"
            let v256 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v255 
            let v257 : string = "String::from_iter($0)"
            let v258 : std_string_String = Fable.Core.RustInterop.emitRustExpr v256 v257 
            let v259 : string = "true; $0 }).collect::<Vec<_>>()"
            let v260 : bool = Fable.Core.RustInterop.emitRustExpr v258 v259 
            let v261 : string = "_vec_map"
            let v262 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v261 
            let v263 : string = "$0.len()"
            let v264 : unativeint = Fable.Core.RustInterop.emitRustExpr v262 v263 
            let v270 : int32 = v264 |> int32 
            let v279 : bool = v187 <> v187 
            let v283 : bool =
                if v279 then
                    let v282 : bool = v270 <= 1
                    v282
                else
                    false
            if v283 then
                v165.l0 <- v208
                ()
            else
                v165.l0 <- v187
                let v284 : string = "true; $0.into_iter().for_each(|x| { //"
                let v285 : bool = Fable.Core.RustInterop.emitRustExpr v262 v284 
                let v286 : string = "x"
                let v287 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v286 
                let v288 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                let v289 : bool = Fable.Core.RustInterop.emitRustExpr v287 v288 
                let v290 : string = $"true"
                let v291 : bool = Fable.Core.RustInterop.emitRustExpr () v290 
                let v292 : string = "true; }); //"
                let v293 : bool = Fable.Core.RustInterop.emitRustExpr () v292 
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v188 v187
            #endif
#if FABLE_COMPILER_PYTHON
            v188 v187
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v188 v187
            #endif
#else
            v188 v187
            #endif
            // run_target_args' is_unit
            let v294 : (string -> unit) = v163.l0
            v294 v187
            US6_0(v162, v163, v164, v165, v166, v167)
    
    ()
and method24 (v0 : near_sdk_AccountId, v1 : struct (std_string_String * uint64 * uint32) option) : string =
    let v2 : string = method12()
    let v3 : Mut3 = {l0 = v2} : Mut3
    let v6 : string = "{ "
    let v7 : string = $"{v6}"
    let v15 : unit = ()
    let v16 : (unit -> unit) = closure7(v3, v7)
    let v17 : unit = (fun () -> v16 (); v15) ()
    let v25 : string = "account_id"
    let v26 : string = $"{v25}"
    let v34 : unit = ()
    let v35 : (unit -> unit) = closure7(v3, v26)
    let v36 : unit = (fun () -> v35 (); v34) ()
    let v44 : string = " = "
    let v45 : string = $"{v44}"
    let v53 : unit = ()
    let v54 : (unit -> unit) = closure7(v3, v45)
    let v55 : unit = (fun () -> v54 (); v53) ()
    (* run_target_args'
    let v65 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v66 : string = "format!(\"{:#?}\", $0)"
    let v67 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v66 
    let v68 : string = "fable_library_rust::String_::fromString($0)"
    let v69 : string = Fable.Core.RustInterop.emitRustExpr v67 v68 
    let _run_target_args'_v65 = v69 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v70 : string = "format!(\"{:#?}\", $0)"
    let v71 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v70 
    let v72 : string = "fable_library_rust::String_::fromString($0)"
    let v73 : string = Fable.Core.RustInterop.emitRustExpr v71 v72 
    let _run_target_args'_v65 = v73 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v74 : string = "format!(\"{:#?}\", $0)"
    let v75 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v74 
    let v76 : string = "fable_library_rust::String_::fromString($0)"
    let v77 : string = Fable.Core.RustInterop.emitRustExpr v75 v76 
    let _run_target_args'_v65 = v77 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v79 : string = $"%A{v0}"
    let _run_target_args'_v65 = v79 
    #endif
#if FABLE_COMPILER_PYTHON
    let v83 : string = $"%A{v0}"
    let _run_target_args'_v65 = v83 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v87 : string = $"%A{v0}"
    let _run_target_args'_v65 = v87 
    #endif
#else
    let v91 : string = $"%A{v0}"
    let _run_target_args'_v65 = v91 
    #endif
    let v94 : string = _run_target_args'_v65 
    let v104 : string = $"{v94}"
    let v112 : unit = ()
    let v113 : (unit -> unit) = closure7(v3, v104)
    let v114 : unit = (fun () -> v113 (); v112) ()
    let v122 : string = "; "
    let v123 : string = $"{v122}"
    let v131 : unit = ()
    let v132 : (unit -> unit) = closure7(v3, v123)
    let v133 : unit = (fun () -> v132 (); v131) ()
    let v141 : string = "result"
    let v142 : string = $"{v141}"
    let v150 : unit = ()
    let v151 : (unit -> unit) = closure7(v3, v142)
    let v152 : unit = (fun () -> v151 (); v150) ()
    let v159 : string = $"{v44}"
    let v167 : unit = ()
    let v168 : (unit -> unit) = closure7(v3, v159)
    let v169 : unit = (fun () -> v168 (); v167) ()
    (* run_target_args'
    let v179 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v180 : string = "format!(\"{:#?}\", $0)"
    let v181 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1 v180 
    let v182 : string = "fable_library_rust::String_::fromString($0)"
    let v183 : string = Fable.Core.RustInterop.emitRustExpr v181 v182 
    let _run_target_args'_v179 = v183 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v184 : string = "format!(\"{:#?}\", $0)"
    let v185 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1 v184 
    let v186 : string = "fable_library_rust::String_::fromString($0)"
    let v187 : string = Fable.Core.RustInterop.emitRustExpr v185 v186 
    let _run_target_args'_v179 = v187 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v188 : string = "format!(\"{:#?}\", $0)"
    let v189 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1 v188 
    let v190 : string = "fable_library_rust::String_::fromString($0)"
    let v191 : string = Fable.Core.RustInterop.emitRustExpr v189 v190 
    let _run_target_args'_v179 = v191 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v193 : string = $"%A{v1}"
    let _run_target_args'_v179 = v193 
    #endif
#if FABLE_COMPILER_PYTHON
    let v197 : string = $"%A{v1}"
    let _run_target_args'_v179 = v197 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v201 : string = $"%A{v1}"
    let _run_target_args'_v179 = v201 
    #endif
#else
    let v205 : string = $"%A{v1}"
    let _run_target_args'_v179 = v205 
    #endif
    let v208 : string = _run_target_args'_v179 
    let v218 : string = $"{v208}"
    let v226 : unit = ()
    let v227 : (unit -> unit) = closure7(v3, v218)
    let v228 : unit = (fun () -> v227 (); v226) ()
    let v236 : string = " }"
    let v237 : string = $"{v236}"
    let v245 : unit = ()
    let v246 : (unit -> unit) = closure7(v3, v237)
    let v247 : unit = (fun () -> v246 (); v245) ()
    let v253 : string = v3.l0
    v253
and method23 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : near_sdk_AccountId, v9 : struct (std_string_String * uint64 * uint32) option) : string =
    let v10 : string = method24(v8, v9)
    let v11 : int64 = v0.l0
    let v14 : string = " "
    let v15 : string = v6 + v14 
    let v19 : string = v15 + v7 
    let v24 : string = " #"
    let v25 : string = v19 + v24 
    let v29 : (int64 -> string) = _.ToString()
    let v30 : string = v29 v11
    let v34 : string = v25 + v30 
    let v38 : string = v34 + v14 
    let v43 : string = "chat_contract.get_account_info"
    let v44 : string = v38 + v43 
    let v49 : string = " / "
    let v50 : string = v44 + v49 
    let v54 : string = v50 + v10 
    method16(v54)
and closure16 (v0 : near_sdk_AccountId, v1 : struct (std_string_String * uint64 * uint32) option) () : unit =
    let v16 : unit = ()
    let v17 : (unit -> unit) = closure3()
    let v18 : unit = (fun () -> v17 (); v16) ()
    let struct (v41 : Mut0, v42 : Mut1, v43 : Mut2, v44 : Mut3, v45 : Mut4, v46 : int64 option) = TraceState.trace_state.Value
    let v59 : US0 = v45.l0
    let v60 : bool = v43.l0
    let v61 : bool = v60 = false
    let v64 : bool =
        if v61 then
            false
        else
            let v62 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v59
            let v63 : bool = 1 >= v62
            v63
    let v65 : bool = v64 = false
    let v299 : US6 =
        if v65 then
            US6_1
        else
            let v81 : unit = ()
            let v82 : unit = (fun () -> v17 (); v81) ()
            let struct (v105 : Mut0, v106 : Mut1, v107 : Mut2, v108 : Mut3, v109 : Mut4, v110 : int64 option) = TraceState.trace_state.Value
            let v123 : string = method6(v105, v106, v107, v108, v109, v110)
            let v124 : string = method10()
            let v125 : string = method23(v105, v106, v107, v108, v109, v110, v123, v124, v0, v1)
            let v140 : unit = ()
            let v141 : unit = (fun () -> v17 (); v140) ()
            let struct (v164 : Mut0, v165 : Mut1, v166 : Mut2, v167 : Mut3, v168 : Mut4, v169 : int64 option) = TraceState.trace_state.Value
            let v184 : unit = ()
            let v185 : (unit -> unit) = closure8(v164)
            let v186 : unit = (fun () -> v185 (); v184) ()
            let v189 : (string -> unit) = closure9()
            (* run_target_args'
            let v190 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v191 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v125 v191 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v192 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v125 v192 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v193 : string = v167.l0
            let v194 : bool = v193 = ""
            let v209 : string =
                if v194 then
                    v125
                else
                    let v195 : bool = v125 = ""
                    if v195 then
                        let v196 : string = v167.l0
                        v196
                    else
                        let v197 : string = v167.l0
                        let v200 : string = "\n"
                        let v201 : string = v197 + v200 
                        let v205 : string = v201 + v125 
                        v205
            (* run_target_args'
            let v214 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v215 : string = "&*$0"
            let v216 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v209 v215 
            let _run_target_args'_v214 = v216 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v217 : string = "&*$0"
            let v218 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v209 v217 
            let _run_target_args'_v214 = v218 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v219 : string = "&*$0"
            let v220 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v209 v219 
            let _run_target_args'_v214 = v220 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v222 : Ref<Str> = v209 |> unbox<Ref<Str>>
            let _run_target_args'_v214 = v222 
            #endif
#if FABLE_COMPILER_PYTHON
            let v226 : Ref<Str> = v209 |> unbox<Ref<Str>>
            let _run_target_args'_v214 = v226 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v230 : Ref<Str> = v209 |> unbox<Ref<Str>>
            let _run_target_args'_v214 = v230 
            #endif
#else
            let v234 : Ref<Str> = v209 |> unbox<Ref<Str>>
            let _run_target_args'_v214 = v234 
            #endif
            let v237 : Ref<Str> = _run_target_args'_v214 
            let v246 : string = $"$0.chars()"
            let v247 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v237 v246 
            let v248 : string = "$0"
            let v249 : _ = Fable.Core.RustInterop.emitRustExpr v247 v248 
            let v250 : string = "$0.collect::<Vec<_>>()"
            let v251 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v249 v250 
            let v252 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v253 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v251 v252 
            let v254 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v255 : bool = Fable.Core.RustInterop.emitRustExpr v253 v254 
            let v256 : string = "x"
            let v257 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v256 
            let v258 : string = "String::from_iter($0)"
            let v259 : std_string_String = Fable.Core.RustInterop.emitRustExpr v257 v258 
            let v260 : string = "true; $0 }).collect::<Vec<_>>()"
            let v261 : bool = Fable.Core.RustInterop.emitRustExpr v259 v260 
            let v262 : string = "_vec_map"
            let v263 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v262 
            let v264 : string = "$0.len()"
            let v265 : unativeint = Fable.Core.RustInterop.emitRustExpr v263 v264 
            let v271 : int32 = v265 |> int32 
            let v281 : string = ""
            let v282 : bool = v125 <> v281 
            let v286 : bool =
                if v282 then
                    let v285 : bool = v271 <= 1
                    v285
                else
                    false
            if v286 then
                v167.l0 <- v209
                ()
            else
                v167.l0 <- v281
                let v287 : string = "true; $0.into_iter().for_each(|x| { //"
                let v288 : bool = Fable.Core.RustInterop.emitRustExpr v263 v287 
                let v289 : string = "x"
                let v290 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v289 
                let v291 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                let v292 : bool = Fable.Core.RustInterop.emitRustExpr v290 v291 
                let v293 : string = $"true"
                let v294 : bool = Fable.Core.RustInterop.emitRustExpr () v293 
                let v295 : string = "true; }); //"
                let v296 : bool = Fable.Core.RustInterop.emitRustExpr () v295 
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v189 v125
            #endif
#if FABLE_COMPILER_PYTHON
            v189 v125
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v189 v125
            #endif
#else
            v189 v125
            #endif
            // run_target_args' is_unit
            let v297 : (string -> unit) = v165.l0
            v297 v125
            US6_0(v164, v165, v166, v167, v168, v169)
    
    ()
and closure17 () () : unit =
    let v14 : unit = ()
    let v15 : (unit -> unit) = closure3()
    let v16 : unit = (fun () -> v15 (); v14) ()
    let struct (v39 : Mut0, v40 : Mut1, v41 : Mut2, v42 : Mut3, v43 : Mut4, v44 : int64 option) = TraceState.trace_state.Value
    let v57 : US0 = v43.l0
    let v58 : bool = v41.l0
    let v59 : bool = v58 = false
    let v62 : bool =
        if v59 then
            false
        else
            let v60 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v57
            let v61 : bool = 1 >= v60
            v61
    let v63 : bool = v62 = false
    let v295 : US6 =
        if v63 then
            US6_1
        else
            let v79 : unit = ()
            let v80 : unit = (fun () -> v15 (); v79) ()
            let struct (v103 : Mut0, v104 : Mut1, v105 : Mut2, v106 : Mut3, v107 : Mut4, v108 : int64 option) = TraceState.trace_state.Value
            let v121 : string = method6(v103, v104, v105, v106, v107, v108)
            let v122 : string = method10()
            let v137 : unit = ()
            let v138 : unit = (fun () -> v15 (); v137) ()
            let struct (v161 : Mut0, v162 : Mut1, v163 : Mut2, v164 : Mut3, v165 : Mut4, v166 : int64 option) = TraceState.trace_state.Value
            let v181 : unit = ()
            let v182 : (unit -> unit) = closure8(v161)
            let v183 : unit = (fun () -> v182 (); v181) ()
            let v186 : string = ""
            let v187 : (string -> unit) = closure9()
            (* run_target_args'
            let v188 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v189 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v186 v189 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v190 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v186 v190 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v191 : string = v164.l0
            let v192 : bool = v191 = ""
            let v207 : string =
                if v192 then
                    v186
                else
                    let v193 : bool = v186 = ""
                    if v193 then
                        let v194 : string = v164.l0
                        v194
                    else
                        let v195 : string = v164.l0
                        let v198 : string = "\n"
                        let v199 : string = v195 + v198 
                        let v203 : string = v199 + v186 
                        v203
            (* run_target_args'
            let v212 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v213 : string = "&*$0"
            let v214 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v207 v213 
            let _run_target_args'_v212 = v214 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v215 : string = "&*$0"
            let v216 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v207 v215 
            let _run_target_args'_v212 = v216 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v217 : string = "&*$0"
            let v218 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v207 v217 
            let _run_target_args'_v212 = v218 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v220 : Ref<Str> = v207 |> unbox<Ref<Str>>
            let _run_target_args'_v212 = v220 
            #endif
#if FABLE_COMPILER_PYTHON
            let v224 : Ref<Str> = v207 |> unbox<Ref<Str>>
            let _run_target_args'_v212 = v224 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v228 : Ref<Str> = v207 |> unbox<Ref<Str>>
            let _run_target_args'_v212 = v228 
            #endif
#else
            let v232 : Ref<Str> = v207 |> unbox<Ref<Str>>
            let _run_target_args'_v212 = v232 
            #endif
            let v235 : Ref<Str> = _run_target_args'_v212 
            let v244 : string = $"$0.chars()"
            let v245 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v235 v244 
            let v246 : string = "$0"
            let v247 : _ = Fable.Core.RustInterop.emitRustExpr v245 v246 
            let v248 : string = "$0.collect::<Vec<_>>()"
            let v249 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v247 v248 
            let v250 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v251 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v249 v250 
            let v252 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v253 : bool = Fable.Core.RustInterop.emitRustExpr v251 v252 
            let v254 : string = "x"
            let v255 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v254 
            let v256 : string = "String::from_iter($0)"
            let v257 : std_string_String = Fable.Core.RustInterop.emitRustExpr v255 v256 
            let v258 : string = "true; $0 }).collect::<Vec<_>>()"
            let v259 : bool = Fable.Core.RustInterop.emitRustExpr v257 v258 
            let v260 : string = "_vec_map"
            let v261 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v260 
            let v262 : string = "$0.len()"
            let v263 : unativeint = Fable.Core.RustInterop.emitRustExpr v261 v262 
            let v269 : int32 = v263 |> int32 
            let v278 : bool = v186 <> v186 
            let v282 : bool =
                if v278 then
                    let v281 : bool = v269 <= 1
                    v281
                else
                    false
            if v282 then
                v164.l0 <- v207
                ()
            else
                v164.l0 <- v186
                let v283 : string = "true; $0.into_iter().for_each(|x| { //"
                let v284 : bool = Fable.Core.RustInterop.emitRustExpr v261 v283 
                let v285 : string = "x"
                let v286 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v285 
                let v287 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                let v288 : bool = Fable.Core.RustInterop.emitRustExpr v286 v287 
                let v289 : string = $"true"
                let v290 : bool = Fable.Core.RustInterop.emitRustExpr () v289 
                let v291 : string = "true; }); //"
                let v292 : bool = Fable.Core.RustInterop.emitRustExpr () v291 
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v187 v186
            #endif
#if FABLE_COMPILER_PYTHON
            v187 v186
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v187 v186
            #endif
#else
            v187 v186
            #endif
            // run_target_args' is_unit
            let v293 : (string -> unit) = v162.l0
            v293 v186
            US6_0(v161, v162, v163, v164, v165, v166)
    
    ()
and method26 (v0 : std_string_String) : string =
    let v1 : string = method12()
    let v2 : Mut3 = {l0 = v1} : Mut3
    let v5 : string = "{ "
    let v6 : string = $"{v5}"
    let v14 : unit = ()
    let v15 : (unit -> unit) = closure7(v2, v6)
    let v16 : unit = (fun () -> v15 (); v14) ()
    let v24 : string = "alias"
    let v25 : string = $"{v24}"
    let v33 : unit = ()
    let v34 : (unit -> unit) = closure7(v2, v25)
    let v35 : unit = (fun () -> v34 (); v33) ()
    let v43 : string = " = "
    let v44 : string = $"{v43}"
    let v52 : unit = ()
    let v53 : (unit -> unit) = closure7(v2, v44)
    let v54 : unit = (fun () -> v53 (); v52) ()
    (* run_target_args'
    let v64 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v65 : string = "format!(\"{:#?}\", $0)"
    let v66 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v65 
    let v67 : string = "fable_library_rust::String_::fromString($0)"
    let v68 : string = Fable.Core.RustInterop.emitRustExpr v66 v67 
    let _run_target_args'_v64 = v68 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v69 : string = "format!(\"{:#?}\", $0)"
    let v70 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v69 
    let v71 : string = "fable_library_rust::String_::fromString($0)"
    let v72 : string = Fable.Core.RustInterop.emitRustExpr v70 v71 
    let _run_target_args'_v64 = v72 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v73 : string = "format!(\"{:#?}\", $0)"
    let v74 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v73 
    let v75 : string = "fable_library_rust::String_::fromString($0)"
    let v76 : string = Fable.Core.RustInterop.emitRustExpr v74 v75 
    let _run_target_args'_v64 = v76 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v78 : string = $"%A{v0}"
    let _run_target_args'_v64 = v78 
    #endif
#if FABLE_COMPILER_PYTHON
    let v82 : string = $"%A{v0}"
    let _run_target_args'_v64 = v82 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v86 : string = $"%A{v0}"
    let _run_target_args'_v64 = v86 
    #endif
#else
    let v90 : string = $"%A{v0}"
    let _run_target_args'_v64 = v90 
    #endif
    let v93 : string = _run_target_args'_v64 
    let v103 : string = $"{v93}"
    let v111 : unit = ()
    let v112 : (unit -> unit) = closure7(v2, v103)
    let v113 : unit = (fun () -> v112 (); v111) ()
    let v121 : string = " }"
    let v122 : string = $"{v121}"
    let v130 : unit = ()
    let v131 : (unit -> unit) = closure7(v2, v122)
    let v132 : unit = (fun () -> v131 (); v130) ()
    let v138 : string = v2.l0
    v138
and method25 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : std_string_String) : string =
    let v9 : string = method26(v8)
    let v10 : int64 = v0.l0
    let v13 : string = " "
    let v14 : string = v6 + v13 
    let v18 : string = v14 + v7 
    let v23 : string = " #"
    let v24 : string = v18 + v23 
    let v28 : (int64 -> string) = _.ToString()
    let v29 : string = v28 v10
    let v33 : string = v24 + v29 
    let v37 : string = v33 + v13 
    let v42 : string = "chat_contract.get_alias_map"
    let v43 : string = v37 + v42 
    let v48 : string = " / "
    let v49 : string = v43 + v48 
    let v53 : string = v49 + v9 
    method16(v53)
and closure18 (v0 : std_string_String) () : unit =
    let v15 : unit = ()
    let v16 : (unit -> unit) = closure3()
    let v17 : unit = (fun () -> v16 (); v15) ()
    let struct (v40 : Mut0, v41 : Mut1, v42 : Mut2, v43 : Mut3, v44 : Mut4, v45 : int64 option) = TraceState.trace_state.Value
    let v58 : US0 = v44.l0
    let v59 : bool = v42.l0
    let v60 : bool = v59 = false
    let v63 : bool =
        if v60 then
            false
        else
            let v61 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v58
            let v62 : bool = 1 >= v61
            v62
    let v64 : bool = v63 = false
    let v298 : US6 =
        if v64 then
            US6_1
        else
            let v80 : unit = ()
            let v81 : unit = (fun () -> v16 (); v80) ()
            let struct (v104 : Mut0, v105 : Mut1, v106 : Mut2, v107 : Mut3, v108 : Mut4, v109 : int64 option) = TraceState.trace_state.Value
            let v122 : string = method6(v104, v105, v106, v107, v108, v109)
            let v123 : string = method10()
            let v124 : string = method25(v104, v105, v106, v107, v108, v109, v122, v123, v0)
            let v139 : unit = ()
            let v140 : unit = (fun () -> v16 (); v139) ()
            let struct (v163 : Mut0, v164 : Mut1, v165 : Mut2, v166 : Mut3, v167 : Mut4, v168 : int64 option) = TraceState.trace_state.Value
            let v183 : unit = ()
            let v184 : (unit -> unit) = closure8(v163)
            let v185 : unit = (fun () -> v184 (); v183) ()
            let v188 : (string -> unit) = closure9()
            (* run_target_args'
            let v189 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v190 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v124 v190 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v191 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v124 v191 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v192 : string = v166.l0
            let v193 : bool = v192 = ""
            let v208 : string =
                if v193 then
                    v124
                else
                    let v194 : bool = v124 = ""
                    if v194 then
                        let v195 : string = v166.l0
                        v195
                    else
                        let v196 : string = v166.l0
                        let v199 : string = "\n"
                        let v200 : string = v196 + v199 
                        let v204 : string = v200 + v124 
                        v204
            (* run_target_args'
            let v213 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v214 : string = "&*$0"
            let v215 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v208 v214 
            let _run_target_args'_v213 = v215 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v216 : string = "&*$0"
            let v217 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v208 v216 
            let _run_target_args'_v213 = v217 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v218 : string = "&*$0"
            let v219 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v208 v218 
            let _run_target_args'_v213 = v219 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v221 : Ref<Str> = v208 |> unbox<Ref<Str>>
            let _run_target_args'_v213 = v221 
            #endif
#if FABLE_COMPILER_PYTHON
            let v225 : Ref<Str> = v208 |> unbox<Ref<Str>>
            let _run_target_args'_v213 = v225 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v229 : Ref<Str> = v208 |> unbox<Ref<Str>>
            let _run_target_args'_v213 = v229 
            #endif
#else
            let v233 : Ref<Str> = v208 |> unbox<Ref<Str>>
            let _run_target_args'_v213 = v233 
            #endif
            let v236 : Ref<Str> = _run_target_args'_v213 
            let v245 : string = $"$0.chars()"
            let v246 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v236 v245 
            let v247 : string = "$0"
            let v248 : _ = Fable.Core.RustInterop.emitRustExpr v246 v247 
            let v249 : string = "$0.collect::<Vec<_>>()"
            let v250 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v248 v249 
            let v251 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v252 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v250 v251 
            let v253 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v254 : bool = Fable.Core.RustInterop.emitRustExpr v252 v253 
            let v255 : string = "x"
            let v256 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v255 
            let v257 : string = "String::from_iter($0)"
            let v258 : std_string_String = Fable.Core.RustInterop.emitRustExpr v256 v257 
            let v259 : string = "true; $0 }).collect::<Vec<_>>()"
            let v260 : bool = Fable.Core.RustInterop.emitRustExpr v258 v259 
            let v261 : string = "_vec_map"
            let v262 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v261 
            let v263 : string = "$0.len()"
            let v264 : unativeint = Fable.Core.RustInterop.emitRustExpr v262 v263 
            let v270 : int32 = v264 |> int32 
            let v280 : string = ""
            let v281 : bool = v124 <> v280 
            let v285 : bool =
                if v281 then
                    let v284 : bool = v270 <= 1
                    v284
                else
                    false
            if v285 then
                v166.l0 <- v208
                ()
            else
                v166.l0 <- v280
                let v286 : string = "true; $0.into_iter().for_each(|x| { //"
                let v287 : bool = Fable.Core.RustInterop.emitRustExpr v262 v286 
                let v288 : string = "x"
                let v289 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v288 
                let v290 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                let v291 : bool = Fable.Core.RustInterop.emitRustExpr v289 v290 
                let v292 : string = $"true"
                let v293 : bool = Fable.Core.RustInterop.emitRustExpr () v292 
                let v294 : string = "true; }); //"
                let v295 : bool = Fable.Core.RustInterop.emitRustExpr () v294 
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v188 v124
            #endif
#if FABLE_COMPILER_PYTHON
            v188 v124
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v188 v124
            #endif
#else
            v188 v124
            #endif
            // run_target_args' is_unit
            let v296 : (string -> unit) = v164.l0
            v296 v124
            US6_0(v163, v164, v165, v166, v167, v168)
    
    ()
and method27 () : (unit -> unit) =
    closure14()
and closure19 (v0 : (unit -> unit)) () : unit =
    let v15 : unit = ()
    let v16 : (unit -> unit) = closure3()
    let v17 : unit = (fun () -> v16 (); v15) ()
    let struct (v40 : Mut0, v41 : Mut1, v42 : Mut2, v43 : Mut3, v44 : Mut4, v45 : int64 option) = TraceState.trace_state.Value
    let v58 : US0 = v44.l0
    let v59 : bool = v42.l0
    let v60 : bool = v59 = false
    let v63 : bool =
        if v60 then
            false
        else
            let v61 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v58
            let v62 : bool = 1 >= v61
            v62
    let v64 : bool = v63 = false
    let v296 : US6 =
        if v64 then
            US6_1
        else
            let v80 : unit = ()
            let v81 : unit = (fun () -> v16 (); v80) ()
            let struct (v104 : Mut0, v105 : Mut1, v106 : Mut2, v107 : Mut3, v108 : Mut4, v109 : int64 option) = TraceState.trace_state.Value
            let v122 : string = method6(v104, v105, v106, v107, v108, v109)
            let v123 : string = method10()
            let v138 : unit = ()
            let v139 : unit = (fun () -> v16 (); v138) ()
            let struct (v162 : Mut0, v163 : Mut1, v164 : Mut2, v165 : Mut3, v166 : Mut4, v167 : int64 option) = TraceState.trace_state.Value
            let v182 : unit = ()
            let v183 : (unit -> unit) = closure8(v162)
            let v184 : unit = (fun () -> v183 (); v182) ()
            let v187 : string = ""
            let v188 : (string -> unit) = closure9()
            (* run_target_args'
            let v189 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v190 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v187 v190 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v191 : string = @"println!(""{}"", $0)"
            Fable.Core.RustInterop.emitRustExpr v187 v191 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v192 : string = v165.l0
            let v193 : bool = v192 = ""
            let v208 : string =
                if v193 then
                    v187
                else
                    let v194 : bool = v187 = ""
                    if v194 then
                        let v195 : string = v165.l0
                        v195
                    else
                        let v196 : string = v165.l0
                        let v199 : string = "\n"
                        let v200 : string = v196 + v199 
                        let v204 : string = v200 + v187 
                        v204
            (* run_target_args'
            let v213 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v214 : string = "&*$0"
            let v215 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v208 v214 
            let _run_target_args'_v213 = v215 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v216 : string = "&*$0"
            let v217 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v208 v216 
            let _run_target_args'_v213 = v217 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v218 : string = "&*$0"
            let v219 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v208 v218 
            let _run_target_args'_v213 = v219 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v221 : Ref<Str> = v208 |> unbox<Ref<Str>>
            let _run_target_args'_v213 = v221 
            #endif
#if FABLE_COMPILER_PYTHON
            let v225 : Ref<Str> = v208 |> unbox<Ref<Str>>
            let _run_target_args'_v213 = v225 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v229 : Ref<Str> = v208 |> unbox<Ref<Str>>
            let _run_target_args'_v213 = v229 
            #endif
#else
            let v233 : Ref<Str> = v208 |> unbox<Ref<Str>>
            let _run_target_args'_v213 = v233 
            #endif
            let v236 : Ref<Str> = _run_target_args'_v213 
            let v245 : string = $"$0.chars()"
            let v246 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v236 v245 
            let v247 : string = "$0"
            let v248 : _ = Fable.Core.RustInterop.emitRustExpr v246 v247 
            let v249 : string = "$0.collect::<Vec<_>>()"
            let v250 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v248 v249 
            let v251 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
            let v252 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v250 v251 
            let v253 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v254 : bool = Fable.Core.RustInterop.emitRustExpr v252 v253 
            let v255 : string = "x"
            let v256 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v255 
            let v257 : string = "String::from_iter($0)"
            let v258 : std_string_String = Fable.Core.RustInterop.emitRustExpr v256 v257 
            let v259 : string = "true; $0 }).collect::<Vec<_>>()"
            let v260 : bool = Fable.Core.RustInterop.emitRustExpr v258 v259 
            let v261 : string = "_vec_map"
            let v262 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v261 
            let v263 : string = "$0.len()"
            let v264 : unativeint = Fable.Core.RustInterop.emitRustExpr v262 v263 
            let v270 : int32 = v264 |> int32 
            let v279 : bool = v187 <> v187 
            let v283 : bool =
                if v279 then
                    let v282 : bool = v270 <= 1
                    v282
                else
                    false
            if v283 then
                v165.l0 <- v208
                ()
            else
                v165.l0 <- v187
                let v284 : string = "true; $0.into_iter().for_each(|x| { //"
                let v285 : bool = Fable.Core.RustInterop.emitRustExpr v262 v284 
                let v286 : string = "x"
                let v287 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v286 
                let v288 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
                let v289 : bool = Fable.Core.RustInterop.emitRustExpr v287 v288 
                let v290 : string = $"true"
                let v291 : bool = Fable.Core.RustInterop.emitRustExpr () v290 
                let v292 : string = "true; }); //"
                let v293 : bool = Fable.Core.RustInterop.emitRustExpr () v292 
                ()
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            v188 v187
            #endif
#if FABLE_COMPILER_PYTHON
            v188 v187
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            v188 v187
            #endif
#else
            v188 v187
            #endif
            // run_target_args' is_unit
            let v294 : (string -> unit) = v163.l0
            v294 v187
            US6_0(v162, v163, v164, v165, v166, v167)
    
    ()
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
    let v122 : bool =
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
                        let v111 : string = $"$0.chars()"
                        let v112 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v102 v111 
                        let v113 : string = "true; // 1"
                        let v114 : bool = Fable.Core.RustInterop.emitRustExpr () v113 
                        let v115 : string = "let mut v112 = v112"
                        Fable.Core.RustInterop.emitRustExpr () v115 
                        let v116 : string = $"v112.all(|x| $0(x))"
                        let v117 : (char -> bool) = closure1()
                        let v118 : bool = Fable.Core.RustInterop.emitRustExpr v117 v116 
                        v118
                    else
                        false
                else
                    false
            else
                false
        else
            false
    let _result = v122 in _result |> (fun x -> Fable.Core.RustInterop.emitRustExpr x "$0 }") // 2
    let v123 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v123 
    let v124 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v124 
    let v125 : string = "true; // ??? / i: 2uy / i': 1uy / acc: 2uy / n: 1uy"
    let v126 : bool = Fable.Core.RustInterop.emitRustExpr () v125 
    let v127 : string = "true; */ // ???? / i: 2uy / i': 2uy / acc: 2uy / n: 1uy"
    let v128 : bool = Fable.Core.RustInterop.emitRustExpr () v127 
    let v129 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v129 
    let v130 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v130 
    let v131 : string = "pub fn generate_cid( //"
    Fable.Core.RustInterop.emitRustExpr () v131 
    let v132 : string = "  &self, //"
    Fable.Core.RustInterop.emitRustExpr () v132 
    let v133 : string = "  content: Vec<u8>, //"
    Fable.Core.RustInterop.emitRustExpr () v133 
    let v134 : string = ") -> String { //"
    Fable.Core.RustInterop.emitRustExpr () v134 
    let v135 : string = $"content"
    let v136 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v135 
    let v137 : string = "  fn encode_u64(value: u64) -> Vec<u8> { //"
    Fable.Core.RustInterop.emitRustExpr () v137 
    let v138 : string = "    let mut buffer = unsigned_varint::encode::u64_buffer(); //"
    Fable.Core.RustInterop.emitRustExpr () v138 
    let v139 : string = "    unsigned_varint::encode::u64(value, &mut buffer).to_vec() //"
    Fable.Core.RustInterop.emitRustExpr () v139 
    let v140 : string = "  } //"
    Fable.Core.RustInterop.emitRustExpr () v140 
    let v141 : string = "  fn sha256_hash(content: &[u8]) -> Vec<u8> { //"
    Fable.Core.RustInterop.emitRustExpr () v141 
    let v142 : string = "    let mut hasher: sha2::Sha256 = sha2::Digest::new(); //"
    Fable.Core.RustInterop.emitRustExpr () v142 
    let v143 : string = "    sha2::Digest::update(&mut hasher, content); //"
    Fable.Core.RustInterop.emitRustExpr () v143 
    let v144 : string = "    sha2::Digest::finalize(hasher).to_vec() //"
    Fable.Core.RustInterop.emitRustExpr () v144 
    let v145 : string = "  } //"
    Fable.Core.RustInterop.emitRustExpr () v145 
    let v146 : string = "  let version: u8 = 1; //"
    Fable.Core.RustInterop.emitRustExpr () v146 
    let v147 : string = "  let codec_raw: u64 = 0x55; //"
    Fable.Core.RustInterop.emitRustExpr () v147 
    let v148 : string = "  let codec_bytes = encode_u64(codec_raw); //"
    Fable.Core.RustInterop.emitRustExpr () v148 
    let v149 : string = "  let hash_result = sha256_hash(&v136); //"
    Fable.Core.RustInterop.emitRustExpr () v149 
    let v150 : string = "  let multihash = std::iter::once(0x12) //"
    Fable.Core.RustInterop.emitRustExpr () v150 
    let v151 : string = "    .chain(std::iter::once(32)) //"
    Fable.Core.RustInterop.emitRustExpr () v151 
    let v152 : string = "    .chain(hash_result.into_iter()) //"
    Fable.Core.RustInterop.emitRustExpr () v152 
    let v153 : string = "    .collect(); //"
    Fable.Core.RustInterop.emitRustExpr () v153 
    let v154 : string = "  let cid_bytes = [vec![version], codec_bytes, multihash].concat(); //"
    Fable.Core.RustInterop.emitRustExpr () v154 
    let v155 : string = "  let result = multibase::encode(multibase::Base::Base32Lower, &cid_bytes); //"
    Fable.Core.RustInterop.emitRustExpr () v155 
    let v156 : string = "result"
    let v157 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v156 
    let _result = v157 in _result |> (fun x -> Fable.Core.RustInterop.emitRustExpr x "$0 }") // 2
    let v158 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v158 
    let v159 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v159 
    let v160 : string = "true; // ??? / i: 3uy / i': 1uy / acc: 3uy / n: 2uy"
    let v161 : bool = Fable.Core.RustInterop.emitRustExpr () v160 
    let v162 : string = "true; */ // ???? / i: 3uy / i': 2uy / acc: 3uy / n: 2uy"
    let v163 : bool = Fable.Core.RustInterop.emitRustExpr () v162 
    let v164 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v164 
    let v165 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v165 
    let v166 : string = "#[result_serializer(borsh)] //"
    Fable.Core.RustInterop.emitRustExpr () v166 
    let v167 : string = "pub fn generate_cid_borsh( //"
    Fable.Core.RustInterop.emitRustExpr () v167 
    let v168 : string = "  &self, //"
    Fable.Core.RustInterop.emitRustExpr () v168 
    let v169 : string = "  #[serializer(borsh)] content: Vec<u8>, //"
    Fable.Core.RustInterop.emitRustExpr () v169 
    let v170 : string = ") -> String { //"
    Fable.Core.RustInterop.emitRustExpr () v170 
    let v171 : string = "  self.generate_cid(content) //"
    Fable.Core.RustInterop.emitRustExpr () v171 
    let v172 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v172 
    let v173 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v173 
    let v174 : string = "true; // ??? / i: 4uy / i': 1uy / acc: 5uy / n: 1uy"
    let v175 : bool = Fable.Core.RustInterop.emitRustExpr () v174 
    let v176 : string = "true; */ // ???? / i: 4uy / i': 2uy / acc: 5uy / n: 1uy"
    let v177 : bool = Fable.Core.RustInterop.emitRustExpr () v176 
    let v178 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v178 
    let v179 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v179 
    let v180 : string = "pub fn claim_alias( //"
    Fable.Core.RustInterop.emitRustExpr () v180 
    let v181 : string = "  &mut self, //"
    Fable.Core.RustInterop.emitRustExpr () v181 
    let v182 : string = "  alias: String, //"
    Fable.Core.RustInterop.emitRustExpr () v182 
    let v183 : string = ") { //"
    Fable.Core.RustInterop.emitRustExpr () v183 
    let v184 : string = $"&mut self.0"
    let v185 : Ref<Mut<struct (uint32 * near_sdk_store_IterableSet<near_sdk_AccountId> * near_sdk_store_IterableSet<std_string_String> * near_sdk_store_LookupMap<near_sdk_AccountId, std_string_String> * near_sdk_store_LookupMap<std_string_String, std_collections_HashMap<near_sdk_AccountId, struct (uint64 * uint32)>>)>> = Fable.Core.RustInterop.emitRustExpr () v184 
    let v186 : string = $"alias"
    let v187 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v186 
    let v188 : string = $"&mut v185.1"
    let v189 : Ref<Mut<near_sdk_store_IterableSet<near_sdk_AccountId>>> = Fable.Core.RustInterop.emitRustExpr () v188 
    let v190 : string = $"&mut v185.2"
    let v191 : Ref<Mut<near_sdk_store_IterableSet<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr () v190 
    let v192 : string = $"&mut v185.3"
    let v193 : Ref<Mut<near_sdk_store_LookupMap<near_sdk_AccountId, std_string_String>>> = Fable.Core.RustInterop.emitRustExpr () v192 
    let v194 : string = $"&mut v185.4"
    let v195 : Ref<Mut<near_sdk_store_LookupMap<std_string_String, std_collections_HashMap<near_sdk_AccountId, struct (uint64 * uint32)>>>> = Fable.Core.RustInterop.emitRustExpr () v194 
    let v196 : string = $"near_sdk::env::signer_account_id()"
    let v197 : near_sdk_AccountId = Fable.Core.RustInterop.emitRustExpr () v196 
    let v198 : string = $"near_sdk::env::predecessor_account_id()"
    let v199 : near_sdk_AccountId = Fable.Core.RustInterop.emitRustExpr () v198 
    let v200 : string = $"near_sdk::env::block_timestamp()"
    let v201 : uint64 = Fable.Core.RustInterop.emitRustExpr () v200 
    let v517 : unit = ()
    let v518 : (unit -> unit) = closure2(v187, v197, v199, v201)
    let v519 : unit = (fun () -> v518 (); v517) ()
    let v838 : string = "fable_library_rust::String_::fromString($0)"
    let v839 : string = Fable.Core.RustInterop.emitRustExpr v187 v838 
    let v840 : int32 = v839.Length
    let v841 : bool = v840 > 0
    let v902 : bool =
        if v841 then
            let v842 : bool = v840 < 64
            if v842 then
                let v845 : string = "-"
                let v846 : bool = v839.StartsWith (v845, false, null)
                let v849 : bool = v846 = false
                if v849 then
                    let v851 : bool = v839.EndsWith (v845, false, null)
                    let v854 : bool = v851 = false
                    if v854 then
                        (* run_target_args'
                        let v859 : unit = ()
                        run_target_args' *)
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v860 : string = "&*$0"
                        let v861 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v839 v860 
                        let _run_target_args'_v859 = v861 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        let v862 : string = "&*$0"
                        let v863 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v839 v862 
                        let _run_target_args'_v859 = v863 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        let v864 : string = "&*$0"
                        let v865 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v839 v864 
                        let _run_target_args'_v859 = v865 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        let v867 : Ref<Str> = v839 |> unbox<Ref<Str>>
                        let _run_target_args'_v859 = v867 
                        #endif
#if FABLE_COMPILER_PYTHON
                        let v871 : Ref<Str> = v839 |> unbox<Ref<Str>>
                        let _run_target_args'_v859 = v871 
                        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                        let v875 : Ref<Str> = v839 |> unbox<Ref<Str>>
                        let _run_target_args'_v859 = v875 
                        #endif
#else
                        let v879 : Ref<Str> = v839 |> unbox<Ref<Str>>
                        let _run_target_args'_v859 = v879 
                        #endif
                        let v882 : Ref<Str> = _run_target_args'_v859 
                        let v891 : string = $"$0.chars()"
                        let v892 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v882 v891 
                        let v893 : string = "true; // 1"
                        let v894 : bool = Fable.Core.RustInterop.emitRustExpr () v893 
                        let v895 : string = "let mut v892 = v892"
                        Fable.Core.RustInterop.emitRustExpr () v895 
                        let v896 : string = $"v892.all(|x| $0(x))"
                        let v897 : (char -> bool) = closure1()
                        let v898 : bool = Fable.Core.RustInterop.emitRustExpr v897 v896 
                        v898
                    else
                        false
                else
                    false
            else
                false
        else
            false
    let v903 : bool = v902 = false
    let v907 : bool =
        if v903 then
            let v904 : string = $"true; near_sdk::env::panic_str(&*$0); //"
            let v905 : string = "chat_contract.claim_alias / invalid alias"
            let v906 : bool = Fable.Core.RustInterop.emitRustExpr v905 v904 
            true
        else
            false
    let v908 : string = $"v193.get(&$0)"
    let v909 : Ref<std_string_String> option = Fable.Core.RustInterop.emitRustExpr v197 v908 
    let v910 : string = "$0.cloned()"
    let v911 : std_string_String option = Fable.Core.RustInterop.emitRustExpr v909 v910 
    let v914 : (std_string_String -> US7) = method17()
    let v915 : US7 option = v911 |> Option.map v914 
    let v935 : US7 = US7_1
    let v936 : US7 = v915 |> Option.defaultValue v935 
    match v936 with
    | US7_0(v940) -> (* Some *)
        let v942 : bool = v940 = v187 
        if v942 then
            let v1260 : unit = ()
            let v1261 : (unit -> unit) = closure12(v940)
            let v1262 : unit = (fun () -> v1261 (); v1260) ()
            ()
        else
            let v1896 : unit = ()
            let v1897 : (unit -> unit) = closure13(v911)
            let v1898 : unit = (fun () -> v1897 (); v1896) ()
            let v2217 : string = "    v195 //"
            Fable.Core.RustInterop.emitRustExpr () v2217 
            let v2218 : string = "      .get_mut(&v940) //"
            Fable.Core.RustInterop.emitRustExpr () v2218 
            let v2219 : string = "      .unwrap() //"
            Fable.Core.RustInterop.emitRustExpr () v2219 
            let v2220 : string = "      .remove(&$0); //"
            Fable.Core.RustInterop.emitRustExpr v197 v2220 
            let v2221 : string = "  v193.insert($0.clone(), $1.clone()); //"
            Fable.Core.RustInterop.emitRustExpr struct (v197, v187) v2221 
            let v2222 : string = $"v189.insert($0)"
            let v2223 : bool = Fable.Core.RustInterop.emitRustExpr v197 v2222 
            let v2224 : string = $"v191.insert($0)"
            let v2225 : bool = Fable.Core.RustInterop.emitRustExpr v187 v2224 
            let v2226 : string = "  let new_alias_account_map = match v195.get(&$0) { //"
            Fable.Core.RustInterop.emitRustExpr v187 v2226 
            let v2227 : string = "    None => { //"
            Fable.Core.RustInterop.emitRustExpr () v2227 
            let v2228 : string = "      let mut new_map = std::collections::HashMap::new(); //"
            Fable.Core.RustInterop.emitRustExpr () v2228 
            let v2229 : string = "      new_map.insert($0, ($1, 0u32)); //"
            Fable.Core.RustInterop.emitRustExpr struct (v197, v201) v2229 
            let v2230 : string = "      new_map //"
            Fable.Core.RustInterop.emitRustExpr () v2230 
            let v2231 : string = "    } //"
            Fable.Core.RustInterop.emitRustExpr () v2231 
            let v2232 : string = "    Some(accounts) => { //"
            Fable.Core.RustInterop.emitRustExpr () v2232 
            let v2233 : string = "      let mut accounts_vec = accounts.iter().collect::<Vec<_>>(); //"
            Fable.Core.RustInterop.emitRustExpr () v2233 
            let v2234 : string = "      accounts_vec.sort_unstable_by_key(|(_, (_, index))| index); //"
            Fable.Core.RustInterop.emitRustExpr () v2234 
            let v2235 : string = "      let mut new_map = accounts_vec //"
            Fable.Core.RustInterop.emitRustExpr () v2235 
            let v2236 : string = "        .iter() //"
            Fable.Core.RustInterop.emitRustExpr () v2236 
            let v2237 : string = "        .enumerate() //"
            Fable.Core.RustInterop.emitRustExpr () v2237 
            let v2238 : string = "        .map(|(i, (signer_account_id, (timestamp, _)))| { //"
            Fable.Core.RustInterop.emitRustExpr () v2238 
            let v2239 : string = "          ((*signer_account_id).clone(), (*timestamp, i as u32)) //"
            Fable.Core.RustInterop.emitRustExpr () v2239 
            let v2240 : string = "        }) //"
            Fable.Core.RustInterop.emitRustExpr () v2240 
            let v2241 : string = "        .collect::<std::collections::HashMap<_, _>>(); //"
            Fable.Core.RustInterop.emitRustExpr () v2241 
            let v2242 : string = "      new_map.insert($0, (v201, accounts_vec.len() as u32)); //"
            Fable.Core.RustInterop.emitRustExpr v197 v2242 
            let v2243 : string = "      new_map //"
            Fable.Core.RustInterop.emitRustExpr () v2243 
            let v2244 : string = "    } //"
            Fable.Core.RustInterop.emitRustExpr () v2244 
            let v2245 : string = "  }; //"
            Fable.Core.RustInterop.emitRustExpr () v2245 
            let v2246 : string = "  v195.insert($0, new_alias_account_map); //"
            Fable.Core.RustInterop.emitRustExpr v187 v2246 
            ()
    | _ ->
        let v2562 : unit = ()
        let v2563 : (unit -> unit) = closure13(v911)
        let v2564 : unit = (fun () -> v2563 (); v2562) ()
        match v936 with
        | US7_1 -> (* None *)
            ()
        let v2883 : string = "  v193.insert($0.clone(), $1.clone()); //"
        Fable.Core.RustInterop.emitRustExpr struct (v197, v187) v2883 
        let v2884 : string = $"v189.insert($0)"
        let v2885 : bool = Fable.Core.RustInterop.emitRustExpr v197 v2884 
        let v2886 : string = $"v191.insert($0)"
        let v2887 : bool = Fable.Core.RustInterop.emitRustExpr v187 v2886 
        let v2888 : string = "  let new_alias_account_map = match v195.get(&$0) { //"
        Fable.Core.RustInterop.emitRustExpr v187 v2888 
        let v2889 : string = "    None => { //"
        Fable.Core.RustInterop.emitRustExpr () v2889 
        let v2890 : string = "      let mut new_map = std::collections::HashMap::new(); //"
        Fable.Core.RustInterop.emitRustExpr () v2890 
        let v2891 : string = "      new_map.insert($0, ($1, 0u32)); //"
        Fable.Core.RustInterop.emitRustExpr struct (v197, v201) v2891 
        let v2892 : string = "      new_map //"
        Fable.Core.RustInterop.emitRustExpr () v2892 
        let v2893 : string = "    } //"
        Fable.Core.RustInterop.emitRustExpr () v2893 
        let v2894 : string = "    Some(accounts) => { //"
        Fable.Core.RustInterop.emitRustExpr () v2894 
        let v2895 : string = "      let mut accounts_vec = accounts.iter().collect::<Vec<_>>(); //"
        Fable.Core.RustInterop.emitRustExpr () v2895 
        let v2896 : string = "      accounts_vec.sort_unstable_by_key(|(_, (_, index))| index); //"
        Fable.Core.RustInterop.emitRustExpr () v2896 
        let v2897 : string = "      let mut new_map = accounts_vec //"
        Fable.Core.RustInterop.emitRustExpr () v2897 
        let v2898 : string = "        .iter() //"
        Fable.Core.RustInterop.emitRustExpr () v2898 
        let v2899 : string = "        .enumerate() //"
        Fable.Core.RustInterop.emitRustExpr () v2899 
        let v2900 : string = "        .map(|(i, (signer_account_id, (timestamp, _)))| { //"
        Fable.Core.RustInterop.emitRustExpr () v2900 
        let v2901 : string = "          ((*signer_account_id).clone(), (*timestamp, i as u32)) //"
        Fable.Core.RustInterop.emitRustExpr () v2901 
        let v2902 : string = "        }) //"
        Fable.Core.RustInterop.emitRustExpr () v2902 
        let v2903 : string = "        .collect::<std::collections::HashMap<_, _>>(); //"
        Fable.Core.RustInterop.emitRustExpr () v2903 
        let v2904 : string = "      new_map.insert($0, (v201, accounts_vec.len() as u32)); //"
        Fable.Core.RustInterop.emitRustExpr v197 v2904 
        let v2905 : string = "      new_map //"
        Fable.Core.RustInterop.emitRustExpr () v2905 
        let v2906 : string = "    } //"
        Fable.Core.RustInterop.emitRustExpr () v2906 
        let v2907 : string = "  }; //"
        Fable.Core.RustInterop.emitRustExpr () v2907 
        let v2908 : string = "  v195.insert($0, new_alias_account_map); //"
        Fable.Core.RustInterop.emitRustExpr v187 v2908 
        ()
    let v2909 : (unit -> unit) = method22()
    let v3219 : unit = ()
    let v3220 : (unit -> unit) = closure15(v2909)
    let v3221 : unit = (fun () -> v3220 (); v3219) ()
    let v3534 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v3534 
    let v3535 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v3535 
    let v3536 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v3536 
    let v3537 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v3537 
    let v3538 : string = "true; // ??? / i: 5uy / i': 1uy / acc: 6uy / n: 3uy"
    let v3539 : bool = Fable.Core.RustInterop.emitRustExpr () v3538 
    let v3540 : string = "true; */ // ???? / i: 5uy / i': 2uy / acc: 6uy / n: 3uy"
    let v3541 : bool = Fable.Core.RustInterop.emitRustExpr () v3540 
    let v3542 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v3542 
    let v3543 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v3543 
    let v3544 : string = "pub fn get_account_info( //"
    Fable.Core.RustInterop.emitRustExpr () v3544 
    let v3545 : string = "  &self, //"
    Fable.Core.RustInterop.emitRustExpr () v3545 
    let v3546 : string = "  account_id: near_sdk::AccountId, //"
    Fable.Core.RustInterop.emitRustExpr () v3546 
    let v3547 : string = ") -> Option<(String, u64, u32)> { //"
    Fable.Core.RustInterop.emitRustExpr () v3547 
    let v3548 : string = $"&self.0"
    let v3549 : Ref<struct (uint32 * near_sdk_store_IterableSet<near_sdk_AccountId> * near_sdk_store_IterableSet<std_string_String> * near_sdk_store_LookupMap<near_sdk_AccountId, std_string_String> * near_sdk_store_LookupMap<std_string_String, std_collections_HashMap<near_sdk_AccountId, struct (uint64 * uint32)>>)> = Fable.Core.RustInterop.emitRustExpr () v3548 
    let v3550 : string = $"account_id"
    let v3551 : near_sdk_AccountId = Fable.Core.RustInterop.emitRustExpr () v3550 
    let v3552 : string = $"&v3549.3"
    let v3553 : Ref<near_sdk_store_LookupMap<near_sdk_AccountId, std_string_String>> = Fable.Core.RustInterop.emitRustExpr () v3552 
    let v3554 : string = $"&v3549.4"
    let v3555 : Ref<near_sdk_store_LookupMap<std_string_String, std_collections_HashMap<near_sdk_AccountId, struct (uint64 * uint32)>>> = Fable.Core.RustInterop.emitRustExpr () v3554 
    let v3556 : string = "true; let result = v3553.get(&$0).and_then(|alias| { //"
    let v3557 : bool = Fable.Core.RustInterop.emitRustExpr v3551 v3556 
    let v3558 : string = "true;    v3555.get(alias).map(|accounts| { //"
    let v3559 : bool = Fable.Core.RustInterop.emitRustExpr () v3558 
    let v3560 : string = "true;        let result = (alias.clone(), *accounts.get(&v3551).unwrap()); //"
    let v3561 : bool = Fable.Core.RustInterop.emitRustExpr () v3560 
    let v3562 : string = "true;        (result.0, result.1.0, result.1.1)  }) }); //"
    let v3563 : bool = Fable.Core.RustInterop.emitRustExpr () v3562 
    let v3564 : string = "result"
    let v3565 : struct (std_string_String * uint64 * uint32) option = Fable.Core.RustInterop.emitRustExpr () v3564 
    let v3877 : unit = ()
    let v3878 : (unit -> unit) = closure16(v3551, v3565)
    let v3879 : unit = (fun () -> v3878 (); v3877) ()
    let v4503 : unit = ()
    let v4504 : (unit -> unit) = closure17()
    let v4505 : unit = (fun () -> v4504 (); v4503) ()
    let _result = v3565 in _result |> (fun x -> Fable.Core.RustInterop.emitRustExpr x "$0 } // 4") // 3
    let v4818 : string = "} // 1"
    Fable.Core.RustInterop.emitRustExpr () v4818 
    let v4819 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v4819 
    let v4820 : string = "true; // ??? / i: 6uy / i': 1uy / acc: 9uy / n: 1uy"
    let v4821 : bool = Fable.Core.RustInterop.emitRustExpr () v4820 
    let v4822 : string = "true; */ // ???? / i: 6uy / i': 2uy / acc: 9uy / n: 1uy"
    let v4823 : bool = Fable.Core.RustInterop.emitRustExpr () v4822 
    let v4824 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v4824 
    let v4825 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v4825 
    let v4826 : string = "pub fn get_alias_map( //"
    Fable.Core.RustInterop.emitRustExpr () v4826 
    let v4827 : string = "  &self, //"
    Fable.Core.RustInterop.emitRustExpr () v4827 
    let v4828 : string = "  alias: String, //"
    Fable.Core.RustInterop.emitRustExpr () v4828 
    let v4829 : string = ") -> Option<std::collections::HashMap<near_sdk::AccountId, (u64, u32)>> { //"
    Fable.Core.RustInterop.emitRustExpr () v4829 
    let v4830 : string = $"&self.0.4"
    let v4831 : Ref<near_sdk_store_LookupMap<std_string_String, std_collections_HashMap<near_sdk_AccountId, struct (uint64 * uint32)>>> = Fable.Core.RustInterop.emitRustExpr () v4830 
    let v4832 : string = $"alias"
    let v4833 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v4832 
    let v5145 : unit = ()
    let v5146 : (unit -> unit) = closure18(v4833)
    let v5147 : unit = (fun () -> v5146 (); v5145) ()
    let v5462 : (unit -> unit) = method27()
    let v5772 : unit = ()
    let v5773 : (unit -> unit) = closure19(v5462)
    let v5774 : unit = (fun () -> v5773 (); v5772) ()
    let v6087 : string = "  v4831.get(&$0).cloned() //"
    Fable.Core.RustInterop.emitRustExpr v4833 v6087 
    let v6088 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v6088 
    let v6089 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v6089 
    let v6090 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v6090 
    let v6091 : string = "true; // ??? / i: 7uy / i': 1uy / acc: 10uy / n: 2uy"
    let v6092 : bool = Fable.Core.RustInterop.emitRustExpr () v6091 
    let v6093 : string = "true; */ // ???? / i: 7uy / i': 2uy / acc: 10uy / n: 2uy"
    let v6094 : bool = Fable.Core.RustInterop.emitRustExpr () v6093 
    let v6095 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v6095 
    let v6096 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v6096 
    let v6097 : string = "#[result_serializer(borsh)] //"
    Fable.Core.RustInterop.emitRustExpr () v6097 
    let v6098 : string = "pub fn get_alias_map_borsh( //"
    Fable.Core.RustInterop.emitRustExpr () v6098 
    let v6099 : string = "  &self, //"
    Fable.Core.RustInterop.emitRustExpr () v6099 
    let v6100 : string = "  #[serializer(borsh)] alias: String, //"
    Fable.Core.RustInterop.emitRustExpr () v6100 
    let v6101 : string = ") -> Option<std::collections::HashMap<near_sdk::AccountId, (u64, u32)>> { //"
    Fable.Core.RustInterop.emitRustExpr () v6101 
    let v6102 : string = "  self.get_alias_map(alias) //"
    Fable.Core.RustInterop.emitRustExpr () v6102 
    let v6103 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v6103 
    let v6104 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v6104 
    let v6105 : string = "true; // ??? / i: 8uy / i': 1uy / acc: 12uy / n: 1uy"
    let v6106 : bool = Fable.Core.RustInterop.emitRustExpr () v6105 
    let v6107 : string = "true; */ // ???? / i: 8uy / i': 2uy / acc: 12uy / n: 1uy"
    let v6108 : bool = Fable.Core.RustInterop.emitRustExpr () v6107 
    let v6109 : string = "fn _main() //"
    Fable.Core.RustInterop.emitRustExpr () v6109 
    let v6110 : string = "{ { //"
    Fable.Core.RustInterop.emitRustExpr () v6110 
    let v6111 : string = "true; { (); // ?? / i': 1uy / n: 13uy"
    let v6112 : bool = Fable.Core.RustInterop.emitRustExpr () v6111 
    let v6113 : string = "true; { (); // ?? / i': 2uy / n: 13uy"
    let v6114 : bool = Fable.Core.RustInterop.emitRustExpr () v6113 
    let v6115 : string = "true; { (); // ?? / i': 3uy / n: 13uy"
    let v6116 : bool = Fable.Core.RustInterop.emitRustExpr () v6115 
    let v6117 : string = "true; { (); // ?? / i': 4uy / n: 13uy"
    let v6118 : bool = Fable.Core.RustInterop.emitRustExpr () v6117 
    let v6119 : string = "true; { (); // ?? / i': 5uy / n: 13uy"
    let v6120 : bool = Fable.Core.RustInterop.emitRustExpr () v6119 
    let v6121 : string = "true; { (); // ?? / i': 6uy / n: 13uy"
    let v6122 : bool = Fable.Core.RustInterop.emitRustExpr () v6121 
    let v6123 : string = "true; { (); // ?? / i': 7uy / n: 13uy"
    let v6124 : bool = Fable.Core.RustInterop.emitRustExpr () v6123 
    let v6125 : string = "true; { (); // ?? / i': 8uy / n: 13uy"
    let v6126 : bool = Fable.Core.RustInterop.emitRustExpr () v6125 
    let v6127 : string = "true; { (); // ?? / i': 9uy / n: 13uy"
    let v6128 : bool = Fable.Core.RustInterop.emitRustExpr () v6127 
    let v6129 : string = "true; { (); // ?? / i': 10uy / n: 13uy"
    let v6130 : bool = Fable.Core.RustInterop.emitRustExpr () v6129 
    let v6131 : string = "true; { (); // ?? / i': 11uy / n: 13uy"
    let v6132 : bool = Fable.Core.RustInterop.emitRustExpr () v6131 
    let v6133 : string = "true; { (); // ?? / i': 12uy / n: 13uy"
    let v6134 : bool = Fable.Core.RustInterop.emitRustExpr () v6133 
    let v6135 : string = "true; { (); // ?? / i': 13uy / n: 13uy"
    let v6136 : bool = Fable.Core.RustInterop.emitRustExpr () v6135 
    let v6137 : string = "true; { { (); // ? / i': 14uy / n: 13uy"
    let v6138 : bool = Fable.Core.RustInterop.emitRustExpr () v6137 
    ()
let v0 : (unit -> unit) = closure0()
v0 |> ignore
()
