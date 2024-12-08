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
and method7 (v0 : US0) : bool =
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
and method9 () : (int64 -> US2) =
    closure6()
and method10 () : string =
    let v0 : string = "hh:mm:ss"
    v0
and method11 () : string =
    let v0 : string = "HH:mm:ss"
    v0
and method8 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option) : string =
    let v6 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v7 : (int64 -> US2) = method9()
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
    let v118 : string = method10()
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
    let v139 : (int64 -> US2) = method9()
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
    let v250 : string = method10()
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
    let v273 : (int64 -> US2) = method9()
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
    let v308 : (int64 -> US2) = method9()
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
    let v419 : string = method11()
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
    let v440 : (int64 -> US2) = method9()
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
    let v551 : string = method11()
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
    let v572 : (int64 -> US2) = method9()
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
    let v683 : string = method11()
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
    let v704 : (int64 -> US2) = method9()
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
    let v815 : string = method11()
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
and method14 () : string =
    let v0 : string = ""
    v0
and closure7 (v0 : Mut3, v1 : string) () : unit =
    let v2 : string = v0.l0
    let v3 : string = v2 + v1 
    v0.l0 <- v3
    ()
and method13 (v0 : char) : string =
    let v1 : string = method14()
    let v2 : Mut3 = {l0 = v1} : Mut3
    let v3 : string = $"{v0}"
    let v6 : unit = ()
    let v7 : (unit -> unit) = closure7(v2, v3)
    let v8 : unit = (fun () -> v7 (); v6) ()
    let v11 : string = v2.l0
    v11
and method15 () : string =
    let v0 : string = "\u001b[0m"
    v0
and method12 () : string =
    
    
    
    
    
    let v0 : string = "Verbose"
    let v1 : (unit -> string) = v0.ToLower
    let v2 : string = v1 ()
    let v5 : char = v2.[int 0]
    let v6 : string = method13(v5)
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
    let v105 : string = method15()
    let v106 : string = v104 + v6 
    let v107 : string = v106 + v105 
    let _v7 = v107 
    #endif
#if FABLE_COMPILER_PYTHON
    let v108 : string = "\u001b[90m"
    let v109 : string = method15()
    let v110 : string = v108 + v6 
    let v111 : string = v110 + v109 
    let _v7 = v111 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v112 : string = "\u001b[90m"
    let v113 : string = method15()
    let v114 : string = v112 + v6 
    let v115 : string = v114 + v113 
    let _v7 = v115 
    #endif
#else
    let v116 : string = "\u001b[90m"
    let v117 : string = method15()
    let v118 : string = v116 + v6 
    let v119 : string = v118 + v117 
    let _v7 = v119 
    #endif
    let v120 : string = _v7 
    v120
and method17 (v0 : int32, v1 : string) : string =
    let v2 : string = method14()
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
and method18 (v0 : string) : string =
    let v1 : char list = []
    let v2 : (char list -> (char [])) = List.toArray
    let v3 : (char []) = v2 v1
    let v6 : string = v0.TrimStart v3 
    let v28 : char list = []
    let v29 : char list = '/' :: v28 
    let v32 : char list = ' ' :: v29 
    let v35 : (char list -> (char [])) = List.toArray
    let v36 : (char []) = v35 v32
    let v39 : string = v6.TrimEnd v36 
    v39
and method16 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : int32, v9 : string) : string =
    let v10 : string = method17(v8, v9)
    let v11 : int64 = v0.l0
    let v12 : string = "networking.test_port_open"
    let v13 : string = $"{v6} {v7} #{v11} %s{v12} / {v10}"
    method18(v13)
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
and method19 (v0 : string) : unit =
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
    let v3 : bool = method7(v2)
    if v3 then
        let v4 : unit = ()
        let v5 : (unit -> unit) = closure0()
        let v6 : unit = (fun () -> v5 (); v4) ()
        let struct (v20 : Mut0, v21 : Mut1, v22 : Mut2, v23 : Mut3, v24 : Mut4, v25 : int64 option) = TraceState.trace_state.Value
        let v38 : string = method8(v20, v21, v22, v23, v24, v25)
        let v39 : string = method12()
        let v40 : string = method16(v20, v21, v22, v23, v24, v25, v38, v39, v0, v1)
        method19(v40)
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
            let v13 : Async<System.Threading.CancellationToken> = Async.CancellationToken
            let! v13 = v13 
            let v14 : System.Threading.CancellationToken = v13 
            let v15 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v16 : System_Net_Sockets_TcpClient = null |> unbox<System_Net_Sockets_TcpClient>
            let _v15 = v16 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v19 : System_Net_Sockets_TcpClient = null |> unbox<System_Net_Sockets_TcpClient>
            let _v15 = v19 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v22 : System_Net_Sockets_TcpClient = null |> unbox<System_Net_Sockets_TcpClient>
            let _v15 = v22 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v25 : System_Net_Sockets_TcpClient = null |> unbox<System_Net_Sockets_TcpClient>
            let _v15 = v25 
            #endif
#if FABLE_COMPILER_PYTHON
            let v28 : System_Net_Sockets_TcpClient = null |> unbox<System_Net_Sockets_TcpClient>
            let _v15 = v28 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v31 : System_Net_Sockets_TcpClient = null |> unbox<System_Net_Sockets_TcpClient>
            let _v15 = v31 
            #endif
#else
            let v34 : System_Net_Sockets_TcpClient = new System_Net_Sockets_TcpClient ()
            let _v15 = v34 
            #endif
            let v35 : System_Net_Sockets_TcpClient = _v15 
            use v35 = v35 
            let v40 : System_Net_Sockets_TcpClient = v35 
            try
            let v41 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v42 : System.Threading.Tasks.ValueTask = null |> unbox<System.Threading.Tasks.ValueTask>
            let _v41 = v42 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v45 : System.Threading.Tasks.ValueTask = null |> unbox<System.Threading.Tasks.ValueTask>
            let _v41 = v45 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v48 : System.Threading.Tasks.ValueTask = null |> unbox<System.Threading.Tasks.ValueTask>
            let _v41 = v48 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v51 : System.Threading.Tasks.ValueTask = null |> unbox<System.Threading.Tasks.ValueTask>
            let _v41 = v51 
            #endif
#if FABLE_COMPILER_PYTHON
            let v54 : System.Threading.Tasks.ValueTask = null |> unbox<System.Threading.Tasks.ValueTask>
            let _v41 = v54 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v57 : System.Threading.Tasks.ValueTask = null |> unbox<System.Threading.Tasks.ValueTask>
            let _v41 = v57 
            #endif
#else
            let v60 : System.Threading.Tasks.ValueTask = v40.ConnectAsync (v0, v1, v14)
            let _v41 = v60 
            #endif
            let v61 : System.Threading.Tasks.ValueTask = _v41 
            let v66 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v67 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
            let _v66 = v67 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v70 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
            let _v66 = v70 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v73 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
            let _v66 = v73 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v76 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
            let _v66 = v76 
            #endif
#if FABLE_COMPILER_PYTHON
            let v79 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
            let _v66 = v79 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v82 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
            let _v66 = v82 
            #endif
#else
            let v85 : (unit -> System.Threading.Tasks.Task) = v61.AsTask
            let v86 : System.Threading.Tasks.Task = v85 ()
            let _v66 = v86 
            #endif
            let v87 : System.Threading.Tasks.Task = _v66 
            let v92 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v93 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
            let v94 : Async<unit> = v93 v87
            let _v92 = v94 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v95 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
            let v96 : Async<unit> = v95 v87
            let _v92 = v96 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v97 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
            let v98 : Async<unit> = v97 v87
            let _v92 = v98 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v99 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
            let v100 : Async<unit> = v99 v87
            let _v92 = v100 
            #endif
#if FABLE_COMPILER_PYTHON
            let v101 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
            let v102 : Async<unit> = v101 v87
            let _v92 = v102 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v103 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
            let v104 : Async<unit> = v103 v87
            let _v92 = v104 
            #endif
#else
            let v105 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
            let v106 : Async<unit> = v105 v87
            let _v92 = v106 
            #endif
            let v107 : Async<unit> = _v92 
            do! v107 
            return true 
            with ex ->
                let v112 : exn = ex
                let v113 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v114 : string = $"%A{v112}"
                let _v113 = v114 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v117 : string = $"%A{v112}"
                let _v113 = v117 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v120 : string = $"%A{v112}"
                let _v113 = v120 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v123 : string = $"%A{v112}"
                let _v113 = v123 
                #endif
#if FABLE_COMPILER_PYTHON
                let v126 : string = $"%A{v112}"
                let _v113 = v126 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v129 : string = $"%A{v112}"
                let _v113 = v129 
                #endif
#else
                let v132 : string = $"{v112.GetType ()}: {v112.Message}"
                let _v113 = v132 
                #endif
                let v133 : string = _v113 
                let v138 : unit = ()
                let v139 : (unit -> unit) = closure5(v1, v133)
                let v140 : unit = (fun () -> v139 (); v138) ()
                return false 
                (*
                ()
            *)
            (*
            let v180 : bool = *)
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v181 : Async<bool> = _v12 
    let _v2 = v181 
    #endif
#if FABLE_COMPILER_PYTHON
    let v182 : unit = ()
    let _v182 =
        async {
            let v183 : Async<System.Threading.CancellationToken> = Async.CancellationToken
            let! v183 = v183 
            let v184 : System.Threading.CancellationToken = v183 
            let v185 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v186 : System_Net_Sockets_TcpClient = null |> unbox<System_Net_Sockets_TcpClient>
            let _v185 = v186 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v189 : System_Net_Sockets_TcpClient = null |> unbox<System_Net_Sockets_TcpClient>
            let _v185 = v189 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v192 : System_Net_Sockets_TcpClient = null |> unbox<System_Net_Sockets_TcpClient>
            let _v185 = v192 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v195 : System_Net_Sockets_TcpClient = null |> unbox<System_Net_Sockets_TcpClient>
            let _v185 = v195 
            #endif
#if FABLE_COMPILER_PYTHON
            let v198 : System_Net_Sockets_TcpClient = null |> unbox<System_Net_Sockets_TcpClient>
            let _v185 = v198 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v201 : System_Net_Sockets_TcpClient = null |> unbox<System_Net_Sockets_TcpClient>
            let _v185 = v201 
            #endif
#else
            let v204 : System_Net_Sockets_TcpClient = new System_Net_Sockets_TcpClient ()
            let _v185 = v204 
            #endif
            let v205 : System_Net_Sockets_TcpClient = _v185 
            use v205 = v205 
            let v210 : System_Net_Sockets_TcpClient = v205 
            try
            let v211 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v212 : System.Threading.Tasks.ValueTask = null |> unbox<System.Threading.Tasks.ValueTask>
            let _v211 = v212 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v215 : System.Threading.Tasks.ValueTask = null |> unbox<System.Threading.Tasks.ValueTask>
            let _v211 = v215 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v218 : System.Threading.Tasks.ValueTask = null |> unbox<System.Threading.Tasks.ValueTask>
            let _v211 = v218 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v221 : System.Threading.Tasks.ValueTask = null |> unbox<System.Threading.Tasks.ValueTask>
            let _v211 = v221 
            #endif
#if FABLE_COMPILER_PYTHON
            let v224 : System.Threading.Tasks.ValueTask = null |> unbox<System.Threading.Tasks.ValueTask>
            let _v211 = v224 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v227 : System.Threading.Tasks.ValueTask = null |> unbox<System.Threading.Tasks.ValueTask>
            let _v211 = v227 
            #endif
#else
            let v230 : System.Threading.Tasks.ValueTask = v210.ConnectAsync (v0, v1, v184)
            let _v211 = v230 
            #endif
            let v231 : System.Threading.Tasks.ValueTask = _v211 
            let v236 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v237 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
            let _v236 = v237 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v240 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
            let _v236 = v240 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v243 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
            let _v236 = v243 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v246 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
            let _v236 = v246 
            #endif
#if FABLE_COMPILER_PYTHON
            let v249 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
            let _v236 = v249 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v252 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
            let _v236 = v252 
            #endif
#else
            let v255 : (unit -> System.Threading.Tasks.Task) = v231.AsTask
            let v256 : System.Threading.Tasks.Task = v255 ()
            let _v236 = v256 
            #endif
            let v257 : System.Threading.Tasks.Task = _v236 
            let v262 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v263 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
            let v264 : Async<unit> = v263 v257
            let _v262 = v264 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v265 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
            let v266 : Async<unit> = v265 v257
            let _v262 = v266 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v267 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
            let v268 : Async<unit> = v267 v257
            let _v262 = v268 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v269 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
            let v270 : Async<unit> = v269 v257
            let _v262 = v270 
            #endif
#if FABLE_COMPILER_PYTHON
            let v271 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
            let v272 : Async<unit> = v271 v257
            let _v262 = v272 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v273 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
            let v274 : Async<unit> = v273 v257
            let _v262 = v274 
            #endif
#else
            let v275 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
            let v276 : Async<unit> = v275 v257
            let _v262 = v276 
            #endif
            let v277 : Async<unit> = _v262 
            do! v277 
            return true 
            with ex ->
                let v282 : exn = ex
                let v283 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v284 : string = $"%A{v282}"
                let _v283 = v284 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v287 : string = $"%A{v282}"
                let _v283 = v287 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v290 : string = $"%A{v282}"
                let _v283 = v290 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v293 : string = $"%A{v282}"
                let _v283 = v293 
                #endif
#if FABLE_COMPILER_PYTHON
                let v296 : string = $"%A{v282}"
                let _v283 = v296 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v299 : string = $"%A{v282}"
                let _v283 = v299 
                #endif
#else
                let v302 : string = $"{v282.GetType ()}: {v282.Message}"
                let _v283 = v302 
                #endif
                let v303 : string = _v283 
                let v308 : unit = ()
                let v309 : (unit -> unit) = closure5(v1, v303)
                let v310 : unit = (fun () -> v309 (); v308) ()
                return false 
                (*
                ()
            *)
            (*
            let v350 : bool = *)
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v351 : Async<bool> = _v182 
    let _v2 = v351 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v352 : unit = ()
    let _v352 =
        async {
            let v353 : Async<System.Threading.CancellationToken> = Async.CancellationToken
            let! v353 = v353 
            let v354 : System.Threading.CancellationToken = v353 
            let v355 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v356 : System_Net_Sockets_TcpClient = null |> unbox<System_Net_Sockets_TcpClient>
            let _v355 = v356 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v359 : System_Net_Sockets_TcpClient = null |> unbox<System_Net_Sockets_TcpClient>
            let _v355 = v359 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v362 : System_Net_Sockets_TcpClient = null |> unbox<System_Net_Sockets_TcpClient>
            let _v355 = v362 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v365 : System_Net_Sockets_TcpClient = null |> unbox<System_Net_Sockets_TcpClient>
            let _v355 = v365 
            #endif
#if FABLE_COMPILER_PYTHON
            let v368 : System_Net_Sockets_TcpClient = null |> unbox<System_Net_Sockets_TcpClient>
            let _v355 = v368 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v371 : System_Net_Sockets_TcpClient = null |> unbox<System_Net_Sockets_TcpClient>
            let _v355 = v371 
            #endif
#else
            let v374 : System_Net_Sockets_TcpClient = new System_Net_Sockets_TcpClient ()
            let _v355 = v374 
            #endif
            let v375 : System_Net_Sockets_TcpClient = _v355 
            use v375 = v375 
            let v380 : System_Net_Sockets_TcpClient = v375 
            try
            let v381 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v382 : System.Threading.Tasks.ValueTask = null |> unbox<System.Threading.Tasks.ValueTask>
            let _v381 = v382 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v385 : System.Threading.Tasks.ValueTask = null |> unbox<System.Threading.Tasks.ValueTask>
            let _v381 = v385 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v388 : System.Threading.Tasks.ValueTask = null |> unbox<System.Threading.Tasks.ValueTask>
            let _v381 = v388 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v391 : System.Threading.Tasks.ValueTask = null |> unbox<System.Threading.Tasks.ValueTask>
            let _v381 = v391 
            #endif
#if FABLE_COMPILER_PYTHON
            let v394 : System.Threading.Tasks.ValueTask = null |> unbox<System.Threading.Tasks.ValueTask>
            let _v381 = v394 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v397 : System.Threading.Tasks.ValueTask = null |> unbox<System.Threading.Tasks.ValueTask>
            let _v381 = v397 
            #endif
#else
            let v400 : System.Threading.Tasks.ValueTask = v380.ConnectAsync (v0, v1, v354)
            let _v381 = v400 
            #endif
            let v401 : System.Threading.Tasks.ValueTask = _v381 
            let v406 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v407 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
            let _v406 = v407 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v410 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
            let _v406 = v410 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v413 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
            let _v406 = v413 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v416 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
            let _v406 = v416 
            #endif
#if FABLE_COMPILER_PYTHON
            let v419 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
            let _v406 = v419 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v422 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
            let _v406 = v422 
            #endif
#else
            let v425 : (unit -> System.Threading.Tasks.Task) = v401.AsTask
            let v426 : System.Threading.Tasks.Task = v425 ()
            let _v406 = v426 
            #endif
            let v427 : System.Threading.Tasks.Task = _v406 
            let v432 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v433 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
            let v434 : Async<unit> = v433 v427
            let _v432 = v434 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v435 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
            let v436 : Async<unit> = v435 v427
            let _v432 = v436 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v437 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
            let v438 : Async<unit> = v437 v427
            let _v432 = v438 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v439 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
            let v440 : Async<unit> = v439 v427
            let _v432 = v440 
            #endif
#if FABLE_COMPILER_PYTHON
            let v441 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
            let v442 : Async<unit> = v441 v427
            let _v432 = v442 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v443 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
            let v444 : Async<unit> = v443 v427
            let _v432 = v444 
            #endif
#else
            let v445 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
            let v446 : Async<unit> = v445 v427
            let _v432 = v446 
            #endif
            let v447 : Async<unit> = _v432 
            do! v447 
            return true 
            with ex ->
                let v452 : exn = ex
                let v453 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v454 : string = $"%A{v452}"
                let _v453 = v454 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v457 : string = $"%A{v452}"
                let _v453 = v457 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v460 : string = $"%A{v452}"
                let _v453 = v460 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v463 : string = $"%A{v452}"
                let _v453 = v463 
                #endif
#if FABLE_COMPILER_PYTHON
                let v466 : string = $"%A{v452}"
                let _v453 = v466 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v469 : string = $"%A{v452}"
                let _v453 = v469 
                #endif
#else
                let v472 : string = $"{v452.GetType ()}: {v452.Message}"
                let _v453 = v472 
                #endif
                let v473 : string = _v453 
                let v478 : unit = ()
                let v479 : (unit -> unit) = closure5(v1, v473)
                let v480 : unit = (fun () -> v479 (); v478) ()
                return false 
                (*
                ()
            *)
            (*
            let v520 : bool = *)
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v521 : Async<bool> = _v352 
    let _v2 = v521 
    #endif
#else
    let v522 : unit = ()
    let _v522 =
        async {
            let v523 : Async<System.Threading.CancellationToken> = Async.CancellationToken
            let! v523 = v523 
            let v524 : System.Threading.CancellationToken = v523 
            let v525 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v526 : System_Net_Sockets_TcpClient = null |> unbox<System_Net_Sockets_TcpClient>
            let _v525 = v526 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v529 : System_Net_Sockets_TcpClient = null |> unbox<System_Net_Sockets_TcpClient>
            let _v525 = v529 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v532 : System_Net_Sockets_TcpClient = null |> unbox<System_Net_Sockets_TcpClient>
            let _v525 = v532 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v535 : System_Net_Sockets_TcpClient = null |> unbox<System_Net_Sockets_TcpClient>
            let _v525 = v535 
            #endif
#if FABLE_COMPILER_PYTHON
            let v538 : System_Net_Sockets_TcpClient = null |> unbox<System_Net_Sockets_TcpClient>
            let _v525 = v538 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v541 : System_Net_Sockets_TcpClient = null |> unbox<System_Net_Sockets_TcpClient>
            let _v525 = v541 
            #endif
#else
            let v544 : System_Net_Sockets_TcpClient = new System_Net_Sockets_TcpClient ()
            let _v525 = v544 
            #endif
            let v545 : System_Net_Sockets_TcpClient = _v525 
            use v545 = v545 
            let v550 : System_Net_Sockets_TcpClient = v545 
            try
            let v551 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v552 : System.Threading.Tasks.ValueTask = null |> unbox<System.Threading.Tasks.ValueTask>
            let _v551 = v552 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v555 : System.Threading.Tasks.ValueTask = null |> unbox<System.Threading.Tasks.ValueTask>
            let _v551 = v555 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v558 : System.Threading.Tasks.ValueTask = null |> unbox<System.Threading.Tasks.ValueTask>
            let _v551 = v558 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v561 : System.Threading.Tasks.ValueTask = null |> unbox<System.Threading.Tasks.ValueTask>
            let _v551 = v561 
            #endif
#if FABLE_COMPILER_PYTHON
            let v564 : System.Threading.Tasks.ValueTask = null |> unbox<System.Threading.Tasks.ValueTask>
            let _v551 = v564 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v567 : System.Threading.Tasks.ValueTask = null |> unbox<System.Threading.Tasks.ValueTask>
            let _v551 = v567 
            #endif
#else
            let v570 : System.Threading.Tasks.ValueTask = v550.ConnectAsync (v0, v1, v524)
            let _v551 = v570 
            #endif
            let v571 : System.Threading.Tasks.ValueTask = _v551 
            let v576 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v577 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
            let _v576 = v577 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v580 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
            let _v576 = v580 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v583 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
            let _v576 = v583 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v586 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
            let _v576 = v586 
            #endif
#if FABLE_COMPILER_PYTHON
            let v589 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
            let _v576 = v589 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v592 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
            let _v576 = v592 
            #endif
#else
            let v595 : (unit -> System.Threading.Tasks.Task) = v571.AsTask
            let v596 : System.Threading.Tasks.Task = v595 ()
            let _v576 = v596 
            #endif
            let v597 : System.Threading.Tasks.Task = _v576 
            let v602 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v603 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
            let v604 : Async<unit> = v603 v597
            let _v602 = v604 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v605 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
            let v606 : Async<unit> = v605 v597
            let _v602 = v606 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v607 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
            let v608 : Async<unit> = v607 v597
            let _v602 = v608 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v609 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
            let v610 : Async<unit> = v609 v597
            let _v602 = v610 
            #endif
#if FABLE_COMPILER_PYTHON
            let v611 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
            let v612 : Async<unit> = v611 v597
            let _v602 = v612 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v613 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
            let v614 : Async<unit> = v613 v597
            let _v602 = v614 
            #endif
#else
            let v615 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
            let v616 : Async<unit> = v615 v597
            let _v602 = v616 
            #endif
            let v617 : Async<unit> = _v602 
            do! v617 
            return true 
            with ex ->
                let v622 : exn = ex
                let v623 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v624 : string = $"%A{v622}"
                let _v623 = v624 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v627 : string = $"%A{v622}"
                let _v623 = v627 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v630 : string = $"%A{v622}"
                let _v623 = v630 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v633 : string = $"%A{v622}"
                let _v623 = v633 
                #endif
#if FABLE_COMPILER_PYTHON
                let v636 : string = $"%A{v622}"
                let _v623 = v636 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v639 : string = $"%A{v622}"
                let _v623 = v639 
                #endif
#else
                let v642 : string = $"{v622.GetType ()}: {v622.Message}"
                let _v623 = v642 
                #endif
                let v643 : string = _v623 
                let v648 : unit = ()
                let v649 : (unit -> unit) = closure5(v1, v643)
                let v650 : unit = (fun () -> v649 (); v648) ()
                return false 
                (*
                ()
            *)
            (*
            let v690 : bool = *)
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v691 : Async<bool> = _v522 
    let _v2 = v691 
    #endif
    let v692 : Async<bool> = _v2 
    v692
and closure4 (v0 : string) (v1 : int32) : Async<bool> =
    method6(v0, v1)
and closure3 () (v0 : string) : (int32 -> Async<bool>) =
    closure4(v0)
and closure14 () (v0 : bool) : US7 =
    US7_0(v0)
and method22 () : (bool -> US7) =
    closure14()
and closure15 () (v0 : exn) : US7 =
    US7_1(v0)
and method23 () : (exn -> US7) =
    closure15()
and method25 (v0 : int32) : string =
    let v1 : string = method14()
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
and method24 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : int32) : string =
    let v9 : string = method25(v8)
    let v10 : int64 = v0.l0
    let v11 : string = "async.run_with_timeout_async"
    let v12 : string = $"{v6} {v7} #{v10} %s{v11} / {v9}"
    method18(v12)
and closure16 (v0 : int32) () : unit =
    let v1 : US0 = US0_0
    let v2 : bool = method7(v1)
    if v2 then
        let v3 : unit = ()
        let v4 : (unit -> unit) = closure0()
        let v5 : unit = (fun () -> v4 (); v3) ()
        let struct (v19 : Mut0, v20 : Mut1, v21 : Mut2, v22 : Mut3, v23 : Mut4, v24 : int64 option) = TraceState.trace_state.Value
        let v37 : string = method8(v19, v20, v21, v22, v23, v24)
        let v38 : string = method12()
        let v39 : string = method24(v19, v20, v21, v22, v23, v24, v37, v38, v0)
        method19(v39)
and method26 () : string =
    
    
    
    
    
    let v0 : string = "Critical"
    let v1 : (unit -> string) = v0.ToLower
    let v2 : string = v1 ()
    let v5 : char = v2.[int 0]
    let v6 : string = method13(v5)
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
    let v105 : string = method15()
    let v106 : string = v104 + v6 
    let v107 : string = v106 + v105 
    let _v7 = v107 
    #endif
#if FABLE_COMPILER_PYTHON
    let v108 : string = "\u001b[91m"
    let v109 : string = method15()
    let v110 : string = v108 + v6 
    let v111 : string = v110 + v109 
    let _v7 = v111 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v112 : string = "\u001b[91m"
    let v113 : string = method15()
    let v114 : string = v112 + v6 
    let v115 : string = v114 + v113 
    let _v7 = v115 
    #endif
#else
    let v116 : string = "\u001b[91m"
    let v117 : string = method15()
    let v118 : string = v116 + v6 
    let v119 : string = v118 + v117 
    let _v7 = v119 
    #endif
    let v120 : string = _v7 
    v120
and method28 (v0 : int32, v1 : string) : string =
    let v2 : string = method14()
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
and method27 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : int32, v9 : string) : string =
    let v10 : string = method28(v8, v9)
    let v11 : int64 = v0.l0
    let v12 : string = "async.run_with_timeout_async**"
    let v13 : string = $"{v6} {v7} #{v11} %s{v12} / {v10}"
    method18(v13)
and closure17 (v0 : int32, v1 : exn) () : unit =
    let v2 : US0 = US0_4
    let v3 : bool = method7(v2)
    if v3 then
        let v4 : unit = ()
        let v5 : (unit -> unit) = closure0()
        let v6 : unit = (fun () -> v5 (); v4) ()
        let struct (v20 : Mut0, v21 : Mut1, v22 : Mut2, v23 : Mut3, v24 : Mut4, v25 : int64 option) = TraceState.trace_state.Value
        let v38 : string = method8(v20, v21, v22, v23, v24, v25)
        let v39 : string = method26()
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
        let v65 : string = method27(v20, v21, v22, v23, v24, v25, v38, v39, v0, v60)
        method19(v65)
and method21 (v0 : int32, v1 : Async<bool>) : Async<US6> =
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
            let v14 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v15 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v14 = v15 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v18 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v14 = v18 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v21 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v14 = v21 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v24 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v14 = v24 
            #endif
#if FABLE_COMPILER_PYTHON
            let v25 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v14 = v25 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v26 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v14 = v26 
            #endif
#else
            let v27 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v14 = v27 
            #endif
            let v28 : Async<Async<bool>> = _v14 
            let! v28 = v28 
            let v33 : Async<bool> = v28 
            let v34 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v35 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v36 : Async<Choice<bool, exn>> = v35 v33
            let _v34 = v36 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v37 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v38 : Async<Choice<bool, exn>> = v37 v33
            let _v34 = v38 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v39 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v40 : Async<Choice<bool, exn>> = v39 v33
            let _v34 = v40 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v41 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v42 : Async<Choice<bool, exn>> = v41 v33
            let _v34 = v42 
            #endif
#if FABLE_COMPILER_PYTHON
            let v43 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v44 : Async<Choice<bool, exn>> = v43 v33
            let _v34 = v44 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v45 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v46 : Async<Choice<bool, exn>> = v45 v33
            let _v34 = v46 
            #endif
#else
            let v47 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v48 : Async<Choice<bool, exn>> = v47 v33
            let _v34 = v48 
            #endif
            let v49 : Async<Choice<bool, exn>> = _v34 
            let v54 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v55 : Async<US7> = null |> unbox<Async<US7>>
            let _v54 = v55 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v58 : Async<US7> = null |> unbox<Async<US7>>
            let _v54 = v58 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v61 : Async<US7> = null |> unbox<Async<US7>>
            let _v54 = v61 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v64 : unit = ()
            let _v64 =
                async {
                    let! v49 = v49 
                    let v65 : Choice<bool, exn> = v49 
                    let v66 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v67 : US7 = null |> unbox<US7>
                    let _v66 = v67 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v70 : US7 = null |> unbox<US7>
                    let _v66 = v70 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v73 : US7 = null |> unbox<US7>
                    let _v66 = v73 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v76 : US7 = null |> unbox<US7>
                    let _v66 = v76 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v79 : US7 = null |> unbox<US7>
                    let _v66 = v79 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v82 : (bool -> US7) = method22()
                    let v83 : (exn -> US7) = method23()
                    let v84 : US7 = match v65 with Choice1Of2 x -> v82 x | Choice2Of2 x -> v83 x
                    let _v66 = v84 
                    #endif
#else
                    let v85 : (bool -> US7) = method22()
                    let v86 : (exn -> US7) = method23()
                    let v87 : US7 = match v65 with Choice1Of2 x -> v85 x | Choice2Of2 x -> v86 x
                    let _v66 = v87 
                    #endif
                    let v88 : US7 = _v66 
                    return v88 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v93 : Async<US7> = _v64 
            let _v54 = v93 
            #endif
#if FABLE_COMPILER_PYTHON
            let v94 : unit = ()
            let _v94 =
                async {
                    let! v49 = v49 
                    let v95 : Choice<bool, exn> = v49 
                    let v96 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v97 : US7 = null |> unbox<US7>
                    let _v96 = v97 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v100 : US7 = null |> unbox<US7>
                    let _v96 = v100 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v103 : US7 = null |> unbox<US7>
                    let _v96 = v103 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v106 : US7 = null |> unbox<US7>
                    let _v96 = v106 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v109 : US7 = null |> unbox<US7>
                    let _v96 = v109 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v112 : (bool -> US7) = method22()
                    let v113 : (exn -> US7) = method23()
                    let v114 : US7 = match v95 with Choice1Of2 x -> v112 x | Choice2Of2 x -> v113 x
                    let _v96 = v114 
                    #endif
#else
                    let v115 : (bool -> US7) = method22()
                    let v116 : (exn -> US7) = method23()
                    let v117 : US7 = match v95 with Choice1Of2 x -> v115 x | Choice2Of2 x -> v116 x
                    let _v96 = v117 
                    #endif
                    let v118 : US7 = _v96 
                    return v118 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v123 : Async<US7> = _v94 
            let _v54 = v123 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v124 : unit = ()
            let _v124 =
                async {
                    let! v49 = v49 
                    let v125 : Choice<bool, exn> = v49 
                    let v126 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v127 : US7 = null |> unbox<US7>
                    let _v126 = v127 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v130 : US7 = null |> unbox<US7>
                    let _v126 = v130 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v133 : US7 = null |> unbox<US7>
                    let _v126 = v133 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v136 : US7 = null |> unbox<US7>
                    let _v126 = v136 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v139 : US7 = null |> unbox<US7>
                    let _v126 = v139 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v142 : (bool -> US7) = method22()
                    let v143 : (exn -> US7) = method23()
                    let v144 : US7 = match v125 with Choice1Of2 x -> v142 x | Choice2Of2 x -> v143 x
                    let _v126 = v144 
                    #endif
#else
                    let v145 : (bool -> US7) = method22()
                    let v146 : (exn -> US7) = method23()
                    let v147 : US7 = match v125 with Choice1Of2 x -> v145 x | Choice2Of2 x -> v146 x
                    let _v126 = v147 
                    #endif
                    let v148 : US7 = _v126 
                    return v148 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v153 : Async<US7> = _v124 
            let _v54 = v153 
            #endif
#else
            let v154 : unit = ()
            let _v154 =
                async {
                    let! v49 = v49 
                    let v155 : Choice<bool, exn> = v49 
                    let v156 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v157 : US7 = null |> unbox<US7>
                    let _v156 = v157 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v160 : US7 = null |> unbox<US7>
                    let _v156 = v160 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v163 : US7 = null |> unbox<US7>
                    let _v156 = v163 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v166 : US7 = null |> unbox<US7>
                    let _v156 = v166 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v169 : US7 = null |> unbox<US7>
                    let _v156 = v169 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v172 : (bool -> US7) = method22()
                    let v173 : (exn -> US7) = method23()
                    let v174 : US7 = match v155 with Choice1Of2 x -> v172 x | Choice2Of2 x -> v173 x
                    let _v156 = v174 
                    #endif
#else
                    let v175 : (bool -> US7) = method22()
                    let v176 : (exn -> US7) = method23()
                    let v177 : US7 = match v155 with Choice1Of2 x -> v175 x | Choice2Of2 x -> v176 x
                    let _v156 = v177 
                    #endif
                    let v178 : US7 = _v156 
                    return v178 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v183 : Async<US7> = _v154 
            let _v54 = v183 
            #endif
            let v184 : Async<US7> = _v54 
            let v189 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v190 : Async<US8> = null |> unbox<Async<US8>>
            let _v189 = v190 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v193 : Async<US8> = null |> unbox<Async<US8>>
            let _v189 = v193 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v196 : Async<US8> = null |> unbox<Async<US8>>
            let _v189 = v196 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v199 : unit = ()
            let _v199 =
                async {
                    let! v184 = v184 
                    let v200 : US7 = v184 
                    let v206 : US8 =
                        match v200 with
                        | US7_0(v201) -> (* C1of2 *)
                            US8_0(v201)
                        | US7_1(v203) -> (* C2of2 *)
                            US8_1(v203)
                    return v206 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v207 : Async<US8> = _v199 
            let _v189 = v207 
            #endif
#if FABLE_COMPILER_PYTHON
            let v208 : unit = ()
            let _v208 =
                async {
                    let! v184 = v184 
                    let v209 : US7 = v184 
                    let v215 : US8 =
                        match v209 with
                        | US7_0(v210) -> (* C1of2 *)
                            US8_0(v210)
                        | US7_1(v212) -> (* C2of2 *)
                            US8_1(v212)
                    return v215 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v216 : Async<US8> = _v208 
            let _v189 = v216 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v217 : unit = ()
            let _v217 =
                async {
                    let! v184 = v184 
                    let v218 : US7 = v184 
                    let v224 : US8 =
                        match v218 with
                        | US7_0(v219) -> (* C1of2 *)
                            US8_0(v219)
                        | US7_1(v221) -> (* C2of2 *)
                            US8_1(v221)
                    return v224 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v225 : Async<US8> = _v217 
            let _v189 = v225 
            #endif
#else
            let v226 : unit = ()
            let _v226 =
                async {
                    let! v184 = v184 
                    let v227 : US7 = v184 
                    let v233 : US8 =
                        match v227 with
                        | US7_0(v228) -> (* C1of2 *)
                            US8_0(v228)
                        | US7_1(v230) -> (* C2of2 *)
                            US8_1(v230)
                    return v233 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v234 : Async<US8> = _v226 
            let _v189 = v234 
            #endif
            let v235 : Async<US8> = _v189 
            let v240 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v241 : Async<US6> = null |> unbox<Async<US6>>
            let _v240 = v241 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v244 : Async<US6> = null |> unbox<Async<US6>>
            let _v240 = v244 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v247 : Async<US6> = null |> unbox<Async<US6>>
            let _v240 = v247 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v250 : unit = ()
            let _v250 =
                async {
                    let! v235 = v235 
                    let v251 : US8 = v235 
                    let v375 : US6 =
                        match v251 with
                        | US8_1(v254) -> (* Error *)
                            let v255 : string = $"%A{v254}"
                            let v258 : string = "System.TimeoutException"
                            let v259 : bool = v255.Contains v258 
                            if v259 then
                                let v262 : unit = ()
                                let v263 : (unit -> unit) = closure16(v0)
                                let v264 : unit = (fun () -> v263 (); v262) ()
                                US6_1
                            else
                                let v305 : unit = ()
                                let v306 : (unit -> unit) = closure17(v0, v254)
                                let v307 : unit = (fun () -> v306 (); v305) ()
                                US6_1
                        | US8_0(v252) -> (* Ok *)
                            US6_0(v252)
                    return v375 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v376 : Async<US6> = _v250 
            let _v240 = v376 
            #endif
#if FABLE_COMPILER_PYTHON
            let v377 : unit = ()
            let _v377 =
                async {
                    let! v235 = v235 
                    let v378 : US8 = v235 
                    let v502 : US6 =
                        match v378 with
                        | US8_1(v381) -> (* Error *)
                            let v382 : string = $"%A{v381}"
                            let v385 : string = "System.TimeoutException"
                            let v386 : bool = v382.Contains v385 
                            if v386 then
                                let v389 : unit = ()
                                let v390 : (unit -> unit) = closure16(v0)
                                let v391 : unit = (fun () -> v390 (); v389) ()
                                US6_1
                            else
                                let v432 : unit = ()
                                let v433 : (unit -> unit) = closure17(v0, v381)
                                let v434 : unit = (fun () -> v433 (); v432) ()
                                US6_1
                        | US8_0(v379) -> (* Ok *)
                            US6_0(v379)
                    return v502 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v503 : Async<US6> = _v377 
            let _v240 = v503 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v504 : unit = ()
            let _v504 =
                async {
                    let! v235 = v235 
                    let v505 : US8 = v235 
                    let v629 : US6 =
                        match v505 with
                        | US8_1(v508) -> (* Error *)
                            let v509 : string = $"%A{v508}"
                            let v512 : string = "System.TimeoutException"
                            let v513 : bool = v509.Contains v512 
                            if v513 then
                                let v516 : unit = ()
                                let v517 : (unit -> unit) = closure16(v0)
                                let v518 : unit = (fun () -> v517 (); v516) ()
                                US6_1
                            else
                                let v559 : unit = ()
                                let v560 : (unit -> unit) = closure17(v0, v508)
                                let v561 : unit = (fun () -> v560 (); v559) ()
                                US6_1
                        | US8_0(v506) -> (* Ok *)
                            US6_0(v506)
                    return v629 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v630 : Async<US6> = _v504 
            let _v240 = v630 
            #endif
#else
            let v631 : unit = ()
            let _v631 =
                async {
                    let! v235 = v235 
                    let v632 : US8 = v235 
                    let v756 : US6 =
                        match v632 with
                        | US8_1(v635) -> (* Error *)
                            let v636 : string = $"%A{v635}"
                            let v639 : string = "System.TimeoutException"
                            let v640 : bool = v636.Contains v639 
                            if v640 then
                                let v643 : unit = ()
                                let v644 : (unit -> unit) = closure16(v0)
                                let v645 : unit = (fun () -> v644 (); v643) ()
                                US6_1
                            else
                                let v686 : unit = ()
                                let v687 : (unit -> unit) = closure17(v0, v635)
                                let v688 : unit = (fun () -> v687 (); v686) ()
                                US6_1
                        | US8_0(v633) -> (* Ok *)
                            US6_0(v633)
                    return v756 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v757 : Async<US6> = _v631 
            let _v240 = v757 
            #endif
            let v758 : Async<US6> = _v240 
            return! v758 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v763 : Async<US6> = _v13 
    let _v3 = v763 
    #endif
#if FABLE_COMPILER_PYTHON
    let v764 : unit = ()
    let _v764 =
        async {
            let v765 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v766 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v765 = v766 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v769 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v765 = v769 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v772 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v765 = v772 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v775 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v765 = v775 
            #endif
#if FABLE_COMPILER_PYTHON
            let v776 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v765 = v776 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v777 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v765 = v777 
            #endif
#else
            let v778 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v765 = v778 
            #endif
            let v779 : Async<Async<bool>> = _v765 
            let! v779 = v779 
            let v784 : Async<bool> = v779 
            let v785 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v786 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v787 : Async<Choice<bool, exn>> = v786 v784
            let _v785 = v787 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v788 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v789 : Async<Choice<bool, exn>> = v788 v784
            let _v785 = v789 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v790 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v791 : Async<Choice<bool, exn>> = v790 v784
            let _v785 = v791 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v792 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v793 : Async<Choice<bool, exn>> = v792 v784
            let _v785 = v793 
            #endif
#if FABLE_COMPILER_PYTHON
            let v794 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v795 : Async<Choice<bool, exn>> = v794 v784
            let _v785 = v795 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v796 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v797 : Async<Choice<bool, exn>> = v796 v784
            let _v785 = v797 
            #endif
#else
            let v798 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v799 : Async<Choice<bool, exn>> = v798 v784
            let _v785 = v799 
            #endif
            let v800 : Async<Choice<bool, exn>> = _v785 
            let v805 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v806 : Async<US7> = null |> unbox<Async<US7>>
            let _v805 = v806 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v809 : Async<US7> = null |> unbox<Async<US7>>
            let _v805 = v809 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v812 : Async<US7> = null |> unbox<Async<US7>>
            let _v805 = v812 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v815 : unit = ()
            let _v815 =
                async {
                    let! v800 = v800 
                    let v816 : Choice<bool, exn> = v800 
                    let v817 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v818 : US7 = null |> unbox<US7>
                    let _v817 = v818 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v821 : US7 = null |> unbox<US7>
                    let _v817 = v821 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v824 : US7 = null |> unbox<US7>
                    let _v817 = v824 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v827 : US7 = null |> unbox<US7>
                    let _v817 = v827 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v830 : US7 = null |> unbox<US7>
                    let _v817 = v830 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v833 : (bool -> US7) = method22()
                    let v834 : (exn -> US7) = method23()
                    let v835 : US7 = match v816 with Choice1Of2 x -> v833 x | Choice2Of2 x -> v834 x
                    let _v817 = v835 
                    #endif
#else
                    let v836 : (bool -> US7) = method22()
                    let v837 : (exn -> US7) = method23()
                    let v838 : US7 = match v816 with Choice1Of2 x -> v836 x | Choice2Of2 x -> v837 x
                    let _v817 = v838 
                    #endif
                    let v839 : US7 = _v817 
                    return v839 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v844 : Async<US7> = _v815 
            let _v805 = v844 
            #endif
#if FABLE_COMPILER_PYTHON
            let v845 : unit = ()
            let _v845 =
                async {
                    let! v800 = v800 
                    let v846 : Choice<bool, exn> = v800 
                    let v847 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v848 : US7 = null |> unbox<US7>
                    let _v847 = v848 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v851 : US7 = null |> unbox<US7>
                    let _v847 = v851 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v854 : US7 = null |> unbox<US7>
                    let _v847 = v854 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v857 : US7 = null |> unbox<US7>
                    let _v847 = v857 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v860 : US7 = null |> unbox<US7>
                    let _v847 = v860 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v863 : (bool -> US7) = method22()
                    let v864 : (exn -> US7) = method23()
                    let v865 : US7 = match v846 with Choice1Of2 x -> v863 x | Choice2Of2 x -> v864 x
                    let _v847 = v865 
                    #endif
#else
                    let v866 : (bool -> US7) = method22()
                    let v867 : (exn -> US7) = method23()
                    let v868 : US7 = match v846 with Choice1Of2 x -> v866 x | Choice2Of2 x -> v867 x
                    let _v847 = v868 
                    #endif
                    let v869 : US7 = _v847 
                    return v869 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v874 : Async<US7> = _v845 
            let _v805 = v874 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v875 : unit = ()
            let _v875 =
                async {
                    let! v800 = v800 
                    let v876 : Choice<bool, exn> = v800 
                    let v877 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v878 : US7 = null |> unbox<US7>
                    let _v877 = v878 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v881 : US7 = null |> unbox<US7>
                    let _v877 = v881 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v884 : US7 = null |> unbox<US7>
                    let _v877 = v884 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v887 : US7 = null |> unbox<US7>
                    let _v877 = v887 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v890 : US7 = null |> unbox<US7>
                    let _v877 = v890 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v893 : (bool -> US7) = method22()
                    let v894 : (exn -> US7) = method23()
                    let v895 : US7 = match v876 with Choice1Of2 x -> v893 x | Choice2Of2 x -> v894 x
                    let _v877 = v895 
                    #endif
#else
                    let v896 : (bool -> US7) = method22()
                    let v897 : (exn -> US7) = method23()
                    let v898 : US7 = match v876 with Choice1Of2 x -> v896 x | Choice2Of2 x -> v897 x
                    let _v877 = v898 
                    #endif
                    let v899 : US7 = _v877 
                    return v899 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v904 : Async<US7> = _v875 
            let _v805 = v904 
            #endif
#else
            let v905 : unit = ()
            let _v905 =
                async {
                    let! v800 = v800 
                    let v906 : Choice<bool, exn> = v800 
                    let v907 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v908 : US7 = null |> unbox<US7>
                    let _v907 = v908 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v911 : US7 = null |> unbox<US7>
                    let _v907 = v911 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v914 : US7 = null |> unbox<US7>
                    let _v907 = v914 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v917 : US7 = null |> unbox<US7>
                    let _v907 = v917 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v920 : US7 = null |> unbox<US7>
                    let _v907 = v920 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v923 : (bool -> US7) = method22()
                    let v924 : (exn -> US7) = method23()
                    let v925 : US7 = match v906 with Choice1Of2 x -> v923 x | Choice2Of2 x -> v924 x
                    let _v907 = v925 
                    #endif
#else
                    let v926 : (bool -> US7) = method22()
                    let v927 : (exn -> US7) = method23()
                    let v928 : US7 = match v906 with Choice1Of2 x -> v926 x | Choice2Of2 x -> v927 x
                    let _v907 = v928 
                    #endif
                    let v929 : US7 = _v907 
                    return v929 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v934 : Async<US7> = _v905 
            let _v805 = v934 
            #endif
            let v935 : Async<US7> = _v805 
            let v940 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v941 : Async<US8> = null |> unbox<Async<US8>>
            let _v940 = v941 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v944 : Async<US8> = null |> unbox<Async<US8>>
            let _v940 = v944 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v947 : Async<US8> = null |> unbox<Async<US8>>
            let _v940 = v947 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v950 : unit = ()
            let _v950 =
                async {
                    let! v935 = v935 
                    let v951 : US7 = v935 
                    let v957 : US8 =
                        match v951 with
                        | US7_0(v952) -> (* C1of2 *)
                            US8_0(v952)
                        | US7_1(v954) -> (* C2of2 *)
                            US8_1(v954)
                    return v957 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v958 : Async<US8> = _v950 
            let _v940 = v958 
            #endif
#if FABLE_COMPILER_PYTHON
            let v959 : unit = ()
            let _v959 =
                async {
                    let! v935 = v935 
                    let v960 : US7 = v935 
                    let v966 : US8 =
                        match v960 with
                        | US7_0(v961) -> (* C1of2 *)
                            US8_0(v961)
                        | US7_1(v963) -> (* C2of2 *)
                            US8_1(v963)
                    return v966 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v967 : Async<US8> = _v959 
            let _v940 = v967 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v968 : unit = ()
            let _v968 =
                async {
                    let! v935 = v935 
                    let v969 : US7 = v935 
                    let v975 : US8 =
                        match v969 with
                        | US7_0(v970) -> (* C1of2 *)
                            US8_0(v970)
                        | US7_1(v972) -> (* C2of2 *)
                            US8_1(v972)
                    return v975 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v976 : Async<US8> = _v968 
            let _v940 = v976 
            #endif
#else
            let v977 : unit = ()
            let _v977 =
                async {
                    let! v935 = v935 
                    let v978 : US7 = v935 
                    let v984 : US8 =
                        match v978 with
                        | US7_0(v979) -> (* C1of2 *)
                            US8_0(v979)
                        | US7_1(v981) -> (* C2of2 *)
                            US8_1(v981)
                    return v984 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v985 : Async<US8> = _v977 
            let _v940 = v985 
            #endif
            let v986 : Async<US8> = _v940 
            let v991 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v992 : Async<US6> = null |> unbox<Async<US6>>
            let _v991 = v992 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v995 : Async<US6> = null |> unbox<Async<US6>>
            let _v991 = v995 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v998 : Async<US6> = null |> unbox<Async<US6>>
            let _v991 = v998 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1001 : unit = ()
            let _v1001 =
                async {
                    let! v986 = v986 
                    let v1002 : US8 = v986 
                    let v1126 : US6 =
                        match v1002 with
                        | US8_1(v1005) -> (* Error *)
                            let v1006 : string = $"%A{v1005}"
                            let v1009 : string = "System.TimeoutException"
                            let v1010 : bool = v1006.Contains v1009 
                            if v1010 then
                                let v1013 : unit = ()
                                let v1014 : (unit -> unit) = closure16(v0)
                                let v1015 : unit = (fun () -> v1014 (); v1013) ()
                                US6_1
                            else
                                let v1056 : unit = ()
                                let v1057 : (unit -> unit) = closure17(v0, v1005)
                                let v1058 : unit = (fun () -> v1057 (); v1056) ()
                                US6_1
                        | US8_0(v1003) -> (* Ok *)
                            US6_0(v1003)
                    return v1126 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v1127 : Async<US6> = _v1001 
            let _v991 = v1127 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1128 : unit = ()
            let _v1128 =
                async {
                    let! v986 = v986 
                    let v1129 : US8 = v986 
                    let v1253 : US6 =
                        match v1129 with
                        | US8_1(v1132) -> (* Error *)
                            let v1133 : string = $"%A{v1132}"
                            let v1136 : string = "System.TimeoutException"
                            let v1137 : bool = v1133.Contains v1136 
                            if v1137 then
                                let v1140 : unit = ()
                                let v1141 : (unit -> unit) = closure16(v0)
                                let v1142 : unit = (fun () -> v1141 (); v1140) ()
                                US6_1
                            else
                                let v1183 : unit = ()
                                let v1184 : (unit -> unit) = closure17(v0, v1132)
                                let v1185 : unit = (fun () -> v1184 (); v1183) ()
                                US6_1
                        | US8_0(v1130) -> (* Ok *)
                            US6_0(v1130)
                    return v1253 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v1254 : Async<US6> = _v1128 
            let _v991 = v1254 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1255 : unit = ()
            let _v1255 =
                async {
                    let! v986 = v986 
                    let v1256 : US8 = v986 
                    let v1380 : US6 =
                        match v1256 with
                        | US8_1(v1259) -> (* Error *)
                            let v1260 : string = $"%A{v1259}"
                            let v1263 : string = "System.TimeoutException"
                            let v1264 : bool = v1260.Contains v1263 
                            if v1264 then
                                let v1267 : unit = ()
                                let v1268 : (unit -> unit) = closure16(v0)
                                let v1269 : unit = (fun () -> v1268 (); v1267) ()
                                US6_1
                            else
                                let v1310 : unit = ()
                                let v1311 : (unit -> unit) = closure17(v0, v1259)
                                let v1312 : unit = (fun () -> v1311 (); v1310) ()
                                US6_1
                        | US8_0(v1257) -> (* Ok *)
                            US6_0(v1257)
                    return v1380 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v1381 : Async<US6> = _v1255 
            let _v991 = v1381 
            #endif
#else
            let v1382 : unit = ()
            let _v1382 =
                async {
                    let! v986 = v986 
                    let v1383 : US8 = v986 
                    let v1507 : US6 =
                        match v1383 with
                        | US8_1(v1386) -> (* Error *)
                            let v1387 : string = $"%A{v1386}"
                            let v1390 : string = "System.TimeoutException"
                            let v1391 : bool = v1387.Contains v1390 
                            if v1391 then
                                let v1394 : unit = ()
                                let v1395 : (unit -> unit) = closure16(v0)
                                let v1396 : unit = (fun () -> v1395 (); v1394) ()
                                US6_1
                            else
                                let v1437 : unit = ()
                                let v1438 : (unit -> unit) = closure17(v0, v1386)
                                let v1439 : unit = (fun () -> v1438 (); v1437) ()
                                US6_1
                        | US8_0(v1384) -> (* Ok *)
                            US6_0(v1384)
                    return v1507 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v1508 : Async<US6> = _v1382 
            let _v991 = v1508 
            #endif
            let v1509 : Async<US6> = _v991 
            return! v1509 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v1514 : Async<US6> = _v764 
    let _v3 = v1514 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1515 : unit = ()
    let _v1515 =
        async {
            let v1516 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1517 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v1516 = v1517 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1520 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v1516 = v1520 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1523 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v1516 = v1523 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1526 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v1516 = v1526 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1527 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v1516 = v1527 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1528 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v1516 = v1528 
            #endif
#else
            let v1529 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v1516 = v1529 
            #endif
            let v1530 : Async<Async<bool>> = _v1516 
            let! v1530 = v1530 
            let v1535 : Async<bool> = v1530 
            let v1536 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1537 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v1538 : Async<Choice<bool, exn>> = v1537 v1535
            let _v1536 = v1538 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1539 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v1540 : Async<Choice<bool, exn>> = v1539 v1535
            let _v1536 = v1540 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1541 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v1542 : Async<Choice<bool, exn>> = v1541 v1535
            let _v1536 = v1542 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1543 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v1544 : Async<Choice<bool, exn>> = v1543 v1535
            let _v1536 = v1544 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1545 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v1546 : Async<Choice<bool, exn>> = v1545 v1535
            let _v1536 = v1546 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1547 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v1548 : Async<Choice<bool, exn>> = v1547 v1535
            let _v1536 = v1548 
            #endif
#else
            let v1549 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v1550 : Async<Choice<bool, exn>> = v1549 v1535
            let _v1536 = v1550 
            #endif
            let v1551 : Async<Choice<bool, exn>> = _v1536 
            let v1556 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1557 : Async<US7> = null |> unbox<Async<US7>>
            let _v1556 = v1557 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1560 : Async<US7> = null |> unbox<Async<US7>>
            let _v1556 = v1560 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1563 : Async<US7> = null |> unbox<Async<US7>>
            let _v1556 = v1563 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1566 : unit = ()
            let _v1566 =
                async {
                    let! v1551 = v1551 
                    let v1567 : Choice<bool, exn> = v1551 
                    let v1568 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1569 : US7 = null |> unbox<US7>
                    let _v1568 = v1569 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v1572 : US7 = null |> unbox<US7>
                    let _v1568 = v1572 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1575 : US7 = null |> unbox<US7>
                    let _v1568 = v1575 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v1578 : US7 = null |> unbox<US7>
                    let _v1568 = v1578 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v1581 : US7 = null |> unbox<US7>
                    let _v1568 = v1581 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v1584 : (bool -> US7) = method22()
                    let v1585 : (exn -> US7) = method23()
                    let v1586 : US7 = match v1567 with Choice1Of2 x -> v1584 x | Choice2Of2 x -> v1585 x
                    let _v1568 = v1586 
                    #endif
#else
                    let v1587 : (bool -> US7) = method22()
                    let v1588 : (exn -> US7) = method23()
                    let v1589 : US7 = match v1567 with Choice1Of2 x -> v1587 x | Choice2Of2 x -> v1588 x
                    let _v1568 = v1589 
                    #endif
                    let v1590 : US7 = _v1568 
                    return v1590 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v1595 : Async<US7> = _v1566 
            let _v1556 = v1595 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1596 : unit = ()
            let _v1596 =
                async {
                    let! v1551 = v1551 
                    let v1597 : Choice<bool, exn> = v1551 
                    let v1598 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1599 : US7 = null |> unbox<US7>
                    let _v1598 = v1599 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v1602 : US7 = null |> unbox<US7>
                    let _v1598 = v1602 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1605 : US7 = null |> unbox<US7>
                    let _v1598 = v1605 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v1608 : US7 = null |> unbox<US7>
                    let _v1598 = v1608 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v1611 : US7 = null |> unbox<US7>
                    let _v1598 = v1611 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v1614 : (bool -> US7) = method22()
                    let v1615 : (exn -> US7) = method23()
                    let v1616 : US7 = match v1597 with Choice1Of2 x -> v1614 x | Choice2Of2 x -> v1615 x
                    let _v1598 = v1616 
                    #endif
#else
                    let v1617 : (bool -> US7) = method22()
                    let v1618 : (exn -> US7) = method23()
                    let v1619 : US7 = match v1597 with Choice1Of2 x -> v1617 x | Choice2Of2 x -> v1618 x
                    let _v1598 = v1619 
                    #endif
                    let v1620 : US7 = _v1598 
                    return v1620 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v1625 : Async<US7> = _v1596 
            let _v1556 = v1625 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1626 : unit = ()
            let _v1626 =
                async {
                    let! v1551 = v1551 
                    let v1627 : Choice<bool, exn> = v1551 
                    let v1628 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1629 : US7 = null |> unbox<US7>
                    let _v1628 = v1629 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v1632 : US7 = null |> unbox<US7>
                    let _v1628 = v1632 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1635 : US7 = null |> unbox<US7>
                    let _v1628 = v1635 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v1638 : US7 = null |> unbox<US7>
                    let _v1628 = v1638 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v1641 : US7 = null |> unbox<US7>
                    let _v1628 = v1641 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v1644 : (bool -> US7) = method22()
                    let v1645 : (exn -> US7) = method23()
                    let v1646 : US7 = match v1627 with Choice1Of2 x -> v1644 x | Choice2Of2 x -> v1645 x
                    let _v1628 = v1646 
                    #endif
#else
                    let v1647 : (bool -> US7) = method22()
                    let v1648 : (exn -> US7) = method23()
                    let v1649 : US7 = match v1627 with Choice1Of2 x -> v1647 x | Choice2Of2 x -> v1648 x
                    let _v1628 = v1649 
                    #endif
                    let v1650 : US7 = _v1628 
                    return v1650 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v1655 : Async<US7> = _v1626 
            let _v1556 = v1655 
            #endif
#else
            let v1656 : unit = ()
            let _v1656 =
                async {
                    let! v1551 = v1551 
                    let v1657 : Choice<bool, exn> = v1551 
                    let v1658 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1659 : US7 = null |> unbox<US7>
                    let _v1658 = v1659 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v1662 : US7 = null |> unbox<US7>
                    let _v1658 = v1662 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1665 : US7 = null |> unbox<US7>
                    let _v1658 = v1665 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v1668 : US7 = null |> unbox<US7>
                    let _v1658 = v1668 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v1671 : US7 = null |> unbox<US7>
                    let _v1658 = v1671 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v1674 : (bool -> US7) = method22()
                    let v1675 : (exn -> US7) = method23()
                    let v1676 : US7 = match v1657 with Choice1Of2 x -> v1674 x | Choice2Of2 x -> v1675 x
                    let _v1658 = v1676 
                    #endif
#else
                    let v1677 : (bool -> US7) = method22()
                    let v1678 : (exn -> US7) = method23()
                    let v1679 : US7 = match v1657 with Choice1Of2 x -> v1677 x | Choice2Of2 x -> v1678 x
                    let _v1658 = v1679 
                    #endif
                    let v1680 : US7 = _v1658 
                    return v1680 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v1685 : Async<US7> = _v1656 
            let _v1556 = v1685 
            #endif
            let v1686 : Async<US7> = _v1556 
            let v1691 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1692 : Async<US8> = null |> unbox<Async<US8>>
            let _v1691 = v1692 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1695 : Async<US8> = null |> unbox<Async<US8>>
            let _v1691 = v1695 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1698 : Async<US8> = null |> unbox<Async<US8>>
            let _v1691 = v1698 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1701 : unit = ()
            let _v1701 =
                async {
                    let! v1686 = v1686 
                    let v1702 : US7 = v1686 
                    let v1708 : US8 =
                        match v1702 with
                        | US7_0(v1703) -> (* C1of2 *)
                            US8_0(v1703)
                        | US7_1(v1705) -> (* C2of2 *)
                            US8_1(v1705)
                    return v1708 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v1709 : Async<US8> = _v1701 
            let _v1691 = v1709 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1710 : unit = ()
            let _v1710 =
                async {
                    let! v1686 = v1686 
                    let v1711 : US7 = v1686 
                    let v1717 : US8 =
                        match v1711 with
                        | US7_0(v1712) -> (* C1of2 *)
                            US8_0(v1712)
                        | US7_1(v1714) -> (* C2of2 *)
                            US8_1(v1714)
                    return v1717 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v1718 : Async<US8> = _v1710 
            let _v1691 = v1718 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1719 : unit = ()
            let _v1719 =
                async {
                    let! v1686 = v1686 
                    let v1720 : US7 = v1686 
                    let v1726 : US8 =
                        match v1720 with
                        | US7_0(v1721) -> (* C1of2 *)
                            US8_0(v1721)
                        | US7_1(v1723) -> (* C2of2 *)
                            US8_1(v1723)
                    return v1726 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v1727 : Async<US8> = _v1719 
            let _v1691 = v1727 
            #endif
#else
            let v1728 : unit = ()
            let _v1728 =
                async {
                    let! v1686 = v1686 
                    let v1729 : US7 = v1686 
                    let v1735 : US8 =
                        match v1729 with
                        | US7_0(v1730) -> (* C1of2 *)
                            US8_0(v1730)
                        | US7_1(v1732) -> (* C2of2 *)
                            US8_1(v1732)
                    return v1735 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v1736 : Async<US8> = _v1728 
            let _v1691 = v1736 
            #endif
            let v1737 : Async<US8> = _v1691 
            let v1742 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1743 : Async<US6> = null |> unbox<Async<US6>>
            let _v1742 = v1743 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1746 : Async<US6> = null |> unbox<Async<US6>>
            let _v1742 = v1746 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1749 : Async<US6> = null |> unbox<Async<US6>>
            let _v1742 = v1749 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1752 : unit = ()
            let _v1752 =
                async {
                    let! v1737 = v1737 
                    let v1753 : US8 = v1737 
                    let v1877 : US6 =
                        match v1753 with
                        | US8_1(v1756) -> (* Error *)
                            let v1757 : string = $"%A{v1756}"
                            let v1760 : string = "System.TimeoutException"
                            let v1761 : bool = v1757.Contains v1760 
                            if v1761 then
                                let v1764 : unit = ()
                                let v1765 : (unit -> unit) = closure16(v0)
                                let v1766 : unit = (fun () -> v1765 (); v1764) ()
                                US6_1
                            else
                                let v1807 : unit = ()
                                let v1808 : (unit -> unit) = closure17(v0, v1756)
                                let v1809 : unit = (fun () -> v1808 (); v1807) ()
                                US6_1
                        | US8_0(v1754) -> (* Ok *)
                            US6_0(v1754)
                    return v1877 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v1878 : Async<US6> = _v1752 
            let _v1742 = v1878 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1879 : unit = ()
            let _v1879 =
                async {
                    let! v1737 = v1737 
                    let v1880 : US8 = v1737 
                    let v2004 : US6 =
                        match v1880 with
                        | US8_1(v1883) -> (* Error *)
                            let v1884 : string = $"%A{v1883}"
                            let v1887 : string = "System.TimeoutException"
                            let v1888 : bool = v1884.Contains v1887 
                            if v1888 then
                                let v1891 : unit = ()
                                let v1892 : (unit -> unit) = closure16(v0)
                                let v1893 : unit = (fun () -> v1892 (); v1891) ()
                                US6_1
                            else
                                let v1934 : unit = ()
                                let v1935 : (unit -> unit) = closure17(v0, v1883)
                                let v1936 : unit = (fun () -> v1935 (); v1934) ()
                                US6_1
                        | US8_0(v1881) -> (* Ok *)
                            US6_0(v1881)
                    return v2004 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v2005 : Async<US6> = _v1879 
            let _v1742 = v2005 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v2006 : unit = ()
            let _v2006 =
                async {
                    let! v1737 = v1737 
                    let v2007 : US8 = v1737 
                    let v2131 : US6 =
                        match v2007 with
                        | US8_1(v2010) -> (* Error *)
                            let v2011 : string = $"%A{v2010}"
                            let v2014 : string = "System.TimeoutException"
                            let v2015 : bool = v2011.Contains v2014 
                            if v2015 then
                                let v2018 : unit = ()
                                let v2019 : (unit -> unit) = closure16(v0)
                                let v2020 : unit = (fun () -> v2019 (); v2018) ()
                                US6_1
                            else
                                let v2061 : unit = ()
                                let v2062 : (unit -> unit) = closure17(v0, v2010)
                                let v2063 : unit = (fun () -> v2062 (); v2061) ()
                                US6_1
                        | US8_0(v2008) -> (* Ok *)
                            US6_0(v2008)
                    return v2131 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v2132 : Async<US6> = _v2006 
            let _v1742 = v2132 
            #endif
#else
            let v2133 : unit = ()
            let _v2133 =
                async {
                    let! v1737 = v1737 
                    let v2134 : US8 = v1737 
                    let v2258 : US6 =
                        match v2134 with
                        | US8_1(v2137) -> (* Error *)
                            let v2138 : string = $"%A{v2137}"
                            let v2141 : string = "System.TimeoutException"
                            let v2142 : bool = v2138.Contains v2141 
                            if v2142 then
                                let v2145 : unit = ()
                                let v2146 : (unit -> unit) = closure16(v0)
                                let v2147 : unit = (fun () -> v2146 (); v2145) ()
                                US6_1
                            else
                                let v2188 : unit = ()
                                let v2189 : (unit -> unit) = closure17(v0, v2137)
                                let v2190 : unit = (fun () -> v2189 (); v2188) ()
                                US6_1
                        | US8_0(v2135) -> (* Ok *)
                            US6_0(v2135)
                    return v2258 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v2259 : Async<US6> = _v2133 
            let _v1742 = v2259 
            #endif
            let v2260 : Async<US6> = _v1742 
            return! v2260 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v2265 : Async<US6> = _v1515 
    let _v3 = v2265 
    #endif
#else
    let v2266 : unit = ()
    let _v2266 =
        async {
            let v2267 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v2268 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v2267 = v2268 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v2271 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v2267 = v2271 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v2274 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v2267 = v2274 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v2277 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v2267 = v2277 
            #endif
#if FABLE_COMPILER_PYTHON
            let v2278 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v2267 = v2278 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v2279 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v2267 = v2279 
            #endif
#else
            let v2280 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v2267 = v2280 
            #endif
            let v2281 : Async<Async<bool>> = _v2267 
            let! v2281 = v2281 
            let v2286 : Async<bool> = v2281 
            let v2287 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v2288 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v2289 : Async<Choice<bool, exn>> = v2288 v2286
            let _v2287 = v2289 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v2290 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v2291 : Async<Choice<bool, exn>> = v2290 v2286
            let _v2287 = v2291 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v2292 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v2293 : Async<Choice<bool, exn>> = v2292 v2286
            let _v2287 = v2293 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v2294 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v2295 : Async<Choice<bool, exn>> = v2294 v2286
            let _v2287 = v2295 
            #endif
#if FABLE_COMPILER_PYTHON
            let v2296 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v2297 : Async<Choice<bool, exn>> = v2296 v2286
            let _v2287 = v2297 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v2298 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v2299 : Async<Choice<bool, exn>> = v2298 v2286
            let _v2287 = v2299 
            #endif
#else
            let v2300 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v2301 : Async<Choice<bool, exn>> = v2300 v2286
            let _v2287 = v2301 
            #endif
            let v2302 : Async<Choice<bool, exn>> = _v2287 
            let v2307 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v2308 : Async<US7> = null |> unbox<Async<US7>>
            let _v2307 = v2308 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v2311 : Async<US7> = null |> unbox<Async<US7>>
            let _v2307 = v2311 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v2314 : Async<US7> = null |> unbox<Async<US7>>
            let _v2307 = v2314 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v2317 : unit = ()
            let _v2317 =
                async {
                    let! v2302 = v2302 
                    let v2318 : Choice<bool, exn> = v2302 
                    let v2319 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v2320 : US7 = null |> unbox<US7>
                    let _v2319 = v2320 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v2323 : US7 = null |> unbox<US7>
                    let _v2319 = v2323 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v2326 : US7 = null |> unbox<US7>
                    let _v2319 = v2326 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v2329 : US7 = null |> unbox<US7>
                    let _v2319 = v2329 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v2332 : US7 = null |> unbox<US7>
                    let _v2319 = v2332 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v2335 : (bool -> US7) = method22()
                    let v2336 : (exn -> US7) = method23()
                    let v2337 : US7 = match v2318 with Choice1Of2 x -> v2335 x | Choice2Of2 x -> v2336 x
                    let _v2319 = v2337 
                    #endif
#else
                    let v2338 : (bool -> US7) = method22()
                    let v2339 : (exn -> US7) = method23()
                    let v2340 : US7 = match v2318 with Choice1Of2 x -> v2338 x | Choice2Of2 x -> v2339 x
                    let _v2319 = v2340 
                    #endif
                    let v2341 : US7 = _v2319 
                    return v2341 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v2346 : Async<US7> = _v2317 
            let _v2307 = v2346 
            #endif
#if FABLE_COMPILER_PYTHON
            let v2347 : unit = ()
            let _v2347 =
                async {
                    let! v2302 = v2302 
                    let v2348 : Choice<bool, exn> = v2302 
                    let v2349 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v2350 : US7 = null |> unbox<US7>
                    let _v2349 = v2350 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v2353 : US7 = null |> unbox<US7>
                    let _v2349 = v2353 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v2356 : US7 = null |> unbox<US7>
                    let _v2349 = v2356 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v2359 : US7 = null |> unbox<US7>
                    let _v2349 = v2359 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v2362 : US7 = null |> unbox<US7>
                    let _v2349 = v2362 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v2365 : (bool -> US7) = method22()
                    let v2366 : (exn -> US7) = method23()
                    let v2367 : US7 = match v2348 with Choice1Of2 x -> v2365 x | Choice2Of2 x -> v2366 x
                    let _v2349 = v2367 
                    #endif
#else
                    let v2368 : (bool -> US7) = method22()
                    let v2369 : (exn -> US7) = method23()
                    let v2370 : US7 = match v2348 with Choice1Of2 x -> v2368 x | Choice2Of2 x -> v2369 x
                    let _v2349 = v2370 
                    #endif
                    let v2371 : US7 = _v2349 
                    return v2371 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v2376 : Async<US7> = _v2347 
            let _v2307 = v2376 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v2377 : unit = ()
            let _v2377 =
                async {
                    let! v2302 = v2302 
                    let v2378 : Choice<bool, exn> = v2302 
                    let v2379 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v2380 : US7 = null |> unbox<US7>
                    let _v2379 = v2380 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v2383 : US7 = null |> unbox<US7>
                    let _v2379 = v2383 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v2386 : US7 = null |> unbox<US7>
                    let _v2379 = v2386 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v2389 : US7 = null |> unbox<US7>
                    let _v2379 = v2389 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v2392 : US7 = null |> unbox<US7>
                    let _v2379 = v2392 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v2395 : (bool -> US7) = method22()
                    let v2396 : (exn -> US7) = method23()
                    let v2397 : US7 = match v2378 with Choice1Of2 x -> v2395 x | Choice2Of2 x -> v2396 x
                    let _v2379 = v2397 
                    #endif
#else
                    let v2398 : (bool -> US7) = method22()
                    let v2399 : (exn -> US7) = method23()
                    let v2400 : US7 = match v2378 with Choice1Of2 x -> v2398 x | Choice2Of2 x -> v2399 x
                    let _v2379 = v2400 
                    #endif
                    let v2401 : US7 = _v2379 
                    return v2401 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v2406 : Async<US7> = _v2377 
            let _v2307 = v2406 
            #endif
#else
            let v2407 : unit = ()
            let _v2407 =
                async {
                    let! v2302 = v2302 
                    let v2408 : Choice<bool, exn> = v2302 
                    let v2409 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v2410 : US7 = null |> unbox<US7>
                    let _v2409 = v2410 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v2413 : US7 = null |> unbox<US7>
                    let _v2409 = v2413 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v2416 : US7 = null |> unbox<US7>
                    let _v2409 = v2416 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v2419 : US7 = null |> unbox<US7>
                    let _v2409 = v2419 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v2422 : US7 = null |> unbox<US7>
                    let _v2409 = v2422 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v2425 : (bool -> US7) = method22()
                    let v2426 : (exn -> US7) = method23()
                    let v2427 : US7 = match v2408 with Choice1Of2 x -> v2425 x | Choice2Of2 x -> v2426 x
                    let _v2409 = v2427 
                    #endif
#else
                    let v2428 : (bool -> US7) = method22()
                    let v2429 : (exn -> US7) = method23()
                    let v2430 : US7 = match v2408 with Choice1Of2 x -> v2428 x | Choice2Of2 x -> v2429 x
                    let _v2409 = v2430 
                    #endif
                    let v2431 : US7 = _v2409 
                    return v2431 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v2436 : Async<US7> = _v2407 
            let _v2307 = v2436 
            #endif
            let v2437 : Async<US7> = _v2307 
            let v2442 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v2443 : Async<US8> = null |> unbox<Async<US8>>
            let _v2442 = v2443 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v2446 : Async<US8> = null |> unbox<Async<US8>>
            let _v2442 = v2446 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v2449 : Async<US8> = null |> unbox<Async<US8>>
            let _v2442 = v2449 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v2452 : unit = ()
            let _v2452 =
                async {
                    let! v2437 = v2437 
                    let v2453 : US7 = v2437 
                    let v2459 : US8 =
                        match v2453 with
                        | US7_0(v2454) -> (* C1of2 *)
                            US8_0(v2454)
                        | US7_1(v2456) -> (* C2of2 *)
                            US8_1(v2456)
                    return v2459 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v2460 : Async<US8> = _v2452 
            let _v2442 = v2460 
            #endif
#if FABLE_COMPILER_PYTHON
            let v2461 : unit = ()
            let _v2461 =
                async {
                    let! v2437 = v2437 
                    let v2462 : US7 = v2437 
                    let v2468 : US8 =
                        match v2462 with
                        | US7_0(v2463) -> (* C1of2 *)
                            US8_0(v2463)
                        | US7_1(v2465) -> (* C2of2 *)
                            US8_1(v2465)
                    return v2468 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v2469 : Async<US8> = _v2461 
            let _v2442 = v2469 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v2470 : unit = ()
            let _v2470 =
                async {
                    let! v2437 = v2437 
                    let v2471 : US7 = v2437 
                    let v2477 : US8 =
                        match v2471 with
                        | US7_0(v2472) -> (* C1of2 *)
                            US8_0(v2472)
                        | US7_1(v2474) -> (* C2of2 *)
                            US8_1(v2474)
                    return v2477 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v2478 : Async<US8> = _v2470 
            let _v2442 = v2478 
            #endif
#else
            let v2479 : unit = ()
            let _v2479 =
                async {
                    let! v2437 = v2437 
                    let v2480 : US7 = v2437 
                    let v2486 : US8 =
                        match v2480 with
                        | US7_0(v2481) -> (* C1of2 *)
                            US8_0(v2481)
                        | US7_1(v2483) -> (* C2of2 *)
                            US8_1(v2483)
                    return v2486 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v2487 : Async<US8> = _v2479 
            let _v2442 = v2487 
            #endif
            let v2488 : Async<US8> = _v2442 
            let v2493 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v2494 : Async<US6> = null |> unbox<Async<US6>>
            let _v2493 = v2494 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v2497 : Async<US6> = null |> unbox<Async<US6>>
            let _v2493 = v2497 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v2500 : Async<US6> = null |> unbox<Async<US6>>
            let _v2493 = v2500 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v2503 : unit = ()
            let _v2503 =
                async {
                    let! v2488 = v2488 
                    let v2504 : US8 = v2488 
                    let v2628 : US6 =
                        match v2504 with
                        | US8_1(v2507) -> (* Error *)
                            let v2508 : string = $"%A{v2507}"
                            let v2511 : string = "System.TimeoutException"
                            let v2512 : bool = v2508.Contains v2511 
                            if v2512 then
                                let v2515 : unit = ()
                                let v2516 : (unit -> unit) = closure16(v0)
                                let v2517 : unit = (fun () -> v2516 (); v2515) ()
                                US6_1
                            else
                                let v2558 : unit = ()
                                let v2559 : (unit -> unit) = closure17(v0, v2507)
                                let v2560 : unit = (fun () -> v2559 (); v2558) ()
                                US6_1
                        | US8_0(v2505) -> (* Ok *)
                            US6_0(v2505)
                    return v2628 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v2629 : Async<US6> = _v2503 
            let _v2493 = v2629 
            #endif
#if FABLE_COMPILER_PYTHON
            let v2630 : unit = ()
            let _v2630 =
                async {
                    let! v2488 = v2488 
                    let v2631 : US8 = v2488 
                    let v2755 : US6 =
                        match v2631 with
                        | US8_1(v2634) -> (* Error *)
                            let v2635 : string = $"%A{v2634}"
                            let v2638 : string = "System.TimeoutException"
                            let v2639 : bool = v2635.Contains v2638 
                            if v2639 then
                                let v2642 : unit = ()
                                let v2643 : (unit -> unit) = closure16(v0)
                                let v2644 : unit = (fun () -> v2643 (); v2642) ()
                                US6_1
                            else
                                let v2685 : unit = ()
                                let v2686 : (unit -> unit) = closure17(v0, v2634)
                                let v2687 : unit = (fun () -> v2686 (); v2685) ()
                                US6_1
                        | US8_0(v2632) -> (* Ok *)
                            US6_0(v2632)
                    return v2755 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v2756 : Async<US6> = _v2630 
            let _v2493 = v2756 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v2757 : unit = ()
            let _v2757 =
                async {
                    let! v2488 = v2488 
                    let v2758 : US8 = v2488 
                    let v2882 : US6 =
                        match v2758 with
                        | US8_1(v2761) -> (* Error *)
                            let v2762 : string = $"%A{v2761}"
                            let v2765 : string = "System.TimeoutException"
                            let v2766 : bool = v2762.Contains v2765 
                            if v2766 then
                                let v2769 : unit = ()
                                let v2770 : (unit -> unit) = closure16(v0)
                                let v2771 : unit = (fun () -> v2770 (); v2769) ()
                                US6_1
                            else
                                let v2812 : unit = ()
                                let v2813 : (unit -> unit) = closure17(v0, v2761)
                                let v2814 : unit = (fun () -> v2813 (); v2812) ()
                                US6_1
                        | US8_0(v2759) -> (* Ok *)
                            US6_0(v2759)
                    return v2882 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v2883 : Async<US6> = _v2757 
            let _v2493 = v2883 
            #endif
#else
            let v2884 : unit = ()
            let _v2884 =
                async {
                    let! v2488 = v2488 
                    let v2885 : US8 = v2488 
                    let v3009 : US6 =
                        match v2885 with
                        | US8_1(v2888) -> (* Error *)
                            let v2889 : string = $"%A{v2888}"
                            let v2892 : string = "System.TimeoutException"
                            let v2893 : bool = v2889.Contains v2892 
                            if v2893 then
                                let v2896 : unit = ()
                                let v2897 : (unit -> unit) = closure16(v0)
                                let v2898 : unit = (fun () -> v2897 (); v2896) ()
                                US6_1
                            else
                                let v2939 : unit = ()
                                let v2940 : (unit -> unit) = closure17(v0, v2888)
                                let v2941 : unit = (fun () -> v2940 (); v2939) ()
                                US6_1
                        | US8_0(v2886) -> (* Ok *)
                            US6_0(v2886)
                    return v3009 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v3010 : Async<US6> = _v2884 
            let _v2493 = v3010 
            #endif
            let v3011 : Async<US6> = _v2493 
            return! v3011 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v3016 : Async<US6> = _v2266 
    let _v3 = v3016 
    #endif
    let v3017 : Async<US6> = _v3 
    let _v2 = v3017 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v3022 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3023 : Async<US6> = null |> unbox<Async<US6>>
    let _v3022 = v3023 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v3026 : Async<US6> = null |> unbox<Async<US6>>
    let _v3022 = v3026 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v3029 : Async<US6> = null |> unbox<Async<US6>>
    let _v3022 = v3029 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v3032 : unit = ()
    let _v3032 =
        async {
            let v3033 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v3034 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v3033 = v3034 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v3037 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v3033 = v3037 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v3040 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v3033 = v3040 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v3043 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v3033 = v3043 
            #endif
#if FABLE_COMPILER_PYTHON
            let v3044 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v3033 = v3044 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v3045 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v3033 = v3045 
            #endif
#else
            let v3046 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v3033 = v3046 
            #endif
            let v3047 : Async<Async<bool>> = _v3033 
            let! v3047 = v3047 
            let v3052 : Async<bool> = v3047 
            let v3053 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v3054 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v3055 : Async<Choice<bool, exn>> = v3054 v3052
            let _v3053 = v3055 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v3056 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v3057 : Async<Choice<bool, exn>> = v3056 v3052
            let _v3053 = v3057 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v3058 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v3059 : Async<Choice<bool, exn>> = v3058 v3052
            let _v3053 = v3059 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v3060 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v3061 : Async<Choice<bool, exn>> = v3060 v3052
            let _v3053 = v3061 
            #endif
#if FABLE_COMPILER_PYTHON
            let v3062 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v3063 : Async<Choice<bool, exn>> = v3062 v3052
            let _v3053 = v3063 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v3064 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v3065 : Async<Choice<bool, exn>> = v3064 v3052
            let _v3053 = v3065 
            #endif
#else
            let v3066 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v3067 : Async<Choice<bool, exn>> = v3066 v3052
            let _v3053 = v3067 
            #endif
            let v3068 : Async<Choice<bool, exn>> = _v3053 
            let v3073 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v3074 : Async<US7> = null |> unbox<Async<US7>>
            let _v3073 = v3074 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v3077 : Async<US7> = null |> unbox<Async<US7>>
            let _v3073 = v3077 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v3080 : Async<US7> = null |> unbox<Async<US7>>
            let _v3073 = v3080 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v3083 : unit = ()
            let _v3083 =
                async {
                    let! v3068 = v3068 
                    let v3084 : Choice<bool, exn> = v3068 
                    let v3085 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v3086 : US7 = null |> unbox<US7>
                    let _v3085 = v3086 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v3089 : US7 = null |> unbox<US7>
                    let _v3085 = v3089 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v3092 : US7 = null |> unbox<US7>
                    let _v3085 = v3092 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v3095 : US7 = null |> unbox<US7>
                    let _v3085 = v3095 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v3098 : US7 = null |> unbox<US7>
                    let _v3085 = v3098 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v3101 : (bool -> US7) = method22()
                    let v3102 : (exn -> US7) = method23()
                    let v3103 : US7 = match v3084 with Choice1Of2 x -> v3101 x | Choice2Of2 x -> v3102 x
                    let _v3085 = v3103 
                    #endif
#else
                    let v3104 : (bool -> US7) = method22()
                    let v3105 : (exn -> US7) = method23()
                    let v3106 : US7 = match v3084 with Choice1Of2 x -> v3104 x | Choice2Of2 x -> v3105 x
                    let _v3085 = v3106 
                    #endif
                    let v3107 : US7 = _v3085 
                    return v3107 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v3112 : Async<US7> = _v3083 
            let _v3073 = v3112 
            #endif
#if FABLE_COMPILER_PYTHON
            let v3113 : unit = ()
            let _v3113 =
                async {
                    let! v3068 = v3068 
                    let v3114 : Choice<bool, exn> = v3068 
                    let v3115 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v3116 : US7 = null |> unbox<US7>
                    let _v3115 = v3116 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v3119 : US7 = null |> unbox<US7>
                    let _v3115 = v3119 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v3122 : US7 = null |> unbox<US7>
                    let _v3115 = v3122 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v3125 : US7 = null |> unbox<US7>
                    let _v3115 = v3125 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v3128 : US7 = null |> unbox<US7>
                    let _v3115 = v3128 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v3131 : (bool -> US7) = method22()
                    let v3132 : (exn -> US7) = method23()
                    let v3133 : US7 = match v3114 with Choice1Of2 x -> v3131 x | Choice2Of2 x -> v3132 x
                    let _v3115 = v3133 
                    #endif
#else
                    let v3134 : (bool -> US7) = method22()
                    let v3135 : (exn -> US7) = method23()
                    let v3136 : US7 = match v3114 with Choice1Of2 x -> v3134 x | Choice2Of2 x -> v3135 x
                    let _v3115 = v3136 
                    #endif
                    let v3137 : US7 = _v3115 
                    return v3137 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v3142 : Async<US7> = _v3113 
            let _v3073 = v3142 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v3143 : unit = ()
            let _v3143 =
                async {
                    let! v3068 = v3068 
                    let v3144 : Choice<bool, exn> = v3068 
                    let v3145 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v3146 : US7 = null |> unbox<US7>
                    let _v3145 = v3146 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v3149 : US7 = null |> unbox<US7>
                    let _v3145 = v3149 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v3152 : US7 = null |> unbox<US7>
                    let _v3145 = v3152 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v3155 : US7 = null |> unbox<US7>
                    let _v3145 = v3155 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v3158 : US7 = null |> unbox<US7>
                    let _v3145 = v3158 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v3161 : (bool -> US7) = method22()
                    let v3162 : (exn -> US7) = method23()
                    let v3163 : US7 = match v3144 with Choice1Of2 x -> v3161 x | Choice2Of2 x -> v3162 x
                    let _v3145 = v3163 
                    #endif
#else
                    let v3164 : (bool -> US7) = method22()
                    let v3165 : (exn -> US7) = method23()
                    let v3166 : US7 = match v3144 with Choice1Of2 x -> v3164 x | Choice2Of2 x -> v3165 x
                    let _v3145 = v3166 
                    #endif
                    let v3167 : US7 = _v3145 
                    return v3167 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v3172 : Async<US7> = _v3143 
            let _v3073 = v3172 
            #endif
#else
            let v3173 : unit = ()
            let _v3173 =
                async {
                    let! v3068 = v3068 
                    let v3174 : Choice<bool, exn> = v3068 
                    let v3175 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v3176 : US7 = null |> unbox<US7>
                    let _v3175 = v3176 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v3179 : US7 = null |> unbox<US7>
                    let _v3175 = v3179 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v3182 : US7 = null |> unbox<US7>
                    let _v3175 = v3182 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v3185 : US7 = null |> unbox<US7>
                    let _v3175 = v3185 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v3188 : US7 = null |> unbox<US7>
                    let _v3175 = v3188 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v3191 : (bool -> US7) = method22()
                    let v3192 : (exn -> US7) = method23()
                    let v3193 : US7 = match v3174 with Choice1Of2 x -> v3191 x | Choice2Of2 x -> v3192 x
                    let _v3175 = v3193 
                    #endif
#else
                    let v3194 : (bool -> US7) = method22()
                    let v3195 : (exn -> US7) = method23()
                    let v3196 : US7 = match v3174 with Choice1Of2 x -> v3194 x | Choice2Of2 x -> v3195 x
                    let _v3175 = v3196 
                    #endif
                    let v3197 : US7 = _v3175 
                    return v3197 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v3202 : Async<US7> = _v3173 
            let _v3073 = v3202 
            #endif
            let v3203 : Async<US7> = _v3073 
            let v3208 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v3209 : Async<US8> = null |> unbox<Async<US8>>
            let _v3208 = v3209 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v3212 : Async<US8> = null |> unbox<Async<US8>>
            let _v3208 = v3212 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v3215 : Async<US8> = null |> unbox<Async<US8>>
            let _v3208 = v3215 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v3218 : unit = ()
            let _v3218 =
                async {
                    let! v3203 = v3203 
                    let v3219 : US7 = v3203 
                    let v3225 : US8 =
                        match v3219 with
                        | US7_0(v3220) -> (* C1of2 *)
                            US8_0(v3220)
                        | US7_1(v3222) -> (* C2of2 *)
                            US8_1(v3222)
                    return v3225 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v3226 : Async<US8> = _v3218 
            let _v3208 = v3226 
            #endif
#if FABLE_COMPILER_PYTHON
            let v3227 : unit = ()
            let _v3227 =
                async {
                    let! v3203 = v3203 
                    let v3228 : US7 = v3203 
                    let v3234 : US8 =
                        match v3228 with
                        | US7_0(v3229) -> (* C1of2 *)
                            US8_0(v3229)
                        | US7_1(v3231) -> (* C2of2 *)
                            US8_1(v3231)
                    return v3234 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v3235 : Async<US8> = _v3227 
            let _v3208 = v3235 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v3236 : unit = ()
            let _v3236 =
                async {
                    let! v3203 = v3203 
                    let v3237 : US7 = v3203 
                    let v3243 : US8 =
                        match v3237 with
                        | US7_0(v3238) -> (* C1of2 *)
                            US8_0(v3238)
                        | US7_1(v3240) -> (* C2of2 *)
                            US8_1(v3240)
                    return v3243 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v3244 : Async<US8> = _v3236 
            let _v3208 = v3244 
            #endif
#else
            let v3245 : unit = ()
            let _v3245 =
                async {
                    let! v3203 = v3203 
                    let v3246 : US7 = v3203 
                    let v3252 : US8 =
                        match v3246 with
                        | US7_0(v3247) -> (* C1of2 *)
                            US8_0(v3247)
                        | US7_1(v3249) -> (* C2of2 *)
                            US8_1(v3249)
                    return v3252 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v3253 : Async<US8> = _v3245 
            let _v3208 = v3253 
            #endif
            let v3254 : Async<US8> = _v3208 
            let v3259 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v3260 : Async<US6> = null |> unbox<Async<US6>>
            let _v3259 = v3260 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v3263 : Async<US6> = null |> unbox<Async<US6>>
            let _v3259 = v3263 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v3266 : Async<US6> = null |> unbox<Async<US6>>
            let _v3259 = v3266 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v3269 : unit = ()
            let _v3269 =
                async {
                    let! v3254 = v3254 
                    let v3270 : US8 = v3254 
                    let v3394 : US6 =
                        match v3270 with
                        | US8_1(v3273) -> (* Error *)
                            let v3274 : string = $"%A{v3273}"
                            let v3277 : string = "System.TimeoutException"
                            let v3278 : bool = v3274.Contains v3277 
                            if v3278 then
                                let v3281 : unit = ()
                                let v3282 : (unit -> unit) = closure16(v0)
                                let v3283 : unit = (fun () -> v3282 (); v3281) ()
                                US6_1
                            else
                                let v3324 : unit = ()
                                let v3325 : (unit -> unit) = closure17(v0, v3273)
                                let v3326 : unit = (fun () -> v3325 (); v3324) ()
                                US6_1
                        | US8_0(v3271) -> (* Ok *)
                            US6_0(v3271)
                    return v3394 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v3395 : Async<US6> = _v3269 
            let _v3259 = v3395 
            #endif
#if FABLE_COMPILER_PYTHON
            let v3396 : unit = ()
            let _v3396 =
                async {
                    let! v3254 = v3254 
                    let v3397 : US8 = v3254 
                    let v3521 : US6 =
                        match v3397 with
                        | US8_1(v3400) -> (* Error *)
                            let v3401 : string = $"%A{v3400}"
                            let v3404 : string = "System.TimeoutException"
                            let v3405 : bool = v3401.Contains v3404 
                            if v3405 then
                                let v3408 : unit = ()
                                let v3409 : (unit -> unit) = closure16(v0)
                                let v3410 : unit = (fun () -> v3409 (); v3408) ()
                                US6_1
                            else
                                let v3451 : unit = ()
                                let v3452 : (unit -> unit) = closure17(v0, v3400)
                                let v3453 : unit = (fun () -> v3452 (); v3451) ()
                                US6_1
                        | US8_0(v3398) -> (* Ok *)
                            US6_0(v3398)
                    return v3521 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v3522 : Async<US6> = _v3396 
            let _v3259 = v3522 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v3523 : unit = ()
            let _v3523 =
                async {
                    let! v3254 = v3254 
                    let v3524 : US8 = v3254 
                    let v3648 : US6 =
                        match v3524 with
                        | US8_1(v3527) -> (* Error *)
                            let v3528 : string = $"%A{v3527}"
                            let v3531 : string = "System.TimeoutException"
                            let v3532 : bool = v3528.Contains v3531 
                            if v3532 then
                                let v3535 : unit = ()
                                let v3536 : (unit -> unit) = closure16(v0)
                                let v3537 : unit = (fun () -> v3536 (); v3535) ()
                                US6_1
                            else
                                let v3578 : unit = ()
                                let v3579 : (unit -> unit) = closure17(v0, v3527)
                                let v3580 : unit = (fun () -> v3579 (); v3578) ()
                                US6_1
                        | US8_0(v3525) -> (* Ok *)
                            US6_0(v3525)
                    return v3648 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v3649 : Async<US6> = _v3523 
            let _v3259 = v3649 
            #endif
#else
            let v3650 : unit = ()
            let _v3650 =
                async {
                    let! v3254 = v3254 
                    let v3651 : US8 = v3254 
                    let v3775 : US6 =
                        match v3651 with
                        | US8_1(v3654) -> (* Error *)
                            let v3655 : string = $"%A{v3654}"
                            let v3658 : string = "System.TimeoutException"
                            let v3659 : bool = v3655.Contains v3658 
                            if v3659 then
                                let v3662 : unit = ()
                                let v3663 : (unit -> unit) = closure16(v0)
                                let v3664 : unit = (fun () -> v3663 (); v3662) ()
                                US6_1
                            else
                                let v3705 : unit = ()
                                let v3706 : (unit -> unit) = closure17(v0, v3654)
                                let v3707 : unit = (fun () -> v3706 (); v3705) ()
                                US6_1
                        | US8_0(v3652) -> (* Ok *)
                            US6_0(v3652)
                    return v3775 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v3776 : Async<US6> = _v3650 
            let _v3259 = v3776 
            #endif
            let v3777 : Async<US6> = _v3259 
            return! v3777 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v3782 : Async<US6> = _v3032 
    let _v3022 = v3782 
    #endif
#if FABLE_COMPILER_PYTHON
    let v3783 : unit = ()
    let _v3783 =
        async {
            let v3784 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v3785 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v3784 = v3785 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v3788 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v3784 = v3788 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v3791 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v3784 = v3791 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v3794 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v3784 = v3794 
            #endif
#if FABLE_COMPILER_PYTHON
            let v3795 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v3784 = v3795 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v3796 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v3784 = v3796 
            #endif
#else
            let v3797 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v3784 = v3797 
            #endif
            let v3798 : Async<Async<bool>> = _v3784 
            let! v3798 = v3798 
            let v3803 : Async<bool> = v3798 
            let v3804 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v3805 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v3806 : Async<Choice<bool, exn>> = v3805 v3803
            let _v3804 = v3806 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v3807 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v3808 : Async<Choice<bool, exn>> = v3807 v3803
            let _v3804 = v3808 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v3809 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v3810 : Async<Choice<bool, exn>> = v3809 v3803
            let _v3804 = v3810 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v3811 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v3812 : Async<Choice<bool, exn>> = v3811 v3803
            let _v3804 = v3812 
            #endif
#if FABLE_COMPILER_PYTHON
            let v3813 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v3814 : Async<Choice<bool, exn>> = v3813 v3803
            let _v3804 = v3814 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v3815 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v3816 : Async<Choice<bool, exn>> = v3815 v3803
            let _v3804 = v3816 
            #endif
#else
            let v3817 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v3818 : Async<Choice<bool, exn>> = v3817 v3803
            let _v3804 = v3818 
            #endif
            let v3819 : Async<Choice<bool, exn>> = _v3804 
            let v3824 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v3825 : Async<US7> = null |> unbox<Async<US7>>
            let _v3824 = v3825 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v3828 : Async<US7> = null |> unbox<Async<US7>>
            let _v3824 = v3828 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v3831 : Async<US7> = null |> unbox<Async<US7>>
            let _v3824 = v3831 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v3834 : unit = ()
            let _v3834 =
                async {
                    let! v3819 = v3819 
                    let v3835 : Choice<bool, exn> = v3819 
                    let v3836 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v3837 : US7 = null |> unbox<US7>
                    let _v3836 = v3837 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v3840 : US7 = null |> unbox<US7>
                    let _v3836 = v3840 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v3843 : US7 = null |> unbox<US7>
                    let _v3836 = v3843 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v3846 : US7 = null |> unbox<US7>
                    let _v3836 = v3846 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v3849 : US7 = null |> unbox<US7>
                    let _v3836 = v3849 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v3852 : (bool -> US7) = method22()
                    let v3853 : (exn -> US7) = method23()
                    let v3854 : US7 = match v3835 with Choice1Of2 x -> v3852 x | Choice2Of2 x -> v3853 x
                    let _v3836 = v3854 
                    #endif
#else
                    let v3855 : (bool -> US7) = method22()
                    let v3856 : (exn -> US7) = method23()
                    let v3857 : US7 = match v3835 with Choice1Of2 x -> v3855 x | Choice2Of2 x -> v3856 x
                    let _v3836 = v3857 
                    #endif
                    let v3858 : US7 = _v3836 
                    return v3858 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v3863 : Async<US7> = _v3834 
            let _v3824 = v3863 
            #endif
#if FABLE_COMPILER_PYTHON
            let v3864 : unit = ()
            let _v3864 =
                async {
                    let! v3819 = v3819 
                    let v3865 : Choice<bool, exn> = v3819 
                    let v3866 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v3867 : US7 = null |> unbox<US7>
                    let _v3866 = v3867 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v3870 : US7 = null |> unbox<US7>
                    let _v3866 = v3870 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v3873 : US7 = null |> unbox<US7>
                    let _v3866 = v3873 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v3876 : US7 = null |> unbox<US7>
                    let _v3866 = v3876 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v3879 : US7 = null |> unbox<US7>
                    let _v3866 = v3879 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v3882 : (bool -> US7) = method22()
                    let v3883 : (exn -> US7) = method23()
                    let v3884 : US7 = match v3865 with Choice1Of2 x -> v3882 x | Choice2Of2 x -> v3883 x
                    let _v3866 = v3884 
                    #endif
#else
                    let v3885 : (bool -> US7) = method22()
                    let v3886 : (exn -> US7) = method23()
                    let v3887 : US7 = match v3865 with Choice1Of2 x -> v3885 x | Choice2Of2 x -> v3886 x
                    let _v3866 = v3887 
                    #endif
                    let v3888 : US7 = _v3866 
                    return v3888 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v3893 : Async<US7> = _v3864 
            let _v3824 = v3893 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v3894 : unit = ()
            let _v3894 =
                async {
                    let! v3819 = v3819 
                    let v3895 : Choice<bool, exn> = v3819 
                    let v3896 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v3897 : US7 = null |> unbox<US7>
                    let _v3896 = v3897 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v3900 : US7 = null |> unbox<US7>
                    let _v3896 = v3900 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v3903 : US7 = null |> unbox<US7>
                    let _v3896 = v3903 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v3906 : US7 = null |> unbox<US7>
                    let _v3896 = v3906 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v3909 : US7 = null |> unbox<US7>
                    let _v3896 = v3909 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v3912 : (bool -> US7) = method22()
                    let v3913 : (exn -> US7) = method23()
                    let v3914 : US7 = match v3895 with Choice1Of2 x -> v3912 x | Choice2Of2 x -> v3913 x
                    let _v3896 = v3914 
                    #endif
#else
                    let v3915 : (bool -> US7) = method22()
                    let v3916 : (exn -> US7) = method23()
                    let v3917 : US7 = match v3895 with Choice1Of2 x -> v3915 x | Choice2Of2 x -> v3916 x
                    let _v3896 = v3917 
                    #endif
                    let v3918 : US7 = _v3896 
                    return v3918 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v3923 : Async<US7> = _v3894 
            let _v3824 = v3923 
            #endif
#else
            let v3924 : unit = ()
            let _v3924 =
                async {
                    let! v3819 = v3819 
                    let v3925 : Choice<bool, exn> = v3819 
                    let v3926 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v3927 : US7 = null |> unbox<US7>
                    let _v3926 = v3927 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v3930 : US7 = null |> unbox<US7>
                    let _v3926 = v3930 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v3933 : US7 = null |> unbox<US7>
                    let _v3926 = v3933 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v3936 : US7 = null |> unbox<US7>
                    let _v3926 = v3936 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v3939 : US7 = null |> unbox<US7>
                    let _v3926 = v3939 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v3942 : (bool -> US7) = method22()
                    let v3943 : (exn -> US7) = method23()
                    let v3944 : US7 = match v3925 with Choice1Of2 x -> v3942 x | Choice2Of2 x -> v3943 x
                    let _v3926 = v3944 
                    #endif
#else
                    let v3945 : (bool -> US7) = method22()
                    let v3946 : (exn -> US7) = method23()
                    let v3947 : US7 = match v3925 with Choice1Of2 x -> v3945 x | Choice2Of2 x -> v3946 x
                    let _v3926 = v3947 
                    #endif
                    let v3948 : US7 = _v3926 
                    return v3948 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v3953 : Async<US7> = _v3924 
            let _v3824 = v3953 
            #endif
            let v3954 : Async<US7> = _v3824 
            let v3959 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v3960 : Async<US8> = null |> unbox<Async<US8>>
            let _v3959 = v3960 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v3963 : Async<US8> = null |> unbox<Async<US8>>
            let _v3959 = v3963 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v3966 : Async<US8> = null |> unbox<Async<US8>>
            let _v3959 = v3966 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v3969 : unit = ()
            let _v3969 =
                async {
                    let! v3954 = v3954 
                    let v3970 : US7 = v3954 
                    let v3976 : US8 =
                        match v3970 with
                        | US7_0(v3971) -> (* C1of2 *)
                            US8_0(v3971)
                        | US7_1(v3973) -> (* C2of2 *)
                            US8_1(v3973)
                    return v3976 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v3977 : Async<US8> = _v3969 
            let _v3959 = v3977 
            #endif
#if FABLE_COMPILER_PYTHON
            let v3978 : unit = ()
            let _v3978 =
                async {
                    let! v3954 = v3954 
                    let v3979 : US7 = v3954 
                    let v3985 : US8 =
                        match v3979 with
                        | US7_0(v3980) -> (* C1of2 *)
                            US8_0(v3980)
                        | US7_1(v3982) -> (* C2of2 *)
                            US8_1(v3982)
                    return v3985 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v3986 : Async<US8> = _v3978 
            let _v3959 = v3986 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v3987 : unit = ()
            let _v3987 =
                async {
                    let! v3954 = v3954 
                    let v3988 : US7 = v3954 
                    let v3994 : US8 =
                        match v3988 with
                        | US7_0(v3989) -> (* C1of2 *)
                            US8_0(v3989)
                        | US7_1(v3991) -> (* C2of2 *)
                            US8_1(v3991)
                    return v3994 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v3995 : Async<US8> = _v3987 
            let _v3959 = v3995 
            #endif
#else
            let v3996 : unit = ()
            let _v3996 =
                async {
                    let! v3954 = v3954 
                    let v3997 : US7 = v3954 
                    let v4003 : US8 =
                        match v3997 with
                        | US7_0(v3998) -> (* C1of2 *)
                            US8_0(v3998)
                        | US7_1(v4000) -> (* C2of2 *)
                            US8_1(v4000)
                    return v4003 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v4004 : Async<US8> = _v3996 
            let _v3959 = v4004 
            #endif
            let v4005 : Async<US8> = _v3959 
            let v4010 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v4011 : Async<US6> = null |> unbox<Async<US6>>
            let _v4010 = v4011 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v4014 : Async<US6> = null |> unbox<Async<US6>>
            let _v4010 = v4014 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v4017 : Async<US6> = null |> unbox<Async<US6>>
            let _v4010 = v4017 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v4020 : unit = ()
            let _v4020 =
                async {
                    let! v4005 = v4005 
                    let v4021 : US8 = v4005 
                    let v4145 : US6 =
                        match v4021 with
                        | US8_1(v4024) -> (* Error *)
                            let v4025 : string = $"%A{v4024}"
                            let v4028 : string = "System.TimeoutException"
                            let v4029 : bool = v4025.Contains v4028 
                            if v4029 then
                                let v4032 : unit = ()
                                let v4033 : (unit -> unit) = closure16(v0)
                                let v4034 : unit = (fun () -> v4033 (); v4032) ()
                                US6_1
                            else
                                let v4075 : unit = ()
                                let v4076 : (unit -> unit) = closure17(v0, v4024)
                                let v4077 : unit = (fun () -> v4076 (); v4075) ()
                                US6_1
                        | US8_0(v4022) -> (* Ok *)
                            US6_0(v4022)
                    return v4145 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v4146 : Async<US6> = _v4020 
            let _v4010 = v4146 
            #endif
#if FABLE_COMPILER_PYTHON
            let v4147 : unit = ()
            let _v4147 =
                async {
                    let! v4005 = v4005 
                    let v4148 : US8 = v4005 
                    let v4272 : US6 =
                        match v4148 with
                        | US8_1(v4151) -> (* Error *)
                            let v4152 : string = $"%A{v4151}"
                            let v4155 : string = "System.TimeoutException"
                            let v4156 : bool = v4152.Contains v4155 
                            if v4156 then
                                let v4159 : unit = ()
                                let v4160 : (unit -> unit) = closure16(v0)
                                let v4161 : unit = (fun () -> v4160 (); v4159) ()
                                US6_1
                            else
                                let v4202 : unit = ()
                                let v4203 : (unit -> unit) = closure17(v0, v4151)
                                let v4204 : unit = (fun () -> v4203 (); v4202) ()
                                US6_1
                        | US8_0(v4149) -> (* Ok *)
                            US6_0(v4149)
                    return v4272 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v4273 : Async<US6> = _v4147 
            let _v4010 = v4273 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v4274 : unit = ()
            let _v4274 =
                async {
                    let! v4005 = v4005 
                    let v4275 : US8 = v4005 
                    let v4399 : US6 =
                        match v4275 with
                        | US8_1(v4278) -> (* Error *)
                            let v4279 : string = $"%A{v4278}"
                            let v4282 : string = "System.TimeoutException"
                            let v4283 : bool = v4279.Contains v4282 
                            if v4283 then
                                let v4286 : unit = ()
                                let v4287 : (unit -> unit) = closure16(v0)
                                let v4288 : unit = (fun () -> v4287 (); v4286) ()
                                US6_1
                            else
                                let v4329 : unit = ()
                                let v4330 : (unit -> unit) = closure17(v0, v4278)
                                let v4331 : unit = (fun () -> v4330 (); v4329) ()
                                US6_1
                        | US8_0(v4276) -> (* Ok *)
                            US6_0(v4276)
                    return v4399 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v4400 : Async<US6> = _v4274 
            let _v4010 = v4400 
            #endif
#else
            let v4401 : unit = ()
            let _v4401 =
                async {
                    let! v4005 = v4005 
                    let v4402 : US8 = v4005 
                    let v4526 : US6 =
                        match v4402 with
                        | US8_1(v4405) -> (* Error *)
                            let v4406 : string = $"%A{v4405}"
                            let v4409 : string = "System.TimeoutException"
                            let v4410 : bool = v4406.Contains v4409 
                            if v4410 then
                                let v4413 : unit = ()
                                let v4414 : (unit -> unit) = closure16(v0)
                                let v4415 : unit = (fun () -> v4414 (); v4413) ()
                                US6_1
                            else
                                let v4456 : unit = ()
                                let v4457 : (unit -> unit) = closure17(v0, v4405)
                                let v4458 : unit = (fun () -> v4457 (); v4456) ()
                                US6_1
                        | US8_0(v4403) -> (* Ok *)
                            US6_0(v4403)
                    return v4526 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v4527 : Async<US6> = _v4401 
            let _v4010 = v4527 
            #endif
            let v4528 : Async<US6> = _v4010 
            return! v4528 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v4533 : Async<US6> = _v3783 
    let _v3022 = v4533 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v4534 : unit = ()
    let _v4534 =
        async {
            let v4535 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v4536 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v4535 = v4536 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v4539 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v4535 = v4539 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v4542 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v4535 = v4542 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v4545 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v4535 = v4545 
            #endif
#if FABLE_COMPILER_PYTHON
            let v4546 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v4535 = v4546 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v4547 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v4535 = v4547 
            #endif
#else
            let v4548 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v4535 = v4548 
            #endif
            let v4549 : Async<Async<bool>> = _v4535 
            let! v4549 = v4549 
            let v4554 : Async<bool> = v4549 
            let v4555 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v4556 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v4557 : Async<Choice<bool, exn>> = v4556 v4554
            let _v4555 = v4557 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v4558 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v4559 : Async<Choice<bool, exn>> = v4558 v4554
            let _v4555 = v4559 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v4560 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v4561 : Async<Choice<bool, exn>> = v4560 v4554
            let _v4555 = v4561 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v4562 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v4563 : Async<Choice<bool, exn>> = v4562 v4554
            let _v4555 = v4563 
            #endif
#if FABLE_COMPILER_PYTHON
            let v4564 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v4565 : Async<Choice<bool, exn>> = v4564 v4554
            let _v4555 = v4565 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v4566 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v4567 : Async<Choice<bool, exn>> = v4566 v4554
            let _v4555 = v4567 
            #endif
#else
            let v4568 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v4569 : Async<Choice<bool, exn>> = v4568 v4554
            let _v4555 = v4569 
            #endif
            let v4570 : Async<Choice<bool, exn>> = _v4555 
            let v4575 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v4576 : Async<US7> = null |> unbox<Async<US7>>
            let _v4575 = v4576 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v4579 : Async<US7> = null |> unbox<Async<US7>>
            let _v4575 = v4579 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v4582 : Async<US7> = null |> unbox<Async<US7>>
            let _v4575 = v4582 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v4585 : unit = ()
            let _v4585 =
                async {
                    let! v4570 = v4570 
                    let v4586 : Choice<bool, exn> = v4570 
                    let v4587 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v4588 : US7 = null |> unbox<US7>
                    let _v4587 = v4588 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v4591 : US7 = null |> unbox<US7>
                    let _v4587 = v4591 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v4594 : US7 = null |> unbox<US7>
                    let _v4587 = v4594 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v4597 : US7 = null |> unbox<US7>
                    let _v4587 = v4597 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v4600 : US7 = null |> unbox<US7>
                    let _v4587 = v4600 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v4603 : (bool -> US7) = method22()
                    let v4604 : (exn -> US7) = method23()
                    let v4605 : US7 = match v4586 with Choice1Of2 x -> v4603 x | Choice2Of2 x -> v4604 x
                    let _v4587 = v4605 
                    #endif
#else
                    let v4606 : (bool -> US7) = method22()
                    let v4607 : (exn -> US7) = method23()
                    let v4608 : US7 = match v4586 with Choice1Of2 x -> v4606 x | Choice2Of2 x -> v4607 x
                    let _v4587 = v4608 
                    #endif
                    let v4609 : US7 = _v4587 
                    return v4609 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v4614 : Async<US7> = _v4585 
            let _v4575 = v4614 
            #endif
#if FABLE_COMPILER_PYTHON
            let v4615 : unit = ()
            let _v4615 =
                async {
                    let! v4570 = v4570 
                    let v4616 : Choice<bool, exn> = v4570 
                    let v4617 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v4618 : US7 = null |> unbox<US7>
                    let _v4617 = v4618 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v4621 : US7 = null |> unbox<US7>
                    let _v4617 = v4621 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v4624 : US7 = null |> unbox<US7>
                    let _v4617 = v4624 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v4627 : US7 = null |> unbox<US7>
                    let _v4617 = v4627 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v4630 : US7 = null |> unbox<US7>
                    let _v4617 = v4630 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v4633 : (bool -> US7) = method22()
                    let v4634 : (exn -> US7) = method23()
                    let v4635 : US7 = match v4616 with Choice1Of2 x -> v4633 x | Choice2Of2 x -> v4634 x
                    let _v4617 = v4635 
                    #endif
#else
                    let v4636 : (bool -> US7) = method22()
                    let v4637 : (exn -> US7) = method23()
                    let v4638 : US7 = match v4616 with Choice1Of2 x -> v4636 x | Choice2Of2 x -> v4637 x
                    let _v4617 = v4638 
                    #endif
                    let v4639 : US7 = _v4617 
                    return v4639 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v4644 : Async<US7> = _v4615 
            let _v4575 = v4644 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v4645 : unit = ()
            let _v4645 =
                async {
                    let! v4570 = v4570 
                    let v4646 : Choice<bool, exn> = v4570 
                    let v4647 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v4648 : US7 = null |> unbox<US7>
                    let _v4647 = v4648 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v4651 : US7 = null |> unbox<US7>
                    let _v4647 = v4651 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v4654 : US7 = null |> unbox<US7>
                    let _v4647 = v4654 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v4657 : US7 = null |> unbox<US7>
                    let _v4647 = v4657 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v4660 : US7 = null |> unbox<US7>
                    let _v4647 = v4660 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v4663 : (bool -> US7) = method22()
                    let v4664 : (exn -> US7) = method23()
                    let v4665 : US7 = match v4646 with Choice1Of2 x -> v4663 x | Choice2Of2 x -> v4664 x
                    let _v4647 = v4665 
                    #endif
#else
                    let v4666 : (bool -> US7) = method22()
                    let v4667 : (exn -> US7) = method23()
                    let v4668 : US7 = match v4646 with Choice1Of2 x -> v4666 x | Choice2Of2 x -> v4667 x
                    let _v4647 = v4668 
                    #endif
                    let v4669 : US7 = _v4647 
                    return v4669 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v4674 : Async<US7> = _v4645 
            let _v4575 = v4674 
            #endif
#else
            let v4675 : unit = ()
            let _v4675 =
                async {
                    let! v4570 = v4570 
                    let v4676 : Choice<bool, exn> = v4570 
                    let v4677 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v4678 : US7 = null |> unbox<US7>
                    let _v4677 = v4678 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v4681 : US7 = null |> unbox<US7>
                    let _v4677 = v4681 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v4684 : US7 = null |> unbox<US7>
                    let _v4677 = v4684 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v4687 : US7 = null |> unbox<US7>
                    let _v4677 = v4687 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v4690 : US7 = null |> unbox<US7>
                    let _v4677 = v4690 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v4693 : (bool -> US7) = method22()
                    let v4694 : (exn -> US7) = method23()
                    let v4695 : US7 = match v4676 with Choice1Of2 x -> v4693 x | Choice2Of2 x -> v4694 x
                    let _v4677 = v4695 
                    #endif
#else
                    let v4696 : (bool -> US7) = method22()
                    let v4697 : (exn -> US7) = method23()
                    let v4698 : US7 = match v4676 with Choice1Of2 x -> v4696 x | Choice2Of2 x -> v4697 x
                    let _v4677 = v4698 
                    #endif
                    let v4699 : US7 = _v4677 
                    return v4699 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v4704 : Async<US7> = _v4675 
            let _v4575 = v4704 
            #endif
            let v4705 : Async<US7> = _v4575 
            let v4710 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v4711 : Async<US8> = null |> unbox<Async<US8>>
            let _v4710 = v4711 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v4714 : Async<US8> = null |> unbox<Async<US8>>
            let _v4710 = v4714 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v4717 : Async<US8> = null |> unbox<Async<US8>>
            let _v4710 = v4717 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v4720 : unit = ()
            let _v4720 =
                async {
                    let! v4705 = v4705 
                    let v4721 : US7 = v4705 
                    let v4727 : US8 =
                        match v4721 with
                        | US7_0(v4722) -> (* C1of2 *)
                            US8_0(v4722)
                        | US7_1(v4724) -> (* C2of2 *)
                            US8_1(v4724)
                    return v4727 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v4728 : Async<US8> = _v4720 
            let _v4710 = v4728 
            #endif
#if FABLE_COMPILER_PYTHON
            let v4729 : unit = ()
            let _v4729 =
                async {
                    let! v4705 = v4705 
                    let v4730 : US7 = v4705 
                    let v4736 : US8 =
                        match v4730 with
                        | US7_0(v4731) -> (* C1of2 *)
                            US8_0(v4731)
                        | US7_1(v4733) -> (* C2of2 *)
                            US8_1(v4733)
                    return v4736 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v4737 : Async<US8> = _v4729 
            let _v4710 = v4737 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v4738 : unit = ()
            let _v4738 =
                async {
                    let! v4705 = v4705 
                    let v4739 : US7 = v4705 
                    let v4745 : US8 =
                        match v4739 with
                        | US7_0(v4740) -> (* C1of2 *)
                            US8_0(v4740)
                        | US7_1(v4742) -> (* C2of2 *)
                            US8_1(v4742)
                    return v4745 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v4746 : Async<US8> = _v4738 
            let _v4710 = v4746 
            #endif
#else
            let v4747 : unit = ()
            let _v4747 =
                async {
                    let! v4705 = v4705 
                    let v4748 : US7 = v4705 
                    let v4754 : US8 =
                        match v4748 with
                        | US7_0(v4749) -> (* C1of2 *)
                            US8_0(v4749)
                        | US7_1(v4751) -> (* C2of2 *)
                            US8_1(v4751)
                    return v4754 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v4755 : Async<US8> = _v4747 
            let _v4710 = v4755 
            #endif
            let v4756 : Async<US8> = _v4710 
            let v4761 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v4762 : Async<US6> = null |> unbox<Async<US6>>
            let _v4761 = v4762 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v4765 : Async<US6> = null |> unbox<Async<US6>>
            let _v4761 = v4765 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v4768 : Async<US6> = null |> unbox<Async<US6>>
            let _v4761 = v4768 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v4771 : unit = ()
            let _v4771 =
                async {
                    let! v4756 = v4756 
                    let v4772 : US8 = v4756 
                    let v4896 : US6 =
                        match v4772 with
                        | US8_1(v4775) -> (* Error *)
                            let v4776 : string = $"%A{v4775}"
                            let v4779 : string = "System.TimeoutException"
                            let v4780 : bool = v4776.Contains v4779 
                            if v4780 then
                                let v4783 : unit = ()
                                let v4784 : (unit -> unit) = closure16(v0)
                                let v4785 : unit = (fun () -> v4784 (); v4783) ()
                                US6_1
                            else
                                let v4826 : unit = ()
                                let v4827 : (unit -> unit) = closure17(v0, v4775)
                                let v4828 : unit = (fun () -> v4827 (); v4826) ()
                                US6_1
                        | US8_0(v4773) -> (* Ok *)
                            US6_0(v4773)
                    return v4896 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v4897 : Async<US6> = _v4771 
            let _v4761 = v4897 
            #endif
#if FABLE_COMPILER_PYTHON
            let v4898 : unit = ()
            let _v4898 =
                async {
                    let! v4756 = v4756 
                    let v4899 : US8 = v4756 
                    let v5023 : US6 =
                        match v4899 with
                        | US8_1(v4902) -> (* Error *)
                            let v4903 : string = $"%A{v4902}"
                            let v4906 : string = "System.TimeoutException"
                            let v4907 : bool = v4903.Contains v4906 
                            if v4907 then
                                let v4910 : unit = ()
                                let v4911 : (unit -> unit) = closure16(v0)
                                let v4912 : unit = (fun () -> v4911 (); v4910) ()
                                US6_1
                            else
                                let v4953 : unit = ()
                                let v4954 : (unit -> unit) = closure17(v0, v4902)
                                let v4955 : unit = (fun () -> v4954 (); v4953) ()
                                US6_1
                        | US8_0(v4900) -> (* Ok *)
                            US6_0(v4900)
                    return v5023 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v5024 : Async<US6> = _v4898 
            let _v4761 = v5024 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v5025 : unit = ()
            let _v5025 =
                async {
                    let! v4756 = v4756 
                    let v5026 : US8 = v4756 
                    let v5150 : US6 =
                        match v5026 with
                        | US8_1(v5029) -> (* Error *)
                            let v5030 : string = $"%A{v5029}"
                            let v5033 : string = "System.TimeoutException"
                            let v5034 : bool = v5030.Contains v5033 
                            if v5034 then
                                let v5037 : unit = ()
                                let v5038 : (unit -> unit) = closure16(v0)
                                let v5039 : unit = (fun () -> v5038 (); v5037) ()
                                US6_1
                            else
                                let v5080 : unit = ()
                                let v5081 : (unit -> unit) = closure17(v0, v5029)
                                let v5082 : unit = (fun () -> v5081 (); v5080) ()
                                US6_1
                        | US8_0(v5027) -> (* Ok *)
                            US6_0(v5027)
                    return v5150 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v5151 : Async<US6> = _v5025 
            let _v4761 = v5151 
            #endif
#else
            let v5152 : unit = ()
            let _v5152 =
                async {
                    let! v4756 = v4756 
                    let v5153 : US8 = v4756 
                    let v5277 : US6 =
                        match v5153 with
                        | US8_1(v5156) -> (* Error *)
                            let v5157 : string = $"%A{v5156}"
                            let v5160 : string = "System.TimeoutException"
                            let v5161 : bool = v5157.Contains v5160 
                            if v5161 then
                                let v5164 : unit = ()
                                let v5165 : (unit -> unit) = closure16(v0)
                                let v5166 : unit = (fun () -> v5165 (); v5164) ()
                                US6_1
                            else
                                let v5207 : unit = ()
                                let v5208 : (unit -> unit) = closure17(v0, v5156)
                                let v5209 : unit = (fun () -> v5208 (); v5207) ()
                                US6_1
                        | US8_0(v5154) -> (* Ok *)
                            US6_0(v5154)
                    return v5277 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v5278 : Async<US6> = _v5152 
            let _v4761 = v5278 
            #endif
            let v5279 : Async<US6> = _v4761 
            return! v5279 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v5284 : Async<US6> = _v4534 
    let _v3022 = v5284 
    #endif
#else
    let v5285 : unit = ()
    let _v5285 =
        async {
            let v5286 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v5287 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v5286 = v5287 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v5290 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v5286 = v5290 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v5293 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v5286 = v5293 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v5296 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v5286 = v5296 
            #endif
#if FABLE_COMPILER_PYTHON
            let v5297 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v5286 = v5297 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v5298 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v5286 = v5298 
            #endif
#else
            let v5299 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v5286 = v5299 
            #endif
            let v5300 : Async<Async<bool>> = _v5286 
            let! v5300 = v5300 
            let v5305 : Async<bool> = v5300 
            let v5306 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v5307 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v5308 : Async<Choice<bool, exn>> = v5307 v5305
            let _v5306 = v5308 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v5309 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v5310 : Async<Choice<bool, exn>> = v5309 v5305
            let _v5306 = v5310 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v5311 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v5312 : Async<Choice<bool, exn>> = v5311 v5305
            let _v5306 = v5312 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v5313 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v5314 : Async<Choice<bool, exn>> = v5313 v5305
            let _v5306 = v5314 
            #endif
#if FABLE_COMPILER_PYTHON
            let v5315 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v5316 : Async<Choice<bool, exn>> = v5315 v5305
            let _v5306 = v5316 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v5317 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v5318 : Async<Choice<bool, exn>> = v5317 v5305
            let _v5306 = v5318 
            #endif
#else
            let v5319 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v5320 : Async<Choice<bool, exn>> = v5319 v5305
            let _v5306 = v5320 
            #endif
            let v5321 : Async<Choice<bool, exn>> = _v5306 
            let v5326 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v5327 : Async<US7> = null |> unbox<Async<US7>>
            let _v5326 = v5327 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v5330 : Async<US7> = null |> unbox<Async<US7>>
            let _v5326 = v5330 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v5333 : Async<US7> = null |> unbox<Async<US7>>
            let _v5326 = v5333 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v5336 : unit = ()
            let _v5336 =
                async {
                    let! v5321 = v5321 
                    let v5337 : Choice<bool, exn> = v5321 
                    let v5338 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v5339 : US7 = null |> unbox<US7>
                    let _v5338 = v5339 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v5342 : US7 = null |> unbox<US7>
                    let _v5338 = v5342 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v5345 : US7 = null |> unbox<US7>
                    let _v5338 = v5345 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v5348 : US7 = null |> unbox<US7>
                    let _v5338 = v5348 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v5351 : US7 = null |> unbox<US7>
                    let _v5338 = v5351 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v5354 : (bool -> US7) = method22()
                    let v5355 : (exn -> US7) = method23()
                    let v5356 : US7 = match v5337 with Choice1Of2 x -> v5354 x | Choice2Of2 x -> v5355 x
                    let _v5338 = v5356 
                    #endif
#else
                    let v5357 : (bool -> US7) = method22()
                    let v5358 : (exn -> US7) = method23()
                    let v5359 : US7 = match v5337 with Choice1Of2 x -> v5357 x | Choice2Of2 x -> v5358 x
                    let _v5338 = v5359 
                    #endif
                    let v5360 : US7 = _v5338 
                    return v5360 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v5365 : Async<US7> = _v5336 
            let _v5326 = v5365 
            #endif
#if FABLE_COMPILER_PYTHON
            let v5366 : unit = ()
            let _v5366 =
                async {
                    let! v5321 = v5321 
                    let v5367 : Choice<bool, exn> = v5321 
                    let v5368 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v5369 : US7 = null |> unbox<US7>
                    let _v5368 = v5369 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v5372 : US7 = null |> unbox<US7>
                    let _v5368 = v5372 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v5375 : US7 = null |> unbox<US7>
                    let _v5368 = v5375 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v5378 : US7 = null |> unbox<US7>
                    let _v5368 = v5378 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v5381 : US7 = null |> unbox<US7>
                    let _v5368 = v5381 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v5384 : (bool -> US7) = method22()
                    let v5385 : (exn -> US7) = method23()
                    let v5386 : US7 = match v5367 with Choice1Of2 x -> v5384 x | Choice2Of2 x -> v5385 x
                    let _v5368 = v5386 
                    #endif
#else
                    let v5387 : (bool -> US7) = method22()
                    let v5388 : (exn -> US7) = method23()
                    let v5389 : US7 = match v5367 with Choice1Of2 x -> v5387 x | Choice2Of2 x -> v5388 x
                    let _v5368 = v5389 
                    #endif
                    let v5390 : US7 = _v5368 
                    return v5390 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v5395 : Async<US7> = _v5366 
            let _v5326 = v5395 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v5396 : unit = ()
            let _v5396 =
                async {
                    let! v5321 = v5321 
                    let v5397 : Choice<bool, exn> = v5321 
                    let v5398 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v5399 : US7 = null |> unbox<US7>
                    let _v5398 = v5399 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v5402 : US7 = null |> unbox<US7>
                    let _v5398 = v5402 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v5405 : US7 = null |> unbox<US7>
                    let _v5398 = v5405 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v5408 : US7 = null |> unbox<US7>
                    let _v5398 = v5408 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v5411 : US7 = null |> unbox<US7>
                    let _v5398 = v5411 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v5414 : (bool -> US7) = method22()
                    let v5415 : (exn -> US7) = method23()
                    let v5416 : US7 = match v5397 with Choice1Of2 x -> v5414 x | Choice2Of2 x -> v5415 x
                    let _v5398 = v5416 
                    #endif
#else
                    let v5417 : (bool -> US7) = method22()
                    let v5418 : (exn -> US7) = method23()
                    let v5419 : US7 = match v5397 with Choice1Of2 x -> v5417 x | Choice2Of2 x -> v5418 x
                    let _v5398 = v5419 
                    #endif
                    let v5420 : US7 = _v5398 
                    return v5420 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v5425 : Async<US7> = _v5396 
            let _v5326 = v5425 
            #endif
#else
            let v5426 : unit = ()
            let _v5426 =
                async {
                    let! v5321 = v5321 
                    let v5427 : Choice<bool, exn> = v5321 
                    let v5428 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v5429 : US7 = null |> unbox<US7>
                    let _v5428 = v5429 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v5432 : US7 = null |> unbox<US7>
                    let _v5428 = v5432 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v5435 : US7 = null |> unbox<US7>
                    let _v5428 = v5435 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v5438 : US7 = null |> unbox<US7>
                    let _v5428 = v5438 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v5441 : US7 = null |> unbox<US7>
                    let _v5428 = v5441 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v5444 : (bool -> US7) = method22()
                    let v5445 : (exn -> US7) = method23()
                    let v5446 : US7 = match v5427 with Choice1Of2 x -> v5444 x | Choice2Of2 x -> v5445 x
                    let _v5428 = v5446 
                    #endif
#else
                    let v5447 : (bool -> US7) = method22()
                    let v5448 : (exn -> US7) = method23()
                    let v5449 : US7 = match v5427 with Choice1Of2 x -> v5447 x | Choice2Of2 x -> v5448 x
                    let _v5428 = v5449 
                    #endif
                    let v5450 : US7 = _v5428 
                    return v5450 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v5455 : Async<US7> = _v5426 
            let _v5326 = v5455 
            #endif
            let v5456 : Async<US7> = _v5326 
            let v5461 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v5462 : Async<US8> = null |> unbox<Async<US8>>
            let _v5461 = v5462 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v5465 : Async<US8> = null |> unbox<Async<US8>>
            let _v5461 = v5465 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v5468 : Async<US8> = null |> unbox<Async<US8>>
            let _v5461 = v5468 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v5471 : unit = ()
            let _v5471 =
                async {
                    let! v5456 = v5456 
                    let v5472 : US7 = v5456 
                    let v5478 : US8 =
                        match v5472 with
                        | US7_0(v5473) -> (* C1of2 *)
                            US8_0(v5473)
                        | US7_1(v5475) -> (* C2of2 *)
                            US8_1(v5475)
                    return v5478 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v5479 : Async<US8> = _v5471 
            let _v5461 = v5479 
            #endif
#if FABLE_COMPILER_PYTHON
            let v5480 : unit = ()
            let _v5480 =
                async {
                    let! v5456 = v5456 
                    let v5481 : US7 = v5456 
                    let v5487 : US8 =
                        match v5481 with
                        | US7_0(v5482) -> (* C1of2 *)
                            US8_0(v5482)
                        | US7_1(v5484) -> (* C2of2 *)
                            US8_1(v5484)
                    return v5487 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v5488 : Async<US8> = _v5480 
            let _v5461 = v5488 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v5489 : unit = ()
            let _v5489 =
                async {
                    let! v5456 = v5456 
                    let v5490 : US7 = v5456 
                    let v5496 : US8 =
                        match v5490 with
                        | US7_0(v5491) -> (* C1of2 *)
                            US8_0(v5491)
                        | US7_1(v5493) -> (* C2of2 *)
                            US8_1(v5493)
                    return v5496 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v5497 : Async<US8> = _v5489 
            let _v5461 = v5497 
            #endif
#else
            let v5498 : unit = ()
            let _v5498 =
                async {
                    let! v5456 = v5456 
                    let v5499 : US7 = v5456 
                    let v5505 : US8 =
                        match v5499 with
                        | US7_0(v5500) -> (* C1of2 *)
                            US8_0(v5500)
                        | US7_1(v5502) -> (* C2of2 *)
                            US8_1(v5502)
                    return v5505 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v5506 : Async<US8> = _v5498 
            let _v5461 = v5506 
            #endif
            let v5507 : Async<US8> = _v5461 
            let v5512 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v5513 : Async<US6> = null |> unbox<Async<US6>>
            let _v5512 = v5513 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v5516 : Async<US6> = null |> unbox<Async<US6>>
            let _v5512 = v5516 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v5519 : Async<US6> = null |> unbox<Async<US6>>
            let _v5512 = v5519 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v5522 : unit = ()
            let _v5522 =
                async {
                    let! v5507 = v5507 
                    let v5523 : US8 = v5507 
                    let v5647 : US6 =
                        match v5523 with
                        | US8_1(v5526) -> (* Error *)
                            let v5527 : string = $"%A{v5526}"
                            let v5530 : string = "System.TimeoutException"
                            let v5531 : bool = v5527.Contains v5530 
                            if v5531 then
                                let v5534 : unit = ()
                                let v5535 : (unit -> unit) = closure16(v0)
                                let v5536 : unit = (fun () -> v5535 (); v5534) ()
                                US6_1
                            else
                                let v5577 : unit = ()
                                let v5578 : (unit -> unit) = closure17(v0, v5526)
                                let v5579 : unit = (fun () -> v5578 (); v5577) ()
                                US6_1
                        | US8_0(v5524) -> (* Ok *)
                            US6_0(v5524)
                    return v5647 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v5648 : Async<US6> = _v5522 
            let _v5512 = v5648 
            #endif
#if FABLE_COMPILER_PYTHON
            let v5649 : unit = ()
            let _v5649 =
                async {
                    let! v5507 = v5507 
                    let v5650 : US8 = v5507 
                    let v5774 : US6 =
                        match v5650 with
                        | US8_1(v5653) -> (* Error *)
                            let v5654 : string = $"%A{v5653}"
                            let v5657 : string = "System.TimeoutException"
                            let v5658 : bool = v5654.Contains v5657 
                            if v5658 then
                                let v5661 : unit = ()
                                let v5662 : (unit -> unit) = closure16(v0)
                                let v5663 : unit = (fun () -> v5662 (); v5661) ()
                                US6_1
                            else
                                let v5704 : unit = ()
                                let v5705 : (unit -> unit) = closure17(v0, v5653)
                                let v5706 : unit = (fun () -> v5705 (); v5704) ()
                                US6_1
                        | US8_0(v5651) -> (* Ok *)
                            US6_0(v5651)
                    return v5774 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v5775 : Async<US6> = _v5649 
            let _v5512 = v5775 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v5776 : unit = ()
            let _v5776 =
                async {
                    let! v5507 = v5507 
                    let v5777 : US8 = v5507 
                    let v5901 : US6 =
                        match v5777 with
                        | US8_1(v5780) -> (* Error *)
                            let v5781 : string = $"%A{v5780}"
                            let v5784 : string = "System.TimeoutException"
                            let v5785 : bool = v5781.Contains v5784 
                            if v5785 then
                                let v5788 : unit = ()
                                let v5789 : (unit -> unit) = closure16(v0)
                                let v5790 : unit = (fun () -> v5789 (); v5788) ()
                                US6_1
                            else
                                let v5831 : unit = ()
                                let v5832 : (unit -> unit) = closure17(v0, v5780)
                                let v5833 : unit = (fun () -> v5832 (); v5831) ()
                                US6_1
                        | US8_0(v5778) -> (* Ok *)
                            US6_0(v5778)
                    return v5901 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v5902 : Async<US6> = _v5776 
            let _v5512 = v5902 
            #endif
#else
            let v5903 : unit = ()
            let _v5903 =
                async {
                    let! v5507 = v5507 
                    let v5904 : US8 = v5507 
                    let v6028 : US6 =
                        match v5904 with
                        | US8_1(v5907) -> (* Error *)
                            let v5908 : string = $"%A{v5907}"
                            let v5911 : string = "System.TimeoutException"
                            let v5912 : bool = v5908.Contains v5911 
                            if v5912 then
                                let v5915 : unit = ()
                                let v5916 : (unit -> unit) = closure16(v0)
                                let v5917 : unit = (fun () -> v5916 (); v5915) ()
                                US6_1
                            else
                                let v5958 : unit = ()
                                let v5959 : (unit -> unit) = closure17(v0, v5907)
                                let v5960 : unit = (fun () -> v5959 (); v5958) ()
                                US6_1
                        | US8_0(v5905) -> (* Ok *)
                            US6_0(v5905)
                    return v6028 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v6029 : Async<US6> = _v5903 
            let _v5512 = v6029 
            #endif
            let v6030 : Async<US6> = _v5512 
            return! v6030 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v6035 : Async<US6> = _v5285 
    let _v3022 = v6035 
    #endif
    let v6036 : Async<US6> = _v3022 
    let _v2 = v6036 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v6041 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v6042 : Async<US6> = null |> unbox<Async<US6>>
    let _v6041 = v6042 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v6045 : Async<US6> = null |> unbox<Async<US6>>
    let _v6041 = v6045 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v6048 : Async<US6> = null |> unbox<Async<US6>>
    let _v6041 = v6048 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v6051 : unit = ()
    let _v6051 =
        async {
            let v6052 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v6053 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v6052 = v6053 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v6056 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v6052 = v6056 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v6059 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v6052 = v6059 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v6062 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v6052 = v6062 
            #endif
#if FABLE_COMPILER_PYTHON
            let v6063 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v6052 = v6063 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v6064 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v6052 = v6064 
            #endif
#else
            let v6065 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v6052 = v6065 
            #endif
            let v6066 : Async<Async<bool>> = _v6052 
            let! v6066 = v6066 
            let v6071 : Async<bool> = v6066 
            let v6072 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v6073 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v6074 : Async<Choice<bool, exn>> = v6073 v6071
            let _v6072 = v6074 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v6075 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v6076 : Async<Choice<bool, exn>> = v6075 v6071
            let _v6072 = v6076 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v6077 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v6078 : Async<Choice<bool, exn>> = v6077 v6071
            let _v6072 = v6078 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v6079 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v6080 : Async<Choice<bool, exn>> = v6079 v6071
            let _v6072 = v6080 
            #endif
#if FABLE_COMPILER_PYTHON
            let v6081 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v6082 : Async<Choice<bool, exn>> = v6081 v6071
            let _v6072 = v6082 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v6083 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v6084 : Async<Choice<bool, exn>> = v6083 v6071
            let _v6072 = v6084 
            #endif
#else
            let v6085 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v6086 : Async<Choice<bool, exn>> = v6085 v6071
            let _v6072 = v6086 
            #endif
            let v6087 : Async<Choice<bool, exn>> = _v6072 
            let v6092 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v6093 : Async<US7> = null |> unbox<Async<US7>>
            let _v6092 = v6093 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v6096 : Async<US7> = null |> unbox<Async<US7>>
            let _v6092 = v6096 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v6099 : Async<US7> = null |> unbox<Async<US7>>
            let _v6092 = v6099 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v6102 : unit = ()
            let _v6102 =
                async {
                    let! v6087 = v6087 
                    let v6103 : Choice<bool, exn> = v6087 
                    let v6104 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v6105 : US7 = null |> unbox<US7>
                    let _v6104 = v6105 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v6108 : US7 = null |> unbox<US7>
                    let _v6104 = v6108 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v6111 : US7 = null |> unbox<US7>
                    let _v6104 = v6111 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v6114 : US7 = null |> unbox<US7>
                    let _v6104 = v6114 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v6117 : US7 = null |> unbox<US7>
                    let _v6104 = v6117 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v6120 : (bool -> US7) = method22()
                    let v6121 : (exn -> US7) = method23()
                    let v6122 : US7 = match v6103 with Choice1Of2 x -> v6120 x | Choice2Of2 x -> v6121 x
                    let _v6104 = v6122 
                    #endif
#else
                    let v6123 : (bool -> US7) = method22()
                    let v6124 : (exn -> US7) = method23()
                    let v6125 : US7 = match v6103 with Choice1Of2 x -> v6123 x | Choice2Of2 x -> v6124 x
                    let _v6104 = v6125 
                    #endif
                    let v6126 : US7 = _v6104 
                    return v6126 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v6131 : Async<US7> = _v6102 
            let _v6092 = v6131 
            #endif
#if FABLE_COMPILER_PYTHON
            let v6132 : unit = ()
            let _v6132 =
                async {
                    let! v6087 = v6087 
                    let v6133 : Choice<bool, exn> = v6087 
                    let v6134 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v6135 : US7 = null |> unbox<US7>
                    let _v6134 = v6135 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v6138 : US7 = null |> unbox<US7>
                    let _v6134 = v6138 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v6141 : US7 = null |> unbox<US7>
                    let _v6134 = v6141 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v6144 : US7 = null |> unbox<US7>
                    let _v6134 = v6144 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v6147 : US7 = null |> unbox<US7>
                    let _v6134 = v6147 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v6150 : (bool -> US7) = method22()
                    let v6151 : (exn -> US7) = method23()
                    let v6152 : US7 = match v6133 with Choice1Of2 x -> v6150 x | Choice2Of2 x -> v6151 x
                    let _v6134 = v6152 
                    #endif
#else
                    let v6153 : (bool -> US7) = method22()
                    let v6154 : (exn -> US7) = method23()
                    let v6155 : US7 = match v6133 with Choice1Of2 x -> v6153 x | Choice2Of2 x -> v6154 x
                    let _v6134 = v6155 
                    #endif
                    let v6156 : US7 = _v6134 
                    return v6156 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v6161 : Async<US7> = _v6132 
            let _v6092 = v6161 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v6162 : unit = ()
            let _v6162 =
                async {
                    let! v6087 = v6087 
                    let v6163 : Choice<bool, exn> = v6087 
                    let v6164 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v6165 : US7 = null |> unbox<US7>
                    let _v6164 = v6165 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v6168 : US7 = null |> unbox<US7>
                    let _v6164 = v6168 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v6171 : US7 = null |> unbox<US7>
                    let _v6164 = v6171 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v6174 : US7 = null |> unbox<US7>
                    let _v6164 = v6174 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v6177 : US7 = null |> unbox<US7>
                    let _v6164 = v6177 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v6180 : (bool -> US7) = method22()
                    let v6181 : (exn -> US7) = method23()
                    let v6182 : US7 = match v6163 with Choice1Of2 x -> v6180 x | Choice2Of2 x -> v6181 x
                    let _v6164 = v6182 
                    #endif
#else
                    let v6183 : (bool -> US7) = method22()
                    let v6184 : (exn -> US7) = method23()
                    let v6185 : US7 = match v6163 with Choice1Of2 x -> v6183 x | Choice2Of2 x -> v6184 x
                    let _v6164 = v6185 
                    #endif
                    let v6186 : US7 = _v6164 
                    return v6186 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v6191 : Async<US7> = _v6162 
            let _v6092 = v6191 
            #endif
#else
            let v6192 : unit = ()
            let _v6192 =
                async {
                    let! v6087 = v6087 
                    let v6193 : Choice<bool, exn> = v6087 
                    let v6194 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v6195 : US7 = null |> unbox<US7>
                    let _v6194 = v6195 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v6198 : US7 = null |> unbox<US7>
                    let _v6194 = v6198 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v6201 : US7 = null |> unbox<US7>
                    let _v6194 = v6201 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v6204 : US7 = null |> unbox<US7>
                    let _v6194 = v6204 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v6207 : US7 = null |> unbox<US7>
                    let _v6194 = v6207 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v6210 : (bool -> US7) = method22()
                    let v6211 : (exn -> US7) = method23()
                    let v6212 : US7 = match v6193 with Choice1Of2 x -> v6210 x | Choice2Of2 x -> v6211 x
                    let _v6194 = v6212 
                    #endif
#else
                    let v6213 : (bool -> US7) = method22()
                    let v6214 : (exn -> US7) = method23()
                    let v6215 : US7 = match v6193 with Choice1Of2 x -> v6213 x | Choice2Of2 x -> v6214 x
                    let _v6194 = v6215 
                    #endif
                    let v6216 : US7 = _v6194 
                    return v6216 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v6221 : Async<US7> = _v6192 
            let _v6092 = v6221 
            #endif
            let v6222 : Async<US7> = _v6092 
            let v6227 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v6228 : Async<US8> = null |> unbox<Async<US8>>
            let _v6227 = v6228 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v6231 : Async<US8> = null |> unbox<Async<US8>>
            let _v6227 = v6231 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v6234 : Async<US8> = null |> unbox<Async<US8>>
            let _v6227 = v6234 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v6237 : unit = ()
            let _v6237 =
                async {
                    let! v6222 = v6222 
                    let v6238 : US7 = v6222 
                    let v6244 : US8 =
                        match v6238 with
                        | US7_0(v6239) -> (* C1of2 *)
                            US8_0(v6239)
                        | US7_1(v6241) -> (* C2of2 *)
                            US8_1(v6241)
                    return v6244 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v6245 : Async<US8> = _v6237 
            let _v6227 = v6245 
            #endif
#if FABLE_COMPILER_PYTHON
            let v6246 : unit = ()
            let _v6246 =
                async {
                    let! v6222 = v6222 
                    let v6247 : US7 = v6222 
                    let v6253 : US8 =
                        match v6247 with
                        | US7_0(v6248) -> (* C1of2 *)
                            US8_0(v6248)
                        | US7_1(v6250) -> (* C2of2 *)
                            US8_1(v6250)
                    return v6253 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v6254 : Async<US8> = _v6246 
            let _v6227 = v6254 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v6255 : unit = ()
            let _v6255 =
                async {
                    let! v6222 = v6222 
                    let v6256 : US7 = v6222 
                    let v6262 : US8 =
                        match v6256 with
                        | US7_0(v6257) -> (* C1of2 *)
                            US8_0(v6257)
                        | US7_1(v6259) -> (* C2of2 *)
                            US8_1(v6259)
                    return v6262 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v6263 : Async<US8> = _v6255 
            let _v6227 = v6263 
            #endif
#else
            let v6264 : unit = ()
            let _v6264 =
                async {
                    let! v6222 = v6222 
                    let v6265 : US7 = v6222 
                    let v6271 : US8 =
                        match v6265 with
                        | US7_0(v6266) -> (* C1of2 *)
                            US8_0(v6266)
                        | US7_1(v6268) -> (* C2of2 *)
                            US8_1(v6268)
                    return v6271 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v6272 : Async<US8> = _v6264 
            let _v6227 = v6272 
            #endif
            let v6273 : Async<US8> = _v6227 
            let v6278 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v6279 : Async<US6> = null |> unbox<Async<US6>>
            let _v6278 = v6279 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v6282 : Async<US6> = null |> unbox<Async<US6>>
            let _v6278 = v6282 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v6285 : Async<US6> = null |> unbox<Async<US6>>
            let _v6278 = v6285 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v6288 : unit = ()
            let _v6288 =
                async {
                    let! v6273 = v6273 
                    let v6289 : US8 = v6273 
                    let v6413 : US6 =
                        match v6289 with
                        | US8_1(v6292) -> (* Error *)
                            let v6293 : string = $"%A{v6292}"
                            let v6296 : string = "System.TimeoutException"
                            let v6297 : bool = v6293.Contains v6296 
                            if v6297 then
                                let v6300 : unit = ()
                                let v6301 : (unit -> unit) = closure16(v0)
                                let v6302 : unit = (fun () -> v6301 (); v6300) ()
                                US6_1
                            else
                                let v6343 : unit = ()
                                let v6344 : (unit -> unit) = closure17(v0, v6292)
                                let v6345 : unit = (fun () -> v6344 (); v6343) ()
                                US6_1
                        | US8_0(v6290) -> (* Ok *)
                            US6_0(v6290)
                    return v6413 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v6414 : Async<US6> = _v6288 
            let _v6278 = v6414 
            #endif
#if FABLE_COMPILER_PYTHON
            let v6415 : unit = ()
            let _v6415 =
                async {
                    let! v6273 = v6273 
                    let v6416 : US8 = v6273 
                    let v6540 : US6 =
                        match v6416 with
                        | US8_1(v6419) -> (* Error *)
                            let v6420 : string = $"%A{v6419}"
                            let v6423 : string = "System.TimeoutException"
                            let v6424 : bool = v6420.Contains v6423 
                            if v6424 then
                                let v6427 : unit = ()
                                let v6428 : (unit -> unit) = closure16(v0)
                                let v6429 : unit = (fun () -> v6428 (); v6427) ()
                                US6_1
                            else
                                let v6470 : unit = ()
                                let v6471 : (unit -> unit) = closure17(v0, v6419)
                                let v6472 : unit = (fun () -> v6471 (); v6470) ()
                                US6_1
                        | US8_0(v6417) -> (* Ok *)
                            US6_0(v6417)
                    return v6540 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v6541 : Async<US6> = _v6415 
            let _v6278 = v6541 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v6542 : unit = ()
            let _v6542 =
                async {
                    let! v6273 = v6273 
                    let v6543 : US8 = v6273 
                    let v6667 : US6 =
                        match v6543 with
                        | US8_1(v6546) -> (* Error *)
                            let v6547 : string = $"%A{v6546}"
                            let v6550 : string = "System.TimeoutException"
                            let v6551 : bool = v6547.Contains v6550 
                            if v6551 then
                                let v6554 : unit = ()
                                let v6555 : (unit -> unit) = closure16(v0)
                                let v6556 : unit = (fun () -> v6555 (); v6554) ()
                                US6_1
                            else
                                let v6597 : unit = ()
                                let v6598 : (unit -> unit) = closure17(v0, v6546)
                                let v6599 : unit = (fun () -> v6598 (); v6597) ()
                                US6_1
                        | US8_0(v6544) -> (* Ok *)
                            US6_0(v6544)
                    return v6667 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v6668 : Async<US6> = _v6542 
            let _v6278 = v6668 
            #endif
#else
            let v6669 : unit = ()
            let _v6669 =
                async {
                    let! v6273 = v6273 
                    let v6670 : US8 = v6273 
                    let v6794 : US6 =
                        match v6670 with
                        | US8_1(v6673) -> (* Error *)
                            let v6674 : string = $"%A{v6673}"
                            let v6677 : string = "System.TimeoutException"
                            let v6678 : bool = v6674.Contains v6677 
                            if v6678 then
                                let v6681 : unit = ()
                                let v6682 : (unit -> unit) = closure16(v0)
                                let v6683 : unit = (fun () -> v6682 (); v6681) ()
                                US6_1
                            else
                                let v6724 : unit = ()
                                let v6725 : (unit -> unit) = closure17(v0, v6673)
                                let v6726 : unit = (fun () -> v6725 (); v6724) ()
                                US6_1
                        | US8_0(v6671) -> (* Ok *)
                            US6_0(v6671)
                    return v6794 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v6795 : Async<US6> = _v6669 
            let _v6278 = v6795 
            #endif
            let v6796 : Async<US6> = _v6278 
            return! v6796 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v6801 : Async<US6> = _v6051 
    let _v6041 = v6801 
    #endif
#if FABLE_COMPILER_PYTHON
    let v6802 : unit = ()
    let _v6802 =
        async {
            let v6803 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v6804 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v6803 = v6804 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v6807 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v6803 = v6807 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v6810 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v6803 = v6810 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v6813 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v6803 = v6813 
            #endif
#if FABLE_COMPILER_PYTHON
            let v6814 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v6803 = v6814 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v6815 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v6803 = v6815 
            #endif
#else
            let v6816 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v6803 = v6816 
            #endif
            let v6817 : Async<Async<bool>> = _v6803 
            let! v6817 = v6817 
            let v6822 : Async<bool> = v6817 
            let v6823 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v6824 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v6825 : Async<Choice<bool, exn>> = v6824 v6822
            let _v6823 = v6825 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v6826 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v6827 : Async<Choice<bool, exn>> = v6826 v6822
            let _v6823 = v6827 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v6828 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v6829 : Async<Choice<bool, exn>> = v6828 v6822
            let _v6823 = v6829 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v6830 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v6831 : Async<Choice<bool, exn>> = v6830 v6822
            let _v6823 = v6831 
            #endif
#if FABLE_COMPILER_PYTHON
            let v6832 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v6833 : Async<Choice<bool, exn>> = v6832 v6822
            let _v6823 = v6833 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v6834 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v6835 : Async<Choice<bool, exn>> = v6834 v6822
            let _v6823 = v6835 
            #endif
#else
            let v6836 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v6837 : Async<Choice<bool, exn>> = v6836 v6822
            let _v6823 = v6837 
            #endif
            let v6838 : Async<Choice<bool, exn>> = _v6823 
            let v6843 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v6844 : Async<US7> = null |> unbox<Async<US7>>
            let _v6843 = v6844 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v6847 : Async<US7> = null |> unbox<Async<US7>>
            let _v6843 = v6847 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v6850 : Async<US7> = null |> unbox<Async<US7>>
            let _v6843 = v6850 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v6853 : unit = ()
            let _v6853 =
                async {
                    let! v6838 = v6838 
                    let v6854 : Choice<bool, exn> = v6838 
                    let v6855 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v6856 : US7 = null |> unbox<US7>
                    let _v6855 = v6856 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v6859 : US7 = null |> unbox<US7>
                    let _v6855 = v6859 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v6862 : US7 = null |> unbox<US7>
                    let _v6855 = v6862 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v6865 : US7 = null |> unbox<US7>
                    let _v6855 = v6865 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v6868 : US7 = null |> unbox<US7>
                    let _v6855 = v6868 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v6871 : (bool -> US7) = method22()
                    let v6872 : (exn -> US7) = method23()
                    let v6873 : US7 = match v6854 with Choice1Of2 x -> v6871 x | Choice2Of2 x -> v6872 x
                    let _v6855 = v6873 
                    #endif
#else
                    let v6874 : (bool -> US7) = method22()
                    let v6875 : (exn -> US7) = method23()
                    let v6876 : US7 = match v6854 with Choice1Of2 x -> v6874 x | Choice2Of2 x -> v6875 x
                    let _v6855 = v6876 
                    #endif
                    let v6877 : US7 = _v6855 
                    return v6877 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v6882 : Async<US7> = _v6853 
            let _v6843 = v6882 
            #endif
#if FABLE_COMPILER_PYTHON
            let v6883 : unit = ()
            let _v6883 =
                async {
                    let! v6838 = v6838 
                    let v6884 : Choice<bool, exn> = v6838 
                    let v6885 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v6886 : US7 = null |> unbox<US7>
                    let _v6885 = v6886 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v6889 : US7 = null |> unbox<US7>
                    let _v6885 = v6889 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v6892 : US7 = null |> unbox<US7>
                    let _v6885 = v6892 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v6895 : US7 = null |> unbox<US7>
                    let _v6885 = v6895 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v6898 : US7 = null |> unbox<US7>
                    let _v6885 = v6898 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v6901 : (bool -> US7) = method22()
                    let v6902 : (exn -> US7) = method23()
                    let v6903 : US7 = match v6884 with Choice1Of2 x -> v6901 x | Choice2Of2 x -> v6902 x
                    let _v6885 = v6903 
                    #endif
#else
                    let v6904 : (bool -> US7) = method22()
                    let v6905 : (exn -> US7) = method23()
                    let v6906 : US7 = match v6884 with Choice1Of2 x -> v6904 x | Choice2Of2 x -> v6905 x
                    let _v6885 = v6906 
                    #endif
                    let v6907 : US7 = _v6885 
                    return v6907 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v6912 : Async<US7> = _v6883 
            let _v6843 = v6912 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v6913 : unit = ()
            let _v6913 =
                async {
                    let! v6838 = v6838 
                    let v6914 : Choice<bool, exn> = v6838 
                    let v6915 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v6916 : US7 = null |> unbox<US7>
                    let _v6915 = v6916 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v6919 : US7 = null |> unbox<US7>
                    let _v6915 = v6919 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v6922 : US7 = null |> unbox<US7>
                    let _v6915 = v6922 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v6925 : US7 = null |> unbox<US7>
                    let _v6915 = v6925 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v6928 : US7 = null |> unbox<US7>
                    let _v6915 = v6928 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v6931 : (bool -> US7) = method22()
                    let v6932 : (exn -> US7) = method23()
                    let v6933 : US7 = match v6914 with Choice1Of2 x -> v6931 x | Choice2Of2 x -> v6932 x
                    let _v6915 = v6933 
                    #endif
#else
                    let v6934 : (bool -> US7) = method22()
                    let v6935 : (exn -> US7) = method23()
                    let v6936 : US7 = match v6914 with Choice1Of2 x -> v6934 x | Choice2Of2 x -> v6935 x
                    let _v6915 = v6936 
                    #endif
                    let v6937 : US7 = _v6915 
                    return v6937 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v6942 : Async<US7> = _v6913 
            let _v6843 = v6942 
            #endif
#else
            let v6943 : unit = ()
            let _v6943 =
                async {
                    let! v6838 = v6838 
                    let v6944 : Choice<bool, exn> = v6838 
                    let v6945 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v6946 : US7 = null |> unbox<US7>
                    let _v6945 = v6946 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v6949 : US7 = null |> unbox<US7>
                    let _v6945 = v6949 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v6952 : US7 = null |> unbox<US7>
                    let _v6945 = v6952 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v6955 : US7 = null |> unbox<US7>
                    let _v6945 = v6955 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v6958 : US7 = null |> unbox<US7>
                    let _v6945 = v6958 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v6961 : (bool -> US7) = method22()
                    let v6962 : (exn -> US7) = method23()
                    let v6963 : US7 = match v6944 with Choice1Of2 x -> v6961 x | Choice2Of2 x -> v6962 x
                    let _v6945 = v6963 
                    #endif
#else
                    let v6964 : (bool -> US7) = method22()
                    let v6965 : (exn -> US7) = method23()
                    let v6966 : US7 = match v6944 with Choice1Of2 x -> v6964 x | Choice2Of2 x -> v6965 x
                    let _v6945 = v6966 
                    #endif
                    let v6967 : US7 = _v6945 
                    return v6967 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v6972 : Async<US7> = _v6943 
            let _v6843 = v6972 
            #endif
            let v6973 : Async<US7> = _v6843 
            let v6978 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v6979 : Async<US8> = null |> unbox<Async<US8>>
            let _v6978 = v6979 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v6982 : Async<US8> = null |> unbox<Async<US8>>
            let _v6978 = v6982 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v6985 : Async<US8> = null |> unbox<Async<US8>>
            let _v6978 = v6985 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v6988 : unit = ()
            let _v6988 =
                async {
                    let! v6973 = v6973 
                    let v6989 : US7 = v6973 
                    let v6995 : US8 =
                        match v6989 with
                        | US7_0(v6990) -> (* C1of2 *)
                            US8_0(v6990)
                        | US7_1(v6992) -> (* C2of2 *)
                            US8_1(v6992)
                    return v6995 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v6996 : Async<US8> = _v6988 
            let _v6978 = v6996 
            #endif
#if FABLE_COMPILER_PYTHON
            let v6997 : unit = ()
            let _v6997 =
                async {
                    let! v6973 = v6973 
                    let v6998 : US7 = v6973 
                    let v7004 : US8 =
                        match v6998 with
                        | US7_0(v6999) -> (* C1of2 *)
                            US8_0(v6999)
                        | US7_1(v7001) -> (* C2of2 *)
                            US8_1(v7001)
                    return v7004 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v7005 : Async<US8> = _v6997 
            let _v6978 = v7005 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v7006 : unit = ()
            let _v7006 =
                async {
                    let! v6973 = v6973 
                    let v7007 : US7 = v6973 
                    let v7013 : US8 =
                        match v7007 with
                        | US7_0(v7008) -> (* C1of2 *)
                            US8_0(v7008)
                        | US7_1(v7010) -> (* C2of2 *)
                            US8_1(v7010)
                    return v7013 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v7014 : Async<US8> = _v7006 
            let _v6978 = v7014 
            #endif
#else
            let v7015 : unit = ()
            let _v7015 =
                async {
                    let! v6973 = v6973 
                    let v7016 : US7 = v6973 
                    let v7022 : US8 =
                        match v7016 with
                        | US7_0(v7017) -> (* C1of2 *)
                            US8_0(v7017)
                        | US7_1(v7019) -> (* C2of2 *)
                            US8_1(v7019)
                    return v7022 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v7023 : Async<US8> = _v7015 
            let _v6978 = v7023 
            #endif
            let v7024 : Async<US8> = _v6978 
            let v7029 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v7030 : Async<US6> = null |> unbox<Async<US6>>
            let _v7029 = v7030 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v7033 : Async<US6> = null |> unbox<Async<US6>>
            let _v7029 = v7033 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v7036 : Async<US6> = null |> unbox<Async<US6>>
            let _v7029 = v7036 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v7039 : unit = ()
            let _v7039 =
                async {
                    let! v7024 = v7024 
                    let v7040 : US8 = v7024 
                    let v7164 : US6 =
                        match v7040 with
                        | US8_1(v7043) -> (* Error *)
                            let v7044 : string = $"%A{v7043}"
                            let v7047 : string = "System.TimeoutException"
                            let v7048 : bool = v7044.Contains v7047 
                            if v7048 then
                                let v7051 : unit = ()
                                let v7052 : (unit -> unit) = closure16(v0)
                                let v7053 : unit = (fun () -> v7052 (); v7051) ()
                                US6_1
                            else
                                let v7094 : unit = ()
                                let v7095 : (unit -> unit) = closure17(v0, v7043)
                                let v7096 : unit = (fun () -> v7095 (); v7094) ()
                                US6_1
                        | US8_0(v7041) -> (* Ok *)
                            US6_0(v7041)
                    return v7164 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v7165 : Async<US6> = _v7039 
            let _v7029 = v7165 
            #endif
#if FABLE_COMPILER_PYTHON
            let v7166 : unit = ()
            let _v7166 =
                async {
                    let! v7024 = v7024 
                    let v7167 : US8 = v7024 
                    let v7291 : US6 =
                        match v7167 with
                        | US8_1(v7170) -> (* Error *)
                            let v7171 : string = $"%A{v7170}"
                            let v7174 : string = "System.TimeoutException"
                            let v7175 : bool = v7171.Contains v7174 
                            if v7175 then
                                let v7178 : unit = ()
                                let v7179 : (unit -> unit) = closure16(v0)
                                let v7180 : unit = (fun () -> v7179 (); v7178) ()
                                US6_1
                            else
                                let v7221 : unit = ()
                                let v7222 : (unit -> unit) = closure17(v0, v7170)
                                let v7223 : unit = (fun () -> v7222 (); v7221) ()
                                US6_1
                        | US8_0(v7168) -> (* Ok *)
                            US6_0(v7168)
                    return v7291 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v7292 : Async<US6> = _v7166 
            let _v7029 = v7292 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v7293 : unit = ()
            let _v7293 =
                async {
                    let! v7024 = v7024 
                    let v7294 : US8 = v7024 
                    let v7418 : US6 =
                        match v7294 with
                        | US8_1(v7297) -> (* Error *)
                            let v7298 : string = $"%A{v7297}"
                            let v7301 : string = "System.TimeoutException"
                            let v7302 : bool = v7298.Contains v7301 
                            if v7302 then
                                let v7305 : unit = ()
                                let v7306 : (unit -> unit) = closure16(v0)
                                let v7307 : unit = (fun () -> v7306 (); v7305) ()
                                US6_1
                            else
                                let v7348 : unit = ()
                                let v7349 : (unit -> unit) = closure17(v0, v7297)
                                let v7350 : unit = (fun () -> v7349 (); v7348) ()
                                US6_1
                        | US8_0(v7295) -> (* Ok *)
                            US6_0(v7295)
                    return v7418 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v7419 : Async<US6> = _v7293 
            let _v7029 = v7419 
            #endif
#else
            let v7420 : unit = ()
            let _v7420 =
                async {
                    let! v7024 = v7024 
                    let v7421 : US8 = v7024 
                    let v7545 : US6 =
                        match v7421 with
                        | US8_1(v7424) -> (* Error *)
                            let v7425 : string = $"%A{v7424}"
                            let v7428 : string = "System.TimeoutException"
                            let v7429 : bool = v7425.Contains v7428 
                            if v7429 then
                                let v7432 : unit = ()
                                let v7433 : (unit -> unit) = closure16(v0)
                                let v7434 : unit = (fun () -> v7433 (); v7432) ()
                                US6_1
                            else
                                let v7475 : unit = ()
                                let v7476 : (unit -> unit) = closure17(v0, v7424)
                                let v7477 : unit = (fun () -> v7476 (); v7475) ()
                                US6_1
                        | US8_0(v7422) -> (* Ok *)
                            US6_0(v7422)
                    return v7545 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v7546 : Async<US6> = _v7420 
            let _v7029 = v7546 
            #endif
            let v7547 : Async<US6> = _v7029 
            return! v7547 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v7552 : Async<US6> = _v6802 
    let _v6041 = v7552 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v7553 : unit = ()
    let _v7553 =
        async {
            let v7554 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v7555 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v7554 = v7555 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v7558 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v7554 = v7558 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v7561 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v7554 = v7561 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v7564 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v7554 = v7564 
            #endif
#if FABLE_COMPILER_PYTHON
            let v7565 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v7554 = v7565 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v7566 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v7554 = v7566 
            #endif
#else
            let v7567 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v7554 = v7567 
            #endif
            let v7568 : Async<Async<bool>> = _v7554 
            let! v7568 = v7568 
            let v7573 : Async<bool> = v7568 
            let v7574 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v7575 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v7576 : Async<Choice<bool, exn>> = v7575 v7573
            let _v7574 = v7576 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v7577 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v7578 : Async<Choice<bool, exn>> = v7577 v7573
            let _v7574 = v7578 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v7579 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v7580 : Async<Choice<bool, exn>> = v7579 v7573
            let _v7574 = v7580 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v7581 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v7582 : Async<Choice<bool, exn>> = v7581 v7573
            let _v7574 = v7582 
            #endif
#if FABLE_COMPILER_PYTHON
            let v7583 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v7584 : Async<Choice<bool, exn>> = v7583 v7573
            let _v7574 = v7584 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v7585 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v7586 : Async<Choice<bool, exn>> = v7585 v7573
            let _v7574 = v7586 
            #endif
#else
            let v7587 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v7588 : Async<Choice<bool, exn>> = v7587 v7573
            let _v7574 = v7588 
            #endif
            let v7589 : Async<Choice<bool, exn>> = _v7574 
            let v7594 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v7595 : Async<US7> = null |> unbox<Async<US7>>
            let _v7594 = v7595 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v7598 : Async<US7> = null |> unbox<Async<US7>>
            let _v7594 = v7598 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v7601 : Async<US7> = null |> unbox<Async<US7>>
            let _v7594 = v7601 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v7604 : unit = ()
            let _v7604 =
                async {
                    let! v7589 = v7589 
                    let v7605 : Choice<bool, exn> = v7589 
                    let v7606 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v7607 : US7 = null |> unbox<US7>
                    let _v7606 = v7607 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v7610 : US7 = null |> unbox<US7>
                    let _v7606 = v7610 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v7613 : US7 = null |> unbox<US7>
                    let _v7606 = v7613 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v7616 : US7 = null |> unbox<US7>
                    let _v7606 = v7616 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v7619 : US7 = null |> unbox<US7>
                    let _v7606 = v7619 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v7622 : (bool -> US7) = method22()
                    let v7623 : (exn -> US7) = method23()
                    let v7624 : US7 = match v7605 with Choice1Of2 x -> v7622 x | Choice2Of2 x -> v7623 x
                    let _v7606 = v7624 
                    #endif
#else
                    let v7625 : (bool -> US7) = method22()
                    let v7626 : (exn -> US7) = method23()
                    let v7627 : US7 = match v7605 with Choice1Of2 x -> v7625 x | Choice2Of2 x -> v7626 x
                    let _v7606 = v7627 
                    #endif
                    let v7628 : US7 = _v7606 
                    return v7628 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v7633 : Async<US7> = _v7604 
            let _v7594 = v7633 
            #endif
#if FABLE_COMPILER_PYTHON
            let v7634 : unit = ()
            let _v7634 =
                async {
                    let! v7589 = v7589 
                    let v7635 : Choice<bool, exn> = v7589 
                    let v7636 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v7637 : US7 = null |> unbox<US7>
                    let _v7636 = v7637 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v7640 : US7 = null |> unbox<US7>
                    let _v7636 = v7640 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v7643 : US7 = null |> unbox<US7>
                    let _v7636 = v7643 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v7646 : US7 = null |> unbox<US7>
                    let _v7636 = v7646 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v7649 : US7 = null |> unbox<US7>
                    let _v7636 = v7649 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v7652 : (bool -> US7) = method22()
                    let v7653 : (exn -> US7) = method23()
                    let v7654 : US7 = match v7635 with Choice1Of2 x -> v7652 x | Choice2Of2 x -> v7653 x
                    let _v7636 = v7654 
                    #endif
#else
                    let v7655 : (bool -> US7) = method22()
                    let v7656 : (exn -> US7) = method23()
                    let v7657 : US7 = match v7635 with Choice1Of2 x -> v7655 x | Choice2Of2 x -> v7656 x
                    let _v7636 = v7657 
                    #endif
                    let v7658 : US7 = _v7636 
                    return v7658 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v7663 : Async<US7> = _v7634 
            let _v7594 = v7663 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v7664 : unit = ()
            let _v7664 =
                async {
                    let! v7589 = v7589 
                    let v7665 : Choice<bool, exn> = v7589 
                    let v7666 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v7667 : US7 = null |> unbox<US7>
                    let _v7666 = v7667 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v7670 : US7 = null |> unbox<US7>
                    let _v7666 = v7670 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v7673 : US7 = null |> unbox<US7>
                    let _v7666 = v7673 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v7676 : US7 = null |> unbox<US7>
                    let _v7666 = v7676 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v7679 : US7 = null |> unbox<US7>
                    let _v7666 = v7679 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v7682 : (bool -> US7) = method22()
                    let v7683 : (exn -> US7) = method23()
                    let v7684 : US7 = match v7665 with Choice1Of2 x -> v7682 x | Choice2Of2 x -> v7683 x
                    let _v7666 = v7684 
                    #endif
#else
                    let v7685 : (bool -> US7) = method22()
                    let v7686 : (exn -> US7) = method23()
                    let v7687 : US7 = match v7665 with Choice1Of2 x -> v7685 x | Choice2Of2 x -> v7686 x
                    let _v7666 = v7687 
                    #endif
                    let v7688 : US7 = _v7666 
                    return v7688 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v7693 : Async<US7> = _v7664 
            let _v7594 = v7693 
            #endif
#else
            let v7694 : unit = ()
            let _v7694 =
                async {
                    let! v7589 = v7589 
                    let v7695 : Choice<bool, exn> = v7589 
                    let v7696 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v7697 : US7 = null |> unbox<US7>
                    let _v7696 = v7697 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v7700 : US7 = null |> unbox<US7>
                    let _v7696 = v7700 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v7703 : US7 = null |> unbox<US7>
                    let _v7696 = v7703 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v7706 : US7 = null |> unbox<US7>
                    let _v7696 = v7706 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v7709 : US7 = null |> unbox<US7>
                    let _v7696 = v7709 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v7712 : (bool -> US7) = method22()
                    let v7713 : (exn -> US7) = method23()
                    let v7714 : US7 = match v7695 with Choice1Of2 x -> v7712 x | Choice2Of2 x -> v7713 x
                    let _v7696 = v7714 
                    #endif
#else
                    let v7715 : (bool -> US7) = method22()
                    let v7716 : (exn -> US7) = method23()
                    let v7717 : US7 = match v7695 with Choice1Of2 x -> v7715 x | Choice2Of2 x -> v7716 x
                    let _v7696 = v7717 
                    #endif
                    let v7718 : US7 = _v7696 
                    return v7718 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v7723 : Async<US7> = _v7694 
            let _v7594 = v7723 
            #endif
            let v7724 : Async<US7> = _v7594 
            let v7729 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v7730 : Async<US8> = null |> unbox<Async<US8>>
            let _v7729 = v7730 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v7733 : Async<US8> = null |> unbox<Async<US8>>
            let _v7729 = v7733 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v7736 : Async<US8> = null |> unbox<Async<US8>>
            let _v7729 = v7736 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v7739 : unit = ()
            let _v7739 =
                async {
                    let! v7724 = v7724 
                    let v7740 : US7 = v7724 
                    let v7746 : US8 =
                        match v7740 with
                        | US7_0(v7741) -> (* C1of2 *)
                            US8_0(v7741)
                        | US7_1(v7743) -> (* C2of2 *)
                            US8_1(v7743)
                    return v7746 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v7747 : Async<US8> = _v7739 
            let _v7729 = v7747 
            #endif
#if FABLE_COMPILER_PYTHON
            let v7748 : unit = ()
            let _v7748 =
                async {
                    let! v7724 = v7724 
                    let v7749 : US7 = v7724 
                    let v7755 : US8 =
                        match v7749 with
                        | US7_0(v7750) -> (* C1of2 *)
                            US8_0(v7750)
                        | US7_1(v7752) -> (* C2of2 *)
                            US8_1(v7752)
                    return v7755 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v7756 : Async<US8> = _v7748 
            let _v7729 = v7756 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v7757 : unit = ()
            let _v7757 =
                async {
                    let! v7724 = v7724 
                    let v7758 : US7 = v7724 
                    let v7764 : US8 =
                        match v7758 with
                        | US7_0(v7759) -> (* C1of2 *)
                            US8_0(v7759)
                        | US7_1(v7761) -> (* C2of2 *)
                            US8_1(v7761)
                    return v7764 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v7765 : Async<US8> = _v7757 
            let _v7729 = v7765 
            #endif
#else
            let v7766 : unit = ()
            let _v7766 =
                async {
                    let! v7724 = v7724 
                    let v7767 : US7 = v7724 
                    let v7773 : US8 =
                        match v7767 with
                        | US7_0(v7768) -> (* C1of2 *)
                            US8_0(v7768)
                        | US7_1(v7770) -> (* C2of2 *)
                            US8_1(v7770)
                    return v7773 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v7774 : Async<US8> = _v7766 
            let _v7729 = v7774 
            #endif
            let v7775 : Async<US8> = _v7729 
            let v7780 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v7781 : Async<US6> = null |> unbox<Async<US6>>
            let _v7780 = v7781 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v7784 : Async<US6> = null |> unbox<Async<US6>>
            let _v7780 = v7784 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v7787 : Async<US6> = null |> unbox<Async<US6>>
            let _v7780 = v7787 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v7790 : unit = ()
            let _v7790 =
                async {
                    let! v7775 = v7775 
                    let v7791 : US8 = v7775 
                    let v7915 : US6 =
                        match v7791 with
                        | US8_1(v7794) -> (* Error *)
                            let v7795 : string = $"%A{v7794}"
                            let v7798 : string = "System.TimeoutException"
                            let v7799 : bool = v7795.Contains v7798 
                            if v7799 then
                                let v7802 : unit = ()
                                let v7803 : (unit -> unit) = closure16(v0)
                                let v7804 : unit = (fun () -> v7803 (); v7802) ()
                                US6_1
                            else
                                let v7845 : unit = ()
                                let v7846 : (unit -> unit) = closure17(v0, v7794)
                                let v7847 : unit = (fun () -> v7846 (); v7845) ()
                                US6_1
                        | US8_0(v7792) -> (* Ok *)
                            US6_0(v7792)
                    return v7915 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v7916 : Async<US6> = _v7790 
            let _v7780 = v7916 
            #endif
#if FABLE_COMPILER_PYTHON
            let v7917 : unit = ()
            let _v7917 =
                async {
                    let! v7775 = v7775 
                    let v7918 : US8 = v7775 
                    let v8042 : US6 =
                        match v7918 with
                        | US8_1(v7921) -> (* Error *)
                            let v7922 : string = $"%A{v7921}"
                            let v7925 : string = "System.TimeoutException"
                            let v7926 : bool = v7922.Contains v7925 
                            if v7926 then
                                let v7929 : unit = ()
                                let v7930 : (unit -> unit) = closure16(v0)
                                let v7931 : unit = (fun () -> v7930 (); v7929) ()
                                US6_1
                            else
                                let v7972 : unit = ()
                                let v7973 : (unit -> unit) = closure17(v0, v7921)
                                let v7974 : unit = (fun () -> v7973 (); v7972) ()
                                US6_1
                        | US8_0(v7919) -> (* Ok *)
                            US6_0(v7919)
                    return v8042 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v8043 : Async<US6> = _v7917 
            let _v7780 = v8043 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v8044 : unit = ()
            let _v8044 =
                async {
                    let! v7775 = v7775 
                    let v8045 : US8 = v7775 
                    let v8169 : US6 =
                        match v8045 with
                        | US8_1(v8048) -> (* Error *)
                            let v8049 : string = $"%A{v8048}"
                            let v8052 : string = "System.TimeoutException"
                            let v8053 : bool = v8049.Contains v8052 
                            if v8053 then
                                let v8056 : unit = ()
                                let v8057 : (unit -> unit) = closure16(v0)
                                let v8058 : unit = (fun () -> v8057 (); v8056) ()
                                US6_1
                            else
                                let v8099 : unit = ()
                                let v8100 : (unit -> unit) = closure17(v0, v8048)
                                let v8101 : unit = (fun () -> v8100 (); v8099) ()
                                US6_1
                        | US8_0(v8046) -> (* Ok *)
                            US6_0(v8046)
                    return v8169 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v8170 : Async<US6> = _v8044 
            let _v7780 = v8170 
            #endif
#else
            let v8171 : unit = ()
            let _v8171 =
                async {
                    let! v7775 = v7775 
                    let v8172 : US8 = v7775 
                    let v8296 : US6 =
                        match v8172 with
                        | US8_1(v8175) -> (* Error *)
                            let v8176 : string = $"%A{v8175}"
                            let v8179 : string = "System.TimeoutException"
                            let v8180 : bool = v8176.Contains v8179 
                            if v8180 then
                                let v8183 : unit = ()
                                let v8184 : (unit -> unit) = closure16(v0)
                                let v8185 : unit = (fun () -> v8184 (); v8183) ()
                                US6_1
                            else
                                let v8226 : unit = ()
                                let v8227 : (unit -> unit) = closure17(v0, v8175)
                                let v8228 : unit = (fun () -> v8227 (); v8226) ()
                                US6_1
                        | US8_0(v8173) -> (* Ok *)
                            US6_0(v8173)
                    return v8296 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v8297 : Async<US6> = _v8171 
            let _v7780 = v8297 
            #endif
            let v8298 : Async<US6> = _v7780 
            return! v8298 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v8303 : Async<US6> = _v7553 
    let _v6041 = v8303 
    #endif
#else
    let v8304 : unit = ()
    let _v8304 =
        async {
            let v8305 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v8306 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v8305 = v8306 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v8309 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v8305 = v8309 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v8312 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v8305 = v8312 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v8315 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v8305 = v8315 
            #endif
#if FABLE_COMPILER_PYTHON
            let v8316 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v8305 = v8316 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v8317 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v8305 = v8317 
            #endif
#else
            let v8318 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v8305 = v8318 
            #endif
            let v8319 : Async<Async<bool>> = _v8305 
            let! v8319 = v8319 
            let v8324 : Async<bool> = v8319 
            let v8325 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v8326 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v8327 : Async<Choice<bool, exn>> = v8326 v8324
            let _v8325 = v8327 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v8328 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v8329 : Async<Choice<bool, exn>> = v8328 v8324
            let _v8325 = v8329 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v8330 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v8331 : Async<Choice<bool, exn>> = v8330 v8324
            let _v8325 = v8331 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v8332 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v8333 : Async<Choice<bool, exn>> = v8332 v8324
            let _v8325 = v8333 
            #endif
#if FABLE_COMPILER_PYTHON
            let v8334 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v8335 : Async<Choice<bool, exn>> = v8334 v8324
            let _v8325 = v8335 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v8336 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v8337 : Async<Choice<bool, exn>> = v8336 v8324
            let _v8325 = v8337 
            #endif
#else
            let v8338 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v8339 : Async<Choice<bool, exn>> = v8338 v8324
            let _v8325 = v8339 
            #endif
            let v8340 : Async<Choice<bool, exn>> = _v8325 
            let v8345 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v8346 : Async<US7> = null |> unbox<Async<US7>>
            let _v8345 = v8346 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v8349 : Async<US7> = null |> unbox<Async<US7>>
            let _v8345 = v8349 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v8352 : Async<US7> = null |> unbox<Async<US7>>
            let _v8345 = v8352 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v8355 : unit = ()
            let _v8355 =
                async {
                    let! v8340 = v8340 
                    let v8356 : Choice<bool, exn> = v8340 
                    let v8357 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v8358 : US7 = null |> unbox<US7>
                    let _v8357 = v8358 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v8361 : US7 = null |> unbox<US7>
                    let _v8357 = v8361 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v8364 : US7 = null |> unbox<US7>
                    let _v8357 = v8364 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v8367 : US7 = null |> unbox<US7>
                    let _v8357 = v8367 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v8370 : US7 = null |> unbox<US7>
                    let _v8357 = v8370 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v8373 : (bool -> US7) = method22()
                    let v8374 : (exn -> US7) = method23()
                    let v8375 : US7 = match v8356 with Choice1Of2 x -> v8373 x | Choice2Of2 x -> v8374 x
                    let _v8357 = v8375 
                    #endif
#else
                    let v8376 : (bool -> US7) = method22()
                    let v8377 : (exn -> US7) = method23()
                    let v8378 : US7 = match v8356 with Choice1Of2 x -> v8376 x | Choice2Of2 x -> v8377 x
                    let _v8357 = v8378 
                    #endif
                    let v8379 : US7 = _v8357 
                    return v8379 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v8384 : Async<US7> = _v8355 
            let _v8345 = v8384 
            #endif
#if FABLE_COMPILER_PYTHON
            let v8385 : unit = ()
            let _v8385 =
                async {
                    let! v8340 = v8340 
                    let v8386 : Choice<bool, exn> = v8340 
                    let v8387 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v8388 : US7 = null |> unbox<US7>
                    let _v8387 = v8388 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v8391 : US7 = null |> unbox<US7>
                    let _v8387 = v8391 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v8394 : US7 = null |> unbox<US7>
                    let _v8387 = v8394 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v8397 : US7 = null |> unbox<US7>
                    let _v8387 = v8397 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v8400 : US7 = null |> unbox<US7>
                    let _v8387 = v8400 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v8403 : (bool -> US7) = method22()
                    let v8404 : (exn -> US7) = method23()
                    let v8405 : US7 = match v8386 with Choice1Of2 x -> v8403 x | Choice2Of2 x -> v8404 x
                    let _v8387 = v8405 
                    #endif
#else
                    let v8406 : (bool -> US7) = method22()
                    let v8407 : (exn -> US7) = method23()
                    let v8408 : US7 = match v8386 with Choice1Of2 x -> v8406 x | Choice2Of2 x -> v8407 x
                    let _v8387 = v8408 
                    #endif
                    let v8409 : US7 = _v8387 
                    return v8409 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v8414 : Async<US7> = _v8385 
            let _v8345 = v8414 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v8415 : unit = ()
            let _v8415 =
                async {
                    let! v8340 = v8340 
                    let v8416 : Choice<bool, exn> = v8340 
                    let v8417 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v8418 : US7 = null |> unbox<US7>
                    let _v8417 = v8418 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v8421 : US7 = null |> unbox<US7>
                    let _v8417 = v8421 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v8424 : US7 = null |> unbox<US7>
                    let _v8417 = v8424 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v8427 : US7 = null |> unbox<US7>
                    let _v8417 = v8427 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v8430 : US7 = null |> unbox<US7>
                    let _v8417 = v8430 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v8433 : (bool -> US7) = method22()
                    let v8434 : (exn -> US7) = method23()
                    let v8435 : US7 = match v8416 with Choice1Of2 x -> v8433 x | Choice2Of2 x -> v8434 x
                    let _v8417 = v8435 
                    #endif
#else
                    let v8436 : (bool -> US7) = method22()
                    let v8437 : (exn -> US7) = method23()
                    let v8438 : US7 = match v8416 with Choice1Of2 x -> v8436 x | Choice2Of2 x -> v8437 x
                    let _v8417 = v8438 
                    #endif
                    let v8439 : US7 = _v8417 
                    return v8439 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v8444 : Async<US7> = _v8415 
            let _v8345 = v8444 
            #endif
#else
            let v8445 : unit = ()
            let _v8445 =
                async {
                    let! v8340 = v8340 
                    let v8446 : Choice<bool, exn> = v8340 
                    let v8447 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v8448 : US7 = null |> unbox<US7>
                    let _v8447 = v8448 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v8451 : US7 = null |> unbox<US7>
                    let _v8447 = v8451 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v8454 : US7 = null |> unbox<US7>
                    let _v8447 = v8454 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v8457 : US7 = null |> unbox<US7>
                    let _v8447 = v8457 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v8460 : US7 = null |> unbox<US7>
                    let _v8447 = v8460 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v8463 : (bool -> US7) = method22()
                    let v8464 : (exn -> US7) = method23()
                    let v8465 : US7 = match v8446 with Choice1Of2 x -> v8463 x | Choice2Of2 x -> v8464 x
                    let _v8447 = v8465 
                    #endif
#else
                    let v8466 : (bool -> US7) = method22()
                    let v8467 : (exn -> US7) = method23()
                    let v8468 : US7 = match v8446 with Choice1Of2 x -> v8466 x | Choice2Of2 x -> v8467 x
                    let _v8447 = v8468 
                    #endif
                    let v8469 : US7 = _v8447 
                    return v8469 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v8474 : Async<US7> = _v8445 
            let _v8345 = v8474 
            #endif
            let v8475 : Async<US7> = _v8345 
            let v8480 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v8481 : Async<US8> = null |> unbox<Async<US8>>
            let _v8480 = v8481 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v8484 : Async<US8> = null |> unbox<Async<US8>>
            let _v8480 = v8484 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v8487 : Async<US8> = null |> unbox<Async<US8>>
            let _v8480 = v8487 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v8490 : unit = ()
            let _v8490 =
                async {
                    let! v8475 = v8475 
                    let v8491 : US7 = v8475 
                    let v8497 : US8 =
                        match v8491 with
                        | US7_0(v8492) -> (* C1of2 *)
                            US8_0(v8492)
                        | US7_1(v8494) -> (* C2of2 *)
                            US8_1(v8494)
                    return v8497 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v8498 : Async<US8> = _v8490 
            let _v8480 = v8498 
            #endif
#if FABLE_COMPILER_PYTHON
            let v8499 : unit = ()
            let _v8499 =
                async {
                    let! v8475 = v8475 
                    let v8500 : US7 = v8475 
                    let v8506 : US8 =
                        match v8500 with
                        | US7_0(v8501) -> (* C1of2 *)
                            US8_0(v8501)
                        | US7_1(v8503) -> (* C2of2 *)
                            US8_1(v8503)
                    return v8506 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v8507 : Async<US8> = _v8499 
            let _v8480 = v8507 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v8508 : unit = ()
            let _v8508 =
                async {
                    let! v8475 = v8475 
                    let v8509 : US7 = v8475 
                    let v8515 : US8 =
                        match v8509 with
                        | US7_0(v8510) -> (* C1of2 *)
                            US8_0(v8510)
                        | US7_1(v8512) -> (* C2of2 *)
                            US8_1(v8512)
                    return v8515 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v8516 : Async<US8> = _v8508 
            let _v8480 = v8516 
            #endif
#else
            let v8517 : unit = ()
            let _v8517 =
                async {
                    let! v8475 = v8475 
                    let v8518 : US7 = v8475 
                    let v8524 : US8 =
                        match v8518 with
                        | US7_0(v8519) -> (* C1of2 *)
                            US8_0(v8519)
                        | US7_1(v8521) -> (* C2of2 *)
                            US8_1(v8521)
                    return v8524 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v8525 : Async<US8> = _v8517 
            let _v8480 = v8525 
            #endif
            let v8526 : Async<US8> = _v8480 
            let v8531 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v8532 : Async<US6> = null |> unbox<Async<US6>>
            let _v8531 = v8532 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v8535 : Async<US6> = null |> unbox<Async<US6>>
            let _v8531 = v8535 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v8538 : Async<US6> = null |> unbox<Async<US6>>
            let _v8531 = v8538 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v8541 : unit = ()
            let _v8541 =
                async {
                    let! v8526 = v8526 
                    let v8542 : US8 = v8526 
                    let v8666 : US6 =
                        match v8542 with
                        | US8_1(v8545) -> (* Error *)
                            let v8546 : string = $"%A{v8545}"
                            let v8549 : string = "System.TimeoutException"
                            let v8550 : bool = v8546.Contains v8549 
                            if v8550 then
                                let v8553 : unit = ()
                                let v8554 : (unit -> unit) = closure16(v0)
                                let v8555 : unit = (fun () -> v8554 (); v8553) ()
                                US6_1
                            else
                                let v8596 : unit = ()
                                let v8597 : (unit -> unit) = closure17(v0, v8545)
                                let v8598 : unit = (fun () -> v8597 (); v8596) ()
                                US6_1
                        | US8_0(v8543) -> (* Ok *)
                            US6_0(v8543)
                    return v8666 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v8667 : Async<US6> = _v8541 
            let _v8531 = v8667 
            #endif
#if FABLE_COMPILER_PYTHON
            let v8668 : unit = ()
            let _v8668 =
                async {
                    let! v8526 = v8526 
                    let v8669 : US8 = v8526 
                    let v8793 : US6 =
                        match v8669 with
                        | US8_1(v8672) -> (* Error *)
                            let v8673 : string = $"%A{v8672}"
                            let v8676 : string = "System.TimeoutException"
                            let v8677 : bool = v8673.Contains v8676 
                            if v8677 then
                                let v8680 : unit = ()
                                let v8681 : (unit -> unit) = closure16(v0)
                                let v8682 : unit = (fun () -> v8681 (); v8680) ()
                                US6_1
                            else
                                let v8723 : unit = ()
                                let v8724 : (unit -> unit) = closure17(v0, v8672)
                                let v8725 : unit = (fun () -> v8724 (); v8723) ()
                                US6_1
                        | US8_0(v8670) -> (* Ok *)
                            US6_0(v8670)
                    return v8793 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v8794 : Async<US6> = _v8668 
            let _v8531 = v8794 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v8795 : unit = ()
            let _v8795 =
                async {
                    let! v8526 = v8526 
                    let v8796 : US8 = v8526 
                    let v8920 : US6 =
                        match v8796 with
                        | US8_1(v8799) -> (* Error *)
                            let v8800 : string = $"%A{v8799}"
                            let v8803 : string = "System.TimeoutException"
                            let v8804 : bool = v8800.Contains v8803 
                            if v8804 then
                                let v8807 : unit = ()
                                let v8808 : (unit -> unit) = closure16(v0)
                                let v8809 : unit = (fun () -> v8808 (); v8807) ()
                                US6_1
                            else
                                let v8850 : unit = ()
                                let v8851 : (unit -> unit) = closure17(v0, v8799)
                                let v8852 : unit = (fun () -> v8851 (); v8850) ()
                                US6_1
                        | US8_0(v8797) -> (* Ok *)
                            US6_0(v8797)
                    return v8920 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v8921 : Async<US6> = _v8795 
            let _v8531 = v8921 
            #endif
#else
            let v8922 : unit = ()
            let _v8922 =
                async {
                    let! v8526 = v8526 
                    let v8923 : US8 = v8526 
                    let v9047 : US6 =
                        match v8923 with
                        | US8_1(v8926) -> (* Error *)
                            let v8927 : string = $"%A{v8926}"
                            let v8930 : string = "System.TimeoutException"
                            let v8931 : bool = v8927.Contains v8930 
                            if v8931 then
                                let v8934 : unit = ()
                                let v8935 : (unit -> unit) = closure16(v0)
                                let v8936 : unit = (fun () -> v8935 (); v8934) ()
                                US6_1
                            else
                                let v8977 : unit = ()
                                let v8978 : (unit -> unit) = closure17(v0, v8926)
                                let v8979 : unit = (fun () -> v8978 (); v8977) ()
                                US6_1
                        | US8_0(v8924) -> (* Ok *)
                            US6_0(v8924)
                    return v9047 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v9048 : Async<US6> = _v8922 
            let _v8531 = v9048 
            #endif
            let v9049 : Async<US6> = _v8531 
            return! v9049 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v9054 : Async<US6> = _v8304 
    let _v6041 = v9054 
    #endif
    let v9055 : Async<US6> = _v6041 
    let _v2 = v9055 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v9060 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v9061 : Async<US6> = null |> unbox<Async<US6>>
    let _v9060 = v9061 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v9064 : Async<US6> = null |> unbox<Async<US6>>
    let _v9060 = v9064 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v9067 : Async<US6> = null |> unbox<Async<US6>>
    let _v9060 = v9067 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v9070 : unit = ()
    let _v9070 =
        async {
            let v9071 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v9072 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v9071 = v9072 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v9075 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v9071 = v9075 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v9078 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v9071 = v9078 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v9081 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v9071 = v9081 
            #endif
#if FABLE_COMPILER_PYTHON
            let v9082 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v9071 = v9082 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v9083 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v9071 = v9083 
            #endif
#else
            let v9084 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v9071 = v9084 
            #endif
            let v9085 : Async<Async<bool>> = _v9071 
            let! v9085 = v9085 
            let v9090 : Async<bool> = v9085 
            let v9091 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v9092 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v9093 : Async<Choice<bool, exn>> = v9092 v9090
            let _v9091 = v9093 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v9094 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v9095 : Async<Choice<bool, exn>> = v9094 v9090
            let _v9091 = v9095 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v9096 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v9097 : Async<Choice<bool, exn>> = v9096 v9090
            let _v9091 = v9097 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v9098 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v9099 : Async<Choice<bool, exn>> = v9098 v9090
            let _v9091 = v9099 
            #endif
#if FABLE_COMPILER_PYTHON
            let v9100 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v9101 : Async<Choice<bool, exn>> = v9100 v9090
            let _v9091 = v9101 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v9102 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v9103 : Async<Choice<bool, exn>> = v9102 v9090
            let _v9091 = v9103 
            #endif
#else
            let v9104 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v9105 : Async<Choice<bool, exn>> = v9104 v9090
            let _v9091 = v9105 
            #endif
            let v9106 : Async<Choice<bool, exn>> = _v9091 
            let v9111 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v9112 : Async<US7> = null |> unbox<Async<US7>>
            let _v9111 = v9112 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v9115 : Async<US7> = null |> unbox<Async<US7>>
            let _v9111 = v9115 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v9118 : Async<US7> = null |> unbox<Async<US7>>
            let _v9111 = v9118 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v9121 : unit = ()
            let _v9121 =
                async {
                    let! v9106 = v9106 
                    let v9122 : Choice<bool, exn> = v9106 
                    let v9123 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v9124 : US7 = null |> unbox<US7>
                    let _v9123 = v9124 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v9127 : US7 = null |> unbox<US7>
                    let _v9123 = v9127 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v9130 : US7 = null |> unbox<US7>
                    let _v9123 = v9130 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v9133 : US7 = null |> unbox<US7>
                    let _v9123 = v9133 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v9136 : US7 = null |> unbox<US7>
                    let _v9123 = v9136 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v9139 : (bool -> US7) = method22()
                    let v9140 : (exn -> US7) = method23()
                    let v9141 : US7 = match v9122 with Choice1Of2 x -> v9139 x | Choice2Of2 x -> v9140 x
                    let _v9123 = v9141 
                    #endif
#else
                    let v9142 : (bool -> US7) = method22()
                    let v9143 : (exn -> US7) = method23()
                    let v9144 : US7 = match v9122 with Choice1Of2 x -> v9142 x | Choice2Of2 x -> v9143 x
                    let _v9123 = v9144 
                    #endif
                    let v9145 : US7 = _v9123 
                    return v9145 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v9150 : Async<US7> = _v9121 
            let _v9111 = v9150 
            #endif
#if FABLE_COMPILER_PYTHON
            let v9151 : unit = ()
            let _v9151 =
                async {
                    let! v9106 = v9106 
                    let v9152 : Choice<bool, exn> = v9106 
                    let v9153 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v9154 : US7 = null |> unbox<US7>
                    let _v9153 = v9154 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v9157 : US7 = null |> unbox<US7>
                    let _v9153 = v9157 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v9160 : US7 = null |> unbox<US7>
                    let _v9153 = v9160 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v9163 : US7 = null |> unbox<US7>
                    let _v9153 = v9163 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v9166 : US7 = null |> unbox<US7>
                    let _v9153 = v9166 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v9169 : (bool -> US7) = method22()
                    let v9170 : (exn -> US7) = method23()
                    let v9171 : US7 = match v9152 with Choice1Of2 x -> v9169 x | Choice2Of2 x -> v9170 x
                    let _v9153 = v9171 
                    #endif
#else
                    let v9172 : (bool -> US7) = method22()
                    let v9173 : (exn -> US7) = method23()
                    let v9174 : US7 = match v9152 with Choice1Of2 x -> v9172 x | Choice2Of2 x -> v9173 x
                    let _v9153 = v9174 
                    #endif
                    let v9175 : US7 = _v9153 
                    return v9175 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v9180 : Async<US7> = _v9151 
            let _v9111 = v9180 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v9181 : unit = ()
            let _v9181 =
                async {
                    let! v9106 = v9106 
                    let v9182 : Choice<bool, exn> = v9106 
                    let v9183 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v9184 : US7 = null |> unbox<US7>
                    let _v9183 = v9184 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v9187 : US7 = null |> unbox<US7>
                    let _v9183 = v9187 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v9190 : US7 = null |> unbox<US7>
                    let _v9183 = v9190 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v9193 : US7 = null |> unbox<US7>
                    let _v9183 = v9193 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v9196 : US7 = null |> unbox<US7>
                    let _v9183 = v9196 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v9199 : (bool -> US7) = method22()
                    let v9200 : (exn -> US7) = method23()
                    let v9201 : US7 = match v9182 with Choice1Of2 x -> v9199 x | Choice2Of2 x -> v9200 x
                    let _v9183 = v9201 
                    #endif
#else
                    let v9202 : (bool -> US7) = method22()
                    let v9203 : (exn -> US7) = method23()
                    let v9204 : US7 = match v9182 with Choice1Of2 x -> v9202 x | Choice2Of2 x -> v9203 x
                    let _v9183 = v9204 
                    #endif
                    let v9205 : US7 = _v9183 
                    return v9205 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v9210 : Async<US7> = _v9181 
            let _v9111 = v9210 
            #endif
#else
            let v9211 : unit = ()
            let _v9211 =
                async {
                    let! v9106 = v9106 
                    let v9212 : Choice<bool, exn> = v9106 
                    let v9213 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v9214 : US7 = null |> unbox<US7>
                    let _v9213 = v9214 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v9217 : US7 = null |> unbox<US7>
                    let _v9213 = v9217 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v9220 : US7 = null |> unbox<US7>
                    let _v9213 = v9220 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v9223 : US7 = null |> unbox<US7>
                    let _v9213 = v9223 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v9226 : US7 = null |> unbox<US7>
                    let _v9213 = v9226 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v9229 : (bool -> US7) = method22()
                    let v9230 : (exn -> US7) = method23()
                    let v9231 : US7 = match v9212 with Choice1Of2 x -> v9229 x | Choice2Of2 x -> v9230 x
                    let _v9213 = v9231 
                    #endif
#else
                    let v9232 : (bool -> US7) = method22()
                    let v9233 : (exn -> US7) = method23()
                    let v9234 : US7 = match v9212 with Choice1Of2 x -> v9232 x | Choice2Of2 x -> v9233 x
                    let _v9213 = v9234 
                    #endif
                    let v9235 : US7 = _v9213 
                    return v9235 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v9240 : Async<US7> = _v9211 
            let _v9111 = v9240 
            #endif
            let v9241 : Async<US7> = _v9111 
            let v9246 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v9247 : Async<US8> = null |> unbox<Async<US8>>
            let _v9246 = v9247 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v9250 : Async<US8> = null |> unbox<Async<US8>>
            let _v9246 = v9250 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v9253 : Async<US8> = null |> unbox<Async<US8>>
            let _v9246 = v9253 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v9256 : unit = ()
            let _v9256 =
                async {
                    let! v9241 = v9241 
                    let v9257 : US7 = v9241 
                    let v9263 : US8 =
                        match v9257 with
                        | US7_0(v9258) -> (* C1of2 *)
                            US8_0(v9258)
                        | US7_1(v9260) -> (* C2of2 *)
                            US8_1(v9260)
                    return v9263 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v9264 : Async<US8> = _v9256 
            let _v9246 = v9264 
            #endif
#if FABLE_COMPILER_PYTHON
            let v9265 : unit = ()
            let _v9265 =
                async {
                    let! v9241 = v9241 
                    let v9266 : US7 = v9241 
                    let v9272 : US8 =
                        match v9266 with
                        | US7_0(v9267) -> (* C1of2 *)
                            US8_0(v9267)
                        | US7_1(v9269) -> (* C2of2 *)
                            US8_1(v9269)
                    return v9272 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v9273 : Async<US8> = _v9265 
            let _v9246 = v9273 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v9274 : unit = ()
            let _v9274 =
                async {
                    let! v9241 = v9241 
                    let v9275 : US7 = v9241 
                    let v9281 : US8 =
                        match v9275 with
                        | US7_0(v9276) -> (* C1of2 *)
                            US8_0(v9276)
                        | US7_1(v9278) -> (* C2of2 *)
                            US8_1(v9278)
                    return v9281 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v9282 : Async<US8> = _v9274 
            let _v9246 = v9282 
            #endif
#else
            let v9283 : unit = ()
            let _v9283 =
                async {
                    let! v9241 = v9241 
                    let v9284 : US7 = v9241 
                    let v9290 : US8 =
                        match v9284 with
                        | US7_0(v9285) -> (* C1of2 *)
                            US8_0(v9285)
                        | US7_1(v9287) -> (* C2of2 *)
                            US8_1(v9287)
                    return v9290 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v9291 : Async<US8> = _v9283 
            let _v9246 = v9291 
            #endif
            let v9292 : Async<US8> = _v9246 
            let v9297 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v9298 : Async<US6> = null |> unbox<Async<US6>>
            let _v9297 = v9298 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v9301 : Async<US6> = null |> unbox<Async<US6>>
            let _v9297 = v9301 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v9304 : Async<US6> = null |> unbox<Async<US6>>
            let _v9297 = v9304 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v9307 : unit = ()
            let _v9307 =
                async {
                    let! v9292 = v9292 
                    let v9308 : US8 = v9292 
                    let v9432 : US6 =
                        match v9308 with
                        | US8_1(v9311) -> (* Error *)
                            let v9312 : string = $"%A{v9311}"
                            let v9315 : string = "System.TimeoutException"
                            let v9316 : bool = v9312.Contains v9315 
                            if v9316 then
                                let v9319 : unit = ()
                                let v9320 : (unit -> unit) = closure16(v0)
                                let v9321 : unit = (fun () -> v9320 (); v9319) ()
                                US6_1
                            else
                                let v9362 : unit = ()
                                let v9363 : (unit -> unit) = closure17(v0, v9311)
                                let v9364 : unit = (fun () -> v9363 (); v9362) ()
                                US6_1
                        | US8_0(v9309) -> (* Ok *)
                            US6_0(v9309)
                    return v9432 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v9433 : Async<US6> = _v9307 
            let _v9297 = v9433 
            #endif
#if FABLE_COMPILER_PYTHON
            let v9434 : unit = ()
            let _v9434 =
                async {
                    let! v9292 = v9292 
                    let v9435 : US8 = v9292 
                    let v9559 : US6 =
                        match v9435 with
                        | US8_1(v9438) -> (* Error *)
                            let v9439 : string = $"%A{v9438}"
                            let v9442 : string = "System.TimeoutException"
                            let v9443 : bool = v9439.Contains v9442 
                            if v9443 then
                                let v9446 : unit = ()
                                let v9447 : (unit -> unit) = closure16(v0)
                                let v9448 : unit = (fun () -> v9447 (); v9446) ()
                                US6_1
                            else
                                let v9489 : unit = ()
                                let v9490 : (unit -> unit) = closure17(v0, v9438)
                                let v9491 : unit = (fun () -> v9490 (); v9489) ()
                                US6_1
                        | US8_0(v9436) -> (* Ok *)
                            US6_0(v9436)
                    return v9559 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v9560 : Async<US6> = _v9434 
            let _v9297 = v9560 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v9561 : unit = ()
            let _v9561 =
                async {
                    let! v9292 = v9292 
                    let v9562 : US8 = v9292 
                    let v9686 : US6 =
                        match v9562 with
                        | US8_1(v9565) -> (* Error *)
                            let v9566 : string = $"%A{v9565}"
                            let v9569 : string = "System.TimeoutException"
                            let v9570 : bool = v9566.Contains v9569 
                            if v9570 then
                                let v9573 : unit = ()
                                let v9574 : (unit -> unit) = closure16(v0)
                                let v9575 : unit = (fun () -> v9574 (); v9573) ()
                                US6_1
                            else
                                let v9616 : unit = ()
                                let v9617 : (unit -> unit) = closure17(v0, v9565)
                                let v9618 : unit = (fun () -> v9617 (); v9616) ()
                                US6_1
                        | US8_0(v9563) -> (* Ok *)
                            US6_0(v9563)
                    return v9686 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v9687 : Async<US6> = _v9561 
            let _v9297 = v9687 
            #endif
#else
            let v9688 : unit = ()
            let _v9688 =
                async {
                    let! v9292 = v9292 
                    let v9689 : US8 = v9292 
                    let v9813 : US6 =
                        match v9689 with
                        | US8_1(v9692) -> (* Error *)
                            let v9693 : string = $"%A{v9692}"
                            let v9696 : string = "System.TimeoutException"
                            let v9697 : bool = v9693.Contains v9696 
                            if v9697 then
                                let v9700 : unit = ()
                                let v9701 : (unit -> unit) = closure16(v0)
                                let v9702 : unit = (fun () -> v9701 (); v9700) ()
                                US6_1
                            else
                                let v9743 : unit = ()
                                let v9744 : (unit -> unit) = closure17(v0, v9692)
                                let v9745 : unit = (fun () -> v9744 (); v9743) ()
                                US6_1
                        | US8_0(v9690) -> (* Ok *)
                            US6_0(v9690)
                    return v9813 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v9814 : Async<US6> = _v9688 
            let _v9297 = v9814 
            #endif
            let v9815 : Async<US6> = _v9297 
            return! v9815 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v9820 : Async<US6> = _v9070 
    let _v9060 = v9820 
    #endif
#if FABLE_COMPILER_PYTHON
    let v9821 : unit = ()
    let _v9821 =
        async {
            let v9822 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v9823 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v9822 = v9823 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v9826 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v9822 = v9826 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v9829 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v9822 = v9829 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v9832 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v9822 = v9832 
            #endif
#if FABLE_COMPILER_PYTHON
            let v9833 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v9822 = v9833 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v9834 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v9822 = v9834 
            #endif
#else
            let v9835 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v9822 = v9835 
            #endif
            let v9836 : Async<Async<bool>> = _v9822 
            let! v9836 = v9836 
            let v9841 : Async<bool> = v9836 
            let v9842 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v9843 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v9844 : Async<Choice<bool, exn>> = v9843 v9841
            let _v9842 = v9844 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v9845 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v9846 : Async<Choice<bool, exn>> = v9845 v9841
            let _v9842 = v9846 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v9847 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v9848 : Async<Choice<bool, exn>> = v9847 v9841
            let _v9842 = v9848 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v9849 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v9850 : Async<Choice<bool, exn>> = v9849 v9841
            let _v9842 = v9850 
            #endif
#if FABLE_COMPILER_PYTHON
            let v9851 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v9852 : Async<Choice<bool, exn>> = v9851 v9841
            let _v9842 = v9852 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v9853 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v9854 : Async<Choice<bool, exn>> = v9853 v9841
            let _v9842 = v9854 
            #endif
#else
            let v9855 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v9856 : Async<Choice<bool, exn>> = v9855 v9841
            let _v9842 = v9856 
            #endif
            let v9857 : Async<Choice<bool, exn>> = _v9842 
            let v9862 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v9863 : Async<US7> = null |> unbox<Async<US7>>
            let _v9862 = v9863 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v9866 : Async<US7> = null |> unbox<Async<US7>>
            let _v9862 = v9866 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v9869 : Async<US7> = null |> unbox<Async<US7>>
            let _v9862 = v9869 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v9872 : unit = ()
            let _v9872 =
                async {
                    let! v9857 = v9857 
                    let v9873 : Choice<bool, exn> = v9857 
                    let v9874 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v9875 : US7 = null |> unbox<US7>
                    let _v9874 = v9875 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v9878 : US7 = null |> unbox<US7>
                    let _v9874 = v9878 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v9881 : US7 = null |> unbox<US7>
                    let _v9874 = v9881 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v9884 : US7 = null |> unbox<US7>
                    let _v9874 = v9884 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v9887 : US7 = null |> unbox<US7>
                    let _v9874 = v9887 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v9890 : (bool -> US7) = method22()
                    let v9891 : (exn -> US7) = method23()
                    let v9892 : US7 = match v9873 with Choice1Of2 x -> v9890 x | Choice2Of2 x -> v9891 x
                    let _v9874 = v9892 
                    #endif
#else
                    let v9893 : (bool -> US7) = method22()
                    let v9894 : (exn -> US7) = method23()
                    let v9895 : US7 = match v9873 with Choice1Of2 x -> v9893 x | Choice2Of2 x -> v9894 x
                    let _v9874 = v9895 
                    #endif
                    let v9896 : US7 = _v9874 
                    return v9896 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v9901 : Async<US7> = _v9872 
            let _v9862 = v9901 
            #endif
#if FABLE_COMPILER_PYTHON
            let v9902 : unit = ()
            let _v9902 =
                async {
                    let! v9857 = v9857 
                    let v9903 : Choice<bool, exn> = v9857 
                    let v9904 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v9905 : US7 = null |> unbox<US7>
                    let _v9904 = v9905 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v9908 : US7 = null |> unbox<US7>
                    let _v9904 = v9908 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v9911 : US7 = null |> unbox<US7>
                    let _v9904 = v9911 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v9914 : US7 = null |> unbox<US7>
                    let _v9904 = v9914 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v9917 : US7 = null |> unbox<US7>
                    let _v9904 = v9917 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v9920 : (bool -> US7) = method22()
                    let v9921 : (exn -> US7) = method23()
                    let v9922 : US7 = match v9903 with Choice1Of2 x -> v9920 x | Choice2Of2 x -> v9921 x
                    let _v9904 = v9922 
                    #endif
#else
                    let v9923 : (bool -> US7) = method22()
                    let v9924 : (exn -> US7) = method23()
                    let v9925 : US7 = match v9903 with Choice1Of2 x -> v9923 x | Choice2Of2 x -> v9924 x
                    let _v9904 = v9925 
                    #endif
                    let v9926 : US7 = _v9904 
                    return v9926 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v9931 : Async<US7> = _v9902 
            let _v9862 = v9931 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v9932 : unit = ()
            let _v9932 =
                async {
                    let! v9857 = v9857 
                    let v9933 : Choice<bool, exn> = v9857 
                    let v9934 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v9935 : US7 = null |> unbox<US7>
                    let _v9934 = v9935 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v9938 : US7 = null |> unbox<US7>
                    let _v9934 = v9938 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v9941 : US7 = null |> unbox<US7>
                    let _v9934 = v9941 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v9944 : US7 = null |> unbox<US7>
                    let _v9934 = v9944 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v9947 : US7 = null |> unbox<US7>
                    let _v9934 = v9947 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v9950 : (bool -> US7) = method22()
                    let v9951 : (exn -> US7) = method23()
                    let v9952 : US7 = match v9933 with Choice1Of2 x -> v9950 x | Choice2Of2 x -> v9951 x
                    let _v9934 = v9952 
                    #endif
#else
                    let v9953 : (bool -> US7) = method22()
                    let v9954 : (exn -> US7) = method23()
                    let v9955 : US7 = match v9933 with Choice1Of2 x -> v9953 x | Choice2Of2 x -> v9954 x
                    let _v9934 = v9955 
                    #endif
                    let v9956 : US7 = _v9934 
                    return v9956 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v9961 : Async<US7> = _v9932 
            let _v9862 = v9961 
            #endif
#else
            let v9962 : unit = ()
            let _v9962 =
                async {
                    let! v9857 = v9857 
                    let v9963 : Choice<bool, exn> = v9857 
                    let v9964 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v9965 : US7 = null |> unbox<US7>
                    let _v9964 = v9965 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v9968 : US7 = null |> unbox<US7>
                    let _v9964 = v9968 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v9971 : US7 = null |> unbox<US7>
                    let _v9964 = v9971 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v9974 : US7 = null |> unbox<US7>
                    let _v9964 = v9974 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v9977 : US7 = null |> unbox<US7>
                    let _v9964 = v9977 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v9980 : (bool -> US7) = method22()
                    let v9981 : (exn -> US7) = method23()
                    let v9982 : US7 = match v9963 with Choice1Of2 x -> v9980 x | Choice2Of2 x -> v9981 x
                    let _v9964 = v9982 
                    #endif
#else
                    let v9983 : (bool -> US7) = method22()
                    let v9984 : (exn -> US7) = method23()
                    let v9985 : US7 = match v9963 with Choice1Of2 x -> v9983 x | Choice2Of2 x -> v9984 x
                    let _v9964 = v9985 
                    #endif
                    let v9986 : US7 = _v9964 
                    return v9986 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v9991 : Async<US7> = _v9962 
            let _v9862 = v9991 
            #endif
            let v9992 : Async<US7> = _v9862 
            let v9997 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v9998 : Async<US8> = null |> unbox<Async<US8>>
            let _v9997 = v9998 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v10001 : Async<US8> = null |> unbox<Async<US8>>
            let _v9997 = v10001 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v10004 : Async<US8> = null |> unbox<Async<US8>>
            let _v9997 = v10004 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v10007 : unit = ()
            let _v10007 =
                async {
                    let! v9992 = v9992 
                    let v10008 : US7 = v9992 
                    let v10014 : US8 =
                        match v10008 with
                        | US7_0(v10009) -> (* C1of2 *)
                            US8_0(v10009)
                        | US7_1(v10011) -> (* C2of2 *)
                            US8_1(v10011)
                    return v10014 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v10015 : Async<US8> = _v10007 
            let _v9997 = v10015 
            #endif
#if FABLE_COMPILER_PYTHON
            let v10016 : unit = ()
            let _v10016 =
                async {
                    let! v9992 = v9992 
                    let v10017 : US7 = v9992 
                    let v10023 : US8 =
                        match v10017 with
                        | US7_0(v10018) -> (* C1of2 *)
                            US8_0(v10018)
                        | US7_1(v10020) -> (* C2of2 *)
                            US8_1(v10020)
                    return v10023 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v10024 : Async<US8> = _v10016 
            let _v9997 = v10024 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v10025 : unit = ()
            let _v10025 =
                async {
                    let! v9992 = v9992 
                    let v10026 : US7 = v9992 
                    let v10032 : US8 =
                        match v10026 with
                        | US7_0(v10027) -> (* C1of2 *)
                            US8_0(v10027)
                        | US7_1(v10029) -> (* C2of2 *)
                            US8_1(v10029)
                    return v10032 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v10033 : Async<US8> = _v10025 
            let _v9997 = v10033 
            #endif
#else
            let v10034 : unit = ()
            let _v10034 =
                async {
                    let! v9992 = v9992 
                    let v10035 : US7 = v9992 
                    let v10041 : US8 =
                        match v10035 with
                        | US7_0(v10036) -> (* C1of2 *)
                            US8_0(v10036)
                        | US7_1(v10038) -> (* C2of2 *)
                            US8_1(v10038)
                    return v10041 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v10042 : Async<US8> = _v10034 
            let _v9997 = v10042 
            #endif
            let v10043 : Async<US8> = _v9997 
            let v10048 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v10049 : Async<US6> = null |> unbox<Async<US6>>
            let _v10048 = v10049 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v10052 : Async<US6> = null |> unbox<Async<US6>>
            let _v10048 = v10052 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v10055 : Async<US6> = null |> unbox<Async<US6>>
            let _v10048 = v10055 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v10058 : unit = ()
            let _v10058 =
                async {
                    let! v10043 = v10043 
                    let v10059 : US8 = v10043 
                    let v10183 : US6 =
                        match v10059 with
                        | US8_1(v10062) -> (* Error *)
                            let v10063 : string = $"%A{v10062}"
                            let v10066 : string = "System.TimeoutException"
                            let v10067 : bool = v10063.Contains v10066 
                            if v10067 then
                                let v10070 : unit = ()
                                let v10071 : (unit -> unit) = closure16(v0)
                                let v10072 : unit = (fun () -> v10071 (); v10070) ()
                                US6_1
                            else
                                let v10113 : unit = ()
                                let v10114 : (unit -> unit) = closure17(v0, v10062)
                                let v10115 : unit = (fun () -> v10114 (); v10113) ()
                                US6_1
                        | US8_0(v10060) -> (* Ok *)
                            US6_0(v10060)
                    return v10183 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v10184 : Async<US6> = _v10058 
            let _v10048 = v10184 
            #endif
#if FABLE_COMPILER_PYTHON
            let v10185 : unit = ()
            let _v10185 =
                async {
                    let! v10043 = v10043 
                    let v10186 : US8 = v10043 
                    let v10310 : US6 =
                        match v10186 with
                        | US8_1(v10189) -> (* Error *)
                            let v10190 : string = $"%A{v10189}"
                            let v10193 : string = "System.TimeoutException"
                            let v10194 : bool = v10190.Contains v10193 
                            if v10194 then
                                let v10197 : unit = ()
                                let v10198 : (unit -> unit) = closure16(v0)
                                let v10199 : unit = (fun () -> v10198 (); v10197) ()
                                US6_1
                            else
                                let v10240 : unit = ()
                                let v10241 : (unit -> unit) = closure17(v0, v10189)
                                let v10242 : unit = (fun () -> v10241 (); v10240) ()
                                US6_1
                        | US8_0(v10187) -> (* Ok *)
                            US6_0(v10187)
                    return v10310 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v10311 : Async<US6> = _v10185 
            let _v10048 = v10311 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v10312 : unit = ()
            let _v10312 =
                async {
                    let! v10043 = v10043 
                    let v10313 : US8 = v10043 
                    let v10437 : US6 =
                        match v10313 with
                        | US8_1(v10316) -> (* Error *)
                            let v10317 : string = $"%A{v10316}"
                            let v10320 : string = "System.TimeoutException"
                            let v10321 : bool = v10317.Contains v10320 
                            if v10321 then
                                let v10324 : unit = ()
                                let v10325 : (unit -> unit) = closure16(v0)
                                let v10326 : unit = (fun () -> v10325 (); v10324) ()
                                US6_1
                            else
                                let v10367 : unit = ()
                                let v10368 : (unit -> unit) = closure17(v0, v10316)
                                let v10369 : unit = (fun () -> v10368 (); v10367) ()
                                US6_1
                        | US8_0(v10314) -> (* Ok *)
                            US6_0(v10314)
                    return v10437 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v10438 : Async<US6> = _v10312 
            let _v10048 = v10438 
            #endif
#else
            let v10439 : unit = ()
            let _v10439 =
                async {
                    let! v10043 = v10043 
                    let v10440 : US8 = v10043 
                    let v10564 : US6 =
                        match v10440 with
                        | US8_1(v10443) -> (* Error *)
                            let v10444 : string = $"%A{v10443}"
                            let v10447 : string = "System.TimeoutException"
                            let v10448 : bool = v10444.Contains v10447 
                            if v10448 then
                                let v10451 : unit = ()
                                let v10452 : (unit -> unit) = closure16(v0)
                                let v10453 : unit = (fun () -> v10452 (); v10451) ()
                                US6_1
                            else
                                let v10494 : unit = ()
                                let v10495 : (unit -> unit) = closure17(v0, v10443)
                                let v10496 : unit = (fun () -> v10495 (); v10494) ()
                                US6_1
                        | US8_0(v10441) -> (* Ok *)
                            US6_0(v10441)
                    return v10564 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v10565 : Async<US6> = _v10439 
            let _v10048 = v10565 
            #endif
            let v10566 : Async<US6> = _v10048 
            return! v10566 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v10571 : Async<US6> = _v9821 
    let _v9060 = v10571 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v10572 : unit = ()
    let _v10572 =
        async {
            let v10573 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v10574 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v10573 = v10574 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v10577 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v10573 = v10577 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v10580 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v10573 = v10580 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v10583 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v10573 = v10583 
            #endif
#if FABLE_COMPILER_PYTHON
            let v10584 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v10573 = v10584 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v10585 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v10573 = v10585 
            #endif
#else
            let v10586 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v10573 = v10586 
            #endif
            let v10587 : Async<Async<bool>> = _v10573 
            let! v10587 = v10587 
            let v10592 : Async<bool> = v10587 
            let v10593 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v10594 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v10595 : Async<Choice<bool, exn>> = v10594 v10592
            let _v10593 = v10595 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v10596 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v10597 : Async<Choice<bool, exn>> = v10596 v10592
            let _v10593 = v10597 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v10598 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v10599 : Async<Choice<bool, exn>> = v10598 v10592
            let _v10593 = v10599 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v10600 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v10601 : Async<Choice<bool, exn>> = v10600 v10592
            let _v10593 = v10601 
            #endif
#if FABLE_COMPILER_PYTHON
            let v10602 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v10603 : Async<Choice<bool, exn>> = v10602 v10592
            let _v10593 = v10603 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v10604 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v10605 : Async<Choice<bool, exn>> = v10604 v10592
            let _v10593 = v10605 
            #endif
#else
            let v10606 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v10607 : Async<Choice<bool, exn>> = v10606 v10592
            let _v10593 = v10607 
            #endif
            let v10608 : Async<Choice<bool, exn>> = _v10593 
            let v10613 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v10614 : Async<US7> = null |> unbox<Async<US7>>
            let _v10613 = v10614 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v10617 : Async<US7> = null |> unbox<Async<US7>>
            let _v10613 = v10617 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v10620 : Async<US7> = null |> unbox<Async<US7>>
            let _v10613 = v10620 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v10623 : unit = ()
            let _v10623 =
                async {
                    let! v10608 = v10608 
                    let v10624 : Choice<bool, exn> = v10608 
                    let v10625 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v10626 : US7 = null |> unbox<US7>
                    let _v10625 = v10626 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v10629 : US7 = null |> unbox<US7>
                    let _v10625 = v10629 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v10632 : US7 = null |> unbox<US7>
                    let _v10625 = v10632 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v10635 : US7 = null |> unbox<US7>
                    let _v10625 = v10635 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v10638 : US7 = null |> unbox<US7>
                    let _v10625 = v10638 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v10641 : (bool -> US7) = method22()
                    let v10642 : (exn -> US7) = method23()
                    let v10643 : US7 = match v10624 with Choice1Of2 x -> v10641 x | Choice2Of2 x -> v10642 x
                    let _v10625 = v10643 
                    #endif
#else
                    let v10644 : (bool -> US7) = method22()
                    let v10645 : (exn -> US7) = method23()
                    let v10646 : US7 = match v10624 with Choice1Of2 x -> v10644 x | Choice2Of2 x -> v10645 x
                    let _v10625 = v10646 
                    #endif
                    let v10647 : US7 = _v10625 
                    return v10647 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v10652 : Async<US7> = _v10623 
            let _v10613 = v10652 
            #endif
#if FABLE_COMPILER_PYTHON
            let v10653 : unit = ()
            let _v10653 =
                async {
                    let! v10608 = v10608 
                    let v10654 : Choice<bool, exn> = v10608 
                    let v10655 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v10656 : US7 = null |> unbox<US7>
                    let _v10655 = v10656 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v10659 : US7 = null |> unbox<US7>
                    let _v10655 = v10659 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v10662 : US7 = null |> unbox<US7>
                    let _v10655 = v10662 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v10665 : US7 = null |> unbox<US7>
                    let _v10655 = v10665 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v10668 : US7 = null |> unbox<US7>
                    let _v10655 = v10668 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v10671 : (bool -> US7) = method22()
                    let v10672 : (exn -> US7) = method23()
                    let v10673 : US7 = match v10654 with Choice1Of2 x -> v10671 x | Choice2Of2 x -> v10672 x
                    let _v10655 = v10673 
                    #endif
#else
                    let v10674 : (bool -> US7) = method22()
                    let v10675 : (exn -> US7) = method23()
                    let v10676 : US7 = match v10654 with Choice1Of2 x -> v10674 x | Choice2Of2 x -> v10675 x
                    let _v10655 = v10676 
                    #endif
                    let v10677 : US7 = _v10655 
                    return v10677 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v10682 : Async<US7> = _v10653 
            let _v10613 = v10682 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v10683 : unit = ()
            let _v10683 =
                async {
                    let! v10608 = v10608 
                    let v10684 : Choice<bool, exn> = v10608 
                    let v10685 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v10686 : US7 = null |> unbox<US7>
                    let _v10685 = v10686 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v10689 : US7 = null |> unbox<US7>
                    let _v10685 = v10689 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v10692 : US7 = null |> unbox<US7>
                    let _v10685 = v10692 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v10695 : US7 = null |> unbox<US7>
                    let _v10685 = v10695 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v10698 : US7 = null |> unbox<US7>
                    let _v10685 = v10698 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v10701 : (bool -> US7) = method22()
                    let v10702 : (exn -> US7) = method23()
                    let v10703 : US7 = match v10684 with Choice1Of2 x -> v10701 x | Choice2Of2 x -> v10702 x
                    let _v10685 = v10703 
                    #endif
#else
                    let v10704 : (bool -> US7) = method22()
                    let v10705 : (exn -> US7) = method23()
                    let v10706 : US7 = match v10684 with Choice1Of2 x -> v10704 x | Choice2Of2 x -> v10705 x
                    let _v10685 = v10706 
                    #endif
                    let v10707 : US7 = _v10685 
                    return v10707 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v10712 : Async<US7> = _v10683 
            let _v10613 = v10712 
            #endif
#else
            let v10713 : unit = ()
            let _v10713 =
                async {
                    let! v10608 = v10608 
                    let v10714 : Choice<bool, exn> = v10608 
                    let v10715 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v10716 : US7 = null |> unbox<US7>
                    let _v10715 = v10716 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v10719 : US7 = null |> unbox<US7>
                    let _v10715 = v10719 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v10722 : US7 = null |> unbox<US7>
                    let _v10715 = v10722 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v10725 : US7 = null |> unbox<US7>
                    let _v10715 = v10725 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v10728 : US7 = null |> unbox<US7>
                    let _v10715 = v10728 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v10731 : (bool -> US7) = method22()
                    let v10732 : (exn -> US7) = method23()
                    let v10733 : US7 = match v10714 with Choice1Of2 x -> v10731 x | Choice2Of2 x -> v10732 x
                    let _v10715 = v10733 
                    #endif
#else
                    let v10734 : (bool -> US7) = method22()
                    let v10735 : (exn -> US7) = method23()
                    let v10736 : US7 = match v10714 with Choice1Of2 x -> v10734 x | Choice2Of2 x -> v10735 x
                    let _v10715 = v10736 
                    #endif
                    let v10737 : US7 = _v10715 
                    return v10737 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v10742 : Async<US7> = _v10713 
            let _v10613 = v10742 
            #endif
            let v10743 : Async<US7> = _v10613 
            let v10748 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v10749 : Async<US8> = null |> unbox<Async<US8>>
            let _v10748 = v10749 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v10752 : Async<US8> = null |> unbox<Async<US8>>
            let _v10748 = v10752 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v10755 : Async<US8> = null |> unbox<Async<US8>>
            let _v10748 = v10755 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v10758 : unit = ()
            let _v10758 =
                async {
                    let! v10743 = v10743 
                    let v10759 : US7 = v10743 
                    let v10765 : US8 =
                        match v10759 with
                        | US7_0(v10760) -> (* C1of2 *)
                            US8_0(v10760)
                        | US7_1(v10762) -> (* C2of2 *)
                            US8_1(v10762)
                    return v10765 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v10766 : Async<US8> = _v10758 
            let _v10748 = v10766 
            #endif
#if FABLE_COMPILER_PYTHON
            let v10767 : unit = ()
            let _v10767 =
                async {
                    let! v10743 = v10743 
                    let v10768 : US7 = v10743 
                    let v10774 : US8 =
                        match v10768 with
                        | US7_0(v10769) -> (* C1of2 *)
                            US8_0(v10769)
                        | US7_1(v10771) -> (* C2of2 *)
                            US8_1(v10771)
                    return v10774 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v10775 : Async<US8> = _v10767 
            let _v10748 = v10775 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v10776 : unit = ()
            let _v10776 =
                async {
                    let! v10743 = v10743 
                    let v10777 : US7 = v10743 
                    let v10783 : US8 =
                        match v10777 with
                        | US7_0(v10778) -> (* C1of2 *)
                            US8_0(v10778)
                        | US7_1(v10780) -> (* C2of2 *)
                            US8_1(v10780)
                    return v10783 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v10784 : Async<US8> = _v10776 
            let _v10748 = v10784 
            #endif
#else
            let v10785 : unit = ()
            let _v10785 =
                async {
                    let! v10743 = v10743 
                    let v10786 : US7 = v10743 
                    let v10792 : US8 =
                        match v10786 with
                        | US7_0(v10787) -> (* C1of2 *)
                            US8_0(v10787)
                        | US7_1(v10789) -> (* C2of2 *)
                            US8_1(v10789)
                    return v10792 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v10793 : Async<US8> = _v10785 
            let _v10748 = v10793 
            #endif
            let v10794 : Async<US8> = _v10748 
            let v10799 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v10800 : Async<US6> = null |> unbox<Async<US6>>
            let _v10799 = v10800 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v10803 : Async<US6> = null |> unbox<Async<US6>>
            let _v10799 = v10803 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v10806 : Async<US6> = null |> unbox<Async<US6>>
            let _v10799 = v10806 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v10809 : unit = ()
            let _v10809 =
                async {
                    let! v10794 = v10794 
                    let v10810 : US8 = v10794 
                    let v10934 : US6 =
                        match v10810 with
                        | US8_1(v10813) -> (* Error *)
                            let v10814 : string = $"%A{v10813}"
                            let v10817 : string = "System.TimeoutException"
                            let v10818 : bool = v10814.Contains v10817 
                            if v10818 then
                                let v10821 : unit = ()
                                let v10822 : (unit -> unit) = closure16(v0)
                                let v10823 : unit = (fun () -> v10822 (); v10821) ()
                                US6_1
                            else
                                let v10864 : unit = ()
                                let v10865 : (unit -> unit) = closure17(v0, v10813)
                                let v10866 : unit = (fun () -> v10865 (); v10864) ()
                                US6_1
                        | US8_0(v10811) -> (* Ok *)
                            US6_0(v10811)
                    return v10934 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v10935 : Async<US6> = _v10809 
            let _v10799 = v10935 
            #endif
#if FABLE_COMPILER_PYTHON
            let v10936 : unit = ()
            let _v10936 =
                async {
                    let! v10794 = v10794 
                    let v10937 : US8 = v10794 
                    let v11061 : US6 =
                        match v10937 with
                        | US8_1(v10940) -> (* Error *)
                            let v10941 : string = $"%A{v10940}"
                            let v10944 : string = "System.TimeoutException"
                            let v10945 : bool = v10941.Contains v10944 
                            if v10945 then
                                let v10948 : unit = ()
                                let v10949 : (unit -> unit) = closure16(v0)
                                let v10950 : unit = (fun () -> v10949 (); v10948) ()
                                US6_1
                            else
                                let v10991 : unit = ()
                                let v10992 : (unit -> unit) = closure17(v0, v10940)
                                let v10993 : unit = (fun () -> v10992 (); v10991) ()
                                US6_1
                        | US8_0(v10938) -> (* Ok *)
                            US6_0(v10938)
                    return v11061 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v11062 : Async<US6> = _v10936 
            let _v10799 = v11062 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v11063 : unit = ()
            let _v11063 =
                async {
                    let! v10794 = v10794 
                    let v11064 : US8 = v10794 
                    let v11188 : US6 =
                        match v11064 with
                        | US8_1(v11067) -> (* Error *)
                            let v11068 : string = $"%A{v11067}"
                            let v11071 : string = "System.TimeoutException"
                            let v11072 : bool = v11068.Contains v11071 
                            if v11072 then
                                let v11075 : unit = ()
                                let v11076 : (unit -> unit) = closure16(v0)
                                let v11077 : unit = (fun () -> v11076 (); v11075) ()
                                US6_1
                            else
                                let v11118 : unit = ()
                                let v11119 : (unit -> unit) = closure17(v0, v11067)
                                let v11120 : unit = (fun () -> v11119 (); v11118) ()
                                US6_1
                        | US8_0(v11065) -> (* Ok *)
                            US6_0(v11065)
                    return v11188 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v11189 : Async<US6> = _v11063 
            let _v10799 = v11189 
            #endif
#else
            let v11190 : unit = ()
            let _v11190 =
                async {
                    let! v10794 = v10794 
                    let v11191 : US8 = v10794 
                    let v11315 : US6 =
                        match v11191 with
                        | US8_1(v11194) -> (* Error *)
                            let v11195 : string = $"%A{v11194}"
                            let v11198 : string = "System.TimeoutException"
                            let v11199 : bool = v11195.Contains v11198 
                            if v11199 then
                                let v11202 : unit = ()
                                let v11203 : (unit -> unit) = closure16(v0)
                                let v11204 : unit = (fun () -> v11203 (); v11202) ()
                                US6_1
                            else
                                let v11245 : unit = ()
                                let v11246 : (unit -> unit) = closure17(v0, v11194)
                                let v11247 : unit = (fun () -> v11246 (); v11245) ()
                                US6_1
                        | US8_0(v11192) -> (* Ok *)
                            US6_0(v11192)
                    return v11315 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v11316 : Async<US6> = _v11190 
            let _v10799 = v11316 
            #endif
            let v11317 : Async<US6> = _v10799 
            return! v11317 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v11322 : Async<US6> = _v10572 
    let _v9060 = v11322 
    #endif
#else
    let v11323 : unit = ()
    let _v11323 =
        async {
            let v11324 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v11325 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v11324 = v11325 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v11328 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v11324 = v11328 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v11331 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v11324 = v11331 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v11334 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v11324 = v11334 
            #endif
#if FABLE_COMPILER_PYTHON
            let v11335 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v11324 = v11335 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v11336 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v11324 = v11336 
            #endif
#else
            let v11337 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v11324 = v11337 
            #endif
            let v11338 : Async<Async<bool>> = _v11324 
            let! v11338 = v11338 
            let v11343 : Async<bool> = v11338 
            let v11344 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v11345 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v11346 : Async<Choice<bool, exn>> = v11345 v11343
            let _v11344 = v11346 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v11347 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v11348 : Async<Choice<bool, exn>> = v11347 v11343
            let _v11344 = v11348 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v11349 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v11350 : Async<Choice<bool, exn>> = v11349 v11343
            let _v11344 = v11350 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v11351 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v11352 : Async<Choice<bool, exn>> = v11351 v11343
            let _v11344 = v11352 
            #endif
#if FABLE_COMPILER_PYTHON
            let v11353 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v11354 : Async<Choice<bool, exn>> = v11353 v11343
            let _v11344 = v11354 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v11355 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v11356 : Async<Choice<bool, exn>> = v11355 v11343
            let _v11344 = v11356 
            #endif
#else
            let v11357 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v11358 : Async<Choice<bool, exn>> = v11357 v11343
            let _v11344 = v11358 
            #endif
            let v11359 : Async<Choice<bool, exn>> = _v11344 
            let v11364 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v11365 : Async<US7> = null |> unbox<Async<US7>>
            let _v11364 = v11365 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v11368 : Async<US7> = null |> unbox<Async<US7>>
            let _v11364 = v11368 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v11371 : Async<US7> = null |> unbox<Async<US7>>
            let _v11364 = v11371 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v11374 : unit = ()
            let _v11374 =
                async {
                    let! v11359 = v11359 
                    let v11375 : Choice<bool, exn> = v11359 
                    let v11376 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v11377 : US7 = null |> unbox<US7>
                    let _v11376 = v11377 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v11380 : US7 = null |> unbox<US7>
                    let _v11376 = v11380 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v11383 : US7 = null |> unbox<US7>
                    let _v11376 = v11383 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v11386 : US7 = null |> unbox<US7>
                    let _v11376 = v11386 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v11389 : US7 = null |> unbox<US7>
                    let _v11376 = v11389 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v11392 : (bool -> US7) = method22()
                    let v11393 : (exn -> US7) = method23()
                    let v11394 : US7 = match v11375 with Choice1Of2 x -> v11392 x | Choice2Of2 x -> v11393 x
                    let _v11376 = v11394 
                    #endif
#else
                    let v11395 : (bool -> US7) = method22()
                    let v11396 : (exn -> US7) = method23()
                    let v11397 : US7 = match v11375 with Choice1Of2 x -> v11395 x | Choice2Of2 x -> v11396 x
                    let _v11376 = v11397 
                    #endif
                    let v11398 : US7 = _v11376 
                    return v11398 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v11403 : Async<US7> = _v11374 
            let _v11364 = v11403 
            #endif
#if FABLE_COMPILER_PYTHON
            let v11404 : unit = ()
            let _v11404 =
                async {
                    let! v11359 = v11359 
                    let v11405 : Choice<bool, exn> = v11359 
                    let v11406 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v11407 : US7 = null |> unbox<US7>
                    let _v11406 = v11407 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v11410 : US7 = null |> unbox<US7>
                    let _v11406 = v11410 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v11413 : US7 = null |> unbox<US7>
                    let _v11406 = v11413 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v11416 : US7 = null |> unbox<US7>
                    let _v11406 = v11416 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v11419 : US7 = null |> unbox<US7>
                    let _v11406 = v11419 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v11422 : (bool -> US7) = method22()
                    let v11423 : (exn -> US7) = method23()
                    let v11424 : US7 = match v11405 with Choice1Of2 x -> v11422 x | Choice2Of2 x -> v11423 x
                    let _v11406 = v11424 
                    #endif
#else
                    let v11425 : (bool -> US7) = method22()
                    let v11426 : (exn -> US7) = method23()
                    let v11427 : US7 = match v11405 with Choice1Of2 x -> v11425 x | Choice2Of2 x -> v11426 x
                    let _v11406 = v11427 
                    #endif
                    let v11428 : US7 = _v11406 
                    return v11428 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v11433 : Async<US7> = _v11404 
            let _v11364 = v11433 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v11434 : unit = ()
            let _v11434 =
                async {
                    let! v11359 = v11359 
                    let v11435 : Choice<bool, exn> = v11359 
                    let v11436 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v11437 : US7 = null |> unbox<US7>
                    let _v11436 = v11437 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v11440 : US7 = null |> unbox<US7>
                    let _v11436 = v11440 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v11443 : US7 = null |> unbox<US7>
                    let _v11436 = v11443 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v11446 : US7 = null |> unbox<US7>
                    let _v11436 = v11446 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v11449 : US7 = null |> unbox<US7>
                    let _v11436 = v11449 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v11452 : (bool -> US7) = method22()
                    let v11453 : (exn -> US7) = method23()
                    let v11454 : US7 = match v11435 with Choice1Of2 x -> v11452 x | Choice2Of2 x -> v11453 x
                    let _v11436 = v11454 
                    #endif
#else
                    let v11455 : (bool -> US7) = method22()
                    let v11456 : (exn -> US7) = method23()
                    let v11457 : US7 = match v11435 with Choice1Of2 x -> v11455 x | Choice2Of2 x -> v11456 x
                    let _v11436 = v11457 
                    #endif
                    let v11458 : US7 = _v11436 
                    return v11458 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v11463 : Async<US7> = _v11434 
            let _v11364 = v11463 
            #endif
#else
            let v11464 : unit = ()
            let _v11464 =
                async {
                    let! v11359 = v11359 
                    let v11465 : Choice<bool, exn> = v11359 
                    let v11466 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v11467 : US7 = null |> unbox<US7>
                    let _v11466 = v11467 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v11470 : US7 = null |> unbox<US7>
                    let _v11466 = v11470 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v11473 : US7 = null |> unbox<US7>
                    let _v11466 = v11473 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v11476 : US7 = null |> unbox<US7>
                    let _v11466 = v11476 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v11479 : US7 = null |> unbox<US7>
                    let _v11466 = v11479 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v11482 : (bool -> US7) = method22()
                    let v11483 : (exn -> US7) = method23()
                    let v11484 : US7 = match v11465 with Choice1Of2 x -> v11482 x | Choice2Of2 x -> v11483 x
                    let _v11466 = v11484 
                    #endif
#else
                    let v11485 : (bool -> US7) = method22()
                    let v11486 : (exn -> US7) = method23()
                    let v11487 : US7 = match v11465 with Choice1Of2 x -> v11485 x | Choice2Of2 x -> v11486 x
                    let _v11466 = v11487 
                    #endif
                    let v11488 : US7 = _v11466 
                    return v11488 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v11493 : Async<US7> = _v11464 
            let _v11364 = v11493 
            #endif
            let v11494 : Async<US7> = _v11364 
            let v11499 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v11500 : Async<US8> = null |> unbox<Async<US8>>
            let _v11499 = v11500 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v11503 : Async<US8> = null |> unbox<Async<US8>>
            let _v11499 = v11503 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v11506 : Async<US8> = null |> unbox<Async<US8>>
            let _v11499 = v11506 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v11509 : unit = ()
            let _v11509 =
                async {
                    let! v11494 = v11494 
                    let v11510 : US7 = v11494 
                    let v11516 : US8 =
                        match v11510 with
                        | US7_0(v11511) -> (* C1of2 *)
                            US8_0(v11511)
                        | US7_1(v11513) -> (* C2of2 *)
                            US8_1(v11513)
                    return v11516 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v11517 : Async<US8> = _v11509 
            let _v11499 = v11517 
            #endif
#if FABLE_COMPILER_PYTHON
            let v11518 : unit = ()
            let _v11518 =
                async {
                    let! v11494 = v11494 
                    let v11519 : US7 = v11494 
                    let v11525 : US8 =
                        match v11519 with
                        | US7_0(v11520) -> (* C1of2 *)
                            US8_0(v11520)
                        | US7_1(v11522) -> (* C2of2 *)
                            US8_1(v11522)
                    return v11525 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v11526 : Async<US8> = _v11518 
            let _v11499 = v11526 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v11527 : unit = ()
            let _v11527 =
                async {
                    let! v11494 = v11494 
                    let v11528 : US7 = v11494 
                    let v11534 : US8 =
                        match v11528 with
                        | US7_0(v11529) -> (* C1of2 *)
                            US8_0(v11529)
                        | US7_1(v11531) -> (* C2of2 *)
                            US8_1(v11531)
                    return v11534 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v11535 : Async<US8> = _v11527 
            let _v11499 = v11535 
            #endif
#else
            let v11536 : unit = ()
            let _v11536 =
                async {
                    let! v11494 = v11494 
                    let v11537 : US7 = v11494 
                    let v11543 : US8 =
                        match v11537 with
                        | US7_0(v11538) -> (* C1of2 *)
                            US8_0(v11538)
                        | US7_1(v11540) -> (* C2of2 *)
                            US8_1(v11540)
                    return v11543 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v11544 : Async<US8> = _v11536 
            let _v11499 = v11544 
            #endif
            let v11545 : Async<US8> = _v11499 
            let v11550 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v11551 : Async<US6> = null |> unbox<Async<US6>>
            let _v11550 = v11551 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v11554 : Async<US6> = null |> unbox<Async<US6>>
            let _v11550 = v11554 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v11557 : Async<US6> = null |> unbox<Async<US6>>
            let _v11550 = v11557 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v11560 : unit = ()
            let _v11560 =
                async {
                    let! v11545 = v11545 
                    let v11561 : US8 = v11545 
                    let v11685 : US6 =
                        match v11561 with
                        | US8_1(v11564) -> (* Error *)
                            let v11565 : string = $"%A{v11564}"
                            let v11568 : string = "System.TimeoutException"
                            let v11569 : bool = v11565.Contains v11568 
                            if v11569 then
                                let v11572 : unit = ()
                                let v11573 : (unit -> unit) = closure16(v0)
                                let v11574 : unit = (fun () -> v11573 (); v11572) ()
                                US6_1
                            else
                                let v11615 : unit = ()
                                let v11616 : (unit -> unit) = closure17(v0, v11564)
                                let v11617 : unit = (fun () -> v11616 (); v11615) ()
                                US6_1
                        | US8_0(v11562) -> (* Ok *)
                            US6_0(v11562)
                    return v11685 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v11686 : Async<US6> = _v11560 
            let _v11550 = v11686 
            #endif
#if FABLE_COMPILER_PYTHON
            let v11687 : unit = ()
            let _v11687 =
                async {
                    let! v11545 = v11545 
                    let v11688 : US8 = v11545 
                    let v11812 : US6 =
                        match v11688 with
                        | US8_1(v11691) -> (* Error *)
                            let v11692 : string = $"%A{v11691}"
                            let v11695 : string = "System.TimeoutException"
                            let v11696 : bool = v11692.Contains v11695 
                            if v11696 then
                                let v11699 : unit = ()
                                let v11700 : (unit -> unit) = closure16(v0)
                                let v11701 : unit = (fun () -> v11700 (); v11699) ()
                                US6_1
                            else
                                let v11742 : unit = ()
                                let v11743 : (unit -> unit) = closure17(v0, v11691)
                                let v11744 : unit = (fun () -> v11743 (); v11742) ()
                                US6_1
                        | US8_0(v11689) -> (* Ok *)
                            US6_0(v11689)
                    return v11812 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v11813 : Async<US6> = _v11687 
            let _v11550 = v11813 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v11814 : unit = ()
            let _v11814 =
                async {
                    let! v11545 = v11545 
                    let v11815 : US8 = v11545 
                    let v11939 : US6 =
                        match v11815 with
                        | US8_1(v11818) -> (* Error *)
                            let v11819 : string = $"%A{v11818}"
                            let v11822 : string = "System.TimeoutException"
                            let v11823 : bool = v11819.Contains v11822 
                            if v11823 then
                                let v11826 : unit = ()
                                let v11827 : (unit -> unit) = closure16(v0)
                                let v11828 : unit = (fun () -> v11827 (); v11826) ()
                                US6_1
                            else
                                let v11869 : unit = ()
                                let v11870 : (unit -> unit) = closure17(v0, v11818)
                                let v11871 : unit = (fun () -> v11870 (); v11869) ()
                                US6_1
                        | US8_0(v11816) -> (* Ok *)
                            US6_0(v11816)
                    return v11939 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v11940 : Async<US6> = _v11814 
            let _v11550 = v11940 
            #endif
#else
            let v11941 : unit = ()
            let _v11941 =
                async {
                    let! v11545 = v11545 
                    let v11942 : US8 = v11545 
                    let v12066 : US6 =
                        match v11942 with
                        | US8_1(v11945) -> (* Error *)
                            let v11946 : string = $"%A{v11945}"
                            let v11949 : string = "System.TimeoutException"
                            let v11950 : bool = v11946.Contains v11949 
                            if v11950 then
                                let v11953 : unit = ()
                                let v11954 : (unit -> unit) = closure16(v0)
                                let v11955 : unit = (fun () -> v11954 (); v11953) ()
                                US6_1
                            else
                                let v11996 : unit = ()
                                let v11997 : (unit -> unit) = closure17(v0, v11945)
                                let v11998 : unit = (fun () -> v11997 (); v11996) ()
                                US6_1
                        | US8_0(v11943) -> (* Ok *)
                            US6_0(v11943)
                    return v12066 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v12067 : Async<US6> = _v11941 
            let _v11550 = v12067 
            #endif
            let v12068 : Async<US6> = _v11550 
            return! v12068 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v12073 : Async<US6> = _v11323 
    let _v9060 = v12073 
    #endif
    let v12074 : Async<US6> = _v9060 
    let _v2 = v12074 
    #endif
#if FABLE_COMPILER_PYTHON
    let v12079 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v12080 : Async<US6> = null |> unbox<Async<US6>>
    let _v12079 = v12080 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v12083 : Async<US6> = null |> unbox<Async<US6>>
    let _v12079 = v12083 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v12086 : Async<US6> = null |> unbox<Async<US6>>
    let _v12079 = v12086 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v12089 : unit = ()
    let _v12089 =
        async {
            let v12090 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v12091 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v12090 = v12091 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v12094 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v12090 = v12094 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v12097 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v12090 = v12097 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v12100 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v12090 = v12100 
            #endif
#if FABLE_COMPILER_PYTHON
            let v12101 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v12090 = v12101 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v12102 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v12090 = v12102 
            #endif
#else
            let v12103 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v12090 = v12103 
            #endif
            let v12104 : Async<Async<bool>> = _v12090 
            let! v12104 = v12104 
            let v12109 : Async<bool> = v12104 
            let v12110 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v12111 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v12112 : Async<Choice<bool, exn>> = v12111 v12109
            let _v12110 = v12112 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v12113 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v12114 : Async<Choice<bool, exn>> = v12113 v12109
            let _v12110 = v12114 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v12115 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v12116 : Async<Choice<bool, exn>> = v12115 v12109
            let _v12110 = v12116 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v12117 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v12118 : Async<Choice<bool, exn>> = v12117 v12109
            let _v12110 = v12118 
            #endif
#if FABLE_COMPILER_PYTHON
            let v12119 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v12120 : Async<Choice<bool, exn>> = v12119 v12109
            let _v12110 = v12120 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v12121 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v12122 : Async<Choice<bool, exn>> = v12121 v12109
            let _v12110 = v12122 
            #endif
#else
            let v12123 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v12124 : Async<Choice<bool, exn>> = v12123 v12109
            let _v12110 = v12124 
            #endif
            let v12125 : Async<Choice<bool, exn>> = _v12110 
            let v12130 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v12131 : Async<US7> = null |> unbox<Async<US7>>
            let _v12130 = v12131 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v12134 : Async<US7> = null |> unbox<Async<US7>>
            let _v12130 = v12134 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v12137 : Async<US7> = null |> unbox<Async<US7>>
            let _v12130 = v12137 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v12140 : unit = ()
            let _v12140 =
                async {
                    let! v12125 = v12125 
                    let v12141 : Choice<bool, exn> = v12125 
                    let v12142 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v12143 : US7 = null |> unbox<US7>
                    let _v12142 = v12143 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v12146 : US7 = null |> unbox<US7>
                    let _v12142 = v12146 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v12149 : US7 = null |> unbox<US7>
                    let _v12142 = v12149 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v12152 : US7 = null |> unbox<US7>
                    let _v12142 = v12152 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v12155 : US7 = null |> unbox<US7>
                    let _v12142 = v12155 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v12158 : (bool -> US7) = method22()
                    let v12159 : (exn -> US7) = method23()
                    let v12160 : US7 = match v12141 with Choice1Of2 x -> v12158 x | Choice2Of2 x -> v12159 x
                    let _v12142 = v12160 
                    #endif
#else
                    let v12161 : (bool -> US7) = method22()
                    let v12162 : (exn -> US7) = method23()
                    let v12163 : US7 = match v12141 with Choice1Of2 x -> v12161 x | Choice2Of2 x -> v12162 x
                    let _v12142 = v12163 
                    #endif
                    let v12164 : US7 = _v12142 
                    return v12164 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v12169 : Async<US7> = _v12140 
            let _v12130 = v12169 
            #endif
#if FABLE_COMPILER_PYTHON
            let v12170 : unit = ()
            let _v12170 =
                async {
                    let! v12125 = v12125 
                    let v12171 : Choice<bool, exn> = v12125 
                    let v12172 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v12173 : US7 = null |> unbox<US7>
                    let _v12172 = v12173 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v12176 : US7 = null |> unbox<US7>
                    let _v12172 = v12176 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v12179 : US7 = null |> unbox<US7>
                    let _v12172 = v12179 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v12182 : US7 = null |> unbox<US7>
                    let _v12172 = v12182 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v12185 : US7 = null |> unbox<US7>
                    let _v12172 = v12185 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v12188 : (bool -> US7) = method22()
                    let v12189 : (exn -> US7) = method23()
                    let v12190 : US7 = match v12171 with Choice1Of2 x -> v12188 x | Choice2Of2 x -> v12189 x
                    let _v12172 = v12190 
                    #endif
#else
                    let v12191 : (bool -> US7) = method22()
                    let v12192 : (exn -> US7) = method23()
                    let v12193 : US7 = match v12171 with Choice1Of2 x -> v12191 x | Choice2Of2 x -> v12192 x
                    let _v12172 = v12193 
                    #endif
                    let v12194 : US7 = _v12172 
                    return v12194 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v12199 : Async<US7> = _v12170 
            let _v12130 = v12199 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v12200 : unit = ()
            let _v12200 =
                async {
                    let! v12125 = v12125 
                    let v12201 : Choice<bool, exn> = v12125 
                    let v12202 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v12203 : US7 = null |> unbox<US7>
                    let _v12202 = v12203 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v12206 : US7 = null |> unbox<US7>
                    let _v12202 = v12206 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v12209 : US7 = null |> unbox<US7>
                    let _v12202 = v12209 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v12212 : US7 = null |> unbox<US7>
                    let _v12202 = v12212 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v12215 : US7 = null |> unbox<US7>
                    let _v12202 = v12215 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v12218 : (bool -> US7) = method22()
                    let v12219 : (exn -> US7) = method23()
                    let v12220 : US7 = match v12201 with Choice1Of2 x -> v12218 x | Choice2Of2 x -> v12219 x
                    let _v12202 = v12220 
                    #endif
#else
                    let v12221 : (bool -> US7) = method22()
                    let v12222 : (exn -> US7) = method23()
                    let v12223 : US7 = match v12201 with Choice1Of2 x -> v12221 x | Choice2Of2 x -> v12222 x
                    let _v12202 = v12223 
                    #endif
                    let v12224 : US7 = _v12202 
                    return v12224 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v12229 : Async<US7> = _v12200 
            let _v12130 = v12229 
            #endif
#else
            let v12230 : unit = ()
            let _v12230 =
                async {
                    let! v12125 = v12125 
                    let v12231 : Choice<bool, exn> = v12125 
                    let v12232 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v12233 : US7 = null |> unbox<US7>
                    let _v12232 = v12233 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v12236 : US7 = null |> unbox<US7>
                    let _v12232 = v12236 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v12239 : US7 = null |> unbox<US7>
                    let _v12232 = v12239 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v12242 : US7 = null |> unbox<US7>
                    let _v12232 = v12242 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v12245 : US7 = null |> unbox<US7>
                    let _v12232 = v12245 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v12248 : (bool -> US7) = method22()
                    let v12249 : (exn -> US7) = method23()
                    let v12250 : US7 = match v12231 with Choice1Of2 x -> v12248 x | Choice2Of2 x -> v12249 x
                    let _v12232 = v12250 
                    #endif
#else
                    let v12251 : (bool -> US7) = method22()
                    let v12252 : (exn -> US7) = method23()
                    let v12253 : US7 = match v12231 with Choice1Of2 x -> v12251 x | Choice2Of2 x -> v12252 x
                    let _v12232 = v12253 
                    #endif
                    let v12254 : US7 = _v12232 
                    return v12254 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v12259 : Async<US7> = _v12230 
            let _v12130 = v12259 
            #endif
            let v12260 : Async<US7> = _v12130 
            let v12265 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v12266 : Async<US8> = null |> unbox<Async<US8>>
            let _v12265 = v12266 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v12269 : Async<US8> = null |> unbox<Async<US8>>
            let _v12265 = v12269 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v12272 : Async<US8> = null |> unbox<Async<US8>>
            let _v12265 = v12272 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v12275 : unit = ()
            let _v12275 =
                async {
                    let! v12260 = v12260 
                    let v12276 : US7 = v12260 
                    let v12282 : US8 =
                        match v12276 with
                        | US7_0(v12277) -> (* C1of2 *)
                            US8_0(v12277)
                        | US7_1(v12279) -> (* C2of2 *)
                            US8_1(v12279)
                    return v12282 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v12283 : Async<US8> = _v12275 
            let _v12265 = v12283 
            #endif
#if FABLE_COMPILER_PYTHON
            let v12284 : unit = ()
            let _v12284 =
                async {
                    let! v12260 = v12260 
                    let v12285 : US7 = v12260 
                    let v12291 : US8 =
                        match v12285 with
                        | US7_0(v12286) -> (* C1of2 *)
                            US8_0(v12286)
                        | US7_1(v12288) -> (* C2of2 *)
                            US8_1(v12288)
                    return v12291 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v12292 : Async<US8> = _v12284 
            let _v12265 = v12292 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v12293 : unit = ()
            let _v12293 =
                async {
                    let! v12260 = v12260 
                    let v12294 : US7 = v12260 
                    let v12300 : US8 =
                        match v12294 with
                        | US7_0(v12295) -> (* C1of2 *)
                            US8_0(v12295)
                        | US7_1(v12297) -> (* C2of2 *)
                            US8_1(v12297)
                    return v12300 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v12301 : Async<US8> = _v12293 
            let _v12265 = v12301 
            #endif
#else
            let v12302 : unit = ()
            let _v12302 =
                async {
                    let! v12260 = v12260 
                    let v12303 : US7 = v12260 
                    let v12309 : US8 =
                        match v12303 with
                        | US7_0(v12304) -> (* C1of2 *)
                            US8_0(v12304)
                        | US7_1(v12306) -> (* C2of2 *)
                            US8_1(v12306)
                    return v12309 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v12310 : Async<US8> = _v12302 
            let _v12265 = v12310 
            #endif
            let v12311 : Async<US8> = _v12265 
            let v12316 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v12317 : Async<US6> = null |> unbox<Async<US6>>
            let _v12316 = v12317 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v12320 : Async<US6> = null |> unbox<Async<US6>>
            let _v12316 = v12320 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v12323 : Async<US6> = null |> unbox<Async<US6>>
            let _v12316 = v12323 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v12326 : unit = ()
            let _v12326 =
                async {
                    let! v12311 = v12311 
                    let v12327 : US8 = v12311 
                    let v12451 : US6 =
                        match v12327 with
                        | US8_1(v12330) -> (* Error *)
                            let v12331 : string = $"%A{v12330}"
                            let v12334 : string = "System.TimeoutException"
                            let v12335 : bool = v12331.Contains v12334 
                            if v12335 then
                                let v12338 : unit = ()
                                let v12339 : (unit -> unit) = closure16(v0)
                                let v12340 : unit = (fun () -> v12339 (); v12338) ()
                                US6_1
                            else
                                let v12381 : unit = ()
                                let v12382 : (unit -> unit) = closure17(v0, v12330)
                                let v12383 : unit = (fun () -> v12382 (); v12381) ()
                                US6_1
                        | US8_0(v12328) -> (* Ok *)
                            US6_0(v12328)
                    return v12451 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v12452 : Async<US6> = _v12326 
            let _v12316 = v12452 
            #endif
#if FABLE_COMPILER_PYTHON
            let v12453 : unit = ()
            let _v12453 =
                async {
                    let! v12311 = v12311 
                    let v12454 : US8 = v12311 
                    let v12578 : US6 =
                        match v12454 with
                        | US8_1(v12457) -> (* Error *)
                            let v12458 : string = $"%A{v12457}"
                            let v12461 : string = "System.TimeoutException"
                            let v12462 : bool = v12458.Contains v12461 
                            if v12462 then
                                let v12465 : unit = ()
                                let v12466 : (unit -> unit) = closure16(v0)
                                let v12467 : unit = (fun () -> v12466 (); v12465) ()
                                US6_1
                            else
                                let v12508 : unit = ()
                                let v12509 : (unit -> unit) = closure17(v0, v12457)
                                let v12510 : unit = (fun () -> v12509 (); v12508) ()
                                US6_1
                        | US8_0(v12455) -> (* Ok *)
                            US6_0(v12455)
                    return v12578 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v12579 : Async<US6> = _v12453 
            let _v12316 = v12579 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v12580 : unit = ()
            let _v12580 =
                async {
                    let! v12311 = v12311 
                    let v12581 : US8 = v12311 
                    let v12705 : US6 =
                        match v12581 with
                        | US8_1(v12584) -> (* Error *)
                            let v12585 : string = $"%A{v12584}"
                            let v12588 : string = "System.TimeoutException"
                            let v12589 : bool = v12585.Contains v12588 
                            if v12589 then
                                let v12592 : unit = ()
                                let v12593 : (unit -> unit) = closure16(v0)
                                let v12594 : unit = (fun () -> v12593 (); v12592) ()
                                US6_1
                            else
                                let v12635 : unit = ()
                                let v12636 : (unit -> unit) = closure17(v0, v12584)
                                let v12637 : unit = (fun () -> v12636 (); v12635) ()
                                US6_1
                        | US8_0(v12582) -> (* Ok *)
                            US6_0(v12582)
                    return v12705 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v12706 : Async<US6> = _v12580 
            let _v12316 = v12706 
            #endif
#else
            let v12707 : unit = ()
            let _v12707 =
                async {
                    let! v12311 = v12311 
                    let v12708 : US8 = v12311 
                    let v12832 : US6 =
                        match v12708 with
                        | US8_1(v12711) -> (* Error *)
                            let v12712 : string = $"%A{v12711}"
                            let v12715 : string = "System.TimeoutException"
                            let v12716 : bool = v12712.Contains v12715 
                            if v12716 then
                                let v12719 : unit = ()
                                let v12720 : (unit -> unit) = closure16(v0)
                                let v12721 : unit = (fun () -> v12720 (); v12719) ()
                                US6_1
                            else
                                let v12762 : unit = ()
                                let v12763 : (unit -> unit) = closure17(v0, v12711)
                                let v12764 : unit = (fun () -> v12763 (); v12762) ()
                                US6_1
                        | US8_0(v12709) -> (* Ok *)
                            US6_0(v12709)
                    return v12832 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v12833 : Async<US6> = _v12707 
            let _v12316 = v12833 
            #endif
            let v12834 : Async<US6> = _v12316 
            return! v12834 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v12839 : Async<US6> = _v12089 
    let _v12079 = v12839 
    #endif
#if FABLE_COMPILER_PYTHON
    let v12840 : unit = ()
    let _v12840 =
        async {
            let v12841 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v12842 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v12841 = v12842 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v12845 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v12841 = v12845 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v12848 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v12841 = v12848 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v12851 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v12841 = v12851 
            #endif
#if FABLE_COMPILER_PYTHON
            let v12852 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v12841 = v12852 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v12853 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v12841 = v12853 
            #endif
#else
            let v12854 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v12841 = v12854 
            #endif
            let v12855 : Async<Async<bool>> = _v12841 
            let! v12855 = v12855 
            let v12860 : Async<bool> = v12855 
            let v12861 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v12862 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v12863 : Async<Choice<bool, exn>> = v12862 v12860
            let _v12861 = v12863 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v12864 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v12865 : Async<Choice<bool, exn>> = v12864 v12860
            let _v12861 = v12865 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v12866 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v12867 : Async<Choice<bool, exn>> = v12866 v12860
            let _v12861 = v12867 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v12868 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v12869 : Async<Choice<bool, exn>> = v12868 v12860
            let _v12861 = v12869 
            #endif
#if FABLE_COMPILER_PYTHON
            let v12870 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v12871 : Async<Choice<bool, exn>> = v12870 v12860
            let _v12861 = v12871 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v12872 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v12873 : Async<Choice<bool, exn>> = v12872 v12860
            let _v12861 = v12873 
            #endif
#else
            let v12874 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v12875 : Async<Choice<bool, exn>> = v12874 v12860
            let _v12861 = v12875 
            #endif
            let v12876 : Async<Choice<bool, exn>> = _v12861 
            let v12881 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v12882 : Async<US7> = null |> unbox<Async<US7>>
            let _v12881 = v12882 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v12885 : Async<US7> = null |> unbox<Async<US7>>
            let _v12881 = v12885 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v12888 : Async<US7> = null |> unbox<Async<US7>>
            let _v12881 = v12888 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v12891 : unit = ()
            let _v12891 =
                async {
                    let! v12876 = v12876 
                    let v12892 : Choice<bool, exn> = v12876 
                    let v12893 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v12894 : US7 = null |> unbox<US7>
                    let _v12893 = v12894 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v12897 : US7 = null |> unbox<US7>
                    let _v12893 = v12897 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v12900 : US7 = null |> unbox<US7>
                    let _v12893 = v12900 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v12903 : US7 = null |> unbox<US7>
                    let _v12893 = v12903 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v12906 : US7 = null |> unbox<US7>
                    let _v12893 = v12906 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v12909 : (bool -> US7) = method22()
                    let v12910 : (exn -> US7) = method23()
                    let v12911 : US7 = match v12892 with Choice1Of2 x -> v12909 x | Choice2Of2 x -> v12910 x
                    let _v12893 = v12911 
                    #endif
#else
                    let v12912 : (bool -> US7) = method22()
                    let v12913 : (exn -> US7) = method23()
                    let v12914 : US7 = match v12892 with Choice1Of2 x -> v12912 x | Choice2Of2 x -> v12913 x
                    let _v12893 = v12914 
                    #endif
                    let v12915 : US7 = _v12893 
                    return v12915 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v12920 : Async<US7> = _v12891 
            let _v12881 = v12920 
            #endif
#if FABLE_COMPILER_PYTHON
            let v12921 : unit = ()
            let _v12921 =
                async {
                    let! v12876 = v12876 
                    let v12922 : Choice<bool, exn> = v12876 
                    let v12923 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v12924 : US7 = null |> unbox<US7>
                    let _v12923 = v12924 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v12927 : US7 = null |> unbox<US7>
                    let _v12923 = v12927 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v12930 : US7 = null |> unbox<US7>
                    let _v12923 = v12930 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v12933 : US7 = null |> unbox<US7>
                    let _v12923 = v12933 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v12936 : US7 = null |> unbox<US7>
                    let _v12923 = v12936 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v12939 : (bool -> US7) = method22()
                    let v12940 : (exn -> US7) = method23()
                    let v12941 : US7 = match v12922 with Choice1Of2 x -> v12939 x | Choice2Of2 x -> v12940 x
                    let _v12923 = v12941 
                    #endif
#else
                    let v12942 : (bool -> US7) = method22()
                    let v12943 : (exn -> US7) = method23()
                    let v12944 : US7 = match v12922 with Choice1Of2 x -> v12942 x | Choice2Of2 x -> v12943 x
                    let _v12923 = v12944 
                    #endif
                    let v12945 : US7 = _v12923 
                    return v12945 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v12950 : Async<US7> = _v12921 
            let _v12881 = v12950 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v12951 : unit = ()
            let _v12951 =
                async {
                    let! v12876 = v12876 
                    let v12952 : Choice<bool, exn> = v12876 
                    let v12953 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v12954 : US7 = null |> unbox<US7>
                    let _v12953 = v12954 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v12957 : US7 = null |> unbox<US7>
                    let _v12953 = v12957 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v12960 : US7 = null |> unbox<US7>
                    let _v12953 = v12960 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v12963 : US7 = null |> unbox<US7>
                    let _v12953 = v12963 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v12966 : US7 = null |> unbox<US7>
                    let _v12953 = v12966 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v12969 : (bool -> US7) = method22()
                    let v12970 : (exn -> US7) = method23()
                    let v12971 : US7 = match v12952 with Choice1Of2 x -> v12969 x | Choice2Of2 x -> v12970 x
                    let _v12953 = v12971 
                    #endif
#else
                    let v12972 : (bool -> US7) = method22()
                    let v12973 : (exn -> US7) = method23()
                    let v12974 : US7 = match v12952 with Choice1Of2 x -> v12972 x | Choice2Of2 x -> v12973 x
                    let _v12953 = v12974 
                    #endif
                    let v12975 : US7 = _v12953 
                    return v12975 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v12980 : Async<US7> = _v12951 
            let _v12881 = v12980 
            #endif
#else
            let v12981 : unit = ()
            let _v12981 =
                async {
                    let! v12876 = v12876 
                    let v12982 : Choice<bool, exn> = v12876 
                    let v12983 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v12984 : US7 = null |> unbox<US7>
                    let _v12983 = v12984 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v12987 : US7 = null |> unbox<US7>
                    let _v12983 = v12987 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v12990 : US7 = null |> unbox<US7>
                    let _v12983 = v12990 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v12993 : US7 = null |> unbox<US7>
                    let _v12983 = v12993 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v12996 : US7 = null |> unbox<US7>
                    let _v12983 = v12996 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v12999 : (bool -> US7) = method22()
                    let v13000 : (exn -> US7) = method23()
                    let v13001 : US7 = match v12982 with Choice1Of2 x -> v12999 x | Choice2Of2 x -> v13000 x
                    let _v12983 = v13001 
                    #endif
#else
                    let v13002 : (bool -> US7) = method22()
                    let v13003 : (exn -> US7) = method23()
                    let v13004 : US7 = match v12982 with Choice1Of2 x -> v13002 x | Choice2Of2 x -> v13003 x
                    let _v12983 = v13004 
                    #endif
                    let v13005 : US7 = _v12983 
                    return v13005 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v13010 : Async<US7> = _v12981 
            let _v12881 = v13010 
            #endif
            let v13011 : Async<US7> = _v12881 
            let v13016 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v13017 : Async<US8> = null |> unbox<Async<US8>>
            let _v13016 = v13017 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v13020 : Async<US8> = null |> unbox<Async<US8>>
            let _v13016 = v13020 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v13023 : Async<US8> = null |> unbox<Async<US8>>
            let _v13016 = v13023 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v13026 : unit = ()
            let _v13026 =
                async {
                    let! v13011 = v13011 
                    let v13027 : US7 = v13011 
                    let v13033 : US8 =
                        match v13027 with
                        | US7_0(v13028) -> (* C1of2 *)
                            US8_0(v13028)
                        | US7_1(v13030) -> (* C2of2 *)
                            US8_1(v13030)
                    return v13033 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v13034 : Async<US8> = _v13026 
            let _v13016 = v13034 
            #endif
#if FABLE_COMPILER_PYTHON
            let v13035 : unit = ()
            let _v13035 =
                async {
                    let! v13011 = v13011 
                    let v13036 : US7 = v13011 
                    let v13042 : US8 =
                        match v13036 with
                        | US7_0(v13037) -> (* C1of2 *)
                            US8_0(v13037)
                        | US7_1(v13039) -> (* C2of2 *)
                            US8_1(v13039)
                    return v13042 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v13043 : Async<US8> = _v13035 
            let _v13016 = v13043 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v13044 : unit = ()
            let _v13044 =
                async {
                    let! v13011 = v13011 
                    let v13045 : US7 = v13011 
                    let v13051 : US8 =
                        match v13045 with
                        | US7_0(v13046) -> (* C1of2 *)
                            US8_0(v13046)
                        | US7_1(v13048) -> (* C2of2 *)
                            US8_1(v13048)
                    return v13051 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v13052 : Async<US8> = _v13044 
            let _v13016 = v13052 
            #endif
#else
            let v13053 : unit = ()
            let _v13053 =
                async {
                    let! v13011 = v13011 
                    let v13054 : US7 = v13011 
                    let v13060 : US8 =
                        match v13054 with
                        | US7_0(v13055) -> (* C1of2 *)
                            US8_0(v13055)
                        | US7_1(v13057) -> (* C2of2 *)
                            US8_1(v13057)
                    return v13060 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v13061 : Async<US8> = _v13053 
            let _v13016 = v13061 
            #endif
            let v13062 : Async<US8> = _v13016 
            let v13067 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v13068 : Async<US6> = null |> unbox<Async<US6>>
            let _v13067 = v13068 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v13071 : Async<US6> = null |> unbox<Async<US6>>
            let _v13067 = v13071 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v13074 : Async<US6> = null |> unbox<Async<US6>>
            let _v13067 = v13074 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v13077 : unit = ()
            let _v13077 =
                async {
                    let! v13062 = v13062 
                    let v13078 : US8 = v13062 
                    let v13202 : US6 =
                        match v13078 with
                        | US8_1(v13081) -> (* Error *)
                            let v13082 : string = $"%A{v13081}"
                            let v13085 : string = "System.TimeoutException"
                            let v13086 : bool = v13082.Contains v13085 
                            if v13086 then
                                let v13089 : unit = ()
                                let v13090 : (unit -> unit) = closure16(v0)
                                let v13091 : unit = (fun () -> v13090 (); v13089) ()
                                US6_1
                            else
                                let v13132 : unit = ()
                                let v13133 : (unit -> unit) = closure17(v0, v13081)
                                let v13134 : unit = (fun () -> v13133 (); v13132) ()
                                US6_1
                        | US8_0(v13079) -> (* Ok *)
                            US6_0(v13079)
                    return v13202 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v13203 : Async<US6> = _v13077 
            let _v13067 = v13203 
            #endif
#if FABLE_COMPILER_PYTHON
            let v13204 : unit = ()
            let _v13204 =
                async {
                    let! v13062 = v13062 
                    let v13205 : US8 = v13062 
                    let v13329 : US6 =
                        match v13205 with
                        | US8_1(v13208) -> (* Error *)
                            let v13209 : string = $"%A{v13208}"
                            let v13212 : string = "System.TimeoutException"
                            let v13213 : bool = v13209.Contains v13212 
                            if v13213 then
                                let v13216 : unit = ()
                                let v13217 : (unit -> unit) = closure16(v0)
                                let v13218 : unit = (fun () -> v13217 (); v13216) ()
                                US6_1
                            else
                                let v13259 : unit = ()
                                let v13260 : (unit -> unit) = closure17(v0, v13208)
                                let v13261 : unit = (fun () -> v13260 (); v13259) ()
                                US6_1
                        | US8_0(v13206) -> (* Ok *)
                            US6_0(v13206)
                    return v13329 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v13330 : Async<US6> = _v13204 
            let _v13067 = v13330 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v13331 : unit = ()
            let _v13331 =
                async {
                    let! v13062 = v13062 
                    let v13332 : US8 = v13062 
                    let v13456 : US6 =
                        match v13332 with
                        | US8_1(v13335) -> (* Error *)
                            let v13336 : string = $"%A{v13335}"
                            let v13339 : string = "System.TimeoutException"
                            let v13340 : bool = v13336.Contains v13339 
                            if v13340 then
                                let v13343 : unit = ()
                                let v13344 : (unit -> unit) = closure16(v0)
                                let v13345 : unit = (fun () -> v13344 (); v13343) ()
                                US6_1
                            else
                                let v13386 : unit = ()
                                let v13387 : (unit -> unit) = closure17(v0, v13335)
                                let v13388 : unit = (fun () -> v13387 (); v13386) ()
                                US6_1
                        | US8_0(v13333) -> (* Ok *)
                            US6_0(v13333)
                    return v13456 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v13457 : Async<US6> = _v13331 
            let _v13067 = v13457 
            #endif
#else
            let v13458 : unit = ()
            let _v13458 =
                async {
                    let! v13062 = v13062 
                    let v13459 : US8 = v13062 
                    let v13583 : US6 =
                        match v13459 with
                        | US8_1(v13462) -> (* Error *)
                            let v13463 : string = $"%A{v13462}"
                            let v13466 : string = "System.TimeoutException"
                            let v13467 : bool = v13463.Contains v13466 
                            if v13467 then
                                let v13470 : unit = ()
                                let v13471 : (unit -> unit) = closure16(v0)
                                let v13472 : unit = (fun () -> v13471 (); v13470) ()
                                US6_1
                            else
                                let v13513 : unit = ()
                                let v13514 : (unit -> unit) = closure17(v0, v13462)
                                let v13515 : unit = (fun () -> v13514 (); v13513) ()
                                US6_1
                        | US8_0(v13460) -> (* Ok *)
                            US6_0(v13460)
                    return v13583 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v13584 : Async<US6> = _v13458 
            let _v13067 = v13584 
            #endif
            let v13585 : Async<US6> = _v13067 
            return! v13585 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v13590 : Async<US6> = _v12840 
    let _v12079 = v13590 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v13591 : unit = ()
    let _v13591 =
        async {
            let v13592 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v13593 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v13592 = v13593 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v13596 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v13592 = v13596 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v13599 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v13592 = v13599 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v13602 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v13592 = v13602 
            #endif
#if FABLE_COMPILER_PYTHON
            let v13603 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v13592 = v13603 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v13604 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v13592 = v13604 
            #endif
#else
            let v13605 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v13592 = v13605 
            #endif
            let v13606 : Async<Async<bool>> = _v13592 
            let! v13606 = v13606 
            let v13611 : Async<bool> = v13606 
            let v13612 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v13613 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v13614 : Async<Choice<bool, exn>> = v13613 v13611
            let _v13612 = v13614 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v13615 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v13616 : Async<Choice<bool, exn>> = v13615 v13611
            let _v13612 = v13616 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v13617 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v13618 : Async<Choice<bool, exn>> = v13617 v13611
            let _v13612 = v13618 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v13619 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v13620 : Async<Choice<bool, exn>> = v13619 v13611
            let _v13612 = v13620 
            #endif
#if FABLE_COMPILER_PYTHON
            let v13621 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v13622 : Async<Choice<bool, exn>> = v13621 v13611
            let _v13612 = v13622 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v13623 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v13624 : Async<Choice<bool, exn>> = v13623 v13611
            let _v13612 = v13624 
            #endif
#else
            let v13625 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v13626 : Async<Choice<bool, exn>> = v13625 v13611
            let _v13612 = v13626 
            #endif
            let v13627 : Async<Choice<bool, exn>> = _v13612 
            let v13632 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v13633 : Async<US7> = null |> unbox<Async<US7>>
            let _v13632 = v13633 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v13636 : Async<US7> = null |> unbox<Async<US7>>
            let _v13632 = v13636 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v13639 : Async<US7> = null |> unbox<Async<US7>>
            let _v13632 = v13639 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v13642 : unit = ()
            let _v13642 =
                async {
                    let! v13627 = v13627 
                    let v13643 : Choice<bool, exn> = v13627 
                    let v13644 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v13645 : US7 = null |> unbox<US7>
                    let _v13644 = v13645 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v13648 : US7 = null |> unbox<US7>
                    let _v13644 = v13648 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v13651 : US7 = null |> unbox<US7>
                    let _v13644 = v13651 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v13654 : US7 = null |> unbox<US7>
                    let _v13644 = v13654 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v13657 : US7 = null |> unbox<US7>
                    let _v13644 = v13657 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v13660 : (bool -> US7) = method22()
                    let v13661 : (exn -> US7) = method23()
                    let v13662 : US7 = match v13643 with Choice1Of2 x -> v13660 x | Choice2Of2 x -> v13661 x
                    let _v13644 = v13662 
                    #endif
#else
                    let v13663 : (bool -> US7) = method22()
                    let v13664 : (exn -> US7) = method23()
                    let v13665 : US7 = match v13643 with Choice1Of2 x -> v13663 x | Choice2Of2 x -> v13664 x
                    let _v13644 = v13665 
                    #endif
                    let v13666 : US7 = _v13644 
                    return v13666 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v13671 : Async<US7> = _v13642 
            let _v13632 = v13671 
            #endif
#if FABLE_COMPILER_PYTHON
            let v13672 : unit = ()
            let _v13672 =
                async {
                    let! v13627 = v13627 
                    let v13673 : Choice<bool, exn> = v13627 
                    let v13674 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v13675 : US7 = null |> unbox<US7>
                    let _v13674 = v13675 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v13678 : US7 = null |> unbox<US7>
                    let _v13674 = v13678 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v13681 : US7 = null |> unbox<US7>
                    let _v13674 = v13681 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v13684 : US7 = null |> unbox<US7>
                    let _v13674 = v13684 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v13687 : US7 = null |> unbox<US7>
                    let _v13674 = v13687 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v13690 : (bool -> US7) = method22()
                    let v13691 : (exn -> US7) = method23()
                    let v13692 : US7 = match v13673 with Choice1Of2 x -> v13690 x | Choice2Of2 x -> v13691 x
                    let _v13674 = v13692 
                    #endif
#else
                    let v13693 : (bool -> US7) = method22()
                    let v13694 : (exn -> US7) = method23()
                    let v13695 : US7 = match v13673 with Choice1Of2 x -> v13693 x | Choice2Of2 x -> v13694 x
                    let _v13674 = v13695 
                    #endif
                    let v13696 : US7 = _v13674 
                    return v13696 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v13701 : Async<US7> = _v13672 
            let _v13632 = v13701 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v13702 : unit = ()
            let _v13702 =
                async {
                    let! v13627 = v13627 
                    let v13703 : Choice<bool, exn> = v13627 
                    let v13704 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v13705 : US7 = null |> unbox<US7>
                    let _v13704 = v13705 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v13708 : US7 = null |> unbox<US7>
                    let _v13704 = v13708 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v13711 : US7 = null |> unbox<US7>
                    let _v13704 = v13711 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v13714 : US7 = null |> unbox<US7>
                    let _v13704 = v13714 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v13717 : US7 = null |> unbox<US7>
                    let _v13704 = v13717 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v13720 : (bool -> US7) = method22()
                    let v13721 : (exn -> US7) = method23()
                    let v13722 : US7 = match v13703 with Choice1Of2 x -> v13720 x | Choice2Of2 x -> v13721 x
                    let _v13704 = v13722 
                    #endif
#else
                    let v13723 : (bool -> US7) = method22()
                    let v13724 : (exn -> US7) = method23()
                    let v13725 : US7 = match v13703 with Choice1Of2 x -> v13723 x | Choice2Of2 x -> v13724 x
                    let _v13704 = v13725 
                    #endif
                    let v13726 : US7 = _v13704 
                    return v13726 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v13731 : Async<US7> = _v13702 
            let _v13632 = v13731 
            #endif
#else
            let v13732 : unit = ()
            let _v13732 =
                async {
                    let! v13627 = v13627 
                    let v13733 : Choice<bool, exn> = v13627 
                    let v13734 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v13735 : US7 = null |> unbox<US7>
                    let _v13734 = v13735 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v13738 : US7 = null |> unbox<US7>
                    let _v13734 = v13738 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v13741 : US7 = null |> unbox<US7>
                    let _v13734 = v13741 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v13744 : US7 = null |> unbox<US7>
                    let _v13734 = v13744 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v13747 : US7 = null |> unbox<US7>
                    let _v13734 = v13747 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v13750 : (bool -> US7) = method22()
                    let v13751 : (exn -> US7) = method23()
                    let v13752 : US7 = match v13733 with Choice1Of2 x -> v13750 x | Choice2Of2 x -> v13751 x
                    let _v13734 = v13752 
                    #endif
#else
                    let v13753 : (bool -> US7) = method22()
                    let v13754 : (exn -> US7) = method23()
                    let v13755 : US7 = match v13733 with Choice1Of2 x -> v13753 x | Choice2Of2 x -> v13754 x
                    let _v13734 = v13755 
                    #endif
                    let v13756 : US7 = _v13734 
                    return v13756 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v13761 : Async<US7> = _v13732 
            let _v13632 = v13761 
            #endif
            let v13762 : Async<US7> = _v13632 
            let v13767 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v13768 : Async<US8> = null |> unbox<Async<US8>>
            let _v13767 = v13768 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v13771 : Async<US8> = null |> unbox<Async<US8>>
            let _v13767 = v13771 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v13774 : Async<US8> = null |> unbox<Async<US8>>
            let _v13767 = v13774 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v13777 : unit = ()
            let _v13777 =
                async {
                    let! v13762 = v13762 
                    let v13778 : US7 = v13762 
                    let v13784 : US8 =
                        match v13778 with
                        | US7_0(v13779) -> (* C1of2 *)
                            US8_0(v13779)
                        | US7_1(v13781) -> (* C2of2 *)
                            US8_1(v13781)
                    return v13784 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v13785 : Async<US8> = _v13777 
            let _v13767 = v13785 
            #endif
#if FABLE_COMPILER_PYTHON
            let v13786 : unit = ()
            let _v13786 =
                async {
                    let! v13762 = v13762 
                    let v13787 : US7 = v13762 
                    let v13793 : US8 =
                        match v13787 with
                        | US7_0(v13788) -> (* C1of2 *)
                            US8_0(v13788)
                        | US7_1(v13790) -> (* C2of2 *)
                            US8_1(v13790)
                    return v13793 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v13794 : Async<US8> = _v13786 
            let _v13767 = v13794 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v13795 : unit = ()
            let _v13795 =
                async {
                    let! v13762 = v13762 
                    let v13796 : US7 = v13762 
                    let v13802 : US8 =
                        match v13796 with
                        | US7_0(v13797) -> (* C1of2 *)
                            US8_0(v13797)
                        | US7_1(v13799) -> (* C2of2 *)
                            US8_1(v13799)
                    return v13802 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v13803 : Async<US8> = _v13795 
            let _v13767 = v13803 
            #endif
#else
            let v13804 : unit = ()
            let _v13804 =
                async {
                    let! v13762 = v13762 
                    let v13805 : US7 = v13762 
                    let v13811 : US8 =
                        match v13805 with
                        | US7_0(v13806) -> (* C1of2 *)
                            US8_0(v13806)
                        | US7_1(v13808) -> (* C2of2 *)
                            US8_1(v13808)
                    return v13811 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v13812 : Async<US8> = _v13804 
            let _v13767 = v13812 
            #endif
            let v13813 : Async<US8> = _v13767 
            let v13818 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v13819 : Async<US6> = null |> unbox<Async<US6>>
            let _v13818 = v13819 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v13822 : Async<US6> = null |> unbox<Async<US6>>
            let _v13818 = v13822 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v13825 : Async<US6> = null |> unbox<Async<US6>>
            let _v13818 = v13825 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v13828 : unit = ()
            let _v13828 =
                async {
                    let! v13813 = v13813 
                    let v13829 : US8 = v13813 
                    let v13953 : US6 =
                        match v13829 with
                        | US8_1(v13832) -> (* Error *)
                            let v13833 : string = $"%A{v13832}"
                            let v13836 : string = "System.TimeoutException"
                            let v13837 : bool = v13833.Contains v13836 
                            if v13837 then
                                let v13840 : unit = ()
                                let v13841 : (unit -> unit) = closure16(v0)
                                let v13842 : unit = (fun () -> v13841 (); v13840) ()
                                US6_1
                            else
                                let v13883 : unit = ()
                                let v13884 : (unit -> unit) = closure17(v0, v13832)
                                let v13885 : unit = (fun () -> v13884 (); v13883) ()
                                US6_1
                        | US8_0(v13830) -> (* Ok *)
                            US6_0(v13830)
                    return v13953 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v13954 : Async<US6> = _v13828 
            let _v13818 = v13954 
            #endif
#if FABLE_COMPILER_PYTHON
            let v13955 : unit = ()
            let _v13955 =
                async {
                    let! v13813 = v13813 
                    let v13956 : US8 = v13813 
                    let v14080 : US6 =
                        match v13956 with
                        | US8_1(v13959) -> (* Error *)
                            let v13960 : string = $"%A{v13959}"
                            let v13963 : string = "System.TimeoutException"
                            let v13964 : bool = v13960.Contains v13963 
                            if v13964 then
                                let v13967 : unit = ()
                                let v13968 : (unit -> unit) = closure16(v0)
                                let v13969 : unit = (fun () -> v13968 (); v13967) ()
                                US6_1
                            else
                                let v14010 : unit = ()
                                let v14011 : (unit -> unit) = closure17(v0, v13959)
                                let v14012 : unit = (fun () -> v14011 (); v14010) ()
                                US6_1
                        | US8_0(v13957) -> (* Ok *)
                            US6_0(v13957)
                    return v14080 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v14081 : Async<US6> = _v13955 
            let _v13818 = v14081 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v14082 : unit = ()
            let _v14082 =
                async {
                    let! v13813 = v13813 
                    let v14083 : US8 = v13813 
                    let v14207 : US6 =
                        match v14083 with
                        | US8_1(v14086) -> (* Error *)
                            let v14087 : string = $"%A{v14086}"
                            let v14090 : string = "System.TimeoutException"
                            let v14091 : bool = v14087.Contains v14090 
                            if v14091 then
                                let v14094 : unit = ()
                                let v14095 : (unit -> unit) = closure16(v0)
                                let v14096 : unit = (fun () -> v14095 (); v14094) ()
                                US6_1
                            else
                                let v14137 : unit = ()
                                let v14138 : (unit -> unit) = closure17(v0, v14086)
                                let v14139 : unit = (fun () -> v14138 (); v14137) ()
                                US6_1
                        | US8_0(v14084) -> (* Ok *)
                            US6_0(v14084)
                    return v14207 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v14208 : Async<US6> = _v14082 
            let _v13818 = v14208 
            #endif
#else
            let v14209 : unit = ()
            let _v14209 =
                async {
                    let! v13813 = v13813 
                    let v14210 : US8 = v13813 
                    let v14334 : US6 =
                        match v14210 with
                        | US8_1(v14213) -> (* Error *)
                            let v14214 : string = $"%A{v14213}"
                            let v14217 : string = "System.TimeoutException"
                            let v14218 : bool = v14214.Contains v14217 
                            if v14218 then
                                let v14221 : unit = ()
                                let v14222 : (unit -> unit) = closure16(v0)
                                let v14223 : unit = (fun () -> v14222 (); v14221) ()
                                US6_1
                            else
                                let v14264 : unit = ()
                                let v14265 : (unit -> unit) = closure17(v0, v14213)
                                let v14266 : unit = (fun () -> v14265 (); v14264) ()
                                US6_1
                        | US8_0(v14211) -> (* Ok *)
                            US6_0(v14211)
                    return v14334 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v14335 : Async<US6> = _v14209 
            let _v13818 = v14335 
            #endif
            let v14336 : Async<US6> = _v13818 
            return! v14336 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v14341 : Async<US6> = _v13591 
    let _v12079 = v14341 
    #endif
#else
    let v14342 : unit = ()
    let _v14342 =
        async {
            let v14343 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v14344 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v14343 = v14344 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v14347 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v14343 = v14347 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v14350 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v14343 = v14350 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v14353 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v14343 = v14353 
            #endif
#if FABLE_COMPILER_PYTHON
            let v14354 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v14343 = v14354 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v14355 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v14343 = v14355 
            #endif
#else
            let v14356 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v14343 = v14356 
            #endif
            let v14357 : Async<Async<bool>> = _v14343 
            let! v14357 = v14357 
            let v14362 : Async<bool> = v14357 
            let v14363 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v14364 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v14365 : Async<Choice<bool, exn>> = v14364 v14362
            let _v14363 = v14365 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v14366 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v14367 : Async<Choice<bool, exn>> = v14366 v14362
            let _v14363 = v14367 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v14368 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v14369 : Async<Choice<bool, exn>> = v14368 v14362
            let _v14363 = v14369 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v14370 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v14371 : Async<Choice<bool, exn>> = v14370 v14362
            let _v14363 = v14371 
            #endif
#if FABLE_COMPILER_PYTHON
            let v14372 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v14373 : Async<Choice<bool, exn>> = v14372 v14362
            let _v14363 = v14373 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v14374 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v14375 : Async<Choice<bool, exn>> = v14374 v14362
            let _v14363 = v14375 
            #endif
#else
            let v14376 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v14377 : Async<Choice<bool, exn>> = v14376 v14362
            let _v14363 = v14377 
            #endif
            let v14378 : Async<Choice<bool, exn>> = _v14363 
            let v14383 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v14384 : Async<US7> = null |> unbox<Async<US7>>
            let _v14383 = v14384 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v14387 : Async<US7> = null |> unbox<Async<US7>>
            let _v14383 = v14387 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v14390 : Async<US7> = null |> unbox<Async<US7>>
            let _v14383 = v14390 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v14393 : unit = ()
            let _v14393 =
                async {
                    let! v14378 = v14378 
                    let v14394 : Choice<bool, exn> = v14378 
                    let v14395 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v14396 : US7 = null |> unbox<US7>
                    let _v14395 = v14396 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v14399 : US7 = null |> unbox<US7>
                    let _v14395 = v14399 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v14402 : US7 = null |> unbox<US7>
                    let _v14395 = v14402 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v14405 : US7 = null |> unbox<US7>
                    let _v14395 = v14405 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v14408 : US7 = null |> unbox<US7>
                    let _v14395 = v14408 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v14411 : (bool -> US7) = method22()
                    let v14412 : (exn -> US7) = method23()
                    let v14413 : US7 = match v14394 with Choice1Of2 x -> v14411 x | Choice2Of2 x -> v14412 x
                    let _v14395 = v14413 
                    #endif
#else
                    let v14414 : (bool -> US7) = method22()
                    let v14415 : (exn -> US7) = method23()
                    let v14416 : US7 = match v14394 with Choice1Of2 x -> v14414 x | Choice2Of2 x -> v14415 x
                    let _v14395 = v14416 
                    #endif
                    let v14417 : US7 = _v14395 
                    return v14417 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v14422 : Async<US7> = _v14393 
            let _v14383 = v14422 
            #endif
#if FABLE_COMPILER_PYTHON
            let v14423 : unit = ()
            let _v14423 =
                async {
                    let! v14378 = v14378 
                    let v14424 : Choice<bool, exn> = v14378 
                    let v14425 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v14426 : US7 = null |> unbox<US7>
                    let _v14425 = v14426 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v14429 : US7 = null |> unbox<US7>
                    let _v14425 = v14429 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v14432 : US7 = null |> unbox<US7>
                    let _v14425 = v14432 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v14435 : US7 = null |> unbox<US7>
                    let _v14425 = v14435 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v14438 : US7 = null |> unbox<US7>
                    let _v14425 = v14438 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v14441 : (bool -> US7) = method22()
                    let v14442 : (exn -> US7) = method23()
                    let v14443 : US7 = match v14424 with Choice1Of2 x -> v14441 x | Choice2Of2 x -> v14442 x
                    let _v14425 = v14443 
                    #endif
#else
                    let v14444 : (bool -> US7) = method22()
                    let v14445 : (exn -> US7) = method23()
                    let v14446 : US7 = match v14424 with Choice1Of2 x -> v14444 x | Choice2Of2 x -> v14445 x
                    let _v14425 = v14446 
                    #endif
                    let v14447 : US7 = _v14425 
                    return v14447 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v14452 : Async<US7> = _v14423 
            let _v14383 = v14452 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v14453 : unit = ()
            let _v14453 =
                async {
                    let! v14378 = v14378 
                    let v14454 : Choice<bool, exn> = v14378 
                    let v14455 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v14456 : US7 = null |> unbox<US7>
                    let _v14455 = v14456 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v14459 : US7 = null |> unbox<US7>
                    let _v14455 = v14459 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v14462 : US7 = null |> unbox<US7>
                    let _v14455 = v14462 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v14465 : US7 = null |> unbox<US7>
                    let _v14455 = v14465 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v14468 : US7 = null |> unbox<US7>
                    let _v14455 = v14468 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v14471 : (bool -> US7) = method22()
                    let v14472 : (exn -> US7) = method23()
                    let v14473 : US7 = match v14454 with Choice1Of2 x -> v14471 x | Choice2Of2 x -> v14472 x
                    let _v14455 = v14473 
                    #endif
#else
                    let v14474 : (bool -> US7) = method22()
                    let v14475 : (exn -> US7) = method23()
                    let v14476 : US7 = match v14454 with Choice1Of2 x -> v14474 x | Choice2Of2 x -> v14475 x
                    let _v14455 = v14476 
                    #endif
                    let v14477 : US7 = _v14455 
                    return v14477 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v14482 : Async<US7> = _v14453 
            let _v14383 = v14482 
            #endif
#else
            let v14483 : unit = ()
            let _v14483 =
                async {
                    let! v14378 = v14378 
                    let v14484 : Choice<bool, exn> = v14378 
                    let v14485 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v14486 : US7 = null |> unbox<US7>
                    let _v14485 = v14486 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v14489 : US7 = null |> unbox<US7>
                    let _v14485 = v14489 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v14492 : US7 = null |> unbox<US7>
                    let _v14485 = v14492 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v14495 : US7 = null |> unbox<US7>
                    let _v14485 = v14495 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v14498 : US7 = null |> unbox<US7>
                    let _v14485 = v14498 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v14501 : (bool -> US7) = method22()
                    let v14502 : (exn -> US7) = method23()
                    let v14503 : US7 = match v14484 with Choice1Of2 x -> v14501 x | Choice2Of2 x -> v14502 x
                    let _v14485 = v14503 
                    #endif
#else
                    let v14504 : (bool -> US7) = method22()
                    let v14505 : (exn -> US7) = method23()
                    let v14506 : US7 = match v14484 with Choice1Of2 x -> v14504 x | Choice2Of2 x -> v14505 x
                    let _v14485 = v14506 
                    #endif
                    let v14507 : US7 = _v14485 
                    return v14507 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v14512 : Async<US7> = _v14483 
            let _v14383 = v14512 
            #endif
            let v14513 : Async<US7> = _v14383 
            let v14518 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v14519 : Async<US8> = null |> unbox<Async<US8>>
            let _v14518 = v14519 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v14522 : Async<US8> = null |> unbox<Async<US8>>
            let _v14518 = v14522 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v14525 : Async<US8> = null |> unbox<Async<US8>>
            let _v14518 = v14525 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v14528 : unit = ()
            let _v14528 =
                async {
                    let! v14513 = v14513 
                    let v14529 : US7 = v14513 
                    let v14535 : US8 =
                        match v14529 with
                        | US7_0(v14530) -> (* C1of2 *)
                            US8_0(v14530)
                        | US7_1(v14532) -> (* C2of2 *)
                            US8_1(v14532)
                    return v14535 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v14536 : Async<US8> = _v14528 
            let _v14518 = v14536 
            #endif
#if FABLE_COMPILER_PYTHON
            let v14537 : unit = ()
            let _v14537 =
                async {
                    let! v14513 = v14513 
                    let v14538 : US7 = v14513 
                    let v14544 : US8 =
                        match v14538 with
                        | US7_0(v14539) -> (* C1of2 *)
                            US8_0(v14539)
                        | US7_1(v14541) -> (* C2of2 *)
                            US8_1(v14541)
                    return v14544 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v14545 : Async<US8> = _v14537 
            let _v14518 = v14545 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v14546 : unit = ()
            let _v14546 =
                async {
                    let! v14513 = v14513 
                    let v14547 : US7 = v14513 
                    let v14553 : US8 =
                        match v14547 with
                        | US7_0(v14548) -> (* C1of2 *)
                            US8_0(v14548)
                        | US7_1(v14550) -> (* C2of2 *)
                            US8_1(v14550)
                    return v14553 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v14554 : Async<US8> = _v14546 
            let _v14518 = v14554 
            #endif
#else
            let v14555 : unit = ()
            let _v14555 =
                async {
                    let! v14513 = v14513 
                    let v14556 : US7 = v14513 
                    let v14562 : US8 =
                        match v14556 with
                        | US7_0(v14557) -> (* C1of2 *)
                            US8_0(v14557)
                        | US7_1(v14559) -> (* C2of2 *)
                            US8_1(v14559)
                    return v14562 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v14563 : Async<US8> = _v14555 
            let _v14518 = v14563 
            #endif
            let v14564 : Async<US8> = _v14518 
            let v14569 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v14570 : Async<US6> = null |> unbox<Async<US6>>
            let _v14569 = v14570 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v14573 : Async<US6> = null |> unbox<Async<US6>>
            let _v14569 = v14573 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v14576 : Async<US6> = null |> unbox<Async<US6>>
            let _v14569 = v14576 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v14579 : unit = ()
            let _v14579 =
                async {
                    let! v14564 = v14564 
                    let v14580 : US8 = v14564 
                    let v14704 : US6 =
                        match v14580 with
                        | US8_1(v14583) -> (* Error *)
                            let v14584 : string = $"%A{v14583}"
                            let v14587 : string = "System.TimeoutException"
                            let v14588 : bool = v14584.Contains v14587 
                            if v14588 then
                                let v14591 : unit = ()
                                let v14592 : (unit -> unit) = closure16(v0)
                                let v14593 : unit = (fun () -> v14592 (); v14591) ()
                                US6_1
                            else
                                let v14634 : unit = ()
                                let v14635 : (unit -> unit) = closure17(v0, v14583)
                                let v14636 : unit = (fun () -> v14635 (); v14634) ()
                                US6_1
                        | US8_0(v14581) -> (* Ok *)
                            US6_0(v14581)
                    return v14704 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v14705 : Async<US6> = _v14579 
            let _v14569 = v14705 
            #endif
#if FABLE_COMPILER_PYTHON
            let v14706 : unit = ()
            let _v14706 =
                async {
                    let! v14564 = v14564 
                    let v14707 : US8 = v14564 
                    let v14831 : US6 =
                        match v14707 with
                        | US8_1(v14710) -> (* Error *)
                            let v14711 : string = $"%A{v14710}"
                            let v14714 : string = "System.TimeoutException"
                            let v14715 : bool = v14711.Contains v14714 
                            if v14715 then
                                let v14718 : unit = ()
                                let v14719 : (unit -> unit) = closure16(v0)
                                let v14720 : unit = (fun () -> v14719 (); v14718) ()
                                US6_1
                            else
                                let v14761 : unit = ()
                                let v14762 : (unit -> unit) = closure17(v0, v14710)
                                let v14763 : unit = (fun () -> v14762 (); v14761) ()
                                US6_1
                        | US8_0(v14708) -> (* Ok *)
                            US6_0(v14708)
                    return v14831 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v14832 : Async<US6> = _v14706 
            let _v14569 = v14832 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v14833 : unit = ()
            let _v14833 =
                async {
                    let! v14564 = v14564 
                    let v14834 : US8 = v14564 
                    let v14958 : US6 =
                        match v14834 with
                        | US8_1(v14837) -> (* Error *)
                            let v14838 : string = $"%A{v14837}"
                            let v14841 : string = "System.TimeoutException"
                            let v14842 : bool = v14838.Contains v14841 
                            if v14842 then
                                let v14845 : unit = ()
                                let v14846 : (unit -> unit) = closure16(v0)
                                let v14847 : unit = (fun () -> v14846 (); v14845) ()
                                US6_1
                            else
                                let v14888 : unit = ()
                                let v14889 : (unit -> unit) = closure17(v0, v14837)
                                let v14890 : unit = (fun () -> v14889 (); v14888) ()
                                US6_1
                        | US8_0(v14835) -> (* Ok *)
                            US6_0(v14835)
                    return v14958 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v14959 : Async<US6> = _v14833 
            let _v14569 = v14959 
            #endif
#else
            let v14960 : unit = ()
            let _v14960 =
                async {
                    let! v14564 = v14564 
                    let v14961 : US8 = v14564 
                    let v15085 : US6 =
                        match v14961 with
                        | US8_1(v14964) -> (* Error *)
                            let v14965 : string = $"%A{v14964}"
                            let v14968 : string = "System.TimeoutException"
                            let v14969 : bool = v14965.Contains v14968 
                            if v14969 then
                                let v14972 : unit = ()
                                let v14973 : (unit -> unit) = closure16(v0)
                                let v14974 : unit = (fun () -> v14973 (); v14972) ()
                                US6_1
                            else
                                let v15015 : unit = ()
                                let v15016 : (unit -> unit) = closure17(v0, v14964)
                                let v15017 : unit = (fun () -> v15016 (); v15015) ()
                                US6_1
                        | US8_0(v14962) -> (* Ok *)
                            US6_0(v14962)
                    return v15085 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v15086 : Async<US6> = _v14960 
            let _v14569 = v15086 
            #endif
            let v15087 : Async<US6> = _v14569 
            return! v15087 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v15092 : Async<US6> = _v14342 
    let _v12079 = v15092 
    #endif
    let v15093 : Async<US6> = _v12079 
    let _v2 = v15093 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v15098 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v15099 : Async<US6> = null |> unbox<Async<US6>>
    let _v15098 = v15099 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v15102 : Async<US6> = null |> unbox<Async<US6>>
    let _v15098 = v15102 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v15105 : Async<US6> = null |> unbox<Async<US6>>
    let _v15098 = v15105 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v15108 : unit = ()
    let _v15108 =
        async {
            let v15109 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v15110 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v15109 = v15110 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v15113 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v15109 = v15113 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v15116 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v15109 = v15116 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v15119 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v15109 = v15119 
            #endif
#if FABLE_COMPILER_PYTHON
            let v15120 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v15109 = v15120 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v15121 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v15109 = v15121 
            #endif
#else
            let v15122 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v15109 = v15122 
            #endif
            let v15123 : Async<Async<bool>> = _v15109 
            let! v15123 = v15123 
            let v15128 : Async<bool> = v15123 
            let v15129 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v15130 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v15131 : Async<Choice<bool, exn>> = v15130 v15128
            let _v15129 = v15131 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v15132 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v15133 : Async<Choice<bool, exn>> = v15132 v15128
            let _v15129 = v15133 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v15134 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v15135 : Async<Choice<bool, exn>> = v15134 v15128
            let _v15129 = v15135 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v15136 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v15137 : Async<Choice<bool, exn>> = v15136 v15128
            let _v15129 = v15137 
            #endif
#if FABLE_COMPILER_PYTHON
            let v15138 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v15139 : Async<Choice<bool, exn>> = v15138 v15128
            let _v15129 = v15139 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v15140 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v15141 : Async<Choice<bool, exn>> = v15140 v15128
            let _v15129 = v15141 
            #endif
#else
            let v15142 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v15143 : Async<Choice<bool, exn>> = v15142 v15128
            let _v15129 = v15143 
            #endif
            let v15144 : Async<Choice<bool, exn>> = _v15129 
            let v15149 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v15150 : Async<US7> = null |> unbox<Async<US7>>
            let _v15149 = v15150 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v15153 : Async<US7> = null |> unbox<Async<US7>>
            let _v15149 = v15153 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v15156 : Async<US7> = null |> unbox<Async<US7>>
            let _v15149 = v15156 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v15159 : unit = ()
            let _v15159 =
                async {
                    let! v15144 = v15144 
                    let v15160 : Choice<bool, exn> = v15144 
                    let v15161 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v15162 : US7 = null |> unbox<US7>
                    let _v15161 = v15162 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v15165 : US7 = null |> unbox<US7>
                    let _v15161 = v15165 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v15168 : US7 = null |> unbox<US7>
                    let _v15161 = v15168 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v15171 : US7 = null |> unbox<US7>
                    let _v15161 = v15171 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v15174 : US7 = null |> unbox<US7>
                    let _v15161 = v15174 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v15177 : (bool -> US7) = method22()
                    let v15178 : (exn -> US7) = method23()
                    let v15179 : US7 = match v15160 with Choice1Of2 x -> v15177 x | Choice2Of2 x -> v15178 x
                    let _v15161 = v15179 
                    #endif
#else
                    let v15180 : (bool -> US7) = method22()
                    let v15181 : (exn -> US7) = method23()
                    let v15182 : US7 = match v15160 with Choice1Of2 x -> v15180 x | Choice2Of2 x -> v15181 x
                    let _v15161 = v15182 
                    #endif
                    let v15183 : US7 = _v15161 
                    return v15183 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v15188 : Async<US7> = _v15159 
            let _v15149 = v15188 
            #endif
#if FABLE_COMPILER_PYTHON
            let v15189 : unit = ()
            let _v15189 =
                async {
                    let! v15144 = v15144 
                    let v15190 : Choice<bool, exn> = v15144 
                    let v15191 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v15192 : US7 = null |> unbox<US7>
                    let _v15191 = v15192 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v15195 : US7 = null |> unbox<US7>
                    let _v15191 = v15195 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v15198 : US7 = null |> unbox<US7>
                    let _v15191 = v15198 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v15201 : US7 = null |> unbox<US7>
                    let _v15191 = v15201 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v15204 : US7 = null |> unbox<US7>
                    let _v15191 = v15204 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v15207 : (bool -> US7) = method22()
                    let v15208 : (exn -> US7) = method23()
                    let v15209 : US7 = match v15190 with Choice1Of2 x -> v15207 x | Choice2Of2 x -> v15208 x
                    let _v15191 = v15209 
                    #endif
#else
                    let v15210 : (bool -> US7) = method22()
                    let v15211 : (exn -> US7) = method23()
                    let v15212 : US7 = match v15190 with Choice1Of2 x -> v15210 x | Choice2Of2 x -> v15211 x
                    let _v15191 = v15212 
                    #endif
                    let v15213 : US7 = _v15191 
                    return v15213 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v15218 : Async<US7> = _v15189 
            let _v15149 = v15218 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v15219 : unit = ()
            let _v15219 =
                async {
                    let! v15144 = v15144 
                    let v15220 : Choice<bool, exn> = v15144 
                    let v15221 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v15222 : US7 = null |> unbox<US7>
                    let _v15221 = v15222 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v15225 : US7 = null |> unbox<US7>
                    let _v15221 = v15225 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v15228 : US7 = null |> unbox<US7>
                    let _v15221 = v15228 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v15231 : US7 = null |> unbox<US7>
                    let _v15221 = v15231 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v15234 : US7 = null |> unbox<US7>
                    let _v15221 = v15234 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v15237 : (bool -> US7) = method22()
                    let v15238 : (exn -> US7) = method23()
                    let v15239 : US7 = match v15220 with Choice1Of2 x -> v15237 x | Choice2Of2 x -> v15238 x
                    let _v15221 = v15239 
                    #endif
#else
                    let v15240 : (bool -> US7) = method22()
                    let v15241 : (exn -> US7) = method23()
                    let v15242 : US7 = match v15220 with Choice1Of2 x -> v15240 x | Choice2Of2 x -> v15241 x
                    let _v15221 = v15242 
                    #endif
                    let v15243 : US7 = _v15221 
                    return v15243 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v15248 : Async<US7> = _v15219 
            let _v15149 = v15248 
            #endif
#else
            let v15249 : unit = ()
            let _v15249 =
                async {
                    let! v15144 = v15144 
                    let v15250 : Choice<bool, exn> = v15144 
                    let v15251 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v15252 : US7 = null |> unbox<US7>
                    let _v15251 = v15252 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v15255 : US7 = null |> unbox<US7>
                    let _v15251 = v15255 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v15258 : US7 = null |> unbox<US7>
                    let _v15251 = v15258 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v15261 : US7 = null |> unbox<US7>
                    let _v15251 = v15261 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v15264 : US7 = null |> unbox<US7>
                    let _v15251 = v15264 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v15267 : (bool -> US7) = method22()
                    let v15268 : (exn -> US7) = method23()
                    let v15269 : US7 = match v15250 with Choice1Of2 x -> v15267 x | Choice2Of2 x -> v15268 x
                    let _v15251 = v15269 
                    #endif
#else
                    let v15270 : (bool -> US7) = method22()
                    let v15271 : (exn -> US7) = method23()
                    let v15272 : US7 = match v15250 with Choice1Of2 x -> v15270 x | Choice2Of2 x -> v15271 x
                    let _v15251 = v15272 
                    #endif
                    let v15273 : US7 = _v15251 
                    return v15273 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v15278 : Async<US7> = _v15249 
            let _v15149 = v15278 
            #endif
            let v15279 : Async<US7> = _v15149 
            let v15284 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v15285 : Async<US8> = null |> unbox<Async<US8>>
            let _v15284 = v15285 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v15288 : Async<US8> = null |> unbox<Async<US8>>
            let _v15284 = v15288 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v15291 : Async<US8> = null |> unbox<Async<US8>>
            let _v15284 = v15291 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v15294 : unit = ()
            let _v15294 =
                async {
                    let! v15279 = v15279 
                    let v15295 : US7 = v15279 
                    let v15301 : US8 =
                        match v15295 with
                        | US7_0(v15296) -> (* C1of2 *)
                            US8_0(v15296)
                        | US7_1(v15298) -> (* C2of2 *)
                            US8_1(v15298)
                    return v15301 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v15302 : Async<US8> = _v15294 
            let _v15284 = v15302 
            #endif
#if FABLE_COMPILER_PYTHON
            let v15303 : unit = ()
            let _v15303 =
                async {
                    let! v15279 = v15279 
                    let v15304 : US7 = v15279 
                    let v15310 : US8 =
                        match v15304 with
                        | US7_0(v15305) -> (* C1of2 *)
                            US8_0(v15305)
                        | US7_1(v15307) -> (* C2of2 *)
                            US8_1(v15307)
                    return v15310 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v15311 : Async<US8> = _v15303 
            let _v15284 = v15311 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v15312 : unit = ()
            let _v15312 =
                async {
                    let! v15279 = v15279 
                    let v15313 : US7 = v15279 
                    let v15319 : US8 =
                        match v15313 with
                        | US7_0(v15314) -> (* C1of2 *)
                            US8_0(v15314)
                        | US7_1(v15316) -> (* C2of2 *)
                            US8_1(v15316)
                    return v15319 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v15320 : Async<US8> = _v15312 
            let _v15284 = v15320 
            #endif
#else
            let v15321 : unit = ()
            let _v15321 =
                async {
                    let! v15279 = v15279 
                    let v15322 : US7 = v15279 
                    let v15328 : US8 =
                        match v15322 with
                        | US7_0(v15323) -> (* C1of2 *)
                            US8_0(v15323)
                        | US7_1(v15325) -> (* C2of2 *)
                            US8_1(v15325)
                    return v15328 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v15329 : Async<US8> = _v15321 
            let _v15284 = v15329 
            #endif
            let v15330 : Async<US8> = _v15284 
            let v15335 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v15336 : Async<US6> = null |> unbox<Async<US6>>
            let _v15335 = v15336 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v15339 : Async<US6> = null |> unbox<Async<US6>>
            let _v15335 = v15339 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v15342 : Async<US6> = null |> unbox<Async<US6>>
            let _v15335 = v15342 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v15345 : unit = ()
            let _v15345 =
                async {
                    let! v15330 = v15330 
                    let v15346 : US8 = v15330 
                    let v15470 : US6 =
                        match v15346 with
                        | US8_1(v15349) -> (* Error *)
                            let v15350 : string = $"%A{v15349}"
                            let v15353 : string = "System.TimeoutException"
                            let v15354 : bool = v15350.Contains v15353 
                            if v15354 then
                                let v15357 : unit = ()
                                let v15358 : (unit -> unit) = closure16(v0)
                                let v15359 : unit = (fun () -> v15358 (); v15357) ()
                                US6_1
                            else
                                let v15400 : unit = ()
                                let v15401 : (unit -> unit) = closure17(v0, v15349)
                                let v15402 : unit = (fun () -> v15401 (); v15400) ()
                                US6_1
                        | US8_0(v15347) -> (* Ok *)
                            US6_0(v15347)
                    return v15470 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v15471 : Async<US6> = _v15345 
            let _v15335 = v15471 
            #endif
#if FABLE_COMPILER_PYTHON
            let v15472 : unit = ()
            let _v15472 =
                async {
                    let! v15330 = v15330 
                    let v15473 : US8 = v15330 
                    let v15597 : US6 =
                        match v15473 with
                        | US8_1(v15476) -> (* Error *)
                            let v15477 : string = $"%A{v15476}"
                            let v15480 : string = "System.TimeoutException"
                            let v15481 : bool = v15477.Contains v15480 
                            if v15481 then
                                let v15484 : unit = ()
                                let v15485 : (unit -> unit) = closure16(v0)
                                let v15486 : unit = (fun () -> v15485 (); v15484) ()
                                US6_1
                            else
                                let v15527 : unit = ()
                                let v15528 : (unit -> unit) = closure17(v0, v15476)
                                let v15529 : unit = (fun () -> v15528 (); v15527) ()
                                US6_1
                        | US8_0(v15474) -> (* Ok *)
                            US6_0(v15474)
                    return v15597 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v15598 : Async<US6> = _v15472 
            let _v15335 = v15598 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v15599 : unit = ()
            let _v15599 =
                async {
                    let! v15330 = v15330 
                    let v15600 : US8 = v15330 
                    let v15724 : US6 =
                        match v15600 with
                        | US8_1(v15603) -> (* Error *)
                            let v15604 : string = $"%A{v15603}"
                            let v15607 : string = "System.TimeoutException"
                            let v15608 : bool = v15604.Contains v15607 
                            if v15608 then
                                let v15611 : unit = ()
                                let v15612 : (unit -> unit) = closure16(v0)
                                let v15613 : unit = (fun () -> v15612 (); v15611) ()
                                US6_1
                            else
                                let v15654 : unit = ()
                                let v15655 : (unit -> unit) = closure17(v0, v15603)
                                let v15656 : unit = (fun () -> v15655 (); v15654) ()
                                US6_1
                        | US8_0(v15601) -> (* Ok *)
                            US6_0(v15601)
                    return v15724 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v15725 : Async<US6> = _v15599 
            let _v15335 = v15725 
            #endif
#else
            let v15726 : unit = ()
            let _v15726 =
                async {
                    let! v15330 = v15330 
                    let v15727 : US8 = v15330 
                    let v15851 : US6 =
                        match v15727 with
                        | US8_1(v15730) -> (* Error *)
                            let v15731 : string = $"%A{v15730}"
                            let v15734 : string = "System.TimeoutException"
                            let v15735 : bool = v15731.Contains v15734 
                            if v15735 then
                                let v15738 : unit = ()
                                let v15739 : (unit -> unit) = closure16(v0)
                                let v15740 : unit = (fun () -> v15739 (); v15738) ()
                                US6_1
                            else
                                let v15781 : unit = ()
                                let v15782 : (unit -> unit) = closure17(v0, v15730)
                                let v15783 : unit = (fun () -> v15782 (); v15781) ()
                                US6_1
                        | US8_0(v15728) -> (* Ok *)
                            US6_0(v15728)
                    return v15851 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v15852 : Async<US6> = _v15726 
            let _v15335 = v15852 
            #endif
            let v15853 : Async<US6> = _v15335 
            return! v15853 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v15858 : Async<US6> = _v15108 
    let _v15098 = v15858 
    #endif
#if FABLE_COMPILER_PYTHON
    let v15859 : unit = ()
    let _v15859 =
        async {
            let v15860 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v15861 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v15860 = v15861 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v15864 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v15860 = v15864 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v15867 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v15860 = v15867 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v15870 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v15860 = v15870 
            #endif
#if FABLE_COMPILER_PYTHON
            let v15871 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v15860 = v15871 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v15872 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v15860 = v15872 
            #endif
#else
            let v15873 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v15860 = v15873 
            #endif
            let v15874 : Async<Async<bool>> = _v15860 
            let! v15874 = v15874 
            let v15879 : Async<bool> = v15874 
            let v15880 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v15881 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v15882 : Async<Choice<bool, exn>> = v15881 v15879
            let _v15880 = v15882 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v15883 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v15884 : Async<Choice<bool, exn>> = v15883 v15879
            let _v15880 = v15884 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v15885 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v15886 : Async<Choice<bool, exn>> = v15885 v15879
            let _v15880 = v15886 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v15887 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v15888 : Async<Choice<bool, exn>> = v15887 v15879
            let _v15880 = v15888 
            #endif
#if FABLE_COMPILER_PYTHON
            let v15889 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v15890 : Async<Choice<bool, exn>> = v15889 v15879
            let _v15880 = v15890 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v15891 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v15892 : Async<Choice<bool, exn>> = v15891 v15879
            let _v15880 = v15892 
            #endif
#else
            let v15893 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v15894 : Async<Choice<bool, exn>> = v15893 v15879
            let _v15880 = v15894 
            #endif
            let v15895 : Async<Choice<bool, exn>> = _v15880 
            let v15900 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v15901 : Async<US7> = null |> unbox<Async<US7>>
            let _v15900 = v15901 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v15904 : Async<US7> = null |> unbox<Async<US7>>
            let _v15900 = v15904 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v15907 : Async<US7> = null |> unbox<Async<US7>>
            let _v15900 = v15907 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v15910 : unit = ()
            let _v15910 =
                async {
                    let! v15895 = v15895 
                    let v15911 : Choice<bool, exn> = v15895 
                    let v15912 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v15913 : US7 = null |> unbox<US7>
                    let _v15912 = v15913 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v15916 : US7 = null |> unbox<US7>
                    let _v15912 = v15916 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v15919 : US7 = null |> unbox<US7>
                    let _v15912 = v15919 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v15922 : US7 = null |> unbox<US7>
                    let _v15912 = v15922 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v15925 : US7 = null |> unbox<US7>
                    let _v15912 = v15925 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v15928 : (bool -> US7) = method22()
                    let v15929 : (exn -> US7) = method23()
                    let v15930 : US7 = match v15911 with Choice1Of2 x -> v15928 x | Choice2Of2 x -> v15929 x
                    let _v15912 = v15930 
                    #endif
#else
                    let v15931 : (bool -> US7) = method22()
                    let v15932 : (exn -> US7) = method23()
                    let v15933 : US7 = match v15911 with Choice1Of2 x -> v15931 x | Choice2Of2 x -> v15932 x
                    let _v15912 = v15933 
                    #endif
                    let v15934 : US7 = _v15912 
                    return v15934 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v15939 : Async<US7> = _v15910 
            let _v15900 = v15939 
            #endif
#if FABLE_COMPILER_PYTHON
            let v15940 : unit = ()
            let _v15940 =
                async {
                    let! v15895 = v15895 
                    let v15941 : Choice<bool, exn> = v15895 
                    let v15942 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v15943 : US7 = null |> unbox<US7>
                    let _v15942 = v15943 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v15946 : US7 = null |> unbox<US7>
                    let _v15942 = v15946 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v15949 : US7 = null |> unbox<US7>
                    let _v15942 = v15949 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v15952 : US7 = null |> unbox<US7>
                    let _v15942 = v15952 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v15955 : US7 = null |> unbox<US7>
                    let _v15942 = v15955 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v15958 : (bool -> US7) = method22()
                    let v15959 : (exn -> US7) = method23()
                    let v15960 : US7 = match v15941 with Choice1Of2 x -> v15958 x | Choice2Of2 x -> v15959 x
                    let _v15942 = v15960 
                    #endif
#else
                    let v15961 : (bool -> US7) = method22()
                    let v15962 : (exn -> US7) = method23()
                    let v15963 : US7 = match v15941 with Choice1Of2 x -> v15961 x | Choice2Of2 x -> v15962 x
                    let _v15942 = v15963 
                    #endif
                    let v15964 : US7 = _v15942 
                    return v15964 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v15969 : Async<US7> = _v15940 
            let _v15900 = v15969 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v15970 : unit = ()
            let _v15970 =
                async {
                    let! v15895 = v15895 
                    let v15971 : Choice<bool, exn> = v15895 
                    let v15972 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v15973 : US7 = null |> unbox<US7>
                    let _v15972 = v15973 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v15976 : US7 = null |> unbox<US7>
                    let _v15972 = v15976 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v15979 : US7 = null |> unbox<US7>
                    let _v15972 = v15979 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v15982 : US7 = null |> unbox<US7>
                    let _v15972 = v15982 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v15985 : US7 = null |> unbox<US7>
                    let _v15972 = v15985 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v15988 : (bool -> US7) = method22()
                    let v15989 : (exn -> US7) = method23()
                    let v15990 : US7 = match v15971 with Choice1Of2 x -> v15988 x | Choice2Of2 x -> v15989 x
                    let _v15972 = v15990 
                    #endif
#else
                    let v15991 : (bool -> US7) = method22()
                    let v15992 : (exn -> US7) = method23()
                    let v15993 : US7 = match v15971 with Choice1Of2 x -> v15991 x | Choice2Of2 x -> v15992 x
                    let _v15972 = v15993 
                    #endif
                    let v15994 : US7 = _v15972 
                    return v15994 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v15999 : Async<US7> = _v15970 
            let _v15900 = v15999 
            #endif
#else
            let v16000 : unit = ()
            let _v16000 =
                async {
                    let! v15895 = v15895 
                    let v16001 : Choice<bool, exn> = v15895 
                    let v16002 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v16003 : US7 = null |> unbox<US7>
                    let _v16002 = v16003 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v16006 : US7 = null |> unbox<US7>
                    let _v16002 = v16006 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v16009 : US7 = null |> unbox<US7>
                    let _v16002 = v16009 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v16012 : US7 = null |> unbox<US7>
                    let _v16002 = v16012 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v16015 : US7 = null |> unbox<US7>
                    let _v16002 = v16015 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v16018 : (bool -> US7) = method22()
                    let v16019 : (exn -> US7) = method23()
                    let v16020 : US7 = match v16001 with Choice1Of2 x -> v16018 x | Choice2Of2 x -> v16019 x
                    let _v16002 = v16020 
                    #endif
#else
                    let v16021 : (bool -> US7) = method22()
                    let v16022 : (exn -> US7) = method23()
                    let v16023 : US7 = match v16001 with Choice1Of2 x -> v16021 x | Choice2Of2 x -> v16022 x
                    let _v16002 = v16023 
                    #endif
                    let v16024 : US7 = _v16002 
                    return v16024 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v16029 : Async<US7> = _v16000 
            let _v15900 = v16029 
            #endif
            let v16030 : Async<US7> = _v15900 
            let v16035 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v16036 : Async<US8> = null |> unbox<Async<US8>>
            let _v16035 = v16036 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v16039 : Async<US8> = null |> unbox<Async<US8>>
            let _v16035 = v16039 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v16042 : Async<US8> = null |> unbox<Async<US8>>
            let _v16035 = v16042 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v16045 : unit = ()
            let _v16045 =
                async {
                    let! v16030 = v16030 
                    let v16046 : US7 = v16030 
                    let v16052 : US8 =
                        match v16046 with
                        | US7_0(v16047) -> (* C1of2 *)
                            US8_0(v16047)
                        | US7_1(v16049) -> (* C2of2 *)
                            US8_1(v16049)
                    return v16052 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v16053 : Async<US8> = _v16045 
            let _v16035 = v16053 
            #endif
#if FABLE_COMPILER_PYTHON
            let v16054 : unit = ()
            let _v16054 =
                async {
                    let! v16030 = v16030 
                    let v16055 : US7 = v16030 
                    let v16061 : US8 =
                        match v16055 with
                        | US7_0(v16056) -> (* C1of2 *)
                            US8_0(v16056)
                        | US7_1(v16058) -> (* C2of2 *)
                            US8_1(v16058)
                    return v16061 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v16062 : Async<US8> = _v16054 
            let _v16035 = v16062 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v16063 : unit = ()
            let _v16063 =
                async {
                    let! v16030 = v16030 
                    let v16064 : US7 = v16030 
                    let v16070 : US8 =
                        match v16064 with
                        | US7_0(v16065) -> (* C1of2 *)
                            US8_0(v16065)
                        | US7_1(v16067) -> (* C2of2 *)
                            US8_1(v16067)
                    return v16070 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v16071 : Async<US8> = _v16063 
            let _v16035 = v16071 
            #endif
#else
            let v16072 : unit = ()
            let _v16072 =
                async {
                    let! v16030 = v16030 
                    let v16073 : US7 = v16030 
                    let v16079 : US8 =
                        match v16073 with
                        | US7_0(v16074) -> (* C1of2 *)
                            US8_0(v16074)
                        | US7_1(v16076) -> (* C2of2 *)
                            US8_1(v16076)
                    return v16079 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v16080 : Async<US8> = _v16072 
            let _v16035 = v16080 
            #endif
            let v16081 : Async<US8> = _v16035 
            let v16086 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v16087 : Async<US6> = null |> unbox<Async<US6>>
            let _v16086 = v16087 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v16090 : Async<US6> = null |> unbox<Async<US6>>
            let _v16086 = v16090 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v16093 : Async<US6> = null |> unbox<Async<US6>>
            let _v16086 = v16093 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v16096 : unit = ()
            let _v16096 =
                async {
                    let! v16081 = v16081 
                    let v16097 : US8 = v16081 
                    let v16221 : US6 =
                        match v16097 with
                        | US8_1(v16100) -> (* Error *)
                            let v16101 : string = $"%A{v16100}"
                            let v16104 : string = "System.TimeoutException"
                            let v16105 : bool = v16101.Contains v16104 
                            if v16105 then
                                let v16108 : unit = ()
                                let v16109 : (unit -> unit) = closure16(v0)
                                let v16110 : unit = (fun () -> v16109 (); v16108) ()
                                US6_1
                            else
                                let v16151 : unit = ()
                                let v16152 : (unit -> unit) = closure17(v0, v16100)
                                let v16153 : unit = (fun () -> v16152 (); v16151) ()
                                US6_1
                        | US8_0(v16098) -> (* Ok *)
                            US6_0(v16098)
                    return v16221 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v16222 : Async<US6> = _v16096 
            let _v16086 = v16222 
            #endif
#if FABLE_COMPILER_PYTHON
            let v16223 : unit = ()
            let _v16223 =
                async {
                    let! v16081 = v16081 
                    let v16224 : US8 = v16081 
                    let v16348 : US6 =
                        match v16224 with
                        | US8_1(v16227) -> (* Error *)
                            let v16228 : string = $"%A{v16227}"
                            let v16231 : string = "System.TimeoutException"
                            let v16232 : bool = v16228.Contains v16231 
                            if v16232 then
                                let v16235 : unit = ()
                                let v16236 : (unit -> unit) = closure16(v0)
                                let v16237 : unit = (fun () -> v16236 (); v16235) ()
                                US6_1
                            else
                                let v16278 : unit = ()
                                let v16279 : (unit -> unit) = closure17(v0, v16227)
                                let v16280 : unit = (fun () -> v16279 (); v16278) ()
                                US6_1
                        | US8_0(v16225) -> (* Ok *)
                            US6_0(v16225)
                    return v16348 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v16349 : Async<US6> = _v16223 
            let _v16086 = v16349 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v16350 : unit = ()
            let _v16350 =
                async {
                    let! v16081 = v16081 
                    let v16351 : US8 = v16081 
                    let v16475 : US6 =
                        match v16351 with
                        | US8_1(v16354) -> (* Error *)
                            let v16355 : string = $"%A{v16354}"
                            let v16358 : string = "System.TimeoutException"
                            let v16359 : bool = v16355.Contains v16358 
                            if v16359 then
                                let v16362 : unit = ()
                                let v16363 : (unit -> unit) = closure16(v0)
                                let v16364 : unit = (fun () -> v16363 (); v16362) ()
                                US6_1
                            else
                                let v16405 : unit = ()
                                let v16406 : (unit -> unit) = closure17(v0, v16354)
                                let v16407 : unit = (fun () -> v16406 (); v16405) ()
                                US6_1
                        | US8_0(v16352) -> (* Ok *)
                            US6_0(v16352)
                    return v16475 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v16476 : Async<US6> = _v16350 
            let _v16086 = v16476 
            #endif
#else
            let v16477 : unit = ()
            let _v16477 =
                async {
                    let! v16081 = v16081 
                    let v16478 : US8 = v16081 
                    let v16602 : US6 =
                        match v16478 with
                        | US8_1(v16481) -> (* Error *)
                            let v16482 : string = $"%A{v16481}"
                            let v16485 : string = "System.TimeoutException"
                            let v16486 : bool = v16482.Contains v16485 
                            if v16486 then
                                let v16489 : unit = ()
                                let v16490 : (unit -> unit) = closure16(v0)
                                let v16491 : unit = (fun () -> v16490 (); v16489) ()
                                US6_1
                            else
                                let v16532 : unit = ()
                                let v16533 : (unit -> unit) = closure17(v0, v16481)
                                let v16534 : unit = (fun () -> v16533 (); v16532) ()
                                US6_1
                        | US8_0(v16479) -> (* Ok *)
                            US6_0(v16479)
                    return v16602 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v16603 : Async<US6> = _v16477 
            let _v16086 = v16603 
            #endif
            let v16604 : Async<US6> = _v16086 
            return! v16604 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v16609 : Async<US6> = _v15859 
    let _v15098 = v16609 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v16610 : unit = ()
    let _v16610 =
        async {
            let v16611 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v16612 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v16611 = v16612 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v16615 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v16611 = v16615 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v16618 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v16611 = v16618 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v16621 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v16611 = v16621 
            #endif
#if FABLE_COMPILER_PYTHON
            let v16622 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v16611 = v16622 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v16623 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v16611 = v16623 
            #endif
#else
            let v16624 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v16611 = v16624 
            #endif
            let v16625 : Async<Async<bool>> = _v16611 
            let! v16625 = v16625 
            let v16630 : Async<bool> = v16625 
            let v16631 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v16632 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v16633 : Async<Choice<bool, exn>> = v16632 v16630
            let _v16631 = v16633 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v16634 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v16635 : Async<Choice<bool, exn>> = v16634 v16630
            let _v16631 = v16635 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v16636 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v16637 : Async<Choice<bool, exn>> = v16636 v16630
            let _v16631 = v16637 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v16638 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v16639 : Async<Choice<bool, exn>> = v16638 v16630
            let _v16631 = v16639 
            #endif
#if FABLE_COMPILER_PYTHON
            let v16640 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v16641 : Async<Choice<bool, exn>> = v16640 v16630
            let _v16631 = v16641 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v16642 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v16643 : Async<Choice<bool, exn>> = v16642 v16630
            let _v16631 = v16643 
            #endif
#else
            let v16644 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v16645 : Async<Choice<bool, exn>> = v16644 v16630
            let _v16631 = v16645 
            #endif
            let v16646 : Async<Choice<bool, exn>> = _v16631 
            let v16651 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v16652 : Async<US7> = null |> unbox<Async<US7>>
            let _v16651 = v16652 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v16655 : Async<US7> = null |> unbox<Async<US7>>
            let _v16651 = v16655 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v16658 : Async<US7> = null |> unbox<Async<US7>>
            let _v16651 = v16658 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v16661 : unit = ()
            let _v16661 =
                async {
                    let! v16646 = v16646 
                    let v16662 : Choice<bool, exn> = v16646 
                    let v16663 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v16664 : US7 = null |> unbox<US7>
                    let _v16663 = v16664 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v16667 : US7 = null |> unbox<US7>
                    let _v16663 = v16667 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v16670 : US7 = null |> unbox<US7>
                    let _v16663 = v16670 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v16673 : US7 = null |> unbox<US7>
                    let _v16663 = v16673 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v16676 : US7 = null |> unbox<US7>
                    let _v16663 = v16676 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v16679 : (bool -> US7) = method22()
                    let v16680 : (exn -> US7) = method23()
                    let v16681 : US7 = match v16662 with Choice1Of2 x -> v16679 x | Choice2Of2 x -> v16680 x
                    let _v16663 = v16681 
                    #endif
#else
                    let v16682 : (bool -> US7) = method22()
                    let v16683 : (exn -> US7) = method23()
                    let v16684 : US7 = match v16662 with Choice1Of2 x -> v16682 x | Choice2Of2 x -> v16683 x
                    let _v16663 = v16684 
                    #endif
                    let v16685 : US7 = _v16663 
                    return v16685 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v16690 : Async<US7> = _v16661 
            let _v16651 = v16690 
            #endif
#if FABLE_COMPILER_PYTHON
            let v16691 : unit = ()
            let _v16691 =
                async {
                    let! v16646 = v16646 
                    let v16692 : Choice<bool, exn> = v16646 
                    let v16693 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v16694 : US7 = null |> unbox<US7>
                    let _v16693 = v16694 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v16697 : US7 = null |> unbox<US7>
                    let _v16693 = v16697 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v16700 : US7 = null |> unbox<US7>
                    let _v16693 = v16700 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v16703 : US7 = null |> unbox<US7>
                    let _v16693 = v16703 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v16706 : US7 = null |> unbox<US7>
                    let _v16693 = v16706 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v16709 : (bool -> US7) = method22()
                    let v16710 : (exn -> US7) = method23()
                    let v16711 : US7 = match v16692 with Choice1Of2 x -> v16709 x | Choice2Of2 x -> v16710 x
                    let _v16693 = v16711 
                    #endif
#else
                    let v16712 : (bool -> US7) = method22()
                    let v16713 : (exn -> US7) = method23()
                    let v16714 : US7 = match v16692 with Choice1Of2 x -> v16712 x | Choice2Of2 x -> v16713 x
                    let _v16693 = v16714 
                    #endif
                    let v16715 : US7 = _v16693 
                    return v16715 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v16720 : Async<US7> = _v16691 
            let _v16651 = v16720 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v16721 : unit = ()
            let _v16721 =
                async {
                    let! v16646 = v16646 
                    let v16722 : Choice<bool, exn> = v16646 
                    let v16723 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v16724 : US7 = null |> unbox<US7>
                    let _v16723 = v16724 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v16727 : US7 = null |> unbox<US7>
                    let _v16723 = v16727 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v16730 : US7 = null |> unbox<US7>
                    let _v16723 = v16730 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v16733 : US7 = null |> unbox<US7>
                    let _v16723 = v16733 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v16736 : US7 = null |> unbox<US7>
                    let _v16723 = v16736 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v16739 : (bool -> US7) = method22()
                    let v16740 : (exn -> US7) = method23()
                    let v16741 : US7 = match v16722 with Choice1Of2 x -> v16739 x | Choice2Of2 x -> v16740 x
                    let _v16723 = v16741 
                    #endif
#else
                    let v16742 : (bool -> US7) = method22()
                    let v16743 : (exn -> US7) = method23()
                    let v16744 : US7 = match v16722 with Choice1Of2 x -> v16742 x | Choice2Of2 x -> v16743 x
                    let _v16723 = v16744 
                    #endif
                    let v16745 : US7 = _v16723 
                    return v16745 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v16750 : Async<US7> = _v16721 
            let _v16651 = v16750 
            #endif
#else
            let v16751 : unit = ()
            let _v16751 =
                async {
                    let! v16646 = v16646 
                    let v16752 : Choice<bool, exn> = v16646 
                    let v16753 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v16754 : US7 = null |> unbox<US7>
                    let _v16753 = v16754 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v16757 : US7 = null |> unbox<US7>
                    let _v16753 = v16757 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v16760 : US7 = null |> unbox<US7>
                    let _v16753 = v16760 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v16763 : US7 = null |> unbox<US7>
                    let _v16753 = v16763 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v16766 : US7 = null |> unbox<US7>
                    let _v16753 = v16766 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v16769 : (bool -> US7) = method22()
                    let v16770 : (exn -> US7) = method23()
                    let v16771 : US7 = match v16752 with Choice1Of2 x -> v16769 x | Choice2Of2 x -> v16770 x
                    let _v16753 = v16771 
                    #endif
#else
                    let v16772 : (bool -> US7) = method22()
                    let v16773 : (exn -> US7) = method23()
                    let v16774 : US7 = match v16752 with Choice1Of2 x -> v16772 x | Choice2Of2 x -> v16773 x
                    let _v16753 = v16774 
                    #endif
                    let v16775 : US7 = _v16753 
                    return v16775 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v16780 : Async<US7> = _v16751 
            let _v16651 = v16780 
            #endif
            let v16781 : Async<US7> = _v16651 
            let v16786 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v16787 : Async<US8> = null |> unbox<Async<US8>>
            let _v16786 = v16787 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v16790 : Async<US8> = null |> unbox<Async<US8>>
            let _v16786 = v16790 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v16793 : Async<US8> = null |> unbox<Async<US8>>
            let _v16786 = v16793 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v16796 : unit = ()
            let _v16796 =
                async {
                    let! v16781 = v16781 
                    let v16797 : US7 = v16781 
                    let v16803 : US8 =
                        match v16797 with
                        | US7_0(v16798) -> (* C1of2 *)
                            US8_0(v16798)
                        | US7_1(v16800) -> (* C2of2 *)
                            US8_1(v16800)
                    return v16803 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v16804 : Async<US8> = _v16796 
            let _v16786 = v16804 
            #endif
#if FABLE_COMPILER_PYTHON
            let v16805 : unit = ()
            let _v16805 =
                async {
                    let! v16781 = v16781 
                    let v16806 : US7 = v16781 
                    let v16812 : US8 =
                        match v16806 with
                        | US7_0(v16807) -> (* C1of2 *)
                            US8_0(v16807)
                        | US7_1(v16809) -> (* C2of2 *)
                            US8_1(v16809)
                    return v16812 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v16813 : Async<US8> = _v16805 
            let _v16786 = v16813 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v16814 : unit = ()
            let _v16814 =
                async {
                    let! v16781 = v16781 
                    let v16815 : US7 = v16781 
                    let v16821 : US8 =
                        match v16815 with
                        | US7_0(v16816) -> (* C1of2 *)
                            US8_0(v16816)
                        | US7_1(v16818) -> (* C2of2 *)
                            US8_1(v16818)
                    return v16821 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v16822 : Async<US8> = _v16814 
            let _v16786 = v16822 
            #endif
#else
            let v16823 : unit = ()
            let _v16823 =
                async {
                    let! v16781 = v16781 
                    let v16824 : US7 = v16781 
                    let v16830 : US8 =
                        match v16824 with
                        | US7_0(v16825) -> (* C1of2 *)
                            US8_0(v16825)
                        | US7_1(v16827) -> (* C2of2 *)
                            US8_1(v16827)
                    return v16830 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v16831 : Async<US8> = _v16823 
            let _v16786 = v16831 
            #endif
            let v16832 : Async<US8> = _v16786 
            let v16837 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v16838 : Async<US6> = null |> unbox<Async<US6>>
            let _v16837 = v16838 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v16841 : Async<US6> = null |> unbox<Async<US6>>
            let _v16837 = v16841 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v16844 : Async<US6> = null |> unbox<Async<US6>>
            let _v16837 = v16844 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v16847 : unit = ()
            let _v16847 =
                async {
                    let! v16832 = v16832 
                    let v16848 : US8 = v16832 
                    let v16972 : US6 =
                        match v16848 with
                        | US8_1(v16851) -> (* Error *)
                            let v16852 : string = $"%A{v16851}"
                            let v16855 : string = "System.TimeoutException"
                            let v16856 : bool = v16852.Contains v16855 
                            if v16856 then
                                let v16859 : unit = ()
                                let v16860 : (unit -> unit) = closure16(v0)
                                let v16861 : unit = (fun () -> v16860 (); v16859) ()
                                US6_1
                            else
                                let v16902 : unit = ()
                                let v16903 : (unit -> unit) = closure17(v0, v16851)
                                let v16904 : unit = (fun () -> v16903 (); v16902) ()
                                US6_1
                        | US8_0(v16849) -> (* Ok *)
                            US6_0(v16849)
                    return v16972 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v16973 : Async<US6> = _v16847 
            let _v16837 = v16973 
            #endif
#if FABLE_COMPILER_PYTHON
            let v16974 : unit = ()
            let _v16974 =
                async {
                    let! v16832 = v16832 
                    let v16975 : US8 = v16832 
                    let v17099 : US6 =
                        match v16975 with
                        | US8_1(v16978) -> (* Error *)
                            let v16979 : string = $"%A{v16978}"
                            let v16982 : string = "System.TimeoutException"
                            let v16983 : bool = v16979.Contains v16982 
                            if v16983 then
                                let v16986 : unit = ()
                                let v16987 : (unit -> unit) = closure16(v0)
                                let v16988 : unit = (fun () -> v16987 (); v16986) ()
                                US6_1
                            else
                                let v17029 : unit = ()
                                let v17030 : (unit -> unit) = closure17(v0, v16978)
                                let v17031 : unit = (fun () -> v17030 (); v17029) ()
                                US6_1
                        | US8_0(v16976) -> (* Ok *)
                            US6_0(v16976)
                    return v17099 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v17100 : Async<US6> = _v16974 
            let _v16837 = v17100 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v17101 : unit = ()
            let _v17101 =
                async {
                    let! v16832 = v16832 
                    let v17102 : US8 = v16832 
                    let v17226 : US6 =
                        match v17102 with
                        | US8_1(v17105) -> (* Error *)
                            let v17106 : string = $"%A{v17105}"
                            let v17109 : string = "System.TimeoutException"
                            let v17110 : bool = v17106.Contains v17109 
                            if v17110 then
                                let v17113 : unit = ()
                                let v17114 : (unit -> unit) = closure16(v0)
                                let v17115 : unit = (fun () -> v17114 (); v17113) ()
                                US6_1
                            else
                                let v17156 : unit = ()
                                let v17157 : (unit -> unit) = closure17(v0, v17105)
                                let v17158 : unit = (fun () -> v17157 (); v17156) ()
                                US6_1
                        | US8_0(v17103) -> (* Ok *)
                            US6_0(v17103)
                    return v17226 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v17227 : Async<US6> = _v17101 
            let _v16837 = v17227 
            #endif
#else
            let v17228 : unit = ()
            let _v17228 =
                async {
                    let! v16832 = v16832 
                    let v17229 : US8 = v16832 
                    let v17353 : US6 =
                        match v17229 with
                        | US8_1(v17232) -> (* Error *)
                            let v17233 : string = $"%A{v17232}"
                            let v17236 : string = "System.TimeoutException"
                            let v17237 : bool = v17233.Contains v17236 
                            if v17237 then
                                let v17240 : unit = ()
                                let v17241 : (unit -> unit) = closure16(v0)
                                let v17242 : unit = (fun () -> v17241 (); v17240) ()
                                US6_1
                            else
                                let v17283 : unit = ()
                                let v17284 : (unit -> unit) = closure17(v0, v17232)
                                let v17285 : unit = (fun () -> v17284 (); v17283) ()
                                US6_1
                        | US8_0(v17230) -> (* Ok *)
                            US6_0(v17230)
                    return v17353 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v17354 : Async<US6> = _v17228 
            let _v16837 = v17354 
            #endif
            let v17355 : Async<US6> = _v16837 
            return! v17355 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v17360 : Async<US6> = _v16610 
    let _v15098 = v17360 
    #endif
#else
    let v17361 : unit = ()
    let _v17361 =
        async {
            let v17362 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v17363 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v17362 = v17363 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v17366 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v17362 = v17366 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v17369 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v17362 = v17369 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v17372 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v17362 = v17372 
            #endif
#if FABLE_COMPILER_PYTHON
            let v17373 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v17362 = v17373 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v17374 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v17362 = v17374 
            #endif
#else
            let v17375 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v17362 = v17375 
            #endif
            let v17376 : Async<Async<bool>> = _v17362 
            let! v17376 = v17376 
            let v17381 : Async<bool> = v17376 
            let v17382 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v17383 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v17384 : Async<Choice<bool, exn>> = v17383 v17381
            let _v17382 = v17384 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v17385 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v17386 : Async<Choice<bool, exn>> = v17385 v17381
            let _v17382 = v17386 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v17387 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v17388 : Async<Choice<bool, exn>> = v17387 v17381
            let _v17382 = v17388 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v17389 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v17390 : Async<Choice<bool, exn>> = v17389 v17381
            let _v17382 = v17390 
            #endif
#if FABLE_COMPILER_PYTHON
            let v17391 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v17392 : Async<Choice<bool, exn>> = v17391 v17381
            let _v17382 = v17392 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v17393 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v17394 : Async<Choice<bool, exn>> = v17393 v17381
            let _v17382 = v17394 
            #endif
#else
            let v17395 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v17396 : Async<Choice<bool, exn>> = v17395 v17381
            let _v17382 = v17396 
            #endif
            let v17397 : Async<Choice<bool, exn>> = _v17382 
            let v17402 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v17403 : Async<US7> = null |> unbox<Async<US7>>
            let _v17402 = v17403 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v17406 : Async<US7> = null |> unbox<Async<US7>>
            let _v17402 = v17406 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v17409 : Async<US7> = null |> unbox<Async<US7>>
            let _v17402 = v17409 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v17412 : unit = ()
            let _v17412 =
                async {
                    let! v17397 = v17397 
                    let v17413 : Choice<bool, exn> = v17397 
                    let v17414 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v17415 : US7 = null |> unbox<US7>
                    let _v17414 = v17415 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v17418 : US7 = null |> unbox<US7>
                    let _v17414 = v17418 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v17421 : US7 = null |> unbox<US7>
                    let _v17414 = v17421 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v17424 : US7 = null |> unbox<US7>
                    let _v17414 = v17424 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v17427 : US7 = null |> unbox<US7>
                    let _v17414 = v17427 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v17430 : (bool -> US7) = method22()
                    let v17431 : (exn -> US7) = method23()
                    let v17432 : US7 = match v17413 with Choice1Of2 x -> v17430 x | Choice2Of2 x -> v17431 x
                    let _v17414 = v17432 
                    #endif
#else
                    let v17433 : (bool -> US7) = method22()
                    let v17434 : (exn -> US7) = method23()
                    let v17435 : US7 = match v17413 with Choice1Of2 x -> v17433 x | Choice2Of2 x -> v17434 x
                    let _v17414 = v17435 
                    #endif
                    let v17436 : US7 = _v17414 
                    return v17436 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v17441 : Async<US7> = _v17412 
            let _v17402 = v17441 
            #endif
#if FABLE_COMPILER_PYTHON
            let v17442 : unit = ()
            let _v17442 =
                async {
                    let! v17397 = v17397 
                    let v17443 : Choice<bool, exn> = v17397 
                    let v17444 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v17445 : US7 = null |> unbox<US7>
                    let _v17444 = v17445 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v17448 : US7 = null |> unbox<US7>
                    let _v17444 = v17448 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v17451 : US7 = null |> unbox<US7>
                    let _v17444 = v17451 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v17454 : US7 = null |> unbox<US7>
                    let _v17444 = v17454 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v17457 : US7 = null |> unbox<US7>
                    let _v17444 = v17457 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v17460 : (bool -> US7) = method22()
                    let v17461 : (exn -> US7) = method23()
                    let v17462 : US7 = match v17443 with Choice1Of2 x -> v17460 x | Choice2Of2 x -> v17461 x
                    let _v17444 = v17462 
                    #endif
#else
                    let v17463 : (bool -> US7) = method22()
                    let v17464 : (exn -> US7) = method23()
                    let v17465 : US7 = match v17443 with Choice1Of2 x -> v17463 x | Choice2Of2 x -> v17464 x
                    let _v17444 = v17465 
                    #endif
                    let v17466 : US7 = _v17444 
                    return v17466 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v17471 : Async<US7> = _v17442 
            let _v17402 = v17471 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v17472 : unit = ()
            let _v17472 =
                async {
                    let! v17397 = v17397 
                    let v17473 : Choice<bool, exn> = v17397 
                    let v17474 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v17475 : US7 = null |> unbox<US7>
                    let _v17474 = v17475 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v17478 : US7 = null |> unbox<US7>
                    let _v17474 = v17478 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v17481 : US7 = null |> unbox<US7>
                    let _v17474 = v17481 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v17484 : US7 = null |> unbox<US7>
                    let _v17474 = v17484 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v17487 : US7 = null |> unbox<US7>
                    let _v17474 = v17487 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v17490 : (bool -> US7) = method22()
                    let v17491 : (exn -> US7) = method23()
                    let v17492 : US7 = match v17473 with Choice1Of2 x -> v17490 x | Choice2Of2 x -> v17491 x
                    let _v17474 = v17492 
                    #endif
#else
                    let v17493 : (bool -> US7) = method22()
                    let v17494 : (exn -> US7) = method23()
                    let v17495 : US7 = match v17473 with Choice1Of2 x -> v17493 x | Choice2Of2 x -> v17494 x
                    let _v17474 = v17495 
                    #endif
                    let v17496 : US7 = _v17474 
                    return v17496 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v17501 : Async<US7> = _v17472 
            let _v17402 = v17501 
            #endif
#else
            let v17502 : unit = ()
            let _v17502 =
                async {
                    let! v17397 = v17397 
                    let v17503 : Choice<bool, exn> = v17397 
                    let v17504 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v17505 : US7 = null |> unbox<US7>
                    let _v17504 = v17505 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v17508 : US7 = null |> unbox<US7>
                    let _v17504 = v17508 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v17511 : US7 = null |> unbox<US7>
                    let _v17504 = v17511 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v17514 : US7 = null |> unbox<US7>
                    let _v17504 = v17514 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v17517 : US7 = null |> unbox<US7>
                    let _v17504 = v17517 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v17520 : (bool -> US7) = method22()
                    let v17521 : (exn -> US7) = method23()
                    let v17522 : US7 = match v17503 with Choice1Of2 x -> v17520 x | Choice2Of2 x -> v17521 x
                    let _v17504 = v17522 
                    #endif
#else
                    let v17523 : (bool -> US7) = method22()
                    let v17524 : (exn -> US7) = method23()
                    let v17525 : US7 = match v17503 with Choice1Of2 x -> v17523 x | Choice2Of2 x -> v17524 x
                    let _v17504 = v17525 
                    #endif
                    let v17526 : US7 = _v17504 
                    return v17526 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v17531 : Async<US7> = _v17502 
            let _v17402 = v17531 
            #endif
            let v17532 : Async<US7> = _v17402 
            let v17537 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v17538 : Async<US8> = null |> unbox<Async<US8>>
            let _v17537 = v17538 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v17541 : Async<US8> = null |> unbox<Async<US8>>
            let _v17537 = v17541 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v17544 : Async<US8> = null |> unbox<Async<US8>>
            let _v17537 = v17544 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v17547 : unit = ()
            let _v17547 =
                async {
                    let! v17532 = v17532 
                    let v17548 : US7 = v17532 
                    let v17554 : US8 =
                        match v17548 with
                        | US7_0(v17549) -> (* C1of2 *)
                            US8_0(v17549)
                        | US7_1(v17551) -> (* C2of2 *)
                            US8_1(v17551)
                    return v17554 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v17555 : Async<US8> = _v17547 
            let _v17537 = v17555 
            #endif
#if FABLE_COMPILER_PYTHON
            let v17556 : unit = ()
            let _v17556 =
                async {
                    let! v17532 = v17532 
                    let v17557 : US7 = v17532 
                    let v17563 : US8 =
                        match v17557 with
                        | US7_0(v17558) -> (* C1of2 *)
                            US8_0(v17558)
                        | US7_1(v17560) -> (* C2of2 *)
                            US8_1(v17560)
                    return v17563 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v17564 : Async<US8> = _v17556 
            let _v17537 = v17564 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v17565 : unit = ()
            let _v17565 =
                async {
                    let! v17532 = v17532 
                    let v17566 : US7 = v17532 
                    let v17572 : US8 =
                        match v17566 with
                        | US7_0(v17567) -> (* C1of2 *)
                            US8_0(v17567)
                        | US7_1(v17569) -> (* C2of2 *)
                            US8_1(v17569)
                    return v17572 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v17573 : Async<US8> = _v17565 
            let _v17537 = v17573 
            #endif
#else
            let v17574 : unit = ()
            let _v17574 =
                async {
                    let! v17532 = v17532 
                    let v17575 : US7 = v17532 
                    let v17581 : US8 =
                        match v17575 with
                        | US7_0(v17576) -> (* C1of2 *)
                            US8_0(v17576)
                        | US7_1(v17578) -> (* C2of2 *)
                            US8_1(v17578)
                    return v17581 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v17582 : Async<US8> = _v17574 
            let _v17537 = v17582 
            #endif
            let v17583 : Async<US8> = _v17537 
            let v17588 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v17589 : Async<US6> = null |> unbox<Async<US6>>
            let _v17588 = v17589 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v17592 : Async<US6> = null |> unbox<Async<US6>>
            let _v17588 = v17592 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v17595 : Async<US6> = null |> unbox<Async<US6>>
            let _v17588 = v17595 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v17598 : unit = ()
            let _v17598 =
                async {
                    let! v17583 = v17583 
                    let v17599 : US8 = v17583 
                    let v17723 : US6 =
                        match v17599 with
                        | US8_1(v17602) -> (* Error *)
                            let v17603 : string = $"%A{v17602}"
                            let v17606 : string = "System.TimeoutException"
                            let v17607 : bool = v17603.Contains v17606 
                            if v17607 then
                                let v17610 : unit = ()
                                let v17611 : (unit -> unit) = closure16(v0)
                                let v17612 : unit = (fun () -> v17611 (); v17610) ()
                                US6_1
                            else
                                let v17653 : unit = ()
                                let v17654 : (unit -> unit) = closure17(v0, v17602)
                                let v17655 : unit = (fun () -> v17654 (); v17653) ()
                                US6_1
                        | US8_0(v17600) -> (* Ok *)
                            US6_0(v17600)
                    return v17723 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v17724 : Async<US6> = _v17598 
            let _v17588 = v17724 
            #endif
#if FABLE_COMPILER_PYTHON
            let v17725 : unit = ()
            let _v17725 =
                async {
                    let! v17583 = v17583 
                    let v17726 : US8 = v17583 
                    let v17850 : US6 =
                        match v17726 with
                        | US8_1(v17729) -> (* Error *)
                            let v17730 : string = $"%A{v17729}"
                            let v17733 : string = "System.TimeoutException"
                            let v17734 : bool = v17730.Contains v17733 
                            if v17734 then
                                let v17737 : unit = ()
                                let v17738 : (unit -> unit) = closure16(v0)
                                let v17739 : unit = (fun () -> v17738 (); v17737) ()
                                US6_1
                            else
                                let v17780 : unit = ()
                                let v17781 : (unit -> unit) = closure17(v0, v17729)
                                let v17782 : unit = (fun () -> v17781 (); v17780) ()
                                US6_1
                        | US8_0(v17727) -> (* Ok *)
                            US6_0(v17727)
                    return v17850 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v17851 : Async<US6> = _v17725 
            let _v17588 = v17851 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v17852 : unit = ()
            let _v17852 =
                async {
                    let! v17583 = v17583 
                    let v17853 : US8 = v17583 
                    let v17977 : US6 =
                        match v17853 with
                        | US8_1(v17856) -> (* Error *)
                            let v17857 : string = $"%A{v17856}"
                            let v17860 : string = "System.TimeoutException"
                            let v17861 : bool = v17857.Contains v17860 
                            if v17861 then
                                let v17864 : unit = ()
                                let v17865 : (unit -> unit) = closure16(v0)
                                let v17866 : unit = (fun () -> v17865 (); v17864) ()
                                US6_1
                            else
                                let v17907 : unit = ()
                                let v17908 : (unit -> unit) = closure17(v0, v17856)
                                let v17909 : unit = (fun () -> v17908 (); v17907) ()
                                US6_1
                        | US8_0(v17854) -> (* Ok *)
                            US6_0(v17854)
                    return v17977 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v17978 : Async<US6> = _v17852 
            let _v17588 = v17978 
            #endif
#else
            let v17979 : unit = ()
            let _v17979 =
                async {
                    let! v17583 = v17583 
                    let v17980 : US8 = v17583 
                    let v18104 : US6 =
                        match v17980 with
                        | US8_1(v17983) -> (* Error *)
                            let v17984 : string = $"%A{v17983}"
                            let v17987 : string = "System.TimeoutException"
                            let v17988 : bool = v17984.Contains v17987 
                            if v17988 then
                                let v17991 : unit = ()
                                let v17992 : (unit -> unit) = closure16(v0)
                                let v17993 : unit = (fun () -> v17992 (); v17991) ()
                                US6_1
                            else
                                let v18034 : unit = ()
                                let v18035 : (unit -> unit) = closure17(v0, v17983)
                                let v18036 : unit = (fun () -> v18035 (); v18034) ()
                                US6_1
                        | US8_0(v17981) -> (* Ok *)
                            US6_0(v17981)
                    return v18104 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v18105 : Async<US6> = _v17979 
            let _v17588 = v18105 
            #endif
            let v18106 : Async<US6> = _v17588 
            return! v18106 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v18111 : Async<US6> = _v17361 
    let _v15098 = v18111 
    #endif
    let v18112 : Async<US6> = _v15098 
    let _v2 = v18112 
    #endif
#else
    let v18117 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v18118 : Async<US6> = null |> unbox<Async<US6>>
    let _v18117 = v18118 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v18121 : Async<US6> = null |> unbox<Async<US6>>
    let _v18117 = v18121 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v18124 : Async<US6> = null |> unbox<Async<US6>>
    let _v18117 = v18124 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v18127 : unit = ()
    let _v18127 =
        async {
            let v18128 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v18129 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v18128 = v18129 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v18132 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v18128 = v18132 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v18135 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v18128 = v18135 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v18138 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v18128 = v18138 
            #endif
#if FABLE_COMPILER_PYTHON
            let v18139 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v18128 = v18139 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v18140 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v18128 = v18140 
            #endif
#else
            let v18141 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v18128 = v18141 
            #endif
            let v18142 : Async<Async<bool>> = _v18128 
            let! v18142 = v18142 
            let v18147 : Async<bool> = v18142 
            let v18148 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v18149 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v18150 : Async<Choice<bool, exn>> = v18149 v18147
            let _v18148 = v18150 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v18151 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v18152 : Async<Choice<bool, exn>> = v18151 v18147
            let _v18148 = v18152 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v18153 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v18154 : Async<Choice<bool, exn>> = v18153 v18147
            let _v18148 = v18154 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v18155 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v18156 : Async<Choice<bool, exn>> = v18155 v18147
            let _v18148 = v18156 
            #endif
#if FABLE_COMPILER_PYTHON
            let v18157 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v18158 : Async<Choice<bool, exn>> = v18157 v18147
            let _v18148 = v18158 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v18159 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v18160 : Async<Choice<bool, exn>> = v18159 v18147
            let _v18148 = v18160 
            #endif
#else
            let v18161 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v18162 : Async<Choice<bool, exn>> = v18161 v18147
            let _v18148 = v18162 
            #endif
            let v18163 : Async<Choice<bool, exn>> = _v18148 
            let v18168 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v18169 : Async<US7> = null |> unbox<Async<US7>>
            let _v18168 = v18169 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v18172 : Async<US7> = null |> unbox<Async<US7>>
            let _v18168 = v18172 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v18175 : Async<US7> = null |> unbox<Async<US7>>
            let _v18168 = v18175 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v18178 : unit = ()
            let _v18178 =
                async {
                    let! v18163 = v18163 
                    let v18179 : Choice<bool, exn> = v18163 
                    let v18180 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v18181 : US7 = null |> unbox<US7>
                    let _v18180 = v18181 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v18184 : US7 = null |> unbox<US7>
                    let _v18180 = v18184 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v18187 : US7 = null |> unbox<US7>
                    let _v18180 = v18187 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v18190 : US7 = null |> unbox<US7>
                    let _v18180 = v18190 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v18193 : US7 = null |> unbox<US7>
                    let _v18180 = v18193 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v18196 : (bool -> US7) = method22()
                    let v18197 : (exn -> US7) = method23()
                    let v18198 : US7 = match v18179 with Choice1Of2 x -> v18196 x | Choice2Of2 x -> v18197 x
                    let _v18180 = v18198 
                    #endif
#else
                    let v18199 : (bool -> US7) = method22()
                    let v18200 : (exn -> US7) = method23()
                    let v18201 : US7 = match v18179 with Choice1Of2 x -> v18199 x | Choice2Of2 x -> v18200 x
                    let _v18180 = v18201 
                    #endif
                    let v18202 : US7 = _v18180 
                    return v18202 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v18207 : Async<US7> = _v18178 
            let _v18168 = v18207 
            #endif
#if FABLE_COMPILER_PYTHON
            let v18208 : unit = ()
            let _v18208 =
                async {
                    let! v18163 = v18163 
                    let v18209 : Choice<bool, exn> = v18163 
                    let v18210 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v18211 : US7 = null |> unbox<US7>
                    let _v18210 = v18211 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v18214 : US7 = null |> unbox<US7>
                    let _v18210 = v18214 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v18217 : US7 = null |> unbox<US7>
                    let _v18210 = v18217 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v18220 : US7 = null |> unbox<US7>
                    let _v18210 = v18220 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v18223 : US7 = null |> unbox<US7>
                    let _v18210 = v18223 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v18226 : (bool -> US7) = method22()
                    let v18227 : (exn -> US7) = method23()
                    let v18228 : US7 = match v18209 with Choice1Of2 x -> v18226 x | Choice2Of2 x -> v18227 x
                    let _v18210 = v18228 
                    #endif
#else
                    let v18229 : (bool -> US7) = method22()
                    let v18230 : (exn -> US7) = method23()
                    let v18231 : US7 = match v18209 with Choice1Of2 x -> v18229 x | Choice2Of2 x -> v18230 x
                    let _v18210 = v18231 
                    #endif
                    let v18232 : US7 = _v18210 
                    return v18232 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v18237 : Async<US7> = _v18208 
            let _v18168 = v18237 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v18238 : unit = ()
            let _v18238 =
                async {
                    let! v18163 = v18163 
                    let v18239 : Choice<bool, exn> = v18163 
                    let v18240 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v18241 : US7 = null |> unbox<US7>
                    let _v18240 = v18241 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v18244 : US7 = null |> unbox<US7>
                    let _v18240 = v18244 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v18247 : US7 = null |> unbox<US7>
                    let _v18240 = v18247 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v18250 : US7 = null |> unbox<US7>
                    let _v18240 = v18250 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v18253 : US7 = null |> unbox<US7>
                    let _v18240 = v18253 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v18256 : (bool -> US7) = method22()
                    let v18257 : (exn -> US7) = method23()
                    let v18258 : US7 = match v18239 with Choice1Of2 x -> v18256 x | Choice2Of2 x -> v18257 x
                    let _v18240 = v18258 
                    #endif
#else
                    let v18259 : (bool -> US7) = method22()
                    let v18260 : (exn -> US7) = method23()
                    let v18261 : US7 = match v18239 with Choice1Of2 x -> v18259 x | Choice2Of2 x -> v18260 x
                    let _v18240 = v18261 
                    #endif
                    let v18262 : US7 = _v18240 
                    return v18262 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v18267 : Async<US7> = _v18238 
            let _v18168 = v18267 
            #endif
#else
            let v18268 : unit = ()
            let _v18268 =
                async {
                    let! v18163 = v18163 
                    let v18269 : Choice<bool, exn> = v18163 
                    let v18270 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v18271 : US7 = null |> unbox<US7>
                    let _v18270 = v18271 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v18274 : US7 = null |> unbox<US7>
                    let _v18270 = v18274 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v18277 : US7 = null |> unbox<US7>
                    let _v18270 = v18277 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v18280 : US7 = null |> unbox<US7>
                    let _v18270 = v18280 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v18283 : US7 = null |> unbox<US7>
                    let _v18270 = v18283 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v18286 : (bool -> US7) = method22()
                    let v18287 : (exn -> US7) = method23()
                    let v18288 : US7 = match v18269 with Choice1Of2 x -> v18286 x | Choice2Of2 x -> v18287 x
                    let _v18270 = v18288 
                    #endif
#else
                    let v18289 : (bool -> US7) = method22()
                    let v18290 : (exn -> US7) = method23()
                    let v18291 : US7 = match v18269 with Choice1Of2 x -> v18289 x | Choice2Of2 x -> v18290 x
                    let _v18270 = v18291 
                    #endif
                    let v18292 : US7 = _v18270 
                    return v18292 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v18297 : Async<US7> = _v18268 
            let _v18168 = v18297 
            #endif
            let v18298 : Async<US7> = _v18168 
            let v18303 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v18304 : Async<US8> = null |> unbox<Async<US8>>
            let _v18303 = v18304 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v18307 : Async<US8> = null |> unbox<Async<US8>>
            let _v18303 = v18307 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v18310 : Async<US8> = null |> unbox<Async<US8>>
            let _v18303 = v18310 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v18313 : unit = ()
            let _v18313 =
                async {
                    let! v18298 = v18298 
                    let v18314 : US7 = v18298 
                    let v18320 : US8 =
                        match v18314 with
                        | US7_0(v18315) -> (* C1of2 *)
                            US8_0(v18315)
                        | US7_1(v18317) -> (* C2of2 *)
                            US8_1(v18317)
                    return v18320 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v18321 : Async<US8> = _v18313 
            let _v18303 = v18321 
            #endif
#if FABLE_COMPILER_PYTHON
            let v18322 : unit = ()
            let _v18322 =
                async {
                    let! v18298 = v18298 
                    let v18323 : US7 = v18298 
                    let v18329 : US8 =
                        match v18323 with
                        | US7_0(v18324) -> (* C1of2 *)
                            US8_0(v18324)
                        | US7_1(v18326) -> (* C2of2 *)
                            US8_1(v18326)
                    return v18329 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v18330 : Async<US8> = _v18322 
            let _v18303 = v18330 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v18331 : unit = ()
            let _v18331 =
                async {
                    let! v18298 = v18298 
                    let v18332 : US7 = v18298 
                    let v18338 : US8 =
                        match v18332 with
                        | US7_0(v18333) -> (* C1of2 *)
                            US8_0(v18333)
                        | US7_1(v18335) -> (* C2of2 *)
                            US8_1(v18335)
                    return v18338 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v18339 : Async<US8> = _v18331 
            let _v18303 = v18339 
            #endif
#else
            let v18340 : unit = ()
            let _v18340 =
                async {
                    let! v18298 = v18298 
                    let v18341 : US7 = v18298 
                    let v18347 : US8 =
                        match v18341 with
                        | US7_0(v18342) -> (* C1of2 *)
                            US8_0(v18342)
                        | US7_1(v18344) -> (* C2of2 *)
                            US8_1(v18344)
                    return v18347 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v18348 : Async<US8> = _v18340 
            let _v18303 = v18348 
            #endif
            let v18349 : Async<US8> = _v18303 
            let v18354 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v18355 : Async<US6> = null |> unbox<Async<US6>>
            let _v18354 = v18355 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v18358 : Async<US6> = null |> unbox<Async<US6>>
            let _v18354 = v18358 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v18361 : Async<US6> = null |> unbox<Async<US6>>
            let _v18354 = v18361 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v18364 : unit = ()
            let _v18364 =
                async {
                    let! v18349 = v18349 
                    let v18365 : US8 = v18349 
                    let v18489 : US6 =
                        match v18365 with
                        | US8_1(v18368) -> (* Error *)
                            let v18369 : string = $"%A{v18368}"
                            let v18372 : string = "System.TimeoutException"
                            let v18373 : bool = v18369.Contains v18372 
                            if v18373 then
                                let v18376 : unit = ()
                                let v18377 : (unit -> unit) = closure16(v0)
                                let v18378 : unit = (fun () -> v18377 (); v18376) ()
                                US6_1
                            else
                                let v18419 : unit = ()
                                let v18420 : (unit -> unit) = closure17(v0, v18368)
                                let v18421 : unit = (fun () -> v18420 (); v18419) ()
                                US6_1
                        | US8_0(v18366) -> (* Ok *)
                            US6_0(v18366)
                    return v18489 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v18490 : Async<US6> = _v18364 
            let _v18354 = v18490 
            #endif
#if FABLE_COMPILER_PYTHON
            let v18491 : unit = ()
            let _v18491 =
                async {
                    let! v18349 = v18349 
                    let v18492 : US8 = v18349 
                    let v18616 : US6 =
                        match v18492 with
                        | US8_1(v18495) -> (* Error *)
                            let v18496 : string = $"%A{v18495}"
                            let v18499 : string = "System.TimeoutException"
                            let v18500 : bool = v18496.Contains v18499 
                            if v18500 then
                                let v18503 : unit = ()
                                let v18504 : (unit -> unit) = closure16(v0)
                                let v18505 : unit = (fun () -> v18504 (); v18503) ()
                                US6_1
                            else
                                let v18546 : unit = ()
                                let v18547 : (unit -> unit) = closure17(v0, v18495)
                                let v18548 : unit = (fun () -> v18547 (); v18546) ()
                                US6_1
                        | US8_0(v18493) -> (* Ok *)
                            US6_0(v18493)
                    return v18616 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v18617 : Async<US6> = _v18491 
            let _v18354 = v18617 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v18618 : unit = ()
            let _v18618 =
                async {
                    let! v18349 = v18349 
                    let v18619 : US8 = v18349 
                    let v18743 : US6 =
                        match v18619 with
                        | US8_1(v18622) -> (* Error *)
                            let v18623 : string = $"%A{v18622}"
                            let v18626 : string = "System.TimeoutException"
                            let v18627 : bool = v18623.Contains v18626 
                            if v18627 then
                                let v18630 : unit = ()
                                let v18631 : (unit -> unit) = closure16(v0)
                                let v18632 : unit = (fun () -> v18631 (); v18630) ()
                                US6_1
                            else
                                let v18673 : unit = ()
                                let v18674 : (unit -> unit) = closure17(v0, v18622)
                                let v18675 : unit = (fun () -> v18674 (); v18673) ()
                                US6_1
                        | US8_0(v18620) -> (* Ok *)
                            US6_0(v18620)
                    return v18743 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v18744 : Async<US6> = _v18618 
            let _v18354 = v18744 
            #endif
#else
            let v18745 : unit = ()
            let _v18745 =
                async {
                    let! v18349 = v18349 
                    let v18746 : US8 = v18349 
                    let v18870 : US6 =
                        match v18746 with
                        | US8_1(v18749) -> (* Error *)
                            let v18750 : string = $"%A{v18749}"
                            let v18753 : string = "System.TimeoutException"
                            let v18754 : bool = v18750.Contains v18753 
                            if v18754 then
                                let v18757 : unit = ()
                                let v18758 : (unit -> unit) = closure16(v0)
                                let v18759 : unit = (fun () -> v18758 (); v18757) ()
                                US6_1
                            else
                                let v18800 : unit = ()
                                let v18801 : (unit -> unit) = closure17(v0, v18749)
                                let v18802 : unit = (fun () -> v18801 (); v18800) ()
                                US6_1
                        | US8_0(v18747) -> (* Ok *)
                            US6_0(v18747)
                    return v18870 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v18871 : Async<US6> = _v18745 
            let _v18354 = v18871 
            #endif
            let v18872 : Async<US6> = _v18354 
            return! v18872 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v18877 : Async<US6> = _v18127 
    let _v18117 = v18877 
    #endif
#if FABLE_COMPILER_PYTHON
    let v18878 : unit = ()
    let _v18878 =
        async {
            let v18879 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v18880 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v18879 = v18880 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v18883 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v18879 = v18883 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v18886 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v18879 = v18886 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v18889 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v18879 = v18889 
            #endif
#if FABLE_COMPILER_PYTHON
            let v18890 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v18879 = v18890 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v18891 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v18879 = v18891 
            #endif
#else
            let v18892 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v18879 = v18892 
            #endif
            let v18893 : Async<Async<bool>> = _v18879 
            let! v18893 = v18893 
            let v18898 : Async<bool> = v18893 
            let v18899 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v18900 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v18901 : Async<Choice<bool, exn>> = v18900 v18898
            let _v18899 = v18901 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v18902 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v18903 : Async<Choice<bool, exn>> = v18902 v18898
            let _v18899 = v18903 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v18904 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v18905 : Async<Choice<bool, exn>> = v18904 v18898
            let _v18899 = v18905 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v18906 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v18907 : Async<Choice<bool, exn>> = v18906 v18898
            let _v18899 = v18907 
            #endif
#if FABLE_COMPILER_PYTHON
            let v18908 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v18909 : Async<Choice<bool, exn>> = v18908 v18898
            let _v18899 = v18909 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v18910 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v18911 : Async<Choice<bool, exn>> = v18910 v18898
            let _v18899 = v18911 
            #endif
#else
            let v18912 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v18913 : Async<Choice<bool, exn>> = v18912 v18898
            let _v18899 = v18913 
            #endif
            let v18914 : Async<Choice<bool, exn>> = _v18899 
            let v18919 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v18920 : Async<US7> = null |> unbox<Async<US7>>
            let _v18919 = v18920 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v18923 : Async<US7> = null |> unbox<Async<US7>>
            let _v18919 = v18923 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v18926 : Async<US7> = null |> unbox<Async<US7>>
            let _v18919 = v18926 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v18929 : unit = ()
            let _v18929 =
                async {
                    let! v18914 = v18914 
                    let v18930 : Choice<bool, exn> = v18914 
                    let v18931 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v18932 : US7 = null |> unbox<US7>
                    let _v18931 = v18932 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v18935 : US7 = null |> unbox<US7>
                    let _v18931 = v18935 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v18938 : US7 = null |> unbox<US7>
                    let _v18931 = v18938 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v18941 : US7 = null |> unbox<US7>
                    let _v18931 = v18941 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v18944 : US7 = null |> unbox<US7>
                    let _v18931 = v18944 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v18947 : (bool -> US7) = method22()
                    let v18948 : (exn -> US7) = method23()
                    let v18949 : US7 = match v18930 with Choice1Of2 x -> v18947 x | Choice2Of2 x -> v18948 x
                    let _v18931 = v18949 
                    #endif
#else
                    let v18950 : (bool -> US7) = method22()
                    let v18951 : (exn -> US7) = method23()
                    let v18952 : US7 = match v18930 with Choice1Of2 x -> v18950 x | Choice2Of2 x -> v18951 x
                    let _v18931 = v18952 
                    #endif
                    let v18953 : US7 = _v18931 
                    return v18953 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v18958 : Async<US7> = _v18929 
            let _v18919 = v18958 
            #endif
#if FABLE_COMPILER_PYTHON
            let v18959 : unit = ()
            let _v18959 =
                async {
                    let! v18914 = v18914 
                    let v18960 : Choice<bool, exn> = v18914 
                    let v18961 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v18962 : US7 = null |> unbox<US7>
                    let _v18961 = v18962 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v18965 : US7 = null |> unbox<US7>
                    let _v18961 = v18965 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v18968 : US7 = null |> unbox<US7>
                    let _v18961 = v18968 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v18971 : US7 = null |> unbox<US7>
                    let _v18961 = v18971 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v18974 : US7 = null |> unbox<US7>
                    let _v18961 = v18974 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v18977 : (bool -> US7) = method22()
                    let v18978 : (exn -> US7) = method23()
                    let v18979 : US7 = match v18960 with Choice1Of2 x -> v18977 x | Choice2Of2 x -> v18978 x
                    let _v18961 = v18979 
                    #endif
#else
                    let v18980 : (bool -> US7) = method22()
                    let v18981 : (exn -> US7) = method23()
                    let v18982 : US7 = match v18960 with Choice1Of2 x -> v18980 x | Choice2Of2 x -> v18981 x
                    let _v18961 = v18982 
                    #endif
                    let v18983 : US7 = _v18961 
                    return v18983 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v18988 : Async<US7> = _v18959 
            let _v18919 = v18988 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v18989 : unit = ()
            let _v18989 =
                async {
                    let! v18914 = v18914 
                    let v18990 : Choice<bool, exn> = v18914 
                    let v18991 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v18992 : US7 = null |> unbox<US7>
                    let _v18991 = v18992 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v18995 : US7 = null |> unbox<US7>
                    let _v18991 = v18995 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v18998 : US7 = null |> unbox<US7>
                    let _v18991 = v18998 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v19001 : US7 = null |> unbox<US7>
                    let _v18991 = v19001 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v19004 : US7 = null |> unbox<US7>
                    let _v18991 = v19004 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v19007 : (bool -> US7) = method22()
                    let v19008 : (exn -> US7) = method23()
                    let v19009 : US7 = match v18990 with Choice1Of2 x -> v19007 x | Choice2Of2 x -> v19008 x
                    let _v18991 = v19009 
                    #endif
#else
                    let v19010 : (bool -> US7) = method22()
                    let v19011 : (exn -> US7) = method23()
                    let v19012 : US7 = match v18990 with Choice1Of2 x -> v19010 x | Choice2Of2 x -> v19011 x
                    let _v18991 = v19012 
                    #endif
                    let v19013 : US7 = _v18991 
                    return v19013 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v19018 : Async<US7> = _v18989 
            let _v18919 = v19018 
            #endif
#else
            let v19019 : unit = ()
            let _v19019 =
                async {
                    let! v18914 = v18914 
                    let v19020 : Choice<bool, exn> = v18914 
                    let v19021 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v19022 : US7 = null |> unbox<US7>
                    let _v19021 = v19022 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v19025 : US7 = null |> unbox<US7>
                    let _v19021 = v19025 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v19028 : US7 = null |> unbox<US7>
                    let _v19021 = v19028 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v19031 : US7 = null |> unbox<US7>
                    let _v19021 = v19031 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v19034 : US7 = null |> unbox<US7>
                    let _v19021 = v19034 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v19037 : (bool -> US7) = method22()
                    let v19038 : (exn -> US7) = method23()
                    let v19039 : US7 = match v19020 with Choice1Of2 x -> v19037 x | Choice2Of2 x -> v19038 x
                    let _v19021 = v19039 
                    #endif
#else
                    let v19040 : (bool -> US7) = method22()
                    let v19041 : (exn -> US7) = method23()
                    let v19042 : US7 = match v19020 with Choice1Of2 x -> v19040 x | Choice2Of2 x -> v19041 x
                    let _v19021 = v19042 
                    #endif
                    let v19043 : US7 = _v19021 
                    return v19043 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v19048 : Async<US7> = _v19019 
            let _v18919 = v19048 
            #endif
            let v19049 : Async<US7> = _v18919 
            let v19054 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v19055 : Async<US8> = null |> unbox<Async<US8>>
            let _v19054 = v19055 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v19058 : Async<US8> = null |> unbox<Async<US8>>
            let _v19054 = v19058 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v19061 : Async<US8> = null |> unbox<Async<US8>>
            let _v19054 = v19061 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v19064 : unit = ()
            let _v19064 =
                async {
                    let! v19049 = v19049 
                    let v19065 : US7 = v19049 
                    let v19071 : US8 =
                        match v19065 with
                        | US7_0(v19066) -> (* C1of2 *)
                            US8_0(v19066)
                        | US7_1(v19068) -> (* C2of2 *)
                            US8_1(v19068)
                    return v19071 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v19072 : Async<US8> = _v19064 
            let _v19054 = v19072 
            #endif
#if FABLE_COMPILER_PYTHON
            let v19073 : unit = ()
            let _v19073 =
                async {
                    let! v19049 = v19049 
                    let v19074 : US7 = v19049 
                    let v19080 : US8 =
                        match v19074 with
                        | US7_0(v19075) -> (* C1of2 *)
                            US8_0(v19075)
                        | US7_1(v19077) -> (* C2of2 *)
                            US8_1(v19077)
                    return v19080 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v19081 : Async<US8> = _v19073 
            let _v19054 = v19081 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v19082 : unit = ()
            let _v19082 =
                async {
                    let! v19049 = v19049 
                    let v19083 : US7 = v19049 
                    let v19089 : US8 =
                        match v19083 with
                        | US7_0(v19084) -> (* C1of2 *)
                            US8_0(v19084)
                        | US7_1(v19086) -> (* C2of2 *)
                            US8_1(v19086)
                    return v19089 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v19090 : Async<US8> = _v19082 
            let _v19054 = v19090 
            #endif
#else
            let v19091 : unit = ()
            let _v19091 =
                async {
                    let! v19049 = v19049 
                    let v19092 : US7 = v19049 
                    let v19098 : US8 =
                        match v19092 with
                        | US7_0(v19093) -> (* C1of2 *)
                            US8_0(v19093)
                        | US7_1(v19095) -> (* C2of2 *)
                            US8_1(v19095)
                    return v19098 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v19099 : Async<US8> = _v19091 
            let _v19054 = v19099 
            #endif
            let v19100 : Async<US8> = _v19054 
            let v19105 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v19106 : Async<US6> = null |> unbox<Async<US6>>
            let _v19105 = v19106 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v19109 : Async<US6> = null |> unbox<Async<US6>>
            let _v19105 = v19109 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v19112 : Async<US6> = null |> unbox<Async<US6>>
            let _v19105 = v19112 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v19115 : unit = ()
            let _v19115 =
                async {
                    let! v19100 = v19100 
                    let v19116 : US8 = v19100 
                    let v19240 : US6 =
                        match v19116 with
                        | US8_1(v19119) -> (* Error *)
                            let v19120 : string = $"%A{v19119}"
                            let v19123 : string = "System.TimeoutException"
                            let v19124 : bool = v19120.Contains v19123 
                            if v19124 then
                                let v19127 : unit = ()
                                let v19128 : (unit -> unit) = closure16(v0)
                                let v19129 : unit = (fun () -> v19128 (); v19127) ()
                                US6_1
                            else
                                let v19170 : unit = ()
                                let v19171 : (unit -> unit) = closure17(v0, v19119)
                                let v19172 : unit = (fun () -> v19171 (); v19170) ()
                                US6_1
                        | US8_0(v19117) -> (* Ok *)
                            US6_0(v19117)
                    return v19240 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v19241 : Async<US6> = _v19115 
            let _v19105 = v19241 
            #endif
#if FABLE_COMPILER_PYTHON
            let v19242 : unit = ()
            let _v19242 =
                async {
                    let! v19100 = v19100 
                    let v19243 : US8 = v19100 
                    let v19367 : US6 =
                        match v19243 with
                        | US8_1(v19246) -> (* Error *)
                            let v19247 : string = $"%A{v19246}"
                            let v19250 : string = "System.TimeoutException"
                            let v19251 : bool = v19247.Contains v19250 
                            if v19251 then
                                let v19254 : unit = ()
                                let v19255 : (unit -> unit) = closure16(v0)
                                let v19256 : unit = (fun () -> v19255 (); v19254) ()
                                US6_1
                            else
                                let v19297 : unit = ()
                                let v19298 : (unit -> unit) = closure17(v0, v19246)
                                let v19299 : unit = (fun () -> v19298 (); v19297) ()
                                US6_1
                        | US8_0(v19244) -> (* Ok *)
                            US6_0(v19244)
                    return v19367 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v19368 : Async<US6> = _v19242 
            let _v19105 = v19368 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v19369 : unit = ()
            let _v19369 =
                async {
                    let! v19100 = v19100 
                    let v19370 : US8 = v19100 
                    let v19494 : US6 =
                        match v19370 with
                        | US8_1(v19373) -> (* Error *)
                            let v19374 : string = $"%A{v19373}"
                            let v19377 : string = "System.TimeoutException"
                            let v19378 : bool = v19374.Contains v19377 
                            if v19378 then
                                let v19381 : unit = ()
                                let v19382 : (unit -> unit) = closure16(v0)
                                let v19383 : unit = (fun () -> v19382 (); v19381) ()
                                US6_1
                            else
                                let v19424 : unit = ()
                                let v19425 : (unit -> unit) = closure17(v0, v19373)
                                let v19426 : unit = (fun () -> v19425 (); v19424) ()
                                US6_1
                        | US8_0(v19371) -> (* Ok *)
                            US6_0(v19371)
                    return v19494 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v19495 : Async<US6> = _v19369 
            let _v19105 = v19495 
            #endif
#else
            let v19496 : unit = ()
            let _v19496 =
                async {
                    let! v19100 = v19100 
                    let v19497 : US8 = v19100 
                    let v19621 : US6 =
                        match v19497 with
                        | US8_1(v19500) -> (* Error *)
                            let v19501 : string = $"%A{v19500}"
                            let v19504 : string = "System.TimeoutException"
                            let v19505 : bool = v19501.Contains v19504 
                            if v19505 then
                                let v19508 : unit = ()
                                let v19509 : (unit -> unit) = closure16(v0)
                                let v19510 : unit = (fun () -> v19509 (); v19508) ()
                                US6_1
                            else
                                let v19551 : unit = ()
                                let v19552 : (unit -> unit) = closure17(v0, v19500)
                                let v19553 : unit = (fun () -> v19552 (); v19551) ()
                                US6_1
                        | US8_0(v19498) -> (* Ok *)
                            US6_0(v19498)
                    return v19621 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v19622 : Async<US6> = _v19496 
            let _v19105 = v19622 
            #endif
            let v19623 : Async<US6> = _v19105 
            return! v19623 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v19628 : Async<US6> = _v18878 
    let _v18117 = v19628 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v19629 : unit = ()
    let _v19629 =
        async {
            let v19630 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v19631 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v19630 = v19631 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v19634 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v19630 = v19634 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v19637 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v19630 = v19637 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v19640 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v19630 = v19640 
            #endif
#if FABLE_COMPILER_PYTHON
            let v19641 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v19630 = v19641 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v19642 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v19630 = v19642 
            #endif
#else
            let v19643 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v19630 = v19643 
            #endif
            let v19644 : Async<Async<bool>> = _v19630 
            let! v19644 = v19644 
            let v19649 : Async<bool> = v19644 
            let v19650 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v19651 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v19652 : Async<Choice<bool, exn>> = v19651 v19649
            let _v19650 = v19652 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v19653 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v19654 : Async<Choice<bool, exn>> = v19653 v19649
            let _v19650 = v19654 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v19655 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v19656 : Async<Choice<bool, exn>> = v19655 v19649
            let _v19650 = v19656 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v19657 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v19658 : Async<Choice<bool, exn>> = v19657 v19649
            let _v19650 = v19658 
            #endif
#if FABLE_COMPILER_PYTHON
            let v19659 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v19660 : Async<Choice<bool, exn>> = v19659 v19649
            let _v19650 = v19660 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v19661 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v19662 : Async<Choice<bool, exn>> = v19661 v19649
            let _v19650 = v19662 
            #endif
#else
            let v19663 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v19664 : Async<Choice<bool, exn>> = v19663 v19649
            let _v19650 = v19664 
            #endif
            let v19665 : Async<Choice<bool, exn>> = _v19650 
            let v19670 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v19671 : Async<US7> = null |> unbox<Async<US7>>
            let _v19670 = v19671 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v19674 : Async<US7> = null |> unbox<Async<US7>>
            let _v19670 = v19674 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v19677 : Async<US7> = null |> unbox<Async<US7>>
            let _v19670 = v19677 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v19680 : unit = ()
            let _v19680 =
                async {
                    let! v19665 = v19665 
                    let v19681 : Choice<bool, exn> = v19665 
                    let v19682 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v19683 : US7 = null |> unbox<US7>
                    let _v19682 = v19683 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v19686 : US7 = null |> unbox<US7>
                    let _v19682 = v19686 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v19689 : US7 = null |> unbox<US7>
                    let _v19682 = v19689 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v19692 : US7 = null |> unbox<US7>
                    let _v19682 = v19692 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v19695 : US7 = null |> unbox<US7>
                    let _v19682 = v19695 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v19698 : (bool -> US7) = method22()
                    let v19699 : (exn -> US7) = method23()
                    let v19700 : US7 = match v19681 with Choice1Of2 x -> v19698 x | Choice2Of2 x -> v19699 x
                    let _v19682 = v19700 
                    #endif
#else
                    let v19701 : (bool -> US7) = method22()
                    let v19702 : (exn -> US7) = method23()
                    let v19703 : US7 = match v19681 with Choice1Of2 x -> v19701 x | Choice2Of2 x -> v19702 x
                    let _v19682 = v19703 
                    #endif
                    let v19704 : US7 = _v19682 
                    return v19704 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v19709 : Async<US7> = _v19680 
            let _v19670 = v19709 
            #endif
#if FABLE_COMPILER_PYTHON
            let v19710 : unit = ()
            let _v19710 =
                async {
                    let! v19665 = v19665 
                    let v19711 : Choice<bool, exn> = v19665 
                    let v19712 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v19713 : US7 = null |> unbox<US7>
                    let _v19712 = v19713 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v19716 : US7 = null |> unbox<US7>
                    let _v19712 = v19716 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v19719 : US7 = null |> unbox<US7>
                    let _v19712 = v19719 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v19722 : US7 = null |> unbox<US7>
                    let _v19712 = v19722 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v19725 : US7 = null |> unbox<US7>
                    let _v19712 = v19725 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v19728 : (bool -> US7) = method22()
                    let v19729 : (exn -> US7) = method23()
                    let v19730 : US7 = match v19711 with Choice1Of2 x -> v19728 x | Choice2Of2 x -> v19729 x
                    let _v19712 = v19730 
                    #endif
#else
                    let v19731 : (bool -> US7) = method22()
                    let v19732 : (exn -> US7) = method23()
                    let v19733 : US7 = match v19711 with Choice1Of2 x -> v19731 x | Choice2Of2 x -> v19732 x
                    let _v19712 = v19733 
                    #endif
                    let v19734 : US7 = _v19712 
                    return v19734 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v19739 : Async<US7> = _v19710 
            let _v19670 = v19739 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v19740 : unit = ()
            let _v19740 =
                async {
                    let! v19665 = v19665 
                    let v19741 : Choice<bool, exn> = v19665 
                    let v19742 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v19743 : US7 = null |> unbox<US7>
                    let _v19742 = v19743 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v19746 : US7 = null |> unbox<US7>
                    let _v19742 = v19746 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v19749 : US7 = null |> unbox<US7>
                    let _v19742 = v19749 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v19752 : US7 = null |> unbox<US7>
                    let _v19742 = v19752 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v19755 : US7 = null |> unbox<US7>
                    let _v19742 = v19755 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v19758 : (bool -> US7) = method22()
                    let v19759 : (exn -> US7) = method23()
                    let v19760 : US7 = match v19741 with Choice1Of2 x -> v19758 x | Choice2Of2 x -> v19759 x
                    let _v19742 = v19760 
                    #endif
#else
                    let v19761 : (bool -> US7) = method22()
                    let v19762 : (exn -> US7) = method23()
                    let v19763 : US7 = match v19741 with Choice1Of2 x -> v19761 x | Choice2Of2 x -> v19762 x
                    let _v19742 = v19763 
                    #endif
                    let v19764 : US7 = _v19742 
                    return v19764 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v19769 : Async<US7> = _v19740 
            let _v19670 = v19769 
            #endif
#else
            let v19770 : unit = ()
            let _v19770 =
                async {
                    let! v19665 = v19665 
                    let v19771 : Choice<bool, exn> = v19665 
                    let v19772 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v19773 : US7 = null |> unbox<US7>
                    let _v19772 = v19773 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v19776 : US7 = null |> unbox<US7>
                    let _v19772 = v19776 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v19779 : US7 = null |> unbox<US7>
                    let _v19772 = v19779 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v19782 : US7 = null |> unbox<US7>
                    let _v19772 = v19782 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v19785 : US7 = null |> unbox<US7>
                    let _v19772 = v19785 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v19788 : (bool -> US7) = method22()
                    let v19789 : (exn -> US7) = method23()
                    let v19790 : US7 = match v19771 with Choice1Of2 x -> v19788 x | Choice2Of2 x -> v19789 x
                    let _v19772 = v19790 
                    #endif
#else
                    let v19791 : (bool -> US7) = method22()
                    let v19792 : (exn -> US7) = method23()
                    let v19793 : US7 = match v19771 with Choice1Of2 x -> v19791 x | Choice2Of2 x -> v19792 x
                    let _v19772 = v19793 
                    #endif
                    let v19794 : US7 = _v19772 
                    return v19794 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v19799 : Async<US7> = _v19770 
            let _v19670 = v19799 
            #endif
            let v19800 : Async<US7> = _v19670 
            let v19805 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v19806 : Async<US8> = null |> unbox<Async<US8>>
            let _v19805 = v19806 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v19809 : Async<US8> = null |> unbox<Async<US8>>
            let _v19805 = v19809 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v19812 : Async<US8> = null |> unbox<Async<US8>>
            let _v19805 = v19812 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v19815 : unit = ()
            let _v19815 =
                async {
                    let! v19800 = v19800 
                    let v19816 : US7 = v19800 
                    let v19822 : US8 =
                        match v19816 with
                        | US7_0(v19817) -> (* C1of2 *)
                            US8_0(v19817)
                        | US7_1(v19819) -> (* C2of2 *)
                            US8_1(v19819)
                    return v19822 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v19823 : Async<US8> = _v19815 
            let _v19805 = v19823 
            #endif
#if FABLE_COMPILER_PYTHON
            let v19824 : unit = ()
            let _v19824 =
                async {
                    let! v19800 = v19800 
                    let v19825 : US7 = v19800 
                    let v19831 : US8 =
                        match v19825 with
                        | US7_0(v19826) -> (* C1of2 *)
                            US8_0(v19826)
                        | US7_1(v19828) -> (* C2of2 *)
                            US8_1(v19828)
                    return v19831 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v19832 : Async<US8> = _v19824 
            let _v19805 = v19832 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v19833 : unit = ()
            let _v19833 =
                async {
                    let! v19800 = v19800 
                    let v19834 : US7 = v19800 
                    let v19840 : US8 =
                        match v19834 with
                        | US7_0(v19835) -> (* C1of2 *)
                            US8_0(v19835)
                        | US7_1(v19837) -> (* C2of2 *)
                            US8_1(v19837)
                    return v19840 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v19841 : Async<US8> = _v19833 
            let _v19805 = v19841 
            #endif
#else
            let v19842 : unit = ()
            let _v19842 =
                async {
                    let! v19800 = v19800 
                    let v19843 : US7 = v19800 
                    let v19849 : US8 =
                        match v19843 with
                        | US7_0(v19844) -> (* C1of2 *)
                            US8_0(v19844)
                        | US7_1(v19846) -> (* C2of2 *)
                            US8_1(v19846)
                    return v19849 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v19850 : Async<US8> = _v19842 
            let _v19805 = v19850 
            #endif
            let v19851 : Async<US8> = _v19805 
            let v19856 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v19857 : Async<US6> = null |> unbox<Async<US6>>
            let _v19856 = v19857 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v19860 : Async<US6> = null |> unbox<Async<US6>>
            let _v19856 = v19860 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v19863 : Async<US6> = null |> unbox<Async<US6>>
            let _v19856 = v19863 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v19866 : unit = ()
            let _v19866 =
                async {
                    let! v19851 = v19851 
                    let v19867 : US8 = v19851 
                    let v19991 : US6 =
                        match v19867 with
                        | US8_1(v19870) -> (* Error *)
                            let v19871 : string = $"%A{v19870}"
                            let v19874 : string = "System.TimeoutException"
                            let v19875 : bool = v19871.Contains v19874 
                            if v19875 then
                                let v19878 : unit = ()
                                let v19879 : (unit -> unit) = closure16(v0)
                                let v19880 : unit = (fun () -> v19879 (); v19878) ()
                                US6_1
                            else
                                let v19921 : unit = ()
                                let v19922 : (unit -> unit) = closure17(v0, v19870)
                                let v19923 : unit = (fun () -> v19922 (); v19921) ()
                                US6_1
                        | US8_0(v19868) -> (* Ok *)
                            US6_0(v19868)
                    return v19991 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v19992 : Async<US6> = _v19866 
            let _v19856 = v19992 
            #endif
#if FABLE_COMPILER_PYTHON
            let v19993 : unit = ()
            let _v19993 =
                async {
                    let! v19851 = v19851 
                    let v19994 : US8 = v19851 
                    let v20118 : US6 =
                        match v19994 with
                        | US8_1(v19997) -> (* Error *)
                            let v19998 : string = $"%A{v19997}"
                            let v20001 : string = "System.TimeoutException"
                            let v20002 : bool = v19998.Contains v20001 
                            if v20002 then
                                let v20005 : unit = ()
                                let v20006 : (unit -> unit) = closure16(v0)
                                let v20007 : unit = (fun () -> v20006 (); v20005) ()
                                US6_1
                            else
                                let v20048 : unit = ()
                                let v20049 : (unit -> unit) = closure17(v0, v19997)
                                let v20050 : unit = (fun () -> v20049 (); v20048) ()
                                US6_1
                        | US8_0(v19995) -> (* Ok *)
                            US6_0(v19995)
                    return v20118 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v20119 : Async<US6> = _v19993 
            let _v19856 = v20119 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v20120 : unit = ()
            let _v20120 =
                async {
                    let! v19851 = v19851 
                    let v20121 : US8 = v19851 
                    let v20245 : US6 =
                        match v20121 with
                        | US8_1(v20124) -> (* Error *)
                            let v20125 : string = $"%A{v20124}"
                            let v20128 : string = "System.TimeoutException"
                            let v20129 : bool = v20125.Contains v20128 
                            if v20129 then
                                let v20132 : unit = ()
                                let v20133 : (unit -> unit) = closure16(v0)
                                let v20134 : unit = (fun () -> v20133 (); v20132) ()
                                US6_1
                            else
                                let v20175 : unit = ()
                                let v20176 : (unit -> unit) = closure17(v0, v20124)
                                let v20177 : unit = (fun () -> v20176 (); v20175) ()
                                US6_1
                        | US8_0(v20122) -> (* Ok *)
                            US6_0(v20122)
                    return v20245 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v20246 : Async<US6> = _v20120 
            let _v19856 = v20246 
            #endif
#else
            let v20247 : unit = ()
            let _v20247 =
                async {
                    let! v19851 = v19851 
                    let v20248 : US8 = v19851 
                    let v20372 : US6 =
                        match v20248 with
                        | US8_1(v20251) -> (* Error *)
                            let v20252 : string = $"%A{v20251}"
                            let v20255 : string = "System.TimeoutException"
                            let v20256 : bool = v20252.Contains v20255 
                            if v20256 then
                                let v20259 : unit = ()
                                let v20260 : (unit -> unit) = closure16(v0)
                                let v20261 : unit = (fun () -> v20260 (); v20259) ()
                                US6_1
                            else
                                let v20302 : unit = ()
                                let v20303 : (unit -> unit) = closure17(v0, v20251)
                                let v20304 : unit = (fun () -> v20303 (); v20302) ()
                                US6_1
                        | US8_0(v20249) -> (* Ok *)
                            US6_0(v20249)
                    return v20372 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v20373 : Async<US6> = _v20247 
            let _v19856 = v20373 
            #endif
            let v20374 : Async<US6> = _v19856 
            return! v20374 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v20379 : Async<US6> = _v19629 
    let _v18117 = v20379 
    #endif
#else
    let v20380 : unit = ()
    let _v20380 =
        async {
            let v20381 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v20382 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v20381 = v20382 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v20385 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v20381 = v20385 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v20388 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v20381 = v20388 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v20391 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v20381 = v20391 
            #endif
#if FABLE_COMPILER_PYTHON
            let v20392 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v20381 = v20392 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v20393 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v20381 = v20393 
            #endif
#else
            let v20394 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v20381 = v20394 
            #endif
            let v20395 : Async<Async<bool>> = _v20381 
            let! v20395 = v20395 
            let v20400 : Async<bool> = v20395 
            let v20401 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v20402 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v20403 : Async<Choice<bool, exn>> = v20402 v20400
            let _v20401 = v20403 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v20404 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v20405 : Async<Choice<bool, exn>> = v20404 v20400
            let _v20401 = v20405 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v20406 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v20407 : Async<Choice<bool, exn>> = v20406 v20400
            let _v20401 = v20407 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v20408 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v20409 : Async<Choice<bool, exn>> = v20408 v20400
            let _v20401 = v20409 
            #endif
#if FABLE_COMPILER_PYTHON
            let v20410 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v20411 : Async<Choice<bool, exn>> = v20410 v20400
            let _v20401 = v20411 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v20412 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v20413 : Async<Choice<bool, exn>> = v20412 v20400
            let _v20401 = v20413 
            #endif
#else
            let v20414 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v20415 : Async<Choice<bool, exn>> = v20414 v20400
            let _v20401 = v20415 
            #endif
            let v20416 : Async<Choice<bool, exn>> = _v20401 
            let v20421 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v20422 : Async<US7> = null |> unbox<Async<US7>>
            let _v20421 = v20422 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v20425 : Async<US7> = null |> unbox<Async<US7>>
            let _v20421 = v20425 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v20428 : Async<US7> = null |> unbox<Async<US7>>
            let _v20421 = v20428 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v20431 : unit = ()
            let _v20431 =
                async {
                    let! v20416 = v20416 
                    let v20432 : Choice<bool, exn> = v20416 
                    let v20433 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v20434 : US7 = null |> unbox<US7>
                    let _v20433 = v20434 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v20437 : US7 = null |> unbox<US7>
                    let _v20433 = v20437 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v20440 : US7 = null |> unbox<US7>
                    let _v20433 = v20440 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v20443 : US7 = null |> unbox<US7>
                    let _v20433 = v20443 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v20446 : US7 = null |> unbox<US7>
                    let _v20433 = v20446 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v20449 : (bool -> US7) = method22()
                    let v20450 : (exn -> US7) = method23()
                    let v20451 : US7 = match v20432 with Choice1Of2 x -> v20449 x | Choice2Of2 x -> v20450 x
                    let _v20433 = v20451 
                    #endif
#else
                    let v20452 : (bool -> US7) = method22()
                    let v20453 : (exn -> US7) = method23()
                    let v20454 : US7 = match v20432 with Choice1Of2 x -> v20452 x | Choice2Of2 x -> v20453 x
                    let _v20433 = v20454 
                    #endif
                    let v20455 : US7 = _v20433 
                    return v20455 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v20460 : Async<US7> = _v20431 
            let _v20421 = v20460 
            #endif
#if FABLE_COMPILER_PYTHON
            let v20461 : unit = ()
            let _v20461 =
                async {
                    let! v20416 = v20416 
                    let v20462 : Choice<bool, exn> = v20416 
                    let v20463 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v20464 : US7 = null |> unbox<US7>
                    let _v20463 = v20464 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v20467 : US7 = null |> unbox<US7>
                    let _v20463 = v20467 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v20470 : US7 = null |> unbox<US7>
                    let _v20463 = v20470 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v20473 : US7 = null |> unbox<US7>
                    let _v20463 = v20473 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v20476 : US7 = null |> unbox<US7>
                    let _v20463 = v20476 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v20479 : (bool -> US7) = method22()
                    let v20480 : (exn -> US7) = method23()
                    let v20481 : US7 = match v20462 with Choice1Of2 x -> v20479 x | Choice2Of2 x -> v20480 x
                    let _v20463 = v20481 
                    #endif
#else
                    let v20482 : (bool -> US7) = method22()
                    let v20483 : (exn -> US7) = method23()
                    let v20484 : US7 = match v20462 with Choice1Of2 x -> v20482 x | Choice2Of2 x -> v20483 x
                    let _v20463 = v20484 
                    #endif
                    let v20485 : US7 = _v20463 
                    return v20485 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v20490 : Async<US7> = _v20461 
            let _v20421 = v20490 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v20491 : unit = ()
            let _v20491 =
                async {
                    let! v20416 = v20416 
                    let v20492 : Choice<bool, exn> = v20416 
                    let v20493 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v20494 : US7 = null |> unbox<US7>
                    let _v20493 = v20494 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v20497 : US7 = null |> unbox<US7>
                    let _v20493 = v20497 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v20500 : US7 = null |> unbox<US7>
                    let _v20493 = v20500 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v20503 : US7 = null |> unbox<US7>
                    let _v20493 = v20503 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v20506 : US7 = null |> unbox<US7>
                    let _v20493 = v20506 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v20509 : (bool -> US7) = method22()
                    let v20510 : (exn -> US7) = method23()
                    let v20511 : US7 = match v20492 with Choice1Of2 x -> v20509 x | Choice2Of2 x -> v20510 x
                    let _v20493 = v20511 
                    #endif
#else
                    let v20512 : (bool -> US7) = method22()
                    let v20513 : (exn -> US7) = method23()
                    let v20514 : US7 = match v20492 with Choice1Of2 x -> v20512 x | Choice2Of2 x -> v20513 x
                    let _v20493 = v20514 
                    #endif
                    let v20515 : US7 = _v20493 
                    return v20515 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v20520 : Async<US7> = _v20491 
            let _v20421 = v20520 
            #endif
#else
            let v20521 : unit = ()
            let _v20521 =
                async {
                    let! v20416 = v20416 
                    let v20522 : Choice<bool, exn> = v20416 
                    let v20523 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v20524 : US7 = null |> unbox<US7>
                    let _v20523 = v20524 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v20527 : US7 = null |> unbox<US7>
                    let _v20523 = v20527 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v20530 : US7 = null |> unbox<US7>
                    let _v20523 = v20530 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v20533 : US7 = null |> unbox<US7>
                    let _v20523 = v20533 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v20536 : US7 = null |> unbox<US7>
                    let _v20523 = v20536 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v20539 : (bool -> US7) = method22()
                    let v20540 : (exn -> US7) = method23()
                    let v20541 : US7 = match v20522 with Choice1Of2 x -> v20539 x | Choice2Of2 x -> v20540 x
                    let _v20523 = v20541 
                    #endif
#else
                    let v20542 : (bool -> US7) = method22()
                    let v20543 : (exn -> US7) = method23()
                    let v20544 : US7 = match v20522 with Choice1Of2 x -> v20542 x | Choice2Of2 x -> v20543 x
                    let _v20523 = v20544 
                    #endif
                    let v20545 : US7 = _v20523 
                    return v20545 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v20550 : Async<US7> = _v20521 
            let _v20421 = v20550 
            #endif
            let v20551 : Async<US7> = _v20421 
            let v20556 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v20557 : Async<US8> = null |> unbox<Async<US8>>
            let _v20556 = v20557 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v20560 : Async<US8> = null |> unbox<Async<US8>>
            let _v20556 = v20560 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v20563 : Async<US8> = null |> unbox<Async<US8>>
            let _v20556 = v20563 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v20566 : unit = ()
            let _v20566 =
                async {
                    let! v20551 = v20551 
                    let v20567 : US7 = v20551 
                    let v20573 : US8 =
                        match v20567 with
                        | US7_0(v20568) -> (* C1of2 *)
                            US8_0(v20568)
                        | US7_1(v20570) -> (* C2of2 *)
                            US8_1(v20570)
                    return v20573 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v20574 : Async<US8> = _v20566 
            let _v20556 = v20574 
            #endif
#if FABLE_COMPILER_PYTHON
            let v20575 : unit = ()
            let _v20575 =
                async {
                    let! v20551 = v20551 
                    let v20576 : US7 = v20551 
                    let v20582 : US8 =
                        match v20576 with
                        | US7_0(v20577) -> (* C1of2 *)
                            US8_0(v20577)
                        | US7_1(v20579) -> (* C2of2 *)
                            US8_1(v20579)
                    return v20582 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v20583 : Async<US8> = _v20575 
            let _v20556 = v20583 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v20584 : unit = ()
            let _v20584 =
                async {
                    let! v20551 = v20551 
                    let v20585 : US7 = v20551 
                    let v20591 : US8 =
                        match v20585 with
                        | US7_0(v20586) -> (* C1of2 *)
                            US8_0(v20586)
                        | US7_1(v20588) -> (* C2of2 *)
                            US8_1(v20588)
                    return v20591 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v20592 : Async<US8> = _v20584 
            let _v20556 = v20592 
            #endif
#else
            let v20593 : unit = ()
            let _v20593 =
                async {
                    let! v20551 = v20551 
                    let v20594 : US7 = v20551 
                    let v20600 : US8 =
                        match v20594 with
                        | US7_0(v20595) -> (* C1of2 *)
                            US8_0(v20595)
                        | US7_1(v20597) -> (* C2of2 *)
                            US8_1(v20597)
                    return v20600 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v20601 : Async<US8> = _v20593 
            let _v20556 = v20601 
            #endif
            let v20602 : Async<US8> = _v20556 
            let v20607 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v20608 : Async<US6> = null |> unbox<Async<US6>>
            let _v20607 = v20608 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v20611 : Async<US6> = null |> unbox<Async<US6>>
            let _v20607 = v20611 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v20614 : Async<US6> = null |> unbox<Async<US6>>
            let _v20607 = v20614 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v20617 : unit = ()
            let _v20617 =
                async {
                    let! v20602 = v20602 
                    let v20618 : US8 = v20602 
                    let v20742 : US6 =
                        match v20618 with
                        | US8_1(v20621) -> (* Error *)
                            let v20622 : string = $"%A{v20621}"
                            let v20625 : string = "System.TimeoutException"
                            let v20626 : bool = v20622.Contains v20625 
                            if v20626 then
                                let v20629 : unit = ()
                                let v20630 : (unit -> unit) = closure16(v0)
                                let v20631 : unit = (fun () -> v20630 (); v20629) ()
                                US6_1
                            else
                                let v20672 : unit = ()
                                let v20673 : (unit -> unit) = closure17(v0, v20621)
                                let v20674 : unit = (fun () -> v20673 (); v20672) ()
                                US6_1
                        | US8_0(v20619) -> (* Ok *)
                            US6_0(v20619)
                    return v20742 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v20743 : Async<US6> = _v20617 
            let _v20607 = v20743 
            #endif
#if FABLE_COMPILER_PYTHON
            let v20744 : unit = ()
            let _v20744 =
                async {
                    let! v20602 = v20602 
                    let v20745 : US8 = v20602 
                    let v20869 : US6 =
                        match v20745 with
                        | US8_1(v20748) -> (* Error *)
                            let v20749 : string = $"%A{v20748}"
                            let v20752 : string = "System.TimeoutException"
                            let v20753 : bool = v20749.Contains v20752 
                            if v20753 then
                                let v20756 : unit = ()
                                let v20757 : (unit -> unit) = closure16(v0)
                                let v20758 : unit = (fun () -> v20757 (); v20756) ()
                                US6_1
                            else
                                let v20799 : unit = ()
                                let v20800 : (unit -> unit) = closure17(v0, v20748)
                                let v20801 : unit = (fun () -> v20800 (); v20799) ()
                                US6_1
                        | US8_0(v20746) -> (* Ok *)
                            US6_0(v20746)
                    return v20869 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v20870 : Async<US6> = _v20744 
            let _v20607 = v20870 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v20871 : unit = ()
            let _v20871 =
                async {
                    let! v20602 = v20602 
                    let v20872 : US8 = v20602 
                    let v20996 : US6 =
                        match v20872 with
                        | US8_1(v20875) -> (* Error *)
                            let v20876 : string = $"%A{v20875}"
                            let v20879 : string = "System.TimeoutException"
                            let v20880 : bool = v20876.Contains v20879 
                            if v20880 then
                                let v20883 : unit = ()
                                let v20884 : (unit -> unit) = closure16(v0)
                                let v20885 : unit = (fun () -> v20884 (); v20883) ()
                                US6_1
                            else
                                let v20926 : unit = ()
                                let v20927 : (unit -> unit) = closure17(v0, v20875)
                                let v20928 : unit = (fun () -> v20927 (); v20926) ()
                                US6_1
                        | US8_0(v20873) -> (* Ok *)
                            US6_0(v20873)
                    return v20996 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v20997 : Async<US6> = _v20871 
            let _v20607 = v20997 
            #endif
#else
            let v20998 : unit = ()
            let _v20998 =
                async {
                    let! v20602 = v20602 
                    let v20999 : US8 = v20602 
                    let v21123 : US6 =
                        match v20999 with
                        | US8_1(v21002) -> (* Error *)
                            let v21003 : string = $"%A{v21002}"
                            let v21006 : string = "System.TimeoutException"
                            let v21007 : bool = v21003.Contains v21006 
                            if v21007 then
                                let v21010 : unit = ()
                                let v21011 : (unit -> unit) = closure16(v0)
                                let v21012 : unit = (fun () -> v21011 (); v21010) ()
                                US6_1
                            else
                                let v21053 : unit = ()
                                let v21054 : (unit -> unit) = closure17(v0, v21002)
                                let v21055 : unit = (fun () -> v21054 (); v21053) ()
                                US6_1
                        | US8_0(v21000) -> (* Ok *)
                            US6_0(v21000)
                    return v21123 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v21124 : Async<US6> = _v20998 
            let _v20607 = v21124 
            #endif
            let v21125 : Async<US6> = _v20607 
            return! v21125 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v21130 : Async<US6> = _v20380 
    let _v18117 = v21130 
    #endif
    let v21131 : Async<US6> = _v18117 
    let _v2 = v21131 
    #endif
    let v21136 : Async<US6> = _v2 
    v21136
and method20 (v0 : int32, v1 : string, v2 : int32) : Async<bool> =
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
            let v14 : Async<bool> = method6(v1, v2)
            let v15 : Async<US6> = method21(v0, v14)
            let! v15 = v15 
            let v16 : US6 = v15 
            let v19 : bool =
                match v16 with
                | US6_1 -> (* None *)
                    false
                | US6_0(v17) -> (* Some *)
                    v17
            return v19 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v20 : Async<bool> = _v13 
    let _v3 = v20 
    #endif
#if FABLE_COMPILER_PYTHON
    let v21 : unit = ()
    let _v21 =
        async {
            let v22 : Async<bool> = method6(v1, v2)
            let v23 : Async<US6> = method21(v0, v22)
            let! v23 = v23 
            let v24 : US6 = v23 
            let v27 : bool =
                match v24 with
                | US6_1 -> (* None *)
                    false
                | US6_0(v25) -> (* Some *)
                    v25
            return v27 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v28 : Async<bool> = _v21 
    let _v3 = v28 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v29 : unit = ()
    let _v29 =
        async {
            let v30 : Async<bool> = method6(v1, v2)
            let v31 : Async<US6> = method21(v0, v30)
            let! v31 = v31 
            let v32 : US6 = v31 
            let v35 : bool =
                match v32 with
                | US6_1 -> (* None *)
                    false
                | US6_0(v33) -> (* Some *)
                    v33
            return v35 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v36 : Async<bool> = _v29 
    let _v3 = v36 
    #endif
#else
    let v37 : unit = ()
    let _v37 =
        async {
            let v38 : Async<bool> = method6(v1, v2)
            let v39 : Async<US6> = method21(v0, v38)
            let! v39 = v39 
            let v40 : US6 = v39 
            let v43 : bool =
                match v40 with
                | US6_1 -> (* None *)
                    false
                | US6_0(v41) -> (* Some *)
                    v41
            return v43 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v44 : Async<bool> = _v37 
    let _v3 = v44 
    #endif
    let v45 : Async<bool> = _v3 
    v45
and closure13 (v0 : int32, v1 : string) (v2 : int32) : Async<bool> =
    method20(v0, v1, v2)
and closure12 (v0 : int32) (v1 : string) : (int32 -> Async<bool>) =
    closure13(v0, v1)
and closure11 () (v0 : int32) : (string -> (int32 -> Async<bool>)) =
    closure12(v0)
and closure22 () (v0 : int32) : US9 =
    US9_0(v0)
and method31 () : (int32 -> US9) =
    closure22()
and method33 (v0 : int32, v1 : int64, v2 : int32 option, v3 : bool) : string =
    let v4 : string = method14()
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
and method32 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : int32, v9 : int64, v10 : int32 option, v11 : bool) : string =
    let v12 : string = method33(v8, v9, v10, v11)
    let v13 : int64 = v0.l0
    let v14 : string = "networking.wait_for_port_access"
    let v15 : string = $"{v6} {v7} #{v13} %s{v14} / {v12}"
    method18(v15)
and closure23 (v0 : int32 option, v1 : bool, v2 : int32, v3 : int64) () : unit =
    let v4 : US0 = US0_0
    let v5 : bool = method7(v4)
    if v5 then
        let v6 : unit = ()
        let v7 : (unit -> unit) = closure0()
        let v8 : unit = (fun () -> v7 (); v6) ()
        let struct (v22 : Mut0, v23 : Mut1, v24 : Mut2, v25 : Mut3, v26 : Mut4, v27 : int64 option) = TraceState.trace_state.Value
        let v40 : string = method8(v22, v23, v24, v25, v26, v27)
        let v41 : string = method12()
        let v42 : string = method32(v22, v23, v24, v25, v26, v27, v40, v41, v2, v3, v0, v1)
        method19(v42)
and method30 (v0 : int32 option, v1 : bool, v2 : string, v3 : int32, v4 : int64) : Async<int64> =
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
            let v16 : (int32 -> US9) = method31()
            let v17 : US9 option = v0 |> Option.map v16 
            let v28 : US9 = US9_1
            let v29 : US9 = v17 |> Option.defaultValue v28 
            let v37 : Async<bool> =
                match v29 with
                | US9_1 -> (* None *)
                    method6(v2, v3)
                | US9_0(v34) -> (* Some *)
                    method20(v34, v2, v3)
            let! v37 = v37 
            let v38 : bool = v37 
            let v39 : bool = v38 = v1
            if v39 then
                return v4 
                (*
                ()
            else
                *) else
                let v40 : int64 = v4 % 100L
                let v41 : bool = v40 = 0L
                if v41 then
                    let v42 : unit = ()
                    let v43 : (unit -> unit) = closure23(v0, v1, v3, v4)
                    let v44 : unit = (fun () -> v43 (); v42) ()
                    ()
                let v84 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v85 : (int32 -> Async<unit>) = Async.Sleep
                let v86 : Async<unit> = v85 10
                let _v84 = v86 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v87 : (int32 -> Async<unit>) = Async.Sleep
                let v88 : Async<unit> = v87 10
                let _v84 = v88 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v89 : (int32 -> Async<unit>) = Async.Sleep
                let v90 : Async<unit> = v89 10
                let _v84 = v90 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v91 : (int32 -> Async<unit>) = Async.Sleep
                let v92 : Async<unit> = v91 10
                let _v84 = v92 
                #endif
#if FABLE_COMPILER_PYTHON
                let v93 : (int32 -> Async<unit>) = Async.Sleep
                let v94 : Async<unit> = v93 10
                let _v84 = v94 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v95 : (int32 -> Async<unit>) = Async.Sleep
                let v96 : Async<unit> = v95 10
                let _v84 = v96 
                #endif
#else
                let v97 : (int32 -> Async<unit>) = Async.Sleep
                let v98 : Async<unit> = v97 10
                let _v84 = v98 
                #endif
                let v99 : Async<unit> = _v84 
                do! v99 
                let v104 : int64 = v4 + 1L
                let v105 : Async<int64> = method30(v0, v1, v2, v3, v104)
                return! v105 
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
    let v106 : Async<int64> = _v15 
    let _v5 = v106 
    #endif
#if FABLE_COMPILER_PYTHON
    let v107 : unit = ()
    let _v107 =
        async {
            let v108 : (int32 -> US9) = method31()
            let v109 : US9 option = v0 |> Option.map v108 
            let v120 : US9 = US9_1
            let v121 : US9 = v109 |> Option.defaultValue v120 
            let v129 : Async<bool> =
                match v121 with
                | US9_1 -> (* None *)
                    method6(v2, v3)
                | US9_0(v126) -> (* Some *)
                    method20(v126, v2, v3)
            let! v129 = v129 
            let v130 : bool = v129 
            let v131 : bool = v130 = v1
            if v131 then
                return v4 
                (*
                ()
            else
                *) else
                let v132 : int64 = v4 % 100L
                let v133 : bool = v132 = 0L
                if v133 then
                    let v134 : unit = ()
                    let v135 : (unit -> unit) = closure23(v0, v1, v3, v4)
                    let v136 : unit = (fun () -> v135 (); v134) ()
                    ()
                let v176 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v177 : (int32 -> Async<unit>) = Async.Sleep
                let v178 : Async<unit> = v177 10
                let _v176 = v178 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v179 : (int32 -> Async<unit>) = Async.Sleep
                let v180 : Async<unit> = v179 10
                let _v176 = v180 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v181 : (int32 -> Async<unit>) = Async.Sleep
                let v182 : Async<unit> = v181 10
                let _v176 = v182 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v183 : (int32 -> Async<unit>) = Async.Sleep
                let v184 : Async<unit> = v183 10
                let _v176 = v184 
                #endif
#if FABLE_COMPILER_PYTHON
                let v185 : (int32 -> Async<unit>) = Async.Sleep
                let v186 : Async<unit> = v185 10
                let _v176 = v186 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v187 : (int32 -> Async<unit>) = Async.Sleep
                let v188 : Async<unit> = v187 10
                let _v176 = v188 
                #endif
#else
                let v189 : (int32 -> Async<unit>) = Async.Sleep
                let v190 : Async<unit> = v189 10
                let _v176 = v190 
                #endif
                let v191 : Async<unit> = _v176 
                do! v191 
                let v196 : int64 = v4 + 1L
                let v197 : Async<int64> = method30(v0, v1, v2, v3, v196)
                return! v197 
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
    let v198 : Async<int64> = _v107 
    let _v5 = v198 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v199 : unit = ()
    let _v199 =
        async {
            let v200 : (int32 -> US9) = method31()
            let v201 : US9 option = v0 |> Option.map v200 
            let v212 : US9 = US9_1
            let v213 : US9 = v201 |> Option.defaultValue v212 
            let v221 : Async<bool> =
                match v213 with
                | US9_1 -> (* None *)
                    method6(v2, v3)
                | US9_0(v218) -> (* Some *)
                    method20(v218, v2, v3)
            let! v221 = v221 
            let v222 : bool = v221 
            let v223 : bool = v222 = v1
            if v223 then
                return v4 
                (*
                ()
            else
                *) else
                let v224 : int64 = v4 % 100L
                let v225 : bool = v224 = 0L
                if v225 then
                    let v226 : unit = ()
                    let v227 : (unit -> unit) = closure23(v0, v1, v3, v4)
                    let v228 : unit = (fun () -> v227 (); v226) ()
                    ()
                let v268 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v269 : (int32 -> Async<unit>) = Async.Sleep
                let v270 : Async<unit> = v269 10
                let _v268 = v270 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v271 : (int32 -> Async<unit>) = Async.Sleep
                let v272 : Async<unit> = v271 10
                let _v268 = v272 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v273 : (int32 -> Async<unit>) = Async.Sleep
                let v274 : Async<unit> = v273 10
                let _v268 = v274 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v275 : (int32 -> Async<unit>) = Async.Sleep
                let v276 : Async<unit> = v275 10
                let _v268 = v276 
                #endif
#if FABLE_COMPILER_PYTHON
                let v277 : (int32 -> Async<unit>) = Async.Sleep
                let v278 : Async<unit> = v277 10
                let _v268 = v278 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v279 : (int32 -> Async<unit>) = Async.Sleep
                let v280 : Async<unit> = v279 10
                let _v268 = v280 
                #endif
#else
                let v281 : (int32 -> Async<unit>) = Async.Sleep
                let v282 : Async<unit> = v281 10
                let _v268 = v282 
                #endif
                let v283 : Async<unit> = _v268 
                do! v283 
                let v288 : int64 = v4 + 1L
                let v289 : Async<int64> = method30(v0, v1, v2, v3, v288)
                return! v289 
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
    let v290 : Async<int64> = _v199 
    let _v5 = v290 
    #endif
#else
    let v291 : unit = ()
    let _v291 =
        async {
            let v292 : (int32 -> US9) = method31()
            let v293 : US9 option = v0 |> Option.map v292 
            let v304 : US9 = US9_1
            let v305 : US9 = v293 |> Option.defaultValue v304 
            let v313 : Async<bool> =
                match v305 with
                | US9_1 -> (* None *)
                    method6(v2, v3)
                | US9_0(v310) -> (* Some *)
                    method20(v310, v2, v3)
            let! v313 = v313 
            let v314 : bool = v313 
            let v315 : bool = v314 = v1
            if v315 then
                return v4 
                (*
                ()
            else
                *) else
                let v316 : int64 = v4 % 100L
                let v317 : bool = v316 = 0L
                if v317 then
                    let v318 : unit = ()
                    let v319 : (unit -> unit) = closure23(v0, v1, v3, v4)
                    let v320 : unit = (fun () -> v319 (); v318) ()
                    ()
                let v360 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v361 : (int32 -> Async<unit>) = Async.Sleep
                let v362 : Async<unit> = v361 10
                let _v360 = v362 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v363 : (int32 -> Async<unit>) = Async.Sleep
                let v364 : Async<unit> = v363 10
                let _v360 = v364 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v365 : (int32 -> Async<unit>) = Async.Sleep
                let v366 : Async<unit> = v365 10
                let _v360 = v366 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v367 : (int32 -> Async<unit>) = Async.Sleep
                let v368 : Async<unit> = v367 10
                let _v360 = v368 
                #endif
#if FABLE_COMPILER_PYTHON
                let v369 : (int32 -> Async<unit>) = Async.Sleep
                let v370 : Async<unit> = v369 10
                let _v360 = v370 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v371 : (int32 -> Async<unit>) = Async.Sleep
                let v372 : Async<unit> = v371 10
                let _v360 = v372 
                #endif
#else
                let v373 : (int32 -> Async<unit>) = Async.Sleep
                let v374 : Async<unit> = v373 10
                let _v360 = v374 
                #endif
                let v375 : Async<unit> = _v360 
                do! v375 
                let v380 : int64 = v4 + 1L
                let v381 : Async<int64> = method30(v0, v1, v2, v3, v380)
                return! v381 
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
    let v382 : Async<int64> = _v291 
    let _v5 = v382 
    #endif
    let v383 : Async<int64> = _v5 
    v383
and method29 (v0 : int32 option, v1 : bool, v2 : string, v3 : int32) : Async<int64> =
    let v4 : int64 = 1L
    method30(v0, v1, v2, v3, v4)
and closure21 (v0 : int32 option, v1 : bool, v2 : string) (v3 : int32) : Async<int64> =
    method29(v0, v1, v2, v3)
and closure20 (v0 : int32 option, v1 : bool) (v2 : string) : (int32 -> Async<int64>) =
    closure21(v0, v1, v2)
and closure19 (v0 : int32 option) (v1 : bool) : (string -> (int32 -> Async<int64>)) =
    closure20(v0, v1)
and closure18 () (v0 : int32 option) : (bool -> (string -> (int32 -> Async<int64>))) =
    closure19(v0)
and method35 (v0 : int32 option, v1 : string, v2 : int32) : Async<int32> =
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
            let v14 : (int32 -> US9) = method31()
            let v15 : US9 option = v0 |> Option.map v14 
            let v26 : US9 = US9_1
            let v27 : US9 = v15 |> Option.defaultValue v26 
            let v35 : Async<bool> =
                match v27 with
                | US9_1 -> (* None *)
                    method6(v1, v2)
                | US9_0(v32) -> (* Some *)
                    method20(v32, v1, v2)
            let! v35 = v35 
            let v36 : bool = v35 
            let v37 : bool = v36 = false
            if v37 then
                return v2 
                (*
                ()
            else
                *) else
                let v38 : int32 = v2 + 1
                let v39 : Async<int32> = method35(v0, v1, v38)
                return! v39 
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
    let v40 : Async<int32> = _v13 
    let _v3 = v40 
    #endif
#if FABLE_COMPILER_PYTHON
    let v41 : unit = ()
    let _v41 =
        async {
            let v42 : (int32 -> US9) = method31()
            let v43 : US9 option = v0 |> Option.map v42 
            let v54 : US9 = US9_1
            let v55 : US9 = v43 |> Option.defaultValue v54 
            let v63 : Async<bool> =
                match v55 with
                | US9_1 -> (* None *)
                    method6(v1, v2)
                | US9_0(v60) -> (* Some *)
                    method20(v60, v1, v2)
            let! v63 = v63 
            let v64 : bool = v63 
            let v65 : bool = v64 = false
            if v65 then
                return v2 
                (*
                ()
            else
                *) else
                let v66 : int32 = v2 + 1
                let v67 : Async<int32> = method35(v0, v1, v66)
                return! v67 
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
    let v68 : Async<int32> = _v41 
    let _v3 = v68 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v69 : unit = ()
    let _v69 =
        async {
            let v70 : (int32 -> US9) = method31()
            let v71 : US9 option = v0 |> Option.map v70 
            let v82 : US9 = US9_1
            let v83 : US9 = v71 |> Option.defaultValue v82 
            let v91 : Async<bool> =
                match v83 with
                | US9_1 -> (* None *)
                    method6(v1, v2)
                | US9_0(v88) -> (* Some *)
                    method20(v88, v1, v2)
            let! v91 = v91 
            let v92 : bool = v91 
            let v93 : bool = v92 = false
            if v93 then
                return v2 
                (*
                ()
            else
                *) else
                let v94 : int32 = v2 + 1
                let v95 : Async<int32> = method35(v0, v1, v94)
                return! v95 
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
    let v96 : Async<int32> = _v69 
    let _v3 = v96 
    #endif
#else
    let v97 : unit = ()
    let _v97 =
        async {
            let v98 : (int32 -> US9) = method31()
            let v99 : US9 option = v0 |> Option.map v98 
            let v110 : US9 = US9_1
            let v111 : US9 = v99 |> Option.defaultValue v110 
            let v119 : Async<bool> =
                match v111 with
                | US9_1 -> (* None *)
                    method6(v1, v2)
                | US9_0(v116) -> (* Some *)
                    method20(v116, v1, v2)
            let! v119 = v119 
            let v120 : bool = v119 
            let v121 : bool = v120 = false
            if v121 then
                return v2 
                (*
                ()
            else
                *) else
                let v122 : int32 = v2 + 1
                let v123 : Async<int32> = method35(v0, v1, v122)
                return! v123 
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
    let v124 : Async<int32> = _v97 
    let _v3 = v124 
    #endif
    let v125 : Async<int32> = _v3 
    v125
and method34 (v0 : int32 option, v1 : string, v2 : int32) : Async<int32> =
    method35(v0, v1, v2)
and closure26 (v0 : int32 option, v1 : string) (v2 : int32) : Async<int32> =
    method34(v0, v1, v2)
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
