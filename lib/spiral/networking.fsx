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
    let v1 : unit = ()
    
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
    let _v1 = v17 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v18 : US3 = US3_1
    let v19 : US4 = US4_2(v18)
    let v20 : string = $"env.get_environment_variable / target: {v19} / var: {v0}"
    let v21 : string = failwith<string> v20
    let _v1 = v21 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v22 : US3 = US3_2
    let v23 : US4 = US4_2(v22)
    let v24 : string = $"env.get_environment_variable / target: {v23} / var: {v0}"
    let v25 : string = failwith<string> v24
    let _v1 = v25 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v26 : string = "process.env[$0] ?? \"\""
    let v27 : string = Fable.Core.JsInterop.emitJsExpr v0 v26 
    let _v1 = v27 
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
    let _v1 = v63 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v64 : US3 = US3_1
    let v65 : US4 = US4_0(v64)
    let v66 : string = $"env.get_environment_variable / target: {v65} / var: {v0}"
    let v67 : string = failwith<string> v66
    let _v1 = v67 
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
    let _v1 = v95 
    #endif
    let v96 : string = _v1 
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
            let v55 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v56 : System.DateTime = System.DateTime.Now
            let _v55 = v56 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v57 : System.DateTime = System.DateTime.Now
            let _v55 = v57 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v58 : System.DateTime = null |> unbox<System.DateTime>
            let _v55 = v58 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v61 : System.DateTime = System.DateTime.Now
            let _v55 = v61 
            #endif
#if FABLE_COMPILER_PYTHON
            let v62 : System.DateTime = System.DateTime.Now
            let _v55 = v62 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v63 : System.DateTime = System.DateTime.Now
            let _v55 = v63 
            #endif
#else
            let v64 : System.DateTime = System.DateTime.Now
            let _v55 = v64 
            #endif
            let v65 : System.DateTime = _v55 
            let v70 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v71 : (System.DateTime -> int64) = _.Ticks
            let v72 : int64 = v71 v65
            let _v70 = v72 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v73 : (System.DateTime -> int64) = _.Ticks
            let v74 : int64 = v73 v65
            let _v70 = v74 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v75 : int64 = null |> unbox<int64>
            let _v70 = v75 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v78 : (System.DateTime -> int64) = _.Ticks
            let v79 : int64 = v78 v65
            let _v70 = v79 
            #endif
#if FABLE_COMPILER_PYTHON
            let v80 : (System.DateTime -> int64) = _.Ticks
            let v81 : int64 = v80 v65
            let _v70 = v81 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v82 : (System.DateTime -> int64) = _.Ticks
            let v83 : int64 = v82 v65
            let _v70 = v83 
            #endif
#else
            let v84 : (System.DateTime -> int64) = _.Ticks
            let v85 : int64 = v84 v65
            let _v70 = v85 
            #endif
            let v86 : int64 = _v70 
            let v103 : int64 = v86 |> int64 
            US2_0(v103)
    struct (v47, v107)
and closure2 () (v0 : string) : unit =
    ()
and method0 (v0 : US0) : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) =
    let v1 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let struct (v2 : US1, v3 : US2) = method1()
    let _v1 = struct (v2, v3) 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v4 : US1 = US1_1
    let v5 : US2 = US2_1
    let _v1 = struct (v4, v5) 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v6 : string = "AUTOMATION"
    let v7 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v8 : string = "option_env!(\"" + v6 + "\").unwrap_or(\"\")"
    let v9 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v8 
    let v10 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v11 : string = "String::from($0)"
    let v12 : std_string_String = Fable.Core.RustInterop.emitRustExpr v9 v11 
    let _v10 = v12 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v13 : string = "String::from($0)"
    let v14 : std_string_String = Fable.Core.RustInterop.emitRustExpr v9 v13 
    let _v10 = v14 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v15 : string = "String::from($0)"
    let v16 : std_string_String = Fable.Core.RustInterop.emitRustExpr v9 v15 
    let _v10 = v16 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v17 : std_string_String = v9 |> unbox<std_string_String>
    let _v10 = v17 
    #endif
#if FABLE_COMPILER_PYTHON
    let v20 : std_string_String = v9 |> unbox<std_string_String>
    let _v10 = v20 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v23 : std_string_String = v9 |> unbox<std_string_String>
    let _v10 = v23 
    #endif
#else
    let v26 : std_string_String = v9 |> unbox<std_string_String>
    let _v10 = v26 
    #endif
    let v29 : std_string_String = _v10 
    let v34 : string = "fable_library_rust::String_::fromString($0)"
    let v35 : string = Fable.Core.RustInterop.emitRustExpr v29 v34 
    let _v7 = v35 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v36 : string = "option_env!(\"" + v6 + "\").unwrap_or(\"\")"
    let v37 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v36 
    let v38 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v39 : string = "String::from($0)"
    let v40 : std_string_String = Fable.Core.RustInterop.emitRustExpr v37 v39 
    let _v38 = v40 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v41 : string = "String::from($0)"
    let v42 : std_string_String = Fable.Core.RustInterop.emitRustExpr v37 v41 
    let _v38 = v42 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v43 : string = "String::from($0)"
    let v44 : std_string_String = Fable.Core.RustInterop.emitRustExpr v37 v43 
    let _v38 = v44 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v45 : std_string_String = v37 |> unbox<std_string_String>
    let _v38 = v45 
    #endif
#if FABLE_COMPILER_PYTHON
    let v48 : std_string_String = v37 |> unbox<std_string_String>
    let _v38 = v48 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v51 : std_string_String = v37 |> unbox<std_string_String>
    let _v38 = v51 
    #endif
#else
    let v54 : std_string_String = v37 |> unbox<std_string_String>
    let _v38 = v54 
    #endif
    let v57 : std_string_String = _v38 
    let v62 : string = "fable_library_rust::String_::fromString($0)"
    let v63 : string = Fable.Core.RustInterop.emitRustExpr v57 v62 
    let _v7 = v63 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v64 : string = "option_env!(\"" + v6 + "\").unwrap_or(\"\")"
    let v65 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v64 
    let v66 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v67 : string = "String::from($0)"
    let v68 : std_string_String = Fable.Core.RustInterop.emitRustExpr v65 v67 
    let _v66 = v68 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v69 : string = "String::from($0)"
    let v70 : std_string_String = Fable.Core.RustInterop.emitRustExpr v65 v69 
    let _v66 = v70 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v71 : string = "String::from($0)"
    let v72 : std_string_String = Fable.Core.RustInterop.emitRustExpr v65 v71 
    let _v66 = v72 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v73 : std_string_String = v65 |> unbox<std_string_String>
    let _v66 = v73 
    #endif
#if FABLE_COMPILER_PYTHON
    let v76 : std_string_String = v65 |> unbox<std_string_String>
    let _v66 = v76 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v79 : std_string_String = v65 |> unbox<std_string_String>
    let _v66 = v79 
    #endif
#else
    let v82 : std_string_String = v65 |> unbox<std_string_String>
    let _v66 = v82 
    #endif
    let v85 : std_string_String = _v66 
    let v90 : string = "fable_library_rust::String_::fromString($0)"
    let v91 : string = Fable.Core.RustInterop.emitRustExpr v85 v90 
    let _v7 = v91 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v92 : string = null |> unbox<string>
    let _v7 = v92 
    #endif
#if FABLE_COMPILER_PYTHON
    let v95 : string = null |> unbox<string>
    let _v7 = v95 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v98 : string = null |> unbox<string>
    let _v7 = v98 
    #endif
#else
    let v101 : string = null |> unbox<string>
    let _v7 = v101 
    #endif
    let v104 : string = _v7 
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
    let _v1 = struct (v122, v121) 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let struct (v123 : US1, v124 : US2) = method1()
    let _v1 = struct (v123, v124) 
    #endif
#if FABLE_COMPILER_PYTHON
    let struct (v125 : US1, v126 : US2) = method1()
    let _v1 = struct (v125, v126) 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let struct (v127 : US1, v128 : US2) = method1()
    let _v1 = struct (v127, v128) 
    #endif
#else
    let struct (v129 : US1, v130 : US2) = method1()
    let _v1 = struct (v129, v130) 
    #endif
    let struct (v131 : US1, v132 : US2) = _v1 
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
and method7 (v0 : System.Threading.Tasks.Task) : Async<unit> =
    let v1 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
    let v3 : Async<unit> = v2 v0
    let _v1 = v3 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v4 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
    let v5 : Async<unit> = v4 v0
    let _v1 = v5 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v6 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
    let v7 : Async<unit> = v6 v0
    let _v1 = v7 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v8 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
    let v9 : Async<unit> = v8 v0
    let _v1 = v9 
    #endif
#if FABLE_COMPILER_PYTHON
    let v10 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
    let v11 : Async<unit> = v10 v0
    let _v1 = v11 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v12 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
    let v13 : Async<unit> = v12 v0
    let _v1 = v13 
    #endif
#else
    let v14 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
    let v15 : Async<unit> = v14 v0
    let _v1 = v15 
    #endif
    let v16 : Async<unit> = _v1 
    v16
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
    let v6 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v7 : (int64 -> US2) = method10()
    let v8 : US2 option = v5 |> Option.map v7 
    let v19 : US2 = US2_1
    let v20 : US2 = v8 |> Option.defaultValue v19 
    let v117 : System.DateTime =
        match v20 with
        | US2_1 -> (* None *)
            let v101 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v102 : System.DateTime = System.DateTime.Now
            let _v101 = v102 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v103 : System.DateTime = System.DateTime.Now
            let _v101 = v103 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v104 : System.DateTime = null |> unbox<System.DateTime>
            let _v101 = v104 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v107 : System.DateTime = System.DateTime.Now
            let _v101 = v107 
            #endif
#if FABLE_COMPILER_PYTHON
            let v108 : System.DateTime = System.DateTime.Now
            let _v101 = v108 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v109 : System.DateTime = System.DateTime.Now
            let _v101 = v109 
            #endif
#else
            let v110 : System.DateTime = System.DateTime.Now
            let _v101 = v110 
            #endif
            let v111 : System.DateTime = _v101 
            v111
        | US2_0(v24) -> (* Some *)
            let v25 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v26 : System.DateTime = System.DateTime.Now
            let _v25 = v26 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v27 : System.DateTime = System.DateTime.Now
            let _v25 = v27 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v28 : System.DateTime = null |> unbox<System.DateTime>
            let _v25 = v28 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v31 : System.DateTime = System.DateTime.Now
            let _v25 = v31 
            #endif
#if FABLE_COMPILER_PYTHON
            let v32 : System.DateTime = System.DateTime.Now
            let _v25 = v32 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v33 : System.DateTime = System.DateTime.Now
            let _v25 = v33 
            #endif
#else
            let v34 : System.DateTime = System.DateTime.Now
            let _v25 = v34 
            #endif
            let v35 : System.DateTime = _v25 
            let v40 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v41 : (System.DateTime -> int64) = _.Ticks
            let v42 : int64 = v41 v35
            let _v40 = v42 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v43 : (System.DateTime -> int64) = _.Ticks
            let v44 : int64 = v43 v35
            let _v40 = v44 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v45 : int64 = null |> unbox<int64>
            let _v40 = v45 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v48 : (System.DateTime -> int64) = _.Ticks
            let v49 : int64 = v48 v35
            let _v40 = v49 
            #endif
#if FABLE_COMPILER_PYTHON
            let v50 : (System.DateTime -> int64) = _.Ticks
            let v51 : int64 = v50 v35
            let _v40 = v51 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v52 : (System.DateTime -> int64) = _.Ticks
            let v53 : int64 = v52 v35
            let _v40 = v53 
            #endif
#else
            let v54 : (System.DateTime -> int64) = _.Ticks
            let v55 : int64 = v54 v35
            let _v40 = v55 
            #endif
            let v56 : int64 = _v40 
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
    let _v6 = v125 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v139 : (int64 -> US2) = method10()
    let v140 : US2 option = v5 |> Option.map v139 
    let v151 : US2 = US2_1
    let v152 : US2 = v140 |> Option.defaultValue v151 
    let v249 : System.DateTime =
        match v152 with
        | US2_1 -> (* None *)
            let v233 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v234 : System.DateTime = System.DateTime.Now
            let _v233 = v234 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v235 : System.DateTime = System.DateTime.Now
            let _v233 = v235 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v236 : System.DateTime = null |> unbox<System.DateTime>
            let _v233 = v236 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v239 : System.DateTime = System.DateTime.Now
            let _v233 = v239 
            #endif
#if FABLE_COMPILER_PYTHON
            let v240 : System.DateTime = System.DateTime.Now
            let _v233 = v240 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v241 : System.DateTime = System.DateTime.Now
            let _v233 = v241 
            #endif
#else
            let v242 : System.DateTime = System.DateTime.Now
            let _v233 = v242 
            #endif
            let v243 : System.DateTime = _v233 
            v243
        | US2_0(v156) -> (* Some *)
            let v157 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v158 : System.DateTime = System.DateTime.Now
            let _v157 = v158 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v159 : System.DateTime = System.DateTime.Now
            let _v157 = v159 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v160 : System.DateTime = null |> unbox<System.DateTime>
            let _v157 = v160 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v163 : System.DateTime = System.DateTime.Now
            let _v157 = v163 
            #endif
#if FABLE_COMPILER_PYTHON
            let v164 : System.DateTime = System.DateTime.Now
            let _v157 = v164 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v165 : System.DateTime = System.DateTime.Now
            let _v157 = v165 
            #endif
#else
            let v166 : System.DateTime = System.DateTime.Now
            let _v157 = v166 
            #endif
            let v167 : System.DateTime = _v157 
            let v172 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v173 : (System.DateTime -> int64) = _.Ticks
            let v174 : int64 = v173 v167
            let _v172 = v174 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v175 : (System.DateTime -> int64) = _.Ticks
            let v176 : int64 = v175 v167
            let _v172 = v176 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v177 : int64 = null |> unbox<int64>
            let _v172 = v177 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v180 : (System.DateTime -> int64) = _.Ticks
            let v181 : int64 = v180 v167
            let _v172 = v181 
            #endif
#if FABLE_COMPILER_PYTHON
            let v182 : (System.DateTime -> int64) = _.Ticks
            let v183 : int64 = v182 v167
            let _v172 = v183 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v184 : (System.DateTime -> int64) = _.Ticks
            let v185 : int64 = v184 v167
            let _v172 = v185 
            #endif
#else
            let v186 : (System.DateTime -> int64) = _.Ticks
            let v187 : int64 = v186 v167
            let _v172 = v187 
            #endif
            let v188 : int64 = _v172 
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
    let _v6 = v257 
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
    let _v6 = v307 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v308 : (int64 -> US2) = method10()
    let v309 : US2 option = v5 |> Option.map v308 
    let v320 : US2 = US2_1
    let v321 : US2 = v309 |> Option.defaultValue v320 
    let v418 : System.DateTime =
        match v321 with
        | US2_1 -> (* None *)
            let v402 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v403 : System.DateTime = System.DateTime.Now
            let _v402 = v403 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v404 : System.DateTime = System.DateTime.Now
            let _v402 = v404 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v405 : System.DateTime = null |> unbox<System.DateTime>
            let _v402 = v405 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v408 : System.DateTime = System.DateTime.Now
            let _v402 = v408 
            #endif
#if FABLE_COMPILER_PYTHON
            let v409 : System.DateTime = System.DateTime.Now
            let _v402 = v409 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v410 : System.DateTime = System.DateTime.Now
            let _v402 = v410 
            #endif
#else
            let v411 : System.DateTime = System.DateTime.Now
            let _v402 = v411 
            #endif
            let v412 : System.DateTime = _v402 
            v412
        | US2_0(v325) -> (* Some *)
            let v326 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v327 : System.DateTime = System.DateTime.Now
            let _v326 = v327 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v328 : System.DateTime = System.DateTime.Now
            let _v326 = v328 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v329 : System.DateTime = null |> unbox<System.DateTime>
            let _v326 = v329 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v332 : System.DateTime = System.DateTime.Now
            let _v326 = v332 
            #endif
#if FABLE_COMPILER_PYTHON
            let v333 : System.DateTime = System.DateTime.Now
            let _v326 = v333 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v334 : System.DateTime = System.DateTime.Now
            let _v326 = v334 
            #endif
#else
            let v335 : System.DateTime = System.DateTime.Now
            let _v326 = v335 
            #endif
            let v336 : System.DateTime = _v326 
            let v341 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v342 : (System.DateTime -> int64) = _.Ticks
            let v343 : int64 = v342 v336
            let _v341 = v343 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v344 : (System.DateTime -> int64) = _.Ticks
            let v345 : int64 = v344 v336
            let _v341 = v345 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v346 : int64 = null |> unbox<int64>
            let _v341 = v346 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v349 : (System.DateTime -> int64) = _.Ticks
            let v350 : int64 = v349 v336
            let _v341 = v350 
            #endif
#if FABLE_COMPILER_PYTHON
            let v351 : (System.DateTime -> int64) = _.Ticks
            let v352 : int64 = v351 v336
            let _v341 = v352 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v353 : (System.DateTime -> int64) = _.Ticks
            let v354 : int64 = v353 v336
            let _v341 = v354 
            #endif
#else
            let v355 : (System.DateTime -> int64) = _.Ticks
            let v356 : int64 = v355 v336
            let _v341 = v356 
            #endif
            let v357 : int64 = _v341 
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
    let _v6 = v426 
    #endif
#if FABLE_COMPILER_PYTHON
    let v440 : (int64 -> US2) = method10()
    let v441 : US2 option = v5 |> Option.map v440 
    let v452 : US2 = US2_1
    let v453 : US2 = v441 |> Option.defaultValue v452 
    let v550 : System.DateTime =
        match v453 with
        | US2_1 -> (* None *)
            let v534 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v535 : System.DateTime = System.DateTime.Now
            let _v534 = v535 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v536 : System.DateTime = System.DateTime.Now
            let _v534 = v536 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v537 : System.DateTime = null |> unbox<System.DateTime>
            let _v534 = v537 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v540 : System.DateTime = System.DateTime.Now
            let _v534 = v540 
            #endif
#if FABLE_COMPILER_PYTHON
            let v541 : System.DateTime = System.DateTime.Now
            let _v534 = v541 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v542 : System.DateTime = System.DateTime.Now
            let _v534 = v542 
            #endif
#else
            let v543 : System.DateTime = System.DateTime.Now
            let _v534 = v543 
            #endif
            let v544 : System.DateTime = _v534 
            v544
        | US2_0(v457) -> (* Some *)
            let v458 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v459 : System.DateTime = System.DateTime.Now
            let _v458 = v459 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v460 : System.DateTime = System.DateTime.Now
            let _v458 = v460 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v461 : System.DateTime = null |> unbox<System.DateTime>
            let _v458 = v461 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v464 : System.DateTime = System.DateTime.Now
            let _v458 = v464 
            #endif
#if FABLE_COMPILER_PYTHON
            let v465 : System.DateTime = System.DateTime.Now
            let _v458 = v465 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v466 : System.DateTime = System.DateTime.Now
            let _v458 = v466 
            #endif
#else
            let v467 : System.DateTime = System.DateTime.Now
            let _v458 = v467 
            #endif
            let v468 : System.DateTime = _v458 
            let v473 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v474 : (System.DateTime -> int64) = _.Ticks
            let v475 : int64 = v474 v468
            let _v473 = v475 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v476 : (System.DateTime -> int64) = _.Ticks
            let v477 : int64 = v476 v468
            let _v473 = v477 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v478 : int64 = null |> unbox<int64>
            let _v473 = v478 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v481 : (System.DateTime -> int64) = _.Ticks
            let v482 : int64 = v481 v468
            let _v473 = v482 
            #endif
#if FABLE_COMPILER_PYTHON
            let v483 : (System.DateTime -> int64) = _.Ticks
            let v484 : int64 = v483 v468
            let _v473 = v484 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v485 : (System.DateTime -> int64) = _.Ticks
            let v486 : int64 = v485 v468
            let _v473 = v486 
            #endif
#else
            let v487 : (System.DateTime -> int64) = _.Ticks
            let v488 : int64 = v487 v468
            let _v473 = v488 
            #endif
            let v489 : int64 = _v473 
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
    let _v6 = v558 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v572 : (int64 -> US2) = method10()
    let v573 : US2 option = v5 |> Option.map v572 
    let v584 : US2 = US2_1
    let v585 : US2 = v573 |> Option.defaultValue v584 
    let v682 : System.DateTime =
        match v585 with
        | US2_1 -> (* None *)
            let v666 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v667 : System.DateTime = System.DateTime.Now
            let _v666 = v667 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v668 : System.DateTime = System.DateTime.Now
            let _v666 = v668 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v669 : System.DateTime = null |> unbox<System.DateTime>
            let _v666 = v669 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v672 : System.DateTime = System.DateTime.Now
            let _v666 = v672 
            #endif
#if FABLE_COMPILER_PYTHON
            let v673 : System.DateTime = System.DateTime.Now
            let _v666 = v673 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v674 : System.DateTime = System.DateTime.Now
            let _v666 = v674 
            #endif
#else
            let v675 : System.DateTime = System.DateTime.Now
            let _v666 = v675 
            #endif
            let v676 : System.DateTime = _v666 
            v676
        | US2_0(v589) -> (* Some *)
            let v590 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v591 : System.DateTime = System.DateTime.Now
            let _v590 = v591 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v592 : System.DateTime = System.DateTime.Now
            let _v590 = v592 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v593 : System.DateTime = null |> unbox<System.DateTime>
            let _v590 = v593 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v596 : System.DateTime = System.DateTime.Now
            let _v590 = v596 
            #endif
#if FABLE_COMPILER_PYTHON
            let v597 : System.DateTime = System.DateTime.Now
            let _v590 = v597 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v598 : System.DateTime = System.DateTime.Now
            let _v590 = v598 
            #endif
#else
            let v599 : System.DateTime = System.DateTime.Now
            let _v590 = v599 
            #endif
            let v600 : System.DateTime = _v590 
            let v605 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v606 : (System.DateTime -> int64) = _.Ticks
            let v607 : int64 = v606 v600
            let _v605 = v607 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v608 : (System.DateTime -> int64) = _.Ticks
            let v609 : int64 = v608 v600
            let _v605 = v609 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v610 : int64 = null |> unbox<int64>
            let _v605 = v610 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v613 : (System.DateTime -> int64) = _.Ticks
            let v614 : int64 = v613 v600
            let _v605 = v614 
            #endif
#if FABLE_COMPILER_PYTHON
            let v615 : (System.DateTime -> int64) = _.Ticks
            let v616 : int64 = v615 v600
            let _v605 = v616 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v617 : (System.DateTime -> int64) = _.Ticks
            let v618 : int64 = v617 v600
            let _v605 = v618 
            #endif
#else
            let v619 : (System.DateTime -> int64) = _.Ticks
            let v620 : int64 = v619 v600
            let _v605 = v620 
            #endif
            let v621 : int64 = _v605 
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
    let _v6 = v690 
    #endif
#else
    let v704 : (int64 -> US2) = method10()
    let v705 : US2 option = v5 |> Option.map v704 
    let v716 : US2 = US2_1
    let v717 : US2 = v705 |> Option.defaultValue v716 
    let v814 : System.DateTime =
        match v717 with
        | US2_1 -> (* None *)
            let v798 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v799 : System.DateTime = System.DateTime.Now
            let _v798 = v799 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v800 : System.DateTime = System.DateTime.Now
            let _v798 = v800 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v801 : System.DateTime = null |> unbox<System.DateTime>
            let _v798 = v801 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v804 : System.DateTime = System.DateTime.Now
            let _v798 = v804 
            #endif
#if FABLE_COMPILER_PYTHON
            let v805 : System.DateTime = System.DateTime.Now
            let _v798 = v805 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v806 : System.DateTime = System.DateTime.Now
            let _v798 = v806 
            #endif
#else
            let v807 : System.DateTime = System.DateTime.Now
            let _v798 = v807 
            #endif
            let v808 : System.DateTime = _v798 
            v808
        | US2_0(v721) -> (* Some *)
            let v722 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v723 : System.DateTime = System.DateTime.Now
            let _v722 = v723 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v724 : System.DateTime = System.DateTime.Now
            let _v722 = v724 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v725 : System.DateTime = null |> unbox<System.DateTime>
            let _v722 = v725 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v728 : System.DateTime = System.DateTime.Now
            let _v722 = v728 
            #endif
#if FABLE_COMPILER_PYTHON
            let v729 : System.DateTime = System.DateTime.Now
            let _v722 = v729 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v730 : System.DateTime = System.DateTime.Now
            let _v722 = v730 
            #endif
#else
            let v731 : System.DateTime = System.DateTime.Now
            let _v722 = v731 
            #endif
            let v732 : System.DateTime = _v722 
            let v737 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v738 : (System.DateTime -> int64) = _.Ticks
            let v739 : int64 = v738 v732
            let _v737 = v739 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v740 : (System.DateTime -> int64) = _.Ticks
            let v741 : int64 = v740 v732
            let _v737 = v741 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v742 : int64 = null |> unbox<int64>
            let _v737 = v742 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v745 : (System.DateTime -> int64) = _.Ticks
            let v746 : int64 = v745 v732
            let _v737 = v746 
            #endif
#if FABLE_COMPILER_PYTHON
            let v747 : (System.DateTime -> int64) = _.Ticks
            let v748 : int64 = v747 v732
            let _v737 = v748 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v749 : (System.DateTime -> int64) = _.Ticks
            let v750 : int64 = v749 v732
            let _v737 = v750 
            #endif
#else
            let v751 : (System.DateTime -> int64) = _.Ticks
            let v752 : int64 = v751 v732
            let _v737 = v752 
            #endif
            let v753 : int64 = _v737 
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
    let _v6 = v822 
    #endif
    let v836 : string = _v6 
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
    let v40 : string = "inline_colorization::color_bright_black"
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
    let v72 : string = "inline_colorization::color_bright_black"
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
    let v104 : string = "\u001b[90m"
    let v105 : string = method16()
    let v106 : string = v104 + v6 
    let v107 : string = v106 + v105 
    let _v7 = v107 
    #endif
#if FABLE_COMPILER_PYTHON
    let v108 : string = "\u001b[90m"
    let v109 : string = method16()
    let v110 : string = v108 + v6 
    let v111 : string = v110 + v109 
    let _v7 = v111 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v112 : string = "\u001b[90m"
    let v113 : string = method16()
    let v114 : string = v112 + v6 
    let v115 : string = v114 + v113 
    let _v7 = v115 
    #endif
#else
    let v116 : string = "\u001b[90m"
    let v117 : string = method16()
    let v118 : string = v116 + v6 
    let v119 : string = v118 + v117 
    let _v7 = v119 
    #endif
    let v120 : string = _v7 
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
    let v121 : (string -> unit) = v18.l0
    v121 v0
and closure5 (v0 : int32, v1 : string) () : unit =
    let v2 : US0 = US0_0
    let v3 : bool = method8(v2)
    if v3 then
        let v4 : unit = ()
        let v5 : (unit -> unit) = closure0()
        let v6 : unit = (fun () -> v5 (); v4) ()
        let struct (v20 : Mut0, v21 : Mut1, v22 : Mut2, v23 : Mut3, v24 : Mut4, v25 : int64 option) = TraceState.trace_state.Value
        let v38 : string = method9(v20, v21, v22, v23, v24, v25)
        let v39 : string = method13()
        let v40 : string = method17(v20, v21, v22, v23, v24, v25, v38, v39, v0, v1)
        method20(v40)
and method6 (v0 : string, v1 : int32) : Async<bool> =
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
    let v12 : unit = ()
    let _v12 =
        async {
            let v15 : Async<System.Threading.CancellationToken> = Async.CancellationToken
            let! v15 = v15 
            let v16 : System.Threading.CancellationToken = v15 
            let v17 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v18 : System_Net_Sockets_TcpClient = null |> unbox<System_Net_Sockets_TcpClient>
            let _v17 = v18 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v21 : System_Net_Sockets_TcpClient = null |> unbox<System_Net_Sockets_TcpClient>
            let _v17 = v21 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v24 : System_Net_Sockets_TcpClient = null |> unbox<System_Net_Sockets_TcpClient>
            let _v17 = v24 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v27 : System_Net_Sockets_TcpClient = null |> unbox<System_Net_Sockets_TcpClient>
            let _v17 = v27 
            #endif
#if FABLE_COMPILER_PYTHON
            let v30 : System_Net_Sockets_TcpClient = null |> unbox<System_Net_Sockets_TcpClient>
            let _v17 = v30 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v33 : System_Net_Sockets_TcpClient = null |> unbox<System_Net_Sockets_TcpClient>
            let _v17 = v33 
            #endif
#else
            let v36 : System_Net_Sockets_TcpClient = new System_Net_Sockets_TcpClient ()
            let _v17 = v36 
            #endif
            let v37 : System_Net_Sockets_TcpClient = _v17 
            use v37 = v37 
            let v42 : System_Net_Sockets_TcpClient = v37 
            try
            let v43 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v44 : System.Threading.Tasks.ValueTask = null |> unbox<System.Threading.Tasks.ValueTask>
            let _v43 = v44 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v47 : System.Threading.Tasks.ValueTask = null |> unbox<System.Threading.Tasks.ValueTask>
            let _v43 = v47 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v50 : System.Threading.Tasks.ValueTask = null |> unbox<System.Threading.Tasks.ValueTask>
            let _v43 = v50 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v53 : System.Threading.Tasks.ValueTask = null |> unbox<System.Threading.Tasks.ValueTask>
            let _v43 = v53 
            #endif
#if FABLE_COMPILER_PYTHON
            let v56 : System.Threading.Tasks.ValueTask = null |> unbox<System.Threading.Tasks.ValueTask>
            let _v43 = v56 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v59 : System.Threading.Tasks.ValueTask = null |> unbox<System.Threading.Tasks.ValueTask>
            let _v43 = v59 
            #endif
#else
            let v62 : System.Threading.Tasks.ValueTask = v42.ConnectAsync (v0, v1, v16)
            let _v43 = v62 
            #endif
            let v63 : System.Threading.Tasks.ValueTask = _v43 
            let v68 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v69 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
            let _v68 = v69 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v72 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
            let _v68 = v72 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v75 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
            let _v68 = v75 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v78 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
            let _v68 = v78 
            #endif
#if FABLE_COMPILER_PYTHON
            let v81 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
            let _v68 = v81 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v84 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
            let _v68 = v84 
            #endif
#else
            let v87 : (unit -> System.Threading.Tasks.Task) = v63.AsTask
            let v88 : System.Threading.Tasks.Task = v87 ()
            let _v68 = v88 
            #endif
            let v89 : System.Threading.Tasks.Task = _v68 
            let v94 : Async<unit> = method7(v89)
            do! v94 
            return true 
            with ex ->
                let v95 : exn = ex
                let v96 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v97 : string = $"%A{v95}"
                let _v96 = v97 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v100 : string = $"%A{v95}"
                let _v96 = v100 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v103 : string = $"%A{v95}"
                let _v96 = v103 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v106 : string = $"%A{v95}"
                let _v96 = v106 
                #endif
#if FABLE_COMPILER_PYTHON
                let v109 : string = $"%A{v95}"
                let _v96 = v109 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v112 : string = $"%A{v95}"
                let _v96 = v112 
                #endif
#else
                let v115 : string = $"{v95.GetType ()}: {v95.Message}"
                let _v96 = v115 
                #endif
                let v116 : string = _v96 
                let v121 : unit = ()
                let v122 : (unit -> unit) = closure5(v1, v116)
                let v123 : unit = (fun () -> v122 (); v121) ()
                return false 
                (*
                ()
            *)
            (*
            let v231 : bool = *)
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v1751 : Async<bool> = _v12 
    let _v2 = v1751 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1752 : unit = ()
    let _v1752 =
        async {
            let v1755 : Async<System.Threading.CancellationToken> = Async.CancellationToken
            let! v1755 = v1755 
            let v1756 : System.Threading.CancellationToken = v1755 
            let v1757 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1758 : System_Net_Sockets_TcpClient = null |> unbox<System_Net_Sockets_TcpClient>
            let _v1757 = v1758 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1761 : System_Net_Sockets_TcpClient = null |> unbox<System_Net_Sockets_TcpClient>
            let _v1757 = v1761 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1764 : System_Net_Sockets_TcpClient = null |> unbox<System_Net_Sockets_TcpClient>
            let _v1757 = v1764 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1767 : System_Net_Sockets_TcpClient = null |> unbox<System_Net_Sockets_TcpClient>
            let _v1757 = v1767 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1770 : System_Net_Sockets_TcpClient = null |> unbox<System_Net_Sockets_TcpClient>
            let _v1757 = v1770 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1773 : System_Net_Sockets_TcpClient = null |> unbox<System_Net_Sockets_TcpClient>
            let _v1757 = v1773 
            #endif
#else
            let v1776 : System_Net_Sockets_TcpClient = new System_Net_Sockets_TcpClient ()
            let _v1757 = v1776 
            #endif
            let v1777 : System_Net_Sockets_TcpClient = _v1757 
            use v1777 = v1777 
            let v1782 : System_Net_Sockets_TcpClient = v1777 
            try
            let v1783 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1784 : System.Threading.Tasks.ValueTask = null |> unbox<System.Threading.Tasks.ValueTask>
            let _v1783 = v1784 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1787 : System.Threading.Tasks.ValueTask = null |> unbox<System.Threading.Tasks.ValueTask>
            let _v1783 = v1787 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1790 : System.Threading.Tasks.ValueTask = null |> unbox<System.Threading.Tasks.ValueTask>
            let _v1783 = v1790 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1793 : System.Threading.Tasks.ValueTask = null |> unbox<System.Threading.Tasks.ValueTask>
            let _v1783 = v1793 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1796 : System.Threading.Tasks.ValueTask = null |> unbox<System.Threading.Tasks.ValueTask>
            let _v1783 = v1796 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1799 : System.Threading.Tasks.ValueTask = null |> unbox<System.Threading.Tasks.ValueTask>
            let _v1783 = v1799 
            #endif
#else
            let v1802 : System.Threading.Tasks.ValueTask = v1782.ConnectAsync (v0, v1, v1756)
            let _v1783 = v1802 
            #endif
            let v1803 : System.Threading.Tasks.ValueTask = _v1783 
            let v1808 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1809 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
            let _v1808 = v1809 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1812 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
            let _v1808 = v1812 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1815 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
            let _v1808 = v1815 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1818 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
            let _v1808 = v1818 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1821 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
            let _v1808 = v1821 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1824 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
            let _v1808 = v1824 
            #endif
#else
            let v1827 : (unit -> System.Threading.Tasks.Task) = v1803.AsTask
            let v1828 : System.Threading.Tasks.Task = v1827 ()
            let _v1808 = v1828 
            #endif
            let v1829 : System.Threading.Tasks.Task = _v1808 
            let v1834 : Async<unit> = method7(v1829)
            do! v1834 
            return true 
            with ex ->
                let v1835 : exn = ex
                let v1836 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v1837 : string = $"%A{v1835}"
                let _v1836 = v1837 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v1840 : string = $"%A{v1835}"
                let _v1836 = v1840 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v1843 : string = $"%A{v1835}"
                let _v1836 = v1843 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v1846 : string = $"%A{v1835}"
                let _v1836 = v1846 
                #endif
#if FABLE_COMPILER_PYTHON
                let v1849 : string = $"%A{v1835}"
                let _v1836 = v1849 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v1852 : string = $"%A{v1835}"
                let _v1836 = v1852 
                #endif
#else
                let v1855 : string = $"{v1835.GetType ()}: {v1835.Message}"
                let _v1836 = v1855 
                #endif
                let v1856 : string = _v1836 
                let v1861 : unit = ()
                let v1862 : (unit -> unit) = closure5(v1, v1856)
                let v1863 : unit = (fun () -> v1862 (); v1861) ()
                return false 
                (*
                ()
            *)
            (*
            let v1971 : bool = *)
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v3491 : Async<bool> = _v1752 
    let _v2 = v3491 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v3492 : unit = ()
    let _v3492 =
        async {
            let v3495 : Async<System.Threading.CancellationToken> = Async.CancellationToken
            let! v3495 = v3495 
            let v3496 : System.Threading.CancellationToken = v3495 
            let v3497 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v3498 : System_Net_Sockets_TcpClient = null |> unbox<System_Net_Sockets_TcpClient>
            let _v3497 = v3498 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v3501 : System_Net_Sockets_TcpClient = null |> unbox<System_Net_Sockets_TcpClient>
            let _v3497 = v3501 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v3504 : System_Net_Sockets_TcpClient = null |> unbox<System_Net_Sockets_TcpClient>
            let _v3497 = v3504 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v3507 : System_Net_Sockets_TcpClient = null |> unbox<System_Net_Sockets_TcpClient>
            let _v3497 = v3507 
            #endif
#if FABLE_COMPILER_PYTHON
            let v3510 : System_Net_Sockets_TcpClient = null |> unbox<System_Net_Sockets_TcpClient>
            let _v3497 = v3510 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v3513 : System_Net_Sockets_TcpClient = null |> unbox<System_Net_Sockets_TcpClient>
            let _v3497 = v3513 
            #endif
#else
            let v3516 : System_Net_Sockets_TcpClient = new System_Net_Sockets_TcpClient ()
            let _v3497 = v3516 
            #endif
            let v3517 : System_Net_Sockets_TcpClient = _v3497 
            use v3517 = v3517 
            let v3522 : System_Net_Sockets_TcpClient = v3517 
            try
            let v3523 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v3524 : System.Threading.Tasks.ValueTask = null |> unbox<System.Threading.Tasks.ValueTask>
            let _v3523 = v3524 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v3527 : System.Threading.Tasks.ValueTask = null |> unbox<System.Threading.Tasks.ValueTask>
            let _v3523 = v3527 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v3530 : System.Threading.Tasks.ValueTask = null |> unbox<System.Threading.Tasks.ValueTask>
            let _v3523 = v3530 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v3533 : System.Threading.Tasks.ValueTask = null |> unbox<System.Threading.Tasks.ValueTask>
            let _v3523 = v3533 
            #endif
#if FABLE_COMPILER_PYTHON
            let v3536 : System.Threading.Tasks.ValueTask = null |> unbox<System.Threading.Tasks.ValueTask>
            let _v3523 = v3536 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v3539 : System.Threading.Tasks.ValueTask = null |> unbox<System.Threading.Tasks.ValueTask>
            let _v3523 = v3539 
            #endif
#else
            let v3542 : System.Threading.Tasks.ValueTask = v3522.ConnectAsync (v0, v1, v3496)
            let _v3523 = v3542 
            #endif
            let v3543 : System.Threading.Tasks.ValueTask = _v3523 
            let v3548 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v3549 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
            let _v3548 = v3549 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v3552 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
            let _v3548 = v3552 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v3555 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
            let _v3548 = v3555 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v3558 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
            let _v3548 = v3558 
            #endif
#if FABLE_COMPILER_PYTHON
            let v3561 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
            let _v3548 = v3561 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v3564 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
            let _v3548 = v3564 
            #endif
#else
            let v3567 : (unit -> System.Threading.Tasks.Task) = v3543.AsTask
            let v3568 : System.Threading.Tasks.Task = v3567 ()
            let _v3548 = v3568 
            #endif
            let v3569 : System.Threading.Tasks.Task = _v3548 
            let v3574 : Async<unit> = method7(v3569)
            do! v3574 
            return true 
            with ex ->
                let v3575 : exn = ex
                let v3576 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v3577 : string = $"%A{v3575}"
                let _v3576 = v3577 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v3580 : string = $"%A{v3575}"
                let _v3576 = v3580 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v3583 : string = $"%A{v3575}"
                let _v3576 = v3583 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v3586 : string = $"%A{v3575}"
                let _v3576 = v3586 
                #endif
#if FABLE_COMPILER_PYTHON
                let v3589 : string = $"%A{v3575}"
                let _v3576 = v3589 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v3592 : string = $"%A{v3575}"
                let _v3576 = v3592 
                #endif
#else
                let v3595 : string = $"{v3575.GetType ()}: {v3575.Message}"
                let _v3576 = v3595 
                #endif
                let v3596 : string = _v3576 
                let v3601 : unit = ()
                let v3602 : (unit -> unit) = closure5(v1, v3596)
                let v3603 : unit = (fun () -> v3602 (); v3601) ()
                return false 
                (*
                ()
            *)
            (*
            let v3711 : bool = *)
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v5231 : Async<bool> = _v3492 
    let _v2 = v5231 
    #endif
#else
    let v5232 : unit = ()
    let _v5232 =
        async {
            let v5235 : Async<System.Threading.CancellationToken> = Async.CancellationToken
            let! v5235 = v5235 
            let v5236 : System.Threading.CancellationToken = v5235 
            let v5237 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v5238 : System_Net_Sockets_TcpClient = null |> unbox<System_Net_Sockets_TcpClient>
            let _v5237 = v5238 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v5241 : System_Net_Sockets_TcpClient = null |> unbox<System_Net_Sockets_TcpClient>
            let _v5237 = v5241 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v5244 : System_Net_Sockets_TcpClient = null |> unbox<System_Net_Sockets_TcpClient>
            let _v5237 = v5244 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v5247 : System_Net_Sockets_TcpClient = null |> unbox<System_Net_Sockets_TcpClient>
            let _v5237 = v5247 
            #endif
#if FABLE_COMPILER_PYTHON
            let v5250 : System_Net_Sockets_TcpClient = null |> unbox<System_Net_Sockets_TcpClient>
            let _v5237 = v5250 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v5253 : System_Net_Sockets_TcpClient = null |> unbox<System_Net_Sockets_TcpClient>
            let _v5237 = v5253 
            #endif
#else
            let v5256 : System_Net_Sockets_TcpClient = new System_Net_Sockets_TcpClient ()
            let _v5237 = v5256 
            #endif
            let v5257 : System_Net_Sockets_TcpClient = _v5237 
            use v5257 = v5257 
            let v5262 : System_Net_Sockets_TcpClient = v5257 
            try
            let v5263 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v5264 : System.Threading.Tasks.ValueTask = null |> unbox<System.Threading.Tasks.ValueTask>
            let _v5263 = v5264 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v5267 : System.Threading.Tasks.ValueTask = null |> unbox<System.Threading.Tasks.ValueTask>
            let _v5263 = v5267 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v5270 : System.Threading.Tasks.ValueTask = null |> unbox<System.Threading.Tasks.ValueTask>
            let _v5263 = v5270 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v5273 : System.Threading.Tasks.ValueTask = null |> unbox<System.Threading.Tasks.ValueTask>
            let _v5263 = v5273 
            #endif
#if FABLE_COMPILER_PYTHON
            let v5276 : System.Threading.Tasks.ValueTask = null |> unbox<System.Threading.Tasks.ValueTask>
            let _v5263 = v5276 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v5279 : System.Threading.Tasks.ValueTask = null |> unbox<System.Threading.Tasks.ValueTask>
            let _v5263 = v5279 
            #endif
#else
            let v5282 : System.Threading.Tasks.ValueTask = v5262.ConnectAsync (v0, v1, v5236)
            let _v5263 = v5282 
            #endif
            let v5283 : System.Threading.Tasks.ValueTask = _v5263 
            let v5288 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v5289 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
            let _v5288 = v5289 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v5292 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
            let _v5288 = v5292 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v5295 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
            let _v5288 = v5295 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v5298 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
            let _v5288 = v5298 
            #endif
#if FABLE_COMPILER_PYTHON
            let v5301 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
            let _v5288 = v5301 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v5304 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
            let _v5288 = v5304 
            #endif
#else
            let v5307 : (unit -> System.Threading.Tasks.Task) = v5283.AsTask
            let v5308 : System.Threading.Tasks.Task = v5307 ()
            let _v5288 = v5308 
            #endif
            let v5309 : System.Threading.Tasks.Task = _v5288 
            let v5314 : Async<unit> = method7(v5309)
            do! v5314 
            return true 
            with ex ->
                let v5315 : exn = ex
                let v5316 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v5317 : string = $"%A{v5315}"
                let _v5316 = v5317 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v5320 : string = $"%A{v5315}"
                let _v5316 = v5320 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v5323 : string = $"%A{v5315}"
                let _v5316 = v5323 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v5326 : string = $"%A{v5315}"
                let _v5316 = v5326 
                #endif
#if FABLE_COMPILER_PYTHON
                let v5329 : string = $"%A{v5315}"
                let _v5316 = v5329 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v5332 : string = $"%A{v5315}"
                let _v5316 = v5332 
                #endif
#else
                let v5335 : string = $"{v5315.GetType ()}: {v5315.Message}"
                let _v5316 = v5335 
                #endif
                let v5336 : string = _v5316 
                let v5341 : unit = ()
                let v5342 : (unit -> unit) = closure5(v1, v5336)
                let v5343 : unit = (fun () -> v5342 (); v5341) ()
                return false 
                (*
                ()
            *)
            (*
            let v5451 : bool = *)
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v6971 : Async<bool> = _v5232 
    let _v2 = v6971 
    #endif
    let v6972 : Async<bool> = _v2 
    v6972
and closure4 (v0 : string) (v1 : int32) : Async<bool> =
    method6(v0, v1)
and closure3 () (v0 : string) : (int32 -> Async<bool>) =
    closure4(v0)
and method23 (v0 : int32, v1 : Async<bool>) : Async<Async<bool>> =
    let v2 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
    let _v2 = v3 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v6 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
    let _v2 = v6 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v9 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
    let _v2 = v9 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v12 : Async<Async<bool>> = Async.StartChild (v1, v0)
    let _v2 = v12 
    #endif
#if FABLE_COMPILER_PYTHON
    let v13 : Async<Async<bool>> = Async.StartChild (v1, v0)
    let _v2 = v13 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v14 : Async<Async<bool>> = Async.StartChild (v1, v0)
    let _v2 = v14 
    #endif
#else
    let v15 : Async<Async<bool>> = Async.StartChild (v1, v0)
    let _v2 = v15 
    #endif
    let v16 : Async<Async<bool>> = _v2 
    v16
and method25 (v0 : Async<bool>) : Async<Choice<bool, exn>> =
    let v1 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
    let v3 : Async<Choice<bool, exn>> = v2 v0
    let _v1 = v3 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v4 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
    let v5 : Async<Choice<bool, exn>> = v4 v0
    let _v1 = v5 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v6 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
    let v7 : Async<Choice<bool, exn>> = v6 v0
    let _v1 = v7 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v8 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
    let v9 : Async<Choice<bool, exn>> = v8 v0
    let _v1 = v9 
    #endif
#if FABLE_COMPILER_PYTHON
    let v10 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
    let v11 : Async<Choice<bool, exn>> = v10 v0
    let _v1 = v11 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v12 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
    let v13 : Async<Choice<bool, exn>> = v12 v0
    let _v1 = v13 
    #endif
#else
    let v14 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
    let v15 : Async<Choice<bool, exn>> = v14 v0
    let _v1 = v15 
    #endif
    let v16 : Async<Choice<bool, exn>> = _v1 
    v16
and closure14 () (v0 : bool) : US8 =
    US8_0(v0)
and method26 () : (bool -> US8) =
    closure14()
and closure15 () (v0 : exn) : US8 =
    US8_1(v0)
and method27 () : (exn -> US8) =
    closure15()
and method24 (v0 : Async<bool>) : Async<US7> =
    let v1 : Async<Choice<bool, exn>> = method25(v0)
    let v2 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : Async<US8> = null |> unbox<Async<US8>>
    let _v2 = v3 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v6 : Async<US8> = null |> unbox<Async<US8>>
    let _v2 = v6 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v9 : Async<US8> = null |> unbox<Async<US8>>
    let _v2 = v9 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v12 : unit = ()
    let _v12 =
        async {
            let! v1 = v1 
            let v15 : Choice<bool, exn> = v1 
            let v16 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v17 : US8 = null |> unbox<US8>
            let _v16 = v17 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v20 : US8 = null |> unbox<US8>
            let _v16 = v20 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v23 : US8 = null |> unbox<US8>
            let _v16 = v23 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v26 : US8 = null |> unbox<US8>
            let _v16 = v26 
            #endif
#if FABLE_COMPILER_PYTHON
            let v29 : US8 = null |> unbox<US8>
            let _v16 = v29 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v32 : (bool -> US8) = method26()
            let v33 : (exn -> US8) = method27()
            let v34 : US8 = match v15 with Choice1Of2 x -> v32 x | Choice2Of2 x -> v33 x
            let _v16 = v34 
            #endif
#else
            let v35 : (bool -> US8) = method26()
            let v36 : (exn -> US8) = method27()
            let v37 : US8 = match v15 with Choice1Of2 x -> v35 x | Choice2Of2 x -> v36 x
            let _v16 = v37 
            #endif
            let v38 : US8 = _v16 
            return v38 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v239 : Async<US8> = _v12 
    let _v2 = v239 
    #endif
#if FABLE_COMPILER_PYTHON
    let v240 : unit = ()
    let _v240 =
        async {
            let! v1 = v1 
            let v243 : Choice<bool, exn> = v1 
            let v244 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v245 : US8 = null |> unbox<US8>
            let _v244 = v245 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v248 : US8 = null |> unbox<US8>
            let _v244 = v248 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v251 : US8 = null |> unbox<US8>
            let _v244 = v251 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v254 : US8 = null |> unbox<US8>
            let _v244 = v254 
            #endif
#if FABLE_COMPILER_PYTHON
            let v257 : US8 = null |> unbox<US8>
            let _v244 = v257 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v260 : (bool -> US8) = method26()
            let v261 : (exn -> US8) = method27()
            let v262 : US8 = match v243 with Choice1Of2 x -> v260 x | Choice2Of2 x -> v261 x
            let _v244 = v262 
            #endif
#else
            let v263 : (bool -> US8) = method26()
            let v264 : (exn -> US8) = method27()
            let v265 : US8 = match v243 with Choice1Of2 x -> v263 x | Choice2Of2 x -> v264 x
            let _v244 = v265 
            #endif
            let v266 : US8 = _v244 
            return v266 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v467 : Async<US8> = _v240 
    let _v2 = v467 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v468 : unit = ()
    let _v468 =
        async {
            let! v1 = v1 
            let v471 : Choice<bool, exn> = v1 
            let v472 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v473 : US8 = null |> unbox<US8>
            let _v472 = v473 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v476 : US8 = null |> unbox<US8>
            let _v472 = v476 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v479 : US8 = null |> unbox<US8>
            let _v472 = v479 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v482 : US8 = null |> unbox<US8>
            let _v472 = v482 
            #endif
#if FABLE_COMPILER_PYTHON
            let v485 : US8 = null |> unbox<US8>
            let _v472 = v485 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v488 : (bool -> US8) = method26()
            let v489 : (exn -> US8) = method27()
            let v490 : US8 = match v471 with Choice1Of2 x -> v488 x | Choice2Of2 x -> v489 x
            let _v472 = v490 
            #endif
#else
            let v491 : (bool -> US8) = method26()
            let v492 : (exn -> US8) = method27()
            let v493 : US8 = match v471 with Choice1Of2 x -> v491 x | Choice2Of2 x -> v492 x
            let _v472 = v493 
            #endif
            let v494 : US8 = _v472 
            return v494 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v695 : Async<US8> = _v468 
    let _v2 = v695 
    #endif
#else
    let v696 : unit = ()
    let _v696 =
        async {
            let! v1 = v1 
            let v699 : Choice<bool, exn> = v1 
            let v700 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v701 : US8 = null |> unbox<US8>
            let _v700 = v701 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v704 : US8 = null |> unbox<US8>
            let _v700 = v704 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v707 : US8 = null |> unbox<US8>
            let _v700 = v707 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v710 : US8 = null |> unbox<US8>
            let _v700 = v710 
            #endif
#if FABLE_COMPILER_PYTHON
            let v713 : US8 = null |> unbox<US8>
            let _v700 = v713 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v716 : (bool -> US8) = method26()
            let v717 : (exn -> US8) = method27()
            let v718 : US8 = match v699 with Choice1Of2 x -> v716 x | Choice2Of2 x -> v717 x
            let _v700 = v718 
            #endif
#else
            let v719 : (bool -> US8) = method26()
            let v720 : (exn -> US8) = method27()
            let v721 : US8 = match v699 with Choice1Of2 x -> v719 x | Choice2Of2 x -> v720 x
            let _v700 = v721 
            #endif
            let v722 : US8 = _v700 
            return v722 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v923 : Async<US8> = _v696 
    let _v2 = v923 
    #endif
    let v924 : Async<US8> = _v2 
    let v1042 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1043 : Async<US7> = null |> unbox<Async<US7>>
    let _v1042 = v1043 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1046 : Async<US7> = null |> unbox<Async<US7>>
    let _v1042 = v1046 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1049 : Async<US7> = null |> unbox<Async<US7>>
    let _v1042 = v1049 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1052 : unit = ()
    let _v1052 =
        async {
            let! v924 = v924 
            let v1055 : US8 = v924 
            let v1061 : US7 =
                match v1055 with
                | US8_0(v1056) -> (* C1of2 *)
                    US7_0(v1056)
                | US8_1(v1058) -> (* C2of2 *)
                    US7_1(v1058)
            return v1061 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v1111 : Async<US7> = _v1052 
    let _v1042 = v1111 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1112 : unit = ()
    let _v1112 =
        async {
            let! v924 = v924 
            let v1115 : US8 = v924 
            let v1121 : US7 =
                match v1115 with
                | US8_0(v1116) -> (* C1of2 *)
                    US7_0(v1116)
                | US8_1(v1118) -> (* C2of2 *)
                    US7_1(v1118)
            return v1121 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v1171 : Async<US7> = _v1112 
    let _v1042 = v1171 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1172 : unit = ()
    let _v1172 =
        async {
            let! v924 = v924 
            let v1175 : US8 = v924 
            let v1181 : US7 =
                match v1175 with
                | US8_0(v1176) -> (* C1of2 *)
                    US7_0(v1176)
                | US8_1(v1178) -> (* C2of2 *)
                    US7_1(v1178)
            return v1181 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v1231 : Async<US7> = _v1172 
    let _v1042 = v1231 
    #endif
#else
    let v1232 : unit = ()
    let _v1232 =
        async {
            let! v924 = v924 
            let v1235 : US8 = v924 
            let v1241 : US7 =
                match v1235 with
                | US8_0(v1236) -> (* C1of2 *)
                    US7_0(v1236)
                | US8_1(v1238) -> (* C2of2 *)
                    US7_1(v1238)
            return v1241 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v1291 : Async<US7> = _v1232 
    let _v1042 = v1291 
    #endif
    let v1292 : Async<US7> = _v1042 
    v1292
and method29 (v0 : int32) : string =
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
and method28 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : int32) : string =
    let v9 : string = method29(v8)
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
        let v39 : string = method28(v19, v20, v21, v22, v23, v24, v37, v38, v0)
        method20(v39)
and method30 () : string =
    
    
    
    
    
    let v0 : string = "Critical"
    let v1 : (unit -> string) = v0.ToLower
    let v2 : string = v1 ()
    let v5 : char = v2.[int 0]
    let v6 : string = method14(v5)
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
    let v40 : string = "inline_colorization::color_bright_red"
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
    let v72 : string = "inline_colorization::color_bright_red"
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
    let v104 : string = "\u001b[91m"
    let v105 : string = method16()
    let v106 : string = v104 + v6 
    let v107 : string = v106 + v105 
    let _v7 = v107 
    #endif
#if FABLE_COMPILER_PYTHON
    let v108 : string = "\u001b[91m"
    let v109 : string = method16()
    let v110 : string = v108 + v6 
    let v111 : string = v110 + v109 
    let _v7 = v111 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v112 : string = "\u001b[91m"
    let v113 : string = method16()
    let v114 : string = v112 + v6 
    let v115 : string = v114 + v113 
    let _v7 = v115 
    #endif
#else
    let v116 : string = "\u001b[91m"
    let v117 : string = method16()
    let v118 : string = v116 + v6 
    let v119 : string = v118 + v117 
    let _v7 = v119 
    #endif
    let v120 : string = _v7 
    v120
and method32 (v0 : int32, v1 : string) : string =
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
and method31 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : int32, v9 : string) : string =
    let v10 : string = method32(v8, v9)
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
        let v39 : string = method30()
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
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v56 : string = $"%A{v1}"
        let _v40 = v56 
        #endif
#else
        let v59 : string = $"{v1.GetType ()}: {v1.Message}"
        let _v40 = v59 
        #endif
        let v60 : string = _v40 
        let v65 : string = method31(v20, v21, v22, v23, v24, v25, v38, v39, v0, v60)
        method20(v65)
and method22 (v0 : int32, v1 : Async<bool>) : Async<US6> =
    let v2 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v4 : Async<US6> = null |> unbox<Async<US6>>
    let _v3 = v4 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v7 : Async<US6> = null |> unbox<Async<US6>>
    let _v3 = v7 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v10 : Async<US6> = null |> unbox<Async<US6>>
    let _v3 = v10 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v13 : unit = ()
    let _v13 =
        async {
            let v16 : Async<Async<bool>> = method23(v0, v1)
            let! v16 = v16 
            let v17 : Async<bool> = v16 
            let v18 : Async<US7> = method24(v17)
            let v19 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v20 : Async<US6> = null |> unbox<Async<US6>>
            let _v19 = v20 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v23 : Async<US6> = null |> unbox<Async<US6>>
            let _v19 = v23 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v26 : Async<US6> = null |> unbox<Async<US6>>
            let _v19 = v26 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v29 : unit = ()
            let _v29 =
                async {
                    let! v18 = v18 
                    let v32 : US7 = v18 
                    let v156 : US6 =
                        match v32 with
                        | US7_1(v35) -> (* Error *)
                            let v36 : string = $"%A{v35}"
                            let v39 : string = "System.TimeoutException"
                            let v40 : bool = v36.Contains v39 
                            if v40 then
                                let v43 : unit = ()
                                let v44 : (unit -> unit) = closure16(v0)
                                let v45 : unit = (fun () -> v44 (); v43) ()
                                US6_1
                            else
                                let v86 : unit = ()
                                let v87 : (unit -> unit) = closure17(v0, v35)
                                let v88 : unit = (fun () -> v87 (); v86) ()
                                US6_1
                        | US7_0(v33) -> (* Ok *)
                            US6_0(v33)
                    return v156 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v1032 : Async<US6> = _v29 
            let _v19 = v1032 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1033 : unit = ()
            let _v1033 =
                async {
                    let! v18 = v18 
                    let v1036 : US7 = v18 
                    let v1160 : US6 =
                        match v1036 with
                        | US7_1(v1039) -> (* Error *)
                            let v1040 : string = $"%A{v1039}"
                            let v1043 : string = "System.TimeoutException"
                            let v1044 : bool = v1040.Contains v1043 
                            if v1044 then
                                let v1047 : unit = ()
                                let v1048 : (unit -> unit) = closure16(v0)
                                let v1049 : unit = (fun () -> v1048 (); v1047) ()
                                US6_1
                            else
                                let v1090 : unit = ()
                                let v1091 : (unit -> unit) = closure17(v0, v1039)
                                let v1092 : unit = (fun () -> v1091 (); v1090) ()
                                US6_1
                        | US7_0(v1037) -> (* Ok *)
                            US6_0(v1037)
                    return v1160 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v2036 : Async<US6> = _v1033 
            let _v19 = v2036 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v2037 : unit = ()
            let _v2037 =
                async {
                    let! v18 = v18 
                    let v2040 : US7 = v18 
                    let v2164 : US6 =
                        match v2040 with
                        | US7_1(v2043) -> (* Error *)
                            let v2044 : string = $"%A{v2043}"
                            let v2047 : string = "System.TimeoutException"
                            let v2048 : bool = v2044.Contains v2047 
                            if v2048 then
                                let v2051 : unit = ()
                                let v2052 : (unit -> unit) = closure16(v0)
                                let v2053 : unit = (fun () -> v2052 (); v2051) ()
                                US6_1
                            else
                                let v2094 : unit = ()
                                let v2095 : (unit -> unit) = closure17(v0, v2043)
                                let v2096 : unit = (fun () -> v2095 (); v2094) ()
                                US6_1
                        | US7_0(v2041) -> (* Ok *)
                            US6_0(v2041)
                    return v2164 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v3040 : Async<US6> = _v2037 
            let _v19 = v3040 
            #endif
#else
            let v3041 : unit = ()
            let _v3041 =
                async {
                    let! v18 = v18 
                    let v3044 : US7 = v18 
                    let v3168 : US6 =
                        match v3044 with
                        | US7_1(v3047) -> (* Error *)
                            let v3048 : string = $"%A{v3047}"
                            let v3051 : string = "System.TimeoutException"
                            let v3052 : bool = v3048.Contains v3051 
                            if v3052 then
                                let v3055 : unit = ()
                                let v3056 : (unit -> unit) = closure16(v0)
                                let v3057 : unit = (fun () -> v3056 (); v3055) ()
                                US6_1
                            else
                                let v3098 : unit = ()
                                let v3099 : (unit -> unit) = closure17(v0, v3047)
                                let v3100 : unit = (fun () -> v3099 (); v3098) ()
                                US6_1
                        | US7_0(v3045) -> (* Ok *)
                            US6_0(v3045)
                    return v3168 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v4044 : Async<US6> = _v3041 
            let _v19 = v4044 
            #endif
            let v4045 : Async<US6> = _v19 
            return! v4045 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v36296 : Async<US6> = _v13 
    let _v3 = v36296 
    #endif
#if FABLE_COMPILER_PYTHON
    let v36297 : unit = ()
    let _v36297 =
        async {
            let v36300 : Async<Async<bool>> = method23(v0, v1)
            let! v36300 = v36300 
            let v36301 : Async<bool> = v36300 
            let v36302 : Async<US7> = method24(v36301)
            let v36303 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v36304 : Async<US6> = null |> unbox<Async<US6>>
            let _v36303 = v36304 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v36307 : Async<US6> = null |> unbox<Async<US6>>
            let _v36303 = v36307 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v36310 : Async<US6> = null |> unbox<Async<US6>>
            let _v36303 = v36310 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v36313 : unit = ()
            let _v36313 =
                async {
                    let! v36302 = v36302 
                    let v36316 : US7 = v36302 
                    let v36440 : US6 =
                        match v36316 with
                        | US7_1(v36319) -> (* Error *)
                            let v36320 : string = $"%A{v36319}"
                            let v36323 : string = "System.TimeoutException"
                            let v36324 : bool = v36320.Contains v36323 
                            if v36324 then
                                let v36327 : unit = ()
                                let v36328 : (unit -> unit) = closure16(v0)
                                let v36329 : unit = (fun () -> v36328 (); v36327) ()
                                US6_1
                            else
                                let v36370 : unit = ()
                                let v36371 : (unit -> unit) = closure17(v0, v36319)
                                let v36372 : unit = (fun () -> v36371 (); v36370) ()
                                US6_1
                        | US7_0(v36317) -> (* Ok *)
                            US6_0(v36317)
                    return v36440 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v37316 : Async<US6> = _v36313 
            let _v36303 = v37316 
            #endif
#if FABLE_COMPILER_PYTHON
            let v37317 : unit = ()
            let _v37317 =
                async {
                    let! v36302 = v36302 
                    let v37320 : US7 = v36302 
                    let v37444 : US6 =
                        match v37320 with
                        | US7_1(v37323) -> (* Error *)
                            let v37324 : string = $"%A{v37323}"
                            let v37327 : string = "System.TimeoutException"
                            let v37328 : bool = v37324.Contains v37327 
                            if v37328 then
                                let v37331 : unit = ()
                                let v37332 : (unit -> unit) = closure16(v0)
                                let v37333 : unit = (fun () -> v37332 (); v37331) ()
                                US6_1
                            else
                                let v37374 : unit = ()
                                let v37375 : (unit -> unit) = closure17(v0, v37323)
                                let v37376 : unit = (fun () -> v37375 (); v37374) ()
                                US6_1
                        | US7_0(v37321) -> (* Ok *)
                            US6_0(v37321)
                    return v37444 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v38320 : Async<US6> = _v37317 
            let _v36303 = v38320 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v38321 : unit = ()
            let _v38321 =
                async {
                    let! v36302 = v36302 
                    let v38324 : US7 = v36302 
                    let v38448 : US6 =
                        match v38324 with
                        | US7_1(v38327) -> (* Error *)
                            let v38328 : string = $"%A{v38327}"
                            let v38331 : string = "System.TimeoutException"
                            let v38332 : bool = v38328.Contains v38331 
                            if v38332 then
                                let v38335 : unit = ()
                                let v38336 : (unit -> unit) = closure16(v0)
                                let v38337 : unit = (fun () -> v38336 (); v38335) ()
                                US6_1
                            else
                                let v38378 : unit = ()
                                let v38379 : (unit -> unit) = closure17(v0, v38327)
                                let v38380 : unit = (fun () -> v38379 (); v38378) ()
                                US6_1
                        | US7_0(v38325) -> (* Ok *)
                            US6_0(v38325)
                    return v38448 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v39324 : Async<US6> = _v38321 
            let _v36303 = v39324 
            #endif
#else
            let v39325 : unit = ()
            let _v39325 =
                async {
                    let! v36302 = v36302 
                    let v39328 : US7 = v36302 
                    let v39452 : US6 =
                        match v39328 with
                        | US7_1(v39331) -> (* Error *)
                            let v39332 : string = $"%A{v39331}"
                            let v39335 : string = "System.TimeoutException"
                            let v39336 : bool = v39332.Contains v39335 
                            if v39336 then
                                let v39339 : unit = ()
                                let v39340 : (unit -> unit) = closure16(v0)
                                let v39341 : unit = (fun () -> v39340 (); v39339) ()
                                US6_1
                            else
                                let v39382 : unit = ()
                                let v39383 : (unit -> unit) = closure17(v0, v39331)
                                let v39384 : unit = (fun () -> v39383 (); v39382) ()
                                US6_1
                        | US7_0(v39329) -> (* Ok *)
                            US6_0(v39329)
                    return v39452 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v40328 : Async<US6> = _v39325 
            let _v36303 = v40328 
            #endif
            let v40329 : Async<US6> = _v36303 
            return! v40329 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v72580 : Async<US6> = _v36297 
    let _v3 = v72580 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v72581 : unit = ()
    let _v72581 =
        async {
            let v72584 : Async<Async<bool>> = method23(v0, v1)
            let! v72584 = v72584 
            let v72585 : Async<bool> = v72584 
            let v72586 : Async<US7> = method24(v72585)
            let v72587 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v72588 : Async<US6> = null |> unbox<Async<US6>>
            let _v72587 = v72588 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v72591 : Async<US6> = null |> unbox<Async<US6>>
            let _v72587 = v72591 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v72594 : Async<US6> = null |> unbox<Async<US6>>
            let _v72587 = v72594 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v72597 : unit = ()
            let _v72597 =
                async {
                    let! v72586 = v72586 
                    let v72600 : US7 = v72586 
                    let v72724 : US6 =
                        match v72600 with
                        | US7_1(v72603) -> (* Error *)
                            let v72604 : string = $"%A{v72603}"
                            let v72607 : string = "System.TimeoutException"
                            let v72608 : bool = v72604.Contains v72607 
                            if v72608 then
                                let v72611 : unit = ()
                                let v72612 : (unit -> unit) = closure16(v0)
                                let v72613 : unit = (fun () -> v72612 (); v72611) ()
                                US6_1
                            else
                                let v72654 : unit = ()
                                let v72655 : (unit -> unit) = closure17(v0, v72603)
                                let v72656 : unit = (fun () -> v72655 (); v72654) ()
                                US6_1
                        | US7_0(v72601) -> (* Ok *)
                            US6_0(v72601)
                    return v72724 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v73600 : Async<US6> = _v72597 
            let _v72587 = v73600 
            #endif
#if FABLE_COMPILER_PYTHON
            let v73601 : unit = ()
            let _v73601 =
                async {
                    let! v72586 = v72586 
                    let v73604 : US7 = v72586 
                    let v73728 : US6 =
                        match v73604 with
                        | US7_1(v73607) -> (* Error *)
                            let v73608 : string = $"%A{v73607}"
                            let v73611 : string = "System.TimeoutException"
                            let v73612 : bool = v73608.Contains v73611 
                            if v73612 then
                                let v73615 : unit = ()
                                let v73616 : (unit -> unit) = closure16(v0)
                                let v73617 : unit = (fun () -> v73616 (); v73615) ()
                                US6_1
                            else
                                let v73658 : unit = ()
                                let v73659 : (unit -> unit) = closure17(v0, v73607)
                                let v73660 : unit = (fun () -> v73659 (); v73658) ()
                                US6_1
                        | US7_0(v73605) -> (* Ok *)
                            US6_0(v73605)
                    return v73728 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v74604 : Async<US6> = _v73601 
            let _v72587 = v74604 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v74605 : unit = ()
            let _v74605 =
                async {
                    let! v72586 = v72586 
                    let v74608 : US7 = v72586 
                    let v74732 : US6 =
                        match v74608 with
                        | US7_1(v74611) -> (* Error *)
                            let v74612 : string = $"%A{v74611}"
                            let v74615 : string = "System.TimeoutException"
                            let v74616 : bool = v74612.Contains v74615 
                            if v74616 then
                                let v74619 : unit = ()
                                let v74620 : (unit -> unit) = closure16(v0)
                                let v74621 : unit = (fun () -> v74620 (); v74619) ()
                                US6_1
                            else
                                let v74662 : unit = ()
                                let v74663 : (unit -> unit) = closure17(v0, v74611)
                                let v74664 : unit = (fun () -> v74663 (); v74662) ()
                                US6_1
                        | US7_0(v74609) -> (* Ok *)
                            US6_0(v74609)
                    return v74732 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v75608 : Async<US6> = _v74605 
            let _v72587 = v75608 
            #endif
#else
            let v75609 : unit = ()
            let _v75609 =
                async {
                    let! v72586 = v72586 
                    let v75612 : US7 = v72586 
                    let v75736 : US6 =
                        match v75612 with
                        | US7_1(v75615) -> (* Error *)
                            let v75616 : string = $"%A{v75615}"
                            let v75619 : string = "System.TimeoutException"
                            let v75620 : bool = v75616.Contains v75619 
                            if v75620 then
                                let v75623 : unit = ()
                                let v75624 : (unit -> unit) = closure16(v0)
                                let v75625 : unit = (fun () -> v75624 (); v75623) ()
                                US6_1
                            else
                                let v75666 : unit = ()
                                let v75667 : (unit -> unit) = closure17(v0, v75615)
                                let v75668 : unit = (fun () -> v75667 (); v75666) ()
                                US6_1
                        | US7_0(v75613) -> (* Ok *)
                            US6_0(v75613)
                    return v75736 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v76612 : Async<US6> = _v75609 
            let _v72587 = v76612 
            #endif
            let v76613 : Async<US6> = _v72587 
            return! v76613 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v108864 : Async<US6> = _v72581 
    let _v3 = v108864 
    #endif
#else
    let v108865 : unit = ()
    let _v108865 =
        async {
            let v108868 : Async<Async<bool>> = method23(v0, v1)
            let! v108868 = v108868 
            let v108869 : Async<bool> = v108868 
            let v108870 : Async<US7> = method24(v108869)
            let v108871 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v108872 : Async<US6> = null |> unbox<Async<US6>>
            let _v108871 = v108872 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v108875 : Async<US6> = null |> unbox<Async<US6>>
            let _v108871 = v108875 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v108878 : Async<US6> = null |> unbox<Async<US6>>
            let _v108871 = v108878 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v108881 : unit = ()
            let _v108881 =
                async {
                    let! v108870 = v108870 
                    let v108884 : US7 = v108870 
                    let v109008 : US6 =
                        match v108884 with
                        | US7_1(v108887) -> (* Error *)
                            let v108888 : string = $"%A{v108887}"
                            let v108891 : string = "System.TimeoutException"
                            let v108892 : bool = v108888.Contains v108891 
                            if v108892 then
                                let v108895 : unit = ()
                                let v108896 : (unit -> unit) = closure16(v0)
                                let v108897 : unit = (fun () -> v108896 (); v108895) ()
                                US6_1
                            else
                                let v108938 : unit = ()
                                let v108939 : (unit -> unit) = closure17(v0, v108887)
                                let v108940 : unit = (fun () -> v108939 (); v108938) ()
                                US6_1
                        | US7_0(v108885) -> (* Ok *)
                            US6_0(v108885)
                    return v109008 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v109884 : Async<US6> = _v108881 
            let _v108871 = v109884 
            #endif
#if FABLE_COMPILER_PYTHON
            let v109885 : unit = ()
            let _v109885 =
                async {
                    let! v108870 = v108870 
                    let v109888 : US7 = v108870 
                    let v110012 : US6 =
                        match v109888 with
                        | US7_1(v109891) -> (* Error *)
                            let v109892 : string = $"%A{v109891}"
                            let v109895 : string = "System.TimeoutException"
                            let v109896 : bool = v109892.Contains v109895 
                            if v109896 then
                                let v109899 : unit = ()
                                let v109900 : (unit -> unit) = closure16(v0)
                                let v109901 : unit = (fun () -> v109900 (); v109899) ()
                                US6_1
                            else
                                let v109942 : unit = ()
                                let v109943 : (unit -> unit) = closure17(v0, v109891)
                                let v109944 : unit = (fun () -> v109943 (); v109942) ()
                                US6_1
                        | US7_0(v109889) -> (* Ok *)
                            US6_0(v109889)
                    return v110012 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v110888 : Async<US6> = _v109885 
            let _v108871 = v110888 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v110889 : unit = ()
            let _v110889 =
                async {
                    let! v108870 = v108870 
                    let v110892 : US7 = v108870 
                    let v111016 : US6 =
                        match v110892 with
                        | US7_1(v110895) -> (* Error *)
                            let v110896 : string = $"%A{v110895}"
                            let v110899 : string = "System.TimeoutException"
                            let v110900 : bool = v110896.Contains v110899 
                            if v110900 then
                                let v110903 : unit = ()
                                let v110904 : (unit -> unit) = closure16(v0)
                                let v110905 : unit = (fun () -> v110904 (); v110903) ()
                                US6_1
                            else
                                let v110946 : unit = ()
                                let v110947 : (unit -> unit) = closure17(v0, v110895)
                                let v110948 : unit = (fun () -> v110947 (); v110946) ()
                                US6_1
                        | US7_0(v110893) -> (* Ok *)
                            US6_0(v110893)
                    return v111016 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v111892 : Async<US6> = _v110889 
            let _v108871 = v111892 
            #endif
#else
            let v111893 : unit = ()
            let _v111893 =
                async {
                    let! v108870 = v108870 
                    let v111896 : US7 = v108870 
                    let v112020 : US6 =
                        match v111896 with
                        | US7_1(v111899) -> (* Error *)
                            let v111900 : string = $"%A{v111899}"
                            let v111903 : string = "System.TimeoutException"
                            let v111904 : bool = v111900.Contains v111903 
                            if v111904 then
                                let v111907 : unit = ()
                                let v111908 : (unit -> unit) = closure16(v0)
                                let v111909 : unit = (fun () -> v111908 (); v111907) ()
                                US6_1
                            else
                                let v111950 : unit = ()
                                let v111951 : (unit -> unit) = closure17(v0, v111899)
                                let v111952 : unit = (fun () -> v111951 (); v111950) ()
                                US6_1
                        | US7_0(v111897) -> (* Ok *)
                            US6_0(v111897)
                    return v112020 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v112896 : Async<US6> = _v111893 
            let _v108871 = v112896 
            #endif
            let v112897 : Async<US6> = _v108871 
            return! v112897 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v145148 : Async<US6> = _v108865 
    let _v3 = v145148 
    #endif
    let v145149 : Async<US6> = _v3 
    let _v2 = v145149 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v163295 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v163296 : Async<US6> = null |> unbox<Async<US6>>
    let _v163295 = v163296 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v163299 : Async<US6> = null |> unbox<Async<US6>>
    let _v163295 = v163299 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v163302 : Async<US6> = null |> unbox<Async<US6>>
    let _v163295 = v163302 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v163305 : unit = ()
    let _v163305 =
        async {
            let v163308 : Async<Async<bool>> = method23(v0, v1)
            let! v163308 = v163308 
            let v163309 : Async<bool> = v163308 
            let v163310 : Async<US7> = method24(v163309)
            let v163311 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v163312 : Async<US6> = null |> unbox<Async<US6>>
            let _v163311 = v163312 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v163315 : Async<US6> = null |> unbox<Async<US6>>
            let _v163311 = v163315 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v163318 : Async<US6> = null |> unbox<Async<US6>>
            let _v163311 = v163318 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v163321 : unit = ()
            let _v163321 =
                async {
                    let! v163310 = v163310 
                    let v163324 : US7 = v163310 
                    let v163448 : US6 =
                        match v163324 with
                        | US7_1(v163327) -> (* Error *)
                            let v163328 : string = $"%A{v163327}"
                            let v163331 : string = "System.TimeoutException"
                            let v163332 : bool = v163328.Contains v163331 
                            if v163332 then
                                let v163335 : unit = ()
                                let v163336 : (unit -> unit) = closure16(v0)
                                let v163337 : unit = (fun () -> v163336 (); v163335) ()
                                US6_1
                            else
                                let v163378 : unit = ()
                                let v163379 : (unit -> unit) = closure17(v0, v163327)
                                let v163380 : unit = (fun () -> v163379 (); v163378) ()
                                US6_1
                        | US7_0(v163325) -> (* Ok *)
                            US6_0(v163325)
                    return v163448 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v164324 : Async<US6> = _v163321 
            let _v163311 = v164324 
            #endif
#if FABLE_COMPILER_PYTHON
            let v164325 : unit = ()
            let _v164325 =
                async {
                    let! v163310 = v163310 
                    let v164328 : US7 = v163310 
                    let v164452 : US6 =
                        match v164328 with
                        | US7_1(v164331) -> (* Error *)
                            let v164332 : string = $"%A{v164331}"
                            let v164335 : string = "System.TimeoutException"
                            let v164336 : bool = v164332.Contains v164335 
                            if v164336 then
                                let v164339 : unit = ()
                                let v164340 : (unit -> unit) = closure16(v0)
                                let v164341 : unit = (fun () -> v164340 (); v164339) ()
                                US6_1
                            else
                                let v164382 : unit = ()
                                let v164383 : (unit -> unit) = closure17(v0, v164331)
                                let v164384 : unit = (fun () -> v164383 (); v164382) ()
                                US6_1
                        | US7_0(v164329) -> (* Ok *)
                            US6_0(v164329)
                    return v164452 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v165328 : Async<US6> = _v164325 
            let _v163311 = v165328 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v165329 : unit = ()
            let _v165329 =
                async {
                    let! v163310 = v163310 
                    let v165332 : US7 = v163310 
                    let v165456 : US6 =
                        match v165332 with
                        | US7_1(v165335) -> (* Error *)
                            let v165336 : string = $"%A{v165335}"
                            let v165339 : string = "System.TimeoutException"
                            let v165340 : bool = v165336.Contains v165339 
                            if v165340 then
                                let v165343 : unit = ()
                                let v165344 : (unit -> unit) = closure16(v0)
                                let v165345 : unit = (fun () -> v165344 (); v165343) ()
                                US6_1
                            else
                                let v165386 : unit = ()
                                let v165387 : (unit -> unit) = closure17(v0, v165335)
                                let v165388 : unit = (fun () -> v165387 (); v165386) ()
                                US6_1
                        | US7_0(v165333) -> (* Ok *)
                            US6_0(v165333)
                    return v165456 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v166332 : Async<US6> = _v165329 
            let _v163311 = v166332 
            #endif
#else
            let v166333 : unit = ()
            let _v166333 =
                async {
                    let! v163310 = v163310 
                    let v166336 : US7 = v163310 
                    let v166460 : US6 =
                        match v166336 with
                        | US7_1(v166339) -> (* Error *)
                            let v166340 : string = $"%A{v166339}"
                            let v166343 : string = "System.TimeoutException"
                            let v166344 : bool = v166340.Contains v166343 
                            if v166344 then
                                let v166347 : unit = ()
                                let v166348 : (unit -> unit) = closure16(v0)
                                let v166349 : unit = (fun () -> v166348 (); v166347) ()
                                US6_1
                            else
                                let v166390 : unit = ()
                                let v166391 : (unit -> unit) = closure17(v0, v166339)
                                let v166392 : unit = (fun () -> v166391 (); v166390) ()
                                US6_1
                        | US7_0(v166337) -> (* Ok *)
                            US6_0(v166337)
                    return v166460 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v167336 : Async<US6> = _v166333 
            let _v163311 = v167336 
            #endif
            let v167337 : Async<US6> = _v163311 
            return! v167337 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v199588 : Async<US6> = _v163305 
    let _v163295 = v199588 
    #endif
#if FABLE_COMPILER_PYTHON
    let v199589 : unit = ()
    let _v199589 =
        async {
            let v199592 : Async<Async<bool>> = method23(v0, v1)
            let! v199592 = v199592 
            let v199593 : Async<bool> = v199592 
            let v199594 : Async<US7> = method24(v199593)
            let v199595 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v199596 : Async<US6> = null |> unbox<Async<US6>>
            let _v199595 = v199596 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v199599 : Async<US6> = null |> unbox<Async<US6>>
            let _v199595 = v199599 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v199602 : Async<US6> = null |> unbox<Async<US6>>
            let _v199595 = v199602 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v199605 : unit = ()
            let _v199605 =
                async {
                    let! v199594 = v199594 
                    let v199608 : US7 = v199594 
                    let v199732 : US6 =
                        match v199608 with
                        | US7_1(v199611) -> (* Error *)
                            let v199612 : string = $"%A{v199611}"
                            let v199615 : string = "System.TimeoutException"
                            let v199616 : bool = v199612.Contains v199615 
                            if v199616 then
                                let v199619 : unit = ()
                                let v199620 : (unit -> unit) = closure16(v0)
                                let v199621 : unit = (fun () -> v199620 (); v199619) ()
                                US6_1
                            else
                                let v199662 : unit = ()
                                let v199663 : (unit -> unit) = closure17(v0, v199611)
                                let v199664 : unit = (fun () -> v199663 (); v199662) ()
                                US6_1
                        | US7_0(v199609) -> (* Ok *)
                            US6_0(v199609)
                    return v199732 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v200608 : Async<US6> = _v199605 
            let _v199595 = v200608 
            #endif
#if FABLE_COMPILER_PYTHON
            let v200609 : unit = ()
            let _v200609 =
                async {
                    let! v199594 = v199594 
                    let v200612 : US7 = v199594 
                    let v200736 : US6 =
                        match v200612 with
                        | US7_1(v200615) -> (* Error *)
                            let v200616 : string = $"%A{v200615}"
                            let v200619 : string = "System.TimeoutException"
                            let v200620 : bool = v200616.Contains v200619 
                            if v200620 then
                                let v200623 : unit = ()
                                let v200624 : (unit -> unit) = closure16(v0)
                                let v200625 : unit = (fun () -> v200624 (); v200623) ()
                                US6_1
                            else
                                let v200666 : unit = ()
                                let v200667 : (unit -> unit) = closure17(v0, v200615)
                                let v200668 : unit = (fun () -> v200667 (); v200666) ()
                                US6_1
                        | US7_0(v200613) -> (* Ok *)
                            US6_0(v200613)
                    return v200736 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v201612 : Async<US6> = _v200609 
            let _v199595 = v201612 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v201613 : unit = ()
            let _v201613 =
                async {
                    let! v199594 = v199594 
                    let v201616 : US7 = v199594 
                    let v201740 : US6 =
                        match v201616 with
                        | US7_1(v201619) -> (* Error *)
                            let v201620 : string = $"%A{v201619}"
                            let v201623 : string = "System.TimeoutException"
                            let v201624 : bool = v201620.Contains v201623 
                            if v201624 then
                                let v201627 : unit = ()
                                let v201628 : (unit -> unit) = closure16(v0)
                                let v201629 : unit = (fun () -> v201628 (); v201627) ()
                                US6_1
                            else
                                let v201670 : unit = ()
                                let v201671 : (unit -> unit) = closure17(v0, v201619)
                                let v201672 : unit = (fun () -> v201671 (); v201670) ()
                                US6_1
                        | US7_0(v201617) -> (* Ok *)
                            US6_0(v201617)
                    return v201740 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v202616 : Async<US6> = _v201613 
            let _v199595 = v202616 
            #endif
#else
            let v202617 : unit = ()
            let _v202617 =
                async {
                    let! v199594 = v199594 
                    let v202620 : US7 = v199594 
                    let v202744 : US6 =
                        match v202620 with
                        | US7_1(v202623) -> (* Error *)
                            let v202624 : string = $"%A{v202623}"
                            let v202627 : string = "System.TimeoutException"
                            let v202628 : bool = v202624.Contains v202627 
                            if v202628 then
                                let v202631 : unit = ()
                                let v202632 : (unit -> unit) = closure16(v0)
                                let v202633 : unit = (fun () -> v202632 (); v202631) ()
                                US6_1
                            else
                                let v202674 : unit = ()
                                let v202675 : (unit -> unit) = closure17(v0, v202623)
                                let v202676 : unit = (fun () -> v202675 (); v202674) ()
                                US6_1
                        | US7_0(v202621) -> (* Ok *)
                            US6_0(v202621)
                    return v202744 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v203620 : Async<US6> = _v202617 
            let _v199595 = v203620 
            #endif
            let v203621 : Async<US6> = _v199595 
            return! v203621 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v235872 : Async<US6> = _v199589 
    let _v163295 = v235872 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v235873 : unit = ()
    let _v235873 =
        async {
            let v235876 : Async<Async<bool>> = method23(v0, v1)
            let! v235876 = v235876 
            let v235877 : Async<bool> = v235876 
            let v235878 : Async<US7> = method24(v235877)
            let v235879 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v235880 : Async<US6> = null |> unbox<Async<US6>>
            let _v235879 = v235880 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v235883 : Async<US6> = null |> unbox<Async<US6>>
            let _v235879 = v235883 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v235886 : Async<US6> = null |> unbox<Async<US6>>
            let _v235879 = v235886 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v235889 : unit = ()
            let _v235889 =
                async {
                    let! v235878 = v235878 
                    let v235892 : US7 = v235878 
                    let v236016 : US6 =
                        match v235892 with
                        | US7_1(v235895) -> (* Error *)
                            let v235896 : string = $"%A{v235895}"
                            let v235899 : string = "System.TimeoutException"
                            let v235900 : bool = v235896.Contains v235899 
                            if v235900 then
                                let v235903 : unit = ()
                                let v235904 : (unit -> unit) = closure16(v0)
                                let v235905 : unit = (fun () -> v235904 (); v235903) ()
                                US6_1
                            else
                                let v235946 : unit = ()
                                let v235947 : (unit -> unit) = closure17(v0, v235895)
                                let v235948 : unit = (fun () -> v235947 (); v235946) ()
                                US6_1
                        | US7_0(v235893) -> (* Ok *)
                            US6_0(v235893)
                    return v236016 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v236892 : Async<US6> = _v235889 
            let _v235879 = v236892 
            #endif
#if FABLE_COMPILER_PYTHON
            let v236893 : unit = ()
            let _v236893 =
                async {
                    let! v235878 = v235878 
                    let v236896 : US7 = v235878 
                    let v237020 : US6 =
                        match v236896 with
                        | US7_1(v236899) -> (* Error *)
                            let v236900 : string = $"%A{v236899}"
                            let v236903 : string = "System.TimeoutException"
                            let v236904 : bool = v236900.Contains v236903 
                            if v236904 then
                                let v236907 : unit = ()
                                let v236908 : (unit -> unit) = closure16(v0)
                                let v236909 : unit = (fun () -> v236908 (); v236907) ()
                                US6_1
                            else
                                let v236950 : unit = ()
                                let v236951 : (unit -> unit) = closure17(v0, v236899)
                                let v236952 : unit = (fun () -> v236951 (); v236950) ()
                                US6_1
                        | US7_0(v236897) -> (* Ok *)
                            US6_0(v236897)
                    return v237020 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v237896 : Async<US6> = _v236893 
            let _v235879 = v237896 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v237897 : unit = ()
            let _v237897 =
                async {
                    let! v235878 = v235878 
                    let v237900 : US7 = v235878 
                    let v238024 : US6 =
                        match v237900 with
                        | US7_1(v237903) -> (* Error *)
                            let v237904 : string = $"%A{v237903}"
                            let v237907 : string = "System.TimeoutException"
                            let v237908 : bool = v237904.Contains v237907 
                            if v237908 then
                                let v237911 : unit = ()
                                let v237912 : (unit -> unit) = closure16(v0)
                                let v237913 : unit = (fun () -> v237912 (); v237911) ()
                                US6_1
                            else
                                let v237954 : unit = ()
                                let v237955 : (unit -> unit) = closure17(v0, v237903)
                                let v237956 : unit = (fun () -> v237955 (); v237954) ()
                                US6_1
                        | US7_0(v237901) -> (* Ok *)
                            US6_0(v237901)
                    return v238024 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v238900 : Async<US6> = _v237897 
            let _v235879 = v238900 
            #endif
#else
            let v238901 : unit = ()
            let _v238901 =
                async {
                    let! v235878 = v235878 
                    let v238904 : US7 = v235878 
                    let v239028 : US6 =
                        match v238904 with
                        | US7_1(v238907) -> (* Error *)
                            let v238908 : string = $"%A{v238907}"
                            let v238911 : string = "System.TimeoutException"
                            let v238912 : bool = v238908.Contains v238911 
                            if v238912 then
                                let v238915 : unit = ()
                                let v238916 : (unit -> unit) = closure16(v0)
                                let v238917 : unit = (fun () -> v238916 (); v238915) ()
                                US6_1
                            else
                                let v238958 : unit = ()
                                let v238959 : (unit -> unit) = closure17(v0, v238907)
                                let v238960 : unit = (fun () -> v238959 (); v238958) ()
                                US6_1
                        | US7_0(v238905) -> (* Ok *)
                            US6_0(v238905)
                    return v239028 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v239904 : Async<US6> = _v238901 
            let _v235879 = v239904 
            #endif
            let v239905 : Async<US6> = _v235879 
            return! v239905 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v272156 : Async<US6> = _v235873 
    let _v163295 = v272156 
    #endif
#else
    let v272157 : unit = ()
    let _v272157 =
        async {
            let v272160 : Async<Async<bool>> = method23(v0, v1)
            let! v272160 = v272160 
            let v272161 : Async<bool> = v272160 
            let v272162 : Async<US7> = method24(v272161)
            let v272163 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v272164 : Async<US6> = null |> unbox<Async<US6>>
            let _v272163 = v272164 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v272167 : Async<US6> = null |> unbox<Async<US6>>
            let _v272163 = v272167 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v272170 : Async<US6> = null |> unbox<Async<US6>>
            let _v272163 = v272170 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v272173 : unit = ()
            let _v272173 =
                async {
                    let! v272162 = v272162 
                    let v272176 : US7 = v272162 
                    let v272300 : US6 =
                        match v272176 with
                        | US7_1(v272179) -> (* Error *)
                            let v272180 : string = $"%A{v272179}"
                            let v272183 : string = "System.TimeoutException"
                            let v272184 : bool = v272180.Contains v272183 
                            if v272184 then
                                let v272187 : unit = ()
                                let v272188 : (unit -> unit) = closure16(v0)
                                let v272189 : unit = (fun () -> v272188 (); v272187) ()
                                US6_1
                            else
                                let v272230 : unit = ()
                                let v272231 : (unit -> unit) = closure17(v0, v272179)
                                let v272232 : unit = (fun () -> v272231 (); v272230) ()
                                US6_1
                        | US7_0(v272177) -> (* Ok *)
                            US6_0(v272177)
                    return v272300 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v273176 : Async<US6> = _v272173 
            let _v272163 = v273176 
            #endif
#if FABLE_COMPILER_PYTHON
            let v273177 : unit = ()
            let _v273177 =
                async {
                    let! v272162 = v272162 
                    let v273180 : US7 = v272162 
                    let v273304 : US6 =
                        match v273180 with
                        | US7_1(v273183) -> (* Error *)
                            let v273184 : string = $"%A{v273183}"
                            let v273187 : string = "System.TimeoutException"
                            let v273188 : bool = v273184.Contains v273187 
                            if v273188 then
                                let v273191 : unit = ()
                                let v273192 : (unit -> unit) = closure16(v0)
                                let v273193 : unit = (fun () -> v273192 (); v273191) ()
                                US6_1
                            else
                                let v273234 : unit = ()
                                let v273235 : (unit -> unit) = closure17(v0, v273183)
                                let v273236 : unit = (fun () -> v273235 (); v273234) ()
                                US6_1
                        | US7_0(v273181) -> (* Ok *)
                            US6_0(v273181)
                    return v273304 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v274180 : Async<US6> = _v273177 
            let _v272163 = v274180 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v274181 : unit = ()
            let _v274181 =
                async {
                    let! v272162 = v272162 
                    let v274184 : US7 = v272162 
                    let v274308 : US6 =
                        match v274184 with
                        | US7_1(v274187) -> (* Error *)
                            let v274188 : string = $"%A{v274187}"
                            let v274191 : string = "System.TimeoutException"
                            let v274192 : bool = v274188.Contains v274191 
                            if v274192 then
                                let v274195 : unit = ()
                                let v274196 : (unit -> unit) = closure16(v0)
                                let v274197 : unit = (fun () -> v274196 (); v274195) ()
                                US6_1
                            else
                                let v274238 : unit = ()
                                let v274239 : (unit -> unit) = closure17(v0, v274187)
                                let v274240 : unit = (fun () -> v274239 (); v274238) ()
                                US6_1
                        | US7_0(v274185) -> (* Ok *)
                            US6_0(v274185)
                    return v274308 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v275184 : Async<US6> = _v274181 
            let _v272163 = v275184 
            #endif
#else
            let v275185 : unit = ()
            let _v275185 =
                async {
                    let! v272162 = v272162 
                    let v275188 : US7 = v272162 
                    let v275312 : US6 =
                        match v275188 with
                        | US7_1(v275191) -> (* Error *)
                            let v275192 : string = $"%A{v275191}"
                            let v275195 : string = "System.TimeoutException"
                            let v275196 : bool = v275192.Contains v275195 
                            if v275196 then
                                let v275199 : unit = ()
                                let v275200 : (unit -> unit) = closure16(v0)
                                let v275201 : unit = (fun () -> v275200 (); v275199) ()
                                US6_1
                            else
                                let v275242 : unit = ()
                                let v275243 : (unit -> unit) = closure17(v0, v275191)
                                let v275244 : unit = (fun () -> v275243 (); v275242) ()
                                US6_1
                        | US7_0(v275189) -> (* Ok *)
                            US6_0(v275189)
                    return v275312 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v276188 : Async<US6> = _v275185 
            let _v272163 = v276188 
            #endif
            let v276189 : Async<US6> = _v272163 
            return! v276189 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v308440 : Async<US6> = _v272157 
    let _v163295 = v308440 
    #endif
    let v308441 : Async<US6> = _v163295 
    let _v2 = v308441 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v326587 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v326588 : Async<US6> = null |> unbox<Async<US6>>
    let _v326587 = v326588 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v326591 : Async<US6> = null |> unbox<Async<US6>>
    let _v326587 = v326591 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v326594 : Async<US6> = null |> unbox<Async<US6>>
    let _v326587 = v326594 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v326597 : unit = ()
    let _v326597 =
        async {
            let v326600 : Async<Async<bool>> = method23(v0, v1)
            let! v326600 = v326600 
            let v326601 : Async<bool> = v326600 
            let v326602 : Async<US7> = method24(v326601)
            let v326603 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v326604 : Async<US6> = null |> unbox<Async<US6>>
            let _v326603 = v326604 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v326607 : Async<US6> = null |> unbox<Async<US6>>
            let _v326603 = v326607 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v326610 : Async<US6> = null |> unbox<Async<US6>>
            let _v326603 = v326610 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v326613 : unit = ()
            let _v326613 =
                async {
                    let! v326602 = v326602 
                    let v326616 : US7 = v326602 
                    let v326740 : US6 =
                        match v326616 with
                        | US7_1(v326619) -> (* Error *)
                            let v326620 : string = $"%A{v326619}"
                            let v326623 : string = "System.TimeoutException"
                            let v326624 : bool = v326620.Contains v326623 
                            if v326624 then
                                let v326627 : unit = ()
                                let v326628 : (unit -> unit) = closure16(v0)
                                let v326629 : unit = (fun () -> v326628 (); v326627) ()
                                US6_1
                            else
                                let v326670 : unit = ()
                                let v326671 : (unit -> unit) = closure17(v0, v326619)
                                let v326672 : unit = (fun () -> v326671 (); v326670) ()
                                US6_1
                        | US7_0(v326617) -> (* Ok *)
                            US6_0(v326617)
                    return v326740 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v327616 : Async<US6> = _v326613 
            let _v326603 = v327616 
            #endif
#if FABLE_COMPILER_PYTHON
            let v327617 : unit = ()
            let _v327617 =
                async {
                    let! v326602 = v326602 
                    let v327620 : US7 = v326602 
                    let v327744 : US6 =
                        match v327620 with
                        | US7_1(v327623) -> (* Error *)
                            let v327624 : string = $"%A{v327623}"
                            let v327627 : string = "System.TimeoutException"
                            let v327628 : bool = v327624.Contains v327627 
                            if v327628 then
                                let v327631 : unit = ()
                                let v327632 : (unit -> unit) = closure16(v0)
                                let v327633 : unit = (fun () -> v327632 (); v327631) ()
                                US6_1
                            else
                                let v327674 : unit = ()
                                let v327675 : (unit -> unit) = closure17(v0, v327623)
                                let v327676 : unit = (fun () -> v327675 (); v327674) ()
                                US6_1
                        | US7_0(v327621) -> (* Ok *)
                            US6_0(v327621)
                    return v327744 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v328620 : Async<US6> = _v327617 
            let _v326603 = v328620 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v328621 : unit = ()
            let _v328621 =
                async {
                    let! v326602 = v326602 
                    let v328624 : US7 = v326602 
                    let v328748 : US6 =
                        match v328624 with
                        | US7_1(v328627) -> (* Error *)
                            let v328628 : string = $"%A{v328627}"
                            let v328631 : string = "System.TimeoutException"
                            let v328632 : bool = v328628.Contains v328631 
                            if v328632 then
                                let v328635 : unit = ()
                                let v328636 : (unit -> unit) = closure16(v0)
                                let v328637 : unit = (fun () -> v328636 (); v328635) ()
                                US6_1
                            else
                                let v328678 : unit = ()
                                let v328679 : (unit -> unit) = closure17(v0, v328627)
                                let v328680 : unit = (fun () -> v328679 (); v328678) ()
                                US6_1
                        | US7_0(v328625) -> (* Ok *)
                            US6_0(v328625)
                    return v328748 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v329624 : Async<US6> = _v328621 
            let _v326603 = v329624 
            #endif
#else
            let v329625 : unit = ()
            let _v329625 =
                async {
                    let! v326602 = v326602 
                    let v329628 : US7 = v326602 
                    let v329752 : US6 =
                        match v329628 with
                        | US7_1(v329631) -> (* Error *)
                            let v329632 : string = $"%A{v329631}"
                            let v329635 : string = "System.TimeoutException"
                            let v329636 : bool = v329632.Contains v329635 
                            if v329636 then
                                let v329639 : unit = ()
                                let v329640 : (unit -> unit) = closure16(v0)
                                let v329641 : unit = (fun () -> v329640 (); v329639) ()
                                US6_1
                            else
                                let v329682 : unit = ()
                                let v329683 : (unit -> unit) = closure17(v0, v329631)
                                let v329684 : unit = (fun () -> v329683 (); v329682) ()
                                US6_1
                        | US7_0(v329629) -> (* Ok *)
                            US6_0(v329629)
                    return v329752 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v330628 : Async<US6> = _v329625 
            let _v326603 = v330628 
            #endif
            let v330629 : Async<US6> = _v326603 
            return! v330629 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v362880 : Async<US6> = _v326597 
    let _v326587 = v362880 
    #endif
#if FABLE_COMPILER_PYTHON
    let v362881 : unit = ()
    let _v362881 =
        async {
            let v362884 : Async<Async<bool>> = method23(v0, v1)
            let! v362884 = v362884 
            let v362885 : Async<bool> = v362884 
            let v362886 : Async<US7> = method24(v362885)
            let v362887 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v362888 : Async<US6> = null |> unbox<Async<US6>>
            let _v362887 = v362888 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v362891 : Async<US6> = null |> unbox<Async<US6>>
            let _v362887 = v362891 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v362894 : Async<US6> = null |> unbox<Async<US6>>
            let _v362887 = v362894 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v362897 : unit = ()
            let _v362897 =
                async {
                    let! v362886 = v362886 
                    let v362900 : US7 = v362886 
                    let v363024 : US6 =
                        match v362900 with
                        | US7_1(v362903) -> (* Error *)
                            let v362904 : string = $"%A{v362903}"
                            let v362907 : string = "System.TimeoutException"
                            let v362908 : bool = v362904.Contains v362907 
                            if v362908 then
                                let v362911 : unit = ()
                                let v362912 : (unit -> unit) = closure16(v0)
                                let v362913 : unit = (fun () -> v362912 (); v362911) ()
                                US6_1
                            else
                                let v362954 : unit = ()
                                let v362955 : (unit -> unit) = closure17(v0, v362903)
                                let v362956 : unit = (fun () -> v362955 (); v362954) ()
                                US6_1
                        | US7_0(v362901) -> (* Ok *)
                            US6_0(v362901)
                    return v363024 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v363900 : Async<US6> = _v362897 
            let _v362887 = v363900 
            #endif
#if FABLE_COMPILER_PYTHON
            let v363901 : unit = ()
            let _v363901 =
                async {
                    let! v362886 = v362886 
                    let v363904 : US7 = v362886 
                    let v364028 : US6 =
                        match v363904 with
                        | US7_1(v363907) -> (* Error *)
                            let v363908 : string = $"%A{v363907}"
                            let v363911 : string = "System.TimeoutException"
                            let v363912 : bool = v363908.Contains v363911 
                            if v363912 then
                                let v363915 : unit = ()
                                let v363916 : (unit -> unit) = closure16(v0)
                                let v363917 : unit = (fun () -> v363916 (); v363915) ()
                                US6_1
                            else
                                let v363958 : unit = ()
                                let v363959 : (unit -> unit) = closure17(v0, v363907)
                                let v363960 : unit = (fun () -> v363959 (); v363958) ()
                                US6_1
                        | US7_0(v363905) -> (* Ok *)
                            US6_0(v363905)
                    return v364028 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v364904 : Async<US6> = _v363901 
            let _v362887 = v364904 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v364905 : unit = ()
            let _v364905 =
                async {
                    let! v362886 = v362886 
                    let v364908 : US7 = v362886 
                    let v365032 : US6 =
                        match v364908 with
                        | US7_1(v364911) -> (* Error *)
                            let v364912 : string = $"%A{v364911}"
                            let v364915 : string = "System.TimeoutException"
                            let v364916 : bool = v364912.Contains v364915 
                            if v364916 then
                                let v364919 : unit = ()
                                let v364920 : (unit -> unit) = closure16(v0)
                                let v364921 : unit = (fun () -> v364920 (); v364919) ()
                                US6_1
                            else
                                let v364962 : unit = ()
                                let v364963 : (unit -> unit) = closure17(v0, v364911)
                                let v364964 : unit = (fun () -> v364963 (); v364962) ()
                                US6_1
                        | US7_0(v364909) -> (* Ok *)
                            US6_0(v364909)
                    return v365032 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v365908 : Async<US6> = _v364905 
            let _v362887 = v365908 
            #endif
#else
            let v365909 : unit = ()
            let _v365909 =
                async {
                    let! v362886 = v362886 
                    let v365912 : US7 = v362886 
                    let v366036 : US6 =
                        match v365912 with
                        | US7_1(v365915) -> (* Error *)
                            let v365916 : string = $"%A{v365915}"
                            let v365919 : string = "System.TimeoutException"
                            let v365920 : bool = v365916.Contains v365919 
                            if v365920 then
                                let v365923 : unit = ()
                                let v365924 : (unit -> unit) = closure16(v0)
                                let v365925 : unit = (fun () -> v365924 (); v365923) ()
                                US6_1
                            else
                                let v365966 : unit = ()
                                let v365967 : (unit -> unit) = closure17(v0, v365915)
                                let v365968 : unit = (fun () -> v365967 (); v365966) ()
                                US6_1
                        | US7_0(v365913) -> (* Ok *)
                            US6_0(v365913)
                    return v366036 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v366912 : Async<US6> = _v365909 
            let _v362887 = v366912 
            #endif
            let v366913 : Async<US6> = _v362887 
            return! v366913 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v399164 : Async<US6> = _v362881 
    let _v326587 = v399164 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v399165 : unit = ()
    let _v399165 =
        async {
            let v399168 : Async<Async<bool>> = method23(v0, v1)
            let! v399168 = v399168 
            let v399169 : Async<bool> = v399168 
            let v399170 : Async<US7> = method24(v399169)
            let v399171 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v399172 : Async<US6> = null |> unbox<Async<US6>>
            let _v399171 = v399172 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v399175 : Async<US6> = null |> unbox<Async<US6>>
            let _v399171 = v399175 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v399178 : Async<US6> = null |> unbox<Async<US6>>
            let _v399171 = v399178 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v399181 : unit = ()
            let _v399181 =
                async {
                    let! v399170 = v399170 
                    let v399184 : US7 = v399170 
                    let v399308 : US6 =
                        match v399184 with
                        | US7_1(v399187) -> (* Error *)
                            let v399188 : string = $"%A{v399187}"
                            let v399191 : string = "System.TimeoutException"
                            let v399192 : bool = v399188.Contains v399191 
                            if v399192 then
                                let v399195 : unit = ()
                                let v399196 : (unit -> unit) = closure16(v0)
                                let v399197 : unit = (fun () -> v399196 (); v399195) ()
                                US6_1
                            else
                                let v399238 : unit = ()
                                let v399239 : (unit -> unit) = closure17(v0, v399187)
                                let v399240 : unit = (fun () -> v399239 (); v399238) ()
                                US6_1
                        | US7_0(v399185) -> (* Ok *)
                            US6_0(v399185)
                    return v399308 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v400184 : Async<US6> = _v399181 
            let _v399171 = v400184 
            #endif
#if FABLE_COMPILER_PYTHON
            let v400185 : unit = ()
            let _v400185 =
                async {
                    let! v399170 = v399170 
                    let v400188 : US7 = v399170 
                    let v400312 : US6 =
                        match v400188 with
                        | US7_1(v400191) -> (* Error *)
                            let v400192 : string = $"%A{v400191}"
                            let v400195 : string = "System.TimeoutException"
                            let v400196 : bool = v400192.Contains v400195 
                            if v400196 then
                                let v400199 : unit = ()
                                let v400200 : (unit -> unit) = closure16(v0)
                                let v400201 : unit = (fun () -> v400200 (); v400199) ()
                                US6_1
                            else
                                let v400242 : unit = ()
                                let v400243 : (unit -> unit) = closure17(v0, v400191)
                                let v400244 : unit = (fun () -> v400243 (); v400242) ()
                                US6_1
                        | US7_0(v400189) -> (* Ok *)
                            US6_0(v400189)
                    return v400312 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v401188 : Async<US6> = _v400185 
            let _v399171 = v401188 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v401189 : unit = ()
            let _v401189 =
                async {
                    let! v399170 = v399170 
                    let v401192 : US7 = v399170 
                    let v401316 : US6 =
                        match v401192 with
                        | US7_1(v401195) -> (* Error *)
                            let v401196 : string = $"%A{v401195}"
                            let v401199 : string = "System.TimeoutException"
                            let v401200 : bool = v401196.Contains v401199 
                            if v401200 then
                                let v401203 : unit = ()
                                let v401204 : (unit -> unit) = closure16(v0)
                                let v401205 : unit = (fun () -> v401204 (); v401203) ()
                                US6_1
                            else
                                let v401246 : unit = ()
                                let v401247 : (unit -> unit) = closure17(v0, v401195)
                                let v401248 : unit = (fun () -> v401247 (); v401246) ()
                                US6_1
                        | US7_0(v401193) -> (* Ok *)
                            US6_0(v401193)
                    return v401316 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v402192 : Async<US6> = _v401189 
            let _v399171 = v402192 
            #endif
#else
            let v402193 : unit = ()
            let _v402193 =
                async {
                    let! v399170 = v399170 
                    let v402196 : US7 = v399170 
                    let v402320 : US6 =
                        match v402196 with
                        | US7_1(v402199) -> (* Error *)
                            let v402200 : string = $"%A{v402199}"
                            let v402203 : string = "System.TimeoutException"
                            let v402204 : bool = v402200.Contains v402203 
                            if v402204 then
                                let v402207 : unit = ()
                                let v402208 : (unit -> unit) = closure16(v0)
                                let v402209 : unit = (fun () -> v402208 (); v402207) ()
                                US6_1
                            else
                                let v402250 : unit = ()
                                let v402251 : (unit -> unit) = closure17(v0, v402199)
                                let v402252 : unit = (fun () -> v402251 (); v402250) ()
                                US6_1
                        | US7_0(v402197) -> (* Ok *)
                            US6_0(v402197)
                    return v402320 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v403196 : Async<US6> = _v402193 
            let _v399171 = v403196 
            #endif
            let v403197 : Async<US6> = _v399171 
            return! v403197 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v435448 : Async<US6> = _v399165 
    let _v326587 = v435448 
    #endif
#else
    let v435449 : unit = ()
    let _v435449 =
        async {
            let v435452 : Async<Async<bool>> = method23(v0, v1)
            let! v435452 = v435452 
            let v435453 : Async<bool> = v435452 
            let v435454 : Async<US7> = method24(v435453)
            let v435455 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v435456 : Async<US6> = null |> unbox<Async<US6>>
            let _v435455 = v435456 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v435459 : Async<US6> = null |> unbox<Async<US6>>
            let _v435455 = v435459 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v435462 : Async<US6> = null |> unbox<Async<US6>>
            let _v435455 = v435462 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v435465 : unit = ()
            let _v435465 =
                async {
                    let! v435454 = v435454 
                    let v435468 : US7 = v435454 
                    let v435592 : US6 =
                        match v435468 with
                        | US7_1(v435471) -> (* Error *)
                            let v435472 : string = $"%A{v435471}"
                            let v435475 : string = "System.TimeoutException"
                            let v435476 : bool = v435472.Contains v435475 
                            if v435476 then
                                let v435479 : unit = ()
                                let v435480 : (unit -> unit) = closure16(v0)
                                let v435481 : unit = (fun () -> v435480 (); v435479) ()
                                US6_1
                            else
                                let v435522 : unit = ()
                                let v435523 : (unit -> unit) = closure17(v0, v435471)
                                let v435524 : unit = (fun () -> v435523 (); v435522) ()
                                US6_1
                        | US7_0(v435469) -> (* Ok *)
                            US6_0(v435469)
                    return v435592 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v436468 : Async<US6> = _v435465 
            let _v435455 = v436468 
            #endif
#if FABLE_COMPILER_PYTHON
            let v436469 : unit = ()
            let _v436469 =
                async {
                    let! v435454 = v435454 
                    let v436472 : US7 = v435454 
                    let v436596 : US6 =
                        match v436472 with
                        | US7_1(v436475) -> (* Error *)
                            let v436476 : string = $"%A{v436475}"
                            let v436479 : string = "System.TimeoutException"
                            let v436480 : bool = v436476.Contains v436479 
                            if v436480 then
                                let v436483 : unit = ()
                                let v436484 : (unit -> unit) = closure16(v0)
                                let v436485 : unit = (fun () -> v436484 (); v436483) ()
                                US6_1
                            else
                                let v436526 : unit = ()
                                let v436527 : (unit -> unit) = closure17(v0, v436475)
                                let v436528 : unit = (fun () -> v436527 (); v436526) ()
                                US6_1
                        | US7_0(v436473) -> (* Ok *)
                            US6_0(v436473)
                    return v436596 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v437472 : Async<US6> = _v436469 
            let _v435455 = v437472 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v437473 : unit = ()
            let _v437473 =
                async {
                    let! v435454 = v435454 
                    let v437476 : US7 = v435454 
                    let v437600 : US6 =
                        match v437476 with
                        | US7_1(v437479) -> (* Error *)
                            let v437480 : string = $"%A{v437479}"
                            let v437483 : string = "System.TimeoutException"
                            let v437484 : bool = v437480.Contains v437483 
                            if v437484 then
                                let v437487 : unit = ()
                                let v437488 : (unit -> unit) = closure16(v0)
                                let v437489 : unit = (fun () -> v437488 (); v437487) ()
                                US6_1
                            else
                                let v437530 : unit = ()
                                let v437531 : (unit -> unit) = closure17(v0, v437479)
                                let v437532 : unit = (fun () -> v437531 (); v437530) ()
                                US6_1
                        | US7_0(v437477) -> (* Ok *)
                            US6_0(v437477)
                    return v437600 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v438476 : Async<US6> = _v437473 
            let _v435455 = v438476 
            #endif
#else
            let v438477 : unit = ()
            let _v438477 =
                async {
                    let! v435454 = v435454 
                    let v438480 : US7 = v435454 
                    let v438604 : US6 =
                        match v438480 with
                        | US7_1(v438483) -> (* Error *)
                            let v438484 : string = $"%A{v438483}"
                            let v438487 : string = "System.TimeoutException"
                            let v438488 : bool = v438484.Contains v438487 
                            if v438488 then
                                let v438491 : unit = ()
                                let v438492 : (unit -> unit) = closure16(v0)
                                let v438493 : unit = (fun () -> v438492 (); v438491) ()
                                US6_1
                            else
                                let v438534 : unit = ()
                                let v438535 : (unit -> unit) = closure17(v0, v438483)
                                let v438536 : unit = (fun () -> v438535 (); v438534) ()
                                US6_1
                        | US7_0(v438481) -> (* Ok *)
                            US6_0(v438481)
                    return v438604 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v439480 : Async<US6> = _v438477 
            let _v435455 = v439480 
            #endif
            let v439481 : Async<US6> = _v435455 
            return! v439481 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v471732 : Async<US6> = _v435449 
    let _v326587 = v471732 
    #endif
    let v471733 : Async<US6> = _v326587 
    let _v2 = v471733 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v489879 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v489880 : Async<US6> = null |> unbox<Async<US6>>
    let _v489879 = v489880 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v489883 : Async<US6> = null |> unbox<Async<US6>>
    let _v489879 = v489883 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v489886 : Async<US6> = null |> unbox<Async<US6>>
    let _v489879 = v489886 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v489889 : unit = ()
    let _v489889 =
        async {
            let v489892 : Async<Async<bool>> = method23(v0, v1)
            let! v489892 = v489892 
            let v489893 : Async<bool> = v489892 
            let v489894 : Async<US7> = method24(v489893)
            let v489895 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v489896 : Async<US6> = null |> unbox<Async<US6>>
            let _v489895 = v489896 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v489899 : Async<US6> = null |> unbox<Async<US6>>
            let _v489895 = v489899 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v489902 : Async<US6> = null |> unbox<Async<US6>>
            let _v489895 = v489902 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v489905 : unit = ()
            let _v489905 =
                async {
                    let! v489894 = v489894 
                    let v489908 : US7 = v489894 
                    let v490032 : US6 =
                        match v489908 with
                        | US7_1(v489911) -> (* Error *)
                            let v489912 : string = $"%A{v489911}"
                            let v489915 : string = "System.TimeoutException"
                            let v489916 : bool = v489912.Contains v489915 
                            if v489916 then
                                let v489919 : unit = ()
                                let v489920 : (unit -> unit) = closure16(v0)
                                let v489921 : unit = (fun () -> v489920 (); v489919) ()
                                US6_1
                            else
                                let v489962 : unit = ()
                                let v489963 : (unit -> unit) = closure17(v0, v489911)
                                let v489964 : unit = (fun () -> v489963 (); v489962) ()
                                US6_1
                        | US7_0(v489909) -> (* Ok *)
                            US6_0(v489909)
                    return v490032 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v490908 : Async<US6> = _v489905 
            let _v489895 = v490908 
            #endif
#if FABLE_COMPILER_PYTHON
            let v490909 : unit = ()
            let _v490909 =
                async {
                    let! v489894 = v489894 
                    let v490912 : US7 = v489894 
                    let v491036 : US6 =
                        match v490912 with
                        | US7_1(v490915) -> (* Error *)
                            let v490916 : string = $"%A{v490915}"
                            let v490919 : string = "System.TimeoutException"
                            let v490920 : bool = v490916.Contains v490919 
                            if v490920 then
                                let v490923 : unit = ()
                                let v490924 : (unit -> unit) = closure16(v0)
                                let v490925 : unit = (fun () -> v490924 (); v490923) ()
                                US6_1
                            else
                                let v490966 : unit = ()
                                let v490967 : (unit -> unit) = closure17(v0, v490915)
                                let v490968 : unit = (fun () -> v490967 (); v490966) ()
                                US6_1
                        | US7_0(v490913) -> (* Ok *)
                            US6_0(v490913)
                    return v491036 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v491912 : Async<US6> = _v490909 
            let _v489895 = v491912 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v491913 : unit = ()
            let _v491913 =
                async {
                    let! v489894 = v489894 
                    let v491916 : US7 = v489894 
                    let v492040 : US6 =
                        match v491916 with
                        | US7_1(v491919) -> (* Error *)
                            let v491920 : string = $"%A{v491919}"
                            let v491923 : string = "System.TimeoutException"
                            let v491924 : bool = v491920.Contains v491923 
                            if v491924 then
                                let v491927 : unit = ()
                                let v491928 : (unit -> unit) = closure16(v0)
                                let v491929 : unit = (fun () -> v491928 (); v491927) ()
                                US6_1
                            else
                                let v491970 : unit = ()
                                let v491971 : (unit -> unit) = closure17(v0, v491919)
                                let v491972 : unit = (fun () -> v491971 (); v491970) ()
                                US6_1
                        | US7_0(v491917) -> (* Ok *)
                            US6_0(v491917)
                    return v492040 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v492916 : Async<US6> = _v491913 
            let _v489895 = v492916 
            #endif
#else
            let v492917 : unit = ()
            let _v492917 =
                async {
                    let! v489894 = v489894 
                    let v492920 : US7 = v489894 
                    let v493044 : US6 =
                        match v492920 with
                        | US7_1(v492923) -> (* Error *)
                            let v492924 : string = $"%A{v492923}"
                            let v492927 : string = "System.TimeoutException"
                            let v492928 : bool = v492924.Contains v492927 
                            if v492928 then
                                let v492931 : unit = ()
                                let v492932 : (unit -> unit) = closure16(v0)
                                let v492933 : unit = (fun () -> v492932 (); v492931) ()
                                US6_1
                            else
                                let v492974 : unit = ()
                                let v492975 : (unit -> unit) = closure17(v0, v492923)
                                let v492976 : unit = (fun () -> v492975 (); v492974) ()
                                US6_1
                        | US7_0(v492921) -> (* Ok *)
                            US6_0(v492921)
                    return v493044 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v493920 : Async<US6> = _v492917 
            let _v489895 = v493920 
            #endif
            let v493921 : Async<US6> = _v489895 
            return! v493921 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v526172 : Async<US6> = _v489889 
    let _v489879 = v526172 
    #endif
#if FABLE_COMPILER_PYTHON
    let v526173 : unit = ()
    let _v526173 =
        async {
            let v526176 : Async<Async<bool>> = method23(v0, v1)
            let! v526176 = v526176 
            let v526177 : Async<bool> = v526176 
            let v526178 : Async<US7> = method24(v526177)
            let v526179 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v526180 : Async<US6> = null |> unbox<Async<US6>>
            let _v526179 = v526180 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v526183 : Async<US6> = null |> unbox<Async<US6>>
            let _v526179 = v526183 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v526186 : Async<US6> = null |> unbox<Async<US6>>
            let _v526179 = v526186 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v526189 : unit = ()
            let _v526189 =
                async {
                    let! v526178 = v526178 
                    let v526192 : US7 = v526178 
                    let v526316 : US6 =
                        match v526192 with
                        | US7_1(v526195) -> (* Error *)
                            let v526196 : string = $"%A{v526195}"
                            let v526199 : string = "System.TimeoutException"
                            let v526200 : bool = v526196.Contains v526199 
                            if v526200 then
                                let v526203 : unit = ()
                                let v526204 : (unit -> unit) = closure16(v0)
                                let v526205 : unit = (fun () -> v526204 (); v526203) ()
                                US6_1
                            else
                                let v526246 : unit = ()
                                let v526247 : (unit -> unit) = closure17(v0, v526195)
                                let v526248 : unit = (fun () -> v526247 (); v526246) ()
                                US6_1
                        | US7_0(v526193) -> (* Ok *)
                            US6_0(v526193)
                    return v526316 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v527192 : Async<US6> = _v526189 
            let _v526179 = v527192 
            #endif
#if FABLE_COMPILER_PYTHON
            let v527193 : unit = ()
            let _v527193 =
                async {
                    let! v526178 = v526178 
                    let v527196 : US7 = v526178 
                    let v527320 : US6 =
                        match v527196 with
                        | US7_1(v527199) -> (* Error *)
                            let v527200 : string = $"%A{v527199}"
                            let v527203 : string = "System.TimeoutException"
                            let v527204 : bool = v527200.Contains v527203 
                            if v527204 then
                                let v527207 : unit = ()
                                let v527208 : (unit -> unit) = closure16(v0)
                                let v527209 : unit = (fun () -> v527208 (); v527207) ()
                                US6_1
                            else
                                let v527250 : unit = ()
                                let v527251 : (unit -> unit) = closure17(v0, v527199)
                                let v527252 : unit = (fun () -> v527251 (); v527250) ()
                                US6_1
                        | US7_0(v527197) -> (* Ok *)
                            US6_0(v527197)
                    return v527320 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v528196 : Async<US6> = _v527193 
            let _v526179 = v528196 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v528197 : unit = ()
            let _v528197 =
                async {
                    let! v526178 = v526178 
                    let v528200 : US7 = v526178 
                    let v528324 : US6 =
                        match v528200 with
                        | US7_1(v528203) -> (* Error *)
                            let v528204 : string = $"%A{v528203}"
                            let v528207 : string = "System.TimeoutException"
                            let v528208 : bool = v528204.Contains v528207 
                            if v528208 then
                                let v528211 : unit = ()
                                let v528212 : (unit -> unit) = closure16(v0)
                                let v528213 : unit = (fun () -> v528212 (); v528211) ()
                                US6_1
                            else
                                let v528254 : unit = ()
                                let v528255 : (unit -> unit) = closure17(v0, v528203)
                                let v528256 : unit = (fun () -> v528255 (); v528254) ()
                                US6_1
                        | US7_0(v528201) -> (* Ok *)
                            US6_0(v528201)
                    return v528324 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v529200 : Async<US6> = _v528197 
            let _v526179 = v529200 
            #endif
#else
            let v529201 : unit = ()
            let _v529201 =
                async {
                    let! v526178 = v526178 
                    let v529204 : US7 = v526178 
                    let v529328 : US6 =
                        match v529204 with
                        | US7_1(v529207) -> (* Error *)
                            let v529208 : string = $"%A{v529207}"
                            let v529211 : string = "System.TimeoutException"
                            let v529212 : bool = v529208.Contains v529211 
                            if v529212 then
                                let v529215 : unit = ()
                                let v529216 : (unit -> unit) = closure16(v0)
                                let v529217 : unit = (fun () -> v529216 (); v529215) ()
                                US6_1
                            else
                                let v529258 : unit = ()
                                let v529259 : (unit -> unit) = closure17(v0, v529207)
                                let v529260 : unit = (fun () -> v529259 (); v529258) ()
                                US6_1
                        | US7_0(v529205) -> (* Ok *)
                            US6_0(v529205)
                    return v529328 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v530204 : Async<US6> = _v529201 
            let _v526179 = v530204 
            #endif
            let v530205 : Async<US6> = _v526179 
            return! v530205 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v562456 : Async<US6> = _v526173 
    let _v489879 = v562456 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v562457 : unit = ()
    let _v562457 =
        async {
            let v562460 : Async<Async<bool>> = method23(v0, v1)
            let! v562460 = v562460 
            let v562461 : Async<bool> = v562460 
            let v562462 : Async<US7> = method24(v562461)
            let v562463 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v562464 : Async<US6> = null |> unbox<Async<US6>>
            let _v562463 = v562464 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v562467 : Async<US6> = null |> unbox<Async<US6>>
            let _v562463 = v562467 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v562470 : Async<US6> = null |> unbox<Async<US6>>
            let _v562463 = v562470 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v562473 : unit = ()
            let _v562473 =
                async {
                    let! v562462 = v562462 
                    let v562476 : US7 = v562462 
                    let v562600 : US6 =
                        match v562476 with
                        | US7_1(v562479) -> (* Error *)
                            let v562480 : string = $"%A{v562479}"
                            let v562483 : string = "System.TimeoutException"
                            let v562484 : bool = v562480.Contains v562483 
                            if v562484 then
                                let v562487 : unit = ()
                                let v562488 : (unit -> unit) = closure16(v0)
                                let v562489 : unit = (fun () -> v562488 (); v562487) ()
                                US6_1
                            else
                                let v562530 : unit = ()
                                let v562531 : (unit -> unit) = closure17(v0, v562479)
                                let v562532 : unit = (fun () -> v562531 (); v562530) ()
                                US6_1
                        | US7_0(v562477) -> (* Ok *)
                            US6_0(v562477)
                    return v562600 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v563476 : Async<US6> = _v562473 
            let _v562463 = v563476 
            #endif
#if FABLE_COMPILER_PYTHON
            let v563477 : unit = ()
            let _v563477 =
                async {
                    let! v562462 = v562462 
                    let v563480 : US7 = v562462 
                    let v563604 : US6 =
                        match v563480 with
                        | US7_1(v563483) -> (* Error *)
                            let v563484 : string = $"%A{v563483}"
                            let v563487 : string = "System.TimeoutException"
                            let v563488 : bool = v563484.Contains v563487 
                            if v563488 then
                                let v563491 : unit = ()
                                let v563492 : (unit -> unit) = closure16(v0)
                                let v563493 : unit = (fun () -> v563492 (); v563491) ()
                                US6_1
                            else
                                let v563534 : unit = ()
                                let v563535 : (unit -> unit) = closure17(v0, v563483)
                                let v563536 : unit = (fun () -> v563535 (); v563534) ()
                                US6_1
                        | US7_0(v563481) -> (* Ok *)
                            US6_0(v563481)
                    return v563604 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v564480 : Async<US6> = _v563477 
            let _v562463 = v564480 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v564481 : unit = ()
            let _v564481 =
                async {
                    let! v562462 = v562462 
                    let v564484 : US7 = v562462 
                    let v564608 : US6 =
                        match v564484 with
                        | US7_1(v564487) -> (* Error *)
                            let v564488 : string = $"%A{v564487}"
                            let v564491 : string = "System.TimeoutException"
                            let v564492 : bool = v564488.Contains v564491 
                            if v564492 then
                                let v564495 : unit = ()
                                let v564496 : (unit -> unit) = closure16(v0)
                                let v564497 : unit = (fun () -> v564496 (); v564495) ()
                                US6_1
                            else
                                let v564538 : unit = ()
                                let v564539 : (unit -> unit) = closure17(v0, v564487)
                                let v564540 : unit = (fun () -> v564539 (); v564538) ()
                                US6_1
                        | US7_0(v564485) -> (* Ok *)
                            US6_0(v564485)
                    return v564608 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v565484 : Async<US6> = _v564481 
            let _v562463 = v565484 
            #endif
#else
            let v565485 : unit = ()
            let _v565485 =
                async {
                    let! v562462 = v562462 
                    let v565488 : US7 = v562462 
                    let v565612 : US6 =
                        match v565488 with
                        | US7_1(v565491) -> (* Error *)
                            let v565492 : string = $"%A{v565491}"
                            let v565495 : string = "System.TimeoutException"
                            let v565496 : bool = v565492.Contains v565495 
                            if v565496 then
                                let v565499 : unit = ()
                                let v565500 : (unit -> unit) = closure16(v0)
                                let v565501 : unit = (fun () -> v565500 (); v565499) ()
                                US6_1
                            else
                                let v565542 : unit = ()
                                let v565543 : (unit -> unit) = closure17(v0, v565491)
                                let v565544 : unit = (fun () -> v565543 (); v565542) ()
                                US6_1
                        | US7_0(v565489) -> (* Ok *)
                            US6_0(v565489)
                    return v565612 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v566488 : Async<US6> = _v565485 
            let _v562463 = v566488 
            #endif
            let v566489 : Async<US6> = _v562463 
            return! v566489 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v598740 : Async<US6> = _v562457 
    let _v489879 = v598740 
    #endif
#else
    let v598741 : unit = ()
    let _v598741 =
        async {
            let v598744 : Async<Async<bool>> = method23(v0, v1)
            let! v598744 = v598744 
            let v598745 : Async<bool> = v598744 
            let v598746 : Async<US7> = method24(v598745)
            let v598747 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v598748 : Async<US6> = null |> unbox<Async<US6>>
            let _v598747 = v598748 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v598751 : Async<US6> = null |> unbox<Async<US6>>
            let _v598747 = v598751 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v598754 : Async<US6> = null |> unbox<Async<US6>>
            let _v598747 = v598754 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v598757 : unit = ()
            let _v598757 =
                async {
                    let! v598746 = v598746 
                    let v598760 : US7 = v598746 
                    let v598884 : US6 =
                        match v598760 with
                        | US7_1(v598763) -> (* Error *)
                            let v598764 : string = $"%A{v598763}"
                            let v598767 : string = "System.TimeoutException"
                            let v598768 : bool = v598764.Contains v598767 
                            if v598768 then
                                let v598771 : unit = ()
                                let v598772 : (unit -> unit) = closure16(v0)
                                let v598773 : unit = (fun () -> v598772 (); v598771) ()
                                US6_1
                            else
                                let v598814 : unit = ()
                                let v598815 : (unit -> unit) = closure17(v0, v598763)
                                let v598816 : unit = (fun () -> v598815 (); v598814) ()
                                US6_1
                        | US7_0(v598761) -> (* Ok *)
                            US6_0(v598761)
                    return v598884 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v599760 : Async<US6> = _v598757 
            let _v598747 = v599760 
            #endif
#if FABLE_COMPILER_PYTHON
            let v599761 : unit = ()
            let _v599761 =
                async {
                    let! v598746 = v598746 
                    let v599764 : US7 = v598746 
                    let v599888 : US6 =
                        match v599764 with
                        | US7_1(v599767) -> (* Error *)
                            let v599768 : string = $"%A{v599767}"
                            let v599771 : string = "System.TimeoutException"
                            let v599772 : bool = v599768.Contains v599771 
                            if v599772 then
                                let v599775 : unit = ()
                                let v599776 : (unit -> unit) = closure16(v0)
                                let v599777 : unit = (fun () -> v599776 (); v599775) ()
                                US6_1
                            else
                                let v599818 : unit = ()
                                let v599819 : (unit -> unit) = closure17(v0, v599767)
                                let v599820 : unit = (fun () -> v599819 (); v599818) ()
                                US6_1
                        | US7_0(v599765) -> (* Ok *)
                            US6_0(v599765)
                    return v599888 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v600764 : Async<US6> = _v599761 
            let _v598747 = v600764 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v600765 : unit = ()
            let _v600765 =
                async {
                    let! v598746 = v598746 
                    let v600768 : US7 = v598746 
                    let v600892 : US6 =
                        match v600768 with
                        | US7_1(v600771) -> (* Error *)
                            let v600772 : string = $"%A{v600771}"
                            let v600775 : string = "System.TimeoutException"
                            let v600776 : bool = v600772.Contains v600775 
                            if v600776 then
                                let v600779 : unit = ()
                                let v600780 : (unit -> unit) = closure16(v0)
                                let v600781 : unit = (fun () -> v600780 (); v600779) ()
                                US6_1
                            else
                                let v600822 : unit = ()
                                let v600823 : (unit -> unit) = closure17(v0, v600771)
                                let v600824 : unit = (fun () -> v600823 (); v600822) ()
                                US6_1
                        | US7_0(v600769) -> (* Ok *)
                            US6_0(v600769)
                    return v600892 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v601768 : Async<US6> = _v600765 
            let _v598747 = v601768 
            #endif
#else
            let v601769 : unit = ()
            let _v601769 =
                async {
                    let! v598746 = v598746 
                    let v601772 : US7 = v598746 
                    let v601896 : US6 =
                        match v601772 with
                        | US7_1(v601775) -> (* Error *)
                            let v601776 : string = $"%A{v601775}"
                            let v601779 : string = "System.TimeoutException"
                            let v601780 : bool = v601776.Contains v601779 
                            if v601780 then
                                let v601783 : unit = ()
                                let v601784 : (unit -> unit) = closure16(v0)
                                let v601785 : unit = (fun () -> v601784 (); v601783) ()
                                US6_1
                            else
                                let v601826 : unit = ()
                                let v601827 : (unit -> unit) = closure17(v0, v601775)
                                let v601828 : unit = (fun () -> v601827 (); v601826) ()
                                US6_1
                        | US7_0(v601773) -> (* Ok *)
                            US6_0(v601773)
                    return v601896 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v602772 : Async<US6> = _v601769 
            let _v598747 = v602772 
            #endif
            let v602773 : Async<US6> = _v598747 
            return! v602773 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v635024 : Async<US6> = _v598741 
    let _v489879 = v635024 
    #endif
    let v635025 : Async<US6> = _v489879 
    let _v2 = v635025 
    #endif
#if FABLE_COMPILER_PYTHON
    let v653171 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v653172 : Async<US6> = null |> unbox<Async<US6>>
    let _v653171 = v653172 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v653175 : Async<US6> = null |> unbox<Async<US6>>
    let _v653171 = v653175 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v653178 : Async<US6> = null |> unbox<Async<US6>>
    let _v653171 = v653178 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v653181 : unit = ()
    let _v653181 =
        async {
            let v653184 : Async<Async<bool>> = method23(v0, v1)
            let! v653184 = v653184 
            let v653185 : Async<bool> = v653184 
            let v653186 : Async<US7> = method24(v653185)
            let v653187 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v653188 : Async<US6> = null |> unbox<Async<US6>>
            let _v653187 = v653188 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v653191 : Async<US6> = null |> unbox<Async<US6>>
            let _v653187 = v653191 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v653194 : Async<US6> = null |> unbox<Async<US6>>
            let _v653187 = v653194 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v653197 : unit = ()
            let _v653197 =
                async {
                    let! v653186 = v653186 
                    let v653200 : US7 = v653186 
                    let v653324 : US6 =
                        match v653200 with
                        | US7_1(v653203) -> (* Error *)
                            let v653204 : string = $"%A{v653203}"
                            let v653207 : string = "System.TimeoutException"
                            let v653208 : bool = v653204.Contains v653207 
                            if v653208 then
                                let v653211 : unit = ()
                                let v653212 : (unit -> unit) = closure16(v0)
                                let v653213 : unit = (fun () -> v653212 (); v653211) ()
                                US6_1
                            else
                                let v653254 : unit = ()
                                let v653255 : (unit -> unit) = closure17(v0, v653203)
                                let v653256 : unit = (fun () -> v653255 (); v653254) ()
                                US6_1
                        | US7_0(v653201) -> (* Ok *)
                            US6_0(v653201)
                    return v653324 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v654200 : Async<US6> = _v653197 
            let _v653187 = v654200 
            #endif
#if FABLE_COMPILER_PYTHON
            let v654201 : unit = ()
            let _v654201 =
                async {
                    let! v653186 = v653186 
                    let v654204 : US7 = v653186 
                    let v654328 : US6 =
                        match v654204 with
                        | US7_1(v654207) -> (* Error *)
                            let v654208 : string = $"%A{v654207}"
                            let v654211 : string = "System.TimeoutException"
                            let v654212 : bool = v654208.Contains v654211 
                            if v654212 then
                                let v654215 : unit = ()
                                let v654216 : (unit -> unit) = closure16(v0)
                                let v654217 : unit = (fun () -> v654216 (); v654215) ()
                                US6_1
                            else
                                let v654258 : unit = ()
                                let v654259 : (unit -> unit) = closure17(v0, v654207)
                                let v654260 : unit = (fun () -> v654259 (); v654258) ()
                                US6_1
                        | US7_0(v654205) -> (* Ok *)
                            US6_0(v654205)
                    return v654328 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v655204 : Async<US6> = _v654201 
            let _v653187 = v655204 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v655205 : unit = ()
            let _v655205 =
                async {
                    let! v653186 = v653186 
                    let v655208 : US7 = v653186 
                    let v655332 : US6 =
                        match v655208 with
                        | US7_1(v655211) -> (* Error *)
                            let v655212 : string = $"%A{v655211}"
                            let v655215 : string = "System.TimeoutException"
                            let v655216 : bool = v655212.Contains v655215 
                            if v655216 then
                                let v655219 : unit = ()
                                let v655220 : (unit -> unit) = closure16(v0)
                                let v655221 : unit = (fun () -> v655220 (); v655219) ()
                                US6_1
                            else
                                let v655262 : unit = ()
                                let v655263 : (unit -> unit) = closure17(v0, v655211)
                                let v655264 : unit = (fun () -> v655263 (); v655262) ()
                                US6_1
                        | US7_0(v655209) -> (* Ok *)
                            US6_0(v655209)
                    return v655332 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v656208 : Async<US6> = _v655205 
            let _v653187 = v656208 
            #endif
#else
            let v656209 : unit = ()
            let _v656209 =
                async {
                    let! v653186 = v653186 
                    let v656212 : US7 = v653186 
                    let v656336 : US6 =
                        match v656212 with
                        | US7_1(v656215) -> (* Error *)
                            let v656216 : string = $"%A{v656215}"
                            let v656219 : string = "System.TimeoutException"
                            let v656220 : bool = v656216.Contains v656219 
                            if v656220 then
                                let v656223 : unit = ()
                                let v656224 : (unit -> unit) = closure16(v0)
                                let v656225 : unit = (fun () -> v656224 (); v656223) ()
                                US6_1
                            else
                                let v656266 : unit = ()
                                let v656267 : (unit -> unit) = closure17(v0, v656215)
                                let v656268 : unit = (fun () -> v656267 (); v656266) ()
                                US6_1
                        | US7_0(v656213) -> (* Ok *)
                            US6_0(v656213)
                    return v656336 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v657212 : Async<US6> = _v656209 
            let _v653187 = v657212 
            #endif
            let v657213 : Async<US6> = _v653187 
            return! v657213 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v689464 : Async<US6> = _v653181 
    let _v653171 = v689464 
    #endif
#if FABLE_COMPILER_PYTHON
    let v689465 : unit = ()
    let _v689465 =
        async {
            let v689468 : Async<Async<bool>> = method23(v0, v1)
            let! v689468 = v689468 
            let v689469 : Async<bool> = v689468 
            let v689470 : Async<US7> = method24(v689469)
            let v689471 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v689472 : Async<US6> = null |> unbox<Async<US6>>
            let _v689471 = v689472 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v689475 : Async<US6> = null |> unbox<Async<US6>>
            let _v689471 = v689475 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v689478 : Async<US6> = null |> unbox<Async<US6>>
            let _v689471 = v689478 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v689481 : unit = ()
            let _v689481 =
                async {
                    let! v689470 = v689470 
                    let v689484 : US7 = v689470 
                    let v689608 : US6 =
                        match v689484 with
                        | US7_1(v689487) -> (* Error *)
                            let v689488 : string = $"%A{v689487}"
                            let v689491 : string = "System.TimeoutException"
                            let v689492 : bool = v689488.Contains v689491 
                            if v689492 then
                                let v689495 : unit = ()
                                let v689496 : (unit -> unit) = closure16(v0)
                                let v689497 : unit = (fun () -> v689496 (); v689495) ()
                                US6_1
                            else
                                let v689538 : unit = ()
                                let v689539 : (unit -> unit) = closure17(v0, v689487)
                                let v689540 : unit = (fun () -> v689539 (); v689538) ()
                                US6_1
                        | US7_0(v689485) -> (* Ok *)
                            US6_0(v689485)
                    return v689608 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v690484 : Async<US6> = _v689481 
            let _v689471 = v690484 
            #endif
#if FABLE_COMPILER_PYTHON
            let v690485 : unit = ()
            let _v690485 =
                async {
                    let! v689470 = v689470 
                    let v690488 : US7 = v689470 
                    let v690612 : US6 =
                        match v690488 with
                        | US7_1(v690491) -> (* Error *)
                            let v690492 : string = $"%A{v690491}"
                            let v690495 : string = "System.TimeoutException"
                            let v690496 : bool = v690492.Contains v690495 
                            if v690496 then
                                let v690499 : unit = ()
                                let v690500 : (unit -> unit) = closure16(v0)
                                let v690501 : unit = (fun () -> v690500 (); v690499) ()
                                US6_1
                            else
                                let v690542 : unit = ()
                                let v690543 : (unit -> unit) = closure17(v0, v690491)
                                let v690544 : unit = (fun () -> v690543 (); v690542) ()
                                US6_1
                        | US7_0(v690489) -> (* Ok *)
                            US6_0(v690489)
                    return v690612 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v691488 : Async<US6> = _v690485 
            let _v689471 = v691488 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v691489 : unit = ()
            let _v691489 =
                async {
                    let! v689470 = v689470 
                    let v691492 : US7 = v689470 
                    let v691616 : US6 =
                        match v691492 with
                        | US7_1(v691495) -> (* Error *)
                            let v691496 : string = $"%A{v691495}"
                            let v691499 : string = "System.TimeoutException"
                            let v691500 : bool = v691496.Contains v691499 
                            if v691500 then
                                let v691503 : unit = ()
                                let v691504 : (unit -> unit) = closure16(v0)
                                let v691505 : unit = (fun () -> v691504 (); v691503) ()
                                US6_1
                            else
                                let v691546 : unit = ()
                                let v691547 : (unit -> unit) = closure17(v0, v691495)
                                let v691548 : unit = (fun () -> v691547 (); v691546) ()
                                US6_1
                        | US7_0(v691493) -> (* Ok *)
                            US6_0(v691493)
                    return v691616 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v692492 : Async<US6> = _v691489 
            let _v689471 = v692492 
            #endif
#else
            let v692493 : unit = ()
            let _v692493 =
                async {
                    let! v689470 = v689470 
                    let v692496 : US7 = v689470 
                    let v692620 : US6 =
                        match v692496 with
                        | US7_1(v692499) -> (* Error *)
                            let v692500 : string = $"%A{v692499}"
                            let v692503 : string = "System.TimeoutException"
                            let v692504 : bool = v692500.Contains v692503 
                            if v692504 then
                                let v692507 : unit = ()
                                let v692508 : (unit -> unit) = closure16(v0)
                                let v692509 : unit = (fun () -> v692508 (); v692507) ()
                                US6_1
                            else
                                let v692550 : unit = ()
                                let v692551 : (unit -> unit) = closure17(v0, v692499)
                                let v692552 : unit = (fun () -> v692551 (); v692550) ()
                                US6_1
                        | US7_0(v692497) -> (* Ok *)
                            US6_0(v692497)
                    return v692620 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v693496 : Async<US6> = _v692493 
            let _v689471 = v693496 
            #endif
            let v693497 : Async<US6> = _v689471 
            return! v693497 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v725748 : Async<US6> = _v689465 
    let _v653171 = v725748 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v725749 : unit = ()
    let _v725749 =
        async {
            let v725752 : Async<Async<bool>> = method23(v0, v1)
            let! v725752 = v725752 
            let v725753 : Async<bool> = v725752 
            let v725754 : Async<US7> = method24(v725753)
            let v725755 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v725756 : Async<US6> = null |> unbox<Async<US6>>
            let _v725755 = v725756 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v725759 : Async<US6> = null |> unbox<Async<US6>>
            let _v725755 = v725759 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v725762 : Async<US6> = null |> unbox<Async<US6>>
            let _v725755 = v725762 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v725765 : unit = ()
            let _v725765 =
                async {
                    let! v725754 = v725754 
                    let v725768 : US7 = v725754 
                    let v725892 : US6 =
                        match v725768 with
                        | US7_1(v725771) -> (* Error *)
                            let v725772 : string = $"%A{v725771}"
                            let v725775 : string = "System.TimeoutException"
                            let v725776 : bool = v725772.Contains v725775 
                            if v725776 then
                                let v725779 : unit = ()
                                let v725780 : (unit -> unit) = closure16(v0)
                                let v725781 : unit = (fun () -> v725780 (); v725779) ()
                                US6_1
                            else
                                let v725822 : unit = ()
                                let v725823 : (unit -> unit) = closure17(v0, v725771)
                                let v725824 : unit = (fun () -> v725823 (); v725822) ()
                                US6_1
                        | US7_0(v725769) -> (* Ok *)
                            US6_0(v725769)
                    return v725892 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v726768 : Async<US6> = _v725765 
            let _v725755 = v726768 
            #endif
#if FABLE_COMPILER_PYTHON
            let v726769 : unit = ()
            let _v726769 =
                async {
                    let! v725754 = v725754 
                    let v726772 : US7 = v725754 
                    let v726896 : US6 =
                        match v726772 with
                        | US7_1(v726775) -> (* Error *)
                            let v726776 : string = $"%A{v726775}"
                            let v726779 : string = "System.TimeoutException"
                            let v726780 : bool = v726776.Contains v726779 
                            if v726780 then
                                let v726783 : unit = ()
                                let v726784 : (unit -> unit) = closure16(v0)
                                let v726785 : unit = (fun () -> v726784 (); v726783) ()
                                US6_1
                            else
                                let v726826 : unit = ()
                                let v726827 : (unit -> unit) = closure17(v0, v726775)
                                let v726828 : unit = (fun () -> v726827 (); v726826) ()
                                US6_1
                        | US7_0(v726773) -> (* Ok *)
                            US6_0(v726773)
                    return v726896 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v727772 : Async<US6> = _v726769 
            let _v725755 = v727772 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v727773 : unit = ()
            let _v727773 =
                async {
                    let! v725754 = v725754 
                    let v727776 : US7 = v725754 
                    let v727900 : US6 =
                        match v727776 with
                        | US7_1(v727779) -> (* Error *)
                            let v727780 : string = $"%A{v727779}"
                            let v727783 : string = "System.TimeoutException"
                            let v727784 : bool = v727780.Contains v727783 
                            if v727784 then
                                let v727787 : unit = ()
                                let v727788 : (unit -> unit) = closure16(v0)
                                let v727789 : unit = (fun () -> v727788 (); v727787) ()
                                US6_1
                            else
                                let v727830 : unit = ()
                                let v727831 : (unit -> unit) = closure17(v0, v727779)
                                let v727832 : unit = (fun () -> v727831 (); v727830) ()
                                US6_1
                        | US7_0(v727777) -> (* Ok *)
                            US6_0(v727777)
                    return v727900 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v728776 : Async<US6> = _v727773 
            let _v725755 = v728776 
            #endif
#else
            let v728777 : unit = ()
            let _v728777 =
                async {
                    let! v725754 = v725754 
                    let v728780 : US7 = v725754 
                    let v728904 : US6 =
                        match v728780 with
                        | US7_1(v728783) -> (* Error *)
                            let v728784 : string = $"%A{v728783}"
                            let v728787 : string = "System.TimeoutException"
                            let v728788 : bool = v728784.Contains v728787 
                            if v728788 then
                                let v728791 : unit = ()
                                let v728792 : (unit -> unit) = closure16(v0)
                                let v728793 : unit = (fun () -> v728792 (); v728791) ()
                                US6_1
                            else
                                let v728834 : unit = ()
                                let v728835 : (unit -> unit) = closure17(v0, v728783)
                                let v728836 : unit = (fun () -> v728835 (); v728834) ()
                                US6_1
                        | US7_0(v728781) -> (* Ok *)
                            US6_0(v728781)
                    return v728904 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v729780 : Async<US6> = _v728777 
            let _v725755 = v729780 
            #endif
            let v729781 : Async<US6> = _v725755 
            return! v729781 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v762032 : Async<US6> = _v725749 
    let _v653171 = v762032 
    #endif
#else
    let v762033 : unit = ()
    let _v762033 =
        async {
            let v762036 : Async<Async<bool>> = method23(v0, v1)
            let! v762036 = v762036 
            let v762037 : Async<bool> = v762036 
            let v762038 : Async<US7> = method24(v762037)
            let v762039 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v762040 : Async<US6> = null |> unbox<Async<US6>>
            let _v762039 = v762040 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v762043 : Async<US6> = null |> unbox<Async<US6>>
            let _v762039 = v762043 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v762046 : Async<US6> = null |> unbox<Async<US6>>
            let _v762039 = v762046 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v762049 : unit = ()
            let _v762049 =
                async {
                    let! v762038 = v762038 
                    let v762052 : US7 = v762038 
                    let v762176 : US6 =
                        match v762052 with
                        | US7_1(v762055) -> (* Error *)
                            let v762056 : string = $"%A{v762055}"
                            let v762059 : string = "System.TimeoutException"
                            let v762060 : bool = v762056.Contains v762059 
                            if v762060 then
                                let v762063 : unit = ()
                                let v762064 : (unit -> unit) = closure16(v0)
                                let v762065 : unit = (fun () -> v762064 (); v762063) ()
                                US6_1
                            else
                                let v762106 : unit = ()
                                let v762107 : (unit -> unit) = closure17(v0, v762055)
                                let v762108 : unit = (fun () -> v762107 (); v762106) ()
                                US6_1
                        | US7_0(v762053) -> (* Ok *)
                            US6_0(v762053)
                    return v762176 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v763052 : Async<US6> = _v762049 
            let _v762039 = v763052 
            #endif
#if FABLE_COMPILER_PYTHON
            let v763053 : unit = ()
            let _v763053 =
                async {
                    let! v762038 = v762038 
                    let v763056 : US7 = v762038 
                    let v763180 : US6 =
                        match v763056 with
                        | US7_1(v763059) -> (* Error *)
                            let v763060 : string = $"%A{v763059}"
                            let v763063 : string = "System.TimeoutException"
                            let v763064 : bool = v763060.Contains v763063 
                            if v763064 then
                                let v763067 : unit = ()
                                let v763068 : (unit -> unit) = closure16(v0)
                                let v763069 : unit = (fun () -> v763068 (); v763067) ()
                                US6_1
                            else
                                let v763110 : unit = ()
                                let v763111 : (unit -> unit) = closure17(v0, v763059)
                                let v763112 : unit = (fun () -> v763111 (); v763110) ()
                                US6_1
                        | US7_0(v763057) -> (* Ok *)
                            US6_0(v763057)
                    return v763180 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v764056 : Async<US6> = _v763053 
            let _v762039 = v764056 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v764057 : unit = ()
            let _v764057 =
                async {
                    let! v762038 = v762038 
                    let v764060 : US7 = v762038 
                    let v764184 : US6 =
                        match v764060 with
                        | US7_1(v764063) -> (* Error *)
                            let v764064 : string = $"%A{v764063}"
                            let v764067 : string = "System.TimeoutException"
                            let v764068 : bool = v764064.Contains v764067 
                            if v764068 then
                                let v764071 : unit = ()
                                let v764072 : (unit -> unit) = closure16(v0)
                                let v764073 : unit = (fun () -> v764072 (); v764071) ()
                                US6_1
                            else
                                let v764114 : unit = ()
                                let v764115 : (unit -> unit) = closure17(v0, v764063)
                                let v764116 : unit = (fun () -> v764115 (); v764114) ()
                                US6_1
                        | US7_0(v764061) -> (* Ok *)
                            US6_0(v764061)
                    return v764184 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v765060 : Async<US6> = _v764057 
            let _v762039 = v765060 
            #endif
#else
            let v765061 : unit = ()
            let _v765061 =
                async {
                    let! v762038 = v762038 
                    let v765064 : US7 = v762038 
                    let v765188 : US6 =
                        match v765064 with
                        | US7_1(v765067) -> (* Error *)
                            let v765068 : string = $"%A{v765067}"
                            let v765071 : string = "System.TimeoutException"
                            let v765072 : bool = v765068.Contains v765071 
                            if v765072 then
                                let v765075 : unit = ()
                                let v765076 : (unit -> unit) = closure16(v0)
                                let v765077 : unit = (fun () -> v765076 (); v765075) ()
                                US6_1
                            else
                                let v765118 : unit = ()
                                let v765119 : (unit -> unit) = closure17(v0, v765067)
                                let v765120 : unit = (fun () -> v765119 (); v765118) ()
                                US6_1
                        | US7_0(v765065) -> (* Ok *)
                            US6_0(v765065)
                    return v765188 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v766064 : Async<US6> = _v765061 
            let _v762039 = v766064 
            #endif
            let v766065 : Async<US6> = _v762039 
            return! v766065 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v798316 : Async<US6> = _v762033 
    let _v653171 = v798316 
    #endif
    let v798317 : Async<US6> = _v653171 
    let _v2 = v798317 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v816463 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v816464 : Async<US6> = null |> unbox<Async<US6>>
    let _v816463 = v816464 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v816467 : Async<US6> = null |> unbox<Async<US6>>
    let _v816463 = v816467 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v816470 : Async<US6> = null |> unbox<Async<US6>>
    let _v816463 = v816470 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v816473 : unit = ()
    let _v816473 =
        async {
            let v816476 : Async<Async<bool>> = method23(v0, v1)
            let! v816476 = v816476 
            let v816477 : Async<bool> = v816476 
            let v816478 : Async<US7> = method24(v816477)
            let v816479 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v816480 : Async<US6> = null |> unbox<Async<US6>>
            let _v816479 = v816480 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v816483 : Async<US6> = null |> unbox<Async<US6>>
            let _v816479 = v816483 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v816486 : Async<US6> = null |> unbox<Async<US6>>
            let _v816479 = v816486 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v816489 : unit = ()
            let _v816489 =
                async {
                    let! v816478 = v816478 
                    let v816492 : US7 = v816478 
                    let v816616 : US6 =
                        match v816492 with
                        | US7_1(v816495) -> (* Error *)
                            let v816496 : string = $"%A{v816495}"
                            let v816499 : string = "System.TimeoutException"
                            let v816500 : bool = v816496.Contains v816499 
                            if v816500 then
                                let v816503 : unit = ()
                                let v816504 : (unit -> unit) = closure16(v0)
                                let v816505 : unit = (fun () -> v816504 (); v816503) ()
                                US6_1
                            else
                                let v816546 : unit = ()
                                let v816547 : (unit -> unit) = closure17(v0, v816495)
                                let v816548 : unit = (fun () -> v816547 (); v816546) ()
                                US6_1
                        | US7_0(v816493) -> (* Ok *)
                            US6_0(v816493)
                    return v816616 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v817492 : Async<US6> = _v816489 
            let _v816479 = v817492 
            #endif
#if FABLE_COMPILER_PYTHON
            let v817493 : unit = ()
            let _v817493 =
                async {
                    let! v816478 = v816478 
                    let v817496 : US7 = v816478 
                    let v817620 : US6 =
                        match v817496 with
                        | US7_1(v817499) -> (* Error *)
                            let v817500 : string = $"%A{v817499}"
                            let v817503 : string = "System.TimeoutException"
                            let v817504 : bool = v817500.Contains v817503 
                            if v817504 then
                                let v817507 : unit = ()
                                let v817508 : (unit -> unit) = closure16(v0)
                                let v817509 : unit = (fun () -> v817508 (); v817507) ()
                                US6_1
                            else
                                let v817550 : unit = ()
                                let v817551 : (unit -> unit) = closure17(v0, v817499)
                                let v817552 : unit = (fun () -> v817551 (); v817550) ()
                                US6_1
                        | US7_0(v817497) -> (* Ok *)
                            US6_0(v817497)
                    return v817620 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v818496 : Async<US6> = _v817493 
            let _v816479 = v818496 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v818497 : unit = ()
            let _v818497 =
                async {
                    let! v816478 = v816478 
                    let v818500 : US7 = v816478 
                    let v818624 : US6 =
                        match v818500 with
                        | US7_1(v818503) -> (* Error *)
                            let v818504 : string = $"%A{v818503}"
                            let v818507 : string = "System.TimeoutException"
                            let v818508 : bool = v818504.Contains v818507 
                            if v818508 then
                                let v818511 : unit = ()
                                let v818512 : (unit -> unit) = closure16(v0)
                                let v818513 : unit = (fun () -> v818512 (); v818511) ()
                                US6_1
                            else
                                let v818554 : unit = ()
                                let v818555 : (unit -> unit) = closure17(v0, v818503)
                                let v818556 : unit = (fun () -> v818555 (); v818554) ()
                                US6_1
                        | US7_0(v818501) -> (* Ok *)
                            US6_0(v818501)
                    return v818624 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v819500 : Async<US6> = _v818497 
            let _v816479 = v819500 
            #endif
#else
            let v819501 : unit = ()
            let _v819501 =
                async {
                    let! v816478 = v816478 
                    let v819504 : US7 = v816478 
                    let v819628 : US6 =
                        match v819504 with
                        | US7_1(v819507) -> (* Error *)
                            let v819508 : string = $"%A{v819507}"
                            let v819511 : string = "System.TimeoutException"
                            let v819512 : bool = v819508.Contains v819511 
                            if v819512 then
                                let v819515 : unit = ()
                                let v819516 : (unit -> unit) = closure16(v0)
                                let v819517 : unit = (fun () -> v819516 (); v819515) ()
                                US6_1
                            else
                                let v819558 : unit = ()
                                let v819559 : (unit -> unit) = closure17(v0, v819507)
                                let v819560 : unit = (fun () -> v819559 (); v819558) ()
                                US6_1
                        | US7_0(v819505) -> (* Ok *)
                            US6_0(v819505)
                    return v819628 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v820504 : Async<US6> = _v819501 
            let _v816479 = v820504 
            #endif
            let v820505 : Async<US6> = _v816479 
            return! v820505 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v852756 : Async<US6> = _v816473 
    let _v816463 = v852756 
    #endif
#if FABLE_COMPILER_PYTHON
    let v852757 : unit = ()
    let _v852757 =
        async {
            let v852760 : Async<Async<bool>> = method23(v0, v1)
            let! v852760 = v852760 
            let v852761 : Async<bool> = v852760 
            let v852762 : Async<US7> = method24(v852761)
            let v852763 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v852764 : Async<US6> = null |> unbox<Async<US6>>
            let _v852763 = v852764 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v852767 : Async<US6> = null |> unbox<Async<US6>>
            let _v852763 = v852767 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v852770 : Async<US6> = null |> unbox<Async<US6>>
            let _v852763 = v852770 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v852773 : unit = ()
            let _v852773 =
                async {
                    let! v852762 = v852762 
                    let v852776 : US7 = v852762 
                    let v852900 : US6 =
                        match v852776 with
                        | US7_1(v852779) -> (* Error *)
                            let v852780 : string = $"%A{v852779}"
                            let v852783 : string = "System.TimeoutException"
                            let v852784 : bool = v852780.Contains v852783 
                            if v852784 then
                                let v852787 : unit = ()
                                let v852788 : (unit -> unit) = closure16(v0)
                                let v852789 : unit = (fun () -> v852788 (); v852787) ()
                                US6_1
                            else
                                let v852830 : unit = ()
                                let v852831 : (unit -> unit) = closure17(v0, v852779)
                                let v852832 : unit = (fun () -> v852831 (); v852830) ()
                                US6_1
                        | US7_0(v852777) -> (* Ok *)
                            US6_0(v852777)
                    return v852900 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v853776 : Async<US6> = _v852773 
            let _v852763 = v853776 
            #endif
#if FABLE_COMPILER_PYTHON
            let v853777 : unit = ()
            let _v853777 =
                async {
                    let! v852762 = v852762 
                    let v853780 : US7 = v852762 
                    let v853904 : US6 =
                        match v853780 with
                        | US7_1(v853783) -> (* Error *)
                            let v853784 : string = $"%A{v853783}"
                            let v853787 : string = "System.TimeoutException"
                            let v853788 : bool = v853784.Contains v853787 
                            if v853788 then
                                let v853791 : unit = ()
                                let v853792 : (unit -> unit) = closure16(v0)
                                let v853793 : unit = (fun () -> v853792 (); v853791) ()
                                US6_1
                            else
                                let v853834 : unit = ()
                                let v853835 : (unit -> unit) = closure17(v0, v853783)
                                let v853836 : unit = (fun () -> v853835 (); v853834) ()
                                US6_1
                        | US7_0(v853781) -> (* Ok *)
                            US6_0(v853781)
                    return v853904 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v854780 : Async<US6> = _v853777 
            let _v852763 = v854780 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v854781 : unit = ()
            let _v854781 =
                async {
                    let! v852762 = v852762 
                    let v854784 : US7 = v852762 
                    let v854908 : US6 =
                        match v854784 with
                        | US7_1(v854787) -> (* Error *)
                            let v854788 : string = $"%A{v854787}"
                            let v854791 : string = "System.TimeoutException"
                            let v854792 : bool = v854788.Contains v854791 
                            if v854792 then
                                let v854795 : unit = ()
                                let v854796 : (unit -> unit) = closure16(v0)
                                let v854797 : unit = (fun () -> v854796 (); v854795) ()
                                US6_1
                            else
                                let v854838 : unit = ()
                                let v854839 : (unit -> unit) = closure17(v0, v854787)
                                let v854840 : unit = (fun () -> v854839 (); v854838) ()
                                US6_1
                        | US7_0(v854785) -> (* Ok *)
                            US6_0(v854785)
                    return v854908 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v855784 : Async<US6> = _v854781 
            let _v852763 = v855784 
            #endif
#else
            let v855785 : unit = ()
            let _v855785 =
                async {
                    let! v852762 = v852762 
                    let v855788 : US7 = v852762 
                    let v855912 : US6 =
                        match v855788 with
                        | US7_1(v855791) -> (* Error *)
                            let v855792 : string = $"%A{v855791}"
                            let v855795 : string = "System.TimeoutException"
                            let v855796 : bool = v855792.Contains v855795 
                            if v855796 then
                                let v855799 : unit = ()
                                let v855800 : (unit -> unit) = closure16(v0)
                                let v855801 : unit = (fun () -> v855800 (); v855799) ()
                                US6_1
                            else
                                let v855842 : unit = ()
                                let v855843 : (unit -> unit) = closure17(v0, v855791)
                                let v855844 : unit = (fun () -> v855843 (); v855842) ()
                                US6_1
                        | US7_0(v855789) -> (* Ok *)
                            US6_0(v855789)
                    return v855912 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v856788 : Async<US6> = _v855785 
            let _v852763 = v856788 
            #endif
            let v856789 : Async<US6> = _v852763 
            return! v856789 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v889040 : Async<US6> = _v852757 
    let _v816463 = v889040 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v889041 : unit = ()
    let _v889041 =
        async {
            let v889044 : Async<Async<bool>> = method23(v0, v1)
            let! v889044 = v889044 
            let v889045 : Async<bool> = v889044 
            let v889046 : Async<US7> = method24(v889045)
            let v889047 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v889048 : Async<US6> = null |> unbox<Async<US6>>
            let _v889047 = v889048 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v889051 : Async<US6> = null |> unbox<Async<US6>>
            let _v889047 = v889051 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v889054 : Async<US6> = null |> unbox<Async<US6>>
            let _v889047 = v889054 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v889057 : unit = ()
            let _v889057 =
                async {
                    let! v889046 = v889046 
                    let v889060 : US7 = v889046 
                    let v889184 : US6 =
                        match v889060 with
                        | US7_1(v889063) -> (* Error *)
                            let v889064 : string = $"%A{v889063}"
                            let v889067 : string = "System.TimeoutException"
                            let v889068 : bool = v889064.Contains v889067 
                            if v889068 then
                                let v889071 : unit = ()
                                let v889072 : (unit -> unit) = closure16(v0)
                                let v889073 : unit = (fun () -> v889072 (); v889071) ()
                                US6_1
                            else
                                let v889114 : unit = ()
                                let v889115 : (unit -> unit) = closure17(v0, v889063)
                                let v889116 : unit = (fun () -> v889115 (); v889114) ()
                                US6_1
                        | US7_0(v889061) -> (* Ok *)
                            US6_0(v889061)
                    return v889184 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v890060 : Async<US6> = _v889057 
            let _v889047 = v890060 
            #endif
#if FABLE_COMPILER_PYTHON
            let v890061 : unit = ()
            let _v890061 =
                async {
                    let! v889046 = v889046 
                    let v890064 : US7 = v889046 
                    let v890188 : US6 =
                        match v890064 with
                        | US7_1(v890067) -> (* Error *)
                            let v890068 : string = $"%A{v890067}"
                            let v890071 : string = "System.TimeoutException"
                            let v890072 : bool = v890068.Contains v890071 
                            if v890072 then
                                let v890075 : unit = ()
                                let v890076 : (unit -> unit) = closure16(v0)
                                let v890077 : unit = (fun () -> v890076 (); v890075) ()
                                US6_1
                            else
                                let v890118 : unit = ()
                                let v890119 : (unit -> unit) = closure17(v0, v890067)
                                let v890120 : unit = (fun () -> v890119 (); v890118) ()
                                US6_1
                        | US7_0(v890065) -> (* Ok *)
                            US6_0(v890065)
                    return v890188 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v891064 : Async<US6> = _v890061 
            let _v889047 = v891064 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v891065 : unit = ()
            let _v891065 =
                async {
                    let! v889046 = v889046 
                    let v891068 : US7 = v889046 
                    let v891192 : US6 =
                        match v891068 with
                        | US7_1(v891071) -> (* Error *)
                            let v891072 : string = $"%A{v891071}"
                            let v891075 : string = "System.TimeoutException"
                            let v891076 : bool = v891072.Contains v891075 
                            if v891076 then
                                let v891079 : unit = ()
                                let v891080 : (unit -> unit) = closure16(v0)
                                let v891081 : unit = (fun () -> v891080 (); v891079) ()
                                US6_1
                            else
                                let v891122 : unit = ()
                                let v891123 : (unit -> unit) = closure17(v0, v891071)
                                let v891124 : unit = (fun () -> v891123 (); v891122) ()
                                US6_1
                        | US7_0(v891069) -> (* Ok *)
                            US6_0(v891069)
                    return v891192 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v892068 : Async<US6> = _v891065 
            let _v889047 = v892068 
            #endif
#else
            let v892069 : unit = ()
            let _v892069 =
                async {
                    let! v889046 = v889046 
                    let v892072 : US7 = v889046 
                    let v892196 : US6 =
                        match v892072 with
                        | US7_1(v892075) -> (* Error *)
                            let v892076 : string = $"%A{v892075}"
                            let v892079 : string = "System.TimeoutException"
                            let v892080 : bool = v892076.Contains v892079 
                            if v892080 then
                                let v892083 : unit = ()
                                let v892084 : (unit -> unit) = closure16(v0)
                                let v892085 : unit = (fun () -> v892084 (); v892083) ()
                                US6_1
                            else
                                let v892126 : unit = ()
                                let v892127 : (unit -> unit) = closure17(v0, v892075)
                                let v892128 : unit = (fun () -> v892127 (); v892126) ()
                                US6_1
                        | US7_0(v892073) -> (* Ok *)
                            US6_0(v892073)
                    return v892196 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v893072 : Async<US6> = _v892069 
            let _v889047 = v893072 
            #endif
            let v893073 : Async<US6> = _v889047 
            return! v893073 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v925324 : Async<US6> = _v889041 
    let _v816463 = v925324 
    #endif
#else
    let v925325 : unit = ()
    let _v925325 =
        async {
            let v925328 : Async<Async<bool>> = method23(v0, v1)
            let! v925328 = v925328 
            let v925329 : Async<bool> = v925328 
            let v925330 : Async<US7> = method24(v925329)
            let v925331 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v925332 : Async<US6> = null |> unbox<Async<US6>>
            let _v925331 = v925332 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v925335 : Async<US6> = null |> unbox<Async<US6>>
            let _v925331 = v925335 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v925338 : Async<US6> = null |> unbox<Async<US6>>
            let _v925331 = v925338 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v925341 : unit = ()
            let _v925341 =
                async {
                    let! v925330 = v925330 
                    let v925344 : US7 = v925330 
                    let v925468 : US6 =
                        match v925344 with
                        | US7_1(v925347) -> (* Error *)
                            let v925348 : string = $"%A{v925347}"
                            let v925351 : string = "System.TimeoutException"
                            let v925352 : bool = v925348.Contains v925351 
                            if v925352 then
                                let v925355 : unit = ()
                                let v925356 : (unit -> unit) = closure16(v0)
                                let v925357 : unit = (fun () -> v925356 (); v925355) ()
                                US6_1
                            else
                                let v925398 : unit = ()
                                let v925399 : (unit -> unit) = closure17(v0, v925347)
                                let v925400 : unit = (fun () -> v925399 (); v925398) ()
                                US6_1
                        | US7_0(v925345) -> (* Ok *)
                            US6_0(v925345)
                    return v925468 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v926344 : Async<US6> = _v925341 
            let _v925331 = v926344 
            #endif
#if FABLE_COMPILER_PYTHON
            let v926345 : unit = ()
            let _v926345 =
                async {
                    let! v925330 = v925330 
                    let v926348 : US7 = v925330 
                    let v926472 : US6 =
                        match v926348 with
                        | US7_1(v926351) -> (* Error *)
                            let v926352 : string = $"%A{v926351}"
                            let v926355 : string = "System.TimeoutException"
                            let v926356 : bool = v926352.Contains v926355 
                            if v926356 then
                                let v926359 : unit = ()
                                let v926360 : (unit -> unit) = closure16(v0)
                                let v926361 : unit = (fun () -> v926360 (); v926359) ()
                                US6_1
                            else
                                let v926402 : unit = ()
                                let v926403 : (unit -> unit) = closure17(v0, v926351)
                                let v926404 : unit = (fun () -> v926403 (); v926402) ()
                                US6_1
                        | US7_0(v926349) -> (* Ok *)
                            US6_0(v926349)
                    return v926472 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v927348 : Async<US6> = _v926345 
            let _v925331 = v927348 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v927349 : unit = ()
            let _v927349 =
                async {
                    let! v925330 = v925330 
                    let v927352 : US7 = v925330 
                    let v927476 : US6 =
                        match v927352 with
                        | US7_1(v927355) -> (* Error *)
                            let v927356 : string = $"%A{v927355}"
                            let v927359 : string = "System.TimeoutException"
                            let v927360 : bool = v927356.Contains v927359 
                            if v927360 then
                                let v927363 : unit = ()
                                let v927364 : (unit -> unit) = closure16(v0)
                                let v927365 : unit = (fun () -> v927364 (); v927363) ()
                                US6_1
                            else
                                let v927406 : unit = ()
                                let v927407 : (unit -> unit) = closure17(v0, v927355)
                                let v927408 : unit = (fun () -> v927407 (); v927406) ()
                                US6_1
                        | US7_0(v927353) -> (* Ok *)
                            US6_0(v927353)
                    return v927476 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v928352 : Async<US6> = _v927349 
            let _v925331 = v928352 
            #endif
#else
            let v928353 : unit = ()
            let _v928353 =
                async {
                    let! v925330 = v925330 
                    let v928356 : US7 = v925330 
                    let v928480 : US6 =
                        match v928356 with
                        | US7_1(v928359) -> (* Error *)
                            let v928360 : string = $"%A{v928359}"
                            let v928363 : string = "System.TimeoutException"
                            let v928364 : bool = v928360.Contains v928363 
                            if v928364 then
                                let v928367 : unit = ()
                                let v928368 : (unit -> unit) = closure16(v0)
                                let v928369 : unit = (fun () -> v928368 (); v928367) ()
                                US6_1
                            else
                                let v928410 : unit = ()
                                let v928411 : (unit -> unit) = closure17(v0, v928359)
                                let v928412 : unit = (fun () -> v928411 (); v928410) ()
                                US6_1
                        | US7_0(v928357) -> (* Ok *)
                            US6_0(v928357)
                    return v928480 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v929356 : Async<US6> = _v928353 
            let _v925331 = v929356 
            #endif
            let v929357 : Async<US6> = _v925331 
            return! v929357 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v961608 : Async<US6> = _v925325 
    let _v816463 = v961608 
    #endif
    let v961609 : Async<US6> = _v816463 
    let _v2 = v961609 
    #endif
#else
    let v979755 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v979756 : Async<US6> = null |> unbox<Async<US6>>
    let _v979755 = v979756 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v979759 : Async<US6> = null |> unbox<Async<US6>>
    let _v979755 = v979759 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v979762 : Async<US6> = null |> unbox<Async<US6>>
    let _v979755 = v979762 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v979765 : unit = ()
    let _v979765 =
        async {
            let v979768 : Async<Async<bool>> = method23(v0, v1)
            let! v979768 = v979768 
            let v979769 : Async<bool> = v979768 
            let v979770 : Async<US7> = method24(v979769)
            let v979771 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v979772 : Async<US6> = null |> unbox<Async<US6>>
            let _v979771 = v979772 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v979775 : Async<US6> = null |> unbox<Async<US6>>
            let _v979771 = v979775 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v979778 : Async<US6> = null |> unbox<Async<US6>>
            let _v979771 = v979778 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v979781 : unit = ()
            let _v979781 =
                async {
                    let! v979770 = v979770 
                    let v979784 : US7 = v979770 
                    let v979908 : US6 =
                        match v979784 with
                        | US7_1(v979787) -> (* Error *)
                            let v979788 : string = $"%A{v979787}"
                            let v979791 : string = "System.TimeoutException"
                            let v979792 : bool = v979788.Contains v979791 
                            if v979792 then
                                let v979795 : unit = ()
                                let v979796 : (unit -> unit) = closure16(v0)
                                let v979797 : unit = (fun () -> v979796 (); v979795) ()
                                US6_1
                            else
                                let v979838 : unit = ()
                                let v979839 : (unit -> unit) = closure17(v0, v979787)
                                let v979840 : unit = (fun () -> v979839 (); v979838) ()
                                US6_1
                        | US7_0(v979785) -> (* Ok *)
                            US6_0(v979785)
                    return v979908 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v980784 : Async<US6> = _v979781 
            let _v979771 = v980784 
            #endif
#if FABLE_COMPILER_PYTHON
            let v980785 : unit = ()
            let _v980785 =
                async {
                    let! v979770 = v979770 
                    let v980788 : US7 = v979770 
                    let v980912 : US6 =
                        match v980788 with
                        | US7_1(v980791) -> (* Error *)
                            let v980792 : string = $"%A{v980791}"
                            let v980795 : string = "System.TimeoutException"
                            let v980796 : bool = v980792.Contains v980795 
                            if v980796 then
                                let v980799 : unit = ()
                                let v980800 : (unit -> unit) = closure16(v0)
                                let v980801 : unit = (fun () -> v980800 (); v980799) ()
                                US6_1
                            else
                                let v980842 : unit = ()
                                let v980843 : (unit -> unit) = closure17(v0, v980791)
                                let v980844 : unit = (fun () -> v980843 (); v980842) ()
                                US6_1
                        | US7_0(v980789) -> (* Ok *)
                            US6_0(v980789)
                    return v980912 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v981788 : Async<US6> = _v980785 
            let _v979771 = v981788 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v981789 : unit = ()
            let _v981789 =
                async {
                    let! v979770 = v979770 
                    let v981792 : US7 = v979770 
                    let v981916 : US6 =
                        match v981792 with
                        | US7_1(v981795) -> (* Error *)
                            let v981796 : string = $"%A{v981795}"
                            let v981799 : string = "System.TimeoutException"
                            let v981800 : bool = v981796.Contains v981799 
                            if v981800 then
                                let v981803 : unit = ()
                                let v981804 : (unit -> unit) = closure16(v0)
                                let v981805 : unit = (fun () -> v981804 (); v981803) ()
                                US6_1
                            else
                                let v981846 : unit = ()
                                let v981847 : (unit -> unit) = closure17(v0, v981795)
                                let v981848 : unit = (fun () -> v981847 (); v981846) ()
                                US6_1
                        | US7_0(v981793) -> (* Ok *)
                            US6_0(v981793)
                    return v981916 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v982792 : Async<US6> = _v981789 
            let _v979771 = v982792 
            #endif
#else
            let v982793 : unit = ()
            let _v982793 =
                async {
                    let! v979770 = v979770 
                    let v982796 : US7 = v979770 
                    let v982920 : US6 =
                        match v982796 with
                        | US7_1(v982799) -> (* Error *)
                            let v982800 : string = $"%A{v982799}"
                            let v982803 : string = "System.TimeoutException"
                            let v982804 : bool = v982800.Contains v982803 
                            if v982804 then
                                let v982807 : unit = ()
                                let v982808 : (unit -> unit) = closure16(v0)
                                let v982809 : unit = (fun () -> v982808 (); v982807) ()
                                US6_1
                            else
                                let v982850 : unit = ()
                                let v982851 : (unit -> unit) = closure17(v0, v982799)
                                let v982852 : unit = (fun () -> v982851 (); v982850) ()
                                US6_1
                        | US7_0(v982797) -> (* Ok *)
                            US6_0(v982797)
                    return v982920 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v983796 : Async<US6> = _v982793 
            let _v979771 = v983796 
            #endif
            let v983797 : Async<US6> = _v979771 
            return! v983797 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v1016048 : Async<US6> = _v979765 
    let _v979755 = v1016048 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1016049 : unit = ()
    let _v1016049 =
        async {
            let v1016052 : Async<Async<bool>> = method23(v0, v1)
            let! v1016052 = v1016052 
            let v1016053 : Async<bool> = v1016052 
            let v1016054 : Async<US7> = method24(v1016053)
            let v1016055 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1016056 : Async<US6> = null |> unbox<Async<US6>>
            let _v1016055 = v1016056 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1016059 : Async<US6> = null |> unbox<Async<US6>>
            let _v1016055 = v1016059 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1016062 : Async<US6> = null |> unbox<Async<US6>>
            let _v1016055 = v1016062 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1016065 : unit = ()
            let _v1016065 =
                async {
                    let! v1016054 = v1016054 
                    let v1016068 : US7 = v1016054 
                    let v1016192 : US6 =
                        match v1016068 with
                        | US7_1(v1016071) -> (* Error *)
                            let v1016072 : string = $"%A{v1016071}"
                            let v1016075 : string = "System.TimeoutException"
                            let v1016076 : bool = v1016072.Contains v1016075 
                            if v1016076 then
                                let v1016079 : unit = ()
                                let v1016080 : (unit -> unit) = closure16(v0)
                                let v1016081 : unit = (fun () -> v1016080 (); v1016079) ()
                                US6_1
                            else
                                let v1016122 : unit = ()
                                let v1016123 : (unit -> unit) = closure17(v0, v1016071)
                                let v1016124 : unit = (fun () -> v1016123 (); v1016122) ()
                                US6_1
                        | US7_0(v1016069) -> (* Ok *)
                            US6_0(v1016069)
                    return v1016192 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v1017068 : Async<US6> = _v1016065 
            let _v1016055 = v1017068 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1017069 : unit = ()
            let _v1017069 =
                async {
                    let! v1016054 = v1016054 
                    let v1017072 : US7 = v1016054 
                    let v1017196 : US6 =
                        match v1017072 with
                        | US7_1(v1017075) -> (* Error *)
                            let v1017076 : string = $"%A{v1017075}"
                            let v1017079 : string = "System.TimeoutException"
                            let v1017080 : bool = v1017076.Contains v1017079 
                            if v1017080 then
                                let v1017083 : unit = ()
                                let v1017084 : (unit -> unit) = closure16(v0)
                                let v1017085 : unit = (fun () -> v1017084 (); v1017083) ()
                                US6_1
                            else
                                let v1017126 : unit = ()
                                let v1017127 : (unit -> unit) = closure17(v0, v1017075)
                                let v1017128 : unit = (fun () -> v1017127 (); v1017126) ()
                                US6_1
                        | US7_0(v1017073) -> (* Ok *)
                            US6_0(v1017073)
                    return v1017196 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v1018072 : Async<US6> = _v1017069 
            let _v1016055 = v1018072 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1018073 : unit = ()
            let _v1018073 =
                async {
                    let! v1016054 = v1016054 
                    let v1018076 : US7 = v1016054 
                    let v1018200 : US6 =
                        match v1018076 with
                        | US7_1(v1018079) -> (* Error *)
                            let v1018080 : string = $"%A{v1018079}"
                            let v1018083 : string = "System.TimeoutException"
                            let v1018084 : bool = v1018080.Contains v1018083 
                            if v1018084 then
                                let v1018087 : unit = ()
                                let v1018088 : (unit -> unit) = closure16(v0)
                                let v1018089 : unit = (fun () -> v1018088 (); v1018087) ()
                                US6_1
                            else
                                let v1018130 : unit = ()
                                let v1018131 : (unit -> unit) = closure17(v0, v1018079)
                                let v1018132 : unit = (fun () -> v1018131 (); v1018130) ()
                                US6_1
                        | US7_0(v1018077) -> (* Ok *)
                            US6_0(v1018077)
                    return v1018200 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v1019076 : Async<US6> = _v1018073 
            let _v1016055 = v1019076 
            #endif
#else
            let v1019077 : unit = ()
            let _v1019077 =
                async {
                    let! v1016054 = v1016054 
                    let v1019080 : US7 = v1016054 
                    let v1019204 : US6 =
                        match v1019080 with
                        | US7_1(v1019083) -> (* Error *)
                            let v1019084 : string = $"%A{v1019083}"
                            let v1019087 : string = "System.TimeoutException"
                            let v1019088 : bool = v1019084.Contains v1019087 
                            if v1019088 then
                                let v1019091 : unit = ()
                                let v1019092 : (unit -> unit) = closure16(v0)
                                let v1019093 : unit = (fun () -> v1019092 (); v1019091) ()
                                US6_1
                            else
                                let v1019134 : unit = ()
                                let v1019135 : (unit -> unit) = closure17(v0, v1019083)
                                let v1019136 : unit = (fun () -> v1019135 (); v1019134) ()
                                US6_1
                        | US7_0(v1019081) -> (* Ok *)
                            US6_0(v1019081)
                    return v1019204 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v1020080 : Async<US6> = _v1019077 
            let _v1016055 = v1020080 
            #endif
            let v1020081 : Async<US6> = _v1016055 
            return! v1020081 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v1052332 : Async<US6> = _v1016049 
    let _v979755 = v1052332 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1052333 : unit = ()
    let _v1052333 =
        async {
            let v1052336 : Async<Async<bool>> = method23(v0, v1)
            let! v1052336 = v1052336 
            let v1052337 : Async<bool> = v1052336 
            let v1052338 : Async<US7> = method24(v1052337)
            let v1052339 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1052340 : Async<US6> = null |> unbox<Async<US6>>
            let _v1052339 = v1052340 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1052343 : Async<US6> = null |> unbox<Async<US6>>
            let _v1052339 = v1052343 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1052346 : Async<US6> = null |> unbox<Async<US6>>
            let _v1052339 = v1052346 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1052349 : unit = ()
            let _v1052349 =
                async {
                    let! v1052338 = v1052338 
                    let v1052352 : US7 = v1052338 
                    let v1052476 : US6 =
                        match v1052352 with
                        | US7_1(v1052355) -> (* Error *)
                            let v1052356 : string = $"%A{v1052355}"
                            let v1052359 : string = "System.TimeoutException"
                            let v1052360 : bool = v1052356.Contains v1052359 
                            if v1052360 then
                                let v1052363 : unit = ()
                                let v1052364 : (unit -> unit) = closure16(v0)
                                let v1052365 : unit = (fun () -> v1052364 (); v1052363) ()
                                US6_1
                            else
                                let v1052406 : unit = ()
                                let v1052407 : (unit -> unit) = closure17(v0, v1052355)
                                let v1052408 : unit = (fun () -> v1052407 (); v1052406) ()
                                US6_1
                        | US7_0(v1052353) -> (* Ok *)
                            US6_0(v1052353)
                    return v1052476 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v1053352 : Async<US6> = _v1052349 
            let _v1052339 = v1053352 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1053353 : unit = ()
            let _v1053353 =
                async {
                    let! v1052338 = v1052338 
                    let v1053356 : US7 = v1052338 
                    let v1053480 : US6 =
                        match v1053356 with
                        | US7_1(v1053359) -> (* Error *)
                            let v1053360 : string = $"%A{v1053359}"
                            let v1053363 : string = "System.TimeoutException"
                            let v1053364 : bool = v1053360.Contains v1053363 
                            if v1053364 then
                                let v1053367 : unit = ()
                                let v1053368 : (unit -> unit) = closure16(v0)
                                let v1053369 : unit = (fun () -> v1053368 (); v1053367) ()
                                US6_1
                            else
                                let v1053410 : unit = ()
                                let v1053411 : (unit -> unit) = closure17(v0, v1053359)
                                let v1053412 : unit = (fun () -> v1053411 (); v1053410) ()
                                US6_1
                        | US7_0(v1053357) -> (* Ok *)
                            US6_0(v1053357)
                    return v1053480 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v1054356 : Async<US6> = _v1053353 
            let _v1052339 = v1054356 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1054357 : unit = ()
            let _v1054357 =
                async {
                    let! v1052338 = v1052338 
                    let v1054360 : US7 = v1052338 
                    let v1054484 : US6 =
                        match v1054360 with
                        | US7_1(v1054363) -> (* Error *)
                            let v1054364 : string = $"%A{v1054363}"
                            let v1054367 : string = "System.TimeoutException"
                            let v1054368 : bool = v1054364.Contains v1054367 
                            if v1054368 then
                                let v1054371 : unit = ()
                                let v1054372 : (unit -> unit) = closure16(v0)
                                let v1054373 : unit = (fun () -> v1054372 (); v1054371) ()
                                US6_1
                            else
                                let v1054414 : unit = ()
                                let v1054415 : (unit -> unit) = closure17(v0, v1054363)
                                let v1054416 : unit = (fun () -> v1054415 (); v1054414) ()
                                US6_1
                        | US7_0(v1054361) -> (* Ok *)
                            US6_0(v1054361)
                    return v1054484 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v1055360 : Async<US6> = _v1054357 
            let _v1052339 = v1055360 
            #endif
#else
            let v1055361 : unit = ()
            let _v1055361 =
                async {
                    let! v1052338 = v1052338 
                    let v1055364 : US7 = v1052338 
                    let v1055488 : US6 =
                        match v1055364 with
                        | US7_1(v1055367) -> (* Error *)
                            let v1055368 : string = $"%A{v1055367}"
                            let v1055371 : string = "System.TimeoutException"
                            let v1055372 : bool = v1055368.Contains v1055371 
                            if v1055372 then
                                let v1055375 : unit = ()
                                let v1055376 : (unit -> unit) = closure16(v0)
                                let v1055377 : unit = (fun () -> v1055376 (); v1055375) ()
                                US6_1
                            else
                                let v1055418 : unit = ()
                                let v1055419 : (unit -> unit) = closure17(v0, v1055367)
                                let v1055420 : unit = (fun () -> v1055419 (); v1055418) ()
                                US6_1
                        | US7_0(v1055365) -> (* Ok *)
                            US6_0(v1055365)
                    return v1055488 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v1056364 : Async<US6> = _v1055361 
            let _v1052339 = v1056364 
            #endif
            let v1056365 : Async<US6> = _v1052339 
            return! v1056365 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v1088616 : Async<US6> = _v1052333 
    let _v979755 = v1088616 
    #endif
#else
    let v1088617 : unit = ()
    let _v1088617 =
        async {
            let v1088620 : Async<Async<bool>> = method23(v0, v1)
            let! v1088620 = v1088620 
            let v1088621 : Async<bool> = v1088620 
            let v1088622 : Async<US7> = method24(v1088621)
            let v1088623 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1088624 : Async<US6> = null |> unbox<Async<US6>>
            let _v1088623 = v1088624 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1088627 : Async<US6> = null |> unbox<Async<US6>>
            let _v1088623 = v1088627 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1088630 : Async<US6> = null |> unbox<Async<US6>>
            let _v1088623 = v1088630 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1088633 : unit = ()
            let _v1088633 =
                async {
                    let! v1088622 = v1088622 
                    let v1088636 : US7 = v1088622 
                    let v1088760 : US6 =
                        match v1088636 with
                        | US7_1(v1088639) -> (* Error *)
                            let v1088640 : string = $"%A{v1088639}"
                            let v1088643 : string = "System.TimeoutException"
                            let v1088644 : bool = v1088640.Contains v1088643 
                            if v1088644 then
                                let v1088647 : unit = ()
                                let v1088648 : (unit -> unit) = closure16(v0)
                                let v1088649 : unit = (fun () -> v1088648 (); v1088647) ()
                                US6_1
                            else
                                let v1088690 : unit = ()
                                let v1088691 : (unit -> unit) = closure17(v0, v1088639)
                                let v1088692 : unit = (fun () -> v1088691 (); v1088690) ()
                                US6_1
                        | US7_0(v1088637) -> (* Ok *)
                            US6_0(v1088637)
                    return v1088760 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v1089636 : Async<US6> = _v1088633 
            let _v1088623 = v1089636 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1089637 : unit = ()
            let _v1089637 =
                async {
                    let! v1088622 = v1088622 
                    let v1089640 : US7 = v1088622 
                    let v1089764 : US6 =
                        match v1089640 with
                        | US7_1(v1089643) -> (* Error *)
                            let v1089644 : string = $"%A{v1089643}"
                            let v1089647 : string = "System.TimeoutException"
                            let v1089648 : bool = v1089644.Contains v1089647 
                            if v1089648 then
                                let v1089651 : unit = ()
                                let v1089652 : (unit -> unit) = closure16(v0)
                                let v1089653 : unit = (fun () -> v1089652 (); v1089651) ()
                                US6_1
                            else
                                let v1089694 : unit = ()
                                let v1089695 : (unit -> unit) = closure17(v0, v1089643)
                                let v1089696 : unit = (fun () -> v1089695 (); v1089694) ()
                                US6_1
                        | US7_0(v1089641) -> (* Ok *)
                            US6_0(v1089641)
                    return v1089764 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v1090640 : Async<US6> = _v1089637 
            let _v1088623 = v1090640 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1090641 : unit = ()
            let _v1090641 =
                async {
                    let! v1088622 = v1088622 
                    let v1090644 : US7 = v1088622 
                    let v1090768 : US6 =
                        match v1090644 with
                        | US7_1(v1090647) -> (* Error *)
                            let v1090648 : string = $"%A{v1090647}"
                            let v1090651 : string = "System.TimeoutException"
                            let v1090652 : bool = v1090648.Contains v1090651 
                            if v1090652 then
                                let v1090655 : unit = ()
                                let v1090656 : (unit -> unit) = closure16(v0)
                                let v1090657 : unit = (fun () -> v1090656 (); v1090655) ()
                                US6_1
                            else
                                let v1090698 : unit = ()
                                let v1090699 : (unit -> unit) = closure17(v0, v1090647)
                                let v1090700 : unit = (fun () -> v1090699 (); v1090698) ()
                                US6_1
                        | US7_0(v1090645) -> (* Ok *)
                            US6_0(v1090645)
                    return v1090768 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v1091644 : Async<US6> = _v1090641 
            let _v1088623 = v1091644 
            #endif
#else
            let v1091645 : unit = ()
            let _v1091645 =
                async {
                    let! v1088622 = v1088622 
                    let v1091648 : US7 = v1088622 
                    let v1091772 : US6 =
                        match v1091648 with
                        | US7_1(v1091651) -> (* Error *)
                            let v1091652 : string = $"%A{v1091651}"
                            let v1091655 : string = "System.TimeoutException"
                            let v1091656 : bool = v1091652.Contains v1091655 
                            if v1091656 then
                                let v1091659 : unit = ()
                                let v1091660 : (unit -> unit) = closure16(v0)
                                let v1091661 : unit = (fun () -> v1091660 (); v1091659) ()
                                US6_1
                            else
                                let v1091702 : unit = ()
                                let v1091703 : (unit -> unit) = closure17(v0, v1091651)
                                let v1091704 : unit = (fun () -> v1091703 (); v1091702) ()
                                US6_1
                        | US7_0(v1091649) -> (* Ok *)
                            US6_0(v1091649)
                    return v1091772 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v1092648 : Async<US6> = _v1091645 
            let _v1088623 = v1092648 
            #endif
            let v1092649 : Async<US6> = _v1088623 
            return! v1092649 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v1124900 : Async<US6> = _v1088617 
    let _v979755 = v1124900 
    #endif
    let v1124901 : Async<US6> = _v979755 
    let _v2 = v1124901 
    #endif
    let v1143047 : Async<US6> = _v2 
    v1143047
and method21 (v0 : int32, v1 : string, v2 : int32) : Async<bool> =
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
    let v13 : unit = ()
    let _v13 =
        async {
            let v16 : Async<bool> = method6(v1, v2)
            let v17 : Async<US6> = method22(v0, v16)
            let! v17 = v17 
            let v18 : US6 = v17 
            let v21 : bool =
                match v18 with
                | US6_1 -> (* None *)
                    false
                | US6_0(v19) -> (* Some *)
                    v19
            return v21 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v64 : Async<bool> = _v13 
    let _v3 = v64 
    #endif
#if FABLE_COMPILER_PYTHON
    let v65 : unit = ()
    let _v65 =
        async {
            let v68 : Async<bool> = method6(v1, v2)
            let v69 : Async<US6> = method22(v0, v68)
            let! v69 = v69 
            let v70 : US6 = v69 
            let v73 : bool =
                match v70 with
                | US6_1 -> (* None *)
                    false
                | US6_0(v71) -> (* Some *)
                    v71
            return v73 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v116 : Async<bool> = _v65 
    let _v3 = v116 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v117 : unit = ()
    let _v117 =
        async {
            let v120 : Async<bool> = method6(v1, v2)
            let v121 : Async<US6> = method22(v0, v120)
            let! v121 = v121 
            let v122 : US6 = v121 
            let v125 : bool =
                match v122 with
                | US6_1 -> (* None *)
                    false
                | US6_0(v123) -> (* Some *)
                    v123
            return v125 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v168 : Async<bool> = _v117 
    let _v3 = v168 
    #endif
#else
    let v169 : unit = ()
    let _v169 =
        async {
            let v172 : Async<bool> = method6(v1, v2)
            let v173 : Async<US6> = method22(v0, v172)
            let! v173 = v173 
            let v174 : US6 = v173 
            let v177 : bool =
                match v174 with
                | US6_1 -> (* None *)
                    false
                | US6_0(v175) -> (* Some *)
                    v175
            return v177 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v220 : Async<bool> = _v169 
    let _v3 = v220 
    #endif
    let v221 : Async<bool> = _v3 
    v221
and closure13 (v0 : int32, v1 : string) (v2 : int32) : Async<bool> =
    method21(v0, v1, v2)
and closure12 (v0 : int32) (v1 : string) : (int32 -> Async<bool>) =
    closure13(v0, v1)
and closure11 () (v0 : int32) : (string -> (int32 -> Async<bool>)) =
    closure12(v0)
and closure22 () (v0 : int32) : US9 =
    US9_0(v0)
and method35 () : (int32 -> US9) =
    closure22()
and method37 (v0 : int32, v1 : int64, v2 : int32 option, v3 : bool) : string =
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
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v119 : string = $"%A{v2}"
    let _v100 = v119 
    #endif
#else
    let v122 : string = $"%A{v2}"
    let _v100 = v122 
    #endif
    let v125 : string = _v100 
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
and method36 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : int32, v9 : int64, v10 : int32 option, v11 : bool) : string =
    let v12 : string = method37(v8, v9, v10, v11)
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
        let v42 : string = method36(v22, v23, v24, v25, v26, v27, v40, v41, v2, v3, v0, v1)
        method20(v42)
and method38 (v0 : int32) : Async<unit> =
    let v1 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : (int32 -> Async<unit>) = Async.Sleep
    let v3 : Async<unit> = v2 v0
    let _v1 = v3 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v4 : (int32 -> Async<unit>) = Async.Sleep
    let v5 : Async<unit> = v4 v0
    let _v1 = v5 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v6 : (int32 -> Async<unit>) = Async.Sleep
    let v7 : Async<unit> = v6 v0
    let _v1 = v7 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v8 : (int32 -> Async<unit>) = Async.Sleep
    let v9 : Async<unit> = v8 v0
    let _v1 = v9 
    #endif
#if FABLE_COMPILER_PYTHON
    let v10 : (int32 -> Async<unit>) = Async.Sleep
    let v11 : Async<unit> = v10 v0
    let _v1 = v11 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v12 : (int32 -> Async<unit>) = Async.Sleep
    let v13 : Async<unit> = v12 v0
    let _v1 = v13 
    #endif
#else
    let v14 : (int32 -> Async<unit>) = Async.Sleep
    let v15 : Async<unit> = v14 v0
    let _v1 = v15 
    #endif
    let v16 : Async<unit> = _v1 
    v16
and method34 (v0 : int32 option, v1 : bool, v2 : string, v3 : int32, v4 : int64) : Async<int64> =
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
    let v15 : unit = ()
    let _v15 =
        async {
            let v18 : (int32 -> US9) = method35()
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
                (*
                ()
            else
                *) else
                let v42 : int64 = v4 % 100L
                let v43 : bool = v42 = 0L
                if v43 then
                    let v44 : unit = ()
                    let v45 : (unit -> unit) = closure23(v0, v1, v3, v4)
                    let v46 : unit = (fun () -> v45 (); v44) ()
                    ()
                let v86 : int32 = 10
                let v87 : Async<unit> = method38(v86)
                do! v87 
                let v88 : int64 = v4 + 1L
                let v89 : Async<int64> = method34(v0, v1, v2, v3, v88)
                return! v89 
                (*
                ()
            *)
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v594 : Async<int64> = _v15 
    let _v5 = v594 
    #endif
#if FABLE_COMPILER_PYTHON
    let v595 : unit = ()
    let _v595 =
        async {
            let v598 : (int32 -> US9) = method35()
            let v599 : US9 option = v0 |> Option.map v598 
            let v610 : US9 = US9_1
            let v611 : US9 = v599 |> Option.defaultValue v610 
            let v619 : Async<bool> =
                match v611 with
                | US9_1 -> (* None *)
                    method6(v2, v3)
                | US9_0(v616) -> (* Some *)
                    method21(v616, v2, v3)
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
                let v666 : int32 = 10
                let v667 : Async<unit> = method38(v666)
                do! v667 
                let v668 : int64 = v4 + 1L
                let v669 : Async<int64> = method34(v0, v1, v2, v3, v668)
                return! v669 
                (*
                ()
            *)
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v1174 : Async<int64> = _v595 
    let _v5 = v1174 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1175 : unit = ()
    let _v1175 =
        async {
            let v1178 : (int32 -> US9) = method35()
            let v1179 : US9 option = v0 |> Option.map v1178 
            let v1190 : US9 = US9_1
            let v1191 : US9 = v1179 |> Option.defaultValue v1190 
            let v1199 : Async<bool> =
                match v1191 with
                | US9_1 -> (* None *)
                    method6(v2, v3)
                | US9_0(v1196) -> (* Some *)
                    method21(v1196, v2, v3)
            let! v1199 = v1199 
            let v1200 : bool = v1199 
            let v1201 : bool = v1200 = v1
            if v1201 then
                return v4 
                (*
                ()
            else
                *) else
                let v1202 : int64 = v4 % 100L
                let v1203 : bool = v1202 = 0L
                if v1203 then
                    let v1204 : unit = ()
                    let v1205 : (unit -> unit) = closure23(v0, v1, v3, v4)
                    let v1206 : unit = (fun () -> v1205 (); v1204) ()
                    ()
                let v1246 : int32 = 10
                let v1247 : Async<unit> = method38(v1246)
                do! v1247 
                let v1248 : int64 = v4 + 1L
                let v1249 : Async<int64> = method34(v0, v1, v2, v3, v1248)
                return! v1249 
                (*
                ()
            *)
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v1754 : Async<int64> = _v1175 
    let _v5 = v1754 
    #endif
#else
    let v1755 : unit = ()
    let _v1755 =
        async {
            let v1758 : (int32 -> US9) = method35()
            let v1759 : US9 option = v0 |> Option.map v1758 
            let v1770 : US9 = US9_1
            let v1771 : US9 = v1759 |> Option.defaultValue v1770 
            let v1779 : Async<bool> =
                match v1771 with
                | US9_1 -> (* None *)
                    method6(v2, v3)
                | US9_0(v1776) -> (* Some *)
                    method21(v1776, v2, v3)
            let! v1779 = v1779 
            let v1780 : bool = v1779 
            let v1781 : bool = v1780 = v1
            if v1781 then
                return v4 
                (*
                ()
            else
                *) else
                let v1782 : int64 = v4 % 100L
                let v1783 : bool = v1782 = 0L
                if v1783 then
                    let v1784 : unit = ()
                    let v1785 : (unit -> unit) = closure23(v0, v1, v3, v4)
                    let v1786 : unit = (fun () -> v1785 (); v1784) ()
                    ()
                let v1826 : int32 = 10
                let v1827 : Async<unit> = method38(v1826)
                do! v1827 
                let v1828 : int64 = v4 + 1L
                let v1829 : Async<int64> = method34(v0, v1, v2, v3, v1828)
                return! v1829 
                (*
                ()
            *)
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v2334 : Async<int64> = _v1755 
    let _v5 = v2334 
    #endif
    let v2335 : Async<int64> = _v5 
    v2335
and method33 (v0 : int32 option, v1 : bool, v2 : string, v3 : int32) : Async<int64> =
    let v4 : int64 = 1L
    method34(v0, v1, v2, v3, v4)
and closure21 (v0 : int32 option, v1 : bool, v2 : string) (v3 : int32) : Async<int64> =
    method33(v0, v1, v2, v3)
and closure20 (v0 : int32 option, v1 : bool) (v2 : string) : (int32 -> Async<int64>) =
    closure21(v0, v1, v2)
and closure19 (v0 : int32 option) (v1 : bool) : (string -> (int32 -> Async<int64>)) =
    closure20(v0, v1)
and closure18 () (v0 : int32 option) : (bool -> (string -> (int32 -> Async<int64>))) =
    closure19(v0)
and method40 (v0 : int32 option, v1 : string, v2 : int32) : Async<int32> =
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
    let v13 : unit = ()
    let _v13 =
        async {
            let v16 : (int32 -> US9) = method35()
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
                (*
                ()
            else
                *) else
                let v40 : int32 = v2 + 1
                let v41 : Async<int32> = method40(v0, v1, v40)
                return! v41 
                (*
                ()
            *)
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v224 : Async<int32> = _v13 
    let _v3 = v224 
    #endif
#if FABLE_COMPILER_PYTHON
    let v225 : unit = ()
    let _v225 =
        async {
            let v228 : (int32 -> US9) = method35()
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
                (*
                ()
            else
                *) else
                let v252 : int32 = v2 + 1
                let v253 : Async<int32> = method40(v0, v1, v252)
                return! v253 
                (*
                ()
            *)
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v436 : Async<int32> = _v225 
    let _v3 = v436 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v437 : unit = ()
    let _v437 =
        async {
            let v440 : (int32 -> US9) = method35()
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
                (*
                ()
            else
                *) else
                let v464 : int32 = v2 + 1
                let v465 : Async<int32> = method40(v0, v1, v464)
                return! v465 
                (*
                ()
            *)
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v648 : Async<int32> = _v437 
    let _v3 = v648 
    #endif
#else
    let v649 : unit = ()
    let _v649 =
        async {
            let v652 : (int32 -> US9) = method35()
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
                (*
                ()
            else
                *) else
                let v676 : int32 = v2 + 1
                let v677 : Async<int32> = method40(v0, v1, v676)
                return! v677 
                (*
                ()
            *)
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v860 : Async<int32> = _v649 
    let _v3 = v860 
    #endif
    let v861 : Async<int32> = _v3 
    v861
and method39 (v0 : int32 option, v1 : string, v2 : int32) : Async<int32> =
    method40(v0, v1, v2)
and closure26 (v0 : int32 option, v1 : string) (v2 : int32) : Async<int32> =
    method39(v0, v1, v2)
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
