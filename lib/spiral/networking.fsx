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

type System_Net_Sockets_TcpClient = System.IDisposable
#else
type System_Net_Sockets_TcpClient = System.Net.Sockets.TcpClient
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
and [<Struct>] US5 =
    | US5_0 of f0_0 : string
    | US5_1
and [<Struct>] US6 =
    | US6_0 of f0_0 : bool
    | US6_1
and [<Struct>] US7 =
    | US7_0 of f0_0 : bool
    | US7_1 of f1_0 : exn
and [<Struct>] US8 =
    | US8_0 of f0_0 : bool
    | US8_1 of f1_0 : exn
and [<Struct>] US9 =
    | US9_0 of f0_0 : int32
    | US9_1
let rec method3 (v0 : string) : string =
    v0
and method4 () : string =
    let v0 : string = ""
    v0
and closure1 () (v0 : string) : US5 =
    US5_0(v0)
and method5 () : (string -> US5) =
    closure1()
and method2 (v0 : string) : string =
    (* run_target_args'
    let v1 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = method3(v0)
    let v3 : string = "std::env::var(&*$0)"
    let v4 : Result<std_string_String, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr v2 v3 
    let v5 : string = "true; let _result_map_ = $0.map(|x| { //"
    let v6 : bool = Fable.Core.RustInterop.emitRustExpr v4 v5 
    let v7 : string = "x"
    let v8 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v7 
    let v9 : string = "fable_library_rust::String_::fromString($0)"
    let v10 : string = Fable.Core.RustInterop.emitRustExpr v8 v9 
    let v11 : string = "true; $0 })"
    let v12 : bool = Fable.Core.RustInterop.emitRustExpr v10 v11 
    let v13 : string = "_result_map_"
    let v14 : Result<string, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr () v13 
    let v15 : string = method4()
    let v16 : string = "$0.unwrap_or($1)"
    let v17 : string = Fable.Core.RustInterop.emitRustExpr struct (v14, v15) v16 
    let _run_target_args'_v1 = v17 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v18 : US3 = US3_1
    let v19 : US4 = US4_2(v18)
    let v20 : string = $"env.get_environment_variable / target: {v19} / var: {v0}"
    let v21 : string = failwith<string> v20
    let _run_target_args'_v1 = v21 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v22 : US3 = US3_2
    let v23 : US4 = US4_2(v22)
    let v24 : string = $"env.get_environment_variable / target: {v23} / var: {v0}"
    let v25 : string = failwith<string> v24
    let _run_target_args'_v1 = v25 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v26 : string = "process.env[$0] ?? \"\""
    let v27 : string = Fable.Core.JsInterop.emitJsExpr v0 v26 
    let _run_target_args'_v1 = v27 
    #endif
#if FABLE_COMPILER_PYTHON
    let v28 : string = "os"
    let v29 : IOsEnviron = Fable.Core.PyInterop.importAll v28 
    let v30 : string = "v29.environ"
    let v31 : obj = Fable.Core.PyInterop.emitPyExpr () v30 
    let v34 : string = "v31.get($0)"
    let v35 : string = Fable.Core.PyInterop.emitPyExpr v0 v34 
    let mutable _v35 = None
    #if !FABLE_COMPILER && !WASM && !CONTRACT
    let v38 : (string -> string option) = Option.ofObj
    let v39 : string option = v38 v35
    v39 
    #else
    Some v35 
    #endif
    |> fun x -> _v35 <- Some x
    let v40 : string option = match _v35 with Some x -> x | None -> failwith "optionm'.of_obj / _v35=None"
    let v43 : (string -> US5) = method5()
    let v44 : US5 option = v40 |> Option.map v43 
    let v55 : US5 = US5_1
    let v56 : US5 = v44 |> Option.defaultValue v55 
    let v63 : string =
        match v56 with
        | US5_1 -> (* None *)
            let v61 : string = ""
            v61
        | US5_0(v60) -> (* Some *)
            v60
    let _run_target_args'_v1 = v63 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v64 : US3 = US3_1
    let v65 : US4 = US4_0(v64)
    let v66 : string = $"env.get_environment_variable / target: {v65} / var: {v0}"
    let v67 : string = failwith<string> v66
    let _run_target_args'_v1 = v67 
    #endif
#else
    let v68 : (string -> string) = System.Environment.GetEnvironmentVariable
    let v69 : string = v68 v0
    let mutable _v69 = None
    #if !FABLE_COMPILER && !WASM && !CONTRACT
    let v70 : (string -> string option) = Option.ofObj
    let v71 : string option = v70 v69
    v71 
    #else
    Some v69 
    #endif
    |> fun x -> _v69 <- Some x
    let v72 : string option = match _v69 with Some x -> x | None -> failwith "optionm'.of_obj / _v69=None"
    let v75 : (string -> US5) = method5()
    let v76 : US5 option = v72 |> Option.map v75 
    let v87 : US5 = US5_1
    let v88 : US5 = v76 |> Option.defaultValue v87 
    let v95 : string =
        match v88 with
        | US5_1 -> (* None *)
            let v93 : string = ""
            v93
        | US5_0(v92) -> (* Some *)
            v92
    let _run_target_args'_v1 = v95 
    #endif
    let v96 : string = _run_target_args'_v1 
    v96
and method1 () : struct (US1 * US2) =
    let v0 : string = "TRACE_LEVEL"
    let v1 : string = method2(v0)
    
    
    
    
    
    let v2 : bool = "Verbose" = v1
    let v6 : US1 =
        if v2 then
            let v3 : US0 = US0_0
            US1_0(v3)
        else
            US1_1
    let v47 : US1 =
        match v6 with
        | US1_1 -> (* None *)
            let v9 : bool = "Debug" = v1
            let v13 : US1 =
                if v9 then
                    let v10 : US0 = US0_1
                    US1_0(v10)
                else
                    US1_1
            match v13 with
            | US1_1 -> (* None *)
                let v16 : bool = "Info" = v1
                let v20 : US1 =
                    if v16 then
                        let v17 : US0 = US0_2
                        US1_0(v17)
                    else
                        US1_1
                match v20 with
                | US1_1 -> (* None *)
                    let v23 : bool = "Warning" = v1
                    let v27 : US1 =
                        if v23 then
                            let v24 : US0 = US0_3
                            US1_0(v24)
                        else
                            US1_1
                    match v27 with
                    | US1_1 -> (* None *)
                        let v30 : bool = "Critical" = v1
                        let v34 : US1 =
                            if v30 then
                                let v31 : US0 = US0_4
                                US1_0(v31)
                            else
                                US1_1
                        match v34 with
                        | US1_1 -> (* None *)
                            US1_1
                        | US1_0(v35) -> (* Some *)
                            US1_0(v35)
                    | US1_0(v28) -> (* Some *)
                        US1_0(v28)
                | US1_0(v21) -> (* Some *)
                    US1_0(v21)
            | US1_0(v14) -> (* Some *)
                US1_0(v14)
        | US1_0(v7) -> (* Some *)
            US1_0(v7)
    let v48 : string = "AUTOMATION"
    let v49 : string = method2(v48)
    let v50 : string = "True"
    let v51 : bool = v49 <> v50 
    let v107 : US2 =
        if v51 then
            US2_1
        else
            (* run_target_args'
            let v55 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v56 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v55 = v56 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v57 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v55 = v57 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v58 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v55 = v58 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v61 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v55 = v61 
            #endif
#if FABLE_COMPILER_PYTHON
            let v62 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v55 = v62 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v63 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v55 = v63 
            #endif
#else
            let v64 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v55 = v64 
            #endif
            let v65 : System.DateTime = _run_target_args'_v55 
            (* run_target_args'
            let v70 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v71 : (System.DateTime -> int64) = _.Ticks
            let v72 : int64 = v71 v65
            let _run_target_args'_v70 = v72 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v73 : (System.DateTime -> int64) = _.Ticks
            let v74 : int64 = v73 v65
            let _run_target_args'_v70 = v74 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v75 : int64 = null |> unbox<int64>
            let _run_target_args'_v70 = v75 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v78 : (System.DateTime -> int64) = _.Ticks
            let v79 : int64 = v78 v65
            let _run_target_args'_v70 = v79 
            #endif
#if FABLE_COMPILER_PYTHON
            let v80 : (System.DateTime -> int64) = _.Ticks
            let v81 : int64 = v80 v65
            let _run_target_args'_v70 = v81 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v82 : (System.DateTime -> int64) = _.Ticks
            let v83 : int64 = v82 v65
            let _run_target_args'_v70 = v83 
            #endif
#else
            let v84 : (System.DateTime -> int64) = _.Ticks
            let v85 : int64 = v84 v65
            let _run_target_args'_v70 = v85 
            #endif
            let v86 : int64 = _run_target_args'_v70 
            let v103 : int64 = v86 |> int64 
            US2_0(v103)
    struct (v47, v107)
and closure2 () (v0 : string) : unit =
    ()
and method0 (v0 : US0) : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) =
    (* run_target_args'
    let v1 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let struct (v2 : US1, v3 : US2) = method1()
    let _run_target_args'_v1 = struct (v2, v3) 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v4 : US1 = US1_1
    let v5 : US2 = US2_1
    let _run_target_args'_v1 = struct (v4, v5) 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v6 : string = "AUTOMATION"
    (* run_target_args'
    let v7 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v8 : string = "option_env!(\"" + v6 + "\").unwrap_or(\"\")"
    let v9 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v8 
    (* run_target_args'
    let v10 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v11 : string = "String::from($0)"
    let v12 : std_string_String = Fable.Core.RustInterop.emitRustExpr v9 v11 
    let _run_target_args'_v10 = v12 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v13 : string = "String::from($0)"
    let v14 : std_string_String = Fable.Core.RustInterop.emitRustExpr v9 v13 
    let _run_target_args'_v10 = v14 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v15 : string = "String::from($0)"
    let v16 : std_string_String = Fable.Core.RustInterop.emitRustExpr v9 v15 
    let _run_target_args'_v10 = v16 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v17 : std_string_String = v9 |> unbox<std_string_String>
    let _run_target_args'_v10 = v17 
    #endif
#if FABLE_COMPILER_PYTHON
    let v20 : std_string_String = v9 |> unbox<std_string_String>
    let _run_target_args'_v10 = v20 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v23 : std_string_String = v9 |> unbox<std_string_String>
    let _run_target_args'_v10 = v23 
    #endif
#else
    let v26 : std_string_String = v9 |> unbox<std_string_String>
    let _run_target_args'_v10 = v26 
    #endif
    let v29 : std_string_String = _run_target_args'_v10 
    let v34 : string = "fable_library_rust::String_::fromString($0)"
    let v35 : string = Fable.Core.RustInterop.emitRustExpr v29 v34 
    let _run_target_args'_v7 = v35 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v36 : string = "option_env!(\"" + v6 + "\").unwrap_or(\"\")"
    let v37 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v36 
    (* run_target_args'
    let v38 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v39 : string = "String::from($0)"
    let v40 : std_string_String = Fable.Core.RustInterop.emitRustExpr v37 v39 
    let _run_target_args'_v38 = v40 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v41 : string = "String::from($0)"
    let v42 : std_string_String = Fable.Core.RustInterop.emitRustExpr v37 v41 
    let _run_target_args'_v38 = v42 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v43 : string = "String::from($0)"
    let v44 : std_string_String = Fable.Core.RustInterop.emitRustExpr v37 v43 
    let _run_target_args'_v38 = v44 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v45 : std_string_String = v37 |> unbox<std_string_String>
    let _run_target_args'_v38 = v45 
    #endif
#if FABLE_COMPILER_PYTHON
    let v48 : std_string_String = v37 |> unbox<std_string_String>
    let _run_target_args'_v38 = v48 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v51 : std_string_String = v37 |> unbox<std_string_String>
    let _run_target_args'_v38 = v51 
    #endif
#else
    let v54 : std_string_String = v37 |> unbox<std_string_String>
    let _run_target_args'_v38 = v54 
    #endif
    let v57 : std_string_String = _run_target_args'_v38 
    let v62 : string = "fable_library_rust::String_::fromString($0)"
    let v63 : string = Fable.Core.RustInterop.emitRustExpr v57 v62 
    let _run_target_args'_v7 = v63 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v64 : string = "option_env!(\"" + v6 + "\").unwrap_or(\"\")"
    let v65 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v64 
    (* run_target_args'
    let v66 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v67 : string = "String::from($0)"
    let v68 : std_string_String = Fable.Core.RustInterop.emitRustExpr v65 v67 
    let _run_target_args'_v66 = v68 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v69 : string = "String::from($0)"
    let v70 : std_string_String = Fable.Core.RustInterop.emitRustExpr v65 v69 
    let _run_target_args'_v66 = v70 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v71 : string = "String::from($0)"
    let v72 : std_string_String = Fable.Core.RustInterop.emitRustExpr v65 v71 
    let _run_target_args'_v66 = v72 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v73 : std_string_String = v65 |> unbox<std_string_String>
    let _run_target_args'_v66 = v73 
    #endif
#if FABLE_COMPILER_PYTHON
    let v76 : std_string_String = v65 |> unbox<std_string_String>
    let _run_target_args'_v66 = v76 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v79 : std_string_String = v65 |> unbox<std_string_String>
    let _run_target_args'_v66 = v79 
    #endif
#else
    let v82 : std_string_String = v65 |> unbox<std_string_String>
    let _run_target_args'_v66 = v82 
    #endif
    let v85 : std_string_String = _run_target_args'_v66 
    let v90 : string = "fable_library_rust::String_::fromString($0)"
    let v91 : string = Fable.Core.RustInterop.emitRustExpr v85 v90 
    let _run_target_args'_v7 = v91 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v92 : string = null |> unbox<string>
    let _run_target_args'_v7 = v92 
    #endif
#if FABLE_COMPILER_PYTHON
    let v95 : string = null |> unbox<string>
    let _run_target_args'_v7 = v95 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v98 : string = null |> unbox<string>
    let _run_target_args'_v7 = v98 
    #endif
#else
    let v101 : string = null |> unbox<string>
    let _run_target_args'_v7 = v101 
    #endif
    let v104 : string = _run_target_args'_v7 
    let v109 : string = "True"
    let v110 : bool = v104 <> v109 
    let v121 : US2 =
        if v110 then
            US2_1
        else
            let v114 : string = $"near_sdk::env::block_timestamp()"
            let v115 : uint64 = Fable.Core.RustInterop.emitRustExpr () v114 
            let v116 : (uint64 -> int64) = int64
            let v117 : int64 = v116 v115
            US2_0(v117)
    let v122 : US1 = US1_1
    let _run_target_args'_v1 = struct (v122, v121) 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let struct (v123 : US1, v124 : US2) = method1()
    let _run_target_args'_v1 = struct (v123, v124) 
    #endif
#if FABLE_COMPILER_PYTHON
    let struct (v125 : US1, v126 : US2) = method1()
    let _run_target_args'_v1 = struct (v125, v126) 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let struct (v127 : US1, v128 : US2) = method1()
    let _run_target_args'_v1 = struct (v127, v128) 
    #endif
#else
    let struct (v129 : US1, v130 : US2) = method1()
    let _run_target_args'_v1 = struct (v129, v130) 
    #endif
    let struct (v131 : US1, v132 : US2) = _run_target_args'_v1 
    let v137 : Mut0 = {l0 = 1L} : Mut0
    let v138 : (string -> unit) = closure2()
    let v139 : Mut1 = {l0 = v138} : Mut1
    let v140 : Mut2 = {l0 = true} : Mut2
    let v141 : string = ""
    let v142 : Mut3 = {l0 = v141} : Mut3
    let v145 : US0 =
        match v131 with
        | US1_1 -> (* None *)
            v0
        | US1_0(v143) -> (* Some *)
            v143
    let v146 : Mut4 = {l0 = v145} : Mut4
    let v153 : int64 option =
        match v132 with
        | US2_1 -> (* None *)
            let v151 : int64 option = None
            v151
        | US2_0(v147) -> (* Some *)
            let v148 : int64 option = Some v147 
            v148
    struct (v137, v139, v140, v142, v146, v153)
and closure0 () () : unit =
    let v0 : bool = TraceState.trace_state.IsNone
    if v0 then
        let v1 : US0 = US0_0
        let struct (v2 : Mut0, v3 : Mut1, v4 : Mut2, v5 : Mut3, v6 : Mut4, v7 : int64 option) = method0(v1)
        let v8 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v2, v3, v4, v5, v6, v7) 
        TraceState.trace_state <- v8 
        ()
and method8 (v0 : US0) : bool =
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
and closure6 () (v0 : int64) : US2 =
    US2_0(v0)
and method10 () : (int64 -> US2) =
    closure6()
and method11 () : string =
    let v0 : string = "hh:mm:ss"
    v0
and method12 () : string =
    let v0 : string = "HH:mm:ss"
    v0
and method9 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option) : string =
    (* run_target_args'
    let v6 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v7 : (int64 -> US2) = method10()
    let v8 : US2 option = v5 |> Option.map v7 
    let v19 : US2 = US2_1
    let v20 : US2 = v8 |> Option.defaultValue v19 
    let v117 : System.DateTime =
        match v20 with
        | US2_1 -> (* None *)
            (* run_target_args'
            let v101 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v102 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v101 = v102 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v103 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v101 = v103 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v104 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v101 = v104 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v107 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v101 = v107 
            #endif
#if FABLE_COMPILER_PYTHON
            let v108 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v101 = v108 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v109 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v101 = v109 
            #endif
#else
            let v110 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v101 = v110 
            #endif
            let v111 : System.DateTime = _run_target_args'_v101 
            v111
        | US2_0(v24) -> (* Some *)
            (* run_target_args'
            let v25 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v26 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v25 = v26 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v27 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v25 = v27 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v28 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v25 = v28 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v31 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v25 = v31 
            #endif
#if FABLE_COMPILER_PYTHON
            let v32 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v25 = v32 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v33 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v25 = v33 
            #endif
#else
            let v34 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v25 = v34 
            #endif
            let v35 : System.DateTime = _run_target_args'_v25 
            (* run_target_args'
            let v40 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v41 : (System.DateTime -> int64) = _.Ticks
            let v42 : int64 = v41 v35
            let _run_target_args'_v40 = v42 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v43 : (System.DateTime -> int64) = _.Ticks
            let v44 : int64 = v43 v35
            let _run_target_args'_v40 = v44 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v45 : int64 = null |> unbox<int64>
            let _run_target_args'_v40 = v45 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v48 : (System.DateTime -> int64) = _.Ticks
            let v49 : int64 = v48 v35
            let _run_target_args'_v40 = v49 
            #endif
#if FABLE_COMPILER_PYTHON
            let v50 : (System.DateTime -> int64) = _.Ticks
            let v51 : int64 = v50 v35
            let _run_target_args'_v40 = v51 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v52 : (System.DateTime -> int64) = _.Ticks
            let v53 : int64 = v52 v35
            let _run_target_args'_v40 = v53 
            #endif
#else
            let v54 : (System.DateTime -> int64) = _.Ticks
            let v55 : int64 = v54 v35
            let _run_target_args'_v40 = v55 
            #endif
            let v56 : int64 = _run_target_args'_v40 
            let v73 : int64 = v56 |> int64 
            let v76 : int64 = v73 - v24
            let v77 : System.TimeSpan = v76 |> System.TimeSpan 
            let v82 : (System.TimeSpan -> int32) = _.Hours
            let v83 : int32 = v82 v77
            let v86 : (System.TimeSpan -> int32) = _.Minutes
            let v87 : int32 = v86 v77
            let v90 : (System.TimeSpan -> int32) = _.Seconds
            let v91 : int32 = v90 v77
            let v94 : (System.TimeSpan -> int32) = _.Milliseconds
            let v95 : int32 = v94 v77
            let v98 : System.DateTime = System.DateTime (1, 1, 1, v83, v87, v91, v95)
            v98
    let v118 : string = method11()
    let v121 : bool = v118 = ""
    let v123 : string =
        if v121 then
            let v122 : string = "M-d-y hh:mm:ss tt"
            v122
        else
            v118
    let v124 : (string -> string) = v117.ToString
    let v125 : string = v124 v123
    let _run_target_args'_v6 = v125 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v139 : (int64 -> US2) = method10()
    let v140 : US2 option = v5 |> Option.map v139 
    let v151 : US2 = US2_1
    let v152 : US2 = v140 |> Option.defaultValue v151 
    let v249 : System.DateTime =
        match v152 with
        | US2_1 -> (* None *)
            (* run_target_args'
            let v233 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v234 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v233 = v234 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v235 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v233 = v235 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v236 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v233 = v236 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v239 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v233 = v239 
            #endif
#if FABLE_COMPILER_PYTHON
            let v240 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v233 = v240 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v241 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v233 = v241 
            #endif
#else
            let v242 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v233 = v242 
            #endif
            let v243 : System.DateTime = _run_target_args'_v233 
            v243
        | US2_0(v156) -> (* Some *)
            (* run_target_args'
            let v157 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v158 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v157 = v158 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v159 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v157 = v159 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v160 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v157 = v160 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v163 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v157 = v163 
            #endif
#if FABLE_COMPILER_PYTHON
            let v164 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v157 = v164 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v165 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v157 = v165 
            #endif
#else
            let v166 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v157 = v166 
            #endif
            let v167 : System.DateTime = _run_target_args'_v157 
            (* run_target_args'
            let v172 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v173 : (System.DateTime -> int64) = _.Ticks
            let v174 : int64 = v173 v167
            let _run_target_args'_v172 = v174 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v175 : (System.DateTime -> int64) = _.Ticks
            let v176 : int64 = v175 v167
            let _run_target_args'_v172 = v176 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v177 : int64 = null |> unbox<int64>
            let _run_target_args'_v172 = v177 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v180 : (System.DateTime -> int64) = _.Ticks
            let v181 : int64 = v180 v167
            let _run_target_args'_v172 = v181 
            #endif
#if FABLE_COMPILER_PYTHON
            let v182 : (System.DateTime -> int64) = _.Ticks
            let v183 : int64 = v182 v167
            let _run_target_args'_v172 = v183 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v184 : (System.DateTime -> int64) = _.Ticks
            let v185 : int64 = v184 v167
            let _run_target_args'_v172 = v185 
            #endif
#else
            let v186 : (System.DateTime -> int64) = _.Ticks
            let v187 : int64 = v186 v167
            let _run_target_args'_v172 = v187 
            #endif
            let v188 : int64 = _run_target_args'_v172 
            let v205 : int64 = v188 |> int64 
            let v208 : int64 = v205 - v156
            let v209 : System.TimeSpan = v208 |> System.TimeSpan 
            let v214 : (System.TimeSpan -> int32) = _.Hours
            let v215 : int32 = v214 v209
            let v218 : (System.TimeSpan -> int32) = _.Minutes
            let v219 : int32 = v218 v209
            let v222 : (System.TimeSpan -> int32) = _.Seconds
            let v223 : int32 = v222 v209
            let v226 : (System.TimeSpan -> int32) = _.Milliseconds
            let v227 : int32 = v226 v209
            let v230 : System.DateTime = System.DateTime (1, 1, 1, v215, v219, v223, v227)
            v230
    let v250 : string = method11()
    let v253 : bool = v250 = ""
    let v255 : string =
        if v253 then
            let v254 : string = "M-d-y hh:mm:ss tt"
            v254
        else
            v250
    let v256 : (string -> string) = v249.ToString
    let v257 : string = v256 v255
    let _run_target_args'_v6 = v257 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v271 : string = $"near_sdk::env::block_timestamp()"
    let v272 : uint64 = Fable.Core.RustInterop.emitRustExpr () v271 
    let v273 : (int64 -> US2) = method10()
    let v274 : US2 option = v5 |> Option.map v273 
    let v285 : US2 = US2_1
    let v286 : US2 = v274 |> Option.defaultValue v285 
    let v297 : uint64 =
        match v286 with
        | US2_1 -> (* None *)
            v272
        | US2_0(v290) -> (* Some *)
            let v291 : (int64 -> uint64) = uint64
            let v292 : uint64 = v291 v290
            let v295 : uint64 = v272 - v292
            v295
    let v298 : uint64 = v297 / 1000000000UL
    let v299 : uint64 = v298 % 60UL
    let v300 : uint64 = v298 / 60UL
    let v301 : uint64 = v300 % 60UL
    let v302 : uint64 = v298 / 3600UL
    let v303 : uint64 = v302 % 24UL
    let v304 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
    let v305 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v303, v301, v299) v304 
    let v306 : string = "fable_library_rust::String_::fromString($0)"
    let v307 : string = Fable.Core.RustInterop.emitRustExpr v305 v306 
    let _run_target_args'_v6 = v307 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v308 : (int64 -> US2) = method10()
    let v309 : US2 option = v5 |> Option.map v308 
    let v320 : US2 = US2_1
    let v321 : US2 = v309 |> Option.defaultValue v320 
    let v418 : System.DateTime =
        match v321 with
        | US2_1 -> (* None *)
            (* run_target_args'
            let v402 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v403 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v402 = v403 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v404 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v402 = v404 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v405 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v402 = v405 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v408 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v402 = v408 
            #endif
#if FABLE_COMPILER_PYTHON
            let v409 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v402 = v409 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v410 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v402 = v410 
            #endif
#else
            let v411 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v402 = v411 
            #endif
            let v412 : System.DateTime = _run_target_args'_v402 
            v412
        | US2_0(v325) -> (* Some *)
            (* run_target_args'
            let v326 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v327 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v326 = v327 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v328 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v326 = v328 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v329 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v326 = v329 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v332 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v326 = v332 
            #endif
#if FABLE_COMPILER_PYTHON
            let v333 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v326 = v333 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v334 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v326 = v334 
            #endif
#else
            let v335 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v326 = v335 
            #endif
            let v336 : System.DateTime = _run_target_args'_v326 
            (* run_target_args'
            let v341 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v342 : (System.DateTime -> int64) = _.Ticks
            let v343 : int64 = v342 v336
            let _run_target_args'_v341 = v343 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v344 : (System.DateTime -> int64) = _.Ticks
            let v345 : int64 = v344 v336
            let _run_target_args'_v341 = v345 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v346 : int64 = null |> unbox<int64>
            let _run_target_args'_v341 = v346 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v349 : (System.DateTime -> int64) = _.Ticks
            let v350 : int64 = v349 v336
            let _run_target_args'_v341 = v350 
            #endif
#if FABLE_COMPILER_PYTHON
            let v351 : (System.DateTime -> int64) = _.Ticks
            let v352 : int64 = v351 v336
            let _run_target_args'_v341 = v352 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v353 : (System.DateTime -> int64) = _.Ticks
            let v354 : int64 = v353 v336
            let _run_target_args'_v341 = v354 
            #endif
#else
            let v355 : (System.DateTime -> int64) = _.Ticks
            let v356 : int64 = v355 v336
            let _run_target_args'_v341 = v356 
            #endif
            let v357 : int64 = _run_target_args'_v341 
            let v374 : int64 = v357 |> int64 
            let v377 : int64 = v374 - v325
            let v378 : System.TimeSpan = v377 |> System.TimeSpan 
            let v383 : (System.TimeSpan -> int32) = _.Hours
            let v384 : int32 = v383 v378
            let v387 : (System.TimeSpan -> int32) = _.Minutes
            let v388 : int32 = v387 v378
            let v391 : (System.TimeSpan -> int32) = _.Seconds
            let v392 : int32 = v391 v378
            let v395 : (System.TimeSpan -> int32) = _.Milliseconds
            let v396 : int32 = v395 v378
            let v399 : System.DateTime = System.DateTime (1, 1, 1, v384, v388, v392, v396)
            v399
    let v419 : string = method12()
    let v422 : bool = v419 = ""
    let v424 : string =
        if v422 then
            let v423 : string = "M-d-y hh:mm:ss tt"
            v423
        else
            v419
    let v425 : (string -> string) = v418.ToString
    let v426 : string = v425 v424
    let _run_target_args'_v6 = v426 
    #endif
#if FABLE_COMPILER_PYTHON
    let v440 : (int64 -> US2) = method10()
    let v441 : US2 option = v5 |> Option.map v440 
    let v452 : US2 = US2_1
    let v453 : US2 = v441 |> Option.defaultValue v452 
    let v550 : System.DateTime =
        match v453 with
        | US2_1 -> (* None *)
            (* run_target_args'
            let v534 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v535 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v534 = v535 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v536 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v534 = v536 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v537 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v534 = v537 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v540 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v534 = v540 
            #endif
#if FABLE_COMPILER_PYTHON
            let v541 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v534 = v541 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v542 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v534 = v542 
            #endif
#else
            let v543 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v534 = v543 
            #endif
            let v544 : System.DateTime = _run_target_args'_v534 
            v544
        | US2_0(v457) -> (* Some *)
            (* run_target_args'
            let v458 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v459 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v458 = v459 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v460 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v458 = v460 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v461 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v458 = v461 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v464 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v458 = v464 
            #endif
#if FABLE_COMPILER_PYTHON
            let v465 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v458 = v465 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v466 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v458 = v466 
            #endif
#else
            let v467 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v458 = v467 
            #endif
            let v468 : System.DateTime = _run_target_args'_v458 
            (* run_target_args'
            let v473 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v474 : (System.DateTime -> int64) = _.Ticks
            let v475 : int64 = v474 v468
            let _run_target_args'_v473 = v475 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v476 : (System.DateTime -> int64) = _.Ticks
            let v477 : int64 = v476 v468
            let _run_target_args'_v473 = v477 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v478 : int64 = null |> unbox<int64>
            let _run_target_args'_v473 = v478 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v481 : (System.DateTime -> int64) = _.Ticks
            let v482 : int64 = v481 v468
            let _run_target_args'_v473 = v482 
            #endif
#if FABLE_COMPILER_PYTHON
            let v483 : (System.DateTime -> int64) = _.Ticks
            let v484 : int64 = v483 v468
            let _run_target_args'_v473 = v484 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v485 : (System.DateTime -> int64) = _.Ticks
            let v486 : int64 = v485 v468
            let _run_target_args'_v473 = v486 
            #endif
#else
            let v487 : (System.DateTime -> int64) = _.Ticks
            let v488 : int64 = v487 v468
            let _run_target_args'_v473 = v488 
            #endif
            let v489 : int64 = _run_target_args'_v473 
            let v506 : int64 = v489 |> int64 
            let v509 : int64 = v506 - v457
            let v510 : System.TimeSpan = v509 |> System.TimeSpan 
            let v515 : (System.TimeSpan -> int32) = _.Hours
            let v516 : int32 = v515 v510
            let v519 : (System.TimeSpan -> int32) = _.Minutes
            let v520 : int32 = v519 v510
            let v523 : (System.TimeSpan -> int32) = _.Seconds
            let v524 : int32 = v523 v510
            let v527 : (System.TimeSpan -> int32) = _.Milliseconds
            let v528 : int32 = v527 v510
            let v531 : System.DateTime = System.DateTime (1, 1, 1, v516, v520, v524, v528)
            v531
    let v551 : string = method12()
    let v554 : bool = v551 = ""
    let v556 : string =
        if v554 then
            let v555 : string = "M-d-y hh:mm:ss tt"
            v555
        else
            v551
    let v557 : (string -> string) = v550.ToString
    let v558 : string = v557 v556
    let _run_target_args'_v6 = v558 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v572 : (int64 -> US2) = method10()
    let v573 : US2 option = v5 |> Option.map v572 
    let v584 : US2 = US2_1
    let v585 : US2 = v573 |> Option.defaultValue v584 
    let v682 : System.DateTime =
        match v585 with
        | US2_1 -> (* None *)
            (* run_target_args'
            let v666 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v667 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v666 = v667 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v668 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v666 = v668 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v669 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v666 = v669 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v672 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v666 = v672 
            #endif
#if FABLE_COMPILER_PYTHON
            let v673 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v666 = v673 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v674 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v666 = v674 
            #endif
#else
            let v675 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v666 = v675 
            #endif
            let v676 : System.DateTime = _run_target_args'_v666 
            v676
        | US2_0(v589) -> (* Some *)
            (* run_target_args'
            let v590 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v591 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v590 = v591 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v592 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v590 = v592 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v593 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v590 = v593 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v596 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v590 = v596 
            #endif
#if FABLE_COMPILER_PYTHON
            let v597 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v590 = v597 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v598 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v590 = v598 
            #endif
#else
            let v599 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v590 = v599 
            #endif
            let v600 : System.DateTime = _run_target_args'_v590 
            (* run_target_args'
            let v605 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v606 : (System.DateTime -> int64) = _.Ticks
            let v607 : int64 = v606 v600
            let _run_target_args'_v605 = v607 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v608 : (System.DateTime -> int64) = _.Ticks
            let v609 : int64 = v608 v600
            let _run_target_args'_v605 = v609 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v610 : int64 = null |> unbox<int64>
            let _run_target_args'_v605 = v610 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v613 : (System.DateTime -> int64) = _.Ticks
            let v614 : int64 = v613 v600
            let _run_target_args'_v605 = v614 
            #endif
#if FABLE_COMPILER_PYTHON
            let v615 : (System.DateTime -> int64) = _.Ticks
            let v616 : int64 = v615 v600
            let _run_target_args'_v605 = v616 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v617 : (System.DateTime -> int64) = _.Ticks
            let v618 : int64 = v617 v600
            let _run_target_args'_v605 = v618 
            #endif
#else
            let v619 : (System.DateTime -> int64) = _.Ticks
            let v620 : int64 = v619 v600
            let _run_target_args'_v605 = v620 
            #endif
            let v621 : int64 = _run_target_args'_v605 
            let v638 : int64 = v621 |> int64 
            let v641 : int64 = v638 - v589
            let v642 : System.TimeSpan = v641 |> System.TimeSpan 
            let v647 : (System.TimeSpan -> int32) = _.Hours
            let v648 : int32 = v647 v642
            let v651 : (System.TimeSpan -> int32) = _.Minutes
            let v652 : int32 = v651 v642
            let v655 : (System.TimeSpan -> int32) = _.Seconds
            let v656 : int32 = v655 v642
            let v659 : (System.TimeSpan -> int32) = _.Milliseconds
            let v660 : int32 = v659 v642
            let v663 : System.DateTime = System.DateTime (1, 1, 1, v648, v652, v656, v660)
            v663
    let v683 : string = method12()
    let v686 : bool = v683 = ""
    let v688 : string =
        if v686 then
            let v687 : string = "M-d-y hh:mm:ss tt"
            v687
        else
            v683
    let v689 : (string -> string) = v682.ToString
    let v690 : string = v689 v688
    let _run_target_args'_v6 = v690 
    #endif
#else
    let v704 : (int64 -> US2) = method10()
    let v705 : US2 option = v5 |> Option.map v704 
    let v716 : US2 = US2_1
    let v717 : US2 = v705 |> Option.defaultValue v716 
    let v814 : System.DateTime =
        match v717 with
        | US2_1 -> (* None *)
            (* run_target_args'
            let v798 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v799 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v798 = v799 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v800 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v798 = v800 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v801 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v798 = v801 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v804 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v798 = v804 
            #endif
#if FABLE_COMPILER_PYTHON
            let v805 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v798 = v805 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v806 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v798 = v806 
            #endif
#else
            let v807 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v798 = v807 
            #endif
            let v808 : System.DateTime = _run_target_args'_v798 
            v808
        | US2_0(v721) -> (* Some *)
            (* run_target_args'
            let v722 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v723 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v722 = v723 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v724 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v722 = v724 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v725 : System.DateTime = null |> unbox<System.DateTime>
            let _run_target_args'_v722 = v725 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v728 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v722 = v728 
            #endif
#if FABLE_COMPILER_PYTHON
            let v729 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v722 = v729 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v730 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v722 = v730 
            #endif
#else
            let v731 : System.DateTime = System.DateTime.Now
            let _run_target_args'_v722 = v731 
            #endif
            let v732 : System.DateTime = _run_target_args'_v722 
            (* run_target_args'
            let v737 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v738 : (System.DateTime -> int64) = _.Ticks
            let v739 : int64 = v738 v732
            let _run_target_args'_v737 = v739 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v740 : (System.DateTime -> int64) = _.Ticks
            let v741 : int64 = v740 v732
            let _run_target_args'_v737 = v741 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v742 : int64 = null |> unbox<int64>
            let _run_target_args'_v737 = v742 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v745 : (System.DateTime -> int64) = _.Ticks
            let v746 : int64 = v745 v732
            let _run_target_args'_v737 = v746 
            #endif
#if FABLE_COMPILER_PYTHON
            let v747 : (System.DateTime -> int64) = _.Ticks
            let v748 : int64 = v747 v732
            let _run_target_args'_v737 = v748 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v749 : (System.DateTime -> int64) = _.Ticks
            let v750 : int64 = v749 v732
            let _run_target_args'_v737 = v750 
            #endif
#else
            let v751 : (System.DateTime -> int64) = _.Ticks
            let v752 : int64 = v751 v732
            let _run_target_args'_v737 = v752 
            #endif
            let v753 : int64 = _run_target_args'_v737 
            let v770 : int64 = v753 |> int64 
            let v773 : int64 = v770 - v721
            let v774 : System.TimeSpan = v773 |> System.TimeSpan 
            let v779 : (System.TimeSpan -> int32) = _.Hours
            let v780 : int32 = v779 v774
            let v783 : (System.TimeSpan -> int32) = _.Minutes
            let v784 : int32 = v783 v774
            let v787 : (System.TimeSpan -> int32) = _.Seconds
            let v788 : int32 = v787 v774
            let v791 : (System.TimeSpan -> int32) = _.Milliseconds
            let v792 : int32 = v791 v774
            let v795 : System.DateTime = System.DateTime (1, 1, 1, v780, v784, v788, v792)
            v795
    let v815 : string = method12()
    let v818 : bool = v815 = ""
    let v820 : string =
        if v818 then
            let v819 : string = "M-d-y hh:mm:ss tt"
            v819
        else
            v815
    let v821 : (string -> string) = v814.ToString
    let v822 : string = v821 v820
    let _run_target_args'_v6 = v822 
    #endif
    let v836 : string = _run_target_args'_v6 
    v836
and method15 () : string =
    let v0 : string = ""
    v0
and closure7 (v0 : Mut3, v1 : string) () : unit =
    let v2 : string = v0.l0
    let v3 : string = v2 + v1 
    v0.l0 <- v3
    ()
and method14 (v0 : char) : string =
    let v1 : string = method15()
    let v2 : Mut3 = {l0 = v1} : Mut3
    let v3 : string = $"{v0}"
    let v6 : unit = ()
    let v7 : (unit -> unit) = closure7(v2, v3)
    let v8 : unit = (fun () -> v7 (); v6) ()
    let v11 : string = v2.l0
    v11
and method16 () : string =
    let v0 : string = "\u001b[0m"
    v0
and method13 () : string =
    
    
    
    
    
    let v0 : string = "Verbose"
    let v1 : (unit -> string) = v0.ToLower
    let v2 : string = v1 ()
    let v5 : char = v2.[int 0]
    let v6 : string = method14(v5)
    (* run_target_args'
    let v7 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v8 : string = "inline_colorization::color_bright_black"
    let v9 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v8 
    (* run_target_args'
    let v10 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v11 : string = "&*$0"
    let v12 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v11 
    let _run_target_args'_v10 = v12 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v13 : string = "&*$0"
    let v14 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v13 
    let _run_target_args'_v10 = v14 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v15 : string = "&*$0"
    let v16 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v15 
    let _run_target_args'_v10 = v16 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v17 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _run_target_args'_v10 = v17 
    #endif
#if FABLE_COMPILER_PYTHON
    let v20 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _run_target_args'_v10 = v20 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v23 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _run_target_args'_v10 = v23 
    #endif
#else
    let v26 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _run_target_args'_v10 = v26 
    #endif
    let v29 : Ref<Str> = _run_target_args'_v10 
    let v34 : string = "inline_colorization::color_reset"
    let v35 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v34 
    let v36 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v37 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v9, v29, v35) v36 
    let v38 : string = "fable_library_rust::String_::fromString($0)"
    let v39 : string = Fable.Core.RustInterop.emitRustExpr v37 v38 
    let _run_target_args'_v7 = v39 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v40 : string = "inline_colorization::color_bright_black"
    let v41 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v40 
    (* run_target_args'
    let v42 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v43 : string = "&*$0"
    let v44 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v43 
    let _run_target_args'_v42 = v44 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v45 : string = "&*$0"
    let v46 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v45 
    let _run_target_args'_v42 = v46 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v47 : string = "&*$0"
    let v48 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v47 
    let _run_target_args'_v42 = v48 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v49 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _run_target_args'_v42 = v49 
    #endif
#if FABLE_COMPILER_PYTHON
    let v52 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _run_target_args'_v42 = v52 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v55 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _run_target_args'_v42 = v55 
    #endif
#else
    let v58 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _run_target_args'_v42 = v58 
    #endif
    let v61 : Ref<Str> = _run_target_args'_v42 
    let v66 : string = "inline_colorization::color_reset"
    let v67 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v66 
    let v68 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v69 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v41, v61, v67) v68 
    let v70 : string = "fable_library_rust::String_::fromString($0)"
    let v71 : string = Fable.Core.RustInterop.emitRustExpr v69 v70 
    let _run_target_args'_v7 = v71 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v72 : string = "inline_colorization::color_bright_black"
    let v73 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v72 
    (* run_target_args'
    let v74 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v75 : string = "&*$0"
    let v76 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v75 
    let _run_target_args'_v74 = v76 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v77 : string = "&*$0"
    let v78 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v77 
    let _run_target_args'_v74 = v78 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v79 : string = "&*$0"
    let v80 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v79 
    let _run_target_args'_v74 = v80 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v81 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _run_target_args'_v74 = v81 
    #endif
#if FABLE_COMPILER_PYTHON
    let v84 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _run_target_args'_v74 = v84 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v87 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _run_target_args'_v74 = v87 
    #endif
#else
    let v90 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _run_target_args'_v74 = v90 
    #endif
    let v93 : Ref<Str> = _run_target_args'_v74 
    let v98 : string = "inline_colorization::color_reset"
    let v99 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v98 
    let v100 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v101 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v73, v93, v99) v100 
    let v102 : string = "fable_library_rust::String_::fromString($0)"
    let v103 : string = Fable.Core.RustInterop.emitRustExpr v101 v102 
    let _run_target_args'_v7 = v103 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v104 : string = "\u001b[90m"
    let v105 : string = method16()
    let v106 : string = v104 + v6 
    let v107 : string = v106 + v105 
    let _run_target_args'_v7 = v107 
    #endif
#if FABLE_COMPILER_PYTHON
    let v108 : string = "\u001b[90m"
    let v109 : string = method16()
    let v110 : string = v108 + v6 
    let v111 : string = v110 + v109 
    let _run_target_args'_v7 = v111 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v112 : string = "\u001b[90m"
    let v113 : string = method16()
    let v114 : string = v112 + v6 
    let v115 : string = v114 + v113 
    let _run_target_args'_v7 = v115 
    #endif
#else
    let v116 : string = "\u001b[90m"
    let v117 : string = method16()
    let v118 : string = v116 + v6 
    let v119 : string = v118 + v117 
    let _run_target_args'_v7 = v119 
    #endif
    let v120 : string = _run_target_args'_v7 
    v120
and method18 (v0 : int32, v1 : string) : string =
    let v2 : string = method15()
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
and method19 (v0 : string) : string =
    let v1 : char list = []
    let v2 : (char list -> (char [])) = List.toArray
    let v3 : (char []) = v2 v1
    let v6 : string = v0.TrimStart v3 
    let v30 : char list = []
    let v31 : char list = '/' :: v30 
    let v34 : char list = ' ' :: v31 
    let v37 : (char list -> (char [])) = List.toArray
    let v38 : (char []) = v37 v34
    let v41 : string = v6.TrimEnd v38 
    v41
and method17 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : int32, v9 : string) : string =
    let v10 : string = method18(v8, v9)
    let v11 : int64 = v0.l0
    let v12 : string = "networking.test_port_open"
    let v13 : string = $"{v6} {v7} #{v11} %s{v12} / {v10}"
    method19(v13)
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
and method20 (v0 : string) : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure0()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v17 : Mut0, v18 : Mut1, v19 : Mut2, v20 : Mut3, v21 : Mut4, v22 : int64 option) = TraceState.trace_state.Value
    let v35 : unit = ()
    let v36 : (unit -> unit) = closure8(v17)
    let v37 : unit = (fun () -> v36 (); v35) ()
    let v40 : (string -> unit) = closure9()
    (* run_target_args'
    let v41 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v42 : string = @"println!(""{}"", $0)"
    Fable.Core.RustInterop.emitRustExpr v0 v42 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v43 : string = @"println!(""{}"", $0)"
    Fable.Core.RustInterop.emitRustExpr v0 v43 
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
    (* run_target_args'
    let v54 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v55 : string = "&*$0"
    let v56 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v53 v55 
    let _run_target_args'_v54 = v56 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v57 : string = "&*$0"
    let v58 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v53 v57 
    let _run_target_args'_v54 = v58 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v59 : string = "&*$0"
    let v60 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v53 v59 
    let _run_target_args'_v54 = v60 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v61 : Ref<Str> = v53 |> unbox<Ref<Str>>
    let _run_target_args'_v54 = v61 
    #endif
#if FABLE_COMPILER_PYTHON
    let v64 : Ref<Str> = v53 |> unbox<Ref<Str>>
    let _run_target_args'_v54 = v64 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v67 : Ref<Str> = v53 |> unbox<Ref<Str>>
    let _run_target_args'_v54 = v67 
    #endif
#else
    let v70 : Ref<Str> = v53 |> unbox<Ref<Str>>
    let _run_target_args'_v54 = v70 
    #endif
    let v73 : Ref<Str> = _run_target_args'_v54 
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
    let v98 : int32 = v97 |> int32 
    let v105 : string = ""
    let v106 : bool = v0 <> v105 
    let v110 : bool =
        if v106 then
            let v109 : bool = v98 <= 1
            v109
        else
            false
    if v110 then
        v20.l0 <- v53
        ()
    else
        v20.l0 <- v105
        let v111 : string = "true; $0.into_iter().for_each(|x| { //"
        let v112 : bool = Fable.Core.RustInterop.emitRustExpr v95 v111 
        let v113 : string = "x"
        let v114 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v113 
        let v115 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
        let v116 : bool = Fable.Core.RustInterop.emitRustExpr v114 v115 
        let v117 : string = $"true"
        let v118 : bool = Fable.Core.RustInterop.emitRustExpr () v117 
        let v119 : string = "true; }); //"
        let v120 : bool = Fable.Core.RustInterop.emitRustExpr () v119 
        ()
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    v40 v0
    #endif
#if FABLE_COMPILER_PYTHON
    v40 v0
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    v40 v0
    #endif
#else
    v40 v0
    #endif
    // run_target_args' is_unit
    let v121 : (string -> unit) = v18.l0
    v121 v0
and closure5 (v0 : int32, v1 : exn) () : unit =
    let v2 : US0 = US0_0
    let v3 : bool = method8(v2)
    if v3 then
        let v4 : unit = ()
        let v5 : (unit -> unit) = closure0()
        let v6 : unit = (fun () -> v5 (); v4) ()
        let struct (v20 : Mut0, v21 : Mut1, v22 : Mut2, v23 : Mut3, v24 : Mut4, v25 : int64 option) = TraceState.trace_state.Value
        let v38 : string = method9(v20, v21, v22, v23, v24, v25)
        let v39 : string = method13()
        (* run_target_args'
        let v40 : unit = ()
        run_target_args' *)
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v41 : string = $"%A{v1}"
        let _run_target_args'_v40 = v41 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v44 : string = $"%A{v1}"
        let _run_target_args'_v40 = v44 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v47 : string = $"%A{v1}"
        let _run_target_args'_v40 = v47 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v50 : string = $"%A{v1}"
        let _run_target_args'_v40 = v50 
        #endif
#if FABLE_COMPILER_PYTHON
        let v53 : string = $"%A{v1}"
        let _run_target_args'_v40 = v53 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v56 : string = $"%A{v1}"
        let _run_target_args'_v40 = v56 
        #endif
#else
        let v59 : string = $"{v1.GetType ()}: {v1.Message}"
        let _run_target_args'_v40 = v59 
        #endif
        let v60 : string = _run_target_args'_v40 
        let v65 : string = method17(v20, v21, v22, v23, v24, v25, v38, v39, v0, v60)
        method20(v65)
and method7 (v0 : string, v1 : int32) : Async<bool> =
    (* run_target_args'
    let v2 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : Async<bool> = null |> unbox<Async<bool>>
    let _run_target_args'_v2 = v3 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v6 : Async<bool> = null |> unbox<Async<bool>>
    let _run_target_args'_v2 = v6 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v9 : Async<bool> = null |> unbox<Async<bool>>
    let _run_target_args'_v2 = v9 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v12 : unit = ()
    let _let'_v12 =
        async {
            let v15 : Async<System.Threading.CancellationToken> = Async.CancellationToken
            let! v15 = v15 
            let v16 : System.Threading.CancellationToken = v15 
            (* run_target_args'
            let v17 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v18 : System_Net_Sockets_TcpClient = null |> unbox<System_Net_Sockets_TcpClient>
            let _run_target_args'_v17 = v18 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v21 : System_Net_Sockets_TcpClient = null |> unbox<System_Net_Sockets_TcpClient>
            let _run_target_args'_v17 = v21 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v24 : System_Net_Sockets_TcpClient = null |> unbox<System_Net_Sockets_TcpClient>
            let _run_target_args'_v17 = v24 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v27 : System_Net_Sockets_TcpClient = null |> unbox<System_Net_Sockets_TcpClient>
            let _run_target_args'_v17 = v27 
            #endif
#if FABLE_COMPILER_PYTHON
            let v30 : System_Net_Sockets_TcpClient = null |> unbox<System_Net_Sockets_TcpClient>
            let _run_target_args'_v17 = v30 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v33 : System_Net_Sockets_TcpClient = null |> unbox<System_Net_Sockets_TcpClient>
            let _run_target_args'_v17 = v33 
            #endif
#else
            let v36 : System_Net_Sockets_TcpClient = new System_Net_Sockets_TcpClient ()
            let _run_target_args'_v17 = v36 
            #endif
            let v37 : System_Net_Sockets_TcpClient = _run_target_args'_v17 
            use v37 = v37 
            let v42 : System_Net_Sockets_TcpClient = v37 
            try
                (* run_target_args'
                let v43 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v44 : System.Threading.Tasks.ValueTask = null |> unbox<System.Threading.Tasks.ValueTask>
                let _run_target_args'_v43 = v44 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v47 : System.Threading.Tasks.ValueTask = null |> unbox<System.Threading.Tasks.ValueTask>
                let _run_target_args'_v43 = v47 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v50 : System.Threading.Tasks.ValueTask = null |> unbox<System.Threading.Tasks.ValueTask>
                let _run_target_args'_v43 = v50 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v53 : System.Threading.Tasks.ValueTask = null |> unbox<System.Threading.Tasks.ValueTask>
                let _run_target_args'_v43 = v53 
                #endif
#if FABLE_COMPILER_PYTHON
                let v56 : System.Threading.Tasks.ValueTask = null |> unbox<System.Threading.Tasks.ValueTask>
                let _run_target_args'_v43 = v56 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v59 : System.Threading.Tasks.ValueTask = null |> unbox<System.Threading.Tasks.ValueTask>
                let _run_target_args'_v43 = v59 
                #endif
#else
                let v62 : System.Threading.Tasks.ValueTask = v42.ConnectAsync (v0, v1, v16)
                let _run_target_args'_v43 = v62 
                #endif
                let v63 : System.Threading.Tasks.ValueTask = _run_target_args'_v43 
                (* run_target_args'
                let v68 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v69 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v68 = v69 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v72 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v68 = v72 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v75 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v68 = v75 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v78 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v68 = v78 
                #endif
#if FABLE_COMPILER_PYTHON
                let v81 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v68 = v81 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v84 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v68 = v84 
                #endif
#else
                let v87 : (unit -> System.Threading.Tasks.Task) = v63.AsTask
                let v88 : System.Threading.Tasks.Task = v87 ()
                let _run_target_args'_v68 = v88 
                #endif
                let v89 : System.Threading.Tasks.Task = _run_target_args'_v68 
                (* run_target_args'
                let v94 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v95 : Async<unit> = null |> unbox<Async<unit>>
                let _run_target_args'_v94 = v95 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v98 : Async<unit> = null |> unbox<Async<unit>>
                let _run_target_args'_v94 = v98 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v101 : Async<unit> = null |> unbox<Async<unit>>
                let _run_target_args'_v94 = v101 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v104 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                let v105 : Async<unit> = v104 v89
                let _run_target_args'_v94 = v105 
                #endif
#if FABLE_COMPILER_PYTHON
                let v106 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                let v107 : Async<unit> = v106 v89
                let _run_target_args'_v94 = v107 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v108 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                let v109 : Async<unit> = v108 v89
                let _run_target_args'_v94 = v109 
                #endif
#else
                let v110 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                let v111 : Async<unit> = v110 v89
                let _run_target_args'_v94 = v111 
                #endif
                let v112 : Async<unit> = _run_target_args'_v94 
                do! v112 
                return true 
                (* indent
                ()
            indent *)
            with ex ->
                let v191 : exn = ex
                let v192 : unit = ()
                let v193 : (unit -> unit) = closure5(v1, v191)
                let v194 : unit = (fun () -> v193 (); v192) ()
                return false 
                (* indent
                ()
            indent *)
            (* try_unit
            let v327 : bool = try_unit *)
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v2535 : Async<bool> = _let'_v12 
    let _run_target_args'_v2 = v2535 
    #endif
#if FABLE_COMPILER_PYTHON
    let v2536 : unit = ()
    let _let'_v2536 =
        async {
            let v2539 : Async<System.Threading.CancellationToken> = Async.CancellationToken
            let! v2539 = v2539 
            let v2540 : System.Threading.CancellationToken = v2539 
            (* run_target_args'
            let v2541 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v2542 : System_Net_Sockets_TcpClient = null |> unbox<System_Net_Sockets_TcpClient>
            let _run_target_args'_v2541 = v2542 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v2545 : System_Net_Sockets_TcpClient = null |> unbox<System_Net_Sockets_TcpClient>
            let _run_target_args'_v2541 = v2545 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v2548 : System_Net_Sockets_TcpClient = null |> unbox<System_Net_Sockets_TcpClient>
            let _run_target_args'_v2541 = v2548 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v2551 : System_Net_Sockets_TcpClient = null |> unbox<System_Net_Sockets_TcpClient>
            let _run_target_args'_v2541 = v2551 
            #endif
#if FABLE_COMPILER_PYTHON
            let v2554 : System_Net_Sockets_TcpClient = null |> unbox<System_Net_Sockets_TcpClient>
            let _run_target_args'_v2541 = v2554 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v2557 : System_Net_Sockets_TcpClient = null |> unbox<System_Net_Sockets_TcpClient>
            let _run_target_args'_v2541 = v2557 
            #endif
#else
            let v2560 : System_Net_Sockets_TcpClient = new System_Net_Sockets_TcpClient ()
            let _run_target_args'_v2541 = v2560 
            #endif
            let v2561 : System_Net_Sockets_TcpClient = _run_target_args'_v2541 
            use v2561 = v2561 
            let v2566 : System_Net_Sockets_TcpClient = v2561 
            try
                (* run_target_args'
                let v2567 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v2568 : System.Threading.Tasks.ValueTask = null |> unbox<System.Threading.Tasks.ValueTask>
                let _run_target_args'_v2567 = v2568 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v2571 : System.Threading.Tasks.ValueTask = null |> unbox<System.Threading.Tasks.ValueTask>
                let _run_target_args'_v2567 = v2571 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v2574 : System.Threading.Tasks.ValueTask = null |> unbox<System.Threading.Tasks.ValueTask>
                let _run_target_args'_v2567 = v2574 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v2577 : System.Threading.Tasks.ValueTask = null |> unbox<System.Threading.Tasks.ValueTask>
                let _run_target_args'_v2567 = v2577 
                #endif
#if FABLE_COMPILER_PYTHON
                let v2580 : System.Threading.Tasks.ValueTask = null |> unbox<System.Threading.Tasks.ValueTask>
                let _run_target_args'_v2567 = v2580 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v2583 : System.Threading.Tasks.ValueTask = null |> unbox<System.Threading.Tasks.ValueTask>
                let _run_target_args'_v2567 = v2583 
                #endif
#else
                let v2586 : System.Threading.Tasks.ValueTask = v2566.ConnectAsync (v0, v1, v2540)
                let _run_target_args'_v2567 = v2586 
                #endif
                let v2587 : System.Threading.Tasks.ValueTask = _run_target_args'_v2567 
                (* run_target_args'
                let v2592 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v2593 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v2592 = v2593 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v2596 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v2592 = v2596 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v2599 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v2592 = v2599 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v2602 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v2592 = v2602 
                #endif
#if FABLE_COMPILER_PYTHON
                let v2605 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v2592 = v2605 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v2608 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v2592 = v2608 
                #endif
#else
                let v2611 : (unit -> System.Threading.Tasks.Task) = v2587.AsTask
                let v2612 : System.Threading.Tasks.Task = v2611 ()
                let _run_target_args'_v2592 = v2612 
                #endif
                let v2613 : System.Threading.Tasks.Task = _run_target_args'_v2592 
                (* run_target_args'
                let v2618 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v2619 : Async<unit> = null |> unbox<Async<unit>>
                let _run_target_args'_v2618 = v2619 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v2622 : Async<unit> = null |> unbox<Async<unit>>
                let _run_target_args'_v2618 = v2622 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v2625 : Async<unit> = null |> unbox<Async<unit>>
                let _run_target_args'_v2618 = v2625 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v2628 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                let v2629 : Async<unit> = v2628 v2613
                let _run_target_args'_v2618 = v2629 
                #endif
#if FABLE_COMPILER_PYTHON
                let v2630 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                let v2631 : Async<unit> = v2630 v2613
                let _run_target_args'_v2618 = v2631 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v2632 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                let v2633 : Async<unit> = v2632 v2613
                let _run_target_args'_v2618 = v2633 
                #endif
#else
                let v2634 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                let v2635 : Async<unit> = v2634 v2613
                let _run_target_args'_v2618 = v2635 
                #endif
                let v2636 : Async<unit> = _run_target_args'_v2618 
                do! v2636 
                return true 
                (* indent
                ()
            indent *)
            with ex ->
                let v2715 : exn = ex
                let v2716 : unit = ()
                let v2717 : (unit -> unit) = closure5(v1, v2715)
                let v2718 : unit = (fun () -> v2717 (); v2716) ()
                return false 
                (* indent
                ()
            indent *)
            (* try_unit
            let v2851 : bool = try_unit *)
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v5059 : Async<bool> = _let'_v2536 
    let _run_target_args'_v2 = v5059 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v5060 : unit = ()
    let _let'_v5060 =
        async {
            let v5063 : Async<System.Threading.CancellationToken> = Async.CancellationToken
            let! v5063 = v5063 
            let v5064 : System.Threading.CancellationToken = v5063 
            (* run_target_args'
            let v5065 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v5066 : System_Net_Sockets_TcpClient = null |> unbox<System_Net_Sockets_TcpClient>
            let _run_target_args'_v5065 = v5066 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v5069 : System_Net_Sockets_TcpClient = null |> unbox<System_Net_Sockets_TcpClient>
            let _run_target_args'_v5065 = v5069 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v5072 : System_Net_Sockets_TcpClient = null |> unbox<System_Net_Sockets_TcpClient>
            let _run_target_args'_v5065 = v5072 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v5075 : System_Net_Sockets_TcpClient = null |> unbox<System_Net_Sockets_TcpClient>
            let _run_target_args'_v5065 = v5075 
            #endif
#if FABLE_COMPILER_PYTHON
            let v5078 : System_Net_Sockets_TcpClient = null |> unbox<System_Net_Sockets_TcpClient>
            let _run_target_args'_v5065 = v5078 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v5081 : System_Net_Sockets_TcpClient = null |> unbox<System_Net_Sockets_TcpClient>
            let _run_target_args'_v5065 = v5081 
            #endif
#else
            let v5084 : System_Net_Sockets_TcpClient = new System_Net_Sockets_TcpClient ()
            let _run_target_args'_v5065 = v5084 
            #endif
            let v5085 : System_Net_Sockets_TcpClient = _run_target_args'_v5065 
            use v5085 = v5085 
            let v5090 : System_Net_Sockets_TcpClient = v5085 
            try
                (* run_target_args'
                let v5091 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v5092 : System.Threading.Tasks.ValueTask = null |> unbox<System.Threading.Tasks.ValueTask>
                let _run_target_args'_v5091 = v5092 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v5095 : System.Threading.Tasks.ValueTask = null |> unbox<System.Threading.Tasks.ValueTask>
                let _run_target_args'_v5091 = v5095 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v5098 : System.Threading.Tasks.ValueTask = null |> unbox<System.Threading.Tasks.ValueTask>
                let _run_target_args'_v5091 = v5098 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v5101 : System.Threading.Tasks.ValueTask = null |> unbox<System.Threading.Tasks.ValueTask>
                let _run_target_args'_v5091 = v5101 
                #endif
#if FABLE_COMPILER_PYTHON
                let v5104 : System.Threading.Tasks.ValueTask = null |> unbox<System.Threading.Tasks.ValueTask>
                let _run_target_args'_v5091 = v5104 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v5107 : System.Threading.Tasks.ValueTask = null |> unbox<System.Threading.Tasks.ValueTask>
                let _run_target_args'_v5091 = v5107 
                #endif
#else
                let v5110 : System.Threading.Tasks.ValueTask = v5090.ConnectAsync (v0, v1, v5064)
                let _run_target_args'_v5091 = v5110 
                #endif
                let v5111 : System.Threading.Tasks.ValueTask = _run_target_args'_v5091 
                (* run_target_args'
                let v5116 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v5117 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v5116 = v5117 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v5120 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v5116 = v5120 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v5123 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v5116 = v5123 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v5126 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v5116 = v5126 
                #endif
#if FABLE_COMPILER_PYTHON
                let v5129 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v5116 = v5129 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v5132 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v5116 = v5132 
                #endif
#else
                let v5135 : (unit -> System.Threading.Tasks.Task) = v5111.AsTask
                let v5136 : System.Threading.Tasks.Task = v5135 ()
                let _run_target_args'_v5116 = v5136 
                #endif
                let v5137 : System.Threading.Tasks.Task = _run_target_args'_v5116 
                (* run_target_args'
                let v5142 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v5143 : Async<unit> = null |> unbox<Async<unit>>
                let _run_target_args'_v5142 = v5143 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v5146 : Async<unit> = null |> unbox<Async<unit>>
                let _run_target_args'_v5142 = v5146 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v5149 : Async<unit> = null |> unbox<Async<unit>>
                let _run_target_args'_v5142 = v5149 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v5152 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                let v5153 : Async<unit> = v5152 v5137
                let _run_target_args'_v5142 = v5153 
                #endif
#if FABLE_COMPILER_PYTHON
                let v5154 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                let v5155 : Async<unit> = v5154 v5137
                let _run_target_args'_v5142 = v5155 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v5156 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                let v5157 : Async<unit> = v5156 v5137
                let _run_target_args'_v5142 = v5157 
                #endif
#else
                let v5158 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                let v5159 : Async<unit> = v5158 v5137
                let _run_target_args'_v5142 = v5159 
                #endif
                let v5160 : Async<unit> = _run_target_args'_v5142 
                do! v5160 
                return true 
                (* indent
                ()
            indent *)
            with ex ->
                let v5239 : exn = ex
                let v5240 : unit = ()
                let v5241 : (unit -> unit) = closure5(v1, v5239)
                let v5242 : unit = (fun () -> v5241 (); v5240) ()
                return false 
                (* indent
                ()
            indent *)
            (* try_unit
            let v5375 : bool = try_unit *)
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v7583 : Async<bool> = _let'_v5060 
    let _run_target_args'_v2 = v7583 
    #endif
#else
    let v7584 : unit = ()
    let _let'_v7584 =
        async {
            let v7587 : Async<System.Threading.CancellationToken> = Async.CancellationToken
            let! v7587 = v7587 
            let v7588 : System.Threading.CancellationToken = v7587 
            (* run_target_args'
            let v7589 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v7590 : System_Net_Sockets_TcpClient = null |> unbox<System_Net_Sockets_TcpClient>
            let _run_target_args'_v7589 = v7590 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v7593 : System_Net_Sockets_TcpClient = null |> unbox<System_Net_Sockets_TcpClient>
            let _run_target_args'_v7589 = v7593 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v7596 : System_Net_Sockets_TcpClient = null |> unbox<System_Net_Sockets_TcpClient>
            let _run_target_args'_v7589 = v7596 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v7599 : System_Net_Sockets_TcpClient = null |> unbox<System_Net_Sockets_TcpClient>
            let _run_target_args'_v7589 = v7599 
            #endif
#if FABLE_COMPILER_PYTHON
            let v7602 : System_Net_Sockets_TcpClient = null |> unbox<System_Net_Sockets_TcpClient>
            let _run_target_args'_v7589 = v7602 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v7605 : System_Net_Sockets_TcpClient = null |> unbox<System_Net_Sockets_TcpClient>
            let _run_target_args'_v7589 = v7605 
            #endif
#else
            let v7608 : System_Net_Sockets_TcpClient = new System_Net_Sockets_TcpClient ()
            let _run_target_args'_v7589 = v7608 
            #endif
            let v7609 : System_Net_Sockets_TcpClient = _run_target_args'_v7589 
            use v7609 = v7609 
            let v7614 : System_Net_Sockets_TcpClient = v7609 
            try
                (* run_target_args'
                let v7615 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v7616 : System.Threading.Tasks.ValueTask = null |> unbox<System.Threading.Tasks.ValueTask>
                let _run_target_args'_v7615 = v7616 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v7619 : System.Threading.Tasks.ValueTask = null |> unbox<System.Threading.Tasks.ValueTask>
                let _run_target_args'_v7615 = v7619 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v7622 : System.Threading.Tasks.ValueTask = null |> unbox<System.Threading.Tasks.ValueTask>
                let _run_target_args'_v7615 = v7622 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v7625 : System.Threading.Tasks.ValueTask = null |> unbox<System.Threading.Tasks.ValueTask>
                let _run_target_args'_v7615 = v7625 
                #endif
#if FABLE_COMPILER_PYTHON
                let v7628 : System.Threading.Tasks.ValueTask = null |> unbox<System.Threading.Tasks.ValueTask>
                let _run_target_args'_v7615 = v7628 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v7631 : System.Threading.Tasks.ValueTask = null |> unbox<System.Threading.Tasks.ValueTask>
                let _run_target_args'_v7615 = v7631 
                #endif
#else
                let v7634 : System.Threading.Tasks.ValueTask = v7614.ConnectAsync (v0, v1, v7588)
                let _run_target_args'_v7615 = v7634 
                #endif
                let v7635 : System.Threading.Tasks.ValueTask = _run_target_args'_v7615 
                (* run_target_args'
                let v7640 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v7641 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v7640 = v7641 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v7644 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v7640 = v7644 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v7647 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v7640 = v7647 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v7650 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v7640 = v7650 
                #endif
#if FABLE_COMPILER_PYTHON
                let v7653 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v7640 = v7653 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v7656 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v7640 = v7656 
                #endif
#else
                let v7659 : (unit -> System.Threading.Tasks.Task) = v7635.AsTask
                let v7660 : System.Threading.Tasks.Task = v7659 ()
                let _run_target_args'_v7640 = v7660 
                #endif
                let v7661 : System.Threading.Tasks.Task = _run_target_args'_v7640 
                (* run_target_args'
                let v7666 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v7667 : Async<unit> = null |> unbox<Async<unit>>
                let _run_target_args'_v7666 = v7667 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v7670 : Async<unit> = null |> unbox<Async<unit>>
                let _run_target_args'_v7666 = v7670 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v7673 : Async<unit> = null |> unbox<Async<unit>>
                let _run_target_args'_v7666 = v7673 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v7676 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                let v7677 : Async<unit> = v7676 v7661
                let _run_target_args'_v7666 = v7677 
                #endif
#if FABLE_COMPILER_PYTHON
                let v7678 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                let v7679 : Async<unit> = v7678 v7661
                let _run_target_args'_v7666 = v7679 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v7680 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                let v7681 : Async<unit> = v7680 v7661
                let _run_target_args'_v7666 = v7681 
                #endif
#else
                let v7682 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                let v7683 : Async<unit> = v7682 v7661
                let _run_target_args'_v7666 = v7683 
                #endif
                let v7684 : Async<unit> = _run_target_args'_v7666 
                do! v7684 
                return true 
                (* indent
                ()
            indent *)
            with ex ->
                let v7763 : exn = ex
                let v7764 : unit = ()
                let v7765 : (unit -> unit) = closure5(v1, v7763)
                let v7766 : unit = (fun () -> v7765 (); v7764) ()
                return false 
                (* indent
                ()
            indent *)
            (* try_unit
            let v7899 : bool = try_unit *)
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v10107 : Async<bool> = _let'_v7584 
    let _run_target_args'_v2 = v10107 
    #endif
    let v10108 : Async<bool> = _run_target_args'_v2 
    v10108
and method6 (v0 : string, v1 : int32) : Async<bool> =
    method7(v0, v1)
and closure4 (v0 : string) (v1 : int32) : Async<bool> =
    method6(v0, v1)
and closure3 () (v0 : string) : (int32 -> Async<bool>) =
    closure4(v0)
and closure14 () (v0 : bool) : US7 =
    US7_0(v0)
and method26 () : (bool -> US7) =
    closure14()
and closure15 () (v0 : exn) : US7 =
    US7_1(v0)
and method27 () : (exn -> US7) =
    closure15()
and method25 (v0 : Async<Choice<bool, exn>>) : Async<US7> =
    (* run_target_args'
    let v1 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : Async<US7> = null |> unbox<Async<US7>>
    let _run_target_args'_v1 = v2 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v5 : Async<US7> = null |> unbox<Async<US7>>
    let _run_target_args'_v1 = v5 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v8 : Async<US7> = null |> unbox<Async<US7>>
    let _run_target_args'_v1 = v8 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v11 : unit = ()
    let _let'_v11 =
        async {
            let! v0 = v0 
            let v14 : Choice<bool, exn> = v0 
            (* run_target_args'
            let v15 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v16 : US7 = null |> unbox<US7>
            let _run_target_args'_v15 = v16 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v19 : US7 = null |> unbox<US7>
            let _run_target_args'_v15 = v19 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v22 : US7 = null |> unbox<US7>
            let _run_target_args'_v15 = v22 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v25 : US7 = null |> unbox<US7>
            let _run_target_args'_v15 = v25 
            #endif
#if FABLE_COMPILER_PYTHON
            let v28 : US7 = null |> unbox<US7>
            let _run_target_args'_v15 = v28 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v31 : (bool -> US7) = method26()
            let v32 : (exn -> US7) = method27()
            let v33 : US7 = match v14 with Choice1Of2 x -> v31 x | Choice2Of2 x -> v32 x
            let _run_target_args'_v15 = v33 
            #endif
#else
            let v34 : (bool -> US7) = method26()
            let v35 : (exn -> US7) = method27()
            let v36 : US7 = match v14 with Choice1Of2 x -> v34 x | Choice2Of2 x -> v35 x
            let _run_target_args'_v15 = v36 
            #endif
            let v37 : US7 = _run_target_args'_v15 
            return v37 
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v238 : Async<US7> = _let'_v11 
    let _run_target_args'_v1 = v238 
    #endif
#if FABLE_COMPILER_PYTHON
    let v239 : unit = ()
    let _let'_v239 =
        async {
            let! v0 = v0 
            let v242 : Choice<bool, exn> = v0 
            (* run_target_args'
            let v243 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v244 : US7 = null |> unbox<US7>
            let _run_target_args'_v243 = v244 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v247 : US7 = null |> unbox<US7>
            let _run_target_args'_v243 = v247 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v250 : US7 = null |> unbox<US7>
            let _run_target_args'_v243 = v250 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v253 : US7 = null |> unbox<US7>
            let _run_target_args'_v243 = v253 
            #endif
#if FABLE_COMPILER_PYTHON
            let v256 : US7 = null |> unbox<US7>
            let _run_target_args'_v243 = v256 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v259 : (bool -> US7) = method26()
            let v260 : (exn -> US7) = method27()
            let v261 : US7 = match v242 with Choice1Of2 x -> v259 x | Choice2Of2 x -> v260 x
            let _run_target_args'_v243 = v261 
            #endif
#else
            let v262 : (bool -> US7) = method26()
            let v263 : (exn -> US7) = method27()
            let v264 : US7 = match v242 with Choice1Of2 x -> v262 x | Choice2Of2 x -> v263 x
            let _run_target_args'_v243 = v264 
            #endif
            let v265 : US7 = _run_target_args'_v243 
            return v265 
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v466 : Async<US7> = _let'_v239 
    let _run_target_args'_v1 = v466 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v467 : unit = ()
    let _let'_v467 =
        async {
            let! v0 = v0 
            let v470 : Choice<bool, exn> = v0 
            (* run_target_args'
            let v471 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v472 : US7 = null |> unbox<US7>
            let _run_target_args'_v471 = v472 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v475 : US7 = null |> unbox<US7>
            let _run_target_args'_v471 = v475 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v478 : US7 = null |> unbox<US7>
            let _run_target_args'_v471 = v478 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v481 : US7 = null |> unbox<US7>
            let _run_target_args'_v471 = v481 
            #endif
#if FABLE_COMPILER_PYTHON
            let v484 : US7 = null |> unbox<US7>
            let _run_target_args'_v471 = v484 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v487 : (bool -> US7) = method26()
            let v488 : (exn -> US7) = method27()
            let v489 : US7 = match v470 with Choice1Of2 x -> v487 x | Choice2Of2 x -> v488 x
            let _run_target_args'_v471 = v489 
            #endif
#else
            let v490 : (bool -> US7) = method26()
            let v491 : (exn -> US7) = method27()
            let v492 : US7 = match v470 with Choice1Of2 x -> v490 x | Choice2Of2 x -> v491 x
            let _run_target_args'_v471 = v492 
            #endif
            let v493 : US7 = _run_target_args'_v471 
            return v493 
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v694 : Async<US7> = _let'_v467 
    let _run_target_args'_v1 = v694 
    #endif
#else
    let v695 : unit = ()
    let _let'_v695 =
        async {
            let! v0 = v0 
            let v698 : Choice<bool, exn> = v0 
            (* run_target_args'
            let v699 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v700 : US7 = null |> unbox<US7>
            let _run_target_args'_v699 = v700 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v703 : US7 = null |> unbox<US7>
            let _run_target_args'_v699 = v703 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v706 : US7 = null |> unbox<US7>
            let _run_target_args'_v699 = v706 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v709 : US7 = null |> unbox<US7>
            let _run_target_args'_v699 = v709 
            #endif
#if FABLE_COMPILER_PYTHON
            let v712 : US7 = null |> unbox<US7>
            let _run_target_args'_v699 = v712 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v715 : (bool -> US7) = method26()
            let v716 : (exn -> US7) = method27()
            let v717 : US7 = match v698 with Choice1Of2 x -> v715 x | Choice2Of2 x -> v716 x
            let _run_target_args'_v699 = v717 
            #endif
#else
            let v718 : (bool -> US7) = method26()
            let v719 : (exn -> US7) = method27()
            let v720 : US7 = match v698 with Choice1Of2 x -> v718 x | Choice2Of2 x -> v719 x
            let _run_target_args'_v699 = v720 
            #endif
            let v721 : US7 = _run_target_args'_v699 
            return v721 
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v922 : Async<US7> = _let'_v695 
    let _run_target_args'_v1 = v922 
    #endif
    let v923 : Async<US7> = _run_target_args'_v1 
    v923
and method28 (v0 : Async<US7>) : Async<US8> =
    (* run_target_args'
    let v1 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : Async<US8> = null |> unbox<Async<US8>>
    let _run_target_args'_v1 = v2 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v5 : Async<US8> = null |> unbox<Async<US8>>
    let _run_target_args'_v1 = v5 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v8 : Async<US8> = null |> unbox<Async<US8>>
    let _run_target_args'_v1 = v8 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v11 : unit = ()
    let _let'_v11 =
        async {
            let! v0 = v0 
            let v14 : US7 = v0 
            let v20 : US8 =
                match v14 with
                | US7_0(v15) -> (* C1of2 *)
                    US8_0(v15)
                | US7_1(v17) -> (* C2of2 *)
                    US8_1(v17)
            return v20 
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v70 : Async<US8> = _let'_v11 
    let _run_target_args'_v1 = v70 
    #endif
#if FABLE_COMPILER_PYTHON
    let v71 : unit = ()
    let _let'_v71 =
        async {
            let! v0 = v0 
            let v74 : US7 = v0 
            let v80 : US8 =
                match v74 with
                | US7_0(v75) -> (* C1of2 *)
                    US8_0(v75)
                | US7_1(v77) -> (* C2of2 *)
                    US8_1(v77)
            return v80 
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v130 : Async<US8> = _let'_v71 
    let _run_target_args'_v1 = v130 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v131 : unit = ()
    let _let'_v131 =
        async {
            let! v0 = v0 
            let v134 : US7 = v0 
            let v140 : US8 =
                match v134 with
                | US7_0(v135) -> (* C1of2 *)
                    US8_0(v135)
                | US7_1(v137) -> (* C2of2 *)
                    US8_1(v137)
            return v140 
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v190 : Async<US8> = _let'_v131 
    let _run_target_args'_v1 = v190 
    #endif
#else
    let v191 : unit = ()
    let _let'_v191 =
        async {
            let! v0 = v0 
            let v194 : US7 = v0 
            let v200 : US8 =
                match v194 with
                | US7_0(v195) -> (* C1of2 *)
                    US8_0(v195)
                | US7_1(v197) -> (* C2of2 *)
                    US8_1(v197)
            return v200 
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v250 : Async<US8> = _let'_v191 
    let _run_target_args'_v1 = v250 
    #endif
    let v251 : Async<US8> = _run_target_args'_v1 
    v251
and method31 (v0 : int32) : string =
    let v1 : string = method15()
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
and method30 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : int32) : string =
    let v9 : string = method31(v8)
    let v10 : int64 = v0.l0
    let v11 : string = "async.run_with_timeout_async"
    let v12 : string = $"{v6} {v7} #{v10} %s{v11} / {v9}"
    method19(v12)
and closure16 (v0 : int32) () : unit =
    let v1 : US0 = US0_0
    let v2 : bool = method8(v1)
    if v2 then
        let v3 : unit = ()
        let v4 : (unit -> unit) = closure0()
        let v5 : unit = (fun () -> v4 (); v3) ()
        let struct (v19 : Mut0, v20 : Mut1, v21 : Mut2, v22 : Mut3, v23 : Mut4, v24 : int64 option) = TraceState.trace_state.Value
        let v37 : string = method9(v19, v20, v21, v22, v23, v24)
        let v38 : string = method13()
        let v39 : string = method30(v19, v20, v21, v22, v23, v24, v37, v38, v0)
        method20(v39)
and method32 () : string =
    
    
    
    
    
    let v0 : string = "Critical"
    let v1 : (unit -> string) = v0.ToLower
    let v2 : string = v1 ()
    let v5 : char = v2.[int 0]
    let v6 : string = method14(v5)
    (* run_target_args'
    let v7 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v8 : string = "inline_colorization::color_bright_red"
    let v9 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v8 
    (* run_target_args'
    let v10 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v11 : string = "&*$0"
    let v12 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v11 
    let _run_target_args'_v10 = v12 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v13 : string = "&*$0"
    let v14 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v13 
    let _run_target_args'_v10 = v14 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v15 : string = "&*$0"
    let v16 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v15 
    let _run_target_args'_v10 = v16 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v17 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _run_target_args'_v10 = v17 
    #endif
#if FABLE_COMPILER_PYTHON
    let v20 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _run_target_args'_v10 = v20 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v23 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _run_target_args'_v10 = v23 
    #endif
#else
    let v26 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _run_target_args'_v10 = v26 
    #endif
    let v29 : Ref<Str> = _run_target_args'_v10 
    let v34 : string = "inline_colorization::color_reset"
    let v35 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v34 
    let v36 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v37 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v9, v29, v35) v36 
    let v38 : string = "fable_library_rust::String_::fromString($0)"
    let v39 : string = Fable.Core.RustInterop.emitRustExpr v37 v38 
    let _run_target_args'_v7 = v39 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v40 : string = "inline_colorization::color_bright_red"
    let v41 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v40 
    (* run_target_args'
    let v42 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v43 : string = "&*$0"
    let v44 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v43 
    let _run_target_args'_v42 = v44 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v45 : string = "&*$0"
    let v46 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v45 
    let _run_target_args'_v42 = v46 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v47 : string = "&*$0"
    let v48 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v47 
    let _run_target_args'_v42 = v48 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v49 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _run_target_args'_v42 = v49 
    #endif
#if FABLE_COMPILER_PYTHON
    let v52 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _run_target_args'_v42 = v52 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v55 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _run_target_args'_v42 = v55 
    #endif
#else
    let v58 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _run_target_args'_v42 = v58 
    #endif
    let v61 : Ref<Str> = _run_target_args'_v42 
    let v66 : string = "inline_colorization::color_reset"
    let v67 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v66 
    let v68 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v69 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v41, v61, v67) v68 
    let v70 : string = "fable_library_rust::String_::fromString($0)"
    let v71 : string = Fable.Core.RustInterop.emitRustExpr v69 v70 
    let _run_target_args'_v7 = v71 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v72 : string = "inline_colorization::color_bright_red"
    let v73 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v72 
    (* run_target_args'
    let v74 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v75 : string = "&*$0"
    let v76 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v75 
    let _run_target_args'_v74 = v76 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v77 : string = "&*$0"
    let v78 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v77 
    let _run_target_args'_v74 = v78 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v79 : string = "&*$0"
    let v80 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v79 
    let _run_target_args'_v74 = v80 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v81 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _run_target_args'_v74 = v81 
    #endif
#if FABLE_COMPILER_PYTHON
    let v84 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _run_target_args'_v74 = v84 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v87 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _run_target_args'_v74 = v87 
    #endif
#else
    let v90 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _run_target_args'_v74 = v90 
    #endif
    let v93 : Ref<Str> = _run_target_args'_v74 
    let v98 : string = "inline_colorization::color_reset"
    let v99 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v98 
    let v100 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v101 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v73, v93, v99) v100 
    let v102 : string = "fable_library_rust::String_::fromString($0)"
    let v103 : string = Fable.Core.RustInterop.emitRustExpr v101 v102 
    let _run_target_args'_v7 = v103 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v104 : string = "\u001b[91m"
    let v105 : string = method16()
    let v106 : string = v104 + v6 
    let v107 : string = v106 + v105 
    let _run_target_args'_v7 = v107 
    #endif
#if FABLE_COMPILER_PYTHON
    let v108 : string = "\u001b[91m"
    let v109 : string = method16()
    let v110 : string = v108 + v6 
    let v111 : string = v110 + v109 
    let _run_target_args'_v7 = v111 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v112 : string = "\u001b[91m"
    let v113 : string = method16()
    let v114 : string = v112 + v6 
    let v115 : string = v114 + v113 
    let _run_target_args'_v7 = v115 
    #endif
#else
    let v116 : string = "\u001b[91m"
    let v117 : string = method16()
    let v118 : string = v116 + v6 
    let v119 : string = v118 + v117 
    let _run_target_args'_v7 = v119 
    #endif
    let v120 : string = _run_target_args'_v7 
    v120
and method34 (v0 : int32, v1 : string) : string =
    let v2 : string = method15()
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
and method33 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : int32, v9 : string) : string =
    let v10 : string = method34(v8, v9)
    let v11 : int64 = v0.l0
    let v12 : string = "async.run_with_timeout_async**"
    let v13 : string = $"{v6} {v7} #{v11} %s{v12} / {v10}"
    method19(v13)
and closure17 (v0 : int32, v1 : exn) () : unit =
    let v2 : US0 = US0_4
    let v3 : bool = method8(v2)
    if v3 then
        let v4 : unit = ()
        let v5 : (unit -> unit) = closure0()
        let v6 : unit = (fun () -> v5 (); v4) ()
        let struct (v20 : Mut0, v21 : Mut1, v22 : Mut2, v23 : Mut3, v24 : Mut4, v25 : int64 option) = TraceState.trace_state.Value
        let v38 : string = method9(v20, v21, v22, v23, v24, v25)
        let v39 : string = method32()
        (* run_target_args'
        let v40 : unit = ()
        run_target_args' *)
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v41 : string = $"%A{v1}"
        let _run_target_args'_v40 = v41 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v44 : string = $"%A{v1}"
        let _run_target_args'_v40 = v44 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v47 : string = $"%A{v1}"
        let _run_target_args'_v40 = v47 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v50 : string = $"%A{v1}"
        let _run_target_args'_v40 = v50 
        #endif
#if FABLE_COMPILER_PYTHON
        let v53 : string = $"%A{v1}"
        let _run_target_args'_v40 = v53 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v56 : string = $"%A{v1}"
        let _run_target_args'_v40 = v56 
        #endif
#else
        let v59 : string = $"{v1.GetType ()}: {v1.Message}"
        let _run_target_args'_v40 = v59 
        #endif
        let v60 : string = _run_target_args'_v40 
        let v65 : string = method33(v20, v21, v22, v23, v24, v25, v38, v39, v0, v60)
        method20(v65)
and method29 (v0 : int32, v1 : Async<US8>) : Async<US6> =
    (* run_target_args'
    let v2 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : Async<US6> = null |> unbox<Async<US6>>
    let _run_target_args'_v2 = v3 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v6 : Async<US6> = null |> unbox<Async<US6>>
    let _run_target_args'_v2 = v6 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v9 : Async<US6> = null |> unbox<Async<US6>>
    let _run_target_args'_v2 = v9 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v12 : unit = ()
    let _let'_v12 =
        async {
            let! v1 = v1 
            let v15 : US8 = v1 
            let v139 : US6 =
                match v15 with
                | US8_1(v18) -> (* Error *)
                    let v19 : string = $"%A{v18}"
                    let v22 : string = "System.TimeoutException"
                    let v23 : bool = v19.Contains v22 
                    if v23 then
                        let v26 : unit = ()
                        let v27 : (unit -> unit) = closure16(v0)
                        let v28 : unit = (fun () -> v27 (); v26) ()
                        US6_1
                    else
                        let v69 : unit = ()
                        let v70 : (unit -> unit) = closure17(v0, v18)
                        let v71 : unit = (fun () -> v70 (); v69) ()
                        US6_1
                | US8_0(v16) -> (* Ok *)
                    US6_0(v16)
            return v139 
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v1015 : Async<US6> = _let'_v12 
    let _run_target_args'_v2 = v1015 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1016 : unit = ()
    let _let'_v1016 =
        async {
            let! v1 = v1 
            let v1019 : US8 = v1 
            let v1143 : US6 =
                match v1019 with
                | US8_1(v1022) -> (* Error *)
                    let v1023 : string = $"%A{v1022}"
                    let v1026 : string = "System.TimeoutException"
                    let v1027 : bool = v1023.Contains v1026 
                    if v1027 then
                        let v1030 : unit = ()
                        let v1031 : (unit -> unit) = closure16(v0)
                        let v1032 : unit = (fun () -> v1031 (); v1030) ()
                        US6_1
                    else
                        let v1073 : unit = ()
                        let v1074 : (unit -> unit) = closure17(v0, v1022)
                        let v1075 : unit = (fun () -> v1074 (); v1073) ()
                        US6_1
                | US8_0(v1020) -> (* Ok *)
                    US6_0(v1020)
            return v1143 
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v2019 : Async<US6> = _let'_v1016 
    let _run_target_args'_v2 = v2019 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v2020 : unit = ()
    let _let'_v2020 =
        async {
            let! v1 = v1 
            let v2023 : US8 = v1 
            let v2147 : US6 =
                match v2023 with
                | US8_1(v2026) -> (* Error *)
                    let v2027 : string = $"%A{v2026}"
                    let v2030 : string = "System.TimeoutException"
                    let v2031 : bool = v2027.Contains v2030 
                    if v2031 then
                        let v2034 : unit = ()
                        let v2035 : (unit -> unit) = closure16(v0)
                        let v2036 : unit = (fun () -> v2035 (); v2034) ()
                        US6_1
                    else
                        let v2077 : unit = ()
                        let v2078 : (unit -> unit) = closure17(v0, v2026)
                        let v2079 : unit = (fun () -> v2078 (); v2077) ()
                        US6_1
                | US8_0(v2024) -> (* Ok *)
                    US6_0(v2024)
            return v2147 
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v3023 : Async<US6> = _let'_v2020 
    let _run_target_args'_v2 = v3023 
    #endif
#else
    let v3024 : unit = ()
    let _let'_v3024 =
        async {
            let! v1 = v1 
            let v3027 : US8 = v1 
            let v3151 : US6 =
                match v3027 with
                | US8_1(v3030) -> (* Error *)
                    let v3031 : string = $"%A{v3030}"
                    let v3034 : string = "System.TimeoutException"
                    let v3035 : bool = v3031.Contains v3034 
                    if v3035 then
                        let v3038 : unit = ()
                        let v3039 : (unit -> unit) = closure16(v0)
                        let v3040 : unit = (fun () -> v3039 (); v3038) ()
                        US6_1
                    else
                        let v3081 : unit = ()
                        let v3082 : (unit -> unit) = closure17(v0, v3030)
                        let v3083 : unit = (fun () -> v3082 (); v3081) ()
                        US6_1
                | US8_0(v3028) -> (* Ok *)
                    US6_0(v3028)
            return v3151 
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v4027 : Async<US6> = _let'_v3024 
    let _run_target_args'_v2 = v4027 
    #endif
    let v4028 : Async<US6> = _run_target_args'_v2 
    v4028
and method24 (v0 : Async<bool>, v1 : int32) : Async<US6> =
    (* run_target_args'
    let v2 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : Async<US6> = null |> unbox<Async<US6>>
    let _run_target_args'_v2 = v3 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v6 : Async<US6> = null |> unbox<Async<US6>>
    let _run_target_args'_v2 = v6 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v9 : Async<US6> = null |> unbox<Async<US6>>
    let _run_target_args'_v2 = v9 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v12 : unit = ()
    let _let'_v12 =
        async {
            (* run_target_args'
            let v15 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v16 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _run_target_args'_v15 = v16 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v19 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _run_target_args'_v15 = v19 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v22 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _run_target_args'_v15 = v22 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v25 : Async<Async<bool>> = Async.StartChild (v0, v1)
            let _run_target_args'_v15 = v25 
            #endif
#if FABLE_COMPILER_PYTHON
            let v26 : Async<Async<bool>> = Async.StartChild (v0, v1)
            let _run_target_args'_v15 = v26 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v27 : Async<Async<bool>> = Async.StartChild (v0, v1)
            let _run_target_args'_v15 = v27 
            #endif
#else
            let v28 : Async<Async<bool>> = Async.StartChild (v0, v1)
            let _run_target_args'_v15 = v28 
            #endif
            let v29 : Async<Async<bool>> = _run_target_args'_v15 
            let! v29 = v29 
            let v34 : Async<bool> = v29 
            (* run_target_args'
            let v35 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v36 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
            let _run_target_args'_v35 = v36 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v39 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
            let _run_target_args'_v35 = v39 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v42 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
            let _run_target_args'_v35 = v42 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v45 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v46 : Async<Choice<bool, exn>> = v45 v34
            let _run_target_args'_v35 = v46 
            #endif
#if FABLE_COMPILER_PYTHON
            let v47 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v48 : Async<Choice<bool, exn>> = v47 v34
            let _run_target_args'_v35 = v48 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v49 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v50 : Async<Choice<bool, exn>> = v49 v34
            let _run_target_args'_v35 = v50 
            #endif
#else
            let v51 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v52 : Async<Choice<bool, exn>> = v51 v34
            let _run_target_args'_v35 = v52 
            #endif
            let v53 : Async<Choice<bool, exn>> = _run_target_args'_v35 
            let v58 : Async<US7> = method25(v53)
            let v59 : Async<US8> = method28(v58)
            let v60 : Async<US6> = method29(v1, v59)
            return! v60 
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v383 : Async<US6> = _let'_v12 
    let _run_target_args'_v2 = v383 
    #endif
#if FABLE_COMPILER_PYTHON
    let v384 : unit = ()
    let _let'_v384 =
        async {
            (* run_target_args'
            let v387 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v388 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _run_target_args'_v387 = v388 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v391 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _run_target_args'_v387 = v391 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v394 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _run_target_args'_v387 = v394 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v397 : Async<Async<bool>> = Async.StartChild (v0, v1)
            let _run_target_args'_v387 = v397 
            #endif
#if FABLE_COMPILER_PYTHON
            let v398 : Async<Async<bool>> = Async.StartChild (v0, v1)
            let _run_target_args'_v387 = v398 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v399 : Async<Async<bool>> = Async.StartChild (v0, v1)
            let _run_target_args'_v387 = v399 
            #endif
#else
            let v400 : Async<Async<bool>> = Async.StartChild (v0, v1)
            let _run_target_args'_v387 = v400 
            #endif
            let v401 : Async<Async<bool>> = _run_target_args'_v387 
            let! v401 = v401 
            let v406 : Async<bool> = v401 
            (* run_target_args'
            let v407 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v408 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
            let _run_target_args'_v407 = v408 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v411 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
            let _run_target_args'_v407 = v411 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v414 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
            let _run_target_args'_v407 = v414 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v417 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v418 : Async<Choice<bool, exn>> = v417 v406
            let _run_target_args'_v407 = v418 
            #endif
#if FABLE_COMPILER_PYTHON
            let v419 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v420 : Async<Choice<bool, exn>> = v419 v406
            let _run_target_args'_v407 = v420 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v421 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v422 : Async<Choice<bool, exn>> = v421 v406
            let _run_target_args'_v407 = v422 
            #endif
#else
            let v423 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v424 : Async<Choice<bool, exn>> = v423 v406
            let _run_target_args'_v407 = v424 
            #endif
            let v425 : Async<Choice<bool, exn>> = _run_target_args'_v407 
            let v430 : Async<US7> = method25(v425)
            let v431 : Async<US8> = method28(v430)
            let v432 : Async<US6> = method29(v1, v431)
            return! v432 
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v755 : Async<US6> = _let'_v384 
    let _run_target_args'_v2 = v755 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v756 : unit = ()
    let _let'_v756 =
        async {
            (* run_target_args'
            let v759 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v760 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _run_target_args'_v759 = v760 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v763 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _run_target_args'_v759 = v763 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v766 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _run_target_args'_v759 = v766 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v769 : Async<Async<bool>> = Async.StartChild (v0, v1)
            let _run_target_args'_v759 = v769 
            #endif
#if FABLE_COMPILER_PYTHON
            let v770 : Async<Async<bool>> = Async.StartChild (v0, v1)
            let _run_target_args'_v759 = v770 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v771 : Async<Async<bool>> = Async.StartChild (v0, v1)
            let _run_target_args'_v759 = v771 
            #endif
#else
            let v772 : Async<Async<bool>> = Async.StartChild (v0, v1)
            let _run_target_args'_v759 = v772 
            #endif
            let v773 : Async<Async<bool>> = _run_target_args'_v759 
            let! v773 = v773 
            let v778 : Async<bool> = v773 
            (* run_target_args'
            let v779 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v780 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
            let _run_target_args'_v779 = v780 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v783 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
            let _run_target_args'_v779 = v783 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v786 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
            let _run_target_args'_v779 = v786 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v789 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v790 : Async<Choice<bool, exn>> = v789 v778
            let _run_target_args'_v779 = v790 
            #endif
#if FABLE_COMPILER_PYTHON
            let v791 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v792 : Async<Choice<bool, exn>> = v791 v778
            let _run_target_args'_v779 = v792 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v793 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v794 : Async<Choice<bool, exn>> = v793 v778
            let _run_target_args'_v779 = v794 
            #endif
#else
            let v795 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v796 : Async<Choice<bool, exn>> = v795 v778
            let _run_target_args'_v779 = v796 
            #endif
            let v797 : Async<Choice<bool, exn>> = _run_target_args'_v779 
            let v802 : Async<US7> = method25(v797)
            let v803 : Async<US8> = method28(v802)
            let v804 : Async<US6> = method29(v1, v803)
            return! v804 
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v1127 : Async<US6> = _let'_v756 
    let _run_target_args'_v2 = v1127 
    #endif
#else
    let v1128 : unit = ()
    let _let'_v1128 =
        async {
            (* run_target_args'
            let v1131 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1132 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _run_target_args'_v1131 = v1132 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1135 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _run_target_args'_v1131 = v1135 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1138 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _run_target_args'_v1131 = v1138 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1141 : Async<Async<bool>> = Async.StartChild (v0, v1)
            let _run_target_args'_v1131 = v1141 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1142 : Async<Async<bool>> = Async.StartChild (v0, v1)
            let _run_target_args'_v1131 = v1142 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1143 : Async<Async<bool>> = Async.StartChild (v0, v1)
            let _run_target_args'_v1131 = v1143 
            #endif
#else
            let v1144 : Async<Async<bool>> = Async.StartChild (v0, v1)
            let _run_target_args'_v1131 = v1144 
            #endif
            let v1145 : Async<Async<bool>> = _run_target_args'_v1131 
            let! v1145 = v1145 
            let v1150 : Async<bool> = v1145 
            (* run_target_args'
            let v1151 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1152 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
            let _run_target_args'_v1151 = v1152 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1155 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
            let _run_target_args'_v1151 = v1155 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1158 : Async<Choice<bool, exn>> = null |> unbox<Async<Choice<bool, exn>>>
            let _run_target_args'_v1151 = v1158 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1161 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v1162 : Async<Choice<bool, exn>> = v1161 v1150
            let _run_target_args'_v1151 = v1162 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1163 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v1164 : Async<Choice<bool, exn>> = v1163 v1150
            let _run_target_args'_v1151 = v1164 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1165 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v1166 : Async<Choice<bool, exn>> = v1165 v1150
            let _run_target_args'_v1151 = v1166 
            #endif
#else
            let v1167 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v1168 : Async<Choice<bool, exn>> = v1167 v1150
            let _run_target_args'_v1151 = v1168 
            #endif
            let v1169 : Async<Choice<bool, exn>> = _run_target_args'_v1151 
            let v1174 : Async<US7> = method25(v1169)
            let v1175 : Async<US8> = method28(v1174)
            let v1176 : Async<US6> = method29(v1, v1175)
            return! v1176 
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v1499 : Async<US6> = _let'_v1128 
    let _run_target_args'_v2 = v1499 
    #endif
    let v1500 : Async<US6> = _run_target_args'_v2 
    v1500
and method23 (v0 : int32, v1 : Async<bool>) : Async<US6> =
    (* run_target_args'
    let v2 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : Async<US6> = method24(v1, v0)
    let _run_target_args'_v2 = v3 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v4 : Async<US6> = method24(v1, v0)
    let _run_target_args'_v2 = v4 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v5 : Async<US6> = method24(v1, v0)
    let _run_target_args'_v2 = v5 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v6 : Async<US6> = method24(v1, v0)
    let _run_target_args'_v2 = v6 
    #endif
#if FABLE_COMPILER_PYTHON
    let v7 : Async<US6> = method24(v1, v0)
    let _run_target_args'_v2 = v7 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v8 : Async<US6> = method24(v1, v0)
    let _run_target_args'_v2 = v8 
    #endif
#else
    let v9 : Async<US6> = method24(v1, v0)
    let _run_target_args'_v2 = v9 
    #endif
    let v10 : Async<US6> = _run_target_args'_v2 
    v10
and method22 (v0 : int32, v1 : string, v2 : int32) : Async<bool> =
    (* run_target_args'
    let v3 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v4 : Async<bool> = null |> unbox<Async<bool>>
    let _run_target_args'_v3 = v4 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v7 : Async<bool> = null |> unbox<Async<bool>>
    let _run_target_args'_v3 = v7 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v10 : Async<bool> = null |> unbox<Async<bool>>
    let _run_target_args'_v3 = v10 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v13 : unit = ()
    let _let'_v13 =
        async {
            let v16 : Async<bool> = method6(v1, v2)
            let v17 : Async<US6> = method23(v0, v16)
            let! v17 = v17 
            let v18 : US6 = v17 
            let v21 : bool =
                match v18 with
                | US6_1 -> (* None *)
                    false
                | US6_0(v19) -> (* Some *)
                    v19
            return v21 
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v64 : Async<bool> = _let'_v13 
    let _run_target_args'_v3 = v64 
    #endif
#if FABLE_COMPILER_PYTHON
    let v65 : unit = ()
    let _let'_v65 =
        async {
            let v68 : Async<bool> = method6(v1, v2)
            let v69 : Async<US6> = method23(v0, v68)
            let! v69 = v69 
            let v70 : US6 = v69 
            let v73 : bool =
                match v70 with
                | US6_1 -> (* None *)
                    false
                | US6_0(v71) -> (* Some *)
                    v71
            return v73 
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v116 : Async<bool> = _let'_v65 
    let _run_target_args'_v3 = v116 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v117 : unit = ()
    let _let'_v117 =
        async {
            let v120 : Async<bool> = method6(v1, v2)
            let v121 : Async<US6> = method23(v0, v120)
            let! v121 = v121 
            let v122 : US6 = v121 
            let v125 : bool =
                match v122 with
                | US6_1 -> (* None *)
                    false
                | US6_0(v123) -> (* Some *)
                    v123
            return v125 
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v168 : Async<bool> = _let'_v117 
    let _run_target_args'_v3 = v168 
    #endif
#else
    let v169 : unit = ()
    let _let'_v169 =
        async {
            let v172 : Async<bool> = method6(v1, v2)
            let v173 : Async<US6> = method23(v0, v172)
            let! v173 = v173 
            let v174 : US6 = v173 
            let v177 : bool =
                match v174 with
                | US6_1 -> (* None *)
                    false
                | US6_0(v175) -> (* Some *)
                    v175
            return v177 
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v220 : Async<bool> = _let'_v169 
    let _run_target_args'_v3 = v220 
    #endif
    let v221 : Async<bool> = _run_target_args'_v3 
    v221
and method21 (v0 : int32, v1 : string, v2 : int32) : Async<bool> =
    method22(v0, v1, v2)
and closure13 (v0 : int32, v1 : string) (v2 : int32) : Async<bool> =
    method21(v0, v1, v2)
and closure12 (v0 : int32) (v1 : string) : (int32 -> Async<bool>) =
    closure13(v0, v1)
and closure11 () (v0 : int32) : (string -> (int32 -> Async<bool>)) =
    closure12(v0)
and closure22 () (v0 : int32) : US9 =
    US9_0(v0)
and method38 () : (int32 -> US9) =
    closure22()
and method40 (v0 : int32, v1 : int64, v2 : int32 option, v3 : bool) : string =
    let v4 : string = method15()
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
    (* run_target_args'
    let v100 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v101 : string = "format!(\"{:#?}\", $0)"
    let v102 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v101 
    let v103 : string = "fable_library_rust::String_::fromString($0)"
    let v104 : string = Fable.Core.RustInterop.emitRustExpr v102 v103 
    let _run_target_args'_v100 = v104 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v105 : string = "format!(\"{:#?}\", $0)"
    let v106 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v105 
    let v107 : string = "fable_library_rust::String_::fromString($0)"
    let v108 : string = Fable.Core.RustInterop.emitRustExpr v106 v107 
    let _run_target_args'_v100 = v108 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v109 : string = "format!(\"{:#?}\", $0)"
    let v110 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v109 
    let v111 : string = "fable_library_rust::String_::fromString($0)"
    let v112 : string = Fable.Core.RustInterop.emitRustExpr v110 v111 
    let _run_target_args'_v100 = v112 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v113 : string = $"%A{v2}"
    let _run_target_args'_v100 = v113 
    #endif
#if FABLE_COMPILER_PYTHON
    let v116 : string = $"%A{v2}"
    let _run_target_args'_v100 = v116 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v119 : string = $"%A{v2}"
    let _run_target_args'_v100 = v119 
    #endif
#else
    let v122 : string = $"%A{v2}"
    let _run_target_args'_v100 = v122 
    #endif
    let v125 : string = _run_target_args'_v100 
    let v130 : string = $"{v125}"
    let v133 : unit = ()
    let v134 : (unit -> unit) = closure7(v5, v130)
    let v135 : unit = (fun () -> v134 (); v133) ()
    let v138 : string = $"{v41}"
    let v141 : unit = ()
    let v142 : (unit -> unit) = closure7(v5, v138)
    let v143 : unit = (fun () -> v142 (); v141) ()
    let v146 : string = "status"
    let v147 : string = $"{v146}"
    let v150 : unit = ()
    let v151 : (unit -> unit) = closure7(v5, v147)
    let v152 : unit = (fun () -> v151 (); v150) ()
    let v155 : string = $"{v24}"
    let v158 : unit = ()
    let v159 : (unit -> unit) = closure7(v5, v155)
    let v160 : unit = (fun () -> v159 (); v158) ()
    let v165 : string =
        if v3 then
            let v163 : string = "true"
            v163
        else
            let v164 : string = "false"
            v164
    let v166 : string = $"{v165}"
    let v169 : unit = ()
    let v170 : (unit -> unit) = closure7(v5, v166)
    let v171 : unit = (fun () -> v170 (); v169) ()
    let v174 : string = " }"
    let v175 : string = $"{v174}"
    let v178 : unit = ()
    let v179 : (unit -> unit) = closure7(v5, v175)
    let v180 : unit = (fun () -> v179 (); v178) ()
    let v183 : string = v5.l0
    v183
and method39 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : int32, v9 : int64, v10 : int32 option, v11 : bool) : string =
    let v12 : string = method40(v8, v9, v10, v11)
    let v13 : int64 = v0.l0
    let v14 : string = "networking.wait_for_port_access"
    let v15 : string = $"{v6} {v7} #{v13} %s{v14} / {v12}"
    method19(v15)
and closure23 (v0 : int32 option, v1 : bool, v2 : int32, v3 : int64) () : unit =
    let v4 : US0 = US0_0
    let v5 : bool = method8(v4)
    if v5 then
        let v6 : unit = ()
        let v7 : (unit -> unit) = closure0()
        let v8 : unit = (fun () -> v7 (); v6) ()
        let struct (v22 : Mut0, v23 : Mut1, v24 : Mut2, v25 : Mut3, v26 : Mut4, v27 : int64 option) = TraceState.trace_state.Value
        let v40 : string = method9(v22, v23, v24, v25, v26, v27)
        let v41 : string = method13()
        let v42 : string = method39(v22, v23, v24, v25, v26, v27, v40, v41, v2, v3, v0, v1)
        method20(v42)
and method37 (v0 : int32 option, v1 : bool, v2 : string, v3 : int32, v4 : int64) : Async<int64> =
    (* run_target_args'
    let v5 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v6 : Async<int64> = null |> unbox<Async<int64>>
    let _run_target_args'_v5 = v6 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v9 : Async<int64> = null |> unbox<Async<int64>>
    let _run_target_args'_v5 = v9 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v12 : Async<int64> = null |> unbox<Async<int64>>
    let _run_target_args'_v5 = v12 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v15 : unit = ()
    let _let'_v15 =
        async {
            let v18 : (int32 -> US9) = method38()
            let v19 : US9 option = v0 |> Option.map v18 
            let v30 : US9 = US9_1
            let v31 : US9 = v19 |> Option.defaultValue v30 
            let v39 : Async<bool> =
                match v31 with
                | US9_1 -> (* None *)
                    method6(v2, v3)
                | US9_0(v36) -> (* Some *)
                    method21(v36, v2, v3)
            let! v39 = v39 
            let v40 : bool = v39 
            let v41 : bool = v40 = v1
            if v41 then
                return v4 
                (* fix_condition then
                ()
            else
                fix_condition then *) else
                let v42 : int64 = v4 % 100L
                let v43 : bool = v42 = 0L
                if v43 then
                    let v44 : unit = ()
                    let v45 : (unit -> unit) = closure23(v0, v1, v3, v4)
                    let v46 : unit = (fun () -> v45 (); v44) ()
                    ()
                (* run_target_args'
                let v86 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v87 : (int32 -> Async<unit>) = Async.Sleep
                let v88 : Async<unit> = v87 10
                let _run_target_args'_v86 = v88 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v89 : (int32 -> Async<unit>) = Async.Sleep
                let v90 : Async<unit> = v89 10
                let _run_target_args'_v86 = v90 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v91 : (int32 -> Async<unit>) = Async.Sleep
                let v92 : Async<unit> = v91 10
                let _run_target_args'_v86 = v92 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v93 : (int32 -> Async<unit>) = Async.Sleep
                let v94 : Async<unit> = v93 10
                let _run_target_args'_v86 = v94 
                #endif
#if FABLE_COMPILER_PYTHON
                let v95 : (int32 -> Async<unit>) = Async.Sleep
                let v96 : Async<unit> = v95 10
                let _run_target_args'_v86 = v96 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v97 : (int32 -> Async<unit>) = Async.Sleep
                let v98 : Async<unit> = v97 10
                let _run_target_args'_v86 = v98 
                #endif
#else
                let v99 : (int32 -> Async<unit>) = Async.Sleep
                let v100 : Async<unit> = v99 10
                let _run_target_args'_v86 = v100 
                #endif
                let v101 : Async<unit> = _run_target_args'_v86 
                do! v101 
                let v104 : int64 = v4 + 1L
                let v105 : Async<int64> = method36(v0, v1, v2, v3, v104)
                return! v105 
                (* fix_condition else
                ()
            fix_condition else *)
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v722 : Async<int64> = _let'_v15 
    let _run_target_args'_v5 = v722 
    #endif
#if FABLE_COMPILER_PYTHON
    let v723 : unit = ()
    let _let'_v723 =
        async {
            let v726 : (int32 -> US9) = method38()
            let v727 : US9 option = v0 |> Option.map v726 
            let v738 : US9 = US9_1
            let v739 : US9 = v727 |> Option.defaultValue v738 
            let v747 : Async<bool> =
                match v739 with
                | US9_1 -> (* None *)
                    method6(v2, v3)
                | US9_0(v744) -> (* Some *)
                    method21(v744, v2, v3)
            let! v747 = v747 
            let v748 : bool = v747 
            let v749 : bool = v748 = v1
            if v749 then
                return v4 
                (* fix_condition then
                ()
            else
                fix_condition then *) else
                let v750 : int64 = v4 % 100L
                let v751 : bool = v750 = 0L
                if v751 then
                    let v752 : unit = ()
                    let v753 : (unit -> unit) = closure23(v0, v1, v3, v4)
                    let v754 : unit = (fun () -> v753 (); v752) ()
                    ()
                (* run_target_args'
                let v794 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v795 : (int32 -> Async<unit>) = Async.Sleep
                let v796 : Async<unit> = v795 10
                let _run_target_args'_v794 = v796 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v797 : (int32 -> Async<unit>) = Async.Sleep
                let v798 : Async<unit> = v797 10
                let _run_target_args'_v794 = v798 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v799 : (int32 -> Async<unit>) = Async.Sleep
                let v800 : Async<unit> = v799 10
                let _run_target_args'_v794 = v800 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v801 : (int32 -> Async<unit>) = Async.Sleep
                let v802 : Async<unit> = v801 10
                let _run_target_args'_v794 = v802 
                #endif
#if FABLE_COMPILER_PYTHON
                let v803 : (int32 -> Async<unit>) = Async.Sleep
                let v804 : Async<unit> = v803 10
                let _run_target_args'_v794 = v804 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v805 : (int32 -> Async<unit>) = Async.Sleep
                let v806 : Async<unit> = v805 10
                let _run_target_args'_v794 = v806 
                #endif
#else
                let v807 : (int32 -> Async<unit>) = Async.Sleep
                let v808 : Async<unit> = v807 10
                let _run_target_args'_v794 = v808 
                #endif
                let v809 : Async<unit> = _run_target_args'_v794 
                do! v809 
                let v812 : int64 = v4 + 1L
                let v813 : Async<int64> = method36(v0, v1, v2, v3, v812)
                return! v813 
                (* fix_condition else
                ()
            fix_condition else *)
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v1430 : Async<int64> = _let'_v723 
    let _run_target_args'_v5 = v1430 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1431 : unit = ()
    let _let'_v1431 =
        async {
            let v1434 : (int32 -> US9) = method38()
            let v1435 : US9 option = v0 |> Option.map v1434 
            let v1446 : US9 = US9_1
            let v1447 : US9 = v1435 |> Option.defaultValue v1446 
            let v1455 : Async<bool> =
                match v1447 with
                | US9_1 -> (* None *)
                    method6(v2, v3)
                | US9_0(v1452) -> (* Some *)
                    method21(v1452, v2, v3)
            let! v1455 = v1455 
            let v1456 : bool = v1455 
            let v1457 : bool = v1456 = v1
            if v1457 then
                return v4 
                (* fix_condition then
                ()
            else
                fix_condition then *) else
                let v1458 : int64 = v4 % 100L
                let v1459 : bool = v1458 = 0L
                if v1459 then
                    let v1460 : unit = ()
                    let v1461 : (unit -> unit) = closure23(v0, v1, v3, v4)
                    let v1462 : unit = (fun () -> v1461 (); v1460) ()
                    ()
                (* run_target_args'
                let v1502 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v1503 : (int32 -> Async<unit>) = Async.Sleep
                let v1504 : Async<unit> = v1503 10
                let _run_target_args'_v1502 = v1504 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v1505 : (int32 -> Async<unit>) = Async.Sleep
                let v1506 : Async<unit> = v1505 10
                let _run_target_args'_v1502 = v1506 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v1507 : (int32 -> Async<unit>) = Async.Sleep
                let v1508 : Async<unit> = v1507 10
                let _run_target_args'_v1502 = v1508 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v1509 : (int32 -> Async<unit>) = Async.Sleep
                let v1510 : Async<unit> = v1509 10
                let _run_target_args'_v1502 = v1510 
                #endif
#if FABLE_COMPILER_PYTHON
                let v1511 : (int32 -> Async<unit>) = Async.Sleep
                let v1512 : Async<unit> = v1511 10
                let _run_target_args'_v1502 = v1512 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v1513 : (int32 -> Async<unit>) = Async.Sleep
                let v1514 : Async<unit> = v1513 10
                let _run_target_args'_v1502 = v1514 
                #endif
#else
                let v1515 : (int32 -> Async<unit>) = Async.Sleep
                let v1516 : Async<unit> = v1515 10
                let _run_target_args'_v1502 = v1516 
                #endif
                let v1517 : Async<unit> = _run_target_args'_v1502 
                do! v1517 
                let v1520 : int64 = v4 + 1L
                let v1521 : Async<int64> = method36(v0, v1, v2, v3, v1520)
                return! v1521 
                (* fix_condition else
                ()
            fix_condition else *)
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v2138 : Async<int64> = _let'_v1431 
    let _run_target_args'_v5 = v2138 
    #endif
#else
    let v2139 : unit = ()
    let _let'_v2139 =
        async {
            let v2142 : (int32 -> US9) = method38()
            let v2143 : US9 option = v0 |> Option.map v2142 
            let v2154 : US9 = US9_1
            let v2155 : US9 = v2143 |> Option.defaultValue v2154 
            let v2163 : Async<bool> =
                match v2155 with
                | US9_1 -> (* None *)
                    method6(v2, v3)
                | US9_0(v2160) -> (* Some *)
                    method21(v2160, v2, v3)
            let! v2163 = v2163 
            let v2164 : bool = v2163 
            let v2165 : bool = v2164 = v1
            if v2165 then
                return v4 
                (* fix_condition then
                ()
            else
                fix_condition then *) else
                let v2166 : int64 = v4 % 100L
                let v2167 : bool = v2166 = 0L
                if v2167 then
                    let v2168 : unit = ()
                    let v2169 : (unit -> unit) = closure23(v0, v1, v3, v4)
                    let v2170 : unit = (fun () -> v2169 (); v2168) ()
                    ()
                (* run_target_args'
                let v2210 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v2211 : (int32 -> Async<unit>) = Async.Sleep
                let v2212 : Async<unit> = v2211 10
                let _run_target_args'_v2210 = v2212 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v2213 : (int32 -> Async<unit>) = Async.Sleep
                let v2214 : Async<unit> = v2213 10
                let _run_target_args'_v2210 = v2214 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v2215 : (int32 -> Async<unit>) = Async.Sleep
                let v2216 : Async<unit> = v2215 10
                let _run_target_args'_v2210 = v2216 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v2217 : (int32 -> Async<unit>) = Async.Sleep
                let v2218 : Async<unit> = v2217 10
                let _run_target_args'_v2210 = v2218 
                #endif
#if FABLE_COMPILER_PYTHON
                let v2219 : (int32 -> Async<unit>) = Async.Sleep
                let v2220 : Async<unit> = v2219 10
                let _run_target_args'_v2210 = v2220 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v2221 : (int32 -> Async<unit>) = Async.Sleep
                let v2222 : Async<unit> = v2221 10
                let _run_target_args'_v2210 = v2222 
                #endif
#else
                let v2223 : (int32 -> Async<unit>) = Async.Sleep
                let v2224 : Async<unit> = v2223 10
                let _run_target_args'_v2210 = v2224 
                #endif
                let v2225 : Async<unit> = _run_target_args'_v2210 
                do! v2225 
                let v2228 : int64 = v4 + 1L
                let v2229 : Async<int64> = method36(v0, v1, v2, v3, v2228)
                return! v2229 
                (* fix_condition else
                ()
            fix_condition else *)
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v2846 : Async<int64> = _let'_v2139 
    let _run_target_args'_v5 = v2846 
    #endif
    let v2847 : Async<int64> = _run_target_args'_v5 
    v2847
and method36 (v0 : int32 option, v1 : bool, v2 : string, v3 : int32, v4 : int64) : Async<int64> =
    method37(v0, v1, v2, v3, v4)
and method35 (v0 : int32 option, v1 : bool, v2 : string, v3 : int32) : Async<int64> =
    let v4 : int64 = 1L
    method36(v0, v1, v2, v3, v4)
and closure21 (v0 : int32 option, v1 : bool, v2 : string) (v3 : int32) : Async<int64> =
    method35(v0, v1, v2, v3)
and closure20 (v0 : int32 option, v1 : bool) (v2 : string) : (int32 -> Async<int64>) =
    closure21(v0, v1, v2)
and closure19 (v0 : int32 option) (v1 : bool) : (string -> (int32 -> Async<int64>)) =
    closure20(v0, v1)
and closure18 () (v0 : int32 option) : (bool -> (string -> (int32 -> Async<int64>))) =
    closure19(v0)
and method43 (v0 : int32 option, v1 : string, v2 : int32) : Async<int32> =
    (* run_target_args'
    let v3 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v4 : Async<int32> = null |> unbox<Async<int32>>
    let _run_target_args'_v3 = v4 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v7 : Async<int32> = null |> unbox<Async<int32>>
    let _run_target_args'_v3 = v7 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v10 : Async<int32> = null |> unbox<Async<int32>>
    let _run_target_args'_v3 = v10 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v13 : unit = ()
    let _let'_v13 =
        async {
            let v16 : (int32 -> US9) = method38()
            let v17 : US9 option = v0 |> Option.map v16 
            let v28 : US9 = US9_1
            let v29 : US9 = v17 |> Option.defaultValue v28 
            let v37 : Async<bool> =
                match v29 with
                | US9_1 -> (* None *)
                    method6(v1, v2)
                | US9_0(v34) -> (* Some *)
                    method21(v34, v1, v2)
            let! v37 = v37 
            let v38 : bool = v37 
            let v39 : bool = v38 = false
            if v39 then
                return v2 
                (* fix_condition then
                ()
            else
                fix_condition then *) else
                let v40 : int32 = v2 + 1
                let v41 : Async<int32> = method42(v0, v1, v40)
                return! v41 
                (* fix_condition else
                ()
            fix_condition else *)
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v224 : Async<int32> = _let'_v13 
    let _run_target_args'_v3 = v224 
    #endif
#if FABLE_COMPILER_PYTHON
    let v225 : unit = ()
    let _let'_v225 =
        async {
            let v228 : (int32 -> US9) = method38()
            let v229 : US9 option = v0 |> Option.map v228 
            let v240 : US9 = US9_1
            let v241 : US9 = v229 |> Option.defaultValue v240 
            let v249 : Async<bool> =
                match v241 with
                | US9_1 -> (* None *)
                    method6(v1, v2)
                | US9_0(v246) -> (* Some *)
                    method21(v246, v1, v2)
            let! v249 = v249 
            let v250 : bool = v249 
            let v251 : bool = v250 = false
            if v251 then
                return v2 
                (* fix_condition then
                ()
            else
                fix_condition then *) else
                let v252 : int32 = v2 + 1
                let v253 : Async<int32> = method42(v0, v1, v252)
                return! v253 
                (* fix_condition else
                ()
            fix_condition else *)
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v436 : Async<int32> = _let'_v225 
    let _run_target_args'_v3 = v436 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v437 : unit = ()
    let _let'_v437 =
        async {
            let v440 : (int32 -> US9) = method38()
            let v441 : US9 option = v0 |> Option.map v440 
            let v452 : US9 = US9_1
            let v453 : US9 = v441 |> Option.defaultValue v452 
            let v461 : Async<bool> =
                match v453 with
                | US9_1 -> (* None *)
                    method6(v1, v2)
                | US9_0(v458) -> (* Some *)
                    method21(v458, v1, v2)
            let! v461 = v461 
            let v462 : bool = v461 
            let v463 : bool = v462 = false
            if v463 then
                return v2 
                (* fix_condition then
                ()
            else
                fix_condition then *) else
                let v464 : int32 = v2 + 1
                let v465 : Async<int32> = method42(v0, v1, v464)
                return! v465 
                (* fix_condition else
                ()
            fix_condition else *)
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v648 : Async<int32> = _let'_v437 
    let _run_target_args'_v3 = v648 
    #endif
#else
    let v649 : unit = ()
    let _let'_v649 =
        async {
            let v652 : (int32 -> US9) = method38()
            let v653 : US9 option = v0 |> Option.map v652 
            let v664 : US9 = US9_1
            let v665 : US9 = v653 |> Option.defaultValue v664 
            let v673 : Async<bool> =
                match v665 with
                | US9_1 -> (* None *)
                    method6(v1, v2)
                | US9_0(v670) -> (* Some *)
                    method21(v670, v1, v2)
            let! v673 = v673 
            let v674 : bool = v673 
            let v675 : bool = v674 = false
            if v675 then
                return v2 
                (* fix_condition then
                ()
            else
                fix_condition then *) else
                let v676 : int32 = v2 + 1
                let v677 : Async<int32> = method42(v0, v1, v676)
                return! v677 
                (* fix_condition else
                ()
            fix_condition else *)
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v860 : Async<int32> = _let'_v649 
    let _run_target_args'_v3 = v860 
    #endif
    let v861 : Async<int32> = _run_target_args'_v3 
    v861
and method42 (v0 : int32 option, v1 : string, v2 : int32) : Async<int32> =
    method43(v0, v1, v2)
and method41 (v0 : int32 option, v1 : string, v2 : int32) : Async<int32> =
    method42(v0, v1, v2)
and closure26 (v0 : int32 option, v1 : string) (v2 : int32) : Async<int32> =
    method41(v0, v1, v2)
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
